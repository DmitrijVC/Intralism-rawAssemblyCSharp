using System;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific
{
	// Token: 0x0200018B RID: 395
	public class MobileInput : VirtualInput
	{
		// Token: 0x0600735E RID: 29534 RVA: 0x00238EB0 File Offset: 0x002370B0
		private void IPPJKCNAEJN(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.RegisterVirtualAxis(new CrossPlatformInputManager.VirtualAxis(EBEHBBDKDFJ));
		}

		// Token: 0x0600735F RID: 29535 RVA: 0x00238EBD File Offset: 0x002370BD
		public virtual void EHKLKLKNOFF(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.IEHPKHLCOPC(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].JNBPKNNBMDI(1491f);
		}

		// Token: 0x06007360 RID: 29536 RVA: 0x00238EED File Offset: 0x002370ED
		public virtual void LBLBPBPIJBG(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.NNFBJCKOAAN(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].LLJLDLLNFBH(1455f);
		}

		// Token: 0x06007361 RID: 29537 RVA: 0x00238EB0 File Offset: 0x002370B0
		private void LKPNIOCHMHM(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.RegisterVirtualAxis(new CrossPlatformInputManager.VirtualAxis(EBEHBBDKDFJ));
		}

		// Token: 0x06007362 RID: 29538 RVA: 0x00238F1D File Offset: 0x0023711D
		public override void SetAxisPositive(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.MPAGFDJAAEG(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].Update(1f);
		}

		// Token: 0x06007363 RID: 29539 RVA: 0x00238F4D File Offset: 0x0023714D
		public virtual void FBHEGOEOCIE(string EBEHBBDKDFJ, float DPNHODJHGJL)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.LPGGEKNILEN(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].FOMNCPKKCFN(DPNHODJHGJL);
		}

		// Token: 0x06007364 RID: 29540 RVA: 0x00238F79 File Offset: 0x00237179
		public virtual void PACKMFEKMIG(string EBEHBBDKDFJ)
		{
			if (!this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				this.BDPBNLCFJDM(EBEHBBDKDFJ);
			}
			this.EPFOGMBOGLH[EBEHBBDKDFJ].IAKOCGPNHJM();
		}

		// Token: 0x06007365 RID: 29541 RVA: 0x00238FA4 File Offset: 0x002371A4
		public virtual float LFJHOJLCEGC(string EBEHBBDKDFJ, bool IBFFEGJDFNA)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.DFLNADPHPCO(EBEHBBDKDFJ);
			}
			return this.JOFMOEEOMCD[EBEHBBDKDFJ].HHBDOCNHMNH();
		}

		// Token: 0x06007366 RID: 29542 RVA: 0x00238FCF File Offset: 0x002371CF
		public virtual void ABKPMFPEOOF(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.OEICJOFLDHF(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].NDAJBJFJGCF(156f);
		}

		// Token: 0x06007367 RID: 29543 RVA: 0x00238FFF File Offset: 0x002371FF
		public virtual bool BGABPEFMCDE(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].DBOEEGIEDFA();
			}
			this.PIFDJNBKPOC(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].DAPDDIKKCOC();
		}

		// Token: 0x06007368 RID: 29544 RVA: 0x0023903C File Offset: 0x0023723C
		public override void SetAxisNegative(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.MPAGFDJAAEG(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].Update(-1f);
		}

		// Token: 0x06007369 RID: 29545 RVA: 0x0023906C File Offset: 0x0023726C
		public virtual bool HEPKPICDOGE(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].GetButtonUp;
			}
			this.PADIKONKAPL(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].HBKFKJHFABP();
		}

		// Token: 0x0600736A RID: 29546 RVA: 0x002390A9 File Offset: 0x002372A9
		public virtual bool MNEKLHOIAKA(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].KEEEMAGCDNN();
			}
			this.GCMMIBKBPEJ(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].KEEEMAGCDNN();
		}

		// Token: 0x0600736B RID: 29547 RVA: 0x002390E6 File Offset: 0x002372E6
		public virtual void FEDHALDMJDI(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.OEICJOFLDHF(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].NKLIHNJCHOG(764f);
		}

		// Token: 0x0600736C RID: 29548 RVA: 0x00239116 File Offset: 0x00237316
		public virtual bool DDJHLFBLDMJ(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].HBCEJLBNMKP();
			}
			this.PIFDJNBKPOC(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].LNGKNGOABBN();
		}

		// Token: 0x0600736D RID: 29549 RVA: 0x00239153 File Offset: 0x00237353
		private void BEJNIFMGPJB(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.RegisterVirtualButton(new CrossPlatformInputManager.VirtualButton(EBEHBBDKDFJ));
		}

		// Token: 0x0600736E RID: 29550 RVA: 0x00239160 File Offset: 0x00237360
		public virtual void KMPLANMHIDC(string EBEHBBDKDFJ, float DPNHODJHGJL)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.DEMKHLFNBLL(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].NDAJBJFJGCF(DPNHODJHGJL);
		}

		// Token: 0x0600736F RID: 29551 RVA: 0x0023918C File Offset: 0x0023738C
		public virtual void HMNPLIJEDKJ(string EBEHBBDKDFJ, float DPNHODJHGJL)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.KJKALNFCGCA(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].FOMNCPKKCFN(DPNHODJHGJL);
		}

		// Token: 0x06007370 RID: 29552 RVA: 0x002391B8 File Offset: 0x002373B8
		public virtual bool LHLMEEFLHNN(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].GetButtonUp;
			}
			this.OALIHKAHHIO(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].APIBFBMFKHH();
		}

		// Token: 0x06007371 RID: 29553 RVA: 0x002391F5 File Offset: 0x002373F5
		public virtual void DHGBHCEIOBB(string EBEHBBDKDFJ)
		{
			if (!this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				this.HMJHDDFJNBO(EBEHBBDKDFJ);
			}
			this.EPFOGMBOGLH[EBEHBBDKDFJ].Released();
		}

		// Token: 0x06007372 RID: 29554 RVA: 0x00239220 File Offset: 0x00237420
		public virtual void CGBIJPCLPJM(string EBEHBBDKDFJ, float DPNHODJHGJL)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.DFLNADPHPCO(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].FOMNCPKKCFN(DPNHODJHGJL);
		}

		// Token: 0x06007373 RID: 29555 RVA: 0x00239153 File Offset: 0x00237353
		private void GGDKLAAIHBM(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.RegisterVirtualButton(new CrossPlatformInputManager.VirtualButton(EBEHBBDKDFJ));
		}

		// Token: 0x06007374 RID: 29556 RVA: 0x0023924C File Offset: 0x0023744C
		public virtual void FJGACGNIGJG(string EBEHBBDKDFJ)
		{
			if (!this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				this.BDPBNLCFJDM(EBEHBBDKDFJ);
			}
			this.EPFOGMBOGLH[EBEHBBDKDFJ].FLGMNKODIGN();
		}

		// Token: 0x06007375 RID: 29557 RVA: 0x00239277 File Offset: 0x00237477
		public virtual bool MEKDLKDDEHL(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].DBGAEKIIMGK();
			}
			this.BHPBNHNNOEA(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].KEEEMAGCDNN();
		}

		// Token: 0x06007376 RID: 29558 RVA: 0x00239153 File Offset: 0x00237353
		private void PIFDJNBKPOC(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.RegisterVirtualButton(new CrossPlatformInputManager.VirtualButton(EBEHBBDKDFJ));
		}

		// Token: 0x06007377 RID: 29559 RVA: 0x002392B4 File Offset: 0x002374B4
		public virtual void GEOEJHKCHPE(string EBEHBBDKDFJ, float DPNHODJHGJL)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.KBHBBPAOHHL(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].Update(DPNHODJHGJL);
		}

		// Token: 0x06007378 RID: 29560 RVA: 0x002392E0 File Offset: 0x002374E0
		public virtual bool KLAHNCOHEHF(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].HBKFKJHFABP();
			}
			this.PIFDJNBKPOC(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].GetButtonUp;
		}

		// Token: 0x06007379 RID: 29561 RVA: 0x00238EB0 File Offset: 0x002370B0
		private void DEMKHLFNBLL(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.RegisterVirtualAxis(new CrossPlatformInputManager.VirtualAxis(EBEHBBDKDFJ));
		}

		// Token: 0x0600737B RID: 29563 RVA: 0x00239325 File Offset: 0x00237525
		public virtual Vector3 DJHKCCLPBKC()
		{
			return base.virtualMousePosition;
		}

		// Token: 0x0600737C RID: 29564 RVA: 0x0023932D File Offset: 0x0023752D
		public override void SetAxis(string EBEHBBDKDFJ, float DPNHODJHGJL)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.MPAGFDJAAEG(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].Update(DPNHODJHGJL);
		}

		// Token: 0x0600737D RID: 29565 RVA: 0x00239359 File Offset: 0x00237559
		public virtual void FEIPMDGJJPK(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.IPPJKCNAEJN(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].NDAJBJFJGCF(1447f);
		}

		// Token: 0x0600737E RID: 29566 RVA: 0x00239153 File Offset: 0x00237353
		private void BHPBNHNNOEA(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.RegisterVirtualButton(new CrossPlatformInputManager.VirtualButton(EBEHBBDKDFJ));
		}

		// Token: 0x0600737F RID: 29567 RVA: 0x00239389 File Offset: 0x00237589
		public virtual void AIOBMDMPJEO(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.MPAGFDJAAEG(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].NDAJBJFJGCF(1202f);
		}

		// Token: 0x06007380 RID: 29568 RVA: 0x002393B9 File Offset: 0x002375B9
		public virtual void HIHKBILKDEN(string EBEHBBDKDFJ)
		{
			if (!this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				this.GCMMIBKBPEJ(EBEHBBDKDFJ);
			}
			this.EPFOGMBOGLH[EBEHBBDKDFJ].JJEINPPFEKI();
		}

		// Token: 0x06007381 RID: 29569 RVA: 0x002393E4 File Offset: 0x002375E4
		public virtual void GOACDAIAFKD(string EBEHBBDKDFJ)
		{
			if (!this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				this.OALIHKAHHIO(EBEHBBDKDFJ);
			}
			this.EPFOGMBOGLH[EBEHBBDKDFJ].JJEINPPFEKI();
		}

		// Token: 0x06007382 RID: 29570 RVA: 0x00239325 File Offset: 0x00237525
		public virtual Vector3 NBFGEJFMBGO()
		{
			return base.virtualMousePosition;
		}

		// Token: 0x06007383 RID: 29571 RVA: 0x0023940F File Offset: 0x0023760F
		public virtual void KFGELMAHOBO(string EBEHBBDKDFJ, float DPNHODJHGJL)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.KJKALNFCGCA(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].NDAJBJFJGCF(DPNHODJHGJL);
		}

		// Token: 0x06007384 RID: 29572 RVA: 0x0023943B File Offset: 0x0023763B
		public virtual void EDKPCLJCLGK(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.DFLNADPHPCO(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].FOMNCPKKCFN(1639f);
		}

		// Token: 0x06007385 RID: 29573 RVA: 0x0023946B File Offset: 0x0023766B
		public virtual float POAMCFEFBNA(string EBEHBBDKDFJ, bool IBFFEGJDFNA)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.IEHPKHLCOPC(EBEHBBDKDFJ);
			}
			return this.JOFMOEEOMCD[EBEHBBDKDFJ].NPHNIDDOGDI();
		}

		// Token: 0x06007386 RID: 29574 RVA: 0x00239496 File Offset: 0x00237696
		public virtual void PEBMAKDFIDB(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.LPGGEKNILEN(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].NKLIHNJCHOG(909f);
		}

		// Token: 0x06007387 RID: 29575 RVA: 0x00239153 File Offset: 0x00237353
		private void PADIKONKAPL(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.RegisterVirtualButton(new CrossPlatformInputManager.VirtualButton(EBEHBBDKDFJ));
		}

		// Token: 0x06007388 RID: 29576 RVA: 0x002394C6 File Offset: 0x002376C6
		public virtual void JLCEIFDDPBK(string EBEHBBDKDFJ)
		{
			if (!this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				this.HMJHDDFJNBO(EBEHBBDKDFJ);
			}
			this.EPFOGMBOGLH[EBEHBBDKDFJ].IDOKGPNBJBG();
		}

		// Token: 0x06007389 RID: 29577 RVA: 0x00239325 File Offset: 0x00237525
		public virtual Vector3 CAJKFDLELNO()
		{
			return base.virtualMousePosition;
		}

		// Token: 0x0600738A RID: 29578 RVA: 0x00239325 File Offset: 0x00237525
		public virtual Vector3 DGOMLHAJBOI()
		{
			return base.virtualMousePosition;
		}

		// Token: 0x0600738B RID: 29579 RVA: 0x002394F1 File Offset: 0x002376F1
		public virtual void EOGLANEOMIB(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.KBHBBPAOHHL(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].BGFJOEPFOPM(1140f);
		}

		// Token: 0x0600738C RID: 29580 RVA: 0x00239521 File Offset: 0x00237721
		public virtual void AOMBKDGCAIG(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.MPAGFDJAAEG(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].IBHACCEEFFI(1005f);
		}

		// Token: 0x0600738D RID: 29581 RVA: 0x00239551 File Offset: 0x00237751
		public virtual void NCMDNBPKDIC(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.KBHBBPAOHHL(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].NKLIHNJCHOG(1966f);
		}

		// Token: 0x0600738E RID: 29582 RVA: 0x00239581 File Offset: 0x00237781
		public virtual bool IOMBFAMJKIC(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].DJIJNCPMLCB();
			}
			this.HMJHDDFJNBO(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].GetButtonDown;
		}

		// Token: 0x0600738F RID: 29583 RVA: 0x002395BE File Offset: 0x002377BE
		public override bool GetButton(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].GetButton;
			}
			this.OALIHKAHHIO(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].GetButton;
		}

		// Token: 0x06007390 RID: 29584 RVA: 0x002395FB File Offset: 0x002377FB
		public virtual void CIDCOBFIAND(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.IEHPKHLCOPC(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].JNBPKNNBMDI(1368f);
		}

		// Token: 0x06007391 RID: 29585 RVA: 0x0023962B File Offset: 0x0023782B
		public virtual bool MHJACLBAMDL(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].LNJGMIGLICB();
			}
			this.CINIIMPBBMB(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].MJEAFFHODKE();
		}

		// Token: 0x06007392 RID: 29586 RVA: 0x00239325 File Offset: 0x00237525
		public virtual Vector3 IFPGFLJFAFL()
		{
			return base.virtualMousePosition;
		}

		// Token: 0x06007393 RID: 29587 RVA: 0x00239668 File Offset: 0x00237868
		public override void SetButtonDown(string EBEHBBDKDFJ)
		{
			if (!this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				this.OALIHKAHHIO(EBEHBBDKDFJ);
			}
			this.EPFOGMBOGLH[EBEHBBDKDFJ].Pressed();
		}

		// Token: 0x06007394 RID: 29588 RVA: 0x00239693 File Offset: 0x00237893
		public virtual float ELKNGBPEBED(string EBEHBBDKDFJ, bool IBFFEGJDFNA)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.LPGGEKNILEN(EBEHBBDKDFJ);
			}
			return this.JOFMOEEOMCD[EBEHBBDKDFJ].GetValue;
		}

		// Token: 0x06007395 RID: 29589 RVA: 0x002396BE File Offset: 0x002378BE
		public virtual float LNEGKFDJCFP(string EBEHBBDKDFJ, bool IBFFEGJDFNA)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.ACPHJLIAKCF(EBEHBBDKDFJ);
			}
			return this.JOFMOEEOMCD[EBEHBBDKDFJ].NPHNIDDOGDI();
		}

		// Token: 0x06007396 RID: 29590 RVA: 0x002396E9 File Offset: 0x002378E9
		public virtual void EMPOJCGHFLJ(string EBEHBBDKDFJ, float DPNHODJHGJL)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.DFLNADPHPCO(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].LLJLDLLNFBH(DPNHODJHGJL);
		}

		// Token: 0x06007397 RID: 29591 RVA: 0x00239715 File Offset: 0x00237915
		public virtual void IMKHNLFBLKC(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.DFLNADPHPCO(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].BGFJOEPFOPM(336f);
		}

		// Token: 0x06007398 RID: 29592 RVA: 0x00239745 File Offset: 0x00237945
		public virtual void NHBJCLMCCKK(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.KJKALNFCGCA(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].Update(1020f);
		}

		// Token: 0x06007399 RID: 29593 RVA: 0x00239775 File Offset: 0x00237975
		public virtual void CNAKNNOFMBM(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.MPAGFDJAAEG(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].LLJLDLLNFBH(1018f);
		}

		// Token: 0x0600739A RID: 29594 RVA: 0x002397A5 File Offset: 0x002379A5
		public virtual void BPNLPHMJEMN(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.KBHBBPAOHHL(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].LLJLDLLNFBH(413f);
		}

		// Token: 0x0600739B RID: 29595 RVA: 0x002397D5 File Offset: 0x002379D5
		public virtual void FJBDNKLIJNG(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.LKPNIOCHMHM(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].LLJLDLLNFBH(1130f);
		}

		// Token: 0x0600739C RID: 29596 RVA: 0x00239805 File Offset: 0x00237A05
		public virtual float GFIOHABJNCG(string EBEHBBDKDFJ, bool IBFFEGJDFNA)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.DNDFHLIKKLN(EBEHBBDKDFJ);
			}
			return this.JOFMOEEOMCD[EBEHBBDKDFJ].GetValue;
		}

		// Token: 0x0600739D RID: 29597 RVA: 0x00239830 File Offset: 0x00237A30
		public override float GetAxis(string EBEHBBDKDFJ, bool IBFFEGJDFNA)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.MPAGFDJAAEG(EBEHBBDKDFJ);
			}
			return this.JOFMOEEOMCD[EBEHBBDKDFJ].GetValue;
		}

		// Token: 0x0600739E RID: 29598 RVA: 0x0023985B File Offset: 0x00237A5B
		public override void SetButtonUp(string EBEHBBDKDFJ)
		{
			if (!this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				this.OALIHKAHHIO(EBEHBBDKDFJ);
			}
			this.EPFOGMBOGLH[EBEHBBDKDFJ].Released();
		}

		// Token: 0x0600739F RID: 29599 RVA: 0x00238EB0 File Offset: 0x002370B0
		private void NNFBJCKOAAN(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.RegisterVirtualAxis(new CrossPlatformInputManager.VirtualAxis(EBEHBBDKDFJ));
		}

		// Token: 0x060073A0 RID: 29600 RVA: 0x00239886 File Offset: 0x00237A86
		public virtual bool BGDHEBDAAOG(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].DNFBINHIDPH();
			}
			this.OALIHKAHHIO(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].APIBFBMFKHH();
		}

		// Token: 0x060073A1 RID: 29601 RVA: 0x00238EB0 File Offset: 0x002370B0
		private void KBHBBPAOHHL(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.RegisterVirtualAxis(new CrossPlatformInputManager.VirtualAxis(EBEHBBDKDFJ));
		}

		// Token: 0x060073A2 RID: 29602 RVA: 0x00239325 File Offset: 0x00237525
		public virtual Vector3 EDINCKHKHAL()
		{
			return base.virtualMousePosition;
		}

		// Token: 0x060073A3 RID: 29603 RVA: 0x002398C3 File Offset: 0x00237AC3
		public virtual float JLPPEGBDNKA(string EBEHBBDKDFJ, bool IBFFEGJDFNA)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.LKPNIOCHMHM(EBEHBBDKDFJ);
			}
			return this.JOFMOEEOMCD[EBEHBBDKDFJ].BEBAEPPOHEG();
		}

		// Token: 0x060073A4 RID: 29604 RVA: 0x002398EE File Offset: 0x00237AEE
		public virtual void DLMNGHHFPPL(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.MPAGFDJAAEG(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].BGFJOEPFOPM(42f);
		}

		// Token: 0x060073A5 RID: 29605 RVA: 0x0023991E File Offset: 0x00237B1E
		public virtual void ENKNMMBPLGH(string EBEHBBDKDFJ)
		{
			if (!this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				this.BHPBNHNNOEA(EBEHBBDKDFJ);
			}
			this.EPFOGMBOGLH[EBEHBBDKDFJ].IDOKGPNBJBG();
		}

		// Token: 0x060073A6 RID: 29606 RVA: 0x00239949 File Offset: 0x00237B49
		public virtual bool LHLEBEOMMEH(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].GetButton;
			}
			this.CINIIMPBBMB(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].EODBJNNEHJM();
		}

		// Token: 0x060073A7 RID: 29607 RVA: 0x00239986 File Offset: 0x00237B86
		public virtual void IJNGFFPDKCB(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.DNDFHLIKKLN(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].NKLIHNJCHOG(1718f);
		}

		// Token: 0x060073A8 RID: 29608 RVA: 0x002399B6 File Offset: 0x00237BB6
		public virtual void KNIIKGGFHLO(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.IPPJKCNAEJN(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].LLJLDLLNFBH(1966f);
		}

		// Token: 0x060073A9 RID: 29609 RVA: 0x00239153 File Offset: 0x00237353
		private void PNDFFJJICAN(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.RegisterVirtualButton(new CrossPlatformInputManager.VirtualButton(EBEHBBDKDFJ));
		}

		// Token: 0x060073AA RID: 29610 RVA: 0x00239153 File Offset: 0x00237353
		private void GCMMIBKBPEJ(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.RegisterVirtualButton(new CrossPlatformInputManager.VirtualButton(EBEHBBDKDFJ));
		}

		// Token: 0x060073AB RID: 29611 RVA: 0x002399E6 File Offset: 0x00237BE6
		public virtual void CDBONLJOEJL(string EBEHBBDKDFJ, float DPNHODJHGJL)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.DFLNADPHPCO(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].JDGFCEPDKAJ(DPNHODJHGJL);
		}

		// Token: 0x060073AC RID: 29612 RVA: 0x00239A12 File Offset: 0x00237C12
		public virtual void CEJMGHOFGBF(string EBEHBBDKDFJ)
		{
			if (!this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				this.GGDKLAAIHBM(EBEHBBDKDFJ);
			}
			this.EPFOGMBOGLH[EBEHBBDKDFJ].FJHPAHEDLKC();
		}

		// Token: 0x060073AD RID: 29613 RVA: 0x00238EB0 File Offset: 0x002370B0
		private void MPAGFDJAAEG(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.RegisterVirtualAxis(new CrossPlatformInputManager.VirtualAxis(EBEHBBDKDFJ));
		}

		// Token: 0x060073AE RID: 29614 RVA: 0x00239A3D File Offset: 0x00237C3D
		public virtual void AEKJHBCEHBF(string EBEHBBDKDFJ)
		{
			if (!this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				this.BDPBNLCFJDM(EBEHBBDKDFJ);
			}
			this.EPFOGMBOGLH[EBEHBBDKDFJ].JLIOOPBKFIL();
		}

		// Token: 0x060073AF RID: 29615 RVA: 0x00239A68 File Offset: 0x00237C68
		public virtual void OLCOCGKNPAH(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.LPGGEKNILEN(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].BGFJOEPFOPM(956f);
		}

		// Token: 0x060073B0 RID: 29616 RVA: 0x00239220 File Offset: 0x00237420
		public virtual void BBIFPHNEGJO(string EBEHBBDKDFJ, float DPNHODJHGJL)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.DFLNADPHPCO(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].FOMNCPKKCFN(DPNHODJHGJL);
		}

		// Token: 0x060073B1 RID: 29617 RVA: 0x00239325 File Offset: 0x00237525
		public virtual Vector3 NIFFNDGPNPK()
		{
			return base.virtualMousePosition;
		}

		// Token: 0x060073B2 RID: 29618 RVA: 0x00239A98 File Offset: 0x00237C98
		public virtual void KBEHPADHJNE(string EBEHBBDKDFJ, float DPNHODJHGJL)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.KBHBBPAOHHL(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].JDGFCEPDKAJ(DPNHODJHGJL);
		}

		// Token: 0x060073B3 RID: 29619 RVA: 0x00238EB0 File Offset: 0x002370B0
		private void LPGGEKNILEN(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.RegisterVirtualAxis(new CrossPlatformInputManager.VirtualAxis(EBEHBBDKDFJ));
		}

		// Token: 0x060073B4 RID: 29620 RVA: 0x00239325 File Offset: 0x00237525
		public virtual Vector3 CCJNFMJGOMK()
		{
			return base.virtualMousePosition;
		}

		// Token: 0x060073B5 RID: 29621 RVA: 0x002399E6 File Offset: 0x00237BE6
		public virtual void FLCKKLCLOFE(string EBEHBBDKDFJ, float DPNHODJHGJL)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.DFLNADPHPCO(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].JDGFCEPDKAJ(DPNHODJHGJL);
		}

		// Token: 0x060073B6 RID: 29622 RVA: 0x00239AC4 File Offset: 0x00237CC4
		public virtual bool HKAHCGAFBOK(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].LPBMODOPDOI();
			}
			this.BHPBNHNNOEA(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].DBGAEKIIMGK();
		}

		// Token: 0x060073B7 RID: 29623 RVA: 0x00239B01 File Offset: 0x00237D01
		public virtual void DBNJLNNOPFC(string EBEHBBDKDFJ)
		{
			if (!this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				this.HMJHDDFJNBO(EBEHBBDKDFJ);
			}
			this.EPFOGMBOGLH[EBEHBBDKDFJ].HFFEFJELMEH();
		}

		// Token: 0x060073B8 RID: 29624 RVA: 0x00239325 File Offset: 0x00237525
		public virtual Vector3 JAKGHCCPHFE()
		{
			return base.virtualMousePosition;
		}

		// Token: 0x060073B9 RID: 29625 RVA: 0x00239B2C File Offset: 0x00237D2C
		public virtual bool DCILALBKMAC(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].DAPDDIKKCOC();
			}
			this.GCMMIBKBPEJ(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].KHENAAAJJNP();
		}

		// Token: 0x060073BA RID: 29626 RVA: 0x00239B69 File Offset: 0x00237D69
		public virtual void KCBNGJFDEIG(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.IEHPKHLCOPC(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].Update(260f);
		}

		// Token: 0x060073BB RID: 29627 RVA: 0x00239B99 File Offset: 0x00237D99
		public virtual void HKGFAKMBGND(string EBEHBBDKDFJ)
		{
			if (!this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				this.PNDFFJJICAN(EBEHBBDKDFJ);
			}
			this.EPFOGMBOGLH[EBEHBBDKDFJ].IDOKGPNBJBG();
		}

		// Token: 0x060073BC RID: 29628 RVA: 0x00239153 File Offset: 0x00237353
		private void OALIHKAHHIO(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.RegisterVirtualButton(new CrossPlatformInputManager.VirtualButton(EBEHBBDKDFJ));
		}

		// Token: 0x060073BD RID: 29629 RVA: 0x00239BC4 File Offset: 0x00237DC4
		public virtual bool KKLGNEAOJEP(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].LMIDFLOKIJD();
			}
			this.CINIIMPBBMB(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].DBOEEGIEDFA();
		}

		// Token: 0x060073BE RID: 29630 RVA: 0x00239325 File Offset: 0x00237525
		public override Vector3 MousePosition()
		{
			return base.virtualMousePosition;
		}

		// Token: 0x060073BF RID: 29631 RVA: 0x00239C01 File Offset: 0x00237E01
		public virtual float LPNDELNKEIN(string EBEHBBDKDFJ, bool IBFFEGJDFNA)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.IEHPKHLCOPC(EBEHBBDKDFJ);
			}
			return this.JOFMOEEOMCD[EBEHBBDKDFJ].BEBAEPPOHEG();
		}

		// Token: 0x060073C0 RID: 29632 RVA: 0x00239C2C File Offset: 0x00237E2C
		public virtual void IEFDOIIPNIH(string EBEHBBDKDFJ)
		{
			if (!this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				this.GGDKLAAIHBM(EBEHBBDKDFJ);
			}
			this.EPFOGMBOGLH[EBEHBBDKDFJ].AHOIEDPGMPE();
		}

		// Token: 0x060073C1 RID: 29633 RVA: 0x00239C57 File Offset: 0x00237E57
		public virtual void GIPILEHPLLD(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.MPAGFDJAAEG(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].JDGFCEPDKAJ(358f);
		}

		// Token: 0x060073C2 RID: 29634 RVA: 0x00239C87 File Offset: 0x00237E87
		public virtual void PNHBBMCPGPO(string EBEHBBDKDFJ)
		{
			if (!this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				this.PNDFFJJICAN(EBEHBBDKDFJ);
			}
			this.EPFOGMBOGLH[EBEHBBDKDFJ].Pressed();
		}

		// Token: 0x060073C3 RID: 29635 RVA: 0x00239CB2 File Offset: 0x00237EB2
		public virtual bool CLFEDOHPDGI(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].DAPDDIKKCOC();
			}
			this.CINIIMPBBMB(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].KHENAAAJJNP();
		}

		// Token: 0x060073C4 RID: 29636 RVA: 0x00239CEF File Offset: 0x00237EEF
		public virtual void NLGNBAALFLJ(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.LKPNIOCHMHM(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].BGFJOEPFOPM(1535f);
		}

		// Token: 0x060073C5 RID: 29637 RVA: 0x00239325 File Offset: 0x00237525
		public virtual Vector3 NCIGNEFBGPH()
		{
			return base.virtualMousePosition;
		}

		// Token: 0x060073C6 RID: 29638 RVA: 0x00239153 File Offset: 0x00237353
		private void BDPBNLCFJDM(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.RegisterVirtualButton(new CrossPlatformInputManager.VirtualButton(EBEHBBDKDFJ));
		}

		// Token: 0x060073C7 RID: 29639 RVA: 0x00239D1F File Offset: 0x00237F1F
		public virtual void AIHIKAGFFIC(string EBEHBBDKDFJ, float DPNHODJHGJL)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.IEHPKHLCOPC(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].BGFJOEPFOPM(DPNHODJHGJL);
		}

		// Token: 0x060073C8 RID: 29640 RVA: 0x00239D4B File Offset: 0x00237F4B
		public virtual bool JKJBLHEBMDM(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].EODBJNNEHJM();
			}
			this.HMJHDDFJNBO(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].FDBNBGAAIAF();
		}

		// Token: 0x060073C9 RID: 29641 RVA: 0x00239D88 File Offset: 0x00237F88
		public virtual void CMHOFAKOIMO(string EBEHBBDKDFJ, float DPNHODJHGJL)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.ACPHJLIAKCF(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].IBHACCEEFFI(DPNHODJHGJL);
		}

		// Token: 0x060073CA RID: 29642 RVA: 0x00238EB0 File Offset: 0x002370B0
		private void ACPHJLIAKCF(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.RegisterVirtualAxis(new CrossPlatformInputManager.VirtualAxis(EBEHBBDKDFJ));
		}

		// Token: 0x060073CB RID: 29643 RVA: 0x00239DB4 File Offset: 0x00237FB4
		public virtual bool DMKDKPNCFCN(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].KEEEMAGCDNN();
			}
			this.PADIKONKAPL(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].KEEEMAGCDNN();
		}

		// Token: 0x060073CC RID: 29644 RVA: 0x00238EB0 File Offset: 0x002370B0
		private void OEICJOFLDHF(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.RegisterVirtualAxis(new CrossPlatformInputManager.VirtualAxis(EBEHBBDKDFJ));
		}

		// Token: 0x060073CD RID: 29645 RVA: 0x00239DF1 File Offset: 0x00237FF1
		public virtual void APLAOOCBHHB(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.LKPNIOCHMHM(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].JNBPKNNBMDI(411f);
		}

		// Token: 0x060073CE RID: 29646 RVA: 0x00239153 File Offset: 0x00237353
		private void CINIIMPBBMB(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.RegisterVirtualButton(new CrossPlatformInputManager.VirtualButton(EBEHBBDKDFJ));
		}

		// Token: 0x060073CF RID: 29647 RVA: 0x00239325 File Offset: 0x00237525
		public virtual Vector3 AOEHJDOLKDE()
		{
			return base.virtualMousePosition;
		}

		// Token: 0x060073D0 RID: 29648 RVA: 0x00239E21 File Offset: 0x00238021
		public virtual void PJGGHICAFDM(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.LKPNIOCHMHM(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].Update(549f);
		}

		// Token: 0x060073D1 RID: 29649 RVA: 0x00239325 File Offset: 0x00237525
		public virtual Vector3 IDGMJKFKIOO()
		{
			return base.virtualMousePosition;
		}

		// Token: 0x060073D2 RID: 29650 RVA: 0x00239E51 File Offset: 0x00238051
		public virtual void HFFLODPDIDD(string EBEHBBDKDFJ, float DPNHODJHGJL)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.OEICJOFLDHF(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].Update(DPNHODJHGJL);
		}

		// Token: 0x060073D3 RID: 29651 RVA: 0x00239E7D File Offset: 0x0023807D
		public virtual float JKHEOKCLBPO(string EBEHBBDKDFJ, bool IBFFEGJDFNA)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.KJKALNFCGCA(EBEHBBDKDFJ);
			}
			return this.JOFMOEEOMCD[EBEHBBDKDFJ].DEIHPCMEHBO();
		}

		// Token: 0x060073D4 RID: 29652 RVA: 0x00239EA8 File Offset: 0x002380A8
		public override void SetAxisZero(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.MPAGFDJAAEG(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].Update(0f);
		}

		// Token: 0x060073D5 RID: 29653 RVA: 0x00239ED8 File Offset: 0x002380D8
		public virtual float NBGMFALBONC(string EBEHBBDKDFJ, bool IBFFEGJDFNA)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.LKPNIOCHMHM(EBEHBBDKDFJ);
			}
			return this.JOFMOEEOMCD[EBEHBBDKDFJ].NPHNIDDOGDI();
		}

		// Token: 0x060073D6 RID: 29654 RVA: 0x00239F03 File Offset: 0x00238103
		public virtual void IBEGMPAFKIJ(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.DEMKHLFNBLL(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].JDGFCEPDKAJ(399f);
		}

		// Token: 0x060073D7 RID: 29655 RVA: 0x00239F33 File Offset: 0x00238133
		public virtual bool NNPFPAAJHID(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].GetButtonUp;
			}
			this.OALIHKAHHIO(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].FEHPDDIECMK();
		}

		// Token: 0x060073D8 RID: 29656 RVA: 0x00239325 File Offset: 0x00237525
		public virtual Vector3 NBLEFMPHNEA()
		{
			return base.virtualMousePosition;
		}

		// Token: 0x060073D9 RID: 29657 RVA: 0x00239F70 File Offset: 0x00238170
		public virtual float NPAAKMHOGBO(string EBEHBBDKDFJ, bool IBFFEGJDFNA)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.LKPNIOCHMHM(EBEHBBDKDFJ);
			}
			return this.JOFMOEEOMCD[EBEHBBDKDFJ].MOMIHHIMFCE();
		}

		// Token: 0x060073DA RID: 29658 RVA: 0x00239F9B File Offset: 0x0023819B
		public virtual bool JNDGCDLBNMO(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].DJIJNCPMLCB();
			}
			this.PIFDJNBKPOC(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].KHENAAAJJNP();
		}

		// Token: 0x060073DB RID: 29659 RVA: 0x00239FD8 File Offset: 0x002381D8
		public virtual bool JCJGGMIFGHM(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].FDBNBGAAIAF();
			}
			this.PADIKONKAPL(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].FDBNBGAAIAF();
		}

		// Token: 0x060073DC RID: 29660 RVA: 0x00239325 File Offset: 0x00237525
		public virtual Vector3 POIGLGBACOG()
		{
			return base.virtualMousePosition;
		}

		// Token: 0x060073DD RID: 29661 RVA: 0x0023A015 File Offset: 0x00238215
		public virtual void HEBBKIIMPJK(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.ACPHJLIAKCF(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].Update(1971f);
		}

		// Token: 0x060073DE RID: 29662 RVA: 0x00239325 File Offset: 0x00237525
		public virtual Vector3 HEOMMGKBOCN()
		{
			return base.virtualMousePosition;
		}

		// Token: 0x060073DF RID: 29663 RVA: 0x0023A045 File Offset: 0x00238245
		public virtual void CHDBEJAMBEH(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.KBHBBPAOHHL(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].JNBPKNNBMDI(1073f);
		}

		// Token: 0x060073E0 RID: 29664 RVA: 0x0023A075 File Offset: 0x00238275
		public override bool GetButtonUp(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].GetButtonUp;
			}
			this.OALIHKAHHIO(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].GetButtonUp;
		}

		// Token: 0x060073E1 RID: 29665 RVA: 0x0023A0B2 File Offset: 0x002382B2
		public virtual bool PGEDKKJGCLF(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].FDBNBGAAIAF();
			}
			this.GGDKLAAIHBM(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].LPBMODOPDOI();
		}

		// Token: 0x060073E2 RID: 29666 RVA: 0x0023A0EF File Offset: 0x002382EF
		public virtual float HDAJCMKCLGI(string EBEHBBDKDFJ, bool IBFFEGJDFNA)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.DFLNADPHPCO(EBEHBBDKDFJ);
			}
			return this.JOFMOEEOMCD[EBEHBBDKDFJ].BEBAEPPOHEG();
		}

		// Token: 0x060073E3 RID: 29667 RVA: 0x0023A11A File Offset: 0x0023831A
		public virtual float DCOBLPDBKID(string EBEHBBDKDFJ, bool IBFFEGJDFNA)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.LKPNIOCHMHM(EBEHBBDKDFJ);
			}
			return this.JOFMOEEOMCD[EBEHBBDKDFJ].ADGPGPJICDG();
		}

		// Token: 0x060073E4 RID: 29668 RVA: 0x0023A145 File Offset: 0x00238345
		public virtual void AODFAEKNKIF(string EBEHBBDKDFJ)
		{
			if (!this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				this.GGDKLAAIHBM(EBEHBBDKDFJ);
			}
			this.EPFOGMBOGLH[EBEHBBDKDFJ].JJNMCNPKDCA();
		}

		// Token: 0x060073E5 RID: 29669 RVA: 0x00238EB0 File Offset: 0x002370B0
		private void KJKALNFCGCA(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.RegisterVirtualAxis(new CrossPlatformInputManager.VirtualAxis(EBEHBBDKDFJ));
		}

		// Token: 0x060073E6 RID: 29670 RVA: 0x00238EB0 File Offset: 0x002370B0
		private void DFLNADPHPCO(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.RegisterVirtualAxis(new CrossPlatformInputManager.VirtualAxis(EBEHBBDKDFJ));
		}

		// Token: 0x060073E7 RID: 29671 RVA: 0x00239153 File Offset: 0x00237353
		private void HMJHDDFJNBO(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.RegisterVirtualButton(new CrossPlatformInputManager.VirtualButton(EBEHBBDKDFJ));
		}

		// Token: 0x060073E8 RID: 29672 RVA: 0x0023A170 File Offset: 0x00238370
		public virtual void LMJPAFEKBLF(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.LKPNIOCHMHM(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].FOMNCPKKCFN(1034f);
		}

		// Token: 0x060073E9 RID: 29673 RVA: 0x0023A1A0 File Offset: 0x002383A0
		public virtual void GGBJGNOFGHJ(string EBEHBBDKDFJ, float DPNHODJHGJL)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.KJKALNFCGCA(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].LLJLDLLNFBH(DPNHODJHGJL);
		}

		// Token: 0x060073EA RID: 29674 RVA: 0x0023A1CC File Offset: 0x002383CC
		public virtual void CMFEBOPOFFJ(string EBEHBBDKDFJ)
		{
			if (!this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				this.PNDFFJJICAN(EBEHBBDKDFJ);
			}
			this.EPFOGMBOGLH[EBEHBBDKDFJ].AHOIEDPGMPE();
		}

		// Token: 0x060073EB RID: 29675 RVA: 0x00238EB0 File Offset: 0x002370B0
		private void DNDFHLIKKLN(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.RegisterVirtualAxis(new CrossPlatformInputManager.VirtualAxis(EBEHBBDKDFJ));
		}

		// Token: 0x060073EC RID: 29676 RVA: 0x00238EB0 File Offset: 0x002370B0
		private void IEHPKHLCOPC(string EBEHBBDKDFJ)
		{
			CrossPlatformInputManager.RegisterVirtualAxis(new CrossPlatformInputManager.VirtualAxis(EBEHBBDKDFJ));
		}

		// Token: 0x060073ED RID: 29677 RVA: 0x0023A1F7 File Offset: 0x002383F7
		public virtual void KEDJJFMLNDL(string EBEHBBDKDFJ)
		{
			if (!this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				this.PADIKONKAPL(EBEHBBDKDFJ);
			}
			this.EPFOGMBOGLH[EBEHBBDKDFJ].AHOIEDPGMPE();
		}

		// Token: 0x060073EE RID: 29678 RVA: 0x0023A222 File Offset: 0x00238422
		public virtual void MFIPOICKPFD(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.MPAGFDJAAEG(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].LLJLDLLNFBH(1805f);
		}

		// Token: 0x060073EF RID: 29679 RVA: 0x0023A252 File Offset: 0x00238452
		public virtual bool JJLGKEHPAPF(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].LNJGMIGLICB();
			}
			this.BHPBNHNNOEA(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].APIBFBMFKHH();
		}

		// Token: 0x060073F0 RID: 29680 RVA: 0x00239325 File Offset: 0x00237525
		public virtual Vector3 EMFKGMPNLAB()
		{
			return base.virtualMousePosition;
		}

		// Token: 0x060073F1 RID: 29681 RVA: 0x0023A28F File Offset: 0x0023848F
		public virtual void JFHEDINIDIN(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.DNDFHLIKKLN(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].NKLIHNJCHOG(850f);
		}

		// Token: 0x060073F2 RID: 29682 RVA: 0x0023A2BF File Offset: 0x002384BF
		public virtual void KFPLKNIBOOI(string EBEHBBDKDFJ)
		{
			if (!this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				this.CINIIMPBBMB(EBEHBBDKDFJ);
			}
			this.EPFOGMBOGLH[EBEHBBDKDFJ].FLGMNKODIGN();
		}

		// Token: 0x060073F3 RID: 29683 RVA: 0x0023A2EA File Offset: 0x002384EA
		public virtual void OGHGKDMFJHH(string EBEHBBDKDFJ)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.MPAGFDJAAEG(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].NKLIHNJCHOG(611f);
		}

		// Token: 0x060073F4 RID: 29684 RVA: 0x0023A31A File Offset: 0x0023851A
		public virtual bool KGAPDGJECMN(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].DBOEEGIEDFA();
			}
			this.GGDKLAAIHBM(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].HBCEJLBNMKP();
		}

		// Token: 0x060073F5 RID: 29685 RVA: 0x0023A357 File Offset: 0x00238557
		public virtual bool HKJHNJMMAPF(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].LMIDFLOKIJD();
			}
			this.GGDKLAAIHBM(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].DAPDDIKKCOC();
		}

		// Token: 0x060073F6 RID: 29686 RVA: 0x0023A394 File Offset: 0x00238594
		public virtual void KIMBOGBFMMG(string EBEHBBDKDFJ)
		{
			if (!this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				this.PADIKONKAPL(EBEHBBDKDFJ);
			}
			this.EPFOGMBOGLH[EBEHBBDKDFJ].JLIOOPBKFIL();
		}

		// Token: 0x060073F7 RID: 29687 RVA: 0x0023A3BF File Offset: 0x002385BF
		public override bool GetButtonDown(string EBEHBBDKDFJ)
		{
			if (this.EPFOGMBOGLH.ContainsKey(EBEHBBDKDFJ))
			{
				return this.EPFOGMBOGLH[EBEHBBDKDFJ].GetButtonDown;
			}
			this.OALIHKAHHIO(EBEHBBDKDFJ);
			return this.EPFOGMBOGLH[EBEHBBDKDFJ].GetButtonDown;
		}

		// Token: 0x060073F8 RID: 29688 RVA: 0x0023A3FC File Offset: 0x002385FC
		public virtual void BDAOKPBMNFM(string EBEHBBDKDFJ, float DPNHODJHGJL)
		{
			if (!this.JOFMOEEOMCD.ContainsKey(EBEHBBDKDFJ))
			{
				this.LKPNIOCHMHM(EBEHBBDKDFJ);
			}
			this.JOFMOEEOMCD[EBEHBBDKDFJ].IBHACCEEFFI(DPNHODJHGJL);
		}
	}
}
