using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

namespace SunCubeStudio.Localization
{
	// Token: 0x02000168 RID: 360
	public class UILocalization : MonoBehaviour
	{
		// Token: 0x060069DC RID: 27100 RVA: 0x0020AC9B File Offset: 0x00208E9B
		private void OnDestroy()
		{
			LocalizationService instance = LocalizationService.Instance;
			instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(this.NFADGEDMNMF));
		}

		// Token: 0x060069DD RID: 27101 RVA: 0x0020ACC3 File Offset: 0x00208EC3
		private void KKADLNPEBMC()
		{
			this.NCHPKINGEMO();
		}

		// Token: 0x060069DE RID: 27102 RVA: 0x0020ACCB File Offset: 0x00208ECB
		private void LPMCPDCJBII()
		{
			this.MDGNCFPFONO(LocalizationService.Instance.IAAEBJKAHDD(this._key));
		}

		// Token: 0x060069DF RID: 27103 RVA: 0x0020ACE3 File Offset: 0x00208EE3
		private string PDBFLKFBELI(string EAFAMAMDNEG)
		{
			if (string.IsNullOrEmpty(EAFAMAMDNEG))
			{
				return string.Empty;
			}
			return EAFAMAMDNEG.Replace("settings.enablehitsoundsinrelax", Environment.NewLine);
		}

		// Token: 0x060069E0 RID: 27104 RVA: 0x0020AD06 File Offset: 0x00208F06
		public string GBOPIIMPAJM()
		{
			return this._key;
		}

		// Token: 0x060069E1 RID: 27105 RVA: 0x0020AD10 File Offset: 0x00208F10
		private IEnumerator ONKGDOACFDC()
		{
			while (!LocalizationService.Instance.inited)
			{
				yield return new WaitForSeconds(0.1f);
			}
			this.DDEKPGECKCD();
			yield break;
		}

		// Token: 0x060069E2 RID: 27106 RVA: 0x0020AD2B File Offset: 0x00208F2B
		public void EJIPDHADHPO(string DPNHODJHGJL)
		{
			this._key = DPNHODJHGJL;
			this.AGODOPOBPEP();
		}

