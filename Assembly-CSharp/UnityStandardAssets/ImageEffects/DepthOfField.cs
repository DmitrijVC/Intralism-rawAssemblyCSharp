using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001DA RID: 474
	[AddComponentMenu("Image Effects/Camera/Depth of Field (Lens Blur, Scatter, DX11)")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class DepthOfField : PostEffectsBase
	{
		// Token: 0x06007C79 RID: 31865 RVA: 0x0028875C File Offset: 0x0028695C
		public virtual bool IILEKDNFOFI()
		{
			base.CKIAMHAKJOK(true);
			this.MGNGBHPPPOF = base.AJKPGPKKHHB(this.dofHdrShader, this.MGNGBHPPPOF);
			if (this.EAKIOBNBAMI && this.blurType == DepthOfField.BlurType.DX11)
			{
				this.KBMDEODBNHF = base.NODBMINMALP(this.dx11BokehShader, this.KBMDEODBNHF);
				this.LGHOEENEFGM();
			}
			if (!this.LMKGCBNNGLI)
			{
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C7A RID: 31866 RVA: 0x002887D5 File Offset: 0x002869D5
		private void CKOABIHHMAG()
		{
			if (this.PCODMENDEFB != null)
			{
				this.PCODMENDEFB.Release();
			}
			this.PCODMENDEFB = null;
			if (this.IJEGHMPOLKI != null)
			{
				this.IJEGHMPOLKI.Release();
			}
			this.IJEGHMPOLKI = null;
		}

		// Token: 0x06007C7B RID: 31867 RVA: 0x00288814 File Offset: 0x00286A14
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.aperture < 0f)
			{
				this.aperture = 0f;
			}
			if (this.maxBlurSize < 0.1f)
			{
				this.maxBlurSize = 0.1f;
			}
			this.focalSize = Mathf.Clamp(this.focalSize, 0f, 2f);
			this.PEFJJMKOCDF = Mathf.Max(this.maxBlurSize, 0f);
			this.IAJGMLGBOEN = ((!this.focalTransform) ? this.DBAHGBBNMOG(this.focalLength) : (this.HFLFJKGNJEG.WorldToViewportPoint(this.focalTransform.position).z / this.HFLFJKGNJEG.farClipPlane));
			this.MGNGBHPPPOF.SetVector("_CurveParams", new Vector4(1f, this.focalSize, 1f / (1f - this.aperture) - 1f, this.IAJGMLGBOEN));
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			float num = this.PEFJJMKOCDF * this.foregroundOverlap;
			if (this.visualizeFocus)
			{
				this.DLHKMBECOBL(HLBKCLPNHEB, true);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.MGNGBHPPPOF, 16);
			}
			else if (this.blurType == DepthOfField.BlurType.DX11 && this.KBMDEODBNHF)
			{
				if (this.highResolution)
				{
					this.PEFJJMKOCDF = ((this.PEFJJMKOCDF >= 0.1f) ? this.PEFJJMKOCDF : 0.1f);
					num = this.PEFJJMKOCDF * this.foregroundOverlap;
					renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, HLBKCLPNHEB.format);
					RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, HLBKCLPNHEB.format);
					this.DLHKMBECOBL(HLBKCLPNHEB, false);
					RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> 1, HLBKCLPNHEB.height >> 1, 0, HLBKCLPNHEB.format);
					RenderTexture temporary3 = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> 1, HLBKCLPNHEB.height >> 1, 0, HLBKCLPNHEB.format);
					Graphics.Blit(HLBKCLPNHEB, temporary2, this.MGNGBHPPPOF, 15);
					this.MGNGBHPPPOF.SetVector("_Offsets", new Vector4(0f, 1.5f, 0f, 1.5f));
					Graphics.Blit(temporary2, temporary3, this.MGNGBHPPPOF, 19);
					this.MGNGBHPPPOF.SetVector("_Offsets", new Vector4(1.5f, 0f, 0f, 1.5f));
					Graphics.Blit(temporary3, temporary2, this.MGNGBHPPPOF, 19);
					if (this.nearBlur)
					{
						Graphics.Blit(HLBKCLPNHEB, temporary3, this.MGNGBHPPPOF, 4);
					}
					this.KBMDEODBNHF.SetTexture("_BlurredColor", temporary2);
					this.KBMDEODBNHF.SetFloat("_SpawnHeuristic", this.dx11SpawnHeuristic);
					this.KBMDEODBNHF.SetVector("_BokehParams", new Vector4(this.dx11BokehScale, this.dx11BokehIntensity, Mathf.Clamp(this.dx11BokehThreshold, 0.005f, 4f), this.PEFJJMKOCDF));
					this.KBMDEODBNHF.SetTexture("_FgCocMask", (!this.nearBlur) ? null : temporary3);
					Graphics.SetRandomWriteTarget(1, this.IJEGHMPOLKI);
					Graphics.Blit(HLBKCLPNHEB, renderTexture, this.KBMDEODBNHF, 0);
					Graphics.ClearRandomWriteTargets();
					if (this.nearBlur)
					{
						this.MGNGBHPPPOF.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
						Graphics.Blit(temporary3, temporary2, this.MGNGBHPPPOF, 2);
						this.MGNGBHPPPOF.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
						Graphics.Blit(temporary2, temporary3, this.MGNGBHPPPOF, 2);
						Graphics.Blit(temporary3, renderTexture, this.MGNGBHPPPOF, 3);
					}
					Graphics.Blit(renderTexture, temporary, this.MGNGBHPPPOF, 20);
					this.MGNGBHPPPOF.SetVector("_Offsets", new Vector4(this.PEFJJMKOCDF, 0f, 0f, this.PEFJJMKOCDF));
					Graphics.Blit(renderTexture, HLBKCLPNHEB, this.MGNGBHPPPOF, 5);
					this.MGNGBHPPPOF.SetVector("_Offsets", new Vector4(0f, this.PEFJJMKOCDF, 0f, this.PEFJJMKOCDF));
					Graphics.Blit(HLBKCLPNHEB, temporary, this.MGNGBHPPPOF, 21);
					Graphics.SetRenderTarget(temporary);
					ComputeBuffer.CopyCount(this.IJEGHMPOLKI, this.PCODMENDEFB, 0);
					this.KBMDEODBNHF.SetBuffer("pointBuffer", this.IJEGHMPOLKI);
					this.KBMDEODBNHF.SetTexture("_MainTex", this.dx11BokehTexture);
					this.KBMDEODBNHF.SetVector("_Screen", new Vector3(1f / (1f * (float)HLBKCLPNHEB.width), 1f / (1f * (float)HLBKCLPNHEB.height), this.PEFJJMKOCDF));
					this.KBMDEODBNHF.SetPass(2);
					Graphics.DrawProceduralIndirect(MeshTopology.Points, this.PCODMENDEFB, 0);
					Graphics.Blit(temporary, BMMLHGHKBNM);
					RenderTexture.ReleaseTemporary(temporary);
					RenderTexture.ReleaseTemporary(temporary2);
					RenderTexture.ReleaseTemporary(temporary3);
				}
				else
				{
					renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> 1, HLBKCLPNHEB.height >> 1, 0, HLBKCLPNHEB.format);
					renderTexture2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> 1, HLBKCLPNHEB.height >> 1, 0, HLBKCLPNHEB.format);
					num = this.PEFJJMKOCDF * this.foregroundOverlap;
					this.DLHKMBECOBL(HLBKCLPNHEB, false);
					HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
					Graphics.Blit(HLBKCLPNHEB, renderTexture, this.MGNGBHPPPOF, 6);
					RenderTexture temporary2 = RenderTexture.GetTemporary(renderTexture.width >> 1, renderTexture.height >> 1, 0, renderTexture.format);
					RenderTexture temporary3 = RenderTexture.GetTemporary(renderTexture.width >> 1, renderTexture.height >> 1, 0, renderTexture.format);
					Graphics.Blit(renderTexture, temporary2, this.MGNGBHPPPOF, 15);
					this.MGNGBHPPPOF.SetVector("_Offsets", new Vector4(0f, 1.5f, 0f, 1.5f));
					Graphics.Blit(temporary2, temporary3, this.MGNGBHPPPOF, 19);
					this.MGNGBHPPPOF.SetVector("_Offsets", new Vector4(1.5f, 0f, 0f, 1.5f));
					Graphics.Blit(temporary3, temporary2, this.MGNGBHPPPOF, 19);
					RenderTexture renderTexture3 = null;
					if (this.nearBlur)
					{
						renderTexture3 = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> 1, HLBKCLPNHEB.height >> 1, 0, HLBKCLPNHEB.format);
						Graphics.Blit(HLBKCLPNHEB, renderTexture3, this.MGNGBHPPPOF, 4);
					}
					this.KBMDEODBNHF.SetTexture("_BlurredColor", temporary2);
					this.KBMDEODBNHF.SetFloat("_SpawnHeuristic", this.dx11SpawnHeuristic);
					this.KBMDEODBNHF.SetVector("_BokehParams", new Vector4(this.dx11BokehScale, this.dx11BokehIntensity, Mathf.Clamp(this.dx11BokehThreshold, 0.005f, 4f), this.PEFJJMKOCDF));
					this.KBMDEODBNHF.SetTexture("_FgCocMask", renderTexture3);
					Graphics.SetRandomWriteTarget(1, this.IJEGHMPOLKI);
					Graphics.Blit(renderTexture, renderTexture2, this.KBMDEODBNHF, 0);
					Graphics.ClearRandomWriteTargets();
					RenderTexture.ReleaseTemporary(temporary2);
					RenderTexture.ReleaseTemporary(temporary3);
					if (this.nearBlur)
					{
						this.MGNGBHPPPOF.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
						Graphics.Blit(renderTexture3, renderTexture, this.MGNGBHPPPOF, 2);
						this.MGNGBHPPPOF.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
						Graphics.Blit(renderTexture, renderTexture3, this.MGNGBHPPPOF, 2);
						Graphics.Blit(renderTexture3, renderTexture2, this.MGNGBHPPPOF, 3);
					}
					this.MGNGBHPPPOF.SetVector("_Offsets", new Vector4(this.PEFJJMKOCDF, 0f, 0f, this.PEFJJMKOCDF));
					Graphics.Blit(renderTexture2, renderTexture, this.MGNGBHPPPOF, 5);
					this.MGNGBHPPPOF.SetVector("_Offsets", new Vector4(0f, this.PEFJJMKOCDF, 0f, this.PEFJJMKOCDF));
					Graphics.Blit(renderTexture, renderTexture2, this.MGNGBHPPPOF, 5);
					Graphics.SetRenderTarget(renderTexture2);
					ComputeBuffer.CopyCount(this.IJEGHMPOLKI, this.PCODMENDEFB, 0);
					this.KBMDEODBNHF.SetBuffer("pointBuffer", this.IJEGHMPOLKI);
					this.KBMDEODBNHF.SetTexture("_MainTex", this.dx11BokehTexture);
					this.KBMDEODBNHF.SetVector("_Screen", new Vector3(1f / (1f * (float)renderTexture2.width), 1f / (1f * (float)renderTexture2.height), this.PEFJJMKOCDF));
					this.KBMDEODBNHF.SetPass(1);
					Graphics.DrawProceduralIndirect(MeshTopology.Points, this.PCODMENDEFB, 0);
					this.MGNGBHPPPOF.SetTexture("_LowRez", renderTexture2);
					this.MGNGBHPPPOF.SetTexture("_FgOverlap", renderTexture3);
					this.MGNGBHPPPOF.SetVector("_Offsets", 1f * (float)HLBKCLPNHEB.width / (1f * (float)renderTexture2.width) * this.PEFJJMKOCDF * Vector4.one);
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.MGNGBHPPPOF, 9);
					if (renderTexture3)
					{
						RenderTexture.ReleaseTemporary(renderTexture3);
					}
				}
			}
			else
			{
				HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
				if (this.highResolution)
				{
					this.PEFJJMKOCDF *= 2f;
				}
				this.DLHKMBECOBL(HLBKCLPNHEB, true);
				renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> 1, HLBKCLPNHEB.height >> 1, 0, HLBKCLPNHEB.format);
				renderTexture2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> 1, HLBKCLPNHEB.height >> 1, 0, HLBKCLPNHEB.format);
				int pass = (this.blurSampleCount != DepthOfField.BlurSampleCount.High && this.blurSampleCount != DepthOfField.BlurSampleCount.Medium) ? 11 : 17;
				if (this.highResolution)
				{
					this.MGNGBHPPPOF.SetVector("_Offsets", new Vector4(0f, this.PEFJJMKOCDF, 0.025f, this.PEFJJMKOCDF));
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.MGNGBHPPPOF, pass);
				}
				else
				{
					this.MGNGBHPPPOF.SetVector("_Offsets", new Vector4(0f, this.PEFJJMKOCDF, 0.1f, this.PEFJJMKOCDF));
					Graphics.Blit(HLBKCLPNHEB, renderTexture, this.MGNGBHPPPOF, 6);
					Graphics.Blit(renderTexture, renderTexture2, this.MGNGBHPPPOF, pass);
					this.MGNGBHPPPOF.SetTexture("_LowRez", renderTexture2);
					this.MGNGBHPPPOF.SetTexture("_FgOverlap", null);
					this.MGNGBHPPPOF.SetVector("_Offsets", Vector4.one * (1f * (float)HLBKCLPNHEB.width / (1f * (float)renderTexture2.width)) * this.PEFJJMKOCDF);
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.MGNGBHPPPOF, (this.blurSampleCount != DepthOfField.BlurSampleCount.High) ? 12 : 18);
				}
			}
			if (renderTexture)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
			if (renderTexture2)
			{
				RenderTexture.ReleaseTemporary(renderTexture2);
			}
		}

		// Token: 0x06007C7C RID: 31868 RVA: 0x0028931C File Offset: 0x0028751C
		private void EMAMCDFBGOA()
		{
			this.HFLFJKGNJEG = base.GetComponent<Camera>();
			this.HFLFJKGNJEG.depthTextureMode |= DepthTextureMode.None;
		}

		// Token: 0x06007C7D RID: 31869 RVA: 0x0028933D File Offset: 0x0028753D
		private void OnEnable()
		{
			this.HFLFJKGNJEG = base.GetComponent<Camera>();
			this.HFLFJKGNJEG.depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x06007C7E RID: 31870 RVA: 0x0028931C File Offset: 0x0028751C
		private void BDBKIEIIFPB()
		{
			this.HFLFJKGNJEG = base.GetComponent<Camera>();
			this.HFLFJKGNJEG.depthTextureMode |= DepthTextureMode.None;
		}

		// Token: 0x06007C7F RID: 31871 RVA: 0x00289360 File Offset: 0x00287560
		private void HNADGLKNADJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.aperture < 1734f)
			{
				this.aperture = 772f;
			}
			if (this.maxBlurSize < 1845f)
			{
				this.maxBlurSize = 160f;
			}
			this.focalSize = Mathf.Clamp(this.focalSize, 1042f, 521f);
			this.PEFJJMKOCDF = Mathf.Max(this.maxBlurSize, 919f);
			this.IAJGMLGBOEN = ((!this.focalTransform) ? this.BHFFAODNDKL(this.focalLength) : (this.HFLFJKGNJEG.WorldToViewportPoint(this.focalTransform.position).z / this.HFLFJKGNJEG.farClipPlane));
			this.MGNGBHPPPOF.SetVector("UseScanLineSize", new Vector4(63f, this.focalSize, 1601f / (902f - this.aperture) - 1742f, this.IAJGMLGBOEN));
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			float num = this.PEFJJMKOCDF * this.foregroundOverlap;
			if (this.visualizeFocus)
			{
				this.DLHKMBECOBL(HLBKCLPNHEB, false);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.MGNGBHPPPOF, 29);
			}
			else if (this.blurType == DepthOfField.BlurType.DiscBlur && this.KBMDEODBNHF)
			{
				if (this.highResolution)
				{
					this.PEFJJMKOCDF = ((this.PEFJJMKOCDF >= 1142f) ? this.PEFJJMKOCDF : 1142f);
					num = this.PEFJJMKOCDF * this.foregroundOverlap;
					renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, HLBKCLPNHEB.format);
					RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1, HLBKCLPNHEB.format);
					this.DLHKMBECOBL(HLBKCLPNHEB, true);
					RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> 0, HLBKCLPNHEB.height >> 1, 0, HLBKCLPNHEB.format);
					RenderTexture temporary3 = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> 0, HLBKCLPNHEB.height >> 1, 1, HLBKCLPNHEB.format);
					Graphics.Blit(HLBKCLPNHEB, temporary2, this.MGNGBHPPPOF, 82);
					this.MGNGBHPPPOF.SetVector("_Value2", new Vector4(1968f, 1196f, 1788f, 1820f));
					Graphics.Blit(temporary2, temporary3, this.MGNGBHPPPOF, -107);
					this.MGNGBHPPPOF.SetVector("OneHand", new Vector4(1753f, 1576f, 468f, 101f));
					Graphics.Blit(temporary3, temporary2, this.MGNGBHPPPOF, 41);
					if (this.nearBlur)
					{
						Graphics.Blit(HLBKCLPNHEB, temporary3, this.MGNGBHPPPOF, 8);
					}
					this.KBMDEODBNHF.SetTexture("Object ID. Case-Sensitive", temporary2);
					this.KBMDEODBNHF.SetFloat("source", this.dx11SpawnHeuristic);
					this.KBMDEODBNHF.SetVector("Drop_Far", new Vector4(this.dx11BokehScale, this.dx11BokehIntensity, Mathf.Clamp(this.dx11BokehThreshold, 1072f, 1041f), this.PEFJJMKOCDF));
					this.KBMDEODBNHF.SetTexture("_ScreenResolution", (!this.nearBlur) ? null : temporary3);
					Graphics.SetRandomWriteTarget(1, this.IJEGHMPOLKI);
					Graphics.Blit(HLBKCLPNHEB, renderTexture, this.KBMDEODBNHF, 0);
					Graphics.ClearRandomWriteTargets();
					if (this.nearBlur)
					{
						this.MGNGBHPPPOF.SetVector("DPADVER", new Vector4(715f, num, 961f, num));
						Graphics.Blit(temporary3, temporary2, this.MGNGBHPPPOF, 8);
						this.MGNGBHPPPOF.SetVector("_TimeX", new Vector4(num, 833f, 202f, num));
						Graphics.Blit(temporary2, temporary3, this.MGNGBHPPPOF, 8);
						Graphics.Blit(temporary3, renderTexture, this.MGNGBHPPPOF, 2);
					}
					Graphics.Blit(renderTexture, temporary, this.MGNGBHPPPOF, 122);
					this.MGNGBHPPPOF.SetVector("_ScreenResolution", new Vector4(this.PEFJJMKOCDF, 1465f, 53f, this.PEFJJMKOCDF));
					Graphics.Blit(renderTexture, HLBKCLPNHEB, this.MGNGBHPPPOF, 3);
					this.MGNGBHPPPOF.SetVector(" | ", new Vector4(238f, this.PEFJJMKOCDF, 174f, this.PEFJJMKOCDF));
					Graphics.Blit(HLBKCLPNHEB, temporary, this.MGNGBHPPPOF, 46);
					Graphics.SetRenderTarget(temporary);
					ComputeBuffer.CopyCount(this.IJEGHMPOLKI, this.PCODMENDEFB, 1);
					this.KBMDEODBNHF.SetBuffer("maps.", this.IJEGHMPOLKI);
					this.KBMDEODBNHF.SetTexture("_TimeX", this.dx11BokehTexture);
					this.KBMDEODBNHF.SetVector("_ScreenResolution", new Vector3(1216f / (287f * (float)HLBKCLPNHEB.width), 1970f / (451f * (float)HLBKCLPNHEB.height), this.PEFJJMKOCDF));
					this.KBMDEODBNHF.SetPass(2);
					Graphics.DrawProceduralIndirect(MeshTopology.Lines, this.PCODMENDEFB, 0);
					Graphics.Blit(temporary, BMMLHGHKBNM);
					RenderTexture.ReleaseTemporary(temporary);
					RenderTexture.ReleaseTemporary(temporary2);
					RenderTexture.ReleaseTemporary(temporary3);
				}
				else
				{
					renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> 1, HLBKCLPNHEB.height >> 0, 1, HLBKCLPNHEB.format);
					renderTexture2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> 1, HLBKCLPNHEB.height >> 1, 0, HLBKCLPNHEB.format);
					num = this.PEFJJMKOCDF * this.foregroundOverlap;
					this.DLHKMBECOBL(HLBKCLPNHEB, false);
					HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
					Graphics.Blit(HLBKCLPNHEB, renderTexture, this.MGNGBHPPPOF, 4);
					RenderTexture temporary2 = RenderTexture.GetTemporary(renderTexture.width >> 0, renderTexture.height >> 1, 1, renderTexture.format);
					RenderTexture temporary3 = RenderTexture.GetTemporary(renderTexture.width >> 0, renderTexture.height >> 1, 0, renderTexture.format);
					Graphics.Blit(renderTexture, temporary2, this.MGNGBHPPPOF, 117);
					this.MGNGBHPPPOF.SetVector("2hands", new Vector4(609f, 1139f, 1567f, 1581f));
					Graphics.Blit(temporary2, temporary3, this.MGNGBHPPPOF, -65);
					this.MGNGBHPPPOF.SetVector("_Value6", new Vector4(1569f, 701f, 129f, 723f));
					Graphics.Blit(temporary3, temporary2, this.MGNGBHPPPOF, 62);
					RenderTexture renderTexture3 = null;
					if (this.nearBlur)
					{
						renderTexture3 = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> 1, HLBKCLPNHEB.height >> 1, 1, HLBKCLPNHEB.format);
						Graphics.Blit(HLBKCLPNHEB, renderTexture3, this.MGNGBHPPPOF, 7);
					}
					this.KBMDEODBNHF.SetTexture(": ", temporary2);
					this.KBMDEODBNHF.SetFloat("_EmissionGain", this.dx11SpawnHeuristic);
					this.KBMDEODBNHF.SetVector("\\n", new Vector4(this.dx11BokehScale, this.dx11BokehIntensity, Mathf.Clamp(this.dx11BokehThreshold, 246f, 16f), this.PEFJJMKOCDF));
					this.KBMDEODBNHF.SetTexture("EventData0DropDownList", renderTexture3);
					Graphics.SetRandomWriteTarget(1, this.IJEGHMPOLKI);
					Graphics.Blit(renderTexture, renderTexture2, this.KBMDEODBNHF, 0);
					Graphics.ClearRandomWriteTargets();
					RenderTexture.ReleaseTemporary(temporary2);
					RenderTexture.ReleaseTemporary(temporary3);
					if (this.nearBlur)
					{
						this.MGNGBHPPPOF.SetVector("LevelNameInputField", new Vector4(1628f, num, 1035f, num));
						Graphics.Blit(renderTexture3, renderTexture, this.MGNGBHPPPOF, 8);
						this.MGNGBHPPPOF.SetVector("_Value2", new Vector4(num, 1031f, 17f, num));
						Graphics.Blit(renderTexture, renderTexture3, this.MGNGBHPPPOF, 2);
						Graphics.Blit(renderTexture3, renderTexture2, this.MGNGBHPPPOF, 2);
					}
					this.MGNGBHPPPOF.SetVector("_MainTex2", new Vector4(this.PEFJJMKOCDF, 1246f, 964f, this.PEFJJMKOCDF));
					Graphics.Blit(renderTexture2, renderTexture, this.MGNGBHPPPOF, 5);
					this.MGNGBHPPPOF.SetVector("yes", new Vector4(1106f, this.PEFJJMKOCDF, 1534f, this.PEFJJMKOCDF));
					Graphics.Blit(renderTexture, renderTexture2, this.MGNGBHPPPOF, 6);
					Graphics.SetRenderTarget(renderTexture2);
					ComputeBuffer.CopyCount(this.IJEGHMPOLKI, this.PCODMENDEFB, 0);
					this.KBMDEODBNHF.SetBuffer("_TimeX", this.IJEGHMPOLKI);
					this.KBMDEODBNHF.SetTexture("Set particles count per one beat", this.dx11BokehTexture);
					this.KBMDEODBNHF.SetVector("_FixDistance", new Vector3(905f / (29f * (float)renderTexture2.width), 68f / (889f * (float)renderTexture2.height), this.PEFJJMKOCDF));
					this.KBMDEODBNHF.SetPass(0);
					Graphics.DrawProceduralIndirect(MeshTopology.Lines, this.PCODMENDEFB, 0);
					this.MGNGBHPPPOF.SetTexture(" room(s)", renderTexture2);
					this.MGNGBHPPPOF.SetTexture("[LevelEditorScene] Creating new item...", renderTexture3);
					this.MGNGBHPPPOF.SetVector("/icon", 579f * (float)HLBKCLPNHEB.width / (95f * (float)renderTexture2.width) * this.PEFJJMKOCDF * Vector4.one);
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.MGNGBHPPPOF, -3);
					if (renderTexture3)
					{
						RenderTexture.ReleaseTemporary(renderTexture3);
					}
				}
			}
			else
			{
				HLBKCLPNHEB.filterMode = FilterMode.Point;
				if (this.highResolution)
				{
					this.PEFJJMKOCDF *= 617f;
				}
				this.DLHKMBECOBL(HLBKCLPNHEB, true);
				renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> 1, HLBKCLPNHEB.height >> 0, 1, HLBKCLPNHEB.format);
				renderTexture2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> 0, HLBKCLPNHEB.height >> 1, 0, HLBKCLPNHEB.format);
				int pass = (this.blurSampleCount != (DepthOfField.BlurSampleCount)8 && this.blurSampleCount != DepthOfField.BlurSampleCount.Medium) ? 84 : -9;
				if (this.highResolution)
				{
					this.MGNGBHPPPOF.SetVector("SpawnObj", new Vector4(253f, this.PEFJJMKOCDF, 376f, this.PEFJJMKOCDF));
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.MGNGBHPPPOF, pass);
				}
				else
				{
					this.MGNGBHPPPOF.SetVector("sfxVolume", new Vector4(1423f, this.PEFJJMKOCDF, 1856f, this.PEFJJMKOCDF));
					Graphics.Blit(HLBKCLPNHEB, renderTexture, this.MGNGBHPPPOF, 5);
					Graphics.Blit(renderTexture, renderTexture2, this.MGNGBHPPPOF, pass);
					this.MGNGBHPPPOF.SetTexture(". Client should be in a room. Current connectionStateDetailed: ", renderTexture2);
					this.MGNGBHPPPOF.SetTexture(" b.", null);
					this.MGNGBHPPPOF.SetVector("[MapsData] Found ", Vector4.one * (53f * (float)HLBKCLPNHEB.width / (1475f * (float)renderTexture2.width)) * this.PEFJJMKOCDF);
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.MGNGBHPPPOF, (this.blurSampleCount != (DepthOfField.BlurSampleCount)6) ? -1 : 106);
				}
			}
			if (renderTexture)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
			if (renderTexture2)
			{
				RenderTexture.ReleaseTemporary(renderTexture2);
			}
		}

		// Token: 0x06007C80 RID: 31872 RVA: 0x00289E68 File Offset: 0x00288068
		private void HNILMGEKDEC()
		{
			this.CKOABIHHMAG();
			if (this.MGNGBHPPPOF)
			{
				UnityEngine.Object.DestroyImmediate(this.MGNGBHPPPOF);
			}
			this.MGNGBHPPPOF = null;
			if (this.KBMDEODBNHF)
			{
				UnityEngine.Object.DestroyImmediate(this.KBMDEODBNHF);
			}
			this.KBMDEODBNHF = null;
		}

		// Token: 0x06007C81 RID: 31873 RVA: 0x00289EC0 File Offset: 0x002880C0
		private float BHFFAODNDKL(float JOCAFKLENDG)
		{
			return this.HFLFJKGNJEG.WorldToViewportPoint((JOCAFKLENDG - this.HFLFJKGNJEG.nearClipPlane) * this.HFLFJKGNJEG.transform.forward + this.HFLFJKGNJEG.transform.position).z / (this.HFLFJKGNJEG.farClipPlane - this.HFLFJKGNJEG.nearClipPlane);
		}

		// Token: 0x06007C82 RID: 31874 RVA: 0x00289F30 File Offset: 0x00288130
		private void DLHKMBECOBL(RenderTexture ODCOOEHPDPJ, bool BDAEIAMLIBD)
		{
			this.MGNGBHPPPOF.SetTexture("_FgOverlap", null);
			if (this.nearBlur && BDAEIAMLIBD)
			{
				int width = ODCOOEHPDPJ.width / 2;
				int height = ODCOOEHPDPJ.height / 2;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, ODCOOEHPDPJ.format);
				Graphics.Blit(ODCOOEHPDPJ, temporary, this.MGNGBHPPPOF, 4);
				float num = this.PEFJJMKOCDF * this.foregroundOverlap;
				this.MGNGBHPPPOF.SetVector("_Offsets", new Vector4(0f, num, 0f, num));
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, ODCOOEHPDPJ.format);
				Graphics.Blit(temporary, temporary2, this.MGNGBHPPPOF, 2);
				RenderTexture.ReleaseTemporary(temporary);
				this.MGNGBHPPPOF.SetVector("_Offsets", new Vector4(num, 0f, 0f, num));
				temporary = RenderTexture.GetTemporary(width, height, 0, ODCOOEHPDPJ.format);
				Graphics.Blit(temporary2, temporary, this.MGNGBHPPPOF, 2);
				RenderTexture.ReleaseTemporary(temporary2);
				this.MGNGBHPPPOF.SetTexture("_FgOverlap", temporary);
				ODCOOEHPDPJ.MarkRestoreExpected();
				Graphics.Blit(ODCOOEHPDPJ, ODCOOEHPDPJ, this.MGNGBHPPPOF, 13);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				ODCOOEHPDPJ.MarkRestoreExpected();
				Graphics.Blit(ODCOOEHPDPJ, ODCOOEHPDPJ, this.MGNGBHPPPOF, 0);
			}
		}

		// Token: 0x06007C83 RID: 31875 RVA: 0x0028A070 File Offset: 0x00288270
		private void HDEKADONMPE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.aperture < 677f)
			{
				this.aperture = 1048f;
			}
			if (this.maxBlurSize < 823f)
			{
				this.maxBlurSize = 1065f;
			}
			this.focalSize = Mathf.Clamp(this.focalSize, 1587f, 766f);
			this.PEFJJMKOCDF = Mathf.Max(this.maxBlurSize, 624f);
			this.IAJGMLGBOEN = ((!this.focalTransform) ? this.DBAHGBBNMOG(this.focalLength) : (this.HFLFJKGNJEG.WorldToViewportPoint(this.focalTransform.position).z / this.HFLFJKGNJEG.farClipPlane));
			this.MGNGBHPPPOF.SetVector("isBunned", new Vector4(230f, this.focalSize, 75f / (900f - this.aperture) - 454f, this.IAJGMLGBOEN));
			RenderTexture renderTexture = null;
			RenderTexture renderTexture2 = null;
			float num = this.PEFJJMKOCDF * this.foregroundOverlap;
			if (this.visualizeFocus)
			{
				this.FBIKJJFAFPO(HLBKCLPNHEB, false);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.MGNGBHPPPOF, 58);
			}
			else if (this.blurType == DepthOfField.BlurType.DX11 && this.KBMDEODBNHF)
			{
				if (this.highResolution)
				{
					this.PEFJJMKOCDF = ((this.PEFJJMKOCDF >= 587f) ? this.PEFJJMKOCDF : 1742f);
					num = this.PEFJJMKOCDF * this.foregroundOverlap;
					renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1, HLBKCLPNHEB.format);
					RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, HLBKCLPNHEB.format);
					this.FBIKJJFAFPO(HLBKCLPNHEB, true);
					RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> 0, HLBKCLPNHEB.height >> 1, 0, HLBKCLPNHEB.format);
					RenderTexture temporary3 = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> 1, HLBKCLPNHEB.height >> 0, 1, HLBKCLPNHEB.format);
					Graphics.Blit(HLBKCLPNHEB, temporary2, this.MGNGBHPPPOF, -21);
					this.MGNGBHPPPOF.SetVector("_TimeX", new Vector4(666f, 1609f, 944f, 304f));
					Graphics.Blit(temporary2, temporary3, this.MGNGBHPPPOF, 80);
					this.MGNGBHPPPOF.SetVector("]", new Vector4(102f, 847f, 785f, 594f));
					Graphics.Blit(temporary3, temporary2, this.MGNGBHPPPOF, -75);
					if (this.nearBlur)
					{
						Graphics.Blit(HLBKCLPNHEB, temporary3, this.MGNGBHPPPOF, 4);
					}
					this.KBMDEODBNHF.SetTexture("CameraFilterPack_Atmosphere_Rain_FX", temporary2);
					this.KBMDEODBNHF.SetFloat(",", this.dx11SpawnHeuristic);
					this.KBMDEODBNHF.SetVector("PLEASE WAIT", new Vector4(this.dx11BokehScale, this.dx11BokehIntensity, Mathf.Clamp(this.dx11BokehThreshold, 52f, 1216f), this.PEFJJMKOCDF));
					this.KBMDEODBNHF.SetTexture(".save", (!this.nearBlur) ? null : temporary3);
					Graphics.SetRandomWriteTarget(1, this.IJEGHMPOLKI);
					Graphics.Blit(HLBKCLPNHEB, renderTexture, this.KBMDEODBNHF, 1);
					Graphics.ClearRandomWriteTargets();
					if (this.nearBlur)
					{
						this.MGNGBHPPPOF.SetVector("_ScreenResolution", new Vector4(290f, num, 1035f, num));
						Graphics.Blit(temporary3, temporary2, this.MGNGBHPPPOF, 1);
						this.MGNGBHPPPOF.SetVector("achievements.21.completed.", new Vector4(num, 566f, 924f, num));
						Graphics.Blit(temporary2, temporary3, this.MGNGBHPPPOF, 1);
						Graphics.Blit(temporary3, renderTexture, this.MGNGBHPPPOF, 6);
					}
					Graphics.Blit(renderTexture, temporary, this.MGNGBHPPPOF, 88);
					this.MGNGBHPPPOF.SetVector(" argument(s): ", new Vector4(this.PEFJJMKOCDF, 740f, 1981f, this.PEFJJMKOCDF));
					Graphics.Blit(renderTexture, HLBKCLPNHEB, this.MGNGBHPPPOF, 0);
					this.MGNGBHPPPOF.SetVector("_Params1", new Vector4(1308f, this.PEFJJMKOCDF, 1986f, this.PEFJJMKOCDF));
					Graphics.Blit(HLBKCLPNHEB, temporary, this.MGNGBHPPPOF, 51);
					Graphics.SetRenderTarget(temporary);
					ComputeBuffer.CopyCount(this.IJEGHMPOLKI, this.PCODMENDEFB, 0);
					this.KBMDEODBNHF.SetBuffer("There is already a virtual axis named ", this.IJEGHMPOLKI);
					this.KBMDEODBNHF.SetTexture("_ScreenResolution", this.dx11BokehTexture);
					this.KBMDEODBNHF.SetVector("VoteUpToggle", new Vector3(1316f / (257f * (float)HLBKCLPNHEB.width), 922f / (1997f * (float)HLBKCLPNHEB.height), this.PEFJJMKOCDF));
					this.KBMDEODBNHF.SetPass(1);
					Graphics.DrawProceduralIndirect(MeshTopology.Triangles, this.PCODMENDEFB, 1);
					Graphics.Blit(temporary, BMMLHGHKBNM);
					RenderTexture.ReleaseTemporary(temporary);
					RenderTexture.ReleaseTemporary(temporary2);
					RenderTexture.ReleaseTemporary(temporary3);
				}
				else
				{
					renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> 0, HLBKCLPNHEB.height >> 1, 0, HLBKCLPNHEB.format);
					renderTexture2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> 0, HLBKCLPNHEB.height >> 1, 1, HLBKCLPNHEB.format);
					num = this.PEFJJMKOCDF * this.foregroundOverlap;
					this.DLHKMBECOBL(HLBKCLPNHEB, true);
					HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
					Graphics.Blit(HLBKCLPNHEB, renderTexture, this.MGNGBHPPPOF, 4);
					RenderTexture temporary2 = RenderTexture.GetTemporary(renderTexture.width >> 1, renderTexture.height >> 0, 1, renderTexture.format);
					RenderTexture temporary3 = RenderTexture.GetTemporary(renderTexture.width >> 0, renderTexture.height >> 0, 0, renderTexture.format);
					Graphics.Blit(renderTexture, temporary2, this.MGNGBHPPPOF, -84);
					this.MGNGBHPPPOF.SetVector("LevelEditor/CustomEventEditor-", new Vector4(1605f, 1832f, 577f, 1839f));
					Graphics.Blit(temporary2, temporary3, this.MGNGBHPPPOF, 101);
					this.MGNGBHPPPOF.SetVector("AudioSampler", new Vector4(76f, 1078f, 438f, 1999f));
					Graphics.Blit(temporary3, temporary2, this.MGNGBHPPPOF, 106);
					RenderTexture renderTexture3 = null;
					if (this.nearBlur)
					{
						renderTexture3 = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> 1, HLBKCLPNHEB.height >> 1, 1, HLBKCLPNHEB.format);
						Graphics.Blit(HLBKCLPNHEB, renderTexture3, this.MGNGBHPPPOF, 4);
					}
					this.KBMDEODBNHF.SetTexture("Anomaly_Distortion", temporary2);
					this.KBMDEODBNHF.SetFloat("_MainTex", this.dx11SpawnHeuristic);
					this.KBMDEODBNHF.SetVector("?", new Vector4(this.dx11BokehScale, this.dx11BokehIntensity, Mathf.Clamp(this.dx11BokehThreshold, 549f, 261f), this.PEFJJMKOCDF));
					this.KBMDEODBNHF.SetTexture("CameraFilterPack_TV_HorrorFX", renderTexture3);
					Graphics.SetRandomWriteTarget(1, this.IJEGHMPOLKI);
					Graphics.Blit(renderTexture, renderTexture2, this.KBMDEODBNHF, 1);
					Graphics.ClearRandomWriteTargets();
					RenderTexture.ReleaseTemporary(temporary2);
					RenderTexture.ReleaseTemporary(temporary3);
					if (this.nearBlur)
					{
						this.MGNGBHPPPOF.SetVector("Error: You're not logged into Steam!", new Vector4(1702f, num, 153f, num));
						Graphics.Blit(renderTexture3, renderTexture, this.MGNGBHPPPOF, 3);
						this.MGNGBHPPPOF.SetVector("_RotationMatrix", new Vector4(num, 901f, 1097f, num));
						Graphics.Blit(renderTexture, renderTexture3, this.MGNGBHPPPOF, 5);
						Graphics.Blit(renderTexture3, renderTexture2, this.MGNGBHPPPOF, 1);
					}
					this.MGNGBHPPPOF.SetVector("NEW_ACHIEVEMENT_1_21", new Vector4(this.PEFJJMKOCDF, 922f, 166f, this.PEFJJMKOCDF));
					Graphics.Blit(renderTexture2, renderTexture, this.MGNGBHPPPOF, 1);
					this.MGNGBHPPPOF.SetVector("Illegal view ID:", new Vector4(1791f, this.PEFJJMKOCDF, 1254f, this.PEFJJMKOCDF));
					Graphics.Blit(renderTexture, renderTexture2, this.MGNGBHPPPOF, 4);
					Graphics.SetRenderTarget(renderTexture2);
					ComputeBuffer.CopyCount(this.IJEGHMPOLKI, this.PCODMENDEFB, 1);
					this.KBMDEODBNHF.SetBuffer("position", this.IJEGHMPOLKI);
					this.KBMDEODBNHF.SetTexture("icon_border", this.dx11BokehTexture);
					this.KBMDEODBNHF.SetVector(",", new Vector3(1415f / (1737f * (float)renderTexture2.width), 1236f / (11f * (float)renderTexture2.height), this.PEFJJMKOCDF));
					this.KBMDEODBNHF.SetPass(0);
					Graphics.DrawProceduralIndirect(MeshTopology.LineStrip, this.PCODMENDEFB, 1);
					this.MGNGBHPPPOF.SetTexture("player.bluearc", renderTexture2);
					this.MGNGBHPPPOF.SetTexture("maps.", renderTexture3);
					this.MGNGBHPPPOF.SetVector("note.5", 1890f * (float)HLBKCLPNHEB.width / (1368f * (float)renderTexture2.width) * this.PEFJJMKOCDF * Vector4.one);
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.MGNGBHPPPOF, -127);
					if (renderTexture3)
					{
						RenderTexture.ReleaseTemporary(renderTexture3);
					}
				}
			}
			else
			{
				HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
				if (this.highResolution)
				{
					this.PEFJJMKOCDF *= 1673f;
				}
				this.FBIKJJFAFPO(HLBKCLPNHEB, true);
				renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> 0, HLBKCLPNHEB.height >> 0, 1, HLBKCLPNHEB.format);
				renderTexture2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width >> 1, HLBKCLPNHEB.height >> 0, 0, HLBKCLPNHEB.format);
				int pass = (this.blurSampleCount != (DepthOfField.BlurSampleCount)5 && this.blurSampleCount != DepthOfField.BlurSampleCount.Low) ? 25 : -68;
				if (this.highResolution)
				{
					this.MGNGBHPPPOF.SetVector("_BgColor", new Vector4(760f, this.PEFJJMKOCDF, 491f, this.PEFJJMKOCDF));
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.MGNGBHPPPOF, pass);
				}
				else
				{
					this.MGNGBHPPPOF.SetVector("' was created: ", new Vector4(383f, this.PEFJJMKOCDF, 1057f, this.PEFJJMKOCDF));
					Graphics.Blit(HLBKCLPNHEB, renderTexture, this.MGNGBHPPPOF, 3);
					Graphics.Blit(renderTexture, renderTexture2, this.MGNGBHPPPOF, pass);
					this.MGNGBHPPPOF.SetTexture("_Intensity", renderTexture2);
					this.MGNGBHPPPOF.SetTexture("#orderby:", null);
					this.MGNGBHPPPOF.SetVector("_Distortion", Vector4.one * (139f * (float)HLBKCLPNHEB.width / (1168f * (float)renderTexture2.width)) * this.PEFJJMKOCDF);
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.MGNGBHPPPOF, (this.blurSampleCount != (DepthOfField.BlurSampleCount)4) ? -10 : 60);
				}
			}
			if (renderTexture)
			{
				RenderTexture.ReleaseTemporary(renderTexture);
			}
			if (renderTexture2)
			{
				RenderTexture.ReleaseTemporary(renderTexture2);
			}
		}

		// Token: 0x06007C84 RID: 31876 RVA: 0x0028AB78 File Offset: 0x00288D78
		public override bool CheckResources()
		{
			base.NPOEJIDLJGK(true);
			this.MGNGBHPPPOF = base.EDFIBHNHAAB(this.dofHdrShader, this.MGNGBHPPPOF);
			if (this.EAKIOBNBAMI && this.blurType == DepthOfField.BlurType.DX11)
			{
				this.KBMDEODBNHF = base.EDFIBHNHAAB(this.dx11BokehShader, this.KBMDEODBNHF);
				this.LGHOEENEFGM();
			}
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C85 RID: 31877 RVA: 0x0028931C File Offset: 0x0028751C
		private void IBEAPBDAOCC()
		{
			this.HFLFJKGNJEG = base.GetComponent<Camera>();
			this.HFLFJKGNJEG.depthTextureMode |= DepthTextureMode.None;
		}

		// Token: 0x06007C87 RID: 31879 RVA: 0x0028AC88 File Offset: 0x00288E88
		private void OnDisable()
		{
			this.ADDLPNODDFM();
			if (this.MGNGBHPPPOF)
			{
				UnityEngine.Object.DestroyImmediate(this.MGNGBHPPPOF);
			}
			this.MGNGBHPPPOF = null;
			if (this.KBMDEODBNHF)
			{
				UnityEngine.Object.DestroyImmediate(this.KBMDEODBNHF);
			}
			this.KBMDEODBNHF = null;
		}

		// Token: 0x06007C88 RID: 31880 RVA: 0x0028ACE0 File Offset: 0x00288EE0
		private void FBIKJJFAFPO(RenderTexture ODCOOEHPDPJ, bool BDAEIAMLIBD)
		{
			this.MGNGBHPPPOF.SetTexture("SupportLogger ", null);
			if (this.nearBlur && BDAEIAMLIBD)
			{
				int width = ODCOOEHPDPJ.width / 3;
				int height = ODCOOEHPDPJ.height / 5;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, ODCOOEHPDPJ.format);
				Graphics.Blit(ODCOOEHPDPJ, temporary, this.MGNGBHPPPOF, 1);
				float num = this.PEFJJMKOCDF * this.foregroundOverlap;
				this.MGNGBHPPPOF.SetVector("st", new Vector4(863f, num, 1036f, num));
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, ODCOOEHPDPJ.format);
				Graphics.Blit(temporary, temporary2, this.MGNGBHPPPOF, 1);
				RenderTexture.ReleaseTemporary(temporary);
				this.MGNGBHPPPOF.SetVector("OnConnectedToMaster() was called by PUN. Now this client is connected and could join a room. Calling: PhotonNetwork.JoinRandomRoom();", new Vector4(num, 811f, 313f, num));
				temporary = RenderTexture.GetTemporary(width, height, 0, ODCOOEHPDPJ.format);
				Graphics.Blit(temporary2, temporary, this.MGNGBHPPPOF, 3);
				RenderTexture.ReleaseTemporary(temporary2);
				this.MGNGBHPPPOF.SetTexture("_SampleScale", temporary);
				ODCOOEHPDPJ.MarkRestoreExpected();
				Graphics.Blit(ODCOOEHPDPJ, ODCOOEHPDPJ, this.MGNGBHPPPOF, -84);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else
			{
				ODCOOEHPDPJ.MarkRestoreExpected();
				Graphics.Blit(ODCOOEHPDPJ, ODCOOEHPDPJ, this.MGNGBHPPPOF, 1);
			}
		}

		// Token: 0x06007C89 RID: 31881 RVA: 0x0028AE20 File Offset: 0x00289020
		private void LGHOEENEFGM()
		{
			if (this.PCODMENDEFB == null)
			{
				this.PCODMENDEFB = new ComputeBuffer(1, 16, ComputeBufferType.DrawIndirect);
				int[] data = new int[]
				{
					0,
					1,
					0,
					0
				};
				this.PCODMENDEFB.SetData(data);
			}
			if (this.IJEGHMPOLKI == null)
			{
				this.IJEGHMPOLKI = new ComputeBuffer(90000, 28, ComputeBufferType.Append);
			}
		}

		// Token: 0x06007C8A RID: 31882 RVA: 0x002887D5 File Offset: 0x002869D5
		private void ADDLPNODDFM()
		{
			if (this.PCODMENDEFB != null)
			{
				this.PCODMENDEFB.Release();
			}
			this.PCODMENDEFB = null;
			if (this.IJEGHMPOLKI != null)
			{
				this.IJEGHMPOLKI.Release();
			}
			this.IJEGHMPOLKI = null;
		}

		// Token: 0x06007C8B RID: 31883 RVA: 0x0028AE8C File Offset: 0x0028908C
		public virtual bool LPDMNDMCPCO()
		{
			base.IHMNPAHGNFF(true);
			this.MGNGBHPPPOF = base.ECNEGNMAMDE(this.dofHdrShader, this.MGNGBHPPPOF);
			if (this.EAKIOBNBAMI && this.blurType == DepthOfField.BlurType.DX11)
			{
				this.KBMDEODBNHF = base.EDFIBHNHAAB(this.dx11BokehShader, this.KBMDEODBNHF);
				this.LGHOEENEFGM();
			}
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C8C RID: 31884 RVA: 0x0028AF08 File Offset: 0x00289108
		public virtual bool APBDJCHNNEH()
		{
			base.KHNPMDDIJAJ(true);
			this.MGNGBHPPPOF = base.ECNEGNMAMDE(this.dofHdrShader, this.MGNGBHPPPOF);
			if (this.EAKIOBNBAMI && this.blurType == DepthOfField.BlurType.DiscBlur)
			{
				this.KBMDEODBNHF = base.AJKPGPKKHHB(this.dx11BokehShader, this.KBMDEODBNHF);
				this.LGHOEENEFGM();
			}
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007C8D RID: 31885 RVA: 0x0028AF84 File Offset: 0x00289184
		private float DBAHGBBNMOG(float JOCAFKLENDG)
		{
			return this.HFLFJKGNJEG.WorldToViewportPoint((JOCAFKLENDG - this.HFLFJKGNJEG.nearClipPlane) * this.HFLFJKGNJEG.transform.forward + this.HFLFJKGNJEG.transform.position).z / (this.HFLFJKGNJEG.farClipPlane - this.HFLFJKGNJEG.nearClipPlane);
		}

		// Token: 0x04000DA5 RID: 3493
		public bool visualizeFocus;

		// Token: 0x04000DA6 RID: 3494
		public float focalLength = 10f;

		// Token: 0x04000DA7 RID: 3495
		public float focalSize = 0.05f;

		// Token: 0x04000DA8 RID: 3496
		public float aperture = 0.5f;

		// Token: 0x04000DA9 RID: 3497
		public Transform focalTransform;

		// Token: 0x04000DAA RID: 3498
		public float maxBlurSize = 2f;

		// Token: 0x04000DAB RID: 3499
		public bool highResolution;

		// Token: 0x04000DAC RID: 3500
		public DepthOfField.BlurType blurType;

		// Token: 0x04000DAD RID: 3501
		public DepthOfField.BlurSampleCount blurSampleCount = DepthOfField.BlurSampleCount.High;

		// Token: 0x04000DAE RID: 3502
		public bool nearBlur;

		// Token: 0x04000DAF RID: 3503
		public float foregroundOverlap = 1f;

		// Token: 0x04000DB0 RID: 3504
		public Shader dofHdrShader;

		// Token: 0x04000DB1 RID: 3505
		private Material MGNGBHPPPOF;

		// Token: 0x04000DB2 RID: 3506
		public Shader dx11BokehShader;

		// Token: 0x04000DB3 RID: 3507
		private Material KBMDEODBNHF;

		// Token: 0x04000DB4 RID: 3508
		public float dx11BokehThreshold = 0.5f;

		// Token: 0x04000DB5 RID: 3509
		public float dx11SpawnHeuristic = 0.0875f;

		// Token: 0x04000DB6 RID: 3510
		public Texture2D dx11BokehTexture;

		// Token: 0x04000DB7 RID: 3511
		public float dx11BokehScale = 1.2f;

		// Token: 0x04000DB8 RID: 3512
		public float dx11BokehIntensity = 2.5f;

		// Token: 0x04000DB9 RID: 3513
		private float IAJGMLGBOEN = 10f;

		// Token: 0x04000DBA RID: 3514
		private ComputeBuffer PCODMENDEFB;

		// Token: 0x04000DBB RID: 3515
		private ComputeBuffer IJEGHMPOLKI;

		// Token: 0x04000DBC RID: 3516
		private float PEFJJMKOCDF = 1f;

		// Token: 0x04000DBD RID: 3517
		private Camera HFLFJKGNJEG;

		// Token: 0x020001DB RID: 475
		public enum BlurType
		{
			// Token: 0x04000DBF RID: 3519
			DiscBlur,
			// Token: 0x04000DC0 RID: 3520
			DX11
		}

		// Token: 0x020001DC RID: 476
		public enum BlurSampleCount
		{
			// Token: 0x04000DC2 RID: 3522
			Low,
			// Token: 0x04000DC3 RID: 3523
			Medium,
			// Token: 0x04000DC4 RID: 3524
			High
		}
	}
}
