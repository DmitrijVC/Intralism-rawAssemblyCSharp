using System;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002BB RID: 699
	[RequireComponent(typeof(ScrollRect))]
	[AddComponentMenu("UI/Extensions/ScrollRectLinker")]
	public class ScrollRectLinker : MonoBehaviour
	{
		// Token: 0x0600A757 RID: 42839 RVA: 0x003E2334 File Offset: 0x003E0534
		private void PHHNJPDDFPJ(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A758 RID: 42840 RVA: 0x003E2388 File Offset: 0x003E0588
		private void HCEFEBFPBOB(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A759 RID: 42841 RVA: 0x003E23DC File Offset: 0x003E05DC
		private void GJFAFLIMCPK(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A75A RID: 42842 RVA: 0x003E242D File Offset: 0x003E062D
		private void GOBHPAJFFDB()
		{
			this.GIGHNDOLPBN = base.GetComponent<ScrollRect>();
			if (this.controllingScrollRect != null)
			{
				this.controllingScrollRect.onValueChanged.AddListener(new UnityAction<Vector2>(this.DKIJJDKMMPL));
			}
		}

		// Token: 0x0600A75B RID: 42843 RVA: 0x003E2468 File Offset: 0x003E0668
		private void MJEKCMFNCCD(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A75C RID: 42844 RVA: 0x003E24BC File Offset: 0x003E06BC
		private void KFPAHCKJAJD(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A75D RID: 42845 RVA: 0x003E2510 File Offset: 0x003E0710
		private void MIOIJDPBAGO(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A75E RID: 42846 RVA: 0x003E2564 File Offset: 0x003E0764
		private void HBDNDDKLMMF(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A75F RID: 42847 RVA: 0x003E25B5 File Offset: 0x003E07B5
		private void MMPOJCFOGJJ()
		{
			this.GIGHNDOLPBN = base.GetComponent<ScrollRect>();
			if (this.controllingScrollRect != null)
			{
				this.controllingScrollRect.onValueChanged.AddListener(new UnityAction<Vector2>(this.HCEFEBFPBOB));
			}
		}

		// Token: 0x0600A760 RID: 42848 RVA: 0x003E25F0 File Offset: 0x003E07F0
		private void MKBPIEHOICH(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A761 RID: 42849 RVA: 0x003E2644 File Offset: 0x003E0844
		private void BHICGEONKFF(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A762 RID: 42850 RVA: 0x003E2698 File Offset: 0x003E0898
		private void CGPGCNHCFDM(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A764 RID: 42852 RVA: 0x003E26F8 File Offset: 0x003E08F8
		private void CIAHIJIOFIE()
		{
			this.GIGHNDOLPBN = base.GetComponent<ScrollRect>();
			if (this.controllingScrollRect != null)
			{
				this.controllingScrollRect.onValueChanged.AddListener(new UnityAction<Vector2>(this.GOKKFFEMEEP));
			}
		}

		// Token: 0x0600A765 RID: 42853 RVA: 0x003E2733 File Offset: 0x003E0933
		private void EIFCCFBJKOO()
		{
			this.GIGHNDOLPBN = base.GetComponent<ScrollRect>();
			if (this.controllingScrollRect != null)
			{
				this.controllingScrollRect.onValueChanged.AddListener(new UnityAction<Vector2>(this.INGDDNIBJIO));
			}
		}

		// Token: 0x0600A766 RID: 42854 RVA: 0x003E2770 File Offset: 0x003E0970
		private void CCNODLEBOHD(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A767 RID: 42855 RVA: 0x003E27C1 File Offset: 0x003E09C1
		private void LFFAKAOAOCN()
		{
			this.GIGHNDOLPBN = base.GetComponent<ScrollRect>();
			if (this.controllingScrollRect != null)
			{
				this.controllingScrollRect.onValueChanged.AddListener(new UnityAction<Vector2>(this.BHOIMDAKHHC));
			}
		}

		// Token: 0x0600A768 RID: 42856 RVA: 0x003E27FC File Offset: 0x003E09FC
		private void LOMHIIKFFEP()
		{
			this.GIGHNDOLPBN = base.GetComponent<ScrollRect>();
			if (this.controllingScrollRect != null)
			{
				this.controllingScrollRect.onValueChanged.AddListener(new UnityAction<Vector2>(this.FOMEECFPFMC));
			}
		}

		// Token: 0x0600A769 RID: 42857 RVA: 0x003E2838 File Offset: 0x003E0A38
		private void JGCDELJIMGN(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A76A RID: 42858 RVA: 0x003E288C File Offset: 0x003E0A8C
		private void NFHIIIOBFCD(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A76B RID: 42859 RVA: 0x003E28E0 File Offset: 0x003E0AE0
		private void MMDNFADFJOF(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A76C RID: 42860 RVA: 0x003E2934 File Offset: 0x003E0B34
		private void DKIJJDKMMPL(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A76D RID: 42861 RVA: 0x003E27C1 File Offset: 0x003E09C1
		private void BFIOIDMHPPL()
		{
			this.GIGHNDOLPBN = base.GetComponent<ScrollRect>();
			if (this.controllingScrollRect != null)
			{
				this.controllingScrollRect.onValueChanged.AddListener(new UnityAction<Vector2>(this.BHOIMDAKHHC));
			}
		}

		// Token: 0x0600A76E RID: 42862 RVA: 0x003E2988 File Offset: 0x003E0B88
		private void GOKKFFEMEEP(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A76F RID: 42863 RVA: 0x003E29DC File Offset: 0x003E0BDC
		private void DJPOBJCDHJM(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A770 RID: 42864 RVA: 0x003E2A2D File Offset: 0x003E0C2D
		private void DHNANELONED()
		{
			this.GIGHNDOLPBN = base.GetComponent<ScrollRect>();
			if (this.controllingScrollRect != null)
			{
				this.controllingScrollRect.onValueChanged.AddListener(new UnityAction<Vector2>(this.NFHIIIOBFCD));
			}
		}

		// Token: 0x0600A771 RID: 42865 RVA: 0x003E2A68 File Offset: 0x003E0C68
		private void GNKGAJADDAL(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A772 RID: 42866 RVA: 0x003E2A2D File Offset: 0x003E0C2D
		private void BMAGFLLGDPJ()
		{
			this.GIGHNDOLPBN = base.GetComponent<ScrollRect>();
			if (this.controllingScrollRect != null)
			{
				this.controllingScrollRect.onValueChanged.AddListener(new UnityAction<Vector2>(this.NFHIIIOBFCD));
			}
		}

		// Token: 0x0600A773 RID: 42867 RVA: 0x003E2ABC File Offset: 0x003E0CBC
		private void LNGMALJGLMF(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A774 RID: 42868 RVA: 0x003E2B0D File Offset: 0x003E0D0D
		private void JEEINPBLBDI()
		{
			this.GIGHNDOLPBN = base.GetComponent<ScrollRect>();
			if (this.controllingScrollRect != null)
			{
				this.controllingScrollRect.onValueChanged.AddListener(new UnityAction<Vector2>(this.NHEBFOENLHD));
			}
		}

		// Token: 0x0600A775 RID: 42869 RVA: 0x003E2B48 File Offset: 0x003E0D48
		private void BCGHNHNOOHK(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A776 RID: 42870 RVA: 0x003E2B99 File Offset: 0x003E0D99
		private void BODPLDJLFCF()
		{
			this.GIGHNDOLPBN = base.GetComponent<ScrollRect>();
			if (this.controllingScrollRect != null)
			{
				this.controllingScrollRect.onValueChanged.AddListener(new UnityAction<Vector2>(this.CGPGCNHCFDM));
			}
		}

		// Token: 0x0600A777 RID: 42871 RVA: 0x003E2BD4 File Offset: 0x003E0DD4
		private void DKJEKHHPOIC(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A778 RID: 42872 RVA: 0x003E2C25 File Offset: 0x003E0E25
		private void HCNECNPPEKA()
		{
			this.GIGHNDOLPBN = base.GetComponent<ScrollRect>();
			if (this.controllingScrollRect != null)
			{
				this.controllingScrollRect.onValueChanged.AddListener(new UnityAction<Vector2>(this.JFHLFFBNHAJ));
			}
		}

		// Token: 0x0600A779 RID: 42873 RVA: 0x003E2C60 File Offset: 0x003E0E60
		private void FOMEECFPFMC(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A77A RID: 42874 RVA: 0x003E2CB1 File Offset: 0x003E0EB1
		private void MADENBGHKDD()
		{
			this.GIGHNDOLPBN = base.GetComponent<ScrollRect>();
			if (this.controllingScrollRect != null)
			{
				this.controllingScrollRect.onValueChanged.AddListener(new UnityAction<Vector2>(this.PHHNJPDDFPJ));
			}
		}

		// Token: 0x0600A77B RID: 42875 RVA: 0x003E2CEC File Offset: 0x003E0EEC
		private void BAGHMEDDBNG(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A77C RID: 42876 RVA: 0x003E25B5 File Offset: 0x003E07B5
		private void EPCGHAAONLN()
		{
			this.GIGHNDOLPBN = base.GetComponent<ScrollRect>();
			if (this.controllingScrollRect != null)
			{
				this.controllingScrollRect.onValueChanged.AddListener(new UnityAction<Vector2>(this.HCEFEBFPBOB));
			}
		}

		// Token: 0x0600A77D RID: 42877 RVA: 0x003E2D40 File Offset: 0x003E0F40
		private void BHOIMDAKHHC(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A77E RID: 42878 RVA: 0x003E2D91 File Offset: 0x003E0F91
		private void FNMPIAMIKCP()
		{
			this.GIGHNDOLPBN = base.GetComponent<ScrollRect>();
			if (this.controllingScrollRect != null)
			{
				this.controllingScrollRect.onValueChanged.AddListener(new UnityAction<Vector2>(this.MJEKCMFNCCD));
			}
		}

		// Token: 0x0600A77F RID: 42879 RVA: 0x003E2DCC File Offset: 0x003E0FCC
		private void NBLBCEAFEPP(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A780 RID: 42880 RVA: 0x003E2E20 File Offset: 0x003E1020
		private void MCFKKHJHHKH(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A781 RID: 42881 RVA: 0x003E2E71 File Offset: 0x003E1071
		private void GDHMJGBAGHP()
		{
			this.GIGHNDOLPBN = base.GetComponent<ScrollRect>();
			if (this.controllingScrollRect != null)
			{
				this.controllingScrollRect.onValueChanged.AddListener(new UnityAction<Vector2>(this.HBDNDDKLMMF));
			}
		}

		// Token: 0x0600A782 RID: 42882 RVA: 0x003E2B0D File Offset: 0x003E0D0D
		private void JIJPHEDDIHC()
		{
			this.GIGHNDOLPBN = base.GetComponent<ScrollRect>();
			if (this.controllingScrollRect != null)
			{
				this.controllingScrollRect.onValueChanged.AddListener(new UnityAction<Vector2>(this.NHEBFOENLHD));
			}
		}

		// Token: 0x0600A783 RID: 42883 RVA: 0x003E2EAC File Offset: 0x003E10AC
		private void INGDDNIBJIO(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A784 RID: 42884 RVA: 0x003E2F00 File Offset: 0x003E1100
		private void NHEBFOENLHD(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A785 RID: 42885 RVA: 0x003E2F51 File Offset: 0x003E1151
		private void AJIKPEIGACI()
		{
			this.GIGHNDOLPBN = base.GetComponent<ScrollRect>();
			if (this.controllingScrollRect != null)
			{
				this.controllingScrollRect.onValueChanged.AddListener(new UnityAction<Vector2>(this.GNKGAJADDAL));
			}
		}

		// Token: 0x0600A786 RID: 42886 RVA: 0x003E2F8C File Offset: 0x003E118C
		private void GOKOEBIAKOB(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A787 RID: 42887 RVA: 0x003E2D91 File Offset: 0x003E0F91
		private void Awake()
		{
			this.GIGHNDOLPBN = base.GetComponent<ScrollRect>();
			if (this.controllingScrollRect != null)
			{
				this.controllingScrollRect.onValueChanged.AddListener(new UnityAction<Vector2>(this.MJEKCMFNCCD));
			}
		}

		// Token: 0x0600A788 RID: 42888 RVA: 0x003E2FE0 File Offset: 0x003E11E0
		private void JFHLFFBNHAJ(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A789 RID: 42889 RVA: 0x003E3034 File Offset: 0x003E1234
		private void AJNPKHNHKKP(Vector2 BMHLPJCOMAA)
		{
			if (this.clamp)
			{
				this.GIGHNDOLPBN.normalizedPosition = new Vector2(Mathf.Clamp01(BMHLPJCOMAA.x), Mathf.Clamp01(BMHLPJCOMAA.y));
			}
			else
			{
				this.GIGHNDOLPBN.normalizedPosition = BMHLPJCOMAA;
			}
		}

		// Token: 0x0600A78A RID: 42890 RVA: 0x003E2D91 File Offset: 0x003E0F91
		private void GEGFJJBCHPE()
		{
			this.GIGHNDOLPBN = base.GetComponent<ScrollRect>();
			if (this.controllingScrollRect != null)
			{
				this.controllingScrollRect.onValueChanged.AddListener(new UnityAction<Vector2>(this.MJEKCMFNCCD));
			}
		}

		// Token: 0x040012B4 RID: 4788
		public bool clamp = true;

		// Token: 0x040012B5 RID: 4789
		[SerializeField]
		private ScrollRect controllingScrollRect;

		// Token: 0x040012B6 RID: 4790
		private ScrollRect GIGHNDOLPBN;
	}
}
