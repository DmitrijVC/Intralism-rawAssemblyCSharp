using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityStandardAssets.CrossPlatformInput
{
	// Token: 0x02000181 RID: 385
	public class AxisTouchButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
	{
		// Token: 0x060071C9 RID: 29129 RVA: 0x002373EC File Offset: 0x002355EC
		public void INKFELLKDFO(PointerEventData NOJGGCLPPAM)
		{
			if (this.DHFJLKOGPPP == null)
			{
				this.PFEBGJIJNDI();
			}
			this.AJLPECOCNDB.FOMNCPKKCFN(Mathf.MoveTowards(this.AJLPECOCNDB.NPHNIDDOGDI(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x060071CA RID: 29130 RVA: 0x0023743D File Offset: 0x0023563D
		private void PHJLHCMCCKE()
		{
			this.AJLPECOCNDB.HPFNAMAOKLC();
		}

		// Token: 0x060071CB RID: 29131 RVA: 0x0023744C File Offset: 0x0023564C
		private void EMAMCDFBGOA()
		{
			if (!CrossPlatformInputManager.AxisExists(this.axisName))
			{
				this.AJLPECOCNDB = new CrossPlatformInputManager.VirtualAxis(this.axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.AJLPECOCNDB);
			}
			else
			{
				this.AJLPECOCNDB = CrossPlatformInputManager.VirtualAxisReference(this.axisName);
			}
			this.FNBOJDLNAEM();
		}

		// Token: 0x060071CC RID: 29132 RVA: 0x002374A4 File Offset: 0x002356A4
		public void MKFGJGKNDIB(PointerEventData NOJGGCLPPAM)
		{
			if (this.DHFJLKOGPPP == null)
			{
				this.COOKNCDHPBI();
			}
			this.AJLPECOCNDB.NKLIHNJCHOG(Mathf.MoveTowards(this.AJLPECOCNDB.MOMIHHIMFCE(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x060071CD RID: 29133 RVA: 0x002374F8 File Offset: 0x002356F8
		private void KDBGDNBIGEI()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 0; i < array.Length; i += 0)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.DHFJLKOGPPP = array[i];
					}
				}
			}
		}

		// Token: 0x060071CE RID: 29134 RVA: 0x00237564 File Offset: 0x00235764
		public void MHDFMCHNHOJ(PointerEventData NOJGGCLPPAM)
		{
			if (this.DHFJLKOGPPP == null)
			{
				this.PFEBGJIJNDI();
			}
			this.AJLPECOCNDB.FOMNCPKKCFN(Mathf.MoveTowards(this.AJLPECOCNDB.GetValue, this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x060071CF RID: 29135 RVA: 0x002375B5 File Offset: 0x002357B5
		public void BDBAMIJLAKD(PointerEventData NOJGGCLPPAM)
		{
			this.AJLPECOCNDB.JNBPKNNBMDI(Mathf.MoveTowards(this.AJLPECOCNDB.ADGPGPJICDG(), 799f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x060071D0 RID: 29136 RVA: 0x002375E4 File Offset: 0x002357E4
		private void FAGCIBNGJAB()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.DHFJLKOGPPP = array[i];
					}
				}
			}
		}

		// Token: 0x060071D1 RID: 29137 RVA: 0x00237650 File Offset: 0x00235850
		private void OnEnable()
		{
			if (!CrossPlatformInputManager.AxisExists(this.axisName))
			{
				this.AJLPECOCNDB = new CrossPlatformInputManager.VirtualAxis(this.axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.AJLPECOCNDB);
			}
			else
			{
				this.AJLPECOCNDB = CrossPlatformInputManager.VirtualAxisReference(this.axisName);
			}
			this.GBMHGIHDCNP();
		}

		// Token: 0x060071D2 RID: 29138 RVA: 0x002376A8 File Offset: 0x002358A8
		private void LLJAFPEKNDO()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 1; i < array.Length; i += 0)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.DHFJLKOGPPP = array[i];
					}
				}
			}
		}

		// Token: 0x060071D3 RID: 29139 RVA: 0x00237714 File Offset: 0x00235914
		public void OnPointerDown(PointerEventData NOJGGCLPPAM)
		{
			if (this.DHFJLKOGPPP == null)
			{
				this.GBMHGIHDCNP();
			}
			this.AJLPECOCNDB.Update(Mathf.MoveTowards(this.AJLPECOCNDB.GetValue, this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x060071D4 RID: 29140 RVA: 0x00237765 File Offset: 0x00235965
		private void GPHPJIDGEPI()
		{
			this.AJLPECOCNDB.Remove();
		}

		// Token: 0x060071D5 RID: 29141 RVA: 0x00237772 File Offset: 0x00235972
		public void KFGAGDILKGH(PointerEventData NOJGGCLPPAM)
		{
			this.AJLPECOCNDB.BGFJOEPFOPM(Mathf.MoveTowards(this.AJLPECOCNDB.ADGPGPJICDG(), 1055f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x060071D6 RID: 29142 RVA: 0x002377A0 File Offset: 0x002359A0
		private void PFEBGJIJNDI()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 1; i < array.Length; i++)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.DHFJLKOGPPP = array[i];
					}
				}
			}
		}

		// Token: 0x060071D8 RID: 29144 RVA: 0x00237840 File Offset: 0x00235A40
		public void GNBEFOEOIIK(PointerEventData NOJGGCLPPAM)
		{
			if (this.DHFJLKOGPPP == null)
			{
				this.KDBGDNBIGEI();
			}
			this.AJLPECOCNDB.BGFJOEPFOPM(Mathf.MoveTowards(this.AJLPECOCNDB.LIILIMDGNMH(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x060071D9 RID: 29145 RVA: 0x00237894 File Offset: 0x00235A94
		private void IFBKMAEMKNN()
		{
			if (!CrossPlatformInputManager.AxisExists(this.axisName))
			{
				this.AJLPECOCNDB = new CrossPlatformInputManager.VirtualAxis(this.axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.AJLPECOCNDB);
			}
			else
			{
				this.AJLPECOCNDB = CrossPlatformInputManager.VirtualAxisReference(this.axisName);
			}
			this.FNBOJDLNAEM();
		}

		// Token: 0x060071DA RID: 29146 RVA: 0x002378EC File Offset: 0x00235AEC
		public void LJEJDLELJGL(PointerEventData NOJGGCLPPAM)
		{
			if (this.DHFJLKOGPPP == null)
			{
				this.LLJAFPEKNDO();
			}
			this.AJLPECOCNDB.JNBPKNNBMDI(Mathf.MoveTowards(this.AJLPECOCNDB.MOMIHHIMFCE(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x060071DB RID: 29147 RVA: 0x00237940 File Offset: 0x00235B40
		public void IOAMFBJCMOD(PointerEventData NOJGGCLPPAM)
		{
			if (this.DHFJLKOGPPP == null)
			{
				this.LLJAFPEKNDO();
			}
			this.AJLPECOCNDB.NDAJBJFJGCF(Mathf.MoveTowards(this.AJLPECOCNDB.ADGPGPJICDG(), this.axisValue, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x060071DC RID: 29148 RVA: 0x00237991 File Offset: 0x00235B91
		public void OnPointerUp(PointerEventData NOJGGCLPPAM)
		{
			this.AJLPECOCNDB.Update(Mathf.MoveTowards(this.AJLPECOCNDB.GetValue, 0f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x060071DD RID: 29149 RVA: 0x002379BF File Offset: 0x00235BBF
		public void BMLGKNAABGL(PointerEventData NOJGGCLPPAM)
		{
			this.AJLPECOCNDB.LLJLDLLNFBH(Mathf.MoveTowards(this.AJLPECOCNDB.ADGPGPJICDG(), 1552f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x060071DE RID: 29150 RVA: 0x002379F0 File Offset: 0x00235BF0
		private void COOKNCDHPBI()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 1; i < array.Length; i++)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.DHFJLKOGPPP = array[i];
					}
				}
			}
		}

		// Token: 0x060071DF RID: 29151 RVA: 0x00237A5C File Offset: 0x00235C5C
		private void GBMHGIHDCNP()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.DHFJLKOGPPP = array[i];
					}
				}
			}
		}

		// Token: 0x060071E0 RID: 29152 RVA: 0x00237AC7 File Offset: 0x00235CC7
		public void KCOPLPBOMDH(PointerEventData NOJGGCLPPAM)
		{
			this.AJLPECOCNDB.JNBPKNNBMDI(Mathf.MoveTowards(this.AJLPECOCNDB.NPHNIDDOGDI(), 706f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x060071E1 RID: 29153 RVA: 0x00237AF8 File Offset: 0x00235CF8
		private void LIFBFDKFMMH()
		{
			if (!CrossPlatformInputManager.AxisExists(this.axisName))
			{
				this.AJLPECOCNDB = new CrossPlatformInputManager.VirtualAxis(this.axisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.AJLPECOCNDB);
			}
			else
			{
				this.AJLPECOCNDB = CrossPlatformInputManager.VirtualAxisReference(this.axisName);
			}
			this.COOKNCDHPBI();
		}

		// Token: 0x060071E2 RID: 29154 RVA: 0x00237B4D File Offset: 0x00235D4D
		public void MPEPPBEMALK(PointerEventData NOJGGCLPPAM)
		{
			this.AJLPECOCNDB.NKLIHNJCHOG(Mathf.MoveTowards(this.AJLPECOCNDB.BEBAEPPOHEG(), 550f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x060071E3 RID: 29155 RVA: 0x00237B7B File Offset: 0x00235D7B
		public void PMBMEAHCJLB(PointerEventData NOJGGCLPPAM)
		{
			this.AJLPECOCNDB.NDAJBJFJGCF(Mathf.MoveTowards(this.AJLPECOCNDB.NMACMHAONFI(), 816f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x060071E4 RID: 29156 RVA: 0x00237BAC File Offset: 0x00235DAC
		private void FNBOJDLNAEM()
		{
			AxisTouchButton[] array = UnityEngine.Object.FindObjectsOfType(typeof(AxisTouchButton)) as AxisTouchButton[];
			if (array != null)
			{
				for (int i = 0; i < array.Length; i++)
				{
					if (array[i].axisName == this.axisName && array[i] != this)
					{
						this.DHFJLKOGPPP = array[i];
					}
				}
			}
		}

		// Token: 0x060071E5 RID: 29157 RVA: 0x00237C17 File Offset: 0x00235E17
		public void KKHDDAIHJEF(PointerEventData NOJGGCLPPAM)
		{
			this.AJLPECOCNDB.NDAJBJFJGCF(Mathf.MoveTowards(this.AJLPECOCNDB.HHBDOCNHMNH(), 1669f, this.responseSpeed * Time.deltaTime));
		}

		// Token: 0x060071E6 RID: 29158 RVA: 0x00237765 File Offset: 0x00235965
		private void OnDisable()
		{
			this.AJLPECOCNDB.Remove();
		}

		// Token: 0x04000B8E RID: 2958
		public string axisName = "Horizontal";

		// Token: 0x04000B8F RID: 2959
		public float axisValue = 1f;

		// Token: 0x04000B90 RID: 2960
		public float responseSpeed = 3f;

		// Token: 0x04000B91 RID: 2961
		public float returnToCentreSpeed = 3f;

		// Token: 0x04000B92 RID: 2962
		private AxisTouchButton DHFJLKOGPPP;

		// Token: 0x04000B93 RID: 2963
		private CrossPlatformInputManager.VirtualAxis AJLPECOCNDB;
	}
}
