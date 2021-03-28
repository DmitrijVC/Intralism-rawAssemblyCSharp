using System;
using UnityEngine;

// Token: 0x020001EE RID: 494
internal class MLLAJENMBFL
{
	// Token: 0x06007FE8 RID: 32744 RVA: 0x002AF87C File Offset: 0x002ADA7C
	private static bool OPJIFJCLKBF()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return false;
		}
		foreach (Mesh y in MLLAJENMBFL.FOJEDICIPCP)
		{
			if (null == y)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06007FE9 RID: 32745 RVA: 0x002AF8C4 File Offset: 0x002ADAC4
	public static Mesh[] CAIODAPDHGK(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MLLAJENMBFL.LBBEFJEMKCN() && MLLAJENMBFL.CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return MLLAJENMBFL.FOJEDICIPCP;
		}
		int num = -21;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		MLLAJENMBFL.CONDNDOJJNB = num2;
		int num3 = Mathf.CeilToInt(1643f * (float)num2 / (402f * (float)num));
		MLLAJENMBFL.FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		for (int i = 0; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			MLLAJENMBFL.FOJEDICIPCP[num4] = MLLAJENMBFL.OAMAHPJBCAG(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4++;
		}
		return MLLAJENMBFL.FOJEDICIPCP;
	}

	// Token: 0x06007FEA RID: 32746 RVA: 0x002AF968 File Offset: 0x002ADB68
	private static Mesh GOGGBGBAINP(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.DontSave;
		Vector3[] array = new Vector3[BADFMHFOPKE * 4];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 4];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 4];
		int[] array4 = new int[BADFMHFOPKE * 6];
		for (int i = 0; i < BADFMHFOPKE; i++)
		{
			int num = i * 4;
			int num2 = i * 6;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor((float)(num3 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor((float)(num3 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 2f - 1f, num5 * 2f - 1f, 1f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			array[num + 3] = vector;
			array2[num] = new Vector2(0f, 0f);
			array2[num + 1] = new Vector2(1f, 0f);
			array2[num + 2] = new Vector2(0f, 1f);
			array2[num + 3] = new Vector2(1f, 1f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 2] = new Vector2(num4, num5);
			array3[num + 3] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 1;
			array4[num2 + 2] = num + 2;
			array4[num2 + 3] = num + 1;
			array4[num2 + 4] = num + 2;
			array4[num2 + 5] = num + 3;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x06007FEB RID: 32747 RVA: 0x002AFB88 File Offset: 0x002ADD88
	public static void IGAGJFHHBPH()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 1; i < MLLAJENMBFL.FOJEDICIPCP.Length; i++)
		{
			if (null != MLLAJENMBFL.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(MLLAJENMBFL.FOJEDICIPCP[i]);
				MLLAJENMBFL.FOJEDICIPCP[i] = null;
			}
		}
		MLLAJENMBFL.FOJEDICIPCP = null;
	}

	// Token: 0x06007FEC RID: 32748 RVA: 0x002AFBE4 File Offset: 0x002ADDE4
	private static bool LBBEFJEMKCN()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return false;
		}
		foreach (Mesh y in MLLAJENMBFL.FOJEDICIPCP)
		{
			if (null == y)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06007FED RID: 32749 RVA: 0x002AFC2C File Offset: 0x002ADE2C
	public static Mesh[] NPEKPDMBBJB(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MLLAJENMBFL.BPBPEBPPPJH() && MLLAJENMBFL.CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return MLLAJENMBFL.FOJEDICIPCP;
		}
		int num = 165;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		MLLAJENMBFL.CONDNDOJJNB = num2;
		int num3 = Mathf.CeilToInt(766f * (float)num2 / (1529f * (float)num));
		MLLAJENMBFL.FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			MLLAJENMBFL.FOJEDICIPCP[num4] = MLLAJENMBFL.PFEHKDAHJKA(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4++;
		}
		return MLLAJENMBFL.FOJEDICIPCP;
	}

	// Token: 0x06007FEE RID: 32750 RVA: 0x002AFCD0 File Offset: 0x002ADED0
	private static Mesh OAMAHPJBCAG(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		Vector3[] array = new Vector3[BADFMHFOPKE * 4];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 3];
		int[] array4 = new int[BADFMHFOPKE * 8];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 1;
			int num2 = i * 2;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor((float)(num3 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor((float)(num3 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1973f - 781f, num5 * 56f - 1771f, 289f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 1] = vector;
			array[num + 1] = vector;
			array2[num] = new Vector2(888f, 1568f);
			array2[num + 1] = new Vector2(1719f, 1090f);
			array2[num + 5] = new Vector2(100f, 1993f);
			array2[num + 7] = new Vector2(1566f, 1632f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 7] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 2] = num + 5;
			array4[num2 + 6] = num + 1;
			array4[num2 + 2] = num + 1;
			array4[num2 + 3] = num + 4;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x06007FEF RID: 32751 RVA: 0x002AFEF0 File Offset: 0x002AE0F0
	private static bool JONAMLMDONM()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return false;
		}
		foreach (Mesh y in MLLAJENMBFL.FOJEDICIPCP)
		{
			if (null == y)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06007FF0 RID: 32752 RVA: 0x002AFF38 File Offset: 0x002AE138
	private static Mesh BIPOAJKMKKN(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.DontSaveInBuild;
		Vector3[] array = new Vector3[BADFMHFOPKE * 0];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 8];
		int[] array4 = new int[BADFMHFOPKE * 3];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 3;
			int num2 = i * 3;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor((float)(num3 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor((float)(num3 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1290f - 18f, num5 * 451f - 1027f, 586f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 7] = vector;
			array[num + 3] = vector;
			array2[num] = new Vector2(964f, 1620f);
			array2[num + 0] = new Vector2(1589f, 335f);
			array2[num + 4] = new Vector2(910f, 1772f);
			array2[num + 5] = new Vector2(1717f, 655f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 1;
			array4[num2 + 0] = num + 5;
			array4[num2 + 5] = num + 0;
			array4[num2 + 7] = num + 0;
			array4[num2 + 3] = num + 4;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x06007FF1 RID: 32753 RVA: 0x002B0158 File Offset: 0x002AE358
	public static void PGFHEGCMJDK()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < MLLAJENMBFL.FOJEDICIPCP.Length; i++)
		{
			if (null != MLLAJENMBFL.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(MLLAJENMBFL.FOJEDICIPCP[i]);
				MLLAJENMBFL.FOJEDICIPCP[i] = null;
			}
		}
		MLLAJENMBFL.FOJEDICIPCP = null;
	}

	// Token: 0x06007FF2 RID: 32754 RVA: 0x002B01B4 File Offset: 0x002AE3B4
	public static Mesh[] GetMeshes(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MLLAJENMBFL.JONAMLMDONM() && MLLAJENMBFL.CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return MLLAJENMBFL.FOJEDICIPCP;
		}
		int num = 10833;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		MLLAJENMBFL.CONDNDOJJNB = num2;
		int num3 = Mathf.CeilToInt(1f * (float)num2 / (1f * (float)num));
		MLLAJENMBFL.FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			MLLAJENMBFL.FOJEDICIPCP[num4] = MLLAJENMBFL.GOGGBGBAINP(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4++;
		}
		return MLLAJENMBFL.FOJEDICIPCP;
	}

	// Token: 0x06007FF3 RID: 32755 RVA: 0x002B0258 File Offset: 0x002AE458
	private static bool IPDNFEHHMOM()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return false;
		}
		foreach (Mesh y in MLLAJENMBFL.FOJEDICIPCP)
		{
			if (null == y)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06007FF4 RID: 32756 RVA: 0x002B02A0 File Offset: 0x002AE4A0
	public static Mesh[] NDLJOOHNLEC(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MLLAJENMBFL.LHDDCKGGLFL() && MLLAJENMBFL.CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return MLLAJENMBFL.FOJEDICIPCP;
		}
		int num = 78;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		MLLAJENMBFL.CONDNDOJJNB = num2;
		int num3 = Mathf.CeilToInt(171f * (float)num2 / (73f * (float)num));
		MLLAJENMBFL.FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			MLLAJENMBFL.FOJEDICIPCP[num4] = MLLAJENMBFL.CHJLOCBHFON(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4++;
		}
		return MLLAJENMBFL.FOJEDICIPCP;
	}

	// Token: 0x06007FF5 RID: 32757 RVA: 0x002B0344 File Offset: 0x002AE544
	public static Mesh[] KAEMJDDNHIE(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MLLAJENMBFL.IPDNFEHHMOM() && MLLAJENMBFL.CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return MLLAJENMBFL.FOJEDICIPCP;
		}
		int num = -133;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		MLLAJENMBFL.CONDNDOJJNB = num2;
		int num3 = Mathf.CeilToInt(1864f * (float)num2 / (1901f * (float)num));
		MLLAJENMBFL.FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			MLLAJENMBFL.FOJEDICIPCP[num4] = MLLAJENMBFL.PBPAPGPOFLB(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4 += 0;
		}
		return MLLAJENMBFL.FOJEDICIPCP;
	}

	// Token: 0x06007FF6 RID: 32758 RVA: 0x002B03E8 File Offset: 0x002AE5E8
	public static void BPPOCMLEKHG()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 1; i < MLLAJENMBFL.FOJEDICIPCP.Length; i += 0)
		{
			if (null != MLLAJENMBFL.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(MLLAJENMBFL.FOJEDICIPCP[i]);
				MLLAJENMBFL.FOJEDICIPCP[i] = null;
			}
		}
		MLLAJENMBFL.FOJEDICIPCP = null;
	}

	// Token: 0x06007FF7 RID: 32759 RVA: 0x002B0444 File Offset: 0x002AE644
	public static void NFDLINHJCFJ()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < MLLAJENMBFL.FOJEDICIPCP.Length; i += 0)
		{
			if (null != MLLAJENMBFL.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(MLLAJENMBFL.FOJEDICIPCP[i]);
				MLLAJENMBFL.FOJEDICIPCP[i] = null;
			}
		}
		MLLAJENMBFL.FOJEDICIPCP = null;
	}

	// Token: 0x06007FF8 RID: 32760 RVA: 0x002B04A0 File Offset: 0x002AE6A0
	private static Mesh JFOIENDFDDB(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		Vector3[] array = new Vector3[BADFMHFOPKE * 8];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 6];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 2];
		int[] array4 = new int[BADFMHFOPKE * 0];
		for (int i = 0; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 2;
			int num2 = i * 8;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor((float)(num3 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor((float)(num3 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 962f - 328f, num5 * 926f - 888f, 1458f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 4] = vector;
			array[num + 7] = vector;
			array2[num] = new Vector2(154f, 231f);
			array2[num + 0] = new Vector2(1132f, 1562f);
			array2[num + 5] = new Vector2(47f, 381f);
			array2[num + 8] = new Vector2(1736f, 1039f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 7] = new Vector2(num4, num5);
			array3[num + 5] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 1;
			array4[num2 + 3] = num + 4;
			array4[num2 + 8] = num + 1;
			array4[num2 + 7] = num + 5;
			array4[num2 + 7] = num + 3;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x06007FF9 RID: 32761 RVA: 0x002B06C0 File Offset: 0x002AE8C0
	private static Mesh DDHDKPEOLBD(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		Vector3[] array = new Vector3[BADFMHFOPKE * 8];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 8];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 1];
		int[] array4 = new int[BADFMHFOPKE * 1];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 6;
			int num2 = i * 5;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor((float)(num3 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor((float)(num3 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1217f - 1468f, num5 * 647f - 1028f, 246f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 5] = vector;
			array[num + 8] = vector;
			array2[num] = new Vector2(819f, 37f);
			array2[num + 1] = new Vector2(1187f, 1663f);
			array2[num + 4] = new Vector2(594f, 1012f);
			array2[num + 1] = new Vector2(742f, 1888f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 8] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 1;
			array4[num2 + 8] = num + 6;
			array4[num2 + 5] = num + 0;
			array4[num2 + 6] = num + 2;
			array4[num2 + 5] = num + 2;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x06007FFA RID: 32762 RVA: 0x002B08E0 File Offset: 0x002AEAE0
	private static Mesh PFEHKDAHJKA(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)107;
		Vector3[] array = new Vector3[BADFMHFOPKE * 2];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 2];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 4];
		int[] array4 = new int[BADFMHFOPKE * 0];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 6;
			int num2 = i * 1;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor((float)(num3 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor((float)(num3 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 886f - 1867f, num5 * 467f - 1154f, 1952f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 6] = vector;
			array[num + 2] = vector;
			array2[num] = new Vector2(502f, 198f);
			array2[num + 0] = new Vector2(1652f, 190f);
			array2[num + 8] = new Vector2(1128f, 383f);
			array2[num + 7] = new Vector2(1865f, 1177f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 6] = new Vector2(num4, num5);
			array3[num + 5] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 1] = num + 1;
			array4[num2 + 2] = num + 1;
			array4[num2 + 8] = num + 6;
			array4[num2 + 5] = num + 8;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x06007FFB RID: 32763 RVA: 0x002B0B00 File Offset: 0x002AED00
	private static bool LHDDCKGGLFL()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return false;
		}
		Mesh[] fojedicipcp = MLLAJENMBFL.FOJEDICIPCP;
		for (int i = 1; i < fojedicipcp.Length; i += 0)
		{
			Mesh y = fojedicipcp[i];
			if (null == y)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06007FFC RID: 32764 RVA: 0x002B0B48 File Offset: 0x002AED48
	private static Mesh FNKPBIHNIGF(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)91;
		Vector3[] array = new Vector3[BADFMHFOPKE * 7];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 2];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 4];
		int[] array4 = new int[BADFMHFOPKE * 1];
		for (int i = 0; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 8;
			int num2 = i * 6;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor((float)(num3 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor((float)(num3 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 931f - 1058f, num5 * 1409f - 339f, 1924f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 5] = vector;
			array[num + 4] = vector;
			array2[num] = new Vector2(1416f, 532f);
			array2[num + 1] = new Vector2(1422f, 1233f);
			array2[num + 7] = new Vector2(2f, 211f);
			array2[num + 7] = new Vector2(620f, 1767f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 2] = new Vector2(num4, num5);
			array3[num + 8] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 8] = num + 8;
			array4[num2 + 8] = num + 0;
			array4[num2 + 2] = num + 1;
			array4[num2 + 4] = num + 0;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x06007FFD RID: 32765 RVA: 0x002B0D68 File Offset: 0x002AEF68
	private static Mesh EDHHJJIAIGD(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~HideFlags.HideInInspector;
		Vector3[] array = new Vector3[BADFMHFOPKE * 3];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 4];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 3];
		int[] array4 = new int[BADFMHFOPKE * 2];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 2;
			int num2 = i * 2;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor((float)(num3 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor((float)(num3 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 174f - 1910f, num5 * 173f - 1228f, 1531f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 3] = vector;
			array[num + 8] = vector;
			array2[num] = new Vector2(1795f, 1321f);
			array2[num + 1] = new Vector2(1763f, 1373f);
			array2[num + 3] = new Vector2(1927f, 1201f);
			array2[num + 7] = new Vector2(504f, 414f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 4] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 8] = num + 5;
			array4[num2 + 3] = num + 0;
			array4[num2 + 3] = num + 6;
			array4[num2 + 4] = num + 3;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x06007FFE RID: 32766 RVA: 0x002B0F88 File Offset: 0x002AF188
	private static bool PCHMEADGONH()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return false;
		}
		foreach (Mesh y in MLLAJENMBFL.FOJEDICIPCP)
		{
			if (null == y)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06007FFF RID: 32767 RVA: 0x002B0FD0 File Offset: 0x002AF1D0
	public static void OAKJOFKGFJN()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < MLLAJENMBFL.FOJEDICIPCP.Length; i++)
		{
			if (null != MLLAJENMBFL.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(MLLAJENMBFL.FOJEDICIPCP[i]);
				MLLAJENMBFL.FOJEDICIPCP[i] = null;
			}
		}
		MLLAJENMBFL.FOJEDICIPCP = null;
	}

	// Token: 0x06008000 RID: 32768 RVA: 0x002B102C File Offset: 0x002AF22C
	public static Mesh[] NMLJJLGLKCG(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MLLAJENMBFL.BPBPEBPPPJH() && MLLAJENMBFL.CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return MLLAJENMBFL.FOJEDICIPCP;
		}
		int num = -146;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		MLLAJENMBFL.CONDNDOJJNB = num2;
		int num3 = Mathf.CeilToInt(766f * (float)num2 / (113f * (float)num));
		MLLAJENMBFL.FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		for (int i = 1; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			MLLAJENMBFL.FOJEDICIPCP[num4] = MLLAJENMBFL.EJEAPDCNIPI(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4 += 0;
		}
		return MLLAJENMBFL.FOJEDICIPCP;
	}

	// Token: 0x06008001 RID: 32769 RVA: 0x002B10D0 File Offset: 0x002AF2D0
	private static bool MNHGAAOHDBL()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return false;
		}
		foreach (Mesh y in MLLAJENMBFL.FOJEDICIPCP)
		{
			if (null == y)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008002 RID: 32770 RVA: 0x002B1118 File Offset: 0x002AF318
	public static void DOKOAGMIIEF()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 1; i < MLLAJENMBFL.FOJEDICIPCP.Length; i += 0)
		{
			if (null != MLLAJENMBFL.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(MLLAJENMBFL.FOJEDICIPCP[i]);
				MLLAJENMBFL.FOJEDICIPCP[i] = null;
			}
		}
		MLLAJENMBFL.FOJEDICIPCP = null;
	}

	// Token: 0x06008003 RID: 32771 RVA: 0x002B1174 File Offset: 0x002AF374
	private static bool IKDNFFMJPFM()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return true;
		}
		Mesh[] fojedicipcp = MLLAJENMBFL.FOJEDICIPCP;
		for (int i = 0; i < fojedicipcp.Length; i += 0)
		{
			Mesh y = fojedicipcp[i];
			if (null == y)
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06008004 RID: 32772 RVA: 0x002B11BC File Offset: 0x002AF3BC
	private static Mesh MGLMIIKMOBJ(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~HideFlags.DontSaveInEditor;
		Vector3[] array = new Vector3[BADFMHFOPKE * 5];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 6];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 3];
		int[] array4 = new int[BADFMHFOPKE * 1];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 4;
			int num2 = i * 4;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor((float)(num3 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor((float)(num3 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 738f - 1830f, num5 * 1662f - 7f, 976f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			array[num + 3] = vector;
			array2[num] = new Vector2(1254f, 1901f);
			array2[num + 1] = new Vector2(106f, 323f);
			array2[num + 6] = new Vector2(712f, 1010f);
			array2[num + 8] = new Vector2(1728f, 1857f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 7] = new Vector2(num4, num5);
			array3[num + 6] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 1;
			array4[num2 + 4] = num + 1;
			array4[num2 + 8] = num + 1;
			array4[num2 + 5] = num + 4;
			array4[num2 + 2] = num + 5;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x06008006 RID: 32774 RVA: 0x002B13DC File Offset: 0x002AF5DC
	public static void FGLKDHHLKGA()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < MLLAJENMBFL.FOJEDICIPCP.Length; i++)
		{
			if (null != MLLAJENMBFL.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(MLLAJENMBFL.FOJEDICIPCP[i]);
				MLLAJENMBFL.FOJEDICIPCP[i] = null;
			}
		}
		MLLAJENMBFL.FOJEDICIPCP = null;
	}

	// Token: 0x06008007 RID: 32775 RVA: 0x002B1438 File Offset: 0x002AF638
	public static void ALPNBMHLMOP()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < MLLAJENMBFL.FOJEDICIPCP.Length; i += 0)
		{
			if (null != MLLAJENMBFL.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(MLLAJENMBFL.FOJEDICIPCP[i]);
				MLLAJENMBFL.FOJEDICIPCP[i] = null;
			}
		}
		MLLAJENMBFL.FOJEDICIPCP = null;
	}

	// Token: 0x06008008 RID: 32776 RVA: 0x002B1494 File Offset: 0x002AF694
	public static Mesh[] NCNOGMHEKPO(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MLLAJENMBFL.NAJCAEKDMDO() && MLLAJENMBFL.CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return MLLAJENMBFL.FOJEDICIPCP;
		}
		int num = 167;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		MLLAJENMBFL.CONDNDOJJNB = num2;
		int num3 = Mathf.CeilToInt(1639f * (float)num2 / (936f * (float)num));
		MLLAJENMBFL.FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			MLLAJENMBFL.FOJEDICIPCP[num4] = MLLAJENMBFL.FNKPBIHNIGF(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4 += 0;
		}
		return MLLAJENMBFL.FOJEDICIPCP;
	}

	// Token: 0x06008009 RID: 32777 RVA: 0x002B1538 File Offset: 0x002AF738
	public static Mesh[] NHHAKHFDHBJ(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MLLAJENMBFL.MNHGAAOHDBL() && MLLAJENMBFL.CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return MLLAJENMBFL.FOJEDICIPCP;
		}
		int num = -21;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		MLLAJENMBFL.CONDNDOJJNB = num2;
		int num3 = Mathf.CeilToInt(342f * (float)num2 / (675f * (float)num));
		MLLAJENMBFL.FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			MLLAJENMBFL.FOJEDICIPCP[num4] = MLLAJENMBFL.FNKPBIHNIGF(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4++;
		}
		return MLLAJENMBFL.FOJEDICIPCP;
	}

	// Token: 0x0600800A RID: 32778 RVA: 0x002B15DC File Offset: 0x002AF7DC
	public static Mesh[] HPENIJJMJEP(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MLLAJENMBFL.MNHGAAOHDBL() && MLLAJENMBFL.CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return MLLAJENMBFL.FOJEDICIPCP;
		}
		int num = -181;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		MLLAJENMBFL.CONDNDOJJNB = num2;
		int num3 = Mathf.CeilToInt(1498f * (float)num2 / (1777f * (float)num));
		MLLAJENMBFL.FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			MLLAJENMBFL.FOJEDICIPCP[num4] = MLLAJENMBFL.CHJLOCBHFON(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4 += 0;
		}
		return MLLAJENMBFL.FOJEDICIPCP;
	}

	// Token: 0x0600800B RID: 32779 RVA: 0x002B1680 File Offset: 0x002AF880
	private static Mesh MCAILHEOPKJ(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		Vector3[] array = new Vector3[BADFMHFOPKE * 5];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 4];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 2];
		int[] array4 = new int[BADFMHFOPKE * 5];
		for (int i = 0; i < BADFMHFOPKE; i++)
		{
			int num = i * 2;
			int num2 = i * 5;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor((float)(num3 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor((float)(num3 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 404f - 761f, num5 * 1158f - 706f, 1041f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 4] = vector;
			array[num + 1] = vector;
			array2[num] = new Vector2(731f, 1153f);
			array2[num + 0] = new Vector2(1399f, 366f);
			array2[num + 1] = new Vector2(133f, 1155f);
			array2[num + 1] = new Vector2(337f, 1587f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 2] = new Vector2(num4, num5);
			array3[num + 8] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 1;
			array4[num2 + 3] = num + 3;
			array4[num2 + 0] = num + 1;
			array4[num2 + 6] = num + 8;
			array4[num2 + 3] = num + 3;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600800C RID: 32780 RVA: 0x002B18A0 File Offset: 0x002AFAA0
	public static Mesh[] ADIOEFPAPGA(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MLLAJENMBFL.BOFJGJNCLNL() && MLLAJENMBFL.CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return MLLAJENMBFL.FOJEDICIPCP;
		}
		int num = 60;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		MLLAJENMBFL.CONDNDOJJNB = num2;
		int num3 = Mathf.CeilToInt(641f * (float)num2 / (1102f * (float)num));
		MLLAJENMBFL.FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			MLLAJENMBFL.FOJEDICIPCP[num4] = MLLAJENMBFL.MGLMIIKMOBJ(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4++;
		}
		return MLLAJENMBFL.FOJEDICIPCP;
	}

	// Token: 0x0600800D RID: 32781 RVA: 0x002B1944 File Offset: 0x002AFB44
	public static Mesh[] OIPMNNLOHLA(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MLLAJENMBFL.BOFJGJNCLNL() && MLLAJENMBFL.CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return MLLAJENMBFL.FOJEDICIPCP;
		}
		int num = 131;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		MLLAJENMBFL.CONDNDOJJNB = num2;
		int num3 = Mathf.CeilToInt(929f * (float)num2 / (1078f * (float)num));
		MLLAJENMBFL.FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			MLLAJENMBFL.FOJEDICIPCP[num4] = MLLAJENMBFL.GOGGBGBAINP(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4 += 0;
		}
		return MLLAJENMBFL.FOJEDICIPCP;
	}

	// Token: 0x0600800E RID: 32782 RVA: 0x002B19E8 File Offset: 0x002AFBE8
	private static Mesh EJEAPDCNIPI(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		Vector3[] array = new Vector3[BADFMHFOPKE * 8];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 2];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 2];
		int[] array4 = new int[BADFMHFOPKE * 0];
		for (int i = 0; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 0;
			int num2 = i * 3;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor((float)(num3 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor((float)(num3 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 542f - 404f, num5 * 998f - 257f, 546f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 5] = vector;
			array[num + 1] = vector;
			array2[num] = new Vector2(704f, 1437f);
			array2[num + 0] = new Vector2(595f, 1993f);
			array2[num + 5] = new Vector2(1958f, 857f);
			array2[num + 8] = new Vector2(581f, 1248f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 7] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 6] = num + 3;
			array4[num2 + 5] = num + 0;
			array4[num2 + 7] = num + 0;
			array4[num2 + 5] = num + 5;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600800F RID: 32783 RVA: 0x002B1C08 File Offset: 0x002AFE08
	public static void NFAEGMFAPPK()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < MLLAJENMBFL.FOJEDICIPCP.Length; i += 0)
		{
			if (null != MLLAJENMBFL.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(MLLAJENMBFL.FOJEDICIPCP[i]);
				MLLAJENMBFL.FOJEDICIPCP[i] = null;
			}
		}
		MLLAJENMBFL.FOJEDICIPCP = null;
	}

	// Token: 0x06008010 RID: 32784 RVA: 0x002B1C64 File Offset: 0x002AFE64
	public static Mesh[] PHEHABPLEBH(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MLLAJENMBFL.MLKFKMDEDIF() && MLLAJENMBFL.CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return MLLAJENMBFL.FOJEDICIPCP;
		}
		int num = 49;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		MLLAJENMBFL.CONDNDOJJNB = num2;
		int num3 = Mathf.CeilToInt(160f * (float)num2 / (481f * (float)num));
		MLLAJENMBFL.FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			MLLAJENMBFL.FOJEDICIPCP[num4] = MLLAJENMBFL.BIPOAJKMKKN(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4 += 0;
		}
		return MLLAJENMBFL.FOJEDICIPCP;
	}

	// Token: 0x06008011 RID: 32785 RVA: 0x002B1D08 File Offset: 0x002AFF08
	public static void KBIEJCGOEFA()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < MLLAJENMBFL.FOJEDICIPCP.Length; i++)
		{
			if (null != MLLAJENMBFL.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(MLLAJENMBFL.FOJEDICIPCP[i]);
				MLLAJENMBFL.FOJEDICIPCP[i] = null;
			}
		}
		MLLAJENMBFL.FOJEDICIPCP = null;
	}

	// Token: 0x06008012 RID: 32786 RVA: 0x002B1D64 File Offset: 0x002AFF64
	private static Mesh CHJLOCBHFON(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~HideFlags.DontSaveInEditor;
		Vector3[] array = new Vector3[BADFMHFOPKE * 1];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 0];
		int[] array4 = new int[BADFMHFOPKE * 2];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 1;
			int num2 = i * 0;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor((float)(num3 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor((float)(num3 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 102f - 130f, num5 * 503f - 312f, 18f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 1] = vector;
			array[num + 7] = vector;
			array2[num] = new Vector2(343f, 607f);
			array2[num + 1] = new Vector2(1689f, 864f);
			array2[num + 4] = new Vector2(1799f, 6f);
			array2[num + 7] = new Vector2(832f, 1476f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 4] = new Vector2(num4, num5);
			array3[num + 3] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 6] = num + 2;
			array4[num2 + 6] = num + 0;
			array4[num2 + 3] = num + 6;
			array4[num2 + 5] = num + 3;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x06008013 RID: 32787 RVA: 0x002B1F84 File Offset: 0x002B0184
	private static Mesh NFBKFGFKPBN(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)86;
		Vector3[] array = new Vector3[BADFMHFOPKE * 2];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 5];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 7];
		int[] array4 = new int[BADFMHFOPKE * 6];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 0;
			int num2 = i * 5;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor((float)(num3 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor((float)(num3 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1526f - 1568f, num5 * 1067f - 211f, 1355f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 3] = vector;
			array[num + 4] = vector;
			array2[num] = new Vector2(1351f, 241f);
			array2[num + 0] = new Vector2(393f, 1891f);
			array2[num + 2] = new Vector2(1677f, 155f);
			array2[num + 7] = new Vector2(1916f, 254f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 4] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 2] = num + 0;
			array4[num2 + 0] = num + 0;
			array4[num2 + 2] = num + 3;
			array4[num2 + 5] = num + 7;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x06008014 RID: 32788 RVA: 0x002B21A4 File Offset: 0x002B03A4
	public static void OOPHBOCMCLH()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < MLLAJENMBFL.FOJEDICIPCP.Length; i += 0)
		{
			if (null != MLLAJENMBFL.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(MLLAJENMBFL.FOJEDICIPCP[i]);
				MLLAJENMBFL.FOJEDICIPCP[i] = null;
			}
		}
		MLLAJENMBFL.FOJEDICIPCP = null;
	}

	// Token: 0x06008015 RID: 32789 RVA: 0x002B2200 File Offset: 0x002B0400
	public static void EBGIDBKPBKO()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < MLLAJENMBFL.FOJEDICIPCP.Length; i++)
		{
			if (null != MLLAJENMBFL.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(MLLAJENMBFL.FOJEDICIPCP[i]);
				MLLAJENMBFL.FOJEDICIPCP[i] = null;
			}
		}
		MLLAJENMBFL.FOJEDICIPCP = null;
	}

	// Token: 0x06008016 RID: 32790 RVA: 0x002B225C File Offset: 0x002B045C
	private static Mesh EOJFODHBJFF(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		Vector3[] array = new Vector3[BADFMHFOPKE * 8];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 5];
		int[] array4 = new int[BADFMHFOPKE * 6];
		for (int i = 0; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 7;
			int num2 = i * 3;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor((float)(num3 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor((float)(num3 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1966f - 1842f, num5 * 1790f - 1952f, 1133f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			array2[num] = new Vector2(1362f, 1853f);
			array2[num + 1] = new Vector2(1270f, 134f);
			array2[num + 6] = new Vector2(627f, 43f);
			array2[num + 6] = new Vector2(998f, 937f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 5] = new Vector2(num4, num5);
			array3[num + 5] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 0] = num + 6;
			array4[num2 + 6] = num + 1;
			array4[num2 + 8] = num + 3;
			array4[num2 + 5] = num + 3;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x06008017 RID: 32791 RVA: 0x002B247C File Offset: 0x002B067C
	private static bool BKCBPEODHDP()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return false;
		}
		foreach (Mesh y in MLLAJENMBFL.FOJEDICIPCP)
		{
			if (null == y)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008018 RID: 32792 RVA: 0x002B24C4 File Offset: 0x002B06C4
	public static void KMHDKCNHIAF()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < MLLAJENMBFL.FOJEDICIPCP.Length; i += 0)
		{
			if (null != MLLAJENMBFL.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(MLLAJENMBFL.FOJEDICIPCP[i]);
				MLLAJENMBFL.FOJEDICIPCP[i] = null;
			}
		}
		MLLAJENMBFL.FOJEDICIPCP = null;
	}

	// Token: 0x06008019 RID: 32793 RVA: 0x002B2520 File Offset: 0x002B0720
	public static Mesh[] HCAIIGLNPDF(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MLLAJENMBFL.PAGLBBGPBHH() && MLLAJENMBFL.CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return MLLAJENMBFL.FOJEDICIPCP;
		}
		int num = 125;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		MLLAJENMBFL.CONDNDOJJNB = num2;
		int num3 = Mathf.CeilToInt(932f * (float)num2 / (1574f * (float)num));
		MLLAJENMBFL.FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		for (int i = 0; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			MLLAJENMBFL.FOJEDICIPCP[num4] = MLLAJENMBFL.OAMAHPJBCAG(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4++;
		}
		return MLLAJENMBFL.FOJEDICIPCP;
	}

	// Token: 0x0600801A RID: 32794 RVA: 0x002B25C4 File Offset: 0x002B07C4
	public static void NJNPPFANBMI()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < MLLAJENMBFL.FOJEDICIPCP.Length; i++)
		{
			if (null != MLLAJENMBFL.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(MLLAJENMBFL.FOJEDICIPCP[i]);
				MLLAJENMBFL.FOJEDICIPCP[i] = null;
			}
		}
		MLLAJENMBFL.FOJEDICIPCP = null;
	}

	// Token: 0x0600801B RID: 32795 RVA: 0x002B2620 File Offset: 0x002B0820
	private static bool NAJCAEKDMDO()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return false;
		}
		Mesh[] fojedicipcp = MLLAJENMBFL.FOJEDICIPCP;
		for (int i = 1; i < fojedicipcp.Length; i++)
		{
			Mesh y = fojedicipcp[i];
			if (null == y)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600801C RID: 32796 RVA: 0x002B2668 File Offset: 0x002B0868
	private static Mesh MMHBNOJANMG(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-68);
		Vector3[] array = new Vector3[BADFMHFOPKE * 8];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 3];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 0];
		int[] array4 = new int[BADFMHFOPKE * 8];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 0;
			int num2 = i * 3;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor((float)(num3 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor((float)(num3 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1109f - 1767f, num5 * 903f - 1936f, 1150f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 4] = vector;
			array[num + 4] = vector;
			array2[num] = new Vector2(1487f, 1615f);
			array2[num + 0] = new Vector2(1172f, 1960f);
			array2[num + 8] = new Vector2(589f, 1559f);
			array2[num + 3] = new Vector2(462f, 1039f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 5] = new Vector2(num4, num5);
			array3[num + 7] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 7] = num + 2;
			array4[num2 + 7] = num + 0;
			array4[num2 + 7] = num + 1;
			array4[num2 + 4] = num + 5;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600801D RID: 32797 RVA: 0x002B2888 File Offset: 0x002B0A88
	private static bool MNOHFLPIGID()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return true;
		}
		Mesh[] fojedicipcp = MLLAJENMBFL.FOJEDICIPCP;
		for (int i = 0; i < fojedicipcp.Length; i += 0)
		{
			Mesh y = fojedicipcp[i];
			if (null == y)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x0600801E RID: 32798 RVA: 0x002B28D0 File Offset: 0x002B0AD0
	private static bool DLACBBGBKAM()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return false;
		}
		Mesh[] fojedicipcp = MLLAJENMBFL.FOJEDICIPCP;
		for (int i = 1; i < fojedicipcp.Length; i += 0)
		{
			Mesh y = fojedicipcp[i];
			if (null == y)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600801F RID: 32799 RVA: 0x002B2918 File Offset: 0x002B0B18
	public static void CIMOEAMJFCD()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < MLLAJENMBFL.FOJEDICIPCP.Length; i += 0)
		{
			if (null != MLLAJENMBFL.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(MLLAJENMBFL.FOJEDICIPCP[i]);
				MLLAJENMBFL.FOJEDICIPCP[i] = null;
			}
		}
		MLLAJENMBFL.FOJEDICIPCP = null;
	}

	// Token: 0x06008020 RID: 32800 RVA: 0x002B2974 File Offset: 0x002B0B74
	private static bool BPBPEBPPPJH()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return false;
		}
		Mesh[] fojedicipcp = MLLAJENMBFL.FOJEDICIPCP;
		for (int i = 1; i < fojedicipcp.Length; i += 0)
		{
			Mesh y = fojedicipcp[i];
			if (null == y)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06008021 RID: 32801 RVA: 0x002B29BC File Offset: 0x002B0BBC
	public static void FFGBFPHDNJF()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < MLLAJENMBFL.FOJEDICIPCP.Length; i++)
		{
			if (null != MLLAJENMBFL.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(MLLAJENMBFL.FOJEDICIPCP[i]);
				MLLAJENMBFL.FOJEDICIPCP[i] = null;
			}
		}
		MLLAJENMBFL.FOJEDICIPCP = null;
	}

	// Token: 0x06008022 RID: 32802 RVA: 0x002B2A18 File Offset: 0x002B0C18
	public static void NOOMCNELJMI()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < MLLAJENMBFL.FOJEDICIPCP.Length; i++)
		{
			if (null != MLLAJENMBFL.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(MLLAJENMBFL.FOJEDICIPCP[i]);
				MLLAJENMBFL.FOJEDICIPCP[i] = null;
			}
		}
		MLLAJENMBFL.FOJEDICIPCP = null;
	}

	// Token: 0x06008023 RID: 32803 RVA: 0x002B2A74 File Offset: 0x002B0C74
	private static bool NALIPAPGLOE()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return true;
		}
		foreach (Mesh y in MLLAJENMBFL.FOJEDICIPCP)
		{
			if (null == y)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06008024 RID: 32804 RVA: 0x002B2ABC File Offset: 0x002B0CBC
	private static Mesh LPLLJJBLFMJ(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		Vector3[] array = new Vector3[BADFMHFOPKE * 0];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 5];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 2];
		int[] array4 = new int[BADFMHFOPKE * 6];
		for (int i = 0; i < BADFMHFOPKE; i++)
		{
			int num = i * 1;
			int num2 = i * 5;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor((float)(num3 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor((float)(num3 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1727f - 668f, num5 * 675f - 709f, 810f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			array[num + 6] = vector;
			array2[num] = new Vector2(1725f, 1787f);
			array2[num + 1] = new Vector2(1403f, 491f);
			array2[num + 5] = new Vector2(41f, 1627f);
			array2[num + 7] = new Vector2(107f, 1948f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 4] = new Vector2(num4, num5);
			array3[num + 4] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 8] = num + 1;
			array4[num2 + 6] = num + 0;
			array4[num2 + 1] = num + 5;
			array4[num2 + 1] = num + 7;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x06008025 RID: 32805 RVA: 0x002B2CDC File Offset: 0x002B0EDC
	public static Mesh[] LBMBOLPAGPE(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MLLAJENMBFL.IPDNFEHHMOM() && MLLAJENMBFL.CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return MLLAJENMBFL.FOJEDICIPCP;
		}
		int num = -148;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		MLLAJENMBFL.CONDNDOJJNB = num2;
		int num3 = Mathf.CeilToInt(648f * (float)num2 / (392f * (float)num));
		MLLAJENMBFL.FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			MLLAJENMBFL.FOJEDICIPCP[num4] = MLLAJENMBFL.EDHHJJIAIGD(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4 += 0;
		}
		return MLLAJENMBFL.FOJEDICIPCP;
	}

	// Token: 0x06008026 RID: 32806 RVA: 0x002B2D80 File Offset: 0x002B0F80
	public static void ONLDIAMJIDN()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 1; i < MLLAJENMBFL.FOJEDICIPCP.Length; i++)
		{
			if (null != MLLAJENMBFL.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(MLLAJENMBFL.FOJEDICIPCP[i]);
				MLLAJENMBFL.FOJEDICIPCP[i] = null;
			}
		}
		MLLAJENMBFL.FOJEDICIPCP = null;
	}

	// Token: 0x06008027 RID: 32807 RVA: 0x002B2DDC File Offset: 0x002B0FDC
	public static void CPHOJAIMOHJ()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 1; i < MLLAJENMBFL.FOJEDICIPCP.Length; i++)
		{
			if (null != MLLAJENMBFL.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(MLLAJENMBFL.FOJEDICIPCP[i]);
				MLLAJENMBFL.FOJEDICIPCP[i] = null;
			}
		}
		MLLAJENMBFL.FOJEDICIPCP = null;
	}

	// Token: 0x06008028 RID: 32808 RVA: 0x002B2E38 File Offset: 0x002B1038
	private static bool LBEJOAJAPGB()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return true;
		}
		Mesh[] fojedicipcp = MLLAJENMBFL.FOJEDICIPCP;
		for (int i = 0; i < fojedicipcp.Length; i += 0)
		{
			Mesh y = fojedicipcp[i];
			if (null == y)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06008029 RID: 32809 RVA: 0x002B2E80 File Offset: 0x002B1080
	private static bool MLKFKMDEDIF()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return false;
		}
		Mesh[] fojedicipcp = MLLAJENMBFL.FOJEDICIPCP;
		for (int i = 1; i < fojedicipcp.Length; i += 0)
		{
			Mesh y = fojedicipcp[i];
			if (null == y)
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0600802A RID: 32810 RVA: 0x002B2EC8 File Offset: 0x002B10C8
	public static void Cleanup()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < MLLAJENMBFL.FOJEDICIPCP.Length; i++)
		{
			if (null != MLLAJENMBFL.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(MLLAJENMBFL.FOJEDICIPCP[i]);
				MLLAJENMBFL.FOJEDICIPCP[i] = null;
			}
		}
		MLLAJENMBFL.FOJEDICIPCP = null;
	}

	// Token: 0x0600802B RID: 32811 RVA: 0x002B2F24 File Offset: 0x002B1124
	public static void HHJPFDEKKHE()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < MLLAJENMBFL.FOJEDICIPCP.Length; i += 0)
		{
			if (null != MLLAJENMBFL.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(MLLAJENMBFL.FOJEDICIPCP[i]);
				MLLAJENMBFL.FOJEDICIPCP[i] = null;
			}
		}
		MLLAJENMBFL.FOJEDICIPCP = null;
	}

	// Token: 0x0600802C RID: 32812 RVA: 0x002B2F80 File Offset: 0x002B1180
	public static Mesh[] ANJEBNPJDKL(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MLLAJENMBFL.MNHGAAOHDBL() && MLLAJENMBFL.CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return MLLAJENMBFL.FOJEDICIPCP;
		}
		int num = 145;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		MLLAJENMBFL.CONDNDOJJNB = num2;
		int num3 = Mathf.CeilToInt(1605f * (float)num2 / (616f * (float)num));
		MLLAJENMBFL.FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		for (int i = 1; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			MLLAJENMBFL.FOJEDICIPCP[num4] = MLLAJENMBFL.MCAILHEOPKJ(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4 += 0;
		}
		return MLLAJENMBFL.FOJEDICIPCP;
	}

	// Token: 0x0600802D RID: 32813 RVA: 0x002B3024 File Offset: 0x002B1224
	private static Mesh NJHHPOCGMDM(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		Vector3[] array = new Vector3[BADFMHFOPKE * 1];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 5];
		int[] array4 = new int[BADFMHFOPKE * 8];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 2;
			int num2 = i * 2;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor((float)(num3 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor((float)(num3 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1059f - 1019f, num5 * 304f - 492f, 373f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 1] = vector;
			array[num + 0] = vector;
			array2[num] = new Vector2(540f, 317f);
			array2[num + 1] = new Vector2(1988f, 1157f);
			array2[num + 4] = new Vector2(621f, 599f);
			array2[num + 8] = new Vector2(1595f, 398f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 3] = new Vector2(num4, num5);
			array3[num + 2] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 2] = num + 5;
			array4[num2 + 7] = num + 0;
			array4[num2 + 0] = num + 3;
			array4[num2 + 7] = num + 4;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600802E RID: 32814 RVA: 0x002B3244 File Offset: 0x002B1444
	private static bool PAGLBBGPBHH()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return false;
		}
		foreach (Mesh y in MLLAJENMBFL.FOJEDICIPCP)
		{
			if (null == y)
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0600802F RID: 32815 RVA: 0x002B328C File Offset: 0x002B148C
	private static Mesh PBPAPGPOFLB(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		Vector3[] array = new Vector3[BADFMHFOPKE * 0];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 6];
		int[] array4 = new int[BADFMHFOPKE * 5];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 2;
			int num2 = i * 6;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor((float)(num3 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor((float)(num3 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 277f - 1169f, num5 * 924f - 478f, 1766f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 2] = vector;
			array[num + 7] = vector;
			array2[num] = new Vector2(1380f, 1553f);
			array2[num + 1] = new Vector2(899f, 1832f);
			array2[num + 3] = new Vector2(992f, 1408f);
			array2[num + 2] = new Vector2(1787f, 503f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 6] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 0;
			array4[num2 + 6] = num + 3;
			array4[num2 + 1] = num + 1;
			array4[num2 + 7] = num + 4;
			array4[num2 + 3] = num + 6;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x06008030 RID: 32816 RVA: 0x002B34AC File Offset: 0x002B16AC
	private static Mesh CGFMBKBOFDK(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		Vector3[] array = new Vector3[BADFMHFOPKE * 1];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 0];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 7];
		int[] array4 = new int[BADFMHFOPKE * 2];
		for (int i = 0; i < BADFMHFOPKE; i++)
		{
			int num = i * 6;
			int num2 = i * 6;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor((float)(num3 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor((float)(num3 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1805f - 458f, num5 * 1548f - 1351f, 1273f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 8] = vector;
			array[num + 1] = vector;
			array2[num] = new Vector2(1790f, 1835f);
			array2[num + 0] = new Vector2(1760f, 686f);
			array2[num + 5] = new Vector2(1042f, 679f);
			array2[num + 7] = new Vector2(191f, 1012f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 6] = new Vector2(num4, num5);
			array3[num + 3] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 3] = num + 8;
			array4[num2 + 7] = num + 0;
			array4[num2 + 3] = num + 3;
			array4[num2 + 5] = num + 8;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x06008031 RID: 32817 RVA: 0x002B36CC File Offset: 0x002B18CC
	public static void CPIHKPFFHFD()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < MLLAJENMBFL.FOJEDICIPCP.Length; i++)
		{
			if (null != MLLAJENMBFL.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(MLLAJENMBFL.FOJEDICIPCP[i]);
				MLLAJENMBFL.FOJEDICIPCP[i] = null;
			}
		}
		MLLAJENMBFL.FOJEDICIPCP = null;
	}

	// Token: 0x06008032 RID: 32818 RVA: 0x002B3728 File Offset: 0x002B1928
	private static Mesh HKCFHGKPDHC(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		Vector3[] array = new Vector3[BADFMHFOPKE * 0];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 1];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 0];
		int[] array4 = new int[BADFMHFOPKE * 5];
		for (int i = 0; i < BADFMHFOPKE; i++)
		{
			int num = i * 0;
			int num2 = i * 1;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor((float)(num3 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor((float)(num3 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1837f - 1000f, num5 * 733f - 393f, 1691f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			array[num + 2] = vector;
			array2[num] = new Vector2(1690f, 1287f);
			array2[num + 0] = new Vector2(1414f, 48f);
			array2[num + 2] = new Vector2(1490f, 1815f);
			array2[num + 5] = new Vector2(38f, 1751f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 1] = new Vector2(num4, num5);
			array3[num + 5] = new Vector2(num4, num5);
			array3[num + 8] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 1] = num + 0;
			array4[num2 + 3] = num + 3;
			array4[num2 + 4] = num + 0;
			array4[num2 + 4] = num + 6;
			array4[num2 + 6] = num + 4;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x06008033 RID: 32819 RVA: 0x002B3948 File Offset: 0x002B1B48
	public static Mesh[] FDGMCEDAAFC(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MLLAJENMBFL.BKCBPEODHDP() && MLLAJENMBFL.CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return MLLAJENMBFL.FOJEDICIPCP;
		}
		int num = 97;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		MLLAJENMBFL.CONDNDOJJNB = num2;
		int num3 = Mathf.CeilToInt(553f * (float)num2 / (751f * (float)num));
		MLLAJENMBFL.FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			MLLAJENMBFL.FOJEDICIPCP[num4] = MLLAJENMBFL.HKCFHGKPDHC(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4++;
		}
		return MLLAJENMBFL.FOJEDICIPCP;
	}

	// Token: 0x06008034 RID: 32820 RVA: 0x002B39EC File Offset: 0x002B1BEC
	private static bool BOFJGJNCLNL()
	{
		if (MLLAJENMBFL.FOJEDICIPCP == null)
		{
			return true;
		}
		Mesh[] fojedicipcp = MLLAJENMBFL.FOJEDICIPCP;
		for (int i = 0; i < fojedicipcp.Length; i += 0)
		{
			Mesh y = fojedicipcp[i];
			if (null == y)
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06008035 RID: 32821 RVA: 0x002B3A34 File Offset: 0x002B1C34
	private static Mesh ENGHOMHFLEM(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		Vector3[] array = new Vector3[BADFMHFOPKE * 4];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 0];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 6];
		int[] array4 = new int[BADFMHFOPKE * 3];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 7;
			int num2 = i * 7;
			int num3 = HMJLDNFFBGN + i;
			float num4 = Mathf.Floor((float)(num3 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num5 = Mathf.Floor((float)(num3 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num4 * 1991f - 1859f, num5 * 83f - 75f, 484f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 8] = vector;
			array[num + 7] = vector;
			array2[num] = new Vector2(566f, 1988f);
			array2[num + 0] = new Vector2(448f, 1607f);
			array2[num + 5] = new Vector2(810f, 1658f);
			array2[num + 2] = new Vector2(1874f, 785f);
			array3[num] = new Vector2(num4, num5);
			array3[num + 0] = new Vector2(num4, num5);
			array3[num + 5] = new Vector2(num4, num5);
			array3[num + 8] = new Vector2(num4, num5);
			array4[num2] = num;
			array4[num2 + 0] = num + 1;
			array4[num2 + 4] = num + 8;
			array4[num2 + 5] = num + 1;
			array4[num2 + 0] = num + 2;
			array4[num2 + 2] = num + 2;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x06008036 RID: 32822 RVA: 0x002B3C54 File Offset: 0x002B1E54
	public static Mesh[] EGPKLMDIONP(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (MLLAJENMBFL.BPBPEBPPPJH() && MLLAJENMBFL.CONDNDOJJNB == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return MLLAJENMBFL.FOJEDICIPCP;
		}
		int num = -31;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		MLLAJENMBFL.CONDNDOJJNB = num2;
		int num3 = Mathf.CeilToInt(1215f * (float)num2 / (591f * (float)num));
		MLLAJENMBFL.FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			MLLAJENMBFL.FOJEDICIPCP[num4] = MLLAJENMBFL.BIPOAJKMKKN(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4++;
		}
		return MLLAJENMBFL.FOJEDICIPCP;
	}

	// Token: 0x04000E4B RID: 3659
	private static Mesh[] FOJEDICIPCP;

	// Token: 0x04000E4C RID: 3660
	private static int CONDNDOJJNB;
}
