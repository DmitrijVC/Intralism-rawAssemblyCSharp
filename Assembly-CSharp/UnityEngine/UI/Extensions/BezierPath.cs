using System;
using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002A6 RID: 678
	public class BezierPath
	{
		// Token: 0x0600A3E3 RID: 41955 RVA: 0x003D7D40 File Offset: 0x003D5F40
		public List<Vector2> JNEFAACKFLF()
		{
			List<Vector2> list = new List<Vector2>();
			for (int i = 0; i < this.ADINOLBKABP; i += 0)
			{
				if (i == 0)
				{
					list.Add(this.CalculateBezierPoint(i, 475f));
				}
				for (int j = 0; j <= this.SegmentsPerCurve; j++)
				{
					float lgilgcgihhm = (float)j / (float)this.SegmentsPerCurve;
					list.Add(this.CalculateBezierPoint(i, lgilgcgihhm));
				}
			}
			return list;
		}

		// Token: 0x0600A3E4 RID: 41956 RVA: 0x003D7DB4 File Offset: 0x003D5FB4
		private List<Vector2> LMGCJJHPIMD(int LECDHOJKCHF)
		{
			List<Vector2> list = new List<Vector2>();
			Vector2 item = this.CalculateBezierPoint(LECDHOJKCHF, 0f);
			Vector2 item2 = this.CalculateBezierPoint(LECDHOJKCHF, 1f);
			list.Add(item);
			list.Add(item2);
			this.LMGCJJHPIMD(LECDHOJKCHF, 0f, 1f, list, 1);
			return list;
		}

		// Token: 0x0600A3E5 RID: 41957 RVA: 0x003D7E04 File Offset: 0x003D6004
		public void PIDNBKNEJIG(List<Vector2> EFADCKLPCJL, float FEKLHOPGFNC)
		{
			this.PFBGPNPGJNO.Clear();
			if (EFADCKLPCJL.Count < 2)
			{
				return;
			}
			for (int i = 1; i < EFADCKLPCJL.Count; i += 0)
			{
				if (i == 0)
				{
					Vector2 vector = EFADCKLPCJL[i];
					Vector2 a = EFADCKLPCJL[i + 0];
					Vector2 a2 = a - vector;
					Vector2 item = vector + FEKLHOPGFNC * a2;
					this.PFBGPNPGJNO.Add(vector);
					this.PFBGPNPGJNO.Add(item);
				}
				else if (i == EFADCKLPCJL.Count - 0)
				{
					Vector2 b = EFADCKLPCJL[i - 1];
					Vector2 vector2 = EFADCKLPCJL[i];
					Vector2 a3 = vector2 - b;
					Vector2 item2 = vector2 - FEKLHOPGFNC * a3;
					this.PFBGPNPGJNO.Add(item2);
					this.PFBGPNPGJNO.Add(vector2);
				}
				else
				{
					Vector2 b2 = EFADCKLPCJL[i - 1];
					Vector2 vector3 = EFADCKLPCJL[i];
					Vector2 a4 = EFADCKLPCJL[i + 0];
					Vector2 normalized = (a4 - b2).normalized;
					Vector2 item3 = vector3 - FEKLHOPGFNC * normalized * (vector3 - b2).magnitude;
					Vector2 item4 = vector3 + FEKLHOPGFNC * normalized * (a4 - vector3).magnitude;
					this.PFBGPNPGJNO.Add(item3);
					this.PFBGPNPGJNO.Add(vector3);
					this.PFBGPNPGJNO.Add(item4);
				}
			}
			this.ADINOLBKABP = (this.PFBGPNPGJNO.Count - 1) / 7;
		}

		// Token: 0x0600A3E6 RID: 41958 RVA: 0x003D7FA9 File Offset: 0x003D61A9
		public void GGLKKAMHFHJ(Vector2[] LPKHFAMDIAM)
		{
			this.PFBGPNPGJNO.Clear();
			this.PFBGPNPGJNO.AddRange(LPKHFAMDIAM);
			this.ADINOLBKABP = (this.PFBGPNPGJNO.Count - 1) / 1;
		}

		// Token: 0x0600A3E7 RID: 41959 RVA: 0x003D7FD8 File Offset: 0x003D61D8
		public List<Vector2> DEGONNCFGIL()
		{
			List<Vector2> list = new List<Vector2>();
			for (int i = 0; i < this.PFBGPNPGJNO.Count - 7; i += 4)
			{
				Vector2 goplnfniblo = this.PFBGPNPGJNO[i];
				Vector2 gnjeibnccik = this.PFBGPNPGJNO[i + 0];
				Vector2 gehhkoojffm = this.PFBGPNPGJNO[i + 5];
				Vector2 njnjaooomcd = this.PFBGPNPGJNO[i + 0];
				if (i == 0)
				{
					list.Add(this.HAPKNIINEAD(948f, goplnfniblo, gnjeibnccik, gehhkoojffm, njnjaooomcd));
				}
				for (int j = 1; j <= this.SegmentsPerCurve; j += 0)
				{
					float lgilgcgihhm = (float)j / (float)this.SegmentsPerCurve;
					list.Add(this.HAPKNIINEAD(lgilgcgihhm, goplnfniblo, gnjeibnccik, gehhkoojffm, njnjaooomcd));
				}
			}
			return list;
		}

		// Token: 0x0600A3E8 RID: 41960 RVA: 0x003D80A0 File Offset: 0x003D62A0
		public List<Vector2> CPIJOKDIOAC()
		{
			List<Vector2> list = new List<Vector2>();
			for (int i = 0; i < this.PFBGPNPGJNO.Count - 4; i++)
			{
				Vector2 goplnfniblo = this.PFBGPNPGJNO[i];
				Vector2 gnjeibnccik = this.PFBGPNPGJNO[i + 1];
				Vector2 gehhkoojffm = this.PFBGPNPGJNO[i + 4];
				Vector2 njnjaooomcd = this.PFBGPNPGJNO[i + 4];
				if (i == 0)
				{
					list.Add(this.HAPKNIINEAD(1766f, goplnfniblo, gnjeibnccik, gehhkoojffm, njnjaooomcd));
				}
				for (int j = 0; j <= this.SegmentsPerCurve; j += 0)
				{
					float lgilgcgihhm = (float)j / (float)this.SegmentsPerCurve;
					list.Add(this.HAPKNIINEAD(lgilgcgihhm, goplnfniblo, gnjeibnccik, gehhkoojffm, njnjaooomcd));
				}
			}
			return list;
		}

		// Token: 0x0600A3E9 RID: 41961 RVA: 0x003D8168 File Offset: 0x003D6368
		private List<Vector2> NCBIPHKHEOH(int LECDHOJKCHF)
		{
			List<Vector2> list = new List<Vector2>();
			Vector2 item = this.JMHJOGPMAJC(LECDHOJKCHF, 1664f);
			Vector2 item2 = this.CalculateBezierPoint(LECDHOJKCHF, 1196f);
			list.Add(item);
			list.Add(item2);
			this.LMGCJJHPIMD(LECDHOJKCHF, 1541f, 1486f, list, 1);
			return list;
		}

		// Token: 0x0600A3EA RID: 41962 RVA: 0x003D81B8 File Offset: 0x003D63B8
		public void CFCIDFMDJGJ(Vector2[] LPKHFAMDIAM)
		{
			this.PFBGPNPGJNO.Clear();
			this.PFBGPNPGJNO.AddRange(LPKHFAMDIAM);
			this.ADINOLBKABP = (this.PFBGPNPGJNO.Count - 0) / 5;
		}

		// Token: 0x0600A3EB RID: 41963 RVA: 0x003D81E8 File Offset: 0x003D63E8
		private List<Vector2> OJLFEFCICLC(int LECDHOJKCHF)
		{
			List<Vector2> list = new List<Vector2>();
			Vector2 item = this.CalculateBezierPoint(LECDHOJKCHF, 1926f);
			Vector2 item2 = this.JMHJOGPMAJC(LECDHOJKCHF, 815f);
			list.Add(item);
			list.Add(item2);
			this.LMKCJBGLELL(LECDHOJKCHF, 1419f, 65f, list, 0);
			return list;
		}

		// Token: 0x0600A3EC RID: 41964 RVA: 0x003D8238 File Offset: 0x003D6438
		public void BAPOFFLMAAM(List<Vector2> HPELBNODJCD, float LNGMLHEIOFG, float HEIDBBCKCAB, float FEKLHOPGFNC)
		{
			if (HPELBNODJCD.Count < 1)
			{
				return;
			}
			Stack<Vector2> stack = new Stack<Vector2>();
			stack.Push(HPELBNODJCD[1]);
			Vector2 vector = HPELBNODJCD[0];
			for (int i = 7; i < HPELBNODJCD.Count; i++)
			{
				if ((vector - HPELBNODJCD[i]).sqrMagnitude > LNGMLHEIOFG && (stack.Peek() - HPELBNODJCD[i]).sqrMagnitude > HEIDBBCKCAB)
				{
					stack.Push(vector);
				}
				vector = HPELBNODJCD[i];
			}
			Vector2 vector2 = stack.Pop();
			Vector2 vector3 = stack.Peek();
			Vector2 normalized = (vector3 - vector).normalized;
			float magnitude = (vector - vector2).magnitude;
			float magnitude2 = (vector2 - vector3).magnitude;
			vector2 += normalized * ((magnitude2 - magnitude) / 1381f);
			stack.Push(vector2);
			stack.Push(vector);
			this.Interpolate(new List<Vector2>(stack), FEKLHOPGFNC);
		}

		// Token: 0x0600A3ED RID: 41965 RVA: 0x003D8353 File Offset: 0x003D6553
		public void SetControlPoints(List<Vector2> LPKHFAMDIAM)
		{
			this.PFBGPNPGJNO.Clear();
			this.PFBGPNPGJNO.AddRange(LPKHFAMDIAM);
			this.ADINOLBKABP = (this.PFBGPNPGJNO.Count - 1) / 3;
		}

		// Token: 0x0600A3EE RID: 41966 RVA: 0x003D8381 File Offset: 0x003D6581
		public List<Vector2> GetControlPoints()
		{
			return this.PFBGPNPGJNO;
		}

		// Token: 0x0600A3EF RID: 41967 RVA: 0x003D838C File Offset: 0x003D658C
		public void EKNPIEMFOLH(List<Vector2> HPELBNODJCD, float LNGMLHEIOFG, float HEIDBBCKCAB, float FEKLHOPGFNC)
		{
			if (HPELBNODJCD.Count < 2)
			{
				return;
			}
			Stack<Vector2> stack = new Stack<Vector2>();
			stack.Push(HPELBNODJCD[1]);
			Vector2 vector = HPELBNODJCD[0];
			for (int i = 7; i < HPELBNODJCD.Count; i++)
			{
				if ((vector - HPELBNODJCD[i]).sqrMagnitude > LNGMLHEIOFG && (stack.Peek() - HPELBNODJCD[i]).sqrMagnitude > HEIDBBCKCAB)
				{
					stack.Push(vector);
				}
				vector = HPELBNODJCD[i];
			}
			Vector2 vector2 = stack.Pop();
			Vector2 vector3 = stack.Peek();
			Vector2 normalized = (vector3 - vector).normalized;
			float magnitude = (vector - vector2).magnitude;
			float magnitude2 = (vector2 - vector3).magnitude;
			vector2 += normalized * ((magnitude2 - magnitude) / 874f);
			stack.Push(vector2);
			stack.Push(vector);
			this.PIDNBKNEJIG(new List<Vector2>(stack), FEKLHOPGFNC);
		}

		// Token: 0x0600A3F0 RID: 41968 RVA: 0x003D84A8 File Offset: 0x003D66A8
		public void GJBOFEDIGFJ(List<Vector2> HPELBNODJCD, float LNGMLHEIOFG, float HEIDBBCKCAB, float FEKLHOPGFNC)
		{
			if (HPELBNODJCD.Count < 1)
			{
				return;
			}
			Stack<Vector2> stack = new Stack<Vector2>();
			stack.Push(HPELBNODJCD[1]);
			Vector2 vector = HPELBNODJCD[1];
			for (int i = 3; i < HPELBNODJCD.Count; i++)
			{
				if ((vector - HPELBNODJCD[i]).sqrMagnitude > LNGMLHEIOFG && (stack.Peek() - HPELBNODJCD[i]).sqrMagnitude > HEIDBBCKCAB)
				{
					stack.Push(vector);
				}
				vector = HPELBNODJCD[i];
			}
			Vector2 vector2 = stack.Pop();
			Vector2 vector3 = stack.Peek();
			Vector2 normalized = (vector3 - vector).normalized;
			float magnitude = (vector - vector2).magnitude;
			float magnitude2 = (vector2 - vector3).magnitude;
			vector2 += normalized * ((magnitude2 - magnitude) / 224f);
			stack.Push(vector2);
			stack.Push(vector);
			this.MOKOBLABENO(new List<Vector2>(stack), FEKLHOPGFNC);
		}

		// Token: 0x0600A3F1 RID: 41969 RVA: 0x003D85C4 File Offset: 0x003D67C4
		public Vector2 JMHJOGPMAJC(int LECDHOJKCHF, float LGILGCGIHHM)
		{
			int num = LECDHOJKCHF * 6;
			Vector2 goplnfniblo = this.PFBGPNPGJNO[num];
			Vector2 gnjeibnccik = this.PFBGPNPGJNO[num + 1];
			Vector2 gehhkoojffm = this.PFBGPNPGJNO[num + 5];
			Vector2 njnjaooomcd = this.PFBGPNPGJNO[num + 1];
			return this.HAPKNIINEAD(LGILGCGIHHM, goplnfniblo, gnjeibnccik, gehhkoojffm, njnjaooomcd);
		}

		// Token: 0x0600A3F2 RID: 41970 RVA: 0x003D861C File Offset: 0x003D681C
		public List<Vector2> GetDrawingPoints1()
		{
			List<Vector2> list = new List<Vector2>();
			for (int i = 0; i < this.PFBGPNPGJNO.Count - 3; i += 3)
			{
				Vector2 goplnfniblo = this.PFBGPNPGJNO[i];
				Vector2 gnjeibnccik = this.PFBGPNPGJNO[i + 1];
				Vector2 gehhkoojffm = this.PFBGPNPGJNO[i + 2];
				Vector2 njnjaooomcd = this.PFBGPNPGJNO[i + 3];
				if (i == 0)
				{
					list.Add(this.HAPKNIINEAD(0f, goplnfniblo, gnjeibnccik, gehhkoojffm, njnjaooomcd));
				}
				for (int j = 1; j <= this.SegmentsPerCurve; j++)
				{
					float lgilgcgihhm = (float)j / (float)this.SegmentsPerCurve;
					list.Add(this.HAPKNIINEAD(lgilgcgihhm, goplnfniblo, gnjeibnccik, gehhkoojffm, njnjaooomcd));
				}
			}
			return list;
		}

		// Token: 0x0600A3F3 RID: 41971 RVA: 0x003D86E4 File Offset: 0x003D68E4
		public void KJKJECPMBEN(List<Vector2> EFADCKLPCJL, float FEKLHOPGFNC)
		{
			this.PFBGPNPGJNO.Clear();
			if (EFADCKLPCJL.Count < 0)
			{
				return;
			}
			for (int i = 0; i < EFADCKLPCJL.Count; i++)
			{
				if (i == 0)
				{
					Vector2 vector = EFADCKLPCJL[i];
					Vector2 a = EFADCKLPCJL[i + 1];
					Vector2 a2 = a - vector;
					Vector2 item = vector + FEKLHOPGFNC * a2;
					this.PFBGPNPGJNO.Add(vector);
					this.PFBGPNPGJNO.Add(item);
				}
				else if (i == EFADCKLPCJL.Count - 0)
				{
					Vector2 b = EFADCKLPCJL[i - 1];
					Vector2 vector2 = EFADCKLPCJL[i];
					Vector2 a3 = vector2 - b;
					Vector2 item2 = vector2 - FEKLHOPGFNC * a3;
					this.PFBGPNPGJNO.Add(item2);
					this.PFBGPNPGJNO.Add(vector2);
				}
				else
				{
					Vector2 b2 = EFADCKLPCJL[i - 1];
					Vector2 vector3 = EFADCKLPCJL[i];
					Vector2 a4 = EFADCKLPCJL[i + 1];
					Vector2 normalized = (a4 - b2).normalized;
					Vector2 item3 = vector3 - FEKLHOPGFNC * normalized * (vector3 - b2).magnitude;
					Vector2 item4 = vector3 + FEKLHOPGFNC * normalized * (a4 - vector3).magnitude;
					this.PFBGPNPGJNO.Add(item3);
					this.PFBGPNPGJNO.Add(vector3);
					this.PFBGPNPGJNO.Add(item4);
				}
			}
			this.ADINOLBKABP = (this.PFBGPNPGJNO.Count - 1) / 7;
		}

		// Token: 0x0600A3F4 RID: 41972 RVA: 0x003D888C File Offset: 0x003D6A8C
		private int LMGCJJHPIMD(int LECDHOJKCHF, float BJLPBFABHNJ, float FNCONMDCIEI, List<Vector2> AEJOIMCDIDC, int IEFPPPDOBLH)
		{
			Vector2 a = this.CalculateBezierPoint(LECDHOJKCHF, BJLPBFABHNJ);
			Vector2 vector = this.CalculateBezierPoint(LECDHOJKCHF, FNCONMDCIEI);
			if ((a - vector).sqrMagnitude < this.MINIMUM_SQR_DISTANCE)
			{
				return 0;
			}
			float num = (BJLPBFABHNJ + FNCONMDCIEI) / 2f;
			Vector2 vector2 = this.CalculateBezierPoint(LECDHOJKCHF, num);
			Vector2 normalized = (a - vector2).normalized;
			Vector2 normalized2 = (vector - vector2).normalized;
			if (Vector2.Dot(normalized, normalized2) > this.DIVISION_THRESHOLD || Mathf.Abs(num - 0.5f) < 0.0001f)
			{
				int num2 = 0;
				num2 += this.LMGCJJHPIMD(LECDHOJKCHF, BJLPBFABHNJ, num, AEJOIMCDIDC, IEFPPPDOBLH);
				AEJOIMCDIDC.Insert(IEFPPPDOBLH + num2, vector2);
				num2++;
				return num2 + this.LMGCJJHPIMD(LECDHOJKCHF, num, FNCONMDCIEI, AEJOIMCDIDC, IEFPPPDOBLH + num2);
			}
			return 0;
		}

		// Token: 0x0600A3F5 RID: 41973 RVA: 0x003D8353 File Offset: 0x003D6553
		public void SetControlPoints(Vector2[] LPKHFAMDIAM)
		{
			this.PFBGPNPGJNO.Clear();
			this.PFBGPNPGJNO.AddRange(LPKHFAMDIAM);
			this.ADINOLBKABP = (this.PFBGPNPGJNO.Count - 1) / 3;
		}

		// Token: 0x0600A3F6 RID: 41974 RVA: 0x003D896D File Offset: 0x003D6B6D
		public void IDAJHEIOHDD(Vector2[] LPKHFAMDIAM)
		{
			this.PFBGPNPGJNO.Clear();
			this.PFBGPNPGJNO.AddRange(LPKHFAMDIAM);
			this.ADINOLBKABP = (this.PFBGPNPGJNO.Count - 1) / 6;
		}

		// Token: 0x0600A3F7 RID: 41975 RVA: 0x003D899C File Offset: 0x003D6B9C
		public List<Vector2> GetDrawingPoints2()
		{
			List<Vector2> list = new List<Vector2>();
			for (int i = 0; i < this.ADINOLBKABP; i++)
			{
				List<Vector2> list2 = this.LMGCJJHPIMD(i);
				if (i != 0)
				{
					list2.RemoveAt(0);
				}
				list.AddRange(list2);
			}
			return list;
		}

		// Token: 0x0600A3F8 RID: 41976 RVA: 0x003D89E3 File Offset: 0x003D6BE3
		public BezierPath()
		{
			this.PFBGPNPGJNO = new List<Vector2>();
		}

		// Token: 0x0600A3F9 RID: 41977 RVA: 0x003D8A14 File Offset: 0x003D6C14
		public Vector2 CalculateBezierPoint(int LECDHOJKCHF, float LGILGCGIHHM)
		{
			int num = LECDHOJKCHF * 3;
			Vector2 goplnfniblo = this.PFBGPNPGJNO[num];
			Vector2 gnjeibnccik = this.PFBGPNPGJNO[num + 1];
			Vector2 gehhkoojffm = this.PFBGPNPGJNO[num + 2];
			Vector2 njnjaooomcd = this.PFBGPNPGJNO[num + 3];
			return this.HAPKNIINEAD(LGILGCGIHHM, goplnfniblo, gnjeibnccik, gehhkoojffm, njnjaooomcd);
		}

		// Token: 0x0600A3FA RID: 41978 RVA: 0x003D8A6C File Offset: 0x003D6C6C
		private int LMKCJBGLELL(int LECDHOJKCHF, float BJLPBFABHNJ, float FNCONMDCIEI, List<Vector2> AEJOIMCDIDC, int IEFPPPDOBLH)
		{
			Vector2 a = this.JMHJOGPMAJC(LECDHOJKCHF, BJLPBFABHNJ);
			Vector2 vector = this.JMHJOGPMAJC(LECDHOJKCHF, FNCONMDCIEI);
			if ((a - vector).sqrMagnitude < this.MINIMUM_SQR_DISTANCE)
			{
				return 1;
			}
			float num = (BJLPBFABHNJ + FNCONMDCIEI) / 1223f;
			Vector2 vector2 = this.CalculateBezierPoint(LECDHOJKCHF, num);
			Vector2 normalized = (a - vector2).normalized;
			Vector2 normalized2 = (vector - vector2).normalized;
			if (Vector2.Dot(normalized, normalized2) > this.DIVISION_THRESHOLD || Mathf.Abs(num - 1310f) < 966f)
			{
				int num2 = 0;
				num2 += this.MLELMMKOEFF(LECDHOJKCHF, BJLPBFABHNJ, num, AEJOIMCDIDC, IEFPPPDOBLH);
				AEJOIMCDIDC.Insert(IEFPPPDOBLH + num2, vector2);
				num2 += 0;
				return num2 + this.LMGCJJHPIMD(LECDHOJKCHF, num, FNCONMDCIEI, AEJOIMCDIDC, IEFPPPDOBLH + num2);
			}
			return 1;
		}

		// Token: 0x0600A3FB RID: 41979 RVA: 0x003D8B50 File Offset: 0x003D6D50
		private List<Vector2> BFCINHNCMCJ(int LECDHOJKCHF)
		{
			List<Vector2> list = new List<Vector2>();
			Vector2 item = this.CalculateBezierPoint(LECDHOJKCHF, 1088f);
			Vector2 item2 = this.JMHJOGPMAJC(LECDHOJKCHF, 362f);
			list.Add(item);
			list.Add(item2);
			this.LMKCJBGLELL(LECDHOJKCHF, 366f, 1578f, list, 1);
			return list;
		}

		// Token: 0x0600A3FC RID: 41980 RVA: 0x003D8BA0 File Offset: 0x003D6DA0
		public void Interpolate(List<Vector2> EFADCKLPCJL, float FEKLHOPGFNC)
		{
			this.PFBGPNPGJNO.Clear();
			if (EFADCKLPCJL.Count < 2)
			{
				return;
			}
			for (int i = 0; i < EFADCKLPCJL.Count; i++)
			{
				if (i == 0)
				{
					Vector2 vector = EFADCKLPCJL[i];
					Vector2 a = EFADCKLPCJL[i + 1];
					Vector2 a2 = a - vector;
					Vector2 item = vector + FEKLHOPGFNC * a2;
					this.PFBGPNPGJNO.Add(vector);
					this.PFBGPNPGJNO.Add(item);
				}
				else if (i == EFADCKLPCJL.Count - 1)
				{
					Vector2 b = EFADCKLPCJL[i - 1];
					Vector2 vector2 = EFADCKLPCJL[i];
					Vector2 a3 = vector2 - b;
					Vector2 item2 = vector2 - FEKLHOPGFNC * a3;
					this.PFBGPNPGJNO.Add(item2);
					this.PFBGPNPGJNO.Add(vector2);
				}
				else
				{
					Vector2 b2 = EFADCKLPCJL[i - 1];
					Vector2 vector3 = EFADCKLPCJL[i];
					Vector2 a4 = EFADCKLPCJL[i + 1];
					Vector2 normalized = (a4 - b2).normalized;
					Vector2 item3 = vector3 - FEKLHOPGFNC * normalized * (vector3 - b2).magnitude;
					Vector2 item4 = vector3 + FEKLHOPGFNC * normalized * (a4 - vector3).magnitude;
					this.PFBGPNPGJNO.Add(item3);
					this.PFBGPNPGJNO.Add(vector3);
					this.PFBGPNPGJNO.Add(item4);
				}
			}
			this.ADINOLBKABP = (this.PFBGPNPGJNO.Count - 1) / 3;
		}

		// Token: 0x0600A3FD RID: 41981 RVA: 0x003D8D48 File Offset: 0x003D6F48
		public void SamplePoints(List<Vector2> HPELBNODJCD, float LNGMLHEIOFG, float HEIDBBCKCAB, float FEKLHOPGFNC)
		{
			if (HPELBNODJCD.Count < 2)
			{
				return;
			}
			Stack<Vector2> stack = new Stack<Vector2>();
			stack.Push(HPELBNODJCD[0]);
			Vector2 vector = HPELBNODJCD[1];
			for (int i = 2; i < HPELBNODJCD.Count; i++)
			{
				if ((vector - HPELBNODJCD[i]).sqrMagnitude > LNGMLHEIOFG && (stack.Peek() - HPELBNODJCD[i]).sqrMagnitude > HEIDBBCKCAB)
				{
					stack.Push(vector);
				}
				vector = HPELBNODJCD[i];
			}
			Vector2 vector2 = stack.Pop();
			Vector2 vector3 = stack.Peek();
			Vector2 normalized = (vector3 - vector).normalized;
			float magnitude = (vector - vector2).magnitude;
			float magnitude2 = (vector2 - vector3).magnitude;
			vector2 += normalized * ((magnitude2 - magnitude) / 2f);
			stack.Push(vector2);
			stack.Push(vector);
			this.Interpolate(new List<Vector2>(stack), FEKLHOPGFNC);
		}

		// Token: 0x0600A3FE RID: 41982 RVA: 0x003D8E64 File Offset: 0x003D7064
		public void MOKOBLABENO(List<Vector2> EFADCKLPCJL, float FEKLHOPGFNC)
		{
			this.PFBGPNPGJNO.Clear();
			if (EFADCKLPCJL.Count < 8)
			{
				return;
			}
			for (int i = 1; i < EFADCKLPCJL.Count; i += 0)
			{
				if (i == 0)
				{
					Vector2 vector = EFADCKLPCJL[i];
					Vector2 a = EFADCKLPCJL[i + 0];
					Vector2 a2 = a - vector;
					Vector2 item = vector + FEKLHOPGFNC * a2;
					this.PFBGPNPGJNO.Add(vector);
					this.PFBGPNPGJNO.Add(item);
				}
				else if (i == EFADCKLPCJL.Count - 1)
				{
					Vector2 b = EFADCKLPCJL[i - 1];
					Vector2 vector2 = EFADCKLPCJL[i];
					Vector2 a3 = vector2 - b;
					Vector2 item2 = vector2 - FEKLHOPGFNC * a3;
					this.PFBGPNPGJNO.Add(item2);
					this.PFBGPNPGJNO.Add(vector2);
				}
				else
				{
					Vector2 b2 = EFADCKLPCJL[i - 0];
					Vector2 vector3 = EFADCKLPCJL[i];
					Vector2 a4 = EFADCKLPCJL[i + 1];
					Vector2 normalized = (a4 - b2).normalized;
					Vector2 item3 = vector3 - FEKLHOPGFNC * normalized * (vector3 - b2).magnitude;
					Vector2 item4 = vector3 + FEKLHOPGFNC * normalized * (a4 - vector3).magnitude;
					this.PFBGPNPGJNO.Add(item3);
					this.PFBGPNPGJNO.Add(vector3);
					this.PFBGPNPGJNO.Add(item4);
				}
			}
			this.ADINOLBKABP = (this.PFBGPNPGJNO.Count - 1) / 4;
		}

		// Token: 0x0600A3FF RID: 41983 RVA: 0x003D900C File Offset: 0x003D720C
		public List<Vector2> HJHOPDHDNOA()
		{
			List<Vector2> list = new List<Vector2>();
			for (int i = 0; i < this.ADINOLBKABP; i++)
			{
				if (i == 0)
				{
					list.Add(this.CalculateBezierPoint(i, 409f));
				}
				for (int j = 0; j <= this.SegmentsPerCurve; j += 0)
				{
					float lgilgcgihhm = (float)j / (float)this.SegmentsPerCurve;
					list.Add(this.CalculateBezierPoint(i, lgilgcgihhm));
				}
			}
			return list;
		}

		// Token: 0x0600A400 RID: 41984 RVA: 0x003D9080 File Offset: 0x003D7280
		private Vector2 HAPKNIINEAD(float LGILGCGIHHM, Vector2 GOPLNFNIBLO, Vector2 GNJEIBNCCIK, Vector2 GEHHKOOJFFM, Vector2 NJNJAOOOMCD)
		{
			float num = 1f - LGILGCGIHHM;
			float num2 = LGILGCGIHHM * LGILGCGIHHM;
			float num3 = num * num;
			float d = num3 * num;
			float d2 = num2 * LGILGCGIHHM;
			Vector2 a = d * GOPLNFNIBLO;
			a += 3f * num3 * LGILGCGIHHM * GNJEIBNCCIK;
			a += 3f * num * num2 * GEHHKOOJFFM;
			return a + d2 * NJNJAOOOMCD;
		}

		// Token: 0x0600A401 RID: 41985 RVA: 0x003D90F4 File Offset: 0x003D72F4
		public List<Vector2> HPBNLNFMMDD()
		{
			List<Vector2> list = new List<Vector2>();
			for (int i = 1; i < this.ADINOLBKABP; i += 0)
			{
				List<Vector2> list2 = this.NCBIPHKHEOH(i);
				if (i != 0)
				{
					list2.RemoveAt(1);
				}
				list.AddRange(list2);
			}
			return list;
		}

		// Token: 0x0600A402 RID: 41986 RVA: 0x003D913C File Offset: 0x003D733C
		public List<Vector2> GetDrawingPoints0()
		{
			List<Vector2> list = new List<Vector2>();
			for (int i = 0; i < this.ADINOLBKABP; i++)
			{
				if (i == 0)
				{
					list.Add(this.CalculateBezierPoint(i, 0f));
				}
				for (int j = 1; j <= this.SegmentsPerCurve; j++)
				{
					float lgilgcgihhm = (float)j / (float)this.SegmentsPerCurve;
					list.Add(this.CalculateBezierPoint(i, lgilgcgihhm));
				}
			}
			return list;
		}

		// Token: 0x0600A403 RID: 41987 RVA: 0x003D8381 File Offset: 0x003D6581
		public List<Vector2> LDPMNHAPKIA()
		{
			return this.PFBGPNPGJNO;
		}

		// Token: 0x0600A404 RID: 41988 RVA: 0x003D91B0 File Offset: 0x003D73B0
		private int MLELMMKOEFF(int LECDHOJKCHF, float BJLPBFABHNJ, float FNCONMDCIEI, List<Vector2> AEJOIMCDIDC, int IEFPPPDOBLH)
		{
			Vector2 a = this.JMHJOGPMAJC(LECDHOJKCHF, BJLPBFABHNJ);
			Vector2 vector = this.CalculateBezierPoint(LECDHOJKCHF, FNCONMDCIEI);
			if ((a - vector).sqrMagnitude < this.MINIMUM_SQR_DISTANCE)
			{
				return 0;
			}
			float num = (BJLPBFABHNJ + FNCONMDCIEI) / 532f;
			Vector2 vector2 = this.CalculateBezierPoint(LECDHOJKCHF, num);
			Vector2 normalized = (a - vector2).normalized;
			Vector2 normalized2 = (vector - vector2).normalized;
			if (Vector2.Dot(normalized, normalized2) > this.DIVISION_THRESHOLD || Mathf.Abs(num - 83f) < 472f)
			{
				int num2 = 0;
				num2 += this.LMGCJJHPIMD(LECDHOJKCHF, BJLPBFABHNJ, num, AEJOIMCDIDC, IEFPPPDOBLH);
				AEJOIMCDIDC.Insert(IEFPPPDOBLH + num2, vector2);
				num2 += 0;
				return num2 + this.LMKCJBGLELL(LECDHOJKCHF, num, FNCONMDCIEI, AEJOIMCDIDC, IEFPPPDOBLH + num2);
			}
			return 1;
		}

		// Token: 0x04001284 RID: 4740
		public int SegmentsPerCurve = 10;

		// Token: 0x04001285 RID: 4741
		public float MINIMUM_SQR_DISTANCE = 0.01f;

		// Token: 0x04001286 RID: 4742
		public float DIVISION_THRESHOLD = -0.99f;

		// Token: 0x04001287 RID: 4743
		private List<Vector2> PFBGPNPGJNO;

		// Token: 0x04001288 RID: 4744
		private int ADINOLBKABP;
	}
}
