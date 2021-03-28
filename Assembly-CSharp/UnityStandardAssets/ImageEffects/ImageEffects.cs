using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001E8 RID: 488
	[AddComponentMenu("")]
	public class ImageEffects
	{
		// Token: 0x06007DFC RID: 32252 RVA: 0x0029ABB6 File Offset: 0x00298DB6
		public static void DNDNHNLCFMN(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL);
		}

		// Token: 0x06007DFD RID: 32253 RVA: 0x0029ABBF File Offset: 0x00298DBF
		public static void OKMPFKIINIL(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL, NBPKMLMCHFN);
		}

		// Token: 0x06007DFE RID: 32254 RVA: 0x0029ABB6 File Offset: 0x00298DB6
		public static void EKBLHCGKEMC(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL);
		}

		// Token: 0x06007E00 RID: 32256 RVA: 0x0029ABB6 File Offset: 0x00298DB6
		public static void IBCDCNEIJLA(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL);
		}

		// Token: 0x06007E01 RID: 32257 RVA: 0x0029ABCC File Offset: 0x00298DCC
		public static void AGPIKDLFPAP(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM, float JEELPBBJKDL, Vector2 KACBKDLBEMA, Vector2 FGJCOIDIJDG)
		{
			bool flag = HLBKCLPNHEB.texelSize.y < 850f;
			if (flag)
			{
				KACBKDLBEMA.y = 727f - KACBKDLBEMA.y;
				JEELPBBJKDL = -JEELPBBJKDL;
			}
			Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(859f, 960f, JEELPBBJKDL), Vector3.one);
			NBPKMLMCHFN.SetMatrix("workshop.", value);
			NBPKMLMCHFN.SetVector("_Bullet_8", new Vector4(KACBKDLBEMA.x, KACBKDLBEMA.y, FGJCOIDIJDG.x, FGJCOIDIJDG.y));
			NBPKMLMCHFN.SetFloat("Failed to 'network-remove' GameObject because it's null.", JEELPBBJKDL * 1130f);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN);
		}

		// Token: 0x06007E02 RID: 32258 RVA: 0x0029ABB6 File Offset: 0x00298DB6
		[Obsolete("Use Graphics.Blit(source,dest) instead")]
		public static void Blit(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL);
		}

		// Token: 0x06007E03 RID: 32259 RVA: 0x0029ABB6 File Offset: 0x00298DB6
		public static void JEGCLPIGFEN(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL);
		}

		// Token: 0x06007E04 RID: 32260 RVA: 0x0029ABB6 File Offset: 0x00298DB6
		public static void KFBDNFCAPDN(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL);
		}

		// Token: 0x06007E05 RID: 32261 RVA: 0x0029ABBF File Offset: 0x00298DBF
		public static void JFDAAKJEPKI(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL, NBPKMLMCHFN);
		}

		// Token: 0x06007E06 RID: 32262 RVA: 0x0029ABBF File Offset: 0x00298DBF
		[Obsolete("Use Graphics.Blit(source, destination, material) instead")]
		public static void BlitWithMaterial(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL, NBPKMLMCHFN);
		}

		// Token: 0x06007E07 RID: 32263 RVA: 0x0029AC80 File Offset: 0x00298E80
		public static void BNLBLAACADN(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM, float JEELPBBJKDL, Vector2 KACBKDLBEMA, Vector2 FGJCOIDIJDG)
		{
			bool flag = HLBKCLPNHEB.texelSize.y < 977f;
			if (flag)
			{
				KACBKDLBEMA.y = 731f - KACBKDLBEMA.y;
				JEELPBBJKDL = -JEELPBBJKDL;
			}
			Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(1071f, 1293f, JEELPBBJKDL), Vector3.one);
			NBPKMLMCHFN.SetMatrix("_Value2", value);
			NBPKMLMCHFN.SetVector("PlayButton", new Vector4(KACBKDLBEMA.x, KACBKDLBEMA.y, FGJCOIDIJDG.x, FGJCOIDIJDG.y));
			NBPKMLMCHFN.SetFloat("Failed to InstantiateSceneObject prefab: ", JEELPBBJKDL * 57f);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN);
		}

		// Token: 0x06007E08 RID: 32264 RVA: 0x0029ABB6 File Offset: 0x00298DB6
		public static void AEOJOONKLGB(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL);
		}

		// Token: 0x06007E09 RID: 32265 RVA: 0x0029ABBF File Offset: 0x00298DBF
		public static void BIDINKAAIKG(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL, NBPKMLMCHFN);
		}

		// Token: 0x06007E0A RID: 32266 RVA: 0x0029ABB6 File Offset: 0x00298DB6
		public static void JEFAHIMGPON(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL);
		}

		// Token: 0x06007E0B RID: 32267 RVA: 0x0029ABB6 File Offset: 0x00298DB6
		public static void KJOPLKLFFFK(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL);
		}

		// Token: 0x06007E0C RID: 32268 RVA: 0x0029AD34 File Offset: 0x00298F34
		public static void GHFCOJLPJJO(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM, float JEELPBBJKDL, Vector2 KACBKDLBEMA, Vector2 FGJCOIDIJDG)
		{
			bool flag = HLBKCLPNHEB.texelSize.y < 788f;
			if (flag)
			{
				KACBKDLBEMA.y = 1703f - KACBKDLBEMA.y;
				JEELPBBJKDL = -JEELPBBJKDL;
			}
			Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(329f, 1037f, JEELPBBJKDL), Vector3.one);
			NBPKMLMCHFN.SetMatrix("Connected to NameServer.", value);
			NBPKMLMCHFN.SetVector("_Distortion", new Vector4(KACBKDLBEMA.x, KACBKDLBEMA.y, FGJCOIDIJDG.x, FGJCOIDIJDG.y));
			NBPKMLMCHFN.SetFloat("maps.", JEELPBBJKDL * 684f);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN);
		}

		// Token: 0x06007E0D RID: 32269 RVA: 0x0029ADE8 File Offset: 0x00298FE8
		public static void PDONJBPKJNM(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM, float JEELPBBJKDL, Vector2 KACBKDLBEMA, Vector2 FGJCOIDIJDG)
		{
			bool flag = HLBKCLPNHEB.texelSize.y < 1912f;
			if (flag)
			{
				KACBKDLBEMA.y = 533f - KACBKDLBEMA.y;
				JEELPBBJKDL = -JEELPBBJKDL;
			}
			Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(1461f, 774f, JEELPBBJKDL), Vector3.one);
			NBPKMLMCHFN.SetMatrix("[PlayerBase] Loaded environment: ", value);
			NBPKMLMCHFN.SetVector("blue", new Vector4(KACBKDLBEMA.x, KACBKDLBEMA.y, FGJCOIDIJDG.x, FGJCOIDIJDG.y));
			NBPKMLMCHFN.SetFloat("PerfectHitsScoreText", JEELPBBJKDL * 456f);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN);
		}

		// Token: 0x06007E0E RID: 32270 RVA: 0x0029AE9C File Offset: 0x0029909C
		public static void KHOCEDHFNEA(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM, float JEELPBBJKDL, Vector2 KACBKDLBEMA, Vector2 FGJCOIDIJDG)
		{
			bool flag = HLBKCLPNHEB.texelSize.y < 1982f;
			if (flag)
			{
				KACBKDLBEMA.y = 996f - KACBKDLBEMA.y;
				JEELPBBJKDL = -JEELPBBJKDL;
			}
			Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(1609f, 1738f, JEELPBBJKDL), Vector3.one);
			NBPKMLMCHFN.SetMatrix("\" to target: ", value);
			NBPKMLMCHFN.SetVector("_AdditiveReflection", new Vector4(KACBKDLBEMA.x, KACBKDLBEMA.y, FGJCOIDIJDG.x, FGJCOIDIJDG.y));
			NBPKMLMCHFN.SetFloat("_TimeX", JEELPBBJKDL * 46f);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN);
		}

		// Token: 0x06007E0F RID: 32271 RVA: 0x0029AF50 File Offset: 0x00299150
		public static void RenderDistortion(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM, float JEELPBBJKDL, Vector2 KACBKDLBEMA, Vector2 FGJCOIDIJDG)
		{
			bool flag = HLBKCLPNHEB.texelSize.y < 0f;
			if (flag)
			{
				KACBKDLBEMA.y = 1f - KACBKDLBEMA.y;
				JEELPBBJKDL = -JEELPBBJKDL;
			}
			Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(0f, 0f, JEELPBBJKDL), Vector3.one);
			NBPKMLMCHFN.SetMatrix("_RotationMatrix", value);
			NBPKMLMCHFN.SetVector("_CenterRadius", new Vector4(KACBKDLBEMA.x, KACBKDLBEMA.y, FGJCOIDIJDG.x, FGJCOIDIJDG.y));
			NBPKMLMCHFN.SetFloat("_Angle", JEELPBBJKDL * 0.0174532924f);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN);
		}

		// Token: 0x06007E10 RID: 32272 RVA: 0x0029ABBF File Offset: 0x00298DBF
		public static void IMLNMDNJNAJ(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL, NBPKMLMCHFN);
		}

		// Token: 0x06007E11 RID: 32273 RVA: 0x0029ABBF File Offset: 0x00298DBF
		public static void BEFJIJMCLCB(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL, NBPKMLMCHFN);
		}

		// Token: 0x06007E12 RID: 32274 RVA: 0x0029ABBF File Offset: 0x00298DBF
		public static void IGAEBPKHCDI(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL, NBPKMLMCHFN);
		}

		// Token: 0x06007E13 RID: 32275 RVA: 0x0029ABBF File Offset: 0x00298DBF
		public static void PMIBMHIJBAG(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL, NBPKMLMCHFN);
		}

		// Token: 0x06007E14 RID: 32276 RVA: 0x0029ABB6 File Offset: 0x00298DB6
		public static void DOOFJEAHPAK(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL);
		}

		// Token: 0x06007E15 RID: 32277 RVA: 0x0029ABBF File Offset: 0x00298DBF
		public static void LFCHAKDIACC(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL, NBPKMLMCHFN);
		}

		// Token: 0x06007E16 RID: 32278 RVA: 0x0029ABB6 File Offset: 0x00298DB6
		public static void LGMPIKILPHO(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL);
		}

		// Token: 0x06007E17 RID: 32279 RVA: 0x0029ABB6 File Offset: 0x00298DB6
		public static void KBEKIHGPEIJ(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL);
		}

		// Token: 0x06007E18 RID: 32280 RVA: 0x0029ABBF File Offset: 0x00298DBF
		public static void FADAGJBLDHF(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL, NBPKMLMCHFN);
		}

		// Token: 0x06007E19 RID: 32281 RVA: 0x0029ABB6 File Offset: 0x00298DB6
		public static void OLBDFGNMIJA(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL);
		}

		// Token: 0x06007E1A RID: 32282 RVA: 0x0029B004 File Offset: 0x00299204
		public static void BHLNDHPGAHF(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM, float JEELPBBJKDL, Vector2 KACBKDLBEMA, Vector2 FGJCOIDIJDG)
		{
			bool flag = HLBKCLPNHEB.texelSize.y < 68f;
			if (flag)
			{
				KACBKDLBEMA.y = 1579f - KACBKDLBEMA.y;
				JEELPBBJKDL = -JEELPBBJKDL;
			}
			Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(849f, 1260f, JEELPBBJKDL), Vector3.one);
			NBPKMLMCHFN.SetMatrix("_Value", value);
			NBPKMLMCHFN.SetVector("_RotationMatrix", new Vector4(KACBKDLBEMA.x, KACBKDLBEMA.y, FGJCOIDIJDG.x, FGJCOIDIJDG.y));
			NBPKMLMCHFN.SetFloat("/", JEELPBBJKDL * 639f);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN);
		}

		// Token: 0x06007E1B RID: 32283 RVA: 0x0029ABB6 File Offset: 0x00298DB6
		public static void DMLHLGBLBNA(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL);
		}

		// Token: 0x06007E1C RID: 32284 RVA: 0x0029B0B8 File Offset: 0x002992B8
		public static void HFNMMNANFFA(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM, float JEELPBBJKDL, Vector2 KACBKDLBEMA, Vector2 FGJCOIDIJDG)
		{
			bool flag = HLBKCLPNHEB.texelSize.y < 1909f;
			if (flag)
			{
				KACBKDLBEMA.y = 1282f - KACBKDLBEMA.y;
				JEELPBBJKDL = -JEELPBBJKDL;
			}
			Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(1488f, 926f, JEELPBBJKDL), Vector3.one);
			NBPKMLMCHFN.SetMatrix("_Amount", value);
			NBPKMLMCHFN.SetVector("workshop.", new Vector4(KACBKDLBEMA.x, KACBKDLBEMA.y, FGJCOIDIJDG.x, FGJCOIDIJDG.y));
			NBPKMLMCHFN.SetFloat("_Value6", JEELPBBJKDL * 735f);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN);
		}

		// Token: 0x06007E1D RID: 32285 RVA: 0x0029ABBF File Offset: 0x00298DBF
		public static void GOPAHKALJHL(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL, NBPKMLMCHFN);
		}

		// Token: 0x06007E1E RID: 32286 RVA: 0x0029ABBF File Offset: 0x00298DBF
		public static void LLNJKFNBAHB(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL, NBPKMLMCHFN);
		}

		// Token: 0x06007E1F RID: 32287 RVA: 0x0029ABBF File Offset: 0x00298DBF
		public static void KDOMBEJKOKF(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL, NBPKMLMCHFN);
		}

		// Token: 0x06007E20 RID: 32288 RVA: 0x0029ABBF File Offset: 0x00298DBF
		public static void BPDOHJJDGND(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL, NBPKMLMCHFN);
		}

		// Token: 0x06007E21 RID: 32289 RVA: 0x0029ABBF File Offset: 0x00298DBF
		public static void ABFFMFELOHP(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL, NBPKMLMCHFN);
		}

		// Token: 0x06007E22 RID: 32290 RVA: 0x0029ABBF File Offset: 0x00298DBF
		public static void CLDKKHMAPCP(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL, NBPKMLMCHFN);
		}

		// Token: 0x06007E23 RID: 32291 RVA: 0x0029ABBF File Offset: 0x00298DBF
		public static void ICLHBHHNCJO(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL, NBPKMLMCHFN);
		}

		// Token: 0x06007E24 RID: 32292 RVA: 0x0029ABB6 File Offset: 0x00298DB6
		public static void NDDAHGNPKDB(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL);
		}

		// Token: 0x06007E25 RID: 32293 RVA: 0x0029ABB6 File Offset: 0x00298DB6
		public static void KCGJAIICAMG(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL);
		}

		// Token: 0x06007E26 RID: 32294 RVA: 0x0029B16C File Offset: 0x0029936C
		public static void LMBLCDOJBLB(Material NBPKMLMCHFN, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM, float JEELPBBJKDL, Vector2 KACBKDLBEMA, Vector2 FGJCOIDIJDG)
		{
			bool flag = HLBKCLPNHEB.texelSize.y < 93f;
			if (flag)
			{
				KACBKDLBEMA.y = 1001f - KACBKDLBEMA.y;
				JEELPBBJKDL = -JEELPBBJKDL;
			}
			Matrix4x4 value = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(1939f, 1834f, JEELPBBJKDL), Vector3.one);
			NBPKMLMCHFN.SetMatrix("[LocalizationService] Error: ", value);
			NBPKMLMCHFN.SetVector(".completedMaps", new Vector4(KACBKDLBEMA.x, KACBKDLBEMA.y, FGJCOIDIJDG.x, FGJCOIDIJDG.y));
			NBPKMLMCHFN.SetFloat("_Value7", JEELPBBJKDL * 1144f);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, NBPKMLMCHFN);
		}

		// Token: 0x06007E27 RID: 32295 RVA: 0x0029ABB6 File Offset: 0x00298DB6
		public static void HKNCIFNEGBI(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			Graphics.Blit(HLBKCLPNHEB, FHNFPBCBODL);
		}
	}
}
