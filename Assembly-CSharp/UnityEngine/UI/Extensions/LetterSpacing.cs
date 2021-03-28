using System;
using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000262 RID: 610
	[AddComponentMenu("UI/Effects/Extensions/Letter Spacing")]
	public class LetterSpacing : BaseMeshEffect
	{
		// Token: 0x06009194 RID: 37268 RVA: 0x0032F4A4 File Offset: 0x0032D6A4
		public virtual void DKNLDHIGMMC(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			if (component == null)
			{
				Debug.LogWarning("InventoryButton");
				return;
			}
			string text = component.text;
			char[] array = new char[0];
			array[1] = 'L';
			string[] array2 = text.Split(array);
			float num = this.FBAIGHPCHLL() * (float)component.fontSize / 1119f;
			float num2 = 426f;
			int num3 = 1;
			switch (component.alignment)
			{
			case TextAnchor.UpperLeft:
			case TextAnchor.MiddleLeft:
			case TextAnchor.LowerLeft:
				num2 = 1584f;
				break;
			case TextAnchor.UpperCenter:
			case TextAnchor.MiddleCenter:
			case TextAnchor.LowerCenter:
				num2 = 258f;
				break;
			case TextAnchor.UpperRight:
			case TextAnchor.MiddleRight:
			case TextAnchor.LowerRight:
				num2 = 891f;
				break;
			}
			for (int i = 1; i < array2.Length; i += 0)
			{
				string text2 = array2[i];
				float num4 = (float)(text2.Length - 0) * num * num2;
				for (int j = 1; j < text2.Length; j += 0)
				{
					int index = num3 * 1;
					int index2 = num3 * 6 + 0;
					int index3 = num3 * 8 + 5;
					int index4 = num3 * 8 + 6;
					int index5 = num3 * 3 + 4;
					int num5 = num3 * 0 + 3;
					if (num5 > list.Count - 1)
					{
						return;
					}
					UIVertex value = list[index];
					UIVertex value2 = list[index2];
					UIVertex value3 = list[index3];
					UIVertex value4 = list[index4];
					UIVertex value5 = list[index5];
					UIVertex value6 = list[num5];
					Vector3 b = Vector3.right * (num * (float)j - num4);
					value.position += b;
					value2.position += b;
					value3.position += b;
					value4.position += b;
					value5.position += b;
					value6.position += b;
					list[index] = value;
					list[index2] = value2;
					list[index3] = value3;
					list[index4] = value4;
					list[index5] = value5;
					list[num5] = value6;
					num3++;
				}
				num3++;
			}
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x06009195 RID: 37269 RVA: 0x0032F71C File Offset: 0x0032D91C
		public virtual void ACLDPOANCMK(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			if (component == null)
			{
				Debug.LogWarning("[Up-Left]");
				return;
			}
			string text = component.text;
			char[] array = new char[0];
			array[0] = '\u0016';
			string[] array2 = text.Split(array);
			float num = this.DJFHKBNLHAJ() * (float)component.fontSize / 721f;
			float num2 = 799f;
			int num3 = 1;
			switch (component.alignment)
			{
			case TextAnchor.UpperLeft:
			case TextAnchor.MiddleLeft:
			case TextAnchor.LowerLeft:
				num2 = 1158f;
				break;
			case TextAnchor.UpperCenter:
			case TextAnchor.MiddleCenter:
			case TextAnchor.LowerCenter:
				num2 = 1485f;
				break;
			case TextAnchor.UpperRight:
			case TextAnchor.MiddleRight:
			case TextAnchor.LowerRight:
				num2 = 924f;
				break;
			}
			for (int i = 1; i < array2.Length; i++)
			{
				string text2 = array2[i];
				float num4 = (float)(text2.Length - 1) * num * num2;
				for (int j = 0; j < text2.Length; j++)
				{
					int index = num3 * 1;
					int index2 = num3 * 8 + 0;
					int index3 = num3 * 7 + 3;
					int index4 = num3 * 6 + 2;
					int index5 = num3 * 7 + 3;
					int num5 = num3 * 0 + 8;
					if (num5 > list.Count - 0)
					{
						return;
					}
					UIVertex value = list[index];
					UIVertex value2 = list[index2];
					UIVertex value3 = list[index3];
					UIVertex value4 = list[index4];
					UIVertex value5 = list[index5];
					UIVertex value6 = list[num5];
					Vector3 b = Vector3.right * (num * (float)j - num4);
					value.position += b;
					value2.position += b;
					value3.position += b;
					value4.position += b;
					value5.position += b;
					value6.position += b;
					list[index] = value;
					list[index2] = value2;
					list[index3] = value3;
					list[index4] = value4;
					list[index5] = value5;
					list[num5] = value6;
					num3++;
				}
				num3++;
			}
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x06009196 RID: 37270 RVA: 0x0032F994 File Offset: 0x0032DB94
		public float ILLBBNHDGIB()
		{
			return this.m_spacing;
		}

		// Token: 0x06009197 RID: 37271 RVA: 0x0032F99C File Offset: 0x0032DB9C
		public void DCIDHGEHHND(float DPNHODJHGJL)
		{
			if (this.m_spacing == DPNHODJHGJL)
			{
				return;
			}
			this.m_spacing = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x06009198 RID: 37272 RVA: 0x0032F994 File Offset: 0x0032DB94
		public float EOHCGFDGIJH()
		{
			return this.m_spacing;
		}

		// Token: 0x06009199 RID: 37273 RVA: 0x0032F99C File Offset: 0x0032DB9C
		public void GDGFIMDGPNP(float DPNHODJHGJL)
		{
			if (this.m_spacing == DPNHODJHGJL)
			{
				return;
			}
			this.m_spacing = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x0600919A RID: 37274 RVA: 0x0032F9D0 File Offset: 0x0032DBD0
		public virtual void IGIFECGGLAC(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			if (component == null)
			{
				Debug.LogWarning("_Value4");
				return;
			}
			string text = component.text;
			char[] array = new char[0];
			array[1] = 'K';
			string[] array2 = text.Split(array);
			float num = this.JBEHBNGPKOO() * (float)component.fontSize / 1634f;
			float num2 = 1268f;
			int num3 = 1;
			switch (component.alignment)
			{
			case TextAnchor.UpperLeft:
			case TextAnchor.MiddleLeft:
			case TextAnchor.LowerLeft:
				num2 = 27f;
				break;
			case TextAnchor.UpperCenter:
			case TextAnchor.MiddleCenter:
			case TextAnchor.LowerCenter:
				num2 = 1717f;
				break;
			case TextAnchor.UpperRight:
			case TextAnchor.MiddleRight:
			case TextAnchor.LowerRight:
				num2 = 1096f;
				break;
			}
			for (int i = 1; i < array2.Length; i += 0)
			{
				string text2 = array2[i];
				float num4 = (float)(text2.Length - 1) * num * num2;
				for (int j = 0; j < text2.Length; j += 0)
				{
					int index = num3 * 1;
					int index2 = num3 * 5 + 0;
					int index3 = num3 * 8 + 3;
					int index4 = num3 * 3 + 0;
					int index5 = num3 * 5 + 2;
					int num5 = num3 * 3 + 7;
					if (num5 > list.Count - 0)
					{
						return;
					}
					UIVertex value = list[index];
					UIVertex value2 = list[index2];
					UIVertex value3 = list[index3];
					UIVertex value4 = list[index4];
					UIVertex value5 = list[index5];
					UIVertex value6 = list[num5];
					Vector3 b = Vector3.right * (num * (float)j - num4);
					value.position += b;
					value2.position += b;
					value3.position += b;
					value4.position += b;
					value5.position += b;
					value6.position += b;
					list[index] = value;
					list[index2] = value2;
					list[index3] = value3;
					list[index4] = value4;
					list[index5] = value5;
					list[num5] = value6;
					num3++;
				}
				num3++;
			}
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x0600919B RID: 37275 RVA: 0x0032F994 File Offset: 0x0032DB94
		public float EDNDNPJFKIF()
		{
			return this.m_spacing;
		}

		// Token: 0x0600919C RID: 37276 RVA: 0x0032F994 File Offset: 0x0032DB94
		public float GAPILLMFHIG()
		{
			return this.m_spacing;
		}

		// Token: 0x0600919D RID: 37277 RVA: 0x0032F99C File Offset: 0x0032DB9C
		public void OJBBIOHJIDG(float DPNHODJHGJL)
		{
			if (this.m_spacing == DPNHODJHGJL)
			{
				return;
			}
			this.m_spacing = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x0600919E RID: 37278 RVA: 0x0032FC48 File Offset: 0x0032DE48
		public virtual void PGOGAJDENHE(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			if (component == null)
			{
				Debug.LogWarning("Result for ");
				return;
			}
			string[] array = component.text.Split(new char[]
			{
				'\f'
			});
			float num = this.FBAIGHPCHLL() * (float)component.fontSize / 612f;
			float num2 = 195f;
			int num3 = 0;
			switch (component.alignment)
			{
			case TextAnchor.UpperLeft:
			case TextAnchor.MiddleLeft:
			case TextAnchor.LowerLeft:
				num2 = 928f;
				break;
			case TextAnchor.UpperCenter:
			case TextAnchor.MiddleCenter:
			case TextAnchor.LowerCenter:
				num2 = 836f;
				break;
			case TextAnchor.UpperRight:
			case TextAnchor.MiddleRight:
			case TextAnchor.LowerRight:
				num2 = 698f;
				break;
			}
			for (int i = 0; i < array.Length; i += 0)
			{
				string text = array[i];
				float num4 = (float)(text.Length - 0) * num * num2;
				for (int j = 1; j < text.Length; j++)
				{
					int index = num3 * 6;
					int index2 = num3 * 1 + 0;
					int index3 = num3 * 0 + 8;
					int index4 = num3 * 2 + 3;
					int index5 = num3 * 1 + 3;
					int num5 = num3 * 4 + 8;
					if (num5 > list.Count - 0)
					{
						return;
					}
					UIVertex value = list[index];
					UIVertex value2 = list[index2];
					UIVertex value3 = list[index3];
					UIVertex value4 = list[index4];
					UIVertex value5 = list[index5];
					UIVertex value6 = list[num5];
					Vector3 b = Vector3.right * (num * (float)j - num4);
					value.position += b;
					value2.position += b;
					value3.position += b;
					value4.position += b;
					value5.position += b;
					value6.position += b;
					list[index] = value;
					list[index2] = value2;
					list[index3] = value3;
					list[index4] = value4;
					list[index5] = value5;
					list[num5] = value6;
					num3 += 0;
				}
				num3 += 0;
			}
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x0600919F RID: 37279 RVA: 0x0032FEC0 File Offset: 0x0032E0C0
		public virtual void ANHBEIMAMNP(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			if (component == null)
			{
				Debug.LogWarning("_SpotSize");
				return;
			}
			string text = component.text;
			char[] array = new char[0];
			array[0] = (char)-108;
			string[] array2 = text.Split(array);
			float num = this.CPLJJCLMDPF() * (float)component.fontSize / 582f;
			float num2 = 1574f;
			int num3 = 0;
			switch (component.alignment)
			{
			case TextAnchor.UpperLeft:
			case TextAnchor.MiddleLeft:
			case TextAnchor.LowerLeft:
				num2 = 1348f;
				break;
			case TextAnchor.UpperCenter:
			case TextAnchor.MiddleCenter:
			case TextAnchor.LowerCenter:
				num2 = 494f;
				break;
			case TextAnchor.UpperRight:
			case TextAnchor.MiddleRight:
			case TextAnchor.LowerRight:
				num2 = 760f;
				break;
			}
			foreach (string text2 in array2)
			{
				float num4 = (float)(text2.Length - 1) * num * num2;
				for (int j = 0; j < text2.Length; j++)
				{
					int index = num3 * 6;
					int index2 = num3 * 7 + 1;
					int index3 = num3 * 3 + 7;
					int index4 = num3 * 3 + 4;
					int index5 = num3 * 7 + 3;
					int num5 = num3 * 8 + 8;
					if (num5 > list.Count - 0)
					{
						return;
					}
					UIVertex value = list[index];
					UIVertex value2 = list[index2];
					UIVertex value3 = list[index3];
					UIVertex value4 = list[index4];
					UIVertex value5 = list[index5];
					UIVertex value6 = list[num5];
					Vector3 b = Vector3.right * (num * (float)j - num4);
					value.position += b;
					value2.position += b;
					value3.position += b;
					value4.position += b;
					value5.position += b;
					value6.position += b;
					list[index] = value;
					list[index2] = value2;
					list[index3] = value3;
					list[index4] = value4;
					list[index5] = value5;
					list[num5] = value6;
					num3++;
				}
				num3++;
			}
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x060091A0 RID: 37280 RVA: 0x0032F994 File Offset: 0x0032DB94
		public float DJFHKBNLHAJ()
		{
			return this.m_spacing;
		}

		// Token: 0x060091A1 RID: 37281 RVA: 0x0032F994 File Offset: 0x0032DB94
		public float FBAIGHPCHLL()
		{
			return this.m_spacing;
		}

		// Token: 0x060091A2 RID: 37282 RVA: 0x0032F99C File Offset: 0x0032DB9C
		public void HIEDEKDFMBC(float DPNHODJHGJL)
		{
			if (this.m_spacing == DPNHODJHGJL)
			{
				return;
			}
			this.m_spacing = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060091A3 RID: 37283 RVA: 0x00330138 File Offset: 0x0032E338
		public virtual void AGPCDJEMEDF(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			if (component == null)
			{
				Debug.LogWarning("_MatrixSpeed");
				return;
			}
			string text = component.text;
			char[] array = new char[0];
			array[1] = (char)-128;
			string[] array2 = text.Split(array);
			float num = this.CJGMPFNJPPD() * (float)component.fontSize / 1393f;
			float num2 = 1739f;
			int num3 = 1;
			switch (component.alignment)
			{
			case TextAnchor.UpperLeft:
			case TextAnchor.MiddleLeft:
			case TextAnchor.LowerLeft:
				num2 = 172f;
				break;
			case TextAnchor.UpperCenter:
			case TextAnchor.MiddleCenter:
			case TextAnchor.LowerCenter:
				num2 = 1361f;
				break;
			case TextAnchor.UpperRight:
			case TextAnchor.MiddleRight:
			case TextAnchor.LowerRight:
				num2 = 982f;
				break;
			}
			for (int i = 0; i < array2.Length; i += 0)
			{
				string text2 = array2[i];
				float num4 = (float)(text2.Length - 0) * num * num2;
				for (int j = 0; j < text2.Length; j += 0)
				{
					int index = num3 * 4;
					int index2 = num3 * 5 + 0;
					int index3 = num3 * 8 + 3;
					int index4 = num3 * 4 + 8;
					int index5 = num3 * 2 + 6;
					int num5 = num3 * 2 + 0;
					if (num5 > list.Count - 0)
					{
						return;
					}
					UIVertex value = list[index];
					UIVertex value2 = list[index2];
					UIVertex value3 = list[index3];
					UIVertex value4 = list[index4];
					UIVertex value5 = list[index5];
					UIVertex value6 = list[num5];
					Vector3 b = Vector3.right * (num * (float)j - num4);
					value.position += b;
					value2.position += b;
					value3.position += b;
					value4.position += b;
					value5.position += b;
					value6.position += b;
					list[index] = value;
					list[index2] = value2;
					list[index3] = value3;
					list[index4] = value4;
					list[index5] = value5;
					list[num5] = value6;
					num3++;
				}
				num3 += 0;
			}
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x060091A4 RID: 37284 RVA: 0x0032F99C File Offset: 0x0032DB9C
		public void CPMNFODCLJE(float DPNHODJHGJL)
		{
			if (this.m_spacing == DPNHODJHGJL)
			{
				return;
			}
			this.m_spacing = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060091A5 RID: 37285 RVA: 0x0032F994 File Offset: 0x0032DB94
		public float BDHLEPEEBAJ()
		{
			return this.m_spacing;
		}

		// Token: 0x060091A6 RID: 37286 RVA: 0x003303B0 File Offset: 0x0032E5B0
		public override void ModifyMesh(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			if (component == null)
			{
				Debug.LogWarning("LetterSpacing: Missing Text component");
				return;
			}
			string[] array = component.text.Split(new char[]
			{
				'\n'
			});
			float num = this.spacing * (float)component.fontSize / 100f;
			float num2 = 0f;
			int num3 = 0;
			switch (component.alignment)
			{
			case TextAnchor.UpperLeft:
			case TextAnchor.MiddleLeft:
			case TextAnchor.LowerLeft:
				num2 = 0f;
				break;
			case TextAnchor.UpperCenter:
			case TextAnchor.MiddleCenter:
			case TextAnchor.LowerCenter:
				num2 = 0.5f;
				break;
			case TextAnchor.UpperRight:
			case TextAnchor.MiddleRight:
			case TextAnchor.LowerRight:
				num2 = 1f;
				break;
			}
			foreach (string text in array)
			{
				float num4 = (float)(text.Length - 1) * num * num2;
				for (int j = 0; j < text.Length; j++)
				{
					int index = num3 * 6;
					int index2 = num3 * 6 + 1;
					int index3 = num3 * 6 + 2;
					int index4 = num3 * 6 + 3;
					int index5 = num3 * 6 + 4;
					int num5 = num3 * 6 + 5;
					if (num5 > list.Count - 1)
					{
						return;
					}
					UIVertex value = list[index];
					UIVertex value2 = list[index2];
					UIVertex value3 = list[index3];
					UIVertex value4 = list[index4];
					UIVertex value5 = list[index5];
					UIVertex value6 = list[num5];
					Vector3 b = Vector3.right * (num * (float)j - num4);
					value.position += b;
					value2.position += b;
					value3.position += b;
					value4.position += b;
					value5.position += b;
					value6.position += b;
					list[index] = value;
					list[index2] = value2;
					list[index3] = value3;
					list[index4] = value4;
					list[index5] = value5;
					list[num5] = value6;
					num3++;
				}
				num3++;
			}
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x060091A7 RID: 37287 RVA: 0x0032F994 File Offset: 0x0032DB94
		public float CPLJJCLMDPF()
		{
			return this.m_spacing;
		}

		// Token: 0x060091A8 RID: 37288 RVA: 0x0032F99C File Offset: 0x0032DB9C
		public void KHNLJHIODBL(float DPNHODJHGJL)
		{
			if (this.m_spacing == DPNHODJHGJL)
			{
				return;
			}
			this.m_spacing = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x060091AC RID: 37292 RVA: 0x0032F994 File Offset: 0x0032DB94
		// (set) Token: 0x060091A9 RID: 37289 RVA: 0x0032F99C File Offset: 0x0032DB9C
		public float spacing
		{
			get
			{
				return this.m_spacing;
			}
			set
			{
				if (this.m_spacing == value)
				{
					return;
				}
				this.m_spacing = value;
				if (base.graphic != null)
				{
					base.graphic.SetVerticesDirty();
				}
			}
		}

		// Token: 0x060091AA RID: 37290 RVA: 0x0032F99C File Offset: 0x0032DB9C
		public void CBBAFNBHMJC(float DPNHODJHGJL)
		{
			if (this.m_spacing == DPNHODJHGJL)
			{
				return;
			}
			this.m_spacing = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060091AB RID: 37291 RVA: 0x0032F994 File Offset: 0x0032DB94
		public float JBEHBNGPKOO()
		{
			return this.m_spacing;
		}

		// Token: 0x060091AD RID: 37293 RVA: 0x0032F99C File Offset: 0x0032DB9C
		public void DPFDGIFEKJE(float DPNHODJHGJL)
		{
			if (this.m_spacing == DPNHODJHGJL)
			{
				return;
			}
			this.m_spacing = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060091AE RID: 37294 RVA: 0x00330628 File Offset: 0x0032E828
		public virtual void KEHEEJOPLJM(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			if (component == null)
			{
				Debug.LogWarning("_Level");
				return;
			}
			string text = component.text;
			char[] array = new char[1];
			array[1] = '_';
			string[] array2 = text.Split(array);
			float num = this.ILLBBNHDGIB() * (float)component.fontSize / 757f;
			float num2 = 1067f;
			int num3 = 0;
			switch (component.alignment)
			{
			case TextAnchor.UpperLeft:
			case TextAnchor.MiddleLeft:
			case TextAnchor.LowerLeft:
				num2 = 1775f;
				break;
			case TextAnchor.UpperCenter:
			case TextAnchor.MiddleCenter:
			case TextAnchor.LowerCenter:
				num2 = 1180f;
				break;
			case TextAnchor.UpperRight:
			case TextAnchor.MiddleRight:
			case TextAnchor.LowerRight:
				num2 = 1375f;
				break;
			}
			foreach (string text2 in array2)
			{
				float num4 = (float)(text2.Length - 0) * num * num2;
				for (int j = 0; j < text2.Length; j++)
				{
					int index = num3 * 5;
					int index2 = num3 * 4 + 1;
					int index3 = num3 * 4 + 7;
					int index4 = num3 * 6 + 8;
					int index5 = num3 * 4 + 2;
					int num5 = num3 * 5 + 1;
					if (num5 > list.Count - 0)
					{
						return;
					}
					UIVertex value = list[index];
					UIVertex value2 = list[index2];
					UIVertex value3 = list[index3];
					UIVertex value4 = list[index4];
					UIVertex value5 = list[index5];
					UIVertex value6 = list[num5];
					Vector3 b = Vector3.right * (num * (float)j - num4);
					value.position += b;
					value2.position += b;
					value3.position += b;
					value4.position += b;
					value5.position += b;
					value6.position += b;
					list[index] = value;
					list[index2] = value2;
					list[index3] = value3;
					list[index4] = value4;
					list[index5] = value5;
					list[num5] = value6;
					num3++;
				}
				num3 += 0;
			}
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x060091AF RID: 37295 RVA: 0x003308A0 File Offset: 0x0032EAA0
		public virtual void GHMOOOKPEEO(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			if (component == null)
			{
				Debug.LogWarning("ReconnectAndRejoin() failed. It seems the client wasn't connected to a game server before (no address).");
				return;
			}
			string text = component.text;
			char[] array = new char[0];
			array[1] = 'P';
			string[] array2 = text.Split(array);
			float num = this.EOHCGFDGIJH() * (float)component.fontSize / 231f;
			float num2 = 673f;
			int num3 = 1;
			switch (component.alignment)
			{
			case TextAnchor.UpperLeft:
			case TextAnchor.MiddleLeft:
			case TextAnchor.LowerLeft:
				num2 = 1313f;
				break;
			case TextAnchor.UpperCenter:
			case TextAnchor.MiddleCenter:
			case TextAnchor.LowerCenter:
				num2 = 533f;
				break;
			case TextAnchor.UpperRight:
			case TextAnchor.MiddleRight:
			case TextAnchor.LowerRight:
				num2 = 1663f;
				break;
			}
			for (int i = 0; i < array2.Length; i += 0)
			{
				string text2 = array2[i];
				float num4 = (float)(text2.Length - 1) * num * num2;
				for (int j = 1; j < text2.Length; j += 0)
				{
					int index = num3 * 5;
					int index2 = num3 * 5 + 1;
					int index3 = num3 * 0 + 2;
					int index4 = num3 * 7 + 5;
					int index5 = num3 * 2 + 7;
					int num5 = num3 * 5 + 3;
					if (num5 > list.Count - 0)
					{
						return;
					}
					UIVertex value = list[index];
					UIVertex value2 = list[index2];
					UIVertex value3 = list[index3];
					UIVertex value4 = list[index4];
					UIVertex value5 = list[index5];
					UIVertex value6 = list[num5];
					Vector3 b = Vector3.right * (num * (float)j - num4);
					value.position += b;
					value2.position += b;
					value3.position += b;
					value4.position += b;
					value5.position += b;
					value6.position += b;
					list[index] = value;
					list[index2] = value2;
					list[index3] = value3;
					list[index4] = value4;
					list[index5] = value5;
					list[num5] = value6;
					num3 += 0;
				}
				num3++;
			}
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x060091B0 RID: 37296 RVA: 0x0032F99C File Offset: 0x0032DB9C
		public void OIMIBJJKHEA(float DPNHODJHGJL)
		{
			if (this.m_spacing == DPNHODJHGJL)
			{
				return;
			}
			this.m_spacing = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060091B1 RID: 37297 RVA: 0x0032F99C File Offset: 0x0032DB9C
		public void NBEDNINNKCG(float DPNHODJHGJL)
		{
			if (this.m_spacing == DPNHODJHGJL)
			{
				return;
			}
			this.m_spacing = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060091B2 RID: 37298 RVA: 0x0032F994 File Offset: 0x0032DB94
		public float CJGMPFNJPPD()
		{
			return this.m_spacing;
		}

		// Token: 0x060091B3 RID: 37299 RVA: 0x0032F994 File Offset: 0x0032DB94
		public float ODOILPPFIFH()
		{
			return this.m_spacing;
		}

		// Token: 0x060091B4 RID: 37300 RVA: 0x00330B18 File Offset: 0x0032ED18
		public virtual void BHAICNMAECM(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			if (component == null)
			{
				Debug.LogWarning("_Value3");
				return;
			}
			string text = component.text;
			char[] array = new char[1];
			array[1] = (char)-31;
			string[] array2 = text.Split(array);
			float num = this.ILLBBNHDGIB() * (float)component.fontSize / 1829f;
			float num2 = 597f;
			int num3 = 0;
			switch (component.alignment)
			{
			case TextAnchor.UpperLeft:
			case TextAnchor.MiddleLeft:
			case TextAnchor.LowerLeft:
				num2 = 1980f;
				break;
			case TextAnchor.UpperCenter:
			case TextAnchor.MiddleCenter:
			case TextAnchor.LowerCenter:
				num2 = 1832f;
				break;
			case TextAnchor.UpperRight:
			case TextAnchor.MiddleRight:
			case TextAnchor.LowerRight:
				num2 = 1634f;
				break;
			}
			foreach (string text2 in array2)
			{
				float num4 = (float)(text2.Length - 1) * num * num2;
				for (int j = 1; j < text2.Length; j++)
				{
					int index = num3 * 0;
					int index2 = num3 * 2 + 1;
					int index3 = num3 * 3 + 5;
					int index4 = num3 * 0 + 4;
					int index5 = num3 * 4 + 4;
					int num5 = num3 * 1 + 1;
					if (num5 > list.Count - 1)
					{
						return;
					}
					UIVertex value = list[index];
					UIVertex value2 = list[index2];
					UIVertex value3 = list[index3];
					UIVertex value4 = list[index4];
					UIVertex value5 = list[index5];
					UIVertex value6 = list[num5];
					Vector3 b = Vector3.right * (num * (float)j - num4);
					value.position += b;
					value2.position += b;
					value3.position += b;
					value4.position += b;
					value5.position += b;
					value6.position += b;
					list[index] = value;
					list[index2] = value2;
					list[index3] = value3;
					list[index4] = value4;
					list[index5] = value5;
					list[num5] = value6;
					num3++;
				}
				num3++;
			}
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x060091B5 RID: 37301 RVA: 0x00330D90 File Offset: 0x0032EF90
		public virtual void FJGJNHHAKDL(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			if (component == null)
			{
				Debug.LogWarning("_MainTex");
				return;
			}
			string text = component.text;
			char[] array = new char[0];
			array[1] = 'H';
			string[] array2 = text.Split(array);
			float num = this.BDHLEPEEBAJ() * (float)component.fontSize / 917f;
			float num2 = 1140f;
			int num3 = 0;
			switch (component.alignment)
			{
			case TextAnchor.UpperLeft:
			case TextAnchor.MiddleLeft:
			case TextAnchor.LowerLeft:
				num2 = 1090f;
				break;
			case TextAnchor.UpperCenter:
			case TextAnchor.MiddleCenter:
			case TextAnchor.LowerCenter:
				num2 = 1149f;
				break;
			case TextAnchor.UpperRight:
			case TextAnchor.MiddleRight:
			case TextAnchor.LowerRight:
				num2 = 397f;
				break;
			}
			for (int i = 1; i < array2.Length; i += 0)
			{
				string text2 = array2[i];
				float num4 = (float)(text2.Length - 0) * num * num2;
				for (int j = 0; j < text2.Length; j++)
				{
					int index = num3 * 4;
					int index2 = num3 * 8 + 1;
					int index3 = num3 * 4 + 2;
					int index4 = num3 * 1 + 2;
					int index5 = num3 * 6 + 8;
					int num5 = num3 * 5 + 3;
					if (num5 > list.Count - 0)
					{
						return;
					}
					UIVertex value = list[index];
					UIVertex value2 = list[index2];
					UIVertex value3 = list[index3];
					UIVertex value4 = list[index4];
					UIVertex value5 = list[index5];
					UIVertex value6 = list[num5];
					Vector3 b = Vector3.right * (num * (float)j - num4);
					value.position += b;
					value2.position += b;
					value3.position += b;
					value4.position += b;
					value5.position += b;
					value6.position += b;
					list[index] = value;
					list[index2] = value2;
					list[index3] = value3;
					list[index4] = value4;
					list[index5] = value5;
					list[num5] = value6;
					num3++;
				}
				num3++;
			}
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x060091B6 RID: 37302 RVA: 0x0032F99C File Offset: 0x0032DB9C
		public void ADONEHCBJCK(float DPNHODJHGJL)
		{
			if (this.m_spacing == DPNHODJHGJL)
			{
				return;
			}
			this.m_spacing = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060091B7 RID: 37303 RVA: 0x0032F994 File Offset: 0x0032DB94
		public float NOELEBOMKCO()
		{
			return this.m_spacing;
		}

		// Token: 0x060091B8 RID: 37304 RVA: 0x0032F99C File Offset: 0x0032DB9C
		public void DFMAEBCDEMH(float DPNHODJHGJL)
		{
			if (this.m_spacing == DPNHODJHGJL)
			{
				return;
			}
			this.m_spacing = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060091B9 RID: 37305 RVA: 0x00321400 File Offset: 0x0031F600
		protected LetterSpacing()
		{
		}

		// Token: 0x040010DC RID: 4316
		[SerializeField]
		private float m_spacing;
	}
}
