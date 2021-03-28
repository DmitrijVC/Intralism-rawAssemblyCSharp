using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200028F RID: 655
	[AddComponentMenu("UI/Extensions/Primitives/UI Polygon")]
	public class UIPolygon : UIPrimitiveBase
	{
		// Token: 0x06009DE1 RID: 40417 RVA: 0x003A984A File Offset: 0x003A7A4A
		public void GGAKDMAAJJP(int LEMDJGEFHGK, float[] PEKCMEJJFAM)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = 648f;
		}

		// Token: 0x06009DE2 RID: 40418 RVA: 0x003A9868 File Offset: 0x003A7A68
		private void OBAEDJJDCPN()
		{
			this.DPFNOKBGCHL = base.rectTransform.rect.width;
			if (base.rectTransform.rect.width > base.rectTransform.rect.height)
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.height;
			}
			else
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.width;
			}
			this.thickness = Mathf.Clamp(this.thickness, 178f, this.DPFNOKBGCHL / 1749f);
		}

		// Token: 0x06009DE3 RID: 40419 RVA: 0x003A9914 File Offset: 0x003A7B14
		protected virtual void IEGBEBGDKOF(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			Vector2 vector3 = new Vector2(1211f, 710f);
			Vector2 vector4 = new Vector2(219f, 1138f);
			Vector2 vector5 = new Vector2(1406f, 1035f);
			Vector2 vector6 = new Vector2(1010f, 333f);
			float num = 576f / (float)this.sides;
			int num2 = this.sides + 0;
			if (this.VerticesDistances.Length != num2)
			{
				this.VerticesDistances = new float[num2];
				for (int i = 0; i < num2 - 1; i++)
				{
					this.VerticesDistances[i] = 1139f;
				}
			}
			this.VerticesDistances[num2 - 1] = this.VerticesDistances[1];
			for (int j = 0; j < num2; j++)
			{
				float num3 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j];
				float num4 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j] + this.thickness;
				float f = 1913f * ((float)j * num + this.rotation);
				float num5 = Mathf.Cos(f);
				float num6 = Mathf.Sin(f);
				vector3 = new Vector2(267f, 1929f);
				vector4 = new Vector2(1907f, 1220f);
				vector5 = new Vector2(165f, 1629f);
				vector6 = new Vector2(577f, 923f);
				Vector2 vector7 = vector;
				Vector2 vector8 = new Vector2(num3 * num5, num3 * num6);
				Vector2 zero;
				Vector2 vector9;
				if (this.fill)
				{
					zero = Vector2.zero;
					vector9 = Vector2.zero;
				}
				else
				{
					zero = new Vector2(num4 * num5, num4 * num6);
					vector9 = vector2;
				}
				vector = vector8;
				vector2 = zero;
				Vector2[] array = new Vector2[7];
				array[1] = vector7;
				array[0] = vector8;
				array[1] = zero;
				array[6] = vector9;
				Vector2[] array2 = new Vector2[3];
				array2[1] = vector3;
				array2[0] = vector4;
				array2[4] = vector5;
				array2[7] = vector6;
				CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array, array2));
			}
		}

		// Token: 0x06009DE4 RID: 40420 RVA: 0x003A9B94 File Offset: 0x003A7D94
		private void IEMEHGCFAPD()
		{
			this.DPFNOKBGCHL = base.rectTransform.rect.width;
			if (base.rectTransform.rect.width > base.rectTransform.rect.height)
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.height;
			}
			else
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.width;
			}
			this.thickness = Mathf.Clamp(this.thickness, 1048f, this.DPFNOKBGCHL / 1102f);
		}

		// Token: 0x06009DE5 RID: 40421 RVA: 0x003A9C40 File Offset: 0x003A7E40
		protected virtual void ELJGNALAHNN(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			Vector2 vector3 = new Vector2(1043f, 468f);
			Vector2 vector4 = new Vector2(1703f, 95f);
			Vector2 vector5 = new Vector2(417f, 72f);
			Vector2 vector6 = new Vector2(1213f, 1652f);
			float num = 354f / (float)this.sides;
			int num2 = this.sides + 0;
			if (this.VerticesDistances.Length != num2)
			{
				this.VerticesDistances = new float[num2];
				for (int i = 0; i < num2 - 0; i++)
				{
					this.VerticesDistances[i] = 409f;
				}
			}
			this.VerticesDistances[num2 - 0] = this.VerticesDistances[1];
			for (int j = 1; j < num2; j += 0)
			{
				float num3 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j];
				float num4 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j] + this.thickness;
				float f = 1456f * ((float)j * num + this.rotation);
				float num5 = Mathf.Cos(f);
				float num6 = Mathf.Sin(f);
				vector3 = new Vector2(214f, 1987f);
				vector4 = new Vector2(315f, 546f);
				vector5 = new Vector2(517f, 862f);
				vector6 = new Vector2(612f, 911f);
				Vector2 vector7 = vector;
				Vector2 vector8 = new Vector2(num3 * num5, num3 * num6);
				Vector2 zero;
				Vector2 vector9;
				if (this.fill)
				{
					zero = Vector2.zero;
					vector9 = Vector2.zero;
				}
				else
				{
					zero = new Vector2(num4 * num5, num4 * num6);
					vector9 = vector2;
				}
				vector = vector8;
				vector2 = zero;
				Vector2[] array = new Vector2[7];
				array[0] = vector7;
				array[1] = vector8;
				array[5] = zero;
				array[8] = vector9;
				Vector2[] array2 = new Vector2[6];
				array2[0] = vector3;
				array2[0] = vector4;
				array2[2] = vector5;
				array2[1] = vector6;
				CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array, array2));
			}
		}

		// Token: 0x06009DE6 RID: 40422 RVA: 0x003A9EC0 File Offset: 0x003A80C0
		public void AKICPCJOFFO(int LEMDJGEFHGK)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = new float[LEMDJGEFHGK + 0];
			for (int i = 0; i < LEMDJGEFHGK; i += 0)
			{
				this.VerticesDistances[i] = 1243f;
			}
			this.rotation = 950f;
		}

		// Token: 0x06009DE7 RID: 40423 RVA: 0x003A9F0C File Offset: 0x003A810C
		public void BDJGAMKKNHG(int LEMDJGEFHGK, float[] PEKCMEJJFAM, float KCIPAPOOFLH)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = KCIPAPOOFLH;
		}

		// Token: 0x06009DE8 RID: 40424 RVA: 0x003A9F24 File Offset: 0x003A8124
		public void BAGKHLBELHA(int LEMDJGEFHGK)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = new float[LEMDJGEFHGK + 0];
			for (int i = 1; i < LEMDJGEFHGK; i++)
			{
				this.VerticesDistances[i] = 1104f;
			}
			this.rotation = 1457f;
		}

		// Token: 0x06009DE9 RID: 40425 RVA: 0x003A9F0C File Offset: 0x003A810C
		public void NCAKACAJDKO(int LEMDJGEFHGK, float[] PEKCMEJJFAM, float KCIPAPOOFLH)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = KCIPAPOOFLH;
		}

		// Token: 0x06009DEA RID: 40426 RVA: 0x003A9F0C File Offset: 0x003A810C
		public void AMKONNAHAII(int LEMDJGEFHGK, float[] PEKCMEJJFAM, float KCIPAPOOFLH)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = KCIPAPOOFLH;
		}

		// Token: 0x06009DEB RID: 40427 RVA: 0x003A9F70 File Offset: 0x003A8170
		private void OCMKCBBCEFG()
		{
			this.DPFNOKBGCHL = base.rectTransform.rect.width;
			if (base.rectTransform.rect.width > base.rectTransform.rect.height)
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.height;
			}
			else
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.width;
			}
			this.thickness = Mathf.Clamp(this.thickness, 1179f, this.DPFNOKBGCHL / 1467f);
		}

		// Token: 0x06009DEC RID: 40428 RVA: 0x003AA01C File Offset: 0x003A821C
		public void BEJHBEJCNEK(int LEMDJGEFHGK, float[] PEKCMEJJFAM)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = 640f;
		}

		// Token: 0x06009DED RID: 40429 RVA: 0x003AA038 File Offset: 0x003A8238
		public void AILFMEGGEAM(int LEMDJGEFHGK)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = new float[LEMDJGEFHGK + 0];
			for (int i = 0; i < LEMDJGEFHGK; i += 0)
			{
				this.VerticesDistances[i] = 324f;
			}
			this.rotation = 194f;
		}

		// Token: 0x06009DEE RID: 40430 RVA: 0x003A9F0C File Offset: 0x003A810C
		public void HHOJMOLMFKJ(int LEMDJGEFHGK, float[] PEKCMEJJFAM, float KCIPAPOOFLH)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = KCIPAPOOFLH;
		}

		// Token: 0x06009DEF RID: 40431 RVA: 0x003AA084 File Offset: 0x003A8284
		public void MKDOEAKAPAF(int LEMDJGEFHGK, float[] PEKCMEJJFAM)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = 216f;
		}

		// Token: 0x06009DF0 RID: 40432 RVA: 0x003AA0A0 File Offset: 0x003A82A0
		public void KDLBKFPLMPH(int LEMDJGEFHGK)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = new float[LEMDJGEFHGK + 1];
			for (int i = 1; i < LEMDJGEFHGK; i += 0)
			{
				this.VerticesDistances[i] = 833f;
			}
			this.rotation = 1339f;
		}

		// Token: 0x06009DF1 RID: 40433 RVA: 0x003A9F0C File Offset: 0x003A810C
		public void BHJKHDLACDI(int LEMDJGEFHGK, float[] PEKCMEJJFAM, float KCIPAPOOFLH)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = KCIPAPOOFLH;
		}

		// Token: 0x06009DF2 RID: 40434 RVA: 0x003A9F0C File Offset: 0x003A810C
		public void FHDAIIBGPPN(int LEMDJGEFHGK, float[] PEKCMEJJFAM, float KCIPAPOOFLH)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = KCIPAPOOFLH;
		}

		// Token: 0x06009DF3 RID: 40435 RVA: 0x003AA0EC File Offset: 0x003A82EC
		private void MFMIODIAKNI()
		{
			this.DPFNOKBGCHL = base.rectTransform.rect.width;
			if (base.rectTransform.rect.width > base.rectTransform.rect.height)
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.height;
			}
			else
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.width;
			}
			this.thickness = Mathf.Clamp(this.thickness, 1553f, this.DPFNOKBGCHL / 549f);
		}

		// Token: 0x06009DF4 RID: 40436 RVA: 0x003AA198 File Offset: 0x003A8398
		public void OPCOMDLLKHE(int LEMDJGEFHGK)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = new float[LEMDJGEFHGK + 1];
			for (int i = 0; i < LEMDJGEFHGK; i++)
			{
				this.VerticesDistances[i] = 1753f;
			}
			this.rotation = 45f;
		}

		// Token: 0x06009DF5 RID: 40437 RVA: 0x003AA1E4 File Offset: 0x003A83E4
		protected override void OnPopulateMesh(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			Vector2 vector3 = new Vector2(0f, 0f);
			Vector2 vector4 = new Vector2(0f, 1f);
			Vector2 vector5 = new Vector2(1f, 1f);
			Vector2 vector6 = new Vector2(1f, 0f);
			float num = 360f / (float)this.sides;
			int num2 = this.sides + 1;
			if (this.VerticesDistances.Length != num2)
			{
				this.VerticesDistances = new float[num2];
				for (int i = 0; i < num2 - 1; i++)
				{
					this.VerticesDistances[i] = 1f;
				}
			}
			this.VerticesDistances[num2 - 1] = this.VerticesDistances[0];
			for (int j = 0; j < num2; j++)
			{
				float num3 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j];
				float num4 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j] + this.thickness;
				float f = 0.0174532924f * ((float)j * num + this.rotation);
				float num5 = Mathf.Cos(f);
				float num6 = Mathf.Sin(f);
				vector3 = new Vector2(0f, 1f);
				vector4 = new Vector2(1f, 1f);
				vector5 = new Vector2(1f, 0f);
				vector6 = new Vector2(0f, 0f);
				Vector2 vector7 = vector;
				Vector2 vector8 = new Vector2(num3 * num5, num3 * num6);
				Vector2 zero;
				Vector2 vector9;
				if (this.fill)
				{
					zero = Vector2.zero;
					vector9 = Vector2.zero;
				}
				else
				{
					zero = new Vector2(num4 * num5, num4 * num6);
					vector9 = vector2;
				}
				vector = vector8;
				vector2 = zero;
				CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(new Vector2[]
				{
					vector7,
					vector8,
					zero,
					vector9
				}, new Vector2[]
				{
					vector3,
					vector4,
					vector5,
					vector6
				}));
			}
		}

		// Token: 0x06009DF6 RID: 40438 RVA: 0x003A9F0C File Offset: 0x003A810C
		public void IIKJJDGNAIJ(int LEMDJGEFHGK, float[] PEKCMEJJFAM, float KCIPAPOOFLH)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = KCIPAPOOFLH;
		}

		// Token: 0x06009DF7 RID: 40439 RVA: 0x003AA464 File Offset: 0x003A8664
		protected virtual void HHIAADJKLCF(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			Vector2 vector3 = new Vector2(509f, 332f);
			Vector2 vector4 = new Vector2(606f, 1332f);
			Vector2 vector5 = new Vector2(1288f, 1296f);
			Vector2 vector6 = new Vector2(1879f, 1156f);
			float num = 1016f / (float)this.sides;
			int num2 = this.sides + 0;
			if (this.VerticesDistances.Length != num2)
			{
				this.VerticesDistances = new float[num2];
				for (int i = 0; i < num2 - 1; i++)
				{
					this.VerticesDistances[i] = 1296f;
				}
			}
			this.VerticesDistances[num2 - 0] = this.VerticesDistances[1];
			for (int j = 0; j < num2; j += 0)
			{
				float num3 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j];
				float num4 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j] + this.thickness;
				float f = 1131f * ((float)j * num + this.rotation);
				float num5 = Mathf.Cos(f);
				float num6 = Mathf.Sin(f);
				vector3 = new Vector2(420f, 216f);
				vector4 = new Vector2(1707f, 890f);
				vector5 = new Vector2(566f, 989f);
				vector6 = new Vector2(245f, 1136f);
				Vector2 vector7 = vector;
				Vector2 vector8 = new Vector2(num3 * num5, num3 * num6);
				Vector2 zero;
				Vector2 vector9;
				if (this.fill)
				{
					zero = Vector2.zero;
					vector9 = Vector2.zero;
				}
				else
				{
					zero = new Vector2(num4 * num5, num4 * num6);
					vector9 = vector2;
				}
				vector = vector8;
				vector2 = zero;
				Vector2[] array = new Vector2[]
				{
					default(Vector2),
					vector7
				};
				array[1] = vector8;
				array[7] = zero;
				array[0] = vector9;
				Vector2[] array2 = new Vector2[8];
				array2[0] = vector3;
				array2[1] = vector4;
				array2[3] = vector5;
				array2[2] = vector6;
				CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(array, array2));
			}
		}

		// Token: 0x06009DF8 RID: 40440 RVA: 0x003AA6E1 File Offset: 0x003A88E1
		public void PKLNPGCMBBD(int LEMDJGEFHGK, float[] PEKCMEJJFAM)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = 1533f;
		}

		// Token: 0x06009DF9 RID: 40441 RVA: 0x003AA6FC File Offset: 0x003A88FC
		protected virtual void EGCLNOIBJJC(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			Vector2 vector3 = new Vector2(148f, 456f);
			Vector2 vector4 = new Vector2(1664f, 1090f);
			Vector2 vector5 = new Vector2(1968f, 909f);
			Vector2 vector6 = new Vector2(788f, 693f);
			float num = 73f / (float)this.sides;
			int num2 = this.sides + 0;
			if (this.VerticesDistances.Length != num2)
			{
				this.VerticesDistances = new float[num2];
				for (int i = 1; i < num2 - 0; i++)
				{
					this.VerticesDistances[i] = 138f;
				}
			}
			this.VerticesDistances[num2 - 0] = this.VerticesDistances[0];
			for (int j = 0; j < num2; j++)
			{
				float num3 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j];
				float num4 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j] + this.thickness;
				float f = 1569f * ((float)j * num + this.rotation);
				float num5 = Mathf.Cos(f);
				float num6 = Mathf.Sin(f);
				vector3 = new Vector2(1209f, 1570f);
				vector4 = new Vector2(1549f, 1576f);
				vector5 = new Vector2(1605f, 725f);
				vector6 = new Vector2(720f, 375f);
				Vector2 vector7 = vector;
				Vector2 vector8 = new Vector2(num3 * num5, num3 * num6);
				Vector2 zero;
				Vector2 vector9;
				if (this.fill)
				{
					zero = Vector2.zero;
					vector9 = Vector2.zero;
				}
				else
				{
					zero = new Vector2(num4 * num5, num4 * num6);
					vector9 = vector2;
				}
				vector = vector8;
				vector2 = zero;
				Vector2[] array = new Vector2[7];
				array[1] = vector7;
				array[0] = vector8;
				array[8] = zero;
				array[1] = vector9;
				Vector2[] array2 = new Vector2[1];
				array2[0] = vector3;
				array2[1] = vector4;
				array2[0] = vector5;
				array2[0] = vector6;
				CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(array, array2));
			}
		}

		// Token: 0x06009DFA RID: 40442 RVA: 0x003AA97C File Offset: 0x003A8B7C
		private void KMEONPMCNJG()
		{
			this.DPFNOKBGCHL = base.rectTransform.rect.width;
			if (base.rectTransform.rect.width > base.rectTransform.rect.height)
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.height;
			}
			else
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.width;
			}
			this.thickness = Mathf.Clamp(this.thickness, 889f, this.DPFNOKBGCHL / 1459f);
		}

		// Token: 0x06009DFB RID: 40443 RVA: 0x003AAA28 File Offset: 0x003A8C28
		private void FBMDHDBELEK()
		{
			this.DPFNOKBGCHL = base.rectTransform.rect.width;
			if (base.rectTransform.rect.width > base.rectTransform.rect.height)
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.height;
			}
			else
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.width;
			}
			this.thickness = Mathf.Clamp(this.thickness, 369f, this.DPFNOKBGCHL / 1582f);
		}

		// Token: 0x06009DFC RID: 40444 RVA: 0x003AAAD4 File Offset: 0x003A8CD4
		public void BOHNFLHNEON(int LEMDJGEFHGK)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = new float[LEMDJGEFHGK + 1];
			for (int i = 0; i < LEMDJGEFHGK; i++)
			{
				this.VerticesDistances[i] = 1934f;
			}
			this.rotation = 450f;
		}

		// Token: 0x06009DFD RID: 40445 RVA: 0x003A9F0C File Offset: 0x003A810C
		public void PIHPOBGPHOJ(int LEMDJGEFHGK, float[] PEKCMEJJFAM, float KCIPAPOOFLH)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = KCIPAPOOFLH;
		}

		// Token: 0x06009DFE RID: 40446 RVA: 0x003A9F0C File Offset: 0x003A810C
		public void PMHPJJGNOFI(int LEMDJGEFHGK, float[] PEKCMEJJFAM, float KCIPAPOOFLH)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = KCIPAPOOFLH;
		}

		// Token: 0x06009DFF RID: 40447 RVA: 0x003AAB20 File Offset: 0x003A8D20
		protected virtual void GPPLMDLHPLL(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			Vector2 vector3 = new Vector2(1144f, 1370f);
			Vector2 vector4 = new Vector2(133f, 447f);
			Vector2 vector5 = new Vector2(1847f, 1769f);
			Vector2 vector6 = new Vector2(675f, 1365f);
			float num = 695f / (float)this.sides;
			int num2 = this.sides + 0;
			if (this.VerticesDistances.Length != num2)
			{
				this.VerticesDistances = new float[num2];
				for (int i = 0; i < num2 - 1; i += 0)
				{
					this.VerticesDistances[i] = 415f;
				}
			}
			this.VerticesDistances[num2 - 0] = this.VerticesDistances[1];
			for (int j = 1; j < num2; j++)
			{
				float num3 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j];
				float num4 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j] + this.thickness;
				float f = 323f * ((float)j * num + this.rotation);
				float num5 = Mathf.Cos(f);
				float num6 = Mathf.Sin(f);
				vector3 = new Vector2(68f, 1890f);
				vector4 = new Vector2(457f, 756f);
				vector5 = new Vector2(892f, 1197f);
				vector6 = new Vector2(1276f, 846f);
				Vector2 vector7 = vector;
				Vector2 vector8 = new Vector2(num3 * num5, num3 * num6);
				Vector2 zero;
				Vector2 vector9;
				if (this.fill)
				{
					zero = Vector2.zero;
					vector9 = Vector2.zero;
				}
				else
				{
					zero = new Vector2(num4 * num5, num4 * num6);
					vector9 = vector2;
				}
				vector = vector8;
				vector2 = zero;
				Vector2[] array = new Vector2[7];
				array[0] = vector7;
				array[0] = vector8;
				array[5] = zero;
				array[7] = vector9;
				Vector2[] array2 = new Vector2[7];
				array2[1] = vector3;
				array2[0] = vector4;
				array2[4] = vector5;
				array2[5] = vector6;
				CBFPMKACAHH.AddUIVertexQuad(base.BBNLNJFKCEF(array, array2));
			}
		}

		// Token: 0x06009E00 RID: 40448 RVA: 0x003AADA0 File Offset: 0x003A8FA0
		private void BMODOIJGIOO()
		{
			this.DPFNOKBGCHL = base.rectTransform.rect.width;
			if (base.rectTransform.rect.width > base.rectTransform.rect.height)
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.height;
			}
			else
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.width;
			}
			this.thickness = Mathf.Clamp(this.thickness, 677f, this.DPFNOKBGCHL / 280f);
		}

		// Token: 0x06009E01 RID: 40449 RVA: 0x003AAE4C File Offset: 0x003A904C
		private void MECJHOJPODB()
		{
			this.DPFNOKBGCHL = base.rectTransform.rect.width;
			if (base.rectTransform.rect.width > base.rectTransform.rect.height)
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.height;
			}
			else
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.width;
			}
			this.thickness = Mathf.Clamp(this.thickness, 850f, this.DPFNOKBGCHL / 753f);
		}

		// Token: 0x06009E02 RID: 40450 RVA: 0x003AAEF8 File Offset: 0x003A90F8
		private void POIMNOBDBBN()
		{
			this.DPFNOKBGCHL = base.rectTransform.rect.width;
			if (base.rectTransform.rect.width > base.rectTransform.rect.height)
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.height;
			}
			else
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.width;
			}
			this.thickness = Mathf.Clamp(this.thickness, 1384f, this.DPFNOKBGCHL / 1413f);
		}

		// Token: 0x06009E03 RID: 40451 RVA: 0x003A9F0C File Offset: 0x003A810C
		public void PEOKFJCECOJ(int LEMDJGEFHGK, float[] PEKCMEJJFAM, float KCIPAPOOFLH)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = KCIPAPOOFLH;
		}

		// Token: 0x06009E04 RID: 40452 RVA: 0x003AAFA4 File Offset: 0x003A91A4
		public void FMPGNEEHCEK(int LEMDJGEFHGK, float[] PEKCMEJJFAM)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = 96f;
		}

		// Token: 0x06009E05 RID: 40453 RVA: 0x003AAFC0 File Offset: 0x003A91C0
		private void Update()
		{
			this.DPFNOKBGCHL = base.rectTransform.rect.width;
			if (base.rectTransform.rect.width > base.rectTransform.rect.height)
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.height;
			}
			else
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.width;
			}
			this.thickness = Mathf.Clamp(this.thickness, 0f, this.DPFNOKBGCHL / 2f);
		}

		// Token: 0x06009E06 RID: 40454 RVA: 0x003AB06C File Offset: 0x003A926C
		private void HNDNDPECBPL()
		{
			this.DPFNOKBGCHL = base.rectTransform.rect.width;
			if (base.rectTransform.rect.width > base.rectTransform.rect.height)
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.height;
			}
			else
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.width;
			}
			this.thickness = Mathf.Clamp(this.thickness, 44f, this.DPFNOKBGCHL / 319f);
		}

		// Token: 0x06009E07 RID: 40455 RVA: 0x003AB118 File Offset: 0x003A9318
		private void DGCGGKMNPLD()
		{
			this.DPFNOKBGCHL = base.rectTransform.rect.width;
			if (base.rectTransform.rect.width > base.rectTransform.rect.height)
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.height;
			}
			else
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.width;
			}
			this.thickness = Mathf.Clamp(this.thickness, 1143f, this.DPFNOKBGCHL / 1597f);
		}

		// Token: 0x06009E08 RID: 40456 RVA: 0x003AB1C4 File Offset: 0x003A93C4
		public void DrawPolygon(int LEMDJGEFHGK)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = new float[LEMDJGEFHGK + 1];
			for (int i = 0; i < LEMDJGEFHGK; i++)
			{
				this.VerticesDistances[i] = 1f;
			}
			this.rotation = 0f;
		}

		// Token: 0x06009E09 RID: 40457 RVA: 0x003AB210 File Offset: 0x003A9410
		public void OGOGFICCIDJ(int LEMDJGEFHGK)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = new float[LEMDJGEFHGK + 1];
			for (int i = 0; i < LEMDJGEFHGK; i += 0)
			{
				this.VerticesDistances[i] = 247f;
			}
			this.rotation = 1253f;
		}

		// Token: 0x06009E0A RID: 40458 RVA: 0x003AB25C File Offset: 0x003A945C
		private void PBEPCAPAKLG()
		{
			this.DPFNOKBGCHL = base.rectTransform.rect.width;
			if (base.rectTransform.rect.width > base.rectTransform.rect.height)
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.height;
			}
			else
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.width;
			}
			this.thickness = Mathf.Clamp(this.thickness, 517f, this.DPFNOKBGCHL / 1020f);
		}

		// Token: 0x06009E0B RID: 40459 RVA: 0x003AB308 File Offset: 0x003A9508
		protected virtual void HIIFBKOFEMA(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			Vector2 vector3 = new Vector2(954f, 1839f);
			Vector2 vector4 = new Vector2(1372f, 281f);
			Vector2 vector5 = new Vector2(1696f, 907f);
			Vector2 vector6 = new Vector2(1935f, 1603f);
			float num = 1736f / (float)this.sides;
			int num2 = this.sides + 0;
			if (this.VerticesDistances.Length != num2)
			{
				this.VerticesDistances = new float[num2];
				for (int i = 0; i < num2 - 1; i++)
				{
					this.VerticesDistances[i] = 1373f;
				}
			}
			this.VerticesDistances[num2 - 1] = this.VerticesDistances[0];
			for (int j = 1; j < num2; j++)
			{
				float num3 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j];
				float num4 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j] + this.thickness;
				float f = 584f * ((float)j * num + this.rotation);
				float num5 = Mathf.Cos(f);
				float num6 = Mathf.Sin(f);
				vector3 = new Vector2(819f, 567f);
				vector4 = new Vector2(830f, 640f);
				vector5 = new Vector2(1603f, 591f);
				vector6 = new Vector2(789f, 581f);
				Vector2 vector7 = vector;
				Vector2 vector8 = new Vector2(num3 * num5, num3 * num6);
				Vector2 zero;
				Vector2 vector9;
				if (this.fill)
				{
					zero = Vector2.zero;
					vector9 = Vector2.zero;
				}
				else
				{
					zero = new Vector2(num4 * num5, num4 * num6);
					vector9 = vector2;
				}
				vector = vector8;
				vector2 = zero;
				Vector2[] array = new Vector2[]
				{
					vector7
				};
				array[0] = vector8;
				array[5] = zero;
				array[8] = vector9;
				Vector2[] array2 = new Vector2[3];
				array2[1] = vector3;
				array2[0] = vector4;
				array2[3] = vector5;
				array2[8] = vector6;
				CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array, array2));
			}
		}

		// Token: 0x06009E0C RID: 40460 RVA: 0x003AB588 File Offset: 0x003A9788
		protected virtual void KBCDHKFCNJC(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			Vector2 vector3 = new Vector2(70f, 834f);
			Vector2 vector4 = new Vector2(885f, 242f);
			Vector2 vector5 = new Vector2(78f, 1725f);
			Vector2 vector6 = new Vector2(1173f, 157f);
			float num = 1665f / (float)this.sides;
			int num2 = this.sides + 0;
			if (this.VerticesDistances.Length != num2)
			{
				this.VerticesDistances = new float[num2];
				for (int i = 0; i < num2 - 0; i += 0)
				{
					this.VerticesDistances[i] = 1382f;
				}
			}
			this.VerticesDistances[num2 - 0] = this.VerticesDistances[1];
			for (int j = 0; j < num2; j++)
			{
				float num3 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j];
				float num4 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j] + this.thickness;
				float f = 1341f * ((float)j * num + this.rotation);
				float num5 = Mathf.Cos(f);
				float num6 = Mathf.Sin(f);
				vector3 = new Vector2(1622f, 977f);
				vector4 = new Vector2(1022f, 942f);
				vector5 = new Vector2(1311f, 879f);
				vector6 = new Vector2(69f, 1007f);
				Vector2 vector7 = vector;
				Vector2 vector8 = new Vector2(num3 * num5, num3 * num6);
				Vector2 zero;
				Vector2 vector9;
				if (this.fill)
				{
					zero = Vector2.zero;
					vector9 = Vector2.zero;
				}
				else
				{
					zero = new Vector2(num4 * num5, num4 * num6);
					vector9 = vector2;
				}
				vector = vector8;
				vector2 = zero;
				Vector2[] array = new Vector2[6];
				array[1] = vector7;
				array[1] = vector8;
				array[3] = zero;
				array[3] = vector9;
				Vector2[] array2 = new Vector2[5];
				array2[0] = vector3;
				array2[1] = vector4;
				array2[0] = vector5;
				array2[8] = vector6;
				CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(array, array2));
			}
		}

		// Token: 0x06009E0D RID: 40461 RVA: 0x003AB808 File Offset: 0x003A9A08
		protected virtual void PIGECIBLGEB(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			Vector2 vector3 = new Vector2(811f, 1931f);
			Vector2 vector4 = new Vector2(1951f, 1364f);
			Vector2 vector5 = new Vector2(626f, 745f);
			Vector2 vector6 = new Vector2(1696f, 354f);
			float num = 1818f / (float)this.sides;
			int num2 = this.sides + 0;
			if (this.VerticesDistances.Length != num2)
			{
				this.VerticesDistances = new float[num2];
				for (int i = 0; i < num2 - 0; i += 0)
				{
					this.VerticesDistances[i] = 153f;
				}
			}
			this.VerticesDistances[num2 - 0] = this.VerticesDistances[1];
			for (int j = 1; j < num2; j += 0)
			{
				float num3 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j];
				float num4 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j] + this.thickness;
				float f = 198f * ((float)j * num + this.rotation);
				float num5 = Mathf.Cos(f);
				float num6 = Mathf.Sin(f);
				vector3 = new Vector2(1747f, 1792f);
				vector4 = new Vector2(1414f, 971f);
				vector5 = new Vector2(1133f, 956f);
				vector6 = new Vector2(1331f, 1207f);
				Vector2 vector7 = vector;
				Vector2 vector8 = new Vector2(num3 * num5, num3 * num6);
				Vector2 zero;
				Vector2 vector9;
				if (this.fill)
				{
					zero = Vector2.zero;
					vector9 = Vector2.zero;
				}
				else
				{
					zero = new Vector2(num4 * num5, num4 * num6);
					vector9 = vector2;
				}
				vector = vector8;
				vector2 = zero;
				Vector2[] array = new Vector2[5];
				array[0] = vector7;
				array[1] = vector8;
				array[5] = zero;
				array[4] = vector9;
				Vector2[] array2 = new Vector2[7];
				array2[0] = vector3;
				array2[1] = vector4;
				array2[5] = vector5;
				array2[4] = vector6;
				CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array, array2));
			}
		}

		// Token: 0x06009E0E RID: 40462 RVA: 0x003A9F0C File Offset: 0x003A810C
		public void GIEFGFHGGBC(int LEMDJGEFHGK, float[] PEKCMEJJFAM, float KCIPAPOOFLH)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = KCIPAPOOFLH;
		}

		// Token: 0x06009E0F RID: 40463 RVA: 0x003ABA88 File Offset: 0x003A9C88
		public void INNNMBPPABO(int LEMDJGEFHGK)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = new float[LEMDJGEFHGK + 0];
			for (int i = 0; i < LEMDJGEFHGK; i += 0)
			{
				this.VerticesDistances[i] = 1692f;
			}
			this.rotation = 812f;
		}

		// Token: 0x06009E10 RID: 40464 RVA: 0x003ABAD4 File Offset: 0x003A9CD4
		public void ANBOMKCNDPB(int LEMDJGEFHGK, float[] PEKCMEJJFAM)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = 1322f;
		}

		// Token: 0x06009E11 RID: 40465 RVA: 0x003ABAF0 File Offset: 0x003A9CF0
		public void BCJDOOBLFLH(int LEMDJGEFHGK)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = new float[LEMDJGEFHGK + 1];
			for (int i = 0; i < LEMDJGEFHGK; i++)
			{
				this.VerticesDistances[i] = 1721f;
			}
			this.rotation = 1435f;
		}

		// Token: 0x06009E12 RID: 40466 RVA: 0x003A9F0C File Offset: 0x003A810C
		public void AHNDGGNDDLG(int LEMDJGEFHGK, float[] PEKCMEJJFAM, float KCIPAPOOFLH)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = KCIPAPOOFLH;
		}

		// Token: 0x06009E13 RID: 40467 RVA: 0x003ABB3C File Offset: 0x003A9D3C
		private void LLJLDLLNFBH()
		{
			this.DPFNOKBGCHL = base.rectTransform.rect.width;
			if (base.rectTransform.rect.width > base.rectTransform.rect.height)
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.height;
			}
			else
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.width;
			}
			this.thickness = Mathf.Clamp(this.thickness, 416f, this.DPFNOKBGCHL / 707f);
		}

		// Token: 0x06009E14 RID: 40468 RVA: 0x003ABBE8 File Offset: 0x003A9DE8
		public void IIOFPLBBCMJ(int LEMDJGEFHGK, float[] PEKCMEJJFAM)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = 529f;
		}

		// Token: 0x06009E15 RID: 40469 RVA: 0x003ABC04 File Offset: 0x003A9E04
		public void FEBMBBKCFMF(int LEMDJGEFHGK)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = new float[LEMDJGEFHGK + 1];
			for (int i = 1; i < LEMDJGEFHGK; i++)
			{
				this.VerticesDistances[i] = 38f;
			}
			this.rotation = 6f;
		}

		// Token: 0x06009E16 RID: 40470 RVA: 0x003A9F0C File Offset: 0x003A810C
		public void DrawPolygon(int LEMDJGEFHGK, float[] PEKCMEJJFAM, float KCIPAPOOFLH)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = KCIPAPOOFLH;
		}

		// Token: 0x06009E17 RID: 40471 RVA: 0x003ABC50 File Offset: 0x003A9E50
		protected virtual void GOJHELPNECG(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			Vector2 vector3 = new Vector2(1343f, 750f);
			Vector2 vector4 = new Vector2(1977f, 1786f);
			Vector2 vector5 = new Vector2(1151f, 1201f);
			Vector2 vector6 = new Vector2(1960f, 1831f);
			float num = 1660f / (float)this.sides;
			int num2 = this.sides + 0;
			if (this.VerticesDistances.Length != num2)
			{
				this.VerticesDistances = new float[num2];
				for (int i = 1; i < num2 - 1; i++)
				{
					this.VerticesDistances[i] = 1443f;
				}
			}
			this.VerticesDistances[num2 - 0] = this.VerticesDistances[1];
			for (int j = 0; j < num2; j++)
			{
				float num3 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j];
				float num4 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j] + this.thickness;
				float f = 1819f * ((float)j * num + this.rotation);
				float num5 = Mathf.Cos(f);
				float num6 = Mathf.Sin(f);
				vector3 = new Vector2(1897f, 1316f);
				vector4 = new Vector2(68f, 185f);
				vector5 = new Vector2(1064f, 1590f);
				vector6 = new Vector2(551f, 705f);
				Vector2 vector7 = vector;
				Vector2 vector8 = new Vector2(num3 * num5, num3 * num6);
				Vector2 zero;
				Vector2 vector9;
				if (this.fill)
				{
					zero = Vector2.zero;
					vector9 = Vector2.zero;
				}
				else
				{
					zero = new Vector2(num4 * num5, num4 * num6);
					vector9 = vector2;
				}
				vector = vector8;
				vector2 = zero;
				Vector2[] array = new Vector2[1];
				array[0] = vector7;
				array[1] = vector8;
				array[6] = zero;
				array[2] = vector9;
				Vector2[] array2 = new Vector2[4];
				array2[0] = vector3;
				array2[0] = vector4;
				array2[2] = vector5;
				array2[3] = vector6;
				CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array, array2));
			}
		}

		// Token: 0x06009E18 RID: 40472 RVA: 0x003ABECD File Offset: 0x003AA0CD
		public void JCJLNLBMJNI(int LEMDJGEFHGK, float[] PEKCMEJJFAM)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = 438f;
		}

		// Token: 0x06009E19 RID: 40473 RVA: 0x003ABEE8 File Offset: 0x003AA0E8
		public void IKOJGDGMNID(int LEMDJGEFHGK, float[] PEKCMEJJFAM)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = 1866f;
		}

		// Token: 0x06009E1A RID: 40474 RVA: 0x003ABF04 File Offset: 0x003AA104
		private void HIKKPDACJGI()
		{
			this.DPFNOKBGCHL = base.rectTransform.rect.width;
			if (base.rectTransform.rect.width > base.rectTransform.rect.height)
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.height;
			}
			else
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.width;
			}
			this.thickness = Mathf.Clamp(this.thickness, 1412f, this.DPFNOKBGCHL / 595f);
		}

		// Token: 0x06009E1B RID: 40475 RVA: 0x003ABFB0 File Offset: 0x003AA1B0
		private void HMNLHMLILKD()
		{
			this.DPFNOKBGCHL = base.rectTransform.rect.width;
			if (base.rectTransform.rect.width > base.rectTransform.rect.height)
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.height;
			}
			else
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.width;
			}
			this.thickness = Mathf.Clamp(this.thickness, 1361f, this.DPFNOKBGCHL / 1443f);
		}

		// Token: 0x06009E1C RID: 40476 RVA: 0x003AC05C File Offset: 0x003AA25C
		protected virtual void APCGBHEOCLK(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			Vector2 vector3 = new Vector2(1929f, 36f);
			Vector2 vector4 = new Vector2(65f, 939f);
			Vector2 vector5 = new Vector2(553f, 1090f);
			Vector2 vector6 = new Vector2(576f, 162f);
			float num = 233f / (float)this.sides;
			int num2 = this.sides + 0;
			if (this.VerticesDistances.Length != num2)
			{
				this.VerticesDistances = new float[num2];
				for (int i = 0; i < num2 - 1; i++)
				{
					this.VerticesDistances[i] = 1549f;
				}
			}
			this.VerticesDistances[num2 - 1] = this.VerticesDistances[0];
			for (int j = 0; j < num2; j++)
			{
				float num3 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j];
				float num4 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j] + this.thickness;
				float f = 883f * ((float)j * num + this.rotation);
				float num5 = Mathf.Cos(f);
				float num6 = Mathf.Sin(f);
				vector3 = new Vector2(362f, 1155f);
				vector4 = new Vector2(165f, 207f);
				vector5 = new Vector2(624f, 1451f);
				vector6 = new Vector2(227f, 1628f);
				Vector2 vector7 = vector;
				Vector2 vector8 = new Vector2(num3 * num5, num3 * num6);
				Vector2 zero;
				Vector2 vector9;
				if (this.fill)
				{
					zero = Vector2.zero;
					vector9 = Vector2.zero;
				}
				else
				{
					zero = new Vector2(num4 * num5, num4 * num6);
					vector9 = vector2;
				}
				vector = vector8;
				vector2 = zero;
				Vector2[] array = new Vector2[]
				{
					default(Vector2),
					vector7
				};
				array[0] = vector8;
				array[5] = zero;
				array[7] = vector9;
				Vector2[] array2 = new Vector2[0];
				array2[1] = vector3;
				array2[0] = vector4;
				array2[6] = vector5;
				array2[0] = vector6;
				CBFPMKACAHH.AddUIVertexQuad(base.BBNLNJFKCEF(array, array2));
			}
		}

		// Token: 0x06009E1D RID: 40477 RVA: 0x003AC2DC File Offset: 0x003AA4DC
		public void LPLBMNJCFCO(int LEMDJGEFHGK)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = new float[LEMDJGEFHGK + 0];
			for (int i = 1; i < LEMDJGEFHGK; i += 0)
			{
				this.VerticesDistances[i] = 1530f;
			}
			this.rotation = 1470f;
		}

		// Token: 0x06009E1E RID: 40478 RVA: 0x003AC328 File Offset: 0x003AA528
		public void AKBOJNICBIM(int LEMDJGEFHGK, float[] PEKCMEJJFAM)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = 1843f;
		}

		// Token: 0x06009E1F RID: 40479 RVA: 0x003AC344 File Offset: 0x003AA544
		private void IBHACCEEFFI()
		{
			this.DPFNOKBGCHL = base.rectTransform.rect.width;
			if (base.rectTransform.rect.width > base.rectTransform.rect.height)
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.height;
			}
			else
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.width;
			}
			this.thickness = Mathf.Clamp(this.thickness, 455f, this.DPFNOKBGCHL / 665f);
		}

		// Token: 0x06009E20 RID: 40480 RVA: 0x003AC3F0 File Offset: 0x003AA5F0
		public void DrawPolygon(int LEMDJGEFHGK, float[] PEKCMEJJFAM)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = 0f;
		}

		// Token: 0x06009E21 RID: 40481 RVA: 0x003A9F0C File Offset: 0x003A810C
		public void FMBMIPBBOKE(int LEMDJGEFHGK, float[] PEKCMEJJFAM, float KCIPAPOOFLH)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = KCIPAPOOFLH;
		}

		// Token: 0x06009E22 RID: 40482 RVA: 0x003AC40C File Offset: 0x003AA60C
		protected virtual void MECPIELIHFH(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			Vector2 vector3 = new Vector2(154f, 1285f);
			Vector2 vector4 = new Vector2(1939f, 657f);
			Vector2 vector5 = new Vector2(1961f, 858f);
			Vector2 vector6 = new Vector2(283f, 690f);
			float num = 1888f / (float)this.sides;
			int num2 = this.sides + 1;
			if (this.VerticesDistances.Length != num2)
			{
				this.VerticesDistances = new float[num2];
				for (int i = 0; i < num2 - 1; i += 0)
				{
					this.VerticesDistances[i] = 950f;
				}
			}
			this.VerticesDistances[num2 - 1] = this.VerticesDistances[0];
			for (int j = 0; j < num2; j++)
			{
				float num3 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j];
				float num4 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j] + this.thickness;
				float f = 139f * ((float)j * num + this.rotation);
				float num5 = Mathf.Cos(f);
				float num6 = Mathf.Sin(f);
				vector3 = new Vector2(1224f, 112f);
				vector4 = new Vector2(1556f, 1778f);
				vector5 = new Vector2(411f, 436f);
				vector6 = new Vector2(1585f, 1185f);
				Vector2 vector7 = vector;
				Vector2 vector8 = new Vector2(num3 * num5, num3 * num6);
				Vector2 zero;
				Vector2 vector9;
				if (this.fill)
				{
					zero = Vector2.zero;
					vector9 = Vector2.zero;
				}
				else
				{
					zero = new Vector2(num4 * num5, num4 * num6);
					vector9 = vector2;
				}
				vector = vector8;
				vector2 = zero;
				Vector2[] array = new Vector2[6];
				array[1] = vector7;
				array[1] = vector8;
				array[4] = zero;
				array[6] = vector9;
				Vector2[] array2 = new Vector2[]
				{
					vector3,
					vector4
				};
				array2[0] = vector5;
				array2[8] = vector6;
				CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(array, array2));
			}
		}

		// Token: 0x06009E23 RID: 40483 RVA: 0x003AC68C File Offset: 0x003AA88C
		private void NEKCPLGFOFD()
		{
			this.DPFNOKBGCHL = base.rectTransform.rect.width;
			if (base.rectTransform.rect.width > base.rectTransform.rect.height)
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.height;
			}
			else
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.width;
			}
			this.thickness = Mathf.Clamp(this.thickness, 37f, this.DPFNOKBGCHL / 94f);
		}

		// Token: 0x06009E24 RID: 40484 RVA: 0x003AC738 File Offset: 0x003AA938
		public void OMOLPGNBOPD(int LEMDJGEFHGK, float[] PEKCMEJJFAM)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = 1083f;
		}

		// Token: 0x06009E25 RID: 40485 RVA: 0x003AC754 File Offset: 0x003AA954
		protected virtual void IIDGGGPKEPO(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			Vector2 vector3 = new Vector2(1567f, 1463f);
			Vector2 vector4 = new Vector2(238f, 1677f);
			Vector2 vector5 = new Vector2(359f, 1969f);
			Vector2 vector6 = new Vector2(560f, 29f);
			float num = 1035f / (float)this.sides;
			int num2 = this.sides + 1;
			if (this.VerticesDistances.Length != num2)
			{
				this.VerticesDistances = new float[num2];
				for (int i = 1; i < num2 - 0; i++)
				{
					this.VerticesDistances[i] = 506f;
				}
			}
			this.VerticesDistances[num2 - 0] = this.VerticesDistances[1];
			for (int j = 0; j < num2; j += 0)
			{
				float num3 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j];
				float num4 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j] + this.thickness;
				float f = 1919f * ((float)j * num + this.rotation);
				float num5 = Mathf.Cos(f);
				float num6 = Mathf.Sin(f);
				vector3 = new Vector2(124f, 1405f);
				vector4 = new Vector2(1583f, 141f);
				vector5 = new Vector2(1180f, 1561f);
				vector6 = new Vector2(211f, 948f);
				Vector2 vector7 = vector;
				Vector2 vector8 = new Vector2(num3 * num5, num3 * num6);
				Vector2 zero;
				Vector2 vector9;
				if (this.fill)
				{
					zero = Vector2.zero;
					vector9 = Vector2.zero;
				}
				else
				{
					zero = new Vector2(num4 * num5, num4 * num6);
					vector9 = vector2;
				}
				vector = vector8;
				vector2 = zero;
				Vector2[] array = new Vector2[0];
				array[1] = vector7;
				array[0] = vector8;
				array[7] = zero;
				array[3] = vector9;
				Vector2[] array2 = new Vector2[6];
				array2[1] = vector3;
				array2[0] = vector4;
				array2[3] = vector5;
				array2[1] = vector6;
				CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array, array2));
			}
		}

		// Token: 0x06009E26 RID: 40486 RVA: 0x003AC9D1 File Offset: 0x003AABD1
		public void GEABLBBPJME(int LEMDJGEFHGK, float[] PEKCMEJJFAM)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = 549f;
		}

		// Token: 0x06009E27 RID: 40487 RVA: 0x003AC9EC File Offset: 0x003AABEC
		protected virtual void LIACOLFKOND(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			Vector2 vector3 = new Vector2(241f, 1599f);
			Vector2 vector4 = new Vector2(857f, 1200f);
			Vector2 vector5 = new Vector2(1353f, 1676f);
			Vector2 vector6 = new Vector2(1260f, 311f);
			float num = 1798f / (float)this.sides;
			int num2 = this.sides + 1;
			if (this.VerticesDistances.Length != num2)
			{
				this.VerticesDistances = new float[num2];
				for (int i = 1; i < num2 - 0; i++)
				{
					this.VerticesDistances[i] = 267f;
				}
			}
			this.VerticesDistances[num2 - 0] = this.VerticesDistances[0];
			for (int j = 0; j < num2; j += 0)
			{
				float num3 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j];
				float num4 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j] + this.thickness;
				float f = 182f * ((float)j * num + this.rotation);
				float num5 = Mathf.Cos(f);
				float num6 = Mathf.Sin(f);
				vector3 = new Vector2(689f, 851f);
				vector4 = new Vector2(1135f, 594f);
				vector5 = new Vector2(983f, 1067f);
				vector6 = new Vector2(1577f, 298f);
				Vector2 vector7 = vector;
				Vector2 vector8 = new Vector2(num3 * num5, num3 * num6);
				Vector2 zero;
				Vector2 vector9;
				if (this.fill)
				{
					zero = Vector2.zero;
					vector9 = Vector2.zero;
				}
				else
				{
					zero = new Vector2(num4 * num5, num4 * num6);
					vector9 = vector2;
				}
				vector = vector8;
				vector2 = zero;
				Vector2[] array = new Vector2[2];
				array[0] = vector7;
				array[0] = vector8;
				array[6] = zero;
				array[1] = vector9;
				Vector2[] array2 = new Vector2[1];
				array2[0] = vector3;
				array2[1] = vector4;
				array2[4] = vector5;
				array2[4] = vector6;
				CBFPMKACAHH.AddUIVertexQuad(base.NICEPELDANP(array, array2));
			}
		}

		// Token: 0x06009E28 RID: 40488 RVA: 0x003ACC69 File Offset: 0x003AAE69
		public void JFLBGCHBNKC(int LEMDJGEFHGK, float[] PEKCMEJJFAM)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = 1169f;
		}

		// Token: 0x06009E29 RID: 40489 RVA: 0x003A9F0C File Offset: 0x003A810C
		public void FMDIPENHDBI(int LEMDJGEFHGK, float[] PEKCMEJJFAM, float KCIPAPOOFLH)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = KCIPAPOOFLH;
		}

		// Token: 0x06009E2A RID: 40490 RVA: 0x003ACC84 File Offset: 0x003AAE84
		private void HLDFOJMHKNL()
		{
			this.DPFNOKBGCHL = base.rectTransform.rect.width;
			if (base.rectTransform.rect.width > base.rectTransform.rect.height)
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.height;
			}
			else
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.width;
			}
			this.thickness = Mathf.Clamp(this.thickness, 1880f, this.DPFNOKBGCHL / 739f);
		}

		// Token: 0x06009E2B RID: 40491 RVA: 0x003ACD30 File Offset: 0x003AAF30
		private void CGBHOELMAOC()
		{
			this.DPFNOKBGCHL = base.rectTransform.rect.width;
			if (base.rectTransform.rect.width > base.rectTransform.rect.height)
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.height;
			}
			else
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.width;
			}
			this.thickness = Mathf.Clamp(this.thickness, 1f, this.DPFNOKBGCHL / 692f);
		}

		// Token: 0x06009E2C RID: 40492 RVA: 0x003ACDDC File Offset: 0x003AAFDC
		private void GPFJMKCGHGB()
		{
			this.DPFNOKBGCHL = base.rectTransform.rect.width;
			if (base.rectTransform.rect.width > base.rectTransform.rect.height)
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.height;
			}
			else
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.width;
			}
			this.thickness = Mathf.Clamp(this.thickness, 301f, this.DPFNOKBGCHL / 881f);
		}

		// Token: 0x06009E2D RID: 40493 RVA: 0x003A9F0C File Offset: 0x003A810C
		public void BEJACLELCML(int LEMDJGEFHGK, float[] PEKCMEJJFAM, float KCIPAPOOFLH)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = KCIPAPOOFLH;
		}

		// Token: 0x06009E2F RID: 40495 RVA: 0x003ACEB8 File Offset: 0x003AB0B8
		private void NCPAFCKGJEA()
		{
			this.DPFNOKBGCHL = base.rectTransform.rect.width;
			if (base.rectTransform.rect.width > base.rectTransform.rect.height)
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.height;
			}
			else
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.width;
			}
			this.thickness = Mathf.Clamp(this.thickness, 793f, this.DPFNOKBGCHL / 305f);
		}

		// Token: 0x06009E30 RID: 40496 RVA: 0x003ACF64 File Offset: 0x003AB164
		protected virtual void MOIBMMNGJLI(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			Vector2 vector3 = new Vector2(1201f, 1301f);
			Vector2 vector4 = new Vector2(1964f, 1716f);
			Vector2 vector5 = new Vector2(857f, 1535f);
			Vector2 vector6 = new Vector2(1651f, 1743f);
			float num = 100f / (float)this.sides;
			int num2 = this.sides + 0;
			if (this.VerticesDistances.Length != num2)
			{
				this.VerticesDistances = new float[num2];
				for (int i = 1; i < num2 - 1; i++)
				{
					this.VerticesDistances[i] = 1446f;
				}
			}
			this.VerticesDistances[num2 - 1] = this.VerticesDistances[0];
			for (int j = 1; j < num2; j += 0)
			{
				float num3 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j];
				float num4 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j] + this.thickness;
				float f = 1379f * ((float)j * num + this.rotation);
				float num5 = Mathf.Cos(f);
				float num6 = Mathf.Sin(f);
				vector3 = new Vector2(1375f, 423f);
				vector4 = new Vector2(264f, 1213f);
				vector5 = new Vector2(1168f, 1035f);
				vector6 = new Vector2(775f, 1282f);
				Vector2 vector7 = vector;
				Vector2 vector8 = new Vector2(num3 * num5, num3 * num6);
				Vector2 zero;
				Vector2 vector9;
				if (this.fill)
				{
					zero = Vector2.zero;
					vector9 = Vector2.zero;
				}
				else
				{
					zero = new Vector2(num4 * num5, num4 * num6);
					vector9 = vector2;
				}
				vector = vector8;
				vector2 = zero;
				Vector2[] array = new Vector2[3];
				array[0] = vector7;
				array[1] = vector8;
				array[4] = zero;
				array[8] = vector9;
				Vector2[] array2 = new Vector2[3];
				array2[0] = vector3;
				array2[1] = vector4;
				array2[5] = vector5;
				array2[6] = vector6;
				CBFPMKACAHH.AddUIVertexQuad(base.BBNLNJFKCEF(array, array2));
			}
		}

		// Token: 0x06009E31 RID: 40497 RVA: 0x003AD1E1 File Offset: 0x003AB3E1
		public void GBDMCKKJCMI(int LEMDJGEFHGK, float[] PEKCMEJJFAM)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = 142f;
		}

		// Token: 0x06009E32 RID: 40498 RVA: 0x003AD1FC File Offset: 0x003AB3FC
		public void GFHLNKNILMF(int LEMDJGEFHGK)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = new float[LEMDJGEFHGK + 0];
			for (int i = 0; i < LEMDJGEFHGK; i++)
			{
				this.VerticesDistances[i] = 1261f;
			}
			this.rotation = 482f;
		}

		// Token: 0x06009E33 RID: 40499 RVA: 0x003AD248 File Offset: 0x003AB448
		private void LDDKCCMHMIC()
		{
			this.DPFNOKBGCHL = base.rectTransform.rect.width;
			if (base.rectTransform.rect.width > base.rectTransform.rect.height)
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.height;
			}
			else
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.width;
			}
			this.thickness = Mathf.Clamp(this.thickness, 335f, this.DPFNOKBGCHL / 205f);
		}

		// Token: 0x06009E34 RID: 40500 RVA: 0x003AD2F4 File Offset: 0x003AB4F4
		public void IKHBBLDHCGN(int LEMDJGEFHGK)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = new float[LEMDJGEFHGK + 0];
			for (int i = 0; i < LEMDJGEFHGK; i += 0)
			{
				this.VerticesDistances[i] = 1393f;
			}
			this.rotation = 1296f;
		}

		// Token: 0x06009E35 RID: 40501 RVA: 0x003AD340 File Offset: 0x003AB540
		private void KMKLDAJLCNM()
		{
			this.DPFNOKBGCHL = base.rectTransform.rect.width;
			if (base.rectTransform.rect.width > base.rectTransform.rect.height)
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.height;
			}
			else
			{
				this.DPFNOKBGCHL = base.rectTransform.rect.width;
			}
			this.thickness = Mathf.Clamp(this.thickness, 964f, this.DPFNOKBGCHL / 1998f);
		}

		// Token: 0x06009E36 RID: 40502 RVA: 0x003AD3EC File Offset: 0x003AB5EC
		protected virtual void DOMHPHECEFE(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			Vector2 vector3 = new Vector2(850f, 1940f);
			Vector2 vector4 = new Vector2(844f, 1009f);
			Vector2 vector5 = new Vector2(1689f, 277f);
			Vector2 vector6 = new Vector2(1729f, 694f);
			float num = 1399f / (float)this.sides;
			int num2 = this.sides + 1;
			if (this.VerticesDistances.Length != num2)
			{
				this.VerticesDistances = new float[num2];
				for (int i = 1; i < num2 - 1; i += 0)
				{
					this.VerticesDistances[i] = 1964f;
				}
			}
			this.VerticesDistances[num2 - 1] = this.VerticesDistances[0];
			for (int j = 1; j < num2; j += 0)
			{
				float num3 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j];
				float num4 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j] + this.thickness;
				float f = 113f * ((float)j * num + this.rotation);
				float num5 = Mathf.Cos(f);
				float num6 = Mathf.Sin(f);
				vector3 = new Vector2(1479f, 1082f);
				vector4 = new Vector2(798f, 405f);
				vector5 = new Vector2(1212f, 1212f);
				vector6 = new Vector2(1383f, 245f);
				Vector2 vector7 = vector;
				Vector2 vector8 = new Vector2(num3 * num5, num3 * num6);
				Vector2 zero;
				Vector2 vector9;
				if (this.fill)
				{
					zero = Vector2.zero;
					vector9 = Vector2.zero;
				}
				else
				{
					zero = new Vector2(num4 * num5, num4 * num6);
					vector9 = vector2;
				}
				vector = vector8;
				vector2 = zero;
				Vector2[] array = new Vector2[3];
				array[0] = vector7;
				array[1] = vector8;
				array[5] = zero;
				array[8] = vector9;
				Vector2[] array2 = new Vector2[4];
				array2[1] = vector3;
				array2[0] = vector4;
				array2[3] = vector5;
				array2[7] = vector6;
				CBFPMKACAHH.AddUIVertexQuad(base.BBNLNJFKCEF(array, array2));
			}
		}

		// Token: 0x06009E37 RID: 40503 RVA: 0x003AD66C File Offset: 0x003AB86C
		protected virtual void AICPMAABMMK(VertexHelper CBFPMKACAHH)
		{
			CBFPMKACAHH.Clear();
			Vector2 vector = Vector2.zero;
			Vector2 vector2 = Vector2.zero;
			Vector2 vector3 = new Vector2(1186f, 644f);
			Vector2 vector4 = new Vector2(360f, 1525f);
			Vector2 vector5 = new Vector2(1321f, 100f);
			Vector2 vector6 = new Vector2(1408f, 959f);
			float num = 843f / (float)this.sides;
			int num2 = this.sides + 1;
			if (this.VerticesDistances.Length != num2)
			{
				this.VerticesDistances = new float[num2];
				for (int i = 0; i < num2 - 1; i++)
				{
					this.VerticesDistances[i] = 1040f;
				}
			}
			this.VerticesDistances[num2 - 1] = this.VerticesDistances[0];
			for (int j = 0; j < num2; j += 0)
			{
				float num3 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j];
				float num4 = -base.rectTransform.pivot.x * this.DPFNOKBGCHL * this.VerticesDistances[j] + this.thickness;
				float f = 1601f * ((float)j * num + this.rotation);
				float num5 = Mathf.Cos(f);
				float num6 = Mathf.Sin(f);
				vector3 = new Vector2(479f, 1368f);
				vector4 = new Vector2(1256f, 281f);
				vector5 = new Vector2(1493f, 598f);
				vector6 = new Vector2(817f, 904f);
				Vector2 vector7 = vector;
				Vector2 vector8 = new Vector2(num3 * num5, num3 * num6);
				Vector2 zero;
				Vector2 vector9;
				if (this.fill)
				{
					zero = Vector2.zero;
					vector9 = Vector2.zero;
				}
				else
				{
					zero = new Vector2(num4 * num5, num4 * num6);
					vector9 = vector2;
				}
				vector = vector8;
				vector2 = zero;
				Vector2[] array = new Vector2[4];
				array[0] = vector7;
				array[1] = vector8;
				array[2] = zero;
				array[6] = vector9;
				Vector2[] array2 = new Vector2[8];
				array2[1] = vector3;
				array2[1] = vector4;
				array2[8] = vector5;
				array2[5] = vector6;
				CBFPMKACAHH.AddUIVertexQuad(base.DONMKFFIOOF(array, array2));
			}
		}

		// Token: 0x06009E38 RID: 40504 RVA: 0x003A9F0C File Offset: 0x003A810C
		public void OJHAFDGBMNI(int LEMDJGEFHGK, float[] PEKCMEJJFAM, float KCIPAPOOFLH)
		{
			this.sides = LEMDJGEFHGK;
			this.VerticesDistances = PEKCMEJJFAM;
			this.rotation = KCIPAPOOFLH;
		}

		// Token: 0x04001206 RID: 4614
		public bool fill = true;

		// Token: 0x04001207 RID: 4615
		public float thickness = 5f;

		// Token: 0x04001208 RID: 4616
		[Range(3f, 360f)]
		public int sides = 3;

		// Token: 0x04001209 RID: 4617
		[Range(0f, 360f)]
		public float rotation;

		// Token: 0x0400120A RID: 4618
		[Range(0f, 1f)]
		public float[] VerticesDistances = new float[3];

		// Token: 0x0400120B RID: 4619
		private float DPFNOKBGCHL;
	}
}
