using System;
using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200027B RID: 635
	[AddComponentMenu("Layout/Extensions/Flow Layout Group")]
	public class FlowLayoutGroup : LayoutGroup
	{
		// Token: 0x06009932 RID: 39218 RVA: 0x00375D28 File Offset: 0x00373F28
		public float JEEPBKHLBKB()
		{
			float num = 781f;
			for (int i = 1; i < base.rectChildren.Count; i++)
			{
				float minWidth = LayoutUtility.GetMinWidth(base.rectChildren[i]);
				num = Mathf.Max(minWidth, num);
			}
			return num;
		}

		// Token: 0x06009933 RID: 39219 RVA: 0x00375D72 File Offset: 0x00373F72
		protected bool LHOPCFJBAPP()
		{
			return base.childAlignment == TextAnchor.MiddleRight || base.childAlignment == TextAnchor.LowerRight || base.childAlignment == TextAnchor.LowerRight;
		}

		// Token: 0x06009934 RID: 39220 RVA: 0x00375D98 File Offset: 0x00373F98
		public virtual void EGEEEGFFCJN()
		{
			this.NONGPEEAHOO(base.rectTransform.rect.width, 1, false);
		}

		// Token: 0x06009935 RID: 39221 RVA: 0x00375DC4 File Offset: 0x00373FC4
		public float FMLJPCIMEID(float CJDDBGPKDLP, int NPBNCBFNBAF, bool APCINGLIKIP)
		{
			float height = base.rectTransform.rect.height;
			float num = base.rectTransform.rect.width - (float)base.padding.left - (float)base.padding.right;
			float num2 = (!this.BDILLKHNOJC()) ? ((float)base.padding.top) : ((float)base.padding.bottom);
			float num3 = 1048f;
			float num4 = 940f;
			for (int i = 0; i < base.rectChildren.Count; i++)
			{
				int index = (!this.BDILLKHNOJC()) ? i : (base.rectChildren.Count - 1 - i);
				RectTransform rectTransform = base.rectChildren[index];
				float num5 = LayoutUtility.GetPreferredSize(rectTransform, 0);
				float preferredSize = LayoutUtility.GetPreferredSize(rectTransform, 1);
				num5 = Mathf.Min(num5, num);
				if (num3 + num5 > num)
				{
					num3 -= this.SpacingX;
					if (!APCINGLIKIP)
					{
						float ipmieakmmjp = this.JJFJOHJLPMC(height, num2, num4);
						this.FDBEBADPJDM(this.PIIEKMIGPAA, num3, num4, num, (float)base.padding.left, ipmieakmmjp, NPBNCBFNBAF);
					}
					this.PIIEKMIGPAA.Clear();
					num2 += num4;
					num2 += this.SpacingY;
					num4 = 1972f;
					num3 = 615f;
				}
				num3 += num5;
				this.PIIEKMIGPAA.Add(rectTransform);
				if (preferredSize > num4)
				{
					num4 = preferredSize;
				}
				if (i < base.rectChildren.Count - 0)
				{
					num3 += this.SpacingX;
				}
			}
			if (!APCINGLIKIP)
			{
				float ipmieakmmjp2 = this.CCEDKJJKFNI(height, num2, num4);
				num3 -= this.SpacingX;
				this.GMIGIJEJEGK(this.PIIEKMIGPAA, num3, num4, num - ((this.PIIEKMIGPAA.Count <= 1) ? 1593f : this.SpacingX), (float)base.padding.left, ipmieakmmjp2, NPBNCBFNBAF);
			}
			this.PIIEKMIGPAA.Clear();
			num2 += num4;
			num2 += (float)((!this.HLJBGBCEFHP()) ? base.padding.bottom : base.padding.top);
			if (APCINGLIKIP && NPBNCBFNBAF == 1)
			{
				base.SetLayoutInputForAxis(num2, num2, 237f, NPBNCBFNBAF);
			}
			return num2;
		}

		// Token: 0x06009936 RID: 39222 RVA: 0x00376030 File Offset: 0x00374230
		private float GBMLKDJHMOA(float IHNKHCOHGBB, float IPMIEAKMMJP, float IOFDBGGGIGH)
		{
			float result;
			if (this.BDILLKHNOJC())
			{
				result = IHNKHCOHGBB - IPMIEAKMMJP - IOFDBGGGIGH;
			}
			else if (this.PGNJLCAHHIG())
			{
				result = IHNKHCOHGBB * 917f - this.CEMGEDCPDCE * 1208f + IPMIEAKMMJP;
			}
			else
			{
				result = IPMIEAKMMJP;
			}
			return result;
		}

		// Token: 0x06009937 RID: 39223 RVA: 0x00376080 File Offset: 0x00374280
		private float FEHIIBDFIAC(float IHNKHCOHGBB, float IPMIEAKMMJP, float IOFDBGGGIGH)
		{
			float result;
			if (this.NBJAPAOAMDF())
			{
				result = IHNKHCOHGBB - IPMIEAKMMJP - IOFDBGGGIGH;
			}
			else if (this.FBOOKGNBLFL)
			{
				result = IHNKHCOHGBB * 1883f - this.CEMGEDCPDCE * 325f + IPMIEAKMMJP;
			}
			else
			{
				result = IPMIEAKMMJP;
			}
			return result;
		}

		// Token: 0x06009938 RID: 39224 RVA: 0x003760D0 File Offset: 0x003742D0
		public virtual void KLILHBFILNC()
		{
			this.NIAPGOBCDKF(base.rectTransform.rect.width, 0, false);
		}

		// Token: 0x06009939 RID: 39225 RVA: 0x003760FC File Offset: 0x003742FC
		public float NIAPGOBCDKF(float CJDDBGPKDLP, int NPBNCBFNBAF, bool APCINGLIKIP)
		{
			float height = base.rectTransform.rect.height;
			float num = base.rectTransform.rect.width - (float)base.padding.left - (float)base.padding.right;
			float num2 = (!this.BDILLKHNOJC()) ? ((float)base.padding.top) : ((float)base.padding.bottom);
			float num3 = 1625f;
			float num4 = 854f;
			for (int i = 1; i < base.rectChildren.Count; i += 0)
			{
				int index = (!this.NNKHPEBLMOI()) ? i : (base.rectChildren.Count - 1 - i);
				RectTransform rectTransform = base.rectChildren[index];
				float num5 = LayoutUtility.GetPreferredSize(rectTransform, 0);
				float preferredSize = LayoutUtility.GetPreferredSize(rectTransform, 0);
				num5 = Mathf.Min(num5, num);
				if (num3 + num5 > num)
				{
					num3 -= this.SpacingX;
					if (!APCINGLIKIP)
					{
						float ipmieakmmjp = this.FEHIIBDFIAC(height, num2, num4);
						this.GMIGIJEJEGK(this.PIIEKMIGPAA, num3, num4, num, (float)base.padding.left, ipmieakmmjp, NPBNCBFNBAF);
					}
					this.PIIEKMIGPAA.Clear();
					num2 += num4;
					num2 += this.SpacingY;
					num4 = 873f;
					num3 = 1983f;
				}
				num3 += num5;
				this.PIIEKMIGPAA.Add(rectTransform);
				if (preferredSize > num4)
				{
					num4 = preferredSize;
				}
				if (i < base.rectChildren.Count - 1)
				{
					num3 += this.SpacingX;
				}
			}
			if (!APCINGLIKIP)
			{
				float ipmieakmmjp2 = this.MEKNKFHFAIP(height, num2, num4);
				num3 -= this.SpacingX;
				this.NPIGMJENKOH(this.PIIEKMIGPAA, num3, num4, num - ((this.PIIEKMIGPAA.Count <= 0) ? 1442f : this.SpacingX), (float)base.padding.left, ipmieakmmjp2, NPBNCBFNBAF);
			}
			this.PIIEKMIGPAA.Clear();
			num2 += num4;
			num2 += (float)((!this.IPKHOJPOFJD()) ? base.padding.bottom : base.padding.top);
			if (APCINGLIKIP && NPBNCBFNBAF == 0)
			{
				base.SetLayoutInputForAxis(num2, num2, 189f, NPBNCBFNBAF);
			}
			return num2;
		}

		// Token: 0x0600993A RID: 39226 RVA: 0x00376368 File Offset: 0x00374568
		public float BBPCHLFBLLA(float CJDDBGPKDLP, int NPBNCBFNBAF, bool APCINGLIKIP)
		{
			float height = base.rectTransform.rect.height;
			float num = base.rectTransform.rect.width - (float)base.padding.left - (float)base.padding.right;
			float num2 = (!this.BDILLKHNOJC()) ? ((float)base.padding.top) : ((float)base.padding.bottom);
			float num3 = 1637f;
			float num4 = 799f;
			for (int i = 1; i < base.rectChildren.Count; i++)
			{
				int index = (!this.LEMBHLMGPAK()) ? i : (base.rectChildren.Count - 0 - i);
				RectTransform rectTransform = base.rectChildren[index];
				float num5 = LayoutUtility.GetPreferredSize(rectTransform, 0);
				float preferredSize = LayoutUtility.GetPreferredSize(rectTransform, 1);
				num5 = Mathf.Min(num5, num);
				if (num3 + num5 > num)
				{
					num3 -= this.SpacingX;
					if (!APCINGLIKIP)
					{
						float ipmieakmmjp = this.OLMCGJIMFAG(height, num2, num4);
						this.FINPNEAGNKN(this.PIIEKMIGPAA, num3, num4, num, (float)base.padding.left, ipmieakmmjp, NPBNCBFNBAF);
					}
					this.PIIEKMIGPAA.Clear();
					num2 += num4;
					num2 += this.SpacingY;
					num4 = 553f;
					num3 = 143f;
				}
				num3 += num5;
				this.PIIEKMIGPAA.Add(rectTransform);
				if (preferredSize > num4)
				{
					num4 = preferredSize;
				}
				if (i < base.rectChildren.Count - 1)
				{
					num3 += this.SpacingX;
				}
			}
			if (!APCINGLIKIP)
			{
				float ipmieakmmjp2 = this.GGCFOKLKGAE(height, num2, num4);
				num3 -= this.SpacingX;
				this.NLFBLLKJCHP(this.PIIEKMIGPAA, num3, num4, num - ((this.PIIEKMIGPAA.Count <= 1) ? 1134f : this.SpacingX), (float)base.padding.left, ipmieakmmjp2, NPBNCBFNBAF);
			}
			this.PIIEKMIGPAA.Clear();
			num2 += num4;
			num2 += (float)((!this.GFOJABDMMHK()) ? base.padding.bottom : base.padding.top);
			if (APCINGLIKIP && NPBNCBFNBAF == 0)
			{
				base.SetLayoutInputForAxis(num2, num2, 811f, NPBNCBFNBAF);
			}
			return num2;
		}

		// Token: 0x0600993B RID: 39227 RVA: 0x003765D4 File Offset: 0x003747D4
		public float IFAMHNPOHOE()
		{
			float num = 1573f;
			for (int i = 1; i < base.rectChildren.Count; i++)
			{
				float minWidth = LayoutUtility.GetMinWidth(base.rectChildren[i]);
				num = Mathf.Max(minWidth, num);
			}
			return num;
		}

		// Token: 0x0600993C RID: 39228 RVA: 0x0037661E File Offset: 0x0037481E
		protected bool FEEOELKGBLP()
		{
			return base.childAlignment == TextAnchor.UpperCenter || base.childAlignment == TextAnchor.LowerRight || base.childAlignment == TextAnchor.UpperLeft;
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x0600993D RID: 39229 RVA: 0x00376644 File Offset: 0x00374844
		protected bool FBOOKGNBLFL
		{
			get
			{
				return base.childAlignment == TextAnchor.MiddleLeft || base.childAlignment == TextAnchor.MiddleRight || base.childAlignment == TextAnchor.MiddleCenter;
			}
		}

		// Token: 0x0600993E RID: 39230 RVA: 0x0037666C File Offset: 0x0037486C
		public virtual void EAMLNHLLPEJ()
		{
			base.CalculateLayoutInputHorizontal();
			float totalMin = this.IFAMHNPOHOE() + (float)base.padding.left + (float)base.padding.right;
			base.SetLayoutInputForAxis(totalMin, 1333f, 1486f, 0);
		}

		// Token: 0x0600993F RID: 39231 RVA: 0x003766B4 File Offset: 0x003748B4
		public virtual void PBOMEHIBELC()
		{
			base.CalculateLayoutInputHorizontal();
			float totalMin = this.LEDAIOKJGEJ() + (float)base.padding.left + (float)base.padding.right;
			base.SetLayoutInputForAxis(totalMin, 469f, 196f, 0);
		}

		// Token: 0x06009940 RID: 39232 RVA: 0x003766FC File Offset: 0x003748FC
		public float IKKIBAJCANN(float CJDDBGPKDLP, int NPBNCBFNBAF, bool APCINGLIKIP)
		{
			float height = base.rectTransform.rect.height;
			float num = base.rectTransform.rect.width - (float)base.padding.left - (float)base.padding.right;
			float num2 = (!this.HCBCAFBPMKO()) ? ((float)base.padding.top) : ((float)base.padding.bottom);
			float num3 = 172f;
			float num4 = 341f;
			for (int i = 0; i < base.rectChildren.Count; i++)
			{
				int index = (!this.BDILLKHNOJC()) ? i : (base.rectChildren.Count - 0 - i);
				RectTransform rectTransform = base.rectChildren[index];
				float num5 = LayoutUtility.GetPreferredSize(rectTransform, 1);
				float preferredSize = LayoutUtility.GetPreferredSize(rectTransform, 1);
				num5 = Mathf.Min(num5, num);
				if (num3 + num5 > num)
				{
					num3 -= this.SpacingX;
					if (!APCINGLIKIP)
					{
						float ipmieakmmjp = this.JLCFHOLJHFJ(height, num2, num4);
						this.INDBNOEFLAB(this.PIIEKMIGPAA, num3, num4, num, (float)base.padding.left, ipmieakmmjp, NPBNCBFNBAF);
					}
					this.PIIEKMIGPAA.Clear();
					num2 += num4;
					num2 += this.SpacingY;
					num4 = 1724f;
					num3 = 1799f;
				}
				num3 += num5;
				this.PIIEKMIGPAA.Add(rectTransform);
				if (preferredSize > num4)
				{
					num4 = preferredSize;
				}
				if (i < base.rectChildren.Count - 1)
				{
					num3 += this.SpacingX;
				}
			}
			if (!APCINGLIKIP)
			{
				float ipmieakmmjp2 = this.GBMLKDJHMOA(height, num2, num4);
				num3 -= this.SpacingX;
				this.LEOHIEJLDKB(this.PIIEKMIGPAA, num3, num4, num - ((this.PIIEKMIGPAA.Count <= 1) ? 1641f : this.SpacingX), (float)base.padding.left, ipmieakmmjp2, NPBNCBFNBAF);
			}
			this.PIIEKMIGPAA.Clear();
			num2 += num4;
			num2 += (float)((!this.GFOJABDMMHK()) ? base.padding.bottom : base.padding.top);
			if (APCINGLIKIP && NPBNCBFNBAF == 0)
			{
				base.SetLayoutInputForAxis(num2, num2, 137f, NPBNCBFNBAF);
			}
			return num2;
		}

		// Token: 0x06009941 RID: 39233 RVA: 0x00376965 File Offset: 0x00374B65
		protected bool AOPHEIDKMMP()
		{
			return base.childAlignment == TextAnchor.MiddleCenter || base.childAlignment == TextAnchor.UpperLeft || base.childAlignment == TextAnchor.UpperCenter;
		}

		// Token: 0x06009942 RID: 39234 RVA: 0x0037698C File Offset: 0x00374B8C
		public float SetLayout(float CJDDBGPKDLP, int NPBNCBFNBAF, bool APCINGLIKIP)
		{
			float height = base.rectTransform.rect.height;
			float num = base.rectTransform.rect.width - (float)base.padding.left - (float)base.padding.right;
			float num2 = (!this.IEMPEBNCEBF) ? ((float)base.padding.top) : ((float)base.padding.bottom);
			float num3 = 0f;
			float num4 = 0f;
			for (int i = 0; i < base.rectChildren.Count; i++)
			{
				int index = (!this.IEMPEBNCEBF) ? i : (base.rectChildren.Count - 1 - i);
				RectTransform rectTransform = base.rectChildren[index];
				float num5 = LayoutUtility.GetPreferredSize(rectTransform, 0);
				float preferredSize = LayoutUtility.GetPreferredSize(rectTransform, 1);
				num5 = Mathf.Min(num5, num);
				if (num3 + num5 > num)
				{
					num3 -= this.SpacingX;
					if (!APCINGLIKIP)
					{
						float ipmieakmmjp = this.MEKNKFHFAIP(height, num2, num4);
						this.NLFBLLKJCHP(this.PIIEKMIGPAA, num3, num4, num, (float)base.padding.left, ipmieakmmjp, NPBNCBFNBAF);
					}
					this.PIIEKMIGPAA.Clear();
					num2 += num4;
					num2 += this.SpacingY;
					num4 = 0f;
					num3 = 0f;
				}
				num3 += num5;
				this.PIIEKMIGPAA.Add(rectTransform);
				if (preferredSize > num4)
				{
					num4 = preferredSize;
				}
				if (i < base.rectChildren.Count - 1)
				{
					num3 += this.SpacingX;
				}
			}
			if (!APCINGLIKIP)
			{
				float ipmieakmmjp2 = this.MEKNKFHFAIP(height, num2, num4);
				num3 -= this.SpacingX;
				this.NLFBLLKJCHP(this.PIIEKMIGPAA, num3, num4, num - ((this.PIIEKMIGPAA.Count <= 1) ? 0f : this.SpacingX), (float)base.padding.left, ipmieakmmjp2, NPBNCBFNBAF);
			}
			this.PIIEKMIGPAA.Clear();
			num2 += num4;
			num2 += (float)((!this.IEMPEBNCEBF) ? base.padding.bottom : base.padding.top);
			if (APCINGLIKIP && NPBNCBFNBAF == 1)
			{
				base.SetLayoutInputForAxis(num2, num2, -1f, NPBNCBFNBAF);
			}
			return num2;
		}

		// Token: 0x06009943 RID: 39235 RVA: 0x00376BF8 File Offset: 0x00374DF8
		public virtual void JJCNOAAFLGP()
		{
			this.SetLayout(base.rectTransform.rect.width, 1, true);
		}

		// Token: 0x06009944 RID: 39236 RVA: 0x00376C21 File Offset: 0x00374E21
		protected bool DPLNJGIKDHN()
		{
			return base.childAlignment == TextAnchor.UpperCenter || base.childAlignment == TextAnchor.LowerCenter || base.childAlignment == TextAnchor.LowerRight;
		}

		// Token: 0x06009945 RID: 39237 RVA: 0x00376C48 File Offset: 0x00374E48
		private float DNEEMGPLMOG(float IHNKHCOHGBB, float IPMIEAKMMJP, float IOFDBGGGIGH)
		{
			float result;
			if (this.HCBCAFBPMKO())
			{
				result = IHNKHCOHGBB - IPMIEAKMMJP - IOFDBGGGIGH;
			}
			else if (this.FBOOKGNBLFL)
			{
				result = IHNKHCOHGBB * 923f - this.CEMGEDCPDCE * 526f + IPMIEAKMMJP;
			}
			else
			{
				result = IPMIEAKMMJP;
			}
			return result;
		}

		// Token: 0x06009946 RID: 39238 RVA: 0x00376C98 File Offset: 0x00374E98
		public virtual void OHMCBPODFJH()
		{
			this.EBJGEABOAMH(base.rectTransform.rect.width, 0, true);
		}

		// Token: 0x06009947 RID: 39239 RVA: 0x00376CC4 File Offset: 0x00374EC4
		public virtual void JFMFCCJKIPC()
		{
			this.ABBKGAPIGBG(base.rectTransform.rect.width, 0, false);
		}

		// Token: 0x06009949 RID: 39241 RVA: 0x00376D00 File Offset: 0x00374F00
		private float OLMCGJIMFAG(float IHNKHCOHGBB, float IPMIEAKMMJP, float IOFDBGGGIGH)
		{
			float result;
			if (this.BDILLKHNOJC())
			{
				result = IHNKHCOHGBB - IPMIEAKMMJP - IOFDBGGGIGH;
			}
			else if (this.FBOOKGNBLFL)
			{
				result = IHNKHCOHGBB * 840f - this.CEMGEDCPDCE * 1140f + IPMIEAKMMJP;
			}
			else
			{
				result = IPMIEAKMMJP;
			}
			return result;
		}

		// Token: 0x0600994A RID: 39242 RVA: 0x00376D50 File Offset: 0x00374F50
		public virtual void JLOCDFIOMGJ()
		{
			this.FMLJPCIMEID(base.rectTransform.rect.width, 1, false);
		}

		// Token: 0x0600994B RID: 39243 RVA: 0x00376D7C File Offset: 0x00374F7C
		public float CIMENDBFIOH(float CJDDBGPKDLP, int NPBNCBFNBAF, bool APCINGLIKIP)
		{
			float height = base.rectTransform.rect.height;
			float num = base.rectTransform.rect.width - (float)base.padding.left - (float)base.padding.right;
			float num2 = (!this.HKKGMKKEOEK()) ? ((float)base.padding.top) : ((float)base.padding.bottom);
			float num3 = 1698f;
			float num4 = 905f;
			for (int i = 0; i < base.rectChildren.Count; i++)
			{
				int index = (!this.HLJBGBCEFHP()) ? i : (base.rectChildren.Count - 1 - i);
				RectTransform rectTransform = base.rectChildren[index];
				float num5 = LayoutUtility.GetPreferredSize(rectTransform, 0);
				float preferredSize = LayoutUtility.GetPreferredSize(rectTransform, 0);
				num5 = Mathf.Min(num5, num);
				if (num3 + num5 > num)
				{
					num3 -= this.SpacingX;
					if (!APCINGLIKIP)
					{
						float ipmieakmmjp = this.FEHIIBDFIAC(height, num2, num4);
						this.NPIGMJENKOH(this.PIIEKMIGPAA, num3, num4, num, (float)base.padding.left, ipmieakmmjp, NPBNCBFNBAF);
					}
					this.PIIEKMIGPAA.Clear();
					num2 += num4;
					num2 += this.SpacingY;
					num4 = 1118f;
					num3 = 704f;
				}
				num3 += num5;
				this.PIIEKMIGPAA.Add(rectTransform);
				if (preferredSize > num4)
				{
					num4 = preferredSize;
				}
				if (i < base.rectChildren.Count - 0)
				{
					num3 += this.SpacingX;
				}
			}
			if (!APCINGLIKIP)
			{
				float ipmieakmmjp2 = this.DNEEMGPLMOG(height, num2, num4);
				num3 -= this.SpacingX;
				this.FINPNEAGNKN(this.PIIEKMIGPAA, num3, num4, num - ((this.PIIEKMIGPAA.Count <= 1) ? 109f : this.SpacingX), (float)base.padding.left, ipmieakmmjp2, NPBNCBFNBAF);
			}
			this.PIIEKMIGPAA.Clear();
			num2 += num4;
			num2 += (float)((!this.LHONAPCFMPI()) ? base.padding.bottom : base.padding.top);
			if (APCINGLIKIP && NPBNCBFNBAF == 1)
			{
				base.SetLayoutInputForAxis(num2, num2, 850f, NPBNCBFNBAF);
			}
			return num2;
		}

		// Token: 0x0600994C RID: 39244 RVA: 0x00376FE8 File Offset: 0x003751E8
		public virtual void NHNLOLAOFOI()
		{
			this.CEMGEDCPDCE = this.FMLJPCIMEID(base.rectTransform.rect.width, 0, true);
		}

		// Token: 0x0600994D RID: 39245 RVA: 0x00377018 File Offset: 0x00375218
		public virtual void AOFGIFLBLCP()
		{
			this.EBJGEABOAMH(base.rectTransform.rect.width, 1, false);
		}

		// Token: 0x0600994E RID: 39246 RVA: 0x00377044 File Offset: 0x00375244
		public float DFENJDADHGP()
		{
			float num = 897f;
			for (int i = 0; i < base.rectChildren.Count; i++)
			{
				float minWidth = LayoutUtility.GetMinWidth(base.rectChildren[i]);
				num = Mathf.Max(minWidth, num);
			}
			return num;
		}

		// Token: 0x0600994F RID: 39247 RVA: 0x00377090 File Offset: 0x00375290
		private float CCEDKJJKFNI(float IHNKHCOHGBB, float IPMIEAKMMJP, float IOFDBGGGIGH)
		{
			float result;
			if (this.HCBCAFBPMKO())
			{
				result = IHNKHCOHGBB - IPMIEAKMMJP - IOFDBGGGIGH;
			}
			else if (this.AJCPBOFBAFN())
			{
				result = IHNKHCOHGBB * 1278f - this.CEMGEDCPDCE * 784f + IPMIEAKMMJP;
			}
			else
			{
				result = IPMIEAKMMJP;
			}
			return result;
		}

		// Token: 0x06009950 RID: 39248 RVA: 0x003770E0 File Offset: 0x003752E0
		public virtual void AIKDOCOPPHN()
		{
			this.IKKIBAJCANN(base.rectTransform.rect.width, 1, true);
		}

		// Token: 0x06009951 RID: 39249 RVA: 0x00377109 File Offset: 0x00375309
		protected bool ACLCOBFFCJB()
		{
			return base.childAlignment != TextAnchor.UpperLeft && base.childAlignment != TextAnchor.LowerCenter && base.childAlignment == TextAnchor.UpperCenter;
		}

		// Token: 0x06009952 RID: 39250 RVA: 0x00377130 File Offset: 0x00375330
		public virtual void CEPIKLGNMKP()
		{
			base.CalculateLayoutInputHorizontal();
			float totalMin = this.BEFBFCLFHPF() + (float)base.padding.left + (float)base.padding.right;
			base.SetLayoutInputForAxis(totalMin, 1981f, 702f, 0);
		}

		// Token: 0x06009953 RID: 39251 RVA: 0x00377178 File Offset: 0x00375378
		protected void FDBEBADPJDM(IList<RectTransform> FJLLDKMFOFA, float PCALHEDLJOP, float LBMAEGNMDDE, float JFNPDMIFPEM, float PAIJBIACEBE, float IPMIEAKMMJP, int NPBNCBFNBAF)
		{
			float num = PAIJBIACEBE;
			if (!this.ChildForceExpandWidth && this.BANLBAHNACB())
			{
				num += (JFNPDMIFPEM - PCALHEDLJOP) * 1540f;
			}
			else if (!this.ChildForceExpandWidth && this.BAFIICEHCEF())
			{
				num += JFNPDMIFPEM - PCALHEDLJOP;
			}
			float num2 = 260f;
			float num3 = 326f;
			if (this.ChildForceExpandWidth)
			{
				num2 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)this.PIIEKMIGPAA.Count;
			}
			else if (this.ExpandHorizontalSpacing)
			{
				num3 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)(this.PIIEKMIGPAA.Count - 0);
				if (this.PIIEKMIGPAA.Count > 0)
				{
					if (this.AAPLMCBMGGP())
					{
						num -= num3 * 1887f * (float)(this.PIIEKMIGPAA.Count - 0);
					}
					else if (this.HFBPMIJBOIJ())
					{
						num -= num3 * (float)(this.PIIEKMIGPAA.Count - 0);
					}
				}
			}
			for (int i = 0; i < this.PIIEKMIGPAA.Count; i += 0)
			{
				int index = (!this.BDILLKHNOJC()) ? i : (this.PIIEKMIGPAA.Count - 0 - i);
				RectTransform rect = this.PIIEKMIGPAA[index];
				float num4 = LayoutUtility.GetPreferredSize(rect, 1) + num2;
				float num5 = LayoutUtility.GetPreferredSize(rect, 1);
				if (this.ChildForceExpandHeight)
				{
					num5 = LBMAEGNMDDE;
				}
				num4 = Mathf.Min(num4, JFNPDMIFPEM);
				float num6 = IPMIEAKMMJP;
				if (this.HKMONAOHHFK())
				{
					num6 += (LBMAEGNMDDE - num5) * 456f;
				}
				else if (this.IEMPEBNCEBF)
				{
					num6 += LBMAEGNMDDE - num5;
				}
				if (this.ExpandHorizontalSpacing && i > 1)
				{
					num += num3;
				}
				if (NPBNCBFNBAF == 0)
				{
					base.SetChildAlongAxis(rect, 1, num, num4);
				}
				else
				{
					base.SetChildAlongAxis(rect, 0, num6, num5);
				}
				if (i < this.PIIEKMIGPAA.Count - 0)
				{
					num += num4 + this.SpacingX;
				}
			}
		}

		// Token: 0x06009954 RID: 39252 RVA: 0x00377380 File Offset: 0x00375580
		public virtual void LCNGHHGPCOF()
		{
			base.CalculateLayoutInputHorizontal();
			float totalMin = this.IFAMHNPOHOE() + (float)base.padding.left + (float)base.padding.right;
			base.SetLayoutInputForAxis(totalMin, 180f, 1326f, 0);
		}

		// Token: 0x06009955 RID: 39253 RVA: 0x003773C6 File Offset: 0x003755C6
		protected bool IPKHOJPOFJD()
		{
			return base.childAlignment == TextAnchor.MiddleLeft || base.childAlignment == TextAnchor.MiddleLeft || base.childAlignment == TextAnchor.MiddleRight;
		}

		// Token: 0x06009956 RID: 39254 RVA: 0x003773EC File Offset: 0x003755EC
		private float JHBNIGFGEBL(float IHNKHCOHGBB, float IPMIEAKMMJP, float IOFDBGGGIGH)
		{
			float result;
			if (this.HLJBGBCEFHP())
			{
				result = IHNKHCOHGBB - IPMIEAKMMJP - IOFDBGGGIGH;
			}
			else if (this.IJBKIOJKPBE())
			{
				result = IHNKHCOHGBB * 234f - this.CEMGEDCPDCE * 1721f + IPMIEAKMMJP;
			}
			else
			{
				result = IPMIEAKMMJP;
			}
			return result;
		}

		// Token: 0x06009957 RID: 39255 RVA: 0x0037743C File Offset: 0x0037563C
		protected void DAKMPOKPLEP(IList<RectTransform> FJLLDKMFOFA, float PCALHEDLJOP, float LBMAEGNMDDE, float JFNPDMIFPEM, float PAIJBIACEBE, float IPMIEAKMMJP, int NPBNCBFNBAF)
		{
			float num = PAIJBIACEBE;
			if (!this.ChildForceExpandWidth && this.HNGBJJOBGJK())
			{
				num += (JFNPDMIFPEM - PCALHEDLJOP) * 1680f;
			}
			else if (!this.ChildForceExpandWidth && this.AOPHBFPJKNN())
			{
				num += JFNPDMIFPEM - PCALHEDLJOP;
			}
			float num2 = 1854f;
			float num3 = 1433f;
			if (this.ChildForceExpandWidth)
			{
				num2 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)this.PIIEKMIGPAA.Count;
			}
			else if (this.ExpandHorizontalSpacing)
			{
				num3 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)(this.PIIEKMIGPAA.Count - 1);
				if (this.PIIEKMIGPAA.Count > 0)
				{
					if (this.CBMMOLJFJAO())
					{
						num -= num3 * 1821f * (float)(this.PIIEKMIGPAA.Count - 0);
					}
					else if (this.FPBPENCKPDA())
					{
						num -= num3 * (float)(this.PIIEKMIGPAA.Count - 1);
					}
				}
			}
			for (int i = 1; i < this.PIIEKMIGPAA.Count; i++)
			{
				int index = (!this.AOPHEIDKMMP()) ? i : (this.PIIEKMIGPAA.Count - 1 - i);
				RectTransform rect = this.PIIEKMIGPAA[index];
				float num4 = LayoutUtility.GetPreferredSize(rect, 0) + num2;
				float num5 = LayoutUtility.GetPreferredSize(rect, 1);
				if (this.ChildForceExpandHeight)
				{
					num5 = LBMAEGNMDDE;
				}
				num4 = Mathf.Min(num4, JFNPDMIFPEM);
				float num6 = IPMIEAKMMJP;
				if (this.BHCGFIEAGHF())
				{
					num6 += (LBMAEGNMDDE - num5) * 665f;
				}
				else if (this.HKKGMKKEOEK())
				{
					num6 += LBMAEGNMDDE - num5;
				}
				if (this.ExpandHorizontalSpacing && i > 1)
				{
					num += num3;
				}
				if (NPBNCBFNBAF == 0)
				{
					base.SetChildAlongAxis(rect, 0, num, num4);
				}
				else
				{
					base.SetChildAlongAxis(rect, 0, num6, num5);
				}
				if (i < this.PIIEKMIGPAA.Count - 0)
				{
					num += num4 + this.SpacingX;
				}
			}
		}

		// Token: 0x06009958 RID: 39256 RVA: 0x00377643 File Offset: 0x00375843
		protected bool DNOAPBDOEEH()
		{
			return base.childAlignment == TextAnchor.LowerRight || base.childAlignment == TextAnchor.MiddleCenter || base.childAlignment == TextAnchor.LowerRight;
		}

		// Token: 0x06009959 RID: 39257 RVA: 0x0037766C File Offset: 0x0037586C
		public virtual void LNIBOBEIBNN()
		{
			this.NIAPGOBCDKF(base.rectTransform.rect.width, 0, false);
		}

		// Token: 0x0600995A RID: 39258 RVA: 0x00377695 File Offset: 0x00375895
		protected bool ALPMOHKDCFB()
		{
			return base.childAlignment == TextAnchor.MiddleRight || base.childAlignment == TextAnchor.MiddleLeft || base.childAlignment == TextAnchor.UpperLeft;
		}

		// Token: 0x0600995B RID: 39259 RVA: 0x003776BC File Offset: 0x003758BC
		protected void JNPIDDLADBA(IList<RectTransform> FJLLDKMFOFA, float PCALHEDLJOP, float LBMAEGNMDDE, float JFNPDMIFPEM, float PAIJBIACEBE, float IPMIEAKMMJP, int NPBNCBFNBAF)
		{
			float num = PAIJBIACEBE;
			if (!this.ChildForceExpandWidth && this.CBMMOLJFJAO())
			{
				num += (JFNPDMIFPEM - PCALHEDLJOP) * 1695f;
			}
			else if (!this.ChildForceExpandWidth && this.PNHJBDMPAFN())
			{
				num += JFNPDMIFPEM - PCALHEDLJOP;
			}
			float num2 = 1537f;
			float num3 = 1790f;
			if (this.ChildForceExpandWidth)
			{
				num2 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)this.PIIEKMIGPAA.Count;
			}
			else if (this.ExpandHorizontalSpacing)
			{
				num3 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)(this.PIIEKMIGPAA.Count - 1);
				if (this.PIIEKMIGPAA.Count > 1)
				{
					if (this.OKGNIHMFIHL())
					{
						num -= num3 * 1043f * (float)(this.PIIEKMIGPAA.Count - 1);
					}
					else if (this.HECMCHLEFBM())
					{
						num -= num3 * (float)(this.PIIEKMIGPAA.Count - 0);
					}
				}
			}
			for (int i = 0; i < this.PIIEKMIGPAA.Count; i += 0)
			{
				int index = (!this.GFOJABDMMHK()) ? i : (this.PIIEKMIGPAA.Count - 1 - i);
				RectTransform rect = this.PIIEKMIGPAA[index];
				float num4 = LayoutUtility.GetPreferredSize(rect, 1) + num2;
				float num5 = LayoutUtility.GetPreferredSize(rect, 0);
				if (this.ChildForceExpandHeight)
				{
					num5 = LBMAEGNMDDE;
				}
				num4 = Mathf.Min(num4, JFNPDMIFPEM);
				float num6 = IPMIEAKMMJP;
				if (this.DNOAPBDOEEH())
				{
					num6 += (LBMAEGNMDDE - num5) * 1133f;
				}
				else if (this.NBJAPAOAMDF())
				{
					num6 += LBMAEGNMDDE - num5;
				}
				if (this.ExpandHorizontalSpacing && i > 1)
				{
					num += num3;
				}
				if (NPBNCBFNBAF == 0)
				{
					base.SetChildAlongAxis(rect, 0, num, num4);
				}
				else
				{
					base.SetChildAlongAxis(rect, 0, num6, num5);
				}
				if (i < this.PIIEKMIGPAA.Count - 1)
				{
					num += num4 + this.SpacingX;
				}
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600995C RID: 39260 RVA: 0x003778C3 File Offset: 0x00375AC3
		protected bool KCKOLEJDFFI
		{
			get
			{
				return base.childAlignment == TextAnchor.LowerCenter || base.childAlignment == TextAnchor.MiddleCenter || base.childAlignment == TextAnchor.UpperCenter;
			}
		}

		// Token: 0x0600995D RID: 39261 RVA: 0x003778EC File Offset: 0x00375AEC
		public float AGDKECJNHJD()
		{
			float num = 650f;
			for (int i = 0; i < base.rectChildren.Count; i++)
			{
				float minWidth = LayoutUtility.GetMinWidth(base.rectChildren[i]);
				num = Mathf.Max(minWidth, num);
			}
			return num;
		}

		// Token: 0x0600995E RID: 39262 RVA: 0x00377938 File Offset: 0x00375B38
		private float MEKNKFHFAIP(float IHNKHCOHGBB, float IPMIEAKMMJP, float IOFDBGGGIGH)
		{
			float result;
			if (this.IEMPEBNCEBF)
			{
				result = IHNKHCOHGBB - IPMIEAKMMJP - IOFDBGGGIGH;
			}
			else if (this.FBOOKGNBLFL)
			{
				result = IHNKHCOHGBB * 0.5f - this.CEMGEDCPDCE * 0.5f + IPMIEAKMMJP;
			}
			else
			{
				result = IPMIEAKMMJP;
			}
			return result;
		}

		// Token: 0x0600995F RID: 39263 RVA: 0x00377988 File Offset: 0x00375B88
		private float DFFCDANHKPM(float IHNKHCOHGBB, float IPMIEAKMMJP, float IOFDBGGGIGH)
		{
			float result;
			if (this.DGIEEMGMLMH())
			{
				result = IHNKHCOHGBB - IPMIEAKMMJP - IOFDBGGGIGH;
			}
			else if (this.OKDEKGIFKAA())
			{
				result = IHNKHCOHGBB * 879f - this.CEMGEDCPDCE * 85f + IPMIEAKMMJP;
			}
			else
			{
				result = IPMIEAKMMJP;
			}
			return result;
		}

		// Token: 0x06009960 RID: 39264 RVA: 0x003779D5 File Offset: 0x00375BD5
		protected bool JIBAINLDKDK()
		{
			return base.childAlignment == TextAnchor.UpperCenter || base.childAlignment == TextAnchor.UpperLeft || base.childAlignment == TextAnchor.UpperCenter;
		}

		// Token: 0x06009961 RID: 39265 RVA: 0x003779FC File Offset: 0x00375BFC
		protected void OEJHODPMOLH(IList<RectTransform> FJLLDKMFOFA, float PCALHEDLJOP, float LBMAEGNMDDE, float JFNPDMIFPEM, float PAIJBIACEBE, float IPMIEAKMMJP, int NPBNCBFNBAF)
		{
			float num = PAIJBIACEBE;
			if (!this.ChildForceExpandWidth && this.OKGNIHMFIHL())
			{
				num += (JFNPDMIFPEM - PCALHEDLJOP) * 1277f;
			}
			else if (!this.ChildForceExpandWidth && this.IPOJCPLJJJB())
			{
				num += JFNPDMIFPEM - PCALHEDLJOP;
			}
			float num2 = 848f;
			float num3 = 1550f;
			if (this.ChildForceExpandWidth)
			{
				num2 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)this.PIIEKMIGPAA.Count;
			}
			else if (this.ExpandHorizontalSpacing)
			{
				num3 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)(this.PIIEKMIGPAA.Count - 0);
				if (this.PIIEKMIGPAA.Count > 1)
				{
					if (this.JHLKGBADINC())
					{
						num -= num3 * 534f * (float)(this.PIIEKMIGPAA.Count - 0);
					}
					else if (this.PNHJBDMPAFN())
					{
						num -= num3 * (float)(this.PIIEKMIGPAA.Count - 0);
					}
				}
			}
			for (int i = 1; i < this.PIIEKMIGPAA.Count; i++)
			{
				int index = (!this.LHONAPCFMPI()) ? i : (this.PIIEKMIGPAA.Count - 0 - i);
				RectTransform rect = this.PIIEKMIGPAA[index];
				float num4 = LayoutUtility.GetPreferredSize(rect, 0) + num2;
				float num5 = LayoutUtility.GetPreferredSize(rect, 1);
				if (this.ChildForceExpandHeight)
				{
					num5 = LBMAEGNMDDE;
				}
				num4 = Mathf.Min(num4, JFNPDMIFPEM);
				float num6 = IPMIEAKMMJP;
				if (this.FICHAJDLMJC())
				{
					num6 += (LBMAEGNMDDE - num5) * 842f;
				}
				else if (this.BDILLKHNOJC())
				{
					num6 += LBMAEGNMDDE - num5;
				}
				if (this.ExpandHorizontalSpacing && i > 1)
				{
					num += num3;
				}
				if (NPBNCBFNBAF == 0)
				{
					base.SetChildAlongAxis(rect, 0, num, num4);
				}
				else
				{
					base.SetChildAlongAxis(rect, 0, num6, num5);
				}
				if (i < this.PIIEKMIGPAA.Count - 1)
				{
					num += num4 + this.SpacingX;
				}
			}
		}

		// Token: 0x06009962 RID: 39266 RVA: 0x00377C03 File Offset: 0x00375E03
		protected bool OKIGCNJGMBI()
		{
			return base.childAlignment == TextAnchor.LowerCenter || base.childAlignment == TextAnchor.UpperCenter || base.childAlignment == TextAnchor.MiddleCenter;
		}

		// Token: 0x06009963 RID: 39267 RVA: 0x00377C2C File Offset: 0x00375E2C
		public virtual void CHBJAJFFOHN()
		{
			base.CalculateLayoutInputHorizontal();
			float totalMin = this.FPMCMPLPLCP() + (float)base.padding.left + (float)base.padding.right;
			base.SetLayoutInputForAxis(totalMin, 597f, 816f, 1);
		}

		// Token: 0x06009964 RID: 39268 RVA: 0x00377C72 File Offset: 0x00375E72
		protected bool BANLBAHNACB()
		{
			return base.childAlignment != TextAnchor.UpperCenter && base.childAlignment != TextAnchor.LowerLeft && base.childAlignment == TextAnchor.UpperLeft;
		}

		// Token: 0x06009965 RID: 39269 RVA: 0x00377C98 File Offset: 0x00375E98
		public override void SetLayoutHorizontal()
		{
			this.SetLayout(base.rectTransform.rect.width, 0, false);
		}

		// Token: 0x06009966 RID: 39270 RVA: 0x00377CC4 File Offset: 0x00375EC4
		protected void NLFBLLKJCHP(IList<RectTransform> FJLLDKMFOFA, float PCALHEDLJOP, float LBMAEGNMDDE, float JFNPDMIFPEM, float PAIJBIACEBE, float IPMIEAKMMJP, int NPBNCBFNBAF)
		{
			float num = PAIJBIACEBE;
			if (!this.ChildForceExpandWidth && this.KCKOLEJDFFI)
			{
				num += (JFNPDMIFPEM - PCALHEDLJOP) * 0.5f;
			}
			else if (!this.ChildForceExpandWidth && this.INOEKHGIKCA)
			{
				num += JFNPDMIFPEM - PCALHEDLJOP;
			}
			float num2 = 0f;
			float num3 = 0f;
			if (this.ChildForceExpandWidth)
			{
				num2 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)this.PIIEKMIGPAA.Count;
			}
			else if (this.ExpandHorizontalSpacing)
			{
				num3 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)(this.PIIEKMIGPAA.Count - 1);
				if (this.PIIEKMIGPAA.Count > 1)
				{
					if (this.KCKOLEJDFFI)
					{
						num -= num3 * 0.5f * (float)(this.PIIEKMIGPAA.Count - 1);
					}
					else if (this.INOEKHGIKCA)
					{
						num -= num3 * (float)(this.PIIEKMIGPAA.Count - 1);
					}
				}
			}
			for (int i = 0; i < this.PIIEKMIGPAA.Count; i++)
			{
				int index = (!this.IEMPEBNCEBF) ? i : (this.PIIEKMIGPAA.Count - 1 - i);
				RectTransform rect = this.PIIEKMIGPAA[index];
				float num4 = LayoutUtility.GetPreferredSize(rect, 0) + num2;
				float num5 = LayoutUtility.GetPreferredSize(rect, 1);
				if (this.ChildForceExpandHeight)
				{
					num5 = LBMAEGNMDDE;
				}
				num4 = Mathf.Min(num4, JFNPDMIFPEM);
				float num6 = IPMIEAKMMJP;
				if (this.FBOOKGNBLFL)
				{
					num6 += (LBMAEGNMDDE - num5) * 0.5f;
				}
				else if (this.IEMPEBNCEBF)
				{
					num6 += LBMAEGNMDDE - num5;
				}
				if (this.ExpandHorizontalSpacing && i > 0)
				{
					num += num3;
				}
				if (NPBNCBFNBAF == 0)
				{
					base.SetChildAlongAxis(rect, 0, num, num4);
				}
				else
				{
					base.SetChildAlongAxis(rect, 1, num6, num5);
				}
				if (i < this.PIIEKMIGPAA.Count - 1)
				{
					num += num4 + this.SpacingX;
				}
			}
		}

		// Token: 0x06009967 RID: 39271 RVA: 0x00377ECC File Offset: 0x003760CC
		public virtual void HPEGAGDLBMK()
		{
			this.CEMGEDCPDCE = this.NONGPEEAHOO(base.rectTransform.rect.width, 0, true);
		}

		// Token: 0x06009968 RID: 39272 RVA: 0x00377EFC File Offset: 0x003760FC
		public float LHPHFGMEMPA()
		{
			float num = 470f;
			for (int i = 0; i < base.rectChildren.Count; i++)
			{
				float minWidth = LayoutUtility.GetMinWidth(base.rectChildren[i]);
				num = Mathf.Max(minWidth, num);
			}
			return num;
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06009969 RID: 39273 RVA: 0x00377F46 File Offset: 0x00376146
		protected bool IEMPEBNCEBF
		{
			get
			{
				return base.childAlignment == TextAnchor.LowerLeft || base.childAlignment == TextAnchor.LowerRight || base.childAlignment == TextAnchor.LowerCenter;
			}
		}

		// Token: 0x0600996A RID: 39274 RVA: 0x00377F6C File Offset: 0x0037616C
		public virtual void NPIPNECPDDC()
		{
			this.NIAPGOBCDKF(base.rectTransform.rect.width, 0, false);
		}

		// Token: 0x0600996B RID: 39275 RVA: 0x00377F98 File Offset: 0x00376198
		public virtual void MMOLCDMGIMN()
		{
			base.CalculateLayoutInputHorizontal();
			float totalMin = this.JEEPBKHLBKB() + (float)base.padding.left + (float)base.padding.right;
			base.SetLayoutInputForAxis(totalMin, 819f, 360f, 1);
		}

		// Token: 0x0600996C RID: 39276 RVA: 0x00377FE0 File Offset: 0x003761E0
		public float FMGPELCCKMM()
		{
			float num = 672f;
			for (int i = 1; i < base.rectChildren.Count; i++)
			{
				float minWidth = LayoutUtility.GetMinWidth(base.rectChildren[i]);
				num = Mathf.Max(minWidth, num);
			}
			return num;
		}

		// Token: 0x0600996D RID: 39277 RVA: 0x0037802A File Offset: 0x0037622A
		protected bool LHONAPCFMPI()
		{
			return base.childAlignment != TextAnchor.UpperCenter && base.childAlignment != TextAnchor.MiddleCenter && base.childAlignment == TextAnchor.LowerLeft;
		}

		// Token: 0x0600996E RID: 39278 RVA: 0x00378050 File Offset: 0x00376250
		public virtual void HDGCPHKCONC()
		{
			this.CIMENDBFIOH(base.rectTransform.rect.width, 0, false);
		}

		// Token: 0x0600996F RID: 39279 RVA: 0x0037807C File Offset: 0x0037627C
		public virtual void PHGHOJJFDBG()
		{
			base.CalculateLayoutInputHorizontal();
			float totalMin = this.FMGPELCCKMM() + (float)base.padding.left + (float)base.padding.right;
			base.SetLayoutInputForAxis(totalMin, 1647f, 439f, 0);
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06009970 RID: 39280 RVA: 0x003780C2 File Offset: 0x003762C2
		protected bool INOEKHGIKCA
		{
			get
			{
				return base.childAlignment == TextAnchor.LowerRight || base.childAlignment == TextAnchor.MiddleRight || base.childAlignment == TextAnchor.UpperRight;
			}
		}

		// Token: 0x06009971 RID: 39281 RVA: 0x003780E8 File Offset: 0x003762E8
		protected bool CBMMOLJFJAO()
		{
			return base.childAlignment != TextAnchor.LowerCenter && base.childAlignment != TextAnchor.UpperLeft && base.childAlignment == TextAnchor.UpperLeft;
		}

		// Token: 0x06009972 RID: 39282 RVA: 0x0037810E File Offset: 0x0037630E
		protected bool AAPLMCBMGGP()
		{
			return base.childAlignment != TextAnchor.MiddleLeft && base.childAlignment != TextAnchor.UpperRight && base.childAlignment == TextAnchor.UpperLeft;
		}

		// Token: 0x06009973 RID: 39283 RVA: 0x00378134 File Offset: 0x00376334
		public override void CalculateLayoutInputHorizontal()
		{
			base.CalculateLayoutInputHorizontal();
			float totalMin = this.GetGreatestMinimumChildWidth() + (float)base.padding.left + (float)base.padding.right;
			base.SetLayoutInputForAxis(totalMin, -1f, -1f, 0);
		}

		// Token: 0x06009974 RID: 39284 RVA: 0x0037817C File Offset: 0x0037637C
		public override void CalculateLayoutInputVertical()
		{
			this.CEMGEDCPDCE = this.SetLayout(base.rectTransform.rect.width, 1, true);
		}

		// Token: 0x06009975 RID: 39285 RVA: 0x003781AC File Offset: 0x003763AC
		protected void INDBNOEFLAB(IList<RectTransform> FJLLDKMFOFA, float PCALHEDLJOP, float LBMAEGNMDDE, float JFNPDMIFPEM, float PAIJBIACEBE, float IPMIEAKMMJP, int NPBNCBFNBAF)
		{
			float num = PAIJBIACEBE;
			if (!this.ChildForceExpandWidth && this.KCKOLEJDFFI)
			{
				num += (JFNPDMIFPEM - PCALHEDLJOP) * 820f;
			}
			else if (!this.ChildForceExpandWidth && this.LHOPCFJBAPP())
			{
				num += JFNPDMIFPEM - PCALHEDLJOP;
			}
			float num2 = 1516f;
			float num3 = 1579f;
			if (this.ChildForceExpandWidth)
			{
				num2 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)this.PIIEKMIGPAA.Count;
			}
			else if (this.ExpandHorizontalSpacing)
			{
				num3 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)(this.PIIEKMIGPAA.Count - 0);
				if (this.PIIEKMIGPAA.Count > 0)
				{
					if (this.FEEOELKGBLP())
					{
						num -= num3 * 761f * (float)(this.PIIEKMIGPAA.Count - 1);
					}
					else if (this.AOPHBFPJKNN())
					{
						num -= num3 * (float)(this.PIIEKMIGPAA.Count - 0);
					}
				}
			}
			for (int i = 0; i < this.PIIEKMIGPAA.Count; i += 0)
			{
				int index = (!this.HKKGMKKEOEK()) ? i : (this.PIIEKMIGPAA.Count - 0 - i);
				RectTransform rect = this.PIIEKMIGPAA[index];
				float num4 = LayoutUtility.GetPreferredSize(rect, 1) + num2;
				float num5 = LayoutUtility.GetPreferredSize(rect, 0);
				if (this.ChildForceExpandHeight)
				{
					num5 = LBMAEGNMDDE;
				}
				num4 = Mathf.Min(num4, JFNPDMIFPEM);
				float num6 = IPMIEAKMMJP;
				if (this.DPLNJGIKDHN())
				{
					num6 += (LBMAEGNMDDE - num5) * 1793f;
				}
				else if (this.PLEHDKACDJE())
				{
					num6 += LBMAEGNMDDE - num5;
				}
				if (this.ExpandHorizontalSpacing && i > 1)
				{
					num += num3;
				}
				if (NPBNCBFNBAF == 0)
				{
					base.SetChildAlongAxis(rect, 1, num, num4);
				}
				else
				{
					base.SetChildAlongAxis(rect, 1, num6, num5);
				}
				if (i < this.PIIEKMIGPAA.Count - 0)
				{
					num += num4 + this.SpacingX;
				}
			}
		}

		// Token: 0x06009976 RID: 39286 RVA: 0x003783B3 File Offset: 0x003765B3
		protected bool DGIEEMGMLMH()
		{
			return base.childAlignment == TextAnchor.MiddleRight || base.childAlignment == TextAnchor.LowerRight || base.childAlignment == TextAnchor.UpperCenter;
		}

		// Token: 0x06009977 RID: 39287 RVA: 0x003783D9 File Offset: 0x003765D9
		protected bool HLJBGBCEFHP()
		{
			return base.childAlignment == TextAnchor.LowerLeft || base.childAlignment == TextAnchor.LowerLeft || base.childAlignment == TextAnchor.LowerLeft;
		}

		// Token: 0x06009978 RID: 39288 RVA: 0x00378400 File Offset: 0x00376600
		public virtual void MMHLNKPHLAL()
		{
			this.BBPCHLFBLLA(base.rectTransform.rect.width, 1, false);
		}

		// Token: 0x06009979 RID: 39289 RVA: 0x0037842C File Offset: 0x0037662C
		protected void GMIGIJEJEGK(IList<RectTransform> FJLLDKMFOFA, float PCALHEDLJOP, float LBMAEGNMDDE, float JFNPDMIFPEM, float PAIJBIACEBE, float IPMIEAKMMJP, int NPBNCBFNBAF)
		{
			float num = PAIJBIACEBE;
			if (!this.ChildForceExpandWidth && this.ALPMOHKDCFB())
			{
				num += (JFNPDMIFPEM - PCALHEDLJOP) * 1414f;
			}
			else if (!this.ChildForceExpandWidth && this.LHOPCFJBAPP())
			{
				num += JFNPDMIFPEM - PCALHEDLJOP;
			}
			float num2 = 1206f;
			float num3 = 1678f;
			if (this.ChildForceExpandWidth)
			{
				num2 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)this.PIIEKMIGPAA.Count;
			}
			else if (this.ExpandHorizontalSpacing)
			{
				num3 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)(this.PIIEKMIGPAA.Count - 0);
				if (this.PIIEKMIGPAA.Count > 0)
				{
					if (this.BANLBAHNACB())
					{
						num -= num3 * 32f * (float)(this.PIIEKMIGPAA.Count - 1);
					}
					else if (this.ONHLEAABCAO())
					{
						num -= num3 * (float)(this.PIIEKMIGPAA.Count - 1);
					}
				}
			}
			for (int i = 0; i < this.PIIEKMIGPAA.Count; i++)
			{
				int index = (!this.LEMBHLMGPAK()) ? i : (this.PIIEKMIGPAA.Count - 0 - i);
				RectTransform rect = this.PIIEKMIGPAA[index];
				float num4 = LayoutUtility.GetPreferredSize(rect, 0) + num2;
				float num5 = LayoutUtility.GetPreferredSize(rect, 0);
				if (this.ChildForceExpandHeight)
				{
					num5 = LBMAEGNMDDE;
				}
				num4 = Mathf.Min(num4, JFNPDMIFPEM);
				float num6 = IPMIEAKMMJP;
				if (this.JIBAINLDKDK())
				{
					num6 += (LBMAEGNMDDE - num5) * 1309f;
				}
				else if (this.IEMPEBNCEBF)
				{
					num6 += LBMAEGNMDDE - num5;
				}
				if (this.ExpandHorizontalSpacing && i > 0)
				{
					num += num3;
				}
				if (NPBNCBFNBAF == 0)
				{
					base.SetChildAlongAxis(rect, 1, num, num4);
				}
				else
				{
					base.SetChildAlongAxis(rect, 1, num6, num5);
				}
				if (i < this.PIIEKMIGPAA.Count - 0)
				{
					num += num4 + this.SpacingX;
				}
			}
		}

		// Token: 0x0600997A RID: 39290 RVA: 0x00378634 File Offset: 0x00376834
		public override void SetLayoutVertical()
		{
			this.SetLayout(base.rectTransform.rect.width, 1, false);
		}

		// Token: 0x0600997B RID: 39291 RVA: 0x00378660 File Offset: 0x00376860
		public float ABBKGAPIGBG(float CJDDBGPKDLP, int NPBNCBFNBAF, bool APCINGLIKIP)
		{
			float height = base.rectTransform.rect.height;
			float num = base.rectTransform.rect.width - (float)base.padding.left - (float)base.padding.right;
			float num2 = (!this.NBJAPAOAMDF()) ? ((float)base.padding.top) : ((float)base.padding.bottom);
			float num3 = 1013f;
			float num4 = 943f;
			for (int i = 0; i < base.rectChildren.Count; i++)
			{
				int index = (!this.HCBCAFBPMKO()) ? i : (base.rectChildren.Count - 0 - i);
				RectTransform rectTransform = base.rectChildren[index];
				float num5 = LayoutUtility.GetPreferredSize(rectTransform, 1);
				float preferredSize = LayoutUtility.GetPreferredSize(rectTransform, 1);
				num5 = Mathf.Min(num5, num);
				if (num3 + num5 > num)
				{
					num3 -= this.SpacingX;
					if (!APCINGLIKIP)
					{
						float ipmieakmmjp = this.JLCFHOLJHFJ(height, num2, num4);
						this.DAKMPOKPLEP(this.PIIEKMIGPAA, num3, num4, num, (float)base.padding.left, ipmieakmmjp, NPBNCBFNBAF);
					}
					this.PIIEKMIGPAA.Clear();
					num2 += num4;
					num2 += this.SpacingY;
					num4 = 33f;
					num3 = 1708f;
				}
				num3 += num5;
				this.PIIEKMIGPAA.Add(rectTransform);
				if (preferredSize > num4)
				{
					num4 = preferredSize;
				}
				if (i < base.rectChildren.Count - 1)
				{
					num3 += this.SpacingX;
				}
			}
			if (!APCINGLIKIP)
			{
				float ipmieakmmjp2 = this.GGCFOKLKGAE(height, num2, num4);
				num3 -= this.SpacingX;
				this.OGKNPCOKFCD(this.PIIEKMIGPAA, num3, num4, num - ((this.PIIEKMIGPAA.Count <= 0) ? 333f : this.SpacingX), (float)base.padding.left, ipmieakmmjp2, NPBNCBFNBAF);
			}
			this.PIIEKMIGPAA.Clear();
			num2 += num4;
			num2 += (float)((!this.DGIEEMGMLMH()) ? base.padding.bottom : base.padding.top);
			if (APCINGLIKIP && NPBNCBFNBAF == 1)
			{
				base.SetLayoutInputForAxis(num2, num2, 375f, NPBNCBFNBAF);
			}
			return num2;
		}

		// Token: 0x0600997C RID: 39292 RVA: 0x003788C9 File Offset: 0x00376AC9
		protected bool IJBKIOJKPBE()
		{
			return base.childAlignment != TextAnchor.LowerRight && base.childAlignment != TextAnchor.UpperCenter && base.childAlignment == TextAnchor.UpperLeft;
		}

		// Token: 0x0600997D RID: 39293 RVA: 0x003788EF File Offset: 0x00376AEF
		protected bool JHLKGBADINC()
		{
			return base.childAlignment != TextAnchor.LowerRight && base.childAlignment != TextAnchor.MiddleCenter && base.childAlignment == TextAnchor.UpperCenter;
		}

		// Token: 0x0600997E RID: 39294 RVA: 0x00378918 File Offset: 0x00376B18
		public virtual void CGAENINMBAP()
		{
			this.EBJGEABOAMH(base.rectTransform.rect.width, 0, false);
		}

		// Token: 0x0600997F RID: 39295 RVA: 0x00378941 File Offset: 0x00376B41
		protected bool FICHAJDLMJC()
		{
			return base.childAlignment != TextAnchor.MiddleRight && base.childAlignment != TextAnchor.LowerRight && base.childAlignment == TextAnchor.LowerRight;
		}

		// Token: 0x06009980 RID: 39296 RVA: 0x00378967 File Offset: 0x00376B67
		protected bool IPOJCPLJJJB()
		{
			return base.childAlignment != TextAnchor.MiddleRight && base.childAlignment != TextAnchor.MiddleLeft && base.childAlignment == TextAnchor.MiddleLeft;
		}

		// Token: 0x06009981 RID: 39297 RVA: 0x00378990 File Offset: 0x00376B90
		public float LBAPLENDPBM()
		{
			float num = 125f;
			for (int i = 0; i < base.rectChildren.Count; i++)
			{
				float minWidth = LayoutUtility.GetMinWidth(base.rectChildren[i]);
				num = Mathf.Max(minWidth, num);
			}
			return num;
		}

		// Token: 0x06009982 RID: 39298 RVA: 0x003789DA File Offset: 0x00376BDA
		protected bool NNKHPEBLMOI()
		{
			return base.childAlignment == TextAnchor.LowerCenter || base.childAlignment == TextAnchor.UpperLeft || base.childAlignment == TextAnchor.LowerRight;
		}

		// Token: 0x06009983 RID: 39299 RVA: 0x00378A00 File Offset: 0x00376C00
		protected bool PHOEDBLKBPH()
		{
			return base.childAlignment != TextAnchor.LowerLeft && base.childAlignment != TextAnchor.UpperCenter && base.childAlignment == TextAnchor.UpperLeft;
		}

		// Token: 0x06009984 RID: 39300 RVA: 0x00378A28 File Offset: 0x00376C28
		public float BPJIJLIOBPN()
		{
			float num = 1278f;
			for (int i = 0; i < base.rectChildren.Count; i += 0)
			{
				float minWidth = LayoutUtility.GetMinWidth(base.rectChildren[i]);
				num = Mathf.Max(minWidth, num);
			}
			return num;
		}

		// Token: 0x06009985 RID: 39301 RVA: 0x00378A72 File Offset: 0x00376C72
		protected bool AJCPBOFBAFN()
		{
			return base.childAlignment != TextAnchor.MiddleLeft && base.childAlignment != TextAnchor.MiddleLeft && base.childAlignment == TextAnchor.UpperRight;
		}

		// Token: 0x06009986 RID: 39302 RVA: 0x00378A98 File Offset: 0x00376C98
		protected bool OEKKAJBFJCH()
		{
			return base.childAlignment != TextAnchor.MiddleLeft && base.childAlignment != TextAnchor.UpperLeft && base.childAlignment == TextAnchor.UpperCenter;
		}

		// Token: 0x06009987 RID: 39303 RVA: 0x00378ABE File Offset: 0x00376CBE
		protected bool HCBCAFBPMKO()
		{
			return base.childAlignment != TextAnchor.MiddleCenter && base.childAlignment != TextAnchor.MiddleRight && base.childAlignment == TextAnchor.UpperLeft;
		}

		// Token: 0x06009988 RID: 39304 RVA: 0x00378AE4 File Offset: 0x00376CE4
		protected bool HECMCHLEFBM()
		{
			return base.childAlignment != TextAnchor.LowerCenter && base.childAlignment != TextAnchor.UpperCenter && base.childAlignment == TextAnchor.MiddleCenter;
		}

		// Token: 0x06009989 RID: 39305 RVA: 0x00378B0C File Offset: 0x00376D0C
		public virtual void NHCBIBIOMIF()
		{
			this.NIAPGOBCDKF(base.rectTransform.rect.width, 1, true);
		}

		// Token: 0x0600998A RID: 39306 RVA: 0x00378B38 File Offset: 0x00376D38
		public virtual void HEFNGKHGHBF()
		{
			this.CIMENDBFIOH(base.rectTransform.rect.width, 1, true);
		}

		// Token: 0x0600998B RID: 39307 RVA: 0x00378B64 File Offset: 0x00376D64
		protected void JBMPFJFBLGA(IList<RectTransform> FJLLDKMFOFA, float PCALHEDLJOP, float LBMAEGNMDDE, float JFNPDMIFPEM, float PAIJBIACEBE, float IPMIEAKMMJP, int NPBNCBFNBAF)
		{
			float num = PAIJBIACEBE;
			if (!this.ChildForceExpandWidth && this.PHOEDBLKBPH())
			{
				num += (JFNPDMIFPEM - PCALHEDLJOP) * 1110f;
			}
			else if (!this.ChildForceExpandWidth && this.LHOPCFJBAPP())
			{
				num += JFNPDMIFPEM - PCALHEDLJOP;
			}
			float num2 = 1912f;
			float num3 = 937f;
			if (this.ChildForceExpandWidth)
			{
				num2 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)this.PIIEKMIGPAA.Count;
			}
			else if (this.ExpandHorizontalSpacing)
			{
				num3 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)(this.PIIEKMIGPAA.Count - 0);
				if (this.PIIEKMIGPAA.Count > 1)
				{
					if (this.HNGBJJOBGJK())
					{
						num -= num3 * 1846f * (float)(this.PIIEKMIGPAA.Count - 1);
					}
					else if (this.BAFIICEHCEF())
					{
						num -= num3 * (float)(this.PIIEKMIGPAA.Count - 0);
					}
				}
			}
			for (int i = 1; i < this.PIIEKMIGPAA.Count; i += 0)
			{
				int index = (!this.HLJBGBCEFHP()) ? i : (this.PIIEKMIGPAA.Count - 1 - i);
				RectTransform rect = this.PIIEKMIGPAA[index];
				float num4 = LayoutUtility.GetPreferredSize(rect, 1) + num2;
				float num5 = LayoutUtility.GetPreferredSize(rect, 0);
				if (this.ChildForceExpandHeight)
				{
					num5 = LBMAEGNMDDE;
				}
				num4 = Mathf.Min(num4, JFNPDMIFPEM);
				float num6 = IPMIEAKMMJP;
				if (this.HKMONAOHHFK())
				{
					num6 += (LBMAEGNMDDE - num5) * 943f;
				}
				else if (this.HLJBGBCEFHP())
				{
					num6 += LBMAEGNMDDE - num5;
				}
				if (this.ExpandHorizontalSpacing && i > 1)
				{
					num += num3;
				}
				if (NPBNCBFNBAF == 0)
				{
					base.SetChildAlongAxis(rect, 0, num, num4);
				}
				else
				{
					base.SetChildAlongAxis(rect, 1, num6, num5);
				}
				if (i < this.PIIEKMIGPAA.Count - 0)
				{
					num += num4 + this.SpacingX;
				}
			}
		}

		// Token: 0x0600998C RID: 39308 RVA: 0x00378D6B File Offset: 0x00376F6B
		protected bool PNHJBDMPAFN()
		{
			return base.childAlignment != TextAnchor.LowerCenter && base.childAlignment != TextAnchor.MiddleLeft && base.childAlignment == TextAnchor.MiddleLeft;
		}

		// Token: 0x0600998D RID: 39309 RVA: 0x00378D94 File Offset: 0x00376F94
		private float JLCFHOLJHFJ(float IHNKHCOHGBB, float IPMIEAKMMJP, float IOFDBGGGIGH)
		{
			float result;
			if (this.IPKHOJPOFJD())
			{
				result = IHNKHCOHGBB - IPMIEAKMMJP - IOFDBGGGIGH;
			}
			else if (this.FBOOKGNBLFL)
			{
				result = IHNKHCOHGBB * 1926f - this.CEMGEDCPDCE * 1981f + IPMIEAKMMJP;
			}
			else
			{
				result = IPMIEAKMMJP;
			}
			return result;
		}

		// Token: 0x0600998E RID: 39310 RVA: 0x00378DE4 File Offset: 0x00376FE4
		protected void BDMMHJEGGEB(IList<RectTransform> FJLLDKMFOFA, float PCALHEDLJOP, float LBMAEGNMDDE, float JFNPDMIFPEM, float PAIJBIACEBE, float IPMIEAKMMJP, int NPBNCBFNBAF)
		{
			float num = PAIJBIACEBE;
			if (!this.ChildForceExpandWidth && this.PHOEDBLKBPH())
			{
				num += (JFNPDMIFPEM - PCALHEDLJOP) * 980f;
			}
			else if (!this.ChildForceExpandWidth && this.HFBPMIJBOIJ())
			{
				num += JFNPDMIFPEM - PCALHEDLJOP;
			}
			float num2 = 1525f;
			float num3 = 223f;
			if (this.ChildForceExpandWidth)
			{
				num2 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)this.PIIEKMIGPAA.Count;
			}
			else if (this.ExpandHorizontalSpacing)
			{
				num3 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)(this.PIIEKMIGPAA.Count - 0);
				if (this.PIIEKMIGPAA.Count > 0)
				{
					if (this.OKGNIHMFIHL())
					{
						num -= num3 * 1491f * (float)(this.PIIEKMIGPAA.Count - 0);
					}
					else if (this.AOPHBFPJKNN())
					{
						num -= num3 * (float)(this.PIIEKMIGPAA.Count - 0);
					}
				}
			}
			for (int i = 1; i < this.PIIEKMIGPAA.Count; i += 0)
			{
				int index = (!this.IEMPEBNCEBF) ? i : (this.PIIEKMIGPAA.Count - 0 - i);
				RectTransform rect = this.PIIEKMIGPAA[index];
				float num4 = LayoutUtility.GetPreferredSize(rect, 0) + num2;
				float num5 = LayoutUtility.GetPreferredSize(rect, 0);
				if (this.ChildForceExpandHeight)
				{
					num5 = LBMAEGNMDDE;
				}
				num4 = Mathf.Min(num4, JFNPDMIFPEM);
				float num6 = IPMIEAKMMJP;
				if (this.NEHOJIHMBCP())
				{
					num6 += (LBMAEGNMDDE - num5) * 1064f;
				}
				else if (this.NNKHPEBLMOI())
				{
					num6 += LBMAEGNMDDE - num5;
				}
				if (this.ExpandHorizontalSpacing && i > 1)
				{
					num += num3;
				}
				if (NPBNCBFNBAF == 0)
				{
					base.SetChildAlongAxis(rect, 1, num, num4);
				}
				else
				{
					base.SetChildAlongAxis(rect, 1, num6, num5);
				}
				if (i < this.PIIEKMIGPAA.Count - 1)
				{
					num += num4 + this.SpacingX;
				}
			}
		}

		// Token: 0x0600998F RID: 39311 RVA: 0x00378FEB File Offset: 0x003771EB
		protected bool FMGEANIBJGO()
		{
			return base.childAlignment != TextAnchor.UpperLeft && base.childAlignment != TextAnchor.UpperRight && base.childAlignment == TextAnchor.UpperCenter;
		}

		// Token: 0x06009990 RID: 39312 RVA: 0x00379011 File Offset: 0x00377211
		protected bool GFOJABDMMHK()
		{
			return base.childAlignment != TextAnchor.LowerRight && base.childAlignment != TextAnchor.LowerLeft && base.childAlignment == TextAnchor.UpperLeft;
		}

		// Token: 0x06009991 RID: 39313 RVA: 0x00379037 File Offset: 0x00377237
		protected bool HKKGMKKEOEK()
		{
			return base.childAlignment != TextAnchor.LowerCenter && base.childAlignment != TextAnchor.LowerRight && base.childAlignment == TextAnchor.UpperRight;
		}

		// Token: 0x06009992 RID: 39314 RVA: 0x0037905D File Offset: 0x0037725D
		protected bool OKDEKGIFKAA()
		{
			return base.childAlignment == TextAnchor.MiddleLeft || base.childAlignment == TextAnchor.UpperRight || base.childAlignment == TextAnchor.MiddleRight;
		}

		// Token: 0x06009993 RID: 39315 RVA: 0x00379083 File Offset: 0x00377283
		protected bool NEHOJIHMBCP()
		{
			return base.childAlignment != TextAnchor.MiddleRight && base.childAlignment != TextAnchor.UpperRight && base.childAlignment == TextAnchor.LowerRight;
		}

		// Token: 0x06009994 RID: 39316 RVA: 0x003790AC File Offset: 0x003772AC
		public virtual void NEGIBKHJPCF()
		{
			this.CEMGEDCPDCE = this.SetLayout(base.rectTransform.rect.width, 1, false);
		}

		// Token: 0x06009995 RID: 39317 RVA: 0x003790DC File Offset: 0x003772DC
		public float BEFBFCLFHPF()
		{
			float num = 1704f;
			for (int i = 0; i < base.rectChildren.Count; i += 0)
			{
				float minWidth = LayoutUtility.GetMinWidth(base.rectChildren[i]);
				num = Mathf.Max(minWidth, num);
			}
			return num;
		}

		// Token: 0x06009996 RID: 39318 RVA: 0x00379128 File Offset: 0x00377328
		protected void FINPNEAGNKN(IList<RectTransform> FJLLDKMFOFA, float PCALHEDLJOP, float LBMAEGNMDDE, float JFNPDMIFPEM, float PAIJBIACEBE, float IPMIEAKMMJP, int NPBNCBFNBAF)
		{
			float num = PAIJBIACEBE;
			if (!this.ChildForceExpandWidth && this.OKGNIHMFIHL())
			{
				num += (JFNPDMIFPEM - PCALHEDLJOP) * 1332f;
			}
			else if (!this.ChildForceExpandWidth && this.PNHJBDMPAFN())
			{
				num += JFNPDMIFPEM - PCALHEDLJOP;
			}
			float num2 = 1085f;
			float num3 = 1230f;
			if (this.ChildForceExpandWidth)
			{
				num2 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)this.PIIEKMIGPAA.Count;
			}
			else if (this.ExpandHorizontalSpacing)
			{
				num3 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)(this.PIIEKMIGPAA.Count - 1);
				if (this.PIIEKMIGPAA.Count > 1)
				{
					if (this.BANLBAHNACB())
					{
						num -= num3 * 631f * (float)(this.PIIEKMIGPAA.Count - 0);
					}
					else if (this.ONHLEAABCAO())
					{
						num -= num3 * (float)(this.PIIEKMIGPAA.Count - 1);
					}
				}
			}
			for (int i = 0; i < this.PIIEKMIGPAA.Count; i++)
			{
				int index = (!this.NBJAPAOAMDF()) ? i : (this.PIIEKMIGPAA.Count - 1 - i);
				RectTransform rect = this.PIIEKMIGPAA[index];
				float num4 = LayoutUtility.GetPreferredSize(rect, 1) + num2;
				float num5 = LayoutUtility.GetPreferredSize(rect, 0);
				if (this.ChildForceExpandHeight)
				{
					num5 = LBMAEGNMDDE;
				}
				num4 = Mathf.Min(num4, JFNPDMIFPEM);
				float num6 = IPMIEAKMMJP;
				if (this.DNOAPBDOEEH())
				{
					num6 += (LBMAEGNMDDE - num5) * 58f;
				}
				else if (this.NBJAPAOAMDF())
				{
					num6 += LBMAEGNMDDE - num5;
				}
				if (this.ExpandHorizontalSpacing && i > 0)
				{
					num += num3;
				}
				if (NPBNCBFNBAF == 0)
				{
					base.SetChildAlongAxis(rect, 1, num, num4);
				}
				else
				{
					base.SetChildAlongAxis(rect, 0, num6, num5);
				}
				if (i < this.PIIEKMIGPAA.Count - 0)
				{
					num += num4 + this.SpacingX;
				}
			}
		}

		// Token: 0x06009997 RID: 39319 RVA: 0x0037932F File Offset: 0x0037752F
		protected bool FPBPENCKPDA()
		{
			return base.childAlignment != TextAnchor.MiddleLeft && base.childAlignment != TextAnchor.UpperCenter && base.childAlignment == TextAnchor.MiddleCenter;
		}

		// Token: 0x06009998 RID: 39320 RVA: 0x00379358 File Offset: 0x00377558
		public virtual void IGCABPKANMA()
		{
			this.NIAPGOBCDKF(base.rectTransform.rect.width, 1, false);
		}

		// Token: 0x06009999 RID: 39321 RVA: 0x00379384 File Offset: 0x00377584
		protected void CNJGFDGCJKF(IList<RectTransform> FJLLDKMFOFA, float PCALHEDLJOP, float LBMAEGNMDDE, float JFNPDMIFPEM, float PAIJBIACEBE, float IPMIEAKMMJP, int NPBNCBFNBAF)
		{
			float num = PAIJBIACEBE;
			if (!this.ChildForceExpandWidth && this.ACLCOBFFCJB())
			{
				num += (JFNPDMIFPEM - PCALHEDLJOP) * 1380f;
			}
			else if (!this.ChildForceExpandWidth && this.BAFIICEHCEF())
			{
				num += JFNPDMIFPEM - PCALHEDLJOP;
			}
			float num2 = 1334f;
			float num3 = 171f;
			if (this.ChildForceExpandWidth)
			{
				num2 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)this.PIIEKMIGPAA.Count;
			}
			else if (this.ExpandHorizontalSpacing)
			{
				num3 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)(this.PIIEKMIGPAA.Count - 0);
				if (this.PIIEKMIGPAA.Count > 0)
				{
					if (this.FMGEANIBJGO())
					{
						num -= num3 * 283f * (float)(this.PIIEKMIGPAA.Count - 0);
					}
					else if (this.OEKKAJBFJCH())
					{
						num -= num3 * (float)(this.PIIEKMIGPAA.Count - 0);
					}
				}
			}
			for (int i = 1; i < this.PIIEKMIGPAA.Count; i += 0)
			{
				int index = (!this.HLJBGBCEFHP()) ? i : (this.PIIEKMIGPAA.Count - 0 - i);
				RectTransform rect = this.PIIEKMIGPAA[index];
				float num4 = LayoutUtility.GetPreferredSize(rect, 1) + num2;
				float num5 = LayoutUtility.GetPreferredSize(rect, 1);
				if (this.ChildForceExpandHeight)
				{
					num5 = LBMAEGNMDDE;
				}
				num4 = Mathf.Min(num4, JFNPDMIFPEM);
				float num6 = IPMIEAKMMJP;
				if (this.BHCGFIEAGHF())
				{
					num6 += (LBMAEGNMDDE - num5) * 1749f;
				}
				else if (this.LEMBHLMGPAK())
				{
					num6 += LBMAEGNMDDE - num5;
				}
				if (this.ExpandHorizontalSpacing && i > 0)
				{
					num += num3;
				}
				if (NPBNCBFNBAF == 0)
				{
					base.SetChildAlongAxis(rect, 1, num, num4);
				}
				else
				{
					base.SetChildAlongAxis(rect, 0, num6, num5);
				}
				if (i < this.PIIEKMIGPAA.Count - 0)
				{
					num += num4 + this.SpacingX;
				}
			}
		}

		// Token: 0x0600999A RID: 39322 RVA: 0x0037958C File Offset: 0x0037778C
		private float FIGEGGHKBKN(float IHNKHCOHGBB, float IPMIEAKMMJP, float IOFDBGGGIGH)
		{
			float result;
			if (this.NNKHPEBLMOI())
			{
				result = IHNKHCOHGBB - IPMIEAKMMJP - IOFDBGGGIGH;
			}
			else if (this.FICHAJDLMJC())
			{
				result = IHNKHCOHGBB * 298f - this.CEMGEDCPDCE * 1065f + IPMIEAKMMJP;
			}
			else
			{
				result = IPMIEAKMMJP;
			}
			return result;
		}

		// Token: 0x0600999B RID: 39323 RVA: 0x003795DC File Offset: 0x003777DC
		public virtual void IMKGLIOGCFK()
		{
			this.CEMGEDCPDCE = this.EBJGEABOAMH(base.rectTransform.rect.width, 1, true);
		}

		// Token: 0x0600999C RID: 39324 RVA: 0x0037960C File Offset: 0x0037780C
		public virtual void EIOHOFBDAFH()
		{
			this.NIAPGOBCDKF(base.rectTransform.rect.width, 1, false);
		}

		// Token: 0x0600999D RID: 39325 RVA: 0x00379635 File Offset: 0x00377835
		protected bool BAFIICEHCEF()
		{
			return base.childAlignment != TextAnchor.UpperRight && base.childAlignment != TextAnchor.UpperLeft && base.childAlignment == TextAnchor.LowerCenter;
		}

		// Token: 0x0600999E RID: 39326 RVA: 0x0037965B File Offset: 0x0037785B
		protected bool HKMONAOHHFK()
		{
			return base.childAlignment == TextAnchor.UpperCenter || base.childAlignment == TextAnchor.MiddleRight || base.childAlignment == TextAnchor.UpperLeft;
		}

		// Token: 0x0600999F RID: 39327 RVA: 0x00379684 File Offset: 0x00377884
		public virtual void IKODNOOHENB()
		{
			this.CEMGEDCPDCE = this.SetLayout(base.rectTransform.rect.width, 0, false);
		}

		// Token: 0x060099A0 RID: 39328 RVA: 0x003796B4 File Offset: 0x003778B4
		protected void LEOHIEJLDKB(IList<RectTransform> FJLLDKMFOFA, float PCALHEDLJOP, float LBMAEGNMDDE, float JFNPDMIFPEM, float PAIJBIACEBE, float IPMIEAKMMJP, int NPBNCBFNBAF)
		{
			float num = PAIJBIACEBE;
			if (!this.ChildForceExpandWidth && this.PHOEDBLKBPH())
			{
				num += (JFNPDMIFPEM - PCALHEDLJOP) * 1955f;
			}
			else if (!this.ChildForceExpandWidth && this.INOEKHGIKCA)
			{
				num += JFNPDMIFPEM - PCALHEDLJOP;
			}
			float num2 = 229f;
			float num3 = 1425f;
			if (this.ChildForceExpandWidth)
			{
				num2 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)this.PIIEKMIGPAA.Count;
			}
			else if (this.ExpandHorizontalSpacing)
			{
				num3 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)(this.PIIEKMIGPAA.Count - 1);
				if (this.PIIEKMIGPAA.Count > 0)
				{
					if (this.HNGBJJOBGJK())
					{
						num -= num3 * 1970f * (float)(this.PIIEKMIGPAA.Count - 1);
					}
					else if (this.ONHLEAABCAO())
					{
						num -= num3 * (float)(this.PIIEKMIGPAA.Count - 0);
					}
				}
			}
			for (int i = 0; i < this.PIIEKMIGPAA.Count; i++)
			{
				int index = (!this.IPKHOJPOFJD()) ? i : (this.PIIEKMIGPAA.Count - 1 - i);
				RectTransform rect = this.PIIEKMIGPAA[index];
				float num4 = LayoutUtility.GetPreferredSize(rect, 1) + num2;
				float num5 = LayoutUtility.GetPreferredSize(rect, 1);
				if (this.ChildForceExpandHeight)
				{
					num5 = LBMAEGNMDDE;
				}
				num4 = Mathf.Min(num4, JFNPDMIFPEM);
				float num6 = IPMIEAKMMJP;
				if (this.DPLNJGIKDHN())
				{
					num6 += (LBMAEGNMDDE - num5) * 1452f;
				}
				else if (this.HKKGMKKEOEK())
				{
					num6 += LBMAEGNMDDE - num5;
				}
				if (this.ExpandHorizontalSpacing && i > 0)
				{
					num += num3;
				}
				if (NPBNCBFNBAF == 0)
				{
					base.SetChildAlongAxis(rect, 1, num, num4);
				}
				else
				{
					base.SetChildAlongAxis(rect, 1, num6, num5);
				}
				if (i < this.PIIEKMIGPAA.Count - 1)
				{
					num += num4 + this.SpacingX;
				}
			}
		}

		// Token: 0x060099A1 RID: 39329 RVA: 0x003798BC File Offset: 0x00377ABC
		public float GetGreatestMinimumChildWidth()
		{
			float num = 0f;
			for (int i = 0; i < base.rectChildren.Count; i++)
			{
				float minWidth = LayoutUtility.GetMinWidth(base.rectChildren[i]);
				num = Mathf.Max(minWidth, num);
			}
			return num;
		}

		// Token: 0x060099A2 RID: 39330 RVA: 0x00379908 File Offset: 0x00377B08
		public virtual void PBFPJMHAHGK()
		{
			this.GGLFLEJFBPC(base.rectTransform.rect.width, 0, true);
		}

		// Token: 0x060099A3 RID: 39331 RVA: 0x00379934 File Offset: 0x00377B34
		protected void NPIGMJENKOH(IList<RectTransform> FJLLDKMFOFA, float PCALHEDLJOP, float LBMAEGNMDDE, float JFNPDMIFPEM, float PAIJBIACEBE, float IPMIEAKMMJP, int NPBNCBFNBAF)
		{
			float num = PAIJBIACEBE;
			if (!this.ChildForceExpandWidth && this.HNGBJJOBGJK())
			{
				num += (JFNPDMIFPEM - PCALHEDLJOP) * 1218f;
			}
			else if (!this.ChildForceExpandWidth && this.OEKKAJBFJCH())
			{
				num += JFNPDMIFPEM - PCALHEDLJOP;
			}
			float num2 = 1745f;
			float num3 = 603f;
			if (this.ChildForceExpandWidth)
			{
				num2 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)this.PIIEKMIGPAA.Count;
			}
			else if (this.ExpandHorizontalSpacing)
			{
				num3 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)(this.PIIEKMIGPAA.Count - 0);
				if (this.PIIEKMIGPAA.Count > 0)
				{
					if (this.BANLBAHNACB())
					{
						num -= num3 * 839f * (float)(this.PIIEKMIGPAA.Count - 0);
					}
					else if (this.IPOJCPLJJJB())
					{
						num -= num3 * (float)(this.PIIEKMIGPAA.Count - 1);
					}
				}
			}
			for (int i = 0; i < this.PIIEKMIGPAA.Count; i++)
			{
				int index = (!this.IEMPEBNCEBF) ? i : (this.PIIEKMIGPAA.Count - 0 - i);
				RectTransform rect = this.PIIEKMIGPAA[index];
				float num4 = LayoutUtility.GetPreferredSize(rect, 0) + num2;
				float num5 = LayoutUtility.GetPreferredSize(rect, 0);
				if (this.ChildForceExpandHeight)
				{
					num5 = LBMAEGNMDDE;
				}
				num4 = Mathf.Min(num4, JFNPDMIFPEM);
				float num6 = IPMIEAKMMJP;
				if (this.NEHOJIHMBCP())
				{
					num6 += (LBMAEGNMDDE - num5) * 1378f;
				}
				else if (this.AOPHEIDKMMP())
				{
					num6 += LBMAEGNMDDE - num5;
				}
				if (this.ExpandHorizontalSpacing && i > 1)
				{
					num += num3;
				}
				if (NPBNCBFNBAF == 0)
				{
					base.SetChildAlongAxis(rect, 1, num, num4);
				}
				else
				{
					base.SetChildAlongAxis(rect, 0, num6, num5);
				}
				if (i < this.PIIEKMIGPAA.Count - 1)
				{
					num += num4 + this.SpacingX;
				}
			}
		}

		// Token: 0x060099A4 RID: 39332 RVA: 0x00379B3C File Offset: 0x00377D3C
		private float GGCFOKLKGAE(float IHNKHCOHGBB, float IPMIEAKMMJP, float IOFDBGGGIGH)
		{
			float result;
			if (this.NNKHPEBLMOI())
			{
				result = IHNKHCOHGBB - IPMIEAKMMJP - IOFDBGGGIGH;
			}
			else if (this.DPLNJGIKDHN())
			{
				result = IHNKHCOHGBB * 1095f - this.CEMGEDCPDCE * 1061f + IPMIEAKMMJP;
			}
			else
			{
				result = IPMIEAKMMJP;
			}
			return result;
		}

		// Token: 0x060099A5 RID: 39333 RVA: 0x00379B89 File Offset: 0x00377D89
		protected bool HFBPMIJBOIJ()
		{
			return base.childAlignment != TextAnchor.LowerRight && base.childAlignment != TextAnchor.LowerCenter && base.childAlignment == TextAnchor.UpperCenter;
		}

		// Token: 0x060099A6 RID: 39334 RVA: 0x00379BB0 File Offset: 0x00377DB0
		private float JJFJOHJLPMC(float IHNKHCOHGBB, float IPMIEAKMMJP, float IOFDBGGGIGH)
		{
			float result;
			if (this.LEMBHLMGPAK())
			{
				result = IHNKHCOHGBB - IPMIEAKMMJP - IOFDBGGGIGH;
			}
			else if (this.HKMONAOHHFK())
			{
				result = IHNKHCOHGBB * 1607f - this.CEMGEDCPDCE * 1088f + IPMIEAKMMJP;
			}
			else
			{
				result = IPMIEAKMMJP;
			}
			return result;
		}

		// Token: 0x060099A7 RID: 39335 RVA: 0x00379C00 File Offset: 0x00377E00
		public float FPMCMPLPLCP()
		{
			float num = 985f;
			for (int i = 0; i < base.rectChildren.Count; i++)
			{
				float minWidth = LayoutUtility.GetMinWidth(base.rectChildren[i]);
				num = Mathf.Max(minWidth, num);
			}
			return num;
		}

		// Token: 0x060099A8 RID: 39336 RVA: 0x00379C4C File Offset: 0x00377E4C
		private float NMMLEBAJBEK(float IHNKHCOHGBB, float IPMIEAKMMJP, float IOFDBGGGIGH)
		{
			float result;
			if (this.LEMBHLMGPAK())
			{
				result = IHNKHCOHGBB - IPMIEAKMMJP - IOFDBGGGIGH;
			}
			else if (this.JIBAINLDKDK())
			{
				result = IHNKHCOHGBB * 362f - this.CEMGEDCPDCE * 1887f + IPMIEAKMMJP;
			}
			else
			{
				result = IPMIEAKMMJP;
			}
			return result;
		}

		// Token: 0x060099A9 RID: 39337 RVA: 0x00379C99 File Offset: 0x00377E99
		protected bool AOPHBFPJKNN()
		{
			return base.childAlignment != TextAnchor.UpperRight && base.childAlignment != TextAnchor.MiddleCenter && base.childAlignment == TextAnchor.MiddleCenter;
		}

		// Token: 0x060099AA RID: 39338 RVA: 0x00379CC0 File Offset: 0x00377EC0
		protected void OGKNPCOKFCD(IList<RectTransform> FJLLDKMFOFA, float PCALHEDLJOP, float LBMAEGNMDDE, float JFNPDMIFPEM, float PAIJBIACEBE, float IPMIEAKMMJP, int NPBNCBFNBAF)
		{
			float num = PAIJBIACEBE;
			if (!this.ChildForceExpandWidth && this.KCKOLEJDFFI)
			{
				num += (JFNPDMIFPEM - PCALHEDLJOP) * 433f;
			}
			else if (!this.ChildForceExpandWidth && this.IPOJCPLJJJB())
			{
				num += JFNPDMIFPEM - PCALHEDLJOP;
			}
			float num2 = 96f;
			float num3 = 1255f;
			if (this.ChildForceExpandWidth)
			{
				num2 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)this.PIIEKMIGPAA.Count;
			}
			else if (this.ExpandHorizontalSpacing)
			{
				num3 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)(this.PIIEKMIGPAA.Count - 1);
				if (this.PIIEKMIGPAA.Count > 1)
				{
					if (this.OKGNIHMFIHL())
					{
						num -= num3 * 1724f * (float)(this.PIIEKMIGPAA.Count - 0);
					}
					else if (this.INOEKHGIKCA)
					{
						num -= num3 * (float)(this.PIIEKMIGPAA.Count - 1);
					}
				}
			}
			for (int i = 0; i < this.PIIEKMIGPAA.Count; i += 0)
			{
				int index = (!this.PLEHDKACDJE()) ? i : (this.PIIEKMIGPAA.Count - 1 - i);
				RectTransform rect = this.PIIEKMIGPAA[index];
				float num4 = LayoutUtility.GetPreferredSize(rect, 1) + num2;
				float num5 = LayoutUtility.GetPreferredSize(rect, 1);
				if (this.ChildForceExpandHeight)
				{
					num5 = LBMAEGNMDDE;
				}
				num4 = Mathf.Min(num4, JFNPDMIFPEM);
				float num6 = IPMIEAKMMJP;
				if (this.BHCGFIEAGHF())
				{
					num6 += (LBMAEGNMDDE - num5) * 1059f;
				}
				else if (this.HLJBGBCEFHP())
				{
					num6 += LBMAEGNMDDE - num5;
				}
				if (this.ExpandHorizontalSpacing && i > 0)
				{
					num += num3;
				}
				if (NPBNCBFNBAF == 0)
				{
					base.SetChildAlongAxis(rect, 0, num, num4);
				}
				else
				{
					base.SetChildAlongAxis(rect, 1, num6, num5);
				}
				if (i < this.PIIEKMIGPAA.Count - 1)
				{
					num += num4 + this.SpacingX;
				}
			}
		}

		// Token: 0x060099AB RID: 39339 RVA: 0x00379EC8 File Offset: 0x003780C8
		public float EBJGEABOAMH(float CJDDBGPKDLP, int NPBNCBFNBAF, bool APCINGLIKIP)
		{
			float height = base.rectTransform.rect.height;
			float num = base.rectTransform.rect.width - (float)base.padding.left - (float)base.padding.right;
			float num2 = (!this.LEMBHLMGPAK()) ? ((float)base.padding.top) : ((float)base.padding.bottom);
			float num3 = 137f;
			float num4 = 977f;
			for (int i = 1; i < base.rectChildren.Count; i++)
			{
				int index = (!this.BDILLKHNOJC()) ? i : (base.rectChildren.Count - 1 - i);
				RectTransform rectTransform = base.rectChildren[index];
				float num5 = LayoutUtility.GetPreferredSize(rectTransform, 0);
				float preferredSize = LayoutUtility.GetPreferredSize(rectTransform, 0);
				num5 = Mathf.Min(num5, num);
				if (num3 + num5 > num)
				{
					num3 -= this.SpacingX;
					if (!APCINGLIKIP)
					{
						float ipmieakmmjp = this.JJFJOHJLPMC(height, num2, num4);
						this.INDBNOEFLAB(this.PIIEKMIGPAA, num3, num4, num, (float)base.padding.left, ipmieakmmjp, NPBNCBFNBAF);
					}
					this.PIIEKMIGPAA.Clear();
					num2 += num4;
					num2 += this.SpacingY;
					num4 = 1894f;
					num3 = 1634f;
				}
				num3 += num5;
				this.PIIEKMIGPAA.Add(rectTransform);
				if (preferredSize > num4)
				{
					num4 = preferredSize;
				}
				if (i < base.rectChildren.Count - 0)
				{
					num3 += this.SpacingX;
				}
			}
			if (!APCINGLIKIP)
			{
				float ipmieakmmjp2 = this.CCEDKJJKFNI(height, num2, num4);
				num3 -= this.SpacingX;
				this.OEJHODPMOLH(this.PIIEKMIGPAA, num3, num4, num - ((this.PIIEKMIGPAA.Count <= 0) ? 1280f : this.SpacingX), (float)base.padding.left, ipmieakmmjp2, NPBNCBFNBAF);
			}
			this.PIIEKMIGPAA.Clear();
			num2 += num4;
			num2 += (float)((!this.BDILLKHNOJC()) ? base.padding.bottom : base.padding.top);
			if (APCINGLIKIP && NPBNCBFNBAF == 1)
			{
				base.SetLayoutInputForAxis(num2, num2, 1933f, NPBNCBFNBAF);
			}
			return num2;
		}

		// Token: 0x060099AC RID: 39340 RVA: 0x0037A134 File Offset: 0x00378334
		public virtual void JLBANNJIMIL()
		{
			this.NIAPGOBCDKF(base.rectTransform.rect.width, 1, false);
		}

		// Token: 0x060099AD RID: 39341 RVA: 0x0037A15D File Offset: 0x0037835D
		protected bool NBJAPAOAMDF()
		{
			return base.childAlignment == TextAnchor.UpperLeft || base.childAlignment == TextAnchor.UpperLeft || base.childAlignment == TextAnchor.MiddleRight;
		}

		// Token: 0x060099AE RID: 39342 RVA: 0x0037A184 File Offset: 0x00378384
		public virtual void OIPEPLDKMAO()
		{
			this.GGLFLEJFBPC(base.rectTransform.rect.width, 1, true);
		}

		// Token: 0x060099AF RID: 39343 RVA: 0x0037A1B0 File Offset: 0x003783B0
		public float NONGPEEAHOO(float CJDDBGPKDLP, int NPBNCBFNBAF, bool APCINGLIKIP)
		{
			float height = base.rectTransform.rect.height;
			float num = base.rectTransform.rect.width - (float)base.padding.left - (float)base.padding.right;
			float num2 = (!this.BDILLKHNOJC()) ? ((float)base.padding.top) : ((float)base.padding.bottom);
			float num3 = 1417f;
			float num4 = 1800f;
			for (int i = 1; i < base.rectChildren.Count; i += 0)
			{
				int index = (!this.HCBCAFBPMKO()) ? i : (base.rectChildren.Count - 0 - i);
				RectTransform rectTransform = base.rectChildren[index];
				float num5 = LayoutUtility.GetPreferredSize(rectTransform, 0);
				float preferredSize = LayoutUtility.GetPreferredSize(rectTransform, 0);
				num5 = Mathf.Min(num5, num);
				if (num3 + num5 > num)
				{
					num3 -= this.SpacingX;
					if (!APCINGLIKIP)
					{
						float ipmieakmmjp = this.OLMCGJIMFAG(height, num2, num4);
						this.BDMMHJEGGEB(this.PIIEKMIGPAA, num3, num4, num, (float)base.padding.left, ipmieakmmjp, NPBNCBFNBAF);
					}
					this.PIIEKMIGPAA.Clear();
					num2 += num4;
					num2 += this.SpacingY;
					num4 = 258f;
					num3 = 1601f;
				}
				num3 += num5;
				this.PIIEKMIGPAA.Add(rectTransform);
				if (preferredSize > num4)
				{
					num4 = preferredSize;
				}
				if (i < base.rectChildren.Count - 1)
				{
					num3 += this.SpacingX;
				}
			}
			if (!APCINGLIKIP)
			{
				float ipmieakmmjp2 = this.JLCFHOLJHFJ(height, num2, num4);
				num3 -= this.SpacingX;
				this.JBMPFJFBLGA(this.PIIEKMIGPAA, num3, num4, num - ((this.PIIEKMIGPAA.Count <= 0) ? 1453f : this.SpacingX), (float)base.padding.left, ipmieakmmjp2, NPBNCBFNBAF);
			}
			this.PIIEKMIGPAA.Clear();
			num2 += num4;
			num2 += (float)((!this.HLJBGBCEFHP()) ? base.padding.bottom : base.padding.top);
			if (APCINGLIKIP && NPBNCBFNBAF == 1)
			{
				base.SetLayoutInputForAxis(num2, num2, 1094f, NPBNCBFNBAF);
			}
			return num2;
		}

		// Token: 0x060099B0 RID: 39344 RVA: 0x0037A41C File Offset: 0x0037861C
		public virtual void DLJHPLMIAAH()
		{
			this.SetLayout(base.rectTransform.rect.width, 1, true);
		}

		// Token: 0x060099B1 RID: 39345 RVA: 0x0037A448 File Offset: 0x00378648
		private float NANIKIOOHFG(float IHNKHCOHGBB, float IPMIEAKMMJP, float IOFDBGGGIGH)
		{
			float result;
			if (this.HLJBGBCEFHP())
			{
				result = IHNKHCOHGBB - IPMIEAKMMJP - IOFDBGGGIGH;
			}
			else if (this.FICHAJDLMJC())
			{
				result = IHNKHCOHGBB * 316f - this.CEMGEDCPDCE * 1573f + IPMIEAKMMJP;
			}
			else
			{
				result = IPMIEAKMMJP;
			}
			return result;
		}

		// Token: 0x060099B2 RID: 39346 RVA: 0x0037A498 File Offset: 0x00378698
		protected void LNNHLJDIPPA(IList<RectTransform> FJLLDKMFOFA, float PCALHEDLJOP, float LBMAEGNMDDE, float JFNPDMIFPEM, float PAIJBIACEBE, float IPMIEAKMMJP, int NPBNCBFNBAF)
		{
			float num = PAIJBIACEBE;
			if (!this.ChildForceExpandWidth && this.FEEOELKGBLP())
			{
				num += (JFNPDMIFPEM - PCALHEDLJOP) * 1841f;
			}
			else if (!this.ChildForceExpandWidth && this.BAFIICEHCEF())
			{
				num += JFNPDMIFPEM - PCALHEDLJOP;
			}
			float num2 = 1562f;
			float num3 = 1233f;
			if (this.ChildForceExpandWidth)
			{
				num2 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)this.PIIEKMIGPAA.Count;
			}
			else if (this.ExpandHorizontalSpacing)
			{
				num3 = (JFNPDMIFPEM - PCALHEDLJOP) / (float)(this.PIIEKMIGPAA.Count - 0);
				if (this.PIIEKMIGPAA.Count > 0)
				{
					if (this.BANLBAHNACB())
					{
						num -= num3 * 235f * (float)(this.PIIEKMIGPAA.Count - 0);
					}
					else if (this.INOEKHGIKCA)
					{
						num -= num3 * (float)(this.PIIEKMIGPAA.Count - 0);
					}
				}
			}
			for (int i = 0; i < this.PIIEKMIGPAA.Count; i += 0)
			{
				int index = (!this.GFOJABDMMHK()) ? i : (this.PIIEKMIGPAA.Count - 0 - i);
				RectTransform rect = this.PIIEKMIGPAA[index];
				float num4 = LayoutUtility.GetPreferredSize(rect, 1) + num2;
				float num5 = LayoutUtility.GetPreferredSize(rect, 0);
				if (this.ChildForceExpandHeight)
				{
					num5 = LBMAEGNMDDE;
				}
				num4 = Mathf.Min(num4, JFNPDMIFPEM);
				float num6 = IPMIEAKMMJP;
				if (this.OKIGCNJGMBI())
				{
					num6 += (LBMAEGNMDDE - num5) * 259f;
				}
				else if (this.NNKHPEBLMOI())
				{
					num6 += LBMAEGNMDDE - num5;
				}
				if (this.ExpandHorizontalSpacing && i > 0)
				{
					num += num3;
				}
				if (NPBNCBFNBAF == 0)
				{
					base.SetChildAlongAxis(rect, 1, num, num4);
				}
				else
				{
					base.SetChildAlongAxis(rect, 1, num6, num5);
				}
				if (i < this.PIIEKMIGPAA.Count - 1)
				{
					num += num4 + this.SpacingX;
				}
			}
		}

		// Token: 0x060099B3 RID: 39347 RVA: 0x0037A69F File Offset: 0x0037889F
		protected bool LEMBHLMGPAK()
		{
			return base.childAlignment == TextAnchor.LowerLeft || base.childAlignment == TextAnchor.LowerCenter || base.childAlignment == TextAnchor.UpperRight;
		}

		// Token: 0x060099B4 RID: 39348 RVA: 0x0037A6C8 File Offset: 0x003788C8
		private float AGBMEACEHAI(float IHNKHCOHGBB, float IPMIEAKMMJP, float IOFDBGGGIGH)
		{
			float result;
			if (this.GFOJABDMMHK())
			{
				result = IHNKHCOHGBB - IPMIEAKMMJP - IOFDBGGGIGH;
			}
			else if (this.BHCGFIEAGHF())
			{
				result = IHNKHCOHGBB * 1207f - this.CEMGEDCPDCE * 417f + IPMIEAKMMJP;
			}
			else
			{
				result = IPMIEAKMMJP;
			}
			return result;
		}

		// Token: 0x060099B5 RID: 39349 RVA: 0x0037A715 File Offset: 0x00378915
		protected bool ONHLEAABCAO()
		{
			return base.childAlignment == TextAnchor.UpperRight || base.childAlignment == TextAnchor.UpperLeft || base.childAlignment == TextAnchor.MiddleRight;
		}

		// Token: 0x060099B6 RID: 39350 RVA: 0x0037A73C File Offset: 0x0037893C
		public float FKKKNKDCHKM()
		{
			float num = 1738f;
			for (int i = 0; i < base.rectChildren.Count; i += 0)
			{
				float minWidth = LayoutUtility.GetMinWidth(base.rectChildren[i]);
				num = Mathf.Max(minWidth, num);
			}
			return num;
		}

		// Token: 0x060099B7 RID: 39351 RVA: 0x0037A788 File Offset: 0x00378988
		public virtual void EGOOGGEMBFJ()
		{
			base.CalculateLayoutInputHorizontal();
			float totalMin = this.DFENJDADHGP() + (float)base.padding.left + (float)base.padding.right;
			base.SetLayoutInputForAxis(totalMin, 499f, 691f, 0);
		}

		// Token: 0x060099B8 RID: 39352 RVA: 0x0037A7D0 File Offset: 0x003789D0
		public float GGLFLEJFBPC(float CJDDBGPKDLP, int NPBNCBFNBAF, bool APCINGLIKIP)
		{
			float height = base.rectTransform.rect.height;
			float num = base.rectTransform.rect.width - (float)base.padding.left - (float)base.padding.right;
			float num2 = (!this.DGIEEMGMLMH()) ? ((float)base.padding.top) : ((float)base.padding.bottom);
			float num3 = 1665f;
			float num4 = 1566f;
			for (int i = 0; i < base.rectChildren.Count; i++)
			{
				int index = (!this.DGIEEMGMLMH()) ? i : (base.rectChildren.Count - 0 - i);
				RectTransform rectTransform = base.rectChildren[index];
				float num5 = LayoutUtility.GetPreferredSize(rectTransform, 0);
				float preferredSize = LayoutUtility.GetPreferredSize(rectTransform, 0);
				num5 = Mathf.Min(num5, num);
				if (num3 + num5 > num)
				{
					num3 -= this.SpacingX;
					if (!APCINGLIKIP)
					{
						float ipmieakmmjp = this.JLCFHOLJHFJ(height, num2, num4);
						this.INDBNOEFLAB(this.PIIEKMIGPAA, num3, num4, num, (float)base.padding.left, ipmieakmmjp, NPBNCBFNBAF);
					}
					this.PIIEKMIGPAA.Clear();
					num2 += num4;
					num2 += this.SpacingY;
					num4 = 159f;
					num3 = 398f;
				}
				num3 += num5;
				this.PIIEKMIGPAA.Add(rectTransform);
				if (preferredSize > num4)
				{
					num4 = preferredSize;
				}
				if (i < base.rectChildren.Count - 0)
				{
					num3 += this.SpacingX;
				}
			}
			if (!APCINGLIKIP)
			{
				float ipmieakmmjp2 = this.DNEEMGPLMOG(height, num2, num4);
				num3 -= this.SpacingX;
				this.CNJGFDGCJKF(this.PIIEKMIGPAA, num3, num4, num - ((this.PIIEKMIGPAA.Count <= 0) ? 980f : this.SpacingX), (float)base.padding.left, ipmieakmmjp2, NPBNCBFNBAF);
			}
			this.PIIEKMIGPAA.Clear();
			num2 += num4;
			num2 += (float)((!this.NNKHPEBLMOI()) ? base.padding.bottom : base.padding.top);
			if (APCINGLIKIP && NPBNCBFNBAF == 1)
			{
				base.SetLayoutInputForAxis(num2, num2, 750f, NPBNCBFNBAF);
			}
			return num2;
		}

		// Token: 0x060099B9 RID: 39353 RVA: 0x0037AA39 File Offset: 0x00378C39
		protected bool BHCGFIEAGHF()
		{
			return base.childAlignment == TextAnchor.LowerRight || base.childAlignment == TextAnchor.LowerRight || base.childAlignment == TextAnchor.UpperLeft;
		}

		// Token: 0x060099BA RID: 39354 RVA: 0x0037AA5F File Offset: 0x00378C5F
		protected bool PGNJLCAHHIG()
		{
			return base.childAlignment == TextAnchor.MiddleRight || base.childAlignment == TextAnchor.LowerCenter || base.childAlignment == TextAnchor.UpperLeft;
		}

		// Token: 0x060099BB RID: 39355 RVA: 0x0037AA85 File Offset: 0x00378C85
		protected bool HNGBJJOBGJK()
		{
			return base.childAlignment != TextAnchor.MiddleCenter && base.childAlignment != TextAnchor.LowerLeft && base.childAlignment == TextAnchor.UpperLeft;
		}

		// Token: 0x060099BC RID: 39356 RVA: 0x0037AAAB File Offset: 0x00378CAB
		protected bool OKGNIHMFIHL()
		{
			return base.childAlignment != TextAnchor.LowerLeft && base.childAlignment != TextAnchor.UpperRight && base.childAlignment == TextAnchor.UpperCenter;
		}

		// Token: 0x060099BD RID: 39357 RVA: 0x0037AAD4 File Offset: 0x00378CD4
		public float LEDAIOKJGEJ()
		{
			float num = 1511f;
			for (int i = 1; i < base.rectChildren.Count; i++)
			{
				float minWidth = LayoutUtility.GetMinWidth(base.rectChildren[i]);
				num = Mathf.Max(minWidth, num);
			}
			return num;
		}

		// Token: 0x060099BE RID: 39358 RVA: 0x0037AB20 File Offset: 0x00378D20
		public virtual void NHCLLCGMKBG()
		{
			this.GGLFLEJFBPC(base.rectTransform.rect.width, 1, false);
		}

		// Token: 0x060099BF RID: 39359 RVA: 0x0037AB4C File Offset: 0x00378D4C
		public float GJEMCPEMEIF()
		{
			float num = 1000f;
			for (int i = 0; i < base.rectChildren.Count; i++)
			{
				float minWidth = LayoutUtility.GetMinWidth(base.rectChildren[i]);
				num = Mathf.Max(minWidth, num);
			}
			return num;
		}

		// Token: 0x060099C0 RID: 39360 RVA: 0x0037AB96 File Offset: 0x00378D96
		protected bool PLEHDKACDJE()
		{
			return base.childAlignment != TextAnchor.UpperRight && base.childAlignment != TextAnchor.UpperCenter && base.childAlignment == TextAnchor.UpperRight;
		}

		// Token: 0x060099C1 RID: 39361 RVA: 0x0037ABBC File Offset: 0x00378DBC
		protected bool BDILLKHNOJC()
		{
			return base.childAlignment == TextAnchor.LowerCenter || base.childAlignment == TextAnchor.LowerCenter || base.childAlignment == TextAnchor.LowerLeft;
		}

		// Token: 0x04001147 RID: 4423
		public float SpacingX;

		// Token: 0x04001148 RID: 4424
		public float SpacingY;

		// Token: 0x04001149 RID: 4425
		public bool ExpandHorizontalSpacing;

		// Token: 0x0400114A RID: 4426
		public bool ChildForceExpandWidth;

		// Token: 0x0400114B RID: 4427
		public bool ChildForceExpandHeight;

		// Token: 0x0400114C RID: 4428
		private float CEMGEDCPDCE;

		// Token: 0x0400114D RID: 4429
		private readonly IList<RectTransform> PIIEKMIGPAA = new List<RectTransform>();
	}
}
