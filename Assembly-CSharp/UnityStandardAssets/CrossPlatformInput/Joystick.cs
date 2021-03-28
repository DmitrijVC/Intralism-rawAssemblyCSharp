using System;
using UnityEngine;
using UnityEngine.EventSystems;

namespace UnityStandardAssets.CrossPlatformInput
{
	// Token: 0x02000188 RID: 392
	public class Joystick : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler, IEventSystemHandler
	{
		// Token: 0x06007329 RID: 29481 RVA: 0x002380D0 File Offset: 0x002362D0
		public void GIKAADBPOKK(PointerEventData NOJGGCLPPAM)
		{
			Vector3 zero = Vector3.zero;
			if (this.AOAAACMLGME)
			{
				int num = (int)(NOJGGCLPPAM.position.x - this.GFNABDIBANL.x);
				num = Mathf.Clamp(num, -this.MovementRange, this.MovementRange);
				zero.x = (float)num;
			}
			if (this.GFGONIBBMGE)
			{
				int num2 = (int)(NOJGGCLPPAM.position.y - this.GFNABDIBANL.y);
				num2 = Mathf.Clamp(num2, -this.MovementRange, this.MovementRange);
				zero.y = (float)num2;
			}
			base.transform.position = new Vector3(this.GFNABDIBANL.x + zero.x, this.GFNABDIBANL.y + zero.y, this.GFNABDIBANL.z + zero.z);
			this.CDLELNOPFOI(base.transform.position);
		}

		// Token: 0x0600732A RID: 29482 RVA: 0x002381C8 File Offset: 0x002363C8
		private void AIAHGBGKLFF(Vector3 DPNHODJHGJL)
		{
			Vector3 a = this.GFNABDIBANL - DPNHODJHGJL;
			a.y = -a.y;
			a /= (float)this.MovementRange;
			if (this.AOAAACMLGME)
			{
				this.GEHLOHDCGKN.FOMNCPKKCFN(-a.x);
			}
			if (this.GFGONIBBMGE)
			{
				this.NMFFOGAJKNE.JDGFCEPDKAJ(a.y);
			}
		}

		// Token: 0x0600732B RID: 29483 RVA: 0x0023823C File Offset: 0x0023643C
		private void CDLELNOPFOI(Vector3 DPNHODJHGJL)
		{
			Vector3 a = this.GFNABDIBANL - DPNHODJHGJL;
			a.y = -a.y;
			a /= (float)this.MovementRange;
			if (this.AOAAACMLGME)
			{
				this.GEHLOHDCGKN.NDAJBJFJGCF(-a.x);
			}
			if (this.GFGONIBBMGE)
			{
				this.NMFFOGAJKNE.LLJLDLLNFBH(a.y);
			}
		}

		// Token: 0x0600732C RID: 29484 RVA: 0x002382B0 File Offset: 0x002364B0
		private void GHBKODKIOOC()
		{
			this.AOAAACMLGME = (this.axesToUse == Joystick.AxisOption.Both || this.axesToUse == Joystick.AxisOption.OnlyHorizontal);
			this.GFGONIBBMGE = (this.axesToUse == Joystick.AxisOption.Both || this.axesToUse == Joystick.AxisOption.OnlyVertical);
			if (this.AOAAACMLGME)
			{
				this.GEHLOHDCGKN = new CrossPlatformInputManager.VirtualAxis(this.horizontalAxisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.GEHLOHDCGKN);
			}
			if (this.GFGONIBBMGE)
			{
				this.NMFFOGAJKNE = new CrossPlatformInputManager.VirtualAxis(this.verticalAxisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.NMFFOGAJKNE);
			}
		}

		// Token: 0x0600732D RID: 29485 RVA: 0x00238348 File Offset: 0x00236548
		public void NAFLLKBCDKM(PointerEventData NOJGGCLPPAM)
		{
			Vector3 zero = Vector3.zero;
			if (this.AOAAACMLGME)
			{
				int num = (int)(NOJGGCLPPAM.position.x - this.GFNABDIBANL.x);
				num = Mathf.Clamp(num, -this.MovementRange, this.MovementRange);
				zero.x = (float)num;
			}
			if (this.GFGONIBBMGE)
			{
				int num2 = (int)(NOJGGCLPPAM.position.y - this.GFNABDIBANL.y);
				num2 = Mathf.Clamp(num2, -this.MovementRange, this.MovementRange);
				zero.y = (float)num2;
			}
			base.transform.position = new Vector3(this.GFNABDIBANL.x + zero.x, this.GFNABDIBANL.y + zero.y, this.GFNABDIBANL.z + zero.z);
			this.HFEEDLKDMKL(base.transform.position);
		}

