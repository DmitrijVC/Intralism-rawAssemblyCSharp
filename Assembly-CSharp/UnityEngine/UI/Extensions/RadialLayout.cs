using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200027D RID: 637
	[AddComponentMenu("Layout/Extensions/Radial Layout")]
	public class RadialLayout : LayoutGroup
	{
		// Token: 0x06009A0D RID: 39437 RVA: 0x0037CDA1 File Offset: 0x0037AFA1
		public virtual void NMHDIPCLFAO()
		{
			this.GIIPDKOHNFB();
		}

		// Token: 0x06009A0E RID: 39438 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void CBJNGDHIHNH()
		{
		}

		// Token: 0x06009A0F RID: 39439 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void PBFPJMHAHGK()
		{
		}

		// Token: 0x06009A10 RID: 39440 RVA: 0x0037CDA9 File Offset: 0x0037AFA9
		public virtual void HEAKADLNCPG()
		{
			this.NNOLGIOKPHA();
		}

		// Token: 0x06009A11 RID: 39441 RVA: 0x0037CDB1 File Offset: 0x0037AFB1
		public virtual void OOPEBMJMJBP()
		{
			this.LGJOKGFHCOJ();
		}

		// Token: 0x06009A12 RID: 39442 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void NJJFIEIEILK()
		{
		}

		// Token: 0x06009A13 RID: 39443 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void JIPIHPMMLBC()
		{
		}

		// Token: 0x06009A14 RID: 39444 RVA: 0x0037CDB9 File Offset: 0x0037AFB9
		public virtual void LFBBBEHPIFL()
		{
			this.JDANPFKBFPF();
		}

		// Token: 0x06009A15 RID: 39445 RVA: 0x0037CDC1 File Offset: 0x0037AFC1
		protected virtual void FCKMAOMOKNB()
		{
			base.OnEnable();
			this.NBFDAMBIHIO();
		}

		// Token: 0x06009A16 RID: 39446 RVA: 0x0037CDCF File Offset: 0x0037AFCF
		public virtual void OGNCGOBGAII()
		{
			this.MPMEBCNIING();
		}

		// Token: 0x06009A17 RID: 39447 RVA: 0x0037CDD8 File Offset: 0x0037AFD8
		private void BGGMEIBHEDO()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			float num = (this.MaxAngle - this.MinAngle) / (float)base.transform.childCount;
			float num2 = this.StartAngle;
			for (int i = 1; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.ScaleY | DrivenTransformProperties.ScaleZ);
					Vector3 a = new Vector3(Mathf.Cos(num2 * 1276f), Mathf.Sin(num2 * 714f), 955f);
					rectTransform.localPosition = a * this.fDistance;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(623f, 1172f);
					rectTransform.pivot = vector;
					vector = vector;
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num2 += num;
				}
			}
		}

		// Token: 0x06009A18 RID: 39448 RVA: 0x0037CED7 File Offset: 0x0037B0D7
		public virtual void BPMFPCLHHGH()
		{
			this.ANLDDIPHLOJ();
		}

		// Token: 0x06009A19 RID: 39449 RVA: 0x0037CEE0 File Offset: 0x0037B0E0
		private void MPMEBCNIING()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			float num = (this.MaxAngle - this.MinAngle) / (float)base.transform.childCount;
			float num2 = this.StartAngle;
			for (int i = 0; i < base.transform.childCount; i++)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, (DrivenTransformProperties)59);
					Vector3 a = new Vector3(Mathf.Cos(num2 * 153f), Mathf.Sin(num2 * 1797f), 1348f);
					rectTransform.localPosition = a * this.fDistance;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(772f, 1537f);
					rectTransform.pivot = vector;
					vector = vector;
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num2 += num;
				}
			}
		}

		// Token: 0x06009A1A RID: 39450 RVA: 0x0037CFDF File Offset: 0x0037B1DF
		public virtual void MONMKGEEBNN()
		{
			this.JFNKPGGPPJP();
		}

		// Token: 0x06009A1B RID: 39451 RVA: 0x0037CFE8 File Offset: 0x0037B1E8
		private void JEHNEIEPECB()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			float num = (this.MaxAngle - this.MinAngle) / (float)base.transform.childCount;
			float num2 = this.StartAngle;
			for (int i = 0; i < base.transform.childCount; i++)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, (DrivenTransformProperties)(-74));
					Vector3 a = new Vector3(Mathf.Cos(num2 * 851f), Mathf.Sin(num2 * 946f), 974f);
					rectTransform.localPosition = a * this.fDistance;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(1200f, 1094f);
					rectTransform.pivot = vector;
					vector = vector;
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num2 += num;
				}
			}
		}

		// Token: 0x06009A1C RID: 39452 RVA: 0x0037D0E7 File Offset: 0x0037B2E7
		public virtual void HOPAKADFFDC()
		{
			this.BPILKIEHCLD();
		}

		// Token: 0x06009A1D RID: 39453 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void DDJLNAKAFFE()
		{
		}

		// Token: 0x06009A1E RID: 39454 RVA: 0x0037D0EF File Offset: 0x0037B2EF
		public virtual void FMOONCCMILF()
		{
			this.FIDFADHJFLM();
		}

		// Token: 0x06009A1F RID: 39455 RVA: 0x0037D0F8 File Offset: 0x0037B2F8
		private void LGJOKGFHCOJ()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			float num = (this.MaxAngle - this.MinAngle) / (float)base.transform.childCount;
			float num2 = this.StartAngle;
			for (int i = 1; i < base.transform.childCount; i++)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, (DrivenTransformProperties)125);
					Vector3 a = new Vector3(Mathf.Cos(num2 * 3f), Mathf.Sin(num2 * 175f), 673f);
					rectTransform.localPosition = a * this.fDistance;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(608f, 879f);
					rectTransform.pivot = vector;
					vector = vector;
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num2 += num;
				}
			}
		}

		// Token: 0x06009A20 RID: 39456 RVA: 0x0037D1F7 File Offset: 0x0037B3F7
		protected virtual void PPGEGFMNIKO()
		{
			base.OnEnable();
			this.JDANPFKBFPF();
		}

		// Token: 0x06009A21 RID: 39457 RVA: 0x0037D205 File Offset: 0x0037B405
		public virtual void BACPPHICKEA()
		{
			this.GHOAFNJGMGM();
		}

		// Token: 0x06009A22 RID: 39458 RVA: 0x0037CDA9 File Offset: 0x0037AFA9
		public virtual void KGKELGDGKPF()
		{
			this.NNOLGIOKPHA();
		}

		// Token: 0x06009A23 RID: 39459 RVA: 0x0037D210 File Offset: 0x0037B410
		private void ACKNACMIHJK()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			float num = (this.MaxAngle - this.MinAngle) / (float)base.transform.childCount;
			float num2 = this.StartAngle;
			for (int i = 0; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, ~(DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.AnchoredPositionZ | DrivenTransformProperties.ScaleX | DrivenTransformProperties.ScaleY));
					Vector3 a = new Vector3(Mathf.Cos(num2 * 1192f), Mathf.Sin(num2 * 696f), 838f);
					rectTransform.localPosition = a * this.fDistance;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(163f, 95f);
					rectTransform.pivot = vector;
					vector = vector;
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num2 += num;
				}
			}
		}

		// Token: 0x06009A24 RID: 39460 RVA: 0x0037D30F File Offset: 0x0037B50F
		protected virtual void HPGKMAIPDEO()
		{
			base.OnEnable();
			this.DLKFEDIAPFM();
		}

		// Token: 0x06009A25 RID: 39461 RVA: 0x0037D30F File Offset: 0x0037B50F
		protected virtual void IBFHEDHJDLH()
		{
			base.OnEnable();
			this.DLKFEDIAPFM();
		}

		// Token: 0x06009A26 RID: 39462 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void KGFIKMABPKK()
		{
		}

		// Token: 0x06009A27 RID: 39463 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void JKBNDNFCFGD()
		{
		}

		// Token: 0x06009A28 RID: 39464 RVA: 0x0037D320 File Offset: 0x0037B520
		private void JDANPFKBFPF()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			float num = (this.MaxAngle - this.MinAngle) / (float)base.transform.childCount;
			float num2 = this.StartAngle;
			for (int i = 1; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, ~(DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.AnchoredPositionZ | DrivenTransformProperties.Rotation | DrivenTransformProperties.ScaleX | DrivenTransformProperties.ScaleZ));
					Vector3 a = new Vector3(Mathf.Cos(num2 * 305f), Mathf.Sin(num2 * 138f), 769f);
					rectTransform.localPosition = a * this.fDistance;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(63f, 491f);
					rectTransform.pivot = vector;
					vector = vector;
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num2 += num;
				}
			}
		}

		// Token: 0x06009A29 RID: 39465 RVA: 0x0037CFDF File Offset: 0x0037B1DF
		public virtual void MDGHLAEFPMD()
		{
			this.JFNKPGGPPJP();
		}

		// Token: 0x06009A2A RID: 39466 RVA: 0x0037D41F File Offset: 0x0037B61F
		protected virtual void MCKOAMFEDGL()
		{
			base.OnEnable();
			this.BPILKIEHCLD();
		}

		// Token: 0x06009A2B RID: 39467 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void OONFALMOMAM()
		{
		}

		// Token: 0x06009A2C RID: 39468 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void CMICHABAMMH()
		{
		}

		// Token: 0x06009A2D RID: 39469 RVA: 0x0037D430 File Offset: 0x0037B630
		private void MLDGFKFEBOO()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			float num = (this.MaxAngle - this.MinAngle) / (float)base.transform.childCount;
			float num2 = this.StartAngle;
			for (int i = 0; i < base.transform.childCount; i++)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.AnchorMinX | DrivenTransformProperties.AnchorMinY | DrivenTransformProperties.AnchorMaxX | DrivenTransformProperties.AnchorMaxY | DrivenTransformProperties.PivotX | DrivenTransformProperties.PivotY);
					Vector3 a = new Vector3(Mathf.Cos(num2 * 0.0174532924f), Mathf.Sin(num2 * 0.0174532924f), 0f);
					rectTransform.localPosition = a * this.fDistance;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(0.5f, 0.5f);
					rectTransform.pivot = vector;
					vector = vector;
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num2 += num;
				}
			}
		}

		// Token: 0x06009A2E RID: 39470 RVA: 0x0037D52F File Offset: 0x0037B72F
		protected virtual void PLNLNCDPPGG()
		{
			base.OnEnable();
			this.LGJOKGFHCOJ();
		}

		// Token: 0x06009A2F RID: 39471 RVA: 0x0037D53D File Offset: 0x0037B73D
		public virtual void LJFPOHBMOJP()
		{
			this.BLCGPFCPJOI();
		}

		// Token: 0x06009A30 RID: 39472 RVA: 0x0037D545 File Offset: 0x0037B745
		public virtual void BBKCFPHDPJG()
		{
			this.LAICPICCCGO();
		}

		// Token: 0x06009A31 RID: 39473 RVA: 0x0037CDA9 File Offset: 0x0037AFA9
		public virtual void LLCGIJNLKBE()
		{
			this.NNOLGIOKPHA();
		}

		// Token: 0x06009A32 RID: 39474 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void BHPPJILHKNL()
		{
		}

		// Token: 0x06009A33 RID: 39475 RVA: 0x0037D54D File Offset: 0x0037B74D
		protected virtual void JKMLIADBEOB()
		{
			base.OnEnable();
			this.BGGMEIBHEDO();
		}

		// Token: 0x06009A34 RID: 39476 RVA: 0x0037D55C File Offset: 0x0037B75C
		private void LDIPBMPFLDO()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			float num = (this.MaxAngle - this.MinAngle) / (float)base.transform.childCount;
			float num2 = this.StartAngle;
			for (int i = 1; i < base.transform.childCount; i++)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, (DrivenTransformProperties)(-118));
					Vector3 a = new Vector3(Mathf.Cos(num2 * 635f), Mathf.Sin(num2 * 947f), 333f);
					rectTransform.localPosition = a * this.fDistance;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(1562f, 796f);
					rectTransform.pivot = vector;
					vector = vector;
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num2 += num;
				}
			}
		}

		// Token: 0x06009A35 RID: 39477 RVA: 0x0037D65C File Offset: 0x0037B85C
		private void NBFDAMBIHIO()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			float num = (this.MaxAngle - this.MinAngle) / (float)base.transform.childCount;
			float num2 = this.StartAngle;
			for (int i = 0; i < base.transform.childCount; i++)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, (DrivenTransformProperties)65);
					Vector3 a = new Vector3(Mathf.Cos(num2 * 1554f), Mathf.Sin(num2 * 577f), 173f);
					rectTransform.localPosition = a * this.fDistance;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(25f, 1344f);
					rectTransform.pivot = vector;
					vector = vector;
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num2 += num;
				}
			}
		}

		// Token: 0x06009A36 RID: 39478 RVA: 0x0037D75C File Offset: 0x0037B95C
		private void GIIPDKOHNFB()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			float num = (this.MaxAngle - this.MinAngle) / (float)base.transform.childCount;
			float num2 = this.StartAngle;
			for (int i = 1; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, (DrivenTransformProperties)(-10));
					Vector3 a = new Vector3(Mathf.Cos(num2 * 62f), Mathf.Sin(num2 * 332f), 1070f);
					rectTransform.localPosition = a * this.fDistance;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(1790f, 1850f);
					rectTransform.pivot = vector;
					vector = vector;
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num2 += num;
				}
			}
		}

		// Token: 0x06009A37 RID: 39479 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void MMHLNKPHLAL()
		{
		}

		// Token: 0x06009A38 RID: 39480 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void LEPLCNJKAJL()
		{
		}

		// Token: 0x06009A39 RID: 39481 RVA: 0x0037D85C File Offset: 0x0037BA5C
		private void JFNKPGGPPJP()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			float num = (this.MaxAngle - this.MinAngle) / (float)base.transform.childCount;
			float num2 = this.StartAngle;
			for (int i = 1; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, DrivenTransformProperties.AnchoredPositionZ | DrivenTransformProperties.ScaleX | DrivenTransformProperties.ScaleY);
					Vector3 a = new Vector3(Mathf.Cos(num2 * 1796f), Mathf.Sin(num2 * 1291f), 392f);
					rectTransform.localPosition = a * this.fDistance;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(771f, 452f);
					rectTransform.pivot = vector;
					vector = vector;
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num2 += num;
				}
			}
		}

		// Token: 0x06009A3A RID: 39482 RVA: 0x0037D95B File Offset: 0x0037BB5B
		protected override void OnEnable()
		{
			base.OnEnable();
			this.MLDGFKFEBOO();
		}

		// Token: 0x06009A3B RID: 39483 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void PDEGEIPCGDL()
		{
		}

		// Token: 0x06009A3C RID: 39484 RVA: 0x0037D52F File Offset: 0x0037B72F
		protected virtual void IDIEBLNAEIF()
		{
			base.OnEnable();
			this.LGJOKGFHCOJ();
		}

		// Token: 0x06009A3D RID: 39485 RVA: 0x0037CDA9 File Offset: 0x0037AFA9
		public virtual void MJGBPFKDMML()
		{
			this.NNOLGIOKPHA();
		}

		// Token: 0x06009A3E RID: 39486 RVA: 0x0037D96C File Offset: 0x0037BB6C
		private void PBMCOEAPFNH()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			float num = (this.MaxAngle - this.MinAngle) / (float)base.transform.childCount;
			float num2 = this.StartAngle;
			for (int i = 1; i < base.transform.childCount; i++)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, (DrivenTransformProperties)69);
					Vector3 a = new Vector3(Mathf.Cos(num2 * 413f), Mathf.Sin(num2 * 1059f), 957f);
					rectTransform.localPosition = a * this.fDistance;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(1406f, 917f);
					rectTransform.pivot = vector;
					vector = vector;
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num2 += num;
				}
			}
		}

		// Token: 0x06009A40 RID: 39488 RVA: 0x0037DA73 File Offset: 0x0037BC73
		public override void CalculateLayoutInputHorizontal()
		{
			this.MLDGFKFEBOO();
		}

		// Token: 0x06009A41 RID: 39489 RVA: 0x0037DA7B File Offset: 0x0037BC7B
		public virtual void IFMJAEDFFPB()
		{
			this.LDGJMAHHACM();
		}

		// Token: 0x06009A42 RID: 39490 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void DEHGKEKGGLB()
		{
		}

		// Token: 0x06009A43 RID: 39491 RVA: 0x0037D53D File Offset: 0x0037B73D
		public virtual void POFBCELLKIF()
		{
			this.BLCGPFCPJOI();
		}

		// Token: 0x06009A44 RID: 39492 RVA: 0x0037DA83 File Offset: 0x0037BC83
		public virtual void ICFJALKPIHP()
		{
			this.LDIPBMPFLDO();
		}

		// Token: 0x06009A45 RID: 39493 RVA: 0x0037DA73 File Offset: 0x0037BC73
		public override void CalculateLayoutInputVertical()
		{
			this.MLDGFKFEBOO();
		}

		// Token: 0x06009A46 RID: 39494 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void IADAENLDFAC()
		{
		}

		// Token: 0x06009A47 RID: 39495 RVA: 0x0037DA8B File Offset: 0x0037BC8B
		public virtual void DNKBEHKIJCO()
		{
			this.KILNIFEPGPG();
		}

		// Token: 0x06009A48 RID: 39496 RVA: 0x0037DA93 File Offset: 0x0037BC93
		protected virtual void INGOODALACO()
		{
			base.OnEnable();
			this.ACKNACMIHJK();
		}

		// Token: 0x06009A49 RID: 39497 RVA: 0x0002523B File Offset: 0x0002343B
		public override void SetLayoutHorizontal()
		{
		}

		// Token: 0x06009A4A RID: 39498 RVA: 0x0037DAA1 File Offset: 0x0037BCA1
		protected virtual void HIFPDKKBDHJ()
		{
			base.OnEnable();
			this.GHOAFNJGMGM();
		}

		// Token: 0x06009A4B RID: 39499 RVA: 0x0037CDB9 File Offset: 0x0037AFB9
		public virtual void GCFOCAEIMNP()
		{
			this.JDANPFKBFPF();
		}

		// Token: 0x06009A4C RID: 39500 RVA: 0x0037DA83 File Offset: 0x0037BC83
		public virtual void ALDCGGFBJAM()
		{
			this.LDIPBMPFLDO();
		}

		// Token: 0x06009A4D RID: 39501 RVA: 0x0037DAB0 File Offset: 0x0037BCB0
		private void ANLDDIPHLOJ()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			float num = (this.MaxAngle - this.MinAngle) / (float)base.transform.childCount;
			float num2 = this.StartAngle;
			for (int i = 1; i < base.transform.childCount; i++)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, (DrivenTransformProperties)25);
					Vector3 a = new Vector3(Mathf.Cos(num2 * 613f), Mathf.Sin(num2 * 1136f), 952f);
					rectTransform.localPosition = a * this.fDistance;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(1996f, 880f);
					rectTransform.pivot = vector;
					vector = vector;
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num2 += num;
				}
			}
		}

		// Token: 0x06009A4E RID: 39502 RVA: 0x0037DA83 File Offset: 0x0037BC83
		public virtual void LGBLGHCKODK()
		{
			this.LDIPBMPFLDO();
		}

		// Token: 0x06009A4F RID: 39503 RVA: 0x0037DBAF File Offset: 0x0037BDAF
		public virtual void MMDDMAOCBIO()
		{
			this.PBMCOEAPFNH();
		}

		// Token: 0x06009A50 RID: 39504 RVA: 0x0037D41F File Offset: 0x0037B61F
		protected virtual void MBNMADBPDLL()
		{
			base.OnEnable();
			this.BPILKIEHCLD();
		}

		// Token: 0x06009A51 RID: 39505 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void GLOJAIENCLD()
		{
		}

		// Token: 0x06009A52 RID: 39506 RVA: 0x0037DBB8 File Offset: 0x0037BDB8
		private void DLKFEDIAPFM()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			float num = (this.MaxAngle - this.MinAngle) / (float)base.transform.childCount;
			float num2 = this.StartAngle;
			for (int i = 1; i < base.transform.childCount; i++)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.ScaleY);
					Vector3 a = new Vector3(Mathf.Cos(num2 * 868f), Mathf.Sin(num2 * 964f), 1368f);
					rectTransform.localPosition = a * this.fDistance;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(1781f, 1542f);
					rectTransform.pivot = vector;
					vector = vector;
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num2 += num;
				}
			}
		}

		// Token: 0x06009A53 RID: 39507 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void JIKGCFAONCJ()
		{
		}

		// Token: 0x06009A54 RID: 39508 RVA: 0x0037DCB7 File Offset: 0x0037BEB7
		public virtual void PNDBJJPBEKO()
		{
			this.BGGMEIBHEDO();
		}

		// Token: 0x06009A55 RID: 39509 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void FIECBJKKJFC()
		{
		}

		// Token: 0x06009A56 RID: 39510 RVA: 0x0037D545 File Offset: 0x0037B745
		public virtual void PLIHKHMMDGB()
		{
			this.LAICPICCCGO();
		}

		// Token: 0x06009A57 RID: 39511 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void AINMCFNBEFA()
		{
		}

		// Token: 0x06009A58 RID: 39512 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void FFPOJCKCPOL()
		{
		}

		// Token: 0x06009A59 RID: 39513 RVA: 0x0037DCBF File Offset: 0x0037BEBF
		public virtual void GBOMEPKDJOI()
		{
			this.NBFDAMBIHIO();
		}

		// Token: 0x06009A5A RID: 39514 RVA: 0x0037CDA9 File Offset: 0x0037AFA9
		public virtual void FBLNOPPOBHP()
		{
			this.NNOLGIOKPHA();
		}

		// Token: 0x06009A5B RID: 39515 RVA: 0x0037DCC8 File Offset: 0x0037BEC8
		private void GHOAFNJGMGM()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			float num = (this.MaxAngle - this.MinAngle) / (float)base.transform.childCount;
			float num2 = this.StartAngle;
			for (int i = 0; i < base.transform.childCount; i++)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.AnchoredPositionZ | DrivenTransformProperties.ScaleX | DrivenTransformProperties.ScaleY);
					Vector3 a = new Vector3(Mathf.Cos(num2 * 1852f), Mathf.Sin(num2 * 911f), 577f);
					rectTransform.localPosition = a * this.fDistance;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(1967f, 777f);
					rectTransform.pivot = vector;
					vector = vector;
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num2 += num;
				}
			}
		}

		// Token: 0x06009A5C RID: 39516 RVA: 0x0037DDC7 File Offset: 0x0037BFC7
		protected virtual void GLKJFIOCPLF()
		{
			base.OnEnable();
			this.NNOLGIOKPHA();
		}

		// Token: 0x06009A5D RID: 39517 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void NNLEPECIJCP()
		{
		}

		// Token: 0x06009A5E RID: 39518 RVA: 0x0037DDD8 File Offset: 0x0037BFD8
		private void LAICPICCCGO()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			float num = (this.MaxAngle - this.MinAngle) / (float)base.transform.childCount;
			float num2 = this.StartAngle;
			for (int i = 1; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, (DrivenTransformProperties)191);
					Vector3 a = new Vector3(Mathf.Cos(num2 * 1808f), Mathf.Sin(num2 * 1166f), 301f);
					rectTransform.localPosition = a * this.fDistance;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(1854f, 1829f);
					rectTransform.pivot = vector;
					vector = vector;
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num2 += num;
				}
			}
		}

		// Token: 0x06009A5F RID: 39519 RVA: 0x0037DED7 File Offset: 0x0037C0D7
		protected virtual void OAKONCDEPPI()
		{
			base.OnEnable();
			this.LAICPICCCGO();
		}

		// Token: 0x06009A60 RID: 39520 RVA: 0x0037DEE8 File Offset: 0x0037C0E8
		private void LDGJMAHHACM()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			float num = (this.MaxAngle - this.MinAngle) / (float)base.transform.childCount;
			float num2 = this.StartAngle;
			for (int i = 0; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, (DrivenTransformProperties)(-188));
					Vector3 a = new Vector3(Mathf.Cos(num2 * 469f), Mathf.Sin(num2 * 1994f), 706f);
					rectTransform.localPosition = a * this.fDistance;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(958f, 1566f);
					rectTransform.pivot = vector;
					vector = vector;
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num2 += num;
				}
			}
		}

		// Token: 0x06009A61 RID: 39521 RVA: 0x0037CDA9 File Offset: 0x0037AFA9
		public virtual void MFFENEMNPCA()
		{
			this.NNOLGIOKPHA();
		}

		// Token: 0x06009A62 RID: 39522 RVA: 0x0037DFE8 File Offset: 0x0037C1E8
		private void NNOLGIOKPHA()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			float num = (this.MaxAngle - this.MinAngle) / (float)base.transform.childCount;
			float num2 = this.StartAngle;
			for (int i = 1; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, (DrivenTransformProperties)113);
					Vector3 a = new Vector3(Mathf.Cos(num2 * 449f), Mathf.Sin(num2 * 585f), 642f);
					rectTransform.localPosition = a * this.fDistance;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(195f, 792f);
					rectTransform.pivot = vector;
					vector = vector;
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num2 += num;
				}
			}
		}

		// Token: 0x06009A63 RID: 39523 RVA: 0x0037D0EF File Offset: 0x0037B2EF
		public virtual void HIJIIPAPHDM()
		{
			this.FIDFADHJFLM();
		}

		// Token: 0x06009A64 RID: 39524 RVA: 0x0037E0E8 File Offset: 0x0037C2E8
		private void BLCGPFCPJOI()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			float num = (this.MaxAngle - this.MinAngle) / (float)base.transform.childCount;
			float num2 = this.StartAngle;
			for (int i = 1; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, (DrivenTransformProperties)103);
					Vector3 a = new Vector3(Mathf.Cos(num2 * 1084f), Mathf.Sin(num2 * 1175f), 315f);
					rectTransform.localPosition = a * this.fDistance;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(1354f, 880f);
					rectTransform.pivot = vector;
					vector = vector;
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num2 += num;
				}
			}
		}

		// Token: 0x06009A65 RID: 39525 RVA: 0x0037E1E8 File Offset: 0x0037C3E8
		private void FIDFADHJFLM()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			float num = (this.MaxAngle - this.MinAngle) / (float)base.transform.childCount;
			float num2 = this.StartAngle;
			for (int i = 0; i < base.transform.childCount; i++)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, (DrivenTransformProperties)(-138));
					Vector3 a = new Vector3(Mathf.Cos(num2 * 963f), Mathf.Sin(num2 * 1818f), 1670f);
					rectTransform.localPosition = a * this.fDistance;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(75f, 704f);
					rectTransform.pivot = vector;
					vector = vector;
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num2 += num;
				}
			}
		}

		// Token: 0x06009A66 RID: 39526 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void MDBIGPPHGKL()
		{
		}

		// Token: 0x06009A67 RID: 39527 RVA: 0x0037D53D File Offset: 0x0037B73D
		public virtual void FBBKIHOJHLH()
		{
			this.BLCGPFCPJOI();
		}

		// Token: 0x06009A68 RID: 39528 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void PBIGDAAOOHM()
		{
		}

		// Token: 0x06009A69 RID: 39529 RVA: 0x0037D0EF File Offset: 0x0037B2EF
		public virtual void OIKAIJFDLJI()
		{
			this.FIDFADHJFLM();
		}

		// Token: 0x06009A6A RID: 39530 RVA: 0x0037D0E7 File Offset: 0x0037B2E7
		public virtual void DAFOGANDAOL()
		{
			this.BPILKIEHCLD();
		}

		// Token: 0x06009A6B RID: 39531 RVA: 0x0002523B File Offset: 0x0002343B
		public override void SetLayoutVertical()
		{
		}

		// Token: 0x06009A6C RID: 39532 RVA: 0x0037DA93 File Offset: 0x0037BC93
		protected virtual void GFBOBIBIOMC()
		{
			base.OnEnable();
			this.ACKNACMIHJK();
		}

		// Token: 0x06009A6D RID: 39533 RVA: 0x0037E2E8 File Offset: 0x0037C4E8
		private void MEEGEFJCHEO()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			float num = (this.MaxAngle - this.MinAngle) / (float)base.transform.childCount;
			float num2 = this.StartAngle;
			for (int i = 1; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, ~(DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.ScaleY | DrivenTransformProperties.ScaleZ));
					Vector3 a = new Vector3(Mathf.Cos(num2 * 1022f), Mathf.Sin(num2 * 1939f), 657f);
					rectTransform.localPosition = a * this.fDistance;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(772f, 494f);
					rectTransform.pivot = vector;
					vector = vector;
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num2 += num;
				}
			}
		}

		// Token: 0x06009A6E RID: 39534 RVA: 0x0037E3E7 File Offset: 0x0037C5E7
		public virtual void EDHJEIKIGHE()
		{
			this.MEEGEFJCHEO();
		}

		// Token: 0x06009A6F RID: 39535 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void PCPFFJEFMCO()
		{
		}

		// Token: 0x06009A70 RID: 39536 RVA: 0x0037DAA1 File Offset: 0x0037BCA1
		protected virtual void LLDBPKHDPKI()
		{
			base.OnEnable();
			this.GHOAFNJGMGM();
		}

		// Token: 0x06009A71 RID: 39537 RVA: 0x0037E3F0 File Offset: 0x0037C5F0
		private void BPILKIEHCLD()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			float num = (this.MaxAngle - this.MinAngle) / (float)base.transform.childCount;
			float num2 = this.StartAngle;
			for (int i = 0; i < base.transform.childCount; i++)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, ~(DrivenTransformProperties.Rotation | DrivenTransformProperties.ScaleX | DrivenTransformProperties.ScaleZ));
					Vector3 a = new Vector3(Mathf.Cos(num2 * 1142f), Mathf.Sin(num2 * 320f), 1118f);
					rectTransform.localPosition = a * this.fDistance;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(1668f, 1619f);
					rectTransform.pivot = vector;
					vector = vector;
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num2 += num;
				}
			}
		}

		// Token: 0x06009A72 RID: 39538 RVA: 0x0037E4F0 File Offset: 0x0037C6F0
		private void KILNIFEPGPG()
		{
			this.m_Tracker.Clear();
			if (base.transform.childCount == 0)
			{
				return;
			}
			float num = (this.MaxAngle - this.MinAngle) / (float)base.transform.childCount;
			float num2 = this.StartAngle;
			for (int i = 0; i < base.transform.childCount; i += 0)
			{
				RectTransform rectTransform = (RectTransform)base.transform.GetChild(i);
				if (rectTransform != null)
				{
					this.m_Tracker.Add(this, rectTransform, DrivenTransformProperties.Rotation | DrivenTransformProperties.ScaleX);
					Vector3 a = new Vector3(Mathf.Cos(num2 * 508f), Mathf.Sin(num2 * 1648f), 710f);
					rectTransform.localPosition = a * this.fDistance;
					RectTransform rectTransform2 = rectTransform;
					Vector2 vector = new Vector2(780f, 1949f);
					rectTransform.pivot = vector;
					vector = vector;
					rectTransform.anchorMax = vector;
					rectTransform2.anchorMin = vector;
					num2 += num;
				}
			}
		}

		// Token: 0x06009A73 RID: 39539 RVA: 0x0037DBAF File Offset: 0x0037BDAF
		public virtual void KKKIPAIFECF()
		{
			this.PBMCOEAPFNH();
		}

		// Token: 0x06009A74 RID: 39540 RVA: 0x0037DA83 File Offset: 0x0037BC83
		public virtual void CCPDOPIMJFJ()
		{
			this.LDIPBMPFLDO();
		}

		// Token: 0x04001163 RID: 4451
		public float fDistance;

		// Token: 0x04001164 RID: 4452
		[Range(0f, 360f)]
		public float MinAngle;

		// Token: 0x04001165 RID: 4453
		[Range(0f, 360f)]
		public float MaxAngle;

		// Token: 0x04001166 RID: 4454
		[Range(0f, 360f)]
		public float StartAngle;
	}
}
