using System;
using System.Collections.Generic;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002D1 RID: 721
	[AddComponentMenu("UI/Extensions/UIScrollToSelection")]
	[RequireComponent(typeof(ScrollRect))]
	public class UIScrollToSelection : MonoBehaviour
	{
		// Token: 0x0600AACA RID: 43722 RVA: 0x003F5C68 File Offset: 0x003F3E68
		private void GOINBMNIELB()
		{
			if (this.MLIPKKCLJDF() != this.IHMDHALBHIC())
			{
				this.OCOOLBGJIAL((!(this.MLIPKKCLJDF() != null)) ? null : this.PNKNDAFPMHG().GetComponent<RectTransform>());
				if (this.LBICIIPAGKK != null && this.DPCDOMNCBFN().transform.parent == this.HJCOKFNFKDJ().transform)
				{
					this.HFJMGDJMLAP(false);
				}
			}
			this.LJIKIOGCCEP(this.LBICIIPAGKK);
		}

		// Token: 0x0600AACB RID: 43723 RVA: 0x003F5CFC File Offset: 0x003F3EFC
		protected void PINLIALFDIO(RectTransform DPNHODJHGJL)
		{
			this.<BCIONAIGIKD>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600AACC RID: 43724 RVA: 0x003F5D05 File Offset: 0x003F3F05
		protected virtual void BFIOIDMHPPL()
		{
			this.HDNNAALGKMP(base.GetComponent<ScrollRect>());
			this.DNGAMLHFBFI(this.PLFAAECNBJC().GetComponent<RectTransform>());
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x0600AACD RID: 43725 RVA: 0x003F5D24 File Offset: 0x003F3F24
		// (set) Token: 0x0600AB1E RID: 43806 RVA: 0x003F5F37 File Offset: 0x003F4137
		protected ScrollRect OIHONKLJKJL { get; set; }

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x0600AB18 RID: 43800 RVA: 0x003F6162 File Offset: 0x003F4362
		// (set) Token: 0x0600AACE RID: 43726 RVA: 0x003F5D2C File Offset: 0x003F3F2C
		protected bool CPGKCDHDAPG { get; set; }

		// Token: 0x0600AACF RID: 43727 RVA: 0x003F5D35 File Offset: 0x003F3F35
		protected List<KeyCode> KJLCNHMHDGC()
		{
			return this.cancelScrollKeycodes;
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x0600AAD0 RID: 43728 RVA: 0x003F5D3D File Offset: 0x003F3F3D
		// (set) Token: 0x0600AADD RID: 43741 RVA: 0x003F5CFC File Offset: 0x003F3EFC
		protected RectTransform DGBLLCKBLLP { get; set; }

		// Token: 0x0600AAD1 RID: 43729 RVA: 0x003F5D48 File Offset: 0x003F3F48
		private void IGOMDEPKPIL()
		{
			if ((!(this.OIHONKLJKJL == null) && !(this.HJCOKFNFKDJ() == null) && this.FDAMLNLKCNL() == null) || this.GFDIJPPFIIE())
			{
				return;
			}
			RectTransform rectTransform = this.EGANFFFMLFN;
			if (rectTransform == null || rectTransform.transform.parent != this.CDFNPNECNCC().transform)
			{
				return;
			}
			UIScrollToSelection.ScrollType scrollType = this.CFBBEPJGOII;
			if (scrollType != UIScrollToSelection.ScrollType.VERTICAL)
			{
				if (scrollType != UIScrollToSelection.ScrollType.HORIZONTAL)
				{
					if (scrollType == (UIScrollToSelection.ScrollType)5)
					{
						this.GECLCKJKMHF(rectTransform);
						this.OGFKFKLGPNP(rectTransform);
					}
				}
				else
				{
					this.OGFKFKLGPNP(rectTransform);
				}
			}
			else
			{
				this.NLBFAKOEHHK(rectTransform);
			}
		}

		// Token: 0x0600AAD2 RID: 43730 RVA: 0x003F5E18 File Offset: 0x003F4018
		protected float EJLPCMLFPFF()
		{
			return this.scrollSpeed;
		}

		// Token: 0x0600AAD3 RID: 43731 RVA: 0x003F5E20 File Offset: 0x003F4020
		protected virtual void BFFHPJMMGHD()
		{
			this.HDNNAALGKMP(base.GetComponent<ScrollRect>());
			this.DNGAMLHFBFI(this.FONOEIPHBEJ().GetComponent<RectTransform>());
		}

		// Token: 0x0600AAD4 RID: 43732 RVA: 0x003F5E3F File Offset: 0x003F403F
		protected void EBCOEEELIHF(RectTransform DPNHODJHGJL)
		{
			this.<BOCIEEKPPDF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600AAD5 RID: 43733 RVA: 0x003F5E48 File Offset: 0x003F4048
		private void IAJNFKODBFB()
		{
			if ((!(this.FONOEIPHBEJ() == null) && !(this.NKPADEMFCNN() == null) && this.MCJGPCMHDPD() == null) || this.GHHOHJPGPGC())
			{
				return;
			}
			RectTransform rectTransform = this.BMDEPBENOAF();
			if (rectTransform == null || rectTransform.transform.parent != this.CDFNPNECNCC().transform)
			{
				return;
			}
			UIScrollToSelection.ScrollType scrollType = this.CNBLDNGMDLL();
			if (scrollType != UIScrollToSelection.ScrollType.VERTICAL)
			{
				if (scrollType != UIScrollToSelection.ScrollType.HORIZONTAL)
				{
					if (scrollType == (UIScrollToSelection.ScrollType)5)
					{
						this.BDCLGDLIHEL(rectTransform);
						this.OGFKFKLGPNP(rectTransform);
					}
				}
				else
				{
					this.OGFKFKLGPNP(rectTransform);
				}
			}
			else
			{
				this.HPDBNNBGHDG(rectTransform);
			}
		}

		// Token: 0x0600AAD6 RID: 43734 RVA: 0x0002523B File Offset: 0x0002343B
		protected virtual void Start()
		{
		}

		// Token: 0x0600AAD7 RID: 43735 RVA: 0x003F5F18 File Offset: 0x003F4118
		protected virtual void Awake()
		{
			this.OIHONKLJKJL = base.GetComponent<ScrollRect>();
			this.DGBLLCKBLLP = this.OIHONKLJKJL.GetComponent<RectTransform>();
		}

		// Token: 0x0600AAD8 RID: 43736 RVA: 0x003F5D2C File Offset: 0x003F3F2C
		protected void HFJMGDJMLAP(bool DPNHODJHGJL)
		{
			this.<MHBEOEFFKJA>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x0600AAD9 RID: 43737 RVA: 0x003F5E18 File Offset: 0x003F4018
		protected float FOPIAABPHEA
		{
			get
			{
				return this.scrollSpeed;
			}
		}

		// Token: 0x0600AADA RID: 43738 RVA: 0x003F5F37 File Offset: 0x003F4137
		protected void HCHDKNAKEKM(ScrollRect DPNHODJHGJL)
		{
			this.<MLLDBKOEAPC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600AADB RID: 43739 RVA: 0x003F5D24 File Offset: 0x003F3F24
		protected ScrollRect FONOEIPHBEJ()
		{
			return this.<MLLDBKOEAPC>k__BackingField;
		}

		// Token: 0x0600AADC RID: 43740 RVA: 0x003F5F40 File Offset: 0x003F4140
		protected void MKEIHFAHOJC(GameObject DPNHODJHGJL)
		{
			this.<GPKIAEOFFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600AADE RID: 43742 RVA: 0x003F5F49 File Offset: 0x003F4149
		protected virtual void GDHMJGBAGHP()
		{
			this.OIHONKLJKJL = base.GetComponent<ScrollRect>();
			this.DGBLLCKBLLP = this.FONOEIPHBEJ().GetComponent<RectTransform>();
		}

		// Token: 0x0600AADF RID: 43743 RVA: 0x003F5F68 File Offset: 0x003F4168
		protected RectTransform JNDFFFPLNHP()
		{
			return this.<BOCIEEKPPDF>k__BackingField;
		}

		// Token: 0x0600AAE0 RID: 43744 RVA: 0x0002523B File Offset: 0x0002343B
		protected virtual void KDMKDEKCELE()
		{
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x0600AAE1 RID: 43745 RVA: 0x003F5F70 File Offset: 0x003F4170
		protected RectTransform DFOJOGPOADK
		{
			get
			{
				return (!(this.OIHONKLJKJL != null)) ? null : this.OIHONKLJKJL.content;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x0600AAE2 RID: 43746 RVA: 0x003F5F94 File Offset: 0x003F4194
		protected GameObject LBICIIPAGKK
		{
			get
			{
				return EventSystem.current.currentSelectedGameObject;
			}
		}

		// Token: 0x0600AAE3 RID: 43747 RVA: 0x003F5FA0 File Offset: 0x003F41A0
		protected RectTransform NKPADEMFCNN()
		{
			return (!(this.PLFAAECNBJC() != null)) ? null : this.FONOEIPHBEJ().content;
		}

		// Token: 0x0600AAE4 RID: 43748 RVA: 0x003F5D3D File Offset: 0x003F3F3D
		protected RectTransform FDAMLNLKCNL()
		{
			return this.<BCIONAIGIKD>k__BackingField;
		}

		// Token: 0x0600AAE5 RID: 43749 RVA: 0x003F5FC4 File Offset: 0x003F41C4
		private void IJMALCJEOBL()
		{
			if (this.LBICIIPAGKK != this.LDJOFOMGHBK)
			{
				this.EGANFFFMLFN = ((!(this.LBICIIPAGKK != null)) ? null : this.LBICIIPAGKK.GetComponent<RectTransform>());
				if (this.LBICIIPAGKK != null && this.LBICIIPAGKK.transform.parent == this.DFOJOGPOADK.transform)
				{
					this.CPGKCDHDAPG = false;
				}
			}
			this.LDJOFOMGHBK = this.LBICIIPAGKK;
		}

		// Token: 0x0600AAE6 RID: 43750 RVA: 0x003F5F40 File Offset: 0x003F4140
		protected void LJIKIOGCCEP(GameObject DPNHODJHGJL)
		{
			this.<GPKIAEOFFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600AAE7 RID: 43751 RVA: 0x003F5D2C File Offset: 0x003F3F2C
		protected void IJCJNHIDILL(bool DPNHODJHGJL)
		{
			this.<MHBEOEFFKJA>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600AAE8 RID: 43752 RVA: 0x003F5FA0 File Offset: 0x003F41A0
		protected RectTransform HJCOKFNFKDJ()
		{
			return (!(this.PLFAAECNBJC() != null)) ? null : this.FONOEIPHBEJ().content;
		}

		// Token: 0x17000228 RID: 552
		// (get) Token: 0x0600AAE9 RID: 43753 RVA: 0x003F5F68 File Offset: 0x003F4168
		// (set) Token: 0x0600AB29 RID: 43817 RVA: 0x003F5E3F File Offset: 0x003F403F
		protected RectTransform EGANFFFMLFN { get; set; }

		// Token: 0x0600AAEA RID: 43754 RVA: 0x003F6058 File Offset: 0x003F4258
		private void JDKFCHIKIOE()
		{
			if ((!(this.OIHONKLJKJL == null) && !(this.HJCOKFNFKDJ() == null) && this.FDAMLNLKCNL() == null) || this.NPFMOKPIOOG())
			{
				return;
			}
			RectTransform rectTransform = this.EGANFFFMLFN;
			if (rectTransform == null || rectTransform.transform.parent != this.CDFNPNECNCC().transform)
			{
				return;
			}
			UIScrollToSelection.ScrollType scrollType = this.CNBLDNGMDLL();
			if (scrollType != UIScrollToSelection.ScrollType.VERTICAL)
			{
				if (scrollType != UIScrollToSelection.ScrollType.VERTICAL)
				{
					if (scrollType == UIScrollToSelection.ScrollType.VERTICAL)
					{
						this.BDCLGDLIHEL(rectTransform);
						this.OGFKFKLGPNP(rectTransform);
					}
				}
				else
				{
					this.OGFKFKLGPNP(rectTransform);
				}
			}
			else
			{
				this.BDCLGDLIHEL(rectTransform);
			}
		}

		// Token: 0x0600AAEB RID: 43755 RVA: 0x003F6128 File Offset: 0x003F4328
		protected virtual void BGFJOEPFOPM()
		{
			this.OCOCJIKDNGK();
			this.BDIDKNDEDGN();
			this.IGOMDEPKPIL();
		}

		// Token: 0x0600AAEC RID: 43756 RVA: 0x003F613C File Offset: 0x003F433C
		protected EventSystem FOGGDEHDAAD()
		{
			return EventSystem.current;
		}

		// Token: 0x0600AAED RID: 43757 RVA: 0x003F6143 File Offset: 0x003F4343
		protected virtual void BGFCMMDKCOI()
		{
			this.HDNNAALGKMP(base.GetComponent<ScrollRect>());
			this.NPLLDALFNOB(this.OIHONKLJKJL.GetComponent<RectTransform>());
		}

		// Token: 0x0600AAEE RID: 43758 RVA: 0x003F6162 File Offset: 0x003F4362
		protected bool GHHOHJPGPGC()
		{
			return this.<MHBEOEFFKJA>k__BackingField;
		}

		// Token: 0x0600AAEF RID: 43759 RVA: 0x003F616A File Offset: 0x003F436A
		protected virtual void KEKNHAAEPCJ()
		{
			this.HCHDKNAKEKM(base.GetComponent<ScrollRect>());
			this.KLCPNPMPPFB(this.FONOEIPHBEJ().GetComponent<RectTransform>());
		}

		// Token: 0x0600AAF0 RID: 43760 RVA: 0x003F6189 File Offset: 0x003F4389
		protected virtual void KMEONPMCNJG()
		{
			this.IJMALCJEOBL();
			this.ICODHPOOFHE();
			this.IGOMDEPKPIL();
		}

		// Token: 0x0600AAF1 RID: 43761 RVA: 0x003F61A0 File Offset: 0x003F43A0
		private void ICODHPOOFHE()
		{
			if (!this.HIHIKGCGPNP() || this.NPFMOKPIOOG())
			{
				return;
			}
			for (int i = 0; i < this.DMANIJECOBE().Count; i += 0)
			{
				if (Input.GetKeyDown(this.FCOKMBCJJJA[i]))
				{
					this.IJCJNHIDILL(false);
					break;
				}
			}
		}

		// Token: 0x0600AAF2 RID: 43762 RVA: 0x003F5F40 File Offset: 0x003F4140
		protected void KFPGHNNHAHF(GameObject DPNHODJHGJL)
		{
			this.<GPKIAEOFFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600AAF3 RID: 43763 RVA: 0x003F5CFC File Offset: 0x003F3EFC
		protected void NPLLDALFNOB(RectTransform DPNHODJHGJL)
		{
			this.<BCIONAIGIKD>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x0600AAF4 RID: 43764 RVA: 0x003F6202 File Offset: 0x003F4402
		protected UIScrollToSelection.ScrollType CFBBEPJGOII
		{
			get
			{
				return this.scrollDirection;
			}
		}

		// Token: 0x0600AAF5 RID: 43765 RVA: 0x003F620C File Offset: 0x003F440C
		private void HFMAIPOOBFC()
		{
			if (this.PNKNDAFPMHG() != this.DAOKHJBAEGK())
			{
				this.EGANFFFMLFN = ((!(this.DPCDOMNCBFN() != null)) ? null : this.DPCDOMNCBFN().GetComponent<RectTransform>());
				if (this.LBICIIPAGKK != null && this.DPCDOMNCBFN().transform.parent == this.DFOJOGPOADK.transform)
				{
					this.DGELBCHKBBC(true);
				}
			}
			this.INPNDCOLOMN(this.PNKNDAFPMHG());
		}

		// Token: 0x0600AAF6 RID: 43766 RVA: 0x003F62A0 File Offset: 0x003F44A0
		protected GameObject IHMDHALBHIC()
		{
			return this.<GPKIAEOFFIC>k__BackingField;
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x0600AAF7 RID: 43767 RVA: 0x003F613C File Offset: 0x003F433C
		protected EventSystem IAOHNLNKBMK
		{
			get
			{
				return EventSystem.current;
			}
		}

		// Token: 0x0600AAF8 RID: 43768 RVA: 0x003F62A8 File Offset: 0x003F44A8
		private void BDCLGDLIHEL(RectTransform IOBBONEKIHM)
		{
			float jopcodojbhd = -IOBBONEKIHM.anchoredPosition.y;
			float height = IOBBONEKIHM.rect.height;
			float height2 = this.MCJGPCMHDPD().rect.height;
			float y = this.NKPADEMFCNN().anchoredPosition.y;
			float num = this.KCECPJNNEAO(jopcodojbhd, y, height, height2);
			this.FONOEIPHBEJ().verticalNormalizedPosition += num / this.HJCOKFNFKDJ().rect.height * Time.deltaTime * this.scrollSpeed;
		}

		// Token: 0x0600AAF9 RID: 43769 RVA: 0x003F5D35 File Offset: 0x003F3F35
		protected List<KeyCode> DKJMLEDJJOB()
		{
			return this.cancelScrollKeycodes;
		}

		// Token: 0x0600AAFA RID: 43770 RVA: 0x003F6344 File Offset: 0x003F4544
		private float LOHEMIPBINL(float JOPCODOJBHD, float LBGOMOMPJOB, float MAFFCAGDNPC, float MAKPLFCPGFO)
		{
			if (JOPCODOJBHD < LBGOMOMPJOB)
			{
				return LBGOMOMPJOB - JOPCODOJBHD;
			}
			if (JOPCODOJBHD + MAFFCAGDNPC > LBGOMOMPJOB + MAKPLFCPGFO)
			{
				return LBGOMOMPJOB + MAKPLFCPGFO - (JOPCODOJBHD + MAFFCAGDNPC);
			}
			return 1281f;
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x0600AB24 RID: 43812 RVA: 0x003F62A0 File Offset: 0x003F44A0
		// (set) Token: 0x0600AAFC RID: 43772 RVA: 0x003F5F40 File Offset: 0x003F4140
		protected GameObject LDJOFOMGHBK { get; set; }

		// Token: 0x0600AAFD RID: 43773 RVA: 0x003F638C File Offset: 0x003F458C
		private void OCOCJIKDNGK()
		{
			if (this.LBICIIPAGKK != this.LDJOFOMGHBK)
			{
				this.OCOOLBGJIAL((!(this.PNKNDAFPMHG() != null)) ? null : this.DPCDOMNCBFN().GetComponent<RectTransform>());
				if (this.PNKNDAFPMHG() != null && this.DPCDOMNCBFN().transform.parent == this.NKPADEMFCNN().transform)
				{
					this.HFJMGDJMLAP(false);
				}
			}
			this.INPNDCOLOMN(this.PNKNDAFPMHG());
		}

		// Token: 0x0600AAFE RID: 43774 RVA: 0x003F6420 File Offset: 0x003F4620
		private void GECLCKJKMHF(RectTransform IOBBONEKIHM)
		{
			float jopcodojbhd = -IOBBONEKIHM.anchoredPosition.y;
			float height = IOBBONEKIHM.rect.height;
			float height2 = this.FDAMLNLKCNL().rect.height;
			float y = this.NKPADEMFCNN().anchoredPosition.y;
			float num = this.KCECPJNNEAO(jopcodojbhd, y, height, height2);
			this.OIHONKLJKJL.verticalNormalizedPosition += num / this.DFOJOGPOADK.rect.height * Time.deltaTime * this.scrollSpeed;
		}

		// Token: 0x0600AAFF RID: 43775 RVA: 0x003F64BC File Offset: 0x003F46BC
		protected bool HIHIKGCGPNP()
		{
			return this.cancelScrollOnInput;
		}

		// Token: 0x0600AB00 RID: 43776 RVA: 0x003F5CFC File Offset: 0x003F3EFC
		protected void KLCPNPMPPFB(RectTransform DPNHODJHGJL)
		{
			this.<BCIONAIGIKD>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600AB01 RID: 43777 RVA: 0x003F64C4 File Offset: 0x003F46C4
		protected virtual void JOACBIEHHCE()
		{
			this.GOINBMNIELB();
			this.BDIDKNDEDGN();
			this.IGOMDEPKPIL();
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x0600AB02 RID: 43778 RVA: 0x003F5D35 File Offset: 0x003F3F35
		protected List<KeyCode> FCOKMBCJJJA
		{
			get
			{
				return this.cancelScrollKeycodes;
			}
		}

		// Token: 0x0600AB03 RID: 43779 RVA: 0x003F613C File Offset: 0x003F433C
		protected EventSystem EDDJPGPFCMO()
		{
			return EventSystem.current;
		}

		// Token: 0x0600AB04 RID: 43780 RVA: 0x003F5F94 File Offset: 0x003F4194
		protected GameObject MLIPKKCLJDF()
		{
			return EventSystem.current.currentSelectedGameObject;
		}

		// Token: 0x0600AB05 RID: 43781 RVA: 0x003F5D35 File Offset: 0x003F3F35
		protected List<KeyCode> DMANIJECOBE()
		{
			return this.cancelScrollKeycodes;
		}

		// Token: 0x0600AB06 RID: 43782 RVA: 0x003F64D8 File Offset: 0x003F46D8
		private void BMOFLIMKOIA()
		{
			if (this.DPCDOMNCBFN() != this.DAOKHJBAEGK())
			{
				this.OCOOLBGJIAL((!(this.MLIPKKCLJDF() != null)) ? null : this.LBICIIPAGKK.GetComponent<RectTransform>());
				if (this.PNKNDAFPMHG() != null && this.MLIPKKCLJDF().transform.parent == this.NKPADEMFCNN().transform)
				{
					this.CPGKCDHDAPG = true;
				}
			}
			this.KFPGHNNHAHF(this.PNKNDAFPMHG());
		}

		// Token: 0x0600AB07 RID: 43783 RVA: 0x003F5F68 File Offset: 0x003F4168
		protected RectTransform BMDEPBENOAF()
		{
			return this.<BOCIEEKPPDF>k__BackingField;
		}

		// Token: 0x0600AB08 RID: 43784 RVA: 0x003F656C File Offset: 0x003F476C
		private float KCECPJNNEAO(float JOPCODOJBHD, float LBGOMOMPJOB, float MAFFCAGDNPC, float MAKPLFCPGFO)
		{
			if (JOPCODOJBHD < LBGOMOMPJOB)
			{
				return LBGOMOMPJOB - JOPCODOJBHD;
			}
			if (JOPCODOJBHD + MAFFCAGDNPC > LBGOMOMPJOB + MAKPLFCPGFO)
			{
				return LBGOMOMPJOB + MAKPLFCPGFO - (JOPCODOJBHD + MAFFCAGDNPC);
			}
			return 0f;
		}

		// Token: 0x0600AB09 RID: 43785 RVA: 0x003F6594 File Offset: 0x003F4794
		private void BFACEMCPIAI()
		{
			if (this.OIHONKLJKJL == null || this.DFOJOGPOADK == null || this.DGBLLCKBLLP == null || this.CPGKCDHDAPG)
			{
				return;
			}
			RectTransform rectTransform = this.EGANFFFMLFN;
			if (rectTransform == null || rectTransform.transform.parent != this.DFOJOGPOADK.transform)
			{
				return;
			}
			UIScrollToSelection.ScrollType scrollType = this.CFBBEPJGOII;
			if (scrollType != UIScrollToSelection.ScrollType.VERTICAL)
			{
				if (scrollType != UIScrollToSelection.ScrollType.HORIZONTAL)
				{
					if (scrollType == UIScrollToSelection.ScrollType.BOTH)
					{
						this.NLBFAKOEHHK(rectTransform);
						this.OGFKFKLGPNP(rectTransform);
					}
				}
				else
				{
					this.OGFKFKLGPNP(rectTransform);
				}
			}
			else
			{
				this.NLBFAKOEHHK(rectTransform);
			}
		}

		// Token: 0x0600AB0A RID: 43786 RVA: 0x003F5D24 File Offset: 0x003F3F24
		protected ScrollRect PLFAAECNBJC()
		{
			return this.<MLLDBKOEAPC>k__BackingField;
		}

		// Token: 0x0600AB0B RID: 43787 RVA: 0x003F6664 File Offset: 0x003F4864
		private void HPDBNNBGHDG(RectTransform IOBBONEKIHM)
		{
			float jopcodojbhd = -IOBBONEKIHM.anchoredPosition.y;
			float height = IOBBONEKIHM.rect.height;
			float height2 = this.DGBLLCKBLLP.rect.height;
			float y = this.CDFNPNECNCC().anchoredPosition.y;
			float num = this.LOHEMIPBINL(jopcodojbhd, y, height, height2);
			this.PLFAAECNBJC().verticalNormalizedPosition += num / this.DFOJOGPOADK.rect.height * Time.deltaTime * this.scrollSpeed;
		}

		// Token: 0x0600AB0C RID: 43788 RVA: 0x003F5E3F File Offset: 0x003F403F
		protected void OCOOLBGJIAL(RectTransform DPNHODJHGJL)
		{
			this.<BOCIEEKPPDF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600AB0D RID: 43789 RVA: 0x003F5D2C File Offset: 0x003F3F2C
		protected void CDGGEEDBLBC(bool DPNHODJHGJL)
		{
			this.<MHBEOEFFKJA>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600AB0E RID: 43790 RVA: 0x0002523B File Offset: 0x0002343B
		protected virtual void NNFMIAFHMJM()
		{
		}

		// Token: 0x0600AB0F RID: 43791 RVA: 0x003F5CFC File Offset: 0x003F3EFC
		protected void DNGAMLHFBFI(RectTransform DPNHODJHGJL)
		{
			this.<BCIONAIGIKD>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600AB10 RID: 43792 RVA: 0x003F6700 File Offset: 0x003F4900
		private void OGCJEFFNIFG()
		{
			if ((!(this.PLFAAECNBJC() == null) && !(this.DFOJOGPOADK == null) && this.FDAMLNLKCNL() == null) || this.NPFMOKPIOOG())
			{
				return;
			}
			RectTransform rectTransform = this.BMDEPBENOAF();
			if (rectTransform == null || rectTransform.transform.parent != this.HJCOKFNFKDJ().transform)
			{
				return;
			}
			UIScrollToSelection.ScrollType scrollType = this.CNBLDNGMDLL();
			if (scrollType != UIScrollToSelection.ScrollType.VERTICAL)
			{
				if (scrollType != UIScrollToSelection.ScrollType.HORIZONTAL)
				{
					if (scrollType == (UIScrollToSelection.ScrollType)6)
					{
						this.GECLCKJKMHF(rectTransform);
						this.OGFKFKLGPNP(rectTransform);
					}
				}
				else
				{
					this.OGFKFKLGPNP(rectTransform);
				}
			}
			else
			{
				this.HPDBNNBGHDG(rectTransform);
			}
		}

		// Token: 0x0600AB11 RID: 43793 RVA: 0x003F67D0 File Offset: 0x003F49D0
		protected virtual void Update()
		{
			this.IJMALCJEOBL();
			this.GPOOGEIEHBN();
			this.BFACEMCPIAI();
		}

		// Token: 0x0600AB12 RID: 43794 RVA: 0x003F67E4 File Offset: 0x003F49E4
		private void BDIDKNDEDGN()
		{
			if (!this.IGGDAIAPCIH || this.CPGKCDHDAPG)
			{
				return;
			}
			for (int i = 1; i < this.CHAKNDBEGEB().Count; i++)
			{
				if (Input.GetKeyDown(this.DKJMLEDJJOB()[i]))
				{
					this.IJCJNHIDILL(false);
					break;
				}
			}
		}

		// Token: 0x0600AB13 RID: 43795 RVA: 0x003F5F94 File Offset: 0x003F4194
		protected GameObject DPCDOMNCBFN()
		{
			return EventSystem.current.currentSelectedGameObject;
		}

		// Token: 0x0600AB14 RID: 43796 RVA: 0x003F64BC File Offset: 0x003F46BC
		protected bool HNLBPJMOFBO()
		{
			return this.cancelScrollOnInput;
		}

		// Token: 0x0600AB15 RID: 43797 RVA: 0x003F5D35 File Offset: 0x003F3F35
		protected List<KeyCode> IDCLIGKLOPN()
		{
			return this.cancelScrollKeycodes;
		}

		// Token: 0x0600AB16 RID: 43798 RVA: 0x003F6846 File Offset: 0x003F4A46
		protected RectTransform CDFNPNECNCC()
		{
			return (!(this.PLFAAECNBJC() != null)) ? null : this.PLFAAECNBJC().content;
		}

		// Token: 0x0600AB17 RID: 43799 RVA: 0x003F5D35 File Offset: 0x003F3F35
		protected List<KeyCode> CHAKNDBEGEB()
		{
			return this.cancelScrollKeycodes;
		}

		// Token: 0x0600AB19 RID: 43801 RVA: 0x003F686C File Offset: 0x003F4A6C
		private void OGFKFKLGPNP(RectTransform IOBBONEKIHM)
		{
			float x = IOBBONEKIHM.anchoredPosition.x;
			float width = IOBBONEKIHM.rect.width;
			float width2 = this.DGBLLCKBLLP.rect.width;
			float lbgomompjob = -this.DFOJOGPOADK.anchoredPosition.x;
			float num = -this.KCECPJNNEAO(x, lbgomompjob, width, width2);
			this.OIHONKLJKJL.horizontalNormalizedPosition += num / this.DFOJOGPOADK.rect.width * Time.deltaTime * this.scrollSpeed;
		}

		// Token: 0x0600AB1A RID: 43802 RVA: 0x003F62A0 File Offset: 0x003F44A0
		protected GameObject DAOKHJBAEGK()
		{
			return this.<GPKIAEOFFIC>k__BackingField;
		}

		// Token: 0x0600AB1B RID: 43803 RVA: 0x003F5D3D File Offset: 0x003F3F3D
		protected RectTransform MCJGPCMHDPD()
		{
			return this.<BCIONAIGIKD>k__BackingField;
		}

		// Token: 0x0600AB1C RID: 43804 RVA: 0x003F5F94 File Offset: 0x003F4194
		protected GameObject PNKNDAFPMHG()
		{
			return EventSystem.current.currentSelectedGameObject;
		}

		// Token: 0x0600AB1D RID: 43805 RVA: 0x003F690C File Offset: 0x003F4B0C
		private void NLBFAKOEHHK(RectTransform IOBBONEKIHM)
		{
			float jopcodojbhd = -IOBBONEKIHM.anchoredPosition.y;
			float height = IOBBONEKIHM.rect.height;
			float height2 = this.DGBLLCKBLLP.rect.height;
			float y = this.DFOJOGPOADK.anchoredPosition.y;
			float num = this.KCECPJNNEAO(jopcodojbhd, y, height, height2);
			this.OIHONKLJKJL.verticalNormalizedPosition += num / this.DFOJOGPOADK.rect.height * Time.deltaTime * this.scrollSpeed;
		}

		// Token: 0x0600AB1F RID: 43807 RVA: 0x003F5F37 File Offset: 0x003F4137
		protected void HDNNAALGKMP(ScrollRect DPNHODJHGJL)
		{
			this.<MLLDBKOEAPC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600AB20 RID: 43808 RVA: 0x0002523B File Offset: 0x0002343B
		protected virtual void IMCKJCHKMKB()
		{
		}

		// Token: 0x0600AB21 RID: 43809 RVA: 0x003F5F40 File Offset: 0x003F4140
		protected void INPNDCOLOMN(GameObject DPNHODJHGJL)
		{
			this.<GPKIAEOFFIC>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600AB22 RID: 43810 RVA: 0x0002523B File Offset: 0x0002343B
		protected virtual void BMIOFJFMCBG()
		{
		}

		// Token: 0x0600AB23 RID: 43811 RVA: 0x003F5D2C File Offset: 0x003F3F2C
		protected void DGELBCHKBBC(bool DPNHODJHGJL)
		{
			this.<MHBEOEFFKJA>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x0600AB25 RID: 43813 RVA: 0x003F69A8 File Offset: 0x003F4BA8
		private void GPOOGEIEHBN()
		{
			if (!this.IGGDAIAPCIH || this.CPGKCDHDAPG)
			{
				return;
			}
			for (int i = 0; i < this.FCOKMBCJJJA.Count; i++)
			{
				if (Input.GetKeyDown(this.FCOKMBCJJJA[i]))
				{
					this.CPGKCDHDAPG = true;
					break;
				}
			}
		}

		// Token: 0x0600AB26 RID: 43814 RVA: 0x003F6162 File Offset: 0x003F4362
		protected bool GFDIJPPFIIE()
		{
			return this.<MHBEOEFFKJA>k__BackingField;
		}

		// Token: 0x0600AB27 RID: 43815 RVA: 0x003F5E18 File Offset: 0x003F4018
		protected float IGAKDGBOCGE()
		{
			return this.scrollSpeed;
		}

		// Token: 0x0600AB28 RID: 43816 RVA: 0x003F6202 File Offset: 0x003F4402
		protected UIScrollToSelection.ScrollType CNBLDNGMDLL()
		{
			return this.scrollDirection;
		}

		// Token: 0x0600AB2A RID: 43818 RVA: 0x003F6162 File Offset: 0x003F4362
		protected bool NPFMOKPIOOG()
		{
			return this.<MHBEOEFFKJA>k__BackingField;
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x0600AB2B RID: 43819 RVA: 0x003F64BC File Offset: 0x003F46BC
		protected bool IGGDAIAPCIH
		{
			get
			{
				return this.cancelScrollOnInput;
			}
		}

		// Token: 0x0600AB2C RID: 43820 RVA: 0x003F6A0A File Offset: 0x003F4C0A
		protected virtual void ONMGIPAILOH()
		{
			this.BMOFLIMKOIA();
			this.ICODHPOOFHE();
			this.BFACEMCPIAI();
		}

		// Token: 0x0600AB2D RID: 43821 RVA: 0x003F613C File Offset: 0x003F433C
		protected EventSystem JECPIBFJHAF()
		{
			return EventSystem.current;
		}

		// Token: 0x040012EB RID: 4843
		[SerializeField]
		[Header("[ Settings ]")]
		private UIScrollToSelection.ScrollType scrollDirection;

		// Token: 0x040012EC RID: 4844
		[SerializeField]
		private float scrollSpeed = 10f;

		// Token: 0x040012ED RID: 4845
		[Header("[ Input ]")]
		[SerializeField]
		private bool cancelScrollOnInput;

		// Token: 0x040012EE RID: 4846
		[SerializeField]
		private List<KeyCode> cancelScrollKeycodes = new List<KeyCode>();

		// Token: 0x020002D2 RID: 722
		public enum ScrollType
		{
			// Token: 0x040012F5 RID: 4853
			VERTICAL,
			// Token: 0x040012F6 RID: 4854
			HORIZONTAL,
			// Token: 0x040012F7 RID: 4855
			BOTH
		}
	}
}
