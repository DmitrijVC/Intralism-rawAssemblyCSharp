using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace UnityEngine.UI
{
	// Token: 0x020002A9 RID: 681
	[AddComponentMenu("UI/Extensions/Extensions Toggle", 31)]
	[RequireComponent(typeof(RectTransform))]
	public class ExtensionsToggle : Selectable, IPointerClickHandler, ISubmitHandler, ICanvasElement, IEventSystemHandler
	{
		// Token: 0x0600A437 RID: 42039 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void NHOLIFLBGPL()
		{
		}

		// Token: 0x0600A438 RID: 42040 RVA: 0x003DA439 File Offset: 0x003D8639
		bool ICanvasElement.IsDestroyed()
		{
			return base.IsDestroyed();
		}

		// Token: 0x0600A439 RID: 42041 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void DHGDADGINKL(CanvasUpdate HDOMJLCMNHL)
		{
		}

		// Token: 0x17000216 RID: 534
		// (get) Token: 0x0600A45E RID: 42078 RVA: 0x003DA59F File Offset: 0x003D879F
		// (set) Token: 0x0600A43A RID: 42042 RVA: 0x003DA441 File Offset: 0x003D8641
		public ExtensionsToggleGroup group
		{
			get
			{
				return this.m_Group;
			}
			set
			{
				this.m_Group = value;
				this.HJBDBMLACBF(this.m_Group, true);
				this.IECAINIGOKL(true);
			}
		}

		// Token: 0x0600A43B RID: 42043 RVA: 0x003C2EFE File Offset: 0x003C10FE
		private Transform AHOCKLILCOH()
		{
			return base.transform;
		}

		// Token: 0x0600A43C RID: 42044 RVA: 0x003DA460 File Offset: 0x003D8660
		private void IECAINIGOKL(bool JJNONJPOOFJ)
		{
			if (this.graphic == null)
			{
				return;
			}
			this.graphic.CrossFadeAlpha((!this.m_IsOn) ? 0f : 1f, (!JJNONJPOOFJ) ? 0.1f : 0f, true);
		}

		// Token: 0x0600A43D RID: 42045 RVA: 0x003DA4BA File Offset: 0x003D86BA
		public bool MNLDFHKEIOE()
		{
			return this.m_IsOn;
		}

		// Token: 0x0600A43E RID: 42046 RVA: 0x003DA4C2 File Offset: 0x003D86C2
		protected virtual void LIEGJOHINGC()
		{
			this.HJBDBMLACBF(null, true);
			base.OnDisable();
		}

		// Token: 0x0600A43F RID: 42047 RVA: 0x003DA4D2 File Offset: 0x003D86D2
		protected override void OnDisable()
		{
			this.HJBDBMLACBF(null, false);
			base.OnDisable();
		}

		// Token: 0x0600A440 RID: 42048 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void KBOLPAJJDGF()
		{
		}

		// Token: 0x0600A441 RID: 42049 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void LayoutComplete()
		{
		}

		// Token: 0x0600A442 RID: 42050 RVA: 0x003DA4E2 File Offset: 0x003D86E2
		public virtual void PPHPNDADENH(BaseEventData OLIIPKODDIN)
		{
			this.KALHOIDEONN();
		}

		// Token: 0x0600A443 RID: 42051 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void LACGFFHBNDA(CanvasUpdate HDOMJLCMNHL)
		{
		}

		// Token: 0x0600A444 RID: 42052 RVA: 0x003DA4EA File Offset: 0x003D86EA
		private void MELMKOBADKE(bool DPNHODJHGJL)
		{
			this.FHOOJGBHPLI(DPNHODJHGJL, false);
		}

		// Token: 0x0600A445 RID: 42053 RVA: 0x003DA4F4 File Offset: 0x003D86F4
		public virtual void DIAEKNMELKB(PointerEventData OLIIPKODDIN)
		{
			if (OLIIPKODDIN.button != PointerEventData.InputButton.Left)
			{
				return;
			}
			this.OAKJNNOMJDO();
		}

		// Token: 0x0600A446 RID: 42054 RVA: 0x003DA508 File Offset: 0x003D8708
		protected ExtensionsToggle()
		{
		}

		// Token: 0x0600A447 RID: 42055 RVA: 0x003DA524 File Offset: 0x003D8724
		protected virtual void DECJLOLKJMI()
		{
			if (this.graphic != null)
			{
				bool flag = !Mathf.Approximately(this.graphic.canvasRenderer.GetColor().a, 97f);
				if (this.m_IsOn != flag)
				{
					this.m_IsOn = flag;
					this.MELMKOBADKE(!flag);
				}
			}
			base.OnDidApplyAnimationProperties();
		}

		// Token: 0x0600A448 RID: 42056 RVA: 0x003DA58B File Offset: 0x003D878B
		public virtual void MGPANACIIOC(PointerEventData OLIIPKODDIN)
		{
			if (OLIIPKODDIN.button != PointerEventData.InputButton.Left)
			{
				return;
			}
			this.KALHOIDEONN();
		}

		// Token: 0x0600A449 RID: 42057 RVA: 0x003DA59F File Offset: 0x003D879F
		public ExtensionsToggleGroup CNOHIMBEPIE()
		{
			return this.m_Group;
		}

		// Token: 0x0600A44A RID: 42058 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void FNKBHGGMGJE(CanvasUpdate HDOMJLCMNHL)
		{
		}

		// Token: 0x0600A44B RID: 42059 RVA: 0x003DA5A8 File Offset: 0x003D87A8
		private void JMHAAPDLHHB(bool DPNHODJHGJL, bool IDBPIIECJEA)
		{
			if (this.m_IsOn == DPNHODJHGJL)
			{
				return;
			}
			this.m_IsOn = DPNHODJHGJL;
			if (this.m_Group != null && this.IsActive() && (this.m_IsOn || (!this.m_Group.PLNKAAFDOLH() && !this.m_Group.OGIGACJBJKL())))
			{
				this.m_IsOn = false;
				this.m_Group.ABCEPPEELDH(this);
			}
			this.CHEKFLDOOEM(this.toggleTransition == ExtensionsToggle.ToggleTransition.None);
			if (IDBPIIECJEA)
			{
				this.onValueChanged.Invoke(this.m_IsOn);
			}
		}

		// Token: 0x0600A44C RID: 42060 RVA: 0x003DA649 File Offset: 0x003D8849
		public void GPBKPNBCJEL(bool DPNHODJHGJL)
		{
			this.MELMKOBADKE(DPNHODJHGJL);
		}

		// Token: 0x0600A44D RID: 42061 RVA: 0x003DA652 File Offset: 0x003D8852
		private void OAKJNNOMJDO()
		{
			if (!this.IsActive() || !this.IsInteractable())
			{
				return;
			}
			this.GPBKPNBCJEL(!this.MNLDFHKEIOE());
		}

		// Token: 0x0600A44E RID: 42062 RVA: 0x003DA58B File Offset: 0x003D878B
		public virtual void NHKKJPKDMEB(PointerEventData OLIIPKODDIN)
		{
			if (OLIIPKODDIN.button != PointerEventData.InputButton.Left)
			{
				return;
			}
			this.KALHOIDEONN();
		}

		// Token: 0x0600A44F RID: 42063 RVA: 0x003DA67A File Offset: 0x003D887A
		protected virtual void JMEOGJHCONJ()
		{
			this.LMPKEBMIIMI(false);
		}

		// Token: 0x0600A450 RID: 42064 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void PCDPLFCHABO(CanvasUpdate HDOMJLCMNHL)
		{
		}

		// Token: 0x0600A451 RID: 42065 RVA: 0x003DA58B File Offset: 0x003D878B
		public virtual void JHMHPFOKLOA(PointerEventData OLIIPKODDIN)
		{
			if (OLIIPKODDIN.button != PointerEventData.InputButton.Left)
			{
				return;
			}
			this.KALHOIDEONN();
		}

		// Token: 0x0600A452 RID: 42066 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void DDMPHFCGMPI()
		{
		}

		// Token: 0x0600A453 RID: 42067 RVA: 0x003DA684 File Offset: 0x003D8884
		protected override void OnDidApplyAnimationProperties()
		{
			if (this.graphic != null)
			{
				bool flag = !Mathf.Approximately(this.graphic.canvasRenderer.GetColor().a, 0f);
				if (this.m_IsOn != flag)
				{
					this.m_IsOn = flag;
					this.JFLGGCEJDCB(!flag);
				}
			}
			base.OnDidApplyAnimationProperties();
		}

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x0600A45D RID: 42077 RVA: 0x003DA4BA File Offset: 0x003D86BA
		// (set) Token: 0x0600A454 RID: 42068 RVA: 0x003DA6EB File Offset: 0x003D88EB
		public bool isOn
		{
			get
			{
				return this.m_IsOn;
			}
			set
			{
				this.JFLGGCEJDCB(value);
			}
		}

		// Token: 0x0600A455 RID: 42069 RVA: 0x003C2EFE File Offset: 0x003C10FE
		private Transform LKLCJNKOCMI()
		{
			return base.transform;
		}

		// Token: 0x0600A456 RID: 42070 RVA: 0x003DA6F4 File Offset: 0x003D88F4
		protected virtual void GLKJFIOCPLF()
		{
			base.OnEnable();
			this.HLMNDJLDFDK(this.m_Group, true);
			this.IECAINIGOKL(true);
		}

		// Token: 0x0600A457 RID: 42071 RVA: 0x003DA4BA File Offset: 0x003D86BA
		public bool KJAEDHPGFOB()
		{
			return this.m_IsOn;
		}

		// Token: 0x0600A458 RID: 42072 RVA: 0x003DA710 File Offset: 0x003D8910
		protected override void Start()
		{
			this.IECAINIGOKL(true);
		}

		// Token: 0x0600A459 RID: 42073 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void FILKNDIIAOF(CanvasUpdate HDOMJLCMNHL)
		{
		}

		// Token: 0x0600A45A RID: 42074 RVA: 0x003DA59F File Offset: 0x003D879F
		public ExtensionsToggleGroup JPLOECJDHMK()
		{
			return this.m_Group;
		}

		// Token: 0x0600A45B RID: 42075 RVA: 0x003DA71C File Offset: 0x003D891C
		private void HNPLLOGEEDE(bool JJNONJPOOFJ)
		{
			if (this.graphic == null)
			{
				return;
			}
			this.graphic.CrossFadeAlpha((!this.m_IsOn) ? 513f : 1553f, (!JJNONJPOOFJ) ? 102f : 933f, true);
		}

		// Token: 0x0600A45C RID: 42076 RVA: 0x003DA58B File Offset: 0x003D878B
		public virtual void OnPointerClick(PointerEventData OLIIPKODDIN)
		{
			if (OLIIPKODDIN.button != PointerEventData.InputButton.Left)
			{
				return;
			}
			this.KALHOIDEONN();
		}

		// Token: 0x0600A45F RID: 42079 RVA: 0x003DA778 File Offset: 0x003D8978
		protected virtual void IJDIHIJFGOD()
		{
			if (this.graphic != null)
			{
				bool flag = Mathf.Approximately(this.graphic.canvasRenderer.GetColor().a, 1138f);
				if (this.m_IsOn != flag)
				{
					this.m_IsOn = flag;
					this.MELMKOBADKE(flag);
				}
			}
			base.OnDidApplyAnimationProperties();
		}

		// Token: 0x0600A460 RID: 42080 RVA: 0x003DA7DF File Offset: 0x003D89DF
		public void PLACJJBAABF(ExtensionsToggleGroup DPNHODJHGJL)
		{
			this.m_Group = DPNHODJHGJL;
			this.HLMNDJLDFDK(this.m_Group, true);
			this.PDGDHMLNMDE(true);
		}

		// Token: 0x0600A461 RID: 42081 RVA: 0x003C2EFE File Offset: 0x003C10FE
		Transform ICanvasElement.get_transform()
		{
			return base.transform;
		}

		// Token: 0x0600A462 RID: 42082 RVA: 0x003DA4F4 File Offset: 0x003D86F4
		public virtual void HKOMFFBNCNJ(PointerEventData OLIIPKODDIN)
		{
			if (OLIIPKODDIN.button != PointerEventData.InputButton.Left)
			{
				return;
			}
			this.OAKJNNOMJDO();
		}

		// Token: 0x0600A463 RID: 42083 RVA: 0x003DA7FC File Offset: 0x003D89FC
		protected virtual void JOONHGHGKKF()
		{
			this.HLMNDJLDFDK(null, true);
			base.OnDisable();
		}

		// Token: 0x0600A464 RID: 42084 RVA: 0x003DA4E2 File Offset: 0x003D86E2
		public virtual void OnSubmit(BaseEventData OLIIPKODDIN)
		{
			this.KALHOIDEONN();
		}

		// Token: 0x0600A465 RID: 42085 RVA: 0x003DA80C File Offset: 0x003D8A0C
		private void JFLGGCEJDCB(bool DPNHODJHGJL, bool IDBPIIECJEA)
		{
			if (this.m_IsOn == DPNHODJHGJL)
			{
				return;
			}
			this.m_IsOn = DPNHODJHGJL;
			if (this.m_Group != null && this.IsActive() && (this.m_IsOn || (!this.m_Group.AnyTogglesOn() && !this.m_Group.allowSwitchOff)))
			{
				this.m_IsOn = true;
				this.m_Group.NotifyToggleOn(this);
			}
			this.IECAINIGOKL(this.toggleTransition == ExtensionsToggle.ToggleTransition.None);
			if (IDBPIIECJEA)
			{
				this.onValueChanged.Invoke(this.m_IsOn);
			}
		}

		// Token: 0x0600A466 RID: 42086 RVA: 0x003DA58B File Offset: 0x003D878B
		public virtual void OBLKNHCABFO(PointerEventData OLIIPKODDIN)
		{
			if (OLIIPKODDIN.button != PointerEventData.InputButton.Left)
			{
				return;
			}
			this.KALHOIDEONN();
		}

		// Token: 0x0600A467 RID: 42087 RVA: 0x003DA8B0 File Offset: 0x003D8AB0
		private void PDGDHMLNMDE(bool JJNONJPOOFJ)
		{
			if (this.graphic == null)
			{
				return;
			}
			this.graphic.CrossFadeAlpha((!this.m_IsOn) ? 1854f : 22f, (!JJNONJPOOFJ) ? 1208f : 1379f, true);
		}

		// Token: 0x0600A468 RID: 42088 RVA: 0x003DA90C File Offset: 0x003D8B0C
		private void HJBDBMLACBF(ExtensionsToggleGroup ALBPFJHDHLJ, bool IEIEOHEGIJM)
		{
			ExtensionsToggleGroup group = this.m_Group;
			if (this.m_Group != null)
			{
				this.m_Group.UnregisterToggle(this);
			}
			if (IEIEOHEGIJM)
			{
				this.m_Group = ALBPFJHDHLJ;
			}
			if (this.m_Group != null && this.IsActive())
			{
				this.m_Group.RegisterToggle(this);
			}
			if (ALBPFJHDHLJ != null && ALBPFJHDHLJ != group && this.isOn && this.IsActive())
			{
				this.m_Group.NotifyToggleOn(this);
			}
		}

		// Token: 0x0600A469 RID: 42089 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void Rebuild(CanvasUpdate HDOMJLCMNHL)
		{
		}

		// Token: 0x0600A46A RID: 42090 RVA: 0x003DA59F File Offset: 0x003D879F
		public ExtensionsToggleGroup EGKFHGDEOBC()
		{
			return this.m_Group;
		}

		// Token: 0x0600A46B RID: 42091 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void AKAMLCGHLEN()
		{
		}

		// Token: 0x0600A46C RID: 42092 RVA: 0x003DA9AC File Offset: 0x003D8BAC
		private void FHOOJGBHPLI(bool DPNHODJHGJL, bool IDBPIIECJEA)
		{
			if (this.m_IsOn == DPNHODJHGJL)
			{
				return;
			}
			this.m_IsOn = DPNHODJHGJL;
			if (this.m_Group != null && this.IsActive() && (this.m_IsOn || (!this.m_Group.PLNKAAFDOLH() && !this.m_Group.JGOIBHNEELF())))
			{
				this.m_IsOn = false;
				this.m_Group.DBNOGOBOPIO(this);
			}
			this.HNPLLOGEEDE(this.toggleTransition == ExtensionsToggle.ToggleTransition.Fade);
			if (IDBPIIECJEA)
			{
				this.onValueChanged.Invoke(this.m_IsOn);
			}
		}

		// Token: 0x0600A46D RID: 42093 RVA: 0x003C2EFE File Offset: 0x003C10FE
		private Transform AGENBNFKKOH()
		{
			return base.transform;
		}

		// Token: 0x0600A46E RID: 42094 RVA: 0x003DA4F4 File Offset: 0x003D86F4
		public virtual void AHGBGNFNLPF(PointerEventData OLIIPKODDIN)
		{
			if (OLIIPKODDIN.button != PointerEventData.InputButton.Left)
			{
				return;
			}
			this.OAKJNNOMJDO();
		}

		// Token: 0x0600A46F RID: 42095 RVA: 0x003DAA4D File Offset: 0x003D8C4D
		protected virtual void JHLGHODFJOO()
		{
			this.HLMNDJLDFDK(null, false);
			base.OnDisable();
		}

		// Token: 0x0600A470 RID: 42096 RVA: 0x003DAA5D File Offset: 0x003D8C5D
		protected virtual void DLBODOFAJGM()
		{
			this.HNPLLOGEEDE(false);
		}

		// Token: 0x0600A471 RID: 42097 RVA: 0x003DA439 File Offset: 0x003D8639
		private bool ODHKEFJBENI()
		{
			return base.IsDestroyed();
		}

		// Token: 0x0600A472 RID: 42098 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void GraphicUpdateComplete()
		{
		}

		// Token: 0x0600A473 RID: 42099 RVA: 0x003DA4BA File Offset: 0x003D86BA
		public bool CKHMHGANJBA()
		{
			return this.m_IsOn;
		}

		// Token: 0x0600A474 RID: 42100 RVA: 0x003DA59F File Offset: 0x003D879F
		public ExtensionsToggleGroup HIMLJHHPMKA()
		{
			return this.m_Group;
		}

		// Token: 0x0600A475 RID: 42101 RVA: 0x003DAA66 File Offset: 0x003D8C66
		private void KALHOIDEONN()
		{
			if (!this.IsActive() || !this.IsInteractable())
			{
				return;
			}
			this.isOn = !this.isOn;
		}

		// Token: 0x0600A476 RID: 42102 RVA: 0x003DAA8E File Offset: 0x003D8C8E
		protected override void OnEnable()
		{
			base.OnEnable();
			this.HJBDBMLACBF(this.m_Group, false);
			this.IECAINIGOKL(true);
		}

		// Token: 0x0600A477 RID: 42103 RVA: 0x003DAAAC File Offset: 0x003D8CAC
		private void LMPKEBMIIMI(bool JJNONJPOOFJ)
		{
			if (this.graphic == null)
			{
				return;
			}
			this.graphic.CrossFadeAlpha((!this.m_IsOn) ? 145f : 473f, (!JJNONJPOOFJ) ? 1697f : 107f, false);
		}

		// Token: 0x0600A478 RID: 42104 RVA: 0x003DAB06 File Offset: 0x003D8D06
		public virtual void EDBIPDJFAME(BaseEventData OLIIPKODDIN)
		{
			this.OAKJNNOMJDO();
		}

		// Token: 0x0600A479 RID: 42105 RVA: 0x003DAB10 File Offset: 0x003D8D10
		private void CHEKFLDOOEM(bool JJNONJPOOFJ)
		{
			if (this.graphic == null)
			{
				return;
			}
			this.graphic.CrossFadeAlpha((!this.m_IsOn) ? 310f : 13f, (!JJNONJPOOFJ) ? 444f : 148f, false);
		}

		// Token: 0x0600A47A RID: 42106 RVA: 0x003DA439 File Offset: 0x003D8639
		private bool OJGHMBGHNDF()
		{
			return base.IsDestroyed();
		}

		// Token: 0x0600A47B RID: 42107 RVA: 0x003DAA5D File Offset: 0x003D8C5D
		protected virtual void MMMDPANNAIO()
		{
			this.HNPLLOGEEDE(false);
		}

		// Token: 0x0600A47C RID: 42108 RVA: 0x003DAB6A File Offset: 0x003D8D6A
		private void JFLGGCEJDCB(bool DPNHODJHGJL)
		{
			this.JFLGGCEJDCB(DPNHODJHGJL, true);
		}

		// Token: 0x0600A47D RID: 42109 RVA: 0x003DAB74 File Offset: 0x003D8D74
		protected virtual void BJCPCBIJDBC()
		{
			if (this.graphic != null)
			{
				bool flag = !Mathf.Approximately(this.graphic.canvasRenderer.GetColor().a, 1918f);
				if (this.m_IsOn != flag)
				{
					this.m_IsOn = flag;
					this.JFLGGCEJDCB(flag);
				}
			}
			base.OnDidApplyAnimationProperties();
		}

		// Token: 0x0600A47E RID: 42110 RVA: 0x003DA439 File Offset: 0x003D8639
		private bool MJJLHJMMBMF()
		{
			return base.IsDestroyed();
		}

		// Token: 0x0600A47F RID: 42111 RVA: 0x003DABDC File Offset: 0x003D8DDC
		private void HLMNDJLDFDK(ExtensionsToggleGroup ALBPFJHDHLJ, bool IEIEOHEGIJM)
		{
			ExtensionsToggleGroup group = this.m_Group;
			if (this.m_Group != null)
			{
				this.m_Group.FOMBNHFMFME(this);
			}
			if (IEIEOHEGIJM)
			{
				this.m_Group = ALBPFJHDHLJ;
			}
			if (this.m_Group != null && this.IsActive())
			{
				this.m_Group.HLIMABOOEEE(this);
			}
			if (ALBPFJHDHLJ != null && ALBPFJHDHLJ != group && this.isOn && this.IsActive())
			{
				this.m_Group.DBNOGOBOPIO(this);
			}
		}

		// Token: 0x04001292 RID: 4754
		public ExtensionsToggle.ToggleTransition toggleTransition = ExtensionsToggle.ToggleTransition.Fade;

		// Token: 0x04001293 RID: 4755
		public Graphic graphic;

		// Token: 0x04001294 RID: 4756
		[SerializeField]
		private ExtensionsToggleGroup m_Group;

		// Token: 0x04001295 RID: 4757
		public ExtensionsToggle.ToggleEvent onValueChanged = new ExtensionsToggle.ToggleEvent();

		// Token: 0x04001296 RID: 4758
		[SerializeField]
		[Tooltip("Is the toggle currently on or off?")]
		[FormerlySerializedAs("m_IsActive")]
		private bool m_IsOn;

		// Token: 0x020002AA RID: 682
		public enum ToggleTransition
		{
			// Token: 0x04001298 RID: 4760
			None,
			// Token: 0x04001299 RID: 4761
			Fade
		}

		// Token: 0x020002AB RID: 683
		[Serializable]
		public class ToggleEvent : UnityEvent<bool>
		{
		}
	}
}
