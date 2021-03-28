using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000195 RID: 405
	[AddComponentMenu("Image Effects/Cinematic/Ambient Occlusion")]
	[ImageEffectAllowedInSceneView]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class AmbientOcclusion : MonoBehaviour
	{
		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060074E6 RID: 29926 RVA: 0x0023CD55 File Offset: 0x0023AF55
		// (set) Token: 0x060074F1 RID: 29937 RVA: 0x0023D077 File Offset: 0x0023B277
		private AmbientOcclusion.HCIBBJPOGOO EMAAIKAICLH { get; set; }

		// Token: 0x060074E7 RID: 29927 RVA: 0x0023CD5D File Offset: 0x0023AF5D
		private Shader GNJPDIAGKCP()
		{
			if (this._aoShader == null)
			{
				this._aoShader = Shader.Find("_RampOffset");
			}
			return this._aoShader;
		}

		// Token: 0x060074E8 RID: 29928 RVA: 0x0023CD86 File Offset: 0x0023AF86
		public bool BNMFKJOJGIE()
		{
			return this.GEBAOLIHMAG.allowHDR && this.JIBEJBLNBBJ == (AmbientOcclusion.OcclusionSource)8;
		}

		// Token: 0x060074E9 RID: 29929 RVA: 0x0023CDA4 File Offset: 0x0023AFA4
		private void APFDBAEILOO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			int num = (!this.CBMEICAGOHG) ? 0 : 0;
			RenderTextureFormat format = this.PJPFFCODEGH;
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default;
			bool flag = this.settings.occlusionSource == (AmbientOcclusion.OcclusionSource)4;
			Material material = this.GLFCHEPLJEO;
			RenderTexture temporary = RenderTexture.GetTemporary(width / num, height / num, 0, format, readWrite);
			Graphics.Blit(HLBKCLPNHEB, temporary, material, (int)this.PKBNGGFEBOA());
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1, format, readWrite);
			material.SetVector("DPADVER", Vector2.right * 1230f);
			Graphics.Blit(temporary, temporary2, material, (!flag) ? 7 : 8);
			RenderTexture.ReleaseTemporary(temporary);
			temporary = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector(" but this PhotonView does not exist! Was remote PV.", Vector2.up * 1734f * (float)num);
			Graphics.Blit(temporary2, temporary, material, (!flag) ? 8 : 8);
			RenderTexture.ReleaseTemporary(temporary2);
			temporary2 = RenderTexture.GetTemporary(width, height, 1, format, readWrite);
			material.SetVector(",", Vector2.right * (float)num);
			Graphics.Blit(temporary, temporary2, material, (!flag) ? 6 : 4);
			RenderTexture.ReleaseTemporary(temporary);
			temporary = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("_Value4", Vector2.up * (float)num);
			Graphics.Blit(temporary2, temporary, material, (!flag) ? 3 : 6);
			RenderTexture.ReleaseTemporary(temporary2);
			material.SetTexture("_Value3", temporary);
			if (!this.settings.debug)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, material, 2);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, material, -104);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060074EA RID: 29930 RVA: 0x0023CF89 File Offset: 0x0023B189
		private Mesh MJMHEAOENIG
		{
			get
			{
				return this._quadMesh;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x060074EB RID: 29931 RVA: 0x0023CF91 File Offset: 0x0023B191
		private RenderTextureFormat PJPFFCODEGH
		{
			get
			{
				if (SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.R8))
				{
					return RenderTextureFormat.R8;
				}
				return RenderTextureFormat.Default;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x060074EC RID: 29932 RVA: 0x0023CFA3 File Offset: 0x0023B1A3
		private float FGJCOIDIJDG
		{
			get
			{
				return Mathf.Max(this.settings.radius, 0.0001f);
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x060074ED RID: 29933 RVA: 0x0023CFBA File Offset: 0x0023B1BA
		private AmbientOcclusion.OcclusionSource JIBEJBLNBBJ
		{
			get
			{
				if (this.settings.occlusionSource == AmbientOcclusion.OcclusionSource.GBuffer && !this.isGBufferAvailable)
				{
					return AmbientOcclusion.OcclusionSource.DepthNormalsTexture;
				}
				return this.settings.occlusionSource;
			}
		}

		// Token: 0x060074EE RID: 29934 RVA: 0x0023CFE5 File Offset: 0x0023B1E5
		public bool CCMHLOCNLDI()
		{
			return this.GEBAOLIHMAG.actualRenderingPath == RenderingPath.VertexLit;
		}

		// Token: 0x060074EF RID: 29935 RVA: 0x0023CFF8 File Offset: 0x0023B1F8
		private void Update()
		{
			if (this.EMAAIKAICLH.CheckNeedsReset(this.settings, this.GEBAOLIHMAG))
			{
				this.OnDisable();
				this.OnEnable();
				if (this.ICODHLHBMHI)
				{
					this.DOHIKBLMMBK.Clear();
					this.LIALEPDMHLF();
				}
				this.EMAAIKAICLH.Update(this.settings, this.GEBAOLIHMAG);
			}
			if (this.ICODHLHBMHI)
			{
				this.AAFFNFMCIPA();
			}
		}

		// Token: 0x060074F0 RID: 29936 RVA: 0x0023CF89 File Offset: 0x0023B189
		private Mesh OGCHMNEIBMP()
		{
			return this._quadMesh;
		}

		// Token: 0x060074F2 RID: 29938 RVA: 0x0023D080 File Offset: 0x0023B280
		private void PLHMAOMGFMF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.HFPHMAPOOEB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
			else
			{
				this.AAFFNFMCIPA();
				this.HBLEDPHMDHG(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x060074F3 RID: 29939 RVA: 0x0023D0A8 File Offset: 0x0023B2A8
		private void JBBCMAJIMCA()
		{
			if (!ImageEffectHelper.IsSupported(this.KAHGJOMCEID(), true, true, this))
			{
				base.enabled = false;
				return;
			}
			if (this.HFPHMAPOOEB())
			{
				this.GEBAOLIHMAG.AddCommandBuffer((CameraEvent)(-58), this.DOHIKBLMMBK);
			}
			if (this.JIBEJBLNBBJ == AmbientOcclusion.OcclusionSource.DepthTexture)
			{
				this.GEBAOLIHMAG.depthTextureMode |= DepthTextureMode.Depth;
			}
			if (this.JIBEJBLNBBJ != (AmbientOcclusion.OcclusionSource)3)
			{
				this.GEBAOLIHMAG.depthTextureMode |= (DepthTextureMode)8;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060074F4 RID: 29940 RVA: 0x0023D12B File Offset: 0x0023B32B
		private CommandBuffer DOHIKBLMMBK
		{
			get
			{
				if (this.PBKBMKFEHJN == null)
				{
					this.PBKBMKFEHJN = new CommandBuffer();
					this.PBKBMKFEHJN.name = "AmbientOcclusion";
				}
				return this.PBKBMKFEHJN;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x060074F5 RID: 29941 RVA: 0x0023D159 File Offset: 0x0023B359
		private AmbientOcclusion.SampleCount NNGJCGPELAJ
		{
			get
			{
				return this.settings.sampleCount;
			}
		}

		// Token: 0x060074F6 RID: 29942 RVA: 0x0023CFE5 File Offset: 0x0023B1E5
		public bool DJOABPPDMIF()
		{
			return this.GEBAOLIHMAG.actualRenderingPath == RenderingPath.VertexLit;
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x060074F7 RID: 29943 RVA: 0x0023D168 File Offset: 0x0023B368
		private int AOEOFMCEGNK
		{
			get
			{
				switch (this.settings.sampleCount)
				{
				case AmbientOcclusion.SampleCount.Lowest:
					return 3;
				case AmbientOcclusion.SampleCount.Low:
					return 6;
				case AmbientOcclusion.SampleCount.Medium:
					return 12;
				case AmbientOcclusion.SampleCount.High:
					return 20;
				default:
					return Mathf.Clamp(this.settings.sampleCountValue, 1, 256);
				}
			}
		}

		// Token: 0x060074F8 RID: 29944 RVA: 0x0023D1BC File Offset: 0x0023B3BC
		private int PCHMNPFKOPM()
		{
			switch (this.settings.sampleCount)
			{
			case AmbientOcclusion.SampleCount.Lowest:
				return 8;
			case AmbientOcclusion.SampleCount.Low:
				return 8;
			case AmbientOcclusion.SampleCount.Medium:
				return 92;
			case AmbientOcclusion.SampleCount.High:
				return 90;
			default:
				return Mathf.Clamp(this.settings.sampleCountValue, 1, -147);
			}
		}

		// Token: 0x060074F9 RID: 29945 RVA: 0x0023D210 File Offset: 0x0023B410
		private void HBLEDPHMDHG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			int num = (!this.CBMEICAGOHG) ? 1 : 2;
			RenderTextureFormat format = this.PJPFFCODEGH;
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Linear;
			bool flag = this.settings.occlusionSource == AmbientOcclusion.OcclusionSource.DepthNormalsTexture;
			Material material = this.GLFCHEPLJEO;
			RenderTexture temporary = RenderTexture.GetTemporary(width / num, height / num, 1, format, readWrite);
			Graphics.Blit(HLBKCLPNHEB, temporary, material, (int)this.PKBNGGFEBOA());
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1, format, readWrite);
			material.SetVector("Drop_Far", Vector2.right * 1331f);
			Graphics.Blit(temporary, temporary2, material, (!flag) ? 7 : 7);
			RenderTexture.ReleaseTemporary(temporary);
			temporary = RenderTexture.GetTemporary(width, height, 1, format, readWrite);
			material.SetVector("_TimeX", Vector2.up * 436f * (float)num);
			Graphics.Blit(temporary2, temporary, material, (!flag) ? 0 : 3);
			RenderTexture.ReleaseTemporary(temporary2);
			temporary2 = RenderTexture.GetTemporary(width, height, 1, format, readWrite);
			material.SetVector(": ", Vector2.right * (float)num);
			Graphics.Blit(temporary, temporary2, material, (!flag) ? 7 : 4);
			RenderTexture.ReleaseTemporary(temporary);
			temporary = RenderTexture.GetTemporary(width, height, 1, format, readWrite);
			material.SetVector("Added checkpoint", Vector2.up * (float)num);
			Graphics.Blit(temporary2, temporary, material, (!flag) ? 4 : 3);
			RenderTexture.ReleaseTemporary(temporary2);
			material.SetTexture("Fill", temporary);
			if (!this.settings.debug)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, material, 8);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, material, 4);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060074FA RID: 29946 RVA: 0x0023D3F5 File Offset: 0x0023B5F5
		private Camera GEBAOLIHMAG
		{
			get
			{
				return base.GetComponent<Camera>();
			}
		}

		// Token: 0x060074FB RID: 29947 RVA: 0x0023D400 File Offset: 0x0023B600
		private void AAFFNFMCIPA()
		{
			Material material = this.GLFCHEPLJEO;
			material.SetFloat("_Intensity", this.KHLKFJAFEBB);
			material.SetFloat("_Radius", this.FGJCOIDIJDG);
			material.SetFloat("_TargetScale", (!this.CBMEICAGOHG) ? 1f : 0.5f);
			material.SetInt("_SampleCount", this.AOEOFMCEGNK);
		}

		// Token: 0x060074FC RID: 29948 RVA: 0x0023D46C File Offset: 0x0023B66C
		private AmbientOcclusion.OcclusionSource PKBNGGFEBOA()
		{
			if (this.settings.occlusionSource == (AmbientOcclusion.OcclusionSource)6 && !this.CCMHLOCNLDI())
			{
				return AmbientOcclusion.OcclusionSource.DepthTexture;
			}
			return this.settings.occlusionSource;
		}

		// Token: 0x060074FD RID: 29949 RVA: 0x0023D497 File Offset: 0x0023B697
		private void HFNLEOLNJLF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.HFPHMAPOOEB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
			else
			{
				this.AAFFNFMCIPA();
				this.EDJABGOKHKM(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x060074FE RID: 29950 RVA: 0x0023D4BE File Offset: 0x0023B6BE
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.ICODHLHBMHI)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
			else
			{
				this.AAFFNFMCIPA();
				this.EDJABGOKHKM(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x060074FF RID: 29951 RVA: 0x0023D4E5 File Offset: 0x0023B6E5
		private float OELPPBCJINH()
		{
			return Mathf.Max(this.settings.radius, 804f);
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06007500 RID: 29952 RVA: 0x0023D4FC File Offset: 0x0023B6FC
		private float KHLKFJAFEBB
		{
			get
			{
				return this.settings.intensity;
			}
		}

		// Token: 0x06007501 RID: 29953 RVA: 0x0023D497 File Offset: 0x0023B697
		private void JCCIKBBEMEB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this.HFPHMAPOOEB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
			else
			{
				this.AAFFNFMCIPA();
				this.EDJABGOKHKM(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x06007502 RID: 29954 RVA: 0x0023D50C File Offset: 0x0023B70C
		private void JAAJECBCCFM()
		{
			if (this.FMDAFIAHBBH().NIJGGJMCMEL(this.settings, this.GEBAOLIHMAG))
			{
				this.OnDisable();
				this.OnEnable();
				if (this.ICODHLHBMHI)
				{
					this.DOHIKBLMMBK.Clear();
					this.JOEMGCEAIGB();
				}
				this.EMAAIKAICLH.JHPOIOELNCG(this.settings, this.GEBAOLIHMAG);
			}
			if (this.HFPHMAPOOEB())
			{
				this.AAFFNFMCIPA();
			}
		}

		// Token: 0x06007503 RID: 29955 RVA: 0x0023CF89 File Offset: 0x0023B189
		private Mesh DENLNMENHEB()
		{
			return this._quadMesh;
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06007504 RID: 29956 RVA: 0x0023D58B File Offset: 0x0023B78B
		private bool ICODHLHBMHI
		{
			get
			{
				return this.settings.ambientOnly && !this.settings.debug && this.isAmbientOnlySupported;
			}
		}

		// Token: 0x06007505 RID: 29957 RVA: 0x0023D5B8 File Offset: 0x0023B7B8
		private void JOEMGCEAIGB()
		{
			CommandBuffer commandBuffer = this.DOHIKBLMMBK;
			int pixelWidth = this.GEBAOLIHMAG.pixelWidth;
			int pixelHeight = this.GEBAOLIHMAG.pixelHeight;
			int num = (!this.CBMEICAGOHG) ? 0 : 7;
			RenderTextureFormat format = this.PJPFFCODEGH;
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default;
			FilterMode filter = FilterMode.Point;
			Material material = this.GLFCHEPLJEO;
			int nameID = Shader.PropertyToID("_Value5");
			commandBuffer.GetTemporaryRT(nameID, pixelWidth / num, pixelHeight / num, 1, filter, format, readWrite);
			commandBuffer.Blit(null, nameID, material, 2);
			int nameID2 = Shader.PropertyToID("_Factor");
			commandBuffer.GetTemporaryRT(nameID2, pixelWidth, pixelHeight, 1, filter, format, readWrite);
			commandBuffer.SetGlobalVector("d264dbba9c2410771b4ad918903b3f4cd9e276a9", Vector2.right * 956f);
			commandBuffer.Blit(nameID, nameID2, material, 3);
			commandBuffer.ReleaseTemporaryRT(nameID);
			commandBuffer.GetTemporaryRT(nameID, pixelWidth, pixelHeight, 1, filter, format, readWrite);
			commandBuffer.SetGlobalVector("_Value4", Vector2.up * 1825f * (float)num);
			commandBuffer.Blit(nameID2, nameID, material, 6);
			commandBuffer.ReleaseTemporaryRT(nameID2);
			commandBuffer.GetTemporaryRT(nameID2, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("ChatHistoryInputField", Vector2.right * (float)num);
			commandBuffer.Blit(nameID, nameID2, material, 3);
			commandBuffer.ReleaseTemporaryRT(nameID);
			commandBuffer.GetTemporaryRT(nameID, pixelWidth, pixelHeight, 1, filter, format, readWrite);
			commandBuffer.SetGlobalVector("MenuPlayButton", Vector2.up * (float)num);
			commandBuffer.Blit(nameID2, nameID, material, 0);
			commandBuffer.ReleaseTemporaryRT(nameID2);
			RenderTargetIdentifier[] array = new RenderTargetIdentifier[8];
			array[1] = BuiltinRenderTextureType.PrepassLight;
			array[0] = BuiltinRenderTextureType.CurrentActive;
			RenderTargetIdentifier[] colors = array;
			commandBuffer.SetRenderTarget(colors, BuiltinRenderTextureType.Depth);
			commandBuffer.SetGlobalTexture("0,1,false", nameID);
			commandBuffer.DrawMesh(this.JELKNECCHHD(), Matrix4x4.identity, material, 0, 3);
			commandBuffer.ReleaseTemporaryRT(nameID);
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06007506 RID: 29958 RVA: 0x0023D7F2 File Offset: 0x0023B9F2
		private bool CBMEICAGOHG
		{
			get
			{
				return this.settings.downsampling;
			}
		}

		// Token: 0x06007507 RID: 29959 RVA: 0x0023CD55 File Offset: 0x0023AF55
		private AmbientOcclusion.HCIBBJPOGOO FMDAFIAHBBH()
		{
			return this.<JGEBLMCOIAF>k__BackingField;
		}

		// Token: 0x06007508 RID: 29960 RVA: 0x0023D800 File Offset: 0x0023BA00
		private void OnEnable()
		{
			if (!ImageEffectHelper.IsSupported(this.KHGEHEPDCJG, true, false, this))
			{
				base.enabled = false;
				return;
			}
			if (this.ICODHLHBMHI)
			{
				this.GEBAOLIHMAG.AddCommandBuffer(CameraEvent.BeforeReflections, this.DOHIKBLMMBK);
			}
			if (this.JIBEJBLNBBJ == AmbientOcclusion.OcclusionSource.DepthTexture)
			{
				this.GEBAOLIHMAG.depthTextureMode |= DepthTextureMode.Depth;
			}
			if (this.JIBEJBLNBBJ != AmbientOcclusion.OcclusionSource.GBuffer)
			{
				this.GEBAOLIHMAG.depthTextureMode |= DepthTextureMode.DepthNormals;
			}
		}

		// Token: 0x06007509 RID: 29961 RVA: 0x0023CF89 File Offset: 0x0023B189
		private Mesh JELKNECCHHD()
		{
			return this._quadMesh;
		}

		// Token: 0x0600750A RID: 29962 RVA: 0x0023D884 File Offset: 0x0023BA84
		private void OnDisable()
		{
			if (this.NCPEICNIJHG != null)
			{
				UnityEngine.Object.DestroyImmediate(this.NCPEICNIJHG);
			}
			this.NCPEICNIJHG = null;
			if (this.PBKBMKFEHJN != null)
			{
				this.GEBAOLIHMAG.RemoveCommandBuffer(CameraEvent.BeforeReflections, this.PBKBMKFEHJN);
			}
			this.PBKBMKFEHJN = null;
		}

		// Token: 0x0600750C RID: 29964 RVA: 0x0023D8EC File Offset: 0x0023BAEC
		private float NNJHPLDGGOG()
		{
			return Mathf.Max(this.settings.radius, 1607f);
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x0600750D RID: 29965 RVA: 0x0023D903 File Offset: 0x0023BB03
		private Shader KHGEHEPDCJG
		{
			get
			{
				if (this._aoShader == null)
				{
					this._aoShader = Shader.Find("Hidden/Image Effects/Cinematic/AmbientOcclusion");
				}
				return this._aoShader;
			}
		}

		// Token: 0x0600750E RID: 29966 RVA: 0x0023D92C File Offset: 0x0023BB2C
		private void OCMKCBBCEFG()
		{
			if (this.EMAAIKAICLH.NIJGGJMCMEL(this.settings, this.GEBAOLIHMAG))
			{
				this.OnDisable();
				this.OnEnable();
				if (this.ICODHLHBMHI)
				{
					this.DOHIKBLMMBK.Clear();
					this.IOHNMHJEIAH();
				}
				this.FMDAFIAHBBH().AGMJDGHLBMN(this.settings, this.GEBAOLIHMAG);
			}
			if (this.HFPHMAPOOEB())
			{
				this.AAFFNFMCIPA();
			}
		}

		// Token: 0x0600750F RID: 29967 RVA: 0x0023D9AC File Offset: 0x0023BBAC
		private void LIALEPDMHLF()
		{
			CommandBuffer commandBuffer = this.DOHIKBLMMBK;
			int pixelWidth = this.GEBAOLIHMAG.pixelWidth;
			int pixelHeight = this.GEBAOLIHMAG.pixelHeight;
			int num = (!this.CBMEICAGOHG) ? 1 : 2;
			RenderTextureFormat format = this.PJPFFCODEGH;
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Linear;
			FilterMode filter = FilterMode.Bilinear;
			Material material = this.GLFCHEPLJEO;
			int nameID = Shader.PropertyToID("_OcclusionTexture");
			commandBuffer.GetTemporaryRT(nameID, pixelWidth / num, pixelHeight / num, 0, filter, format, readWrite);
			commandBuffer.Blit(null, nameID, material, 2);
			int nameID2 = Shader.PropertyToID("_OcclusionBlurTexture");
			commandBuffer.GetTemporaryRT(nameID2, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("_BlurVector", Vector2.right * 2f);
			commandBuffer.Blit(nameID, nameID2, material, 4);
			commandBuffer.ReleaseTemporaryRT(nameID);
			commandBuffer.GetTemporaryRT(nameID, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("_BlurVector", Vector2.up * 2f * (float)num);
			commandBuffer.Blit(nameID2, nameID, material, 4);
			commandBuffer.ReleaseTemporaryRT(nameID2);
			commandBuffer.GetTemporaryRT(nameID2, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("_BlurVector", Vector2.right * (float)num);
			commandBuffer.Blit(nameID, nameID2, material, 6);
			commandBuffer.ReleaseTemporaryRT(nameID);
			commandBuffer.GetTemporaryRT(nameID, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("_BlurVector", Vector2.up * (float)num);
			commandBuffer.Blit(nameID2, nameID, material, 6);
			commandBuffer.ReleaseTemporaryRT(nameID2);
			RenderTargetIdentifier[] colors = new RenderTargetIdentifier[]
			{
				BuiltinRenderTextureType.GBuffer0,
				BuiltinRenderTextureType.CameraTarget
			};
			commandBuffer.SetRenderTarget(colors, BuiltinRenderTextureType.CameraTarget);
			commandBuffer.SetGlobalTexture("_OcclusionTexture", nameID);
			commandBuffer.DrawMesh(this.MJMHEAOENIG, Matrix4x4.identity, material, 0, 8);
			commandBuffer.ReleaseTemporaryRT(nameID);
		}

		// Token: 0x06007510 RID: 29968 RVA: 0x0023DBE6 File Offset: 0x0023BDE6
		private Shader KAHGJOMCEID()
		{
			if (this._aoShader == null)
			{
				this._aoShader = Shader.Find("Mouse Y");
			}
			return this._aoShader;
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06007511 RID: 29969 RVA: 0x0023DC0F File Offset: 0x0023BE0F
		private Material GLFCHEPLJEO
		{
			get
			{
				if (this.NCPEICNIJHG == null)
				{
					this.NCPEICNIJHG = ImageEffectHelper.CheckShaderAndCreateMaterial(this.KHGEHEPDCJG);
				}
				return this.NCPEICNIJHG;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06007512 RID: 29970 RVA: 0x0023DC39 File Offset: 0x0023BE39
		public bool isAmbientOnlySupported
		{
			get
			{
				return this.GEBAOLIHMAG.allowHDR && this.JIBEJBLNBBJ == AmbientOcclusion.OcclusionSource.GBuffer;
			}
		}

		// Token: 0x06007513 RID: 29971 RVA: 0x0023CF89 File Offset: 0x0023B189
		private Mesh FALNGJIMLED()
		{
			return this._quadMesh;
		}

		// Token: 0x06007514 RID: 29972 RVA: 0x0023DC58 File Offset: 0x0023BE58
		private void IOHNMHJEIAH()
		{
			CommandBuffer commandBuffer = this.DOHIKBLMMBK;
			int pixelWidth = this.GEBAOLIHMAG.pixelWidth;
			int pixelHeight = this.GEBAOLIHMAG.pixelHeight;
			int num = (!this.CBMEICAGOHG) ? 1 : 3;
			RenderTextureFormat format = this.PJPFFCODEGH;
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Default;
			FilterMode filter = FilterMode.Bilinear;
			Material material = this.GLFCHEPLJEO;
			int nameID = Shader.PropertyToID("note.0");
			commandBuffer.GetTemporaryRT(nameID, pixelWidth / num, pixelHeight / num, 0, filter, format, readWrite);
			commandBuffer.Blit(null, nameID, material, 1);
			int nameID2 = Shader.PropertyToID("' has been reset to the fault value");
			commandBuffer.GetTemporaryRT(nameID2, pixelWidth, pixelHeight, 1, filter, format, readWrite);
			commandBuffer.SetGlobalVector("Uploading preview image...", Vector2.right * 838f);
			commandBuffer.Blit(nameID, nameID2, material, 8);
			commandBuffer.ReleaseTemporaryRT(nameID);
			commandBuffer.GetTemporaryRT(nameID, pixelWidth, pixelHeight, 1, filter, format, readWrite);
			commandBuffer.SetGlobalVector("JITTER", Vector2.up * 1528f * (float)num);
			commandBuffer.Blit(nameID2, nameID, material, 6);
			commandBuffer.ReleaseTemporaryRT(nameID2);
			commandBuffer.GetTemporaryRT(nameID2, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("setAF", Vector2.right * (float)num);
			commandBuffer.Blit(nameID, nameID2, material, 3);
			commandBuffer.ReleaseTemporaryRT(nameID);
			commandBuffer.GetTemporaryRT(nameID, pixelWidth, pixelHeight, 0, filter, format, readWrite);
			commandBuffer.SetGlobalVector("_BorderColor", Vector2.up * (float)num);
			commandBuffer.Blit(nameID2, nameID, material, 3);
			commandBuffer.ReleaseTemporaryRT(nameID2);
			RenderTargetIdentifier[] array = new RenderTargetIdentifier[8];
			array[1] = (BuiltinRenderTextureType)110;
			array[1] = (BuiltinRenderTextureType)6;
			RenderTargetIdentifier[] colors = array;
			commandBuffer.SetRenderTarget(colors, BuiltinRenderTextureType.CameraTarget);
			commandBuffer.SetGlobalTexture("{0} years ago", nameID);
			commandBuffer.DrawMesh(this.OGCHMNEIBMP(), Matrix4x4.identity, material, 0, 0);
			commandBuffer.ReleaseTemporaryRT(nameID);
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06007515 RID: 29973 RVA: 0x0023DE92 File Offset: 0x0023C092
		public bool isGBufferAvailable
		{
			get
			{
				return this.GEBAOLIHMAG.actualRenderingPath == RenderingPath.DeferredShading;
			}
		}

		// Token: 0x06007516 RID: 29974 RVA: 0x0023DEA2 File Offset: 0x0023C0A2
		private bool HFPHMAPOOEB()
		{
			return !this.settings.ambientOnly || this.settings.debug || this.BNMFKJOJGIE();
		}

		// Token: 0x06007517 RID: 29975 RVA: 0x0023DED0 File Offset: 0x0023C0D0
		private void EDJABGOKHKM(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			int num = (!this.CBMEICAGOHG) ? 1 : 2;
			RenderTextureFormat format = this.PJPFFCODEGH;
			RenderTextureReadWrite readWrite = RenderTextureReadWrite.Linear;
			bool flag = this.settings.occlusionSource == AmbientOcclusion.OcclusionSource.GBuffer;
			Material material = this.GLFCHEPLJEO;
			RenderTexture temporary = RenderTexture.GetTemporary(width / num, height / num, 0, format, readWrite);
			Graphics.Blit(HLBKCLPNHEB, temporary, material, (int)this.JIBEJBLNBBJ);
			RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("_BlurVector", Vector2.right * 2f);
			Graphics.Blit(temporary, temporary2, material, (!flag) ? 3 : 4);
			RenderTexture.ReleaseTemporary(temporary);
			temporary = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("_BlurVector", Vector2.up * 2f * (float)num);
			Graphics.Blit(temporary2, temporary, material, (!flag) ? 3 : 4);
			RenderTexture.ReleaseTemporary(temporary2);
			temporary2 = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("_BlurVector", Vector2.right * (float)num);
			Graphics.Blit(temporary, temporary2, material, (!flag) ? 5 : 6);
			RenderTexture.ReleaseTemporary(temporary);
			temporary = RenderTexture.GetTemporary(width, height, 0, format, readWrite);
			material.SetVector("_BlurVector", Vector2.up * (float)num);
			Graphics.Blit(temporary2, temporary, material, (!flag) ? 5 : 6);
			RenderTexture.ReleaseTemporary(temporary2);
			material.SetTexture("_OcclusionTexture", temporary);
			if (!this.settings.debug)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, material, 7);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, material, 9);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06007518 RID: 29976 RVA: 0x0023E0B5 File Offset: 0x0023C2B5
		public bool AKGMOFLOHOK()
		{
			return this.GEBAOLIHMAG.actualRenderingPath == (RenderingPath)8;
		}

		// Token: 0x04000BDE RID: 3038
		[SerializeField]
		public AmbientOcclusion.Settings settings = AmbientOcclusion.Settings.defaultSettings;

		// Token: 0x04000BDF RID: 3039
		[SerializeField]
		private Shader _aoShader;

		// Token: 0x04000BE0 RID: 3040
		private Material NCPEICNIJHG;

		// Token: 0x04000BE1 RID: 3041
		private CommandBuffer PBKBMKFEHJN;

		// Token: 0x04000BE3 RID: 3043
		[SerializeField]
		private Mesh _quadMesh;

		// Token: 0x02000196 RID: 406
		private struct HCIBBJPOGOO
		{
			// Token: 0x06007519 RID: 29977 RVA: 0x0023E0C8 File Offset: 0x0023C2C8
			public void IIFCIDDJHPM(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				this.OEGOOCPNLKC = INLOKEFEKCF.downsampling;
				this.OIDJNNLAKOF = INLOKEFEKCF.occlusionSource;
				this.EOIFCKEFFDK = INLOKEFEKCF.ambientOnly;
				this.MGHNPADDNED = INLOKEFEKCF.debug;
				this.GEBLONIIAPL = CPHDLGANKHG.pixelWidth;
				this.ENOGALBJCJB = CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x0600751A RID: 29978 RVA: 0x0023E120 File Offset: 0x0023C320
			public void Update(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				this.OEGOOCPNLKC = INLOKEFEKCF.downsampling;
				this.OIDJNNLAKOF = INLOKEFEKCF.occlusionSource;
				this.EOIFCKEFFDK = INLOKEFEKCF.ambientOnly;
				this.MGHNPADDNED = INLOKEFEKCF.debug;
				this.GEBLONIIAPL = CPHDLGANKHG.pixelWidth;
				this.ENOGALBJCJB = CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x0600751B RID: 29979 RVA: 0x0023E178 File Offset: 0x0023C378
			public bool IDJOHMGNPON(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				return this.OEGOOCPNLKC == INLOKEFEKCF.downsampling && this.OIDJNNLAKOF == INLOKEFEKCF.occlusionSource && this.EOIFCKEFFDK == INLOKEFEKCF.ambientOnly && this.MGHNPADDNED == INLOKEFEKCF.debug && this.GEBLONIIAPL == CPHDLGANKHG.pixelWidth && this.ENOGALBJCJB != CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x0600751C RID: 29980 RVA: 0x0023E1F0 File Offset: 0x0023C3F0
			public bool KOEKHPBBGIN(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				return this.OEGOOCPNLKC == INLOKEFEKCF.downsampling && this.OIDJNNLAKOF == INLOKEFEKCF.occlusionSource && this.EOIFCKEFFDK == INLOKEFEKCF.ambientOnly && this.MGHNPADDNED == INLOKEFEKCF.debug && this.GEBLONIIAPL == CPHDLGANKHG.pixelWidth && this.ENOGALBJCJB != CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x0600751D RID: 29981 RVA: 0x0023E268 File Offset: 0x0023C468
			public void GPFJMKCGHGB(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				this.OEGOOCPNLKC = INLOKEFEKCF.downsampling;
				this.OIDJNNLAKOF = INLOKEFEKCF.occlusionSource;
				this.EOIFCKEFFDK = INLOKEFEKCF.ambientOnly;
				this.MGHNPADDNED = INLOKEFEKCF.debug;
				this.GEBLONIIAPL = CPHDLGANKHG.pixelWidth;
				this.ENOGALBJCJB = CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x0600751E RID: 29982 RVA: 0x0023E2C0 File Offset: 0x0023C4C0
			public void FABKIGNFECE(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				this.OEGOOCPNLKC = INLOKEFEKCF.downsampling;
				this.OIDJNNLAKOF = INLOKEFEKCF.occlusionSource;
				this.EOIFCKEFFDK = INLOKEFEKCF.ambientOnly;
				this.MGHNPADDNED = INLOKEFEKCF.debug;
				this.GEBLONIIAPL = CPHDLGANKHG.pixelWidth;
				this.ENOGALBJCJB = CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x0600751F RID: 29983 RVA: 0x0023E318 File Offset: 0x0023C518
			public void MFMIODIAKNI(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				this.OEGOOCPNLKC = INLOKEFEKCF.downsampling;
				this.OIDJNNLAKOF = INLOKEFEKCF.occlusionSource;
				this.EOIFCKEFFDK = INLOKEFEKCF.ambientOnly;
				this.MGHNPADDNED = INLOKEFEKCF.debug;
				this.GEBLONIIAPL = CPHDLGANKHG.pixelWidth;
				this.ENOGALBJCJB = CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x06007520 RID: 29984 RVA: 0x0023E370 File Offset: 0x0023C570
			public bool OOLGKPGLCFO(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				return this.OEGOOCPNLKC != INLOKEFEKCF.downsampling || this.OIDJNNLAKOF != INLOKEFEKCF.occlusionSource || this.EOIFCKEFFDK != INLOKEFEKCF.ambientOnly || this.MGHNPADDNED != INLOKEFEKCF.debug || this.GEBLONIIAPL != CPHDLGANKHG.pixelWidth || this.ENOGALBJCJB == CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x06007521 RID: 29985 RVA: 0x0023E3E8 File Offset: 0x0023C5E8
			public bool PHLOLLCMCGB(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				return this.OEGOOCPNLKC == INLOKEFEKCF.downsampling && this.OIDJNNLAKOF == INLOKEFEKCF.occlusionSource && this.EOIFCKEFFDK == INLOKEFEKCF.ambientOnly && this.MGHNPADDNED == INLOKEFEKCF.debug && this.GEBLONIIAPL == CPHDLGANKHG.pixelWidth && this.ENOGALBJCJB == CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x06007522 RID: 29986 RVA: 0x0023E460 File Offset: 0x0023C660
			public bool DJAHLJLBGHH(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				return this.OEGOOCPNLKC != INLOKEFEKCF.downsampling || this.OIDJNNLAKOF != INLOKEFEKCF.occlusionSource || this.EOIFCKEFFDK != INLOKEFEKCF.ambientOnly || this.MGHNPADDNED != INLOKEFEKCF.debug || this.GEBLONIIAPL != CPHDLGANKHG.pixelWidth || this.ENOGALBJCJB != CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x06007523 RID: 29987 RVA: 0x0023E4D8 File Offset: 0x0023C6D8
			public bool IBIACACIPIH(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				return this.OEGOOCPNLKC == INLOKEFEKCF.downsampling && this.OIDJNNLAKOF == INLOKEFEKCF.occlusionSource && this.EOIFCKEFFDK == INLOKEFEKCF.ambientOnly && this.MGHNPADDNED == INLOKEFEKCF.debug && this.GEBLONIIAPL == CPHDLGANKHG.pixelWidth && this.ENOGALBJCJB != CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x06007524 RID: 29988 RVA: 0x0023E550 File Offset: 0x0023C750
			public bool EPLBLAKFNLI(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				return this.OEGOOCPNLKC != INLOKEFEKCF.downsampling || this.OIDJNNLAKOF != INLOKEFEKCF.occlusionSource || this.EOIFCKEFFDK != INLOKEFEKCF.ambientOnly || this.MGHNPADDNED != INLOKEFEKCF.debug || this.GEBLONIIAPL != CPHDLGANKHG.pixelWidth || this.ENOGALBJCJB == CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x06007525 RID: 29989 RVA: 0x0023E5C8 File Offset: 0x0023C7C8
			public bool FOHKICBNALP(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				return this.OEGOOCPNLKC != INLOKEFEKCF.downsampling || this.OIDJNNLAKOF != INLOKEFEKCF.occlusionSource || this.EOIFCKEFFDK != INLOKEFEKCF.ambientOnly || this.MGHNPADDNED != INLOKEFEKCF.debug || this.GEBLONIIAPL != CPHDLGANKHG.pixelWidth || this.ENOGALBJCJB != CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x06007526 RID: 29990 RVA: 0x0023E640 File Offset: 0x0023C840
			public bool PMIFIOIANHC(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				return this.OEGOOCPNLKC == INLOKEFEKCF.downsampling && this.OIDJNNLAKOF == INLOKEFEKCF.occlusionSource && this.EOIFCKEFFDK == INLOKEFEKCF.ambientOnly && this.MGHNPADDNED == INLOKEFEKCF.debug && this.GEBLONIIAPL == CPHDLGANKHG.pixelWidth && this.ENOGALBJCJB != CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x06007527 RID: 29991 RVA: 0x0023E6B8 File Offset: 0x0023C8B8
			public bool ONLPJAABMHF(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				return this.OEGOOCPNLKC == INLOKEFEKCF.downsampling && this.OIDJNNLAKOF == INLOKEFEKCF.occlusionSource && this.EOIFCKEFFDK == INLOKEFEKCF.ambientOnly && this.MGHNPADDNED == INLOKEFEKCF.debug && this.GEBLONIIAPL == CPHDLGANKHG.pixelWidth && this.ENOGALBJCJB != CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x06007528 RID: 29992 RVA: 0x0023E730 File Offset: 0x0023C930
			public void JHPOIOELNCG(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				this.OEGOOCPNLKC = INLOKEFEKCF.downsampling;
				this.OIDJNNLAKOF = INLOKEFEKCF.occlusionSource;
				this.EOIFCKEFFDK = INLOKEFEKCF.ambientOnly;
				this.MGHNPADDNED = INLOKEFEKCF.debug;
				this.GEBLONIIAPL = CPHDLGANKHG.pixelWidth;
				this.ENOGALBJCJB = CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x06007529 RID: 29993 RVA: 0x0023E788 File Offset: 0x0023C988
			public void OCMKCBBCEFG(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				this.OEGOOCPNLKC = INLOKEFEKCF.downsampling;
				this.OIDJNNLAKOF = INLOKEFEKCF.occlusionSource;
				this.EOIFCKEFFDK = INLOKEFEKCF.ambientOnly;
				this.MGHNPADDNED = INLOKEFEKCF.debug;
				this.GEBLONIIAPL = CPHDLGANKHG.pixelWidth;
				this.ENOGALBJCJB = CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x0600752A RID: 29994 RVA: 0x0023E7E0 File Offset: 0x0023C9E0
			public void JOACBIEHHCE(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				this.OEGOOCPNLKC = INLOKEFEKCF.downsampling;
				this.OIDJNNLAKOF = INLOKEFEKCF.occlusionSource;
				this.EOIFCKEFFDK = INLOKEFEKCF.ambientOnly;
				this.MGHNPADDNED = INLOKEFEKCF.debug;
				this.GEBLONIIAPL = CPHDLGANKHG.pixelWidth;
				this.ENOGALBJCJB = CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x0600752B RID: 29995 RVA: 0x0023E838 File Offset: 0x0023CA38
			public void FABMDEHEDNO(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				this.OEGOOCPNLKC = INLOKEFEKCF.downsampling;
				this.OIDJNNLAKOF = INLOKEFEKCF.occlusionSource;
				this.EOIFCKEFFDK = INLOKEFEKCF.ambientOnly;
				this.MGHNPADDNED = INLOKEFEKCF.debug;
				this.GEBLONIIAPL = CPHDLGANKHG.pixelWidth;
				this.ENOGALBJCJB = CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x0600752C RID: 29996 RVA: 0x0023E890 File Offset: 0x0023CA90
			public bool IPFJCIMHCIF(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				return this.OEGOOCPNLKC == INLOKEFEKCF.downsampling && this.OIDJNNLAKOF == INLOKEFEKCF.occlusionSource && this.EOIFCKEFFDK == INLOKEFEKCF.ambientOnly && this.MGHNPADDNED == INLOKEFEKCF.debug && this.GEBLONIIAPL == CPHDLGANKHG.pixelWidth && this.ENOGALBJCJB != CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x0600752D RID: 29997 RVA: 0x0023E908 File Offset: 0x0023CB08
			public void BGDONBMDPGM(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				this.OEGOOCPNLKC = INLOKEFEKCF.downsampling;
				this.OIDJNNLAKOF = INLOKEFEKCF.occlusionSource;
				this.EOIFCKEFFDK = INLOKEFEKCF.ambientOnly;
				this.MGHNPADDNED = INLOKEFEKCF.debug;
				this.GEBLONIIAPL = CPHDLGANKHG.pixelWidth;
				this.ENOGALBJCJB = CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x0600752E RID: 29998 RVA: 0x0023E960 File Offset: 0x0023CB60
			public bool DPJCJGKCFEH(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				return this.OEGOOCPNLKC == INLOKEFEKCF.downsampling && this.OIDJNNLAKOF == INLOKEFEKCF.occlusionSource && this.EOIFCKEFFDK == INLOKEFEKCF.ambientOnly && this.MGHNPADDNED == INLOKEFEKCF.debug && this.GEBLONIIAPL == CPHDLGANKHG.pixelWidth && this.ENOGALBJCJB != CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x0600752F RID: 29999 RVA: 0x0023E9D8 File Offset: 0x0023CBD8
			public void MAOCOEGAFND(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				this.OEGOOCPNLKC = INLOKEFEKCF.downsampling;
				this.OIDJNNLAKOF = INLOKEFEKCF.occlusionSource;
				this.EOIFCKEFFDK = INLOKEFEKCF.ambientOnly;
				this.MGHNPADDNED = INLOKEFEKCF.debug;
				this.GEBLONIIAPL = CPHDLGANKHG.pixelWidth;
				this.ENOGALBJCJB = CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x06007530 RID: 30000 RVA: 0x0023EA30 File Offset: 0x0023CC30
			public bool OLNBCMDNMMH(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				return this.OEGOOCPNLKC != INLOKEFEKCF.downsampling || this.OIDJNNLAKOF != INLOKEFEKCF.occlusionSource || this.EOIFCKEFFDK != INLOKEFEKCF.ambientOnly || this.MGHNPADDNED != INLOKEFEKCF.debug || this.GEBLONIIAPL != CPHDLGANKHG.pixelWidth || this.ENOGALBJCJB != CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x06007531 RID: 30001 RVA: 0x0023EAA8 File Offset: 0x0023CCA8
			public bool NIJGGJMCMEL(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				return this.OEGOOCPNLKC == INLOKEFEKCF.downsampling && this.OIDJNNLAKOF == INLOKEFEKCF.occlusionSource && this.EOIFCKEFFDK == INLOKEFEKCF.ambientOnly && this.MGHNPADDNED == INLOKEFEKCF.debug && this.GEBLONIIAPL == CPHDLGANKHG.pixelWidth && this.ENOGALBJCJB == CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x06007532 RID: 30002 RVA: 0x0023EB20 File Offset: 0x0023CD20
			public bool HIEFNFKKEEA(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				return this.OEGOOCPNLKC != INLOKEFEKCF.downsampling || this.OIDJNNLAKOF != INLOKEFEKCF.occlusionSource || this.EOIFCKEFFDK != INLOKEFEKCF.ambientOnly || this.MGHNPADDNED != INLOKEFEKCF.debug || this.GEBLONIIAPL != CPHDLGANKHG.pixelWidth || this.ENOGALBJCJB == CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x06007533 RID: 30003 RVA: 0x0023EB98 File Offset: 0x0023CD98
			public void AIJGAJIOJDJ(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				this.OEGOOCPNLKC = INLOKEFEKCF.downsampling;
				this.OIDJNNLAKOF = INLOKEFEKCF.occlusionSource;
				this.EOIFCKEFFDK = INLOKEFEKCF.ambientOnly;
				this.MGHNPADDNED = INLOKEFEKCF.debug;
				this.GEBLONIIAPL = CPHDLGANKHG.pixelWidth;
				this.ENOGALBJCJB = CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x06007534 RID: 30004 RVA: 0x0023EBF0 File Offset: 0x0023CDF0
			public void AGMJDGHLBMN(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				this.OEGOOCPNLKC = INLOKEFEKCF.downsampling;
				this.OIDJNNLAKOF = INLOKEFEKCF.occlusionSource;
				this.EOIFCKEFFDK = INLOKEFEKCF.ambientOnly;
				this.MGHNPADDNED = INLOKEFEKCF.debug;
				this.GEBLONIIAPL = CPHDLGANKHG.pixelWidth;
				this.ENOGALBJCJB = CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x06007535 RID: 30005 RVA: 0x0023EC48 File Offset: 0x0023CE48
			public bool HIOCPMEDPNJ(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				return this.OEGOOCPNLKC == INLOKEFEKCF.downsampling && this.OIDJNNLAKOF == INLOKEFEKCF.occlusionSource && this.EOIFCKEFFDK == INLOKEFEKCF.ambientOnly && this.MGHNPADDNED == INLOKEFEKCF.debug && this.GEBLONIIAPL == CPHDLGANKHG.pixelWidth && this.ENOGALBJCJB == CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x06007536 RID: 30006 RVA: 0x0023ECC0 File Offset: 0x0023CEC0
			public bool CheckNeedsReset(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				return this.OEGOOCPNLKC != INLOKEFEKCF.downsampling || this.OIDJNNLAKOF != INLOKEFEKCF.occlusionSource || this.EOIFCKEFFDK != INLOKEFEKCF.ambientOnly || this.MGHNPADDNED != INLOKEFEKCF.debug || this.GEBLONIIAPL != CPHDLGANKHG.pixelWidth || this.ENOGALBJCJB != CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x06007537 RID: 30007 RVA: 0x0023ED38 File Offset: 0x0023CF38
			public bool EGKCACKBLFI(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				return this.OEGOOCPNLKC != INLOKEFEKCF.downsampling || this.OIDJNNLAKOF != INLOKEFEKCF.occlusionSource || this.EOIFCKEFFDK != INLOKEFEKCF.ambientOnly || this.MGHNPADDNED != INLOKEFEKCF.debug || this.GEBLONIIAPL != CPHDLGANKHG.pixelWidth || this.ENOGALBJCJB == CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x06007538 RID: 30008 RVA: 0x0023EDB0 File Offset: 0x0023CFB0
			public bool FDNGIFAOICB(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				return this.OEGOOCPNLKC == INLOKEFEKCF.downsampling && this.OIDJNNLAKOF == INLOKEFEKCF.occlusionSource && this.EOIFCKEFFDK == INLOKEFEKCF.ambientOnly && this.MGHNPADDNED == INLOKEFEKCF.debug && this.GEBLONIIAPL == CPHDLGANKHG.pixelWidth && this.ENOGALBJCJB != CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x06007539 RID: 30009 RVA: 0x0023EE28 File Offset: 0x0023D028
			public bool JGOHDAHODAE(AmbientOcclusion.Settings INLOKEFEKCF, Camera CPHDLGANKHG)
			{
				return this.OEGOOCPNLKC == INLOKEFEKCF.downsampling && this.OIDJNNLAKOF == INLOKEFEKCF.occlusionSource && this.EOIFCKEFFDK == INLOKEFEKCF.ambientOnly && this.MGHNPADDNED == INLOKEFEKCF.debug && this.GEBLONIIAPL == CPHDLGANKHG.pixelWidth && this.ENOGALBJCJB != CPHDLGANKHG.pixelHeight;
			}

			// Token: 0x04000BE4 RID: 3044
			private bool OEGOOCPNLKC;

			// Token: 0x04000BE5 RID: 3045
			private AmbientOcclusion.OcclusionSource OIDJNNLAKOF;

			// Token: 0x04000BE6 RID: 3046
			private bool EOIFCKEFFDK;

			// Token: 0x04000BE7 RID: 3047
			private bool MGHNPADDNED;

			// Token: 0x04000BE8 RID: 3048
			private int GEBLONIIAPL;

			// Token: 0x04000BE9 RID: 3049
			private int ENOGALBJCJB;
		}

		// Token: 0x02000197 RID: 407
		public enum SampleCount
		{
			// Token: 0x04000BEB RID: 3051
			Lowest,
			// Token: 0x04000BEC RID: 3052
			Low,
			// Token: 0x04000BED RID: 3053
			Medium,
			// Token: 0x04000BEE RID: 3054
			High,
			// Token: 0x04000BEF RID: 3055
			Variable
		}

		// Token: 0x02000198 RID: 408
		public enum OcclusionSource
		{
			// Token: 0x04000BF1 RID: 3057
			DepthTexture,
			// Token: 0x04000BF2 RID: 3058
			DepthNormalsTexture,
			// Token: 0x04000BF3 RID: 3059
			GBuffer
		}

		// Token: 0x02000199 RID: 409
		[Serializable]
		public class Settings
		{
			// Token: 0x0600753A RID: 30010 RVA: 0x0023EEA0 File Offset: 0x0023D0A0
			public static AmbientOcclusion.Settings LOMOMPKEDPL()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 336f,
					radius = 282f,
					sampleCount = AmbientOcclusion.SampleCount.Low,
					sampleCountValue = 57,
					downsampling = false,
					ambientOnly = false,
					occlusionSource = AmbientOcclusion.OcclusionSource.DepthNormalsTexture
				};
			}

			// Token: 0x0600753B RID: 30011 RVA: 0x0023EEF0 File Offset: 0x0023D0F0
			public static AmbientOcclusion.Settings NIPPCMNKCMB()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 14f,
					radius = 452f,
					sampleCount = AmbientOcclusion.SampleCount.Medium,
					sampleCountValue = 110,
					downsampling = false,
					ambientOnly = false,
					occlusionSource = AmbientOcclusion.OcclusionSource.DepthNormalsTexture
				};
			}

			// Token: 0x0600753C RID: 30012 RVA: 0x0023EF40 File Offset: 0x0023D140
			public static AmbientOcclusion.Settings INDEHPGLEGK()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 884f,
					radius = 1367f,
					sampleCount = AmbientOcclusion.SampleCount.Medium,
					sampleCountValue = -8,
					downsampling = false,
					ambientOnly = false,
					occlusionSource = AmbientOcclusion.OcclusionSource.DepthTexture
				};
			}

			// Token: 0x0600753D RID: 30013 RVA: 0x0023EF90 File Offset: 0x0023D190
			public static AmbientOcclusion.Settings EJLLADABOLM()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 1722f,
					radius = 563f,
					sampleCount = AmbientOcclusion.SampleCount.High,
					sampleCountValue = -121,
					downsampling = false,
					ambientOnly = false,
					occlusionSource = AmbientOcclusion.OcclusionSource.DepthNormalsTexture
				};
			}

			// Token: 0x0600753E RID: 30014 RVA: 0x0023EFE0 File Offset: 0x0023D1E0
			public static AmbientOcclusion.Settings BCOPOEIJONI()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 962f,
					radius = 427f,
					sampleCount = (AmbientOcclusion.SampleCount)6,
					sampleCountValue = 106,
					downsampling = false,
					ambientOnly = true,
					occlusionSource = AmbientOcclusion.OcclusionSource.DepthTexture
				};
			}

			// Token: 0x0600753F RID: 30015 RVA: 0x0023F030 File Offset: 0x0023D230
			public static AmbientOcclusion.Settings CCADIDPNEKH()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 800f,
					radius = 1627f,
					sampleCount = (AmbientOcclusion.SampleCount)8,
					sampleCountValue = -9,
					downsampling = true,
					ambientOnly = false,
					occlusionSource = AmbientOcclusion.OcclusionSource.DepthNormalsTexture
				};
			}

			// Token: 0x06007540 RID: 30016 RVA: 0x0023F080 File Offset: 0x0023D280
			public static AmbientOcclusion.Settings MHIHHBMBDLP()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 1429f,
					radius = 173f,
					sampleCount = (AmbientOcclusion.SampleCount)6,
					sampleCountValue = -16,
					downsampling = true,
					ambientOnly = false,
					occlusionSource = AmbientOcclusion.OcclusionSource.DepthNormalsTexture
				};
			}

			// Token: 0x06007541 RID: 30017 RVA: 0x0023F0D0 File Offset: 0x0023D2D0
			public static AmbientOcclusion.Settings DBDJKKLMCGG()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 1864f,
					radius = 942f,
					sampleCount = (AmbientOcclusion.SampleCount)7,
					sampleCountValue = -1,
					downsampling = false,
					ambientOnly = true,
					occlusionSource = AmbientOcclusion.OcclusionSource.DepthTexture
				};
			}

			// Token: 0x06007542 RID: 30018 RVA: 0x0023F120 File Offset: 0x0023D320
			public static AmbientOcclusion.Settings IHMKIGDJKAH()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 1542f,
					radius = 37f,
					sampleCount = (AmbientOcclusion.SampleCount)5,
					sampleCountValue = 112,
					downsampling = true,
					ambientOnly = true,
					occlusionSource = AmbientOcclusion.OcclusionSource.DepthTexture
				};
			}

			// Token: 0x06007543 RID: 30019 RVA: 0x0023F170 File Offset: 0x0023D370
			public static AmbientOcclusion.Settings HJLGAPEDPJM()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 1232f,
					radius = 1317f,
					sampleCount = AmbientOcclusion.SampleCount.Low,
					sampleCountValue = -39,
					downsampling = true,
					ambientOnly = false,
					occlusionSource = AmbientOcclusion.OcclusionSource.DepthNormalsTexture
				};
			}

			// Token: 0x06007544 RID: 30020 RVA: 0x0023F1C0 File Offset: 0x0023D3C0
			public static AmbientOcclusion.Settings MNKGFGNDKED()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 1610f,
					radius = 1601f,
					sampleCount = (AmbientOcclusion.SampleCount)5,
					sampleCountValue = -88,
					downsampling = true,
					ambientOnly = true,
					occlusionSource = AmbientOcclusion.OcclusionSource.DepthNormalsTexture
				};
			}

			// Token: 0x1700015D RID: 349
			// (get) Token: 0x06007545 RID: 30021 RVA: 0x0023F210 File Offset: 0x0023D410
			public static AmbientOcclusion.Settings defaultSettings
			{
				get
				{
					return new AmbientOcclusion.Settings
					{
						intensity = 1f,
						radius = 0.3f,
						sampleCount = AmbientOcclusion.SampleCount.Medium,
						sampleCountValue = 24,
						downsampling = false,
						ambientOnly = false,
						occlusionSource = AmbientOcclusion.OcclusionSource.DepthNormalsTexture
					};
				}
			}

			// Token: 0x06007546 RID: 30022 RVA: 0x0023F260 File Offset: 0x0023D460
			public static AmbientOcclusion.Settings JCLADKAMOLD()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 1554f,
					radius = 977f,
					sampleCount = AmbientOcclusion.SampleCount.High,
					sampleCountValue = -126,
					downsampling = true,
					ambientOnly = true,
					occlusionSource = AmbientOcclusion.OcclusionSource.DepthTexture
				};
			}

			// Token: 0x06007547 RID: 30023 RVA: 0x0023F2B0 File Offset: 0x0023D4B0
			public static AmbientOcclusion.Settings AAPGCALKNAK()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 1737f,
					radius = 388f,
					sampleCount = AmbientOcclusion.SampleCount.High,
					sampleCountValue = -51,
					downsampling = true,
					ambientOnly = true,
					occlusionSource = AmbientOcclusion.OcclusionSource.DepthNormalsTexture
				};
			}

			// Token: 0x06007549 RID: 30025 RVA: 0x0023F300 File Offset: 0x0023D500
			public static AmbientOcclusion.Settings IAKJOAGBDGO()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 909f,
					radius = 579f,
					sampleCount = AmbientOcclusion.SampleCount.Medium,
					sampleCountValue = -68,
					downsampling = true,
					ambientOnly = true,
					occlusionSource = AmbientOcclusion.OcclusionSource.DepthTexture
				};
			}

			// Token: 0x0600754A RID: 30026 RVA: 0x0023F350 File Offset: 0x0023D550
			public static AmbientOcclusion.Settings LBIOOILOAAD()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 16f,
					radius = 356f,
					sampleCount = (AmbientOcclusion.SampleCount)7,
					sampleCountValue = 1,
					downsampling = true,
					ambientOnly = true,
					occlusionSource = AmbientOcclusion.OcclusionSource.DepthTexture
				};
			}

			// Token: 0x0600754B RID: 30027 RVA: 0x0023F3A0 File Offset: 0x0023D5A0
			public static AmbientOcclusion.Settings MLKLBGCKPOO()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 1150f,
					radius = 350f,
					sampleCount = AmbientOcclusion.SampleCount.High,
					sampleCountValue = -9,
					downsampling = true,
					ambientOnly = true,
					occlusionSource = AmbientOcclusion.OcclusionSource.DepthTexture
				};
			}

			// Token: 0x0600754C RID: 30028 RVA: 0x0023F3F0 File Offset: 0x0023D5F0
			public static AmbientOcclusion.Settings EEMMJNPOFOB()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 1706f,
					radius = 827f,
					sampleCount = (AmbientOcclusion.SampleCount)6,
					sampleCountValue = -5,
					downsampling = false,
					ambientOnly = true,
					occlusionSource = AmbientOcclusion.OcclusionSource.DepthNormalsTexture
				};
			}

			// Token: 0x0600754D RID: 30029 RVA: 0x0023F440 File Offset: 0x0023D640
			public static AmbientOcclusion.Settings DFIOJCABPFD()
			{
				return new AmbientOcclusion.Settings
				{
					intensity = 1373f,
					radius = 1738f,
					sampleCount = AmbientOcclusion.SampleCount.Variable,
					sampleCountValue = -92,
					downsampling = true,
					ambientOnly = false,
					occlusionSource = AmbientOcclusion.OcclusionSource.DepthNormalsTexture
				};
			}

			// Token: 0x04000BF4 RID: 3060
			[Range(0f, 4f)]
			[SerializeField]
			[Tooltip("Degree of darkness produced by the effect.")]
			public float intensity;

			// Token: 0x04000BF5 RID: 3061
			[SerializeField]
			[Tooltip("Radius of sample points, which affects extent of darkened areas.")]
			public float radius;

			// Token: 0x04000BF6 RID: 3062
			[Tooltip("Number of sample points, which affects quality and performance.")]
			[SerializeField]
			public AmbientOcclusion.SampleCount sampleCount;

			// Token: 0x04000BF7 RID: 3063
			[Tooltip("Determines the sample count when SampleCount.Variable is used.")]
			[SerializeField]
			public int sampleCountValue;

			// Token: 0x04000BF8 RID: 3064
			[SerializeField]
			[Tooltip("Halves the resolution of the effect to increase performance.")]
			public bool downsampling;

			// Token: 0x04000BF9 RID: 3065
			[Tooltip("If checked, the effect only affects ambient lighting.")]
			[SerializeField]
			public bool ambientOnly;

			// Token: 0x04000BFA RID: 3066
			[SerializeField]
			[Tooltip("Source buffer on which the occlusion estimator is based.")]
			public AmbientOcclusion.OcclusionSource occlusionSource;

			// Token: 0x04000BFB RID: 3067
			[SerializeField]
			[Tooltip("Displays occlusion for debug purpose.")]
			public bool debug;
		}
	}
}
