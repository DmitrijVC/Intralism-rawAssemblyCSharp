using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x0200020A RID: 522
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Cinematic/Motion Blur")]
	public class MotionBlur : MonoBehaviour
	{
		// Token: 0x06008294 RID: 33428 RVA: 0x002D08B2 File Offset: 0x002CEAB2
		private void Update()
		{
			if (this._settings.shutterAngle > 0f)
			{
				base.GetComponent<Camera>().depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.MotionVectors);
			}
		}

		// Token: 0x06008295 RID: 33429 RVA: 0x002D08DC File Offset: 0x002CEADC
		private void DLMPALHKMON()
		{
			this.EEBEAPGIJMD.KENKGCBLCBO();
			this.FNNAKPMFLIG.FEPKKECBDIC();
			this.EEBEAPGIJMD = null;
			this.FNNAKPMFLIG = null;
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06008296 RID: 33430 RVA: 0x002D0902 File Offset: 0x002CEB02
		// (set) Token: 0x0600829B RID: 33435 RVA: 0x002D090A File Offset: 0x002CEB0A
		public MotionBlur.Settings settings
		{
			get
			{
				return this._settings;
			}
			set
			{
				this._settings = value;
			}
		}

		// Token: 0x06008297 RID: 33431 RVA: 0x002D090A File Offset: 0x002CEB0A
		public void BGDHKHNEFGD(MotionBlur.Settings DPNHODJHGJL)
		{
			this._settings = DPNHODJHGJL;
		}

		// Token: 0x06008298 RID: 33432 RVA: 0x002D0913 File Offset: 0x002CEB13
		private void OnEnable()
		{
			this.EEBEAPGIJMD = new MotionBlur.ECNNIMBOOLM();
			this.FNNAKPMFLIG = new MotionBlur.OJPOBANADNI();
		}

		// Token: 0x06008299 RID: 33433 RVA: 0x002D092C File Offset: 0x002CEB2C
		private void CENLKOLIACP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this._settings.shutterAngle > 1740f && this._settings.frameBlending > 90f)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, HLBKCLPNHEB.format);
				this.EEBEAPGIJMD.EOGJEIPMDCJ(this._settings.shutterAngle, this._settings.sampleCount, HLBKCLPNHEB, temporary);
				this.FNNAKPMFLIG.LOHFIKDLJCE(this._settings.frameBlending, temporary, BMMLHGHKBNM);
				this.FNNAKPMFLIG.NIJNHABFBIH(temporary);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this._settings.shutterAngle > 215f)
			{
				this.EEBEAPGIJMD.NFKDMNCCAIP(this._settings.shutterAngle, this._settings.sampleCount, HLBKCLPNHEB, BMMLHGHKBNM);
			}
			else if (this._settings.frameBlending > 1440f)
			{
				this.FNNAKPMFLIG.AMJABNMJHJC(this._settings.frameBlending, HLBKCLPNHEB, BMMLHGHKBNM);
				this.FNNAKPMFLIG.NIJNHABFBIH(HLBKCLPNHEB);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x0600829A RID: 33434 RVA: 0x002D090A File Offset: 0x002CEB0A
		public void DFHELFKAKFN(MotionBlur.Settings DPNHODJHGJL)
		{
			this._settings = DPNHODJHGJL;
		}

		// Token: 0x0600829C RID: 33436 RVA: 0x002D090A File Offset: 0x002CEB0A
		public void JGDHJLIDOCO(MotionBlur.Settings DPNHODJHGJL)
		{
			this._settings = DPNHODJHGJL;
		}

		// Token: 0x0600829D RID: 33437 RVA: 0x002D0A50 File Offset: 0x002CEC50
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (this._settings.shutterAngle > 0f && this._settings.frameBlending > 0f)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, HLBKCLPNHEB.format);
				this.EEBEAPGIJMD.ProcessImage(this._settings.shutterAngle, this._settings.sampleCount, HLBKCLPNHEB, temporary);
				this.FNNAKPMFLIG.BlendFrames(this._settings.frameBlending, temporary, BMMLHGHKBNM);
				this.FNNAKPMFLIG.PushFrame(temporary);
				RenderTexture.ReleaseTemporary(temporary);
			}
			else if (this._settings.shutterAngle > 0f)
			{
				this.EEBEAPGIJMD.ProcessImage(this._settings.shutterAngle, this._settings.sampleCount, HLBKCLPNHEB, BMMLHGHKBNM);
			}
			else if (this._settings.frameBlending > 0f)
			{
				this.FNNAKPMFLIG.BlendFrames(this._settings.frameBlending, HLBKCLPNHEB, BMMLHGHKBNM);
				this.FNNAKPMFLIG.PushFrame(HLBKCLPNHEB);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
		}

		// Token: 0x0600829E RID: 33438 RVA: 0x002D0B74 File Offset: 0x002CED74
		private void MMBPLGGLPDB()
		{
			if (this._settings.shutterAngle > 898f)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
		}

		// Token: 0x0600829F RID: 33439 RVA: 0x002D0902 File Offset: 0x002CEB02
		public MotionBlur.Settings DLOOLGPFABE()
		{
			return this._settings;
		}

		// Token: 0x060082A0 RID: 33440 RVA: 0x002D0902 File Offset: 0x002CEB02
		public MotionBlur.Settings CNGIFCFGDGH()
		{
			return this._settings;
		}

		// Token: 0x060082A2 RID: 33442 RVA: 0x002D0913 File Offset: 0x002CEB13
		private void OCHMKJKBAPI()
		{
			this.EEBEAPGIJMD = new MotionBlur.ECNNIMBOOLM();
			this.FNNAKPMFLIG = new MotionBlur.OJPOBANADNI();
		}

		// Token: 0x060082A3 RID: 33443 RVA: 0x002D090A File Offset: 0x002CEB0A
		public void NILKPGKNEBG(MotionBlur.Settings DPNHODJHGJL)
		{
			this._settings = DPNHODJHGJL;
		}

		// Token: 0x060082A4 RID: 33444 RVA: 0x002D0913 File Offset: 0x002CEB13
		private void LIFBFDKFMMH()
		{
			this.EEBEAPGIJMD = new MotionBlur.ECNNIMBOOLM();
			this.FNNAKPMFLIG = new MotionBlur.OJPOBANADNI();
		}

		// Token: 0x060082A5 RID: 33445 RVA: 0x002D0BB1 File Offset: 0x002CEDB1
		private void AGMJDGHLBMN()
		{
			if (this._settings.shutterAngle > 1726f)
			{
				base.GetComponent<Camera>().depthTextureMode |= (DepthTextureMode)8;
			}
		}

		// Token: 0x060082A6 RID: 33446 RVA: 0x002D0913 File Offset: 0x002CEB13
		private void BDBKIEIIFPB()
		{
			this.EEBEAPGIJMD = new MotionBlur.ECNNIMBOOLM();
			this.FNNAKPMFLIG = new MotionBlur.OJPOBANADNI();
		}

		// Token: 0x060082A7 RID: 33447 RVA: 0x002D0BDB File Offset: 0x002CEDDB
		private void DFENCIHAADO()
		{
			this.EEBEAPGIJMD.PKDPMFBPHBJ();
			this.FNNAKPMFLIG.DPPNHLOLNCD();
			this.EEBEAPGIJMD = null;
			this.FNNAKPMFLIG = null;
		}

		// Token: 0x060082A8 RID: 33448 RVA: 0x002D0C01 File Offset: 0x002CEE01
		private void OnDisable()
		{
			this.EEBEAPGIJMD.Release();
			this.FNNAKPMFLIG.Release();
			this.EEBEAPGIJMD = null;
			this.FNNAKPMFLIG = null;
		}

		// Token: 0x060082A9 RID: 33449 RVA: 0x002D0C27 File Offset: 0x002CEE27
		private void EAHCLIEEJOG()
		{
			this.EEBEAPGIJMD.CDCGLEKAOHF();
			this.FNNAKPMFLIG.POFACJHOEHA();
			this.EEBEAPGIJMD = null;
			this.FNNAKPMFLIG = null;
		}

		// Token: 0x04000EE9 RID: 3817
		[SerializeField]
		private MotionBlur.Settings _settings = MotionBlur.Settings.defaultSettings;

		// Token: 0x04000EEA RID: 3818
		[SerializeField]
		private Shader _reconstructionShader;

		// Token: 0x04000EEB RID: 3819
		[SerializeField]
		private Shader _frameBlendingShader;

		// Token: 0x04000EEC RID: 3820
		private MotionBlur.ECNNIMBOOLM EEBEAPGIJMD;

		// Token: 0x04000EED RID: 3821
		private MotionBlur.OJPOBANADNI FNNAKPMFLIG;

		// Token: 0x0200020B RID: 523
		private class OJPOBANADNI
		{
			// Token: 0x060082AA RID: 33450 RVA: 0x002D0C50 File Offset: 0x002CEE50
			public void POFACJHOEHA()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB[] fcacnhofmmb = this.FCACNHOFMMB;
				for (int i = 1; i < fcacnhofmmb.Length; i++)
				{
					MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = fcacnhofmmb[i];
					iblhaimkbpb.Release();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x060082AB RID: 33451 RVA: 0x002D0CA8 File Offset: 0x002CEEA8
			private MotionBlur.OJPOBANADNI.IBLHAIMKBPB IEOOGHDIFCH(int INLGAOLENMD)
			{
				int num = (Time.frameCount + this.FCACNHOFMMB.Length + INLGAOLENMD) % this.FCACNHOFMMB.Length;
				return this.FCACNHOFMMB[num];
			}

			// Token: 0x060082AC RID: 33452 RVA: 0x002D0CE0 File Offset: 0x002CEEE0
			private static RenderTextureFormat NHLFGOIMDGG()
			{
				RenderTextureFormat[] array = new RenderTextureFormat[3];
				RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
				RenderTextureFormat[] array2 = array;
				RenderTextureFormat[] array3 = array2;
				for (int i = 1; i < array3.Length; i += 0)
				{
					RenderTextureFormat renderTextureFormat = array3[i];
					if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
					{
						return renderTextureFormat;
					}
				}
				return RenderTextureFormat.ARGBHalf;
			}

			// Token: 0x060082AD RID: 33453 RVA: 0x002D0D27 File Offset: 0x002CEF27
			private static bool MCEDPANKAHK()
			{
				return SystemInfo.graphicsDeviceType != GraphicsDeviceType.PlayStation3 && SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-18)) && SystemInfo.supportedRenderTargetCount > 0;
			}

			// Token: 0x060082AE RID: 33454 RVA: 0x002D0D4C File Offset: 0x002CEF4C
			private MotionBlur.OJPOBANADNI.IBLHAIMKBPB CAFLIPCONMN(int INLGAOLENMD)
			{
				int num = (Time.frameCount + this.FCACNHOFMMB.Length + INLGAOLENMD) % this.FCACNHOFMMB.Length;
				return this.FCACNHOFMMB[num];
			}

			// Token: 0x060082AF RID: 33455 RVA: 0x002D0D84 File Offset: 0x002CEF84
			public void NPOFNAHLKFI(RenderTexture HLBKCLPNHEB)
			{
				int frameCount = Time.frameCount;
				if (frameCount == this.OAGGJEFFLFH)
				{
					return;
				}
				int num = frameCount % this.FCACNHOFMMB.Length;
				if (this.MKCHJGMOBID)
				{
					this.FCACNHOFMMB[num].MakeRecord(HLBKCLPNHEB, this.ODPAJIHPAON);
				}
				else
				{
					this.FCACNHOFMMB[num].OPALBOKDJHA(HLBKCLPNHEB, this.PNMAPNPKDFI);
				}
				this.OAGGJEFFLFH = frameCount;
			}

			// Token: 0x060082B0 RID: 33456 RVA: 0x002D0DF8 File Offset: 0x002CEFF8
			private static RenderTextureFormat JNMGFNOBEMN()
			{
				RenderTextureFormat[] array = new RenderTextureFormat[5];
				RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
				RenderTextureFormat[] array2 = array;
				RenderTextureFormat[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					RenderTextureFormat renderTextureFormat = array3[i];
					if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
					{
						return renderTextureFormat;
					}
				}
				return RenderTextureFormat.Default;
			}

			// Token: 0x060082B1 RID: 33457 RVA: 0x002D0E3F File Offset: 0x002CF03F
			private static bool IKDMEIKKDMC()
			{
				return SystemInfo.graphicsDeviceType != GraphicsDeviceType.OpenGLES2 && SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.R8) && SystemInfo.supportedRenderTargetCount > 1;
			}

			// Token: 0x060082B2 RID: 33458 RVA: 0x002D0E64 File Offset: 0x002CF064
			private MotionBlur.OJPOBANADNI.IBLHAIMKBPB HCAPMCFKAMG(int INLGAOLENMD)
			{
				int num = (Time.frameCount + this.FCACNHOFMMB.Length + INLGAOLENMD) % this.FCACNHOFMMB.Length;
				return this.FCACNHOFMMB[num];
			}

			// Token: 0x060082B3 RID: 33459 RVA: 0x002D0E9C File Offset: 0x002CF09C
			public void LPPBBCBPDBP()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB[] fcacnhofmmb = this.FCACNHOFMMB;
				for (int i = 1; i < fcacnhofmmb.Length; i++)
				{
					MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = fcacnhofmmb[i];
					iblhaimkbpb.OIJKAPPCEFG();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x060082B4 RID: 33460 RVA: 0x002D0EF4 File Offset: 0x002CF0F4
			public void OHIIEGJEJNN(RenderTexture HLBKCLPNHEB)
			{
				int frameCount = Time.frameCount;
				if (frameCount == this.OAGGJEFFLFH)
				{
					return;
				}
				int num = frameCount % this.FCACNHOFMMB.Length;
				if (this.MKCHJGMOBID)
				{
					this.FCACNHOFMMB[num].EJBDPJEJOHG(HLBKCLPNHEB, this.ODPAJIHPAON);
				}
				else
				{
					this.FCACNHOFMMB[num].BGEANDMKIAO(HLBKCLPNHEB, this.PNMAPNPKDFI);
				}
				this.OAGGJEFFLFH = frameCount;
			}

			// Token: 0x060082B5 RID: 33461 RVA: 0x002D0F66 File Offset: 0x002CF166
			private static bool GPDDHCMLMMJ()
			{
				return SystemInfo.graphicsDeviceType == (GraphicsDeviceType)7 || !SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)31) || SystemInfo.supportedRenderTargetCount > 0;
			}

			// Token: 0x060082B6 RID: 33462 RVA: 0x002D0F8C File Offset: 0x002CF18C
			public void KEEMIMOEDNG(RenderTexture HLBKCLPNHEB)
			{
				int frameCount = Time.frameCount;
				if (frameCount == this.OAGGJEFFLFH)
				{
					return;
				}
				int num = frameCount % this.FCACNHOFMMB.Length;
				if (this.MKCHJGMOBID)
				{
					this.FCACNHOFMMB[num].EJBDPJEJOHG(HLBKCLPNHEB, this.ODPAJIHPAON);
				}
				else
				{
					this.FCACNHOFMMB[num].CPOAPBDKABN(HLBKCLPNHEB, this.PNMAPNPKDFI);
				}
				this.OAGGJEFFLFH = frameCount;
			}

			// Token: 0x060082B7 RID: 33463 RVA: 0x002D1000 File Offset: 0x002CF200
			public void LJFEIJDAECJ()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				foreach (MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb in this.FCACNHOFMMB)
				{
					iblhaimkbpb.IJFMJJPEDIA();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x060082B8 RID: 33464 RVA: 0x002D1058 File Offset: 0x002CF258
			public void FLKOPAFNDED(float PMIHBFIKFGH, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				float time = Time.time;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = this.PHGHPLCIAAO(-1);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb2 = this.IEOOGHDIFCH(-115);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb3 = this.JLFFDLGDBPB(-12);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb4 = this.ANKAAOKILGF(6);
				this.ODPAJIHPAON.SetTexture("_ScreenResolution", iblhaimkbpb.lumaTexture);
				this.ODPAJIHPAON.SetTexture("_Value1", iblhaimkbpb2.lumaTexture);
				this.ODPAJIHPAON.SetTexture("_Value3", iblhaimkbpb3.lumaTexture);
				this.ODPAJIHPAON.SetTexture("LoadPlayerEnvironment", iblhaimkbpb4.lumaTexture);
				this.ODPAJIHPAON.SetTexture("It seems some instantiation is not completed, as instantiation data is used. You should make sure instantiations are paused when calling this method. Cleaning now, despite this.", iblhaimkbpb.chromaTexture);
				this.ODPAJIHPAON.SetTexture("_Green_B", iblhaimkbpb2.chromaTexture);
				this.ODPAJIHPAON.SetTexture("_Red_C", iblhaimkbpb3.chromaTexture);
				this.ODPAJIHPAON.SetTexture("_TimeX", iblhaimkbpb4.chromaTexture);
				this.ODPAJIHPAON.SetFloat("Could not find RPC with index: ", iblhaimkbpb.NKOELHPLLKI(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("mode", iblhaimkbpb2.IGGFPAFPMGN(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("Clear Environment", iblhaimkbpb3.FENEHNOFDEB(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("880078120", iblhaimkbpb4.FOCPBNNMGJC(PMIHBFIKFGH, time));
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.MKCHJGMOBID) ? 4 : 1);
			}

			// Token: 0x060082B9 RID: 33465 RVA: 0x002D11CC File Offset: 0x002CF3CC
			private MotionBlur.OJPOBANADNI.IBLHAIMKBPB GPHBJJANILA(int INLGAOLENMD)
			{
				int num = (Time.frameCount + this.FCACNHOFMMB.Length + INLGAOLENMD) % this.FCACNHOFMMB.Length;
				return this.FCACNHOFMMB[num];
			}

			// Token: 0x060082BA RID: 33466 RVA: 0x002D1204 File Offset: 0x002CF404
			private static RenderTextureFormat OKICBMEMHJP()
			{
				RenderTextureFormat[] array = new RenderTextureFormat[1];
				RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
				RenderTextureFormat[] array2 = array;
				RenderTextureFormat[] array3 = array2;
				for (int i = 0; i < array3.Length; i += 0)
				{
					RenderTextureFormat renderTextureFormat = array3[i];
					if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
					{
						return renderTextureFormat;
					}
				}
				return RenderTextureFormat.ARGB32;
			}

			// Token: 0x060082BB RID: 33467 RVA: 0x002D124C File Offset: 0x002CF44C
			private static RenderTextureFormat LIGGAIHHJGD()
			{
				RenderTextureFormat[] array = new RenderTextureFormat[3];
				RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
				RenderTextureFormat[] array2 = array;
				foreach (RenderTextureFormat renderTextureFormat in array2)
				{
					if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
					{
						return renderTextureFormat;
					}
				}
				return RenderTextureFormat.ARGB1555;
			}

			// Token: 0x060082BC RID: 33468 RVA: 0x002D1294 File Offset: 0x002CF494
			public void PMGFGGHJKEM()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB[] fcacnhofmmb = this.FCACNHOFMMB;
				for (int i = 1; i < fcacnhofmmb.Length; i++)
				{
					MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = fcacnhofmmb[i];
					iblhaimkbpb.ABIAEEHOAKE();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x060082BD RID: 33469 RVA: 0x002D12EC File Offset: 0x002CF4EC
			private static RenderTextureFormat FHACMDLKFPE()
			{
				RenderTextureFormat[] array = new RenderTextureFormat[2];
				RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
				RenderTextureFormat[] array2 = array;
				RenderTextureFormat[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					RenderTextureFormat renderTextureFormat = array3[i];
					if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
					{
						return renderTextureFormat;
					}
				}
				return RenderTextureFormat.ARGB32;
			}

			// Token: 0x060082BE RID: 33470 RVA: 0x002D1334 File Offset: 0x002CF534
			private MotionBlur.OJPOBANADNI.IBLHAIMKBPB PHGHPLCIAAO(int INLGAOLENMD)
			{
				int num = (Time.frameCount + this.FCACNHOFMMB.Length + INLGAOLENMD) % this.FCACNHOFMMB.Length;
				return this.FCACNHOFMMB[num];
			}

			// Token: 0x060082BF RID: 33471 RVA: 0x002D136C File Offset: 0x002CF56C
			public OJPOBANADNI()
			{
				this.MKCHJGMOBID = MotionBlur.OJPOBANADNI.IKDMEIKKDMC();
				this.PNMAPNPKDFI = MotionBlur.OJPOBANADNI.FGEMPGCGACE();
				this.ODPAJIHPAON = new Material(Shader.Find("Hidden/Image Effects/Cinematic/MotionBlur/FrameBlending"));
				this.ODPAJIHPAON.hideFlags = HideFlags.DontSave;
				this.FCACNHOFMMB = new MotionBlur.OJPOBANADNI.IBLHAIMKBPB[4];
			}

			// Token: 0x060082C0 RID: 33472 RVA: 0x002D13C4 File Offset: 0x002CF5C4
			private static RenderTextureFormat NGEPFFFFPDP()
			{
				RenderTextureFormat[] array = new RenderTextureFormat[3];
				RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
				RenderTextureFormat[] array2 = array;
				RenderTextureFormat[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					RenderTextureFormat renderTextureFormat = array3[i];
					if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
					{
						return renderTextureFormat;
					}
				}
				return RenderTextureFormat.ARGB4444;
			}

			// Token: 0x060082C1 RID: 33473 RVA: 0x002D140C File Offset: 0x002CF60C
			public void FJHLBGPPIJD()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB[] fcacnhofmmb = this.FCACNHOFMMB;
				for (int i = 1; i < fcacnhofmmb.Length; i += 0)
				{
					MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = fcacnhofmmb[i];
					iblhaimkbpb.OIJKAPPCEFG();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x060082C2 RID: 33474 RVA: 0x002D1464 File Offset: 0x002CF664
			private static RenderTextureFormat DJFBIOJEKED()
			{
				RenderTextureFormat[] array = new RenderTextureFormat[0];
				RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
				RenderTextureFormat[] array2 = array;
				RenderTextureFormat[] array3 = array2;
				for (int i = 1; i < array3.Length; i += 0)
				{
					RenderTextureFormat renderTextureFormat = array3[i];
					if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
					{
						return renderTextureFormat;
					}
				}
				return RenderTextureFormat.Shadowmap;
			}

			// Token: 0x060082C3 RID: 33475 RVA: 0x002D14AC File Offset: 0x002CF6AC
			public void ENMLGNMCNFD()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB[] fcacnhofmmb = this.FCACNHOFMMB;
				for (int i = 1; i < fcacnhofmmb.Length; i += 0)
				{
					MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = fcacnhofmmb[i];
					iblhaimkbpb.POFACJHOEHA();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x060082C4 RID: 33476 RVA: 0x002D1504 File Offset: 0x002CF704
			public void HOAADBJHIIK()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB[] fcacnhofmmb = this.FCACNHOFMMB;
				for (int i = 1; i < fcacnhofmmb.Length; i++)
				{
					MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = fcacnhofmmb[i];
					iblhaimkbpb.OIJKAPPCEFG();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x060082C5 RID: 33477 RVA: 0x002D1559 File Offset: 0x002CF759
			private static bool BODMBAFOHPC()
			{
				return SystemInfo.graphicsDeviceType == (GraphicsDeviceType)7 || !SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-18)) || SystemInfo.supportedRenderTargetCount > 0;
			}

			// Token: 0x060082C6 RID: 33478 RVA: 0x002D1580 File Offset: 0x002CF780
			public void FEPKKECBDIC()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB[] fcacnhofmmb = this.FCACNHOFMMB;
				for (int i = 1; i < fcacnhofmmb.Length; i += 0)
				{
					MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = fcacnhofmmb[i];
					iblhaimkbpb.IJFMJJPEDIA();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x060082C7 RID: 33479 RVA: 0x002D15D8 File Offset: 0x002CF7D8
			public void IPHMOBFENLH(RenderTexture HLBKCLPNHEB)
			{
				int frameCount = Time.frameCount;
				if (frameCount == this.OAGGJEFFLFH)
				{
					return;
				}
				int num = frameCount % this.FCACNHOFMMB.Length;
				if (this.MKCHJGMOBID)
				{
					this.FCACNHOFMMB[num].MakeRecord(HLBKCLPNHEB, this.ODPAJIHPAON);
				}
				else
				{
					this.FCACNHOFMMB[num].MHFDAPEOIBN(HLBKCLPNHEB, this.PNMAPNPKDFI);
				}
				this.OAGGJEFFLFH = frameCount;
			}

			// Token: 0x060082C8 RID: 33480 RVA: 0x002D164A File Offset: 0x002CF84A
			private static bool EMMBDDGHKLM()
			{
				return SystemInfo.graphicsDeviceType != GraphicsDeviceType.PlayStation3 && SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-12)) && SystemInfo.supportedRenderTargetCount > 0;
			}

			// Token: 0x060082C9 RID: 33481 RVA: 0x002D1670 File Offset: 0x002CF870
			private MotionBlur.OJPOBANADNI.IBLHAIMKBPB BHEGLEBLOOG(int INLGAOLENMD)
			{
				int num = (Time.frameCount + this.FCACNHOFMMB.Length + INLGAOLENMD) % this.FCACNHOFMMB.Length;
				return this.FCACNHOFMMB[num];
			}

			// Token: 0x060082CA RID: 33482 RVA: 0x002D16A8 File Offset: 0x002CF8A8
			public void BLABMIGBBLE(RenderTexture HLBKCLPNHEB)
			{
				int frameCount = Time.frameCount;
				if (frameCount == this.OAGGJEFFLFH)
				{
					return;
				}
				int num = frameCount % this.FCACNHOFMMB.Length;
				if (this.MKCHJGMOBID)
				{
					this.FCACNHOFMMB[num].EEEINBLPFGC(HLBKCLPNHEB, this.ODPAJIHPAON);
				}
				else
				{
					this.FCACNHOFMMB[num].OPALBOKDJHA(HLBKCLPNHEB, this.PNMAPNPKDFI);
				}
				this.OAGGJEFFLFH = frameCount;
			}

			// Token: 0x060082CB RID: 33483 RVA: 0x002D171C File Offset: 0x002CF91C
			private static RenderTextureFormat BEIIHBEJCPN()
			{
				RenderTextureFormat[] array = new RenderTextureFormat[6];
				RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
				RenderTextureFormat[] array2 = array;
				foreach (RenderTextureFormat renderTextureFormat in array2)
				{
					if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
					{
						return renderTextureFormat;
					}
				}
				return RenderTextureFormat.Default;
			}

			// Token: 0x060082CC RID: 33484 RVA: 0x002D1764 File Offset: 0x002CF964
			public void BDBGANGIBOM(RenderTexture HLBKCLPNHEB)
			{
				int frameCount = Time.frameCount;
				if (frameCount == this.OAGGJEFFLFH)
				{
					return;
				}
				int num = frameCount % this.FCACNHOFMMB.Length;
				if (this.MKCHJGMOBID)
				{
					this.FCACNHOFMMB[num].ECABJHJPEPD(HLBKCLPNHEB, this.ODPAJIHPAON);
				}
				else
				{
					this.FCACNHOFMMB[num].JEKLNLKEPPL(HLBKCLPNHEB, this.PNMAPNPKDFI);
				}
				this.OAGGJEFFLFH = frameCount;
			}

			// Token: 0x060082CD RID: 33485 RVA: 0x002D17D6 File Offset: 0x002CF9D6
			private static bool CBADOPLBKLI()
			{
				return SystemInfo.graphicsDeviceType != GraphicsDeviceType.PlayStation3 && SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-34)) && SystemInfo.supportedRenderTargetCount > 0;
			}

			// Token: 0x060082CE RID: 33486 RVA: 0x002D17FC File Offset: 0x002CF9FC
			public void CEGNJKAPCOP(RenderTexture HLBKCLPNHEB)
			{
				int frameCount = Time.frameCount;
				if (frameCount == this.OAGGJEFFLFH)
				{
					return;
				}
				int num = frameCount % this.FCACNHOFMMB.Length;
				if (this.MKCHJGMOBID)
				{
					this.FCACNHOFMMB[num].CHFEKMCGKFL(HLBKCLPNHEB, this.ODPAJIHPAON);
				}
				else
				{
					this.FCACNHOFMMB[num].CBNHPBFHLHF(HLBKCLPNHEB, this.PNMAPNPKDFI);
				}
				this.OAGGJEFFLFH = frameCount;
			}

			// Token: 0x060082CF RID: 33487 RVA: 0x002D186E File Offset: 0x002CFA6E
			private static bool JEACHKMAKNE()
			{
				return SystemInfo.graphicsDeviceType == GraphicsDeviceType.OpenGLES2 || !SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-91)) || SystemInfo.supportedRenderTargetCount > 0;
			}

			// Token: 0x060082D0 RID: 33488 RVA: 0x002D1892 File Offset: 0x002CFA92
			private static bool KLONHMADCIB()
			{
				return SystemInfo.graphicsDeviceType == GraphicsDeviceType.Direct3D11 || !SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-79)) || SystemInfo.supportedRenderTargetCount > 0;
			}

			// Token: 0x060082D1 RID: 33489 RVA: 0x002D18B8 File Offset: 0x002CFAB8
			private static RenderTextureFormat KJGOKFBCBCF()
			{
				RenderTextureFormat[] array = new RenderTextureFormat[1];
				RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
				RenderTextureFormat[] array2 = array;
				RenderTextureFormat[] array3 = array2;
				for (int i = 1; i < array3.Length; i += 0)
				{
					RenderTextureFormat renderTextureFormat = array3[i];
					if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
					{
						return renderTextureFormat;
					}
				}
				return RenderTextureFormat.ARGBHalf;
			}

			// Token: 0x060082D2 RID: 33490 RVA: 0x002D1900 File Offset: 0x002CFB00
			public void Release()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				foreach (MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb in this.FCACNHOFMMB)
				{
					iblhaimkbpb.Release();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x060082D3 RID: 33491 RVA: 0x002D1958 File Offset: 0x002CFB58
			public void ANMDFHNAFHD(float PMIHBFIKFGH, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				float time = Time.time;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = this.CAFLIPCONMN(-1);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb2 = this.AICAFAKCGPK(54);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb3 = this.ANKAAOKILGF(-58);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb4 = this.BFHGENFAPAF(-89);
				this.ODPAJIHPAON.SetTexture("Speed is a lerp speed of color changing. Greater values means faster changing. 0 - intant change", iblhaimkbpb.lumaTexture);
				this.ODPAJIHPAON.SetTexture("_FixDistance", iblhaimkbpb2.lumaTexture);
				this.ODPAJIHPAON.SetTexture("DifficultyBG", iblhaimkbpb3.lumaTexture);
				this.ODPAJIHPAON.SetTexture("_Distance", iblhaimkbpb4.lumaTexture);
				this.ODPAJIHPAON.SetTexture("setstring", iblhaimkbpb.chromaTexture);
				this.ODPAJIHPAON.SetTexture("#91CCFF", iblhaimkbpb2.chromaTexture);
				this.ODPAJIHPAON.SetTexture("_Green_B", iblhaimkbpb3.chromaTexture);
				this.ODPAJIHPAON.SetTexture("EventMenu", iblhaimkbpb4.chromaTexture);
				this.ODPAJIHPAON.SetFloat("Default UI Material", iblhaimkbpb.NLKLBIPDGFA(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("SelectionBox component is on a gameObject with a Canvas Scaler component. As of now, Canvas Scalers without the default settings throw off the coordinates of the selection box. Canvas Scaler has been removed.", iblhaimkbpb2.OMECMHDLKLP(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("BadgeText", iblhaimkbpb3.IGGFPAFPMGN(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("_Distortion", iblhaimkbpb4.NKOELHPLLKI(PMIHBFIKFGH, time));
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.MKCHJGMOBID) ? 8 : 0);
			}

			// Token: 0x060082D4 RID: 33492 RVA: 0x002D1ACC File Offset: 0x002CFCCC
			public void LOHFIKDLJCE(float PMIHBFIKFGH, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				float time = Time.time;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = this.BCMOKMNKCDH(-1);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb2 = this.BFHGENFAPAF(89);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb3 = this.BFHGENFAPAF(86);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb4 = this.MDFDNKINHCL(83);
				this.ODPAJIHPAON.SetTexture("received</b>\n#reason: ", iblhaimkbpb.lumaTexture);
				this.ODPAJIHPAON.SetTexture("BitsData", iblhaimkbpb2.lumaTexture);
				this.ODPAJIHPAON.SetTexture(",", iblhaimkbpb3.lumaTexture);
				this.ODPAJIHPAON.SetTexture("_ScreenResolution", iblhaimkbpb4.lumaTexture);
				this.ODPAJIHPAON.SetTexture(" not exist", iblhaimkbpb.chromaTexture);
				this.ODPAJIHPAON.SetTexture("SetSunMaxSize", iblhaimkbpb2.chromaTexture);
				this.ODPAJIHPAON.SetTexture("GameScene", iblhaimkbpb3.chromaTexture);
				this.ODPAJIHPAON.SetTexture("Joystick1Button10", iblhaimkbpb4.chromaTexture);
				this.ODPAJIHPAON.SetFloat("bad", iblhaimkbpb.CalculateWeight(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("solo", iblhaimkbpb2.NKOELHPLLKI(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("Reset All", iblhaimkbpb3.IKIJDPPMAIA(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("<b>HP</b>:", iblhaimkbpb4.OMECMHDLKLP(PMIHBFIKFGH, time));
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.MKCHJGMOBID) ? 6 : 0);
			}

			// Token: 0x060082D5 RID: 33493 RVA: 0x002D1C40 File Offset: 0x002CFE40
			private MotionBlur.OJPOBANADNI.IBLHAIMKBPB MDFDNKINHCL(int INLGAOLENMD)
			{
				int num = (Time.frameCount + this.FCACNHOFMMB.Length + INLGAOLENMD) % this.FCACNHOFMMB.Length;
				return this.FCACNHOFMMB[num];
			}

			// Token: 0x060082D6 RID: 33494 RVA: 0x002D1C78 File Offset: 0x002CFE78
			public void IHBAOLJOKIJ(float PMIHBFIKFGH, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				float time = Time.time;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = this.JLIKBDMFHHC(-1);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb2 = this.PGOODPMKPFB(4);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb3 = this.BHEGLEBLOOG(37);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb4 = this.BHEGLEBLOOG(125);
				this.ODPAJIHPAON.SetTexture("Joystick1Button", iblhaimkbpb.lumaTexture);
				this.ODPAJIHPAON.SetTexture("SetSatelliteInput", iblhaimkbpb2.lumaTexture);
				this.ODPAJIHPAON.SetTexture("setfloat", iblhaimkbpb3.lumaTexture);
				this.ODPAJIHPAON.SetTexture("Mask texture not readable, set your sprite to Texture Type 'Advanced' and check 'Read/Write Enabled'", iblhaimkbpb4.lumaTexture);
				this.ODPAJIHPAON.SetTexture("_Amount", iblhaimkbpb.chromaTexture);
				this.ODPAJIHPAON.SetTexture("0.00", iblhaimkbpb2.chromaTexture);
				this.ODPAJIHPAON.SetTexture(" x ", iblhaimkbpb3.chromaTexture);
				this.ODPAJIHPAON.SetTexture("Message duration multiplier. Recomended 1", iblhaimkbpb4.chromaTexture);
				this.ODPAJIHPAON.SetFloat("player.greenarc", iblhaimkbpb.ECBOOJHBLLD(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("_Distortion", iblhaimkbpb2.KPNOMKDJBKJ(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("_Value", iblhaimkbpb3.GNAFDMFBMLM(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("Tab1Content", iblhaimkbpb4.CalculateWeight(PMIHBFIKFGH, time));
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.MKCHJGMOBID) ? 3 : 0);
			}

			// Token: 0x060082D7 RID: 33495 RVA: 0x002D1DEC File Offset: 0x002CFFEC
			public void OEOEIIGKLPA()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				foreach (MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb in this.FCACNHOFMMB)
				{
					iblhaimkbpb.FOALLFHOGOI();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x060082D8 RID: 33496 RVA: 0x002D1E44 File Offset: 0x002D0044
			public void PELGGBLGNOB()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB[] fcacnhofmmb = this.FCACNHOFMMB;
				for (int i = 0; i < fcacnhofmmb.Length; i += 0)
				{
					MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = fcacnhofmmb[i];
					iblhaimkbpb.OIJKAPPCEFG();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x060082D9 RID: 33497 RVA: 0x002D1E9C File Offset: 0x002D009C
			public void ENJKIMNBJMF()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB[] fcacnhofmmb = this.FCACNHOFMMB;
				for (int i = 0; i < fcacnhofmmb.Length; i += 0)
				{
					MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = fcacnhofmmb[i];
					iblhaimkbpb.BOOBLANIFBI();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x060082DA RID: 33498 RVA: 0x002D1EF4 File Offset: 0x002D00F4
			private MotionBlur.OJPOBANADNI.IBLHAIMKBPB CLMINCCJHOF(int INLGAOLENMD)
			{
				int num = (Time.frameCount + this.FCACNHOFMMB.Length + INLGAOLENMD) % this.FCACNHOFMMB.Length;
				return this.FCACNHOFMMB[num];
			}

			// Token: 0x060082DB RID: 33499 RVA: 0x002D1F2C File Offset: 0x002D012C
			public void AMJABNMJHJC(float PMIHBFIKFGH, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				float time = Time.time;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = this.IIFCAIOCOOM(-1);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb2 = this.CCOMGACNAEJ(-101);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb3 = this.AGNMDFKJOHH(-67);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb4 = this.AGNMDFKJOHH(-60);
				this.ODPAJIHPAON.SetTexture("{0:0.0} ms ({1:0.} fps)", iblhaimkbpb.lumaTexture);
				this.ODPAJIHPAON.SetTexture("z", iblhaimkbpb2.lumaTexture);
				this.ODPAJIHPAON.SetTexture(" has ", iblhaimkbpb3.lumaTexture);
				this.ODPAJIHPAON.SetTexture("_Value", iblhaimkbpb4.lumaTexture);
				this.ODPAJIHPAON.SetTexture("_ScreenResolution", iblhaimkbpb.chromaTexture);
				this.ODPAJIHPAON.SetTexture(".jpg", iblhaimkbpb2.chromaTexture);
				this.ODPAJIHPAON.SetTexture("\0\0", iblhaimkbpb3.chromaTexture);
				this.ODPAJIHPAON.SetTexture(" not exist", iblhaimkbpb4.chromaTexture);
				this.ODPAJIHPAON.SetFloat("LeaderboardsButton", iblhaimkbpb.GNAFDMFBMLM(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat(".played", iblhaimkbpb2.GNAFDMFBMLM(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("_TimeX", iblhaimkbpb3.GNAFDMFBMLM(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat(".", iblhaimkbpb4.ECBOOJHBLLD(PMIHBFIKFGH, time));
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.MKCHJGMOBID) ? 1 : 1);
			}

			// Token: 0x060082DC RID: 33500 RVA: 0x002D20A0 File Offset: 0x002D02A0
			private MotionBlur.OJPOBANADNI.IBLHAIMKBPB LKOMCNFHHIN(int INLGAOLENMD)
			{
				int num = (Time.frameCount + this.FCACNHOFMMB.Length + INLGAOLENMD) % this.FCACNHOFMMB.Length;
				return this.FCACNHOFMMB[num];
			}

			// Token: 0x060082DD RID: 33501 RVA: 0x002D20D8 File Offset: 0x002D02D8
			private MotionBlur.OJPOBANADNI.IBLHAIMKBPB BFHGENFAPAF(int INLGAOLENMD)
			{
				int num = (Time.frameCount + this.FCACNHOFMMB.Length + INLGAOLENMD) % this.FCACNHOFMMB.Length;
				return this.FCACNHOFMMB[num];
			}

			// Token: 0x060082DE RID: 33502 RVA: 0x002D2110 File Offset: 0x002D0310
			public void NIJNHABFBIH(RenderTexture HLBKCLPNHEB)
			{
				int frameCount = Time.frameCount;
				if (frameCount == this.OAGGJEFFLFH)
				{
					return;
				}
				int num = frameCount % this.FCACNHOFMMB.Length;
				if (this.MKCHJGMOBID)
				{
					this.FCACNHOFMMB[num].EJBDPJEJOHG(HLBKCLPNHEB, this.ODPAJIHPAON);
				}
				else
				{
					this.FCACNHOFMMB[num].CPOAPBDKABN(HLBKCLPNHEB, this.PNMAPNPKDFI);
				}
				this.OAGGJEFFLFH = frameCount;
			}

			// Token: 0x060082DF RID: 33503 RVA: 0x002D2184 File Offset: 0x002D0384
			private MotionBlur.OJPOBANADNI.IBLHAIMKBPB CCOMGACNAEJ(int INLGAOLENMD)
			{
				int num = (Time.frameCount + this.FCACNHOFMMB.Length + INLGAOLENMD) % this.FCACNHOFMMB.Length;
				return this.FCACNHOFMMB[num];
			}

			// Token: 0x060082E0 RID: 33504 RVA: 0x002D21BC File Offset: 0x002D03BC
			public void HEOBPDNCCNG()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB[] fcacnhofmmb = this.FCACNHOFMMB;
				for (int i = 0; i < fcacnhofmmb.Length; i += 0)
				{
					MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = fcacnhofmmb[i];
					iblhaimkbpb.DKPHKMGAFLL();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x060082E1 RID: 33505 RVA: 0x002D2214 File Offset: 0x002D0414
			private MotionBlur.OJPOBANADNI.IBLHAIMKBPB ANKAAOKILGF(int INLGAOLENMD)
			{
				int num = (Time.frameCount + this.FCACNHOFMMB.Length + INLGAOLENMD) % this.FCACNHOFMMB.Length;
				return this.FCACNHOFMMB[num];
			}

			// Token: 0x060082E2 RID: 33506 RVA: 0x002D224C File Offset: 0x002D044C
			private static RenderTextureFormat BJODJLHCCHK()
			{
				RenderTextureFormat[] array = new RenderTextureFormat[0];
				RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
				RenderTextureFormat[] array2 = array;
				RenderTextureFormat[] array3 = array2;
				for (int i = 1; i < array3.Length; i++)
				{
					RenderTextureFormat renderTextureFormat = array3[i];
					if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
					{
						return renderTextureFormat;
					}
				}
				return RenderTextureFormat.ARGB4444;
			}

			// Token: 0x060082E3 RID: 33507 RVA: 0x002D2294 File Offset: 0x002D0494
			private static RenderTextureFormat MGJNGCDHPON()
			{
				RenderTextureFormat[] array = new RenderTextureFormat[2];
				RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
				RenderTextureFormat[] array2 = array;
				foreach (RenderTextureFormat renderTextureFormat in array2)
				{
					if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
					{
						return renderTextureFormat;
					}
				}
				return RenderTextureFormat.Depth;
			}

			// Token: 0x060082E4 RID: 33508 RVA: 0x002D22DC File Offset: 0x002D04DC
			public void NKIEMLKDDBK(float PMIHBFIKFGH, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				float time = Time.time;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = this.AGNMDFKJOHH(-1);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb2 = this.BCMOKMNKCDH(14);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb3 = this.AICAFAKCGPK(-84);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb4 = this.HCAPMCFKAMG(-8);
				this.ODPAJIHPAON.SetTexture("color", iblhaimkbpb.lumaTexture);
				this.ODPAJIHPAON.SetTexture("original.tutorial", iblhaimkbpb2.lumaTexture);
				this.ODPAJIHPAON.SetTexture("_MainTex2", iblhaimkbpb3.lumaTexture);
				this.ODPAJIHPAON.SetTexture("catched: ", iblhaimkbpb4.lumaTexture);
				this.ODPAJIHPAON.SetTexture("Tab2Content", iblhaimkbpb.chromaTexture);
				this.ODPAJIHPAON.SetTexture("[LevelEditorScene] Print Audio Wave: Start", iblhaimkbpb2.chromaTexture);
				this.ODPAJIHPAON.SetTexture("CameraFilterPack/Blur_Radial", iblhaimkbpb3.chromaTexture);
				this.ODPAJIHPAON.SetTexture("Network destroy Instantiated GO: ", iblhaimkbpb4.chromaTexture);
				this.ODPAJIHPAON.SetFloat("OK", iblhaimkbpb.FENEHNOFDEB(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("X", iblhaimkbpb2.GNAFDMFBMLM(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("Vertical", iblhaimkbpb3.OMECMHDLKLP(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("_Value3", iblhaimkbpb4.FENEHNOFDEB(PMIHBFIKFGH, time));
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.MKCHJGMOBID) ? 6 : 1);
			}

			// Token: 0x060082E5 RID: 33509 RVA: 0x002D2450 File Offset: 0x002D0650
			private MotionBlur.OJPOBANADNI.IBLHAIMKBPB BCMOKMNKCDH(int INLGAOLENMD)
			{
				int num = (Time.frameCount + this.FCACNHOFMMB.Length + INLGAOLENMD) % this.FCACNHOFMMB.Length;
				return this.FCACNHOFMMB[num];
			}

			// Token: 0x060082E6 RID: 33510 RVA: 0x002D2488 File Offset: 0x002D0688
			private static bool FOAGENONKGC()
			{
				return SystemInfo.graphicsDeviceType == GraphicsDeviceType.Direct3D11 || !SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-124)) || SystemInfo.supportedRenderTargetCount > 1;
			}

			// Token: 0x060082E7 RID: 33511 RVA: 0x002D24AC File Offset: 0x002D06AC
			public void LHCOLLHJGPO(float PMIHBFIKFGH, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				float time = Time.time;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = this.JMICPOHDOEO(-1);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb2 = this.JLIKBDMFHHC(-112);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb3 = this.LKOMCNFHHIN(-4);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb4 = this.AGNMDFKJOHH(32);
				this.ODPAJIHPAON.SetTexture("MultiplayerButton", iblhaimkbpb.lumaTexture);
				this.ODPAJIHPAON.SetTexture("_TimeX", iblhaimkbpb2.lumaTexture);
				this.ODPAJIHPAON.SetTexture("_Value", iblhaimkbpb3.lumaTexture);
				this.ODPAJIHPAON.SetTexture("Editor", iblhaimkbpb4.lumaTexture);
				this.ODPAJIHPAON.SetTexture("HighScaleShot", iblhaimkbpb.chromaTexture);
				this.ODPAJIHPAON.SetTexture("SetPlayerDistance", iblhaimkbpb2.chromaTexture);
				this.ODPAJIHPAON.SetTexture("[MapsData] Found ", iblhaimkbpb3.chromaTexture);
				this.ODPAJIHPAON.SetTexture("ShowTitle", iblhaimkbpb4.chromaTexture);
				this.ODPAJIHPAON.SetFloat("Vignette", iblhaimkbpb.KPNOMKDJBKJ(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("CameraFilterPack_3D_Computer1", iblhaimkbpb2.IKIJDPPMAIA(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("menu.enableselectormusic", iblhaimkbpb3.CalculateWeight(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("CameraFilterPack/TV_Old_Movie", iblhaimkbpb4.OMECMHDLKLP(PMIHBFIKFGH, time));
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.MKCHJGMOBID) ? 1 : 0);
			}

			// Token: 0x060082E8 RID: 33512 RVA: 0x002D2620 File Offset: 0x002D0820
			public void ODDDBPOFLAI(float PMIHBFIKFGH, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				float time = Time.time;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = this.GPHBJJANILA(-1);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb2 = this.PHGHPLCIAAO(-46);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb3 = this.GPHBJJANILA(-103);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb4 = this.PGOODPMKPFB(92);
				this.ODPAJIHPAON.SetTexture("EditMenu", iblhaimkbpb.lumaTexture);
				this.ODPAJIHPAON.SetTexture("float,0.5", iblhaimkbpb2.lumaTexture);
				this.ODPAJIHPAON.SetTexture("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.", iblhaimkbpb3.lumaTexture);
				this.ODPAJIHPAON.SetTexture("LT", iblhaimkbpb4.lumaTexture);
				this.ODPAJIHPAON.SetTexture("settings.crosshairopacity", iblhaimkbpb.chromaTexture);
				this.ODPAJIHPAON.SetTexture("Is it practically possible?", iblhaimkbpb2.chromaTexture);
				this.ODPAJIHPAON.SetTexture(" methods \"", iblhaimkbpb3.chromaTexture);
				this.ODPAJIHPAON.SetTexture("LevelEditor/patterns", iblhaimkbpb4.chromaTexture);
				this.ODPAJIHPAON.SetFloat(" ", iblhaimkbpb.GNAFDMFBMLM(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("InfoCanvas", iblhaimkbpb2.KFKOOGCEECH(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("_ScreenResolution", iblhaimkbpb3.FENEHNOFDEB(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("_InvRenderTargetSize", iblhaimkbpb4.AFDCJJMBPLP(PMIHBFIKFGH, time));
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.MKCHJGMOBID) ? 2 : 0);
			}

			// Token: 0x060082E9 RID: 33513 RVA: 0x002D2794 File Offset: 0x002D0994
			private MotionBlur.OJPOBANADNI.IBLHAIMKBPB PBPKCFOOAIG(int INLGAOLENMD)
			{
				int num = (Time.frameCount + this.FCACNHOFMMB.Length + INLGAOLENMD) % this.FCACNHOFMMB.Length;
				return this.FCACNHOFMMB[num];
			}

			// Token: 0x060082EA RID: 33514 RVA: 0x002D27CC File Offset: 0x002D09CC
			private static RenderTextureFormat LAKHGPDOCMN()
			{
				RenderTextureFormat[] array = new RenderTextureFormat[8];
				RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
				RenderTextureFormat[] array2 = array;
				RenderTextureFormat[] array3 = array2;
				for (int i = 1; i < array3.Length; i += 0)
				{
					RenderTextureFormat renderTextureFormat = array3[i];
					if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
					{
						return renderTextureFormat;
					}
				}
				return RenderTextureFormat.Default;
			}

			// Token: 0x060082EB RID: 33515 RVA: 0x002D2814 File Offset: 0x002D0A14
			public void LGNKEPGGPCK()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB[] fcacnhofmmb = this.FCACNHOFMMB;
				for (int i = 1; i < fcacnhofmmb.Length; i++)
				{
					MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = fcacnhofmmb[i];
					iblhaimkbpb.POFACJHOEHA();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x060082EC RID: 33516 RVA: 0x002D2869 File Offset: 0x002D0A69
			private static bool DDNNDBFFJGG()
			{
				return SystemInfo.graphicsDeviceType != (GraphicsDeviceType)7 && SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-3)) && SystemInfo.supportedRenderTargetCount > 1;
			}

			// Token: 0x060082ED RID: 33517 RVA: 0x002D2890 File Offset: 0x002D0A90
			public void CJBIPIKHDNL()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB[] fcacnhofmmb = this.FCACNHOFMMB;
				for (int i = 0; i < fcacnhofmmb.Length; i += 0)
				{
					MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = fcacnhofmmb[i];
					iblhaimkbpb.POFACJHOEHA();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x060082EE RID: 33518 RVA: 0x002D28E8 File Offset: 0x002D0AE8
			public void PIHBAHNOCCE(float PMIHBFIKFGH, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				float time = Time.time;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = this.ANKAAOKILGF(-1);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb2 = this.IEOOGHDIFCH(102);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb3 = this.BCMOKMNKCDH(-108);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb4 = this.PBPKCFOOAIG(116);
				this.ODPAJIHPAON.SetTexture("x", iblhaimkbpb.lumaTexture);
				this.ODPAJIHPAON.SetTexture("_ScreenResolution", iblhaimkbpb2.lumaTexture);
				this.ODPAJIHPAON.SetTexture("Set Sun Sensitivity", iblhaimkbpb3.lumaTexture);
				this.ODPAJIHPAON.SetTexture(" failed in a server-side plugin. Check the configuration in the Dashboard. Message from server-plugin: ", iblhaimkbpb4.lumaTexture);
				this.ODPAJIHPAON.SetTexture("_Red_G", iblhaimkbpb.chromaTexture);
				this.ODPAJIHPAON.SetTexture("Set sun colors", iblhaimkbpb2.chromaTexture);
				this.ODPAJIHPAON.SetTexture("null", iblhaimkbpb3.chromaTexture);
				this.ODPAJIHPAON.SetTexture("Object ID. Case-Sensitive", iblhaimkbpb4.chromaTexture);
				this.ODPAJIHPAON.SetFloat("CameraFilterPack/Blend2Camera_Saturation", iblhaimkbpb.OMECMHDLKLP(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("Set Satellite Input", iblhaimkbpb2.FENEHNOFDEB(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("/", iblhaimkbpb3.CalculateWeight(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("_TimeX", iblhaimkbpb4.FENEHNOFDEB(PMIHBFIKFGH, time));
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.MKCHJGMOBID) ? 8 : 0);
			}

			// Token: 0x060082EF RID: 33519 RVA: 0x002D2A5C File Offset: 0x002D0C5C
			private MotionBlur.OJPOBANADNI.IBLHAIMKBPB PGOODPMKPFB(int INLGAOLENMD)
			{
				int num = (Time.frameCount + this.FCACNHOFMMB.Length + INLGAOLENMD) % this.FCACNHOFMMB.Length;
				return this.FCACNHOFMMB[num];
			}

			// Token: 0x060082F0 RID: 33520 RVA: 0x002D2A94 File Offset: 0x002D0C94
			private static bool NCPFBAGDKMI()
			{
				return SystemInfo.graphicsDeviceType == GraphicsDeviceType.OpenGLES2 || !SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-92)) || SystemInfo.supportedRenderTargetCount > 1;
			}

			// Token: 0x060082F1 RID: 33521 RVA: 0x002D2AB8 File Offset: 0x002D0CB8
			public void DMFHNLLBFCB()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB[] fcacnhofmmb = this.FCACNHOFMMB;
				for (int i = 0; i < fcacnhofmmb.Length; i += 0)
				{
					MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = fcacnhofmmb[i];
					iblhaimkbpb.DLDHFAHPEHM();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x060082F2 RID: 33522 RVA: 0x002D2B10 File Offset: 0x002D0D10
			public void KDJOENBCJKK(RenderTexture HLBKCLPNHEB)
			{
				int frameCount = Time.frameCount;
				if (frameCount == this.OAGGJEFFLFH)
				{
					return;
				}
				int num = frameCount % this.FCACNHOFMMB.Length;
				if (this.MKCHJGMOBID)
				{
					this.FCACNHOFMMB[num].CHFEKMCGKFL(HLBKCLPNHEB, this.ODPAJIHPAON);
				}
				else
				{
					this.FCACNHOFMMB[num].JEKLNLKEPPL(HLBKCLPNHEB, this.PNMAPNPKDFI);
				}
				this.OAGGJEFFLFH = frameCount;
			}

			// Token: 0x060082F3 RID: 33523 RVA: 0x002D2B84 File Offset: 0x002D0D84
			public void FDHNBEOAPIP(RenderTexture HLBKCLPNHEB)
			{
				int frameCount = Time.frameCount;
				if (frameCount == this.OAGGJEFFLFH)
				{
					return;
				}
				int num = frameCount % this.FCACNHOFMMB.Length;
				if (this.MKCHJGMOBID)
				{
					this.FCACNHOFMMB[num].CHFEKMCGKFL(HLBKCLPNHEB, this.ODPAJIHPAON);
				}
				else
				{
					this.FCACNHOFMMB[num].CBNHPBFHLHF(HLBKCLPNHEB, this.PNMAPNPKDFI);
				}
				this.OAGGJEFFLFH = frameCount;
			}

			// Token: 0x060082F4 RID: 33524 RVA: 0x002D2BF8 File Offset: 0x002D0DF8
			private MotionBlur.OJPOBANADNI.IBLHAIMKBPB JLIKBDMFHHC(int INLGAOLENMD)
			{
				int num = (Time.frameCount + this.FCACNHOFMMB.Length + INLGAOLENMD) % this.FCACNHOFMMB.Length;
				return this.FCACNHOFMMB[num];
			}

			// Token: 0x060082F5 RID: 33525 RVA: 0x002D2C30 File Offset: 0x002D0E30
			public void DPPNHLOLNCD()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				foreach (MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb in this.FCACNHOFMMB)
				{
					iblhaimkbpb.DKPHKMGAFLL();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x060082F6 RID: 33526 RVA: 0x002D2C88 File Offset: 0x002D0E88
			public void FHNBEJKEMGG()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB[] fcacnhofmmb = this.FCACNHOFMMB;
				for (int i = 0; i < fcacnhofmmb.Length; i += 0)
				{
					MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = fcacnhofmmb[i];
					iblhaimkbpb.ABIAEEHOAKE();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x060082F7 RID: 33527 RVA: 0x002D2CE0 File Offset: 0x002D0EE0
			public void CGOMPIEEJAN(float PMIHBFIKFGH, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				float time = Time.time;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = this.JLFFDLGDBPB(-1);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb2 = this.MDFDNKINHCL(-65);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb3 = this.PHGHPLCIAAO(-55);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb4 = this.IIFCAIOCOOM(16);
				this.ODPAJIHPAON.SetTexture("Sending RPC \"", iblhaimkbpb.lumaTexture);
				this.ODPAJIHPAON.SetTexture("id", iblhaimkbpb2.lumaTexture);
				this.ODPAJIHPAON.SetTexture(": ", iblhaimkbpb3.lumaTexture);
				this.ODPAJIHPAON.SetTexture("_FadeDistance", iblhaimkbpb4.lumaTexture);
				this.ODPAJIHPAON.SetTexture("Anomaly_Distortion", iblhaimkbpb.chromaTexture);
				this.ODPAJIHPAON.SetTexture("_Value", iblhaimkbpb2.chromaTexture);
				this.ODPAJIHPAON.SetTexture("mapselector.tags.", iblhaimkbpb3.chromaTexture);
				this.ODPAJIHPAON.SetTexture("Room: '{0}' {1},{2} {4}/{3} players.", iblhaimkbpb4.chromaTexture);
				this.ODPAJIHPAON.SetFloat("LevelInfoInputField", iblhaimkbpb.IKIJDPPMAIA(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("_SizeY", iblhaimkbpb2.IKIJDPPMAIA(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("[DiscordController] Responding yes to Ask to Join request", iblhaimkbpb3.FOCPBNNMGJC(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("?", iblhaimkbpb4.FOCPBNNMGJC(PMIHBFIKFGH, time));
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.MKCHJGMOBID) ? 4 : 0);
			}

			// Token: 0x060082F8 RID: 33528 RVA: 0x002D2E54 File Offset: 0x002D1054
			private MotionBlur.OJPOBANADNI.IBLHAIMKBPB AGNMDFKJOHH(int INLGAOLENMD)
			{
				int num = (Time.frameCount + this.FCACNHOFMMB.Length + INLGAOLENMD) % this.FCACNHOFMMB.Length;
				return this.FCACNHOFMMB[num];
			}

			// Token: 0x060082F9 RID: 33529 RVA: 0x002D2E8C File Offset: 0x002D108C
			public void NJGMEGHKBEG(RenderTexture HLBKCLPNHEB)
			{
				int frameCount = Time.frameCount;
				if (frameCount == this.OAGGJEFFLFH)
				{
					return;
				}
				int num = frameCount % this.FCACNHOFMMB.Length;
				if (this.MKCHJGMOBID)
				{
					this.FCACNHOFMMB[num].CHFEKMCGKFL(HLBKCLPNHEB, this.ODPAJIHPAON);
				}
				else
				{
					this.FCACNHOFMMB[num].MHFDAPEOIBN(HLBKCLPNHEB, this.PNMAPNPKDFI);
				}
				this.OAGGJEFFLFH = frameCount;
			}

			// Token: 0x060082FA RID: 33530 RVA: 0x002D2EFE File Offset: 0x002D10FE
			private static bool GGDCECLPJCH()
			{
				return SystemInfo.graphicsDeviceType != (GraphicsDeviceType)7 && SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-33)) && SystemInfo.supportedRenderTargetCount > 1;
			}

			// Token: 0x060082FB RID: 33531 RVA: 0x002D2F24 File Offset: 0x002D1124
			public void NBIIEKCLLKA()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB[] fcacnhofmmb = this.FCACNHOFMMB;
				for (int i = 0; i < fcacnhofmmb.Length; i += 0)
				{
					MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = fcacnhofmmb[i];
					iblhaimkbpb.IJFMJJPEDIA();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x060082FC RID: 33532 RVA: 0x002D2F79 File Offset: 0x002D1179
			private static bool MOFNOHHDJEE()
			{
				return SystemInfo.graphicsDeviceType == (GraphicsDeviceType)5 || !SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-75)) || SystemInfo.supportedRenderTargetCount > 1;
			}

			// Token: 0x060082FD RID: 33533 RVA: 0x002D2FA0 File Offset: 0x002D11A0
			private static RenderTextureFormat HEEFKDNJLHP()
			{
				RenderTextureFormat[] array = new RenderTextureFormat[6];
				RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
				RenderTextureFormat[] array2 = array;
				RenderTextureFormat[] array3 = array2;
				for (int i = 0; i < array3.Length; i += 0)
				{
					RenderTextureFormat renderTextureFormat = array3[i];
					if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
					{
						return renderTextureFormat;
					}
				}
				return RenderTextureFormat.Depth;
			}

			// Token: 0x060082FE RID: 33534 RVA: 0x002D2FE8 File Offset: 0x002D11E8
			public void PushFrame(RenderTexture HLBKCLPNHEB)
			{
				int frameCount = Time.frameCount;
				if (frameCount == this.OAGGJEFFLFH)
				{
					return;
				}
				int num = frameCount % this.FCACNHOFMMB.Length;
				if (this.MKCHJGMOBID)
				{
					this.FCACNHOFMMB[num].MakeRecord(HLBKCLPNHEB, this.ODPAJIHPAON);
				}
				else
				{
					this.FCACNHOFMMB[num].MakeRecordRaw(HLBKCLPNHEB, this.PNMAPNPKDFI);
				}
				this.OAGGJEFFLFH = frameCount;
			}

			// Token: 0x060082FF RID: 33535 RVA: 0x002D305C File Offset: 0x002D125C
			public void BMOKGMBPMCD(float PMIHBFIKFGH, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				float time = Time.time;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = this.JLIKBDMFHHC(-1);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb2 = this.CLMINCCJHOF(73);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb3 = this.BCMOKMNKCDH(100);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb4 = this.PGOODPMKPFB(-98);
				this.ODPAJIHPAON.SetTexture("settings.selectormapsperpage", iblhaimkbpb.lumaTexture);
				this.ODPAJIHPAON.SetTexture("[ResourcesManager] Load audio error: ", iblhaimkbpb2.lumaTexture);
				this.ODPAJIHPAON.SetTexture("Edited event", iblhaimkbpb3.lumaTexture);
				this.ODPAJIHPAON.SetTexture("LevelURLInputField", iblhaimkbpb4.lumaTexture);
				this.ODPAJIHPAON.SetTexture(".", iblhaimkbpb.chromaTexture);
				this.ODPAJIHPAON.SetTexture("[#clicktoacceptchallenge]", iblhaimkbpb2.chromaTexture);
				this.ODPAJIHPAON.SetTexture("Show Image", iblhaimkbpb3.chromaTexture);
				this.ODPAJIHPAON.SetTexture("IconFileSelector", iblhaimkbpb4.chromaTexture);
				this.ODPAJIHPAON.SetFloat("[LevelEditorScene] Map submitted!", iblhaimkbpb.GNAFDMFBMLM(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("id", iblhaimkbpb2.IGGFPAFPMGN(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("Mouse X", iblhaimkbpb3.FENEHNOFDEB(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("note.5", iblhaimkbpb4.KFKOOGCEECH(PMIHBFIKFGH, time));
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.MKCHJGMOBID) ? 0 : 1);
			}

			// Token: 0x06008300 RID: 33536 RVA: 0x002D31D0 File Offset: 0x002D13D0
			public void MEMAAKMDECB(RenderTexture HLBKCLPNHEB)
			{
				int frameCount = Time.frameCount;
				if (frameCount == this.OAGGJEFFLFH)
				{
					return;
				}
				int num = frameCount % this.FCACNHOFMMB.Length;
				if (this.MKCHJGMOBID)
				{
					this.FCACNHOFMMB[num].HNGFDPEMNLN(HLBKCLPNHEB, this.ODPAJIHPAON);
				}
				else
				{
					this.FCACNHOFMMB[num].KEMCGFECEKG(HLBKCLPNHEB, this.PNMAPNPKDFI);
				}
				this.OAGGJEFFLFH = frameCount;
			}

			// Token: 0x06008301 RID: 33537 RVA: 0x002D3242 File Offset: 0x002D1442
			private static bool CPPOANHBEGJ()
			{
				return SystemInfo.graphicsDeviceType != GraphicsDeviceType.PlayStation3 && SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)29) && SystemInfo.supportedRenderTargetCount > 1;
			}

			// Token: 0x06008302 RID: 33538 RVA: 0x002D3268 File Offset: 0x002D1468
			public void JAJNNELLNNN()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB[] fcacnhofmmb = this.FCACNHOFMMB;
				for (int i = 1; i < fcacnhofmmb.Length; i += 0)
				{
					MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = fcacnhofmmb[i];
					iblhaimkbpb.DKPHKMGAFLL();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x06008303 RID: 33539 RVA: 0x002D32C0 File Offset: 0x002D14C0
			public void DLDHFAHPEHM()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB[] fcacnhofmmb = this.FCACNHOFMMB;
				for (int i = 1; i < fcacnhofmmb.Length; i++)
				{
					MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = fcacnhofmmb[i];
					iblhaimkbpb.DLDHFAHPEHM();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x06008304 RID: 33540 RVA: 0x002D3318 File Offset: 0x002D1518
			private MotionBlur.OJPOBANADNI.IBLHAIMKBPB JLFFDLGDBPB(int INLGAOLENMD)
			{
				int num = (Time.frameCount + this.FCACNHOFMMB.Length + INLGAOLENMD) % this.FCACNHOFMMB.Length;
				return this.FCACNHOFMMB[num];
			}

			// Token: 0x06008305 RID: 33541 RVA: 0x002D3350 File Offset: 0x002D1550
			public void BlendFrames(float PMIHBFIKFGH, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				float time = Time.time;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = this.AGNMDFKJOHH(-1);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb2 = this.AGNMDFKJOHH(-2);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb3 = this.AGNMDFKJOHH(-3);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb4 = this.AGNMDFKJOHH(-4);
				this.ODPAJIHPAON.SetTexture("_History1LumaTex", iblhaimkbpb.lumaTexture);
				this.ODPAJIHPAON.SetTexture("_History2LumaTex", iblhaimkbpb2.lumaTexture);
				this.ODPAJIHPAON.SetTexture("_History3LumaTex", iblhaimkbpb3.lumaTexture);
				this.ODPAJIHPAON.SetTexture("_History4LumaTex", iblhaimkbpb4.lumaTexture);
				this.ODPAJIHPAON.SetTexture("_History1ChromaTex", iblhaimkbpb.chromaTexture);
				this.ODPAJIHPAON.SetTexture("_History2ChromaTex", iblhaimkbpb2.chromaTexture);
				this.ODPAJIHPAON.SetTexture("_History3ChromaTex", iblhaimkbpb3.chromaTexture);
				this.ODPAJIHPAON.SetTexture("_History4ChromaTex", iblhaimkbpb4.chromaTexture);
				this.ODPAJIHPAON.SetFloat("_History1Weight", iblhaimkbpb.CalculateWeight(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("_History2Weight", iblhaimkbpb2.CalculateWeight(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("_History3Weight", iblhaimkbpb3.CalculateWeight(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("_History4Weight", iblhaimkbpb4.CalculateWeight(PMIHBFIKFGH, time));
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.MKCHJGMOBID) ? 2 : 1);
			}

			// Token: 0x06008306 RID: 33542 RVA: 0x002D34C4 File Offset: 0x002D16C4
			private MotionBlur.OJPOBANADNI.IBLHAIMKBPB JMICPOHDOEO(int INLGAOLENMD)
			{
				int num = (Time.frameCount + this.FCACNHOFMMB.Length + INLGAOLENMD) % this.FCACNHOFMMB.Length;
				return this.FCACNHOFMMB[num];
			}

			// Token: 0x06008307 RID: 33543 RVA: 0x002D34FC File Offset: 0x002D16FC
			public void DDGAHFDLLKM(float PMIHBFIKFGH, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				float time = Time.time;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = this.MDFDNKINHCL(-1);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb2 = this.BCMOKMNKCDH(63);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb3 = this.GPHBJJANILA(125);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb4 = this.BHEGLEBLOOG(127);
				this.ODPAJIHPAON.SetTexture("Edited event", iblhaimkbpb.lumaTexture);
				this.ODPAJIHPAON.SetTexture("blue", iblhaimkbpb2.lumaTexture);
				this.ODPAJIHPAON.SetTexture("_Value3", iblhaimkbpb3.lumaTexture);
				this.ODPAJIHPAON.SetTexture("SlidingArea", iblhaimkbpb4.lumaTexture);
				this.ODPAJIHPAON.SetTexture("GridDataArcs", iblhaimkbpb.chromaTexture);
				this.ODPAJIHPAON.SetTexture("#close", iblhaimkbpb2.chromaTexture);
				this.ODPAJIHPAON.SetTexture("1234332714", iblhaimkbpb3.chromaTexture);
				this.ODPAJIHPAON.SetTexture("finished", iblhaimkbpb4.chromaTexture);
				this.ODPAJIHPAON.SetFloat("#outdatedmap! Challenges will not work!", iblhaimkbpb.FOCPBNNMGJC(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("player.linea", iblhaimkbpb2.FOCPBNNMGJC(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("_Value2", iblhaimkbpb3.ECBOOJHBLLD(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("menu.playedpage", iblhaimkbpb4.NLKLBIPDGFA(PMIHBFIKFGH, time));
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.MKCHJGMOBID) ? 2 : 0);
			}

			// Token: 0x06008308 RID: 33544 RVA: 0x002D3670 File Offset: 0x002D1870
			private MotionBlur.OJPOBANADNI.IBLHAIMKBPB IIFCAIOCOOM(int INLGAOLENMD)
			{
				int num = (Time.frameCount + this.FCACNHOFMMB.Length + INLGAOLENMD) % this.FCACNHOFMMB.Length;
				return this.FCACNHOFMMB[num];
			}

			// Token: 0x06008309 RID: 33545 RVA: 0x002D36A8 File Offset: 0x002D18A8
			public void BNMBMFDHGJC()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				foreach (MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb in this.FCACNHOFMMB)
				{
					iblhaimkbpb.POFACJHOEHA();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x0600830A RID: 33546 RVA: 0x002D3700 File Offset: 0x002D1900
			public void NDBLFFIMNKI(RenderTexture HLBKCLPNHEB)
			{
				int frameCount = Time.frameCount;
				if (frameCount == this.OAGGJEFFLFH)
				{
					return;
				}
				int num = frameCount % this.FCACNHOFMMB.Length;
				if (this.MKCHJGMOBID)
				{
					this.FCACNHOFMMB[num].CHFEKMCGKFL(HLBKCLPNHEB, this.ODPAJIHPAON);
				}
				else
				{
					this.FCACNHOFMMB[num].BGEANDMKIAO(HLBKCLPNHEB, this.PNMAPNPKDFI);
				}
				this.OAGGJEFFLFH = frameCount;
			}

			// Token: 0x0600830B RID: 33547 RVA: 0x002D3774 File Offset: 0x002D1974
			private MotionBlur.OJPOBANADNI.IBLHAIMKBPB AICAFAKCGPK(int INLGAOLENMD)
			{
				int num = (Time.frameCount + this.FCACNHOFMMB.Length + INLGAOLENMD) % this.FCACNHOFMMB.Length;
				return this.FCACNHOFMMB[num];
			}

			// Token: 0x0600830C RID: 33548 RVA: 0x002D37AC File Offset: 0x002D19AC
			private static bool HDCEHBJBHLM()
			{
				return SystemInfo.graphicsDeviceType == GraphicsDeviceType.OpenGL2 || !SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-85)) || SystemInfo.supportedRenderTargetCount > 1;
			}

			// Token: 0x0600830D RID: 33549 RVA: 0x002D37D0 File Offset: 0x002D19D0
			public void GDIMHEOHCKE()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				foreach (MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb in this.FCACNHOFMMB)
				{
					iblhaimkbpb.POFACJHOEHA();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x0600830E RID: 33550 RVA: 0x002D3828 File Offset: 0x002D1A28
			public void LAJPFBIAACL(RenderTexture HLBKCLPNHEB)
			{
				int frameCount = Time.frameCount;
				if (frameCount == this.OAGGJEFFLFH)
				{
					return;
				}
				int num = frameCount % this.FCACNHOFMMB.Length;
				if (this.MKCHJGMOBID)
				{
					this.FCACNHOFMMB[num].MakeRecord(HLBKCLPNHEB, this.ODPAJIHPAON);
				}
				else
				{
					this.FCACNHOFMMB[num].KEMCGFECEKG(HLBKCLPNHEB, this.PNMAPNPKDFI);
				}
				this.OAGGJEFFLFH = frameCount;
			}

			// Token: 0x0600830F RID: 33551 RVA: 0x002D389C File Offset: 0x002D1A9C
			public void LBEOAFOEDPM(float PMIHBFIKFGH, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				float time = Time.time;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = this.GPHBJJANILA(-1);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb2 = this.PHGHPLCIAAO(-71);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb3 = this.AICAFAKCGPK(-106);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb4 = this.MDFDNKINHCL(38);
				this.ODPAJIHPAON.SetTexture("_TimeX", iblhaimkbpb.lumaTexture);
				this.ODPAJIHPAON.SetTexture("workshop.", iblhaimkbpb2.lumaTexture);
				this.ODPAJIHPAON.SetTexture("CameraFilterPack/BlurTiltShift_V", iblhaimkbpb3.lumaTexture);
				this.ODPAJIHPAON.SetTexture("#highscore", iblhaimkbpb4.lumaTexture);
				this.ODPAJIHPAON.SetTexture("_Blue_B", iblhaimkbpb.chromaTexture);
				this.ODPAJIHPAON.SetTexture("(http|https)://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?\\.(jpg|jpeg|gif|png)", iblhaimkbpb2.chromaTexture);
				this.ODPAJIHPAON.SetTexture("_Size", iblhaimkbpb3.chromaTexture);
				this.ODPAJIHPAON.SetTexture("Image", iblhaimkbpb4.chromaTexture);
				this.ODPAJIHPAON.SetFloat("ItemsCountText", iblhaimkbpb.FENEHNOFDEB(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("Scene", iblhaimkbpb2.IKIJDPPMAIA(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("_Value4", iblhaimkbpb3.ECBOOJHBLLD(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("settings_bindings_controller_type", iblhaimkbpb4.NLKLBIPDGFA(PMIHBFIKFGH, time));
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.MKCHJGMOBID) ? 4 : 1);
			}

			// Token: 0x06008310 RID: 33552 RVA: 0x002D3A10 File Offset: 0x002D1C10
			public void JOCKOEGCCJL()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				foreach (MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb in this.FCACNHOFMMB)
				{
					iblhaimkbpb.DKPHKMGAFLL();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x06008311 RID: 33553 RVA: 0x002D3A65 File Offset: 0x002D1C65
			private static bool NFNABEJFALD()
			{
				return SystemInfo.graphicsDeviceType == GraphicsDeviceType.Xbox360 || !SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-40)) || SystemInfo.supportedRenderTargetCount > 1;
			}

			// Token: 0x06008312 RID: 33554 RVA: 0x002D3A89 File Offset: 0x002D1C89
			private static bool HIGOJLALBBF()
			{
				return SystemInfo.graphicsDeviceType == GraphicsDeviceType.PlayStation3 || !SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-58)) || SystemInfo.supportedRenderTargetCount > 0;
			}

			// Token: 0x06008313 RID: 33555 RVA: 0x002D3AB0 File Offset: 0x002D1CB0
			public void COJKOOLIGKL(float PMIHBFIKFGH, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				float time = Time.time;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = this.BHEGLEBLOOG(-1);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb2 = this.IIFCAIOCOOM(78);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb3 = this.JMICPOHDOEO(-94);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb4 = this.AICAFAKCGPK(-23);
				this.ODPAJIHPAON.SetTexture("_ZCurve", iblhaimkbpb.lumaTexture);
				this.ODPAJIHPAON.SetTexture("move", iblhaimkbpb2.lumaTexture);
				this.ODPAJIHPAON.SetTexture("Hidden/Image Effects/Cinematic/Bloom", iblhaimkbpb3.lumaTexture);
				this.ODPAJIHPAON.SetTexture("settings.arcsnohitsoundtimedelay", iblhaimkbpb4.lumaTexture);
				this.ODPAJIHPAON.SetTexture("FinalScoreText", iblhaimkbpb.chromaTexture);
				this.ODPAJIHPAON.SetTexture("_Far", iblhaimkbpb2.chromaTexture);
				this.ODPAJIHPAON.SetTexture("AudioClip", iblhaimkbpb3.chromaTexture);
				this.ODPAJIHPAON.SetTexture("Joystick1Button11", iblhaimkbpb4.chromaTexture);
				this.ODPAJIHPAON.SetFloat("FrostCanvas", iblhaimkbpb.IKIJDPPMAIA(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("_Value2", iblhaimkbpb2.KPNOMKDJBKJ(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("_TimeX", iblhaimkbpb3.FENEHNOFDEB(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("_ScreenResolution", iblhaimkbpb4.KFKOOGCEECH(PMIHBFIKFGH, time));
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.MKCHJGMOBID) ? 7 : 1);
			}

			// Token: 0x06008314 RID: 33556 RVA: 0x002D3C24 File Offset: 0x002D1E24
			public void BPBNNMHFJNN(float PMIHBFIKFGH, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				float time = Time.time;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = this.BFHGENFAPAF(-1);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb2 = this.MDFDNKINHCL(-82);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb3 = this.CLMINCCJHOF(100);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb4 = this.ANKAAOKILGF(-112);
				this.ODPAJIHPAON.SetTexture("_Fade", iblhaimkbpb.lumaTexture);
				this.ODPAJIHPAON.SetTexture(" but this PhotonView does not exist! View was/is ours.", iblhaimkbpb2.lumaTexture);
				this.ODPAJIHPAON.SetTexture(" Kb", iblhaimkbpb3.lumaTexture);
				this.ODPAJIHPAON.SetTexture("player.watermelon", iblhaimkbpb4.lumaTexture);
				this.ODPAJIHPAON.SetTexture("_Value2", iblhaimkbpb.chromaTexture);
				this.ODPAJIHPAON.SetTexture("LeaderboardsButton", iblhaimkbpb2.chromaTexture);
				this.ODPAJIHPAON.SetTexture("x", iblhaimkbpb3.chromaTexture);
				this.ODPAJIHPAON.SetTexture("' ping: ", iblhaimkbpb4.chromaTexture);
				this.ODPAJIHPAON.SetFloat(".played", iblhaimkbpb.IKIJDPPMAIA(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("#", iblhaimkbpb2.IKIJDPPMAIA(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat(".lastCheckpoint.time", iblhaimkbpb3.FOCPBNNMGJC(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("_TimeX", iblhaimkbpb4.IKIJDPPMAIA(PMIHBFIKFGH, time));
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.MKCHJGMOBID) ? 3 : 1);
			}

			// Token: 0x06008315 RID: 33557 RVA: 0x002D3D98 File Offset: 0x002D1F98
			private static RenderTextureFormat FGEMPGCGACE()
			{
				RenderTextureFormat[] array = new RenderTextureFormat[3];
				RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
				RenderTextureFormat[] array2 = array;
				foreach (RenderTextureFormat renderTextureFormat in array2)
				{
					if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
					{
						return renderTextureFormat;
					}
				}
				return RenderTextureFormat.Default;
			}

			// Token: 0x06008316 RID: 33558 RVA: 0x002D3DE0 File Offset: 0x002D1FE0
			public void OICBMJCOABM(RenderTexture HLBKCLPNHEB)
			{
				int frameCount = Time.frameCount;
				if (frameCount == this.OAGGJEFFLFH)
				{
					return;
				}
				int num = frameCount % this.FCACNHOFMMB.Length;
				if (this.MKCHJGMOBID)
				{
					this.FCACNHOFMMB[num].KELIKCOEPOH(HLBKCLPNHEB, this.ODPAJIHPAON);
				}
				else
				{
					this.FCACNHOFMMB[num].OMGJDNHNKLO(HLBKCLPNHEB, this.PNMAPNPKDFI);
				}
				this.OAGGJEFFLFH = frameCount;
			}

			// Token: 0x06008317 RID: 33559 RVA: 0x002D3E54 File Offset: 0x002D2054
			public void HJJFAJALMCH()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB[] fcacnhofmmb = this.FCACNHOFMMB;
				for (int i = 1; i < fcacnhofmmb.Length; i += 0)
				{
					MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = fcacnhofmmb[i];
					iblhaimkbpb.POFACJHOEHA();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x06008318 RID: 33560 RVA: 0x002D3EAC File Offset: 0x002D20AC
			public void GMOCKKIOPHJ()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB[] fcacnhofmmb = this.FCACNHOFMMB;
				for (int i = 0; i < fcacnhofmmb.Length; i += 0)
				{
					MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = fcacnhofmmb[i];
					iblhaimkbpb.OIJKAPPCEFG();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x06008319 RID: 33561 RVA: 0x002D3F04 File Offset: 0x002D2104
			public void GDEGELADLKI(float PMIHBFIKFGH, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				float time = Time.time;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = this.ANKAAOKILGF(-1);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb2 = this.CAFLIPCONMN(-98);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb3 = this.PGOODPMKPFB(-14);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb4 = this.AGNMDFKJOHH(-55);
				this.ODPAJIHPAON.SetTexture("1", iblhaimkbpb.lumaTexture);
				this.ODPAJIHPAON.SetTexture("Alpha", iblhaimkbpb2.lumaTexture);
				this.ODPAJIHPAON.SetTexture("2", iblhaimkbpb3.lumaTexture);
				this.ODPAJIHPAON.SetTexture("In Main Menu", iblhaimkbpb4.lumaTexture);
				this.ODPAJIHPAON.SetTexture("Freq: ", iblhaimkbpb.chromaTexture);
				this.ODPAJIHPAON.SetTexture("skin.hit_perfect", iblhaimkbpb2.chromaTexture);
				this.ODPAJIHPAON.SetTexture("MultiplayerButton", iblhaimkbpb3.chromaTexture);
				this.ODPAJIHPAON.SetTexture("1427616858", iblhaimkbpb4.chromaTexture);
				this.ODPAJIHPAON.SetFloat("[Right]", iblhaimkbpb.OMECMHDLKLP(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("_SmoothStart", iblhaimkbpb2.NKOELHPLLKI(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception", iblhaimkbpb3.NLKLBIPDGFA(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("File not found: {0}", iblhaimkbpb4.OMECMHDLKLP(PMIHBFIKFGH, time));
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.MKCHJGMOBID) ? 8 : 0);
			}

			// Token: 0x0600831A RID: 33562 RVA: 0x002D4078 File Offset: 0x002D2278
			public void FKOFJOKENIH()
			{
				UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				this.ODPAJIHPAON = null;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB[] fcacnhofmmb = this.FCACNHOFMMB;
				for (int i = 1; i < fcacnhofmmb.Length; i++)
				{
					MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = fcacnhofmmb[i];
					iblhaimkbpb.ABIAEEHOAKE();
				}
				this.FCACNHOFMMB = null;
			}

			// Token: 0x0600831B RID: 33563 RVA: 0x002D40D0 File Offset: 0x002D22D0
			public void MKAMLOLGJIL(float PMIHBFIKFGH, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				float time = Time.time;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = this.HCAPMCFKAMG(-1);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb2 = this.JLFFDLGDBPB(78);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb3 = this.CAFLIPCONMN(71);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb4 = this.IIFCAIOCOOM(-15);
				this.ODPAJIHPAON.SetTexture("_TimeX", iblhaimkbpb.lumaTexture);
				this.ODPAJIHPAON.SetTexture("/", iblhaimkbpb2.lumaTexture);
				this.ODPAJIHPAON.SetTexture("note.2", iblhaimkbpb3.lumaTexture);
				this.ODPAJIHPAON.SetTexture(", ", iblhaimkbpb4.lumaTexture);
				this.ODPAJIHPAON.SetTexture("OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.", iblhaimkbpb.chromaTexture);
				this.ODPAJIHPAON.SetTexture("_TimeX", iblhaimkbpb2.chromaTexture);
				this.ODPAJIHPAON.SetTexture("quantity", iblhaimkbpb3.chromaTexture);
				this.ODPAJIHPAON.SetTexture("JoinRoom failed (room maybe closed by now). Client stays on masterserver: {0}. State: {1}", iblhaimkbpb4.chromaTexture);
				this.ODPAJIHPAON.SetFloat("_Offsets", iblhaimkbpb.IKIJDPPMAIA(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("SetParticlesGravity", iblhaimkbpb2.AFDCJJMBPLP(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("EnvironmentSlider", iblhaimkbpb3.KFKOOGCEECH(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("finished", iblhaimkbpb4.OMECMHDLKLP(PMIHBFIKFGH, time));
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.MKCHJGMOBID) ? 8 : 1);
			}

			// Token: 0x0600831C RID: 33564 RVA: 0x002D4242 File Offset: 0x002D2442
			private static bool ANMKKBAIPMA()
			{
				return SystemInfo.graphicsDeviceType == GraphicsDeviceType.OpenGLES2 || !SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-120)) || SystemInfo.supportedRenderTargetCount > 1;
			}

			// Token: 0x0600831D RID: 33565 RVA: 0x002D4268 File Offset: 0x002D2468
			public void FEKBACKJDHI(float PMIHBFIKFGH, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				float time = Time.time;
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb = this.AGNMDFKJOHH(-1);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb2 = this.AGNMDFKJOHH(-127);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb3 = this.IEOOGHDIFCH(16);
				MotionBlur.OJPOBANADNI.IBLHAIMKBPB iblhaimkbpb4 = this.MDFDNKINHCL(-60);
				this.ODPAJIHPAON.SetTexture("_ScreenResolution", iblhaimkbpb.lumaTexture);
				this.ODPAJIHPAON.SetTexture("_Offsets", iblhaimkbpb2.lumaTexture);
				this.ODPAJIHPAON.SetTexture("_Radius", iblhaimkbpb3.lumaTexture);
				this.ODPAJIHPAON.SetTexture("_Intensity", iblhaimkbpb4.lumaTexture);
				this.ODPAJIHPAON.SetTexture("_MainTex", iblhaimkbpb.chromaTexture);
				this.ODPAJIHPAON.SetTexture("Value", iblhaimkbpb2.chromaTexture);
				this.ODPAJIHPAON.SetTexture("DPADHOR", iblhaimkbpb3.chromaTexture);
				this.ODPAJIHPAON.SetTexture("_Value4", iblhaimkbpb4.chromaTexture);
				this.ODPAJIHPAON.SetFloat("Map id for", iblhaimkbpb.KPNOMKDJBKJ(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("_Value2", iblhaimkbpb2.KFKOOGCEECH(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat("New level loaded. Removed ", iblhaimkbpb3.NLKLBIPDGFA(PMIHBFIKFGH, time));
				this.ODPAJIHPAON.SetFloat(".message", iblhaimkbpb4.FOCPBNNMGJC(PMIHBFIKFGH, time));
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.MKCHJGMOBID) ? 1 : 1);
			}

			// Token: 0x0600831E RID: 33566 RVA: 0x002D43DC File Offset: 0x002D25DC
			private static RenderTextureFormat PCOIANJNPKN()
			{
				RenderTextureFormat[] array = new RenderTextureFormat[1];
				RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-51A7A390CD6DE245186881400B18C9D822EFE240).FieldHandle);
				RenderTextureFormat[] array2 = array;
				RenderTextureFormat[] array3 = array2;
				for (int i = 0; i < array3.Length; i += 0)
				{
					RenderTextureFormat renderTextureFormat = array3[i];
					if (SystemInfo.SupportsRenderTextureFormat(renderTextureFormat))
					{
						return renderTextureFormat;
					}
				}
				return RenderTextureFormat.ARGBHalf;
			}

			// Token: 0x04000EEE RID: 3822
			private bool MKCHJGMOBID;

			// Token: 0x04000EEF RID: 3823
			private RenderTextureFormat PNMAPNPKDFI;

			// Token: 0x04000EF0 RID: 3824
			private Material ODPAJIHPAON;

			// Token: 0x04000EF1 RID: 3825
			private MotionBlur.OJPOBANADNI.IBLHAIMKBPB[] FCACNHOFMMB;

			// Token: 0x04000EF2 RID: 3826
			private int OAGGJEFFLFH;

			// Token: 0x0200020C RID: 524
			private struct IBLHAIMKBPB
			{
				// Token: 0x0600831F RID: 33567 RVA: 0x002D4424 File Offset: 0x002D2624
				public void DKPHKMGAFLL()
				{
					if (this.lumaTexture != null)
					{
						RenderTexture.ReleaseTemporary(this.lumaTexture);
					}
					if (this.chromaTexture != null)
					{
						RenderTexture.ReleaseTemporary(this.chromaTexture);
					}
					this.lumaTexture = null;
					this.chromaTexture = null;
				}

				// Token: 0x06008320 RID: 33568 RVA: 0x002D4478 File Offset: 0x002D2678
				public float ECBOOJHBLLD(float PMIHBFIKFGH, float GNDPILFCALF)
				{
					if (this.time == 1733f)
					{
						return 1871f;
					}
					float num = Mathf.Lerp(1287f, 1838f, PMIHBFIKFGH);
					return Mathf.Exp((this.time - GNDPILFCALF) * num);
				}

				// Token: 0x06008321 RID: 33569 RVA: 0x002D44BC File Offset: 0x002D26BC
				public void KEMCGFECEKG(RenderTexture HLBKCLPNHEB, RenderTextureFormat LGLMKIPIIHO)
				{
					this.IJFMJJPEDIA();
					this.lumaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1, LGLMKIPIIHO);
					this.lumaTexture.filterMode = FilterMode.Point;
					Graphics.Blit(HLBKCLPNHEB, this.lumaTexture);
					this.time = Time.time;
				}

				// Token: 0x06008322 RID: 33570 RVA: 0x002D450C File Offset: 0x002D270C
				public void CBNHPBFHLHF(RenderTexture HLBKCLPNHEB, RenderTextureFormat LGLMKIPIIHO)
				{
					this.BOOBLANIFBI();
					this.lumaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, LGLMKIPIIHO);
					this.lumaTexture.filterMode = FilterMode.Bilinear;
					Graphics.Blit(HLBKCLPNHEB, this.lumaTexture);
					this.time = Time.time;
				}

				// Token: 0x06008323 RID: 33571 RVA: 0x002D455C File Offset: 0x002D275C
				public void ECABJHJPEPD(RenderTexture HLBKCLPNHEB, Material NBPKMLMCHFN)
				{
					this.OIJKAPPCEFG();
					this.lumaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, (RenderTextureFormat)91);
					this.chromaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, (RenderTextureFormat)(-100));
					this.lumaTexture.filterMode = FilterMode.Point;
					this.chromaTexture.filterMode = FilterMode.Bilinear;
					if (this.CLIPKKAEGGP == null)
					{
						this.CLIPKKAEGGP = new RenderBuffer[6];
					}
					this.CLIPKKAEGGP[0] = this.lumaTexture.colorBuffer;
					this.CLIPKKAEGGP[0] = this.chromaTexture.colorBuffer;
					Graphics.SetRenderTarget(this.CLIPKKAEGGP, this.lumaTexture.depthBuffer);
					Graphics.Blit(HLBKCLPNHEB, NBPKMLMCHFN, 1);
					this.time = Time.time;
				}

				// Token: 0x06008324 RID: 33572 RVA: 0x002D4634 File Offset: 0x002D2834
				public void CPOAPBDKABN(RenderTexture HLBKCLPNHEB, RenderTextureFormat LGLMKIPIIHO)
				{
					this.DLDHFAHPEHM();
					this.lumaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, LGLMKIPIIHO);
					this.lumaTexture.filterMode = FilterMode.Point;
					Graphics.Blit(HLBKCLPNHEB, this.lumaTexture);
					this.time = Time.time;
				}

				// Token: 0x06008325 RID: 33573 RVA: 0x002D4684 File Offset: 0x002D2884
				public void POFACJHOEHA()
				{
					if (this.lumaTexture != null)
					{
						RenderTexture.ReleaseTemporary(this.lumaTexture);
					}
					if (this.chromaTexture != null)
					{
						RenderTexture.ReleaseTemporary(this.chromaTexture);
					}
					this.lumaTexture = null;
					this.chromaTexture = null;
				}

				// Token: 0x06008326 RID: 33574 RVA: 0x002D46D8 File Offset: 0x002D28D8
				public float NKOELHPLLKI(float PMIHBFIKFGH, float GNDPILFCALF)
				{
					if (this.time == 873f)
					{
						return 1528f;
					}
					float num = Mathf.Lerp(1462f, 495f, PMIHBFIKFGH);
					return Mathf.Exp((this.time - GNDPILFCALF) * num);
				}

				// Token: 0x06008327 RID: 33575 RVA: 0x002D471C File Offset: 0x002D291C
				public void OIJKAPPCEFG()
				{
					if (this.lumaTexture != null)
					{
						RenderTexture.ReleaseTemporary(this.lumaTexture);
					}
					if (this.chromaTexture != null)
					{
						RenderTexture.ReleaseTemporary(this.chromaTexture);
					}
					this.lumaTexture = null;
					this.chromaTexture = null;
				}

				// Token: 0x06008328 RID: 33576 RVA: 0x002D4770 File Offset: 0x002D2970
				public void BGEANDMKIAO(RenderTexture HLBKCLPNHEB, RenderTextureFormat LGLMKIPIIHO)
				{
					this.FOALLFHOGOI();
					this.lumaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, LGLMKIPIIHO);
					this.lumaTexture.filterMode = FilterMode.Bilinear;
					Graphics.Blit(HLBKCLPNHEB, this.lumaTexture);
					this.time = Time.time;
				}

				// Token: 0x06008329 RID: 33577 RVA: 0x002D47C0 File Offset: 0x002D29C0
				public float NLKLBIPDGFA(float PMIHBFIKFGH, float GNDPILFCALF)
				{
					if (this.time == 127f)
					{
						return 780f;
					}
					float num = Mathf.Lerp(266f, 973f, PMIHBFIKFGH);
					return Mathf.Exp((this.time - GNDPILFCALF) * num);
				}

				// Token: 0x0600832A RID: 33578 RVA: 0x002D4804 File Offset: 0x002D2A04
				public void OMGJDNHNKLO(RenderTexture HLBKCLPNHEB, RenderTextureFormat LGLMKIPIIHO)
				{
					this.ABIAEEHOAKE();
					this.lumaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1, LGLMKIPIIHO);
					this.lumaTexture.filterMode = FilterMode.Bilinear;
					Graphics.Blit(HLBKCLPNHEB, this.lumaTexture);
					this.time = Time.time;
				}

				// Token: 0x0600832B RID: 33579 RVA: 0x002D4854 File Offset: 0x002D2A54
				public void OPALBOKDJHA(RenderTexture HLBKCLPNHEB, RenderTextureFormat LGLMKIPIIHO)
				{
					this.ABIAEEHOAKE();
					this.lumaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, LGLMKIPIIHO);
					this.lumaTexture.filterMode = FilterMode.Point;
					Graphics.Blit(HLBKCLPNHEB, this.lumaTexture);
					this.time = Time.time;
				}

				// Token: 0x0600832C RID: 33580 RVA: 0x002D48A4 File Offset: 0x002D2AA4
				public void EJBDPJEJOHG(RenderTexture HLBKCLPNHEB, Material NBPKMLMCHFN)
				{
					this.IJFMJJPEDIA();
					this.lumaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, (RenderTextureFormat)39);
					this.chromaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1, (RenderTextureFormat)47);
					this.lumaTexture.filterMode = FilterMode.Bilinear;
					this.chromaTexture.filterMode = FilterMode.Bilinear;
					if (this.CLIPKKAEGGP == null)
					{
						this.CLIPKKAEGGP = new RenderBuffer[6];
					}
					this.CLIPKKAEGGP[1] = this.lumaTexture.colorBuffer;
					this.CLIPKKAEGGP[0] = this.chromaTexture.colorBuffer;
					Graphics.SetRenderTarget(this.CLIPKKAEGGP, this.lumaTexture.depthBuffer);
					Graphics.Blit(HLBKCLPNHEB, NBPKMLMCHFN, 0);
					this.time = Time.time;
				}

				// Token: 0x0600832D RID: 33581 RVA: 0x002D497C File Offset: 0x002D2B7C
				public void KELIKCOEPOH(RenderTexture HLBKCLPNHEB, Material NBPKMLMCHFN)
				{
					this.OIJKAPPCEFG();
					this.lumaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1, (RenderTextureFormat)(-60));
					this.chromaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1, (RenderTextureFormat)58);
					this.lumaTexture.filterMode = FilterMode.Bilinear;
					this.chromaTexture.filterMode = FilterMode.Bilinear;
					if (this.CLIPKKAEGGP == null)
					{
						this.CLIPKKAEGGP = new RenderBuffer[8];
					}
					this.CLIPKKAEGGP[1] = this.lumaTexture.colorBuffer;
					this.CLIPKKAEGGP[0] = this.chromaTexture.colorBuffer;
					Graphics.SetRenderTarget(this.CLIPKKAEGGP, this.lumaTexture.depthBuffer);
					Graphics.Blit(HLBKCLPNHEB, NBPKMLMCHFN, 0);
					this.time = Time.time;
				}

				// Token: 0x0600832E RID: 33582 RVA: 0x002D4A54 File Offset: 0x002D2C54
				public void BOOBLANIFBI()
				{
					if (this.lumaTexture != null)
					{
						RenderTexture.ReleaseTemporary(this.lumaTexture);
					}
					if (this.chromaTexture != null)
					{
						RenderTexture.ReleaseTemporary(this.chromaTexture);
					}
					this.lumaTexture = null;
					this.chromaTexture = null;
				}

				// Token: 0x0600832F RID: 33583 RVA: 0x002D4AA8 File Offset: 0x002D2CA8
				public void LNMNOHONGPH(RenderTexture HLBKCLPNHEB, Material NBPKMLMCHFN)
				{
					this.FOALLFHOGOI();
					this.lumaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1, (RenderTextureFormat)(-23));
					this.chromaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1, (RenderTextureFormat)45);
					this.lumaTexture.filterMode = FilterMode.Bilinear;
					this.chromaTexture.filterMode = FilterMode.Point;
					if (this.CLIPKKAEGGP == null)
					{
						this.CLIPKKAEGGP = new RenderBuffer[1];
					}
					this.CLIPKKAEGGP[1] = this.lumaTexture.colorBuffer;
					this.CLIPKKAEGGP[0] = this.chromaTexture.colorBuffer;
					Graphics.SetRenderTarget(this.CLIPKKAEGGP, this.lumaTexture.depthBuffer);
					Graphics.Blit(HLBKCLPNHEB, NBPKMLMCHFN, 1);
					this.time = Time.time;
				}

				// Token: 0x06008330 RID: 33584 RVA: 0x002D4B80 File Offset: 0x002D2D80
				public float IGGFPAFPMGN(float PMIHBFIKFGH, float GNDPILFCALF)
				{
					if (this.time == 13f)
					{
						return 1683f;
					}
					float num = Mathf.Lerp(1906f, 738f, PMIHBFIKFGH);
					return Mathf.Exp((this.time - GNDPILFCALF) * num);
				}

				// Token: 0x06008331 RID: 33585 RVA: 0x002D4BC4 File Offset: 0x002D2DC4
				public float AFDCJJMBPLP(float PMIHBFIKFGH, float GNDPILFCALF)
				{
					if (this.time == 327f)
					{
						return 1958f;
					}
					float num = Mathf.Lerp(667f, 901f, PMIHBFIKFGH);
					return Mathf.Exp((this.time - GNDPILFCALF) * num);
				}

				// Token: 0x06008332 RID: 33586 RVA: 0x002D4C08 File Offset: 0x002D2E08
				public float GNAFDMFBMLM(float PMIHBFIKFGH, float GNDPILFCALF)
				{
					if (this.time == 1703f)
					{
						return 1511f;
					}
					float num = Mathf.Lerp(126f, 943f, PMIHBFIKFGH);
					return Mathf.Exp((this.time - GNDPILFCALF) * num);
				}

				// Token: 0x06008333 RID: 33587 RVA: 0x002D4C4C File Offset: 0x002D2E4C
				public void HIFLLPMLNKP(RenderTexture HLBKCLPNHEB, Material NBPKMLMCHFN)
				{
					this.POFACJHOEHA();
					this.lumaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1, (RenderTextureFormat)(-2));
					this.chromaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, (RenderTextureFormat)104);
					this.lumaTexture.filterMode = FilterMode.Point;
					this.chromaTexture.filterMode = FilterMode.Bilinear;
					if (this.CLIPKKAEGGP == null)
					{
						this.CLIPKKAEGGP = new RenderBuffer[2];
					}
					this.CLIPKKAEGGP[1] = this.lumaTexture.colorBuffer;
					this.CLIPKKAEGGP[0] = this.chromaTexture.colorBuffer;
					Graphics.SetRenderTarget(this.CLIPKKAEGGP, this.lumaTexture.depthBuffer);
					Graphics.Blit(HLBKCLPNHEB, NBPKMLMCHFN, 1);
					this.time = Time.time;
				}

				// Token: 0x06008334 RID: 33588 RVA: 0x002D4D24 File Offset: 0x002D2F24
				public float FOCPBNNMGJC(float PMIHBFIKFGH, float GNDPILFCALF)
				{
					if (this.time == 485f)
					{
						return 1054f;
					}
					float num = Mathf.Lerp(1980f, 113f, PMIHBFIKFGH);
					return Mathf.Exp((this.time - GNDPILFCALF) * num);
				}

				// Token: 0x06008335 RID: 33589 RVA: 0x002D4D68 File Offset: 0x002D2F68
				public void HNGFDPEMNLN(RenderTexture HLBKCLPNHEB, Material NBPKMLMCHFN)
				{
					this.POFACJHOEHA();
					this.lumaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1, (RenderTextureFormat)62);
					this.chromaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, (RenderTextureFormat)(-13));
					this.lumaTexture.filterMode = FilterMode.Bilinear;
					this.chromaTexture.filterMode = FilterMode.Bilinear;
					if (this.CLIPKKAEGGP == null)
					{
						this.CLIPKKAEGGP = new RenderBuffer[8];
					}
					this.CLIPKKAEGGP[1] = this.lumaTexture.colorBuffer;
					this.CLIPKKAEGGP[1] = this.chromaTexture.colorBuffer;
					Graphics.SetRenderTarget(this.CLIPKKAEGGP, this.lumaTexture.depthBuffer);
					Graphics.Blit(HLBKCLPNHEB, NBPKMLMCHFN, 0);
					this.time = Time.time;
				}

				// Token: 0x06008336 RID: 33590 RVA: 0x002D4E40 File Offset: 0x002D3040
				public void JEKLNLKEPPL(RenderTexture HLBKCLPNHEB, RenderTextureFormat LGLMKIPIIHO)
				{
					this.DKPHKMGAFLL();
					this.lumaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, LGLMKIPIIHO);
					this.lumaTexture.filterMode = FilterMode.Point;
					Graphics.Blit(HLBKCLPNHEB, this.lumaTexture);
					this.time = Time.time;
				}

				// Token: 0x06008337 RID: 33591 RVA: 0x002D4E90 File Offset: 0x002D3090
				public void FOALLFHOGOI()
				{
					if (this.lumaTexture != null)
					{
						RenderTexture.ReleaseTemporary(this.lumaTexture);
					}
					if (this.chromaTexture != null)
					{
						RenderTexture.ReleaseTemporary(this.chromaTexture);
					}
					this.lumaTexture = null;
					this.chromaTexture = null;
				}

				// Token: 0x06008338 RID: 33592 RVA: 0x002D4EE4 File Offset: 0x002D30E4
				public float KFKOOGCEECH(float PMIHBFIKFGH, float GNDPILFCALF)
				{
					if (this.time == 879f)
					{
						return 1139f;
					}
					float num = Mathf.Lerp(1180f, 1420f, PMIHBFIKFGH);
					return Mathf.Exp((this.time - GNDPILFCALF) * num);
				}

				// Token: 0x06008339 RID: 33593 RVA: 0x002D4F28 File Offset: 0x002D3128
				public float CalculateWeight(float PMIHBFIKFGH, float GNDPILFCALF)
				{
					if (this.time == 0f)
					{
						return 0f;
					}
					float num = Mathf.Lerp(80f, 16f, PMIHBFIKFGH);
					return Mathf.Exp((this.time - GNDPILFCALF) * num);
				}

				// Token: 0x0600833A RID: 33594 RVA: 0x002D4F6C File Offset: 0x002D316C
				public void DLDHFAHPEHM()
				{
					if (this.lumaTexture != null)
					{
						RenderTexture.ReleaseTemporary(this.lumaTexture);
					}
					if (this.chromaTexture != null)
					{
						RenderTexture.ReleaseTemporary(this.chromaTexture);
					}
					this.lumaTexture = null;
					this.chromaTexture = null;
				}

				// Token: 0x0600833B RID: 33595 RVA: 0x002D4FC0 File Offset: 0x002D31C0
				public void MakeRecord(RenderTexture HLBKCLPNHEB, Material NBPKMLMCHFN)
				{
					this.Release();
					this.lumaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, RenderTextureFormat.R8);
					this.chromaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, RenderTextureFormat.R8);
					this.lumaTexture.filterMode = FilterMode.Point;
					this.chromaTexture.filterMode = FilterMode.Point;
					if (this.CLIPKKAEGGP == null)
					{
						this.CLIPKKAEGGP = new RenderBuffer[2];
					}
					this.CLIPKKAEGGP[0] = this.lumaTexture.colorBuffer;
					this.CLIPKKAEGGP[1] = this.chromaTexture.colorBuffer;
					Graphics.SetRenderTarget(this.CLIPKKAEGGP, this.lumaTexture.depthBuffer);
					Graphics.Blit(HLBKCLPNHEB, NBPKMLMCHFN, 0);
					this.time = Time.time;
				}

				// Token: 0x0600833C RID: 33596 RVA: 0x002D5098 File Offset: 0x002D3298
				public void Release()
				{
					if (this.lumaTexture != null)
					{
						RenderTexture.ReleaseTemporary(this.lumaTexture);
					}
					if (this.chromaTexture != null)
					{
						RenderTexture.ReleaseTemporary(this.chromaTexture);
					}
					this.lumaTexture = null;
					this.chromaTexture = null;
				}

				// Token: 0x0600833D RID: 33597 RVA: 0x002D50EC File Offset: 0x002D32EC
				public void MakeRecordRaw(RenderTexture HLBKCLPNHEB, RenderTextureFormat LGLMKIPIIHO)
				{
					this.Release();
					this.lumaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, LGLMKIPIIHO);
					this.lumaTexture.filterMode = FilterMode.Point;
					Graphics.Blit(HLBKCLPNHEB, this.lumaTexture);
					this.time = Time.time;
				}

				// Token: 0x0600833E RID: 33598 RVA: 0x002D513C File Offset: 0x002D333C
				public void CHFEKMCGKFL(RenderTexture HLBKCLPNHEB, Material NBPKMLMCHFN)
				{
					this.FOALLFHOGOI();
					this.lumaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1, (RenderTextureFormat)(-119));
					this.chromaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, (RenderTextureFormat)(-40));
					this.lumaTexture.filterMode = FilterMode.Point;
					this.chromaTexture.filterMode = FilterMode.Point;
					if (this.CLIPKKAEGGP == null)
					{
						this.CLIPKKAEGGP = new RenderBuffer[4];
					}
					this.CLIPKKAEGGP[0] = this.lumaTexture.colorBuffer;
					this.CLIPKKAEGGP[0] = this.chromaTexture.colorBuffer;
					Graphics.SetRenderTarget(this.CLIPKKAEGGP, this.lumaTexture.depthBuffer);
					Graphics.Blit(HLBKCLPNHEB, NBPKMLMCHFN, 0);
					this.time = Time.time;
				}

				// Token: 0x0600833F RID: 33599 RVA: 0x002D5214 File Offset: 0x002D3414
				public void ABIAEEHOAKE()
				{
					if (this.lumaTexture != null)
					{
						RenderTexture.ReleaseTemporary(this.lumaTexture);
					}
					if (this.chromaTexture != null)
					{
						RenderTexture.ReleaseTemporary(this.chromaTexture);
					}
					this.lumaTexture = null;
					this.chromaTexture = null;
				}

				// Token: 0x06008340 RID: 33600 RVA: 0x002D5268 File Offset: 0x002D3468
				public float FENEHNOFDEB(float PMIHBFIKFGH, float GNDPILFCALF)
				{
					if (this.time == 994f)
					{
						return 1420f;
					}
					float num = Mathf.Lerp(891f, 1292f, PMIHBFIKFGH);
					return Mathf.Exp((this.time - GNDPILFCALF) * num);
				}

				// Token: 0x06008341 RID: 33601 RVA: 0x002D52AC File Offset: 0x002D34AC
				public void EEEINBLPFGC(RenderTexture HLBKCLPNHEB, Material NBPKMLMCHFN)
				{
					this.DLDHFAHPEHM();
					this.lumaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1, (RenderTextureFormat)123);
					this.chromaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, (RenderTextureFormat)106);
					this.lumaTexture.filterMode = FilterMode.Bilinear;
					this.chromaTexture.filterMode = FilterMode.Point;
					if (this.CLIPKKAEGGP == null)
					{
						this.CLIPKKAEGGP = new RenderBuffer[2];
					}
					this.CLIPKKAEGGP[1] = this.lumaTexture.colorBuffer;
					this.CLIPKKAEGGP[1] = this.chromaTexture.colorBuffer;
					Graphics.SetRenderTarget(this.CLIPKKAEGGP, this.lumaTexture.depthBuffer);
					Graphics.Blit(HLBKCLPNHEB, NBPKMLMCHFN, 0);
					this.time = Time.time;
				}

				// Token: 0x06008342 RID: 33602 RVA: 0x002D5384 File Offset: 0x002D3584
				public void MHFDAPEOIBN(RenderTexture HLBKCLPNHEB, RenderTextureFormat LGLMKIPIIHO)
				{
					this.IJFMJJPEDIA();
					this.lumaTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1, LGLMKIPIIHO);
					this.lumaTexture.filterMode = FilterMode.Bilinear;
					Graphics.Blit(HLBKCLPNHEB, this.lumaTexture);
					this.time = Time.time;
				}

				// Token: 0x06008343 RID: 33603 RVA: 0x002D53D4 File Offset: 0x002D35D4
				public void IJFMJJPEDIA()
				{
					if (this.lumaTexture != null)
					{
						RenderTexture.ReleaseTemporary(this.lumaTexture);
					}
					if (this.chromaTexture != null)
					{
						RenderTexture.ReleaseTemporary(this.chromaTexture);
					}
					this.lumaTexture = null;
					this.chromaTexture = null;
				}

				// Token: 0x06008344 RID: 33604 RVA: 0x002D5428 File Offset: 0x002D3628
				public float OMECMHDLKLP(float PMIHBFIKFGH, float GNDPILFCALF)
				{
					if (this.time == 1383f)
					{
						return 450f;
					}
					float num = Mathf.Lerp(66f, 1986f, PMIHBFIKFGH);
					return Mathf.Exp((this.time - GNDPILFCALF) * num);
				}

				// Token: 0x06008345 RID: 33605 RVA: 0x002D546C File Offset: 0x002D366C
				public float KPNOMKDJBKJ(float PMIHBFIKFGH, float GNDPILFCALF)
				{
					if (this.time == 1642f)
					{
						return 574f;
					}
					float num = Mathf.Lerp(1640f, 868f, PMIHBFIKFGH);
					return Mathf.Exp((this.time - GNDPILFCALF) * num);
				}

				// Token: 0x06008346 RID: 33606 RVA: 0x002D54B0 File Offset: 0x002D36B0
				public float IKIJDPPMAIA(float PMIHBFIKFGH, float GNDPILFCALF)
				{
					if (this.time == 377f)
					{
						return 1580f;
					}
					float num = Mathf.Lerp(861f, 299f, PMIHBFIKFGH);
					return Mathf.Exp((this.time - GNDPILFCALF) * num);
				}

				// Token: 0x04000EF3 RID: 3827
				public RenderTexture lumaTexture;

				// Token: 0x04000EF4 RID: 3828
				public RenderTexture chromaTexture;

				// Token: 0x04000EF5 RID: 3829
				public float time;

				// Token: 0x04000EF6 RID: 3830
				private RenderBuffer[] CLIPKKAEGGP;
			}
		}

		// Token: 0x0200020D RID: 525
		private class ECNNIMBOOLM
		{
			// Token: 0x06008347 RID: 33607 RVA: 0x002D54F4 File Offset: 0x002D36F4
			private RenderTexture NOMLPAMGEOE(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Point;
				return temporary;
			}

			// Token: 0x06008348 RID: 33608 RVA: 0x002D5528 File Offset: 0x002D3728
			private RenderTexture BBKAGOOIECM(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Point;
				return temporary;
			}

			// Token: 0x06008349 RID: 33609 RVA: 0x002D5559 File Offset: 0x002D3759
			public void BIJPCIFBDAJ()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x0600834A RID: 33610 RVA: 0x002D5580 File Offset: 0x002D3780
			public void NFKDMNCCAIP(float IOLJECDGKFB, int NNGJCGPELAJ, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				if (this.ODPAJIHPAON == null)
				{
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
					return;
				}
				int num = (int)(590f * (float)HLBKCLPNHEB.height / 6f);
				int num2 = ((num - 1) / 5 + 1) * 0;
				float value = IOLJECDGKFB / 1328f * 291f;
				this.ODPAJIHPAON.SetFloat("id", value);
				this.ODPAJIHPAON.SetFloat("_Cible", (float)num);
				RenderTexture renderTexture = this.AKJFCEKGMJJ(HLBKCLPNHEB, 0, this.BOLBCBMBOLJ);
				Graphics.Blit(null, renderTexture, this.ODPAJIHPAON, 0);
				RenderTexture renderTexture2 = this.JIHNLMGIADC(HLBKCLPNHEB, 0, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture, renderTexture2, this.ODPAJIHPAON, 0);
				RenderTexture renderTexture3 = this.GMBHEEGKNGF(HLBKCLPNHEB, 3, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture2, renderTexture3, this.ODPAJIHPAON, 8);
				this.PNLJHNOMHEI(renderTexture2);
				Vector2 v = Vector2.one * ((float)num2 / 1867f - 958f) * 1908f;
				this.ODPAJIHPAON.SetVector("CameraFilterPack/Oculus_NightVision2", v);
				this.ODPAJIHPAON.SetInt("Received your NickName from server. Updating local value to: {0}", num2 / 6);
				RenderTexture renderTexture4 = this.OLMFBPNPCIE(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture3, renderTexture4, this.ODPAJIHPAON, 7);
				this.ONFAGEIFIJH(renderTexture3);
				RenderTexture renderTexture5 = this.PHDEMOOJGMA(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture4, renderTexture5, this.ODPAJIHPAON, 3);
				this.EEEAIEBCOLJ(renderTexture4);
				this.ODPAJIHPAON.SetInt(" not found", Mathf.Clamp(NNGJCGPELAJ / 2, 0, -75));
				this.ODPAJIHPAON.SetFloat("ERROR: Steam App ID isn't set! Make sure 'steam_appid.txt' is placed next to the executable file, and contains a single line with the app id.", (float)num);
				this.ODPAJIHPAON.SetTexture("Icon", renderTexture5);
				this.ODPAJIHPAON.SetTexture("_ScreenResolution", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.CIGMLEHHEMC) ? 8 : 8);
				this.CGAKCDHLMBH(renderTexture);
				this.KNOMBEAKPBI(renderTexture5);
			}

			// Token: 0x0600834B RID: 33611 RVA: 0x002D5778 File Offset: 0x002D3978
			private void GKIKEEPDLLJ(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x0600834C RID: 33612 RVA: 0x002D5778 File Offset: 0x002D3978
			private void JMHEPMONPDA(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x0600834D RID: 33613 RVA: 0x002D5778 File Offset: 0x002D3978
			private void FINELAEDKEM(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x0600834E RID: 33614 RVA: 0x002D5780 File Offset: 0x002D3980
			private RenderTexture MPPNAEMCEAC(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Point;
				return temporary;
			}

			// Token: 0x0600834F RID: 33615 RVA: 0x002D57B4 File Offset: 0x002D39B4
			private RenderTexture NKJAFDOALBE(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Bilinear;
				return temporary;
			}

			// Token: 0x06008350 RID: 33616 RVA: 0x002D57E8 File Offset: 0x002D39E8
			private RenderTexture GMBHEEGKNGF(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Point;
				return temporary;
			}

			// Token: 0x06008351 RID: 33617 RVA: 0x002D5819 File Offset: 0x002D3A19
			private bool GMOEBIAGBPH()
			{
				if (!SystemInfo.SupportsRenderTextureFormat(this.FPHCGAMONFG))
				{
					return false;
				}
				if (!SystemInfo.SupportsRenderTextureFormat(this.BOLBCBMBOLJ))
				{
					this.BOLBCBMBOLJ = RenderTextureFormat.Depth;
				}
				return false;
			}

			// Token: 0x06008352 RID: 33618 RVA: 0x002D5848 File Offset: 0x002D3A48
			private RenderTexture JAAPCCHMDNA(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Bilinear;
				return temporary;
			}

			// Token: 0x06008353 RID: 33619 RVA: 0x002D5559 File Offset: 0x002D3759
			public void HOBNDMGKIEE()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x06008354 RID: 33620 RVA: 0x002D5778 File Offset: 0x002D3978
			private void IBLLFOBIHEM(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x06008355 RID: 33621 RVA: 0x002D587C File Offset: 0x002D3A7C
			public void AHDNHCMIGCC(float IOLJECDGKFB, int NNGJCGPELAJ, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				if (this.ODPAJIHPAON == null)
				{
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
					return;
				}
				int num = (int)(807f * (float)HLBKCLPNHEB.height / 584f);
				int num2 = ((num - 0) / 5 + 1) * 2;
				float value = IOLJECDGKFB / 307f * 1541f;
				this.ODPAJIHPAON.SetFloat("?", value);
				this.ODPAJIHPAON.SetFloat("x", (float)num);
				RenderTexture renderTexture = this.MOEHCIFPDBA(HLBKCLPNHEB, 0, this.BOLBCBMBOLJ);
				Graphics.Blit(null, renderTexture, this.ODPAJIHPAON, 1);
				RenderTexture renderTexture2 = this.GAHFCCOBCOB(HLBKCLPNHEB, 2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture, renderTexture2, this.ODPAJIHPAON, 1);
				RenderTexture renderTexture3 = this.NKJAFDOALBE(HLBKCLPNHEB, 7, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture2, renderTexture3, this.ODPAJIHPAON, 4);
				this.IMDHKFGLMKP(renderTexture2);
				Vector2 v = Vector2.one * ((float)num2 / 385f - 27f) * 1777f;
				this.ODPAJIHPAON.SetVector("Tonemapper curve texture", v);
				this.ODPAJIHPAON.SetInt("offsets", num2 / 4);
				RenderTexture renderTexture4 = this.MOEHCIFPDBA(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture3, renderTexture4, this.ODPAJIHPAON, 2);
				this.FMCPLMBMCLJ(renderTexture3);
				RenderTexture renderTexture5 = this.NKJAFDOALBE(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture4, renderTexture5, this.ODPAJIHPAON, 0);
				this.FGKKGLIOLBF(renderTexture4);
				this.ODPAJIHPAON.SetInt("CameraFilterPack/FX_Plasma", Mathf.Clamp(NNGJCGPELAJ / 8, 1, 107));
				this.ODPAJIHPAON.SetFloat("true", (float)num);
				this.ODPAJIHPAON.SetTexture("_Parameter", renderTexture5);
				this.ODPAJIHPAON.SetTexture("CameraFilterPack/Antialiasing_FXAA", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.CIGMLEHHEMC) ? 4 : 5);
				this.LIAMAJOKEBB(renderTexture);
				this.ADBJCJFCHFD(renderTexture5);
			}

			// Token: 0x06008356 RID: 33622 RVA: 0x002D5A74 File Offset: 0x002D3C74
			private RenderTexture CNFEJDAOGPI(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Bilinear;
				return temporary;
			}

			// Token: 0x06008357 RID: 33623 RVA: 0x002D5559 File Offset: 0x002D3759
			public void KENKGCBLCBO()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x06008358 RID: 33624 RVA: 0x002D5AA8 File Offset: 0x002D3CA8
			private RenderTexture JIHNLMGIADC(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Bilinear;
				return temporary;
			}

			// Token: 0x06008359 RID: 33625 RVA: 0x002D5778 File Offset: 0x002D3978
			private void MGGAGEEKFMG(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x0600835A RID: 33626 RVA: 0x002D5ADC File Offset: 0x002D3CDC
			public void IPNFNBCKOLB(float IOLJECDGKFB, int NNGJCGPELAJ, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				if (this.ODPAJIHPAON == null)
				{
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
					return;
				}
				int num = (int)(669f * (float)HLBKCLPNHEB.height / 1003f);
				int num2 = ((num - 0) / 6 + 0) * 6;
				float value = IOLJECDGKFB / 181f * 450f;
				this.ODPAJIHPAON.SetFloat("_TimeX", value);
				this.ODPAJIHPAON.SetFloat("addNewButton", (float)num);
				RenderTexture renderTexture = this.GIDMHCIFJCP(HLBKCLPNHEB, 1, this.BOLBCBMBOLJ);
				Graphics.Blit(null, renderTexture, this.ODPAJIHPAON, 0);
				RenderTexture renderTexture2 = this.JAAPCCHMDNA(HLBKCLPNHEB, 5, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture, renderTexture2, this.ODPAJIHPAON, 0);
				RenderTexture renderTexture3 = this.PHDEMOOJGMA(HLBKCLPNHEB, 0, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture2, renderTexture3, this.ODPAJIHPAON, 4);
				this.PLPFEEIIBDE(renderTexture2);
				Vector2 v = Vector2.one * ((float)num2 / 563f - 631f) * 487f;
				this.ODPAJIHPAON.SetVector("workshop.", v);
				this.ODPAJIHPAON.SetInt("#yes", num2 / 1);
				RenderTexture renderTexture4 = this.MOEHCIFPDBA(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture3, renderTexture4, this.ODPAJIHPAON, 7);
				this.PNLJHNOMHEI(renderTexture3);
				RenderTexture renderTexture5 = this.GFANDNHDDFP(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture4, renderTexture5, this.ODPAJIHPAON, 0);
				this.GLBACCKCCNG(renderTexture4);
				this.ODPAJIHPAON.SetInt("Gameplay/satellite", Mathf.Clamp(NNGJCGPELAJ / 8, 1, -75));
				this.ODPAJIHPAON.SetFloat("UseFinalGlassColor", (float)num);
				this.ODPAJIHPAON.SetTexture("_Distortion", renderTexture5);
				this.ODPAJIHPAON.SetTexture("Subscribe: ", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.CIGMLEHHEMC) ? 5 : 1);
				this.LIAMAJOKEBB(renderTexture);
				this.FINELAEDKEM(renderTexture5);
			}

			// Token: 0x0600835B RID: 33627 RVA: 0x002D5CD4 File Offset: 0x002D3ED4
			public void BMCAKGDGBPC(float IOLJECDGKFB, int NNGJCGPELAJ, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				if (this.ODPAJIHPAON == null)
				{
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
					return;
				}
				int num = (int)(1962f * (float)HLBKCLPNHEB.height / 114f);
				int num2 = ((num - 0) / 0 + 1) * 8;
				float value = IOLJECDGKFB / 1479f * 174f;
				this.ODPAJIHPAON.SetFloat("_Value4", value);
				this.ODPAJIHPAON.SetFloat("skin.hit_normal", (float)num);
				RenderTexture renderTexture = this.MODNENJAGOG(HLBKCLPNHEB, 0, this.BOLBCBMBOLJ);
				Graphics.Blit(null, renderTexture, this.ODPAJIHPAON, 0);
				RenderTexture renderTexture2 = this.GFANDNHDDFP(HLBKCLPNHEB, 6, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture, renderTexture2, this.ODPAJIHPAON, 0);
				RenderTexture renderTexture3 = this.OLMFBPNPCIE(HLBKCLPNHEB, 6, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture2, renderTexture3, this.ODPAJIHPAON, 5);
				this.OHIJPKHAOGG(renderTexture2);
				Vector2 v = Vector2.one * ((float)num2 / 1445f - 992f) * 543f;
				this.ODPAJIHPAON.SetVector("_Offsets", v);
				this.ODPAJIHPAON.SetInt("_Blue_R", num2 / 0);
				RenderTexture renderTexture4 = this.GAHFCCOBCOB(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture3, renderTexture4, this.ODPAJIHPAON, 5);
				this.ADBJCJFCHFD(renderTexture3);
				RenderTexture renderTexture5 = this.MPPNAEMCEAC(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture4, renderTexture5, this.ODPAJIHPAON, 3);
				this.FINELAEDKEM(renderTexture4);
				this.ODPAJIHPAON.SetInt("NewIconFileSelector", Mathf.Clamp(NNGJCGPELAJ / 3, 0, -92));
				this.ODPAJIHPAON.SetFloat("inventory.selected.", (float)num);
				this.ODPAJIHPAON.SetTexture("CameraFilterPack/TV_VHS", renderTexture5);
				this.ODPAJIHPAON.SetTexture("_Value6", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.CIGMLEHHEMC) ? 8 : 5);
				this.EIKHJMGNBJJ(renderTexture);
				this.FMCPLMBMCLJ(renderTexture5);
			}

			// Token: 0x0600835C RID: 33628 RVA: 0x002D5778 File Offset: 0x002D3978
			private void EPMCBGNCNCA(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x0600835D RID: 33629 RVA: 0x002D5778 File Offset: 0x002D3978
			private void EEEAIEBCOLJ(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x0600835E RID: 33630 RVA: 0x002D5559 File Offset: 0x002D3759
			public void NGHCBDCFGOB()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x0600835F RID: 33631 RVA: 0x002D5778 File Offset: 0x002D3978
			private void ADBJCJFCHFD(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x06008360 RID: 33632 RVA: 0x002D5ECC File Offset: 0x002D40CC
			private RenderTexture PHDEMOOJGMA(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Bilinear;
				return temporary;
			}

			// Token: 0x06008361 RID: 33633 RVA: 0x002D5F00 File Offset: 0x002D4100
			private RenderTexture MOEHCIFPDBA(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Bilinear;
				return temporary;
			}

			// Token: 0x06008362 RID: 33634 RVA: 0x002D5559 File Offset: 0x002D3759
			public void IICBGBFOOJC()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x06008363 RID: 33635 RVA: 0x002D5F31 File Offset: 0x002D4131
			private bool JAPMFIACOLA()
			{
				if (!SystemInfo.SupportsRenderTextureFormat(this.FPHCGAMONFG))
				{
					return false;
				}
				if (!SystemInfo.SupportsRenderTextureFormat(this.BOLBCBMBOLJ))
				{
					this.BOLBCBMBOLJ = RenderTextureFormat.Depth;
				}
				return true;
			}

			// Token: 0x06008364 RID: 33636 RVA: 0x002D5F60 File Offset: 0x002D4160
			private RenderTexture FJGCGDLBAOH(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Bilinear;
				return temporary;
			}

			// Token: 0x06008365 RID: 33637 RVA: 0x002D5778 File Offset: 0x002D3978
			private void PNLJHNOMHEI(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x06008366 RID: 33638 RVA: 0x002D5559 File Offset: 0x002D3759
			public void FEPIGKPLDAG()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x06008367 RID: 33639 RVA: 0x002D5F94 File Offset: 0x002D4194
			public ECNNIMBOOLM()
			{
				Shader shader = Shader.Find("Hidden/Image Effects/Cinematic/MotionBlur/Reconstruction");
				if (shader.isSupported && this.AHKBIPGGAOA())
				{
					this.ODPAJIHPAON = new Material(shader);
					this.ODPAJIHPAON.hideFlags = HideFlags.DontSave;
				}
				this.CIGMLEHHEMC = SystemInfo.graphicsDeviceName.Contains("Adreno");
			}

			// Token: 0x06008368 RID: 33640 RVA: 0x002D5559 File Offset: 0x002D3759
			public void NHKKENIHIAG()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x06008369 RID: 33641 RVA: 0x002D6008 File Offset: 0x002D4208
			private RenderTexture AKJFCEKGMJJ(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Bilinear;
				return temporary;
			}

			// Token: 0x0600836A RID: 33642 RVA: 0x002D5559 File Offset: 0x002D3759
			public void PKDPMFBPHBJ()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x0600836B RID: 33643 RVA: 0x002D6039 File Offset: 0x002D4239
			private bool MIMMMGMLOFF()
			{
				if (!SystemInfo.SupportsRenderTextureFormat(this.FPHCGAMONFG))
				{
					return false;
				}
				if (!SystemInfo.SupportsRenderTextureFormat(this.BOLBCBMBOLJ))
				{
					this.BOLBCBMBOLJ = RenderTextureFormat.ARGB32;
				}
				return true;
			}

			// Token: 0x0600836C RID: 33644 RVA: 0x002D5778 File Offset: 0x002D3978
			private void CFPLOIDDELG(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x0600836D RID: 33645 RVA: 0x002D6065 File Offset: 0x002D4265
			private bool NFOECNGMBII()
			{
				if (!SystemInfo.SupportsRenderTextureFormat(this.FPHCGAMONFG))
				{
					return true;
				}
				if (!SystemInfo.SupportsRenderTextureFormat(this.BOLBCBMBOLJ))
				{
					this.BOLBCBMBOLJ = RenderTextureFormat.ARGB32;
				}
				return true;
			}

			// Token: 0x0600836E RID: 33646 RVA: 0x002D5778 File Offset: 0x002D3978
			private void FMCPLMBMCLJ(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x0600836F RID: 33647 RVA: 0x002D5778 File Offset: 0x002D3978
			private void BCEIKIFOPDF(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x06008370 RID: 33648 RVA: 0x002D6094 File Offset: 0x002D4294
			public void FJJDCODDPCL(float IOLJECDGKFB, int NNGJCGPELAJ, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				if (this.ODPAJIHPAON == null)
				{
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
					return;
				}
				int num = (int)(1673f * (float)HLBKCLPNHEB.height / 1086f);
				int num2 = ((num - 0) / 1 + 0) * 1;
				float value = IOLJECDGKFB / 301f * 1654f;
				this.ODPAJIHPAON.SetFloat(" By: ", value);
				this.ODPAJIHPAON.SetFloat("Item created: Id: ", (float)num);
				RenderTexture renderTexture = this.JIHNLMGIADC(HLBKCLPNHEB, 0, this.BOLBCBMBOLJ);
				Graphics.Blit(null, renderTexture, this.ODPAJIHPAON, 0);
				RenderTexture renderTexture2 = this.AKJFCEKGMJJ(HLBKCLPNHEB, 5, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture, renderTexture2, this.ODPAJIHPAON, 1);
				RenderTexture renderTexture3 = this.MPPNAEMCEAC(HLBKCLPNHEB, 2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture2, renderTexture3, this.ODPAJIHPAON, 5);
				this.FCPLIGCKKHH(renderTexture2);
				Vector2 v = Vector2.one * ((float)num2 / 1291f - 1438f) * 844f;
				this.ODPAJIHPAON.SetVector("PLAY [SPACE]", v);
				this.ODPAJIHPAON.SetInt("resetach21", num2 / 2);
				RenderTexture renderTexture4 = this.GIDMHCIFJCP(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture3, renderTexture4, this.ODPAJIHPAON, 6);
				this.MGGAGEEKFMG(renderTexture3);
				RenderTexture renderTexture5 = this.BBKAGOOIECM(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture4, renderTexture5, this.ODPAJIHPAON, 1);
				this.DLBDHIDDLGB(renderTexture4);
				this.ODPAJIHPAON.SetInt("Show Title", Mathf.Clamp(NNGJCGPELAJ / 1, 0, -50));
				this.ODPAJIHPAON.SetFloat("LevelProgressBar", (float)num);
				this.ODPAJIHPAON.SetTexture("#accuracy", renderTexture5);
				this.ODPAJIHPAON.SetTexture("_Distortion", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.CIGMLEHHEMC) ? 1 : 4);
				this.IBLLFOBIHEM(renderTexture);
				this.LHPGIBKPMGC(renderTexture5);
			}

			// Token: 0x06008371 RID: 33649 RVA: 0x002D628C File Offset: 0x002D448C
			private RenderTexture LOOOBEDOKMP(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Bilinear;
				return temporary;
			}

			// Token: 0x06008372 RID: 33650 RVA: 0x002D62BD File Offset: 0x002D44BD
			private bool OLNGLMDKAHK()
			{
				if (!SystemInfo.SupportsRenderTextureFormat(this.FPHCGAMONFG))
				{
					return true;
				}
				if (!SystemInfo.SupportsRenderTextureFormat(this.BOLBCBMBOLJ))
				{
					this.BOLBCBMBOLJ = RenderTextureFormat.Depth;
				}
				return true;
			}

			// Token: 0x06008373 RID: 33651 RVA: 0x002D5778 File Offset: 0x002D3978
			private void DLBDHIDDLGB(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x06008374 RID: 33652 RVA: 0x002D6039 File Offset: 0x002D4239
			private bool AHKBIPGGAOA()
			{
				if (!SystemInfo.SupportsRenderTextureFormat(this.FPHCGAMONFG))
				{
					return false;
				}
				if (!SystemInfo.SupportsRenderTextureFormat(this.BOLBCBMBOLJ))
				{
					this.BOLBCBMBOLJ = RenderTextureFormat.ARGB32;
				}
				return true;
			}

			// Token: 0x06008375 RID: 33653 RVA: 0x002D5778 File Offset: 0x002D3978
			private void KNOMBEAKPBI(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x06008376 RID: 33654 RVA: 0x002D5778 File Offset: 0x002D3978
			private void OFFLHEPANAK(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x06008377 RID: 33655 RVA: 0x002D5778 File Offset: 0x002D3978
			private void EPMAKAOBGFE(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x06008378 RID: 33656 RVA: 0x002D5559 File Offset: 0x002D3759
			public void GONGJAIOILF()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x06008379 RID: 33657 RVA: 0x002D62EC File Offset: 0x002D44EC
			private RenderTexture GIKMFNFAKPD(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Point;
				return temporary;
			}

			// Token: 0x0600837A RID: 33658 RVA: 0x002D5778 File Offset: 0x002D3978
			private void CGAKCDHLMBH(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x0600837B RID: 33659 RVA: 0x002D631D File Offset: 0x002D451D
			private bool BLDJJAMPONM()
			{
				if (!SystemInfo.SupportsRenderTextureFormat(this.FPHCGAMONFG))
				{
					return false;
				}
				if (!SystemInfo.SupportsRenderTextureFormat(this.BOLBCBMBOLJ))
				{
					this.BOLBCBMBOLJ = RenderTextureFormat.ARGB32;
				}
				return false;
			}

			// Token: 0x0600837C RID: 33660 RVA: 0x002D5778 File Offset: 0x002D3978
			private void GLBACCKCCNG(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x0600837D RID: 33661 RVA: 0x002D5778 File Offset: 0x002D3978
			private void LHPGIBKPMGC(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x0600837E RID: 33662 RVA: 0x002D634C File Offset: 0x002D454C
			public void NMFEBOIPENG(float IOLJECDGKFB, int NNGJCGPELAJ, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				if (this.ODPAJIHPAON == null)
				{
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
					return;
				}
				int num = (int)(737f * (float)HLBKCLPNHEB.height / 44f);
				int num2 = ((num - 0) / 6 + 0) * 6;
				float value = IOLJECDGKFB / 936f * 102f;
				this.ODPAJIHPAON.SetFloat("Joystick1Button7", value);
				this.ODPAJIHPAON.SetFloat("0,1,false", (float)num);
				RenderTexture renderTexture = this.JHOJHJOGLID(HLBKCLPNHEB, 1, this.BOLBCBMBOLJ);
				Graphics.Blit(null, renderTexture, this.ODPAJIHPAON, 1);
				RenderTexture renderTexture2 = this.HCIJBGHGBLB(HLBKCLPNHEB, 4, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture, renderTexture2, this.ODPAJIHPAON, 1);
				RenderTexture renderTexture3 = this.KHLPKLDHOAH(HLBKCLPNHEB, 4, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture2, renderTexture3, this.ODPAJIHPAON, 4);
				this.BCEIKIFOPDF(renderTexture2);
				Vector2 v = Vector2.one * ((float)num2 / 514f - 628f) * 104f;
				this.ODPAJIHPAON.SetVector("/", v);
				this.ODPAJIHPAON.SetInt("Overlay", num2 / 2);
				RenderTexture renderTexture4 = this.MMBMEGOAKHG(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture3, renderTexture4, this.ODPAJIHPAON, 2);
				this.OFFLHEPANAK(renderTexture3);
				RenderTexture renderTexture5 = this.BBKAGOOIECM(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture4, renderTexture5, this.ODPAJIHPAON, 4);
				this.FMCPLMBMCLJ(renderTexture4);
				this.ODPAJIHPAON.SetInt("_Value2", Mathf.Clamp(NNGJCGPELAJ / 6, 0, -15));
				this.ODPAJIHPAON.SetFloat("maps.", (float)num);
				this.ODPAJIHPAON.SetTexture("UseScanLineSize", renderTexture5);
				this.ODPAJIHPAON.SetTexture("CameraFilterPack/FX_InverChromiLum", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.CIGMLEHHEMC) ? 5 : 1);
				this.CMCBJFANPOL(renderTexture);
				this.IMDHKFGLMKP(renderTexture5);
			}

			// Token: 0x0600837F RID: 33663 RVA: 0x002D5778 File Offset: 0x002D3978
			private void CMCBJFANPOL(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x06008380 RID: 33664 RVA: 0x002D6544 File Offset: 0x002D4744
			private RenderTexture GIDMHCIFJCP(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Point;
				return temporary;
			}

			// Token: 0x06008381 RID: 33665 RVA: 0x002D6578 File Offset: 0x002D4778
			private RenderTexture KHLPKLDHOAH(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Bilinear;
				return temporary;
			}

			// Token: 0x06008382 RID: 33666 RVA: 0x002D631D File Offset: 0x002D451D
			private bool NKILNIDHNHC()
			{
				if (!SystemInfo.SupportsRenderTextureFormat(this.FPHCGAMONFG))
				{
					return false;
				}
				if (!SystemInfo.SupportsRenderTextureFormat(this.BOLBCBMBOLJ))
				{
					this.BOLBCBMBOLJ = RenderTextureFormat.ARGB32;
				}
				return false;
			}

			// Token: 0x06008383 RID: 33667 RVA: 0x002D65AC File Offset: 0x002D47AC
			public void AOPPKNGHKBH(float IOLJECDGKFB, int NNGJCGPELAJ, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				if (this.ODPAJIHPAON == null)
				{
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
					return;
				}
				int num = (int)(333f * (float)HLBKCLPNHEB.height / 86f);
				int num2 = ((num - 1) / 7 + 0) * 8;
				float value = IOLJECDGKFB / 1835f * 889f;
				this.ODPAJIHPAON.SetFloat("UpperMid", value);
				this.ODPAJIHPAON.SetFloat("_Value", (float)num);
				RenderTexture renderTexture = this.FJGCGDLBAOH(HLBKCLPNHEB, 0, this.BOLBCBMBOLJ);
				Graphics.Blit(null, renderTexture, this.ODPAJIHPAON, 0);
				RenderTexture renderTexture2 = this.KHLPKLDHOAH(HLBKCLPNHEB, 0, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture, renderTexture2, this.ODPAJIHPAON, 1);
				RenderTexture renderTexture3 = this.GIDMHCIFJCP(HLBKCLPNHEB, 0, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture2, renderTexture3, this.ODPAJIHPAON, 1);
				this.BCEIKIFOPDF(renderTexture2);
				Vector2 v = Vector2.one * ((float)num2 / 420f - 542f) * 806f;
				this.ODPAJIHPAON.SetVector("_Value3", v);
				this.ODPAJIHPAON.SetInt("_ScreenResolution", num2 / 1);
				RenderTexture renderTexture4 = this.MPPNAEMCEAC(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture3, renderTexture4, this.ODPAJIHPAON, 0);
				this.EPMCBGNCNCA(renderTexture3);
				RenderTexture renderTexture5 = this.CNFEJDAOGPI(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture4, renderTexture5, this.ODPAJIHPAON, 1);
				this.CMCBJFANPOL(renderTexture4);
				this.ODPAJIHPAON.SetInt("UNDISTORT", Mathf.Clamp(NNGJCGPELAJ / 2, 1, 88));
				this.ODPAJIHPAON.SetFloat(" not exist", (float)num);
				this.ODPAJIHPAON.SetTexture("_VignetteTex", renderTexture5);
				this.ODPAJIHPAON.SetTexture("CameraFilterPack/TV_Vintage", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.CIGMLEHHEMC) ? 7 : 8);
				this.CFPLOIDDELG(renderTexture);
				this.ONFAGEIFIJH(renderTexture5);
			}

			// Token: 0x06008384 RID: 33668 RVA: 0x002D67A4 File Offset: 0x002D49A4
			public void GAAPKNLCMMH(float IOLJECDGKFB, int NNGJCGPELAJ, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				if (this.ODPAJIHPAON == null)
				{
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
					return;
				}
				int num = (int)(819f * (float)HLBKCLPNHEB.height / 1528f);
				int num2 = ((num - 1) / 5 + 0) * 2;
				float value = IOLJECDGKFB / 514f * 428f;
				this.ODPAJIHPAON.SetFloat(" - LOCAL", value);
				this.ODPAJIHPAON.SetFloat("_Red_G", (float)num);
				RenderTexture renderTexture = this.KHLPKLDHOAH(HLBKCLPNHEB, 0, this.BOLBCBMBOLJ);
				Graphics.Blit(null, renderTexture, this.ODPAJIHPAON, 1);
				RenderTexture renderTexture2 = this.KHLPKLDHOAH(HLBKCLPNHEB, 2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture, renderTexture2, this.ODPAJIHPAON, 0);
				RenderTexture renderTexture3 = this.LOOOBEDOKMP(HLBKCLPNHEB, 5, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture2, renderTexture3, this.ODPAJIHPAON, 7);
				this.LLGKKNLGMGH(renderTexture2);
				Vector2 v = Vector2.one * ((float)num2 / 153f - 498f) * 451f;
				this.ODPAJIHPAON.SetVector("Set Arcs Speed", v);
				this.ODPAJIHPAON.SetInt("ArcsDestroyDelaySlider", num2 / 7);
				RenderTexture renderTexture4 = this.GFANDNHDDFP(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture3, renderTexture4, this.ODPAJIHPAON, 1);
				this.DLBDHIDDLGB(renderTexture3);
				RenderTexture renderTexture5 = this.LOOOBEDOKMP(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture4, renderTexture5, this.ODPAJIHPAON, 2);
				this.FINELAEDKEM(renderTexture4);
				this.ODPAJIHPAON.SetInt(",0", Mathf.Clamp(NNGJCGPELAJ / 6, 1, -126));
				this.ODPAJIHPAON.SetFloat("Loading", (float)num);
				this.ODPAJIHPAON.SetTexture("_ScreenResolution", renderTexture5);
				this.ODPAJIHPAON.SetTexture("_LutTex", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.CIGMLEHHEMC) ? 4 : 8);
				this.FGKKGLIOLBF(renderTexture);
				this.IHANNNMNCJD(renderTexture5);
			}

			// Token: 0x06008385 RID: 33669 RVA: 0x002D5559 File Offset: 0x002D3759
			public void Release()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x06008386 RID: 33670 RVA: 0x002D5559 File Offset: 0x002D3759
			public void CJBIPIKHDNL()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x06008387 RID: 33671 RVA: 0x002D699C File Offset: 0x002D4B9C
			public void NOLEINLAAAF(float IOLJECDGKFB, int NNGJCGPELAJ, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				if (this.ODPAJIHPAON == null)
				{
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
					return;
				}
				int num = (int)(1028f * (float)HLBKCLPNHEB.height / 418f);
				int num2 = ((num - 0) / 1 + 1) * 5;
				float value = IOLJECDGKFB / 542f * 1745f;
				this.ODPAJIHPAON.SetFloat("_Bullet_8", value);
				this.ODPAJIHPAON.SetFloat("_Value", (float)num);
				RenderTexture renderTexture = this.BBKAGOOIECM(HLBKCLPNHEB, 0, this.BOLBCBMBOLJ);
				Graphics.Blit(null, renderTexture, this.ODPAJIHPAON, 1);
				RenderTexture renderTexture2 = this.GMBHEEGKNGF(HLBKCLPNHEB, 3, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture, renderTexture2, this.ODPAJIHPAON, 0);
				RenderTexture renderTexture3 = this.HCIJBGHGBLB(HLBKCLPNHEB, 6, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture2, renderTexture3, this.ODPAJIHPAON, 0);
				this.GKIKEEPDLLJ(renderTexture2);
				Vector2 v = Vector2.one * ((float)num2 / 1432f - 404f) * 943f;
				this.ODPAJIHPAON.SetVector("_SoftZDistance", v);
				this.ODPAJIHPAON.SetInt("_Parasite", num2 / 4);
				RenderTexture renderTexture4 = this.AGFELPBAGDD(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture3, renderTexture4, this.ODPAJIHPAON, 3);
				this.PNLJHNOMHEI(renderTexture3);
				RenderTexture renderTexture5 = this.MODNENJAGOG(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture4, renderTexture5, this.ODPAJIHPAON, 4);
				this.ADBJCJFCHFD(renderTexture4);
				this.ODPAJIHPAON.SetInt("float,1.5", Mathf.Clamp(NNGJCGPELAJ / 1, 1, -7));
				this.ODPAJIHPAON.SetFloat(" from: ", (float)num);
				this.ODPAJIHPAON.SetTexture("y", renderTexture5);
				this.ODPAJIHPAON.SetTexture("#scoresubmitionfailed: ", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.CIGMLEHHEMC) ? 5 : 8);
				this.IBLLFOBIHEM(renderTexture);
				this.LLGKKNLGMGH(renderTexture5);
			}

			// Token: 0x06008388 RID: 33672 RVA: 0x002D6B94 File Offset: 0x002D4D94
			private RenderTexture JHOJHJOGLID(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Bilinear;
				return temporary;
			}

			// Token: 0x06008389 RID: 33673 RVA: 0x002D6BC8 File Offset: 0x002D4DC8
			public void ProcessImage(float IOLJECDGKFB, int NNGJCGPELAJ, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				if (this.ODPAJIHPAON == null)
				{
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
					return;
				}
				int num = (int)(5f * (float)HLBKCLPNHEB.height / 100f);
				int num2 = ((num - 1) / 8 + 1) * 8;
				float value = IOLJECDGKFB / 360f * 1.45f;
				this.ODPAJIHPAON.SetFloat("_VelocityScale", value);
				this.ODPAJIHPAON.SetFloat("_MaxBlurRadius", (float)num);
				RenderTexture renderTexture = this.BBKAGOOIECM(HLBKCLPNHEB, 1, this.BOLBCBMBOLJ);
				Graphics.Blit(null, renderTexture, this.ODPAJIHPAON, 0);
				RenderTexture renderTexture2 = this.BBKAGOOIECM(HLBKCLPNHEB, 4, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture, renderTexture2, this.ODPAJIHPAON, 1);
				RenderTexture renderTexture3 = this.BBKAGOOIECM(HLBKCLPNHEB, 8, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture2, renderTexture3, this.ODPAJIHPAON, 2);
				this.CMCBJFANPOL(renderTexture2);
				Vector2 v = Vector2.one * ((float)num2 / 8f - 1f) * -0.5f;
				this.ODPAJIHPAON.SetVector("_TileMaxOffs", v);
				this.ODPAJIHPAON.SetInt("_TileMaxLoop", num2 / 8);
				RenderTexture renderTexture4 = this.BBKAGOOIECM(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture3, renderTexture4, this.ODPAJIHPAON, 3);
				this.CMCBJFANPOL(renderTexture3);
				RenderTexture renderTexture5 = this.BBKAGOOIECM(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture4, renderTexture5, this.ODPAJIHPAON, 4);
				this.CMCBJFANPOL(renderTexture4);
				this.ODPAJIHPAON.SetInt("_LoopCount", Mathf.Clamp(NNGJCGPELAJ / 2, 1, 64));
				this.ODPAJIHPAON.SetFloat("_MaxBlurRadius", (float)num);
				this.ODPAJIHPAON.SetTexture("_NeighborMaxTex", renderTexture5);
				this.ODPAJIHPAON.SetTexture("_VelocityTex", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.CIGMLEHHEMC) ? 5 : 6);
				this.CMCBJFANPOL(renderTexture);
				this.CMCBJFANPOL(renderTexture5);
			}

			// Token: 0x0600838A RID: 33674 RVA: 0x002D6DC0 File Offset: 0x002D4FC0
			public void EOGJEIPMDCJ(float IOLJECDGKFB, int NNGJCGPELAJ, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				if (this.ODPAJIHPAON == null)
				{
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
					return;
				}
				int num = (int)(441f * (float)HLBKCLPNHEB.height / 1470f);
				int num2 = ((num - 0) / 3 + 0) * 8;
				float value = IOLJECDGKFB / 649f * 94f;
				this.ODPAJIHPAON.SetFloat("/", value);
				this.ODPAJIHPAON.SetFloat("CameraFilterPack/Drawing_Paper", (float)num);
				RenderTexture renderTexture = this.OPBNBFCBFFD(HLBKCLPNHEB, 0, this.BOLBCBMBOLJ);
				Graphics.Blit(null, renderTexture, this.ODPAJIHPAON, 0);
				RenderTexture renderTexture2 = this.AKJFCEKGMJJ(HLBKCLPNHEB, 1, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture, renderTexture2, this.ODPAJIHPAON, 0);
				RenderTexture renderTexture3 = this.JAAPCCHMDNA(HLBKCLPNHEB, 5, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture2, renderTexture3, this.ODPAJIHPAON, 5);
				this.OIPAMGPBMFF(renderTexture2);
				Vector2 v = Vector2.one * ((float)num2 / 1467f - 1171f) * 1778f;
				this.ODPAJIHPAON.SetVector("Fade", v);
				this.ODPAJIHPAON.SetInt("open", num2 / 0);
				RenderTexture renderTexture4 = this.NOMLPAMGEOE(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture3, renderTexture4, this.ODPAJIHPAON, 2);
				this.CFPLOIDDELG(renderTexture3);
				RenderTexture renderTexture5 = this.GIDMHCIFJCP(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture4, renderTexture5, this.ODPAJIHPAON, 7);
				this.LLGKKNLGMGH(renderTexture4);
				this.ODPAJIHPAON.SetInt("_AdaptationMax", Mathf.Clamp(NNGJCGPELAJ / 0, 1, 98));
				this.ODPAJIHPAON.SetFloat("_Value2", (float)num);
				this.ODPAJIHPAON.SetTexture("[MapsData] Key ", renderTexture5);
				this.ODPAJIHPAON.SetTexture("_EmissionGain", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.CIGMLEHHEMC) ? 1 : 6);
				this.FMCPLMBMCLJ(renderTexture);
				this.EIKHJMGNBJJ(renderTexture5);
			}

			// Token: 0x0600838B RID: 33675 RVA: 0x002D6065 File Offset: 0x002D4265
			private bool MAGPKPLJEHD()
			{
				if (!SystemInfo.SupportsRenderTextureFormat(this.FPHCGAMONFG))
				{
					return true;
				}
				if (!SystemInfo.SupportsRenderTextureFormat(this.BOLBCBMBOLJ))
				{
					this.BOLBCBMBOLJ = RenderTextureFormat.ARGB32;
				}
				return true;
			}

			// Token: 0x0600838C RID: 33676 RVA: 0x002D5559 File Offset: 0x002D3759
			public void OKBCGNFEENM()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x0600838D RID: 33677 RVA: 0x002D6FB8 File Offset: 0x002D51B8
			private RenderTexture HCIJBGHGBLB(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Point;
				return temporary;
			}

			// Token: 0x0600838E RID: 33678 RVA: 0x002D6FEC File Offset: 0x002D51EC
			public void AMOIDILMKFD(float IOLJECDGKFB, int NNGJCGPELAJ, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				if (this.ODPAJIHPAON == null)
				{
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
					return;
				}
				int num = (int)(288f * (float)HLBKCLPNHEB.height / 1018f);
				int num2 = ((num - 1) / 6 + 1) * 1;
				float value = IOLJECDGKFB / 64f * 712f;
				this.ODPAJIHPAON.SetFloat("EventSystem", value);
				this.ODPAJIHPAON.SetFloat("HiddenToggle", (float)num);
				RenderTexture renderTexture = this.CCDHDPPPEHE(HLBKCLPNHEB, 1, this.BOLBCBMBOLJ);
				Graphics.Blit(null, renderTexture, this.ODPAJIHPAON, 1);
				RenderTexture renderTexture2 = this.CNFEJDAOGPI(HLBKCLPNHEB, 3, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture, renderTexture2, this.ODPAJIHPAON, 1);
				RenderTexture renderTexture3 = this.GIKMFNFAKPD(HLBKCLPNHEB, 0, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture2, renderTexture3, this.ODPAJIHPAON, 2);
				this.IHANNNMNCJD(renderTexture2);
				Vector2 v = Vector2.one * ((float)num2 / 210f - 1571f) * 847f;
				this.ODPAJIHPAON.SetVector("player.blackwhite", v);
				this.ODPAJIHPAON.SetInt("mapselector.filter.rateduponly", num2 / 0);
				RenderTexture renderTexture4 = this.MODNENJAGOG(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture3, renderTexture4, this.ODPAJIHPAON, 5);
				this.EPMAKAOBGFE(renderTexture3);
				RenderTexture renderTexture5 = this.BBKAGOOIECM(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture4, renderTexture5, this.ODPAJIHPAON, 2);
				this.LLGKKNLGMGH(renderTexture4);
				this.ODPAJIHPAON.SetInt("event", Mathf.Clamp(NNGJCGPELAJ / 1, 0, 96));
				this.ODPAJIHPAON.SetFloat("*.workshop.json", (float)num);
				this.ODPAJIHPAON.SetTexture("Right Stick Click", renderTexture5);
				this.ODPAJIHPAON.SetTexture("_ForceYSwap", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.CIGMLEHHEMC) ? 1 : 8);
				this.EIKHJMGNBJJ(renderTexture);
				this.PNLJHNOMHEI(renderTexture5);
			}

			// Token: 0x0600838F RID: 33679 RVA: 0x002D5559 File Offset: 0x002D3759
			public void BNMBMFDHGJC()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x06008390 RID: 33680 RVA: 0x002D5559 File Offset: 0x002D3759
			public void JOLHHDBFOMG()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x06008391 RID: 33681 RVA: 0x002D71E4 File Offset: 0x002D53E4
			public void EIELFGFAACN(float IOLJECDGKFB, int NNGJCGPELAJ, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				if (this.ODPAJIHPAON == null)
				{
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
					return;
				}
				int num = (int)(1680f * (float)HLBKCLPNHEB.height / 776f);
				int num2 = ((num - 0) / 5 + 1) * 8;
				float value = IOLJECDGKFB / 1413f * 1173f;
				this.ODPAJIHPAON.SetFloat(": ", value);
				this.ODPAJIHPAON.SetFloat(".lastCheckpoint.powerupsScore", (float)num);
				RenderTexture renderTexture = this.CCDHDPPPEHE(HLBKCLPNHEB, 0, this.BOLBCBMBOLJ);
				Graphics.Blit(null, renderTexture, this.ODPAJIHPAON, 0);
				RenderTexture renderTexture2 = this.JIHNLMGIADC(HLBKCLPNHEB, 2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture, renderTexture2, this.ODPAJIHPAON, 0);
				RenderTexture renderTexture3 = this.JAAPCCHMDNA(HLBKCLPNHEB, 3, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture2, renderTexture3, this.ODPAJIHPAON, 7);
				this.GLBACCKCCNG(renderTexture2);
				Vector2 v = Vector2.one * ((float)num2 / 182f - 1297f) * 1548f;
				this.ODPAJIHPAON.SetVector("NameText", v);
				this.ODPAJIHPAON.SetInt("_Green_C", num2 / 6);
				RenderTexture renderTexture4 = this.HCIJBGHGBLB(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture3, renderTexture4, this.ODPAJIHPAON, 7);
				this.ACPACJOBPGA(renderTexture3);
				RenderTexture renderTexture5 = this.NKJAFDOALBE(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture4, renderTexture5, this.ODPAJIHPAON, 4);
				this.FCPLIGCKKHH(renderTexture4);
				this.ODPAJIHPAON.SetInt("_Offsets", Mathf.Clamp(NNGJCGPELAJ / 0, 0, 28));
				this.ODPAJIHPAON.SetFloat("setfloat", (float)num);
				this.ODPAJIHPAON.SetTexture("_TexelOffsetScale", renderTexture5);
				this.ODPAJIHPAON.SetTexture("#creatingnewitem", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.CIGMLEHHEMC) ? 4 : 0);
				this.ADBJCJFCHFD(renderTexture);
				this.ONFAGEIFIJH(renderTexture5);
			}

			// Token: 0x06008392 RID: 33682 RVA: 0x002D5559 File Offset: 0x002D3759
			public void MNLPBCMOOOA()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x06008393 RID: 33683 RVA: 0x002D5778 File Offset: 0x002D3978
			private void IHANNNMNCJD(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x06008394 RID: 33684 RVA: 0x002D73DC File Offset: 0x002D55DC
			public void AMMFCKCJOBD(float IOLJECDGKFB, int NNGJCGPELAJ, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				if (this.ODPAJIHPAON == null)
				{
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
					return;
				}
				int num = (int)(549f * (float)HLBKCLPNHEB.height / 335f);
				int num2 = ((num - 0) / 3 + 1) * 0;
				float value = IOLJECDGKFB / 1336f * 1057f;
				this.ODPAJIHPAON.SetFloat("settings.cameramovements", value);
				this.ODPAJIHPAON.SetFloat("_Blue_R", (float)num);
				RenderTexture renderTexture = this.OLMFBPNPCIE(HLBKCLPNHEB, 1, this.BOLBCBMBOLJ);
				Graphics.Blit(null, renderTexture, this.ODPAJIHPAON, 0);
				RenderTexture renderTexture2 = this.GAHFCCOBCOB(HLBKCLPNHEB, 5, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture, renderTexture2, this.ODPAJIHPAON, 1);
				RenderTexture renderTexture3 = this.MMBMEGOAKHG(HLBKCLPNHEB, 5, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture2, renderTexture3, this.ODPAJIHPAON, 3);
				this.OHIJPKHAOGG(renderTexture2);
				Vector2 v = Vector2.one * ((float)num2 / 330f - 1763f) * 1431f;
				this.ODPAJIHPAON.SetVector("Error: Can not set the OnSerialize rate higher than the overall SendRate.", v);
				this.ODPAJIHPAON.SetInt("_TimeX", num2 / 6);
				RenderTexture renderTexture4 = this.MPPNAEMCEAC(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture3, renderTexture4, this.ODPAJIHPAON, 6);
				this.DLBDHIDDLGB(renderTexture3);
				RenderTexture renderTexture5 = this.MPPNAEMCEAC(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture4, renderTexture5, this.ODPAJIHPAON, 5);
				this.OFFLHEPANAK(renderTexture4);
				this.ODPAJIHPAON.SetInt("achievements.21.completed.", Mathf.Clamp(NNGJCGPELAJ / 2, 0, 117));
				this.ODPAJIHPAON.SetFloat("Set satellite audio input", (float)num);
				this.ODPAJIHPAON.SetTexture("_Value", renderTexture5);
				this.ODPAJIHPAON.SetTexture("Fade", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.CIGMLEHHEMC) ? 3 : 7);
				this.ACPACJOBPGA(renderTexture);
				this.GKIKEEPDLLJ(renderTexture5);
			}

			// Token: 0x06008395 RID: 33685 RVA: 0x002D75D4 File Offset: 0x002D57D4
			public void KKLENIBKBGF(float IOLJECDGKFB, int NNGJCGPELAJ, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				if (this.ODPAJIHPAON == null)
				{
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
					return;
				}
				int num = (int)(1143f * (float)HLBKCLPNHEB.height / 1561f);
				int num2 = ((num - 1) / 1 + 0) * 0;
				float value = IOLJECDGKFB / 1381f * 815f;
				this.ODPAJIHPAON.SetFloat("CameraFilterPack/Blend2Camera_LighterColor", value);
				this.ODPAJIHPAON.SetFloat("original.tutorial", (float)num);
				RenderTexture renderTexture = this.JHOJHJOGLID(HLBKCLPNHEB, 1, this.BOLBCBMBOLJ);
				Graphics.Blit(null, renderTexture, this.ODPAJIHPAON, 1);
				RenderTexture renderTexture2 = this.MODNENJAGOG(HLBKCLPNHEB, 1, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture, renderTexture2, this.ODPAJIHPAON, 0);
				RenderTexture renderTexture3 = this.BBKAGOOIECM(HLBKCLPNHEB, 3, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture2, renderTexture3, this.ODPAJIHPAON, 6);
				this.FMCPLMBMCLJ(renderTexture2);
				Vector2 v = Vector2.one * ((float)num2 / 431f - 401f) * 875f;
				this.ODPAJIHPAON.SetVector("path", v);
				this.ODPAJIHPAON.SetInt("[ReplayScene] Loading replay: ", num2 / 2);
				RenderTexture renderTexture4 = this.JIHNLMGIADC(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture3, renderTexture4, this.ODPAJIHPAON, 7);
				this.JFPCHNOHCBD(renderTexture3);
				RenderTexture renderTexture5 = this.CNFEJDAOGPI(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture4, renderTexture5, this.ODPAJIHPAON, 0);
				this.BCEIKIFOPDF(renderTexture4);
				this.ODPAJIHPAON.SetInt(" with a prefix of ", Mathf.Clamp(NNGJCGPELAJ / 4, 1, 8));
				this.ODPAJIHPAON.SetFloat("Please specify a map name or buildID", (float)num);
				this.ODPAJIHPAON.SetTexture("scn", renderTexture5);
				this.ODPAJIHPAON.SetTexture("CameraFilterPack/Colors_BleachBypass", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.CIGMLEHHEMC) ? 3 : 0);
				this.GKIKEEPDLLJ(renderTexture);
				this.GKIKEEPDLLJ(renderTexture5);
			}

			// Token: 0x06008396 RID: 33686 RVA: 0x002D77CC File Offset: 0x002D59CC
			private RenderTexture GAHFCCOBCOB(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Bilinear;
				return temporary;
			}

			// Token: 0x06008397 RID: 33687 RVA: 0x002D5559 File Offset: 0x002D3759
			public void FOALLFHOGOI()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x06008398 RID: 33688 RVA: 0x002D5559 File Offset: 0x002D3759
			public void AIJNKBGFMII()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x06008399 RID: 33689 RVA: 0x002D5778 File Offset: 0x002D3978
			private void ACPACJOBPGA(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x0600839A RID: 33690 RVA: 0x002D5559 File Offset: 0x002D3759
			public void JPNFHIGHNFO()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x0600839B RID: 33691 RVA: 0x002D7800 File Offset: 0x002D5A00
			private RenderTexture MMBMEGOAKHG(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Bilinear;
				return temporary;
			}

			// Token: 0x0600839C RID: 33692 RVA: 0x002D5559 File Offset: 0x002D3759
			public void INGPGHHNNMD()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x0600839D RID: 33693 RVA: 0x002D631D File Offset: 0x002D451D
			private bool HIDBMKINMLI()
			{
				if (!SystemInfo.SupportsRenderTextureFormat(this.FPHCGAMONFG))
				{
					return false;
				}
				if (!SystemInfo.SupportsRenderTextureFormat(this.BOLBCBMBOLJ))
				{
					this.BOLBCBMBOLJ = RenderTextureFormat.ARGB32;
				}
				return false;
			}

			// Token: 0x0600839E RID: 33694 RVA: 0x002D7834 File Offset: 0x002D5A34
			public void HLDIOFHPMMK(float IOLJECDGKFB, int NNGJCGPELAJ, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				if (this.ODPAJIHPAON == null)
				{
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
					return;
				}
				int num = (int)(1292f * (float)HLBKCLPNHEB.height / 816f);
				int num2 = ((num - 1) / 7 + 0) * 1;
				float value = IOLJECDGKFB / 1126f * 952f;
				this.ODPAJIHPAON.SetFloat("_Near", value);
				this.ODPAJIHPAON.SetFloat("\r", (float)num);
				RenderTexture renderTexture = this.CCDHDPPPEHE(HLBKCLPNHEB, 1, this.BOLBCBMBOLJ);
				Graphics.Blit(null, renderTexture, this.ODPAJIHPAON, 1);
				RenderTexture renderTexture2 = this.GFANDNHDDFP(HLBKCLPNHEB, 5, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture, renderTexture2, this.ODPAJIHPAON, 0);
				RenderTexture renderTexture3 = this.MPPNAEMCEAC(HLBKCLPNHEB, 2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture2, renderTexture3, this.ODPAJIHPAON, 1);
				this.CMCBJFANPOL(renderTexture2);
				Vector2 v = Vector2.one * ((float)num2 / 1303f - 1836f) * 81f;
				this.ODPAJIHPAON.SetVector("_Intensity", v);
				this.ODPAJIHPAON.SetInt("_MainTex2", num2 / 0);
				RenderTexture renderTexture4 = this.PHDEMOOJGMA(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture3, renderTexture4, this.ODPAJIHPAON, 4);
				this.OHIJPKHAOGG(renderTexture3);
				RenderTexture renderTexture5 = this.OLMFBPNPCIE(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture4, renderTexture5, this.ODPAJIHPAON, 8);
				this.FINELAEDKEM(renderTexture4);
				this.ODPAJIHPAON.SetInt("_TimeX", Mathf.Clamp(NNGJCGPELAJ / 4, 1, 14));
				this.ODPAJIHPAON.SetFloat("DPADVER", (float)num);
				this.ODPAJIHPAON.SetTexture("mapselector.tags.", renderTexture5);
				this.ODPAJIHPAON.SetTexture(".lastCheckpoint.time", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.CIGMLEHHEMC) ? 1 : 2);
				this.PIPLCCPCNHP(renderTexture);
				this.IHANNNMNCJD(renderTexture5);
			}

			// Token: 0x0600839F RID: 33695 RVA: 0x002D5778 File Offset: 0x002D3978
			private void ONFAGEIFIJH(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x060083A0 RID: 33696 RVA: 0x002D7A2C File Offset: 0x002D5C2C
			public void CBMPHIPDBNO(float IOLJECDGKFB, int NNGJCGPELAJ, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				if (this.ODPAJIHPAON == null)
				{
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
					return;
				}
				int num = (int)(1190f * (float)HLBKCLPNHEB.height / 1457f);
				int num2 = ((num - 1) / 1 + 1) * 7;
				float value = IOLJECDGKFB / 60f * 410f;
				this.ODPAJIHPAON.SetFloat("_ScreenResolution", value);
				this.ODPAJIHPAON.SetFloat("local CheckCondition = function()", (float)num);
				RenderTexture renderTexture = this.HCIJBGHGBLB(HLBKCLPNHEB, 1, this.BOLBCBMBOLJ);
				Graphics.Blit(null, renderTexture, this.ODPAJIHPAON, 1);
				RenderTexture renderTexture2 = this.OOLCNDEMLKP(HLBKCLPNHEB, 3, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture, renderTexture2, this.ODPAJIHPAON, 0);
				RenderTexture renderTexture3 = this.NKJAFDOALBE(HLBKCLPNHEB, 5, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture2, renderTexture3, this.ODPAJIHPAON, 4);
				this.OIGPCDKPAFN(renderTexture2);
				Vector2 v = Vector2.one * ((float)num2 / 1544f - 734f) * 43f;
				this.ODPAJIHPAON.SetVector("_Value", v);
				this.ODPAJIHPAON.SetInt("x", num2 / 1);
				RenderTexture renderTexture4 = this.GIDMHCIFJCP(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture3, renderTexture4, this.ODPAJIHPAON, 1);
				this.PIPLCCPCNHP(renderTexture3);
				RenderTexture renderTexture5 = this.AGFELPBAGDD(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture4, renderTexture5, this.ODPAJIHPAON, 8);
				this.IHANNNMNCJD(renderTexture4);
				this.ODPAJIHPAON.SetInt("speed", Mathf.Clamp(NNGJCGPELAJ / 6, 0, -122));
				this.ODPAJIHPAON.SetFloat("_AlphaMask", (float)num);
				this.ODPAJIHPAON.SetTexture("_TimeX", renderTexture5);
				this.ODPAJIHPAON.SetTexture("CameraFilterPack/Drawing_Manga_Color", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.CIGMLEHHEMC) ? 0 : 1);
				this.KNOMBEAKPBI(renderTexture);
				this.FMCPLMBMCLJ(renderTexture5);
			}

			// Token: 0x060083A1 RID: 33697 RVA: 0x002D5778 File Offset: 0x002D3978
			private void PLPFEEIIBDE(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x060083A2 RID: 33698 RVA: 0x002D7C24 File Offset: 0x002D5E24
			private RenderTexture MODNENJAGOG(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Point;
				return temporary;
			}

			// Token: 0x060083A3 RID: 33699 RVA: 0x002D5778 File Offset: 0x002D3978
			private void LLGKKNLGMGH(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x060083A4 RID: 33700 RVA: 0x002D5819 File Offset: 0x002D3A19
			private bool AHJGJOBIDGF()
			{
				if (!SystemInfo.SupportsRenderTextureFormat(this.FPHCGAMONFG))
				{
					return false;
				}
				if (!SystemInfo.SupportsRenderTextureFormat(this.BOLBCBMBOLJ))
				{
					this.BOLBCBMBOLJ = RenderTextureFormat.Depth;
				}
				return false;
			}

			// Token: 0x060083A5 RID: 33701 RVA: 0x002D7C58 File Offset: 0x002D5E58
			private RenderTexture AGFELPBAGDD(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Point;
				return temporary;
			}

			// Token: 0x060083A6 RID: 33702 RVA: 0x002D6039 File Offset: 0x002D4239
			private bool ENOKBDFECPG()
			{
				if (!SystemInfo.SupportsRenderTextureFormat(this.FPHCGAMONFG))
				{
					return false;
				}
				if (!SystemInfo.SupportsRenderTextureFormat(this.BOLBCBMBOLJ))
				{
					this.BOLBCBMBOLJ = RenderTextureFormat.ARGB32;
				}
				return true;
			}

			// Token: 0x060083A7 RID: 33703 RVA: 0x002D6065 File Offset: 0x002D4265
			private bool NNHGFCCFOHJ()
			{
				if (!SystemInfo.SupportsRenderTextureFormat(this.FPHCGAMONFG))
				{
					return true;
				}
				if (!SystemInfo.SupportsRenderTextureFormat(this.BOLBCBMBOLJ))
				{
					this.BOLBCBMBOLJ = RenderTextureFormat.ARGB32;
				}
				return true;
			}

			// Token: 0x060083A8 RID: 33704 RVA: 0x002D5559 File Offset: 0x002D3759
			public void AADECGPKKME()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x060083A9 RID: 33705 RVA: 0x002D5559 File Offset: 0x002D3759
			public void OEDNDJAKFDG()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x060083AA RID: 33706 RVA: 0x002D5559 File Offset: 0x002D3759
			public void CDCGLEKAOHF()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x060083AB RID: 33707 RVA: 0x002D6065 File Offset: 0x002D4265
			private bool HAKIOGMBDAA()
			{
				if (!SystemInfo.SupportsRenderTextureFormat(this.FPHCGAMONFG))
				{
					return true;
				}
				if (!SystemInfo.SupportsRenderTextureFormat(this.BOLBCBMBOLJ))
				{
					this.BOLBCBMBOLJ = RenderTextureFormat.ARGB32;
				}
				return true;
			}

			// Token: 0x060083AC RID: 33708 RVA: 0x002D7C8C File Offset: 0x002D5E8C
			private RenderTexture CCDHDPPPEHE(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Bilinear;
				return temporary;
			}

			// Token: 0x060083AD RID: 33709 RVA: 0x002D7CC0 File Offset: 0x002D5EC0
			public void EGOHFNGBMKJ(float IOLJECDGKFB, int NNGJCGPELAJ, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				if (this.ODPAJIHPAON == null)
				{
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
					return;
				}
				int num = (int)(393f * (float)HLBKCLPNHEB.height / 1990f);
				int num2 = ((num - 1) / 8 + 0) * 6;
				float value = IOLJECDGKFB / 1085f * 203f;
				this.ODPAJIHPAON.SetFloat("_", value);
				this.ODPAJIHPAON.SetFloat("{0:x2}", (float)num);
				RenderTexture renderTexture = this.MMBMEGOAKHG(HLBKCLPNHEB, 1, this.BOLBCBMBOLJ);
				Graphics.Blit(null, renderTexture, this.ODPAJIHPAON, 1);
				RenderTexture renderTexture2 = this.OLMFBPNPCIE(HLBKCLPNHEB, 0, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture, renderTexture2, this.ODPAJIHPAON, 1);
				RenderTexture renderTexture3 = this.MODNENJAGOG(HLBKCLPNHEB, 3, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture2, renderTexture3, this.ODPAJIHPAON, 5);
				this.OIPAMGPBMFF(renderTexture2);
				Vector2 v = Vector2.one * ((float)num2 / 1830f - 1918f) * 1276f;
				this.ODPAJIHPAON.SetVector("Set sun audio input", v);
				this.ODPAJIHPAON.SetInt("CameraFilterPack/Vision_Plasma", num2 / 8);
				RenderTexture renderTexture4 = this.KHLPKLDHOAH(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture3, renderTexture4, this.ODPAJIHPAON, 5);
				this.ONFAGEIFIJH(renderTexture3);
				RenderTexture renderTexture5 = this.AGFELPBAGDD(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture4, renderTexture5, this.ODPAJIHPAON, 2);
				this.ONFAGEIFIJH(renderTexture4);
				this.ODPAJIHPAON.SetInt("Player", Mathf.Clamp(NNGJCGPELAJ / 6, 0, 30));
				this.ODPAJIHPAON.SetFloat(". Should be just one?", (float)num);
				this.ODPAJIHPAON.SetTexture("http://steamcommunity.com/sharedfiles/filedetails/?id=", renderTexture5);
				this.ODPAJIHPAON.SetTexture("Creating awesome map", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.CIGMLEHHEMC) ? 2 : 7);
				this.BKHBHCCHDIF(renderTexture);
				this.FMCPLMBMCLJ(renderTexture5);
			}

			// Token: 0x060083AE RID: 33710 RVA: 0x002D5559 File Offset: 0x002D3759
			public void HNFNPPODOLJ()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x060083AF RID: 33711 RVA: 0x002D5778 File Offset: 0x002D3978
			private void JFPCHNOHCBD(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x060083B0 RID: 33712 RVA: 0x002D7EB8 File Offset: 0x002D60B8
			public void DGHHDLHBJNA(float IOLJECDGKFB, int NNGJCGPELAJ, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				if (this.ODPAJIHPAON == null)
				{
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
					return;
				}
				int num = (int)(781f * (float)HLBKCLPNHEB.height / 1097f);
				int num2 = ((num - 1) / 1 + 0) * 4;
				float value = IOLJECDGKFB / 667f * 1175f;
				this.ODPAJIHPAON.SetFloat("_Value", value);
				this.ODPAJIHPAON.SetFloat("\nCreated by Oxy949", (float)num);
				RenderTexture renderTexture = this.JHOJHJOGLID(HLBKCLPNHEB, 0, this.BOLBCBMBOLJ);
				Graphics.Blit(null, renderTexture, this.ODPAJIHPAON, 0);
				RenderTexture renderTexture2 = this.PHDEMOOJGMA(HLBKCLPNHEB, 6, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture, renderTexture2, this.ODPAJIHPAON, 0);
				RenderTexture renderTexture3 = this.MOEHCIFPDBA(HLBKCLPNHEB, 0, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture2, renderTexture3, this.ODPAJIHPAON, 1);
				this.EEEAIEBCOLJ(renderTexture2);
				Vector2 v = Vector2.one * ((float)num2 / 1694f - 995f) * 537f;
				this.ODPAJIHPAON.SetVector("Environment/SunBase_", v);
				this.ODPAJIHPAON.SetInt(" Time: ", num2 / 5);
				RenderTexture renderTexture4 = this.FJGCGDLBAOH(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture3, renderTexture4, this.ODPAJIHPAON, 1);
				this.GLBACCKCCNG(renderTexture3);
				RenderTexture renderTexture5 = this.MPPNAEMCEAC(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture4, renderTexture5, this.ODPAJIHPAON, 0);
				this.LIAMAJOKEBB(renderTexture4);
				this.ODPAJIHPAON.SetInt("]", Mathf.Clamp(NNGJCGPELAJ / 3, 0, 93));
				this.ODPAJIHPAON.SetFloat("1.87", (float)num);
				this.ODPAJIHPAON.SetTexture("/GetNews/pinnednewsid", renderTexture5);
				this.ODPAJIHPAON.SetTexture("CameraFilterPack/Edge_Edge_filter", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.CIGMLEHHEMC) ? 7 : 6);
				this.FCPLIGCKKHH(renderTexture);
				this.ADBJCJFCHFD(renderTexture5);
			}

			// Token: 0x060083B1 RID: 33713 RVA: 0x002D5778 File Offset: 0x002D3978
			private void FGKKGLIOLBF(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x060083B2 RID: 33714 RVA: 0x002D5559 File Offset: 0x002D3759
			public void ELNLFKIMCCM()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x060083B3 RID: 33715 RVA: 0x002D80B0 File Offset: 0x002D62B0
			private bool CLJAJBOBPAG()
			{
				if (!SystemInfo.SupportsRenderTextureFormat(this.FPHCGAMONFG))
				{
					return true;
				}
				if (!SystemInfo.SupportsRenderTextureFormat(this.BOLBCBMBOLJ))
				{
					this.BOLBCBMBOLJ = RenderTextureFormat.Depth;
				}
				return false;
			}

			// Token: 0x060083B4 RID: 33716 RVA: 0x002D5778 File Offset: 0x002D3978
			private void BKHBHCCHDIF(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x060083B5 RID: 33717 RVA: 0x002D5559 File Offset: 0x002D3759
			public void MDOOAFLCOPM()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x060083B6 RID: 33718 RVA: 0x002D5559 File Offset: 0x002D3759
			public void DLPOPJKGFMG()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x060083B7 RID: 33719 RVA: 0x002D5778 File Offset: 0x002D3978
			private void OHIJPKHAOGG(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x060083B8 RID: 33720 RVA: 0x002D80DC File Offset: 0x002D62DC
			public void CPDHBLIPLEL(float IOLJECDGKFB, int NNGJCGPELAJ, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				if (this.ODPAJIHPAON == null)
				{
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
					return;
				}
				int num = (int)(1744f * (float)HLBKCLPNHEB.height / 1283f);
				int num2 = ((num - 1) / 7 + 0) * 0;
				float value = IOLJECDGKFB / 472f * 475f;
				this.ODPAJIHPAON.SetFloat("_Value3", value);
				this.ODPAJIHPAON.SetFloat("Crosshair", (float)num);
				RenderTexture renderTexture = this.FJGCGDLBAOH(HLBKCLPNHEB, 0, this.BOLBCBMBOLJ);
				Graphics.Blit(null, renderTexture, this.ODPAJIHPAON, 1);
				RenderTexture renderTexture2 = this.MPPNAEMCEAC(HLBKCLPNHEB, 5, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture, renderTexture2, this.ODPAJIHPAON, 0);
				RenderTexture renderTexture3 = this.LOOOBEDOKMP(HLBKCLPNHEB, 5, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture2, renderTexture3, this.ODPAJIHPAON, 1);
				this.CGAKCDHLMBH(renderTexture2);
				Vector2 v = Vector2.one * ((float)num2 / 841f - 175f) * 453f;
				this.ODPAJIHPAON.SetVector("\" marked with the [PunRPC](C#) or @PunRPC(JS) property! Args: ", v);
				this.ODPAJIHPAON.SetInt("offline", num2 / 0);
				RenderTexture renderTexture4 = this.CNFEJDAOGPI(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture3, renderTexture4, this.ODPAJIHPAON, 8);
				this.ONFAGEIFIJH(renderTexture3);
				RenderTexture renderTexture5 = this.BBKAGOOIECM(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture4, renderTexture5, this.ODPAJIHPAON, 7);
				this.FCPLIGCKKHH(renderTexture4);
				this.ODPAJIHPAON.SetInt("_BlurSize", Mathf.Clamp(NNGJCGPELAJ / 1, 0, -64));
				this.ODPAJIHPAON.SetFloat(" not exist", (float)num);
				this.ODPAJIHPAON.SetTexture("_FixDistance", renderTexture5);
				this.ODPAJIHPAON.SetTexture("Most likely the game became empty during the switch to GameServer.", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.CIGMLEHHEMC) ? 4 : 3);
				this.IMDHKFGLMKP(renderTexture);
				this.JMHEPMONPDA(renderTexture5);
			}

			// Token: 0x060083B9 RID: 33721 RVA: 0x002D5778 File Offset: 0x002D3978
			private void IMDHKFGLMKP(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x060083BA RID: 33722 RVA: 0x002D82D4 File Offset: 0x002D64D4
			public void ANAEDHOADEB(float IOLJECDGKFB, int NNGJCGPELAJ, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				if (this.ODPAJIHPAON == null)
				{
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
					return;
				}
				int num = (int)(440f * (float)HLBKCLPNHEB.height / 657f);
				int num2 = ((num - 1) / 0 + 1) * 7;
				float value = IOLJECDGKFB / 1894f * 689f;
				this.ODPAJIHPAON.SetFloat("offsets", value);
				this.ODPAJIHPAON.SetFloat("CameraFilterPack/Gradients_NeonGradient", (float)num);
				RenderTexture renderTexture = this.GFANDNHDDFP(HLBKCLPNHEB, 1, this.BOLBCBMBOLJ);
				Graphics.Blit(null, renderTexture, this.ODPAJIHPAON, 1);
				RenderTexture renderTexture2 = this.AGFELPBAGDD(HLBKCLPNHEB, 1, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture, renderTexture2, this.ODPAJIHPAON, 0);
				RenderTexture renderTexture3 = this.GIKMFNFAKPD(HLBKCLPNHEB, 6, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture2, renderTexture3, this.ODPAJIHPAON, 0);
				this.PIPLCCPCNHP(renderTexture2);
				Vector2 v = Vector2.one * ((float)num2 / 325f - 1457f) * 282f;
				this.ODPAJIHPAON.SetVector("IntraTime", v);
				this.ODPAJIHPAON.SetInt("GlassAberration", num2 / 6);
				RenderTexture renderTexture4 = this.GFANDNHDDFP(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture3, renderTexture4, this.ODPAJIHPAON, 7);
				this.PLPFEEIIBDE(renderTexture3);
				RenderTexture renderTexture5 = this.OLMFBPNPCIE(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture4, renderTexture5, this.ODPAJIHPAON, 8);
				this.EPMCBGNCNCA(renderTexture4);
				this.ODPAJIHPAON.SetInt("RootCanvas", Mathf.Clamp(NNGJCGPELAJ / 4, 0, -110));
				this.ODPAJIHPAON.SetFloat("Tab1Content", (float)num);
				this.ODPAJIHPAON.SetTexture("event", renderTexture5);
				this.ODPAJIHPAON.SetTexture("_Value2", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.CIGMLEHHEMC) ? 1 : 8);
				this.CMCBJFANPOL(renderTexture);
				this.EEEAIEBCOLJ(renderTexture5);
			}

			// Token: 0x060083BB RID: 33723 RVA: 0x002D5559 File Offset: 0x002D3759
			public void LGHOFGNPHMK()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x060083BC RID: 33724 RVA: 0x002D84CC File Offset: 0x002D66CC
			private RenderTexture GFANDNHDDFP(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Point;
				return temporary;
			}

			// Token: 0x060083BD RID: 33725 RVA: 0x002D5778 File Offset: 0x002D3978
			private void OIGPCDKPAFN(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x060083BE RID: 33726 RVA: 0x002D5778 File Offset: 0x002D3978
			private void PIPLCCPCNHP(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x060083BF RID: 33727 RVA: 0x002D80B0 File Offset: 0x002D62B0
			private bool MBMHILDKDKI()
			{
				if (!SystemInfo.SupportsRenderTextureFormat(this.FPHCGAMONFG))
				{
					return true;
				}
				if (!SystemInfo.SupportsRenderTextureFormat(this.BOLBCBMBOLJ))
				{
					this.BOLBCBMBOLJ = RenderTextureFormat.Depth;
				}
				return false;
			}

			// Token: 0x060083C0 RID: 33728 RVA: 0x002D62BD File Offset: 0x002D44BD
			private bool BIPIPBKNKOJ()
			{
				if (!SystemInfo.SupportsRenderTextureFormat(this.FPHCGAMONFG))
				{
					return true;
				}
				if (!SystemInfo.SupportsRenderTextureFormat(this.BOLBCBMBOLJ))
				{
					this.BOLBCBMBOLJ = RenderTextureFormat.Depth;
				}
				return true;
			}

			// Token: 0x060083C1 RID: 33729 RVA: 0x002D8500 File Offset: 0x002D6700
			private RenderTexture OLMFBPNPCIE(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Point;
				return temporary;
			}

			// Token: 0x060083C2 RID: 33730 RVA: 0x002D8534 File Offset: 0x002D6734
			public void AEDCLBLLADB(float IOLJECDGKFB, int NNGJCGPELAJ, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				if (this.ODPAJIHPAON == null)
				{
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
					return;
				}
				int num = (int)(1146f * (float)HLBKCLPNHEB.height / 537f);
				int num2 = ((num - 0) / 5 + 0) * 3;
				float value = IOLJECDGKFB / 1327f * 1458f;
				this.ODPAJIHPAON.SetFloat("_TapMedium", value);
				this.ODPAJIHPAON.SetFloat("CameraFilterPack/FX_superDot", (float)num);
				RenderTexture renderTexture = this.NOMLPAMGEOE(HLBKCLPNHEB, 0, this.BOLBCBMBOLJ);
				Graphics.Blit(null, renderTexture, this.ODPAJIHPAON, 1);
				RenderTexture renderTexture2 = this.HCIJBGHGBLB(HLBKCLPNHEB, 1, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture, renderTexture2, this.ODPAJIHPAON, 1);
				RenderTexture renderTexture3 = this.OLMFBPNPCIE(HLBKCLPNHEB, 6, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture2, renderTexture3, this.ODPAJIHPAON, 5);
				this.PIPLCCPCNHP(renderTexture2);
				Vector2 v = Vector2.one * ((float)num2 / 646f - 1783f) * 1339f;
				this.ODPAJIHPAON.SetVector("speed", v);
				this.ODPAJIHPAON.SetInt("_MainTex", num2 / 4);
				RenderTexture renderTexture4 = this.OPBNBFCBFFD(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture3, renderTexture4, this.ODPAJIHPAON, 0);
				this.FGKKGLIOLBF(renderTexture3);
				RenderTexture renderTexture5 = this.MPPNAEMCEAC(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture4, renderTexture5, this.ODPAJIHPAON, 3);
				this.PIPLCCPCNHP(renderTexture4);
				this.ODPAJIHPAON.SetInt("_Value4", Mathf.Clamp(NNGJCGPELAJ / 0, 0, 127));
				this.ODPAJIHPAON.SetFloat("SingleplayerButton", (float)num);
				this.ODPAJIHPAON.SetTexture("settings.enablehitsoundsinrelax", renderTexture5);
				this.ODPAJIHPAON.SetTexture("_Value12", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.CIGMLEHHEMC) ? 2 : 3);
				this.IMDHKFGLMKP(renderTexture);
				this.EPMCBGNCNCA(renderTexture5);
			}

			// Token: 0x060083C3 RID: 33731 RVA: 0x002D872C File Offset: 0x002D692C
			private RenderTexture OPBNBFCBFFD(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Bilinear;
				return temporary;
			}

			// Token: 0x060083C4 RID: 33732 RVA: 0x002D8760 File Offset: 0x002D6960
			public void ABLGIFAKCEL(float IOLJECDGKFB, int NNGJCGPELAJ, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				if (this.ODPAJIHPAON == null)
				{
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
					return;
				}
				int num = (int)(542f * (float)HLBKCLPNHEB.height / 899f);
				int num2 = ((num - 0) / 4 + 1) * 5;
				float value = IOLJECDGKFB / 1008f * 1866f;
				this.ODPAJIHPAON.SetFloat("CameraFilterPack/Blend2Camera_SoftLight", value);
				this.ODPAJIHPAON.SetFloat("UI/Particles/Hidden", (float)num);
				RenderTexture renderTexture = this.MOEHCIFPDBA(HLBKCLPNHEB, 0, this.BOLBCBMBOLJ);
				Graphics.Blit(null, renderTexture, this.ODPAJIHPAON, 1);
				RenderTexture renderTexture2 = this.AKJFCEKGMJJ(HLBKCLPNHEB, 1, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture, renderTexture2, this.ODPAJIHPAON, 1);
				RenderTexture renderTexture3 = this.MOEHCIFPDBA(HLBKCLPNHEB, 8, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture2, renderTexture3, this.ODPAJIHPAON, 7);
				this.JFPCHNOHCBD(renderTexture2);
				Vector2 v = Vector2.one * ((float)num2 / 1782f - 1651f) * 1829f;
				this.ODPAJIHPAON.SetVector("Netw. Sim.", v);
				this.ODPAJIHPAON.SetInt("Object ID. Case-Sensitive", num2 / 3);
				RenderTexture renderTexture4 = this.NKJAFDOALBE(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture3, renderTexture4, this.ODPAJIHPAON, 7);
				this.PIPLCCPCNHP(renderTexture3);
				RenderTexture renderTexture5 = this.GIKMFNFAKPD(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture4, renderTexture5, this.ODPAJIHPAON, 8);
				this.GLBACCKCCNG(renderTexture4);
				this.ODPAJIHPAON.SetInt("OnJoinedLobby(). This client is connected and does get a room-list, which gets stored as PhotonNetwork.GetRoomList(). This script now calls: PhotonNetwork.JoinRandomRoom();", Mathf.Clamp(NNGJCGPELAJ / 6, 1, -46));
				this.ODPAJIHPAON.SetFloat(" is not supported on this platform!", (float)num);
				this.ODPAJIHPAON.SetTexture("_ColorR", renderTexture5);
				this.ODPAJIHPAON.SetTexture("BitsData", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.CIGMLEHHEMC) ? 6 : 8);
				this.ACPACJOBPGA(renderTexture);
				this.OHIJPKHAOGG(renderTexture5);
			}

			// Token: 0x060083C5 RID: 33733 RVA: 0x002D6039 File Offset: 0x002D4239
			private bool FGAEPBDABJL()
			{
				if (!SystemInfo.SupportsRenderTextureFormat(this.FPHCGAMONFG))
				{
					return false;
				}
				if (!SystemInfo.SupportsRenderTextureFormat(this.BOLBCBMBOLJ))
				{
					this.BOLBCBMBOLJ = RenderTextureFormat.ARGB32;
				}
				return true;
			}

			// Token: 0x060083C6 RID: 33734 RVA: 0x002D5559 File Offset: 0x002D3759
			public void ILJNCBKNNIA()
			{
				if (this.ODPAJIHPAON != null)
				{
					UnityEngine.Object.DestroyImmediate(this.ODPAJIHPAON);
				}
				this.ODPAJIHPAON = null;
			}

			// Token: 0x060083C7 RID: 33735 RVA: 0x002D6039 File Offset: 0x002D4239
			private bool HLABNANIBEK()
			{
				if (!SystemInfo.SupportsRenderTextureFormat(this.FPHCGAMONFG))
				{
					return false;
				}
				if (!SystemInfo.SupportsRenderTextureFormat(this.BOLBCBMBOLJ))
				{
					this.BOLBCBMBOLJ = RenderTextureFormat.ARGB32;
				}
				return true;
			}

			// Token: 0x060083C8 RID: 33736 RVA: 0x002D6065 File Offset: 0x002D4265
			private bool GPHLJBKLCMD()
			{
				if (!SystemInfo.SupportsRenderTextureFormat(this.FPHCGAMONFG))
				{
					return true;
				}
				if (!SystemInfo.SupportsRenderTextureFormat(this.BOLBCBMBOLJ))
				{
					this.BOLBCBMBOLJ = RenderTextureFormat.ARGB32;
				}
				return true;
			}

			// Token: 0x060083C9 RID: 33737 RVA: 0x002D8958 File Offset: 0x002D6B58
			public void PELFFMLBNCJ(float IOLJECDGKFB, int NNGJCGPELAJ, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
			{
				if (this.ODPAJIHPAON == null)
				{
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
					return;
				}
				int num = (int)(677f * (float)HLBKCLPNHEB.height / 439f);
				int num2 = ((num - 1) / 1 + 1) * 5;
				float value = IOLJECDGKFB / 375f * 1169f;
				this.ODPAJIHPAON.SetFloat("[MapEditor] Loaded music file: ", value);
				this.ODPAJIHPAON.SetFloat("_TimeX", (float)num);
				RenderTexture renderTexture = this.GAHFCCOBCOB(HLBKCLPNHEB, 0, this.BOLBCBMBOLJ);
				Graphics.Blit(null, renderTexture, this.ODPAJIHPAON, 0);
				RenderTexture renderTexture2 = this.MOEHCIFPDBA(HLBKCLPNHEB, 7, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture, renderTexture2, this.ODPAJIHPAON, 0);
				RenderTexture renderTexture3 = this.OLMFBPNPCIE(HLBKCLPNHEB, 6, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture2, renderTexture3, this.ODPAJIHPAON, 4);
				this.OFFLHEPANAK(renderTexture2);
				Vector2 v = Vector2.one * ((float)num2 / 355f - 26f) * 1820f;
				this.ODPAJIHPAON.SetVector("_EmissionGain", v);
				this.ODPAJIHPAON.SetInt("_Color_B", num2 / 8);
				RenderTexture renderTexture4 = this.HCIJBGHGBLB(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture3, renderTexture4, this.ODPAJIHPAON, 1);
				this.ACPACJOBPGA(renderTexture3);
				RenderTexture renderTexture5 = this.JHOJHJOGLID(HLBKCLPNHEB, num2, this.FPHCGAMONFG);
				Graphics.Blit(renderTexture4, renderTexture5, this.ODPAJIHPAON, 4);
				this.DLBDHIDDLGB(renderTexture4);
				this.ODPAJIHPAON.SetInt("Tab2Content", Mathf.Clamp(NNGJCGPELAJ / 4, 0, -112));
				this.ODPAJIHPAON.SetFloat("CameraFilterPack/TV_WideScreenCircle", (float)num);
				this.ODPAJIHPAON.SetTexture("_ScreenResolution", renderTexture5);
				this.ODPAJIHPAON.SetTexture("st", renderTexture);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.ODPAJIHPAON, (!this.CIGMLEHHEMC) ? 5 : 3);
				this.OFFLHEPANAK(renderTexture);
				this.LLGKKNLGMGH(renderTexture5);
			}

			// Token: 0x060083CA RID: 33738 RVA: 0x002D5778 File Offset: 0x002D3978
			private void OIPAMGPBMFF(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x060083CB RID: 33739 RVA: 0x002D5778 File Offset: 0x002D3978
			private void FCPLIGCKKHH(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x060083CC RID: 33740 RVA: 0x002D5778 File Offset: 0x002D3978
			private void LIAMAJOKEBB(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x060083CD RID: 33741 RVA: 0x002D5778 File Offset: 0x002D3978
			private void EIKHJMGNBJJ(RenderTexture HIIBHBOMGLD)
			{
				RenderTexture.ReleaseTemporary(HIIBHBOMGLD);
			}

			// Token: 0x060083CE RID: 33742 RVA: 0x002D8B50 File Offset: 0x002D6D50
			private RenderTexture OOLCNDEMLKP(Texture HLBKCLPNHEB, int IMDGFHEAHLC, RenderTextureFormat LGLMKIPIIHO)
			{
				int width = HLBKCLPNHEB.width / IMDGFHEAHLC;
				int height = HLBKCLPNHEB.height / IMDGFHEAHLC;
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0, LGLMKIPIIHO);
				temporary.filterMode = FilterMode.Point;
				return temporary;
			}

			// Token: 0x060083CF RID: 33743 RVA: 0x002D6039 File Offset: 0x002D4239
			private bool DKPBBAILGFA()
			{
				if (!SystemInfo.SupportsRenderTextureFormat(this.FPHCGAMONFG))
				{
					return false;
				}
				if (!SystemInfo.SupportsRenderTextureFormat(this.BOLBCBMBOLJ))
				{
					this.BOLBCBMBOLJ = RenderTextureFormat.ARGB32;
				}
				return true;
			}

			// Token: 0x04000EF7 RID: 3831
			private const float JDKPIFNEDNK = 5f;

			// Token: 0x04000EF8 RID: 3832
			private Material ODPAJIHPAON;

			// Token: 0x04000EF9 RID: 3833
			private bool CIGMLEHHEMC;

			// Token: 0x04000EFA RID: 3834
			private RenderTextureFormat FPHCGAMONFG = RenderTextureFormat.RGHalf;

			// Token: 0x04000EFB RID: 3835
			private RenderTextureFormat BOLBCBMBOLJ = RenderTextureFormat.ARGB2101010;
		}

		// Token: 0x0200020E RID: 526
		[Serializable]
		public class Settings
		{
			// Token: 0x060083D0 RID: 33744 RVA: 0x002D8B84 File Offset: 0x002D6D84
			public static MotionBlur.Settings NPIEKGGCMBG()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 1310f,
					sampleCount = 105,
					frameBlending = 1356f
				};
			}

			// Token: 0x060083D1 RID: 33745 RVA: 0x002D8BB8 File Offset: 0x002D6DB8
			public static MotionBlur.Settings DHGILJILMLN()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 1788f,
					sampleCount = -27,
					frameBlending = 1716f
				};
			}

			// Token: 0x060083D2 RID: 33746 RVA: 0x002D8BEC File Offset: 0x002D6DEC
			public static MotionBlur.Settings ELOBECLMGDD()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 1631f,
					sampleCount = -9,
					frameBlending = 501f
				};
			}

			// Token: 0x060083D3 RID: 33747 RVA: 0x002D8C20 File Offset: 0x002D6E20
			public static MotionBlur.Settings MGEOLKPLHOM()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 1910f,
					sampleCount = -95,
					frameBlending = 1421f
				};
			}

			// Token: 0x060083D4 RID: 33748 RVA: 0x002D8C54 File Offset: 0x002D6E54
			public static MotionBlur.Settings LOMOMPKEDPL()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 496f,
					sampleCount = 58,
					frameBlending = 1132f
				};
			}

			// Token: 0x060083D5 RID: 33749 RVA: 0x002D8C88 File Offset: 0x002D6E88
			public static MotionBlur.Settings IHMKIGDJKAH()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 1525f,
					sampleCount = 15,
					frameBlending = 1951f
				};
			}

			// Token: 0x060083D6 RID: 33750 RVA: 0x002D8CBC File Offset: 0x002D6EBC
			public static MotionBlur.Settings FMLCJEKMPCN()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 732f,
					sampleCount = -32,
					frameBlending = 1613f
				};
			}

			// Token: 0x060083D7 RID: 33751 RVA: 0x002D8CF0 File Offset: 0x002D6EF0
			public static MotionBlur.Settings BCOPOEIJONI()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 1791f,
					sampleCount = 76,
					frameBlending = 1630f
				};
			}

			// Token: 0x060083D8 RID: 33752 RVA: 0x002D8D24 File Offset: 0x002D6F24
			public static MotionBlur.Settings HJLGAPEDPJM()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 478f,
					sampleCount = 14,
					frameBlending = 1762f
				};
			}

			// Token: 0x060083D9 RID: 33753 RVA: 0x002D8D58 File Offset: 0x002D6F58
			public static MotionBlur.Settings DFIOJCABPFD()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 0f,
					sampleCount = 127,
					frameBlending = 1485f
				};
			}

			// Token: 0x060083DA RID: 33754 RVA: 0x002D8D8C File Offset: 0x002D6F8C
			public static MotionBlur.Settings FIFAPIHDEBM()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 993f,
					sampleCount = -27,
					frameBlending = 1317f
				};
			}

			// Token: 0x060083DB RID: 33755 RVA: 0x002D8DC0 File Offset: 0x002D6FC0
			public static MotionBlur.Settings EEMMJNPOFOB()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 1354f,
					sampleCount = 23,
					frameBlending = 1408f
				};
			}

			// Token: 0x060083DC RID: 33756 RVA: 0x002D8DF4 File Offset: 0x002D6FF4
			public static MotionBlur.Settings IAKJOAGBDGO()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 264f,
					sampleCount = -9,
					frameBlending = 1764f
				};
			}

			// Token: 0x060083DD RID: 33757 RVA: 0x002D8E28 File Offset: 0x002D7028
			public static MotionBlur.Settings NOBNMJMOJDB()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 67f,
					sampleCount = -99,
					frameBlending = 1507f
				};
			}

			// Token: 0x060083DE RID: 33758 RVA: 0x002D8E5C File Offset: 0x002D705C
			public static MotionBlur.Settings AAPGCALKNAK()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 1320f,
					sampleCount = -108,
					frameBlending = 769f
				};
			}

			// Token: 0x060083DF RID: 33759 RVA: 0x002D8E90 File Offset: 0x002D7090
			public static MotionBlur.Settings CDJAOBCAOKJ()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 63f,
					sampleCount = -7,
					frameBlending = 373f
				};
			}

			// Token: 0x060083E0 RID: 33760 RVA: 0x002D8EC4 File Offset: 0x002D70C4
			public static MotionBlur.Settings MHIHHBMBDLP()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 321f,
					sampleCount = -54,
					frameBlending = 71f
				};
			}

			// Token: 0x060083E1 RID: 33761 RVA: 0x002D8EF8 File Offset: 0x002D70F8
			public static MotionBlur.Settings GJNKFICGFFG()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 881f,
					sampleCount = 7,
					frameBlending = 5f
				};
			}

			// Token: 0x060083E2 RID: 33762 RVA: 0x002D8F2C File Offset: 0x002D712C
			public static MotionBlur.Settings CIHLOMNEHHL()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 1963f,
					sampleCount = -90,
					frameBlending = 1562f
				};
			}

			// Token: 0x060083E3 RID: 33763 RVA: 0x002D8F60 File Offset: 0x002D7160
			public static MotionBlur.Settings EJLLADABOLM()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 678f,
					sampleCount = 25,
					frameBlending = 1300f
				};
			}

			// Token: 0x060083E5 RID: 33765 RVA: 0x002D8F94 File Offset: 0x002D7194
			public static MotionBlur.Settings AOACBHHEGFA()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 426f,
					sampleCount = -70,
					frameBlending = 1736f
				};
			}

			// Token: 0x060083E6 RID: 33766 RVA: 0x002D8FC8 File Offset: 0x002D71C8
			public static MotionBlur.Settings IOFLMDMLCAG()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 751f,
					sampleCount = 85,
					frameBlending = 1073f
				};
			}

			// Token: 0x060083E7 RID: 33767 RVA: 0x002D8FFC File Offset: 0x002D71FC
			public static MotionBlur.Settings FPMJKNDJCON()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 1064f,
					sampleCount = -36,
					frameBlending = 662f
				};
			}

			// Token: 0x060083E8 RID: 33768 RVA: 0x002D9030 File Offset: 0x002D7230
			public static MotionBlur.Settings MLKLBGCKPOO()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 1376f,
					sampleCount = 67,
					frameBlending = 1117f
				};
			}

			// Token: 0x060083E9 RID: 33769 RVA: 0x002D9064 File Offset: 0x002D7264
			public static MotionBlur.Settings BOMFHCIHHIP()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 1680f,
					sampleCount = -67,
					frameBlending = 1107f
				};
			}

			// Token: 0x060083EA RID: 33770 RVA: 0x002D9098 File Offset: 0x002D7298
			public static MotionBlur.Settings NCFGPFGLKLJ()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 971f,
					sampleCount = -103,
					frameBlending = 762f
				};
			}

			// Token: 0x060083EB RID: 33771 RVA: 0x002D90CC File Offset: 0x002D72CC
			public static MotionBlur.Settings CJFONFEOHIO()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 1263f,
					sampleCount = -15,
					frameBlending = 1788f
				};
			}

			// Token: 0x060083EC RID: 33772 RVA: 0x002D9100 File Offset: 0x002D7300
			public static MotionBlur.Settings AFJJPFIOEJD()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 579f,
					sampleCount = -8,
					frameBlending = 1400f
				};
			}

			// Token: 0x060083ED RID: 33773 RVA: 0x002D9134 File Offset: 0x002D7334
			public static MotionBlur.Settings OIPFKIPOECC()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 6f,
					sampleCount = -35,
					frameBlending = 710f
				};
			}

			// Token: 0x060083EE RID: 33774 RVA: 0x002D9168 File Offset: 0x002D7368
			public static MotionBlur.Settings CCADIDPNEKH()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 39f,
					sampleCount = -48,
					frameBlending = 1230f
				};
			}

			// Token: 0x060083EF RID: 33775 RVA: 0x002D919C File Offset: 0x002D739C
			public static MotionBlur.Settings FIPCIMGELME()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 1315f,
					sampleCount = 56,
					frameBlending = 1337f
				};
			}

			// Token: 0x060083F0 RID: 33776 RVA: 0x002D91D0 File Offset: 0x002D73D0
			public static MotionBlur.Settings MNKGFGNDKED()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 1906f,
					sampleCount = -17,
					frameBlending = 927f
				};
			}

			// Token: 0x060083F1 RID: 33777 RVA: 0x002D9204 File Offset: 0x002D7404
			public static MotionBlur.Settings IAKAIGHJJJK()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 1162f,
					sampleCount = -28,
					frameBlending = 91f
				};
			}

			// Token: 0x060083F2 RID: 33778 RVA: 0x002D9238 File Offset: 0x002D7438
			public static MotionBlur.Settings OLPCIKIBBKE()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 1162f,
					sampleCount = 27,
					frameBlending = 802f
				};
			}

			// Token: 0x060083F3 RID: 33779 RVA: 0x002D926C File Offset: 0x002D746C
			public static MotionBlur.Settings BKEJIPPCPDO()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 978f,
					sampleCount = 88,
					frameBlending = 1777f
				};
			}

			// Token: 0x060083F4 RID: 33780 RVA: 0x002D92A0 File Offset: 0x002D74A0
			public static MotionBlur.Settings EBMPPAMNFNK()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 1471f,
					sampleCount = -10,
					frameBlending = 1911f
				};
			}

			// Token: 0x060083F5 RID: 33781 RVA: 0x002D92D4 File Offset: 0x002D74D4
			public static MotionBlur.Settings BFBOLLFFMLN()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 1488f,
					sampleCount = 117,
					frameBlending = 876f
				};
			}

			// Token: 0x060083F6 RID: 33782 RVA: 0x002D9308 File Offset: 0x002D7508
			public static MotionBlur.Settings FCBIDJLDABO()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 467f,
					sampleCount = 17,
					frameBlending = 1818f
				};
			}

			// Token: 0x060083F7 RID: 33783 RVA: 0x002D933C File Offset: 0x002D753C
			public static MotionBlur.Settings DBDJKKLMCGG()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 763f,
					sampleCount = -9,
					frameBlending = 600f
				};
			}

			// Token: 0x1700018F RID: 399
			// (get) Token: 0x060083F8 RID: 33784 RVA: 0x002D9370 File Offset: 0x002D7570
			public static MotionBlur.Settings defaultSettings
			{
				get
				{
					return new MotionBlur.Settings
					{
						shutterAngle = 270f,
						sampleCount = 10,
						frameBlending = 0f
					};
				}
			}

			// Token: 0x060083F9 RID: 33785 RVA: 0x002D93A4 File Offset: 0x002D75A4
			public static MotionBlur.Settings PKJMMJJFJAE()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 352f,
					sampleCount = -73,
					frameBlending = 1184f
				};
			}

			// Token: 0x060083FA RID: 33786 RVA: 0x002D93D8 File Offset: 0x002D75D8
			public static MotionBlur.Settings KBINDKOODMK()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 685f,
					sampleCount = 49,
					frameBlending = 1310f
				};
			}

			// Token: 0x060083FB RID: 33787 RVA: 0x002D940C File Offset: 0x002D760C
			public static MotionBlur.Settings INDEHPGLEGK()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 1524f,
					sampleCount = -65,
					frameBlending = 712f
				};
			}

			// Token: 0x060083FC RID: 33788 RVA: 0x002D9440 File Offset: 0x002D7640
			public static MotionBlur.Settings LIDMIPKCHOI()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 463f,
					sampleCount = -92,
					frameBlending = 1057f
				};
			}

			// Token: 0x060083FD RID: 33789 RVA: 0x002D9474 File Offset: 0x002D7674
			public static MotionBlur.Settings LBIOOILOAAD()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 1099f,
					sampleCount = -58,
					frameBlending = 532f
				};
			}

			// Token: 0x060083FE RID: 33790 RVA: 0x002D94A8 File Offset: 0x002D76A8
			public static MotionBlur.Settings EDMABHKFEEO()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 159f,
					sampleCount = -112,
					frameBlending = 127f
				};
			}

			// Token: 0x060083FF RID: 33791 RVA: 0x002D94DC File Offset: 0x002D76DC
			public static MotionBlur.Settings JCLADKAMOLD()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 818f,
					sampleCount = 100,
					frameBlending = 1423f
				};
			}

			// Token: 0x06008400 RID: 33792 RVA: 0x002D9510 File Offset: 0x002D7710
			public static MotionBlur.Settings NIPPCMNKCMB()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 1366f,
					sampleCount = 24,
					frameBlending = 1104f
				};
			}

			// Token: 0x06008401 RID: 33793 RVA: 0x002D9544 File Offset: 0x002D7744
			public static MotionBlur.Settings IOJDDHLHPLH()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 904f,
					sampleCount = 78,
					frameBlending = 1320f
				};
			}

			// Token: 0x06008402 RID: 33794 RVA: 0x002D9578 File Offset: 0x002D7778
			public static MotionBlur.Settings GOKMCEIBFIM()
			{
				return new MotionBlur.Settings
				{
					shutterAngle = 1336f,
					sampleCount = 119,
					frameBlending = 1211f
				};
			}

			// Token: 0x04000EFC RID: 3836
			[SerializeField]
			[Tooltip("The angle of rotary shutter. Larger values give longer exposure.")]
			[Range(0f, 360f)]
			public float shutterAngle;

			// Token: 0x04000EFD RID: 3837
			[Tooltip("The amount of sample points, which affects quality and performance.")]
			[SerializeField]
			public int sampleCount;

			// Token: 0x04000EFE RID: 3838
			[Tooltip("The strength of multiple frame blending")]
			[Range(0f, 1f)]
			[SerializeField]
			public float frameBlending;
		}
	}
}
