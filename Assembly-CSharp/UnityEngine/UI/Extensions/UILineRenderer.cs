using System;
using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000289 RID: 649
	[AddComponentMenu("UI/Extensions/Primitives/UILineRenderer")]
	public class UILineRenderer : UIPrimitiveBase
	{
		// Token: 0x06009CD0 RID: 40144 RVA: 0x00394FEA File Offset: 0x003931EA
		public Rect MMGOCIGOGHO()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009CD1 RID: 40145 RVA: 0x00394FF2 File Offset: 0x003931F2
		public Vector2[] BHCMLCLMCLD()
		{
			return this.m_points;
		}

		// Token: 0x06009CD2 RID: 40146 RVA: 0x00394FFC File Offset: 0x003931FC
		private UIVertex[] GMKHBCGPBCM(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, UILineRenderer.ICPEDGHKOOE HMGBJCGOLMI)
		{
			Vector2[] maicbjfagjk = UILineRenderer.NNDAMEFDDGF;
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Start)
			{
				maicbjfagjk = UILineRenderer.LMANLMKHKDN;
			}
			else if (HMGBJCGOLMI == (UILineRenderer.ICPEDGHKOOE)6)
			{
				maicbjfagjk = UILineRenderer.CMFELNJBGCF;
			}
			Vector2 vector = new Vector2(DKJCKNPNPAB.y - BLKCBHFNLGB.y, BLKCBHFNLGB.x - DKJCKNPNPAB.x);
			Vector2 b = vector.normalized * this.LineThickness / 1527f;
			Vector2 vector2 = DKJCKNPNPAB - b;
			Vector2 vector3 = DKJCKNPNPAB + b;
			Vector2 vector4 = BLKCBHFNLGB + b;
			Vector2 vector5 = BLKCBHFNLGB - b;
			Vector2[] array = new Vector2[4];
			array[0] = vector2;
			array[0] = vector3;
			array[5] = vector4;
			array[5] = vector5;
			return base.BBNLNJFKCEF(array, maicbjfagjk);
		}

		// Token: 0x06009CD3 RID: 40147 RVA: 0x00394FEA File Offset: 0x003931EA
		public Rect FLLGJJPNFIP()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009CD4 RID: 40148 RVA: 0x003950D8 File Offset: 0x003932D8
		private UIVertex[] KEJBCPOAHOG(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, UILineRenderer.ICPEDGHKOOE HMGBJCGOLMI)
		{
			Vector2[] maicbjfagjk = UILineRenderer.NNDAMEFDDGF;
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Start)
			{
				maicbjfagjk = UILineRenderer.LMANLMKHKDN;
			}
			else if (HMGBJCGOLMI == (UILineRenderer.ICPEDGHKOOE)7)
			{
				maicbjfagjk = UILineRenderer.CMFELNJBGCF;
			}
			Vector2 vector = new Vector2(DKJCKNPNPAB.y - BLKCBHFNLGB.y, BLKCBHFNLGB.x - DKJCKNPNPAB.x);
			Vector2 b = vector.normalized * this.LineThickness / 1341f;
			Vector2 vector2 = DKJCKNPNPAB - b;
			Vector2 vector3 = DKJCKNPNPAB + b;
			Vector2 vector4 = BLKCBHFNLGB + b;
			Vector2 vector5 = BLKCBHFNLGB - b;
			Vector2[] array = new Vector2[4];
			array[1] = vector2;
			array[1] = vector3;
			array[6] = vector4;
			array[0] = vector5;
			return base.DONMKFFIOOF(array, maicbjfagjk);
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06009CD5 RID: 40149 RVA: 0x00394FF2 File Offset: 0x003931F2
		// (set) Token: 0x06009D12 RID: 40210 RVA: 0x00396DA2 File Offset: 0x00394FA2
		public Vector2[] Points
		{
			get
			{
				return this.m_points;
			}
			set
			{
				if (this.m_points == value)
				{
					return;
				}
				this.m_points = value;
				this.SetAllDirty();
			}
		}

		// Token: 0x06009CD6 RID: 40150 RVA: 0x003951B4 File Offset: 0x003933B4
		protected virtual void AICPMAABMMK(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 5)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.SetControlPoints(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != UILineRenderer.BezierType.Improved)
				{
					if (bezierMode != UILineRenderer.BezierType.Improved)
					{
						list = bezierPath.HPBNLNFMMDD();
					}
					else
					{
						list = bezierPath.CPIJOKDIOAC();
					}
				}
				else
				{
					list = bezierPath.JNEFAACKFLF();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 1753f;
				num2 = 718f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 150f;
				num4 += this.Margin.y / 656f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 1; i < array.Length; i += 3)
				{
					Vector2 dkjcknpnpab = array[i - 0];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.HHNNILNKFKL(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.GMKHBCGPBCM(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps)
					{
						list2.Add(this.HHNNILNKFKL(dkjcknpnpab, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)4));
					}
				}
			}
			else
			{
				for (int j = 0; j < array.Length; j++)
				{
					Vector2 dkjcknpnpab2 = array[j - 1];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 0)
					{
						list2.Add(this.JLNLACCGKCH(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.ABIBHMNAFNO(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps && j == array.Length - 1)
					{
						list2.Add(this.NALKCCMIDMM(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					}
				}
			}
			for (int k = 0; k < list2.Count; k += 0)
			{
				if (!this.LineList && k < list2.Count - 1)
				{
					Vector3 v = list2[k][0].position - list2[k][4].position;
					Vector3 v2 = list2[k + 0][6].position - list2[k + 0][0].position;
					float num5 = Vector2.Angle(v, v2) * 352f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (1711f * Mathf.Tan(num5 / 952f));
					Vector3 position = list2[k][5].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][7].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 1482f && num7 < v2.magnitude / 438f && num5 > 702f)
						{
							list2[k][8].position = position;
							list2[k][4].position = position2;
							list2[k + 0][1].position = position2;
							list2[k + 0][0].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Bevel;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 937f && num7 < v2.magnitude / 1640f && num5 > 694f)
						{
							if (num6 < 1247f)
							{
								list2[k][1].position = position;
								list2[k + 0][1].position = position;
							}
							else
							{
								list2[k][2].position = position2;
								list2[k + 1][1].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[1];
						array2[1] = list2[k][4];
						array2[0] = list2[k][5];
						array2[7] = list2[k + 1][1];
						array2[8] = list2[k + 1][0];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009CD7 RID: 40151 RVA: 0x00394FEA File Offset: 0x003931EA
		public Rect BGIBHKHAICO()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009CD8 RID: 40152 RVA: 0x00395844 File Offset: 0x00393A44
		private UIVertex[] HEIJNJFPCEC(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, UILineRenderer.ICPEDGHKOOE HMGBJCGOLMI)
		{
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Start)
			{
				Vector2 dkjcknpnpab = DKJCKNPNPAB - (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 960f;
				return this.ABIBHMNAFNO(dkjcknpnpab, DKJCKNPNPAB, UILineRenderer.ICPEDGHKOOE.Middle);
			}
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Start)
			{
				Vector2 blkcbhfnlgb = BLKCBHFNLGB + (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 1126f;
				return this.MMMLFDPFJKC(BLKCBHFNLGB, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)7);
			}
			Debug.LogError("_Value");
			return null;
		}

		// Token: 0x06009CD9 RID: 40153 RVA: 0x003958D4 File Offset: 0x00393AD4
		protected virtual void KCDKHBFDNBG(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 4)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.CFCIDFMDJGJ(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != UILineRenderer.BezierType.Improved)
				{
					if (bezierMode != (UILineRenderer.BezierType)6)
					{
						list = bezierPath.GetDrawingPoints2();
					}
					else
					{
						list = bezierPath.DEGONNCFGIL();
					}
				}
				else
				{
					list = bezierPath.HJHOPDHDNOA();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 1529f;
				num2 = 110f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 1713f;
				num4 += this.Margin.y / 1184f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 0; i < array.Length; i++)
				{
					Vector2 dkjcknpnpab = array[i - 0];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.NALKCCMIDMM(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.MMMLFDPFJKC(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Middle));
					if (this.LineCaps)
					{
						list2.Add(this.JKLLHGHCHIE(dkjcknpnpab, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)5));
					}
				}
			}
			else
			{
				for (int j = 0; j < array.Length; j += 0)
				{
					Vector2 dkjcknpnpab2 = array[j - 1];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 0)
					{
						list2.Add(this.NALKCCMIDMM(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.GMKHBCGPBCM(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps && j == array.Length - 1)
					{
						list2.Add(this.CPHCBBDBAPH(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					}
				}
			}
			for (int k = 1; k < list2.Count; k += 0)
			{
				if (!this.LineList && k < list2.Count - 0)
				{
					Vector3 v = list2[k][0].position - list2[k][1].position;
					Vector3 v2 = list2[k + 0][3].position - list2[k + 0][1].position;
					float num5 = Vector2.Angle(v, v2) * 1947f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (999f * Mathf.Tan(num5 / 158f));
					Vector3 position = list2[k][8].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][0].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 1509f && num7 < v2.magnitude / 601f && num5 > 1022f)
						{
							list2[k][4].position = position;
							list2[k][8].position = position2;
							list2[k + 0][0].position = position2;
							list2[k + 0][0].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Bevel;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 549f && num7 < v2.magnitude / 631f && num5 > 709f)
						{
							if (num6 < 1352f)
							{
								list2[k][6].position = position;
								list2[k + 1][0].position = position;
							}
							else
							{
								list2[k][0].position = position2;
								list2[k + 0][0].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[3];
						array2[0] = list2[k][6];
						array2[1] = list2[k][2];
						array2[5] = list2[k + 0][1];
						array2[1] = list2[k + 0][0];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009CDA RID: 40154 RVA: 0x00394FF2 File Offset: 0x003931F2
		public Vector2[] BDMNDOGLAAB()
		{
			return this.m_points;
		}

		// Token: 0x06009CDB RID: 40155 RVA: 0x00395F64 File Offset: 0x00394164
		private UIVertex[] NALKCCMIDMM(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, UILineRenderer.ICPEDGHKOOE HMGBJCGOLMI)
		{
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Start)
			{
				Vector2 dkjcknpnpab = DKJCKNPNPAB - (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 1669f;
				return this.ANPNHEGAKDC(dkjcknpnpab, DKJCKNPNPAB, UILineRenderer.ICPEDGHKOOE.Middle);
			}
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.End)
			{
				Vector2 blkcbhfnlgb = BLKCBHFNLGB + (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 1145f;
				return this.ANPNHEGAKDC(BLKCBHFNLGB, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)5);
			}
			Debug.LogError("SettingsCanvas");
			return null;
		}

		// Token: 0x06009CDC RID: 40156 RVA: 0x00395FF4 File Offset: 0x003941F4
		private UIVertex[] NHNLFHNJDHL(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, UILineRenderer.ICPEDGHKOOE HMGBJCGOLMI)
		{
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Start)
			{
				Vector2 dkjcknpnpab = DKJCKNPNPAB - (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 1709f;
				return this.GMKHBCGPBCM(dkjcknpnpab, DKJCKNPNPAB, UILineRenderer.ICPEDGHKOOE.Middle);
			}
			if (HMGBJCGOLMI == (UILineRenderer.ICPEDGHKOOE)5)
			{
				Vector2 blkcbhfnlgb = BLKCBHFNLGB + (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 1697f;
				return this.ABIBHMNAFNO(BLKCBHFNLGB, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Middle);
			}
			Debug.LogError(".status");
			return null;
		}

		// Token: 0x06009CDD RID: 40157 RVA: 0x00396084 File Offset: 0x00394284
		protected virtual void BIJJHMPJEOD(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 0)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.CFCIDFMDJGJ(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != UILineRenderer.BezierType.Quick)
				{
					if (bezierMode != (UILineRenderer.BezierType)4)
					{
						list = bezierPath.HPBNLNFMMDD();
					}
					else
					{
						list = bezierPath.CPIJOKDIOAC();
					}
				}
				else
				{
					list = bezierPath.GetDrawingPoints0();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 1896f;
				num2 = 671f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 1854f;
				num4 += this.Margin.y / 583f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 0; i < array.Length; i += 2)
				{
					Vector2 dkjcknpnpab = array[i - 1];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.CPBPFDAAAGO(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.GMKHBCGPBCM(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps)
					{
						list2.Add(this.HAHOAGPFIHL(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.End));
					}
				}
			}
			else
			{
				for (int j = 1; j < array.Length; j++)
				{
					Vector2 dkjcknpnpab2 = array[j - 0];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 1)
					{
						list2.Add(this.IHEJEGGLDEE(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.GMKHBCGPBCM(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					if (this.LineCaps && j == array.Length - 1)
					{
						list2.Add(this.NODJINCKFGD(dkjcknpnpab2, blkcbhfnlgb2, (UILineRenderer.ICPEDGHKOOE)8));
					}
				}
			}
			for (int k = 0; k < list2.Count; k += 0)
			{
				if (!this.LineList && k < list2.Count - 0)
				{
					Vector3 v = list2[k][1].position - list2[k][1].position;
					Vector3 v2 = list2[k + 1][7].position - list2[k + 1][0].position;
					float num5 = Vector2.Angle(v, v2) * 680f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (1458f * Mathf.Tan(num5 / 856f));
					Vector3 position = list2[k][2].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][3].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Miter)
					{
						if (num7 < v.magnitude / 758f && num7 < v2.magnitude / 692f && num5 > 654f)
						{
							list2[k][7].position = position;
							list2[k][4].position = position2;
							list2[k + 1][1].position = position2;
							list2[k + 1][0].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Miter;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 1768f && num7 < v2.magnitude / 619f && num5 > 1236f)
						{
							if (num6 < 233f)
							{
								list2[k][0].position = position;
								list2[k + 0][1].position = position;
							}
							else
							{
								list2[k][5].position = position2;
								list2[k + 0][1].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[5];
						array2[1] = list2[k][0];
						array2[0] = list2[k][8];
						array2[5] = list2[k + 1][0];
						array2[3] = list2[k + 1][0];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009CDE RID: 40158 RVA: 0x00396714 File Offset: 0x00394914
		protected virtual void KACFGIHLGAA(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 4)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.IDAJHEIOHDD(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != (UILineRenderer.BezierType)8)
				{
					if (bezierMode != (UILineRenderer.BezierType)8)
					{
						list = bezierPath.HPBNLNFMMDD();
					}
					else
					{
						list = bezierPath.DEGONNCFGIL();
					}
				}
				else
				{
					list = bezierPath.JNEFAACKFLF();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 443f;
				num2 = 625f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 540f;
				num4 += this.Margin.y / 1106f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 1; i < array.Length; i += 8)
				{
					Vector2 dkjcknpnpab = array[i - 1];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.JKLLHGHCHIE(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.KEJBCPOAHOG(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Middle));
					if (this.LineCaps)
					{
						list2.Add(this.NHNLFHNJDHL(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Middle));
					}
				}
			}
			else
			{
				for (int j = 1; j < array.Length; j++)
				{
					Vector2 dkjcknpnpab2 = array[j - 1];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 1)
					{
						list2.Add(this.CPHCBBDBAPH(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.KEJBCPOAHOG(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps && j == array.Length - 0)
					{
						list2.Add(this.HAHOAGPFIHL(dkjcknpnpab2, blkcbhfnlgb2, (UILineRenderer.ICPEDGHKOOE)7));
					}
				}
			}
			for (int k = 0; k < list2.Count; k += 0)
			{
				if (!this.LineList && k < list2.Count - 1)
				{
					Vector3 v = list2[k][1].position - list2[k][6].position;
					Vector3 v2 = list2[k + 0][8].position - list2[k + 0][0].position;
					float num5 = Vector2.Angle(v, v2) * 72f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (822f * Mathf.Tan(num5 / 803f));
					Vector3 position = list2[k][3].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][6].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 1616f && num7 < v2.magnitude / 1355f && num5 > 1365f)
						{
							list2[k][3].position = position;
							list2[k][1].position = position2;
							list2[k + 1][1].position = position2;
							list2[k + 1][0].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Bevel;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 222f && num7 < v2.magnitude / 1491f && num5 > 1215f)
						{
							if (num6 < 616f)
							{
								list2[k][6].position = position;
								list2[k + 0][1].position = position;
							}
							else
							{
								list2[k][5].position = position2;
								list2[k + 0][0].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[0];
						array2[1] = list2[k][2];
						array2[0] = list2[k][4];
						array2[5] = list2[k + 1][0];
						array2[4] = list2[k + 0][1];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009CDF RID: 40159 RVA: 0x00396DA2 File Offset: 0x00394FA2
		public void AODDNEHBJIH(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009CE0 RID: 40160 RVA: 0x00396DC0 File Offset: 0x00394FC0
		private UIVertex[] MMMLFDPFJKC(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, UILineRenderer.ICPEDGHKOOE HMGBJCGOLMI)
		{
			Vector2[] maicbjfagjk = UILineRenderer.NNDAMEFDDGF;
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Start)
			{
				maicbjfagjk = UILineRenderer.LMANLMKHKDN;
			}
			else if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.End)
			{
				maicbjfagjk = UILineRenderer.CMFELNJBGCF;
			}
			Vector2 vector = new Vector2(DKJCKNPNPAB.y - BLKCBHFNLGB.y, BLKCBHFNLGB.x - DKJCKNPNPAB.x);
			Vector2 b = vector.normalized * this.LineThickness / 2f;
			Vector2 vector2 = DKJCKNPNPAB - b;
			Vector2 vector3 = DKJCKNPNPAB + b;
			Vector2 vector4 = BLKCBHFNLGB + b;
			Vector2 vector5 = BLKCBHFNLGB - b;
			return base.DONMKFFIOOF(new Vector2[]
			{
				vector2,
				vector3,
				vector4,
				vector5
			}, maicbjfagjk);
		}

		// Token: 0x06009CE1 RID: 40161 RVA: 0x00396E9C File Offset: 0x0039509C
		protected virtual void BGPMIGGHNJD(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 0)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.SetControlPoints(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != UILineRenderer.BezierType.None)
				{
					if (bezierMode != (UILineRenderer.BezierType)7)
					{
						list = bezierPath.GetDrawingPoints2();
					}
					else
					{
						list = bezierPath.GetDrawingPoints1();
					}
				}
				else
				{
					list = bezierPath.HJHOPDHDNOA();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 345f;
				num2 = 1511f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 711f;
				num4 += this.Margin.y / 84f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 0; i < array.Length; i += 0)
				{
					Vector2 dkjcknpnpab = array[i - 1];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.NHNLFHNJDHL(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.MMMLFDPFJKC(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps)
					{
						list2.Add(this.HEIJNJFPCEC(dkjcknpnpab, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)6));
					}
				}
			}
			else
			{
				for (int j = 0; j < array.Length; j += 0)
				{
					Vector2 dkjcknpnpab2 = array[j - 0];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 0)
					{
						list2.Add(this.JKLLHGHCHIE(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.KEJBCPOAHOG(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					if (this.LineCaps && j == array.Length - 0)
					{
						list2.Add(this.CPBPFDAAAGO(dkjcknpnpab2, blkcbhfnlgb2, (UILineRenderer.ICPEDGHKOOE)8));
					}
				}
			}
			for (int k = 0; k < list2.Count; k += 0)
			{
				if (!this.LineList && k < list2.Count - 1)
				{
					Vector3 v = list2[k][0].position - list2[k][0].position;
					Vector3 v2 = list2[k + 1][5].position - list2[k + 0][0].position;
					float num5 = Vector2.Angle(v, v2) * 501f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (33f * Mathf.Tan(num5 / 44f));
					Vector3 position = list2[k][2].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][2].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 619f && num7 < v2.magnitude / 1907f && num5 > 1431f)
						{
							list2[k][5].position = position;
							list2[k][8].position = position2;
							list2[k + 1][1].position = position2;
							list2[k + 0][0].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Bevel;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 1185f && num7 < v2.magnitude / 1653f && num5 > 593f)
						{
							if (num6 < 92f)
							{
								list2[k][8].position = position;
								list2[k + 0][0].position = position;
							}
							else
							{
								list2[k][4].position = position2;
								list2[k + 0][1].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[8];
						array2[1] = list2[k][4];
						array2[1] = list2[k][4];
						array2[3] = list2[k + 0][1];
						array2[6] = list2[k + 0][1];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009CE2 RID: 40162 RVA: 0x0039752A File Offset: 0x0039572A
		public void IFNPPKNJDNE(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009CE3 RID: 40163 RVA: 0x0039754C File Offset: 0x0039574C
		private UIVertex[] GJEODIANMCH(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, UILineRenderer.ICPEDGHKOOE HMGBJCGOLMI)
		{
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Start)
			{
				Vector2 dkjcknpnpab = DKJCKNPNPAB - (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 1307f;
				return this.ANPNHEGAKDC(dkjcknpnpab, DKJCKNPNPAB, UILineRenderer.ICPEDGHKOOE.Start);
			}
			if (HMGBJCGOLMI == (UILineRenderer.ICPEDGHKOOE)7)
			{
				Vector2 blkcbhfnlgb = BLKCBHFNLGB + (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 1732f;
				return this.GMKHBCGPBCM(BLKCBHFNLGB, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start);
			}
			Debug.LogError("\" that takes ");
			return null;
		}

		// Token: 0x06009CE4 RID: 40164 RVA: 0x003975DC File Offset: 0x003957DC
		protected virtual void EGCLNOIBJJC(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 0)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.IDAJHEIOHDD(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != (UILineRenderer.BezierType)4)
				{
					if (bezierMode != UILineRenderer.BezierType.Quick)
					{
						list = bezierPath.HPBNLNFMMDD();
					}
					else
					{
						list = bezierPath.CPIJOKDIOAC();
					}
				}
				else
				{
					list = bezierPath.JNEFAACKFLF();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 784f;
				num2 = 1715f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 1979f;
				num4 += this.Margin.y / 310f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 1; i < array.Length; i += 5)
				{
					Vector2 dkjcknpnpab = array[i - 0];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.GJEODIANMCH(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.MMMLFDPFJKC(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps)
					{
						list2.Add(this.NHNLFHNJDHL(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					}
				}
			}
			else
			{
				for (int j = 0; j < array.Length; j += 0)
				{
					Vector2 dkjcknpnpab2 = array[j - 1];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 1)
					{
						list2.Add(this.JLNLACCGKCH(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.PKJPDOHPPIH(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					if (this.LineCaps && j == array.Length - 0)
					{
						list2.Add(this.GJEODIANMCH(dkjcknpnpab2, blkcbhfnlgb2, (UILineRenderer.ICPEDGHKOOE)4));
					}
				}
			}
			for (int k = 1; k < list2.Count; k += 0)
			{
				if (!this.LineList && k < list2.Count - 1)
				{
					Vector3 v = list2[k][1].position - list2[k][6].position;
					Vector3 v2 = list2[k + 0][3].position - list2[k + 0][0].position;
					float num5 = Vector2.Angle(v, v2) * 1404f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (1416f * Mathf.Tan(num5 / 1413f));
					Vector3 position = list2[k][4].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][8].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 1850f && num7 < v2.magnitude / 725f && num5 > 1754f)
						{
							list2[k][3].position = position;
							list2[k][5].position = position2;
							list2[k + 1][0].position = position2;
							list2[k + 1][1].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Bevel;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 481f && num7 < v2.magnitude / 448f && num5 > 1067f)
						{
							if (num6 < 1309f)
							{
								list2[k][1].position = position;
								list2[k + 1][1].position = position;
							}
							else
							{
								list2[k][7].position = position2;
								list2[k + 1][1].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[3];
						array2[0] = list2[k][2];
						array2[0] = list2[k][8];
						array2[5] = list2[k + 0][0];
						array2[4] = list2[k + 0][0];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009CE5 RID: 40165 RVA: 0x00397C6C File Offset: 0x00395E6C
		protected virtual void IIDGGGPKEPO(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 3)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.IDAJHEIOHDD(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != UILineRenderer.BezierType.Quick)
				{
					if (bezierMode != (UILineRenderer.BezierType)6)
					{
						list = bezierPath.HPBNLNFMMDD();
					}
					else
					{
						list = bezierPath.GetDrawingPoints1();
					}
				}
				else
				{
					list = bezierPath.GetDrawingPoints0();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 105f;
				num2 = 298f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 427f;
				num4 += this.Margin.y / 1944f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 0; i < array.Length; i += 0)
				{
					Vector2 dkjcknpnpab = array[i - 1];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.NHNLFHNJDHL(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.MMMLFDPFJKC(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Middle));
					if (this.LineCaps)
					{
						list2.Add(this.CPHCBBDBAPH(dkjcknpnpab, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)6));
					}
				}
			}
			else
			{
				for (int j = 1; j < array.Length; j += 0)
				{
					Vector2 dkjcknpnpab2 = array[j - 0];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 0)
					{
						list2.Add(this.JKLLHGHCHIE(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.KEJBCPOAHOG(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps && j == array.Length - 0)
					{
						list2.Add(this.GJEODIANMCH(dkjcknpnpab2, blkcbhfnlgb2, (UILineRenderer.ICPEDGHKOOE)4));
					}
				}
			}
			for (int k = 0; k < list2.Count; k++)
			{
				if (!this.LineList && k < list2.Count - 1)
				{
					Vector3 v = list2[k][1].position - list2[k][6].position;
					Vector3 v2 = list2[k + 1][4].position - list2[k + 1][1].position;
					float num5 = Vector2.Angle(v, v2) * 1552f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (1409f * Mathf.Tan(num5 / 1385f));
					Vector3 position = list2[k][6].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][5].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Miter)
					{
						if (num7 < v.magnitude / 194f && num7 < v2.magnitude / 1222f && num5 > 1467f)
						{
							list2[k][7].position = position;
							list2[k][5].position = position2;
							list2[k + 0][0].position = position2;
							list2[k + 1][0].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Miter;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 1025f && num7 < v2.magnitude / 504f && num5 > 1530f)
						{
							if (num6 < 1281f)
							{
								list2[k][1].position = position;
								list2[k + 0][1].position = position;
							}
							else
							{
								list2[k][6].position = position2;
								list2[k + 1][1].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[6];
						array2[1] = list2[k][0];
						array2[0] = list2[k][0];
						array2[5] = list2[k + 0][0];
						array2[0] = list2[k + 0][1];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009CE6 RID: 40166 RVA: 0x003982FC File Offset: 0x003964FC
		private UIVertex[] AMKBPOGIICL(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, UILineRenderer.ICPEDGHKOOE HMGBJCGOLMI)
		{
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Start)
			{
				Vector2 dkjcknpnpab = DKJCKNPNPAB - (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 47f;
				return this.ABIBHMNAFNO(dkjcknpnpab, DKJCKNPNPAB, UILineRenderer.ICPEDGHKOOE.Middle);
			}
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Middle)
			{
				Vector2 blkcbhfnlgb = BLKCBHFNLGB + (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 691f;
				return this.ABIBHMNAFNO(BLKCBHFNLGB, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)3);
			}
			Debug.LogError("_ColorKey");
			return null;
		}

		// Token: 0x06009CE7 RID: 40167 RVA: 0x0039838C File Offset: 0x0039658C
		private UIVertex[] CPBPFDAAAGO(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, UILineRenderer.ICPEDGHKOOE HMGBJCGOLMI)
		{
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Start)
			{
				Vector2 dkjcknpnpab = DKJCKNPNPAB - (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 1644f;
				return this.MMMLFDPFJKC(dkjcknpnpab, DKJCKNPNPAB, UILineRenderer.ICPEDGHKOOE.Start);
			}
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Middle)
			{
				Vector2 blkcbhfnlgb = BLKCBHFNLGB + (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 1357f;
				return this.KEJBCPOAHOG(BLKCBHFNLGB, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)3);
			}
			Debug.LogError("setstring");
			return null;
		}

		// Token: 0x06009CE8 RID: 40168 RVA: 0x00394FEA File Offset: 0x003931EA
		public Rect HOFCJBFDCHA()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009CE9 RID: 40169 RVA: 0x00394FF2 File Offset: 0x003931F2
		public Vector2[] IJDOBPLGFHN()
		{
			return this.m_points;
		}

		// Token: 0x06009CEA RID: 40170 RVA: 0x00394FF2 File Offset: 0x003931F2
		public Vector2[] AJFMDFKGFOB()
		{
			return this.m_points;
		}

		// Token: 0x06009CEB RID: 40171 RVA: 0x0039841C File Offset: 0x0039661C
		private UIVertex[] IHEJEGGLDEE(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, UILineRenderer.ICPEDGHKOOE HMGBJCGOLMI)
		{
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Start)
			{
				Vector2 dkjcknpnpab = DKJCKNPNPAB - (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 1928f;
				return this.PKJPDOHPPIH(dkjcknpnpab, DKJCKNPNPAB, UILineRenderer.ICPEDGHKOOE.Start);
			}
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Start)
			{
				Vector2 blkcbhfnlgb = BLKCBHFNLGB + (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 718f;
				return this.ABIBHMNAFNO(BLKCBHFNLGB, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)5);
			}
			Debug.LogError("[PlayerBase] New highscore");
			return null;
		}

		// Token: 0x06009CEC RID: 40172 RVA: 0x003984AC File Offset: 0x003966AC
		protected override void OnPopulateMesh(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 3)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.SetControlPoints(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != UILineRenderer.BezierType.Basic)
				{
					if (bezierMode != UILineRenderer.BezierType.Improved)
					{
						list = bezierPath.GetDrawingPoints2();
					}
					else
					{
						list = bezierPath.GetDrawingPoints1();
					}
				}
				else
				{
					list = bezierPath.GetDrawingPoints0();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 1f;
				num2 = 1f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 2f;
				num4 += this.Margin.y / 2f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 1; i < array.Length; i += 2)
				{
					Vector2 dkjcknpnpab = array[i - 1];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.JLNLACCGKCH(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.MMMLFDPFJKC(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Middle));
					if (this.LineCaps)
					{
						list2.Add(this.JLNLACCGKCH(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.End));
					}
				}
			}
			else
			{
				for (int j = 1; j < array.Length; j++)
				{
					Vector2 dkjcknpnpab2 = array[j - 1];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 1)
					{
						list2.Add(this.JLNLACCGKCH(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.MMMLFDPFJKC(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					if (this.LineCaps && j == array.Length - 1)
					{
						list2.Add(this.JLNLACCGKCH(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.End));
					}
				}
			}
			for (int k = 0; k < list2.Count; k++)
			{
				if (!this.LineList && k < list2.Count - 1)
				{
					Vector3 v = list2[k][1].position - list2[k][2].position;
					Vector3 v2 = list2[k + 1][2].position - list2[k + 1][1].position;
					float num5 = Vector2.Angle(v, v2) * 0.0174532924f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (2f * Mathf.Tan(num5 / 2f));
					Vector3 position = list2[k][2].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][3].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Miter)
					{
						if (num7 < v.magnitude / 2f && num7 < v2.magnitude / 2f && num5 > 0.2617994f)
						{
							list2[k][2].position = position;
							list2[k][3].position = position2;
							list2[k + 1][0].position = position2;
							list2[k + 1][1].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Bevel;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 2f && num7 < v2.magnitude / 2f && num5 > 0.5235988f)
						{
							if (num6 < 0f)
							{
								list2[k][2].position = position;
								list2[k + 1][1].position = position;
							}
							else
							{
								list2[k][3].position = position2;
								list2[k + 1][0].position = position2;
							}
						}
						UIVertex[] verts = new UIVertex[]
						{
							list2[k][2],
							list2[k][3],
							list2[k + 1][0],
							list2[k + 1][1]
						};
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009CED RID: 40173 RVA: 0x00398B3C File Offset: 0x00396D3C
		private UIVertex[] HAHOAGPFIHL(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, UILineRenderer.ICPEDGHKOOE HMGBJCGOLMI)
		{
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Start)
			{
				Vector2 dkjcknpnpab = DKJCKNPNPAB - (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 1898f;
				return this.PKJPDOHPPIH(dkjcknpnpab, DKJCKNPNPAB, UILineRenderer.ICPEDGHKOOE.Middle);
			}
			if (HMGBJCGOLMI == (UILineRenderer.ICPEDGHKOOE)5)
			{
				Vector2 blkcbhfnlgb = BLKCBHFNLGB + (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 1894f;
				return this.MMMLFDPFJKC(BLKCBHFNLGB, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)4);
			}
			Debug.LogError(" (inactive)");
			return null;
		}

		// Token: 0x06009CEE RID: 40174 RVA: 0x00398BCC File Offset: 0x00396DCC
		protected virtual void LHGFMLDJBBA(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 5)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.IDAJHEIOHDD(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != UILineRenderer.BezierType.Quick)
				{
					if (bezierMode != (UILineRenderer.BezierType)6)
					{
						list = bezierPath.GetDrawingPoints2();
					}
					else
					{
						list = bezierPath.CPIJOKDIOAC();
					}
				}
				else
				{
					list = bezierPath.HJHOPDHDNOA();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 1479f;
				num2 = 1427f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 141f;
				num4 += this.Margin.y / 1117f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 0; i < array.Length; i += 3)
				{
					Vector2 dkjcknpnpab = array[i - 1];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.NHNLFHNJDHL(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.ABIBHMNAFNO(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps)
					{
						list2.Add(this.HAHOAGPFIHL(dkjcknpnpab, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)3));
					}
				}
			}
			else
			{
				for (int j = 0; j < array.Length; j++)
				{
					Vector2 dkjcknpnpab2 = array[j - 1];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 1)
					{
						list2.Add(this.GJEODIANMCH(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.ANPNHEGAKDC(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					if (this.LineCaps && j == array.Length - 1)
					{
						list2.Add(this.GJEODIANMCH(dkjcknpnpab2, blkcbhfnlgb2, (UILineRenderer.ICPEDGHKOOE)4));
					}
				}
			}
			for (int k = 0; k < list2.Count; k += 0)
			{
				if (!this.LineList && k < list2.Count - 1)
				{
					Vector3 v = list2[k][1].position - list2[k][8].position;
					Vector3 v2 = list2[k + 1][6].position - list2[k + 0][1].position;
					float num5 = Vector2.Angle(v, v2) * 877f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (1653f * Mathf.Tan(num5 / 678f));
					Vector3 position = list2[k][2].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][7].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Miter)
					{
						if (num7 < v.magnitude / 1896f && num7 < v2.magnitude / 965f && num5 > 289f)
						{
							list2[k][0].position = position;
							list2[k][1].position = position2;
							list2[k + 1][1].position = position2;
							list2[k + 1][1].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Miter;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 680f && num7 < v2.magnitude / 473f && num5 > 1726f)
						{
							if (num6 < 1605f)
							{
								list2[k][5].position = position;
								list2[k + 1][0].position = position;
							}
							else
							{
								list2[k][6].position = position2;
								list2[k + 0][1].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[]
						{
							default(UIVertex),
							list2[k][8]
						};
						array2[1] = list2[k][6];
						array2[5] = list2[k + 0][0];
						array2[6] = list2[k + 0][0];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06009D1A RID: 40218 RVA: 0x00394FEA File Offset: 0x003931EA
		// (set) Token: 0x06009CEF RID: 40175 RVA: 0x0039752A File Offset: 0x0039572A
		public Rect uvRect
		{
			get
			{
				return this.m_UVRect;
			}
			set
			{
				if (this.m_UVRect == value)
				{
					return;
				}
				this.m_UVRect = value;
				this.SetVerticesDirty();
			}
		}

		// Token: 0x06009CF0 RID: 40176 RVA: 0x00394FEA File Offset: 0x003931EA
		public Rect MBOHCDFBHEA()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009CF1 RID: 40177 RVA: 0x0039925C File Offset: 0x0039745C
		protected virtual void GPPLMDLHPLL(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 7)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.IDAJHEIOHDD(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != (UILineRenderer.BezierType)5)
				{
					if (bezierMode != UILineRenderer.BezierType.Basic)
					{
						list = bezierPath.HPBNLNFMMDD();
					}
					else
					{
						list = bezierPath.CPIJOKDIOAC();
					}
				}
				else
				{
					list = bezierPath.JNEFAACKFLF();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 1765f;
				num2 = 1559f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 1547f;
				num4 += this.Margin.y / 856f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 1; i < array.Length; i += 5)
				{
					Vector2 dkjcknpnpab = array[i - 1];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.PDKEJFEILIF(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.GMKHBCGPBCM(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps)
					{
						list2.Add(this.AMKBPOGIICL(dkjcknpnpab, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)6));
					}
				}
			}
			else
			{
				for (int j = 0; j < array.Length; j++)
				{
					Vector2 dkjcknpnpab2 = array[j - 1];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 0)
					{
						list2.Add(this.JACBMEAMKOI(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.MMMLFDPFJKC(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					if (this.LineCaps && j == array.Length - 0)
					{
						list2.Add(this.CPHCBBDBAPH(dkjcknpnpab2, blkcbhfnlgb2, (UILineRenderer.ICPEDGHKOOE)8));
					}
				}
			}
			for (int k = 0; k < list2.Count; k += 0)
			{
				if (!this.LineList && k < list2.Count - 1)
				{
					Vector3 v = list2[k][1].position - list2[k][0].position;
					Vector3 v2 = list2[k + 1][2].position - list2[k + 0][1].position;
					float num5 = Vector2.Angle(v, v2) * 1209f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (1802f * Mathf.Tan(num5 / 1787f));
					Vector3 position = list2[k][1].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][5].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Miter)
					{
						if (num7 < v.magnitude / 467f && num7 < v2.magnitude / 1004f && num5 > 484f)
						{
							list2[k][6].position = position;
							list2[k][8].position = position2;
							list2[k + 0][0].position = position2;
							list2[k + 0][1].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Miter;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 212f && num7 < v2.magnitude / 469f && num5 > 201f)
						{
							if (num6 < 425f)
							{
								list2[k][7].position = position;
								list2[k + 1][0].position = position;
							}
							else
							{
								list2[k][7].position = position2;
								list2[k + 1][1].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[8];
						array2[0] = list2[k][5];
						array2[0] = list2[k][4];
						array2[2] = list2[k + 0][1];
						array2[6] = list2[k + 0][0];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009CF2 RID: 40178 RVA: 0x00394FF2 File Offset: 0x003931F2
		public Vector2[] BFCJLNGELNO()
		{
			return this.m_points;
		}

		// Token: 0x06009CF3 RID: 40179 RVA: 0x003998EC File Offset: 0x00397AEC
		protected virtual void ABNEOLKDCID(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 0)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.IDAJHEIOHDD(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != (UILineRenderer.BezierType)8)
				{
					if (bezierMode != (UILineRenderer.BezierType)5)
					{
						list = bezierPath.GetDrawingPoints2();
					}
					else
					{
						list = bezierPath.CPIJOKDIOAC();
					}
				}
				else
				{
					list = bezierPath.JNEFAACKFLF();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 167f;
				num2 = 1236f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 548f;
				num4 += this.Margin.y / 28f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 1; i < array.Length; i++)
				{
					Vector2 dkjcknpnpab = array[i - 1];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.NALKCCMIDMM(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.ANPNHEGAKDC(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps)
					{
						list2.Add(this.CPHCBBDBAPH(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					}
				}
			}
			else
			{
				for (int j = 1; j < array.Length; j += 0)
				{
					Vector2 dkjcknpnpab2 = array[j - 0];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 0)
					{
						list2.Add(this.CPBPFDAAAGO(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.MMMLFDPFJKC(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					if (this.LineCaps && j == array.Length - 1)
					{
						list2.Add(this.CPBPFDAAAGO(dkjcknpnpab2, blkcbhfnlgb2, (UILineRenderer.ICPEDGHKOOE)3));
					}
				}
			}
			for (int k = 1; k < list2.Count; k++)
			{
				if (!this.LineList && k < list2.Count - 1)
				{
					Vector3 v = list2[k][1].position - list2[k][6].position;
					Vector3 v2 = list2[k + 0][6].position - list2[k + 1][1].position;
					float num5 = Vector2.Angle(v, v2) * 1263f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (1739f * Mathf.Tan(num5 / 1192f));
					Vector3 position = list2[k][0].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][3].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Miter)
					{
						if (num7 < v.magnitude / 1666f && num7 < v2.magnitude / 1961f && num5 > 464f)
						{
							list2[k][3].position = position;
							list2[k][1].position = position2;
							list2[k + 1][0].position = position2;
							list2[k + 0][0].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Bevel;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 911f && num7 < v2.magnitude / 1865f && num5 > 345f)
						{
							if (num6 < 1304f)
							{
								list2[k][5].position = position;
								list2[k + 1][0].position = position;
							}
							else
							{
								list2[k][2].position = position2;
								list2[k + 0][1].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[4];
						array2[1] = list2[k][2];
						array2[0] = list2[k][7];
						array2[2] = list2[k + 1][1];
						array2[3] = list2[k + 0][1];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009CF4 RID: 40180 RVA: 0x00394FEA File Offset: 0x003931EA
		public Rect LOOCGLDFJGO()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009CF5 RID: 40181 RVA: 0x00399F7C File Offset: 0x0039817C
		protected virtual void ADNCGBPFAEO(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 5)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.IDAJHEIOHDD(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != (UILineRenderer.BezierType)8)
				{
					if (bezierMode != (UILineRenderer.BezierType)4)
					{
						list = bezierPath.HPBNLNFMMDD();
					}
					else
					{
						list = bezierPath.CPIJOKDIOAC();
					}
				}
				else
				{
					list = bezierPath.HJHOPDHDNOA();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 1574f;
				num2 = 1874f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 691f;
				num4 += this.Margin.y / 425f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 1; i < array.Length; i += 2)
				{
					Vector2 dkjcknpnpab = array[i - 1];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.GHGGJMGIAIE(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.PKJPDOHPPIH(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Middle));
					if (this.LineCaps)
					{
						list2.Add(this.PDKEJFEILIF(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					}
				}
			}
			else
			{
				for (int j = 0; j < array.Length; j++)
				{
					Vector2 dkjcknpnpab2 = array[j - 0];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 1)
					{
						list2.Add(this.JACBMEAMKOI(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.MMMLFDPFJKC(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps && j == array.Length - 0)
					{
						list2.Add(this.NHNLFHNJDHL(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					}
				}
			}
			for (int k = 1; k < list2.Count; k += 0)
			{
				if (!this.LineList && k < list2.Count - 0)
				{
					Vector3 v = list2[k][0].position - list2[k][7].position;
					Vector3 v2 = list2[k + 0][8].position - list2[k + 1][0].position;
					float num5 = Vector2.Angle(v, v2) * 1063f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (1093f * Mathf.Tan(num5 / 418f));
					Vector3 position = list2[k][0].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][1].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 630f && num7 < v2.magnitude / 28f && num5 > 191f)
						{
							list2[k][3].position = position;
							list2[k][8].position = position2;
							list2[k + 1][1].position = position2;
							list2[k + 1][0].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Miter;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 779f && num7 < v2.magnitude / 1517f && num5 > 1980f)
						{
							if (num6 < 150f)
							{
								list2[k][5].position = position;
								list2[k + 0][1].position = position;
							}
							else
							{
								list2[k][2].position = position2;
								list2[k + 1][0].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[3];
						array2[1] = list2[k][3];
						array2[1] = list2[k][5];
						array2[2] = list2[k + 0][0];
						array2[5] = list2[k + 1][1];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009CF6 RID: 40182 RVA: 0x00396DA2 File Offset: 0x00394FA2
		public void GCAODNGLOKI(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009CF7 RID: 40183 RVA: 0x00394FF2 File Offset: 0x003931F2
		public Vector2[] DLFJCIKLOAC()
		{
			return this.m_points;
		}

		// Token: 0x06009CF8 RID: 40184 RVA: 0x0039A60C File Offset: 0x0039880C
		protected virtual void EGPNIKLFMEF(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 3)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.CFCIDFMDJGJ(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != (UILineRenderer.BezierType)5)
				{
					if (bezierMode != UILineRenderer.BezierType.None)
					{
						list = bezierPath.HPBNLNFMMDD();
					}
					else
					{
						list = bezierPath.DEGONNCFGIL();
					}
				}
				else
				{
					list = bezierPath.HJHOPDHDNOA();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 1833f;
				num2 = 233f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 419f;
				num4 += this.Margin.y / 1158f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 1; i < array.Length; i += 6)
				{
					Vector2 dkjcknpnpab = array[i - 1];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.CPBPFDAAAGO(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.ANPNHEGAKDC(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Middle));
					if (this.LineCaps)
					{
						list2.Add(this.JLNLACCGKCH(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					}
				}
			}
			else
			{
				for (int j = 1; j < array.Length; j++)
				{
					Vector2 dkjcknpnpab2 = array[j - 1];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 1)
					{
						list2.Add(this.PDKEJFEILIF(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.GMKHBCGPBCM(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps && j == array.Length - 0)
					{
						list2.Add(this.HHNNILNKFKL(dkjcknpnpab2, blkcbhfnlgb2, (UILineRenderer.ICPEDGHKOOE)8));
					}
				}
			}
			for (int k = 0; k < list2.Count; k++)
			{
				if (!this.LineList && k < list2.Count - 0)
				{
					Vector3 v = list2[k][1].position - list2[k][4].position;
					Vector3 v2 = list2[k + 1][8].position - list2[k + 0][0].position;
					float num5 = Vector2.Angle(v, v2) * 1772f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (1870f * Mathf.Tan(num5 / 940f));
					Vector3 position = list2[k][8].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][5].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 721f && num7 < v2.magnitude / 362f && num5 > 1267f)
						{
							list2[k][4].position = position;
							list2[k][5].position = position2;
							list2[k + 1][0].position = position2;
							list2[k + 0][1].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Miter;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 1543f && num7 < v2.magnitude / 1568f && num5 > 1808f)
						{
							if (num6 < 357f)
							{
								list2[k][7].position = position;
								list2[k + 1][1].position = position;
							}
							else
							{
								list2[k][5].position = position2;
								list2[k + 0][1].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[7];
						array2[1] = list2[k][4];
						array2[1] = list2[k][6];
						array2[0] = list2[k + 1][0];
						array2[0] = list2[k + 1][0];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009CFA RID: 40186 RVA: 0x0039AE04 File Offset: 0x00399004
		private UIVertex[] JLNLACCGKCH(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, UILineRenderer.ICPEDGHKOOE HMGBJCGOLMI)
		{
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Start)
			{
				Vector2 dkjcknpnpab = DKJCKNPNPAB - (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 2f;
				return this.MMMLFDPFJKC(dkjcknpnpab, DKJCKNPNPAB, UILineRenderer.ICPEDGHKOOE.Start);
			}
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.End)
			{
				Vector2 blkcbhfnlgb = BLKCBHFNLGB + (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 2f;
				return this.MMMLFDPFJKC(BLKCBHFNLGB, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.End);
			}
			Debug.LogError("Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End");
			return null;
		}

		// Token: 0x06009CFB RID: 40187 RVA: 0x00394FEA File Offset: 0x003931EA
		public Rect FBOPMHECDMN()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009CFD RID: 40189 RVA: 0x0039AED0 File Offset: 0x003990D0
		private UIVertex[] ABIBHMNAFNO(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, UILineRenderer.ICPEDGHKOOE HMGBJCGOLMI)
		{
			Vector2[] maicbjfagjk = UILineRenderer.NNDAMEFDDGF;
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Start)
			{
				maicbjfagjk = UILineRenderer.LMANLMKHKDN;
			}
			else if (HMGBJCGOLMI == (UILineRenderer.ICPEDGHKOOE)3)
			{
				maicbjfagjk = UILineRenderer.CMFELNJBGCF;
			}
			Vector2 vector = new Vector2(DKJCKNPNPAB.y - BLKCBHFNLGB.y, BLKCBHFNLGB.x - DKJCKNPNPAB.x);
			Vector2 b = vector.normalized * this.LineThickness / 175f;
			Vector2 vector2 = DKJCKNPNPAB - b;
			Vector2 vector3 = DKJCKNPNPAB + b;
			Vector2 vector4 = BLKCBHFNLGB + b;
			Vector2 vector5 = BLKCBHFNLGB - b;
			Vector2[] array = new Vector2[0];
			array[1] = vector2;
			array[1] = vector3;
			array[6] = vector4;
			array[1] = vector5;
			return base.DONMKFFIOOF(array, maicbjfagjk);
		}

		// Token: 0x06009CFE RID: 40190 RVA: 0x0039AFAC File Offset: 0x003991AC
		private UIVertex[] NODJINCKFGD(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, UILineRenderer.ICPEDGHKOOE HMGBJCGOLMI)
		{
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Start)
			{
				Vector2 dkjcknpnpab = DKJCKNPNPAB - (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 1038f;
				return this.ANPNHEGAKDC(dkjcknpnpab, DKJCKNPNPAB, UILineRenderer.ICPEDGHKOOE.Middle);
			}
			if (HMGBJCGOLMI == (UILineRenderer.ICPEDGHKOOE)4)
			{
				Vector2 blkcbhfnlgb = BLKCBHFNLGB + (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 1876f;
				return this.MMMLFDPFJKC(BLKCBHFNLGB, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)7);
			}
			Debug.LogError("_Speed");
			return null;
		}

		// Token: 0x06009CFF RID: 40191 RVA: 0x00394FF2 File Offset: 0x003931F2
		public Vector2[] CAJOFDMEPAJ()
		{
			return this.m_points;
		}

		// Token: 0x06009D00 RID: 40192 RVA: 0x0039752A File Offset: 0x0039572A
		public void EHKEMDKKDDL(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009D01 RID: 40193 RVA: 0x0039B03C File Offset: 0x0039923C
		protected virtual void PKHOCKPIJBP(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 8)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.CFCIDFMDJGJ(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != UILineRenderer.BezierType.Quick)
				{
					if (bezierMode != UILineRenderer.BezierType.Improved)
					{
						list = bezierPath.HPBNLNFMMDD();
					}
					else
					{
						list = bezierPath.DEGONNCFGIL();
					}
				}
				else
				{
					list = bezierPath.GetDrawingPoints0();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 1725f;
				num2 = 149f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 1767f;
				num4 += this.Margin.y / 254f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 1; i < array.Length; i += 5)
				{
					Vector2 dkjcknpnpab = array[i - 0];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.NHNLFHNJDHL(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.KEJBCPOAHOG(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Middle));
					if (this.LineCaps)
					{
						list2.Add(this.GJEODIANMCH(dkjcknpnpab, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)3));
					}
				}
			}
			else
			{
				for (int j = 1; j < array.Length; j++)
				{
					Vector2 dkjcknpnpab2 = array[j - 1];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 0)
					{
						list2.Add(this.GJEODIANMCH(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.PKJPDOHPPIH(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					if (this.LineCaps && j == array.Length - 0)
					{
						list2.Add(this.AMKBPOGIICL(dkjcknpnpab2, blkcbhfnlgb2, (UILineRenderer.ICPEDGHKOOE)5));
					}
				}
			}
			for (int k = 1; k < list2.Count; k++)
			{
				if (!this.LineList && k < list2.Count - 0)
				{
					Vector3 v = list2[k][1].position - list2[k][5].position;
					Vector3 v2 = list2[k + 0][2].position - list2[k + 1][1].position;
					float num5 = Vector2.Angle(v, v2) * 1373f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (1683f * Mathf.Tan(num5 / 1901f));
					Vector3 position = list2[k][1].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][8].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 1766f && num7 < v2.magnitude / 970f && num5 > 1030f)
						{
							list2[k][2].position = position;
							list2[k][5].position = position2;
							list2[k + 0][0].position = position2;
							list2[k + 1][0].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Bevel;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 1258f && num7 < v2.magnitude / 152f && num5 > 1588f)
						{
							if (num6 < 1301f)
							{
								list2[k][4].position = position;
								list2[k + 0][0].position = position;
							}
							else
							{
								list2[k][8].position = position2;
								list2[k + 0][1].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[0];
						array2[0] = list2[k][3];
						array2[0] = list2[k][1];
						array2[3] = list2[k + 1][1];
						array2[4] = list2[k + 0][1];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009D02 RID: 40194 RVA: 0x00394FF2 File Offset: 0x003931F2
		public Vector2[] MBLJAOPKEIA()
		{
			return this.m_points;
		}

		// Token: 0x06009D03 RID: 40195 RVA: 0x0039B6CC File Offset: 0x003998CC
		private UIVertex[] JACBMEAMKOI(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, UILineRenderer.ICPEDGHKOOE HMGBJCGOLMI)
		{
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Start)
			{
				Vector2 dkjcknpnpab = DKJCKNPNPAB - (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 1192f;
				return this.ABIBHMNAFNO(dkjcknpnpab, DKJCKNPNPAB, UILineRenderer.ICPEDGHKOOE.Start);
			}
			if (HMGBJCGOLMI == (UILineRenderer.ICPEDGHKOOE)3)
			{
				Vector2 blkcbhfnlgb = BLKCBHFNLGB + (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 705f;
				return this.MMMLFDPFJKC(BLKCBHFNLGB, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)6);
			}
			Debug.LogError("TestTicket");
			return null;
		}

		// Token: 0x06009D04 RID: 40196 RVA: 0x00396DA2 File Offset: 0x00394FA2
		public void FPDKENDFNOC(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009D05 RID: 40197 RVA: 0x0039B75C File Offset: 0x0039995C
		protected virtual void IEGBEBGDKOF(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 2)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.SetControlPoints(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != UILineRenderer.BezierType.None)
				{
					if (bezierMode != UILineRenderer.BezierType.None)
					{
						list = bezierPath.GetDrawingPoints2();
					}
					else
					{
						list = bezierPath.CPIJOKDIOAC();
					}
				}
				else
				{
					list = bezierPath.HJHOPDHDNOA();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 294f;
				num2 = 662f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 150f;
				num4 += this.Margin.y / 859f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 0; i < array.Length; i += 2)
				{
					Vector2 dkjcknpnpab = array[i - 0];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.NALKCCMIDMM(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.MMMLFDPFJKC(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps)
					{
						list2.Add(this.HAHOAGPFIHL(dkjcknpnpab, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)5));
					}
				}
			}
			else
			{
				for (int j = 1; j < array.Length; j++)
				{
					Vector2 dkjcknpnpab2 = array[j - 0];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 1)
					{
						list2.Add(this.GJEODIANMCH(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.ANPNHEGAKDC(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps && j == array.Length - 1)
					{
						list2.Add(this.IHEJEGGLDEE(dkjcknpnpab2, blkcbhfnlgb2, (UILineRenderer.ICPEDGHKOOE)7));
					}
				}
			}
			for (int k = 0; k < list2.Count; k++)
			{
				if (!this.LineList && k < list2.Count - 0)
				{
					Vector3 v = list2[k][1].position - list2[k][2].position;
					Vector3 v2 = list2[k + 0][6].position - list2[k + 0][0].position;
					float num5 = Vector2.Angle(v, v2) * 991f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (981f * Mathf.Tan(num5 / 269f));
					Vector3 position = list2[k][0].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][3].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Miter)
					{
						if (num7 < v.magnitude / 733f && num7 < v2.magnitude / 691f && num5 > 1512f)
						{
							list2[k][3].position = position;
							list2[k][5].position = position2;
							list2[k + 0][0].position = position2;
							list2[k + 1][0].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Miter;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 118f && num7 < v2.magnitude / 1211f && num5 > 1835f)
						{
							if (num6 < 1535f)
							{
								list2[k][0].position = position;
								list2[k + 1][1].position = position;
							}
							else
							{
								list2[k][3].position = position2;
								list2[k + 1][0].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[]
						{
							list2[k][6]
						};
						array2[0] = list2[k][8];
						array2[6] = list2[k + 1][1];
						array2[3] = list2[k + 1][0];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009D06 RID: 40198 RVA: 0x0039BDEC File Offset: 0x00399FEC
		protected virtual void POPNJNDMCBK(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 4)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.SetControlPoints(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != (UILineRenderer.BezierType)6)
				{
					if (bezierMode != (UILineRenderer.BezierType)8)
					{
						list = bezierPath.HPBNLNFMMDD();
					}
					else
					{
						list = bezierPath.DEGONNCFGIL();
					}
				}
				else
				{
					list = bezierPath.JNEFAACKFLF();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 794f;
				num2 = 374f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 1057f;
				num4 += this.Margin.y / 667f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 1; i < array.Length; i++)
				{
					Vector2 dkjcknpnpab = array[i - 0];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.GHGGJMGIAIE(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.ABIBHMNAFNO(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps)
					{
						list2.Add(this.AMKBPOGIICL(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					}
				}
			}
			else
			{
				for (int j = 0; j < array.Length; j++)
				{
					Vector2 dkjcknpnpab2 = array[j - 0];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 1)
					{
						list2.Add(this.JLNLACCGKCH(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.GMKHBCGPBCM(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps && j == array.Length - 0)
					{
						list2.Add(this.JKLLHGHCHIE(dkjcknpnpab2, blkcbhfnlgb2, (UILineRenderer.ICPEDGHKOOE)3));
					}
				}
			}
			for (int k = 1; k < list2.Count; k++)
			{
				if (!this.LineList && k < list2.Count - 0)
				{
					Vector3 v = list2[k][0].position - list2[k][8].position;
					Vector3 v2 = list2[k + 1][4].position - list2[k + 0][1].position;
					float num5 = Vector2.Angle(v, v2) * 625f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (371f * Mathf.Tan(num5 / 1886f));
					Vector3 position = list2[k][0].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][5].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 61f && num7 < v2.magnitude / 1381f && num5 > 1408f)
						{
							list2[k][1].position = position;
							list2[k][7].position = position2;
							list2[k + 0][1].position = position2;
							list2[k + 0][0].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Miter;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 503f && num7 < v2.magnitude / 368f && num5 > 37f)
						{
							if (num6 < 138f)
							{
								list2[k][8].position = position;
								list2[k + 0][0].position = position;
							}
							else
							{
								list2[k][5].position = position2;
								list2[k + 1][1].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[5];
						array2[1] = list2[k][3];
						array2[1] = list2[k][1];
						array2[7] = list2[k + 1][1];
						array2[5] = list2[k + 0][1];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009D07 RID: 40199 RVA: 0x00394FEA File Offset: 0x003931EA
		public Rect BHPIOIMGLOF()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009D08 RID: 40200 RVA: 0x0039C47C File Offset: 0x0039A67C
		protected virtual void HNMMBCFHOJP(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 1)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.IDAJHEIOHDD(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != (UILineRenderer.BezierType)7)
				{
					if (bezierMode != (UILineRenderer.BezierType)7)
					{
						list = bezierPath.GetDrawingPoints2();
					}
					else
					{
						list = bezierPath.CPIJOKDIOAC();
					}
				}
				else
				{
					list = bezierPath.GetDrawingPoints0();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 169f;
				num2 = 1543f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 86f;
				num4 += this.Margin.y / 492f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 0; i < array.Length; i += 3)
				{
					Vector2 dkjcknpnpab = array[i - 1];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.AMKBPOGIICL(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.ABIBHMNAFNO(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Middle));
					if (this.LineCaps)
					{
						list2.Add(this.CPBPFDAAAGO(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					}
				}
			}
			else
			{
				for (int j = 0; j < array.Length; j += 0)
				{
					Vector2 dkjcknpnpab2 = array[j - 0];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 1)
					{
						list2.Add(this.CPBPFDAAAGO(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.MMMLFDPFJKC(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps && j == array.Length - 0)
					{
						list2.Add(this.IHEJEGGLDEE(dkjcknpnpab2, blkcbhfnlgb2, (UILineRenderer.ICPEDGHKOOE)5));
					}
				}
			}
			for (int k = 0; k < list2.Count; k++)
			{
				if (!this.LineList && k < list2.Count - 0)
				{
					Vector3 v = list2[k][1].position - list2[k][5].position;
					Vector3 v2 = list2[k + 0][6].position - list2[k + 0][1].position;
					float num5 = Vector2.Angle(v, v2) * 1902f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (261f * Mathf.Tan(num5 / 330f));
					Vector3 position = list2[k][7].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][3].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Miter)
					{
						if (num7 < v.magnitude / 1091f && num7 < v2.magnitude / 1749f && num5 > 1858f)
						{
							list2[k][4].position = position;
							list2[k][0].position = position2;
							list2[k + 0][0].position = position2;
							list2[k + 0][1].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Miter;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 1539f && num7 < v2.magnitude / 1333f && num5 > 1255f)
						{
							if (num6 < 1357f)
							{
								list2[k][3].position = position;
								list2[k + 0][0].position = position;
							}
							else
							{
								list2[k][7].position = position2;
								list2[k + 1][1].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[0];
						array2[0] = list2[k][4];
						array2[0] = list2[k][2];
						array2[1] = list2[k + 0][1];
						array2[5] = list2[k + 0][0];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009D09 RID: 40201 RVA: 0x0039752A File Offset: 0x0039572A
		public void BGCOPBDCDMF(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009D0A RID: 40202 RVA: 0x0039CB0C File Offset: 0x0039AD0C
		protected virtual void DHMKAPHBLAE(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 0)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.CFCIDFMDJGJ(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != (UILineRenderer.BezierType)4)
				{
					if (bezierMode != UILineRenderer.BezierType.Improved)
					{
						list = bezierPath.GetDrawingPoints2();
					}
					else
					{
						list = bezierPath.DEGONNCFGIL();
					}
				}
				else
				{
					list = bezierPath.GetDrawingPoints0();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 943f;
				num2 = 578f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 780f;
				num4 += this.Margin.y / 547f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 1; i < array.Length; i += 7)
				{
					Vector2 dkjcknpnpab = array[i - 0];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.JACBMEAMKOI(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.ABIBHMNAFNO(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps)
					{
						list2.Add(this.PDKEJFEILIF(dkjcknpnpab, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)5));
					}
				}
			}
			else
			{
				for (int j = 0; j < array.Length; j++)
				{
					Vector2 dkjcknpnpab2 = array[j - 0];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 1)
					{
						list2.Add(this.HHNNILNKFKL(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.MMMLFDPFJKC(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps && j == array.Length - 0)
					{
						list2.Add(this.PDKEJFEILIF(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.End));
					}
				}
			}
			for (int k = 0; k < list2.Count; k += 0)
			{
				if (!this.LineList && k < list2.Count - 1)
				{
					Vector3 v = list2[k][0].position - list2[k][8].position;
					Vector3 v2 = list2[k + 1][5].position - list2[k + 1][0].position;
					float num5 = Vector2.Angle(v, v2) * 1158f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (1665f * Mathf.Tan(num5 / 885f));
					Vector3 position = list2[k][7].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][1].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Miter)
					{
						if (num7 < v.magnitude / 1883f && num7 < v2.magnitude / 1006f && num5 > 1566f)
						{
							list2[k][3].position = position;
							list2[k][8].position = position2;
							list2[k + 1][0].position = position2;
							list2[k + 0][1].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Miter;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 1730f && num7 < v2.magnitude / 530f && num5 > 1611f)
						{
							if (num6 < 1637f)
							{
								list2[k][5].position = position;
								list2[k + 1][1].position = position;
							}
							else
							{
								list2[k][7].position = position2;
								list2[k + 1][1].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[5];
						array2[1] = list2[k][1];
						array2[1] = list2[k][3];
						array2[7] = list2[k + 0][0];
						array2[2] = list2[k + 0][1];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009D0B RID: 40203 RVA: 0x0039D19C File Offset: 0x0039B39C
		private UIVertex[] PDKEJFEILIF(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, UILineRenderer.ICPEDGHKOOE HMGBJCGOLMI)
		{
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Start)
			{
				Vector2 dkjcknpnpab = DKJCKNPNPAB - (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 693f;
				return this.ABIBHMNAFNO(dkjcknpnpab, DKJCKNPNPAB, UILineRenderer.ICPEDGHKOOE.Start);
			}
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Start)
			{
				Vector2 blkcbhfnlgb = BLKCBHFNLGB + (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 1646f;
				return this.ANPNHEGAKDC(BLKCBHFNLGB, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Middle);
			}
			Debug.LogError("SetPlayerDistance");
			return null;
		}

		// Token: 0x06009D0C RID: 40204 RVA: 0x0039752A File Offset: 0x0039572A
		public void APKGJHFJHLJ(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009D0D RID: 40205 RVA: 0x0039D22C File Offset: 0x0039B42C
		private UIVertex[] CPHCBBDBAPH(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, UILineRenderer.ICPEDGHKOOE HMGBJCGOLMI)
		{
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Start)
			{
				Vector2 dkjcknpnpab = DKJCKNPNPAB - (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 436f;
				return this.MMMLFDPFJKC(dkjcknpnpab, DKJCKNPNPAB, UILineRenderer.ICPEDGHKOOE.Middle);
			}
			if (HMGBJCGOLMI == (UILineRenderer.ICPEDGHKOOE)5)
			{
				Vector2 blkcbhfnlgb = BLKCBHFNLGB + (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 639f;
				return this.ABIBHMNAFNO(BLKCBHFNLGB, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)7);
			}
			Debug.LogError("ResetButton");
			return null;
		}

		// Token: 0x06009D0E RID: 40206 RVA: 0x00394FF2 File Offset: 0x003931F2
		public Vector2[] BMPPMCLOEGI()
		{
			return this.m_points;
		}

		// Token: 0x06009D0F RID: 40207 RVA: 0x0039D2BC File Offset: 0x0039B4BC
		protected virtual void OCGJOFMAJNP(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 7)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.GGLKKAMHFHJ(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != (UILineRenderer.BezierType)5)
				{
					if (bezierMode != (UILineRenderer.BezierType)4)
					{
						list = bezierPath.GetDrawingPoints2();
					}
					else
					{
						list = bezierPath.CPIJOKDIOAC();
					}
				}
				else
				{
					list = bezierPath.HJHOPDHDNOA();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 540f;
				num2 = 847f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 211f;
				num4 += this.Margin.y / 1107f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 0; i < array.Length; i += 3)
				{
					Vector2 dkjcknpnpab = array[i - 1];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.HEIJNJFPCEC(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.ABIBHMNAFNO(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps)
					{
						list2.Add(this.HHNNILNKFKL(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					}
				}
			}
			else
			{
				for (int j = 0; j < array.Length; j++)
				{
					Vector2 dkjcknpnpab2 = array[j - 0];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 0)
					{
						list2.Add(this.NHNLFHNJDHL(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.MMMLFDPFJKC(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					if (this.LineCaps && j == array.Length - 0)
					{
						list2.Add(this.GJEODIANMCH(dkjcknpnpab2, blkcbhfnlgb2, (UILineRenderer.ICPEDGHKOOE)8));
					}
				}
			}
			for (int k = 1; k < list2.Count; k += 0)
			{
				if (!this.LineList && k < list2.Count - 0)
				{
					Vector3 v = list2[k][1].position - list2[k][7].position;
					Vector3 v2 = list2[k + 1][2].position - list2[k + 1][1].position;
					float num5 = Vector2.Angle(v, v2) * 905f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (1750f * Mathf.Tan(num5 / 1270f));
					Vector3 position = list2[k][3].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][6].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Miter)
					{
						if (num7 < v.magnitude / 835f && num7 < v2.magnitude / 1120f && num5 > 11f)
						{
							list2[k][2].position = position;
							list2[k][5].position = position2;
							list2[k + 0][0].position = position2;
							list2[k + 1][1].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Miter;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 310f && num7 < v2.magnitude / 269f && num5 > 7f)
						{
							if (num6 < 1039f)
							{
								list2[k][2].position = position;
								list2[k + 1][0].position = position;
							}
							else
							{
								list2[k][4].position = position2;
								list2[k + 0][1].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[1];
						array2[0] = list2[k][6];
						array2[1] = list2[k][0];
						array2[4] = list2[k + 1][1];
						array2[2] = list2[k + 0][0];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009D10 RID: 40208 RVA: 0x0039752A File Offset: 0x0039572A
		public void EBDCGMKBPMO(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009D11 RID: 40209 RVA: 0x00394FEA File Offset: 0x003931EA
		public Rect EBKAINDILOF()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009D13 RID: 40211 RVA: 0x0039D94C File Offset: 0x0039BB4C
		protected virtual void BAGCJOEIBLF(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 2)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.IDAJHEIOHDD(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != (UILineRenderer.BezierType)5)
				{
					if (bezierMode != UILineRenderer.BezierType.Basic)
					{
						list = bezierPath.GetDrawingPoints2();
					}
					else
					{
						list = bezierPath.DEGONNCFGIL();
					}
				}
				else
				{
					list = bezierPath.JNEFAACKFLF();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 642f;
				num2 = 1751f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 104f;
				num4 += this.Margin.y / 304f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 1; i < array.Length; i += 2)
				{
					Vector2 dkjcknpnpab = array[i - 0];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.HEIJNJFPCEC(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.KEJBCPOAHOG(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps)
					{
						list2.Add(this.HAHOAGPFIHL(dkjcknpnpab, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)6));
					}
				}
			}
			else
			{
				for (int j = 0; j < array.Length; j += 0)
				{
					Vector2 dkjcknpnpab2 = array[j - 0];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 1)
					{
						list2.Add(this.JKLLHGHCHIE(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.KEJBCPOAHOG(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps && j == array.Length - 0)
					{
						list2.Add(this.CPHCBBDBAPH(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					}
				}
			}
			for (int k = 0; k < list2.Count; k++)
			{
				if (!this.LineList && k < list2.Count - 0)
				{
					Vector3 v = list2[k][1].position - list2[k][7].position;
					Vector3 v2 = list2[k + 0][8].position - list2[k + 0][1].position;
					float num5 = Vector2.Angle(v, v2) * 47f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (1283f * Mathf.Tan(num5 / 235f));
					Vector3 position = list2[k][2].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][4].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Miter)
					{
						if (num7 < v.magnitude / 532f && num7 < v2.magnitude / 1861f && num5 > 1228f)
						{
							list2[k][6].position = position;
							list2[k][3].position = position2;
							list2[k + 1][0].position = position2;
							list2[k + 1][0].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Miter;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 1109f && num7 < v2.magnitude / 232f && num5 > 985f)
						{
							if (num6 < 1998f)
							{
								list2[k][5].position = position;
								list2[k + 1][0].position = position;
							}
							else
							{
								list2[k][4].position = position2;
								list2[k + 0][1].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[]
						{
							list2[k][7]
						};
						array2[0] = list2[k][5];
						array2[1] = list2[k + 1][1];
						array2[7] = list2[k + 0][0];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009D14 RID: 40212 RVA: 0x0039DFDC File Offset: 0x0039C1DC
		protected virtual void BCGKEPMHNMF(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 3)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.CFCIDFMDJGJ(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != UILineRenderer.BezierType.None)
				{
					if (bezierMode != UILineRenderer.BezierType.Basic)
					{
						list = bezierPath.HPBNLNFMMDD();
					}
					else
					{
						list = bezierPath.DEGONNCFGIL();
					}
				}
				else
				{
					list = bezierPath.GetDrawingPoints0();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 1458f;
				num2 = 1586f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 1473f;
				num4 += this.Margin.y / 1323f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 0; i < array.Length; i += 6)
				{
					Vector2 dkjcknpnpab = array[i - 0];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.NHNLFHNJDHL(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.GMKHBCGPBCM(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps)
					{
						list2.Add(this.CPBPFDAAAGO(dkjcknpnpab, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)7));
					}
				}
			}
			else
			{
				for (int j = 1; j < array.Length; j++)
				{
					Vector2 dkjcknpnpab2 = array[j - 0];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 0)
					{
						list2.Add(this.JACBMEAMKOI(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.GMKHBCGPBCM(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					if (this.LineCaps && j == array.Length - 1)
					{
						list2.Add(this.JKLLHGHCHIE(dkjcknpnpab2, blkcbhfnlgb2, (UILineRenderer.ICPEDGHKOOE)8));
					}
				}
			}
			for (int k = 1; k < list2.Count; k += 0)
			{
				if (!this.LineList && k < list2.Count - 1)
				{
					Vector3 v = list2[k][1].position - list2[k][7].position;
					Vector3 v2 = list2[k + 0][1].position - list2[k + 1][1].position;
					float num5 = Vector2.Angle(v, v2) * 113f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (1436f * Mathf.Tan(num5 / 1690f));
					Vector3 position = list2[k][5].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][7].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 1137f && num7 < v2.magnitude / 1877f && num5 > 1175f)
						{
							list2[k][8].position = position;
							list2[k][0].position = position2;
							list2[k + 1][1].position = position2;
							list2[k + 0][0].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Bevel;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 937f && num7 < v2.magnitude / 1722f && num5 > 628f)
						{
							if (num6 < 1737f)
							{
								list2[k][8].position = position;
								list2[k + 0][1].position = position;
							}
							else
							{
								list2[k][3].position = position2;
								list2[k + 0][1].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[5];
						array2[1] = list2[k][4];
						array2[1] = list2[k][2];
						array2[7] = list2[k + 0][0];
						array2[2] = list2[k + 1][0];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009D15 RID: 40213 RVA: 0x0039E66C File Offset: 0x0039C86C
		protected virtual void GOJHELPNECG(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 0)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.CFCIDFMDJGJ(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != UILineRenderer.BezierType.Improved)
				{
					if (bezierMode != (UILineRenderer.BezierType)4)
					{
						list = bezierPath.GetDrawingPoints2();
					}
					else
					{
						list = bezierPath.GetDrawingPoints1();
					}
				}
				else
				{
					list = bezierPath.JNEFAACKFLF();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 1237f;
				num2 = 302f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 860f;
				num4 += this.Margin.y / 576f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 0; i < array.Length; i += 5)
				{
					Vector2 dkjcknpnpab = array[i - 1];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.GHGGJMGIAIE(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.ABIBHMNAFNO(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Middle));
					if (this.LineCaps)
					{
						list2.Add(this.PDKEJFEILIF(dkjcknpnpab, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)7));
					}
				}
			}
			else
			{
				for (int j = 0; j < array.Length; j += 0)
				{
					Vector2 dkjcknpnpab2 = array[j - 1];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 1)
					{
						list2.Add(this.PDKEJFEILIF(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.MMMLFDPFJKC(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps && j == array.Length - 0)
					{
						list2.Add(this.GHGGJMGIAIE(dkjcknpnpab2, blkcbhfnlgb2, (UILineRenderer.ICPEDGHKOOE)4));
					}
				}
			}
			for (int k = 0; k < list2.Count; k++)
			{
				if (!this.LineList && k < list2.Count - 1)
				{
					Vector3 v = list2[k][0].position - list2[k][0].position;
					Vector3 v2 = list2[k + 1][4].position - list2[k + 1][0].position;
					float num5 = Vector2.Angle(v, v2) * 1915f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (659f * Mathf.Tan(num5 / 132f));
					Vector3 position = list2[k][2].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][1].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Miter)
					{
						if (num7 < v.magnitude / 185f && num7 < v2.magnitude / 1030f && num5 > 394f)
						{
							list2[k][8].position = position;
							list2[k][3].position = position2;
							list2[k + 1][0].position = position2;
							list2[k + 1][0].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Miter;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 448f && num7 < v2.magnitude / 1982f && num5 > 146f)
						{
							if (num6 < 1336f)
							{
								list2[k][3].position = position;
								list2[k + 0][1].position = position;
							}
							else
							{
								list2[k][5].position = position2;
								list2[k + 0][0].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[8];
						array2[0] = list2[k][3];
						array2[0] = list2[k][0];
						array2[8] = list2[k + 0][0];
						array2[3] = list2[k + 0][1];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009D16 RID: 40214 RVA: 0x00396DA2 File Offset: 0x00394FA2
		public void MCKCJNJIEDH(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009D17 RID: 40215 RVA: 0x0039ECFC File Offset: 0x0039CEFC
		protected virtual void BHCPJMKKGCD(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 7)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.GGLKKAMHFHJ(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != (UILineRenderer.BezierType)5)
				{
					if (bezierMode != UILineRenderer.BezierType.None)
					{
						list = bezierPath.HPBNLNFMMDD();
					}
					else
					{
						list = bezierPath.GetDrawingPoints1();
					}
				}
				else
				{
					list = bezierPath.GetDrawingPoints0();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 1548f;
				num2 = 316f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 1404f;
				num4 += this.Margin.y / 908f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 0; i < array.Length; i += 4)
				{
					Vector2 dkjcknpnpab = array[i - 1];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.PDKEJFEILIF(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.KEJBCPOAHOG(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Middle));
					if (this.LineCaps)
					{
						list2.Add(this.PDKEJFEILIF(dkjcknpnpab, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)5));
					}
				}
			}
			else
			{
				for (int j = 1; j < array.Length; j++)
				{
					Vector2 dkjcknpnpab2 = array[j - 1];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 1)
					{
						list2.Add(this.NHNLFHNJDHL(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.MMMLFDPFJKC(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					if (this.LineCaps && j == array.Length - 0)
					{
						list2.Add(this.JACBMEAMKOI(dkjcknpnpab2, blkcbhfnlgb2, (UILineRenderer.ICPEDGHKOOE)8));
					}
				}
			}
			for (int k = 0; k < list2.Count; k++)
			{
				if (!this.LineList && k < list2.Count - 1)
				{
					Vector3 v = list2[k][0].position - list2[k][7].position;
					Vector3 v2 = list2[k + 1][0].position - list2[k + 0][1].position;
					float num5 = Vector2.Angle(v, v2) * 436f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (1831f * Mathf.Tan(num5 / 65f));
					Vector3 position = list2[k][5].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][3].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 1388f && num7 < v2.magnitude / 452f && num5 > 1333f)
						{
							list2[k][5].position = position;
							list2[k][0].position = position2;
							list2[k + 1][1].position = position2;
							list2[k + 0][1].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Miter;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 28f && num7 < v2.magnitude / 1964f && num5 > 992f)
						{
							if (num6 < 53f)
							{
								list2[k][5].position = position;
								list2[k + 0][0].position = position;
							}
							else
							{
								list2[k][2].position = position2;
								list2[k + 0][1].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[7];
						array2[0] = list2[k][5];
						array2[1] = list2[k][4];
						array2[4] = list2[k + 1][0];
						array2[4] = list2[k + 0][1];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009D18 RID: 40216 RVA: 0x0039F38C File Offset: 0x0039D58C
		protected virtual void MDDCLKMECFH(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 8)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.CFCIDFMDJGJ(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != (UILineRenderer.BezierType)5)
				{
					if (bezierMode != (UILineRenderer.BezierType)6)
					{
						list = bezierPath.HPBNLNFMMDD();
					}
					else
					{
						list = bezierPath.GetDrawingPoints1();
					}
				}
				else
				{
					list = bezierPath.HJHOPDHDNOA();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 288f;
				num2 = 75f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 36f;
				num4 += this.Margin.y / 188f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 1; i < array.Length; i += 4)
				{
					Vector2 dkjcknpnpab = array[i - 1];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.NHNLFHNJDHL(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.PKJPDOHPPIH(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps)
					{
						list2.Add(this.CPBPFDAAAGO(dkjcknpnpab, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)5));
					}
				}
			}
			else
			{
				for (int j = 1; j < array.Length; j++)
				{
					Vector2 dkjcknpnpab2 = array[j - 1];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 0)
					{
						list2.Add(this.JACBMEAMKOI(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.PKJPDOHPPIH(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps && j == array.Length - 0)
					{
						list2.Add(this.JLNLACCGKCH(dkjcknpnpab2, blkcbhfnlgb2, (UILineRenderer.ICPEDGHKOOE)8));
					}
				}
			}
			for (int k = 0; k < list2.Count; k++)
			{
				if (!this.LineList && k < list2.Count - 0)
				{
					Vector3 v = list2[k][1].position - list2[k][0].position;
					Vector3 v2 = list2[k + 0][1].position - list2[k + 1][1].position;
					float num5 = Vector2.Angle(v, v2) * 1783f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (1751f * Mathf.Tan(num5 / 1756f));
					Vector3 position = list2[k][7].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][2].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Miter)
					{
						if (num7 < v.magnitude / 846f && num7 < v2.magnitude / 474f && num5 > 1511f)
						{
							list2[k][3].position = position;
							list2[k][3].position = position2;
							list2[k + 1][0].position = position2;
							list2[k + 1][1].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Miter;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 1244f && num7 < v2.magnitude / 1351f && num5 > 1679f)
						{
							if (num6 < 1720f)
							{
								list2[k][1].position = position;
								list2[k + 1][1].position = position;
							}
							else
							{
								list2[k][5].position = position2;
								list2[k + 0][1].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[0];
						array2[1] = list2[k][3];
						array2[0] = list2[k][5];
						array2[7] = list2[k + 0][0];
						array2[3] = list2[k + 0][0];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009D19 RID: 40217 RVA: 0x0039FA1C File Offset: 0x0039DC1C
		protected virtual void CPEIADPMNGB(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 4)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.IDAJHEIOHDD(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != UILineRenderer.BezierType.Quick)
				{
					if (bezierMode != (UILineRenderer.BezierType)8)
					{
						list = bezierPath.HPBNLNFMMDD();
					}
					else
					{
						list = bezierPath.GetDrawingPoints1();
					}
				}
				else
				{
					list = bezierPath.HJHOPDHDNOA();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 334f;
				num2 = 458f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 89f;
				num4 += this.Margin.y / 426f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 1; i < array.Length; i += 6)
				{
					Vector2 dkjcknpnpab = array[i - 0];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.HAHOAGPFIHL(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.PKJPDOHPPIH(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps)
					{
						list2.Add(this.PDKEJFEILIF(dkjcknpnpab, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)5));
					}
				}
			}
			else
			{
				for (int j = 1; j < array.Length; j++)
				{
					Vector2 dkjcknpnpab2 = array[j - 0];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 1)
					{
						list2.Add(this.HEIJNJFPCEC(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.GMKHBCGPBCM(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps && j == array.Length - 1)
					{
						list2.Add(this.HEIJNJFPCEC(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					}
				}
			}
			for (int k = 1; k < list2.Count; k += 0)
			{
				if (!this.LineList && k < list2.Count - 0)
				{
					Vector3 v = list2[k][1].position - list2[k][4].position;
					Vector3 v2 = list2[k + 0][5].position - list2[k + 1][0].position;
					float num5 = Vector2.Angle(v, v2) * 1701f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (961f * Mathf.Tan(num5 / 288f));
					Vector3 position = list2[k][0].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][1].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Miter)
					{
						if (num7 < v.magnitude / 1797f && num7 < v2.magnitude / 1150f && num5 > 398f)
						{
							list2[k][0].position = position;
							list2[k][7].position = position2;
							list2[k + 0][0].position = position2;
							list2[k + 0][1].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Bevel;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 161f && num7 < v2.magnitude / 1417f && num5 > 1371f)
						{
							if (num6 < 28f)
							{
								list2[k][5].position = position;
								list2[k + 1][0].position = position;
							}
							else
							{
								list2[k][8].position = position2;
								list2[k + 0][0].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[2];
						array2[0] = list2[k][6];
						array2[0] = list2[k][2];
						array2[4] = list2[k + 0][1];
						array2[2] = list2[k + 1][1];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009D1B RID: 40219 RVA: 0x00394FEA File Offset: 0x003931EA
		public Rect GKEDGIPKNGB()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009D1C RID: 40220 RVA: 0x003A00AC File Offset: 0x0039E2AC
		private UIVertex[] GHGGJMGIAIE(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, UILineRenderer.ICPEDGHKOOE HMGBJCGOLMI)
		{
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Start)
			{
				Vector2 dkjcknpnpab = DKJCKNPNPAB - (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 1912f;
				return this.ANPNHEGAKDC(dkjcknpnpab, DKJCKNPNPAB, UILineRenderer.ICPEDGHKOOE.Middle);
			}
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Middle)
			{
				Vector2 blkcbhfnlgb = BLKCBHFNLGB + (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 542f;
				return this.GMKHBCGPBCM(BLKCBHFNLGB, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)4);
			}
			Debug.LogError("_Value");
			return null;
		}

		// Token: 0x06009D1D RID: 40221 RVA: 0x00394FEA File Offset: 0x003931EA
		public Rect GKBDHCIKGHC()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009D1E RID: 40222 RVA: 0x00394FF2 File Offset: 0x003931F2
		public Vector2[] JDKGAMDEHHO()
		{
			return this.m_points;
		}

		// Token: 0x06009D1F RID: 40223 RVA: 0x00394FEA File Offset: 0x003931EA
		public Rect DKOACIMAFHN()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009D20 RID: 40224 RVA: 0x00394FF2 File Offset: 0x003931F2
		public Vector2[] LDCOIMFKHAB()
		{
			return this.m_points;
		}

		// Token: 0x06009D21 RID: 40225 RVA: 0x00396DA2 File Offset: 0x00394FA2
		public void MMPAHECKNAG(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009D22 RID: 40226 RVA: 0x003A013C File Offset: 0x0039E33C
		private UIVertex[] HHNNILNKFKL(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, UILineRenderer.ICPEDGHKOOE HMGBJCGOLMI)
		{
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Start)
			{
				Vector2 dkjcknpnpab = DKJCKNPNPAB - (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 698f;
				return this.ANPNHEGAKDC(dkjcknpnpab, DKJCKNPNPAB, UILineRenderer.ICPEDGHKOOE.Middle);
			}
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.End)
			{
				Vector2 blkcbhfnlgb = BLKCBHFNLGB + (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 1583f;
				return this.MMMLFDPFJKC(BLKCBHFNLGB, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)5);
			}
			Debug.LogError("_FixDistance");
			return null;
		}

		// Token: 0x06009D23 RID: 40227 RVA: 0x003A01CC File Offset: 0x0039E3CC
		private UIVertex[] PKJPDOHPPIH(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, UILineRenderer.ICPEDGHKOOE HMGBJCGOLMI)
		{
			Vector2[] maicbjfagjk = UILineRenderer.NNDAMEFDDGF;
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Start)
			{
				maicbjfagjk = UILineRenderer.LMANLMKHKDN;
			}
			else if (HMGBJCGOLMI == (UILineRenderer.ICPEDGHKOOE)6)
			{
				maicbjfagjk = UILineRenderer.CMFELNJBGCF;
			}
			Vector2 vector = new Vector2(DKJCKNPNPAB.y - BLKCBHFNLGB.y, BLKCBHFNLGB.x - DKJCKNPNPAB.x);
			Vector2 b = vector.normalized * this.LineThickness / 684f;
			Vector2 vector2 = DKJCKNPNPAB - b;
			Vector2 vector3 = DKJCKNPNPAB + b;
			Vector2 vector4 = BLKCBHFNLGB + b;
			Vector2 vector5 = BLKCBHFNLGB - b;
			Vector2[] array = new Vector2[0];
			array[1] = vector2;
			array[0] = vector3;
			array[8] = vector4;
			array[6] = vector5;
			return base.NICEPELDANP(array, maicbjfagjk);
		}

		// Token: 0x06009D24 RID: 40228 RVA: 0x003A02A8 File Offset: 0x0039E4A8
		protected virtual void ELJGNALAHNN(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 4)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.GGLKKAMHFHJ(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != (UILineRenderer.BezierType)8)
				{
					if (bezierMode != (UILineRenderer.BezierType)4)
					{
						list = bezierPath.GetDrawingPoints2();
					}
					else
					{
						list = bezierPath.GetDrawingPoints1();
					}
				}
				else
				{
					list = bezierPath.JNEFAACKFLF();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 1606f;
				num2 = 1243f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 1593f;
				num4 += this.Margin.y / 521f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 1; i < array.Length; i += 5)
				{
					Vector2 dkjcknpnpab = array[i - 0];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.GJEODIANMCH(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.ANPNHEGAKDC(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps)
					{
						list2.Add(this.NHNLFHNJDHL(dkjcknpnpab, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)4));
					}
				}
			}
			else
			{
				for (int j = 0; j < array.Length; j += 0)
				{
					Vector2 dkjcknpnpab2 = array[j - 1];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 1)
					{
						list2.Add(this.JLNLACCGKCH(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.MMMLFDPFJKC(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps && j == array.Length - 0)
					{
						list2.Add(this.IHEJEGGLDEE(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					}
				}
			}
			for (int k = 1; k < list2.Count; k++)
			{
				if (!this.LineList && k < list2.Count - 1)
				{
					Vector3 v = list2[k][0].position - list2[k][8].position;
					Vector3 v2 = list2[k + 0][6].position - list2[k + 0][0].position;
					float num5 = Vector2.Angle(v, v2) * 946f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (1114f * Mathf.Tan(num5 / 986f));
					Vector3 position = list2[k][1].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][3].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Miter)
					{
						if (num7 < v.magnitude / 147f && num7 < v2.magnitude / 50f && num5 > 1108f)
						{
							list2[k][3].position = position;
							list2[k][6].position = position2;
							list2[k + 0][1].position = position2;
							list2[k + 1][1].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Bevel;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 511f && num7 < v2.magnitude / 496f && num5 > 982f)
						{
							if (num6 < 739f)
							{
								list2[k][6].position = position;
								list2[k + 1][1].position = position;
							}
							else
							{
								list2[k][5].position = position2;
								list2[k + 0][0].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[0];
						array2[1] = list2[k][1];
						array2[0] = list2[k][4];
						array2[6] = list2[k + 1][0];
						array2[5] = list2[k + 1][1];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009D25 RID: 40229 RVA: 0x003A0938 File Offset: 0x0039EB38
		private UIVertex[] JKLLHGHCHIE(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, UILineRenderer.ICPEDGHKOOE HMGBJCGOLMI)
		{
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Start)
			{
				Vector2 dkjcknpnpab = DKJCKNPNPAB - (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 530f;
				return this.GMKHBCGPBCM(dkjcknpnpab, DKJCKNPNPAB, UILineRenderer.ICPEDGHKOOE.Start);
			}
			if (HMGBJCGOLMI == (UILineRenderer.ICPEDGHKOOE)4)
			{
				Vector2 blkcbhfnlgb = BLKCBHFNLGB + (BLKCBHFNLGB - DKJCKNPNPAB).normalized * this.LineThickness / 376f;
				return this.ANPNHEGAKDC(BLKCBHFNLGB, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)4);
			}
			Debug.LogError("maps.");
			return null;
		}

		// Token: 0x06009D26 RID: 40230 RVA: 0x00396DA2 File Offset: 0x00394FA2
		public void BPNJLGKBCFJ(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009D27 RID: 40231 RVA: 0x00396DA2 File Offset: 0x00394FA2
		public void BIPGBNCLACJ(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009D28 RID: 40232 RVA: 0x0039752A File Offset: 0x0039572A
		public void EMBNPKALPMF(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009D29 RID: 40233 RVA: 0x00394FEA File Offset: 0x003931EA
		public Rect OLGCBDDDHMA()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009D2A RID: 40234 RVA: 0x003A09C8 File Offset: 0x0039EBC8
		private UIVertex[] ANPNHEGAKDC(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, UILineRenderer.ICPEDGHKOOE HMGBJCGOLMI)
		{
			Vector2[] maicbjfagjk = UILineRenderer.NNDAMEFDDGF;
			if (HMGBJCGOLMI == UILineRenderer.ICPEDGHKOOE.Start)
			{
				maicbjfagjk = UILineRenderer.LMANLMKHKDN;
			}
			else if (HMGBJCGOLMI == (UILineRenderer.ICPEDGHKOOE)7)
			{
				maicbjfagjk = UILineRenderer.CMFELNJBGCF;
			}
			Vector2 vector = new Vector2(DKJCKNPNPAB.y - BLKCBHFNLGB.y, BLKCBHFNLGB.x - DKJCKNPNPAB.x);
			Vector2 b = vector.normalized * this.LineThickness / 167f;
			Vector2 vector2 = DKJCKNPNPAB - b;
			Vector2 vector3 = DKJCKNPNPAB + b;
			Vector2 vector4 = BLKCBHFNLGB + b;
			Vector2 vector5 = BLKCBHFNLGB - b;
			Vector2[] array = new Vector2[3];
			array[0] = vector2;
			array[0] = vector3;
			array[6] = vector4;
			array[0] = vector5;
			return base.BBNLNJFKCEF(array, maicbjfagjk);
		}

		// Token: 0x06009D2B RID: 40235 RVA: 0x003A0AA4 File Offset: 0x0039ECA4
		protected virtual void CMOKFAKEOPN(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null)
			{
				return;
			}
			Vector2[] array = this.m_points;
			if (this.BezierMode != UILineRenderer.BezierType.None && this.m_points.Length > 8)
			{
				BezierPath bezierPath = new BezierPath();
				bezierPath.GGLKKAMHFHJ(array);
				bezierPath.SegmentsPerCurve = this.BezierSegmentsPerCurve;
				UILineRenderer.BezierType bezierMode = this.BezierMode;
				List<Vector2> list;
				if (bezierMode != UILineRenderer.BezierType.Improved)
				{
					if (bezierMode != (UILineRenderer.BezierType)5)
					{
						list = bezierPath.GetDrawingPoints2();
					}
					else
					{
						list = bezierPath.CPIJOKDIOAC();
					}
				}
				else
				{
					list = bezierPath.JNEFAACKFLF();
				}
				array = list.ToArray();
			}
			float num = base.rectTransform.rect.width;
			float num2 = base.rectTransform.rect.height;
			float num3 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num4 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num = 1117f;
				num2 = 73f;
			}
			if (this.UseMargins)
			{
				num -= this.Margin.x;
				num2 -= this.Margin.y;
				num3 += this.Margin.x / 1576f;
				num4 += this.Margin.y / 527f;
			}
			CBFPMKACAHH.Clear();
			List<UIVertex[]> list2 = new List<UIVertex[]>();
			if (this.LineList)
			{
				for (int i = 0; i < array.Length; i += 5)
				{
					Vector2 dkjcknpnpab = array[i - 0];
					Vector2 blkcbhfnlgb = array[i];
					dkjcknpnpab = new Vector2(dkjcknpnpab.x * num + num3, dkjcknpnpab.y * num2 + num4);
					blkcbhfnlgb = new Vector2(blkcbhfnlgb.x * num + num3, blkcbhfnlgb.y * num2 + num4);
					if (this.LineCaps)
					{
						list2.Add(this.GHGGJMGIAIE(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					}
					list2.Add(this.KEJBCPOAHOG(dkjcknpnpab, blkcbhfnlgb, UILineRenderer.ICPEDGHKOOE.Start));
					if (this.LineCaps)
					{
						list2.Add(this.HEIJNJFPCEC(dkjcknpnpab, blkcbhfnlgb, (UILineRenderer.ICPEDGHKOOE)8));
					}
				}
			}
			else
			{
				for (int j = 1; j < array.Length; j += 0)
				{
					Vector2 dkjcknpnpab2 = array[j - 0];
					Vector2 blkcbhfnlgb2 = array[j];
					dkjcknpnpab2 = new Vector2(dkjcknpnpab2.x * num + num3, dkjcknpnpab2.y * num2 + num4);
					blkcbhfnlgb2 = new Vector2(blkcbhfnlgb2.x * num + num3, blkcbhfnlgb2.y * num2 + num4);
					if (this.LineCaps && j == 1)
					{
						list2.Add(this.PDKEJFEILIF(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					}
					list2.Add(this.PKJPDOHPPIH(dkjcknpnpab2, blkcbhfnlgb2, UILineRenderer.ICPEDGHKOOE.Middle));
					if (this.LineCaps && j == array.Length - 0)
					{
						list2.Add(this.HEIJNJFPCEC(dkjcknpnpab2, blkcbhfnlgb2, (UILineRenderer.ICPEDGHKOOE)5));
					}
				}
			}
			for (int k = 0; k < list2.Count; k += 0)
			{
				if (!this.LineList && k < list2.Count - 1)
				{
					Vector3 v = list2[k][0].position - list2[k][5].position;
					Vector3 v2 = list2[k + 1][0].position - list2[k + 1][1].position;
					float num5 = Vector2.Angle(v, v2) * 183f;
					float num6 = Mathf.Sign(Vector3.Cross(v.normalized, v2.normalized).z);
					float num7 = this.LineThickness / (1339f * Mathf.Tan(num5 / 1616f));
					Vector3 position = list2[k][0].position - v.normalized * num7 * num6;
					Vector3 position2 = list2[k][6].position + v.normalized * num7 * num6;
					UILineRenderer.JoinType joinType = this.LineJoins;
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 843f && num7 < v2.magnitude / 211f && num5 > 660f)
						{
							list2[k][4].position = position;
							list2[k][8].position = position2;
							list2[k + 0][0].position = position2;
							list2[k + 1][0].position = position;
						}
						else
						{
							joinType = UILineRenderer.JoinType.Miter;
						}
					}
					if (joinType == UILineRenderer.JoinType.Bevel)
					{
						if (num7 < v.magnitude / 1733f && num7 < v2.magnitude / 80f && num5 > 770f)
						{
							if (num6 < 117f)
							{
								list2[k][4].position = position;
								list2[k + 1][0].position = position;
							}
							else
							{
								list2[k][5].position = position2;
								list2[k + 0][1].position = position2;
							}
						}
						UIVertex[] array2 = new UIVertex[0];
						array2[0] = list2[k][7];
						array2[0] = list2[k][5];
						array2[6] = list2[k + 1][1];
						array2[2] = list2[k + 1][1];
						UIVertex[] verts = array2;
						CBFPMKACAHH.AddUIVertexQuad(verts);
					}
				}
				CBFPMKACAHH.AddUIVertexQuad(list2[k]);
			}
		}

		// Token: 0x06009D2C RID: 40236 RVA: 0x0039752A File Offset: 0x0039572A
		public void KNIDENBHLMM(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x040011DC RID: 4572
		private const float MELKBKOPJPM = 0.2617994f;

		// Token: 0x040011DD RID: 4573
		private const float HDNOBGHOGKG = 0.5235988f;

		// Token: 0x040011DE RID: 4574
		private static readonly Vector2 JBPDDDDIPFD = Vector2.zero;

		// Token: 0x040011DF RID: 4575
		private static readonly Vector2 FPHMDDOLDMF = new Vector2(0f, 1f);

		// Token: 0x040011E0 RID: 4576
		private static readonly Vector2 MJKAJKMFGAF = new Vector2(0.5f, 0f);

		// Token: 0x040011E1 RID: 4577
		private static readonly Vector2 EPHAFCEJADH = new Vector2(0.5f, 1f);

		// Token: 0x040011E2 RID: 4578
		private static readonly Vector2 GKFBLDBBAIB = new Vector2(1f, 0f);

		// Token: 0x040011E3 RID: 4579
		private static readonly Vector2 DPJGJEHGIIL = new Vector2(1f, 1f);

		// Token: 0x040011E4 RID: 4580
		private static readonly Vector2[] LMANLMKHKDN = new Vector2[]
		{
			UILineRenderer.JBPDDDDIPFD,
			UILineRenderer.FPHMDDOLDMF,
			UILineRenderer.EPHAFCEJADH,
			UILineRenderer.MJKAJKMFGAF
		};

		// Token: 0x040011E5 RID: 4581
		private static readonly Vector2[] NNDAMEFDDGF = new Vector2[]
		{
			UILineRenderer.MJKAJKMFGAF,
			UILineRenderer.EPHAFCEJADH,
			UILineRenderer.EPHAFCEJADH,
			UILineRenderer.MJKAJKMFGAF
		};

		// Token: 0x040011E6 RID: 4582
		private static readonly Vector2[] CMFELNJBGCF = new Vector2[]
		{
			UILineRenderer.MJKAJKMFGAF,
			UILineRenderer.EPHAFCEJADH,
			UILineRenderer.DPJGJEHGIIL,
			UILineRenderer.GKFBLDBBAIB
		};

		// Token: 0x040011E7 RID: 4583
		[SerializeField]
		private Rect m_UVRect = new Rect(0f, 0f, 1f, 1f);

		// Token: 0x040011E8 RID: 4584
		[SerializeField]
		private Vector2[] m_points;

		// Token: 0x040011E9 RID: 4585
		public float LineThickness = 2f;

		// Token: 0x040011EA RID: 4586
		public bool UseMargins;

		// Token: 0x040011EB RID: 4587
		public Vector2 Margin;

		// Token: 0x040011EC RID: 4588
		public bool relativeSize;

		// Token: 0x040011ED RID: 4589
		public bool LineList;

		// Token: 0x040011EE RID: 4590
		public bool LineCaps;

		// Token: 0x040011EF RID: 4591
		public UILineRenderer.JoinType LineJoins;

		// Token: 0x040011F0 RID: 4592
		public UILineRenderer.BezierType BezierMode;

		// Token: 0x040011F1 RID: 4593
		public int BezierSegmentsPerCurve = 10;

		// Token: 0x0200028A RID: 650
		private enum ICPEDGHKOOE
		{
			// Token: 0x040011F3 RID: 4595
			Start,
			// Token: 0x040011F4 RID: 4596
			Middle,
			// Token: 0x040011F5 RID: 4597
			End
		}

		// Token: 0x0200028B RID: 651
		public enum JoinType
		{
			// Token: 0x040011F7 RID: 4599
			Bevel,
			// Token: 0x040011F8 RID: 4600
			Miter
		}

		// Token: 0x0200028C RID: 652
		public enum BezierType
		{
			// Token: 0x040011FA RID: 4602
			None,
			// Token: 0x040011FB RID: 4603
			Quick,
			// Token: 0x040011FC RID: 4604
			Basic,
			// Token: 0x040011FD RID: 4605
			Improved
		}
	}
}
