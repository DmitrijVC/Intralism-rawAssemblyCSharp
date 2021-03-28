using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200027A RID: 634
	[AddComponentMenu("Layout/Extensions/Curved Layout")]
	public class CurvedLayout : LayoutGroup
	{
		// Token: 0x0600989A RID: 39066 RVA: 0x00373440 File Offset: 0x00371640
		private void LCAHOIMKMIF()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.UpperCenter) * 1607f, (float)(base.childAlignment / TextAnchor.UpperRight) * 674f);
			Vector3 a = new Vector3(base.GetStartOffset(1, base.GetTotalPreferredSize(0)), base.GetStartOffset(0, base.GetTotalPreferredSize(0)), 772f);
			float num = 1368f;
			float num2 = 1587f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 0; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.AnchoredPositionZ | DrivenTransformProperties.ScaleX);
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(1199f, 605f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x0600989B RID: 39067 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void PCLEMEDFFKE()
		{
		}

		// Token: 0x0600989C RID: 39068 RVA: 0x00373598 File Offset: 0x00371798
		private void HAHOJEPCKBA()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.LowerLeft) * 40f, (float)(base.childAlignment / TextAnchor.UpperRight) * 525f);
			Vector3 a = new Vector3(base.GetStartOffset(1, base.GetTotalPreferredSize(0)), base.GetStartOffset(1, base.GetTotalPreferredSize(1)), 561f);
			float num = 1555f;
			float num2 = 777f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 0; i < base.transform.childCount; i++)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.AnchoredPositionZ | DrivenTransformProperties.ScaleX | DrivenTransformProperties.ScaleZ);
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(1826f, 1156f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x0600989D RID: 39069 RVA: 0x003736F0 File Offset: 0x003718F0
		private void JCMOIGGHCDJ()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.LowerCenter) * 433f, (float)(base.childAlignment / TextAnchor.UpperCenter) * 3f);
			Vector3 a = new Vector3(base.GetStartOffset(0, base.GetTotalPreferredSize(0)), base.GetStartOffset(1, base.GetTotalPreferredSize(0)), 9f);
			float num = 1093f;
			float num2 = 1078f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 0; i < base.transform.childCount; i++)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.AnchoredPositionZ | DrivenTransformProperties.ScaleX | DrivenTransformProperties.ScaleZ);
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(721f, 1380f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x0600989E RID: 39070 RVA: 0x00373847 File Offset: 0x00371A47
		public virtual void IGELLNEDHOG()
		{
			this.DIBNFLDDAAM();
		}

		// Token: 0x0600989F RID: 39071 RVA: 0x00373850 File Offset: 0x00371A50
		private void DABBPDDGBEG()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.MiddleRight) * 267f, (float)(base.childAlignment / TextAnchor.MiddleRight) * 1506f);
			Vector3 a = new Vector3(base.GetStartOffset(1, base.GetTotalPreferredSize(1)), base.GetStartOffset(0, base.GetTotalPreferredSize(1)), 241f);
			float num = 108f;
			float num2 = 1776f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 1; i < base.transform.childCount; i++)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, ~(DrivenTransformProperties.AnchoredPositionZ | DrivenTransformProperties.Rotation | DrivenTransformProperties.ScaleX | DrivenTransformProperties.ScaleY));
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(1338f, 1807f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x060098A0 RID: 39072 RVA: 0x003739A7 File Offset: 0x00371BA7
		protected virtual void AAPMAEFHKEO()
		{
			base.OnEnable();
			this.JFLDEGAPMLL();
		}

		// Token: 0x060098A1 RID: 39073 RVA: 0x003739B5 File Offset: 0x00371BB5
		public virtual void DAJLEAPIOLB()
		{
			this.JFLDEGAPMLL();
		}

		// Token: 0x060098A2 RID: 39074 RVA: 0x003739B5 File Offset: 0x00371BB5
		public virtual void EAMLNHLLPEJ()
		{
			this.JFLDEGAPMLL();
		}

		// Token: 0x060098A3 RID: 39075 RVA: 0x003739BD File Offset: 0x00371BBD
		public virtual void JFPLBCIAPCA()
		{
			this.BPILKIEHCLD();
		}

		// Token: 0x060098A4 RID: 39076 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void NGEFGPMINCH()
		{
		}

		// Token: 0x060098A5 RID: 39077 RVA: 0x003739C5 File Offset: 0x00371BC5
		public virtual void HHJENJJDJCC()
		{
			this.HBKKENFLGKG();
		}

		// Token: 0x060098A6 RID: 39078 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void GOCLHIIHHOO()
		{
		}

		// Token: 0x060098A7 RID: 39079 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void MGKKFPAEIND()
		{
		}

		// Token: 0x060098A8 RID: 39080 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void PABEPBDMCHC()
		{
		}

		// Token: 0x060098A9 RID: 39081 RVA: 0x003739CD File Offset: 0x00371BCD
		public override void CalculateLayoutInputVertical()
		{
			this.MLDGFKFEBOO();
		}

		// Token: 0x060098AA RID: 39082 RVA: 0x003739D5 File Offset: 0x00371BD5
		public virtual void FCONKEMJPPL()
		{
			this.AIFFKPFNIOL();
		}

		// Token: 0x060098AB RID: 39083 RVA: 0x003739DD File Offset: 0x00371BDD
		public virtual void JGGGGLGPFPF()
		{
			this.DABBPDDGBEG();
		}

		// Token: 0x060098AC RID: 39084 RVA: 0x003739E8 File Offset: 0x00371BE8
		private void HOJDDOBIKFJ()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.LowerCenter) * 1329f, (float)(base.childAlignment / TextAnchor.LowerLeft) * 550f);
			Vector3 a = new Vector3(base.GetStartOffset(1, base.GetTotalPreferredSize(1)), base.GetStartOffset(1, base.GetTotalPreferredSize(0)), 1712f);
			float num = 734f;
			float num2 = 811f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 1; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, ~DrivenTransformProperties.AnchoredPositionZ);
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(1935f, 1970f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x060098AD RID: 39085 RVA: 0x00373B40 File Offset: 0x00371D40
		private void BPILKIEHCLD()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.MiddleCenter) * 845f, (float)(base.childAlignment / TextAnchor.MiddleCenter) * 1104f);
			Vector3 a = new Vector3(base.GetStartOffset(0, base.GetTotalPreferredSize(1)), base.GetStartOffset(1, base.GetTotalPreferredSize(1)), 344f);
			float num = 337f;
			float num2 = 0f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 0; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.Rotation);
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(1719f, 1615f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x060098AE RID: 39086 RVA: 0x003739CD File Offset: 0x00371BCD
		public override void CalculateLayoutInputHorizontal()
		{
			this.MLDGFKFEBOO();
		}

		// Token: 0x060098AF RID: 39087 RVA: 0x00373C97 File Offset: 0x00371E97
		public virtual void GACPNDEDIGD()
		{
			this.JACAGAGDCLM();
		}

		// Token: 0x060098B0 RID: 39088 RVA: 0x00373C9F File Offset: 0x00371E9F
		public virtual void ENEDMEMEIEL()
		{
			this.NFKMICKLNPI();
		}

		// Token: 0x060098B1 RID: 39089 RVA: 0x00373CA8 File Offset: 0x00371EA8
		private void LGJOKGFHCOJ()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.UpperLeft) * 522f, (float)(base.childAlignment / TextAnchor.UpperCenter) * 832f);
			Vector3 a = new Vector3(base.GetStartOffset(0, base.GetTotalPreferredSize(0)), base.GetStartOffset(1, base.GetTotalPreferredSize(0)), 1025f);
			float num = 1417f;
			float num2 = 1322f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 1; i < base.transform.childCount; i++)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, (DrivenTransformProperties)(-144));
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(1101f, 824f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x060098B2 RID: 39090 RVA: 0x003739CD File Offset: 0x00371BCD
		public virtual void BKMLJONFLEC()
		{
			this.MLDGFKFEBOO();
		}

		// Token: 0x060098B3 RID: 39091 RVA: 0x00373DFF File Offset: 0x00371FFF
		protected virtual void OOBIMFILNED()
		{
			base.OnEnable();
			this.BLCGPFCPJOI();
		}

		// Token: 0x060098B4 RID: 39092 RVA: 0x00373E0D File Offset: 0x0037200D
		public virtual void NLIKBHDGFOJ()
		{
			this.IOMBELKEKHD();
		}

		// Token: 0x060098B5 RID: 39093 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void EMLADGALKPI()
		{
		}

		// Token: 0x060098B6 RID: 39094 RVA: 0x003739DD File Offset: 0x00371BDD
		public virtual void ADNCOKOOLKJ()
		{
			this.DABBPDDGBEG();
		}

		// Token: 0x060098B7 RID: 39095 RVA: 0x00373E15 File Offset: 0x00372015
		public virtual void OOPEBMJMJBP()
		{
			this.HNAJOEGOONG();
		}

		// Token: 0x060098B8 RID: 39096 RVA: 0x00373E1D File Offset: 0x0037201D
		public virtual void GADDGCEHIFJ()
		{
			this.EPNNMEDEJCL();
		}

		// Token: 0x060098B9 RID: 39097 RVA: 0x00373E25 File Offset: 0x00372025
		protected virtual void NEBGKMODOPD()
		{
			base.OnEnable();
			this.LGJOKGFHCOJ();
		}

		// Token: 0x060098BA RID: 39098 RVA: 0x00373E33 File Offset: 0x00372033
		protected virtual void EMAMCDFBGOA()
		{
			base.OnEnable();
			this.JCMOIGGHCDJ();
		}

		// Token: 0x060098BB RID: 39099 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void JIPIHPMMLBC()
		{
		}

		// Token: 0x060098BC RID: 39100 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void GMOPMDOOLNL()
		{
		}

		// Token: 0x060098BD RID: 39101 RVA: 0x00373E33 File Offset: 0x00372033
		protected virtual void EAOKCECGKAK()
		{
			base.OnEnable();
			this.JCMOIGGHCDJ();
		}

		// Token: 0x060098BE RID: 39102 RVA: 0x00373E41 File Offset: 0x00372041
		public virtual void KGKELGDGKPF()
		{
			this.BGNCMMJFKNG();
		}

		// Token: 0x060098BF RID: 39103 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void NPFLMHDOOOH()
		{
		}

		// Token: 0x060098C0 RID: 39104 RVA: 0x003739B5 File Offset: 0x00371BB5
		public virtual void OFCMEDGLBPC()
		{
			this.JFLDEGAPMLL();
		}

		// Token: 0x060098C1 RID: 39105 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void NBKFHJFOJML()
		{
		}

		// Token: 0x060098C2 RID: 39106 RVA: 0x0002523B File Offset: 0x0002343B
		public override void SetLayoutVertical()
		{
		}

		// Token: 0x060098C3 RID: 39107 RVA: 0x00373E4C File Offset: 0x0037204C
		private void HBKKENFLGKG()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.LowerRight) * 1777f, (float)(base.childAlignment / TextAnchor.LowerRight) * 1869f);
			Vector3 a = new Vector3(base.GetStartOffset(1, base.GetTotalPreferredSize(1)), base.GetStartOffset(0, base.GetTotalPreferredSize(1)), 921f);
			float num = 49f;
			float num2 = 424f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 1; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.ScaleX | DrivenTransformProperties.ScaleZ);
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(1424f, 734f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x060098C4 RID: 39108 RVA: 0x00373FA4 File Offset: 0x003721A4
		private void JACAGAGDCLM()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.MiddleRight) * 79f, (float)(base.childAlignment / TextAnchor.MiddleCenter) * 639f);
			Vector3 a = new Vector3(base.GetStartOffset(1, base.GetTotalPreferredSize(0)), base.GetStartOffset(1, base.GetTotalPreferredSize(1)), 593f);
			float num = 634f;
			float num2 = 471f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 0; i < base.transform.childCount; i++)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, (DrivenTransformProperties)(-136));
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(1896f, 784f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x060098C5 RID: 39109 RVA: 0x003740FC File Offset: 0x003722FC
		private void MLDGFKFEBOO()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.MiddleLeft) * 0.5f, (float)(base.childAlignment / TextAnchor.MiddleLeft) * 0.5f);
			Vector3 a = new Vector3(base.GetStartOffset(0, base.GetTotalPreferredSize(0)), base.GetStartOffset(1, base.GetTotalPreferredSize(1)), 0f);
			float num = 0f;
			float num2 = 1f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 0; i < base.transform.childCount; i++)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.AnchorMinX | DrivenTransformProperties.AnchorMinY | DrivenTransformProperties.AnchorMaxX | DrivenTransformProperties.AnchorMaxY | DrivenTransformProperties.PivotX | DrivenTransformProperties.PivotY);
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(0.5f, 0.5f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x060098C6 RID: 39110 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void FFPOJCKCPOL()
		{
		}

		// Token: 0x060098C7 RID: 39111 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void CDEJNODMBLD()
		{
		}

		// Token: 0x060098C8 RID: 39112 RVA: 0x00374253 File Offset: 0x00372453
		protected virtual void MHGPANIBBCM()
		{
			base.OnEnable();
			this.HNAJOEGOONG();
		}

		// Token: 0x060098C9 RID: 39113 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void IPPFPCGJAIC()
		{
		}

		// Token: 0x060098CA RID: 39114 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void JMDPMLNEJOP()
		{
		}

		// Token: 0x060098CB RID: 39115 RVA: 0x00374264 File Offset: 0x00372464
		private void JFLDEGAPMLL()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.MiddleRight) * 593f, (float)(base.childAlignment / TextAnchor.UpperCenter) * 25f);
			Vector3 a = new Vector3(base.GetStartOffset(0, base.GetTotalPreferredSize(0)), base.GetStartOffset(1, base.GetTotalPreferredSize(0)), 1123f);
			float num = 1575f;
			float num2 = 1747f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 1; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, (DrivenTransformProperties)(-48));
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(1826f, 1314f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x060098CC RID: 39116 RVA: 0x003739A7 File Offset: 0x00371BA7
		protected virtual void IFKNIHJCAFB()
		{
			base.OnEnable();
			this.JFLDEGAPMLL();
		}

		// Token: 0x060098CD RID: 39117 RVA: 0x003743BC File Offset: 0x003725BC
		private void DIBNFLDDAAM()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.MiddleLeft) * 564f, (float)(base.childAlignment / TextAnchor.MiddleLeft) * 1658f);
			Vector3 a = new Vector3(base.GetStartOffset(0, base.GetTotalPreferredSize(0)), base.GetStartOffset(0, base.GetTotalPreferredSize(1)), 571f);
			float num = 1679f;
			float num2 = 994f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 0; i < base.transform.childCount; i++)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, ~(DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.AnchoredPositionZ | DrivenTransformProperties.Rotation | DrivenTransformProperties.ScaleX | DrivenTransformProperties.ScaleY));
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(1572f, 1567f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x060098CE RID: 39118 RVA: 0x00374513 File Offset: 0x00372713
		protected override void OnEnable()
		{
			base.OnEnable();
			this.MLDGFKFEBOO();
		}

		// Token: 0x060098CF RID: 39119 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void OBDLMKOGLED()
		{
		}

		// Token: 0x060098D0 RID: 39120 RVA: 0x00374521 File Offset: 0x00372721
		public virtual void FMEMBFMMOBC()
		{
			this.EGGGPIEMHEE();
		}

		// Token: 0x060098D1 RID: 39121 RVA: 0x0037452C File Offset: 0x0037272C
		private void IOMBELKEKHD()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.UpperRight) * 1122f, (float)(base.childAlignment / TextAnchor.MiddleCenter) * 1178f);
			Vector3 a = new Vector3(base.GetStartOffset(1, base.GetTotalPreferredSize(1)), base.GetStartOffset(1, base.GetTotalPreferredSize(1)), 1155f);
			float num = 1457f;
			float num2 = 1800f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 1; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, (DrivenTransformProperties)21);
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(1141f, 1561f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x060098D2 RID: 39122 RVA: 0x00374684 File Offset: 0x00372884
		private void AIFFKPFNIOL()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.MiddleLeft) * 1847f, (float)(base.childAlignment / TextAnchor.LowerLeft) * 1291f);
			Vector3 a = new Vector3(base.GetStartOffset(1, base.GetTotalPreferredSize(0)), base.GetStartOffset(0, base.GetTotalPreferredSize(1)), 1427f);
			float num = 890f;
			float num2 = 1784f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 0; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.AnchoredPositionZ | DrivenTransformProperties.Rotation | DrivenTransformProperties.ScaleY);
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(197f, 25f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x060098D3 RID: 39123 RVA: 0x00373C9F File Offset: 0x00371E9F
		public virtual void CDIKPBMIFPN()
		{
			this.NFKMICKLNPI();
		}

		// Token: 0x060098D4 RID: 39124 RVA: 0x003747DB File Offset: 0x003729DB
		public virtual void LFBBBEHPIFL()
		{
			this.LIIPDEBPGCH();
		}

		// Token: 0x060098D5 RID: 39125 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void MPKONAHFIFI()
		{
		}

		// Token: 0x060098D6 RID: 39126 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void KDNPNHENFMH()
		{
		}

		// Token: 0x060098D7 RID: 39127 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void JBMGMLHKIPK()
		{
		}

		// Token: 0x060098D8 RID: 39128 RVA: 0x00373E15 File Offset: 0x00372015
		public virtual void NDAIBLFPFHD()
		{
			this.HNAJOEGOONG();
		}

		// Token: 0x060098D9 RID: 39129 RVA: 0x003747E4 File Offset: 0x003729E4
		private void BGNCMMJFKNG()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.UpperCenter) * 1176f, (float)(base.childAlignment / TextAnchor.LowerCenter) * 281f);
			Vector3 a = new Vector3(base.GetStartOffset(1, base.GetTotalPreferredSize(1)), base.GetStartOffset(0, base.GetTotalPreferredSize(0)), 1859f);
			float num = 738f;
			float num2 = 1888f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 0; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, DrivenTransformProperties.ScaleX | DrivenTransformProperties.ScaleY);
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(123f, 142f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x060098DA RID: 39130 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void FHHKNLPONIG()
		{
		}

		// Token: 0x060098DB RID: 39131 RVA: 0x0037493C File Offset: 0x00372B3C
		private void EGGGPIEMHEE()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.LowerLeft) * 1543f, (float)(base.childAlignment / TextAnchor.MiddleCenter) * 376f);
			Vector3 a = new Vector3(base.GetStartOffset(0, base.GetTotalPreferredSize(1)), base.GetStartOffset(0, base.GetTotalPreferredSize(0)), 1626f);
			float num = 799f;
			float num2 = 1636f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 0; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.AnchoredPositionZ | DrivenTransformProperties.Rotation | DrivenTransformProperties.ScaleX | DrivenTransformProperties.ScaleY);
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(527f, 81f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x060098DC RID: 39132 RVA: 0x00374A93 File Offset: 0x00372C93
		protected virtual void FCKIJIKNMCF()
		{
			base.OnEnable();
			this.EGGGPIEMHEE();
		}

		// Token: 0x060098DD RID: 39133 RVA: 0x00374AA1 File Offset: 0x00372CA1
		public virtual void LJDNNFIGBJN()
		{
			this.LCAHOIMKMIF();
		}

		// Token: 0x060098DE RID: 39134 RVA: 0x00374AA9 File Offset: 0x00372CA9
		protected virtual void GENKFCNHBLH()
		{
			base.OnEnable();
			this.LIIPDEBPGCH();
		}

		// Token: 0x060098DF RID: 39135 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void BHEGBCGLCAI()
		{
		}

		// Token: 0x060098E0 RID: 39136 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void DLLKNDBBJKF()
		{
		}

		// Token: 0x060098E1 RID: 39137 RVA: 0x00373E15 File Offset: 0x00372015
		public virtual void GGPJAHPAACH()
		{
			this.HNAJOEGOONG();
		}

		// Token: 0x060098E2 RID: 39138 RVA: 0x003739DD File Offset: 0x00371BDD
		public virtual void FIBEIPKJCIC()
		{
			this.DABBPDDGBEG();
		}

		// Token: 0x060098E3 RID: 39139 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void JILGONFOJII()
		{
		}

		// Token: 0x060098E4 RID: 39140 RVA: 0x00373E15 File Offset: 0x00372015
		public virtual void GCFOCAEIMNP()
		{
			this.HNAJOEGOONG();
		}

		// Token: 0x060098E5 RID: 39141 RVA: 0x00374AB7 File Offset: 0x00372CB7
		protected virtual void JAKKPABOLEB()
		{
			base.OnEnable();
			this.IOMBELKEKHD();
		}

		// Token: 0x060098E6 RID: 39142 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void IDECFIMJDKC()
		{
		}

		// Token: 0x060098E7 RID: 39143 RVA: 0x003739CD File Offset: 0x00371BCD
		public virtual void HLMEFHIJJLL()
		{
			this.MLDGFKFEBOO();
		}

		// Token: 0x060098E8 RID: 39144 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void DLJHPLMIAAH()
		{
		}

		// Token: 0x060098E9 RID: 39145 RVA: 0x00374521 File Offset: 0x00372721
		public virtual void AFJGPOHGHKK()
		{
			this.EGGGPIEMHEE();
		}

		// Token: 0x060098EA RID: 39146 RVA: 0x00374AC5 File Offset: 0x00372CC5
		protected virtual void BLNLHBNBKOH()
		{
			base.OnEnable();
			this.DIBNFLDDAAM();
		}

		// Token: 0x060098EB RID: 39147 RVA: 0x00374AD3 File Offset: 0x00372CD3
		public virtual void AFDGHDOPFCB()
		{
			this.HBLIEGJCLAI();
		}

		// Token: 0x060098EC RID: 39148 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void CNBMOFAHOPP()
		{
		}

		// Token: 0x060098ED RID: 39149 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void NJFAFPCPCPC()
		{
		}

		// Token: 0x060098EE RID: 39150 RVA: 0x00374ADB File Offset: 0x00372CDB
		public virtual void KHJGLNAKPEH()
		{
			this.BDFKOOGMPOM();
		}

		// Token: 0x060098EF RID: 39151 RVA: 0x00374AE4 File Offset: 0x00372CE4
		private void HNAJOEGOONG()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.LowerCenter) * 1468f, (float)(base.childAlignment / TextAnchor.MiddleLeft) * 1937f);
			Vector3 a = new Vector3(base.GetStartOffset(0, base.GetTotalPreferredSize(1)), base.GetStartOffset(1, base.GetTotalPreferredSize(1)), 1849f);
			float num = 612f;
			float num2 = 671f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 1; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, (DrivenTransformProperties)191);
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(743f, 371f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x060098F0 RID: 39152 RVA: 0x00374C3B File Offset: 0x00372E3B
		protected virtual void OCHMKJKBAPI()
		{
			base.OnEnable();
			this.JACAGAGDCLM();
		}

		// Token: 0x060098F1 RID: 39153 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void NIBLOMOKDBG()
		{
		}

		// Token: 0x060098F3 RID: 39155 RVA: 0x00374C5C File Offset: 0x00372E5C
		public virtual void KBCAPBHCFMF()
		{
			this.DLKFEDIAPFM();
		}

		// Token: 0x060098F4 RID: 39156 RVA: 0x00374521 File Offset: 0x00372721
		public virtual void ALFLHAPDPLE()
		{
			this.EGGGPIEMHEE();
		}

		// Token: 0x060098F5 RID: 39157 RVA: 0x00374C64 File Offset: 0x00372E64
		private void DLKFEDIAPFM()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.LowerRight) * 1259f, (float)(base.childAlignment / TextAnchor.LowerRight) * 112f);
			Vector3 a = new Vector3(base.GetStartOffset(1, base.GetTotalPreferredSize(1)), base.GetStartOffset(1, base.GetTotalPreferredSize(1)), 535f);
			float num = 605f;
			float num2 = 619f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 0; i < base.transform.childCount; i++)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, ~(DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.Rotation | DrivenTransformProperties.ScaleX | DrivenTransformProperties.ScaleY));
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(1050f, 779f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x060098F6 RID: 39158 RVA: 0x00374DBB File Offset: 0x00372FBB
		protected virtual void HGALNAGDJIM()
		{
			base.OnEnable();
			this.EPNNMEDEJCL();
		}

		// Token: 0x060098F7 RID: 39159 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void JFPPOLLPFCF()
		{
		}

		// Token: 0x060098F8 RID: 39160 RVA: 0x00374DCC File Offset: 0x00372FCC
		private void BLCGPFCPJOI()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.MiddleRight) * 168f, (float)(base.childAlignment / TextAnchor.MiddleCenter) * 1003f);
			Vector3 a = new Vector3(base.GetStartOffset(1, base.GetTotalPreferredSize(1)), base.GetStartOffset(0, base.GetTotalPreferredSize(1)), 1550f);
			float num = 1232f;
			float num2 = 857f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 0; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, (DrivenTransformProperties)(-76));
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(47f, 506f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x060098F9 RID: 39161 RVA: 0x00374C3B File Offset: 0x00372E3B
		protected virtual void IJCBBIJOCAH()
		{
			base.OnEnable();
			this.JACAGAGDCLM();
		}

		// Token: 0x060098FA RID: 39162 RVA: 0x00374F23 File Offset: 0x00373123
		public virtual void KHIBNCCHBJJ()
		{
			this.LKMIJCABLJB();
		}

		// Token: 0x060098FB RID: 39163 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void GINDDFJFEOB()
		{
		}

		// Token: 0x060098FC RID: 39164 RVA: 0x00374F2B File Offset: 0x0037312B
		public virtual void HEAKADLNCPG()
		{
			this.BCJNHIPHLAP();
		}

		// Token: 0x060098FD RID: 39165 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void ILKDLPGBCJD()
		{
		}

		// Token: 0x060098FE RID: 39166 RVA: 0x00374F34 File Offset: 0x00373134
		private void EPNNMEDEJCL()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.MiddleCenter) * 1498f, (float)(base.childAlignment / TextAnchor.UpperRight) * 245f);
			Vector3 a = new Vector3(base.GetStartOffset(1, base.GetTotalPreferredSize(1)), base.GetStartOffset(0, base.GetTotalPreferredSize(1)), 838f);
			float num = 1352f;
			float num2 = 1815f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 0; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, ~(DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.ScaleX | DrivenTransformProperties.ScaleZ));
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(705f, 35f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x060098FF RID: 39167 RVA: 0x0037508B File Offset: 0x0037328B
		public virtual void ILHAILHKAAE()
		{
			this.PGFJELMJEBM();
		}

		// Token: 0x06009900 RID: 39168 RVA: 0x00375094 File Offset: 0x00373294
		private void LKMIJCABLJB()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.LowerLeft) * 1541f, (float)(base.childAlignment / TextAnchor.UpperRight) * 757f);
			Vector3 a = new Vector3(base.GetStartOffset(1, base.GetTotalPreferredSize(1)), base.GetStartOffset(1, base.GetTotalPreferredSize(0)), 1603f);
			float num = 362f;
			float num2 = 494f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 1; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, (DrivenTransformProperties)(-32));
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(217f, 1274f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x06009901 RID: 39169 RVA: 0x003751EB File Offset: 0x003733EB
		protected virtual void LGELACBDPEH()
		{
			base.OnEnable();
			this.BPILKIEHCLD();
		}

		// Token: 0x06009902 RID: 39170 RVA: 0x003739D5 File Offset: 0x00371BD5
		public virtual void EIDNPIDIDIN()
		{
			this.AIFFKPFNIOL();
		}

		// Token: 0x06009903 RID: 39171 RVA: 0x003751F9 File Offset: 0x003733F9
		protected virtual void LEFFPPCFNKD()
		{
			base.OnEnable();
			this.MCPPHIGALEH();
		}

		// Token: 0x06009904 RID: 39172 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void GFKMNPHNJOP()
		{
		}

		// Token: 0x06009905 RID: 39173 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void KDPEKEIIEAA()
		{
		}

		// Token: 0x06009906 RID: 39174 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void LGOMFCJMILI()
		{
		}

		// Token: 0x06009907 RID: 39175 RVA: 0x00375207 File Offset: 0x00373407
		public virtual void PPNIJPMPLGG()
		{
			this.HAHOJEPCKBA();
		}

		// Token: 0x06009908 RID: 39176 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void NENGJAHKAGH()
		{
		}

		// Token: 0x06009909 RID: 39177 RVA: 0x0002523B File Offset: 0x0002343B
		public override void SetLayoutHorizontal()
		{
		}

		// Token: 0x0600990A RID: 39178 RVA: 0x00375210 File Offset: 0x00373410
		private void BCJNHIPHLAP()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.MiddleLeft) * 1305f, (float)(base.childAlignment / TextAnchor.MiddleCenter) * 689f);
			Vector3 a = new Vector3(base.GetStartOffset(1, base.GetTotalPreferredSize(1)), base.GetStartOffset(0, base.GetTotalPreferredSize(1)), 31f);
			float num = 595f;
			float num2 = 1748f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 0; i < base.transform.childCount; i++)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, ~(DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.Rotation | DrivenTransformProperties.ScaleX | DrivenTransformProperties.ScaleY));
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(750f, 1987f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x0600990B RID: 39179 RVA: 0x00375367 File Offset: 0x00373567
		public virtual void POEJOHIONEG()
		{
			this.LGJOKGFHCOJ();
		}

		// Token: 0x0600990C RID: 39180 RVA: 0x00375370 File Offset: 0x00373570
		private void LIIPDEBPGCH()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.LowerCenter) * 328f, (float)(base.childAlignment / TextAnchor.LowerRight) * 147f);
			Vector3 a = new Vector3(base.GetStartOffset(1, base.GetTotalPreferredSize(1)), base.GetStartOffset(1, base.GetTotalPreferredSize(0)), 351f);
			float num = 577f;
			float num2 = 890f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 0; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, (DrivenTransformProperties)103);
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(1027f, 1593f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x0600990D RID: 39181 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void MOLPMIDLOKN()
		{
		}

		// Token: 0x0600990E RID: 39182 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void MHNPIEIPJJM()
		{
		}

		// Token: 0x0600990F RID: 39183 RVA: 0x003754C8 File Offset: 0x003736C8
		private void BDFKOOGMPOM()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.MiddleRight) * 525f, (float)(base.childAlignment / TextAnchor.LowerLeft) * 477f);
			Vector3 a = new Vector3(base.GetStartOffset(1, base.GetTotalPreferredSize(1)), base.GetStartOffset(1, base.GetTotalPreferredSize(0)), 611f);
			float num = 1883f;
			float num2 = 1068f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 0; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, ~(DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.Rotation | DrivenTransformProperties.ScaleY));
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(292f, 249f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x06009910 RID: 39184 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void BJAEFHLAGHO()
		{
		}

		// Token: 0x06009911 RID: 39185 RVA: 0x0037561F File Offset: 0x0037381F
		public virtual void HHOLPNOIFIM()
		{
			this.HOJDDOBIKFJ();
		}

		// Token: 0x06009912 RID: 39186 RVA: 0x003739DD File Offset: 0x00371BDD
		public virtual void AGPAFEHGPGP()
		{
			this.DABBPDDGBEG();
		}

		// Token: 0x06009913 RID: 39187 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void MBHOJGBOPBD()
		{
		}

		// Token: 0x06009914 RID: 39188 RVA: 0x00375627 File Offset: 0x00373827
		public virtual void EHCNHEKCINE()
		{
			this.MIHONJJBLBO();
		}

		// Token: 0x06009915 RID: 39189 RVA: 0x00373C97 File Offset: 0x00371E97
		public virtual void HPEGAGDLBMK()
		{
			this.JACAGAGDCLM();
		}

		// Token: 0x06009916 RID: 39190 RVA: 0x00373E15 File Offset: 0x00372015
		public virtual void ALDCGGFBJAM()
		{
			this.HNAJOEGOONG();
		}

		// Token: 0x06009917 RID: 39191 RVA: 0x003747DB File Offset: 0x003729DB
		public virtual void BACPPHICKEA()
		{
			this.LIIPDEBPGCH();
		}

		// Token: 0x06009918 RID: 39192 RVA: 0x0037562F File Offset: 0x0037382F
		protected virtual void CNHEENCFCMF()
		{
			base.OnEnable();
			this.BCJNHIPHLAP();
		}

		// Token: 0x06009919 RID: 39193 RVA: 0x0037563D File Offset: 0x0037383D
		public virtual void EOBFNJFBLCN()
		{
			this.BLCGPFCPJOI();
		}

		// Token: 0x0600991A RID: 39194 RVA: 0x0037561F File Offset: 0x0037381F
		public virtual void IOPCBHBFJLE()
		{
			this.HOJDDOBIKFJ();
		}

		// Token: 0x0600991B RID: 39195 RVA: 0x003739CD File Offset: 0x00371BCD
		public virtual void OOEHGJBIFLA()
		{
			this.MLDGFKFEBOO();
		}

		// Token: 0x0600991C RID: 39196 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void IAPEOHOEIFP()
		{
		}

		// Token: 0x0600991D RID: 39197 RVA: 0x00375645 File Offset: 0x00373845
		protected virtual void IDIEBLNAEIF()
		{
			base.OnEnable();
			this.HBKKENFLGKG();
		}

		// Token: 0x0600991E RID: 39198 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void HDNGDDFAKLA()
		{
		}

		// Token: 0x0600991F RID: 39199 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void LALDFPPFOGJ()
		{
		}

		// Token: 0x06009920 RID: 39200 RVA: 0x003739DD File Offset: 0x00371BDD
		public virtual void PPJEDHAONLP()
		{
			this.DABBPDDGBEG();
		}

		// Token: 0x06009921 RID: 39201 RVA: 0x00375654 File Offset: 0x00373854
		private void MIHONJJBLBO()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.LowerRight) * 214f, (float)(base.childAlignment / TextAnchor.UpperCenter) * 204f);
			Vector3 a = new Vector3(base.GetStartOffset(0, base.GetTotalPreferredSize(1)), base.GetStartOffset(1, base.GetTotalPreferredSize(0)), 1622f);
			float num = 1013f;
			float num2 = 362f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 0; i < base.transform.childCount; i++)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, (DrivenTransformProperties)(-120));
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(1371f, 408f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x06009922 RID: 39202 RVA: 0x00375627 File Offset: 0x00373827
		public virtual void HMNNJDHPAML()
		{
			this.MIHONJJBLBO();
		}

		// Token: 0x06009923 RID: 39203 RVA: 0x003757AC File Offset: 0x003739AC
		private void NFKMICKLNPI()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.MiddleCenter) * 1209f, (float)(base.childAlignment / TextAnchor.LowerCenter) * 1173f);
			Vector3 a = new Vector3(base.GetStartOffset(1, base.GetTotalPreferredSize(0)), base.GetStartOffset(1, base.GetTotalPreferredSize(1)), 73f);
			float num = 567f;
			float num2 = 1685f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 0; i < base.transform.childCount; i++)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, ~(DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.Rotation | DrivenTransformProperties.ScaleX | DrivenTransformProperties.ScaleY));
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(883f, 939f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x06009924 RID: 39204 RVA: 0x00375904 File Offset: 0x00373B04
		private void MCPPHIGALEH()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.LowerRight) * 1728f, (float)(base.childAlignment / TextAnchor.UpperRight) * 670f);
			Vector3 a = new Vector3(base.GetStartOffset(0, base.GetTotalPreferredSize(0)), base.GetStartOffset(1, base.GetTotalPreferredSize(0)), 1284f);
			float num = 343f;
			float num2 = 1401f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 0; i < base.transform.childCount; i++)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, (DrivenTransformProperties)(-6));
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(1221f, 1320f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x06009925 RID: 39205 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void DPLHPCBCJGA()
		{
		}

		// Token: 0x06009926 RID: 39206 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void BMBHMINJCMH()
		{
		}

		// Token: 0x06009927 RID: 39207 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void HCDEANGCMOB()
		{
		}

		// Token: 0x06009928 RID: 39208 RVA: 0x00375A5B File Offset: 0x00373C5B
		protected virtual void BDBKIEIIFPB()
		{
			base.OnEnable();
			this.AIFFKPFNIOL();
		}

		// Token: 0x06009929 RID: 39209 RVA: 0x00375A69 File Offset: 0x00373C69
		protected virtual void MFFJMNOHPBE()
		{
			base.OnEnable();
			this.NFKMICKLNPI();
		}

		// Token: 0x0600992A RID: 39210 RVA: 0x00375A78 File Offset: 0x00373C78
		private void PGFJELMJEBM()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.MiddleLeft) * 29f, (float)(base.childAlignment / TextAnchor.MiddleCenter) * 756f);
			Vector3 a = new Vector3(base.GetStartOffset(1, base.GetTotalPreferredSize(0)), base.GetStartOffset(0, base.GetTotalPreferredSize(0)), 1875f);
			float num = 137f;
			float num2 = 99f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 0; i < base.transform.childCount; i++)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, (DrivenTransformProperties)127);
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(846f, 1774f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x0600992B RID: 39211 RVA: 0x00374C5C File Offset: 0x00372E5C
		public virtual void FAJNPDLHEOB()
		{
			this.DLKFEDIAPFM();
		}

		// Token: 0x0600992C RID: 39212 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void CMICHABAMMH()
		{
		}

		// Token: 0x0600992D RID: 39213 RVA: 0x003739BD File Offset: 0x00371BBD
		public virtual void PFPKOPNFOFO()
		{
			this.BPILKIEHCLD();
		}

		// Token: 0x0600992E RID: 39214 RVA: 0x00375207 File Offset: 0x00373407
		public virtual void OBMECLAKNOB()
		{
			this.HAHOJEPCKBA();
		}

		// Token: 0x0600992F RID: 39215 RVA: 0x00375BD0 File Offset: 0x00373DD0
		private void HBLIEGJCLAI()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			Vector2 pivot = new Vector2((float)(base.childAlignment % TextAnchor.LowerCenter) * 1434f, (float)(base.childAlignment / TextAnchor.LowerRight) * 1219f);
			Vector3 a = new Vector3(base.GetStartOffset(1, base.GetTotalPreferredSize(0)), base.GetStartOffset(0, base.GetTotalPreferredSize(0)), 89f);
			float num = 628f;
			float num2 = 1967f / (float)base.transform.childCount;
			Vector3 b = this.itemAxis.normalized * this.itemSize;
			for (int i = 0; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.AnchoredPositionZ | DrivenTransformProperties.ScaleX);
					Vector3 a2 = a + b;
					a = (rectTransform.localPosition = a2 + (num - this.centerpoint) * this.CurveOffset);
					rectTransform.pivot = pivot;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(83f, 17f);
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num += num2;
				}
			}
		}

		// Token: 0x06009930 RID: 39216 RVA: 0x003739DD File Offset: 0x00371BDD
		public virtual void JFCOKJDHLBJ()
		{
			this.DABBPDDGBEG();
		}

		// Token: 0x06009931 RID: 39217 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void LBGIIIOAPLJ()
		{
		}

		// Token: 0x04001143 RID: 4419
		public Vector3 CurveOffset;

		// Token: 0x04001144 RID: 4420
		[Tooltip("axis along which to place the items, Normalized before use")]
		public Vector3 itemAxis;

		// Token: 0x04001145 RID: 4421
		[Tooltip("size of each item along the Normalized axis")]
		public float itemSize;

		// Token: 0x04001146 RID: 4422
		public float centerpoint = 0.5f;
	}
}
