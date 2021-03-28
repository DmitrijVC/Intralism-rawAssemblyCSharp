using System;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x020001A2 RID: 418
	[Serializable]
	public class SMAA : IAntiAliasing
	{
		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06007623 RID: 30243 RVA: 0x00240306 File Offset: 0x0023E506
		private Texture2D searchTexture
		{
			get
			{
				if (this.m_SearchTexture == null)
				{
					this.m_SearchTexture = Resources.Load<Texture2D>("SearchTex");
				}
				return this.m_SearchTexture;
			}
		}

		// Token: 0x06007624 RID: 30244 RVA: 0x00240330 File Offset: 0x0023E530
		private RenderTexture DGEILEMBGNA(int CJDDBGPKDLP, int PBMAGEKDPLI, RenderTextureFormat LGLMKIPIIHO)
		{
			int depthBuffer = 0;
			return RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, depthBuffer, LGLMKIPIIHO, RenderTextureReadWrite.Linear);
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06007625 RID: 30245 RVA: 0x00240349 File Offset: 0x0023E549
		private Texture2D areaTexture
		{
			get
			{
				if (this.m_AreaTexture == null)
				{
					this.m_AreaTexture = Resources.Load<Texture2D>("AreaTex");
				}
				return this.m_AreaTexture;
			}
		}

		// Token: 0x06007626 RID: 30246 RVA: 0x00240372 File Offset: 0x0023E572
		private Texture2D IMHCKPAABNA()
		{
			if (this.m_AreaTexture == null)
			{
				this.m_AreaTexture = Resources.Load<Texture2D>("value");
			}
			return this.m_AreaTexture;
		}

		// Token: 0x06007627 RID: 30247 RVA: 0x0024039B File Offset: 0x0023E59B
		private Texture2D DDHPKOJHIPJ()
		{
			if (this.m_AreaTexture == null)
			{
				this.m_AreaTexture = Resources.Load<Texture2D>("curScn");
			}
			return this.m_AreaTexture;
		}

		// Token: 0x06007628 RID: 30248 RVA: 0x002403C4 File Offset: 0x0023E5C4
		private Material PLBEJJIHFPB()
		{
			if (this.m_Material == null)
			{
				this.m_Material = ImageEffectHelper.CheckShaderAndCreateMaterial(this.DOIDAGGLBCO());
			}
			return this.m_Material;
		}

		// Token: 0x06007629 RID: 30249 RVA: 0x002403F0 File Offset: 0x0023E5F0
		private RenderTexture AFBDICNKBFF(int CJDDBGPKDLP, int PBMAGEKDPLI, RenderTextureFormat LGLMKIPIIHO)
		{
			int depthBuffer = 1;
			return RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, depthBuffer, LGLMKIPIIHO, RenderTextureReadWrite.Default);
		}

		// Token: 0x0600762A RID: 30250 RVA: 0x00240409 File Offset: 0x0023E609
		public void LHGFCBDACBM(AntiAliasing DNFGMNFCBGA)
		{
			if (!ImageEffectHelper.IsSupported(this.NLECFJKGKJD(), true, true, DNFGMNFCBGA))
			{
				DNFGMNFCBGA.enabled = true;
			}
		}

		// Token: 0x0600762B RID: 30251 RVA: 0x00240428 File Offset: 0x0023E628
		public void HFHELAEDMCA(Camera CPHDLGANKHG)
		{
			if (this.temporal.PCAFAPIIILI())
			{
				this.m_ProjectionMatrix = CPHDLGANKHG.projectionMatrix;
				this.m_FlipFlop -= 561f * this.m_FlipFlop;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.m03 = 1985f * this.m_FlipFlop * this.temporal.fuzzSize / (float)CPHDLGANKHG.pixelWidth;
				identity.m13 = 1684f * this.m_FlipFlop * this.temporal.fuzzSize / (float)CPHDLGANKHG.pixelHeight;
				CPHDLGANKHG.projectionMatrix = identity * CPHDLGANKHG.projectionMatrix;
			}
		}

		// Token: 0x0600762C RID: 30252 RVA: 0x002404D0 File Offset: 0x0023E6D0
		private RenderTexture HHCCBBJINEG(int CJDDBGPKDLP, int PBMAGEKDPLI, RenderTextureFormat LGLMKIPIIHO)
		{
			int depthBuffer = 1;
			return RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, depthBuffer, LGLMKIPIIHO, RenderTextureReadWrite.Linear);
		}

		// Token: 0x0600762D RID: 30253 RVA: 0x002404E9 File Offset: 0x0023E6E9
		private Texture2D CLBJBFOOCML()
		{
			if (this.m_SearchTexture == null)
			{
				this.m_SearchTexture = Resources.Load<Texture2D>("maps.");
			}
			return this.m_SearchTexture;
		}

		// Token: 0x0600762E RID: 30254 RVA: 0x00240514 File Offset: 0x0023E714
		private RenderTexture LJMKIAOFMIG(int CJDDBGPKDLP, int PBMAGEKDPLI, RenderTextureFormat LGLMKIPIIHO)
		{
			int depthBuffer = 0;
			return RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, depthBuffer, LGLMKIPIIHO, RenderTextureReadWrite.Default);
		}

		// Token: 0x0600762F RID: 30255 RVA: 0x0024052D File Offset: 0x0023E72D
		private Texture2D CNFBCDPECKG()
		{
			if (this.m_AreaTexture == null)
			{
				this.m_AreaTexture = Resources.Load<Texture2D>("InfoText");
			}
			return this.m_AreaTexture;
		}

		// Token: 0x06007630 RID: 30256 RVA: 0x00240556 File Offset: 0x0023E756
		public void OnEnable(AntiAliasing DNFGMNFCBGA)
		{
			if (!ImageEffectHelper.IsSupported(this.shader, true, false, DNFGMNFCBGA))
			{
				DNFGMNFCBGA.enabled = false;
			}
		}

		// Token: 0x06007631 RID: 30257 RVA: 0x00240574 File Offset: 0x0023E774
		public void OnPreCull(Camera CPHDLGANKHG)
		{
			if (this.temporal.UseTemporal())
			{
				this.m_ProjectionMatrix = CPHDLGANKHG.projectionMatrix;
				this.m_FlipFlop -= 2f * this.m_FlipFlop;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.m03 = 0.25f * this.m_FlipFlop * this.temporal.fuzzSize / (float)CPHDLGANKHG.pixelWidth;
				identity.m13 = -0.25f * this.m_FlipFlop * this.temporal.fuzzSize / (float)CPHDLGANKHG.pixelHeight;
				CPHDLGANKHG.projectionMatrix = identity * CPHDLGANKHG.projectionMatrix;
			}
		}

		// Token: 0x06007632 RID: 30258 RVA: 0x0024061C File Offset: 0x0023E81C
		private Material ADBKPGFMNKO()
		{
			if (this.m_Material == null)
			{
				this.m_Material = ImageEffectHelper.CheckShaderAndCreateMaterial(this.shader);
			}
			return this.m_Material;
		}

		// Token: 0x06007633 RID: 30259 RVA: 0x00240646 File Offset: 0x0023E846
		public void MLLPGPANCHI(AntiAliasing DNFGMNFCBGA)
		{
			if (!ImageEffectHelper.IsSupported(this.shader, false, false, DNFGMNFCBGA))
			{
				DNFGMNFCBGA.enabled = true;
			}
		}

		// Token: 0x06007634 RID: 30260 RVA: 0x00240664 File Offset: 0x0023E864
		public void OnRenderImage(Camera CPHDLGANKHG, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			int pixelWidth = CPHDLGANKHG.pixelWidth;
			int pixelHeight = CPHDLGANKHG.pixelHeight;
			bool flag = false;
			SMAA.QualitySettings qualitySettings = this.quality;
			if (this.settings.quality != SMAA.QualityPreset.Custom)
			{
				qualitySettings = SMAA.QualitySettings.presetQualitySettings[(int)this.settings.quality];
			}
			int edgeDetectionMethod = (int)this.settings.edgeDetectionMethod;
			int pass = 4;
			int pass2 = 5;
			int pass3 = 6;
			Matrix4x4 matrix4x = GL.GetGPUProjectionMatrix(this.m_ProjectionMatrix, true) * CPHDLGANKHG.worldToCameraMatrix;
			this.material.SetTexture("_AreaTex", this.areaTexture);
			this.material.SetTexture("_SearchTex", this.searchTexture);
			this.material.SetVector("_Metrics", new Vector4(1f / (float)pixelWidth, 1f / (float)pixelHeight, (float)pixelWidth, (float)pixelHeight));
			this.material.SetVector("_Params1", new Vector4(qualitySettings.threshold, qualitySettings.depthThreshold, (float)qualitySettings.maxSearchSteps, (float)qualitySettings.maxDiagonalSearchSteps));
			this.material.SetVector("_Params2", new Vector2((float)qualitySettings.cornerRounding, qualitySettings.localContrastAdaptationFactor));
			this.material.SetMatrix("_ReprojectionMatrix", this.m_PreviousViewProjectionMatrix * Matrix4x4.Inverse(matrix4x));
			float num = (this.m_FlipFlop >= 0f) ? 1f : 2f;
			this.material.SetVector("_SubsampleIndices", new Vector4(num, num, num, 0f));
			Shader.DisableKeyword("USE_PREDICATION");
			if (this.settings.edgeDetectionMethod == SMAA.EdgeDetectionMethod.Depth)
			{
				CPHDLGANKHG.depthTextureMode |= DepthTextureMode.Depth;
			}
			else if (this.predication.enabled)
			{
				CPHDLGANKHG.depthTextureMode |= DepthTextureMode.Depth;
				Shader.EnableKeyword("USE_PREDICATION");
				this.material.SetVector("_Params3", new Vector3(this.predication.threshold, this.predication.scale, this.predication.strength));
			}
			Shader.DisableKeyword("USE_DIAG_SEARCH");
			Shader.DisableKeyword("USE_CORNER_DETECTION");
			if (qualitySettings.diagonalDetection)
			{
				Shader.EnableKeyword("USE_DIAG_SEARCH");
			}
			if (qualitySettings.cornerDetection)
			{
				Shader.EnableKeyword("USE_CORNER_DETECTION");
			}
			Shader.DisableKeyword("USE_UV_BASED_REPROJECTION");
			if (this.temporal.UseTemporal())
			{
				Shader.EnableKeyword("USE_UV_BASED_REPROJECTION");
			}
			if (this.m_Accumulation == null || this.m_Accumulation.width != pixelWidth || this.m_Accumulation.height != pixelHeight)
			{
				if (this.m_Accumulation)
				{
					RenderTexture.ReleaseTemporary(this.m_Accumulation);
				}
				this.m_Accumulation = RenderTexture.GetTemporary(pixelWidth, pixelHeight, 0, HLBKCLPNHEB.format, RenderTextureReadWrite.Linear);
				this.m_Accumulation.hideFlags = HideFlags.HideAndDontSave;
				flag = true;
			}
			RenderTexture renderTexture = this.HPAOHDLJJFM(pixelWidth, pixelHeight, HLBKCLPNHEB.format);
			Graphics.Blit(null, renderTexture, this.material, 0);
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.material, edgeDetectionMethod);
			if (this.settings.debugPass == SMAA.DebugPass.Edges)
			{
				Graphics.Blit(renderTexture, BMMLHGHKBNM);
			}
			else
			{
				RenderTexture renderTexture2 = this.HPAOHDLJJFM(pixelWidth, pixelHeight, HLBKCLPNHEB.format);
				Graphics.Blit(null, renderTexture2, this.material, 0);
				Graphics.Blit(renderTexture, renderTexture2, this.material, pass);
				if (this.settings.debugPass == SMAA.DebugPass.Weights)
				{
					Graphics.Blit(renderTexture2, BMMLHGHKBNM);
				}
				else
				{
					this.material.SetTexture("_BlendTex", renderTexture2);
					if (this.temporal.UseTemporal())
					{
						Graphics.Blit(HLBKCLPNHEB, renderTexture, this.material, pass2);
						if (this.settings.debugPass == SMAA.DebugPass.Accumulation)
						{
							Graphics.Blit(this.m_Accumulation, BMMLHGHKBNM);
						}
						else if (!flag)
						{
							this.material.SetTexture("_AccumulationTex", this.m_Accumulation);
							Graphics.Blit(renderTexture, BMMLHGHKBNM, this.material, pass3);
						}
						else
						{
							Graphics.Blit(renderTexture, BMMLHGHKBNM);
						}
						Graphics.Blit(BMMLHGHKBNM, this.m_Accumulation);
						RenderTexture.active = null;
					}
					else
					{
						Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.material, pass2);
					}
				}
				RenderTexture.ReleaseTemporary(renderTexture2);
			}
			RenderTexture.ReleaseTemporary(renderTexture);
			this.m_PreviousViewProjectionMatrix = matrix4x;
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x06007635 RID: 30261 RVA: 0x00240AC2 File Offset: 0x0023ECC2
		public Shader shader
		{
			get
			{
				if (this.m_Shader == null)
				{
					this.m_Shader = Shader.Find("Hidden/Subpixel Morphological Anti-aliasing");
				}
				return this.m_Shader;
			}
		}

		// Token: 0x06007636 RID: 30262 RVA: 0x00240AEC File Offset: 0x0023ECEC
		public void DPFOEBCADNP()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
			if (this.m_Accumulation != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Accumulation);
			}
			this.m_Material = null;
			this.m_Accumulation = null;
		}

		// Token: 0x06007637 RID: 30263 RVA: 0x00240B3F File Offset: 0x0023ED3F
		public void NOLHKKEDEHM(Camera CPHDLGANKHG)
		{
			if (this.temporal.BHEMFECAGCN())
			{
				CPHDLGANKHG.ResetProjectionMatrix();
			}
		}

		// Token: 0x06007638 RID: 30264 RVA: 0x00240B57 File Offset: 0x0023ED57
		public void FKHCIAJEDHF(Camera CPHDLGANKHG)
		{
			if (this.temporal.CKDMFCJLAJL())
			{
				CPHDLGANKHG.ResetProjectionMatrix();
			}
		}

		// Token: 0x06007639 RID: 30265 RVA: 0x00240B70 File Offset: 0x0023ED70
		public void GBHFPIAHPPF(Camera CPHDLGANKHG)
		{
			if (this.temporal.JHLLGHAKJGJ())
			{
				this.m_ProjectionMatrix = CPHDLGANKHG.projectionMatrix;
				this.m_FlipFlop -= 1280f * this.m_FlipFlop;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.m03 = 1892f * this.m_FlipFlop * this.temporal.fuzzSize / (float)CPHDLGANKHG.pixelWidth;
				identity.m13 = 579f * this.m_FlipFlop * this.temporal.fuzzSize / (float)CPHDLGANKHG.pixelHeight;
				CPHDLGANKHG.projectionMatrix = identity * CPHDLGANKHG.projectionMatrix;
			}
		}

		// Token: 0x0600763A RID: 30266 RVA: 0x00240C18 File Offset: 0x0023EE18
		private RenderTexture FHPDNEGJMEL(int CJDDBGPKDLP, int PBMAGEKDPLI, RenderTextureFormat LGLMKIPIIHO)
		{
			int depthBuffer = 1;
			return RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, depthBuffer, LGLMKIPIIHO, RenderTextureReadWrite.Default);
		}

		// Token: 0x0600763B RID: 30267 RVA: 0x00240C34 File Offset: 0x0023EE34
		private RenderTexture HPAOHDLJJFM(int CJDDBGPKDLP, int PBMAGEKDPLI, RenderTextureFormat LGLMKIPIIHO)
		{
			int depthBuffer = 0;
			return RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, depthBuffer, LGLMKIPIIHO, RenderTextureReadWrite.Linear);
		}

		// Token: 0x0600763C RID: 30268 RVA: 0x00240C4D File Offset: 0x0023EE4D
		public Shader NLECFJKGKJD()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("ViewMenu");
			}
			return this.m_Shader;
		}

		// Token: 0x0600763D RID: 30269 RVA: 0x00240C78 File Offset: 0x0023EE78
		public void PLIKADJCEPO()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
			if (this.m_Accumulation != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Accumulation);
			}
			this.m_Material = null;
			this.m_Accumulation = null;
		}

		// Token: 0x0600763E RID: 30270 RVA: 0x00240CCB File Offset: 0x0023EECB
		private Texture2D PJCCLPIHAGC()
		{
			if (this.m_SearchTexture == null)
			{
				this.m_SearchTexture = Resources.Load<Texture2D>("_Axis");
			}
			return this.m_SearchTexture;
		}

		// Token: 0x0600763F RID: 30271 RVA: 0x00240CF4 File Offset: 0x0023EEF4
		private Texture2D APGLFDEFEPH()
		{
			if (this.m_AreaTexture == null)
			{
				this.m_AreaTexture = Resources.Load<Texture2D>("OneHand");
			}
			return this.m_AreaTexture;
		}

		// Token: 0x06007640 RID: 30272 RVA: 0x00240D20 File Offset: 0x0023EF20
		private RenderTexture OACICOMELHB(int CJDDBGPKDLP, int PBMAGEKDPLI, RenderTextureFormat LGLMKIPIIHO)
		{
			int depthBuffer = 0;
			return RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, depthBuffer, LGLMKIPIIHO, RenderTextureReadWrite.Linear);
		}

		// Token: 0x06007642 RID: 30274 RVA: 0x00240D91 File Offset: 0x0023EF91
		public Shader DOIDAGGLBCO()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("{0}");
			}
			return this.m_Shader;
		}

		// Token: 0x06007643 RID: 30275 RVA: 0x00240DBA File Offset: 0x0023EFBA
		private Texture2D HLDNDMKHOJP()
		{
			if (this.m_AreaTexture == null)
			{
				this.m_AreaTexture = Resources.Load<Texture2D>("_MainTex");
			}
			return this.m_AreaTexture;
		}

		// Token: 0x06007644 RID: 30276 RVA: 0x00240DE3 File Offset: 0x0023EFE3
		public Shader IGPCJOCBOIN()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find(" url: ");
			}
			return this.m_Shader;
		}

		// Token: 0x06007645 RID: 30277 RVA: 0x00240E0C File Offset: 0x0023F00C
		public void ONAFNCDKEMD(Camera CPHDLGANKHG)
		{
			if (this.temporal.DODALHEKHGE())
			{
				CPHDLGANKHG.ResetProjectionMatrix();
			}
		}

		// Token: 0x06007646 RID: 30278 RVA: 0x00240E24 File Offset: 0x0023F024
		public void JNGMIAFLBDL()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
			if (this.m_Accumulation != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Accumulation);
			}
			this.m_Material = null;
			this.m_Accumulation = null;
		}

		// Token: 0x06007647 RID: 30279 RVA: 0x0024061C File Offset: 0x0023E81C
		private Material EPCGJFCCAFH()
		{
			if (this.m_Material == null)
			{
				this.m_Material = ImageEffectHelper.CheckShaderAndCreateMaterial(this.shader);
			}
			return this.m_Material;
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06007648 RID: 30280 RVA: 0x0024061C File Offset: 0x0023E81C
		private Material material
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

		// Token: 0x06007649 RID: 30281 RVA: 0x00240E77 File Offset: 0x0023F077
		private Texture2D GHNECPLGBPC()
		{
			if (this.m_SearchTexture == null)
			{
				this.m_SearchTexture = Resources.Load<Texture2D>("Set camera background color");
			}
			return this.m_SearchTexture;
		}

		// Token: 0x0600764A RID: 30282 RVA: 0x00240EA0 File Offset: 0x0023F0A0
		private RenderTexture PFBDFOIKAII(int CJDDBGPKDLP, int PBMAGEKDPLI, RenderTextureFormat LGLMKIPIIHO)
		{
			int depthBuffer = 1;
			return RenderTexture.GetTemporary(CJDDBGPKDLP, PBMAGEKDPLI, depthBuffer, LGLMKIPIIHO, RenderTextureReadWrite.Default);
		}

		// Token: 0x0600764B RID: 30283 RVA: 0x00240EB9 File Offset: 0x0023F0B9
		public void OnPostRender(Camera CPHDLGANKHG)
		{
			if (this.temporal.UseTemporal())
			{
				CPHDLGANKHG.ResetProjectionMatrix();
			}
		}

		// Token: 0x0600764C RID: 30284 RVA: 0x00240ED4 File Offset: 0x0023F0D4
		public void MJFMHPLBKAK(Camera CPHDLGANKHG)
		{
			if (this.temporal.UseTemporal())
			{
				this.m_ProjectionMatrix = CPHDLGANKHG.projectionMatrix;
				this.m_FlipFlop -= 989f * this.m_FlipFlop;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.m03 = 1588f * this.m_FlipFlop * this.temporal.fuzzSize / (float)CPHDLGANKHG.pixelWidth;
				identity.m13 = 1394f * this.m_FlipFlop * this.temporal.fuzzSize / (float)CPHDLGANKHG.pixelHeight;
				CPHDLGANKHG.projectionMatrix = identity * CPHDLGANKHG.projectionMatrix;
			}
		}

		// Token: 0x0600764D RID: 30285 RVA: 0x00240F7C File Offset: 0x0023F17C
		private Texture2D AIIFALIOEMM()
		{
			if (this.m_SearchTexture == null)
			{
				this.m_SearchTexture = Resources.Load<Texture2D>(".a");
			}
			return this.m_SearchTexture;
		}

		// Token: 0x0600764E RID: 30286 RVA: 0x00240FA5 File Offset: 0x0023F1A5
		private Texture2D HLDOJMPKLOK()
		{
			if (this.m_AreaTexture == null)
			{
				this.m_AreaTexture = Resources.Load<Texture2D>("public");
			}
			return this.m_AreaTexture;
		}

		// Token: 0x0600764F RID: 30287 RVA: 0x00240FCE File Offset: 0x0023F1CE
		private Texture2D EDLPGHEAINL()
		{
			if (this.m_AreaTexture == null)
			{
				this.m_AreaTexture = Resources.Load<Texture2D>("ChatHistoryInputField");
			}
			return this.m_AreaTexture;
		}

		// Token: 0x06007650 RID: 30288 RVA: 0x00240FF8 File Offset: 0x0023F1F8
		public void OnDisable()
		{
			if (this.m_Material != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Material);
			}
			if (this.m_Accumulation != null)
			{
				UnityEngine.Object.DestroyImmediate(this.m_Accumulation);
			}
			this.m_Material = null;
			this.m_Accumulation = null;
		}

		// Token: 0x04000C16 RID: 3094
		[SMAA.TopLevelSettings]
		public SMAA.GlobalSettings settings = SMAA.GlobalSettings.defaultSettings;

		// Token: 0x04000C17 RID: 3095
		[SMAA.SettingsGroup]
		public SMAA.QualitySettings quality = SMAA.QualitySettings.presetQualitySettings[2];

		// Token: 0x04000C18 RID: 3096
		[SMAA.SettingsGroup]
		public SMAA.PredicationSettings predication = SMAA.PredicationSettings.defaultSettings;

		// Token: 0x04000C19 RID: 3097
		[SMAA.ExperimentalGroup]
		[SMAA.SettingsGroup]
		public SMAA.TemporalSettings temporal = SMAA.TemporalSettings.defaultSettings;

		// Token: 0x04000C1A RID: 3098
		private Matrix4x4 m_ProjectionMatrix;

		// Token: 0x04000C1B RID: 3099
		private Matrix4x4 m_PreviousViewProjectionMatrix;

		// Token: 0x04000C1C RID: 3100
		private float m_FlipFlop = 1f;

		// Token: 0x04000C1D RID: 3101
		private RenderTexture m_Accumulation;

		// Token: 0x04000C1E RID: 3102
		private Shader m_Shader;

		// Token: 0x04000C1F RID: 3103
		private Texture2D m_AreaTexture;

		// Token: 0x04000C20 RID: 3104
		private Texture2D m_SearchTexture;

		// Token: 0x04000C21 RID: 3105
		private Material m_Material;

		// Token: 0x020001A3 RID: 419
		[AttributeUsage(AttributeTargets.Field)]
		public class SettingsGroup : Attribute
		{
		}

		// Token: 0x020001A4 RID: 420
		[AttributeUsage(AttributeTargets.Field)]
		public class TopLevelSettings : Attribute
		{
		}

		// Token: 0x020001A5 RID: 421
		[AttributeUsage(AttributeTargets.Field)]
		public class ExperimentalGroup : Attribute
		{
		}

		// Token: 0x020001A6 RID: 422
		public enum DebugPass
		{
			// Token: 0x04000C23 RID: 3107
			Off,
			// Token: 0x04000C24 RID: 3108
			Edges,
			// Token: 0x04000C25 RID: 3109
			Weights,
			// Token: 0x04000C26 RID: 3110
			Accumulation
		}

		// Token: 0x020001A7 RID: 423
		public enum QualityPreset
		{
			// Token: 0x04000C28 RID: 3112
			Low,
			// Token: 0x04000C29 RID: 3113
			Medium,
			// Token: 0x04000C2A RID: 3114
			High,
			// Token: 0x04000C2B RID: 3115
			Ultra,
			// Token: 0x04000C2C RID: 3116
			Custom
		}

		// Token: 0x020001A8 RID: 424
		public enum EdgeDetectionMethod
		{
			// Token: 0x04000C2E RID: 3118
			Luma = 1,
			// Token: 0x04000C2F RID: 3119
			Color,
			// Token: 0x04000C30 RID: 3120
			Depth
		}

		// Token: 0x020001A9 RID: 425
		[Serializable]
		public struct GlobalSettings
		{
			// Token: 0x06007654 RID: 30292 RVA: 0x00241054 File Offset: 0x0023F254
			public static SMAA.GlobalSettings BKEJIPPCPDO()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Off,
					quality = (SMAA.QualityPreset)6,
					edgeDetectionMethod = (SMAA.EdgeDetectionMethod)0
				};
			}

			// Token: 0x06007655 RID: 30293 RVA: 0x00241084 File Offset: 0x0023F284
			public static SMAA.GlobalSettings AOACBHHEGFA()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Off,
					quality = SMAA.QualityPreset.Low,
					edgeDetectionMethod = SMAA.EdgeDetectionMethod.Color
				};
			}

			// Token: 0x06007656 RID: 30294 RVA: 0x002410B4 File Offset: 0x0023F2B4
			public static SMAA.GlobalSettings EDMABHKFEEO()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Edges,
					quality = (SMAA.QualityPreset)6,
					edgeDetectionMethod = (SMAA.EdgeDetectionMethod)4
				};
			}

			// Token: 0x06007657 RID: 30295 RVA: 0x002410E4 File Offset: 0x0023F2E4
			public static SMAA.GlobalSettings DFIOJCABPFD()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Off,
					quality = SMAA.QualityPreset.Ultra,
					edgeDetectionMethod = (SMAA.EdgeDetectionMethod)0
				};
			}

			// Token: 0x06007658 RID: 30296 RVA: 0x00241114 File Offset: 0x0023F314
			public static SMAA.GlobalSettings IAKAIGHJJJK()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Edges,
					quality = (SMAA.QualityPreset)6,
					edgeDetectionMethod = SMAA.EdgeDetectionMethod.Depth
				};
			}

			// Token: 0x06007659 RID: 30297 RVA: 0x00241144 File Offset: 0x0023F344
			public static SMAA.GlobalSettings LOMOMPKEDPL()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Off,
					quality = (SMAA.QualityPreset)8,
					edgeDetectionMethod = (SMAA.EdgeDetectionMethod)5
				};
			}

			// Token: 0x0600765A RID: 30298 RVA: 0x00241174 File Offset: 0x0023F374
			public static SMAA.GlobalSettings PKJMMJJFJAE()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Edges,
					quality = (SMAA.QualityPreset)8,
					edgeDetectionMethod = (SMAA.EdgeDetectionMethod)4
				};
			}

			// Token: 0x0600765B RID: 30299 RVA: 0x002411A4 File Offset: 0x0023F3A4
			public static SMAA.GlobalSettings CIHLOMNEHHL()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Edges,
					quality = SMAA.QualityPreset.High,
					edgeDetectionMethod = (SMAA.EdgeDetectionMethod)8
				};
			}

			// Token: 0x0600765C RID: 30300 RVA: 0x002411D4 File Offset: 0x0023F3D4
			public static SMAA.GlobalSettings KBINDKOODMK()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Edges,
					quality = (SMAA.QualityPreset)7,
					edgeDetectionMethod = SMAA.EdgeDetectionMethod.Depth
				};
			}

			// Token: 0x0600765D RID: 30301 RVA: 0x00241204 File Offset: 0x0023F404
			public static SMAA.GlobalSettings ELOBECLMGDD()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Edges,
					quality = (SMAA.QualityPreset)8,
					edgeDetectionMethod = SMAA.EdgeDetectionMethod.Depth
				};
			}

			// Token: 0x0600765E RID: 30302 RVA: 0x00241234 File Offset: 0x0023F434
			public static SMAA.GlobalSettings FPMJKNDJCON()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Edges,
					quality = (SMAA.QualityPreset)8,
					edgeDetectionMethod = (SMAA.EdgeDetectionMethod)8
				};
			}

			// Token: 0x0600765F RID: 30303 RVA: 0x00241264 File Offset: 0x0023F464
			public static SMAA.GlobalSettings AFJJPFIOEJD()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Edges,
					quality = SMAA.QualityPreset.Ultra,
					edgeDetectionMethod = SMAA.EdgeDetectionMethod.Depth
				};
			}

			// Token: 0x06007660 RID: 30304 RVA: 0x00241294 File Offset: 0x0023F494
			public static SMAA.GlobalSettings BOMFHCIHHIP()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Edges,
					quality = (SMAA.QualityPreset)5,
					edgeDetectionMethod = (SMAA.EdgeDetectionMethod)6
				};
			}

			// Token: 0x06007661 RID: 30305 RVA: 0x002412C4 File Offset: 0x0023F4C4
			public static SMAA.GlobalSettings HJLGAPEDPJM()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Off,
					quality = SMAA.QualityPreset.Ultra,
					edgeDetectionMethod = (SMAA.EdgeDetectionMethod)0
				};
			}

			// Token: 0x06007662 RID: 30306 RVA: 0x002412F4 File Offset: 0x0023F4F4
			public static SMAA.GlobalSettings NCFGPFGLKLJ()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Off,
					quality = SMAA.QualityPreset.Medium,
					edgeDetectionMethod = SMAA.EdgeDetectionMethod.Color
				};
			}

			// Token: 0x06007663 RID: 30307 RVA: 0x00241324 File Offset: 0x0023F524
			public static SMAA.GlobalSettings EBMPPAMNFNK()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Edges,
					quality = (SMAA.QualityPreset)5,
					edgeDetectionMethod = (SMAA.EdgeDetectionMethod)0
				};
			}

			// Token: 0x06007664 RID: 30308 RVA: 0x00241354 File Offset: 0x0023F554
			public static SMAA.GlobalSettings OIPFKIPOECC()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Off,
					quality = SMAA.QualityPreset.Ultra,
					edgeDetectionMethod = (SMAA.EdgeDetectionMethod)4
				};
			}

			// Token: 0x06007665 RID: 30309 RVA: 0x00241384 File Offset: 0x0023F584
			public static SMAA.GlobalSettings IHMKIGDJKAH()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Off,
					quality = SMAA.QualityPreset.High,
					edgeDetectionMethod = (SMAA.EdgeDetectionMethod)5
				};
			}

			// Token: 0x06007666 RID: 30310 RVA: 0x002413B4 File Offset: 0x0023F5B4
			public static SMAA.GlobalSettings JCLADKAMOLD()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Edges,
					quality = SMAA.QualityPreset.Medium,
					edgeDetectionMethod = SMAA.EdgeDetectionMethod.Color
				};
			}

			// Token: 0x06007667 RID: 30311 RVA: 0x002413E4 File Offset: 0x0023F5E4
			public static SMAA.GlobalSettings MHIHHBMBDLP()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Edges,
					quality = SMAA.QualityPreset.Ultra,
					edgeDetectionMethod = SMAA.EdgeDetectionMethod.Color
				};
			}

			// Token: 0x06007668 RID: 30312 RVA: 0x00241414 File Offset: 0x0023F614
			public static SMAA.GlobalSettings LIDMIPKCHOI()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Off,
					quality = (SMAA.QualityPreset)8,
					edgeDetectionMethod = SMAA.EdgeDetectionMethod.Color
				};
			}

			// Token: 0x06007669 RID: 30313 RVA: 0x00241444 File Offset: 0x0023F644
			public static SMAA.GlobalSettings IAKJOAGBDGO()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Edges,
					quality = SMAA.QualityPreset.Custom,
					edgeDetectionMethod = (SMAA.EdgeDetectionMethod)6
				};
			}

			// Token: 0x0600766A RID: 30314 RVA: 0x00241474 File Offset: 0x0023F674
			public static SMAA.GlobalSettings FCBIDJLDABO()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Off,
					quality = SMAA.QualityPreset.High,
					edgeDetectionMethod = (SMAA.EdgeDetectionMethod)4
				};
			}

			// Token: 0x0600766B RID: 30315 RVA: 0x002414A4 File Offset: 0x0023F6A4
			public static SMAA.GlobalSettings MLKLBGCKPOO()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Edges,
					quality = SMAA.QualityPreset.Custom,
					edgeDetectionMethod = (SMAA.EdgeDetectionMethod)5
				};
			}

			// Token: 0x0600766C RID: 30316 RVA: 0x002414D4 File Offset: 0x0023F6D4
			public static SMAA.GlobalSettings BCOPOEIJONI()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Edges,
					quality = SMAA.QualityPreset.High,
					edgeDetectionMethod = SMAA.EdgeDetectionMethod.Depth
				};
			}

			// Token: 0x0600766D RID: 30317 RVA: 0x00241504 File Offset: 0x0023F704
			public static SMAA.GlobalSettings AAPGCALKNAK()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Edges,
					quality = (SMAA.QualityPreset)6,
					edgeDetectionMethod = (SMAA.EdgeDetectionMethod)0
				};
			}

			// Token: 0x0600766E RID: 30318 RVA: 0x00241534 File Offset: 0x0023F734
			public static SMAA.GlobalSettings INDEHPGLEGK()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Off,
					quality = (SMAA.QualityPreset)7,
					edgeDetectionMethod = (SMAA.EdgeDetectionMethod)6
				};
			}

			// Token: 0x1700016D RID: 365
			// (get) Token: 0x0600766F RID: 30319 RVA: 0x00241564 File Offset: 0x0023F764
			public static SMAA.GlobalSettings defaultSettings
			{
				get
				{
					return new SMAA.GlobalSettings
					{
						debugPass = SMAA.DebugPass.Off,
						quality = SMAA.QualityPreset.High,
						edgeDetectionMethod = SMAA.EdgeDetectionMethod.Color
					};
				}
			}

			// Token: 0x06007670 RID: 30320 RVA: 0x00241594 File Offset: 0x0023F794
			public static SMAA.GlobalSettings LBIOOILOAAD()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Edges,
					quality = SMAA.QualityPreset.Medium,
					edgeDetectionMethod = SMAA.EdgeDetectionMethod.Depth
				};
			}

			// Token: 0x06007671 RID: 30321 RVA: 0x002415C4 File Offset: 0x0023F7C4
			public static SMAA.GlobalSettings EJLLADABOLM()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Off,
					quality = SMAA.QualityPreset.Custom,
					edgeDetectionMethod = SMAA.EdgeDetectionMethod.Luma
				};
			}

			// Token: 0x06007672 RID: 30322 RVA: 0x002415F4 File Offset: 0x0023F7F4
			public static SMAA.GlobalSettings NIPPCMNKCMB()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Edges,
					quality = (SMAA.QualityPreset)5,
					edgeDetectionMethod = (SMAA.EdgeDetectionMethod)5
				};
			}

			// Token: 0x06007673 RID: 30323 RVA: 0x00241624 File Offset: 0x0023F824
			public static SMAA.GlobalSettings CCADIDPNEKH()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Off,
					quality = SMAA.QualityPreset.Custom,
					edgeDetectionMethod = (SMAA.EdgeDetectionMethod)7
				};
			}

			// Token: 0x06007674 RID: 30324 RVA: 0x00241654 File Offset: 0x0023F854
			public static SMAA.GlobalSettings EEMMJNPOFOB()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Edges,
					quality = SMAA.QualityPreset.Low,
					edgeDetectionMethod = (SMAA.EdgeDetectionMethod)5
				};
			}

			// Token: 0x06007675 RID: 30325 RVA: 0x00241684 File Offset: 0x0023F884
			public static SMAA.GlobalSettings GJNKFICGFFG()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Edges,
					quality = SMAA.QualityPreset.Ultra,
					edgeDetectionMethod = (SMAA.EdgeDetectionMethod)0
				};
			}

			// Token: 0x06007676 RID: 30326 RVA: 0x002416B4 File Offset: 0x0023F8B4
			public static SMAA.GlobalSettings MNKGFGNDKED()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Off,
					quality = (SMAA.QualityPreset)7,
					edgeDetectionMethod = (SMAA.EdgeDetectionMethod)8
				};
			}

			// Token: 0x06007677 RID: 30327 RVA: 0x002416E4 File Offset: 0x0023F8E4
			public static SMAA.GlobalSettings DBDJKKLMCGG()
			{
				return new SMAA.GlobalSettings
				{
					debugPass = SMAA.DebugPass.Edges,
					quality = (SMAA.QualityPreset)7,
					edgeDetectionMethod = SMAA.EdgeDetectionMethod.Luma
				};
			}

			// Token: 0x04000C31 RID: 3121
			[Tooltip("Use this to fine tune your settings when working in Custom quality mode. \"Accumulation\" only works when \"Temporal Filtering\" is enabled.")]
			public SMAA.DebugPass debugPass;

			// Token: 0x04000C32 RID: 3122
			[Tooltip("Low: 60% of the quality.\nMedium: 80% of the quality.\nHigh: 95% of the quality.\nUltra: 99% of the quality (overkill).")]
			public SMAA.QualityPreset quality;

			// Token: 0x04000C33 RID: 3123
			[Tooltip("You've three edge detection methods to choose from: luma, color or depth.\nThey represent different quality/performance and anti-aliasing/sharpness tradeoffs, so our recommendation is for you to choose the one that best suits your particular scenario:\n\n- Depth edge detection is usually the fastest but it may miss some edges.\n- Luma edge detection is usually more expensive than depth edge detection, but catches visible edges that depth edge detection can miss.\n- Color edge detection is usually the most expensive one but catches chroma-only edges.")]
			public SMAA.EdgeDetectionMethod edgeDetectionMethod;
		}

		// Token: 0x020001AA RID: 426
		[Serializable]
		public struct QualitySettings
		{
			// Token: 0x04000C34 RID: 3124
			[Tooltip("Enables/Disables diagonal processing.")]
			public bool diagonalDetection;

			// Token: 0x04000C35 RID: 3125
			[Tooltip("Enables/Disables corner detection. Leave this on to avoid blurry corners.")]
			public bool cornerDetection;

			// Token: 0x04000C36 RID: 3126
			[Tooltip("Specifies the threshold or sensitivity to edges. Lowering this value you will be able to detect more edges at the expense of performance.\n0.1 is a reasonable value, and allows to catch most visible edges. 0.05 is a rather overkill value, that allows to catch 'em all.")]
			[Range(0f, 0.5f)]
			public float threshold;

			// Token: 0x04000C37 RID: 3127
			[Tooltip("Specifies the threshold for depth edge detection. Lowering this value you will be able to detect more edges at the expense of performance.")]
			[Min(0.0001f)]
			public float depthThreshold;

			// Token: 0x04000C38 RID: 3128
			[Tooltip("Specifies the maximum steps performed in the horizontal/vertical pattern searches, at each side of the pixel.\nIn number of pixels, it's actually the double. So the maximum line length perfectly handled by, for example 16, is 64 (by perfectly, we meant that longer lines won't look as good, but still antialiased).")]
			[Range(0f, 112f)]
			public int maxSearchSteps;

			// Token: 0x04000C39 RID: 3129
			[Tooltip("Specifies the maximum steps performed in the diagonal pattern searches, at each side of the pixel. In this case we jump one pixel at time, instead of two.\nOn high-end machines it is cheap (between a 0.8x and 0.9x slower for 16 steps), but it can have a significant impact on older machines.")]
			[Range(0f, 20f)]
			public int maxDiagonalSearchSteps;

			// Token: 0x04000C3A RID: 3130
			[Tooltip("Specifies how much sharp corners will be rounded.")]
			[Range(0f, 100f)]
			public int cornerRounding;

			// Token: 0x04000C3B RID: 3131
			[Tooltip("If there is an neighbor edge that has a local contrast factor times bigger contrast than current edge, current edge will be discarded.\nThis allows to eliminate spurious crossing edges, and is based on the fact that, if there is too much contrast in a direction, that will hide perceptually contrast in the other neighbors.")]
			[Min(0f)]
			public float localContrastAdaptationFactor;

			// Token: 0x04000C3C RID: 3132
			public static SMAA.QualitySettings[] presetQualitySettings = new SMAA.QualitySettings[]
			{
				new SMAA.QualitySettings
				{
					diagonalDetection = false,
					cornerDetection = false,
					threshold = 0.15f,
					depthThreshold = 0.01f,
					maxSearchSteps = 4,
					maxDiagonalSearchSteps = 8,
					cornerRounding = 25,
					localContrastAdaptationFactor = 2f
				},
				new SMAA.QualitySettings
				{
					diagonalDetection = false,
					cornerDetection = false,
					threshold = 0.1f,
					depthThreshold = 0.01f,
					maxSearchSteps = 8,
					maxDiagonalSearchSteps = 8,
					cornerRounding = 25,
					localContrastAdaptationFactor = 2f
				},
				new SMAA.QualitySettings
				{
					diagonalDetection = true,
					cornerDetection = true,
					threshold = 0.1f,
					depthThreshold = 0.01f,
					maxSearchSteps = 16,
					maxDiagonalSearchSteps = 8,
					cornerRounding = 25,
					localContrastAdaptationFactor = 2f
				},
				new SMAA.QualitySettings
				{
					diagonalDetection = true,
					cornerDetection = true,
					threshold = 0.05f,
					depthThreshold = 0.01f,
					maxSearchSteps = 32,
					maxDiagonalSearchSteps = 16,
					cornerRounding = 25,
					localContrastAdaptationFactor = 2f
				}
			};
		}

		// Token: 0x020001AB RID: 427
		[Serializable]
		public struct TemporalSettings
		{
			// Token: 0x06007679 RID: 30329 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool OBEOMABPCPC()
			{
				return this.enabled;
			}

			// Token: 0x0600767A RID: 30330 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool EDJLDCJJLIE()
			{
				return this.enabled;
			}

			// Token: 0x0600767B RID: 30331 RVA: 0x002418C0 File Offset: 0x0023FAC0
			public static SMAA.TemporalSettings JCLADKAMOLD()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 799f
				};
			}

			// Token: 0x0600767C RID: 30332 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool BHEMFECAGCN()
			{
				return this.enabled;
			}

			// Token: 0x0600767D RID: 30333 RVA: 0x002418EC File Offset: 0x0023FAEC
			public static SMAA.TemporalSettings FCBIDJLDABO()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 1036f
				};
			}

			// Token: 0x0600767E RID: 30334 RVA: 0x00241918 File Offset: 0x0023FB18
			public static SMAA.TemporalSettings MGEOLKPLHOM()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 1337f
				};
			}

			// Token: 0x0600767F RID: 30335 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool KIGPGFLHFAI()
			{
				return this.enabled;
			}

			// Token: 0x06007680 RID: 30336 RVA: 0x00241944 File Offset: 0x0023FB44
			public static SMAA.TemporalSettings AOACBHHEGFA()
			{
				return new SMAA.TemporalSettings
				{
					enabled = false,
					fuzzSize = 1130f
				};
			}

			// Token: 0x06007681 RID: 30337 RVA: 0x00241970 File Offset: 0x0023FB70
			public static SMAA.TemporalSettings DEOLKOLBAHH()
			{
				return new SMAA.TemporalSettings
				{
					enabled = false,
					fuzzSize = 845f
				};
			}

			// Token: 0x06007682 RID: 30338 RVA: 0x0024199C File Offset: 0x0023FB9C
			public static SMAA.TemporalSettings CDJAOBCAOKJ()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 341f
				};
			}

			// Token: 0x06007683 RID: 30339 RVA: 0x002419C8 File Offset: 0x0023FBC8
			public static SMAA.TemporalSettings OLPCIKIBBKE()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 117f
				};
			}

			// Token: 0x06007684 RID: 30340 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool JHLLGHAKJGJ()
			{
				return this.enabled;
			}

			// Token: 0x06007685 RID: 30341 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool BKBKMMLIOHA()
			{
				return this.enabled;
			}

			// Token: 0x06007686 RID: 30342 RVA: 0x002419F4 File Offset: 0x0023FBF4
			public static SMAA.TemporalSettings IAKAIGHJJJK()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 1575f
				};
			}

			// Token: 0x06007687 RID: 30343 RVA: 0x00241A20 File Offset: 0x0023FC20
			public static SMAA.TemporalSettings ELOBECLMGDD()
			{
				return new SMAA.TemporalSettings
				{
					enabled = false,
					fuzzSize = 99f
				};
			}

			// Token: 0x06007688 RID: 30344 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool BCGFKBMMOHM()
			{
				return this.enabled;
			}

			// Token: 0x06007689 RID: 30345 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool MFGJKBIHKML()
			{
				return this.enabled;
			}

			// Token: 0x0600768A RID: 30346 RVA: 0x00241A4C File Offset: 0x0023FC4C
			public static SMAA.TemporalSettings MHIHHBMBDLP()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 1985f
				};
			}

			// Token: 0x0600768B RID: 30347 RVA: 0x00241A78 File Offset: 0x0023FC78
			public static SMAA.TemporalSettings NPIEKGGCMBG()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 875f
				};
			}

			// Token: 0x0600768C RID: 30348 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool LLBFFHKIIFL()
			{
				return this.enabled;
			}

			// Token: 0x0600768D RID: 30349 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool EGCGAFBNJOP()
			{
				return this.enabled;
			}

			// Token: 0x0600768E RID: 30350 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool GLEAKHGMLEJ()
			{
				return this.enabled;
			}

			// Token: 0x0600768F RID: 30351 RVA: 0x00241AA4 File Offset: 0x0023FCA4
			public static SMAA.TemporalSettings OIPFKIPOECC()
			{
				return new SMAA.TemporalSettings
				{
					enabled = false,
					fuzzSize = 1832f
				};
			}

			// Token: 0x06007690 RID: 30352 RVA: 0x00241AD0 File Offset: 0x0023FCD0
			public static SMAA.TemporalSettings EDMABHKFEEO()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 166f
				};
			}

			// Token: 0x06007691 RID: 30353 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool ICFPCDGIPNL()
			{
				return this.enabled;
			}

			// Token: 0x06007692 RID: 30354 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool LJINCEBICGC()
			{
				return this.enabled;
			}

			// Token: 0x06007693 RID: 30355 RVA: 0x00241AFC File Offset: 0x0023FCFC
			public static SMAA.TemporalSettings DFIOJCABPFD()
			{
				return new SMAA.TemporalSettings
				{
					enabled = false,
					fuzzSize = 948f
				};
			}

			// Token: 0x06007694 RID: 30356 RVA: 0x00241B28 File Offset: 0x0023FD28
			public static SMAA.TemporalSettings AFJJPFIOEJD()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 1274f
				};
			}

			// Token: 0x06007695 RID: 30357 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool MPNCMEIMMBK()
			{
				return this.enabled;
			}

			// Token: 0x06007696 RID: 30358 RVA: 0x00241B54 File Offset: 0x0023FD54
			public static SMAA.TemporalSettings MLKLBGCKPOO()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 845f
				};
			}

			// Token: 0x06007697 RID: 30359 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool GIDBMEMGGOC()
			{
				return this.enabled;
			}

			// Token: 0x06007698 RID: 30360 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool FJFPEFBPJNB()
			{
				return this.enabled;
			}

			// Token: 0x06007699 RID: 30361 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool MCPNBHIEIIK()
			{
				return this.enabled;
			}

			// Token: 0x0600769A RID: 30362 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool FMCPCADLDKG()
			{
				return this.enabled;
			}

			// Token: 0x0600769B RID: 30363 RVA: 0x00241B80 File Offset: 0x0023FD80
			public static SMAA.TemporalSettings CJFONFEOHIO()
			{
				return new SMAA.TemporalSettings
				{
					enabled = false,
					fuzzSize = 163f
				};
			}

			// Token: 0x0600769C RID: 30364 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool DODALHEKHGE()
			{
				return this.enabled;
			}

			// Token: 0x0600769D RID: 30365 RVA: 0x00241BAC File Offset: 0x0023FDAC
			public static SMAA.TemporalSettings PKJMMJJFJAE()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 1210f
				};
			}

			// Token: 0x0600769E RID: 30366 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool KEMLBPLNLJD()
			{
				return this.enabled;
			}

			// Token: 0x0600769F RID: 30367 RVA: 0x00241BD8 File Offset: 0x0023FDD8
			public static SMAA.TemporalSettings BFBOLLFFMLN()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 1574f
				};
			}

			// Token: 0x060076A0 RID: 30368 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool GKMPKFDLKMI()
			{
				return this.enabled;
			}

			// Token: 0x060076A1 RID: 30369 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool BICLFFLHENM()
			{
				return this.enabled;
			}

			// Token: 0x060076A2 RID: 30370 RVA: 0x00241C04 File Offset: 0x0023FE04
			public static SMAA.TemporalSettings IOJDDHLHPLH()
			{
				return new SMAA.TemporalSettings
				{
					enabled = false,
					fuzzSize = 1203f
				};
			}

			// Token: 0x1700016E RID: 366
			// (get) Token: 0x060076A3 RID: 30371 RVA: 0x00241C30 File Offset: 0x0023FE30
			public static SMAA.TemporalSettings defaultSettings
			{
				get
				{
					return new SMAA.TemporalSettings
					{
						enabled = false,
						fuzzSize = 2f
					};
				}
			}

			// Token: 0x060076A4 RID: 30372 RVA: 0x00241C5C File Offset: 0x0023FE5C
			public static SMAA.TemporalSettings INDEHPGLEGK()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 334f
				};
			}

			// Token: 0x060076A5 RID: 30373 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool UseTemporal()
			{
				return this.enabled;
			}

			// Token: 0x060076A6 RID: 30374 RVA: 0x00241C88 File Offset: 0x0023FE88
			public static SMAA.TemporalSettings HJLGAPEDPJM()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 291f
				};
			}

			// Token: 0x060076A7 RID: 30375 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool AHNJABLBJKL()
			{
				return this.enabled;
			}

			// Token: 0x060076A8 RID: 30376 RVA: 0x00241CB4 File Offset: 0x0023FEB4
			public static SMAA.TemporalSettings NIPPCMNKCMB()
			{
				return new SMAA.TemporalSettings
				{
					enabled = true,
					fuzzSize = 1224f
				};
			}

			// Token: 0x060076A9 RID: 30377 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool CKDMFCJLAJL()
			{
				return this.enabled;
			}

			// Token: 0x060076AA RID: 30378 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool PCAFAPIIILI()
			{
				return this.enabled;
			}

			// Token: 0x060076AB RID: 30379 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool LOKNCMOGCAB()
			{
				return this.enabled;
			}

			// Token: 0x060076AC RID: 30380 RVA: 0x002418B7 File Offset: 0x0023FAB7
			public bool GKBNADGPHDH()
			{
				return this.enabled;
			}

			// Token: 0x04000C3D RID: 3133
			[Tooltip("Temporal filtering makes it possible for the SMAA algorithm to benefit from minute subpixel information available that has been accumulated over many frames.")]
			public bool enabled;

			// Token: 0x04000C3E RID: 3134
			[Tooltip("The size of the fuzz-displacement (jitter) in pixels applied to the camera's perspective projection matrix.\nUsed for 2x temporal anti-aliasing.")]
			[Range(0.5f, 10f)]
			public float fuzzSize;
		}

		// Token: 0x020001AC RID: 428
		[Serializable]
		public struct PredicationSettings
		{
			// Token: 0x060076AD RID: 30381 RVA: 0x00241CE0 File Offset: 0x0023FEE0
			public static SMAA.PredicationSettings BOMFHCIHHIP()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 1927f,
					scale = 1028f,
					strength = 215f
				};
			}

			// Token: 0x060076AE RID: 30382 RVA: 0x00241D24 File Offset: 0x0023FF24
			public static SMAA.PredicationSettings FPMJKNDJCON()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 569f,
					scale = 1327f,
					strength = 445f
				};
			}

			// Token: 0x060076AF RID: 30383 RVA: 0x00241D68 File Offset: 0x0023FF68
			public static SMAA.PredicationSettings NPIEKGGCMBG()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 576f,
					scale = 1962f,
					strength = 800f
				};
			}

			// Token: 0x060076B0 RID: 30384 RVA: 0x00241DAC File Offset: 0x0023FFAC
			public static SMAA.PredicationSettings IAKAIGHJJJK()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 1265f,
					scale = 969f,
					strength = 1561f
				};
			}

			// Token: 0x060076B1 RID: 30385 RVA: 0x00241DF0 File Offset: 0x0023FFF0
			public static SMAA.PredicationSettings CJFONFEOHIO()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 110f,
					scale = 947f,
					strength = 414f
				};
			}

			// Token: 0x060076B2 RID: 30386 RVA: 0x00241E34 File Offset: 0x00240034
			public static SMAA.PredicationSettings IHMKIGDJKAH()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 486f,
					scale = 110f,
					strength = 1244f
				};
			}

			// Token: 0x060076B3 RID: 30387 RVA: 0x00241E78 File Offset: 0x00240078
			public static SMAA.PredicationSettings PKJMMJJFJAE()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 1027f,
					scale = 845f,
					strength = 1978f
				};
			}

			// Token: 0x060076B4 RID: 30388 RVA: 0x00241EBC File Offset: 0x002400BC
			public static SMAA.PredicationSettings FCBIDJLDABO()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 417f,
					scale = 295f,
					strength = 1420f
				};
			}

			// Token: 0x060076B5 RID: 30389 RVA: 0x00241F00 File Offset: 0x00240100
			public static SMAA.PredicationSettings NCFGPFGLKLJ()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 656f,
					scale = 1490f,
					strength = 1702f
				};
			}

			// Token: 0x060076B6 RID: 30390 RVA: 0x00241F44 File Offset: 0x00240144
			public static SMAA.PredicationSettings AAPGCALKNAK()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 1138f,
					scale = 32f,
					strength = 1952f
				};
			}

			// Token: 0x060076B7 RID: 30391 RVA: 0x00241F88 File Offset: 0x00240188
			public static SMAA.PredicationSettings EBMPPAMNFNK()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 389f,
					scale = 457f,
					strength = 1518f
				};
			}

			// Token: 0x060076B8 RID: 30392 RVA: 0x00241FCC File Offset: 0x002401CC
			public static SMAA.PredicationSettings INDEHPGLEGK()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 1786f,
					scale = 722f,
					strength = 977f
				};
			}

			// Token: 0x060076B9 RID: 30393 RVA: 0x00242010 File Offset: 0x00240210
			public static SMAA.PredicationSettings FIPCIMGELME()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 713f,
					scale = 613f,
					strength = 348f
				};
			}

			// Token: 0x060076BA RID: 30394 RVA: 0x00242054 File Offset: 0x00240254
			public static SMAA.PredicationSettings MNKGFGNDKED()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 65f,
					scale = 1952f,
					strength = 1641f
				};
			}

			// Token: 0x060076BB RID: 30395 RVA: 0x00242098 File Offset: 0x00240298
			public static SMAA.PredicationSettings LIDMIPKCHOI()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 927f,
					scale = 592f,
					strength = 1728f
				};
			}

			// Token: 0x060076BC RID: 30396 RVA: 0x002420DC File Offset: 0x002402DC
			public static SMAA.PredicationSettings EEMMJNPOFOB()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 1840f,
					scale = 1631f,
					strength = 257f
				};
			}

			// Token: 0x060076BD RID: 30397 RVA: 0x00242120 File Offset: 0x00240320
			public static SMAA.PredicationSettings HJLGAPEDPJM()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 700f,
					scale = 553f,
					strength = 1939f
				};
			}

			// Token: 0x060076BE RID: 30398 RVA: 0x00242164 File Offset: 0x00240364
			public static SMAA.PredicationSettings ELOBECLMGDD()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 896f,
					scale = 590f,
					strength = 1614f
				};
			}

			// Token: 0x060076BF RID: 30399 RVA: 0x002421A8 File Offset: 0x002403A8
			public static SMAA.PredicationSettings BCOPOEIJONI()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 453f,
					scale = 1554f,
					strength = 254f
				};
			}

			// Token: 0x060076C0 RID: 30400 RVA: 0x002421EC File Offset: 0x002403EC
			public static SMAA.PredicationSettings EJLLADABOLM()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 563f,
					scale = 1938f,
					strength = 298f
				};
			}

			// Token: 0x060076C1 RID: 30401 RVA: 0x00242230 File Offset: 0x00240430
			public static SMAA.PredicationSettings JCLADKAMOLD()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 438f,
					scale = 1751f,
					strength = 58f
				};
			}

			// Token: 0x060076C2 RID: 30402 RVA: 0x00242274 File Offset: 0x00240474
			public static SMAA.PredicationSettings DBDJKKLMCGG()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 803f,
					scale = 300f,
					strength = 1953f
				};
			}

			// Token: 0x060076C3 RID: 30403 RVA: 0x002422B8 File Offset: 0x002404B8
			public static SMAA.PredicationSettings CCADIDPNEKH()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 1404f,
					scale = 641f,
					strength = 1228f
				};
			}

			// Token: 0x060076C4 RID: 30404 RVA: 0x002422FC File Offset: 0x002404FC
			public static SMAA.PredicationSettings EDMABHKFEEO()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 1094f,
					scale = 782f,
					strength = 69f
				};
			}

			// Token: 0x060076C5 RID: 30405 RVA: 0x00242340 File Offset: 0x00240540
			public static SMAA.PredicationSettings DFIOJCABPFD()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 533f,
					scale = 1897f,
					strength = 252f
				};
			}

			// Token: 0x060076C6 RID: 30406 RVA: 0x00242384 File Offset: 0x00240584
			public static SMAA.PredicationSettings NOBNMJMOJDB()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 129f,
					scale = 411f,
					strength = 588f
				};
			}

			// Token: 0x060076C7 RID: 30407 RVA: 0x002423C8 File Offset: 0x002405C8
			public static SMAA.PredicationSettings MHIHHBMBDLP()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 1796f,
					scale = 729f,
					strength = 1695f
				};
			}

			// Token: 0x060076C8 RID: 30408 RVA: 0x0024240C File Offset: 0x0024060C
			public static SMAA.PredicationSettings GOKMCEIBFIM()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 1899f,
					scale = 54f,
					strength = 1547f
				};
			}

			// Token: 0x060076C9 RID: 30409 RVA: 0x00242450 File Offset: 0x00240650
			public static SMAA.PredicationSettings LBIOOILOAAD()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 1144f,
					scale = 53f,
					strength = 909f
				};
			}

			// Token: 0x060076CA RID: 30410 RVA: 0x00242494 File Offset: 0x00240694
			public static SMAA.PredicationSettings BKEJIPPCPDO()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 900f,
					scale = 262f,
					strength = 1140f
				};
			}

			// Token: 0x060076CB RID: 30411 RVA: 0x002424D8 File Offset: 0x002406D8
			public static SMAA.PredicationSettings AFJJPFIOEJD()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 123f,
					scale = 998f,
					strength = 1791f
				};
			}

			// Token: 0x060076CC RID: 30412 RVA: 0x0024251C File Offset: 0x0024071C
			public static SMAA.PredicationSettings MGEOLKPLHOM()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 1139f,
					scale = 841f,
					strength = 337f
				};
			}

			// Token: 0x1700016F RID: 367
			// (get) Token: 0x060076CD RID: 30413 RVA: 0x00242560 File Offset: 0x00240760
			public static SMAA.PredicationSettings defaultSettings
			{
				get
				{
					return new SMAA.PredicationSettings
					{
						enabled = false,
						threshold = 0.01f,
						scale = 2f,
						strength = 0.4f
					};
				}
			}

			// Token: 0x060076CE RID: 30414 RVA: 0x002425A4 File Offset: 0x002407A4
			public static SMAA.PredicationSettings KBINDKOODMK()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 522f,
					scale = 415f,
					strength = 428f
				};
			}

			// Token: 0x060076CF RID: 30415 RVA: 0x002425E8 File Offset: 0x002407E8
			public static SMAA.PredicationSettings MLKLBGCKPOO()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 1937f,
					scale = 523f,
					strength = 387f
				};
			}

			// Token: 0x060076D0 RID: 30416 RVA: 0x0024262C File Offset: 0x0024082C
			public static SMAA.PredicationSettings OIPFKIPOECC()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 1713f,
					scale = 1983f,
					strength = 527f
				};
			}

			// Token: 0x060076D1 RID: 30417 RVA: 0x00242670 File Offset: 0x00240870
			public static SMAA.PredicationSettings CIHLOMNEHHL()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 284f,
					scale = 1955f,
					strength = 936f
				};
			}

			// Token: 0x060076D2 RID: 30418 RVA: 0x002426B4 File Offset: 0x002408B4
			public static SMAA.PredicationSettings AOACBHHEGFA()
			{
				return new SMAA.PredicationSettings
				{
					enabled = false,
					threshold = 259f,
					scale = 1275f,
					strength = 231f
				};
			}

			// Token: 0x060076D3 RID: 30419 RVA: 0x002426F8 File Offset: 0x002408F8
			public static SMAA.PredicationSettings NIPPCMNKCMB()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 373f,
					scale = 652f,
					strength = 676f
				};
			}

			// Token: 0x060076D4 RID: 30420 RVA: 0x0024273C File Offset: 0x0024093C
			public static SMAA.PredicationSettings IAKJOAGBDGO()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 306f,
					scale = 265f,
					strength = 608f
				};
			}

			// Token: 0x060076D5 RID: 30421 RVA: 0x00242780 File Offset: 0x00240980
			public static SMAA.PredicationSettings GJNKFICGFFG()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 268f,
					scale = 483f,
					strength = 1350f
				};
			}

			// Token: 0x060076D6 RID: 30422 RVA: 0x002427C4 File Offset: 0x002409C4
			public static SMAA.PredicationSettings IOFLMDMLCAG()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 684f,
					scale = 1877f,
					strength = 636f
				};
			}

			// Token: 0x060076D7 RID: 30423 RVA: 0x00242808 File Offset: 0x00240A08
			public static SMAA.PredicationSettings LOMOMPKEDPL()
			{
				return new SMAA.PredicationSettings
				{
					enabled = true,
					threshold = 118f,
					scale = 193f,
					strength = 1322f
				};
			}

			// Token: 0x04000C3F RID: 3135
			[Tooltip("Predicated thresholding allows to better preserve texture details and to improve performance, by decreasing the number of detected edges using an additional buffer (the detph buffer).\nIt locally decreases the luma or color threshold if an edge is found in an additional buffer (so the global threshold can be higher).")]
			public bool enabled;

			// Token: 0x04000C40 RID: 3136
			[Tooltip("Threshold to be used in the additional predication buffer.")]
			[Min(0.0001f)]
			public float threshold;

			// Token: 0x04000C41 RID: 3137
			[Tooltip("How much to scale the global threshold used for luma or color edge detection when using predication.")]
			[Range(1f, 5f)]
			public float scale;

			// Token: 0x04000C42 RID: 3138
			[Range(0f, 1f)]
			[Tooltip("How much to locally decrease the threshold.")]
			public float strength;
		}
	}
}
