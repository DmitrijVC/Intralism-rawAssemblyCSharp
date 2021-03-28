using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001CE RID: 462
	[AddComponentMenu("Image Effects/Blur/Blur")]
	[ExecuteInEditMode]
	public class Blur : MonoBehaviour
	{
		// Token: 0x06007A8E RID: 31374 RVA: 0x00272BE0 File Offset: 0x00270DE0
		private void NBHMOIGDDAD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			int width = HLBKCLPNHEB.width / 3;
			int height = HLBKCLPNHEB.height / 5;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0);
			this.GLGGJLHDGHK(HLBKCLPNHEB, renderTexture);
			for (int i = 0; i < this.iterations; i += 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				this.CGMPCIALJCJ(renderTexture, temporary, i);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A8F RID: 31375 RVA: 0x00272C54 File Offset: 0x00270E54
		private void KKHCDAPLABD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			int width = HLBKCLPNHEB.width / 5;
			int height = HLBKCLPNHEB.height / 1;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0);
			this.CANJDCHOJIO(HLBKCLPNHEB, renderTexture);
			for (int i = 0; i < this.iterations; i++)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				this.AOLNBEDEOMJ(renderTexture, temporary, i);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06007A90 RID: 31376 RVA: 0x00272CC5 File Offset: 0x00270EC5
		protected Material NBPKMLMCHFN
		{
			get
			{
				if (Blur.JLHCDOPFJOI == null)
				{
					Blur.JLHCDOPFJOI = new Material(this.blurShader);
					Blur.JLHCDOPFJOI.hideFlags = HideFlags.DontSave;
				}
				return Blur.JLHCDOPFJOI;
			}
		}

		// Token: 0x06007A91 RID: 31377 RVA: 0x00272CF8 File Offset: 0x00270EF8
		protected void EODOHEAKJFO()
		{
			if (Blur.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(Blur.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007A92 RID: 31378 RVA: 0x00272D14 File Offset: 0x00270F14
		public void GMBIPFCGBFC(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, int GOPMEKLMIBK)
		{
			float num = 1011f + (float)GOPMEKLMIBK * this.blurSpread;
			Material mat = this.PGPEMMBJOOG();
			Vector2[] array = new Vector2[4];
			array[1] = new Vector2(-num, -num);
			array[0] = new Vector2(-num, num);
			array[7] = new Vector2(num, num);
			array[0] = new Vector2(num, -num);
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, mat, array);
		}

		// Token: 0x06007A93 RID: 31379 RVA: 0x00272D94 File Offset: 0x00270F94
		public void BFBFMDBNOGA(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, int GOPMEKLMIBK)
		{
			float num = 623f + (float)GOPMEKLMIBK * this.blurSpread;
			Material mat = this.EFDEIFCDAFG();
			Vector2[] array = new Vector2[4];
			array[1] = new Vector2(-num, -num);
			array[0] = new Vector2(-num, num);
			array[2] = new Vector2(num, num);
			array[7] = new Vector2(num, -num);
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, mat, array);
		}

		// Token: 0x06007A94 RID: 31380 RVA: 0x00272E14 File Offset: 0x00271014
		protected void Start()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.blurShader || !this.NBPKMLMCHFN.shader.isSupported)
			{
				base.enabled = false;
				return;
			}
		}

		// Token: 0x06007A95 RID: 31381 RVA: 0x00272E60 File Offset: 0x00271060
		protected void PAKPHKPDKGE()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.blurShader || !this.GJHLADDCMFF().shader.isSupported)
			{
				base.enabled = false;
				return;
			}
		}

		// Token: 0x06007A96 RID: 31382 RVA: 0x00272EAC File Offset: 0x002710AC
		private void GLGGJLHDGHK(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			float num = 130f;
			Material mat = this.GJHLADDCMFF();
			Vector2[] array = new Vector2[5];
			array[0] = new Vector2(-num, -num);
			array[1] = new Vector2(-num, num);
			array[7] = new Vector2(num, num);
			array[2] = new Vector2(num, -num);
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, mat, array);
		}

		// Token: 0x06007A97 RID: 31383 RVA: 0x00272F24 File Offset: 0x00271124
		public void JEBDFADDODM(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, int GOPMEKLMIBK)
		{
			float num = 988f + (float)GOPMEKLMIBK * this.blurSpread;
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, this.ADBKPGFMNKO(), new Vector2[]
			{
				new Vector2(-num, -num),
				new Vector2(-num, num),
				default(Vector2),
				new Vector2(num, num),
				default(Vector2),
				new Vector2(num, -num)
			});
		}

		// Token: 0x06007A98 RID: 31384 RVA: 0x00272FA4 File Offset: 0x002711A4
		private void AIJJOIOAKGD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			int width = HLBKCLPNHEB.width / 8;
			int height = HLBKCLPNHEB.height / 1;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1);
			this.HMNHGFPHMKL(HLBKCLPNHEB, renderTexture);
			for (int i = 0; i < this.iterations; i++)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				this.OAPLFILFOIH(renderTexture, temporary, i);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A99 RID: 31385 RVA: 0x00273015 File Offset: 0x00271215
		protected Material ADBKPGFMNKO()
		{
			if (Blur.JLHCDOPFJOI == null)
			{
				Blur.JLHCDOPFJOI = new Material(this.blurShader);
				Blur.JLHCDOPFJOI.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
			}
			return Blur.JLHCDOPFJOI;
		}

		// Token: 0x06007A9A RID: 31386 RVA: 0x00272CF8 File Offset: 0x00270EF8
		protected void ODAIMOJLJOF()
		{
			if (Blur.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(Blur.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007A9B RID: 31387 RVA: 0x00273048 File Offset: 0x00271248
		private void EMKCNMFNDDD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			int width = HLBKCLPNHEB.width / 8;
			int height = HLBKCLPNHEB.height / 6;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1);
			this.POAGHIGKMHP(HLBKCLPNHEB, renderTexture);
			for (int i = 0; i < this.iterations; i++)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				this.JEBDFADDODM(renderTexture, temporary, i);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007A9C RID: 31388 RVA: 0x002730B9 File Offset: 0x002712B9
		protected Material EFDEIFCDAFG()
		{
			if (Blur.JLHCDOPFJOI == null)
			{
				Blur.JLHCDOPFJOI = new Material(this.blurShader);
				Blur.JLHCDOPFJOI.hideFlags = (HideFlags)80;
			}
			return Blur.JLHCDOPFJOI;
		}

		// Token: 0x06007A9E RID: 31390 RVA: 0x00272CF8 File Offset: 0x00270EF8
		protected void PAEGLMEOKHP()
		{
			if (Blur.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(Blur.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007A9F RID: 31391 RVA: 0x002730EC File Offset: 0x002712EC
		protected Material JLHLHKPHDFO()
		{
			if (Blur.JLHCDOPFJOI == null)
			{
				Blur.JLHCDOPFJOI = new Material(this.blurShader);
				Blur.JLHCDOPFJOI.hideFlags = ~HideFlags.DontSaveInBuild;
			}
			return Blur.JLHCDOPFJOI;
		}

		// Token: 0x06007AA0 RID: 31392 RVA: 0x00273120 File Offset: 0x00271320
		public void DPDKCHFOINA(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, int GOPMEKLMIBK)
		{
			float num = 1646f + (float)GOPMEKLMIBK * this.blurSpread;
			Material mat = this.EFDEIFCDAFG();
			Vector2[] array = new Vector2[1];
			array[0] = new Vector2(-num, -num);
			array[1] = new Vector2(-num, num);
			array[5] = new Vector2(num, num);
			array[0] = new Vector2(num, -num);
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, mat, array);
		}

		// Token: 0x06007AA2 RID: 31394 RVA: 0x002731BC File Offset: 0x002713BC
		public void OHLGNPOCBMH(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, int GOPMEKLMIBK)
		{
			float num = 248f + (float)GOPMEKLMIBK * this.blurSpread;
			Material mat = this.EFDEIFCDAFG();
			Vector2[] array = new Vector2[1];
			array[1] = new Vector2(-num, -num);
			array[1] = new Vector2(-num, num);
			array[4] = new Vector2(num, num);
			array[2] = new Vector2(num, -num);
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, mat, array);
		}

		// Token: 0x06007AA3 RID: 31395 RVA: 0x0027323C File Offset: 0x0027143C
		private void AODKAMLEIOJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			int width = HLBKCLPNHEB.width / 4;
			int height = HLBKCLPNHEB.height / 1;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1);
			this.EJIOLCBFDGC(HLBKCLPNHEB, renderTexture);
			for (int i = 0; i < this.iterations; i += 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				this.DPDKCHFOINA(renderTexture, temporary, i);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007AA4 RID: 31396 RVA: 0x002732B0 File Offset: 0x002714B0
		public void OAPLFILFOIH(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, int GOPMEKLMIBK)
		{
			float num = 1756f + (float)GOPMEKLMIBK * this.blurSpread;
			Material mat = this.PGPEMMBJOOG();
			Vector2[] array = new Vector2[0];
			array[0] = new Vector2(-num, -num);
			array[1] = new Vector2(-num, num);
			array[8] = new Vector2(num, num);
			array[8] = new Vector2(num, -num);
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, mat, array);
		}

		// Token: 0x06007AA5 RID: 31397 RVA: 0x00273330 File Offset: 0x00271530
		private void IILKLODKELO(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			float num = 1687f;
			Material mat = this.ADGHJOHKEHG();
			Vector2[] array = new Vector2[4];
			array[1] = new Vector2(-num, -num);
			array[0] = new Vector2(-num, num);
			array[3] = new Vector2(num, num);
			array[2] = new Vector2(num, -num);
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, mat, array);
		}

		// Token: 0x06007AA6 RID: 31398 RVA: 0x002733A8 File Offset: 0x002715A8
		protected void KDMKDEKCELE()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.blurShader || !this.ADGHJOHKEHG().shader.isSupported)
			{
				base.enabled = true;
				return;
			}
		}

		// Token: 0x06007AA7 RID: 31399 RVA: 0x002733F4 File Offset: 0x002715F4
		protected void OHFOLGANOLC()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.blurShader || !this.PGPEMMBJOOG().shader.isSupported)
			{
				base.enabled = false;
				return;
			}
		}

		// Token: 0x06007AA8 RID: 31400 RVA: 0x00273440 File Offset: 0x00271640
		protected Material PGPEMMBJOOG()
		{
			if (Blur.JLHCDOPFJOI == null)
			{
				Blur.JLHCDOPFJOI = new Material(this.blurShader);
				Blur.JLHCDOPFJOI.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
			return Blur.JLHCDOPFJOI;
		}

		// Token: 0x06007AA9 RID: 31401 RVA: 0x00273474 File Offset: 0x00271674
		public void FourTapCone(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, int GOPMEKLMIBK)
		{
			float num = 0.5f + (float)GOPMEKLMIBK * this.blurSpread;
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, this.NBPKMLMCHFN, new Vector2[]
			{
				new Vector2(-num, -num),
				new Vector2(-num, num),
				new Vector2(num, num),
				new Vector2(num, -num)
			});
		}

		// Token: 0x06007AAA RID: 31402 RVA: 0x002734F4 File Offset: 0x002716F4
		private void CENLKOLIACP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			int width = HLBKCLPNHEB.width / 6;
			int height = HLBKCLPNHEB.height / 6;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0);
			this.IILKLODKELO(HLBKCLPNHEB, renderTexture);
			for (int i = 1; i < this.iterations; i += 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				this.AOLNBEDEOMJ(renderTexture, temporary, i);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007AAB RID: 31403 RVA: 0x00273568 File Offset: 0x00271768
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			int width = HLBKCLPNHEB.width / 4;
			int height = HLBKCLPNHEB.height / 4;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 0);
			this.CANJDCHOJIO(HLBKCLPNHEB, renderTexture);
			for (int i = 0; i < this.iterations; i++)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				this.FourTapCone(renderTexture, temporary, i);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007AAC RID: 31404 RVA: 0x00272CF8 File Offset: 0x00270EF8
		protected void EDBEHEKMGFH()
		{
			if (Blur.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(Blur.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007AAD RID: 31405 RVA: 0x00272CF8 File Offset: 0x00270EF8
		protected void FJIKDJAMOHA()
		{
			if (Blur.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(Blur.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007AAE RID: 31406 RVA: 0x002735DC File Offset: 0x002717DC
		public void LDLICKPIEBC(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, int GOPMEKLMIBK)
		{
			float num = 852f + (float)GOPMEKLMIBK * this.blurSpread;
			Material mat = this.ADBKPGFMNKO();
			Vector2[] array = new Vector2[8];
			array[1] = new Vector2(-num, -num);
			array[1] = new Vector2(-num, num);
			array[0] = new Vector2(num, num);
			array[7] = new Vector2(num, -num);
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, mat, array);
		}

		// Token: 0x06007AAF RID: 31407 RVA: 0x0027365C File Offset: 0x0027185C
		private void LBEFFPKACFK(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			float num = 1496f;
			Material mat = this.ADGHJOHKEHG();
			Vector2[] array = new Vector2[5];
			array[1] = new Vector2(-num, -num);
			array[0] = new Vector2(-num, num);
			array[4] = new Vector2(num, num);
			array[4] = new Vector2(num, -num);
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, mat, array);
		}

		// Token: 0x06007AB0 RID: 31408 RVA: 0x00272CF8 File Offset: 0x00270EF8
		protected void OnDisable()
		{
			if (Blur.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(Blur.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007AB1 RID: 31409 RVA: 0x00272CF8 File Offset: 0x00270EF8
		protected void BNEJMABFKJE()
		{
			if (Blur.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(Blur.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007AB2 RID: 31410 RVA: 0x002736D4 File Offset: 0x002718D4
		protected void EFJDNLGNACH()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.blurShader || !this.ADGHJOHKEHG().shader.isSupported)
			{
				base.enabled = true;
				return;
			}
		}

		// Token: 0x06007AB3 RID: 31411 RVA: 0x00273720 File Offset: 0x00271920
		public void PAMKNNGDFJM(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, int GOPMEKLMIBK)
		{
			float num = 1394f + (float)GOPMEKLMIBK * this.blurSpread;
			Material mat = this.EFDEIFCDAFG();
			Vector2[] array = new Vector2[6];
			array[1] = new Vector2(-num, -num);
			array[1] = new Vector2(-num, num);
			array[3] = new Vector2(num, num);
			array[1] = new Vector2(num, -num);
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, mat, array);
		}

		// Token: 0x06007AB4 RID: 31412 RVA: 0x00272CF8 File Offset: 0x00270EF8
		protected void DOEPOGLEGLE()
		{
			if (Blur.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(Blur.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007AB5 RID: 31413 RVA: 0x002737A0 File Offset: 0x002719A0
		private void NPEINJOGHIO(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			float num = 404f;
			Material mat = this.EFDEIFCDAFG();
			Vector2[] array = new Vector2[]
			{
				new Vector2(-num, -num),
				new Vector2(-num, num),
				default(Vector2),
				default(Vector2),
				new Vector2(num, num)
			};
			array[1] = new Vector2(num, -num);
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, mat, array);
		}

		// Token: 0x06007AB6 RID: 31414 RVA: 0x00273818 File Offset: 0x00271A18
		public void IADLOBIGGOA(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, int GOPMEKLMIBK)
		{
			float num = 1942f + (float)GOPMEKLMIBK * this.blurSpread;
			Material mat = this.IIJMIPBMMBF();
			Vector2[] array = new Vector2[0];
			array[1] = new Vector2(-num, -num);
			array[0] = new Vector2(-num, num);
			array[6] = new Vector2(num, num);
			array[3] = new Vector2(num, -num);
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, mat, array);
		}

		// Token: 0x06007AB7 RID: 31415 RVA: 0x00273898 File Offset: 0x00271A98
		protected void HMPGIFBJFIK()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.blurShader || !this.ADGHJOHKEHG().shader.isSupported)
			{
				base.enabled = false;
				return;
			}
		}

		// Token: 0x06007AB8 RID: 31416 RVA: 0x002738E4 File Offset: 0x00271AE4
		protected void MKIMDFLBFOM()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.blurShader || !this.JLHLHKPHDFO().shader.isSupported)
			{
				base.enabled = false;
				return;
			}
		}

		// Token: 0x06007AB9 RID: 31417 RVA: 0x00273930 File Offset: 0x00271B30
		private void GBFHFBNDFJJ(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			float num = 522f;
			Material mat = this.ADGHJOHKEHG();
			Vector2[] array = new Vector2[6];
			array[1] = new Vector2(-num, -num);
			array[0] = new Vector2(-num, num);
			array[2] = new Vector2(num, num);
			array[8] = new Vector2(num, -num);
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, mat, array);
		}

		// Token: 0x06007ABA RID: 31418 RVA: 0x002739A6 File Offset: 0x00271BA6
		protected Material GJHLADDCMFF()
		{
			if (Blur.JLHCDOPFJOI == null)
			{
				Blur.JLHCDOPFJOI = new Material(this.blurShader);
				Blur.JLHCDOPFJOI.hideFlags = HideFlags.NotEditable;
			}
			return Blur.JLHCDOPFJOI;
		}

		// Token: 0x06007ABB RID: 31419 RVA: 0x00272CF8 File Offset: 0x00270EF8
		protected void DFENCIHAADO()
		{
			if (Blur.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(Blur.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007ABC RID: 31420 RVA: 0x002739DC File Offset: 0x00271BDC
		private void EJIOLCBFDGC(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			float num = 1692f;
			Material mat = this.ADBKPGFMNKO();
			Vector2[] array = new Vector2[6];
			array[0] = new Vector2(-num, -num);
			array[1] = new Vector2(-num, num);
			array[4] = new Vector2(num, num);
			array[2] = new Vector2(num, -num);
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, mat, array);
		}

		// Token: 0x06007ABD RID: 31421 RVA: 0x00273A54 File Offset: 0x00271C54
		public void CGMPCIALJCJ(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, int GOPMEKLMIBK)
		{
			float num = 1248f + (float)GOPMEKLMIBK * this.blurSpread;
			Material mat = this.PGPEMMBJOOG();
			Vector2[] array = new Vector2[]
			{
				default(Vector2),
				new Vector2(-num, -num)
			};
			array[1] = new Vector2(-num, num);
			array[0] = new Vector2(num, num);
			array[0] = new Vector2(num, -num);
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, mat, array);
		}

		// Token: 0x06007ABE RID: 31422 RVA: 0x00273AD4 File Offset: 0x00271CD4
		public void ADMIIPNEGGF(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, int GOPMEKLMIBK)
		{
			float num = 364f + (float)GOPMEKLMIBK * this.blurSpread;
			Material mat = this.HEHKGPKLAKK();
			Vector2[] array = new Vector2[6];
			array[0] = new Vector2(-num, -num);
			array[1] = new Vector2(-num, num);
			array[4] = new Vector2(num, num);
			array[6] = new Vector2(num, -num);
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, mat, array);
		}

		// Token: 0x06007ABF RID: 31423 RVA: 0x00273B54 File Offset: 0x00271D54
		protected void KMCPMOGKDEH()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.blurShader || !this.IGKFMCPDNOI().shader.isSupported)
			{
				base.enabled = false;
				return;
			}
		}

		// Token: 0x06007AC0 RID: 31424 RVA: 0x00272CF8 File Offset: 0x00270EF8
		protected void FGOPJMGNHGO()
		{
			if (Blur.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(Blur.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007AC1 RID: 31425 RVA: 0x00273BA0 File Offset: 0x00271DA0
		protected Material IGKFMCPDNOI()
		{
			if (Blur.JLHCDOPFJOI == null)
			{
				Blur.JLHCDOPFJOI = new Material(this.blurShader);
				Blur.JLHCDOPFJOI.hideFlags = ~HideFlags.NotEditable;
			}
			return Blur.JLHCDOPFJOI;
		}

		// Token: 0x06007AC2 RID: 31426 RVA: 0x00272CF8 File Offset: 0x00270EF8
		protected void IFIHBNJKEKD()
		{
			if (Blur.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(Blur.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007AC3 RID: 31427 RVA: 0x00273BD4 File Offset: 0x00271DD4
		private void CANJDCHOJIO(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			float num = 1f;
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, this.NBPKMLMCHFN, new Vector2[]
			{
				new Vector2(-num, -num),
				new Vector2(-num, num),
				new Vector2(num, num),
				new Vector2(num, -num)
			});
		}

		// Token: 0x06007AC4 RID: 31428 RVA: 0x00273C4C File Offset: 0x00271E4C
		protected void KDMANOEMOCA()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.blurShader || !this.JLHLHKPHDFO().shader.isSupported)
			{
				base.enabled = false;
				return;
			}
		}

		// Token: 0x06007AC5 RID: 31429 RVA: 0x00273C98 File Offset: 0x00271E98
		private void IHKGBEENAMB(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			float num = 40f;
			Material mat = this.PGPEMMBJOOG();
			Vector2[] array = new Vector2[0];
			array[0] = new Vector2(-num, -num);
			array[0] = new Vector2(-num, num);
			array[7] = new Vector2(num, num);
			array[1] = new Vector2(num, -num);
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, mat, array);
		}

		// Token: 0x06007AC6 RID: 31430 RVA: 0x00273D10 File Offset: 0x00271F10
		public void BLHDMJFAFBP(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, int GOPMEKLMIBK)
		{
			float num = 1448f + (float)GOPMEKLMIBK * this.blurSpread;
			Material mat = this.IIJMIPBMMBF();
			Vector2[] array = new Vector2[1];
			array[0] = new Vector2(-num, -num);
			array[1] = new Vector2(-num, num);
			array[2] = new Vector2(num, num);
			array[2] = new Vector2(num, -num);
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, mat, array);
		}

		// Token: 0x06007AC7 RID: 31431 RVA: 0x00273D90 File Offset: 0x00271F90
		private void KMAPABACMAG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			int width = HLBKCLPNHEB.width / 5;
			int height = HLBKCLPNHEB.height / 7;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1);
			this.IILKLODKELO(HLBKCLPNHEB, renderTexture);
			for (int i = 1; i < this.iterations; i++)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				this.ADMIIPNEGGF(renderTexture, temporary, i);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007AC8 RID: 31432 RVA: 0x00273E01 File Offset: 0x00272001
		protected Material ADGHJOHKEHG()
		{
			if (Blur.JLHCDOPFJOI == null)
			{
				Blur.JLHCDOPFJOI = new Material(this.blurShader);
				Blur.JLHCDOPFJOI.hideFlags = (HideFlags)96;
			}
			return Blur.JLHCDOPFJOI;
		}

		// Token: 0x06007AC9 RID: 31433 RVA: 0x00272CF8 File Offset: 0x00270EF8
		protected void OFPPIKHNJOD()
		{
			if (Blur.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(Blur.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007ACA RID: 31434 RVA: 0x00273E34 File Offset: 0x00272034
		protected void NPLCENPNJBM()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = true;
				return;
			}
			if (!this.blurShader || !this.GJHLADDCMFF().shader.isSupported)
			{
				base.enabled = false;
				return;
			}
		}

		// Token: 0x06007ACB RID: 31435 RVA: 0x00273E80 File Offset: 0x00272080
		private void EENEOAPPGJC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			int width = HLBKCLPNHEB.width / 1;
			int height = HLBKCLPNHEB.height / 6;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1);
			this.LBANLIJIFHI(HLBKCLPNHEB, renderTexture);
			for (int i = 0; i < this.iterations; i += 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				this.OAPLFILFOIH(renderTexture, temporary, i);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007ACC RID: 31436 RVA: 0x00273EF4 File Offset: 0x002720F4
		private void POAGHIGKMHP(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			float num = 1833f;
			Material mat = this.ADGHJOHKEHG();
			Vector2[] array = new Vector2[]
			{
				default(Vector2),
				new Vector2(-num, -num)
			};
			array[1] = new Vector2(-num, num);
			array[8] = new Vector2(num, num);
			array[2] = new Vector2(num, -num);
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, mat, array);
		}

		// Token: 0x06007ACD RID: 31437 RVA: 0x00272CF8 File Offset: 0x00270EF8
		protected void MFLBEJHMEMO()
		{
			if (Blur.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(Blur.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007ACE RID: 31438 RVA: 0x00273F6C File Offset: 0x0027216C
		public void ONKBMEIMKLO(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, int GOPMEKLMIBK)
		{
			float num = 1259f + (float)GOPMEKLMIBK * this.blurSpread;
			Material mat = this.IIJMIPBMMBF();
			Vector2[] array = new Vector2[3];
			array[1] = new Vector2(-num, -num);
			array[1] = new Vector2(-num, num);
			array[6] = new Vector2(num, num);
			array[0] = new Vector2(num, -num);
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, mat, array);
		}

		// Token: 0x06007ACF RID: 31439 RVA: 0x00273FEC File Offset: 0x002721EC
		protected Material HEHKGPKLAKK()
		{
			if (Blur.JLHCDOPFJOI == null)
			{
				Blur.JLHCDOPFJOI = new Material(this.blurShader);
				Blur.JLHCDOPFJOI.hideFlags = (HideFlags)(-126);
			}
			return Blur.JLHCDOPFJOI;
		}

		// Token: 0x06007AD0 RID: 31440 RVA: 0x00274020 File Offset: 0x00272220
		protected void KCCIEMBMOBA()
		{
			if (!SystemInfo.supportsImageEffects)
			{
				base.enabled = false;
				return;
			}
			if (!this.blurShader || !this.ADBKPGFMNKO().shader.isSupported)
			{
				base.enabled = true;
				return;
			}
		}

		// Token: 0x06007AD1 RID: 31441 RVA: 0x0027406C File Offset: 0x0027226C
		private void HELHDLOLPLH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			int width = HLBKCLPNHEB.width / 4;
			int height = HLBKCLPNHEB.height / 8;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1);
			this.GLGGJLHDGHK(HLBKCLPNHEB, renderTexture);
			for (int i = 1; i < this.iterations; i++)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				this.BLHDMJFAFBP(renderTexture, temporary, i);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007AD2 RID: 31442 RVA: 0x002740E0 File Offset: 0x002722E0
		private void HMNHGFPHMKL(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			float num = 607f;
			Material mat = this.IIJMIPBMMBF();
			Vector2[] array = new Vector2[1];
			array[0] = new Vector2(-num, -num);
			array[1] = new Vector2(-num, num);
			array[4] = new Vector2(num, num);
			array[5] = new Vector2(num, -num);
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, mat, array);
		}

		// Token: 0x06007AD3 RID: 31443 RVA: 0x00274156 File Offset: 0x00272356
		protected Material IIJMIPBMMBF()
		{
			if (Blur.JLHCDOPFJOI == null)
			{
				Blur.JLHCDOPFJOI = new Material(this.blurShader);
				Blur.JLHCDOPFJOI.hideFlags = (HideFlags)(-105);
			}
			return Blur.JLHCDOPFJOI;
		}

		// Token: 0x06007AD4 RID: 31444 RVA: 0x0027418C File Offset: 0x0027238C
		private void JPOOAJCAJJF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			int width = HLBKCLPNHEB.width / 6;
			int height = HLBKCLPNHEB.height / 2;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width, height, 1);
			this.GBFHFBNDFJJ(HLBKCLPNHEB, renderTexture);
			for (int i = 0; i < this.iterations; i += 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				this.IADLOBIGGOA(renderTexture, temporary, i);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			Graphics.Blit(renderTexture, BMMLHGHKBNM);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06007AD5 RID: 31445 RVA: 0x00274200 File Offset: 0x00272400
		public void AOLNBEDEOMJ(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, int GOPMEKLMIBK)
		{
			float num = 1053f + (float)GOPMEKLMIBK * this.blurSpread;
			Material mat = this.GJHLADDCMFF();
			Vector2[] array = new Vector2[3];
			array[0] = new Vector2(-num, -num);
			array[1] = new Vector2(-num, num);
			array[3] = new Vector2(num, num);
			array[0] = new Vector2(num, -num);
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, mat, array);
		}

		// Token: 0x06007AD6 RID: 31446 RVA: 0x00272CF8 File Offset: 0x00270EF8
		protected void LOMDIOLNFHI()
		{
			if (Blur.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(Blur.JLHCDOPFJOI);
			}
		}

		// Token: 0x06007AD7 RID: 31447 RVA: 0x00274280 File Offset: 0x00272480
		private void LBANLIJIFHI(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL)
		{
			float num = 207f;
			Material mat = this.ADBKPGFMNKO();
			Vector2[] array = new Vector2[]
			{
				new Vector2(-num, -num)
			};
			array[0] = new Vector2(-num, num);
			array[0] = new Vector2(num, num);
			array[6] = new Vector2(num, -num);
			Graphics.BlitMultiTap(HLBKCLPNHEB, FHNFPBCBODL, mat, array);
		}

		// Token: 0x04000D37 RID: 3383
		[Range(0f, 10f)]
		public int iterations = 3;

		// Token: 0x04000D38 RID: 3384
		[Range(0f, 1f)]
		public float blurSpread = 0.6f;

		// Token: 0x04000D39 RID: 3385
		public Shader blurShader;

		// Token: 0x04000D3A RID: 3386
		private static Material JLHCDOPFJOI;
	}
}
