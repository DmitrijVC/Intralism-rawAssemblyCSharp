using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001F2 RID: 498
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Occlusion")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class ScreenSpaceAmbientOcclusion : MonoBehaviour
	{
		// Token: 0x060080B5 RID: 32949 RVA: 0x002B8290 File Offset: 0x002B6490
		private void EFJDNLGNACH()
		{
			if (!SystemInfo.supportsImageEffects || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.JNFFFGIJIOO = true;
				base.enabled = false;
				return;
			}
			this.MEKBMDMEAOB();
			if (!this.BAIGKAOLHEI || this.BAIGKAOLHEI.passCount != 1)
			{
				this.JNFFFGIJIOO = false;
				base.enabled = true;
				return;
			}
			this.JNFFFGIJIOO = true;
		}

		// Token: 0x060080B6 RID: 32950 RVA: 0x002B82FE File Offset: 0x002B64FE
		private void LIEGJOHINGC()
		{
			ScreenSpaceAmbientOcclusion.CDLDGAPONMN(this.BAIGKAOLHEI);
		}

		// Token: 0x060080B7 RID: 32951 RVA: 0x002B830C File Offset: 0x002B650C
		private void IIKGIPIIPBG()
		{
			if (!this.BAIGKAOLHEI && this.m_SSAOShader.isSupported)
			{
				this.BAIGKAOLHEI = ScreenSpaceAmbientOcclusion.FNAFFHMMOHH(this.m_SSAOShader);
				this.BAIGKAOLHEI.SetTexture("CameraFilterPack/Edge_Sobel", this.m_RandomTexture);
			}
		}

		// Token: 0x060080B8 RID: 32952 RVA: 0x002B8360 File Offset: 0x002B6560
		private void GKEOGDGMAED()
		{
			if (!this.BAIGKAOLHEI && this.m_SSAOShader.isSupported)
			{
				this.BAIGKAOLHEI = ScreenSpaceAmbientOcclusion.MKLCGLNFOOL(this.m_SSAOShader);
				this.BAIGKAOLHEI.SetTexture("speed", this.m_RandomTexture);
			}
		}

		// Token: 0x060080B9 RID: 32953 RVA: 0x002B83B4 File Offset: 0x002B65B4
		private void EAHCLIEEJOG()
		{
			ScreenSpaceAmbientOcclusion.IJMJAHMIDOA(this.BAIGKAOLHEI);
		}

		// Token: 0x060080BA RID: 32954 RVA: 0x002B83C4 File Offset: 0x002B65C4
		private static Material KMDDMNHDJPE(Shader IPHBIIBPKDG)
		{
			if (!IPHBIIBPKDG)
			{
				return null;
			}
			return new Material(IPHBIIBPKDG)
			{
				hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild)
			};
		}

		// Token: 0x060080BB RID: 32955 RVA: 0x002B83F0 File Offset: 0x002B65F0
		private void NCNPAKFAFOE()
		{
			if (!SystemInfo.supportsImageEffects || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.JNFFFGIJIOO = true;
				base.enabled = true;
				return;
			}
			this.IIKGIPIIPBG();
			if (!this.BAIGKAOLHEI || this.BAIGKAOLHEI.passCount != 7)
			{
				this.JNFFFGIJIOO = true;
				base.enabled = false;
				return;
			}
			this.JNFFFGIJIOO = true;
		}

		// Token: 0x060080BC RID: 32956 RVA: 0x002B8460 File Offset: 0x002B6660
		private static Material MOKEIJGLJOF(Shader IPHBIIBPKDG)
		{
			if (!IPHBIIBPKDG)
			{
				return null;
			}
			return new Material(IPHBIIBPKDG)
			{
				hideFlags = HideFlags.HideAndDontSave
			};
		}

		// Token: 0x060080BD RID: 32957 RVA: 0x002B848C File Offset: 0x002B668C
		private void MKIMDFLBFOM()
		{
			if (!SystemInfo.supportsImageEffects || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.JNFFFGIJIOO = false;
				base.enabled = true;
				return;
			}
			this.FOJPJPJHKDL();
			if (!this.BAIGKAOLHEI || this.BAIGKAOLHEI.passCount != 6)
			{
				this.JNFFFGIJIOO = false;
				base.enabled = false;
				return;
			}
			this.JNFFFGIJIOO = true;
		}

		// Token: 0x060080BE RID: 32958 RVA: 0x002B84FA File Offset: 0x002B66FA
		private void LBPHCAMMAPB()
		{
			ScreenSpaceAmbientOcclusion.HDJPDMCBELD(this.BAIGKAOLHEI);
		}

		// Token: 0x060080BF RID: 32959 RVA: 0x002B8507 File Offset: 0x002B6707
		private void MBNMADBPDLL()
		{
			base.GetComponent<Camera>().depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals | DepthTextureMode.MotionVectors);
		}

		// Token: 0x060080C0 RID: 32960 RVA: 0x002B851C File Offset: 0x002B671C
		private void HGFCJINNEBJ()
		{
			if (!this.BAIGKAOLHEI && this.m_SSAOShader.isSupported)
			{
				this.BAIGKAOLHEI = ScreenSpaceAmbientOcclusion.JDNJABFLIHA(this.m_SSAOShader);
				this.BAIGKAOLHEI.SetTexture("_Value2", this.m_RandomTexture);
			}
		}

		// Token: 0x060080C1 RID: 32961 RVA: 0x002B8570 File Offset: 0x002B6770
		private void JCCIKBBEMEB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.JNFFFGIJIOO || !this.m_SSAOShader.isSupported)
			{
				base.enabled = false;
				return;
			}
			this.EGJDJNNAEDB();
			this.m_Downsampling = Mathf.Clamp(this.m_Downsampling, 0, 8);
			this.m_Radius = Mathf.Clamp(this.m_Radius, 1105f, 910f);
			this.m_MinZ = Mathf.Clamp(this.m_MinZ, 204f, 759f);
			this.m_OcclusionIntensity = Mathf.Clamp(this.m_OcclusionIntensity, 1709f, 1308f);
			this.m_OcclusionAttenuation = Mathf.Clamp(this.m_OcclusionAttenuation, 1402f, 1974f);
			this.m_Blur = Mathf.Clamp(this.m_Blur, 0, 6);
			RenderTexture renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width / this.m_Downsampling, HLBKCLPNHEB.height / this.m_Downsampling, 0);
			float fieldOfView = base.GetComponent<Camera>().fieldOfView;
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * 1924f * 1786f) * farClipPlane;
			float x = num * base.GetComponent<Camera>().aspect;
			this.BAIGKAOLHEI.SetVector("_Radius", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if (this.m_RandomTexture)
			{
				num2 = this.m_RandomTexture.width;
				num3 = this.m_RandomTexture.height;
			}
			else
			{
				num2 = 1;
				num3 = 0;
			}
			this.BAIGKAOLHEI.SetVector("#task", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 509f));
			this.BAIGKAOLHEI.SetVector("_FixDistance", new Vector4(this.m_Radius, this.m_MinZ, 1880f / this.m_OcclusionAttenuation, this.m_OcclusionIntensity));
			bool flag = this.m_Blur > 0;
			Graphics.Blit((!flag) ? HLBKCLPNHEB : null, renderTexture, this.BAIGKAOLHEI, (int)this.m_SampleCount);
			if (flag)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.BAIGKAOLHEI.SetVector("Server: {0}. Region: {1} ", new Vector4((float)this.m_Blur / (float)HLBKCLPNHEB.width, 433f, 1969f, 426f));
				this.BAIGKAOLHEI.SetTexture("english", renderTexture);
				Graphics.Blit(null, temporary, this.BAIGKAOLHEI, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.BAIGKAOLHEI.SetVector("w", new Vector4(10f, (float)this.m_Blur / (float)HLBKCLPNHEB.height, 1557f, 894f));
				this.BAIGKAOLHEI.SetTexture("config.txt", temporary);
				Graphics.Blit(HLBKCLPNHEB, temporary2, this.BAIGKAOLHEI, 3);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			this.BAIGKAOLHEI.SetTexture("_MainTex2", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BAIGKAOLHEI, 2);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x060080C2 RID: 32962 RVA: 0x002B8888 File Offset: 0x002B6A88
		private void FJNCHGLIEMA()
		{
			if (!SystemInfo.supportsImageEffects || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.JNFFFGIJIOO = true;
				base.enabled = false;
				return;
			}
			this.EGJDJNNAEDB();
			if (!this.BAIGKAOLHEI || this.BAIGKAOLHEI.passCount != 7)
			{
				this.JNFFFGIJIOO = false;
				base.enabled = false;
				return;
			}
			this.JNFFFGIJIOO = false;
		}

		// Token: 0x060080C3 RID: 32963 RVA: 0x002B88F6 File Offset: 0x002B6AF6
		private void OnEnable()
		{
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.DepthNormals;
		}

		// Token: 0x060080C4 RID: 32964 RVA: 0x002B890C File Offset: 0x002B6B0C
		private static Material KFGBPANFDOF(Shader IPHBIIBPKDG)
		{
			if (!IPHBIIBPKDG)
			{
				return null;
			}
			return new Material(IPHBIIBPKDG)
			{
				hideFlags = (HideFlags)97
			};
		}

		// Token: 0x060080C5 RID: 32965 RVA: 0x002B8936 File Offset: 0x002B6B36
		private static void FENDFLFNANJ(Material HCACMMMJBKL)
		{
			if (HCACMMMJBKL)
			{
				UnityEngine.Object.DestroyImmediate(HCACMMMJBKL);
				HCACMMMJBKL = null;
			}
		}

		// Token: 0x060080C6 RID: 32966 RVA: 0x002B894C File Offset: 0x002B6B4C
		private void HNADGLKNADJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.JNFFFGIJIOO || !this.m_SSAOShader.isSupported)
			{
				base.enabled = true;
				return;
			}
			this.DCFKOKPCAOE();
			this.m_Downsampling = Mathf.Clamp(this.m_Downsampling, 0, 1);
			this.m_Radius = Mathf.Clamp(this.m_Radius, 645f, 1908f);
			this.m_MinZ = Mathf.Clamp(this.m_MinZ, 1842f, 1434f);
			this.m_OcclusionIntensity = Mathf.Clamp(this.m_OcclusionIntensity, 954f, 522f);
			this.m_OcclusionAttenuation = Mathf.Clamp(this.m_OcclusionAttenuation, 872f, 1443f);
			this.m_Blur = Mathf.Clamp(this.m_Blur, 1, 1);
			RenderTexture renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width / this.m_Downsampling, HLBKCLPNHEB.height / this.m_Downsampling, 1);
			float fieldOfView = base.GetComponent<Camera>().fieldOfView;
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * 1337f * 876f) * farClipPlane;
			float x = num * base.GetComponent<Camera>().aspect;
			this.BAIGKAOLHEI.SetVector("JoinOrCreateRoom failed. A roomname is required. If you don't know one, how will you join?", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if (this.m_RandomTexture)
			{
				num2 = this.m_RandomTexture.width;
				num3 = this.m_RandomTexture.height;
			}
			else
			{
				num2 = 0;
				num3 = 0;
			}
			this.BAIGKAOLHEI.SetVector("SetSatelliteRotationSpeed", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 1531f));
			this.BAIGKAOLHEI.SetVector("Arc", new Vector4(this.m_Radius, this.m_MinZ, 804f / this.m_OcclusionAttenuation, this.m_OcclusionIntensity));
			bool flag = this.m_Blur > 1;
			Graphics.Blit((!flag) ? HLBKCLPNHEB : null, renderTexture, this.BAIGKAOLHEI, (int)this.m_SampleCount);
			if (flag)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.BAIGKAOLHEI.SetVector("_TimeX", new Vector4((float)this.m_Blur / (float)HLBKCLPNHEB.width, 734f, 1707f, 1388f));
				this.BAIGKAOLHEI.SetTexture("inventory.selected.", renderTexture);
				Graphics.Blit(null, temporary, this.BAIGKAOLHEI, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.BAIGKAOLHEI.SetVector("Illegal view ID:", new Vector4(1606f, (float)this.m_Blur / (float)HLBKCLPNHEB.height, 1300f, 1875f));
				this.BAIGKAOLHEI.SetTexture("_Offsets", temporary);
				Graphics.Blit(HLBKCLPNHEB, temporary2, this.BAIGKAOLHEI, 4);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			this.BAIGKAOLHEI.SetTexture("ns", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BAIGKAOLHEI, 2);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x060080C7 RID: 32967 RVA: 0x002B8C64 File Offset: 0x002B6E64
		private void EGJDJNNAEDB()
		{
			if (!this.BAIGKAOLHEI && this.m_SSAOShader.isSupported)
			{
				this.BAIGKAOLHEI = ScreenSpaceAmbientOcclusion.FNAFFHMMOHH(this.m_SSAOShader);
				this.BAIGKAOLHEI.SetTexture("Texture3", this.m_RandomTexture);
			}
		}

		// Token: 0x060080C8 RID: 32968 RVA: 0x002B8CB8 File Offset: 0x002B6EB8
		private void BADIEIOFPIE()
		{
			if (!this.BAIGKAOLHEI && this.m_SSAOShader.isSupported)
			{
				this.BAIGKAOLHEI = ScreenSpaceAmbientOcclusion.MCJGAIDDBGO(this.m_SSAOShader);
				this.BAIGKAOLHEI.SetTexture("1 Kb", this.m_RandomTexture);
			}
		}

		// Token: 0x060080C9 RID: 32969 RVA: 0x002B8D0C File Offset: 0x002B6F0C
		private void NBHMOIGDDAD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.JNFFFGIJIOO || !this.m_SSAOShader.isSupported)
			{
				base.enabled = false;
				return;
			}
			this.GKEOGDGMAED();
			this.m_Downsampling = Mathf.Clamp(this.m_Downsampling, 0, 6);
			this.m_Radius = Mathf.Clamp(this.m_Radius, 914f, 1019f);
			this.m_MinZ = Mathf.Clamp(this.m_MinZ, 1564f, 178f);
			this.m_OcclusionIntensity = Mathf.Clamp(this.m_OcclusionIntensity, 811f, 1590f);
			this.m_OcclusionAttenuation = Mathf.Clamp(this.m_OcclusionAttenuation, 79f, 979f);
			this.m_Blur = Mathf.Clamp(this.m_Blur, 0, 8);
			RenderTexture renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width / this.m_Downsampling, HLBKCLPNHEB.height / this.m_Downsampling, 1);
			float fieldOfView = base.GetComponent<Camera>().fieldOfView;
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * 847f * 22f) * farClipPlane;
			float x = num * base.GetComponent<Camera>().aspect;
			this.BAIGKAOLHEI.SetVector("[LevelEditorScene] Item creation successful! Published Item ID: ", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if (this.m_RandomTexture)
			{
				num2 = this.m_RandomTexture.width;
				num3 = this.m_RandomTexture.height;
			}
			else
			{
				num2 = 1;
				num3 = 0;
			}
			this.BAIGKAOLHEI.SetVector("EventMenu", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 436f));
			this.BAIGKAOLHEI.SetVector("settings_bindings_sec_", new Vector4(this.m_Radius, this.m_MinZ, 338f / this.m_OcclusionAttenuation, this.m_OcclusionIntensity));
			bool flag = this.m_Blur > 1;
			Graphics.Blit((!flag) ? HLBKCLPNHEB : null, renderTexture, this.BAIGKAOLHEI, (int)this.m_SampleCount);
			if (flag)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.BAIGKAOLHEI.SetVector("GlassesColor2", new Vector4((float)this.m_Blur / (float)HLBKCLPNHEB.width, 1685f, 1523f, 576f));
				this.BAIGKAOLHEI.SetTexture("_Value3", renderTexture);
				Graphics.Blit(null, temporary, this.BAIGKAOLHEI, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.BAIGKAOLHEI.SetVector("event", new Vector4(202f, (float)this.m_Blur / (float)HLBKCLPNHEB.height, 1937f, 1603f));
				this.BAIGKAOLHEI.SetTexture("2", temporary);
				Graphics.Blit(HLBKCLPNHEB, temporary2, this.BAIGKAOLHEI, 8);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			this.BAIGKAOLHEI.SetTexture("SupportLogger ", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BAIGKAOLHEI, 6);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x060080CA RID: 32970 RVA: 0x002B9024 File Offset: 0x002B7224
		private void BGBGJFACHLD()
		{
			if (!this.BAIGKAOLHEI && this.m_SSAOShader.isSupported)
			{
				this.BAIGKAOLHEI = ScreenSpaceAmbientOcclusion.MKLCGLNFOOL(this.m_SSAOShader);
				this.BAIGKAOLHEI.SetTexture("BitsData", this.m_RandomTexture);
			}
		}

		// Token: 0x060080CB RID: 32971 RVA: 0x002B9078 File Offset: 0x002B7278
		private void MEKBMDMEAOB()
		{
			if (!this.BAIGKAOLHEI && this.m_SSAOShader.isSupported)
			{
				this.BAIGKAOLHEI = ScreenSpaceAmbientOcclusion.KMDDMNHDJPE(this.m_SSAOShader);
				this.BAIGKAOLHEI.SetTexture("CameraFilterPack/Gradients_FireGradient", this.m_RandomTexture);
			}
		}

		// Token: 0x060080CC RID: 32972 RVA: 0x002B90CC File Offset: 0x002B72CC
		private void OCCGJMPAJIK()
		{
			ScreenSpaceAmbientOcclusion.MHMJFKJPMIE(this.BAIGKAOLHEI);
		}

		// Token: 0x060080CD RID: 32973 RVA: 0x002B90DC File Offset: 0x002B72DC
		private void ILCFPCIPENO()
		{
			if (!SystemInfo.supportsImageEffects || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.JNFFFGIJIOO = true;
				base.enabled = false;
				return;
			}
			this.MEKBMDMEAOB();
			if (!this.BAIGKAOLHEI || this.BAIGKAOLHEI.passCount != 8)
			{
				this.JNFFFGIJIOO = true;
				base.enabled = false;
				return;
			}
			this.JNFFFGIJIOO = false;
		}

		// Token: 0x060080CE RID: 32974 RVA: 0x002B914C File Offset: 0x002B734C
		private void CKHAFEAJMED()
		{
			if (!this.BAIGKAOLHEI && this.m_SSAOShader.isSupported)
			{
				this.BAIGKAOLHEI = ScreenSpaceAmbientOcclusion.KFGBPANFDOF(this.m_SSAOShader);
				this.BAIGKAOLHEI.SetTexture("CameraFilterPack/RainFX", this.m_RandomTexture);
			}
		}

		// Token: 0x060080CF RID: 32975 RVA: 0x002B8936 File Offset: 0x002B6B36
		private static void NOMIPEDOEJJ(Material HCACMMMJBKL)
		{
			if (HCACMMMJBKL)
			{
				UnityEngine.Object.DestroyImmediate(HCACMMMJBKL);
				HCACMMMJBKL = null;
			}
		}

		// Token: 0x060080D0 RID: 32976 RVA: 0x002B91A0 File Offset: 0x002B73A0
		private void NOOFNIDLCMI()
		{
			if (!this.BAIGKAOLHEI && this.m_SSAOShader.isSupported)
			{
				this.BAIGKAOLHEI = ScreenSpaceAmbientOcclusion.FNAFFHMMOHH(this.m_SSAOShader);
				this.BAIGKAOLHEI.SetTexture(": ", this.m_RandomTexture);
			}
		}

		// Token: 0x060080D1 RID: 32977 RVA: 0x002B91F4 File Offset: 0x002B73F4
		private void GAOOPEEBGJA()
		{
			ScreenSpaceAmbientOcclusion.JNDMGEKMEEG(this.BAIGKAOLHEI);
		}

		// Token: 0x060080D2 RID: 32978 RVA: 0x002B9204 File Offset: 0x002B7404
		private void MHGGJOAHGLL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.JNFFFGIJIOO || !this.m_SSAOShader.isSupported)
			{
				base.enabled = true;
				return;
			}
			this.LFFJOMMFAHJ();
			this.m_Downsampling = Mathf.Clamp(this.m_Downsampling, 0, 5);
			this.m_Radius = Mathf.Clamp(this.m_Radius, 1684f, 1145f);
			this.m_MinZ = Mathf.Clamp(this.m_MinZ, 1081f, 1442f);
			this.m_OcclusionIntensity = Mathf.Clamp(this.m_OcclusionIntensity, 1860f, 613f);
			this.m_OcclusionAttenuation = Mathf.Clamp(this.m_OcclusionAttenuation, 1299f, 513f);
			this.m_Blur = Mathf.Clamp(this.m_Blur, 1, 4);
			RenderTexture renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width / this.m_Downsampling, HLBKCLPNHEB.height / this.m_Downsampling, 0);
			float fieldOfView = base.GetComponent<Camera>().fieldOfView;
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * 442f * 1059f) * farClipPlane;
			float x = num * base.GetComponent<Camera>().aspect;
			this.BAIGKAOLHEI.SetVector("_TimeX", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if (this.m_RandomTexture)
			{
				num2 = this.m_RandomTexture.width;
				num3 = this.m_RandomTexture.height;
			}
			else
			{
				num2 = 0;
				num3 = 1;
			}
			this.BAIGKAOLHEI.SetVector("Value", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 1101f));
			this.BAIGKAOLHEI.SetVector("RecieveChatMessage", new Vector4(this.m_Radius, this.m_MinZ, 1175f / this.m_OcclusionAttenuation, this.m_OcclusionIntensity));
			bool flag = this.m_Blur > 1;
			Graphics.Blit((!flag) ? HLBKCLPNHEB : null, renderTexture, this.BAIGKAOLHEI, (int)this.m_SampleCount);
			if (flag)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.BAIGKAOLHEI.SetVector("AvatarImage", new Vector4((float)this.m_Blur / (float)HLBKCLPNHEB.width, 162f, 1954f, 89f));
				this.BAIGKAOLHEI.SetTexture("Delete events", renderTexture);
				Graphics.Blit(null, temporary, this.BAIGKAOLHEI, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.BAIGKAOLHEI.SetVector("_History3Weight", new Vector4(258f, (float)this.m_Blur / (float)HLBKCLPNHEB.height, 746f, 1711f));
				this.BAIGKAOLHEI.SetTexture("[Right]", temporary);
				Graphics.Blit(HLBKCLPNHEB, temporary2, this.BAIGKAOLHEI, 6);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			this.BAIGKAOLHEI.SetTexture("_TimeX", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BAIGKAOLHEI, 2);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x060080D3 RID: 32979 RVA: 0x002B951C File Offset: 0x002B771C
		private void JPOOAJCAJJF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.JNFFFGIJIOO || !this.m_SSAOShader.isSupported)
			{
				base.enabled = false;
				return;
			}
			this.FOJPJPJHKDL();
			this.m_Downsampling = Mathf.Clamp(this.m_Downsampling, 0, 6);
			this.m_Radius = Mathf.Clamp(this.m_Radius, 1030f, 91f);
			this.m_MinZ = Mathf.Clamp(this.m_MinZ, 568f, 372f);
			this.m_OcclusionIntensity = Mathf.Clamp(this.m_OcclusionIntensity, 419f, 1633f);
			this.m_OcclusionAttenuation = Mathf.Clamp(this.m_OcclusionAttenuation, 813f, 1160f);
			this.m_Blur = Mathf.Clamp(this.m_Blur, 0, 1);
			RenderTexture renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width / this.m_Downsampling, HLBKCLPNHEB.height / this.m_Downsampling, 1);
			float fieldOfView = base.GetComponent<Camera>().fieldOfView;
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * 612f * 1161f) * farClipPlane;
			float x = num * base.GetComponent<Camera>().aspect;
			this.BAIGKAOLHEI.SetVector("/../", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if (this.m_RandomTexture)
			{
				num2 = this.m_RandomTexture.width;
				num3 = this.m_RandomTexture.height;
			}
			else
			{
				num2 = 0;
				num3 = 0;
			}
			this.BAIGKAOLHEI.SetVector("JoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 1082f));
			this.BAIGKAOLHEI.SetVector("_Blur", new Vector4(this.m_Radius, this.m_MinZ, 1074f / this.m_OcclusionAttenuation, this.m_OcclusionIntensity));
			bool flag = this.m_Blur > 0;
			Graphics.Blit((!flag) ? HLBKCLPNHEB : null, renderTexture, this.BAIGKAOLHEI, (int)this.m_SampleCount);
			if (flag)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.BAIGKAOLHEI.SetVector("_ScreenResolution", new Vector4((float)this.m_Blur / (float)HLBKCLPNHEB.width, 1298f, 1075f, 1708f));
				this.BAIGKAOLHEI.SetTexture("_TimeX", renderTexture);
				Graphics.Blit(null, temporary, this.BAIGKAOLHEI, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.BAIGKAOLHEI.SetVector("powerup.0", new Vector4(1073f, (float)this.m_Blur / (float)HLBKCLPNHEB.height, 1308f, 1804f));
				this.BAIGKAOLHEI.SetTexture("ns.exitgames.com", temporary);
				Graphics.Blit(HLBKCLPNHEB, temporary2, this.BAIGKAOLHEI, 2);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			this.BAIGKAOLHEI.SetTexture("_ScreenResolution", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BAIGKAOLHEI, 5);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x060080D4 RID: 32980 RVA: 0x002B9834 File Offset: 0x002B7A34
		private void MMOKKAPFGAK()
		{
			if (!SystemInfo.supportsImageEffects || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.JNFFFGIJIOO = true;
				base.enabled = false;
				return;
			}
			this.BADIEIOFPIE();
			if (!this.BAIGKAOLHEI || this.BAIGKAOLHEI.passCount != 5)
			{
				this.JNFFFGIJIOO = true;
				base.enabled = false;
				return;
			}
			this.JNFFFGIJIOO = false;
		}

		// Token: 0x060080D5 RID: 32981 RVA: 0x002B98A4 File Offset: 0x002B7AA4
		private void DPMMIPDKJND(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.JNFFFGIJIOO || !this.m_SSAOShader.isSupported)
			{
				base.enabled = false;
				return;
			}
			this.BIHPAIPGAEF();
			this.m_Downsampling = Mathf.Clamp(this.m_Downsampling, 0, 5);
			this.m_Radius = Mathf.Clamp(this.m_Radius, 1820f, 1065f);
			this.m_MinZ = Mathf.Clamp(this.m_MinZ, 1779f, 623f);
			this.m_OcclusionIntensity = Mathf.Clamp(this.m_OcclusionIntensity, 1208f, 453f);
			this.m_OcclusionAttenuation = Mathf.Clamp(this.m_OcclusionAttenuation, 1722f, 286f);
			this.m_Blur = Mathf.Clamp(this.m_Blur, 1, 8);
			RenderTexture renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width / this.m_Downsampling, HLBKCLPNHEB.height / this.m_Downsampling, 0);
			float fieldOfView = base.GetComponent<Camera>().fieldOfView;
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * 425f * 1818f) * farClipPlane;
			float x = num * base.GetComponent<Camera>().aspect;
			this.BAIGKAOLHEI.SetVector("[NetworkManager] Found ", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if (this.m_RandomTexture)
			{
				num2 = this.m_RandomTexture.width;
				num3 = this.m_RandomTexture.height;
			}
			else
			{
				num2 = 1;
				num3 = 0;
			}
			this.BAIGKAOLHEI.SetVector("OnRenderImage in Helper called ...", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 1796f));
			this.BAIGKAOLHEI.SetVector("Editor/", new Vector4(this.m_Radius, this.m_MinZ, 1448f / this.m_OcclusionAttenuation, this.m_OcclusionIntensity));
			bool flag = this.m_Blur > 0;
			Graphics.Blit((!flag) ? HLBKCLPNHEB : null, renderTexture, this.BAIGKAOLHEI, (int)this.m_SampleCount);
			if (flag)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.BAIGKAOLHEI.SetVector("R:", new Vector4((float)this.m_Blur / (float)HLBKCLPNHEB.width, 1848f, 982f, 8f));
				this.BAIGKAOLHEI.SetTexture("_TimeX", renderTexture);
				Graphics.Blit(null, temporary, this.BAIGKAOLHEI, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.BAIGKAOLHEI.SetVector("No Camera attached!", new Vector4(1353f, (float)this.m_Blur / (float)HLBKCLPNHEB.height, 1421f, 712f));
				this.BAIGKAOLHEI.SetTexture("CameraFilterPack_3D_Myst1", temporary);
				Graphics.Blit(HLBKCLPNHEB, temporary2, this.BAIGKAOLHEI, 8);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			this.BAIGKAOLHEI.SetTexture("ShineEffect", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BAIGKAOLHEI, 5);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x060080D6 RID: 32982 RVA: 0x002B9BBC File Offset: 0x002B7DBC
		private void LFFJOMMFAHJ()
		{
			if (!this.BAIGKAOLHEI && this.m_SSAOShader.isSupported)
			{
				this.BAIGKAOLHEI = ScreenSpaceAmbientOcclusion.MCJGAIDDBGO(this.m_SSAOShader);
				this.BAIGKAOLHEI.SetTexture("_Visualize", this.m_RandomTexture);
			}
		}

		// Token: 0x060080D7 RID: 32983 RVA: 0x002B88F6 File Offset: 0x002B6AF6
		private void FLHBCHLMOFK()
		{
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.DepthNormals;
		}

		// Token: 0x060080D8 RID: 32984 RVA: 0x002B8936 File Offset: 0x002B6B36
		private static void IJMJAHMIDOA(Material HCACMMMJBKL)
		{
			if (HCACMMMJBKL)
			{
				UnityEngine.Object.DestroyImmediate(HCACMMMJBKL);
				HCACMMMJBKL = null;
			}
		}

		// Token: 0x060080D9 RID: 32985 RVA: 0x002B9C10 File Offset: 0x002B7E10
		private void LADCJEIALMH()
		{
			ScreenSpaceAmbientOcclusion.FOMOEKHMBMI(this.BAIGKAOLHEI);
		}

		// Token: 0x060080DA RID: 32986 RVA: 0x002B9C20 File Offset: 0x002B7E20
		private static Material JDNJABFLIHA(Shader IPHBIIBPKDG)
		{
			if (!IPHBIIBPKDG)
			{
				return null;
			}
			return new Material(IPHBIIBPKDG)
			{
				hideFlags = (HideFlags)95
			};
		}

		// Token: 0x060080DB RID: 32987 RVA: 0x002B8936 File Offset: 0x002B6B36
		private static void HDJPDMCBELD(Material HCACMMMJBKL)
		{
			if (HCACMMMJBKL)
			{
				UnityEngine.Object.DestroyImmediate(HCACMMMJBKL);
				HCACMMMJBKL = null;
			}
		}

		// Token: 0x060080DC RID: 32988 RVA: 0x002B9C4C File Offset: 0x002B7E4C
		private void NFPCLHOGCDB()
		{
			if (!this.BAIGKAOLHEI && this.m_SSAOShader.isSupported)
			{
				this.BAIGKAOLHEI = ScreenSpaceAmbientOcclusion.MOKEIJGLJOF(this.m_SSAOShader);
				this.BAIGKAOLHEI.SetTexture("_RandomTexture", this.m_RandomTexture);
			}
		}

		// Token: 0x060080DD RID: 32989 RVA: 0x002B9CA0 File Offset: 0x002B7EA0
		private void OnDisable()
		{
			ScreenSpaceAmbientOcclusion.NOMIPEDOEJJ(this.BAIGKAOLHEI);
		}

		// Token: 0x060080DE RID: 32990 RVA: 0x002B9CB0 File Offset: 0x002B7EB0
		private void PJKAGNNNFGK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.JNFFFGIJIOO || !this.m_SSAOShader.isSupported)
			{
				base.enabled = true;
				return;
			}
			this.LFFJOMMFAHJ();
			this.m_Downsampling = Mathf.Clamp(this.m_Downsampling, 0, 4);
			this.m_Radius = Mathf.Clamp(this.m_Radius, 1820f, 1283f);
			this.m_MinZ = Mathf.Clamp(this.m_MinZ, 1880f, 398f);
			this.m_OcclusionIntensity = Mathf.Clamp(this.m_OcclusionIntensity, 353f, 1752f);
			this.m_OcclusionAttenuation = Mathf.Clamp(this.m_OcclusionAttenuation, 822f, 342f);
			this.m_Blur = Mathf.Clamp(this.m_Blur, 1, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width / this.m_Downsampling, HLBKCLPNHEB.height / this.m_Downsampling, 1);
			float fieldOfView = base.GetComponent<Camera>().fieldOfView;
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * 778f * 269f) * farClipPlane;
			float x = num * base.GetComponent<Camera>().aspect;
			this.BAIGKAOLHEI.SetVector("_TimeX", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if (this.m_RandomTexture)
			{
				num2 = this.m_RandomTexture.width;
				num3 = this.m_RandomTexture.height;
			}
			else
			{
				num2 = 0;
				num3 = 0;
			}
			this.BAIGKAOLHEI.SetVector("RPC: 'OnAwakeRPC' PhotonView: ", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 544f));
			this.BAIGKAOLHEI.SetVector("_ZCurve", new Vector4(this.m_Radius, this.m_MinZ, 229f / this.m_OcclusionAttenuation, this.m_OcclusionIntensity));
			bool flag = this.m_Blur > 1;
			Graphics.Blit((!flag) ? HLBKCLPNHEB : null, renderTexture, this.BAIGKAOLHEI, (int)this.m_SampleCount);
			if (flag)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.BAIGKAOLHEI.SetVector("settings_bindings_controller_type", new Vector4((float)this.m_Blur / (float)HLBKCLPNHEB.width, 1809f, 491f, 1586f));
				this.BAIGKAOLHEI.SetTexture("menu.enableselectormusic", renderTexture);
				Graphics.Blit(null, temporary, this.BAIGKAOLHEI, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.BAIGKAOLHEI.SetVector("_BlurVector", new Vector4(160f, (float)this.m_Blur / (float)HLBKCLPNHEB.height, 504f, 1645f));
				this.BAIGKAOLHEI.SetTexture(".", temporary);
				Graphics.Blit(HLBKCLPNHEB, temporary2, this.BAIGKAOLHEI, 6);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			this.BAIGKAOLHEI.SetTexture("https://store.steampowered.com/itemstore/513510/", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BAIGKAOLHEI, 7);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x060080DF RID: 32991 RVA: 0x002B9FC8 File Offset: 0x002B81C8
		private void DBEMDAJDDDA()
		{
			if (!SystemInfo.supportsImageEffects || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.JNFFFGIJIOO = false;
				base.enabled = false;
				return;
			}
			this.BADIEIOFPIE();
			if (!this.BAIGKAOLHEI || this.BAIGKAOLHEI.passCount != 3)
			{
				this.JNFFFGIJIOO = false;
				base.enabled = false;
				return;
			}
			this.JNFFFGIJIOO = false;
		}

		// Token: 0x060080E0 RID: 32992 RVA: 0x002B8507 File Offset: 0x002B6707
		private void JHBPINEKDPE()
		{
			base.GetComponent<Camera>().depthTextureMode |= (DepthTextureMode.Depth | DepthTextureMode.DepthNormals | DepthTextureMode.MotionVectors);
		}

		// Token: 0x060080E1 RID: 32993 RVA: 0x002BA038 File Offset: 0x002B8238
		private void COIJKMKIEAK()
		{
			if (!SystemInfo.supportsImageEffects || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.JNFFFGIJIOO = false;
				base.enabled = false;
				return;
			}
			this.BGBGJFACHLD();
			if (!this.BAIGKAOLHEI || this.BAIGKAOLHEI.passCount != 1)
			{
				this.JNFFFGIJIOO = false;
				base.enabled = true;
				return;
			}
			this.JNFFFGIJIOO = true;
		}

		// Token: 0x060080E2 RID: 32994 RVA: 0x002BA0A6 File Offset: 0x002B82A6
		private void GBFPAEDPOPP()
		{
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.MotionVectors;
		}

		// Token: 0x060080E3 RID: 32995 RVA: 0x002B88F6 File Offset: 0x002B6AF6
		private void ENDDDMALLBK()
		{
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.DepthNormals;
		}

		// Token: 0x060080E4 RID: 32996 RVA: 0x002BA0BC File Offset: 0x002B82BC
		private void GHILGJJEAOF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.JNFFFGIJIOO || !this.m_SSAOShader.isSupported)
			{
				base.enabled = true;
				return;
			}
			this.NFPCLHOGCDB();
			this.m_Downsampling = Mathf.Clamp(this.m_Downsampling, 0, 1);
			this.m_Radius = Mathf.Clamp(this.m_Radius, 1327f, 349f);
			this.m_MinZ = Mathf.Clamp(this.m_MinZ, 59f, 1430f);
			this.m_OcclusionIntensity = Mathf.Clamp(this.m_OcclusionIntensity, 1424f, 1412f);
			this.m_OcclusionAttenuation = Mathf.Clamp(this.m_OcclusionAttenuation, 1499f, 637f);
			this.m_Blur = Mathf.Clamp(this.m_Blur, 1, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width / this.m_Downsampling, HLBKCLPNHEB.height / this.m_Downsampling, 1);
			float fieldOfView = base.GetComponent<Camera>().fieldOfView;
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * 3f * 496f) * farClipPlane;
			float x = num * base.GetComponent<Camera>().aspect;
			this.BAIGKAOLHEI.SetVector("SetParticlesGravity", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if (this.m_RandomTexture)
			{
				num2 = this.m_RandomTexture.width;
				num3 = this.m_RandomTexture.height;
			}
			else
			{
				num2 = 0;
				num3 = 1;
			}
			this.BAIGKAOLHEI.SetVector("/", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 230f));
			this.BAIGKAOLHEI.SetVector("RecieveChatActionMessage", new Vector4(this.m_Radius, this.m_MinZ, 157f / this.m_OcclusionAttenuation, this.m_OcclusionIntensity));
			bool flag = this.m_Blur > 0;
			Graphics.Blit((!flag) ? HLBKCLPNHEB : null, renderTexture, this.BAIGKAOLHEI, (int)this.m_SampleCount);
			if (flag)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.BAIGKAOLHEI.SetVector("The given 2D texture ", new Vector4((float)this.m_Blur / (float)HLBKCLPNHEB.width, 1391f, 330f, 497f));
				this.BAIGKAOLHEI.SetTexture("settings.volume.menu", renderTexture);
				Graphics.Blit(null, temporary, this.BAIGKAOLHEI, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.BAIGKAOLHEI.SetVector("_LayerThickness", new Vector4(106f, (float)this.m_Blur / (float)HLBKCLPNHEB.height, 1799f, 926f));
				this.BAIGKAOLHEI.SetTexture("_Value3", temporary);
				Graphics.Blit(HLBKCLPNHEB, temporary2, this.BAIGKAOLHEI, 2);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			this.BAIGKAOLHEI.SetTexture("ns", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BAIGKAOLHEI, 8);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x060080E5 RID: 32997 RVA: 0x002B82FE File Offset: 0x002B64FE
		private void DHENLPJJOEN()
		{
			ScreenSpaceAmbientOcclusion.CDLDGAPONMN(this.BAIGKAOLHEI);
		}

		// Token: 0x060080E6 RID: 32998 RVA: 0x002BA3D4 File Offset: 0x002B85D4
		private static Material MCJGAIDDBGO(Shader IPHBIIBPKDG)
		{
			if (!IPHBIIBPKDG)
			{
				return null;
			}
			return new Material(IPHBIIBPKDG)
			{
				hideFlags = HideFlags.HideInHierarchy
			};
		}

		// Token: 0x060080E7 RID: 32999 RVA: 0x002BA3FE File Offset: 0x002B85FE
		private void HGJKBDGABKM()
		{
			base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
		}

		// Token: 0x060080E8 RID: 33000 RVA: 0x002B84FA File Offset: 0x002B66FA
		private void GKNKIIEALCH()
		{
			ScreenSpaceAmbientOcclusion.HDJPDMCBELD(this.BAIGKAOLHEI);
		}

		// Token: 0x060080E9 RID: 33001 RVA: 0x002B8936 File Offset: 0x002B6B36
		private static void MANNLJFLBAM(Material HCACMMMJBKL)
		{
			if (HCACMMMJBKL)
			{
				UnityEngine.Object.DestroyImmediate(HCACMMMJBKL);
				HCACMMMJBKL = null;
			}
		}

		// Token: 0x060080EA RID: 33002 RVA: 0x002BA414 File Offset: 0x002B8614
		private void DCFKOKPCAOE()
		{
			if (!this.BAIGKAOLHEI && this.m_SSAOShader.isSupported)
			{
				this.BAIGKAOLHEI = ScreenSpaceAmbientOcclusion.KMDDMNHDJPE(this.m_SSAOShader);
				this.BAIGKAOLHEI.SetTexture("uploads/Intralism/mods_terms.pdf", this.m_RandomTexture);
			}
		}

		// Token: 0x060080EB RID: 33003 RVA: 0x002BA468 File Offset: 0x002B8668
		private static Material FNAFFHMMOHH(Shader IPHBIIBPKDG)
		{
			if (!IPHBIIBPKDG)
			{
				return null;
			}
			return new Material(IPHBIIBPKDG)
			{
				hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable)
			};
		}

		// Token: 0x060080EC RID: 33004 RVA: 0x002B8936 File Offset: 0x002B6B36
		private static void FOMOEKHMBMI(Material HCACMMMJBKL)
		{
			if (HCACMMMJBKL)
			{
				UnityEngine.Object.DestroyImmediate(HCACMMMJBKL);
				HCACMMMJBKL = null;
			}
		}

		// Token: 0x060080ED RID: 33005 RVA: 0x002B8936 File Offset: 0x002B6B36
		private static void CDLDGAPONMN(Material HCACMMMJBKL)
		{
			if (HCACMMMJBKL)
			{
				UnityEngine.Object.DestroyImmediate(HCACMMMJBKL);
				HCACMMMJBKL = null;
			}
		}

		// Token: 0x060080EE RID: 33006 RVA: 0x002BA494 File Offset: 0x002B8694
		private void Start()
		{
			if (!SystemInfo.supportsImageEffects || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.JNFFFGIJIOO = false;
				base.enabled = false;
				return;
			}
			this.NFPCLHOGCDB();
			if (!this.BAIGKAOLHEI || this.BAIGKAOLHEI.passCount != 5)
			{
				this.JNFFFGIJIOO = false;
				base.enabled = false;
				return;
			}
			this.JNFFFGIJIOO = true;
		}

		// Token: 0x060080EF RID: 33007 RVA: 0x002BA504 File Offset: 0x002B8704
		private void CACIIEMMMHG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.JNFFFGIJIOO || !this.m_SSAOShader.isSupported)
			{
				base.enabled = true;
				return;
			}
			this.EGJDJNNAEDB();
			this.m_Downsampling = Mathf.Clamp(this.m_Downsampling, 0, 6);
			this.m_Radius = Mathf.Clamp(this.m_Radius, 514f, 290f);
			this.m_MinZ = Mathf.Clamp(this.m_MinZ, 599f, 1900f);
			this.m_OcclusionIntensity = Mathf.Clamp(this.m_OcclusionIntensity, 225f, 972f);
			this.m_OcclusionAttenuation = Mathf.Clamp(this.m_OcclusionAttenuation, 1029f, 1769f);
			this.m_Blur = Mathf.Clamp(this.m_Blur, 1, 8);
			RenderTexture renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width / this.m_Downsampling, HLBKCLPNHEB.height / this.m_Downsampling, 1);
			float fieldOfView = base.GetComponent<Camera>().fieldOfView;
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * 252f * 1784f) * farClipPlane;
			float x = num * base.GetComponent<Camera>().aspect;
			this.BAIGKAOLHEI.SetVector("stretchWidth", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if (this.m_RandomTexture)
			{
				num2 = this.m_RandomTexture.width;
				num3 = this.m_RandomTexture.height;
			}
			else
			{
				num2 = 1;
				num3 = 1;
			}
			this.BAIGKAOLHEI.SetVector("_TimeX", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 1167f));
			this.BAIGKAOLHEI.SetVector("In Maps Editor", new Vector4(this.m_Radius, this.m_MinZ, 1421f / this.m_OcclusionAttenuation, this.m_OcclusionIntensity));
			bool flag = this.m_Blur > 1;
			Graphics.Blit((!flag) ? HLBKCLPNHEB : null, renderTexture, this.BAIGKAOLHEI, (int)this.m_SampleCount);
			if (flag)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.BAIGKAOLHEI.SetVector("Malformed RPC; this should never occur. Content: ", new Vector4((float)this.m_Blur / (float)HLBKCLPNHEB.width, 332f, 33f, 790f));
				this.BAIGKAOLHEI.SetTexture("[DiscordController] Join ({0})", renderTexture);
				Graphics.Blit(null, temporary, this.BAIGKAOLHEI, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.BAIGKAOLHEI.SetVector("Paste events", new Vector4(1039f, (float)this.m_Blur / (float)HLBKCLPNHEB.height, 719f, 1105f));
				this.BAIGKAOLHEI.SetTexture("_Light2", temporary);
				Graphics.Blit(HLBKCLPNHEB, temporary2, this.BAIGKAOLHEI, 7);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			this.BAIGKAOLHEI.SetTexture("BitsData", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BAIGKAOLHEI, 4);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x060080F0 RID: 33008 RVA: 0x002BA81C File Offset: 0x002B8A1C
		private void FHPFJBFCOOF()
		{
			if (!SystemInfo.supportsImageEffects || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.JNFFFGIJIOO = true;
				base.enabled = false;
				return;
			}
			this.DCFKOKPCAOE();
			if (!this.BAIGKAOLHEI || this.BAIGKAOLHEI.passCount != 6)
			{
				this.JNFFFGIJIOO = false;
				base.enabled = true;
				return;
			}
			this.JNFFFGIJIOO = false;
		}

		// Token: 0x060080F1 RID: 33009 RVA: 0x002BA88C File Offset: 0x002B8A8C
		private void BGDPIHMAACO()
		{
			if (!SystemInfo.supportsImageEffects || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				this.JNFFFGIJIOO = true;
				base.enabled = false;
				return;
			}
			this.GKEOGDGMAED();
			if (!this.BAIGKAOLHEI || this.BAIGKAOLHEI.passCount != 6)
			{
				this.JNFFFGIJIOO = false;
				base.enabled = false;
				return;
			}
			this.JNFFFGIJIOO = false;
		}

		// Token: 0x060080F2 RID: 33010 RVA: 0x002BA8FC File Offset: 0x002B8AFC
		private static Material MKLCGLNFOOL(Shader IPHBIIBPKDG)
		{
			if (!IPHBIIBPKDG)
			{
				return null;
			}
			return new Material(IPHBIIBPKDG)
			{
				hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild)
			};
		}

		// Token: 0x060080F3 RID: 33011 RVA: 0x002B9CA0 File Offset: 0x002B7EA0
		private void EDBEHEKMGFH()
		{
			ScreenSpaceAmbientOcclusion.NOMIPEDOEJJ(this.BAIGKAOLHEI);
		}

		// Token: 0x060080F4 RID: 33012 RVA: 0x002BA928 File Offset: 0x002B8B28
		private void OOIDNDLOLPM()
		{
			if (!this.BAIGKAOLHEI && this.m_SSAOShader.isSupported)
			{
				this.BAIGKAOLHEI = ScreenSpaceAmbientOcclusion.JDNJABFLIHA(this.m_SSAOShader);
				this.BAIGKAOLHEI.SetTexture(".played", this.m_RandomTexture);
			}
		}

		// Token: 0x060080F5 RID: 33013 RVA: 0x002BA97C File Offset: 0x002B8B7C
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.JNFFFGIJIOO || !this.m_SSAOShader.isSupported)
			{
				base.enabled = false;
				return;
			}
			this.NFPCLHOGCDB();
			this.m_Downsampling = Mathf.Clamp(this.m_Downsampling, 1, 6);
			this.m_Radius = Mathf.Clamp(this.m_Radius, 0.05f, 1f);
			this.m_MinZ = Mathf.Clamp(this.m_MinZ, 1E-05f, 0.5f);
			this.m_OcclusionIntensity = Mathf.Clamp(this.m_OcclusionIntensity, 0.5f, 4f);
			this.m_OcclusionAttenuation = Mathf.Clamp(this.m_OcclusionAttenuation, 0.2f, 2f);
			this.m_Blur = Mathf.Clamp(this.m_Blur, 0, 4);
			RenderTexture renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width / this.m_Downsampling, HLBKCLPNHEB.height / this.m_Downsampling, 0);
			float fieldOfView = base.GetComponent<Camera>().fieldOfView;
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * 0.0174532924f * 0.5f) * farClipPlane;
			float x = num * base.GetComponent<Camera>().aspect;
			this.BAIGKAOLHEI.SetVector("_FarCorner", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if (this.m_RandomTexture)
			{
				num2 = this.m_RandomTexture.width;
				num3 = this.m_RandomTexture.height;
			}
			else
			{
				num2 = 1;
				num3 = 1;
			}
			this.BAIGKAOLHEI.SetVector("_NoiseScale", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 0f));
			this.BAIGKAOLHEI.SetVector("_Params", new Vector4(this.m_Radius, this.m_MinZ, 1f / this.m_OcclusionAttenuation, this.m_OcclusionIntensity));
			bool flag = this.m_Blur > 0;
			Graphics.Blit((!flag) ? HLBKCLPNHEB : null, renderTexture, this.BAIGKAOLHEI, (int)this.m_SampleCount);
			if (flag)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.BAIGKAOLHEI.SetVector("_TexelOffsetScale", new Vector4((float)this.m_Blur / (float)HLBKCLPNHEB.width, 0f, 0f, 0f));
				this.BAIGKAOLHEI.SetTexture("_SSAO", renderTexture);
				Graphics.Blit(null, temporary, this.BAIGKAOLHEI, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.BAIGKAOLHEI.SetVector("_TexelOffsetScale", new Vector4(0f, (float)this.m_Blur / (float)HLBKCLPNHEB.height, 0f, 0f));
				this.BAIGKAOLHEI.SetTexture("_SSAO", temporary);
				Graphics.Blit(HLBKCLPNHEB, temporary2, this.BAIGKAOLHEI, 3);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			this.BAIGKAOLHEI.SetTexture("_SSAO", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BAIGKAOLHEI, 4);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x060080F7 RID: 33015 RVA: 0x002B83B4 File Offset: 0x002B65B4
		private void BJOHDLNDFAD()
		{
			ScreenSpaceAmbientOcclusion.IJMJAHMIDOA(this.BAIGKAOLHEI);
		}

		// Token: 0x060080F8 RID: 33016 RVA: 0x002BACE8 File Offset: 0x002B8EE8
		private void NOEAGHKPPKD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.JNFFFGIJIOO || !this.m_SSAOShader.isSupported)
			{
				base.enabled = true;
				return;
			}
			this.OOIDNDLOLPM();
			this.m_Downsampling = Mathf.Clamp(this.m_Downsampling, 1, 0);
			this.m_Radius = Mathf.Clamp(this.m_Radius, 93f, 1022f);
			this.m_MinZ = Mathf.Clamp(this.m_MinZ, 1638f, 712f);
			this.m_OcclusionIntensity = Mathf.Clamp(this.m_OcclusionIntensity, 328f, 566f);
			this.m_OcclusionAttenuation = Mathf.Clamp(this.m_OcclusionAttenuation, 1047f, 1174f);
			this.m_Blur = Mathf.Clamp(this.m_Blur, 1, 5);
			RenderTexture renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width / this.m_Downsampling, HLBKCLPNHEB.height / this.m_Downsampling, 1);
			float fieldOfView = base.GetComponent<Camera>().fieldOfView;
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * 1235f * 701f) * farClipPlane;
			float x = num * base.GetComponent<Camera>().aspect;
			this.BAIGKAOLHEI.SetVector(" scene view IDs from last level.", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if (this.m_RandomTexture)
			{
				num2 = this.m_RandomTexture.width;
				num3 = this.m_RandomTexture.height;
			}
			else
			{
				num2 = 0;
				num3 = 1;
			}
			this.BAIGKAOLHEI.SetVector("(singleton) ", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 1259f));
			this.BAIGKAOLHEI.SetVector("bad", new Vector4(this.m_Radius, this.m_MinZ, 914f / this.m_OcclusionAttenuation, this.m_OcclusionIntensity));
			bool flag = this.m_Blur > 1;
			Graphics.Blit((!flag) ? HLBKCLPNHEB : null, renderTexture, this.BAIGKAOLHEI, (int)this.m_SampleCount);
			if (flag)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0);
				this.BAIGKAOLHEI.SetVector("Preparing content", new Vector4((float)this.m_Blur / (float)HLBKCLPNHEB.width, 340f, 1680f, 1097f));
				this.BAIGKAOLHEI.SetTexture("ready", renderTexture);
				Graphics.Blit(null, temporary, this.BAIGKAOLHEI, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.BAIGKAOLHEI.SetVector("_ScreenResolution", new Vector4(1830f, (float)this.m_Blur / (float)HLBKCLPNHEB.height, 1276f, 1775f));
				this.BAIGKAOLHEI.SetTexture("88f00bdf0ad61b16b803971ebe071962", temporary);
				Graphics.Blit(HLBKCLPNHEB, temporary2, this.BAIGKAOLHEI, 7);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			this.BAIGKAOLHEI.SetTexture("ControllerLeftX", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BAIGKAOLHEI, 6);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x060080F9 RID: 33017 RVA: 0x002BB000 File Offset: 0x002B9200
		private void HDEKADONMPE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.JNFFFGIJIOO || !this.m_SSAOShader.isSupported)
			{
				base.enabled = false;
				return;
			}
			this.OOIDNDLOLPM();
			this.m_Downsampling = Mathf.Clamp(this.m_Downsampling, 0, 0);
			this.m_Radius = Mathf.Clamp(this.m_Radius, 552f, 1945f);
			this.m_MinZ = Mathf.Clamp(this.m_MinZ, 1794f, 1963f);
			this.m_OcclusionIntensity = Mathf.Clamp(this.m_OcclusionIntensity, 796f, 1602f);
			this.m_OcclusionAttenuation = Mathf.Clamp(this.m_OcclusionAttenuation, 1768f, 1825f);
			this.m_Blur = Mathf.Clamp(this.m_Blur, 1, 0);
			RenderTexture renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width / this.m_Downsampling, HLBKCLPNHEB.height / this.m_Downsampling, 1);
			float fieldOfView = base.GetComponent<Camera>().fieldOfView;
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * 1156f * 1888f) * farClipPlane;
			float x = num * base.GetComponent<Camera>().aspect;
			this.BAIGKAOLHEI.SetVector("/", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if (this.m_RandomTexture)
			{
				num2 = this.m_RandomTexture.width;
				num3 = this.m_RandomTexture.height;
			}
			else
			{
				num2 = 1;
				num3 = 1;
			}
			this.BAIGKAOLHEI.SetVector("_SSRMultiplier", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 1783f));
			this.BAIGKAOLHEI.SetVector("Vignette", new Vector4(this.m_Radius, this.m_MinZ, 88f / this.m_OcclusionAttenuation, this.m_OcclusionIntensity));
			bool flag = this.m_Blur > 0;
			Graphics.Blit((!flag) ? HLBKCLPNHEB : null, renderTexture, this.BAIGKAOLHEI, (int)this.m_SampleCount);
			if (flag)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.BAIGKAOLHEI.SetVector("_DiffuseColor", new Vector4((float)this.m_Blur / (float)HLBKCLPNHEB.width, 1037f, 1338f, 1602f));
				this.BAIGKAOLHEI.SetTexture("_Green_R", renderTexture);
				Graphics.Blit(null, temporary, this.BAIGKAOLHEI, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.BAIGKAOLHEI.SetVector("(\\[ */ *quote *\\])", new Vector4(1075f, (float)this.m_Blur / (float)HLBKCLPNHEB.height, 1633f, 277f));
				this.BAIGKAOLHEI.SetTexture(" with prefix ", temporary);
				Graphics.Blit(HLBKCLPNHEB, temporary2, this.BAIGKAOLHEI, 0);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			this.BAIGKAOLHEI.SetTexture("_TapLowBackground", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BAIGKAOLHEI, 2);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x060080FA RID: 33018 RVA: 0x002B8936 File Offset: 0x002B6B36
		private static void EFPHMMJHENH(Material HCACMMMJBKL)
		{
			if (HCACMMMJBKL)
			{
				UnityEngine.Object.DestroyImmediate(HCACMMMJBKL);
				HCACMMMJBKL = null;
			}
		}

		// Token: 0x060080FB RID: 33019 RVA: 0x002BB318 File Offset: 0x002B9518
		private void BIHPAIPGAEF()
		{
			if (!this.BAIGKAOLHEI && this.m_SSAOShader.isSupported)
			{
				this.BAIGKAOLHEI = ScreenSpaceAmbientOcclusion.FNAFFHMMOHH(this.m_SSAOShader);
				this.BAIGKAOLHEI.SetTexture("menu.tabid", this.m_RandomTexture);
			}
		}

		// Token: 0x060080FC RID: 33020 RVA: 0x002BB36C File Offset: 0x002B956C
		private void EPEGAEGDJAM()
		{
			if (!SystemInfo.supportsImageEffects || !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGB32))
			{
				this.JNFFFGIJIOO = true;
				base.enabled = true;
				return;
			}
			this.BIHPAIPGAEF();
			if (!this.BAIGKAOLHEI || this.BAIGKAOLHEI.passCount != 1)
			{
				this.JNFFFGIJIOO = false;
				base.enabled = true;
				return;
			}
			this.JNFFFGIJIOO = false;
		}

		// Token: 0x060080FD RID: 33021 RVA: 0x002B8936 File Offset: 0x002B6B36
		private static void MHMJFKJPMIE(Material HCACMMMJBKL)
		{
			if (HCACMMMJBKL)
			{
				UnityEngine.Object.DestroyImmediate(HCACMMMJBKL);
				HCACMMMJBKL = null;
			}
		}

		// Token: 0x060080FE RID: 33022 RVA: 0x002B8936 File Offset: 0x002B6B36
		private static void JNDMGEKMEEG(Material HCACMMMJBKL)
		{
			if (HCACMMMJBKL)
			{
				UnityEngine.Object.DestroyImmediate(HCACMMMJBKL);
				HCACMMMJBKL = null;
			}
		}

		// Token: 0x060080FF RID: 33023 RVA: 0x002B9CA0 File Offset: 0x002B7EA0
		private void CPAJLKHMOJB()
		{
			ScreenSpaceAmbientOcclusion.NOMIPEDOEJJ(this.BAIGKAOLHEI);
		}

		// Token: 0x06008100 RID: 33024 RVA: 0x002BB3DC File Offset: 0x002B95DC
		private void AMKFLDKCIJO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.JNFFFGIJIOO || !this.m_SSAOShader.isSupported)
			{
				base.enabled = false;
				return;
			}
			this.IIKGIPIIPBG();
			this.m_Downsampling = Mathf.Clamp(this.m_Downsampling, 1, 0);
			this.m_Radius = Mathf.Clamp(this.m_Radius, 712f, 1417f);
			this.m_MinZ = Mathf.Clamp(this.m_MinZ, 1091f, 671f);
			this.m_OcclusionIntensity = Mathf.Clamp(this.m_OcclusionIntensity, 316f, 800f);
			this.m_OcclusionAttenuation = Mathf.Clamp(this.m_OcclusionAttenuation, 326f, 954f);
			this.m_Blur = Mathf.Clamp(this.m_Blur, 0, 8);
			RenderTexture renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width / this.m_Downsampling, HLBKCLPNHEB.height / this.m_Downsampling, 1);
			float fieldOfView = base.GetComponent<Camera>().fieldOfView;
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * 1999f * 1099f) * farClipPlane;
			float x = num * base.GetComponent<Camera>().aspect;
			this.BAIGKAOLHEI.SetVector("[LevelEditorScene] Exported to ", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if (this.m_RandomTexture)
			{
				num2 = this.m_RandomTexture.width;
				num3 = this.m_RandomTexture.height;
			}
			else
			{
				num2 = 1;
				num3 = 0;
			}
			this.BAIGKAOLHEI.SetVector("_HardBlend", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 39f));
			this.BAIGKAOLHEI.SetVector("Uploading preview image", new Vector4(this.m_Radius, this.m_MinZ, 844f / this.m_OcclusionAttenuation, this.m_OcclusionIntensity));
			bool flag = this.m_Blur > 1;
			Graphics.Blit((!flag) ? HLBKCLPNHEB : null, renderTexture, this.BAIGKAOLHEI, (int)this.m_SampleCount);
			if (flag)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.BAIGKAOLHEI.SetVector("steamid", new Vector4((float)this.m_Blur / (float)HLBKCLPNHEB.width, 1374f, 1923f, 507f));
				this.BAIGKAOLHEI.SetTexture(" registered.", renderTexture);
				Graphics.Blit(null, temporary, this.BAIGKAOLHEI, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.BAIGKAOLHEI.SetVector(": ", new Vector4(754f, (float)this.m_Blur / (float)HLBKCLPNHEB.height, 1555f, 1528f));
				this.BAIGKAOLHEI.SetTexture("/files/mods_terms.pdf", temporary);
				Graphics.Blit(HLBKCLPNHEB, temporary2, this.BAIGKAOLHEI, 5);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			this.BAIGKAOLHEI.SetTexture("Found best region: '", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BAIGKAOLHEI, 8);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06008101 RID: 33025 RVA: 0x002BB6F4 File Offset: 0x002B98F4
		private void FOJPJPJHKDL()
		{
			if (!this.BAIGKAOLHEI && this.m_SSAOShader.isSupported)
			{
				this.BAIGKAOLHEI = ScreenSpaceAmbientOcclusion.FNAFFHMMOHH(this.m_SSAOShader);
				this.BAIGKAOLHEI.SetTexture("_Distortion", this.m_RandomTexture);
			}
		}

		// Token: 0x06008102 RID: 33026 RVA: 0x002BB748 File Offset: 0x002B9948
		private void LDIOANOMHMO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.JNFFFGIJIOO || !this.m_SSAOShader.isSupported)
			{
				base.enabled = false;
				return;
			}
			this.LFFJOMMFAHJ();
			this.m_Downsampling = Mathf.Clamp(this.m_Downsampling, 1, 6);
			this.m_Radius = Mathf.Clamp(this.m_Radius, 454f, 1327f);
			this.m_MinZ = Mathf.Clamp(this.m_MinZ, 1147f, 568f);
			this.m_OcclusionIntensity = Mathf.Clamp(this.m_OcclusionIntensity, 1267f, 33f);
			this.m_OcclusionAttenuation = Mathf.Clamp(this.m_OcclusionAttenuation, 1141f, 1656f);
			this.m_Blur = Mathf.Clamp(this.m_Blur, 0, 7);
			RenderTexture renderTexture = RenderTexture.GetTemporary(HLBKCLPNHEB.width / this.m_Downsampling, HLBKCLPNHEB.height / this.m_Downsampling, 0);
			float fieldOfView = base.GetComponent<Camera>().fieldOfView;
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			float num = Mathf.Tan(fieldOfView * 876f * 1389f) * farClipPlane;
			float x = num * base.GetComponent<Camera>().aspect;
			this.BAIGKAOLHEI.SetVector("ShineEffect", new Vector3(x, num, farClipPlane));
			int num2;
			int num3;
			if (this.m_RandomTexture)
			{
				num2 = this.m_RandomTexture.width;
				num3 = this.m_RandomTexture.height;
			}
			else
			{
				num2 = 0;
				num3 = 1;
			}
			this.BAIGKAOLHEI.SetVector("SpawnObj", new Vector3((float)renderTexture.width / (float)num2, (float)renderTexture.height / (float)num3, 39f));
			this.BAIGKAOLHEI.SetVector("ExitButton", new Vector4(this.m_Radius, this.m_MinZ, 72f / this.m_OcclusionAttenuation, this.m_OcclusionIntensity));
			bool flag = this.m_Blur > 1;
			Graphics.Blit((!flag) ? HLBKCLPNHEB : null, renderTexture, this.BAIGKAOLHEI, (int)this.m_SampleCount);
			if (flag)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.BAIGKAOLHEI.SetVector("[NetworkManager] Connecting...", new Vector4((float)this.m_Blur / (float)HLBKCLPNHEB.width, 1598f, 1885f, 1114f));
				this.BAIGKAOLHEI.SetTexture("player.licenceaccepted", renderTexture);
				Graphics.Blit(null, temporary, this.BAIGKAOLHEI, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1);
				this.BAIGKAOLHEI.SetVector("SetSatelliteEmission", new Vector4(1193f, (float)this.m_Blur / (float)HLBKCLPNHEB.height, 1445f, 1212f));
				this.BAIGKAOLHEI.SetTexture("Set satellite color", temporary);
				Graphics.Blit(HLBKCLPNHEB, temporary2, this.BAIGKAOLHEI, 4);
				RenderTexture.ReleaseTemporary(temporary);
				renderTexture = temporary2;
			}
			this.BAIGKAOLHEI.SetTexture("\"", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.BAIGKAOLHEI, 1);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x04000E60 RID: 3680
		[Range(0.05f, 1f)]
		public float m_Radius = 0.4f;

		// Token: 0x04000E61 RID: 3681
		public ScreenSpaceAmbientOcclusion.SSAOSamples m_SampleCount = ScreenSpaceAmbientOcclusion.SSAOSamples.Medium;

		// Token: 0x04000E62 RID: 3682
		[Range(0.5f, 4f)]
		public float m_OcclusionIntensity = 1.5f;

		// Token: 0x04000E63 RID: 3683
		[Range(0f, 4f)]
		public int m_Blur = 2;

		// Token: 0x04000E64 RID: 3684
		[Range(1f, 6f)]
		public int m_Downsampling = 2;

		// Token: 0x04000E65 RID: 3685
		[Range(0.2f, 2f)]
		public float m_OcclusionAttenuation = 1f;

		// Token: 0x04000E66 RID: 3686
		[Range(1E-05f, 0.5f)]
		public float m_MinZ = 0.01f;

		// Token: 0x04000E67 RID: 3687
		public Shader m_SSAOShader;

		// Token: 0x04000E68 RID: 3688
		private Material BAIGKAOLHEI;

		// Token: 0x04000E69 RID: 3689
		public Texture2D m_RandomTexture;

		// Token: 0x04000E6A RID: 3690
		private bool JNFFFGIJIOO;

		// Token: 0x020001F3 RID: 499
		public enum SSAOSamples
		{
			// Token: 0x04000E6C RID: 3692
			Low,
			// Token: 0x04000E6D RID: 3693
			Medium,
			// Token: 0x04000E6E RID: 3694
			High
		}
	}
}
