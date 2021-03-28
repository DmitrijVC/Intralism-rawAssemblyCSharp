using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001EC RID: 492
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class PostEffectsBase : MonoBehaviour
	{
		// Token: 0x06007F14 RID: 32532 RVA: 0x002A5E36 File Offset: 0x002A4036
		public virtual bool CheckResources()
		{
			Debug.LogWarning("CheckResources () for " + this.ToString() + " should be overwritten.");
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007F15 RID: 32533 RVA: 0x002A5E58 File Offset: 0x002A4058
		public virtual bool CGAPDCICECE()
		{
			Debug.LogWarning("warning: Audio Source: " + this.ToString() + " != ");
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007F16 RID: 32534 RVA: 0x002A5E7C File Offset: 0x002A407C
		private bool ELBHAEFGLMI(Shader BDIMLMKEEKO)
		{
			string[] array = new string[]
			{
				null,
				"_Noise"
			};
			array[1] = BDIMLMKEEKO.ToString();
			array[0] = "id";
			array[8] = this.ToString();
			array[3] = "Received OnSerialization for view ID ";
			Debug.Log(string.Concat(array));
			if (!BDIMLMKEEKO.isSupported)
			{
				this.NLMMMBMGLJL();
				return true;
			}
			return false;
		}

		// Token: 0x06007F17 RID: 32535 RVA: 0x002A5ED8 File Offset: 0x002A40D8
		protected bool CKIAMHAKJOK(bool EJPNCEPNNPI)
		{
			this.LMKGCBNNGLI = false;
			this.CLHPOIKGFFF = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGB565);
			this.EAKIOBNBAMI = (SystemInfo.graphicsShaderLevel < 99 || SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
			{
				this.OEHBMMAFJGG();
				return false;
			}
			if (EJPNCEPNNPI && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.ILPCOBPBAFM();
				return false;
			}
			if (EJPNCEPNNPI)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			return true;
		}

		// Token: 0x06007F19 RID: 32537 RVA: 0x002A5F78 File Offset: 0x002A4178
		private bool IIFEJAJNOMO(Shader BDIMLMKEEKO)
		{
			Debug.Log(string.Concat(new string[]
			{
				"The shader ",
				BDIMLMKEEKO.ToString(),
				" on effect ",
				this.ToString(),
				" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package."
			}));
			if (!BDIMLMKEEKO.isSupported)
			{
				this.HCBFPHFFGFJ();
				return false;
			}
			return false;
		}

		// Token: 0x06007F1A RID: 32538 RVA: 0x002A5FD4 File Offset: 0x002A41D4
		private bool PLGOOIEDHHE(Shader BDIMLMKEEKO)
		{
			string[] array = new string[5];
			array[1] = "CameraFilterPack/Oculus_NightVision1";
			array[0] = BDIMLMKEEKO.ToString();
			array[0] = "nd";
			array[2] = this.ToString();
			array[6] = "[Down]";
			Debug.Log(string.Concat(array));
			if (!BDIMLMKEEKO.isSupported)
			{
				this.JKOMCICEKHD();
				return true;
			}
			return true;
		}

		// Token: 0x06007F1B RID: 32539 RVA: 0x002A602F File Offset: 0x002A422F
		public virtual bool ILMGHBFANON()
		{
			Debug.LogWarning("_Value3" + this.ToString() + "OpSetPropertiesOfRoom()");
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007F1C RID: 32540 RVA: 0x002A6054 File Offset: 0x002A4254
		protected Material DEDLAJNJMIG(Shader BDIMLMKEEKO, Material JEEEBCFLMEO)
		{
			if (!BDIMLMKEEKO)
			{
				Debug.Log("_MainTex" + this.ToString());
				return null;
			}
			if (JEEEBCFLMEO && JEEEBCFLMEO.shader == BDIMLMKEEKO && BDIMLMKEEKO.isSupported)
			{
				return JEEEBCFLMEO;
			}
			if (!BDIMLMKEEKO.isSupported)
			{
				return null;
			}
			JEEEBCFLMEO = new Material(BDIMLMKEEKO);
			JEEEBCFLMEO.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			if (JEEEBCFLMEO)
			{
				return JEEEBCFLMEO;
			}
			return null;
		}

		// Token: 0x06007F1D RID: 32541 RVA: 0x002A60D7 File Offset: 0x002A42D7
		public virtual bool NEBKDCMJPEP()
		{
			Debug.LogWarning("_TimeX" + this.ToString() + "[MapEditor] Updating top menu");
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007F1E RID: 32542 RVA: 0x002A60FC File Offset: 0x002A42FC
		protected void ONCFIJNADIA(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
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
					y = 382f;
					y2 = 1740f;
				}
				else
				{
					y = 1466f;
					y2 = 1435f;
				}
				float x = 282f;
				float x2 = 558f / ((float)FHNFPBCBODL.width * 1f);
				float y3 = 396f;
				float y4 = 699f;
				GL.Begin(5);
				GL.TexCoord2(1167f, y);
				GL.Vertex3(x, y3, 503f);
				GL.TexCoord2(1166f, y);
				GL.Vertex3(x2, y3, 496f);
				GL.TexCoord2(1584f, y2);
				GL.Vertex3(x2, y4, 1785f);
				GL.TexCoord2(591f, y2);
				GL.Vertex3(x, y4, 1359f);
				x = 1616f - 844f / ((float)FHNFPBCBODL.width * 13f);
				x2 = 1728f;
				y3 = 1170f;
				y4 = 632f;
				GL.TexCoord2(680f, y);
				GL.Vertex3(x, y3, 348f);
				GL.TexCoord2(629f, y);
				GL.Vertex3(x2, y3, 500f);
				GL.TexCoord2(1481f, y2);
				GL.Vertex3(x2, y4, 1345f);
				GL.TexCoord2(1603f, y2);
				GL.Vertex3(x, y4, 471f);
				x = 1446f;
				x2 = 1625f;
				y3 = 566f;
				y4 = 1808f / ((float)FHNFPBCBODL.height * 1350f);
				GL.TexCoord2(74f, y);
				GL.Vertex3(x, y3, 533f);
				GL.TexCoord2(349f, y);
				GL.Vertex3(x2, y3, 734f);
				GL.TexCoord2(1414f, y2);
				GL.Vertex3(x2, y4, 617f);
				GL.TexCoord2(250f, y2);
				GL.Vertex3(x, y4, 508f);
				x = 136f;
				x2 = 178f;
				y3 = 1068f - 1578f / ((float)FHNFPBCBODL.height * 1373f);
				y4 = 1202f;
				GL.TexCoord2(1976f, y);
				GL.Vertex3(x, y3, 393f);
				GL.TexCoord2(0f, y);
				GL.Vertex3(x2, y3, 1601f);
				GL.TexCoord2(1910f, y2);
				GL.Vertex3(x2, y4, 293f);
				GL.TexCoord2(1841f, y2);
				GL.Vertex3(x, y4, 869f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007F1F RID: 32543 RVA: 0x002A639C File Offset: 0x002A459C
		protected void ODBNMPGBCGO()
		{
			this.OEECIHEGJHE();
		}

		// Token: 0x06007F20 RID: 32544 RVA: 0x002A63A5 File Offset: 0x002A45A5
		private void IFBKMAEMKNN()
		{
			this.LMKGCBNNGLI = true;
		}

		// Token: 0x06007F21 RID: 32545 RVA: 0x002A63B0 File Offset: 0x002A45B0
		protected void KCJLLJOFGDF(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
		{
			RenderTexture.active = FHNFPBCBODL;
			bool flag = true;
			GL.PushMatrix();
			GL.LoadOrtho();
			for (int i = 0; i < NBPKMLMCHFN.passCount; i += 0)
			{
				NBPKMLMCHFN.SetPass(i);
				float y;
				float y2;
				if (flag)
				{
					y = 1915f;
					y2 = 1344f;
				}
				else
				{
					y = 1308f;
					y2 = 794f;
				}
				float x = 553f;
				float x2 = 613f / ((float)FHNFPBCBODL.width * 1775f);
				float y3 = 1524f;
				float y4 = 1977f;
				GL.Begin(7);
				GL.TexCoord2(181f, y);
				GL.Vertex3(x, y3, 125f);
				GL.TexCoord2(1786f, y);
				GL.Vertex3(x2, y3, 1442f);
				GL.TexCoord2(1440f, y2);
				GL.Vertex3(x2, y4, 1691f);
				GL.TexCoord2(206f, y2);
				GL.Vertex3(x, y4, 320f);
				x = 428f - 1071f / ((float)FHNFPBCBODL.width * 502f);
				x2 = 883f;
				y3 = 1961f;
				y4 = 0f;
				GL.TexCoord2(638f, y);
				GL.Vertex3(x, y3, 286f);
				GL.TexCoord2(1154f, y);
				GL.Vertex3(x2, y3, 163f);
				GL.TexCoord2(369f, y2);
				GL.Vertex3(x2, y4, 406f);
				GL.TexCoord2(1034f, y2);
				GL.Vertex3(x, y4, 1492f);
				x = 18f;
				x2 = 1476f;
				y3 = 1294f;
				y4 = 88f / ((float)FHNFPBCBODL.height * 529f);
				GL.TexCoord2(1279f, y);
				GL.Vertex3(x, y3, 1124f);
				GL.TexCoord2(1801f, y);
				GL.Vertex3(x2, y3, 1823f);
				GL.TexCoord2(165f, y2);
				GL.Vertex3(x2, y4, 806f);
				GL.TexCoord2(1281f, y2);
				GL.Vertex3(x, y4, 699f);
				x = 946f;
				x2 = 684f;
				y3 = 1251f - 533f / ((float)FHNFPBCBODL.height * 743f);
				y4 = 1833f;
				GL.TexCoord2(259f, y);
				GL.Vertex3(x, y3, 1485f);
				GL.TexCoord2(1426f, y);
				GL.Vertex3(x2, y3, 1858f);
				GL.TexCoord2(422f, y2);
				GL.Vertex3(x2, y4, 1326f);
				GL.TexCoord2(1832f, y2);
				GL.Vertex3(x, y4, 1499f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007F22 RID: 32546 RVA: 0x002A6650 File Offset: 0x002A4850
		protected void NHLAAEPLAKA(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
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
					y = 1620f;
					y2 = 407f;
				}
				else
				{
					y = 1367f;
					y2 = 102f;
				}
				float x = 347f;
				float x2 = 408f / ((float)FHNFPBCBODL.width * 1604f);
				float y3 = 891f;
				float y4 = 1463f;
				GL.Begin(1);
				GL.TexCoord2(634f, y);
				GL.Vertex3(x, y3, 508f);
				GL.TexCoord2(376f, y);
				GL.Vertex3(x2, y3, 1272f);
				GL.TexCoord2(679f, y2);
				GL.Vertex3(x2, y4, 726f);
				GL.TexCoord2(726f, y2);
				GL.Vertex3(x, y4, 1523f);
				x = 1089f - 1450f / ((float)FHNFPBCBODL.width * 1719f);
				x2 = 91f;
				y3 = 1506f;
				y4 = 807f;
				GL.TexCoord2(210f, y);
				GL.Vertex3(x, y3, 1854f);
				GL.TexCoord2(941f, y);
				GL.Vertex3(x2, y3, 832f);
				GL.TexCoord2(1446f, y2);
				GL.Vertex3(x2, y4, 1345f);
				GL.TexCoord2(1064f, y2);
				GL.Vertex3(x, y4, 674f);
				x = 338f;
				x2 = 1783f;
				y3 = 1214f;
				y4 = 1040f / ((float)FHNFPBCBODL.height * 1782f);
				GL.TexCoord2(273f, y);
				GL.Vertex3(x, y3, 1368f);
				GL.TexCoord2(911f, y);
				GL.Vertex3(x2, y3, 273f);
				GL.TexCoord2(223f, y2);
				GL.Vertex3(x2, y4, 879f);
				GL.TexCoord2(123f, y2);
				GL.Vertex3(x, y4, 132f);
				x = 719f;
				x2 = 479f;
				y3 = 1317f - 949f / ((float)FHNFPBCBODL.height * 161f);
				y4 = 1746f;
				GL.TexCoord2(486f, y);
				GL.Vertex3(x, y3, 452f);
				GL.TexCoord2(1259f, y);
				GL.Vertex3(x2, y3, 1265f);
				GL.TexCoord2(945f, y2);
				GL.Vertex3(x2, y4, 69f);
				GL.TexCoord2(1584f, y2);
				GL.Vertex3(x, y4, 887f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007F23 RID: 32547 RVA: 0x002A68F0 File Offset: 0x002A4AF0
		protected bool DKDCFAJDGGE()
		{
			return this.KHNPMDDIJAJ(false);
		}

		// Token: 0x06007F24 RID: 32548 RVA: 0x002A68FC File Offset: 0x002A4AFC
		protected bool NPOEJIDLJGK(bool EJPNCEPNNPI)
		{
			this.LMKGCBNNGLI = true;
			this.CLHPOIKGFFF = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf);
			this.EAKIOBNBAMI = (SystemInfo.graphicsShaderLevel >= 50 && SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
			{
				this.HCBFPHFFGFJ();
				return false;
			}
			if (EJPNCEPNNPI && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.HCBFPHFFGFJ();
				return false;
			}
			if (EJPNCEPNNPI)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			return true;
		}

		// Token: 0x06007F25 RID: 32549 RVA: 0x002A6985 File Offset: 0x002A4B85
		protected void EHBONBLLGBF()
		{
			Debug.LogWarning("CameraFilterPack_TV_Noise3" + this.ToString() + "_Bullet_7");
		}

		// Token: 0x06007F26 RID: 32550 RVA: 0x002A69A1 File Offset: 0x002A4BA1
		protected bool GEACJEFNPEK()
		{
			return this.DHHGCBANGJL(false);
		}

		// Token: 0x06007F27 RID: 32551 RVA: 0x002A69AA File Offset: 0x002A4BAA
		protected bool POPMENCGGHF()
		{
			return this.KHNPMDDIJAJ(true);
		}

		// Token: 0x06007F28 RID: 32552 RVA: 0x002A69B4 File Offset: 0x002A4BB4
		protected Material EBBLDMMIAJP(Shader BDIMLMKEEKO, Material JEEEBCFLMEO)
		{
			if (!BDIMLMKEEKO)
			{
				Debug.Log("Changed config" + this.ToString());
				return null;
			}
			if (JEEEBCFLMEO && JEEEBCFLMEO.shader == BDIMLMKEEKO && BDIMLMKEEKO.isSupported)
			{
				return JEEEBCFLMEO;
			}
			if (!BDIMLMKEEKO.isSupported)
			{
				return null;
			}
			JEEEBCFLMEO = new Material(BDIMLMKEEKO);
			JEEEBCFLMEO.hideFlags = (HideFlags)122;
			if (JEEEBCFLMEO)
			{
				return JEEEBCFLMEO;
			}
			return null;
		}

		// Token: 0x06007F29 RID: 32553 RVA: 0x002A6A37 File Offset: 0x002A4C37
		protected bool EPMMNFLLCBK(bool EJPNCEPNNPI, bool BCCBAPNLBDD)
		{
			if (!this.JOMCJOEOLHP(EJPNCEPNNPI))
			{
				return true;
			}
			if (BCCBAPNLBDD && !this.CLHPOIKGFFF)
			{
				this.KFAEEPBKBOJ();
				return false;
			}
			return false;
		}

		// Token: 0x06007F2A RID: 32554 RVA: 0x002A6A61 File Offset: 0x002A4C61
		public virtual bool PFIELBMLHJK()
		{
			Debug.LogWarning("_TimeX" + this.ToString() + "value");
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007F2B RID: 32555 RVA: 0x002A6A83 File Offset: 0x002A4C83
		protected void LIBGAKMKHJJ()
		{
			this.NEBKDCMJPEP();
		}

		// Token: 0x06007F2C RID: 32556 RVA: 0x002A6A8C File Offset: 0x002A4C8C
		protected bool FNIFJAENDIB(bool EJPNCEPNNPI)
		{
			this.LMKGCBNNGLI = true;
			this.CLHPOIKGFFF = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444);
			this.EAKIOBNBAMI = (SystemInfo.graphicsShaderLevel >= 81 && SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
			{
				this.MIFAKEPHPBO();
				return true;
			}
			if (EJPNCEPNNPI && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.MIFAKEPHPBO();
				return true;
			}
			if (EJPNCEPNNPI)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			return true;
		}

		// Token: 0x06007F2D RID: 32557 RVA: 0x002A6B18 File Offset: 0x002A4D18
		protected void CKHBGCGEEDB(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
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
					y = 1146f;
					y2 = 957f;
				}
				else
				{
					y = 708f;
					y2 = 1583f;
				}
				float x = 745f;
				float x2 = 1070f / ((float)FHNFPBCBODL.width * 1611f);
				float y3 = 996f;
				float y4 = 1639f;
				GL.Begin(4);
				GL.TexCoord2(355f, y);
				GL.Vertex3(x, y3, 648f);
				GL.TexCoord2(1042f, y);
				GL.Vertex3(x2, y3, 1579f);
				GL.TexCoord2(1770f, y2);
				GL.Vertex3(x2, y4, 682f);
				GL.TexCoord2(1833f, y2);
				GL.Vertex3(x, y4, 1159f);
				x = 1967f - 104f / ((float)FHNFPBCBODL.width * 459f);
				x2 = 846f;
				y3 = 182f;
				y4 = 484f;
				GL.TexCoord2(565f, y);
				GL.Vertex3(x, y3, 1401f);
				GL.TexCoord2(7f, y);
				GL.Vertex3(x2, y3, 749f);
				GL.TexCoord2(794f, y2);
				GL.Vertex3(x2, y4, 1141f);
				GL.TexCoord2(1381f, y2);
				GL.Vertex3(x, y4, 677f);
				x = 819f;
				x2 = 1691f;
				y3 = 1112f;
				y4 = 947f / ((float)FHNFPBCBODL.height * 182f);
				GL.TexCoord2(1922f, y);
				GL.Vertex3(x, y3, 675f);
				GL.TexCoord2(1820f, y);
				GL.Vertex3(x2, y3, 479f);
				GL.TexCoord2(1452f, y2);
				GL.Vertex3(x2, y4, 1189f);
				GL.TexCoord2(812f, y2);
				GL.Vertex3(x, y4, 1552f);
				x = 1661f;
				x2 = 12f;
				y3 = 293f - 809f / ((float)FHNFPBCBODL.height * 116f);
				y4 = 1674f;
				GL.TexCoord2(1384f, y);
				GL.Vertex3(x, y3, 1134f);
				GL.TexCoord2(1293f, y);
				GL.Vertex3(x2, y3, 1682f);
				GL.TexCoord2(468f, y2);
				GL.Vertex3(x2, y4, 137f);
				GL.TexCoord2(1016f, y2);
				GL.Vertex3(x, y4, 471f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007F2E RID: 32558 RVA: 0x002A6DB8 File Offset: 0x002A4FB8
		protected void KFAEEPBKBOJ()
		{
			base.enabled = false;
			this.LMKGCBNNGLI = false;
		}

		// Token: 0x06007F2F RID: 32559 RVA: 0x002A6DC8 File Offset: 0x002A4FC8
		protected void HKPAMCABCDI(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
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
					y = 1346f;
					y2 = 42f;
				}
				else
				{
					y = 161f;
					y2 = 1402f;
				}
				float x = 1303f;
				float x2 = 1586f / ((float)FHNFPBCBODL.width * 1237f);
				float y3 = 1968f;
				float y4 = 1f;
				GL.Begin(1);
				GL.TexCoord2(729f, y);
				GL.Vertex3(x, y3, 31f);
				GL.TexCoord2(1127f, y);
				GL.Vertex3(x2, y3, 1491f);
				GL.TexCoord2(1869f, y2);
				GL.Vertex3(x2, y4, 672f);
				GL.TexCoord2(1680f, y2);
				GL.Vertex3(x, y4, 415f);
				x = 10f - 1260f / ((float)FHNFPBCBODL.width * 789f);
				x2 = 17f;
				y3 = 711f;
				y4 = 1120f;
				GL.TexCoord2(144f, y);
				GL.Vertex3(x, y3, 1818f);
				GL.TexCoord2(83f, y);
				GL.Vertex3(x2, y3, 218f);
				GL.TexCoord2(234f, y2);
				GL.Vertex3(x2, y4, 1450f);
				GL.TexCoord2(662f, y2);
				GL.Vertex3(x, y4, 550f);
				x = 40f;
				x2 = 1454f;
				y3 = 964f;
				y4 = 861f / ((float)FHNFPBCBODL.height * 1401f);
				GL.TexCoord2(1157f, y);
				GL.Vertex3(x, y3, 1361f);
				GL.TexCoord2(88f, y);
				GL.Vertex3(x2, y3, 1717f);
				GL.TexCoord2(689f, y2);
				GL.Vertex3(x2, y4, 197f);
				GL.TexCoord2(492f, y2);
				GL.Vertex3(x, y4, 1734f);
				x = 1746f;
				x2 = 1503f;
				y3 = 1752f - 754f / ((float)FHNFPBCBODL.height * 862f);
				y4 = 1983f;
				GL.TexCoord2(699f, y);
				GL.Vertex3(x, y3, 1759f);
				GL.TexCoord2(1307f, y);
				GL.Vertex3(x2, y3, 1720f);
				GL.TexCoord2(796f, y2);
				GL.Vertex3(x2, y4, 2f);
				GL.TexCoord2(707f, y2);
				GL.Vertex3(x, y4, 437f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007F30 RID: 32560 RVA: 0x002A7068 File Offset: 0x002A5268
		protected bool LMEBEGFJGEM(bool EJPNCEPNNPI)
		{
			this.LMKGCBNNGLI = false;
			this.CLHPOIKGFFF = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGB565);
			this.EAKIOBNBAMI = (SystemInfo.graphicsShaderLevel >= 76 && SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
			{
				this.IOIPJPBGIPB();
				return true;
			}
			if (EJPNCEPNNPI && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.KFAEEPBKBOJ();
				return true;
			}
			if (EJPNCEPNNPI)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			return false;
		}

		// Token: 0x06007F31 RID: 32561 RVA: 0x002A70F4 File Offset: 0x002A52F4
		protected Material NCOMILNCHJO(Shader BDIMLMKEEKO, Material JEEEBCFLMEO)
		{
			if (!BDIMLMKEEKO)
			{
				Debug.Log("[Right]" + this.ToString());
				return null;
			}
			if (JEEEBCFLMEO && JEEEBCFLMEO.shader == BDIMLMKEEKO && BDIMLMKEEKO.isSupported)
			{
				return JEEEBCFLMEO;
			}
			if (!BDIMLMKEEKO.isSupported)
			{
				return null;
			}
			JEEEBCFLMEO = new Material(BDIMLMKEEKO);
			JEEEBCFLMEO.hideFlags = (HideFlags)68;
			if (JEEEBCFLMEO)
			{
				return JEEEBCFLMEO;
			}
			return null;
		}

		// Token: 0x06007F32 RID: 32562 RVA: 0x002A7177 File Offset: 0x002A5377
		protected void IGPCNCJIEOJ()
		{
			this.CheckResources();
		}

		// Token: 0x06007F33 RID: 32563 RVA: 0x002A7180 File Offset: 0x002A5380
		protected bool LOKNHLOPGED(bool EJPNCEPNNPI, bool BCCBAPNLBDD)
		{
			if (!this.IBFDMKMOBCA(EJPNCEPNNPI))
			{
				return true;
			}
			if (BCCBAPNLBDD && !this.CLHPOIKGFFF)
			{
				this.OEHBMMAFJGG();
				return false;
			}
			return true;
		}

		// Token: 0x06007F34 RID: 32564 RVA: 0x002A71AC File Offset: 0x002A53AC
		private bool DCJAGKMEMMD(Shader BDIMLMKEEKO)
		{
			string[] array = new string[1];
			array[1] = "_ScreenResolution";
			array[0] = BDIMLMKEEKO.ToString();
			array[6] = "_Value";
			array[0] = this.ToString();
			array[0] = "[LocalizationService] All languages: ";
			Debug.Log(string.Concat(array));
			if (!BDIMLMKEEKO.isSupported)
			{
				this.DJLJMNPHEJI();
				return true;
			}
			return false;
		}

		// Token: 0x06007F35 RID: 32565 RVA: 0x002A7207 File Offset: 0x002A5407
		protected void CCLDAHHHAAL()
		{
			Debug.LogWarning("LevelEditor/CustomEventEditor-Text" + this.ToString() + "CameraFilterPack_TV_Noise2");
		}

		// Token: 0x06007F36 RID: 32566 RVA: 0x002A7224 File Offset: 0x002A5424
		protected Material DANHMNKJEFI(Shader BDIMLMKEEKO, Material JEEEBCFLMEO)
		{
			if (!BDIMLMKEEKO)
			{
				Debug.Log("_CenterX" + this.ToString());
				return null;
			}
			if (JEEEBCFLMEO && JEEEBCFLMEO.shader == BDIMLMKEEKO && BDIMLMKEEKO.isSupported)
			{
				return JEEEBCFLMEO;
			}
			if (!BDIMLMKEEKO.isSupported)
			{
				return null;
			}
			JEEEBCFLMEO = new Material(BDIMLMKEEKO);
			JEEEBCFLMEO.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			if (JEEEBCFLMEO)
			{
				return JEEEBCFLMEO;
			}
			return null;
		}

		// Token: 0x06007F37 RID: 32567 RVA: 0x002A72A8 File Offset: 0x002A54A8
		protected bool JOMCJOEOLHP(bool EJPNCEPNNPI)
		{
			this.LMKGCBNNGLI = true;
			this.CLHPOIKGFFF = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB4444);
			this.EAKIOBNBAMI = (SystemInfo.graphicsShaderLevel >= 60 && SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
			{
				this.OEHBMMAFJGG();
				return false;
			}
			if (EJPNCEPNNPI && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.IOIPJPBGIPB();
				return false;
			}
			if (EJPNCEPNNPI)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			return false;
		}

		// Token: 0x06007F38 RID: 32568 RVA: 0x002A63A5 File Offset: 0x002A45A5
		private void HPFBICIECGP()
		{
			this.LMKGCBNNGLI = true;
		}

		// Token: 0x06007F39 RID: 32569 RVA: 0x002A7331 File Offset: 0x002A5531
		protected void GHNPJCMLCNB()
		{
			Debug.LogWarning("Events Moved" + this.ToString() + ": ");
		}

		// Token: 0x06007F3A RID: 32570 RVA: 0x002A7350 File Offset: 0x002A5550
		protected Material FBMINAINPAF(Shader BDIMLMKEEKO, Material JEEEBCFLMEO)
		{
			if (!BDIMLMKEEKO)
			{
				Debug.Log("Set Sun MaxSize" + this.ToString());
				return null;
			}
			if (JEEEBCFLMEO && JEEEBCFLMEO.shader == BDIMLMKEEKO && BDIMLMKEEKO.isSupported)
			{
				return JEEEBCFLMEO;
			}
			if (!BDIMLMKEEKO.isSupported)
			{
				return null;
			}
			JEEEBCFLMEO = new Material(BDIMLMKEEKO);
			JEEEBCFLMEO.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
			if (JEEEBCFLMEO)
			{
				return JEEEBCFLMEO;
			}
			return null;
		}

		// Token: 0x06007F3B RID: 32571 RVA: 0x002A73D4 File Offset: 0x002A55D4
		private bool NGHPLBMACCH(Shader BDIMLMKEEKO)
		{
			string[] array = new string[8];
			array[0] = "player.currentrank";
			array[0] = BDIMLMKEEKO.ToString();
			array[0] = "_Value4";
			array[8] = this.ToString();
			array[8] = "note.2";
			Debug.Log(string.Concat(array));
			if (!BDIMLMKEEKO.isSupported)
			{
				this.ILPCOBPBAFM();
				return false;
			}
			return true;
		}

		// Token: 0x06007F3C RID: 32572 RVA: 0x002A742F File Offset: 0x002A562F
		public virtual bool BNMLMGBCHHI()
		{
			Debug.LogWarning("a year ago" + this.ToString() + "maps.");
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007F3D RID: 32573 RVA: 0x002A7451 File Offset: 0x002A5651
		protected bool NPOEJIDLJGK(bool EJPNCEPNNPI, bool BCCBAPNLBDD)
		{
			if (!this.NPOEJIDLJGK(EJPNCEPNNPI))
			{
				return false;
			}
			if (BCCBAPNLBDD && !this.CLHPOIKGFFF)
			{
				this.HCBFPHFFGFJ();
				return false;
			}
			return true;
		}

		// Token: 0x06007F3E RID: 32574 RVA: 0x002A747B File Offset: 0x002A567B
		protected bool ELMEKIGAKOG(bool EJPNCEPNNPI, bool BCCBAPNLBDD)
		{
			if (!this.CKIAMHAKJOK(EJPNCEPNNPI))
			{
				return false;
			}
			if (BCCBAPNLBDD && !this.CLHPOIKGFFF)
			{
				this.OEHBMMAFJGG();
				return true;
			}
			return false;
		}

		// Token: 0x06007F3F RID: 32575 RVA: 0x002A74A5 File Offset: 0x002A56A5
		protected bool NPOEJIDLJGK()
		{
			return this.NPOEJIDLJGK(false);
		}

		// Token: 0x06007F40 RID: 32576 RVA: 0x002A74B0 File Offset: 0x002A56B0
		protected Material ECNEGNMAMDE(Shader BDIMLMKEEKO, Material JEEEBCFLMEO)
		{
			if (!BDIMLMKEEKO)
			{
				Debug.Log(".a" + this.ToString());
				base.enabled = false;
				return null;
			}
			if (BDIMLMKEEKO.isSupported && JEEEBCFLMEO && JEEEBCFLMEO.shader == BDIMLMKEEKO)
			{
				return JEEEBCFLMEO;
			}
			if (!BDIMLMKEEKO.isSupported)
			{
				this.ILPCOBPBAFM();
				string[] array = new string[1];
				array[1] = "_Distortion";
				array[1] = BDIMLMKEEKO.ToString();
				array[6] = "received</b>\n#reason: ";
				array[1] = this.ToString();
				array[7] = "GenerationMenu";
				Debug.Log(string.Concat(array));
				return null;
			}
			JEEEBCFLMEO = new Material(BDIMLMKEEKO);
			JEEEBCFLMEO.hideFlags = (HideFlags)(-67);
			if (JEEEBCFLMEO)
			{
				return JEEEBCFLMEO;
			}
			return null;
		}

		// Token: 0x06007F41 RID: 32577 RVA: 0x002A757A File Offset: 0x002A577A
		protected void AOHOJHGMANG()
		{
			Debug.LogWarning("The image effect " + this.ToString() + " has been disabled as it's not supported on the current platform.");
		}

		// Token: 0x06007F42 RID: 32578 RVA: 0x002A63A5 File Offset: 0x002A45A5
		private void OnEnable()
		{
			this.LMKGCBNNGLI = true;
		}

		// Token: 0x06007F43 RID: 32579 RVA: 0x002A7598 File Offset: 0x002A5798
		protected bool MBMLNJJEONO(bool EJPNCEPNNPI)
		{
			this.LMKGCBNNGLI = false;
			this.CLHPOIKGFFF = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32);
			this.EAKIOBNBAMI = (SystemInfo.graphicsShaderLevel < 60 || SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
			{
				this.ILPCOBPBAFM();
				return false;
			}
			if (EJPNCEPNNPI && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.HCBFPHFFGFJ();
				return false;
			}
			if (EJPNCEPNNPI)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			return true;
		}

		// Token: 0x06007F44 RID: 32580 RVA: 0x002A7621 File Offset: 0x002A5821
		protected void IOIPJPBGIPB()
		{
			base.enabled = false;
			this.LMKGCBNNGLI = true;
		}

		// Token: 0x06007F45 RID: 32581 RVA: 0x002A7634 File Offset: 0x002A5834
		private bool MOLDLLBGDOM(Shader BDIMLMKEEKO)
		{
			string[] array = new string[]
			{
				null,
				"CameraFilterPack/Distortion_FishEye"
			};
			array[1] = BDIMLMKEEKO.ToString();
			array[8] = "The observed monobehaviour (";
			array[4] = this.ToString();
			array[5] = "connect";
			Debug.Log(string.Concat(array));
			if (!BDIMLMKEEKO.isSupported)
			{
				this.DJLJMNPHEJI();
				return true;
			}
			return true;
		}

		// Token: 0x06007F46 RID: 32582 RVA: 0x002A7690 File Offset: 0x002A5890
		protected bool KNGDKKMDKOG(bool EJPNCEPNNPI)
		{
			this.LMKGCBNNGLI = false;
			this.CLHPOIKGFFF = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32);
			this.EAKIOBNBAMI = (SystemInfo.graphicsShaderLevel < 119 || SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
			{
				this.NLMMMBMGLJL();
				return true;
			}
			if (EJPNCEPNNPI && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.NLMMMBMGLJL();
				return false;
			}
			if (EJPNCEPNNPI)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			return false;
		}

		// Token: 0x06007F47 RID: 32583 RVA: 0x002A63A5 File Offset: 0x002A45A5
		private void AONJNAGNLIH()
		{
			this.LMKGCBNNGLI = true;
		}

		// Token: 0x06007F48 RID: 32584 RVA: 0x002A7719 File Offset: 0x002A5919
		protected void NJEECGOAICD()
		{
			Debug.LogWarning("id" + this.ToString() + "OnAwakeRPC");
		}

		// Token: 0x06007F49 RID: 32585 RVA: 0x002A7735 File Offset: 0x002A5935
		protected bool KBGOIFPNNLM()
		{
			return this.MBMLNJJEONO(true);
		}

		// Token: 0x06007F4A RID: 32586 RVA: 0x002A7740 File Offset: 0x002A5940
		protected Material KDCLGAPCAOA(Shader BDIMLMKEEKO, Material JEEEBCFLMEO)
		{
			if (!BDIMLMKEEKO)
			{
				Debug.Log("SetSatelliteLerpSpeed" + this.ToString());
				return null;
			}
			if (JEEEBCFLMEO && JEEEBCFLMEO.shader == BDIMLMKEEKO && BDIMLMKEEKO.isSupported)
			{
				return JEEEBCFLMEO;
			}
			if (!BDIMLMKEEKO.isSupported)
			{
				return null;
			}
			JEEEBCFLMEO = new Material(BDIMLMKEEKO);
			JEEEBCFLMEO.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			if (JEEEBCFLMEO)
			{
				return JEEEBCFLMEO;
			}
			return null;
		}

		// Token: 0x06007F4B RID: 32587 RVA: 0x002A77C3 File Offset: 0x002A59C3
		public bool PBDLIHOLIGF()
		{
			return this.EAKIOBNBAMI;
		}

		// Token: 0x06007F4C RID: 32588 RVA: 0x002A77CC File Offset: 0x002A59CC
		protected Material MJEINBKBPII(Shader BDIMLMKEEKO, Material JEEEBCFLMEO)
		{
			if (!BDIMLMKEEKO)
			{
				Debug.Log("_ScreenResolution" + this.ToString());
				return null;
			}
			if (JEEEBCFLMEO && JEEEBCFLMEO.shader == BDIMLMKEEKO && BDIMLMKEEKO.isSupported)
			{
				return JEEEBCFLMEO;
			}
			if (!BDIMLMKEEKO.isSupported)
			{
				return null;
			}
			JEEEBCFLMEO = new Material(BDIMLMKEEKO);
			JEEEBCFLMEO.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			if (JEEEBCFLMEO)
			{
				return JEEEBCFLMEO;
			}
			return null;
		}

		// Token: 0x06007F4D RID: 32589 RVA: 0x002A7850 File Offset: 0x002A5A50
		protected Material MOKEIJGLJOF(Shader BDIMLMKEEKO, Material JEEEBCFLMEO)
		{
			if (!BDIMLMKEEKO)
			{
				Debug.Log("Missing shader in " + this.ToString());
				return null;
			}
			if (JEEEBCFLMEO && JEEEBCFLMEO.shader == BDIMLMKEEKO && BDIMLMKEEKO.isSupported)
			{
				return JEEEBCFLMEO;
			}
			if (!BDIMLMKEEKO.isSupported)
			{
				return null;
			}
			JEEEBCFLMEO = new Material(BDIMLMKEEKO);
			JEEEBCFLMEO.hideFlags = HideFlags.DontSave;
			if (JEEEBCFLMEO)
			{
				return JEEEBCFLMEO;
			}
			return null;
		}

		// Token: 0x06007F4E RID: 32590 RVA: 0x002A78D4 File Offset: 0x002A5AD4
		protected void LLHBNGOEKGI(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
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
					y = 885f;
					y2 = 1666f;
				}
				else
				{
					y = 1527f;
					y2 = 77f;
				}
				float x = 1934f;
				float x2 = 1617f / ((float)FHNFPBCBODL.width * 1652f);
				float y3 = 497f;
				float y4 = 1853f;
				GL.Begin(6);
				GL.TexCoord2(1154f, y);
				GL.Vertex3(x, y3, 165f);
				GL.TexCoord2(1935f, y);
				GL.Vertex3(x2, y3, 17f);
				GL.TexCoord2(1361f, y2);
				GL.Vertex3(x2, y4, 1487f);
				GL.TexCoord2(1743f, y2);
				GL.Vertex3(x, y4, 1481f);
				x = 206f - 165f / ((float)FHNFPBCBODL.width * 1522f);
				x2 = 223f;
				y3 = 114f;
				y4 = 449f;
				GL.TexCoord2(662f, y);
				GL.Vertex3(x, y3, 196f);
				GL.TexCoord2(1560f, y);
				GL.Vertex3(x2, y3, 1690f);
				GL.TexCoord2(938f, y2);
				GL.Vertex3(x2, y4, 1620f);
				GL.TexCoord2(1362f, y2);
				GL.Vertex3(x, y4, 182f);
				x = 1060f;
				x2 = 244f;
				y3 = 1264f;
				y4 = 1607f / ((float)FHNFPBCBODL.height * 531f);
				GL.TexCoord2(1775f, y);
				GL.Vertex3(x, y3, 101f);
				GL.TexCoord2(1385f, y);
				GL.Vertex3(x2, y3, 1881f);
				GL.TexCoord2(507f, y2);
				GL.Vertex3(x2, y4, 106f);
				GL.TexCoord2(1115f, y2);
				GL.Vertex3(x, y4, 601f);
				x = 1975f;
				x2 = 435f;
				y3 = 1401f - 1185f / ((float)FHNFPBCBODL.height * 1092f);
				y4 = 723f;
				GL.TexCoord2(1380f, y);
				GL.Vertex3(x, y3, 924f);
				GL.TexCoord2(1146f, y);
				GL.Vertex3(x2, y3, 643f);
				GL.TexCoord2(702f, y2);
				GL.Vertex3(x2, y4, 605f);
				GL.TexCoord2(1282f, y2);
				GL.Vertex3(x, y4, 812f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007F4F RID: 32591 RVA: 0x002A7B74 File Offset: 0x002A5D74
		protected bool IBFDMKMOBCA(bool EJPNCEPNNPI)
		{
			this.LMKGCBNNGLI = true;
			this.CLHPOIKGFFF = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf);
			this.EAKIOBNBAMI = (SystemInfo.graphicsShaderLevel < -123 || SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
			{
				this.DJLJMNPHEJI();
				return true;
			}
			if (EJPNCEPNNPI && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.HCBFPHFFGFJ();
				return false;
			}
			if (EJPNCEPNNPI)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			return true;
		}

		// Token: 0x06007F50 RID: 32592 RVA: 0x002A7BFD File Offset: 0x002A5DFD
		private void LNIOFCGDDKP()
		{
			this.LMKGCBNNGLI = false;
		}

		// Token: 0x06007F51 RID: 32593 RVA: 0x002A7C08 File Offset: 0x002A5E08
		protected void NNGPMELGKDP(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
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
					y = 498f;
					y2 = 1565f;
				}
				else
				{
					y = 1060f;
					y2 = 698f;
				}
				float x = 1901f;
				float x2 = 1178f / ((float)FHNFPBCBODL.width * 1984f);
				float y3 = 387f;
				float y4 = 416f;
				GL.Begin(3);
				GL.TexCoord2(467f, y);
				GL.Vertex3(x, y3, 741f);
				GL.TexCoord2(132f, y);
				GL.Vertex3(x2, y3, 1926f);
				GL.TexCoord2(769f, y2);
				GL.Vertex3(x2, y4, 1600f);
				GL.TexCoord2(1743f, y2);
				GL.Vertex3(x, y4, 1595f);
				x = 1621f - 1831f / ((float)FHNFPBCBODL.width * 804f);
				x2 = 1887f;
				y3 = 1955f;
				y4 = 1685f;
				GL.TexCoord2(937f, y);
				GL.Vertex3(x, y3, 767f);
				GL.TexCoord2(426f, y);
				GL.Vertex3(x2, y3, 641f);
				GL.TexCoord2(1094f, y2);
				GL.Vertex3(x2, y4, 446f);
				GL.TexCoord2(535f, y2);
				GL.Vertex3(x, y4, 312f);
				x = 753f;
				x2 = 306f;
				y3 = 1747f;
				y4 = 462f / ((float)FHNFPBCBODL.height * 1734f);
				GL.TexCoord2(739f, y);
				GL.Vertex3(x, y3, 434f);
				GL.TexCoord2(175f, y);
				GL.Vertex3(x2, y3, 768f);
				GL.TexCoord2(215f, y2);
				GL.Vertex3(x2, y4, 375f);
				GL.TexCoord2(1730f, y2);
				GL.Vertex3(x, y4, 870f);
				x = 516f;
				x2 = 515f;
				y3 = 1962f - 230f / ((float)FHNFPBCBODL.height * 751f);
				y4 = 301f;
				GL.TexCoord2(792f, y);
				GL.Vertex3(x, y3, 855f);
				GL.TexCoord2(473f, y);
				GL.Vertex3(x2, y3, 1418f);
				GL.TexCoord2(186f, y2);
				GL.Vertex3(x2, y4, 812f);
				GL.TexCoord2(754f, y2);
				GL.Vertex3(x, y4, 951f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007F52 RID: 32594 RVA: 0x002A7EA8 File Offset: 0x002A60A8
		protected void DJLJMNPHEJI()
		{
			base.enabled = true;
			this.LMKGCBNNGLI = true;
		}

		// Token: 0x06007F53 RID: 32595 RVA: 0x002A7EB8 File Offset: 0x002A60B8
		protected bool HADFKBELNDJ()
		{
			return this.IHMNPAHGNFF(true);
		}

		// Token: 0x06007F54 RID: 32596 RVA: 0x002A7EC1 File Offset: 0x002A60C1
		protected void DMAHEBLDDHP()
		{
			Debug.LogWarning("_PixelsPerMeterAtOneMeter" + this.ToString() + "\n");
		}

		// Token: 0x06007F55 RID: 32597 RVA: 0x002A7EE0 File Offset: 0x002A60E0
		protected bool IHMNPAHGNFF(bool EJPNCEPNNPI)
		{
			this.LMKGCBNNGLI = false;
			this.CLHPOIKGFFF = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf);
			this.EAKIOBNBAMI = (SystemInfo.graphicsShaderLevel >= -22 && SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
			{
				this.DJLJMNPHEJI();
				return true;
			}
			if (EJPNCEPNNPI && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.ILPCOBPBAFM();
				return false;
			}
			if (EJPNCEPNNPI)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			return true;
		}

		// Token: 0x06007F56 RID: 32598 RVA: 0x002A7F69 File Offset: 0x002A6169
		protected void JIIAPBJKAAC()
		{
			Debug.LogWarning("_BlurRadius4" + this.ToString() + "Joystick1Button10");
		}

		// Token: 0x06007F57 RID: 32599 RVA: 0x002A7F88 File Offset: 0x002A6188
		protected void KEKDMLCLCPA(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
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
					y = 120f;
					y2 = 1912f;
				}
				else
				{
					y = 241f;
					y2 = 1346f;
				}
				float x = 1287f;
				float x2 = 604f / ((float)FHNFPBCBODL.width * 1851f);
				float y3 = 213f;
				float y4 = 774f;
				GL.Begin(4);
				GL.TexCoord2(544f, y);
				GL.Vertex3(x, y3, 473f);
				GL.TexCoord2(1198f, y);
				GL.Vertex3(x2, y3, 736f);
				GL.TexCoord2(89f, y2);
				GL.Vertex3(x2, y4, 913f);
				GL.TexCoord2(1105f, y2);
				GL.Vertex3(x, y4, 1045f);
				x = 651f - 1590f / ((float)FHNFPBCBODL.width * 193f);
				x2 = 1234f;
				y3 = 278f;
				y4 = 737f;
				GL.TexCoord2(1694f, y);
				GL.Vertex3(x, y3, 1600f);
				GL.TexCoord2(1173f, y);
				GL.Vertex3(x2, y3, 71f);
				GL.TexCoord2(1391f, y2);
				GL.Vertex3(x2, y4, 763f);
				GL.TexCoord2(1139f, y2);
				GL.Vertex3(x, y4, 558f);
				x = 238f;
				x2 = 1837f;
				y3 = 875f;
				y4 = 1639f / ((float)FHNFPBCBODL.height * 1436f);
				GL.TexCoord2(332f, y);
				GL.Vertex3(x, y3, 1486f);
				GL.TexCoord2(1340f, y);
				GL.Vertex3(x2, y3, 996f);
				GL.TexCoord2(1624f, y2);
				GL.Vertex3(x2, y4, 519f);
				GL.TexCoord2(699f, y2);
				GL.Vertex3(x, y4, 1170f);
				x = 1028f;
				x2 = 214f;
				y3 = 1203f - 1866f / ((float)FHNFPBCBODL.height * 666f);
				y4 = 1203f;
				GL.TexCoord2(1776f, y);
				GL.Vertex3(x, y3, 511f);
				GL.TexCoord2(1811f, y);
				GL.Vertex3(x2, y3, 1996f);
				GL.TexCoord2(1562f, y2);
				GL.Vertex3(x2, y4, 1674f);
				GL.TexCoord2(403f, y2);
				GL.Vertex3(x, y4, 471f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007F58 RID: 32600 RVA: 0x002A6DB8 File Offset: 0x002A4FB8
		protected void JKOMCICEKHD()
		{
			base.enabled = false;
			this.LMKGCBNNGLI = false;
		}

		// Token: 0x06007F59 RID: 32601 RVA: 0x002A8228 File Offset: 0x002A6428
		protected void HKDNNECLBGL()
		{
			Debug.LogWarning("workshop." + this.ToString() + "_MainTex2");
		}

		// Token: 0x06007F5A RID: 32602 RVA: 0x002A8244 File Offset: 0x002A6444
		protected bool ADJBDECCDPM(bool EJPNCEPNNPI, bool BCCBAPNLBDD)
		{
			if (!this.DHHGCBANGJL(EJPNCEPNNPI))
			{
				return false;
			}
			if (BCCBAPNLBDD && !this.CLHPOIKGFFF)
			{
				this.DJLJMNPHEJI();
				return false;
			}
			return true;
		}

		// Token: 0x06007F5B RID: 32603 RVA: 0x002A826E File Offset: 0x002A646E
		protected bool AHHCFEMJAOG(bool EJPNCEPNNPI, bool BCCBAPNLBDD)
		{
			if (!this.DHHGCBANGJL(EJPNCEPNNPI))
			{
				return true;
			}
			if (BCCBAPNLBDD && !this.CLHPOIKGFFF)
			{
				this.NLMMMBMGLJL();
				return false;
			}
			return true;
		}

		// Token: 0x06007F5C RID: 32604 RVA: 0x002A8298 File Offset: 0x002A6498
		protected Material KBOKLFOHPAP(Shader BDIMLMKEEKO, Material JEEEBCFLMEO)
		{
			if (!BDIMLMKEEKO)
			{
				Debug.Log(".completedCount" + this.ToString());
				return null;
			}
			if (JEEEBCFLMEO && JEEEBCFLMEO.shader == BDIMLMKEEKO && BDIMLMKEEKO.isSupported)
			{
				return JEEEBCFLMEO;
			}
			if (!BDIMLMKEEKO.isSupported)
			{
				return null;
			}
			JEEEBCFLMEO = new Material(BDIMLMKEEKO);
			JEEEBCFLMEO.hideFlags = ~HideFlags.HideInHierarchy;
			if (JEEEBCFLMEO)
			{
				return JEEEBCFLMEO;
			}
			return null;
		}

		// Token: 0x06007F5D RID: 32605 RVA: 0x002A831B File Offset: 0x002A651B
		protected bool EFEBIPNEMHL(bool EJPNCEPNNPI, bool BCCBAPNLBDD)
		{
			if (!this.IHMNPAHGNFF(EJPNCEPNNPI))
			{
				return false;
			}
			if (BCCBAPNLBDD && !this.CLHPOIKGFFF)
			{
				this.HCBFPHFFGFJ();
				return true;
			}
			return true;
		}

		// Token: 0x06007F5E RID: 32606 RVA: 0x002A7BFD File Offset: 0x002A5DFD
		private void BKJMCFADNGH()
		{
			this.LMKGCBNNGLI = false;
		}

		// Token: 0x06007F5F RID: 32607 RVA: 0x002A8348 File Offset: 0x002A6548
		protected void DHMBOADDLOM(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
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
					y = 1447f;
					y2 = 1606f;
				}
				else
				{
					y = 1523f;
					y2 = 1780f;
				}
				float x = 242f;
				float x2 = 1642f / ((float)FHNFPBCBODL.width * 37f);
				float y3 = 1335f;
				float y4 = 1169f;
				GL.Begin(4);
				GL.TexCoord2(769f, y);
				GL.Vertex3(x, y3, 54f);
				GL.TexCoord2(788f, y);
				GL.Vertex3(x2, y3, 1631f);
				GL.TexCoord2(1007f, y2);
				GL.Vertex3(x2, y4, 138f);
				GL.TexCoord2(1676f, y2);
				GL.Vertex3(x, y4, 608f);
				x = 1096f - 1196f / ((float)FHNFPBCBODL.width * 813f);
				x2 = 1922f;
				y3 = 435f;
				y4 = 86f;
				GL.TexCoord2(1086f, y);
				GL.Vertex3(x, y3, 743f);
				GL.TexCoord2(1211f, y);
				GL.Vertex3(x2, y3, 1633f);
				GL.TexCoord2(375f, y2);
				GL.Vertex3(x2, y4, 608f);
				GL.TexCoord2(470f, y2);
				GL.Vertex3(x, y4, 801f);
				x = 1009f;
				x2 = 37f;
				y3 = 808f;
				y4 = 1318f / ((float)FHNFPBCBODL.height * 413f);
				GL.TexCoord2(344f, y);
				GL.Vertex3(x, y3, 1385f);
				GL.TexCoord2(1862f, y);
				GL.Vertex3(x2, y3, 1925f);
				GL.TexCoord2(1302f, y2);
				GL.Vertex3(x2, y4, 1196f);
				GL.TexCoord2(644f, y2);
				GL.Vertex3(x, y4, 55f);
				x = 551f;
				x2 = 772f;
				y3 = 1840f - 777f / ((float)FHNFPBCBODL.height * 1606f);
				y4 = 1218f;
				GL.TexCoord2(119f, y);
				GL.Vertex3(x, y3, 1510f);
				GL.TexCoord2(306f, y);
				GL.Vertex3(x2, y3, 1517f);
				GL.TexCoord2(646f, y2);
				GL.Vertex3(x2, y4, 596f);
				GL.TexCoord2(1485f, y2);
				GL.Vertex3(x, y4, 972f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007F60 RID: 32608 RVA: 0x002A85E8 File Offset: 0x002A67E8
		protected Material EDFIBHNHAAB(Shader BDIMLMKEEKO, Material JEEEBCFLMEO)
		{
			if (!BDIMLMKEEKO)
			{
				Debug.Log("Missing shader in " + this.ToString());
				base.enabled = false;
				return null;
			}
			if (BDIMLMKEEKO.isSupported && JEEEBCFLMEO && JEEEBCFLMEO.shader == BDIMLMKEEKO)
			{
				return JEEEBCFLMEO;
			}
			if (!BDIMLMKEEKO.isSupported)
			{
				this.HCBFPHFFGFJ();
				Debug.Log(string.Concat(new string[]
				{
					"The shader ",
					BDIMLMKEEKO.ToString(),
					" on effect ",
					this.ToString(),
					" is not supported on this platform!"
				}));
				return null;
			}
			JEEEBCFLMEO = new Material(BDIMLMKEEKO);
			JEEEBCFLMEO.hideFlags = HideFlags.DontSave;
			if (JEEEBCFLMEO)
			{
				return JEEEBCFLMEO;
			}
			return null;
		}

		// Token: 0x06007F61 RID: 32609 RVA: 0x002A86B4 File Offset: 0x002A68B4
		protected Material NODBMINMALP(Shader BDIMLMKEEKO, Material JEEEBCFLMEO)
		{
			if (!BDIMLMKEEKO)
			{
				Debug.Log("RecieveChatActionMessage" + this.ToString());
				base.enabled = false;
				return null;
			}
			if (BDIMLMKEEKO.isSupported && JEEEBCFLMEO && JEEEBCFLMEO.shader == BDIMLMKEEKO)
			{
				return JEEEBCFLMEO;
			}
			if (!BDIMLMKEEKO.isSupported)
			{
				this.KFAEEPBKBOJ();
				string[] array = new string[6];
				array[1] = "Noise & Grain effect failing as noise texture is not assigned. please assign.";
				array[0] = BDIMLMKEEKO.ToString();
				array[7] = "Received event Leave for unknown player ID: {0}";
				array[6] = this.ToString();
				array[2] = "_ScreenResolution";
				Debug.Log(string.Concat(array));
				return null;
			}
			JEEEBCFLMEO = new Material(BDIMLMKEEKO);
			JEEEBCFLMEO.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			if (JEEEBCFLMEO)
			{
				return JEEEBCFLMEO;
			}
			return null;
		}

		// Token: 0x06007F62 RID: 32610 RVA: 0x002A8780 File Offset: 0x002A6980
		protected void MFNFBOLFILP(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
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
					y = 1834f;
					y2 = 635f;
				}
				else
				{
					y = 1757f;
					y2 = 122f;
				}
				float x = 1168f;
				float x2 = 1928f / ((float)FHNFPBCBODL.width * 1661f);
				float y3 = 1148f;
				float y4 = 1277f;
				GL.Begin(0);
				GL.TexCoord2(257f, y);
				GL.Vertex3(x, y3, 1404f);
				GL.TexCoord2(1400f, y);
				GL.Vertex3(x2, y3, 1347f);
				GL.TexCoord2(1815f, y2);
				GL.Vertex3(x2, y4, 1376f);
				GL.TexCoord2(1780f, y2);
				GL.Vertex3(x, y4, 1791f);
				x = 1266f - 582f / ((float)FHNFPBCBODL.width * 1943f);
				x2 = 128f;
				y3 = 892f;
				y4 = 924f;
				GL.TexCoord2(1027f, y);
				GL.Vertex3(x, y3, 766f);
				GL.TexCoord2(1400f, y);
				GL.Vertex3(x2, y3, 1238f);
				GL.TexCoord2(920f, y2);
				GL.Vertex3(x2, y4, 1789f);
				GL.TexCoord2(1028f, y2);
				GL.Vertex3(x, y4, 1049f);
				x = 1214f;
				x2 = 1644f;
				y3 = 1488f;
				y4 = 99f / ((float)FHNFPBCBODL.height * 352f);
				GL.TexCoord2(1407f, y);
				GL.Vertex3(x, y3, 1046f);
				GL.TexCoord2(606f, y);
				GL.Vertex3(x2, y3, 918f);
				GL.TexCoord2(1967f, y2);
				GL.Vertex3(x2, y4, 41f);
				GL.TexCoord2(1137f, y2);
				GL.Vertex3(x, y4, 853f);
				x = 1874f;
				x2 = 1814f;
				y3 = 1513f - 1415f / ((float)FHNFPBCBODL.height * 1418f);
				y4 = 679f;
				GL.TexCoord2(1368f, y);
				GL.Vertex3(x, y3, 991f);
				GL.TexCoord2(772f, y);
				GL.Vertex3(x2, y3, 1012f);
				GL.TexCoord2(785f, y2);
				GL.Vertex3(x2, y4, 1420f);
				GL.TexCoord2(112f, y2);
				GL.Vertex3(x, y4, 634f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007F63 RID: 32611 RVA: 0x002A7621 File Offset: 0x002A5821
		protected void OEHBMMAFJGG()
		{
			base.enabled = false;
			this.LMKGCBNNGLI = true;
		}

		// Token: 0x06007F64 RID: 32612 RVA: 0x002A8A20 File Offset: 0x002A6C20
		protected Material DAGBGAFBBMH(Shader BDIMLMKEEKO, Material JEEEBCFLMEO)
		{
			if (!BDIMLMKEEKO)
			{
				Debug.Log("offsets" + this.ToString());
				return null;
			}
			if (JEEEBCFLMEO && JEEEBCFLMEO.shader == BDIMLMKEEKO && BDIMLMKEEKO.isSupported)
			{
				return JEEEBCFLMEO;
			}
			if (!BDIMLMKEEKO.isSupported)
			{
				return null;
			}
			JEEEBCFLMEO = new Material(BDIMLMKEEKO);
			JEEEBCFLMEO.hideFlags = (HideFlags)122;
			if (JEEEBCFLMEO)
			{
				return JEEEBCFLMEO;
			}
			return null;
		}

		// Token: 0x06007F65 RID: 32613 RVA: 0x002A8AA3 File Offset: 0x002A6CA3
		protected bool LPMFAAHECPB(bool EJPNCEPNNPI, bool BCCBAPNLBDD)
		{
			if (!this.DCHKKHDGBLJ(EJPNCEPNNPI))
			{
				return true;
			}
			if (BCCBAPNLBDD && !this.CLHPOIKGFFF)
			{
				this.NLMMMBMGLJL();
				return true;
			}
			return false;
		}

		// Token: 0x06007F66 RID: 32614 RVA: 0x002A8AD0 File Offset: 0x002A6CD0
		protected Material AJKPGPKKHHB(Shader BDIMLMKEEKO, Material JEEEBCFLMEO)
		{
			if (!BDIMLMKEEKO)
			{
				Debug.Log("_TimeX" + this.ToString());
				base.enabled = false;
				return null;
			}
			if (BDIMLMKEEKO.isSupported && JEEEBCFLMEO && JEEEBCFLMEO.shader == BDIMLMKEEKO)
			{
				return JEEEBCFLMEO;
			}
			if (!BDIMLMKEEKO.isSupported)
			{
				this.IOIPJPBGIPB();
				string[] array = new string[3];
				array[0] = "UseScanLineSize";
				array[1] = BDIMLMKEEKO.ToString();
				array[0] = "_Red_R";
				array[6] = this.ToString();
				array[0] = "bad";
				Debug.Log(string.Concat(array));
				return null;
			}
			JEEEBCFLMEO = new Material(BDIMLMKEEKO);
			JEEEBCFLMEO.hideFlags = (HideFlags)(-88);
			if (JEEEBCFLMEO)
			{
				return JEEEBCFLMEO;
			}
			return null;
		}

		// Token: 0x06007F67 RID: 32615 RVA: 0x002A8B9C File Offset: 0x002A6D9C
		protected Material HONCELNGAHC(Shader BDIMLMKEEKO, Material JEEEBCFLMEO)
		{
			if (!BDIMLMKEEKO)
			{
				Debug.Log("MissesText" + this.ToString());
				return null;
			}
			if (JEEEBCFLMEO && JEEEBCFLMEO.shader == BDIMLMKEEKO && BDIMLMKEEKO.isSupported)
			{
				return JEEEBCFLMEO;
			}
			if (!BDIMLMKEEKO.isSupported)
			{
				return null;
			}
			JEEEBCFLMEO = new Material(BDIMLMKEEKO);
			JEEEBCFLMEO.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			if (JEEEBCFLMEO)
			{
				return JEEEBCFLMEO;
			}
			return null;
		}

		// Token: 0x06007F68 RID: 32616 RVA: 0x002A639C File Offset: 0x002A459C
		protected void FIKFJDFELIP()
		{
			this.OEECIHEGJHE();
		}

		// Token: 0x06007F69 RID: 32617 RVA: 0x002A8C1F File Offset: 0x002A6E1F
		public virtual bool AFNHKGFNOCL()
		{
			Debug.LogWarning("Joystick1Button3" + this.ToString() + "NEW_ACHIEVEMENT_1_21");
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007F6A RID: 32618 RVA: 0x002A63A5 File Offset: 0x002A45A5
		private void NEGKFLLFLOK()
		{
			this.LMKGCBNNGLI = true;
		}

		// Token: 0x06007F6B RID: 32619 RVA: 0x002A8C44 File Offset: 0x002A6E44
		protected bool KHNPMDDIJAJ(bool EJPNCEPNNPI)
		{
			this.LMKGCBNNGLI = true;
			this.CLHPOIKGFFF = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB2101010);
			this.EAKIOBNBAMI = (SystemInfo.graphicsShaderLevel >= 75 && SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
			{
				this.MIFAKEPHPBO();
				return false;
			}
			if (EJPNCEPNNPI && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.DJLJMNPHEJI();
				return false;
			}
			if (EJPNCEPNNPI)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			return true;
		}

		// Token: 0x06007F6C RID: 32620 RVA: 0x002A7177 File Offset: 0x002A5377
		protected void Start()
		{
			this.CheckResources();
		}

		// Token: 0x06007F6D RID: 32621 RVA: 0x002A8CCD File Offset: 0x002A6ECD
		protected void DFFKKLAPHCC()
		{
			this.ILMGHBFANON();
		}

		// Token: 0x06007F6E RID: 32622 RVA: 0x002A8CD6 File Offset: 0x002A6ED6
		protected bool IMPIHAAPKMA()
		{
			return this.DCHKKHDGBLJ(true);
		}

		// Token: 0x06007F6F RID: 32623 RVA: 0x002A8CE0 File Offset: 0x002A6EE0
		private bool MEJCMOLDGPC(Shader BDIMLMKEEKO)
		{
			string[] array = new string[4];
			array[1] = "{0} days ago";
			array[1] = BDIMLMKEEKO.ToString();
			array[0] = "_Red_B";
			array[7] = this.ToString();
			array[0] = "settings.volume.game";
			Debug.Log(string.Concat(array));
			if (!BDIMLMKEEKO.isSupported)
			{
				this.NLMMMBMGLJL();
				return true;
			}
			return true;
		}

		// Token: 0x06007F70 RID: 32624 RVA: 0x002A7BFD File Offset: 0x002A5DFD
		private void HLCMOFCEJLP()
		{
			this.LMKGCBNNGLI = false;
		}

		// Token: 0x06007F71 RID: 32625 RVA: 0x002A8D3C File Offset: 0x002A6F3C
		private bool MKGGCKPJCIJ(Shader BDIMLMKEEKO)
		{
			string[] array = new string[1];
			array[0] = " key(s)";
			array[1] = BDIMLMKEEKO.ToString();
			array[1] = "Set camera background color";
			array[1] = this.ToString();
			array[2] = "DisableStoryboardToggle";
			Debug.Log(string.Concat(array));
			if (!BDIMLMKEEKO.isSupported)
			{
				this.OEHBMMAFJGG();
				return true;
			}
			return false;
		}

		// Token: 0x06007F72 RID: 32626 RVA: 0x002A8D97 File Offset: 0x002A6F97
		protected void DKOPKPBLDHH()
		{
			this.CGAPDCICECE();
		}

		// Token: 0x06007F73 RID: 32627 RVA: 0x002A8DA0 File Offset: 0x002A6FA0
		protected void KLDIFBJHKPO()
		{
			Debug.LogWarning("[PlayerBase] SpawnObj error: " + this.ToString() + "EnableRankingToggle");
		}

		// Token: 0x06007F74 RID: 32628 RVA: 0x002A8DBC File Offset: 0x002A6FBC
		protected bool BFCJMJJHMFO(bool EJPNCEPNNPI, bool BCCBAPNLBDD)
		{
			if (!this.JOMCJOEOLHP(EJPNCEPNNPI))
			{
				return true;
			}
			if (BCCBAPNLBDD && !this.CLHPOIKGFFF)
			{
				this.MIFAKEPHPBO();
				return true;
			}
			return false;
		}

		// Token: 0x06007F75 RID: 32629 RVA: 0x002A7621 File Offset: 0x002A5821
		protected void MIFAKEPHPBO()
		{
			base.enabled = false;
			this.LMKGCBNNGLI = true;
		}

		// Token: 0x06007F76 RID: 32630 RVA: 0x002A8DE6 File Offset: 0x002A6FE6
		protected bool PIOJMKCBGJH()
		{
			return this.KNGDKKMDKOG(false);
		}

		// Token: 0x06007F77 RID: 32631 RVA: 0x002A6DB8 File Offset: 0x002A4FB8
		protected void HCBFPHFFGFJ()
		{
			base.enabled = false;
			this.LMKGCBNNGLI = false;
		}

		// Token: 0x06007F78 RID: 32632 RVA: 0x002A8DF0 File Offset: 0x002A6FF0
		protected void NBLMPDOACKB(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
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

		// Token: 0x06007F79 RID: 32633 RVA: 0x002A6DB8 File Offset: 0x002A4FB8
		protected void ILPCOBPBAFM()
		{
			base.enabled = false;
			this.LMKGCBNNGLI = false;
		}

		// Token: 0x06007F7A RID: 32634 RVA: 0x002A77C3 File Offset: 0x002A59C3
		public bool BJJIDPPDCKC()
		{
			return this.EAKIOBNBAMI;
		}

		// Token: 0x06007F7B RID: 32635 RVA: 0x002A8D97 File Offset: 0x002A6F97
		protected void FJNCHGLIEMA()
		{
			this.CGAPDCICECE();
		}

		// Token: 0x06007F7C RID: 32636 RVA: 0x002A9090 File Offset: 0x002A7290
		protected bool KMNGKHKHCGA(bool EJPNCEPNNPI, bool BCCBAPNLBDD)
		{
			if (!this.NPOEJIDLJGK(EJPNCEPNNPI))
			{
				return false;
			}
			if (BCCBAPNLBDD && !this.CLHPOIKGFFF)
			{
				this.ILPCOBPBAFM();
				return false;
			}
			return false;
		}

		// Token: 0x06007F7D RID: 32637 RVA: 0x002A90BA File Offset: 0x002A72BA
		protected bool LBHKCKBMHJC(bool EJPNCEPNNPI, bool BCCBAPNLBDD)
		{
			if (!this.KNGDKKMDKOG(EJPNCEPNNPI))
			{
				return true;
			}
			if (BCCBAPNLBDD && !this.CLHPOIKGFFF)
			{
				this.JKOMCICEKHD();
				return false;
			}
			return false;
		}

		// Token: 0x06007F7E RID: 32638 RVA: 0x002A90E4 File Offset: 0x002A72E4
		protected void IOMHNBJEKLP()
		{
			Debug.LogWarning("other.dust2" + this.ToString() + "_Value2");
		}

		// Token: 0x06007F7F RID: 32639 RVA: 0x002A9100 File Offset: 0x002A7300
		private bool KCCDKLBLAMF(Shader BDIMLMKEEKO)
		{
			string[] array = new string[8];
			array[0] = "OnSerialize";
			array[1] = BDIMLMKEEKO.ToString();
			array[1] = "getfloat";
			array[7] = this.ToString();
			array[1] = "GlassAberration";
			Debug.Log(string.Concat(array));
			if (!BDIMLMKEEKO.isSupported)
			{
				this.DJLJMNPHEJI();
				return false;
			}
			return false;
		}

		// Token: 0x06007F80 RID: 32640 RVA: 0x002A915C File Offset: 0x002A735C
		private bool OMBIDLKKNNI(Shader BDIMLMKEEKO)
		{
			string[] array = new string[5];
			array[0] = "float,1.5";
			array[0] = BDIMLMKEEKO.ToString();
			array[0] = "_ScreenResolution";
			array[4] = this.ToString();
			array[5] = "DPADHOR";
			Debug.Log(string.Concat(array));
			if (!BDIMLMKEEKO.isSupported)
			{
				this.IOIPJPBGIPB();
				return true;
			}
			return false;
		}

		// Token: 0x06007F81 RID: 32641 RVA: 0x002A91B8 File Offset: 0x002A73B8
		protected bool DCHKKHDGBLJ(bool EJPNCEPNNPI)
		{
			this.LMKGCBNNGLI = false;
			this.CLHPOIKGFFF = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB2101010);
			this.EAKIOBNBAMI = (SystemInfo.graphicsShaderLevel >= -14 && SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
			{
				this.NLMMMBMGLJL();
				return true;
			}
			if (EJPNCEPNNPI && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.NLMMMBMGLJL();
				return false;
			}
			if (EJPNCEPNNPI)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			return true;
		}

		// Token: 0x06007F82 RID: 32642 RVA: 0x002A9241 File Offset: 0x002A7441
		protected bool ECCELJPCCAL(bool EJPNCEPNNPI, bool BCCBAPNLBDD)
		{
			if (!this.DHHGCBANGJL(EJPNCEPNNPI))
			{
				return true;
			}
			if (BCCBAPNLBDD && !this.CLHPOIKGFFF)
			{
				this.DJLJMNPHEJI();
				return false;
			}
			return false;
		}

		// Token: 0x06007F83 RID: 32643 RVA: 0x002A63A5 File Offset: 0x002A45A5
		private void PLIPIMPKNLO()
		{
			this.LMKGCBNNGLI = true;
		}

		// Token: 0x06007F84 RID: 32644 RVA: 0x002A77C3 File Offset: 0x002A59C3
		public bool Dx11Support()
		{
			return this.EAKIOBNBAMI;
		}

		// Token: 0x06007F85 RID: 32645 RVA: 0x002A926B File Offset: 0x002A746B
		protected bool ELMKAHCILEG(bool EJPNCEPNNPI, bool BCCBAPNLBDD)
		{
			if (!this.JOMCJOEOLHP(EJPNCEPNNPI))
			{
				return true;
			}
			if (BCCBAPNLBDD && !this.CLHPOIKGFFF)
			{
				this.DJLJMNPHEJI();
				return true;
			}
			return true;
		}

		// Token: 0x06007F86 RID: 32646 RVA: 0x002A7BFD File Offset: 0x002A5DFD
		private void HENBNNAGIKN()
		{
			this.LMKGCBNNGLI = false;
		}

		// Token: 0x06007F87 RID: 32647 RVA: 0x002A9295 File Offset: 0x002A7495
		protected void OHFOLGANOLC()
		{
			this.AFNHKGFNOCL();
		}

		// Token: 0x06007F88 RID: 32648 RVA: 0x002A929E File Offset: 0x002A749E
		protected void OJOJPJNEKHJ()
		{
			Debug.LogWarning("A" + this.ToString() + "Texture2");
		}

		// Token: 0x06007F89 RID: 32649 RVA: 0x002A63A5 File Offset: 0x002A45A5
		private void DLOAJEFNKDA()
		{
			this.LMKGCBNNGLI = true;
		}

		// Token: 0x06007F8A RID: 32650 RVA: 0x002A77C3 File Offset: 0x002A59C3
		public bool JPIPAIOEBJJ()
		{
			return this.EAKIOBNBAMI;
		}

		// Token: 0x06007F8B RID: 32651 RVA: 0x002A92BC File Offset: 0x002A74BC
		protected Material LKIJNGDHLAK(Shader BDIMLMKEEKO, Material JEEEBCFLMEO)
		{
			if (!BDIMLMKEEKO)
			{
				Debug.Log(" [" + this.ToString());
				base.enabled = true;
				return null;
			}
			if (BDIMLMKEEKO.isSupported && JEEEBCFLMEO && JEEEBCFLMEO.shader == BDIMLMKEEKO)
			{
				return JEEEBCFLMEO;
			}
			if (!BDIMLMKEEKO.isSupported)
			{
				this.ILPCOBPBAFM();
				string[] array = new string[0];
				array[0] = "HiddenToggle";
				array[1] = BDIMLMKEEKO.ToString();
				array[3] = "#alreadyexist";
				array[8] = this.ToString();
				array[1] = "1";
				Debug.Log(string.Concat(array));
				return null;
			}
			JEEEBCFLMEO = new Material(BDIMLMKEEKO);
			JEEEBCFLMEO.hideFlags = (HideFlags)(-127);
			if (JEEEBCFLMEO)
			{
				return JEEEBCFLMEO;
			}
			return null;
		}

		// Token: 0x06007F8C RID: 32652 RVA: 0x002A9388 File Offset: 0x002A7588
		private bool EODJKIHHFEI(Shader BDIMLMKEEKO)
		{
			string[] array = new string[7];
			array[1] = " argument(s): ";
			array[1] = BDIMLMKEEKO.ToString();
			array[3] = "_Amount";
			array[0] = this.ToString();
			array[3] = "CameraFilterPack/3D_Shield";
			Debug.Log(string.Concat(array));
			if (!BDIMLMKEEKO.isSupported)
			{
				this.JKOMCICEKHD();
				return false;
			}
			return true;
		}

		// Token: 0x06007F8D RID: 32653 RVA: 0x002A93E4 File Offset: 0x002A75E4
		protected Material GJKHKCOAFDB(Shader BDIMLMKEEKO, Material JEEEBCFLMEO)
		{
			if (!BDIMLMKEEKO)
			{
				Debug.Log("_Offsets" + this.ToString());
				base.enabled = true;
				return null;
			}
			if (BDIMLMKEEKO.isSupported && JEEEBCFLMEO && JEEEBCFLMEO.shader == BDIMLMKEEKO)
			{
				return JEEEBCFLMEO;
			}
			if (!BDIMLMKEEKO.isSupported)
			{
				this.IOIPJPBGIPB();
				string[] array = new string[5];
				array[1] = "ChatHistoryInputField";
				array[0] = BDIMLMKEEKO.ToString();
				array[6] = ".lastCheckpoint.longestComboScore";
				array[5] = this.ToString();
				array[6] = "Joystick";
				Debug.Log(string.Concat(array));
				return null;
			}
			JEEEBCFLMEO = new Material(BDIMLMKEEKO);
			JEEEBCFLMEO.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
			if (JEEEBCFLMEO)
			{
				return JEEEBCFLMEO;
			}
			return null;
		}

		// Token: 0x06007F8E RID: 32654 RVA: 0x002A94AE File Offset: 0x002A76AE
		public virtual bool LPDGLHPMDLB()
		{
			Debug.LogWarning(".png" + this.ToString() + "connecting");
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007F8F RID: 32655 RVA: 0x002A94D0 File Offset: 0x002A76D0
		protected void BGDJEEOJFFA(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
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
					y = 634f;
					y2 = 869f;
				}
				else
				{
					y = 1536f;
					y2 = 843f;
				}
				float x = 1645f;
				float x2 = 1855f / ((float)FHNFPBCBODL.width * 162f);
				float y3 = 82f;
				float y4 = 104f;
				GL.Begin(0);
				GL.TexCoord2(331f, y);
				GL.Vertex3(x, y3, 310f);
				GL.TexCoord2(33f, y);
				GL.Vertex3(x2, y3, 31f);
				GL.TexCoord2(917f, y2);
				GL.Vertex3(x2, y4, 1000f);
				GL.TexCoord2(1833f, y2);
				GL.Vertex3(x, y4, 939f);
				x = 1149f - 603f / ((float)FHNFPBCBODL.width * 905f);
				x2 = 1241f;
				y3 = 1767f;
				y4 = 648f;
				GL.TexCoord2(313f, y);
				GL.Vertex3(x, y3, 1976f);
				GL.TexCoord2(352f, y);
				GL.Vertex3(x2, y3, 1106f);
				GL.TexCoord2(359f, y2);
				GL.Vertex3(x2, y4, 979f);
				GL.TexCoord2(177f, y2);
				GL.Vertex3(x, y4, 1383f);
				x = 981f;
				x2 = 1279f;
				y3 = 1674f;
				y4 = 1050f / ((float)FHNFPBCBODL.height * 779f);
				GL.TexCoord2(1589f, y);
				GL.Vertex3(x, y3, 1567f);
				GL.TexCoord2(1269f, y);
				GL.Vertex3(x2, y3, 1619f);
				GL.TexCoord2(391f, y2);
				GL.Vertex3(x2, y4, 1572f);
				GL.TexCoord2(1771f, y2);
				GL.Vertex3(x, y4, 1013f);
				x = 1468f;
				x2 = 1866f;
				y3 = 1539f - 1321f / ((float)FHNFPBCBODL.height * 1810f);
				y4 = 1927f;
				GL.TexCoord2(413f, y);
				GL.Vertex3(x, y3, 1638f);
				GL.TexCoord2(1250f, y);
				GL.Vertex3(x2, y3, 810f);
				GL.TexCoord2(1250f, y2);
				GL.Vertex3(x2, y4, 1887f);
				GL.TexCoord2(256f, y2);
				GL.Vertex3(x, y4, 1169f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007F90 RID: 32656 RVA: 0x002A9770 File Offset: 0x002A7970
		private bool ANILPCHPKGE(Shader BDIMLMKEEKO)
		{
			string[] array = new string[3];
			array[0] = "received</b>\n#reason: ";
			array[0] = BDIMLMKEEKO.ToString();
			array[5] = " - ";
			array[0] = this.ToString();
			array[6] = "int";
			Debug.Log(string.Concat(array));
			if (!BDIMLMKEEKO.isSupported)
			{
				this.OEHBMMAFJGG();
				return true;
			}
			return true;
		}

		// Token: 0x06007F91 RID: 32657 RVA: 0x002A97CB File Offset: 0x002A79CB
		protected void FDGHGPOPOAK()
		{
			Debug.LogWarning("_Value1" + this.ToString() + "LetterSpacing: Missing Text component");
		}

		// Token: 0x06007F92 RID: 32658 RVA: 0x002A97E8 File Offset: 0x002A79E8
		protected Material PAFINHBHDIK(Shader BDIMLMKEEKO, Material JEEEBCFLMEO)
		{
			if (!BDIMLMKEEKO)
			{
				Debug.Log("ReconnectAndRejoin() failed. Can only connect while in state 'Disconnected'. Current state: " + this.ToString());
				return null;
			}
			if (JEEEBCFLMEO && JEEEBCFLMEO.shader == BDIMLMKEEKO && BDIMLMKEEKO.isSupported)
			{
				return JEEEBCFLMEO;
			}
			if (!BDIMLMKEEKO.isSupported)
			{
				return null;
			}
			JEEEBCFLMEO = new Material(BDIMLMKEEKO);
			JEEEBCFLMEO.hideFlags = (HideFlags)86;
			if (JEEEBCFLMEO)
			{
				return JEEEBCFLMEO;
			}
			return null;
		}

		// Token: 0x06007F93 RID: 32659 RVA: 0x002A7BFD File Offset: 0x002A5DFD
		private void LGELACBDPEH()
		{
			this.LMKGCBNNGLI = false;
		}

		// Token: 0x06007F94 RID: 32660 RVA: 0x002A986C File Offset: 0x002A7A6C
		protected void MMKJCLLGOPE(RenderTexture FHNFPBCBODL, Material NBPKMLMCHFN)
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
					y = 1711f;
					y2 = 889f;
				}
				else
				{
					y = 801f;
					y2 = 96f;
				}
				float x = 1263f;
				float x2 = 990f / ((float)FHNFPBCBODL.width * 278f);
				float y3 = 996f;
				float y4 = 254f;
				GL.Begin(7);
				GL.TexCoord2(357f, y);
				GL.Vertex3(x, y3, 999f);
				GL.TexCoord2(1186f, y);
				GL.Vertex3(x2, y3, 209f);
				GL.TexCoord2(1488f, y2);
				GL.Vertex3(x2, y4, 1951f);
				GL.TexCoord2(1895f, y2);
				GL.Vertex3(x, y4, 567f);
				x = 1150f - 939f / ((float)FHNFPBCBODL.width * 1101f);
				x2 = 1337f;
				y3 = 381f;
				y4 = 477f;
				GL.TexCoord2(1949f, y);
				GL.Vertex3(x, y3, 1123f);
				GL.TexCoord2(1491f, y);
				GL.Vertex3(x2, y3, 712f);
				GL.TexCoord2(852f, y2);
				GL.Vertex3(x2, y4, 683f);
				GL.TexCoord2(1105f, y2);
				GL.Vertex3(x, y4, 137f);
				x = 1038f;
				x2 = 1990f;
				y3 = 110f;
				y4 = 1138f / ((float)FHNFPBCBODL.height * 1830f);
				GL.TexCoord2(262f, y);
				GL.Vertex3(x, y3, 309f);
				GL.TexCoord2(935f, y);
				GL.Vertex3(x2, y3, 1793f);
				GL.TexCoord2(1753f, y2);
				GL.Vertex3(x2, y4, 669f);
				GL.TexCoord2(1565f, y2);
				GL.Vertex3(x, y4, 1801f);
				x = 121f;
				x2 = 1849f;
				y3 = 1548f - 158f / ((float)FHNFPBCBODL.height * 1546f);
				y4 = 48f;
				GL.TexCoord2(1638f, y);
				GL.Vertex3(x, y3, 999f);
				GL.TexCoord2(1746f, y);
				GL.Vertex3(x2, y3, 1969f);
				GL.TexCoord2(1573f, y2);
				GL.Vertex3(x2, y4, 1851f);
				GL.TexCoord2(811f, y2);
				GL.Vertex3(x, y4, 1986f);
				GL.End();
			}
			GL.PopMatrix();
		}

		// Token: 0x06007F95 RID: 32661 RVA: 0x002A9B0C File Offset: 0x002A7D0C
		protected bool DHHGCBANGJL(bool EJPNCEPNNPI)
		{
			this.LMKGCBNNGLI = true;
			this.CLHPOIKGFFF = SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32);
			this.EAKIOBNBAMI = (SystemInfo.graphicsShaderLevel >= -69 && SystemInfo.supportsComputeShaders);
			if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
			{
				this.ILPCOBPBAFM();
				return false;
			}
			if (EJPNCEPNNPI && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.OEHBMMAFJGG();
				return true;
			}
			if (EJPNCEPNNPI)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			return true;
		}

		// Token: 0x06007F96 RID: 32662 RVA: 0x002A9B95 File Offset: 0x002A7D95
		protected void BPEKKDKKLPM()
		{
			Debug.LogWarning("Pop" + this.ToString() + "CameraFilterPack/Blend2Camera_ColorBurn");
		}

		// Token: 0x06007F97 RID: 32663 RVA: 0x002A9BB4 File Offset: 0x002A7DB4
		private bool ODIBHAIEOHI(Shader BDIMLMKEEKO)
		{
			string[] array = new string[]
			{
				null,
				"Submition failed"
			};
			array[1] = BDIMLMKEEKO.ToString();
			array[6] = "https://store.steampowered.com/recommended/recommendgame/";
			array[3] = this.ToString();
			array[1] = "_Value6";
			Debug.Log(string.Concat(array));
			if (!BDIMLMKEEKO.isSupported)
			{
				this.JKOMCICEKHD();
				return false;
			}
			return false;
		}

		// Token: 0x06007F98 RID: 32664 RVA: 0x002A9C10 File Offset: 0x002A7E10
		private bool ALCAHGJAAFM(Shader BDIMLMKEEKO)
		{
			string[] array = new string[7];
			array[1] = "AllocateViewID() failed. User {0} is out of subIds, as all viewIDs are used.";
			array[1] = BDIMLMKEEKO.ToString();
			array[1] = "_Size";
			array[1] = this.ToString();
			array[6] = "Texture2";
			Debug.Log(string.Concat(array));
			if (!BDIMLMKEEKO.isSupported)
			{
				this.KFAEEPBKBOJ();
				return true;
			}
			return true;
		}

		// Token: 0x06007F99 RID: 32665 RVA: 0x002A9C6B File Offset: 0x002A7E6B
		public virtual bool OEECIHEGJHE()
		{
			Debug.LogWarning("float,1.5" + this.ToString() + "skin.");
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007F9A RID: 32666 RVA: 0x002A9C8D File Offset: 0x002A7E8D
		protected void MBPJJEHMMGJ()
		{
			Debug.LogWarning("closed" + this.ToString() + "mapselector.tags.");
		}

		// Token: 0x06007F9B RID: 32667 RVA: 0x002A9CAC File Offset: 0x002A7EAC
		protected Material KDHKHOHMKCG(Shader BDIMLMKEEKO, Material JEEEBCFLMEO)
		{
			if (!BDIMLMKEEKO)
			{
				Debug.Log("CameraFilterPack/TV_Artefact" + this.ToString());
				base.enabled = false;
				return null;
			}
			if (BDIMLMKEEKO.isSupported && JEEEBCFLMEO && JEEEBCFLMEO.shader == BDIMLMKEEKO)
			{
				return JEEEBCFLMEO;
			}
			if (!BDIMLMKEEKO.isSupported)
			{
				this.ILPCOBPBAFM();
				string[] array = new string[0];
				array[1] = "CameraFilterPack/3D_BlackHole";
				array[1] = BDIMLMKEEKO.ToString();
				array[2] = "_DisplayVelocityScale";
				array[2] = this.ToString();
				array[4] = ". Going to ignore! Check PhotonServerSettings.RpcList";
				Debug.Log(string.Concat(array));
				return null;
			}
			JEEEBCFLMEO = new Material(BDIMLMKEEKO);
			JEEEBCFLMEO.hideFlags = (HideFlags)100;
			if (JEEEBCFLMEO)
			{
				return JEEEBCFLMEO;
			}
			return null;
		}

		// Token: 0x06007F9C RID: 32668 RVA: 0x002A9D78 File Offset: 0x002A7F78
		protected Material NAJEHEHHDOJ(Shader BDIMLMKEEKO, Material JEEEBCFLMEO)
		{
			if (!BDIMLMKEEKO)
			{
				Debug.Log("EnableRankingToggle" + this.ToString());
				return null;
			}
			if (JEEEBCFLMEO && JEEEBCFLMEO.shader == BDIMLMKEEKO && BDIMLMKEEKO.isSupported)
			{
				return JEEEBCFLMEO;
			}
			if (!BDIMLMKEEKO.isSupported)
			{
				return null;
			}
			JEEEBCFLMEO = new Material(BDIMLMKEEKO);
			JEEEBCFLMEO.hideFlags = (HideFlags)(-96);
			if (JEEEBCFLMEO)
			{
				return JEEEBCFLMEO;
			}
			return null;
		}

		// Token: 0x06007F9D RID: 32669 RVA: 0x002A7621 File Offset: 0x002A5821
		protected void NLMMMBMGLJL()
		{
			base.enabled = false;
			this.LMKGCBNNGLI = true;
		}

		// Token: 0x06007F9E RID: 32670 RVA: 0x002A68F0 File Offset: 0x002A4AF0
		protected bool EGNDJHBBNCI()
		{
			return this.KHNPMDDIJAJ(false);
		}

		// Token: 0x04000E48 RID: 3656
		protected bool CLHPOIKGFFF = true;

		// Token: 0x04000E49 RID: 3657
		protected bool EAKIOBNBAMI;

		// Token: 0x04000E4A RID: 3658
		protected bool LMKGCBNNGLI = true;
	}
}
