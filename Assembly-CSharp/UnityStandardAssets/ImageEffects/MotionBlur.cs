using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001E9 RID: 489
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Blur/Motion Blur (Color Accumulation)")]
	public class MotionBlur : ImageEffectBase
	{
		// Token: 0x06007E28 RID: 32296 RVA: 0x0029B21F File Offset: 0x0029941F
		protected override void FMNPFCHBLJF()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.DOFDGBGEDFI();
		}

		// Token: 0x06007E29 RID: 32297 RVA: 0x0029B239 File Offset: 0x00299439
		protected virtual void BNEJMABFKJE()
		{
			base.JNALDALAJLG();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E2A RID: 32298 RVA: 0x0029B24C File Offset: 0x0029944C
		private void NEALKDCJCJH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.CABFICNMMBK.hideFlags = (HideFlags)(-126);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 6, HLBKCLPNHEB.height / 0, 0);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 625f, 1082f);
			base.IIBLJCKLGFG().SetTexture("_BlurPass", this.CABFICNMMBK);
			base.OLHDPICFBOF().SetFloat("[PlayerController] ", 1086f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.HHIFMIPPMPF());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E2B RID: 32299 RVA: 0x0029B394 File Offset: 0x00299594
		private void EGKNJMMAOAO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.CABFICNMMBK.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 0, HLBKCLPNHEB.height / 0, 1);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 279f, 436f);
			base.FLGPDBBKAIP().SetTexture("RemoveEnvironmentObject", this.CABFICNMMBK);
			base.IGKFMCPDNOI().SetFloat("_Value", 239f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.LMLENGFLEBD());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E2C RID: 32300 RVA: 0x0029B4DB File Offset: 0x002996DB
		protected override void JHANGPCOCIG()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.EGEPLFGKGLI();
		}

		// Token: 0x06007E2D RID: 32301 RVA: 0x0029B4F8 File Offset: 0x002996F8
		private void DPMMIPDKJND(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.CABFICNMMBK.hideFlags = (HideFlags)85;
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 0, HLBKCLPNHEB.height / 6, 1);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 581f, 1336f);
			base.DNLMFEGJJDD().SetTexture("_Noise", this.CABFICNMMBK);
			base.NJDIODJNGGA().SetFloat("_ColorG", 457f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.IGIAPKPKGPK());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E2E RID: 32302 RVA: 0x0029B63F File Offset: 0x0029983F
		protected virtual void JILOMOBDPIA()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.IMCKJCHKMKB();
		}

		// Token: 0x06007E2F RID: 32303 RVA: 0x0029B659 File Offset: 0x00299859
		protected virtual void NAOLAJPDGIC()
		{
			base.OEIBFOHPOPD();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E30 RID: 32304 RVA: 0x0029B66C File Offset: 0x0029986C
		private void HELHDLOLPLH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.CABFICNMMBK.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 2, HLBKCLPNHEB.height / 0, 0);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 380f, 545f);
			base.EMDFHOKEGNG().SetTexture("workshop.", this.CABFICNMMBK);
			base.LPPEPKGFOEM().SetFloat("y", 518f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.JFDGLLEOPGB());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E31 RID: 32305 RVA: 0x0029B63F File Offset: 0x0029983F
		protected override void KCCIEMBMOBA()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.IMCKJCHKMKB();
		}

		// Token: 0x06007E32 RID: 32306 RVA: 0x0029B7B3 File Offset: 0x002999B3
		protected virtual void MKOMIDCPCDC()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.JHANGPCOCIG();
		}

		// Token: 0x06007E33 RID: 32307 RVA: 0x0029B7CD File Offset: 0x002999CD
		protected override void IMGGCJICLHK()
		{
			base.IMGGCJICLHK();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E34 RID: 32308 RVA: 0x0029B7E0 File Offset: 0x002999E0
		private void PJIFJFENPJO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.CABFICNMMBK.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 8, HLBKCLPNHEB.height / 8, 0);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 339f, 1049f);
			base.EJDPNJAEAKJ().SetTexture("CameraFilterPack/3D_Inverse", this.CABFICNMMBK);
			base.EPCGJFCCAFH().SetFloat("_SunPosition", 64f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.ABHDNGIHBKE());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E35 RID: 32309 RVA: 0x0029B927 File Offset: 0x00299B27
		protected virtual void IDJKNBDKHBD()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.DAHFFNNIGML();
		}

		// Token: 0x06007E36 RID: 32310 RVA: 0x0029B941 File Offset: 0x00299B41
		protected virtual void DNNFHBOOPIN()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.ADPLHDFJFID();
		}

		// Token: 0x06007E37 RID: 32311 RVA: 0x0029B95C File Offset: 0x00299B5C
		private void KPOCGNOKNOB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.CABFICNMMBK.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 7, HLBKCLPNHEB.height / 0, 0);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 278f, 950f);
			base.OIBHFCLJKDB().SetTexture("_Value3", this.CABFICNMMBK);
			base.NLFJGMBCICG().SetFloat("closed", 533f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.IGIAPKPKGPK());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E38 RID: 32312 RVA: 0x0029BAA3 File Offset: 0x00299CA3
		protected override void KHIGHFJKPFG()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.JOHOFNKJDEB();
		}

		// Token: 0x06007E39 RID: 32313 RVA: 0x0029BABD File Offset: 0x00299CBD
		protected virtual void NKFDNIAKGEO()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.COOHIILCOCO();
		}

		// Token: 0x06007E3A RID: 32314 RVA: 0x0029BAD7 File Offset: 0x00299CD7
		protected virtual void MGMAOBPPOBJ()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.ECBILENEOOL();
		}

		// Token: 0x06007E3B RID: 32315 RVA: 0x0029BAF1 File Offset: 0x00299CF1
		protected virtual void PAKPHKPDKGE()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.NBGIMIDICKE();
		}

		// Token: 0x06007E3C RID: 32316 RVA: 0x0029BAF1 File Offset: 0x00299CF1
		protected override void MDNHCLKNCLE()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.NBGIMIDICKE();
		}

		// Token: 0x06007E3D RID: 32317 RVA: 0x0029BB0C File Offset: 0x00299D0C
		private void LBHPMIDFKPP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.CABFICNMMBK.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 2, HLBKCLPNHEB.height / 8, 1);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 112f, 1465f);
			base.EJDPNJAEAKJ().SetTexture("Tab1Content", this.CABFICNMMBK);
			base.LEIAFCPJMDP().SetFloat("[PlayerController] ", 513f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.IGIAPKPKGPK());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E3E RID: 32318 RVA: 0x0029BC53 File Offset: 0x00299E53
		protected virtual void IGPCNCJIEOJ()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.FIKFJDFELIP();
		}

		// Token: 0x06007E3F RID: 32319 RVA: 0x0029BC6D File Offset: 0x00299E6D
		protected virtual void FEKECCBFGMI()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.LGHCJCFHEMF();
		}

		// Token: 0x06007E40 RID: 32320 RVA: 0x0029BC88 File Offset: 0x00299E88
		private void KKHCDAPLABD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.CABFICNMMBK.hideFlags = (HideFlags)119;
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 3, HLBKCLPNHEB.height / 3, 1);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 882f, 1696f);
			base.DONENAMLFLF().SetTexture("Cancel", this.CABFICNMMBK);
			base.EJDPNJAEAKJ().SetFloat("</color>", 1834f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.CBCNOEIALHB());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E41 RID: 32321 RVA: 0x0029BDCF File Offset: 0x00299FCF
		protected virtual void OKLAJINHPAN()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.NCNPAKFAFOE();
		}

		// Token: 0x06007E42 RID: 32322 RVA: 0x0029BDE9 File Offset: 0x00299FE9
		protected virtual void KKEOHFGKCIK()
		{
			base.JMAIIENCEKE();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E43 RID: 32323 RVA: 0x0029BDFC File Offset: 0x00299FFC
		protected virtual void DOEPOGLEGLE()
		{
			base.FJIKDJAMOHA();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E44 RID: 32324 RVA: 0x0029BE0F File Offset: 0x0029A00F
		protected virtual void PKLOBJHKFEO()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.NPLCENPNJBM();
		}

		// Token: 0x06007E45 RID: 32325 RVA: 0x0029BE29 File Offset: 0x0029A029
		protected override void CHOPDIGHJNH()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.MNBPNHNAEBK();
		}

		// Token: 0x06007E46 RID: 32326 RVA: 0x0029BE43 File Offset: 0x0029A043
		protected virtual void IBLGHLNNAHN()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.ALJEJJCIMJN();
		}

		// Token: 0x06007E47 RID: 32327 RVA: 0x0029BE60 File Offset: 0x0029A060
		private void NFJFHPCMEGD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.CABFICNMMBK.hideFlags = (HideFlags)104;
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 6, HLBKCLPNHEB.height / 7, 0);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 942f, 1439f);
			base.AELJLBOJAIL().SetTexture("BlockCount", this.CABFICNMMBK);
			base.HEINDEMCGIK().SetFloat("challenges", 662f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.HKHBBBFLGJH());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E48 RID: 32328 RVA: 0x0029BFA7 File Offset: 0x0029A1A7
		protected override void COOHIILCOCO()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.MMOKKAPFGAK();
		}

		// Token: 0x06007E49 RID: 32329 RVA: 0x0029BFC1 File Offset: 0x0029A1C1
		protected virtual void DLBODOFAJGM()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.EGEPLFGKGLI();
		}

		// Token: 0x06007E4A RID: 32330 RVA: 0x0029BFDB File Offset: 0x0029A1DB
		protected virtual void JFJLGJEPEAA()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.DKGBFNCOAEO();
		}

		// Token: 0x06007E4B RID: 32331 RVA: 0x0029BFF5 File Offset: 0x0029A1F5
		protected virtual void IFIHBNJKEKD()
		{
			base.FDPOFMCFBMF();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E4C RID: 32332 RVA: 0x0029BE43 File Offset: 0x0029A043
		protected override void MMOKKAPFGAK()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.ALJEJJCIMJN();
		}

		// Token: 0x06007E4D RID: 32333 RVA: 0x0029C008 File Offset: 0x0029A208
		protected virtual void FNCDAPDOBBI()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.FIKFJDFELIP();
		}

		// Token: 0x06007E4E RID: 32334 RVA: 0x0029BFC1 File Offset: 0x0029A1C1
		protected override void DKGBFNCOAEO()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.EGEPLFGKGLI();
		}

		// Token: 0x06007E4F RID: 32335 RVA: 0x0029C024 File Offset: 0x0029A224
		private void KBGCKEDIGAH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.CABFICNMMBK.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 7, HLBKCLPNHEB.height / 4, 1);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 1332f, 992f);
			base.MICHFGAOPKM().SetTexture("_FixDistance", this.CABFICNMMBK);
			base.CFCPHFMKHII().SetFloat("AddEnvironmentSprite", 1638f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.HKGAONMOBMH());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E50 RID: 32336 RVA: 0x0029C16B File Offset: 0x0029A36B
		protected override void HLHJBJGEEEA()
		{
			base.IHHNCCOGLPN();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E51 RID: 32337 RVA: 0x0029C180 File Offset: 0x0029A380
		private void NCDPFPKBCCM(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.CABFICNMMBK.hideFlags = (HideFlags)(-111);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 2, HLBKCLPNHEB.height / 3, 1);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 1725f, 1265f);
			base.OOMFJGPAOKL().SetTexture("_Offsets", this.CABFICNMMBK);
			base.CBCNOEIALHB().SetFloat("#join", 395f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.IGKFMCPDNOI());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E52 RID: 32338 RVA: 0x0029BDE9 File Offset: 0x00299FE9
		protected virtual void EDBEHEKMGFH()
		{
			base.JMAIIENCEKE();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E53 RID: 32339 RVA: 0x0029C2C7 File Offset: 0x0029A4C7
		protected virtual void JKBMKPDGCHG()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.KLILJHJNICK();
		}

		// Token: 0x06007E54 RID: 32340 RVA: 0x0029C2E1 File Offset: 0x0029A4E1
		protected override void IEFMONDKKJN()
		{
			base.ALJEADNKJPO();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E55 RID: 32341 RVA: 0x0029BFC1 File Offset: 0x0029A1C1
		protected virtual void NEFHGMNAPEP()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.EGEPLFGKGLI();
		}

		// Token: 0x06007E56 RID: 32342 RVA: 0x0029C2F4 File Offset: 0x0029A4F4
		private void BABCJIIKIAD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.CABFICNMMBK.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 8, HLBKCLPNHEB.height / 0, 1);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 67f, 162f);
			base.JFDGLLEOPGB().SetTexture("Set Satellite Radius", this.CABFICNMMBK);
			base.MCDGIILBNIF().SetFloat(" is not observed by this object's photonView! OnPhotonSerializeView() in this class won't be used.", 46f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.IIJMIPBMMBF());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E57 RID: 32343 RVA: 0x0029C43B File Offset: 0x0029A63B
		protected virtual void PKBENONAOOL()
		{
			base.GNMGIHFKJIJ();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E58 RID: 32344 RVA: 0x0029C44E File Offset: 0x0029A64E
		protected virtual void EFJDNLGNACH()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.FMNPFCHBLJF();
		}

		// Token: 0x06007E59 RID: 32345 RVA: 0x0029C468 File Offset: 0x0029A668
		protected virtual void LFAFJKJAEEL()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.FANADGBGCPI();
		}

		// Token: 0x06007E5A RID: 32346 RVA: 0x0029C484 File Offset: 0x0029A684
		private void GOIMKCCICFK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.CABFICNMMBK.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 0, HLBKCLPNHEB.height / 3, 1);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 1377f, 1741f);
			base.OIBHFCLJKDB().SetTexture("/files/mods_terms.pdf", this.CABFICNMMBK);
			base.OIBHFCLJKDB().SetFloat("_ScreenResolution", 1687f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.AELJLBOJAIL());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E5B RID: 32347 RVA: 0x0029C5CB File Offset: 0x0029A7CB
		protected override void MGFFNGEGFDC()
		{
			base.MGFFNGEGFDC();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E5C RID: 32348 RVA: 0x0029C5E0 File Offset: 0x0029A7E0
		private void CGIMPFJPEKD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.CABFICNMMBK.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 3, HLBKCLPNHEB.height / 2, 0);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 1739f, 589f);
			base.HKHBBBFLGJH().SetTexture("_Radius", this.CABFICNMMBK);
			base.GCDFNHMJMIP().SetFloat("PlayButton", 804f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.FGENHBKMPDA());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E5D RID: 32349 RVA: 0x0029C727 File Offset: 0x0029A927
		protected virtual void DPLLKHHLDBB()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.JKFDDNMPOJH();
		}

		// Token: 0x06007E5E RID: 32350 RVA: 0x0029C741 File Offset: 0x0029A941
		protected virtual void IHLMNAGPKDA()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.HLIAEEMGBHN();
		}

		// Token: 0x06007E5F RID: 32351 RVA: 0x0029C75C File Offset: 0x0029A95C
		private void JCCIKBBEMEB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.CABFICNMMBK.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 1, HLBKCLPNHEB.height / 7, 1);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 1825f, 1500f);
			base.JFDGLLEOPGB().SetTexture("CameraFilterPack/Distortion_Flag", this.CABFICNMMBK);
			base.NFMGLIKNOOC().SetFloat("Can't do manual instantiation without PhotonView component.", 1453f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.GJHPODJOBHL());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E60 RID: 32352 RVA: 0x0029C8A3 File Offset: 0x0029AAA3
		protected virtual void FBPHNEJBDJN()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.DAHFFNNIGML();
		}

		// Token: 0x06007E61 RID: 32353 RVA: 0x0029C8C0 File Offset: 0x0029AAC0
		private void CLLJDEAJDNL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.CABFICNMMBK.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 6, HLBKCLPNHEB.height / 8, 1);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 1020f, 359f);
			base.ABHDNGIHBKE().SetTexture("22x3", this.CABFICNMMBK);
			base.NLFJGMBCICG().SetFloat("_Distortion", 782f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.DONENAMLFLF());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E62 RID: 32354 RVA: 0x0029CA07 File Offset: 0x0029AC07
		protected override void MMPHNFPPEHO()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.ADPLHDFJFID();
		}

		// Token: 0x06007E64 RID: 32356 RVA: 0x0029CA34 File Offset: 0x0029AC34
		protected virtual void JHJFBCFBKLD()
		{
			base.OFPPIKHNJOD();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E65 RID: 32357 RVA: 0x0029CA47 File Offset: 0x0029AC47
		protected virtual void GNPDGBNDCPL()
		{
			base.ALMGMOOHLMA();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E66 RID: 32358 RVA: 0x0029CA5A File Offset: 0x0029AC5A
		protected virtual void LINKAMEPKGM()
		{
			base.FGOPJMGNHGO();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E67 RID: 32359 RVA: 0x0029CA6D File Offset: 0x0029AC6D
		protected virtual void CCLNNLCOPBL()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.NPLCENPNJBM();
		}

		// Token: 0x06007E68 RID: 32360 RVA: 0x0029CA87 File Offset: 0x0029AC87
		protected virtual void KNBJBNDGCIJ()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.Start();
		}

		// Token: 0x06007E69 RID: 32361 RVA: 0x0029CAA1 File Offset: 0x0029ACA1
		protected virtual void DIPDEHOOBPG()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.BEBNOKFLJPH();
		}

		// Token: 0x06007E6A RID: 32362 RVA: 0x0029CABC File Offset: 0x0029ACBC
		private void KEFKNAOGCHO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.CABFICNMMBK.hideFlags = (HideFlags)(-114);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 2, HLBKCLPNHEB.height / 2, 1);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 1842f, 1444f);
			base.FGENHBKMPDA().SetTexture("CameraFilterPack/FX_DigitalMatrixDistortion", this.CABFICNMMBK);
			base.MICHFGAOPKM().SetFloat("#timeuntilchallenge: ", 446f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.LPPEPKGFOEM());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E6B RID: 32363 RVA: 0x0029CC04 File Offset: 0x0029AE04
		private void NBHMOIGDDAD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.CABFICNMMBK.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 0, HLBKCLPNHEB.height / 3, 1);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 304f, 1306f);
			base.LMLENGFLEBD().SetTexture(": ", this.CABFICNMMBK);
			base.OIBHFCLJKDB().SetFloat("#exitmapeditor", 222f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.GJHLADDCMFF());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E6C RID: 32364 RVA: 0x0029CD4C File Offset: 0x0029AF4C
		private void HNADGLKNADJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.CABFICNMMBK.hideFlags = (HideFlags)(-75);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 1, HLBKCLPNHEB.height / 6, 1);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 1190f, 1775f);
			base.LMLENGFLEBD().SetTexture(". Should be just one?", this.CABFICNMMBK);
			base.BAGICADFBAB().SetFloat("Scene", 1853f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.GJHPODJOBHL());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E6D RID: 32365 RVA: 0x0029CE93 File Offset: 0x0029B093
		protected override void DHNGNHGDPLM()
		{
			base.LECCHIAFGGE();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E6E RID: 32366 RVA: 0x0029CEA6 File Offset: 0x0029B0A6
		protected virtual void GJLKJAOBPJD()
		{
			base.FAMLCFNDGNI();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E6F RID: 32367 RVA: 0x0029C5CB File Offset: 0x0029A7CB
		protected override void AMHEJBMLFNM()
		{
			base.MGFFNGEGFDC();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E70 RID: 32368 RVA: 0x0029CEB9 File Offset: 0x0029B0B9
		protected virtual void PDHKMDBNGGN()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.HLIAEEMGBHN();
		}

		// Token: 0x06007E71 RID: 32369 RVA: 0x0029C16B File Offset: 0x0029A36B
		protected override void DKPBBJINKMG()
		{
			base.IHHNCCOGLPN();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E72 RID: 32370 RVA: 0x0029BDCF File Offset: 0x00299FCF
		protected virtual void OHFOLGANOLC()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.NCNPAKFAFOE();
		}

		// Token: 0x06007E73 RID: 32371 RVA: 0x0029CED3 File Offset: 0x0029B0D3
		protected override void DBEMDAJDDDA()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.FLKEJJEGCFA();
		}

		// Token: 0x06007E74 RID: 32372 RVA: 0x0029CEED File Offset: 0x0029B0ED
		protected override void FAMLCFNDGNI()
		{
			base.LADCJEIALMH();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E75 RID: 32373 RVA: 0x0029CF00 File Offset: 0x0029B100
		protected virtual void BOPKKCAFODF()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.ALJEJJCIMJN();
		}

		// Token: 0x06007E76 RID: 32374 RVA: 0x0029CF1A File Offset: 0x0029B11A
		protected virtual void ODBNMPGBCGO()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.FDNONDCGGCG();
		}

		// Token: 0x06007E77 RID: 32375 RVA: 0x0029BDE9 File Offset: 0x00299FE9
		protected virtual void ICDBMJKMIKC()
		{
			base.JMAIIENCEKE();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E78 RID: 32376 RVA: 0x0029CA6D File Offset: 0x0029AC6D
		protected virtual void FHPFJBFCOOF()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.NPLCENPNJBM();
		}

		// Token: 0x06007E79 RID: 32377 RVA: 0x0029CF34 File Offset: 0x0029B134
		protected virtual void NJHJHBOJKIC()
		{
			base.FPHLDMMAOEF();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E7A RID: 32378 RVA: 0x0029CF48 File Offset: 0x0029B148
		private void JBMEPDENLOM(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.CABFICNMMBK.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 3, HLBKCLPNHEB.height / 8, 1);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 1639f, 1622f);
			base.NFMGLIKNOOC().SetTexture("CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", this.CABFICNMMBK);
			base.OLHDPICFBOF().SetFloat("Mouse Wheel Down", 1438f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.NLFJGMBCICG());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E7B RID: 32379 RVA: 0x0029D08F File Offset: 0x0029B28F
		protected virtual void HDMDKOKOOJC()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.KHIGHFJKPFG();
		}

		// Token: 0x06007E7C RID: 32380 RVA: 0x0029D0AC File Offset: 0x0029B2AC
		private void PACLEGDKKPI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.CABFICNMMBK.hideFlags = (HideFlags)(-104);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 7, HLBKCLPNHEB.height / 3, 1);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 1080f, 1748f);
			base.HHIFMIPPMPF().SetTexture("_Blue_B", this.CABFICNMMBK);
			base.FLGPDBBKAIP().SetFloat("_MainTex", 1018f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.ABHDNGIHBKE());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E7D RID: 32381 RVA: 0x0029D1F3 File Offset: 0x0029B3F3
		protected override void EGEPLFGKGLI()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.KCCIEMBMOBA();
		}

		// Token: 0x06007E7E RID: 32382 RVA: 0x0029D210 File Offset: 0x0029B410
		private void HHJBIALGCME(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.CABFICNMMBK.hideFlags = (HideFlags)(-120);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 8, HLBKCLPNHEB.height / 7, 1);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 981f, 206f);
			base.NBPKMLMCHFN.SetTexture("GroupNameText", this.CABFICNMMBK);
			base.EPCGJFCCAFH().SetFloat("<color=#", 424f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.AELJLBOJAIL());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E7F RID: 32383 RVA: 0x0029D357 File Offset: 0x0029B557
		protected override void ECBILENEOOL()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.BGDPIHMAACO();
		}

		// Token: 0x06007E80 RID: 32384 RVA: 0x0029D371 File Offset: 0x0029B571
		protected virtual void MEBPBNLBECA()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.ECBILENEOOL();
		}

		// Token: 0x06007E81 RID: 32385 RVA: 0x0029D38C File Offset: 0x0029B58C
		private void KCNIHHNMFFF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.CABFICNMMBK.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 6, HLBKCLPNHEB.height / 0, 0);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 695f, 1990f);
			base.PGPEMMBJOOG().SetTexture("BitsData", this.CABFICNMMBK);
			base.NFMGLIKNOOC().SetFloat("OPEN FILE", 1788f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.HKGAONMOBMH());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E82 RID: 32386 RVA: 0x0029D4D3 File Offset: 0x0029B6D3
		protected override void BFEILOMHNPC()
		{
			base.EKCDEFDELMP();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E83 RID: 32387 RVA: 0x0029D4E6 File Offset: 0x0029B6E6
		protected virtual void EFECEKPFOEM()
		{
			base.AOKOLPEGHDD();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E84 RID: 32388 RVA: 0x0029D4FC File Offset: 0x0029B6FC
		private void JKAKHLNPNNP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.CABFICNMMBK.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 6, HLBKCLPNHEB.height / 2, 0);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 1855f, 613f);
			base.GCDFNHMJMIP().SetTexture("ResetButton", this.CABFICNMMBK);
			base.MCDGIILBNIF().SetFloat("Items/", 729f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.HEINDEMCGIK());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E85 RID: 32389 RVA: 0x0029D644 File Offset: 0x0029B844
		private void GHOAOEKHEKI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.CABFICNMMBK.hideFlags = (HideFlags)94;
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 6, HLBKCLPNHEB.height / 8, 0);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 994f, 436f);
			base.LEIAFCPJMDP().SetTexture("_Value4", this.CABFICNMMBK);
			base.IGIAPKPKGPK().SetFloat("ReconnectToMaster() with AuthValues == null is not correct!", 413f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.JFDGLLEOPGB());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E86 RID: 32390 RVA: 0x0029D4E6 File Offset: 0x0029B6E6
		protected override void MKFLBEGJJDC()
		{
			base.AOKOLPEGHDD();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E87 RID: 32391 RVA: 0x0029D78C File Offset: 0x0029B98C
		private void AIJJOIOAKGD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.CABFICNMMBK.hideFlags = (HideFlags)96;
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 4, HLBKCLPNHEB.height / 2, 1);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 1726f, 1897f);
			base.GJHLADDCMFF().SetTexture("player.currentrank", this.CABFICNMMBK);
			base.HHIFMIPPMPF().SetFloat("A", 1032f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.NLFJGMBCICG());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E88 RID: 32392 RVA: 0x0029D8D3 File Offset: 0x0029BAD3
		protected virtual void CFFCLAHMBAA()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.FEHCNJLLJMP();
		}

		// Token: 0x06007E89 RID: 32393 RVA: 0x0029D8ED File Offset: 0x0029BAED
		protected override void DBLILJGKGHJ()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.NCNPAKFAFOE();
		}

		// Token: 0x06007E8A RID: 32394 RVA: 0x0029D907 File Offset: 0x0029BB07
		protected virtual void DPFOEBCADNP()
		{
			base.ODGMCJILIHF();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E8B RID: 32395 RVA: 0x0029D91A File Offset: 0x0029BB1A
		protected virtual void NNCCPEBIAKH()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.NNFMIAFHMJM();
		}

		// Token: 0x06007E8C RID: 32396 RVA: 0x0029D934 File Offset: 0x0029BB34
		protected virtual void EDPDMBFLHLP()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.FLKEJJEGCFA();
		}

		// Token: 0x06007E8D RID: 32397 RVA: 0x0029C8A3 File Offset: 0x0029AAA3
		protected virtual void CCFEDENFNEF()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.DAHFFNNIGML();
		}

		// Token: 0x06007E8E RID: 32398 RVA: 0x0029D94E File Offset: 0x0029BB4E
		protected virtual void DOKAKEMDALN()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.NNFMIAFHMJM();
		}

		// Token: 0x06007E8F RID: 32399 RVA: 0x0029BDE9 File Offset: 0x00299FE9
		protected virtual void OFIMMFHFHDD()
		{
			base.JMAIIENCEKE();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E90 RID: 32400 RVA: 0x0029B7CD File Offset: 0x002999CD
		protected override void IHHNCCOGLPN()
		{
			base.IMGGCJICLHK();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E91 RID: 32401 RVA: 0x0029D968 File Offset: 0x0029BB68
		private void KDOCJGGAOII(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.CABFICNMMBK.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 3, HLBKCLPNHEB.height / 4, 1);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 1793f, 1919f);
			base.AELJLBOJAIL().SetTexture("_VelocityScale", this.CABFICNMMBK);
			base.JFDGLLEOPGB().SetFloat("TimeBGSlider", 292f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.GJHPODJOBHL());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E92 RID: 32402 RVA: 0x0029DAAF File Offset: 0x0029BCAF
		protected virtual void PLIKADJCEPO()
		{
			base.EKCKJLFFAID();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E93 RID: 32403 RVA: 0x0029DAC4 File Offset: 0x0029BCC4
		private void NKKLGKPFPIK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.CABFICNMMBK.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 4, HLBKCLPNHEB.height / 8, 1);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 1858f, 1489f);
			base.IIBLJCKLGFG().SetTexture("finished", this.CABFICNMMBK);
			base.BAGICADFBAB().SetFloat("CameraFilterPack/Gradients_Tech", 1985f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.CFCPHFMKHII());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E94 RID: 32404 RVA: 0x0029DC0B File Offset: 0x0029BE0B
		protected virtual void HJPCJGOEKMF()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.DBEMDAJDDDA();
		}

		// Token: 0x06007E95 RID: 32405 RVA: 0x0029CA34 File Offset: 0x0029AC34
		protected virtual void DHENLPJJOEN()
		{
			base.OFPPIKHNJOD();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E96 RID: 32406 RVA: 0x0029DC28 File Offset: 0x0029BE28
		private void NEIOOEKEOPC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.CABFICNMMBK.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 4, HLBKCLPNHEB.height / 8, 1);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 1071f, 981f);
			base.HHIFMIPPMPF().SetTexture("MenuScene", this.CABFICNMMBK);
			base.HKHBBBFLGJH().SetFloat("_Value", 1416f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.HEHKGPKLAKK());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E97 RID: 32407 RVA: 0x0029DD70 File Offset: 0x0029BF70
		private void LNOOFNGHNEL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.CABFICNMMBK.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 5, HLBKCLPNHEB.height / 7, 0);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 799f, 1717f);
			base.CIAFLBFJLEJ().SetTexture("Items", this.CABFICNMMBK);
			base.FOOCJIDNGBB().SetFloat("UI Extensions/UI Image Crop", 1814f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.OOMFJGPAOKL());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E98 RID: 32408 RVA: 0x0029DEB7 File Offset: 0x0029C0B7
		protected virtual void JONGNKNLLND()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.KLILJHJNICK();
		}

		// Token: 0x06007E99 RID: 32409 RVA: 0x0029DED4 File Offset: 0x0029C0D4
		private void GHILGJJEAOF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.CABFICNMMBK.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 0, HLBKCLPNHEB.height / 4, 0);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 564f, 1484f);
			base.CIAFLBFJLEJ().SetTexture("Speed", this.CABFICNMMBK);
			base.CFCPHFMKHII().SetFloat("Items/", 1353f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.HEHKGPKLAKK());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E9A RID: 32410 RVA: 0x0029E01C File Offset: 0x0029C21C
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.CABFICNMMBK.hideFlags = HideFlags.HideAndDontSave;
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 4, HLBKCLPNHEB.height / 4, 0);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 0f, 0.92f);
			base.NBPKMLMCHFN.SetTexture("_MainTex", this.CABFICNMMBK);
			base.NBPKMLMCHFN.SetFloat("_AccumOrig", 1f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.NBPKMLMCHFN);
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E9B RID: 32411 RVA: 0x0029E164 File Offset: 0x0029C364
		private void BGMNONMHAJP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.CABFICNMMBK.hideFlags = (HideFlags)(-128);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 6, HLBKCLPNHEB.height / 2, 0);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 772f, 639f);
			base.EMDFHOKEGNG().SetTexture("Working.\nPlease wait..", this.CABFICNMMBK);
			base.LMLENGFLEBD().SetFloat("_ColorG", 1439f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.LEIAFCPJMDP());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007E9C RID: 32412 RVA: 0x0029CF34 File Offset: 0x0029B134
		protected override void EKCDEFDELMP()
		{
			base.FPHLDMMAOEF();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007E9D RID: 32413 RVA: 0x0029DEB7 File Offset: 0x0029C0B7
		protected override void LGHCJCFHEMF()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.KLILJHJNICK();
		}

		// Token: 0x06007E9E RID: 32414 RVA: 0x0029BE43 File Offset: 0x0029A043
		protected override void KOJKBFDNGDK()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = true;
				return;
			}
			base.ALJEJJCIMJN();
		}

		// Token: 0x06007E9F RID: 32415 RVA: 0x0029DAAF File Offset: 0x0029BCAF
		protected virtual void HNILMGEKDEC()
		{
			base.EKCKJLFFAID();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007EA0 RID: 32416 RVA: 0x0029E2AC File Offset: 0x0029C4AC
		private void OPHBLNNGFKG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.CABFICNMMBK.hideFlags = (HideFlags)(-110);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 4, HLBKCLPNHEB.height / 0, 1);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 384f, 1517f);
			base.FOOCJIDNGBB().SetTexture("_Offsets", this.CABFICNMMBK);
			base.HHIFMIPPMPF().SetFloat(": ", 899f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.HKHBBBFLGJH());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007EA1 RID: 32417 RVA: 0x0029E3F4 File Offset: 0x0029C5F4
		private void DOOIKOEBBJB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.CABFICNMMBK == null || this.CABFICNMMBK.width != HLBKCLPNHEB.width || this.CABFICNMMBK.height != HLBKCLPNHEB.height)
			{
				UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
				this.CABFICNMMBK = new RenderTexture(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.CABFICNMMBK.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
				Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK);
			}
			if (this.extraBlur)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width / 0, HLBKCLPNHEB.height / 0, 0);
				this.CABFICNMMBK.MarkRestoreExpected();
				Graphics.Blit(this.CABFICNMMBK, temporary);
				Graphics.Blit(temporary, this.CABFICNMMBK);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.blurAmount = Mathf.Clamp(this.blurAmount, 1012f, 1245f);
			base.OLHDPICFBOF().SetTexture("tolobby", this.CABFICNMMBK);
			base.HHIFMIPPMPF().SetFloat("_TimeX", 281f - this.blurAmount);
			this.CABFICNMMBK.MarkRestoreExpected();
			Graphics.Blit(HLBKCLPNHEB, this.CABFICNMMBK, base.MICHFGAOPKM());
			Graphics.Blit(this.CABFICNMMBK, BMMLHGHKBNM);
		}

		// Token: 0x06007EA2 RID: 32418 RVA: 0x0029C16B File Offset: 0x0029A36B
		protected virtual void CMIBEOJGAIL()
		{
			base.IHHNCCOGLPN();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007EA3 RID: 32419 RVA: 0x0029E53B File Offset: 0x0029C73B
		protected override void Start()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.Start();
		}

		// Token: 0x06007EA4 RID: 32420 RVA: 0x0029E555 File Offset: 0x0029C755
		protected virtual void FMFNILJIEIA()
		{
			if (!SystemInfo.supportsRenderTextures)
			{
				base.enabled = false;
				return;
			}
			base.MDNHCLKNCLE();
		}

		// Token: 0x06007EA5 RID: 32421 RVA: 0x0029E56F File Offset: 0x0029C76F
		protected override void OnDisable()
		{
			base.OnDisable();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x06007EA6 RID: 32422 RVA: 0x0029E582 File Offset: 0x0029C782
		protected virtual void PHJLHCMCCKE()
		{
			base.DKPBBJINKMG();
			UnityEngine.Object.DestroyImmediate(this.CABFICNMMBK);
		}

		// Token: 0x04000E21 RID: 3617
		[Range(0f, 0.92f)]
		public float blurAmount = 0.8f;

		// Token: 0x04000E22 RID: 3618
		public bool extraBlur;

		// Token: 0x04000E23 RID: 3619
		private RenderTexture CABFICNMMBK;
	}
}
