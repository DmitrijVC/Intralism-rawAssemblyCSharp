using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001F1 RID: 497
	[AddComponentMenu("Image Effects/Rendering/Screen Space Ambient Obscurance")]
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	internal class ScreenSpaceAmbientObscurance : PostEffectsBase
	{
		// Token: 0x0600808B RID: 32907 RVA: 0x002B5BEC File Offset: 0x002B3DEC
		public virtual bool OAGFHJHEBCA()
		{
			base.LMEBEGFJGEM(false);
			this.GLFCHEPLJEO = base.ECNEGNMAMDE(this.aoShader, this.GLFCHEPLJEO);
			if (!this.LMKGCBNNGLI)
			{
				base.EHBONBLLGBF();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600808C RID: 32908 RVA: 0x002B5C25 File Offset: 0x002B3E25
		private void JHJGJJKELJM()
		{
			if (this.GLFCHEPLJEO)
			{
				UnityEngine.Object.DestroyImmediate(this.GLFCHEPLJEO);
			}
			this.GLFCHEPLJEO = null;
		}

		// Token: 0x0600808D RID: 32909 RVA: 0x002B5C4C File Offset: 0x002B3E4C
		private void MHGGJOAHGLL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Matrix4x4 projectionMatrix = base.GetComponent<Camera>().projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 value = new Vector4(969f / ((float)Screen.width * projectionMatrix[1]), 325f / ((float)Screen.height * projectionMatrix[1]), (183f - projectionMatrix[4]) / projectionMatrix[1], (523f + projectionMatrix[8]) / projectionMatrix[5]);
			this.GLFCHEPLJEO.SetVector("mapselector.filter.favoriteonly", value);
			this.GLFCHEPLJEO.SetMatrix("CameraFilterPack/TV_Horror", inverse);
			this.GLFCHEPLJEO.SetTexture("PlayMapGoal", this.rand);
			this.GLFCHEPLJEO.SetFloat("_ScreenResolution", this.radius);
			this.GLFCHEPLJEO.SetFloat(" Time: ", this.radius * this.radius);
			this.GLFCHEPLJEO.SetFloat("file://", this.intensity);
			this.GLFCHEPLJEO.SetFloat("_Near", this.blurFilterDistance);
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> (this.downsample & -43), height >> (this.downsample & 3));
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.GLFCHEPLJEO, 1);
			if (this.downsample > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.GLFCHEPLJEO.SetVector("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", new Vector2(1146f, 1143f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				this.GLFCHEPLJEO.SetVector("_Value2", new Vector2(210f, 1994f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, this.GLFCHEPLJEO, 0);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.GLFCHEPLJEO.SetTexture("_TimeX", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GLFCHEPLJEO, 6);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600808E RID: 32910 RVA: 0x002B5EB0 File Offset: 0x002B40B0
		private void HELHDLOLPLH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Matrix4x4 projectionMatrix = base.GetComponent<Camera>().projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 value = new Vector4(1659f / ((float)Screen.width * projectionMatrix[0]), 428f / ((float)Screen.height * projectionMatrix[8]), (1078f - projectionMatrix[8]) / projectionMatrix[0], (1678f + projectionMatrix[3]) / projectionMatrix[0]);
			this.GLFCHEPLJEO.SetVector("#", value);
			this.GLFCHEPLJEO.SetMatrix("plainText", inverse);
			this.GLFCHEPLJEO.SetTexture("DPADHOR", this.rand);
			this.GLFCHEPLJEO.SetFloat("_Overlay", this.radius);
			this.GLFCHEPLJEO.SetFloat("workshop.", this.radius * this.radius);
			this.GLFCHEPLJEO.SetFloat("_Size", this.intensity);
			this.GLFCHEPLJEO.SetFloat("_MatrixSize", this.blurFilterDistance);
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> (this.downsample & 24), height >> (this.downsample & 53));
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.GLFCHEPLJEO, 0);
			if (this.downsample > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				this.GLFCHEPLJEO.SetVector("_Value3", new Vector2(668f, 1728f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				this.GLFCHEPLJEO.SetVector("accuracy", new Vector2(1320f, 452f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, this.GLFCHEPLJEO, 1);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.GLFCHEPLJEO.SetTexture("_Vibrance", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GLFCHEPLJEO, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600808F RID: 32911 RVA: 0x002B6113 File Offset: 0x002B4313
		public virtual bool KIELKBGLNKO()
		{
			base.NPOEJIDLJGK(false);
			this.GLFCHEPLJEO = base.KDHKHOHMKCG(this.aoShader, this.GLFCHEPLJEO);
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008090 RID: 32912 RVA: 0x002B614C File Offset: 0x002B434C
		private void OAHHAAKEBDD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Matrix4x4 projectionMatrix = base.GetComponent<Camera>().projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 value = new Vector4(593f / ((float)Screen.width * projectionMatrix[1]), 1720f / ((float)Screen.height * projectionMatrix[0]), (1525f - projectionMatrix[5]) / projectionMatrix[1], (8f + projectionMatrix[0]) / projectionMatrix[1]);
			this.GLFCHEPLJEO.SetVector("/music", value);
			this.GLFCHEPLJEO.SetMatrix("BadgeText", inverse);
			this.GLFCHEPLJEO.SetTexture(".icon", this.rand);
			this.GLFCHEPLJEO.SetFloat("_ScreenResolution", this.radius);
			this.GLFCHEPLJEO.SetFloat("skin.hit_normal", this.radius * this.radius);
			this.GLFCHEPLJEO.SetFloat("ready", this.intensity);
			this.GLFCHEPLJEO.SetFloat("/", this.blurFilterDistance);
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> (this.downsample & -111), height >> (this.downsample & 32));
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.GLFCHEPLJEO, 1);
			if (this.downsample > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.GLFCHEPLJEO.SetVector("{0}{1}{2}", new Vector2(537f, 369f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				this.GLFCHEPLJEO.SetVector("CameraFilterPack/Drawing_Paper3", new Vector2(836f, 1899f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, this.GLFCHEPLJEO, 0);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.GLFCHEPLJEO.SetTexture("offsets", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GLFCHEPLJEO, 3);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06008091 RID: 32913 RVA: 0x002B63AF File Offset: 0x002B45AF
		public virtual bool MPMLKLHMPJH()
		{
			base.LMEBEGFJGEM(false);
			this.GLFCHEPLJEO = base.AJKPGPKKHHB(this.aoShader, this.GLFCHEPLJEO);
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008092 RID: 32914 RVA: 0x002B63E8 File Offset: 0x002B45E8
		public virtual bool JFFKKNHBANB()
		{
			base.KNGDKKMDKOG(false);
			this.GLFCHEPLJEO = base.GJKHKCOAFDB(this.aoShader, this.GLFCHEPLJEO);
			if (!this.LMKGCBNNGLI)
			{
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008093 RID: 32915 RVA: 0x002B6424 File Offset: 0x002B4624
		private void DBIDOEKLEII(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Matrix4x4 projectionMatrix = base.GetComponent<Camera>().projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 value = new Vector4(834f / ((float)Screen.width * projectionMatrix[1]), 607f / ((float)Screen.height * projectionMatrix[8]), (1887f - projectionMatrix[8]) / projectionMatrix[1], (94f + projectionMatrix[1]) / projectionMatrix[4]);
			this.GLFCHEPLJEO.SetVector("_EmissionColor", value);
			this.GLFCHEPLJEO.SetMatrix("_LowRez", inverse);
			this.GLFCHEPLJEO.SetTexture("Vignette", this.rand);
			this.GLFCHEPLJEO.SetFloat("[Right]", this.radius);
			this.GLFCHEPLJEO.SetFloat("Joystick1Button5", this.radius * this.radius);
			this.GLFCHEPLJEO.SetFloat("inventory.itemscash", this.intensity);
			this.GLFCHEPLJEO.SetFloat("OpSetPropertiesOfActor()", this.blurFilterDistance);
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> (this.downsample & 24), height >> (this.downsample & 70));
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.GLFCHEPLJEO, 0);
			if (this.downsample > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.GLFCHEPLJEO.SetVector("GlassDistortion", new Vector2(748f, 736f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				this.GLFCHEPLJEO.SetVector("CheckCombo", new Vector2(1643f, 911f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, this.GLFCHEPLJEO, 1);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.GLFCHEPLJEO.SetTexture("float,1", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GLFCHEPLJEO, 3);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06008094 RID: 32916 RVA: 0x002B6688 File Offset: 0x002B4888
		private void AMKFLDKCIJO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Matrix4x4 projectionMatrix = base.GetComponent<Camera>().projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 value = new Vector4(127f / ((float)Screen.width * projectionMatrix[1]), 1235f / ((float)Screen.height * projectionMatrix[1]), (327f - projectionMatrix[8]) / projectionMatrix[0], (1094f + projectionMatrix[1]) / projectionMatrix[1]);
			this.GLFCHEPLJEO.SetVector(" x ", value);
			this.GLFCHEPLJEO.SetMatrix("_ScreenResolution", inverse);
			this.GLFCHEPLJEO.SetTexture("[MapsData] Installed: ", this.rand);
			this.GLFCHEPLJEO.SetFloat("_Value2", this.radius);
			this.GLFCHEPLJEO.SetFloat("note.6", this.radius * this.radius);
			this.GLFCHEPLJEO.SetFloat("t", this.intensity);
			this.GLFCHEPLJEO.SetFloat("g", this.blurFilterDistance);
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> (this.downsample & 117), height >> (this.downsample & 6));
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.GLFCHEPLJEO, 0);
			if (this.downsample > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.GLFCHEPLJEO.SetVector("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", new Vector2(1335f, 639f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				this.GLFCHEPLJEO.SetVector("warning: Audio Source: ", new Vector2(462f, 1852f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, this.GLFCHEPLJEO, 0);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.GLFCHEPLJEO.SetTexture("note.6", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GLFCHEPLJEO, 2);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06008095 RID: 32917 RVA: 0x002B68EC File Offset: 0x002B4AEC
		private void KKHCDAPLABD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Matrix4x4 projectionMatrix = base.GetComponent<Camera>().projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 value = new Vector4(1371f / ((float)Screen.width * projectionMatrix[0]), 1747f / ((float)Screen.height * projectionMatrix[5]), (858f - projectionMatrix[0]) / projectionMatrix[0], (1050f + projectionMatrix[4]) / projectionMatrix[1]);
			this.GLFCHEPLJEO.SetVector("Adding player twice: ", value);
			this.GLFCHEPLJEO.SetMatrix("RECORD [R]", inverse);
			this.GLFCHEPLJEO.SetTexture(": ", this.rand);
			this.GLFCHEPLJEO.SetFloat("_WaveIntensity", this.radius);
			this.GLFCHEPLJEO.SetFloat("/../", this.radius * this.radius);
			this.GLFCHEPLJEO.SetFloat("[Up]", this.intensity);
			this.GLFCHEPLJEO.SetFloat("To Log", this.blurFilterDistance);
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> (this.downsample & -10), height >> (this.downsample & 101));
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.GLFCHEPLJEO, 1);
			if (this.downsample > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 1; i < this.blurIterations; i++)
			{
				this.GLFCHEPLJEO.SetVector("Save level before uploading?", new Vector2(1216f, 663f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				this.GLFCHEPLJEO.SetVector("#failed!", new Vector2(1449f, 912f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, this.GLFCHEPLJEO, 0);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.GLFCHEPLJEO.SetTexture("_AdaptationMax", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GLFCHEPLJEO, 3);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x06008096 RID: 32918 RVA: 0x002B5C25 File Offset: 0x002B3E25
		private void FKEJGBFDCAH()
		{
			if (this.GLFCHEPLJEO)
			{
				UnityEngine.Object.DestroyImmediate(this.GLFCHEPLJEO);
			}
			this.GLFCHEPLJEO = null;
		}

		// Token: 0x06008097 RID: 32919 RVA: 0x002B5C25 File Offset: 0x002B3E25
		private void BJOHDLNDFAD()
		{
			if (this.GLFCHEPLJEO)
			{
				UnityEngine.Object.DestroyImmediate(this.GLFCHEPLJEO);
			}
			this.GLFCHEPLJEO = null;
		}

		// Token: 0x06008098 RID: 32920 RVA: 0x002B6B4F File Offset: 0x002B4D4F
		public virtual bool OOBHPBJOKMD()
		{
			base.DCHKKHDGBLJ(true);
			this.GLFCHEPLJEO = base.GJKHKCOAFDB(this.aoShader, this.GLFCHEPLJEO);
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008099 RID: 32921 RVA: 0x002B6B88 File Offset: 0x002B4D88
		private void LDIOANOMHMO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Matrix4x4 projectionMatrix = base.GetComponent<Camera>().projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 value = new Vector4(508f / ((float)Screen.width * projectionMatrix[1]), 1543f / ((float)Screen.height * projectionMatrix[1]), (593f - projectionMatrix[3]) / projectionMatrix[1], (879f + projectionMatrix[6]) / projectionMatrix[2]);
			this.GLFCHEPLJEO.SetVector("Attempting to remove texture that was not allocated: {0}", value);
			this.GLFCHEPLJEO.SetMatrix("ItemsCountText", inverse);
			this.GLFCHEPLJEO.SetTexture("_Value", this.rand);
			this.GLFCHEPLJEO.SetFloat("\\\\", this.radius);
			this.GLFCHEPLJEO.SetFloat("workshop.", this.radius * this.radius);
			this.GLFCHEPLJEO.SetFloat("_Luminance", this.intensity);
			this.GLFCHEPLJEO.SetFloat("_CenterX", this.blurFilterDistance);
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> (this.downsample & -54), height >> (this.downsample & 17));
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.GLFCHEPLJEO, 1);
			if (this.downsample > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 5);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.GLFCHEPLJEO.SetVector("_TimeX", new Vector2(1675f, 1099f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				this.GLFCHEPLJEO.SetVector("_Value3", new Vector2(1319f, 463f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, this.GLFCHEPLJEO, 0);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.GLFCHEPLJEO.SetTexture("RequestSelectedLevel", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GLFCHEPLJEO, 7);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x0600809A RID: 32922 RVA: 0x002B6DEB File Offset: 0x002B4FEB
		public override bool ILMGHBFANON()
		{
			base.FNIFJAENDIB(true);
			this.GLFCHEPLJEO = base.KDHKHOHMKCG(this.aoShader, this.GLFCHEPLJEO);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600809B RID: 32923 RVA: 0x002B5C25 File Offset: 0x002B3E25
		private void JNGMIAFLBDL()
		{
			if (this.GLFCHEPLJEO)
			{
				UnityEngine.Object.DestroyImmediate(this.GLFCHEPLJEO);
			}
			this.GLFCHEPLJEO = null;
		}

		// Token: 0x0600809C RID: 32924 RVA: 0x002B6E24 File Offset: 0x002B5024
		public virtual bool KMKBAOKOJDE()
		{
			base.KNGDKKMDKOG(true);
			this.GLFCHEPLJEO = base.EDFIBHNHAAB(this.aoShader, this.GLFCHEPLJEO);
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600809D RID: 32925 RVA: 0x002B5C25 File Offset: 0x002B3E25
		private void MGFFNGEGFDC()
		{
			if (this.GLFCHEPLJEO)
			{
				UnityEngine.Object.DestroyImmediate(this.GLFCHEPLJEO);
			}
			this.GLFCHEPLJEO = null;
		}

		// Token: 0x0600809E RID: 32926 RVA: 0x002B6E5D File Offset: 0x002B505D
		public virtual bool HDDNBPJGGFK()
		{
			base.KHNPMDDIJAJ(true);
			this.GLFCHEPLJEO = base.LKIJNGDHLAK(this.aoShader, this.GLFCHEPLJEO);
			if (!this.LMKGCBNNGLI)
			{
				base.GHNPJCMLCNB();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600809F RID: 32927 RVA: 0x002B5C25 File Offset: 0x002B3E25
		private void LOMDIOLNFHI()
		{
			if (this.GLFCHEPLJEO)
			{
				UnityEngine.Object.DestroyImmediate(this.GLFCHEPLJEO);
			}
			this.GLFCHEPLJEO = null;
		}

		// Token: 0x060080A0 RID: 32928 RVA: 0x002B5C25 File Offset: 0x002B3E25
		private void OnDisable()
		{
			if (this.GLFCHEPLJEO)
			{
				UnityEngine.Object.DestroyImmediate(this.GLFCHEPLJEO);
			}
			this.GLFCHEPLJEO = null;
		}

		// Token: 0x060080A1 RID: 32929 RVA: 0x002B5C25 File Offset: 0x002B3E25
		private void DFENCIHAADO()
		{
			if (this.GLFCHEPLJEO)
			{
				UnityEngine.Object.DestroyImmediate(this.GLFCHEPLJEO);
			}
			this.GLFCHEPLJEO = null;
		}

		// Token: 0x060080A2 RID: 32930 RVA: 0x002B6E98 File Offset: 0x002B5098
		private void NJFDLOBJCCF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Matrix4x4 projectionMatrix = base.GetComponent<Camera>().projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 value = new Vector4(905f / ((float)Screen.width * projectionMatrix[1]), 1040f / ((float)Screen.height * projectionMatrix[8]), (367f - projectionMatrix[4]) / projectionMatrix[1], (1440f + projectionMatrix[8]) / projectionMatrix[7]);
			this.GLFCHEPLJEO.SetVector("Drop_Floor_Fluid", value);
			this.GLFCHEPLJEO.SetMatrix("_TimeX", inverse);
			this.GLFCHEPLJEO.SetTexture(".sav", this.rand);
			this.GLFCHEPLJEO.SetFloat("_FarCamera", this.radius);
			this.GLFCHEPLJEO.SetFloat(". Our prefix is ", this.radius * this.radius);
			this.GLFCHEPLJEO.SetFloat("OnConnectedToMaster() was called by PUN. Now this client is connected and could join a room. Calling: PhotonNetwork.JoinRandomRoom();", this.intensity);
			this.GLFCHEPLJEO.SetFloat("The process failed: ", this.blurFilterDistance);
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> (this.downsample & 37), height >> (this.downsample & -16));
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.GLFCHEPLJEO, 0);
			if (this.downsample > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.GLFCHEPLJEO.SetVector(": ", new Vector2(155f, 1587f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				this.GLFCHEPLJEO.SetVector(" key(s)", new Vector2(343f, 448f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, this.GLFCHEPLJEO, 1);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.GLFCHEPLJEO.SetTexture("TimeBGSlider", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GLFCHEPLJEO, 4);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x060080A3 RID: 32931 RVA: 0x002B70FC File Offset: 0x002B52FC
		private void JBMEPDENLOM(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Matrix4x4 projectionMatrix = base.GetComponent<Camera>().projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 value = new Vector4(1049f / ((float)Screen.width * projectionMatrix[0]), 1103f / ((float)Screen.height * projectionMatrix[0]), (1569f - projectionMatrix[3]) / projectionMatrix[0], (743f + projectionMatrix[1]) / projectionMatrix[4]);
			this.GLFCHEPLJEO.SetVector("_Value2", value);
			this.GLFCHEPLJEO.SetMatrix("_TimeX", inverse);
			this.GLFCHEPLJEO.SetTexture("steamid", this.rand);
			this.GLFCHEPLJEO.SetFloat("LastHighScoreText", this.radius);
			this.GLFCHEPLJEO.SetFloat("DPADVER", this.radius * this.radius);
			this.GLFCHEPLJEO.SetFloat("[MapsData] Bad map: ", this.intensity);
			this.GLFCHEPLJEO.SetFloat("ArcsNoHitsoundTimeDelaySlider", this.blurFilterDistance);
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> (this.downsample & -33), height >> (this.downsample & -9));
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.GLFCHEPLJEO, 1);
			if (this.downsample > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.GLFCHEPLJEO.SetVector("CameraFilterPack_AAA_Blood2", new Vector2(951f, 1595f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				this.GLFCHEPLJEO.SetVector(".r", new Vector2(1516f, 1459f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, this.GLFCHEPLJEO, 0);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.GLFCHEPLJEO.SetTexture("Object ID. Case-Sensitive", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GLFCHEPLJEO, 5);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x060080A4 RID: 32932 RVA: 0x002B7360 File Offset: 0x002B5560
		private void EEFLHPENNEI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Matrix4x4 projectionMatrix = base.GetComponent<Camera>().projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 value = new Vector4(1604f / ((float)Screen.width * projectionMatrix[0]), 1316f / ((float)Screen.height * projectionMatrix[8]), (587f - projectionMatrix[7]) / projectionMatrix[1], (946f + projectionMatrix[1]) / projectionMatrix[4]);
			this.GLFCHEPLJEO.SetVector("restrictions\n\n#until: ", value);
			this.GLFCHEPLJEO.SetMatrix("Closes the app", inverse);
			this.GLFCHEPLJEO.SetTexture("HPText", this.rand);
			this.GLFCHEPLJEO.SetFloat("maps.", this.radius);
			this.GLFCHEPLJEO.SetFloat("_Value3", this.radius * this.radius);
			this.GLFCHEPLJEO.SetFloat("Tab1Content", this.intensity);
			this.GLFCHEPLJEO.SetFloat("_BlurredColor", this.blurFilterDistance);
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> (this.downsample & 110), height >> (this.downsample & 1));
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.GLFCHEPLJEO, 0);
			if (this.downsample > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 8);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 1; i < this.blurIterations; i += 0)
			{
				this.GLFCHEPLJEO.SetVector("OnReadyClick", new Vector2(1189f, 237f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				this.GLFCHEPLJEO.SetVector("_Value2", new Vector2(308f, 915f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, this.GLFCHEPLJEO, 0);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.GLFCHEPLJEO.SetTexture("22x3", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GLFCHEPLJEO, 7);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x060080A5 RID: 32933 RVA: 0x002B5C25 File Offset: 0x002B3E25
		private void PAEGLMEOKHP()
		{
			if (this.GLFCHEPLJEO)
			{
				UnityEngine.Object.DestroyImmediate(this.GLFCHEPLJEO);
			}
			this.GLFCHEPLJEO = null;
		}

		// Token: 0x060080A6 RID: 32934 RVA: 0x002B75C4 File Offset: 0x002B57C4
		private void AODKAMLEIOJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Matrix4x4 projectionMatrix = base.GetComponent<Camera>().projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 value = new Vector4(162f / ((float)Screen.width * projectionMatrix[0]), 463f / ((float)Screen.height * projectionMatrix[3]), (441f - projectionMatrix[4]) / projectionMatrix[1], (1844f + projectionMatrix[0]) / projectionMatrix[2]);
			this.GLFCHEPLJEO.SetVector("_ScreenResolution", value);
			this.GLFCHEPLJEO.SetMatrix("remaining: {0:0.000}", inverse);
			this.GLFCHEPLJEO.SetTexture("CameraFilterPack/Blend2Camera_DarkerColor", this.rand);
			this.GLFCHEPLJEO.SetFloat("Left Stick Click", this.radius);
			this.GLFCHEPLJEO.SetFloat("_Intensity", this.radius * this.radius);
			this.GLFCHEPLJEO.SetFloat("buttons", this.intensity);
			this.GLFCHEPLJEO.SetFloat("_Screen", this.blurFilterDistance);
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> (this.downsample & -64), height >> (this.downsample & 45));
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.GLFCHEPLJEO, 1);
			if (this.downsample > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 3);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				this.GLFCHEPLJEO.SetVector(" not exist", new Vector2(1437f, 1453f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				this.GLFCHEPLJEO.SetVector("_AdaptationSpeed", new Vector2(672f, 1560f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, this.GLFCHEPLJEO, 1);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.GLFCHEPLJEO.SetTexture("CameraFilterPack/Glasses_On", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GLFCHEPLJEO, 7);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x060080A7 RID: 32935 RVA: 0x002B5C25 File Offset: 0x002B3E25
		private void DPFOEBCADNP()
		{
			if (this.GLFCHEPLJEO)
			{
				UnityEngine.Object.DestroyImmediate(this.GLFCHEPLJEO);
			}
			this.GLFCHEPLJEO = null;
		}

		// Token: 0x060080A8 RID: 32936 RVA: 0x002B7827 File Offset: 0x002B5A27
		public virtual bool PHEIDFBDELF()
		{
			base.MBMLNJJEONO(false);
			this.GLFCHEPLJEO = base.NODBMINMALP(this.aoShader, this.GLFCHEPLJEO);
			if (!this.LMKGCBNNGLI)
			{
				base.FDGHGPOPOAK();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060080A9 RID: 32937 RVA: 0x002B5C25 File Offset: 0x002B3E25
		private void HGDDCINLDAD()
		{
			if (this.GLFCHEPLJEO)
			{
				UnityEngine.Object.DestroyImmediate(this.GLFCHEPLJEO);
			}
			this.GLFCHEPLJEO = null;
		}

		// Token: 0x060080AA RID: 32938 RVA: 0x002B5C25 File Offset: 0x002B3E25
		private void BNEJMABFKJE()
		{
			if (this.GLFCHEPLJEO)
			{
				UnityEngine.Object.DestroyImmediate(this.GLFCHEPLJEO);
			}
			this.GLFCHEPLJEO = null;
		}

		// Token: 0x060080AB RID: 32939 RVA: 0x002B5C25 File Offset: 0x002B3E25
		private void FPHLDMMAOEF()
		{
			if (this.GLFCHEPLJEO)
			{
				UnityEngine.Object.DestroyImmediate(this.GLFCHEPLJEO);
			}
			this.GLFCHEPLJEO = null;
		}

		// Token: 0x060080AC RID: 32940 RVA: 0x002B7860 File Offset: 0x002B5A60
		private void CENLKOLIACP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Matrix4x4 projectionMatrix = base.GetComponent<Camera>().projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 value = new Vector4(188f / ((float)Screen.width * projectionMatrix[0]), 549f / ((float)Screen.height * projectionMatrix[8]), (1583f - projectionMatrix[1]) / projectionMatrix[1], (1209f + projectionMatrix[6]) / projectionMatrix[3]);
			this.GLFCHEPLJEO.SetVector("#FFDA44", value);
			this.GLFCHEPLJEO.SetMatrix("_Speed", inverse);
			this.GLFCHEPLJEO.SetTexture("mapselector.tags.", this.rand);
			this.GLFCHEPLJEO.SetFloat("Connection error: ", this.radius);
			this.GLFCHEPLJEO.SetFloat("_ScreenResolution", this.radius * this.radius);
			this.GLFCHEPLJEO.SetFloat("MusicFileSelector", this.intensity);
			this.GLFCHEPLJEO.SetFloat("mapselector.orderby", this.blurFilterDistance);
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> (this.downsample & -108), height >> (this.downsample & -99));
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.GLFCHEPLJEO, 0);
			if (this.downsample > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 2);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				this.GLFCHEPLJEO.SetVector("CameraFilterPack/AAA_BloodOnScreen", new Vector2(1627f, 480f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				this.GLFCHEPLJEO.SetVector("HiddenToggle", new Vector2(211f, 1740f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, this.GLFCHEPLJEO, 1);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.GLFCHEPLJEO.SetTexture("_Color_G", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GLFCHEPLJEO, 5);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x060080AD RID: 32941 RVA: 0x002B7AC4 File Offset: 0x002B5CC4
		private void KMAPABACMAG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Matrix4x4 projectionMatrix = base.GetComponent<Camera>().projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 value = new Vector4(1288f / ((float)Screen.width * projectionMatrix[0]), 1130f / ((float)Screen.height * projectionMatrix[6]), (1561f - projectionMatrix[8]) / projectionMatrix[1], (1916f + projectionMatrix[0]) / projectionMatrix[8]);
			this.GLFCHEPLJEO.SetVector(" ", value);
			this.GLFCHEPLJEO.SetMatrix("HightScoreMaxPointsText", inverse);
			this.GLFCHEPLJEO.SetTexture("shader.sunny", this.rand);
			this.GLFCHEPLJEO.SetFloat("HightScoreMaxPointsText", this.radius);
			this.GLFCHEPLJEO.SetFloat("CameraFilterPack/Blend2Camera_Exclusion", this.radius * this.radius);
			this.GLFCHEPLJEO.SetFloat("GO==null", this.intensity);
			this.GLFCHEPLJEO.SetFloat("0.000", this.blurFilterDistance);
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> (this.downsample & 124), height >> (this.downsample & -114));
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.GLFCHEPLJEO, 0);
			if (this.downsample > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 6);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.GLFCHEPLJEO.SetVector("_Value5", new Vector2(1789f, 1615f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				this.GLFCHEPLJEO.SetVector("CameraFilterPack/EyesVision_2", new Vector2(1139f, 309f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, this.GLFCHEPLJEO, 1);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.GLFCHEPLJEO.SetTexture("Backward", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GLFCHEPLJEO, 4);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x060080AE RID: 32942 RVA: 0x002B7D28 File Offset: 0x002B5F28
		private void PLHMAOMGFMF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Matrix4x4 projectionMatrix = base.GetComponent<Camera>().projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 value = new Vector4(1226f / ((float)Screen.width * projectionMatrix[0]), 44f / ((float)Screen.height * projectionMatrix[6]), (1048f - projectionMatrix[8]) / projectionMatrix[0], (601f + projectionMatrix[2]) / projectionMatrix[6]);
			this.GLFCHEPLJEO.SetVector("(\\[ */ *h1 *\\])", value);
			this.GLFCHEPLJEO.SetMatrix("mapselector.filter.subscribedonly", inverse);
			this.GLFCHEPLJEO.SetTexture("CameraFilterPack/Edge_Sobel", this.rand);
			this.GLFCHEPLJEO.SetFloat("_Radius2", this.radius);
			this.GLFCHEPLJEO.SetFloat(".save", this.radius * this.radius);
			this.GLFCHEPLJEO.SetFloat("Hidden/DepthOfField/MedianFilter", this.intensity);
			this.GLFCHEPLJEO.SetFloat("-1", this.blurFilterDistance);
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> (this.downsample & 88), height >> (this.downsample & -9));
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.GLFCHEPLJEO, 1);
			if (this.downsample > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 7);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 0; i < this.blurIterations; i += 0)
			{
				this.GLFCHEPLJEO.SetVector("ticket", new Vector2(1669f, 810f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 0);
				RenderTexture.ReleaseTemporary(renderTexture);
				this.GLFCHEPLJEO.SetVector("colorD", new Vector2(776f, 65f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, this.GLFCHEPLJEO, 0);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.GLFCHEPLJEO.SetTexture("ItemNameBGImage", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GLFCHEPLJEO, 0);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x060080AF RID: 32943 RVA: 0x002B5C25 File Offset: 0x002B3E25
		private void ICDBMJKMIKC()
		{
			if (this.GLFCHEPLJEO)
			{
				UnityEngine.Object.DestroyImmediate(this.GLFCHEPLJEO);
			}
			this.GLFCHEPLJEO = null;
		}

		// Token: 0x060080B0 RID: 32944 RVA: 0x002B5C25 File Offset: 0x002B3E25
		private void GPHPJIDGEPI()
		{
			if (this.GLFCHEPLJEO)
			{
				UnityEngine.Object.DestroyImmediate(this.GLFCHEPLJEO);
			}
			this.GLFCHEPLJEO = null;
		}

		// Token: 0x060080B1 RID: 32945 RVA: 0x002B7F8B File Offset: 0x002B618B
		public override bool CheckResources()
		{
			base.NPOEJIDLJGK(true);
			this.GLFCHEPLJEO = base.EDFIBHNHAAB(this.aoShader, this.GLFCHEPLJEO);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x060080B2 RID: 32946 RVA: 0x002B7FC4 File Offset: 0x002B61C4
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Matrix4x4 projectionMatrix = base.GetComponent<Camera>().projectionMatrix;
			Matrix4x4 inverse = projectionMatrix.inverse;
			Vector4 value = new Vector4(-2f / ((float)Screen.width * projectionMatrix[0]), -2f / ((float)Screen.height * projectionMatrix[5]), (1f - projectionMatrix[2]) / projectionMatrix[0], (1f + projectionMatrix[6]) / projectionMatrix[5]);
			this.GLFCHEPLJEO.SetVector("_ProjInfo", value);
			this.GLFCHEPLJEO.SetMatrix("_ProjectionInv", inverse);
			this.GLFCHEPLJEO.SetTexture("_Rand", this.rand);
			this.GLFCHEPLJEO.SetFloat("_Radius", this.radius);
			this.GLFCHEPLJEO.SetFloat("_Radius2", this.radius * this.radius);
			this.GLFCHEPLJEO.SetFloat("_Intensity", this.intensity);
			this.GLFCHEPLJEO.SetFloat("_BlurFilterDistance", this.blurFilterDistance);
			int width = HLBKCLPNHEB.width;
			int height = HLBKCLPNHEB.height;
			RenderTexture renderTexture = RenderTexture.GetTemporary(width >> this.downsample, height >> this.downsample);
			Graphics.Blit(HLBKCLPNHEB, renderTexture, this.GLFCHEPLJEO, 0);
			if (this.downsample > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 4);
				RenderTexture.ReleaseTemporary(renderTexture);
				renderTexture = temporary;
			}
			for (int i = 0; i < this.blurIterations; i++)
			{
				this.GLFCHEPLJEO.SetVector("_Axis", new Vector2(1f, 0f));
				RenderTexture temporary = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(renderTexture, temporary, this.GLFCHEPLJEO, 1);
				RenderTexture.ReleaseTemporary(renderTexture);
				this.GLFCHEPLJEO.SetVector("_Axis", new Vector2(0f, 1f));
				renderTexture = RenderTexture.GetTemporary(width, height);
				Graphics.Blit(temporary, renderTexture, this.GLFCHEPLJEO, 1);
				RenderTexture.ReleaseTemporary(temporary);
			}
			this.GLFCHEPLJEO.SetTexture("_AOTex", renderTexture);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.GLFCHEPLJEO, 2);
			RenderTexture.ReleaseTemporary(renderTexture);
		}

		// Token: 0x060080B3 RID: 32947 RVA: 0x002B8227 File Offset: 0x002B6427
		public virtual bool BCDIEBGNBEG()
		{
			base.FNIFJAENDIB(true);
			this.GLFCHEPLJEO = base.LKIJNGDHLAK(this.aoShader, this.GLFCHEPLJEO);
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x04000E58 RID: 3672
		[Range(0f, 3f)]
		public float intensity = 0.5f;

		// Token: 0x04000E59 RID: 3673
		[Range(0.1f, 3f)]
		public float radius = 0.2f;

		// Token: 0x04000E5A RID: 3674
		[Range(0f, 3f)]
		public int blurIterations = 1;

		// Token: 0x04000E5B RID: 3675
		[Range(0f, 5f)]
		public float blurFilterDistance = 1.25f;

		// Token: 0x04000E5C RID: 3676
		[Range(0f, 1f)]
		public int downsample;

		// Token: 0x04000E5D RID: 3677
		public Texture2D rand;

		// Token: 0x04000E5E RID: 3678
		public Shader aoShader;

		// Token: 0x04000E5F RID: 3679
		private Material GLFCHEPLJEO;
	}
}