		// Token: 0x060069E3 RID: 27107 RVA: 0x0020AD3C File Offset: 0x00208F3C
		private void OPDAFHEJEPL()
		{
			LocalizationService instance = LocalizationService.Instance;
			instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(this.NFADGEDMNMF));
			this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
			this.OCOOKPAELJJ = base.gameObject.GetComponent<TextMesh>();
			this.PLIEIBMOGKB();
		}

		// Token: 0x060069E5 RID: 27109 RVA: 0x0020ACC3 File Offset: 0x00208EC3
		private void PLIEIBMOGKB()
		{
			this.NCHPKINGEMO();
		}

		// Token: 0x060069E6 RID: 27110 RVA: 0x0020ADA6 File Offset: 0x00208FA6
		private void DAHFFNNIGML()
		{
			base.StartCoroutine(this.POCPKICJPFE());
		}

		// Token: 0x060069E7 RID: 27111 RVA: 0x0020ADB5 File Offset: 0x00208FB5
		public void NEBBMLKOCOK(string DPNHODJHGJL)
		{
			this._key = DPNHODJHGJL;
			this.JLJHLJOENBN();
		}

		// Token: 0x060069E8 RID: 27112 RVA: 0x0020ADC4 File Offset: 0x00208FC4
		private void HKGBLNDLJDI()
		{
			this.IHJAADMJGPB(LocalizationService.Instance.GetTextByKey(this._key));
		}

		// Token: 0x060069E9 RID: 27113 RVA: 0x0020ADDC File Offset: 0x00208FDC
		private void PAKPHKPDKGE()
		{
			base.StartCoroutine(this.ONKGDOACFDC());
		}

		// Token: 0x060069EA RID: 27114 RVA: 0x0020ADEB File Offset: 0x00208FEB
		private string AIMIDDBPBDN(string EAFAMAMDNEG)
		{
			if (string.IsNullOrEmpty(EAFAMAMDNEG))
			{
				return string.Empty;
			}
			return EAFAMAMDNEG.Replace("_NoiseTex", Environment.NewLine);
		}

		// Token: 0x060069EB RID: 27115 RVA: 0x0020AE0E File Offset: 0x0020900E
		private void NBGGMDJKNLO()
		{
			this.LHBBNKIDAKD(LocalizationService.Instance.IAAEBJKAHDD(this._key));
		}

		// Token: 0x060069EC RID: 27116 RVA: 0x0020AE28 File Offset: 0x00209028
		private void HNDJHBNLEEL()
		{
			LocalizationService instance = LocalizationService.Instance;
			instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(this.PLIEIBMOGKB));
			this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
			this.OCOOKPAELJJ = base.gameObject.GetComponent<TextMesh>();
			this.ILNJPIBHMKN();
		}

		// Token: 0x060069ED RID: 27117 RVA: 0x0020AE84 File Offset: 0x00209084
		private void DDEKPGECKCD()
		{
			LocalizationService instance = LocalizationService.Instance;
			instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(this.NFADGEDMNMF));
			this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
			this.OCOOKPAELJJ = base.gameObject.GetComponent<TextMesh>();
			this.NFADGEDMNMF();
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060069EE RID: 27118 RVA: 0x0020AD06 File Offset: 0x00208F06
		// (set) Token: 0x06006A14 RID: 27156 RVA: 0x0020B84B File Offset: 0x00209A4B
		public string Key
		{
			get
			{
				return this._key;
			}
			set
			{
				this._key = value;
				this.MNHCBCCOOMJ();
			}
		}

		// Token: 0x060069EF RID: 27119 RVA: 0x0020AEE0 File Offset: 0x002090E0
		private IEnumerator GNHBLNKLCBG()
		{
			while (!LocalizationService.Instance.inited)
			{
				yield return new WaitForSeconds(0.1f);
			}
			this.DDEKPGECKCD();
			yield break;
		}

		// Token: 0x060069F0 RID: 27120 RVA: 0x0020AEFC File Offset: 0x002090FC
		private void HLFHPKHKEFD(string EAFAMAMDNEG)
		{
			EAFAMAMDNEG = this.MBENMGEIBPJ(EAFAMAMDNEG);
			if (this.OCAMCGEINLB != null)
			{
				this.OCAMCGEINLB.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
			}
			if (this.OCOOKPAELJJ != null)
			{
				this.OCOOKPAELJJ.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
			}
			if (EAFAMAMDNEG == "Checkpoint" || EAFAMAMDNEG == string.Format("Bad parameters for setbool! Use <key> <value>", this._key))
			{
			}
		}

		// Token: 0x060069F1 RID: 27121 RVA: 0x0020AFA3 File Offset: 0x002091A3
		private void HNGGOIOGENO()
		{
			this.ODIHIJKFPKP();
		}

		// Token: 0x060069F2 RID: 27122 RVA: 0x0020AFAB File Offset: 0x002091AB
		private string MBENMGEIBPJ(string EAFAMAMDNEG)
		{
			if (string.IsNullOrEmpty(EAFAMAMDNEG))
			{
				return string.Empty;
			}
			return EAFAMAMDNEG.Replace("_TimeX", Environment.NewLine);
		}

		// Token: 0x060069F3 RID: 27123 RVA: 0x0020AFD0 File Offset: 0x002091D0
		private void GHJJDAJIOPM(string EAFAMAMDNEG)
		{
			EAFAMAMDNEG = this.ELHHIIPGOGM(EAFAMAMDNEG);
			if (this.OCAMCGEINLB != null)
			{
				this.OCAMCGEINLB.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
			}
			if (this.OCOOKPAELJJ != null)
			{
				this.OCOOKPAELJJ.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
			}
			if (EAFAMAMDNEG == "[EMPTY]" || EAFAMAMDNEG == string.Format("[ERROR KEY {0}]", this._key))
			{
			}
		}

		// Token: 0x060069F4 RID: 27124 RVA: 0x0020B077 File Offset: 0x00209277
		private void NFADGEDMNMF()
		{
			this.MNHCBCCOOMJ();
		}

		// Token: 0x060069F5 RID: 27125 RVA: 0x0020B07F File Offset: 0x0020927F
		private string HJLHEOLPAKJ(string EAFAMAMDNEG)
		{
			if (string.IsNullOrEmpty(EAFAMAMDNEG))
			{
				return string.Empty;
			}
			return EAFAMAMDNEG.Replace("_VignettingColor", Environment.NewLine);
		}

		// Token: 0x060069F6 RID: 27126 RVA: 0x0020B0A4 File Offset: 0x002092A4
		private void CKMFPCEPKAG()
		{
			LocalizationService instance = LocalizationService.Instance;
			instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(this.GLAMFCMLKLA));
			this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
			this.OCOOKPAELJJ = base.gameObject.GetComponent<TextMesh>();
			this.ILNJPIBHMKN();
		}

		// Token: 0x060069F7 RID: 27127 RVA: 0x0020AE0E File Offset: 0x0020900E
		private void ODIHIJKFPKP()
		{
			this.LHBBNKIDAKD(LocalizationService.Instance.IAAEBJKAHDD(this._key));
		}

		// Token: 0x060069F8 RID: 27128 RVA: 0x0020ADA6 File Offset: 0x00208FA6
		private void KLILJHJNICK()
		{
			base.StartCoroutine(this.POCPKICJPFE());
		}

		// Token: 0x060069F9 RID: 27129 RVA: 0x0020B0FF File Offset: 0x002092FF
		private void KHNOBJFOJIO()
		{
			this.HLFHPKHKEFD(LocalizationService.Instance.GetTextByKey(this._key));
		}

		// Token: 0x060069FA RID: 27130 RVA: 0x0020B118 File Offset: 0x00209318
		private void MCPDNFJCAPC()
		{
			LocalizationService instance = LocalizationService.Instance;
			instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(this.PLIEIBMOGKB));
			this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
			this.OCOOKPAELJJ = base.gameObject.GetComponent<TextMesh>();
			this.HNGGOIOGENO();
		}

		// Token: 0x060069FB RID: 27131 RVA: 0x0020B174 File Offset: 0x00209374
		private void LHBBNKIDAKD(string EAFAMAMDNEG)
		{
			EAFAMAMDNEG = this.BFONOGEPNNF(EAFAMAMDNEG);
			if (this.OCAMCGEINLB != null)
			{
				this.OCAMCGEINLB.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
			}
			if (this.OCOOKPAELJJ != null)
			{
				this.OCOOKPAELJJ.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
			}
			if (EAFAMAMDNEG == "_NoiseTex" || EAFAMAMDNEG == string.Format("UI Extensions/SoftMaskShaderText", this._key))
			{
			}
		}

		// Token: 0x060069FC RID: 27132 RVA: 0x0020B21B File Offset: 0x0020941B
		private void AGODOPOBPEP()
		{
			this.GJJKCBMHBKF(LocalizationService.Instance.IAAEBJKAHDD(this._key));
		}

		// Token: 0x060069FD RID: 27133 RVA: 0x0020B234 File Offset: 0x00209434
		private void PBHNFEGCKOG()
		{
			LocalizationService instance = LocalizationService.Instance;
			instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(this.ILNJPIBHMKN));
			this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
			this.OCOOKPAELJJ = base.gameObject.GetComponent<TextMesh>();
			this.ILNJPIBHMKN();
		}

		// Token: 0x060069FE RID: 27134 RVA: 0x0020B28F File Offset: 0x0020948F
		private string ELHHIIPGOGM(string EAFAMAMDNEG)
		{
			if (string.IsNullOrEmpty(EAFAMAMDNEG))
			{
				return string.Empty;
			}
			return EAFAMAMDNEG.Replace("\\n", Environment.NewLine);
		}

		// Token: 0x060069FF RID: 27135 RVA: 0x0020B2B4 File Offset: 0x002094B4
		private void CMGLPNCMLDC()
		{
			LocalizationService instance = LocalizationService.Instance;
			instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(this.NFADGEDMNMF));
			this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
			this.OCOOKPAELJJ = base.gameObject.GetComponent<TextMesh>();
			this.NFADGEDMNMF();
		}

		// Token: 0x06006A00 RID: 27136 RVA: 0x0020B310 File Offset: 0x00209510
		public bool LAIFNNLJCIM()
		{
			this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
			this.OCOOKPAELJJ = base.gameObject.GetComponent<TextMesh>();
			return !(this.OCAMCGEINLB != null) && this.OCOOKPAELJJ != null;
		}

		// Token: 0x06006A01 RID: 27137 RVA: 0x0020B360 File Offset: 0x00209560
		private void GJJKCBMHBKF(string EAFAMAMDNEG)
		{
			EAFAMAMDNEG = this.ELHHIIPGOGM(EAFAMAMDNEG);
			if (this.OCAMCGEINLB != null)
			{
				this.OCAMCGEINLB.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
			}
			if (this.OCOOKPAELJJ != null)
			{
				this.OCOOKPAELJJ.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
			}
			if (EAFAMAMDNEG == "IEnumerable" || EAFAMAMDNEG == string.Format("ChatHistoryInputField", this._key))
			{
			}
		}

		// Token: 0x06006A02 RID: 27138 RVA: 0x0020B408 File Offset: 0x00209608
		private void GLNHACHPPKL(string EAFAMAMDNEG)
		{
			EAFAMAMDNEG = this.ELHHIIPGOGM(EAFAMAMDNEG);
			if (this.OCAMCGEINLB != null)
			{
				this.OCAMCGEINLB.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
			}
			if (this.OCOOKPAELJJ != null)
			{
				this.OCOOKPAELJJ.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
			}
			if (EAFAMAMDNEG == "Object ID. Case-Sensitive" || EAFAMAMDNEG == string.Format("_BorderSize", this._key))
			{
			}
		}

		// Token: 0x06006A03 RID: 27139 RVA: 0x0020B4B0 File Offset: 0x002096B0
		public bool IEJKLJJOMGK()
		{
			this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
			this.OCOOKPAELJJ = base.gameObject.GetComponent<TextMesh>();
			return this.OCAMCGEINLB != null || this.OCOOKPAELJJ != null;
		}

		// Token: 0x06006A04 RID: 27140 RVA: 0x0020B4FF File Offset: 0x002096FF
		private void GKAJONDPPGI()
		{
			LocalizationService instance = LocalizationService.Instance;
			instance.OnChangeLocalization = (Action)Delegate.Remove(instance.OnChangeLocalization, new Action(this.GLAMFCMLKLA));
		}

		// Token: 0x06006A05 RID: 27141 RVA: 0x0020B527 File Offset: 0x00209727
		private void NCHPKINGEMO()
		{
			this.IHJAADMJGPB(LocalizationService.Instance.IAAEBJKAHDD(this._key));
		}

		// Token: 0x06006A06 RID: 27142 RVA: 0x0020B53F File Offset: 0x0020973F
		private string BFONOGEPNNF(string EAFAMAMDNEG)
		{
			if (string.IsNullOrEmpty(EAFAMAMDNEG))
			{
				return string.Empty;
			}
			return EAFAMAMDNEG.Replace("No Name", Environment.NewLine);
		}

		// Token: 0x06006A07 RID: 27143 RVA: 0x0020B564 File Offset: 0x00209764
		private void MDGNCFPFONO(string EAFAMAMDNEG)
		{
			EAFAMAMDNEG = this.AHLENEBBPEJ(EAFAMAMDNEG);
			if (this.OCAMCGEINLB != null)
			{
				this.OCAMCGEINLB.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
			}
			if (this.OCOOKPAELJJ != null)
			{
				this.OCOOKPAELJJ.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
			}
			if (EAFAMAMDNEG == "_HeightParams" || EAFAMAMDNEG == string.Format("PhotonView with ID ", this._key))
			{
			}
		}

		// Token: 0x06006A08 RID: 27144 RVA: 0x0020ACC3 File Offset: 0x00208EC3
		private void GLAMFCMLKLA()
		{
			this.NCHPKINGEMO();
		}

		// Token: 0x06006A09 RID: 27145 RVA: 0x0020B60C File Offset: 0x0020980C
		public bool IsHasOutputHelper()
		{
			this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
			this.OCOOKPAELJJ = base.gameObject.GetComponent<TextMesh>();
			return this.OCAMCGEINLB != null || this.OCOOKPAELJJ != null;
		}

		// Token: 0x06006A0A RID: 27146 RVA: 0x0020B65C File Offset: 0x0020985C
		private void FPKPFLLDCCH(string EAFAMAMDNEG)
		{
			EAFAMAMDNEG = this.PDBFLKFBELI(EAFAMAMDNEG);
			if (this.OCAMCGEINLB != null)
			{
				this.OCAMCGEINLB.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
			}
			if (this.OCOOKPAELJJ != null)
			{
				this.OCOOKPAELJJ.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
			}
			if (EAFAMAMDNEG == "note.5" || EAFAMAMDNEG == string.Format("Hex value #RRGGBB", this._key))
			{
			}
		}

		// Token: 0x06006A0B RID: 27147 RVA: 0x0020B703 File Offset: 0x00209903
		private void MNHCBCCOOMJ()
		{
			this.GHJJDAJIOPM(LocalizationService.Instance.GetTextByKey(this._key));
		}

		// Token: 0x06006A0C RID: 27148 RVA: 0x0020B527 File Offset: 0x00209727
		private void JLJHLJOENBN()
		{
			this.IHJAADMJGPB(LocalizationService.Instance.IAAEBJKAHDD(this._key));
		}

		// Token: 0x06006A0D RID: 27149 RVA: 0x0020AFA3 File Offset: 0x002091A3
		private void ILNJPIBHMKN()
		{
			this.ODIHIJKFPKP();
		}

		// Token: 0x06006A0E RID: 27150 RVA: 0x0020B71C File Offset: 0x0020991C
		public bool OGDDBFIGOJE()
		{
			this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
			this.OCOOKPAELJJ = base.gameObject.GetComponent<TextMesh>();
			return !(this.OCAMCGEINLB != null) && this.OCOOKPAELJJ != null;
		}

		// Token: 0x06006A0F RID: 27151 RVA: 0x0020B76C File Offset: 0x0020996C
		public bool LBPDPCEHCMA()
		{
			this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
			this.OCOOKPAELJJ = base.gameObject.GetComponent<TextMesh>();
			return !(this.OCAMCGEINLB != null) && this.OCOOKPAELJJ != null;
		}

		// Token: 0x06006A10 RID: 27152 RVA: 0x0020B7BB File Offset: 0x002099BB
		private string AHLENEBBPEJ(string EAFAMAMDNEG)
		{
			if (string.IsNullOrEmpty(EAFAMAMDNEG))
			{
				return string.Empty;
			}
			return EAFAMAMDNEG.Replace("Tab2Content", Environment.NewLine);
		}

		// Token: 0x06006A11 RID: 27153 RVA: 0x0020B7E0 File Offset: 0x002099E0
		public bool DEGFDEDKNFE()
		{
			this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
			this.OCOOKPAELJJ = base.gameObject.GetComponent<TextMesh>();
			return !(this.OCAMCGEINLB != null) && this.OCOOKPAELJJ != null;
		}

		// Token: 0x06006A12 RID: 27154 RVA: 0x0020ADA6 File Offset: 0x00208FA6
		private void JMEOGJHCONJ()
		{
			base.StartCoroutine(this.POCPKICJPFE());
		}

		// Token: 0x06006A13 RID: 27155 RVA: 0x0020B830 File Offset: 0x00209A30
		private IEnumerator POCPKICJPFE()
		{
			while (!LocalizationService.Instance.inited)
			{
				yield return new WaitForSeconds(0.1f);
			}
			this.DDEKPGECKCD();
			yield break;
		}

		// Token: 0x06006A15 RID: 27157 RVA: 0x0020ADDC File Offset: 0x00208FDC
		private void KMCPMOGKDEH()
		{
			base.StartCoroutine(this.ONKGDOACFDC());
		}

		// Token: 0x06006A16 RID: 27158 RVA: 0x0020ADA6 File Offset: 0x00208FA6
		private void Start()
		{
			base.StartCoroutine(this.POCPKICJPFE());
		}

		// Token: 0x06006A17 RID: 27159 RVA: 0x0020ADDC File Offset: 0x00208FDC
		private void HMPGIFBJFIK()
		{
			base.StartCoroutine(this.ONKGDOACFDC());
		}

		// Token: 0x06006A18 RID: 27160 RVA: 0x0020B85C File Offset: 0x00209A5C
		private void IHJAADMJGPB(string EAFAMAMDNEG)
		{
			EAFAMAMDNEG = this.PDBFLKFBELI(EAFAMAMDNEG);
			if (this.OCAMCGEINLB != null)
			{
				this.OCAMCGEINLB.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
			}
			if (this.OCOOKPAELJJ != null)
			{
				this.OCOOKPAELJJ.text = ((!this.useCaps) ? EAFAMAMDNEG : EAFAMAMDNEG.ToUpper());
			}
			if (EAFAMAMDNEG == "_SubsampleIndices" || EAFAMAMDNEG == string.Format("TBD", this._key))
			{
			}
		}

		// Token: 0x06006A19 RID: 27161 RVA: 0x0020B904 File Offset: 0x00209B04
		private void CIEPPCBBLIF()
		{
			LocalizationService instance = LocalizationService.Instance;
			instance.OnChangeLocalization = (Action)Delegate.Combine(instance.OnChangeLocalization, new Action(this.GLAMFCMLKLA));
			this.OCAMCGEINLB = base.gameObject.GetComponent<Text>();
			this.OCOOKPAELJJ = base.gameObject.GetComponent<TextMesh>();
			this.KKADLNPEBMC();
		}

		// Token: 0x04000AED RID: 2797
		public bool useCaps = true;

		// Token: 0x04000AEE RID: 2798
		public string _key;

		// Token: 0x04000AEF RID: 2799
		private Text OCAMCGEINLB;

		// Token: 0x04000AF0 RID: 2800
		private TextMesh OCOOKPAELJJ;
	}
}
