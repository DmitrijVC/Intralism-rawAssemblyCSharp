using System;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002D4 RID: 724
	[AddComponentMenu("UI/Extensions/UI Selectable Extension")]
	[RequireComponent(typeof(Selectable))]
	public class UISelectableExtension : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
	{
		// Token: 0x0600AB58 RID: 43864 RVA: 0x003F7EC5 File Offset: 0x003F60C5
		private void MEHAENOPEMG(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonPress != null)
			{
				this.OnButtonPress.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = false;
			this.PMNGOAFCBDI = OLIIPKODDIN;
		}

		// Token: 0x0600AB59 RID: 43865 RVA: 0x003F7EF1 File Offset: 0x003F60F1
		private void OnDisable()
		{
			this.MFLMFGEPBLA = false;
		}

		// Token: 0x0600AB5A RID: 43866 RVA: 0x003F7EF1 File Offset: 0x003F60F1
		private void ODAIMOJLJOF()
		{
			this.MFLMFGEPBLA = false;
		}

		// Token: 0x0600AB5B RID: 43867 RVA: 0x0002523B File Offset: 0x0002343B
		public void MPPBAFFNNHB()
		{
		}

		// Token: 0x0600AB5C RID: 43868 RVA: 0x003F7EF1 File Offset: 0x003F60F1
		private void IFJDKDFLGBG()
		{
			this.MFLMFGEPBLA = false;
		}

		// Token: 0x0600AB5D RID: 43869 RVA: 0x0002523B File Offset: 0x0002343B
		public void KHGMIPGDIBJ()
		{
		}

		// Token: 0x0600AB5E RID: 43870 RVA: 0x003F7EFA File Offset: 0x003F60FA
		void IPointerUpHandler.OnPointerUp(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonRelease != null)
			{
				this.OnButtonRelease.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = false;
			this.PMNGOAFCBDI = null;
		}

		// Token: 0x0600AB5F RID: 43871 RVA: 0x003F7EC5 File Offset: 0x003F60C5
		private void ODJALJPFKDC(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonPress != null)
			{
				this.OnButtonPress.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = false;
			this.PMNGOAFCBDI = OLIIPKODDIN;
		}

		// Token: 0x0600AB60 RID: 43872 RVA: 0x0002523B File Offset: 0x0002343B
		public void IOOCOLHOBEA()
		{
		}

		// Token: 0x0600AB61 RID: 43873 RVA: 0x0002523B File Offset: 0x0002343B
		public void TestPressed()
		{
		}

		// Token: 0x0600AB62 RID: 43874 RVA: 0x0002523B File Offset: 0x0002343B
		public void TestHold()
		{
		}

		// Token: 0x0600AB63 RID: 43875 RVA: 0x003F7F26 File Offset: 0x003F6126
		private void FGBDGGCBFLP()
		{
			this.MFLMFGEPBLA = true;
		}

		// Token: 0x0600AB64 RID: 43876 RVA: 0x0002523B File Offset: 0x0002343B
		public void DIBNNLBPEOK()
		{
		}

		// Token: 0x0600AB65 RID: 43877 RVA: 0x003F7F2F File Offset: 0x003F612F
		private void CPDHPLPAFPA(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonPress != null)
			{
				this.OnButtonPress.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = true;
			this.PMNGOAFCBDI = OLIIPKODDIN;
		}

		// Token: 0x0600AB66 RID: 43878 RVA: 0x003F7F26 File Offset: 0x003F6126
		private void BNEJMABFKJE()
		{
			this.MFLMFGEPBLA = true;
		}

		// Token: 0x0600AB67 RID: 43879 RVA: 0x0002523B File Offset: 0x0002343B
		public void OPEKNMONEJA()
		{
		}

		// Token: 0x0600AB68 RID: 43880 RVA: 0x0002523B File Offset: 0x0002343B
		public void DCBJHLBIMEC()
		{
		}

		// Token: 0x0600AB69 RID: 43881 RVA: 0x0002523B File Offset: 0x0002343B
		public void BPIJDIDICAF()
		{
		}

		// Token: 0x0600AB6A RID: 43882 RVA: 0x0002523B File Offset: 0x0002343B
		public void JDCACKHNIAG()
		{
		}

		// Token: 0x0600AB6B RID: 43883 RVA: 0x003F7EC5 File Offset: 0x003F60C5
		private void IFJBICEKNBN(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonPress != null)
			{
				this.OnButtonPress.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = false;
			this.PMNGOAFCBDI = OLIIPKODDIN;
		}

		// Token: 0x0600AB6C RID: 43884 RVA: 0x0002523B File Offset: 0x0002343B
		public void FCNOMALKEOL()
		{
		}

		// Token: 0x0600AB6D RID: 43885 RVA: 0x003F7F5B File Offset: 0x003F615B
		private void OFFAIODKOHM(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonRelease != null)
			{
				this.OnButtonRelease.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = true;
			this.PMNGOAFCBDI = null;
		}

		// Token: 0x0600AB6E RID: 43886 RVA: 0x003F7EFA File Offset: 0x003F60FA
		private void DKHGHMFOJFI(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonRelease != null)
			{
				this.OnButtonRelease.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = false;
			this.PMNGOAFCBDI = null;
		}

		// Token: 0x0600AB6F RID: 43887 RVA: 0x003F7F87 File Offset: 0x003F6187
		private void BMODOIJGIOO()
		{
			if (!this.MFLMFGEPBLA)
			{
				return;
			}
			if (this.OnButtonHeld != null)
			{
				this.OnButtonHeld.Invoke(this.PMNGOAFCBDI.button);
			}
		}

		// Token: 0x0600AB70 RID: 43888 RVA: 0x0002523B File Offset: 0x0002343B
		public void BFLPOHAGIEN()
		{
		}

		// Token: 0x0600AB71 RID: 43889 RVA: 0x0002523B File Offset: 0x0002343B
		public void MICPCJBEBIB()
		{
		}

		// Token: 0x0600AB72 RID: 43890 RVA: 0x003F7EFA File Offset: 0x003F60FA
		private void HPEFHPDEAOP(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonRelease != null)
			{
				this.OnButtonRelease.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = false;
			this.PMNGOAFCBDI = null;
		}

		// Token: 0x0600AB73 RID: 43891 RVA: 0x003F7F26 File Offset: 0x003F6126
		private void HONBLGFDMLL()
		{
			this.MFLMFGEPBLA = true;
		}

		// Token: 0x0600AB74 RID: 43892 RVA: 0x003F7F2F File Offset: 0x003F612F
		private void OOPIBBEGMAE(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonPress != null)
			{
				this.OnButtonPress.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = true;
			this.PMNGOAFCBDI = OLIIPKODDIN;
		}

		// Token: 0x0600AB75 RID: 43893 RVA: 0x0002523B File Offset: 0x0002343B
		public void TestClicked()
		{
		}

		// Token: 0x0600AB76 RID: 43894 RVA: 0x0002523B File Offset: 0x0002343B
		public void LILMOKMILEF()
		{
		}

		// Token: 0x0600AB77 RID: 43895 RVA: 0x003F7F87 File Offset: 0x003F6187
		private void DGCGGKMNPLD()
		{
			if (!this.MFLMFGEPBLA)
			{
				return;
			}
			if (this.OnButtonHeld != null)
			{
				this.OnButtonHeld.Invoke(this.PMNGOAFCBDI.button);
			}
		}

		// Token: 0x0600AB78 RID: 43896 RVA: 0x003F7EF1 File Offset: 0x003F60F1
		private void IFIHBNJKEKD()
		{
			this.MFLMFGEPBLA = false;
		}

		// Token: 0x0600AB79 RID: 43897 RVA: 0x003F7EFA File Offset: 0x003F60FA
		private void COKPNDCNMKM(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonRelease != null)
			{
				this.OnButtonRelease.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = false;
			this.PMNGOAFCBDI = null;
		}

		// Token: 0x0600AB7A RID: 43898 RVA: 0x0002523B File Offset: 0x0002343B
		public void GPALJAPADEO()
		{
		}

		// Token: 0x0600AB7C RID: 43900 RVA: 0x0002523B File Offset: 0x0002343B
		public void DBANBGOKKHA()
		{
		}

		// Token: 0x0600AB7D RID: 43901 RVA: 0x003F7EC5 File Offset: 0x003F60C5
		private void ONGICKNMCJH(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonPress != null)
			{
				this.OnButtonPress.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = false;
			this.PMNGOAFCBDI = OLIIPKODDIN;
		}

		// Token: 0x0600AB7E RID: 43902 RVA: 0x0002523B File Offset: 0x0002343B
		public void TestReleased()
		{
		}

		// Token: 0x0600AB7F RID: 43903 RVA: 0x0002523B File Offset: 0x0002343B
		public void NGJNHONNBHI()
		{
		}

		// Token: 0x0600AB80 RID: 43904 RVA: 0x003F7EC5 File Offset: 0x003F60C5
		private void OFOFDBPOOCJ(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonPress != null)
			{
				this.OnButtonPress.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = false;
			this.PMNGOAFCBDI = OLIIPKODDIN;
		}

		// Token: 0x0600AB81 RID: 43905 RVA: 0x0002523B File Offset: 0x0002343B
		public void AMPFNDEKDHI()
		{
		}

		// Token: 0x0600AB82 RID: 43906 RVA: 0x0002523B File Offset: 0x0002343B
		public void GBFNOOICKDN()
		{
		}

		// Token: 0x0600AB83 RID: 43907 RVA: 0x0002523B File Offset: 0x0002343B
		public void EIKBCKKLPGA()
		{
		}

		// Token: 0x0600AB84 RID: 43908 RVA: 0x003F7F26 File Offset: 0x003F6126
		private void IABLKKAALGI()
		{
			this.MFLMFGEPBLA = true;
		}

		// Token: 0x0600AB85 RID: 43909 RVA: 0x0002523B File Offset: 0x0002343B
		public void FMKNOPJOLNH()
		{
		}

		// Token: 0x0600AB86 RID: 43910 RVA: 0x003F7EFA File Offset: 0x003F60FA
		private void AMPOABJHBEJ(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonRelease != null)
			{
				this.OnButtonRelease.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = false;
			this.PMNGOAFCBDI = null;
		}

		// Token: 0x0600AB87 RID: 43911 RVA: 0x0002523B File Offset: 0x0002343B
		public void EIBAIANGOOO()
		{
		}

		// Token: 0x0600AB88 RID: 43912 RVA: 0x0002523B File Offset: 0x0002343B
		public void MPBBJKJBKDL()
		{
		}

		// Token: 0x0600AB89 RID: 43913 RVA: 0x003F7F5B File Offset: 0x003F615B
		private void IHDPIOBAPAD(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonRelease != null)
			{
				this.OnButtonRelease.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = true;
			this.PMNGOAFCBDI = null;
		}

		// Token: 0x0600AB8A RID: 43914 RVA: 0x003F7F87 File Offset: 0x003F6187
		private void IKIDIJLIGOH()
		{
			if (!this.MFLMFGEPBLA)
			{
				return;
			}
			if (this.OnButtonHeld != null)
			{
				this.OnButtonHeld.Invoke(this.PMNGOAFCBDI.button);
			}
		}

		// Token: 0x0600AB8B RID: 43915 RVA: 0x0002523B File Offset: 0x0002343B
		public void EBPBLANHJIC()
		{
		}

		// Token: 0x0600AB8C RID: 43916 RVA: 0x003F7EFA File Offset: 0x003F60FA
		private void EHFHDACIKCL(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonRelease != null)
			{
				this.OnButtonRelease.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = false;
			this.PMNGOAFCBDI = null;
		}

		// Token: 0x0600AB8D RID: 43917 RVA: 0x0002523B File Offset: 0x0002343B
		public void BCBPPGDCLMO()
		{
		}

		// Token: 0x0600AB8E RID: 43918 RVA: 0x003F7F87 File Offset: 0x003F6187
		private void LPMINJJPDCH()
		{
			if (!this.MFLMFGEPBLA)
			{
				return;
			}
			if (this.OnButtonHeld != null)
			{
				this.OnButtonHeld.Invoke(this.PMNGOAFCBDI.button);
			}
		}

		// Token: 0x0600AB8F RID: 43919 RVA: 0x003F7F87 File Offset: 0x003F6187
		private void LEAHIBJDMBI()
		{
			if (!this.MFLMFGEPBLA)
			{
				return;
			}
			if (this.OnButtonHeld != null)
			{
				this.OnButtonHeld.Invoke(this.PMNGOAFCBDI.button);
			}
		}

		// Token: 0x0600AB90 RID: 43920 RVA: 0x003F7F2F File Offset: 0x003F612F
		private void PDKEHGJCBHG(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonPress != null)
			{
				this.OnButtonPress.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = true;
			this.PMNGOAFCBDI = OLIIPKODDIN;
		}

		// Token: 0x0600AB91 RID: 43921 RVA: 0x0002523B File Offset: 0x0002343B
		public void IGHFMDECPAK()
		{
		}

		// Token: 0x0600AB92 RID: 43922 RVA: 0x0002523B File Offset: 0x0002343B
		public void AGLCOIBGLBC()
		{
		}

		// Token: 0x0600AB93 RID: 43923 RVA: 0x0002523B File Offset: 0x0002343B
		public void NBKDJOAPDDN()
		{
		}

		// Token: 0x0600AB94 RID: 43924 RVA: 0x003F7EFA File Offset: 0x003F60FA
		private void HCHPBCCGCHJ(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonRelease != null)
			{
				this.OnButtonRelease.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = false;
			this.PMNGOAFCBDI = null;
		}

		// Token: 0x0600AB95 RID: 43925 RVA: 0x003F7F26 File Offset: 0x003F6126
		private void FDMAEPOHDMK()
		{
			this.MFLMFGEPBLA = true;
		}

		// Token: 0x0600AB96 RID: 43926 RVA: 0x003F7F5B File Offset: 0x003F615B
		private void ABEFAABNHDB(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonRelease != null)
			{
				this.OnButtonRelease.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = true;
			this.PMNGOAFCBDI = null;
		}

		// Token: 0x0600AB97 RID: 43927 RVA: 0x003F7F87 File Offset: 0x003F6187
		private void HDDECCMEJKA()
		{
			if (!this.MFLMFGEPBLA)
			{
				return;
			}
			if (this.OnButtonHeld != null)
			{
				this.OnButtonHeld.Invoke(this.PMNGOAFCBDI.button);
			}
		}

		// Token: 0x0600AB98 RID: 43928 RVA: 0x003F7F87 File Offset: 0x003F6187
		private void HIKKPDACJGI()
		{
			if (!this.MFLMFGEPBLA)
			{
				return;
			}
			if (this.OnButtonHeld != null)
			{
				this.OnButtonHeld.Invoke(this.PMNGOAFCBDI.button);
			}
		}

		// Token: 0x0600AB99 RID: 43929 RVA: 0x0002523B File Offset: 0x0002343B
		public void DMGGBOCJCGF()
		{
		}

		// Token: 0x0600AB9A RID: 43930 RVA: 0x003F7F2F File Offset: 0x003F612F
		private void PHBMLFKPMGN(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonPress != null)
			{
				this.OnButtonPress.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = true;
			this.PMNGOAFCBDI = OLIIPKODDIN;
		}

		// Token: 0x0600AB9B RID: 43931 RVA: 0x003F7F87 File Offset: 0x003F6187
		private void BGFJOEPFOPM()
		{
			if (!this.MFLMFGEPBLA)
			{
				return;
			}
			if (this.OnButtonHeld != null)
			{
				this.OnButtonHeld.Invoke(this.PMNGOAFCBDI.button);
			}
		}

		// Token: 0x0600AB9C RID: 43932 RVA: 0x0002523B File Offset: 0x0002343B
		public void EKDINGHHGGB()
		{
		}

		// Token: 0x0600AB9D RID: 43933 RVA: 0x003F7EF1 File Offset: 0x003F60F1
		private void GJLKJAOBPJD()
		{
			this.MFLMFGEPBLA = false;
		}

		// Token: 0x0600AB9E RID: 43934 RVA: 0x0002523B File Offset: 0x0002343B
		public void KHIFFJGBBCG()
		{
		}

		// Token: 0x0600AB9F RID: 43935 RVA: 0x003F7F5B File Offset: 0x003F615B
		private void KIKBGGHPMJH(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonRelease != null)
			{
				this.OnButtonRelease.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = true;
			this.PMNGOAFCBDI = null;
		}

		// Token: 0x0600ABA0 RID: 43936 RVA: 0x003F7F87 File Offset: 0x003F6187
		private void LCDJFJIBADI()
		{
			if (!this.MFLMFGEPBLA)
			{
				return;
			}
			if (this.OnButtonHeld != null)
			{
				this.OnButtonHeld.Invoke(this.PMNGOAFCBDI.button);
			}
		}

		// Token: 0x0600ABA1 RID: 43937 RVA: 0x003F7F2F File Offset: 0x003F612F
		void IPointerDownHandler.OnPointerDown(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonPress != null)
			{
				this.OnButtonPress.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = true;
			this.PMNGOAFCBDI = OLIIPKODDIN;
		}

		// Token: 0x0600ABA2 RID: 43938 RVA: 0x003F7EF1 File Offset: 0x003F60F1
		private void PLBOFEPBPKC()
		{
			this.MFLMFGEPBLA = false;
		}

		// Token: 0x0600ABA3 RID: 43939 RVA: 0x003F7F26 File Offset: 0x003F6126
		private void NNPBKKBFDHH()
		{
			this.MFLMFGEPBLA = true;
		}

		// Token: 0x0600ABA4 RID: 43940 RVA: 0x003F7F5B File Offset: 0x003F615B
		private void DHDPOCFGMAI(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonRelease != null)
			{
				this.OnButtonRelease.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = true;
			this.PMNGOAFCBDI = null;
		}

		// Token: 0x0600ABA5 RID: 43941 RVA: 0x0002523B File Offset: 0x0002343B
		public void CPDOJDLKNCH()
		{
		}

		// Token: 0x0600ABA6 RID: 43942 RVA: 0x0002523B File Offset: 0x0002343B
		public void NDLDMILJHNB()
		{
		}

		// Token: 0x0600ABA7 RID: 43943 RVA: 0x003F7F2F File Offset: 0x003F612F
		private void EMKMCEPOGPO(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonPress != null)
			{
				this.OnButtonPress.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = true;
			this.PMNGOAFCBDI = OLIIPKODDIN;
		}

		// Token: 0x0600ABA8 RID: 43944 RVA: 0x0002523B File Offset: 0x0002343B
		public void ALGKHLNGECF()
		{
		}

		// Token: 0x0600ABA9 RID: 43945 RVA: 0x003F7EF1 File Offset: 0x003F60F1
		private void JHLGHODFJOO()
		{
			this.MFLMFGEPBLA = false;
		}

		// Token: 0x0600ABAA RID: 43946 RVA: 0x003F7F87 File Offset: 0x003F6187
		private void JHPOIOELNCG()
		{
			if (!this.MFLMFGEPBLA)
			{
				return;
			}
			if (this.OnButtonHeld != null)
			{
				this.OnButtonHeld.Invoke(this.PMNGOAFCBDI.button);
			}
		}

		// Token: 0x0600ABAB RID: 43947 RVA: 0x003F7F87 File Offset: 0x003F6187
		private void FBMDHDBELEK()
		{
			if (!this.MFLMFGEPBLA)
			{
				return;
			}
			if (this.OnButtonHeld != null)
			{
				this.OnButtonHeld.Invoke(this.PMNGOAFCBDI.button);
			}
		}

		// Token: 0x0600ABAC RID: 43948 RVA: 0x003F7EFA File Offset: 0x003F60FA
		private void AHIMENLHLEM(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonRelease != null)
			{
				this.OnButtonRelease.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = false;
			this.PMNGOAFCBDI = null;
		}

		// Token: 0x0600ABAD RID: 43949 RVA: 0x003F7F5B File Offset: 0x003F615B
		private void AFDNIPGIPCF(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonRelease != null)
			{
				this.OnButtonRelease.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = true;
			this.PMNGOAFCBDI = null;
		}

		// Token: 0x0600ABAE RID: 43950 RVA: 0x0002523B File Offset: 0x0002343B
		public void HDDAKKNOMEB()
		{
		}

		// Token: 0x0600ABAF RID: 43951 RVA: 0x003F7F5B File Offset: 0x003F615B
		private void KIJGJBKEHCK(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonRelease != null)
			{
				this.OnButtonRelease.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = true;
			this.PMNGOAFCBDI = null;
		}

		// Token: 0x0600ABB0 RID: 43952 RVA: 0x003F7F87 File Offset: 0x003F6187
		private void Update()
		{
			if (!this.MFLMFGEPBLA)
			{
				return;
			}
			if (this.OnButtonHeld != null)
			{
				this.OnButtonHeld.Invoke(this.PMNGOAFCBDI.button);
			}
		}

		// Token: 0x0600ABB1 RID: 43953 RVA: 0x003F7F87 File Offset: 0x003F6187
		private void MECJHOJPODB()
		{
			if (!this.MFLMFGEPBLA)
			{
				return;
			}
			if (this.OnButtonHeld != null)
			{
				this.OnButtonHeld.Invoke(this.PMNGOAFCBDI.button);
			}
		}

		// Token: 0x0600ABB2 RID: 43954 RVA: 0x0002523B File Offset: 0x0002343B
		public void JDEMHBEMLDI()
		{
		}

		// Token: 0x0600ABB3 RID: 43955 RVA: 0x003F7F87 File Offset: 0x003F6187
		private void LCJHDLKJEOM()
		{
			if (!this.MFLMFGEPBLA)
			{
				return;
			}
			if (this.OnButtonHeld != null)
			{
				this.OnButtonHeld.Invoke(this.PMNGOAFCBDI.button);
			}
		}

		// Token: 0x0600ABB4 RID: 43956 RVA: 0x003F7F2F File Offset: 0x003F612F
		private void BPHGKJEDNNI(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonPress != null)
			{
				this.OnButtonPress.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = true;
			this.PMNGOAFCBDI = OLIIPKODDIN;
		}

		// Token: 0x0600ABB5 RID: 43957 RVA: 0x0002523B File Offset: 0x0002343B
		public void FGECCBIMBFK()
		{
		}

		// Token: 0x0600ABB6 RID: 43958 RVA: 0x003F7F2F File Offset: 0x003F612F
		private void HDAKEIGIHOI(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonPress != null)
			{
				this.OnButtonPress.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = true;
			this.PMNGOAFCBDI = OLIIPKODDIN;
		}

		// Token: 0x0600ABB7 RID: 43959 RVA: 0x003F7EFA File Offset: 0x003F60FA
		private void OPGFOOELDNP(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonRelease != null)
			{
				this.OnButtonRelease.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = false;
			this.PMNGOAFCBDI = null;
		}

		// Token: 0x0600ABB8 RID: 43960 RVA: 0x0002523B File Offset: 0x0002343B
		public void JHMMEOBPGMO()
		{
		}

		// Token: 0x0600ABB9 RID: 43961 RVA: 0x003F7EC5 File Offset: 0x003F60C5
		private void EAFIHAMBNFP(PointerEventData OLIIPKODDIN)
		{
			if (this.OnButtonPress != null)
			{
				this.OnButtonPress.Invoke(OLIIPKODDIN.button);
			}
			this.MFLMFGEPBLA = false;
			this.PMNGOAFCBDI = OLIIPKODDIN;
		}

		// Token: 0x0600ABBA RID: 43962 RVA: 0x0002523B File Offset: 0x0002343B
		public void IMIMFGKPBDK()
		{
		}

		// Token: 0x040012FF RID: 4863
		[Tooltip("Event that fires when a button is initially pressed down")]
		public UISelectableExtension.UIButtonEvent OnButtonPress;

		// Token: 0x04001300 RID: 4864
		[Tooltip("Event that fires when a button is released")]
		public UISelectableExtension.UIButtonEvent OnButtonRelease;

		// Token: 0x04001301 RID: 4865
		[Tooltip("Event that continually fires while a button is held down")]
		public UISelectableExtension.UIButtonEvent OnButtonHeld;

		// Token: 0x04001302 RID: 4866
		private bool MFLMFGEPBLA;

		// Token: 0x04001303 RID: 4867
		private PointerEventData PMNGOAFCBDI;

		// Token: 0x020002D5 RID: 725
		[Serializable]
		public class UIButtonEvent : UnityEvent<PointerEventData.InputButton>
		{
		}
	}
}
