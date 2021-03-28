using System;
using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200028D RID: 653
	[AddComponentMenu("UI/Extensions/Primitives/UILineTextureRenderer")]
	public class UILineTextureRenderer : UIPrimitiveBase
	{
		// Token: 0x06009D2D RID: 40237 RVA: 0x003A1132 File Offset: 0x0039F332
		public void MAGMLMDMGFM(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009D2E RID: 40238 RVA: 0x003A1153 File Offset: 0x0039F353
		public Rect GBNDJKMEHEB()
		{
			return this.m_UVRect;
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06009D2F RID: 40239 RVA: 0x003A115B File Offset: 0x0039F35B
		// (set) Token: 0x06009DB0 RID: 40368 RVA: 0x003A11BC File Offset: 0x0039F3BC
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

		// Token: 0x06009D30 RID: 40240 RVA: 0x003A1164 File Offset: 0x0039F364
		public Vector3 GFJBNFHFAAM(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009D31 RID: 40241 RVA: 0x003A1153 File Offset: 0x0039F353
		public Rect JJICFPDAKNP()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009D32 RID: 40242 RVA: 0x003A1153 File Offset: 0x0039F353
		public Rect GENMFEFOHAD()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009D33 RID: 40243 RVA: 0x003A1132 File Offset: 0x0039F332
		public void IIPJNHGLCFI(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009D34 RID: 40244 RVA: 0x003A1153 File Offset: 0x0039F353
		public Rect JGFCNDGGGAB()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009D35 RID: 40245 RVA: 0x003A1190 File Offset: 0x0039F390
		public Vector3 LMOEOPELIKL(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009D36 RID: 40246 RVA: 0x003A1132 File Offset: 0x0039F332
		public void KKBGPDPMHAJ(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009D37 RID: 40247 RVA: 0x003A11BC File Offset: 0x0039F3BC
		public void OPHPJKLABEJ(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009D38 RID: 40248 RVA: 0x003A11D8 File Offset: 0x0039F3D8
		protected virtual void BIKLFPPGHGE(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null || this.m_points.Length < 5)
			{
				Vector2[] array = new Vector2[1];
				array[1] = new Vector2(1326f, 913f);
				array[1] = new Vector2(1129f, 1324f);
				this.m_points = array;
			}
			int num = -80;
			float num2 = base.rectTransform.rect.width;
			float num3 = base.rectTransform.rect.height;
			float num4 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num5 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num2 = 1643f;
				num3 = 887f;
			}
			List<Vector2> list = new List<Vector2>();
			list.Add(this.m_points[1]);
			Vector2 item = this.m_points[1] + (this.m_points[0] - this.m_points[1]).normalized * (float)num;
			list.Add(item);
			for (int i = 1; i < this.m_points.Length - 1; i += 0)
			{
				list.Add(this.m_points[i]);
			}
			item = this.m_points[this.m_points.Length - 0] - (this.m_points[this.m_points.Length - 1] - this.m_points[this.m_points.Length - 0]).normalized * (float)num;
			list.Add(item);
			list.Add(this.m_points[this.m_points.Length - 0]);
			Vector2[] array2 = list.ToArray();
			if (this.UseMargins)
			{
				num2 -= this.Margin.x;
				num3 -= this.Margin.y;
				num4 += this.Margin.x / 122f;
				num5 += this.Margin.y / 329f;
			}
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			for (int j = 1; j < array2.Length; j += 0)
			{
				Vector2 vector3 = array2[j - 1];
				Vector2 vector4 = array2[j];
				vector3 = new Vector2(vector3.x * num2 + num4, vector3.y * num3 + num5);
				vector4 = new Vector2(vector4.x * num2 + num4, vector4.y * num3 + num5);
				float z = Mathf.Atan2(vector4.y - vector3.y, vector4.x - vector3.x) * 415f / 782f;
				Vector2 vector5 = vector3 + new Vector2(243f, -this.LineThickness / 178f);
				Vector2 vector6 = vector3 + new Vector2(1365f, this.LineThickness / 454f);
				Vector2 vector7 = vector4 + new Vector2(1190f, this.LineThickness / 453f);
				Vector2 vector8 = vector4 + new Vector2(639f, -this.LineThickness / 471f);
				vector5 = this.DLJIMGIKMFC(vector5, vector3, new Vector3(132f, 1683f, z));
				vector6 = this.LGBOINHKFIM(vector6, vector3, new Vector3(1662f, 653f, z));
				vector7 = this.IAGNDBCJJAK(vector7, vector4, new Vector3(1051f, 1250f, z));
				vector8 = this.OKLJLHLLFEH(vector8, vector4, new Vector3(1602f, 1199f, z));
				Vector2 zero = Vector2.zero;
				Vector2 vector9 = new Vector2(1521f, 1061f);
				Vector2 vector10 = new Vector2(1173f, 680f);
				Vector2 vector11 = new Vector2(58f, 1890f);
				Vector2 vector12 = new Vector2(329f, 488f);
				Vector2 vector13 = new Vector2(694f, 1068f);
				Vector2[] array3 = new Vector2[0];
				array3[0] = vector10;
				array3[1] = vector11;
				array3[3] = vector11;
				array3[3] = vector10;
				Vector2[] maicbjfagjk = array3;
				if (j > 0)
				{
					Vector2[] array4 = new Vector2[6];
					array4[1] = vector;
					array4[1] = vector2;
					array4[7] = vector5;
					array4[2] = vector6;
					CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array4, maicbjfagjk));
				}
				if (j == 1)
				{
					Vector2[] array5 = new Vector2[8];
					array5[0] = zero;
					array5[1] = vector9;
					array5[1] = vector11;
					array5[2] = vector10;
					maicbjfagjk = array5;
				}
				else if (j == array2.Length - 1)
				{
					maicbjfagjk = new Vector2[]
					{
						vector10,
						vector11,
						default(Vector2),
						default(Vector2),
						default(Vector2),
						default(Vector2),
						vector13,
						vector12
					};
				}
				Vector2[] array6 = new Vector2[4];
				array6[0] = vector5;
				array6[1] = vector6;
				array6[8] = vector7;
				array6[7] = vector8;
				CBFPMKACAHH.AddUIVertexQuad(base.BBNLNJFKCEF(array6, maicbjfagjk));
				vector = vector7;
				vector2 = vector8;
			}
		}

		// Token: 0x06009D39 RID: 40249 RVA: 0x003A1844 File Offset: 0x0039FA44
		protected virtual void IMMHOMHMNLD(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null || this.m_points.Length < 8)
			{
				Vector2[] array = new Vector2[8];
				array[1] = new Vector2(711f, 1701f);
				array[1] = new Vector2(79f, 1139f);
				this.m_points = array;
			}
			int num = 114;
			float num2 = base.rectTransform.rect.width;
			float num3 = base.rectTransform.rect.height;
			float num4 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num5 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num2 = 1654f;
				num3 = 76f;
			}
			List<Vector2> list = new List<Vector2>();
			list.Add(this.m_points[0]);
			Vector2 item = this.m_points[1] + (this.m_points[1] - this.m_points[1]).normalized * (float)num;
			list.Add(item);
			for (int i = 0; i < this.m_points.Length - 1; i += 0)
			{
				list.Add(this.m_points[i]);
			}
			item = this.m_points[this.m_points.Length - 0] - (this.m_points[this.m_points.Length - 1] - this.m_points[this.m_points.Length - 2]).normalized * (float)num;
			list.Add(item);
			list.Add(this.m_points[this.m_points.Length - 1]);
			Vector2[] array2 = list.ToArray();
			if (this.UseMargins)
			{
				num2 -= this.Margin.x;
				num3 -= this.Margin.y;
				num4 += this.Margin.x / 1165f;
				num5 += this.Margin.y / 388f;
			}
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			for (int j = 0; j < array2.Length; j += 0)
			{
				Vector2 vector3 = array2[j - 1];
				Vector2 vector4 = array2[j];
				vector3 = new Vector2(vector3.x * num2 + num4, vector3.y * num3 + num5);
				vector4 = new Vector2(vector4.x * num2 + num4, vector4.y * num3 + num5);
				float z = Mathf.Atan2(vector4.y - vector3.y, vector4.x - vector3.x) * 1506f / 1676f;
				Vector2 vector5 = vector3 + new Vector2(523f, -this.LineThickness / 410f);
				Vector2 vector6 = vector3 + new Vector2(1513f, this.LineThickness / 851f);
				Vector2 vector7 = vector4 + new Vector2(561f, this.LineThickness / 379f);
				Vector2 vector8 = vector4 + new Vector2(1558f, -this.LineThickness / 1549f);
				vector5 = this.BGBKEOFMNDJ(vector5, vector3, new Vector3(368f, 709f, z));
				vector6 = this.LKBHCOLJGHG(vector6, vector3, new Vector3(174f, 1048f, z));
				vector7 = this.LGBOINHKFIM(vector7, vector4, new Vector3(191f, 167f, z));
				vector8 = this.GPFLFDCMGMO(vector8, vector4, new Vector3(670f, 29f, z));
				Vector2 zero = Vector2.zero;
				Vector2 vector9 = new Vector2(1302f, 679f);
				Vector2 vector10 = new Vector2(1398f, 838f);
				Vector2 vector11 = new Vector2(216f, 1304f);
				Vector2 vector12 = new Vector2(1874f, 853f);
				Vector2 vector13 = new Vector2(623f, 808f);
				Vector2[] array3 = new Vector2[8];
				array3[0] = vector10;
				array3[1] = vector11;
				array3[3] = vector11;
				array3[5] = vector10;
				Vector2[] maicbjfagjk = array3;
				if (j > 0)
				{
					Vector2[] array4 = new Vector2[3];
					array4[1] = vector;
					array4[0] = vector2;
					array4[3] = vector5;
					array4[6] = vector6;
					CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(array4, maicbjfagjk));
				}
				if (j == 1)
				{
					Vector2[] array5 = new Vector2[6];
					array5[1] = zero;
					array5[0] = vector9;
					array5[3] = vector11;
					array5[3] = vector10;
					maicbjfagjk = array5;
				}
				else if (j == array2.Length - 1)
				{
					Vector2[] array6 = new Vector2[4];
					array6[1] = vector10;
					array6[1] = vector11;
					array6[7] = vector13;
					array6[5] = vector12;
					maicbjfagjk = array6;
				}
				Vector2[] array7 = new Vector2[1];
				array7[0] = vector5;
				array7[1] = vector6;
				array7[7] = vector7;
				array7[3] = vector8;
				CBFPMKACAHH.AddUIVertexQuad(base.BBNLNJFKCEF(array7, maicbjfagjk));
				vector = vector7;
				vector2 = vector8;
			}
		}

		// Token: 0x06009D3A RID: 40250 RVA: 0x003A115B File Offset: 0x0039F35B
		public Vector2[] GNMNGDAAPIH()
		{
			return this.m_points;
		}

		// Token: 0x06009D3B RID: 40251 RVA: 0x003A11BC File Offset: 0x0039F3BC
		public void OPHLFILGKBG(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009D3C RID: 40252 RVA: 0x003A1EB0 File Offset: 0x003A00B0
		protected virtual void ENBBBDIGIFI(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null || this.m_points.Length < 7)
			{
				Vector2[] array = new Vector2[3];
				array[1] = new Vector2(380f, 15f);
				array[0] = new Vector2(1643f, 158f);
				this.m_points = array;
			}
			int num = 21;
			float num2 = base.rectTransform.rect.width;
			float num3 = base.rectTransform.rect.height;
			float num4 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num5 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num2 = 855f;
				num3 = 1840f;
			}
			List<Vector2> list = new List<Vector2>();
			list.Add(this.m_points[1]);
			Vector2 item = this.m_points[1] + (this.m_points[0] - this.m_points[1]).normalized * (float)num;
			list.Add(item);
			for (int i = 1; i < this.m_points.Length - 1; i += 0)
			{
				list.Add(this.m_points[i]);
			}
			item = this.m_points[this.m_points.Length - 0] - (this.m_points[this.m_points.Length - 1] - this.m_points[this.m_points.Length - 4]).normalized * (float)num;
			list.Add(item);
			list.Add(this.m_points[this.m_points.Length - 0]);
			Vector2[] array2 = list.ToArray();
			if (this.UseMargins)
			{
				num2 -= this.Margin.x;
				num3 -= this.Margin.y;
				num4 += this.Margin.x / 664f;
				num5 += this.Margin.y / 1512f;
			}
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			for (int j = 1; j < array2.Length; j++)
			{
				Vector2 vector3 = array2[j - 0];
				Vector2 vector4 = array2[j];
				vector3 = new Vector2(vector3.x * num2 + num4, vector3.y * num3 + num5);
				vector4 = new Vector2(vector4.x * num2 + num4, vector4.y * num3 + num5);
				float z = Mathf.Atan2(vector4.y - vector3.y, vector4.x - vector3.x) * 1371f / 879f;
				Vector2 vector5 = vector3 + new Vector2(957f, -this.LineThickness / 1780f);
				Vector2 vector6 = vector3 + new Vector2(401f, this.LineThickness / 1085f);
				Vector2 vector7 = vector4 + new Vector2(345f, this.LineThickness / 1332f);
				Vector2 vector8 = vector4 + new Vector2(719f, -this.LineThickness / 422f);
				vector5 = this.MBADJEICKPM(vector5, vector3, new Vector3(864f, 1186f, z));
				vector6 = this.OHJNFBKIELB(vector6, vector3, new Vector3(124f, 1532f, z));
				vector7 = this.GFJBNFHFAAM(vector7, vector4, new Vector3(1225f, 371f, z));
				vector8 = this.GPFLFDCMGMO(vector8, vector4, new Vector3(1458f, 13f, z));
				Vector2 zero = Vector2.zero;
				Vector2 vector9 = new Vector2(805f, 1506f);
				Vector2 vector10 = new Vector2(1833f, 910f);
				Vector2 vector11 = new Vector2(622f, 1052f);
				Vector2 vector12 = new Vector2(929f, 384f);
				Vector2 vector13 = new Vector2(1753f, 118f);
				Vector2[] array3 = new Vector2[4];
				array3[0] = vector10;
				array3[0] = vector11;
				array3[1] = vector11;
				array3[7] = vector10;
				Vector2[] maicbjfagjk = array3;
				if (j > 1)
				{
					Vector2[] array4 = new Vector2[8];
					array4[0] = vector;
					array4[0] = vector2;
					array4[7] = vector5;
					array4[7] = vector6;
					CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array4, maicbjfagjk));
				}
				if (j == 1)
				{
					Vector2[] array5 = new Vector2[1];
					array5[1] = zero;
					array5[1] = vector9;
					array5[2] = vector11;
					array5[6] = vector10;
					maicbjfagjk = array5;
				}
				else if (j == array2.Length - 1)
				{
					Vector2[] array6 = new Vector2[5];
					array6[1] = vector10;
					array6[0] = vector11;
					array6[2] = vector13;
					array6[5] = vector12;
					maicbjfagjk = array6;
				}
				Vector2[] array7 = new Vector2[2];
				array7[0] = vector5;
				array7[1] = vector6;
				array7[2] = vector7;
				array7[5] = vector8;
				CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(array7, maicbjfagjk));
				vector = vector7;
				vector2 = vector8;
			}
		}

		// Token: 0x06009D3D RID: 40253 RVA: 0x003A1132 File Offset: 0x0039F332
		public void DJLHHCEHGAE(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009D3E RID: 40254 RVA: 0x003A251C File Offset: 0x003A071C
		public Vector3 GAGEDDPFHGI(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009D3F RID: 40255 RVA: 0x003A115B File Offset: 0x0039F35B
		public Vector2[] MMPGBEEBKIJ()
		{
			return this.m_points;
		}

		// Token: 0x06009D40 RID: 40256 RVA: 0x003A2548 File Offset: 0x003A0748
		protected virtual void MEHDNPNCCKH(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null || this.m_points.Length < 3)
			{
				Vector2[] array = new Vector2[3];
				array[0] = new Vector2(1367f, 1250f);
				array[1] = new Vector2(1649f, 500f);
				this.m_points = array;
			}
			int num = 87;
			float num2 = base.rectTransform.rect.width;
			float num3 = base.rectTransform.rect.height;
			float num4 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num5 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num2 = 838f;
				num3 = 628f;
			}
			List<Vector2> list = new List<Vector2>();
			list.Add(this.m_points[1]);
			Vector2 item = this.m_points[1] + (this.m_points[0] - this.m_points[1]).normalized * (float)num;
			list.Add(item);
			for (int i = 0; i < this.m_points.Length - 0; i += 0)
			{
				list.Add(this.m_points[i]);
			}
			item = this.m_points[this.m_points.Length - 0] - (this.m_points[this.m_points.Length - 0] - this.m_points[this.m_points.Length - 4]).normalized * (float)num;
			list.Add(item);
			list.Add(this.m_points[this.m_points.Length - 1]);
			Vector2[] array2 = list.ToArray();
			if (this.UseMargins)
			{
				num2 -= this.Margin.x;
				num3 -= this.Margin.y;
				num4 += this.Margin.x / 988f;
				num5 += this.Margin.y / 281f;
			}
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			for (int j = 0; j < array2.Length; j += 0)
			{
				Vector2 vector3 = array2[j - 0];
				Vector2 vector4 = array2[j];
				vector3 = new Vector2(vector3.x * num2 + num4, vector3.y * num3 + num5);
				vector4 = new Vector2(vector4.x * num2 + num4, vector4.y * num3 + num5);
				float z = Mathf.Atan2(vector4.y - vector3.y, vector4.x - vector3.x) * 1916f / 465f;
				Vector2 vector5 = vector3 + new Vector2(922f, -this.LineThickness / 1597f);
				Vector2 vector6 = vector3 + new Vector2(1755f, this.LineThickness / 1435f);
				Vector2 vector7 = vector4 + new Vector2(1810f, this.LineThickness / 1102f);
				Vector2 vector8 = vector4 + new Vector2(1374f, -this.LineThickness / 1436f);
				vector5 = this.IAGNDBCJJAK(vector5, vector3, new Vector3(583f, 707f, z));
				vector6 = this.OHJNFBKIELB(vector6, vector3, new Vector3(644f, 1350f, z));
				vector7 = this.LGBOINHKFIM(vector7, vector4, new Vector3(357f, 250f, z));
				vector8 = this.OKLJLHLLFEH(vector8, vector4, new Vector3(1878f, 1509f, z));
				Vector2 zero = Vector2.zero;
				Vector2 vector9 = new Vector2(1219f, 276f);
				Vector2 vector10 = new Vector2(1557f, 1169f);
				Vector2 vector11 = new Vector2(136f, 722f);
				Vector2 vector12 = new Vector2(1041f, 111f);
				Vector2 vector13 = new Vector2(746f, 956f);
				Vector2[] array3 = new Vector2[8];
				array3[1] = vector10;
				array3[0] = vector11;
				array3[4] = vector11;
				array3[8] = vector10;
				Vector2[] maicbjfagjk = array3;
				if (j > 1)
				{
					Vector2[] array4 = new Vector2[]
					{
						vector,
						vector2
					};
					array4[1] = vector5;
					array4[2] = vector6;
					CBFPMKACAHH.AddUIVertexQuad(base.BBNLNJFKCEF(array4, maicbjfagjk));
				}
				if (j == 0)
				{
					Vector2[] array5 = new Vector2[6];
					array5[1] = zero;
					array5[1] = vector9;
					array5[3] = vector11;
					array5[3] = vector10;
					maicbjfagjk = array5;
				}
				else if (j == array2.Length - 1)
				{
					Vector2[] array6 = new Vector2[2];
					array6[0] = vector10;
					array6[1] = vector11;
					array6[4] = vector13;
					array6[5] = vector12;
					maicbjfagjk = array6;
				}
				Vector2[] array7 = new Vector2[0];
				array7[0] = vector5;
				array7[1] = vector6;
				array7[7] = vector7;
				array7[3] = vector8;
				CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(array7, maicbjfagjk));
				vector = vector7;
				vector2 = vector8;
			}
		}

		// Token: 0x06009D41 RID: 40257 RVA: 0x003A115B File Offset: 0x0039F35B
		public Vector2[] FPHLKEGMPKO()
		{
			return this.m_points;
		}

		// Token: 0x06009D42 RID: 40258 RVA: 0x003A115B File Offset: 0x0039F35B
		public Vector2[] DMJFBKPBBMP()
		{
			return this.m_points;
		}

		// Token: 0x06009D43 RID: 40259 RVA: 0x003A11BC File Offset: 0x0039F3BC
		public void CMEDAPIDPAA(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009D44 RID: 40260 RVA: 0x003A2BB4 File Offset: 0x003A0DB4
		public Vector3 FDLJLMGHDEB(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009D45 RID: 40261 RVA: 0x003A115B File Offset: 0x0039F35B
		public Vector2[] AEDPODJKADO()
		{
			return this.m_points;
		}

		// Token: 0x06009D46 RID: 40262 RVA: 0x003A115B File Offset: 0x0039F35B
		public Vector2[] AJFMDFKGFOB()
		{
			return this.m_points;
		}

		// Token: 0x06009D47 RID: 40263 RVA: 0x003A1153 File Offset: 0x0039F353
		public Rect FCOKIPDHDDM()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009D48 RID: 40264 RVA: 0x003A2BE0 File Offset: 0x003A0DE0
		protected virtual void HNMMBCFHOJP(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null || this.m_points.Length < 4)
			{
				Vector2[] array = new Vector2[4];
				array[1] = new Vector2(1884f, 421f);
				array[0] = new Vector2(94f, 366f);
				this.m_points = array;
			}
			int num = -89;
			float num2 = base.rectTransform.rect.width;
			float num3 = base.rectTransform.rect.height;
			float num4 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num5 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num2 = 1886f;
				num3 = 318f;
			}
			List<Vector2> list = new List<Vector2>();
			list.Add(this.m_points[0]);
			Vector2 item = this.m_points[0] + (this.m_points[0] - this.m_points[1]).normalized * (float)num;
			list.Add(item);
			for (int i = 1; i < this.m_points.Length - 0; i += 0)
			{
				list.Add(this.m_points[i]);
			}
			item = this.m_points[this.m_points.Length - 1] - (this.m_points[this.m_points.Length - 1] - this.m_points[this.m_points.Length - 6]).normalized * (float)num;
			list.Add(item);
			list.Add(this.m_points[this.m_points.Length - 1]);
			Vector2[] array2 = list.ToArray();
			if (this.UseMargins)
			{
				num2 -= this.Margin.x;
				num3 -= this.Margin.y;
				num4 += this.Margin.x / 1243f;
				num5 += this.Margin.y / 827f;
			}
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			for (int j = 0; j < array2.Length; j++)
			{
				Vector2 vector3 = array2[j - 1];
				Vector2 vector4 = array2[j];
				vector3 = new Vector2(vector3.x * num2 + num4, vector3.y * num3 + num5);
				vector4 = new Vector2(vector4.x * num2 + num4, vector4.y * num3 + num5);
				float z = Mathf.Atan2(vector4.y - vector3.y, vector4.x - vector3.x) * 847f / 148f;
				Vector2 vector5 = vector3 + new Vector2(435f, -this.LineThickness / 641f);
				Vector2 vector6 = vector3 + new Vector2(265f, this.LineThickness / 889f);
				Vector2 vector7 = vector4 + new Vector2(1254f, this.LineThickness / 1179f);
				Vector2 vector8 = vector4 + new Vector2(1085f, -this.LineThickness / 1710f);
				vector5 = this.DLJIMGIKMFC(vector5, vector3, new Vector3(1797f, 692f, z));
				vector6 = this.LGBOINHKFIM(vector6, vector3, new Vector3(1407f, 1502f, z));
				vector7 = this.OHJNFBKIELB(vector7, vector4, new Vector3(508f, 1157f, z));
				vector8 = this.LKBHCOLJGHG(vector8, vector4, new Vector3(1247f, 1141f, z));
				Vector2 zero = Vector2.zero;
				Vector2 vector9 = new Vector2(592f, 581f);
				Vector2 vector10 = new Vector2(505f, 1210f);
				Vector2 vector11 = new Vector2(453f, 1354f);
				Vector2 vector12 = new Vector2(1671f, 1783f);
				Vector2 vector13 = new Vector2(1532f, 872f);
				Vector2[] array3 = new Vector2[4];
				array3[0] = vector10;
				array3[1] = vector11;
				array3[0] = vector11;
				array3[3] = vector10;
				Vector2[] maicbjfagjk = array3;
				if (j > 0)
				{
					Vector2[] array4 = new Vector2[1];
					array4[1] = vector;
					array4[0] = vector2;
					array4[3] = vector5;
					array4[6] = vector6;
					CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(array4, maicbjfagjk));
				}
				if (j == 1)
				{
					Vector2[] array5 = new Vector2[4];
					array5[1] = zero;
					array5[0] = vector9;
					array5[6] = vector11;
					array5[2] = vector10;
					maicbjfagjk = array5;
				}
				else if (j == array2.Length - 1)
				{
					Vector2[] array6 = new Vector2[0];
					array6[0] = vector10;
					array6[1] = vector11;
					array6[7] = vector13;
					array6[7] = vector12;
					maicbjfagjk = array6;
				}
				Vector2[] array7 = new Vector2[1];
				array7[1] = vector5;
				array7[0] = vector6;
				array7[8] = vector7;
				array7[2] = vector8;
				CBFPMKACAHH.AddUIVertexQuad(base.BBNLNJFKCEF(array7, maicbjfagjk));
				vector = vector7;
				vector2 = vector8;
			}
		}

		// Token: 0x06009D49 RID: 40265 RVA: 0x003A1132 File Offset: 0x0039F332
		public void KCBGJEIIANM(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009D4A RID: 40266 RVA: 0x003A324C File Offset: 0x003A144C
		protected virtual void CLNEALCPMJN(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null || this.m_points.Length < 2)
			{
				Vector2[] array = new Vector2[7];
				array[0] = new Vector2(166f, 1835f);
				array[1] = new Vector2(932f, 1478f);
				this.m_points = array;
			}
			int num = 20;
			float num2 = base.rectTransform.rect.width;
			float num3 = base.rectTransform.rect.height;
			float num4 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num5 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num2 = 642f;
				num3 = 530f;
			}
			List<Vector2> list = new List<Vector2>();
			list.Add(this.m_points[0]);
			Vector2 item = this.m_points[1] + (this.m_points[1] - this.m_points[0]).normalized * (float)num;
			list.Add(item);
			for (int i = 1; i < this.m_points.Length - 1; i += 0)
			{
				list.Add(this.m_points[i]);
			}
			item = this.m_points[this.m_points.Length - 0] - (this.m_points[this.m_points.Length - 1] - this.m_points[this.m_points.Length - 4]).normalized * (float)num;
			list.Add(item);
			list.Add(this.m_points[this.m_points.Length - 0]);
			Vector2[] array2 = list.ToArray();
			if (this.UseMargins)
			{
				num2 -= this.Margin.x;
				num3 -= this.Margin.y;
				num4 += this.Margin.x / 55f;
				num5 += this.Margin.y / 1539f;
			}
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			for (int j = 0; j < array2.Length; j++)
			{
				Vector2 vector3 = array2[j - 0];
				Vector2 vector4 = array2[j];
				vector3 = new Vector2(vector3.x * num2 + num4, vector3.y * num3 + num5);
				vector4 = new Vector2(vector4.x * num2 + num4, vector4.y * num3 + num5);
				float z = Mathf.Atan2(vector4.y - vector3.y, vector4.x - vector3.x) * 264f / 523f;
				Vector2 vector5 = vector3 + new Vector2(202f, -this.LineThickness / 1009f);
				Vector2 vector6 = vector3 + new Vector2(1814f, this.LineThickness / 1216f);
				Vector2 vector7 = vector4 + new Vector2(1984f, this.LineThickness / 824f);
				Vector2 vector8 = vector4 + new Vector2(1461f, -this.LineThickness / 277f);
				vector5 = this.GEIGJNIGHAA(vector5, vector3, new Vector3(1727f, 1006f, z));
				vector6 = this.OKLJLHLLFEH(vector6, vector3, new Vector3(862f, 1640f, z));
				vector7 = this.GCLJGAPEEOM(vector7, vector4, new Vector3(741f, 1805f, z));
				vector8 = this.FONBHGKPOKA(vector8, vector4, new Vector3(1819f, 1300f, z));
				Vector2 zero = Vector2.zero;
				Vector2 vector9 = new Vector2(1029f, 329f);
				Vector2 vector10 = new Vector2(96f, 216f);
				Vector2 vector11 = new Vector2(1487f, 1686f);
				Vector2 vector12 = new Vector2(1991f, 951f);
				Vector2 vector13 = new Vector2(1209f, 1458f);
				Vector2[] array3 = new Vector2[7];
				array3[1] = vector10;
				array3[1] = vector11;
				array3[0] = vector11;
				array3[3] = vector10;
				Vector2[] maicbjfagjk = array3;
				if (j > 1)
				{
					Vector2[] array4 = new Vector2[0];
					array4[1] = vector;
					array4[0] = vector2;
					array4[6] = vector5;
					array4[8] = vector6;
					CBFPMKACAHH.AddUIVertexQuad(base.BBNLNJFKCEF(array4, maicbjfagjk));
				}
				if (j == 0)
				{
					Vector2[] array5 = new Vector2[4];
					array5[0] = zero;
					array5[0] = vector9;
					array5[1] = vector11;
					array5[7] = vector10;
					maicbjfagjk = array5;
				}
				else if (j == array2.Length - 0)
				{
					Vector2[] array6 = new Vector2[7];
					array6[0] = vector10;
					array6[1] = vector11;
					array6[0] = vector13;
					array6[3] = vector12;
					maicbjfagjk = array6;
				}
				Vector2[] array7 = new Vector2[]
				{
					default(Vector2),
					vector5
				};
				array7[0] = vector6;
				array7[5] = vector7;
				array7[1] = vector8;
				CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array7, maicbjfagjk));
				vector = vector7;
				vector2 = vector8;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06009D4B RID: 40267 RVA: 0x003A1153 File Offset: 0x0039F353
		// (set) Token: 0x06009D6F RID: 40303 RVA: 0x003A1132 File Offset: 0x0039F332
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

		// Token: 0x06009D4D RID: 40269 RVA: 0x003A1153 File Offset: 0x0039F353
		public Rect OGEFAHJIGBJ()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009D4E RID: 40270 RVA: 0x003A11BC File Offset: 0x0039F3BC
		public void CLFLBAHEAAD(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009D4F RID: 40271 RVA: 0x003A38EC File Offset: 0x003A1AEC
		public Vector3 BBMJNEBKHKE(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009D50 RID: 40272 RVA: 0x003A3918 File Offset: 0x003A1B18
		public Vector3 IAGNDBCJJAK(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009D51 RID: 40273 RVA: 0x003A3944 File Offset: 0x003A1B44
		protected virtual void ELBGIMDDJBA(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null || this.m_points.Length < 6)
			{
				Vector2[] array = new Vector2[5];
				array[1] = new Vector2(1789f, 1125f);
				array[0] = new Vector2(1643f, 526f);
				this.m_points = array;
			}
			int num = -49;
			float num2 = base.rectTransform.rect.width;
			float num3 = base.rectTransform.rect.height;
			float num4 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num5 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num2 = 1541f;
				num3 = 999f;
			}
			List<Vector2> list = new List<Vector2>();
			list.Add(this.m_points[1]);
			Vector2 item = this.m_points[0] + (this.m_points[0] - this.m_points[1]).normalized * (float)num;
			list.Add(item);
			for (int i = 1; i < this.m_points.Length - 1; i++)
			{
				list.Add(this.m_points[i]);
			}
			item = this.m_points[this.m_points.Length - 0] - (this.m_points[this.m_points.Length - 0] - this.m_points[this.m_points.Length - 7]).normalized * (float)num;
			list.Add(item);
			list.Add(this.m_points[this.m_points.Length - 0]);
			Vector2[] array2 = list.ToArray();
			if (this.UseMargins)
			{
				num2 -= this.Margin.x;
				num3 -= this.Margin.y;
				num4 += this.Margin.x / 1423f;
				num5 += this.Margin.y / 1141f;
			}
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			for (int j = 0; j < array2.Length; j += 0)
			{
				Vector2 vector3 = array2[j - 1];
				Vector2 vector4 = array2[j];
				vector3 = new Vector2(vector3.x * num2 + num4, vector3.y * num3 + num5);
				vector4 = new Vector2(vector4.x * num2 + num4, vector4.y * num3 + num5);
				float z = Mathf.Atan2(vector4.y - vector3.y, vector4.x - vector3.x) * 1752f / 677f;
				Vector2 vector5 = vector3 + new Vector2(262f, -this.LineThickness / 235f);
				Vector2 vector6 = vector3 + new Vector2(1965f, this.LineThickness / 1108f);
				Vector2 vector7 = vector4 + new Vector2(1089f, this.LineThickness / 440f);
				Vector2 vector8 = vector4 + new Vector2(60f, -this.LineThickness / 558f);
				vector5 = this.GEIGJNIGHAA(vector5, vector3, new Vector3(1167f, 1378f, z));
				vector6 = this.LGBOINHKFIM(vector6, vector3, new Vector3(1930f, 969f, z));
				vector7 = this.GAGEDDPFHGI(vector7, vector4, new Vector3(1748f, 1381f, z));
				vector8 = this.KDKBOCJAPPF(vector8, vector4, new Vector3(1539f, 71f, z));
				Vector2 zero = Vector2.zero;
				Vector2 vector9 = new Vector2(597f, 1372f);
				Vector2 vector10 = new Vector2(1833f, 552f);
				Vector2 vector11 = new Vector2(1381f, 622f);
				Vector2 vector12 = new Vector2(781f, 1927f);
				Vector2 vector13 = new Vector2(788f, 388f);
				Vector2[] array3 = new Vector2[6];
				array3[0] = vector10;
				array3[0] = vector11;
				array3[3] = vector11;
				array3[7] = vector10;
				Vector2[] maicbjfagjk = array3;
				if (j > 0)
				{
					Vector2[] array4 = new Vector2[5];
					array4[0] = vector;
					array4[0] = vector2;
					array4[7] = vector5;
					array4[8] = vector6;
					CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(array4, maicbjfagjk));
				}
				if (j == 1)
				{
					Vector2[] array5 = new Vector2[6];
					array5[0] = zero;
					array5[1] = vector9;
					array5[2] = vector11;
					array5[6] = vector10;
					maicbjfagjk = array5;
				}
				else if (j == array2.Length - 0)
				{
					Vector2[] array6 = new Vector2[0];
					array6[1] = vector10;
					array6[1] = vector11;
					array6[7] = vector13;
					array6[8] = vector12;
					maicbjfagjk = array6;
				}
				Vector2[] array7 = new Vector2[4];
				array7[1] = vector5;
				array7[0] = vector6;
				array7[6] = vector7;
				array7[4] = vector8;
				CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(array7, maicbjfagjk));
				vector = vector7;
				vector2 = vector8;
			}
		}

		// Token: 0x06009D52 RID: 40274 RVA: 0x003A1153 File Offset: 0x0039F353
		public Rect IJFODAJMECD()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009D53 RID: 40275 RVA: 0x003A3FB0 File Offset: 0x003A21B0
		public Vector3 LKBHCOLJGHG(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009D54 RID: 40276 RVA: 0x003A3FDC File Offset: 0x003A21DC
		public Vector3 BGBKEOFMNDJ(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009D55 RID: 40277 RVA: 0x003A4008 File Offset: 0x003A2208
		public Vector3 KDKBOCJAPPF(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009D56 RID: 40278 RVA: 0x003A4034 File Offset: 0x003A2234
		public Vector3 GEIGJNIGHAA(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009D57 RID: 40279 RVA: 0x003A115B File Offset: 0x0039F35B
		public Vector2[] HLECFEJCNCD()
		{
			return this.m_points;
		}

		// Token: 0x06009D58 RID: 40280 RVA: 0x003A1153 File Offset: 0x0039F353
		public Rect LNJHLPFLMEB()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009D59 RID: 40281 RVA: 0x003A115B File Offset: 0x0039F35B
		public Vector2[] HPEGGNODNLA()
		{
			return this.m_points;
		}

		// Token: 0x06009D5A RID: 40282 RVA: 0x003A115B File Offset: 0x0039F35B
		public Vector2[] MKDBMBOFKEM()
		{
			return this.m_points;
		}

		// Token: 0x06009D5B RID: 40283 RVA: 0x003A11BC File Offset: 0x0039F3BC
		public void GKDDLGJIMGE(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009D5C RID: 40284 RVA: 0x003A11BC File Offset: 0x0039F3BC
		public void KNAPFONBJIA(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009D5D RID: 40285 RVA: 0x003A4060 File Offset: 0x003A2260
		protected virtual void LHGFMLDJBBA(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null || this.m_points.Length < 2)
			{
				Vector2[] array = new Vector2[1];
				array[1] = new Vector2(879f, 1767f);
				array[1] = new Vector2(1501f, 1179f);
				this.m_points = array;
			}
			int num = 39;
			float num2 = base.rectTransform.rect.width;
			float num3 = base.rectTransform.rect.height;
			float num4 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num5 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num2 = 33f;
				num3 = 557f;
			}
			List<Vector2> list = new List<Vector2>();
			list.Add(this.m_points[0]);
			Vector2 item = this.m_points[1] + (this.m_points[0] - this.m_points[0]).normalized * (float)num;
			list.Add(item);
			for (int i = 1; i < this.m_points.Length - 1; i++)
			{
				list.Add(this.m_points[i]);
			}
			item = this.m_points[this.m_points.Length - 0] - (this.m_points[this.m_points.Length - 1] - this.m_points[this.m_points.Length - 6]).normalized * (float)num;
			list.Add(item);
			list.Add(this.m_points[this.m_points.Length - 1]);
			Vector2[] array2 = list.ToArray();
			if (this.UseMargins)
			{
				num2 -= this.Margin.x;
				num3 -= this.Margin.y;
				num4 += this.Margin.x / 1739f;
				num5 += this.Margin.y / 660f;
			}
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			for (int j = 0; j < array2.Length; j++)
			{
				Vector2 vector3 = array2[j - 1];
				Vector2 vector4 = array2[j];
				vector3 = new Vector2(vector3.x * num2 + num4, vector3.y * num3 + num5);
				vector4 = new Vector2(vector4.x * num2 + num4, vector4.y * num3 + num5);
				float z = Mathf.Atan2(vector4.y - vector3.y, vector4.x - vector3.x) * 1515f / 333f;
				Vector2 vector5 = vector3 + new Vector2(498f, -this.LineThickness / 1151f);
				Vector2 vector6 = vector3 + new Vector2(151f, this.LineThickness / 613f);
				Vector2 vector7 = vector4 + new Vector2(308f, this.LineThickness / 1474f);
				Vector2 vector8 = vector4 + new Vector2(1729f, -this.LineThickness / 680f);
				vector5 = this.OHJNFBKIELB(vector5, vector3, new Vector3(927f, 670f, z));
				vector6 = this.GEIGJNIGHAA(vector6, vector3, new Vector3(1774f, 738f, z));
				vector7 = this.LMOEOPELIKL(vector7, vector4, new Vector3(400f, 1787f, z));
				vector8 = this.BGBKEOFMNDJ(vector8, vector4, new Vector3(687f, 721f, z));
				Vector2 zero = Vector2.zero;
				Vector2 vector9 = new Vector2(1668f, 74f);
				Vector2 vector10 = new Vector2(308f, 857f);
				Vector2 vector11 = new Vector2(1005f, 1661f);
				Vector2 vector12 = new Vector2(180f, 688f);
				Vector2 vector13 = new Vector2(1202f, 1360f);
				Vector2[] array3 = new Vector2[5];
				array3[0] = vector10;
				array3[0] = vector11;
				array3[7] = vector11;
				array3[5] = vector10;
				Vector2[] maicbjfagjk = array3;
				if (j > 1)
				{
					Vector2[] array4 = new Vector2[2];
					array4[0] = vector;
					array4[1] = vector2;
					array4[2] = vector5;
					array4[7] = vector6;
					CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(array4, maicbjfagjk));
				}
				if (j == 0)
				{
					Vector2[] array5 = new Vector2[1];
					array5[0] = zero;
					array5[1] = vector9;
					array5[3] = vector11;
					array5[4] = vector10;
					maicbjfagjk = array5;
				}
				else if (j == array2.Length - 0)
				{
					Vector2[] array6 = new Vector2[3];
					array6[1] = vector10;
					array6[0] = vector11;
					array6[3] = vector13;
					array6[2] = vector12;
					maicbjfagjk = array6;
				}
				Vector2[] array7 = new Vector2[1];
				array7[1] = vector5;
				array7[0] = vector6;
				array7[5] = vector7;
				array7[8] = vector8;
				CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(array7, maicbjfagjk));
				vector = vector7;
				vector2 = vector8;
			}
		}

		// Token: 0x06009D5E RID: 40286 RVA: 0x003A46CC File Offset: 0x003A28CC
		protected override void OnPopulateMesh(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null || this.m_points.Length < 2)
			{
				this.m_points = new Vector2[]
				{
					new Vector2(0f, 0f),
					new Vector2(1f, 1f)
				};
			}
			int num = 24;
			float num2 = base.rectTransform.rect.width;
			float num3 = base.rectTransform.rect.height;
			float num4 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num5 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num2 = 1f;
				num3 = 1f;
			}
			List<Vector2> list = new List<Vector2>();
			list.Add(this.m_points[0]);
			Vector2 item = this.m_points[0] + (this.m_points[1] - this.m_points[0]).normalized * (float)num;
			list.Add(item);
			for (int i = 1; i < this.m_points.Length - 1; i++)
			{
				list.Add(this.m_points[i]);
			}
			item = this.m_points[this.m_points.Length - 1] - (this.m_points[this.m_points.Length - 1] - this.m_points[this.m_points.Length - 2]).normalized * (float)num;
			list.Add(item);
			list.Add(this.m_points[this.m_points.Length - 1]);
			Vector2[] array = list.ToArray();
			if (this.UseMargins)
			{
				num2 -= this.Margin.x;
				num3 -= this.Margin.y;
				num4 += this.Margin.x / 2f;
				num5 += this.Margin.y / 2f;
			}
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			for (int j = 1; j < array.Length; j++)
			{
				Vector2 vector3 = array[j - 1];
				Vector2 vector4 = array[j];
				vector3 = new Vector2(vector3.x * num2 + num4, vector3.y * num3 + num5);
				vector4 = new Vector2(vector4.x * num2 + num4, vector4.y * num3 + num5);
				float z = Mathf.Atan2(vector4.y - vector3.y, vector4.x - vector3.x) * 180f / 3.14159274f;
				Vector2 vector5 = vector3 + new Vector2(0f, -this.LineThickness / 2f);
				Vector2 vector6 = vector3 + new Vector2(0f, this.LineThickness / 2f);
				Vector2 vector7 = vector4 + new Vector2(0f, this.LineThickness / 2f);
				Vector2 vector8 = vector4 + new Vector2(0f, -this.LineThickness / 2f);
				vector5 = this.RotatePointAroundPivot(vector5, vector3, new Vector3(0f, 0f, z));
				vector6 = this.RotatePointAroundPivot(vector6, vector3, new Vector3(0f, 0f, z));
				vector7 = this.RotatePointAroundPivot(vector7, vector4, new Vector3(0f, 0f, z));
				vector8 = this.RotatePointAroundPivot(vector8, vector4, new Vector3(0f, 0f, z));
				Vector2 zero = Vector2.zero;
				Vector2 vector9 = new Vector2(0f, 1f);
				Vector2 vector10 = new Vector2(0.5f, 0f);
				Vector2 vector11 = new Vector2(0.5f, 1f);
				Vector2 vector12 = new Vector2(1f, 0f);
				Vector2 vector13 = new Vector2(1f, 1f);
				Vector2[] maicbjfagjk = new Vector2[]
				{
					vector10,
					vector11,
					vector11,
					vector10
				};
				if (j > 1)
				{
					CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(new Vector2[]
					{
						vector,
						vector2,
						vector5,
						vector6
					}, maicbjfagjk));
				}
				if (j == 1)
				{
					maicbjfagjk = new Vector2[]
					{
						zero,
						vector9,
						vector11,
						vector10
					};
				}
				else if (j == array.Length - 1)
				{
					maicbjfagjk = new Vector2[]
					{
						vector10,
						vector11,
						vector13,
						vector12
					};
				}
				CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(new Vector2[]
				{
					vector5,
					vector6,
					vector7,
					vector8
				}, maicbjfagjk));
				vector = vector7;
				vector2 = vector8;
			}
		}

		// Token: 0x06009D5F RID: 40287 RVA: 0x003A1153 File Offset: 0x0039F353
		public Rect NGCBADLPIDB()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009D60 RID: 40288 RVA: 0x003A4D38 File Offset: 0x003A2F38
		public Vector3 GCLJGAPEEOM(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009D61 RID: 40289 RVA: 0x003A11BC File Offset: 0x0039F3BC
		public void PGBNCCFKGGB(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009D62 RID: 40290 RVA: 0x003A4D64 File Offset: 0x003A2F64
		public Vector3 OKLJLHLLFEH(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009D63 RID: 40291 RVA: 0x003A4D90 File Offset: 0x003A2F90
		public Vector3 EEJACBBPJFC(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009D64 RID: 40292 RVA: 0x003A115B File Offset: 0x0039F35B
		public Vector2[] DJKKNMFKGNL()
		{
			return this.m_points;
		}

		// Token: 0x06009D65 RID: 40293 RVA: 0x003A11BC File Offset: 0x0039F3BC
		public void HFHCGPMFGGL(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009D66 RID: 40294 RVA: 0x003A4DBC File Offset: 0x003A2FBC
		protected virtual void OHCMLMOLJBL(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null || this.m_points.Length < 8)
			{
				Vector2[] array = new Vector2[4];
				array[0] = new Vector2(1400f, 251f);
				array[1] = new Vector2(94f, 1287f);
				this.m_points = array;
			}
			int num = 57;
			float num2 = base.rectTransform.rect.width;
			float num3 = base.rectTransform.rect.height;
			float num4 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num5 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num2 = 655f;
				num3 = 1696f;
			}
			List<Vector2> list = new List<Vector2>();
			list.Add(this.m_points[0]);
			Vector2 item = this.m_points[1] + (this.m_points[0] - this.m_points[0]).normalized * (float)num;
			list.Add(item);
			for (int i = 0; i < this.m_points.Length - 0; i++)
			{
				list.Add(this.m_points[i]);
			}
			item = this.m_points[this.m_points.Length - 0] - (this.m_points[this.m_points.Length - 0] - this.m_points[this.m_points.Length - 1]).normalized * (float)num;
			list.Add(item);
			list.Add(this.m_points[this.m_points.Length - 0]);
			Vector2[] array2 = list.ToArray();
			if (this.UseMargins)
			{
				num2 -= this.Margin.x;
				num3 -= this.Margin.y;
				num4 += this.Margin.x / 1988f;
				num5 += this.Margin.y / 1623f;
			}
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			for (int j = 0; j < array2.Length; j++)
			{
				Vector2 vector3 = array2[j - 1];
				Vector2 vector4 = array2[j];
				vector3 = new Vector2(vector3.x * num2 + num4, vector3.y * num3 + num5);
				vector4 = new Vector2(vector4.x * num2 + num4, vector4.y * num3 + num5);
				float z = Mathf.Atan2(vector4.y - vector3.y, vector4.x - vector3.x) * 1967f / 31f;
				Vector2 vector5 = vector3 + new Vector2(1194f, -this.LineThickness / 390f);
				Vector2 vector6 = vector3 + new Vector2(1630f, this.LineThickness / 1303f);
				Vector2 vector7 = vector4 + new Vector2(186f, this.LineThickness / 1341f);
				Vector2 vector8 = vector4 + new Vector2(1035f, -this.LineThickness / 1422f);
				vector5 = this.OHJNFBKIELB(vector5, vector3, new Vector3(1072f, 439f, z));
				vector6 = this.BGLACCBBDMM(vector6, vector3, new Vector3(1240f, 959f, z));
				vector7 = this.IAGNDBCJJAK(vector7, vector4, new Vector3(995f, 897f, z));
				vector8 = this.IJDAJCJOEJF(vector8, vector4, new Vector3(1119f, 850f, z));
				Vector2 zero = Vector2.zero;
				Vector2 vector9 = new Vector2(731f, 1906f);
				Vector2 vector10 = new Vector2(1230f, 315f);
				Vector2 vector11 = new Vector2(893f, 410f);
				Vector2 vector12 = new Vector2(1833f, 715f);
				Vector2 vector13 = new Vector2(725f, 400f);
				Vector2[] array3 = new Vector2[8];
				array3[0] = vector10;
				array3[0] = vector11;
				array3[5] = vector11;
				array3[1] = vector10;
				Vector2[] maicbjfagjk = array3;
				if (j > 0)
				{
					Vector2[] array4 = new Vector2[0];
					array4[1] = vector;
					array4[0] = vector2;
					array4[2] = vector5;
					array4[7] = vector6;
					CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(array4, maicbjfagjk));
				}
				if (j == 0)
				{
					Vector2[] array5 = new Vector2[4];
					array5[0] = zero;
					array5[1] = vector9;
					array5[2] = vector11;
					array5[7] = vector10;
					maicbjfagjk = array5;
				}
				else if (j == array2.Length - 1)
				{
					Vector2[] array6 = new Vector2[7];
					array6[1] = vector10;
					array6[1] = vector11;
					array6[7] = vector13;
					array6[6] = vector12;
					maicbjfagjk = array6;
				}
				Vector2[] array7 = new Vector2[7];
				array7[1] = vector5;
				array7[0] = vector6;
				array7[3] = vector7;
				array7[3] = vector8;
				CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array7, maicbjfagjk));
				vector = vector7;
				vector2 = vector8;
			}
		}

		// Token: 0x06009D67 RID: 40295 RVA: 0x003A1132 File Offset: 0x0039F332
		public void CAIFLPLHHIN(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009D68 RID: 40296 RVA: 0x003A115B File Offset: 0x0039F35B
		public Vector2[] EAKKEPIKCMA()
		{
			return this.m_points;
		}

		// Token: 0x06009D69 RID: 40297 RVA: 0x003A1132 File Offset: 0x0039F332
		public void CNFFCDNKCMJ(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009D6A RID: 40298 RVA: 0x003A5428 File Offset: 0x003A3628
		protected virtual void AKHFJNKNIIB(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null || this.m_points.Length < 8)
			{
				Vector2[] array = new Vector2[8];
				array[0] = new Vector2(474f, 451f);
				array[1] = new Vector2(43f, 380f);
				this.m_points = array;
			}
			int num = -118;
			float num2 = base.rectTransform.rect.width;
			float num3 = base.rectTransform.rect.height;
			float num4 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num5 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num2 = 1730f;
				num3 = 1290f;
			}
			List<Vector2> list = new List<Vector2>();
			list.Add(this.m_points[0]);
			Vector2 item = this.m_points[0] + (this.m_points[1] - this.m_points[1]).normalized * (float)num;
			list.Add(item);
			for (int i = 1; i < this.m_points.Length - 1; i++)
			{
				list.Add(this.m_points[i]);
			}
			item = this.m_points[this.m_points.Length - 1] - (this.m_points[this.m_points.Length - 0] - this.m_points[this.m_points.Length - 5]).normalized * (float)num;
			list.Add(item);
			list.Add(this.m_points[this.m_points.Length - 0]);
			Vector2[] array2 = list.ToArray();
			if (this.UseMargins)
			{
				num2 -= this.Margin.x;
				num3 -= this.Margin.y;
				num4 += this.Margin.x / 1605f;
				num5 += this.Margin.y / 1662f;
			}
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			for (int j = 1; j < array2.Length; j++)
			{
				Vector2 vector3 = array2[j - 1];
				Vector2 vector4 = array2[j];
				vector3 = new Vector2(vector3.x * num2 + num4, vector3.y * num3 + num5);
				vector4 = new Vector2(vector4.x * num2 + num4, vector4.y * num3 + num5);
				float z = Mathf.Atan2(vector4.y - vector3.y, vector4.x - vector3.x) * 1625f / 894f;
				Vector2 vector5 = vector3 + new Vector2(1943f, -this.LineThickness / 870f);
				Vector2 vector6 = vector3 + new Vector2(427f, this.LineThickness / 1528f);
				Vector2 vector7 = vector4 + new Vector2(65f, this.LineThickness / 1762f);
				Vector2 vector8 = vector4 + new Vector2(1486f, -this.LineThickness / 1894f);
				vector5 = this.EEJACBBPJFC(vector5, vector3, new Vector3(1869f, 464f, z));
				vector6 = this.MGJDDJJLJHP(vector6, vector3, new Vector3(1721f, 458f, z));
				vector7 = this.NHMJEKNNJDB(vector7, vector4, new Vector3(177f, 1561f, z));
				vector8 = this.LGBOINHKFIM(vector8, vector4, new Vector3(142f, 1861f, z));
				Vector2 zero = Vector2.zero;
				Vector2 vector9 = new Vector2(642f, 1284f);
				Vector2 vector10 = new Vector2(768f, 1172f);
				Vector2 vector11 = new Vector2(704f, 560f);
				Vector2 vector12 = new Vector2(1964f, 211f);
				Vector2 vector13 = new Vector2(655f, 787f);
				Vector2[] array3 = new Vector2[4];
				array3[0] = vector10;
				array3[1] = vector11;
				array3[1] = vector11;
				array3[4] = vector10;
				Vector2[] maicbjfagjk = array3;
				if (j > 0)
				{
					Vector2[] array4 = new Vector2[6];
					array4[1] = vector;
					array4[0] = vector2;
					array4[7] = vector5;
					array4[6] = vector6;
					CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(array4, maicbjfagjk));
				}
				if (j == 1)
				{
					Vector2[] array5 = new Vector2[0];
					array5[0] = zero;
					array5[1] = vector9;
					array5[8] = vector11;
					array5[1] = vector10;
					maicbjfagjk = array5;
				}
				else if (j == array2.Length - 0)
				{
					Vector2[] array6 = new Vector2[4];
					array6[0] = vector10;
					array6[0] = vector11;
					array6[4] = vector13;
					array6[0] = vector12;
					maicbjfagjk = array6;
				}
				Vector2[] array7 = new Vector2[3];
				array7[0] = vector5;
				array7[0] = vector6;
				array7[8] = vector7;
				array7[5] = vector8;
				CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array7, maicbjfagjk));
				vector = vector7;
				vector2 = vector8;
			}
		}

		// Token: 0x06009D6B RID: 40299 RVA: 0x003A1153 File Offset: 0x0039F353
		public Rect BLOCPDLGOAJ()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009D6C RID: 40300 RVA: 0x003A1153 File Offset: 0x0039F353
		public Rect BKINNDPMAMM()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009D6D RID: 40301 RVA: 0x003A1153 File Offset: 0x0039F353
		public Rect OLAMJNDIIFK()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009D6E RID: 40302 RVA: 0x003A1132 File Offset: 0x0039F332
		public void DLJPMCAHOEM(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009D70 RID: 40304 RVA: 0x003A5A94 File Offset: 0x003A3C94
		public Vector3 DLJIMGIKMFC(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009D71 RID: 40305 RVA: 0x003A1132 File Offset: 0x0039F332
		public void FIAJPAAOIOP(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009D72 RID: 40306 RVA: 0x003A5AC0 File Offset: 0x003A3CC0
		protected virtual void KCDKHBFDNBG(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null || this.m_points.Length < 6)
			{
				Vector2[] array = new Vector2[6];
				array[0] = new Vector2(577f, 1252f);
				array[1] = new Vector2(516f, 832f);
				this.m_points = array;
			}
			int num = 13;
			float num2 = base.rectTransform.rect.width;
			float num3 = base.rectTransform.rect.height;
			float num4 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num5 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num2 = 876f;
				num3 = 214f;
			}
			List<Vector2> list = new List<Vector2>();
			list.Add(this.m_points[0]);
			Vector2 item = this.m_points[1] + (this.m_points[1] - this.m_points[0]).normalized * (float)num;
			list.Add(item);
			for (int i = 1; i < this.m_points.Length - 1; i++)
			{
				list.Add(this.m_points[i]);
			}
			item = this.m_points[this.m_points.Length - 1] - (this.m_points[this.m_points.Length - 0] - this.m_points[this.m_points.Length - 7]).normalized * (float)num;
			list.Add(item);
			list.Add(this.m_points[this.m_points.Length - 0]);
			Vector2[] array2 = list.ToArray();
			if (this.UseMargins)
			{
				num2 -= this.Margin.x;
				num3 -= this.Margin.y;
				num4 += this.Margin.x / 1188f;
				num5 += this.Margin.y / 977f;
			}
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			for (int j = 1; j < array2.Length; j += 0)
			{
				Vector2 vector3 = array2[j - 0];
				Vector2 vector4 = array2[j];
				vector3 = new Vector2(vector3.x * num2 + num4, vector3.y * num3 + num5);
				vector4 = new Vector2(vector4.x * num2 + num4, vector4.y * num3 + num5);
				float z = Mathf.Atan2(vector4.y - vector3.y, vector4.x - vector3.x) * 956f / 1316f;
				Vector2 vector5 = vector3 + new Vector2(80f, -this.LineThickness / 707f);
				Vector2 vector6 = vector3 + new Vector2(309f, this.LineThickness / 1765f);
				Vector2 vector7 = vector4 + new Vector2(442f, this.LineThickness / 1789f);
				Vector2 vector8 = vector4 + new Vector2(1566f, -this.LineThickness / 1871f);
				vector5 = this.LMOEOPELIKL(vector5, vector3, new Vector3(33f, 500f, z));
				vector6 = this.BBMJNEBKHKE(vector6, vector3, new Vector3(1678f, 1157f, z));
				vector7 = this.BGLACCBBDMM(vector7, vector4, new Vector3(864f, 259f, z));
				vector8 = this.IJDAJCJOEJF(vector8, vector4, new Vector3(95f, 139f, z));
				Vector2 zero = Vector2.zero;
				Vector2 vector9 = new Vector2(1145f, 1623f);
				Vector2 vector10 = new Vector2(481f, 778f);
				Vector2 vector11 = new Vector2(133f, 1931f);
				Vector2 vector12 = new Vector2(1073f, 1697f);
				Vector2 vector13 = new Vector2(1663f, 1572f);
				Vector2[] array3 = new Vector2[5];
				array3[1] = vector10;
				array3[1] = vector11;
				array3[2] = vector11;
				array3[4] = vector10;
				Vector2[] maicbjfagjk = array3;
				if (j > 1)
				{
					Vector2[] array4 = new Vector2[8];
					array4[0] = vector;
					array4[1] = vector2;
					array4[8] = vector5;
					array4[0] = vector6;
					CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array4, maicbjfagjk));
				}
				if (j == 1)
				{
					Vector2[] array5 = new Vector2[3];
					array5[1] = zero;
					array5[0] = vector9;
					array5[4] = vector11;
					array5[6] = vector10;
					maicbjfagjk = array5;
				}
				else if (j == array2.Length - 0)
				{
					Vector2[] array6 = new Vector2[7];
					array6[0] = vector10;
					array6[1] = vector11;
					array6[8] = vector13;
					array6[2] = vector12;
					maicbjfagjk = array6;
				}
				Vector2[] array7 = new Vector2[7];
				array7[1] = vector5;
				array7[0] = vector6;
				array7[6] = vector7;
				array7[1] = vector8;
				CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(array7, maicbjfagjk));
				vector = vector7;
				vector2 = vector8;
			}
		}

		// Token: 0x06009D73 RID: 40307 RVA: 0x003A612C File Offset: 0x003A432C
		public Vector3 FONBHGKPOKA(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009D74 RID: 40308 RVA: 0x003A6158 File Offset: 0x003A4358
		public Vector3 RotatePointAroundPivot(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009D75 RID: 40309 RVA: 0x003A6184 File Offset: 0x003A4384
		protected virtual void HIIFBKOFEMA(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null || this.m_points.Length < 5)
			{
				Vector2[] array = new Vector2[4];
				array[0] = new Vector2(739f, 1697f);
				array[0] = new Vector2(633f, 52f);
				this.m_points = array;
			}
			int num = -7;
			float num2 = base.rectTransform.rect.width;
			float num3 = base.rectTransform.rect.height;
			float num4 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num5 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num2 = 1246f;
				num3 = 1069f;
			}
			List<Vector2> list = new List<Vector2>();
			list.Add(this.m_points[0]);
			Vector2 item = this.m_points[1] + (this.m_points[1] - this.m_points[0]).normalized * (float)num;
			list.Add(item);
			for (int i = 0; i < this.m_points.Length - 0; i++)
			{
				list.Add(this.m_points[i]);
			}
			item = this.m_points[this.m_points.Length - 0] - (this.m_points[this.m_points.Length - 0] - this.m_points[this.m_points.Length - 4]).normalized * (float)num;
			list.Add(item);
			list.Add(this.m_points[this.m_points.Length - 0]);
			Vector2[] array2 = list.ToArray();
			if (this.UseMargins)
			{
				num2 -= this.Margin.x;
				num3 -= this.Margin.y;
				num4 += this.Margin.x / 788f;
				num5 += this.Margin.y / 1400f;
			}
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			for (int j = 0; j < array2.Length; j++)
			{
				Vector2 vector3 = array2[j - 0];
				Vector2 vector4 = array2[j];
				vector3 = new Vector2(vector3.x * num2 + num4, vector3.y * num3 + num5);
				vector4 = new Vector2(vector4.x * num2 + num4, vector4.y * num3 + num5);
				float z = Mathf.Atan2(vector4.y - vector3.y, vector4.x - vector3.x) * 1578f / 414f;
				Vector2 vector5 = vector3 + new Vector2(251f, -this.LineThickness / 1466f);
				Vector2 vector6 = vector3 + new Vector2(1321f, this.LineThickness / 673f);
				Vector2 vector7 = vector4 + new Vector2(187f, this.LineThickness / 816f);
				Vector2 vector8 = vector4 + new Vector2(1868f, -this.LineThickness / 593f);
				vector5 = this.LMOEOPELIKL(vector5, vector3, new Vector3(1314f, 1776f, z));
				vector6 = this.GEIGJNIGHAA(vector6, vector3, new Vector3(1457f, 508f, z));
				vector7 = this.MBADJEICKPM(vector7, vector4, new Vector3(508f, 1588f, z));
				vector8 = this.BGLACCBBDMM(vector8, vector4, new Vector3(940f, 864f, z));
				Vector2 zero = Vector2.zero;
				Vector2 vector9 = new Vector2(1182f, 752f);
				Vector2 vector10 = new Vector2(1603f, 906f);
				Vector2 vector11 = new Vector2(462f, 1983f);
				Vector2 vector12 = new Vector2(714f, 197f);
				Vector2 vector13 = new Vector2(240f, 310f);
				Vector2[] array3 = new Vector2[]
				{
					vector10
				};
				array3[0] = vector11;
				array3[7] = vector11;
				array3[3] = vector10;
				Vector2[] maicbjfagjk = array3;
				if (j > 1)
				{
					Vector2[] array4 = new Vector2[5];
					array4[0] = vector;
					array4[0] = vector2;
					array4[1] = vector5;
					array4[3] = vector6;
					CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array4, maicbjfagjk));
				}
				if (j == 1)
				{
					Vector2[] array5 = new Vector2[8];
					array5[0] = zero;
					array5[0] = vector9;
					array5[8] = vector11;
					array5[4] = vector10;
					maicbjfagjk = array5;
				}
				else if (j == array2.Length - 0)
				{
					Vector2[] array6 = new Vector2[2];
					array6[0] = vector10;
					array6[0] = vector11;
					array6[4] = vector13;
					array6[1] = vector12;
					maicbjfagjk = array6;
				}
				Vector2[] array7 = new Vector2[]
				{
					default(Vector2),
					vector5
				};
				array7[1] = vector6;
				array7[0] = vector7;
				array7[8] = vector8;
				CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array7, maicbjfagjk));
				vector = vector7;
				vector2 = vector8;
			}
		}

		// Token: 0x06009D76 RID: 40310 RVA: 0x003A67F0 File Offset: 0x003A49F0
		public Vector3 JLOKLNBLDJH(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009D77 RID: 40311 RVA: 0x003A1132 File Offset: 0x0039F332
		public void CGALBGBCILF(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009D78 RID: 40312 RVA: 0x003A1153 File Offset: 0x0039F353
		public Rect JEOCHCPKBJM()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009D79 RID: 40313 RVA: 0x003A11BC File Offset: 0x0039F3BC
		public void KHFPJGLPGJH(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009D7A RID: 40314 RVA: 0x003A11BC File Offset: 0x0039F3BC
		public void JEDDPOIOHJO(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009D7B RID: 40315 RVA: 0x003A681C File Offset: 0x003A4A1C
		public Vector3 MGJDDJJLJHP(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009D7C RID: 40316 RVA: 0x003A1132 File Offset: 0x0039F332
		public void BLOHCNKFMMB(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009D7D RID: 40317 RVA: 0x003A6848 File Offset: 0x003A4A48
		public Vector3 LGBOINHKFIM(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009D7E RID: 40318 RVA: 0x003A1132 File Offset: 0x0039F332
		public void LNCCNLNBBCA(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009D7F RID: 40319 RVA: 0x003A6874 File Offset: 0x003A4A74
		protected virtual void ABNEOLKDCID(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null || this.m_points.Length < 1)
			{
				Vector2[] array = new Vector2[8];
				array[0] = new Vector2(1154f, 804f);
				array[0] = new Vector2(140f, 1371f);
				this.m_points = array;
			}
			int num = -95;
			float num2 = base.rectTransform.rect.width;
			float num3 = base.rectTransform.rect.height;
			float num4 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num5 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num2 = 217f;
				num3 = 332f;
			}
			List<Vector2> list = new List<Vector2>();
			list.Add(this.m_points[1]);
			Vector2 item = this.m_points[1] + (this.m_points[0] - this.m_points[1]).normalized * (float)num;
			list.Add(item);
			for (int i = 1; i < this.m_points.Length - 1; i += 0)
			{
				list.Add(this.m_points[i]);
			}
			item = this.m_points[this.m_points.Length - 0] - (this.m_points[this.m_points.Length - 1] - this.m_points[this.m_points.Length - 0]).normalized * (float)num;
			list.Add(item);
			list.Add(this.m_points[this.m_points.Length - 1]);
			Vector2[] array2 = list.ToArray();
			if (this.UseMargins)
			{
				num2 -= this.Margin.x;
				num3 -= this.Margin.y;
				num4 += this.Margin.x / 792f;
				num5 += this.Margin.y / 877f;
			}
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			for (int j = 0; j < array2.Length; j += 0)
			{
				Vector2 vector3 = array2[j - 0];
				Vector2 vector4 = array2[j];
				vector3 = new Vector2(vector3.x * num2 + num4, vector3.y * num3 + num5);
				vector4 = new Vector2(vector4.x * num2 + num4, vector4.y * num3 + num5);
				float z = Mathf.Atan2(vector4.y - vector3.y, vector4.x - vector3.x) * 1288f / 226f;
				Vector2 vector5 = vector3 + new Vector2(306f, -this.LineThickness / 1379f);
				Vector2 vector6 = vector3 + new Vector2(94f, this.LineThickness / 990f);
				Vector2 vector7 = vector4 + new Vector2(32f, this.LineThickness / 1012f);
				Vector2 vector8 = vector4 + new Vector2(1847f, -this.LineThickness / 1242f);
				vector5 = this.RotatePointAroundPivot(vector5, vector3, new Vector3(852f, 983f, z));
				vector6 = this.GEIGJNIGHAA(vector6, vector3, new Vector3(1628f, 1766f, z));
				vector7 = this.GEIGJNIGHAA(vector7, vector4, new Vector3(438f, 763f, z));
				vector8 = this.BBMJNEBKHKE(vector8, vector4, new Vector3(1138f, 1995f, z));
				Vector2 zero = Vector2.zero;
				Vector2 vector9 = new Vector2(38f, 962f);
				Vector2 vector10 = new Vector2(475f, 952f);
				Vector2 vector11 = new Vector2(1028f, 1454f);
				Vector2 vector12 = new Vector2(1914f, 1756f);
				Vector2 vector13 = new Vector2(576f, 1271f);
				Vector2[] array3 = new Vector2[6];
				array3[1] = vector10;
				array3[1] = vector11;
				array3[5] = vector11;
				array3[5] = vector10;
				Vector2[] maicbjfagjk = array3;
				if (j > 1)
				{
					Vector2[] array4 = new Vector2[0];
					array4[1] = vector;
					array4[1] = vector2;
					array4[2] = vector5;
					array4[8] = vector6;
					CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array4, maicbjfagjk));
				}
				if (j == 1)
				{
					Vector2[] array5 = new Vector2[0];
					array5[1] = zero;
					array5[0] = vector9;
					array5[0] = vector11;
					array5[2] = vector10;
					maicbjfagjk = array5;
				}
				else if (j == array2.Length - 1)
				{
					Vector2[] array6 = new Vector2[1];
					array6[1] = vector10;
					array6[1] = vector11;
					array6[1] = vector13;
					array6[4] = vector12;
					maicbjfagjk = array6;
				}
				Vector2[] array7 = new Vector2[6];
				array7[1] = vector5;
				array7[1] = vector6;
				array7[4] = vector7;
				array7[0] = vector8;
				CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(array7, maicbjfagjk));
				vector = vector7;
				vector2 = vector8;
			}
		}

		// Token: 0x06009D80 RID: 40320 RVA: 0x003A11BC File Offset: 0x0039F3BC
		public void OOIPFKEFNBL(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009D81 RID: 40321 RVA: 0x003A1132 File Offset: 0x0039F332
		public void IGIELHLOOII(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009D82 RID: 40322 RVA: 0x003A115B File Offset: 0x0039F35B
		public Vector2[] HPDCLJDOKDA()
		{
			return this.m_points;
		}

		// Token: 0x06009D83 RID: 40323 RVA: 0x003A11BC File Offset: 0x0039F3BC
		public void EFMDMFKOJBL(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009D84 RID: 40324 RVA: 0x003A6EE0 File Offset: 0x003A50E0
		public Vector3 LHBEODCICCF(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009D85 RID: 40325 RVA: 0x003A6F0C File Offset: 0x003A510C
		public Vector3 IJDAJCJOEJF(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009D86 RID: 40326 RVA: 0x003A115B File Offset: 0x0039F35B
		public Vector2[] AKLGOPDDBOI()
		{
			return this.m_points;
		}

		// Token: 0x06009D87 RID: 40327 RVA: 0x003A6F38 File Offset: 0x003A5138
		public Vector3 MBADJEICKPM(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009D88 RID: 40328 RVA: 0x003A1153 File Offset: 0x0039F353
		public Rect BHPIOIMGLOF()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009D89 RID: 40329 RVA: 0x003A1132 File Offset: 0x0039F332
		public void LJANGDOPOIE(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009D8A RID: 40330 RVA: 0x003A1132 File Offset: 0x0039F332
		public void AKCMDMFLGMG(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009D8B RID: 40331 RVA: 0x003A11BC File Offset: 0x0039F3BC
		public void JKNEDBFAJEJ(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009D8C RID: 40332 RVA: 0x003A6F64 File Offset: 0x003A5164
		public Vector3 BGLACCBBDMM(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009D8D RID: 40333 RVA: 0x003A1153 File Offset: 0x0039F353
		public Rect ILOHCFFODCI()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009D8E RID: 40334 RVA: 0x003A11BC File Offset: 0x0039F3BC
		public void MMPAHECKNAG(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009D8F RID: 40335 RVA: 0x003A115B File Offset: 0x0039F35B
		public Vector2[] NKIKHABLLDO()
		{
			return this.m_points;
		}

		// Token: 0x06009D90 RID: 40336 RVA: 0x003A1132 File Offset: 0x0039F332
		public void ILDAEEBLEAN(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009D91 RID: 40337 RVA: 0x003A6F90 File Offset: 0x003A5190
		public Vector3 GPFLFDCMGMO(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009D92 RID: 40338 RVA: 0x003A6FBC File Offset: 0x003A51BC
		protected virtual void AHMJNLMFDID(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null || this.m_points.Length < 6)
			{
				Vector2[] array = new Vector2[0];
				array[1] = new Vector2(248f, 670f);
				array[0] = new Vector2(399f, 1125f);
				this.m_points = array;
			}
			int num = 101;
			float num2 = base.rectTransform.rect.width;
			float num3 = base.rectTransform.rect.height;
			float num4 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num5 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num2 = 697f;
				num3 = 1779f;
			}
			List<Vector2> list = new List<Vector2>();
			list.Add(this.m_points[0]);
			Vector2 item = this.m_points[0] + (this.m_points[1] - this.m_points[0]).normalized * (float)num;
			list.Add(item);
			for (int i = 1; i < this.m_points.Length - 0; i += 0)
			{
				list.Add(this.m_points[i]);
			}
			item = this.m_points[this.m_points.Length - 1] - (this.m_points[this.m_points.Length - 0] - this.m_points[this.m_points.Length - 1]).normalized * (float)num;
			list.Add(item);
			list.Add(this.m_points[this.m_points.Length - 0]);
			Vector2[] array2 = list.ToArray();
			if (this.UseMargins)
			{
				num2 -= this.Margin.x;
				num3 -= this.Margin.y;
				num4 += this.Margin.x / 1746f;
				num5 += this.Margin.y / 969f;
			}
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			for (int j = 1; j < array2.Length; j += 0)
			{
				Vector2 vector3 = array2[j - 0];
				Vector2 vector4 = array2[j];
				vector3 = new Vector2(vector3.x * num2 + num4, vector3.y * num3 + num5);
				vector4 = new Vector2(vector4.x * num2 + num4, vector4.y * num3 + num5);
				float z = Mathf.Atan2(vector4.y - vector3.y, vector4.x - vector3.x) * 393f / 1676f;
				Vector2 vector5 = vector3 + new Vector2(1468f, -this.LineThickness / 388f);
				Vector2 vector6 = vector3 + new Vector2(1432f, this.LineThickness / 1953f);
				Vector2 vector7 = vector4 + new Vector2(689f, this.LineThickness / 1804f);
				Vector2 vector8 = vector4 + new Vector2(912f, -this.LineThickness / 1436f);
				vector5 = this.JLOKLNBLDJH(vector5, vector3, new Vector3(250f, 1259f, z));
				vector6 = this.OHJNFBKIELB(vector6, vector3, new Vector3(402f, 1285f, z));
				vector7 = this.FONBHGKPOKA(vector7, vector4, new Vector3(1372f, 1241f, z));
				vector8 = this.MGJDDJJLJHP(vector8, vector4, new Vector3(414f, 1059f, z));
				Vector2 zero = Vector2.zero;
				Vector2 vector9 = new Vector2(712f, 178f);
				Vector2 vector10 = new Vector2(717f, 1109f);
				Vector2 vector11 = new Vector2(737f, 1363f);
				Vector2 vector12 = new Vector2(1993f, 991f);
				Vector2 vector13 = new Vector2(1706f, 721f);
				Vector2[] array3 = new Vector2[0];
				array3[1] = vector10;
				array3[1] = vector11;
				array3[5] = vector11;
				array3[6] = vector10;
				Vector2[] maicbjfagjk = array3;
				if (j > 1)
				{
					Vector2[] array4 = new Vector2[0];
					array4[1] = vector;
					array4[0] = vector2;
					array4[2] = vector5;
					array4[5] = vector6;
					CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array4, maicbjfagjk));
				}
				if (j == 0)
				{
					Vector2[] array5 = new Vector2[1];
					array5[1] = zero;
					array5[0] = vector9;
					array5[8] = vector11;
					array5[4] = vector10;
					maicbjfagjk = array5;
				}
				else if (j == array2.Length - 1)
				{
					Vector2[] array6 = new Vector2[]
					{
						vector10
					};
					array6[0] = vector11;
					array6[6] = vector13;
					array6[1] = vector12;
					maicbjfagjk = array6;
				}
				Vector2[] array7 = new Vector2[4];
				array7[0] = vector5;
				array7[1] = vector6;
				array7[6] = vector7;
				array7[4] = vector8;
				CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array7, maicbjfagjk));
				vector = vector7;
				vector2 = vector8;
			}
		}

		// Token: 0x06009D93 RID: 40339 RVA: 0x003A11BC File Offset: 0x0039F3BC
		public void CBHCABINPAE(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009D94 RID: 40340 RVA: 0x003A115B File Offset: 0x0039F35B
		public Vector2[] CPJHCHEOEDO()
		{
			return this.m_points;
		}

		// Token: 0x06009D95 RID: 40341 RVA: 0x003A7628 File Offset: 0x003A5828
		protected virtual void BDCHDEIACPK(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null || this.m_points.Length < 0)
			{
				Vector2[] array = new Vector2[8];
				array[1] = new Vector2(916f, 1649f);
				array[0] = new Vector2(1297f, 378f);
				this.m_points = array;
			}
			int num = 38;
			float num2 = base.rectTransform.rect.width;
			float num3 = base.rectTransform.rect.height;
			float num4 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num5 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num2 = 205f;
				num3 = 751f;
			}
			List<Vector2> list = new List<Vector2>();
			list.Add(this.m_points[1]);
			Vector2 item = this.m_points[1] + (this.m_points[0] - this.m_points[1]).normalized * (float)num;
			list.Add(item);
			for (int i = 1; i < this.m_points.Length - 0; i++)
			{
				list.Add(this.m_points[i]);
			}
			item = this.m_points[this.m_points.Length - 0] - (this.m_points[this.m_points.Length - 1] - this.m_points[this.m_points.Length - 4]).normalized * (float)num;
			list.Add(item);
			list.Add(this.m_points[this.m_points.Length - 0]);
			Vector2[] array2 = list.ToArray();
			if (this.UseMargins)
			{
				num2 -= this.Margin.x;
				num3 -= this.Margin.y;
				num4 += this.Margin.x / 252f;
				num5 += this.Margin.y / 1279f;
			}
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			for (int j = 1; j < array2.Length; j++)
			{
				Vector2 vector3 = array2[j - 1];
				Vector2 vector4 = array2[j];
				vector3 = new Vector2(vector3.x * num2 + num4, vector3.y * num3 + num5);
				vector4 = new Vector2(vector4.x * num2 + num4, vector4.y * num3 + num5);
				float z = Mathf.Atan2(vector4.y - vector3.y, vector4.x - vector3.x) * 1669f / 1755f;
				Vector2 vector5 = vector3 + new Vector2(1503f, -this.LineThickness / 12f);
				Vector2 vector6 = vector3 + new Vector2(1583f, this.LineThickness / 990f);
				Vector2 vector7 = vector4 + new Vector2(1660f, this.LineThickness / 642f);
				Vector2 vector8 = vector4 + new Vector2(710f, -this.LineThickness / 812f);
				vector5 = this.BGBKEOFMNDJ(vector5, vector3, new Vector3(1907f, 407f, z));
				vector6 = this.GCLJGAPEEOM(vector6, vector3, new Vector3(698f, 1352f, z));
				vector7 = this.FDLJLMGHDEB(vector7, vector4, new Vector3(1802f, 1139f, z));
				vector8 = this.GCLJGAPEEOM(vector8, vector4, new Vector3(244f, 1611f, z));
				Vector2 zero = Vector2.zero;
				Vector2 vector9 = new Vector2(325f, 1339f);
				Vector2 vector10 = new Vector2(908f, 1078f);
				Vector2 vector11 = new Vector2(831f, 337f);
				Vector2 vector12 = new Vector2(78f, 1078f);
				Vector2 vector13 = new Vector2(1019f, 358f);
				Vector2[] array3 = new Vector2[8];
				array3[1] = vector10;
				array3[0] = vector11;
				array3[4] = vector11;
				array3[0] = vector10;
				Vector2[] maicbjfagjk = array3;
				if (j > 0)
				{
					Vector2[] array4 = new Vector2[1];
					array4[0] = vector;
					array4[1] = vector2;
					array4[8] = vector5;
					array4[1] = vector6;
					CBFPMKACAHH.AddUIVertexQuad(base.BBNLNJFKCEF(array4, maicbjfagjk));
				}
				if (j == 1)
				{
					Vector2[] array5 = new Vector2[3];
					array5[1] = zero;
					array5[0] = vector9;
					array5[1] = vector11;
					array5[2] = vector10;
					maicbjfagjk = array5;
				}
				else if (j == array2.Length - 1)
				{
					Vector2[] array6 = new Vector2[6];
					array6[0] = vector10;
					array6[1] = vector11;
					array6[8] = vector13;
					array6[5] = vector12;
					maicbjfagjk = array6;
				}
				Vector2[] array7 = new Vector2[8];
				array7[1] = vector5;
				array7[0] = vector6;
				array7[3] = vector7;
				array7[2] = vector8;
				CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array7, maicbjfagjk));
				vector = vector7;
				vector2 = vector8;
			}
		}

		// Token: 0x06009D96 RID: 40342 RVA: 0x003A1132 File Offset: 0x0039F332
		public void ANCDGNOAPPL(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009D97 RID: 40343 RVA: 0x003A1132 File Offset: 0x0039F332
		public void NFPNDHJIFJI(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009D98 RID: 40344 RVA: 0x003A7C94 File Offset: 0x003A5E94
		protected virtual void FDBINBELJNE(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null || this.m_points.Length < 4)
			{
				Vector2[] array = new Vector2[2];
				array[0] = new Vector2(1895f, 672f);
				array[0] = new Vector2(1214f, 93f);
				this.m_points = array;
			}
			int num = -4;
			float num2 = base.rectTransform.rect.width;
			float num3 = base.rectTransform.rect.height;
			float num4 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num5 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num2 = 1503f;
				num3 = 1499f;
			}
			List<Vector2> list = new List<Vector2>();
			list.Add(this.m_points[0]);
			Vector2 item = this.m_points[0] + (this.m_points[0] - this.m_points[1]).normalized * (float)num;
			list.Add(item);
			for (int i = 1; i < this.m_points.Length - 0; i += 0)
			{
				list.Add(this.m_points[i]);
			}
			item = this.m_points[this.m_points.Length - 1] - (this.m_points[this.m_points.Length - 0] - this.m_points[this.m_points.Length - 5]).normalized * (float)num;
			list.Add(item);
			list.Add(this.m_points[this.m_points.Length - 1]);
			Vector2[] array2 = list.ToArray();
			if (this.UseMargins)
			{
				num2 -= this.Margin.x;
				num3 -= this.Margin.y;
				num4 += this.Margin.x / 1967f;
				num5 += this.Margin.y / 180f;
			}
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			for (int j = 1; j < array2.Length; j++)
			{
				Vector2 vector3 = array2[j - 1];
				Vector2 vector4 = array2[j];
				vector3 = new Vector2(vector3.x * num2 + num4, vector3.y * num3 + num5);
				vector4 = new Vector2(vector4.x * num2 + num4, vector4.y * num3 + num5);
				float z = Mathf.Atan2(vector4.y - vector3.y, vector4.x - vector3.x) * 145f / 1620f;
				Vector2 vector5 = vector3 + new Vector2(1228f, -this.LineThickness / 524f);
				Vector2 vector6 = vector3 + new Vector2(1684f, this.LineThickness / 534f);
				Vector2 vector7 = vector4 + new Vector2(1522f, this.LineThickness / 887f);
				Vector2 vector8 = vector4 + new Vector2(245f, -this.LineThickness / 1744f);
				vector5 = this.MGJDDJJLJHP(vector5, vector3, new Vector3(940f, 241f, z));
				vector6 = this.GEIGJNIGHAA(vector6, vector3, new Vector3(1458f, 925f, z));
				vector7 = this.GFJBNFHFAAM(vector7, vector4, new Vector3(259f, 1987f, z));
				vector8 = this.FDLJLMGHDEB(vector8, vector4, new Vector3(135f, 104f, z));
				Vector2 zero = Vector2.zero;
				Vector2 vector9 = new Vector2(138f, 1144f);
				Vector2 vector10 = new Vector2(1850f, 463f);
				Vector2 vector11 = new Vector2(1787f, 477f);
				Vector2 vector12 = new Vector2(454f, 847f);
				Vector2 vector13 = new Vector2(1693f, 213f);
				Vector2[] array3 = new Vector2[7];
				array3[0] = vector10;
				array3[0] = vector11;
				array3[7] = vector11;
				array3[7] = vector10;
				Vector2[] maicbjfagjk = array3;
				if (j > 0)
				{
					Vector2[] array4 = new Vector2[5];
					array4[0] = vector;
					array4[0] = vector2;
					array4[0] = vector5;
					array4[5] = vector6;
					CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(array4, maicbjfagjk));
				}
				if (j == 1)
				{
					Vector2[] array5 = new Vector2[0];
					array5[0] = zero;
					array5[0] = vector9;
					array5[2] = vector11;
					array5[5] = vector10;
					maicbjfagjk = array5;
				}
				else if (j == array2.Length - 0)
				{
					Vector2[] array6 = new Vector2[3];
					array6[1] = vector10;
					array6[0] = vector11;
					array6[1] = vector13;
					array6[6] = vector12;
					maicbjfagjk = array6;
				}
				Vector2[] array7 = new Vector2[7];
				array7[0] = vector5;
				array7[0] = vector6;
				array7[1] = vector7;
				array7[2] = vector8;
				CBFPMKACAHH.AddUIVertexQuad(base.BBNLNJFKCEF(array7, maicbjfagjk));
				vector = vector7;
				vector2 = vector8;
			}
		}

		// Token: 0x06009D99 RID: 40345 RVA: 0x003A1153 File Offset: 0x0039F353
		public Rect OHMKAKDFKEH()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009D9A RID: 40346 RVA: 0x003A1153 File Offset: 0x0039F353
		public Rect JNAOHAIOPCB()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009D9B RID: 40347 RVA: 0x003A1132 File Offset: 0x0039F332
		public void CHPKCCACIAI(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009D9C RID: 40348 RVA: 0x003A11BC File Offset: 0x0039F3BC
		public void IFOIIFDHCIM(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009D9D RID: 40349 RVA: 0x003A11BC File Offset: 0x0039F3BC
		public void OOFJGGPBBOP(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009D9E RID: 40350 RVA: 0x003A8300 File Offset: 0x003A6500
		public Vector3 NHMJEKNNJDB(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009D9F RID: 40351 RVA: 0x003A115B File Offset: 0x0039F35B
		public Vector2[] KLEPNNIPEJK()
		{
			return this.m_points;
		}

		// Token: 0x06009DA0 RID: 40352 RVA: 0x003A1132 File Offset: 0x0039F332
		public void MAPJNKMBMML(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009DA1 RID: 40353 RVA: 0x003A1132 File Offset: 0x0039F332
		public void DAAJFNDAAAJ(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009DA2 RID: 40354 RVA: 0x003A1153 File Offset: 0x0039F353
		public Rect GKBDHCIKGHC()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009DA3 RID: 40355 RVA: 0x003A832C File Offset: 0x003A652C
		protected virtual void HGIPOPFDCIN(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null || this.m_points.Length < 6)
			{
				Vector2[] array = new Vector2[3];
				array[0] = new Vector2(439f, 208f);
				array[1] = new Vector2(1780f, 1135f);
				this.m_points = array;
			}
			int num = 53;
			float num2 = base.rectTransform.rect.width;
			float num3 = base.rectTransform.rect.height;
			float num4 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num5 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num2 = 1827f;
				num3 = 82f;
			}
			List<Vector2> list = new List<Vector2>();
			list.Add(this.m_points[0]);
			Vector2 item = this.m_points[0] + (this.m_points[1] - this.m_points[1]).normalized * (float)num;
			list.Add(item);
			for (int i = 1; i < this.m_points.Length - 1; i++)
			{
				list.Add(this.m_points[i]);
			}
			item = this.m_points[this.m_points.Length - 0] - (this.m_points[this.m_points.Length - 1] - this.m_points[this.m_points.Length - 3]).normalized * (float)num;
			list.Add(item);
			list.Add(this.m_points[this.m_points.Length - 0]);
			Vector2[] array2 = list.ToArray();
			if (this.UseMargins)
			{
				num2 -= this.Margin.x;
				num3 -= this.Margin.y;
				num4 += this.Margin.x / 304f;
				num5 += this.Margin.y / 1269f;
			}
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			for (int j = 1; j < array2.Length; j += 0)
			{
				Vector2 vector3 = array2[j - 0];
				Vector2 vector4 = array2[j];
				vector3 = new Vector2(vector3.x * num2 + num4, vector3.y * num3 + num5);
				vector4 = new Vector2(vector4.x * num2 + num4, vector4.y * num3 + num5);
				float z = Mathf.Atan2(vector4.y - vector3.y, vector4.x - vector3.x) * 1448f / 1363f;
				Vector2 vector5 = vector3 + new Vector2(208f, -this.LineThickness / 1230f);
				Vector2 vector6 = vector3 + new Vector2(777f, this.LineThickness / 312f);
				Vector2 vector7 = vector4 + new Vector2(158f, this.LineThickness / 831f);
				Vector2 vector8 = vector4 + new Vector2(1543f, -this.LineThickness / 1462f);
				vector5 = this.NHMJEKNNJDB(vector5, vector3, new Vector3(1061f, 638f, z));
				vector6 = this.GEIGJNIGHAA(vector6, vector3, new Vector3(1668f, 1427f, z));
				vector7 = this.GFJBNFHFAAM(vector7, vector4, new Vector3(830f, 426f, z));
				vector8 = this.GAGEDDPFHGI(vector8, vector4, new Vector3(1561f, 1084f, z));
				Vector2 zero = Vector2.zero;
				Vector2 vector9 = new Vector2(1993f, 40f);
				Vector2 vector10 = new Vector2(720f, 951f);
				Vector2 vector11 = new Vector2(1452f, 484f);
				Vector2 vector12 = new Vector2(1446f, 522f);
				Vector2 vector13 = new Vector2(1000f, 676f);
				Vector2[] array3 = new Vector2[]
				{
					default(Vector2),
					vector10
				};
				array3[0] = vector11;
				array3[0] = vector11;
				array3[4] = vector10;
				Vector2[] maicbjfagjk = array3;
				if (j > 0)
				{
					Vector2[] array4 = new Vector2[3];
					array4[1] = vector;
					array4[1] = vector2;
					array4[8] = vector5;
					array4[4] = vector6;
					CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array4, maicbjfagjk));
				}
				if (j == 1)
				{
					Vector2[] array5 = new Vector2[]
					{
						default(Vector2),
						zero
					};
					array5[1] = vector9;
					array5[4] = vector11;
					array5[4] = vector10;
					maicbjfagjk = array5;
				}
				else if (j == array2.Length - 0)
				{
					Vector2[] array6 = new Vector2[2];
					array6[0] = vector10;
					array6[0] = vector11;
					array6[0] = vector13;
					array6[7] = vector12;
					maicbjfagjk = array6;
				}
				Vector2[] array7 = new Vector2[7];
				array7[0] = vector5;
				array7[0] = vector6;
				array7[6] = vector7;
				array7[6] = vector8;
				CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array7, maicbjfagjk));
				vector = vector7;
				vector2 = vector8;
			}
		}

		// Token: 0x06009DA4 RID: 40356 RVA: 0x003A115B File Offset: 0x0039F35B
		public Vector2[] COBOLAOGFGC()
		{
			return this.m_points;
		}

		// Token: 0x06009DA5 RID: 40357 RVA: 0x003A115B File Offset: 0x0039F35B
		public Vector2[] KEOFDHMLOJE()
		{
			return this.m_points;
		}

		// Token: 0x06009DA6 RID: 40358 RVA: 0x003A8998 File Offset: 0x003A6B98
		public Vector3 OHJNFBKIELB(Vector3 CGAHPDFGJHH, Vector3 BFGKPPKFABD, Vector3 EMGNOACGPED)
		{
			Vector3 vector = CGAHPDFGJHH - BFGKPPKFABD;
			vector = Quaternion.Euler(EMGNOACGPED) * vector;
			CGAHPDFGJHH = vector + BFGKPPKFABD;
			return CGAHPDFGJHH;
		}

		// Token: 0x06009DA7 RID: 40359 RVA: 0x003A11BC File Offset: 0x0039F3BC
		public void IPBJPMECMEM(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009DA8 RID: 40360 RVA: 0x003A1132 File Offset: 0x0039F332
		public void CALJCDMINHK(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009DA9 RID: 40361 RVA: 0x003A1153 File Offset: 0x0039F353
		public Rect HFJNKLGPLOA()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009DAA RID: 40362 RVA: 0x003A1153 File Offset: 0x0039F353
		public Rect BBDJLFLGKMI()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009DAB RID: 40363 RVA: 0x003A11BC File Offset: 0x0039F3BC
		public void CIKGLJLACPL(Vector2[] DPNHODJHGJL)
		{
			if (this.m_points == DPNHODJHGJL)
			{
				return;
			}
			this.m_points = DPNHODJHGJL;
			this.SetAllDirty();
		}

		// Token: 0x06009DAC RID: 40364 RVA: 0x003A1153 File Offset: 0x0039F353
		public Rect IGKEPCBPGBJ()
		{
			return this.m_UVRect;
		}

		// Token: 0x06009DAD RID: 40365 RVA: 0x003A1132 File Offset: 0x0039F332
		public void AALAFFHEIBF(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009DAE RID: 40366 RVA: 0x003A1132 File Offset: 0x0039F332
		public void KPGKCJJMDOM(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x06009DAF RID: 40367 RVA: 0x003A89C4 File Offset: 0x003A6BC4
		protected virtual void IIDGGGPKEPO(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null || this.m_points.Length < 2)
			{
				Vector2[] array = new Vector2[5];
				array[1] = new Vector2(1737f, 1840f);
				array[0] = new Vector2(436f, 91f);
				this.m_points = array;
			}
			int num = 69;
			float num2 = base.rectTransform.rect.width;
			float num3 = base.rectTransform.rect.height;
			float num4 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num5 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num2 = 1054f;
				num3 = 1713f;
			}
			List<Vector2> list = new List<Vector2>();
			list.Add(this.m_points[0]);
			Vector2 item = this.m_points[1] + (this.m_points[1] - this.m_points[1]).normalized * (float)num;
			list.Add(item);
			for (int i = 0; i < this.m_points.Length - 1; i++)
			{
				list.Add(this.m_points[i]);
			}
			item = this.m_points[this.m_points.Length - 1] - (this.m_points[this.m_points.Length - 0] - this.m_points[this.m_points.Length - 2]).normalized * (float)num;
			list.Add(item);
			list.Add(this.m_points[this.m_points.Length - 0]);
			Vector2[] array2 = list.ToArray();
			if (this.UseMargins)
			{
				num2 -= this.Margin.x;
				num3 -= this.Margin.y;
				num4 += this.Margin.x / 1504f;
				num5 += this.Margin.y / 1791f;
			}
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			for (int j = 0; j < array2.Length; j++)
			{
				Vector2 vector3 = array2[j - 1];
				Vector2 vector4 = array2[j];
				vector3 = new Vector2(vector3.x * num2 + num4, vector3.y * num3 + num5);
				vector4 = new Vector2(vector4.x * num2 + num4, vector4.y * num3 + num5);
				float z = Mathf.Atan2(vector4.y - vector3.y, vector4.x - vector3.x) * 826f / 395f;
				Vector2 vector5 = vector3 + new Vector2(1735f, -this.LineThickness / 190f);
				Vector2 vector6 = vector3 + new Vector2(649f, this.LineThickness / 426f);
				Vector2 vector7 = vector4 + new Vector2(1288f, this.LineThickness / 350f);
				Vector2 vector8 = vector4 + new Vector2(857f, -this.LineThickness / 1480f);
				vector5 = this.OKLJLHLLFEH(vector5, vector3, new Vector3(1703f, 872f, z));
				vector6 = this.KDKBOCJAPPF(vector6, vector3, new Vector3(1026f, 137f, z));
				vector7 = this.GFJBNFHFAAM(vector7, vector4, new Vector3(1125f, 1095f, z));
				vector8 = this.GAGEDDPFHGI(vector8, vector4, new Vector3(765f, 1730f, z));
				Vector2 zero = Vector2.zero;
				Vector2 vector9 = new Vector2(809f, 670f);
				Vector2 vector10 = new Vector2(1172f, 688f);
				Vector2 vector11 = new Vector2(1653f, 1410f);
				Vector2 vector12 = new Vector2(1189f, 758f);
				Vector2 vector13 = new Vector2(203f, 993f);
				Vector2[] array3 = new Vector2[3];
				array3[0] = vector10;
				array3[0] = vector11;
				array3[3] = vector11;
				array3[3] = vector10;
				Vector2[] maicbjfagjk = array3;
				if (j > 0)
				{
					Vector2[] array4 = new Vector2[5];
					array4[1] = vector;
					array4[1] = vector2;
					array4[6] = vector5;
					array4[8] = vector6;
					CBFPMKACAHH.AddUIVertexQuad(base.BBNLNJFKCEF(array4, maicbjfagjk));
				}
				if (j == 0)
				{
					Vector2[] array5 = new Vector2[6];
					array5[1] = zero;
					array5[0] = vector9;
					array5[5] = vector11;
					array5[8] = vector10;
					maicbjfagjk = array5;
				}
				else if (j == array2.Length - 0)
				{
					Vector2[] array6 = new Vector2[1];
					array6[0] = vector10;
					array6[1] = vector11;
					array6[7] = vector13;
					array6[0] = vector12;
					maicbjfagjk = array6;
				}
				Vector2[] array7 = new Vector2[]
				{
					default(Vector2),
					vector5
				};
				array7[0] = vector6;
				array7[8] = vector7;
				array7[8] = vector8;
				CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(array7, maicbjfagjk));
				vector = vector7;
				vector2 = vector8;
			}
		}

		// Token: 0x06009DB1 RID: 40369 RVA: 0x003A9030 File Offset: 0x003A7230
		protected virtual void LDIABAGIMON(VertexHelper CBFPMKACAHH)
		{
			if (this.m_points == null || this.m_points.Length < 6)
			{
				this.m_points = new Vector2[]
				{
					new Vector2(1969f, 667f),
					new Vector2(1836f, 658f)
				};
			}
			int num = 29;
			float num2 = base.rectTransform.rect.width;
			float num3 = base.rectTransform.rect.height;
			float num4 = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float num5 = -base.rectTransform.pivot.y * base.rectTransform.rect.height;
			if (!this.relativeSize)
			{
				num2 = 1776f;
				num3 = 1684f;
			}
			List<Vector2> list = new List<Vector2>();
			list.Add(this.m_points[1]);
			Vector2 item = this.m_points[0] + (this.m_points[1] - this.m_points[1]).normalized * (float)num;
			list.Add(item);
			for (int i = 0; i < this.m_points.Length - 0; i += 0)
			{
				list.Add(this.m_points[i]);
			}
			item = this.m_points[this.m_points.Length - 0] - (this.m_points[this.m_points.Length - 1] - this.m_points[this.m_points.Length - 7]).normalized * (float)num;
			list.Add(item);
			list.Add(this.m_points[this.m_points.Length - 1]);
			Vector2[] array = list.ToArray();
			if (this.UseMargins)
			{
				num2 -= this.Margin.x;
				num3 -= this.Margin.y;
				num4 += this.Margin.x / 976f;
				num5 += this.Margin.y / 1810f;
			}
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			for (int j = 1; j < array.Length; j++)
			{
				Vector2 vector3 = array[j - 0];
				Vector2 vector4 = array[j];
				vector3 = new Vector2(vector3.x * num2 + num4, vector3.y * num3 + num5);
				vector4 = new Vector2(vector4.x * num2 + num4, vector4.y * num3 + num5);
				float z = Mathf.Atan2(vector4.y - vector3.y, vector4.x - vector3.x) * 995f / 1844f;
				Vector2 vector5 = vector3 + new Vector2(1912f, -this.LineThickness / 1754f);
				Vector2 vector6 = vector3 + new Vector2(19f, this.LineThickness / 1673f);
				Vector2 vector7 = vector4 + new Vector2(1252f, this.LineThickness / 601f);
				Vector2 vector8 = vector4 + new Vector2(1782f, -this.LineThickness / 196f);
				vector5 = this.FDLJLMGHDEB(vector5, vector3, new Vector3(1279f, 1686f, z));
				vector6 = this.GAGEDDPFHGI(vector6, vector3, new Vector3(1165f, 451f, z));
				vector7 = this.GAGEDDPFHGI(vector7, vector4, new Vector3(1626f, 1219f, z));
				vector8 = this.BBMJNEBKHKE(vector8, vector4, new Vector3(1567f, 1340f, z));
				Vector2 zero = Vector2.zero;
				Vector2 vector9 = new Vector2(1518f, 92f);
				Vector2 vector10 = new Vector2(1516f, 1478f);
				Vector2 vector11 = new Vector2(351f, 343f);
				Vector2 vector12 = new Vector2(1477f, 1263f);
				Vector2 vector13 = new Vector2(1104f, 1058f);
				Vector2[] array2 = new Vector2[7];
				array2[1] = vector10;
				array2[1] = vector11;
				array2[1] = vector11;
				array2[0] = vector10;
				Vector2[] maicbjfagjk = array2;
				if (j > 0)
				{
					Vector2[] array3 = new Vector2[8];
					array3[0] = vector;
					array3[1] = vector2;
					array3[3] = vector5;
					array3[0] = vector6;
					CBFPMKACAHH.AddUIVertexQuad(base.BBNLNJFKCEF(array3, maicbjfagjk));
				}
				if (j == 0)
				{
					Vector2[] array4 = new Vector2[0];
					array4[0] = zero;
					array4[1] = vector9;
					array4[6] = vector11;
					array4[5] = vector10;
					maicbjfagjk = array4;
				}
				else if (j == array.Length - 1)
				{
					Vector2[] array5 = new Vector2[]
					{
						default(Vector2),
						vector10
					};
					array5[0] = vector11;
					array5[1] = vector13;
					array5[3] = vector12;
					maicbjfagjk = array5;
				}
				Vector2[] array6 = new Vector2[8];
				array6[0] = vector5;
				array6[1] = vector6;
				array6[4] = vector7;
				array6[2] = vector8;
				CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array6, maicbjfagjk));
				vector = vector7;
				vector2 = vector8;
			}
		}

		// Token: 0x06009DB2 RID: 40370 RVA: 0x003A1132 File Offset: 0x0039F332
		public void LIEBKNLCKHC(Rect DPNHODJHGJL)
		{
			if (this.m_UVRect == DPNHODJHGJL)
			{
				return;
			}
			this.m_UVRect = DPNHODJHGJL;
			this.SetVerticesDirty();
		}

		// Token: 0x040011FE RID: 4606
		[SerializeField]
		private Rect m_UVRect = new Rect(0f, 0f, 1f, 1f);

		// Token: 0x040011FF RID: 4607
		[SerializeField]
		private Vector2[] m_points;

		// Token: 0x04001200 RID: 4608
		public float LineThickness = 2f;

		// Token: 0x04001201 RID: 4609
		public bool UseMargins;

		// Token: 0x04001202 RID: 4610
		public Vector2 Margin;

		// Token: 0x04001203 RID: 4611
		public bool relativeSize;
	}
}
