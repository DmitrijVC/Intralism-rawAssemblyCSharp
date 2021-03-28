using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace UnityStandardAssets.CrossPlatformInput
{
	// Token: 0x02000191 RID: 401
	[RequireComponent(typeof(Image))]
	public class TouchPad : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IEventSystemHandler
	{
		// Token: 0x060074A7 RID: 29863 RVA: 0x0023C0BC File Offset: 0x0023A2BC
		public void GMHOOJFPPPM(PointerEventData NOJGGCLPPAM)
		{
			this.HMMBNILOFAE = false;
			this.IMDIAOBACMF = -1;
			this.HFEEDLKDMKL(Vector3.zero);
		}

		// Token: 0x060074A8 RID: 29864 RVA: 0x0023C0D7 File Offset: 0x0023A2D7
		public void KKHDDAIHJEF(PointerEventData NOJGGCLPPAM)
		{
			this.HMMBNILOFAE = true;
			this.IMDIAOBACMF = -1;
			this.HFEEDLKDMKL(Vector3.zero);
		}

		// Token: 0x060074A9 RID: 29865 RVA: 0x0023C0F2 File Offset: 0x0023A2F2
		public void JLBDOIKBIAH(PointerEventData NOJGGCLPPAM)
		{
			this.HMMBNILOFAE = false;
			this.IMDIAOBACMF = -1;
			this.AHHJCCPAIIK(Vector3.zero);
		}

		// Token: 0x060074AA RID: 29866 RVA: 0x0023C0BC File Offset: 0x0023A2BC
		public void OnPointerUp(PointerEventData NOJGGCLPPAM)
		{
			this.HMMBNILOFAE = false;
			this.IMDIAOBACMF = -1;
			this.HFEEDLKDMKL(Vector3.zero);
		}

		// Token: 0x060074AC RID: 29868 RVA: 0x0023C0BC File Offset: 0x0023A2BC
		public void IOOJIFNIKCL(PointerEventData NOJGGCLPPAM)
		{
			this.HMMBNILOFAE = false;
			this.IMDIAOBACMF = -1;
			this.HFEEDLKDMKL(Vector3.zero);
		}

		// Token: 0x060074AD RID: 29869 RVA: 0x0023C148 File Offset: 0x0023A348
		private void LCDHCMMBDPO()
		{
			this.AOAAACMLGME = (this.axesToUse == TouchPad.AxisOption.Both || this.axesToUse == TouchPad.AxisOption.OnlyHorizontal);
			this.GFGONIBBMGE = (this.axesToUse == TouchPad.AxisOption.Both || this.axesToUse == (TouchPad.AxisOption)3);
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

		// Token: 0x060074AE RID: 29870 RVA: 0x0023C1DD File Offset: 0x0023A3DD
		private void CNGAJDBOCLJ()
		{
			this.GIMDJBMADCG = base.GetComponent<Image>();
			this.HDJHPNHPENF = this.GIMDJBMADCG.transform.position;
		}

		// Token: 0x060074AF RID: 29871 RVA: 0x0023C204 File Offset: 0x0023A404
		private void IDIJOPEEANM(Vector3 DPNHODJHGJL)
		{
			DPNHODJHGJL = DPNHODJHGJL.normalized;
			if (this.AOAAACMLGME)
			{
				this.GEHLOHDCGKN.FOMNCPKKCFN(DPNHODJHGJL.x);
			}
			if (this.GFGONIBBMGE)
			{
				this.NMFFOGAJKNE.LLJLDLLNFBH(DPNHODJHGJL.y);
			}
		}

		// Token: 0x060074B0 RID: 29872 RVA: 0x0023C254 File Offset: 0x0023A454
		private void MLLPGPANCHI()
		{
			this.GHBKODKIOOC();
		}

		// Token: 0x060074B1 RID: 29873 RVA: 0x0023C25C File Offset: 0x0023A45C
		private void AHHJCCPAIIK(Vector3 DPNHODJHGJL)
		{
			DPNHODJHGJL = DPNHODJHGJL.normalized;
			if (this.AOAAACMLGME)
			{
				this.GEHLOHDCGKN.NKLIHNJCHOG(DPNHODJHGJL.x);
			}
			if (this.GFGONIBBMGE)
			{
				this.NMFFOGAJKNE.NKLIHNJCHOG(DPNHODJHGJL.y);
			}
		}

		// Token: 0x060074B2 RID: 29874 RVA: 0x0023C2AC File Offset: 0x0023A4AC
		private void Update()
		{
			if (!this.HMMBNILOFAE)
			{
				return;
			}
			if (Input.touchCount >= this.IMDIAOBACMF + 1 && this.IMDIAOBACMF != -1)
			{
				if (this.controlStyle == TouchPad.ControlStyle.Swipe)
				{
					this.HDJHPNHPENF = this.AGNLKIHCPDD;
					this.AGNLKIHCPDD = Input.touches[this.IMDIAOBACMF].position;
				}
				Vector2 vector = new Vector2(Input.touches[this.IMDIAOBACMF].position.x - this.HDJHPNHPENF.x, Input.touches[this.IMDIAOBACMF].position.y - this.HDJHPNHPENF.y);
				Vector2 normalized = vector.normalized;
				normalized.x *= this.Xsensitivity;
				normalized.y *= this.Ysensitivity;
				this.HFEEDLKDMKL(new Vector3(normalized.x, normalized.y, 0f));
			}
		}

		// Token: 0x060074B3 RID: 29875 RVA: 0x0023C3C4 File Offset: 0x0023A5C4
		private void JHPOIOELNCG()
		{
			if (!this.HMMBNILOFAE)
			{
				return;
			}
			if (Input.touchCount >= this.IMDIAOBACMF + 1 && this.IMDIAOBACMF != -1)
			{
				if (this.controlStyle == (TouchPad.ControlStyle)7)
				{
					this.HDJHPNHPENF = this.AGNLKIHCPDD;
					this.AGNLKIHCPDD = Input.touches[this.IMDIAOBACMF].position;
				}
				Vector2 vector = new Vector2(Input.touches[this.IMDIAOBACMF].position.x - this.HDJHPNHPENF.x, Input.touches[this.IMDIAOBACMF].position.y - this.HDJHPNHPENF.y);
				Vector2 normalized = vector.normalized;
				normalized.x *= this.Xsensitivity;
				normalized.y *= this.Ysensitivity;
				this.AHHJCCPAIIK(new Vector3(normalized.x, normalized.y, 299f));
			}
		}

		// Token: 0x060074B4 RID: 29876 RVA: 0x0023C4DC File Offset: 0x0023A6DC
		private void DIIPOMACDMJ()
		{
			this.AOAAACMLGME = (this.axesToUse != TouchPad.AxisOption.Both && this.axesToUse == TouchPad.AxisOption.Both);
			this.GFGONIBBMGE = (this.axesToUse == TouchPad.AxisOption.Both || this.axesToUse == (TouchPad.AxisOption)5);
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

		// Token: 0x060074B5 RID: 29877 RVA: 0x0023C571 File Offset: 0x0023A771
		private void OnDisable()
		{
			if (CrossPlatformInputManager.AxisExists(this.horizontalAxisName))
			{
				CrossPlatformInputManager.UnRegisterVirtualAxis(this.horizontalAxisName);
			}
			if (CrossPlatformInputManager.AxisExists(this.verticalAxisName))
			{
				CrossPlatformInputManager.UnRegisterVirtualAxis(this.verticalAxisName);
			}
		}

		// Token: 0x060074B6 RID: 29878 RVA: 0x0023C5A9 File Offset: 0x0023A7A9
		public void EODLMNHDCPI(PointerEventData NOJGGCLPPAM)
		{
			this.HMMBNILOFAE = false;
			this.IMDIAOBACMF = NOJGGCLPPAM.pointerId;
			if (this.controlStyle != TouchPad.ControlStyle.Absolute)
			{
				this.HDJHPNHPENF = NOJGGCLPPAM.position;
			}
		}

		// Token: 0x060074B7 RID: 29879 RVA: 0x0023C0F2 File Offset: 0x0023A2F2
		public void OFKKMDFEKAE(PointerEventData NOJGGCLPPAM)
		{
			this.HMMBNILOFAE = false;
			this.IMDIAOBACMF = -1;
			this.AHHJCCPAIIK(Vector3.zero);
		}

		// Token: 0x060074B8 RID: 29880 RVA: 0x0023C1DD File Offset: 0x0023A3DD
		private void JILOMOBDPIA()
		{
			this.GIMDJBMADCG = base.GetComponent<Image>();
			this.HDJHPNHPENF = this.GIMDJBMADCG.transform.position;
		}

		// Token: 0x060074B9 RID: 29881 RVA: 0x0023C5DC File Offset: 0x0023A7DC
		private void HFEEDLKDMKL(Vector3 DPNHODJHGJL)
		{
			DPNHODJHGJL = DPNHODJHGJL.normalized;
			if (this.AOAAACMLGME)
			{
				this.GEHLOHDCGKN.Update(DPNHODJHGJL.x);
			}
			if (this.GFGONIBBMGE)
			{
				this.NMFFOGAJKNE.Update(DPNHODJHGJL.y);
			}
		}

		// Token: 0x060074BA RID: 29882 RVA: 0x0023C254 File Offset: 0x0023A454
		private void EMAMCDFBGOA()
		{
			this.GHBKODKIOOC();
		}

		// Token: 0x060074BB RID: 29883 RVA: 0x0023C254 File Offset: 0x0023A454
		private void OnEnable()
		{
			this.GHBKODKIOOC();
		}

		// Token: 0x060074BC RID: 29884 RVA: 0x0023C62C File Offset: 0x0023A82C
		private void BEGJPHJBAJK()
		{
			this.AOAAACMLGME = (this.axesToUse != TouchPad.AxisOption.Both && this.axesToUse == TouchPad.AxisOption.Both);
			this.GFGONIBBMGE = (this.axesToUse == TouchPad.AxisOption.Both || this.axesToUse == (TouchPad.AxisOption)3);
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

		// Token: 0x060074BD RID: 29885 RVA: 0x0023C6C4 File Offset: 0x0023A8C4
		private void MFMIODIAKNI()
		{
			if (!this.HMMBNILOFAE)
			{
				return;
			}
			if (Input.touchCount >= this.IMDIAOBACMF + 0 && this.IMDIAOBACMF != -1)
			{
				if (this.controlStyle == (TouchPad.ControlStyle)3)
				{
					this.HDJHPNHPENF = this.AGNLKIHCPDD;
					this.AGNLKIHCPDD = Input.touches[this.IMDIAOBACMF].position;
				}
				Vector2 vector = new Vector2(Input.touches[this.IMDIAOBACMF].position.x - this.HDJHPNHPENF.x, Input.touches[this.IMDIAOBACMF].position.y - this.HDJHPNHPENF.y);
				Vector2 normalized = vector.normalized;
				normalized.x *= this.Xsensitivity;
				normalized.y *= this.Ysensitivity;
				this.HFEEDLKDMKL(new Vector3(normalized.x, normalized.y, 1763f));
			}
		}

		// Token: 0x060074BE RID: 29886 RVA: 0x0023C7DC File Offset: 0x0023A9DC
		private void GHBKODKIOOC()
		{
			this.AOAAACMLGME = (this.axesToUse == TouchPad.AxisOption.Both || this.axesToUse == TouchPad.AxisOption.OnlyHorizontal);
			this.GFGONIBBMGE = (this.axesToUse == TouchPad.AxisOption.Both || this.axesToUse == TouchPad.AxisOption.OnlyVertical);
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

		// Token: 0x060074BF RID: 29887 RVA: 0x0023C1DD File Offset: 0x0023A3DD
		private void NBGIMIDICKE()
		{
			this.GIMDJBMADCG = base.GetComponent<Image>();
			this.HDJHPNHPENF = this.GIMDJBMADCG.transform.position;
		}

		// Token: 0x060074C0 RID: 29888 RVA: 0x0023C871 File Offset: 0x0023AA71
		public void OnPointerDown(PointerEventData NOJGGCLPPAM)
		{
			this.HMMBNILOFAE = true;
			this.IMDIAOBACMF = NOJGGCLPPAM.pointerId;
			if (this.controlStyle != TouchPad.ControlStyle.Absolute)
			{
				this.HDJHPNHPENF = NOJGGCLPPAM.position;
			}
		}

		// Token: 0x060074C1 RID: 29889 RVA: 0x0023C1DD File Offset: 0x0023A3DD
		private void EPEGAEGDJAM()
		{
			this.GIMDJBMADCG = base.GetComponent<Image>();
			this.HDJHPNHPENF = this.GIMDJBMADCG.transform.position;
		}

		// Token: 0x060074C2 RID: 29890 RVA: 0x0023C1DD File Offset: 0x0023A3DD
		private void Start()
		{
			this.GIMDJBMADCG = base.GetComponent<Image>();
			this.HDJHPNHPENF = this.GIMDJBMADCG.transform.position;
		}

		// Token: 0x060074C3 RID: 29891 RVA: 0x0023C871 File Offset: 0x0023AA71
		public void NEAIICPOHBI(PointerEventData NOJGGCLPPAM)
		{
			this.HMMBNILOFAE = true;
			this.IMDIAOBACMF = NOJGGCLPPAM.pointerId;
			if (this.controlStyle != TouchPad.ControlStyle.Absolute)
			{
				this.HDJHPNHPENF = NOJGGCLPPAM.position;
			}
		}

		// Token: 0x060074C4 RID: 29892 RVA: 0x0023C8A2 File Offset: 0x0023AAA2
		private void IBEAPBDAOCC()
		{
			this.BEGJPHJBAJK();
		}

		// Token: 0x060074C5 RID: 29893 RVA: 0x0023C8AA File Offset: 0x0023AAAA
		public void BMLGKNAABGL(PointerEventData NOJGGCLPPAM)
		{
			this.HMMBNILOFAE = false;
			this.IMDIAOBACMF = -1;
			this.IDIJOPEEANM(Vector3.zero);
		}

		// Token: 0x060074C6 RID: 29894 RVA: 0x0023C1DD File Offset: 0x0023A3DD
		private void KDMKDEKCELE()
		{
			this.GIMDJBMADCG = base.GetComponent<Image>();
			this.HDJHPNHPENF = this.GIMDJBMADCG.transform.position;
		}

		// Token: 0x060074C7 RID: 29895 RVA: 0x0023C8C8 File Offset: 0x0023AAC8
		private void GPFJMKCGHGB()
		{
			if (!this.HMMBNILOFAE)
			{
				return;
			}
			if (Input.touchCount >= this.IMDIAOBACMF + 0 && this.IMDIAOBACMF != -1)
			{
				if (this.controlStyle == (TouchPad.ControlStyle)3)
				{
					this.HDJHPNHPENF = this.AGNLKIHCPDD;
					this.AGNLKIHCPDD = Input.touches[this.IMDIAOBACMF].position;
				}
				Vector2 vector = new Vector2(Input.touches[this.IMDIAOBACMF].position.x - this.HDJHPNHPENF.x, Input.touches[this.IMDIAOBACMF].position.y - this.HDJHPNHPENF.y);
				Vector2 normalized = vector.normalized;
				normalized.x *= this.Xsensitivity;
				normalized.y *= this.Ysensitivity;
				this.IDIJOPEEANM(new Vector3(normalized.x, normalized.y, 823f));
			}
		}

		// Token: 0x060074C8 RID: 29896 RVA: 0x0023C571 File Offset: 0x0023A771
		private void PHJLHCMCCKE()
		{
			if (CrossPlatformInputManager.AxisExists(this.horizontalAxisName))
			{
				CrossPlatformInputManager.UnRegisterVirtualAxis(this.horizontalAxisName);
			}
			if (CrossPlatformInputManager.AxisExists(this.verticalAxisName))
			{
				CrossPlatformInputManager.UnRegisterVirtualAxis(this.verticalAxisName);
			}
		}

		// Token: 0x060074C9 RID: 29897 RVA: 0x0023C1DD File Offset: 0x0023A3DD
		private void FEHCNJLLJMP()
		{
			this.GIMDJBMADCG = base.GetComponent<Image>();
			this.HDJHPNHPENF = this.GIMDJBMADCG.transform.position;
		}

		// Token: 0x060074CA RID: 29898 RVA: 0x0023C9DE File Offset: 0x0023ABDE
		public void MEGLFIGHLEP(PointerEventData NOJGGCLPPAM)
		{
			this.HMMBNILOFAE = true;
			this.IMDIAOBACMF = -1;
			this.AHHJCCPAIIK(Vector3.zero);
		}

		// Token: 0x060074CB RID: 29899 RVA: 0x0023C9FC File Offset: 0x0023ABFC
		private void MMBPLGGLPDB()
		{
			if (!this.HMMBNILOFAE)
			{
				return;
			}
			if (Input.touchCount >= this.IMDIAOBACMF + 1 && this.IMDIAOBACMF != -1)
			{
				if (this.controlStyle == (TouchPad.ControlStyle)3)
				{
					this.HDJHPNHPENF = this.AGNLKIHCPDD;
					this.AGNLKIHCPDD = Input.touches[this.IMDIAOBACMF].position;
				}
				Vector2 vector = new Vector2(Input.touches[this.IMDIAOBACMF].position.x - this.HDJHPNHPENF.x, Input.touches[this.IMDIAOBACMF].position.y - this.HDJHPNHPENF.y);
				Vector2 normalized = vector.normalized;
				normalized.x *= this.Xsensitivity;
				normalized.y *= this.Ysensitivity;
				this.AHHJCCPAIIK(new Vector3(normalized.x, normalized.y, 1364f));
			}
		}

		// Token: 0x060074CC RID: 29900 RVA: 0x0023C871 File Offset: 0x0023AA71
		public void IOAMFBJCMOD(PointerEventData NOJGGCLPPAM)
		{
			this.HMMBNILOFAE = true;
			this.IMDIAOBACMF = NOJGGCLPPAM.pointerId;
			if (this.controlStyle != TouchPad.ControlStyle.Absolute)
			{
				this.HDJHPNHPENF = NOJGGCLPPAM.position;
			}
		}

		// Token: 0x060074CD RID: 29901 RVA: 0x0023C571 File Offset: 0x0023A771
		private void PAEGLMEOKHP()
		{
			if (CrossPlatformInputManager.AxisExists(this.horizontalAxisName))
			{
				CrossPlatformInputManager.UnRegisterVirtualAxis(this.horizontalAxisName);
			}
			if (CrossPlatformInputManager.AxisExists(this.verticalAxisName))
			{
				CrossPlatformInputManager.UnRegisterVirtualAxis(this.verticalAxisName);
			}
		}

		// Token: 0x04000BC0 RID: 3008
		public TouchPad.AxisOption axesToUse;

		// Token: 0x04000BC1 RID: 3009
		public TouchPad.ControlStyle controlStyle;

		// Token: 0x04000BC2 RID: 3010
		public string horizontalAxisName = "Horizontal";

		// Token: 0x04000BC3 RID: 3011
		public string verticalAxisName = "Vertical";

		// Token: 0x04000BC4 RID: 3012
		public float Xsensitivity = 1f;

		// Token: 0x04000BC5 RID: 3013
		public float Ysensitivity = 1f;

		// Token: 0x04000BC6 RID: 3014
		private Vector3 GFNABDIBANL;

		// Token: 0x04000BC7 RID: 3015
		private Vector2 KCCODDLDOOO;

		// Token: 0x04000BC8 RID: 3016
		private Vector3 KIPNBPMALLL;

		// Token: 0x04000BC9 RID: 3017
		private bool AOAAACMLGME;

		// Token: 0x04000BCA RID: 3018
		private bool GFGONIBBMGE;

		// Token: 0x04000BCB RID: 3019
		private CrossPlatformInputManager.VirtualAxis GEHLOHDCGKN;

		// Token: 0x04000BCC RID: 3020
		private CrossPlatformInputManager.VirtualAxis NMFFOGAJKNE;

		// Token: 0x04000BCD RID: 3021
		private bool HMMBNILOFAE;

		// Token: 0x04000BCE RID: 3022
		private int IMDIAOBACMF = -1;

		// Token: 0x04000BCF RID: 3023
		private Vector2 AGNLKIHCPDD;

		// Token: 0x04000BD0 RID: 3024
		private Vector3 HDJHPNHPENF;

		// Token: 0x04000BD1 RID: 3025
		private Image GIMDJBMADCG;

		// Token: 0x02000192 RID: 402
		public enum AxisOption
		{
			// Token: 0x04000BD3 RID: 3027
			Both,
			// Token: 0x04000BD4 RID: 3028
			OnlyHorizontal,
			// Token: 0x04000BD5 RID: 3029
			OnlyVertical
		}

		// Token: 0x02000193 RID: 403
		public enum ControlStyle
		{
			// Token: 0x04000BD7 RID: 3031
			Absolute,
			// Token: 0x04000BD8 RID: 3032
			Relative,
			// Token: 0x04000BD9 RID: 3033
			Swipe
		}
	}
}