		// Token: 0x0600732E RID: 29486 RVA: 0x0023843E File Offset: 0x0023663E
		private void KIMMMCJFMAB()
		{
			this.GFNABDIBANL = base.transform.position;
		}

		// Token: 0x0600732F RID: 29487 RVA: 0x00238454 File Offset: 0x00236654
		private void HFEEDLKDMKL(Vector3 DPNHODJHGJL)
		{
			Vector3 a = this.GFNABDIBANL - DPNHODJHGJL;
			a.y = -a.y;
			a /= (float)this.MovementRange;
			if (this.AOAAACMLGME)
			{
				this.GEHLOHDCGKN.Update(-a.x);
			}
			if (this.GFGONIBBMGE)
			{
				this.NMFFOGAJKNE.Update(a.y);
			}
		}

		// Token: 0x06007330 RID: 29488 RVA: 0x002384C6 File Offset: 0x002366C6
		private void MEJPBKFMAIG()
		{
			this.DHDJKPBFPNK();
		}

		// Token: 0x06007331 RID: 29489 RVA: 0x0002523B File Offset: 0x0002343B
		public void BMFCMFPCGKO(PointerEventData NOJGGCLPPAM)
		{
		}

		// Token: 0x06007332 RID: 29490 RVA: 0x002384D0 File Offset: 0x002366D0
		public void PHMLOFLENEF(PointerEventData NOJGGCLPPAM)
		{
			Vector3 zero = Vector3.zero;
			if (this.AOAAACMLGME)
			{
				int num = (int)(NOJGGCLPPAM.position.x - this.GFNABDIBANL.x);
				num = Mathf.Clamp(num, -this.MovementRange, this.MovementRange);
				zero.x = (float)num;
			}
			if (this.GFGONIBBMGE)
			{
				int num2 = (int)(NOJGGCLPPAM.position.y - this.GFNABDIBANL.y);
				num2 = Mathf.Clamp(num2, -this.MovementRange, this.MovementRange);
				zero.y = (float)num2;
			}
			base.transform.position = new Vector3(this.GFNABDIBANL.x + zero.x, this.GFNABDIBANL.y + zero.y, this.GFNABDIBANL.z + zero.z);
			this.CDLELNOPFOI(base.transform.position);
		}

		// Token: 0x06007333 RID: 29491 RVA: 0x0023843E File Offset: 0x0023663E
		private void NPLCENPNJBM()
		{
			this.GFNABDIBANL = base.transform.position;
		}

		// Token: 0x06007334 RID: 29492 RVA: 0x0023843E File Offset: 0x0023663E
		private void Start()
		{
			this.GFNABDIBANL = base.transform.position;
		}

		// Token: 0x06007335 RID: 29493 RVA: 0x002385C6 File Offset: 0x002367C6
		public void GMHOOJFPPPM(PointerEventData NOJGGCLPPAM)
		{
			base.transform.position = this.GFNABDIBANL;
			this.AIAHGBGKLFF(this.GFNABDIBANL);
		}

		// Token: 0x06007336 RID: 29494 RVA: 0x002385E8 File Offset: 0x002367E8
		public void JLMIGIMEIDA(PointerEventData NOJGGCLPPAM)
		{
			Vector3 zero = Vector3.zero;
			if (this.AOAAACMLGME)
			{
				int num = (int)(NOJGGCLPPAM.position.x - this.GFNABDIBANL.x);
				num = Mathf.Clamp(num, -this.MovementRange, this.MovementRange);
				zero.x = (float)num;
			}
			if (this.GFGONIBBMGE)
			{
				int num2 = (int)(NOJGGCLPPAM.position.y - this.GFNABDIBANL.y);
				num2 = Mathf.Clamp(num2, -this.MovementRange, this.MovementRange);
				zero.y = (float)num2;
			}
			base.transform.position = new Vector3(this.GFNABDIBANL.x + zero.x, this.GFNABDIBANL.y + zero.y, this.GFNABDIBANL.z + zero.z);
			this.HFEEDLKDMKL(base.transform.position);
		}

		// Token: 0x06007337 RID: 29495 RVA: 0x002386E0 File Offset: 0x002368E0
		public void HNMDAFGIOIK(PointerEventData NOJGGCLPPAM)
		{
			Vector3 zero = Vector3.zero;
			if (this.AOAAACMLGME)
			{
				int num = (int)(NOJGGCLPPAM.position.x - this.GFNABDIBANL.x);
				num = Mathf.Clamp(num, -this.MovementRange, this.MovementRange);
				zero.x = (float)num;
			}
			if (this.GFGONIBBMGE)
			{
				int num2 = (int)(NOJGGCLPPAM.position.y - this.GFNABDIBANL.y);
				num2 = Mathf.Clamp(num2, -this.MovementRange, this.MovementRange);
				zero.y = (float)num2;
			}
			base.transform.position = new Vector3(this.GFNABDIBANL.x + zero.x, this.GFNABDIBANL.y + zero.y, this.GFNABDIBANL.z + zero.z);
			this.HFEEDLKDMKL(base.transform.position);
		}

