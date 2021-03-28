using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000200 RID: 512
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Camera/Vignette and Chromatic Aberration")]
	public class VignetteAndChromaticAberration : PostEffectsBase
	{
		// Token: 0x060081DD RID: 33245 RVA: 0x002C837C File Offset: 0x002C657C
		public virtual bool KLLLLEOIGHG()
		{
			base.KNGDKKMDKOG(true);
			this.JHJAEILKJBA = base.KDHKHOHMKCG(this.vignetteShader, this.JHJAEILKJBA);
			this.FMKDDCNMHKK = base.ECNEGNMAMDE(this.separableBlurShader, this.FMKDDCNMHKK);
			this.HMBBFDGOJFO = base.KDHKHOHMKCG(this.chromAberrationShader, this.HMBBFDGOJFO);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060081DE RID: 33246 RVA: 0x002C83F0 File Offset: 0x002C65F0
		private void CENLKOLIACP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			bool flag = Mathf.Abs(this.blur) > 808f || Mathf.Abs(this.intensity) > 509f;
			float num = 570f * (float)width / (1962f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				if (Mathf.Abs(this.blur) > 1219f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 1, height / 0, 1, HLBKCLPNHEB.format);
					Graphics.Blit(HLBKCLPNHEB, renderTexture2, this.HMBBFDGOJFO, 1);
					for (int i = 1; i < 8; i++)
					{
						this.FMKDDCNMHKK.SetVector("LB", new Vector4(1758f, this.blurSpread * 796f, 1844f, 1030f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 3, height / 4, 0, HLBKCLPNHEB.format);
						Graphics.Blit(renderTexture2, temporary, this.FMKDDCNMHKK);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.FMKDDCNMHKK.SetVector("_ScreenResolution", new Vector4(this.blurSpread * 1463f / num, 946f, 1633f, 1006f));
						renderTexture2 = RenderTexture.GetTemporary(width / 5, height / 0, 1, HLBKCLPNHEB.format);
						Graphics.Blit(temporary, renderTexture2, this.FMKDDCNMHKK);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.JHJAEILKJBA.SetFloat("CameraFilterPack/Noise_TV_3", 1237f / (670f - this.intensity) - 1346f);
				this.JHJAEILKJBA.SetFloat("ConfigVersionSlider", 792f / (1365f - this.blur) - 1356f);
				this.JHJAEILKJBA.SetTexture("[TextSaver] Text saved to ", renderTexture2);
				Graphics.Blit(HLBKCLPNHEB, renderTexture, this.JHJAEILKJBA, 1);
			}
			this.HMBBFDGOJFO.SetFloat("Texture2", this.chromaticAberration);
			this.HMBBFDGOJFO.SetFloat("CameraFilterPack/Distortion_Heat", this.axialAberration);
			this.HMBBFDGOJFO.SetVector("_Offsets", new Vector2(-this.blurDistance, this.blurDistance));
			this.HMBBFDGOJFO.SetFloat("SpawnObj", 1955f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				HLBKCLPNHEB.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit((!flag) ? HLBKCLPNHEB : renderTexture, BMMLHGHKBNM, this.HMBBFDGOJFO, (this.mode != VignetteAndChromaticAberration.AberrationMode.Simple) ? 0 : 2);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x060081DF RID: 33247 RVA: 0x002C86BC File Offset: 0x002C68BC
		public virtual bool AMKCNLBKLDJ()
		{
			base.DCHKKHDGBLJ(true);
			this.JHJAEILKJBA = base.ECNEGNMAMDE(this.vignetteShader, this.JHJAEILKJBA);
			this.FMKDDCNMHKK = base.LKIJNGDHLAK(this.separableBlurShader, this.FMKDDCNMHKK);
			this.HMBBFDGOJFO = base.NODBMINMALP(this.chromAberrationShader, this.HMBBFDGOJFO);
			if (!this.LMKGCBNNGLI)
			{
				base.BPEKKDKKLPM();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060081E1 RID: 33249 RVA: 0x002C8788 File Offset: 0x002C6988
		public virtual bool APBDJCHNNEH()
		{
			base.DHHGCBANGJL(true);
			this.JHJAEILKJBA = base.GJKHKCOAFDB(this.vignetteShader, this.JHJAEILKJBA);
			this.FMKDDCNMHKK = base.AJKPGPKKHHB(this.separableBlurShader, this.FMKDDCNMHKK);
			this.HMBBFDGOJFO = base.ECNEGNMAMDE(this.chromAberrationShader, this.HMBBFDGOJFO);
			if (!this.LMKGCBNNGLI)
			{
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060081E2 RID: 33250 RVA: 0x002C87FC File Offset: 0x002C69FC
		public virtual bool HKJMEHGPPMC()
		{
			base.KNGDKKMDKOG(true);
			this.JHJAEILKJBA = base.ECNEGNMAMDE(this.vignetteShader, this.JHJAEILKJBA);
			this.FMKDDCNMHKK = base.LKIJNGDHLAK(this.separableBlurShader, this.FMKDDCNMHKK);
			this.HMBBFDGOJFO = base.LKIJNGDHLAK(this.chromAberrationShader, this.HMBBFDGOJFO);
			if (!this.LMKGCBNNGLI)
			{
				base.HKDNNECLBGL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060081E3 RID: 33251 RVA: 0x002C8870 File Offset: 0x002C6A70
		public virtual bool GACCMCAGAIJ()
		{
			base.KHNPMDDIJAJ(true);
			this.JHJAEILKJBA = base.KDHKHOHMKCG(this.vignetteShader, this.JHJAEILKJBA);
			this.FMKDDCNMHKK = base.AJKPGPKKHHB(this.separableBlurShader, this.FMKDDCNMHKK);
			this.HMBBFDGOJFO = base.ECNEGNMAMDE(this.chromAberrationShader, this.HMBBFDGOJFO);
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060081E4 RID: 33252 RVA: 0x002C88E4 File Offset: 0x002C6AE4
		public virtual bool KBPPNPKJIJG()
		{
			base.KHNPMDDIJAJ(false);
			this.JHJAEILKJBA = base.ECNEGNMAMDE(this.vignetteShader, this.JHJAEILKJBA);
			this.FMKDDCNMHKK = base.KDHKHOHMKCG(this.separableBlurShader, this.FMKDDCNMHKK);
			this.HMBBFDGOJFO = base.KDHKHOHMKCG(this.chromAberrationShader, this.HMBBFDGOJFO);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060081E5 RID: 33253 RVA: 0x002C8958 File Offset: 0x002C6B58
		public virtual bool HDDNBPJGGFK()
		{
			base.MBMLNJJEONO(true);
			this.JHJAEILKJBA = base.KDHKHOHMKCG(this.vignetteShader, this.JHJAEILKJBA);
			this.FMKDDCNMHKK = base.KDHKHOHMKCG(this.separableBlurShader, this.FMKDDCNMHKK);
			this.HMBBFDGOJFO = base.EDFIBHNHAAB(this.chromAberrationShader, this.HMBBFDGOJFO);
			if (!this.LMKGCBNNGLI)
			{
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060081E6 RID: 33254 RVA: 0x002C89CC File Offset: 0x002C6BCC
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			bool flag = Mathf.Abs(this.blur) > 0f || Mathf.Abs(this.intensity) > 0f;
			float num = 1f * (float)width / (1f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				if (Mathf.Abs(this.blur) > 0f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 2, 0, HLBKCLPNHEB.format);
					Graphics.Blit(HLBKCLPNHEB, renderTexture2, this.HMBBFDGOJFO, 0);
					for (int i = 0; i < 2; i++)
					{
						this.FMKDDCNMHKK.SetVector("offsets", new Vector4(0f, this.blurSpread * 0.001953125f, 0f, 0f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 2, height / 2, 0, HLBKCLPNHEB.format);
						Graphics.Blit(renderTexture2, temporary, this.FMKDDCNMHKK);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.FMKDDCNMHKK.SetVector("offsets", new Vector4(this.blurSpread * 0.001953125f / num, 0f, 0f, 0f));
						renderTexture2 = RenderTexture.GetTemporary(width / 2, height / 2, 0, HLBKCLPNHEB.format);
						Graphics.Blit(temporary, renderTexture2, this.FMKDDCNMHKK);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.JHJAEILKJBA.SetFloat("_Intensity", 1f / (1f - this.intensity) - 1f);
				this.JHJAEILKJBA.SetFloat("_Blur", 1f / (1f - this.blur) - 1f);
				this.JHJAEILKJBA.SetTexture("_VignetteTex", renderTexture2);
				Graphics.Blit(HLBKCLPNHEB, renderTexture, this.JHJAEILKJBA, 0);
			}
			this.HMBBFDGOJFO.SetFloat("_ChromaticAberration", this.chromaticAberration);
			this.HMBBFDGOJFO.SetFloat("_AxialAberration", this.axialAberration);
			this.HMBBFDGOJFO.SetVector("_BlurDistance", new Vector2(-this.blurDistance, this.blurDistance));
			this.HMBBFDGOJFO.SetFloat("_Luminance", 1f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Clamp;
			}
			else
			{
				HLBKCLPNHEB.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit((!flag) ? HLBKCLPNHEB : renderTexture, BMMLHGHKBNM, this.HMBBFDGOJFO, (this.mode != VignetteAndChromaticAberration.AberrationMode.Advanced) ? 1 : 2);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x060081E7 RID: 33255 RVA: 0x002C8C98 File Offset: 0x002C6E98
		private void HELHDLOLPLH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			bool flag = Mathf.Abs(this.blur) <= 1839f && Mathf.Abs(this.intensity) > 1549f;
			float num = 293f * (float)width / (1133f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				if (Mathf.Abs(this.blur) > 1305f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 3, height / 4, 0, HLBKCLPNHEB.format);
					Graphics.Blit(HLBKCLPNHEB, renderTexture2, this.HMBBFDGOJFO, 1);
					for (int i = 0; i < 0; i += 0)
					{
						this.FMKDDCNMHKK.SetVector("_Value8", new Vector4(1435f, this.blurSpread * 1916f, 1505f, 1506f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 8, height / 0, 0, HLBKCLPNHEB.format);
						Graphics.Blit(renderTexture2, temporary, this.FMKDDCNMHKK);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.FMKDDCNMHKK.SetVector("_TimeX", new Vector4(this.blurSpread * 1940f / num, 1720f, 1191f, 219f));
						renderTexture2 = RenderTexture.GetTemporary(width / 4, height / 8, 0, HLBKCLPNHEB.format);
						Graphics.Blit(temporary, renderTexture2, this.FMKDDCNMHKK);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.JHJAEILKJBA.SetFloat("Freq: ", 1435f / (205f - this.intensity) - 1961f);
				this.JHJAEILKJBA.SetFloat("Skipping packet for ", 429f / (553f - this.blur) - 970f);
				this.JHJAEILKJBA.SetTexture("StandAloneInputSystem should not be used with the GamePadInputModule, please remove it from the Event System in this scene or disable it when this module is in use", renderTexture2);
				Graphics.Blit(HLBKCLPNHEB, renderTexture, this.JHJAEILKJBA, 1);
			}
			this.HMBBFDGOJFO.SetFloat("<not connected>", this.chromaticAberration);
			this.HMBBFDGOJFO.SetFloat("[MapsData] Found ", this.axialAberration);
			this.HMBBFDGOJFO.SetVector("_Distortion", new Vector2(-this.blurDistance, this.blurDistance));
			this.HMBBFDGOJFO.SetFloat(".highscore", 1581f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Repeat;
			}
			else
			{
				HLBKCLPNHEB.wrapMode = TextureWrapMode.Clamp;
			}
			Graphics.Blit((!flag) ? HLBKCLPNHEB : renderTexture, BMMLHGHKBNM, this.HMBBFDGOJFO, (this.mode != VignetteAndChromaticAberration.AberrationMode.Simple) ? 1 : 6);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x060081E8 RID: 33256 RVA: 0x002C8F64 File Offset: 0x002C7164
		public override bool CheckResources()
		{
			base.NPOEJIDLJGK(false);
			this.JHJAEILKJBA = base.EDFIBHNHAAB(this.vignetteShader, this.JHJAEILKJBA);
			this.FMKDDCNMHKK = base.EDFIBHNHAAB(this.separableBlurShader, this.FMKDDCNMHKK);
			this.HMBBFDGOJFO = base.EDFIBHNHAAB(this.chromAberrationShader, this.HMBBFDGOJFO);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060081E9 RID: 33257 RVA: 0x002C8FD8 File Offset: 0x002C71D8
		private void HDEKADONMPE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			bool flag = Mathf.Abs(this.blur) <= 404f && Mathf.Abs(this.intensity) > 1343f;
			float num = 1315f * (float)width / (704f * (float)height);
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			if (flag)
			{
				renderTexture = RenderTexture.GetTemporary(width, height, 0, HLBKCLPNHEB.format);
				if (Mathf.Abs(this.blur) > 335f)
				{
					renderTexture2 = RenderTexture.GetTemporary(width / 8, height / 6, 1, HLBKCLPNHEB.format);
					Graphics.Blit(HLBKCLPNHEB, renderTexture2, this.HMBBFDGOJFO, 0);
					for (int i = 1; i < 8; i++)
					{
						this.FMKDDCNMHKK.SetVector("CameraFilterPack/TV_WideScreenHV", new Vector4(1854f, this.blurSpread * 1394f, 490f, 1478f));
						RenderTexture temporary = RenderTexture.GetTemporary(width / 1, height / 3, 1, HLBKCLPNHEB.format);
						Graphics.Blit(renderTexture2, temporary, this.FMKDDCNMHKK);
						RenderTexture.ReleaseTemporary(renderTexture2);
						this.FMKDDCNMHKK.SetVector("inventory.selected.", new Vector4(this.blurSpread * 1923f / num, 367f, 1579f, 1814f));
						renderTexture2 = RenderTexture.GetTemporary(width / 7, height / 7, 1, HLBKCLPNHEB.format);
						Graphics.Blit(temporary, renderTexture2, this.FMKDDCNMHKK);
						RenderTexture.ReleaseTemporary(temporary);
					}
				}
				this.JHJAEILKJBA.SetFloat("#no", 1596f / (833f - this.intensity) - 899f);
				this.JHJAEILKJBA.SetFloat("_", 742f / (14f - this.blur) - 1115f);
				this.JHJAEILKJBA.SetTexture("ItemsCountText", renderTexture2);
				Graphics.Blit(HLBKCLPNHEB, renderTexture, this.JHJAEILKJBA, 1);
			}
			this.HMBBFDGOJFO.SetFloat("maps.", this.chromaticAberration);
			this.HMBBFDGOJFO.SetFloat("LevelEditor/CustomEventEditor-Text", this.axialAberration);
			this.HMBBFDGOJFO.SetVector("menu.playedpage", new Vector2(-this.blurDistance, this.blurDistance));
			this.HMBBFDGOJFO.SetFloat("Editor/", 95f / Mathf.Max(Mathf.Epsilon, this.luminanceDependency));
			if (flag)
			{
				renderTexture.wrapMode = TextureWrapMode.Repeat;
			}
			else
			{
				HLBKCLPNHEB.wrapMode = TextureWrapMode.Repeat;
			}
			Graphics.Blit((!flag) ? HLBKCLPNHEB : renderTexture, BMMLHGHKBNM, this.HMBBFDGOJFO, (this.mode != VignetteAndChromaticAberration.AberrationMode.Simple) ? 1 : 7);
			RenderTexture.ReleaseTemporary(renderTexture);
			RenderTexture.ReleaseTemporary(renderTexture2);
		}

		// Token: 0x04000EB4 RID: 3764
		public VignetteAndChromaticAberration.AberrationMode mode;

		// Token: 0x04000EB5 RID: 3765
		public float intensity = 0.036f;

		// Token: 0x04000EB6 RID: 3766
		public float chromaticAberration = 0.2f;

		// Token: 0x04000EB7 RID: 3767
		public float axialAberration = 0.5f;

		// Token: 0x04000EB8 RID: 3768
		public float blur;

		// Token: 0x04000EB9 RID: 3769
		public float blurSpread = 0.75f;

		// Token: 0x04000EBA RID: 3770
		public float luminanceDependency = 0.25f;

		// Token: 0x04000EBB RID: 3771
		public float blurDistance = 2.5f;

		// Token: 0x04000EBC RID: 3772
		public Shader vignetteShader;

		// Token: 0x04000EBD RID: 3773
		public Shader separableBlurShader;

		// Token: 0x04000EBE RID: 3774
		public Shader chromAberrationShader;

		// Token: 0x04000EBF RID: 3775
		private Material JHJAEILKJBA;

		// Token: 0x04000EC0 RID: 3776
		private Material FMKDDCNMHKK;

		// Token: 0x04000EC1 RID: 3777
		private Material HMBBFDGOJFO;

		// Token: 0x02000201 RID: 513
		public enum AberrationMode
		{
			// Token: 0x04000EC3 RID: 3779
			Simple,
			// Token: 0x04000EC4 RID: 3780
			Advanced
		}
	}
}
