using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace HardShellStudios.InputManager
{
	// Token: 0x0200015E RID: 350
	[AddComponentMenu("Hard Shell Studios/Input Manager/Rebind Button")]
	public class hardInputUI : MonoBehaviour
	{
		// Token: 0x060067DE RID: 26590 RVA: 0x001F33E4 File Offset: 0x001F15E4
		private void FLEOGEBIADI()
		{
			this.JMAAPCIBDNO();
		}

		// Token: 0x060067DF RID: 26591 RVA: 0x001F33EC File Offset: 0x001F15EC
		private void MGPEEODMKND()
		{
			this.GDFIEOPHMPP();
		}

		// Token: 0x060067E0 RID: 26592 RVA: 0x001F33F4 File Offset: 0x001F15F4
		private void PCCEPADONHK()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.GetKeyName(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "Updating...";
				}
			}
		}

		// Token: 0x060067E1 RID: 26593 RVA: 0x001F3459 File Offset: 0x001F1659
		private void PEMPABLNJHL()
		{
			base.GetComponent<Button>().onClick.RemoveAllListeners();
			base.GetComponent<Button>().onClick.AddListener(new UnityAction(this.LILCAENMADC));
		}

		// Token: 0x060067E2 RID: 26594 RVA: 0x001F3487 File Offset: 0x001F1687
		private void JNIPABEGJND()
		{
			base.GetComponent<Button>().onClick.RemoveAllListeners();
			base.GetComponent<Button>().onClick.AddListener(new UnityAction(this.MJOFHNEPNCH));
		}

		// Token: 0x060067E3 RID: 26595 RVA: 0x001F34B8 File Offset: 0x001F16B8
		private void KJMHKHDMKIE()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.EPIFCBNFKNO(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "Editor/";
				}
			}
		}

		// Token: 0x060067E4 RID: 26596 RVA: 0x001F351D File Offset: 0x001F171D
		private void PMBIKIBOHOF()
		{
			base.GetComponent<Button>().onClick.RemoveAllListeners();
			base.GetComponent<Button>().onClick.AddListener(new UnityAction(this.MGPEEODMKND));
		}

		// Token: 0x060067E5 RID: 26597 RVA: 0x001F354C File Offset: 0x001F174C
		private void CPJBNBJMJFA()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.GetKeyName(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "_TimeX";
				}
			}
		}

		// Token: 0x060067E6 RID: 26598 RVA: 0x001F35B1 File Offset: 0x001F17B1
		private void JHFJOFJALLI()
		{
			this.NBEHGOLCODJ();
		}

		// Token: 0x060067E7 RID: 26599 RVA: 0x001F35B9 File Offset: 0x001F17B9
		private void NLNAJMCBNDC()
		{
			base.GetComponent<Button>().onClick.RemoveAllListeners();
			base.GetComponent<Button>().onClick.AddListener(new UnityAction(this.IHECIOIDBJJ));
		}

		// Token: 0x060067E8 RID: 26600 RVA: 0x001F35E7 File Offset: 0x001F17E7
		private void DHNANELONED()
		{
			base.GetComponent<Button>().onClick.RemoveAllListeners();
			base.GetComponent<Button>().onClick.AddListener(new UnityAction(this.GECBGAHBNHD));
		}

		// Token: 0x060067E9 RID: 26601 RVA: 0x001F3615 File Offset: 0x001F1815
		private void IOCDGDOEMLK()
		{
			this.IMGELFMHHKP();
		}

		// Token: 0x060067EA RID: 26602 RVA: 0x001F3620 File Offset: 0x001F1820
		public void MICCMOOJLNM()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = true;
				hardInput.KNFDDKEBKJC(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 0)
			{
				hardInput.ResetBinding(this.keyName);
			}
			else if (this.buttonAction == 5)
			{
				hardInput.JONAFAINKKM();
			}
		}

		// Token: 0x060067EB RID: 26603 RVA: 0x001F368D File Offset: 0x001F188D
		private void LINDIEEOICB()
		{
			this.JIDAGGMGDPG();
		}

		// Token: 0x060067ED RID: 26605 RVA: 0x001F3698 File Offset: 0x001F1898
		public void LOELEBIHHFM()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = true;
				hardInput.KNFDDKEBKJC(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 0)
			{
				hardInput.ADDMOGHAPPA(this.keyName);
			}
			else if (this.buttonAction == 8)
			{
				hardInput.ResetAllBindings();
			}
		}

		// Token: 0x060067EE RID: 26606 RVA: 0x001F3708 File Offset: 0x001F1908
		public void CFLMELKPAHH()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = false;
				hardInput.OLHMLFIEIDO(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 1)
			{
				hardInput.ADDMOGHAPPA(this.keyName);
			}
			else if (this.buttonAction == 4)
			{
				hardInput.ResetAllBindings();
			}
		}

		// Token: 0x060067EF RID: 26607 RVA: 0x001F3775 File Offset: 0x001F1975
		private void GEGFJJBCHPE()
		{
			base.GetComponent<Button>().onClick.RemoveAllListeners();
			base.GetComponent<Button>().onClick.AddListener(new UnityAction(this.JHFJOFJALLI));
		}

		// Token: 0x060067F0 RID: 26608 RVA: 0x001F37A3 File Offset: 0x001F19A3
		private void GECBGAHBNHD()
		{
			this.PGMJMHHCFJG();
		}

		// Token: 0x060067F1 RID: 26609 RVA: 0x001F37AB File Offset: 0x001F19AB
		private void GLGOLEOAFOD()
		{
			base.GetComponent<Button>().onClick.RemoveAllListeners();
			base.GetComponent<Button>().onClick.AddListener(new UnityAction(this.AJBAAHEOIAC));
		}

		// Token: 0x060067F2 RID: 26610 RVA: 0x001F37D9 File Offset: 0x001F19D9
		private void ECGKFDLAMCK()
		{
			this.CFLMELKPAHH();
		}

		// Token: 0x060067F3 RID: 26611 RVA: 0x001F37E4 File Offset: 0x001F19E4
		public void AFDKBMOOCLG()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = false;
				hardInput.OLHMLFIEIDO(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 0)
			{
				hardInput.ResetBinding(this.keyName);
			}
			else if (this.buttonAction == 3)
			{
				hardInput.JONAFAINKKM();
			}
		}

		// Token: 0x060067F4 RID: 26612 RVA: 0x001F3854 File Offset: 0x001F1A54
		public void HEDNMPOPNOE()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = true;
				hardInput.OLHMLFIEIDO(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 1)
			{
				hardInput.ADDMOGHAPPA(this.keyName);
			}
			else if (this.buttonAction == 4)
			{
				hardInput.JONAFAINKKM();
			}
		}

		// Token: 0x060067F5 RID: 26613 RVA: 0x001F38C4 File Offset: 0x001F1AC4
		public void HCJOLALFDOI()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = false;
				hardInput.OLHMLFIEIDO(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 0)
			{
				hardInput.ResetBinding(this.keyName);
			}
			else if (this.buttonAction == 3)
			{
				hardInput.ResetAllBindings();
			}
		}

		// Token: 0x060067F6 RID: 26614 RVA: 0x001F3934 File Offset: 0x001F1B34
		private void DPMIABFMGCO()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.EPIFCBNFKNO(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "CameraFilterPack/Vision_Psycho";
				}
			}
		}

		// Token: 0x060067F7 RID: 26615 RVA: 0x001F399C File Offset: 0x001F1B9C
		private void PCABPJAANFH()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.GetKeyName(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "achievements.21.completed.";
				}
			}
		}

		// Token: 0x060067F8 RID: 26616 RVA: 0x001F3A01 File Offset: 0x001F1C01
		private void AJBAAHEOIAC()
		{
			this.MCAFPBIAAMM();
		}

		// Token: 0x060067F9 RID: 26617 RVA: 0x001F3A0C File Offset: 0x001F1C0C
		private void LIIEJAHOGFL()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.NFAMPNFLAEJ(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: ";
				}
			}
		}

		// Token: 0x060067FA RID: 26618 RVA: 0x001F3A71 File Offset: 0x001F1C71
		private void PIIMBOLGHOE()
		{
			base.GetComponent<Button>().onClick.RemoveAllListeners();
			base.GetComponent<Button>().onClick.AddListener(new UnityAction(this.OMNJGKABMOH));
		}

		// Token: 0x060067FB RID: 26619 RVA: 0x001F3AA0 File Offset: 0x001F1CA0
		private void DCJBGIFPNAN()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.GetKeyName(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "input";
				}
			}
		}

		// Token: 0x060067FC RID: 26620 RVA: 0x001F3B08 File Offset: 0x001F1D08
		public void NBEHGOLCODJ()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = true;
				hardInput.HardStartRebind(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 1)
			{
				hardInput.ResetBinding(this.keyName);
			}
			else if (this.buttonAction == 0)
			{
				hardInput.ResetAllBindings();
			}
		}

		// Token: 0x060067FD RID: 26621 RVA: 0x001F3B78 File Offset: 0x001F1D78
		private void DKNLIFAKIKL()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.NFAMPNFLAEJ(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "_Value2";
				}
			}
		}

		// Token: 0x060067FE RID: 26622 RVA: 0x001F3BE0 File Offset: 0x001F1DE0
		private void MINMKOCOLEP()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.EPIFCBNFKNO(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "SpawnObj";
				}
			}
		}

		// Token: 0x060067FF RID: 26623 RVA: 0x001F3C45 File Offset: 0x001F1E45
		private void EPCGHAAONLN()
		{
			base.GetComponent<Button>().onClick.RemoveAllListeners();
			base.GetComponent<Button>().onClick.AddListener(new UnityAction(this.JDJCJPKACGO));
		}

		// Token: 0x06006800 RID: 26624 RVA: 0x001F3C74 File Offset: 0x001F1E74
		private void NHOKMFGLIPN()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.GetKeyName(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "InventoryButton";
				}
			}
		}

		// Token: 0x06006801 RID: 26625 RVA: 0x001F3CD9 File Offset: 0x001F1ED9
		private void LPFIKGDJMJN()
		{
			this.AFDKBMOOCLG();
		}

		// Token: 0x06006802 RID: 26626 RVA: 0x001F3CE4 File Offset: 0x001F1EE4
		public void IDILCHCMOLE()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = false;
				hardInput.OLHMLFIEIDO(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 0)
			{
				hardInput.LDNIGNMHCOM(this.keyName);
			}
			else if (this.buttonAction == 7)
			{
				hardInput.JONAFAINKKM();
			}
		}

		// Token: 0x06006803 RID: 26627 RVA: 0x001F3D54 File Offset: 0x001F1F54
		public void GDFIEOPHMPP()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = false;
				hardInput.OLHMLFIEIDO(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 1)
			{
				hardInput.LDNIGNMHCOM(this.keyName);
			}
			else if (this.buttonAction == 8)
			{
				hardInput.ResetAllBindings();
			}
		}

		// Token: 0x06006804 RID: 26628 RVA: 0x001F3DC4 File Offset: 0x001F1FC4
		public void IODININLACN()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = false;
				hardInput.KNFDDKEBKJC(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 0)
			{
				hardInput.LDNIGNMHCOM(this.keyName);
			}
			else if (this.buttonAction == 1)
			{
				hardInput.ResetAllBindings();
			}
		}

		// Token: 0x06006805 RID: 26629 RVA: 0x001F3E34 File Offset: 0x001F2034
		private void CJFLPGBFBNL()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.GetKeyName(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "_MaxBlurRadius";
				}
			}
		}

		// Token: 0x06006806 RID: 26630 RVA: 0x001F37D9 File Offset: 0x001F19D9
		private void IHECIOIDBJJ()
		{
			this.CFLMELKPAHH();
		}

		// Token: 0x06006807 RID: 26631 RVA: 0x001F33E4 File Offset: 0x001F15E4
		private void FCLKOMNEGJD()
		{
			this.JMAAPCIBDNO();
		}

		// Token: 0x06006808 RID: 26632 RVA: 0x001F3E9C File Offset: 0x001F209C
		public void CPDHGFJJCGM()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = false;
				hardInput.KNFDDKEBKJC(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 1)
			{
				hardInput.ADDMOGHAPPA(this.keyName);
			}
			else if (this.buttonAction == 1)
			{
				hardInput.ResetAllBindings();
			}
		}

		// Token: 0x06006809 RID: 26633 RVA: 0x001F33E4 File Offset: 0x001F15E4
		private void OMNJGKABMOH()
		{
			this.JMAAPCIBDNO();
		}

		// Token: 0x0600680A RID: 26634 RVA: 0x001F3F09 File Offset: 0x001F2109
		private void LILCAENMADC()
		{
			this.FGCKJDMFBEO();
		}

		// Token: 0x0600680B RID: 26635 RVA: 0x001F3F14 File Offset: 0x001F2114
		public void MCAFPBIAAMM()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = true;
				hardInput.KNFDDKEBKJC(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 0)
			{
				hardInput.LDNIGNMHCOM(this.keyName);
			}
			else if (this.buttonAction == 6)
			{
				hardInput.JONAFAINKKM();
			}
		}

		// Token: 0x0600680C RID: 26636 RVA: 0x001F3F84 File Offset: 0x001F2184
		private void BCODHAOJLJL()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.NFAMPNFLAEJ(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "_Value7";
				}
			}
		}

		// Token: 0x0600680D RID: 26637 RVA: 0x001F3A71 File Offset: 0x001F1C71
		private void EIFCCFBJKOO()
		{
			base.GetComponent<Button>().onClick.RemoveAllListeners();
			base.GetComponent<Button>().onClick.AddListener(new UnityAction(this.OMNJGKABMOH));
		}

		// Token: 0x0600680E RID: 26638 RVA: 0x001F3FEC File Offset: 0x001F21EC
		public void NGNJAFAKHCJ()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = true;
				hardInput.HardStartRebind(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 0)
			{
				hardInput.ADDMOGHAPPA(this.keyName);
			}
			else if (this.buttonAction == 0)
			{
				hardInput.JONAFAINKKM();
			}
		}

		// Token: 0x0600680F RID: 26639 RVA: 0x001F405C File Offset: 0x001F225C
		private void LEMMMPHGOPD()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.EPIFCBNFKNO(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "Prints list of commands";
				}
			}
		}

		// Token: 0x06006810 RID: 26640 RVA: 0x001F3487 File Offset: 0x001F1687
		private void EBPAOCJEJGE()
		{
			base.GetComponent<Button>().onClick.RemoveAllListeners();
			base.GetComponent<Button>().onClick.AddListener(new UnityAction(this.MJOFHNEPNCH));
		}

		// Token: 0x06006811 RID: 26641 RVA: 0x001F40C4 File Offset: 0x001F22C4
		private void KLEHHODOCLD()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.GetKeyName(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "Set Arcs Speed";
				}
			}
		}

		// Token: 0x06006812 RID: 26642 RVA: 0x001F412C File Offset: 0x001F232C
		public void JMAAPCIBDNO()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = true;
				hardInput.HardStartRebind(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 1)
			{
				hardInput.LDNIGNMHCOM(this.keyName);
			}
			else if (this.buttonAction == 5)
			{
				hardInput.JONAFAINKKM();
			}
		}

		// Token: 0x06006813 RID: 26643 RVA: 0x001F4199 File Offset: 0x001F2399
		private void EPCAPPLPFED()
		{
			base.GetComponent<Button>().onClick.RemoveAllListeners();
			base.GetComponent<Button>().onClick.AddListener(new UnityAction(this.LINDIEEOICB));
		}

		// Token: 0x06006814 RID: 26644 RVA: 0x001F41C8 File Offset: 0x001F23C8
		private void OLFFIKHJIEO()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.NFAMPNFLAEJ(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "CameraFilterPack/FX_Psycho";
				}
			}
		}

		// Token: 0x06006815 RID: 26645 RVA: 0x001F4230 File Offset: 0x001F2430
		private void HBNHHPJNNIP()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.GetKeyName(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "hidden";
				}
			}
		}

		// Token: 0x06006816 RID: 26646 RVA: 0x001F3A71 File Offset: 0x001F1C71
		private void JNBMKLFJCEM()
		{
			base.GetComponent<Button>().onClick.RemoveAllListeners();
			base.GetComponent<Button>().onClick.AddListener(new UnityAction(this.OMNJGKABMOH));
		}

		// Token: 0x06006817 RID: 26647 RVA: 0x001F4298 File Offset: 0x001F2498
		public void FHJBHJGHPDK()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = false;
				hardInput.HardStartRebind(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 0)
			{
				hardInput.ResetBinding(this.keyName);
			}
			else if (this.buttonAction == 0)
			{
				hardInput.JONAFAINKKM();
			}
		}

		// Token: 0x06006818 RID: 26648 RVA: 0x001F4308 File Offset: 0x001F2508
		private void IEHKJPADFFM()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.EPIFCBNFKNO(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "Fade";
				}
			}
		}

		// Token: 0x06006819 RID: 26649 RVA: 0x001F4370 File Offset: 0x001F2570
		private void JLKEEOILNFI()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.GetKeyName(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "_TimeX";
				}
			}
		}

		// Token: 0x0600681A RID: 26650 RVA: 0x001F351D File Offset: 0x001F171D
		private void NEEIFNDHDOG()
		{
			base.GetComponent<Button>().onClick.RemoveAllListeners();
			base.GetComponent<Button>().onClick.AddListener(new UnityAction(this.MGPEEODMKND));
		}

		// Token: 0x0600681B RID: 26651 RVA: 0x001F3A71 File Offset: 0x001F1C71
		private void LJEFMGOBKGE()
		{
			base.GetComponent<Button>().onClick.RemoveAllListeners();
			base.GetComponent<Button>().onClick.AddListener(new UnityAction(this.OMNJGKABMOH));
		}

		// Token: 0x0600681C RID: 26652 RVA: 0x001F43D8 File Offset: 0x001F25D8
		private void NMHIDAOMOGO()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.GetKeyName(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "[Up-Left]";
				}
			}
		}

		// Token: 0x0600681D RID: 26653 RVA: 0x001F3C45 File Offset: 0x001F1E45
		private void BODPLDJLFCF()
		{
			base.GetComponent<Button>().onClick.RemoveAllListeners();
			base.GetComponent<Button>().onClick.AddListener(new UnityAction(this.JDJCJPKACGO));
		}

		// Token: 0x0600681E RID: 26654 RVA: 0x001F4440 File Offset: 0x001F2640
		private void OnGUI()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.GetKeyName(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "PRESS A KEY";
				}
			}
		}

		// Token: 0x0600681F RID: 26655 RVA: 0x001F44A8 File Offset: 0x001F26A8
		public void CFCAFKCAIAC()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = false;
				hardInput.OLHMLFIEIDO(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 0)
			{
				hardInput.LDNIGNMHCOM(this.keyName);
			}
			else if (this.buttonAction == 5)
			{
				hardInput.JONAFAINKKM();
			}
		}

		// Token: 0x06006820 RID: 26656 RVA: 0x001F3CD9 File Offset: 0x001F1ED9
		private void MBHBDHAOKDN()
		{
			this.AFDKBMOOCLG();
		}

		// Token: 0x06006821 RID: 26657 RVA: 0x001F4515 File Offset: 0x001F2715
		[CompilerGenerated]
		private void EODMHHCLPIH()
		{
			this.remapKey();
		}

		// Token: 0x06006822 RID: 26658 RVA: 0x001F4520 File Offset: 0x001F2720
		public void FGCKJDMFBEO()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = true;
				hardInput.OLHMLFIEIDO(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 1)
			{
				hardInput.ADDMOGHAPPA(this.keyName);
			}
			else if (this.buttonAction == 3)
			{
				hardInput.JONAFAINKKM();
			}
		}

		// Token: 0x06006823 RID: 26659 RVA: 0x001F4590 File Offset: 0x001F2790
		private void EAELMLKKFOL()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.NFAMPNFLAEJ(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = ") then the masterserver requests a disconnect!";
				}
			}
		}

		// Token: 0x06006824 RID: 26660 RVA: 0x001F45F8 File Offset: 0x001F27F8
		private void BLJJAFNPLKE()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.GetKeyName(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "_ScreenResolution";
				}
			}
		}

		// Token: 0x06006825 RID: 26661 RVA: 0x001F465D File Offset: 0x001F285D
		private void AJIKPEIGACI()
		{
			base.GetComponent<Button>().onClick.RemoveAllListeners();
			base.GetComponent<Button>().onClick.AddListener(new UnityAction(this.FLEOGEBIADI));
		}

		// Token: 0x06006826 RID: 26662 RVA: 0x001F468C File Offset: 0x001F288C
		private void LLLOCCNLCNL()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.GetKeyName(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "#activechallenges";
				}
			}
		}

		// Token: 0x06006827 RID: 26663 RVA: 0x001F46F1 File Offset: 0x001F28F1
		private void Awake()
		{
			base.GetComponent<Button>().onClick.RemoveAllListeners();
			base.GetComponent<Button>().onClick.AddListener(new UnityAction(this.EODMHHCLPIH));
		}

		// Token: 0x06006828 RID: 26664 RVA: 0x001F471F File Offset: 0x001F291F
		private void JDJCJPKACGO()
		{
			this.CFCAFKCAIAC();
		}

		// Token: 0x06006829 RID: 26665 RVA: 0x001F4728 File Offset: 0x001F2928
		public void AHLIGFGJPOG()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = true;
				hardInput.OLHMLFIEIDO(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 0)
			{
				hardInput.ResetBinding(this.keyName);
			}
			else if (this.buttonAction == 4)
			{
				hardInput.JONAFAINKKM();
			}
		}

		// Token: 0x0600682A RID: 26666 RVA: 0x001F4798 File Offset: 0x001F2998
		public void remapKey()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = true;
				hardInput.HardStartRebind(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 1)
			{
				hardInput.ResetBinding(this.keyName);
			}
			else if (this.buttonAction == 2)
			{
				hardInput.ResetAllBindings();
			}
		}

		// Token: 0x0600682B RID: 26667 RVA: 0x001F4805 File Offset: 0x001F2A05
		private void MJOFHNEPNCH()
		{
			this.NGNJAFAKHCJ();
		}

		// Token: 0x0600682C RID: 26668 RVA: 0x001F4810 File Offset: 0x001F2A10
		public void JIDAGGMGDPG()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = true;
				hardInput.KNFDDKEBKJC(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 0)
			{
				hardInput.ResetBinding(this.keyName);
			}
			else if (this.buttonAction == 8)
			{
				hardInput.ResetAllBindings();
			}
		}

		// Token: 0x0600682D RID: 26669 RVA: 0x001F4880 File Offset: 0x001F2A80
		public void HEJMJBFGNJL()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = true;
				hardInput.OLHMLFIEIDO(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 0)
			{
				hardInput.ADDMOGHAPPA(this.keyName);
			}
			else if (this.buttonAction == 0)
			{
				hardInput.JONAFAINKKM();
			}
		}

		// Token: 0x0600682E RID: 26670 RVA: 0x001F48F0 File Offset: 0x001F2AF0
		public void PGMJMHHCFJG()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = true;
				hardInput.KNFDDKEBKJC(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 0)
			{
				hardInput.LDNIGNMHCOM(this.keyName);
			}
			else if (this.buttonAction == 7)
			{
				hardInput.ResetAllBindings();
			}
		}

		// Token: 0x0600682F RID: 26671 RVA: 0x001F4960 File Offset: 0x001F2B60
		public void MBHNJOMAEJO()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = true;
				hardInput.HardStartRebind(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 1)
			{
				hardInput.ADDMOGHAPPA(this.keyName);
			}
			else if (this.buttonAction == 5)
			{
				hardInput.JONAFAINKKM();
			}
		}

		// Token: 0x06006830 RID: 26672 RVA: 0x001F49D0 File Offset: 0x001F2BD0
		public void IMGELFMHHKP()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = true;
				hardInput.HardStartRebind(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 0)
			{
				hardInput.ADDMOGHAPPA(this.keyName);
			}
			else if (this.buttonAction == 0)
			{
				hardInput.JONAFAINKKM();
			}
		}

		// Token: 0x06006831 RID: 26673 RVA: 0x001F3775 File Offset: 0x001F1975
		private void OJACCGOHBGH()
		{
			base.GetComponent<Button>().onClick.RemoveAllListeners();
			base.GetComponent<Button>().onClick.AddListener(new UnityAction(this.JHFJOFJALLI));
		}

		// Token: 0x06006832 RID: 26674 RVA: 0x001F4A40 File Offset: 0x001F2C40
		private void PFGBMOOHMMJ()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.GetKeyName(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "_Value4";
				}
			}
		}

		// Token: 0x06006833 RID: 26675 RVA: 0x001F4AA5 File Offset: 0x001F2CA5
		private void IOIJHBANOKF()
		{
			this.HEJMJBFGNJL();
		}

		// Token: 0x06006834 RID: 26676 RVA: 0x001F4199 File Offset: 0x001F2399
		private void FMAFBLKAJDF()
		{
			base.GetComponent<Button>().onClick.RemoveAllListeners();
			base.GetComponent<Button>().onClick.AddListener(new UnityAction(this.LINDIEEOICB));
		}

		// Token: 0x06006835 RID: 26677 RVA: 0x001F4AB0 File Offset: 0x001F2CB0
		private void HKOJIMNBFPN()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.NFAMPNFLAEJ(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "_OcclusionTexture";
				}
			}
		}

		// Token: 0x06006836 RID: 26678 RVA: 0x001F4B18 File Offset: 0x001F2D18
		public void EPDCGLKEHKK()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = false;
				hardInput.KNFDDKEBKJC(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 1)
			{
				hardInput.ADDMOGHAPPA(this.keyName);
			}
			else if (this.buttonAction == 7)
			{
				hardInput.ResetAllBindings();
			}
		}

		// Token: 0x06006837 RID: 26679 RVA: 0x001F4B88 File Offset: 0x001F2D88
		private void GAMPNFOIFHF()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.EPIFCBNFKNO(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = ":";
				}
			}
		}

		// Token: 0x06006838 RID: 26680 RVA: 0x001F4BF0 File Offset: 0x001F2DF0
		private void PNEKMLABFCE()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.GetKeyName(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "_Value";
				}
			}
		}

		// Token: 0x06006839 RID: 26681 RVA: 0x001F351D File Offset: 0x001F171D
		private void DAHIMKKFNPH()
		{
			base.GetComponent<Button>().onClick.RemoveAllListeners();
			base.GetComponent<Button>().onClick.AddListener(new UnityAction(this.MGPEEODMKND));
		}

		// Token: 0x0600683A RID: 26682 RVA: 0x001F4C55 File Offset: 0x001F2E55
		private void HCCMANDFEPL()
		{
			base.GetComponent<Button>().onClick.RemoveAllListeners();
			base.GetComponent<Button>().onClick.AddListener(new UnityAction(this.FCLKOMNEGJD));
		}

		// Token: 0x0600683B RID: 26683 RVA: 0x001F4C84 File Offset: 0x001F2E84
		private void AJCFIBPGAME()
		{
			if (this.displayText != null && this.buttonAction == 0)
			{
				if (!this.beingBound)
				{
					this.displayText.text = hardInput.EPIFCBNFKNO(this.keyName, this.useSecondary);
				}
				else
				{
					this.displayText.text = "CameraFilterPack/Blend2Camera_ColorBurn";
				}
			}
		}

		// Token: 0x0600683C RID: 26684 RVA: 0x001F4CEC File Offset: 0x001F2EEC
		public void KPDGGDOLEII()
		{
			if (this.buttonAction == 0)
			{
				this.beingBound = false;
				hardInput.HardStartRebind(this.keyName, this.useSecondary, base.gameObject.GetComponent<hardInputUI>());
			}
			else if (this.buttonAction == 0)
			{
				hardInput.ADDMOGHAPPA(this.keyName);
			}
			else if (this.buttonAction == 4)
			{
				hardInput.ResetAllBindings();
			}
		}

		// Token: 0x04000AAA RID: 2730
		public Text displayText;

		// Token: 0x04000AAB RID: 2731
		public string keyName;

		// Token: 0x04000AAC RID: 2732
		public bool useSecondary;

		// Token: 0x04000AAD RID: 2733
		[HideInInspector]
		public bool beingBound;

		// Token: 0x04000AAE RID: 2734
		public int buttonAction;
	}
}
