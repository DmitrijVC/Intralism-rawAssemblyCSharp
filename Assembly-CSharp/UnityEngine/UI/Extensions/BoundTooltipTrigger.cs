using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002A2 RID: 674
	[AddComponentMenu("UI/Extensions/Bound Tooltip/Tooltip Trigger")]
	public class BoundTooltipTrigger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, ISelectHandler, IDeselectHandler, IEventSystemHandler
	{
		// Token: 0x0600A200 RID: 41472 RVA: 0x003C8706 File Offset: 0x003C6906
		public void NMKNKMGFJGG(PointerEventData OLIIPKODDIN)
		{
			this.LEBHKKBKCMF();
		}

		// Token: 0x0600A201 RID: 41473 RVA: 0x003C870E File Offset: 0x003C690E
		public void HPEKIOCMHCM(BaseEventData OLIIPKODDIN)
		{
			this.FCHPMLLGOGM(base.transform.position);
		}

		// Token: 0x0600A202 RID: 41474 RVA: 0x003C8721 File Offset: 0x003C6921
		public void OAOMDADPBCL(BaseEventData OLIIPKODDIN)
		{
			this.KKKBIAAFDDA(base.transform.position);
		}

		// Token: 0x0600A203 RID: 41475 RVA: 0x003C8734 File Offset: 0x003C6934
		public void LMFKBNMFJFL(PointerEventData OLIIPKODDIN)
		{
			this.GCFLEIMGFCA();
		}

		// Token: 0x0600A204 RID: 41476 RVA: 0x003C873C File Offset: 0x003C693C
		private void DMNACOKHNHB()
		{
			BoundTooltipItem.AOPOIJGMBDI().PHMGGLHDEGJ();
		}

		// Token: 0x0600A205 RID: 41477 RVA: 0x003C8748 File Offset: 0x003C6948
		private void OEHBMMGMKPD(Vector3 JOPCODOJBHD)
		{
			BoundTooltipItem.GLAEIAAPEFK().ShowTooltip(this.text, JOPCODOJBHD);
		}

		// Token: 0x0600A206 RID: 41478 RVA: 0x003C875B File Offset: 0x003C695B
		private void MGCENMELLFH(Vector3 JOPCODOJBHD)
		{
			BoundTooltipItem.BCLHIBPDOPP().JACHFOPPJLD(this.text, JOPCODOJBHD);
		}

		// Token: 0x0600A207 RID: 41479 RVA: 0x003C8770 File Offset: 0x003C6970
		public void HDMMMPOKLDK(PointerEventData OLIIPKODDIN)
		{
			if (this.useMousePosition)
			{
				this.DGPDKGONPPD(new Vector3(OLIIPKODDIN.position.x, OLIIPKODDIN.position.y, 391f));
			}
			else
			{
				this.HOEMONLHLHK(base.transform.position + this.offset);
			}
		}

		// Token: 0x0600A208 RID: 41480 RVA: 0x003C87D5 File Offset: 0x003C69D5
		public void LMFHBLPLFBH(BaseEventData OLIIPKODDIN)
		{
			this.DEGPJOOJHKB(base.transform.position);
		}

		// Token: 0x0600A209 RID: 41481 RVA: 0x003C87E8 File Offset: 0x003C69E8
		private void MGMNAEIKOOA()
		{
			BoundTooltipItem.GLAEIAAPEFK().CEHGJFIDHHF();
		}

		// Token: 0x0600A20A RID: 41482 RVA: 0x003C87F4 File Offset: 0x003C69F4
		private void CPCPJANDOKD(Vector3 JOPCODOJBHD)
		{
			BoundTooltipItem.JHHBLAJMCBF().GHECJNBFGJC(this.text, JOPCODOJBHD);
		}

		// Token: 0x0600A20B RID: 41483 RVA: 0x003C8807 File Offset: 0x003C6A07
		private void AHNNKFFEOBN(Vector3 JOPCODOJBHD)
		{
			BoundTooltipItem.LEFIEBAACNO().LKKIIHKFOPA(this.text, JOPCODOJBHD);
		}

		// Token: 0x0600A20C RID: 41484 RVA: 0x003C8706 File Offset: 0x003C6906
		public void AHOABDAANNL(PointerEventData OLIIPKODDIN)
		{
			this.LEBHKKBKCMF();
		}

		// Token: 0x0600A20D RID: 41485 RVA: 0x003C881A File Offset: 0x003C6A1A
		private void DGPDKGONPPD(Vector3 JOPCODOJBHD)
		{
			BoundTooltipItem.DNMHKEAGIJE().DABNHIBKLID(this.text, JOPCODOJBHD);
		}

		// Token: 0x0600A20E RID: 41486 RVA: 0x003C882D File Offset: 0x003C6A2D
		private void KOBECHKCABG()
		{
			BoundTooltipItem.KMLCFPCJNOB().ENFLFDIHMJE();
		}

		// Token: 0x0600A20F RID: 41487 RVA: 0x003C883C File Offset: 0x003C6A3C
		public void CGEOHCFCHJJ(PointerEventData OLIIPKODDIN)
		{
			if (this.useMousePosition)
			{
				this.FLOEJPAOHKG(new Vector3(OLIIPKODDIN.position.x, OLIIPKODDIN.position.y, 1663f));
			}
			else
			{
				this.HDIAOCLPLMJ(base.transform.position + this.offset);
			}
		}

		// Token: 0x0600A210 RID: 41488 RVA: 0x003C88A1 File Offset: 0x003C6AA1
		public void OnSelect(BaseEventData OLIIPKODDIN)
		{
			this.HOEMONLHLHK(base.transform.position);
		}

		// Token: 0x0600A211 RID: 41489 RVA: 0x003C88B4 File Offset: 0x003C6AB4
		public void MDDELAOIKPD(BaseEventData OLIIPKODDIN)
		{
			this.MNMGAFFCMBD(base.transform.position);
		}

		// Token: 0x0600A212 RID: 41490 RVA: 0x003C88C7 File Offset: 0x003C6AC7
		public void DOPPKNJEJKK(BaseEventData OLIIPKODDIN)
		{
			this.AHNNKFFEOBN(base.transform.position);
		}

		// Token: 0x0600A213 RID: 41491 RVA: 0x003C88DA File Offset: 0x003C6ADA
		public void GGEDCJCAIIC(PointerEventData OLIIPKODDIN)
		{
			this.CGCBEOJOEBH();
		}

		// Token: 0x0600A214 RID: 41492 RVA: 0x003C88E2 File Offset: 0x003C6AE2
		private void NLIHHKJAMFO(Vector3 JOPCODOJBHD)
		{
			BoundTooltipItem.LECLHHENMIA().OOFBGIBHPKO(this.text, JOPCODOJBHD);
		}

		// Token: 0x0600A215 RID: 41493 RVA: 0x003C88A1 File Offset: 0x003C6AA1
		public void APDFKNKBFIM(BaseEventData OLIIPKODDIN)
		{
			this.HOEMONLHLHK(base.transform.position);
		}

		// Token: 0x0600A216 RID: 41494 RVA: 0x003C88F5 File Offset: 0x003C6AF5
		public void MMECFOKDAIE(BaseEventData OLIIPKODDIN)
		{
			this.MGMNAEIKOOA();
		}

		// Token: 0x0600A217 RID: 41495 RVA: 0x003C88FD File Offset: 0x003C6AFD
		public void IOIHPMCPBPH(PointerEventData OLIIPKODDIN)
		{
			this.EFHCBDPFCCP();
		}

		// Token: 0x0600A218 RID: 41496 RVA: 0x003C8905 File Offset: 0x003C6B05
		public void ONELGAGOKKL(PointerEventData OLIIPKODDIN)
		{
			this.NFEICFOALJA();
		}

		// Token: 0x0600A219 RID: 41497 RVA: 0x003C8734 File Offset: 0x003C6934
		public void JINPCGEIGKJ(PointerEventData OLIIPKODDIN)
		{
			this.GCFLEIMGFCA();
		}

		// Token: 0x0600A21A RID: 41498 RVA: 0x003C890D File Offset: 0x003C6B0D
		private void GCFLEIMGFCA()
		{
			BoundTooltipItem.IBDLENPHGCD().JNOJNPCKAJN();
		}

		// Token: 0x0600A21B RID: 41499 RVA: 0x003C8919 File Offset: 0x003C6B19
		public void COINPBJAOMA(PointerEventData OLIIPKODDIN)
		{
			this.DMNACOKHNHB();
		}

		// Token: 0x0600A21C RID: 41500 RVA: 0x003C8921 File Offset: 0x003C6B21
		private void KKKBIAAFDDA(Vector3 JOPCODOJBHD)
		{
			BoundTooltipItem.BMLJJAMJPMO().NNKBKKFLMBH(this.text, JOPCODOJBHD);
		}

		// Token: 0x0600A21D RID: 41501 RVA: 0x003C8706 File Offset: 0x003C6906
		public void IGEBOHGMOFP(PointerEventData OLIIPKODDIN)
		{
			this.LEBHKKBKCMF();
		}

		// Token: 0x0600A21E RID: 41502 RVA: 0x003C8934 File Offset: 0x003C6B34
		public void MBFLHFHNGIM(PointerEventData OLIIPKODDIN)
		{
			if (this.useMousePosition)
			{
				this.JLNCBJCNOAB(new Vector3(OLIIPKODDIN.position.x, OLIIPKODDIN.position.y, 80f));
			}
			else
			{
				this.HDIAOCLPLMJ(base.transform.position + this.offset);
			}
		}

		// Token: 0x0600A21F RID: 41503 RVA: 0x003C88DA File Offset: 0x003C6ADA
		public void OnDeselect(BaseEventData OLIIPKODDIN)
		{
			this.CGCBEOJOEBH();
		}

		// Token: 0x0600A220 RID: 41504 RVA: 0x003C8999 File Offset: 0x003C6B99
		public void KPCLILNAJII(PointerEventData OLIIPKODDIN)
		{
			this.CJGLGOGOOEA();
		}

		// Token: 0x0600A221 RID: 41505 RVA: 0x003C89A4 File Offset: 0x003C6BA4
		public void LPEHMMKPHIO(PointerEventData OLIIPKODDIN)
		{
			if (this.useMousePosition)
			{
				this.DMDPBCEBEAK(new Vector3(OLIIPKODDIN.position.x, OLIIPKODDIN.position.y, 1339f));
			}
			else
			{
				this.FCHPMLLGOGM(base.transform.position + this.offset);
			}
		}

		// Token: 0x0600A222 RID: 41506 RVA: 0x003C8A09 File Offset: 0x003C6C09
		private void DAAKEGFBCBF()
		{
			BoundTooltipItem.GLAEIAAPEFK().PHMGGLHDEGJ();
		}

		// Token: 0x0600A223 RID: 41507 RVA: 0x003C8A15 File Offset: 0x003C6C15
		public void DPBHBAFBFFL(BaseEventData OLIIPKODDIN)
		{
			this.PIBLHHLPFBM(base.transform.position);
		}

		// Token: 0x0600A224 RID: 41508 RVA: 0x003C8A28 File Offset: 0x003C6C28
		private void DEGPJOOJHKB(Vector3 JOPCODOJBHD)
		{
			BoundTooltipItem.GFIEMBPCNEC().IIGIPEHOKGN(this.text, JOPCODOJBHD);
		}

		// Token: 0x0600A225 RID: 41509 RVA: 0x003C88B4 File Offset: 0x003C6AB4
		public void KHMAIEJNONJ(BaseEventData OLIIPKODDIN)
		{
			this.MNMGAFFCMBD(base.transform.position);
		}

		// Token: 0x0600A226 RID: 41510 RVA: 0x003C8A3B File Offset: 0x003C6C3B
		private void JDELENLOKKO()
		{
			BoundTooltipItem.LCGNLCPJBOH().DMDHNJPDJJK();
		}

		// Token: 0x0600A227 RID: 41511 RVA: 0x003C8A47 File Offset: 0x003C6C47
		public void LNJKPOIFKCA(PointerEventData OLIIPKODDIN)
		{
			this.GEHIDFGEEJA();
		}

		// Token: 0x0600A228 RID: 41512 RVA: 0x003C8A4F File Offset: 0x003C6C4F
		public void CJNEHMGPONG(BaseEventData OLIIPKODDIN)
		{
			this.KOBECHKCABG();
		}

		// Token: 0x0600A229 RID: 41513 RVA: 0x003C8A57 File Offset: 0x003C6C57
		private void FHMKLMPFDLG()
		{
			BoundTooltipItem.KIOBEHGBMCL().MDFMDDCBKCP();
		}

		// Token: 0x0600A22A RID: 41514 RVA: 0x003C8A63 File Offset: 0x003C6C63
		private void FCHPMLLGOGM(Vector3 JOPCODOJBHD)
		{
			BoundTooltipItem.LECLHHENMIA().OHPALEJAFGJ(this.text, JOPCODOJBHD);
		}

		// Token: 0x0600A22B RID: 41515 RVA: 0x003C8A78 File Offset: 0x003C6C78
		public void IADALDGIFLP(PointerEventData OLIIPKODDIN)
		{
			if (this.useMousePosition)
			{
				this.DEGPJOOJHKB(new Vector3(OLIIPKODDIN.position.x, OLIIPKODDIN.position.y, 625f));
			}
			else
			{
				this.FCHPMLLGOGM(base.transform.position + this.offset);
			}
		}

		// Token: 0x0600A22C RID: 41516 RVA: 0x003C8ADD File Offset: 0x003C6CDD
		public void EDJEGDPCBGO(BaseEventData OLIIPKODDIN)
		{
			this.HDIAOCLPLMJ(base.transform.position);
		}

		// Token: 0x0600A22D RID: 41517 RVA: 0x003C8AF0 File Offset: 0x003C6CF0
		private void MOBLIHCBNBP()
		{
			BoundTooltipItem.BCLHIBPDOPP().DMDHNJPDJJK();
		}

		// Token: 0x0600A22E RID: 41518 RVA: 0x003C8AFC File Offset: 0x003C6CFC
		private void CGCBEOJOEBH()
		{
			BoundTooltipItem.Instance.HideTooltip();
		}

		// Token: 0x0600A22F RID: 41519 RVA: 0x003C87D5 File Offset: 0x003C69D5
		public void OKJIHOCKOGI(BaseEventData OLIIPKODDIN)
		{
			this.DEGPJOOJHKB(base.transform.position);
		}

		// Token: 0x0600A230 RID: 41520 RVA: 0x003C8B08 File Offset: 0x003C6D08
		public void KFKEIOMFDJC(BaseEventData OLIIPKODDIN)
		{
			this.FHMKLMPFDLG();
		}

		// Token: 0x0600A231 RID: 41521 RVA: 0x003C8919 File Offset: 0x003C6B19
		public void HCJIKPDMHLN(BaseEventData OLIIPKODDIN)
		{
			this.DMNACOKHNHB();
		}

		// Token: 0x0600A232 RID: 41522 RVA: 0x003C8B08 File Offset: 0x003C6D08
		public void HEINHODDGOL(BaseEventData OLIIPKODDIN)
		{
			this.FHMKLMPFDLG();
		}

		// Token: 0x0600A233 RID: 41523 RVA: 0x003C8B10 File Offset: 0x003C6D10
		public void NJFFKFAHCOF(BaseEventData OLIIPKODDIN)
		{
			this.DMDPBCEBEAK(base.transform.position);
		}

		// Token: 0x0600A234 RID: 41524 RVA: 0x003C882D File Offset: 0x003C6A2D
		private void EFHCBDPFCCP()
		{
			BoundTooltipItem.KMLCFPCJNOB().ENFLFDIHMJE();
		}

		// Token: 0x0600A235 RID: 41525 RVA: 0x003C8B23 File Offset: 0x003C6D23
		public void ADHPKBEINJE(BaseEventData OLIIPKODDIN)
		{
			this.KFBEMMHFJND();
		}

		// Token: 0x0600A236 RID: 41526 RVA: 0x003C8919 File Offset: 0x003C6B19
		public void CBNIALEHHLN(BaseEventData OLIIPKODDIN)
		{
			this.DMNACOKHNHB();
		}

		// Token: 0x0600A237 RID: 41527 RVA: 0x003C8919 File Offset: 0x003C6B19
		public void IBHKDEINMNJ(BaseEventData OLIIPKODDIN)
		{
			this.DMNACOKHNHB();
		}

		// Token: 0x0600A239 RID: 41529 RVA: 0x003C8B2C File Offset: 0x003C6D2C
		public void NDMHJMFBHGC(PointerEventData OLIIPKODDIN)
		{
			if (this.useMousePosition)
			{
				this.MNMGAFFCMBD(new Vector3(OLIIPKODDIN.position.x, OLIIPKODDIN.position.y, 1797f));
			}
			else
			{
				this.CPCPJANDOKD(base.transform.position + this.offset);
			}
		}

		// Token: 0x0600A23A RID: 41530 RVA: 0x003C8B91 File Offset: 0x003C6D91
		private void HOEMONLHLHK(Vector3 JOPCODOJBHD)
		{
			BoundTooltipItem.Instance.ShowTooltip(this.text, JOPCODOJBHD);
		}

		// Token: 0x0600A23B RID: 41531 RVA: 0x003C8BA4 File Offset: 0x003C6DA4
		public void KJJHKJCEADD(PointerEventData OLIIPKODDIN)
		{
			if (this.useMousePosition)
			{
				this.AHNNKFFEOBN(new Vector3(OLIIPKODDIN.position.x, OLIIPKODDIN.position.y, 1275f));
			}
			else
			{
				this.DGPDKGONPPD(base.transform.position + this.offset);
			}
		}

		// Token: 0x0600A23C RID: 41532 RVA: 0x003C8C0C File Offset: 0x003C6E0C
		public void CFDMNMNMMIF(PointerEventData OLIIPKODDIN)
		{
			if (this.useMousePosition)
			{
				this.HOEMONLHLHK(new Vector3(OLIIPKODDIN.position.x, OLIIPKODDIN.position.y, 249f));
			}
			else
			{
				this.DMDPBCEBEAK(base.transform.position + this.offset);
			}
		}

		// Token: 0x0600A23D RID: 41533 RVA: 0x003C8C71 File Offset: 0x003C6E71
		public void MCGIEFGEAFO(PointerEventData OLIIPKODDIN)
		{
			this.DAAKEGFBCBF();
		}

		// Token: 0x0600A23E RID: 41534 RVA: 0x003C8C7C File Offset: 0x003C6E7C
		public void OnPointerEnter(PointerEventData OLIIPKODDIN)
		{
			if (this.useMousePosition)
			{
				this.HOEMONLHLHK(new Vector3(OLIIPKODDIN.position.x, OLIIPKODDIN.position.y, 0f));
			}
			else
			{
				this.HOEMONLHLHK(base.transform.position + this.offset);
			}
		}

		// Token: 0x0600A23F RID: 41535 RVA: 0x003C8CE4 File Offset: 0x003C6EE4
		public void ICBCBAOAGPC(PointerEventData OLIIPKODDIN)
		{
			if (this.useMousePosition)
			{
				this.FLOEJPAOHKG(new Vector3(OLIIPKODDIN.position.x, OLIIPKODDIN.position.y, 603f));
			}
			else
			{
				this.HDIAOCLPLMJ(base.transform.position + this.offset);
			}
		}

		// Token: 0x0600A240 RID: 41536 RVA: 0x003C8905 File Offset: 0x003C6B05
		public void IJJEMCGICJH(PointerEventData OLIIPKODDIN)
		{
			this.NFEICFOALJA();
		}

		// Token: 0x0600A241 RID: 41537 RVA: 0x003C8D4C File Offset: 0x003C6F4C
		public void HCMGGKHBELD(PointerEventData OLIIPKODDIN)
		{
			if (this.useMousePosition)
			{
				this.CPCPJANDOKD(new Vector3(OLIIPKODDIN.position.x, OLIIPKODDIN.position.y, 472f));
			}
			else
			{
				this.CPCPJANDOKD(base.transform.position + this.offset);
			}
		}

		// Token: 0x0600A242 RID: 41538 RVA: 0x003C8DB1 File Offset: 0x003C6FB1
		public void HEAPABJGJKB(BaseEventData OLIIPKODDIN)
		{
			this.NLIHHKJAMFO(base.transform.position);
		}

		// Token: 0x0600A243 RID: 41539 RVA: 0x003C8DC4 File Offset: 0x003C6FC4
		public void JJMDCGJENEL(PointerEventData OLIIPKODDIN)
		{
			if (this.useMousePosition)
			{
				this.PIBLHHLPFBM(new Vector3(OLIIPKODDIN.position.x, OLIIPKODDIN.position.y, 1900f));
			}
			else
			{
				this.NLIHHKJAMFO(base.transform.position + this.offset);
			}
		}

		// Token: 0x0600A244 RID: 41540 RVA: 0x003C8E29 File Offset: 0x003C7029
		private void PIBLHHLPFBM(Vector3 JOPCODOJBHD)
		{
			BoundTooltipItem.GLAEIAAPEFK().KNMJCEICJAP(this.text, JOPCODOJBHD);
		}

		// Token: 0x0600A245 RID: 41541 RVA: 0x003C8E3C File Offset: 0x003C703C
		public void BAJOFLCOJFF(PointerEventData OLIIPKODDIN)
		{
			if (this.useMousePosition)
			{
				this.NLIHHKJAMFO(new Vector3(OLIIPKODDIN.position.x, OLIIPKODDIN.position.y, 568f));
			}
			else
			{
				this.GDIMPKLIAPK(base.transform.position + this.offset);
			}
		}

		// Token: 0x0600A246 RID: 41542 RVA: 0x003C8A47 File Offset: 0x003C6C47
		public void BFKPLFGHBDK(PointerEventData OLIIPKODDIN)
		{
			this.GEHIDFGEEJA();
		}

		// Token: 0x0600A247 RID: 41543 RVA: 0x003C8EA4 File Offset: 0x003C70A4
		public void BMDGFNKHHDJ(PointerEventData OLIIPKODDIN)
		{
			if (this.useMousePosition)
			{
				this.HDIAOCLPLMJ(new Vector3(OLIIPKODDIN.position.x, OLIIPKODDIN.position.y, 1957f));
			}
			else
			{
				this.FCHPMLLGOGM(base.transform.position + this.offset);
			}
		}

		// Token: 0x0600A248 RID: 41544 RVA: 0x003C8A47 File Offset: 0x003C6C47
		public void ENGKBBJEEOP(PointerEventData OLIIPKODDIN)
		{
			this.GEHIDFGEEJA();
		}

		// Token: 0x0600A249 RID: 41545 RVA: 0x003C8F0C File Offset: 0x003C710C
		public void LKEOEKONABE(PointerEventData OLIIPKODDIN)
		{
			if (this.useMousePosition)
			{
				this.DEGPJOOJHKB(new Vector3(OLIIPKODDIN.position.x, OLIIPKODDIN.position.y, 592f));
			}
			else
			{
				this.MNMGAFFCMBD(base.transform.position + this.offset);
			}
		}

		// Token: 0x0600A24A RID: 41546 RVA: 0x003C8999 File Offset: 0x003C6B99
		public void NPNNDHOJICO(BaseEventData OLIIPKODDIN)
		{
			this.CJGLGOGOOEA();
		}

		// Token: 0x0600A24B RID: 41547 RVA: 0x003C8F71 File Offset: 0x003C7171
		private void JLNCBJCNOAB(Vector3 JOPCODOJBHD)
		{
			BoundTooltipItem.KMLCFPCJNOB().LPABGLHJACH(this.text, JOPCODOJBHD);
		}

		// Token: 0x0600A24C RID: 41548 RVA: 0x003C8F84 File Offset: 0x003C7184
		private void FLOEJPAOHKG(Vector3 JOPCODOJBHD)
		{
			BoundTooltipItem.BOGNFIBCFOM().OHCOKOPJDBE(this.text, JOPCODOJBHD);
		}

		// Token: 0x0600A24D RID: 41549 RVA: 0x003C8F97 File Offset: 0x003C7197
		public void PFCLPINEJOO(BaseEventData OLIIPKODDIN)
		{
			this.MOBLIHCBNBP();
		}

		// Token: 0x0600A24E RID: 41550 RVA: 0x003C8A47 File Offset: 0x003C6C47
		public void AIGFMLGDJPD(BaseEventData OLIIPKODDIN)
		{
			this.GEHIDFGEEJA();
		}

		// Token: 0x0600A24F RID: 41551 RVA: 0x003C8F9F File Offset: 0x003C719F
		private void NICLNLMEALH(Vector3 JOPCODOJBHD)
		{
			BoundTooltipItem.CNCBAJACOGD().AIIMPHBJHIK(this.text, JOPCODOJBHD);
		}

		// Token: 0x0600A250 RID: 41552 RVA: 0x003C8734 File Offset: 0x003C6934
		public void BPEIHNOBJMP(BaseEventData OLIIPKODDIN)
		{
			this.GCFLEIMGFCA();
		}

		// Token: 0x0600A251 RID: 41553 RVA: 0x003C88B4 File Offset: 0x003C6AB4
		public void LHONEABAMNG(BaseEventData OLIIPKODDIN)
		{
			this.MNMGAFFCMBD(base.transform.position);
		}

		// Token: 0x0600A252 RID: 41554 RVA: 0x003C8FB2 File Offset: 0x003C71B2
		private void GDIMPKLIAPK(Vector3 JOPCODOJBHD)
		{
			BoundTooltipItem.BIPJOHJMDJB().HPPPLMEICHH(this.text, JOPCODOJBHD);
		}

		// Token: 0x0600A253 RID: 41555 RVA: 0x003C88DA File Offset: 0x003C6ADA
		public void OnPointerExit(PointerEventData OLIIPKODDIN)
		{
			this.CGCBEOJOEBH();
		}

		// Token: 0x0600A254 RID: 41556 RVA: 0x003C8FC5 File Offset: 0x003C71C5
		private void GOOLMEBPGNP(Vector3 JOPCODOJBHD)
		{
			BoundTooltipItem.HMADOEFFOEM().LGNHNCGFMEA(this.text, JOPCODOJBHD);
		}

		// Token: 0x0600A255 RID: 41557 RVA: 0x003C8FD8 File Offset: 0x003C71D8
		private void DAGINEBNEEM(Vector3 JOPCODOJBHD)
		{
			BoundTooltipItem.DNMHKEAGIJE().ShowTooltip(this.text, JOPCODOJBHD);
		}

		// Token: 0x0600A256 RID: 41558 RVA: 0x003C8FEB File Offset: 0x003C71EB
		public void MPIABIOLELG(BaseEventData OLIIPKODDIN)
		{
			this.FLOEJPAOHKG(base.transform.position);
		}

		// Token: 0x0600A257 RID: 41559 RVA: 0x003C9000 File Offset: 0x003C7200
		public void OPEOOGMHBDB(PointerEventData OLIIPKODDIN)
		{
			if (this.useMousePosition)
			{
				this.OEHBMMGMKPD(new Vector3(OLIIPKODDIN.position.x, OLIIPKODDIN.position.y, 339f));
			}
			else
			{
				this.DMDPBCEBEAK(base.transform.position + this.offset);
			}
		}

		// Token: 0x0600A258 RID: 41560 RVA: 0x003C9068 File Offset: 0x003C7268
		public void AFFFFKEILCF(PointerEventData OLIIPKODDIN)
		{
			if (this.useMousePosition)
			{
				this.FCHPMLLGOGM(new Vector3(OLIIPKODDIN.position.x, OLIIPKODDIN.position.y, 226f));
			}
			else
			{
				this.DAGINEBNEEM(base.transform.position + this.offset);
			}
		}

		// Token: 0x0600A259 RID: 41561 RVA: 0x003C88FD File Offset: 0x003C6AFD
		public void NAOKPMGDBAG(BaseEventData OLIIPKODDIN)
		{
			this.EFHCBDPFCCP();
		}

		// Token: 0x0600A25A RID: 41562 RVA: 0x003C90CD File Offset: 0x003C72CD
		private void HDIAOCLPLMJ(Vector3 JOPCODOJBHD)
		{
			BoundTooltipItem.KIOBEHGBMCL().LPABGLHJACH(this.text, JOPCODOJBHD);
		}

		// Token: 0x0600A25B RID: 41563 RVA: 0x003C8F97 File Offset: 0x003C7197
		public void JNIGACGLFKC(BaseEventData OLIIPKODDIN)
		{
			this.MOBLIHCBNBP();
		}

		// Token: 0x0600A25C RID: 41564 RVA: 0x003C90E0 File Offset: 0x003C72E0
		private void CJGLGOGOOEA()
		{
			BoundTooltipItem.BMLJJAMJPMO().OKDGGFNIFCI();
		}

		// Token: 0x0600A25D RID: 41565 RVA: 0x003C8721 File Offset: 0x003C6921
		public void FEAKFOCPEOL(BaseEventData OLIIPKODDIN)
		{
			this.KKKBIAAFDDA(base.transform.position);
		}

		// Token: 0x0600A25E RID: 41566 RVA: 0x003C870E File Offset: 0x003C690E
		public void EOHMKNIBPLG(BaseEventData OLIIPKODDIN)
		{
			this.FCHPMLLGOGM(base.transform.position);
		}

		// Token: 0x0600A25F RID: 41567 RVA: 0x003C90EC File Offset: 0x003C72EC
		private void DMDPBCEBEAK(Vector3 JOPCODOJBHD)
		{
			BoundTooltipItem.Instance.LGNHNCGFMEA(this.text, JOPCODOJBHD);
		}

		// Token: 0x0600A260 RID: 41568 RVA: 0x003C90FF File Offset: 0x003C72FF
		private void MNMGAFFCMBD(Vector3 JOPCODOJBHD)
		{
			BoundTooltipItem.BIPJOHJMDJB().OOFBGIBHPKO(this.text, JOPCODOJBHD);
		}

		// Token: 0x0600A261 RID: 41569 RVA: 0x003C8F97 File Offset: 0x003C7197
		public void GANPFFDIDAK(PointerEventData OLIIPKODDIN)
		{
			this.MOBLIHCBNBP();
		}

		// Token: 0x0600A262 RID: 41570 RVA: 0x003C9114 File Offset: 0x003C7314
		public void PLEOKHBEBNA(PointerEventData OLIIPKODDIN)
		{
			if (this.useMousePosition)
			{
				this.DMDPBCEBEAK(new Vector3(OLIIPKODDIN.position.x, OLIIPKODDIN.position.y, 1530f));
			}
			else
			{
				this.HDIAOCLPLMJ(base.transform.position + this.offset);
			}
		}

		// Token: 0x0600A263 RID: 41571 RVA: 0x003C917C File Offset: 0x003C737C
		public void LDNEJOAHKKD(PointerEventData OLIIPKODDIN)
		{
			if (this.useMousePosition)
			{
				this.NLIHHKJAMFO(new Vector3(OLIIPKODDIN.position.x, OLIIPKODDIN.position.y, 608f));
			}
			else
			{
				this.MGCENMELLFH(base.transform.position + this.offset);
			}
		}

		// Token: 0x0600A264 RID: 41572 RVA: 0x003C8B23 File Offset: 0x003C6D23
		public void JOOKIPKFHFP(PointerEventData OLIIPKODDIN)
		{
			this.KFBEMMHFJND();
		}

		// Token: 0x0600A265 RID: 41573 RVA: 0x003C91E1 File Offset: 0x003C73E1
		private void GEHIDFGEEJA()
		{
			BoundTooltipItem.NGDEDGAAFNA().MFOKEJNJBLD();
		}

		// Token: 0x0600A266 RID: 41574 RVA: 0x003C91ED File Offset: 0x003C73ED
		public void NONPCDAOPHM(BaseEventData OLIIPKODDIN)
		{
			this.MGCENMELLFH(base.transform.position);
		}

		// Token: 0x0600A267 RID: 41575 RVA: 0x003C9200 File Offset: 0x003C7400
		private void LEBHKKBKCMF()
		{
			BoundTooltipItem.HGPHIHLIEPD().OKDGGFNIFCI();
		}

		// Token: 0x0600A268 RID: 41576 RVA: 0x003C8B08 File Offset: 0x003C6D08
		public void LPNJIHKDKCF(PointerEventData OLIIPKODDIN)
		{
			this.FHMKLMPFDLG();
		}

		// Token: 0x0600A269 RID: 41577 RVA: 0x003C8F97 File Offset: 0x003C7197
		public void PHLPANMMNBK(BaseEventData OLIIPKODDIN)
		{
			this.MOBLIHCBNBP();
		}

		// Token: 0x0600A26A RID: 41578 RVA: 0x003C920C File Offset: 0x003C740C
		private void KFBEMMHFJND()
		{
			BoundTooltipItem.KFPGDCHBEBC().NLMILEAIFHJ();
		}

		// Token: 0x0600A26B RID: 41579 RVA: 0x003C9218 File Offset: 0x003C7418
		public void BPEILFCNLOC(PointerEventData OLIIPKODDIN)
		{
			if (this.useMousePosition)
			{
				this.MGCENMELLFH(new Vector3(OLIIPKODDIN.position.x, OLIIPKODDIN.position.y, 1907f));
			}
			else
			{
				this.DAGINEBNEEM(base.transform.position + this.offset);
			}
		}

		// Token: 0x0600A26C RID: 41580 RVA: 0x003C927D File Offset: 0x003C747D
		private void NFEICFOALJA()
		{
			BoundTooltipItem.GBGAGCENJCL().ACACBDFKMOD();
		}

		// Token: 0x0400125F RID: 4703
		[TextArea]
		public string text;

		// Token: 0x04001260 RID: 4704
		public bool useMousePosition;

		// Token: 0x04001261 RID: 4705
		public Vector3 offset;
	}
}
