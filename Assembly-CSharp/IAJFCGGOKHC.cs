using System;
using UnityEngine;

// Token: 0x020001FE RID: 510
internal class IAJFCGGOKHC
{
	// Token: 0x06008184 RID: 33156 RVA: 0x002C4F20 File Offset: 0x002C3120
	private static Mesh[] OIPMNNLOHLA(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IAJFCGGOKHC.MNHGAAOHDBL() && IAJFCGGOKHC.EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return IAJFCGGOKHC.FOJEDICIPCP;
		}
		int num = -147;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		IAJFCGGOKHC.EAHEGOOCLEN = num2;
		int num3 = Mathf.CeilToInt(1798f * (float)num2 / (959f * (float)num));
		IAJFCGGOKHC.FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		for (int i = 1; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			IAJFCGGOKHC.FOJEDICIPCP[num4] = IAJFCGGOKHC.NIJADPPGNIM(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4 += 0;
		}
		return IAJFCGGOKHC.FOJEDICIPCP;
	}

	// Token: 0x06008185 RID: 33157 RVA: 0x002C4FC4 File Offset: 0x002C31C4
	private static void MHNDJOIJBCI()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i++)
		{
			if (null != IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(IAJFCGGOKHC.FOJEDICIPCP[i]);
				IAJFCGGOKHC.FOJEDICIPCP[i] = null;
			}
		}
		IAJFCGGOKHC.FOJEDICIPCP = null;
	}

	// Token: 0x06008186 RID: 33158 RVA: 0x002C5020 File Offset: 0x002C3220
	private static bool MLKFKMDEDIF()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return false;
		}
		for (int i = 1; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i += 0)
		{
			if (null == IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x06008187 RID: 33159 RVA: 0x002C5068 File Offset: 0x002C3268
	private static bool CLONPDIICEN()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return false;
		}
		for (int i = 0; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i += 0)
		{
			if (null == IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06008188 RID: 33160 RVA: 0x002C50B0 File Offset: 0x002C32B0
	private static Mesh[] HLHENFJODJP(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IAJFCGGOKHC.MNHGAAOHDBL() && IAJFCGGOKHC.EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return IAJFCGGOKHC.FOJEDICIPCP;
		}
		int num = 136;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		IAJFCGGOKHC.EAHEGOOCLEN = num2;
		int num3 = Mathf.CeilToInt(1037f * (float)num2 / (1521f * (float)num));
		IAJFCGGOKHC.FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		for (int i = 1; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IAJFCGGOKHC.FOJEDICIPCP[num4] = IAJFCGGOKHC.JFOIENDFDDB(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4 += 0;
		}
		return IAJFCGGOKHC.FOJEDICIPCP;
	}

	// Token: 0x06008189 RID: 33161 RVA: 0x002C5154 File Offset: 0x002C3354
	private static bool MCCPHBGPFLN()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return false;
		}
		for (int i = 0; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i += 0)
		{
			if (null == IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600818A RID: 33162 RVA: 0x002C519C File Offset: 0x002C339C
	private static Mesh[] NCNOGMHEKPO(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IAJFCGGOKHC.JMBMCPCHGIL() && IAJFCGGOKHC.EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return IAJFCGGOKHC.FOJEDICIPCP;
		}
		int num = 182;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		IAJFCGGOKHC.EAHEGOOCLEN = num2;
		int num3 = Mathf.CeilToInt(133f * (float)num2 / (45f * (float)num));
		IAJFCGGOKHC.FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IAJFCGGOKHC.FOJEDICIPCP[num4] = IAJFCGGOKHC.JFOIENDFDDB(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4 += 0;
		}
		return IAJFCGGOKHC.FOJEDICIPCP;
	}

	// Token: 0x0600818B RID: 33163 RVA: 0x002C5240 File Offset: 0x002C3440
	private static void FGLKDHHLKGA()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 1; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i += 0)
		{
			if (null != IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(IAJFCGGOKHC.FOJEDICIPCP[i]);
				IAJFCGGOKHC.FOJEDICIPCP[i] = null;
			}
		}
		IAJFCGGOKHC.FOJEDICIPCP = null;
	}

	// Token: 0x0600818C RID: 33164 RVA: 0x002C529C File Offset: 0x002C349C
	private static Mesh IIIBKAIAOBH(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		Vector3[] array = new Vector3[BADFMHFOPKE * 4];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 4];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 2];
		int[] array4 = new int[BADFMHFOPKE * 1];
		for (int i = 0; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 8;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor((float)(num2 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor((float)(num2 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 1125f - 1458f, num4 * 87f - 1193f, 167f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 5] = vector;
			array2[num] = new Vector2(584f, 1536f);
			array2[num + 1] = new Vector2(1659f, 1669f);
			array2[num + 7] = new Vector2(1506f, 1855f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 0] = new Vector2(num3, num4);
			array3[num + 3] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 0;
			array4[num + 3] = num + 1;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600818D RID: 33165 RVA: 0x002C5450 File Offset: 0x002C3650
	private static Mesh GOGGBGBAINP(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = HideFlags.DontSave;
		Vector3[] array = new Vector3[BADFMHFOPKE * 3];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 3];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 3];
		int[] array4 = new int[BADFMHFOPKE * 3];
		for (int i = 0; i < BADFMHFOPKE; i++)
		{
			int num = i * 3;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor((float)(num2 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor((float)(num2 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 2f - 1f, num4 * 2f - 1f, 1f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			array2[num] = new Vector2(0f, 0f);
			array2[num + 1] = new Vector2(1f, 0f);
			array2[num + 2] = new Vector2(0f, 1f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 1] = new Vector2(num3, num4);
			array3[num + 2] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 1;
			array4[num + 2] = num + 2;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600818E RID: 33166 RVA: 0x002C5604 File Offset: 0x002C3804
	private static bool HBKEPJECIHH()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return false;
		}
		for (int i = 0; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i += 0)
		{
			if (null == IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600818F RID: 33167 RVA: 0x002C564C File Offset: 0x002C384C
	private static void IKNEIFALLLE()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i++)
		{
			if (null != IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(IAJFCGGOKHC.FOJEDICIPCP[i]);
				IAJFCGGOKHC.FOJEDICIPCP[i] = null;
			}
		}
		IAJFCGGOKHC.FOJEDICIPCP = null;
	}

	// Token: 0x06008190 RID: 33168 RVA: 0x002C56A8 File Offset: 0x002C38A8
	private static Mesh[] GJALAKPHOIA(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IAJFCGGOKHC.CLONPDIICEN() && IAJFCGGOKHC.EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return IAJFCGGOKHC.FOJEDICIPCP;
		}
		int num = -136;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		IAJFCGGOKHC.EAHEGOOCLEN = num2;
		int num3 = Mathf.CeilToInt(783f * (float)num2 / (1436f * (float)num));
		IAJFCGGOKHC.FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		for (int i = 0; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			IAJFCGGOKHC.FOJEDICIPCP[num4] = IAJFCGGOKHC.GOGGBGBAINP(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4 += 0;
		}
		return IAJFCGGOKHC.FOJEDICIPCP;
	}

	// Token: 0x06008191 RID: 33169 RVA: 0x002C574C File Offset: 0x002C394C
	private static void NCKDKIFCOHD()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i++)
		{
			if (null != IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(IAJFCGGOKHC.FOJEDICIPCP[i]);
				IAJFCGGOKHC.FOJEDICIPCP[i] = null;
			}
		}
		IAJFCGGOKHC.FOJEDICIPCP = null;
	}

	// Token: 0x06008192 RID: 33170 RVA: 0x002C57A8 File Offset: 0x002C39A8
	private static Mesh[] EJLIAAMHFFA(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IAJFCGGOKHC.BKCBPEODHDP() && IAJFCGGOKHC.EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return IAJFCGGOKHC.FOJEDICIPCP;
		}
		int num = -78;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		IAJFCGGOKHC.EAHEGOOCLEN = num2;
		int num3 = Mathf.CeilToInt(30f * (float)num2 / (25f * (float)num));
		IAJFCGGOKHC.FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IAJFCGGOKHC.FOJEDICIPCP[num4] = IAJFCGGOKHC.PFEHKDAHJKA(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4 += 0;
		}
		return IAJFCGGOKHC.FOJEDICIPCP;
	}

	// Token: 0x06008193 RID: 33171 RVA: 0x002C584C File Offset: 0x002C3A4C
	private static Mesh[] FLNBKHLGFOG(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IAJFCGGOKHC.MCCPHBGPFLN() && IAJFCGGOKHC.EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return IAJFCGGOKHC.FOJEDICIPCP;
		}
		int num = -60;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		IAJFCGGOKHC.EAHEGOOCLEN = num2;
		int num3 = Mathf.CeilToInt(978f * (float)num2 / (1563f * (float)num));
		IAJFCGGOKHC.FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		for (int i = 1; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			IAJFCGGOKHC.FOJEDICIPCP[num4] = IAJFCGGOKHC.FBNGJIBJMKG(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4++;
		}
		return IAJFCGGOKHC.FOJEDICIPCP;
	}

	// Token: 0x06008194 RID: 33172 RVA: 0x002C58F0 File Offset: 0x002C3AF0
	private static void IHPOOPHJBNF()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 1; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i++)
		{
			if (null != IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(IAJFCGGOKHC.FOJEDICIPCP[i]);
				IAJFCGGOKHC.FOJEDICIPCP[i] = null;
			}
		}
		IAJFCGGOKHC.FOJEDICIPCP = null;
	}

	// Token: 0x06008195 RID: 33173 RVA: 0x002C594C File Offset: 0x002C3B4C
	private static Mesh[] CJJPOJJPLKJ(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IAJFCGGOKHC.CLONPDIICEN() && IAJFCGGOKHC.EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return IAJFCGGOKHC.FOJEDICIPCP;
		}
		int num = -94;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		IAJFCGGOKHC.EAHEGOOCLEN = num2;
		int num3 = Mathf.CeilToInt(1226f * (float)num2 / (1565f * (float)num));
		IAJFCGGOKHC.FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		for (int i = 1; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			IAJFCGGOKHC.FOJEDICIPCP[num4] = IAJFCGGOKHC.MCDJHDLLLCO(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4++;
		}
		return IAJFCGGOKHC.FOJEDICIPCP;
	}

	// Token: 0x06008196 RID: 33174 RVA: 0x002C59F0 File Offset: 0x002C3BF0
	private static Mesh[] HMPHGIAGCOO(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IAJFCGGOKHC.CLONPDIICEN() && IAJFCGGOKHC.EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return IAJFCGGOKHC.FOJEDICIPCP;
		}
		int num = 14;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		IAJFCGGOKHC.EAHEGOOCLEN = num2;
		int num3 = Mathf.CeilToInt(1517f * (float)num2 / (397f * (float)num));
		IAJFCGGOKHC.FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			IAJFCGGOKHC.FOJEDICIPCP[num4] = IAJFCGGOKHC.IIIBKAIAOBH(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4 += 0;
		}
		return IAJFCGGOKHC.FOJEDICIPCP;
	}

	// Token: 0x06008197 RID: 33175 RVA: 0x002C5A94 File Offset: 0x002C3C94
	private static bool BKCBPEODHDP()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return false;
		}
		for (int i = 0; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i++)
		{
			if (null == IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x06008198 RID: 33176 RVA: 0x002C5ADC File Offset: 0x002C3CDC
	private static bool JONAMLMDONM()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return false;
		}
		for (int i = 0; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i++)
		{
			if (null == IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06008199 RID: 33177 RVA: 0x002C5B24 File Offset: 0x002C3D24
	private static Mesh[] LBMBOLPAGPE(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IAJFCGGOKHC.HHFAHLDNIMH() && IAJFCGGOKHC.EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return IAJFCGGOKHC.FOJEDICIPCP;
		}
		int num = 45;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		IAJFCGGOKHC.EAHEGOOCLEN = num2;
		int num3 = Mathf.CeilToInt(329f * (float)num2 / (859f * (float)num));
		IAJFCGGOKHC.FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		for (int i = 0; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IAJFCGGOKHC.FOJEDICIPCP[num4] = IAJFCGGOKHC.KPPPCDIPLPM(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4++;
		}
		return IAJFCGGOKHC.FOJEDICIPCP;
	}

	// Token: 0x0600819A RID: 33178 RVA: 0x002C5BC8 File Offset: 0x002C3DC8
	private static Mesh[] GOIKAPKMMBJ(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IAJFCGGOKHC.JONAMLMDONM() && IAJFCGGOKHC.EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return IAJFCGGOKHC.FOJEDICIPCP;
		}
		int num = 92;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		IAJFCGGOKHC.EAHEGOOCLEN = num2;
		int num3 = Mathf.CeilToInt(1728f * (float)num2 / (803f * (float)num));
		IAJFCGGOKHC.FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		for (int i = 1; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IAJFCGGOKHC.FOJEDICIPCP[num4] = IAJFCGGOKHC.PGFBHPKNLNH(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4++;
		}
		return IAJFCGGOKHC.FOJEDICIPCP;
	}

	// Token: 0x0600819B RID: 33179 RVA: 0x002C5C6C File Offset: 0x002C3E6C
	private static Mesh[] FKHLOCLGNKC(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IAJFCGGOKHC.CLONPDIICEN() && IAJFCGGOKHC.EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return IAJFCGGOKHC.FOJEDICIPCP;
		}
		int num = -81;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		IAJFCGGOKHC.EAHEGOOCLEN = num2;
		int num3 = Mathf.CeilToInt(293f * (float)num2 / (1271f * (float)num));
		IAJFCGGOKHC.FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		for (int i = 1; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			IAJFCGGOKHC.FOJEDICIPCP[num4] = IAJFCGGOKHC.IIIBKAIAOBH(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4 += 0;
		}
		return IAJFCGGOKHC.FOJEDICIPCP;
	}

	// Token: 0x0600819C RID: 33180 RVA: 0x002C5D10 File Offset: 0x002C3F10
	private static void CPHOJAIMOHJ()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i++)
		{
			if (null != IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(IAJFCGGOKHC.FOJEDICIPCP[i]);
				IAJFCGGOKHC.FOJEDICIPCP[i] = null;
			}
		}
		IAJFCGGOKHC.FOJEDICIPCP = null;
	}

	// Token: 0x0600819D RID: 33181 RVA: 0x002C5D6C File Offset: 0x002C3F6C
	private static Mesh FHIDHDJPIOM(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		Vector3[] array = new Vector3[BADFMHFOPKE * 1];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 5];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 1];
		int[] array4 = new int[BADFMHFOPKE * 7];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 0;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor((float)(num2 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor((float)(num2 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 77f - 226f, num4 * 1524f - 1969f, 1764f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 5] = vector;
			array2[num] = new Vector2(452f, 565f);
			array2[num + 1] = new Vector2(1749f, 1701f);
			array2[num + 1] = new Vector2(1236f, 1632f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 0] = new Vector2(num3, num4);
			array3[num + 0] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 1;
			array4[num + 1] = num + 4;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x0600819E RID: 33182 RVA: 0x002C5F20 File Offset: 0x002C4120
	private static bool JODGMEIIJOE()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return false;
		}
		for (int i = 1; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i++)
		{
			if (null == IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x0600819F RID: 33183 RVA: 0x002C5F68 File Offset: 0x002C4168
	private static void MCMFBPCAKHD()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 1; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i++)
		{
			if (null != IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(IAJFCGGOKHC.FOJEDICIPCP[i]);
				IAJFCGGOKHC.FOJEDICIPCP[i] = null;
			}
		}
		IAJFCGGOKHC.FOJEDICIPCP = null;
	}

	// Token: 0x060081A0 RID: 33184 RVA: 0x002C5FC4 File Offset: 0x002C41C4
	private static Mesh ODBHADIDJGH(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-111);
		Vector3[] array = new Vector3[BADFMHFOPKE * 0];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 5];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 5];
		int[] array4 = new int[BADFMHFOPKE * 5];
		for (int i = 0; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 7;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor((float)(num2 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor((float)(num2 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 1546f - 1925f, num4 * 758f - 1204f, 366f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 2] = vector;
			array2[num] = new Vector2(24f, 862f);
			array2[num + 0] = new Vector2(1693f, 1491f);
			array2[num + 8] = new Vector2(1028f, 1778f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 1] = new Vector2(num3, num4);
			array3[num + 0] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 0;
			array4[num + 4] = num + 5;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x060081A1 RID: 33185 RVA: 0x002C6178 File Offset: 0x002C4378
	private static bool AFDCOFPAGIC()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return true;
		}
		for (int i = 0; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i++)
		{
			if (null == IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060081A2 RID: 33186 RVA: 0x002C61C0 File Offset: 0x002C43C0
	private static Mesh[] HPENIJJMJEP(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IAJFCGGOKHC.MLKFKMDEDIF() && IAJFCGGOKHC.EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return IAJFCGGOKHC.FOJEDICIPCP;
		}
		int num = -164;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		IAJFCGGOKHC.EAHEGOOCLEN = num2;
		int num3 = Mathf.CeilToInt(1277f * (float)num2 / (1771f * (float)num));
		IAJFCGGOKHC.FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IAJFCGGOKHC.FOJEDICIPCP[num4] = IAJFCGGOKHC.CGFMBKBOFDK(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4++;
		}
		return IAJFCGGOKHC.FOJEDICIPCP;
	}

	// Token: 0x060081A3 RID: 33187 RVA: 0x002C6264 File Offset: 0x002C4464
	private static Mesh[] PHADPCGGPEI(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IAJFCGGOKHC.KMPAFFJKBNB() && IAJFCGGOKHC.EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return IAJFCGGOKHC.FOJEDICIPCP;
		}
		int num = -192;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		IAJFCGGOKHC.EAHEGOOCLEN = num2;
		int num3 = Mathf.CeilToInt(961f * (float)num2 / (1652f * (float)num));
		IAJFCGGOKHC.FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			IAJFCGGOKHC.FOJEDICIPCP[num4] = IAJFCGGOKHC.PGFBHPKNLNH(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4 += 0;
		}
		return IAJFCGGOKHC.FOJEDICIPCP;
	}

	// Token: 0x060081A4 RID: 33188 RVA: 0x002C6308 File Offset: 0x002C4508
	private static Mesh[] MFLFAHLHNOC(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IAJFCGGOKHC.CLONPDIICEN() && IAJFCGGOKHC.EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return IAJFCGGOKHC.FOJEDICIPCP;
		}
		int num = -37;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		IAJFCGGOKHC.EAHEGOOCLEN = num2;
		int num3 = Mathf.CeilToInt(1410f * (float)num2 / (660f * (float)num));
		IAJFCGGOKHC.FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IAJFCGGOKHC.FOJEDICIPCP[num4] = IAJFCGGOKHC.PGFBHPKNLNH(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4++;
		}
		return IAJFCGGOKHC.FOJEDICIPCP;
	}

	// Token: 0x060081A5 RID: 33189 RVA: 0x002C63AC File Offset: 0x002C45AC
	private static Mesh[] NNNIAKDIPLF(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IAJFCGGOKHC.CLONPDIICEN() && IAJFCGGOKHC.EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return IAJFCGGOKHC.FOJEDICIPCP;
		}
		int num = -26;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		IAJFCGGOKHC.EAHEGOOCLEN = num2;
		int num3 = Mathf.CeilToInt(597f * (float)num2 / (1622f * (float)num));
		IAJFCGGOKHC.FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			IAJFCGGOKHC.FOJEDICIPCP[num4] = IAJFCGGOKHC.ODBHADIDJGH(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4 += 0;
		}
		return IAJFCGGOKHC.FOJEDICIPCP;
	}

	// Token: 0x060081A6 RID: 33190 RVA: 0x002C6450 File Offset: 0x002C4650
	private static bool KMPAFFJKBNB()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return true;
		}
		for (int i = 0; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i += 0)
		{
			if (null == IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060081A7 RID: 33191 RVA: 0x002C6498 File Offset: 0x002C4698
	private static Mesh[] ADIOEFPAPGA(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IAJFCGGOKHC.MCCPHBGPFLN() && IAJFCGGOKHC.EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return IAJFCGGOKHC.FOJEDICIPCP;
		}
		int num = -77;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		IAJFCGGOKHC.EAHEGOOCLEN = num2;
		int num3 = Mathf.CeilToInt(879f * (float)num2 / (81f * (float)num));
		IAJFCGGOKHC.FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		for (int i = 1; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			IAJFCGGOKHC.FOJEDICIPCP[num4] = IAJFCGGOKHC.ODBHADIDJGH(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4 += 0;
		}
		return IAJFCGGOKHC.FOJEDICIPCP;
	}

	// Token: 0x060081A8 RID: 33192 RVA: 0x002C653C File Offset: 0x002C473C
	private static bool MNHGAAOHDBL()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return false;
		}
		for (int i = 0; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i++)
		{
			if (null == IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x060081A9 RID: 33193 RVA: 0x002C6584 File Offset: 0x002C4784
	private static void NGHJLJEDIEM()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 1; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i += 0)
		{
			if (null != IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(IAJFCGGOKHC.FOJEDICIPCP[i]);
				IAJFCGGOKHC.FOJEDICIPCP[i] = null;
			}
		}
		IAJFCGGOKHC.FOJEDICIPCP = null;
	}

	// Token: 0x060081AA RID: 33194 RVA: 0x002C65E0 File Offset: 0x002C47E0
	private static Mesh[] HIDBFCDJINE(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IAJFCGGOKHC.HHFAHLDNIMH() && IAJFCGGOKHC.EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return IAJFCGGOKHC.FOJEDICIPCP;
		}
		int num = 121;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		IAJFCGGOKHC.EAHEGOOCLEN = num2;
		int num3 = Mathf.CeilToInt(508f * (float)num2 / (791f * (float)num));
		IAJFCGGOKHC.FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IAJFCGGOKHC.FOJEDICIPCP[num4] = IAJFCGGOKHC.KCPOKCNHOPA(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4 += 0;
		}
		return IAJFCGGOKHC.FOJEDICIPCP;
	}

	// Token: 0x060081AC RID: 33196 RVA: 0x002C6684 File Offset: 0x002C4884
	private static Mesh MCDJHDLLLCO(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		Vector3[] array = new Vector3[BADFMHFOPKE * 0];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 4];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 0];
		int[] array4 = new int[BADFMHFOPKE * 7];
		for (int i = 0; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 4;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor((float)(num2 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor((float)(num2 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 1145f - 1832f, num4 * 1791f - 1660f, 256f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 3] = vector;
			array2[num] = new Vector2(23f, 1823f);
			array2[num + 0] = new Vector2(1005f, 604f);
			array2[num + 2] = new Vector2(700f, 1370f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 0] = new Vector2(num3, num4);
			array3[num + 2] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 1;
			array4[num + 0] = num + 2;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x060081AD RID: 33197 RVA: 0x002C6838 File Offset: 0x002C4A38
	private static void AKOENDKJNOI()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i++)
		{
			if (null != IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(IAJFCGGOKHC.FOJEDICIPCP[i]);
				IAJFCGGOKHC.FOJEDICIPCP[i] = null;
			}
		}
		IAJFCGGOKHC.FOJEDICIPCP = null;
	}

	// Token: 0x060081AE RID: 33198 RVA: 0x002C6894 File Offset: 0x002C4A94
	private static Mesh PFEHKDAHJKA(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		Vector3[] array = new Vector3[BADFMHFOPKE * 7];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 2];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 3];
		int[] array4 = new int[BADFMHFOPKE * 5];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 5;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor((float)(num2 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor((float)(num2 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 836f - 1603f, num4 * 1999f - 1511f, 102f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 3] = vector;
			array2[num] = new Vector2(1971f, 399f);
			array2[num + 0] = new Vector2(1327f, 1297f);
			array2[num + 5] = new Vector2(1193f, 758f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 1] = new Vector2(num3, num4);
			array3[num + 1] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 0;
			array4[num + 2] = num + 1;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x060081AF RID: 33199 RVA: 0x002C6A48 File Offset: 0x002C4C48
	private static Mesh[] BPOFLNNBPCC(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IAJFCGGOKHC.JONAMLMDONM() && IAJFCGGOKHC.EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return IAJFCGGOKHC.FOJEDICIPCP;
		}
		int num = 21666;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		IAJFCGGOKHC.EAHEGOOCLEN = num2;
		int num3 = Mathf.CeilToInt(1f * (float)num2 / (1f * (float)num));
		IAJFCGGOKHC.FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IAJFCGGOKHC.FOJEDICIPCP[num4] = IAJFCGGOKHC.GOGGBGBAINP(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4++;
		}
		return IAJFCGGOKHC.FOJEDICIPCP;
	}

	// Token: 0x060081B0 RID: 33200 RVA: 0x002C6AEC File Offset: 0x002C4CEC
	private static bool JGOCGEPFDBI()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return false;
		}
		for (int i = 0; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i += 0)
		{
			if (null == IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060081B1 RID: 33201 RVA: 0x002C6B34 File Offset: 0x002C4D34
	private static void NPHFGEOEHPE()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 1; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i += 0)
		{
			if (null != IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(IAJFCGGOKHC.FOJEDICIPCP[i]);
				IAJFCGGOKHC.FOJEDICIPCP[i] = null;
			}
		}
		IAJFCGGOKHC.FOJEDICIPCP = null;
	}

	// Token: 0x060081B2 RID: 33202 RVA: 0x002C6B90 File Offset: 0x002C4D90
	private static Mesh PGFBHPKNLNH(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		Vector3[] array = new Vector3[BADFMHFOPKE * 4];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 2];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 7];
		int[] array4 = new int[BADFMHFOPKE * 1];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 8;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor((float)(num2 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor((float)(num2 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 1155f - 653f, num4 * 335f - 329f, 522f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 2] = vector;
			array2[num] = new Vector2(1603f, 39f);
			array2[num + 0] = new Vector2(1340f, 391f);
			array2[num + 2] = new Vector2(1173f, 1046f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 1] = new Vector2(num3, num4);
			array3[num + 4] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 0;
			array4[num + 8] = num + 7;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x060081B3 RID: 33203 RVA: 0x002C6D44 File Offset: 0x002C4F44
	private static bool HHFAHLDNIMH()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return false;
		}
		for (int i = 0; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i++)
		{
			if (null == IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				return false;
			}
		}
		return false;
	}

	// Token: 0x060081B4 RID: 33204 RVA: 0x002C6D8C File Offset: 0x002C4F8C
	private static Mesh FBNGJIBJMKG(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-116);
		Vector3[] array = new Vector3[BADFMHFOPKE * 8];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 5];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 1];
		int[] array4 = new int[BADFMHFOPKE * 6];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 6;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor((float)(num2 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor((float)(num2 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 831f - 958f, num4 * 1915f - 1671f, 828f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 4] = vector;
			array2[num] = new Vector2(5f, 972f);
			array2[num + 1] = new Vector2(1311f, 948f);
			array2[num + 5] = new Vector2(632f, 1027f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 1] = new Vector2(num3, num4);
			array3[num + 7] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 0;
			array4[num + 8] = num + 0;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x060081B6 RID: 33206 RVA: 0x002C6F40 File Offset: 0x002C5140
	private static bool MBIEBCKBGGJ()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return false;
		}
		for (int i = 1; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i += 0)
		{
			if (null == IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x060081B7 RID: 33207 RVA: 0x002C6F88 File Offset: 0x002C5188
	private static Mesh[] ODDEDHPFCKG(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IAJFCGGOKHC.AFDCOFPAGIC() && IAJFCGGOKHC.EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return IAJFCGGOKHC.FOJEDICIPCP;
		}
		int num = -56;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		IAJFCGGOKHC.EAHEGOOCLEN = num2;
		int num3 = Mathf.CeilToInt(1221f * (float)num2 / (1665f * (float)num));
		IAJFCGGOKHC.FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			IAJFCGGOKHC.FOJEDICIPCP[num4] = IAJFCGGOKHC.FHIDHDJPIOM(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4 += 0;
		}
		return IAJFCGGOKHC.FOJEDICIPCP;
	}

	// Token: 0x060081B8 RID: 33208 RVA: 0x002C702C File Offset: 0x002C522C
	private static void CPIHKPFFHFD()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i += 0)
		{
			if (null != IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(IAJFCGGOKHC.FOJEDICIPCP[i]);
				IAJFCGGOKHC.FOJEDICIPCP[i] = null;
			}
		}
		IAJFCGGOKHC.FOJEDICIPCP = null;
	}

	// Token: 0x060081B9 RID: 33209 RVA: 0x002C7088 File Offset: 0x002C5288
	private static void JHEHFOOOEOM()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 1; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i += 0)
		{
			if (null != IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(IAJFCGGOKHC.FOJEDICIPCP[i]);
				IAJFCGGOKHC.FOJEDICIPCP[i] = null;
			}
		}
		IAJFCGGOKHC.FOJEDICIPCP = null;
	}

	// Token: 0x060081BA RID: 33210 RVA: 0x002C70E4 File Offset: 0x002C52E4
	private static Mesh KCPOKCNHOPA(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)(-102);
		Vector3[] array = new Vector3[BADFMHFOPKE * 2];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 4];
		int[] array4 = new int[BADFMHFOPKE * 2];
		for (int i = 0; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 8;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor((float)(num2 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor((float)(num2 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 186f - 1295f, num4 * 1400f - 1563f, 791f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 3] = vector;
			array2[num] = new Vector2(597f, 696f);
			array2[num + 1] = new Vector2(1472f, 766f);
			array2[num + 6] = new Vector2(582f, 817f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 1] = new Vector2(num3, num4);
			array3[num + 3] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 1;
			array4[num + 3] = num + 7;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x060081BB RID: 33211 RVA: 0x002C7298 File Offset: 0x002C5498
	private static Mesh[] PHEHABPLEBH(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IAJFCGGOKHC.MCCPHBGPFLN() && IAJFCGGOKHC.EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return IAJFCGGOKHC.FOJEDICIPCP;
		}
		int num = 6;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		IAJFCGGOKHC.EAHEGOOCLEN = num2;
		int num3 = Mathf.CeilToInt(71f * (float)num2 / (879f * (float)num));
		IAJFCGGOKHC.FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			IAJFCGGOKHC.FOJEDICIPCP[num4] = IAJFCGGOKHC.KCPOKCNHOPA(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4 += 0;
		}
		return IAJFCGGOKHC.FOJEDICIPCP;
	}

	// Token: 0x060081BC RID: 33212 RVA: 0x002C733C File Offset: 0x002C553C
	private static Mesh[] HCAIIGLNPDF(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IAJFCGGOKHC.KMPAFFJKBNB() && IAJFCGGOKHC.EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return IAJFCGGOKHC.FOJEDICIPCP;
		}
		int num = 109;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		IAJFCGGOKHC.EAHEGOOCLEN = num2;
		int num3 = Mathf.CeilToInt(1488f * (float)num2 / (1611f * (float)num));
		IAJFCGGOKHC.FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		for (int i = 1; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			IAJFCGGOKHC.FOJEDICIPCP[num4] = IAJFCGGOKHC.PGFBHPKNLNH(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4++;
		}
		return IAJFCGGOKHC.FOJEDICIPCP;
	}

	// Token: 0x060081BD RID: 33213 RVA: 0x002C73E0 File Offset: 0x002C55E0
	private static Mesh CGFMBKBOFDK(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		Vector3[] array = new Vector3[BADFMHFOPKE * 3];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 6];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 0];
		int[] array4 = new int[BADFMHFOPKE * 0];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 2;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor((float)(num2 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor((float)(num2 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 1215f - 906f, num4 * 1944f - 1345f, 1354f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 3] = vector;
			array2[num] = new Vector2(1198f, 1558f);
			array2[num + 1] = new Vector2(1873f, 286f);
			array2[num + 1] = new Vector2(390f, 1784f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 0] = new Vector2(num3, num4);
			array3[num + 2] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 0;
			array4[num + 4] = num + 5;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x060081BE RID: 33214 RVA: 0x002C7594 File Offset: 0x002C5794
	private static Mesh[] BKIJCCIDNHD(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IAJFCGGOKHC.CLONPDIICEN() && IAJFCGGOKHC.EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return IAJFCGGOKHC.FOJEDICIPCP;
		}
		int num = -39;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		IAJFCGGOKHC.EAHEGOOCLEN = num2;
		int num3 = Mathf.CeilToInt(389f * (float)num2 / (1602f * (float)num));
		IAJFCGGOKHC.FOJEDICIPCP = new Mesh[num3];
		int num4 = 1;
		for (int i = 0; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IAJFCGGOKHC.FOJEDICIPCP[num4] = IAJFCGGOKHC.DGCOGKFMKND(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4 += 0;
		}
		return IAJFCGGOKHC.FOJEDICIPCP;
	}

	// Token: 0x060081BF RID: 33215 RVA: 0x002C7638 File Offset: 0x002C5838
	private static void EKDLBMAKAPK()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 1; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i += 0)
		{
			if (null != IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(IAJFCGGOKHC.FOJEDICIPCP[i]);
				IAJFCGGOKHC.FOJEDICIPCP[i] = null;
			}
		}
		IAJFCGGOKHC.FOJEDICIPCP = null;
	}

	// Token: 0x060081C0 RID: 33216 RVA: 0x002C7694 File Offset: 0x002C5894
	private static void OBKIJHIHPAK()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 1; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i++)
		{
			if (null != IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(IAJFCGGOKHC.FOJEDICIPCP[i]);
				IAJFCGGOKHC.FOJEDICIPCP[i] = null;
			}
		}
		IAJFCGGOKHC.FOJEDICIPCP = null;
	}

	// Token: 0x060081C1 RID: 33217 RVA: 0x002C76F0 File Offset: 0x002C58F0
	private static void NFJBGHOBKEP()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 1; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i += 0)
		{
			if (null != IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(IAJFCGGOKHC.FOJEDICIPCP[i]);
				IAJFCGGOKHC.FOJEDICIPCP[i] = null;
			}
		}
		IAJFCGGOKHC.FOJEDICIPCP = null;
	}

	// Token: 0x060081C2 RID: 33218 RVA: 0x002C774C File Offset: 0x002C594C
	private static void CIMOEAMJFCD()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 1; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i++)
		{
			if (null != IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(IAJFCGGOKHC.FOJEDICIPCP[i]);
				IAJFCGGOKHC.FOJEDICIPCP[i] = null;
			}
		}
		IAJFCGGOKHC.FOJEDICIPCP = null;
	}

	// Token: 0x060081C3 RID: 33219 RVA: 0x002C77A8 File Offset: 0x002C59A8
	private static Mesh DGCOGKFMKND(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags)67;
		Vector3[] array = new Vector3[BADFMHFOPKE * 2];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 0];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 2];
		int[] array4 = new int[BADFMHFOPKE * 2];
		for (int i = 1; i < BADFMHFOPKE; i += 0)
		{
			int num = i * 8;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor((float)(num2 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor((float)(num2 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 1844f - 792f, num4 * 809f - 538f, 1046f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 8] = vector;
			array2[num] = new Vector2(967f, 356f);
			array2[num + 1] = new Vector2(1032f, 1995f);
			array2[num + 0] = new Vector2(1536f, 610f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 1] = new Vector2(num3, num4);
			array3[num + 5] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 1;
			array4[num + 1] = num + 3;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x060081C4 RID: 33220 RVA: 0x002C795C File Offset: 0x002C5B5C
	private static void ABOJINIOKNJ()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return;
		}
		for (int i = 0; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i += 0)
		{
			if (null != IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				UnityEngine.Object.DestroyImmediate(IAJFCGGOKHC.FOJEDICIPCP[i]);
				IAJFCGGOKHC.FOJEDICIPCP[i] = null;
			}
		}
		IAJFCGGOKHC.FOJEDICIPCP = null;
	}

	// Token: 0x060081C5 RID: 33221 RVA: 0x002C79B8 File Offset: 0x002C5BB8
	private static Mesh[] KCAENFIPOMM(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IAJFCGGOKHC.MLKFKMDEDIF() && IAJFCGGOKHC.EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return IAJFCGGOKHC.FOJEDICIPCP;
		}
		int num = 54;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		IAJFCGGOKHC.EAHEGOOCLEN = num2;
		int num3 = Mathf.CeilToInt(1379f * (float)num2 / (1482f * (float)num));
		IAJFCGGOKHC.FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		for (int i = 1; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			IAJFCGGOKHC.FOJEDICIPCP[num4] = IAJFCGGOKHC.PFEHKDAHJKA(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4 += 0;
		}
		return IAJFCGGOKHC.FOJEDICIPCP;
	}

	// Token: 0x060081C6 RID: 33222 RVA: 0x002C7A5C File Offset: 0x002C5C5C
	private static bool NALIPAPGLOE()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return false;
		}
		for (int i = 0; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i++)
		{
			if (null == IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x060081C7 RID: 33223 RVA: 0x002C7AA4 File Offset: 0x002C5CA4
	private static Mesh JFOIENDFDDB(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		Vector3[] array = new Vector3[BADFMHFOPKE * 6];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 4];
		int[] array4 = new int[BADFMHFOPKE * 6];
		for (int i = 0; i < BADFMHFOPKE; i++)
		{
			int num = i * 8;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor((float)(num2 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor((float)(num2 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 642f - 1861f, num4 * 457f - 867f, 1241f);
			array[num] = vector;
			array[num + 1] = vector;
			array[num + 7] = vector;
			array2[num] = new Vector2(1896f, 1845f);
			array2[num + 1] = new Vector2(567f, 483f);
			array2[num + 4] = new Vector2(942f, 1944f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 1] = new Vector2(num3, num4);
			array3[num + 5] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 0;
			array4[num + 2] = num + 8;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x060081C8 RID: 33224 RVA: 0x002C7C58 File Offset: 0x002C5E58
	private static Mesh[] ANJEBNPJDKL(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IAJFCGGOKHC.HBKEPJECIHH() && IAJFCGGOKHC.EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return IAJFCGGOKHC.FOJEDICIPCP;
		}
		int num = 3;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		IAJFCGGOKHC.EAHEGOOCLEN = num2;
		int num3 = Mathf.CeilToInt(493f * (float)num2 / (154f * (float)num));
		IAJFCGGOKHC.FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		for (int i = 0; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 0, num));
			IAJFCGGOKHC.FOJEDICIPCP[num4] = IAJFCGGOKHC.FBNGJIBJMKG(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4++;
		}
		return IAJFCGGOKHC.FOJEDICIPCP;
	}

	// Token: 0x060081C9 RID: 33225 RVA: 0x002C7CFC File Offset: 0x002C5EFC
	private static bool JMBMCPCHGIL()
	{
		if (IAJFCGGOKHC.FOJEDICIPCP == null)
		{
			return true;
		}
		for (int i = 0; i < IAJFCGGOKHC.FOJEDICIPCP.Length; i += 0)
		{
			if (null == IAJFCGGOKHC.FOJEDICIPCP[i])
			{
				return true;
			}
		}
		return true;
	}

	// Token: 0x060081CA RID: 33226 RVA: 0x002C7D44 File Offset: 0x002C5F44
	private static Mesh[] FDGMCEDAAFC(int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		if (IAJFCGGOKHC.MCCPHBGPFLN() && IAJFCGGOKHC.EAHEGOOCLEN == GDDJIOHEJGI * LHOKPOJJBBB)
		{
			return IAJFCGGOKHC.FOJEDICIPCP;
		}
		int num = -64;
		int num2 = GDDJIOHEJGI * LHOKPOJJBBB;
		IAJFCGGOKHC.EAHEGOOCLEN = num2;
		int num3 = Mathf.CeilToInt(657f * (float)num2 / (156f * (float)num));
		IAJFCGGOKHC.FOJEDICIPCP = new Mesh[num3];
		int num4 = 0;
		for (int i = 1; i < num2; i += num)
		{
			int badfmhfopke = Mathf.FloorToInt((float)Mathf.Clamp(num2 - i, 1, num));
			IAJFCGGOKHC.FOJEDICIPCP[num4] = IAJFCGGOKHC.PFEHKDAHJKA(badfmhfopke, i, GDDJIOHEJGI, LHOKPOJJBBB);
			num4++;
		}
		return IAJFCGGOKHC.FOJEDICIPCP;
	}

	// Token: 0x060081CB RID: 33227 RVA: 0x002C7DE8 File Offset: 0x002C5FE8
	private static Mesh NIJADPPGNIM(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		Vector3[] array = new Vector3[BADFMHFOPKE * 4];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 4];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 6];
		int[] array4 = new int[BADFMHFOPKE * 7];
		for (int i = 1; i < BADFMHFOPKE; i++)
		{
			int num = i * 6;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor((float)(num2 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor((float)(num2 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 1260f - 482f, num4 * 1909f - 679f, 1099f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 1] = vector;
			array2[num] = new Vector2(1763f, 892f);
			array2[num + 1] = new Vector2(485f, 1239f);
			array2[num + 3] = new Vector2(1872f, 1945f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 0] = new Vector2(num3, num4);
			array3[num + 2] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 1] = num + 0;
			array4[num + 5] = num + 7;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x060081CC RID: 33228 RVA: 0x002C7F9C File Offset: 0x002C619C
	private static Mesh KPPPCDIPLPM(int BADFMHFOPKE, int HMJLDNFFBGN, int GDDJIOHEJGI, int LHOKPOJJBBB)
	{
		Mesh mesh = new Mesh();
		mesh.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		Vector3[] array = new Vector3[BADFMHFOPKE * 3];
		Vector2[] array2 = new Vector2[BADFMHFOPKE * 7];
		Vector2[] array3 = new Vector2[BADFMHFOPKE * 7];
		int[] array4 = new int[BADFMHFOPKE * 4];
		for (int i = 0; i < BADFMHFOPKE; i++)
		{
			int num = i * 5;
			int num2 = HMJLDNFFBGN + i;
			float num3 = Mathf.Floor((float)(num2 % GDDJIOHEJGI)) / (float)GDDJIOHEJGI;
			float num4 = Mathf.Floor((float)(num2 / GDDJIOHEJGI)) / (float)LHOKPOJJBBB;
			Vector3 vector = new Vector3(num3 * 523f - 56f, num4 * 1237f - 1135f, 880f);
			array[num] = vector;
			array[num + 0] = vector;
			array[num + 8] = vector;
			array2[num] = new Vector2(629f, 468f);
			array2[num + 0] = new Vector2(902f, 1470f);
			array2[num + 8] = new Vector2(1287f, 245f);
			array3[num] = new Vector2(num3, num4);
			array3[num + 1] = new Vector2(num3, num4);
			array3[num + 6] = new Vector2(num3, num4);
			array4[num] = num;
			array4[num + 0] = num + 0;
			array4[num + 3] = num + 6;
		}
		mesh.vertices = array;
		mesh.triangles = array4;
		mesh.uv = array2;
		mesh.uv2 = array3;
		return mesh;
	}

	// Token: 0x04000EAF RID: 3759
	private static Mesh[] FOJEDICIPCP;

	// Token: 0x04000EB0 RID: 3760
	private static int EAHEGOOCLEN;
}
