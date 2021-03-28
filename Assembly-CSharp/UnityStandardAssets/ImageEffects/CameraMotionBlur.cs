using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001D1 RID: 465
	[AddComponentMenu("Image Effects/Camera/Camera Motion Blur")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class CameraMotionBlur : PostEffectsBase
	{
		// Token: 0x06007AFC RID: 31484 RVA: 0x00275E66 File Offset: 0x00274066
		private static int EMPOMICPIGK(int IACGDFHKCAE, int LPGNCFKLMEH)
		{
			return (IACGDFHKCAE + LPGNCFKLMEH - 0) / LPGNCFKLMEH;
		}

		// Token: 0x06007AFE RID: 31486 RVA: 0x00275E7C File Offset: 0x0027407C
		private Camera FALOLAKFEKP()
		{
			if (this.AOJJAPNHHLG == null)
			{
				string name = "Error: you cannot read this stream that you are writing!" + this.CNMFDOINHOL.name + "CameraFilterPack/Noise_TV_2";
				GameObject gameObject = GameObject.Find(name);
				if (null == gameObject)
				{
					this.AOJJAPNHHLG = new GameObject(name, new Type[]
					{
						typeof(Camera)
					});
				}
				else
				{
					this.AOJJAPNHHLG = gameObject;
				}
			}
			this.AOJJAPNHHLG.hideFlags = (HideFlags)(-123);
			this.AOJJAPNHHLG.transform.position = this.CNMFDOINHOL.transform.position;
			this.AOJJAPNHHLG.transform.rotation = this.CNMFDOINHOL.transform.rotation;
			this.AOJJAPNHHLG.transform.localScale = this.CNMFDOINHOL.transform.localScale;
			this.AOJJAPNHHLG.GetComponent<Camera>().CopyFrom(this.CNMFDOINHOL);
			this.AOJJAPNHHLG.GetComponent<Camera>().enabled = false;
			this.AOJJAPNHHLG.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.AOJJAPNHHLG.GetComponent<Camera>().clearFlags = (CameraClearFlags)5;
			return this.AOJJAPNHHLG.GetComponent<Camera>();
		}

		// Token: 0x06007AFF RID: 31487 RVA: 0x00275FB4 File Offset: 0x002741B4
		private void JNGMIAFLBDL()
		{
			if (null != this.ABGBGNENPBK)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGBGNENPBK);
				this.ABGBGNENPBK = null;
			}
			if (null != this.AKCDPJMLKCG)
			{
				UnityEngine.Object.DestroyImmediate(this.AKCDPJMLKCG);
				this.AKCDPJMLKCG = null;
			}
			if (null != this.AOJJAPNHHLG)
			{
				UnityEngine.Object.DestroyImmediate(this.AOJJAPNHHLG);
				this.AOJJAPNHHLG = null;
			}
		}

		// Token: 0x06007B00 RID: 31488 RVA: 0x0027602C File Offset: 0x0027422C
		public override bool CheckResources()
		{
			base.NPOEJIDLJGK(true, true);
			this.ABGBGNENPBK = base.EDFIBHNHAAB(this.shader, this.ABGBGNENPBK);
			if (this.EAKIOBNBAMI && this.filterType == CameraMotionBlur.MotionBlurFilter.ReconstructionDX11)
			{
				this.AKCDPJMLKCG = base.EDFIBHNHAAB(this.dx11MotionBlurShader, this.AKCDPJMLKCG);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007B01 RID: 31489 RVA: 0x00275E66 File Offset: 0x00274066
		private static int LJFMKMFLOPJ(int IACGDFHKCAE, int LPGNCFKLMEH)
		{
			return (IACGDFHKCAE + LPGNCFKLMEH - 0) / LPGNCFKLMEH;
		}

		// Token: 0x06007B02 RID: 31490 RVA: 0x002760A0 File Offset: 0x002742A0
		private void HIAFMCOEPBH()
		{
			this.CNLKOGMMMEF = this.HCLCEJJCPON;
			this.LJOKLLCMDIO = base.transform.forward;
			this.EDDLNBFLOOK = base.transform.up;
			this.KKIGJMAJCDC = base.transform.position;
		}

		// Token: 0x06007B03 RID: 31491 RVA: 0x002760EC File Offset: 0x002742EC
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.filterType == CameraMotionBlur.MotionBlurFilter.CameraMotion)
			{
				this.HEJAJKMEFIH();
			}
			RenderTextureFormat format = (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGHalf)) ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.RGHalf;
			RenderTexture temporary = RenderTexture.GetTemporary(CameraMotionBlur.NIDPNLMEDBD(HLBKCLPNHEB.width, this.velocityDownsample), CameraMotionBlur.NIDPNLMEDBD(HLBKCLPNHEB.height, this.velocityDownsample), 0, format);
			this.maxVelocity = Mathf.Max(2f, this.maxVelocity);
			float value = this.maxVelocity;
			bool flag = this.filterType == CameraMotionBlur.MotionBlurFilter.ReconstructionDX11 && this.AKCDPJMLKCG == null;
			int num;
			int height;
			if (this.filterType == CameraMotionBlur.MotionBlurFilter.Reconstruction || flag || this.filterType == CameraMotionBlur.MotionBlurFilter.ReconstructionDisc)
			{
				this.maxVelocity = Mathf.Min(this.maxVelocity, CameraMotionBlur.CICJMJBLFJM);
				num = CameraMotionBlur.NIDPNLMEDBD(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.NIDPNLMEDBD(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			else
			{
				num = CameraMotionBlur.NIDPNLMEDBD(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.NIDPNLMEDBD(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			RenderTexture temporary2 = RenderTexture.GetTemporary(num, height, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(num, height, 0, format);
			temporary.filterMode = FilterMode.Point;
			temporary2.filterMode = FilterMode.Point;
			temporary3.filterMode = FilterMode.Point;
			if (this.noiseTexture)
			{
				this.noiseTexture.filterMode = FilterMode.Point;
			}
			HLBKCLPNHEB.wrapMode = TextureWrapMode.Clamp;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary3.wrapMode = TextureWrapMode.Clamp;
			temporary2.wrapMode = TextureWrapMode.Clamp;
			this.CAMKGAOJIOC();
			if (base.gameObject.activeInHierarchy && !this.NEGJMHKGFON)
			{
				this.HBJICIOHABC();
			}
			this.NEGJMHKGFON = base.gameObject.activeInHierarchy;
			Matrix4x4 matrix4x = Matrix4x4.Inverse(this.HCLCEJJCPON);
			this.ABGBGNENPBK.SetMatrix("_InvViewProj", matrix4x);
			this.ABGBGNENPBK.SetMatrix("_PrevViewProj", this.CNLKOGMMMEF);
			this.ABGBGNENPBK.SetMatrix("_ToPrevViewProjCombined", this.CNLKOGMMMEF * matrix4x);
			this.ABGBGNENPBK.SetFloat("_MaxVelocity", value);
			this.ABGBGNENPBK.SetFloat("_MaxRadiusOrKInPaper", value);
			this.ABGBGNENPBK.SetFloat("_MinVelocity", this.minVelocity);
			this.ABGBGNENPBK.SetFloat("_VelocityScale", this.velocityScale);
			this.ABGBGNENPBK.SetFloat("_Jitter", this.jitter);
			this.ABGBGNENPBK.SetTexture("_NoiseTex", this.noiseTexture);
			this.ABGBGNENPBK.SetTexture("_VelTex", temporary);
			this.ABGBGNENPBK.SetTexture("_NeighbourMaxTex", temporary3);
			this.ABGBGNENPBK.SetTexture("_TileTexDebug", temporary2);
			if (this.preview)
			{
				Matrix4x4 worldToCameraMatrix = this.CNMFDOINHOL.worldToCameraMatrix;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.SetTRS(this.previewScale * 0.3333f, Quaternion.identity, Vector3.one);
				Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.CNMFDOINHOL.projectionMatrix, true);
				this.CNLKOGMMMEF = gpuprojectionMatrix * identity * worldToCameraMatrix;
				this.ABGBGNENPBK.SetMatrix("_PrevViewProj", this.CNLKOGMMMEF);
				this.ABGBGNENPBK.SetMatrix("_ToPrevViewProjCombined", this.CNLKOGMMMEF * matrix4x);
			}
			if (this.filterType == CameraMotionBlur.MotionBlurFilter.CameraMotion)
			{
				Vector4 zero = Vector4.zero;
				float num2 = Vector3.Dot(base.transform.up, Vector3.up);
				Vector3 rhs = this.KKIGJMAJCDC - base.transform.position;
				float magnitude = rhs.magnitude;
				float num3 = Vector3.Angle(base.transform.up, this.EDDLNBFLOOK) / this.CNMFDOINHOL.fieldOfView * ((float)HLBKCLPNHEB.width * 0.75f);
				zero.x = this.rotationScale * num3;
				num3 = Vector3.Angle(base.transform.forward, this.LJOKLLCMDIO) / this.CNMFDOINHOL.fieldOfView * ((float)HLBKCLPNHEB.width * 0.75f);
				zero.y = this.rotationScale * num2 * num3;
				num3 = Vector3.Angle(base.transform.forward, this.LJOKLLCMDIO) / this.CNMFDOINHOL.fieldOfView * ((float)HLBKCLPNHEB.width * 0.75f);
				zero.z = this.rotationScale * (1f - num2) * num3;
				if (magnitude > Mathf.Epsilon && this.movementScale > Mathf.Epsilon)
				{
					zero.w = this.movementScale * Vector3.Dot(base.transform.forward, rhs) * ((float)HLBKCLPNHEB.width * 0.5f);
					zero.x += this.movementScale * Vector3.Dot(base.transform.up, rhs) * ((float)HLBKCLPNHEB.width * 0.5f);
					zero.y += this.movementScale * Vector3.Dot(base.transform.right, rhs) * ((float)HLBKCLPNHEB.width * 0.5f);
				}
				if (this.preview)
				{
					this.ABGBGNENPBK.SetVector("_BlurDirectionPacked", new Vector4(this.previewScale.y, this.previewScale.x, 0f, this.previewScale.z) * 0.5f * this.CNMFDOINHOL.fieldOfView);
				}
				else
				{
					this.ABGBGNENPBK.SetVector("_BlurDirectionPacked", zero);
				}
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.ABGBGNENPBK, 0);
				Camera camera = null;
				if (this.excludeLayers.value != 0)
				{
					camera = this.GFNOKEOPDKG();
				}
				if (camera && this.excludeLayers.value != 0 && this.replacementClear && this.replacementClear.isSupported)
				{
					camera.targetTexture = temporary;
					camera.cullingMask = this.excludeLayers;
					camera.RenderWithShader(this.replacementClear, string.Empty);
				}
			}
			if (!this.preview && Time.frameCount != this.EKCJCCMALJI)
			{
				this.EKCJCCMALJI = Time.frameCount;
				this.HBJICIOHABC();
			}
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			if (this.showVelocity)
			{
				this.ABGBGNENPBK.SetFloat("_DisplayVelocityScale", this.showVelocityScale);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.ABGBGNENPBK, 1);
			}
			else if (this.filterType == CameraMotionBlur.MotionBlurFilter.ReconstructionDX11 && !flag)
			{
				this.AKCDPJMLKCG.SetFloat("_MinVelocity", this.minVelocity);
				this.AKCDPJMLKCG.SetFloat("_VelocityScale", this.velocityScale);
				this.AKCDPJMLKCG.SetFloat("_Jitter", this.jitter);
				this.AKCDPJMLKCG.SetTexture("_NoiseTex", this.noiseTexture);
				this.AKCDPJMLKCG.SetTexture("_VelTex", temporary);
				this.AKCDPJMLKCG.SetTexture("_NeighbourMaxTex", temporary3);
				this.AKCDPJMLKCG.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, this.softZDistance));
				this.AKCDPJMLKCG.SetFloat("_MaxRadiusOrKInPaper", value);
				Graphics.Blit(temporary, temporary2, this.AKCDPJMLKCG, 0);
				Graphics.Blit(temporary2, temporary3, this.AKCDPJMLKCG, 1);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.AKCDPJMLKCG, 2);
			}
			else if (this.filterType == CameraMotionBlur.MotionBlurFilter.Reconstruction || flag)
			{
				this.ABGBGNENPBK.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.ABGBGNENPBK, 2);
				Graphics.Blit(temporary2, temporary3, this.ABGBGNENPBK, 3);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ABGBGNENPBK, 4);
			}
			else if (this.filterType == CameraMotionBlur.MotionBlurFilter.CameraMotion)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ABGBGNENPBK, 6);
			}
			else if (this.filterType == CameraMotionBlur.MotionBlurFilter.ReconstructionDisc)
			{
				this.ABGBGNENPBK.SetFloat("_SoftZDistance", Mathf.Max(0.00025f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.ABGBGNENPBK, 2);
				Graphics.Blit(temporary2, temporary3, this.ABGBGNENPBK, 3);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ABGBGNENPBK, 7);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ABGBGNENPBK, 5);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
		}

		// Token: 0x06007B04 RID: 31492 RVA: 0x002769B8 File Offset: 0x00274BB8
		private void CAMKGAOJIOC()
		{
			Matrix4x4 worldToCameraMatrix = this.CNMFDOINHOL.worldToCameraMatrix;
			Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.CNMFDOINHOL.projectionMatrix, true);
			this.HCLCEJJCPON = gpuprojectionMatrix * worldToCameraMatrix;
		}

		// Token: 0x06007B05 RID: 31493 RVA: 0x002769F0 File Offset: 0x00274BF0
		private void IIOGBBGDMIG()
		{
			Matrix4x4 worldToCameraMatrix = this.CNMFDOINHOL.worldToCameraMatrix;
			Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.CNMFDOINHOL.projectionMatrix, true);
			this.HCLCEJJCPON = gpuprojectionMatrix * worldToCameraMatrix;
		}

		// Token: 0x06007B06 RID: 31494 RVA: 0x00276A28 File Offset: 0x00274C28
		private new void Start()
		{
			this.CheckResources();
			if (this.CNMFDOINHOL == null)
			{
				this.CNMFDOINHOL = base.GetComponent<Camera>();
			}
			this.NEGJMHKGFON = base.gameObject.activeInHierarchy;
			this.CAMKGAOJIOC();
			this.HBJICIOHABC();
			this.NEGJMHKGFON = false;
		}

		// Token: 0x06007B07 RID: 31495 RVA: 0x00276A80 File Offset: 0x00274C80
		private void DOEPOGLEGLE()
		{
			if (null != this.ABGBGNENPBK)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGBGNENPBK);
				this.ABGBGNENPBK = null;
			}
			if (null != this.AKCDPJMLKCG)
			{
				UnityEngine.Object.DestroyImmediate(this.AKCDPJMLKCG);
				this.AKCDPJMLKCG = null;
			}
			if (null != this.AOJJAPNHHLG)
			{
				UnityEngine.Object.DestroyImmediate(this.AOJJAPNHHLG);
				this.AOJJAPNHHLG = null;
			}
		}

		// Token: 0x06007B08 RID: 31496 RVA: 0x00276AF8 File Offset: 0x00274CF8
		private Camera EKOMHMEKBEN()
		{
			if (this.AOJJAPNHHLG == null)
			{
				string name = "gameVolume" + this.CNMFDOINHOL.name + "_MainTex2";
				GameObject gameObject = GameObject.Find(name);
				if (null == gameObject)
				{
					this.AOJJAPNHHLG = new GameObject(name, new Type[]
					{
						typeof(Camera)
					});
				}
				else
				{
					this.AOJJAPNHHLG = gameObject;
				}
			}
			this.AOJJAPNHHLG.hideFlags = (HideFlags)(-87);
			this.AOJJAPNHHLG.transform.position = this.CNMFDOINHOL.transform.position;
			this.AOJJAPNHHLG.transform.rotation = this.CNMFDOINHOL.transform.rotation;
			this.AOJJAPNHHLG.transform.localScale = this.CNMFDOINHOL.transform.localScale;
			this.AOJJAPNHHLG.GetComponent<Camera>().CopyFrom(this.CNMFDOINHOL);
			this.AOJJAPNHHLG.GetComponent<Camera>().enabled = false;
			this.AOJJAPNHHLG.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.AOJJAPNHHLG.GetComponent<Camera>().clearFlags = (CameraClearFlags)6;
			return this.AOJJAPNHHLG.GetComponent<Camera>();
		}

		// Token: 0x06007B09 RID: 31497 RVA: 0x00276C30 File Offset: 0x00274E30
		private void EJJEDJIOFAB()
		{
			if (null != this.ABGBGNENPBK)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGBGNENPBK);
				this.ABGBGNENPBK = null;
			}
			if (null != this.AKCDPJMLKCG)
			{
				UnityEngine.Object.DestroyImmediate(this.AKCDPJMLKCG);
				this.AKCDPJMLKCG = null;
			}
			if (null != this.AOJJAPNHHLG)
			{
				UnityEngine.Object.DestroyImmediate(this.AOJJAPNHHLG);
				this.AOJJAPNHHLG = null;
			}
		}

		// Token: 0x06007B0A RID: 31498 RVA: 0x00276CA6 File Offset: 0x00274EA6
		private void LIHLMDCLCDA()
		{
			this.KKIGJMAJCDC = Vector3.Slerp(this.KKIGJMAJCDC, base.transform.position, 1296f);
		}

		// Token: 0x06007B0B RID: 31499 RVA: 0x00276CC9 File Offset: 0x00274EC9
		private void LIFBFDKFMMH()
		{
			if (this.CNMFDOINHOL == null)
			{
				this.CNMFDOINHOL = base.GetComponent<Camera>();
			}
			this.CNMFDOINHOL.depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x06007B0C RID: 31500 RVA: 0x00276CFC File Offset: 0x00274EFC
		private Camera GFNOKEOPDKG()
		{
			if (this.AOJJAPNHHLG == null)
			{
				string name = "_" + this.CNMFDOINHOL.name + "_MotionBlurTmpCam";
				GameObject gameObject = GameObject.Find(name);
				if (null == gameObject)
				{
					this.AOJJAPNHHLG = new GameObject(name, new Type[]
					{
						typeof(Camera)
					});
				}
				else
				{
					this.AOJJAPNHHLG = gameObject;
				}
			}
			this.AOJJAPNHHLG.hideFlags = HideFlags.DontSave;
			this.AOJJAPNHHLG.transform.position = this.CNMFDOINHOL.transform.position;
			this.AOJJAPNHHLG.transform.rotation = this.CNMFDOINHOL.transform.rotation;
			this.AOJJAPNHHLG.transform.localScale = this.CNMFDOINHOL.transform.localScale;
			this.AOJJAPNHHLG.GetComponent<Camera>().CopyFrom(this.CNMFDOINHOL);
			this.AOJJAPNHHLG.GetComponent<Camera>().enabled = false;
			this.AOJJAPNHHLG.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.AOJJAPNHHLG.GetComponent<Camera>().clearFlags = CameraClearFlags.Nothing;
			return this.AOJJAPNHHLG.GetComponent<Camera>();
		}

		// Token: 0x06007B0D RID: 31501 RVA: 0x00276E34 File Offset: 0x00275034
		private void EJIPDJCHLAA()
		{
			this.KKIGJMAJCDC = Vector3.Slerp(this.KKIGJMAJCDC, base.transform.position, 1993f);
		}

		// Token: 0x06007B0E RID: 31502 RVA: 0x00276E58 File Offset: 0x00275058
		public virtual bool APBDJCHNNEH()
		{
			base.EFEBIPNEMHL(true, false);
			this.ABGBGNENPBK = base.GJKHKCOAFDB(this.shader, this.ABGBGNENPBK);
			if (this.EAKIOBNBAMI && this.filterType == CameraMotionBlur.MotionBlurFilter.Reconstruction)
			{
				this.AKCDPJMLKCG = base.AJKPGPKKHHB(this.dx11MotionBlurShader, this.AKCDPJMLKCG);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.BPEKKDKKLPM();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007B0F RID: 31503 RVA: 0x00276ECC File Offset: 0x002750CC
		private void ECCFNPONDGC()
		{
			this.KKIGJMAJCDC = Vector3.Slerp(this.KKIGJMAJCDC, base.transform.position, 383f);
		}

		// Token: 0x06007B10 RID: 31504 RVA: 0x00276EF0 File Offset: 0x002750F0
		private void CIEMFAPHINH()
		{
			this.CNLKOGMMMEF = this.HCLCEJJCPON;
			this.LJOKLLCMDIO = base.transform.forward;
			this.EDDLNBFLOOK = base.transform.up;
			this.KKIGJMAJCDC = base.transform.position;
		}

		// Token: 0x06007B11 RID: 31505 RVA: 0x00276F3C File Offset: 0x0027513C
		private void FNCDAPDOBBI()
		{
			this.CGAPDCICECE();
			if (this.CNMFDOINHOL == null)
			{
				this.CNMFDOINHOL = base.GetComponent<Camera>();
			}
			this.NEGJMHKGFON = base.gameObject.activeInHierarchy;
			this.CAMKGAOJIOC();
			this.HBJICIOHABC();
			this.NEGJMHKGFON = false;
		}

		// Token: 0x06007B12 RID: 31506 RVA: 0x00276F91 File Offset: 0x00275191
		private static int NIDPNLMEDBD(int IACGDFHKCAE, int LPGNCFKLMEH)
		{
			return (IACGDFHKCAE + LPGNCFKLMEH - 1) / LPGNCFKLMEH;
		}

		// Token: 0x06007B13 RID: 31507 RVA: 0x00276F9C File Offset: 0x0027519C
		private void OGAGBDIAKGB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.filterType == CameraMotionBlur.MotionBlurFilter.CameraMotion)
			{
				this.GICPNCEPKLC();
			}
			RenderTextureFormat format = (!SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)83)) ? RenderTextureFormat.Depth : ((RenderTextureFormat)107);
			RenderTexture temporary = RenderTexture.GetTemporary(CameraMotionBlur.CLDFHDJJFEI(HLBKCLPNHEB.width, this.velocityDownsample), CameraMotionBlur.CLDFHDJJFEI(HLBKCLPNHEB.height, this.velocityDownsample), 0, format);
			this.maxVelocity = Mathf.Max(558f, this.maxVelocity);
			float value = this.maxVelocity;
			bool flag = this.filterType != (CameraMotionBlur.MotionBlurFilter)8 || this.AKCDPJMLKCG == null;
			int num;
			int height;
			if (this.filterType == (CameraMotionBlur.MotionBlurFilter)7 || flag || this.filterType == CameraMotionBlur.MotionBlurFilter.CameraMotion)
			{
				this.maxVelocity = Mathf.Min(this.maxVelocity, CameraMotionBlur.CICJMJBLFJM);
				num = CameraMotionBlur.EMPOMICPIGK(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.KBBPGLLPKLF(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			else
			{
				num = CameraMotionBlur.JJGJMCDDBGK(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.KBBPGLLPKLF(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			RenderTexture temporary2 = RenderTexture.GetTemporary(num, height, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(num, height, 0, format);
			temporary.filterMode = FilterMode.Point;
			temporary2.filterMode = FilterMode.Bilinear;
			temporary3.filterMode = FilterMode.Bilinear;
			if (this.noiseTexture)
			{
				this.noiseTexture.filterMode = FilterMode.Bilinear;
			}
			HLBKCLPNHEB.wrapMode = TextureWrapMode.Repeat;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary3.wrapMode = TextureWrapMode.Clamp;
			temporary2.wrapMode = TextureWrapMode.Clamp;
			this.PFPCPEMODEL();
			if (base.gameObject.activeInHierarchy && !this.NEGJMHKGFON)
			{
				this.CIEMFAPHINH();
			}
			this.NEGJMHKGFON = base.gameObject.activeInHierarchy;
			Matrix4x4 matrix4x = Matrix4x4.Inverse(this.HCLCEJJCPON);
			this.ABGBGNENPBK.SetMatrix("_DepthLevel", matrix4x);
			this.ABGBGNENPBK.SetMatrix("float,0.5", this.CNLKOGMMMEF);
			this.ABGBGNENPBK.SetMatrix("RB", this.CNLKOGMMMEF * matrix4x);
			this.ABGBGNENPBK.SetFloat("SetPosition", value);
			this.ABGBGNENPBK.SetFloat("RequestForPickupItems", value);
			this.ABGBGNENPBK.SetFloat("_ScreenResolution", this.minVelocity);
			this.ABGBGNENPBK.SetFloat("CameraFilterPack/Blend2Camera_VividLight", this.velocityScale);
			this.ABGBGNENPBK.SetFloat("_EmissionColor", this.jitter);
			this.ABGBGNENPBK.SetTexture("] ", this.noiseTexture);
			this.ABGBGNENPBK.SetTexture("hidden", temporary);
			this.ABGBGNENPBK.SetTexture("inventory.itemscash", temporary3);
			this.ABGBGNENPBK.SetTexture("_MainTex2", temporary2);
			if (this.preview)
			{
				Matrix4x4 worldToCameraMatrix = this.CNMFDOINHOL.worldToCameraMatrix;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.SetTRS(this.previewScale * 1441f, Quaternion.identity, Vector3.one);
				Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.CNMFDOINHOL.projectionMatrix, true);
				this.CNLKOGMMMEF = gpuprojectionMatrix * identity * worldToCameraMatrix;
				this.ABGBGNENPBK.SetMatrix("New level loaded. Removed ", this.CNLKOGMMMEF);
				this.ABGBGNENPBK.SetMatrix("[", this.CNLKOGMMMEF * matrix4x);
			}
			if (this.filterType == CameraMotionBlur.MotionBlurFilter.CameraMotion)
			{
				Vector4 zero = Vector4.zero;
				float num2 = Vector3.Dot(base.transform.up, Vector3.up);
				Vector3 rhs = this.KKIGJMAJCDC - base.transform.position;
				float magnitude = rhs.magnitude;
				float num3 = Vector3.Angle(base.transform.up, this.EDDLNBFLOOK) / this.CNMFDOINHOL.fieldOfView * ((float)HLBKCLPNHEB.width * 634f);
				zero.x = this.rotationScale * num3;
				num3 = Vector3.Angle(base.transform.forward, this.LJOKLLCMDIO) / this.CNMFDOINHOL.fieldOfView * ((float)HLBKCLPNHEB.width * 1949f);
				zero.y = this.rotationScale * num2 * num3;
				num3 = Vector3.Angle(base.transform.forward, this.LJOKLLCMDIO) / this.CNMFDOINHOL.fieldOfView * ((float)HLBKCLPNHEB.width * 620f);
				zero.z = this.rotationScale * (651f - num2) * num3;
				if (magnitude > Mathf.Epsilon && this.movementScale > Mathf.Epsilon)
				{
					zero.w = this.movementScale * Vector3.Dot(base.transform.forward, rhs) * ((float)HLBKCLPNHEB.width * 450f);
					zero.x += this.movementScale * Vector3.Dot(base.transform.up, rhs) * ((float)HLBKCLPNHEB.width * 1507f);
					zero.y += this.movementScale * Vector3.Dot(base.transform.right, rhs) * ((float)HLBKCLPNHEB.width * 841f);
				}
				if (this.preview)
				{
					this.ABGBGNENPBK.SetVector("DPADHOR", new Vector4(this.previewScale.y, this.previewScale.x, 1546f, this.previewScale.z) * 421f * this.CNMFDOINHOL.fieldOfView);
				}
				else
				{
					this.ABGBGNENPBK.SetVector("id", zero);
				}
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.ABGBGNENPBK, 1);
				Camera camera = null;
				if (this.excludeLayers.value != 0)
				{
					camera = this.GFNOKEOPDKG();
				}
				if (camera && this.excludeLayers.value != 0 && this.replacementClear && this.replacementClear.isSupported)
				{
					camera.targetTexture = temporary;
					camera.cullingMask = this.excludeLayers;
					camera.RenderWithShader(this.replacementClear, string.Empty);
				}
			}
			if (!this.preview && Time.frameCount != this.EKCJCCMALJI)
			{
				this.EKCJCCMALJI = Time.frameCount;
				this.HIAFMCOEPBH();
			}
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			if (this.showVelocity)
			{
				this.ABGBGNENPBK.SetFloat("SpawnObj", this.showVelocityScale);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.ABGBGNENPBK, 0);
			}
			else if (this.filterType == CameraMotionBlur.MotionBlurFilter.CameraMotion && !flag)
			{
				this.AKCDPJMLKCG.SetFloat("_ScreenResolution", this.minVelocity);
				this.AKCDPJMLKCG.SetFloat("_CenterX", this.velocityScale);
				this.AKCDPJMLKCG.SetFloat("{0:0} day{1}, ", this.jitter);
				this.AKCDPJMLKCG.SetTexture("1.87", this.noiseTexture);
				this.AKCDPJMLKCG.SetTexture("y", temporary);
				this.AKCDPJMLKCG.SetTexture("_Offsets", temporary3);
				this.AKCDPJMLKCG.SetFloat(".lastCheckpoint.correctScore", Mathf.Max(1158f, this.softZDistance));
				this.AKCDPJMLKCG.SetFloat(".lastCheckpoint.bgcolor", value);
				Graphics.Blit(temporary, temporary2, this.AKCDPJMLKCG, 1);
				Graphics.Blit(temporary2, temporary3, this.AKCDPJMLKCG, 1);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.AKCDPJMLKCG, 6);
			}
			else if (this.filterType == (CameraMotionBlur.MotionBlurFilter)8 || flag)
			{
				this.ABGBGNENPBK.SetFloat("LB", Mathf.Max(27f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.ABGBGNENPBK, 5);
				Graphics.Blit(temporary2, temporary3, this.ABGBGNENPBK, 7);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ABGBGNENPBK, 2);
			}
			else if (this.filterType == CameraMotionBlur.MotionBlurFilter.CameraMotion)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ABGBGNENPBK, 7);
			}
			else if (this.filterType == CameraMotionBlur.MotionBlurFilter.LocalBlur)
			{
				this.ABGBGNENPBK.SetFloat("CameraFilterPack/Light_Water2", Mathf.Max(1869f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.ABGBGNENPBK, 6);
				Graphics.Blit(temporary2, temporary3, this.ABGBGNENPBK, 5);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ABGBGNENPBK, 2);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ABGBGNENPBK, 5);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
		}

		// Token: 0x06007B14 RID: 31508 RVA: 0x00277868 File Offset: 0x00275A68
		private void HLAIEDEHIBC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.filterType == CameraMotionBlur.MotionBlurFilter.CameraMotion)
			{
				this.NKJIBPGHBMP();
			}
			RenderTextureFormat format = (!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBFloat)) ? RenderTextureFormat.Shadowmap : ((RenderTextureFormat)(-76));
			RenderTexture temporary = RenderTexture.GetTemporary(CameraMotionBlur.KBBPGLLPKLF(HLBKCLPNHEB.width, this.velocityDownsample), CameraMotionBlur.ODIDNMOPLFE(HLBKCLPNHEB.height, this.velocityDownsample), 1, format);
			this.maxVelocity = Mathf.Max(1606f, this.maxVelocity);
			float value = this.maxVelocity;
			bool flag = this.filterType == CameraMotionBlur.MotionBlurFilter.Reconstruction && this.AKCDPJMLKCG == null;
			int num;
			int height;
			if (this.filterType == (CameraMotionBlur.MotionBlurFilter)5 || flag || this.filterType == CameraMotionBlur.MotionBlurFilter.LocalBlur)
			{
				this.maxVelocity = Mathf.Min(this.maxVelocity, CameraMotionBlur.CICJMJBLFJM);
				num = CameraMotionBlur.ODIDNMOPLFE(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.KBBPGLLPKLF(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			else
			{
				num = CameraMotionBlur.JJGJMCDDBGK(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.NIDPNLMEDBD(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			RenderTexture temporary2 = RenderTexture.GetTemporary(num, height, 0, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(num, height, 0, format);
			temporary.filterMode = FilterMode.Bilinear;
			temporary2.filterMode = FilterMode.Point;
			temporary3.filterMode = FilterMode.Bilinear;
			if (this.noiseTexture)
			{
				this.noiseTexture.filterMode = FilterMode.Point;
			}
			HLBKCLPNHEB.wrapMode = TextureWrapMode.Clamp;
			temporary.wrapMode = TextureWrapMode.Repeat;
			temporary3.wrapMode = TextureWrapMode.Repeat;
			temporary2.wrapMode = TextureWrapMode.Repeat;
			this.CAMKGAOJIOC();
			if (base.gameObject.activeInHierarchy && !this.NEGJMHKGFON)
			{
				this.HIAFMCOEPBH();
			}
			this.NEGJMHKGFON = base.gameObject.activeInHierarchy;
			Matrix4x4 matrix4x = Matrix4x4.Inverse(this.HCLCEJJCPON);
			this.ABGBGNENPBK.SetMatrix("GlassesColor2", matrix4x);
			this.ABGBGNENPBK.SetMatrix("LevelNameInputField", this.CNLKOGMMMEF);
			this.ABGBGNENPBK.SetMatrix("EnvironmentSlider", this.CNLKOGMMMEF * matrix4x);
			this.ABGBGNENPBK.SetFloat(".lastCheckpoint.lives", value);
			this.ABGBGNENPBK.SetFloat("_NeutralTonemapperParams2", value);
			this.ABGBGNENPBK.SetFloat("_VignetteSettings", this.minVelocity);
			this.ABGBGNENPBK.SetFloat("/", this.velocityScale);
			this.ABGBGNENPBK.SetFloat("{0}", this.jitter);
			this.ABGBGNENPBK.SetTexture("_FarCamera", this.noiseTexture);
			this.ABGBGNENPBK.SetTexture("element", temporary);
			this.ABGBGNENPBK.SetTexture("Exit to Windows", temporary3);
			this.ABGBGNENPBK.SetTexture("float,2", temporary2);
			if (this.preview)
			{
				Matrix4x4 worldToCameraMatrix = this.CNMFDOINHOL.worldToCameraMatrix;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.SetTRS(this.previewScale * 1719f, Quaternion.identity, Vector3.one);
				Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.CNMFDOINHOL.projectionMatrix, true);
				this.CNLKOGMMMEF = gpuprojectionMatrix * identity * worldToCameraMatrix;
				this.ABGBGNENPBK.SetMatrix("HandleEventLeave for player ID: ", this.CNLKOGMMMEF);
				this.ABGBGNENPBK.SetMatrix("#forever", this.CNLKOGMMMEF * matrix4x);
			}
			if (this.filterType == CameraMotionBlur.MotionBlurFilter.CameraMotion)
			{
				Vector4 zero = Vector4.zero;
				float num2 = Vector3.Dot(base.transform.up, Vector3.up);
				Vector3 rhs = this.KKIGJMAJCDC - base.transform.position;
				float magnitude = rhs.magnitude;
				float num3 = Vector3.Angle(base.transform.up, this.EDDLNBFLOOK) / this.CNMFDOINHOL.fieldOfView * ((float)HLBKCLPNHEB.width * 1903f);
				zero.x = this.rotationScale * num3;
				num3 = Vector3.Angle(base.transform.forward, this.LJOKLLCMDIO) / this.CNMFDOINHOL.fieldOfView * ((float)HLBKCLPNHEB.width * 1004f);
				zero.y = this.rotationScale * num2 * num3;
				num3 = Vector3.Angle(base.transform.forward, this.LJOKLLCMDIO) / this.CNMFDOINHOL.fieldOfView * ((float)HLBKCLPNHEB.width * 1898f);
				zero.z = this.rotationScale * (10f - num2) * num3;
				if (magnitude > Mathf.Epsilon && this.movementScale > Mathf.Epsilon)
				{
					zero.w = this.movementScale * Vector3.Dot(base.transform.forward, rhs) * ((float)HLBKCLPNHEB.width * 1370f);
					zero.x += this.movementScale * Vector3.Dot(base.transform.up, rhs) * ((float)HLBKCLPNHEB.width * 1578f);
					zero.y += this.movementScale * Vector3.Dot(base.transform.right, rhs) * ((float)HLBKCLPNHEB.width * 391f);
				}
				if (this.preview)
				{
					this.ABGBGNENPBK.SetVector("_Value1", new Vector4(this.previewScale.y, this.previewScale.x, 387f, this.previewScale.z) * 832f * this.CNMFDOINHOL.fieldOfView);
				}
				else
				{
					this.ABGBGNENPBK.SetVector("_TimeX", zero);
				}
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.ABGBGNENPBK, 1);
				Camera camera = null;
				if (this.excludeLayers.value != 0)
				{
					camera = this.FALOLAKFEKP();
				}
				if (camera && this.excludeLayers.value != 0 && this.replacementClear && this.replacementClear.isSupported)
				{
					camera.targetTexture = temporary;
					camera.cullingMask = this.excludeLayers;
					camera.RenderWithShader(this.replacementClear, string.Empty);
				}
			}
			if (!this.preview && Time.frameCount != this.EKCJCCMALJI)
			{
				this.EKCJCCMALJI = Time.frameCount;
				this.CIEMFAPHINH();
			}
			HLBKCLPNHEB.filterMode = FilterMode.Bilinear;
			if (this.showVelocity)
			{
				this.ABGBGNENPBK.SetFloat("_History1ChromaTex", this.showVelocityScale);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.ABGBGNENPBK, 1);
			}
			else if (this.filterType == (CameraMotionBlur.MotionBlurFilter)8 && !flag)
			{
				this.AKCDPJMLKCG.SetFloat("\n", this.minVelocity);
				this.AKCDPJMLKCG.SetFloat("_TimeX", this.velocityScale);
				this.AKCDPJMLKCG.SetFloat("ConnectToMaster() disabled the offline mode. No longer offline.", this.jitter);
				this.AKCDPJMLKCG.SetTexture("#craftng", this.noiseTexture);
				this.AKCDPJMLKCG.SetTexture("InfoButton", temporary);
				this.AKCDPJMLKCG.SetTexture("/", temporary3);
				this.AKCDPJMLKCG.SetFloat("_ScreenResolution", Mathf.Max(497f, this.softZDistance));
				this.AKCDPJMLKCG.SetFloat("_Offsets", value);
				Graphics.Blit(temporary, temporary2, this.AKCDPJMLKCG, 1);
				Graphics.Blit(temporary2, temporary3, this.AKCDPJMLKCG, 1);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.AKCDPJMLKCG, 1);
			}
			else if (this.filterType == CameraMotionBlur.MotionBlurFilter.ReconstructionDX11 || flag)
			{
				this.ABGBGNENPBK.SetFloat("OnDeserialize", Mathf.Max(1550f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.ABGBGNENPBK, 1);
				Graphics.Blit(temporary2, temporary3, this.ABGBGNENPBK, 3);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ABGBGNENPBK, 0);
			}
			else if (this.filterType == CameraMotionBlur.MotionBlurFilter.CameraMotion)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ABGBGNENPBK, 6);
			}
			else if (this.filterType == CameraMotionBlur.MotionBlurFilter.ReconstructionDisc)
			{
				this.ABGBGNENPBK.SetFloat("y", Mathf.Max(1718f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.ABGBGNENPBK, 3);
				Graphics.Blit(temporary2, temporary3, this.ABGBGNENPBK, 7);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ABGBGNENPBK, 8);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ABGBGNENPBK, 6);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
		}

		// Token: 0x06007B15 RID: 31509 RVA: 0x00278134 File Offset: 0x00276334
		public override bool BNMLMGBCHHI()
		{
			base.EFEBIPNEMHL(false, false);
			this.ABGBGNENPBK = base.ECNEGNMAMDE(this.shader, this.ABGBGNENPBK);
			if (this.EAKIOBNBAMI && this.filterType == CameraMotionBlur.MotionBlurFilter.ReconstructionDX11)
			{
				this.AKCDPJMLKCG = base.EDFIBHNHAAB(this.dx11MotionBlurShader, this.AKCDPJMLKCG);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.BPEKKDKKLPM();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007B16 RID: 31510 RVA: 0x002781A8 File Offset: 0x002763A8
		public virtual bool OCADOBLPPAA()
		{
			base.ELMEKIGAKOG(true, true);
			this.ABGBGNENPBK = base.EDFIBHNHAAB(this.shader, this.ABGBGNENPBK);
			if (this.EAKIOBNBAMI && this.filterType == CameraMotionBlur.MotionBlurFilter.CameraMotion)
			{
				this.AKCDPJMLKCG = base.GJKHKCOAFDB(this.dx11MotionBlurShader, this.AKCDPJMLKCG);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007B17 RID: 31511 RVA: 0x0027821C File Offset: 0x0027641C
		private void KLILJHJNICK()
		{
			this.AFNHKGFNOCL();
			if (this.CNMFDOINHOL == null)
			{
				this.CNMFDOINHOL = base.GetComponent<Camera>();
			}
			this.NEGJMHKGFON = base.gameObject.activeInHierarchy;
			this.ANLCFMOEDLK();
			this.OGEAPKCKDOA();
			this.NEGJMHKGFON = true;
		}

		// Token: 0x06007B18 RID: 31512 RVA: 0x00278274 File Offset: 0x00276474
		public virtual bool NOABPEFKKHK()
		{
			base.EPMMNFLLCBK(false, false);
			this.ABGBGNENPBK = base.NODBMINMALP(this.shader, this.ABGBGNENPBK);
			if (this.EAKIOBNBAMI && this.filterType == (CameraMotionBlur.MotionBlurFilter)5)
			{
				this.AKCDPJMLKCG = base.NODBMINMALP(this.dx11MotionBlurShader, this.AKCDPJMLKCG);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007B19 RID: 31513 RVA: 0x002782E8 File Offset: 0x002764E8
		private void FDIJLKIIMLL()
		{
			if (this.CNMFDOINHOL == null)
			{
				this.CNMFDOINHOL = base.GetComponent<Camera>();
			}
			this.CNMFDOINHOL.depthTextureMode |= DepthTextureMode.None;
		}

		// Token: 0x06007B1A RID: 31514 RVA: 0x0027831A File Offset: 0x0027651A
		private void GICPNCEPKLC()
		{
			this.KKIGJMAJCDC = Vector3.Slerp(this.KKIGJMAJCDC, base.transform.position, 1611f);
		}

		// Token: 0x06007B1B RID: 31515 RVA: 0x00276CC9 File Offset: 0x00274EC9
		private void OCHMKJKBAPI()
		{
			if (this.CNMFDOINHOL == null)
			{
				this.CNMFDOINHOL = base.GetComponent<Camera>();
			}
			this.CNMFDOINHOL.depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x06007B1C RID: 31516 RVA: 0x00278340 File Offset: 0x00276540
		private void KCCIEMBMOBA()
		{
			this.NEBKDCMJPEP();
			if (this.CNMFDOINHOL == null)
			{
				this.CNMFDOINHOL = base.GetComponent<Camera>();
			}
			this.NEGJMHKGFON = base.gameObject.activeInHierarchy;
			this.CAMKGAOJIOC();
			this.OGEAPKCKDOA();
			this.NEGJMHKGFON = false;
		}

		// Token: 0x06007B1D RID: 31517 RVA: 0x00278398 File Offset: 0x00276598
		private void LIEGJOHINGC()
		{
			if (null != this.ABGBGNENPBK)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGBGNENPBK);
				this.ABGBGNENPBK = null;
			}
			if (null != this.AKCDPJMLKCG)
			{
				UnityEngine.Object.DestroyImmediate(this.AKCDPJMLKCG);
				this.AKCDPJMLKCG = null;
			}
			if (null != this.AOJJAPNHHLG)
			{
				UnityEngine.Object.DestroyImmediate(this.AOJJAPNHHLG);
				this.AOJJAPNHHLG = null;
			}
		}

		// Token: 0x06007B1E RID: 31518 RVA: 0x00275E66 File Offset: 0x00274066
		private static int HGJDADGBPHB(int IACGDFHKCAE, int LPGNCFKLMEH)
		{
			return (IACGDFHKCAE + LPGNCFKLMEH - 0) / LPGNCFKLMEH;
		}

		// Token: 0x06007B1F RID: 31519 RVA: 0x0027840E File Offset: 0x0027660E
		private void MAHGJDCGDGE()
		{
			this.KKIGJMAJCDC = Vector3.Slerp(this.KKIGJMAJCDC, base.transform.position, 520f);
		}

		// Token: 0x06007B20 RID: 31520 RVA: 0x00278434 File Offset: 0x00276634
		public virtual bool ELHBKCFNCOJ()
		{
			base.BFCJMJJHMFO(false, true);
			this.ABGBGNENPBK = base.AJKPGPKKHHB(this.shader, this.ABGBGNENPBK);
			if (this.EAKIOBNBAMI && this.filterType == (CameraMotionBlur.MotionBlurFilter)6)
			{
				this.AKCDPJMLKCG = base.ECNEGNMAMDE(this.dx11MotionBlurShader, this.AKCDPJMLKCG);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007B21 RID: 31521 RVA: 0x002784A8 File Offset: 0x002766A8
		private void OnDisable()
		{
			if (null != this.ABGBGNENPBK)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGBGNENPBK);
				this.ABGBGNENPBK = null;
			}
			if (null != this.AKCDPJMLKCG)
			{
				UnityEngine.Object.DestroyImmediate(this.AKCDPJMLKCG);
				this.AKCDPJMLKCG = null;
			}
			if (null != this.AOJJAPNHHLG)
			{
				UnityEngine.Object.DestroyImmediate(this.AOJJAPNHHLG);
				this.AOJJAPNHHLG = null;
			}
		}

		// Token: 0x06007B22 RID: 31522 RVA: 0x00278520 File Offset: 0x00276720
		private void PHJLHCMCCKE()
		{
			if (null != this.ABGBGNENPBK)
			{
				UnityEngine.Object.DestroyImmediate(this.ABGBGNENPBK);
				this.ABGBGNENPBK = null;
			}
			if (null != this.AKCDPJMLKCG)
			{
				UnityEngine.Object.DestroyImmediate(this.AKCDPJMLKCG);
				this.AKCDPJMLKCG = null;
			}
			if (null != this.AOJJAPNHHLG)
			{
				UnityEngine.Object.DestroyImmediate(this.AOJJAPNHHLG);
				this.AOJJAPNHHLG = null;
			}
		}

		// Token: 0x06007B23 RID: 31523 RVA: 0x00276F91 File Offset: 0x00275191
		private static int JJGJMCDDBGK(int IACGDFHKCAE, int LPGNCFKLMEH)
		{
			return (IACGDFHKCAE + LPGNCFKLMEH - 1) / LPGNCFKLMEH;
		}

		// Token: 0x06007B24 RID: 31524 RVA: 0x00278596 File Offset: 0x00276796
		private void MIFLJLKFCGK()
		{
			this.KKIGJMAJCDC = Vector3.Slerp(this.KKIGJMAJCDC, base.transform.position, 404f);
		}

		// Token: 0x06007B25 RID: 31525 RVA: 0x002785BC File Offset: 0x002767BC
		private void ANLCFMOEDLK()
		{
			Matrix4x4 worldToCameraMatrix = this.CNMFDOINHOL.worldToCameraMatrix;
			Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.CNMFDOINHOL.projectionMatrix, false);
			this.HCLCEJJCPON = gpuprojectionMatrix * worldToCameraMatrix;
		}

		// Token: 0x06007B26 RID: 31526 RVA: 0x00276F91 File Offset: 0x00275191
		private static int ODIDNMOPLFE(int IACGDFHKCAE, int LPGNCFKLMEH)
		{
			return (IACGDFHKCAE + LPGNCFKLMEH - 1) / LPGNCFKLMEH;
		}

		// Token: 0x06007B27 RID: 31527 RVA: 0x002785F4 File Offset: 0x002767F4
		public virtual bool EAOFDBCPJDI()
		{
			base.EPMMNFLLCBK(true, true);
			this.ABGBGNENPBK = base.LKIJNGDHLAK(this.shader, this.ABGBGNENPBK);
			if (this.EAKIOBNBAMI && this.filterType == (CameraMotionBlur.MotionBlurFilter)6)
			{
				this.AKCDPJMLKCG = base.GJKHKCOAFDB(this.dx11MotionBlurShader, this.AKCDPJMLKCG);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007B28 RID: 31528 RVA: 0x00278668 File Offset: 0x00276868
		private void NKKLGKPFPIK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.filterType == CameraMotionBlur.MotionBlurFilter.CameraMotion)
			{
				this.LIHLMDCLCDA();
			}
			RenderTextureFormat format = (!SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)54)) ? RenderTextureFormat.Default : ((RenderTextureFormat)95);
			RenderTexture temporary = RenderTexture.GetTemporary(CameraMotionBlur.CLDFHDJJFEI(HLBKCLPNHEB.width, this.velocityDownsample), CameraMotionBlur.CLDFHDJJFEI(HLBKCLPNHEB.height, this.velocityDownsample), 1, format);
			this.maxVelocity = Mathf.Max(1467f, this.maxVelocity);
			float value = this.maxVelocity;
			bool flag = this.filterType != (CameraMotionBlur.MotionBlurFilter)8 || this.AKCDPJMLKCG == null;
			int num;
			int height;
			if (this.filterType == CameraMotionBlur.MotionBlurFilter.ReconstructionDX11 || flag || this.filterType == CameraMotionBlur.MotionBlurFilter.Reconstruction)
			{
				this.maxVelocity = Mathf.Min(this.maxVelocity, CameraMotionBlur.CICJMJBLFJM);
				num = CameraMotionBlur.KBBPGLLPKLF(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.NIDPNLMEDBD(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			else
			{
				num = CameraMotionBlur.HGJDADGBPHB(temporary.width, (int)this.maxVelocity);
				height = CameraMotionBlur.HGJDADGBPHB(temporary.height, (int)this.maxVelocity);
				value = (float)(temporary.width / num);
			}
			RenderTexture temporary2 = RenderTexture.GetTemporary(num, height, 1, format);
			RenderTexture temporary3 = RenderTexture.GetTemporary(num, height, 0, format);
			temporary.filterMode = FilterMode.Bilinear;
			temporary2.filterMode = FilterMode.Point;
			temporary3.filterMode = FilterMode.Point;
			if (this.noiseTexture)
			{
				this.noiseTexture.filterMode = FilterMode.Bilinear;
			}
			HLBKCLPNHEB.wrapMode = TextureWrapMode.Repeat;
			temporary.wrapMode = TextureWrapMode.Clamp;
			temporary3.wrapMode = TextureWrapMode.Repeat;
			temporary2.wrapMode = TextureWrapMode.Clamp;
			this.ANLCFMOEDLK();
			if (base.gameObject.activeInHierarchy && !this.NEGJMHKGFON)
			{
				this.OGEAPKCKDOA();
			}
			this.NEGJMHKGFON = base.gameObject.activeInHierarchy;
			Matrix4x4 matrix4x = Matrix4x4.Inverse(this.HCLCEJJCPON);
			this.ABGBGNENPBK.SetMatrix("[PlayerBase] Loaded music", matrix4x);
			this.ABGBGNENPBK.SetMatrix("_Noise", this.CNLKOGMMMEF);
			this.ABGBGNENPBK.SetMatrix("OK", this.CNLKOGMMMEF * matrix4x);
			this.ABGBGNENPBK.SetFloat("_Value5", value);
			this.ABGBGNENPBK.SetFloat("_Value", value);
			this.ABGBGNENPBK.SetFloat("mapselector.tags.", this.minVelocity);
			this.ABGBGNENPBK.SetFloat("ReJoinRoom failed due to offline mode.", this.velocityScale);
			this.ABGBGNENPBK.SetFloat("shader.future", this.jitter);
			this.ABGBGNENPBK.SetTexture("menu.enableselectormusic", this.noiseTexture);
			this.ABGBGNENPBK.SetTexture("-1", temporary);
			this.ABGBGNENPBK.SetTexture("OPEN FILE", temporary3);
			this.ABGBGNENPBK.SetTexture("_ScreenResolution", temporary2);
			if (this.preview)
			{
				Matrix4x4 worldToCameraMatrix = this.CNMFDOINHOL.worldToCameraMatrix;
				Matrix4x4 identity = Matrix4x4.identity;
				identity.SetTRS(this.previewScale * 257f, Quaternion.identity, Vector3.one);
				Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.CNMFDOINHOL.projectionMatrix, false);
				this.CNLKOGMMMEF = gpuprojectionMatrix * identity * worldToCameraMatrix;
				this.ABGBGNENPBK.SetMatrix("start", this.CNLKOGMMMEF);
				this.ABGBGNENPBK.SetMatrix("Loaded Game: ", this.CNLKOGMMMEF * matrix4x);
			}
			if (this.filterType == CameraMotionBlur.MotionBlurFilter.CameraMotion)
			{
				Vector4 zero = Vector4.zero;
				float num2 = Vector3.Dot(base.transform.up, Vector3.up);
				Vector3 rhs = this.KKIGJMAJCDC - base.transform.position;
				float magnitude = rhs.magnitude;
				float num3 = Vector3.Angle(base.transform.up, this.EDDLNBFLOOK) / this.CNMFDOINHOL.fieldOfView * ((float)HLBKCLPNHEB.width * 1421f);
				zero.x = this.rotationScale * num3;
				num3 = Vector3.Angle(base.transform.forward, this.LJOKLLCMDIO) / this.CNMFDOINHOL.fieldOfView * ((float)HLBKCLPNHEB.width * 424f);
				zero.y = this.rotationScale * num2 * num3;
				num3 = Vector3.Angle(base.transform.forward, this.LJOKLLCMDIO) / this.CNMFDOINHOL.fieldOfView * ((float)HLBKCLPNHEB.width * 976f);
				zero.z = this.rotationScale * (799f - num2) * num3;
				if (magnitude > Mathf.Epsilon && this.movementScale > Mathf.Epsilon)
				{
					zero.w = this.movementScale * Vector3.Dot(base.transform.forward, rhs) * ((float)HLBKCLPNHEB.width * 1138f);
					zero.x += this.movementScale * Vector3.Dot(base.transform.up, rhs) * ((float)HLBKCLPNHEB.width * 765f);
					zero.y += this.movementScale * Vector3.Dot(base.transform.right, rhs) * ((float)HLBKCLPNHEB.width * 947f);
				}
				if (this.preview)
				{
					this.ABGBGNENPBK.SetVector("_DepthLevel", new Vector4(this.previewScale.y, this.previewScale.x, 1491f, this.previewScale.z) * 916f * this.CNMFDOINHOL.fieldOfView);
				}
				else
				{
					this.ABGBGNENPBK.SetVector("513510", zero);
				}
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.ABGBGNENPBK, 1);
				Camera camera = null;
				if (this.excludeLayers.value != 0)
				{
					camera = this.EKOMHMEKBEN();
				}
				if (camera && this.excludeLayers.value != 0 && this.replacementClear && this.replacementClear.isSupported)
				{
					camera.targetTexture = temporary;
					camera.cullingMask = this.excludeLayers;
					camera.RenderWithShader(this.replacementClear, string.Empty);
				}
			}
			if (!this.preview && Time.frameCount != this.EKCJCCMALJI)
			{
				this.EKCJCCMALJI = Time.frameCount;
				this.HBJICIOHABC();
			}
			HLBKCLPNHEB.filterMode = FilterMode.Point;
			if (this.showVelocity)
			{
				this.ABGBGNENPBK.SetFloat("_RedAmplifier", this.showVelocityScale);
				Graphics.Blit(temporary, BMMLHGHKBNM, this.ABGBGNENPBK, 0);
			}
			else if (this.filterType == (CameraMotionBlur.MotionBlurFilter)5 && !flag)
			{
				this.AKCDPJMLKCG.SetFloat("setbool", this.minVelocity);
				this.AKCDPJMLKCG.SetFloat("selColor", this.velocityScale);
				this.AKCDPJMLKCG.SetFloat(" BETA", this.jitter);
				this.AKCDPJMLKCG.SetTexture("color", this.noiseTexture);
				this.AKCDPJMLKCG.SetTexture("Texture2", temporary);
				this.AKCDPJMLKCG.SetTexture("CameraFilterPack/Color_Chromatic_Aberration", temporary3);
				this.AKCDPJMLKCG.SetFloat("_BorderColor", Mathf.Max(1703f, this.softZDistance));
				this.AKCDPJMLKCG.SetFloat("GlassesColor", value);
				Graphics.Blit(temporary, temporary2, this.AKCDPJMLKCG, 1);
				Graphics.Blit(temporary2, temporary3, this.AKCDPJMLKCG, 1);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.AKCDPJMLKCG, 8);
			}
			else if (this.filterType == CameraMotionBlur.MotionBlurFilter.ReconstructionDX11 || flag)
			{
				this.ABGBGNENPBK.SetFloat("AvatarImage", Mathf.Max(1021f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.ABGBGNENPBK, 4);
				Graphics.Blit(temporary2, temporary3, this.ABGBGNENPBK, 3);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ABGBGNENPBK, 4);
			}
			else if (this.filterType == CameraMotionBlur.MotionBlurFilter.CameraMotion)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ABGBGNENPBK, 4);
			}
			else if (this.filterType == (CameraMotionBlur.MotionBlurFilter)7)
			{
				this.ABGBGNENPBK.SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", Mathf.Max(1297f, this.softZDistance));
				Graphics.Blit(temporary, temporary2, this.ABGBGNENPBK, 1);
				Graphics.Blit(temporary2, temporary3, this.ABGBGNENPBK, 5);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ABGBGNENPBK, 0);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ABGBGNENPBK, 6);
			}
			RenderTexture.ReleaseTemporary(temporary);
			RenderTexture.ReleaseTemporary(temporary2);
			RenderTexture.ReleaseTemporary(temporary3);
		}

		// Token: 0x06007B29 RID: 31529 RVA: 0x00275E66 File Offset: 0x00274066
		private static int CLDFHDJJFEI(int IACGDFHKCAE, int LPGNCFKLMEH)
		{
			return (IACGDFHKCAE + LPGNCFKLMEH - 0) / LPGNCFKLMEH;
		}

		// Token: 0x06007B2A RID: 31530 RVA: 0x00276CC9 File Offset: 0x00274EC9
		private void OnEnable()
		{
			if (this.CNMFDOINHOL == null)
			{
				this.CNMFDOINHOL = base.GetComponent<Camera>();
			}
			this.CNMFDOINHOL.depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x06007B2B RID: 31531 RVA: 0x00276CC9 File Offset: 0x00274EC9
		private void IFBKMAEMKNN()
		{
			if (this.CNMFDOINHOL == null)
			{
				this.CNMFDOINHOL = base.GetComponent<Camera>();
			}
			this.CNMFDOINHOL.depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x06007B2C RID: 31532 RVA: 0x00278F34 File Offset: 0x00277134
		public override bool OEECIHEGJHE()
		{
			base.LBHKCKBMHJC(true, false);
			this.ABGBGNENPBK = base.EDFIBHNHAAB(this.shader, this.ABGBGNENPBK);
			if (this.EAKIOBNBAMI && this.filterType == (CameraMotionBlur.MotionBlurFilter)6)
			{
				this.AKCDPJMLKCG = base.KDHKHOHMKCG(this.dx11MotionBlurShader, this.AKCDPJMLKCG);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.HKDNNECLBGL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007B2D RID: 31533 RVA: 0x00278FA8 File Offset: 0x002771A8
		private void PFPCPEMODEL()
		{
			Matrix4x4 worldToCameraMatrix = this.CNMFDOINHOL.worldToCameraMatrix;
			Matrix4x4 gpuprojectionMatrix = GL.GetGPUProjectionMatrix(this.CNMFDOINHOL.projectionMatrix, true);
			this.HCLCEJJCPON = gpuprojectionMatrix * worldToCameraMatrix;
		}

		// Token: 0x06007B2E RID: 31534 RVA: 0x00278FE0 File Offset: 0x002771E0
		private Camera CMBJEONLCOP()
		{
			if (this.AOJJAPNHHLG == null)
			{
				string text = "_Value3" + this.CNMFDOINHOL.name + "Dec";
				GameObject gameObject = GameObject.Find(text);
				if (null == gameObject)
				{
					string name = text;
					Type[] array = new Type[1];
					array[1] = typeof(Camera);
					this.AOJJAPNHHLG = new GameObject(name, array);
				}
				else
				{
					this.AOJJAPNHHLG = gameObject;
				}
			}
			this.AOJJAPNHHLG.hideFlags = (HideFlags)101;
			this.AOJJAPNHHLG.transform.position = this.CNMFDOINHOL.transform.position;
			this.AOJJAPNHHLG.transform.rotation = this.CNMFDOINHOL.transform.rotation;
			this.AOJJAPNHHLG.transform.localScale = this.CNMFDOINHOL.transform.localScale;
			this.AOJJAPNHHLG.GetComponent<Camera>().CopyFrom(this.CNMFDOINHOL);
			this.AOJJAPNHHLG.GetComponent<Camera>().enabled = true;
			this.AOJJAPNHHLG.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.AOJJAPNHHLG.GetComponent<Camera>().clearFlags = CameraClearFlags.Skybox;
			return this.AOJJAPNHHLG.GetComponent<Camera>();
		}

		// Token: 0x06007B2F RID: 31535 RVA: 0x00276CC9 File Offset: 0x00274EC9
		private void PPFGHAKKLMN()
		{
			if (this.CNMFDOINHOL == null)
			{
				this.CNMFDOINHOL = base.GetComponent<Camera>();
			}
			this.CNMFDOINHOL.depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x06007B30 RID: 31536 RVA: 0x00279118 File Offset: 0x00277318
		private void HEJAJKMEFIH()
		{
			this.KKIGJMAJCDC = Vector3.Slerp(this.KKIGJMAJCDC, base.transform.position, 0.75f);
		}

		// Token: 0x06007B32 RID: 31538 RVA: 0x002791E4 File Offset: 0x002773E4
		public virtual bool FKHOCKAEMLD()
		{
			base.KMNGKHKHCGA(true, true);
			this.ABGBGNENPBK = base.EDFIBHNHAAB(this.shader, this.ABGBGNENPBK);
			if (this.EAKIOBNBAMI && this.filterType == (CameraMotionBlur.MotionBlurFilter)7)
			{
				this.AKCDPJMLKCG = base.GJKHKCOAFDB(this.dx11MotionBlurShader, this.AKCDPJMLKCG);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007B33 RID: 31539 RVA: 0x00279258 File Offset: 0x00277458
		public virtual bool OOBHPBJOKMD()
		{
			base.AHHCFEMJAOG(false, false);
			this.ABGBGNENPBK = base.EDFIBHNHAAB(this.shader, this.ABGBGNENPBK);
			if (this.EAKIOBNBAMI && this.filterType == (CameraMotionBlur.MotionBlurFilter)5)
			{
				this.AKCDPJMLKCG = base.KDHKHOHMKCG(this.dx11MotionBlurShader, this.AKCDPJMLKCG);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007B34 RID: 31540 RVA: 0x00276F91 File Offset: 0x00275191
		private static int KBBPGLLPKLF(int IACGDFHKCAE, int LPGNCFKLMEH)
		{
			return (IACGDFHKCAE + LPGNCFKLMEH - 1) / LPGNCFKLMEH;
		}

		// Token: 0x06007B35 RID: 31541 RVA: 0x002792CC File Offset: 0x002774CC
		private void NKJIBPGHBMP()
		{
			this.KKIGJMAJCDC = Vector3.Slerp(this.KKIGJMAJCDC, base.transform.position, 1495f);
		}

		// Token: 0x06007B36 RID: 31542 RVA: 0x002782E8 File Offset: 0x002764E8
		private void GBFPAEDPOPP()
		{
			if (this.CNMFDOINHOL == null)
			{
				this.CNMFDOINHOL = base.GetComponent<Camera>();
			}
			this.CNMFDOINHOL.depthTextureMode |= DepthTextureMode.None;
		}

		// Token: 0x06007B37 RID: 31543 RVA: 0x002792F0 File Offset: 0x002774F0
		private void HBJICIOHABC()
		{
			this.CNLKOGMMMEF = this.HCLCEJJCPON;
			this.LJOKLLCMDIO = base.transform.forward;
			this.EDDLNBFLOOK = base.transform.up;
			this.KKIGJMAJCDC = base.transform.position;
		}

		// Token: 0x06007B38 RID: 31544 RVA: 0x0027933C File Offset: 0x0027753C
		private void OGEAPKCKDOA()
		{
			this.CNLKOGMMMEF = this.HCLCEJJCPON;
			this.LJOKLLCMDIO = base.transform.forward;
			this.EDDLNBFLOOK = base.transform.up;
			this.KKIGJMAJCDC = base.transform.position;
		}

		// Token: 0x04000D44 RID: 3396
		private static float CICJMJBLFJM = 10f;

		// Token: 0x04000D45 RID: 3397
		public CameraMotionBlur.MotionBlurFilter filterType = CameraMotionBlur.MotionBlurFilter.Reconstruction;

		// Token: 0x04000D46 RID: 3398
		public bool preview;

		// Token: 0x04000D47 RID: 3399
		public Vector3 previewScale = Vector3.one;

		// Token: 0x04000D48 RID: 3400
		public float movementScale;

		// Token: 0x04000D49 RID: 3401
		public float rotationScale = 1f;

		// Token: 0x04000D4A RID: 3402
		public float maxVelocity = 8f;

		// Token: 0x04000D4B RID: 3403
		public float minVelocity = 0.1f;

		// Token: 0x04000D4C RID: 3404
		public float velocityScale = 0.375f;

		// Token: 0x04000D4D RID: 3405
		public float softZDistance = 0.005f;

		// Token: 0x04000D4E RID: 3406
		public int velocityDownsample = 1;

		// Token: 0x04000D4F RID: 3407
		public LayerMask excludeLayers = 0;

		// Token: 0x04000D50 RID: 3408
		private GameObject AOJJAPNHHLG;

		// Token: 0x04000D51 RID: 3409
		public Shader shader;

		// Token: 0x04000D52 RID: 3410
		public Shader dx11MotionBlurShader;

		// Token: 0x04000D53 RID: 3411
		public Shader replacementClear;

		// Token: 0x04000D54 RID: 3412
		private Material ABGBGNENPBK;

		// Token: 0x04000D55 RID: 3413
		private Material AKCDPJMLKCG;

		// Token: 0x04000D56 RID: 3414
		public Texture2D noiseTexture;

		// Token: 0x04000D57 RID: 3415
		public float jitter = 0.05f;

		// Token: 0x04000D58 RID: 3416
		public bool showVelocity;

		// Token: 0x04000D59 RID: 3417
		public float showVelocityScale = 1f;

		// Token: 0x04000D5A RID: 3418
		private Matrix4x4 HCLCEJJCPON;

		// Token: 0x04000D5B RID: 3419
		private Matrix4x4 CNLKOGMMMEF;

		// Token: 0x04000D5C RID: 3420
		private int EKCJCCMALJI;

		// Token: 0x04000D5D RID: 3421
		private bool NEGJMHKGFON;

		// Token: 0x04000D5E RID: 3422
		private Vector3 LJOKLLCMDIO = Vector3.forward;

		// Token: 0x04000D5F RID: 3423
		private Vector3 EDDLNBFLOOK = Vector3.up;

		// Token: 0x04000D60 RID: 3424
		private Vector3 KKIGJMAJCDC = Vector3.zero;

		// Token: 0x04000D61 RID: 3425
		private Camera CNMFDOINHOL;

		// Token: 0x020001D2 RID: 466
		public enum MotionBlurFilter
		{
			// Token: 0x04000D63 RID: 3427
			CameraMotion,
			// Token: 0x04000D64 RID: 3428
			LocalBlur,
			// Token: 0x04000D65 RID: 3429
			Reconstruction,
			// Token: 0x04000D66 RID: 3430
			ReconstructionDX11,
			// Token: 0x04000D67 RID: 3431
			ReconstructionDisc
		}
	}
}
