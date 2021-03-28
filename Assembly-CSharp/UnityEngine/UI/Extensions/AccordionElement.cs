using System;
using UnityEngine.Events;
using UnityEngine.UI.Extensions.Tweens;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000243 RID: 579
	[AddComponentMenu("UI/Extensions/Accordion/Accordion Element")]
	[RequireComponent(typeof(RectTransform), typeof(LayoutElement))]
	public class AccordionElement : Toggle
	{
		// Token: 0x06008B77 RID: 35703 RVA: 0x00304B5C File Offset: 0x00302D5C
		protected void MNELPKFGAAJ(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 989f : this.BDDJALKHLOM.MFEFOBCDOBM();
			FloatTween floatTween = default(FloatTween);
			floatTween.OMMLOPBCJHF(dpnhodjhgjl);
			floatTween.MABJAGKDMND(AKGOFCHGGGE);
			floatTween.targetFloat = FIGPMEGNFKJ;
			FloatTween dagalcailln = floatTween;
			dagalcailln.MFHBKOLEPBP(new UnityAction<float>(this.IDDBEDLGJCO));
			dagalcailln.ignoreTimeScale = true;
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008B78 RID: 35704 RVA: 0x00304BDC File Offset: 0x00302DDC
		protected virtual void GLGOLEOAFOD()
		{
			base.Awake();
			base.transition = Selectable.Transition.ColorTint;
			this.toggleTransition = Toggle.ToggleTransition.Fade;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.ILDKHOJMBIJ));
		}

		// Token: 0x06008B79 RID: 35705 RVA: 0x00304C48 File Offset: 0x00302E48
		protected void BJKBDOGNBLP(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 1596f : this.BDDJALKHLOM.AGDKPKCOMDP();
			FloatTween floatTween = default(FloatTween);
			floatTween.OMMLOPBCJHF(dpnhodjhgjl);
			floatTween.IFMFNEFACHC(AKGOFCHGGGE);
			floatTween.NDDCCGGPEHL(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.LNODOBONEFA(new UnityAction<float>(this.PGPCOGABPGJ));
			dagalcailln.DKAILNKOMMB(false);
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008B7A RID: 35706 RVA: 0x00304CC5 File Offset: 0x00302EC5
		protected void ANAFHNPNHPO(float PBMAGEKDPLI)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			this.JAMADOPBCMA.preferredHeight = PBMAGEKDPLI;
		}

		// Token: 0x06008B7B RID: 35707 RVA: 0x00304CE8 File Offset: 0x00302EE8
		protected void JPCLAMCHJHK(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 1996f : this.BDDJALKHLOM.GAHIKNKPPOF();
			FloatTween floatTween = default(FloatTween);
			floatTween.BEAJGNGKIMP(dpnhodjhgjl);
			floatTween.startFloat = AKGOFCHGGGE;
			floatTween.MJKMBGONKJE(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.AddOnChangedCallback(new UnityAction<float>(this.PHNILJJCKAB));
			dagalcailln.ignoreTimeScale = false;
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008B7C RID: 35708 RVA: 0x00304D68 File Offset: 0x00302F68
		protected float ANJEDDIHIDL()
		{
			if (this.JAMADOPBCMA == null)
			{
				return this.m_MinHeight;
			}
			float preferredHeight = this.JAMADOPBCMA.preferredHeight;
			this.JAMADOPBCMA.preferredHeight = 1485f;
			float preferredHeight2 = LayoutUtility.GetPreferredHeight(this.AJMEDOCLAMM);
			this.JAMADOPBCMA.preferredHeight = preferredHeight;
			return preferredHeight2;
		}

		// Token: 0x06008B7D RID: 35709 RVA: 0x00304CC5 File Offset: 0x00302EC5
		protected void IHEPLJHEJHE(float PBMAGEKDPLI)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			this.JAMADOPBCMA.preferredHeight = PBMAGEKDPLI;
		}

		// Token: 0x06008B7E RID: 35710 RVA: 0x00304DC4 File Offset: 0x00302FC4
		public void EGMDHNOPCCN(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Instant : this.BDDJALKHLOM.MHLOJDKPIHG();
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = 761f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Tween)
			{
				if (IJPCEKICPCP)
				{
					this.MIJAGAHKHPI(this.m_MinHeight, this.PGAIHGACGLE());
				}
				else
				{
					this.OOAOOMCJCMH(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x06008B7F RID: 35711 RVA: 0x00304E80 File Offset: 0x00303080
		protected float KKJNDFNKIJE()
		{
			if (this.JAMADOPBCMA == null)
			{
				return this.m_MinHeight;
			}
			float preferredHeight = this.JAMADOPBCMA.preferredHeight;
			this.JAMADOPBCMA.preferredHeight = 686f;
			float preferredHeight2 = LayoutUtility.GetPreferredHeight(this.AJMEDOCLAMM);
			this.JAMADOPBCMA.preferredHeight = preferredHeight;
			return preferredHeight2;
		}

		// Token: 0x06008B80 RID: 35712 RVA: 0x00304EDC File Offset: 0x003030DC
		protected void HKEBJHFAOGD(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 691f : this.BDDJALKHLOM.LBEFNNIIPBD();
			FloatTween floatTween = default(FloatTween);
			floatTween.IEKPPEPCFHH(dpnhodjhgjl);
			floatTween.JGKOCCKCJCL(AKGOFCHGGGE);
			floatTween.NDCBJCEGCNP(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.GHKGJNIEEGC(new UnityAction<float>(this.IDDBEDLGJCO));
			dagalcailln.PGCFILIOJAF(false);
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008B81 RID: 35713 RVA: 0x00304F5C File Offset: 0x0030315C
		protected virtual void EMANBHKAONB()
		{
			base.Awake();
			base.transition = Selectable.Transition.None;
			this.toggleTransition = Toggle.ToggleTransition.None;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.NLGILHOHFNB));
		}

		// Token: 0x06008B82 RID: 35714 RVA: 0x00304FC8 File Offset: 0x003031C8
		protected float NDKINCJMFHF()
		{
			if (this.JAMADOPBCMA == null)
			{
				return this.m_MinHeight;
			}
			float preferredHeight = this.JAMADOPBCMA.preferredHeight;
			this.JAMADOPBCMA.preferredHeight = 1218f;
			float preferredHeight2 = LayoutUtility.GetPreferredHeight(this.AJMEDOCLAMM);
			this.JAMADOPBCMA.preferredHeight = preferredHeight;
			return preferredHeight2;
		}

		// Token: 0x06008B83 RID: 35715 RVA: 0x00305024 File Offset: 0x00303224
		protected void GBKNOMPFICK(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 562f : this.BDDJALKHLOM.PDKOOCJDICA();
			FloatTween floatTween = default(FloatTween);
			floatTween.IEKPPEPCFHH(dpnhodjhgjl);
			floatTween.PPAIAHCJNEK(AKGOFCHGGGE);
			floatTween.BGELCMLGPEG(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.MHIPCJOACFL(new UnityAction<float>(this.FDDIHOILILL));
			dagalcailln.DKAILNKOMMB(false);
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008B84 RID: 35716 RVA: 0x003050A4 File Offset: 0x003032A4
		protected float LGDOLABAAKK()
		{
			if (this.JAMADOPBCMA == null)
			{
				return this.m_MinHeight;
			}
			float preferredHeight = this.JAMADOPBCMA.preferredHeight;
			this.JAMADOPBCMA.preferredHeight = 1345f;
			float preferredHeight2 = LayoutUtility.GetPreferredHeight(this.AJMEDOCLAMM);
			this.JAMADOPBCMA.preferredHeight = preferredHeight;
			return preferredHeight2;
		}

		// Token: 0x06008B85 RID: 35717 RVA: 0x00304CC5 File Offset: 0x00302EC5
		protected void GFHDFHPICPB(float PBMAGEKDPLI)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			this.JAMADOPBCMA.preferredHeight = PBMAGEKDPLI;
		}

		// Token: 0x06008B86 RID: 35718 RVA: 0x00305100 File Offset: 0x00303300
		public void DNGHIAEBFIG(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Tween : this.BDDJALKHLOM.DDGGMKMFCEB();
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = 1276f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JPCLAMCHJHK(this.m_MinHeight, this.KGFNDIIIKHJ());
				}
				else
				{
					this.HJCPPAPLJJB(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x06008B87 RID: 35719 RVA: 0x003051BC File Offset: 0x003033BC
		protected float KGFNDIIIKHJ()
		{
			if (this.JAMADOPBCMA == null)
			{
				return this.m_MinHeight;
			}
			float preferredHeight = this.JAMADOPBCMA.preferredHeight;
			this.JAMADOPBCMA.preferredHeight = 1327f;
			float preferredHeight2 = LayoutUtility.GetPreferredHeight(this.AJMEDOCLAMM);
			this.JAMADOPBCMA.preferredHeight = preferredHeight;
			return preferredHeight2;
		}

		// Token: 0x06008B88 RID: 35720 RVA: 0x00304CC5 File Offset: 0x00302EC5
		protected void OBBHIKJNOHM(float PBMAGEKDPLI)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			this.JAMADOPBCMA.preferredHeight = PBMAGEKDPLI;
		}

		// Token: 0x06008B89 RID: 35721 RVA: 0x00304CC5 File Offset: 0x00302EC5
		protected void IDDBEDLGJCO(float PBMAGEKDPLI)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			this.JAMADOPBCMA.preferredHeight = PBMAGEKDPLI;
		}

		// Token: 0x06008B8A RID: 35722 RVA: 0x00304CC5 File Offset: 0x00302EC5
		protected void MCOMNFOKMFE(float PBMAGEKDPLI)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			this.JAMADOPBCMA.preferredHeight = PBMAGEKDPLI;
		}

		// Token: 0x06008B8B RID: 35723 RVA: 0x00305218 File Offset: 0x00303418
		public void CKGABMKPJJP(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Instant : this.BDDJALKHLOM.FHODONKKFJC();
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = 222f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Tween)
			{
				if (IJPCEKICPCP)
				{
					this.PLFJJFGKCNI(this.m_MinHeight, this.CFPKDGBBFIL());
				}
				else
				{
					this.MBEHEFBNFIN(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x06008B8C RID: 35724 RVA: 0x003052D4 File Offset: 0x003034D4
		public void NLGILHOHFNB(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Tween : this.BDDJALKHLOM.INBONAKBCFB();
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = 1346f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.HPMNNIJJIOI(this.m_MinHeight, this.PGAKNAIHODO());
				}
				else
				{
					this.BJKBDOGNBLP(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x06008B8D RID: 35725 RVA: 0x00305390 File Offset: 0x00303590
		public void DKKHIGGPJED(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Tween : this.BDDJALKHLOM.transition;
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = 747f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Tween)
			{
				if (IJPCEKICPCP)
				{
					this.HJCPPAPLJJB(this.m_MinHeight, this.FCCACBGKJMD());
				}
				else
				{
					this.NNFMIPNPMCO(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x06008B8E RID: 35726 RVA: 0x0030544C File Offset: 0x0030364C
		protected virtual void LFHKGIHNONL()
		{
			base.Awake();
			base.transition = Selectable.Transition.ColorTint;
			this.toggleTransition = Toggle.ToggleTransition.None;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.KIGBJFLKEBO));
		}

		// Token: 0x06008B8F RID: 35727 RVA: 0x003054B8 File Offset: 0x003036B8
		protected void BDKIAHIAGMC(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 1392f : this.BDDJALKHLOM.DNBEGPLAAJL();
			FloatTween floatTween = default(FloatTween);
			floatTween.OMMLOPBCJHF(dpnhodjhgjl);
			floatTween.PPAIAHCJNEK(AKGOFCHGGGE);
			floatTween.NDDCCGGPEHL(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.GEKCGIEAGNG(new UnityAction<float>(this.PHNILJJCKAB));
			dagalcailln.KCBDDBPIOAP(false);
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008B90 RID: 35728 RVA: 0x00305535 File Offset: 0x00303735
		protected AccordionElement()
		{
			if (this.ACLDNDECODB == null)
			{
				this.ACLDNDECODB = new FGHNFDBDDHM<FloatTween>();
			}
			this.ACLDNDECODB.Init(this);
		}

		// Token: 0x06008B91 RID: 35729 RVA: 0x0030556C File Offset: 0x0030376C
		protected virtual void CJEDMGCKHBI()
		{
			base.Awake();
			base.transition = Selectable.Transition.ColorTint;
			this.toggleTransition = Toggle.ToggleTransition.None;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.HMGAKCHMKKG));
		}

		// Token: 0x06008B92 RID: 35730 RVA: 0x00304CC5 File Offset: 0x00302EC5
		protected void KHNNAFOKAIP(float PBMAGEKDPLI)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			this.JAMADOPBCMA.preferredHeight = PBMAGEKDPLI;
		}

		// Token: 0x06008B93 RID: 35731 RVA: 0x003055D8 File Offset: 0x003037D8
		protected virtual void GCNKABKPNOJ()
		{
			base.Awake();
			base.transition = Selectable.Transition.None;
			this.toggleTransition = Toggle.ToggleTransition.Fade;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.IBJCJKBECJE));
		}

		// Token: 0x06008B94 RID: 35732 RVA: 0x00305644 File Offset: 0x00303844
		protected virtual void LBOBAIGNOML()
		{
			base.Awake();
			base.transition = Selectable.Transition.ColorTint;
			this.toggleTransition = Toggle.ToggleTransition.Fade;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.CILOCBACPAA));
		}

		// Token: 0x06008B95 RID: 35733 RVA: 0x003056B0 File Offset: 0x003038B0
		protected virtual void MFAMHKBMBEI()
		{
			base.Awake();
			base.transition = Selectable.Transition.None;
			this.toggleTransition = Toggle.ToggleTransition.None;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.JEGMJJFAENM));
		}

		// Token: 0x06008B96 RID: 35734 RVA: 0x0030571C File Offset: 0x0030391C
		protected virtual void HKDMCBDOGDK()
		{
			base.Awake();
			base.transition = Selectable.Transition.None;
			this.toggleTransition = Toggle.ToggleTransition.None;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.HOLHFCIKIOL));
		}

		// Token: 0x06008B97 RID: 35735 RVA: 0x00305788 File Offset: 0x00303988
		protected float CFPKDGBBFIL()
		{
			if (this.JAMADOPBCMA == null)
			{
				return this.m_MinHeight;
			}
			float preferredHeight = this.JAMADOPBCMA.preferredHeight;
			this.JAMADOPBCMA.preferredHeight = 1008f;
			float preferredHeight2 = LayoutUtility.GetPreferredHeight(this.AJMEDOCLAMM);
			this.JAMADOPBCMA.preferredHeight = preferredHeight;
			return preferredHeight2;
		}

		// Token: 0x06008B98 RID: 35736 RVA: 0x003057E4 File Offset: 0x003039E4
		protected virtual void MBCDCBCLMCI()
		{
			base.Awake();
			base.transition = Selectable.Transition.None;
			this.toggleTransition = Toggle.ToggleTransition.None;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.EHDAFHGGPKN));
		}

		// Token: 0x06008B99 RID: 35737 RVA: 0x00305850 File Offset: 0x00303A50
		protected float IFJLMAHGMIB()
		{
			if (this.JAMADOPBCMA == null)
			{
				return this.m_MinHeight;
			}
			float preferredHeight = this.JAMADOPBCMA.preferredHeight;
			this.JAMADOPBCMA.preferredHeight = 690f;
			float preferredHeight2 = LayoutUtility.GetPreferredHeight(this.AJMEDOCLAMM);
			this.JAMADOPBCMA.preferredHeight = preferredHeight;
			return preferredHeight2;
		}

		// Token: 0x06008B9A RID: 35738 RVA: 0x00304CC5 File Offset: 0x00302EC5
		protected void CDIJEFHNINM(float PBMAGEKDPLI)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			this.JAMADOPBCMA.preferredHeight = PBMAGEKDPLI;
		}

		// Token: 0x06008B9B RID: 35739 RVA: 0x003058AC File Offset: 0x00303AAC
		protected void IANIOIJPMIB(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 1289f : this.BDDJALKHLOM.NMOOIGMAFBJ();
			FloatTween floatTween = default(FloatTween);
			floatTween.IIHLFJCBNLE(dpnhodjhgjl);
			floatTween.PPAIAHCJNEK(AKGOFCHGGGE);
			floatTween.MJKMBGONKJE(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.MFHBKOLEPBP(new UnityAction<float>(this.GLOBPOLHONG));
			dagalcailln.KCBDDBPIOAP(false);
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008B9C RID: 35740 RVA: 0x00304CC5 File Offset: 0x00302EC5
		protected void EPNIPIABKEG(float PBMAGEKDPLI)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			this.JAMADOPBCMA.preferredHeight = PBMAGEKDPLI;
		}

		// Token: 0x06008B9D RID: 35741 RVA: 0x0030592C File Offset: 0x00303B2C
		protected virtual void IOMCHHBGJEC()
		{
			base.Awake();
			base.transition = Selectable.Transition.None;
			this.toggleTransition = Toggle.ToggleTransition.None;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.LMPOHJNODIM));
		}

		// Token: 0x06008B9E RID: 35742 RVA: 0x00305998 File Offset: 0x00303B98
		protected virtual void DHNANELONED()
		{
			base.Awake();
			base.transition = Selectable.Transition.ColorTint;
			this.toggleTransition = Toggle.ToggleTransition.None;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.HNGOJFCKJAK));
		}

		// Token: 0x06008B9F RID: 35743 RVA: 0x00305A04 File Offset: 0x00303C04
		protected virtual void DEJEBOGKMJO()
		{
			base.Awake();
			base.transition = Selectable.Transition.None;
			this.toggleTransition = Toggle.ToggleTransition.None;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.LMPOHJNODIM));
		}

		// Token: 0x06008BA0 RID: 35744 RVA: 0x00305A70 File Offset: 0x00303C70
		protected void HMHDKNCLPOL(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 1442f : this.BDDJALKHLOM.OLPMOKEFHMG();
			FloatTween floatTween = default(FloatTween);
			floatTween.PICGIOOADEF(dpnhodjhgjl);
			floatTween.KCJOGGECJIA(AKGOFCHGGGE);
			floatTween.targetFloat = FIGPMEGNFKJ;
			FloatTween dagalcailln = floatTween;
			dagalcailln.GKMPCBOIIFL(new UnityAction<float>(this.IDDBEDLGJCO));
			dagalcailln.IGHJOGHHDEK(true);
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008BA1 RID: 35745 RVA: 0x00305AF0 File Offset: 0x00303CF0
		public void OGAFNEEIBNO(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Tween : this.BDDJALKHLOM.EEPCOKEJLFJ();
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = 525f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Tween)
			{
				if (IJPCEKICPCP)
				{
					this.DILNHGGMNGH(this.m_MinHeight, this.PGAIHGACGLE());
				}
				else
				{
					this.EMFDBAICMPL(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x06008BA2 RID: 35746 RVA: 0x00305BAC File Offset: 0x00303DAC
		protected void MBEHEFBNFIN(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 8f : this.BDDJALKHLOM.DNBEGPLAAJL();
			FloatTween floatTween = default(FloatTween);
			floatTween.BEHLFOKHCGD(dpnhodjhgjl);
			floatTween.KCJOGGECJIA(AKGOFCHGGGE);
			floatTween.NDCBJCEGCNP(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.GHKGJNIEEGC(new UnityAction<float>(this.GLOBPOLHONG));
			dagalcailln.KCBDDBPIOAP(false);
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008BA3 RID: 35747 RVA: 0x00305C2C File Offset: 0x00303E2C
		protected float OHKECDIDDPP()
		{
			if (this.JAMADOPBCMA == null)
			{
				return this.m_MinHeight;
			}
			float preferredHeight = this.JAMADOPBCMA.preferredHeight;
			this.JAMADOPBCMA.preferredHeight = 150f;
			float preferredHeight2 = LayoutUtility.GetPreferredHeight(this.AJMEDOCLAMM);
			this.JAMADOPBCMA.preferredHeight = preferredHeight;
			return preferredHeight2;
		}

		// Token: 0x06008BA4 RID: 35748 RVA: 0x00305C88 File Offset: 0x00303E88
		public void ILDKHOJMBIJ(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Instant : this.BDDJALKHLOM.ECPBLEMMCPF();
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = 1646f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.BLHCOLOJAMH(this.m_MinHeight, this.PGAIHGACGLE());
				}
				else
				{
					this.MNELPKFGAAJ(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x06008BA5 RID: 35749 RVA: 0x00305D44 File Offset: 0x00303F44
		protected void BLKOFOMIIHM(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 1618f : this.BDDJALKHLOM.LBEFNNIIPBD();
			FloatTween floatTween = default(FloatTween);
			floatTween.EHCCNEIJCGH(dpnhodjhgjl);
			floatTween.PPAIAHCJNEK(AKGOFCHGGGE);
			floatTween.BGELCMLGPEG(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.AddOnChangedCallback(new UnityAction<float>(this.DMPACCCBLIP));
			dagalcailln.ignoreTimeScale = false;
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008BA6 RID: 35750 RVA: 0x00305DC4 File Offset: 0x00303FC4
		protected void LLGLGBMLDHL(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 151f : this.BDDJALKHLOM.HGAIPLLOFOE();
			FloatTween floatTween = default(FloatTween);
			floatTween.IEKPPEPCFHH(dpnhodjhgjl);
			floatTween.IFMFNEFACHC(AKGOFCHGGGE);
			floatTween.NGJCEBHDFPH(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.CEIGHGPMHID(new UnityAction<float>(this.OBBHIKJNOHM));
			dagalcailln.PGCFILIOJAF(true);
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008BA7 RID: 35751 RVA: 0x00305E44 File Offset: 0x00304044
		protected void EMFDBAICMPL(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 891f : this.BDDJALKHLOM.HGAIPLLOFOE();
			FloatTween floatTween = default(FloatTween);
			floatTween.DGABOEMEHFN(dpnhodjhgjl);
			floatTween.IFMFNEFACHC(AKGOFCHGGGE);
			floatTween.KOOEAMPNCKA(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.AddOnChangedCallback(new UnityAction<float>(this.AOOKCOAANDN));
			dagalcailln.KCBDDBPIOAP(false);
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008BA8 RID: 35752 RVA: 0x00305EC4 File Offset: 0x003040C4
		protected void NPPIKMEHJAA(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 1115f : this.BDDJALKHLOM.AGDKPKCOMDP();
			FloatTween floatTween = default(FloatTween);
			floatTween.EHCCNEIJCGH(dpnhodjhgjl);
			floatTween.startFloat = AKGOFCHGGGE;
			floatTween.targetFloat = FIGPMEGNFKJ;
			FloatTween dagalcailln = floatTween;
			dagalcailln.LNODOBONEFA(new UnityAction<float>(this.KHNNAFOKAIP));
			dagalcailln.DKAILNKOMMB(false);
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008BA9 RID: 35753 RVA: 0x00305F44 File Offset: 0x00304144
		protected float FCCACBGKJMD()
		{
			if (this.JAMADOPBCMA == null)
			{
				return this.m_MinHeight;
			}
			float preferredHeight = this.JAMADOPBCMA.preferredHeight;
			this.JAMADOPBCMA.preferredHeight = -1f;
			float preferredHeight2 = LayoutUtility.GetPreferredHeight(this.AJMEDOCLAMM);
			this.JAMADOPBCMA.preferredHeight = preferredHeight;
			return preferredHeight2;
		}

		// Token: 0x06008BAA RID: 35754 RVA: 0x00305FA0 File Offset: 0x003041A0
		protected virtual void MADENBGHKDD()
		{
			base.Awake();
			base.transition = Selectable.Transition.ColorTint;
			this.toggleTransition = Toggle.ToggleTransition.Fade;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.EHDAFHGGPKN));
		}

		// Token: 0x06008BAB RID: 35755 RVA: 0x0030600C File Offset: 0x0030420C
		protected virtual void PHHOMLJECOJ()
		{
			base.Awake();
			base.transition = Selectable.Transition.ColorTint;
			this.toggleTransition = Toggle.ToggleTransition.None;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.EHDAFHGGPKN));
		}

		// Token: 0x06008BAC RID: 35756 RVA: 0x00304CC5 File Offset: 0x00302EC5
		protected void PGPCOGABPGJ(float PBMAGEKDPLI)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			this.JAMADOPBCMA.preferredHeight = PBMAGEKDPLI;
		}

		// Token: 0x06008BAD RID: 35757 RVA: 0x00306078 File Offset: 0x00304278
		protected void BLHCOLOJAMH(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 1749f : this.BDDJALKHLOM.MFEFOBCDOBM();
			FloatTween floatTween = default(FloatTween);
			floatTween.PICGIOOADEF(dpnhodjhgjl);
			floatTween.JGKOCCKCJCL(AKGOFCHGGGE);
			floatTween.MJKMBGONKJE(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.GKMPCBOIIFL(new UnityAction<float>(this.OBBHIKJNOHM));
			dagalcailln.IGHJOGHHDEK(false);
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008BAE RID: 35758 RVA: 0x003060F8 File Offset: 0x003042F8
		public void NBBFMOFDNIH(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Tween : this.BDDJALKHLOM.FMACJOGBCEF();
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = 1469f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.GBKNOMPFICK(this.m_MinHeight, this.FCCACBGKJMD());
				}
				else
				{
					this.LNNHIDAHIPI(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x06008BAF RID: 35759 RVA: 0x00304CC5 File Offset: 0x00302EC5
		protected void ECMLHCPONAA(float PBMAGEKDPLI)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			this.JAMADOPBCMA.preferredHeight = PBMAGEKDPLI;
		}

		// Token: 0x06008BB0 RID: 35760 RVA: 0x003061B4 File Offset: 0x003043B4
		protected float MFNJHAFIKMN()
		{
			if (this.JAMADOPBCMA == null)
			{
				return this.m_MinHeight;
			}
			float preferredHeight = this.JAMADOPBCMA.preferredHeight;
			this.JAMADOPBCMA.preferredHeight = 805f;
			float preferredHeight2 = LayoutUtility.GetPreferredHeight(this.AJMEDOCLAMM);
			this.JAMADOPBCMA.preferredHeight = preferredHeight;
			return preferredHeight2;
		}

		// Token: 0x06008BB1 RID: 35761 RVA: 0x00306210 File Offset: 0x00304410
		protected float NDNIIPPAPMH()
		{
			if (this.JAMADOPBCMA == null)
			{
				return this.m_MinHeight;
			}
			float preferredHeight = this.JAMADOPBCMA.preferredHeight;
			this.JAMADOPBCMA.preferredHeight = 281f;
			float preferredHeight2 = LayoutUtility.GetPreferredHeight(this.AJMEDOCLAMM);
			this.JAMADOPBCMA.preferredHeight = preferredHeight;
			return preferredHeight2;
		}

		// Token: 0x06008BB2 RID: 35762 RVA: 0x0030626C File Offset: 0x0030446C
		protected void MIJAGAHKHPI(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 269f : this.BDDJALKHLOM.LBEFNNIIPBD();
			FloatTween floatTween = default(FloatTween);
			floatTween.BEHLFOKHCGD(dpnhodjhgjl);
			floatTween.startFloat = AKGOFCHGGGE;
			floatTween.MOMGMGLANEK(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.LNODOBONEFA(new UnityAction<float>(this.PGPCOGABPGJ));
			dagalcailln.DKAILNKOMMB(true);
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008BB3 RID: 35763 RVA: 0x003062EC File Offset: 0x003044EC
		protected float PAONKDFOLPO()
		{
			if (this.JAMADOPBCMA == null)
			{
				return this.m_MinHeight;
			}
			float preferredHeight = this.JAMADOPBCMA.preferredHeight;
			this.JAMADOPBCMA.preferredHeight = 971f;
			float preferredHeight2 = LayoutUtility.GetPreferredHeight(this.AJMEDOCLAMM);
			this.JAMADOPBCMA.preferredHeight = preferredHeight;
			return preferredHeight2;
		}

		// Token: 0x06008BB4 RID: 35764 RVA: 0x00306348 File Offset: 0x00304548
		public void LMPOHJNODIM(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Tween : this.BDDJALKHLOM.KKKMPELDHOB();
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = 1504f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.ACLBDKCMBIB(this.m_MinHeight, this.JFHOMKDNEFE());
				}
				else
				{
					this.PEANPLFPICB(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x06008BB5 RID: 35765 RVA: 0x00306404 File Offset: 0x00304604
		protected void PKHHIFNIHAK(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 182f : this.BDDJALKHLOM.GAHIKNKPPOF();
			FloatTween floatTween = default(FloatTween);
			floatTween.IEKPPEPCFHH(dpnhodjhgjl);
			floatTween.IFMFNEFACHC(AKGOFCHGGGE);
			floatTween.KOOEAMPNCKA(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.MHIPCJOACFL(new UnityAction<float>(this.IDDBEDLGJCO));
			dagalcailln.DKAILNKOMMB(true);
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008BB6 RID: 35766 RVA: 0x00306484 File Offset: 0x00304684
		protected float AIMNBENAFAN()
		{
			if (this.JAMADOPBCMA == null)
			{
				return this.m_MinHeight;
			}
			float preferredHeight = this.JAMADOPBCMA.preferredHeight;
			this.JAMADOPBCMA.preferredHeight = 969f;
			float preferredHeight2 = LayoutUtility.GetPreferredHeight(this.AJMEDOCLAMM);
			this.JAMADOPBCMA.preferredHeight = preferredHeight;
			return preferredHeight2;
		}

		// Token: 0x06008BB7 RID: 35767 RVA: 0x003064E0 File Offset: 0x003046E0
		protected void PEANPLFPICB(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 675f : this.BDDJALKHLOM.MFEFOBCDOBM();
			FloatTween floatTween = default(FloatTween);
			floatTween.PICGIOOADEF(dpnhodjhgjl);
			floatTween.PPAIAHCJNEK(AKGOFCHGGGE);
			floatTween.BGELCMLGPEG(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.FEOHNOCBHNO(new UnityAction<float>(this.JFECNJEJLAH));
			dagalcailln.CIKJLGDCOBK(false);
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008BB8 RID: 35768 RVA: 0x00304CC5 File Offset: 0x00302EC5
		protected void GLOBPOLHONG(float PBMAGEKDPLI)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			this.JAMADOPBCMA.preferredHeight = PBMAGEKDPLI;
		}

		// Token: 0x06008BB9 RID: 35769 RVA: 0x00306560 File Offset: 0x00304760
		public void GJIJFILNKEB(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Tween : this.BDDJALKHLOM.ECPBLEMMCPF();
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = 172f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.IMJJKAALLFO(this.m_MinHeight, this.LGDOLABAAKK());
				}
				else
				{
					this.PLFJJFGKCNI(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x06008BBA RID: 35770 RVA: 0x0030661C File Offset: 0x0030481C
		protected virtual void OBPCMAFGLON()
		{
			base.Awake();
			base.transition = Selectable.Transition.ColorTint;
			this.toggleTransition = Toggle.ToggleTransition.Fade;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.CACFCCLMDAA));
		}

		// Token: 0x06008BBB RID: 35771 RVA: 0x00306688 File Offset: 0x00304888
		protected void HJCPPAPLJJB(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 1879f : this.BDDJALKHLOM.PMOFECDFHPJ();
			FloatTween floatTween = default(FloatTween);
			floatTween.GOKNNGFPFDF(dpnhodjhgjl);
			floatTween.PPAIAHCJNEK(AKGOFCHGGGE);
			floatTween.NDCBJCEGCNP(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.LNODOBONEFA(new UnityAction<float>(this.FFEMINKKHMG));
			dagalcailln.ignoreTimeScale = true;
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008BBC RID: 35772 RVA: 0x00306708 File Offset: 0x00304908
		protected virtual void CCDNJPNLGBN()
		{
			base.Awake();
			base.transition = Selectable.Transition.None;
			this.toggleTransition = Toggle.ToggleTransition.None;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.HBABFDEBAEH));
		}

		// Token: 0x06008BBD RID: 35773 RVA: 0x00306774 File Offset: 0x00304974
		protected void DILNHGGMNGH(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float duration = (!(this.BDDJALKHLOM != null)) ? 0.3f : this.BDDJALKHLOM.transitionDuration;
			FloatTween dagalcailln = new FloatTween
			{
				duration = duration,
				startFloat = AKGOFCHGGGE,
				targetFloat = FIGPMEGNFKJ
			};
			dagalcailln.AddOnChangedCallback(new UnityAction<float>(this.HHIJEPOPAFP));
			dagalcailln.ignoreTimeScale = true;
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008BBE RID: 35774 RVA: 0x003067F4 File Offset: 0x003049F4
		protected virtual void MLPCIDDEIDC()
		{
			base.Awake();
			base.transition = Selectable.Transition.None;
			this.toggleTransition = Toggle.ToggleTransition.Fade;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.HBABFDEBAEH));
		}

		// Token: 0x06008BBF RID: 35775 RVA: 0x00304CC5 File Offset: 0x00302EC5
		protected void FFEMINKKHMG(float PBMAGEKDPLI)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			this.JAMADOPBCMA.preferredHeight = PBMAGEKDPLI;
		}

		// Token: 0x06008BC0 RID: 35776 RVA: 0x00306860 File Offset: 0x00304A60
		public void EKEAMBCIPFK(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Tween : this.BDDJALKHLOM.PAIPIJCCEEH();
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = 1641f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.EMFDBAICMPL(this.m_MinHeight, this.LGDOLABAAKK());
				}
				else
				{
					this.JPCLAMCHJHK(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x06008BC1 RID: 35777 RVA: 0x0030691C File Offset: 0x00304B1C
		protected void NNFMIPNPMCO(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 298f : this.BDDJALKHLOM.GAHIKNKPPOF();
			FloatTween floatTween = default(FloatTween);
			floatTween.BEHLFOKHCGD(dpnhodjhgjl);
			floatTween.PPAIAHCJNEK(AKGOFCHGGGE);
			floatTween.NDDCCGGPEHL(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.MHIPCJOACFL(new UnityAction<float>(this.KHNNAFOKAIP));
			dagalcailln.PGCFILIOJAF(false);
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008BC2 RID: 35778 RVA: 0x0030699C File Offset: 0x00304B9C
		public void OnValueChanged(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Instant : this.BDDJALKHLOM.transition;
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = -1f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Tween)
			{
				if (IJPCEKICPCP)
				{
					this.DILNHGGMNGH(this.m_MinHeight, this.FCCACBGKJMD());
				}
				else
				{
					this.DILNHGGMNGH(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x06008BC3 RID: 35779 RVA: 0x00306A58 File Offset: 0x00304C58
		protected void IMJJKAALLFO(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 924f : this.BDDJALKHLOM.PMOFECDFHPJ();
			FloatTween floatTween = default(FloatTween);
			floatTween.PICGIOOADEF(dpnhodjhgjl);
			floatTween.JGKOCCKCJCL(AKGOFCHGGGE);
			floatTween.NGJCEBHDFPH(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.CEIGHGPMHID(new UnityAction<float>(this.CDIJEFHNINM));
			dagalcailln.CIKJLGDCOBK(false);
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008BC4 RID: 35780 RVA: 0x00306AD8 File Offset: 0x00304CD8
		protected virtual void PMBIKIBOHOF()
		{
			base.Awake();
			base.transition = Selectable.Transition.ColorTint;
			this.toggleTransition = Toggle.ToggleTransition.Fade;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.OGAFNEEIBNO));
		}

		// Token: 0x06008BC5 RID: 35781 RVA: 0x00306B44 File Offset: 0x00304D44
		protected virtual void OFFGFINPBMK()
		{
			base.Awake();
			base.transition = Selectable.Transition.ColorTint;
			this.toggleTransition = Toggle.ToggleTransition.None;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.GJIJFILNKEB));
		}

		// Token: 0x06008BC6 RID: 35782 RVA: 0x00306BB0 File Offset: 0x00304DB0
		protected virtual void HKKLLDHKBMI()
		{
			base.Awake();
			base.transition = Selectable.Transition.None;
			this.toggleTransition = Toggle.ToggleTransition.Fade;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.FDGBNLFNFGG));
		}

		// Token: 0x06008BC7 RID: 35783 RVA: 0x00306C1C File Offset: 0x00304E1C
		protected float PGAIHGACGLE()
		{
			if (this.JAMADOPBCMA == null)
			{
				return this.m_MinHeight;
			}
			float preferredHeight = this.JAMADOPBCMA.preferredHeight;
			this.JAMADOPBCMA.preferredHeight = 1872f;
			float preferredHeight2 = LayoutUtility.GetPreferredHeight(this.AJMEDOCLAMM);
			this.JAMADOPBCMA.preferredHeight = preferredHeight;
			return preferredHeight2;
		}

		// Token: 0x06008BC8 RID: 35784 RVA: 0x00306C78 File Offset: 0x00304E78
		protected virtual void JEEINPBLBDI()
		{
			base.Awake();
			base.transition = Selectable.Transition.ColorTint;
			this.toggleTransition = Toggle.ToggleTransition.None;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.GJIJFILNKEB));
		}

		// Token: 0x06008BC9 RID: 35785 RVA: 0x00306CE4 File Offset: 0x00304EE4
		public void HOBDJBAPCBI(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Instant : this.BDDJALKHLOM.KKKMPELDHOB();
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = 1130f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.ACLBDKCMBIB(this.m_MinHeight, this.OHKECDIDDPP());
				}
				else
				{
					this.HJCPPAPLJJB(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x06008BCA RID: 35786 RVA: 0x00306DA0 File Offset: 0x00304FA0
		protected virtual void KEKNHAAEPCJ()
		{
			base.Awake();
			base.transition = Selectable.Transition.ColorTint;
			this.toggleTransition = Toggle.ToggleTransition.None;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.EGMDHNOPCCN));
		}

		// Token: 0x06008BCB RID: 35787 RVA: 0x00306E0C File Offset: 0x0030500C
		public void CACFCCLMDAA(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Tween : this.BDDJALKHLOM.MHLOJDKPIHG();
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = 1509f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.ACLBDKCMBIB(this.m_MinHeight, this.AIMNBENAFAN());
				}
				else
				{
					this.CLEMNLIBEHO(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x06008BCC RID: 35788 RVA: 0x00306EC8 File Offset: 0x003050C8
		protected virtual void AJIKPEIGACI()
		{
			base.Awake();
			base.transition = Selectable.Transition.None;
			this.toggleTransition = Toggle.ToggleTransition.Fade;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.DKKHIGGPJED));
		}

		// Token: 0x06008BCD RID: 35789 RVA: 0x00306F34 File Offset: 0x00305134
		public void MOFFMIELEKF(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Tween : this.BDDJALKHLOM.MHLOJDKPIHG();
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = 803f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Tween)
			{
				if (IJPCEKICPCP)
				{
					this.IMJJKAALLFO(this.m_MinHeight, this.FCCACBGKJMD());
				}
				else
				{
					this.BJKBDOGNBLP(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x06008BCE RID: 35790 RVA: 0x00306FF0 File Offset: 0x003051F0
		protected void PLFJJFGKCNI(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float duration = (!(this.BDDJALKHLOM != null)) ? 729f : this.BDDJALKHLOM.MFEFOBCDOBM();
			FloatTween floatTween = default(FloatTween);
			floatTween.duration = duration;
			floatTween.KCJOGGECJIA(AKGOFCHGGGE);
			floatTween.KOOEAMPNCKA(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.FEOHNOCBHNO(new UnityAction<float>(this.GLOBPOLHONG));
			dagalcailln.ignoreTimeScale = true;
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008BCF RID: 35791 RVA: 0x00307070 File Offset: 0x00305270
		protected virtual void NKNPEAOFHFM()
		{
			base.Awake();
			base.transition = Selectable.Transition.None;
			this.toggleTransition = Toggle.ToggleTransition.Fade;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.FDGBNLFNFGG));
		}

		// Token: 0x06008BD0 RID: 35792 RVA: 0x003070DC File Offset: 0x003052DC
		protected virtual void GEPELODHBFN()
		{
			base.Awake();
			base.transition = Selectable.Transition.ColorTint;
			this.toggleTransition = Toggle.ToggleTransition.None;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.EHDAFHGGPKN));
		}

		// Token: 0x06008BD1 RID: 35793 RVA: 0x00307148 File Offset: 0x00305348
		protected float FGFPDILPADD()
		{
			if (this.JAMADOPBCMA == null)
			{
				return this.m_MinHeight;
			}
			float preferredHeight = this.JAMADOPBCMA.preferredHeight;
			this.JAMADOPBCMA.preferredHeight = 1624f;
			float preferredHeight2 = LayoutUtility.GetPreferredHeight(this.AJMEDOCLAMM);
			this.JAMADOPBCMA.preferredHeight = preferredHeight;
			return preferredHeight2;
		}

		// Token: 0x06008BD2 RID: 35794 RVA: 0x003071A4 File Offset: 0x003053A4
		protected override void Awake()
		{
			base.Awake();
			base.transition = Selectable.Transition.None;
			this.toggleTransition = Toggle.ToggleTransition.None;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.OnValueChanged));
		}

		// Token: 0x06008BD3 RID: 35795 RVA: 0x00307210 File Offset: 0x00305410
		protected float PGAKNAIHODO()
		{
			if (this.JAMADOPBCMA == null)
			{
				return this.m_MinHeight;
			}
			float preferredHeight = this.JAMADOPBCMA.preferredHeight;
			this.JAMADOPBCMA.preferredHeight = 1487f;
			float preferredHeight2 = LayoutUtility.GetPreferredHeight(this.AJMEDOCLAMM);
			this.JAMADOPBCMA.preferredHeight = preferredHeight;
			return preferredHeight2;
		}

		// Token: 0x06008BD4 RID: 35796 RVA: 0x0030726C File Offset: 0x0030546C
		public void JEGMJJFAENM(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Tween : this.BDDJALKHLOM.FMACJOGBCEF();
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = 1285f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.DILNHGGMNGH(this.m_MinHeight, this.KGFNDIIIKHJ());
				}
				else
				{
					this.BLKOFOMIIHM(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x06008BD5 RID: 35797 RVA: 0x00307328 File Offset: 0x00305528
		public void HNGOJFCKJAK(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Tween : this.BDDJALKHLOM.FHODONKKFJC();
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = 927f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.BLHCOLOJAMH(this.m_MinHeight, this.CFPKDGBBFIL());
				}
				else
				{
					this.CLEMNLIBEHO(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x06008BD6 RID: 35798 RVA: 0x003073E4 File Offset: 0x003055E4
		public void FDGBNLFNFGG(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Tween : this.BDDJALKHLOM.JCOEDOCKMDL();
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = 1092f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Tween)
			{
				if (IJPCEKICPCP)
				{
					this.PLFJJFGKCNI(this.m_MinHeight, this.PGAIHGACGLE());
				}
				else
				{
					this.BLKOFOMIIHM(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x06008BD7 RID: 35799 RVA: 0x003074A0 File Offset: 0x003056A0
		protected float PCJKCPHOJAP()
		{
			if (this.JAMADOPBCMA == null)
			{
				return this.m_MinHeight;
			}
			float preferredHeight = this.JAMADOPBCMA.preferredHeight;
			this.JAMADOPBCMA.preferredHeight = 1658f;
			float preferredHeight2 = LayoutUtility.GetPreferredHeight(this.AJMEDOCLAMM);
			this.JAMADOPBCMA.preferredHeight = preferredHeight;
			return preferredHeight2;
		}

		// Token: 0x06008BD8 RID: 35800 RVA: 0x003074FC File Offset: 0x003056FC
		protected virtual void MMPOJCFOGJJ()
		{
			base.Awake();
			base.transition = Selectable.Transition.ColorTint;
			this.toggleTransition = Toggle.ToggleTransition.None;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.OnValueChanged));
		}

		// Token: 0x06008BD9 RID: 35801 RVA: 0x00307568 File Offset: 0x00305768
		protected virtual void JIJPHEDDIHC()
		{
			base.Awake();
			base.transition = Selectable.Transition.None;
			this.toggleTransition = Toggle.ToggleTransition.Fade;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.JEGMJJFAENM));
		}

		// Token: 0x06008BDA RID: 35802 RVA: 0x00304CC5 File Offset: 0x00302EC5
		protected void MKDAOEGJLLJ(float PBMAGEKDPLI)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			this.JAMADOPBCMA.preferredHeight = PBMAGEKDPLI;
		}

		// Token: 0x06008BDB RID: 35803 RVA: 0x00304CC5 File Offset: 0x00302EC5
		protected void PHNILJJCKAB(float PBMAGEKDPLI)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			this.JAMADOPBCMA.preferredHeight = PBMAGEKDPLI;
		}

		// Token: 0x06008BDC RID: 35804 RVA: 0x00304CC5 File Offset: 0x00302EC5
		protected void JFECNJEJLAH(float PBMAGEKDPLI)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			this.JAMADOPBCMA.preferredHeight = PBMAGEKDPLI;
		}

		// Token: 0x06008BDD RID: 35805 RVA: 0x003075D4 File Offset: 0x003057D4
		public void HMGAKCHMKKG(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Tween : this.BDDJALKHLOM.INBONAKBCFB();
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = 1317f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.IMJJKAALLFO(this.m_MinHeight, this.PAONKDFOLPO());
				}
				else
				{
					this.NNFMIPNPMCO(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x06008BDE RID: 35806 RVA: 0x00307690 File Offset: 0x00305890
		protected void ACLBDKCMBIB(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 1455f : this.BDDJALKHLOM.AGDKPKCOMDP();
			FloatTween floatTween = default(FloatTween);
			floatTween.DGABOEMEHFN(dpnhodjhgjl);
			floatTween.KCJOGGECJIA(AKGOFCHGGGE);
			floatTween.BGELCMLGPEG(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.LNODOBONEFA(new UnityAction<float>(this.GFHDFHPICPB));
			dagalcailln.IGHJOGHHDEK(true);
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008BDF RID: 35807 RVA: 0x00307710 File Offset: 0x00305910
		protected void LBBKBDPPCMH(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 1613f : this.BDDJALKHLOM.IOPGMIHHDIB();
			FloatTween floatTween = default(FloatTween);
			floatTween.IEKPPEPCFHH(dpnhodjhgjl);
			floatTween.MABJAGKDMND(AKGOFCHGGGE);
			floatTween.BGELCMLGPEG(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.LNODOBONEFA(new UnityAction<float>(this.FFEMINKKHMG));
			dagalcailln.HPOANOANLJN(false);
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008BE0 RID: 35808 RVA: 0x00307790 File Offset: 0x00305990
		protected virtual void KAMMKPFNJJF()
		{
			base.Awake();
			base.transition = Selectable.Transition.ColorTint;
			this.toggleTransition = Toggle.ToggleTransition.Fade;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.ILDKHOJMBIJ));
		}

		// Token: 0x06008BE1 RID: 35809 RVA: 0x003077FC File Offset: 0x003059FC
		protected void LNOPCNEHBFA(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 641f : this.BDDJALKHLOM.FCHCBEIAKFH();
			FloatTween floatTween = default(FloatTween);
			floatTween.OMMLOPBCJHF(dpnhodjhgjl);
			floatTween.PPAIAHCJNEK(AKGOFCHGGGE);
			floatTween.MJKMBGONKJE(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.MFHBKOLEPBP(new UnityAction<float>(this.PGPCOGABPGJ));
			dagalcailln.PGCFILIOJAF(false);
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008BE2 RID: 35810 RVA: 0x00304CC5 File Offset: 0x00302EC5
		protected void HHIJEPOPAFP(float PBMAGEKDPLI)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			this.JAMADOPBCMA.preferredHeight = PBMAGEKDPLI;
		}

		// Token: 0x06008BE3 RID: 35811 RVA: 0x0030787C File Offset: 0x00305A7C
		public void IEFKIBGEKCD(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Tween : this.BDDJALKHLOM.MNDAIDDCINF();
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = 72f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Tween)
			{
				if (IJPCEKICPCP)
				{
					this.HMHDKNCLPOL(this.m_MinHeight, this.PGAIHGACGLE());
				}
				else
				{
					this.BJKBDOGNBLP(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x06008BE4 RID: 35812 RVA: 0x00307938 File Offset: 0x00305B38
		protected float AHLJCMBOJIE()
		{
			if (this.JAMADOPBCMA == null)
			{
				return this.m_MinHeight;
			}
			float preferredHeight = this.JAMADOPBCMA.preferredHeight;
			this.JAMADOPBCMA.preferredHeight = 138f;
			float preferredHeight2 = LayoutUtility.GetPreferredHeight(this.AJMEDOCLAMM);
			this.JAMADOPBCMA.preferredHeight = preferredHeight;
			return preferredHeight2;
		}

		// Token: 0x06008BE5 RID: 35813 RVA: 0x00307994 File Offset: 0x00305B94
		protected virtual void ELJPNLNELIE()
		{
			base.Awake();
			base.transition = Selectable.Transition.None;
			this.toggleTransition = Toggle.ToggleTransition.Fade;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.NBBFMOFDNIH));
		}

		// Token: 0x06008BE6 RID: 35814 RVA: 0x00307A00 File Offset: 0x00305C00
		protected void HAHEENGFFGL(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 466f : this.BDDJALKHLOM.ECPAEFPMCIN();
			FloatTween floatTween = default(FloatTween);
			floatTween.BEHLFOKHCGD(dpnhodjhgjl);
			floatTween.OKANGNECOAN(AKGOFCHGGGE);
			floatTween.MOMGMGLANEK(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.GKMPCBOIIFL(new UnityAction<float>(this.EPNIPIABKEG));
			dagalcailln.PGCFILIOJAF(true);
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008BE7 RID: 35815 RVA: 0x00307A80 File Offset: 0x00305C80
		public void HOLHFCIKIOL(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Instant : this.BDDJALKHLOM.PAIPIJCCEEH();
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = 635f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.CLEMNLIBEHO(this.m_MinHeight, this.ANJEDDIHIDL());
				}
				else
				{
					this.MBEHEFBNFIN(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x06008BE8 RID: 35816 RVA: 0x00307B3C File Offset: 0x00305D3C
		public void KIGBJFLKEBO(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Tween : this.BDDJALKHLOM.FHODONKKFJC();
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = 1969f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Tween)
			{
				if (IJPCEKICPCP)
				{
					this.MIJAGAHKHPI(this.m_MinHeight, this.NDKINCJMFHF());
				}
				else
				{
					this.HAHEENGFFGL(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x06008BE9 RID: 35817 RVA: 0x00307BF8 File Offset: 0x00305DF8
		protected virtual void JPJNECPABBG()
		{
			base.Awake();
			base.transition = Selectable.Transition.ColorTint;
			this.toggleTransition = Toggle.ToggleTransition.Fade;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.ILDKHOJMBIJ));
		}

		// Token: 0x06008BEA RID: 35818 RVA: 0x00307C64 File Offset: 0x00305E64
		protected virtual void GMIOCKFLJAK()
		{
			base.Awake();
			base.transition = Selectable.Transition.ColorTint;
			this.toggleTransition = Toggle.ToggleTransition.Fade;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.DKKHIGGPJED));
		}

		// Token: 0x06008BEB RID: 35819 RVA: 0x00307CD0 File Offset: 0x00305ED0
		public void IBJCJKBECJE(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Tween : this.BDDJALKHLOM.KKKMPELDHOB();
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = 1215f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Tween)
			{
				if (IJPCEKICPCP)
				{
					this.MBEHEFBNFIN(this.m_MinHeight, this.MFNJHAFIKMN());
				}
				else
				{
					this.OOAOOMCJCMH(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x06008BEC RID: 35820 RVA: 0x00307D8C File Offset: 0x00305F8C
		protected float CLPPKGALDJJ()
		{
			if (this.JAMADOPBCMA == null)
			{
				return this.m_MinHeight;
			}
			float preferredHeight = this.JAMADOPBCMA.preferredHeight;
			this.JAMADOPBCMA.preferredHeight = 1628f;
			float preferredHeight2 = LayoutUtility.GetPreferredHeight(this.AJMEDOCLAMM);
			this.JAMADOPBCMA.preferredHeight = preferredHeight;
			return preferredHeight2;
		}

		// Token: 0x06008BED RID: 35821 RVA: 0x00307DE8 File Offset: 0x00305FE8
		public void CILOCBACPAA(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Instant : this.BDDJALKHLOM.JMFALLEEIDG();
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = 1614f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Tween)
			{
				if (IJPCEKICPCP)
				{
					this.IMJJKAALLFO(this.m_MinHeight, this.KGFNDIIIKHJ());
				}
				else
				{
					this.MIJAGAHKHPI(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x06008BEE RID: 35822 RVA: 0x00307EA4 File Offset: 0x003060A4
		protected float JFHOMKDNEFE()
		{
			if (this.JAMADOPBCMA == null)
			{
				return this.m_MinHeight;
			}
			float preferredHeight = this.JAMADOPBCMA.preferredHeight;
			this.JAMADOPBCMA.preferredHeight = 933f;
			float preferredHeight2 = LayoutUtility.GetPreferredHeight(this.AJMEDOCLAMM);
			this.JAMADOPBCMA.preferredHeight = preferredHeight;
			return preferredHeight2;
		}

		// Token: 0x06008BEF RID: 35823 RVA: 0x00307F00 File Offset: 0x00306100
		protected void HPMNNIJJIOI(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 139f : this.BDDJALKHLOM.BHIHBAPJCHO();
			FloatTween floatTween = default(FloatTween);
			floatTween.EHCCNEIJCGH(dpnhodjhgjl);
			floatTween.MABJAGKDMND(AKGOFCHGGGE);
			floatTween.NELMOPMEFPA(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.FEOHNOCBHNO(new UnityAction<float>(this.IHEPLJHEJHE));
			dagalcailln.CIKJLGDCOBK(false);
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008BF0 RID: 35824 RVA: 0x00307F80 File Offset: 0x00306180
		protected void CLEMNLIBEHO(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 1222f : this.BDDJALKHLOM.AGDKPKCOMDP();
			FloatTween floatTween = default(FloatTween);
			floatTween.DGABOEMEHFN(dpnhodjhgjl);
			floatTween.startFloat = AKGOFCHGGGE;
			floatTween.NDCBJCEGCNP(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.FEOHNOCBHNO(new UnityAction<float>(this.ANAFHNPNHPO));
			dagalcailln.PGCFILIOJAF(true);
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008BF1 RID: 35825 RVA: 0x00308000 File Offset: 0x00306200
		protected virtual void CNDGDDLEFJF()
		{
			base.Awake();
			base.transition = Selectable.Transition.None;
			this.toggleTransition = Toggle.ToggleTransition.None;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.OGAFNEEIBNO));
		}

		// Token: 0x06008BF2 RID: 35826 RVA: 0x00304CC5 File Offset: 0x00302EC5
		protected void AOOKCOAANDN(float PBMAGEKDPLI)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			this.JAMADOPBCMA.preferredHeight = PBMAGEKDPLI;
		}

		// Token: 0x06008BF3 RID: 35827 RVA: 0x0030806C File Offset: 0x0030626C
		protected virtual void BODPLDJLFCF()
		{
			base.Awake();
			base.transition = Selectable.Transition.None;
			this.toggleTransition = Toggle.ToggleTransition.None;
			this.BDDJALKHLOM = base.gameObject.GetComponentInParent<Accordion>();
			this.AJMEDOCLAMM = (base.transform as RectTransform);
			this.JAMADOPBCMA = base.gameObject.GetComponent<LayoutElement>();
			this.onValueChanged.AddListener(new UnityAction<bool>(this.MOFFMIELEKF));
		}

		// Token: 0x06008BF4 RID: 35828 RVA: 0x003080D8 File Offset: 0x003062D8
		public void HBABFDEBAEH(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Instant : this.BDDJALKHLOM.JCOEDOCKMDL();
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = 1918f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.MBEHEFBNFIN(this.m_MinHeight, this.OHKECDIDDPP());
				}
				else
				{
					this.IMJJKAALLFO(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x06008BF5 RID: 35829 RVA: 0x00308194 File Offset: 0x00306394
		protected void LNNHIDAHIPI(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 20f : this.BDDJALKHLOM.KCHNKBPMPHB();
			FloatTween floatTween = default(FloatTween);
			floatTween.PICGIOOADEF(dpnhodjhgjl);
			floatTween.KCJOGGECJIA(AKGOFCHGGGE);
			floatTween.MJKMBGONKJE(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.MFHBKOLEPBP(new UnityAction<float>(this.JFECNJEJLAH));
			dagalcailln.PGCFILIOJAF(false);
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008BF6 RID: 35830 RVA: 0x00304CC5 File Offset: 0x00302EC5
		protected void FDDIHOILILL(float PBMAGEKDPLI)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			this.JAMADOPBCMA.preferredHeight = PBMAGEKDPLI;
		}

		// Token: 0x06008BF7 RID: 35831 RVA: 0x00304CC5 File Offset: 0x00302EC5
		protected void DMPACCCBLIP(float PBMAGEKDPLI)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			this.JAMADOPBCMA.preferredHeight = PBMAGEKDPLI;
		}

		// Token: 0x06008BF8 RID: 35832 RVA: 0x00308214 File Offset: 0x00306414
		protected void OOAOOMCJCMH(float AKGOFCHGGGE, float FIGPMEGNFKJ)
		{
			float dpnhodjhgjl = (!(this.BDDJALKHLOM != null)) ? 235f : this.BDDJALKHLOM.AGDKPKCOMDP();
			FloatTween floatTween = default(FloatTween);
			floatTween.PICGIOOADEF(dpnhodjhgjl);
			floatTween.KCJOGGECJIA(AKGOFCHGGGE);
			floatTween.BGELCMLGPEG(FIGPMEGNFKJ);
			FloatTween dagalcailln = floatTween;
			dagalcailln.GEKCGIEAGNG(new UnityAction<float>(this.HHIJEPOPAFP));
			dagalcailln.KCBDDBPIOAP(true);
			this.ACLDNDECODB.StartTween(dagalcailln);
		}

		// Token: 0x06008BF9 RID: 35833 RVA: 0x00308294 File Offset: 0x00306494
		public void EHDAFHGGPKN(bool IJPCEKICPCP)
		{
			if (this.JAMADOPBCMA == null)
			{
				return;
			}
			Accordion.Transition transition = (!(this.BDDJALKHLOM != null)) ? Accordion.Transition.Tween : this.BDDJALKHLOM.PAIPIJCCEEH();
			if (transition == Accordion.Transition.Instant)
			{
				if (IJPCEKICPCP)
				{
					this.JAMADOPBCMA.preferredHeight = 1151f;
				}
				else
				{
					this.JAMADOPBCMA.preferredHeight = this.m_MinHeight;
				}
			}
			else if (transition == Accordion.Transition.Tween)
			{
				if (IJPCEKICPCP)
				{
					this.MBEHEFBNFIN(this.m_MinHeight, this.MFNJHAFIKMN());
				}
				else
				{
					this.IANIOIJPMIB(this.AJMEDOCLAMM.rect.height, this.m_MinHeight);
				}
			}
		}

		// Token: 0x04001026 RID: 4134
		[SerializeField]
		private float m_MinHeight = 18f;

		// Token: 0x04001027 RID: 4135
		private Accordion BDDJALKHLOM;

		// Token: 0x04001028 RID: 4136
		private RectTransform AJMEDOCLAMM;

		// Token: 0x04001029 RID: 4137
		private LayoutElement JAMADOPBCMA;

		// Token: 0x0400102A RID: 4138
		[NonSerialized]
		private readonly FGHNFDBDDHM<FloatTween> ACLDNDECODB;
	}
}
