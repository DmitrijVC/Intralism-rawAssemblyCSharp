using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001F5 RID: 501
	[AddComponentMenu("Image Effects/Rendering/Sun Shafts")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	public class SunShafts : PostEffectsBase
	{
		// Token: 0x06008128 RID: 33064 RVA: 0x002BBBA8 File Offset: 0x002B9DA8
		private void MDHIALGJMBO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 5;
			if (this.resolution == SunShafts.SunShaftsResolution.Normal)
			{
				num = 3;
			}
			else if (this.resolution == SunShafts.SunShaftsResolution.High)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 866f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1299f, 1584f, 365f);
			}
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.PKJJFEIPAJA.SetVector("[ResourcesManager] Load text error: not found", new Vector4(1941f, 28f, 40f, 1763f) * this.sunShaftBlurRadius);
			this.PKJJFEIPAJA.SetVector("Data", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.PKJJFEIPAJA.SetVector("\n", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = (!base.GetComponent<Camera>().allowHDR) ? RenderTextureFormat.ARGB4444 : ((RenderTextureFormat)97);
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.PKJJFEIPAJA.SetTexture("_FilteredReflections", temporary2);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 6);
			}
			base.HKPAMCABCDI(temporary, this.NOJPCNFDAMC);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 5);
			float num2 = this.sunShaftBlurRadius * 96f;
			this.PKJJFEIPAJA.SetVector("_Radius", new Vector4(num2, num2, 604f, 1570f));
			this.PKJJFEIPAJA.SetVector("finished", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.PKJJFEIPAJA, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1347f + 1057f) * 1320f) / 188f;
				this.PKJJFEIPAJA.SetVector("...", new Vector4(num2, num2, 1199f, 1684f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.PKJJFEIPAJA, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 641f + 1503f) * 817f) / 697f;
				this.PKJJFEIPAJA.SetVector("ShowSprite", new Vector4(num2, num2, 1905f, 942f));
			}
			if (vector.z >= 234f)
			{
				this.PKJJFEIPAJA.SetVector("#FFFFFFFF", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.PKJJFEIPAJA.SetVector("_Value3", Vector4.zero);
			}
			this.PKJJFEIPAJA.SetTexture("_Value4", temporary);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PKJJFEIPAJA, (this.screenBlendMode != SunShafts.ShaftsScreenBlendMode.Screen) ? 5 : 1);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06008129 RID: 33065 RVA: 0x002BBF9C File Offset: 0x002BA19C
		private void EFMOIIPLOOB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 3;
			if (this.resolution == SunShafts.SunShaftsResolution.Low)
			{
				num = 3;
			}
			else if (this.resolution == (SunShafts.SunShaftsResolution)4)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 650f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(505f, 1998f, 1900f);
			}
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.PKJJFEIPAJA.SetVector("CameraFilterPack/Drawing_EnhancedComics", new Vector4(1588f, 950f, 19f, 692f) * this.sunShaftBlurRadius);
			this.PKJJFEIPAJA.SetVector("_TimeX", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.PKJJFEIPAJA.SetVector("CompletedLevel", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = (!base.GetComponent<Camera>().allowHDR) ? RenderTextureFormat.ARGBHalf : ((RenderTextureFormat)(-89));
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.PKJJFEIPAJA.SetTexture("Player Disconnected", temporary2);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 4);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 5);
			}
			base.ONCFIJNADIA(temporary, this.NOJPCNFDAMC);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 5);
			float num2 = this.sunShaftBlurRadius * 41f;
			this.PKJJFEIPAJA.SetVector(" : ", new Vector4(num2, num2, 1908f, 416f));
			this.PKJJFEIPAJA.SetVector("SupportLogger OnFailedToConnectToPhoton(", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1679f + 1129f) * 324f) / 133f;
				this.PKJJFEIPAJA.SetVector(".", new Vector4(num2, num2, 1268f, 588f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 181f + 1509f) * 1189f) / 1491f;
				this.PKJJFEIPAJA.SetVector("SetSunLerpSpeed", new Vector4(num2, num2, 440f, 1700f));
			}
			if (vector.z >= 964f)
			{
				this.PKJJFEIPAJA.SetVector(".", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.PKJJFEIPAJA.SetVector("\" call.", Vector4.zero);
			}
			this.PKJJFEIPAJA.SetTexture(" failed in a server-side plugin. Check the configuration in the Dashboard. Message from server-plugin: ", temporary);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PKJJFEIPAJA, (this.screenBlendMode != SunShafts.ShaftsScreenBlendMode.Screen) ? 6 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600812A RID: 33066 RVA: 0x002BC390 File Offset: 0x002BA590
		private void KBGCKEDIGAH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 8;
			if (this.resolution == SunShafts.SunShaftsResolution.Normal)
			{
				num = 4;
			}
			else if (this.resolution == SunShafts.SunShaftsResolution.Low)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 1501f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(67f, 166f, 151f);
			}
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.PKJJFEIPAJA.SetVector("Done!", new Vector4(1710f, 1635f, 1977f, 1521f) * this.sunShaftBlurRadius);
			this.PKJJFEIPAJA.SetVector("Please attach component to a Graphical UI component", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.PKJJFEIPAJA.SetVector("_Value3", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = (!base.GetComponent<Camera>().allowHDR) ? RenderTextureFormat.RGB565 : ((RenderTextureFormat)(-105));
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.PKJJFEIPAJA.SetTexture("SetParticlesInput", temporary2);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 4);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 3);
			}
			base.BGDJEEOJFFA(temporary, this.NOJPCNFDAMC);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 4);
			float num2 = this.sunShaftBlurRadius * 893f;
			this.PKJJFEIPAJA.SetVector("OK", new Vector4(num2, num2, 258f, 1266f));
			this.PKJJFEIPAJA.SetVector("Fade", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1456f + 1434f) * 1808f) / 577f;
				this.PKJJFEIPAJA.SetVector("Hidden/Image Effects/Cinematic/AmbientOcclusion", new Vector4(num2, num2, 843f, 912f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1126f + 1756f) * 396f) / 381f;
				this.PKJJFEIPAJA.SetVector("null", new Vector4(num2, num2, 314f, 1568f));
			}
			if (vector.z >= 1756f)
			{
				this.PKJJFEIPAJA.SetVector(".lastCheckpoint.currentCombo", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.PKJJFEIPAJA.SetVector("Submition failed", Vector4.zero);
			}
			this.PKJJFEIPAJA.SetTexture("CameraFilterPack/AAA_Super_Hexagon", temporary);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PKJJFEIPAJA, (this.screenBlendMode != SunShafts.ShaftsScreenBlendMode.Screen) ? 3 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600812B RID: 33067 RVA: 0x002BC784 File Offset: 0x002BA984
		private void HELHDLOLPLH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 6;
			if (this.resolution == SunShafts.SunShaftsResolution.Normal)
			{
				num = 3;
			}
			else if (this.resolution == (SunShafts.SunShaftsResolution)3)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 545f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1451f, 1278f, 52f);
			}
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.PKJJFEIPAJA.SetVector("_TimeX", new Vector4(1468f, 154f, 305f, 1919f) * this.sunShaftBlurRadius);
			this.PKJJFEIPAJA.SetVector("_Light", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.PKJJFEIPAJA.SetVector("yes", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = (!base.GetComponent<Camera>().allowHDR) ? RenderTextureFormat.ARGB2101010 : ((RenderTextureFormat)72);
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.PKJJFEIPAJA.SetTexture("offsets", temporary2);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 0);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 4);
			}
			base.LLHBNGOEKGI(temporary, this.NOJPCNFDAMC);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 5);
			float num2 = this.sunShaftBlurRadius * 69f;
			this.PKJJFEIPAJA.SetVector("settings.shaders", new Vector4(num2, num2, 1900f, 878f));
			this.PKJJFEIPAJA.SetVector("finished", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.PKJJFEIPAJA, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1132f + 1599f) * 1136f) / 474f;
				this.PKJJFEIPAJA.SetVector("Changed config", new Vector4(num2, num2, 813f, 125f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1306f + 513f) * 515f) / 1636f;
				this.PKJJFEIPAJA.SetVector("<command>", new Vector4(num2, num2, 1083f, 120f));
			}
			if (vector.z >= 221f)
			{
				this.PKJJFEIPAJA.SetVector("_Overlay", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.PKJJFEIPAJA.SetVector("_TimeX", Vector4.zero);
			}
			this.PKJJFEIPAJA.SetTexture("_BokehParams", temporary);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PKJJFEIPAJA, (this.screenBlendMode != SunShafts.ShaftsScreenBlendMode.Screen) ? 8 : 1);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600812C RID: 33068 RVA: 0x002BCB78 File Offset: 0x002BAD78
		public virtual bool GHHAAPCBJJD()
		{
			base.CKIAMHAKJOK(this.useDepthTexture);
			this.PKJJFEIPAJA = base.EDFIBHNHAAB(this.sunShaftsShader, this.PKJJFEIPAJA);
			this.NOJPCNFDAMC = base.ECNEGNMAMDE(this.simpleClearShader, this.NOJPCNFDAMC);
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600812D RID: 33069 RVA: 0x002BCBDC File Offset: 0x002BADDC
		public virtual bool MPMLKLHMPJH()
		{
			base.LMEBEGFJGEM(this.useDepthTexture);
			this.PKJJFEIPAJA = base.GJKHKCOAFDB(this.sunShaftsShader, this.PKJJFEIPAJA);
			this.NOJPCNFDAMC = base.ECNEGNMAMDE(this.simpleClearShader, this.NOJPCNFDAMC);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600812E RID: 33070 RVA: 0x002BCC40 File Offset: 0x002BAE40
		private void KEFKNAOGCHO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 0;
			if (this.resolution == SunShafts.SunShaftsResolution.Low)
			{
				num = 6;
			}
			else if (this.resolution == (SunShafts.SunShaftsResolution)3)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 450f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1611f, 1899f, 289f);
			}
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.PKJJFEIPAJA.SetVector("#000000", new Vector4(1462f, 1105f, 1211f, 1637f) * this.sunShaftBlurRadius);
			this.PKJJFEIPAJA.SetVector("\" call.", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.PKJJFEIPAJA.SetVector("player.russia", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = (!base.GetComponent<Camera>().allowHDR) ? RenderTextureFormat.RGB565 : ((RenderTextureFormat)(-92));
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.PKJJFEIPAJA.SetTexture("SetSatelliteSensitivity", temporary2);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 0);
			}
			base.CKHBGCGEEDB(temporary, this.NOJPCNFDAMC);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 2);
			float num2 = this.sunShaftBlurRadius * 524f;
			this.PKJJFEIPAJA.SetVector(" has no method \"", new Vector4(num2, num2, 339f, 771f));
			this.PKJJFEIPAJA.SetVector(" is muted", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.PKJJFEIPAJA, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 478f + 1628f) * 295f) / 903f;
				this.PKJJFEIPAJA.SetVector("_ScreenResolution", new Vector4(num2, num2, 741f, 1573f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 908f + 431f) * 1296f) / 961f;
				this.PKJJFEIPAJA.SetVector("Cross", new Vector4(num2, num2, 364f, 218f));
			}
			if (vector.z >= 1372f)
			{
				this.PKJJFEIPAJA.SetVector("_ScreenResolution", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.PKJJFEIPAJA.SetVector("Please specify a map name or buildID", Vector4.zero);
			}
			this.PKJJFEIPAJA.SetTexture("[PlayerController] ", temporary);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PKJJFEIPAJA, (this.screenBlendMode != SunShafts.ShaftsScreenBlendMode.Screen) ? 1 : 1);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600812F RID: 33071 RVA: 0x002BD034 File Offset: 0x002BB234
		private void AIJJOIOAKGD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 8;
			if (this.resolution == SunShafts.SunShaftsResolution.Low)
			{
				num = 0;
			}
			else if (this.resolution == (SunShafts.SunShaftsResolution)6)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 1500f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1889f, 1851f, 1360f);
			}
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.PKJJFEIPAJA.SetVector("MenuScene", new Vector4(1832f, 1677f, 967f, 1545f) * this.sunShaftBlurRadius);
			this.PKJJFEIPAJA.SetVector("_TimeX", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.PKJJFEIPAJA.SetVector("SelectorMapsCountSlider", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = (!base.GetComponent<Camera>().allowHDR) ? RenderTextureFormat.ARGB4444 : ((RenderTextureFormat)33);
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.PKJJFEIPAJA.SetTexture("_ScreenResolution", temporary2);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 0);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 3);
			}
			base.KEKDMLCLCPA(temporary, this.NOJPCNFDAMC);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 1);
			float num2 = this.sunShaftBlurRadius * 1152f;
			this.PKJJFEIPAJA.SetVector(".", new Vector4(num2, num2, 67f, 229f));
			this.PKJJFEIPAJA.SetVector("_TraceBehindObjects", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.PKJJFEIPAJA, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 826f + 874f) * 1469f) / 634f;
				this.PKJJFEIPAJA.SetVector("_PColor2", new Vector4(num2, num2, 1811f, 828f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.PKJJFEIPAJA, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 350f + 606f) * 102f) / 1038f;
				this.PKJJFEIPAJA.SetVector("_TimeX", new Vector4(num2, num2, 1339f, 499f));
			}
			if (vector.z >= 1805f)
			{
				this.PKJJFEIPAJA.SetVector("_TargetScale", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.PKJJFEIPAJA.SetVector("ConnectToRegion() failed. Can only connect while in state 'Disconnected'. Current state: ", Vector4.zero);
			}
			this.PKJJFEIPAJA.SetTexture("y", temporary);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PKJJFEIPAJA, (this.screenBlendMode != SunShafts.ShaftsScreenBlendMode.Screen) ? 8 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06008130 RID: 33072 RVA: 0x002BD428 File Offset: 0x002BB628
		public virtual bool DIAEBALGKAP()
		{
			base.KHNPMDDIJAJ(this.useDepthTexture);
			this.PKJJFEIPAJA = base.AJKPGPKKHHB(this.sunShaftsShader, this.PKJJFEIPAJA);
			this.NOJPCNFDAMC = base.AJKPGPKKHHB(this.simpleClearShader, this.NOJPCNFDAMC);
			if (!this.LMKGCBNNGLI)
			{
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008131 RID: 33073 RVA: 0x002BD48C File Offset: 0x002BB68C
		public override bool CheckResources()
		{
			base.NPOEJIDLJGK(this.useDepthTexture);
			this.PKJJFEIPAJA = base.EDFIBHNHAAB(this.sunShaftsShader, this.PKJJFEIPAJA);
			this.NOJPCNFDAMC = base.EDFIBHNHAAB(this.simpleClearShader, this.NOJPCNFDAMC);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008132 RID: 33074 RVA: 0x002BD4F0 File Offset: 0x002BB6F0
		public virtual bool BKNCNFMHIGH()
		{
			base.CKIAMHAKJOK(this.useDepthTexture);
			this.PKJJFEIPAJA = base.EDFIBHNHAAB(this.sunShaftsShader, this.PKJJFEIPAJA);
			this.NOJPCNFDAMC = base.ECNEGNMAMDE(this.simpleClearShader, this.NOJPCNFDAMC);
			if (!this.LMKGCBNNGLI)
			{
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008133 RID: 33075 RVA: 0x002BD554 File Offset: 0x002BB754
		private void JPOOAJCAJJF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 2;
			if (this.resolution == SunShafts.SunShaftsResolution.Normal)
			{
				num = 1;
			}
			else if (this.resolution == SunShafts.SunShaftsResolution.High)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 345f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1538f, 1334f, 1131f);
			}
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.PKJJFEIPAJA.SetVector(" | Level: ", new Vector4(0f, 1925f, 1287f, 872f) * this.sunShaftBlurRadius);
			this.PKJJFEIPAJA.SetVector("cancel", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.PKJJFEIPAJA.SetVector("id", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = (!base.GetComponent<Camera>().allowHDR) ? RenderTextureFormat.ARGB4444 : ((RenderTextureFormat)(-102));
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.PKJJFEIPAJA.SetTexture("Image_", temporary2);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 4);
			}
			base.KCJLLJOFGDF(temporary, this.NOJPCNFDAMC);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 3);
			float num2 = this.sunShaftBlurRadius * 195f;
			this.PKJJFEIPAJA.SetVector("levelcompleted", new Vector4(num2, num2, 1216f, 1778f));
			this.PKJJFEIPAJA.SetVector("The given 2D texture ", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 655f + 471f) * 607f) / 60f;
				this.PKJJFEIPAJA.SetVector("GlassesColor2", new Vector4(num2, num2, 202f, 712f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.PKJJFEIPAJA, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 59f + 1938f) * 223f) / 220f;
				this.PKJJFEIPAJA.SetVector("MapperNameText", new Vector4(num2, num2, 998f, 1673f));
			}
			if (vector.z >= 1284f)
			{
				this.PKJJFEIPAJA.SetVector(" evLeave: ", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.PKJJFEIPAJA.SetVector("mapselector.orderby", Vector4.zero);
			}
			this.PKJJFEIPAJA.SetTexture(" not exist", temporary);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PKJJFEIPAJA, (this.screenBlendMode != SunShafts.ShaftsScreenBlendMode.Screen) ? 8 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06008134 RID: 33076 RVA: 0x002BD948 File Offset: 0x002BBB48
		public virtual bool BCDIEBGNBEG()
		{
			base.IBFDMKMOBCA(this.useDepthTexture);
			this.PKJJFEIPAJA = base.GJKHKCOAFDB(this.sunShaftsShader, this.PKJJFEIPAJA);
			this.NOJPCNFDAMC = base.NODBMINMALP(this.simpleClearShader, this.NOJPCNFDAMC);
			if (!this.LMKGCBNNGLI)
			{
				base.HKDNNECLBGL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008135 RID: 33077 RVA: 0x002BD9AC File Offset: 0x002BBBAC
		public virtual bool PHEIDFBDELF()
		{
			base.FNIFJAENDIB(this.useDepthTexture);
			this.PKJJFEIPAJA = base.KDHKHOHMKCG(this.sunShaftsShader, this.PKJJFEIPAJA);
			this.NOJPCNFDAMC = base.EDFIBHNHAAB(this.simpleClearShader, this.NOJPCNFDAMC);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008136 RID: 33078 RVA: 0x002BDA10 File Offset: 0x002BBC10
		public virtual bool OBEFMKGPJLI()
		{
			base.NPOEJIDLJGK(this.useDepthTexture);
			this.PKJJFEIPAJA = base.KDHKHOHMKCG(this.sunShaftsShader, this.PKJJFEIPAJA);
			this.NOJPCNFDAMC = base.AJKPGPKKHHB(this.simpleClearShader, this.NOJPCNFDAMC);
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008137 RID: 33079 RVA: 0x002BDA74 File Offset: 0x002BBC74
		private void OGAGBDIAKGB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 1;
			if (this.resolution == SunShafts.SunShaftsResolution.Low)
			{
				num = 0;
			}
			else if (this.resolution == (SunShafts.SunShaftsResolution)5)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 914f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1900f, 1438f, 952f);
			}
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.PKJJFEIPAJA.SetVector("maps.", new Vector4(1062f, 883f, 326f, 159f) * this.sunShaftBlurRadius);
			this.PKJJFEIPAJA.SetVector("checkpoint", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.PKJJFEIPAJA.SetVector(",", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = (!base.GetComponent<Camera>().allowHDR) ? RenderTextureFormat.ARGB1555 : ((RenderTextureFormat)(-111));
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.PKJJFEIPAJA.SetTexture("]", temporary2);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 6);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 7);
			}
			base.HKPAMCABCDI(temporary, this.NOJPCNFDAMC);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 3);
			float num2 = this.sunShaftBlurRadius * 91f;
			this.PKJJFEIPAJA.SetVector("BadgeText", new Vector4(num2, num2, 907f, 1097f));
			this.PKJJFEIPAJA.SetVector("_Exposure", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.PKJJFEIPAJA, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1089f + 1511f) * 1003f) / 1163f;
				this.PKJJFEIPAJA.SetVector("Source Object: ", new Vector4(num2, num2, 999f, 1348f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 517f + 1423f) * 618f) / 1947f;
				this.PKJJFEIPAJA.SetVector(" timeUntilRespawnBasedOnTimeBase:", new Vector4(num2, num2, 97f, 1637f));
			}
			if (vector.z >= 782f)
			{
				this.PKJJFEIPAJA.SetVector("Unable to get a reward! Try again?", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.PKJJFEIPAJA.SetVector("_Value", Vector4.zero);
			}
			this.PKJJFEIPAJA.SetTexture("maps.", temporary);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PKJJFEIPAJA, (this.screenBlendMode != SunShafts.ShaftsScreenBlendMode.Screen) ? 0 : 1);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06008138 RID: 33080 RVA: 0x002BDE68 File Offset: 0x002BC068
		public virtual bool OOBHPBJOKMD()
		{
			base.LMEBEGFJGEM(this.useDepthTexture);
			this.PKJJFEIPAJA = base.NODBMINMALP(this.sunShaftsShader, this.PKJJFEIPAJA);
			this.NOJPCNFDAMC = base.KDHKHOHMKCG(this.simpleClearShader, this.NOJPCNFDAMC);
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008139 RID: 33081 RVA: 0x002BDECC File Offset: 0x002BC0CC
		private void HLAIEDEHIBC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 7;
			if (this.resolution == SunShafts.SunShaftsResolution.Low)
			{
				num = 5;
			}
			else if (this.resolution == (SunShafts.SunShaftsResolution)6)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 1892f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(495f, 1591f, 1327f);
			}
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.PKJJFEIPAJA.SetVector("SetEnvSpriteImage", new Vector4(999f, 1818f, 1925f, 659f) * this.sunShaftBlurRadius);
			this.PKJJFEIPAJA.SetVector("[NetworkManager] Connection failed: ", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.PKJJFEIPAJA.SetVector(" not exist", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = (!base.GetComponent<Camera>().allowHDR) ? RenderTextureFormat.RGB565 : ((RenderTextureFormat)61);
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.PKJJFEIPAJA.SetTexture("_ChangeGreen", temporary2);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 7);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 2);
			}
			base.CKHBGCGEEDB(temporary, this.NOJPCNFDAMC);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 0);
			float num2 = this.sunShaftBlurRadius * 1567f;
			this.PKJJFEIPAJA.SetVector("-", new Vector4(num2, num2, 1553f, 615f));
			this.PKJJFEIPAJA.SetVector("_Value", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.PKJJFEIPAJA, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 863f + 812f) * 1009f) / 1066f;
				this.PKJJFEIPAJA.SetVector("/", new Vector4(num2, num2, 634f, 1366f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 717f + 1275f) * 153f) / 1717f;
				this.PKJJFEIPAJA.SetVector("Anime", new Vector4(num2, num2, 401f, 797f));
			}
			if (vector.z >= 1113f)
			{
				this.PKJJFEIPAJA.SetVector("_Value3", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.PKJJFEIPAJA.SetVector("ws://", Vector4.zero);
			}
			this.PKJJFEIPAJA.SetTexture("GlassesColor2", temporary);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PKJJFEIPAJA, (this.screenBlendMode != SunShafts.ShaftsScreenBlendMode.Screen) ? 8 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600813A RID: 33082 RVA: 0x002BE2C0 File Offset: 0x002BC4C0
		public virtual bool ELHBKCFNCOJ()
		{
			base.KHNPMDDIJAJ(this.useDepthTexture);
			this.PKJJFEIPAJA = base.ECNEGNMAMDE(this.sunShaftsShader, this.PKJJFEIPAJA);
			this.NOJPCNFDAMC = base.EDFIBHNHAAB(this.simpleClearShader, this.NOJPCNFDAMC);
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600813C RID: 33084 RVA: 0x002BE394 File Offset: 0x002BC594
		public virtual bool JFFKKNHBANB()
		{
			base.FNIFJAENDIB(this.useDepthTexture);
			this.PKJJFEIPAJA = base.ECNEGNMAMDE(this.sunShaftsShader, this.PKJJFEIPAJA);
			this.NOJPCNFDAMC = base.LKIJNGDHLAK(this.simpleClearShader, this.NOJPCNFDAMC);
			if (!this.LMKGCBNNGLI)
			{
				base.EHBONBLLGBF();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600813D RID: 33085 RVA: 0x002BE3F8 File Offset: 0x002BC5F8
		private void MHGGJOAHGLL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 2;
			if (this.resolution == SunShafts.SunShaftsResolution.Low)
			{
				num = 6;
			}
			else if (this.resolution == (SunShafts.SunShaftsResolution)4)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 1815f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(116f, 1495f, 757f);
			}
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.PKJJFEIPAJA.SetVector("GlassesColor2", new Vector4(275f, 273f, 1788f, 1353f) * this.sunShaftBlurRadius);
			this.PKJJFEIPAJA.SetVector("UnAllocateViewID() should be called after the PhotonView was destroyed (GameObject.Destroy()). ViewID: {0} still found in: {1}", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.PKJJFEIPAJA.SetVector("New level loaded. Removed ", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = (!base.GetComponent<Camera>().allowHDR) ? RenderTextureFormat.Depth : ((RenderTextureFormat)(-95));
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.PKJJFEIPAJA.SetTexture("GetLive", temporary2);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 6);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 4);
			}
			base.KCJLLJOFGDF(temporary, this.NOJPCNFDAMC);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 1);
			float num2 = this.sunShaftBlurRadius * 1793f;
			this.PKJJFEIPAJA.SetVector("_TimeX", new Vector4(num2, num2, 1392f, 1437f));
			this.PKJJFEIPAJA.SetVector("maps.", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1986f + 20f) * 714f) / 1352f;
				this.PKJJFEIPAJA.SetVector("_LightIntensity", new Vector4(num2, num2, 419f, 1234f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1942f + 595f) * 1691f) / 804f;
				this.PKJJFEIPAJA.SetVector("_TimeX", new Vector4(num2, num2, 1216f, 1430f));
			}
			if (vector.z >= 807f)
			{
				this.PKJJFEIPAJA.SetVector("Joystick1Button5", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.PKJJFEIPAJA.SetVector("CameraFilterPack_AAA_BloodOnScreen1", Vector4.zero);
			}
			this.PKJJFEIPAJA.SetTexture("QuickSave", temporary);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PKJJFEIPAJA, (this.screenBlendMode != SunShafts.ShaftsScreenBlendMode.Screen) ? 7 : 1);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600813E RID: 33086 RVA: 0x002BE7EC File Offset: 0x002BC9EC
		public virtual bool FNEACOMEPBL()
		{
			base.LMEBEGFJGEM(this.useDepthTexture);
			this.PKJJFEIPAJA = base.GJKHKCOAFDB(this.sunShaftsShader, this.PKJJFEIPAJA);
			this.NOJPCNFDAMC = base.ECNEGNMAMDE(this.simpleClearShader, this.NOJPCNFDAMC);
			if (!this.LMKGCBNNGLI)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600813F RID: 33087 RVA: 0x002BE850 File Offset: 0x002BCA50
		private void ENGFEPKGEDG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 6;
			if (this.resolution == SunShafts.SunShaftsResolution.Normal)
			{
				num = 7;
			}
			else if (this.resolution == (SunShafts.SunShaftsResolution)7)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 1013f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1532f, 365f, 627f);
			}
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.PKJJFEIPAJA.SetVector("\n", new Vector4(584f, 1045f, 1702f, 1001f) * this.sunShaftBlurRadius);
			this.PKJJFEIPAJA.SetVector("/", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.PKJJFEIPAJA.SetVector("Set Parent", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = (!base.GetComponent<Camera>().allowHDR) ? RenderTextureFormat.RGB565 : ((RenderTextureFormat)94);
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.PKJJFEIPAJA.SetTexture("_TapMedium", temporary2);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 7);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 5);
			}
			base.NBLMPDOACKB(temporary, this.NOJPCNFDAMC);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 0);
			float num2 = this.sunShaftBlurRadius * 1783f;
			this.PKJJFEIPAJA.SetVector("_SecondTex", new Vector4(num2, num2, 225f, 790f));
			this.PKJJFEIPAJA.SetVector("_Value3", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.PKJJFEIPAJA, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1966f + 1588f) * 1087f) / 1167f;
				this.PKJJFEIPAJA.SetVector("Bad parameters for setbool! Use <key> <value>", new Vector4(num2, num2, 472f, 532f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1914f + 98f) * 1881f) / 1900f;
				this.PKJJFEIPAJA.SetVector("player.orangearc", new Vector4(num2, num2, 454f, 231f));
			}
			if (vector.z >= 742f)
			{
				this.PKJJFEIPAJA.SetVector("BloodAlternative3", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.PKJJFEIPAJA.SetVector("_Value3", Vector4.zero);
			}
			this.PKJJFEIPAJA.SetTexture("EventSystem", temporary);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PKJJFEIPAJA, (this.screenBlendMode != SunShafts.ShaftsScreenBlendMode.Screen) ? 0 : 1);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06008140 RID: 33088 RVA: 0x002BEC44 File Offset: 0x002BCE44
		public virtual bool NOABPEFKKHK()
		{
			base.JOMCJOEOLHP(this.useDepthTexture);
			this.PKJJFEIPAJA = base.LKIJNGDHLAK(this.sunShaftsShader, this.PKJJFEIPAJA);
			this.NOJPCNFDAMC = base.AJKPGPKKHHB(this.simpleClearShader, this.NOJPCNFDAMC);
			if (!this.LMKGCBNNGLI)
			{
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008141 RID: 33089 RVA: 0x002BECA8 File Offset: 0x002BCEA8
		private void NKKLGKPFPIK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 1;
			if (this.resolution == SunShafts.SunShaftsResolution.Low)
			{
				num = 7;
			}
			else if (this.resolution == (SunShafts.SunShaftsResolution)4)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 1775f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(937f, 327f, 1896f);
			}
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.PKJJFEIPAJA.SetVector("CurrentTimeLabel", new Vector4(961f, 1406f, 1172f, 503f) * this.sunShaftBlurRadius);
			this.PKJJFEIPAJA.SetVector("SetEnvSpriteColor", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.PKJJFEIPAJA.SetVector("CameraMovementSlider", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = (!base.GetComponent<Camera>().allowHDR) ? RenderTextureFormat.Shadowmap : ((RenderTextureFormat)(-57));
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.PKJJFEIPAJA.SetTexture("Clear Environment", temporary2);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 7);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 6);
			}
			base.KEKDMLCLCPA(temporary, this.NOJPCNFDAMC);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 5);
			float num2 = this.sunShaftBlurRadius * 299f;
			this.PKJJFEIPAJA.SetVector("PointsScoreText", new Vector4(num2, num2, 1623f, 167f));
			this.PKJJFEIPAJA.SetVector("CameraFilterPack/AAA_Blood_Hit", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1325f + 767f) * 737f) / 769f;
				this.PKJJFEIPAJA.SetVector("CameraFilterPack/Blend2Camera_Darken", new Vector4(num2, num2, 1259f, 1471f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1435f + 793f) * 1846f) / 1609f;
				this.PKJJFEIPAJA.SetVector("Connection failed: ", new Vector4(num2, num2, 224f, 1409f));
			}
			if (vector.z >= 1061f)
			{
				this.PKJJFEIPAJA.SetVector("Please specify either t or f.", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.PKJJFEIPAJA.SetVector("hitsounds:", Vector4.zero);
			}
			this.PKJJFEIPAJA.SetTexture("_Value", temporary);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PKJJFEIPAJA, (this.screenBlendMode != SunShafts.ShaftsScreenBlendMode.Screen) ? 4 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06008142 RID: 33090 RVA: 0x002BF09C File Offset: 0x002BD29C
		private void KCFHGGCIDNE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 8;
			if (this.resolution == SunShafts.SunShaftsResolution.Low)
			{
				num = 1;
			}
			else if (this.resolution == (SunShafts.SunShaftsResolution)4)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 489f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1792f, 348f, 769f);
			}
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.PKJJFEIPAJA.SetVector("bool", new Vector4(579f, 601f, 1868f, 887f) * this.sunShaftBlurRadius);
			this.PKJJFEIPAJA.SetVector("_Value2", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.PKJJFEIPAJA.SetVector("[LevelEditorScene] Error: Timeout :S", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = (!base.GetComponent<Camera>().allowHDR) ? RenderTextureFormat.ARGB2101010 : ((RenderTextureFormat)(-31));
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.PKJJFEIPAJA.SetTexture("ScoreText", temporary2);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 3);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 1);
			}
			base.BGDJEEOJFFA(temporary, this.NOJPCNFDAMC);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 0);
			float num2 = this.sunShaftBlurRadius * 703f;
			this.PKJJFEIPAJA.SetVector("Sprite", new Vector4(num2, num2, 834f, 1053f));
			this.PKJJFEIPAJA.SetVector("HiddenToggle", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1520f + 689f) * 1986f) / 618f;
				this.PKJJFEIPAJA.SetVector("_TimeX", new Vector4(num2, num2, 1889f, 1657f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 872f + 1050f) * 1948f) / 1876f;
				this.PKJJFEIPAJA.SetVector("_Value", new Vector4(num2, num2, 1036f, 921f));
			}
			if (vector.z >= 396f)
			{
				this.PKJJFEIPAJA.SetVector(" This is not possible to be called for standalone input. Please check your platform and code where this is called", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.PKJJFEIPAJA.SetVector("_Red_R", Vector4.zero);
			}
			this.PKJJFEIPAJA.SetTexture("inventory.itemscash", temporary);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PKJJFEIPAJA, (this.screenBlendMode != SunShafts.ShaftsScreenBlendMode.Screen) ? 3 : 1);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06008143 RID: 33091 RVA: 0x002BF490 File Offset: 0x002BD690
		public virtual bool APBDJCHNNEH()
		{
			base.NPOEJIDLJGK(this.useDepthTexture);
			this.PKJJFEIPAJA = base.GJKHKCOAFDB(this.sunShaftsShader, this.PKJJFEIPAJA);
			this.NOJPCNFDAMC = base.ECNEGNMAMDE(this.simpleClearShader, this.NOJPCNFDAMC);
			if (!this.LMKGCBNNGLI)
			{
				base.HKDNNECLBGL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008144 RID: 33092 RVA: 0x002BF4F4 File Offset: 0x002BD6F4
		private void NJFDLOBJCCF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 1;
			if (this.resolution == SunShafts.SunShaftsResolution.Low)
			{
				num = 3;
			}
			else if (this.resolution == SunShafts.SunShaftsResolution.Low)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 587f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(854f, 469f, 1993f);
			}
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.PKJJFEIPAJA.SetVector("_TimeX", new Vector4(1938f, 1851f, 1726f, 1898f) * this.sunShaftBlurRadius);
			this.PKJJFEIPAJA.SetVector("Lightning", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.PKJJFEIPAJA.SetVector("masterVolume", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = (!base.GetComponent<Camera>().allowHDR) ? RenderTextureFormat.Depth : ((RenderTextureFormat)53);
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.PKJJFEIPAJA.SetTexture("CameraFilterPack/Blend2Camera_LinearBurn", temporary2);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 0);
			}
			base.MMKJCLLGOPE(temporary, this.NOJPCNFDAMC);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 8);
			float num2 = this.sunShaftBlurRadius * 249f;
			this.PKJJFEIPAJA.SetVector("_PColor2", new Vector4(num2, num2, 93f, 1765f));
			this.PKJJFEIPAJA.SetVector("speed", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1737f + 1187f) * 1222f) / 1617f;
				this.PKJJFEIPAJA.SetVector("_TimeX", new Vector4(num2, num2, 1006f, 1056f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1401f + 115f) * 1999f) / 1752f;
				this.PKJJFEIPAJA.SetVector(". Current number of cells is ", new Vector4(num2, num2, 147f, 976f));
			}
			if (vector.z >= 407f)
			{
				this.PKJJFEIPAJA.SetVector("Distortion", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.PKJJFEIPAJA.SetVector("red", Vector4.zero);
			}
			this.PKJJFEIPAJA.SetTexture("_CurTex", temporary);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PKJJFEIPAJA, (this.screenBlendMode != SunShafts.ShaftsScreenBlendMode.Screen) ? 3 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06008145 RID: 33093 RVA: 0x002BF8E8 File Offset: 0x002BDAE8
		public virtual bool KFDALIFKLHE()
		{
			base.FNIFJAENDIB(this.useDepthTexture);
			this.PKJJFEIPAJA = base.ECNEGNMAMDE(this.sunShaftsShader, this.PKJJFEIPAJA);
			this.NOJPCNFDAMC = base.GJKHKCOAFDB(this.simpleClearShader, this.NOJPCNFDAMC);
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008146 RID: 33094 RVA: 0x002BF94C File Offset: 0x002BDB4C
		public virtual bool GACCMCAGAIJ()
		{
			base.KNGDKKMDKOG(this.useDepthTexture);
			this.PKJJFEIPAJA = base.AJKPGPKKHHB(this.sunShaftsShader, this.PKJJFEIPAJA);
			this.NOJPCNFDAMC = base.EDFIBHNHAAB(this.simpleClearShader, this.NOJPCNFDAMC);
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008147 RID: 33095 RVA: 0x002BF9B0 File Offset: 0x002BDBB0
		private void KKHCDAPLABD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 1;
			if (this.resolution == SunShafts.SunShaftsResolution.Low)
			{
				num = 4;
			}
			else if (this.resolution == (SunShafts.SunShaftsResolution)3)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 1077f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1691f, 1432f, 1366f);
			}
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.PKJJFEIPAJA.SetVector("Hidden/LensAberrations", new Vector4(1257f, 864f, 180f, 337f) * this.sunShaftBlurRadius);
			this.PKJJFEIPAJA.SetVector(":", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.PKJJFEIPAJA.SetVector("https://twitch.tv/intralism", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = (!base.GetComponent<Camera>().allowHDR) ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.RG16;
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.PKJJFEIPAJA.SetTexture("_TimeX", temporary2);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 5);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 1);
			}
			base.CKHBGCGEEDB(temporary, this.NOJPCNFDAMC);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 6);
			float num2 = this.sunShaftBlurRadius * 1293f;
			this.PKJJFEIPAJA.SetVector("OnClick", new Vector4(num2, num2, 1362f, 396f));
			this.PKJJFEIPAJA.SetVector("DPADHOR", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.PKJJFEIPAJA, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1253f + 1632f) * 473f) / 1430f;
				this.PKJJFEIPAJA.SetVector("Value", new Vector4(num2, num2, 380f, 296f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1369f + 1422f) * 210f) / 827f;
				this.PKJJFEIPAJA.SetVector("help", new Vector4(num2, num2, 927f, 871f));
			}
			if (vector.z >= 335f)
			{
				this.PKJJFEIPAJA.SetVector(" or ", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.PKJJFEIPAJA.SetVector("RPCs can only be sent in rooms. Call of \"", Vector4.zero);
			}
			this.PKJJFEIPAJA.SetTexture("LevelConfigButton", temporary);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PKJJFEIPAJA, (this.screenBlendMode != SunShafts.ShaftsScreenBlendMode.Screen) ? 4 : 1);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06008148 RID: 33096 RVA: 0x002BFDA4 File Offset: 0x002BDFA4
		private void LDIOANOMHMO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 6;
			if (this.resolution == SunShafts.SunShaftsResolution.Normal)
			{
				num = 3;
			}
			else if (this.resolution == (SunShafts.SunShaftsResolution)6)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 892f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1825f, 1012f, 331f);
			}
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.PKJJFEIPAJA.SetVector("Editor/", new Vector4(198f, 699f, 1042f, 1009f) * this.sunShaftBlurRadius);
			this.PKJJFEIPAJA.SetVector("mapselector.lastSearch", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.PKJJFEIPAJA.SetVector("shader.crispwinter", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = (!base.GetComponent<Camera>().allowHDR) ? RenderTextureFormat.ARGB1555 : ((RenderTextureFormat)(-49));
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.PKJJFEIPAJA.SetTexture("_History2LumaTex", temporary2);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 0);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 5);
			}
			base.ONCFIJNADIA(temporary, this.NOJPCNFDAMC);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 1);
			float num2 = this.sunShaftBlurRadius * 752f;
			this.PKJJFEIPAJA.SetVector("return ", new Vector4(num2, num2, 334f, 932f));
			this.PKJJFEIPAJA.SetVector("CameraFilterPack/Blend2Camera_SoftLight", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.PKJJFEIPAJA, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 353f + 220f) * 535f) / 1526f;
				this.PKJJFEIPAJA.SetVector("CameraFilterPack/Distortion_Half_Sphere", new Vector4(num2, num2, 258f, 1126f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 229f + 1048f) * 616f) / 1162f;
				this.PKJJFEIPAJA.SetVector("maps.", new Vector4(num2, num2, 766f, 1734f));
			}
			if (vector.z >= 125f)
			{
				this.PKJJFEIPAJA.SetVector("note.5", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.PKJJFEIPAJA.SetVector("_OffsetScale", Vector4.zero);
			}
			this.PKJJFEIPAJA.SetTexture("ENABLE_USER_LUT", temporary);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PKJJFEIPAJA, (this.screenBlendMode != SunShafts.ShaftsScreenBlendMode.Screen) ? 3 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06008149 RID: 33097 RVA: 0x002C0198 File Offset: 0x002BE398
		private void KDFILLAPHIO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 3;
			if (this.resolution == SunShafts.SunShaftsResolution.Normal)
			{
				num = 6;
			}
			else if (this.resolution == (SunShafts.SunShaftsResolution)4)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 1583f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(196f, 779f, 340f);
			}
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.PKJJFEIPAJA.SetVector("SteamManager", new Vector4(1919f, 879f, 979f, 602f) * this.sunShaftBlurRadius);
			this.PKJJFEIPAJA.SetVector("\\n", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.PKJJFEIPAJA.SetVector("EndlessLoopsScoreText", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = (!base.GetComponent<Camera>().allowHDR) ? RenderTextureFormat.ARGB32 : ((RenderTextureFormat)(-14));
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.PKJJFEIPAJA.SetTexture("<command>", temporary2);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 5);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 2);
			}
			base.MMKJCLLGOPE(temporary, this.NOJPCNFDAMC);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 4);
			float num2 = this.sunShaftBlurRadius * 1167f;
			this.PKJJFEIPAJA.SetVector(" to ", new Vector4(num2, num2, 1073f, 44f));
			this.PKJJFEIPAJA.SetVector("_Value4", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.PKJJFEIPAJA, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 734f + 1943f) * 998f) / 1929f;
				this.PKJJFEIPAJA.SetVector("TimeBGSlider", new Vector4(num2, num2, 619f, 1155f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.PKJJFEIPAJA, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1942f + 651f) * 705f) / 1417f;
				this.PKJJFEIPAJA.SetVector("settings.enableranking", new Vector4(num2, num2, 1933f, 813f));
			}
			if (vector.z >= 1217f)
			{
				this.PKJJFEIPAJA.SetVector(" not exist", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.PKJJFEIPAJA.SetVector("/Segment-[Up]", Vector4.zero);
			}
			this.PKJJFEIPAJA.SetTexture("_Value2", temporary);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PKJJFEIPAJA, (this.screenBlendMode != SunShafts.ShaftsScreenBlendMode.Screen) ? 6 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600814A RID: 33098 RVA: 0x002C058C File Offset: 0x002BE78C
		public virtual bool JDPOEILHKLC()
		{
			base.NPOEJIDLJGK(this.useDepthTexture);
			this.PKJJFEIPAJA = base.GJKHKCOAFDB(this.sunShaftsShader, this.PKJJFEIPAJA);
			this.NOJPCNFDAMC = base.LKIJNGDHLAK(this.simpleClearShader, this.NOJPCNFDAMC);
			if (!this.LMKGCBNNGLI)
			{
				base.HKDNNECLBGL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600814B RID: 33099 RVA: 0x002C05F0 File Offset: 0x002BE7F0
		public virtual bool FEIGCNHEINM()
		{
			base.DCHKKHDGBLJ(this.useDepthTexture);
			this.PKJJFEIPAJA = base.LKIJNGDHLAK(this.sunShaftsShader, this.PKJJFEIPAJA);
			this.NOJPCNFDAMC = base.ECNEGNMAMDE(this.simpleClearShader, this.NOJPCNFDAMC);
			if (!this.LMKGCBNNGLI)
			{
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600814C RID: 33100 RVA: 0x002C0654 File Offset: 0x002BE854
		private void HFNLEOLNJLF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 6;
			if (this.resolution == SunShafts.SunShaftsResolution.Low)
			{
				num = 0;
			}
			else if (this.resolution == (SunShafts.SunShaftsResolution)5)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 1146f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(118f, 848f, 1791f);
			}
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			this.PKJJFEIPAJA.SetVector("offsets", new Vector4(1391f, 485f, 1840f, 654f) * this.sunShaftBlurRadius);
			this.PKJJFEIPAJA.SetVector("]", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.PKJJFEIPAJA.SetVector("DisableStoryboardToggle", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = (!base.GetComponent<Camera>().allowHDR) ? RenderTextureFormat.Depth : ((RenderTextureFormat)95);
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.PKJJFEIPAJA.SetTexture(":", temporary2);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 8);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 8);
			}
			base.NHLAAEPLAKA(temporary, this.NOJPCNFDAMC);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 3);
			float num2 = this.sunShaftBlurRadius * 1660f;
			this.PKJJFEIPAJA.SetVector("Mouse Wheel Down", new Vector4(num2, num2, 1633f, 1985f));
			this.PKJJFEIPAJA.SetVector("InfoText", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 12f + 734f) * 780f) / 1509f;
				this.PKJJFEIPAJA.SetVector("Left Stick Click", new Vector4(num2, num2, 618f, 574f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1046f + 888f) * 439f) / 366f;
				this.PKJJFEIPAJA.SetVector("Nov", new Vector4(num2, num2, 865f, 1943f));
			}
			if (vector.z >= 1343f)
			{
				this.PKJJFEIPAJA.SetVector("(?<=#)\\w+", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.PKJJFEIPAJA.SetVector("masterSteamID", Vector4.zero);
			}
			this.PKJJFEIPAJA.SetTexture("_Distortion", temporary);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PKJJFEIPAJA, (this.screenBlendMode != SunShafts.ShaftsScreenBlendMode.Screen) ? 1 : 1);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600814D RID: 33101 RVA: 0x002C0A48 File Offset: 0x002BEC48
		private void DPMMIPDKJND(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 7;
			if (this.resolution == SunShafts.SunShaftsResolution.Normal)
			{
				num = 4;
			}
			else if (this.resolution == (SunShafts.SunShaftsResolution)4)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 1446f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1273f, 1865f, 1349f);
			}
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.PKJJFEIPAJA.SetVector("2;13;14;15;16", new Vector4(1704f, 1210f, 1499f, 1745f) * this.sunShaftBlurRadius);
			this.PKJJFEIPAJA.SetVector(": ", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.PKJJFEIPAJA.SetVector("SupportLogger OnJoinedLobby(", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = (!base.GetComponent<Camera>().allowHDR) ? RenderTextureFormat.ARGB2101010 : ((RenderTextureFormat)(-49));
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.PKJJFEIPAJA.SetTexture("id", temporary2);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 8);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 6);
			}
			base.LLHBNGOEKGI(temporary, this.NOJPCNFDAMC);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 4);
			float num2 = this.sunShaftBlurRadius * 1299f;
			this.PKJJFEIPAJA.SetVector("Can't set open when not in that room.", new Vector4(num2, num2, 672f, 1209f));
			this.PKJJFEIPAJA.SetVector(".", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 711f + 1008f) * 463f) / 1227f;
				this.PKJJFEIPAJA.SetVector("_GreenAmplifier", new Vector4(num2, num2, 706f, 1147f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1849f + 779f) * 257f) / 1399f;
				this.PKJJFEIPAJA.SetVector("float,1.5", new Vector4(num2, num2, 1651f, 282f));
			}
			if (vector.z >= 942f)
			{
				this.PKJJFEIPAJA.SetVector("_MainTex2", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.PKJJFEIPAJA.SetVector("_StretchWidth", Vector4.zero);
			}
			this.PKJJFEIPAJA.SetTexture("_Value", temporary);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PKJJFEIPAJA, (this.screenBlendMode != SunShafts.ShaftsScreenBlendMode.Screen) ? 3 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600814E RID: 33102 RVA: 0x002C0E3C File Offset: 0x002BF03C
		public virtual bool MOLMLGKEBOL()
		{
			base.DHHGCBANGJL(this.useDepthTexture);
			this.PKJJFEIPAJA = base.NODBMINMALP(this.sunShaftsShader, this.PKJJFEIPAJA);
			this.NOJPCNFDAMC = base.LKIJNGDHLAK(this.simpleClearShader, this.NOJPCNFDAMC);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600814F RID: 33103 RVA: 0x002C0EA0 File Offset: 0x002BF0A0
		public override bool ILMGHBFANON()
		{
			base.DCHKKHDGBLJ(this.useDepthTexture);
			this.PKJJFEIPAJA = base.NODBMINMALP(this.sunShaftsShader, this.PKJJFEIPAJA);
			this.NOJPCNFDAMC = base.KDHKHOHMKCG(this.simpleClearShader, this.NOJPCNFDAMC);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008150 RID: 33104 RVA: 0x002C0F04 File Offset: 0x002BF104
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 4;
			if (this.resolution == SunShafts.SunShaftsResolution.Normal)
			{
				num = 2;
			}
			else if (this.resolution == SunShafts.SunShaftsResolution.High)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 0.5f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(0.5f, 0.5f, 0f);
			}
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.PKJJFEIPAJA.SetVector("_BlurRadius4", new Vector4(1f, 1f, 0f, 0f) * this.sunShaftBlurRadius);
			this.PKJJFEIPAJA.SetVector("_SunPosition", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.PKJJFEIPAJA.SetVector("_SunThreshold", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = (!base.GetComponent<Camera>().allowHDR) ? RenderTextureFormat.Default : RenderTextureFormat.DefaultHDR;
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.PKJJFEIPAJA.SetTexture("_Skybox", temporary2);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 3);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 2);
			}
			base.NBLMPDOACKB(temporary, this.NOJPCNFDAMC);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 4);
			float num2 = this.sunShaftBlurRadius * 0.00130208337f;
			this.PKJJFEIPAJA.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
			this.PKJJFEIPAJA.SetVector("_SunPosition", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 2f + 1f) * 6f) / 768f;
				this.PKJJFEIPAJA.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 2f + 2f) * 6f) / 768f;
				this.PKJJFEIPAJA.SetVector("_BlurRadius4", new Vector4(num2, num2, 0f, 0f));
			}
			if (vector.z >= 0f)
			{
				this.PKJJFEIPAJA.SetVector("_SunColor", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.PKJJFEIPAJA.SetVector("_SunColor", Vector4.zero);
			}
			this.PKJJFEIPAJA.SetTexture("_ColorBuffer", temporary);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PKJJFEIPAJA, (this.screenBlendMode != SunShafts.ShaftsScreenBlendMode.Screen) ? 4 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06008151 RID: 33105 RVA: 0x002C12F8 File Offset: 0x002BF4F8
		private void CLLJDEAJDNL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.Depth;
			}
			int num = 2;
			if (this.resolution == SunShafts.SunShaftsResolution.Normal)
			{
				num = 8;
			}
			else if (this.resolution == (SunShafts.SunShaftsResolution)3)
			{
				num = 0;
			}
			Vector3 vector = Vector3.one * 1074f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(979f, 1728f, 818f);
			}
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.PKJJFEIPAJA.SetVector("CameraFilterPack/Gradients_Therma", new Vector4(1301f, 1723f, 969f, 108f) * this.sunShaftBlurRadius);
			this.PKJJFEIPAJA.SetVector("Reconnect() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.PKJJFEIPAJA.SetVector(" id: ", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = (!base.GetComponent<Camera>().allowHDR) ? RenderTextureFormat.RGB565 : ((RenderTextureFormat)(-60));
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.PKJJFEIPAJA.SetTexture("EnableRankedNotificationsToggle", temporary2);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 0);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 4);
			}
			base.DHMBOADDLOM(temporary, this.NOJPCNFDAMC);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 3);
			float num2 = this.sunShaftBlurRadius * 783f;
			this.PKJJFEIPAJA.SetVector("Data/Localization", new Vector4(num2, num2, 771f, 446f));
			this.PKJJFEIPAJA.SetVector("LobbyCanvas", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i += 0)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1473f + 355f) * 706f) / 630f;
				this.PKJJFEIPAJA.SetVector("_LowRez", new Vector4(num2, num2, 57f, 890f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 290f + 1602f) * 274f) / 189f;
				this.PKJJFEIPAJA.SetVector("TotalHitsScoreText", new Vector4(num2, num2, 1674f, 760f));
			}
			if (vector.z >= 96f)
			{
				this.PKJJFEIPAJA.SetVector("settings.enablerankingnotifications", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.PKJJFEIPAJA.SetVector(". Prefab must have a PhotonView component.", Vector4.zero);
			}
			this.PKJJFEIPAJA.SetTexture("_HueShift", temporary);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PKJJFEIPAJA, (this.screenBlendMode != SunShafts.ShaftsScreenBlendMode.Screen) ? 6 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06008152 RID: 33106 RVA: 0x002C16EC File Offset: 0x002BF8EC
		private void JCCIKBBEMEB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 4;
			if (this.resolution == SunShafts.SunShaftsResolution.Low)
			{
				num = 0;
			}
			else if (this.resolution == SunShafts.SunShaftsResolution.High)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 414f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1742f, 1971f, 379f);
			}
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.PKJJFEIPAJA.SetVector("Submition failed", new Vector4(230f, 337f, 1304f, 161f) * this.sunShaftBlurRadius);
			this.PKJJFEIPAJA.SetVector("win", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.PKJJFEIPAJA.SetVector("_NoisePerChannel", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = (!base.GetComponent<Camera>().allowHDR) ? RenderTextureFormat.RGB565 : ((RenderTextureFormat)(-88));
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 1, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(false, base.GetComponent<Camera>());
				this.PKJJFEIPAJA.SetTexture("MenuVolumeSlider", temporary2);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 5);
			}
			base.MMKJCLLGOPE(temporary, this.NOJPCNFDAMC);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 1, 8);
			float num2 = this.sunShaftBlurRadius * 1420f;
			this.PKJJFEIPAJA.SetVector("_EmissionColor", new Vector4(num2, num2, 1573f, 911f));
			this.PKJJFEIPAJA.SetVector(":", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 0; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary, temporary3, this.PKJJFEIPAJA, 1);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 1423f + 1240f) * 1077f) / 1914f;
				this.PKJJFEIPAJA.SetVector("#md5submitionfailed: ", new Vector4(num2, num2, 1545f, 1067f));
				temporary = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary3, temporary, this.PKJJFEIPAJA, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1059f + 1251f) * 1277f) / 835f;
				this.PKJJFEIPAJA.SetVector("#ok", new Vector4(num2, num2, 163f, 630f));
			}
			if (vector.z >= 1719f)
			{
				this.PKJJFEIPAJA.SetVector(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.PKJJFEIPAJA.SetVector("settings_bindings_controller_type", Vector4.zero);
			}
			this.PKJJFEIPAJA.SetTexture("Data", temporary);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PKJJFEIPAJA, (this.screenBlendMode != SunShafts.ShaftsScreenBlendMode.Screen) ? 7 : 0);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06008153 RID: 33107 RVA: 0x002C1AE0 File Offset: 0x002BFCE0
		public virtual bool IMPPEKJHPIM()
		{
			base.CKIAMHAKJOK(this.useDepthTexture);
			this.PKJJFEIPAJA = base.GJKHKCOAFDB(this.sunShaftsShader, this.PKJJFEIPAJA);
			this.NOJPCNFDAMC = base.EDFIBHNHAAB(this.simpleClearShader, this.NOJPCNFDAMC);
			if (!this.LMKGCBNNGLI)
			{
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008154 RID: 33108 RVA: 0x002C1B44 File Offset: 0x002BFD44
		private void DBIDOEKLEII(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			if (this.useDepthTexture)
			{
				base.GetComponent<Camera>().depthTextureMode |= DepthTextureMode.None;
			}
			int num = 6;
			if (this.resolution == SunShafts.SunShaftsResolution.Normal)
			{
				num = 8;
			}
			else if (this.resolution == (SunShafts.SunShaftsResolution)5)
			{
				num = 1;
			}
			Vector3 vector = Vector3.one * 685f;
			if (this.sunTransform)
			{
				vector = base.GetComponent<Camera>().WorldToViewportPoint(this.sunTransform.position);
			}
			else
			{
				vector = new Vector3(1260f, 1387f, 537f);
			}
			int width = HLBKCLPNHEB.width / num;
			int height = HLBKCLPNHEB.height / num;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			this.PKJJFEIPAJA.SetVector("Middle Click", new Vector4(384f, 1858f, 323f, 1328f) * this.sunShaftBlurRadius);
			this.PKJJFEIPAJA.SetVector("_TimeX", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			this.PKJJFEIPAJA.SetVector("y", this.sunThreshold);
			if (!this.useDepthTexture)
			{
				RenderTextureFormat format = (!base.GetComponent<Camera>().allowHDR) ? RenderTextureFormat.ARGB4444 : ((RenderTextureFormat)(-110));
				RenderTexture temporary2 = RenderTexture.GetTemporary(HLBKCLPNHEB.width, HLBKCLPNHEB.height, 0, format);
				RenderTexture.active = temporary2;
				GL.ClearWithSkybox(true, base.GetComponent<Camera>());
				this.PKJJFEIPAJA.SetTexture("Delete events", temporary2);
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 7);
				RenderTexture.ReleaseTemporary(temporary2);
			}
			else
			{
				Graphics.Blit(HLBKCLPNHEB, temporary, this.PKJJFEIPAJA, 7);
			}
			base.KEKDMLCLCPA(temporary, this.NOJPCNFDAMC);
			this.radialBlurIterations = Mathf.Clamp(this.radialBlurIterations, 0, 3);
			float num2 = this.sunShaftBlurRadius * 55f;
			this.PKJJFEIPAJA.SetVector("[ItemsHandler] Inventory not changed", new Vector4(num2, num2, 1040f, 661f));
			this.PKJJFEIPAJA.SetVector("FinalScoreSmallText", new Vector4(vector.x, vector.y, vector.z, this.maxRadius));
			for (int i = 1; i < this.radialBlurIterations; i++)
			{
				RenderTexture temporary3 = RenderTexture.GetTemporary(width, height, 1);
				Graphics.Blit(temporary, temporary3, this.PKJJFEIPAJA, 0);
				RenderTexture.ReleaseTemporary(temporary);
				num2 = this.sunShaftBlurRadius * (((float)i * 578f + 1300f) * 997f) / 357f;
				this.PKJJFEIPAJA.SetVector("\n\n#", new Vector4(num2, num2, 1144f, 1444f));
				temporary = RenderTexture.GetTemporary(width, height, 0);
				Graphics.Blit(temporary3, temporary, this.PKJJFEIPAJA, 0);
				RenderTexture.ReleaseTemporary(temporary3);
				num2 = this.sunShaftBlurRadius * (((float)i * 1706f + 1027f) * 1473f) / 648f;
				this.PKJJFEIPAJA.SetVector("[", new Vector4(num2, num2, 165f, 1614f));
			}
			if (vector.z >= 1798f)
			{
				this.PKJJFEIPAJA.SetVector("id", new Vector4(this.sunColor.r, this.sunColor.g, this.sunColor.b, this.sunColor.a) * this.sunShaftIntensity);
			}
			else
			{
				this.PKJJFEIPAJA.SetVector("_Value3", Vector4.zero);
			}
			this.PKJJFEIPAJA.SetTexture("challenges.", temporary);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PKJJFEIPAJA, (this.screenBlendMode != SunShafts.ShaftsScreenBlendMode.Screen) ? 6 : 1);
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06008155 RID: 33109 RVA: 0x002C1F38 File Offset: 0x002C0138
		public virtual bool NHCNNDEHICD()
		{
			base.IBFDMKMOBCA(this.useDepthTexture);
			this.PKJJFEIPAJA = base.NODBMINMALP(this.sunShaftsShader, this.PKJJFEIPAJA);
			this.NOJPCNFDAMC = base.EDFIBHNHAAB(this.simpleClearShader, this.NOJPCNFDAMC);
			if (!this.LMKGCBNNGLI)
			{
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x04000E6F RID: 3695
		public SunShafts.SunShaftsResolution resolution = SunShafts.SunShaftsResolution.Normal;

		// Token: 0x04000E70 RID: 3696
		public SunShafts.ShaftsScreenBlendMode screenBlendMode;

		// Token: 0x04000E71 RID: 3697
		public Transform sunTransform;

		// Token: 0x04000E72 RID: 3698
		public int radialBlurIterations = 2;

		// Token: 0x04000E73 RID: 3699
		public Color sunColor = Color.white;

		// Token: 0x04000E74 RID: 3700
		public Color sunThreshold = new Color(0.87f, 0.74f, 0.65f);

		// Token: 0x04000E75 RID: 3701
		public float sunShaftBlurRadius = 2.5f;

		// Token: 0x04000E76 RID: 3702
		public float sunShaftIntensity = 1.15f;

		// Token: 0x04000E77 RID: 3703
		public float maxRadius = 0.75f;

		// Token: 0x04000E78 RID: 3704
		public bool useDepthTexture = true;

		// Token: 0x04000E79 RID: 3705
		public Shader sunShaftsShader;

		// Token: 0x04000E7A RID: 3706
		private Material PKJJFEIPAJA;

		// Token: 0x04000E7B RID: 3707
		public Shader simpleClearShader;

		// Token: 0x04000E7C RID: 3708
		private Material NOJPCNFDAMC;

		// Token: 0x020001F6 RID: 502
		public enum SunShaftsResolution
		{
			// Token: 0x04000E7E RID: 3710
			Low,
			// Token: 0x04000E7F RID: 3711
			Normal,
			// Token: 0x04000E80 RID: 3712
			High
		}

		// Token: 0x020001F7 RID: 503
		public enum ShaftsScreenBlendMode
		{
			// Token: 0x04000E82 RID: 3714
			Screen,
			// Token: 0x04000E83 RID: 3715
			Add
		}
	}
}
