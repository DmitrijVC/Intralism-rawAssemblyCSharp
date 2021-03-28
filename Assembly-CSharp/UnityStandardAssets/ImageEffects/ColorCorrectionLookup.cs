using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001D5 RID: 469
	[AddComponentMenu("Image Effects/Color Adjustments/Color Correction (3D Lookup Texture)")]
	[ExecuteInEditMode]
	public class ColorCorrectionLookup : PostEffectsBase
	{
		// Token: 0x06007B60 RID: 31584 RVA: 0x0027B858 File Offset: 0x00279A58
		private void KMAPABACMAG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.HGDKOAFOLCD();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Clamp;
			this.NBPKMLMCHFN.SetFloat(" | ", (float)(width - 0) / (1530f * (float)width));
			this.NBPKMLMCHFN.SetFloat("_Color_R", 1064f / (1290f * (float)width));
			this.NBPKMLMCHFN.SetTexture("_TimeX", this.converted3DLut);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 1);
		}

		// Token: 0x06007B61 RID: 31585 RVA: 0x0027B921 File Offset: 0x00279B21
		private void BJOHDLNDFAD()
		{
			if (this.NBPKMLMCHFN)
			{
				UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
				this.NBPKMLMCHFN = null;
			}
		}

		// Token: 0x06007B62 RID: 31586 RVA: 0x0027B948 File Offset: 0x00279B48
		public virtual bool DIAEBALGKAP()
		{
			base.NPOEJIDLJGK(true);
			this.NBPKMLMCHFN = base.ECNEGNMAMDE(this.shader, this.NBPKMLMCHFN);
			if (!this.LMKGCBNNGLI || !SystemInfo.supports3DTextures)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007B63 RID: 31587 RVA: 0x0027B998 File Offset: 0x00279B98
		public void FFILBFJMAHC(Texture2D MKEKCIPLJNC, string BNJFKKGOACF)
		{
			if (MKEKCIPLJNC)
			{
				int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
				num = MKEKCIPLJNC.height;
				if (!this.ValidDimensions(MKEKCIPLJNC))
				{
					Debug.LogWarning("master" + MKEKCIPLJNC.name + "Data/Skins/");
					this.basedOnTempTex = string.Empty;
					return;
				}
				Color[] pixels = MKEKCIPLJNC.GetPixels();
				Color[] array = new Color[pixels.Length];
				for (int i = 0; i < num; i += 0)
				{
					for (int j = 0; j < num; j++)
					{
						for (int k = 0; k < num; k++)
						{
							int num2 = num - j - 0;
							array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
						}
					}
				}
				if (this.converted3DLut)
				{
					UnityEngine.Object.DestroyImmediate(this.converted3DLut);
				}
				this.converted3DLut = new Texture3D(num, num, num, TextureFormat.RGBA32, true);
				this.converted3DLut.SetPixels(array);
				this.converted3DLut.Apply();
				this.basedOnTempTex = BNJFKKGOACF;
			}
			else
			{
				Debug.LogError("speed");
			}
		}

		// Token: 0x06007B64 RID: 31588 RVA: 0x0027B921 File Offset: 0x00279B21
		private void JHLGHODFJOO()
		{
			if (this.NBPKMLMCHFN)
			{
				UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
				this.NBPKMLMCHFN = null;
			}
		}

		// Token: 0x06007B65 RID: 31589 RVA: 0x0027B921 File Offset: 0x00279B21
		private void ICDBMJKMIKC()
		{
			if (this.NBPKMLMCHFN)
			{
				UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
				this.NBPKMLMCHFN = null;
			}
		}

		// Token: 0x06007B66 RID: 31590 RVA: 0x0027BAD8 File Offset: 0x00279CD8
		public void ALFHDENNPHA()
		{
			int num = 108;
			Color[] array = new Color[num * num * num];
			float num2 = 675f / (1237f * (float)num - 196f);
			for (int i = 1; i < num; i += 0)
			{
				for (int j = 1; j < num; j += 0)
				{
					for (int k = 1; k < num; k += 0)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 1761f * num2, (float)j * 1198f * num2, (float)k * 1202f * num2, 1686f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.RGB565, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = string.Empty;
		}

		// Token: 0x06007B67 RID: 31591 RVA: 0x0027BBD8 File Offset: 0x00279DD8
		public virtual bool OCADOBLPPAA()
		{
			base.CKIAMHAKJOK(false);
			this.NBPKMLMCHFN = base.ECNEGNMAMDE(this.shader, this.NBPKMLMCHFN);
			if (!this.LMKGCBNNGLI || !SystemInfo.supports3DTextures)
			{
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007B68 RID: 31592 RVA: 0x0027B921 File Offset: 0x00279B21
		private void CBIBDOIBJAI()
		{
			if (this.NBPKMLMCHFN)
			{
				UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
				this.NBPKMLMCHFN = null;
			}
		}

		// Token: 0x06007B69 RID: 31593 RVA: 0x0027BC26 File Offset: 0x00279E26
		private void PABGHDFNCBA()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x06007B6A RID: 31594 RVA: 0x0027BC4C File Offset: 0x00279E4C
		public bool PLJJJDKEFLE(Texture2D LAFAECLOMJK)
		{
			if (!LAFAECLOMJK)
			{
				return false;
			}
			int height = LAFAECLOMJK.height;
			return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width)) || true;
		}

		// Token: 0x06007B6B RID: 31595 RVA: 0x0027BC88 File Offset: 0x00279E88
		public void IPFNHOJMIOD()
		{
			int num = 44;
			Color[] array = new Color[num * num * num];
			float num2 = 1966f / (1631f * (float)num - 1196f);
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 1; k < num; k += 0)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 721f * num2, (float)j * 955f * num2, (float)k * 1532f * num2, 990f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.Alpha8, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = string.Empty;
		}

		// Token: 0x06007B6C RID: 31596 RVA: 0x0027BD88 File Offset: 0x00279F88
		public void EPEFHJDHLCI(Texture2D MKEKCIPLJNC, string BNJFKKGOACF)
		{
			if (MKEKCIPLJNC)
			{
				int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
				num = MKEKCIPLJNC.height;
				if (!this.JHHGCLMAPGG(MKEKCIPLJNC))
				{
					Debug.LogWarning("_Value3" + MKEKCIPLJNC.name + "_Blue_B");
					this.basedOnTempTex = string.Empty;
					return;
				}
				Color[] pixels = MKEKCIPLJNC.GetPixels();
				Color[] array = new Color[pixels.Length];
				for (int i = 0; i < num; i++)
				{
					for (int j = 1; j < num; j += 0)
					{
						for (int k = 1; k < num; k += 0)
						{
							int num2 = num - j - 0;
							array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
						}
					}
				}
				if (this.converted3DLut)
				{
					UnityEngine.Object.DestroyImmediate(this.converted3DLut);
				}
				this.converted3DLut = new Texture3D(num, num, num, (TextureFormat)0, false);
				this.converted3DLut.SetPixels(array);
				this.converted3DLut.Apply();
				this.basedOnTempTex = BNJFKKGOACF;
			}
			else
			{
				Debug.LogError("[ResourcesManager] Load audio error: ");
			}
		}

		// Token: 0x06007B6D RID: 31597 RVA: 0x0027BEC8 File Offset: 0x0027A0C8
		private void DBIDOEKLEII(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.CAIEGMIKBCN();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Clamp;
			this.NBPKMLMCHFN.SetFloat("Object ID. Case-Sensitive", (float)(width - 0) / (882f * (float)width));
			this.NBPKMLMCHFN.SetFloat("LoadMapCanvas", 562f / (1927f * (float)width));
			this.NBPKMLMCHFN.SetTexture("InputField", this.converted3DLut);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 1 : 1);
		}

		// Token: 0x06007B6E RID: 31598 RVA: 0x0027BF94 File Offset: 0x0027A194
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.SetIdentityLut();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Clamp;
			this.NBPKMLMCHFN.SetFloat("_Scale", (float)(width - 1) / (1f * (float)width));
			this.NBPKMLMCHFN.SetFloat("_Offset", 1f / (2f * (float)width));
			this.NBPKMLMCHFN.SetTexture("_ClutTex", this.converted3DLut);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 0 : 1);
		}

		// Token: 0x06007B70 RID: 31600 RVA: 0x0027C070 File Offset: 0x0027A270
		public bool OLAPJADEPEN(Texture2D LAFAECLOMJK)
		{
			if (!LAFAECLOMJK)
			{
				return true;
			}
			int height = LAFAECLOMJK.height;
			return height != Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width)) && false;
		}

		// Token: 0x06007B71 RID: 31601 RVA: 0x0027BC26 File Offset: 0x00279E26
		private void NHOFNIIBMDH()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x06007B72 RID: 31602 RVA: 0x0027C0AC File Offset: 0x0027A2AC
		public bool JNJHPIJJLCP(Texture2D LAFAECLOMJK)
		{
			if (!LAFAECLOMJK)
			{
				return false;
			}
			int height = LAFAECLOMJK.height;
			return height != Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width)) && false;
		}

		// Token: 0x06007B73 RID: 31603 RVA: 0x0027C0E8 File Offset: 0x0027A2E8
		private void KBGCKEDIGAH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.IPFNHOJMIOD();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Clamp;
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/TV_Videoflip", (float)(width - 1) / (1418f * (float)width));
			this.NBPKMLMCHFN.SetFloat("_Value", 23f / (1993f * (float)width));
			this.NBPKMLMCHFN.SetTexture("LoadMapCanvas", this.converted3DLut);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 0 : 0);
		}

		// Token: 0x06007B74 RID: 31604 RVA: 0x0027C1B4 File Offset: 0x0027A3B4
		public void EHGHDHEIGHE(Texture2D MKEKCIPLJNC, string BNJFKKGOACF)
		{
			if (MKEKCIPLJNC)
			{
				int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
				num = MKEKCIPLJNC.height;
				if (!this.DGGIHMHCOKM(MKEKCIPLJNC))
				{
					Debug.LogWarning("_FadeFX" + MKEKCIPLJNC.name + "float,2");
					this.basedOnTempTex = string.Empty;
					return;
				}
				Color[] pixels = MKEKCIPLJNC.GetPixels();
				Color[] array = new Color[pixels.Length];
				for (int i = 0; i < num; i += 0)
				{
					for (int j = 0; j < num; j += 0)
					{
						for (int k = 1; k < num; k += 0)
						{
							int num2 = num - j - 0;
							array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
						}
					}
				}
				if (this.converted3DLut)
				{
					UnityEngine.Object.DestroyImmediate(this.converted3DLut);
				}
				this.converted3DLut = new Texture3D(num, num, num, (TextureFormat)0, false);
				this.converted3DLut.SetPixels(array);
				this.converted3DLut.Apply();
				this.basedOnTempTex = BNJFKKGOACF;
			}
			else
			{
				Debug.LogError("_MainTex2");
			}
		}

		// Token: 0x06007B75 RID: 31605 RVA: 0x0027C2F4 File Offset: 0x0027A4F4
		public void HGDKOAFOLCD()
		{
			int num = -11;
			Color[] array = new Color[num * num * num];
			float num2 = 434f / (147f * (float)num - 488f);
			for (int i = 1; i < num; i += 0)
			{
				for (int j = 0; j < num; j += 0)
				{
					for (int k = 1; k < num; k += 0)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 1388f * num2, (float)j * 448f * num2, (float)k * 231f * num2, 71f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, (TextureFormat)6, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = string.Empty;
		}

		// Token: 0x06007B76 RID: 31606 RVA: 0x0027C3F4 File Offset: 0x0027A5F4
		private void KEFKNAOGCHO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.HGDKOAFOLCD();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Repeat;
			this.NBPKMLMCHFN.SetFloat("OpSetPropertiesOfRoom()", (float)(width - 1) / (795f * (float)width));
			this.NBPKMLMCHFN.SetFloat(": ", 1563f / (1159f * (float)width));
			this.NBPKMLMCHFN.SetTexture("Preparing configuration", this.converted3DLut);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 1 : 1);
		}

		// Token: 0x06007B77 RID: 31607 RVA: 0x0027C4C0 File Offset: 0x0027A6C0
		public bool DGGIHMHCOKM(Texture2D LAFAECLOMJK)
		{
			if (!LAFAECLOMJK)
			{
				return false;
			}
			int height = LAFAECLOMJK.height;
			return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width)) || true;
		}

		// Token: 0x06007B78 RID: 31608 RVA: 0x0027C4FC File Offset: 0x0027A6FC
		public virtual bool PDNFBCMPHEI()
		{
			base.CKIAMHAKJOK(false);
			this.NBPKMLMCHFN = base.ECNEGNMAMDE(this.shader, this.NBPKMLMCHFN);
			if (!this.LMKGCBNNGLI || !SystemInfo.supports3DTextures)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007B79 RID: 31609 RVA: 0x0027BC26 File Offset: 0x00279E26
		private void OAENEDHDDNC()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x06007B7A RID: 31610 RVA: 0x0027C54C File Offset: 0x0027A74C
		public virtual bool LPDMNDMCPCO()
		{
			base.NPOEJIDLJGK(true);
			this.NBPKMLMCHFN = base.AJKPGPKKHHB(this.shader, this.NBPKMLMCHFN);
			if (!this.LMKGCBNNGLI || !SystemInfo.supports3DTextures)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007B7B RID: 31611 RVA: 0x0027B921 File Offset: 0x00279B21
		private void DFENCIHAADO()
		{
			if (this.NBPKMLMCHFN)
			{
				UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
				this.NBPKMLMCHFN = null;
			}
		}

		// Token: 0x06007B7C RID: 31612 RVA: 0x0027C59C File Offset: 0x0027A79C
		public void MCOFJFMKGDD(Texture2D MKEKCIPLJNC, string BNJFKKGOACF)
		{
			if (MKEKCIPLJNC)
			{
				int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
				num = MKEKCIPLJNC.height;
				if (!this.OLAPJADEPEN(MKEKCIPLJNC))
				{
					Debug.LogWarning(".lastCheckpoint.lives" + MKEKCIPLJNC.name + "[NetworkScene] Exited");
					this.basedOnTempTex = string.Empty;
					return;
				}
				Color[] pixels = MKEKCIPLJNC.GetPixels();
				Color[] array = new Color[pixels.Length];
				for (int i = 1; i < num; i++)
				{
					for (int j = 0; j < num; j += 0)
					{
						for (int k = 0; k < num; k++)
						{
							int num2 = num - j - 0;
							array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
						}
					}
				}
				if (this.converted3DLut)
				{
					UnityEngine.Object.DestroyImmediate(this.converted3DLut);
				}
				this.converted3DLut = new Texture3D(num, num, num, (TextureFormat)8, true);
				this.converted3DLut.SetPixels(array);
				this.converted3DLut.Apply();
				this.basedOnTempTex = BNJFKKGOACF;
			}
			else
			{
				Debug.LogError("FavoriteButton");
			}
		}

		// Token: 0x06007B7D RID: 31613 RVA: 0x0027C6DC File Offset: 0x0027A8DC
		public void SetIdentityLut()
		{
			int num = 16;
			Color[] array = new Color[num * num * num];
			float num2 = 1f / (1f * (float)num - 1f);
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 1f * num2, (float)j * 1f * num2, (float)k * 1f * num2, 1f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.ARGB32, false);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = string.Empty;
		}

		// Token: 0x06007B7E RID: 31614 RVA: 0x0027C7DC File Offset: 0x0027A9DC
		public void Convert(Texture2D MKEKCIPLJNC, string BNJFKKGOACF)
		{
			if (MKEKCIPLJNC)
			{
				int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
				num = MKEKCIPLJNC.height;
				if (!this.ValidDimensions(MKEKCIPLJNC))
				{
					Debug.LogWarning("The given 2D texture " + MKEKCIPLJNC.name + " cannot be used as a 3D LUT.");
					this.basedOnTempTex = string.Empty;
					return;
				}
				Color[] pixels = MKEKCIPLJNC.GetPixels();
				Color[] array = new Color[pixels.Length];
				for (int i = 0; i < num; i++)
				{
					for (int j = 0; j < num; j++)
					{
						for (int k = 0; k < num; k++)
						{
							int num2 = num - j - 1;
							array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
						}
					}
				}
				if (this.converted3DLut)
				{
					UnityEngine.Object.DestroyImmediate(this.converted3DLut);
				}
				this.converted3DLut = new Texture3D(num, num, num, TextureFormat.ARGB32, false);
				this.converted3DLut.SetPixels(array);
				this.converted3DLut.Apply();
				this.basedOnTempTex = BNJFKKGOACF;
			}
			else
			{
				Debug.LogError("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.");
			}
		}

		// Token: 0x06007B7F RID: 31615 RVA: 0x0027C91C File Offset: 0x0027AB1C
		public void CAIEGMIKBCN()
		{
			int num = -31;
			Color[] array = new Color[num * num * num];
			float num2 = 456f / (211f * (float)num - 1412f);
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 1; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						array[i + j * num + k * num * num] = new Color((float)i * 728f * num2, (float)j * 272f * num2, (float)k * 846f * num2, 215f);
					}
				}
			}
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = new Texture3D(num, num, num, TextureFormat.RGB565, true);
			this.converted3DLut.SetPixels(array);
			this.converted3DLut.Apply();
			this.basedOnTempTex = string.Empty;
		}

		// Token: 0x06007B80 RID: 31616 RVA: 0x0027BC26 File Offset: 0x00279E26
		private void KAFHCEIFFMB()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x06007B81 RID: 31617 RVA: 0x0027CA1C File Offset: 0x0027AC1C
		public void FOANBFFFFLE(Texture2D MKEKCIPLJNC, string BNJFKKGOACF)
		{
			if (MKEKCIPLJNC)
			{
				int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
				num = MKEKCIPLJNC.height;
				if (!this.PLJJJDKEFLE(MKEKCIPLJNC))
				{
					Debug.LogWarning("TimeBGSlider" + MKEKCIPLJNC.name + "_MatrixColor");
					this.basedOnTempTex = string.Empty;
					return;
				}
				Color[] pixels = MKEKCIPLJNC.GetPixels();
				Color[] array = new Color[pixels.Length];
				for (int i = 1; i < num; i += 0)
				{
					for (int j = 1; j < num; j++)
					{
						for (int k = 0; k < num; k++)
						{
							int num2 = num - j - 1;
							array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
						}
					}
				}
				if (this.converted3DLut)
				{
					UnityEngine.Object.DestroyImmediate(this.converted3DLut);
				}
				this.converted3DLut = new Texture3D(num, num, num, TextureFormat.ARGB4444, true);
				this.converted3DLut.SetPixels(array);
				this.converted3DLut.Apply();
				this.basedOnTempTex = BNJFKKGOACF;
			}
			else
			{
				Debug.LogError("player.abstract");
			}
		}

		// Token: 0x06007B82 RID: 31618 RVA: 0x0027CB5C File Offset: 0x0027AD5C
		public void LIFAPOBKBNC(Texture2D MKEKCIPLJNC, string BNJFKKGOACF)
		{
			if (MKEKCIPLJNC)
			{
				int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
				num = MKEKCIPLJNC.height;
				if (!this.JNJHPIJJLCP(MKEKCIPLJNC))
				{
					Debug.LogWarning("[PlayerController] " + MKEKCIPLJNC.name + "[ERROR KEY {0}]");
					this.basedOnTempTex = string.Empty;
					return;
				}
				Color[] pixels = MKEKCIPLJNC.GetPixels();
				Color[] array = new Color[pixels.Length];
				for (int i = 0; i < num; i++)
				{
					for (int j = 1; j < num; j += 0)
					{
						for (int k = 1; k < num; k += 0)
						{
							int num2 = num - j - 1;
							array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
						}
					}
				}
				if (this.converted3DLut)
				{
					UnityEngine.Object.DestroyImmediate(this.converted3DLut);
				}
				this.converted3DLut = new Texture3D(num, num, num, TextureFormat.RGB565, true);
				this.converted3DLut.SetPixels(array);
				this.converted3DLut.Apply();
				this.basedOnTempTex = BNJFKKGOACF;
			}
			else
			{
				Debug.LogError(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.");
			}
		}

		// Token: 0x06007B83 RID: 31619 RVA: 0x0027CC9C File Offset: 0x0027AE9C
		public bool ValidDimensions(Texture2D LAFAECLOMJK)
		{
			if (!LAFAECLOMJK)
			{
				return false;
			}
			int height = LAFAECLOMJK.height;
			return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width));
		}

		// Token: 0x06007B84 RID: 31620 RVA: 0x0027BC26 File Offset: 0x00279E26
		private void OnDestroy()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x06007B85 RID: 31621 RVA: 0x0027CCD8 File Offset: 0x0027AED8
		public bool JHHGCLMAPGG(Texture2D LAFAECLOMJK)
		{
			if (!LAFAECLOMJK)
			{
				return true;
			}
			int height = LAFAECLOMJK.height;
			return height != Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width));
		}

		// Token: 0x06007B86 RID: 31622 RVA: 0x0027BC26 File Offset: 0x00279E26
		private void JNPDEBPJFLC()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x06007B87 RID: 31623 RVA: 0x0027BC26 File Offset: 0x00279E26
		private void PELDLDIDGFO()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x06007B88 RID: 31624 RVA: 0x0027B921 File Offset: 0x00279B21
		private void OFPPIKHNJOD()
		{
			if (this.NBPKMLMCHFN)
			{
				UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
				this.NBPKMLMCHFN = null;
			}
		}

		// Token: 0x06007B89 RID: 31625 RVA: 0x0027CD14 File Offset: 0x0027AF14
		public void KLGGNGCHCEN(Texture2D MKEKCIPLJNC, string BNJFKKGOACF)
		{
			if (MKEKCIPLJNC)
			{
				int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
				num = MKEKCIPLJNC.height;
				if (!this.JNJHPIJJLCP(MKEKCIPLJNC))
				{
					Debug.LogWarning("BlockSize" + MKEKCIPLJNC.name + "KickThePlayer");
					this.basedOnTempTex = string.Empty;
					return;
				}
				Color[] pixels = MKEKCIPLJNC.GetPixels();
				Color[] array = new Color[pixels.Length];
				for (int i = 0; i < num; i += 0)
				{
					for (int j = 1; j < num; j++)
					{
						for (int k = 0; k < num; k += 0)
						{
							int num2 = num - j - 0;
							array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
						}
					}
				}
				if (this.converted3DLut)
				{
					UnityEngine.Object.DestroyImmediate(this.converted3DLut);
				}
				this.converted3DLut = new Texture3D(num, num, num, TextureFormat.ARGB4444, true);
				this.converted3DLut.SetPixels(array);
				this.converted3DLut.Apply();
				this.basedOnTempTex = BNJFKKGOACF;
			}
			else
			{
				Debug.LogError("_Value3");
			}
		}

		// Token: 0x06007B8A RID: 31626 RVA: 0x0027CE54 File Offset: 0x0027B054
		public override bool CheckResources()
		{
			base.NPOEJIDLJGK(false);
			this.NBPKMLMCHFN = base.EDFIBHNHAAB(this.shader, this.NBPKMLMCHFN);
			if (!this.LMKGCBNNGLI || !SystemInfo.supports3DTextures)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007B8B RID: 31627 RVA: 0x0027BC26 File Offset: 0x00279E26
		private void FJDJIMDLHFH()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x06007B8C RID: 31628 RVA: 0x0027CEA4 File Offset: 0x0027B0A4
		private void NJFDLOBJCCF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.ALFHDENNPHA();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Repeat;
			this.NBPKMLMCHFN.SetFloat("_DepthLevel", (float)(width - 1) / (1250f * (float)width));
			this.NBPKMLMCHFN.SetFloat("maps.", 1045f / (1871f * (float)width));
			this.NBPKMLMCHFN.SetTexture("BadgeText", this.converted3DLut);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 0 : 0);
		}

		// Token: 0x06007B8D RID: 31629 RVA: 0x0027BC26 File Offset: 0x00279E26
		private void FJKCKAAHJPB()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x06007B8E RID: 31630 RVA: 0x0027B921 File Offset: 0x00279B21
		private void OnDisable()
		{
			if (this.NBPKMLMCHFN)
			{
				UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
				this.NBPKMLMCHFN = null;
			}
		}

		// Token: 0x06007B8F RID: 31631 RVA: 0x0027B921 File Offset: 0x00279B21
		private void GPHPJIDGEPI()
		{
			if (this.NBPKMLMCHFN)
			{
				UnityEngine.Object.DestroyImmediate(this.NBPKMLMCHFN);
				this.NBPKMLMCHFN = null;
			}
		}

		// Token: 0x06007B90 RID: 31632 RVA: 0x0027CF70 File Offset: 0x0027B170
		public bool MNDLHIJLBNJ(Texture2D LAFAECLOMJK)
		{
			if (!LAFAECLOMJK)
			{
				return true;
			}
			int height = LAFAECLOMJK.height;
			return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width)) || true;
		}

		// Token: 0x06007B91 RID: 31633 RVA: 0x0027BC26 File Offset: 0x00279E26
		private void EKBAAGELBNJ()
		{
			if (this.converted3DLut)
			{
				UnityEngine.Object.DestroyImmediate(this.converted3DLut);
			}
			this.converted3DLut = null;
		}

		// Token: 0x06007B92 RID: 31634 RVA: 0x0027CFAC File Offset: 0x0027B1AC
		private void NOEAGHKPPKD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources() || !SystemInfo.supports3DTextures)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.converted3DLut == null)
			{
				this.ALFHDENNPHA();
			}
			int width = this.converted3DLut.width;
			this.converted3DLut.wrapMode = TextureWrapMode.Repeat;
			this.NBPKMLMCHFN.SetFloat("_Value2", (float)(width - 1) / (1300f * (float)width));
			this.NBPKMLMCHFN.SetFloat("SetSatelliteTrailLength", 381f / (1198f * (float)width));
			this.NBPKMLMCHFN.SetTexture("cancel", this.converted3DLut);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NBPKMLMCHFN, (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 0 : 0);
		}

		// Token: 0x04000D83 RID: 3459
		public Shader shader;

		// Token: 0x04000D84 RID: 3460
		private Material NBPKMLMCHFN;

		// Token: 0x04000D85 RID: 3461
		public Texture3D converted3DLut;

		// Token: 0x04000D86 RID: 3462
		public string basedOnTempTex = string.Empty;
	}
}