		// Token: 0x06007338 RID: 29496 RVA: 0x002387D6 File Offset: 0x002369D6
		private void FCKIJIKNMCF()
		{
			this.GHBKODKIOOC();
		}

		// Token: 0x06007339 RID: 29497 RVA: 0x002387E0 File Offset: 0x002369E0
		public void OnDrag(PointerEventData NOJGGCLPPAM)
		{
			Vector3 zero = Vector3.zero;
			if (this.AOAAACMLGME)
			{
				int num = (int)(NOJGGCLPPAM.position.x - this.GFNABDIBANL.x);
				num = Mathf.Clamp(num, -this.MovementRange, this.MovementRange);
				zero.x = (float)num;
			}
			if (this.GFGONIBBMGE)
			{
				int num2 = (int)(NOJGGCLPPAM.position.y - this.GFNABDIBANL.y);
				num2 = Mathf.Clamp(num2, -this.MovementRange, this.MovementRange);
				zero.y = (float)num2;
			}
			base.transform.position = new Vector3(this.GFNABDIBANL.x + zero.x, this.GFNABDIBANL.y + zero.y, this.GFNABDIBANL.z + zero.z);
			this.HFEEDLKDMKL(base.transform.position);
		}

		// Token: 0x0600733B RID: 29499 RVA: 0x002388FC File Offset: 0x00236AFC
		public void BDBAMIJLAKD(PointerEventData NOJGGCLPPAM)
		{
			base.transform.position = this.GFNABDIBANL;
			this.CDLELNOPFOI(this.GFNABDIBANL);
		}

		// Token: 0x0600733C RID: 29500 RVA: 0x0002523B File Offset: 0x0002343B
		public void EODLMNHDCPI(PointerEventData NOJGGCLPPAM)
		{
		}

		// Token: 0x0600733D RID: 29501 RVA: 0x0023891B File Offset: 0x00236B1B
		private void OnDisable()
		{
			if (this.AOAAACMLGME)
			{
				this.GEHLOHDCGKN.Remove();
			}
			if (this.GFGONIBBMGE)
			{
				this.NMFFOGAJKNE.Remove();
			}
		}

		// Token: 0x0600733E RID: 29502 RVA: 0x0002523B File Offset: 0x0002343B
		public void LIPHKAAMJJA(PointerEventData NOJGGCLPPAM)
		{
		}

		// Token: 0x0600733F RID: 29503 RVA: 0x0023894C File Offset: 0x00236B4C
		private void PMMPCIAFMBL(Vector3 DPNHODJHGJL)
		{
			Vector3 a = this.GFNABDIBANL - DPNHODJHGJL;
			a.y = -a.y;
			a /= (float)this.MovementRange;
			if (this.AOAAACMLGME)
			{
				this.GEHLOHDCGKN.LLJLDLLNFBH(-a.x);
			}
			if (this.GFGONIBBMGE)
			{
				this.NMFFOGAJKNE.Update(a.y);
			}
		}

		// Token: 0x06007340 RID: 29504 RVA: 0x0023843E File Offset: 0x0023663E
		private void CCLNNLCOPBL()
		{
			this.GFNABDIBANL = base.transform.position;
		}

		// Token: 0x06007341 RID: 29505 RVA: 0x002389BE File Offset: 0x00236BBE
		public void OnPointerUp(PointerEventData NOJGGCLPPAM)
		{
			base.transform.position = this.GFNABDIBANL;
			this.HFEEDLKDMKL(this.GFNABDIBANL);
		}

		// Token: 0x06007342 RID: 29506 RVA: 0x002389DD File Offset: 0x00236BDD
		private void DFENCIHAADO()
		{
			if (this.AOAAACMLGME)
			{
				this.GEHLOHDCGKN.FAJPCAIIKHF();
			}
			if (this.GFGONIBBMGE)
			{
				this.NMFFOGAJKNE.FAJPCAIIKHF();
			}
		}

		// Token: 0x06007343 RID: 29507 RVA: 0x002387D6 File Offset: 0x002369D6
		private void BDBKIEIIFPB()
		{
			this.GHBKODKIOOC();
		}

		// Token: 0x06007344 RID: 29508 RVA: 0x0002523B File Offset: 0x0002343B
		public void OnPointerDown(PointerEventData NOJGGCLPPAM)
		{
		}

