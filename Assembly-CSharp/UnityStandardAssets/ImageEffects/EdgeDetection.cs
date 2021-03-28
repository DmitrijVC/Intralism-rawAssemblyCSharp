using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001E2 RID: 482
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Edge Detection/Edge Detection")]
	public class EdgeDetection : PostEffectsBase
	{
		// Token: 0x06007CDA RID: 31962 RVA: 0x0029140C File Offset: 0x0028F60C
		public virtual bool GACCMCAGAIJ()
		{
			base.DHHGCBANGJL(false);
			this.EALPHIINHAC = base.ECNEGNMAMDE(this.edgeDetectShader, this.EALPHIINHAC);
			if (this.mode != this.HKMNBILMLGL)
			{
				this.NHIMOPEINLL();
			}
			this.HKMNBILMLGL = this.mode;
			if (!this.LMKGCBNNGLI)
			{
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007CDB RID: 31963 RVA: 0x00291473 File Offset: 0x0028F673
		private void GFLAINNLMBO()
		{
			this.NHIMOPEINLL();
		}

		// Token: 0x06007CDC RID: 31964 RVA: 0x0029147C File Offset: 0x0028F67C
		private void NHIMOPEINLL()
		{
			if (this.mode == (EdgeDetection.EdgeDetectMode)6 || this.mode == EdgeDetection.EdgeDetectMode.RobertsCrossDepthNormals)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			else if (this.mode == EdgeDetection.EdgeDetectMode.TriangleDepthNormals || this.mode == EdgeDetection.EdgeDetectMode.RobertsCrossDepthNormals)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.DepthNormals;
			}
		}

		// Token: 0x06007CDD RID: 31965 RVA: 0x002914E3 File Offset: 0x0028F6E3
		private void LIFBFDKFMMH()
		{
			this.PDODELPFDAI();
		}

		// Token: 0x06007CDE RID: 31966 RVA: 0x002914EC File Offset: 0x0028F6EC
		private void DPFHBBLGLID()
		{
			if (this.mode == EdgeDetection.EdgeDetectMode.SobelDepth || this.mode == EdgeDetection.EdgeDetectMode.SobelDepthThin)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			else if (this.mode == EdgeDetection.EdgeDetectMode.TriangleDepthNormals || this.mode == EdgeDetection.EdgeDetectMode.RobertsCrossDepthNormals)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.DepthNormals;
			}
		}

		// Token: 0x06007CDF RID: 31967 RVA: 0x00291553 File Offset: 0x0028F753
		private void OnEnable()
		{
			this.DPFHBBLGLID();
		}

		// Token: 0x06007CE0 RID: 31968 RVA: 0x0029155C File Offset: 0x0028F75C
		private void HFNLEOLNJLF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector2 vector = new Vector2(this.sensitivityDepth, this.sensitivityNormals);
			this.EALPHIINHAC.SetVector("player.bluebat", new Vector4(vector.x, vector.y, 1199f, vector.y));
			this.EALPHIINHAC.SetFloat("_Offsets", this.edgesOnly);
			this.EALPHIINHAC.SetFloat("Editor/", this.sampleDist);
			this.EALPHIINHAC.SetVector("Tab1Content", this.edgesOnlyBgColor);
			this.EALPHIINHAC.SetFloat("_TempTexture", this.edgeExp);
			this.EALPHIINHAC.SetFloat("RespawnAfter", this.lumThreshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.EALPHIINHAC, (int)this.mode);
		}

		// Token: 0x06007CE1 RID: 31969 RVA: 0x00291644 File Offset: 0x0028F844
		private void PDODELPFDAI()
		{
			if (this.mode == EdgeDetection.EdgeDetectMode.RobertsCrossDepthNormals || this.mode == (EdgeDetection.EdgeDetectMode)6)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			else if (this.mode == EdgeDetection.EdgeDetectMode.TriangleDepthNormals || this.mode == EdgeDetection.EdgeDetectMode.TriangleDepthNormals)
			{
				base.GetComponent<Camera>().depthTextureMode |= (DepthTextureMode)8;
			}
		}

		// Token: 0x06007CE3 RID: 31971 RVA: 0x0029170F File Offset: 0x0028F90F
		private void IMCKJCHKMKB()
		{
			this.HKMNBILMLGL = this.mode;
		}

		// Token: 0x06007CE4 RID: 31972 RVA: 0x00291720 File Offset: 0x0028F920
		public virtual bool APBDJCHNNEH()
		{
			base.NPOEJIDLJGK(false);
			this.EALPHIINHAC = base.AJKPGPKKHHB(this.edgeDetectShader, this.EALPHIINHAC);
			if (this.mode != this.HKMNBILMLGL)
			{
				this.DPFHBBLGLID();
			}
			this.HKMNBILMLGL = this.mode;
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007CE5 RID: 31973 RVA: 0x0029170F File Offset: 0x0028F90F
		private new void Start()
		{
			this.HKMNBILMLGL = this.mode;
		}

		// Token: 0x06007CE6 RID: 31974 RVA: 0x00291788 File Offset: 0x0028F988
		private void KBGCKEDIGAH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector2 vector = new Vector2(this.sensitivityDepth, this.sensitivityNormals);
			this.EALPHIINHAC.SetVector("BadgeText", new Vector4(vector.x, vector.y, 1403f, vector.y));
			this.EALPHIINHAC.SetFloat(". Going to ignore! Check PhotonServerSettings.RpcList", this.edgesOnly);
			this.EALPHIINHAC.SetFloat("ScreenResolutionPanel", this.sampleDist);
			this.EALPHIINHAC.SetVector("CameraFilterPack/Drawing_Curve", this.edgesOnlyBgColor);
			this.EALPHIINHAC.SetFloat("Connecting to server", this.edgeExp);
			this.EALPHIINHAC.SetFloat("tagElement", this.lumThreshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.EALPHIINHAC, (int)this.mode);
		}

		// Token: 0x06007CE7 RID: 31975 RVA: 0x00291870 File Offset: 0x0028FA70
		public override bool CheckResources()
		{
			base.NPOEJIDLJGK(true);
			this.EALPHIINHAC = base.EDFIBHNHAAB(this.edgeDetectShader, this.EALPHIINHAC);
			if (this.mode != this.HKMNBILMLGL)
			{
				this.DPFHBBLGLID();
			}
			this.HKMNBILMLGL = this.mode;
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007CE8 RID: 31976 RVA: 0x002914E3 File Offset: 0x0028F6E3
		private void IBEAPBDAOCC()
		{
			this.PDODELPFDAI();
		}

		// Token: 0x06007CE9 RID: 31977 RVA: 0x002918D8 File Offset: 0x0028FAD8
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Vector2 vector = new Vector2(this.sensitivityDepth, this.sensitivityNormals);
			this.EALPHIINHAC.SetVector("_Sensitivity", new Vector4(vector.x, vector.y, 1f, vector.y));
			this.EALPHIINHAC.SetFloat("_BgFade", this.edgesOnly);
			this.EALPHIINHAC.SetFloat("_SampleDistance", this.sampleDist);
			this.EALPHIINHAC.SetVector("_BgColor", this.edgesOnlyBgColor);
			this.EALPHIINHAC.SetFloat("_Exponent", this.edgeExp);
			this.EALPHIINHAC.SetFloat("_Threshold", this.lumThreshold);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.EALPHIINHAC, (int)this.mode);
		}

		// Token: 0x06007CEA RID: 31978 RVA: 0x002919C0 File Offset: 0x0028FBC0
		public virtual bool MOLMLGKEBOL()
		{
			base.MBMLNJJEONO(true);
			this.EALPHIINHAC = base.AJKPGPKKHHB(this.edgeDetectShader, this.EALPHIINHAC);
			if (this.mode != this.HKMNBILMLGL)
			{
				this.DPFHBBLGLID();
			}
			this.HKMNBILMLGL = this.mode;
			if (!this.LMKGCBNNGLI)
			{
				base.HKDNNECLBGL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x04000DFF RID: 3583
		public EdgeDetection.EdgeDetectMode mode = EdgeDetection.EdgeDetectMode.SobelDepthThin;

		// Token: 0x04000E00 RID: 3584
		public float sensitivityDepth = 1f;

		// Token: 0x04000E01 RID: 3585
		public float sensitivityNormals = 1f;

		// Token: 0x04000E02 RID: 3586
		public float lumThreshold = 0.2f;

		// Token: 0x04000E03 RID: 3587
		public float edgeExp = 1f;

		// Token: 0x04000E04 RID: 3588
		public float sampleDist = 1f;

		// Token: 0x04000E05 RID: 3589
		public float edgesOnly;

		// Token: 0x04000E06 RID: 3590
		public Color edgesOnlyBgColor = Color.white;

		// Token: 0x04000E07 RID: 3591
		public Shader edgeDetectShader;

		// Token: 0x04000E08 RID: 3592
		private Material EALPHIINHAC;

		// Token: 0x04000E09 RID: 3593
		private EdgeDetection.EdgeDetectMode HKMNBILMLGL = EdgeDetection.EdgeDetectMode.SobelDepthThin;

		// Token: 0x020001E3 RID: 483
		public enum EdgeDetectMode
		{
			// Token: 0x04000E0B RID: 3595
			TriangleDepthNormals,
			// Token: 0x04000E0C RID: 3596
			RobertsCrossDepthNormals,
			// Token: 0x04000E0D RID: 3597
			SobelDepth,
			// Token: 0x04000E0E RID: 3598
			SobelDepthThin,
			// Token: 0x04000E0F RID: 3599
			TriangleLuminance
		}
	}
}
