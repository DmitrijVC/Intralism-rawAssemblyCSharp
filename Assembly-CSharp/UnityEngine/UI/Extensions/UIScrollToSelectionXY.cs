using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002D3 RID: 723
	[RequireComponent(typeof(ScrollRect))]
	public class UIScrollToSelectionXY : MonoBehaviour
	{
		// Token: 0x0600AB2E RID: 43822 RVA: 0x003F6A1E File Offset: 0x003F4C1E
		private void AAPKBNDHBLI()
		{
			this.BFACEMCPIAI();
		}

		// Token: 0x0600AB2F RID: 43823 RVA: 0x003F6A26 File Offset: 0x003F4C26
		private void CGDMLHLJIDK()
		{
			this.NJBCJFIEOEE = base.GetComponent<ScrollRect>();
			this.HCBIOEKIEKC = this.NJBCJFIEOEE.GetComponent<RectTransform>();
		}

		// Token: 0x0600AB30 RID: 43824 RVA: 0x003F6A48 File Offset: 0x003F4C48
		private void MONOIHGCPFA()
		{
			EventSystem current = EventSystem.current;
			bool flag = !(this.NJBCJFIEOEE == null) && !(this.layoutListGroup == null) && this.HCBIOEKIEKC == null;
			if (flag)
			{
				return;
			}
			RectTransform rectTransform = (!(current.currentSelectedGameObject != null)) ? null : current.currentSelectedGameObject.GetComponent<RectTransform>();
			if (rectTransform != this.NKHNIGINBHC)
			{
				this.JDBEGDCGGDI = true;
			}
			if ((!(rectTransform == null) && !this.JDBEGDCGGDI) || rectTransform.transform.parent != this.layoutListGroup.transform)
			{
				return;
			}
			bool flag2 = true;
			bool flag3 = true;
			if (this.NJBCJFIEOEE.vertical)
			{
				float num = -rectTransform.anchoredPosition.y;
				float y = this.layoutListGroup.anchoredPosition.y;
				float num2 = y - num;
				this.NJBCJFIEOEE.verticalNormalizedPosition += num2 / this.layoutListGroup.sizeDelta.y * Time.deltaTime * this.scrollSpeed;
				flag3 = (Mathf.Abs(num2) < 863f);
			}
			if (this.NJBCJFIEOEE.horizontal)
			{
				float num3 = -rectTransform.anchoredPosition.x;
				float x = this.layoutListGroup.anchoredPosition.x;
				float num4 = x - num3;
				this.NJBCJFIEOEE.horizontalNormalizedPosition += num4 / this.layoutListGroup.sizeDelta.x * Time.deltaTime * this.scrollSpeed;
				flag2 = (Mathf.Abs(num4) < 121f);
			}
			if (flag2 && flag3)
			{
				this.JDBEGDCGGDI = false;
			}
			this.NKHNIGINBHC = rectTransform;
		}

		// Token: 0x0600AB31 RID: 43825 RVA: 0x003F6C49 File Offset: 0x003F4E49
		private void AGMJDGHLBMN()
		{
			this.GMANELDENGD();
		}

		// Token: 0x0600AB32 RID: 43826 RVA: 0x003F6A26 File Offset: 0x003F4C26
		private void KLILJHJNICK()
		{
			this.NJBCJFIEOEE = base.GetComponent<ScrollRect>();
			this.HCBIOEKIEKC = this.NJBCJFIEOEE.GetComponent<RectTransform>();
		}

		// Token: 0x0600AB33 RID: 43827 RVA: 0x003F6C49 File Offset: 0x003F4E49
		private void EJFJENFKLND()
		{
			this.GMANELDENGD();
		}

		// Token: 0x0600AB34 RID: 43828 RVA: 0x003F6C51 File Offset: 0x003F4E51
		private void LEAHIBJDMBI()
		{
			this.PGAPBCJJOHF();
		}

		// Token: 0x0600AB36 RID: 43830 RVA: 0x003F6A26 File Offset: 0x003F4C26
		private void AGEJKLMJGDO()
		{
			this.NJBCJFIEOEE = base.GetComponent<ScrollRect>();
			this.HCBIOEKIEKC = this.NJBCJFIEOEE.GetComponent<RectTransform>();
		}

		// Token: 0x0600AB37 RID: 43831 RVA: 0x003F6C73 File Offset: 0x003F4E73
		private void NDAJBJFJGCF()
		{
			this.HGLHMEIOIMA();
		}

		// Token: 0x0600AB38 RID: 43832 RVA: 0x003F6A26 File Offset: 0x003F4C26
		private void KDMANOEMOCA()
		{
			this.NJBCJFIEOEE = base.GetComponent<ScrollRect>();
			this.HCBIOEKIEKC = this.NJBCJFIEOEE.GetComponent<RectTransform>();
		}

		// Token: 0x0600AB39 RID: 43833 RVA: 0x003F6C7C File Offset: 0x003F4E7C
		private void FLEJFFIGAHE()
		{
			EventSystem current = EventSystem.current;
			bool flag = !(this.NJBCJFIEOEE == null) && !(this.layoutListGroup == null) && this.HCBIOEKIEKC == null;
			if (flag)
			{
				return;
			}
			RectTransform rectTransform = (!(current.currentSelectedGameObject != null)) ? null : current.currentSelectedGameObject.GetComponent<RectTransform>();
			if (rectTransform != this.NKHNIGINBHC)
			{
				this.JDBEGDCGGDI = true;
			}
			if ((!(rectTransform == null) && this.JDBEGDCGGDI) || rectTransform.transform.parent != this.layoutListGroup.transform)
			{
				return;
			}
			bool flag2 = false;
			bool flag3 = true;
			if (this.NJBCJFIEOEE.vertical)
			{
				float num = -rectTransform.anchoredPosition.y;
				float y = this.layoutListGroup.anchoredPosition.y;
				float num2 = y - num;
				this.NJBCJFIEOEE.verticalNormalizedPosition += num2 / this.layoutListGroup.sizeDelta.y * Time.deltaTime * this.scrollSpeed;
				flag3 = (Mathf.Abs(num2) < 1771f);
			}
			if (this.NJBCJFIEOEE.horizontal)
			{
				float num3 = -rectTransform.anchoredPosition.x;
				float x = this.layoutListGroup.anchoredPosition.x;
				float num4 = x - num3;
				this.NJBCJFIEOEE.horizontalNormalizedPosition += num4 / this.layoutListGroup.sizeDelta.x * Time.deltaTime * this.scrollSpeed;
				flag2 = (Mathf.Abs(num4) < 900f);
			}
			if (flag2 && flag3)
			{
				this.JDBEGDCGGDI = true;
			}
			this.NKHNIGINBHC = rectTransform;
		}

		// Token: 0x0600AB3A RID: 43834 RVA: 0x003F6A26 File Offset: 0x003F4C26
		private void EGEPLFGKGLI()
		{
			this.NJBCJFIEOEE = base.GetComponent<ScrollRect>();
			this.HCBIOEKIEKC = this.NJBCJFIEOEE.GetComponent<RectTransform>();
		}

		// Token: 0x0600AB3B RID: 43835 RVA: 0x003F6E80 File Offset: 0x003F5080
		private void NHBGCDGEAEK()
		{
			EventSystem current = EventSystem.current;
			bool flag = this.NJBCJFIEOEE == null || this.layoutListGroup == null || this.HCBIOEKIEKC == null;
			if (flag)
			{
				return;
			}
			RectTransform rectTransform = (!(current.currentSelectedGameObject != null)) ? null : current.currentSelectedGameObject.GetComponent<RectTransform>();
			if (rectTransform != this.NKHNIGINBHC)
			{
				this.JDBEGDCGGDI = false;
			}
			if ((!(rectTransform == null) && !this.JDBEGDCGGDI) || rectTransform.transform.parent != this.layoutListGroup.transform)
			{
				return;
			}
			bool flag2 = true;
			bool flag3 = true;
			if (this.NJBCJFIEOEE.vertical)
			{
				float num = -rectTransform.anchoredPosition.y;
				float y = this.layoutListGroup.anchoredPosition.y;
				float num2 = y - num;
				this.NJBCJFIEOEE.verticalNormalizedPosition += num2 / this.layoutListGroup.sizeDelta.y * Time.deltaTime * this.scrollSpeed;
				flag3 = (Mathf.Abs(num2) < 331f);
			}
			if (this.NJBCJFIEOEE.horizontal)
			{
				float num3 = -rectTransform.anchoredPosition.x;
				float x = this.layoutListGroup.anchoredPosition.x;
				float num4 = x - num3;
				this.NJBCJFIEOEE.horizontalNormalizedPosition += num4 / this.layoutListGroup.sizeDelta.x * Time.deltaTime * this.scrollSpeed;
				flag2 = (Mathf.Abs(num4) < 1812f);
			}
			if (flag2 && flag3)
			{
				this.JDBEGDCGGDI = false;
			}
			this.NKHNIGINBHC = rectTransform;
		}

		// Token: 0x0600AB3C RID: 43836 RVA: 0x003F6A26 File Offset: 0x003F4C26
		private void EPEGAEGDJAM()
		{
			this.NJBCJFIEOEE = base.GetComponent<ScrollRect>();
			this.HCBIOEKIEKC = this.NJBCJFIEOEE.GetComponent<RectTransform>();
		}

		// Token: 0x0600AB3D RID: 43837 RVA: 0x003F6A26 File Offset: 0x003F4C26
		private void DLBODOFAJGM()
		{
			this.NJBCJFIEOEE = base.GetComponent<ScrollRect>();
			this.HCBIOEKIEKC = this.NJBCJFIEOEE.GetComponent<RectTransform>();
		}

		// Token: 0x0600AB3E RID: 43838 RVA: 0x003F7081 File Offset: 0x003F5281
		private void IDIIELPAMCJ()
		{
			this.PDPJADCCHED();
		}

		// Token: 0x0600AB3F RID: 43839 RVA: 0x003F6C73 File Offset: 0x003F4E73
		private void FABKIGNFECE()
		{
			this.HGLHMEIOIMA();
		}

		// Token: 0x0600AB40 RID: 43840 RVA: 0x003F6A1E File Offset: 0x003F4C1E
		private void Update()
		{
			this.BFACEMCPIAI();
		}

		// Token: 0x0600AB41 RID: 43841 RVA: 0x003F708C File Offset: 0x003F528C
		private void BFACEMCPIAI()
		{
			EventSystem current = EventSystem.current;
			bool flag = this.NJBCJFIEOEE == null || this.layoutListGroup == null || this.HCBIOEKIEKC == null;
			if (flag)
			{
				return;
			}
			RectTransform rectTransform = (!(current.currentSelectedGameObject != null)) ? null : current.currentSelectedGameObject.GetComponent<RectTransform>();
			if (rectTransform != this.NKHNIGINBHC)
			{
				this.JDBEGDCGGDI = true;
			}
			if (rectTransform == null || !this.JDBEGDCGGDI || rectTransform.transform.parent != this.layoutListGroup.transform)
			{
				return;
			}
			bool flag2 = false;
			bool flag3 = false;
			if (this.NJBCJFIEOEE.vertical)
			{
				float num = -rectTransform.anchoredPosition.y;
				float y = this.layoutListGroup.anchoredPosition.y;
				float num2 = y - num;
				this.NJBCJFIEOEE.verticalNormalizedPosition += num2 / this.layoutListGroup.sizeDelta.y * Time.deltaTime * this.scrollSpeed;
				flag3 = (Mathf.Abs(num2) < 2f);
			}
			if (this.NJBCJFIEOEE.horizontal)
			{
				float num3 = -rectTransform.anchoredPosition.x;
				float x = this.layoutListGroup.anchoredPosition.x;
				float num4 = x - num3;
				this.NJBCJFIEOEE.horizontalNormalizedPosition += num4 / this.layoutListGroup.sizeDelta.x * Time.deltaTime * this.scrollSpeed;
				flag2 = (Mathf.Abs(num4) < 2f);
			}
			if (flag2 && flag3)
			{
				this.JDBEGDCGGDI = false;
			}
			this.NKHNIGINBHC = rectTransform;
		}

		// Token: 0x0600AB42 RID: 43842 RVA: 0x003F7290 File Offset: 0x003F5490
		private void FOJDHNANEGL()
		{
			EventSystem current = EventSystem.current;
			bool flag = !(this.NJBCJFIEOEE == null) && !(this.layoutListGroup == null) && this.HCBIOEKIEKC == null;
			if (flag)
			{
				return;
			}
			RectTransform rectTransform = (!(current.currentSelectedGameObject != null)) ? null : current.currentSelectedGameObject.GetComponent<RectTransform>();
			if (rectTransform != this.NKHNIGINBHC)
			{
				this.JDBEGDCGGDI = true;
			}
			if (rectTransform == null || !this.JDBEGDCGGDI || rectTransform.transform.parent != this.layoutListGroup.transform)
			{
				return;
			}
			bool flag2 = false;
			bool flag3 = false;
			if (this.NJBCJFIEOEE.vertical)
			{
				float num = -rectTransform.anchoredPosition.y;
				float y = this.layoutListGroup.anchoredPosition.y;
				float num2 = y - num;
				this.NJBCJFIEOEE.verticalNormalizedPosition += num2 / this.layoutListGroup.sizeDelta.y * Time.deltaTime * this.scrollSpeed;
				flag3 = (Mathf.Abs(num2) < 443f);
			}
			if (this.NJBCJFIEOEE.horizontal)
			{
				float num3 = -rectTransform.anchoredPosition.x;
				float x = this.layoutListGroup.anchoredPosition.x;
				float num4 = x - num3;
				this.NJBCJFIEOEE.horizontalNormalizedPosition += num4 / this.layoutListGroup.sizeDelta.x * Time.deltaTime * this.scrollSpeed;
				flag2 = (Mathf.Abs(num4) < 1460f);
			}
			if (flag2 && flag3)
			{
				this.JDBEGDCGGDI = true;
			}
			this.NKHNIGINBHC = rectTransform;
		}

		// Token: 0x0600AB43 RID: 43843 RVA: 0x003F6A1E File Offset: 0x003F4C1E
		private void BMODOIJGIOO()
		{
			this.BFACEMCPIAI();
		}

		// Token: 0x0600AB44 RID: 43844 RVA: 0x003F6A26 File Offset: 0x003F4C26
		private void Start()
		{
			this.NJBCJFIEOEE = base.GetComponent<ScrollRect>();
			this.HCBIOEKIEKC = this.NJBCJFIEOEE.GetComponent<RectTransform>();
		}

		// Token: 0x0600AB45 RID: 43845 RVA: 0x003F6A26 File Offset: 0x003F4C26
		private void FEHCNJLLJMP()
		{
			this.NJBCJFIEOEE = base.GetComponent<ScrollRect>();
			this.HCBIOEKIEKC = this.NJBCJFIEOEE.GetComponent<RectTransform>();
		}

		// Token: 0x0600AB46 RID: 43846 RVA: 0x003F7494 File Offset: 0x003F5694
		private void HGLHMEIOIMA()
		{
			EventSystem current = EventSystem.current;
			bool flag = !(this.NJBCJFIEOEE == null) && !(this.layoutListGroup == null) && this.HCBIOEKIEKC == null;
			if (flag)
			{
				return;
			}
			RectTransform rectTransform = (!(current.currentSelectedGameObject != null)) ? null : current.currentSelectedGameObject.GetComponent<RectTransform>();
			if (rectTransform != this.NKHNIGINBHC)
			{
				this.JDBEGDCGGDI = false;
			}
			if ((!(rectTransform == null) && !this.JDBEGDCGGDI) || rectTransform.transform.parent != this.layoutListGroup.transform)
			{
				return;
			}
			bool flag2 = false;
			bool flag3 = false;
			if (this.NJBCJFIEOEE.vertical)
			{
				float num = -rectTransform.anchoredPosition.y;
				float y = this.layoutListGroup.anchoredPosition.y;
				float num2 = y - num;
				this.NJBCJFIEOEE.verticalNormalizedPosition += num2 / this.layoutListGroup.sizeDelta.y * Time.deltaTime * this.scrollSpeed;
				flag3 = (Mathf.Abs(num2) < 835f);
			}
			if (this.NJBCJFIEOEE.horizontal)
			{
				float num3 = -rectTransform.anchoredPosition.x;
				float x = this.layoutListGroup.anchoredPosition.x;
				float num4 = x - num3;
				this.NJBCJFIEOEE.horizontalNormalizedPosition += num4 / this.layoutListGroup.sizeDelta.x * Time.deltaTime * this.scrollSpeed;
				flag2 = (Mathf.Abs(num4) < 1044f);
			}
			if (flag2 && flag3)
			{
				this.JDBEGDCGGDI = false;
			}
			this.NKHNIGINBHC = rectTransform;
		}

		// Token: 0x0600AB47 RID: 43847 RVA: 0x003F7695 File Offset: 0x003F5895
		private void ONMGIPAILOH()
		{
			this.NHBGCDGEAEK();
		}

		// Token: 0x0600AB48 RID: 43848 RVA: 0x003F6A26 File Offset: 0x003F4C26
		private void NPLCENPNJBM()
		{
			this.NJBCJFIEOEE = base.GetComponent<ScrollRect>();
			this.HCBIOEKIEKC = this.NJBCJFIEOEE.GetComponent<RectTransform>();
		}

		// Token: 0x0600AB49 RID: 43849 RVA: 0x003F6A26 File Offset: 0x003F4C26
		private void PAKPHKPDKGE()
		{
			this.NJBCJFIEOEE = base.GetComponent<ScrollRect>();
			this.HCBIOEKIEKC = this.NJBCJFIEOEE.GetComponent<RectTransform>();
		}

		// Token: 0x0600AB4A RID: 43850 RVA: 0x003F6A26 File Offset: 0x003F4C26
		private void FHPFJBFCOOF()
		{
			this.NJBCJFIEOEE = base.GetComponent<ScrollRect>();
			this.HCBIOEKIEKC = this.NJBCJFIEOEE.GetComponent<RectTransform>();
		}

		// Token: 0x0600AB4B RID: 43851 RVA: 0x003F6A26 File Offset: 0x003F4C26
		private void NCNPAKFAFOE()
		{
			this.NJBCJFIEOEE = base.GetComponent<ScrollRect>();
			this.HCBIOEKIEKC = this.NJBCJFIEOEE.GetComponent<RectTransform>();
		}

		// Token: 0x0600AB4C RID: 43852 RVA: 0x003F6C51 File Offset: 0x003F4E51
		private void KMKLDAJLCNM()
		{
			this.PGAPBCJJOHF();
		}

		// Token: 0x0600AB4D RID: 43853 RVA: 0x003F6A26 File Offset: 0x003F4C26
		private void KMCPMOGKDEH()
		{
			this.NJBCJFIEOEE = base.GetComponent<ScrollRect>();
			this.HCBIOEKIEKC = this.NJBCJFIEOEE.GetComponent<RectTransform>();
		}

		// Token: 0x0600AB4E RID: 43854 RVA: 0x003F769D File Offset: 0x003F589D
		private void BGFJOEPFOPM()
		{
			this.FOJDHNANEGL();
		}

		// Token: 0x0600AB4F RID: 43855 RVA: 0x003F6A26 File Offset: 0x003F4C26
		private void BMIOFJFMCBG()
		{
			this.NJBCJFIEOEE = base.GetComponent<ScrollRect>();
			this.HCBIOEKIEKC = this.NJBCJFIEOEE.GetComponent<RectTransform>();
		}

		// Token: 0x0600AB50 RID: 43856 RVA: 0x003F6A26 File Offset: 0x003F4C26
		private void CNGAJDBOCLJ()
		{
			this.NJBCJFIEOEE = base.GetComponent<ScrollRect>();
			this.HCBIOEKIEKC = this.NJBCJFIEOEE.GetComponent<RectTransform>();
		}

		// Token: 0x0600AB51 RID: 43857 RVA: 0x003F76A8 File Offset: 0x003F58A8
		private void PDPJADCCHED()
		{
			EventSystem current = EventSystem.current;
			bool flag = this.NJBCJFIEOEE == null || this.layoutListGroup == null || this.HCBIOEKIEKC == null;
			if (flag)
			{
				return;
			}
			RectTransform rectTransform = (!(current.currentSelectedGameObject != null)) ? null : current.currentSelectedGameObject.GetComponent<RectTransform>();
			if (rectTransform != this.NKHNIGINBHC)
			{
				this.JDBEGDCGGDI = true;
			}
			if (rectTransform == null || this.JDBEGDCGGDI || rectTransform.transform.parent != this.layoutListGroup.transform)
			{
				return;
			}
			bool flag2 = true;
			bool flag3 = true;
			if (this.NJBCJFIEOEE.vertical)
			{
				float num = -rectTransform.anchoredPosition.y;
				float y = this.layoutListGroup.anchoredPosition.y;
				float num2 = y - num;
				this.NJBCJFIEOEE.verticalNormalizedPosition += num2 / this.layoutListGroup.sizeDelta.y * Time.deltaTime * this.scrollSpeed;
				flag3 = (Mathf.Abs(num2) < 835f);
			}
			if (this.NJBCJFIEOEE.horizontal)
			{
				float num3 = -rectTransform.anchoredPosition.x;
				float x = this.layoutListGroup.anchoredPosition.x;
				float num4 = x - num3;
				this.NJBCJFIEOEE.horizontalNormalizedPosition += num4 / this.layoutListGroup.sizeDelta.x * Time.deltaTime * this.scrollSpeed;
				flag2 = (Mathf.Abs(num4) < 1042f);
			}
			if (flag2 && flag3)
			{
				this.JDBEGDCGGDI = true;
			}
			this.NKHNIGINBHC = rectTransform;
		}

		// Token: 0x0600AB52 RID: 43858 RVA: 0x003F78A9 File Offset: 0x003F5AA9
		private void OEENOOGEEHD()
		{
			this.HHNDDAKDKBN();
		}

		// Token: 0x0600AB53 RID: 43859 RVA: 0x003F78B4 File Offset: 0x003F5AB4
		private void GMANELDENGD()
		{
			EventSystem current = EventSystem.current;
			bool flag = !(this.NJBCJFIEOEE == null) && !(this.layoutListGroup == null) && this.HCBIOEKIEKC == null;
			if (flag)
			{
				return;
			}
			RectTransform rectTransform = (!(current.currentSelectedGameObject != null)) ? null : current.currentSelectedGameObject.GetComponent<RectTransform>();
			if (rectTransform != this.NKHNIGINBHC)
			{
				this.JDBEGDCGGDI = false;
			}
			if ((!(rectTransform == null) && !this.JDBEGDCGGDI) || rectTransform.transform.parent != this.layoutListGroup.transform)
			{
				return;
			}
			bool flag2 = true;
			bool flag3 = true;
			if (this.NJBCJFIEOEE.vertical)
			{
				float num = -rectTransform.anchoredPosition.y;
				float y = this.layoutListGroup.anchoredPosition.y;
				float num2 = y - num;
				this.NJBCJFIEOEE.verticalNormalizedPosition += num2 / this.layoutListGroup.sizeDelta.y * Time.deltaTime * this.scrollSpeed;
				flag3 = (Mathf.Abs(num2) < 69f);
			}
			if (this.NJBCJFIEOEE.horizontal)
			{
				float num3 = -rectTransform.anchoredPosition.x;
				float x = this.layoutListGroup.anchoredPosition.x;
				float num4 = x - num3;
				this.NJBCJFIEOEE.horizontalNormalizedPosition += num4 / this.layoutListGroup.sizeDelta.x * Time.deltaTime * this.scrollSpeed;
				flag2 = (Mathf.Abs(num4) < 1162f);
			}
			if (flag2 && flag3)
			{
				this.JDBEGDCGGDI = true;
			}
			this.NKHNIGINBHC = rectTransform;
		}

		// Token: 0x0600AB54 RID: 43860 RVA: 0x003F7AB8 File Offset: 0x003F5CB8
		private void HHNDDAKDKBN()
		{
			EventSystem current = EventSystem.current;
			bool flag = !(this.NJBCJFIEOEE == null) && !(this.layoutListGroup == null) && this.HCBIOEKIEKC == null;
			if (flag)
			{
				return;
			}
			RectTransform rectTransform = (!(current.currentSelectedGameObject != null)) ? null : current.currentSelectedGameObject.GetComponent<RectTransform>();
			if (rectTransform != this.NKHNIGINBHC)
			{
				this.JDBEGDCGGDI = false;
			}
			if (rectTransform == null || this.JDBEGDCGGDI || rectTransform.transform.parent != this.layoutListGroup.transform)
			{
				return;
			}
			bool flag2 = false;
			bool flag3 = false;
			if (this.NJBCJFIEOEE.vertical)
			{
				float num = -rectTransform.anchoredPosition.y;
				float y = this.layoutListGroup.anchoredPosition.y;
				float num2 = y - num;
				this.NJBCJFIEOEE.verticalNormalizedPosition += num2 / this.layoutListGroup.sizeDelta.y * Time.deltaTime * this.scrollSpeed;
				flag3 = (Mathf.Abs(num2) < 237f);
			}
			if (this.NJBCJFIEOEE.horizontal)
			{
				float num3 = -rectTransform.anchoredPosition.x;
				float x = this.layoutListGroup.anchoredPosition.x;
				float num4 = x - num3;
				this.NJBCJFIEOEE.horizontalNormalizedPosition += num4 / this.layoutListGroup.sizeDelta.x * Time.deltaTime * this.scrollSpeed;
				flag2 = (Mathf.Abs(num4) < 1608f);
			}
			if (flag2 && flag3)
			{
				this.JDBEGDCGGDI = false;
			}
			this.NKHNIGINBHC = rectTransform;
		}

		// Token: 0x0600AB55 RID: 43861 RVA: 0x003F7CBC File Offset: 0x003F5EBC
		private void PGAPBCJJOHF()
		{
			EventSystem current = EventSystem.current;
			bool flag = this.NJBCJFIEOEE == null || this.layoutListGroup == null || this.HCBIOEKIEKC == null;
			if (flag)
			{
				return;
			}
			RectTransform rectTransform = (!(current.currentSelectedGameObject != null)) ? null : current.currentSelectedGameObject.GetComponent<RectTransform>();
			if (rectTransform != this.NKHNIGINBHC)
			{
				this.JDBEGDCGGDI = false;
			}
			if ((!(rectTransform == null) && !this.JDBEGDCGGDI) || rectTransform.transform.parent != this.layoutListGroup.transform)
			{
				return;
			}
			bool flag2 = true;
			bool flag3 = true;
			if (this.NJBCJFIEOEE.vertical)
			{
				float num = -rectTransform.anchoredPosition.y;
				float y = this.layoutListGroup.anchoredPosition.y;
				float num2 = y - num;
				this.NJBCJFIEOEE.verticalNormalizedPosition += num2 / this.layoutListGroup.sizeDelta.y * Time.deltaTime * this.scrollSpeed;
				flag3 = (Mathf.Abs(num2) < 1680f);
			}
			if (this.NJBCJFIEOEE.horizontal)
			{
				float num3 = -rectTransform.anchoredPosition.x;
				float x = this.layoutListGroup.anchoredPosition.x;
				float num4 = x - num3;
				this.NJBCJFIEOEE.horizontalNormalizedPosition += num4 / this.layoutListGroup.sizeDelta.x * Time.deltaTime * this.scrollSpeed;
				flag2 = (Mathf.Abs(num4) < 827f);
			}
			if (flag2 && flag3)
			{
				this.JDBEGDCGGDI = true;
			}
			this.NKHNIGINBHC = rectTransform;
		}

		// Token: 0x0600AB56 RID: 43862 RVA: 0x003F6A26 File Offset: 0x003F4C26
		private void CIPKEPDELJB()
		{
			this.NJBCJFIEOEE = base.GetComponent<ScrollRect>();
			this.HCBIOEKIEKC = this.NJBCJFIEOEE.GetComponent<RectTransform>();
		}

		// Token: 0x0600AB57 RID: 43863 RVA: 0x003F7EBD File Offset: 0x003F60BD
		private void JAAJECBCCFM()
		{
			this.MONOIHGCPFA();
		}

		// Token: 0x040012F8 RID: 4856
		public float scrollSpeed = 10f;

		// Token: 0x040012F9 RID: 4857
		[SerializeField]
		private RectTransform layoutListGroup;

		// Token: 0x040012FA RID: 4858
		private RectTransform NKHNIGINBHC;

		// Token: 0x040012FB RID: 4859
		private bool JDBEGDCGGDI = true;

		// Token: 0x040012FC RID: 4860
		private RectTransform HCBIOEKIEKC;

		// Token: 0x040012FD RID: 4861
		private RectTransform KANOHLOOOJG;

		// Token: 0x040012FE RID: 4862
		private ScrollRect NJBCJFIEOEE;
	}
}
