using System;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x0200019C RID: 412
	[Serializable]
	public class FXAA : IAntiAliasing
	{
		// Token: 0x060075B0 RID: 30128 RVA: 0x0023F902 File Offset: 0x0023DB02
		public void NJHJHBOJKIC()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
		}

		// Token: 0x060075B1 RID: 30129 RVA: 0x0023F920 File Offset: 0x0023DB20
		public bool MDHHNOHIGLM()
		{
			return this.<validSourceFormat>k__BackingField;
		}

		// Token: 0x060075B2 RID: 30130 RVA: 0x0023F928 File Offset: 0x0023DB28
		private void JIHNJJBJPCP(bool DPNHODJHGJL)
		{
			this.<validSourceFormat>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x060075B3 RID: 30131 RVA: 0x0002523B File Offset: 0x0002343B
		public void PCNEANMHFFF(Camera CPHDLGANKHG)
		{
		}

		// Token: 0x060075B4 RID: 30132 RVA: 0x0002523B File Offset: 0x0002343B
		public void OnPostRender(Camera CPHDLGANKHG)
		{
		}

		// Token: 0x060075B5 RID: 30133 RVA: 0x0002523B File Offset: 0x0002343B
		public void OnPreCull(Camera CPHDLGANKHG)
		{
		}

		// Token: 0x060075B6 RID: 30134 RVA: 0x0023F931 File Offset: 0x0023DB31
		public Material LNLKMDPHDCC()
		{
			if (this.m_Material == null)
			{
				this.m_Material = ImageEffectHelper.CheckShaderAndCreateMaterial(this.FMOMOEOJFKH());
			}
			return this.m_Material;
		}

		// Token: 0x060075B7 RID: 30135 RVA: 0x0023F95C File Offset: 0x0023DB5C
		public void JJCEACGCOHB(Camera CPHDLGANKHG, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.LNLKMDPHDCC().SetVector("CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", new Vector3(this.preset.qualitySettings.subpixelAliasingRemovalAmount, this.preset.qualitySettings.edgeDetectionThreshold, this.preset.qualitySettings.minimumRequiredLuminance));
			this.KAFBNOBOIAJ().SetVector("maps.", new Vector4(this.preset.consoleSettings.subpixelSpreadAmount, this.preset.consoleSettings.edgeSharpnessAmount, this.preset.consoleSettings.edgeDetectionThreshold, this.preset.consoleSettings.minimumRequiredLuminance));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.material, 0);
		}

		// Token: 0x060075B8 RID: 30136 RVA: 0x0023FA18 File Offset: 0x0023DC18
		public void KEFKNAOGCHO(Camera CPHDLGANKHG, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.LNLKMDPHDCC().SetVector("_DiffuseColor", new Vector3(this.preset.qualitySettings.subpixelAliasingRemovalAmount, this.preset.qualitySettings.edgeDetectionThreshold, this.preset.qualitySettings.minimumRequiredLuminance));
			this.KAFBNOBOIAJ().SetVector(". The group number should be at least 1.", new Vector4(this.preset.consoleSettings.subpixelSpreadAmount, this.preset.consoleSettings.edgeSharpnessAmount, this.preset.consoleSettings.edgeDetectionThreshold, this.preset.consoleSettings.minimumRequiredLuminance));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KAFBNOBOIAJ(), 0);
		}

		// Token: 0x060075B9 RID: 30137 RVA: 0x0023F920 File Offset: 0x0023DB20
		public bool NDJDLDBDMOM()
		{
			return this.<validSourceFormat>k__BackingField;
		}

		// Token: 0x060075BA RID: 30138 RVA: 0x0023FAD2 File Offset: 0x0023DCD2
		public void LLAJPKFNDIG(AntiAliasing DNFGMNFCBGA)
		{
			if (!ImageEffectHelper.IsSupported(this.BNHIJFAKEIM(), true, false, DNFGMNFCBGA))
			{
				DNFGMNFCBGA.enabled = true;
			}
		}

		// Token: 0x060075BB RID: 30139 RVA: 0x0023FAF0 File Offset: 0x0023DCF0
		public void KDFILLAPHIO(Camera CPHDLGANKHG, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.material.SetVector("settings.shaders", new Vector3(this.preset.qualitySettings.subpixelAliasingRemovalAmount, this.preset.qualitySettings.edgeDetectionThreshold, this.preset.qualitySettings.minimumRequiredLuminance));
			this.KAFBNOBOIAJ().SetVector("_ScreenResolution", new Vector4(this.preset.consoleSettings.subpixelSpreadAmount, this.preset.consoleSettings.edgeSharpnessAmount, this.preset.consoleSettings.edgeDetectionThreshold, this.preset.consoleSettings.minimumRequiredLuminance));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KAFBNOBOIAJ(), 1);
		}

		// Token: 0x060075BC RID: 30140 RVA: 0x0023F928 File Offset: 0x0023DB28
		private void INHPGDFJKHC(bool DPNHODJHGJL)
		{
			this.<validSourceFormat>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060075BD RID: 30141 RVA: 0x0023FBAA File Offset: 0x0023DDAA
		private Shader shader
		{
			get
			{
				if (this.m_Shader == null)
				{
					this.m_Shader = Shader.Find("Hidden/Fast Approximate Anti-aliasing");
				}
				return this.m_Shader;
			}
		}

		// Token: 0x060075BE RID: 30142 RVA: 0x0023F902 File Offset: 0x0023DB02
		public void OnDisable()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
		}

		// Token: 0x060075BF RID: 30143 RVA: 0x0023F920 File Offset: 0x0023DB20
		public bool JDCBOEAKDGA()
		{
			return this.<validSourceFormat>k__BackingField;
		}

		// Token: 0x060075C0 RID: 30144 RVA: 0x0023FBD3 File Offset: 0x0023DDD3
		public void EBBOJPEPDCN(AntiAliasing DNFGMNFCBGA)
		{
			if (!ImageEffectHelper.IsSupported(this.FMOMOEOJFKH(), false, false, DNFGMNFCBGA))
			{
				DNFGMNFCBGA.enabled = true;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060075C1 RID: 30145 RVA: 0x0023F920 File Offset: 0x0023DB20
		// (set) Token: 0x060075D3 RID: 30163 RVA: 0x0023F928 File Offset: 0x0023DB28
		public bool validSourceFormat { get; private set; }

		// Token: 0x060075C2 RID: 30146 RVA: 0x0023F928 File Offset: 0x0023DB28
		private void PDNDHOCHKCK(bool DPNHODJHGJL)
		{
			this.<validSourceFormat>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x060075C3 RID: 30147 RVA: 0x0023F920 File Offset: 0x0023DB20
		public bool KFOGLGNNAFM()
		{
			return this.<validSourceFormat>k__BackingField;
		}

		// Token: 0x060075C4 RID: 30148 RVA: 0x0023FBF0 File Offset: 0x0023DDF0
		public void OnRenderImage(Camera CPHDLGANKHG, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.material.SetVector("_QualitySettings", new Vector3(this.preset.qualitySettings.subpixelAliasingRemovalAmount, this.preset.qualitySettings.edgeDetectionThreshold, this.preset.qualitySettings.minimumRequiredLuminance));
			this.material.SetVector("_ConsoleSettings", new Vector4(this.preset.consoleSettings.subpixelSpreadAmount, this.preset.consoleSettings.edgeSharpnessAmount, this.preset.consoleSettings.edgeDetectionThreshold, this.preset.consoleSettings.minimumRequiredLuminance));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.material, 0);
		}

		// Token: 0x060075C5 RID: 30149 RVA: 0x0023F928 File Offset: 0x0023DB28
		private void NHAIKKJGINC(bool DPNHODJHGJL)
		{
			this.<validSourceFormat>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x060075C6 RID: 30150 RVA: 0x0023F920 File Offset: 0x0023DB20
		public bool GGLILJMEMJG()
		{
			return this.<validSourceFormat>k__BackingField;
		}

		// Token: 0x060075C7 RID: 30151 RVA: 0x0002523B File Offset: 0x0002343B
		public void EDGLMALMGDJ(Camera CPHDLGANKHG)
		{
		}

		// Token: 0x060075C8 RID: 30152 RVA: 0x0023FCAA File Offset: 0x0023DEAA
		public Material KAFBNOBOIAJ()
		{
			if (this.m_Material == null)
			{
				this.m_Material = ImageEffectHelper.CheckShaderAndCreateMaterial(this.BNHIJFAKEIM());
			}
			return this.m_Material;
		}

		// Token: 0x060075C9 RID: 30153 RVA: 0x0023FCD4 File Offset: 0x0023DED4
		private Shader KHFBDENANNP()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_VelocityScale");
			}
			return this.m_Shader;
		}

		// Token: 0x060075CB RID: 30155 RVA: 0x0002523B File Offset: 0x0002343B
		public void NOHLBIOEIDG(Camera CPHDLGANKHG)
		{
		}

		// Token: 0x060075CC RID: 30156 RVA: 0x0023F928 File Offset: 0x0023DB28
		private void LFNBHOABHCK(bool DPNHODJHGJL)
		{
			this.<validSourceFormat>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x060075CD RID: 30157 RVA: 0x0023F920 File Offset: 0x0023DB20
		public bool NDIACBPAGFF()
		{
			return this.<validSourceFormat>k__BackingField;
		}

		// Token: 0x060075CE RID: 30158 RVA: 0x0023F920 File Offset: 0x0023DB20
		public bool DLLMEBJCAHC()
		{
			return this.<validSourceFormat>k__BackingField;
		}

		// Token: 0x060075CF RID: 30159 RVA: 0x0023FD6D File Offset: 0x0023DF6D
		public void PAHNKEGFGHB(AntiAliasing DNFGMNFCBGA)
		{
			if (!ImageEffectHelper.IsSupported(this.shader, false, false, DNFGMNFCBGA))
			{
				DNFGMNFCBGA.enabled = false;
			}
		}

		// Token: 0x060075D0 RID: 30160 RVA: 0x0023F902 File Offset: 0x0023DB02
		public void DLMPALHKMON()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
		}

		// Token: 0x060075D1 RID: 30161 RVA: 0x0002523B File Offset: 0x0002343B
		public void JFKLGLFFIGA(Camera CPHDLGANKHG)
		{
		}

		// Token: 0x060075D2 RID: 30162 RVA: 0x0023FD89 File Offset: 0x0023DF89
		public void LHGFCBDACBM(AntiAliasing DNFGMNFCBGA)
		{
			if (!ImageEffectHelper.IsSupported(this.shader, true, true, DNFGMNFCBGA))
			{
				DNFGMNFCBGA.enabled = false;
			}
		}

		// Token: 0x060075D4 RID: 30164 RVA: 0x0023FDA5 File Offset: 0x0023DFA5
		public void HGIMCCHIPCP(AntiAliasing DNFGMNFCBGA)
		{
			if (!ImageEffectHelper.IsSupported(this.KHFBDENANNP(), true, false, DNFGMNFCBGA))
			{
				DNFGMNFCBGA.enabled = false;
			}
		}

		// Token: 0x060075D5 RID: 30165 RVA: 0x0002523B File Offset: 0x0002343B
		public void PEDFHDDKILA(Camera CPHDLGANKHG)
		{
		}

		// Token: 0x060075D6 RID: 30166 RVA: 0x0023FDC1 File Offset: 0x0023DFC1
		private Shader BNHIJFAKEIM()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_MainTex2");
			}
			return this.m_Shader;
		}

		// Token: 0x060075D7 RID: 30167 RVA: 0x0023FDEA File Offset: 0x0023DFEA
		public void JBBCMAJIMCA(AntiAliasing DNFGMNFCBGA)
		{
			if (!ImageEffectHelper.IsSupported(this.KHFBDENANNP(), true, false, DNFGMNFCBGA))
			{
				DNFGMNFCBGA.enabled = true;
			}
		}

		// Token: 0x060075D8 RID: 30168 RVA: 0x0002523B File Offset: 0x0002343B
		public void ECDKGJNEJEK(Camera CPHDLGANKHG)
		{
		}

		// Token: 0x060075D9 RID: 30169 RVA: 0x0023F928 File Offset: 0x0023DB28
		private void CJKIDFFMEOF(bool DPNHODJHGJL)
		{
			this.<validSourceFormat>k__BackingField = DPNHODJHGJL;
		}

		// Token: 0x060075DB RID: 30171 RVA: 0x0023FE19 File Offset: 0x0023E019
		public void GFLAINNLMBO(AntiAliasing DNFGMNFCBGA)
		{
			if (!ImageEffectHelper.IsSupported(this.FMOMOEOJFKH(), false, true, DNFGMNFCBGA))
			{
				DNFGMNFCBGA.enabled = true;
			}
		}

		// Token: 0x060075DC RID: 30172 RVA: 0x0023FE38 File Offset: 0x0023E038
		public void KCFHGGCIDNE(Camera CPHDLGANKHG, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.KAFBNOBOIAJ().SetVector("Joystick1Button8", new Vector3(this.preset.qualitySettings.subpixelAliasingRemovalAmount, this.preset.qualitySettings.edgeDetectionThreshold, this.preset.qualitySettings.minimumRequiredLuminance));
			this.KAFBNOBOIAJ().SetVector("Down", new Vector4(this.preset.consoleSettings.subpixelSpreadAmount, this.preset.consoleSettings.edgeSharpnessAmount, this.preset.consoleSettings.edgeDetectionThreshold, this.preset.consoleSettings.minimumRequiredLuminance));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LNLKMDPHDCC(), 1);
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060075DD RID: 30173 RVA: 0x0023FEF2 File Offset: 0x0023E0F2
		public Material material
		{
			get
			{
				if (this.m_Material == null)
				{
					this.m_Material = ImageEffectHelper.CheckShaderAndCreateMaterial(this.shader);
				}
				return this.m_Material;
			}
		}

		// Token: 0x060075DE RID: 30174 RVA: 0x0002523B File Offset: 0x0002343B
		public void AHODFNEEDEE(Camera CPHDLGANKHG)
		{
		}

		// Token: 0x060075DF RID: 30175 RVA: 0x0002523B File Offset: 0x0002343B
		public void HEBOJHKKKMP(Camera CPHDLGANKHG)
		{
		}

		// Token: 0x060075E0 RID: 30176 RVA: 0x0023FF1C File Offset: 0x0023E11C
		public void LPFDJPCIADE(Camera CPHDLGANKHG, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			this.KAFBNOBOIAJ().SetVector("SetSpeed", new Vector3(this.preset.qualitySettings.subpixelAliasingRemovalAmount, this.preset.qualitySettings.edgeDetectionThreshold, this.preset.qualitySettings.minimumRequiredLuminance));
			this.KAFBNOBOIAJ().SetVector("-1", new Vector4(this.preset.consoleSettings.subpixelSpreadAmount, this.preset.consoleSettings.edgeSharpnessAmount, this.preset.consoleSettings.edgeDetectionThreshold, this.preset.consoleSettings.minimumRequiredLuminance));
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KAFBNOBOIAJ(), 0);
		}

		// Token: 0x060075E1 RID: 30177 RVA: 0x0023FFD6 File Offset: 0x0023E1D6
		private Shader FMOMOEOJFKH()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_ScreenResolution");
			}
			return this.m_Shader;
		}

		// Token: 0x060075E2 RID: 30178 RVA: 0x0002523B File Offset: 0x0002343B
		public void BOLKEMBOCMO(Camera CPHDLGANKHG)
		{
		}

		// Token: 0x060075E3 RID: 30179 RVA: 0x0023FFFF File Offset: 0x0023E1FF
		public void OnEnable(AntiAliasing DNFGMNFCBGA)
		{
			if (!ImageEffectHelper.IsSupported(this.shader, true, false, DNFGMNFCBGA))
			{
				DNFGMNFCBGA.enabled = false;
			}
		}

		// Token: 0x060075E4 RID: 30180 RVA: 0x0024001B File Offset: 0x0023E21B
		public void LLDBPKHDPKI(AntiAliasing DNFGMNFCBGA)
		{
			if (!ImageEffectHelper.IsSupported(this.shader, false, true, DNFGMNFCBGA))
			{
				DNFGMNFCBGA.enabled = true;
			}
		}

		// Token: 0x060075E5 RID: 30181 RVA: 0x0023F920 File Offset: 0x0023DB20
		public bool PPCLECJHDLK()
		{
			return this.<validSourceFormat>k__BackingField;
		}

		// Token: 0x04000C03 RID: 3075
		private Shader m_Shader;

		// Token: 0x04000C04 RID: 3076
		private Material m_Material;

		// Token: 0x04000C05 RID: 3077
		[SerializeField]
		[HideInInspector]
		public FXAA.Preset preset = FXAA.Preset.defaultPreset;

		// Token: 0x04000C06 RID: 3078
		public static FXAA.Preset[] availablePresets = new FXAA.Preset[]
		{
			FXAA.Preset.extremePerformancePreset,
			FXAA.Preset.performancePreset,
			FXAA.Preset.defaultPreset,
			FXAA.Preset.qualityPreset,
			FXAA.Preset.extremeQualityPreset
		};

		// Token: 0x0200019D RID: 413
		[Serializable]
		public struct QualitySettings
		{
			// Token: 0x04000C08 RID: 3080
			[Tooltip("The amount of desired sub-pixel aliasing removal. Effects the sharpeness of the output.")]
			[Range(0f, 1f)]
			public float subpixelAliasingRemovalAmount;

			// Token: 0x04000C09 RID: 3081
			[Range(0.063f, 0.333f)]
			[Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
			public float edgeDetectionThreshold;

			// Token: 0x04000C0A RID: 3082
			[Range(0f, 0.0833f)]
			[Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
			public float minimumRequiredLuminance;
		}

		// Token: 0x0200019E RID: 414
		[Serializable]
		public struct ConsoleSettings
		{
			// Token: 0x04000C0B RID: 3083
			[Tooltip("The amount of spread applied to the sampling coordinates while sampling for subpixel information.")]
			[Range(0.33f, 0.5f)]
			public float subpixelSpreadAmount;

			// Token: 0x04000C0C RID: 3084
			[Tooltip("This value dictates how sharp the edges in the image are kept; a higher value implies sharper edges.")]
			[Range(2f, 8f)]
			public float edgeSharpnessAmount;

			// Token: 0x04000C0D RID: 3085
			[Range(0.125f, 0.25f)]
			[Tooltip("The minimum amount of local contrast required to qualify a region as containing an edge.")]
			public float edgeDetectionThreshold;

			// Token: 0x04000C0E RID: 3086
			[Tooltip("Local contrast adaptation value to disallow the algorithm from executing on the darker regions.")]
			[Range(0.04f, 0.06f)]
			public float minimumRequiredLuminance;
		}

		// Token: 0x0200019F RID: 415
		[Serializable]
		public struct Preset
		{
			// Token: 0x060075E6 RID: 30182 RVA: 0x00240037 File Offset: 0x0023E237
			public static FXAA.Preset NKDNPMMJAEN()
			{
				return FXAA.Preset.s_Quality;
			}

			// Token: 0x060075E7 RID: 30183 RVA: 0x0024003E File Offset: 0x0023E23E
			public static FXAA.Preset ICPCDFGILLA()
			{
				return FXAA.Preset.s_Default;
			}

			// Token: 0x060075E8 RID: 30184 RVA: 0x00240037 File Offset: 0x0023E237
			public static FXAA.Preset FFDCKIMDKDD()
			{
				return FXAA.Preset.s_Quality;
			}

			// Token: 0x060075E9 RID: 30185 RVA: 0x00240037 File Offset: 0x0023E237
			public static FXAA.Preset ABJLPOJBALF()
			{
				return FXAA.Preset.s_Quality;
			}

			// Token: 0x060075EA RID: 30186 RVA: 0x00240045 File Offset: 0x0023E245
			public static FXAA.Preset LLADPKICBIO()
			{
				return FXAA.Preset.s_ExtremePerformance;
			}

			// Token: 0x060075EB RID: 30187 RVA: 0x00240045 File Offset: 0x0023E245
			public static FXAA.Preset BKKIEMMFCLG()
			{
				return FXAA.Preset.s_ExtremePerformance;
			}

			// Token: 0x060075EC RID: 30188 RVA: 0x00240037 File Offset: 0x0023E237
			public static FXAA.Preset KNDOFBPKKPO()
			{
				return FXAA.Preset.s_Quality;
			}

			// Token: 0x060075ED RID: 30189 RVA: 0x00240037 File Offset: 0x0023E237
			public static FXAA.Preset HNEDBAPKJOB()
			{
				return FXAA.Preset.s_Quality;
			}

			// Token: 0x060075EE RID: 30190 RVA: 0x00240045 File Offset: 0x0023E245
			public static FXAA.Preset FMPFFJEGJNM()
			{
				return FXAA.Preset.s_ExtremePerformance;
			}

			// Token: 0x060075EF RID: 30191 RVA: 0x0024004C File Offset: 0x0023E24C
			public static FXAA.Preset COOPEFGNOCD()
			{
				return FXAA.Preset.s_Performance;
			}

			// Token: 0x17000167 RID: 359
			// (get) Token: 0x060075F0 RID: 30192 RVA: 0x00240037 File Offset: 0x0023E237
			public static FXAA.Preset qualityPreset
			{
				get
				{
					return FXAA.Preset.s_Quality;
				}
			}

			// Token: 0x060075F1 RID: 30193 RVA: 0x00240045 File Offset: 0x0023E245
			public static FXAA.Preset GHDNHKEHDEN()
			{
				return FXAA.Preset.s_ExtremePerformance;
			}

			// Token: 0x060075F2 RID: 30194 RVA: 0x0024003E File Offset: 0x0023E23E
			public static FXAA.Preset CCNFOOMDNCL()
			{
				return FXAA.Preset.s_Default;
			}

			// Token: 0x060075F3 RID: 30195 RVA: 0x00240045 File Offset: 0x0023E245
			public static FXAA.Preset BPFKLECBEOP()
			{
				return FXAA.Preset.s_ExtremePerformance;
			}

			// Token: 0x17000166 RID: 358
			// (get) Token: 0x060075F4 RID: 30196 RVA: 0x0024003E File Offset: 0x0023E23E
			public static FXAA.Preset defaultPreset
			{
				get
				{
					return FXAA.Preset.s_Default;
				}
			}

			// Token: 0x060075F5 RID: 30197 RVA: 0x00240053 File Offset: 0x0023E253
			public static FXAA.Preset JBGLDCDHNPH()
			{
				return FXAA.Preset.s_ExtremeQuality;
			}

			// Token: 0x060075F6 RID: 30198 RVA: 0x00240053 File Offset: 0x0023E253
			public static FXAA.Preset NHEPEAJKOGP()
			{
				return FXAA.Preset.s_ExtremeQuality;
			}

			// Token: 0x060075F7 RID: 30199 RVA: 0x00240037 File Offset: 0x0023E237
			public static FXAA.Preset JNGAHPAMJHP()
			{
				return FXAA.Preset.s_Quality;
			}

			// Token: 0x060075F8 RID: 30200 RVA: 0x00240053 File Offset: 0x0023E253
			public static FXAA.Preset HDJGAJGPLIO()
			{
				return FXAA.Preset.s_ExtremeQuality;
			}

			// Token: 0x060075F9 RID: 30201 RVA: 0x00240053 File Offset: 0x0023E253
			public static FXAA.Preset GALINMBNLCF()
			{
				return FXAA.Preset.s_ExtremeQuality;
			}

			// Token: 0x060075FA RID: 30202 RVA: 0x0024003E File Offset: 0x0023E23E
			public static FXAA.Preset EBOJBFKNNAL()
			{
				return FXAA.Preset.s_Default;
			}

			// Token: 0x060075FB RID: 30203 RVA: 0x0024004C File Offset: 0x0023E24C
			public static FXAA.Preset HJOBDAJJHOM()
			{
				return FXAA.Preset.s_Performance;
			}

			// Token: 0x060075FC RID: 30204 RVA: 0x00240037 File Offset: 0x0023E237
			public static FXAA.Preset MBLKHPGCOPM()
			{
				return FXAA.Preset.s_Quality;
			}

			// Token: 0x060075FD RID: 30205 RVA: 0x00240053 File Offset: 0x0023E253
			public static FXAA.Preset BDLMHGKGNHC()
			{
				return FXAA.Preset.s_ExtremeQuality;
			}

			// Token: 0x060075FE RID: 30206 RVA: 0x00240045 File Offset: 0x0023E245
			public static FXAA.Preset PBAOMMFJCLJ()
			{
				return FXAA.Preset.s_ExtremePerformance;
			}

			// Token: 0x060075FF RID: 30207 RVA: 0x00240053 File Offset: 0x0023E253
			public static FXAA.Preset PBKCCMCLFMI()
			{
				return FXAA.Preset.s_ExtremeQuality;
			}

			// Token: 0x06007600 RID: 30208 RVA: 0x0024003E File Offset: 0x0023E23E
			public static FXAA.Preset NNJEKNMJFHO()
			{
				return FXAA.Preset.s_Default;
			}

			// Token: 0x06007601 RID: 30209 RVA: 0x00240037 File Offset: 0x0023E237
			public static FXAA.Preset LHIIOMBIFIB()
			{
				return FXAA.Preset.s_Quality;
			}

			// Token: 0x06007602 RID: 30210 RVA: 0x00240045 File Offset: 0x0023E245
			public static FXAA.Preset POADEMIFKOA()
			{
				return FXAA.Preset.s_ExtremePerformance;
			}

			// Token: 0x06007604 RID: 30212 RVA: 0x00240053 File Offset: 0x0023E253
			public static FXAA.Preset GOKHLAHKBGK()
			{
				return FXAA.Preset.s_ExtremeQuality;
			}

			// Token: 0x06007605 RID: 30213 RVA: 0x00240053 File Offset: 0x0023E253
			public static FXAA.Preset IJJAOPMBIFE()
			{
				return FXAA.Preset.s_ExtremeQuality;
			}

			// Token: 0x06007606 RID: 30214 RVA: 0x0024003E File Offset: 0x0023E23E
			public static FXAA.Preset JJKNHAHJPNB()
			{
				return FXAA.Preset.s_Default;
			}

			// Token: 0x06007607 RID: 30215 RVA: 0x00240037 File Offset: 0x0023E237
			public static FXAA.Preset GOJMGGMONOB()
			{
				return FXAA.Preset.s_Quality;
			}

			// Token: 0x06007608 RID: 30216 RVA: 0x0024004C File Offset: 0x0023E24C
			public static FXAA.Preset NGGEDLJPBGD()
			{
				return FXAA.Preset.s_Performance;
			}

			// Token: 0x17000164 RID: 356
			// (get) Token: 0x06007609 RID: 30217 RVA: 0x00240045 File Offset: 0x0023E245
			public static FXAA.Preset extremePerformancePreset
			{
				get
				{
					return FXAA.Preset.s_ExtremePerformance;
				}
			}

			// Token: 0x0600760A RID: 30218 RVA: 0x00240045 File Offset: 0x0023E245
			public static FXAA.Preset KIKGADMKHNC()
			{
				return FXAA.Preset.s_ExtremePerformance;
			}

			// Token: 0x0600760B RID: 30219 RVA: 0x0024003E File Offset: 0x0023E23E
			public static FXAA.Preset NHDNNBALFJF()
			{
				return FXAA.Preset.s_Default;
			}

			// Token: 0x17000165 RID: 357
			// (get) Token: 0x0600760C RID: 30220 RVA: 0x0024004C File Offset: 0x0023E24C
			public static FXAA.Preset performancePreset
			{
				get
				{
					return FXAA.Preset.s_Performance;
				}
			}

			// Token: 0x0600760D RID: 30221 RVA: 0x00240053 File Offset: 0x0023E253
			public static FXAA.Preset GGJKJFMCOKL()
			{
				return FXAA.Preset.s_ExtremeQuality;
			}

			// Token: 0x0600760E RID: 30222 RVA: 0x00240037 File Offset: 0x0023E237
			public static FXAA.Preset DDCEIIFDMHB()
			{
				return FXAA.Preset.s_Quality;
			}

			// Token: 0x0600760F RID: 30223 RVA: 0x0024004C File Offset: 0x0023E24C
			public static FXAA.Preset LIFCDDKBJCM()
			{
				return FXAA.Preset.s_Performance;
			}

			// Token: 0x06007610 RID: 30224 RVA: 0x0024004C File Offset: 0x0023E24C
			public static FXAA.Preset ODDOKBLBANI()
			{
				return FXAA.Preset.s_Performance;
			}

			// Token: 0x06007611 RID: 30225 RVA: 0x00240037 File Offset: 0x0023E237
			public static FXAA.Preset LOLGMIOMEGH()
			{
				return FXAA.Preset.s_Quality;
			}

			// Token: 0x06007612 RID: 30226 RVA: 0x0024003E File Offset: 0x0023E23E
			public static FXAA.Preset ICEGIABCDMN()
			{
				return FXAA.Preset.s_Default;
			}

			// Token: 0x06007613 RID: 30227 RVA: 0x00240053 File Offset: 0x0023E253
			public static FXAA.Preset MKCNNKEPKGF()
			{
				return FXAA.Preset.s_ExtremeQuality;
			}

			// Token: 0x06007614 RID: 30228 RVA: 0x00240045 File Offset: 0x0023E245
			public static FXAA.Preset NHMIGAPHEHL()
			{
				return FXAA.Preset.s_ExtremePerformance;
			}

			// Token: 0x06007615 RID: 30229 RVA: 0x00240053 File Offset: 0x0023E253
			public static FXAA.Preset EDPHBLHFHLB()
			{
				return FXAA.Preset.s_ExtremeQuality;
			}

			// Token: 0x17000168 RID: 360
			// (get) Token: 0x06007616 RID: 30230 RVA: 0x00240053 File Offset: 0x0023E253
			public static FXAA.Preset extremeQualityPreset
			{
				get
				{
					return FXAA.Preset.s_ExtremeQuality;
				}
			}

			// Token: 0x06007617 RID: 30231 RVA: 0x00240045 File Offset: 0x0023E245
			public static FXAA.Preset DKGHGCILKJL()
			{
				return FXAA.Preset.s_ExtremePerformance;
			}

			// Token: 0x06007618 RID: 30232 RVA: 0x00240045 File Offset: 0x0023E245
			public static FXAA.Preset FFOPECFFDCG()
			{
				return FXAA.Preset.s_ExtremePerformance;
			}

			// Token: 0x06007619 RID: 30233 RVA: 0x00240037 File Offset: 0x0023E237
			public static FXAA.Preset OOFEBDNMFFE()
			{
				return FXAA.Preset.s_Quality;
			}

			// Token: 0x0600761A RID: 30234 RVA: 0x00240037 File Offset: 0x0023E237
			public static FXAA.Preset OGMICPPGLBE()
			{
				return FXAA.Preset.s_Quality;
			}

			// Token: 0x0600761B RID: 30235 RVA: 0x00240045 File Offset: 0x0023E245
			public static FXAA.Preset AOMBPCBMJCH()
			{
				return FXAA.Preset.s_ExtremePerformance;
			}

			// Token: 0x0600761C RID: 30236 RVA: 0x0024004C File Offset: 0x0023E24C
			public static FXAA.Preset IFAJGMBNPLO()
			{
				return FXAA.Preset.s_Performance;
			}

			// Token: 0x04000C0F RID: 3087
			[FXAA.Preset.LayoutAttribute]
			public FXAA.QualitySettings qualitySettings;

			// Token: 0x04000C10 RID: 3088
			[FXAA.Preset.LayoutAttribute]
			public FXAA.ConsoleSettings consoleSettings;

			// Token: 0x04000C11 RID: 3089
			private static readonly FXAA.Preset s_ExtremePerformance = new FXAA.Preset
			{
				qualitySettings = new FXAA.QualitySettings
				{
					subpixelAliasingRemovalAmount = 0f,
					edgeDetectionThreshold = 0.333f,
					minimumRequiredLuminance = 0.0833f
				},
				consoleSettings = new FXAA.ConsoleSettings
				{
					subpixelSpreadAmount = 0.33f,
					edgeSharpnessAmount = 8f,
					edgeDetectionThreshold = 0.25f,
					minimumRequiredLuminance = 0.06f
				}
			};

			// Token: 0x04000C12 RID: 3090
			private static readonly FXAA.Preset s_Performance = new FXAA.Preset
			{
				qualitySettings = new FXAA.QualitySettings
				{
					subpixelAliasingRemovalAmount = 0.25f,
					edgeDetectionThreshold = 0.25f,
					minimumRequiredLuminance = 0.0833f
				},
				consoleSettings = new FXAA.ConsoleSettings
				{
					subpixelSpreadAmount = 0.33f,
					edgeSharpnessAmount = 8f,
					edgeDetectionThreshold = 0.125f,
					minimumRequiredLuminance = 0.06f
				}
			};

			// Token: 0x04000C13 RID: 3091
			private static readonly FXAA.Preset s_Default = new FXAA.Preset
			{
				qualitySettings = new FXAA.QualitySettings
				{
					subpixelAliasingRemovalAmount = 0.75f,
					edgeDetectionThreshold = 0.166f,
					minimumRequiredLuminance = 0.0833f
				},
				consoleSettings = new FXAA.ConsoleSettings
				{
					subpixelSpreadAmount = 0.5f,
					edgeSharpnessAmount = 8f,
					edgeDetectionThreshold = 0.125f,
					minimumRequiredLuminance = 0.05f
				}
			};

			// Token: 0x04000C14 RID: 3092
			private static readonly FXAA.Preset s_Quality = new FXAA.Preset
			{
				qualitySettings = new FXAA.QualitySettings
				{
					subpixelAliasingRemovalAmount = 1f,
					edgeDetectionThreshold = 0.125f,
					minimumRequiredLuminance = 0.0625f
				},
				consoleSettings = new FXAA.ConsoleSettings
				{
					subpixelSpreadAmount = 0.5f,
					edgeSharpnessAmount = 4f,
					edgeDetectionThreshold = 0.125f,
					minimumRequiredLuminance = 0.04f
				}
			};

			// Token: 0x04000C15 RID: 3093
			private static readonly FXAA.Preset s_ExtremeQuality = new FXAA.Preset
			{
				qualitySettings = new FXAA.QualitySettings
				{
					subpixelAliasingRemovalAmount = 1f,
					edgeDetectionThreshold = 0.063f,
					minimumRequiredLuminance = 0.0312f
				},
				consoleSettings = new FXAA.ConsoleSettings
				{
					subpixelSpreadAmount = 0.5f,
					edgeSharpnessAmount = 2f,
					edgeDetectionThreshold = 0.125f,
					minimumRequiredLuminance = 0.04f
				}
			};

			// Token: 0x020001A0 RID: 416
			[AttributeUsage(AttributeTargets.Field)]
			public class LayoutAttribute : PropertyAttribute
			{
			}
		}
	}
}
