using System;
using System.Runtime.CompilerServices;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002B4 RID: 692
	[AddComponentMenu("UI/Extensions/ScrollRectEx")]
	public class ScrollRectEx : ScrollRect
	{
		// Token: 0x0600A683 RID: 42627 RVA: 0x003E020C File Offset: 0x003DE40C
		public virtual void AAKNKKPBCBK(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.PBJKDHBPDOD pbjkdhbpdod = new ScrollRectEx.PBJKDHBPDOD();
			pbjkdhbpdod.OLIIPKODDIN = OLIIPKODDIN;
			this.GFMDKIDKIPP<IInitializePotentialDragHandler>(new Action<IInitializePotentialDragHandler>(pbjkdhbpdod.KGKMOLCPDIH));
			base.OnInitializePotentialDrag(pbjkdhbpdod.OLIIPKODDIN);
		}

		// Token: 0x0600A684 RID: 42628 RVA: 0x003E0244 File Offset: 0x003DE444
		public virtual void LODAKINFIKE(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.PBJKDHBPDOD pbjkdhbpdod = new ScrollRectEx.PBJKDHBPDOD();
			pbjkdhbpdod.OLIIPKODDIN = OLIIPKODDIN;
			this.GFMDKIDKIPP<IInitializePotentialDragHandler>(new Action<IInitializePotentialDragHandler>(pbjkdhbpdod.DNIMHEKGJHB));
			base.OnInitializePotentialDrag(pbjkdhbpdod.OLIIPKODDIN);
		}

		// Token: 0x0600A685 RID: 42629 RVA: 0x003E027C File Offset: 0x003DE47C
		public virtual void FNEMGJIABDO(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.DLBGDLICCMB dlbgdliccmb = new ScrollRectEx.DLBGDLICCMB();
			dlbgdliccmb.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IDragHandler>(new Action<IDragHandler>(dlbgdliccmb.DBFPGFHEGKA));
			}
			else
			{
				base.OnDrag(dlbgdliccmb.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A686 RID: 42630 RVA: 0x003E02C4 File Offset: 0x003DE4C4
		public virtual void KIEGDCLCJIB(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.HDNKAFOOCBL hdnkafoocbl = new ScrollRectEx.HDNKAFOOCBL();
			hdnkafoocbl.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IEndDragHandler>(new Action<IEndDragHandler>(hdnkafoocbl.MEMPOPNAEDN));
			}
			else
			{
				base.OnEndDrag(hdnkafoocbl.OLIIPKODDIN);
			}
			this.NPAFKDKFJDB = true;
		}

		// Token: 0x0600A687 RID: 42631 RVA: 0x003E0314 File Offset: 0x003DE514
		public virtual void JMPPAOIBBBF(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.HDNKAFOOCBL hdnkafoocbl = new ScrollRectEx.HDNKAFOOCBL();
			hdnkafoocbl.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IEndDragHandler>(new Action<IEndDragHandler>(hdnkafoocbl.DBFPGFHEGKA));
			}
			else
			{
				base.OnEndDrag(hdnkafoocbl.OLIIPKODDIN);
			}
			this.NPAFKDKFJDB = false;
		}

		// Token: 0x0600A688 RID: 42632 RVA: 0x003E0364 File Offset: 0x003DE564
		public virtual void NIIDAINGGMF(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.PBJKDHBPDOD pbjkdhbpdod = new ScrollRectEx.PBJKDHBPDOD();
			pbjkdhbpdod.OLIIPKODDIN = OLIIPKODDIN;
			this.GFMDKIDKIPP<IInitializePotentialDragHandler>(new Action<IInitializePotentialDragHandler>(pbjkdhbpdod.AGJKEBOPIOC));
			base.OnInitializePotentialDrag(pbjkdhbpdod.OLIIPKODDIN);
		}

		// Token: 0x0600A689 RID: 42633 RVA: 0x003E039C File Offset: 0x003DE59C
		public virtual void DINIEBDANOM(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.PBJKDHBPDOD pbjkdhbpdod = new ScrollRectEx.PBJKDHBPDOD();
			pbjkdhbpdod.OLIIPKODDIN = OLIIPKODDIN;
			this.GFMDKIDKIPP<IInitializePotentialDragHandler>(new Action<IInitializePotentialDragHandler>(pbjkdhbpdod.OFLDIMDDLHM));
			base.OnInitializePotentialDrag(pbjkdhbpdod.OLIIPKODDIN);
		}

		// Token: 0x0600A68A RID: 42634 RVA: 0x003E03D4 File Offset: 0x003DE5D4
		public virtual void MLHFDGPJEFK(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.CGALGKEFBIN cgalgkefbin = new ScrollRectEx.CGALGKEFBIN();
			cgalgkefbin.OLIIPKODDIN = OLIIPKODDIN;
			if (!base.horizontal && Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.x) > Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.y))
			{
				this.NPAFKDKFJDB = true;
			}
			else if (!base.vertical && Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.x) < Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.y))
			{
				this.NPAFKDKFJDB = true;
			}
			else
			{
				this.NPAFKDKFJDB = true;
			}
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IBeginDragHandler>(new Action<IBeginDragHandler>(cgalgkefbin.LNDGINDKPFA));
			}
			else
			{
				base.OnBeginDrag(cgalgkefbin.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A68B RID: 42635 RVA: 0x003E04BC File Offset: 0x003DE6BC
		public virtual void HNIJFBBMKLD(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.CBIBHMLEJGL cbibhmlejgl = new ScrollRectEx.CBIBHMLEJGL();
			cbibhmlejgl.OLIIPKODDIN = OLIIPKODDIN;
			if (!base.horizontal && Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.x) > Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.y))
			{
				this.NPAFKDKFJDB = true;
			}
			else if (!base.vertical && Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.x) < Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.y))
			{
				this.NPAFKDKFJDB = false;
			}
			else
			{
				this.NPAFKDKFJDB = false;
			}
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IScrollHandler>(new Action<IScrollHandler>(cbibhmlejgl.BDGDIDPDBHG));
			}
			else
			{
				base.OnScroll(cbibhmlejgl.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A68C RID: 42636 RVA: 0x003E05A4 File Offset: 0x003DE7A4
		public virtual void KDJPJHEFHOJ(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.CBIBHMLEJGL cbibhmlejgl = new ScrollRectEx.CBIBHMLEJGL();
			cbibhmlejgl.OLIIPKODDIN = OLIIPKODDIN;
			if (!base.horizontal && Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.x) > Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.y))
			{
				this.NPAFKDKFJDB = false;
			}
			else if (!base.vertical && Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.x) < Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.y))
			{
				this.NPAFKDKFJDB = true;
			}
			else
			{
				this.NPAFKDKFJDB = true;
			}
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IScrollHandler>(new Action<IScrollHandler>(cbibhmlejgl.FFEGPHJKMFK));
			}
			else
			{
				base.OnScroll(cbibhmlejgl.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A68D RID: 42637 RVA: 0x003E068C File Offset: 0x003DE88C
		public virtual void KBJMNKGBENN(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.CGALGKEFBIN cgalgkefbin = new ScrollRectEx.CGALGKEFBIN();
			cgalgkefbin.OLIIPKODDIN = OLIIPKODDIN;
			if (!base.horizontal && Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.x) > Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.y))
			{
				this.NPAFKDKFJDB = false;
			}
			else if (!base.vertical && Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.x) < Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.y))
			{
				this.NPAFKDKFJDB = false;
			}
			else
			{
				this.NPAFKDKFJDB = true;
			}
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IBeginDragHandler>(new Action<IBeginDragHandler>(cgalgkefbin.IGFOBPKFCDJ));
			}
			else
			{
				base.OnBeginDrag(cgalgkefbin.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A68E RID: 42638 RVA: 0x003E0774 File Offset: 0x003DE974
		public virtual void JLMIGIMEIDA(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.DLBGDLICCMB dlbgdliccmb = new ScrollRectEx.DLBGDLICCMB();
			dlbgdliccmb.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IDragHandler>(new Action<IDragHandler>(dlbgdliccmb.JKEDCEOCPJO));
			}
			else
			{
				base.OnDrag(dlbgdliccmb.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A68F RID: 42639 RVA: 0x003E07BC File Offset: 0x003DE9BC
		public virtual void NIAJMCCIFBC(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.PBJKDHBPDOD pbjkdhbpdod = new ScrollRectEx.PBJKDHBPDOD();
			pbjkdhbpdod.OLIIPKODDIN = OLIIPKODDIN;
			this.GFMDKIDKIPP<IInitializePotentialDragHandler>(new Action<IInitializePotentialDragHandler>(pbjkdhbpdod.OFHCGKJFGDI));
			base.OnInitializePotentialDrag(pbjkdhbpdod.OLIIPKODDIN);
		}

		// Token: 0x0600A690 RID: 42640 RVA: 0x003E07F4 File Offset: 0x003DE9F4
		public virtual void JLBDLJNKNKN(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.DLBGDLICCMB dlbgdliccmb = new ScrollRectEx.DLBGDLICCMB();
			dlbgdliccmb.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IDragHandler>(new Action<IDragHandler>(dlbgdliccmb.LLNDDFGPOPL));
			}
			else
			{
				base.OnDrag(dlbgdliccmb.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A691 RID: 42641 RVA: 0x003E083C File Offset: 0x003DEA3C
		public virtual void JJFHDNPEBNM(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.CGALGKEFBIN cgalgkefbin = new ScrollRectEx.CGALGKEFBIN();
			cgalgkefbin.OLIIPKODDIN = OLIIPKODDIN;
			if (!base.horizontal && Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.x) > Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.y))
			{
				this.NPAFKDKFJDB = false;
			}
			else if (!base.vertical && Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.x) < Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.y))
			{
				this.NPAFKDKFJDB = false;
			}
			else
			{
				this.NPAFKDKFJDB = true;
			}
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IBeginDragHandler>(new Action<IBeginDragHandler>(cgalgkefbin.BKNHHGBPLGH));
			}
			else
			{
				base.OnBeginDrag(cgalgkefbin.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A692 RID: 42642 RVA: 0x003E0924 File Offset: 0x003DEB24
		public virtual void KJLACJPABEE(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.CBIBHMLEJGL cbibhmlejgl = new ScrollRectEx.CBIBHMLEJGL();
			cbibhmlejgl.OLIIPKODDIN = OLIIPKODDIN;
			if (!base.horizontal && Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.x) > Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.y))
			{
				this.NPAFKDKFJDB = false;
			}
			else if (!base.vertical && Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.x) < Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.y))
			{
				this.NPAFKDKFJDB = false;
			}
			else
			{
				this.NPAFKDKFJDB = true;
			}
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IScrollHandler>(new Action<IScrollHandler>(cbibhmlejgl.AEINPAGJFME));
			}
			else
			{
				base.OnScroll(cbibhmlejgl.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A693 RID: 42643 RVA: 0x003E0A0C File Offset: 0x003DEC0C
		public virtual void JJIPEGHABBC(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.PBJKDHBPDOD pbjkdhbpdod = new ScrollRectEx.PBJKDHBPDOD();
			pbjkdhbpdod.OLIIPKODDIN = OLIIPKODDIN;
			this.GFMDKIDKIPP<IInitializePotentialDragHandler>(new Action<IInitializePotentialDragHandler>(pbjkdhbpdod.BFEABMIFIEE));
			base.OnInitializePotentialDrag(pbjkdhbpdod.OLIIPKODDIN);
		}

		// Token: 0x0600A694 RID: 42644 RVA: 0x003E0A44 File Offset: 0x003DEC44
		public override void OnDrag(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.DLBGDLICCMB dlbgdliccmb = new ScrollRectEx.DLBGDLICCMB();
			dlbgdliccmb.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IDragHandler>(new Action<IDragHandler>(dlbgdliccmb.GBKBDKHPLKG));
			}
			else
			{
				base.OnDrag(dlbgdliccmb.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A695 RID: 42645 RVA: 0x003E0A8C File Offset: 0x003DEC8C
		public virtual void JMMGODHFJNN(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.PBJKDHBPDOD pbjkdhbpdod = new ScrollRectEx.PBJKDHBPDOD();
			pbjkdhbpdod.OLIIPKODDIN = OLIIPKODDIN;
			this.GFMDKIDKIPP<IInitializePotentialDragHandler>(new Action<IInitializePotentialDragHandler>(pbjkdhbpdod.FJDBPPKABJE));
			base.OnInitializePotentialDrag(pbjkdhbpdod.OLIIPKODDIN);
		}

		// Token: 0x0600A696 RID: 42646 RVA: 0x003E0AC4 File Offset: 0x003DECC4
		public virtual void JJBFNAPLFHG(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.CBIBHMLEJGL cbibhmlejgl = new ScrollRectEx.CBIBHMLEJGL();
			cbibhmlejgl.OLIIPKODDIN = OLIIPKODDIN;
			if (!base.horizontal && Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.x) > Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.y))
			{
				this.NPAFKDKFJDB = true;
			}
			else if (!base.vertical && Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.x) < Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.y))
			{
				this.NPAFKDKFJDB = true;
			}
			else
			{
				this.NPAFKDKFJDB = false;
			}
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IScrollHandler>(new Action<IScrollHandler>(cbibhmlejgl.LNDGINDKPFA));
			}
			else
			{
				base.OnScroll(cbibhmlejgl.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A697 RID: 42647 RVA: 0x003E0BAC File Offset: 0x003DEDAC
		public virtual void BPJBOILFGKB(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.CGALGKEFBIN cgalgkefbin = new ScrollRectEx.CGALGKEFBIN();
			cgalgkefbin.OLIIPKODDIN = OLIIPKODDIN;
			if (!base.horizontal && Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.x) > Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.y))
			{
				this.NPAFKDKFJDB = true;
			}
			else if (!base.vertical && Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.x) < Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.y))
			{
				this.NPAFKDKFJDB = false;
			}
			else
			{
				this.NPAFKDKFJDB = false;
			}
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IBeginDragHandler>(new Action<IBeginDragHandler>(cgalgkefbin.MEMPOPNAEDN));
			}
			else
			{
				base.OnBeginDrag(cgalgkefbin.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A698 RID: 42648 RVA: 0x003E0C94 File Offset: 0x003DEE94
		public virtual void GENCIDAHOBF(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.CBIBHMLEJGL cbibhmlejgl = new ScrollRectEx.CBIBHMLEJGL();
			cbibhmlejgl.OLIIPKODDIN = OLIIPKODDIN;
			if (!base.horizontal && Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.x) > Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.y))
			{
				this.NPAFKDKFJDB = true;
			}
			else if (!base.vertical && Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.x) < Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.y))
			{
				this.NPAFKDKFJDB = false;
			}
			else
			{
				this.NPAFKDKFJDB = true;
			}
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IScrollHandler>(new Action<IScrollHandler>(cbibhmlejgl.JDELIMPGFDJ));
			}
			else
			{
				base.OnScroll(cbibhmlejgl.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A699 RID: 42649 RVA: 0x003E0D7C File Offset: 0x003DEF7C
		public virtual void BDNDKBINDBG(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.CGALGKEFBIN cgalgkefbin = new ScrollRectEx.CGALGKEFBIN();
			cgalgkefbin.OLIIPKODDIN = OLIIPKODDIN;
			if (!base.horizontal && Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.x) > Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.y))
			{
				this.NPAFKDKFJDB = true;
			}
			else if (!base.vertical && Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.x) < Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.y))
			{
				this.NPAFKDKFJDB = true;
			}
			else
			{
				this.NPAFKDKFJDB = true;
			}
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IBeginDragHandler>(new Action<IBeginDragHandler>(cgalgkefbin.FIPCLHEKKCA));
			}
			else
			{
				base.OnBeginDrag(cgalgkefbin.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A69A RID: 42650 RVA: 0x003E0E64 File Offset: 0x003DF064
		public virtual void BPFLEOPNLJK(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.DLBGDLICCMB dlbgdliccmb = new ScrollRectEx.DLBGDLICCMB();
			dlbgdliccmb.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IDragHandler>(new Action<IDragHandler>(dlbgdliccmb.KFNBKFELFLH));
			}
			else
			{
				base.OnDrag(dlbgdliccmb.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A69B RID: 42651 RVA: 0x003E0EAC File Offset: 0x003DF0AC
		public virtual void HPEAHCAPNDC(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.HDNKAFOOCBL hdnkafoocbl = new ScrollRectEx.HDNKAFOOCBL();
			hdnkafoocbl.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IEndDragHandler>(new Action<IEndDragHandler>(hdnkafoocbl.LOEAMHGMMPK));
			}
			else
			{
				base.OnEndDrag(hdnkafoocbl.OLIIPKODDIN);
			}
			this.NPAFKDKFJDB = true;
		}

		// Token: 0x0600A69C RID: 42652 RVA: 0x003E0EFC File Offset: 0x003DF0FC
		public virtual void PPJKLBPPDNE(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.DLBGDLICCMB dlbgdliccmb = new ScrollRectEx.DLBGDLICCMB();
			dlbgdliccmb.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IDragHandler>(new Action<IDragHandler>(dlbgdliccmb.EKHOOPGPPGE));
			}
			else
			{
				base.OnDrag(dlbgdliccmb.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A69D RID: 42653 RVA: 0x003E0F44 File Offset: 0x003DF144
		public virtual void JHHDCFMGGGE(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.DLBGDLICCMB dlbgdliccmb = new ScrollRectEx.DLBGDLICCMB();
			dlbgdliccmb.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IDragHandler>(new Action<IDragHandler>(dlbgdliccmb.DKGPCPBNDPK));
			}
			else
			{
				base.OnDrag(dlbgdliccmb.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A69E RID: 42654 RVA: 0x003E0F8C File Offset: 0x003DF18C
		public virtual void FKOHMBBKPDL(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.CGALGKEFBIN cgalgkefbin = new ScrollRectEx.CGALGKEFBIN();
			cgalgkefbin.OLIIPKODDIN = OLIIPKODDIN;
			if (!base.horizontal && Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.x) > Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.y))
			{
				this.NPAFKDKFJDB = true;
			}
			else if (!base.vertical && Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.x) < Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.y))
			{
				this.NPAFKDKFJDB = false;
			}
			else
			{
				this.NPAFKDKFJDB = true;
			}
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IBeginDragHandler>(new Action<IBeginDragHandler>(cgalgkefbin.BMAOCLKPNNC));
			}
			else
			{
				base.OnBeginDrag(cgalgkefbin.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A69F RID: 42655 RVA: 0x003E1074 File Offset: 0x003DF274
		public virtual void FEKKBNDDBEP(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.CBIBHMLEJGL cbibhmlejgl = new ScrollRectEx.CBIBHMLEJGL();
			cbibhmlejgl.OLIIPKODDIN = OLIIPKODDIN;
			if (!base.horizontal && Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.x) > Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.y))
			{
				this.NPAFKDKFJDB = false;
			}
			else if (!base.vertical && Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.x) < Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.y))
			{
				this.NPAFKDKFJDB = true;
			}
			else
			{
				this.NPAFKDKFJDB = false;
			}
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IScrollHandler>(new Action<IScrollHandler>(cbibhmlejgl.OFHCGKJFGDI));
			}
			else
			{
				base.OnScroll(cbibhmlejgl.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A6A0 RID: 42656 RVA: 0x003E115C File Offset: 0x003DF35C
		public override void OnInitializePotentialDrag(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.PBJKDHBPDOD pbjkdhbpdod = new ScrollRectEx.PBJKDHBPDOD();
			pbjkdhbpdod.OLIIPKODDIN = OLIIPKODDIN;
			this.GFMDKIDKIPP<IInitializePotentialDragHandler>(new Action<IInitializePotentialDragHandler>(pbjkdhbpdod.GBKBDKHPLKG));
			base.OnInitializePotentialDrag(pbjkdhbpdod.OLIIPKODDIN);
		}

		// Token: 0x0600A6A1 RID: 42657 RVA: 0x003E1194 File Offset: 0x003DF394
		public virtual void MPJJECEGMCL(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.PBJKDHBPDOD pbjkdhbpdod = new ScrollRectEx.PBJKDHBPDOD();
			pbjkdhbpdod.OLIIPKODDIN = OLIIPKODDIN;
			this.GFMDKIDKIPP<IInitializePotentialDragHandler>(new Action<IInitializePotentialDragHandler>(pbjkdhbpdod.DBFPGFHEGKA));
			base.OnInitializePotentialDrag(pbjkdhbpdod.OLIIPKODDIN);
		}

		// Token: 0x0600A6A2 RID: 42658 RVA: 0x003E11CC File Offset: 0x003DF3CC
		public virtual void GIOBGKEANJG(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.CGALGKEFBIN cgalgkefbin = new ScrollRectEx.CGALGKEFBIN();
			cgalgkefbin.OLIIPKODDIN = OLIIPKODDIN;
			if (!base.horizontal && Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.x) > Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.y))
			{
				this.NPAFKDKFJDB = true;
			}
			else if (!base.vertical && Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.x) < Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.y))
			{
				this.NPAFKDKFJDB = false;
			}
			else
			{
				this.NPAFKDKFJDB = true;
			}
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IBeginDragHandler>(new Action<IBeginDragHandler>(cgalgkefbin.JKEDCEOCPJO));
			}
			else
			{
				base.OnBeginDrag(cgalgkefbin.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A6A3 RID: 42659 RVA: 0x003E12B4 File Offset: 0x003DF4B4
		public virtual void LKMIKLDMNMO(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.CBIBHMLEJGL cbibhmlejgl = new ScrollRectEx.CBIBHMLEJGL();
			cbibhmlejgl.OLIIPKODDIN = OLIIPKODDIN;
			if (!base.horizontal && Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.x) > Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.y))
			{
				this.NPAFKDKFJDB = true;
			}
			else if (!base.vertical && Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.x) < Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.y))
			{
				this.NPAFKDKFJDB = true;
			}
			else
			{
				this.NPAFKDKFJDB = true;
			}
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IScrollHandler>(new Action<IScrollHandler>(cbibhmlejgl.DKGPCPBNDPK));
			}
			else
			{
				base.OnScroll(cbibhmlejgl.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A6A4 RID: 42660 RVA: 0x003E139C File Offset: 0x003DF59C
		public override void OnBeginDrag(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.CGALGKEFBIN cgalgkefbin = new ScrollRectEx.CGALGKEFBIN();
			cgalgkefbin.OLIIPKODDIN = OLIIPKODDIN;
			if (!base.horizontal && Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.x) > Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.y))
			{
				this.NPAFKDKFJDB = true;
			}
			else if (!base.vertical && Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.x) < Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.y))
			{
				this.NPAFKDKFJDB = true;
			}
			else
			{
				this.NPAFKDKFJDB = false;
			}
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IBeginDragHandler>(new Action<IBeginDragHandler>(cgalgkefbin.GBKBDKHPLKG));
			}
			else
			{
				base.OnBeginDrag(cgalgkefbin.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A6A5 RID: 42661 RVA: 0x003E1484 File Offset: 0x003DF684
		public virtual void DBMJBJPIBEP(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.CBIBHMLEJGL cbibhmlejgl = new ScrollRectEx.CBIBHMLEJGL();
			cbibhmlejgl.OLIIPKODDIN = OLIIPKODDIN;
			if (!base.horizontal && Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.x) > Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.y))
			{
				this.NPAFKDKFJDB = true;
			}
			else if (!base.vertical && Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.x) < Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.y))
			{
				this.NPAFKDKFJDB = false;
			}
			else
			{
				this.NPAFKDKFJDB = false;
			}
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IScrollHandler>(new Action<IScrollHandler>(cbibhmlejgl.LNDGINDKPFA));
			}
			else
			{
				base.OnScroll(cbibhmlejgl.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A6A6 RID: 42662 RVA: 0x003E156C File Offset: 0x003DF76C
		private void GFMDKIDKIPP<T>(Action<T> LHCIHJOHGEJ) where T : IEventSystemHandler
		{
			Transform parent = base.transform.parent;
			while (parent != null)
			{
				foreach (Component component in parent.GetComponents<Component>())
				{
					if (component is T)
					{
						LHCIHJOHGEJ((T)((object)((IEventSystemHandler)component)));
					}
				}
				parent = parent.parent;
			}
		}

		// Token: 0x0600A6A7 RID: 42663 RVA: 0x003E15D8 File Offset: 0x003DF7D8
		public virtual void IBMONOMLNCD(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.CBIBHMLEJGL cbibhmlejgl = new ScrollRectEx.CBIBHMLEJGL();
			cbibhmlejgl.OLIIPKODDIN = OLIIPKODDIN;
			if (!base.horizontal && Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.x) > Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.y))
			{
				this.NPAFKDKFJDB = false;
			}
			else if (!base.vertical && Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.x) < Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.y))
			{
				this.NPAFKDKFJDB = false;
			}
			else
			{
				this.NPAFKDKFJDB = false;
			}
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IScrollHandler>(new Action<IScrollHandler>(cbibhmlejgl.EKHOOPGPPGE));
			}
			else
			{
				base.OnScroll(cbibhmlejgl.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A6A8 RID: 42664 RVA: 0x003E16C0 File Offset: 0x003DF8C0
		public override void OnEndDrag(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.HDNKAFOOCBL hdnkafoocbl = new ScrollRectEx.HDNKAFOOCBL();
			hdnkafoocbl.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IEndDragHandler>(new Action<IEndDragHandler>(hdnkafoocbl.GBKBDKHPLKG));
			}
			else
			{
				base.OnEndDrag(hdnkafoocbl.OLIIPKODDIN);
			}
			this.NPAFKDKFJDB = false;
		}

		// Token: 0x0600A6A9 RID: 42665 RVA: 0x003E1710 File Offset: 0x003DF910
		public virtual void ACNEIFKJCMH(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.HDNKAFOOCBL hdnkafoocbl = new ScrollRectEx.HDNKAFOOCBL();
			hdnkafoocbl.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IEndDragHandler>(new Action<IEndDragHandler>(hdnkafoocbl.KFNBKFELFLH));
			}
			else
			{
				base.OnEndDrag(hdnkafoocbl.OLIIPKODDIN);
			}
			this.NPAFKDKFJDB = false;
		}

		// Token: 0x0600A6AA RID: 42666 RVA: 0x003E1760 File Offset: 0x003DF960
		public virtual void HJDADMOPHPE(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.HDNKAFOOCBL hdnkafoocbl = new ScrollRectEx.HDNKAFOOCBL();
			hdnkafoocbl.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IEndDragHandler>(new Action<IEndDragHandler>(hdnkafoocbl.KFNBKFELFLH));
			}
			else
			{
				base.OnEndDrag(hdnkafoocbl.OLIIPKODDIN);
			}
			this.NPAFKDKFJDB = true;
		}

		// Token: 0x0600A6AB RID: 42667 RVA: 0x003E17B0 File Offset: 0x003DF9B0
		public virtual void DAEPLEDNAIH(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.PBJKDHBPDOD pbjkdhbpdod = new ScrollRectEx.PBJKDHBPDOD();
			pbjkdhbpdod.OLIIPKODDIN = OLIIPKODDIN;
			this.GFMDKIDKIPP<IInitializePotentialDragHandler>(new Action<IInitializePotentialDragHandler>(pbjkdhbpdod.GBKBDKHPLKG));
			base.OnInitializePotentialDrag(pbjkdhbpdod.OLIIPKODDIN);
		}

		// Token: 0x0600A6AC RID: 42668 RVA: 0x003E17E8 File Offset: 0x003DF9E8
		public virtual void NGILNNIBEND(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.CGALGKEFBIN cgalgkefbin = new ScrollRectEx.CGALGKEFBIN();
			cgalgkefbin.OLIIPKODDIN = OLIIPKODDIN;
			if (!base.horizontal && Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.x) > Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.y))
			{
				this.NPAFKDKFJDB = false;
			}
			else if (!base.vertical && Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.x) < Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.y))
			{
				this.NPAFKDKFJDB = true;
			}
			else
			{
				this.NPAFKDKFJDB = true;
			}
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IBeginDragHandler>(new Action<IBeginDragHandler>(cgalgkefbin.FJDBPPKABJE));
			}
			else
			{
				base.OnBeginDrag(cgalgkefbin.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A6AD RID: 42669 RVA: 0x003E18D0 File Offset: 0x003DFAD0
		public virtual void BEKLAKIPPNI(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.PBJKDHBPDOD pbjkdhbpdod = new ScrollRectEx.PBJKDHBPDOD();
			pbjkdhbpdod.OLIIPKODDIN = OLIIPKODDIN;
			this.GFMDKIDKIPP<IInitializePotentialDragHandler>(new Action<IInitializePotentialDragHandler>(pbjkdhbpdod.FIPCLHEKKCA));
			base.OnInitializePotentialDrag(pbjkdhbpdod.OLIIPKODDIN);
		}

		// Token: 0x0600A6AE RID: 42670 RVA: 0x003E1908 File Offset: 0x003DFB08
		public virtual void IJOKICJHDHE(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.DLBGDLICCMB dlbgdliccmb = new ScrollRectEx.DLBGDLICCMB();
			dlbgdliccmb.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IDragHandler>(new Action<IDragHandler>(dlbgdliccmb.KFNBKFELFLH));
			}
			else
			{
				base.OnDrag(dlbgdliccmb.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A6AF RID: 42671 RVA: 0x003E1950 File Offset: 0x003DFB50
		public virtual void IJBNBOGAFKC(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.CGALGKEFBIN cgalgkefbin = new ScrollRectEx.CGALGKEFBIN();
			cgalgkefbin.OLIIPKODDIN = OLIIPKODDIN;
			if (!base.horizontal && Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.x) > Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.y))
			{
				this.NPAFKDKFJDB = true;
			}
			else if (!base.vertical && Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.x) < Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.y))
			{
				this.NPAFKDKFJDB = true;
			}
			else
			{
				this.NPAFKDKFJDB = true;
			}
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IBeginDragHandler>(new Action<IBeginDragHandler>(cgalgkefbin.PIJAOCFAPKC));
			}
			else
			{
				base.OnBeginDrag(cgalgkefbin.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A6B0 RID: 42672 RVA: 0x003E1A38 File Offset: 0x003DFC38
		public virtual void BCBKDFGLEDJ(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.DLBGDLICCMB dlbgdliccmb = new ScrollRectEx.DLBGDLICCMB();
			dlbgdliccmb.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IDragHandler>(new Action<IDragHandler>(dlbgdliccmb.EGKGJJGAPMN));
			}
			else
			{
				base.OnDrag(dlbgdliccmb.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A6B1 RID: 42673 RVA: 0x003E1A80 File Offset: 0x003DFC80
		public virtual void PNAFHIHBKHB(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.DLBGDLICCMB dlbgdliccmb = new ScrollRectEx.DLBGDLICCMB();
			dlbgdliccmb.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IDragHandler>(new Action<IDragHandler>(dlbgdliccmb.OLIGLEMPFOP));
			}
			else
			{
				base.OnDrag(dlbgdliccmb.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A6B2 RID: 42674 RVA: 0x003E1AC8 File Offset: 0x003DFCC8
		public virtual void JFJHHDNKHFL(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.HDNKAFOOCBL hdnkafoocbl = new ScrollRectEx.HDNKAFOOCBL();
			hdnkafoocbl.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IEndDragHandler>(new Action<IEndDragHandler>(hdnkafoocbl.JKEDCEOCPJO));
			}
			else
			{
				base.OnEndDrag(hdnkafoocbl.OLIIPKODDIN);
			}
			this.NPAFKDKFJDB = true;
		}

		// Token: 0x0600A6B3 RID: 42675 RVA: 0x003E1B18 File Offset: 0x003DFD18
		public virtual void GIKAADBPOKK(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.DLBGDLICCMB dlbgdliccmb = new ScrollRectEx.DLBGDLICCMB();
			dlbgdliccmb.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IDragHandler>(new Action<IDragHandler>(dlbgdliccmb.JDELIMPGFDJ));
			}
			else
			{
				base.OnDrag(dlbgdliccmb.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A6B4 RID: 42676 RVA: 0x003E1B60 File Offset: 0x003DFD60
		public virtual void PKJMOHDCHNA(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.DLBGDLICCMB dlbgdliccmb = new ScrollRectEx.DLBGDLICCMB();
			dlbgdliccmb.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IDragHandler>(new Action<IDragHandler>(dlbgdliccmb.DNIMHEKGJHB));
			}
			else
			{
				base.OnDrag(dlbgdliccmb.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A6B5 RID: 42677 RVA: 0x003E1BA8 File Offset: 0x003DFDA8
		public virtual void ABIGIFHIJLH(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.DLBGDLICCMB dlbgdliccmb = new ScrollRectEx.DLBGDLICCMB();
			dlbgdliccmb.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IDragHandler>(new Action<IDragHandler>(dlbgdliccmb.FIPCLHEKKCA));
			}
			else
			{
				base.OnDrag(dlbgdliccmb.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A6B6 RID: 42678 RVA: 0x003E1BF0 File Offset: 0x003DFDF0
		public virtual void GHFBJAAEMFA(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.CGALGKEFBIN cgalgkefbin = new ScrollRectEx.CGALGKEFBIN();
			cgalgkefbin.OLIIPKODDIN = OLIIPKODDIN;
			if (!base.horizontal && Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.x) > Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.y))
			{
				this.NPAFKDKFJDB = false;
			}
			else if (!base.vertical && Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.x) < Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.y))
			{
				this.NPAFKDKFJDB = true;
			}
			else
			{
				this.NPAFKDKFJDB = false;
			}
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IBeginDragHandler>(new Action<IBeginDragHandler>(cgalgkefbin.DNIMHEKGJHB));
			}
			else
			{
				base.OnBeginDrag(cgalgkefbin.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A6B7 RID: 42679 RVA: 0x003E1CD8 File Offset: 0x003DFED8
		public virtual void GCFBPDBOKAD(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.CBIBHMLEJGL cbibhmlejgl = new ScrollRectEx.CBIBHMLEJGL();
			cbibhmlejgl.OLIIPKODDIN = OLIIPKODDIN;
			if (!base.horizontal && Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.x) > Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.y))
			{
				this.NPAFKDKFJDB = false;
			}
			else if (!base.vertical && Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.x) < Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.y))
			{
				this.NPAFKDKFJDB = false;
			}
			else
			{
				this.NPAFKDKFJDB = false;
			}
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IScrollHandler>(new Action<IScrollHandler>(cbibhmlejgl.PBCAHKDLFPE));
			}
			else
			{
				base.OnScroll(cbibhmlejgl.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A6B9 RID: 42681 RVA: 0x003E1DC8 File Offset: 0x003DFFC8
		public virtual void HGPBDNOJBFG(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.HDNKAFOOCBL hdnkafoocbl = new ScrollRectEx.HDNKAFOOCBL();
			hdnkafoocbl.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IEndDragHandler>(new Action<IEndDragHandler>(hdnkafoocbl.GBKBDKHPLKG));
			}
			else
			{
				base.OnEndDrag(hdnkafoocbl.OLIIPKODDIN);
			}
			this.NPAFKDKFJDB = true;
		}

		// Token: 0x0600A6BA RID: 42682 RVA: 0x003E1E18 File Offset: 0x003E0018
		public virtual void AJKNFEEHAFH(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.DLBGDLICCMB dlbgdliccmb = new ScrollRectEx.DLBGDLICCMB();
			dlbgdliccmb.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IDragHandler>(new Action<IDragHandler>(dlbgdliccmb.OFHCGKJFGDI));
			}
			else
			{
				base.OnDrag(dlbgdliccmb.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A6BB RID: 42683 RVA: 0x003E1E60 File Offset: 0x003E0060
		public virtual void JANNDAOJOAJ(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.PBJKDHBPDOD pbjkdhbpdod = new ScrollRectEx.PBJKDHBPDOD();
			pbjkdhbpdod.OLIIPKODDIN = OLIIPKODDIN;
			this.GFMDKIDKIPP<IInitializePotentialDragHandler>(new Action<IInitializePotentialDragHandler>(pbjkdhbpdod.BDGDIDPDBHG));
			base.OnInitializePotentialDrag(pbjkdhbpdod.OLIIPKODDIN);
		}

		// Token: 0x0600A6BC RID: 42684 RVA: 0x003E1E98 File Offset: 0x003E0098
		public virtual void JLLMDLGPNHO(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.PBJKDHBPDOD pbjkdhbpdod = new ScrollRectEx.PBJKDHBPDOD();
			pbjkdhbpdod.OLIIPKODDIN = OLIIPKODDIN;
			this.GFMDKIDKIPP<IInitializePotentialDragHandler>(new Action<IInitializePotentialDragHandler>(pbjkdhbpdod.FJDBPPKABJE));
			base.OnInitializePotentialDrag(pbjkdhbpdod.OLIIPKODDIN);
		}

		// Token: 0x0600A6BD RID: 42685 RVA: 0x003E1ED0 File Offset: 0x003E00D0
		public virtual void MFKIIMLJILD(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.CGALGKEFBIN cgalgkefbin = new ScrollRectEx.CGALGKEFBIN();
			cgalgkefbin.OLIIPKODDIN = OLIIPKODDIN;
			if (!base.horizontal && Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.x) > Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.y))
			{
				this.NPAFKDKFJDB = false;
			}
			else if (!base.vertical && Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.x) < Math.Abs(cgalgkefbin.OLIIPKODDIN.delta.y))
			{
				this.NPAFKDKFJDB = true;
			}
			else
			{
				this.NPAFKDKFJDB = true;
			}
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IBeginDragHandler>(new Action<IBeginDragHandler>(cgalgkefbin.FJDBPPKABJE));
			}
			else
			{
				base.OnBeginDrag(cgalgkefbin.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A6BE RID: 42686 RVA: 0x003E1FB8 File Offset: 0x003E01B8
		public virtual void NBEEABGEMFP(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.HDNKAFOOCBL hdnkafoocbl = new ScrollRectEx.HDNKAFOOCBL();
			hdnkafoocbl.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IEndDragHandler>(new Action<IEndDragHandler>(hdnkafoocbl.FFEGPHJKMFK));
			}
			else
			{
				base.OnEndDrag(hdnkafoocbl.OLIIPKODDIN);
			}
			this.NPAFKDKFJDB = true;
		}

		// Token: 0x0600A6BF RID: 42687 RVA: 0x003E2008 File Offset: 0x003E0208
		public virtual void GEFACKACDHO(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.HDNKAFOOCBL hdnkafoocbl = new ScrollRectEx.HDNKAFOOCBL();
			hdnkafoocbl.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IEndDragHandler>(new Action<IEndDragHandler>(hdnkafoocbl.BKNHHGBPLGH));
			}
			else
			{
				base.OnEndDrag(hdnkafoocbl.OLIIPKODDIN);
			}
			this.NPAFKDKFJDB = true;
		}

		// Token: 0x0600A6C0 RID: 42688 RVA: 0x003E2058 File Offset: 0x003E0258
		public virtual void HFKDDAMLINH(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.DLBGDLICCMB dlbgdliccmb = new ScrollRectEx.DLBGDLICCMB();
			dlbgdliccmb.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IDragHandler>(new Action<IDragHandler>(dlbgdliccmb.GBKBDKHPLKG));
			}
			else
			{
				base.OnDrag(dlbgdliccmb.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A6C1 RID: 42689 RVA: 0x003E20A0 File Offset: 0x003E02A0
		public virtual void NNPDLHKLOLM(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.HDNKAFOOCBL hdnkafoocbl = new ScrollRectEx.HDNKAFOOCBL();
			hdnkafoocbl.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IEndDragHandler>(new Action<IEndDragHandler>(hdnkafoocbl.BFEABMIFIEE));
			}
			else
			{
				base.OnEndDrag(hdnkafoocbl.OLIIPKODDIN);
			}
			this.NPAFKDKFJDB = true;
		}

		// Token: 0x0600A6C2 RID: 42690 RVA: 0x003E20F0 File Offset: 0x003E02F0
		public override void OnScroll(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.CBIBHMLEJGL cbibhmlejgl = new ScrollRectEx.CBIBHMLEJGL();
			cbibhmlejgl.OLIIPKODDIN = OLIIPKODDIN;
			if (!base.horizontal && Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.x) > Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.y))
			{
				this.NPAFKDKFJDB = true;
			}
			else if (!base.vertical && Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.x) < Math.Abs(cbibhmlejgl.OLIIPKODDIN.scrollDelta.y))
			{
				this.NPAFKDKFJDB = true;
			}
			else
			{
				this.NPAFKDKFJDB = false;
			}
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IScrollHandler>(new Action<IScrollHandler>(cbibhmlejgl.GBKBDKHPLKG));
			}
			else
			{
				base.OnScroll(cbibhmlejgl.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A6C3 RID: 42691 RVA: 0x003E21D8 File Offset: 0x003E03D8
		public virtual void IKENMCHKHKM(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.HDNKAFOOCBL hdnkafoocbl = new ScrollRectEx.HDNKAFOOCBL();
			hdnkafoocbl.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IEndDragHandler>(new Action<IEndDragHandler>(hdnkafoocbl.GBKBDKHPLKG));
			}
			else
			{
				base.OnEndDrag(hdnkafoocbl.OLIIPKODDIN);
			}
			this.NPAFKDKFJDB = true;
		}

		// Token: 0x0600A6C4 RID: 42692 RVA: 0x003E2228 File Offset: 0x003E0428
		public virtual void DBLIMHEKNGH(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.DLBGDLICCMB dlbgdliccmb = new ScrollRectEx.DLBGDLICCMB();
			dlbgdliccmb.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IDragHandler>(new Action<IDragHandler>(dlbgdliccmb.HBJFIOJFBHC));
			}
			else
			{
				base.OnDrag(dlbgdliccmb.OLIIPKODDIN);
			}
		}

		// Token: 0x0600A6C5 RID: 42693 RVA: 0x003E2270 File Offset: 0x003E0470
		public virtual void JBLNMGNIABJ(PointerEventData OLIIPKODDIN)
		{
			ScrollRectEx.HDNKAFOOCBL hdnkafoocbl = new ScrollRectEx.HDNKAFOOCBL();
			hdnkafoocbl.OLIIPKODDIN = OLIIPKODDIN;
			if (this.NPAFKDKFJDB)
			{
				this.GFMDKIDKIPP<IEndDragHandler>(new Action<IEndDragHandler>(hdnkafoocbl.KFNBKFELFLH));
			}
			else
			{
				base.OnEndDrag(hdnkafoocbl.OLIIPKODDIN);
			}
			this.NPAFKDKFJDB = false;
		}

		// Token: 0x040012AE RID: 4782
		private bool NPAFKDKFJDB;

		// Token: 0x020002B5 RID: 693
		[CompilerGenerated]
		private sealed class PBJKDHBPDOD
		{
			// Token: 0x0600A6C6 RID: 42694 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void EKHOOPGPPGE(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6C7 RID: 42695 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void OFHCGKJFGDI(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6C8 RID: 42696 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void AEINPAGJFME(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6C9 RID: 42697 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void FHFECFLBHMA(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6CA RID: 42698 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void JDELIMPGFDJ(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6CB RID: 42699 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void HBJFIOJFBHC(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6CD RID: 42701 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void BJMAIJDIKCN(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6CE RID: 42702 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void KGKMOLCPDIH(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6CF RID: 42703 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void BKNHHGBPLGH(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6D0 RID: 42704 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void BMAOCLKPNNC(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6D1 RID: 42705 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void AGJKEBOPIOC(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6D2 RID: 42706 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void FJDBPPKABJE(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6D3 RID: 42707 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void FCAGEDLBBHD(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6D4 RID: 42708 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void IGFOBPKFCDJ(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6D5 RID: 42709 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void LNDGINDKPFA(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6D6 RID: 42710 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void EGKGJJGAPMN(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6D7 RID: 42711 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void LOEAMHGMMPK(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6D8 RID: 42712 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void KFNBKFELFLH(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6D9 RID: 42713 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void DKGPCPBNDPK(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6DA RID: 42714 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void OLIGLEMPFOP(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6DB RID: 42715 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void DNIMHEKGJHB(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6DC RID: 42716 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void DBFPGFHEGKA(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6DD RID: 42717 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void BFEABMIFIEE(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6DE RID: 42718 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void BDGDIDPDBHG(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6DF RID: 42719 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void PBCAHKDLFPE(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6E0 RID: 42720 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void PIJAOCFAPKC(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6E1 RID: 42721 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void MEMPOPNAEDN(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6E2 RID: 42722 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void LHHFJBIAHCN(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6E3 RID: 42723 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void FFEGPHJKMFK(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6E4 RID: 42724 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void FDAIFOAGDLA(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6E5 RID: 42725 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void FIPCLHEKKCA(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6E6 RID: 42726 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void LLNDDFGPOPL(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6E7 RID: 42727 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void GBKBDKHPLKG(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6E8 RID: 42728 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void JKEDCEOCPJO(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6E9 RID: 42729 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void FHIJCPPECHA(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6EA RID: 42730 RVA: 0x003E22BF File Offset: 0x003E04BF
			internal void OFLDIMDDLHM(IInitializePotentialDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnInitializePotentialDrag(this.OLIIPKODDIN);
			}

			// Token: 0x040012AF RID: 4783
			internal PointerEventData OLIIPKODDIN;
		}

		// Token: 0x020002B6 RID: 694
		[CompilerGenerated]
		private sealed class DLBGDLICCMB
		{
			// Token: 0x0600A6EB RID: 42731 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void BMAOCLKPNNC(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6EC RID: 42732 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void AEINPAGJFME(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6ED RID: 42733 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void LOEAMHGMMPK(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6EE RID: 42734 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void AGJKEBOPIOC(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6EF RID: 42735 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void EKHOOPGPPGE(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6F0 RID: 42736 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void PBCAHKDLFPE(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6F1 RID: 42737 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void LHHFJBIAHCN(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6F2 RID: 42738 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void LNDGINDKPFA(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6F3 RID: 42739 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void FJDBPPKABJE(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6F4 RID: 42740 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void EGKGJJGAPMN(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6F5 RID: 42741 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void FFEGPHJKMFK(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6F6 RID: 42742 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void KGKMOLCPDIH(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6F7 RID: 42743 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void BDGDIDPDBHG(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6F8 RID: 42744 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void OLIGLEMPFOP(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6F9 RID: 42745 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void PIJAOCFAPKC(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6FA RID: 42746 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void KFNBKFELFLH(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6FB RID: 42747 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void GBKBDKHPLKG(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6FC RID: 42748 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void BKNHHGBPLGH(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6FD RID: 42749 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void JKEDCEOCPJO(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6FE RID: 42750 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void DNIMHEKGJHB(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A6FF RID: 42751 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void JDELIMPGFDJ(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A700 RID: 42752 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void DBFPGFHEGKA(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A701 RID: 42753 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void OFHCGKJFGDI(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A702 RID: 42754 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void BFEABMIFIEE(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A703 RID: 42755 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void DKGPCPBNDPK(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A704 RID: 42756 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void FIPCLHEKKCA(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A705 RID: 42757 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void MEMPOPNAEDN(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A706 RID: 42758 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void LLNDDFGPOPL(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A708 RID: 42760 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void HBJFIOJFBHC(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A709 RID: 42761 RVA: 0x003E22CD File Offset: 0x003E04CD
			internal void IGFOBPKFCDJ(IDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnDrag(this.OLIIPKODDIN);
			}

			// Token: 0x040012B0 RID: 4784
			internal PointerEventData OLIIPKODDIN;
		}

		// Token: 0x020002B7 RID: 695
		[CompilerGenerated]
		private sealed class CGALGKEFBIN
		{
			// Token: 0x0600A70A RID: 42762 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void HBJFIOJFBHC(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A70B RID: 42763 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void LNDGINDKPFA(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A70C RID: 42764 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void LOEAMHGMMPK(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A70D RID: 42765 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void FFEGPHJKMFK(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A70E RID: 42766 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void KGKMOLCPDIH(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A70F RID: 42767 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void BMAOCLKPNNC(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A710 RID: 42768 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void DBFPGFHEGKA(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A711 RID: 42769 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void BKNHHGBPLGH(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A712 RID: 42770 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void KFNBKFELFLH(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A713 RID: 42771 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void AGJKEBOPIOC(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A714 RID: 42772 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void DKGPCPBNDPK(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A715 RID: 42773 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void IGFOBPKFCDJ(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A716 RID: 42774 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void BFEABMIFIEE(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A717 RID: 42775 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void JDELIMPGFDJ(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A719 RID: 42777 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void GBKBDKHPLKG(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A71A RID: 42778 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void FIPCLHEKKCA(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A71B RID: 42779 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void PBCAHKDLFPE(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A71C RID: 42780 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void FHIJCPPECHA(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A71D RID: 42781 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void AEINPAGJFME(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A71E RID: 42782 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void BDGDIDPDBHG(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A71F RID: 42783 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void PIJAOCFAPKC(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A720 RID: 42784 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void EKHOOPGPPGE(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A721 RID: 42785 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void OFHCGKJFGDI(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A722 RID: 42786 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void JKEDCEOCPJO(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A723 RID: 42787 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void LHHFJBIAHCN(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A724 RID: 42788 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void EGKGJJGAPMN(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A725 RID: 42789 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void MEMPOPNAEDN(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A726 RID: 42790 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void FJDBPPKABJE(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A727 RID: 42791 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void FCAGEDLBBHD(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A728 RID: 42792 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void OLIGLEMPFOP(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A729 RID: 42793 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void LLNDDFGPOPL(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A72A RID: 42794 RVA: 0x003E22DB File Offset: 0x003E04DB
			internal void DNIMHEKGJHB(IBeginDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnBeginDrag(this.OLIIPKODDIN);
			}

			// Token: 0x040012B1 RID: 4785
			internal PointerEventData OLIIPKODDIN;
		}

		// Token: 0x020002B8 RID: 696
		[CompilerGenerated]
		private sealed class HDNKAFOOCBL
		{
			// Token: 0x0600A72B RID: 42795 RVA: 0x003E22E9 File Offset: 0x003E04E9
			internal void BFEABMIFIEE(IEndDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnEndDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A72C RID: 42796 RVA: 0x003E22E9 File Offset: 0x003E04E9
			internal void PBCAHKDLFPE(IEndDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnEndDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A72D RID: 42797 RVA: 0x003E22E9 File Offset: 0x003E04E9
			internal void AEINPAGJFME(IEndDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnEndDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A72E RID: 42798 RVA: 0x003E22E9 File Offset: 0x003E04E9
			internal void FFEGPHJKMFK(IEndDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnEndDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A72F RID: 42799 RVA: 0x003E22E9 File Offset: 0x003E04E9
			internal void BKNHHGBPLGH(IEndDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnEndDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A731 RID: 42801 RVA: 0x003E22E9 File Offset: 0x003E04E9
			internal void KFNBKFELFLH(IEndDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnEndDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A732 RID: 42802 RVA: 0x003E22E9 File Offset: 0x003E04E9
			internal void OFHCGKJFGDI(IEndDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnEndDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A733 RID: 42803 RVA: 0x003E22E9 File Offset: 0x003E04E9
			internal void BDGDIDPDBHG(IEndDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnEndDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A734 RID: 42804 RVA: 0x003E22E9 File Offset: 0x003E04E9
			internal void MEMPOPNAEDN(IEndDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnEndDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A735 RID: 42805 RVA: 0x003E22E9 File Offset: 0x003E04E9
			internal void GBKBDKHPLKG(IEndDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnEndDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A736 RID: 42806 RVA: 0x003E22E9 File Offset: 0x003E04E9
			internal void LNDGINDKPFA(IEndDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnEndDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A737 RID: 42807 RVA: 0x003E22E9 File Offset: 0x003E04E9
			internal void OLIGLEMPFOP(IEndDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnEndDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A738 RID: 42808 RVA: 0x003E22E9 File Offset: 0x003E04E9
			internal void LOEAMHGMMPK(IEndDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnEndDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A739 RID: 42809 RVA: 0x003E22E9 File Offset: 0x003E04E9
			internal void DBFPGFHEGKA(IEndDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnEndDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A73A RID: 42810 RVA: 0x003E22E9 File Offset: 0x003E04E9
			internal void JKEDCEOCPJO(IEndDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnEndDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A73B RID: 42811 RVA: 0x003E22E9 File Offset: 0x003E04E9
			internal void LLNDDFGPOPL(IEndDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnEndDrag(this.OLIIPKODDIN);
			}

			// Token: 0x0600A73C RID: 42812 RVA: 0x003E22E9 File Offset: 0x003E04E9
			internal void EKHOOPGPPGE(IEndDragHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnEndDrag(this.OLIIPKODDIN);
			}

			// Token: 0x040012B2 RID: 4786
			internal PointerEventData OLIIPKODDIN;
		}

		// Token: 0x020002B9 RID: 697
		[CompilerGenerated]
		private sealed class CBIBHMLEJGL
		{
			// Token: 0x0600A73D RID: 42813 RVA: 0x003E22F7 File Offset: 0x003E04F7
			internal void JDELIMPGFDJ(IScrollHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnScroll(this.OLIIPKODDIN);
			}

			// Token: 0x0600A73E RID: 42814 RVA: 0x003E22F7 File Offset: 0x003E04F7
			internal void DBFPGFHEGKA(IScrollHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnScroll(this.OLIIPKODDIN);
			}

			// Token: 0x0600A73F RID: 42815 RVA: 0x003E22F7 File Offset: 0x003E04F7
			internal void AEINPAGJFME(IScrollHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnScroll(this.OLIIPKODDIN);
			}

			// Token: 0x0600A740 RID: 42816 RVA: 0x003E22F7 File Offset: 0x003E04F7
			internal void GBKBDKHPLKG(IScrollHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnScroll(this.OLIIPKODDIN);
			}

			// Token: 0x0600A741 RID: 42817 RVA: 0x003E22F7 File Offset: 0x003E04F7
			internal void BKNHHGBPLGH(IScrollHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnScroll(this.OLIIPKODDIN);
			}

			// Token: 0x0600A742 RID: 42818 RVA: 0x003E22F7 File Offset: 0x003E04F7
			internal void FJDBPPKABJE(IScrollHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnScroll(this.OLIIPKODDIN);
			}

			// Token: 0x0600A743 RID: 42819 RVA: 0x003E22F7 File Offset: 0x003E04F7
			internal void OLIGLEMPFOP(IScrollHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnScroll(this.OLIIPKODDIN);
			}

			// Token: 0x0600A745 RID: 42821 RVA: 0x003E22F7 File Offset: 0x003E04F7
			internal void EGKGJJGAPMN(IScrollHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnScroll(this.OLIIPKODDIN);
			}

			// Token: 0x0600A746 RID: 42822 RVA: 0x003E22F7 File Offset: 0x003E04F7
			internal void MEMPOPNAEDN(IScrollHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnScroll(this.OLIIPKODDIN);
			}

			// Token: 0x0600A747 RID: 42823 RVA: 0x003E22F7 File Offset: 0x003E04F7
			internal void FIPCLHEKKCA(IScrollHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnScroll(this.OLIIPKODDIN);
			}

			// Token: 0x0600A748 RID: 42824 RVA: 0x003E22F7 File Offset: 0x003E04F7
			internal void LHHFJBIAHCN(IScrollHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnScroll(this.OLIIPKODDIN);
			}

			// Token: 0x0600A749 RID: 42825 RVA: 0x003E22F7 File Offset: 0x003E04F7
			internal void DKGPCPBNDPK(IScrollHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnScroll(this.OLIIPKODDIN);
			}

			// Token: 0x0600A74A RID: 42826 RVA: 0x003E22F7 File Offset: 0x003E04F7
			internal void FFEGPHJKMFK(IScrollHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnScroll(this.OLIIPKODDIN);
			}

			// Token: 0x0600A74B RID: 42827 RVA: 0x003E22F7 File Offset: 0x003E04F7
			internal void JKEDCEOCPJO(IScrollHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnScroll(this.OLIIPKODDIN);
			}

			// Token: 0x0600A74C RID: 42828 RVA: 0x003E22F7 File Offset: 0x003E04F7
			internal void LNDGINDKPFA(IScrollHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnScroll(this.OLIIPKODDIN);
			}

			// Token: 0x0600A74D RID: 42829 RVA: 0x003E22F7 File Offset: 0x003E04F7
			internal void BDGDIDPDBHG(IScrollHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnScroll(this.OLIIPKODDIN);
			}

			// Token: 0x0600A74E RID: 42830 RVA: 0x003E22F7 File Offset: 0x003E04F7
			internal void LLNDDFGPOPL(IScrollHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnScroll(this.OLIIPKODDIN);
			}

			// Token: 0x0600A74F RID: 42831 RVA: 0x003E22F7 File Offset: 0x003E04F7
			internal void EKHOOPGPPGE(IScrollHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnScroll(this.OLIIPKODDIN);
			}

			// Token: 0x0600A750 RID: 42832 RVA: 0x003E22F7 File Offset: 0x003E04F7
			internal void LOEAMHGMMPK(IScrollHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnScroll(this.OLIIPKODDIN);
			}

			// Token: 0x0600A751 RID: 42833 RVA: 0x003E22F7 File Offset: 0x003E04F7
			internal void PBCAHKDLFPE(IScrollHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnScroll(this.OLIIPKODDIN);
			}

			// Token: 0x0600A752 RID: 42834 RVA: 0x003E22F7 File Offset: 0x003E04F7
			internal void KFNBKFELFLH(IScrollHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnScroll(this.OLIIPKODDIN);
			}

			// Token: 0x0600A753 RID: 42835 RVA: 0x003E22F7 File Offset: 0x003E04F7
			internal void OFHCGKJFGDI(IScrollHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnScroll(this.OLIIPKODDIN);
			}

			// Token: 0x0600A754 RID: 42836 RVA: 0x003E22F7 File Offset: 0x003E04F7
			internal void BFEABMIFIEE(IScrollHandler OJICGBOIKNA)
			{
				OJICGBOIKNA.OnScroll(this.OLIIPKODDIN);
			}

			// Token: 0x040012B3 RID: 4787
			internal PointerEventData OLIIPKODDIN;
		}
	}
}
