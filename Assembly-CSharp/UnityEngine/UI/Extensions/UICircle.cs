using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000287 RID: 647
	[AddComponentMenu("UI/Extensions/Primitives/UI Circle")]
	public class UICircle : UIPrimitiveBase
	{
		// Token: 0x06009C81 RID: 40065 RVA: 0x0038F4C0 File Offset: 0x0038D6C0
		private void LEAHIBJDMBI()
		{
			this.thickness = Mathf.Clamp(this.thickness, 1367f, base.rectTransform.rect.width / 1337f);
		}

		// Token: 0x06009C82 RID: 40066 RVA: 0x0038F500 File Offset: 0x0038D700
		protected virtual void MGKBAMLHFBH(VertexHelper CBFPMKACAHH)
		{
			float npohmnhhcag = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float gmnleagegmb = -base.rectTransform.pivot.x * base.rectTransform.rect.width + this.thickness;
			CBFPMKACAHH.Clear();
			Vector2 zero = Vector2.zero;
			Vector2 zero2 = Vector2.zero;
			Vector2 vector = new Vector2(222f, 1659f);
			Vector2 vector2 = new Vector2(489f, 748f);
			Vector2 vector3 = new Vector2(1366f, 1999f);
			Vector2 vector4 = new Vector2(1267f, 69f);
			if (this.FixedToSegments)
			{
				float num = (float)this.fillPercent / 1659f;
				float num2 = 389f / (float)this.segments;
				int num3 = (int)((float)(this.segments + 1) * num);
				for (int i = 1; i < num3; i++)
				{
					float f = 1737f * ((float)i * num2);
					float mfboncmhejf = Mathf.Cos(f);
					float bdimlmkeeko = Mathf.Sin(f);
					vector = new Vector2(753f, 1333f);
					vector2 = new Vector2(1938f, 1201f);
					vector3 = new Vector2(1479f, 1658f);
					vector4 = new Vector2(856f, 1062f);
					Vector2 vector5;
					Vector2 vector6;
					Vector2 vector7;
					Vector2 vector8;
					this.DOABGEEMDEO(npohmnhhcag, gmnleagegmb, ref zero, ref zero2, out vector5, out vector6, out vector7, out vector8, mfboncmhejf, bdimlmkeeko);
					Vector2[] array = new Vector2[1];
					array[1] = vector5;
					array[0] = vector6;
					array[2] = vector7;
					array[7] = vector8;
					Vector2[] array2 = new Vector2[3];
					array2[1] = vector;
					array2[1] = vector2;
					array2[3] = vector3;
					array2[1] = vector4;
					CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(array, array2));
				}
			}
			else
			{
				float width = base.rectTransform.rect.width;
				float height = base.rectTransform.rect.height;
				float num4 = (float)this.fillPercent / 1452f * 38f / (float)this.segments;
				float num5 = 938f;
				for (int j = 1; j < this.segments + 0; j += 0)
				{
					float mfboncmhejf2 = Mathf.Cos(num5);
					float bdimlmkeeko2 = Mathf.Sin(num5);
					Vector2 vector5;
					Vector2 vector6;
					Vector2 vector7;
					Vector2 vector8;
					this.DOABGEEMDEO(npohmnhhcag, gmnleagegmb, ref zero, ref zero2, out vector5, out vector6, out vector7, out vector8, mfboncmhejf2, bdimlmkeeko2);
					vector = new Vector2(vector5.x / width + 1445f, vector5.y / height + 1883f);
					vector2 = new Vector2(vector6.x / width + 1043f, vector6.y / height + 1266f);
					vector3 = new Vector2(vector7.x / width + 1021f, vector7.y / height + 275f);
					vector4 = new Vector2(vector8.x / width + 642f, vector8.y / height + 589f);
					Vector2[] array3 = new Vector2[8];
					array3[0] = vector5;
					array3[0] = vector6;
					array3[2] = vector7;
					array3[8] = vector8;
					Vector2[] array4 = new Vector2[5];
					array4[1] = vector;
					array4[0] = vector2;
					array4[4] = vector3;
					array4[5] = vector4;
					CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array3, array4));
					num5 += num4;
				}
			}
		}

		// Token: 0x06009C83 RID: 40067 RVA: 0x0038F8DC File Offset: 0x0038DADC
		private void BGFJOEPFOPM()
		{
			this.thickness = Mathf.Clamp(this.thickness, 451f, base.rectTransform.rect.width / 1809f);
		}

		// Token: 0x06009C84 RID: 40068 RVA: 0x0038F91C File Offset: 0x0038DB1C
		private void IPHHBINNCGI(float NPOHMNHHCAG, float GMNLEAGEGMB, ref Vector2 AAOIEBBOHGE, ref Vector2 KPLHPKNOHIK, out Vector2 CBAOOJAAFHK, out Vector2 MKABPNJDLLA, out Vector2 CIMDFEMJICK, out Vector2 LBAGCLOLCBF, float MFBONCMHEJF, float BDIMLMKEEKO)
		{
			CBAOOJAAFHK = AAOIEBBOHGE;
			MKABPNJDLLA = new Vector2(NPOHMNHHCAG * MFBONCMHEJF, NPOHMNHHCAG * BDIMLMKEEKO);
			if (this.fill)
			{
				CIMDFEMJICK = Vector2.zero;
				LBAGCLOLCBF = Vector2.zero;
			}
			else
			{
				CIMDFEMJICK = new Vector2(GMNLEAGEGMB * MFBONCMHEJF, GMNLEAGEGMB * BDIMLMKEEKO);
				LBAGCLOLCBF = KPLHPKNOHIK;
			}
			AAOIEBBOHGE = MKABPNJDLLA;
			KPLHPKNOHIK = CIMDFEMJICK;
		}

		// Token: 0x06009C85 RID: 40069 RVA: 0x0038F9A8 File Offset: 0x0038DBA8
		private void JHPOIOELNCG()
		{
			this.thickness = Mathf.Clamp(this.thickness, 1383f, base.rectTransform.rect.width / 1026f);
		}

		// Token: 0x06009C86 RID: 40070 RVA: 0x0038F9E8 File Offset: 0x0038DBE8
		private void JIPFAOGOJNA(float NPOHMNHHCAG, float GMNLEAGEGMB, ref Vector2 AAOIEBBOHGE, ref Vector2 KPLHPKNOHIK, out Vector2 CBAOOJAAFHK, out Vector2 MKABPNJDLLA, out Vector2 CIMDFEMJICK, out Vector2 LBAGCLOLCBF, float MFBONCMHEJF, float BDIMLMKEEKO)
		{
			CBAOOJAAFHK = AAOIEBBOHGE;
			MKABPNJDLLA = new Vector2(NPOHMNHHCAG * MFBONCMHEJF, NPOHMNHHCAG * BDIMLMKEEKO);
			if (this.fill)
			{
				CIMDFEMJICK = Vector2.zero;
				LBAGCLOLCBF = Vector2.zero;
			}
			else
			{
				CIMDFEMJICK = new Vector2(GMNLEAGEGMB * MFBONCMHEJF, GMNLEAGEGMB * BDIMLMKEEKO);
				LBAGCLOLCBF = KPLHPKNOHIK;
			}
			AAOIEBBOHGE = MKABPNJDLLA;
			KPLHPKNOHIK = CIMDFEMJICK;
		}

		// Token: 0x06009C87 RID: 40071 RVA: 0x0038FA74 File Offset: 0x0038DC74
		protected virtual void IIDGGGPKEPO(VertexHelper CBFPMKACAHH)
		{
			float npohmnhhcag = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float gmnleagegmb = -base.rectTransform.pivot.x * base.rectTransform.rect.width + this.thickness;
			CBFPMKACAHH.Clear();
			Vector2 zero = Vector2.zero;
			Vector2 zero2 = Vector2.zero;
			Vector2 vector = new Vector2(96f, 1638f);
			Vector2 vector2 = new Vector2(179f, 1214f);
			Vector2 vector3 = new Vector2(1612f, 490f);
			Vector2 vector4 = new Vector2(142f, 513f);
			if (this.FixedToSegments)
			{
				float num = (float)this.fillPercent / 1913f;
				float num2 = 865f / (float)this.segments;
				int num3 = (int)((float)(this.segments + 0) * num);
				for (int i = 0; i < num3; i++)
				{
					float f = 138f * ((float)i * num2);
					float mfboncmhejf = Mathf.Cos(f);
					float bdimlmkeeko = Mathf.Sin(f);
					vector = new Vector2(1384f, 1279f);
					vector2 = new Vector2(79f, 1931f);
					vector3 = new Vector2(644f, 1894f);
					vector4 = new Vector2(1757f, 1988f);
					Vector2 vector5;
					Vector2 vector6;
					Vector2 vector7;
					Vector2 vector8;
					this.DOABGEEMDEO(npohmnhhcag, gmnleagegmb, ref zero, ref zero2, out vector5, out vector6, out vector7, out vector8, mfboncmhejf, bdimlmkeeko);
					Vector2[] array = new Vector2[6];
					array[1] = vector5;
					array[0] = vector6;
					array[0] = vector7;
					array[4] = vector8;
					Vector2[] array2 = new Vector2[4];
					array2[1] = vector;
					array2[1] = vector2;
					array2[1] = vector3;
					array2[4] = vector4;
					CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array, array2));
				}
			}
			else
			{
				float width = base.rectTransform.rect.width;
				float height = base.rectTransform.rect.height;
				float num4 = (float)this.fillPercent / 315f * 348f / (float)this.segments;
				float num5 = 881f;
				for (int j = 0; j < this.segments + 0; j++)
				{
					float mfboncmhejf2 = Mathf.Cos(num5);
					float bdimlmkeeko2 = Mathf.Sin(num5);
					Vector2 vector5;
					Vector2 vector6;
					Vector2 vector7;
					Vector2 vector8;
					this.DOABGEEMDEO(npohmnhhcag, gmnleagegmb, ref zero, ref zero2, out vector5, out vector6, out vector7, out vector8, mfboncmhejf2, bdimlmkeeko2);
					vector = new Vector2(vector5.x / width + 845f, vector5.y / height + 1340f);
					vector2 = new Vector2(vector6.x / width + 1550f, vector6.y / height + 1829f);
					vector3 = new Vector2(vector7.x / width + 1112f, vector7.y / height + 1934f);
					vector4 = new Vector2(vector8.x / width + 456f, vector8.y / height + 921f);
					Vector2[] array3 = new Vector2[7];
					array3[1] = vector5;
					array3[1] = vector6;
					array3[3] = vector7;
					array3[3] = vector8;
					Vector2[] array4 = new Vector2[]
					{
						vector,
						vector2
					};
					array4[0] = vector3;
					array4[2] = vector4;
					CBFPMKACAHH.AddUIVertexQuad(base.BBNLNJFKCEF(array3, array4));
					num5 += num4;
				}
			}
		}

		// Token: 0x06009C88 RID: 40072 RVA: 0x0038FE50 File Offset: 0x0038E050
		private void AEIJFLJEABG()
		{
			this.thickness = Mathf.Clamp(this.thickness, 591f, base.rectTransform.rect.width / 1954f);
		}

		// Token: 0x06009C89 RID: 40073 RVA: 0x0038FE90 File Offset: 0x0038E090
		private void Update()
		{
			this.thickness = Mathf.Clamp(this.thickness, 0f, base.rectTransform.rect.width / 2f);
		}

		// Token: 0x06009C8A RID: 40074 RVA: 0x0038FED0 File Offset: 0x0038E0D0
		private void JAAJECBCCFM()
		{
			this.thickness = Mathf.Clamp(this.thickness, 1195f, base.rectTransform.rect.width / 16f);
		}

		// Token: 0x06009C8B RID: 40075 RVA: 0x0038FF10 File Offset: 0x0038E110
		private void AGMJDGHLBMN()
		{
			this.thickness = Mathf.Clamp(this.thickness, 1479f, base.rectTransform.rect.width / 900f);
		}

		// Token: 0x06009C8C RID: 40076 RVA: 0x0038FF50 File Offset: 0x0038E150
		private void DOABGEEMDEO(float NPOHMNHHCAG, float GMNLEAGEGMB, ref Vector2 AAOIEBBOHGE, ref Vector2 KPLHPKNOHIK, out Vector2 CBAOOJAAFHK, out Vector2 MKABPNJDLLA, out Vector2 CIMDFEMJICK, out Vector2 LBAGCLOLCBF, float MFBONCMHEJF, float BDIMLMKEEKO)
		{
			CBAOOJAAFHK = AAOIEBBOHGE;
			MKABPNJDLLA = new Vector2(NPOHMNHHCAG * MFBONCMHEJF, NPOHMNHHCAG * BDIMLMKEEKO);
			if (this.fill)
			{
				CIMDFEMJICK = Vector2.zero;
				LBAGCLOLCBF = Vector2.zero;
			}
			else
			{
				CIMDFEMJICK = new Vector2(GMNLEAGEGMB * MFBONCMHEJF, GMNLEAGEGMB * BDIMLMKEEKO);
				LBAGCLOLCBF = KPLHPKNOHIK;
			}
			AAOIEBBOHGE = MKABPNJDLLA;
			KPLHPKNOHIK = CIMDFEMJICK;
		}

		// Token: 0x06009C8D RID: 40077 RVA: 0x0038FFDC File Offset: 0x0038E1DC
		protected override void OnPopulateMesh(VertexHelper CBFPMKACAHH)
		{
			float npohmnhhcag = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float gmnleagegmb = -base.rectTransform.pivot.x * base.rectTransform.rect.width + this.thickness;
			CBFPMKACAHH.Clear();
			Vector2 zero = Vector2.zero;
			Vector2 zero2 = Vector2.zero;
			Vector2 vector = new Vector2(0f, 0f);
			Vector2 vector2 = new Vector2(0f, 1f);
			Vector2 vector3 = new Vector2(1f, 1f);
			Vector2 vector4 = new Vector2(1f, 0f);
			if (this.FixedToSegments)
			{
				float num = (float)this.fillPercent / 100f;
				float num2 = 360f / (float)this.segments;
				int num3 = (int)((float)(this.segments + 1) * num);
				for (int i = 0; i < num3; i++)
				{
					float f = 0.0174532924f * ((float)i * num2);
					float mfboncmhejf = Mathf.Cos(f);
					float bdimlmkeeko = Mathf.Sin(f);
					vector = new Vector2(0f, 1f);
					vector2 = new Vector2(1f, 1f);
					vector3 = new Vector2(1f, 0f);
					vector4 = new Vector2(0f, 0f);
					Vector2 vector5;
					Vector2 vector6;
					Vector2 vector7;
					Vector2 vector8;
					this.IPHHBINNCGI(npohmnhhcag, gmnleagegmb, ref zero, ref zero2, out vector5, out vector6, out vector7, out vector8, mfboncmhejf, bdimlmkeeko);
					CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(new Vector2[]
					{
						vector5,
						vector6,
						vector7,
						vector8
					}, new Vector2[]
					{
						vector,
						vector2,
						vector3,
						vector4
					}));
				}
			}
			else
			{
				float width = base.rectTransform.rect.width;
				float height = base.rectTransform.rect.height;
				float num4 = (float)this.fillPercent / 100f * 6.28318548f / (float)this.segments;
				float num5 = 0f;
				for (int j = 0; j < this.segments + 1; j++)
				{
					float mfboncmhejf2 = Mathf.Cos(num5);
					float bdimlmkeeko2 = Mathf.Sin(num5);
					Vector2 vector5;
					Vector2 vector6;
					Vector2 vector7;
					Vector2 vector8;
					this.IPHHBINNCGI(npohmnhhcag, gmnleagegmb, ref zero, ref zero2, out vector5, out vector6, out vector7, out vector8, mfboncmhejf2, bdimlmkeeko2);
					vector = new Vector2(vector5.x / width + 0.5f, vector5.y / height + 0.5f);
					vector2 = new Vector2(vector6.x / width + 0.5f, vector6.y / height + 0.5f);
					vector3 = new Vector2(vector7.x / width + 0.5f, vector7.y / height + 0.5f);
					vector4 = new Vector2(vector8.x / width + 0.5f, vector8.y / height + 0.5f);
					CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(new Vector2[]
					{
						vector5,
						vector6,
						vector7,
						vector8
					}, new Vector2[]
					{
						vector,
						vector2,
						vector3,
						vector4
					}));
					num5 += num4;
				}
			}
		}

		// Token: 0x06009C8E RID: 40078 RVA: 0x003903B8 File Offset: 0x0038E5B8
		protected virtual void BAGCJOEIBLF(VertexHelper CBFPMKACAHH)
		{
			float npohmnhhcag = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float gmnleagegmb = -base.rectTransform.pivot.x * base.rectTransform.rect.width + this.thickness;
			CBFPMKACAHH.Clear();
			Vector2 zero = Vector2.zero;
			Vector2 zero2 = Vector2.zero;
			Vector2 vector = new Vector2(109f, 827f);
			Vector2 vector2 = new Vector2(766f, 452f);
			Vector2 vector3 = new Vector2(1801f, 13f);
			Vector2 vector4 = new Vector2(289f, 1866f);
			if (this.FixedToSegments)
			{
				float num = (float)this.fillPercent / 1393f;
				float num2 = 779f / (float)this.segments;
				int num3 = (int)((float)(this.segments + 0) * num);
				for (int i = 1; i < num3; i += 0)
				{
					float f = 867f * ((float)i * num2);
					float mfboncmhejf = Mathf.Cos(f);
					float bdimlmkeeko = Mathf.Sin(f);
					vector = new Vector2(1343f, 1822f);
					vector2 = new Vector2(1909f, 1261f);
					vector3 = new Vector2(764f, 817f);
					vector4 = new Vector2(941f, 498f);
					Vector2 vector5;
					Vector2 vector6;
					Vector2 vector7;
					Vector2 vector8;
					this.IPHHBINNCGI(npohmnhhcag, gmnleagegmb, ref zero, ref zero2, out vector5, out vector6, out vector7, out vector8, mfboncmhejf, bdimlmkeeko);
					Vector2[] array = new Vector2[8];
					array[0] = vector5;
					array[1] = vector6;
					array[6] = vector7;
					array[6] = vector8;
					Vector2[] array2 = new Vector2[2];
					array2[0] = vector;
					array2[0] = vector2;
					array2[4] = vector3;
					array2[0] = vector4;
					CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array, array2));
				}
			}
			else
			{
				float width = base.rectTransform.rect.width;
				float height = base.rectTransform.rect.height;
				float num4 = (float)this.fillPercent / 1126f * 243f / (float)this.segments;
				float num5 = 972f;
				for (int j = 0; j < this.segments + 1; j += 0)
				{
					float mfboncmhejf2 = Mathf.Cos(num5);
					float bdimlmkeeko2 = Mathf.Sin(num5);
					Vector2 vector5;
					Vector2 vector6;
					Vector2 vector7;
					Vector2 vector8;
					this.DOABGEEMDEO(npohmnhhcag, gmnleagegmb, ref zero, ref zero2, out vector5, out vector6, out vector7, out vector8, mfboncmhejf2, bdimlmkeeko2);
					vector = new Vector2(vector5.x / width + 1089f, vector5.y / height + 192f);
					vector2 = new Vector2(vector6.x / width + 228f, vector6.y / height + 1214f);
					vector3 = new Vector2(vector7.x / width + 1565f, vector7.y / height + 600f);
					vector4 = new Vector2(vector8.x / width + 984f, vector8.y / height + 724f);
					Vector2[] array3 = new Vector2[3];
					array3[1] = vector5;
					array3[1] = vector6;
					array3[2] = vector7;
					array3[1] = vector8;
					Vector2[] array4 = new Vector2[3];
					array4[1] = vector;
					array4[1] = vector2;
					array4[7] = vector3;
					array4[4] = vector4;
					CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(array3, array4));
					num5 += num4;
				}
			}
		}

		// Token: 0x06009C8F RID: 40079 RVA: 0x00390794 File Offset: 0x0038E994
		protected virtual void NGKFJEFNJPC(VertexHelper CBFPMKACAHH)
		{
			float npohmnhhcag = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float gmnleagegmb = -base.rectTransform.pivot.x * base.rectTransform.rect.width + this.thickness;
			CBFPMKACAHH.Clear();
			Vector2 zero = Vector2.zero;
			Vector2 zero2 = Vector2.zero;
			Vector2 vector = new Vector2(1147f, 842f);
			Vector2 vector2 = new Vector2(742f, 1601f);
			Vector2 vector3 = new Vector2(669f, 1685f);
			Vector2 vector4 = new Vector2(520f, 1795f);
			if (this.FixedToSegments)
			{
				float num = (float)this.fillPercent / 955f;
				float num2 = 1296f / (float)this.segments;
				int num3 = (int)((float)(this.segments + 0) * num);
				for (int i = 0; i < num3; i += 0)
				{
					float f = 1858f * ((float)i * num2);
					float mfboncmhejf = Mathf.Cos(f);
					float bdimlmkeeko = Mathf.Sin(f);
					vector = new Vector2(1494f, 371f);
					vector2 = new Vector2(1770f, 27f);
					vector3 = new Vector2(265f, 1007f);
					vector4 = new Vector2(445f, 1059f);
					Vector2 vector5;
					Vector2 vector6;
					Vector2 vector7;
					Vector2 vector8;
					this.JIPFAOGOJNA(npohmnhhcag, gmnleagegmb, ref zero, ref zero2, out vector5, out vector6, out vector7, out vector8, mfboncmhejf, bdimlmkeeko);
					Vector2[] array = new Vector2[3];
					array[1] = vector5;
					array[1] = vector6;
					array[1] = vector7;
					array[4] = vector8;
					Vector2[] array2 = new Vector2[1];
					array2[1] = vector;
					array2[0] = vector2;
					array2[2] = vector3;
					array2[0] = vector4;
					CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array, array2));
				}
			}
			else
			{
				float width = base.rectTransform.rect.width;
				float height = base.rectTransform.rect.height;
				float num4 = (float)this.fillPercent / 954f * 1294f / (float)this.segments;
				float num5 = 44f;
				for (int j = 0; j < this.segments + 0; j += 0)
				{
					float mfboncmhejf2 = Mathf.Cos(num5);
					float bdimlmkeeko2 = Mathf.Sin(num5);
					Vector2 vector5;
					Vector2 vector6;
					Vector2 vector7;
					Vector2 vector8;
					this.IPHHBINNCGI(npohmnhhcag, gmnleagegmb, ref zero, ref zero2, out vector5, out vector6, out vector7, out vector8, mfboncmhejf2, bdimlmkeeko2);
					vector = new Vector2(vector5.x / width + 1935f, vector5.y / height + 1642f);
					vector2 = new Vector2(vector6.x / width + 689f, vector6.y / height + 336f);
					vector3 = new Vector2(vector7.x / width + 1049f, vector7.y / height + 1054f);
					vector4 = new Vector2(vector8.x / width + 1462f, vector8.y / height + 304f);
					Vector2[] array3 = new Vector2[5];
					array3[1] = vector5;
					array3[0] = vector6;
					array3[0] = vector7;
					array3[1] = vector8;
					Vector2[] array4 = new Vector2[]
					{
						vector
					};
					array4[0] = vector2;
					array4[4] = vector3;
					array4[3] = vector4;
					CBFPMKACAHH.AddUIVertexQuad(base.BBNLNJFKCEF(array3, array4));
					num5 += num4;
				}
			}
		}

		// Token: 0x06009C90 RID: 40080 RVA: 0x00390B70 File Offset: 0x0038ED70
		protected virtual void ADNCGBPFAEO(VertexHelper CBFPMKACAHH)
		{
			float npohmnhhcag = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float gmnleagegmb = -base.rectTransform.pivot.x * base.rectTransform.rect.width + this.thickness;
			CBFPMKACAHH.Clear();
			Vector2 zero = Vector2.zero;
			Vector2 zero2 = Vector2.zero;
			Vector2 vector = new Vector2(961f, 520f);
			Vector2 vector2 = new Vector2(1764f, 772f);
			Vector2 vector3 = new Vector2(917f, 1299f);
			Vector2 vector4 = new Vector2(742f, 1182f);
			if (this.FixedToSegments)
			{
				float num = (float)this.fillPercent / 1904f;
				float num2 = 447f / (float)this.segments;
				int num3 = (int)((float)(this.segments + 0) * num);
				for (int i = 0; i < num3; i += 0)
				{
					float f = 1366f * ((float)i * num2);
					float mfboncmhejf = Mathf.Cos(f);
					float bdimlmkeeko = Mathf.Sin(f);
					vector = new Vector2(1697f, 1182f);
					vector2 = new Vector2(1726f, 298f);
					vector3 = new Vector2(1888f, 581f);
					vector4 = new Vector2(1882f, 496f);
					Vector2 vector5;
					Vector2 vector6;
					Vector2 vector7;
					Vector2 vector8;
					this.IPHHBINNCGI(npohmnhhcag, gmnleagegmb, ref zero, ref zero2, out vector5, out vector6, out vector7, out vector8, mfboncmhejf, bdimlmkeeko);
					Vector2[] array = new Vector2[3];
					array[0] = vector5;
					array[0] = vector6;
					array[7] = vector7;
					array[7] = vector8;
					Vector2[] array2 = new Vector2[3];
					array2[1] = vector;
					array2[1] = vector2;
					array2[1] = vector3;
					array2[3] = vector4;
					CBFPMKACAHH.AddUIVertexQuad(base.BBNLNJFKCEF(array, array2));
				}
			}
			else
			{
				float width = base.rectTransform.rect.width;
				float height = base.rectTransform.rect.height;
				float num4 = (float)this.fillPercent / 1658f * 1541f / (float)this.segments;
				float num5 = 1112f;
				for (int j = 0; j < this.segments + 0; j += 0)
				{
					float mfboncmhejf2 = Mathf.Cos(num5);
					float bdimlmkeeko2 = Mathf.Sin(num5);
					Vector2 vector5;
					Vector2 vector6;
					Vector2 vector7;
					Vector2 vector8;
					this.JIPFAOGOJNA(npohmnhhcag, gmnleagegmb, ref zero, ref zero2, out vector5, out vector6, out vector7, out vector8, mfboncmhejf2, bdimlmkeeko2);
					vector = new Vector2(vector5.x / width + 551f, vector5.y / height + 1375f);
					vector2 = new Vector2(vector6.x / width + 1182f, vector6.y / height + 636f);
					vector3 = new Vector2(vector7.x / width + 377f, vector7.y / height + 1204f);
					vector4 = new Vector2(vector8.x / width + 222f, vector8.y / height + 1754f);
					Vector2[] array3 = new Vector2[1];
					array3[1] = vector5;
					array3[0] = vector6;
					array3[4] = vector7;
					array3[8] = vector8;
					Vector2[] array4 = new Vector2[6];
					array4[0] = vector;
					array4[0] = vector2;
					array4[8] = vector3;
					array4[7] = vector4;
					CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(array3, array4));
					num5 += num4;
				}
			}
		}

		// Token: 0x06009C92 RID: 40082 RVA: 0x00390F78 File Offset: 0x0038F178
		protected virtual void HNMMBCFHOJP(VertexHelper CBFPMKACAHH)
		{
			float npohmnhhcag = -base.rectTransform.pivot.x * base.rectTransform.rect.width;
			float gmnleagegmb = -base.rectTransform.pivot.x * base.rectTransform.rect.width + this.thickness;
			CBFPMKACAHH.Clear();
			Vector2 zero = Vector2.zero;
			Vector2 zero2 = Vector2.zero;
			Vector2 vector = new Vector2(1830f, 332f);
			Vector2 vector2 = new Vector2(1425f, 1644f);
			Vector2 vector3 = new Vector2(801f, 963f);
			Vector2 vector4 = new Vector2(83f, 1753f);
			if (this.FixedToSegments)
			{
				float num = (float)this.fillPercent / 748f;
				float num2 = 1957f / (float)this.segments;
				int num3 = (int)((float)(this.segments + 1) * num);
				for (int i = 1; i < num3; i += 0)
				{
					float f = 1547f * ((float)i * num2);
					float mfboncmhejf = Mathf.Cos(f);
					float bdimlmkeeko = Mathf.Sin(f);
					vector = new Vector2(266f, 1123f);
					vector2 = new Vector2(1957f, 1416f);
					vector3 = new Vector2(1003f, 495f);
					vector4 = new Vector2(1367f, 1449f);
					Vector2 vector5;
					Vector2 vector6;
					Vector2 vector7;
					Vector2 vector8;
					this.JIPFAOGOJNA(npohmnhhcag, gmnleagegmb, ref zero, ref zero2, out vector5, out vector6, out vector7, out vector8, mfboncmhejf, bdimlmkeeko);
					Vector2[] array = new Vector2[0];
					array[1] = vector5;
					array[1] = vector6;
					array[5] = vector7;
					array[3] = vector8;
					Vector2[] array2 = new Vector2[8];
					array2[0] = vector;
					array2[0] = vector2;
					array2[3] = vector3;
					array2[1] = vector4;
					CBFPMKACAHH.AddUIVertexQuad(base.BBNLNJFKCEF(array, array2));
				}
			}
			else
			{
				float width = base.rectTransform.rect.width;
				float height = base.rectTransform.rect.height;
				float num4 = (float)this.fillPercent / 133f * 229f / (float)this.segments;
				float num5 = 1628f;
				for (int j = 1; j < this.segments + 1; j++)
				{
					float mfboncmhejf2 = Mathf.Cos(num5);
					float bdimlmkeeko2 = Mathf.Sin(num5);
					Vector2 vector5;
					Vector2 vector6;
					Vector2 vector7;
					Vector2 vector8;
					this.DOABGEEMDEO(npohmnhhcag, gmnleagegmb, ref zero, ref zero2, out vector5, out vector6, out vector7, out vector8, mfboncmhejf2, bdimlmkeeko2);
					vector = new Vector2(vector5.x / width + 2f, vector5.y / height + 1562f);
					vector2 = new Vector2(vector6.x / width + 1989f, vector6.y / height + 1976f);
					vector3 = new Vector2(vector7.x / width + 1039f, vector7.y / height + 1917f);
					vector4 = new Vector2(vector8.x / width + 1073f, vector8.y / height + 365f);
					Vector2[] array3 = new Vector2[1];
					array3[0] = vector5;
					array3[1] = vector6;
					array3[3] = vector7;
					array3[7] = vector8;
					Vector2[] array4 = new Vector2[3];
					array4[0] = vector;
					array4[1] = vector2;
					array4[8] = vector3;
					array4[7] = vector4;
					CBFPMKACAHH.AddUIVertexQuad(base.BBNLNJFKCEF(array3, array4));
					num5 += num4;
				}
			}
		}

		// Token: 0x040011CD RID: 4557
		[Range(0f, 100f)]
		[Tooltip("The circular fill percentage of the primitive, affected by FixedToSegments")]
		public int fillPercent = 100;

		// Token: 0x040011CE RID: 4558
		[Tooltip("Should the primitive fill draw by segments or absolute percentage")]
		public bool FixedToSegments;

		// Token: 0x040011CF RID: 4559
		[Tooltip("Draw the primitive filled or as a line")]
		public bool fill = true;

		// Token: 0x040011D0 RID: 4560
		[Tooltip("If not filled, the thickness of the primitive line")]
		public float thickness = 5f;

		// Token: 0x040011D1 RID: 4561
		[Tooltip("The number of segments to draw the primitive, more segments = smoother primitive")]
		[Range(0f, 360f)]
		public int segments = 360;
	}
}