		// Token: 0x06007345 RID: 29509 RVA: 0x00238A0B File Offset: 0x00236C0B
		private void PHJLHCMCCKE()
		{
			if (this.AOAAACMLGME)
			{
				this.GEHLOHDCGKN.KHPOJPKOEJP();
			}
			if (this.GFGONIBBMGE)
			{
				this.NMFFOGAJKNE.OIGFKCBEMLN();
			}
		}

		// Token: 0x06007346 RID: 29510 RVA: 0x00238A3C File Offset: 0x00236C3C
		public void JPHMFELEOND(PointerEventData NOJGGCLPPAM)
		{
			Vector3 zero = Vector3.zero;
			if (this.AOAAACMLGME)
			{
				int num = (int)(NOJGGCLPPAM.position.x - this.GFNABDIBANL.x);
				num = Mathf.Clamp(num, -this.MovementRange, this.MovementRange);
				zero.x = (float)num;
			}
			if (this.GFGONIBBMGE)
			{
				int num2 = (int)(NOJGGCLPPAM.position.y - this.GFNABDIBANL.y);
				num2 = Mathf.Clamp(num2, -this.MovementRange, this.MovementRange);
				zero.y = (float)num2;
			}
			base.transform.position = new Vector3(this.GFNABDIBANL.x + zero.x, this.GFNABDIBANL.y + zero.y, this.GFNABDIBANL.z + zero.z);
			this.HFEEDLKDMKL(base.transform.position);
		}

		// Token: 0x06007347 RID: 29511 RVA: 0x00238B34 File Offset: 0x00236D34
		private void DHDJKPBFPNK()
		{
			this.AOAAACMLGME = (this.axesToUse != Joystick.AxisOption.Both && this.axesToUse == Joystick.AxisOption.Both);
			this.GFGONIBBMGE = (this.axesToUse == Joystick.AxisOption.Both || this.axesToUse == Joystick.AxisOption.Both);
			if (this.AOAAACMLGME)
			{
				this.GEHLOHDCGKN = new CrossPlatformInputManager.VirtualAxis(this.horizontalAxisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.GEHLOHDCGKN);
			}
			if (this.GFGONIBBMGE)
			{
				this.NMFFOGAJKNE = new CrossPlatformInputManager.VirtualAxis(this.verticalAxisName);
				CrossPlatformInputManager.RegisterVirtualAxis(this.NMFFOGAJKNE);
			}
		}

		// Token: 0x06007348 RID: 29512 RVA: 0x00238BC9 File Offset: 0x00236DC9
		public void KCOPLPBOMDH(PointerEventData NOJGGCLPPAM)
		{
			base.transform.position = this.GFNABDIBANL;
			this.PMMPCIAFMBL(this.GFNABDIBANL);
		}

		// Token: 0x06007349 RID: 29513 RVA: 0x002387D6 File Offset: 0x002369D6
		private void OnEnable()
		{
			this.GHBKODKIOOC();
		}

		// Token: 0x0600734A RID: 29514 RVA: 0x0002523B File Offset: 0x0002343B
		public void LNMLCNDAOPC(PointerEventData NOJGGCLPPAM)
		{
		}

		// Token: 0x0600734B RID: 29515 RVA: 0x0023843E File Offset: 0x0023663E
		private void DIPDEHOOBPG()
		{
			this.GFNABDIBANL = base.transform.position;
		}

		// Token: 0x04000BA4 RID: 2980
		public int MovementRange = 100;

		// Token: 0x04000BA5 RID: 2981
		public Joystick.AxisOption axesToUse;

		// Token: 0x04000BA6 RID: 2982
		public string horizontalAxisName = "Horizontal";

		// Token: 0x04000BA7 RID: 2983
		public string verticalAxisName = "Vertical";

		// Token: 0x04000BA8 RID: 2984
		private Vector3 GFNABDIBANL;

		// Token: 0x04000BA9 RID: 2985
		private bool AOAAACMLGME;

		// Token: 0x04000BAA RID: 2986
		private bool GFGONIBBMGE;

		// Token: 0x04000BAB RID: 2987
		private CrossPlatformInputManager.VirtualAxis GEHLOHDCGKN;

		// Token: 0x04000BAC RID: 2988
		private CrossPlatformInputManager.VirtualAxis NMFFOGAJKNE;

		// Token: 0x02000189 RID: 393
		public enum AxisOption
		{
			// Token: 0x04000BAE RID: 2990
			Both,
			// Token: 0x04000BAF RID: 2991
			OnlyHorizontal,
			// Token: 0x04000BB0 RID: 2992
			OnlyVertical
		}
	}
}
