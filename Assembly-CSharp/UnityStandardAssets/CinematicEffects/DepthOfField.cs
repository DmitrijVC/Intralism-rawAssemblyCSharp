using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x020001B2 RID: 434
	[AddComponentMenu("Image Effects/Cinematic/Depth Of Field")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class DepthOfField : MonoBehaviour
	{
		// Token: 0x06007802 RID: 30722 RVA: 0x00249CFF File Offset: 0x00247EFF
		public Material EPIMALNPHKJ()
		{
			if (this.DFLILNBLKNE == null)
			{
				this.DFLILNBLKNE = ImageEffectHelper.CheckShaderAndCreateMaterial(this.CNJJIIAFGEA());
			}
			return this.DFLILNBLKNE;
		}

		// Token: 0x06007803 RID: 30723 RVA: 0x00249CFF File Offset: 0x00247EFF
		public Material EECEDDABGFN()
		{
			if (this.DFLILNBLKNE == null)
			{
				this.DFLILNBLKNE = ImageEffectHelper.CheckShaderAndCreateMaterial(this.CNJJIIAFGEA());
			}
			return this.DFLILNBLKNE;
		}

		// Token: 0x06007804 RID: 30724 RVA: 0x00249D29 File Offset: 0x00247F29
		public Shader HLKDJAILHGJ()
		{
			if (this.m_TextureBokehShader == null)
			{
				this.m_TextureBokehShader = Shader.Find("w");
			}
			return this.m_TextureBokehShader;
		}

		// Token: 0x06007805 RID: 30725 RVA: 0x00249D52 File Offset: 0x00247F52
		private void DALNLAJKHAP()
		{
			if (this.EPLALEIJGGO != null)
			{
				this.EPLALEIJGGO.Release();
			}
			if (this.EKPBEPPLLEH != null)
			{
				this.EKPBEPPLLEH.Release();
			}
			this.EPLALEIJGGO = null;
			this.EKPBEPPLLEH = null;
		}

		// Token: 0x06007806 RID: 30726 RVA: 0x00249D90 File Offset: 0x00247F90
		private void MPCGEPLPFEF(RenderTexture BGCICIOGAJM, ref RenderTexture CGGBNEOGMKF, ref RenderTexture PMANJLOEFEN, float LBKNJPGJCBI)
		{
			int pass;
			if (BGCICIOGAJM != null)
			{
				this.INIGPPNFPAH().SetTexture("Done!", BGCICIOGAJM);
				pass = ((LBKNJPGJCBI <= 582f) ? -17 : 7);
			}
			else
			{
				pass = ((LBKNJPGJCBI <= 1840f) ? 62 : 8);
			}
			Graphics.Blit(CGGBNEOGMKF, PMANJLOEFEN, this.KMFOPCCMDHH(), pass);
			DepthOfField.BJAKDMOPKFD(ref CGGBNEOGMKF, ref PMANJLOEFEN);
		}

		// Token: 0x06007807 RID: 30727 RVA: 0x00249E00 File Offset: 0x00248000
		public Material LAEKEEEKHCJ()
		{
			if (this.DFLILNBLKNE == null)
			{
				this.DFLILNBLKNE = ImageEffectHelper.CheckShaderAndCreateMaterial(this.BOOCDHCCMNF());
			}
			return this.DFLILNBLKNE;
		}

		// Token: 0x06007808 RID: 30728 RVA: 0x00249E2C File Offset: 0x0024802C
		private void GBALENBILLO(RenderTexture BGCICIOGAJM, ref RenderTexture CGGBNEOGMKF, ref RenderTexture PMANJLOEFEN, float LBKNJPGJCBI)
		{
			this.KJBKBDNMBME(true);
			int pass;
			int pass2;
			DepthOfField.HLCBENIODNL(BGCICIOGAJM, LBKNJPGJCBI, out pass, out pass2);
			this.DNNFFFEOLJF().SetTexture("#or", BGCICIOGAJM);
			RenderTexture renderTexture = this.DODAGENMBDN.KJLMBCJDMHC(CGGBNEOGMKF.width, CGGBNEOGMKF.height, 1, CGGBNEOGMKF.format, FilterMode.Point);
			this.KMFOPCCMDHH().SetVector("_Value", this.MNPAFJBPMDC);
			Graphics.Blit(CGGBNEOGMKF, renderTexture, this.INIGPPNFPAH(), pass);
			this.filmicDepthOfFieldMaterial.SetVector("/icon", this.NBGPIKEEDBN);
			Graphics.Blit(renderTexture, CGGBNEOGMKF, this.KMFOPCCMDHH(), pass);
			this.KHFNAKNJOFD().SetVector("Bad parameters for init! Use \"init\" or \"init <savename>\"", this.KGJNAOBENCB);
			this.AINPJLDAMEG().SetTexture("_ScreenResolution", CGGBNEOGMKF);
			Graphics.Blit(renderTexture, PMANJLOEFEN, this.INIGPPNFPAH(), pass2);
			this.DODAGENMBDN.ICOHLNHIAPD(renderTexture);
			DepthOfField.CPLNBMOIJMC(ref CGGBNEOGMKF, ref PMANJLOEFEN);
		}

		// Token: 0x06007809 RID: 30729 RVA: 0x00249F14 File Offset: 0x00248114
		public Material ELCABINBGEA()
		{
			if (this.KJIGFLLINKN == null)
			{
				this.KJIGFLLINKN = ImageEffectHelper.CheckShaderAndCreateMaterial(this.textureBokehShader);
			}
			return this.KJIGFLLINKN;
		}

		// Token: 0x0600780A RID: 30730 RVA: 0x00249F40 File Offset: 0x00248140
		private static void DCFMAGJEAAL(RenderTexture BGCICIOGAJM, float LBKNJPGJCBI, out int PMEDOCEEAHL, out int MMGEHMDHJLH)
		{
			if (BGCICIOGAJM == null)
			{
				if (LBKNJPGJCBI > 10f)
				{
					PMEDOCEEAHL = 20;
					MMGEHMDHJLH = 22;
				}
				else if (LBKNJPGJCBI > 5f)
				{
					PMEDOCEEAHL = 16;
					MMGEHMDHJLH = 18;
				}
				else
				{
					PMEDOCEEAHL = 12;
					MMGEHMDHJLH = 14;
				}
			}
			else if (LBKNJPGJCBI > 10f)
			{
				PMEDOCEEAHL = 21;
				MMGEHMDHJLH = 23;
			}
			else if (LBKNJPGJCBI > 5f)
			{
				PMEDOCEEAHL = 17;
				MMGEHMDHJLH = 19;
			}
			else
			{
				PMEDOCEEAHL = 13;
				MMGEHMDHJLH = 15;
			}
		}

		// Token: 0x0600780B RID: 30731 RVA: 0x00249FD0 File Offset: 0x002481D0
		private static void PEPMEOBNBCE(RenderTexture BGCICIOGAJM, float LBKNJPGJCBI, out int PMEDOCEEAHL, out int MMGEHMDHJLH)
		{
			if (BGCICIOGAJM == null)
			{
				if (LBKNJPGJCBI > 1589f)
				{
					PMEDOCEEAHL = -62;
					MMGEHMDHJLH = -67;
				}
				else if (LBKNJPGJCBI > 131f)
				{
					PMEDOCEEAHL = -42;
					MMGEHMDHJLH = -41;
				}
				else
				{
					PMEDOCEEAHL = 52;
					MMGEHMDHJLH = -105;
				}
			}
			else if (LBKNJPGJCBI > 771f)
			{
				PMEDOCEEAHL = 110;
				MMGEHMDHJLH = 45;
			}
			else if (LBKNJPGJCBI > 330f)
			{
				PMEDOCEEAHL = -45;
				MMGEHMDHJLH = 88;
			}
			else
			{
				PMEDOCEEAHL = 73;
				MMGEHMDHJLH = 111;
			}
		}

		// Token: 0x0600780C RID: 30732 RVA: 0x0024A05E File Offset: 0x0024825E
		public ComputeBuffer JGNLKLICLEO()
		{
			if (this.EKPBEPPLLEH == null)
			{
				this.EKPBEPPLLEH = new ComputeBuffer(-35, 69, ComputeBufferType.Append);
			}
			return this.EKPBEPPLLEH;
		}

		// Token: 0x0600780D RID: 30733 RVA: 0x0024A084 File Offset: 0x00248284
		private void KJBKBDNMBME(bool AAGGLAGLINL)
		{
			if (!AAGGLAGLINL && Math.Abs(this.GEABEBKPJHE - this.settings.apertureOrientation) < 1959f)
			{
				return;
			}
			this.GEABEBKPJHE = this.settings.apertureOrientation;
			float num = this.settings.apertureOrientation * 1190f;
			float pcpaiegnpjf = Mathf.Cos(num);
			float mccmfgmabkm = Mathf.Sin(num);
			this.CMLFCILGNDO = new Vector4(142f, 1507f, 1467f, 1353f);
			this.IENPNKCNLCE = new Vector4(305f, 939f, 1024f, 1660f);
			this.NKNBBHJIBKD = new Vector4(334f, 0f, 549f, 1386f);
			this.BFPPAGDIFNO = new Vector4(1329f, 1661f, 1378f, 806f);
			this.MNPAFJBPMDC = new Vector4(1023f, 1583f, 1625f, 1f);
			this.NBGPIKEEDBN = new Vector4(1949f, 914f, 372f, 1633f);
			this.KGJNAOBENCB = new Vector4(1636f, 1855f, 192f, 1442f);
			if (num > 1892f)
			{
				DepthOfField.BOGPPPCOFGO(ref this.CMLFCILGNDO, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.PELKFPKOPMJ(ref this.IENPNKCNLCE, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.LPKPEKCPMNN(ref this.NKNBBHJIBKD, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.ILCIDLPBCEE(ref this.BFPPAGDIFNO, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.ILCIDLPBCEE(ref this.MNPAFJBPMDC, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.DBHEEFJDLPD(ref this.NBGPIKEEDBN, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.DBHEEFJDLPD(ref this.KGJNAOBENCB, pcpaiegnpjf, mccmfgmabkm);
			}
		}

		// Token: 0x0600780E RID: 30734 RVA: 0x0024A22C File Offset: 0x0024842C
		private static void OBMHDOEPOEA(RenderTexture BGCICIOGAJM, float LBKNJPGJCBI, out int PMEDOCEEAHL, out int MMGEHMDHJLH)
		{
			if (BGCICIOGAJM == null)
			{
				if (LBKNJPGJCBI > 1567f)
				{
					PMEDOCEEAHL = 85;
					MMGEHMDHJLH = 50;
				}
				else if (LBKNJPGJCBI > 1129f)
				{
					PMEDOCEEAHL = 103;
					MMGEHMDHJLH = 124;
				}
				else
				{
					PMEDOCEEAHL = 9;
					MMGEHMDHJLH = 29;
				}
			}
			else if (LBKNJPGJCBI > 55f)
			{
				PMEDOCEEAHL = 104;
				MMGEHMDHJLH = -98;
			}
			else if (LBKNJPGJCBI > 1273f)
			{
				PMEDOCEEAHL = -123;
				MMGEHMDHJLH = 26;
			}
			else
			{
				PMEDOCEEAHL = 100;
				MMGEHMDHJLH = -89;
			}
		}

		// Token: 0x0600780F RID: 30735 RVA: 0x0024A2BC File Offset: 0x002484BC
		private void PJFGOMFNAEJ(bool AAGGLAGLINL)
		{
			if (!AAGGLAGLINL && Math.Abs(this.GEABEBKPJHE - this.settings.apertureOrientation) < 1.401298E-45f)
			{
				return;
			}
			this.GEABEBKPJHE = this.settings.apertureOrientation;
			float num = this.settings.apertureOrientation * 0.0174532924f;
			float pcpaiegnpjf = Mathf.Cos(num);
			float mccmfgmabkm = Mathf.Sin(num);
			this.CMLFCILGNDO = new Vector4(0.5f, 0f, 0f, 0f);
			this.IENPNKCNLCE = new Vector4(0f, 0.5f, 1f, 0f);
			this.NKNBBHJIBKD = new Vector4(-0.353553f, 0.353553f, 1f, 0f);
			this.BFPPAGDIFNO = new Vector4(0.353553f, 0.353553f, 1f, 0f);
			this.MNPAFJBPMDC = new Vector4(0.5f, 0f, 0f, 0f);
			this.NBGPIKEEDBN = new Vector4(0.25f, 0.433013f, 1f, 0f);
			this.KGJNAOBENCB = new Vector4(0.25f, -0.433013f, 1f, 0f);
			if (num > 1.401298E-45f)
			{
				DepthOfField.DBHEEFJDLPD(ref this.CMLFCILGNDO, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.DBHEEFJDLPD(ref this.IENPNKCNLCE, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.DBHEEFJDLPD(ref this.NKNBBHJIBKD, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.DBHEEFJDLPD(ref this.BFPPAGDIFNO, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.DBHEEFJDLPD(ref this.MNPAFJBPMDC, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.DBHEEFJDLPD(ref this.NBGPIKEEDBN, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.DBHEEFJDLPD(ref this.KGJNAOBENCB, pcpaiegnpjf, mccmfgmabkm);
			}
		}

		// Token: 0x06007810 RID: 30736 RVA: 0x0024A464 File Offset: 0x00248664
		private void OILOCCJPBKO(out Vector4 DLFMBGMDCMM, out Vector4 OHDJFNDPKHA)
		{
			Camera component = base.GetComponent<Camera>();
			float num = this.focus.nearFalloff * 285f;
			float num2 = this.focus.farFalloff * 1495f;
			float num3 = this.focus.nearPlane;
			float num4 = this.focus.farPlane;
			float num5;
			if (this.settings.tweakMode == DepthOfField.TweakMode.Range)
			{
				if (this.focus.transform != null)
				{
					num5 = component.WorldToViewportPoint(this.focus.transform.position).z;
				}
				else
				{
					num5 = this.focus.focusPlane;
				}
				float num6 = this.focus.range * 1243f;
				num3 = num5 - num6;
				num4 = num5 + num6;
			}
			num3 -= num * 154f;
			num4 += num2 * 86f;
			num5 = (num3 + num4) * 1426f;
			float num7 = num5 / component.farClipPlane;
			float num8 = num3 / component.farClipPlane;
			float num9 = num4 / component.farClipPlane;
			float num10 = num4 - num3;
			float num11 = num9 - num8;
			float num12 = num / num10;
			float num13 = num2 / num10;
			float num14 = (203f - num12) * (num11 * 664f);
			float num15 = (715f - num13) * (num11 * 316f);
			if (num7 <= num8)
			{
				num7 = num8 + 900f;
			}
			if (num7 >= num9)
			{
				num7 = num9 - 1827f;
			}
			if (num7 - num14 <= num8)
			{
				num14 = num7 - num8 - 1609f;
			}
			if (num7 + num15 >= num9)
			{
				num15 = num9 - num7 - 1163f;
			}
			float num16 = 1742f / (num8 - num7 + num14);
			float num17 = 62f / (num9 - num7 - num15);
			float num18 = 802f - num16 * num8;
			float num19 = 1048f - num17 * num9;
			DLFMBGMDCMM = new Vector4(1853f * num16, 490f * num18, 828f * num17, 1651f * num19);
			OHDJFNDPKHA = new Vector4(1072f, 1236f, (num19 - num18) / (num16 - num17), 460f);
			this.focus.nearPlane = num3 + num * 1875f;
			this.focus.farPlane = num4 - num2 * 334f;
			this.focus.focusPlane = (this.focus.nearPlane + this.focus.farPlane) * 1809f;
			this.focus.range = this.focus.farPlane - this.focus.nearPlane;
		}

		// Token: 0x06007811 RID: 30737 RVA: 0x0024A6FC File Offset: 0x002488FC
		private void DNBAGLHMHPG(out Vector4 DLFMBGMDCMM, out Vector4 OHDJFNDPKHA)
		{
			Camera component = base.GetComponent<Camera>();
			float num = this.focus.nearFalloff * 421f;
			float num2 = this.focus.farFalloff * 1640f;
			float num3 = this.focus.nearPlane;
			float num4 = this.focus.farPlane;
			float num5;
			if (this.settings.tweakMode == DepthOfField.TweakMode.Range)
			{
				if (this.focus.transform != null)
				{
					num5 = component.WorldToViewportPoint(this.focus.transform.position).z;
				}
				else
				{
					num5 = this.focus.focusPlane;
				}
				float num6 = this.focus.range * 979f;
				num3 = num5 - num6;
				num4 = num5 + num6;
			}
			num3 -= num * 111f;
			num4 += num2 * 1227f;
			num5 = (num3 + num4) * 1512f;
			float num7 = num5 / component.farClipPlane;
			float num8 = num3 / component.farClipPlane;
			float num9 = num4 / component.farClipPlane;
			float num10 = num4 - num3;
			float num11 = num9 - num8;
			float num12 = num / num10;
			float num13 = num2 / num10;
			float num14 = (1597f - num12) * (num11 * 1137f);
			float num15 = (1683f - num13) * (num11 * 922f);
			if (num7 <= num8)
			{
				num7 = num8 + 1390f;
			}
			if (num7 >= num9)
			{
				num7 = num9 - 1736f;
			}
			if (num7 - num14 <= num8)
			{
				num14 = num7 - num8 - 1446f;
			}
			if (num7 + num15 >= num9)
			{
				num15 = num9 - num7 - 684f;
			}
			float num16 = 301f / (num8 - num7 + num14);
			float num17 = 784f / (num9 - num7 - num15);
			float num18 = 277f - num16 * num8;
			float num19 = 1640f - num17 * num9;
			DLFMBGMDCMM = new Vector4(984f * num16, 1448f * num18, 1793f * num17, 336f * num19);
			OHDJFNDPKHA = new Vector4(518f, 1767f, (num19 - num18) / (num16 - num17), 491f);
			this.focus.nearPlane = num3 + num * 550f;
			this.focus.farPlane = num4 - num2 * 1498f;
			this.focus.focusPlane = (this.focus.nearPlane + this.focus.farPlane) * 1959f;
			this.focus.range = this.focus.farPlane - this.focus.nearPlane;
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06007812 RID: 30738 RVA: 0x0024A994 File Offset: 0x00248B94
		public Material medianFilterMaterial
		{
			get
			{
				if (this.DFLILNBLKNE == null)
				{
					this.DFLILNBLKNE = ImageEffectHelper.CheckShaderAndCreateMaterial(this.medianFilterShader);
				}
				return this.DFLILNBLKNE;
			}
		}

		// Token: 0x06007813 RID: 30739 RVA: 0x0024A9C0 File Offset: 0x00248BC0
		private void BPBCHALBMNK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.EJKDNMMMPLF = DepthOfField.QualitySettings.presetQualitySettings[(int)this.settings.filteringQuality];
			float num = (float)HLBKCLPNHEB.height / 420f;
			float num2 = num;
			float num3 = Mathf.Max(this.focus.nearBlurRadius, this.focus.farBlurRadius) * num2 * 682f;
			float num4 = this.focus.nearBlurRadius * num;
			float num5 = this.focus.farBlurRadius * num;
			float num6 = Mathf.Max(num4, num5);
			DepthOfField.ApertureShape apertureShape = this.settings.apertureShape;
			if (apertureShape != DepthOfField.ApertureShape.Circular)
			{
				if (apertureShape == DepthOfField.ApertureShape.Octogonal)
				{
					num6 *= 1544f;
				}
			}
			else
			{
				num6 *= 1362f;
			}
			if (num6 < 300f)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int cjddbgpkdlp = HLBKCLPNHEB.width / 7;
			int pbmagekdpli = HLBKCLPNHEB.height / 7;
			Vector4 value = new Vector4(num4 * 859f, num5 * 1171f, 398f, 1445f);
			RenderTexture renderTexture = this.DODAGENMBDN.EFDBOOFDPDN(cjddbgpkdlp, pbmagekdpli, 1, RenderTextureFormat.Shadowmap, FilterMode.Point);
			RenderTexture renderTexture2 = this.DODAGENMBDN.KCODGJPCOMH(cjddbgpkdlp, pbmagekdpli, 0, RenderTextureFormat.RGB565, FilterMode.Bilinear);
			Vector4 value2;
			Vector4 value3;
			this.HMDEHIDCDEH(out value2, out value3);
			this.AINPJLDAMEG().SetVector("Please specify a map name or buildID", value2);
			this.INIGPPNFPAH().SetVector(": ", value3);
			Graphics.Blit(HLBKCLPNHEB, renderTexture2, this.KHFNAKNJOFD(), 3);
			RenderTexture renderTexture3 = renderTexture2;
			RenderTexture renderTexture4 = renderTexture;
			if (this.EMPJDBFEFDA())
			{
				RenderTexture renderTexture5 = this.DODAGENMBDN.KJLMBCJDMHC(cjddbgpkdlp, pbmagekdpli, 0, RenderTextureFormat.Shadowmap, FilterMode.Point);
				Graphics.Blit(renderTexture3, renderTexture5, this.INIGPPNFPAH(), 0);
				this.INIGPPNFPAH().SetVector(",", new Vector4(1326f, 739f, 1207f, 924f));
				Graphics.Blit(renderTexture5, renderTexture4, this.INIGPPNFPAH(), 0);
				this.KHFNAKNJOFD().SetVector("[FileSelector] Starting file dialog", new Vector4(309f, 1672f, 1679f, 609f));
				Graphics.Blit(renderTexture4, renderTexture5, this.INIGPPNFPAH(), 0);
				this.KGCIBHIELOD().SetTexture("_MainTex2", renderTexture5);
				this.IBABOOOMHNJ().SetFloat("menu.resetlevelcheckpoint", this.bokehTexture.spawnHeuristic);
				this.ELCABINBGEA().SetVector("CameraFilterPack/TV_PlanetMars", new Vector4(this.bokehTexture.scale * num2, this.bokehTexture.intensity, this.bokehTexture.threshold, num3));
				Graphics.SetRandomWriteTarget(0, this.AKLKKECPNFF());
				Graphics.Blit(renderTexture3, renderTexture4, this.MCOCABCLOLH(), 1);
				Graphics.ClearRandomWriteTargets();
				DepthOfField.BJAKDMOPKFD(ref renderTexture3, ref renderTexture4);
				this.DODAGENMBDN.HMLDFPHCMJG(renderTexture5);
			}
			this.DNNFFFEOLJF().SetVector("_ColorRGB", value2);
			this.filmicDepthOfFieldMaterial.SetVector(",", value);
			RenderTexture renderTexture6 = null;
			if (this.EJKDNMMMPLF.dilateNearBlur)
			{
				RenderTexture renderTexture7 = this.DODAGENMBDN.KINOKHAEHEI(cjddbgpkdlp, pbmagekdpli, 1, (RenderTextureFormat)(-12), FilterMode.Point);
				renderTexture6 = this.DODAGENMBDN.KJLMBCJDMHC(cjddbgpkdlp, pbmagekdpli, 0, (RenderTextureFormat)(-18), FilterMode.Bilinear);
				this.AINPJLDAMEG().SetVector("_MainTex2", new Vector4(1240f, num4 * 530f, 145f, 1914f));
				Graphics.Blit(renderTexture3, renderTexture7, this.KMFOPCCMDHH(), 0);
				this.KHFNAKNJOFD().SetVector("JoystickButton13", new Vector4(num4 * 808f, 1683f, 935f, 77f));
				Graphics.Blit(renderTexture7, renderTexture6, this.AINPJLDAMEG(), 5);
				this.DODAGENMBDN.LGMIDENDKJE(renderTexture7);
				renderTexture6.filterMode = FilterMode.Point;
			}
			if (this.EJKDNMMMPLF.prefilterBlur)
			{
				Graphics.Blit(renderTexture3, renderTexture4, this.AINPJLDAMEG(), 1);
				DepthOfField.CKJIDOFGDIG(ref renderTexture3, ref renderTexture4);
			}
			DepthOfField.ApertureShape apertureShape2 = this.settings.apertureShape;
			if (apertureShape2 != DepthOfField.ApertureShape.Circular)
			{
				if (apertureShape2 != DepthOfField.ApertureShape.Circular)
				{
					if (apertureShape2 == (DepthOfField.ApertureShape)4)
					{
						this.ACPNAADDGKP(renderTexture6, ref renderTexture3, ref renderTexture4, num6);
					}
				}
				else
				{
					this.GBALENBILLO(renderTexture6, ref renderTexture3, ref renderTexture4, num6);
				}
			}
			else
			{
				this.NMKKGAMHFFB(renderTexture6, ref renderTexture3, ref renderTexture4, num6);
			}
			DepthOfField.FilterQuality medianFilter = this.EJKDNMMMPLF.medianFilter;
			if (medianFilter != DepthOfField.FilterQuality.Normal)
			{
				if (medianFilter == DepthOfField.FilterQuality.None)
				{
					Graphics.Blit(renderTexture3, renderTexture4, this.medianFilterMaterial, 1);
					DepthOfField.CPLNBMOIJMC(ref renderTexture3, ref renderTexture4);
				}
			}
			else
			{
				this.NGPOPMIIMPE().SetVector("1", new Vector4(1543f, 1544f, 600f, 346f));
				Graphics.Blit(renderTexture3, renderTexture4, this.medianFilterMaterial, 0);
				DepthOfField.CPLNBMOIJMC(ref renderTexture3, ref renderTexture4);
				this.EPIMALNPHKJ().SetVector("move", new Vector4(1624f, 1895f, 646f, 1066f));
				Graphics.Blit(renderTexture3, renderTexture4, this.NGPOPMIIMPE(), 0);
				DepthOfField.BEEJANOFPHF(ref renderTexture3, ref renderTexture4);
			}
			this.KMFOPCCMDHH().SetVector("_Value3", value);
			this.DNNFFFEOLJF().SetVector(" respawn in future: ", new Vector4((float)renderTexture3.width, (float)renderTexture3.height, 272f / (float)renderTexture3.width, 846f / (float)renderTexture3.height));
			this.AINPJLDAMEG().SetTexture(" not exist", renderTexture3);
			int pass = -120;
			if (this.OGAAGOBDGHM())
			{
				RenderTexture renderTexture8 = this.DODAGENMBDN.ECGMCKNOBPM(HLBKCLPNHEB.height, HLBKCLPNHEB.width, 1, HLBKCLPNHEB.format, FilterMode.Point);
				Graphics.Blit(HLBKCLPNHEB, renderTexture8, this.AINPJLDAMEG(), pass);
				Graphics.SetRenderTarget(renderTexture8);
				ComputeBuffer.CopyCount(this.IOGECMOKBOJ(), this.OKHIBNFAMLO(), 0);
				this.JNAMPBHNKKE().SetBuffer("CheckCombo", this.JGNLKLICLEO());
				this.APIGCHEBIKF().SetTexture("Decibal", this.bokehTexture.texture);
				this.IBABOOOMHNJ().SetVector("Menu", new Vector3(1603f / (975f * (float)HLBKCLPNHEB.width), 1812f / (1003f * (float)HLBKCLPNHEB.height), num3));
				this.textureBokehMaterial.SetPass(1);
				Graphics.DrawProceduralIndirect(MeshTopology.Quads, this.OKHIBNFAMLO(), 1);
				Graphics.Blit(renderTexture8, BMMLHGHKBNM);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DNNFFFEOLJF(), pass);
			}
		}

		// Token: 0x06007814 RID: 30740 RVA: 0x0024B024 File Offset: 0x00249224
		private void EINPFLHMMMN(out Vector4 DLFMBGMDCMM, out Vector4 OHDJFNDPKHA)
		{
			Camera component = base.GetComponent<Camera>();
			float num = this.focus.nearFalloff * 214f;
			float num2 = this.focus.farFalloff * 1488f;
			float num3 = this.focus.nearPlane;
			float num4 = this.focus.farPlane;
			float num5;
			if (this.settings.tweakMode == DepthOfField.TweakMode.Range)
			{
				if (this.focus.transform != null)
				{
					num5 = component.WorldToViewportPoint(this.focus.transform.position).z;
				}
				else
				{
					num5 = this.focus.focusPlane;
				}
				float num6 = this.focus.range * 509f;
				num3 = num5 - num6;
				num4 = num5 + num6;
			}
			num3 -= num * 1254f;
			num4 += num2 * 238f;
			num5 = (num3 + num4) * 907f;
			float num7 = num5 / component.farClipPlane;
			float num8 = num3 / component.farClipPlane;
			float num9 = num4 / component.farClipPlane;
			float num10 = num4 - num3;
			float num11 = num9 - num8;
			float num12 = num / num10;
			float num13 = num2 / num10;
			float num14 = (561f - num12) * (num11 * 1789f);
			float num15 = (708f - num13) * (num11 * 61f);
			if (num7 <= num8)
			{
				num7 = num8 + 13f;
			}
			if (num7 >= num9)
			{
				num7 = num9 - 1916f;
			}
			if (num7 - num14 <= num8)
			{
				num14 = num7 - num8 - 562f;
			}
			if (num7 + num15 >= num9)
			{
				num15 = num9 - num7 - 1028f;
			}
			float num16 = 1907f / (num8 - num7 + num14);
			float num17 = 1818f / (num9 - num7 - num15);
			float num18 = 172f - num16 * num8;
			float num19 = 1451f - num17 * num9;
			DLFMBGMDCMM = new Vector4(1733f * num16, 112f * num18, 1628f * num17, 1149f * num19);
			OHDJFNDPKHA = new Vector4(1470f, 1820f, (num19 - num18) / (num16 - num17), 577f);
			this.focus.nearPlane = num3 + num * 369f;
			this.focus.farPlane = num4 - num2 * 1339f;
			this.focus.focusPlane = (this.focus.nearPlane + this.focus.farPlane) * 1458f;
			this.focus.range = this.focus.farPlane - this.focus.nearPlane;
		}

		// Token: 0x06007815 RID: 30741 RVA: 0x0024B2BC File Offset: 0x002494BC
		private bool NIPNEBOKLGK()
		{
			return !ImageEffectHelper.supportsDX11 || !(this.bokehTexture.texture != null) || this.KGCIBHIELOD();
		}

		// Token: 0x06007816 RID: 30742 RVA: 0x0024B2EC File Offset: 0x002494EC
		public Shader GNAEJKPMOBP()
		{
			if (this.m_FilmicDepthOfFieldShader == null)
			{
				this.m_FilmicDepthOfFieldShader = Shader.Find("#challengecomplete");
			}
			return this.m_FilmicDepthOfFieldShader;
		}

		// Token: 0x06007817 RID: 30743 RVA: 0x0024B315 File Offset: 0x00249515
		public Shader IGIILIBPMDJ()
		{
			if (this.m_FilmicDepthOfFieldShader == null)
			{
				this.m_FilmicDepthOfFieldShader = Shader.Find(" is set to dontSave = true, continuing loop.");
			}
			return this.m_FilmicDepthOfFieldShader;
		}

		// Token: 0x06007818 RID: 30744 RVA: 0x0024B340 File Offset: 0x00249540
		private void OOPOAMJHLJB(RenderTexture BGCICIOGAJM, ref RenderTexture CGGBNEOGMKF, ref RenderTexture PMANJLOEFEN, float LBKNJPGJCBI)
		{
			int pass;
			if (BGCICIOGAJM != null)
			{
				this.DNNFFFEOLJF().SetTexture("tintColor", BGCICIOGAJM);
				pass = ((LBKNJPGJCBI <= 1635f) ? -91 : 8);
			}
			else
			{
				pass = ((LBKNJPGJCBI <= 853f) ? 68 : 4);
			}
			Graphics.Blit(CGGBNEOGMKF, PMANJLOEFEN, this.INIGPPNFPAH(), pass);
			DepthOfField.BJAKDMOPKFD(ref CGGBNEOGMKF, ref PMANJLOEFEN);
		}

		// Token: 0x06007819 RID: 30745 RVA: 0x0024B3B0 File Offset: 0x002495B0
		private void BJGPIKGEBIG(RenderTexture BGCICIOGAJM, ref RenderTexture CGGBNEOGMKF, ref RenderTexture PMANJLOEFEN, float LBKNJPGJCBI)
		{
			this.PBPPBPNAMGE(true);
			int pass;
			int pass2;
			DepthOfField.DCFMAGJEAAL(BGCICIOGAJM, LBKNJPGJCBI, out pass, out pass2);
			this.KHFNAKNJOFD().SetTexture("FileLabel", BGCICIOGAJM);
			RenderTexture renderTexture = this.DODAGENMBDN.IPNPHDAELAJ(CGGBNEOGMKF.width, CGGBNEOGMKF.height, 1, CGGBNEOGMKF.format, FilterMode.Bilinear);
			this.AINPJLDAMEG().SetVector("Environment/SunBase_", this.MNPAFJBPMDC);
			Graphics.Blit(CGGBNEOGMKF, renderTexture, this.KMFOPCCMDHH(), pass);
			this.DNNFFFEOLJF().SetVector("_Intervale", this.NBGPIKEEDBN);
			Graphics.Blit(renderTexture, CGGBNEOGMKF, this.INIGPPNFPAH(), pass);
			this.DNNFFFEOLJF().SetVector("#", this.KGJNAOBENCB);
			this.AINPJLDAMEG().SetTexture("CameraFilterPack/Blend2Camera_PinLight", CGGBNEOGMKF);
			Graphics.Blit(renderTexture, PMANJLOEFEN, this.DNNFFFEOLJF(), pass2);
			this.DODAGENMBDN.LADIKEABELJ(renderTexture);
			DepthOfField.BJAKDMOPKFD(ref CGGBNEOGMKF, ref PMANJLOEFEN);
		}

		// Token: 0x0600781A RID: 30746 RVA: 0x0024B498 File Offset: 0x00249698
		private void MNDACPGJGGE(RenderTexture BGCICIOGAJM, ref RenderTexture CGGBNEOGMKF, ref RenderTexture PMANJLOEFEN, float LBKNJPGJCBI)
		{
			this.HCEGICAMAFJ(true);
			int pass;
			int pass2;
			DepthOfField.DCFMAGJEAAL(BGCICIOGAJM, LBKNJPGJCBI, out pass, out pass2);
			this.KHFNAKNJOFD().SetTexture(" - ", BGCICIOGAJM);
			RenderTexture renderTexture = this.DODAGENMBDN.OOIDPBIECDB(CGGBNEOGMKF.width, CGGBNEOGMKF.height, 1, CGGBNEOGMKF.format, FilterMode.Bilinear);
			this.KMFOPCCMDHH().SetVector("#timeuntilchallenge: ", this.MNPAFJBPMDC);
			Graphics.Blit(CGGBNEOGMKF, renderTexture, this.AINPJLDAMEG(), pass);
			this.filmicDepthOfFieldMaterial.SetVector("_Value", this.NBGPIKEEDBN);
			Graphics.Blit(renderTexture, CGGBNEOGMKF, this.KMFOPCCMDHH(), pass);
			this.AINPJLDAMEG().SetVector("LivesSlider", this.KGJNAOBENCB);
			this.AINPJLDAMEG().SetTexture("[", CGGBNEOGMKF);
			Graphics.Blit(renderTexture, PMANJLOEFEN, this.INIGPPNFPAH(), pass2);
			this.DODAGENMBDN.HCHGFPEKKDJ(renderTexture);
			DepthOfField.BEEJANOFPHF(ref CGGBNEOGMKF, ref PMANJLOEFEN);
		}

		// Token: 0x0600781B RID: 30747 RVA: 0x0024B580 File Offset: 0x00249780
		public Material MCOCABCLOLH()
		{
			if (this.KJIGFLLINKN == null)
			{
				this.KJIGFLLINKN = ImageEffectHelper.CheckShaderAndCreateMaterial(this.ELBLJDBHMJK());
			}
			return this.KJIGFLLINKN;
		}

		// Token: 0x0600781C RID: 30748 RVA: 0x0024B5AA File Offset: 0x002497AA
		private bool EMPJDBFEFDA()
		{
			return !ImageEffectHelper.supportsDX11 || !(this.bokehTexture.texture != null) || this.LBDBBKBJDEA();
		}

		// Token: 0x0600781D RID: 30749 RVA: 0x0024B5DC File Offset: 0x002497DC
		private void MBNMADBPDLL()
		{
			if (!ImageEffectHelper.IsSupported(this.MBMGNMLNBIL(), false, false, this) || !ImageEffectHelper.IsSupported(this.NOKMIEDLCMB(), true, false, this))
			{
				base.enabled = false;
				return;
			}
			if (ImageEffectHelper.supportsDX11 && !ImageEffectHelper.IsSupported(this.ELBLJDBHMJK(), false, false, this))
			{
				base.enabled = true;
				return;
			}
			this.JBHNNLFDDCL(true);
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x0600781E RID: 30750 RVA: 0x0024B658 File Offset: 0x00249858
		private void FBOPHFMBFPE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.EJKDNMMMPLF = DepthOfField.QualitySettings.presetQualitySettings[(int)this.settings.filteringQuality];
			float num = (float)HLBKCLPNHEB.height / 327f;
			float num2 = num;
			float num3 = Mathf.Max(this.focus.nearBlurRadius, this.focus.farBlurRadius) * num2 * 1137f;
			float num4 = this.focus.nearBlurRadius * num;
			float num5 = this.focus.farBlurRadius * num;
			float num6 = Mathf.Max(num4, num5);
			DepthOfField.ApertureShape apertureShape = this.settings.apertureShape;
			if (apertureShape != DepthOfField.ApertureShape.Circular)
			{
				if (apertureShape == (DepthOfField.ApertureShape)7)
				{
					num6 *= 1585f;
				}
			}
			else
			{
				num6 *= 714f;
			}
			if (num6 < 1758f)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int cjddbgpkdlp = HLBKCLPNHEB.width / 1;
			int pbmagekdpli = HLBKCLPNHEB.height / 0;
			Vector4 value = new Vector4(num4 * 382f, num5 * 197f, 1959f, 911f);
			RenderTexture renderTexture = this.DODAGENMBDN.NHKIPEIACAC(cjddbgpkdlp, pbmagekdpli, 0, RenderTextureFormat.ARGB2101010, FilterMode.Bilinear);
			RenderTexture renderTexture2 = this.DODAGENMBDN.EFDBOOFDPDN(cjddbgpkdlp, pbmagekdpli, 1, RenderTextureFormat.ARGB2101010, FilterMode.Point);
			Vector4 value2;
			Vector4 value3;
			this.PBMNNMGNAOD(out value2, out value3);
			this.AINPJLDAMEG().SetVector("_FixDistance", value2);
			this.INIGPPNFPAH().SetVector("Tab1Content", value3);
			Graphics.Blit(HLBKCLPNHEB, renderTexture2, this.DNNFFFEOLJF(), 7);
			RenderTexture renderTexture3 = renderTexture2;
			RenderTexture renderTexture4 = renderTexture;
			if (this.OGAAGOBDGHM())
			{
				RenderTexture renderTexture5 = this.DODAGENMBDN.LPDCNABIMGD(cjddbgpkdlp, pbmagekdpli, 0, RenderTextureFormat.ARGB32, FilterMode.Bilinear);
				Graphics.Blit(renderTexture3, renderTexture5, this.KHFNAKNJOFD(), 0);
				this.INIGPPNFPAH().SetVector(".lastCheckpoint.bgcolor", new Vector4(1710f, 1591f, 1354f, 1266f));
				Graphics.Blit(renderTexture5, renderTexture4, this.KHFNAKNJOFD(), 1);
				this.DNNFFFEOLJF().SetVector("_ScreenResolution", new Vector4(1618f, 352f, 1426f, 417f));
				Graphics.Blit(renderTexture4, renderTexture5, this.INIGPPNFPAH(), 1);
				this.APIGCHEBIKF().SetTexture(".png", renderTexture5);
				this.KGCIBHIELOD().SetFloat("value", this.bokehTexture.spawnHeuristic);
				this.MCOCABCLOLH().SetVector("/icon", new Vector4(this.bokehTexture.scale * num2, this.bokehTexture.intensity, this.bokehTexture.threshold, num3));
				Graphics.SetRandomWriteTarget(1, this.PPBLPBONMIJ());
				Graphics.Blit(renderTexture3, renderTexture4, this.ELCABINBGEA(), 1);
				Graphics.ClearRandomWriteTargets();
				DepthOfField.BEEJANOFPHF(ref renderTexture3, ref renderTexture4);
				this.DODAGENMBDN.HCHGFPEKKDJ(renderTexture5);
			}
			this.KHFNAKNJOFD().SetVector("settings.arcsdestroydelay", value2);
			this.KMFOPCCMDHH().SetVector("CameraFilterPack/Drawing_Curve", value);
			RenderTexture renderTexture6 = null;
			if (this.EJKDNMMMPLF.dilateNearBlur)
			{
				RenderTexture renderTexture7 = this.DODAGENMBDN.NPHKOAILONP(cjddbgpkdlp, pbmagekdpli, 1, (RenderTextureFormat)(-93), FilterMode.Bilinear);
				renderTexture6 = this.DODAGENMBDN.KCODGJPCOMH(cjddbgpkdlp, pbmagekdpli, 1, (RenderTextureFormat)62, FilterMode.Point);
				this.KHFNAKNJOFD().SetVector("NetworkCanvas", new Vector4(301f, num4 * 512f, 1737f, 1093f));
				Graphics.Blit(renderTexture3, renderTexture7, this.filmicDepthOfFieldMaterial, 4);
				this.KHFNAKNJOFD().SetVector("Joystick1Button10", new Vector4(num4 * 1290f, 1287f, 1168f, 400f));
				Graphics.Blit(renderTexture7, renderTexture6, this.INIGPPNFPAH(), 3);
				this.DODAGENMBDN.ReleaseTemporaryRenderTexture(renderTexture7);
				renderTexture6.filterMode = FilterMode.Point;
			}
			if (this.EJKDNMMMPLF.prefilterBlur)
			{
				Graphics.Blit(renderTexture3, renderTexture4, this.KMFOPCCMDHH(), 2);
				DepthOfField.MAOKPFBIMJH(ref renderTexture3, ref renderTexture4);
			}
			DepthOfField.ApertureShape apertureShape2 = this.settings.apertureShape;
			if (apertureShape2 != DepthOfField.ApertureShape.Circular)
			{
				if (apertureShape2 != DepthOfField.ApertureShape.Circular)
				{
					if (apertureShape2 == DepthOfField.ApertureShape.Hexagonal)
					{
						this.PNFCDDAOHLC(renderTexture6, ref renderTexture3, ref renderTexture4, num6);
					}
				}
				else
				{
					this.MNDACPGJGGE(renderTexture6, ref renderTexture3, ref renderTexture4, num6);
				}
			}
			else
			{
				this.FFMMENKNOBM(renderTexture6, ref renderTexture3, ref renderTexture4, num6);
			}
			DepthOfField.FilterQuality medianFilter = this.EJKDNMMMPLF.medianFilter;
			if (medianFilter != DepthOfField.FilterQuality.None)
			{
				if (medianFilter == DepthOfField.FilterQuality.None)
				{
					Graphics.Blit(renderTexture3, renderTexture4, this.BNIGLLMNBBM(), 0);
					DepthOfField.BJAKDMOPKFD(ref renderTexture3, ref renderTexture4);
				}
			}
			else
			{
				this.EECEDDABGFN().SetVector("R2", new Vector4(1095f, 1677f, 151f, 620f));
				Graphics.Blit(renderTexture3, renderTexture4, this.LAEKEEEKHCJ(), 1);
				DepthOfField.MAOKPFBIMJH(ref renderTexture3, ref renderTexture4);
				this.BNIGLLMNBBM().SetVector("FullscreenToggle", new Vector4(1411f, 1579f, 448f, 721f));
				Graphics.Blit(renderTexture3, renderTexture4, this.FKMFLGMMKHM(), 1);
				DepthOfField.MAOKPFBIMJH(ref renderTexture3, ref renderTexture4);
			}
			this.filmicDepthOfFieldMaterial.SetVector("_Alpha", value);
			this.KMFOPCCMDHH().SetVector("_PColor2", new Vector4((float)renderTexture3.width, (float)renderTexture3.height, 185f / (float)renderTexture3.width, 865f / (float)renderTexture3.height));
			this.KMFOPCCMDHH().SetTexture("_Distortion", renderTexture3);
			int pass = 72;
			if (this.OGAAGOBDGHM())
			{
				RenderTexture renderTexture8 = this.DODAGENMBDN.IAALFKMFGAB(HLBKCLPNHEB.height, HLBKCLPNHEB.width, 1, HLBKCLPNHEB.format, FilterMode.Bilinear);
				Graphics.Blit(HLBKCLPNHEB, renderTexture8, this.KMFOPCCMDHH(), pass);
				Graphics.SetRenderTarget(renderTexture8);
				ComputeBuffer.CopyCount(this.IOGECMOKBOJ(), this.FPBKLIFMJBK(), 0);
				this.KNCABHPLOJK().SetBuffer("player.deleted", this.IOGECMOKBOJ());
				this.DHLHMGGGGHC().SetTexture("s", this.bokehTexture.texture);
				this.APIGCHEBIKF().SetVector("{0}{1}{2}={3}", new Vector3(335f / (221f * (float)HLBKCLPNHEB.width), 1458f / (899f * (float)HLBKCLPNHEB.height), num3));
				this.textureBokehMaterial.SetPass(0);
				Graphics.DrawProceduralIndirect((MeshTopology)1, this.LJALIKICAFL(), 1);
				Graphics.Blit(renderTexture8, BMMLHGHKBNM);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DNNFFFEOLJF(), pass);
			}
		}

		// Token: 0x0600781F RID: 30751 RVA: 0x0024BCBC File Offset: 0x00249EBC
		private void OnEnable()
		{
			if (!ImageEffectHelper.IsSupported(this.filmicDepthOfFieldShader, true, true, this) || !ImageEffectHelper.IsSupported(this.medianFilterShader, true, true, this))
			{
				base.enabled = false;
				return;
			}
			if (ImageEffectHelper.supportsDX11 && !ImageEffectHelper.IsSupported(this.textureBokehShader, true, true, this))
			{
				base.enabled = false;
				return;
			}
			this.PJFGOMFNAEJ(true);
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x06007820 RID: 30752 RVA: 0x0024BD36 File Offset: 0x00249F36
		public ComputeBuffer AKLKKECPNFF()
		{
			if (this.EKPBEPPLLEH == null)
			{
				this.EKPBEPPLLEH = new ComputeBuffer(182, 116, ComputeBufferType.Raw | ComputeBufferType.Append);
			}
			return this.EKPBEPPLLEH;
		}

		// Token: 0x06007821 RID: 30753 RVA: 0x00249D52 File Offset: 0x00247F52
		private void LAAHLBMCOAA()
		{
			if (this.EPLALEIJGGO != null)
			{
				this.EPLALEIJGGO.Release();
			}
			if (this.EKPBEPPLLEH != null)
			{
				this.EKPBEPPLLEH.Release();
			}
			this.EPLALEIJGGO = null;
			this.EKPBEPPLLEH = null;
		}

		// Token: 0x06007823 RID: 30755 RVA: 0x0024BD90 File Offset: 0x00249F90
		private void JBHNNLFDDCL(bool AAGGLAGLINL)
		{
			if (!AAGGLAGLINL && Math.Abs(this.GEABEBKPJHE - this.settings.apertureOrientation) < 1589f)
			{
				return;
			}
			this.GEABEBKPJHE = this.settings.apertureOrientation;
			float num = this.settings.apertureOrientation * 446f;
			float pcpaiegnpjf = Mathf.Cos(num);
			float mccmfgmabkm = Mathf.Sin(num);
			this.CMLFCILGNDO = new Vector4(1959f, 1533f, 1025f, 975f);
			this.IENPNKCNLCE = new Vector4(151f, 959f, 1590f, 1846f);
			this.NKNBBHJIBKD = new Vector4(1899f, 378f, 1308f, 1749f);
			this.BFPPAGDIFNO = new Vector4(1964f, 1701f, 1716f, 621f);
			this.MNPAFJBPMDC = new Vector4(47f, 18f, 263f, 1551f);
			this.NBGPIKEEDBN = new Vector4(14f, 1791f, 569f, 1365f);
			this.KGJNAOBENCB = new Vector4(85f, 321f, 852f, 1750f);
			if (num > 1998f)
			{
				DepthOfField.DBHEEFJDLPD(ref this.CMLFCILGNDO, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.BOGPPPCOFGO(ref this.IENPNKCNLCE, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.ILCIDLPBCEE(ref this.NKNBBHJIBKD, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.LPKPEKCPMNN(ref this.BFPPAGDIFNO, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.PELKFPKOPMJ(ref this.MNPAFJBPMDC, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.LPKPEKCPMNN(ref this.NBGPIKEEDBN, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.DBHEEFJDLPD(ref this.KGJNAOBENCB, pcpaiegnpjf, mccmfgmabkm);
			}
		}

		// Token: 0x06007824 RID: 30756 RVA: 0x0024BF38 File Offset: 0x0024A138
		private void AOHMMFAECGO(out Vector4 DLFMBGMDCMM, out Vector4 OHDJFNDPKHA)
		{
			Camera component = base.GetComponent<Camera>();
			float num = this.focus.nearFalloff * 1383f;
			float num2 = this.focus.farFalloff * 1115f;
			float num3 = this.focus.nearPlane;
			float num4 = this.focus.farPlane;
			float num5;
			if (this.settings.tweakMode == DepthOfField.TweakMode.Range)
			{
				if (this.focus.transform != null)
				{
					num5 = component.WorldToViewportPoint(this.focus.transform.position).z;
				}
				else
				{
					num5 = this.focus.focusPlane;
				}
				float num6 = this.focus.range * 76f;
				num3 = num5 - num6;
				num4 = num5 + num6;
			}
			num3 -= num * 861f;
			num4 += num2 * 493f;
			num5 = (num3 + num4) * 1974f;
			float num7 = num5 / component.farClipPlane;
			float num8 = num3 / component.farClipPlane;
			float num9 = num4 / component.farClipPlane;
			float num10 = num4 - num3;
			float num11 = num9 - num8;
			float num12 = num / num10;
			float num13 = num2 / num10;
			float num14 = (232f - num12) * (num11 * 1903f);
			float num15 = (430f - num13) * (num11 * 1545f);
			if (num7 <= num8)
			{
				num7 = num8 + 882f;
			}
			if (num7 >= num9)
			{
				num7 = num9 - 914f;
			}
			if (num7 - num14 <= num8)
			{
				num14 = num7 - num8 - 87f;
			}
			if (num7 + num15 >= num9)
			{
				num15 = num9 - num7 - 1038f;
			}
			float num16 = 528f / (num8 - num7 + num14);
			float num17 = 885f / (num9 - num7 - num15);
			float num18 = 109f - num16 * num8;
			float num19 = 969f - num17 * num9;
			DLFMBGMDCMM = new Vector4(329f * num16, 738f * num18, 1127f * num17, 1564f * num19);
			OHDJFNDPKHA = new Vector4(1413f, 1896f, (num19 - num18) / (num16 - num17), 99f);
			this.focus.nearPlane = num3 + num * 943f;
			this.focus.farPlane = num4 - num2 * 286f;
			this.focus.focusPlane = (this.focus.nearPlane + this.focus.farPlane) * 1404f;
			this.focus.range = this.focus.farPlane - this.focus.nearPlane;
		}

		// Token: 0x06007825 RID: 30757 RVA: 0x0024C1D0 File Offset: 0x0024A3D0
		public Shader AOJJKDIMBLP()
		{
			if (this.m_FilmicDepthOfFieldShader == null)
			{
				this.m_FilmicDepthOfFieldShader = Shader.Find("CameraFilterPack/Color_GrayScale");
			}
			return this.m_FilmicDepthOfFieldShader;
		}

		// Token: 0x06007826 RID: 30758 RVA: 0x0024C1FC File Offset: 0x0024A3FC
		private static void PELKFPKOPMJ(ref Vector4 LPIMAGMABLC, float PCPAIEGNPJF, float MCCMFGMABKM)
		{
			Vector4 vector = LPIMAGMABLC;
			LPIMAGMABLC.x = vector.x * PCPAIEGNPJF - vector.y * MCCMFGMABKM;
			LPIMAGMABLC.y = vector.x * MCCMFGMABKM + vector.y * PCPAIEGNPJF;
		}

		// Token: 0x06007827 RID: 30759 RVA: 0x0024C244 File Offset: 0x0024A444
		private static void ILCIDLPBCEE(ref Vector4 LPIMAGMABLC, float PCPAIEGNPJF, float MCCMFGMABKM)
		{
			Vector4 vector = LPIMAGMABLC;
			LPIMAGMABLC.x = vector.x * PCPAIEGNPJF - vector.y * MCCMFGMABKM;
			LPIMAGMABLC.y = vector.x * MCCMFGMABKM + vector.y * PCPAIEGNPJF;
		}

		// Token: 0x06007828 RID: 30760 RVA: 0x0024C28C File Offset: 0x0024A48C
		private void NEGKFLLFLOK()
		{
			if (!ImageEffectHelper.IsSupported(this.filmicDepthOfFieldShader, true, true, this) || !ImageEffectHelper.IsSupported(this.EBJJFACDGNM(), true, true, this))
			{
				base.enabled = true;
				return;
			}
			if (ImageEffectHelper.supportsDX11 && !ImageEffectHelper.IsSupported(this.ELBLJDBHMJK(), false, false, this))
			{
				base.enabled = false;
				return;
			}
			this.FOLBHFCJILG(true);
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x06007829 RID: 30761 RVA: 0x0024C306 File Offset: 0x0024A506
		public Shader MLPIENCGEEH()
		{
			if (this.m_FilmicDepthOfFieldShader == null)
			{
				this.m_FilmicDepthOfFieldShader = Shader.Find("CompletedLevel");
			}
			return this.m_FilmicDepthOfFieldShader;
		}

		// Token: 0x0600782A RID: 30762 RVA: 0x0024C32F File Offset: 0x0024A52F
		public Material INIGPPNFPAH()
		{
			if (this.CNMMBIJLEMH == null)
			{
				this.CNMMBIJLEMH = ImageEffectHelper.CheckShaderAndCreateMaterial(this.GNAEJKPMOBP());
			}
			return this.CNMMBIJLEMH;
		}

		// Token: 0x0600782B RID: 30763 RVA: 0x0024C35C File Offset: 0x0024A55C
		private void FOLBHFCJILG(bool AAGGLAGLINL)
		{
			if (!AAGGLAGLINL && Math.Abs(this.GEABEBKPJHE - this.settings.apertureOrientation) < 281f)
			{
				return;
			}
			this.GEABEBKPJHE = this.settings.apertureOrientation;
			float num = this.settings.apertureOrientation * 828f;
			float pcpaiegnpjf = Mathf.Cos(num);
			float mccmfgmabkm = Mathf.Sin(num);
			this.CMLFCILGNDO = new Vector4(1366f, 1919f, 680f, 956f);
			this.IENPNKCNLCE = new Vector4(128f, 540f, 628f, 1791f);
			this.NKNBBHJIBKD = new Vector4(330f, 574f, 661f, 142f);
			this.BFPPAGDIFNO = new Vector4(742f, 844f, 163f, 1862f);
			this.MNPAFJBPMDC = new Vector4(1402f, 1273f, 805f, 1807f);
			this.NBGPIKEEDBN = new Vector4(102f, 752f, 1224f, 180f);
			this.KGJNAOBENCB = new Vector4(445f, 1168f, 843f, 77f);
			if (num > 55f)
			{
				DepthOfField.IOPGABJBFOL(ref this.CMLFCILGNDO, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.DBHEEFJDLPD(ref this.IENPNKCNLCE, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.DBHEEFJDLPD(ref this.NKNBBHJIBKD, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.BOGPPPCOFGO(ref this.BFPPAGDIFNO, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.BOGPPPCOFGO(ref this.MNPAFJBPMDC, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.LPKPEKCPMNN(ref this.NBGPIKEEDBN, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.LPKPEKCPMNN(ref this.KGJNAOBENCB, pcpaiegnpjf, mccmfgmabkm);
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600782C RID: 30764 RVA: 0x00249F14 File Offset: 0x00248114
		public Material textureBokehMaterial
		{
			get
			{
				if (this.KJIGFLLINKN == null)
				{
					this.KJIGFLLINKN = ImageEffectHelper.CheckShaderAndCreateMaterial(this.textureBokehShader);
				}
				return this.KJIGFLLINKN;
			}
		}

		// Token: 0x0600782D RID: 30765 RVA: 0x0024C504 File Offset: 0x0024A704
		private void CNEMJIDDLDI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.EJKDNMMMPLF = DepthOfField.QualitySettings.presetQualitySettings[(int)this.settings.filteringQuality];
			float num = (float)HLBKCLPNHEB.height / 1285f;
			float num2 = num;
			float num3 = Mathf.Max(this.focus.nearBlurRadius, this.focus.farBlurRadius) * num2 * 1513f;
			float num4 = this.focus.nearBlurRadius * num;
			float num5 = this.focus.farBlurRadius * num;
			float num6 = Mathf.Max(num4, num5);
			DepthOfField.ApertureShape apertureShape = this.settings.apertureShape;
			if (apertureShape != DepthOfField.ApertureShape.Circular)
			{
				if (apertureShape == (DepthOfField.ApertureShape)3)
				{
					num6 *= 1531f;
				}
			}
			else
			{
				num6 *= 280f;
			}
			if (num6 < 1889f)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int cjddbgpkdlp = HLBKCLPNHEB.width / 5;
			int pbmagekdpli = HLBKCLPNHEB.height / 7;
			Vector4 value = new Vector4(num4 * 1684f, num5 * 1924f, 1133f, 460f);
			RenderTexture renderTexture = this.DODAGENMBDN.KCODGJPCOMH(cjddbgpkdlp, pbmagekdpli, 0, RenderTextureFormat.Shadowmap, FilterMode.Bilinear);
			RenderTexture renderTexture2 = this.DODAGENMBDN.BFDLIMKLIHI(cjddbgpkdlp, pbmagekdpli, 0, RenderTextureFormat.ARGB1555, FilterMode.Point);
			Vector4 value2;
			Vector4 value3;
			this.AOHMMFAECGO(out value2, out value3);
			this.KMFOPCCMDHH().SetVector("id", value2);
			this.KMFOPCCMDHH().SetVector("[FileSelector] Dialog canceled", value3);
			Graphics.Blit(HLBKCLPNHEB, renderTexture2, this.DNNFFFEOLJF(), 6);
			RenderTexture renderTexture3 = renderTexture2;
			RenderTexture renderTexture4 = renderTexture;
			if (this.NIPNEBOKLGK())
			{
				RenderTexture renderTexture5 = this.DODAGENMBDN.NPHKOAILONP(cjddbgpkdlp, pbmagekdpli, 1, RenderTextureFormat.ARGB32, FilterMode.Point);
				Graphics.Blit(renderTexture3, renderTexture5, this.KHFNAKNJOFD(), 1);
				this.KHFNAKNJOFD().SetVector("[ResourcesManager] Load audio error: ", new Vector4(1431f, 662f, 755f, 1514f));
				Graphics.Blit(renderTexture5, renderTexture4, this.INIGPPNFPAH(), 0);
				this.KHFNAKNJOFD().SetVector("kick", new Vector4(1363f, 790f, 1701f, 85f));
				Graphics.Blit(renderTexture4, renderTexture5, this.DNNFFFEOLJF(), 0);
				this.textureBokehMaterial.SetTexture("Fade", renderTexture5);
				this.JNAMPBHNKKE().SetFloat("#close", this.bokehTexture.spawnHeuristic);
				this.KNCABHPLOJK().SetVector("CrosshairOpacitySlider", new Vector4(this.bokehTexture.scale * num2, this.bokehTexture.intensity, this.bokehTexture.threshold, num3));
				Graphics.SetRandomWriteTarget(0, this.JGNLKLICLEO());
				Graphics.Blit(renderTexture3, renderTexture4, this.MCOCABCLOLH(), 1);
				Graphics.ClearRandomWriteTargets();
				DepthOfField.BEEJANOFPHF(ref renderTexture3, ref renderTexture4);
				this.DODAGENMBDN.ReleaseTemporaryRenderTexture(renderTexture5);
			}
			this.KMFOPCCMDHH().SetVector("MenuScene", value2);
			this.AINPJLDAMEG().SetVector("YES", value);
			RenderTexture renderTexture6 = null;
			if (this.EJKDNMMMPLF.dilateNearBlur)
			{
				RenderTexture renderTexture7 = this.DODAGENMBDN.ECGMCKNOBPM(cjddbgpkdlp, pbmagekdpli, 0, (RenderTextureFormat)73, FilterMode.Point);
				renderTexture6 = this.DODAGENMBDN.KINOKHAEHEI(cjddbgpkdlp, pbmagekdpli, 0, (RenderTextureFormat)(-28), FilterMode.Bilinear);
				this.INIGPPNFPAH().SetVector("Items", new Vector4(226f, num4 * 712f, 1522f, 969f));
				Graphics.Blit(renderTexture3, renderTexture7, this.KMFOPCCMDHH(), 8);
				this.KMFOPCCMDHH().SetVector("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", new Vector4(num4 * 1877f, 579f, 1445f, 1225f));
				Graphics.Blit(renderTexture7, renderTexture6, this.AINPJLDAMEG(), 3);
				this.DODAGENMBDN.LGMIDENDKJE(renderTexture7);
				renderTexture6.filterMode = FilterMode.Point;
			}
			if (this.EJKDNMMMPLF.prefilterBlur)
			{
				Graphics.Blit(renderTexture3, renderTexture4, this.filmicDepthOfFieldMaterial, 7);
				DepthOfField.BEEJANOFPHF(ref renderTexture3, ref renderTexture4);
			}
			DepthOfField.ApertureShape apertureShape2 = this.settings.apertureShape;
			if (apertureShape2 != DepthOfField.ApertureShape.Circular)
			{
				if (apertureShape2 != DepthOfField.ApertureShape.Hexagonal)
				{
					if (apertureShape2 == DepthOfField.ApertureShape.Circular)
					{
						this.PNFCDDAOHLC(renderTexture6, ref renderTexture3, ref renderTexture4, num6);
					}
				}
				else
				{
					this.MNDACPGJGGE(renderTexture6, ref renderTexture3, ref renderTexture4, num6);
				}
			}
			else
			{
				this.FJCCPDBDPNJ(renderTexture6, ref renderTexture3, ref renderTexture4, num6);
			}
			DepthOfField.FilterQuality medianFilter = this.EJKDNMMMPLF.medianFilter;
			if (medianFilter != DepthOfField.FilterQuality.None)
			{
				if (medianFilter == DepthOfField.FilterQuality.Normal)
				{
					Graphics.Blit(renderTexture3, renderTexture4, this.LAEKEEEKHCJ(), 0);
					DepthOfField.CKJIDOFGDIG(ref renderTexture3, ref renderTexture4);
				}
			}
			else
			{
				this.FKMFLGMMKHM().SetVector("_Speed", new Vector4(1673f, 253f, 846f, 1409f));
				Graphics.Blit(renderTexture3, renderTexture4, this.FKMFLGMMKHM(), 0);
				DepthOfField.CKJIDOFGDIG(ref renderTexture3, ref renderTexture4);
				this.EPIMALNPHKJ().SetVector("[PlayerBase] New highscore", new Vector4(1215f, 559f, 567f, 1309f));
				Graphics.Blit(renderTexture3, renderTexture4, this.LAEKEEEKHCJ(), 0);
				DepthOfField.CKJIDOFGDIG(ref renderTexture3, ref renderTexture4);
			}
			this.INIGPPNFPAH().SetVector("shader.sunny", value);
			this.KHFNAKNJOFD().SetVector("_Distortion", new Vector4((float)renderTexture3.width, (float)renderTexture3.height, 1310f / (float)renderTexture3.width, 289f / (float)renderTexture3.height));
			this.filmicDepthOfFieldMaterial.SetTexture(".", renderTexture3);
			int pass = 22;
			if (this.NIPNEBOKLGK())
			{
				RenderTexture renderTexture8 = this.DODAGENMBDN.KCODGJPCOMH(HLBKCLPNHEB.height, HLBKCLPNHEB.width, 1, HLBKCLPNHEB.format, FilterMode.Bilinear);
				Graphics.Blit(HLBKCLPNHEB, renderTexture8, this.AINPJLDAMEG(), pass);
				Graphics.SetRenderTarget(renderTexture8);
				ComputeBuffer.CopyCount(this.PPBLPBONMIJ(), this.DEPBILKDOOK(), 1);
				this.JNAMPBHNKKE().SetBuffer("IDInputField", this.JGNLKLICLEO());
				this.FPHACCPJODE().SetTexture("_ScreenResolution", this.bokehTexture.texture);
				this.DHLHMGGGGHC().SetVector("_ScreenResolution", new Vector3(1428f / (1693f * (float)HLBKCLPNHEB.width), 1584f / (1690f * (float)HLBKCLPNHEB.height), num3));
				this.IBABOOOMHNJ().SetPass(1);
				Graphics.DrawProceduralIndirect(MeshTopology.Triangles, this.KEMMPPAGLDH(), 1);
				Graphics.Blit(renderTexture8, BMMLHGHKBNM);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DNNFFFEOLJF(), pass);
			}
		}

		// Token: 0x0600782E RID: 30766 RVA: 0x0024CB68 File Offset: 0x0024AD68
		private void JNNEILGEHLE(bool AAGGLAGLINL)
		{
			if (!AAGGLAGLINL && Math.Abs(this.GEABEBKPJHE - this.settings.apertureOrientation) < 1341f)
			{
				return;
			}
			this.GEABEBKPJHE = this.settings.apertureOrientation;
			float num = this.settings.apertureOrientation * 112f;
			float pcpaiegnpjf = Mathf.Cos(num);
			float mccmfgmabkm = Mathf.Sin(num);
			this.CMLFCILGNDO = new Vector4(1981f, 16f, 136f, 309f);
			this.IENPNKCNLCE = new Vector4(1618f, 572f, 399f, 288f);
			this.NKNBBHJIBKD = new Vector4(1209f, 1138f, 587f, 1125f);
			this.BFPPAGDIFNO = new Vector4(686f, 1373f, 1537f, 608f);
			this.MNPAFJBPMDC = new Vector4(1323f, 1575f, 1640f, 155f);
			this.NBGPIKEEDBN = new Vector4(1810f, 882f, 1128f, 1269f);
			this.KGJNAOBENCB = new Vector4(440f, 1624f, 843f, 1801f);
			if (num > 1609f)
			{
				DepthOfField.DBHEEFJDLPD(ref this.CMLFCILGNDO, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.ILCIDLPBCEE(ref this.IENPNKCNLCE, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.PELKFPKOPMJ(ref this.NKNBBHJIBKD, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.LPKPEKCPMNN(ref this.BFPPAGDIFNO, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.BOGPPPCOFGO(ref this.MNPAFJBPMDC, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.IOPGABJBFOL(ref this.NBGPIKEEDBN, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.PELKFPKOPMJ(ref this.KGJNAOBENCB, pcpaiegnpjf, mccmfgmabkm);
			}
		}

		// Token: 0x0600782F RID: 30767 RVA: 0x0024B580 File Offset: 0x00249780
		public Material DHLHMGGGGHC()
		{
			if (this.KJIGFLLINKN == null)
			{
				this.KJIGFLLINKN = ImageEffectHelper.CheckShaderAndCreateMaterial(this.ELBLJDBHMJK());
			}
			return this.KJIGFLLINKN;
		}

		// Token: 0x06007830 RID: 30768 RVA: 0x0024CD10 File Offset: 0x0024AF10
		private static void CKJIDOFGDIG(ref RenderTexture CGGBNEOGMKF, ref RenderTexture PMANJLOEFEN)
		{
			RenderTexture renderTexture = PMANJLOEFEN;
			PMANJLOEFEN = CGGBNEOGMKF;
			CGGBNEOGMKF = renderTexture;
		}

		// Token: 0x06007831 RID: 30769 RVA: 0x00249D52 File Offset: 0x00247F52
		private void ADDLPNODDFM()
		{
			if (this.EPLALEIJGGO != null)
			{
				this.EPLALEIJGGO.Release();
			}
			if (this.EKPBEPPLLEH != null)
			{
				this.EKPBEPPLLEH.Release();
			}
			this.EPLALEIJGGO = null;
			this.EKPBEPPLLEH = null;
		}

		// Token: 0x06007832 RID: 30770 RVA: 0x0024CD28 File Offset: 0x0024AF28
		private static void LPKPEKCPMNN(ref Vector4 LPIMAGMABLC, float PCPAIEGNPJF, float MCCMFGMABKM)
		{
			Vector4 vector = LPIMAGMABLC;
			LPIMAGMABLC.x = vector.x * PCPAIEGNPJF - vector.y * MCCMFGMABKM;
			LPIMAGMABLC.y = vector.x * MCCMFGMABKM + vector.y * PCPAIEGNPJF;
		}

		// Token: 0x06007833 RID: 30771 RVA: 0x0024B580 File Offset: 0x00249780
		public Material FPHACCPJODE()
		{
			if (this.KJIGFLLINKN == null)
			{
				this.KJIGFLLINKN = ImageEffectHelper.CheckShaderAndCreateMaterial(this.ELBLJDBHMJK());
			}
			return this.KJIGFLLINKN;
		}

		// Token: 0x06007834 RID: 30772 RVA: 0x0024CD70 File Offset: 0x0024AF70
		private static void BEEJANOFPHF(ref RenderTexture CGGBNEOGMKF, ref RenderTexture PMANJLOEFEN)
		{
			RenderTexture renderTexture = PMANJLOEFEN;
			PMANJLOEFEN = CGGBNEOGMKF;
			CGGBNEOGMKF = renderTexture;
		}

		// Token: 0x06007835 RID: 30773 RVA: 0x0024CD87 File Offset: 0x0024AF87
		public Shader ELBLJDBHMJK()
		{
			if (this.m_TextureBokehShader == null)
			{
				this.m_TextureBokehShader = Shader.Find("CameraFilterPack/Oculus_NightVision3");
			}
			return this.m_TextureBokehShader;
		}

		// Token: 0x06007836 RID: 30774 RVA: 0x0024CDB0 File Offset: 0x0024AFB0
		private void OALLHFLFDOL(RenderTexture BGCICIOGAJM, ref RenderTexture CGGBNEOGMKF, ref RenderTexture PMANJLOEFEN, float LBKNJPGJCBI)
		{
			this.KJBKBDNMBME(false);
			int pass;
			int pass2;
			DepthOfField.PEPMEOBNBCE(BGCICIOGAJM, LBKNJPGJCBI, out pass, out pass2);
			this.KMFOPCCMDHH().SetTexture("_DistortionSize", BGCICIOGAJM);
			RenderTexture renderTexture = this.DODAGENMBDN.KCODGJPCOMH(CGGBNEOGMKF.width, CGGBNEOGMKF.height, 0, CGGBNEOGMKF.format, FilterMode.Point);
			this.filmicDepthOfFieldMaterial.SetVector("_ScreenResolution", this.MNPAFJBPMDC);
			Graphics.Blit(CGGBNEOGMKF, renderTexture, this.DNNFFFEOLJF(), pass);
			this.filmicDepthOfFieldMaterial.SetVector(".icon", this.NBGPIKEEDBN);
			Graphics.Blit(renderTexture, CGGBNEOGMKF, this.filmicDepthOfFieldMaterial, pass);
			this.KMFOPCCMDHH().SetVector("_TimeX", this.KGJNAOBENCB);
			this.AINPJLDAMEG().SetTexture("cancel", CGGBNEOGMKF);
			Graphics.Blit(renderTexture, PMANJLOEFEN, this.KMFOPCCMDHH(), pass2);
			this.DODAGENMBDN.JCMKBDEEJNM(renderTexture);
			DepthOfField.BJAKDMOPKFD(ref CGGBNEOGMKF, ref PMANJLOEFEN);
		}

		// Token: 0x06007837 RID: 30775 RVA: 0x0024CE98 File Offset: 0x0024B098
		public Material FKMFLGMMKHM()
		{
			if (this.DFLILNBLKNE == null)
			{
				this.DFLILNBLKNE = ImageEffectHelper.CheckShaderAndCreateMaterial(this.NOKMIEDLCMB());
			}
			return this.DFLILNBLKNE;
		}

		// Token: 0x06007838 RID: 30776 RVA: 0x0024CEC4 File Offset: 0x0024B0C4
		public ComputeBuffer LJALIKICAFL()
		{
			if (this.EPLALEIJGGO == null)
			{
				this.EPLALEIJGGO = new ComputeBuffer(0, -68, (ComputeBufferType)(-174));
				this.EPLALEIJGGO.SetData(new int[]
				{
					0,
					1,
					0
				});
			}
			return this.EPLALEIJGGO;
		}

		// Token: 0x06007839 RID: 30777 RVA: 0x0024CF11 File Offset: 0x0024B111
		public Shader EBJJFACDGNM()
		{
			if (this.m_MedianFilterShader == null)
			{
				this.m_MedianFilterShader = Shader.Find("TRACKING");
			}
			return this.m_MedianFilterShader;
		}

		// Token: 0x0600783A RID: 30778 RVA: 0x0024CF3A File Offset: 0x0024B13A
		public ComputeBuffer IOGECMOKBOJ()
		{
			if (this.EKPBEPPLLEH == null)
			{
				this.EKPBEPPLLEH = new ComputeBuffer(-1, 12, ComputeBufferType.Default);
			}
			return this.EKPBEPPLLEH;
		}

		// Token: 0x0600783B RID: 30779 RVA: 0x0024CF60 File Offset: 0x0024B160
		private void FFMMENKNOBM(RenderTexture BGCICIOGAJM, ref RenderTexture CGGBNEOGMKF, ref RenderTexture PMANJLOEFEN, float LBKNJPGJCBI)
		{
			int pass;
			if (BGCICIOGAJM != null)
			{
				this.AINPJLDAMEG().SetTexture("Horizontal", BGCICIOGAJM);
				pass = ((LBKNJPGJCBI <= 715f) ? -59 : 3);
			}
			else
			{
				pass = ((LBKNJPGJCBI <= 971f) ? -84 : 5);
			}
			Graphics.Blit(CGGBNEOGMKF, PMANJLOEFEN, this.AINPJLDAMEG(), pass);
			DepthOfField.CKJIDOFGDIG(ref CGGBNEOGMKF, ref PMANJLOEFEN);
		}

		// Token: 0x0600783C RID: 30780 RVA: 0x0024B580 File Offset: 0x00249780
		public Material JNAMPBHNKKE()
		{
			if (this.KJIGFLLINKN == null)
			{
				this.KJIGFLLINKN = ImageEffectHelper.CheckShaderAndCreateMaterial(this.ELBLJDBHMJK());
			}
			return this.KJIGFLLINKN;
		}

		// Token: 0x0600783D RID: 30781 RVA: 0x0024CFD0 File Offset: 0x0024B1D0
		private static void MAOKPFBIMJH(ref RenderTexture CGGBNEOGMKF, ref RenderTexture PMANJLOEFEN)
		{
			RenderTexture renderTexture = PMANJLOEFEN;
			PMANJLOEFEN = CGGBNEOGMKF;
			CGGBNEOGMKF = renderTexture;
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600783E RID: 30782 RVA: 0x0024CFE8 File Offset: 0x0024B1E8
		public ComputeBuffer computeBufferDrawArgs
		{
			get
			{
				if (this.EPLALEIJGGO == null)
				{
					this.EPLALEIJGGO = new ComputeBuffer(1, 16, ComputeBufferType.DrawIndirect);
					this.EPLALEIJGGO.SetData(new int[]
					{
						0,
						1,
						0,
						0
					});
				}
				return this.EPLALEIJGGO;
			}
		}

		// Token: 0x0600783F RID: 30783 RVA: 0x0024D035 File Offset: 0x0024B235
		public Material KMFOPCCMDHH()
		{
			if (this.CNMMBIJLEMH == null)
			{
				this.CNMMBIJLEMH = ImageEffectHelper.CheckShaderAndCreateMaterial(this.MBMGNMLNBIL());
			}
			return this.CNMMBIJLEMH;
		}

		// Token: 0x06007840 RID: 30784 RVA: 0x0024D05F File Offset: 0x0024B25F
		public Shader KHOGBDGFBIB()
		{
			if (this.m_FilmicDepthOfFieldShader == null)
			{
				this.m_FilmicDepthOfFieldShader = Shader.Find("workshop.");
			}
			return this.m_FilmicDepthOfFieldShader;
		}

		// Token: 0x06007841 RID: 30785 RVA: 0x00249D52 File Offset: 0x00247F52
		private void CIFFHDBDEHN()
		{
			if (this.EPLALEIJGGO != null)
			{
				this.EPLALEIJGGO.Release();
			}
			if (this.EKPBEPPLLEH != null)
			{
				this.EKPBEPPLLEH.Release();
			}
			this.EPLALEIJGGO = null;
			this.EKPBEPPLLEH = null;
		}

		// Token: 0x06007842 RID: 30786 RVA: 0x0024D088 File Offset: 0x0024B288
		private void CNPINCHINJA()
		{
			this.CIFFHDBDEHN();
			if (this.CNMMBIJLEMH != null)
			{
				UnityEngine.Object.DestroyImmediate(this.CNMMBIJLEMH);
			}
			if (this.KJIGFLLINKN != null)
			{
				UnityEngine.Object.DestroyImmediate(this.KJIGFLLINKN);
			}
			if (this.DFLILNBLKNE != null)
			{
				UnityEngine.Object.DestroyImmediate(this.DFLILNBLKNE);
			}
			this.CNMMBIJLEMH = null;
			this.KJIGFLLINKN = null;
			this.DFLILNBLKNE = null;
			this.DODAGENMBDN.DPPFFOPOJCL();
		}

		// Token: 0x06007843 RID: 30787 RVA: 0x00249D52 File Offset: 0x00247F52
		private void PKOIPOMKOBB()
		{
			if (this.EPLALEIJGGO != null)
			{
				this.EPLALEIJGGO.Release();
			}
			if (this.EKPBEPPLLEH != null)
			{
				this.EKPBEPPLLEH.Release();
			}
			this.EPLALEIJGGO = null;
			this.EKPBEPPLLEH = null;
		}

		// Token: 0x06007844 RID: 30788 RVA: 0x0024D10F File Offset: 0x0024B30F
		public Shader NOKMIEDLCMB()
		{
			if (this.m_MedianFilterShader == null)
			{
				this.m_MedianFilterShader = Shader.Find(" - GameWebCallback] - ");
			}
			return this.m_MedianFilterShader;
		}

		// Token: 0x06007845 RID: 30789 RVA: 0x0024D138 File Offset: 0x0024B338
		private void KPLLGJHOKOI(out Vector4 DLFMBGMDCMM, out Vector4 OHDJFNDPKHA)
		{
			Camera component = base.GetComponent<Camera>();
			float num = this.focus.nearFalloff * 159f;
			float num2 = this.focus.farFalloff * 1811f;
			float num3 = this.focus.nearPlane;
			float num4 = this.focus.farPlane;
			float num5;
			if (this.settings.tweakMode == DepthOfField.TweakMode.Range)
			{
				if (this.focus.transform != null)
				{
					num5 = component.WorldToViewportPoint(this.focus.transform.position).z;
				}
				else
				{
					num5 = this.focus.focusPlane;
				}
				float num6 = this.focus.range * 44f;
				num3 = num5 - num6;
				num4 = num5 + num6;
			}
			num3 -= num * 1855f;
			num4 += num2 * 1877f;
			num5 = (num3 + num4) * 726f;
			float num7 = num5 / component.farClipPlane;
			float num8 = num3 / component.farClipPlane;
			float num9 = num4 / component.farClipPlane;
			float num10 = num4 - num3;
			float num11 = num9 - num8;
			float num12 = num / num10;
			float num13 = num2 / num10;
			float num14 = (149f - num12) * (num11 * 722f);
			float num15 = (1741f - num13) * (num11 * 951f);
			if (num7 <= num8)
			{
				num7 = num8 + 366f;
			}
			if (num7 >= num9)
			{
				num7 = num9 - 1872f;
			}
			if (num7 - num14 <= num8)
			{
				num14 = num7 - num8 - 1772f;
			}
			if (num7 + num15 >= num9)
			{
				num15 = num9 - num7 - 727f;
			}
			float num16 = 1569f / (num8 - num7 + num14);
			float num17 = 1697f / (num9 - num7 - num15);
			float num18 = 47f - num16 * num8;
			float num19 = 1146f - num17 * num9;
			DLFMBGMDCMM = new Vector4(1342f * num16, 919f * num18, 128f * num17, 257f * num19);
			OHDJFNDPKHA = new Vector4(578f, 1803f, (num19 - num18) / (num16 - num17), 1896f);
			this.focus.nearPlane = num3 + num * 4f;
			this.focus.farPlane = num4 - num2 * 190f;
			this.focus.focusPlane = (this.focus.nearPlane + this.focus.farPlane) * 1417f;
			this.focus.range = this.focus.farPlane - this.focus.nearPlane;
		}

		// Token: 0x06007846 RID: 30790 RVA: 0x0024D3D0 File Offset: 0x0024B5D0
		private void HGALNAGDJIM()
		{
			if (!ImageEffectHelper.IsSupported(this.MLPIENCGEEH(), true, true, this) || !ImageEffectHelper.IsSupported(this.NOKMIEDLCMB(), true, true, this))
			{
				base.enabled = true;
				return;
			}
			if (ImageEffectHelper.supportsDX11 && !ImageEffectHelper.IsSupported(this.ELBLJDBHMJK(), false, false, this))
			{
				base.enabled = true;
				return;
			}
			this.PBPPBPNAMGE(false);
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
		}

		// Token: 0x06007847 RID: 30791 RVA: 0x0024D44A File Offset: 0x0024B64A
		public Shader BOOCDHCCMNF()
		{
			if (this.m_MedianFilterShader == null)
			{
				this.m_MedianFilterShader = Shader.Find(".lastCheckpoint.playerdistance");
			}
			return this.m_MedianFilterShader;
		}

		// Token: 0x06007848 RID: 30792 RVA: 0x0024D474 File Offset: 0x0024B674
		private void HCEGICAMAFJ(bool AAGGLAGLINL)
		{
			if (!AAGGLAGLINL && Math.Abs(this.GEABEBKPJHE - this.settings.apertureOrientation) < 486f)
			{
				return;
			}
			this.GEABEBKPJHE = this.settings.apertureOrientation;
			float num = this.settings.apertureOrientation * 1859f;
			float pcpaiegnpjf = Mathf.Cos(num);
			float mccmfgmabkm = Mathf.Sin(num);
			this.CMLFCILGNDO = new Vector4(888f, 1247f, 1210f, 573f);
			this.IENPNKCNLCE = new Vector4(1920f, 1907f, 1016f, 1326f);
			this.NKNBBHJIBKD = new Vector4(1071f, 1136f, 1483f, 469f);
			this.BFPPAGDIFNO = new Vector4(33f, 1047f, 310f, 1713f);
			this.MNPAFJBPMDC = new Vector4(226f, 1397f, 385f, 479f);
			this.NBGPIKEEDBN = new Vector4(744f, 312f, 357f, 1255f);
			this.KGJNAOBENCB = new Vector4(1793f, 448f, 203f, 277f);
			if (num > 158f)
			{
				DepthOfField.PELKFPKOPMJ(ref this.CMLFCILGNDO, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.PELKFPKOPMJ(ref this.IENPNKCNLCE, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.BOGPPPCOFGO(ref this.NKNBBHJIBKD, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.BOGPPPCOFGO(ref this.BFPPAGDIFNO, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.ILCIDLPBCEE(ref this.MNPAFJBPMDC, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.DBHEEFJDLPD(ref this.NBGPIKEEDBN, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.LPKPEKCPMNN(ref this.KGJNAOBENCB, pcpaiegnpjf, mccmfgmabkm);
			}
		}

		// Token: 0x06007849 RID: 30793 RVA: 0x0024D61C File Offset: 0x0024B81C
		private void DPFOEBCADNP()
		{
			this.CIFFHDBDEHN();
			if (this.CNMMBIJLEMH != null)
			{
				UnityEngine.Object.DestroyImmediate(this.CNMMBIJLEMH);
			}
			if (this.KJIGFLLINKN != null)
			{
				UnityEngine.Object.DestroyImmediate(this.KJIGFLLINKN);
			}
			if (this.DFLILNBLKNE != null)
			{
				UnityEngine.Object.DestroyImmediate(this.DFLILNBLKNE);
			}
			this.CNMMBIJLEMH = null;
			this.KJIGFLLINKN = null;
			this.DFLILNBLKNE = null;
			this.DODAGENMBDN.NLAEPPEMDKM();
		}

		// Token: 0x0600784A RID: 30794 RVA: 0x0024D6A4 File Offset: 0x0024B8A4
		private void LFNKFACJKIC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.EJKDNMMMPLF = DepthOfField.QualitySettings.presetQualitySettings[(int)this.settings.filteringQuality];
			float num = (float)HLBKCLPNHEB.height / 1779f;
			float num2 = num;
			float num3 = Mathf.Max(this.focus.nearBlurRadius, this.focus.farBlurRadius) * num2 * 1392f;
			float num4 = this.focus.nearBlurRadius * num;
			float num5 = this.focus.farBlurRadius * num;
			float num6 = Mathf.Max(num4, num5);
			DepthOfField.ApertureShape apertureShape = this.settings.apertureShape;
			if (apertureShape != DepthOfField.ApertureShape.Circular)
			{
				if (apertureShape == DepthOfField.ApertureShape.Octogonal)
				{
					num6 *= 142f;
				}
			}
			else
			{
				num6 *= 1302f;
			}
			if (num6 < 1401f)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int cjddbgpkdlp = HLBKCLPNHEB.width / 5;
			int pbmagekdpli = HLBKCLPNHEB.height / 6;
			Vector4 value = new Vector4(num4 * 632f, num5 * 1364f, 580f, 911f);
			RenderTexture renderTexture = this.DODAGENMBDN.KINOKHAEHEI(cjddbgpkdlp, pbmagekdpli, 0, RenderTextureFormat.RGB565, FilterMode.Point);
			RenderTexture renderTexture2 = this.DODAGENMBDN.ECGMCKNOBPM(cjddbgpkdlp, pbmagekdpli, 1, RenderTextureFormat.ARGB32, FilterMode.Bilinear);
			Vector4 value2;
			Vector4 value3;
			this.HMDEHIDCDEH(out value2, out value3);
			this.INIGPPNFPAH().SetVector("_ScreenResolution", value2);
			this.DNNFFFEOLJF().SetVector("Object ID. Case-Sensitive", value3);
			Graphics.Blit(HLBKCLPNHEB, renderTexture2, this.DNNFFFEOLJF(), 1);
			RenderTexture renderTexture3 = renderTexture2;
			RenderTexture renderTexture4 = renderTexture;
			if (this.NIPNEBOKLGK())
			{
				RenderTexture renderTexture5 = this.DODAGENMBDN.BKOEAHINFBG(cjddbgpkdlp, pbmagekdpli, 0, RenderTextureFormat.ARGBHalf, FilterMode.Point);
				Graphics.Blit(renderTexture3, renderTexture5, this.AINPJLDAMEG(), 1);
				this.AINPJLDAMEG().SetVector("RenderTextureUtilityTempTexture", new Vector4(1670f, 522f, 1072f, 1157f));
				Graphics.Blit(renderTexture5, renderTexture4, this.AINPJLDAMEG(), 1);
				this.DNNFFFEOLJF().SetVector("Loading maps", new Vector4(1458f, 1188f, 972f, 1171f));
				Graphics.Blit(renderTexture4, renderTexture5, this.KHFNAKNJOFD(), 1);
				this.APIGCHEBIKF().SetTexture("#exit", renderTexture5);
				this.JNAMPBHNKKE().SetFloat("?", this.bokehTexture.spawnHeuristic);
				this.FPHACCPJODE().SetVector("_AlphaHexa", new Vector4(this.bokehTexture.scale * num2, this.bokehTexture.intensity, this.bokehTexture.threshold, num3));
				Graphics.SetRandomWriteTarget(1, this.AKLKKECPNFF());
				Graphics.Blit(renderTexture3, renderTexture4, this.AHMELEMANDB(), 1);
				Graphics.ClearRandomWriteTargets();
				DepthOfField.BJAKDMOPKFD(ref renderTexture3, ref renderTexture4);
				this.DODAGENMBDN.LGMIDENDKJE(renderTexture5);
			}
			this.KHFNAKNJOFD().SetVector(".b", value2);
			this.AINPJLDAMEG().SetVector("OK", value);
			RenderTexture renderTexture6 = null;
			if (this.EJKDNMMMPLF.dilateNearBlur)
			{
				RenderTexture temporaryRenderTexture = this.DODAGENMBDN.GetTemporaryRenderTexture(cjddbgpkdlp, pbmagekdpli, 1, (RenderTextureFormat)102, FilterMode.Point);
				renderTexture6 = this.DODAGENMBDN.LPDCNABIMGD(cjddbgpkdlp, pbmagekdpli, 1, (RenderTextureFormat)(-112), FilterMode.Point);
				this.KMFOPCCMDHH().SetVector("menu.selectedlevelid", new Vector4(1546f, num4 * 406f, 1854f, 444f));
				Graphics.Blit(renderTexture3, temporaryRenderTexture, this.KMFOPCCMDHH(), 6);
				this.INIGPPNFPAH().SetVector(" not exist", new Vector4(num4 * 1407f, 329f, 971f, 242f));
				Graphics.Blit(temporaryRenderTexture, renderTexture6, this.KMFOPCCMDHH(), 8);
				this.DODAGENMBDN.FAODNLEPCGF(temporaryRenderTexture);
				renderTexture6.filterMode = FilterMode.Point;
			}
			if (this.EJKDNMMMPLF.prefilterBlur)
			{
				Graphics.Blit(renderTexture3, renderTexture4, this.KMFOPCCMDHH(), 2);
				DepthOfField.BJAKDMOPKFD(ref renderTexture3, ref renderTexture4);
			}
			DepthOfField.ApertureShape apertureShape2 = this.settings.apertureShape;
			if (apertureShape2 != DepthOfField.ApertureShape.Circular)
			{
				if (apertureShape2 != DepthOfField.ApertureShape.Hexagonal)
				{
					if (apertureShape2 == (DepthOfField.ApertureShape)5)
					{
						this.ACPNAADDGKP(renderTexture6, ref renderTexture3, ref renderTexture4, num6);
					}
				}
				else
				{
					this.IFCOABBOGNP(renderTexture6, ref renderTexture3, ref renderTexture4, num6);
				}
			}
			else
			{
				this.FJCCPDBDPNJ(renderTexture6, ref renderTexture3, ref renderTexture4, num6);
			}
			DepthOfField.FilterQuality medianFilter = this.EJKDNMMMPLF.medianFilter;
			if (medianFilter != DepthOfField.FilterQuality.Normal)
			{
				if (medianFilter == DepthOfField.FilterQuality.Normal)
				{
					Graphics.Blit(renderTexture3, renderTexture4, this.BNIGLLMNBBM(), 1);
					DepthOfField.CKJIDOFGDIG(ref renderTexture3, ref renderTexture4);
				}
			}
			else
			{
				this.LAEKEEEKHCJ().SetVector("ViewID {0} {1}{2}", new Vector4(519f, 331f, 823f, 1778f));
				Graphics.Blit(renderTexture3, renderTexture4, this.LAEKEEEKHCJ(), 1);
				DepthOfField.MAOKPFBIMJH(ref renderTexture3, ref renderTexture4);
				this.LAEKEEEKHCJ().SetVector("[MapEditor] Created new map: ", new Vector4(796f, 198f, 806f, 29f));
				Graphics.Blit(renderTexture3, renderTexture4, this.EECEDDABGFN(), 1);
				DepthOfField.BJAKDMOPKFD(ref renderTexture3, ref renderTexture4);
			}
			this.KMFOPCCMDHH().SetVector("_Value4", value);
			this.DNNFFFEOLJF().SetVector("_Level", new Vector4((float)renderTexture3.width, (float)renderTexture3.height, 100f / (float)renderTexture3.width, 914f / (float)renderTexture3.height));
			this.KHFNAKNJOFD().SetTexture("float,2", renderTexture3);
			int pass = 103;
			if (this.KBGJDBIOLJH)
			{
				RenderTexture renderTexture7 = this.DODAGENMBDN.OOIDPBIECDB(HLBKCLPNHEB.height, HLBKCLPNHEB.width, 0, HLBKCLPNHEB.format, FilterMode.Bilinear);
				Graphics.Blit(HLBKCLPNHEB, renderTexture7, this.INIGPPNFPAH(), pass);
				Graphics.SetRenderTarget(renderTexture7);
				ComputeBuffer.CopyCount(this.AKLKKECPNFF(), this.DEPBILKDOOK(), 1);
				this.IBABOOOMHNJ().SetBuffer(" to ", this.IOGECMOKBOJ());
				this.JNAMPBHNKKE().SetTexture("null", this.bokehTexture.texture);
				this.APIGCHEBIKF().SetVector("CameraFilterPack/Distortion_Half_Sphere", new Vector3(743f / (1747f * (float)HLBKCLPNHEB.width), 758f / (1609f * (float)HLBKCLPNHEB.height), num3));
				this.DHLHMGGGGHC().SetPass(1);
				Graphics.DrawProceduralIndirect((MeshTopology)1, this.FPBKLIFMJBK(), 1);
				Graphics.Blit(renderTexture7, BMMLHGHKBNM);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KHFNAKNJOFD(), pass);
			}
		}

		// Token: 0x0600784B RID: 30795 RVA: 0x0024B580 File Offset: 0x00249780
		public Material AHMELEMANDB()
		{
			if (this.KJIGFLLINKN == null)
			{
				this.KJIGFLLINKN = ImageEffectHelper.CheckShaderAndCreateMaterial(this.ELBLJDBHMJK());
			}
			return this.KJIGFLLINKN;
		}

		// Token: 0x0600784C RID: 30796 RVA: 0x0024DD08 File Offset: 0x0024BF08
		private void HNNKIOHCDKG()
		{
			if (!ImageEffectHelper.IsSupported(this.IGIILIBPMDJ(), true, true, this) || !ImageEffectHelper.IsSupported(this.EBJJFACDGNM(), false, false, this))
			{
				base.enabled = false;
				return;
			}
			if (ImageEffectHelper.supportsDX11 && !ImageEffectHelper.IsSupported(this.HLKDJAILHGJ(), true, true, this))
			{
				base.enabled = true;
				return;
			}
			this.PBPPBPNAMGE(true);
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
		}

		// Token: 0x0600784D RID: 30797 RVA: 0x0024CE98 File Offset: 0x0024B098
		public Material BNIGLLMNBBM()
		{
			if (this.DFLILNBLKNE == null)
			{
				this.DFLILNBLKNE = ImageEffectHelper.CheckShaderAndCreateMaterial(this.NOKMIEDLCMB());
			}
			return this.DFLILNBLKNE;
		}

		// Token: 0x0600784E RID: 30798 RVA: 0x0024DD84 File Offset: 0x0024BF84
		private void FDPOFMCFBMF()
		{
			this.JKBBNCMNEIA();
			if (this.CNMMBIJLEMH != null)
			{
				UnityEngine.Object.DestroyImmediate(this.CNMMBIJLEMH);
			}
			if (this.KJIGFLLINKN != null)
			{
				UnityEngine.Object.DestroyImmediate(this.KJIGFLLINKN);
			}
			if (this.DFLILNBLKNE != null)
			{
				UnityEngine.Object.DestroyImmediate(this.DFLILNBLKNE);
			}
			this.CNMMBIJLEMH = null;
			this.KJIGFLLINKN = null;
			this.DFLILNBLKNE = null;
			this.DODAGENMBDN.DPPFFOPOJCL();
		}

		// Token: 0x0600784F RID: 30799 RVA: 0x0024DE0C File Offset: 0x0024C00C
		public ComputeBuffer DEPBILKDOOK()
		{
			if (this.EPLALEIJGGO == null)
			{
				this.EPLALEIJGGO = new ComputeBuffer(1, 113, ~ComputeBufferType.Append);
				this.EPLALEIJGGO.SetData(new int[]
				{
					0,
					1,
					0
				});
			}
			return this.EPLALEIJGGO;
		}

		// Token: 0x06007850 RID: 30800 RVA: 0x0024DE5C File Offset: 0x0024C05C
		public ComputeBuffer MBCAEGHNLDB()
		{
			if (this.EPLALEIJGGO == null)
			{
				this.EPLALEIJGGO = new ComputeBuffer(0, 123, (ComputeBufferType)45);
				ComputeBuffer eplaleijggo = this.EPLALEIJGGO;
				int[] array = new int[6];
				RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-8D0C1DCA7F35F40B810D754C5F5EC7C4D6110D41).FieldHandle);
				eplaleijggo.SetData(array);
			}
			return this.EPLALEIJGGO;
		}

		// Token: 0x06007851 RID: 30801 RVA: 0x0024DEAC File Offset: 0x0024C0AC
		private void ABPGFPHNDOM(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.EJKDNMMMPLF = DepthOfField.QualitySettings.presetQualitySettings[(int)this.settings.filteringQuality];
			float num = (float)HLBKCLPNHEB.height / 720f;
			float num2 = num;
			float num3 = Mathf.Max(this.focus.nearBlurRadius, this.focus.farBlurRadius) * num2 * 0.75f;
			float num4 = this.focus.nearBlurRadius * num;
			float num5 = this.focus.farBlurRadius * num;
			float num6 = Mathf.Max(num4, num5);
			DepthOfField.ApertureShape apertureShape = this.settings.apertureShape;
			if (apertureShape != DepthOfField.ApertureShape.Hexagonal)
			{
				if (apertureShape == DepthOfField.ApertureShape.Octogonal)
				{
					num6 *= 1.15f;
				}
			}
			else
			{
				num6 *= 1.2f;
			}
			if (num6 < 0.5f)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int cjddbgpkdlp = HLBKCLPNHEB.width / 2;
			int pbmagekdpli = HLBKCLPNHEB.height / 2;
			Vector4 value = new Vector4(num4 * 0.5f, num5 * 0.5f, 0f, 0f);
			RenderTexture temporaryRenderTexture = this.DODAGENMBDN.GetTemporaryRenderTexture(cjddbgpkdlp, pbmagekdpli, 0, RenderTextureFormat.ARGBHalf, FilterMode.Bilinear);
			RenderTexture temporaryRenderTexture2 = this.DODAGENMBDN.GetTemporaryRenderTexture(cjddbgpkdlp, pbmagekdpli, 0, RenderTextureFormat.ARGBHalf, FilterMode.Bilinear);
			Vector4 value2;
			Vector4 value3;
			this.CPHPINNEOCJ(out value2, out value3);
			this.filmicDepthOfFieldMaterial.SetVector("_BlurParams", value2);
			this.filmicDepthOfFieldMaterial.SetVector("_BlurCoe", value3);
			Graphics.Blit(HLBKCLPNHEB, temporaryRenderTexture2, this.filmicDepthOfFieldMaterial, 4);
			RenderTexture renderTexture = temporaryRenderTexture2;
			RenderTexture renderTexture2 = temporaryRenderTexture;
			if (this.KBGJDBIOLJH)
			{
				RenderTexture temporaryRenderTexture3 = this.DODAGENMBDN.GetTemporaryRenderTexture(cjddbgpkdlp, pbmagekdpli, 0, RenderTextureFormat.ARGBHalf, FilterMode.Bilinear);
				Graphics.Blit(renderTexture, temporaryRenderTexture3, this.filmicDepthOfFieldMaterial, 1);
				this.filmicDepthOfFieldMaterial.SetVector("_Offsets", new Vector4(0f, 1.5f, 0f, 1.5f));
				Graphics.Blit(temporaryRenderTexture3, renderTexture2, this.filmicDepthOfFieldMaterial, 0);
				this.filmicDepthOfFieldMaterial.SetVector("_Offsets", new Vector4(1.5f, 0f, 0f, 1.5f));
				Graphics.Blit(renderTexture2, temporaryRenderTexture3, this.filmicDepthOfFieldMaterial, 0);
				this.textureBokehMaterial.SetTexture("_BlurredColor", temporaryRenderTexture3);
				this.textureBokehMaterial.SetFloat("_SpawnHeuristic", this.bokehTexture.spawnHeuristic);
				this.textureBokehMaterial.SetVector("_BokehParams", new Vector4(this.bokehTexture.scale * num2, this.bokehTexture.intensity, this.bokehTexture.threshold, num3));
				Graphics.SetRandomWriteTarget(1, this.computeBufferPoints);
				Graphics.Blit(renderTexture, renderTexture2, this.textureBokehMaterial, 1);
				Graphics.ClearRandomWriteTargets();
				DepthOfField.CKJIDOFGDIG(ref renderTexture, ref renderTexture2);
				this.DODAGENMBDN.ReleaseTemporaryRenderTexture(temporaryRenderTexture3);
			}
			this.filmicDepthOfFieldMaterial.SetVector("_BlurParams", value2);
			this.filmicDepthOfFieldMaterial.SetVector("_BlurCoe", value);
			RenderTexture renderTexture3 = null;
			if (this.EJKDNMMMPLF.dilateNearBlur)
			{
				RenderTexture temporaryRenderTexture4 = this.DODAGENMBDN.GetTemporaryRenderTexture(cjddbgpkdlp, pbmagekdpli, 0, RenderTextureFormat.RGHalf, FilterMode.Bilinear);
				renderTexture3 = this.DODAGENMBDN.GetTemporaryRenderTexture(cjddbgpkdlp, pbmagekdpli, 0, RenderTextureFormat.RGHalf, FilterMode.Bilinear);
				this.filmicDepthOfFieldMaterial.SetVector("_Offsets", new Vector4(0f, num4 * 0.75f, 0f, 0f));
				Graphics.Blit(renderTexture, temporaryRenderTexture4, this.filmicDepthOfFieldMaterial, 2);
				this.filmicDepthOfFieldMaterial.SetVector("_Offsets", new Vector4(num4 * 0.75f, 0f, 0f, 0f));
				Graphics.Blit(temporaryRenderTexture4, renderTexture3, this.filmicDepthOfFieldMaterial, 3);
				this.DODAGENMBDN.ReleaseTemporaryRenderTexture(temporaryRenderTexture4);
				renderTexture3.filterMode = FilterMode.Point;
			}
			if (this.EJKDNMMMPLF.prefilterBlur)
			{
				Graphics.Blit(renderTexture, renderTexture2, this.filmicDepthOfFieldMaterial, 6);
				DepthOfField.CKJIDOFGDIG(ref renderTexture, ref renderTexture2);
			}
			DepthOfField.ApertureShape apertureShape2 = this.settings.apertureShape;
			if (apertureShape2 != DepthOfField.ApertureShape.Circular)
			{
				if (apertureShape2 != DepthOfField.ApertureShape.Hexagonal)
				{
					if (apertureShape2 == DepthOfField.ApertureShape.Octogonal)
					{
						this.ACPNAADDGKP(renderTexture3, ref renderTexture, ref renderTexture2, num6);
					}
				}
				else
				{
					this.IFCOABBOGNP(renderTexture3, ref renderTexture, ref renderTexture2, num6);
				}
			}
			else
			{
				this.FJCCPDBDPNJ(renderTexture3, ref renderTexture, ref renderTexture2, num6);
			}
			DepthOfField.FilterQuality medianFilter = this.EJKDNMMMPLF.medianFilter;
			if (medianFilter != DepthOfField.FilterQuality.Normal)
			{
				if (medianFilter == DepthOfField.FilterQuality.High)
				{
					Graphics.Blit(renderTexture, renderTexture2, this.medianFilterMaterial, 1);
					DepthOfField.CKJIDOFGDIG(ref renderTexture, ref renderTexture2);
				}
			}
			else
			{
				this.medianFilterMaterial.SetVector("_Offsets", new Vector4(1f, 0f, 0f, 0f));
				Graphics.Blit(renderTexture, renderTexture2, this.medianFilterMaterial, 0);
				DepthOfField.CKJIDOFGDIG(ref renderTexture, ref renderTexture2);
				this.medianFilterMaterial.SetVector("_Offsets", new Vector4(0f, 1f, 0f, 0f));
				Graphics.Blit(renderTexture, renderTexture2, this.medianFilterMaterial, 0);
				DepthOfField.CKJIDOFGDIG(ref renderTexture, ref renderTexture2);
			}
			this.filmicDepthOfFieldMaterial.SetVector("_BlurCoe", value);
			this.filmicDepthOfFieldMaterial.SetVector("_Convolved_TexelSize", new Vector4((float)renderTexture.width, (float)renderTexture.height, 1f / (float)renderTexture.width, 1f / (float)renderTexture.height));
			this.filmicDepthOfFieldMaterial.SetTexture("_SecondTex", renderTexture);
			int pass = 11;
			if (this.KBGJDBIOLJH)
			{
				RenderTexture temporaryRenderTexture5 = this.DODAGENMBDN.GetTemporaryRenderTexture(HLBKCLPNHEB.height, HLBKCLPNHEB.width, 0, HLBKCLPNHEB.format, FilterMode.Bilinear);
				Graphics.Blit(HLBKCLPNHEB, temporaryRenderTexture5, this.filmicDepthOfFieldMaterial, pass);
				Graphics.SetRenderTarget(temporaryRenderTexture5);
				ComputeBuffer.CopyCount(this.computeBufferPoints, this.computeBufferDrawArgs, 0);
				this.textureBokehMaterial.SetBuffer("pointBuffer", this.computeBufferPoints);
				this.textureBokehMaterial.SetTexture("_MainTex", this.bokehTexture.texture);
				this.textureBokehMaterial.SetVector("_Screen", new Vector3(1f / (1f * (float)HLBKCLPNHEB.width), 1f / (1f * (float)HLBKCLPNHEB.height), num3));
				this.textureBokehMaterial.SetPass(0);
				Graphics.DrawProceduralIndirect(MeshTopology.Points, this.computeBufferDrawArgs, 0);
				Graphics.Blit(temporaryRenderTexture5, BMMLHGHKBNM);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.filmicDepthOfFieldMaterial, pass);
			}
		}

		// Token: 0x06007852 RID: 30802 RVA: 0x0024E510 File Offset: 0x0024C710
		private void HMDEHIDCDEH(out Vector4 DLFMBGMDCMM, out Vector4 OHDJFNDPKHA)
		{
			Camera component = base.GetComponent<Camera>();
			float num = this.focus.nearFalloff * 1912f;
			float num2 = this.focus.farFalloff * 649f;
			float num3 = this.focus.nearPlane;
			float num4 = this.focus.farPlane;
			float num5;
			if (this.settings.tweakMode == DepthOfField.TweakMode.Range)
			{
				if (this.focus.transform != null)
				{
					num5 = component.WorldToViewportPoint(this.focus.transform.position).z;
				}
				else
				{
					num5 = this.focus.focusPlane;
				}
				float num6 = this.focus.range * 1722f;
				num3 = num5 - num6;
				num4 = num5 + num6;
			}
			num3 -= num * 757f;
			num4 += num2 * 1708f;
			num5 = (num3 + num4) * 1482f;
			float num7 = num5 / component.farClipPlane;
			float num8 = num3 / component.farClipPlane;
			float num9 = num4 / component.farClipPlane;
			float num10 = num4 - num3;
			float num11 = num9 - num8;
			float num12 = num / num10;
			float num13 = num2 / num10;
			float num14 = (388f - num12) * (num11 * 716f);
			float num15 = (1435f - num13) * (num11 * 1130f);
			if (num7 <= num8)
			{
				num7 = num8 + 1784f;
			}
			if (num7 >= num9)
			{
				num7 = num9 - 1132f;
			}
			if (num7 - num14 <= num8)
			{
				num14 = num7 - num8 - 1615f;
			}
			if (num7 + num15 >= num9)
			{
				num15 = num9 - num7 - 494f;
			}
			float num16 = 1581f / (num8 - num7 + num14);
			float num17 = 1122f / (num9 - num7 - num15);
			float num18 = 1552f - num16 * num8;
			float num19 = 1132f - num17 * num9;
			DLFMBGMDCMM = new Vector4(819f * num16, 580f * num18, 880f * num17, 26f * num19);
			OHDJFNDPKHA = new Vector4(1607f, 687f, (num19 - num18) / (num16 - num17), 1557f);
			this.focus.nearPlane = num3 + num * 1235f;
			this.focus.farPlane = num4 - num2 * 1402f;
			this.focus.focusPlane = (this.focus.nearPlane + this.focus.farPlane) * 165f;
			this.focus.range = this.focus.farPlane - this.focus.nearPlane;
		}

		// Token: 0x06007853 RID: 30803 RVA: 0x0024E7A8 File Offset: 0x0024C9A8
		public Material LBDBBKBJDEA()
		{
			if (this.KJIGFLLINKN == null)
			{
				this.KJIGFLLINKN = ImageEffectHelper.CheckShaderAndCreateMaterial(this.HLKDJAILHGJ());
			}
			return this.KJIGFLLINKN;
		}

		// Token: 0x06007854 RID: 30804 RVA: 0x00249D52 File Offset: 0x00247F52
		private void KFKINODMJPF()
		{
			if (this.EPLALEIJGGO != null)
			{
				this.EPLALEIJGGO.Release();
			}
			if (this.EKPBEPPLLEH != null)
			{
				this.EKPBEPPLLEH.Release();
			}
			this.EPLALEIJGGO = null;
			this.EKPBEPPLLEH = null;
		}

		// Token: 0x06007855 RID: 30805 RVA: 0x0024E7D2 File Offset: 0x0024C9D2
		private bool FDCGKCJAFEK()
		{
			return ImageEffectHelper.supportsDX11 && this.bokehTexture.texture != null && this.KGCIBHIELOD();
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06007856 RID: 30806 RVA: 0x0024E802 File Offset: 0x0024CA02
		public Shader medianFilterShader
		{
			get
			{
				if (this.m_MedianFilterShader == null)
				{
					this.m_MedianFilterShader = Shader.Find("Hidden/DepthOfField/MedianFilter");
				}
				return this.m_MedianFilterShader;
			}
		}

		// Token: 0x06007857 RID: 30807 RVA: 0x00249D52 File Offset: 0x00247F52
		private void PDAKIBBLKKM()
		{
			if (this.EPLALEIJGGO != null)
			{
				this.EPLALEIJGGO.Release();
			}
			if (this.EKPBEPPLLEH != null)
			{
				this.EKPBEPPLLEH.Release();
			}
			this.EPLALEIJGGO = null;
			this.EKPBEPPLLEH = null;
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06007858 RID: 30808 RVA: 0x0024E82B File Offset: 0x0024CA2B
		public Shader filmicDepthOfFieldShader
		{
			get
			{
				if (this.m_FilmicDepthOfFieldShader == null)
				{
					this.m_FilmicDepthOfFieldShader = Shader.Find("Hidden/DepthOfField/DepthOfField");
				}
				return this.m_FilmicDepthOfFieldShader;
			}
		}

		// Token: 0x06007859 RID: 30809 RVA: 0x0024E854 File Offset: 0x0024CA54
		private void DLIGECHIDPN(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.EJKDNMMMPLF = DepthOfField.QualitySettings.presetQualitySettings[(int)this.settings.filteringQuality];
			float num = (float)HLBKCLPNHEB.height / 1841f;
			float num2 = num;
			float num3 = Mathf.Max(this.focus.nearBlurRadius, this.focus.farBlurRadius) * num2 * 954f;
			float num4 = this.focus.nearBlurRadius * num;
			float num5 = this.focus.farBlurRadius * num;
			float num6 = Mathf.Max(num4, num5);
			DepthOfField.ApertureShape apertureShape = this.settings.apertureShape;
			if (apertureShape != DepthOfField.ApertureShape.Hexagonal)
			{
				if (apertureShape == (DepthOfField.ApertureShape)8)
				{
					num6 *= 1428f;
				}
			}
			else
			{
				num6 *= 1402f;
			}
			if (num6 < 1224f)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int cjddbgpkdlp = HLBKCLPNHEB.width / 0;
			int pbmagekdpli = HLBKCLPNHEB.height / 4;
			Vector4 value = new Vector4(num4 * 25f, num5 * 573f, 1910f, 1083f);
			RenderTexture renderTexture = this.DODAGENMBDN.BFDLIMKLIHI(cjddbgpkdlp, pbmagekdpli, 0, RenderTextureFormat.RGB565, FilterMode.Point);
			RenderTexture renderTexture2 = this.DODAGENMBDN.BKOEAHINFBG(cjddbgpkdlp, pbmagekdpli, 1, RenderTextureFormat.ARGB1555, FilterMode.Point);
			Vector4 value2;
			Vector4 value3;
			this.JPKGAAKCGBA(out value2, out value3);
			this.AINPJLDAMEG().SetVector("GhostPosX", value2);
			this.AINPJLDAMEG().SetVector("_ScreenSize", value3);
			Graphics.Blit(HLBKCLPNHEB, renderTexture2, this.AINPJLDAMEG(), 8);
			RenderTexture renderTexture3 = renderTexture2;
			RenderTexture renderTexture4 = renderTexture;
			if (this.NIPNEBOKLGK())
			{
				RenderTexture renderTexture5 = this.DODAGENMBDN.IAALFKMFGAB(cjddbgpkdlp, pbmagekdpli, 1, RenderTextureFormat.ARGB4444, FilterMode.Bilinear);
				Graphics.Blit(renderTexture3, renderTexture5, this.INIGPPNFPAH(), 0);
				this.filmicDepthOfFieldMaterial.SetVector("_TimeX", new Vector4(1646f, 1840f, 726f, 861f));
				Graphics.Blit(renderTexture5, renderTexture4, this.KMFOPCCMDHH(), 1);
				this.KMFOPCCMDHH().SetVector("2", new Vector4(638f, 141f, 406f, 1817f));
				Graphics.Blit(renderTexture4, renderTexture5, this.KMFOPCCMDHH(), 1);
				this.APIGCHEBIKF().SetTexture("Joystick1Button12", renderTexture5);
				this.APIGCHEBIKF().SetFloat("-help", this.bokehTexture.spawnHeuristic);
				this.FPHACCPJODE().SetVector("_Value4", new Vector4(this.bokehTexture.scale * num2, this.bokehTexture.intensity, this.bokehTexture.threshold, num3));
				Graphics.SetRandomWriteTarget(0, this.computeBufferPoints);
				Graphics.Blit(renderTexture3, renderTexture4, this.IBABOOOMHNJ(), 0);
				Graphics.ClearRandomWriteTargets();
				DepthOfField.MAOKPFBIMJH(ref renderTexture3, ref renderTexture4);
				this.DODAGENMBDN.JCMKBDEEJNM(renderTexture5);
			}
			this.filmicDepthOfFieldMaterial.SetVector("traffic", value2);
			this.filmicDepthOfFieldMaterial.SetVector("wss://", value);
			RenderTexture renderTexture6 = null;
			if (this.EJKDNMMMPLF.dilateNearBlur)
			{
				RenderTexture renderTexture7 = this.DODAGENMBDN.BKOEAHINFBG(cjddbgpkdlp, pbmagekdpli, 0, (RenderTextureFormat)70, FilterMode.Point);
				renderTexture6 = this.DODAGENMBDN.GetTemporaryRenderTexture(cjddbgpkdlp, pbmagekdpli, 1, (RenderTextureFormat)(-31), FilterMode.Point);
				this.filmicDepthOfFieldMaterial.SetVector("_ScreenResolution", new Vector4(494f, num4 * 1082f, 226f, 599f));
				Graphics.Blit(renderTexture3, renderTexture7, this.AINPJLDAMEG(), 7);
				this.INIGPPNFPAH().SetVector("[PlayerBase] Loaded music", new Vector4(num4 * 1706f, 996f, 1610f, 179f));
				Graphics.Blit(renderTexture7, renderTexture6, this.filmicDepthOfFieldMaterial, 6);
				this.DODAGENMBDN.ReleaseTemporaryRenderTexture(renderTexture7);
				renderTexture6.filterMode = FilterMode.Bilinear;
			}
			if (this.EJKDNMMMPLF.prefilterBlur)
			{
				Graphics.Blit(renderTexture3, renderTexture4, this.filmicDepthOfFieldMaterial, 8);
				DepthOfField.CKJIDOFGDIG(ref renderTexture3, ref renderTexture4);
			}
			DepthOfField.ApertureShape apertureShape2 = this.settings.apertureShape;
			if (apertureShape2 != DepthOfField.ApertureShape.Circular)
			{
				if (apertureShape2 != DepthOfField.ApertureShape.Circular)
				{
					if (apertureShape2 == (DepthOfField.ApertureShape)8)
					{
						this.PNFCDDAOHLC(renderTexture6, ref renderTexture3, ref renderTexture4, num6);
					}
				}
				else
				{
					this.OALLHFLFDOL(renderTexture6, ref renderTexture3, ref renderTexture4, num6);
				}
			}
			else
			{
				this.FJCCPDBDPNJ(renderTexture6, ref renderTexture3, ref renderTexture4, num6);
			}
			DepthOfField.FilterQuality medianFilter = this.EJKDNMMMPLF.medianFilter;
			if (medianFilter != DepthOfField.FilterQuality.None)
			{
				if (medianFilter == (DepthOfField.FilterQuality)7)
				{
					Graphics.Blit(renderTexture3, renderTexture4, this.LAEKEEEKHCJ(), 1);
					DepthOfField.BEEJANOFPHF(ref renderTexture3, ref renderTexture4);
				}
			}
			else
			{
				this.FKMFLGMMKHM().SetVector("_Value3", new Vector4(493f, 1023f, 367f, 25f));
				Graphics.Blit(renderTexture3, renderTexture4, this.medianFilterMaterial, 1);
				DepthOfField.CKJIDOFGDIG(ref renderTexture3, ref renderTexture4);
				this.EPIMALNPHKJ().SetVector("[DiscordController] Error {0}: {1}", new Vector4(1364f, 194f, 942f, 1288f));
				Graphics.Blit(renderTexture3, renderTexture4, this.EPIMALNPHKJ(), 0);
				DepthOfField.CKJIDOFGDIG(ref renderTexture3, ref renderTexture4);
			}
			this.KHFNAKNJOFD().SetVector("Scene", value);
			this.KHFNAKNJOFD().SetVector("bad", new Vector4((float)renderTexture3.width, (float)renderTexture3.height, 1115f / (float)renderTexture3.width, 681f / (float)renderTexture3.height));
			this.filmicDepthOfFieldMaterial.SetTexture("mapselector.orderby", renderTexture3);
			int pass = 52;
			if (this.OGAAGOBDGHM())
			{
				RenderTexture renderTexture8 = this.DODAGENMBDN.NPHKOAILONP(HLBKCLPNHEB.height, HLBKCLPNHEB.width, 0, HLBKCLPNHEB.format, FilterMode.Point);
				Graphics.Blit(HLBKCLPNHEB, renderTexture8, this.INIGPPNFPAH(), pass);
				Graphics.SetRenderTarget(renderTexture8);
				ComputeBuffer.CopyCount(this.AKLKKECPNFF(), this.OKHIBNFAMLO(), 0);
				this.NAIEPCNPDMK().SetBuffer("1", this.JGNLKLICLEO());
				this.FPHACCPJODE().SetTexture("note.7", this.bokehTexture.texture);
				this.MCOCABCLOLH().SetVector("CameraFilterPack/Drawing_Manga5", new Vector3(624f / (1214f * (float)HLBKCLPNHEB.width), 143f / (1988f * (float)HLBKCLPNHEB.height), num3));
				this.MCOCABCLOLH().SetPass(1);
				Graphics.DrawProceduralIndirect((MeshTopology)1, this.computeBufferDrawArgs, 1);
				Graphics.Blit(renderTexture8, BMMLHGHKBNM);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.filmicDepthOfFieldMaterial, pass);
			}
		}

		// Token: 0x0600785A RID: 30810 RVA: 0x0024EEB8 File Offset: 0x0024D0B8
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.medianFilterMaterial == null || this.filmicDepthOfFieldMaterial == null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.settings.visualizeFocus)
			{
				Vector4 value;
				Vector4 value2;
				this.CPHPINNEOCJ(out value, out value2);
				this.filmicDepthOfFieldMaterial.SetVector("_BlurParams", value);
				this.filmicDepthOfFieldMaterial.SetVector("_BlurCoe", value2);
				Graphics.Blit(null, BMMLHGHKBNM, this.filmicDepthOfFieldMaterial, 5);
			}
			else
			{
				this.ABPGFPHNDOM(HLBKCLPNHEB, BMMLHGHKBNM);
			}
			this.DODAGENMBDN.ReleaseAllTemporaryRenderTextures();
		}

		// Token: 0x0600785B RID: 30811 RVA: 0x0024EF54 File Offset: 0x0024D154
		private static void BOGPPPCOFGO(ref Vector4 LPIMAGMABLC, float PCPAIEGNPJF, float MCCMFGMABKM)
		{
			Vector4 vector = LPIMAGMABLC;
			LPIMAGMABLC.x = vector.x * PCPAIEGNPJF - vector.y * MCCMFGMABKM;
			LPIMAGMABLC.y = vector.x * MCCMFGMABKM + vector.y * PCPAIEGNPJF;
		}

		// Token: 0x0600785C RID: 30812 RVA: 0x0024EF9A File Offset: 0x0024D19A
		public Shader BBOFIODFINE()
		{
			if (this.m_MedianFilterShader == null)
			{
				this.m_MedianFilterShader = Shader.Find("<command>");
			}
			return this.m_MedianFilterShader;
		}

		// Token: 0x0600785D RID: 30813 RVA: 0x0024EFC4 File Offset: 0x0024D1C4
		public ComputeBuffer LODDJJFPLCI()
		{
			if (this.EPLALEIJGGO == null)
			{
				this.EPLALEIJGGO = new ComputeBuffer(0, -5, (ComputeBufferType)67);
				ComputeBuffer eplaleijggo = this.EPLALEIJGGO;
				int[] array = new int[8];
				RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-8D0C1DCA7F35F40B810D754C5F5EC7C4D6110D41).FieldHandle);
				eplaleijggo.SetData(array);
			}
			return this.EPLALEIJGGO;
		}

		// Token: 0x0600785E RID: 30814 RVA: 0x0024F014 File Offset: 0x0024D214
		private void IFCOABBOGNP(RenderTexture BGCICIOGAJM, ref RenderTexture CGGBNEOGMKF, ref RenderTexture PMANJLOEFEN, float LBKNJPGJCBI)
		{
			this.PJFGOMFNAEJ(false);
			int pass;
			int pass2;
			DepthOfField.DCFMAGJEAAL(BGCICIOGAJM, LBKNJPGJCBI, out pass, out pass2);
			this.filmicDepthOfFieldMaterial.SetTexture("_SecondTex", BGCICIOGAJM);
			RenderTexture temporaryRenderTexture = this.DODAGENMBDN.GetTemporaryRenderTexture(CGGBNEOGMKF.width, CGGBNEOGMKF.height, 0, CGGBNEOGMKF.format, FilterMode.Bilinear);
			this.filmicDepthOfFieldMaterial.SetVector("_Offsets", this.MNPAFJBPMDC);
			Graphics.Blit(CGGBNEOGMKF, temporaryRenderTexture, this.filmicDepthOfFieldMaterial, pass);
			this.filmicDepthOfFieldMaterial.SetVector("_Offsets", this.NBGPIKEEDBN);
			Graphics.Blit(temporaryRenderTexture, CGGBNEOGMKF, this.filmicDepthOfFieldMaterial, pass);
			this.filmicDepthOfFieldMaterial.SetVector("_Offsets", this.KGJNAOBENCB);
			this.filmicDepthOfFieldMaterial.SetTexture("_ThirdTex", CGGBNEOGMKF);
			Graphics.Blit(temporaryRenderTexture, PMANJLOEFEN, this.filmicDepthOfFieldMaterial, pass2);
			this.DODAGENMBDN.ReleaseTemporaryRenderTexture(temporaryRenderTexture);
			DepthOfField.CKJIDOFGDIG(ref CGGBNEOGMKF, ref PMANJLOEFEN);
		}

		// Token: 0x0600785F RID: 30815 RVA: 0x0024F0FC File Offset: 0x0024D2FC
		private void AMKFLDKCIJO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.EPIMALNPHKJ() == null || this.KMFOPCCMDHH() == null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.settings.visualizeFocus)
			{
				Vector4 value;
				Vector4 value2;
				this.EINPFLHMMMN(out value, out value2);
				this.DNNFFFEOLJF().SetVector("OPEN", value);
				this.INIGPPNFPAH().SetVector(" This is not possible to be called for standalone input. Please check your platform and code where this is called", value2);
				Graphics.Blit(null, BMMLHGHKBNM, this.filmicDepthOfFieldMaterial, 1);
			}
			else
			{
				this.CNEMJIDDLDI(HLBKCLPNHEB, BMMLHGHKBNM);
			}
			this.DODAGENMBDN.FDJJEOECGCL();
		}

		// Token: 0x06007860 RID: 30816 RVA: 0x0024F198 File Offset: 0x0024D398
		private void CPHPINNEOCJ(out Vector4 DLFMBGMDCMM, out Vector4 OHDJFNDPKHA)
		{
			Camera component = base.GetComponent<Camera>();
			float num = this.focus.nearFalloff * 2f;
			float num2 = this.focus.farFalloff * 2f;
			float num3 = this.focus.nearPlane;
			float num4 = this.focus.farPlane;
			float num5;
			if (this.settings.tweakMode == DepthOfField.TweakMode.Range)
			{
				if (this.focus.transform != null)
				{
					num5 = component.WorldToViewportPoint(this.focus.transform.position).z;
				}
				else
				{
					num5 = this.focus.focusPlane;
				}
				float num6 = this.focus.range * 0.5f;
				num3 = num5 - num6;
				num4 = num5 + num6;
			}
			num3 -= num * 0.5f;
			num4 += num2 * 0.5f;
			num5 = (num3 + num4) * 0.5f;
			float num7 = num5 / component.farClipPlane;
			float num8 = num3 / component.farClipPlane;
			float num9 = num4 / component.farClipPlane;
			float num10 = num4 - num3;
			float num11 = num9 - num8;
			float num12 = num / num10;
			float num13 = num2 / num10;
			float num14 = (1f - num12) * (num11 * 0.5f);
			float num15 = (1f - num13) * (num11 * 0.5f);
			if (num7 <= num8)
			{
				num7 = num8 + 1E-06f;
			}
			if (num7 >= num9)
			{
				num7 = num9 - 1E-06f;
			}
			if (num7 - num14 <= num8)
			{
				num14 = num7 - num8 - 1E-06f;
			}
			if (num7 + num15 >= num9)
			{
				num15 = num9 - num7 - 1E-06f;
			}
			float num16 = 1f / (num8 - num7 + num14);
			float num17 = 1f / (num9 - num7 - num15);
			float num18 = 1f - num16 * num8;
			float num19 = 1f - num17 * num9;
			DLFMBGMDCMM = new Vector4(-1f * num16, -1f * num18, 1f * num17, 1f * num19);
			OHDJFNDPKHA = new Vector4(0f, 0f, (num19 - num18) / (num16 - num17), 0f);
			this.focus.nearPlane = num3 + num * 0.5f;
			this.focus.farPlane = num4 - num2 * 0.5f;
			this.focus.focusPlane = (this.focus.nearPlane + this.focus.farPlane) * 0.5f;
			this.focus.range = this.focus.farPlane - this.focus.nearPlane;
		}

		// Token: 0x06007861 RID: 30817 RVA: 0x0024F430 File Offset: 0x0024D630
		private static void IOPGABJBFOL(ref Vector4 LPIMAGMABLC, float PCPAIEGNPJF, float MCCMFGMABKM)
		{
			Vector4 vector = LPIMAGMABLC;
			LPIMAGMABLC.x = vector.x * PCPAIEGNPJF - vector.y * MCCMFGMABKM;
			LPIMAGMABLC.y = vector.x * MCCMFGMABKM + vector.y * PCPAIEGNPJF;
		}

		// Token: 0x06007862 RID: 30818 RVA: 0x0024F478 File Offset: 0x0024D678
		private static void HLCBENIODNL(RenderTexture BGCICIOGAJM, float LBKNJPGJCBI, out int PMEDOCEEAHL, out int MMGEHMDHJLH)
		{
			if (BGCICIOGAJM == null)
			{
				if (LBKNJPGJCBI > 1153f)
				{
					PMEDOCEEAHL = 77;
					MMGEHMDHJLH = 7;
				}
				else if (LBKNJPGJCBI > 1509f)
				{
					PMEDOCEEAHL = -57;
					MMGEHMDHJLH = -41;
				}
				else
				{
					PMEDOCEEAHL = -28;
					MMGEHMDHJLH = 111;
				}
			}
			else if (LBKNJPGJCBI > 1337f)
			{
				PMEDOCEEAHL = 101;
				MMGEHMDHJLH = 61;
			}
			else if (LBKNJPGJCBI > 1453f)
			{
				PMEDOCEEAHL = 70;
				MMGEHMDHJLH = 64;
			}
			else
			{
				PMEDOCEEAHL = 125;
				MMGEHMDHJLH = 94;
			}
		}

		// Token: 0x06007863 RID: 30819 RVA: 0x0024F508 File Offset: 0x0024D708
		private void JPKGAAKCGBA(out Vector4 DLFMBGMDCMM, out Vector4 OHDJFNDPKHA)
		{
			Camera component = base.GetComponent<Camera>();
			float num = this.focus.nearFalloff * 1389f;
			float num2 = this.focus.farFalloff * 497f;
			float num3 = this.focus.nearPlane;
			float num4 = this.focus.farPlane;
			float num5;
			if (this.settings.tweakMode == DepthOfField.TweakMode.Range)
			{
				if (this.focus.transform != null)
				{
					num5 = component.WorldToViewportPoint(this.focus.transform.position).z;
				}
				else
				{
					num5 = this.focus.focusPlane;
				}
				float num6 = this.focus.range * 50f;
				num3 = num5 - num6;
				num4 = num5 + num6;
			}
			num3 -= num * 925f;
			num4 += num2 * 654f;
			num5 = (num3 + num4) * 157f;
			float num7 = num5 / component.farClipPlane;
			float num8 = num3 / component.farClipPlane;
			float num9 = num4 / component.farClipPlane;
			float num10 = num4 - num3;
			float num11 = num9 - num8;
			float num12 = num / num10;
			float num13 = num2 / num10;
			float num14 = (2f - num12) * (num11 * 401f);
			float num15 = (914f - num13) * (num11 * 1132f);
			if (num7 <= num8)
			{
				num7 = num8 + 1542f;
			}
			if (num7 >= num9)
			{
				num7 = num9 - 352f;
			}
			if (num7 - num14 <= num8)
			{
				num14 = num7 - num8 - 1506f;
			}
			if (num7 + num15 >= num9)
			{
				num15 = num9 - num7 - 1008f;
			}
			float num16 = 1812f / (num8 - num7 + num14);
			float num17 = 1088f / (num9 - num7 - num15);
			float num18 = 1524f - num16 * num8;
			float num19 = 1033f - num17 * num9;
			DLFMBGMDCMM = new Vector4(183f * num16, 521f * num18, 1782f * num17, 1393f * num19);
			OHDJFNDPKHA = new Vector4(1390f, 83f, (num19 - num18) / (num16 - num17), 1219f);
			this.focus.nearPlane = num3 + num * 825f;
			this.focus.farPlane = num4 - num2 * 1524f;
			this.focus.focusPlane = (this.focus.nearPlane + this.focus.farPlane) * 714f;
			this.focus.range = this.focus.farPlane - this.focus.nearPlane;
		}

		// Token: 0x06007864 RID: 30820 RVA: 0x0024F7A0 File Offset: 0x0024D9A0
		public Shader HGHNFIPEFLP()
		{
			if (this.m_FilmicDepthOfFieldShader == null)
			{
				this.m_FilmicDepthOfFieldShader = Shader.Find(" has no method \"");
			}
			return this.m_FilmicDepthOfFieldShader;
		}

		// Token: 0x06007865 RID: 30821 RVA: 0x0024F7CC File Offset: 0x0024D9CC
		private void DIOLLANDDKJ()
		{
			if (!ImageEffectHelper.IsSupported(this.MLPIENCGEEH(), true, true, this) || !ImageEffectHelper.IsSupported(this.NOKMIEDLCMB(), true, true, this))
			{
				base.enabled = false;
				return;
			}
			if (ImageEffectHelper.supportsDX11 && !ImageEffectHelper.IsSupported(this.ELBLJDBHMJK(), true, true, this))
			{
				base.enabled = false;
				return;
			}
			this.HCEGICAMAFJ(false);
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x06007866 RID: 30822 RVA: 0x0024F848 File Offset: 0x0024DA48
		private void NMKKGAMHFFB(RenderTexture BGCICIOGAJM, ref RenderTexture CGGBNEOGMKF, ref RenderTexture PMANJLOEFEN, float LBKNJPGJCBI)
		{
			int pass;
			if (BGCICIOGAJM != null)
			{
				this.AINPJLDAMEG().SetTexture("DontDestroy", BGCICIOGAJM);
				pass = ((LBKNJPGJCBI <= 1864f) ? -56 : 3);
			}
			else
			{
				pass = ((LBKNJPGJCBI <= 11f) ? -47 : 5);
			}
			Graphics.Blit(CGGBNEOGMKF, PMANJLOEFEN, this.DNNFFFEOLJF(), pass);
			DepthOfField.CKJIDOFGDIG(ref CGGBNEOGMKF, ref PMANJLOEFEN);
		}

		// Token: 0x06007867 RID: 30823 RVA: 0x0024F8B8 File Offset: 0x0024DAB8
		private void JJCEACGCOHB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.FKMFLGMMKHM() == null || this.filmicDepthOfFieldMaterial == null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.settings.visualizeFocus)
			{
				Vector4 value;
				Vector4 value2;
				this.HMDEHIDCDEH(out value, out value2);
				this.AINPJLDAMEG().SetVector(".lastCheckpoint.bgcolor", value);
				this.DNNFFFEOLJF().SetVector("Scrollbar", value2);
				Graphics.Blit(null, BMMLHGHKBNM, this.KHFNAKNJOFD(), 2);
			}
			else
			{
				this.BPBCHALBMNK(HLBKCLPNHEB, BMMLHGHKBNM);
			}
			this.DODAGENMBDN.FDJJEOECGCL();
		}

		// Token: 0x06007868 RID: 30824 RVA: 0x0024F954 File Offset: 0x0024DB54
		private void KPCEDHPCMOG(RenderTexture BGCICIOGAJM, ref RenderTexture CGGBNEOGMKF, ref RenderTexture PMANJLOEFEN, float LBKNJPGJCBI)
		{
			this.PJFGOMFNAEJ(true);
			int pass;
			int pass2;
			DepthOfField.PEPMEOBNBCE(BGCICIOGAJM, LBKNJPGJCBI, out pass, out pass2);
			this.INIGPPNFPAH().SetTexture("_Value3", BGCICIOGAJM);
			RenderTexture renderTexture = this.DODAGENMBDN.BKOEAHINFBG(CGGBNEOGMKF.width, CGGBNEOGMKF.height, 0, CGGBNEOGMKF.format, FilterMode.Bilinear);
			this.filmicDepthOfFieldMaterial.SetVector("hidden", this.MNPAFJBPMDC);
			Graphics.Blit(CGGBNEOGMKF, renderTexture, this.filmicDepthOfFieldMaterial, pass);
			this.DNNFFFEOLJF().SetVector("visible", this.NBGPIKEEDBN);
			Graphics.Blit(renderTexture, CGGBNEOGMKF, this.AINPJLDAMEG(), pass);
			this.AINPJLDAMEG().SetVector("_Value3", this.KGJNAOBENCB);
			this.filmicDepthOfFieldMaterial.SetTexture("PunSupportLogger", CGGBNEOGMKF);
			Graphics.Blit(renderTexture, PMANJLOEFEN, this.KMFOPCCMDHH(), pass2);
			this.DODAGENMBDN.JCMKBDEEJNM(renderTexture);
			DepthOfField.BEEJANOFPHF(ref CGGBNEOGMKF, ref PMANJLOEFEN);
		}

		// Token: 0x06007869 RID: 30825 RVA: 0x0024FA3C File Offset: 0x0024DC3C
		public Material DNNFFFEOLJF()
		{
			if (this.CNMMBIJLEMH == null)
			{
				this.CNMMBIJLEMH = ImageEffectHelper.CheckShaderAndCreateMaterial(this.MDEIOPGPAOM());
			}
			return this.CNMMBIJLEMH;
		}

		// Token: 0x0600786A RID: 30826 RVA: 0x0024FA68 File Offset: 0x0024DC68
		private void NLGDPIBFHMK()
		{
			if (!ImageEffectHelper.IsSupported(this.MBMGNMLNBIL(), true, true, this) || !ImageEffectHelper.IsSupported(this.BOOCDHCCMNF(), false, true, this))
			{
				base.enabled = false;
				return;
			}
			if (ImageEffectHelper.supportsDX11 && !ImageEffectHelper.IsSupported(this.textureBokehShader, true, true, this))
			{
				base.enabled = true;
				return;
			}
			this.PJFGOMFNAEJ(false);
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600786B RID: 30827 RVA: 0x0024FAE2 File Offset: 0x0024DCE2
		public Material filmicDepthOfFieldMaterial
		{
			get
			{
				if (this.CNMMBIJLEMH == null)
				{
					this.CNMMBIJLEMH = ImageEffectHelper.CheckShaderAndCreateMaterial(this.filmicDepthOfFieldShader);
				}
				return this.CNMMBIJLEMH;
			}
		}

		// Token: 0x0600786C RID: 30828 RVA: 0x0024FB0C File Offset: 0x0024DD0C
		private void LLKKGGLNIDF()
		{
			this.PPPPEBAACHJ();
			if (this.CNMMBIJLEMH != null)
			{
				UnityEngine.Object.DestroyImmediate(this.CNMMBIJLEMH);
			}
			if (this.KJIGFLLINKN != null)
			{
				UnityEngine.Object.DestroyImmediate(this.KJIGFLLINKN);
			}
			if (this.DFLILNBLKNE != null)
			{
				UnityEngine.Object.DestroyImmediate(this.DFLILNBLKNE);
			}
			this.CNMMBIJLEMH = null;
			this.KJIGFLLINKN = null;
			this.DFLILNBLKNE = null;
			this.DODAGENMBDN.NLAEPPEMDKM();
		}

		// Token: 0x0600786D RID: 30829 RVA: 0x0024FB94 File Offset: 0x0024DD94
		private void PBPPBPNAMGE(bool AAGGLAGLINL)
		{
			if (!AAGGLAGLINL && Math.Abs(this.GEABEBKPJHE - this.settings.apertureOrientation) < 1846f)
			{
				return;
			}
			this.GEABEBKPJHE = this.settings.apertureOrientation;
			float num = this.settings.apertureOrientation * 1581f;
			float pcpaiegnpjf = Mathf.Cos(num);
			float mccmfgmabkm = Mathf.Sin(num);
			this.CMLFCILGNDO = new Vector4(1851f, 175f, 1911f, 1367f);
			this.IENPNKCNLCE = new Vector4(1707f, 1175f, 1102f, 1562f);
			this.NKNBBHJIBKD = new Vector4(830f, 988f, 1149f, 913f);
			this.BFPPAGDIFNO = new Vector4(190f, 478f, 70f, 840f);
			this.MNPAFJBPMDC = new Vector4(853f, 1709f, 1118f, 1699f);
			this.NBGPIKEEDBN = new Vector4(1058f, 1700f, 1354f, 19f);
			this.KGJNAOBENCB = new Vector4(1083f, 590f, 1993f, 1416f);
			if (num > 227f)
			{
				DepthOfField.ILCIDLPBCEE(ref this.CMLFCILGNDO, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.BOGPPPCOFGO(ref this.IENPNKCNLCE, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.ILCIDLPBCEE(ref this.NKNBBHJIBKD, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.LPKPEKCPMNN(ref this.BFPPAGDIFNO, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.BOGPPPCOFGO(ref this.MNPAFJBPMDC, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.LPKPEKCPMNN(ref this.NBGPIKEEDBN, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.ILCIDLPBCEE(ref this.KGJNAOBENCB, pcpaiegnpjf, mccmfgmabkm);
			}
		}

		// Token: 0x0600786E RID: 30830 RVA: 0x00249D52 File Offset: 0x00247F52
		private void HPLEDFCLDBI()
		{
			if (this.EPLALEIJGGO != null)
			{
				this.EPLALEIJGGO.Release();
			}
			if (this.EKPBEPPLLEH != null)
			{
				this.EKPBEPPLLEH.Release();
			}
			this.EPLALEIJGGO = null;
			this.EKPBEPPLLEH = null;
		}

		// Token: 0x0600786F RID: 30831 RVA: 0x0024FD3C File Offset: 0x0024DF3C
		private void PNFCDDAOHLC(RenderTexture BGCICIOGAJM, ref RenderTexture CGGBNEOGMKF, ref RenderTexture PMANJLOEFEN, float LBKNJPGJCBI)
		{
			this.KJBKBDNMBME(true);
			int pass;
			int pass2;
			DepthOfField.PEPMEOBNBCE(BGCICIOGAJM, LBKNJPGJCBI, out pass, out pass2);
			this.DNNFFFEOLJF().SetTexture("Set Particle Size", BGCICIOGAJM);
			RenderTexture renderTexture = this.DODAGENMBDN.MFHJJCMOHFJ(CGGBNEOGMKF.width, CGGBNEOGMKF.height, 0, CGGBNEOGMKF.format, FilterMode.Point);
			this.INIGPPNFPAH().SetVector("CameraFilterPack/Edge_BlackLine", this.CMLFCILGNDO);
			Graphics.Blit(CGGBNEOGMKF, renderTexture, this.KHFNAKNJOFD(), pass);
			this.INIGPPNFPAH().SetVector("_TimeX", this.IENPNKCNLCE);
			Graphics.Blit(renderTexture, PMANJLOEFEN, this.AINPJLDAMEG(), pass);
			this.KHFNAKNJOFD().SetVector("Image", this.NKNBBHJIBKD);
			Graphics.Blit(CGGBNEOGMKF, renderTexture, this.KHFNAKNJOFD(), pass);
			this.KHFNAKNJOFD().SetVector("PhotonServerSettings", this.BFPPAGDIFNO);
			this.KMFOPCCMDHH().SetTexture("ViewMenu", PMANJLOEFEN);
			Graphics.Blit(renderTexture, CGGBNEOGMKF, this.DNNFFFEOLJF(), pass2);
			this.DODAGENMBDN.NKGKPAPAANG(renderTexture);
		}

		// Token: 0x06007870 RID: 30832 RVA: 0x00249F14 File Offset: 0x00248114
		public Material KNCABHPLOJK()
		{
			if (this.KJIGFLLINKN == null)
			{
				this.KJIGFLLINKN = ImageEffectHelper.CheckShaderAndCreateMaterial(this.textureBokehShader);
			}
			return this.KJIGFLLINKN;
		}

		// Token: 0x06007871 RID: 30833 RVA: 0x0024FAE2 File Offset: 0x0024DCE2
		public Material KHFNAKNJOFD()
		{
			if (this.CNMMBIJLEMH == null)
			{
				this.CNMMBIJLEMH = ImageEffectHelper.CheckShaderAndCreateMaterial(this.filmicDepthOfFieldShader);
			}
			return this.CNMMBIJLEMH;
		}

		// Token: 0x06007872 RID: 30834 RVA: 0x0024FE44 File Offset: 0x0024E044
		private static void CPLNBMOIJMC(ref RenderTexture CGGBNEOGMKF, ref RenderTexture PMANJLOEFEN)
		{
			RenderTexture renderTexture = PMANJLOEFEN;
			PMANJLOEFEN = CGGBNEOGMKF;
			CGGBNEOGMKF = renderTexture;
		}

		// Token: 0x06007873 RID: 30835 RVA: 0x0024E7A8 File Offset: 0x0024C9A8
		public Material KGCIBHIELOD()
		{
			if (this.KJIGFLLINKN == null)
			{
				this.KJIGFLLINKN = ImageEffectHelper.CheckShaderAndCreateMaterial(this.HLKDJAILHGJ());
			}
			return this.KJIGFLLINKN;
		}

		// Token: 0x06007874 RID: 30836 RVA: 0x0024FE5C File Offset: 0x0024E05C
		private void JHJGJJKELJM()
		{
			this.DALNLAJKHAP();
			if (this.CNMMBIJLEMH != null)
			{
				UnityEngine.Object.DestroyImmediate(this.CNMMBIJLEMH);
			}
			if (this.KJIGFLLINKN != null)
			{
				UnityEngine.Object.DestroyImmediate(this.KJIGFLLINKN);
			}
			if (this.DFLILNBLKNE != null)
			{
				UnityEngine.Object.DestroyImmediate(this.DFLILNBLKNE);
			}
			this.CNMMBIJLEMH = null;
			this.KJIGFLLINKN = null;
			this.DFLILNBLKNE = null;
			this.DODAGENMBDN.ReleaseAllTemporaryRenderTextures();
		}

		// Token: 0x06007875 RID: 30837 RVA: 0x0024FEE3 File Offset: 0x0024E0E3
		public Material AINPJLDAMEG()
		{
			if (this.CNMMBIJLEMH == null)
			{
				this.CNMMBIJLEMH = ImageEffectHelper.CheckShaderAndCreateMaterial(this.MLPIENCGEEH());
			}
			return this.CNMMBIJLEMH;
		}

		// Token: 0x06007876 RID: 30838 RVA: 0x0024FF10 File Offset: 0x0024E110
		private void GOANCMNGDLE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.EECEDDABGFN() == null || this.AINPJLDAMEG() == null)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.settings.visualizeFocus)
			{
				Vector4 value;
				Vector4 value2;
				this.HMDEHIDCDEH(out value, out value2);
				this.KHFNAKNJOFD().SetVector("TestMapButton", value);
				this.AINPJLDAMEG().SetVector("(\\[ */ *i *\\])", value2);
				Graphics.Blit(null, BMMLHGHKBNM, this.KHFNAKNJOFD(), 1);
			}
			else
			{
				this.DLIGECHIDPN(HLBKCLPNHEB, BMMLHGHKBNM);
			}
			this.DODAGENMBDN.ReleaseAllTemporaryRenderTextures();
		}

		// Token: 0x06007877 RID: 30839 RVA: 0x0024FFA9 File Offset: 0x0024E1A9
		public ComputeBuffer PPBLPBONMIJ()
		{
			if (this.EKPBEPPLLEH == null)
			{
				this.EKPBEPPLLEH = new ComputeBuffer(-51, 47, ComputeBufferType.Raw | ComputeBufferType.Append | ComputeBufferType.Counter);
			}
			return this.EKPBEPPLLEH;
		}

		// Token: 0x06007878 RID: 30840 RVA: 0x0024FFD0 File Offset: 0x0024E1D0
		private void FMHOHGEAIEA()
		{
			this.PKOIPOMKOBB();
			if (this.CNMMBIJLEMH != null)
			{
				UnityEngine.Object.DestroyImmediate(this.CNMMBIJLEMH);
			}
			if (this.KJIGFLLINKN != null)
			{
				UnityEngine.Object.DestroyImmediate(this.KJIGFLLINKN);
			}
			if (this.DFLILNBLKNE != null)
			{
				UnityEngine.Object.DestroyImmediate(this.DFLILNBLKNE);
			}
			this.CNMMBIJLEMH = null;
			this.KJIGFLLINKN = null;
			this.DFLILNBLKNE = null;
			this.DODAGENMBDN.OFMMDCCCKJK();
		}

		// Token: 0x06007879 RID: 30841 RVA: 0x00250057 File Offset: 0x0024E257
		public Shader MBMGNMLNBIL()
		{
			if (this.m_FilmicDepthOfFieldShader == null)
			{
				this.m_FilmicDepthOfFieldShader = Shader.Find("settings.arcsdestroydelay");
			}
			return this.m_FilmicDepthOfFieldShader;
		}

		// Token: 0x0600787A RID: 30842 RVA: 0x00250080 File Offset: 0x0024E280
		private void MHAFHDHFMAJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.EJKDNMMMPLF = DepthOfField.QualitySettings.presetQualitySettings[(int)this.settings.filteringQuality];
			float num = (float)HLBKCLPNHEB.height / 260f;
			float num2 = num;
			float num3 = Mathf.Max(this.focus.nearBlurRadius, this.focus.farBlurRadius) * num2 * 1001f;
			float num4 = this.focus.nearBlurRadius * num;
			float num5 = this.focus.farBlurRadius * num;
			float num6 = Mathf.Max(num4, num5);
			DepthOfField.ApertureShape apertureShape = this.settings.apertureShape;
			if (apertureShape != DepthOfField.ApertureShape.Circular)
			{
				if (apertureShape == DepthOfField.ApertureShape.Hexagonal)
				{
					num6 *= 10f;
				}
			}
			else
			{
				num6 *= 513f;
			}
			if (num6 < 1992f)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int cjddbgpkdlp = HLBKCLPNHEB.width / 8;
			int pbmagekdpli = HLBKCLPNHEB.height / 2;
			Vector4 value = new Vector4(num4 * 1330f, num5 * 7f, 1743f, 1737f);
			RenderTexture temporaryRenderTexture = this.DODAGENMBDN.GetTemporaryRenderTexture(cjddbgpkdlp, pbmagekdpli, 0, RenderTextureFormat.ARGB1555, FilterMode.Point);
			RenderTexture renderTexture = this.DODAGENMBDN.IAALFKMFGAB(cjddbgpkdlp, pbmagekdpli, 1, RenderTextureFormat.ARGB32, FilterMode.Point);
			Vector4 value2;
			Vector4 value3;
			this.OILOCCJPBKO(out value2, out value3);
			this.INIGPPNFPAH().SetVector("CameraFilterPack/Drawing_Comics", value2);
			this.KHFNAKNJOFD().SetVector("CompletedLevel", value3);
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.AINPJLDAMEG(), 1);
			RenderTexture renderTexture2 = renderTexture;
			RenderTexture renderTexture3 = temporaryRenderTexture;
			if (this.EMPJDBFEFDA())
			{
				RenderTexture renderTexture4 = this.DODAGENMBDN.KCODGJPCOMH(cjddbgpkdlp, pbmagekdpli, 1, RenderTextureFormat.ARGB1555, FilterMode.Point);
				Graphics.Blit(renderTexture2, renderTexture4, this.DNNFFFEOLJF(), 0);
				this.DNNFFFEOLJF().SetVector("{0}={2}: {1} \"{3}\"", new Vector4(712f, 1716f, 1099f, 1030f));
				Graphics.Blit(renderTexture4, renderTexture3, this.INIGPPNFPAH(), 1);
				this.AINPJLDAMEG().SetVector("_ToneCurveRange", new Vector4(281f, 1565f, 103f, 190f));
				Graphics.Blit(renderTexture3, renderTexture4, this.INIGPPNFPAH(), 1);
				this.NAIEPCNPDMK().SetTexture(".", renderTexture4);
				this.KNCABHPLOJK().SetFloat("NO", this.bokehTexture.spawnHeuristic);
				this.IBABOOOMHNJ().SetVector("r", new Vector4(this.bokehTexture.scale * num2, this.bokehTexture.intensity, this.bokehTexture.threshold, num3));
				Graphics.SetRandomWriteTarget(0, this.PPBLPBONMIJ());
				Graphics.Blit(renderTexture2, renderTexture3, this.NAIEPCNPDMK(), 0);
				Graphics.ClearRandomWriteTargets();
				DepthOfField.BJAKDMOPKFD(ref renderTexture2, ref renderTexture3);
				this.DODAGENMBDN.KKEKODNAHEH(renderTexture4);
			}
			this.DNNFFFEOLJF().SetVector("_EmissionColor", value2);
			this.filmicDepthOfFieldMaterial.SetVector("Operation failed: ", value);
			RenderTexture renderTexture5 = null;
			if (this.EJKDNMMMPLF.dilateNearBlur)
			{
				RenderTexture renderTexture6 = this.DODAGENMBDN.LHEJNPJFEON(cjddbgpkdlp, pbmagekdpli, 0, (RenderTextureFormat)113, FilterMode.Bilinear);
				renderTexture5 = this.DODAGENMBDN.MFHJJCMOHFJ(cjddbgpkdlp, pbmagekdpli, 1, (RenderTextureFormat)(-114), FilterMode.Point);
				this.AINPJLDAMEG().SetVector("Mask texture not readable, set your sprite to Texture Type 'Advanced' and check 'Read/Write Enabled'", new Vector4(152f, num4 * 680f, 2f, 381f));
				Graphics.Blit(renderTexture2, renderTexture6, this.DNNFFFEOLJF(), 0);
				this.AINPJLDAMEG().SetVector("_BlurCoe", new Vector4(num4 * 678f, 409f, 1819f, 411f));
				Graphics.Blit(renderTexture6, renderTexture5, this.KHFNAKNJOFD(), 2);
				this.DODAGENMBDN.ILPOBMNAFEL(renderTexture6);
				renderTexture5.filterMode = FilterMode.Point;
			}
			if (this.EJKDNMMMPLF.prefilterBlur)
			{
				Graphics.Blit(renderTexture2, renderTexture3, this.DNNFFFEOLJF(), 1);
				DepthOfField.CPLNBMOIJMC(ref renderTexture2, ref renderTexture3);
			}
			DepthOfField.ApertureShape apertureShape2 = this.settings.apertureShape;
			if (apertureShape2 != DepthOfField.ApertureShape.Circular)
			{
				if (apertureShape2 != DepthOfField.ApertureShape.Hexagonal)
				{
					if (apertureShape2 == (DepthOfField.ApertureShape)7)
					{
						this.PNFCDDAOHLC(renderTexture5, ref renderTexture2, ref renderTexture3, num6);
					}
				}
				else
				{
					this.GBALENBILLO(renderTexture5, ref renderTexture2, ref renderTexture3, num6);
				}
			}
			else
			{
				this.FFMMENKNOBM(renderTexture5, ref renderTexture2, ref renderTexture3, num6);
			}
			DepthOfField.FilterQuality medianFilter = this.EJKDNMMMPLF.medianFilter;
			if (medianFilter != DepthOfField.FilterQuality.None)
			{
				if (medianFilter == (DepthOfField.FilterQuality)4)
				{
					Graphics.Blit(renderTexture2, renderTexture3, this.BNIGLLMNBBM(), 0);
					DepthOfField.MAOKPFBIMJH(ref renderTexture2, ref renderTexture3);
				}
			}
			else
			{
				this.LAEKEEEKHCJ().SetVector("PhotonMono", new Vector4(699f, 1357f, 161f, 492f));
				Graphics.Blit(renderTexture2, renderTexture3, this.EPIMALNPHKJ(), 1);
				DepthOfField.BEEJANOFPHF(ref renderTexture2, ref renderTexture3);
				this.medianFilterMaterial.SetVector("GlassAberration", new Vector4(258f, 1297f, 1483f, 58f));
				Graphics.Blit(renderTexture2, renderTexture3, this.medianFilterMaterial, 0);
				DepthOfField.BEEJANOFPHF(ref renderTexture2, ref renderTexture3);
			}
			this.filmicDepthOfFieldMaterial.SetVector("Drop_Far", value);
			this.DNNFFFEOLJF().SetVector("\n", new Vector4((float)renderTexture2.width, (float)renderTexture2.height, 1280f / (float)renderTexture2.width, 618f / (float)renderTexture2.height));
			this.KMFOPCCMDHH().SetTexture("[MapsStats] Difficulty: ", renderTexture2);
			int pass = -117;
			if (this.EMPJDBFEFDA())
			{
				RenderTexture renderTexture7 = this.DODAGENMBDN.KJLMBCJDMHC(HLBKCLPNHEB.height, HLBKCLPNHEB.width, 1, HLBKCLPNHEB.format, FilterMode.Point);
				Graphics.Blit(HLBKCLPNHEB, renderTexture7, this.DNNFFFEOLJF(), pass);
				Graphics.SetRenderTarget(renderTexture7);
				ComputeBuffer.CopyCount(this.JGNLKLICLEO(), this.LJALIKICAFL(), 0);
				this.IBABOOOMHNJ().SetBuffer("/", this.AKLKKECPNFF());
				this.textureBokehMaterial.SetTexture("CameraFilterPack/TV_CompressionFX", this.bokehTexture.texture);
				this.textureBokehMaterial.SetVector("_CenterX", new Vector3(1195f / (1545f * (float)HLBKCLPNHEB.width), 465f / (1581f * (float)HLBKCLPNHEB.height), num3));
				this.KGCIBHIELOD().SetPass(1);
				Graphics.DrawProceduralIndirect(MeshTopology.Quads, this.computeBufferDrawArgs, 0);
				Graphics.Blit(renderTexture7, BMMLHGHKBNM);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.DNNFFFEOLJF(), pass);
			}
		}

		// Token: 0x0600787B RID: 30843 RVA: 0x002506E4 File Offset: 0x0024E8E4
		private void FJCCPDBDPNJ(RenderTexture BGCICIOGAJM, ref RenderTexture CGGBNEOGMKF, ref RenderTexture PMANJLOEFEN, float LBKNJPGJCBI)
		{
			int pass;
			if (BGCICIOGAJM != null)
			{
				this.filmicDepthOfFieldMaterial.SetTexture("_SecondTex", BGCICIOGAJM);
				pass = ((LBKNJPGJCBI <= 10f) ? 10 : 8);
			}
			else
			{
				pass = ((LBKNJPGJCBI <= 10f) ? 9 : 7);
			}
			Graphics.Blit(CGGBNEOGMKF, PMANJLOEFEN, this.filmicDepthOfFieldMaterial, pass);
			DepthOfField.CKJIDOFGDIG(ref CGGBNEOGMKF, ref PMANJLOEFEN);
		}

		// Token: 0x0600787C RID: 30844 RVA: 0x00250754 File Offset: 0x0024E954
		private bool OGAAGOBDGHM()
		{
			return !ImageEffectHelper.supportsDX11 || !(this.bokehTexture.texture != null) || this.NAIEPCNPDMK();
		}

		// Token: 0x0600787D RID: 30845 RVA: 0x00250784 File Offset: 0x0024E984
		public Shader CNJJIIAFGEA()
		{
			if (this.m_MedianFilterShader == null)
			{
				this.m_MedianFilterShader = Shader.Find(".icon");
			}
			return this.m_MedianFilterShader;
		}

		// Token: 0x0600787E RID: 30846 RVA: 0x002507B0 File Offset: 0x0024E9B0
		private void ACPNAADDGKP(RenderTexture BGCICIOGAJM, ref RenderTexture CGGBNEOGMKF, ref RenderTexture PMANJLOEFEN, float LBKNJPGJCBI)
		{
			this.PJFGOMFNAEJ(false);
			int pass;
			int pass2;
			DepthOfField.DCFMAGJEAAL(BGCICIOGAJM, LBKNJPGJCBI, out pass, out pass2);
			this.filmicDepthOfFieldMaterial.SetTexture("_SecondTex", BGCICIOGAJM);
			RenderTexture temporaryRenderTexture = this.DODAGENMBDN.GetTemporaryRenderTexture(CGGBNEOGMKF.width, CGGBNEOGMKF.height, 0, CGGBNEOGMKF.format, FilterMode.Bilinear);
			this.filmicDepthOfFieldMaterial.SetVector("_Offsets", this.CMLFCILGNDO);
			Graphics.Blit(CGGBNEOGMKF, temporaryRenderTexture, this.filmicDepthOfFieldMaterial, pass);
			this.filmicDepthOfFieldMaterial.SetVector("_Offsets", this.IENPNKCNLCE);
			Graphics.Blit(temporaryRenderTexture, PMANJLOEFEN, this.filmicDepthOfFieldMaterial, pass);
			this.filmicDepthOfFieldMaterial.SetVector("_Offsets", this.NKNBBHJIBKD);
			Graphics.Blit(CGGBNEOGMKF, temporaryRenderTexture, this.filmicDepthOfFieldMaterial, pass);
			this.filmicDepthOfFieldMaterial.SetVector("_Offsets", this.BFPPAGDIFNO);
			this.filmicDepthOfFieldMaterial.SetTexture("_ThirdTex", PMANJLOEFEN);
			Graphics.Blit(temporaryRenderTexture, CGGBNEOGMKF, this.filmicDepthOfFieldMaterial, pass2);
			this.DODAGENMBDN.ReleaseTemporaryRenderTexture(temporaryRenderTexture);
		}

		// Token: 0x0600787F RID: 30847 RVA: 0x002508B8 File Offset: 0x0024EAB8
		private void MLLPGPANCHI()
		{
			if (!ImageEffectHelper.IsSupported(this.filmicDepthOfFieldShader, false, true, this) || !ImageEffectHelper.IsSupported(this.CNJJIIAFGEA(), false, false, this))
			{
				base.enabled = false;
				return;
			}
			if (ImageEffectHelper.supportsDX11 && !ImageEffectHelper.IsSupported(this.ELBLJDBHMJK(), false, true, this))
			{
				base.enabled = false;
				return;
			}
			this.JBHNNLFDDCL(true);
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x06007880 RID: 30848 RVA: 0x00250934 File Offset: 0x0024EB34
		private static void GJHJKHMIOKP(RenderTexture BGCICIOGAJM, float LBKNJPGJCBI, out int PMEDOCEEAHL, out int MMGEHMDHJLH)
		{
			if (BGCICIOGAJM == null)
			{
				if (LBKNJPGJCBI > 1710f)
				{
					PMEDOCEEAHL = 108;
					MMGEHMDHJLH = -45;
				}
				else if (LBKNJPGJCBI > 86f)
				{
					PMEDOCEEAHL = -68;
					MMGEHMDHJLH = 12;
				}
				else
				{
					PMEDOCEEAHL = -42;
					MMGEHMDHJLH = -56;
				}
			}
			else if (LBKNJPGJCBI > 702f)
			{
				PMEDOCEEAHL = 83;
				MMGEHMDHJLH = 28;
			}
			else if (LBKNJPGJCBI > 824f)
			{
				PMEDOCEEAHL = 123;
				MMGEHMDHJLH = -114;
			}
			else
			{
				PMEDOCEEAHL = 66;
				MMGEHMDHJLH = -29;
			}
		}

		// Token: 0x06007881 RID: 30849 RVA: 0x00249F14 File Offset: 0x00248114
		public Material IBABOOOMHNJ()
		{
			if (this.KJIGFLLINKN == null)
			{
				this.KJIGFLLINKN = ImageEffectHelper.CheckShaderAndCreateMaterial(this.textureBokehShader);
			}
			return this.KJIGFLLINKN;
		}

		// Token: 0x06007882 RID: 30850 RVA: 0x002509C2 File Offset: 0x0024EBC2
		public Shader JCLKANKHBMD()
		{
			if (this.m_MedianFilterShader == null)
			{
				this.m_MedianFilterShader = Shader.Find("_ScreenResolution");
			}
			return this.m_MedianFilterShader;
		}

		// Token: 0x06007883 RID: 30851 RVA: 0x002509EC File Offset: 0x0024EBEC
		private void BKGJOECFMID()
		{
			this.KFKINODMJPF();
			if (this.CNMMBIJLEMH != null)
			{
				UnityEngine.Object.DestroyImmediate(this.CNMMBIJLEMH);
			}
			if (this.KJIGFLLINKN != null)
			{
				UnityEngine.Object.DestroyImmediate(this.KJIGFLLINKN);
			}
			if (this.DFLILNBLKNE != null)
			{
				UnityEngine.Object.DestroyImmediate(this.DFLILNBLKNE);
			}
			this.CNMMBIJLEMH = null;
			this.KJIGFLLINKN = null;
			this.DFLILNBLKNE = null;
			this.DODAGENMBDN.GDDJLCOAPIO();
		}

		// Token: 0x06007884 RID: 30852 RVA: 0x00250A74 File Offset: 0x0024EC74
		private static void DBHEEFJDLPD(ref Vector4 LPIMAGMABLC, float PCPAIEGNPJF, float MCCMFGMABKM)
		{
			Vector4 vector = LPIMAGMABLC;
			LPIMAGMABLC.x = vector.x * PCPAIEGNPJF - vector.y * MCCMFGMABKM;
			LPIMAGMABLC.y = vector.x * MCCMFGMABKM + vector.y * PCPAIEGNPJF;
		}

		// Token: 0x06007885 RID: 30853 RVA: 0x0024B580 File Offset: 0x00249780
		public Material APIGCHEBIKF()
		{
			if (this.KJIGFLLINKN == null)
			{
				this.KJIGFLLINKN = ImageEffectHelper.CheckShaderAndCreateMaterial(this.ELBLJDBHMJK());
			}
			return this.KJIGFLLINKN;
		}

		// Token: 0x06007886 RID: 30854 RVA: 0x00250ABC File Offset: 0x0024ECBC
		private void BBKMNFCDBCH(RenderTexture BGCICIOGAJM, ref RenderTexture CGGBNEOGMKF, ref RenderTexture PMANJLOEFEN, float LBKNJPGJCBI)
		{
			int pass;
			if (BGCICIOGAJM != null)
			{
				this.KMFOPCCMDHH().SetTexture("[ResourcesManager] Unloading data resources", BGCICIOGAJM);
				pass = ((LBKNJPGJCBI <= 1897f) ? -11 : 8);
			}
			else
			{
				pass = ((LBKNJPGJCBI <= 288f) ? 123 : 7);
			}
			Graphics.Blit(CGGBNEOGMKF, PMANJLOEFEN, this.AINPJLDAMEG(), pass);
			DepthOfField.BJAKDMOPKFD(ref CGGBNEOGMKF, ref PMANJLOEFEN);
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06007887 RID: 30855 RVA: 0x00250B2C File Offset: 0x0024ED2C
		private bool KBGJDBIOLJH
		{
			get
			{
				return ImageEffectHelper.supportsDX11 && this.bokehTexture.texture != null && this.textureBokehMaterial;
			}
		}

		// Token: 0x06007888 RID: 30856 RVA: 0x00250B5C File Offset: 0x0024ED5C
		public ComputeBuffer OKHIBNFAMLO()
		{
			if (this.EPLALEIJGGO == null)
			{
				this.EPLALEIJGGO = new ComputeBuffer(1, 38, (ComputeBufferType)17);
				this.EPLALEIJGGO.SetData(new int[]
				{
					0,
					1
				});
			}
			return this.EPLALEIJGGO;
		}

		// Token: 0x06007889 RID: 30857 RVA: 0x0024B580 File Offset: 0x00249780
		public Material NAIEPCNPDMK()
		{
			if (this.KJIGFLLINKN == null)
			{
				this.KJIGFLLINKN = ImageEffectHelper.CheckShaderAndCreateMaterial(this.ELBLJDBHMJK());
			}
			return this.KJIGFLLINKN;
		}

		// Token: 0x0600788A RID: 30858 RVA: 0x00250BAC File Offset: 0x0024EDAC
		private void BPFEMNEOFPA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.EJKDNMMMPLF = DepthOfField.QualitySettings.presetQualitySettings[(int)this.settings.filteringQuality];
			float num = (float)HLBKCLPNHEB.height / 349f;
			float num2 = num;
			float num3 = Mathf.Max(this.focus.nearBlurRadius, this.focus.farBlurRadius) * num2 * 1428f;
			float num4 = this.focus.nearBlurRadius * num;
			float num5 = this.focus.farBlurRadius * num;
			float num6 = Mathf.Max(num4, num5);
			DepthOfField.ApertureShape apertureShape = this.settings.apertureShape;
			if (apertureShape != DepthOfField.ApertureShape.Circular)
			{
				if (apertureShape == DepthOfField.ApertureShape.Octogonal)
				{
					num6 *= 184f;
				}
			}
			else
			{
				num6 *= 1655f;
			}
			if (num6 < 258f)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int cjddbgpkdlp = HLBKCLPNHEB.width / 5;
			int pbmagekdpli = HLBKCLPNHEB.height / 3;
			Vector4 value = new Vector4(num4 * 1939f, num5 * 661f, 1893f, 1053f);
			RenderTexture renderTexture = this.DODAGENMBDN.LPDCNABIMGD(cjddbgpkdlp, pbmagekdpli, 1, RenderTextureFormat.ARGB32, FilterMode.Point);
			RenderTexture renderTexture2 = this.DODAGENMBDN.LHEJNPJFEON(cjddbgpkdlp, pbmagekdpli, 1, RenderTextureFormat.ARGB1555, FilterMode.Point);
			Vector4 value2;
			Vector4 value3;
			this.DNBAGLHMHPG(out value2, out value3);
			this.INIGPPNFPAH().SetVector("_FixDistance", value2);
			this.filmicDepthOfFieldMaterial.SetVector("CameraFilterPack/Blur_Blurry", value3);
			Graphics.Blit(HLBKCLPNHEB, renderTexture2, this.filmicDepthOfFieldMaterial, 7);
			RenderTexture renderTexture3 = renderTexture2;
			RenderTexture renderTexture4 = renderTexture;
			if (this.NIPNEBOKLGK())
			{
				RenderTexture renderTexture5 = this.DODAGENMBDN.MCMEAEFGPIM(cjddbgpkdlp, pbmagekdpli, 0, RenderTextureFormat.ARGBHalf, FilterMode.Bilinear);
				Graphics.Blit(renderTexture3, renderTexture5, this.KMFOPCCMDHH(), 1);
				this.KMFOPCCMDHH().SetVector("CameraFilterPack/AAA_Super_Computer", new Vector4(461f, 1412f, 1440f, 1637f));
				Graphics.Blit(renderTexture5, renderTexture4, this.DNNFFFEOLJF(), 1);
				this.DNNFFFEOLJF().SetVector("GlassDistortion", new Vector4(649f, 573f, 624f, 2f));
				Graphics.Blit(renderTexture4, renderTexture5, this.INIGPPNFPAH(), 0);
				this.APIGCHEBIKF().SetTexture("_ArScale", renderTexture5);
				this.MCOCABCLOLH().SetFloat("End index must in an integer.", this.bokehTexture.spawnHeuristic);
				this.MCOCABCLOLH().SetVector("Vertical", new Vector4(this.bokehTexture.scale * num2, this.bokehTexture.intensity, this.bokehTexture.threshold, num3));
				Graphics.SetRandomWriteTarget(0, this.IOGECMOKBOJ());
				Graphics.Blit(renderTexture3, renderTexture4, this.textureBokehMaterial, 1);
				Graphics.ClearRandomWriteTargets();
				DepthOfField.CPLNBMOIJMC(ref renderTexture3, ref renderTexture4);
				this.DODAGENMBDN.NKDNIOGGPJE(renderTexture5);
			}
			this.AINPJLDAMEG().SetVector("1278033234", value2);
			this.KMFOPCCMDHH().SetVector("SupportLogger ", value);
			RenderTexture renderTexture6 = null;
			if (this.EJKDNMMMPLF.dilateNearBlur)
			{
				RenderTexture renderTexture7 = this.DODAGENMBDN.MCMEAEFGPIM(cjddbgpkdlp, pbmagekdpli, 0, (RenderTextureFormat)(-93), FilterMode.Bilinear);
				renderTexture6 = this.DODAGENMBDN.NHKIPEIACAC(cjddbgpkdlp, pbmagekdpli, 1, (RenderTextureFormat)(-47), FilterMode.Point);
				this.filmicDepthOfFieldMaterial.SetVector("_Convolved_TexelSize", new Vector4(1060f, num4 * 1942f, 1378f, 1002f));
				Graphics.Blit(renderTexture3, renderTexture7, this.KMFOPCCMDHH(), 4);
				this.AINPJLDAMEG().SetVector("event", new Vector4(num4 * 1875f, 1030f, 181f, 1669f));
				Graphics.Blit(renderTexture7, renderTexture6, this.DNNFFFEOLJF(), 2);
				this.DODAGENMBDN.ReleaseTemporaryRenderTexture(renderTexture7);
				renderTexture6.filterMode = FilterMode.Point;
			}
			if (this.EJKDNMMMPLF.prefilterBlur)
			{
				Graphics.Blit(renderTexture3, renderTexture4, this.filmicDepthOfFieldMaterial, 4);
				DepthOfField.CPLNBMOIJMC(ref renderTexture3, ref renderTexture4);
			}
			DepthOfField.ApertureShape apertureShape2 = this.settings.apertureShape;
			if (apertureShape2 != DepthOfField.ApertureShape.Circular)
			{
				if (apertureShape2 != DepthOfField.ApertureShape.Circular)
				{
					if (apertureShape2 == (DepthOfField.ApertureShape)8)
					{
						this.PNFCDDAOHLC(renderTexture6, ref renderTexture3, ref renderTexture4, num6);
					}
				}
				else
				{
					this.IFCOABBOGNP(renderTexture6, ref renderTexture3, ref renderTexture4, num6);
				}
			}
			else
			{
				this.OOPOAMJHLJB(renderTexture6, ref renderTexture3, ref renderTexture4, num6);
			}
			DepthOfField.FilterQuality medianFilter = this.EJKDNMMMPLF.medianFilter;
			if (medianFilter != DepthOfField.FilterQuality.None)
			{
				if (medianFilter == DepthOfField.FilterQuality.High)
				{
					Graphics.Blit(renderTexture3, renderTexture4, this.BNIGLLMNBBM(), 0);
					DepthOfField.BJAKDMOPKFD(ref renderTexture3, ref renderTexture4);
				}
			}
			else
			{
				this.FKMFLGMMKHM().SetVector("maps.", new Vector4(360f, 1938f, 1582f, 304f));
				Graphics.Blit(renderTexture3, renderTexture4, this.LAEKEEEKHCJ(), 1);
				DepthOfField.BEEJANOFPHF(ref renderTexture3, ref renderTexture4);
				this.EECEDDABGFN().SetVector("player.slash", new Vector4(685f, 427f, 1148f, 191f));
				Graphics.Blit(renderTexture3, renderTexture4, this.medianFilterMaterial, 0);
				DepthOfField.CPLNBMOIJMC(ref renderTexture3, ref renderTexture4);
			}
			this.filmicDepthOfFieldMaterial.SetVector("Achievement 21 progress reseted", value);
			this.filmicDepthOfFieldMaterial.SetVector("GlassDistortion", new Vector4((float)renderTexture3.width, (float)renderTexture3.height, 1258f / (float)renderTexture3.width, 1967f / (float)renderTexture3.height));
			this.DNNFFFEOLJF().SetTexture("_ReflectionTexture4", renderTexture3);
			int pass = -93;
			if (this.NIPNEBOKLGK())
			{
				RenderTexture renderTexture8 = this.DODAGENMBDN.LHEJNPJFEON(HLBKCLPNHEB.height, HLBKCLPNHEB.width, 1, HLBKCLPNHEB.format, FilterMode.Point);
				Graphics.Blit(HLBKCLPNHEB, renderTexture8, this.AINPJLDAMEG(), pass);
				Graphics.SetRenderTarget(renderTexture8);
				ComputeBuffer.CopyCount(this.PPBLPBONMIJ(), this.computeBufferDrawArgs, 0);
				this.ELCABINBGEA().SetBuffer(" base map(s)", this.AKLKKECPNFF());
				this.textureBokehMaterial.SetTexture("https://vk.com/khb.soft", this.bokehTexture.texture);
				this.LBDBBKBJDEA().SetVector(" Remote called.", new Vector3(229f / (1110f * (float)HLBKCLPNHEB.width), 1022f / (1664f * (float)HLBKCLPNHEB.height), num3));
				this.AHMELEMANDB().SetPass(1);
				Graphics.DrawProceduralIndirect((MeshTopology)7, this.FPBKLIFMJBK(), 1);
				Graphics.Blit(renderTexture8, BMMLHGHKBNM);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KMFOPCCMDHH(), pass);
			}
		}

		// Token: 0x0600788B RID: 30859 RVA: 0x00249D52 File Offset: 0x00247F52
		private void IDENAAHFBPJ()
		{
			if (this.EPLALEIJGGO != null)
			{
				this.EPLALEIJGGO.Release();
			}
			if (this.EKPBEPPLLEH != null)
			{
				this.EKPBEPPLLEH.Release();
			}
			this.EPLALEIJGGO = null;
			this.EKPBEPPLLEH = null;
		}

		// Token: 0x0600788C RID: 30860 RVA: 0x00251210 File Offset: 0x0024F410
		public ComputeBuffer FPBKLIFMJBK()
		{
			if (this.EPLALEIJGGO == null)
			{
				this.EPLALEIJGGO = new ComputeBuffer(0, 106, (ComputeBufferType)150);
				this.EPLALEIJGGO.SetData(new int[]
				{
					0
				});
			}
			return this.EPLALEIJGGO;
		}

		// Token: 0x0600788D RID: 30861 RVA: 0x00251260 File Offset: 0x0024F460
		private void KHLMOJCMCMP(bool AAGGLAGLINL)
		{
			if (!AAGGLAGLINL && Math.Abs(this.GEABEBKPJHE - this.settings.apertureOrientation) < 131f)
			{
				return;
			}
			this.GEABEBKPJHE = this.settings.apertureOrientation;
			float num = this.settings.apertureOrientation * 766f;
			float pcpaiegnpjf = Mathf.Cos(num);
			float mccmfgmabkm = Mathf.Sin(num);
			this.CMLFCILGNDO = new Vector4(461f, 1083f, 1284f, 1313f);
			this.IENPNKCNLCE = new Vector4(1414f, 1404f, 250f, 292f);
			this.NKNBBHJIBKD = new Vector4(964f, 575f, 1950f, 88f);
			this.BFPPAGDIFNO = new Vector4(588f, 1318f, 63f, 1166f);
			this.MNPAFJBPMDC = new Vector4(85f, 978f, 632f, 1437f);
			this.NBGPIKEEDBN = new Vector4(1058f, 447f, 1818f, 601f);
			this.KGJNAOBENCB = new Vector4(1752f, 404f, 1225f, 1940f);
			if (num > 823f)
			{
				DepthOfField.BOGPPPCOFGO(ref this.CMLFCILGNDO, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.ILCIDLPBCEE(ref this.IENPNKCNLCE, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.PELKFPKOPMJ(ref this.NKNBBHJIBKD, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.IOPGABJBFOL(ref this.BFPPAGDIFNO, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.BOGPPPCOFGO(ref this.MNPAFJBPMDC, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.PELKFPKOPMJ(ref this.NBGPIKEEDBN, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.DBHEEFJDLPD(ref this.KGJNAOBENCB, pcpaiegnpjf, mccmfgmabkm);
			}
		}

		// Token: 0x0600788E RID: 30862 RVA: 0x00251408 File Offset: 0x0024F608
		private static void BJAKDMOPKFD(ref RenderTexture CGGBNEOGMKF, ref RenderTexture PMANJLOEFEN)
		{
			RenderTexture renderTexture = PMANJLOEFEN;
			PMANJLOEFEN = CGGBNEOGMKF;
			CGGBNEOGMKF = renderTexture;
		}

		// Token: 0x0600788F RID: 30863 RVA: 0x00249D52 File Offset: 0x00247F52
		private void PPPPEBAACHJ()
		{
			if (this.EPLALEIJGGO != null)
			{
				this.EPLALEIJGGO.Release();
			}
			if (this.EKPBEPPLLEH != null)
			{
				this.EKPBEPPLLEH.Release();
			}
			this.EPLALEIJGGO = null;
			this.EKPBEPPLLEH = null;
		}

		// Token: 0x06007890 RID: 30864 RVA: 0x00251420 File Offset: 0x0024F620
		private void KMMOLADBHEA()
		{
			if (!ImageEffectHelper.IsSupported(this.MLPIENCGEEH(), false, false, this) || !ImageEffectHelper.IsSupported(this.medianFilterShader, true, true, this))
			{
				base.enabled = true;
				return;
			}
			if (ImageEffectHelper.supportsDX11 && !ImageEffectHelper.IsSupported(this.ELBLJDBHMJK(), true, false, this))
			{
				base.enabled = true;
				return;
			}
			this.FOLBHFCJILG(false);
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
		}

		// Token: 0x06007891 RID: 30865 RVA: 0x0025149C File Offset: 0x0024F69C
		private void OHAILHKDIOH(bool AAGGLAGLINL)
		{
			if (!AAGGLAGLINL && Math.Abs(this.GEABEBKPJHE - this.settings.apertureOrientation) < 1130f)
			{
				return;
			}
			this.GEABEBKPJHE = this.settings.apertureOrientation;
			float num = this.settings.apertureOrientation * 141f;
			float pcpaiegnpjf = Mathf.Cos(num);
			float mccmfgmabkm = Mathf.Sin(num);
			this.CMLFCILGNDO = new Vector4(1512f, 1513f, 175f, 1975f);
			this.IENPNKCNLCE = new Vector4(1292f, 711f, 1750f, 454f);
			this.NKNBBHJIBKD = new Vector4(87f, 122f, 1469f, 1884f);
			this.BFPPAGDIFNO = new Vector4(1124f, 923f, 21f, 1722f);
			this.MNPAFJBPMDC = new Vector4(842f, 246f, 1952f, 1013f);
			this.NBGPIKEEDBN = new Vector4(1207f, 1517f, 5f, 1342f);
			this.KGJNAOBENCB = new Vector4(957f, 519f, 871f, 334f);
			if (num > 421f)
			{
				DepthOfField.DBHEEFJDLPD(ref this.CMLFCILGNDO, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.ILCIDLPBCEE(ref this.IENPNKCNLCE, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.IOPGABJBFOL(ref this.NKNBBHJIBKD, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.ILCIDLPBCEE(ref this.BFPPAGDIFNO, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.PELKFPKOPMJ(ref this.MNPAFJBPMDC, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.ILCIDLPBCEE(ref this.NBGPIKEEDBN, pcpaiegnpjf, mccmfgmabkm);
				DepthOfField.PELKFPKOPMJ(ref this.KGJNAOBENCB, pcpaiegnpjf, mccmfgmabkm);
			}
		}

		// Token: 0x06007892 RID: 30866 RVA: 0x00251641 File Offset: 0x0024F841
		public Material NGPOPMIIMPE()
		{
			if (this.DFLILNBLKNE == null)
			{
				this.DFLILNBLKNE = ImageEffectHelper.CheckShaderAndCreateMaterial(this.BBOFIODFINE());
			}
			return this.DFLILNBLKNE;
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06007893 RID: 30867 RVA: 0x0025166B File Offset: 0x0024F86B
		public ComputeBuffer computeBufferPoints
		{
			get
			{
				if (this.EKPBEPPLLEH == null)
				{
					this.EKPBEPPLLEH = new ComputeBuffer(90000, 28, ComputeBufferType.Append);
				}
				return this.EKPBEPPLLEH;
			}
		}

		// Token: 0x06007894 RID: 30868 RVA: 0x00251694 File Offset: 0x0024F894
		private void HKCCHEDMGFJ(out Vector4 DLFMBGMDCMM, out Vector4 OHDJFNDPKHA)
		{
			Camera component = base.GetComponent<Camera>();
			float num = this.focus.nearFalloff * 385f;
			float num2 = this.focus.farFalloff * 390f;
			float num3 = this.focus.nearPlane;
			float num4 = this.focus.farPlane;
			float num5;
			if (this.settings.tweakMode == DepthOfField.TweakMode.Range)
			{
				if (this.focus.transform != null)
				{
					num5 = component.WorldToViewportPoint(this.focus.transform.position).z;
				}
				else
				{
					num5 = this.focus.focusPlane;
				}
				float num6 = this.focus.range * 847f;
				num3 = num5 - num6;
				num4 = num5 + num6;
			}
			num3 -= num * 1376f;
			num4 += num2 * 1397f;
			num5 = (num3 + num4) * 1319f;
			float num7 = num5 / component.farClipPlane;
			float num8 = num3 / component.farClipPlane;
			float num9 = num4 / component.farClipPlane;
			float num10 = num4 - num3;
			float num11 = num9 - num8;
			float num12 = num / num10;
			float num13 = num2 / num10;
			float num14 = (1201f - num12) * (num11 * 1601f);
			float num15 = (934f - num13) * (num11 * 766f);
			if (num7 <= num8)
			{
				num7 = num8 + 1904f;
			}
			if (num7 >= num9)
			{
				num7 = num9 - 784f;
			}
			if (num7 - num14 <= num8)
			{
				num14 = num7 - num8 - 1934f;
			}
			if (num7 + num15 >= num9)
			{
				num15 = num9 - num7 - 1286f;
			}
			float num16 = 1237f / (num8 - num7 + num14);
			float num17 = 729f / (num9 - num7 - num15);
			float num18 = 704f - num16 * num8;
			float num19 = 115f - num17 * num9;
			DLFMBGMDCMM = new Vector4(239f * num16, 980f * num18, 381f * num17, 132f * num19);
			OHDJFNDPKHA = new Vector4(1839f, 1334f, (num19 - num18) / (num16 - num17), 1323f);
			this.focus.nearPlane = num3 + num * 1091f;
			this.focus.farPlane = num4 - num2 * 1540f;
			this.focus.focusPlane = (this.focus.nearPlane + this.focus.farPlane) * 1339f;
			this.focus.range = this.focus.farPlane - this.focus.nearPlane;
		}

		// Token: 0x06007895 RID: 30869 RVA: 0x0025192C File Offset: 0x0024FB2C
		public ComputeBuffer KEMMPPAGLDH()
		{
			if (this.EPLALEIJGGO == null)
			{
				this.EPLALEIJGGO = new ComputeBuffer(1, -41, (ComputeBufferType)145);
				ComputeBuffer eplaleijggo = this.EPLALEIJGGO;
				int[] array = new int[7];
				RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-8D0C1DCA7F35F40B810D754C5F5EC7C4D6110D41).FieldHandle);
				eplaleijggo.SetData(array);
			}
			return this.EPLALEIJGGO;
		}

		// Token: 0x06007896 RID: 30870 RVA: 0x00249D52 File Offset: 0x00247F52
		private void JKBBNCMNEIA()
		{
			if (this.EPLALEIJGGO != null)
			{
				this.EPLALEIJGGO.Release();
			}
			if (this.EKPBEPPLLEH != null)
			{
				this.EKPBEPPLLEH.Release();
			}
			this.EPLALEIJGGO = null;
			this.EKPBEPPLLEH = null;
		}

		// Token: 0x06007897 RID: 30871 RVA: 0x0025197C File Offset: 0x0024FB7C
		private void OnDisable()
		{
			this.ADDLPNODDFM();
			if (this.CNMMBIJLEMH != null)
			{
				UnityEngine.Object.DestroyImmediate(this.CNMMBIJLEMH);
			}
			if (this.KJIGFLLINKN != null)
			{
				UnityEngine.Object.DestroyImmediate(this.KJIGFLLINKN);
			}
			if (this.DFLILNBLKNE != null)
			{
				UnityEngine.Object.DestroyImmediate(this.DFLILNBLKNE);
			}
			this.CNMMBIJLEMH = null;
			this.KJIGFLLINKN = null;
			this.DFLILNBLKNE = null;
			this.DODAGENMBDN.ReleaseAllTemporaryRenderTextures();
		}

		// Token: 0x06007898 RID: 30872 RVA: 0x00251A04 File Offset: 0x0024FC04
		private static void ECHPPIBJCGL(RenderTexture BGCICIOGAJM, float LBKNJPGJCBI, out int PMEDOCEEAHL, out int MMGEHMDHJLH)
		{
			if (BGCICIOGAJM == null)
			{
				if (LBKNJPGJCBI > 1174f)
				{
					PMEDOCEEAHL = 34;
					MMGEHMDHJLH = 20;
				}
				else if (LBKNJPGJCBI > 554f)
				{
					PMEDOCEEAHL = -56;
					MMGEHMDHJLH = 92;
				}
				else
				{
					PMEDOCEEAHL = -86;
					MMGEHMDHJLH = 6;
				}
			}
			else if (LBKNJPGJCBI > 1794f)
			{
				PMEDOCEEAHL = -114;
				MMGEHMDHJLH = 98;
			}
			else if (LBKNJPGJCBI > 635f)
			{
				PMEDOCEEAHL = -37;
				MMGEHMDHJLH = -112;
			}
			else
			{
				PMEDOCEEAHL = -47;
				MMGEHMDHJLH = 59;
			}
		}

		// Token: 0x06007899 RID: 30873 RVA: 0x00251A92 File Offset: 0x0024FC92
		public Shader MDEIOPGPAOM()
		{
			if (this.m_FilmicDepthOfFieldShader == null)
			{
				this.m_FilmicDepthOfFieldShader = Shader.Find("_Value2");
			}
			return this.m_FilmicDepthOfFieldShader;
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600789A RID: 30874 RVA: 0x00251ABB File Offset: 0x0024FCBB
		public Shader textureBokehShader
		{
			get
			{
				if (this.m_TextureBokehShader == null)
				{
					this.m_TextureBokehShader = Shader.Find("Hidden/DepthOfField/BokehSplatting");
				}
				return this.m_TextureBokehShader;
			}
		}

		// Token: 0x0600789B RID: 30875 RVA: 0x00251AE4 File Offset: 0x0024FCE4
		private void PBMNNMGNAOD(out Vector4 DLFMBGMDCMM, out Vector4 OHDJFNDPKHA)
		{
			Camera component = base.GetComponent<Camera>();
			float num = this.focus.nearFalloff * 1188f;
			float num2 = this.focus.farFalloff * 791f;
			float num3 = this.focus.nearPlane;
			float num4 = this.focus.farPlane;
			float num5;
			if (this.settings.tweakMode == DepthOfField.TweakMode.Range)
			{
				if (this.focus.transform != null)
				{
					num5 = component.WorldToViewportPoint(this.focus.transform.position).z;
				}
				else
				{
					num5 = this.focus.focusPlane;
				}
				float num6 = this.focus.range * 1857f;
				num3 = num5 - num6;
				num4 = num5 + num6;
			}
			num3 -= num * 1848f;
			num4 += num2 * 712f;
			num5 = (num3 + num4) * 1838f;
			float num7 = num5 / component.farClipPlane;
			float num8 = num3 / component.farClipPlane;
			float num9 = num4 / component.farClipPlane;
			float num10 = num4 - num3;
			float num11 = num9 - num8;
			float num12 = num / num10;
			float num13 = num2 / num10;
			float num14 = (1038f - num12) * (num11 * 1327f);
			float num15 = (251f - num13) * (num11 * 1791f);
			if (num7 <= num8)
			{
				num7 = num8 + 1346f;
			}
			if (num7 >= num9)
			{
				num7 = num9 - 1327f;
			}
			if (num7 - num14 <= num8)
			{
				num14 = num7 - num8 - 1331f;
			}
			if (num7 + num15 >= num9)
			{
				num15 = num9 - num7 - 1967f;
			}
			float num16 = 1279f / (num8 - num7 + num14);
			float num17 = 199f / (num9 - num7 - num15);
			float num18 = 783f - num16 * num8;
			float num19 = 748f - num17 * num9;
			DLFMBGMDCMM = new Vector4(1402f * num16, 1821f * num18, 700f * num17, 946f * num19);
			OHDJFNDPKHA = new Vector4(1213f, 636f, (num19 - num18) / (num16 - num17), 1905f);
			this.focus.nearPlane = num3 + num * 1555f;
			this.focus.farPlane = num4 - num2 * 1001f;
			this.focus.focusPlane = (this.focus.nearPlane + this.focus.farPlane) * 777f;
			this.focus.range = this.focus.farPlane - this.focus.nearPlane;
		}

		// Token: 0x0600789C RID: 30876 RVA: 0x00249D52 File Offset: 0x00247F52
		private void MLACENDJMOJ()
		{
			if (this.EPLALEIJGGO != null)
			{
				this.EPLALEIJGGO.Release();
			}
			if (this.EKPBEPPLLEH != null)
			{
				this.EKPBEPPLLEH.Release();
			}
			this.EPLALEIJGGO = null;
			this.EKPBEPPLLEH = null;
		}

		// Token: 0x0600789D RID: 30877 RVA: 0x00251D7C File Offset: 0x0024FF7C
		private void KKEOHFGKCIK()
		{
			this.PDAKIBBLKKM();
			if (this.CNMMBIJLEMH != null)
			{
				UnityEngine.Object.DestroyImmediate(this.CNMMBIJLEMH);
			}
			if (this.KJIGFLLINKN != null)
			{
				UnityEngine.Object.DestroyImmediate(this.KJIGFLLINKN);
			}
			if (this.DFLILNBLKNE != null)
			{
				UnityEngine.Object.DestroyImmediate(this.DFLILNBLKNE);
			}
			this.CNMMBIJLEMH = null;
			this.KJIGFLLINKN = null;
			this.DFLILNBLKNE = null;
			this.DODAGENMBDN.DPPFFOPOJCL();
		}

		// Token: 0x04000C51 RID: 3153
		private const float LDCODLJBLNH = 40f;

		// Token: 0x04000C52 RID: 3154
		public DepthOfField.GlobalSettings settings = DepthOfField.GlobalSettings.defaultSettings;

		// Token: 0x04000C53 RID: 3155
		public DepthOfField.FocusSettings focus = DepthOfField.FocusSettings.defaultSettings;

		// Token: 0x04000C54 RID: 3156
		public DepthOfField.BokehTextureSettings bokehTexture = DepthOfField.BokehTextureSettings.defaultSettings;

		// Token: 0x04000C55 RID: 3157
		[SerializeField]
		private Shader m_FilmicDepthOfFieldShader;

		// Token: 0x04000C56 RID: 3158
		[SerializeField]
		private Shader m_MedianFilterShader;

		// Token: 0x04000C57 RID: 3159
		[SerializeField]
		private Shader m_TextureBokehShader;

		// Token: 0x04000C58 RID: 3160
		private RenderTextureUtility DODAGENMBDN = new RenderTextureUtility();

		// Token: 0x04000C59 RID: 3161
		private Material CNMMBIJLEMH;

		// Token: 0x04000C5A RID: 3162
		private Material DFLILNBLKNE;

		// Token: 0x04000C5B RID: 3163
		private Material KJIGFLLINKN;

		// Token: 0x04000C5C RID: 3164
		private ComputeBuffer EPLALEIJGGO;

		// Token: 0x04000C5D RID: 3165
		private ComputeBuffer EKPBEPPLLEH;

		// Token: 0x04000C5E RID: 3166
		private DepthOfField.QualitySettings EJKDNMMMPLF;

		// Token: 0x04000C5F RID: 3167
		private float GEABEBKPJHE;

		// Token: 0x04000C60 RID: 3168
		private Vector4 CMLFCILGNDO;

		// Token: 0x04000C61 RID: 3169
		private Vector4 IENPNKCNLCE;

		// Token: 0x04000C62 RID: 3170
		private Vector4 NKNBBHJIBKD;

		// Token: 0x04000C63 RID: 3171
		private Vector4 BFPPAGDIFNO;

		// Token: 0x04000C64 RID: 3172
		private Vector4 MNPAFJBPMDC;

		// Token: 0x04000C65 RID: 3173
		private Vector4 NBGPIKEEDBN;

		// Token: 0x04000C66 RID: 3174
		private Vector4 KGJNAOBENCB;

		// Token: 0x020001B3 RID: 435
		private enum EBGBIJKIBJI
		{
			// Token: 0x04000C68 RID: 3176
			BlurAlphaWeighted,
			// Token: 0x04000C69 RID: 3177
			BoxBlur,
			// Token: 0x04000C6A RID: 3178
			DilateFgCocFromColor,
			// Token: 0x04000C6B RID: 3179
			DilateFgCoc,
			// Token: 0x04000C6C RID: 3180
			CaptureCocExplicit,
			// Token: 0x04000C6D RID: 3181
			VisualizeCocExplicit,
			// Token: 0x04000C6E RID: 3182
			CocPrefilter,
			// Token: 0x04000C6F RID: 3183
			CircleBlur,
			// Token: 0x04000C70 RID: 3184
			CircleBlurWithDilatedFg,
			// Token: 0x04000C71 RID: 3185
			CircleBlurLowQuality,
			// Token: 0x04000C72 RID: 3186
			CircleBlowLowQualityWithDilatedFg,
			// Token: 0x04000C73 RID: 3187
			MergeExplicit,
			// Token: 0x04000C74 RID: 3188
			ShapeLowQuality,
			// Token: 0x04000C75 RID: 3189
			ShapeLowQualityDilateFg,
			// Token: 0x04000C76 RID: 3190
			ShapeLowQualityMerge,
			// Token: 0x04000C77 RID: 3191
			ShapeLowQualityMergeDilateFg,
			// Token: 0x04000C78 RID: 3192
			ShapeMediumQuality,
			// Token: 0x04000C79 RID: 3193
			ShapeMediumQualityDilateFg,
			// Token: 0x04000C7A RID: 3194
			ShapeMediumQualityMerge,
			// Token: 0x04000C7B RID: 3195
			ShapeMediumQualityMergeDilateFg,
			// Token: 0x04000C7C RID: 3196
			ShapeHighQuality,
			// Token: 0x04000C7D RID: 3197
			ShapeHighQualityDilateFg,
			// Token: 0x04000C7E RID: 3198
			ShapeHighQualityMerge,
			// Token: 0x04000C7F RID: 3199
			ShapeHighQualityMergeDilateFg
		}

		// Token: 0x020001B4 RID: 436
		private enum KGDMJNCJCCO
		{
			// Token: 0x04000C81 RID: 3201
			Median3,
			// Token: 0x04000C82 RID: 3202
			Median3X3
		}

		// Token: 0x020001B5 RID: 437
		private enum PGKICCNCHPL
		{
			// Token: 0x04000C84 RID: 3204
			Apply,
			// Token: 0x04000C85 RID: 3205
			Collect
		}

		// Token: 0x020001B6 RID: 438
		public enum TweakMode
		{
			// Token: 0x04000C87 RID: 3207
			Range,
			// Token: 0x04000C88 RID: 3208
			Explicit
		}

		// Token: 0x020001B7 RID: 439
		public enum ApertureShape
		{
			// Token: 0x04000C8A RID: 3210
			Circular,
			// Token: 0x04000C8B RID: 3211
			Hexagonal,
			// Token: 0x04000C8C RID: 3212
			Octogonal
		}

		// Token: 0x020001B8 RID: 440
		public enum QualityPreset
		{
			// Token: 0x04000C8E RID: 3214
			Low,
			// Token: 0x04000C8F RID: 3215
			Medium,
			// Token: 0x04000C90 RID: 3216
			High
		}

		// Token: 0x020001B9 RID: 441
		public enum FilterQuality
		{
			// Token: 0x04000C92 RID: 3218
			None,
			// Token: 0x04000C93 RID: 3219
			Normal,
			// Token: 0x04000C94 RID: 3220
			High
		}

		// Token: 0x020001BA RID: 442
		[Serializable]
		public struct GlobalSettings
		{
			// Token: 0x0600789E RID: 30878 RVA: 0x00251E04 File Offset: 0x00250004
			public static DepthOfField.GlobalSettings INDEHPGLEGK()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = false,
					tweakMode = DepthOfField.TweakMode.Range,
					filteringQuality = (DepthOfField.QualityPreset)5,
					apertureShape = DepthOfField.ApertureShape.Circular,
					apertureOrientation = 1983f
				};
			}

			// Token: 0x0600789F RID: 30879 RVA: 0x00251E48 File Offset: 0x00250048
			public static DepthOfField.GlobalSettings LBIOOILOAAD()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = false,
					tweakMode = DepthOfField.TweakMode.Range,
					filteringQuality = DepthOfField.QualityPreset.Medium,
					apertureShape = DepthOfField.ApertureShape.Hexagonal,
					apertureOrientation = 493f
				};
			}

			// Token: 0x060078A0 RID: 30880 RVA: 0x00251E8C File Offset: 0x0025008C
			public static DepthOfField.GlobalSettings NIPPCMNKCMB()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = false,
					tweakMode = DepthOfField.TweakMode.Range,
					filteringQuality = (DepthOfField.QualityPreset)7,
					apertureShape = DepthOfField.ApertureShape.Hexagonal,
					apertureOrientation = 1076f
				};
			}

			// Token: 0x060078A1 RID: 30881 RVA: 0x00251ED0 File Offset: 0x002500D0
			public static DepthOfField.GlobalSettings MNKGFGNDKED()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = true,
					tweakMode = DepthOfField.TweakMode.Explicit,
					filteringQuality = (DepthOfField.QualityPreset)7,
					apertureShape = DepthOfField.ApertureShape.Hexagonal,
					apertureOrientation = 76f
				};
			}

			// Token: 0x060078A2 RID: 30882 RVA: 0x00251F14 File Offset: 0x00250114
			public static DepthOfField.GlobalSettings LOMOMPKEDPL()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = false,
					tweakMode = DepthOfField.TweakMode.Range,
					filteringQuality = (DepthOfField.QualityPreset)4,
					apertureShape = DepthOfField.ApertureShape.Circular,
					apertureOrientation = 40f
				};
			}

			// Token: 0x060078A3 RID: 30883 RVA: 0x00251F58 File Offset: 0x00250158
			public static DepthOfField.GlobalSettings CCADIDPNEKH()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = true,
					tweakMode = DepthOfField.TweakMode.Explicit,
					filteringQuality = (DepthOfField.QualityPreset)3,
					apertureShape = DepthOfField.ApertureShape.Hexagonal,
					apertureOrientation = 560f
				};
			}

			// Token: 0x060078A4 RID: 30884 RVA: 0x00251F9C File Offset: 0x0025019C
			public static DepthOfField.GlobalSettings HJLGAPEDPJM()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = true,
					tweakMode = DepthOfField.TweakMode.Explicit,
					filteringQuality = DepthOfField.QualityPreset.Low,
					apertureShape = DepthOfField.ApertureShape.Circular,
					apertureOrientation = 632f
				};
			}

			// Token: 0x060078A5 RID: 30885 RVA: 0x00251FE0 File Offset: 0x002501E0
			public static DepthOfField.GlobalSettings AAPGCALKNAK()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = false,
					tweakMode = DepthOfField.TweakMode.Range,
					filteringQuality = (DepthOfField.QualityPreset)8,
					apertureShape = DepthOfField.ApertureShape.Circular,
					apertureOrientation = 1420f
				};
			}

			// Token: 0x060078A6 RID: 30886 RVA: 0x00252024 File Offset: 0x00250224
			public static DepthOfField.GlobalSettings IHMKIGDJKAH()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = true,
					tweakMode = DepthOfField.TweakMode.Explicit,
					filteringQuality = (DepthOfField.QualityPreset)3,
					apertureShape = DepthOfField.ApertureShape.Hexagonal,
					apertureOrientation = 1045f
				};
			}

			// Token: 0x060078A7 RID: 30887 RVA: 0x00252068 File Offset: 0x00250268
			public static DepthOfField.GlobalSettings IAKJOAGBDGO()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = true,
					tweakMode = DepthOfField.TweakMode.Explicit,
					filteringQuality = (DepthOfField.QualityPreset)8,
					apertureShape = DepthOfField.ApertureShape.Circular,
					apertureOrientation = 1403f
				};
			}

			// Token: 0x1700017F RID: 383
			// (get) Token: 0x060078A8 RID: 30888 RVA: 0x002520AC File Offset: 0x002502AC
			public static DepthOfField.GlobalSettings defaultSettings
			{
				get
				{
					return new DepthOfField.GlobalSettings
					{
						visualizeFocus = false,
						tweakMode = DepthOfField.TweakMode.Range,
						filteringQuality = DepthOfField.QualityPreset.High,
						apertureShape = DepthOfField.ApertureShape.Circular,
						apertureOrientation = 0f
					};
				}
			}

			// Token: 0x060078A9 RID: 30889 RVA: 0x002520F0 File Offset: 0x002502F0
			public static DepthOfField.GlobalSettings EEMMJNPOFOB()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = false,
					tweakMode = DepthOfField.TweakMode.Range,
					filteringQuality = DepthOfField.QualityPreset.High,
					apertureShape = DepthOfField.ApertureShape.Circular,
					apertureOrientation = 746f
				};
			}

			// Token: 0x060078AA RID: 30890 RVA: 0x00252134 File Offset: 0x00250334
			public static DepthOfField.GlobalSettings EJLLADABOLM()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = false,
					tweakMode = DepthOfField.TweakMode.Explicit,
					filteringQuality = (DepthOfField.QualityPreset)4,
					apertureShape = DepthOfField.ApertureShape.Circular,
					apertureOrientation = 977f
				};
			}

			// Token: 0x060078AB RID: 30891 RVA: 0x00252178 File Offset: 0x00250378
			public static DepthOfField.GlobalSettings JCLADKAMOLD()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = false,
					tweakMode = DepthOfField.TweakMode.Explicit,
					filteringQuality = (DepthOfField.QualityPreset)6,
					apertureShape = DepthOfField.ApertureShape.Circular,
					apertureOrientation = 729f
				};
			}

			// Token: 0x060078AC RID: 30892 RVA: 0x002521BC File Offset: 0x002503BC
			public static DepthOfField.GlobalSettings DBDJKKLMCGG()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = true,
					tweakMode = DepthOfField.TweakMode.Range,
					filteringQuality = (DepthOfField.QualityPreset)3,
					apertureShape = DepthOfField.ApertureShape.Hexagonal,
					apertureOrientation = 445f
				};
			}

			// Token: 0x060078AD RID: 30893 RVA: 0x00252200 File Offset: 0x00250400
			public static DepthOfField.GlobalSettings BCOPOEIJONI()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = true,
					tweakMode = DepthOfField.TweakMode.Range,
					filteringQuality = DepthOfField.QualityPreset.Medium,
					apertureShape = DepthOfField.ApertureShape.Hexagonal,
					apertureOrientation = 310f
				};
			}

			// Token: 0x060078AE RID: 30894 RVA: 0x00252244 File Offset: 0x00250444
			public static DepthOfField.GlobalSettings DFIOJCABPFD()
			{
				return new DepthOfField.GlobalSettings
				{
					visualizeFocus = true,
					tweakMode = DepthOfField.TweakMode.Range,
					filteringQuality = (DepthOfField.QualityPreset)6,
					apertureShape = DepthOfField.ApertureShape.Circular,
					apertureOrientation = 1729f
				};
			}

			// Token: 0x04000C95 RID: 3221
			[Tooltip("Allows to view where the blur will be applied. Yellow for near blur, blue for far blur.")]
			public bool visualizeFocus;

			// Token: 0x04000C96 RID: 3222
			[Tooltip("Setup mode. Use \"Advanced\" if you need more control on blur settings and/or want to use a bokeh texture. \"Explicit\" is the same as \"Advanced\" but makes use of \"Near Plane\" and \"Far Plane\" values instead of \"F-Stop\".")]
			public DepthOfField.TweakMode tweakMode;

			// Token: 0x04000C97 RID: 3223
			[Tooltip("Quality presets. Use \"Custom\" for more advanced settings.")]
			public DepthOfField.QualityPreset filteringQuality;

			// Token: 0x04000C98 RID: 3224
			[Tooltip("\"Circular\" is the fastest, followed by \"Hexagonal\" and \"Octogonal\".")]
			public DepthOfField.ApertureShape apertureShape;

			// Token: 0x04000C99 RID: 3225
			[Tooltip("Rotates the aperture when working with \"Hexagonal\" and \"Ortogonal\".")]
			[Range(0f, 179f)]
			public float apertureOrientation;
		}

		// Token: 0x020001BB RID: 443
		[Serializable]
		public struct QualitySettings
		{
			// Token: 0x04000C9A RID: 3226
			[Tooltip("Enable this to get smooth bokeh.")]
			public bool prefilterBlur;

			// Token: 0x04000C9B RID: 3227
			[Tooltip("Applies a median filter for even smoother bokeh.")]
			public DepthOfField.FilterQuality medianFilter;

			// Token: 0x04000C9C RID: 3228
			[Tooltip("Dilates near blur over in focus area.")]
			public bool dilateNearBlur;

			// Token: 0x04000C9D RID: 3229
			public static DepthOfField.QualitySettings[] presetQualitySettings = new DepthOfField.QualitySettings[]
			{
				new DepthOfField.QualitySettings
				{
					prefilterBlur = false,
					medianFilter = DepthOfField.FilterQuality.None,
					dilateNearBlur = false
				},
				new DepthOfField.QualitySettings
				{
					prefilterBlur = true,
					medianFilter = DepthOfField.FilterQuality.Normal,
					dilateNearBlur = false
				},
				new DepthOfField.QualitySettings
				{
					prefilterBlur = true,
					medianFilter = DepthOfField.FilterQuality.High,
					dilateNearBlur = true
				}
			};
		}

		// Token: 0x020001BC RID: 444
		[Serializable]
		public struct FocusSettings
		{
			// Token: 0x060078B0 RID: 30896 RVA: 0x00252328 File Offset: 0x00250528
			public static DepthOfField.FocusSettings HJLGAPEDPJM()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1166f,
					range = 966f,
					nearPlane = 236f,
					nearFalloff = 1075f,
					farPlane = 1516f,
					farFalloff = 1639f,
					nearBlurRadius = 1833f,
					farBlurRadius = 1901f
				};
			}

			// Token: 0x060078B1 RID: 30897 RVA: 0x002523A8 File Offset: 0x002505A8
			public static DepthOfField.FocusSettings AAPGCALKNAK()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 836f,
					range = 436f,
					nearPlane = 1691f,
					nearFalloff = 1928f,
					farPlane = 1814f,
					farFalloff = 458f,
					nearBlurRadius = 220f,
					farBlurRadius = 287f
				};
			}

			// Token: 0x060078B2 RID: 30898 RVA: 0x00252428 File Offset: 0x00250628
			public static DepthOfField.FocusSettings EDMABHKFEEO()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 795f,
					range = 1862f,
					nearPlane = 16f,
					nearFalloff = 352f,
					farPlane = 410f,
					farFalloff = 331f,
					nearBlurRadius = 1013f,
					farBlurRadius = 1833f
				};
			}

			// Token: 0x060078B3 RID: 30899 RVA: 0x002524A8 File Offset: 0x002506A8
			public static DepthOfField.FocusSettings GJNKFICGFFG()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1064f,
					range = 712f,
					nearPlane = 889f,
					nearFalloff = 1044f,
					farPlane = 459f,
					farFalloff = 296f,
					nearBlurRadius = 1059f,
					farBlurRadius = 960f
				};
			}

			// Token: 0x060078B4 RID: 30900 RVA: 0x00252528 File Offset: 0x00250728
			public static DepthOfField.FocusSettings MLKLBGCKPOO()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1683f,
					range = 114f,
					nearPlane = 1620f,
					nearFalloff = 65f,
					farPlane = 1385f,
					farFalloff = 538f,
					nearBlurRadius = 1896f,
					farBlurRadius = 1038f
				};
			}

			// Token: 0x060078B5 RID: 30901 RVA: 0x002525A8 File Offset: 0x002507A8
			public static DepthOfField.FocusSettings BKEJIPPCPDO()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 440f,
					range = 1533f,
					nearPlane = 369f,
					nearFalloff = 964f,
					farPlane = 1066f,
					farFalloff = 1886f,
					nearBlurRadius = 1466f,
					farBlurRadius = 108f
				};
			}

			// Token: 0x060078B6 RID: 30902 RVA: 0x00252628 File Offset: 0x00250828
			public static DepthOfField.FocusSettings IOFLMDMLCAG()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1866f,
					range = 598f,
					nearPlane = 1580f,
					nearFalloff = 56f,
					farPlane = 1152f,
					farFalloff = 1741f,
					nearBlurRadius = 1755f,
					farBlurRadius = 1054f
				};
			}

			// Token: 0x060078B7 RID: 30903 RVA: 0x002526A8 File Offset: 0x002508A8
			public static DepthOfField.FocusSettings OIPFKIPOECC()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 752f,
					range = 937f,
					nearPlane = 1804f,
					nearFalloff = 1289f,
					farPlane = 1155f,
					farFalloff = 117f,
					nearBlurRadius = 661f,
					farBlurRadius = 1084f
				};
			}

			// Token: 0x060078B8 RID: 30904 RVA: 0x00252728 File Offset: 0x00250928
			public static DepthOfField.FocusSettings PKJMMJJFJAE()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 439f,
					range = 796f,
					nearPlane = 255f,
					nearFalloff = 1797f,
					farPlane = 211f,
					farFalloff = 1504f,
					nearBlurRadius = 1882f,
					farBlurRadius = 428f
				};
			}

			// Token: 0x060078B9 RID: 30905 RVA: 0x002527A8 File Offset: 0x002509A8
			public static DepthOfField.FocusSettings FPMJKNDJCON()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 843f,
					range = 1826f,
					nearPlane = 1567f,
					nearFalloff = 1913f,
					farPlane = 1535f,
					farFalloff = 1981f,
					nearBlurRadius = 466f,
					farBlurRadius = 67f
				};
			}

			// Token: 0x060078BA RID: 30906 RVA: 0x00252828 File Offset: 0x00250A28
			public static DepthOfField.FocusSettings BOMFHCIHHIP()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1644f,
					range = 1104f,
					nearPlane = 123f,
					nearFalloff = 1704f,
					farPlane = 880f,
					farFalloff = 289f,
					nearBlurRadius = 255f,
					farBlurRadius = 1376f
				};
			}

			// Token: 0x060078BB RID: 30907 RVA: 0x002528A8 File Offset: 0x00250AA8
			public static DepthOfField.FocusSettings KBINDKOODMK()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 953f,
					range = 30f,
					nearPlane = 623f,
					nearFalloff = 1924f,
					farPlane = 464f,
					farFalloff = 1980f,
					nearBlurRadius = 1568f,
					farBlurRadius = 377f
				};
			}

			// Token: 0x060078BC RID: 30908 RVA: 0x00252928 File Offset: 0x00250B28
			public static DepthOfField.FocusSettings GOKMCEIBFIM()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 58f,
					range = 978f,
					nearPlane = 385f,
					nearFalloff = 1478f,
					farPlane = 382f,
					farFalloff = 1378f,
					nearBlurRadius = 1775f,
					farBlurRadius = 1022f
				};
			}

			// Token: 0x060078BD RID: 30909 RVA: 0x002529A8 File Offset: 0x00250BA8
			public static DepthOfField.FocusSettings EBMPPAMNFNK()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1634f,
					range = 1974f,
					nearPlane = 815f,
					nearFalloff = 687f,
					farPlane = 1419f,
					farFalloff = 1660f,
					nearBlurRadius = 1658f,
					farBlurRadius = 857f
				};
			}

			// Token: 0x060078BE RID: 30910 RVA: 0x00252A28 File Offset: 0x00250C28
			public static DepthOfField.FocusSettings AOACBHHEGFA()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 392f,
					range = 1217f,
					nearPlane = 956f,
					nearFalloff = 1338f,
					farPlane = 1221f,
					farFalloff = 1635f,
					nearBlurRadius = 740f,
					farBlurRadius = 93f
				};
			}

			// Token: 0x060078BF RID: 30911 RVA: 0x00252AA8 File Offset: 0x00250CA8
			public static DepthOfField.FocusSettings DFIOJCABPFD()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1868f,
					range = 715f,
					nearPlane = 1491f,
					nearFalloff = 573f,
					farPlane = 1549f,
					farFalloff = 778f,
					nearBlurRadius = 1973f,
					farBlurRadius = 1329f
				};
			}

			// Token: 0x060078C0 RID: 30912 RVA: 0x00252B28 File Offset: 0x00250D28
			public static DepthOfField.FocusSettings MNKGFGNDKED()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 877f,
					range = 1039f,
					nearPlane = 231f,
					nearFalloff = 70f,
					farPlane = 1948f,
					farFalloff = 819f,
					nearBlurRadius = 460f,
					farBlurRadius = 377f
				};
			}

			// Token: 0x060078C1 RID: 30913 RVA: 0x00252BA8 File Offset: 0x00250DA8
			public static DepthOfField.FocusSettings NIPPCMNKCMB()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 649f,
					range = 1186f,
					nearPlane = 450f,
					nearFalloff = 1722f,
					farPlane = 1053f,
					farFalloff = 1963f,
					nearBlurRadius = 617f,
					farBlurRadius = 1906f
				};
			}

			// Token: 0x060078C2 RID: 30914 RVA: 0x00252C28 File Offset: 0x00250E28
			public static DepthOfField.FocusSettings CJFONFEOHIO()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 79f,
					range = 1879f,
					nearPlane = 1657f,
					nearFalloff = 1981f,
					farPlane = 1155f,
					farFalloff = 1941f,
					nearBlurRadius = 1406f,
					farBlurRadius = 1688f
				};
			}

			// Token: 0x060078C3 RID: 30915 RVA: 0x00252CA8 File Offset: 0x00250EA8
			public static DepthOfField.FocusSettings JCLADKAMOLD()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 668f,
					range = 1488f,
					nearPlane = 1094f,
					nearFalloff = 1273f,
					farPlane = 1179f,
					farFalloff = 1109f,
					nearBlurRadius = 1563f,
					farBlurRadius = 436f
				};
			}

			// Token: 0x060078C4 RID: 30916 RVA: 0x00252D28 File Offset: 0x00250F28
			public static DepthOfField.FocusSettings MGEOLKPLHOM()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 748f,
					range = 1444f,
					nearPlane = 963f,
					nearFalloff = 1425f,
					farPlane = 1855f,
					farFalloff = 1499f,
					nearBlurRadius = 1757f,
					farBlurRadius = 1383f
				};
			}

			// Token: 0x060078C5 RID: 30917 RVA: 0x00252DA8 File Offset: 0x00250FA8
			public static DepthOfField.FocusSettings EJLLADABOLM()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 351f,
					range = 1197f,
					nearPlane = 1395f,
					nearFalloff = 1381f,
					farPlane = 1508f,
					farFalloff = 1232f,
					nearBlurRadius = 519f,
					farBlurRadius = 1675f
				};
			}

			// Token: 0x060078C6 RID: 30918 RVA: 0x00252E28 File Offset: 0x00251028
			public static DepthOfField.FocusSettings INDEHPGLEGK()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1389f,
					range = 1333f,
					nearPlane = 115f,
					nearFalloff = 390f,
					farPlane = 1993f,
					farFalloff = 1208f,
					nearBlurRadius = 1202f,
					farBlurRadius = 1400f
				};
			}

			// Token: 0x060078C7 RID: 30919 RVA: 0x00252EA8 File Offset: 0x002510A8
			public static DepthOfField.FocusSettings BCOPOEIJONI()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 406f,
					range = 461f,
					nearPlane = 608f,
					nearFalloff = 60f,
					farPlane = 1863f,
					farFalloff = 352f,
					nearBlurRadius = 1302f,
					farBlurRadius = 1752f
				};
			}

			// Token: 0x060078C8 RID: 30920 RVA: 0x00252F28 File Offset: 0x00251128
			public static DepthOfField.FocusSettings NCFGPFGLKLJ()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 513f,
					range = 1459f,
					nearPlane = 474f,
					nearFalloff = 905f,
					farPlane = 741f,
					farFalloff = 901f,
					nearBlurRadius = 145f,
					farBlurRadius = 1909f
				};
			}

			// Token: 0x060078C9 RID: 30921 RVA: 0x00252FA8 File Offset: 0x002511A8
			public static DepthOfField.FocusSettings ELOBECLMGDD()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 145f,
					range = 872f,
					nearPlane = 1680f,
					nearFalloff = 1087f,
					farPlane = 35f,
					farFalloff = 554f,
					nearBlurRadius = 1919f,
					farBlurRadius = 965f
				};
			}

			// Token: 0x060078CA RID: 30922 RVA: 0x00253028 File Offset: 0x00251228
			public static DepthOfField.FocusSettings MHIHHBMBDLP()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1920f,
					range = 1621f,
					nearPlane = 190f,
					nearFalloff = 827f,
					farPlane = 1820f,
					farFalloff = 539f,
					nearBlurRadius = 1185f,
					farBlurRadius = 604f
				};
			}

			// Token: 0x060078CB RID: 30923 RVA: 0x002530A8 File Offset: 0x002512A8
			public static DepthOfField.FocusSettings DBDJKKLMCGG()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 300f,
					range = 785f,
					nearPlane = 833f,
					nearFalloff = 1148f,
					farPlane = 1969f,
					farFalloff = 770f,
					nearBlurRadius = 680f,
					farBlurRadius = 245f
				};
			}

			// Token: 0x060078CC RID: 30924 RVA: 0x00253128 File Offset: 0x00251328
			public static DepthOfField.FocusSettings AFJJPFIOEJD()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1845f,
					range = 1024f,
					nearPlane = 1850f,
					nearFalloff = 789f,
					farPlane = 596f,
					farFalloff = 1008f,
					nearBlurRadius = 314f,
					farBlurRadius = 1063f
				};
			}

			// Token: 0x060078CD RID: 30925 RVA: 0x002531A8 File Offset: 0x002513A8
			public static DepthOfField.FocusSettings EEMMJNPOFOB()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1666f,
					range = 504f,
					nearPlane = 1005f,
					nearFalloff = 56f,
					farPlane = 1629f,
					farFalloff = 1256f,
					nearBlurRadius = 1024f,
					farBlurRadius = 1324f
				};
			}

			// Token: 0x060078CE RID: 30926 RVA: 0x00253228 File Offset: 0x00251428
			public static DepthOfField.FocusSettings CIHLOMNEHHL()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 873f,
					range = 1633f,
					nearPlane = 1169f,
					nearFalloff = 218f,
					farPlane = 1529f,
					farFalloff = 1483f,
					nearBlurRadius = 57f,
					farBlurRadius = 319f
				};
			}

			// Token: 0x060078CF RID: 30927 RVA: 0x002532A8 File Offset: 0x002514A8
			public static DepthOfField.FocusSettings FCBIDJLDABO()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 55f,
					range = 1483f,
					nearPlane = 1220f,
					nearFalloff = 1805f,
					farPlane = 1033f,
					farFalloff = 1127f,
					nearBlurRadius = 1595f,
					farBlurRadius = 882f
				};
			}

			// Token: 0x060078D0 RID: 30928 RVA: 0x00253328 File Offset: 0x00251528
			public static DepthOfField.FocusSettings LOMOMPKEDPL()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1514f,
					range = 572f,
					nearPlane = 678f,
					nearFalloff = 1770f,
					farPlane = 733f,
					farFalloff = 1170f,
					nearBlurRadius = 468f,
					farBlurRadius = 1774f
				};
			}

			// Token: 0x060078D1 RID: 30929 RVA: 0x002533A8 File Offset: 0x002515A8
			public static DepthOfField.FocusSettings IAKAIGHJJJK()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 981f,
					range = 1685f,
					nearPlane = 575f,
					nearFalloff = 620f,
					farPlane = 126f,
					farFalloff = 907f,
					nearBlurRadius = 1600f,
					farBlurRadius = 1888f
				};
			}

			// Token: 0x060078D2 RID: 30930 RVA: 0x00253428 File Offset: 0x00251628
			public static DepthOfField.FocusSettings NOBNMJMOJDB()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 241f,
					range = 128f,
					nearPlane = 1806f,
					nearFalloff = 893f,
					farPlane = 1283f,
					farFalloff = 1623f,
					nearBlurRadius = 1860f,
					farBlurRadius = 1770f
				};
			}

			// Token: 0x17000180 RID: 384
			// (get) Token: 0x060078D3 RID: 30931 RVA: 0x002534A8 File Offset: 0x002516A8
			public static DepthOfField.FocusSettings defaultSettings
			{
				get
				{
					return new DepthOfField.FocusSettings
					{
						transform = null,
						focusPlane = 20f,
						range = 35f,
						nearPlane = 2.5f,
						nearFalloff = 15f,
						farPlane = 37.5f,
						farFalloff = 50f,
						nearBlurRadius = 15f,
						farBlurRadius = 20f
					};
				}
			}

			// Token: 0x060078D4 RID: 30932 RVA: 0x00253528 File Offset: 0x00251728
			public static DepthOfField.FocusSettings LBIOOILOAAD()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 667f,
					range = 1717f,
					nearPlane = 1684f,
					nearFalloff = 544f,
					farPlane = 1679f,
					farFalloff = 1643f,
					nearBlurRadius = 850f,
					farBlurRadius = 562f
				};
			}

			// Token: 0x060078D5 RID: 30933 RVA: 0x002535A8 File Offset: 0x002517A8
			public static DepthOfField.FocusSettings CCADIDPNEKH()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1921f,
					range = 1279f,
					nearPlane = 222f,
					nearFalloff = 182f,
					farPlane = 451f,
					farFalloff = 1475f,
					nearBlurRadius = 1663f,
					farBlurRadius = 1525f
				};
			}

			// Token: 0x060078D6 RID: 30934 RVA: 0x00253628 File Offset: 0x00251828
			public static DepthOfField.FocusSettings IHMKIGDJKAH()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 131f,
					range = 1015f,
					nearPlane = 1161f,
					nearFalloff = 893f,
					farPlane = 1949f,
					farFalloff = 255f,
					nearBlurRadius = 110f,
					farBlurRadius = 255f
				};
			}

			// Token: 0x060078D7 RID: 30935 RVA: 0x002536A8 File Offset: 0x002518A8
			public static DepthOfField.FocusSettings IAKJOAGBDGO()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1283f,
					range = 371f,
					nearPlane = 501f,
					nearFalloff = 249f,
					farPlane = 853f,
					farFalloff = 1554f,
					nearBlurRadius = 598f,
					farBlurRadius = 623f
				};
			}

			// Token: 0x060078D8 RID: 30936 RVA: 0x00253728 File Offset: 0x00251928
			public static DepthOfField.FocusSettings LIDMIPKCHOI()
			{
				return new DepthOfField.FocusSettings
				{
					transform = null,
					focusPlane = 1377f,
					range = 568f,
					nearPlane = 88f,
					nearFalloff = 1349f,
					farPlane = 578f,
					farFalloff = 1517f,
					nearBlurRadius = 16f,
					farBlurRadius = 554f
				};
			}

			// Token: 0x04000C9E RID: 3230
			[Tooltip("Auto-focus on a selected transform.")]
			public Transform transform;

			// Token: 0x04000C9F RID: 3231
			[Tooltip("Focus distance (in world units).")]
			[Min(0f)]
			public float focusPlane;

			// Token: 0x04000CA0 RID: 3232
			[Min(0.1f)]
			[Tooltip("Focus range (in world units). The focus plane is located in the center of the range.")]
			public float range;

			// Token: 0x04000CA1 RID: 3233
			[Tooltip("Near focus distance (in world units).")]
			[Min(0f)]
			public float nearPlane;

			// Token: 0x04000CA2 RID: 3234
			[Tooltip("Near blur falloff (in world units).")]
			[Min(0f)]
			public float nearFalloff;

			// Token: 0x04000CA3 RID: 3235
			[Tooltip("Far focus distance (in world units).")]
			[Min(0f)]
			public float farPlane;

			// Token: 0x04000CA4 RID: 3236
			[Tooltip("Far blur falloff (in world units).")]
			[Min(0f)]
			public float farFalloff;

			// Token: 0x04000CA5 RID: 3237
			[Range(0f, 40f)]
			[Tooltip("Maximum blur radius for the near plane.")]
			public float nearBlurRadius;

			// Token: 0x04000CA6 RID: 3238
			[Tooltip("Maximum blur radius for the far plane.")]
			[Range(0f, 40f)]
			public float farBlurRadius;
		}

		// Token: 0x020001BD RID: 445
		[Serializable]
		public struct BokehTextureSettings
		{
			// Token: 0x060078D9 RID: 30937 RVA: 0x002537A8 File Offset: 0x002519A8
			public static DepthOfField.BokehTextureSettings MNKGFGNDKED()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 1632f,
					intensity = 1051f,
					threshold = 1036f,
					spawnHeuristic = 1384f
				};
			}

			// Token: 0x060078DA RID: 30938 RVA: 0x002537F8 File Offset: 0x002519F8
			public static DepthOfField.BokehTextureSettings LBIOOILOAAD()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 1312f,
					intensity = 483f,
					threshold = 233f,
					spawnHeuristic = 995f
				};
			}

			// Token: 0x060078DB RID: 30939 RVA: 0x00253848 File Offset: 0x00251A48
			public static DepthOfField.BokehTextureSettings AAPGCALKNAK()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 368f,
					intensity = 1231f,
					threshold = 115f,
					spawnHeuristic = 130f
				};
			}

			// Token: 0x060078DC RID: 30940 RVA: 0x00253898 File Offset: 0x00251A98
			public static DepthOfField.BokehTextureSettings BCOPOEIJONI()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 387f,
					intensity = 57f,
					threshold = 1537f,
					spawnHeuristic = 1814f
				};
			}

			// Token: 0x060078DD RID: 30941 RVA: 0x002538E8 File Offset: 0x00251AE8
			public static DepthOfField.BokehTextureSettings IHMKIGDJKAH()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 1836f,
					intensity = 1262f,
					threshold = 408f,
					spawnHeuristic = 222f
				};
			}

			// Token: 0x060078DE RID: 30942 RVA: 0x00253938 File Offset: 0x00251B38
			public static DepthOfField.BokehTextureSettings IAKJOAGBDGO()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 1303f,
					intensity = 127f,
					threshold = 104f,
					spawnHeuristic = 523f
				};
			}

			// Token: 0x060078DF RID: 30943 RVA: 0x00253988 File Offset: 0x00251B88
			public static DepthOfField.BokehTextureSettings EJLLADABOLM()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 1748f,
					intensity = 299f,
					threshold = 971f,
					spawnHeuristic = 1157f
				};
			}

			// Token: 0x060078E0 RID: 30944 RVA: 0x002539D8 File Offset: 0x00251BD8
			public static DepthOfField.BokehTextureSettings DBDJKKLMCGG()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 749f,
					intensity = 1123f,
					threshold = 519f,
					spawnHeuristic = 1221f
				};
			}

			// Token: 0x17000181 RID: 385
			// (get) Token: 0x060078E1 RID: 30945 RVA: 0x00253A28 File Offset: 0x00251C28
			public static DepthOfField.BokehTextureSettings defaultSettings
			{
				get
				{
					return new DepthOfField.BokehTextureSettings
					{
						texture = null,
						scale = 1f,
						intensity = 50f,
						threshold = 2f,
						spawnHeuristic = 0.15f
					};
				}
			}

			// Token: 0x060078E2 RID: 30946 RVA: 0x00253A78 File Offset: 0x00251C78
			public static DepthOfField.BokehTextureSettings INDEHPGLEGK()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 1234f,
					intensity = 1436f,
					threshold = 1529f,
					spawnHeuristic = 523f
				};
			}

			// Token: 0x060078E3 RID: 30947 RVA: 0x00253AC8 File Offset: 0x00251CC8
			public static DepthOfField.BokehTextureSettings DFIOJCABPFD()
			{
				return new DepthOfField.BokehTextureSettings
				{
					texture = null,
					scale = 682f,
					intensity = 1713f,
					threshold = 383f,
					spawnHeuristic = 378f
				};
			}

			// Token: 0x04000CA7 RID: 3239
			[Tooltip("Adding a texture to this field will enable the use of \"Bokeh Textures\". Use with care. This feature is only available on Shader Model 5 compatible-hardware and performance scale with the amount of bokeh.")]
			public Texture2D texture;

			// Token: 0x04000CA8 RID: 3240
			[Range(0.01f, 10f)]
			[Tooltip("Maximum size of bokeh textures on screen.")]
			public float scale;

			// Token: 0x04000CA9 RID: 3241
			[Range(0.01f, 100f)]
			[Tooltip("Bokeh brightness.")]
			public float intensity;

			// Token: 0x04000CAA RID: 3242
			[Range(0.01f, 5f)]
			[Tooltip("Controls the amount of bokeh textures. Lower values mean more bokeh splats.")]
			public float threshold;

			// Token: 0x04000CAB RID: 3243
			[Tooltip("Controls the spawn conditions. Lower values mean more visible bokeh.")]
			[Range(0.01f, 1f)]
			public float spawnHeuristic;
		}
	}
}
