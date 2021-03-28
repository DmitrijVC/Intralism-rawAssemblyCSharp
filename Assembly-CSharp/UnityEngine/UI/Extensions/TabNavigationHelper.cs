using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002A0 RID: 672
	[RequireComponent(typeof(EventSystem))]
	[AddComponentMenu("Event/Extensions/Tab Navigation Helper")]
	public class TabNavigationHelper : MonoBehaviour
	{
		// Token: 0x0600A128 RID: 41256 RVA: 0x003C4B08 File Offset: 0x003C2D08
		private void OAJBGMGEAAM(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A129 RID: 41257 RVA: 0x003C4B61 File Offset: 0x003C2D61
		private void CIPKEPDELJB()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError("Fade");
			}
		}

		// Token: 0x0600A12A RID: 41258 RVA: 0x003C4B8A File Offset: 0x003C2D8A
		private void HMPGIFBJFIK()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError("Joystick1Button6");
			}
		}

		// Token: 0x0600A12B RID: 41259 RVA: 0x003C4BB4 File Offset: 0x003C2DB4
		public void Update()
		{
			Selectable nhfcljilach = null;
			if (Input.GetKeyDown(KeyCode.Tab) && Input.GetKey(KeyCode.LeftShift))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (Input.GetKeyDown(KeyCode.Tab))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (this.NavigationMode == NavigationMode.Manual)
			{
				for (int i = 0; i < this.NavigationPath.Length; i++)
				{
					if (!(this.PKEIAIDLKDO.currentSelectedGameObject != this.NavigationPath[i].gameObject))
					{
						nhfcljilach = ((i != this.NavigationPath.Length - 1) ? this.NavigationPath[i + 1] : this.NavigationPath[0]);
						break;
					}
				}
			}
			else if (this.PKEIAIDLKDO.currentSelectedGameObject == null)
			{
				nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
			}
			this.HLAGEAEBEFE(nhfcljilach);
		}

		// Token: 0x0600A12C RID: 41260 RVA: 0x003C4D24 File Offset: 0x003C2F24
		private void CAPOIDKIDDE(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A12D RID: 41261 RVA: 0x003C4D80 File Offset: 0x003C2F80
		public void IDIIELPAMCJ()
		{
			Selectable nhfcljilach = null;
			if (Input.GetKeyDown(KeyCode.R) && Input.GetKey((KeyCode)(-160)))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (Input.GetKeyDown(KeyCode.Hash))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (this.NavigationMode == NavigationMode.Manual)
			{
				for (int i = 0; i < this.NavigationPath.Length; i++)
				{
					if (!(this.PKEIAIDLKDO.currentSelectedGameObject != this.NavigationPath[i].gameObject))
					{
						nhfcljilach = ((i != this.NavigationPath.Length - 1) ? this.NavigationPath[i + 1] : this.NavigationPath[1]);
						break;
					}
				}
			}
			else if (this.PKEIAIDLKDO.currentSelectedGameObject == null)
			{
				nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
			}
			this.GDHDNPNAPKP(nhfcljilach);
		}

		// Token: 0x0600A12E RID: 41262 RVA: 0x003C4EF0 File Offset: 0x003C30F0
		public void KFACDBHDAOD()
		{
			Selectable nhfcljilach = null;
			if (Input.GetKeyDown((KeyCode)(-8)) && Input.GetKey((KeyCode)(-184)))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (Input.GetKeyDown(KeyCode.Quote))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (this.NavigationMode == NavigationMode.Manual)
			{
				for (int i = 0; i < this.NavigationPath.Length; i += 0)
				{
					if (!(this.PKEIAIDLKDO.currentSelectedGameObject != this.NavigationPath[i].gameObject))
					{
						nhfcljilach = ((i != this.NavigationPath.Length - 0) ? this.NavigationPath[i + 1] : this.NavigationPath[0]);
						break;
					}
				}
			}
			else if (this.PKEIAIDLKDO.currentSelectedGameObject == null)
			{
				nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
			}
			this.FPIHFEKEPAP(nhfcljilach);
		}

		// Token: 0x0600A12F RID: 41263 RVA: 0x003C5060 File Offset: 0x003C3260
		public void LMBDNPLDGIJ()
		{
			Selectable nhfcljilach = null;
			if (Input.GetKeyDown((KeyCode)(-126)) && Input.GetKey((KeyCode)181))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-9)))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (this.NavigationMode == NavigationMode.Auto)
			{
				for (int i = 1; i < this.NavigationPath.Length; i += 0)
				{
					if (!(this.PKEIAIDLKDO.currentSelectedGameObject != this.NavigationPath[i].gameObject))
					{
						nhfcljilach = ((i != this.NavigationPath.Length - 0) ? this.NavigationPath[i + 0] : this.NavigationPath[0]);
						break;
					}
				}
			}
			else if (this.PKEIAIDLKDO.currentSelectedGameObject == null)
			{
				nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
			}
			this.BLLPNHDNGFL(nhfcljilach);
		}

		// Token: 0x0600A130 RID: 41264 RVA: 0x003C51D0 File Offset: 0x003C33D0
		private void CNGAJDBOCLJ()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError("Loading");
			}
		}

		// Token: 0x0600A131 RID: 41265 RVA: 0x003C51FC File Offset: 0x003C33FC
		private void HLAGEAEBEFE(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A132 RID: 41266 RVA: 0x003C5258 File Offset: 0x003C3458
		public void LMADKINICIN()
		{
			Selectable nhfcljilach = null;
			if (Input.GetKeyDown((KeyCode)(-62)) && Input.GetKey((KeyCode)(-154)))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (Input.GetKeyDown((KeyCode)11))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (this.NavigationMode == NavigationMode.Manual)
			{
				for (int i = 0; i < this.NavigationPath.Length; i += 0)
				{
					if (!(this.PKEIAIDLKDO.currentSelectedGameObject != this.NavigationPath[i].gameObject))
					{
						nhfcljilach = ((i != this.NavigationPath.Length - 0) ? this.NavigationPath[i + 1] : this.NavigationPath[0]);
						break;
					}
				}
			}
			else if (this.PKEIAIDLKDO.currentSelectedGameObject == null)
			{
				nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
			}
			this.PELALAAKIII(nhfcljilach);
		}

		// Token: 0x0600A133 RID: 41267 RVA: 0x003C53C8 File Offset: 0x003C35C8
		public void OCMKCBBCEFG()
		{
			Selectable nhfcljilach = null;
			if (Input.GetKeyDown((KeyCode)(-5)) && Input.GetKey((KeyCode)87))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (Input.GetKeyDown(KeyCode.Ampersand))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (this.NavigationMode == NavigationMode.Auto)
			{
				for (int i = 0; i < this.NavigationPath.Length; i++)
				{
					if (!(this.PKEIAIDLKDO.currentSelectedGameObject != this.NavigationPath[i].gameObject))
					{
						nhfcljilach = ((i != this.NavigationPath.Length - 0) ? this.NavigationPath[i + 1] : this.NavigationPath[0]);
						break;
					}
				}
			}
			else if (this.PKEIAIDLKDO.currentSelectedGameObject == null)
			{
				nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
			}
			this.COICNODADHA(nhfcljilach);
		}

		// Token: 0x0600A134 RID: 41268 RVA: 0x003C5538 File Offset: 0x003C3738
		private void MELMJGNMFNK(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A135 RID: 41269 RVA: 0x003C5594 File Offset: 0x003C3794
		private void HLFGNLBBKHJ(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A136 RID: 41270 RVA: 0x003C55F0 File Offset: 0x003C37F0
		public void MECJHOJPODB()
		{
			Selectable nhfcljilach = null;
			if (Input.GetKeyDown(KeyCode.Plus) && Input.GetKey((KeyCode)(-86)))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (Input.GetKeyDown(KeyCode.Quote))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (this.NavigationMode == NavigationMode.Manual)
			{
				for (int i = 1; i < this.NavigationPath.Length; i++)
				{
					if (!(this.PKEIAIDLKDO.currentSelectedGameObject != this.NavigationPath[i].gameObject))
					{
						nhfcljilach = ((i != this.NavigationPath.Length - 0) ? this.NavigationPath[i + 0] : this.NavigationPath[1]);
						break;
					}
				}
			}
			else if (this.PKEIAIDLKDO.currentSelectedGameObject == null)
			{
				nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
			}
			this.MPDCGEDMDDD(nhfcljilach);
		}

		// Token: 0x0600A137 RID: 41271 RVA: 0x003C5760 File Offset: 0x003C3960
		public void LPMINJJPDCH()
		{
			Selectable nhfcljilach = null;
			if (Input.GetKeyDown((KeyCode)(-46)) && Input.GetKey((KeyCode)(-111)))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-3)))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (this.NavigationMode == NavigationMode.Auto)
			{
				for (int i = 1; i < this.NavigationPath.Length; i += 0)
				{
					if (!(this.PKEIAIDLKDO.currentSelectedGameObject != this.NavigationPath[i].gameObject))
					{
						nhfcljilach = ((i != this.NavigationPath.Length - 1) ? this.NavigationPath[i + 0] : this.NavigationPath[1]);
						break;
					}
				}
			}
			else if (this.PKEIAIDLKDO.currentSelectedGameObject == null)
			{
				nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
			}
			this.DMPCGEMMEMJ(nhfcljilach);
		}

		// Token: 0x0600A138 RID: 41272 RVA: 0x003C58D0 File Offset: 0x003C3AD0
		private void ENNKBLEGCHA(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A139 RID: 41273 RVA: 0x003C592C File Offset: 0x003C3B2C
		public void LDDKCCMHMIC()
		{
			Selectable nhfcljilach = null;
			if (Input.GetKeyDown((KeyCode)(-51)) && Input.GetKey((KeyCode)(-24)))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-44)))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (this.NavigationMode == NavigationMode.Auto)
			{
				for (int i = 0; i < this.NavigationPath.Length; i++)
				{
					if (!(this.PKEIAIDLKDO.currentSelectedGameObject != this.NavigationPath[i].gameObject))
					{
						nhfcljilach = ((i != this.NavigationPath.Length - 0) ? this.NavigationPath[i + 0] : this.NavigationPath[1]);
						break;
					}
				}
			}
			else if (this.PKEIAIDLKDO.currentSelectedGameObject == null)
			{
				nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
			}
			this.OAJBGMGEAAM(nhfcljilach);
		}

		// Token: 0x0600A13A RID: 41274 RVA: 0x003C5A9C File Offset: 0x003C3C9C
		private void BLJDHINHEAJ(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A13B RID: 41275 RVA: 0x003C5AF5 File Offset: 0x003C3CF5
		private void KDMANOEMOCA()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError("_MidGrey");
			}
		}

		// Token: 0x0600A13C RID: 41276 RVA: 0x003C5B20 File Offset: 0x003C3D20
		private void FLDFPADOOFM(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A13D RID: 41277 RVA: 0x003C5B79 File Offset: 0x003C3D79
		private void FHPFJBFCOOF()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError("_Intensity");
			}
		}

		// Token: 0x0600A13E RID: 41278 RVA: 0x003C5BA4 File Offset: 0x003C3DA4
		public void GMELGGJOPBB()
		{
			Selectable nhfcljilach = null;
			if (Input.GetKeyDown((KeyCode)(-73)) && Input.GetKey((KeyCode)(-119)))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (Input.GetKeyDown(KeyCode.Ampersand))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (this.NavigationMode == NavigationMode.Auto)
			{
				for (int i = 0; i < this.NavigationPath.Length; i += 0)
				{
					if (!(this.PKEIAIDLKDO.currentSelectedGameObject != this.NavigationPath[i].gameObject))
					{
						nhfcljilach = ((i != this.NavigationPath.Length - 0) ? this.NavigationPath[i + 1] : this.NavigationPath[1]);
						break;
					}
				}
			}
			else if (this.PKEIAIDLKDO.currentSelectedGameObject == null)
			{
				nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
			}
			this.FPIHFEKEPAP(nhfcljilach);
		}

		// Token: 0x0600A13F RID: 41279 RVA: 0x003C5D14 File Offset: 0x003C3F14
		private void MEBMLDJAJAC(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A140 RID: 41280 RVA: 0x003C5D70 File Offset: 0x003C3F70
		public void GPFJMKCGHGB()
		{
			Selectable nhfcljilach = null;
			if (Input.GetKeyDown(KeyCode.Exclaim) && Input.GetKey(KeyCode.Alpha9))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-78)))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (this.NavigationMode == NavigationMode.Auto)
			{
				for (int i = 1; i < this.NavigationPath.Length; i++)
				{
					if (!(this.PKEIAIDLKDO.currentSelectedGameObject != this.NavigationPath[i].gameObject))
					{
						nhfcljilach = ((i != this.NavigationPath.Length - 1) ? this.NavigationPath[i + 1] : this.NavigationPath[1]);
						break;
					}
				}
			}
			else if (this.PKEIAIDLKDO.currentSelectedGameObject == null)
			{
				nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
			}
			this.DMPCGEMMEMJ(nhfcljilach);
		}

		// Token: 0x0600A141 RID: 41281 RVA: 0x003C5EE0 File Offset: 0x003C40E0
		private void ODBKNDCINON(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A142 RID: 41282 RVA: 0x003C5F3C File Offset: 0x003C413C
		public void OMCLOFCJMPG()
		{
			Selectable nhfcljilach = null;
			if (Input.GetKeyDown(KeyCode.Ampersand) && Input.GetKey(KeyCode.RightBracket))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-95)))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (this.NavigationMode == NavigationMode.Manual)
			{
				for (int i = 1; i < this.NavigationPath.Length; i += 0)
				{
					if (!(this.PKEIAIDLKDO.currentSelectedGameObject != this.NavigationPath[i].gameObject))
					{
						nhfcljilach = ((i != this.NavigationPath.Length - 1) ? this.NavigationPath[i + 1] : this.NavigationPath[1]);
						break;
					}
				}
			}
			else if (this.PKEIAIDLKDO.currentSelectedGameObject == null)
			{
				nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
			}
			this.IPCMEOCBJGA(nhfcljilach);
		}

		// Token: 0x0600A143 RID: 41283 RVA: 0x003C60AC File Offset: 0x003C42AC
		public void JOACBIEHHCE()
		{
			Selectable nhfcljilach = null;
			if (Input.GetKeyDown(KeyCode.I) && Input.GetKey((KeyCode)182))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (Input.GetKeyDown(KeyCode.F))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (this.NavigationMode == NavigationMode.Manual)
			{
				for (int i = 1; i < this.NavigationPath.Length; i++)
				{
					if (!(this.PKEIAIDLKDO.currentSelectedGameObject != this.NavigationPath[i].gameObject))
					{
						nhfcljilach = ((i != this.NavigationPath.Length - 1) ? this.NavigationPath[i + 1] : this.NavigationPath[0]);
						break;
					}
				}
			}
			else if (this.PKEIAIDLKDO.currentSelectedGameObject == null)
			{
				nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
			}
			this.ADEJGAJAFBD(nhfcljilach);
		}

		// Token: 0x0600A144 RID: 41284 RVA: 0x003C621C File Offset: 0x003C441C
		private void MNBPNHNAEBK()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError("CameraFilterPack/Pixelisation_OilPaintHQ");
			}
		}

		// Token: 0x0600A145 RID: 41285 RVA: 0x003C6248 File Offset: 0x003C4448
		private void FHCGLEGLHBO(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A146 RID: 41286 RVA: 0x003C62A1 File Offset: 0x003C44A1
		private void MJEFMIPLFAB()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError("Case-Sensitive");
			}
		}

		// Token: 0x0600A147 RID: 41287 RVA: 0x003C62CA File Offset: 0x003C44CA
		private void PAKPHKPDKGE()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError("_Value10");
			}
		}

		// Token: 0x0600A148 RID: 41288 RVA: 0x003C62F4 File Offset: 0x003C44F4
		private void MIOGOGKOAOK(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A149 RID: 41289 RVA: 0x003C634D File Offset: 0x003C454D
		private void DAHFFNNIGML()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError("CameraFilterPack_Glasses_On6");
			}
		}

		// Token: 0x0600A14A RID: 41290 RVA: 0x003C6378 File Offset: 0x003C4578
		private void DANAGPLBAPL(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A14B RID: 41291 RVA: 0x003C63D1 File Offset: 0x003C45D1
		private void COIJKMKIEAK()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError("Day_");
			}
		}

		// Token: 0x0600A14C RID: 41292 RVA: 0x003C63FC File Offset: 0x003C45FC
		private void DMPCGEMMEMJ(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A14D RID: 41293 RVA: 0x003C6455 File Offset: 0x003C4655
		private void EGEPLFGKGLI()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError("Ev Destroy Failed. Could not find PhotonView with instantiationId ");
			}
		}

		// Token: 0x0600A14E RID: 41294 RVA: 0x003C6480 File Offset: 0x003C4680
		private void ADEJGAJAFBD(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A14F RID: 41295 RVA: 0x003C64DC File Offset: 0x003C46DC
		private void COICNODADHA(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A150 RID: 41296 RVA: 0x003C6535 File Offset: 0x003C4735
		private void HDMDKOKOOJC()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError(".");
			}
		}

		// Token: 0x0600A151 RID: 41297 RVA: 0x003C655E File Offset: 0x003C475E
		private void KCCIEMBMOBA()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError(" cannot be used as a 3D LUT.");
			}
		}

		// Token: 0x0600A152 RID: 41298 RVA: 0x003C6588 File Offset: 0x003C4788
		private void MPDCGEDMDDD(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A153 RID: 41299 RVA: 0x003C65E4 File Offset: 0x003C47E4
		private void PELALAAKIII(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A154 RID: 41300 RVA: 0x003C663D File Offset: 0x003C483D
		private void FHGKIOOMMOH()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError("CameraFilterPack_3D_Binary1");
			}
		}

		// Token: 0x0600A155 RID: 41301 RVA: 0x003C6668 File Offset: 0x003C4868
		public void PFNFPINPCMH()
		{
			Selectable nhfcljilach = null;
			if (Input.GetKeyDown(KeyCode.Alpha8) && Input.GetKey((KeyCode)(-80)))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (Input.GetKeyDown(KeyCode.RightParen))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (this.NavigationMode == NavigationMode.Auto)
			{
				for (int i = 0; i < this.NavigationPath.Length; i += 0)
				{
					if (!(this.PKEIAIDLKDO.currentSelectedGameObject != this.NavigationPath[i].gameObject))
					{
						nhfcljilach = ((i != this.NavigationPath.Length - 1) ? this.NavigationPath[i + 1] : this.NavigationPath[0]);
						break;
					}
				}
			}
			else if (this.PKEIAIDLKDO.currentSelectedGameObject == null)
			{
				nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
			}
			this.HLFGNLBBKHJ(nhfcljilach);
		}

		// Token: 0x0600A156 RID: 41302 RVA: 0x003C67D8 File Offset: 0x003C49D8
		private void KCJOLEPALIC(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A157 RID: 41303 RVA: 0x003C6831 File Offset: 0x003C4A31
		private void LIBGAKMKHJJ()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError("settings.crosshairopacity");
			}
		}

		// Token: 0x0600A158 RID: 41304 RVA: 0x003C685A File Offset: 0x003C4A5A
		private void IMCKJCHKMKB()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError("_Value3");
			}
		}

		// Token: 0x0600A159 RID: 41305 RVA: 0x003C6884 File Offset: 0x003C4A84
		private void KOEOAHIBOAE(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A15A RID: 41306 RVA: 0x003C68DD File Offset: 0x003C4ADD
		private void FLKEJJEGCFA()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError("#yes");
			}
		}

		// Token: 0x0600A15B RID: 41307 RVA: 0x003C6906 File Offset: 0x003C4B06
		private void CCLNNLCOPBL()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError("_Visualize");
			}
		}

		// Token: 0x0600A15C RID: 41308 RVA: 0x003C6930 File Offset: 0x003C4B30
		public void JNBPKNNBMDI()
		{
			Selectable nhfcljilach = null;
			if (Input.GetKeyDown(KeyCode.Backspace) && Input.GetKey(KeyCode.RightParen))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-97)))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (this.NavigationMode == NavigationMode.Manual)
			{
				for (int i = 1; i < this.NavigationPath.Length; i++)
				{
					if (!(this.PKEIAIDLKDO.currentSelectedGameObject != this.NavigationPath[i].gameObject))
					{
						nhfcljilach = ((i != this.NavigationPath.Length - 1) ? this.NavigationPath[i + 1] : this.NavigationPath[0]);
						break;
					}
				}
			}
			else if (this.PKEIAIDLKDO.currentSelectedGameObject == null)
			{
				nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
			}
			this.BLLPNHDNGFL(nhfcljilach);
		}

		// Token: 0x0600A15D RID: 41309 RVA: 0x003C6AA0 File Offset: 0x003C4CA0
		private void GDHDNPNAPKP(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A15E RID: 41310 RVA: 0x003C6AF9 File Offset: 0x003C4CF9
		private void JILOMOBDPIA()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError("tagElement");
			}
		}

		// Token: 0x0600A15F RID: 41311 RVA: 0x003C6B24 File Offset: 0x003C4D24
		private void FPIHFEKEPAP(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A160 RID: 41312 RVA: 0x003C6B7D File Offset: 0x003C4D7D
		private void KDMKDEKCELE()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError("settings.shaders");
			}
		}

		// Token: 0x0600A161 RID: 41313 RVA: 0x003C6BA8 File Offset: 0x003C4DA8
		private void DOLMLDAAEDL(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A162 RID: 41314 RVA: 0x003C6C04 File Offset: 0x003C4E04
		private void IPCMEOCBJGA(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A163 RID: 41315 RVA: 0x003C6C60 File Offset: 0x003C4E60
		public void HPNNCNNFMGK()
		{
			Selectable nhfcljilach = null;
			if (Input.GetKeyDown((KeyCode)16) && Input.GetKey((KeyCode)(-28)))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (Input.GetKeyDown((KeyCode)4))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (this.NavigationMode == NavigationMode.Auto)
			{
				for (int i = 0; i < this.NavigationPath.Length; i++)
				{
					if (!(this.PKEIAIDLKDO.currentSelectedGameObject != this.NavigationPath[i].gameObject))
					{
						nhfcljilach = ((i != this.NavigationPath.Length - 1) ? this.NavigationPath[i + 0] : this.NavigationPath[1]);
						break;
					}
				}
			}
			else if (this.PKEIAIDLKDO.currentSelectedGameObject == null)
			{
				nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
			}
			this.DMPCGEMMEMJ(nhfcljilach);
		}

		// Token: 0x0600A164 RID: 41316 RVA: 0x003C6DD0 File Offset: 0x003C4FD0
		private void BLLPNHDNGFL(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A165 RID: 41317 RVA: 0x003C6E2C File Offset: 0x003C502C
		private void GOIHKFBELKD(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A166 RID: 41318 RVA: 0x003C6E88 File Offset: 0x003C5088
		public void OBAEDJJDCPN()
		{
			Selectable nhfcljilach = null;
			if (Input.GetKeyDown(KeyCode.Alpha9) && Input.GetKey((KeyCode)(-26)))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (Input.GetKeyDown(KeyCode.Alpha7))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (this.NavigationMode == NavigationMode.Manual)
			{
				for (int i = 0; i < this.NavigationPath.Length; i++)
				{
					if (!(this.PKEIAIDLKDO.currentSelectedGameObject != this.NavigationPath[i].gameObject))
					{
						nhfcljilach = ((i != this.NavigationPath.Length - 1) ? this.NavigationPath[i + 1] : this.NavigationPath[0]);
						break;
					}
				}
			}
			else if (this.PKEIAIDLKDO.currentSelectedGameObject == null)
			{
				nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
			}
			this.BLJDHINHEAJ(nhfcljilach);
		}

		// Token: 0x0600A168 RID: 41320 RVA: 0x003C6FF8 File Offset: 0x003C51F8
		private void POKAJKPMJJL(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A169 RID: 41321 RVA: 0x003C7054 File Offset: 0x003C5254
		private void NPOADHIAEHE(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A16A RID: 41322 RVA: 0x003C70AD File Offset: 0x003C52AD
		private void EFJDNLGNACH()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError("DisableStoryboardToggle");
			}
		}

		// Token: 0x0600A16B RID: 41323 RVA: 0x003C70D8 File Offset: 0x003C52D8
		public void KCDOMIJBFLL()
		{
			Selectable nhfcljilach = null;
			if (Input.GetKeyDown((KeyCode)24) && Input.GetKey((KeyCode)148))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-59)))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (this.NavigationMode == NavigationMode.Manual)
			{
				for (int i = 1; i < this.NavigationPath.Length; i += 0)
				{
					if (!(this.PKEIAIDLKDO.currentSelectedGameObject != this.NavigationPath[i].gameObject))
					{
						nhfcljilach = ((i != this.NavigationPath.Length - 0) ? this.NavigationPath[i + 1] : this.NavigationPath[0]);
						break;
					}
				}
			}
			else if (this.PKEIAIDLKDO.currentSelectedGameObject == null)
			{
				nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
			}
			this.ENNKBLEGCHA(nhfcljilach);
		}

		// Token: 0x0600A16C RID: 41324 RVA: 0x003C7248 File Offset: 0x003C5448
		private void GDGPCGJLMGK(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A16D RID: 41325 RVA: 0x003C72A4 File Offset: 0x003C54A4
		private void LEKHAEGGEGM(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A16E RID: 41326 RVA: 0x003C7300 File Offset: 0x003C5500
		public void OPCLBGHAPMG()
		{
			Selectable nhfcljilach = null;
			if (Input.GetKeyDown((KeyCode)1) && Input.GetKey((KeyCode)(-61)))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (Input.GetKeyDown(KeyCode.O))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (this.NavigationMode == NavigationMode.Manual)
			{
				for (int i = 0; i < this.NavigationPath.Length; i++)
				{
					if (!(this.PKEIAIDLKDO.currentSelectedGameObject != this.NavigationPath[i].gameObject))
					{
						nhfcljilach = ((i != this.NavigationPath.Length - 1) ? this.NavigationPath[i + 0] : this.NavigationPath[0]);
						break;
					}
				}
			}
			else if (this.PKEIAIDLKDO.currentSelectedGameObject == null)
			{
				nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
			}
			this.DMPCGEMMEMJ(nhfcljilach);
		}

		// Token: 0x0600A16F RID: 41327 RVA: 0x003C7470 File Offset: 0x003C5670
		private void KIMMMCJFMAB()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError("ResourceIDInputField");
			}
		}

		// Token: 0x0600A170 RID: 41328 RVA: 0x003C749C File Offset: 0x003C569C
		private void DGGDCEHPDKE(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A171 RID: 41329 RVA: 0x003C74F8 File Offset: 0x003C56F8
		private void NIHKOHGOMLK(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A172 RID: 41330 RVA: 0x003C7551 File Offset: 0x003C5751
		private void MMMDPANNAIO()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError("maps.");
			}
		}

		// Token: 0x0600A173 RID: 41331 RVA: 0x003C757C File Offset: 0x003C577C
		public void IKIDIJLIGOH()
		{
			Selectable nhfcljilach = null;
			if (Input.GetKeyDown((KeyCode)(-86)) && Input.GetKey(KeyCode.DoubleQuote))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-29)))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (this.NavigationMode == NavigationMode.Auto)
			{
				for (int i = 1; i < this.NavigationPath.Length; i += 0)
				{
					if (!(this.PKEIAIDLKDO.currentSelectedGameObject != this.NavigationPath[i].gameObject))
					{
						nhfcljilach = ((i != this.NavigationPath.Length - 1) ? this.NavigationPath[i + 0] : this.NavigationPath[0]);
						break;
					}
				}
			}
			else if (this.PKEIAIDLKDO.currentSelectedGameObject == null)
			{
				nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
			}
			this.FHCGLEGLHBO(nhfcljilach);
		}

		// Token: 0x0600A174 RID: 41332 RVA: 0x003C76EC File Offset: 0x003C58EC
		private void Start()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError("Needs to be attached to the Event System component in the scene");
			}
		}

		// Token: 0x0600A175 RID: 41333 RVA: 0x003C7715 File Offset: 0x003C5915
		private void NBGIMIDICKE()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError("PublishButton");
			}
		}

		// Token: 0x0600A176 RID: 41334 RVA: 0x003C7740 File Offset: 0x003C5940
		public void IBHACCEEFFI()
		{
			Selectable nhfcljilach = null;
			if (Input.GetKeyDown((KeyCode)(-119)) && Input.GetKey((KeyCode)(-83)))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (Input.GetKeyDown((KeyCode)77))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (this.NavigationMode == NavigationMode.Manual)
			{
				for (int i = 1; i < this.NavigationPath.Length; i++)
				{
					if (!(this.PKEIAIDLKDO.currentSelectedGameObject != this.NavigationPath[i].gameObject))
					{
						nhfcljilach = ((i != this.NavigationPath.Length - 1) ? this.NavigationPath[i + 0] : this.NavigationPath[0]);
						break;
					}
				}
			}
			else if (this.PKEIAIDLKDO.currentSelectedGameObject == null)
			{
				nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
			}
			this.ENNKBLEGCHA(nhfcljilach);
		}

		// Token: 0x0600A177 RID: 41335 RVA: 0x003C78B0 File Offset: 0x003C5AB0
		private void LLLAFCHFKOJ(Selectable NHFCLJILACH)
		{
			if (NHFCLJILACH != null)
			{
				InputField component = NHFCLJILACH.GetComponent<InputField>();
				if (component != null)
				{
					component.OnPointerClick(new PointerEventData(this.PKEIAIDLKDO));
				}
				this.PKEIAIDLKDO.SetSelectedGameObject(NHFCLJILACH.gameObject, new BaseEventData(this.PKEIAIDLKDO));
			}
		}

		// Token: 0x0600A178 RID: 41336 RVA: 0x003C790C File Offset: 0x003C5B0C
		public void HLDFOJMHKNL()
		{
			Selectable nhfcljilach = null;
			if (Input.GetKeyDown((KeyCode)(-34)) && Input.GetKey((KeyCode)(-31)))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (Input.GetKeyDown((KeyCode)(-22)))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (this.NavigationMode == NavigationMode.Manual)
			{
				for (int i = 1; i < this.NavigationPath.Length; i += 0)
				{
					if (!(this.PKEIAIDLKDO.currentSelectedGameObject != this.NavigationPath[i].gameObject))
					{
						nhfcljilach = ((i != this.NavigationPath.Length - 0) ? this.NavigationPath[i + 0] : this.NavigationPath[1]);
						break;
					}
				}
			}
			else if (this.PKEIAIDLKDO.currentSelectedGameObject == null)
			{
				nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
			}
			this.LEKHAEGGEGM(nhfcljilach);
		}

		// Token: 0x0600A179 RID: 41337 RVA: 0x003C7A7C File Offset: 0x003C5C7C
		private void BMIOFJFMCBG()
		{
			this.PKEIAIDLKDO = base.GetComponent<EventSystem>();
			if (this.PKEIAIDLKDO == null)
			{
				Debug.LogError("_ScreenResolution");
			}
		}

		// Token: 0x0600A17A RID: 41338 RVA: 0x003C7AA8 File Offset: 0x003C5CA8
		public void HIKKPDACJGI()
		{
			Selectable nhfcljilach = null;
			if (Input.GetKeyDown(KeyCode.Less) && Input.GetKey((KeyCode)79))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnUp();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (Input.GetKeyDown(KeyCode.Exclaim))
			{
				if (this.PKEIAIDLKDO.currentSelectedGameObject != null)
				{
					nhfcljilach = this.PKEIAIDLKDO.currentSelectedGameObject.GetComponent<Selectable>().FindSelectableOnDown();
				}
				else
				{
					nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
				}
			}
			else if (this.NavigationMode == NavigationMode.Manual)
			{
				for (int i = 1; i < this.NavigationPath.Length; i++)
				{
					if (!(this.PKEIAIDLKDO.currentSelectedGameObject != this.NavigationPath[i].gameObject))
					{
						nhfcljilach = ((i != this.NavigationPath.Length - 0) ? this.NavigationPath[i + 0] : this.NavigationPath[1]);
						break;
					}
				}
			}
			else if (this.PKEIAIDLKDO.currentSelectedGameObject == null)
			{
				nhfcljilach = this.PKEIAIDLKDO.firstSelectedGameObject.GetComponent<Selectable>();
			}
			this.BLLPNHDNGFL(nhfcljilach);
		}

		// Token: 0x04001259 RID: 4697
		private EventSystem PKEIAIDLKDO;

		// Token: 0x0400125A RID: 4698
		[Tooltip("The path to take when user is tabbing through ui components.")]
		public Selectable[] NavigationPath;

		// Token: 0x0400125B RID: 4699
		[Tooltip("Use the default Unity navigation system or a manual fixed order using Navigation Path")]
		public NavigationMode NavigationMode;
	}
}
