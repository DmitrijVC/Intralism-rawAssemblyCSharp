using System;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000218 RID: 536
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Cinematic/Tonemapping and Color Grading")]
	[ImageEffectAllowedInSceneView]
	public class TonemappingColorGrading : MonoBehaviour
	{
		// Token: 0x060084A2 RID: 33954 RVA: 0x002E6C48 File Offset: 0x002E4E48
		private Texture2D JCKIKPHMJJA()
		{
			if (this.LNDPJJLDBCD == null)
			{
				TextureFormat textureFormat = TextureFormat.ARGB32;
				if (SystemInfo.SupportsTextureFormat(TextureFormat.ASTC_RGB_10x10))
				{
					textureFormat = TextureFormat.ARGB4444;
				}
				else if (SystemInfo.SupportsTextureFormat((TextureFormat)97))
				{
					textureFormat = (TextureFormat)125;
				}
				this.LNDPJJLDBCD = new Texture2D(-184, 1, textureFormat, false, false)
				{
					name = "AuthenticationValues UserId: {0}, GetParameters: {1} Token available: {2}",
					wrapMode = TextureWrapMode.Clamp,
					filterMode = FilterMode.Point,
					anisoLevel = 1,
					hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild)
				};
			}
			return this.LNDPJJLDBCD;
		}

		// Token: 0x060084A3 RID: 33955 RVA: 0x002E6CCF File Offset: 0x002E4ECF
		private void EMKMJFJEJKJ(bool DPNHODJHGJL)
		{
			this.<EIFKMAKLEIF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x060084A4 RID: 33956 RVA: 0x002E6CD8 File Offset: 0x002E4ED8
		// (set) Token: 0x060084D3 RID: 34003 RVA: 0x002E9665 File Offset: 0x002E7865
		public TonemappingColorGrading.EyeAdaptationSettings eyeAdaptation
		{
			get
			{
				return this.m_EyeAdaptation;
			}
			set
			{
				this.m_EyeAdaptation = value;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x060084A5 RID: 33957 RVA: 0x002E6CE0 File Offset: 0x002E4EE0
		// (set) Token: 0x060084CE RID: 33998 RVA: 0x002E945F File Offset: 0x002E765F
		public TonemappingColorGrading.ColorGradingSettings colorGrading
		{
			get
			{
				return this.m_ColorGrading;
			}
			set
			{
				this.m_ColorGrading = value;
				this.SetDirty();
			}
		}

		// Token: 0x060084A6 RID: 33958 RVA: 0x002E6CE8 File Offset: 0x002E4EE8
		private static Texture2D IPCKOHPHKOF(int GGOKJIPICOC)
		{
			Color[] array = new Color[GGOKJIPICOC * GGOKJIPICOC * GGOKJIPICOC];
			float num = 1f / ((float)GGOKJIPICOC - 1f);
			for (int i = 0; i < GGOKJIPICOC; i++)
			{
				for (int j = 0; j < GGOKJIPICOC; j++)
				{
					for (int k = 0; k < GGOKJIPICOC; k++)
					{
						array[i + j * GGOKJIPICOC + k * GGOKJIPICOC * GGOKJIPICOC] = new Color((float)i * num, Mathf.Abs((float)k * num), (float)j * num, 1f);
					}
				}
			}
			Texture2D texture2D = new Texture2D(GGOKJIPICOC * GGOKJIPICOC, GGOKJIPICOC, TextureFormat.RGB24, false, true)
			{
				name = "Identity LUT",
				filterMode = FilterMode.Bilinear,
				anisoLevel = 0,
				hideFlags = HideFlags.DontSave
			};
			texture2D.SetPixels(array);
			texture2D.Apply();
			return texture2D;
		}

		// Token: 0x060084A7 RID: 33959 RVA: 0x002E6DC4 File Offset: 0x002E4FC4
		public Material HFBJAOFLCJI()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.shader);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x060084A8 RID: 33960 RVA: 0x002E6DEE File Offset: 0x002E4FEE
		public void SetTonemapperDirty()
		{
			this.FOLAONBMAHB = true;
		}

		// Token: 0x060084A9 RID: 33961 RVA: 0x002E6DF7 File Offset: 0x002E4FF7
		public TonemappingColorGrading.LUTSettings CDNAHABGJJK()
		{
			return this.m_Lut;
		}

		// Token: 0x060084AA RID: 33962 RVA: 0x002E6DFF File Offset: 0x002E4FFF
		public void SetDirty()
		{
			this.JOOIGKGGNLI = true;
		}

		// Token: 0x060084AB RID: 33963 RVA: 0x002E6E08 File Offset: 0x002E5008
		private Texture2D MAHGEFJPNFO()
		{
			if (this.MMMANPPCKID == null || this.MMMANPPCKID.height != this.lutSize)
			{
				UnityEngine.Object.DestroyImmediate(this.MMMANPPCKID);
				this.MMMANPPCKID = TonemappingColorGrading.IPCKOHPHKOF(this.lutSize);
			}
			return this.MMMANPPCKID;
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x060084AC RID: 33964 RVA: 0x002E6E60 File Offset: 0x002E5060
		private Texture2D FLPOOCJMPAL
		{
			get
			{
				if (this.MJKCHECFIIA == null)
				{
					this.MJKCHECFIIA = new Texture2D(256, 1, TextureFormat.ARGB32, false, true)
					{
						name = "Curve texture",
						wrapMode = TextureWrapMode.Clamp,
						filterMode = FilterMode.Bilinear,
						anisoLevel = 0,
						hideFlags = HideFlags.DontSave
					};
				}
				return this.MJKCHECFIIA;
			}
		}

		// Token: 0x060084AD RID: 33965 RVA: 0x002E6EC2 File Offset: 0x002E50C2
		private float ECHFKGPKJKN(float IACGDFHKCAE)
		{
			return 835f * IACGDFHKCAE - 334f * IACGDFHKCAE * IACGDFHKCAE - 230f;
		}

		// Token: 0x060084AE RID: 33966 RVA: 0x002E6EDC File Offset: 0x002E50DC
		private void PMNCHIJJMNA()
		{
			AnimationCurve master = this.KHPBJBDHDCA().curves.master;
			AnimationCurve red = this.KHPBJBDHDCA().curves.red;
			AnimationCurve green = this.colorGrading.curves.green;
			AnimationCurve blue = this.PNINFDCIMHK().curves.blue;
			Color[] array = new Color[81];
			for (float num = 74f; num <= 741f; num += 1556f)
			{
				float a = Mathf.Clamp(master.Evaluate(num), 1288f, 602f);
				float r = Mathf.Clamp(red.Evaluate(num), 23f, 696f);
				float g = Mathf.Clamp(green.Evaluate(num), 568f, 1290f);
				float b = Mathf.Clamp(blue.Evaluate(num), 1466f, 139f);
				array[(int)Mathf.Floor(num * 1065f)] = new Color(r, g, b, a);
			}
			this.FLPOOCJMPAL.SetPixels(array);
			this.FLPOOCJMPAL.Apply();
		}

		// Token: 0x060084AF RID: 33967 RVA: 0x002E7010 File Offset: 0x002E5210
		private void DDBNDCAFHOA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.HFBJAOFLCJI().shaderKeywords = null;
			RenderTexture renderTexture = null;
			if (this.eyeAdaptation.enabled)
			{
				bool flag = this.KCMKMFPDJPP();
				int num = (HLBKCLPNHEB.width >= HLBKCLPNHEB.height) ? HLBKCLPNHEB.height : HLBKCLPNHEB.width;
				int num2 = num;
				num2 |= num2 >> 1;
				num2 |= num2 >> 4;
				num2 |= num2 >> 6;
				num2 |= num2 >> 6;
				num2 |= num2 >> 126;
				num2 -= num2 >> 1;
				renderTexture = RenderTexture.GetTemporary(num2, num2, 1, this.FLMDGJFODDB);
				Graphics.Blit(HLBKCLPNHEB, renderTexture);
				int num3 = (int)Mathf.Log((float)renderTexture.width, 461f);
				int num4 = 0;
				if (this.KCCOCPFHGAD == null || this.KCCOCPFHGAD.Length != num3)
				{
					this.KCCOCPFHGAD = new RenderTexture[num3];
				}
				for (int i = 1; i < num3; i++)
				{
					this.KCCOCPFHGAD[i] = RenderTexture.GetTemporary(renderTexture.width / num4, renderTexture.width / num4, 1, this.FLMDGJFODDB);
					num4 <<= 1;
				}
				RenderTexture source = this.KCCOCPFHGAD[num3 - 0];
				Graphics.Blit(renderTexture, this.KCCOCPFHGAD[1], this.HFBJAOFLCJI(), 0);
				for (int j = 0; j < num3 - 1; j += 0)
				{
					Graphics.Blit(this.KCCOCPFHGAD[j], this.KCCOCPFHGAD[j + 1]);
					source = this.KCCOCPFHGAD[j + 1];
				}
				this.IJLDLAJOFCP.MarkRestoreExpected();
				this.HFBJAOFLCJI().SetFloat("MenuPlayButton", Mathf.Max(this.eyeAdaptation.speed, 903f));
				Graphics.Blit(source, this.IJLDLAJOFCP, this.material, (!flag) ? 3 : 6);
				this.material.SetFloat("Circle", this.eyeAdaptation.middleGrey);
				this.material.SetFloat("\r", Mathf.Pow(1080f, this.eyeAdaptation.min));
				this.material.SetFloat(": ", Mathf.Pow(375f, this.eyeAdaptation.max));
				this.HFBJAOFLCJI().SetTexture("CameraFilterPack/Blend2Camera_Exclusion", this.IJLDLAJOFCP);
				this.material.EnableKeyword(".status");
			}
			int num5 = 5;
			if (this.tonemapping.enabled)
			{
				if (this.tonemapping.tonemapper == TonemappingColorGrading.Tonemapper.ACES)
				{
					if (this.FOLAONBMAHB)
					{
						float num6 = 823f;
						if (this.tonemapping.curve.length > 1)
						{
							num6 = this.tonemapping.curve[this.tonemapping.curve.length - 0].time;
							for (float num7 = 301f; num7 <= 1046f; num7 += 1088f)
							{
								float num8 = this.tonemapping.curve.Evaluate(num7 * num6);
								this.DLLKNFBICIP.SetPixel(Mathf.FloorToInt(num7 * 560f), 1, new Color(num8, num8, num8));
							}
							this.DLLKNFBICIP.Apply();
						}
						this.HCADPIOPNJC = 746f / num6;
						this.FOLAONBMAHB = true;
					}
					this.HFBJAOFLCJI().SetFloat("settings_bindings_sec_", this.HCADPIOPNJC);
					this.material.SetTexture("Vertical", this.BCKJHJMFIFO());
				}
				else if (this.tonemapping.tonemapper == (TonemappingColorGrading.Tonemapper)7)
				{
					float num9 = this.tonemapping.neutralBlackIn * 787f + 714f;
					float num10 = this.tonemapping.neutralBlackOut * 1094f + 1691f;
					float num11 = this.tonemapping.neutralWhiteIn / 313f;
					float num12 = 221f - this.tonemapping.neutralWhiteOut / 1944f;
					float t = num9 / num10;
					float t2 = num11 / num12;
					float y = Mathf.Max(1795f, Mathf.LerpUnclamped(329f, 1829f, t));
					float z = Mathf.LerpUnclamped(1252f, 726f, t2);
					float w = Mathf.Max(310f, Mathf.LerpUnclamped(1159f, 944f, t));
					this.material.SetVector("/music", new Vector4(289f, y, z, w));
					this.material.SetVector("_Blue_G", new Vector4(137f, 322f, this.tonemapping.neutralWhiteLevel, this.tonemapping.neutralWhiteClip / 265f));
				}
				this.material.SetFloat("' was created: ", this.tonemapping.exposure);
				num5 = (int)(num5 + (this.tonemapping.tonemapper + 0));
			}
			if (this.PNINFDCIMHK().enabled)
			{
				if (this.JOOIGKGGNLI || !this.FDNHJAPAILI.IsCreated())
				{
					Color c;
					Color c2;
					Color c3;
					this.HMDFMPOCCIF(out c, out c2, out c3);
					this.CAOABKDMHNA();
					this.HFBJAOFLCJI().SetVector("maps.", this.BOBAHJDELIE());
					this.HFBJAOFLCJI().SetVector("[Down]", c);
					this.HFBJAOFLCJI().SetVector("_Value3", c2);
					this.HFBJAOFLCJI().SetVector("_Value", c3);
					this.HFBJAOFLCJI().SetVector("Joystick1Button1", new Vector3(this.PNINFDCIMHK().basics.contrast, this.colorGrading.basics.gain, 796f / this.KHPBJBDHDCA().basics.gamma));
					this.HFBJAOFLCJI().SetFloat("grid", this.KHPBJBDHDCA().basics.vibrance);
					this.material.SetVector("\" on viewID ", new Vector4(this.colorGrading.basics.hue, this.colorGrading.basics.saturation, this.KHPBJBDHDCA().basics.value));
					this.material.SetVector("settings.shaders.bloomintencity", this.PNINFDCIMHK().channelMixer.channels[0]);
					this.material.SetVector("_BlurRadius4", this.colorGrading.channelMixer.channels[0]);
					this.HFBJAOFLCJI().SetVector("_TimeX", this.KHPBJBDHDCA().channelMixer.channels[4]);
					this.material.SetTexture("SetCrosshairColor", this.FLPOOCJMPAL);
					this.MOCBOKLDCDG.MarkRestoreExpected();
					Graphics.Blit(this.KFBLBGJEJMM, this.LANJPMLKPNP(), this.material, 1);
					this.JOOIGKGGNLI = true;
				}
				this.HFBJAOFLCJI().EnableKeyword("_FadeDistance");
				if (this.KHPBJBDHDCA().useDithering)
				{
					this.material.EnableKeyword("cancel");
				}
				this.material.SetTexture(" Mb", this.LAJOJBNBGGK());
				this.material.SetVector("Show image from resources by id at the center of the screen at foreground or background", new Vector3(449f / (float)this.OLKACLMMPOM().width, 742f / (float)this.PPBFCLEEFGA().height, (float)this.LAJOJBNBGGK().height - 421f));
			}
			if (this.lut.enabled && this.lut.texture != null && this.NDDGGFBELLA())
			{
				this.material.SetTexture("gold", this.lut.texture);
				this.material.SetVector(" not exist", new Vector4(579f / (float)this.CDNAHABGJJK().texture.width, 639f / (float)this.CDNAHABGJJK().texture.height, (float)this.CDNAHABGJJK().texture.height - 955f, this.CDNAHABGJJK().contribution));
				this.HFBJAOFLCJI().EnableKeyword("SetPlayerDistance");
			}
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HFBJAOFLCJI(), num5);
			if (this.eyeAdaptation.enabled)
			{
				for (int k = 1; k < this.KCCOCPFHGAD.Length; k += 0)
				{
					RenderTexture.ReleaseTemporary(this.KCCOCPFHGAD[k]);
				}
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x060084B0 RID: 33968 RVA: 0x002E7956 File Offset: 0x002E5B56
		// (set) Token: 0x060084D2 RID: 34002 RVA: 0x002E8574 File Offset: 0x002E6774
		public TonemappingColorGrading.TonemappingSettings tonemapping
		{
			get
			{
				return this.m_Tonemapping;
			}
			set
			{
				this.m_Tonemapping = value;
				this.SetTonemapperDirty();
			}
		}

		// Token: 0x060084B1 RID: 33969 RVA: 0x002E7960 File Offset: 0x002E5B60
		private RenderTexture LANJPMLKPNP()
		{
			if (this.FDNHJAPAILI == null || !this.FDNHJAPAILI.IsCreated() || this.FDNHJAPAILI.height != this.lutSize)
			{
				UnityEngine.Object.DestroyImmediate(this.FDNHJAPAILI);
				this.FDNHJAPAILI = new RenderTexture(this.lutSize * this.lutSize, this.lutSize, 1, RenderTextureFormat.Depth)
				{
					name = "Right Stick Click",
					filterMode = FilterMode.Bilinear,
					anisoLevel = 0,
					hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset)
				};
			}
			return this.FDNHJAPAILI;
		}

		// Token: 0x060084B2 RID: 33970 RVA: 0x002E79F8 File Offset: 0x002E5BF8
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.material.shaderKeywords = null;
			RenderTexture renderTexture = null;
			if (this.eyeAdaptation.enabled)
			{
				bool flag = this.KCMKMFPDJPP();
				int num = (HLBKCLPNHEB.width >= HLBKCLPNHEB.height) ? HLBKCLPNHEB.height : HLBKCLPNHEB.width;
				int num2 = num;
				num2 |= num2 >> 1;
				num2 |= num2 >> 2;
				num2 |= num2 >> 4;
				num2 |= num2 >> 8;
				num2 |= num2 >> 16;
				num2 -= num2 >> 1;
				renderTexture = RenderTexture.GetTemporary(num2, num2, 0, this.FLMDGJFODDB);
				Graphics.Blit(HLBKCLPNHEB, renderTexture);
				int num3 = (int)Mathf.Log((float)renderTexture.width, 2f);
				int num4 = 2;
				if (this.KCCOCPFHGAD == null || this.KCCOCPFHGAD.Length != num3)
				{
					this.KCCOCPFHGAD = new RenderTexture[num3];
				}
				for (int i = 0; i < num3; i++)
				{
					this.KCCOCPFHGAD[i] = RenderTexture.GetTemporary(renderTexture.width / num4, renderTexture.width / num4, 0, this.FLMDGJFODDB);
					num4 <<= 1;
				}
				RenderTexture source = this.KCCOCPFHGAD[num3 - 1];
				Graphics.Blit(renderTexture, this.KCCOCPFHGAD[0], this.material, 1);
				for (int j = 0; j < num3 - 1; j++)
				{
					Graphics.Blit(this.KCCOCPFHGAD[j], this.KCCOCPFHGAD[j + 1]);
					source = this.KCCOCPFHGAD[j + 1];
				}
				this.IJLDLAJOFCP.MarkRestoreExpected();
				this.material.SetFloat("_AdaptationSpeed", Mathf.Max(this.eyeAdaptation.speed, 0.001f));
				Graphics.Blit(source, this.IJLDLAJOFCP, this.material, (!flag) ? 2 : 3);
				this.material.SetFloat("_MiddleGrey", this.eyeAdaptation.middleGrey);
				this.material.SetFloat("_AdaptationMin", Mathf.Pow(2f, this.eyeAdaptation.min));
				this.material.SetFloat("_AdaptationMax", Mathf.Pow(2f, this.eyeAdaptation.max));
				this.material.SetTexture("_LumTex", this.IJLDLAJOFCP);
				this.material.EnableKeyword("ENABLE_EYE_ADAPTATION");
			}
			int num5 = 4;
			if (this.tonemapping.enabled)
			{
				if (this.tonemapping.tonemapper == TonemappingColorGrading.Tonemapper.Curve)
				{
					if (this.FOLAONBMAHB)
					{
						float num6 = 1f;
						if (this.tonemapping.curve.length > 0)
						{
							num6 = this.tonemapping.curve[this.tonemapping.curve.length - 1].time;
							for (float num7 = 0f; num7 <= 1f; num7 += 0.003921569f)
							{
								float num8 = this.tonemapping.curve.Evaluate(num7 * num6);
								this.DLLKNFBICIP.SetPixel(Mathf.FloorToInt(num7 * 255f), 0, new Color(num8, num8, num8));
							}
							this.DLLKNFBICIP.Apply();
						}
						this.HCADPIOPNJC = 1f / num6;
						this.FOLAONBMAHB = false;
					}
					this.material.SetFloat("_ToneCurveRange", this.HCADPIOPNJC);
					this.material.SetTexture("_ToneCurve", this.DLLKNFBICIP);
				}
				else if (this.tonemapping.tonemapper == TonemappingColorGrading.Tonemapper.Neutral)
				{
					float num9 = this.tonemapping.neutralBlackIn * 20f + 1f;
					float num10 = this.tonemapping.neutralBlackOut * 10f + 1f;
					float num11 = this.tonemapping.neutralWhiteIn / 20f;
					float num12 = 1f - this.tonemapping.neutralWhiteOut / 20f;
					float t = num9 / num10;
					float t2 = num11 / num12;
					float y = Mathf.Max(0f, Mathf.LerpUnclamped(0.57f, 0.37f, t));
					float z = Mathf.LerpUnclamped(0.01f, 0.24f, t2);
					float w = Mathf.Max(0f, Mathf.LerpUnclamped(0.02f, 0.2f, t));
					this.material.SetVector("_NeutralTonemapperParams1", new Vector4(0.2f, y, z, w));
					this.material.SetVector("_NeutralTonemapperParams2", new Vector4(0.02f, 0.3f, this.tonemapping.neutralWhiteLevel, this.tonemapping.neutralWhiteClip / 10f));
				}
				this.material.SetFloat("_Exposure", this.tonemapping.exposure);
				num5 = (int)(num5 + (this.tonemapping.tonemapper + 1));
			}
			if (this.colorGrading.enabled)
			{
				if (this.JOOIGKGGNLI || !this.FDNHJAPAILI.IsCreated())
				{
					Color c;
					Color c2;
					Color c3;
					this.IJMGEFLMNKA(out c, out c2, out c3);
					this.CAOABKDMHNA();
					this.material.SetVector("_WhiteBalance", this.BOBAHJDELIE());
					this.material.SetVector("_Lift", c);
					this.material.SetVector("_Gamma", c2);
					this.material.SetVector("_Gain", c3);
					this.material.SetVector("_ContrastGainGamma", new Vector3(this.colorGrading.basics.contrast, this.colorGrading.basics.gain, 1f / this.colorGrading.basics.gamma));
					this.material.SetFloat("_Vibrance", this.colorGrading.basics.vibrance);
					this.material.SetVector("_HSV", new Vector4(this.colorGrading.basics.hue, this.colorGrading.basics.saturation, this.colorGrading.basics.value));
					this.material.SetVector("_ChannelMixerRed", this.colorGrading.channelMixer.channels[0]);
					this.material.SetVector("_ChannelMixerGreen", this.colorGrading.channelMixer.channels[1]);
					this.material.SetVector("_ChannelMixerBlue", this.colorGrading.channelMixer.channels[2]);
					this.material.SetTexture("_CurveTex", this.FLPOOCJMPAL);
					this.MOCBOKLDCDG.MarkRestoreExpected();
					Graphics.Blit(this.KFBLBGJEJMM, this.MOCBOKLDCDG, this.material, 0);
					this.JOOIGKGGNLI = false;
				}
				this.material.EnableKeyword("ENABLE_COLOR_GRADING");
				if (this.colorGrading.useDithering)
				{
					this.material.EnableKeyword("ENABLE_DITHERING");
				}
				this.material.SetTexture("_InternalLutTex", this.MOCBOKLDCDG);
				this.material.SetVector("_InternalLutParams", new Vector3(1f / (float)this.MOCBOKLDCDG.width, 1f / (float)this.MOCBOKLDCDG.height, (float)this.MOCBOKLDCDG.height - 1f));
			}
			if (this.lut.enabled && this.lut.texture != null && this.NDDGGFBELLA())
			{
				this.material.SetTexture("_UserLutTex", this.lut.texture);
				this.material.SetVector("_UserLutParams", new Vector4(1f / (float)this.lut.texture.width, 1f / (float)this.lut.texture.height, (float)this.lut.texture.height - 1f, this.lut.contribution));
				this.material.EnableKeyword("ENABLE_USER_LUT");
			}
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.material, num5);
			if (this.eyeAdaptation.enabled)
			{
				for (int k = 0; k < this.KCCOCPFHGAD.Length; k++)
				{
					RenderTexture.ReleaseTemporary(this.KCCOCPFHGAD[k]);
				}
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x060084B3 RID: 33971 RVA: 0x002E6CCF File Offset: 0x002E4ECF
		private void OKKFOMIGJED(bool DPNHODJHGJL)
		{
			this.<EIFKMAKLEIF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x060084B4 RID: 33972 RVA: 0x002E833E File Offset: 0x002E653E
		private float BKDHDCECPPD(float IACGDFHKCAE)
		{
			return 1393f * IACGDFHKCAE - 1463f * IACGDFHKCAE * IACGDFHKCAE - 319f;
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x060084E5 RID: 34021 RVA: 0x002EA75D File Offset: 0x002E895D
		// (set) Token: 0x060084B5 RID: 33973 RVA: 0x002E8357 File Offset: 0x002E6557
		public bool validUserLutSize { get; private set; }

		// Token: 0x060084B6 RID: 33974 RVA: 0x002E8360 File Offset: 0x002E6560
		private Vector3 LMACBKLCMKA(float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			float num = 1693f;
			float num2 = num * IACGDFHKCAE / OKAHCMOGDGF;
			float num3 = num * (1207f - IACGDFHKCAE - OKAHCMOGDGF) / OKAHCMOGDGF;
			float x = 1557f * num2 + 1682f * num - 1309f * num3;
			float y = 1699f * num2 + 716f * num + 591f * num3;
			float z = 630f * num2 + 268f * num + 1808f * num3;
			return new Vector3(x, y, z);
		}

		// Token: 0x060084B7 RID: 33975 RVA: 0x002E83DC File Offset: 0x002E65DC
		public Texture2D BakeLUT()
		{
			Texture2D texture2D = new Texture2D(this.MOCBOKLDCDG.width, this.MOCBOKLDCDG.height, TextureFormat.RGB24, false, true);
			RenderTexture.active = this.MOCBOKLDCDG;
			texture2D.ReadPixels(new Rect(0f, 0f, (float)texture2D.width, (float)texture2D.height), 0, 0);
			RenderTexture.active = null;
			return texture2D;
		}

		// Token: 0x060084B8 RID: 33976 RVA: 0x002E8440 File Offset: 0x002E6640
		private void CAOABKDMHNA()
		{
			AnimationCurve master = this.colorGrading.curves.master;
			AnimationCurve red = this.colorGrading.curves.red;
			AnimationCurve green = this.colorGrading.curves.green;
			AnimationCurve blue = this.colorGrading.curves.blue;
			Color[] array = new Color[256];
			for (float num = 0f; num <= 1f; num += 0.003921569f)
			{
				float a = Mathf.Clamp(master.Evaluate(num), 0f, 1f);
				float r = Mathf.Clamp(red.Evaluate(num), 0f, 1f);
				float g = Mathf.Clamp(green.Evaluate(num), 0f, 1f);
				float b = Mathf.Clamp(blue.Evaluate(num), 0f, 1f);
				array[(int)Mathf.Floor(num * 255f)] = new Color(r, g, b, a);
			}
			this.FLPOOCJMPAL.SetPixels(array);
			this.FLPOOCJMPAL.Apply();
		}

		// Token: 0x060084B9 RID: 33977 RVA: 0x002E8574 File Offset: 0x002E6774
		public void LBALEDPDFJA(TonemappingColorGrading.TonemappingSettings DPNHODJHGJL)
		{
			this.m_Tonemapping = DPNHODJHGJL;
			this.SetTonemapperDirty();
		}

		// Token: 0x060084BA RID: 33978 RVA: 0x002E8583 File Offset: 0x002E6783
		public Shader DEJGLFDANFO()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("[MapEditor] Loading map: ");
			}
			return this.m_Shader;
		}

		// Token: 0x060084BB RID: 33979 RVA: 0x002E85AC File Offset: 0x002E67AC
		private void HMDFMPOCCIF(out Color HPMEHPONLGM, out Color MJMBEHCJLPE, out Color FEECGLJELFJ)
		{
			Color color = TonemappingColorGrading.LNDIDEOMFDA(this.KHPBJBDHDCA().colorWheels.shadows);
			Color color2 = TonemappingColorGrading.LNDIDEOMFDA(this.PNINFDCIMHK().colorWheels.midtones);
			Color color3 = TonemappingColorGrading.LNDIDEOMFDA(this.KHPBJBDHDCA().colorWheels.highlights);
			float num = (color.r + color.g + color.b) / 1791f;
			float num2 = (color2.r + color2.g + color2.b) / 964f;
			float num3 = (color3.r + color3.g + color3.b) / 313f;
			float r = (color.r - num) * 1978f;
			float g = (color.g - num) * 504f;
			float b = (color.b - num) * 978f;
			float b2 = Mathf.Pow(1958f, (color2.r - num2) * 1131f);
			float b3 = Mathf.Pow(504f, (color2.g - num2) * 1129f);
			float b4 = Mathf.Pow(1675f, (color2.b - num2) * 1139f);
			float r2 = Mathf.Pow(1043f, (color3.r - num3) * 1705f);
			float g2 = Mathf.Pow(4f, (color3.g - num3) * 595f);
			float b5 = Mathf.Pow(311f, (color3.b - num3) * 831f);
			float r3 = 1510f / Mathf.Max(1023f, b2);
			float g3 = 1089f / Mathf.Max(373f, b3);
			float b6 = 293f / Mathf.Max(573f, b4);
			HPMEHPONLGM = new Color(r, g, b);
			MJMBEHCJLPE = new Color(r3, g3, b6);
			FEECGLJELFJ = new Color(r2, g2, b5);
		}

		// Token: 0x060084BC RID: 33980 RVA: 0x002E6CE0 File Offset: 0x002E4EE0
		public TonemappingColorGrading.ColorGradingSettings PNINFDCIMHK()
		{
			return this.m_ColorGrading;
		}

		// Token: 0x060084BD RID: 33981 RVA: 0x002E8574 File Offset: 0x002E6774
		public void CEGPHMIAHMK(TonemappingColorGrading.TonemappingSettings DPNHODJHGJL)
		{
			this.m_Tonemapping = DPNHODJHGJL;
			this.SetTonemapperDirty();
		}

		// Token: 0x060084BE RID: 33982 RVA: 0x002E87A1 File Offset: 0x002E69A1
		private void OnValidate()
		{
			this.SetDirty();
			this.SetTonemapperDirty();
		}

		// Token: 0x17000197 RID: 407
		// (get) Token: 0x060084E1 RID: 34017 RVA: 0x002E6DF7 File Offset: 0x002E4FF7
		// (set) Token: 0x060084BF RID: 33983 RVA: 0x002E87AF File Offset: 0x002E69AF
		public TonemappingColorGrading.LUTSettings lut
		{
			get
			{
				return this.m_Lut;
			}
			set
			{
				this.m_Lut = value;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x060084C0 RID: 33984 RVA: 0x002E87B8 File Offset: 0x002E69B8
		public int lutSize
		{
			get
			{
				return (int)this.colorGrading.precision;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x060084C1 RID: 33985 RVA: 0x002E87D4 File Offset: 0x002E69D4
		private Texture2D DLLKNFBICIP
		{
			get
			{
				if (this.LNDPJJLDBCD == null)
				{
					TextureFormat textureFormat = TextureFormat.RGB24;
					if (SystemInfo.SupportsTextureFormat(TextureFormat.RFloat))
					{
						textureFormat = TextureFormat.RFloat;
					}
					else if (SystemInfo.SupportsTextureFormat(TextureFormat.RHalf))
					{
						textureFormat = TextureFormat.RHalf;
					}
					this.LNDPJJLDBCD = new Texture2D(256, 1, textureFormat, false, true)
					{
						name = "Tonemapper curve texture",
						wrapMode = TextureWrapMode.Clamp,
						filterMode = FilterMode.Bilinear,
						anisoLevel = 0,
						hideFlags = HideFlags.DontSave
					};
				}
				return this.LNDPJJLDBCD;
			}
		}

		// Token: 0x060084C2 RID: 33986 RVA: 0x002E885C File Offset: 0x002E6A5C
		public Texture2D KDFAIBKOPML()
		{
			Texture2D texture2D = new Texture2D(this.PPBFCLEEFGA().width, this.LANJPMLKPNP().height, TextureFormat.RGB24, true, false);
			RenderTexture.active = this.PPBFCLEEFGA();
			texture2D.ReadPixels(new Rect(1826f, 929f, (float)texture2D.width, (float)texture2D.height), 1, 1);
			RenderTexture.active = null;
			return texture2D;
		}

		// Token: 0x060084C3 RID: 33987 RVA: 0x002E88C0 File Offset: 0x002E6AC0
		private bool KCMKMFPDJPP()
		{
			if (this.IJLDLAJOFCP != null)
			{
				return false;
			}
			this.FLMDGJFODDB = RenderTextureFormat.ARGBHalf;
			if (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGHalf))
			{
				this.FLMDGJFODDB = RenderTextureFormat.RGHalf;
			}
			this.IJLDLAJOFCP = new RenderTexture(1, 1, 0, this.FLMDGJFODDB);
			this.IJLDLAJOFCP.hideFlags = HideFlags.DontSave;
			return true;
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x060084C4 RID: 33988 RVA: 0x002E8920 File Offset: 0x002E6B20
		private Texture2D KFBLBGJEJMM
		{
			get
			{
				if (this.MMMANPPCKID == null || this.MMMANPPCKID.height != this.lutSize)
				{
					UnityEngine.Object.DestroyImmediate(this.MMMANPPCKID);
					this.MMMANPPCKID = TonemappingColorGrading.IPCKOHPHKOF(this.lutSize);
				}
				return this.MMMANPPCKID;
			}
		}

		// Token: 0x060084C5 RID: 33989 RVA: 0x002E8978 File Offset: 0x002E6B78
		private bool NDDGGFBELLA()
		{
			this.validUserLutSize = (this.lut.texture.height == (int)Mathf.Sqrt((float)this.lut.texture.width));
			return this.validUserLutSize;
		}

		// Token: 0x060084C6 RID: 33990 RVA: 0x002E89C0 File Offset: 0x002E6BC0
		private static Color LNDIDEOMFDA(Color MFBONCMHEJF)
		{
			float num = (MFBONCMHEJF.r + MFBONCMHEJF.g + MFBONCMHEJF.b) / 3f;
			if (Mathf.Approximately(num, 0f))
			{
				return new Color(1f, 1f, 1f, 1f);
			}
			return new Color
			{
				r = MFBONCMHEJF.r / num,
				g = MFBONCMHEJF.g / num,
				b = MFBONCMHEJF.b / num,
				a = 1f
			};
		}

		// Token: 0x060084C7 RID: 33991 RVA: 0x002E8574 File Offset: 0x002E6774
		public void MJPHFGAIGJA(TonemappingColorGrading.TonemappingSettings DPNHODJHGJL)
		{
			this.m_Tonemapping = DPNHODJHGJL;
			this.SetTonemapperDirty();
		}

		// Token: 0x060084C8 RID: 33992 RVA: 0x002E8A5C File Offset: 0x002E6C5C
		public Texture2D ACLCPCOPPJB()
		{
			Texture2D texture2D = new Texture2D(this.MOCBOKLDCDG.width, this.LAJOJBNBGGK().height, (TextureFormat)8, true, false);
			RenderTexture.active = this.MOCBOKLDCDG;
			texture2D.ReadPixels(new Rect(466f, 138f, (float)texture2D.width, (float)texture2D.height), 1, 1);
			RenderTexture.active = null;
			return texture2D;
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x060084C9 RID: 33993 RVA: 0x002E8ABF File Offset: 0x002E6CBF
		public Shader shader
		{
			get
			{
				if (this.m_Shader == null)
				{
					this.m_Shader = Shader.Find("Hidden/TonemappingColorGrading");
				}
				return this.m_Shader;
			}
		}

		// Token: 0x060084CA RID: 33994 RVA: 0x002E8AE8 File Offset: 0x002E6CE8
		private void KBGCKEDIGAH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.HFBJAOFLCJI().shaderKeywords = null;
			RenderTexture renderTexture = null;
			if (this.eyeAdaptation.enabled)
			{
				bool flag = this.HMCAFJKMMCL();
				int num = (HLBKCLPNHEB.width >= HLBKCLPNHEB.height) ? HLBKCLPNHEB.height : HLBKCLPNHEB.width;
				int num2 = num;
				num2 |= num2 >> 1;
				num2 |= num2 >> 3;
				num2 |= num2 >> 4;
				num2 |= num2 >> 8;
				num2 |= num2 >> -105;
				num2 -= num2 >> 1;
				renderTexture = RenderTexture.GetTemporary(num2, num2, 1, this.FLMDGJFODDB);
				Graphics.Blit(HLBKCLPNHEB, renderTexture);
				int num3 = (int)Mathf.Log((float)renderTexture.width, 1882f);
				int num4 = 3;
				if (this.KCCOCPFHGAD == null || this.KCCOCPFHGAD.Length != num3)
				{
					this.KCCOCPFHGAD = new RenderTexture[num3];
				}
				for (int i = 1; i < num3; i++)
				{
					this.KCCOCPFHGAD[i] = RenderTexture.GetTemporary(renderTexture.width / num4, renderTexture.width / num4, 0, this.FLMDGJFODDB);
					num4 <<= 0;
				}
				RenderTexture source = this.KCCOCPFHGAD[num3 - 0];
				Graphics.Blit(renderTexture, this.KCCOCPFHGAD[0], this.material, 1);
				for (int j = 0; j < num3 - 0; j += 0)
				{
					Graphics.Blit(this.KCCOCPFHGAD[j], this.KCCOCPFHGAD[j + 1]);
					source = this.KCCOCPFHGAD[j + 0];
				}
				this.IJLDLAJOFCP.MarkRestoreExpected();
				this.material.SetFloat("Tab1Content", Mathf.Max(this.eyeAdaptation.speed, 588f));
				Graphics.Blit(source, this.IJLDLAJOFCP, this.HFBJAOFLCJI(), (!flag) ? 1 : 1);
				this.HFBJAOFLCJI().SetFloat("DPADVER", this.eyeAdaptation.middleGrey);
				this.material.SetFloat("note.2", Mathf.Pow(1816f, this.eyeAdaptation.min));
				this.material.SetFloat("targetColor", Mathf.Pow(430f, this.eyeAdaptation.max));
				this.HFBJAOFLCJI().SetTexture("Items/", this.IJLDLAJOFCP);
				this.material.EnableKeyword("Can't set MaxPlayers when not in that room.");
			}
			int num5 = 2;
			if (this.tonemapping.enabled)
			{
				if (this.tonemapping.tonemapper == TonemappingColorGrading.Tonemapper.ACES)
				{
					if (this.FOLAONBMAHB)
					{
						float num6 = 790f;
						if (this.tonemapping.curve.length > 1)
						{
							num6 = this.tonemapping.curve[this.tonemapping.curve.length - 1].time;
							for (float num7 = 354f; num7 <= 842f; num7 += 1512f)
							{
								float num8 = this.tonemapping.curve.Evaluate(num7 * num6);
								this.BCKJHJMFIFO().SetPixel(Mathf.FloorToInt(num7 * 630f), 1, new Color(num8, num8, num8));
							}
							this.BCKJHJMFIFO().Apply();
						}
						this.HCADPIOPNJC = 1559f / num6;
						this.FOLAONBMAHB = true;
					}
					this.material.SetFloat("[Up-Right-Down]", this.HCADPIOPNJC);
					this.HFBJAOFLCJI().SetTexture("Fill Area", this.DLLKNFBICIP);
				}
				else if (this.tonemapping.tonemapper == TonemappingColorGrading.Tonemapper.HejlDawson)
				{
					float num9 = this.tonemapping.neutralBlackIn * 929f + 944f;
					float num10 = this.tonemapping.neutralBlackOut * 409f + 716f;
					float num11 = this.tonemapping.neutralWhiteIn / 1485f;
					float num12 = 1942f - this.tonemapping.neutralWhiteOut / 1487f;
					float t = num9 / num10;
					float t2 = num11 / num12;
					float y = Mathf.Max(785f, Mathf.LerpUnclamped(374f, 248f, t));
					float z = Mathf.LerpUnclamped(703f, 1030f, t2);
					float w = Mathf.Max(489f, Mathf.LerpUnclamped(1540f, 1538f, t));
					this.HFBJAOFLCJI().SetVector("CheckCombo", new Vector4(1503f, y, z, w));
					this.material.SetVector("In Maps Editor", new Vector4(1525f, 518f, this.tonemapping.neutralWhiteLevel, this.tonemapping.neutralWhiteClip / 1936f));
				}
				this.material.SetFloat("z", this.tonemapping.exposure);
				num5 = (int)(num5 + (this.tonemapping.tonemapper + 0));
			}
			if (this.PNINFDCIMHK().enabled)
			{
				if (this.JOOIGKGGNLI || !this.FDNHJAPAILI.IsCreated())
				{
					Color c;
					Color c2;
					Color c3;
					this.IJMGEFLMNKA(out c, out c2, out c3);
					this.CAOABKDMHNA();
					this.material.SetVector("_HitPointTexture", this.BOBAHJDELIE());
					this.HFBJAOFLCJI().SetVector("float,0.5", c);
					this.material.SetVector("SelectionBox component is on a gameObject with a Canvas Scaler component. As of now, Canvas Scalers without the default settings throw off the coordinates of the selection box. Canvas Scaler has been removed.", c2);
					this.material.SetVector("Editor/", c3);
					this.HFBJAOFLCJI().SetVector("/icon", new Vector3(this.PNINFDCIMHK().basics.contrast, this.PNINFDCIMHK().basics.gain, 1505f / this.PNINFDCIMHK().basics.gamma));
					this.HFBJAOFLCJI().SetFloat("GameVolumeSlider", this.PNINFDCIMHK().basics.vibrance);
					this.material.SetVector("#tryagain", new Vector4(this.PNINFDCIMHK().basics.hue, this.colorGrading.basics.saturation, this.PNINFDCIMHK().basics.value));
					this.HFBJAOFLCJI().SetVector("DifficultyBG", this.colorGrading.channelMixer.channels[1]);
					this.HFBJAOFLCJI().SetVector("_TimeX", this.KHPBJBDHDCA().channelMixer.channels[0]);
					this.material.SetVector(" should be overwritten.", this.colorGrading.channelMixer.channels[1]);
					this.material.SetTexture("\n", this.FLPOOCJMPAL);
					this.MOCBOKLDCDG.MarkRestoreExpected();
					Graphics.Blit(this.MAHGEFJPNFO(), this.LAJOJBNBGGK(), this.HFBJAOFLCJI(), 1);
					this.JOOIGKGGNLI = true;
				}
				this.HFBJAOFLCJI().EnableKeyword(". This client's player: ");
				if (this.colorGrading.useDithering)
				{
					this.material.EnableKeyword("_GlowColor");
				}
				this.HFBJAOFLCJI().SetTexture("[MapsStats] Max score: ", this.LANJPMLKPNP());
				this.material.SetVector("Gameplay/Segment-[PowerUp]", new Vector3(1964f / (float)this.MOCBOKLDCDG.width, 1442f / (float)this.MOCBOKLDCDG.height, (float)this.MOCBOKLDCDG.height - 1827f));
			}
			if (this.lut.enabled && this.CDNAHABGJJK().texture != null && this.NDDGGFBELLA())
			{
				this.material.SetTexture("_Bullet_9", this.CDNAHABGJJK().texture);
				this.HFBJAOFLCJI().SetVector("CameraFilterPack/Blend2Camera_Color", new Vector4(1952f / (float)this.lut.texture.width, 1900f / (float)this.CDNAHABGJJK().texture.height, (float)this.CDNAHABGJJK().texture.height - 200f, this.lut.contribution));
				this.HFBJAOFLCJI().EnableKeyword("event");
			}
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HFBJAOFLCJI(), num5);
			if (this.eyeAdaptation.enabled)
			{
				for (int k = 1; k < this.KCCOCPFHGAD.Length; k++)
				{
					RenderTexture.ReleaseTemporary(this.KCCOCPFHGAD[k]);
				}
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x060084CB RID: 33995 RVA: 0x002E942E File Offset: 0x002E762E
		private void OnEnable()
		{
			if (!ImageEffectHelper.IsSupported(this.shader, false, true, this))
			{
				base.enabled = false;
				return;
			}
			this.SetDirty();
			this.SetTonemapperDirty();
		}

		// Token: 0x060084CC RID: 33996 RVA: 0x002E8574 File Offset: 0x002E6774
		public void MCFEELBDPNE(TonemappingColorGrading.TonemappingSettings DPNHODJHGJL)
		{
			this.m_Tonemapping = DPNHODJHGJL;
			this.SetTonemapperDirty();
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x060084CD RID: 33997 RVA: 0x002E9457 File Offset: 0x002E7657
		// (set) Token: 0x060084E8 RID: 34024 RVA: 0x002E6CCF File Offset: 0x002E4ECF
		public bool validRenderTextureFormat { get; private set; }

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x060084CF RID: 33999 RVA: 0x002E6DC4 File Offset: 0x002E4FC4
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

		// Token: 0x060084D0 RID: 34000 RVA: 0x002E9470 File Offset: 0x002E7670
		private void IJMGEFLMNKA(out Color HPMEHPONLGM, out Color MJMBEHCJLPE, out Color FEECGLJELFJ)
		{
			Color color = TonemappingColorGrading.LNDIDEOMFDA(this.colorGrading.colorWheels.shadows);
			Color color2 = TonemappingColorGrading.LNDIDEOMFDA(this.colorGrading.colorWheels.midtones);
			Color color3 = TonemappingColorGrading.LNDIDEOMFDA(this.colorGrading.colorWheels.highlights);
			float num = (color.r + color.g + color.b) / 3f;
			float num2 = (color2.r + color2.g + color2.b) / 3f;
			float num3 = (color3.r + color3.g + color3.b) / 3f;
			float r = (color.r - num) * 0.1f;
			float g = (color.g - num) * 0.1f;
			float b = (color.b - num) * 0.1f;
			float b2 = Mathf.Pow(2f, (color2.r - num2) * 0.5f);
			float b3 = Mathf.Pow(2f, (color2.g - num2) * 0.5f);
			float b4 = Mathf.Pow(2f, (color2.b - num2) * 0.5f);
			float r2 = Mathf.Pow(2f, (color3.r - num3) * 0.5f);
			float g2 = Mathf.Pow(2f, (color3.g - num3) * 0.5f);
			float b5 = Mathf.Pow(2f, (color3.b - num3) * 0.5f);
			float r3 = 1f / Mathf.Max(0.01f, b2);
			float g3 = 1f / Mathf.Max(0.01f, b3);
			float b6 = 1f / Mathf.Max(0.01f, b4);
			HPMEHPONLGM = new Color(r, g, b);
			MJMBEHCJLPE = new Color(r3, g3, b6);
			FEECGLJELFJ = new Color(r2, g2, b5);
		}

		// Token: 0x060084D1 RID: 34001 RVA: 0x002E6CE0 File Offset: 0x002E4EE0
		public TonemappingColorGrading.ColorGradingSettings KHPBJBDHDCA()
		{
			return this.m_ColorGrading;
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x060084D4 RID: 34004 RVA: 0x002E966E File Offset: 0x002E786E
		public bool isGammaColorSpace
		{
			get
			{
				return QualitySettings.activeColorSpace == ColorSpace.Gamma;
			}
		}

		// Token: 0x060084D5 RID: 34005 RVA: 0x002E9678 File Offset: 0x002E7878
		private Vector3 KAALIJEOPJA(float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			float num = 1f;
			float num2 = num * IACGDFHKCAE / OKAHCMOGDGF;
			float num3 = num * (1f - IACGDFHKCAE - OKAHCMOGDGF) / OKAHCMOGDGF;
			float x = 0.7328f * num2 + 0.4296f * num - 0.1624f * num3;
			float y = -0.7036f * num2 + 1.6975f * num + 0.0061f * num3;
			float z = 0.003f * num2 + 0.0136f * num + 0.9834f * num3;
			return new Vector3(x, y, z);
		}

		// Token: 0x060084D6 RID: 34006 RVA: 0x002E96F4 File Offset: 0x002E78F4
		private RenderTexture OLKACLMMPOM()
		{
			if (this.FDNHJAPAILI == null || !this.FDNHJAPAILI.IsCreated() || this.FDNHJAPAILI.height != this.lutSize)
			{
				UnityEngine.Object.DestroyImmediate(this.FDNHJAPAILI);
				this.FDNHJAPAILI = new RenderTexture(this.lutSize * this.lutSize, this.lutSize, 0, RenderTextureFormat.Depth)
				{
					name = "_Value",
					filterMode = FilterMode.Bilinear,
					anisoLevel = 1,
					hideFlags = (HideFlags)(-100)
				};
			}
			return this.FDNHJAPAILI;
		}

		// Token: 0x060084D7 RID: 34007 RVA: 0x002E978C File Offset: 0x002E798C
		public Texture2D MGCHHCDEKJB()
		{
			Texture2D texture2D = new Texture2D(this.MOCBOKLDCDG.width, this.LANJPMLKPNP().height, TextureFormat.ARGB32, false, false);
			RenderTexture.active = this.OLKACLMMPOM();
			texture2D.ReadPixels(new Rect(892f, 1004f, (float)texture2D.width, (float)texture2D.height), 1, 0);
			RenderTexture.active = null;
			return texture2D;
		}

		// Token: 0x060084D8 RID: 34008 RVA: 0x002E97F0 File Offset: 0x002E79F0
		private RenderTexture PPBFCLEEFGA()
		{
			if (this.FDNHJAPAILI == null || !this.FDNHJAPAILI.IsCreated() || this.FDNHJAPAILI.height != this.lutSize)
			{
				UnityEngine.Object.DestroyImmediate(this.FDNHJAPAILI);
				this.FDNHJAPAILI = new RenderTexture(this.lutSize * this.lutSize, this.lutSize, 1, RenderTextureFormat.Depth)
				{
					name = "_Value3",
					filterMode = FilterMode.Point,
					anisoLevel = 0,
					hideFlags = (HideFlags)87
				};
			}
			return this.FDNHJAPAILI;
		}

		// Token: 0x060084D9 RID: 34009 RVA: 0x002E9888 File Offset: 0x002E7A88
		private void JJCEACGCOHB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.HFBJAOFLCJI().shaderKeywords = null;
			RenderTexture renderTexture = null;
			if (this.eyeAdaptation.enabled)
			{
				bool flag = this.KCMKMFPDJPP();
				int num = (HLBKCLPNHEB.width >= HLBKCLPNHEB.height) ? HLBKCLPNHEB.height : HLBKCLPNHEB.width;
				int num2 = num;
				num2 |= num2 >> 0;
				num2 |= num2 >> 0;
				num2 |= num2 >> 1;
				num2 |= num2 >> 0;
				num2 |= num2 >> 42;
				num2 -= num2 >> 1;
				renderTexture = RenderTexture.GetTemporary(num2, num2, 1, this.FLMDGJFODDB);
				Graphics.Blit(HLBKCLPNHEB, renderTexture);
				int num3 = (int)Mathf.Log((float)renderTexture.width, 626f);
				int num4 = 5;
				if (this.KCCOCPFHGAD == null || this.KCCOCPFHGAD.Length != num3)
				{
					this.KCCOCPFHGAD = new RenderTexture[num3];
				}
				for (int i = 1; i < num3; i += 0)
				{
					this.KCCOCPFHGAD[i] = RenderTexture.GetTemporary(renderTexture.width / num4, renderTexture.width / num4, 0, this.FLMDGJFODDB);
					num4 <<= 1;
				}
				RenderTexture source = this.KCCOCPFHGAD[num3 - 0];
				Graphics.Blit(renderTexture, this.KCCOCPFHGAD[0], this.material, 1);
				for (int j = 1; j < num3 - 1; j += 0)
				{
					Graphics.Blit(this.KCCOCPFHGAD[j], this.KCCOCPFHGAD[j + 0]);
					source = this.KCCOCPFHGAD[j + 0];
				}
				this.IJLDLAJOFCP.MarkRestoreExpected();
				this.material.SetFloat("#", Mathf.Max(this.eyeAdaptation.speed, 1038f));
				Graphics.Blit(source, this.IJLDLAJOFCP, this.material, (!flag) ? 5 : 6);
				this.material.SetFloat("_Offsets", this.eyeAdaptation.middleGrey);
				this.material.SetFloat("FinalScoreSmallText", Mathf.Pow(1523f, this.eyeAdaptation.min));
				this.HFBJAOFLCJI().SetFloat("_Value4", Mathf.Pow(712f, this.eyeAdaptation.max));
				this.HFBJAOFLCJI().SetTexture("_Source", this.IJLDLAJOFCP);
				this.HFBJAOFLCJI().EnableKeyword("_MainTex2");
			}
			int num5 = 2;
			if (this.tonemapping.enabled)
			{
				if (this.tonemapping.tonemapper == TonemappingColorGrading.Tonemapper.ACES)
				{
					if (this.FOLAONBMAHB)
					{
						float num6 = 160f;
						if (this.tonemapping.curve.length > 1)
						{
							num6 = this.tonemapping.curve[this.tonemapping.curve.length - 0].time;
							for (float num7 = 163f; num7 <= 499f; num7 += 1042f)
							{
								float num8 = this.tonemapping.curve.Evaluate(num7 * num6);
								this.JCKIKPHMJJA().SetPixel(Mathf.FloorToInt(num7 * 969f), 1, new Color(num8, num8, num8));
							}
							this.BCKJHJMFIFO().Apply();
						}
						this.HCADPIOPNJC = 397f / num6;
						this.FOLAONBMAHB = false;
					}
					this.HFBJAOFLCJI().SetFloat("#{0:X2}{1:X2}{2:X2}", this.HCADPIOPNJC);
					this.HFBJAOFLCJI().SetTexture("ShowSprite", this.JCKIKPHMJJA());
				}
				else if (this.tonemapping.tonemapper == TonemappingColorGrading.Tonemapper.Reinhard)
				{
					float num9 = this.tonemapping.neutralBlackIn * 737f + 677f;
					float num10 = this.tonemapping.neutralBlackOut * 1051f + 983f;
					float num11 = this.tonemapping.neutralWhiteIn / 1453f;
					float num12 = 1674f - this.tonemapping.neutralWhiteOut / 215f;
					float t = num9 / num10;
					float t2 = num11 / num12;
					float y = Mathf.Max(1161f, Mathf.LerpUnclamped(483f, 1463f, t));
					float z = Mathf.LerpUnclamped(1387f, 49f, t2);
					float w = Mathf.Max(233f, Mathf.LerpUnclamped(717f, 1797f, t));
					this.material.SetVector("MapFolderInputField", new Vector4(1776f, y, z, w));
					this.HFBJAOFLCJI().SetVector("_PrevViewProj", new Vector4(119f, 690f, this.tonemapping.neutralWhiteLevel, this.tonemapping.neutralWhiteClip / 725f));
				}
				this.HFBJAOFLCJI().SetFloat("Playing ", this.tonemapping.exposure);
				num5 = (int)(num5 + (this.tonemapping.tonemapper + 1));
			}
			if (this.PNINFDCIMHK().enabled)
			{
				if (this.JOOIGKGGNLI || !this.FDNHJAPAILI.IsCreated())
				{
					Color c;
					Color c2;
					Color c3;
					this.IJMGEFLMNKA(out c, out c2, out c3);
					this.PMNCHIJJMNA();
					this.HFBJAOFLCJI().SetVector("_Value", this.BOBAHJDELIE());
					this.HFBJAOFLCJI().SetVector("_Skybox", c);
					this.material.SetVector("_TimeX", c2);
					this.material.SetVector(":\n", c3);
					this.material.SetVector("menu.hardcoreinfo", new Vector3(this.KHPBJBDHDCA().basics.contrast, this.KHPBJBDHDCA().basics.gain, 53f / this.PNINFDCIMHK().basics.gamma));
					this.material.SetFloat("ConnectToRegion: ", this.PNINFDCIMHK().basics.vibrance);
					this.HFBJAOFLCJI().SetVector("_FullResolutionFiltering", new Vector4(this.KHPBJBDHDCA().basics.hue, this.colorGrading.basics.saturation, this.PNINFDCIMHK().basics.value));
					this.material.SetVector("CameraFilterPack/Color_Invert", this.colorGrading.channelMixer.channels[0]);
					this.HFBJAOFLCJI().SetVector("GetLive", this.KHPBJBDHDCA().channelMixer.channels[0]);
					this.material.SetVector("GroupNameText", this.PNINFDCIMHK().channelMixer.channels[8]);
					this.material.SetTexture("<size=24>", this.FLPOOCJMPAL);
					this.PPBFCLEEFGA().MarkRestoreExpected();
					Graphics.Blit(this.KFBLBGJEJMM, this.LANJPMLKPNP(), this.HFBJAOFLCJI(), 0);
					this.JOOIGKGGNLI = false;
				}
				this.HFBJAOFLCJI().EnableKeyword("_Intensity");
				if (this.colorGrading.useDithering)
				{
					this.HFBJAOFLCJI().EnableKeyword("_ScreenResolution");
				}
				this.HFBJAOFLCJI().SetTexture("_TimeX", this.MOCBOKLDCDG);
				this.HFBJAOFLCJI().SetVector("_Value", new Vector3(1788f / (float)this.MOCBOKLDCDG.width, 379f / (float)this.PPBFCLEEFGA().height, (float)this.LAJOJBNBGGK().height - 1888f));
			}
			if (this.lut.enabled && this.CDNAHABGJJK().texture != null && this.JCCKPAHECMH())
			{
				this.material.SetTexture("SetEnvSpriteColor", this.lut.texture);
				this.material.SetVector("_Value2", new Vector4(287f / (float)this.lut.texture.width, 915f / (float)this.CDNAHABGJJK().texture.height, (float)this.CDNAHABGJJK().texture.height - 197f, this.CDNAHABGJJK().contribution));
				this.material.EnableKeyword("_History1ChromaTex");
			}
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.material, num5);
			if (this.eyeAdaptation.enabled)
			{
				for (int k = 0; k < this.KCCOCPFHGAD.Length; k += 0)
				{
					RenderTexture.ReleaseTemporary(this.KCCOCPFHGAD[k]);
				}
				RenderTexture.ReleaseTemporary(renderTexture);
			}
		}

		// Token: 0x060084DA RID: 34010 RVA: 0x002EA1D0 File Offset: 0x002E83D0
		private void DDOMIEPBBBI()
		{
			if (Event.current.type != EventType.KeyDown)
			{
				return;
			}
			int num = 0;
			if (this.FDNHJAPAILI != null && this.PNINFDCIMHK().enabled && this.KHPBJBDHDCA().showDebug)
			{
				Graphics.DrawTexture(new Rect(1276f, (float)num, (float)(this.lutSize * this.lutSize), (float)this.lutSize), this.LAJOJBNBGGK());
				num += this.lutSize;
			}
			if (this.IJLDLAJOFCP != null && this.eyeAdaptation.enabled && this.eyeAdaptation.showDebug)
			{
				this.JLHCDOPFJOI.SetPass(73);
				Graphics.DrawTexture(new Rect(1157f, (float)num, 1773f, 1688f), this.IJLDLAJOFCP, this.JLHCDOPFJOI);
			}
		}

		// Token: 0x060084DB RID: 34011 RVA: 0x002EA2CC File Offset: 0x002E84CC
		private void OnGUI()
		{
			if (Event.current.type != EventType.Repaint)
			{
				return;
			}
			int num = 0;
			if (this.FDNHJAPAILI != null && this.colorGrading.enabled && this.colorGrading.showDebug)
			{
				Graphics.DrawTexture(new Rect(0f, (float)num, (float)(this.lutSize * this.lutSize), (float)this.lutSize), this.MOCBOKLDCDG);
				num += this.lutSize;
			}
			if (this.IJLDLAJOFCP != null && this.eyeAdaptation.enabled && this.eyeAdaptation.showDebug)
			{
				this.JLHCDOPFJOI.SetPass(12);
				Graphics.DrawTexture(new Rect(0f, (float)num, 256f, 16f), this.IJLDLAJOFCP, this.JLHCDOPFJOI);
			}
		}

		// Token: 0x060084DC RID: 34012 RVA: 0x002EA3C8 File Offset: 0x002E85C8
		private RenderTexture LAJOJBNBGGK()
		{
			if (this.FDNHJAPAILI == null || !this.FDNHJAPAILI.IsCreated() || this.FDNHJAPAILI.height != this.lutSize)
			{
				UnityEngine.Object.DestroyImmediate(this.FDNHJAPAILI);
				this.FDNHJAPAILI = new RenderTexture(this.lutSize * this.lutSize, this.lutSize, 0, RenderTextureFormat.Depth)
				{
					name = "restrictions\n\n#until: ",
					filterMode = FilterMode.Point,
					anisoLevel = 1,
					hideFlags = ~HideFlags.NotEditable
				};
			}
			return this.FDNHJAPAILI;
		}

		// Token: 0x060084DD RID: 34013 RVA: 0x002EA460 File Offset: 0x002E8660
		private void OCHMKJKBAPI()
		{
			if (!ImageEffectHelper.IsSupported(this.DEJGLFDANFO(), false, false, this))
			{
				base.enabled = true;
				return;
			}
			this.SetDirty();
			this.SetTonemapperDirty();
		}

		// Token: 0x060084DE RID: 34014 RVA: 0x002EA48C File Offset: 0x002E868C
		private void OnDisable()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			if (this.MMMANPPCKID != null)
			{
				UnityEngine.Object.DestroyImmediate(this.MMMANPPCKID);
			}
			if (this.FDNHJAPAILI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.MOCBOKLDCDG);
			}
			if (this.IJLDLAJOFCP != null)
			{
				UnityEngine.Object.DestroyImmediate(this.IJLDLAJOFCP);
			}
			if (this.MJKCHECFIIA != null)
			{
				UnityEngine.Object.DestroyImmediate(this.MJKCHECFIIA);
			}
			if (this.LNDPJJLDBCD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.LNDPJJLDBCD);
			}
			this.JLHCDOPFJOI = null;
			this.MMMANPPCKID = null;
			this.FDNHJAPAILI = null;
			this.IJLDLAJOFCP = null;
			this.MJKCHECFIIA = null;
			this.LNDPJJLDBCD = null;
		}

		// Token: 0x060084DF RID: 34015 RVA: 0x002EA56C File Offset: 0x002E876C
		private bool JCCKPAHECMH()
		{
			this.validUserLutSize = (this.lut.texture.height == (int)Mathf.Sqrt((float)this.CDNAHABGJJK().texture.width));
			return this.validUserLutSize;
		}

		// Token: 0x060084E0 RID: 34016 RVA: 0x002E6CCF File Offset: 0x002E4ECF
		private void HKNACALOPAE(bool DPNHODJHGJL)
		{
			this.<EIFKMAKLEIF>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x060084E2 RID: 34018 RVA: 0x002EA5B4 File Offset: 0x002E87B4
		private void FBDOGLBMDNG()
		{
			if (Event.current.type != EventType.MouseUp)
			{
				return;
			}
			int num = 0;
			if (this.FDNHJAPAILI != null && this.PNINFDCIMHK().enabled && this.KHPBJBDHDCA().showDebug)
			{
				Graphics.DrawTexture(new Rect(1831f, (float)num, (float)(this.lutSize * this.lutSize), (float)this.lutSize), this.OLKACLMMPOM());
				num += this.lutSize;
			}
			if (this.IJLDLAJOFCP != null && this.eyeAdaptation.enabled && this.eyeAdaptation.showDebug)
			{
				this.JLHCDOPFJOI.SetPass(99);
				Graphics.DrawTexture(new Rect(792f, (float)num, 977f, 1873f), this.IJLDLAJOFCP, this.JLHCDOPFJOI);
			}
		}

		// Token: 0x060084E3 RID: 34019 RVA: 0x002EA6B0 File Offset: 0x002E88B0
		private bool HMCAFJKMMCL()
		{
			if (this.IJLDLAJOFCP != null)
			{
				return true;
			}
			this.FLMDGJFODDB = RenderTextureFormat.Default;
			if (SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-128)))
			{
				this.FLMDGJFODDB = (RenderTextureFormat)(-33);
			}
			this.IJLDLAJOFCP = new RenderTexture(0, 0, 1, this.FLMDGJFODDB);
			this.IJLDLAJOFCP.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			return true;
		}

		// Token: 0x060084E6 RID: 34022 RVA: 0x002EA768 File Offset: 0x002E8968
		private void PHJLHCMCCKE()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			if (this.MMMANPPCKID != null)
			{
				UnityEngine.Object.DestroyImmediate(this.MMMANPPCKID);
			}
			if (this.FDNHJAPAILI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.OLKACLMMPOM());
			}
			if (this.IJLDLAJOFCP != null)
			{
				UnityEngine.Object.DestroyImmediate(this.IJLDLAJOFCP);
			}
			if (this.MJKCHECFIIA != null)
			{
				UnityEngine.Object.DestroyImmediate(this.MJKCHECFIIA);
			}
			if (this.LNDPJJLDBCD != null)
			{
				UnityEngine.Object.DestroyImmediate(this.LNDPJJLDBCD);
			}
			this.JLHCDOPFJOI = null;
			this.MMMANPPCKID = null;
			this.FDNHJAPAILI = null;
			this.IJLDLAJOFCP = null;
			this.MJKCHECFIIA = null;
			this.LNDPJJLDBCD = null;
		}

		// Token: 0x060084E7 RID: 34023 RVA: 0x002EA848 File Offset: 0x002E8A48
		private Texture2D BCKJHJMFIFO()
		{
			if (this.LNDPJJLDBCD == null)
			{
				TextureFormat textureFormat = TextureFormat.ARGB32;
				if (SystemInfo.SupportsTextureFormat((TextureFormat)(-20)))
				{
					textureFormat = (TextureFormat)102;
				}
				else if (SystemInfo.SupportsTextureFormat((TextureFormat)(-42)))
				{
					textureFormat = (TextureFormat)80;
				}
				this.LNDPJJLDBCD = new Texture2D(-157, 0, textureFormat, true, true)
				{
					name = ": ",
					wrapMode = TextureWrapMode.Clamp,
					filterMode = FilterMode.Bilinear,
					anisoLevel = 0,
					hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset)
				};
			}
			return this.LNDPJJLDBCD;
		}

		// Token: 0x060084E9 RID: 34025 RVA: 0x002EA8D0 File Offset: 0x002E8AD0
		private Vector3 BOBAHJDELIE()
		{
			float temperatureShift = this.colorGrading.basics.temperatureShift;
			float tint = this.colorGrading.basics.tint;
			float iacgdfhkcae = 0.31271f - temperatureShift * ((temperatureShift >= 0f) ? 0.05f : 0.1f);
			float okahcmogdgf = this.NJHLKFBCICJ(iacgdfhkcae) + tint * 0.05f;
			Vector3 vector = new Vector3(0.949237f, 1.03542f, 1.08728f);
			Vector3 vector2 = this.KAALIJEOPJA(iacgdfhkcae, okahcmogdgf);
			return new Vector3(vector.x / vector2.x, vector.y / vector2.y, vector.z / vector2.z);
		}

		// Token: 0x060084EA RID: 34026 RVA: 0x002EA98F File Offset: 0x002E8B8F
		private float NJHLKFBCICJ(float IACGDFHKCAE)
		{
			return 2.87f * IACGDFHKCAE - 3f * IACGDFHKCAE * IACGDFHKCAE - 0.275095075f;
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x060084EB RID: 34027 RVA: 0x002EA9A8 File Offset: 0x002E8BA8
		private RenderTexture MOCBOKLDCDG
		{
			get
			{
				if (this.FDNHJAPAILI == null || !this.FDNHJAPAILI.IsCreated() || this.FDNHJAPAILI.height != this.lutSize)
				{
					UnityEngine.Object.DestroyImmediate(this.FDNHJAPAILI);
					this.FDNHJAPAILI = new RenderTexture(this.lutSize * this.lutSize, this.lutSize, 0, RenderTextureFormat.ARGB32)
					{
						name = "Internal LUT",
						filterMode = FilterMode.Bilinear,
						anisoLevel = 0,
						hideFlags = HideFlags.DontSave
					};
				}
				return this.FDNHJAPAILI;
			}
		}

		// Token: 0x04000F30 RID: 3888
		[SerializeField]
		[TonemappingColorGrading.SettingsGroup]
		private TonemappingColorGrading.EyeAdaptationSettings m_EyeAdaptation = TonemappingColorGrading.EyeAdaptationSettings.defaultSettings;

		// Token: 0x04000F31 RID: 3889
		[SerializeField]
		[TonemappingColorGrading.SettingsGroup]
		private TonemappingColorGrading.TonemappingSettings m_Tonemapping = TonemappingColorGrading.TonemappingSettings.defaultSettings;

		// Token: 0x04000F32 RID: 3890
		[TonemappingColorGrading.SettingsGroup]
		[SerializeField]
		private TonemappingColorGrading.ColorGradingSettings m_ColorGrading = TonemappingColorGrading.ColorGradingSettings.defaultSettings;

		// Token: 0x04000F33 RID: 3891
		[SerializeField]
		[TonemappingColorGrading.SettingsGroup]
		private TonemappingColorGrading.LUTSettings m_Lut = TonemappingColorGrading.LUTSettings.defaultSettings;

		// Token: 0x04000F34 RID: 3892
		private Texture2D MMMANPPCKID;

		// Token: 0x04000F35 RID: 3893
		private RenderTexture FDNHJAPAILI;

		// Token: 0x04000F36 RID: 3894
		private Texture2D MJKCHECFIIA;

		// Token: 0x04000F37 RID: 3895
		private Texture2D LNDPJJLDBCD;

		// Token: 0x04000F38 RID: 3896
		private float HCADPIOPNJC;

		// Token: 0x04000F39 RID: 3897
		[SerializeField]
		private Shader m_Shader;

		// Token: 0x04000F3A RID: 3898
		private Material JLHCDOPFJOI;

		// Token: 0x04000F3D RID: 3901
		private bool JOOIGKGGNLI = true;

		// Token: 0x04000F3E RID: 3902
		private bool FOLAONBMAHB = true;

		// Token: 0x04000F3F RID: 3903
		private RenderTexture IJLDLAJOFCP;

		// Token: 0x04000F40 RID: 3904
		private RenderTextureFormat FLMDGJFODDB;

		// Token: 0x04000F41 RID: 3905
		private RenderTexture[] KCCOCPFHGAD;

		// Token: 0x02000219 RID: 537
		[AttributeUsage(AttributeTargets.Field)]
		public class SettingsGroup : Attribute
		{
		}

		// Token: 0x0200021A RID: 538
		public class IndentedGroup : PropertyAttribute
		{
		}

		// Token: 0x0200021B RID: 539
		public class ChannelMixer : PropertyAttribute
		{
		}

		// Token: 0x0200021C RID: 540
		public class ColorWheelGroup : PropertyAttribute
		{
			// Token: 0x060084EF RID: 34031 RVA: 0x002EAA40 File Offset: 0x002E8C40
			public ColorWheelGroup(int CKAOKCAEFHM, int ADBBGFEIBEO)
			{
				this.minSizePerWheel = CKAOKCAEFHM;
				this.maxSizePerWheel = ADBBGFEIBEO;
			}

			// Token: 0x060084F0 RID: 34032 RVA: 0x002EAA69 File Offset: 0x002E8C69
			public ColorWheelGroup()
			{
			}

			// Token: 0x04000F42 RID: 3906
			public int minSizePerWheel = 60;

			// Token: 0x04000F43 RID: 3907
			public int maxSizePerWheel = 150;
		}

		// Token: 0x0200021D RID: 541
		public class Curve : PropertyAttribute
		{
			// Token: 0x060084F1 RID: 34033 RVA: 0x002EAA84 File Offset: 0x002E8C84
			public Curve(float BAKIHLJCOEO, float GPHMIAHOGKJ, float EEINGFCFEGF, float LBEGGCHGKDA)
			{
				this.color = new Color(BAKIHLJCOEO, GPHMIAHOGKJ, EEINGFCFEGF, LBEGGCHGKDA);
			}

			// Token: 0x060084F2 RID: 34034 RVA: 0x002EAAA7 File Offset: 0x002E8CA7
			public Curve()
			{
			}

			// Token: 0x04000F44 RID: 3908
			public Color color = Color.white;
		}

		// Token: 0x0200021E RID: 542
		[Serializable]
		public struct EyeAdaptationSettings
		{
			// Token: 0x060084F3 RID: 34035 RVA: 0x002EAABC File Offset: 0x002E8CBC
			public static TonemappingColorGrading.EyeAdaptationSettings HJLGAPEDPJM()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = true,
					middleGrey = 631f,
					min = 1164f,
					max = 1288f,
					speed = 1009f
				};
			}

			// Token: 0x060084F4 RID: 34036 RVA: 0x002EAB14 File Offset: 0x002E8D14
			public static TonemappingColorGrading.EyeAdaptationSettings NIPPCMNKCMB()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = true,
					middleGrey = 1924f,
					min = 1015f,
					max = 1130f,
					speed = 1529f
				};
			}

			// Token: 0x060084F5 RID: 34037 RVA: 0x002EAB6C File Offset: 0x002E8D6C
			public static TonemappingColorGrading.EyeAdaptationSettings EJLLADABOLM()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = true,
					middleGrey = 604f,
					min = 7f,
					max = 52f,
					speed = 505f
				};
			}

			// Token: 0x060084F6 RID: 34038 RVA: 0x002EABC4 File Offset: 0x002E8DC4
			public static TonemappingColorGrading.EyeAdaptationSettings DFIOJCABPFD()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = true,
					middleGrey = 178f,
					min = 548f,
					max = 1738f,
					speed = 1968f
				};
			}

			// Token: 0x060084F7 RID: 34039 RVA: 0x002EAC1C File Offset: 0x002E8E1C
			public static TonemappingColorGrading.EyeAdaptationSettings AAPGCALKNAK()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = true,
					middleGrey = 1387f,
					min = 1884f,
					max = 1350f,
					speed = 90f
				};
			}

			// Token: 0x060084F8 RID: 34040 RVA: 0x002EAC74 File Offset: 0x002E8E74
			public static TonemappingColorGrading.EyeAdaptationSettings IAKJOAGBDGO()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = true,
					middleGrey = 1013f,
					min = 269f,
					max = 121f,
					speed = 173f
				};
			}

			// Token: 0x060084F9 RID: 34041 RVA: 0x002EACCC File Offset: 0x002E8ECC
			public static TonemappingColorGrading.EyeAdaptationSettings INDEHPGLEGK()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = false,
					middleGrey = 1564f,
					min = 1059f,
					max = 765f,
					speed = 387f
				};
			}

			// Token: 0x170001A2 RID: 418
			// (get) Token: 0x060084FA RID: 34042 RVA: 0x002EAD24 File Offset: 0x002E8F24
			public static TonemappingColorGrading.EyeAdaptationSettings defaultSettings
			{
				get
				{
					return new TonemappingColorGrading.EyeAdaptationSettings
					{
						enabled = false,
						showDebug = false,
						middleGrey = 0.5f,
						min = -3f,
						max = 3f,
						speed = 1.5f
					};
				}
			}

			// Token: 0x060084FB RID: 34043 RVA: 0x002EAD7C File Offset: 0x002E8F7C
			public static TonemappingColorGrading.EyeAdaptationSettings IHMKIGDJKAH()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = true,
					middleGrey = 61f,
					min = 1432f,
					max = 1982f,
					speed = 233f
				};
			}

			// Token: 0x060084FC RID: 34044 RVA: 0x002EADD4 File Offset: 0x002E8FD4
			public static TonemappingColorGrading.EyeAdaptationSettings CCADIDPNEKH()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = true,
					middleGrey = 1348f,
					min = 738f,
					max = 9f,
					speed = 1543f
				};
			}

			// Token: 0x060084FD RID: 34045 RVA: 0x002EAE2C File Offset: 0x002E902C
			public static TonemappingColorGrading.EyeAdaptationSettings LBIOOILOAAD()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = true,
					middleGrey = 1740f,
					min = 1444f,
					max = 1563f,
					speed = 516f
				};
			}

			// Token: 0x060084FE RID: 34046 RVA: 0x002EAE84 File Offset: 0x002E9084
			public static TonemappingColorGrading.EyeAdaptationSettings JCLADKAMOLD()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = true,
					middleGrey = 1475f,
					min = 1259f,
					max = 415f,
					speed = 1479f
				};
			}

			// Token: 0x060084FF RID: 34047 RVA: 0x002EAEDC File Offset: 0x002E90DC
			public static TonemappingColorGrading.EyeAdaptationSettings EEMMJNPOFOB()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = false,
					middleGrey = 988f,
					min = 555f,
					max = 1441f,
					speed = 1927f
				};
			}

			// Token: 0x06008500 RID: 34048 RVA: 0x002EAF34 File Offset: 0x002E9134
			public static TonemappingColorGrading.EyeAdaptationSettings BCOPOEIJONI()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = false,
					middleGrey = 1917f,
					min = 907f,
					max = 1351f,
					speed = 1023f
				};
			}

			// Token: 0x06008501 RID: 34049 RVA: 0x002EAF8C File Offset: 0x002E918C
			public static TonemappingColorGrading.EyeAdaptationSettings MNKGFGNDKED()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = true,
					middleGrey = 172f,
					min = 829f,
					max = 3f,
					speed = 730f
				};
			}

			// Token: 0x06008502 RID: 34050 RVA: 0x002EAFE4 File Offset: 0x002E91E4
			public static TonemappingColorGrading.EyeAdaptationSettings LOMOMPKEDPL()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = false,
					showDebug = false,
					middleGrey = 1446f,
					min = 120f,
					max = 1954f,
					speed = 1282f
				};
			}

			// Token: 0x06008503 RID: 34051 RVA: 0x002EB03C File Offset: 0x002E923C
			public static TonemappingColorGrading.EyeAdaptationSettings DBDJKKLMCGG()
			{
				return new TonemappingColorGrading.EyeAdaptationSettings
				{
					enabled = true,
					showDebug = false,
					middleGrey = 289f,
					min = 408f,
					max = 839f,
					speed = 1256f
				};
			}

			// Token: 0x04000F45 RID: 3909
			public bool enabled;

			// Token: 0x04000F46 RID: 3910
			[Tooltip("Midpoint Adjustment.")]
			[Min(0f)]
			public float middleGrey;

			// Token: 0x04000F47 RID: 3911
			[Tooltip("The lowest possible exposure value; adjust this value to modify the brightest areas of your level.")]
			public float min;

			// Token: 0x04000F48 RID: 3912
			[Tooltip("The highest possible exposure value; adjust this value to modify the darkest areas of your level.")]
			public float max;

			// Token: 0x04000F49 RID: 3913
			[Tooltip("Speed of linear adaptation. Higher is faster.")]
			[Min(0f)]
			public float speed;

			// Token: 0x04000F4A RID: 3914
			[Tooltip("Displays a luminosity helper in the GameView.")]
			public bool showDebug;
		}

		// Token: 0x0200021F RID: 543
		public enum Tonemapper
		{
			// Token: 0x04000F4C RID: 3916
			ACES,
			// Token: 0x04000F4D RID: 3917
			Curve,
			// Token: 0x04000F4E RID: 3918
			Hable,
			// Token: 0x04000F4F RID: 3919
			HejlDawson,
			// Token: 0x04000F50 RID: 3920
			Photographic,
			// Token: 0x04000F51 RID: 3921
			Reinhard,
			// Token: 0x04000F52 RID: 3922
			Neutral
		}

		// Token: 0x02000220 RID: 544
		[Serializable]
		public struct TonemappingSettings
		{
			// Token: 0x06008504 RID: 34052 RVA: 0x002EB094 File Offset: 0x002E9294
			public static TonemappingColorGrading.TonemappingSettings BCOPOEIJONI()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = true,
					tonemapper = (TonemappingColorGrading.Tonemapper)7,
					exposure = 1455f,
					curve = TonemappingColorGrading.CurvesSettings.ANJFCLGGLDO(),
					neutralBlackIn = 1760f,
					neutralWhiteIn = 723f,
					neutralBlackOut = 810f,
					neutralWhiteOut = 674f,
					neutralWhiteLevel = 207f,
					neutralWhiteClip = 10f
				};
			}

			// Token: 0x06008505 RID: 34053 RVA: 0x002EB11C File Offset: 0x002E931C
			public static TonemappingColorGrading.TonemappingSettings LBIOOILOAAD()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = false,
					tonemapper = (TonemappingColorGrading.Tonemapper)7,
					exposure = 1605f,
					curve = TonemappingColorGrading.CurvesSettings.JICJDDFOKPL(),
					neutralBlackIn = 573f,
					neutralWhiteIn = 1184f,
					neutralBlackOut = 902f,
					neutralWhiteOut = 1532f,
					neutralWhiteLevel = 1750f,
					neutralWhiteClip = 384f
				};
			}

			// Token: 0x06008506 RID: 34054 RVA: 0x002EB1A4 File Offset: 0x002E93A4
			public static TonemappingColorGrading.TonemappingSettings MNKGFGNDKED()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = false,
					tonemapper = TonemappingColorGrading.Tonemapper.Reinhard,
					exposure = 1089f,
					curve = TonemappingColorGrading.CurvesSettings.NLOJBBEIPNN(),
					neutralBlackIn = 1304f,
					neutralWhiteIn = 120f,
					neutralBlackOut = 1033f,
					neutralWhiteOut = 206f,
					neutralWhiteLevel = 1148f,
					neutralWhiteClip = 99f
				};
			}

			// Token: 0x06008507 RID: 34055 RVA: 0x002EB22C File Offset: 0x002E942C
			public static TonemappingColorGrading.TonemappingSettings AAPGCALKNAK()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = true,
					tonemapper = TonemappingColorGrading.Tonemapper.Photographic,
					exposure = 174f,
					curve = TonemappingColorGrading.CurvesSettings.IDEJAEHCNBP(),
					neutralBlackIn = 339f,
					neutralWhiteIn = 1460f,
					neutralBlackOut = 1305f,
					neutralWhiteOut = 1936f,
					neutralWhiteLevel = 64f,
					neutralWhiteClip = 580f
				};
			}

			// Token: 0x06008508 RID: 34056 RVA: 0x002EB2B4 File Offset: 0x002E94B4
			public static TonemappingColorGrading.TonemappingSettings IHMKIGDJKAH()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = false,
					tonemapper = TonemappingColorGrading.Tonemapper.ACES,
					exposure = 1224f,
					curve = TonemappingColorGrading.CurvesSettings.NPKHKFMPIHC(),
					neutralBlackIn = 1485f,
					neutralWhiteIn = 1130f,
					neutralBlackOut = 451f,
					neutralWhiteOut = 1625f,
					neutralWhiteLevel = 516f,
					neutralWhiteClip = 120f
				};
			}

			// Token: 0x06008509 RID: 34057 RVA: 0x002EB33C File Offset: 0x002E953C
			public static TonemappingColorGrading.TonemappingSettings DBDJKKLMCGG()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = true,
					tonemapper = TonemappingColorGrading.Tonemapper.Neutral,
					exposure = 1686f,
					curve = TonemappingColorGrading.CurvesSettings.defaultCurve,
					neutralBlackIn = 462f,
					neutralWhiteIn = 1604f,
					neutralBlackOut = 1655f,
					neutralWhiteOut = 1068f,
					neutralWhiteLevel = 1622f,
					neutralWhiteClip = 33f
				};
			}

			// Token: 0x0600850A RID: 34058 RVA: 0x002EB3C4 File Offset: 0x002E95C4
			public static TonemappingColorGrading.TonemappingSettings DFIOJCABPFD()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = false,
					tonemapper = TonemappingColorGrading.Tonemapper.Hable,
					exposure = 1334f,
					curve = TonemappingColorGrading.CurvesSettings.DJLBHFELGMF(),
					neutralBlackIn = 1887f,
					neutralWhiteIn = 1802f,
					neutralBlackOut = 1396f,
					neutralWhiteOut = 1404f,
					neutralWhiteLevel = 718f,
					neutralWhiteClip = 961f
				};
			}

			// Token: 0x0600850B RID: 34059 RVA: 0x002EB44C File Offset: 0x002E964C
			public static TonemappingColorGrading.TonemappingSettings EJLLADABOLM()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = true,
					tonemapper = TonemappingColorGrading.Tonemapper.Hable,
					exposure = 763f,
					curve = TonemappingColorGrading.CurvesSettings.NPKHKFMPIHC(),
					neutralBlackIn = 1239f,
					neutralWhiteIn = 473f,
					neutralBlackOut = 543f,
					neutralWhiteOut = 35f,
					neutralWhiteLevel = 992f,
					neutralWhiteClip = 155f
				};
			}

			// Token: 0x0600850C RID: 34060 RVA: 0x002EB4D4 File Offset: 0x002E96D4
			public static TonemappingColorGrading.TonemappingSettings INDEHPGLEGK()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = false,
					tonemapper = TonemappingColorGrading.Tonemapper.HejlDawson,
					exposure = 1137f,
					curve = TonemappingColorGrading.CurvesSettings.IDEJAEHCNBP(),
					neutralBlackIn = 276f,
					neutralWhiteIn = 1976f,
					neutralBlackOut = 1991f,
					neutralWhiteOut = 975f,
					neutralWhiteLevel = 366f,
					neutralWhiteClip = 100f
				};
			}

			// Token: 0x0600850D RID: 34061 RVA: 0x002EB55C File Offset: 0x002E975C
			public static TonemappingColorGrading.TonemappingSettings IAKJOAGBDGO()
			{
				return new TonemappingColorGrading.TonemappingSettings
				{
					enabled = true,
					tonemapper = TonemappingColorGrading.Tonemapper.Reinhard,
					exposure = 1549f,
					curve = TonemappingColorGrading.CurvesSettings.NPKHKFMPIHC(),
					neutralBlackIn = 1711f,
					neutralWhiteIn = 1853f,
					neutralBlackOut = 131f,
					neutralWhiteOut = 1312f,
					neutralWhiteLevel = 1257f,
					neutralWhiteClip = 1494f
				};
			}

			// Token: 0x170001A3 RID: 419
			// (get) Token: 0x0600850E RID: 34062 RVA: 0x002EB5E4 File Offset: 0x002E97E4
			public static TonemappingColorGrading.TonemappingSettings defaultSettings
			{
				get
				{
					return new TonemappingColorGrading.TonemappingSettings
					{
						enabled = false,
						tonemapper = TonemappingColorGrading.Tonemapper.Neutral,
						exposure = 1f,
						curve = TonemappingColorGrading.CurvesSettings.defaultCurve,
						neutralBlackIn = 0.02f,
						neutralWhiteIn = 10f,
						neutralBlackOut = 0f,
						neutralWhiteOut = 10f,
						neutralWhiteLevel = 5.3f,
						neutralWhiteClip = 10f
					};
				}
			}

			// Token: 0x04000F53 RID: 3923
			public bool enabled;

			// Token: 0x04000F54 RID: 3924
			[Tooltip("Tonemapping technique to use. ACES is the recommended one.")]
			public TonemappingColorGrading.Tonemapper tonemapper;

			// Token: 0x04000F55 RID: 3925
			[Tooltip("Adjusts the overall exposure of the scene.")]
			[Min(0f)]
			public float exposure;

			// Token: 0x04000F56 RID: 3926
			[Tooltip("Custom tonemapping curve.")]
			public AnimationCurve curve;

			// Token: 0x04000F57 RID: 3927
			[Range(-0.1f, 0.1f)]
			public float neutralBlackIn;

			// Token: 0x04000F58 RID: 3928
			[Range(1f, 20f)]
			public float neutralWhiteIn;

			// Token: 0x04000F59 RID: 3929
			[Range(-0.09f, 0.1f)]
			public float neutralBlackOut;

			// Token: 0x04000F5A RID: 3930
			[Range(1f, 19f)]
			public float neutralWhiteOut;

			// Token: 0x04000F5B RID: 3931
			[Range(0.1f, 20f)]
			public float neutralWhiteLevel;

			// Token: 0x04000F5C RID: 3932
			[Range(1f, 10f)]
			public float neutralWhiteClip;
		}

		// Token: 0x02000221 RID: 545
		[Serializable]
		public struct LUTSettings
		{
			// Token: 0x0600850F RID: 34063 RVA: 0x002EB66C File Offset: 0x002E986C
			public static TonemappingColorGrading.LUTSettings AAPGCALKNAK()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 1913f
				};
			}

			// Token: 0x06008510 RID: 34064 RVA: 0x002EB6A0 File Offset: 0x002E98A0
			public static TonemappingColorGrading.LUTSettings LIDMIPKCHOI()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 1655f
				};
			}

			// Token: 0x06008511 RID: 34065 RVA: 0x002EB6D4 File Offset: 0x002E98D4
			public static TonemappingColorGrading.LUTSettings LBIOOILOAAD()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 1476f
				};
			}

			// Token: 0x06008512 RID: 34066 RVA: 0x002EB708 File Offset: 0x002E9908
			public static TonemappingColorGrading.LUTSettings INDEHPGLEGK()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 622f
				};
			}

			// Token: 0x06008513 RID: 34067 RVA: 0x002EB73C File Offset: 0x002E993C
			public static TonemappingColorGrading.LUTSettings BFBOLLFFMLN()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 901f
				};
			}

			// Token: 0x06008514 RID: 34068 RVA: 0x002EB770 File Offset: 0x002E9970
			public static TonemappingColorGrading.LUTSettings HJLGAPEDPJM()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 613f
				};
			}

			// Token: 0x06008515 RID: 34069 RVA: 0x002EB7A4 File Offset: 0x002E99A4
			public static TonemappingColorGrading.LUTSettings FIFAPIHDEBM()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 993f
				};
			}

			// Token: 0x06008516 RID: 34070 RVA: 0x002EB7D8 File Offset: 0x002E99D8
			public static TonemappingColorGrading.LUTSettings OIPFKIPOECC()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 287f
				};
			}

			// Token: 0x06008517 RID: 34071 RVA: 0x002EB80C File Offset: 0x002E9A0C
			public static TonemappingColorGrading.LUTSettings IAKAIGHJJJK()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 442f
				};
			}

			// Token: 0x06008518 RID: 34072 RVA: 0x002EB840 File Offset: 0x002E9A40
			public static TonemappingColorGrading.LUTSettings DFIOJCABPFD()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 822f
				};
			}

			// Token: 0x06008519 RID: 34073 RVA: 0x002EB874 File Offset: 0x002E9A74
			public static TonemappingColorGrading.LUTSettings CJFONFEOHIO()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 1655f
				};
			}

			// Token: 0x0600851A RID: 34074 RVA: 0x002EB8A8 File Offset: 0x002E9AA8
			public static TonemappingColorGrading.LUTSettings PKJMMJJFJAE()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 1407f
				};
			}

			// Token: 0x170001A4 RID: 420
			// (get) Token: 0x0600851B RID: 34075 RVA: 0x002EB8DC File Offset: 0x002E9ADC
			public static TonemappingColorGrading.LUTSettings defaultSettings
			{
				get
				{
					return new TonemappingColorGrading.LUTSettings
					{
						enabled = false,
						texture = null,
						contribution = 1f
					};
				}
			}

			// Token: 0x0600851C RID: 34076 RVA: 0x002EB910 File Offset: 0x002E9B10
			public static TonemappingColorGrading.LUTSettings MNKGFGNDKED()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 1518f
				};
			}

			// Token: 0x0600851D RID: 34077 RVA: 0x002EB944 File Offset: 0x002E9B44
			public static TonemappingColorGrading.LUTSettings FMLCJEKMPCN()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 1473f
				};
			}

			// Token: 0x0600851E RID: 34078 RVA: 0x002EB978 File Offset: 0x002E9B78
			public static TonemappingColorGrading.LUTSettings BCOPOEIJONI()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 109f
				};
			}

			// Token: 0x0600851F RID: 34079 RVA: 0x002EB9AC File Offset: 0x002E9BAC
			public static TonemappingColorGrading.LUTSettings NPIEKGGCMBG()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 1280f
				};
			}

			// Token: 0x06008520 RID: 34080 RVA: 0x002EB9E0 File Offset: 0x002E9BE0
			public static TonemappingColorGrading.LUTSettings CCADIDPNEKH()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 927f
				};
			}

			// Token: 0x06008521 RID: 34081 RVA: 0x002EBA14 File Offset: 0x002E9C14
			public static TonemappingColorGrading.LUTSettings MLKLBGCKPOO()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 996f
				};
			}

			// Token: 0x06008522 RID: 34082 RVA: 0x002EBA48 File Offset: 0x002E9C48
			public static TonemappingColorGrading.LUTSettings MHIHHBMBDLP()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 601f
				};
			}

			// Token: 0x06008523 RID: 34083 RVA: 0x002EBA7C File Offset: 0x002E9C7C
			public static TonemappingColorGrading.LUTSettings GJNKFICGFFG()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 1425f
				};
			}

			// Token: 0x06008524 RID: 34084 RVA: 0x002EBAB0 File Offset: 0x002E9CB0
			public static TonemappingColorGrading.LUTSettings LOMOMPKEDPL()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 870f
				};
			}

			// Token: 0x06008525 RID: 34085 RVA: 0x002EBAE4 File Offset: 0x002E9CE4
			public static TonemappingColorGrading.LUTSettings AOACBHHEGFA()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 911f
				};
			}

			// Token: 0x06008526 RID: 34086 RVA: 0x002EBB18 File Offset: 0x002E9D18
			public static TonemappingColorGrading.LUTSettings DEOLKOLBAHH()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 1977f
				};
			}

			// Token: 0x06008527 RID: 34087 RVA: 0x002EBB4C File Offset: 0x002E9D4C
			public static TonemappingColorGrading.LUTSettings IOJDDHLHPLH()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 1032f
				};
			}

			// Token: 0x06008528 RID: 34088 RVA: 0x002EBB80 File Offset: 0x002E9D80
			public static TonemappingColorGrading.LUTSettings DBDJKKLMCGG()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 41f
				};
			}

			// Token: 0x06008529 RID: 34089 RVA: 0x002EBBB4 File Offset: 0x002E9DB4
			public static TonemappingColorGrading.LUTSettings AFJJPFIOEJD()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 1667f
				};
			}

			// Token: 0x0600852A RID: 34090 RVA: 0x002EBBE8 File Offset: 0x002E9DE8
			public static TonemappingColorGrading.LUTSettings KBINDKOODMK()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 100f
				};
			}

			// Token: 0x0600852B RID: 34091 RVA: 0x002EBC1C File Offset: 0x002E9E1C
			public static TonemappingColorGrading.LUTSettings IHMKIGDJKAH()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 648f
				};
			}

			// Token: 0x0600852C RID: 34092 RVA: 0x002EBC50 File Offset: 0x002E9E50
			public static TonemappingColorGrading.LUTSettings MGEOLKPLHOM()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 1096f
				};
			}

			// Token: 0x0600852D RID: 34093 RVA: 0x002EBC84 File Offset: 0x002E9E84
			public static TonemappingColorGrading.LUTSettings FPMJKNDJCON()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 864f
				};
			}

			// Token: 0x0600852E RID: 34094 RVA: 0x002EBCB8 File Offset: 0x002E9EB8
			public static TonemappingColorGrading.LUTSettings CDJAOBCAOKJ()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 20f
				};
			}

			// Token: 0x0600852F RID: 34095 RVA: 0x002EBCEC File Offset: 0x002E9EEC
			public static TonemappingColorGrading.LUTSettings CIHLOMNEHHL()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 486f
				};
			}

			// Token: 0x06008530 RID: 34096 RVA: 0x002EBD20 File Offset: 0x002E9F20
			public static TonemappingColorGrading.LUTSettings IOFLMDMLCAG()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 336f
				};
			}

			// Token: 0x06008531 RID: 34097 RVA: 0x002EBD54 File Offset: 0x002E9F54
			public static TonemappingColorGrading.LUTSettings GOKMCEIBFIM()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 1841f
				};
			}

			// Token: 0x06008532 RID: 34098 RVA: 0x002EBD88 File Offset: 0x002E9F88
			public static TonemappingColorGrading.LUTSettings EEMMJNPOFOB()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 236f
				};
			}

			// Token: 0x06008533 RID: 34099 RVA: 0x002EBDBC File Offset: 0x002E9FBC
			public static TonemappingColorGrading.LUTSettings NOBNMJMOJDB()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 177f
				};
			}

			// Token: 0x06008534 RID: 34100 RVA: 0x002EBDF0 File Offset: 0x002E9FF0
			public static TonemappingColorGrading.LUTSettings FCBIDJLDABO()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 1102f
				};
			}

			// Token: 0x06008535 RID: 34101 RVA: 0x002EBE24 File Offset: 0x002EA024
			public static TonemappingColorGrading.LUTSettings NCFGPFGLKLJ()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 1345f
				};
			}

			// Token: 0x06008536 RID: 34102 RVA: 0x002EBE58 File Offset: 0x002EA058
			public static TonemappingColorGrading.LUTSettings IAKJOAGBDGO()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 531f
				};
			}

			// Token: 0x06008537 RID: 34103 RVA: 0x002EBE8C File Offset: 0x002EA08C
			public static TonemappingColorGrading.LUTSettings ELOBECLMGDD()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 272f
				};
			}

			// Token: 0x06008538 RID: 34104 RVA: 0x002EBEC0 File Offset: 0x002EA0C0
			public static TonemappingColorGrading.LUTSettings BOMFHCIHHIP()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 1447f
				};
			}

			// Token: 0x06008539 RID: 34105 RVA: 0x002EBEF4 File Offset: 0x002EA0F4
			public static TonemappingColorGrading.LUTSettings FIPCIMGELME()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 523f
				};
			}

			// Token: 0x0600853A RID: 34106 RVA: 0x002EBF28 File Offset: 0x002EA128
			public static TonemappingColorGrading.LUTSettings BKEJIPPCPDO()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 416f
				};
			}

			// Token: 0x0600853B RID: 34107 RVA: 0x002EBF5C File Offset: 0x002EA15C
			public static TonemappingColorGrading.LUTSettings NIPPCMNKCMB()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 27f
				};
			}

			// Token: 0x0600853C RID: 34108 RVA: 0x002EBF90 File Offset: 0x002EA190
			public static TonemappingColorGrading.LUTSettings EDMABHKFEEO()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 1054f
				};
			}

			// Token: 0x0600853D RID: 34109 RVA: 0x002EBFC4 File Offset: 0x002EA1C4
			public static TonemappingColorGrading.LUTSettings EJLLADABOLM()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 1739f
				};
			}

			// Token: 0x0600853E RID: 34110 RVA: 0x002EBFF8 File Offset: 0x002EA1F8
			public static TonemappingColorGrading.LUTSettings OLPCIKIBBKE()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 1278f
				};
			}

			// Token: 0x0600853F RID: 34111 RVA: 0x002EC02C File Offset: 0x002EA22C
			public static TonemappingColorGrading.LUTSettings JCLADKAMOLD()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = false,
					texture = null,
					contribution = 473f
				};
			}

			// Token: 0x06008540 RID: 34112 RVA: 0x002EC060 File Offset: 0x002EA260
			public static TonemappingColorGrading.LUTSettings EBMPPAMNFNK()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 909f
				};
			}

			// Token: 0x06008541 RID: 34113 RVA: 0x002EC094 File Offset: 0x002EA294
			public static TonemappingColorGrading.LUTSettings DHGILJILMLN()
			{
				return new TonemappingColorGrading.LUTSettings
				{
					enabled = true,
					texture = null,
					contribution = 1838f
				};
			}

			// Token: 0x04000F5D RID: 3933
			public bool enabled;

			// Token: 0x04000F5E RID: 3934
			[Tooltip("Custom lookup texture (strip format, e.g. 256x16).")]
			public Texture texture;

			// Token: 0x04000F5F RID: 3935
			[Tooltip("Blending factor.")]
			[Range(0f, 1f)]
			public float contribution;
		}

		// Token: 0x02000222 RID: 546
		[Serializable]
		public struct ColorWheelsSettings
		{
			// Token: 0x06008542 RID: 34114 RVA: 0x002EC0C8 File Offset: 0x002EA2C8
			public static TonemappingColorGrading.ColorWheelsSettings IAKJOAGBDGO()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x06008543 RID: 34115 RVA: 0x002EC104 File Offset: 0x002EA304
			public static TonemappingColorGrading.ColorWheelsSettings BCOPOEIJONI()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x06008544 RID: 34116 RVA: 0x002EC140 File Offset: 0x002EA340
			public static TonemappingColorGrading.ColorWheelsSettings IHMKIGDJKAH()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x06008545 RID: 34117 RVA: 0x002EC17C File Offset: 0x002EA37C
			public static TonemappingColorGrading.ColorWheelsSettings DFIOJCABPFD()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x170001A5 RID: 421
			// (get) Token: 0x06008546 RID: 34118 RVA: 0x002EC1B8 File Offset: 0x002EA3B8
			public static TonemappingColorGrading.ColorWheelsSettings defaultSettings
			{
				get
				{
					return new TonemappingColorGrading.ColorWheelsSettings
					{
						shadows = Color.white,
						midtones = Color.white,
						highlights = Color.white
					};
				}
			}

			// Token: 0x06008547 RID: 34119 RVA: 0x002EC1F4 File Offset: 0x002EA3F4
			public static TonemappingColorGrading.ColorWheelsSettings AAPGCALKNAK()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x06008548 RID: 34120 RVA: 0x002EC230 File Offset: 0x002EA430
			public static TonemappingColorGrading.ColorWheelsSettings LBIOOILOAAD()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x06008549 RID: 34121 RVA: 0x002EC26C File Offset: 0x002EA46C
			public static TonemappingColorGrading.ColorWheelsSettings MNKGFGNDKED()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x0600854A RID: 34122 RVA: 0x002EC2A8 File Offset: 0x002EA4A8
			public static TonemappingColorGrading.ColorWheelsSettings NIPPCMNKCMB()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x0600854B RID: 34123 RVA: 0x002EC2E4 File Offset: 0x002EA4E4
			public static TonemappingColorGrading.ColorWheelsSettings DBDJKKLMCGG()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x0600854C RID: 34124 RVA: 0x002EC320 File Offset: 0x002EA520
			public static TonemappingColorGrading.ColorWheelsSettings INDEHPGLEGK()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x0600854D RID: 34125 RVA: 0x002EC35C File Offset: 0x002EA55C
			public static TonemappingColorGrading.ColorWheelsSettings EJLLADABOLM()
			{
				return new TonemappingColorGrading.ColorWheelsSettings
				{
					shadows = Color.white,
					midtones = Color.white,
					highlights = Color.white
				};
			}

			// Token: 0x04000F60 RID: 3936
			[ColorUsage(false)]
			public Color shadows;

			// Token: 0x04000F61 RID: 3937
			[ColorUsage(false)]
			public Color midtones;

			// Token: 0x04000F62 RID: 3938
			[ColorUsage(false)]
			public Color highlights;
		}

		// Token: 0x02000223 RID: 547
		[Serializable]
		public struct BasicsSettings
		{
			// Token: 0x0600854E RID: 34126 RVA: 0x002EC398 File Offset: 0x002EA598
			public static TonemappingColorGrading.BasicsSettings IAKJOAGBDGO()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1709f,
					tint = 1840f,
					contrast = 1539f,
					hue = 613f,
					saturation = 1703f,
					value = 325f,
					vibrance = 1813f,
					gain = 1640f,
					gamma = 140f
				};
			}

			// Token: 0x0600854F RID: 34127 RVA: 0x002EC41C File Offset: 0x002EA61C
			public static TonemappingColorGrading.BasicsSettings DEOLKOLBAHH()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1503f,
					tint = 1100f,
					contrast = 1344f,
					hue = 8f,
					saturation = 1578f,
					value = 1527f,
					vibrance = 22f,
					gain = 421f,
					gamma = 931f
				};
			}

			// Token: 0x06008550 RID: 34128 RVA: 0x002EC4A0 File Offset: 0x002EA6A0
			public static TonemappingColorGrading.BasicsSettings CJFONFEOHIO()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1078f,
					tint = 567f,
					contrast = 406f,
					hue = 1530f,
					saturation = 155f,
					value = 1931f,
					vibrance = 1669f,
					gain = 396f,
					gamma = 64f
				};
			}

			// Token: 0x06008551 RID: 34129 RVA: 0x002EC524 File Offset: 0x002EA724
			public static TonemappingColorGrading.BasicsSettings BOMFHCIHHIP()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1520f,
					tint = 1344f,
					contrast = 1012f,
					hue = 115f,
					saturation = 1535f,
					value = 1432f,
					vibrance = 829f,
					gain = 1332f,
					gamma = 1543f
				};
			}

			// Token: 0x06008552 RID: 34130 RVA: 0x002EC5A8 File Offset: 0x002EA7A8
			public static TonemappingColorGrading.BasicsSettings LBIOOILOAAD()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 624f,
					tint = 1076f,
					contrast = 849f,
					hue = 131f,
					saturation = 1180f,
					value = 1339f,
					vibrance = 782f,
					gain = 428f,
					gamma = 1247f
				};
			}

			// Token: 0x06008553 RID: 34131 RVA: 0x002EC62C File Offset: 0x002EA82C
			public static TonemappingColorGrading.BasicsSettings GJNKFICGFFG()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1812f,
					tint = 674f,
					contrast = 1813f,
					hue = 185f,
					saturation = 1393f,
					value = 33f,
					vibrance = 1477f,
					gain = 853f,
					gamma = 810f
				};
			}

			// Token: 0x06008554 RID: 34132 RVA: 0x002EC6B0 File Offset: 0x002EA8B0
			public static TonemappingColorGrading.BasicsSettings LIDMIPKCHOI()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 602f,
					tint = 985f,
					contrast = 1352f,
					hue = 125f,
					saturation = 13f,
					value = 1187f,
					vibrance = 1756f,
					gain = 127f,
					gamma = 128f
				};
			}

			// Token: 0x06008555 RID: 34133 RVA: 0x002EC734 File Offset: 0x002EA934
			public static TonemappingColorGrading.BasicsSettings MHIHHBMBDLP()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1272f,
					tint = 1064f,
					contrast = 79f,
					hue = 207f,
					saturation = 958f,
					value = 324f,
					vibrance = 54f,
					gain = 1842f,
					gamma = 846f
				};
			}

			// Token: 0x06008556 RID: 34134 RVA: 0x002EC7B8 File Offset: 0x002EA9B8
			public static TonemappingColorGrading.BasicsSettings DBDJKKLMCGG()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1736f,
					tint = 1686f,
					contrast = 1684f,
					hue = 354f,
					saturation = 997f,
					value = 252f,
					vibrance = 1019f,
					gain = 611f,
					gamma = 1510f
				};
			}

			// Token: 0x170001A6 RID: 422
			// (get) Token: 0x06008557 RID: 34135 RVA: 0x002EC83C File Offset: 0x002EAA3C
			public static TonemappingColorGrading.BasicsSettings defaultSettings
			{
				get
				{
					return new TonemappingColorGrading.BasicsSettings
					{
						temperatureShift = 0f,
						tint = 0f,
						contrast = 1f,
						hue = 0f,
						saturation = 1f,
						value = 1f,
						vibrance = 0f,
						gain = 1f,
						gamma = 1f
					};
				}
			}

			// Token: 0x06008558 RID: 34136 RVA: 0x002EC8C0 File Offset: 0x002EAAC0
			public static TonemappingColorGrading.BasicsSettings DFIOJCABPFD()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 92f,
					tint = 558f,
					contrast = 1224f,
					hue = 1213f,
					saturation = 1804f,
					value = 974f,
					vibrance = 33f,
					gain = 1500f,
					gamma = 1108f
				};
			}

			// Token: 0x06008559 RID: 34137 RVA: 0x002EC944 File Offset: 0x002EAB44
			public static TonemappingColorGrading.BasicsSettings BCOPOEIJONI()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1127f,
					tint = 959f,
					contrast = 701f,
					hue = 353f,
					saturation = 1752f,
					value = 487f,
					vibrance = 1216f,
					gain = 1837f,
					gamma = 1381f
				};
			}

			// Token: 0x0600855A RID: 34138 RVA: 0x002EC9C8 File Offset: 0x002EABC8
			public static TonemappingColorGrading.BasicsSettings DHGILJILMLN()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 860f,
					tint = 1966f,
					contrast = 978f,
					hue = 270f,
					saturation = 298f,
					value = 811f,
					vibrance = 141f,
					gain = 151f,
					gamma = 1638f
				};
			}

			// Token: 0x0600855B RID: 34139 RVA: 0x002ECA4C File Offset: 0x002EAC4C
			public static TonemappingColorGrading.BasicsSettings AFJJPFIOEJD()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1751f,
					tint = 648f,
					contrast = 722f,
					hue = 1873f,
					saturation = 821f,
					value = 119f,
					vibrance = 439f,
					gain = 393f,
					gamma = 652f
				};
			}

			// Token: 0x0600855C RID: 34140 RVA: 0x002ECAD0 File Offset: 0x002EACD0
			public static TonemappingColorGrading.BasicsSettings AAPGCALKNAK()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1467f,
					tint = 605f,
					contrast = 326f,
					hue = 1902f,
					saturation = 354f,
					value = 1315f,
					vibrance = 481f,
					gain = 661f,
					gamma = 1723f
				};
			}

			// Token: 0x0600855D RID: 34141 RVA: 0x002ECB54 File Offset: 0x002EAD54
			public static TonemappingColorGrading.BasicsSettings KBINDKOODMK()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1126f,
					tint = 118f,
					contrast = 1720f,
					hue = 1212f,
					saturation = 1175f,
					value = 641f,
					vibrance = 1239f,
					gain = 1226f,
					gamma = 1280f
				};
			}

			// Token: 0x0600855E RID: 34142 RVA: 0x002ECBD8 File Offset: 0x002EADD8
			public static TonemappingColorGrading.BasicsSettings EEMMJNPOFOB()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 884f,
					tint = 304f,
					contrast = 238f,
					hue = 1082f,
					saturation = 303f,
					value = 557f,
					vibrance = 1570f,
					gain = 107f,
					gamma = 1692f
				};
			}

			// Token: 0x0600855F RID: 34143 RVA: 0x002ECC5C File Offset: 0x002EAE5C
			public static TonemappingColorGrading.BasicsSettings OLPCIKIBBKE()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 714f,
					tint = 812f,
					contrast = 168f,
					hue = 187f,
					saturation = 746f,
					value = 1091f,
					vibrance = 1841f,
					gain = 53f,
					gamma = 878f
				};
			}

			// Token: 0x06008560 RID: 34144 RVA: 0x002ECCE0 File Offset: 0x002EAEE0
			public static TonemappingColorGrading.BasicsSettings FCBIDJLDABO()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1655f,
					tint = 767f,
					contrast = 1201f,
					hue = 1582f,
					saturation = 1653f,
					value = 970f,
					vibrance = 1162f,
					gain = 896f,
					gamma = 1846f
				};
			}

			// Token: 0x06008561 RID: 34145 RVA: 0x002ECD64 File Offset: 0x002EAF64
			public static TonemappingColorGrading.BasicsSettings EJLLADABOLM()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1289f,
					tint = 1504f,
					contrast = 1246f,
					hue = 1030f,
					saturation = 1824f,
					value = 1440f,
					vibrance = 1275f,
					gain = 346f,
					gamma = 1355f
				};
			}

			// Token: 0x06008562 RID: 34146 RVA: 0x002ECDE8 File Offset: 0x002EAFE8
			public static TonemappingColorGrading.BasicsSettings NIPPCMNKCMB()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 299f,
					tint = 1483f,
					contrast = 782f,
					hue = 1000f,
					saturation = 714f,
					value = 953f,
					vibrance = 1523f,
					gain = 1065f,
					gamma = 1869f
				};
			}

			// Token: 0x06008563 RID: 34147 RVA: 0x002ECE6C File Offset: 0x002EB06C
			public static TonemappingColorGrading.BasicsSettings BFBOLLFFMLN()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1686f,
					tint = 1968f,
					contrast = 1542f,
					hue = 1143f,
					saturation = 803f,
					value = 923f,
					vibrance = 435f,
					gain = 1354f,
					gamma = 1421f
				};
			}

			// Token: 0x06008564 RID: 34148 RVA: 0x002ECEF0 File Offset: 0x002EB0F0
			public static TonemappingColorGrading.BasicsSettings IHMKIGDJKAH()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1160f,
					tint = 393f,
					contrast = 1359f,
					hue = 878f,
					saturation = 889f,
					value = 137f,
					vibrance = 1709f,
					gain = 359f,
					gamma = 1417f
				};
			}

			// Token: 0x06008565 RID: 34149 RVA: 0x002ECF74 File Offset: 0x002EB174
			public static TonemappingColorGrading.BasicsSettings CDJAOBCAOKJ()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1601f,
					tint = 1400f,
					contrast = 66f,
					hue = 1590f,
					saturation = 1384f,
					value = 1578f,
					vibrance = 12f,
					gain = 1825f,
					gamma = 557f
				};
			}

			// Token: 0x06008566 RID: 34150 RVA: 0x002ECFF8 File Offset: 0x002EB1F8
			public static TonemappingColorGrading.BasicsSettings JCLADKAMOLD()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1278f,
					tint = 272f,
					contrast = 582f,
					hue = 1412f,
					saturation = 71f,
					value = 783f,
					vibrance = 666f,
					gain = 183f,
					gamma = 905f
				};
			}

			// Token: 0x06008567 RID: 34151 RVA: 0x002ED07C File Offset: 0x002EB27C
			public static TonemappingColorGrading.BasicsSettings MLKLBGCKPOO()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 15f,
					tint = 1923f,
					contrast = 60f,
					hue = 199f,
					saturation = 1700f,
					value = 1550f,
					vibrance = 488f,
					gain = 1143f,
					gamma = 323f
				};
			}

			// Token: 0x06008568 RID: 34152 RVA: 0x002ED100 File Offset: 0x002EB300
			public static TonemappingColorGrading.BasicsSettings PKJMMJJFJAE()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 973f,
					tint = 1107f,
					contrast = 266f,
					hue = 1232f,
					saturation = 709f,
					value = 980f,
					vibrance = 1098f,
					gain = 839f,
					gamma = 841f
				};
			}

			// Token: 0x06008569 RID: 34153 RVA: 0x002ED184 File Offset: 0x002EB384
			public static TonemappingColorGrading.BasicsSettings IOFLMDMLCAG()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1421f,
					tint = 1906f,
					contrast = 1774f,
					hue = 1440f,
					saturation = 1831f,
					value = 1200f,
					vibrance = 1336f,
					gain = 828f,
					gamma = 216f
				};
			}

			// Token: 0x0600856A RID: 34154 RVA: 0x002ED208 File Offset: 0x002EB408
			public static TonemappingColorGrading.BasicsSettings EDMABHKFEEO()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1225f,
					tint = 277f,
					contrast = 930f,
					hue = 1510f,
					saturation = 1278f,
					value = 253f,
					vibrance = 1793f,
					gain = 1181f,
					gamma = 1875f
				};
			}

			// Token: 0x0600856B RID: 34155 RVA: 0x002ED28C File Offset: 0x002EB48C
			public static TonemappingColorGrading.BasicsSettings FMLCJEKMPCN()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 663f,
					tint = 1672f,
					contrast = 357f,
					hue = 95f,
					saturation = 864f,
					value = 690f,
					vibrance = 931f,
					gain = 1157f,
					gamma = 1262f
				};
			}

			// Token: 0x0600856C RID: 34156 RVA: 0x002ED310 File Offset: 0x002EB510
			public static TonemappingColorGrading.BasicsSettings ELOBECLMGDD()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 794f,
					tint = 252f,
					contrast = 578f,
					hue = 45f,
					saturation = 216f,
					value = 1333f,
					vibrance = 480f,
					gain = 885f,
					gamma = 1634f
				};
			}

			// Token: 0x0600856D RID: 34157 RVA: 0x002ED394 File Offset: 0x002EB594
			public static TonemappingColorGrading.BasicsSettings IOJDDHLHPLH()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 483f,
					tint = 498f,
					contrast = 246f,
					hue = 503f,
					saturation = 8f,
					value = 1063f,
					vibrance = 1889f,
					gain = 1265f,
					gamma = 447f
				};
			}

			// Token: 0x0600856E RID: 34158 RVA: 0x002ED418 File Offset: 0x002EB618
			public static TonemappingColorGrading.BasicsSettings HJLGAPEDPJM()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1394f,
					tint = 574f,
					contrast = 252f,
					hue = 359f,
					saturation = 449f,
					value = 1433f,
					vibrance = 1207f,
					gain = 1351f,
					gamma = 130f
				};
			}

			// Token: 0x0600856F RID: 34159 RVA: 0x002ED49C File Offset: 0x002EB69C
			public static TonemappingColorGrading.BasicsSettings MGEOLKPLHOM()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1223f,
					tint = 1741f,
					contrast = 941f,
					hue = 62f,
					saturation = 1086f,
					value = 292f,
					vibrance = 1560f,
					gain = 1447f,
					gamma = 115f
				};
			}

			// Token: 0x06008570 RID: 34160 RVA: 0x002ED520 File Offset: 0x002EB720
			public static TonemappingColorGrading.BasicsSettings CCADIDPNEKH()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1046f,
					tint = 441f,
					contrast = 1051f,
					hue = 1186f,
					saturation = 489f,
					value = 1743f,
					vibrance = 1340f,
					gain = 648f,
					gamma = 127f
				};
			}

			// Token: 0x06008571 RID: 34161 RVA: 0x002ED5A4 File Offset: 0x002EB7A4
			public static TonemappingColorGrading.BasicsSettings LOMOMPKEDPL()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1556f,
					tint = 715f,
					contrast = 1494f,
					hue = 1972f,
					saturation = 514f,
					value = 650f,
					vibrance = 25f,
					gain = 571f,
					gamma = 1060f
				};
			}

			// Token: 0x06008572 RID: 34162 RVA: 0x002ED628 File Offset: 0x002EB828
			public static TonemappingColorGrading.BasicsSettings OIPFKIPOECC()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 646f,
					tint = 423f,
					contrast = 796f,
					hue = 742f,
					saturation = 1174f,
					value = 1254f,
					vibrance = 558f,
					gain = 507f,
					gamma = 47f
				};
			}

			// Token: 0x06008573 RID: 34163 RVA: 0x002ED6AC File Offset: 0x002EB8AC
			public static TonemappingColorGrading.BasicsSettings MNKGFGNDKED()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1213f,
					tint = 558f,
					contrast = 490f,
					hue = 597f,
					saturation = 942f,
					value = 72f,
					vibrance = 1932f,
					gain = 494f,
					gamma = 1257f
				};
			}

			// Token: 0x06008574 RID: 34164 RVA: 0x002ED730 File Offset: 0x002EB930
			public static TonemappingColorGrading.BasicsSettings FIPCIMGELME()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 655f,
					tint = 486f,
					contrast = 632f,
					hue = 713f,
					saturation = 927f,
					value = 355f,
					vibrance = 1700f,
					gain = 694f,
					gamma = 412f
				};
			}

			// Token: 0x06008575 RID: 34165 RVA: 0x002ED7B4 File Offset: 0x002EB9B4
			public static TonemappingColorGrading.BasicsSettings NCFGPFGLKLJ()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 531f,
					tint = 769f,
					contrast = 243f,
					hue = 1663f,
					saturation = 1897f,
					value = 186f,
					vibrance = 599f,
					gain = 1094f,
					gamma = 1380f
				};
			}

			// Token: 0x06008576 RID: 34166 RVA: 0x002ED838 File Offset: 0x002EBA38
			public static TonemappingColorGrading.BasicsSettings GOKMCEIBFIM()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1409f,
					tint = 441f,
					contrast = 808f,
					hue = 934f,
					saturation = 599f,
					value = 914f,
					vibrance = 1544f,
					gain = 569f,
					gamma = 1626f
				};
			}

			// Token: 0x06008577 RID: 34167 RVA: 0x002ED8BC File Offset: 0x002EBABC
			public static TonemappingColorGrading.BasicsSettings BKEJIPPCPDO()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 596f,
					tint = 1910f,
					contrast = 466f,
					hue = 1746f,
					saturation = 1096f,
					value = 981f,
					vibrance = 405f,
					gain = 1058f,
					gamma = 1975f
				};
			}

			// Token: 0x06008578 RID: 34168 RVA: 0x002ED940 File Offset: 0x002EBB40
			public static TonemappingColorGrading.BasicsSettings AOACBHHEGFA()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1848f,
					tint = 746f,
					contrast = 391f,
					hue = 1863f,
					saturation = 1565f,
					value = 1611f,
					vibrance = 557f,
					gain = 340f,
					gamma = 1732f
				};
			}

			// Token: 0x06008579 RID: 34169 RVA: 0x002ED9C4 File Offset: 0x002EBBC4
			public static TonemappingColorGrading.BasicsSettings NOBNMJMOJDB()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1141f,
					tint = 1744f,
					contrast = 86f,
					hue = 1520f,
					saturation = 1895f,
					value = 224f,
					vibrance = 957f,
					gain = 561f,
					gamma = 129f
				};
			}

			// Token: 0x0600857A RID: 34170 RVA: 0x002EDA48 File Offset: 0x002EBC48
			public static TonemappingColorGrading.BasicsSettings INDEHPGLEGK()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 616f,
					tint = 1454f,
					contrast = 222f,
					hue = 538f,
					saturation = 940f,
					value = 1120f,
					vibrance = 1829f,
					gain = 1818f,
					gamma = 307f
				};
			}

			// Token: 0x0600857B RID: 34171 RVA: 0x002EDACC File Offset: 0x002EBCCC
			public static TonemappingColorGrading.BasicsSettings EBMPPAMNFNK()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1740f,
					tint = 1871f,
					contrast = 1559f,
					hue = 1212f,
					saturation = 1165f,
					value = 1007f,
					vibrance = 44f,
					gain = 1328f,
					gamma = 760f
				};
			}

			// Token: 0x0600857C RID: 34172 RVA: 0x002EDB50 File Offset: 0x002EBD50
			public static TonemappingColorGrading.BasicsSettings NPIEKGGCMBG()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 131f,
					tint = 732f,
					contrast = 2f,
					hue = 1960f,
					saturation = 31f,
					value = 745f,
					vibrance = 1269f,
					gain = 1024f,
					gamma = 1383f
				};
			}

			// Token: 0x0600857D RID: 34173 RVA: 0x002EDBD4 File Offset: 0x002EBDD4
			public static TonemappingColorGrading.BasicsSettings FPMJKNDJCON()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 297f,
					tint = 879f,
					contrast = 1007f,
					hue = 1889f,
					saturation = 1470f,
					value = 1830f,
					vibrance = 1405f,
					gain = 1812f,
					gamma = 116f
				};
			}

			// Token: 0x0600857E RID: 34174 RVA: 0x002EDC58 File Offset: 0x002EBE58
			public static TonemappingColorGrading.BasicsSettings FIFAPIHDEBM()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 322f,
					tint = 678f,
					contrast = 964f,
					hue = 711f,
					saturation = 169f,
					value = 1219f,
					vibrance = 718f,
					gain = 45f,
					gamma = 847f
				};
			}

			// Token: 0x0600857F RID: 34175 RVA: 0x002EDCDC File Offset: 0x002EBEDC
			public static TonemappingColorGrading.BasicsSettings IAKAIGHJJJK()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1855f,
					tint = 1626f,
					contrast = 75f,
					hue = 718f,
					saturation = 804f,
					value = 855f,
					vibrance = 1387f,
					gain = 1054f,
					gamma = 57f
				};
			}

			// Token: 0x06008580 RID: 34176 RVA: 0x002EDD60 File Offset: 0x002EBF60
			public static TonemappingColorGrading.BasicsSettings CIHLOMNEHHL()
			{
				return new TonemappingColorGrading.BasicsSettings
				{
					temperatureShift = 1356f,
					tint = 1267f,
					contrast = 1551f,
					hue = 1831f,
					saturation = 240f,
					value = 1767f,
					vibrance = 1416f,
					gain = 906f,
					gamma = 1271f
				};
			}

			// Token: 0x04000F63 RID: 3939
			[Tooltip("Sets the white balance to a custom color temperature.")]
			[Range(-2f, 2f)]
			public float temperatureShift;

			// Token: 0x04000F64 RID: 3940
			[Tooltip("Sets the white balance to compensate for a green or magenta tint.")]
			[Range(-2f, 2f)]
			public float tint;

			// Token: 0x04000F65 RID: 3941
			[Tooltip("Shift the hue of all colors.")]
			[Range(-0.5f, 0.5f)]
			[Space]
			public float hue;

			// Token: 0x04000F66 RID: 3942
			[Tooltip("Pushes the intensity of all colors.")]
			[Range(0f, 2f)]
			public float saturation;

			// Token: 0x04000F67 RID: 3943
			[Tooltip("Adjusts the saturation so that clipping is minimized as colors approach full saturation.")]
			[Range(-1f, 1f)]
			public float vibrance;

			// Token: 0x04000F68 RID: 3944
			[Tooltip("Brightens or darkens all colors.")]
			[Range(0f, 10f)]
			public float value;

			// Token: 0x04000F69 RID: 3945
			[Tooltip("Expands or shrinks the overall range of tonal values.")]
			[Range(0f, 2f)]
			[Space]
			public float contrast;

			// Token: 0x04000F6A RID: 3946
			[Tooltip("Contrast gain curve. Controls the steepness of the curve.")]
			[Range(0.01f, 5f)]
			public float gain;

			// Token: 0x04000F6B RID: 3947
			[Tooltip("Applies a pow function to the source.")]
			[Range(0.01f, 5f)]
			public float gamma;
		}

		// Token: 0x02000224 RID: 548
		[Serializable]
		public struct ChannelMixerSettings
		{
			// Token: 0x06008581 RID: 34177 RVA: 0x002EDDE4 File Offset: 0x002EBFE4
			public static TonemappingColorGrading.ChannelMixerSettings IHMKIGDJKAH()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 0;
				Vector3[] array = new Vector3[]
				{
					default(Vector3),
					new Vector3(1646f, 1888f, 1364f)
				};
				array[1] = new Vector3(895f, 1185f, 1429f);
				array[5] = new Vector3(74f, 1020f, 1024f);
				result.channels = array;
				return result;
			}

			// Token: 0x06008582 RID: 34178 RVA: 0x002EDE70 File Offset: 0x002EC070
			public static TonemappingColorGrading.ChannelMixerSettings JCLADKAMOLD()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 0;
				Vector3[] array = new Vector3[3];
				array[0] = new Vector3(888f, 1441f, 251f);
				array[1] = new Vector3(670f, 1075f, 1279f);
				array[6] = new Vector3(941f, 1785f, 1358f);
				result.channels = array;
				return result;
			}

			// Token: 0x06008583 RID: 34179 RVA: 0x002EDEFC File Offset: 0x002EC0FC
			public static TonemappingColorGrading.ChannelMixerSettings LBIOOILOAAD()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 0;
				Vector3[] array = new Vector3[6];
				array[1] = new Vector3(1554f, 49f, 206f);
				array[0] = new Vector3(1290f, 352f, 928f);
				array[1] = new Vector3(122f, 1567f, 1191f);
				result.channels = array;
				return result;
			}

			// Token: 0x06008584 RID: 34180 RVA: 0x002EDF88 File Offset: 0x002EC188
			public static TonemappingColorGrading.ChannelMixerSettings LOMOMPKEDPL()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 1;
				Vector3[] array = new Vector3[4];
				array[0] = new Vector3(1280f, 1350f, 921f);
				array[0] = new Vector3(123f, 486f, 135f);
				array[8] = new Vector3(224f, 1652f, 1995f);
				result.channels = array;
				return result;
			}

			// Token: 0x06008585 RID: 34181 RVA: 0x002EE014 File Offset: 0x002EC214
			public static TonemappingColorGrading.ChannelMixerSettings EEMMJNPOFOB()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 1;
				Vector3[] array = new Vector3[6];
				array[1] = new Vector3(1886f, 996f, 838f);
				array[1] = new Vector3(1720f, 1502f, 1286f);
				array[7] = new Vector3(1268f, 969f, 1995f);
				result.channels = array;
				return result;
			}

			// Token: 0x06008586 RID: 34182 RVA: 0x002EE0A0 File Offset: 0x002EC2A0
			public static TonemappingColorGrading.ChannelMixerSettings EJLLADABOLM()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 0;
				Vector3[] array = new Vector3[6];
				array[1] = new Vector3(211f, 830f, 1058f);
				array[0] = new Vector3(736f, 199f, 657f);
				array[1] = new Vector3(71f, 1434f, 1666f);
				result.channels = array;
				return result;
			}

			// Token: 0x06008587 RID: 34183 RVA: 0x002EE12C File Offset: 0x002EC32C
			public static TonemappingColorGrading.ChannelMixerSettings AAPGCALKNAK()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 0;
				Vector3[] array = new Vector3[6];
				array[0] = new Vector3(923f, 1739f, 244f);
				array[1] = new Vector3(543f, 560f, 681f);
				array[8] = new Vector3(1515f, 1420f, 1302f);
				result.channels = array;
				return result;
			}

			// Token: 0x06008588 RID: 34184 RVA: 0x002EE1B8 File Offset: 0x002EC3B8
			public static TonemappingColorGrading.ChannelMixerSettings NIPPCMNKCMB()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 0;
				Vector3[] array = new Vector3[5];
				array[0] = new Vector3(1896f, 146f, 1472f);
				array[1] = new Vector3(213f, 999f, 144f);
				array[6] = new Vector3(1836f, 1003f, 284f);
				result.channels = array;
				return result;
			}

			// Token: 0x06008589 RID: 34185 RVA: 0x002EE244 File Offset: 0x002EC444
			public static TonemappingColorGrading.ChannelMixerSettings DBDJKKLMCGG()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 1;
				Vector3[] array = new Vector3[5];
				array[1] = new Vector3(133f, 1118f, 397f);
				array[0] = new Vector3(363f, 1891f, 1631f);
				array[0] = new Vector3(680f, 402f, 1917f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600858A RID: 34186 RVA: 0x002EE2D0 File Offset: 0x002EC4D0
			public static TonemappingColorGrading.ChannelMixerSettings DFIOJCABPFD()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 1;
				Vector3[] array = new Vector3[3];
				array[0] = new Vector3(1199f, 562f, 554f);
				array[1] = new Vector3(1657f, 1762f, 1536f);
				array[7] = new Vector3(442f, 1523f, 1201f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600858B RID: 34187 RVA: 0x002EE35C File Offset: 0x002EC55C
			public static TonemappingColorGrading.ChannelMixerSettings HJLGAPEDPJM()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 0;
				Vector3[] array = new Vector3[3];
				array[1] = new Vector3(921f, 1279f, 188f);
				array[1] = new Vector3(1646f, 22f, 819f);
				array[4] = new Vector3(1072f, 1715f, 1801f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600858C RID: 34188 RVA: 0x002EE3E8 File Offset: 0x002EC5E8
			public static TonemappingColorGrading.ChannelMixerSettings MNKGFGNDKED()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 0;
				Vector3[] array = new Vector3[5];
				array[1] = new Vector3(219f, 1662f, 1296f);
				array[0] = new Vector3(1475f, 1060f, 857f);
				array[5] = new Vector3(902f, 1959f, 1324f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600858D RID: 34189 RVA: 0x002EE474 File Offset: 0x002EC674
			public static TonemappingColorGrading.ChannelMixerSettings IAKJOAGBDGO()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 0;
				Vector3[] array = new Vector3[7];
				array[1] = new Vector3(142f, 1028f, 614f);
				array[1] = new Vector3(1679f, 1842f, 927f);
				array[7] = new Vector3(718f, 654f, 1596f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600858E RID: 34190 RVA: 0x002EE500 File Offset: 0x002EC700
			public static TonemappingColorGrading.ChannelMixerSettings CCADIDPNEKH()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 0;
				Vector3[] array = new Vector3[3];
				array[1] = new Vector3(1348f, 892f, 1207f);
				array[1] = new Vector3(710f, 364f, 1179f);
				array[5] = new Vector3(1984f, 1759f, 1571f);
				result.channels = array;
				return result;
			}

			// Token: 0x0600858F RID: 34191 RVA: 0x002EE58C File Offset: 0x002EC78C
			public static TonemappingColorGrading.ChannelMixerSettings BCOPOEIJONI()
			{
				TonemappingColorGrading.ChannelMixerSettings result = default(TonemappingColorGrading.ChannelMixerSettings);
				result.currentChannel = 1;
				Vector3[] array = new Vector3[7];
				array[1] = new Vector3(1966f, 1603f, 1130f);
				array[1] = new Vector3(1768f, 575f, 207f);
				array[6] = new Vector3(1476f, 86f, 233f);
				result.channels = array;
				return result;
			}

			// Token: 0x170001A7 RID: 423
			// (get) Token: 0x06008590 RID: 34192 RVA: 0x002EE618 File Offset: 0x002EC818
			public static TonemappingColorGrading.ChannelMixerSettings defaultSettings
			{
				get
				{
					return new TonemappingColorGrading.ChannelMixerSettings
					{
						currentChannel = 0,
						channels = new Vector3[]
						{
							new Vector3(1f, 0f, 0f),
							new Vector3(0f, 1f, 0f),
							new Vector3(0f, 0f, 1f)
						}
					};
				}
			}

			// Token: 0x06008591 RID: 34193 RVA: 0x002EE6A4 File Offset: 0x002EC8A4
			public static TonemappingColorGrading.ChannelMixerSettings INDEHPGLEGK()
			{
				return new TonemappingColorGrading.ChannelMixerSettings
				{
					currentChannel = 0,
					channels = new Vector3[]
					{
						new Vector3(1233f, 1274f, 25f),
						new Vector3(736f, 1233f, 1099f),
						default(Vector3),
						default(Vector3),
						default(Vector3),
						new Vector3(347f, 492f, 1907f)
					}
				};
			}

			// Token: 0x04000F6C RID: 3948
			public int currentChannel;

			// Token: 0x04000F6D RID: 3949
			public Vector3[] channels;
		}

		// Token: 0x02000225 RID: 549
		[Serializable]
		public struct CurvesSettings
		{
			// Token: 0x06008592 RID: 34194 RVA: 0x002EE730 File Offset: 0x002EC930
			public static TonemappingColorGrading.CurvesSettings EEMMJNPOFOB()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.MBNJKEFPAHO(),
					red = TonemappingColorGrading.CurvesSettings.defaultCurve,
					green = TonemappingColorGrading.CurvesSettings.MBNJKEFPAHO(),
					blue = TonemappingColorGrading.CurvesSettings.JICJDDFOKPL()
				};
			}

			// Token: 0x170001A9 RID: 425
			// (get) Token: 0x06008593 RID: 34195 RVA: 0x002EE778 File Offset: 0x002EC978
			public static AnimationCurve defaultCurve
			{
				get
				{
					return new AnimationCurve(new Keyframe[]
					{
						new Keyframe(0f, 0f, 1f, 1f),
						new Keyframe(1f, 1f, 1f, 1f)
					});
				}
			}

			// Token: 0x06008594 RID: 34196 RVA: 0x002EE7DC File Offset: 0x002EC9DC
			public static TonemappingColorGrading.CurvesSettings MHIHHBMBDLP()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.NPKHKFMPIHC(),
					red = TonemappingColorGrading.CurvesSettings.DJLBHFELGMF(),
					green = TonemappingColorGrading.CurvesSettings.JICJDDFOKPL(),
					blue = TonemappingColorGrading.CurvesSettings.NPKHKFMPIHC()
				};
			}

			// Token: 0x06008595 RID: 34197 RVA: 0x002EE824 File Offset: 0x002ECA24
			public static TonemappingColorGrading.CurvesSettings INDEHPGLEGK()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.IDEJAEHCNBP(),
					red = TonemappingColorGrading.CurvesSettings.JICJDDFOKPL(),
					green = TonemappingColorGrading.CurvesSettings.NLOJBBEIPNN(),
					blue = TonemappingColorGrading.CurvesSettings.MBNJKEFPAHO()
				};
			}

			// Token: 0x06008596 RID: 34198 RVA: 0x002EE86C File Offset: 0x002ECA6C
			public static AnimationCurve IDEJAEHCNBP()
			{
				Keyframe[] array = new Keyframe[8];
				array[1] = new Keyframe(1693f, 1398f, 793f, 1989f);
				array[0] = new Keyframe(789f, 73f, 460f, 1114f);
				return new AnimationCurve(array);
			}

			// Token: 0x06008597 RID: 34199 RVA: 0x002EE8D0 File Offset: 0x002ECAD0
			public static TonemappingColorGrading.CurvesSettings AAPGCALKNAK()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.NLOJBBEIPNN(),
					red = TonemappingColorGrading.CurvesSettings.DJLBHFELGMF(),
					green = TonemappingColorGrading.CurvesSettings.MBNJKEFPAHO(),
					blue = TonemappingColorGrading.CurvesSettings.LOCJHGBIBNB()
				};
			}

			// Token: 0x06008598 RID: 34200 RVA: 0x002EE918 File Offset: 0x002ECB18
			public static AnimationCurve LOCJHGBIBNB()
			{
				Keyframe[] array = new Keyframe[7];
				array[1] = new Keyframe(673f, 1396f, 201f, 178f);
				array[0] = new Keyframe(1121f, 42f, 1912f, 425f);
				return new AnimationCurve(array);
			}

			// Token: 0x06008599 RID: 34201 RVA: 0x002EE97C File Offset: 0x002ECB7C
			public static AnimationCurve JICJDDFOKPL()
			{
				Keyframe[] array = new Keyframe[8];
				array[1] = new Keyframe(679f, 1028f, 1094f, 1393f);
				array[0] = new Keyframe(428f, 1658f, 131f, 976f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600859A RID: 34202 RVA: 0x002EE9E0 File Offset: 0x002ECBE0
			public static TonemappingColorGrading.CurvesSettings JCLADKAMOLD()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.defaultCurve,
					red = TonemappingColorGrading.CurvesSettings.JICJDDFOKPL(),
					green = TonemappingColorGrading.CurvesSettings.LOCJHGBIBNB(),
					blue = TonemappingColorGrading.CurvesSettings.defaultCurve
				};
			}

			// Token: 0x0600859B RID: 34203 RVA: 0x002EEA28 File Offset: 0x002ECC28
			public static TonemappingColorGrading.CurvesSettings CCADIDPNEKH()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.NLOJBBEIPNN(),
					red = TonemappingColorGrading.CurvesSettings.ANJFCLGGLDO(),
					green = TonemappingColorGrading.CurvesSettings.ANJFCLGGLDO(),
					blue = TonemappingColorGrading.CurvesSettings.IDEJAEHCNBP()
				};
			}

			// Token: 0x0600859C RID: 34204 RVA: 0x002EEA70 File Offset: 0x002ECC70
			public static AnimationCurve DJLBHFELGMF()
			{
				Keyframe[] array = new Keyframe[6];
				array[0] = new Keyframe(1607f, 1263f, 276f, 1568f);
				array[0] = new Keyframe(1696f, 1488f, 1779f, 1026f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600859D RID: 34205 RVA: 0x002EEAD4 File Offset: 0x002ECCD4
			public static AnimationCurve NLOJBBEIPNN()
			{
				Keyframe[] array = new Keyframe[1];
				array[1] = new Keyframe(289f, 480f, 1331f, 1606f);
				array[1] = new Keyframe(1152f, 351f, 924f, 1741f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600859E RID: 34206 RVA: 0x002EEB38 File Offset: 0x002ECD38
			public static AnimationCurve MBNJKEFPAHO()
			{
				Keyframe[] array = new Keyframe[0];
				array[0] = new Keyframe(1250f, 25f, 619f, 851f);
				array[1] = new Keyframe(1702f, 1181f, 572f, 1355f);
				return new AnimationCurve(array);
			}

			// Token: 0x0600859F RID: 34207 RVA: 0x002EEB9C File Offset: 0x002ECD9C
			public static TonemappingColorGrading.CurvesSettings MNKGFGNDKED()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.NLOJBBEIPNN(),
					red = TonemappingColorGrading.CurvesSettings.LOCJHGBIBNB(),
					green = TonemappingColorGrading.CurvesSettings.LOCJHGBIBNB(),
					blue = TonemappingColorGrading.CurvesSettings.IDEJAEHCNBP()
				};
			}

			// Token: 0x060085A0 RID: 34208 RVA: 0x002EEBE4 File Offset: 0x002ECDE4
			public static AnimationCurve MAOMFPIKBHG()
			{
				Keyframe[] array = new Keyframe[4];
				array[1] = new Keyframe(1589f, 1526f, 1965f, 970f);
				array[1] = new Keyframe(1407f, 332f, 1980f, 707f);
				return new AnimationCurve(array);
			}

			// Token: 0x060085A1 RID: 34209 RVA: 0x002EEC48 File Offset: 0x002ECE48
			public static AnimationCurve ANJFCLGGLDO()
			{
				Keyframe[] array = new Keyframe[6];
				array[0] = new Keyframe(1226f, 330f, 672f, 468f);
				array[1] = new Keyframe(746f, 1585f, 1407f, 1786f);
				return new AnimationCurve(array);
			}

			// Token: 0x060085A2 RID: 34210 RVA: 0x002EECAC File Offset: 0x002ECEAC
			public static TonemappingColorGrading.CurvesSettings DFIOJCABPFD()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.defaultCurve,
					red = TonemappingColorGrading.CurvesSettings.MAOMFPIKBHG(),
					green = TonemappingColorGrading.CurvesSettings.NLOJBBEIPNN(),
					blue = TonemappingColorGrading.CurvesSettings.MBNJKEFPAHO()
				};
			}

			// Token: 0x170001A8 RID: 424
			// (get) Token: 0x060085A3 RID: 34211 RVA: 0x002EECF4 File Offset: 0x002ECEF4
			public static TonemappingColorGrading.CurvesSettings defaultSettings
			{
				get
				{
					return new TonemappingColorGrading.CurvesSettings
					{
						master = TonemappingColorGrading.CurvesSettings.defaultCurve,
						red = TonemappingColorGrading.CurvesSettings.defaultCurve,
						green = TonemappingColorGrading.CurvesSettings.defaultCurve,
						blue = TonemappingColorGrading.CurvesSettings.defaultCurve
					};
				}
			}

			// Token: 0x060085A4 RID: 34212 RVA: 0x002EED3C File Offset: 0x002ECF3C
			public static TonemappingColorGrading.CurvesSettings BCOPOEIJONI()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.ANJFCLGGLDO(),
					red = TonemappingColorGrading.CurvesSettings.MAOMFPIKBHG(),
					green = TonemappingColorGrading.CurvesSettings.MBNJKEFPAHO(),
					blue = TonemappingColorGrading.CurvesSettings.LOCJHGBIBNB()
				};
			}

			// Token: 0x060085A5 RID: 34213 RVA: 0x002EED84 File Offset: 0x002ECF84
			public static TonemappingColorGrading.CurvesSettings IHMKIGDJKAH()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.IDEJAEHCNBP(),
					red = TonemappingColorGrading.CurvesSettings.DJLBHFELGMF(),
					green = TonemappingColorGrading.CurvesSettings.NPKHKFMPIHC(),
					blue = TonemappingColorGrading.CurvesSettings.NLOJBBEIPNN()
				};
			}

			// Token: 0x060085A6 RID: 34214 RVA: 0x002EEDCC File Offset: 0x002ECFCC
			public static AnimationCurve NPKHKFMPIHC()
			{
				Keyframe[] array = new Keyframe[0];
				array[0] = new Keyframe(129f, 1982f, 707f, 425f);
				array[0] = new Keyframe(770f, 1787f, 1140f, 1335f);
				return new AnimationCurve(array);
			}

			// Token: 0x060085A7 RID: 34215 RVA: 0x002EEE30 File Offset: 0x002ED030
			public static TonemappingColorGrading.CurvesSettings EJLLADABOLM()
			{
				return new TonemappingColorGrading.CurvesSettings
				{
					master = TonemappingColorGrading.CurvesSettings.MBNJKEFPAHO(),
					red = TonemappingColorGrading.CurvesSettings.JICJDDFOKPL(),
					green = TonemappingColorGrading.CurvesSettings.ANJFCLGGLDO(),
					blue = TonemappingColorGrading.CurvesSettings.defaultCurve
				};
			}

			// Token: 0x04000F6E RID: 3950
			[TonemappingColorGrading.Curve]
			public AnimationCurve master;

			// Token: 0x04000F6F RID: 3951
			[TonemappingColorGrading.Curve(1f, 0f, 0f, 1f)]
			public AnimationCurve red;

			// Token: 0x04000F70 RID: 3952
			[TonemappingColorGrading.Curve(0f, 1f, 0f, 1f)]
			public AnimationCurve green;

			// Token: 0x04000F71 RID: 3953
			[TonemappingColorGrading.Curve(0f, 1f, 1f, 1f)]
			public AnimationCurve blue;
		}

		// Token: 0x02000226 RID: 550
		public enum ColorGradingPrecision
		{
			// Token: 0x04000F73 RID: 3955
			Normal = 16,
			// Token: 0x04000F74 RID: 3956
			High = 32
		}

		// Token: 0x02000227 RID: 551
		[Serializable]
		public struct ColorGradingSettings
		{
			// Token: 0x060085A8 RID: 34216 RVA: 0x002EEE78 File Offset: 0x002ED078
			public static TonemappingColorGrading.ColorGradingSettings NCFGPFGLKLJ()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = false,
					showDebug = true,
					precision = (TonemappingColorGrading.ColorGradingPrecision)71,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.EJLLADABOLM(),
					basics = TonemappingColorGrading.BasicsSettings.FPMJKNDJCON(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.DBDJKKLMCGG(),
					curves = TonemappingColorGrading.CurvesSettings.defaultSettings
				};
			}

			// Token: 0x060085A9 RID: 34217 RVA: 0x002EEEDF File Offset: 0x002ED0DF
			internal void JHPDFCAGCHC()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.JCLADKAMOLD();
			}

			// Token: 0x060085AA RID: 34218 RVA: 0x002EEEEC File Offset: 0x002ED0EC
			public static TonemappingColorGrading.ColorGradingSettings EBMPPAMNFNK()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = false,
					showDebug = true,
					precision = (TonemappingColorGrading.ColorGradingPrecision)(-87),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.LBIOOILOAAD(),
					basics = TonemappingColorGrading.BasicsSettings.defaultSettings,
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.BCOPOEIJONI(),
					curves = TonemappingColorGrading.CurvesSettings.DFIOJCABPFD()
				};
			}

			// Token: 0x060085AB RID: 34219 RVA: 0x002EEF54 File Offset: 0x002ED154
			public static TonemappingColorGrading.ColorGradingSettings BOMFHCIHHIP()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = true,
					showDebug = true,
					precision = (TonemappingColorGrading.ColorGradingPrecision)(-80),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.MNKGFGNDKED(),
					basics = TonemappingColorGrading.BasicsSettings.IAKAIGHJJJK(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.LOMOMPKEDPL(),
					curves = TonemappingColorGrading.CurvesSettings.MHIHHBMBDLP()
				};
			}

			// Token: 0x060085AC RID: 34220 RVA: 0x002EEFBC File Offset: 0x002ED1BC
			public static TonemappingColorGrading.ColorGradingSettings KBINDKOODMK()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = false,
					showDebug = true,
					precision = (TonemappingColorGrading.ColorGradingPrecision)7,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.IAKJOAGBDGO(),
					basics = TonemappingColorGrading.BasicsSettings.FIFAPIHDEBM(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.BCOPOEIJONI(),
					curves = TonemappingColorGrading.CurvesSettings.IHMKIGDJKAH()
				};
			}

			// Token: 0x060085AD RID: 34221 RVA: 0x002EF024 File Offset: 0x002ED224
			public static TonemappingColorGrading.ColorGradingSettings MHIHHBMBDLP()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = true,
					showDebug = true,
					precision = (TonemappingColorGrading.ColorGradingPrecision)(-97),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.MNKGFGNDKED(),
					basics = TonemappingColorGrading.BasicsSettings.EJLLADABOLM(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.IAKJOAGBDGO(),
					curves = TonemappingColorGrading.CurvesSettings.IHMKIGDJKAH()
				};
			}

			// Token: 0x060085AE RID: 34222 RVA: 0x002EF08C File Offset: 0x002ED28C
			public static TonemappingColorGrading.ColorGradingSettings BBPJINDGEEL()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = false,
					showDebug = true,
					precision = (TonemappingColorGrading.ColorGradingPrecision)(-30),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.IHMKIGDJKAH(),
					basics = TonemappingColorGrading.BasicsSettings.GJNKFICGFFG(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.HJLGAPEDPJM(),
					curves = TonemappingColorGrading.CurvesSettings.BCOPOEIJONI()
				};
			}

			// Token: 0x060085AF RID: 34223 RVA: 0x002EEEDF File Offset: 0x002ED0DF
			internal void HBFLDGHLMBJ()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.JCLADKAMOLD();
			}

			// Token: 0x060085B0 RID: 34224 RVA: 0x002EF0F3 File Offset: 0x002ED2F3
			internal void NFMDNEJAGLB()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.EEMMJNPOFOB();
			}

			// Token: 0x060085B1 RID: 34225 RVA: 0x002EF100 File Offset: 0x002ED300
			public static TonemappingColorGrading.ColorGradingSettings AAPGCALKNAK()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = true,
					showDebug = true,
					precision = (TonemappingColorGrading.ColorGradingPrecision)124,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.IHMKIGDJKAH(),
					basics = TonemappingColorGrading.BasicsSettings.DHGILJILMLN(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.AAPGCALKNAK(),
					curves = TonemappingColorGrading.CurvesSettings.BCOPOEIJONI()
				};
			}

			// Token: 0x060085B2 RID: 34226 RVA: 0x002EF167 File Offset: 0x002ED367
			internal void DGNLHKLGAMC()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.INDEHPGLEGK();
			}

			// Token: 0x060085B3 RID: 34227 RVA: 0x002EF174 File Offset: 0x002ED374
			internal void DABMBPBGPPI()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.IHMKIGDJKAH();
			}

			// Token: 0x060085B4 RID: 34228 RVA: 0x002EEEDF File Offset: 0x002ED0DF
			internal void JADEDAEMLBN()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.JCLADKAMOLD();
			}

			// Token: 0x060085B5 RID: 34229 RVA: 0x002EF184 File Offset: 0x002ED384
			public static TonemappingColorGrading.ColorGradingSettings IHMKIGDJKAH()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = true,
					showDebug = false,
					precision = (TonemappingColorGrading.ColorGradingPrecision)107,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.DBDJKKLMCGG(),
					basics = TonemappingColorGrading.BasicsSettings.DBDJKKLMCGG(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.INDEHPGLEGK(),
					curves = TonemappingColorGrading.CurvesSettings.BCOPOEIJONI()
				};
			}

			// Token: 0x060085B6 RID: 34230 RVA: 0x002EF1EC File Offset: 0x002ED3EC
			public static TonemappingColorGrading.ColorGradingSettings NPIEKGGCMBG()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = false,
					showDebug = true,
					precision = (TonemappingColorGrading.ColorGradingPrecision)(-15),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.EJLLADABOLM(),
					basics = TonemappingColorGrading.BasicsSettings.CIHLOMNEHHL(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.LOMOMPKEDPL(),
					curves = TonemappingColorGrading.CurvesSettings.defaultSettings
				};
			}

			// Token: 0x060085B7 RID: 34231 RVA: 0x002EF254 File Offset: 0x002ED454
			public static TonemappingColorGrading.ColorGradingSettings DEOLKOLBAHH()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = false,
					showDebug = true,
					precision = (TonemappingColorGrading.ColorGradingPrecision)85,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.DBDJKKLMCGG(),
					basics = TonemappingColorGrading.BasicsSettings.EEMMJNPOFOB(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.HJLGAPEDPJM(),
					curves = TonemappingColorGrading.CurvesSettings.JCLADKAMOLD()
				};
			}

			// Token: 0x060085B8 RID: 34232 RVA: 0x002EF2BB File Offset: 0x002ED4BB
			internal void AIFAGDOHAGD()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.DFIOJCABPFD();
			}

			// Token: 0x060085B9 RID: 34233 RVA: 0x002EF2C8 File Offset: 0x002ED4C8
			public static TonemappingColorGrading.ColorGradingSettings PJKDCGILBCC()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = true,
					showDebug = false,
					precision = (TonemappingColorGrading.ColorGradingPrecision)(-76),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.MNKGFGNDKED(),
					basics = TonemappingColorGrading.BasicsSettings.MHIHHBMBDLP(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.DFIOJCABPFD(),
					curves = TonemappingColorGrading.CurvesSettings.CCADIDPNEKH()
				};
			}

			// Token: 0x060085BA RID: 34234 RVA: 0x002EEEDF File Offset: 0x002ED0DF
			internal void IJFMKNEPKEJ()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.JCLADKAMOLD();
			}

			// Token: 0x060085BB RID: 34235 RVA: 0x002EF330 File Offset: 0x002ED530
			public static TonemappingColorGrading.ColorGradingSettings BLLCDODHDIL()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = false,
					showDebug = false,
					precision = (TonemappingColorGrading.ColorGradingPrecision)49,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.AAPGCALKNAK(),
					basics = TonemappingColorGrading.BasicsSettings.FPMJKNDJCON(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.JCLADKAMOLD(),
					curves = TonemappingColorGrading.CurvesSettings.INDEHPGLEGK()
				};
			}

			// Token: 0x060085BC RID: 34236 RVA: 0x002EF398 File Offset: 0x002ED598
			public static TonemappingColorGrading.ColorGradingSettings IOJDDHLHPLH()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = true,
					showDebug = true,
					precision = (TonemappingColorGrading.ColorGradingPrecision)(-7),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.BCOPOEIJONI(),
					basics = TonemappingColorGrading.BasicsSettings.NPIEKGGCMBG(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.INDEHPGLEGK(),
					curves = TonemappingColorGrading.CurvesSettings.JCLADKAMOLD()
				};
			}

			// Token: 0x060085BD RID: 34237 RVA: 0x002EF0F3 File Offset: 0x002ED2F3
			internal void ABDHDGNIHHI()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.EEMMJNPOFOB();
			}

			// Token: 0x060085BE RID: 34238 RVA: 0x002EF3FF File Offset: 0x002ED5FF
			internal void GLJIDEPMMFO()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.BCOPOEIJONI();
			}

			// Token: 0x060085BF RID: 34239 RVA: 0x002EF174 File Offset: 0x002ED374
			internal void GOFMABPMLKF()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.IHMKIGDJKAH();
			}

			// Token: 0x060085C0 RID: 34240 RVA: 0x002EF40C File Offset: 0x002ED60C
			internal void BBBNLHALLBN()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.defaultSettings;
			}

			// Token: 0x060085C1 RID: 34241 RVA: 0x002EF41C File Offset: 0x002ED61C
			public static TonemappingColorGrading.ColorGradingSettings DBDJKKLMCGG()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = true,
					showDebug = true,
					precision = (TonemappingColorGrading.ColorGradingPrecision)(-69),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.MNKGFGNDKED(),
					basics = TonemappingColorGrading.BasicsSettings.EEMMJNPOFOB(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.EJLLADABOLM(),
					curves = TonemappingColorGrading.CurvesSettings.DFIOJCABPFD()
				};
			}

			// Token: 0x060085C2 RID: 34242 RVA: 0x002EF483 File Offset: 0x002ED683
			internal void NELFFHHCADM()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.MHIHHBMBDLP();
			}

			// Token: 0x060085C3 RID: 34243 RVA: 0x002EF490 File Offset: 0x002ED690
			public static TonemappingColorGrading.ColorGradingSettings LEAMJGIOPNG()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = false,
					showDebug = true,
					precision = TonemappingColorGrading.ColorGradingPrecision.Normal,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.MNKGFGNDKED(),
					basics = TonemappingColorGrading.BasicsSettings.IOJDDHLHPLH(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.JCLADKAMOLD(),
					curves = TonemappingColorGrading.CurvesSettings.JCLADKAMOLD()
				};
			}

			// Token: 0x060085C4 RID: 34244 RVA: 0x002EF4F7 File Offset: 0x002ED6F7
			internal void JOPOMLLAMKE()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.EJLLADABOLM();
			}

			// Token: 0x060085C5 RID: 34245 RVA: 0x002EF504 File Offset: 0x002ED704
			public static TonemappingColorGrading.ColorGradingSettings ECHEIJELADD()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = false,
					showDebug = true,
					precision = (TonemappingColorGrading.ColorGradingPrecision)(-116),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.NIPPCMNKCMB(),
					basics = TonemappingColorGrading.BasicsSettings.IHMKIGDJKAH(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.LOMOMPKEDPL(),
					curves = TonemappingColorGrading.CurvesSettings.BCOPOEIJONI()
				};
			}

			// Token: 0x060085C6 RID: 34246 RVA: 0x002EF56C File Offset: 0x002ED76C
			public static TonemappingColorGrading.ColorGradingSettings CMOGMEEGGAF()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = true,
					showDebug = false,
					precision = (TonemappingColorGrading.ColorGradingPrecision)75,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.EJLLADABOLM(),
					basics = TonemappingColorGrading.BasicsSettings.INDEHPGLEGK(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.IHMKIGDJKAH(),
					curves = TonemappingColorGrading.CurvesSettings.JCLADKAMOLD()
				};
			}

			// Token: 0x060085C7 RID: 34247 RVA: 0x002EF5D4 File Offset: 0x002ED7D4
			public static TonemappingColorGrading.ColorGradingSettings BFBOLLFFMLN()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = true,
					showDebug = true,
					precision = (TonemappingColorGrading.ColorGradingPrecision)125,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.INDEHPGLEGK(),
					basics = TonemappingColorGrading.BasicsSettings.FCBIDJLDABO(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.EEMMJNPOFOB(),
					curves = TonemappingColorGrading.CurvesSettings.EEMMJNPOFOB()
				};
			}

			// Token: 0x060085C8 RID: 34248 RVA: 0x002EF63C File Offset: 0x002ED83C
			public static TonemappingColorGrading.ColorGradingSettings CHKLMHIHGNN()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = true,
					showDebug = true,
					precision = (TonemappingColorGrading.ColorGradingPrecision)(-97),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.BCOPOEIJONI(),
					basics = TonemappingColorGrading.BasicsSettings.ELOBECLMGDD(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.HJLGAPEDPJM(),
					curves = TonemappingColorGrading.CurvesSettings.MNKGFGNDKED()
				};
			}

			// Token: 0x060085C9 RID: 34249 RVA: 0x002EF6A4 File Offset: 0x002ED8A4
			public static TonemappingColorGrading.ColorGradingSettings BHOPBPABOLG()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = true,
					showDebug = false,
					precision = (TonemappingColorGrading.ColorGradingPrecision)(-7),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.INDEHPGLEGK(),
					basics = TonemappingColorGrading.BasicsSettings.IOJDDHLHPLH(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.CCADIDPNEKH(),
					curves = TonemappingColorGrading.CurvesSettings.IHMKIGDJKAH()
				};
			}

			// Token: 0x060085CA RID: 34250 RVA: 0x002EF167 File Offset: 0x002ED367
			internal void FGAPIOELJCG()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.INDEHPGLEGK();
			}

			// Token: 0x060085CB RID: 34251 RVA: 0x002EF70C File Offset: 0x002ED90C
			public static TonemappingColorGrading.ColorGradingSettings CCADIDPNEKH()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = true,
					showDebug = true,
					precision = (TonemappingColorGrading.ColorGradingPrecision)(-85),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.AAPGCALKNAK(),
					basics = TonemappingColorGrading.BasicsSettings.IAKJOAGBDGO(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.LBIOOILOAAD(),
					curves = TonemappingColorGrading.CurvesSettings.AAPGCALKNAK()
				};
			}

			// Token: 0x060085CC RID: 34252 RVA: 0x002EF774 File Offset: 0x002ED974
			public static TonemappingColorGrading.ColorGradingSettings OFBGNKEDPPK()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = true,
					showDebug = true,
					precision = (TonemappingColorGrading.ColorGradingPrecision)(-35),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.NIPPCMNKCMB(),
					basics = TonemappingColorGrading.BasicsSettings.OIPFKIPOECC(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.IHMKIGDJKAH(),
					curves = TonemappingColorGrading.CurvesSettings.defaultSettings
				};
			}

			// Token: 0x060085CD RID: 34253 RVA: 0x002EF40C File Offset: 0x002ED60C
			internal void FPKJJBAENGF()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.defaultSettings;
			}

			// Token: 0x060085CE RID: 34254 RVA: 0x002EF40C File Offset: 0x002ED60C
			internal void KOBJAEPJJJM()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.defaultSettings;
			}

			// Token: 0x060085CF RID: 34255 RVA: 0x002EF483 File Offset: 0x002ED683
			internal void LHIBPEGLPHM()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.MHIHHBMBDLP();
			}

			// Token: 0x170001AA RID: 426
			// (get) Token: 0x060085D0 RID: 34256 RVA: 0x002EF7DC File Offset: 0x002ED9DC
			public static TonemappingColorGrading.ColorGradingSettings defaultSettings
			{
				get
				{
					return new TonemappingColorGrading.ColorGradingSettings
					{
						enabled = false,
						useDithering = false,
						showDebug = false,
						precision = TonemappingColorGrading.ColorGradingPrecision.Normal,
						colorWheels = TonemappingColorGrading.ColorWheelsSettings.defaultSettings,
						basics = TonemappingColorGrading.BasicsSettings.defaultSettings,
						channelMixer = TonemappingColorGrading.ChannelMixerSettings.defaultSettings,
						curves = TonemappingColorGrading.CurvesSettings.defaultSettings
					};
				}
			}

			// Token: 0x060085D1 RID: 34257 RVA: 0x002EF844 File Offset: 0x002EDA44
			public static TonemappingColorGrading.ColorGradingSettings EDMABHKFEEO()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = false,
					showDebug = true,
					precision = (TonemappingColorGrading.ColorGradingPrecision)22,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.defaultSettings,
					basics = TonemappingColorGrading.BasicsSettings.FPMJKNDJCON(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.JCLADKAMOLD(),
					curves = TonemappingColorGrading.CurvesSettings.IHMKIGDJKAH()
				};
			}

			// Token: 0x060085D2 RID: 34258 RVA: 0x002EF8AB File Offset: 0x002EDAAB
			internal void NBOKAGMABPN()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.AAPGCALKNAK();
			}

			// Token: 0x060085D3 RID: 34259 RVA: 0x002EF2BB File Offset: 0x002ED4BB
			internal void IFGEODOGMHC()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.DFIOJCABPFD();
			}

			// Token: 0x060085D4 RID: 34260 RVA: 0x002EF8B8 File Offset: 0x002EDAB8
			public static TonemappingColorGrading.ColorGradingSettings GJNKFICGFFG()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = true,
					showDebug = false,
					precision = (TonemappingColorGrading.ColorGradingPrecision)102,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.MNKGFGNDKED(),
					basics = TonemappingColorGrading.BasicsSettings.BKEJIPPCPDO(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.DFIOJCABPFD(),
					curves = TonemappingColorGrading.CurvesSettings.AAPGCALKNAK()
				};
			}

			// Token: 0x060085D5 RID: 34261 RVA: 0x002EF920 File Offset: 0x002EDB20
			public static TonemappingColorGrading.ColorGradingSettings HJLGAPEDPJM()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = false,
					showDebug = false,
					precision = (TonemappingColorGrading.ColorGradingPrecision)(-14),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.DBDJKKLMCGG(),
					basics = TonemappingColorGrading.BasicsSettings.AAPGCALKNAK(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.LBIOOILOAAD(),
					curves = TonemappingColorGrading.CurvesSettings.MNKGFGNDKED()
				};
			}

			// Token: 0x060085D6 RID: 34262 RVA: 0x002EF987 File Offset: 0x002EDB87
			internal void IDOFOCOFEIE()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.MNKGFGNDKED();
			}

			// Token: 0x060085D7 RID: 34263 RVA: 0x002EEEDF File Offset: 0x002ED0DF
			internal void CKCPHFLOLAH()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.JCLADKAMOLD();
			}

			// Token: 0x060085D8 RID: 34264 RVA: 0x002EF174 File Offset: 0x002ED374
			internal void HFFAJNCOJNB()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.IHMKIGDJKAH();
			}

			// Token: 0x060085D9 RID: 34265 RVA: 0x002EF994 File Offset: 0x002EDB94
			public static TonemappingColorGrading.ColorGradingSettings DJPGOPCKIJB()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = false,
					showDebug = true,
					precision = (TonemappingColorGrading.ColorGradingPrecision)(-43),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.NIPPCMNKCMB(),
					basics = TonemappingColorGrading.BasicsSettings.NIPPCMNKCMB(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.EJLLADABOLM(),
					curves = TonemappingColorGrading.CurvesSettings.BCOPOEIJONI()
				};
			}

			// Token: 0x060085DA RID: 34266 RVA: 0x002EF2BB File Offset: 0x002ED4BB
			internal void CAPPKCBFILL()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.DFIOJCABPFD();
			}

			// Token: 0x060085DB RID: 34267 RVA: 0x002EF9FC File Offset: 0x002EDBFC
			public static TonemappingColorGrading.ColorGradingSettings FCBIDJLDABO()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = true,
					showDebug = false,
					precision = (TonemappingColorGrading.ColorGradingPrecision)(-119),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.BCOPOEIJONI(),
					basics = TonemappingColorGrading.BasicsSettings.DEOLKOLBAHH(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.JCLADKAMOLD(),
					curves = TonemappingColorGrading.CurvesSettings.MNKGFGNDKED()
				};
			}

			// Token: 0x060085DC RID: 34268 RVA: 0x002EFA64 File Offset: 0x002EDC64
			public static TonemappingColorGrading.ColorGradingSettings EGEEKEIBDGJ()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = true,
					showDebug = false,
					precision = (TonemappingColorGrading.ColorGradingPrecision)13,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.defaultSettings,
					basics = TonemappingColorGrading.BasicsSettings.NCFGPFGLKLJ(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.NIPPCMNKCMB(),
					curves = TonemappingColorGrading.CurvesSettings.AAPGCALKNAK()
				};
			}

			// Token: 0x060085DD RID: 34269 RVA: 0x002EF174 File Offset: 0x002ED374
			internal void LDGJGONCEND()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.IHMKIGDJKAH();
			}

			// Token: 0x060085DE RID: 34270 RVA: 0x002EF174 File Offset: 0x002ED374
			internal void AIEDHEKFPEP()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.IHMKIGDJKAH();
			}

			// Token: 0x060085DF RID: 34271 RVA: 0x002EFACB File Offset: 0x002EDCCB
			internal void MBBHOJMLCBC()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.CCADIDPNEKH();
			}

			// Token: 0x060085E0 RID: 34272 RVA: 0x002EFAD8 File Offset: 0x002EDCD8
			public static TonemappingColorGrading.ColorGradingSettings BKEJIPPCPDO()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = false,
					showDebug = true,
					precision = (TonemappingColorGrading.ColorGradingPrecision)79,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.DFIOJCABPFD(),
					basics = TonemappingColorGrading.BasicsSettings.FMLCJEKMPCN(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.JCLADKAMOLD(),
					curves = TonemappingColorGrading.CurvesSettings.MHIHHBMBDLP()
				};
			}

			// Token: 0x060085E1 RID: 34273 RVA: 0x002EFB40 File Offset: 0x002EDD40
			public static TonemappingColorGrading.ColorGradingSettings GOKMCEIBFIM()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = true,
					showDebug = true,
					precision = (TonemappingColorGrading.ColorGradingPrecision)(-57),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.DBDJKKLMCGG(),
					basics = TonemappingColorGrading.BasicsSettings.LOMOMPKEDPL(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.DFIOJCABPFD(),
					curves = TonemappingColorGrading.CurvesSettings.MHIHHBMBDLP()
				};
			}

			// Token: 0x060085E2 RID: 34274 RVA: 0x002EF483 File Offset: 0x002ED683
			internal void HMBLLAECOIL()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.MHIHHBMBDLP();
			}

			// Token: 0x060085E3 RID: 34275 RVA: 0x002EF174 File Offset: 0x002ED374
			internal void EGFBPCMCNDJ()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.IHMKIGDJKAH();
			}

			// Token: 0x060085E4 RID: 34276 RVA: 0x002EF167 File Offset: 0x002ED367
			internal void GGALLPMKOJI()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.INDEHPGLEGK();
			}

			// Token: 0x060085E5 RID: 34277 RVA: 0x002EFACB File Offset: 0x002EDCCB
			internal void GAOMPMFOJNC()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.CCADIDPNEKH();
			}

			// Token: 0x060085E6 RID: 34278 RVA: 0x002EF40C File Offset: 0x002ED60C
			internal void GGOAHCHPBMJ()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.defaultSettings;
			}

			// Token: 0x060085E7 RID: 34279 RVA: 0x002EF174 File Offset: 0x002ED374
			internal void KMHCLFLINIO()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.IHMKIGDJKAH();
			}

			// Token: 0x060085E8 RID: 34280 RVA: 0x002EF987 File Offset: 0x002EDB87
			internal void BJIKAHNJNEB()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.MNKGFGNDKED();
			}

			// Token: 0x060085E9 RID: 34281 RVA: 0x002EFBA8 File Offset: 0x002EDDA8
			public static TonemappingColorGrading.ColorGradingSettings FMLCJEKMPCN()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = false,
					showDebug = false,
					precision = (TonemappingColorGrading.ColorGradingPrecision)(-13),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.defaultSettings,
					basics = TonemappingColorGrading.BasicsSettings.MLKLBGCKPOO(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.DFIOJCABPFD(),
					curves = TonemappingColorGrading.CurvesSettings.EEMMJNPOFOB()
				};
			}

			// Token: 0x060085EA RID: 34282 RVA: 0x002EF0F3 File Offset: 0x002ED2F3
			internal void OGAMGLEAOAF()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.EEMMJNPOFOB();
			}

			// Token: 0x060085EB RID: 34283 RVA: 0x002EFC10 File Offset: 0x002EDE10
			public static TonemappingColorGrading.ColorGradingSettings KPJJPOBJOFC()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = true,
					useDithering = true,
					showDebug = true,
					precision = (TonemappingColorGrading.ColorGradingPrecision)(-115),
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.EJLLADABOLM(),
					basics = TonemappingColorGrading.BasicsSettings.MLKLBGCKPOO(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.LBIOOILOAAD(),
					curves = TonemappingColorGrading.CurvesSettings.DFIOJCABPFD()
				};
			}

			// Token: 0x060085EC RID: 34284 RVA: 0x002EF174 File Offset: 0x002ED374
			internal void PMLIOODCKDB()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.IHMKIGDJKAH();
			}

			// Token: 0x060085ED RID: 34285 RVA: 0x002EFC78 File Offset: 0x002EDE78
			public static TonemappingColorGrading.ColorGradingSettings IAKJOAGBDGO()
			{
				return new TonemappingColorGrading.ColorGradingSettings
				{
					enabled = false,
					useDithering = true,
					showDebug = false,
					precision = TonemappingColorGrading.ColorGradingPrecision.High,
					colorWheels = TonemappingColorGrading.ColorWheelsSettings.DFIOJCABPFD(),
					basics = TonemappingColorGrading.BasicsSettings.FIPCIMGELME(),
					channelMixer = TonemappingColorGrading.ChannelMixerSettings.CCADIDPNEKH(),
					curves = TonemappingColorGrading.CurvesSettings.BCOPOEIJONI()
				};
			}

			// Token: 0x060085EE RID: 34286 RVA: 0x002EF174 File Offset: 0x002ED374
			internal void GONKPNAAIEE()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.IHMKIGDJKAH();
			}

			// Token: 0x060085EF RID: 34287 RVA: 0x002EEEDF File Offset: 0x002ED0DF
			internal void GGHCBIAEBBH()
			{
				this.curves = TonemappingColorGrading.CurvesSettings.JCLADKAMOLD();
			}

			// Token: 0x04000F75 RID: 3957
			public bool enabled;

			// Token: 0x04000F76 RID: 3958
			[Tooltip("Internal LUT precision. \"Normal\" is 256x16, \"High\" is 1024x32. Prefer \"Normal\" on mobile devices.")]
			public TonemappingColorGrading.ColorGradingPrecision precision;

			// Token: 0x04000F77 RID: 3959
			[Space]
			[TonemappingColorGrading.ColorWheelGroup]
			public TonemappingColorGrading.ColorWheelsSettings colorWheels;

			// Token: 0x04000F78 RID: 3960
			[Space]
			[TonemappingColorGrading.IndentedGroup]
			public TonemappingColorGrading.BasicsSettings basics;

			// Token: 0x04000F79 RID: 3961
			[Space]
			[TonemappingColorGrading.ChannelMixer]
			public TonemappingColorGrading.ChannelMixerSettings channelMixer;

			// Token: 0x04000F7A RID: 3962
			[TonemappingColorGrading.IndentedGroup]
			[Space]
			public TonemappingColorGrading.CurvesSettings curves;

			// Token: 0x04000F7B RID: 3963
			[Tooltip("Use dithering to try and minimize color banding in dark areas.")]
			[Space]
			public bool useDithering;

			// Token: 0x04000F7C RID: 3964
			[Tooltip("Displays the generated LUT in the top left corner of the GameView.")]
			public bool showDebug;
		}

		// Token: 0x02000228 RID: 552
		private enum BKNCMILHPCJ
		{
			// Token: 0x04000F7E RID: 3966
			LutGen,
			// Token: 0x04000F7F RID: 3967
			AdaptationLog,
			// Token: 0x04000F80 RID: 3968
			AdaptationExpBlend,
			// Token: 0x04000F81 RID: 3969
			AdaptationExp,
			// Token: 0x04000F82 RID: 3970
			TonemappingOff,
			// Token: 0x04000F83 RID: 3971
			TonemappingACES,
			// Token: 0x04000F84 RID: 3972
			TonemappingCurve,
			// Token: 0x04000F85 RID: 3973
			TonemappingHable,
			// Token: 0x04000F86 RID: 3974
			TonemappingHejlDawson,
			// Token: 0x04000F87 RID: 3975
			TonemappingPhotographic,
			// Token: 0x04000F88 RID: 3976
			TonemappingReinhard,
			// Token: 0x04000F89 RID: 3977
			TonemappingNeutral,
			// Token: 0x04000F8A RID: 3978
			AdaptationDebug
		}
	}
}
