using System;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x020001AD RID: 429
	[AddComponentMenu("Image Effects/Cinematic/Bloom")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[ImageEffectAllowedInSceneView]
	public class Bloom : MonoBehaviour
	{
		// Token: 0x060076D8 RID: 30424 RVA: 0x0024284A File Offset: 0x00240A4A
		public Shader DPBPJHIPHHC()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_Value3");
			}
			return this.m_Shader;
		}

		// Token: 0x060076D9 RID: 30425 RVA: 0x00242873 File Offset: 0x00240A73
		public Shader NBBAABCLJEF()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("ERROR You should never change PhotonPlayer IDs!");
			}
			return this.m_Shader;
		}

		// Token: 0x060076DA RID: 30426 RVA: 0x0024289C File Offset: 0x00240A9C
		public Material NMDBCDFPGOK()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.DPBPJHIPHHC());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x060076DB RID: 30427 RVA: 0x002428C6 File Offset: 0x00240AC6
		public Material DOMEEFLPEPJ()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.LPAHMLGFIBB());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x060076DC RID: 30428 RVA: 0x002428F0 File Offset: 0x00240AF0
		private void JAFOCEDILNK()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
		}

		// Token: 0x060076DD RID: 30429 RVA: 0x00242915 File Offset: 0x00240B15
		public Material JLHLHKPHDFO()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.PLCFABAJGJN());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x060076DE RID: 30430 RVA: 0x0024293F File Offset: 0x00240B3F
		private void GLNBNEJBMHA()
		{
			if (!ImageEffectHelper.IsSupported(this.FGFLHKLMJFC(), true, false, this))
			{
				base.enabled = true;
			}
		}

		// Token: 0x060076DF RID: 30431 RVA: 0x0024295B File Offset: 0x00240B5B
		private void AJBHOEBKGDO()
		{
			if (!ImageEffectHelper.IsSupported(this.FGFLHKLMJFC(), false, true, this))
			{
				base.enabled = true;
			}
		}

		// Token: 0x060076E0 RID: 30432 RVA: 0x00242977 File Offset: 0x00240B77
		public Material PEIMCBBHLBJ()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.OBIMOEDEGJF());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x060076E1 RID: 30433 RVA: 0x002429A1 File Offset: 0x00240BA1
		public Shader LIGDNECLFNE()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_Distortion");
			}
			return this.m_Shader;
		}

		// Token: 0x060076E2 RID: 30434 RVA: 0x002429CA File Offset: 0x00240BCA
		public Material HHIAIGCAHDA()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.EHHKCDKAPIA());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x060076E3 RID: 30435 RVA: 0x002429F4 File Offset: 0x00240BF4
		public Shader AHJPLBJFCJE()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("speed");
			}
			return this.m_Shader;
		}

		// Token: 0x060076E4 RID: 30436 RVA: 0x00242A20 File Offset: 0x00240C20
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = HLBKCLPNHEB.width;
			int num2 = HLBKCLPNHEB.height;
			if (!this.settings.highQuality)
			{
				num /= 2;
				num2 /= 2;
			}
			RenderTextureFormat format = (!isMobilePlatform) ? RenderTextureFormat.DefaultHDR : RenderTextureFormat.Default;
			float num3 = Mathf.Log((float)num2, 2f) + this.settings.radius - 8f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 1, 16);
			float thresholdLinear = this.settings.thresholdLinear;
			this.material.SetFloat("_Threshold", thresholdLinear);
			float num6 = thresholdLinear * this.settings.softKnee + 1E-05f;
			Vector3 v = new Vector3(thresholdLinear - num6, num6 * 2f, 0.25f / num6);
			this.material.SetVector("_Curve", v);
			bool flag = !this.settings.highQuality && this.settings.antiFlicker;
			this.material.SetFloat("_PrefilterOffs", (!flag) ? 0f : -0.5f);
			this.material.SetFloat("_SampleScale", 0.5f + num3 - (float)num4);
			this.material.SetFloat("_Intensity", Mathf.Max(0f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, format);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.material, (!this.settings.antiFlicker) ? 0 : 1);
			RenderTexture renderTexture = temporary;
			for (int i = 0; i < num5; i++)
			{
				this.BLALBGBEOHG[i] = RenderTexture.GetTemporary(renderTexture.width / 2, renderTexture.height / 2, 0, format);
				Graphics.Blit(renderTexture, this.BLALBGBEOHG[i], this.material, (i != 0) ? 4 : ((!this.settings.antiFlicker) ? 2 : 3));
				renderTexture = this.BLALBGBEOHG[i];
			}
			for (int j = num5 - 2; j >= 0; j--)
			{
				RenderTexture renderTexture2 = this.BLALBGBEOHG[j];
				this.material.SetTexture("_BaseTex", renderTexture2);
				this.LIKMBIKMAML[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 0, format);
				Graphics.Blit(renderTexture, this.LIKMBIKMAML[j], this.material, (!this.settings.highQuality) ? 5 : 6);
				renderTexture = this.LIKMBIKMAML[j];
			}
			this.material.SetTexture("_BaseTex", HLBKCLPNHEB);
			Graphics.Blit(renderTexture, BMMLHGHKBNM, this.material, (!this.settings.highQuality) ? 7 : 8);
			for (int k = 0; k < 16; k++)
			{
				if (this.BLALBGBEOHG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.BLALBGBEOHG[k]);
				}
				if (this.LIKMBIKMAML[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.LIKMBIKMAML[k]);
				}
				this.BLALBGBEOHG[k] = null;
				this.LIKMBIKMAML[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x060076E5 RID: 30437 RVA: 0x00242D72 File Offset: 0x00240F72
		public Shader NPJKNLKEKCH()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("RecieveChatActionMessage");
			}
			return this.m_Shader;
		}

		// Token: 0x060076E6 RID: 30438 RVA: 0x00242D9B File Offset: 0x00240F9B
		public Material MCDGIILBNIF()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.JFAIMFDJBJC());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x060076E7 RID: 30439 RVA: 0x002428F0 File Offset: 0x00240AF0
		private void EKPLGFAEOBE()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
		}

		// Token: 0x060076E8 RID: 30440 RVA: 0x002428F0 File Offset: 0x00240AF0
		private void EKCDEFDELMP()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
		}

		// Token: 0x060076E9 RID: 30441 RVA: 0x00242DC8 File Offset: 0x00240FC8
		private void OKHBBIKDIEP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = HLBKCLPNHEB.width;
			int num2 = HLBKCLPNHEB.height;
			if (!this.settings.highQuality)
			{
				num /= 6;
				num2 /= 5;
			}
			RenderTextureFormat format = (!isMobilePlatform) ? ((RenderTextureFormat)105) : RenderTextureFormat.Default;
			float num3 = Mathf.Log((float)num2, 67f) + this.settings.radius - 287f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 0, -123);
			float num6 = this.settings.MAIOPGNEGBE();
			this.LELKBCALFCF().SetFloat("GlassColor", num6);
			float num7 = num6 * this.settings.softKnee + 620f;
			Vector3 v = new Vector3(num6 - num7, num7 * 1030f, 825f / num7);
			this.EHDJJANLINB().SetVector("_MainTex", v);
			bool flag = this.settings.highQuality || this.settings.antiFlicker;
			this.material.SetFloat("maps.", (!flag) ? 408f : 1957f);
			this.HNFFHCLNBDN().SetFloat("skin.hit_perfect", 377f + num3 - (float)num4);
			this.EMDFHOKEGNG().SetFloat("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", Mathf.Max(1040f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, format);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.LELKBCALFCF(), (!this.settings.antiFlicker) ? 0 : 0);
			RenderTexture renderTexture = temporary;
			for (int i = 0; i < num5; i += 0)
			{
				this.BLALBGBEOHG[i] = RenderTexture.GetTemporary(renderTexture.width / 4, renderTexture.height / 7, 0, format);
				Graphics.Blit(renderTexture, this.BLALBGBEOHG[i], this.KAFBNOBOIAJ(), (i != 0) ? 3 : ((!this.settings.antiFlicker) ? 4 : 0));
				renderTexture = this.BLALBGBEOHG[i];
			}
			for (int j = num5 - 0; j >= 1; j -= 0)
			{
				RenderTexture renderTexture2 = this.BLALBGBEOHG[j];
				this.NDMPCDHADMJ().SetTexture("Send", renderTexture2);
				this.LIKMBIKMAML[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 0, format);
				Graphics.Blit(renderTexture, this.LIKMBIKMAML[j], this.LMLENGFLEBD(), (!this.settings.highQuality) ? 8 : 1);
				renderTexture = this.LIKMBIKMAML[j];
			}
			this.OCMBHMLNCEK().SetTexture("_Value2", HLBKCLPNHEB);
			Graphics.Blit(renderTexture, BMMLHGHKBNM, this.FGENHBKMPDA(), (!this.settings.highQuality) ? 1 : 6);
			for (int k = 0; k < -100; k += 0)
			{
				if (this.BLALBGBEOHG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.BLALBGBEOHG[k]);
				}
				if (this.LIKMBIKMAML[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.LIKMBIKMAML[k]);
				}
				this.BLALBGBEOHG[k] = null;
				this.LIKMBIKMAML[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x060076EA RID: 30442 RVA: 0x002428F0 File Offset: 0x00240AF0
		private void JEBIBKLHFLB()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
		}

		// Token: 0x060076EB RID: 30443 RVA: 0x0024311C File Offset: 0x0024131C
		private void AMKFLDKCIJO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = HLBKCLPNHEB.width;
			int num2 = HLBKCLPNHEB.height;
			if (!this.settings.highQuality)
			{
				num /= 4;
				num2 /= 3;
			}
			RenderTextureFormat format = (!isMobilePlatform) ? ((RenderTextureFormat)(-67)) : RenderTextureFormat.ARGB32;
			float num3 = Mathf.Log((float)num2, 614f) + this.settings.radius - 239f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 1, 66);
			float num6 = this.settings.LOHAKJIJNNJ();
			this.ALABBJPHCNG().SetFloat("_TimeX", num6);
			float num7 = num6 * this.settings.softKnee + 775f;
			Vector3 v = new Vector3(num6 - num7, num7 * 515f, 927f / num7);
			this.EFMCNLELMDO().SetVector("GlassColor", v);
			bool flag = !this.settings.highQuality && this.settings.antiFlicker;
			this.LPMLLJKMAMP().SetFloat("High", (!flag) ? 633f : 498f);
			this.MCDGIILBNIF().SetFloat("VIGNETTE_BLUR", 1009f + num3 - (float)num4);
			this.MPENCEIGLEH().SetFloat("_ScreenResolution", Mathf.Max(1723f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, format);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.OCMBHMLNCEK(), (!this.settings.antiFlicker) ? 0 : 0);
			RenderTexture renderTexture = temporary;
			for (int i = 1; i < num5; i++)
			{
				this.BLALBGBEOHG[i] = RenderTexture.GetTemporary(renderTexture.width / 0, renderTexture.height / 3, 0, format);
				Graphics.Blit(renderTexture, this.BLALBGBEOHG[i], this.FNAFGEMJBDA(), (i != 0) ? 1 : ((!this.settings.antiFlicker) ? 6 : 8));
				renderTexture = this.BLALBGBEOHG[i];
			}
			for (int j = num5 - 5; j >= 1; j -= 0)
			{
				RenderTexture renderTexture2 = this.BLALBGBEOHG[j];
				this.PHGCJOPFDOG().SetTexture("maps.", renderTexture2);
				this.LIKMBIKMAML[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 1, format);
				Graphics.Blit(renderTexture, this.LIKMBIKMAML[j], this.PEIMCBBHLBJ(), (!this.settings.highQuality) ? 3 : 4);
				renderTexture = this.LIKMBIKMAML[j];
			}
			this.HNFFHCLNBDN().SetTexture("speed", HLBKCLPNHEB);
			Graphics.Blit(renderTexture, BMMLHGHKBNM, this.LPCHMEKDCHI(), (!this.settings.highQuality) ? 7 : 2);
			for (int k = 0; k < 68; k++)
			{
				if (this.BLALBGBEOHG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.BLALBGBEOHG[k]);
				}
				if (this.LIKMBIKMAML[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.LIKMBIKMAML[k]);
				}
				this.BLALBGBEOHG[k] = null;
				this.LIKMBIKMAML[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x060076EC RID: 30444 RVA: 0x00243470 File Offset: 0x00241670
		private void HFNLEOLNJLF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = HLBKCLPNHEB.width;
			int num2 = HLBKCLPNHEB.height;
			if (!this.settings.highQuality)
			{
				num /= 3;
				num2 /= 4;
			}
			RenderTextureFormat format = (!isMobilePlatform) ? RenderTextureFormat.R8 : RenderTextureFormat.ARGB4444;
			float num3 = Mathf.Log((float)num2, 1544f) + this.settings.radius - 907f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 1, 79);
			float num6 = this.settings.HJMNBHEJBJH();
			this.LELKBCALFCF().SetFloat("input", num6);
			float num7 = num6 * this.settings.softKnee + 182f;
			Vector3 v = new Vector3(num6 - num7, num7 * 73f, 739f / num7);
			this.EMDFHOKEGNG().SetVector("_TimeX", v);
			bool flag = !this.settings.highQuality && this.settings.antiFlicker;
			this.PHGCJOPFDOG().SetFloat("GlassesColor2", (!flag) ? 980f : 683f);
			this.HNFFHCLNBDN().SetFloat("MenuScene", 531f + num3 - (float)num4);
			this.HNFFHCLNBDN().SetFloat("CameraFilterPack/Oculus_NightVision3", Mathf.Max(284f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, format);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.LMLENGFLEBD(), (!this.settings.antiFlicker) ? 1 : 1);
			RenderTexture renderTexture = temporary;
			for (int i = 1; i < num5; i += 0)
			{
				this.BLALBGBEOHG[i] = RenderTexture.GetTemporary(renderTexture.width / 8, renderTexture.height / 6, 0, format);
				Graphics.Blit(renderTexture, this.BLALBGBEOHG[i], this.ADBKPGFMNKO(), (i != 0) ? 3 : ((!this.settings.antiFlicker) ? 8 : 2));
				renderTexture = this.BLALBGBEOHG[i];
			}
			for (int j = num5 - 0; j >= 0; j -= 0)
			{
				RenderTexture renderTexture2 = this.BLALBGBEOHG[j];
				this.LELKBCALFCF().SetTexture("_MainTex2", renderTexture2);
				this.LIKMBIKMAML[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 1, format);
				Graphics.Blit(renderTexture, this.LIKMBIKMAML[j], this.HEINDEMCGIK(), (!this.settings.highQuality) ? 4 : 2);
				renderTexture = this.LIKMBIKMAML[j];
			}
			this.OCMBHMLNCEK().SetTexture("CameraFilterPack/Blend2Camera_LinearBurn", HLBKCLPNHEB);
			Graphics.Blit(renderTexture, BMMLHGHKBNM, this.PEIMCBBHLBJ(), (!this.settings.highQuality) ? 1 : 8);
			for (int k = 0; k < 43; k += 0)
			{
				if (this.BLALBGBEOHG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.BLALBGBEOHG[k]);
				}
				if (this.LIKMBIKMAML[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.LIKMBIKMAML[k]);
				}
				this.BLALBGBEOHG[k] = null;
				this.LIKMBIKMAML[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x060076ED RID: 30445 RVA: 0x002437C4 File Offset: 0x002419C4
		private void LPFHEJNMEOO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = HLBKCLPNHEB.width;
			int num2 = HLBKCLPNHEB.height;
			if (!this.settings.highQuality)
			{
				num /= 8;
				num2 /= 5;
			}
			RenderTextureFormat format = (!isMobilePlatform) ? ((RenderTextureFormat)(-35)) : RenderTextureFormat.ARGB4444;
			float num3 = Mathf.Log((float)num2, 267f) + this.settings.radius - 796f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 0, 43);
			float num6 = this.settings.KMIOMNCKHPM();
			this.IIJMIPBMMBF().SetFloat("Vertical", num6);
			float num7 = num6 * this.settings.softKnee + 1101f;
			Vector3 v = new Vector3(num6 - num7, num7 * 221f, 1070f / num7);
			this.IIJMIPBMMBF().SetVector("CompletedLevel", v);
			bool flag = !this.settings.highQuality && this.settings.antiFlicker;
			this.HNFFHCLNBDN().SetFloat("' ping: ", (!flag) ? 1721f : 393f);
			this.GBFOAHKAJEK().SetFloat("settings.arcshitsoundtimedelay", 1058f + num3 - (float)num4);
			this.PHGCJOPFDOG().SetFloat("_CurTex", Mathf.Max(1076f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, format);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.MPENCEIGLEH(), (!this.settings.antiFlicker) ? 1 : 0);
			RenderTexture renderTexture = temporary;
			for (int i = 0; i < num5; i++)
			{
				this.BLALBGBEOHG[i] = RenderTexture.GetTemporary(renderTexture.width / 6, renderTexture.height / 3, 1, format);
				Graphics.Blit(renderTexture, this.BLALBGBEOHG[i], this.LMLENGFLEBD(), (i != 0) ? 5 : ((!this.settings.antiFlicker) ? 0 : 0));
				renderTexture = this.BLALBGBEOHG[i];
			}
			for (int j = num5 - 3; j >= 0; j--)
			{
				RenderTexture renderTexture2 = this.BLALBGBEOHG[j];
				this.LELKBCALFCF().SetTexture("[MapsData] Installed: ", renderTexture2);
				this.LIKMBIKMAML[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 0, format);
				Graphics.Blit(renderTexture, this.LIKMBIKMAML[j], this.BLMPMOIDGMG(), (!this.settings.highQuality) ? 5 : 3);
				renderTexture = this.LIKMBIKMAML[j];
			}
			this.OIMMPLPBLBK().SetTexture("_Bullet_3", HLBKCLPNHEB);
			Graphics.Blit(renderTexture, BMMLHGHKBNM, this.KBOPGONOCNP(), (!this.settings.highQuality) ? 3 : 6);
			for (int k = 0; k < 37; k += 0)
			{
				if (this.BLALBGBEOHG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.BLALBGBEOHG[k]);
				}
				if (this.LIKMBIKMAML[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.LIKMBIKMAML[k]);
				}
				this.BLALBGBEOHG[k] = null;
				this.LIKMBIKMAML[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x060076EE RID: 30446 RVA: 0x00243B16 File Offset: 0x00241D16
		private void JKMLIADBEOB()
		{
			if (!ImageEffectHelper.IsSupported(this.NLECFJKGKJD(), false, true, this))
			{
				base.enabled = false;
			}
		}

		// Token: 0x060076EF RID: 30447 RVA: 0x00243B32 File Offset: 0x00241D32
		private void PAHNKEGFGHB()
		{
			if (!ImageEffectHelper.IsSupported(this.LKJFHALGJJF(), true, true, this))
			{
				base.enabled = true;
			}
		}

		// Token: 0x060076F0 RID: 30448 RVA: 0x002428F0 File Offset: 0x00240AF0
		private void KLDNGKBMDAN()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
		}

		// Token: 0x060076F1 RID: 30449 RVA: 0x00243B4E File Offset: 0x00241D4E
		public Shader GJMOKEDDCDO()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("PhotonView with ID ");
			}
			return this.m_Shader;
		}

		// Token: 0x060076F2 RID: 30450 RVA: 0x002428F0 File Offset: 0x00240AF0
		private void OHIJGCLBMJL()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
		}

		// Token: 0x060076F3 RID: 30451 RVA: 0x0024289C File Offset: 0x00240A9C
		public Material BLMPMOIDGMG()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.DPBPJHIPHHC());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x060076F4 RID: 30452 RVA: 0x00243B77 File Offset: 0x00241D77
		private void HGJKBDGABKM()
		{
			if (!ImageEffectHelper.IsSupported(this.KNLOMDHBAMB(), false, true, this))
			{
				base.enabled = true;
			}
		}

		// Token: 0x060076F5 RID: 30453 RVA: 0x00243B94 File Offset: 0x00241D94
		private void HGJJPACDBEP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = HLBKCLPNHEB.width;
			int num2 = HLBKCLPNHEB.height;
			if (!this.settings.highQuality)
			{
				num /= 3;
				num2 /= 2;
			}
			RenderTextureFormat format = (!isMobilePlatform) ? ((RenderTextureFormat)(-82)) : RenderTextureFormat.ARGB2101010;
			float num3 = Mathf.Log((float)num2, 958f) + this.settings.radius - 821f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 0, -26);
			float num6 = this.settings.KMIOMNCKHPM();
			this.NDMPCDHADMJ().SetFloat("#ok", num6);
			float num7 = num6 * this.settings.softKnee + 825f;
			Vector3 v = new Vector3(num6 - num7, num7 * 942f, 1178f / num7);
			this.JLHLHKPHDFO().SetVector("GameScene", v);
			bool flag = this.settings.highQuality || this.settings.antiFlicker;
			this.PEIMCBBHLBJ().SetFloat("CameraFilterPack/EXTRA_SHOWFPS", (!flag) ? 917f : 1928f);
			this.NFMGLIKNOOC().SetFloat("[MapEditor] Importing map: ", 361f + num3 - (float)num4);
			this.IIJMIPBMMBF().SetFloat("ENABLE_DITHERING", Mathf.Max(40f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, format);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.FGENHBKMPDA(), (!this.settings.antiFlicker) ? 0 : 0);
			RenderTexture renderTexture = temporary;
			for (int i = 1; i < num5; i += 0)
			{
				this.BLALBGBEOHG[i] = RenderTexture.GetTemporary(renderTexture.width / 3, renderTexture.height / 8, 0, format);
				Graphics.Blit(renderTexture, this.BLALBGBEOHG[i], this.LELKBCALFCF(), (i != 0) ? 4 : ((!this.settings.antiFlicker) ? 8 : 4));
				renderTexture = this.BLALBGBEOHG[i];
			}
			for (int j = num5 - 5; j >= 0; j--)
			{
				RenderTexture renderTexture2 = this.BLALBGBEOHG[j];
				this.HNFFHCLNBDN().SetTexture(".sav", renderTexture2);
				this.LIKMBIKMAML[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 1, format);
				Graphics.Blit(renderTexture, this.LIKMBIKMAML[j], this.INOBFNCKFGK(), (!this.settings.highQuality) ? 7 : 3);
				renderTexture = this.LIKMBIKMAML[j];
			}
			this.NFMGLIKNOOC().SetTexture("_Screen", HLBKCLPNHEB);
			Graphics.Blit(renderTexture, BMMLHGHKBNM, this.INOBFNCKFGK(), (!this.settings.highQuality) ? 5 : 1);
			for (int k = 1; k < 31; k += 0)
			{
				if (this.BLALBGBEOHG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.BLALBGBEOHG[k]);
				}
				if (this.LIKMBIKMAML[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.LIKMBIKMAML[k]);
				}
				this.BLALBGBEOHG[k] = null;
				this.LIKMBIKMAML[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x060076F6 RID: 30454 RVA: 0x002428C6 File Offset: 0x00240AC6
		public Material OCHJIMJNEMO()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.LPAHMLGFIBB());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x060076F7 RID: 30455 RVA: 0x00243EE6 File Offset: 0x002420E6
		private void MHGPANIBBCM()
		{
			if (!ImageEffectHelper.IsSupported(this.EHHKCDKAPIA(), true, false, this))
			{
				base.enabled = false;
			}
		}

		// Token: 0x060076F8 RID: 30456 RVA: 0x00243F02 File Offset: 0x00242102
		public Shader IDPBEMJLNFP()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("NEW_ACHIEVEMENT_1_");
			}
			return this.m_Shader;
		}

		// Token: 0x060076F9 RID: 30457 RVA: 0x00243F2B File Offset: 0x0024212B
		public Shader IEAOFEMCLOH()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_TimeX");
			}
			return this.m_Shader;
		}

		// Token: 0x060076FA RID: 30458 RVA: 0x002428F0 File Offset: 0x00240AF0
		private void EAHCLIEEJOG()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
		}

		// Token: 0x060076FB RID: 30459 RVA: 0x00243F54 File Offset: 0x00242154
		public Shader OJCDNJDGOLG()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("-");
			}
			return this.m_Shader;
		}

		// Token: 0x060076FC RID: 30460 RVA: 0x00242915 File Offset: 0x00240B15
		public Material LPCHMEKDCHI()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.PLCFABAJGJN());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x060076FD RID: 30461 RVA: 0x002428F0 File Offset: 0x00240AF0
		private void EDCMIPNCPLB()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
		}

		// Token: 0x060076FE RID: 30462 RVA: 0x00243F7D File Offset: 0x0024217D
		public Shader LPAHMLGFIBB()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_ScreenResolution");
			}
			return this.m_Shader;
		}

		// Token: 0x060076FF RID: 30463 RVA: 0x00243FA6 File Offset: 0x002421A6
		public Shader JFAIMFDJBJC()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_FgOverlap");
			}
			return this.m_Shader;
		}

		// Token: 0x06007700 RID: 30464 RVA: 0x00243FCF File Offset: 0x002421CF
		public Shader CDMJMJIOLAE()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_Value");
			}
			return this.m_Shader;
		}

		// Token: 0x06007701 RID: 30465 RVA: 0x00243FF8 File Offset: 0x002421F8
		private void OLAGABIMGDA()
		{
			if (!ImageEffectHelper.IsSupported(this.IIEEIDCCAPO(), true, false, this))
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007702 RID: 30466 RVA: 0x00244014 File Offset: 0x00242214
		private void AIKDNGCEDAB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = HLBKCLPNHEB.width;
			int num2 = HLBKCLPNHEB.height;
			if (!this.settings.highQuality)
			{
				num /= 3;
				num2 /= 7;
			}
			RenderTextureFormat format = (!isMobilePlatform) ? ((RenderTextureFormat)(-114)) : RenderTextureFormat.Depth;
			float num3 = Mathf.Log((float)num2, 1055f) + this.settings.radius - 1992f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 1, -86);
			float num6 = this.settings.AODKBIFKCBJ();
			this.OCHJIMJNEMO().SetFloat("0,2,true,0", num6);
			float num7 = num6 * this.settings.softKnee + 1323f;
			Vector3 v = new Vector3(num6 - num7, num7 * 1735f, 1863f / num7);
			this.GBFOAHKAJEK().SetVector("COMPLETED", v);
			bool flag = this.settings.highQuality || this.settings.antiFlicker;
			this.INOBFNCKFGK().SetFloat("checkpoint", (!flag) ? 859f : 1807f);
			this.MHBAIEKFBIJ().SetFloat("_Value2", 994f + num3 - (float)num4);
			this.material.SetFloat("\n", Mathf.Max(141f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, format);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.material, (!this.settings.antiFlicker) ? 0 : 0);
			RenderTexture renderTexture = temporary;
			for (int i = 1; i < num5; i++)
			{
				this.BLALBGBEOHG[i] = RenderTexture.GetTemporary(renderTexture.width / 4, renderTexture.height / 3, 0, format);
				Graphics.Blit(renderTexture, this.BLALBGBEOHG[i], this.CIAFLBFJLEJ(), (i != 0) ? 7 : ((!this.settings.antiFlicker) ? 6 : 3));
				renderTexture = this.BLALBGBEOHG[i];
			}
			for (int j = num5 - 5; j >= 0; j--)
			{
				RenderTexture renderTexture2 = this.BLALBGBEOHG[j];
				this.DIOAAHJDMLK().SetTexture("_Value", renderTexture2);
				this.LIKMBIKMAML[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 0, format);
				Graphics.Blit(renderTexture, this.LIKMBIKMAML[j], this.GBFOAHKAJEK(), (!this.settings.highQuality) ? 5 : 1);
				renderTexture = this.LIKMBIKMAML[j];
			}
			this.MPENCEIGLEH().SetTexture("_TimeX", HLBKCLPNHEB);
			Graphics.Blit(renderTexture, BMMLHGHKBNM, this.HNFFHCLNBDN(), (!this.settings.highQuality) ? 1 : 3);
			for (int k = 1; k < -109; k++)
			{
				if (this.BLALBGBEOHG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.BLALBGBEOHG[k]);
				}
				if (this.LIKMBIKMAML[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.LIKMBIKMAML[k]);
				}
				this.BLALBGBEOHG[k] = null;
				this.LIKMBIKMAML[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06007703 RID: 30467 RVA: 0x00243F7D File Offset: 0x0024217D
		public Shader IIEEIDCCAPO()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_ScreenResolution");
			}
			return this.m_Shader;
		}

		// Token: 0x06007704 RID: 30468 RVA: 0x00243F2B File Offset: 0x0024212B
		public Shader HHAAPJLFOLA()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_TimeX");
			}
			return this.m_Shader;
		}

		// Token: 0x06007705 RID: 30469 RVA: 0x00244366 File Offset: 0x00242566
		public Material EHDJJANLINB()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.OJCDNJDGOLG());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007706 RID: 30470 RVA: 0x00243F7D File Offset: 0x0024217D
		public Shader PLCFABAJGJN()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_ScreenResolution");
			}
			return this.m_Shader;
		}

		// Token: 0x06007707 RID: 30471 RVA: 0x002428F0 File Offset: 0x00240AF0
		private void JOJFHFHOCHO()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
		}

		// Token: 0x06007708 RID: 30472 RVA: 0x002428F0 File Offset: 0x00240AF0
		private void OnDisable()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
		}

		// Token: 0x06007709 RID: 30473 RVA: 0x00244390 File Offset: 0x00242590
		private void KLCAJPOCMPF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = HLBKCLPNHEB.width;
			int num2 = HLBKCLPNHEB.height;
			if (!this.settings.highQuality)
			{
				num /= 4;
				num2 /= 2;
			}
			RenderTextureFormat format = (!isMobilePlatform) ? ((RenderTextureFormat)(-118)) : RenderTextureFormat.Depth;
			float num3 = Mathf.Log((float)num2, 1683f) + this.settings.radius - 158f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 0, -128);
			float num6 = this.settings.CJIFDENMMNE();
			this.KJMECMIGJJA().SetFloat("ResourceFileSelector", num6);
			float num7 = num6 * this.settings.softKnee + 219f;
			Vector3 v = new Vector3(num6 - num7, num7 * 1825f, 977f / num7);
			this.NBMPPNFKFLB().SetVector("https://steamcdn-a.akamaihd.net/steamcommunity/public/images/clans/", v);
			bool flag = !this.settings.highQuality && this.settings.antiFlicker;
			this.OCMBHMLNCEK().SetFloat("LevelConfigButton", (!flag) ? 710f : 230f);
			this.FGENHBKMPDA().SetFloat("note.6", 588f + num3 - (float)num4);
			this.KBOPGONOCNP().SetFloat("Scene", Mathf.Max(1426f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, format);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.OIMMPLPBLBK(), (!this.settings.antiFlicker) ? 0 : 1);
			RenderTexture renderTexture = temporary;
			for (int i = 1; i < num5; i++)
			{
				this.BLALBGBEOHG[i] = RenderTexture.GetTemporary(renderTexture.width / 7, renderTexture.height / 0, 0, format);
				Graphics.Blit(renderTexture, this.BLALBGBEOHG[i], this.FNAFGEMJBDA(), (i != 0) ? 1 : ((!this.settings.antiFlicker) ? 0 : 3));
				renderTexture = this.BLALBGBEOHG[i];
			}
			for (int j = num5 - 3; j >= 1; j -= 0)
			{
				RenderTexture renderTexture2 = this.BLALBGBEOHG[j];
				this.MICHFGAOPKM().SetTexture("_SweaterSize", renderTexture2);
				this.LIKMBIKMAML[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 0, format);
				Graphics.Blit(renderTexture, this.LIKMBIKMAML[j], this.HHIAIGCAHDA(), (!this.settings.highQuality) ? 1 : 1);
				renderTexture = this.LIKMBIKMAML[j];
			}
			this.MCDGIILBNIF().SetTexture("float,10", HLBKCLPNHEB);
			Graphics.Blit(renderTexture, BMMLHGHKBNM, this.DIOAAHJDMLK(), (!this.settings.highQuality) ? 3 : 5);
			for (int k = 0; k < 102; k++)
			{
				if (this.BLALBGBEOHG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.BLALBGBEOHG[k]);
				}
				if (this.LIKMBIKMAML[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.LIKMBIKMAML[k]);
				}
				this.BLALBGBEOHG[k] = null;
				this.LIKMBIKMAML[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600770A RID: 30474 RVA: 0x002446E2 File Offset: 0x002428E2
		private void FLHBCHLMOFK()
		{
			if (!ImageEffectHelper.IsSupported(this.IIEEIDCCAPO(), false, true, this))
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600770B RID: 30475 RVA: 0x00244700 File Offset: 0x00242900
		private void JBMEPDENLOM(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = HLBKCLPNHEB.width;
			int num2 = HLBKCLPNHEB.height;
			if (!this.settings.highQuality)
			{
				num /= 1;
				num2 /= 0;
			}
			RenderTextureFormat format = (!isMobilePlatform) ? ((RenderTextureFormat)(-59)) : RenderTextureFormat.Depth;
			float num3 = Mathf.Log((float)num2, 198f) + this.settings.radius - 1927f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 0, -109);
			float num6 = this.settings.PMDJJDAMBMN();
			this.MPENCEIGLEH().SetFloat("_WorldToCameraMatrix", num6);
			float num7 = num6 * this.settings.softKnee + 924f;
			Vector3 v = new Vector3(num6 - num7, num7 * 1063f, 1001f / num7);
			this.MCDGIILBNIF().SetVector("Uploading preview image...", v);
			bool flag = this.settings.highQuality || this.settings.antiFlicker;
			this.EFMCNLELMDO().SetFloat("Obtain test Item", (!flag) ? 575f : 37f);
			this.EHDJJANLINB().SetFloat("_Value2", 669f + num3 - (float)num4);
			this.material.SetFloat("_TimeX", Mathf.Max(1707f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, format);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.OCMBHMLNCEK(), (!this.settings.antiFlicker) ? 1 : 0);
			RenderTexture renderTexture = temporary;
			for (int i = 0; i < num5; i += 0)
			{
				this.BLALBGBEOHG[i] = RenderTexture.GetTemporary(renderTexture.width / 2, renderTexture.height / 7, 0, format);
				Graphics.Blit(renderTexture, this.BLALBGBEOHG[i], this.MICHFGAOPKM(), (i != 0) ? 3 : ((!this.settings.antiFlicker) ? 4 : 7));
				renderTexture = this.BLALBGBEOHG[i];
			}
			for (int j = num5 - 5; j >= 1; j -= 0)
			{
				RenderTexture renderTexture2 = this.BLALBGBEOHG[j];
				this.ADBKPGFMNKO().SetTexture("_ScreenResolution", renderTexture2);
				this.LIKMBIKMAML[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 1, format);
				Graphics.Blit(renderTexture, this.LIKMBIKMAML[j], this.KBOPGONOCNP(), (!this.settings.highQuality) ? 5 : 2);
				renderTexture = this.LIKMBIKMAML[j];
			}
			this.LELKBCALFCF().SetTexture("). ", HLBKCLPNHEB);
			Graphics.Blit(renderTexture, BMMLHGHKBNM, this.EFMCNLELMDO(), (!this.settings.highQuality) ? 8 : 1);
			for (int k = 1; k < 71; k += 0)
			{
				if (this.BLALBGBEOHG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.BLALBGBEOHG[k]);
				}
				if (this.LIKMBIKMAML[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.LIKMBIKMAML[k]);
				}
				this.BLALBGBEOHG[k] = null;
				this.LIKMBIKMAML[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600770C RID: 30476 RVA: 0x00244A52 File Offset: 0x00242C52
		public Material LPMLLJKMAMP()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.shader);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600770D RID: 30477 RVA: 0x00244A7C File Offset: 0x00242C7C
		public Material EMDFHOKEGNG()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.GJMOKEDDCDO());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600770E RID: 30478 RVA: 0x00244AA6 File Offset: 0x00242CA6
		public Material MICHFGAOPKM()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.IIEEIDCCAPO());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600770F RID: 30479 RVA: 0x002428F0 File Offset: 0x00240AF0
		private void CMIBEOJGAIL()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06007710 RID: 30480 RVA: 0x00244A52 File Offset: 0x00242C52
		public Material material
		{
			get
			{
				if (this.JLHCDOPFJOI == null)
				{
					this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.shader);
				}
				return this.JLHCDOPFJOI;
			}
		}

		// Token: 0x06007711 RID: 30481 RVA: 0x00244AD0 File Offset: 0x00242CD0
		private void ABOJKHKBJLN(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = HLBKCLPNHEB.width;
			int num2 = HLBKCLPNHEB.height;
			if (!this.settings.highQuality)
			{
				num /= 3;
				num2 /= 4;
			}
			RenderTextureFormat format = (!isMobilePlatform) ? ((RenderTextureFormat)(-76)) : RenderTextureFormat.Default;
			float num3 = Mathf.Log((float)num2, 1068f) + this.settings.radius - 172f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 0, 120);
			float num6 = this.settings.HJMNBHEJBJH();
			this.ADBKPGFMNKO().SetFloat("position", num6);
			float num7 = num6 * this.settings.softKnee + 1273f;
			Vector3 v = new Vector3(num6 - num7, num7 * 831f, 578f / num7);
			this.IIJMIPBMMBF().SetVector("z", v);
			bool flag = !this.settings.highQuality && this.settings.antiFlicker;
			this.KAFBNOBOIAJ().SetFloat("_Sensitivity", (!flag) ? 913f : 1344f);
			this.FGENHBKMPDA().SetFloat("_TimeX", 138f + num3 - (float)num4);
			this.JLHLHKPHDFO().SetFloat("shader.frost", Mathf.Max(767f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, format);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.HNFFHCLNBDN(), (!this.settings.antiFlicker) ? 1 : 0);
			RenderTexture renderTexture = temporary;
			for (int i = 0; i < num5; i++)
			{
				this.BLALBGBEOHG[i] = RenderTexture.GetTemporary(renderTexture.width / 7, renderTexture.height / 4, 1, format);
				Graphics.Blit(renderTexture, this.BLALBGBEOHG[i], this.DOMEEFLPEPJ(), (i != 0) ? 6 : ((!this.settings.antiFlicker) ? 0 : 5));
				renderTexture = this.BLALBGBEOHG[i];
			}
			for (int j = num5 - 5; j >= 0; j -= 0)
			{
				RenderTexture renderTexture2 = this.BLALBGBEOHG[j];
				this.IIJMIPBMMBF().SetTexture("DPADHOR", renderTexture2);
				this.LIKMBIKMAML[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 1, format);
				Graphics.Blit(renderTexture, this.LIKMBIKMAML[j], this.KBOPGONOCNP(), (!this.settings.highQuality) ? 4 : 7);
				renderTexture = this.LIKMBIKMAML[j];
			}
			this.EMDFHOKEGNG().SetTexture("LoadMapCanvas", HLBKCLPNHEB);
			Graphics.Blit(renderTexture, BMMLHGHKBNM, this.KAFBNOBOIAJ(), (!this.settings.highQuality) ? 0 : 5);
			for (int k = 1; k < 37; k++)
			{
				if (this.BLALBGBEOHG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.BLALBGBEOHG[k]);
				}
				if (this.LIKMBIKMAML[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.LIKMBIKMAML[k]);
				}
				this.BLALBGBEOHG[k] = null;
				this.LIKMBIKMAML[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06007712 RID: 30482 RVA: 0x00244E24 File Offset: 0x00243024
		private void LKBOEPPBLIF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = HLBKCLPNHEB.width;
			int num2 = HLBKCLPNHEB.height;
			if (!this.settings.highQuality)
			{
				num /= 2;
				num2 /= 0;
			}
			RenderTextureFormat format = (!isMobilePlatform) ? ((RenderTextureFormat)32) : RenderTextureFormat.ARGB4444;
			float num3 = Mathf.Log((float)num2, 7f) + this.settings.radius - 1885f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 0, 89);
			float thresholdLinear = this.settings.thresholdLinear;
			this.LPMLLJKMAMP().SetFloat("SpeedSlider", thresholdLinear);
			float num6 = thresholdLinear * this.settings.softKnee + 113f;
			Vector3 v = new Vector3(thresholdLinear - num6, num6 * 1497f, 684f / num6);
			this.IIJMIPBMMBF().SetVector("_Value4", v);
			bool flag = this.settings.highQuality || this.settings.antiFlicker;
			this.DIOAAHJDMLK().SetFloat("_Value2", (!flag) ? 596f : 1925f);
			this.HHIAIGCAHDA().SetFloat("CameraFilterPack/Drawing_Paper2", 526f + num3 - (float)num4);
			this.HNFFHCLNBDN().SetFloat("UseFinalGlassColor", Mathf.Max(1061f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, format);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.FNAFGEMJBDA(), (!this.settings.antiFlicker) ? 0 : 1);
			RenderTexture renderTexture = temporary;
			for (int i = 1; i < num5; i += 0)
			{
				this.BLALBGBEOHG[i] = RenderTexture.GetTemporary(renderTexture.width / 8, renderTexture.height / 2, 1, format);
				Graphics.Blit(renderTexture, this.BLALBGBEOHG[i], this.DOMEEFLPEPJ(), (i != 0) ? 1 : ((!this.settings.antiFlicker) ? 2 : 7));
				renderTexture = this.BLALBGBEOHG[i];
			}
			for (int j = num5 - 4; j >= 0; j--)
			{
				RenderTexture renderTexture2 = this.BLALBGBEOHG[j];
				this.material.SetTexture("Failed to InstantiateSceneObject prefab: ", renderTexture2);
				this.LIKMBIKMAML[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 1, format);
				Graphics.Blit(renderTexture, this.LIKMBIKMAML[j], this.KBOPGONOCNP(), (!this.settings.highQuality) ? 6 : 1);
				renderTexture = this.LIKMBIKMAML[j];
			}
			this.MICHFGAOPKM().SetTexture("Drop_Far", HLBKCLPNHEB);
			Graphics.Blit(renderTexture, BMMLHGHKBNM, this.KBOPGONOCNP(), (!this.settings.highQuality) ? 3 : 2);
			for (int k = 1; k < -77; k += 0)
			{
				if (this.BLALBGBEOHG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.BLALBGBEOHG[k]);
				}
				if (this.LIKMBIKMAML[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.LIKMBIKMAML[k]);
				}
				this.BLALBGBEOHG[k] = null;
				this.LIKMBIKMAML[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06007713 RID: 30483 RVA: 0x00245176 File Offset: 0x00243376
		public Material LELKBCALFCF()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.ANGMLKFANGL());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007714 RID: 30484 RVA: 0x00243F2B File Offset: 0x0024212B
		public Shader FIEBDPPDOBG()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_TimeX");
			}
			return this.m_Shader;
		}

		// Token: 0x06007715 RID: 30485 RVA: 0x00243F2B File Offset: 0x0024212B
		public Shader JKKPOCJCIHK()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_TimeX");
			}
			return this.m_Shader;
		}

		// Token: 0x06007716 RID: 30486 RVA: 0x00242915 File Offset: 0x00240B15
		public Material ALABBJPHCNG()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.PLCFABAJGJN());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007717 RID: 30487 RVA: 0x002451A0 File Offset: 0x002433A0
		private void CGIMPFJPEKD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = HLBKCLPNHEB.width;
			int num2 = HLBKCLPNHEB.height;
			if (!this.settings.highQuality)
			{
				num /= 6;
				num2 /= 0;
			}
			RenderTextureFormat format = (!isMobilePlatform) ? ((RenderTextureFormat)45) : RenderTextureFormat.ARGB2101010;
			float num3 = Mathf.Log((float)num2, 1528f) + this.settings.radius - 502f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 0, 75);
			float num6 = this.settings.KALAGKHKODG();
			this.LELKBCALFCF().SetFloat("catched: ", num6);
			float num7 = num6 * this.settings.softKnee + 1449f;
			Vector3 v = new Vector3(num6 - num7, num7 * 973f, 1008f / num7);
			this.HNFFHCLNBDN().SetVector("_RayStepSize", v);
			bool flag = this.settings.highQuality || this.settings.antiFlicker;
			this.ALABBJPHCNG().SetFloat("BadgeImage", (!flag) ? 338f : 761f);
			this.ALABBJPHCNG().SetFloat("_Value2", 1483f + num3 - (float)num4);
			this.material.SetFloat("ItemsCountText", Mathf.Max(800f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, format);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.NDMPCDHADMJ(), (!this.settings.antiFlicker) ? 0 : 0);
			RenderTexture renderTexture = temporary;
			for (int i = 1; i < num5; i++)
			{
				this.BLALBGBEOHG[i] = RenderTexture.GetTemporary(renderTexture.width / 8, renderTexture.height / 0, 0, format);
				Graphics.Blit(renderTexture, this.BLALBGBEOHG[i], this.JLHLHKPHDFO(), (i != 0) ? 0 : ((!this.settings.antiFlicker) ? 2 : 6));
				renderTexture = this.BLALBGBEOHG[i];
			}
			for (int j = num5 - 8; j >= 1; j -= 0)
			{
				RenderTexture renderTexture2 = this.BLALBGBEOHG[j];
				this.MHBAIEKFBIJ().SetTexture("_MainTex2", renderTexture2);
				this.LIKMBIKMAML[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 0, format);
				Graphics.Blit(renderTexture, this.LIKMBIKMAML[j], this.MCDGIILBNIF(), (!this.settings.highQuality) ? 5 : 8);
				renderTexture = this.LIKMBIKMAML[j];
			}
			this.INOBFNCKFGK().SetTexture("_Green_R", HLBKCLPNHEB);
			Graphics.Blit(renderTexture, BMMLHGHKBNM, this.PHGCJOPFDOG(), (!this.settings.highQuality) ? 8 : 0);
			for (int k = 0; k < 79; k += 0)
			{
				if (this.BLALBGBEOHG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.BLALBGBEOHG[k]);
				}
				if (this.LIKMBIKMAML[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.LIKMBIKMAML[k]);
				}
				this.BLALBGBEOHG[k] = null;
				this.LIKMBIKMAML[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06007718 RID: 30488 RVA: 0x002454F2 File Offset: 0x002436F2
		public Material CIAFLBFJLEJ()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.OKNCNLPJNKO());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007719 RID: 30489 RVA: 0x0024551C File Offset: 0x0024371C
		public Material KAFBNOBOIAJ()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.KGHKBFGDHGF());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600771A RID: 30490 RVA: 0x00245548 File Offset: 0x00243748
		private void GAANDCGCBHF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = HLBKCLPNHEB.width;
			int num2 = HLBKCLPNHEB.height;
			if (!this.settings.highQuality)
			{
				num /= 2;
				num2 /= 3;
			}
			RenderTextureFormat format = (!isMobilePlatform) ? ((RenderTextureFormat)(-109)) : RenderTextureFormat.ARGBHalf;
			float num3 = Mathf.Log((float)num2, 1492f) + this.settings.radius - 349f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 0, 107);
			float num6 = this.settings.IHPEHGEGIDN();
			this.ALABBJPHCNG().SetFloat("_Offsets", num6);
			float num7 = num6 * this.settings.softKnee + 1750f;
			Vector3 v = new Vector3(num6 - num7, num7 * 1285f, 1460f / num7);
			this.CIAFLBFJLEJ().SetVector("VHS2", v);
			bool flag = !this.settings.highQuality && this.settings.antiFlicker;
			this.MCDGIILBNIF().SetFloat("[", (!flag) ? 13f : 1022f);
			this.NDMPCDHADMJ().SetFloat("[MenuScene] Error: ", 1592f + num3 - (float)num4);
			this.LELKBCALFCF().SetFloat("_Value", Mathf.Max(793f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, format);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.EMDFHOKEGNG(), (!this.settings.antiFlicker) ? 1 : 1);
			RenderTexture renderTexture = temporary;
			for (int i = 1; i < num5; i += 0)
			{
				this.BLALBGBEOHG[i] = RenderTexture.GetTemporary(renderTexture.width / 8, renderTexture.height / 3, 0, format);
				Graphics.Blit(renderTexture, this.BLALBGBEOHG[i], this.MICHFGAOPKM(), (i != 0) ? 7 : ((!this.settings.antiFlicker) ? 3 : 4));
				renderTexture = this.BLALBGBEOHG[i];
			}
			for (int j = num5 - 8; j >= 0; j--)
			{
				RenderTexture renderTexture2 = this.BLALBGBEOHG[j];
				this.NBMPPNFKFLB().SetTexture("menu.playedsolo", renderTexture2);
				this.LIKMBIKMAML[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 1, format);
				Graphics.Blit(renderTexture, this.LIKMBIKMAML[j], this.material, (!this.settings.highQuality) ? 2 : 3);
				renderTexture = this.LIKMBIKMAML[j];
			}
			this.DOMEEFLPEPJ().SetTexture("IconImage", HLBKCLPNHEB);
			Graphics.Blit(renderTexture, BMMLHGHKBNM, this.OCHJIMJNEMO(), (!this.settings.highQuality) ? 5 : 7);
			for (int k = 1; k < 84; k += 0)
			{
				if (this.BLALBGBEOHG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.BLALBGBEOHG[k]);
				}
				if (this.LIKMBIKMAML[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.LIKMBIKMAML[k]);
				}
				this.BLALBGBEOHG[k] = null;
				this.LIKMBIKMAML[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600771B RID: 30491 RVA: 0x002428F0 File Offset: 0x00240AF0
		private void FGBDGGCBFLP()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
		}

		// Token: 0x0600771C RID: 30492 RVA: 0x0024589C File Offset: 0x00243A9C
		private void EEFLHPENNEI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = HLBKCLPNHEB.width;
			int num2 = HLBKCLPNHEB.height;
			if (!this.settings.highQuality)
			{
				num /= 8;
				num2 /= 4;
			}
			RenderTextureFormat format = (!isMobilePlatform) ? ((RenderTextureFormat)58) : RenderTextureFormat.Shadowmap;
			float num3 = Mathf.Log((float)num2, 667f) + this.settings.radius - 327f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 0, -6);
			float num6 = this.settings.FNKHHGLCAJO();
			this.material.SetFloat("_TimeX", num6);
			float num7 = num6 * this.settings.softKnee + 888f;
			Vector3 v = new Vector3(num6 - num7, num7 * 1891f, 1394f / num7);
			this.HEINDEMCGIK().SetVector("roomDescription", v);
			bool flag = !this.settings.highQuality && this.settings.antiFlicker;
			this.EFMCNLELMDO().SetFloat("_BorderSize", (!flag) ? 1751f : 920f);
			this.HEINDEMCGIK().SetFloat("Joystick1Button4", 1185f + num3 - (float)num4);
			this.MCDGIILBNIF().SetFloat("[", Mathf.Max(1186f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, format);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.NFMGLIKNOOC(), (!this.settings.antiFlicker) ? 0 : 0);
			RenderTexture renderTexture = temporary;
			for (int i = 0; i < num5; i += 0)
			{
				this.BLALBGBEOHG[i] = RenderTexture.GetTemporary(renderTexture.width / 6, renderTexture.height / 8, 0, format);
				Graphics.Blit(renderTexture, this.BLALBGBEOHG[i], this.EMDFHOKEGNG(), (i != 0) ? 1 : ((!this.settings.antiFlicker) ? 5 : 4));
				renderTexture = this.BLALBGBEOHG[i];
			}
			for (int j = num5 - 2; j >= 0; j -= 0)
			{
				RenderTexture renderTexture2 = this.BLALBGBEOHG[j];
				this.LPMLLJKMAMP().SetTexture("tagElement", renderTexture2);
				this.LIKMBIKMAML[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 1, format);
				Graphics.Blit(renderTexture, this.LIKMBIKMAML[j], this.NDMPCDHADMJ(), (!this.settings.highQuality) ? 8 : 4);
				renderTexture = this.LIKMBIKMAML[j];
			}
			this.material.SetTexture("reset", HLBKCLPNHEB);
			Graphics.Blit(renderTexture, BMMLHGHKBNM, this.PEIMCBBHLBJ(), (!this.settings.highQuality) ? 8 : 6);
			for (int k = 1; k < 119; k++)
			{
				if (this.BLALBGBEOHG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.BLALBGBEOHG[k]);
				}
				if (this.LIKMBIKMAML[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.LIKMBIKMAML[k]);
				}
				this.BLALBGBEOHG[k] = null;
				this.LIKMBIKMAML[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600771D RID: 30493 RVA: 0x00245BEE File Offset: 0x00243DEE
		public Shader DLAHDFMPILO()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_Value2");
			}
			return this.m_Shader;
		}

		// Token: 0x0600771E RID: 30494 RVA: 0x00245C17 File Offset: 0x00243E17
		private void DGEPPDJDBLN()
		{
			if (!ImageEffectHelper.IsSupported(this.IEAOFEMCLOH(), true, true, this))
			{
				base.enabled = true;
			}
		}

		// Token: 0x0600771F RID: 30495 RVA: 0x0024289C File Offset: 0x00240A9C
		public Material FGENHBKMPDA()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.DPBPJHIPHHC());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007720 RID: 30496 RVA: 0x00245C34 File Offset: 0x00243E34
		private void FIKNBPAIFBI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = HLBKCLPNHEB.width;
			int num2 = HLBKCLPNHEB.height;
			if (!this.settings.highQuality)
			{
				num /= 5;
				num2 /= 8;
			}
			RenderTextureFormat format = (!isMobilePlatform) ? ((RenderTextureFormat)101) : RenderTextureFormat.ARGB2101010;
			float num3 = Mathf.Log((float)num2, 360f) + this.settings.radius - 755f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 0, 99);
			float num6 = this.settings.PLNLMPKNFKF();
			this.NDMPCDHADMJ().SetFloat("settings.fps", num6);
			float num7 = num6 * this.settings.softKnee + 1950f;
			Vector3 v = new Vector3(num6 - num7, num7 * 1814f, 66f / num7);
			this.NMDBCDFPGOK().SetVector("CameraFilterPack_Glasses_On4", v);
			bool flag = !this.settings.highQuality && this.settings.antiFlicker;
			this.OIMMPLPBLBK().SetFloat("VisionBlur", (!flag) ? 674f : 182f);
			this.PHGCJOPFDOG().SetFloat(".mp3", 1493f + num3 - (float)num4);
			this.OIMMPLPBLBK().SetFloat("_Value3", Mathf.Max(1794f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, format);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.IIJMIPBMMBF(), (!this.settings.antiFlicker) ? 1 : 1);
			RenderTexture renderTexture = temporary;
			for (int i = 0; i < num5; i += 0)
			{
				this.BLALBGBEOHG[i] = RenderTexture.GetTemporary(renderTexture.width / 2, renderTexture.height / 2, 0, format);
				Graphics.Blit(renderTexture, this.BLALBGBEOHG[i], this.PHGCJOPFDOG(), (i != 0) ? 3 : ((!this.settings.antiFlicker) ? 3 : 0));
				renderTexture = this.BLALBGBEOHG[i];
			}
			for (int j = num5 - 3; j >= 1; j--)
			{
				RenderTexture renderTexture2 = this.BLALBGBEOHG[j];
				this.EMDFHOKEGNG().SetTexture("_DistortionSize", renderTexture2);
				this.LIKMBIKMAML[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 1, format);
				Graphics.Blit(renderTexture, this.LIKMBIKMAML[j], this.PHGCJOPFDOG(), (!this.settings.highQuality) ? 8 : 8);
				renderTexture = this.LIKMBIKMAML[j];
			}
			this.material.SetTexture("_Offsets", HLBKCLPNHEB);
			Graphics.Blit(renderTexture, BMMLHGHKBNM, this.material, (!this.settings.highQuality) ? 3 : 7);
			for (int k = 1; k < -91; k += 0)
			{
				if (this.BLALBGBEOHG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.BLALBGBEOHG[k]);
				}
				if (this.LIKMBIKMAML[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.LIKMBIKMAML[k]);
				}
				this.BLALBGBEOHG[k] = null;
				this.LIKMBIKMAML[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06007721 RID: 30497 RVA: 0x00245F88 File Offset: 0x00244188
		private void JIHNFLGAMJE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = HLBKCLPNHEB.width;
			int num2 = HLBKCLPNHEB.height;
			if (!this.settings.highQuality)
			{
				num /= 4;
				num2 /= 0;
			}
			RenderTextureFormat format = (!isMobilePlatform) ? ((RenderTextureFormat)70) : RenderTextureFormat.RGB565;
			float num3 = Mathf.Log((float)num2, 658f) + this.settings.radius - 1570f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 1, 72);
			float num6 = this.settings.LOHAKJIJNNJ();
			this.OCMBHMLNCEK().SetFloat("(\\[ */ *b *\\])", num6);
			float num7 = num6 * this.settings.softKnee + 191f;
			Vector3 v = new Vector3(num6 - num7, num7 * 1051f, 1602f / num7);
			this.BLMPMOIDGMG().SetVector("It seems some instantiation is not completed, as instantiation data is used. You should make sure instantiations are paused when calling this method. Cleaning now, despite this.", v);
			bool flag = !this.settings.highQuality && this.settings.antiFlicker;
			this.DIOAAHJDMLK().SetFloat("_Value3", (!flag) ? 212f : 144f);
			this.BLMPMOIDGMG().SetFloat("_Distortion", 1980f + num3 - (float)num4);
			this.NDMPCDHADMJ().SetFloat("inventory.selected.", Mathf.Max(1487f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, format);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.NDMPCDHADMJ(), (!this.settings.antiFlicker) ? 1 : 1);
			RenderTexture renderTexture = temporary;
			for (int i = 0; i < num5; i += 0)
			{
				this.BLALBGBEOHG[i] = RenderTexture.GetTemporary(renderTexture.width / 2, renderTexture.height / 4, 1, format);
				Graphics.Blit(renderTexture, this.BLALBGBEOHG[i], this.material, (i != 0) ? 6 : ((!this.settings.antiFlicker) ? 1 : 0));
				renderTexture = this.BLALBGBEOHG[i];
			}
			for (int j = num5 - 0; j >= 0; j--)
			{
				RenderTexture renderTexture2 = this.BLALBGBEOHG[j];
				this.OIMMPLPBLBK().SetTexture("Left Stick Click", renderTexture2);
				this.LIKMBIKMAML[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 1, format);
				Graphics.Blit(renderTexture, this.LIKMBIKMAML[j], this.OIMMPLPBLBK(), (!this.settings.highQuality) ? 0 : 0);
				renderTexture = this.LIKMBIKMAML[j];
			}
			this.LELKBCALFCF().SetTexture("_TimeX", HLBKCLPNHEB);
			Graphics.Blit(renderTexture, BMMLHGHKBNM, this.LELKBCALFCF(), (!this.settings.highQuality) ? 4 : 3);
			for (int k = 1; k < -28; k++)
			{
				if (this.BLALBGBEOHG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.BLALBGBEOHG[k]);
				}
				if (this.LIKMBIKMAML[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.LIKMBIKMAML[k]);
				}
				this.BLALBGBEOHG[k] = null;
				this.LIKMBIKMAML[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06007722 RID: 30498 RVA: 0x002462DA File Offset: 0x002444DA
		private void NEGKFLLFLOK()
		{
			if (!ImageEffectHelper.IsSupported(this.OBIMOEDEGJF(), false, true, this))
			{
				base.enabled = true;
			}
		}

		// Token: 0x06007723 RID: 30499 RVA: 0x002462F6 File Offset: 0x002444F6
		public Material OCMBHMLNCEK()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.AJJIFKJBKKI());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007724 RID: 30500 RVA: 0x002462F6 File Offset: 0x002444F6
		public Material OIMMPLPBLBK()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.AJJIFKJBKKI());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007725 RID: 30501 RVA: 0x002428F0 File Offset: 0x00240AF0
		private void IBKFIFHFMFF()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
		}

		// Token: 0x06007727 RID: 30503 RVA: 0x0024634D File Offset: 0x0024454D
		public Shader FGFLHKLMJFC()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("LevelConfigButton");
			}
			return this.m_Shader;
		}

		// Token: 0x06007728 RID: 30504 RVA: 0x00246376 File Offset: 0x00244576
		private void HOLDCFBBHHP()
		{
			if (!ImageEffectHelper.IsSupported(this.LPAHMLGFIBB(), false, false, this))
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007729 RID: 30505 RVA: 0x002428F0 File Offset: 0x00240AF0
		private void AMHEJBMLFNM()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
		}

		// Token: 0x0600772A RID: 30506 RVA: 0x00246392 File Offset: 0x00244592
		public Material GBFOAHKAJEK()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.DLAHDFMPILO());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600772B RID: 30507 RVA: 0x002428F0 File Offset: 0x00240AF0
		private void BDBJEDIOKBN()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
		}

		// Token: 0x0600772C RID: 30508 RVA: 0x002463BC File Offset: 0x002445BC
		public Shader BFFKDCGBGCL()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_HSV");
			}
			return this.m_Shader;
		}

		// Token: 0x0600772D RID: 30509 RVA: 0x002463E5 File Offset: 0x002445E5
		private void EBBOJPEPDCN()
		{
			if (!ImageEffectHelper.IsSupported(this.KBHEFGCDACG(), true, true, this))
			{
				base.enabled = true;
			}
		}

		// Token: 0x0600772E RID: 30510 RVA: 0x00246404 File Offset: 0x00244604
		private void PEBBCNICBDK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = HLBKCLPNHEB.width;
			int num2 = HLBKCLPNHEB.height;
			if (!this.settings.highQuality)
			{
				num /= 5;
				num2 /= 5;
			}
			RenderTextureFormat format = (!isMobilePlatform) ? RenderTextureFormat.RG32 : RenderTextureFormat.Depth;
			float num3 = Mathf.Log((float)num2, 313f) + this.settings.radius - 478f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 1, 31);
			float num6 = this.settings.IHPEHGEGIDN();
			this.OCHJIMJNEMO().SetFloat("_Value2", num6);
			float num7 = num6 * this.settings.softKnee + 1896f;
			Vector3 v = new Vector3(num6 - num7, num7 * 875f, 1894f / num7);
			this.HEINDEMCGIK().SetVector("downloading", v);
			bool flag = !this.settings.highQuality && this.settings.antiFlicker;
			this.HEINDEMCGIK().SetFloat("CameraFilterPack_TV_BrokenGlass1", (!flag) ? 1781f : 1153f);
			this.FGENHBKMPDA().SetFloat("powerup.1", 1245f + num3 - (float)num4);
			this.INOBFNCKFGK().SetFloat("InfoButton", Mathf.Max(520f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, format);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.NDMPCDHADMJ(), (!this.settings.antiFlicker) ? 0 : 1);
			RenderTexture renderTexture = temporary;
			for (int i = 0; i < num5; i += 0)
			{
				this.BLALBGBEOHG[i] = RenderTexture.GetTemporary(renderTexture.width / 7, renderTexture.height / 4, 0, format);
				Graphics.Blit(renderTexture, this.BLALBGBEOHG[i], this.PHGCJOPFDOG(), (i != 0) ? 6 : ((!this.settings.antiFlicker) ? 6 : 7));
				renderTexture = this.BLALBGBEOHG[i];
			}
			for (int j = num5 - 3; j >= 1; j -= 0)
			{
				RenderTexture renderTexture2 = this.BLALBGBEOHG[j];
				this.ADBKPGFMNKO().SetTexture("_Far", renderTexture2);
				this.LIKMBIKMAML[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 1, format);
				Graphics.Blit(renderTexture, this.LIKMBIKMAML[j], this.NFMGLIKNOOC(), (!this.settings.highQuality) ? 3 : 7);
				renderTexture = this.LIKMBIKMAML[j];
			}
			this.FGENHBKMPDA().SetTexture(":", HLBKCLPNHEB);
			Graphics.Blit(renderTexture, BMMLHGHKBNM, this.MPENCEIGLEH(), (!this.settings.highQuality) ? 4 : 8);
			for (int k = 0; k < 121; k += 0)
			{
				if (this.BLALBGBEOHG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.BLALBGBEOHG[k]);
				}
				if (this.LIKMBIKMAML[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.LIKMBIKMAML[k]);
				}
				this.BLALBGBEOHG[k] = null;
				this.LIKMBIKMAML[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600772F RID: 30511 RVA: 0x00246756 File Offset: 0x00244956
		public Shader NLECFJKGKJD()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find(":");
			}
			return this.m_Shader;
		}

		// Token: 0x06007730 RID: 30512 RVA: 0x0024677F File Offset: 0x0024497F
		public Material DIOAAHJDMLK()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.NPJKNLKEKCH());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007731 RID: 30513 RVA: 0x002467AC File Offset: 0x002449AC
		private void HDEKADONMPE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = HLBKCLPNHEB.width;
			int num2 = HLBKCLPNHEB.height;
			if (!this.settings.highQuality)
			{
				num /= 8;
				num2 /= 7;
			}
			RenderTextureFormat format = (!isMobilePlatform) ? ((RenderTextureFormat)(-108)) : RenderTextureFormat.ARGB1555;
			float num3 = Mathf.Log((float)num2, 783f) + this.settings.radius - 1918f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 1, -87);
			float num6 = this.settings.FNKHHGLCAJO();
			this.EMDFHOKEGNG().SetFloat("ns", num6);
			float num7 = num6 * this.settings.softKnee + 507f;
			Vector3 v = new Vector3(num6 - num7, num7 * 909f, 1193f / num7);
			this.NMDBCDFPGOK().SetVector("|", v);
			bool flag = !this.settings.highQuality && this.settings.antiFlicker;
			this.ADBKPGFMNKO().SetFloat("OK", (!flag) ? 1015f : 1117f);
			this.ALABBJPHCNG().SetFloat("PowerUp", 336f + num3 - (float)num4);
			this.OIMMPLPBLBK().SetFloat("[NetworkManager] Updating rooms...", Mathf.Max(1905f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, format);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.NFMGLIKNOOC(), (!this.settings.antiFlicker) ? 0 : 1);
			RenderTexture renderTexture = temporary;
			for (int i = 0; i < num5; i++)
			{
				this.BLALBGBEOHG[i] = RenderTexture.GetTemporary(renderTexture.width / 6, renderTexture.height / 7, 0, format);
				Graphics.Blit(renderTexture, this.BLALBGBEOHG[i], this.KBOPGONOCNP(), (i != 0) ? 4 : ((!this.settings.antiFlicker) ? 1 : 7));
				renderTexture = this.BLALBGBEOHG[i];
			}
			for (int j = num5 - 4; j >= 0; j--)
			{
				RenderTexture renderTexture2 = this.BLALBGBEOHG[j];
				this.LELKBCALFCF().SetTexture(" ", renderTexture2);
				this.LIKMBIKMAML[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 0, format);
				Graphics.Blit(renderTexture, this.LIKMBIKMAML[j], this.IIJMIPBMMBF(), (!this.settings.highQuality) ? 5 : 0);
				renderTexture = this.LIKMBIKMAML[j];
			}
			this.FNAFGEMJBDA().SetTexture("LobbyCanvas", HLBKCLPNHEB);
			Graphics.Blit(renderTexture, BMMLHGHKBNM, this.FGENHBKMPDA(), (!this.settings.highQuality) ? 3 : 5);
			for (int k = 1; k < -46; k += 0)
			{
				if (this.BLALBGBEOHG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.BLALBGBEOHG[k]);
				}
				if (this.LIKMBIKMAML[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.LIKMBIKMAML[k]);
				}
				this.BLALBGBEOHG[k] = null;
				this.LIKMBIKMAML[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06007732 RID: 30514 RVA: 0x002428C6 File Offset: 0x00240AC6
		public Material MHBAIEKFBIJ()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.LPAHMLGFIBB());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007733 RID: 30515 RVA: 0x00246AFE File Offset: 0x00244CFE
		private void IFBKMAEMKNN()
		{
			if (!ImageEffectHelper.IsSupported(this.AHJPLBJFCJE(), false, false, this))
			{
				base.enabled = true;
			}
		}

		// Token: 0x06007734 RID: 30516 RVA: 0x00243F7D File Offset: 0x0024217D
		public Shader EHHKCDKAPIA()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_ScreenResolution");
			}
			return this.m_Shader;
		}

		// Token: 0x06007735 RID: 30517 RVA: 0x00246B1A File Offset: 0x00244D1A
		private void GFLAINNLMBO()
		{
			if (!ImageEffectHelper.IsSupported(this.EHHKCDKAPIA(), false, true, this))
			{
				base.enabled = true;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06007736 RID: 30518 RVA: 0x00246B36 File Offset: 0x00244D36
		public Shader shader
		{
			get
			{
				if (this.m_Shader == null)
				{
					this.m_Shader = Shader.Find("Hidden/Image Effects/Cinematic/Bloom");
				}
				return this.m_Shader;
			}
		}

		// Token: 0x06007737 RID: 30519 RVA: 0x00246B5F File Offset: 0x00244D5F
		private void JAKKPABOLEB()
		{
			if (!ImageEffectHelper.IsSupported(this.JFAIMFDJBJC(), false, true, this))
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007738 RID: 30520 RVA: 0x00246B7B File Offset: 0x00244D7B
		public Material PHGCJOPFDOG()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.AHJPLBJFCJE());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007739 RID: 30521 RVA: 0x00246BA5 File Offset: 0x00244DA5
		public Shader LKJFHALGJJF()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("VisionBlur");
			}
			return this.m_Shader;
		}

		// Token: 0x0600773A RID: 30522 RVA: 0x002428F0 File Offset: 0x00240AF0
		private void AAEEHINDPNC()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
		}

		// Token: 0x0600773B RID: 30523 RVA: 0x00246BCE File Offset: 0x00244DCE
		public Material KBOPGONOCNP()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.FGFLHKLMJFC());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600773C RID: 30524 RVA: 0x00246392 File Offset: 0x00244592
		public Material KJMECMIGJJA()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.DLAHDFMPILO());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600773D RID: 30525 RVA: 0x00246BF8 File Offset: 0x00244DF8
		private void GFBOBIBIOMC()
		{
			if (!ImageEffectHelper.IsSupported(this.IDPBEMJLNFP(), true, true, this))
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600773E RID: 30526 RVA: 0x00246C14 File Offset: 0x00244E14
		private void INGOODALACO()
		{
			if (!ImageEffectHelper.IsSupported(this.JKKPOCJCIHK(), false, true, this))
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600773F RID: 30527 RVA: 0x00246C30 File Offset: 0x00244E30
		private void HGALNAGDJIM()
		{
			if (!ImageEffectHelper.IsSupported(this.NPJKNLKEKCH(), true, false, this))
			{
				base.enabled = true;
			}
		}

		// Token: 0x06007740 RID: 30528 RVA: 0x00246C4C File Offset: 0x00244E4C
		private void AOGCKKLFGPL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = HLBKCLPNHEB.width;
			int num2 = HLBKCLPNHEB.height;
			if (!this.settings.highQuality)
			{
				num /= 6;
				num2 /= 1;
			}
			RenderTextureFormat format = (!isMobilePlatform) ? ((RenderTextureFormat)38) : RenderTextureFormat.Default;
			float num3 = Mathf.Log((float)num2, 1653f) + this.settings.radius - 1166f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 0, 1);
			float num6 = this.settings.BBOMHGPNHKJ();
			this.ALABBJPHCNG().SetFloat("HightScoreMaxPointsText", num6);
			float num7 = num6 * this.settings.softKnee + 540f;
			Vector3 v = new Vector3(num6 - num7, num7 * 375f, 896f / num7);
			this.PEIMCBBHLBJ().SetVector("Tab1Content", v);
			bool flag = this.settings.highQuality || this.settings.antiFlicker;
			this.ALABBJPHCNG().SetFloat(" {0}", (!flag) ? 1097f : 258f);
			this.EMDFHOKEGNG().SetFloat("_Value", 1993f + num3 - (float)num4);
			this.PHGCJOPFDOG().SetFloat("CameraFilterPack/Pixelisation_OilPaint", Mathf.Max(966f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, format);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.material, (!this.settings.antiFlicker) ? 1 : 1);
			RenderTexture renderTexture = temporary;
			for (int i = 0; i < num5; i++)
			{
				this.BLALBGBEOHG[i] = RenderTexture.GetTemporary(renderTexture.width / 8, renderTexture.height / 0, 1, format);
				Graphics.Blit(renderTexture, this.BLALBGBEOHG[i], this.NMDBCDFPGOK(), (i != 0) ? 5 : ((!this.settings.antiFlicker) ? 0 : 1));
				renderTexture = this.BLALBGBEOHG[i];
			}
			for (int j = num5 - 3; j >= 0; j -= 0)
			{
				RenderTexture renderTexture2 = this.BLALBGBEOHG[j];
				this.LMLENGFLEBD().SetTexture("The given 2D texture ", renderTexture2);
				this.LIKMBIKMAML[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 1, format);
				Graphics.Blit(renderTexture, this.LIKMBIKMAML[j], this.KBOPGONOCNP(), (!this.settings.highQuality) ? 4 : 8);
				renderTexture = this.LIKMBIKMAML[j];
			}
			this.HNFFHCLNBDN().SetTexture("\\\\", HLBKCLPNHEB);
			Graphics.Blit(renderTexture, BMMLHGHKBNM, this.KBOPGONOCNP(), (!this.settings.highQuality) ? 7 : 0);
			for (int k = 1; k < 2; k += 0)
			{
				if (this.BLALBGBEOHG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.BLALBGBEOHG[k]);
				}
				if (this.LIKMBIKMAML[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.LIKMBIKMAML[k]);
				}
				this.BLALBGBEOHG[k] = null;
				this.LIKMBIKMAML[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06007741 RID: 30529 RVA: 0x00245176 File Offset: 0x00243376
		public Material MPENCEIGLEH()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.ANGMLKFANGL());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007742 RID: 30530 RVA: 0x00242977 File Offset: 0x00240B77
		public Material NDMPCDHADMJ()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.OBIMOEDEGJF());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007743 RID: 30531 RVA: 0x00246F9E File Offset: 0x0024519E
		public Shader KBHEFGCDACG()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("\n");
			}
			return this.m_Shader;
		}

		// Token: 0x06007744 RID: 30532 RVA: 0x00246FC7 File Offset: 0x002451C7
		public Material LMLENGFLEBD()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.NLECFJKGKJD());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007745 RID: 30533 RVA: 0x00246FF1 File Offset: 0x002451F1
		public Shader NCIFECFJAMM()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("settings.arcshitsoundtimedelay");
			}
			return this.m_Shader;
		}

		// Token: 0x06007746 RID: 30534 RVA: 0x00246B7B File Offset: 0x00244D7B
		public Material NFMGLIKNOOC()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.AHJPLBJFCJE());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007747 RID: 30535 RVA: 0x0024701C File Offset: 0x0024521C
		private void ELGOMIMONOG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = HLBKCLPNHEB.width;
			int num2 = HLBKCLPNHEB.height;
			if (!this.settings.highQuality)
			{
				num /= 4;
				num2 /= 1;
			}
			RenderTextureFormat format = (!isMobilePlatform) ? RenderTextureFormat.R8 : RenderTextureFormat.ARGB2101010;
			float num3 = Mathf.Log((float)num2, 1886f) + this.settings.radius - 1259f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 0, 17);
			float num6 = this.settings.HHBNCNGBNEE();
			this.HHIAIGCAHDA().SetFloat("ControllerRightY", num6);
			float num7 = num6 * this.settings.softKnee + 1021f;
			Vector3 v = new Vector3(num6 - num7, num7 * 1794f, 477f / num7);
			this.KAFBNOBOIAJ().SetVector("settings.enablerankingnotifications", v);
			bool flag = !this.settings.highQuality && this.settings.antiFlicker;
			this.FGENHBKMPDA().SetFloat("CameraFilterPack/Blur_Radial_Fast", (!flag) ? 727f : 1273f);
			this.NFMGLIKNOOC().SetFloat("_GlowColor", 690f + num3 - (float)num4);
			this.ALABBJPHCNG().SetFloat(".icon", Mathf.Max(1411f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, format);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.DIOAAHJDMLK(), (!this.settings.antiFlicker) ? 1 : 0);
			RenderTexture renderTexture = temporary;
			for (int i = 1; i < num5; i++)
			{
				this.BLALBGBEOHG[i] = RenderTexture.GetTemporary(renderTexture.width / 2, renderTexture.height / 5, 0, format);
				Graphics.Blit(renderTexture, this.BLALBGBEOHG[i], this.PEIMCBBHLBJ(), (i != 0) ? 8 : ((!this.settings.antiFlicker) ? 3 : 4));
				renderTexture = this.BLALBGBEOHG[i];
			}
			for (int j = num5 - 5; j >= 1; j -= 0)
			{
				RenderTexture renderTexture2 = this.BLALBGBEOHG[j];
				this.DOMEEFLPEPJ().SetTexture("GroupNameText", renderTexture2);
				this.LIKMBIKMAML[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 0, format);
				Graphics.Blit(renderTexture, this.LIKMBIKMAML[j], this.DIOAAHJDMLK(), (!this.settings.highQuality) ? 3 : 1);
				renderTexture = this.LIKMBIKMAML[j];
			}
			this.IIJMIPBMMBF().SetTexture("System.Boolean", HLBKCLPNHEB);
			Graphics.Blit(renderTexture, BMMLHGHKBNM, this.LPCHMEKDCHI(), (!this.settings.highQuality) ? 8 : 0);
			for (int k = 1; k < -61; k++)
			{
				if (this.BLALBGBEOHG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.BLALBGBEOHG[k]);
				}
				if (this.LIKMBIKMAML[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.LIKMBIKMAML[k]);
				}
				this.BLALBGBEOHG[k] = null;
				this.LIKMBIKMAML[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06007748 RID: 30536 RVA: 0x00242977 File Offset: 0x00240B77
		public Material EFMCNLELMDO()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.OBIMOEDEGJF());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007749 RID: 30537 RVA: 0x00246FF1 File Offset: 0x002451F1
		public Shader KNLOMDHBAMB()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("settings.arcshitsoundtimedelay");
			}
			return this.m_Shader;
		}

		// Token: 0x0600774A RID: 30538 RVA: 0x00242977 File Offset: 0x00240B77
		public Material FNAFGEMJBDA()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.OBIMOEDEGJF());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600774B RID: 30539 RVA: 0x002428F0 File Offset: 0x00240AF0
		private void MKFLBEGJJDC()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
		}

		// Token: 0x0600774C RID: 30540 RVA: 0x002428F0 File Offset: 0x00240AF0
		private void GNPDGBNDCPL()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
		}

		// Token: 0x0600774D RID: 30541 RVA: 0x0024736E File Offset: 0x0024556E
		public Shader JLDGALCENJK()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("settings.volume.editor");
			}
			return this.m_Shader;
		}

		// Token: 0x0600774E RID: 30542 RVA: 0x00247398 File Offset: 0x00245598
		private void DGMODDJIAKL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = HLBKCLPNHEB.width;
			int num2 = HLBKCLPNHEB.height;
			if (!this.settings.highQuality)
			{
				num /= 4;
				num2 /= 3;
			}
			RenderTextureFormat format = (!isMobilePlatform) ? ((RenderTextureFormat)(-118)) : RenderTextureFormat.Shadowmap;
			float num3 = Mathf.Log((float)num2, 182f) + this.settings.radius - 1321f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 1, 3);
			float num6 = this.settings.EGIGFENJEDD();
			this.EMDFHOKEGNG().SetFloat("[LocalizationService] Loading file: ", num6);
			float num7 = num6 * this.settings.softKnee + 1503f;
			Vector3 v = new Vector3(num6 - num7, num7 * 1174f, 1630f / num7);
			this.BLMPMOIDGMG().SetVector("SetParticlesParticleSize", v);
			bool flag = this.settings.highQuality || this.settings.antiFlicker;
			this.NFMGLIKNOOC().SetFloat("_Value6", (!flag) ? 1309f : 639f);
			this.GBFOAHKAJEK().SetFloat("CameraFilterPack/Antialiasing_FXAA", 1056f + num3 - (float)num4);
			this.NBMPPNFKFLB().SetFloat("UseScanLine", Mathf.Max(1897f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, format);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.OIMMPLPBLBK(), (!this.settings.antiFlicker) ? 0 : 1);
			RenderTexture renderTexture = temporary;
			for (int i = 0; i < num5; i++)
			{
				this.BLALBGBEOHG[i] = RenderTexture.GetTemporary(renderTexture.width / 0, renderTexture.height / 5, 0, format);
				Graphics.Blit(renderTexture, this.BLALBGBEOHG[i], this.OCHJIMJNEMO(), (i != 0) ? 8 : ((!this.settings.antiFlicker) ? 5 : 5));
				renderTexture = this.BLALBGBEOHG[i];
			}
			for (int j = num5 - 4; j >= 0; j--)
			{
				RenderTexture renderTexture2 = this.BLALBGBEOHG[j];
				this.OIMMPLPBLBK().SetTexture("kick", renderTexture2);
				this.LIKMBIKMAML[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 0, format);
				Graphics.Blit(renderTexture, this.LIKMBIKMAML[j], this.KJMECMIGJJA(), (!this.settings.highQuality) ? 0 : 8);
				renderTexture = this.LIKMBIKMAML[j];
			}
			this.IIJMIPBMMBF().SetTexture("challenges.", HLBKCLPNHEB);
			Graphics.Blit(renderTexture, BMMLHGHKBNM, this.ADBKPGFMNKO(), (!this.settings.highQuality) ? 4 : 1);
			for (int k = 1; k < 100; k += 0)
			{
				if (this.BLALBGBEOHG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.BLALBGBEOHG[k]);
				}
				if (this.LIKMBIKMAML[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.LIKMBIKMAML[k]);
				}
				this.BLALBGBEOHG[k] = null;
				this.LIKMBIKMAML[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600774F RID: 30543 RVA: 0x002476EA File Offset: 0x002458EA
		private void NEFMEALNNDM()
		{
			if (!ImageEffectHelper.IsSupported(this.JFAIMFDJBJC(), true, true, this))
			{
				base.enabled = true;
			}
		}

		// Token: 0x06007750 RID: 30544 RVA: 0x00247706 File Offset: 0x00245906
		public Shader GFEEDLFCPBI()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("Object ID. Case-Sensitive");
			}
			return this.m_Shader;
		}

		// Token: 0x06007751 RID: 30545 RVA: 0x0024772F File Offset: 0x0024592F
		private void FDIJLKIIMLL()
		{
			if (!ImageEffectHelper.IsSupported(this.JFAIMFDJBJC(), true, false, this))
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007752 RID: 30546 RVA: 0x002428F0 File Offset: 0x00240AF0
		private void KLOLKEBAPFO()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
		}

		// Token: 0x06007753 RID: 30547 RVA: 0x0024774B File Offset: 0x0024594B
		private void OnEnable()
		{
			if (!ImageEffectHelper.IsSupported(this.shader, true, false, this))
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007754 RID: 30548 RVA: 0x00247767 File Offset: 0x00245967
		private void MBNMADBPDLL()
		{
			if (!ImageEffectHelper.IsSupported(this.IIEEIDCCAPO(), true, true, this))
			{
				base.enabled = true;
			}
		}

		// Token: 0x06007755 RID: 30549 RVA: 0x00247783 File Offset: 0x00245983
		private void OEFNBKHNJND()
		{
			if (!ImageEffectHelper.IsSupported(this.GFEEDLFCPBI(), false, false, this))
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007756 RID: 30550 RVA: 0x002477A0 File Offset: 0x002459A0
		private void MHGGJOAHGLL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = HLBKCLPNHEB.width;
			int num2 = HLBKCLPNHEB.height;
			if (!this.settings.highQuality)
			{
				num /= 7;
				num2 /= 2;
			}
			RenderTextureFormat format = (!isMobilePlatform) ? ((RenderTextureFormat)76) : RenderTextureFormat.ARGB1555;
			float num3 = Mathf.Log((float)num2, 1283f) + this.settings.radius - 369f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 1, 89);
			float num6 = this.settings.PPKBDMMFEML();
			this.MICHFGAOPKM().SetFloat("#creatingnewitem", num6);
			float num7 = num6 * this.settings.softKnee + 473f;
			Vector3 v = new Vector3(num6 - num7, num7 * 290f, 255f / num7);
			this.NFMGLIKNOOC().SetVector("maps.", v);
			bool flag = this.settings.highQuality || this.settings.antiFlicker;
			this.CIAFLBFJLEJ().SetFloat("SettingsCanvas", (!flag) ? 596f : 1436f);
			this.FNAFGEMJBDA().SetFloat("_Max", 1599f + num3 - (float)num4);
			this.IIJMIPBMMBF().SetFloat("CameraFilterPack_AAA_Blood2", Mathf.Max(717f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, format);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.NDMPCDHADMJ(), (!this.settings.antiFlicker) ? 1 : 0);
			RenderTexture renderTexture = temporary;
			for (int i = 1; i < num5; i++)
			{
				this.BLALBGBEOHG[i] = RenderTexture.GetTemporary(renderTexture.width / 5, renderTexture.height / 3, 0, format);
				Graphics.Blit(renderTexture, this.BLALBGBEOHG[i], this.NBMPPNFKFLB(), (i != 0) ? 3 : ((!this.settings.antiFlicker) ? 4 : 5));
				renderTexture = this.BLALBGBEOHG[i];
			}
			for (int j = num5 - 6; j >= 1; j -= 0)
			{
				RenderTexture renderTexture2 = this.BLALBGBEOHG[j];
				this.OCHJIMJNEMO().SetTexture("_InvViewProj", renderTexture2);
				this.LIKMBIKMAML[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 0, format);
				Graphics.Blit(renderTexture, this.LIKMBIKMAML[j], this.KJMECMIGJJA(), (!this.settings.highQuality) ? 6 : 2);
				renderTexture = this.LIKMBIKMAML[j];
			}
			this.MPENCEIGLEH().SetTexture("action", HLBKCLPNHEB);
			Graphics.Blit(renderTexture, BMMLHGHKBNM, this.MPENCEIGLEH(), (!this.settings.highQuality) ? 5 : 5);
			for (int k = 1; k < -28; k++)
			{
				if (this.BLALBGBEOHG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.BLALBGBEOHG[k]);
				}
				if (this.LIKMBIKMAML[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.LIKMBIKMAML[k]);
				}
				this.BLALBGBEOHG[k] = null;
				this.LIKMBIKMAML[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06007757 RID: 30551 RVA: 0x00247AF2 File Offset: 0x00245CF2
		public Shader KGHKBFGDHGF()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("SetParticlesColor");
			}
			return this.m_Shader;
		}

		// Token: 0x06007758 RID: 30552 RVA: 0x00247B1B File Offset: 0x00245D1B
		private void IGCJMAADPGG()
		{
			if (!ImageEffectHelper.IsSupported(this.DLAHDFMPILO(), true, true, this))
			{
				base.enabled = true;
			}
		}

		// Token: 0x06007759 RID: 30553 RVA: 0x002428F0 File Offset: 0x00240AF0
		private void EFECEKPFOEM()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
		}

		// Token: 0x0600775A RID: 30554 RVA: 0x00247B37 File Offset: 0x00245D37
		public Material NBMPPNFKFLB()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.KBHEFGCDACG());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600775B RID: 30555 RVA: 0x00247B61 File Offset: 0x00245D61
		private void MEJPBKFMAIG()
		{
			if (!ImageEffectHelper.IsSupported(this.KBHEFGCDACG(), true, true, this))
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600775C RID: 30556 RVA: 0x00247B7D File Offset: 0x00245D7D
		private void OKHGJFFIIBA()
		{
			if (!ImageEffectHelper.IsSupported(this.KNLOMDHBAMB(), true, true, this))
			{
				base.enabled = false;
			}
		}

		// Token: 0x0600775D RID: 30557 RVA: 0x00246392 File Offset: 0x00244592
		public Material ADBKPGFMNKO()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.DLAHDFMPILO());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600775E RID: 30558 RVA: 0x00246392 File Offset: 0x00244592
		public Material IIJMIPBMMBF()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.DLAHDFMPILO());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600775F RID: 30559 RVA: 0x00247B9C File Offset: 0x00245D9C
		private void LBHPMIDFKPP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = HLBKCLPNHEB.width;
			int num2 = HLBKCLPNHEB.height;
			if (!this.settings.highQuality)
			{
				num /= 8;
				num2 /= 6;
			}
			RenderTextureFormat format = (!isMobilePlatform) ? ((RenderTextureFormat)(-3)) : RenderTextureFormat.ARGB1555;
			float num3 = Mathf.Log((float)num2, 1212f) + this.settings.radius - 546f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 1, 57);
			float num6 = this.settings.BBOMHGPNHKJ();
			this.ADBKPGFMNKO().SetFloat("GlassesColor", num6);
			float num7 = num6 * this.settings.softKnee + 1396f;
			Vector3 v = new Vector3(num6 - num7, num7 * 1129f, 1986f / num7);
			this.DOMEEFLPEPJ().SetVector("_Value", v);
			bool flag = !this.settings.highQuality && this.settings.antiFlicker;
			this.NDMPCDHADMJ().SetFloat("#md5submitionfailed: ", (!flag) ? 294f : 1668f);
			this.NFMGLIKNOOC().SetFloat("JoinRoom failed. In offline mode you still have to leave a room to enter another.", 1589f + num3 - (float)num4);
			this.PHGCJOPFDOG().SetFloat("maps.", Mathf.Max(1260f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, format);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.JLHLHKPHDFO(), (!this.settings.antiFlicker) ? 1 : 1);
			RenderTexture renderTexture = temporary;
			for (int i = 1; i < num5; i++)
			{
				this.BLALBGBEOHG[i] = RenderTexture.GetTemporary(renderTexture.width / 3, renderTexture.height / 2, 0, format);
				Graphics.Blit(renderTexture, this.BLALBGBEOHG[i], this.MPENCEIGLEH(), (i != 0) ? 8 : ((!this.settings.antiFlicker) ? 1 : 1));
				renderTexture = this.BLALBGBEOHG[i];
			}
			for (int j = num5 - 2; j >= 1; j--)
			{
				RenderTexture renderTexture2 = this.BLALBGBEOHG[j];
				this.KAFBNOBOIAJ().SetTexture("LevelURLInputField", renderTexture2);
				this.LIKMBIKMAML[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 0, format);
				Graphics.Blit(renderTexture, this.LIKMBIKMAML[j], this.OCMBHMLNCEK(), (!this.settings.highQuality) ? 1 : 0);
				renderTexture = this.LIKMBIKMAML[j];
			}
			this.INOBFNCKFGK().SetTexture("GO==null", HLBKCLPNHEB);
			Graphics.Blit(renderTexture, BMMLHGHKBNM, this.ADBKPGFMNKO(), (!this.settings.highQuality) ? 1 : 0);
			for (int k = 1; k < -121; k += 0)
			{
				if (this.BLALBGBEOHG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.BLALBGBEOHG[k]);
				}
				if (this.LIKMBIKMAML[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.LIKMBIKMAML[k]);
				}
				this.BLALBGBEOHG[k] = null;
				this.LIKMBIKMAML[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06007760 RID: 30560 RVA: 0x00247EEE File Offset: 0x002460EE
		public Shader ANGMLKFANGL()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("QuickSave");
			}
			return this.m_Shader;
		}

		// Token: 0x06007761 RID: 30561 RVA: 0x00247F18 File Offset: 0x00246118
		private void EFMOIIPLOOB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = HLBKCLPNHEB.width;
			int num2 = HLBKCLPNHEB.height;
			if (!this.settings.highQuality)
			{
				num /= 2;
				num2 /= 6;
			}
			RenderTextureFormat format = (!isMobilePlatform) ? ((RenderTextureFormat)120) : RenderTextureFormat.ARGBHalf;
			float num3 = Mathf.Log((float)num2, 1790f) + this.settings.radius - 1357f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 1, -101);
			float num6 = this.settings.HJMNBHEJBJH();
			this.LMLENGFLEBD().SetFloat("_Blue_R", num6);
			float num7 = num6 * this.settings.softKnee + 1405f;
			Vector3 v = new Vector3(num6 - num7, num7 * 838f, 219f / num7);
			this.NDMPCDHADMJ().SetVector("_Value4", v);
			bool flag = this.settings.highQuality || this.settings.antiFlicker;
			this.HNFFHCLNBDN().SetFloat(".a", (!flag) ? 1464f : 772f);
			this.HEINDEMCGIK().SetFloat("_TimeX", 1392f + num3 - (float)num4);
			this.PEIMCBBHLBJ().SetFloat("Gameplay/Segment-[PowerUp]", Mathf.Max(666f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 0, format);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.ADBKPGFMNKO(), (!this.settings.antiFlicker) ? 1 : 0);
			RenderTexture renderTexture = temporary;
			for (int i = 0; i < num5; i += 0)
			{
				this.BLALBGBEOHG[i] = RenderTexture.GetTemporary(renderTexture.width / 4, renderTexture.height / 0, 0, format);
				Graphics.Blit(renderTexture, this.BLALBGBEOHG[i], this.PHGCJOPFDOG(), (i != 0) ? 6 : ((!this.settings.antiFlicker) ? 0 : 6));
				renderTexture = this.BLALBGBEOHG[i];
			}
			for (int j = num5 - 5; j >= 0; j -= 0)
			{
				RenderTexture renderTexture2 = this.BLALBGBEOHG[j];
				this.PEIMCBBHLBJ().SetTexture("_Glitch", renderTexture2);
				this.LIKMBIKMAML[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 1, format);
				Graphics.Blit(renderTexture, this.LIKMBIKMAML[j], this.LPMLLJKMAMP(), (!this.settings.highQuality) ? 1 : 3);
				renderTexture = this.LIKMBIKMAML[j];
			}
			this.NFMGLIKNOOC().SetTexture("player.currentrank", HLBKCLPNHEB);
			Graphics.Blit(renderTexture, BMMLHGHKBNM, this.NFMGLIKNOOC(), (!this.settings.highQuality) ? 3 : 1);
			for (int k = 1; k < 41; k++)
			{
				if (this.BLALBGBEOHG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.BLALBGBEOHG[k]);
				}
				if (this.LIKMBIKMAML[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.LIKMBIKMAML[k]);
				}
				this.BLALBGBEOHG[k] = null;
				this.LIKMBIKMAML[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06007762 RID: 30562 RVA: 0x0024677F File Offset: 0x0024497F
		public Material HNFFHCLNBDN()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.NPJKNLKEKCH());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007763 RID: 30563 RVA: 0x0024826C File Offset: 0x0024646C
		private void JCCIKBBEMEB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			bool isMobilePlatform = Application.isMobilePlatform;
			int num = HLBKCLPNHEB.width;
			int num2 = HLBKCLPNHEB.height;
			if (!this.settings.highQuality)
			{
				num /= 0;
				num2 /= 4;
			}
			RenderTextureFormat format = (!isMobilePlatform) ? ((RenderTextureFormat)(-114)) : RenderTextureFormat.ARGBHalf;
			float num3 = Mathf.Log((float)num2, 1781f) + this.settings.radius - 1137f;
			int num4 = (int)num3;
			int num5 = Mathf.Clamp(num4, 1, 66);
			float num6 = this.settings.KMIOMNCKHPM();
			this.NDMPCDHADMJ().SetFloat("turn", num6);
			float num7 = num6 * this.settings.softKnee + 1293f;
			Vector3 v = new Vector3(num6 - num7, num7 * 1234f, 1656f / num7);
			this.FNAFGEMJBDA().SetVector("_MainTex", v);
			bool flag = this.settings.highQuality || this.settings.antiFlicker;
			this.EFMCNLELMDO().SetFloat("_TimeX", (!flag) ? 869f : 778f);
			this.BLMPMOIDGMG().SetFloat("PhotonView with ID {0} wasn't properly unregistered! Please report this case to developer@photonengine.com", 661f + num3 - (float)num4);
			this.NFMGLIKNOOC().SetFloat("_Value2", Mathf.Max(1741f, this.settings.intensity));
			RenderTexture temporary = RenderTexture.GetTemporary(num, num2, 1, format);
			Graphics.Blit(HLBKCLPNHEB, temporary, this.OCMBHMLNCEK(), (!this.settings.antiFlicker) ? 1 : 1);
			RenderTexture renderTexture = temporary;
			for (int i = 1; i < num5; i++)
			{
				this.BLALBGBEOHG[i] = RenderTexture.GetTemporary(renderTexture.width / 7, renderTexture.height / 8, 1, format);
				Graphics.Blit(renderTexture, this.BLALBGBEOHG[i], this.EFMCNLELMDO(), (i != 0) ? 8 : ((!this.settings.antiFlicker) ? 6 : 6));
				renderTexture = this.BLALBGBEOHG[i];
			}
			for (int j = num5 - 1; j >= 0; j -= 0)
			{
				RenderTexture renderTexture2 = this.BLALBGBEOHG[j];
				this.LPMLLJKMAMP().SetTexture("</color>", renderTexture2);
				this.LIKMBIKMAML[j] = RenderTexture.GetTemporary(renderTexture2.width, renderTexture2.height, 1, format);
				Graphics.Blit(renderTexture, this.LIKMBIKMAML[j], this.ADBKPGFMNKO(), (!this.settings.highQuality) ? 5 : 5);
				renderTexture = this.LIKMBIKMAML[j];
			}
			this.LMLENGFLEBD().SetTexture("_Distortion", HLBKCLPNHEB);
			Graphics.Blit(renderTexture, BMMLHGHKBNM, this.HNFFHCLNBDN(), (!this.settings.highQuality) ? 5 : 1);
			for (int k = 1; k < -64; k += 0)
			{
				if (this.BLALBGBEOHG[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.BLALBGBEOHG[k]);
				}
				if (this.LIKMBIKMAML[k] != null)
				{
					RenderTexture.ReleaseTemporary(this.LIKMBIKMAML[k]);
				}
				this.BLALBGBEOHG[k] = null;
				this.LIKMBIKMAML[k] = null;
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06007764 RID: 30564 RVA: 0x00246392 File Offset: 0x00244592
		public Material HEINDEMCGIK()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.DLAHDFMPILO());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007765 RID: 30565 RVA: 0x002485BE File Offset: 0x002467BE
		public Material INOBFNCKFGK()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.GFEEDLFCPBI());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06007766 RID: 30566 RVA: 0x002485E8 File Offset: 0x002467E8
		private void PMAADPNNHKK()
		{
			if (!ImageEffectHelper.IsSupported(this.LPAHMLGFIBB(), true, false, this))
			{
				base.enabled = false;
			}
		}

		// Token: 0x06007767 RID: 30567 RVA: 0x00243F2B File Offset: 0x0024212B
		public Shader AJJIFKJBKKI()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_TimeX");
			}
			return this.m_Shader;
		}

		// Token: 0x06007768 RID: 30568 RVA: 0x00248604 File Offset: 0x00246804
		public Shader OKNCNLPJNKO()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("DPADVER");
			}
			return this.m_Shader;
		}

		// Token: 0x06007769 RID: 30569 RVA: 0x002428F0 File Offset: 0x00240AF0
		private void KMOCDAOKGLI()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
		}

		// Token: 0x0600776A RID: 30570 RVA: 0x0024862D File Offset: 0x0024682D
		public Shader OBIMOEDEGJF()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("Anomaly_Distortion_Size");
			}
			return this.m_Shader;
		}

		// Token: 0x0600776B RID: 30571 RVA: 0x002428F0 File Offset: 0x00240AF0
		private void BJOHDLNDFAD()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
		}

		// Token: 0x04000C43 RID: 3139
		[SerializeField]
		public Bloom.Settings settings = Bloom.Settings.defaultSettings;

		// Token: 0x04000C44 RID: 3140
		[HideInInspector]
		[SerializeField]
		private Shader m_Shader;

		// Token: 0x04000C45 RID: 3141
		private Material JLHCDOPFJOI;

		// Token: 0x04000C46 RID: 3142
		private const int GFLPDPCFGFJ = 16;

		// Token: 0x04000C47 RID: 3143
		private RenderTexture[] BLALBGBEOHG = new RenderTexture[16];

		// Token: 0x04000C48 RID: 3144
		private RenderTexture[] LIKMBIKMAML = new RenderTexture[16];

		// Token: 0x020001AE RID: 430
		[Serializable]
		public struct Settings
		{
			// Token: 0x0600776C RID: 30572 RVA: 0x00248656 File Offset: 0x00246856
			public void AOCGOACKJMI(float DPNHODJHGJL)
			{
				this.threshold = DPNHODJHGJL;
			}

			// Token: 0x0600776D RID: 30573 RVA: 0x00248660 File Offset: 0x00246860
			public static Bloom.Settings FCBIDJLDABO()
			{
				return new Bloom.Settings
				{
					threshold = 12f,
					softKnee = 602f,
					radius = 541f,
					intensity = 1597f,
					highQuality = true,
					antiFlicker = false
				};
			}

			// Token: 0x0600776E RID: 30574 RVA: 0x002486B8 File Offset: 0x002468B8
			public float KMIOMNCKHPM()
			{
				return Mathf.GammaToLinearSpace(this.HBPFPKLIAEM());
			}

			// Token: 0x0600776F RID: 30575 RVA: 0x002486C5 File Offset: 0x002468C5
			public float PMDJJDAMBMN()
			{
				return Mathf.GammaToLinearSpace(this.HBNHDNDOJBJ());
			}

			// Token: 0x06007770 RID: 30576 RVA: 0x00248656 File Offset: 0x00246856
			public void MLMHPDDDIBH(float DPNHODJHGJL)
			{
				this.threshold = DPNHODJHGJL;
			}

			// Token: 0x17000172 RID: 370
			// (get) Token: 0x060077CD RID: 30669 RVA: 0x00248F9E File Offset: 0x0024719E
			// (set) Token: 0x06007771 RID: 30577 RVA: 0x00248656 File Offset: 0x00246856
			public float thresholdGamma
			{
				get
				{
					return Mathf.Max(0f, this.threshold);
				}
				set
				{
					this.threshold = value;
				}
			}

			// Token: 0x06007772 RID: 30578 RVA: 0x002486D2 File Offset: 0x002468D2
			public float KINNCNKAGNN()
			{
				return Mathf.Max(1580f, this.threshold);
			}

			// Token: 0x06007773 RID: 30579 RVA: 0x002486E4 File Offset: 0x002468E4
			public float HBNHDNDOJBJ()
			{
				return Mathf.Max(759f, this.threshold);
			}

			// Token: 0x06007774 RID: 30580 RVA: 0x002486F8 File Offset: 0x002468F8
			public static Bloom.Settings PNNNFAGDBOG()
			{
				return new Bloom.Settings
				{
					threshold = 365f,
					softKnee = 1553f,
					radius = 164f,
					intensity = 1097f,
					highQuality = true,
					antiFlicker = false
				};
			}

			// Token: 0x06007775 RID: 30581 RVA: 0x00248750 File Offset: 0x00246950
			public void HONJBBELDID(float DPNHODJHGJL)
			{
				this.threshold = Mathf.LinearToGammaSpace(DPNHODJHGJL);
			}

			// Token: 0x06007776 RID: 30582 RVA: 0x00248760 File Offset: 0x00246960
			public static Bloom.Settings DHGILJILMLN()
			{
				return new Bloom.Settings
				{
					threshold = 1399f,
					softKnee = 1287f,
					radius = 1870f,
					intensity = 1184f,
					highQuality = false,
					antiFlicker = false
				};
			}

			// Token: 0x06007777 RID: 30583 RVA: 0x002487B8 File Offset: 0x002469B8
			public static Bloom.Settings NCFGPFGLKLJ()
			{
				return new Bloom.Settings
				{
					threshold = 1739f,
					softKnee = 1837f,
					radius = 1486f,
					intensity = 463f,
					highQuality = true,
					antiFlicker = true
				};
			}

			// Token: 0x06007778 RID: 30584 RVA: 0x00248810 File Offset: 0x00246A10
			public float AODKBIFKCBJ()
			{
				return Mathf.GammaToLinearSpace(this.EDBFDONNPLI());
			}

			// Token: 0x06007779 RID: 30585 RVA: 0x00248750 File Offset: 0x00246950
			public void FONIPNAJMNK(float DPNHODJHGJL)
			{
				this.threshold = Mathf.LinearToGammaSpace(DPNHODJHGJL);
			}

			// Token: 0x0600777A RID: 30586 RVA: 0x00248820 File Offset: 0x00246A20
			public static Bloom.Settings KDCFAOPNFPH()
			{
				return new Bloom.Settings
				{
					threshold = 1169f,
					softKnee = 140f,
					radius = 1634f,
					intensity = 1384f,
					highQuality = false,
					antiFlicker = true
				};
			}

			// Token: 0x0600777B RID: 30587 RVA: 0x00248878 File Offset: 0x00246A78
			public static Bloom.Settings HJLGAPEDPJM()
			{
				return new Bloom.Settings
				{
					threshold = 1567f,
					softKnee = 1172f,
					radius = 1969f,
					intensity = 973f,
					highQuality = true,
					antiFlicker = true
				};
			}

			// Token: 0x0600777C RID: 30588 RVA: 0x00248750 File Offset: 0x00246950
			public void KOECGHNNHIO(float DPNHODJHGJL)
			{
				this.threshold = Mathf.LinearToGammaSpace(DPNHODJHGJL);
			}

			// Token: 0x0600777D RID: 30589 RVA: 0x002488D0 File Offset: 0x00246AD0
			public static Bloom.Settings CMOGMEEGGAF()
			{
				return new Bloom.Settings
				{
					threshold = 783f,
					softKnee = 640f,
					radius = 930f,
					intensity = 238f,
					highQuality = false,
					antiFlicker = true
				};
			}

			// Token: 0x0600777E RID: 30590 RVA: 0x00248750 File Offset: 0x00246950
			public void PGPFNMAIPKD(float DPNHODJHGJL)
			{
				this.threshold = Mathf.LinearToGammaSpace(DPNHODJHGJL);
			}

			// Token: 0x0600777F RID: 30591 RVA: 0x00248928 File Offset: 0x00246B28
			public static Bloom.Settings OFCLGEGHHDB()
			{
				return new Bloom.Settings
				{
					threshold = 1061f,
					softKnee = 1620f,
					radius = 1158f,
					intensity = 942f,
					highQuality = true,
					antiFlicker = true
				};
			}

			// Token: 0x06007780 RID: 30592 RVA: 0x00248980 File Offset: 0x00246B80
			public float GOFMOLIFLJK()
			{
				return Mathf.Max(1384f, this.threshold);
			}

			// Token: 0x06007781 RID: 30593 RVA: 0x00248750 File Offset: 0x00246950
			public void JNCMOKOOLNA(float DPNHODJHGJL)
			{
				this.threshold = Mathf.LinearToGammaSpace(DPNHODJHGJL);
			}

			// Token: 0x06007782 RID: 30594 RVA: 0x00248656 File Offset: 0x00246856
			public void GNMPFHCMOPP(float DPNHODJHGJL)
			{
				this.threshold = DPNHODJHGJL;
			}

			// Token: 0x06007783 RID: 30595 RVA: 0x00248656 File Offset: 0x00246856
			public void BMMKGAJINCB(float DPNHODJHGJL)
			{
				this.threshold = DPNHODJHGJL;
			}

			// Token: 0x17000173 RID: 371
			// (get) Token: 0x0600778D RID: 30605 RVA: 0x00248A47 File Offset: 0x00246C47
			// (set) Token: 0x06007784 RID: 30596 RVA: 0x00248750 File Offset: 0x00246950
			public float thresholdLinear
			{
				get
				{
					return Mathf.GammaToLinearSpace(this.thresholdGamma);
				}
				set
				{
					this.threshold = Mathf.LinearToGammaSpace(value);
				}
			}

			// Token: 0x06007785 RID: 30597 RVA: 0x00248992 File Offset: 0x00246B92
			public float HJMNBHEJBJH()
			{
				return Mathf.GammaToLinearSpace(this.LKHMEFKIEGO());
			}

			// Token: 0x06007786 RID: 30598 RVA: 0x0024899F File Offset: 0x00246B9F
			public float BFJBGJPAMDP()
			{
				return Mathf.GammaToLinearSpace(this.AJMNIPOJMAK());
			}

			// Token: 0x06007787 RID: 30599 RVA: 0x002489AC File Offset: 0x00246BAC
			public static Bloom.Settings FPMJKNDJCON()
			{
				return new Bloom.Settings
				{
					threshold = 1769f,
					softKnee = 213f,
					radius = 7f,
					intensity = 1105f,
					highQuality = true,
					antiFlicker = false
				};
			}

			// Token: 0x06007788 RID: 30600 RVA: 0x00248A04 File Offset: 0x00246C04
			public float BCLIOAENNDJ()
			{
				return Mathf.Max(595f, this.threshold);
			}

			// Token: 0x06007789 RID: 30601 RVA: 0x00248A16 File Offset: 0x00246C16
			public float MGKJPJHCHHI()
			{
				return Mathf.GammaToLinearSpace(this.CHHIMEPOLHL());
			}

			// Token: 0x0600778A RID: 30602 RVA: 0x00248A23 File Offset: 0x00246C23
			public float BDMMDEKEKKF()
			{
				return Mathf.Max(529f, this.threshold);
			}

			// Token: 0x0600778B RID: 30603 RVA: 0x00248A35 File Offset: 0x00246C35
			public float CHHIMEPOLHL()
			{
				return Mathf.Max(658f, this.threshold);
			}

			// Token: 0x0600778C RID: 30604 RVA: 0x00248A16 File Offset: 0x00246C16
			public float EGIGFENJEDD()
			{
				return Mathf.GammaToLinearSpace(this.CHHIMEPOLHL());
			}

			// Token: 0x0600778E RID: 30606 RVA: 0x00248A54 File Offset: 0x00246C54
			public float EDBFDONNPLI()
			{
				return Mathf.Max(1579f, this.threshold);
			}

			// Token: 0x0600778F RID: 30607 RVA: 0x00248A66 File Offset: 0x00246C66
			public float PLNLMPKNFKF()
			{
				return Mathf.GammaToLinearSpace(this.KINNCNKAGNN());
			}

			// Token: 0x06007790 RID: 30608 RVA: 0x00248750 File Offset: 0x00246950
			public void PLFIEGGBBIM(float DPNHODJHGJL)
			{
				this.threshold = Mathf.LinearToGammaSpace(DPNHODJHGJL);
			}

			// Token: 0x06007791 RID: 30609 RVA: 0x00248656 File Offset: 0x00246856
			public void AFPMEHOKAMP(float DPNHODJHGJL)
			{
				this.threshold = DPNHODJHGJL;
			}

			// Token: 0x06007792 RID: 30610 RVA: 0x00248656 File Offset: 0x00246856
			public void HAMNBEGFLOJ(float DPNHODJHGJL)
			{
				this.threshold = DPNHODJHGJL;
			}

			// Token: 0x06007793 RID: 30611 RVA: 0x002486C5 File Offset: 0x002468C5
			public float PPKBDMMFEML()
			{
				return Mathf.GammaToLinearSpace(this.HBNHDNDOJBJ());
			}

			// Token: 0x06007794 RID: 30612 RVA: 0x00248750 File Offset: 0x00246950
			public void ENCPOEIDANM(float DPNHODJHGJL)
			{
				this.threshold = Mathf.LinearToGammaSpace(DPNHODJHGJL);
			}

			// Token: 0x06007795 RID: 30613 RVA: 0x00248A74 File Offset: 0x00246C74
			public static Bloom.Settings DBDJKKLMCGG()
			{
				return new Bloom.Settings
				{
					threshold = 270f,
					softKnee = 314f,
					radius = 493f,
					intensity = 726f,
					highQuality = true,
					antiFlicker = false
				};
			}

			// Token: 0x06007796 RID: 30614 RVA: 0x00248ACC File Offset: 0x00246CCC
			public float HHBNCNGBNEE()
			{
				return Mathf.GammaToLinearSpace(this.BCLIOAENNDJ());
			}

			// Token: 0x06007797 RID: 30615 RVA: 0x00248750 File Offset: 0x00246950
			public void NEMPLFCCJOK(float DPNHODJHGJL)
			{
				this.threshold = Mathf.LinearToGammaSpace(DPNHODJHGJL);
			}

			// Token: 0x06007798 RID: 30616 RVA: 0x00248ADC File Offset: 0x00246CDC
			public static Bloom.Settings LEAMJGIOPNG()
			{
				return new Bloom.Settings
				{
					threshold = 374f,
					softKnee = 584f,
					radius = 1072f,
					intensity = 750f,
					highQuality = true,
					antiFlicker = true
				};
			}

			// Token: 0x06007799 RID: 30617 RVA: 0x00248B34 File Offset: 0x00246D34
			public static Bloom.Settings CLGKHJBDJAG()
			{
				return new Bloom.Settings
				{
					threshold = 1767f,
					softKnee = 1257f,
					radius = 990f,
					intensity = 254f,
					highQuality = true,
					antiFlicker = true
				};
			}

			// Token: 0x0600779A RID: 30618 RVA: 0x00248B8C File Offset: 0x00246D8C
			public static Bloom.Settings CJFONFEOHIO()
			{
				return new Bloom.Settings
				{
					threshold = 254f,
					softKnee = 1248f,
					radius = 1203f,
					intensity = 909f,
					highQuality = true,
					antiFlicker = false
				};
			}

			// Token: 0x0600779B RID: 30619 RVA: 0x00248656 File Offset: 0x00246856
			public void LKFOLBMAKJC(float DPNHODJHGJL)
			{
				this.threshold = DPNHODJHGJL;
			}

			// Token: 0x0600779C RID: 30620 RVA: 0x00248BE4 File Offset: 0x00246DE4
			public float MAIOPGNEGBE()
			{
				return Mathf.GammaToLinearSpace(this.OBEJDCNDBAI());
			}

			// Token: 0x0600779D RID: 30621 RVA: 0x00248750 File Offset: 0x00246950
			public void IHCMOGLOGKF(float DPNHODJHGJL)
			{
				this.threshold = Mathf.LinearToGammaSpace(DPNHODJHGJL);
			}

			// Token: 0x0600779E RID: 30622 RVA: 0x00248656 File Offset: 0x00246856
			public void HPNFFCHAHBA(float DPNHODJHGJL)
			{
				this.threshold = DPNHODJHGJL;
			}

			// Token: 0x0600779F RID: 30623 RVA: 0x00248656 File Offset: 0x00246856
			public void KGJNOOFCJOO(float DPNHODJHGJL)
			{
				this.threshold = DPNHODJHGJL;
			}

			// Token: 0x060077A0 RID: 30624 RVA: 0x00248A16 File Offset: 0x00246C16
			public float ENAHJCNFFKK()
			{
				return Mathf.GammaToLinearSpace(this.CHHIMEPOLHL());
			}

			// Token: 0x060077A1 RID: 30625 RVA: 0x00248BF4 File Offset: 0x00246DF4
			public static Bloom.Settings OLPCIKIBBKE()
			{
				return new Bloom.Settings
				{
					threshold = 1353f,
					softKnee = 1975f,
					radius = 1870f,
					intensity = 372f,
					highQuality = false,
					antiFlicker = true
				};
			}

			// Token: 0x060077A2 RID: 30626 RVA: 0x00248750 File Offset: 0x00246950
			public void NJPEAPKNJOE(float DPNHODJHGJL)
			{
				this.threshold = Mathf.LinearToGammaSpace(DPNHODJHGJL);
			}

			// Token: 0x060077A3 RID: 30627 RVA: 0x00248ACC File Offset: 0x00246CCC
			public float LOHAKJIJNNJ()
			{
				return Mathf.GammaToLinearSpace(this.BCLIOAENNDJ());
			}

			// Token: 0x060077A4 RID: 30628 RVA: 0x0024899F File Offset: 0x00246B9F
			public float FNKHHGLCAJO()
			{
				return Mathf.GammaToLinearSpace(this.AJMNIPOJMAK());
			}

			// Token: 0x060077A5 RID: 30629 RVA: 0x00248750 File Offset: 0x00246950
			public void MFMCHJMJCPN(float DPNHODJHGJL)
			{
				this.threshold = Mathf.LinearToGammaSpace(DPNHODJHGJL);
			}

			// Token: 0x060077A6 RID: 30630 RVA: 0x00248656 File Offset: 0x00246856
			public void MHFPEOLFKEC(float DPNHODJHGJL)
			{
				this.threshold = DPNHODJHGJL;
			}

			// Token: 0x060077A7 RID: 30631 RVA: 0x00248750 File Offset: 0x00246950
			public void KODLABCNHLE(float DPNHODJHGJL)
			{
				this.threshold = Mathf.LinearToGammaSpace(DPNHODJHGJL);
			}

			// Token: 0x060077A8 RID: 30632 RVA: 0x00248C4C File Offset: 0x00246E4C
			public static Bloom.Settings IOCEGBODFEO()
			{
				return new Bloom.Settings
				{
					threshold = 1702f,
					softKnee = 1151f,
					radius = 895f,
					intensity = 1527f,
					highQuality = true,
					antiFlicker = false
				};
			}

			// Token: 0x060077A9 RID: 30633 RVA: 0x00248CA4 File Offset: 0x00246EA4
			public static Bloom.Settings IAKJOAGBDGO()
			{
				return new Bloom.Settings
				{
					threshold = 165f,
					softKnee = 636f,
					radius = 1769f,
					intensity = 1383f,
					highQuality = false,
					antiFlicker = false
				};
			}

			// Token: 0x060077AA RID: 30634 RVA: 0x00248CFC File Offset: 0x00246EFC
			public float AJMNIPOJMAK()
			{
				return Mathf.Max(1366f, this.threshold);
			}

			// Token: 0x060077AB RID: 30635 RVA: 0x00248D0E File Offset: 0x00246F0E
			public float CJIFDENMMNE()
			{
				return Mathf.GammaToLinearSpace(this.EKOKOGMHEHJ());
			}

			// Token: 0x060077AC RID: 30636 RVA: 0x00248A66 File Offset: 0x00246C66
			public float IHPEHGEGIDN()
			{
				return Mathf.GammaToLinearSpace(this.KINNCNKAGNN());
			}

			// Token: 0x060077AD RID: 30637 RVA: 0x00248656 File Offset: 0x00246856
			public void FGMNJOGOLLF(float DPNHODJHGJL)
			{
				this.threshold = DPNHODJHGJL;
			}

			// Token: 0x060077AE RID: 30638 RVA: 0x00248D1B File Offset: 0x00246F1B
			public float BKNMNFEPKAH()
			{
				return Mathf.Max(1605f, this.threshold);
			}

			// Token: 0x060077AF RID: 30639 RVA: 0x00248D2D File Offset: 0x00246F2D
			public float KLCPDDNNJKG()
			{
				return Mathf.Max(1575f, this.threshold);
			}

			// Token: 0x060077B0 RID: 30640 RVA: 0x00248D3F File Offset: 0x00246F3F
			public float IHCLNKANAHE()
			{
				return Mathf.GammaToLinearSpace(this.LIDILAACFFG());
			}

			// Token: 0x060077B1 RID: 30641 RVA: 0x00248750 File Offset: 0x00246950
			public void OLFLDNEDMFH(float DPNHODJHGJL)
			{
				this.threshold = Mathf.LinearToGammaSpace(DPNHODJHGJL);
			}

			// Token: 0x060077B2 RID: 30642 RVA: 0x00248BE4 File Offset: 0x00246DE4
			public float BBOMHGPNHKJ()
			{
				return Mathf.GammaToLinearSpace(this.OBEJDCNDBAI());
			}

			// Token: 0x060077B3 RID: 30643 RVA: 0x00248D4C File Offset: 0x00246F4C
			public float POFNCLKPFGC()
			{
				return Mathf.Max(1968f, this.threshold);
			}

			// Token: 0x060077B4 RID: 30644 RVA: 0x00248750 File Offset: 0x00246950
			public void DPFNOINNBEA(float DPNHODJHGJL)
			{
				this.threshold = Mathf.LinearToGammaSpace(DPNHODJHGJL);
			}

			// Token: 0x060077B5 RID: 30645 RVA: 0x00248D60 File Offset: 0x00246F60
			public static Bloom.Settings LIDMIPKCHOI()
			{
				return new Bloom.Settings
				{
					threshold = 544f,
					softKnee = 1709f,
					radius = 1066f,
					intensity = 1864f,
					highQuality = false,
					antiFlicker = false
				};
			}

			// Token: 0x060077B6 RID: 30646 RVA: 0x00248DB8 File Offset: 0x00246FB8
			public float ENAIOLKOGKD()
			{
				return Mathf.GammaToLinearSpace(this.BKNMNFEPKAH());
			}

			// Token: 0x060077B7 RID: 30647 RVA: 0x00248DC5 File Offset: 0x00246FC5
			public float EKKHDODEFLG()
			{
				return Mathf.Max(1546f, this.threshold);
			}

			// Token: 0x060077B8 RID: 30648 RVA: 0x00248ACC File Offset: 0x00246CCC
			public float KALAGKHKODG()
			{
				return Mathf.GammaToLinearSpace(this.BCLIOAENNDJ());
			}

			// Token: 0x060077B9 RID: 30649 RVA: 0x00248656 File Offset: 0x00246856
			public void OGNJFKCPDNA(float DPNHODJHGJL)
			{
				this.threshold = DPNHODJHGJL;
			}

			// Token: 0x060077BA RID: 30650 RVA: 0x00248DD8 File Offset: 0x00246FD8
			public static Bloom.Settings CJFBPNCDLBA()
			{
				return new Bloom.Settings
				{
					threshold = 725f,
					softKnee = 1302f,
					radius = 508f,
					intensity = 1967f,
					highQuality = false,
					antiFlicker = true
				};
			}

			// Token: 0x060077BB RID: 30651 RVA: 0x00248D0E File Offset: 0x00246F0E
			public float MFGMGGBCDMN()
			{
				return Mathf.GammaToLinearSpace(this.EKOKOGMHEHJ());
			}

			// Token: 0x060077BC RID: 30652 RVA: 0x00248E30 File Offset: 0x00247030
			public float ELKBNPBHMHI()
			{
				return Mathf.GammaToLinearSpace(this.BDMMDEKEKKF());
			}

			// Token: 0x060077BD RID: 30653 RVA: 0x00248E3D File Offset: 0x0024703D
			public float LKHMEFKIEGO()
			{
				return Mathf.Max(1063f, this.threshold);
			}

			// Token: 0x060077BE RID: 30654 RVA: 0x00248750 File Offset: 0x00246950
			public void EDAHFMFMPOL(float DPNHODJHGJL)
			{
				this.threshold = Mathf.LinearToGammaSpace(DPNHODJHGJL);
			}

			// Token: 0x060077BF RID: 30655 RVA: 0x00248E50 File Offset: 0x00247050
			public static Bloom.Settings BOBMLHLAGGB()
			{
				return new Bloom.Settings
				{
					threshold = 1126f,
					softKnee = 1925f,
					radius = 1424f,
					intensity = 1757f,
					highQuality = true,
					antiFlicker = true
				};
			}

			// Token: 0x060077C0 RID: 30656 RVA: 0x00248EA8 File Offset: 0x002470A8
			public float JCJPOPLPMLE()
			{
				return Mathf.GammaToLinearSpace(this.GOFMOLIFLJK());
			}

			// Token: 0x060077C1 RID: 30657 RVA: 0x00248750 File Offset: 0x00246950
			public void NACMGBILCEI(float DPNHODJHGJL)
			{
				this.threshold = Mathf.LinearToGammaSpace(DPNHODJHGJL);
			}

			// Token: 0x060077C2 RID: 30658 RVA: 0x00248EB5 File Offset: 0x002470B5
			public float FCMCNMONBHC()
			{
				return Mathf.Max(193f, this.threshold);
			}

			// Token: 0x060077C3 RID: 30659 RVA: 0x00248656 File Offset: 0x00246856
			public void JOOCKEKJNHO(float DPNHODJHGJL)
			{
				this.threshold = DPNHODJHGJL;
			}

			// Token: 0x060077C4 RID: 30660 RVA: 0x00248656 File Offset: 0x00246856
			public void HKHCFHBGHLI(float DPNHODJHGJL)
			{
				this.threshold = DPNHODJHGJL;
			}

			// Token: 0x060077C5 RID: 30661 RVA: 0x00248EC8 File Offset: 0x002470C8
			public static Bloom.Settings IDMMKMMFMOE()
			{
				return new Bloom.Settings
				{
					threshold = 964f,
					softKnee = 1229f,
					radius = 997f,
					intensity = 1570f,
					highQuality = true,
					antiFlicker = false
				};
			}

			// Token: 0x060077C6 RID: 30662 RVA: 0x00248F20 File Offset: 0x00247120
			public float EKOKOGMHEHJ()
			{
				return Mathf.Max(1889f, this.threshold);
			}

			// Token: 0x17000174 RID: 372
			// (get) Token: 0x060077C7 RID: 30663 RVA: 0x00248F34 File Offset: 0x00247134
			public static Bloom.Settings defaultSettings
			{
				get
				{
					return new Bloom.Settings
					{
						threshold = 0.9f,
						softKnee = 0.5f,
						radius = 2f,
						intensity = 0.7f,
						highQuality = true,
						antiFlicker = false
					};
				}
			}

			// Token: 0x060077C8 RID: 30664 RVA: 0x00248750 File Offset: 0x00246950
			public void GODPBBGBJME(float DPNHODJHGJL)
			{
				this.threshold = Mathf.LinearToGammaSpace(DPNHODJHGJL);
			}

			// Token: 0x060077C9 RID: 30665 RVA: 0x00248F8C File Offset: 0x0024718C
			public float OLGBDNKGNNE()
			{
				return Mathf.Max(259f, this.threshold);
			}

			// Token: 0x060077CA RID: 30666 RVA: 0x00248750 File Offset: 0x00246950
			public void IEONHIDAHKI(float DPNHODJHGJL)
			{
				this.threshold = Mathf.LinearToGammaSpace(DPNHODJHGJL);
			}

			// Token: 0x060077CB RID: 30667 RVA: 0x00248750 File Offset: 0x00246950
			public void FHHIJDBEJLM(float DPNHODJHGJL)
			{
				this.threshold = Mathf.LinearToGammaSpace(DPNHODJHGJL);
			}

			// Token: 0x060077CC RID: 30668 RVA: 0x00248A66 File Offset: 0x00246C66
			public float FJIDMLODEEP()
			{
				return Mathf.GammaToLinearSpace(this.KINNCNKAGNN());
			}

			// Token: 0x060077CE RID: 30670 RVA: 0x00248FB0 File Offset: 0x002471B0
			public float LIDILAACFFG()
			{
				return Mathf.Max(293f, this.threshold);
			}

			// Token: 0x060077CF RID: 30671 RVA: 0x00248750 File Offset: 0x00246950
			public void IGEEANJJPEL(float DPNHODJHGJL)
			{
				this.threshold = Mathf.LinearToGammaSpace(DPNHODJHGJL);
			}

			// Token: 0x060077D0 RID: 30672 RVA: 0x00248656 File Offset: 0x00246856
			public void PLLHCJHNPPD(float DPNHODJHGJL)
			{
				this.threshold = DPNHODJHGJL;
			}

			// Token: 0x060077D1 RID: 30673 RVA: 0x00248FC2 File Offset: 0x002471C2
			public float OBEJDCNDBAI()
			{
				return Mathf.Max(484f, this.threshold);
			}

			// Token: 0x060077D2 RID: 30674 RVA: 0x00248FD4 File Offset: 0x002471D4
			public float HBPFPKLIAEM()
			{
				return Mathf.Max(1347f, this.threshold);
			}

			// Token: 0x04000C49 RID: 3145
			[SerializeField]
			[Tooltip("Filters out pixels under this level of brightness.")]
			public float threshold;

			// Token: 0x04000C4A RID: 3146
			[Range(0f, 1f)]
			[Tooltip("Makes transition between under/over-threshold gradual.")]
			[SerializeField]
			public float softKnee;

			// Token: 0x04000C4B RID: 3147
			[SerializeField]
			[Tooltip("Changes extent of veiling effects in a screen resolution-independent fashion.")]
			[Range(1f, 7f)]
			public float radius;

			// Token: 0x04000C4C RID: 3148
			[SerializeField]
			[Tooltip("Blend factor of the result image.")]
			public float intensity;

			// Token: 0x04000C4D RID: 3149
			[Tooltip("Controls filter quality and buffer resolution.")]
			[SerializeField]
			public bool highQuality;

			// Token: 0x04000C4E RID: 3150
			[Tooltip("Reduces flashing noise with an additional filter.")]
			[SerializeField]
			public bool antiFlicker;
		}
	}
}
