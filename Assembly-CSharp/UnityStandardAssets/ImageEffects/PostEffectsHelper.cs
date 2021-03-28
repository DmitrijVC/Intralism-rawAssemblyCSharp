using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001ED RID: 493
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	internal class PostEffectsHelper : MonoBehaviour
	{
		// Token: 0x06007F9F RID: 32671 RVA: 0x002A9DFC File Offset: 0x002A7FFC
		private static void BPHFCCIGJLM(float JJHJLEJMFID, float JINOMGPBACG, float NBLOBAIKBBB, float PKLDINBOIKI, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture(". Our prefix is ", HLBKCLPNHEB);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(8);
				float y;
				float y2;
				if (flag)
				{
					y = 252f;
					y2 = 1924f;
				}
				else
				{
					y = 641f;
					y2 = 1199f;
				}
				GL.TexCoord2(1262f, y);
				GL.Vertex3(JJHJLEJMFID, NBLOBAIKBBB, 1970f);
				GL.TexCoord2(1009f, y);
				GL.Vertex3(JINOMGPBACG, NBLOBAIKBBB, 1624f);
				GL.TexCoord2(122f, y2);
				GL.Vertex3(JINOMGPBACG, PKLDINBOIKI, 664f);
				GL.TexCoord2(1024f, y2);
				GL.Vertex3(JJHJLEJMFID, PKLDINBOIKI, 1103f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FA0 RID: 32672 RVA: 0x002A9EDA File Offset: 0x002A80DA
		private void JCCIKBBEMEB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			Debug.Log("_ChannelMixerGreen");
		}

		// Token: 0x06007FA1 RID: 32673 RVA: 0x002A9EE8 File Offset: 0x002A80E8
		private static void AGFFMLDGNKN(float IEKFIDNJJAM, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN, Camera HMFGLHIAIOM)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("_MainTex", HLBKCLPNHEB);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(HMFGLHIAIOM.projectionMatrix);
			float f = HMFGLHIAIOM.fieldOfView * 0.5f * 0.0174532924f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = HMFGLHIAIOM.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 1f / -num;
			float num5 = 1f / num;
			float num6 = 1f;
			num2 *= IEKFIDNJJAM * num6;
			num3 *= IEKFIDNJJAM * num6;
			num4 *= IEKFIDNJJAM * num6;
			num5 *= IEKFIDNJJAM * num6;
			float z = -IEKFIDNJJAM;
			for (int i = 0; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(7);
				float y;
				float y2;
				if (flag)
				{
					y = 1f;
					y2 = 0f;
				}
				else
				{
					y = 0f;
					y2 = 1f;
				}
				GL.TexCoord2(0f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(1f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FA2 RID: 32674 RVA: 0x002AA050 File Offset: 0x002A8250
		private static void AGKPFCPEIHF(float IEKFIDNJJAM, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN, Camera HMFGLHIAIOM)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("F3", HLBKCLPNHEB);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(HMFGLHIAIOM.projectionMatrix);
			float f = HMFGLHIAIOM.fieldOfView * 23f * 612f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = HMFGLHIAIOM.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 209f / -num;
			float num5 = 1025f / num;
			float num6 = 727f;
			num2 *= IEKFIDNJJAM * num6;
			num3 *= IEKFIDNJJAM * num6;
			num4 *= IEKFIDNJJAM * num6;
			num5 *= IEKFIDNJJAM * num6;
			float z = -IEKFIDNJJAM;
			for (int i = 1; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(5);
				float y;
				float y2;
				if (flag)
				{
					y = 623f;
					y2 = 1960f;
				}
				else
				{
					y = 1423f;
					y2 = 1389f;
				}
				GL.TexCoord2(914f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(588f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(489f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(1193f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FA3 RID: 32675 RVA: 0x002AA1B5 File Offset: 0x002A83B5
		private void NBHMOIGDDAD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			Debug.Log(" not exist");
		}

		// Token: 0x06007FA4 RID: 32676 RVA: 0x002AA1C4 File Offset: 0x002A83C4
		private static void LBAPKLFBIIP(float IEKFIDNJJAM, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN, Camera HMFGLHIAIOM)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("y", HLBKCLPNHEB);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(HMFGLHIAIOM.projectionMatrix);
			float f = HMFGLHIAIOM.fieldOfView * 1746f * 758f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = HMFGLHIAIOM.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 835f / -num;
			float num5 = 160f / num;
			float num6 = 235f;
			num2 *= IEKFIDNJJAM * num6;
			num3 *= IEKFIDNJJAM * num6;
			num4 *= IEKFIDNJJAM * num6;
			num5 *= IEKFIDNJJAM * num6;
			float z = -IEKFIDNJJAM;
			for (int i = 1; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(0);
				float y;
				float y2;
				if (flag)
				{
					y = 348f;
					y2 = 986f;
				}
				else
				{
					y = 376f;
					y2 = 1516f;
				}
				GL.TexCoord2(999f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(302f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(1597f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(150f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FA5 RID: 32677 RVA: 0x002AA329 File Offset: 0x002A8529
		private void KDFILLAPHIO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			Debug.Log("FileMenu");
		}

		// Token: 0x06007FA6 RID: 32678 RVA: 0x002AA338 File Offset: 0x002A8538
		private static void CANPAMIHANN(float IEKFIDNJJAM, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN, Camera HMFGLHIAIOM)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("_LumTex", HLBKCLPNHEB);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(HMFGLHIAIOM.projectionMatrix);
			float f = HMFGLHIAIOM.fieldOfView * 659f * 579f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = HMFGLHIAIOM.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 501f / -num;
			float num5 = 1795f / num;
			float num6 = 349f;
			num2 *= IEKFIDNJJAM * num6;
			num3 *= IEKFIDNJJAM * num6;
			num4 *= IEKFIDNJJAM * num6;
			num5 *= IEKFIDNJJAM * num6;
			float z = -IEKFIDNJJAM;
			for (int i = 1; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(6);
				float y;
				float y2;
				if (flag)
				{
					y = 245f;
					y2 = 1668f;
				}
				else
				{
					y = 1183f;
					y2 = 184f;
				}
				GL.TexCoord2(1964f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(1130f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(68f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(1033f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FA7 RID: 32679 RVA: 0x002AA49D File Offset: 0x002A869D
		private void GOBILPKKHFA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			Debug.Log("Mouse Y");
		}

		// Token: 0x06007FA8 RID: 32680 RVA: 0x002AA4AC File Offset: 0x002A86AC
		private static void DMHDNFKHALL(float IEKFIDNJJAM, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN, Camera HMFGLHIAIOM)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("JoinRandomRoom failed. In offline mode you still have to leave a room to enter another.", HLBKCLPNHEB);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(HMFGLHIAIOM.projectionMatrix);
			float f = HMFGLHIAIOM.fieldOfView * 468f * 1225f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = HMFGLHIAIOM.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 1911f / -num;
			float num5 = 419f / num;
			float num6 = 695f;
			num2 *= IEKFIDNJJAM * num6;
			num3 *= IEKFIDNJJAM * num6;
			num4 *= IEKFIDNJJAM * num6;
			num5 *= IEKFIDNJJAM * num6;
			float z = -IEKFIDNJJAM;
			for (int i = 0; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(8);
				float y;
				float y2;
				if (flag)
				{
					y = 252f;
					y2 = 1141f;
				}
				else
				{
					y = 1253f;
					y2 = 784f;
				}
				GL.TexCoord2(831f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(352f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(581f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(1291f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FA9 RID: 32681 RVA: 0x002AA614 File Offset: 0x002A8814
		private static void NNJJPJPJNCJ(float IEKFIDNJJAM, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN, Camera HMFGLHIAIOM)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("y", HLBKCLPNHEB);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(HMFGLHIAIOM.projectionMatrix);
			float f = HMFGLHIAIOM.fieldOfView * 1789f * 1694f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = HMFGLHIAIOM.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 463f / -num;
			float num5 = 623f / num;
			float num6 = 944f;
			num2 *= IEKFIDNJJAM * num6;
			num3 *= IEKFIDNJJAM * num6;
			num4 *= IEKFIDNJJAM * num6;
			num5 *= IEKFIDNJJAM * num6;
			float z = -IEKFIDNJJAM;
			for (int i = 0; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(0);
				float y;
				float y2;
				if (flag)
				{
					y = 122f;
					y2 = 1446f;
				}
				else
				{
					y = 1609f;
					y2 = 307f;
				}
				GL.TexCoord2(1289f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(710f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(779f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(1233f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FAA RID: 32682 RVA: 0x002AA77C File Offset: 0x002A897C
		private static void GMLMHBEKFEA(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 1; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1846f;
					y2 = 114f;
				}
				else
				{
					y = 1292f;
					y2 = 1704f;
				}
				float x = 1536f;
				float x2 = 1551f / ((float)FHNFPBCBODL.width * 518f);
				float y3 = 1448f;
				float y4 = 197f;
				GL.Begin(0);
				GL.TexCoord2(1336f, y);
				GL.Vertex3(x, y3, 618f);
				GL.TexCoord2(1035f, y);
				GL.Vertex3(x2, y3, 1596f);
				GL.TexCoord2(425f, y2);
				GL.Vertex3(x2, y4, 906f);
				GL.TexCoord2(3f, y2);
				GL.Vertex3(x, y4, 136f);
				x = 1352f - 60f / ((float)FHNFPBCBODL.width * 1710f);
				x2 = 891f;
				y3 = 784f;
				y4 = 741f;
				GL.TexCoord2(1579f, y);
				GL.Vertex3(x, y3, 591f);
				GL.TexCoord2(80f, y);
				GL.Vertex3(x2, y3, 1314f);
				GL.TexCoord2(577f, y2);
				GL.Vertex3(x2, y4, 1283f);
				GL.TexCoord2(1202f, y2);
				GL.Vertex3(x, y4, 1491f);
				x = 396f;
				x2 = 1725f;
				y3 = 1545f;
				y4 = 1147f / ((float)FHNFPBCBODL.height * 1860f);
				GL.TexCoord2(1995f, y);
				GL.Vertex3(x, y3, 1125f);
				GL.TexCoord2(1875f, y);
				GL.Vertex3(x2, y3, 1379f);
				GL.TexCoord2(60f, y2);
				GL.Vertex3(x2, y4, 1016f);
				GL.TexCoord2(312f, y2);
				GL.Vertex3(x, y4, 930f);
				x = 499f;
				x2 = 788f;
				y3 = 338f - 1385f / ((float)FHNFPBCBODL.height * 1818f);
				y4 = 1657f;
				GL.TexCoord2(1523f, y);
				GL.Vertex3(x, y3, 851f);
				GL.TexCoord2(350f, y);
				GL.Vertex3(x2, y3, 449f);
				GL.TexCoord2(355f, y2);
				GL.Vertex3(x2, y4, 1718f);
				GL.TexCoord2(1566f, y2);
				GL.Vertex3(x, y4, 159f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FAB RID: 32683 RVA: 0x002AAA1C File Offset: 0x002A8C1C
		private static void EHIPBDNEMJK(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1015f;
					y2 = 550f;
				}
				else
				{
					y = 369f;
					y2 = 163f;
				}
				float x = 1456f;
				float x2 = 1190f / ((float)FHNFPBCBODL.width * 1897f);
				float y3 = 715f;
				float y4 = 507f;
				GL.Begin(3);
				GL.TexCoord2(1359f, y);
				GL.Vertex3(x, y3, 160f);
				GL.TexCoord2(586f, y);
				GL.Vertex3(x2, y3, 1067f);
				GL.TexCoord2(598f, y2);
				GL.Vertex3(x2, y4, 266f);
				GL.TexCoord2(1638f, y2);
				GL.Vertex3(x, y4, 1867f);
				x = 718f - 222f / ((float)FHNFPBCBODL.width * 1453f);
				x2 = 1007f;
				y3 = 1843f;
				y4 = 813f;
				GL.TexCoord2(1186f, y);
				GL.Vertex3(x, y3, 1887f);
				GL.TexCoord2(1625f, y);
				GL.Vertex3(x2, y3, 521f);
				GL.TexCoord2(466f, y2);
				GL.Vertex3(x2, y4, 1357f);
				GL.TexCoord2(819f, y2);
				GL.Vertex3(x, y4, 719f);
				x = 1126f;
				x2 = 218f;
				y3 = 1548f;
				y4 = 1989f / ((float)FHNFPBCBODL.height * 1159f);
				GL.TexCoord2(1691f, y);
				GL.Vertex3(x, y3, 236f);
				GL.TexCoord2(1893f, y);
				GL.Vertex3(x2, y3, 597f);
				GL.TexCoord2(1378f, y2);
				GL.Vertex3(x2, y4, 1497f);
				GL.TexCoord2(126f, y2);
				GL.Vertex3(x, y4, 1532f);
				x = 1368f;
				x2 = 1673f;
				y3 = 186f - 1116f / ((float)FHNFPBCBODL.height * 1709f);
				y4 = 525f;
				GL.TexCoord2(766f, y);
				GL.Vertex3(x, y3, 832f);
				GL.TexCoord2(979f, y);
				GL.Vertex3(x2, y3, 1542f);
				GL.TexCoord2(296f, y2);
				GL.Vertex3(x2, y4, 1424f);
				GL.TexCoord2(151f, y2);
				GL.Vertex3(x, y4, 614f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FAC RID: 32684 RVA: 0x002AACBC File Offset: 0x002A8EBC
		private static void CFJDFCDFAJN(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 1; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1484f;
					y2 = 44f;
				}
				else
				{
					y = 1509f;
					y2 = 1935f;
				}
				float x = 303f;
				float x2 = 1426f / ((float)FHNFPBCBODL.width * 322f);
				float y3 = 1406f;
				float y4 = 1732f;
				GL.Begin(8);
				GL.TexCoord2(97f, y);
				GL.Vertex3(x, y3, 719f);
				GL.TexCoord2(894f, y);
				GL.Vertex3(x2, y3, 649f);
				GL.TexCoord2(925f, y2);
				GL.Vertex3(x2, y4, 1083f);
				GL.TexCoord2(680f, y2);
				GL.Vertex3(x, y4, 1525f);
				x = 123f - 1717f / ((float)FHNFPBCBODL.width * 1223f);
				x2 = 1102f;
				y3 = 1317f;
				y4 = 1721f;
				GL.TexCoord2(285f, y);
				GL.Vertex3(x, y3, 1142f);
				GL.TexCoord2(134f, y);
				GL.Vertex3(x2, y3, 658f);
				GL.TexCoord2(1586f, y2);
				GL.Vertex3(x2, y4, 1416f);
				GL.TexCoord2(231f, y2);
				GL.Vertex3(x, y4, 1788f);
				x = 1391f;
				x2 = 568f;
				y3 = 940f;
				y4 = 1246f / ((float)FHNFPBCBODL.height * 1224f);
				GL.TexCoord2(165f, y);
				GL.Vertex3(x, y3, 997f);
				GL.TexCoord2(383f, y);
				GL.Vertex3(x2, y3, 1081f);
				GL.TexCoord2(92f, y2);
				GL.Vertex3(x2, y4, 466f);
				GL.TexCoord2(870f, y2);
				GL.Vertex3(x, y4, 36f);
				x = 715f;
				x2 = 58f;
				y3 = 1953f - 235f / ((float)FHNFPBCBODL.height * 895f);
				y4 = 1093f;
				GL.TexCoord2(1262f, y);
				GL.Vertex3(x, y3, 1679f);
				GL.TexCoord2(1928f, y);
				GL.Vertex3(x2, y3, 806f);
				GL.TexCoord2(1696f, y2);
				GL.Vertex3(x2, y4, 652f);
				GL.TexCoord2(941f, y2);
				GL.Vertex3(x, y4, 995f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FAD RID: 32685 RVA: 0x002AAF5C File Offset: 0x002A915C
		private static void MBENPNILLGM(float IEKFIDNJJAM, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN, Camera HMFGLHIAIOM)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("_Value3", HLBKCLPNHEB);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(HMFGLHIAIOM.projectionMatrix);
			float f = HMFGLHIAIOM.fieldOfView * 325f * 88f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = HMFGLHIAIOM.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 1575f / -num;
			float num5 = 1588f / num;
			float num6 = 1748f;
			num2 *= IEKFIDNJJAM * num6;
			num3 *= IEKFIDNJJAM * num6;
			num4 *= IEKFIDNJJAM * num6;
			num5 *= IEKFIDNJJAM * num6;
			float z = -IEKFIDNJJAM;
			for (int i = 0; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(8);
				float y;
				float y2;
				if (flag)
				{
					y = 39f;
					y2 = 599f;
				}
				else
				{
					y = 252f;
					y2 = 821f;
				}
				GL.TexCoord2(1897f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(363f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(833f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(266f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FAE RID: 32686 RVA: 0x002AB0C1 File Offset: 0x002A92C1
		private void CDCLDBFMKOG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			Debug.Log("CameraFilterPack_Blizzard1");
		}

		// Token: 0x06007FAF RID: 32687 RVA: 0x002AB0D0 File Offset: 0x002A92D0
		private static void BONIHJILLEK(float JJHJLEJMFID, float JINOMGPBACG, float NBLOBAIKBBB, float PKLDINBOIKI, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("#close", HLBKCLPNHEB);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 1; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(6);
				float y;
				float y2;
				if (flag)
				{
					y = 1529f;
					y2 = 850f;
				}
				else
				{
					y = 1784f;
					y2 = 1372f;
				}
				GL.TexCoord2(1838f, y);
				GL.Vertex3(JJHJLEJMFID, NBLOBAIKBBB, 1021f);
				GL.TexCoord2(560f, y);
				GL.Vertex3(JINOMGPBACG, NBLOBAIKBBB, 1795f);
				GL.TexCoord2(1683f, y2);
				GL.Vertex3(JINOMGPBACG, PKLDINBOIKI, 1723f);
				GL.TexCoord2(374f, y2);
				GL.Vertex3(JJHJLEJMFID, PKLDINBOIKI, 1214f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FB0 RID: 32688 RVA: 0x002AB1B0 File Offset: 0x002A93B0
		private static void HKCEPBMNONM(float IEKFIDNJJAM, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN, Camera HMFGLHIAIOM)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("#combo", HLBKCLPNHEB);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(HMFGLHIAIOM.projectionMatrix);
			float f = HMFGLHIAIOM.fieldOfView * 170f * 315f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = HMFGLHIAIOM.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 372f / -num;
			float num5 = 741f / num;
			float num6 = 306f;
			num2 *= IEKFIDNJJAM * num6;
			num3 *= IEKFIDNJJAM * num6;
			num4 *= IEKFIDNJJAM * num6;
			num5 *= IEKFIDNJJAM * num6;
			float z = -IEKFIDNJJAM;
			for (int i = 0; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(5);
				float y;
				float y2;
				if (flag)
				{
					y = 201f;
					y2 = 438f;
				}
				else
				{
					y = 1995f;
					y2 = 684f;
				}
				GL.TexCoord2(1922f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(547f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(717f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(1434f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FB1 RID: 32689 RVA: 0x002AB315 File Offset: 0x002A9515
		private void LDIOANOMHMO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			Debug.Log("_Distortion");
		}

		// Token: 0x06007FB2 RID: 32690 RVA: 0x002AB324 File Offset: 0x002A9524
		private static void DFLGGNPMJOK(float JJHJLEJMFID, float JINOMGPBACG, float NBLOBAIKBBB, float PKLDINBOIKI, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("STICKLHOR", HLBKCLPNHEB);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(0);
				float y;
				float y2;
				if (flag)
				{
					y = 1361f;
					y2 = 810f;
				}
				else
				{
					y = 1476f;
					y2 = 1119f;
				}
				GL.TexCoord2(1582f, y);
				GL.Vertex3(JJHJLEJMFID, NBLOBAIKBBB, 726f);
				GL.TexCoord2(671f, y);
				GL.Vertex3(JINOMGPBACG, NBLOBAIKBBB, 1710f);
				GL.TexCoord2(1634f, y2);
				GL.Vertex3(JINOMGPBACG, PKLDINBOIKI, 728f);
				GL.TexCoord2(222f, y2);
				GL.Vertex3(JJHJLEJMFID, PKLDINBOIKI, 591f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FB3 RID: 32691 RVA: 0x002AB404 File Offset: 0x002A9604
		private static void NHGPNDEGKNF(float JJHJLEJMFID, float JINOMGPBACG, float NBLOBAIKBBB, float PKLDINBOIKI, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("Joystick1Button9", HLBKCLPNHEB);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(0);
				float y;
				float y2;
				if (flag)
				{
					y = 793f;
					y2 = 1350f;
				}
				else
				{
					y = 1432f;
					y2 = 1816f;
				}
				GL.TexCoord2(1936f, y);
				GL.Vertex3(JJHJLEJMFID, NBLOBAIKBBB, 1660f);
				GL.TexCoord2(1208f, y);
				GL.Vertex3(JINOMGPBACG, NBLOBAIKBBB, 275f);
				GL.TexCoord2(718f, y2);
				GL.Vertex3(JINOMGPBACG, PKLDINBOIKI, 311f);
				GL.TexCoord2(1860f, y2);
				GL.Vertex3(JJHJLEJMFID, PKLDINBOIKI, 1381f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FB4 RID: 32692 RVA: 0x002AB4E4 File Offset: 0x002A96E4
		private static void OAOKGAGCHPE(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 1; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1474f;
					y2 = 390f;
				}
				else
				{
					y = 1114f;
					y2 = 1111f;
				}
				float x = 1858f;
				float x2 = 1543f / ((float)FHNFPBCBODL.width * 468f);
				float y3 = 1372f;
				float y4 = 786f;
				GL.Begin(3);
				GL.TexCoord2(1151f, y);
				GL.Vertex3(x, y3, 586f);
				GL.TexCoord2(1302f, y);
				GL.Vertex3(x2, y3, 448f);
				GL.TexCoord2(110f, y2);
				GL.Vertex3(x2, y4, 1000f);
				GL.TexCoord2(979f, y2);
				GL.Vertex3(x, y4, 1515f);
				x = 1534f - 986f / ((float)FHNFPBCBODL.width * 1409f);
				x2 = 237f;
				y3 = 1816f;
				y4 = 478f;
				GL.TexCoord2(1084f, y);
				GL.Vertex3(x, y3, 1101f);
				GL.TexCoord2(1761f, y);
				GL.Vertex3(x2, y3, 1799f);
				GL.TexCoord2(549f, y2);
				GL.Vertex3(x2, y4, 320f);
				GL.TexCoord2(418f, y2);
				GL.Vertex3(x, y4, 393f);
				x = 1425f;
				x2 = 705f;
				y3 = 1373f;
				y4 = 1019f / ((float)FHNFPBCBODL.height * 114f);
				GL.TexCoord2(834f, y);
				GL.Vertex3(x, y3, 1720f);
				GL.TexCoord2(940f, y);
				GL.Vertex3(x2, y3, 593f);
				GL.TexCoord2(1858f, y2);
				GL.Vertex3(x2, y4, 882f);
				GL.TexCoord2(1765f, y2);
				GL.Vertex3(x, y4, 896f);
				x = 1592f;
				x2 = 1551f;
				y3 = 781f - 1383f / ((float)FHNFPBCBODL.height * 197f);
				y4 = 368f;
				GL.TexCoord2(373f, y);
				GL.Vertex3(x, y3, 640f);
				GL.TexCoord2(1390f, y);
				GL.Vertex3(x2, y3, 1572f);
				GL.TexCoord2(1080f, y2);
				GL.Vertex3(x2, y4, 964f);
				GL.TexCoord2(409f, y2);
				GL.Vertex3(x, y4, 1738f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FB5 RID: 32693 RVA: 0x002AB784 File Offset: 0x002A9984
		private static void CKHBGCGEEDB(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1900f;
					y2 = 1599f;
				}
				else
				{
					y = 1150f;
					y2 = 713f;
				}
				float x = 732f;
				float x2 = 317f / ((float)FHNFPBCBODL.width * 610f);
				float y3 = 1285f;
				float y4 = 59f;
				GL.Begin(0);
				GL.TexCoord2(1000f, y);
				GL.Vertex3(x, y3, 604f);
				GL.TexCoord2(1619f, y);
				GL.Vertex3(x2, y3, 1991f);
				GL.TexCoord2(559f, y2);
				GL.Vertex3(x2, y4, 1201f);
				GL.TexCoord2(1015f, y2);
				GL.Vertex3(x, y4, 1776f);
				x = 536f - 917f / ((float)FHNFPBCBODL.width * 356f);
				x2 = 1689f;
				y3 = 1641f;
				y4 = 822f;
				GL.TexCoord2(723f, y);
				GL.Vertex3(x, y3, 360f);
				GL.TexCoord2(273f, y);
				GL.Vertex3(x2, y3, 675f);
				GL.TexCoord2(182f, y2);
				GL.Vertex3(x2, y4, 271f);
				GL.TexCoord2(1878f, y2);
				GL.Vertex3(x, y4, 1907f);
				x = 1602f;
				x2 = 463f;
				y3 = 214f;
				y4 = 1469f / ((float)FHNFPBCBODL.height * 1759f);
				GL.TexCoord2(50f, y);
				GL.Vertex3(x, y3, 1095f);
				GL.TexCoord2(1734f, y);
				GL.Vertex3(x2, y3, 1976f);
				GL.TexCoord2(1425f, y2);
				GL.Vertex3(x2, y4, 1016f);
				GL.TexCoord2(1871f, y2);
				GL.Vertex3(x, y4, 1000f);
				x = 664f;
				x2 = 1161f;
				y3 = 416f - 1524f / ((float)FHNFPBCBODL.height * 1715f);
				y4 = 1019f;
				GL.TexCoord2(1992f, y);
				GL.Vertex3(x, y3, 855f);
				GL.TexCoord2(1375f, y);
				GL.Vertex3(x2, y3, 527f);
				GL.TexCoord2(1992f, y2);
				GL.Vertex3(x2, y4, 1996f);
				GL.TexCoord2(686f, y2);
				GL.Vertex3(x, y4, 499f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FB6 RID: 32694 RVA: 0x002ABA24 File Offset: 0x002A9C24
		private void NJFDLOBJCCF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			Debug.Log("RanksButton");
		}

		// Token: 0x06007FB7 RID: 32695 RVA: 0x002ABA30 File Offset: 0x002A9C30
		private static void IJAAOOGCKNL(float JJHJLEJMFID, float JINOMGPBACG, float NBLOBAIKBBB, float PKLDINBOIKI, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("achievements.21.completed.", HLBKCLPNHEB);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(0);
				float y;
				float y2;
				if (flag)
				{
					y = 1695f;
					y2 = 1455f;
				}
				else
				{
					y = 594f;
					y2 = 959f;
				}
				GL.TexCoord2(1201f, y);
				GL.Vertex3(JJHJLEJMFID, NBLOBAIKBBB, 1040f);
				GL.TexCoord2(435f, y);
				GL.Vertex3(JINOMGPBACG, NBLOBAIKBBB, 175f);
				GL.TexCoord2(1338f, y2);
				GL.Vertex3(JINOMGPBACG, PKLDINBOIKI, 1432f);
				GL.TexCoord2(131f, y2);
				GL.Vertex3(JJHJLEJMFID, PKLDINBOIKI, 1531f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FB8 RID: 32696 RVA: 0x002ABB10 File Offset: 0x002A9D10
		private static void GNLJGMMFIFH(float JJHJLEJMFID, float JINOMGPBACG, float NBLOBAIKBBB, float PKLDINBOIKI, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("Command not found!", HLBKCLPNHEB);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(2);
				float y;
				float y2;
				if (flag)
				{
					y = 298f;
					y2 = 1344f;
				}
				else
				{
					y = 1188f;
					y2 = 1316f;
				}
				GL.TexCoord2(435f, y);
				GL.Vertex3(JJHJLEJMFID, NBLOBAIKBBB, 1364f);
				GL.TexCoord2(1180f, y);
				GL.Vertex3(JINOMGPBACG, NBLOBAIKBBB, 1833f);
				GL.TexCoord2(311f, y2);
				GL.Vertex3(JINOMGPBACG, PKLDINBOIKI, 884f);
				GL.TexCoord2(1220f, y2);
				GL.Vertex3(JJHJLEJMFID, PKLDINBOIKI, 1533f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FB9 RID: 32697 RVA: 0x002ABBEE File Offset: 0x002A9DEE
		private void JKAKHLNPNNP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			Debug.Log("\n");
		}

		// Token: 0x06007FBA RID: 32698 RVA: 0x002ABBFA File Offset: 0x002A9DFA
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			Debug.Log("OnRenderImage in Helper called ...");
		}

		// Token: 0x06007FBB RID: 32699 RVA: 0x002ABC08 File Offset: 0x002A9E08
		private static void MCLBIMAHAJP(float JJHJLEJMFID, float JINOMGPBACG, float NBLOBAIKBBB, float PKLDINBOIKI, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("LeaderboardsButton", HLBKCLPNHEB);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(3);
				float y;
				float y2;
				if (flag)
				{
					y = 1810f;
					y2 = 1943f;
				}
				else
				{
					y = 873f;
					y2 = 1416f;
				}
				GL.TexCoord2(531f, y);
				GL.Vertex3(JJHJLEJMFID, NBLOBAIKBBB, 721f);
				GL.TexCoord2(1728f, y);
				GL.Vertex3(JINOMGPBACG, NBLOBAIKBBB, 682f);
				GL.TexCoord2(1697f, y2);
				GL.Vertex3(JINOMGPBACG, PKLDINBOIKI, 174f);
				GL.TexCoord2(504f, y2);
				GL.Vertex3(JJHJLEJMFID, PKLDINBOIKI, 36f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FBC RID: 32700 RVA: 0x002ABCE8 File Offset: 0x002A9EE8
		private static void FMGDKPJJACF(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 1; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1258f;
					y2 = 894f;
				}
				else
				{
					y = 1730f;
					y2 = 1026f;
				}
				float x = 790f;
				float x2 = 1005f / ((float)FHNFPBCBODL.width * 1083f);
				float y3 = 1597f;
				float y4 = 1576f;
				GL.Begin(3);
				GL.TexCoord2(1241f, y);
				GL.Vertex3(x, y3, 603f);
				GL.TexCoord2(528f, y);
				GL.Vertex3(x2, y3, 1635f);
				GL.TexCoord2(1464f, y2);
				GL.Vertex3(x2, y4, 960f);
				GL.TexCoord2(1752f, y2);
				GL.Vertex3(x, y4, 1204f);
				x = 726f - 281f / ((float)FHNFPBCBODL.width * 525f);
				x2 = 1003f;
				y3 = 55f;
				y4 = 754f;
				GL.TexCoord2(1940f, y);
				GL.Vertex3(x, y3, 367f);
				GL.TexCoord2(239f, y);
				GL.Vertex3(x2, y3, 1983f);
				GL.TexCoord2(833f, y2);
				GL.Vertex3(x2, y4, 1116f);
				GL.TexCoord2(1581f, y2);
				GL.Vertex3(x, y4, 1427f);
				x = 1527f;
				x2 = 469f;
				y3 = 558f;
				y4 = 1492f / ((float)FHNFPBCBODL.height * 876f);
				GL.TexCoord2(910f, y);
				GL.Vertex3(x, y3, 407f);
				GL.TexCoord2(1864f, y);
				GL.Vertex3(x2, y3, 886f);
				GL.TexCoord2(1766f, y2);
				GL.Vertex3(x2, y4, 212f);
				GL.TexCoord2(1414f, y2);
				GL.Vertex3(x, y4, 524f);
				x = 1606f;
				x2 = 1416f;
				y3 = 1283f - 1831f / ((float)FHNFPBCBODL.height * 1940f);
				y4 = 1573f;
				GL.TexCoord2(1374f, y);
				GL.Vertex3(x, y3, 416f);
				GL.TexCoord2(752f, y);
				GL.Vertex3(x2, y3, 305f);
				GL.TexCoord2(1830f, y2);
				GL.Vertex3(x2, y4, 1367f);
				GL.TexCoord2(1260f, y2);
				GL.Vertex3(x, y4, 467f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FBD RID: 32701 RVA: 0x002ABF88 File Offset: 0x002AA188
		private static void CDBMCHELIKK(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 1; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1955f;
					y2 = 1131f;
				}
				else
				{
					y = 324f;
					y2 = 757f;
				}
				float x = 1651f;
				float x2 = 775f / ((float)FHNFPBCBODL.width * 1983f);
				float y3 = 301f;
				float y4 = 991f;
				GL.Begin(7);
				GL.TexCoord2(1454f, y);
				GL.Vertex3(x, y3, 1694f);
				GL.TexCoord2(519f, y);
				GL.Vertex3(x2, y3, 810f);
				GL.TexCoord2(1851f, y2);
				GL.Vertex3(x2, y4, 1806f);
				GL.TexCoord2(1729f, y2);
				GL.Vertex3(x, y4, 1038f);
				x = 358f - 1095f / ((float)FHNFPBCBODL.width * 509f);
				x2 = 1528f;
				y3 = 1540f;
				y4 = 1508f;
				GL.TexCoord2(198f, y);
				GL.Vertex3(x, y3, 1059f);
				GL.TexCoord2(917f, y);
				GL.Vertex3(x2, y3, 1040f);
				GL.TexCoord2(325f, y2);
				GL.Vertex3(x2, y4, 1431f);
				GL.TexCoord2(197f, y2);
				GL.Vertex3(x, y4, 835f);
				x = 853f;
				x2 = 1220f;
				y3 = 229f;
				y4 = 14f / ((float)FHNFPBCBODL.height * 248f);
				GL.TexCoord2(1785f, y);
				GL.Vertex3(x, y3, 1340f);
				GL.TexCoord2(646f, y);
				GL.Vertex3(x2, y3, 1590f);
				GL.TexCoord2(1685f, y2);
				GL.Vertex3(x2, y4, 906f);
				GL.TexCoord2(1327f, y2);
				GL.Vertex3(x, y4, 1929f);
				x = 1687f;
				x2 = 105f;
				y3 = 1303f - 1001f / ((float)FHNFPBCBODL.height * 675f);
				y4 = 1005f;
				GL.TexCoord2(1397f, y);
				GL.Vertex3(x, y3, 1174f);
				GL.TexCoord2(1101f, y);
				GL.Vertex3(x2, y3, 1133f);
				GL.TexCoord2(1119f, y2);
				GL.Vertex3(x2, y4, 278f);
				GL.TexCoord2(1104f, y2);
				GL.Vertex3(x, y4, 528f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FBE RID: 32702 RVA: 0x002AC228 File Offset: 0x002AA428
		private static void KFEPCKLJBCB(float JJHJLEJMFID, float JINOMGPBACG, float NBLOBAIKBBB, float PKLDINBOIKI, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("You did not select a Hosting Type in your PhotonServerSettings. Please set it up or don't use ConnectUsingSettings().", HLBKCLPNHEB);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(1);
				float y;
				float y2;
				if (flag)
				{
					y = 1393f;
					y2 = 1774f;
				}
				else
				{
					y = 354f;
					y2 = 64f;
				}
				GL.TexCoord2(1144f, y);
				GL.Vertex3(JJHJLEJMFID, NBLOBAIKBBB, 478f);
				GL.TexCoord2(1458f, y);
				GL.Vertex3(JINOMGPBACG, NBLOBAIKBBB, 1470f);
				GL.TexCoord2(465f, y2);
				GL.Vertex3(JINOMGPBACG, PKLDINBOIKI, 547f);
				GL.TexCoord2(897f, y2);
				GL.Vertex3(JJHJLEJMFID, PKLDINBOIKI, 605f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FBF RID: 32703 RVA: 0x002AC308 File Offset: 0x002AA508
		private static void PJBBLCAOJPE(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1661f;
					y2 = 1101f;
				}
				else
				{
					y = 841f;
					y2 = 347f;
				}
				float x = 912f;
				float x2 = 1667f / ((float)FHNFPBCBODL.width * 1535f);
				float y3 = 1433f;
				float y4 = 338f;
				GL.Begin(2);
				GL.TexCoord2(1467f, y);
				GL.Vertex3(x, y3, 1423f);
				GL.TexCoord2(1686f, y);
				GL.Vertex3(x2, y3, 91f);
				GL.TexCoord2(882f, y2);
				GL.Vertex3(x2, y4, 1241f);
				GL.TexCoord2(442f, y2);
				GL.Vertex3(x, y4, 209f);
				x = 762f - 428f / ((float)FHNFPBCBODL.width * 1157f);
				x2 = 659f;
				y3 = 1431f;
				y4 = 1728f;
				GL.TexCoord2(749f, y);
				GL.Vertex3(x, y3, 368f);
				GL.TexCoord2(451f, y);
				GL.Vertex3(x2, y3, 1436f);
				GL.TexCoord2(486f, y2);
				GL.Vertex3(x2, y4, 1145f);
				GL.TexCoord2(584f, y2);
				GL.Vertex3(x, y4, 132f);
				x = 1617f;
				x2 = 1468f;
				y3 = 1361f;
				y4 = 610f / ((float)FHNFPBCBODL.height * 1810f);
				GL.TexCoord2(22f, y);
				GL.Vertex3(x, y3, 907f);
				GL.TexCoord2(1657f, y);
				GL.Vertex3(x2, y3, 1781f);
				GL.TexCoord2(1657f, y2);
				GL.Vertex3(x2, y4, 1480f);
				GL.TexCoord2(812f, y2);
				GL.Vertex3(x, y4, 674f);
				x = 351f;
				x2 = 519f;
				y3 = 714f - 1527f / ((float)FHNFPBCBODL.height * 1065f);
				y4 = 253f;
				GL.TexCoord2(652f, y);
				GL.Vertex3(x, y3, 623f);
				GL.TexCoord2(1284f, y);
				GL.Vertex3(x2, y3, 1755f);
				GL.TexCoord2(1528f, y2);
				GL.Vertex3(x2, y4, 1483f);
				GL.TexCoord2(1373f, y2);
				GL.Vertex3(x, y4, 986f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FC0 RID: 32704 RVA: 0x002AC5A8 File Offset: 0x002AA7A8
		private static void PFPBELFMCLM(float JJHJLEJMFID, float JINOMGPBACG, float NBLOBAIKBBB, float PKLDINBOIKI, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("Can't find key ", HLBKCLPNHEB);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(6);
				float y;
				float y2;
				if (flag)
				{
					y = 1297f;
					y2 = 1461f;
				}
				else
				{
					y = 779f;
					y2 = 576f;
				}
				GL.TexCoord2(273f, y);
				GL.Vertex3(JJHJLEJMFID, NBLOBAIKBBB, 162f);
				GL.TexCoord2(1042f, y);
				GL.Vertex3(JINOMGPBACG, NBLOBAIKBBB, 827f);
				GL.TexCoord2(292f, y2);
				GL.Vertex3(JINOMGPBACG, PKLDINBOIKI, 1418f);
				GL.TexCoord2(1421f, y2);
				GL.Vertex3(JJHJLEJMFID, PKLDINBOIKI, 545f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FC1 RID: 32705 RVA: 0x002AC686 File Offset: 0x002AA886
		private void AFCICEAOBHL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			Debug.Log("_ScreenResolution");
		}

		// Token: 0x06007FC2 RID: 32706 RVA: 0x002AC694 File Offset: 0x002AA894
		private static void KHFPEJOAEBG(float IEKFIDNJJAM, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN, Camera HMFGLHIAIOM)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("_TimeX", HLBKCLPNHEB);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(HMFGLHIAIOM.projectionMatrix);
			float f = HMFGLHIAIOM.fieldOfView * 188f * 1591f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = HMFGLHIAIOM.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 679f / -num;
			float num5 = 1168f / num;
			float num6 = 74f;
			num2 *= IEKFIDNJJAM * num6;
			num3 *= IEKFIDNJJAM * num6;
			num4 *= IEKFIDNJJAM * num6;
			num5 *= IEKFIDNJJAM * num6;
			float z = -IEKFIDNJJAM;
			for (int i = 0; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(1);
				float y;
				float y2;
				if (flag)
				{
					y = 1545f;
					y2 = 1137f;
				}
				else
				{
					y = 1328f;
					y2 = 1199f;
				}
				GL.TexCoord2(1757f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(1715f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(1309f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(1482f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FC3 RID: 32707 RVA: 0x002AC7FC File Offset: 0x002AA9FC
		private static void AKBCICELHGP(float IEKFIDNJJAM, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN, Camera HMFGLHIAIOM)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("GlassColor", HLBKCLPNHEB);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(HMFGLHIAIOM.projectionMatrix);
			float f = HMFGLHIAIOM.fieldOfView * 1023f * 385f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = HMFGLHIAIOM.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 217f / -num;
			float num5 = 1917f / num;
			float num6 = 29f;
			num2 *= IEKFIDNJJAM * num6;
			num3 *= IEKFIDNJJAM * num6;
			num4 *= IEKFIDNJJAM * num6;
			num5 *= IEKFIDNJJAM * num6;
			float z = -IEKFIDNJJAM;
			for (int i = 0; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(1);
				float y;
				float y2;
				if (flag)
				{
					y = 1589f;
					y2 = 1881f;
				}
				else
				{
					y = 70f;
					y2 = 1860f;
				}
				GL.TexCoord2(1026f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(70f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(93f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(1403f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FC4 RID: 32708 RVA: 0x002AC964 File Offset: 0x002AAB64
		private static void NHFMHCDPNHJ(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 1; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 511f;
					y2 = 687f;
				}
				else
				{
					y = 904f;
					y2 = 1999f;
				}
				float x = 1873f;
				float x2 = 508f / ((float)FHNFPBCBODL.width * 1242f);
				float y3 = 460f;
				float y4 = 1226f;
				GL.Begin(4);
				GL.TexCoord2(904f, y);
				GL.Vertex3(x, y3, 1176f);
				GL.TexCoord2(946f, y);
				GL.Vertex3(x2, y3, 1164f);
				GL.TexCoord2(1649f, y2);
				GL.Vertex3(x2, y4, 1222f);
				GL.TexCoord2(1236f, y2);
				GL.Vertex3(x, y4, 818f);
				x = 1334f - 1666f / ((float)FHNFPBCBODL.width * 928f);
				x2 = 1923f;
				y3 = 1893f;
				y4 = 1192f;
				GL.TexCoord2(886f, y);
				GL.Vertex3(x, y3, 486f);
				GL.TexCoord2(196f, y);
				GL.Vertex3(x2, y3, 1133f);
				GL.TexCoord2(1246f, y2);
				GL.Vertex3(x2, y4, 1769f);
				GL.TexCoord2(1861f, y2);
				GL.Vertex3(x, y4, 68f);
				x = 410f;
				x2 = 1470f;
				y3 = 1293f;
				y4 = 1784f / ((float)FHNFPBCBODL.height * 1398f);
				GL.TexCoord2(812f, y);
				GL.Vertex3(x, y3, 120f);
				GL.TexCoord2(1565f, y);
				GL.Vertex3(x2, y3, 1955f);
				GL.TexCoord2(62f, y2);
				GL.Vertex3(x2, y4, 829f);
				GL.TexCoord2(34f, y2);
				GL.Vertex3(x, y4, 1497f);
				x = 113f;
				x2 = 1789f;
				y3 = 898f - 224f / ((float)FHNFPBCBODL.height * 1866f);
				y4 = 242f;
				GL.TexCoord2(1241f, y);
				GL.Vertex3(x, y3, 1831f);
				GL.TexCoord2(1011f, y);
				GL.Vertex3(x2, y3, 1950f);
				GL.TexCoord2(443f, y2);
				GL.Vertex3(x2, y4, 277f);
				GL.TexCoord2(1434f, y2);
				GL.Vertex3(x, y4, 705f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FC5 RID: 32709 RVA: 0x002ACC04 File Offset: 0x002AAE04
		private static void MDFFCKEIODG(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1213f;
					y2 = 1307f;
				}
				else
				{
					y = 1016f;
					y2 = 1350f;
				}
				float x = 907f;
				float x2 = 1325f / ((float)FHNFPBCBODL.width * 425f);
				float y3 = 800f;
				float y4 = 1693f;
				GL.Begin(7);
				GL.TexCoord2(9f, y);
				GL.Vertex3(x, y3, 1205f);
				GL.TexCoord2(61f, y);
				GL.Vertex3(x2, y3, 1700f);
				GL.TexCoord2(189f, y2);
				GL.Vertex3(x2, y4, 189f);
				GL.TexCoord2(1107f, y2);
				GL.Vertex3(x, y4, 1703f);
				x = 1658f - 1320f / ((float)FHNFPBCBODL.width * 1300f);
				x2 = 619f;
				y3 = 968f;
				y4 = 1432f;
				GL.TexCoord2(1144f, y);
				GL.Vertex3(x, y3, 544f);
				GL.TexCoord2(1368f, y);
				GL.Vertex3(x2, y3, 1005f);
				GL.TexCoord2(1185f, y2);
				GL.Vertex3(x2, y4, 384f);
				GL.TexCoord2(639f, y2);
				GL.Vertex3(x, y4, 424f);
				x = 1003f;
				x2 = 986f;
				y3 = 95f;
				y4 = 482f / ((float)FHNFPBCBODL.height * 1571f);
				GL.TexCoord2(1075f, y);
				GL.Vertex3(x, y3, 51f);
				GL.TexCoord2(552f, y);
				GL.Vertex3(x2, y3, 1375f);
				GL.TexCoord2(1625f, y2);
				GL.Vertex3(x2, y4, 569f);
				GL.TexCoord2(749f, y2);
				GL.Vertex3(x, y4, 529f);
				x = 1998f;
				x2 = 598f;
				y3 = 1090f - 1520f / ((float)FHNFPBCBODL.height * 475f);
				y4 = 815f;
				GL.TexCoord2(489f, y);
				GL.Vertex3(x, y3, 270f);
				GL.TexCoord2(1723f, y);
				GL.Vertex3(x2, y3, 265f);
				GL.TexCoord2(788f, y2);
				GL.Vertex3(x2, y4, 304f);
				GL.TexCoord2(29f, y2);
				GL.Vertex3(x, y4, 1255f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FC6 RID: 32710 RVA: 0x002ACEA4 File Offset: 0x002AB0A4
		private static void NBLMPDOACKB(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1f;
					y2 = 0f;
				}
				else
				{
					y = 0f;
					y2 = 1f;
				}
				float x = 0f;
				float x2 = 1f / ((float)FHNFPBCBODL.width * 1f);
				float y3 = 0f;
				float y4 = 1f;
				GL.Begin(7);
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				x = 1f - 1f / ((float)FHNFPBCBODL.width * 1f);
				x2 = 1f;
				y3 = 0f;
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				x = 0f;
				x2 = 1f;
				y3 = 0f;
				y4 = 1f / ((float)FHNFPBCBODL.height * 1f);
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				x = 0f;
				x2 = 1f;
				y3 = 1f - 1f / ((float)FHNFPBCBODL.height * 1f);
				y4 = 1f;
				GL.TexCoord2(0f, y);
				GL.Vertex3(x, y3, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(x2, y3, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(x2, y4, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(x, y4, 0.1f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FC7 RID: 32711 RVA: 0x002AD144 File Offset: 0x002AB344
		private static void DDEEIKMLDKB(float IEKFIDNJJAM, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN, Camera HMFGLHIAIOM)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("CameraFilterPack/Blend2Camera_Blend", HLBKCLPNHEB);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(HMFGLHIAIOM.projectionMatrix);
			float f = HMFGLHIAIOM.fieldOfView * 1633f * 775f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = HMFGLHIAIOM.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 240f / -num;
			float num5 = 742f / num;
			float num6 = 482f;
			num2 *= IEKFIDNJJAM * num6;
			num3 *= IEKFIDNJJAM * num6;
			num4 *= IEKFIDNJJAM * num6;
			num5 *= IEKFIDNJJAM * num6;
			float z = -IEKFIDNJJAM;
			for (int i = 1; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(1);
				float y;
				float y2;
				if (flag)
				{
					y = 70f;
					y2 = 1830f;
				}
				else
				{
					y = 617f;
					y2 = 1566f;
				}
				GL.TexCoord2(522f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(664f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(1019f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(183f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FC8 RID: 32712 RVA: 0x002AD2A9 File Offset: 0x002AB4A9
		private void PLHMAOMGFMF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			Debug.Log("PunSupportLogger");
		}

		// Token: 0x06007FC9 RID: 32713 RVA: 0x002AD2B8 File Offset: 0x002AB4B8
		private static void FLCKJBBPFNL(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1833f;
					y2 = 1652f;
				}
				else
				{
					y = 928f;
					y2 = 56f;
				}
				float x = 911f;
				float x2 = 36f / ((float)FHNFPBCBODL.width * 1047f);
				float y3 = 139f;
				float y4 = 1330f;
				GL.Begin(0);
				GL.TexCoord2(1472f, y);
				GL.Vertex3(x, y3, 1313f);
				GL.TexCoord2(957f, y);
				GL.Vertex3(x2, y3, 1352f);
				GL.TexCoord2(174f, y2);
				GL.Vertex3(x2, y4, 29f);
				GL.TexCoord2(687f, y2);
				GL.Vertex3(x, y4, 36f);
				x = 1782f - 537f / ((float)FHNFPBCBODL.width * 524f);
				x2 = 1762f;
				y3 = 646f;
				y4 = 1826f;
				GL.TexCoord2(341f, y);
				GL.Vertex3(x, y3, 1211f);
				GL.TexCoord2(342f, y);
				GL.Vertex3(x2, y3, 833f);
				GL.TexCoord2(1551f, y2);
				GL.Vertex3(x2, y4, 1438f);
				GL.TexCoord2(859f, y2);
				GL.Vertex3(x, y4, 859f);
				x = 1997f;
				x2 = 563f;
				y3 = 767f;
				y4 = 1199f / ((float)FHNFPBCBODL.height * 1157f);
				GL.TexCoord2(214f, y);
				GL.Vertex3(x, y3, 1152f);
				GL.TexCoord2(670f, y);
				GL.Vertex3(x2, y3, 1469f);
				GL.TexCoord2(970f, y2);
				GL.Vertex3(x2, y4, 1517f);
				GL.TexCoord2(608f, y2);
				GL.Vertex3(x, y4, 103f);
				x = 725f;
				x2 = 1783f;
				y3 = 1019f - 852f / ((float)FHNFPBCBODL.height * 1598f);
				y4 = 572f;
				GL.TexCoord2(1393f, y);
				GL.Vertex3(x, y3, 1694f);
				GL.TexCoord2(1612f, y);
				GL.Vertex3(x2, y3, 0f);
				GL.TexCoord2(973f, y2);
				GL.Vertex3(x2, y4, 1654f);
				GL.TexCoord2(365f, y2);
				GL.Vertex3(x, y4, 1288f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FCA RID: 32714 RVA: 0x002AD558 File Offset: 0x002AB758
		private static void JBKFJIDNFMK(float IEKFIDNJJAM, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN, Camera HMFGLHIAIOM)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("TimeBGSlider", HLBKCLPNHEB);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(HMFGLHIAIOM.projectionMatrix);
			float f = HMFGLHIAIOM.fieldOfView * 1948f * 604f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = HMFGLHIAIOM.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 1877f / -num;
			float num5 = 250f / num;
			float num6 = 1126f;
			num2 *= IEKFIDNJJAM * num6;
			num3 *= IEKFIDNJJAM * num6;
			num4 *= IEKFIDNJJAM * num6;
			num5 *= IEKFIDNJJAM * num6;
			float z = -IEKFIDNJJAM;
			for (int i = 1; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(5);
				float y;
				float y2;
				if (flag)
				{
					y = 1481f;
					y2 = 1260f;
				}
				else
				{
					y = 1047f;
					y2 = 1835f;
				}
				GL.TexCoord2(510f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(533f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(294f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(493f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FCB RID: 32715 RVA: 0x002AD6C0 File Offset: 0x002AB8C0
		private static void EHBFGMJBCCC(float IEKFIDNJJAM, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN, Camera HMFGLHIAIOM)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("_FadeFX", HLBKCLPNHEB);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(HMFGLHIAIOM.projectionMatrix);
			float f = HMFGLHIAIOM.fieldOfView * 1229f * 592f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = HMFGLHIAIOM.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 1451f / -num;
			float num5 = 750f / num;
			float num6 = 1008f;
			num2 *= IEKFIDNJJAM * num6;
			num3 *= IEKFIDNJJAM * num6;
			num4 *= IEKFIDNJJAM * num6;
			num5 *= IEKFIDNJJAM * num6;
			float z = -IEKFIDNJJAM;
			for (int i = 1; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(3);
				float y;
				float y2;
				if (flag)
				{
					y = 174f;
					y2 = 863f;
				}
				else
				{
					y = 1271f;
					y2 = 889f;
				}
				GL.TexCoord2(463f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(1474f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(1906f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(999f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FCC RID: 32716 RVA: 0x002AD828 File Offset: 0x002ABA28
		private static void POPMAEBEOCL(float JJHJLEJMFID, float JINOMGPBACG, float NBLOBAIKBBB, float PKLDINBOIKI, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("Arc", HLBKCLPNHEB);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 1; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(1);
				float y;
				float y2;
				if (flag)
				{
					y = 384f;
					y2 = 635f;
				}
				else
				{
					y = 1312f;
					y2 = 1170f;
				}
				GL.TexCoord2(190f, y);
				GL.Vertex3(JJHJLEJMFID, NBLOBAIKBBB, 1590f);
				GL.TexCoord2(17f, y);
				GL.Vertex3(JINOMGPBACG, NBLOBAIKBBB, 183f);
				GL.TexCoord2(1183f, y2);
				GL.Vertex3(JINOMGPBACG, PKLDINBOIKI, 505f);
				GL.TexCoord2(811f, y2);
				GL.Vertex3(JJHJLEJMFID, PKLDINBOIKI, 348f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FCD RID: 32717 RVA: 0x002AD908 File Offset: 0x002ABB08
		private static void JBGFCMDKCFA(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 1; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1169f;
					y2 = 1818f;
				}
				else
				{
					y = 726f;
					y2 = 647f;
				}
				float x = 1663f;
				float x2 = 236f / ((float)FHNFPBCBODL.width * 487f);
				float y3 = 236f;
				float y4 = 704f;
				GL.Begin(5);
				GL.TexCoord2(550f, y);
				GL.Vertex3(x, y3, 899f);
				GL.TexCoord2(1714f, y);
				GL.Vertex3(x2, y3, 724f);
				GL.TexCoord2(1508f, y2);
				GL.Vertex3(x2, y4, 88f);
				GL.TexCoord2(933f, y2);
				GL.Vertex3(x, y4, 289f);
				x = 1034f - 338f / ((float)FHNFPBCBODL.width * 1705f);
				x2 = 158f;
				y3 = 1499f;
				y4 = 399f;
				GL.TexCoord2(491f, y);
				GL.Vertex3(x, y3, 1389f);
				GL.TexCoord2(1549f, y);
				GL.Vertex3(x2, y3, 71f);
				GL.TexCoord2(647f, y2);
				GL.Vertex3(x2, y4, 1623f);
				GL.TexCoord2(894f, y2);
				GL.Vertex3(x, y4, 308f);
				x = 796f;
				x2 = 1855f;
				y3 = 79f;
				y4 = 1812f / ((float)FHNFPBCBODL.height * 687f);
				GL.TexCoord2(669f, y);
				GL.Vertex3(x, y3, 266f);
				GL.TexCoord2(265f, y);
				GL.Vertex3(x2, y3, 1131f);
				GL.TexCoord2(854f, y2);
				GL.Vertex3(x2, y4, 1443f);
				GL.TexCoord2(1119f, y2);
				GL.Vertex3(x, y4, 1765f);
				x = 307f;
				x2 = 1047f;
				y3 = 498f - 113f / ((float)FHNFPBCBODL.height * 1696f);
				y4 = 905f;
				GL.TexCoord2(1573f, y);
				GL.Vertex3(x, y3, 626f);
				GL.TexCoord2(692f, y);
				GL.Vertex3(x2, y3, 642f);
				GL.TexCoord2(860f, y2);
				GL.Vertex3(x2, y4, 1022f);
				GL.TexCoord2(871f, y2);
				GL.Vertex3(x, y4, 567f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FCE RID: 32718 RVA: 0x002ADBA8 File Offset: 0x002ABDA8
		private static void KFABECFMFPB(float JJHJLEJMFID, float JINOMGPBACG, float NBLOBAIKBBB, float PKLDINBOIKI, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("HandsCountSlider", HLBKCLPNHEB);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(6);
				float y;
				float y2;
				if (flag)
				{
					y = 796f;
					y2 = 74f;
				}
				else
				{
					y = 1076f;
					y2 = 337f;
				}
				GL.TexCoord2(357f, y);
				GL.Vertex3(JJHJLEJMFID, NBLOBAIKBBB, 1851f);
				GL.TexCoord2(384f, y);
				GL.Vertex3(JINOMGPBACG, NBLOBAIKBBB, 356f);
				GL.TexCoord2(93f, y2);
				GL.Vertex3(JINOMGPBACG, PKLDINBOIKI, 1710f);
				GL.TexCoord2(1065f, y2);
				GL.Vertex3(JJHJLEJMFID, PKLDINBOIKI, 1224f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FCF RID: 32719 RVA: 0x002ADC88 File Offset: 0x002ABE88
		private static void OINAMDDGHLG(float JJHJLEJMFID, float JINOMGPBACG, float NBLOBAIKBBB, float PKLDINBOIKI, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("_Value7", HLBKCLPNHEB);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(8);
				float y;
				float y2;
				if (flag)
				{
					y = 825f;
					y2 = 639f;
				}
				else
				{
					y = 971f;
					y2 = 939f;
				}
				GL.TexCoord2(1695f, y);
				GL.Vertex3(JJHJLEJMFID, NBLOBAIKBBB, 1049f);
				GL.TexCoord2(609f, y);
				GL.Vertex3(JINOMGPBACG, NBLOBAIKBBB, 1471f);
				GL.TexCoord2(37f, y2);
				GL.Vertex3(JINOMGPBACG, PKLDINBOIKI, 1772f);
				GL.TexCoord2(307f, y2);
				GL.Vertex3(JJHJLEJMFID, PKLDINBOIKI, 1813f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FD0 RID: 32720 RVA: 0x002ADD66 File Offset: 0x002ABF66
		private void ENGFEPKGEDG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			Debug.Log("#failed!");
		}

		// Token: 0x06007FD1 RID: 32721 RVA: 0x002ADD74 File Offset: 0x002ABF74
		private static void AHPPNAIGDED(float JJHJLEJMFID, float JINOMGPBACG, float NBLOBAIKBBB, float PKLDINBOIKI, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("_MainTex", HLBKCLPNHEB);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(7);
				float y;
				float y2;
				if (flag)
				{
					y = 1f;
					y2 = 0f;
				}
				else
				{
					y = 0f;
					y2 = 1f;
				}
				GL.TexCoord2(0f, y);
				GL.Vertex3(JJHJLEJMFID, NBLOBAIKBBB, 0.1f);
				GL.TexCoord2(1f, y);
				GL.Vertex3(JINOMGPBACG, NBLOBAIKBBB, 0.1f);
				GL.TexCoord2(1f, y2);
				GL.Vertex3(JINOMGPBACG, PKLDINBOIKI, 0.1f);
				GL.TexCoord2(0f, y2);
				GL.Vertex3(JJHJLEJMFID, PKLDINBOIKI, 0.1f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FD2 RID: 32722 RVA: 0x002ADE54 File Offset: 0x002AC054
		private static void NLJPNHLDHCI(float JJHJLEJMFID, float JINOMGPBACG, float NBLOBAIKBBB, float PKLDINBOIKI, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture(": ", HLBKCLPNHEB);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 1; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(2);
				float y;
				float y2;
				if (flag)
				{
					y = 184f;
					y2 = 1289f;
				}
				else
				{
					y = 1070f;
					y2 = 1606f;
				}
				GL.TexCoord2(936f, y);
				GL.Vertex3(JJHJLEJMFID, NBLOBAIKBBB, 656f);
				GL.TexCoord2(1551f, y);
				GL.Vertex3(JINOMGPBACG, NBLOBAIKBBB, 667f);
				GL.TexCoord2(936f, y2);
				GL.Vertex3(JINOMGPBACG, PKLDINBOIKI, 605f);
				GL.TexCoord2(375f, y2);
				GL.Vertex3(JJHJLEJMFID, PKLDINBOIKI, 935f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FD3 RID: 32723 RVA: 0x002ADF32 File Offset: 0x002AC132
		private void KMAPABACMAG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			Debug.Log("_ExposureAdjustment");
		}

		// Token: 0x06007FD4 RID: 32724 RVA: 0x002ADF40 File Offset: 0x002AC140
		private static void BAOPMDPKOKO(float JJHJLEJMFID, float JINOMGPBACG, float NBLOBAIKBBB, float PKLDINBOIKI, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("shader.invert", HLBKCLPNHEB);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(2);
				float y;
				float y2;
				if (flag)
				{
					y = 1835f;
					y2 = 436f;
				}
				else
				{
					y = 596f;
					y2 = 1558f;
				}
				GL.TexCoord2(906f, y);
				GL.Vertex3(JJHJLEJMFID, NBLOBAIKBBB, 889f);
				GL.TexCoord2(134f, y);
				GL.Vertex3(JINOMGPBACG, NBLOBAIKBBB, 807f);
				GL.TexCoord2(420f, y2);
				GL.Vertex3(JINOMGPBACG, PKLDINBOIKI, 1783f);
				GL.TexCoord2(408f, y2);
				GL.Vertex3(JJHJLEJMFID, PKLDINBOIKI, 293f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FD5 RID: 32725 RVA: 0x002AE020 File Offset: 0x002AC220
		private static void AHCAMIJGJMJ(float IEKFIDNJJAM, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN, Camera HMFGLHIAIOM)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("CameraFilterPack/FX_Scan", HLBKCLPNHEB);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(HMFGLHIAIOM.projectionMatrix);
			float f = HMFGLHIAIOM.fieldOfView * 176f * 919f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = HMFGLHIAIOM.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 1714f / -num;
			float num5 = 1319f / num;
			float num6 = 1717f;
			num2 *= IEKFIDNJJAM * num6;
			num3 *= IEKFIDNJJAM * num6;
			num4 *= IEKFIDNJJAM * num6;
			num5 *= IEKFIDNJJAM * num6;
			float z = -IEKFIDNJJAM;
			for (int i = 1; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(1);
				float y;
				float y2;
				if (flag)
				{
					y = 638f;
					y2 = 1881f;
				}
				else
				{
					y = 11f;
					y2 = 1059f;
				}
				GL.TexCoord2(1199f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(1694f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(1377f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(1173f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FD6 RID: 32726 RVA: 0x002AE188 File Offset: 0x002AC388
		private static void DOBBNHCCKCP(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 1; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 942f;
					y2 = 1102f;
				}
				else
				{
					y = 689f;
					y2 = 913f;
				}
				float x = 929f;
				float x2 = 1326f / ((float)FHNFPBCBODL.width * 86f);
				float y3 = 1191f;
				float y4 = 1273f;
				GL.Begin(7);
				GL.TexCoord2(445f, y);
				GL.Vertex3(x, y3, 769f);
				GL.TexCoord2(1339f, y);
				GL.Vertex3(x2, y3, 1216f);
				GL.TexCoord2(802f, y2);
				GL.Vertex3(x2, y4, 998f);
				GL.TexCoord2(1325f, y2);
				GL.Vertex3(x, y4, 326f);
				x = 563f - 1811f / ((float)FHNFPBCBODL.width * 512f);
				x2 = 1215f;
				y3 = 1175f;
				y4 = 1470f;
				GL.TexCoord2(1366f, y);
				GL.Vertex3(x, y3, 967f);
				GL.TexCoord2(1176f, y);
				GL.Vertex3(x2, y3, 369f);
				GL.TexCoord2(1305f, y2);
				GL.Vertex3(x2, y4, 1451f);
				GL.TexCoord2(627f, y2);
				GL.Vertex3(x, y4, 1270f);
				x = 431f;
				x2 = 585f;
				y3 = 344f;
				y4 = 725f / ((float)FHNFPBCBODL.height * 1135f);
				GL.TexCoord2(483f, y);
				GL.Vertex3(x, y3, 1339f);
				GL.TexCoord2(371f, y);
				GL.Vertex3(x2, y3, 1956f);
				GL.TexCoord2(1886f, y2);
				GL.Vertex3(x2, y4, 1416f);
				GL.TexCoord2(42f, y2);
				GL.Vertex3(x, y4, 1755f);
				x = 23f;
				x2 = 421f;
				y3 = 1052f - 163f / ((float)FHNFPBCBODL.height * 1521f);
				y4 = 984f;
				GL.TexCoord2(219f, y);
				GL.Vertex3(x, y3, 1796f);
				GL.TexCoord2(1753f, y);
				GL.Vertex3(x2, y3, 924f);
				GL.TexCoord2(1671f, y2);
				GL.Vertex3(x2, y4, 671f);
				GL.TexCoord2(104f, y2);
				GL.Vertex3(x, y4, 569f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FD7 RID: 32727 RVA: 0x002AE428 File Offset: 0x002AC628
		private static void JDDKPEJAFEG(float JJHJLEJMFID, float JINOMGPBACG, float NBLOBAIKBBB, float PKLDINBOIKI, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("_ScreenResolution", HLBKCLPNHEB);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(3);
				float y;
				float y2;
				if (flag)
				{
					y = 1275f;
					y2 = 1601f;
				}
				else
				{
					y = 723f;
					y2 = 666f;
				}
				GL.TexCoord2(1926f, y);
				GL.Vertex3(JJHJLEJMFID, NBLOBAIKBBB, 117f);
				GL.TexCoord2(1664f, y);
				GL.Vertex3(JINOMGPBACG, NBLOBAIKBBB, 751f);
				GL.TexCoord2(1533f, y2);
				GL.Vertex3(JINOMGPBACG, PKLDINBOIKI, 403f);
				GL.TexCoord2(186f, y2);
				GL.Vertex3(JJHJLEJMFID, PKLDINBOIKI, 39f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FD8 RID: 32728 RVA: 0x002AE508 File Offset: 0x002AC708
		private static void FAKNCBJCCEF(float IEKFIDNJJAM, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN, Camera HMFGLHIAIOM)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("\n", HLBKCLPNHEB);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(HMFGLHIAIOM.projectionMatrix);
			float f = HMFGLHIAIOM.fieldOfView * 282f * 1998f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = HMFGLHIAIOM.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 1077f / -num;
			float num5 = 825f / num;
			float num6 = 886f;
			num2 *= IEKFIDNJJAM * num6;
			num3 *= IEKFIDNJJAM * num6;
			num4 *= IEKFIDNJJAM * num6;
			num5 *= IEKFIDNJJAM * num6;
			float z = -IEKFIDNJJAM;
			for (int i = 0; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(7);
				float y;
				float y2;
				if (flag)
				{
					y = 1468f;
					y2 = 401f;
				}
				else
				{
					y = 1516f;
					y2 = 212f;
				}
				GL.TexCoord2(1543f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(224f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(685f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(74f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FD9 RID: 32729 RVA: 0x002AE66D File Offset: 0x002AC86D
		private void KBGCKEDIGAH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			Debug.Log("_Value");
		}

		// Token: 0x06007FDA RID: 32730 RVA: 0x002AE679 File Offset: 0x002AC879
		private void MDHIALGJMBO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			Debug.Log("menu.selectedplaymode");
		}

		// Token: 0x06007FDB RID: 32731 RVA: 0x002AE688 File Offset: 0x002AC888
		private static void FLHONPEEDGG(float IEKFIDNJJAM, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN, Camera HMFGLHIAIOM)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("CameraFilterPack/Color_Convert_Normal", HLBKCLPNHEB);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(HMFGLHIAIOM.projectionMatrix);
			float f = HMFGLHIAIOM.fieldOfView * 115f * 1567f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = HMFGLHIAIOM.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 1326f / -num;
			float num5 = 700f / num;
			float num6 = 157f;
			num2 *= IEKFIDNJJAM * num6;
			num3 *= IEKFIDNJJAM * num6;
			num4 *= IEKFIDNJJAM * num6;
			num5 *= IEKFIDNJJAM * num6;
			float z = -IEKFIDNJJAM;
			for (int i = 1; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(5);
				float y;
				float y2;
				if (flag)
				{
					y = 1145f;
					y2 = 627f;
				}
				else
				{
					y = 488f;
					y2 = 429f;
				}
				GL.TexCoord2(846f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(1193f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(810f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(914f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FDC RID: 32732 RVA: 0x002AE7F0 File Offset: 0x002AC9F0
		private static void FPICBELOKCA(float IEKFIDNJJAM, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN, Camera HMFGLHIAIOM)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("CameraFilterPack_Broken_Screen1", HLBKCLPNHEB);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(HMFGLHIAIOM.projectionMatrix);
			float f = HMFGLHIAIOM.fieldOfView * 525f * 845f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = HMFGLHIAIOM.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 776f / -num;
			float num5 = 1502f / num;
			float num6 = 1941f;
			num2 *= IEKFIDNJJAM * num6;
			num3 *= IEKFIDNJJAM * num6;
			num4 *= IEKFIDNJJAM * num6;
			num5 *= IEKFIDNJJAM * num6;
			float z = -IEKFIDNJJAM;
			for (int i = 0; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(2);
				float y;
				float y2;
				if (flag)
				{
					y = 40f;
					y2 = 861f;
				}
				else
				{
					y = 1414f;
					y2 = 1659f;
				}
				GL.TexCoord2(1945f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(160f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(1517f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(15f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FDD RID: 32733 RVA: 0x002AE958 File Offset: 0x002ACB58
		private static void KCGIHFFCDKN(float IEKFIDNJJAM, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN, Camera HMFGLHIAIOM)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("_Size", HLBKCLPNHEB);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(HMFGLHIAIOM.projectionMatrix);
			float f = HMFGLHIAIOM.fieldOfView * 46f * 161f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = HMFGLHIAIOM.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 945f / -num;
			float num5 = 1143f / num;
			float num6 = 368f;
			num2 *= IEKFIDNJJAM * num6;
			num3 *= IEKFIDNJJAM * num6;
			num4 *= IEKFIDNJJAM * num6;
			num5 *= IEKFIDNJJAM * num6;
			float z = -IEKFIDNJJAM;
			for (int i = 0; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(3);
				float y;
				float y2;
				if (flag)
				{
					y = 1770f;
					y2 = 1186f;
				}
				else
				{
					y = 1644f;
					y2 = 593f;
				}
				GL.TexCoord2(1889f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(843f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(554f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(1194f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FDE RID: 32734 RVA: 0x002AEAC0 File Offset: 0x002ACCC0
		private static void EHMOPBHPLFJ(float IEKFIDNJJAM, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN, Camera HMFGLHIAIOM)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("_TimeX", HLBKCLPNHEB);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(HMFGLHIAIOM.projectionMatrix);
			float f = HMFGLHIAIOM.fieldOfView * 344f * 1977f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = HMFGLHIAIOM.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 1769f / -num;
			float num5 = 788f / num;
			float num6 = 1192f;
			num2 *= IEKFIDNJJAM * num6;
			num3 *= IEKFIDNJJAM * num6;
			num4 *= IEKFIDNJJAM * num6;
			num5 *= IEKFIDNJJAM * num6;
			float z = -IEKFIDNJJAM;
			for (int i = 0; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(0);
				float y;
				float y2;
				if (flag)
				{
					y = 1700f;
					y2 = 425f;
				}
				else
				{
					y = 36f;
					y2 = 1683f;
				}
				GL.TexCoord2(90f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(1111f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(353f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(439f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FDF RID: 32735 RVA: 0x002AEC28 File Offset: 0x002ACE28
		private static void CIEINCAPAHK(float IEKFIDNJJAM, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN, Camera HMFGLHIAIOM)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("SetSatelliteSensitivity", HLBKCLPNHEB);
			bool flag = false;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(HMFGLHIAIOM.projectionMatrix);
			float f = HMFGLHIAIOM.fieldOfView * 1379f * 42f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = HMFGLHIAIOM.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 1655f / -num;
			float num5 = 935f / num;
			float num6 = 992f;
			num2 *= IEKFIDNJJAM * num6;
			num3 *= IEKFIDNJJAM * num6;
			num4 *= IEKFIDNJJAM * num6;
			num5 *= IEKFIDNJJAM * num6;
			float z = -IEKFIDNJJAM;
			for (int i = 1; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(6);
				float y;
				float y2;
				if (flag)
				{
					y = 788f;
					y2 = 1357f;
				}
				else
				{
					y = 353f;
					y2 = 803f;
				}
				GL.TexCoord2(1238f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(247f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(75f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(1292f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FE0 RID: 32736 RVA: 0x002AED90 File Offset: 0x002ACF90
		private static void CBNLFNAIIIP(float IEKFIDNJJAM, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN, Camera HMFGLHIAIOM)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("Anomaly_With_Obj", HLBKCLPNHEB);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(HMFGLHIAIOM.projectionMatrix);
			float f = HMFGLHIAIOM.fieldOfView * 1629f * 1232f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = HMFGLHIAIOM.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 1945f / -num;
			float num5 = 1258f / num;
			float num6 = 428f;
			num2 *= IEKFIDNJJAM * num6;
			num3 *= IEKFIDNJJAM * num6;
			num4 *= IEKFIDNJJAM * num6;
			num5 *= IEKFIDNJJAM * num6;
			float z = -IEKFIDNJJAM;
			for (int i = 1; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(8);
				float y;
				float y2;
				if (flag)
				{
					y = 1790f;
					y2 = 933f;
				}
				else
				{
					y = 862f;
					y2 = 1396f;
				}
				GL.TexCoord2(678f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(971f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(1569f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(1783f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FE1 RID: 32737 RVA: 0x002AEEF8 File Offset: 0x002AD0F8
		private static void AICBJGKKCCF(float IEKFIDNJJAM, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN, Camera HMFGLHIAIOM)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("mapselector.lastSearch", HLBKCLPNHEB);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(HMFGLHIAIOM.projectionMatrix);
			float f = HMFGLHIAIOM.fieldOfView * 768f * 596f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = HMFGLHIAIOM.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 1192f / -num;
			float num5 = 453f / num;
			float num6 = 1319f;
			num2 *= IEKFIDNJJAM * num6;
			num3 *= IEKFIDNJJAM * num6;
			num4 *= IEKFIDNJJAM * num6;
			num5 *= IEKFIDNJJAM * num6;
			float z = -IEKFIDNJJAM;
			for (int i = 0; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(5);
				float y;
				float y2;
				if (flag)
				{
					y = 423f;
					y2 = 438f;
				}
				else
				{
					y = 1216f;
					y2 = 1645f;
				}
				GL.TexCoord2(811f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(1199f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(1734f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(1922f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FE2 RID: 32738 RVA: 0x002AF060 File Offset: 0x002AD260
		private static void KEKDMLCLCPA(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 1; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1544f;
					y2 = 1838f;
				}
				else
				{
					y = 559f;
					y2 = 27f;
				}
				float x = 1872f;
				float x2 = 1337f / ((float)FHNFPBCBODL.width * 1984f);
				float y3 = 266f;
				float y4 = 1403f;
				GL.Begin(3);
				GL.TexCoord2(965f, y);
				GL.Vertex3(x, y3, 1704f);
				GL.TexCoord2(424f, y);
				GL.Vertex3(x2, y3, 1801f);
				GL.TexCoord2(1786f, y2);
				GL.Vertex3(x2, y4, 1333f);
				GL.TexCoord2(643f, y2);
				GL.Vertex3(x, y4, 973f);
				x = 657f - 750f / ((float)FHNFPBCBODL.width * 1193f);
				x2 = 1483f;
				y3 = 41f;
				y4 = 594f;
				GL.TexCoord2(1848f, y);
				GL.Vertex3(x, y3, 1855f);
				GL.TexCoord2(1052f, y);
				GL.Vertex3(x2, y3, 1972f);
				GL.TexCoord2(1101f, y2);
				GL.Vertex3(x2, y4, 317f);
				GL.TexCoord2(380f, y2);
				GL.Vertex3(x, y4, 1021f);
				x = 308f;
				x2 = 70f;
				y3 = 1866f;
				y4 = 1283f / ((float)FHNFPBCBODL.height * 235f);
				GL.TexCoord2(778f, y);
				GL.Vertex3(x, y3, 714f);
				GL.TexCoord2(461f, y);
				GL.Vertex3(x2, y3, 1705f);
				GL.TexCoord2(276f, y2);
				GL.Vertex3(x2, y4, 790f);
				GL.TexCoord2(1495f, y2);
				GL.Vertex3(x, y4, 474f);
				x = 1700f;
				x2 = 142f;
				y3 = 1369f - 1282f / ((float)FHNFPBCBODL.height * 212f);
				y4 = 1980f;
				GL.TexCoord2(1853f, y);
				GL.Vertex3(x, y3, 267f);
				GL.TexCoord2(1238f, y);
				GL.Vertex3(x2, y3, 1596f);
				GL.TexCoord2(522f, y2);
				GL.Vertex3(x2, y4, 1529f);
				GL.TexCoord2(489f, y2);
				GL.Vertex3(x, y4, 161f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FE3 RID: 32739 RVA: 0x002AF300 File Offset: 0x002AD500
		private static void CAOHDGNDILN(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			bool flag = false;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1338f;
					y2 = 1750f;
				}
				else
				{
					y = 759f;
					y2 = 631f;
				}
				float x = 1289f;
				float x2 = 1675f / ((float)FHNFPBCBODL.width * 1862f);
				float y3 = 668f;
				float y4 = 1711f;
				GL.Begin(8);
				GL.TexCoord2(259f, y);
				GL.Vertex3(x, y3, 1905f);
				GL.TexCoord2(1860f, y);
				GL.Vertex3(x2, y3, 961f);
				GL.TexCoord2(1357f, y2);
				GL.Vertex3(x2, y4, 1441f);
				GL.TexCoord2(1386f, y2);
				GL.Vertex3(x, y4, 244f);
				x = 1718f - 1649f / ((float)FHNFPBCBODL.width * 1353f);
				x2 = 1924f;
				y3 = 1164f;
				y4 = 235f;
				GL.TexCoord2(1477f, y);
				GL.Vertex3(x, y3, 738f);
				GL.TexCoord2(1510f, y);
				GL.Vertex3(x2, y3, 1092f);
				GL.TexCoord2(976f, y2);
				GL.Vertex3(x2, y4, 1112f);
				GL.TexCoord2(441f, y2);
				GL.Vertex3(x, y4, 1361f);
				x = 1543f;
				x2 = 579f;
				y3 = 1494f;
				y4 = 1444f / ((float)FHNFPBCBODL.height * 887f);
				GL.TexCoord2(178f, y);
				GL.Vertex3(x, y3, 959f);
				GL.TexCoord2(942f, y);
				GL.Vertex3(x2, y3, 1249f);
				GL.TexCoord2(1067f, y2);
				GL.Vertex3(x2, y4, 1451f);
				GL.TexCoord2(540f, y2);
				GL.Vertex3(x, y4, 237f);
				x = 92f;
				x2 = 1018f;
				y3 = 947f - 1028f / ((float)FHNFPBCBODL.height * 72f);
				y4 = 838f;
				GL.TexCoord2(153f, y);
				GL.Vertex3(x, y3, 190f);
				GL.TexCoord2(1242f, y);
				GL.Vertex3(x2, y3, 1797f);
				GL.TexCoord2(1977f, y2);
				GL.Vertex3(x2, y4, 206f);
				GL.TexCoord2(180f, y2);
				GL.Vertex3(x, y4, 1137f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FE4 RID: 32740 RVA: 0x002AF5A0 File Offset: 0x002AD7A0
		private void HELHDLOLPLH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			Debug.Log("_Value2");
		}

		// Token: 0x06007FE5 RID: 32741 RVA: 0x002AF5AC File Offset: 0x002AD7AC
		private static void PKHMHBKOEAK(float IEKFIDNJJAM, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN, Camera HMFGLHIAIOM)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("CameraFilterPack_WaterDrop", HLBKCLPNHEB);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(HMFGLHIAIOM.projectionMatrix);
			float f = HMFGLHIAIOM.fieldOfView * 174f * 1577f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = HMFGLHIAIOM.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 1766f / -num;
			float num5 = 1694f / num;
			float num6 = 1817f;
			num2 *= IEKFIDNJJAM * num6;
			num3 *= IEKFIDNJJAM * num6;
			num4 *= IEKFIDNJJAM * num6;
			num5 *= IEKFIDNJJAM * num6;
			float z = -IEKFIDNJJAM;
			for (int i = 0; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(8);
				float y;
				float y2;
				if (flag)
				{
					y = 723f;
					y2 = 928f;
				}
				else
				{
					y = 646f;
					y2 = 1442f;
				}
				GL.TexCoord2(1154f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(1818f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(1016f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(270f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007FE7 RID: 32743 RVA: 0x002AF714 File Offset: 0x002AD914
		private static void EKFGEABBNEE(float IEKFIDNJJAM, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN, Camera HMFGLHIAIOM)
		{
			RenderTexture.active = FHNFPBCBODL;
			NBPKMLMCHFN.SetTexture("There are too many cells created by your subdivision options. Maximum allowed number of cells is ", HLBKCLPNHEB);
			bool flag = true;
			GL.PushMatrix();
			GL.LoadIdentity();
			GL.LoadProjectionMatrix(HMFGLHIAIOM.projectionMatrix);
			float f = HMFGLHIAIOM.fieldOfView * 119f * 814f;
			float num = Mathf.Cos(f) / Mathf.Sin(f);
			float aspect = HMFGLHIAIOM.aspect;
			float num2 = aspect / -num;
			float num3 = aspect / num;
			float num4 = 1922f / -num;
			float num5 = 1466f / num;
			float num6 = 1762f;
			num2 *= IEKFIDNJJAM * num6;
			num3 *= IEKFIDNJJAM * num6;
			num4 *= IEKFIDNJJAM * num6;
			num5 *= IEKFIDNJJAM * num6;
			float z = -IEKFIDNJJAM;
			for (int i = 1; i < NBPKMLMCHFN.passCount; i++)
			{
				NBPKMLMCHFN.SetPass(i);
				GL.Begin(2);
				float y;
				float y2;
				if (flag)
				{
					y = 588f;
					y2 = 1259f;
				}
				else
				{
					y = 1818f;
					y2 = 1376f;
				}
				GL.TexCoord2(1674f, y);
				GL.Vertex3(num2, num4, z);
				GL.TexCoord2(521f, y);
				GL.Vertex3(num3, num4, z);
				GL.TexCoord2(37f, y2);
				GL.Vertex3(num3, num5, z);
				GL.TexCoord2(1228f, y2);
				GL.Vertex3(num2, num5, z);
				GL.End();
			}
			GL.PopMatrix();
		}
	}
}
