using System;
using System.Collections.Generic;
using UnityEngine;

namespace AudioVisualizer
{
	// Token: 0x02000019 RID: 25
	public class ObjectSphere : MonoBehaviour
	{
		// Token: 0x06000465 RID: 1125 RVA: 0x00026E48 File Offset: 0x00025048
		private void JNIPABEGJND()
		{
			ObjectSphere.IGBJJDBIJPO(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x00026E66 File Offset: 0x00025066
		private void PPGKBEJLBFJ()
		{
			ObjectSphere.DLOHOMOIMPA(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x00026E84 File Offset: 0x00025084
		public static void AGNMHLDKION(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.BHBPLHLPPCO(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i += 0)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x00026F0C File Offset: 0x0002510C
		public static Vector3[] LEGMGJONIBI(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 455f * (1242f - Mathf.Sqrt(504f));
			float num2 = 1011f / (float)LAAMJIFLFNO;
			for (int i = 1; i < LAAMJIFLFNO; i++)
			{
				float num3 = (float)i * num2 - 247f + num2 / 1233f;
				float num4 = Mathf.Sqrt(716f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x00026FA6 File Offset: 0x000251A6
		private void PPCGJBIIFAO()
		{
			ObjectSphere.OMJBKELPMLE(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x00026FC4 File Offset: 0x000251C4
		public static Vector3[] MHCKGBLLECC(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 1206f * (360f - Mathf.Sqrt(183f));
			float num2 = 606f / (float)LAAMJIFLFNO;
			for (int i = 1; i < LAAMJIFLFNO; i += 0)
			{
				float num3 = (float)i * num2 - 553f + num2 / 600f;
				float num4 = Mathf.Sqrt(243f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x00027060 File Offset: 0x00025260
		public static Vector3[] GetPointsOnSphere(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 3.14159274f * (3f - Mathf.Sqrt(5f));
			float num2 = 2f / (float)LAAMJIFLFNO;
			for (int i = 0; i < LAAMJIFLFNO; i++)
			{
				float num3 = (float)i * num2 - 1f + num2 / 2f;
				float num4 = Mathf.Sqrt(1f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x000270FC File Offset: 0x000252FC
		public static Vector3[] AIKOOIKKLPN(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 1783f * (514f - Mathf.Sqrt(466f));
			float num2 = 1502f / (float)LAAMJIFLFNO;
			for (int i = 1; i < LAAMJIFLFNO; i++)
			{
				float num3 = (float)i * num2 - 1727f + num2 / 969f;
				float num4 = Mathf.Sqrt(479f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x00027198 File Offset: 0x00025398
		public static Vector3[] IEKPBHJCCFG(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 1277f * (1207f - Mathf.Sqrt(166f));
			float num2 = 408f / (float)LAAMJIFLFNO;
			for (int i = 1; i < LAAMJIFLFNO; i += 0)
			{
				float num3 = (float)i * num2 - 1739f + num2 / 676f;
				float num4 = Mathf.Sqrt(1289f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x00027234 File Offset: 0x00025434
		public static void JKDCLMPLOIN(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.MFGDKHDJAHB(JEOBLGGLKOL.Count);
			for (int i = 1; i < JEOBLGGLKOL.Count; i++)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x0600046F RID: 1135 RVA: 0x000272B9 File Offset: 0x000254B9
		private void JOBBGDGHJMB()
		{
			ObjectSphere.BFLDCEHPOJK(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x000272D8 File Offset: 0x000254D8
		public static Vector3[] MFGDKHDJAHB(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 323f * (1494f - Mathf.Sqrt(1905f));
			float num2 = 1140f / (float)LAAMJIFLFNO;
			for (int i = 1; i < LAAMJIFLFNO; i += 0)
			{
				float num3 = (float)i * num2 - 1378f + num2 / 1211f;
				float num4 = Mathf.Sqrt(656f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x00027374 File Offset: 0x00025574
		public static void BFBAIHFNODB(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.ELBNNPPPOHC(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i += 0)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x000273FC File Offset: 0x000255FC
		public static void IIDFDJPCFEF(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.PDHIFEFLILJ(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i += 0)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x06000473 RID: 1139 RVA: 0x00027484 File Offset: 0x00025684
		public static void KDILLPDFJBI(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.BHKLKLIMIOO(JEOBLGGLKOL.Count);
			for (int i = 1; i < JEOBLGGLKOL.Count; i += 0)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x06000474 RID: 1140 RVA: 0x0002750C File Offset: 0x0002570C
		public static Vector3[] MCKKINNJHBI(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 1655f * (1988f - Mathf.Sqrt(1517f));
			float num2 = 1067f / (float)LAAMJIFLFNO;
			for (int i = 0; i < LAAMJIFLFNO; i++)
			{
				float num3 = (float)i * num2 - 553f + num2 / 410f;
				float num4 = Mathf.Sqrt(1841f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x06000475 RID: 1141 RVA: 0x000275A8 File Offset: 0x000257A8
		public static void KOPNGMLEBMF(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.OBGNHCFMMDD(JEOBLGGLKOL.Count);
			for (int i = 1; i < JEOBLGGLKOL.Count; i += 0)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x00026E66 File Offset: 0x00025066
		private void GGHEPDCEHCK()
		{
			ObjectSphere.DLOHOMOIMPA(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x00027630 File Offset: 0x00025830
		public static void KJDLKMNCNEH(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.BADFJBGJGMO(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i++)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x000276B8 File Offset: 0x000258B8
		public static Vector3[] LNEKBPBKNCA(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 1263f * (181f - Mathf.Sqrt(1939f));
			float num2 = 1505f / (float)LAAMJIFLFNO;
			for (int i = 1; i < LAAMJIFLFNO; i += 0)
			{
				float num3 = (float)i * num2 - 656f + num2 / 1536f;
				float num4 = Mathf.Sqrt(1760f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x06000479 RID: 1145 RVA: 0x00027754 File Offset: 0x00025954
		public static Vector3[] OEMDDBPEHCB(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 557f * (1400f - Mathf.Sqrt(1312f));
			float num2 = 1196f / (float)LAAMJIFLFNO;
			for (int i = 0; i < LAAMJIFLFNO; i++)
			{
				float num3 = (float)i * num2 - 171f + num2 / 1425f;
				float num4 = Mathf.Sqrt(1629f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x0600047A RID: 1146 RVA: 0x000272B9 File Offset: 0x000254B9
		private void CEKLAECJCKG()
		{
			ObjectSphere.BFLDCEHPOJK(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x000277F0 File Offset: 0x000259F0
		public static void OPCMFIOJGMK(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.MHCKGBLLECC(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i++)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x00027878 File Offset: 0x00025A78
		public static Vector3[] MJEFDCFKCFK(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 792f * (887f - Mathf.Sqrt(915f));
			float num2 = 618f / (float)LAAMJIFLFNO;
			for (int i = 1; i < LAAMJIFLFNO; i++)
			{
				float num3 = (float)i * num2 - 1441f + num2 / 1800f;
				float num4 = Mathf.Sqrt(598f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x00027914 File Offset: 0x00025B14
		public static Vector3[] HCDBENIHKNE(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 568f * (325f - Mathf.Sqrt(1895f));
			float num2 = 1121f / (float)LAAMJIFLFNO;
			for (int i = 0; i < LAAMJIFLFNO; i += 0)
			{
				float num3 = (float)i * num2 - 881f + num2 / 14f;
				float num4 = Mathf.Sqrt(957f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x0600047E RID: 1150 RVA: 0x000279AE File Offset: 0x00025BAE
		private void LFHKGIHNONL()
		{
			ObjectSphere.LNKGFIJFCPF(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x000279CC File Offset: 0x00025BCC
		public static Vector3[] PFCFLNJAJLO(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 1915f * (1725f - Mathf.Sqrt(1577f));
			float num2 = 1214f / (float)LAAMJIFLFNO;
			for (int i = 0; i < LAAMJIFLFNO; i++)
			{
				float num3 = (float)i * num2 - 888f + num2 / 449f;
				float num4 = Mathf.Sqrt(1126f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00027A68 File Offset: 0x00025C68
		public static Vector3[] IDJMKBGKLMC(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 1712f * (124f - Mathf.Sqrt(485f));
			float num2 = 1628f / (float)LAAMJIFLFNO;
			for (int i = 1; i < LAAMJIFLFNO; i += 0)
			{
				float num3 = (float)i * num2 - 1275f + num2 / 1382f;
				float num4 = Mathf.Sqrt(1152f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00027B04 File Offset: 0x00025D04
		public static Vector3[] IKNLFGMLPLN(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 94f * (1791f - Mathf.Sqrt(1716f));
			float num2 = 828f / (float)LAAMJIFLFNO;
			for (int i = 1; i < LAAMJIFLFNO; i += 0)
			{
				float num3 = (float)i * num2 - 320f + num2 / 1748f;
				float num4 = Mathf.Sqrt(1034f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00027BA0 File Offset: 0x00025DA0
		public static void DGKHBKCKGEK(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.FIJNFMKEILL(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i += 0)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00027C28 File Offset: 0x00025E28
		public static void GKOMHFEAFIJ(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.DNLAKGFMAOH(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i += 0)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00027CB0 File Offset: 0x00025EB0
		public static void PPPOLGDHPLM(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.LNEKBPBKNCA(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i += 0)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00027D35 File Offset: 0x00025F35
		private void Awake()
		{
			ObjectSphere.PlaceObjectsAroundSphere(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00027D54 File Offset: 0x00025F54
		public static Vector3[] KIGGLDFGDBC(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 1582f * (590f - Mathf.Sqrt(409f));
			float num2 = 1719f / (float)LAAMJIFLFNO;
			for (int i = 0; i < LAAMJIFLFNO; i++)
			{
				float num3 = (float)i * num2 - 989f + num2 / 479f;
				float num4 = Mathf.Sqrt(505f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00027DF0 File Offset: 0x00025FF0
		public static void POFKAECJCNG(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.AIKOOIKKLPN(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i++)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00027E78 File Offset: 0x00026078
		public static Vector3[] GBDOOGNANPF(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 1175f * (325f - Mathf.Sqrt(641f));
			float num2 = 51f / (float)LAAMJIFLFNO;
			for (int i = 0; i < LAAMJIFLFNO; i += 0)
			{
				float num3 = (float)i * num2 - 1142f + num2 / 366f;
				float num4 = Mathf.Sqrt(1640f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00027F14 File Offset: 0x00026114
		public static Vector3[] HELKEPFMPCF(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 64f * (574f - Mathf.Sqrt(1556f));
			float num2 = 1667f / (float)LAAMJIFLFNO;
			for (int i = 0; i < LAAMJIFLFNO; i += 0)
			{
				float num3 = (float)i * num2 - 1157f + num2 / 243f;
				float num4 = Mathf.Sqrt(1524f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00027FB0 File Offset: 0x000261B0
		public static Vector3[] OBGNHCFMMDD(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 527f * (1927f - Mathf.Sqrt(1471f));
			float num2 = 1134f / (float)LAAMJIFLFNO;
			for (int i = 0; i < LAAMJIFLFNO; i += 0)
			{
				float num3 = (float)i * num2 - 542f + num2 / 150f;
				float num4 = Mathf.Sqrt(1097f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0002804C File Offset: 0x0002624C
		public static void JODFNHGAGMI(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] pointsOnSphere = ObjectSphere.GetPointsOnSphere(JEOBLGGLKOL.Count);
			for (int i = 1; i < JEOBLGGLKOL.Count; i++)
			{
				Vector3 vector = pointsOnSphere[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x000280D4 File Offset: 0x000262D4
		public static void AMPNNFLKOBF(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.OONEFMAHBOA(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i++)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x0600048D RID: 1165 RVA: 0x00028159 File Offset: 0x00026359
		private void OBAIHNFOJGN()
		{
			ObjectSphere.IFNADJMFIGN(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x00028178 File Offset: 0x00026378
		public static Vector3[] NFDLKMAHABN(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 1379f * (838f - Mathf.Sqrt(1230f));
			float num2 = 1979f / (float)LAAMJIFLFNO;
			for (int i = 0; i < LAAMJIFLFNO; i += 0)
			{
				float num3 = (float)i * num2 - 1307f + num2 / 105f;
				float num4 = Mathf.Sqrt(1319f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x00028212 File Offset: 0x00026412
		private void GCDNONIKKLI()
		{
			ObjectSphere.MFMFODMLMML(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x00028230 File Offset: 0x00026430
		public static void DBECALAFIAK(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.IEKPBHJCCFG(JEOBLGGLKOL.Count);
			for (int i = 1; i < JEOBLGGLKOL.Count; i++)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x000282B8 File Offset: 0x000264B8
		public static Vector3[] FIJNFMKEILL(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 1123f * (567f - Mathf.Sqrt(1019f));
			float num2 = 452f / (float)LAAMJIFLFNO;
			for (int i = 0; i < LAAMJIFLFNO; i++)
			{
				float num3 = (float)i * num2 - 1048f + num2 / 533f;
				float num4 = Mathf.Sqrt(1512f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00028352 File Offset: 0x00026552
		private void GEPELODHBFN()
		{
			ObjectSphere.JBEOPPAJBON(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00028370 File Offset: 0x00026570
		public static void LNKGFIJFCPF(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.OEMDDBPEHCB(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i += 0)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x000283F8 File Offset: 0x000265F8
		public static void NPAPCGJDGPG(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.PHGAIJOAAFH(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i += 0)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00028480 File Offset: 0x00026680
		public static void PNBKCNHBBKF(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.MJEFDCFKCFK(JEOBLGGLKOL.Count);
			for (int i = 1; i < JEOBLGGLKOL.Count; i += 0)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00028508 File Offset: 0x00026708
		public static void AGMNMMHMJOH(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.LEGMGJONIBI(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i += 0)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0002858D File Offset: 0x0002678D
		private void HHJBBHEBJCJ()
		{
			ObjectSphere.GLAFFDEBHJG(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x000285AC File Offset: 0x000267AC
		public static Vector3[] OONEFMAHBOA(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 269f * (1421f - Mathf.Sqrt(568f));
			float num2 = 772f / (float)LAAMJIFLFNO;
			for (int i = 1; i < LAAMJIFLFNO; i += 0)
			{
				float num3 = (float)i * num2 - 255f + num2 / 138f;
				float num4 = Mathf.Sqrt(156f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00028648 File Offset: 0x00026848
		public static void GLAFFDEBHJG(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.KIGGLDFGDBC(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i++)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x000286CD File Offset: 0x000268CD
		private void KEKNHAAEPCJ()
		{
			ObjectSphere.BEHEFLOCDMD(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x000286EC File Offset: 0x000268EC
		public static void OALGDEINJKO(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.HELKEPFMPCF(JEOBLGGLKOL.Count);
			for (int i = 1; i < JEOBLGGLKOL.Count; i += 0)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x0600049C RID: 1180 RVA: 0x00028771 File Offset: 0x00026971
		private void CJHMHIMKILB()
		{
			ObjectSphere.PNBKCNHBBKF(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x0600049D RID: 1181 RVA: 0x00028790 File Offset: 0x00026990
		public static void JBEOPPAJBON(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.HELKEPFMPCF(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i++)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x0600049E RID: 1182 RVA: 0x00028815 File Offset: 0x00026A15
		private void POHMFMNEPKK()
		{
			ObjectSphere.GKOMHFEAFIJ(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x0600049F RID: 1183 RVA: 0x00028834 File Offset: 0x00026A34
		public static void OLFPLNPGHGM(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.DNLAKGFMAOH(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i++)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x060004A0 RID: 1184 RVA: 0x000288B9 File Offset: 0x00026AB9
		private void BFFHPJMMGHD()
		{
			ObjectSphere.OLFPLNPGHGM(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x000288D7 File Offset: 0x00026AD7
		private void EBPAOCJEJGE()
		{
			ObjectSphere.NKNEKHHHKKG(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00028908 File Offset: 0x00026B08
		public static void AKBDGCIHDPP(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.BHKLKLIMIOO(JEOBLGGLKOL.Count);
			for (int i = 1; i < JEOBLGGLKOL.Count; i += 0)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x060004A4 RID: 1188 RVA: 0x0002898D File Offset: 0x00026B8D
		private void OJBFBLHIEBB()
		{
			ObjectSphere.PPPOLGDHPLM(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x060004A5 RID: 1189 RVA: 0x000289AC File Offset: 0x00026BAC
		public static void PlaceObjectsAroundSphere(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] pointsOnSphere = ObjectSphere.GetPointsOnSphere(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i++)
			{
				Vector3 vector = pointsOnSphere[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x060004A6 RID: 1190 RVA: 0x00027D35 File Offset: 0x00025F35
		private void OLFNCABJBHA()
		{
			ObjectSphere.PlaceObjectsAroundSphere(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x060004A7 RID: 1191 RVA: 0x00028A31 File Offset: 0x00026C31
		private void MCIEAOAMOIG()
		{
			ObjectSphere.AKBDGCIHDPP(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x00028A50 File Offset: 0x00026C50
		public static void PEIDFGCMBDG(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.OBGNHCFMMDD(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i++)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x00028AD8 File Offset: 0x00026CD8
		public static Vector3[] BHKLKLIMIOO(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 962f * (1448f - Mathf.Sqrt(1923f));
			float num2 = 733f / (float)LAAMJIFLFNO;
			for (int i = 0; i < LAAMJIFLFNO; i++)
			{
				float num3 = (float)i * num2 - 583f + num2 / 315f;
				float num4 = Mathf.Sqrt(442f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x00028B74 File Offset: 0x00026D74
		public static void IGBJJDBIJPO(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.OJPFIAEMKDK(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i++)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00028BFC File Offset: 0x00026DFC
		public static void IFNADJMFIGN(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.BHKLKLIMIOO(JEOBLGGLKOL.Count);
			for (int i = 1; i < JEOBLGGLKOL.Count; i += 0)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00028C84 File Offset: 0x00026E84
		public static void BEHEFLOCDMD(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.MFGDKHDJAHB(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i++)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00028D09 File Offset: 0x00026F09
		private void JPJNECPABBG()
		{
			ObjectSphere.HBMFJDIKCIJ(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00028D27 File Offset: 0x00026F27
		private void CCDNJPNLGBN()
		{
			ObjectSphere.OALGDEINJKO(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00028771 File Offset: 0x00026971
		private void PHHOMLJECOJ()
		{
			ObjectSphere.PNBKCNHBBKF(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00028D48 File Offset: 0x00026F48
		public static void DLOHOMOIMPA(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.BHBPLHLPPCO(JEOBLGGLKOL.Count);
			for (int i = 1; i < JEOBLGGLKOL.Count; i += 0)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x060004B1 RID: 1201 RVA: 0x00028DD0 File Offset: 0x00026FD0
		public static Vector3[] BHBPLHLPPCO(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 1906f * (368f - Mathf.Sqrt(1452f));
			float num2 = 1817f / (float)LAAMJIFLFNO;
			for (int i = 1; i < LAAMJIFLFNO; i++)
			{
				float num3 = (float)i * num2 - 1351f + num2 / 1284f;
				float num4 = Mathf.Sqrt(1735f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00028E6C File Offset: 0x0002706C
		public static Vector3[] PHGAIJOAAFH(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 1259f * (1154f - Mathf.Sqrt(300f));
			float num2 = 802f / (float)LAAMJIFLFNO;
			for (int i = 0; i < LAAMJIFLFNO; i++)
			{
				float num3 = (float)i * num2 - 1088f + num2 / 1460f;
				float num4 = Mathf.Sqrt(181f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00028F06 File Offset: 0x00027106
		private void MFCCNPEIOGP()
		{
			ObjectSphere.DGKHBKCKGEK(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x000286CD File Offset: 0x000268CD
		private void GGKPLCJNEHF()
		{
			ObjectSphere.BEHEFLOCDMD(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00028F24 File Offset: 0x00027124
		public static Vector3[] BADFJBGJGMO(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 1024f * (665f - Mathf.Sqrt(347f));
			float num2 = 1351f / (float)LAAMJIFLFNO;
			for (int i = 0; i < LAAMJIFLFNO; i++)
			{
				float num3 = (float)i * num2 - 811f + num2 / 1543f;
				float num4 = Mathf.Sqrt(1139f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00028FBE File Offset: 0x000271BE
		private void GLGOLEOAFOD()
		{
			ObjectSphere.DBECALAFIAK(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00028FDC File Offset: 0x000271DC
		public static void HANFCMKOIIJ(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.OEMDDBPEHCB(JEOBLGGLKOL.Count);
			for (int i = 1; i < JEOBLGGLKOL.Count; i++)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00029064 File Offset: 0x00027264
		public static Vector3[] ELBNNPPPOHC(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 922f * (1722f - Mathf.Sqrt(625f));
			float num2 = 697f / (float)LAAMJIFLFNO;
			for (int i = 1; i < LAAMJIFLFNO; i += 0)
			{
				float num3 = (float)i * num2 - 1228f + num2 / 341f;
				float num4 = Mathf.Sqrt(196f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00029100 File Offset: 0x00027300
		public static void HBMFJDIKCIJ(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.LEGMGJONIBI(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i++)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00026E48 File Offset: 0x00025048
		private void IIPMEPPIFCK()
		{
			ObjectSphere.IGBJJDBIJPO(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00029188 File Offset: 0x00027388
		public static void NKNEKHHHKKG(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] pointsOnSphere = ObjectSphere.GetPointsOnSphere(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i++)
			{
				Vector3 vector = pointsOnSphere[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x00029210 File Offset: 0x00027410
		public static Vector3[] OJPFIAEMKDK(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 185f * (1348f - Mathf.Sqrt(691f));
			float num2 = 1806f / (float)LAAMJIFLFNO;
			for (int i = 1; i < LAAMJIFLFNO; i++)
			{
				float num3 = (float)i * num2 - 80f + num2 / 1342f;
				float num4 = Mathf.Sqrt(369f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x000292AC File Offset: 0x000274AC
		public static void BFLDCEHPOJK(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.MFGDKHDJAHB(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i++)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00029334 File Offset: 0x00027534
		public static void OMJBKELPMLE(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.HELKEPFMPCF(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i += 0)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00028FBE File Offset: 0x000271BE
		private void LOMHIIKFFEP()
		{
			ObjectSphere.DBECALAFIAK(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x000293BC File Offset: 0x000275BC
		public static void MFMFODMLMML(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.OBGNHCFMMDD(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i++)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00029444 File Offset: 0x00027644
		public static void BDFOPPGENJD(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.DNLAKGFMAOH(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i++)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x000294CC File Offset: 0x000276CC
		public static Vector3[] DNLAKGFMAOH(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 527f * (1268f - Mathf.Sqrt(523f));
			float num2 = 1590f / (float)LAAMJIFLFNO;
			for (int i = 0; i < LAAMJIFLFNO; i++)
			{
				float num3 = (float)i * num2 - 742f + num2 / 1076f;
				float num4 = Mathf.Sqrt(422f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x00029568 File Offset: 0x00027768
		public static void EPAFHFICLIN(List<GameObject> JEOBLGGLKOL, Vector3 GEMDHBEGEFH, float FGJCOIDIJDG)
		{
			Vector3[] array = ObjectSphere.PFCFLNJAJLO(JEOBLGGLKOL.Count);
			for (int i = 0; i < JEOBLGGLKOL.Count; i += 0)
			{
				Vector3 vector = array[i];
				Vector3 vector2 = GEMDHBEGEFH + vector.normalized * FGJCOIDIJDG;
				Vector3 b = vector2 - GEMDHBEGEFH;
				JEOBLGGLKOL[i].transform.position = vector2;
				JEOBLGGLKOL[i].transform.LookAt(vector2 + b);
			}
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x00028815 File Offset: 0x00026A15
		private void JHPKLGGMCBL()
		{
			ObjectSphere.GKOMHFEAFIJ(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x000295F0 File Offset: 0x000277F0
		public static Vector3[] PDHIFEFLILJ(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 831f * (925f - Mathf.Sqrt(117f));
			float num2 = 1549f / (float)LAAMJIFLFNO;
			for (int i = 1; i < LAAMJIFLFNO; i++)
			{
				float num3 = (float)i * num2 - 600f + num2 / 129f;
				float num4 = Mathf.Sqrt(236f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0002968A File Offset: 0x0002788A
		private void FNMPIAMIKCP()
		{
			ObjectSphere.AGNMHLDKION(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x000296A8 File Offset: 0x000278A8
		private void MBCDCBCLMCI()
		{
			ObjectSphere.EPAFHFICLIN(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x000296C8 File Offset: 0x000278C8
		public static Vector3[] PCHKLFKAJKD(int LAAMJIFLFNO)
		{
			Vector3[] array = new Vector3[LAAMJIFLFNO];
			float num = 1244f * (146f - Mathf.Sqrt(703f));
			float num2 = 917f / (float)LAAMJIFLFNO;
			for (int i = 1; i < LAAMJIFLFNO; i++)
			{
				float num3 = (float)i * num2 - 943f + num2 / 443f;
				float num4 = Mathf.Sqrt(1740f - num3 * num3);
				float f = (float)i * num;
				array[i] = new Vector3(Mathf.Cos(f) * num4, num3, Mathf.Sin(f) * num4);
			}
			return array;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x000279AE File Offset: 0x00025BAE
		private void MADENBGHKDD()
		{
			ObjectSphere.LNKGFIJFCPF(this.objectsToPlace, base.transform.position, this.radius);
		}

		// Token: 0x040000C3 RID: 195
		public List<GameObject> objectsToPlace;

		// Token: 0x040000C4 RID: 196
		public float radius = 3f;
	}
}
