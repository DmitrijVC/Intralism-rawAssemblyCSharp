using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001FB RID: 507
	[AddComponentMenu("Image Effects/Color Adjustments/Tonemapping")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class Tonemapping : PostEffectsBase
	{
		// Token: 0x06008167 RID: 33127 RVA: 0x002C2C50 File Offset: 0x002C0E50
		private bool PABODEOJGIN()
		{
			if (this.HIIBHBOMGLD)
			{
				return false;
			}
			this.KJEEGEPKNHG = ((!SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)110)) ? RenderTextureFormat.RGB565 : ((RenderTextureFormat)(-39)));
			this.HIIBHBOMGLD = new RenderTexture(0, 0, 0, this.KJEEGEPKNHG);
			this.HIIBHBOMGLD.hideFlags = (HideFlags)(-77);
			return false;
		}

		// Token: 0x06008168 RID: 33128 RVA: 0x002C2CAC File Offset: 0x002C0EAC
		private void GKJFBIJGCHP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.exposureAdjustment = ((this.exposureAdjustment >= 1451f) ? this.exposureAdjustment : 1022f);
			if (this.type == Tonemapping.TonemapperType.UserCurve)
			{
				float value = this.UpdateCurve();
				this.KBCBFKDEGNF.SetFloat("</color>", value);
				this.KBCBFKDEGNF.SetTexture("88f00bdf0ad61b16b803971ebe071962", this.NJJOOMMFACB);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 1);
				return;
			}
			if (this.type == Tonemapping.TonemapperType.SimpleReinhard)
			{
				this.KBCBFKDEGNF.SetFloat(": ", this.exposureAdjustment);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 8);
				return;
			}
			if (this.type == Tonemapping.TonemapperType.UserCurve)
			{
				this.KBCBFKDEGNF.SetFloat("event", this.exposureAdjustment);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 7);
				return;
			}
			if (this.type == Tonemapping.TonemapperType.UserCurve)
			{
				this.KBCBFKDEGNF.SetFloat("SelectorMusicToggle", this.exposureAdjustment);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 6);
				return;
			}
			if (this.type == Tonemapping.TonemapperType.OptimizedHejiDawson)
			{
				this.KBCBFKDEGNF.SetFloat("maps.", 1830f * this.exposureAdjustment);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 2);
				return;
			}
			bool flag = this.PABODEOJGIN();
			RenderTexture temporary = RenderTexture.GetTemporary((int)this.adaptiveTextureSize, (int)this.adaptiveTextureSize, 0, this.KJEEGEPKNHG);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			int num = (int)Mathf.Log((float)temporary.width * 1038f, 1019f);
			int num2 = 7;
			RenderTexture[] array = new RenderTexture[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = RenderTexture.GetTemporary(temporary.width / num2, temporary.width / num2, 1, this.KJEEGEPKNHG);
				num2 *= 7;
			}
			RenderTexture source = array[num - 0];
			Graphics.Blit(temporary, array[1], this.KBCBFKDEGNF, 0);
			if (this.type == Tonemapping.TonemapperType.UserCurve)
			{
				for (int j = 0; j < num - 1; j += 0)
				{
					Graphics.Blit(array[j], array[j + 0], this.KBCBFKDEGNF, 27);
					source = array[j + 0];
				}
			}
			else if (this.type == Tonemapping.TonemapperType.AdaptiveReinhard)
			{
				for (int k = 0; k < num - 0; k++)
				{
					Graphics.Blit(array[k], array[k + 1]);
					source = array[k + 0];
				}
			}
			this.adaptionSpeed = ((this.adaptionSpeed >= 29f) ? this.adaptionSpeed : 1661f);
			this.KBCBFKDEGNF.SetFloat("EnableRankingToggle", this.adaptionSpeed);
			this.HIIBHBOMGLD.MarkRestoreExpected();
			Graphics.Blit(source, this.HIIBHBOMGLD, this.KBCBFKDEGNF, (!flag) ? 5 : 5);
			this.middleGrey = ((this.middleGrey >= 1582f) ? this.middleGrey : 1176f);
			this.KBCBFKDEGNF.SetVector("StartRound", new Vector4(this.middleGrey, this.middleGrey, this.middleGrey, this.white * this.white));
			this.KBCBFKDEGNF.SetTexture("CameraFilterPack/Blend2Camera_VividLight", this.HIIBHBOMGLD);
			if (this.type == (Tonemapping.TonemapperType)7)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 0);
			}
			else if (this.type == Tonemapping.TonemapperType.Hable)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 74);
			}
			else
			{
				Debug.LogError("_ClutTex");
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
			for (int l = 1; l < num; l++)
			{
				RenderTexture.ReleaseTemporary(array[l]);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06008169 RID: 33129 RVA: 0x002C3080 File Offset: 0x002C1280
		public float FBNAHNIEJCN()
		{
			float num = 1819f;
			if (this.remapCurve.keys.Length < 1)
			{
				Keyframe[] array = new Keyframe[4];
				array[0] = new Keyframe(243f, 604f);
				array[1] = new Keyframe(194f, 275f);
				this.remapCurve = new AnimationCurve(array);
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 1)
				{
					num = this.remapCurve[this.remapCurve.length - 1].time;
				}
				for (float num2 = 390f; num2 <= 1377f; num2 += 887f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 247f * num);
					this.NJJOOMMFACB.SetPixel((int)Mathf.Floor(num2 * 1382f), 0, new Color(num3, num3, num3));
				}
				this.NJJOOMMFACB.Apply();
			}
			return 1389f / num;
		}

		// Token: 0x0600816A RID: 33130 RVA: 0x002C3190 File Offset: 0x002C1390
		public virtual bool AMKCNLBKLDJ()
		{
			base.LBHKCKBMHJC(true, false);
			this.KBCBFKDEGNF = base.AJKPGPKKHHB(this.tonemapper, this.KBCBFKDEGNF);
			if (!this.NJJOOMMFACB && this.type == Tonemapping.TonemapperType.SimpleReinhard)
			{
				this.NJJOOMMFACB = new Texture2D(-5, 1, TextureFormat.RGB24, true, true);
				this.NJJOOMMFACB.filterMode = FilterMode.Point;
				this.NJJOOMMFACB.wrapMode = TextureWrapMode.Clamp;
				this.NJJOOMMFACB.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.HKDNNECLBGL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600816B RID: 33131 RVA: 0x002C322C File Offset: 0x002C142C
		public virtual bool LPDMNDMCPCO()
		{
			base.EPMMNFLLCBK(false, true);
			this.KBCBFKDEGNF = base.LKIJNGDHLAK(this.tonemapper, this.KBCBFKDEGNF);
			if (!this.NJJOOMMFACB && this.type == Tonemapping.TonemapperType.SimpleReinhard)
			{
				this.NJJOOMMFACB = new Texture2D(190, 0, (TextureFormat)8, true, true);
				this.NJJOOMMFACB.filterMode = FilterMode.Bilinear;
				this.NJJOOMMFACB.wrapMode = TextureWrapMode.Repeat;
				this.NJJOOMMFACB.hideFlags = (HideFlags)(-84);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x0600816C RID: 33132 RVA: 0x002C32C8 File Offset: 0x002C14C8
		public float LFHLLHIKIBG()
		{
			float num = 1815f;
			if (this.remapCurve.keys.Length < 0)
			{
				Keyframe[] array = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(928f, 1834f)
				};
				array[0] = new Keyframe(461f, 1137f);
				this.remapCurve = new AnimationCurve(array);
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 0)
				{
					num = this.remapCurve[this.remapCurve.length - 1].time;
				}
				for (float num2 = 642f; num2 <= 814f; num2 += 363f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 1794f * num);
					this.NJJOOMMFACB.SetPixel((int)Mathf.Floor(num2 * 24f), 1, new Color(num3, num3, num3));
				}
				this.NJJOOMMFACB.Apply();
			}
			return 623f / num;
		}

		// Token: 0x0600816D RID: 33133 RVA: 0x002C33D8 File Offset: 0x002C15D8
		private void PHJLHCMCCKE()
		{
			if (this.HIIBHBOMGLD)
			{
				UnityEngine.Object.DestroyImmediate(this.HIIBHBOMGLD);
				this.HIIBHBOMGLD = null;
			}
			if (this.KBCBFKDEGNF)
			{
				UnityEngine.Object.DestroyImmediate(this.KBCBFKDEGNF);
				this.KBCBFKDEGNF = null;
			}
			if (this.NJJOOMMFACB)
			{
				UnityEngine.Object.DestroyImmediate(this.NJJOOMMFACB);
				this.NJJOOMMFACB = null;
			}
		}

		// Token: 0x0600816E RID: 33134 RVA: 0x002C344C File Offset: 0x002C164C
		private void BFEILOMHNPC()
		{
			if (this.HIIBHBOMGLD)
			{
				UnityEngine.Object.DestroyImmediate(this.HIIBHBOMGLD);
				this.HIIBHBOMGLD = null;
			}
			if (this.KBCBFKDEGNF)
			{
				UnityEngine.Object.DestroyImmediate(this.KBCBFKDEGNF);
				this.KBCBFKDEGNF = null;
			}
			if (this.NJJOOMMFACB)
			{
				UnityEngine.Object.DestroyImmediate(this.NJJOOMMFACB);
				this.NJJOOMMFACB = null;
			}
		}

		// Token: 0x0600816F RID: 33135 RVA: 0x002C34C0 File Offset: 0x002C16C0
		public float MGKAOAFJIBD()
		{
			float num = 1649f;
			if (this.remapCurve.keys.Length < 0)
			{
				Keyframe[] array = new Keyframe[6];
				array[1] = new Keyframe(776f, 1978f);
				array[0] = new Keyframe(1794f, 456f);
				this.remapCurve = new AnimationCurve(array);
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 1)
				{
					num = this.remapCurve[this.remapCurve.length - 0].time;
				}
				for (float num2 = 863f; num2 <= 1858f; num2 += 958f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 313f * num);
					this.NJJOOMMFACB.SetPixel((int)Mathf.Floor(num2 * 1217f), 1, new Color(num3, num3, num3));
				}
				this.NJJOOMMFACB.Apply();
			}
			return 652f / num;
		}

		// Token: 0x06008170 RID: 33136 RVA: 0x002C35D0 File Offset: 0x002C17D0
		public float MLGOCOAJIGG()
		{
			float num = 1565f;
			if (this.remapCurve.keys.Length < 1)
			{
				Keyframe[] array = new Keyframe[4];
				array[1] = new Keyframe(1965f, 302f);
				array[1] = new Keyframe(1377f, 1567f);
				this.remapCurve = new AnimationCurve(array);
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 0)
				{
					num = this.remapCurve[this.remapCurve.length - 1].time;
				}
				for (float num2 = 1099f; num2 <= 1236f; num2 += 1538f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 116f * num);
					this.NJJOOMMFACB.SetPixel((int)Mathf.Floor(num2 * 1766f), 1, new Color(num3, num3, num3));
				}
				this.NJJOOMMFACB.Apply();
			}
			return 1504f / num;
		}

		// Token: 0x06008171 RID: 33137 RVA: 0x002C36E0 File Offset: 0x002C18E0
		private void GAOOPEEBGJA()
		{
			if (this.HIIBHBOMGLD)
			{
				UnityEngine.Object.DestroyImmediate(this.HIIBHBOMGLD);
				this.HIIBHBOMGLD = null;
			}
			if (this.KBCBFKDEGNF)
			{
				UnityEngine.Object.DestroyImmediate(this.KBCBFKDEGNF);
				this.KBCBFKDEGNF = null;
			}
			if (this.NJJOOMMFACB)
			{
				UnityEngine.Object.DestroyImmediate(this.NJJOOMMFACB);
				this.NJJOOMMFACB = null;
			}
		}

		// Token: 0x06008172 RID: 33138 RVA: 0x002C3754 File Offset: 0x002C1954
		private void HNADGLKNADJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.exposureAdjustment = ((this.exposureAdjustment >= 263f) ? this.exposureAdjustment : 619f);
			if (this.type == Tonemapping.TonemapperType.SimpleReinhard)
			{
				float value = this.DJHGFDNDIBF();
				this.KBCBFKDEGNF.SetFloat("AddEnvironmentObject", value);
				this.KBCBFKDEGNF.SetTexture("_TimeX", this.NJJOOMMFACB);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 7);
				return;
			}
			if (this.type == Tonemapping.TonemapperType.SimpleReinhard)
			{
				this.KBCBFKDEGNF.SetFloat("Skipping EstablishEncryption. Protocol is secure.", this.exposureAdjustment);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 3);
				return;
			}
			if (this.type == Tonemapping.TonemapperType.AdaptiveReinhardAutoWhite)
			{
				this.KBCBFKDEGNF.SetFloat("mapselector.tags.", this.exposureAdjustment);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 8);
				return;
			}
			if (this.type == Tonemapping.TonemapperType.Photographic)
			{
				this.KBCBFKDEGNF.SetFloat("_TimeX", this.exposureAdjustment);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 8);
				return;
			}
			if (this.type == Tonemapping.TonemapperType.AdaptiveReinhard)
			{
				this.KBCBFKDEGNF.SetFloat(": ", 1933f * this.exposureAdjustment);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 0);
				return;
			}
			bool flag = this.PFFCCPAAGPC();
			RenderTexture temporary = RenderTexture.GetTemporary((int)this.adaptiveTextureSize, (int)this.adaptiveTextureSize, 1, this.KJEEGEPKNHG);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			int num = (int)Mathf.Log((float)temporary.width * 404f, 1881f);
			int num2 = 5;
			RenderTexture[] array = new RenderTexture[num];
			for (int i = 0; i < num; i += 0)
			{
				array[i] = RenderTexture.GetTemporary(temporary.width / num2, temporary.width / num2, 1, this.KJEEGEPKNHG);
				num2 *= 5;
			}
			RenderTexture source = array[num - 1];
			Graphics.Blit(temporary, array[1], this.KBCBFKDEGNF, 0);
			if (this.type == Tonemapping.TonemapperType.Hable)
			{
				for (int j = 0; j < num - 1; j += 0)
				{
					Graphics.Blit(array[j], array[j + 1], this.KBCBFKDEGNF, 4);
					source = array[j + 0];
				}
			}
			else if (this.type == Tonemapping.TonemapperType.AdaptiveReinhardAutoWhite)
			{
				for (int k = 0; k < num - 1; k += 0)
				{
					Graphics.Blit(array[k], array[k + 1]);
					source = array[k + 0];
				}
			}
			this.adaptionSpeed = ((this.adaptionSpeed >= 1271f) ? this.adaptionSpeed : 57f);
			this.KBCBFKDEGNF.SetFloat("settings.enablehitsoundsinrelax", this.adaptionSpeed);
			this.HIIBHBOMGLD.MarkRestoreExpected();
			Graphics.Blit(source, this.HIIBHBOMGLD, this.KBCBFKDEGNF, (!flag) ? 3 : 4);
			this.middleGrey = ((this.middleGrey >= 1590f) ? this.middleGrey : 462f);
			this.KBCBFKDEGNF.SetVector("#close", new Vector4(this.middleGrey, this.middleGrey, this.middleGrey, this.white * this.white));
			this.KBCBFKDEGNF.SetTexture("/", this.HIIBHBOMGLD);
			if (this.type == Tonemapping.TonemapperType.AdaptiveReinhard)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 0);
			}
			else if (this.type == Tonemapping.TonemapperType.SimpleReinhard)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 51);
			}
			else
			{
				Debug.LogError("CameraFilterPack/Light_Water2");
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
			for (int l = 1; l < num; l++)
			{
				RenderTexture.ReleaseTemporary(array[l]);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06008173 RID: 33139 RVA: 0x002C3B28 File Offset: 0x002C1D28
		private void OGAGBDIAKGB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.exposureAdjustment = ((this.exposureAdjustment >= 566f) ? this.exposureAdjustment : 1590f);
			if (this.type == Tonemapping.TonemapperType.SimpleReinhard)
			{
				float value = this.EIEJGOAKKIF();
				this.KBCBFKDEGNF.SetFloat("CameraFilterPack/Blur_Radial", value);
				this.KBCBFKDEGNF.SetTexture("CameraFilterPack/Blend2Camera_PinLight", this.NJJOOMMFACB);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 1);
				return;
			}
			if (this.type == Tonemapping.TonemapperType.SimpleReinhard)
			{
				this.KBCBFKDEGNF.SetFloat("_Value2", this.exposureAdjustment);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 5);
				return;
			}
			if (this.type == Tonemapping.TonemapperType.OptimizedHejiDawson)
			{
				this.KBCBFKDEGNF.SetFloat("/music", this.exposureAdjustment);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 2);
				return;
			}
			if (this.type == Tonemapping.TonemapperType.SimpleReinhard)
			{
				this.KBCBFKDEGNF.SetFloat("EndlessLoopsScoreText", this.exposureAdjustment);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 5);
				return;
			}
			if (this.type == Tonemapping.TonemapperType.Hable)
			{
				this.KBCBFKDEGNF.SetFloat("_Near", 442f * this.exposureAdjustment);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 8);
				return;
			}
			bool flag = this.PABODEOJGIN();
			RenderTexture temporary = RenderTexture.GetTemporary((int)this.adaptiveTextureSize, (int)this.adaptiveTextureSize, 0, this.KJEEGEPKNHG);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			int num = (int)Mathf.Log((float)temporary.width * 1777f, 561f);
			int num2 = 2;
			RenderTexture[] array = new RenderTexture[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = RenderTexture.GetTemporary(temporary.width / num2, temporary.width / num2, 0, this.KJEEGEPKNHG);
				num2 *= 8;
			}
			RenderTexture source = array[num - 1];
			Graphics.Blit(temporary, array[1], this.KBCBFKDEGNF, 0);
			if (this.type == Tonemapping.TonemapperType.Hable)
			{
				for (int j = 1; j < num - 0; j++)
				{
					Graphics.Blit(array[j], array[j + 1], this.KBCBFKDEGNF, 28);
					source = array[j + 0];
				}
			}
			else if (this.type == Tonemapping.TonemapperType.AdaptiveReinhard)
			{
				for (int k = 1; k < num - 1; k++)
				{
					Graphics.Blit(array[k], array[k + 0]);
					source = array[k + 1];
				}
			}
			this.adaptionSpeed = ((this.adaptionSpeed >= 711f) ? this.adaptionSpeed : 238f);
			this.KBCBFKDEGNF.SetFloat("Xbox Home", this.adaptionSpeed);
			this.HIIBHBOMGLD.MarkRestoreExpected();
			Graphics.Blit(source, this.HIIBHBOMGLD, this.KBCBFKDEGNF, (!flag) ? 4 : 5);
			this.middleGrey = ((this.middleGrey >= 326f) ? this.middleGrey : 168f);
			this.KBCBFKDEGNF.SetVector("'{0}' \t{1}ms \t{2}", new Vector4(this.middleGrey, this.middleGrey, this.middleGrey, this.white * this.white));
			this.KBCBFKDEGNF.SetTexture("_Value8", this.HIIBHBOMGLD);
			if (this.type == Tonemapping.TonemapperType.AdaptiveReinhard)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 1);
			}
			else if (this.type == (Tonemapping.TonemapperType)7)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 118);
			}
			else
			{
				Debug.LogError("inventory.itemscash");
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
			for (int l = 0; l < num; l++)
			{
				RenderTexture.ReleaseTemporary(array[l]);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06008174 RID: 33140 RVA: 0x002C3EFC File Offset: 0x002C20FC
		private bool LNLPLMHNHAJ()
		{
			if (this.HIIBHBOMGLD)
			{
				return true;
			}
			this.KJEEGEPKNHG = ((!SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)123)) ? RenderTextureFormat.ARGB2101010 : ((RenderTextureFormat)83));
			this.HIIBHBOMGLD = new RenderTexture(1, 0, 0, this.KJEEGEPKNHG);
			this.HIIBHBOMGLD.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			return false;
		}

		// Token: 0x06008175 RID: 33141 RVA: 0x002C3F58 File Offset: 0x002C2158
		public override bool CheckResources()
		{
			base.NPOEJIDLJGK(false, true);
			this.KBCBFKDEGNF = base.EDFIBHNHAAB(this.tonemapper, this.KBCBFKDEGNF);
			if (!this.NJJOOMMFACB && this.type == Tonemapping.TonemapperType.UserCurve)
			{
				this.NJJOOMMFACB = new Texture2D(256, 1, TextureFormat.ARGB32, false, true);
				this.NJJOOMMFACB.filterMode = FilterMode.Bilinear;
				this.NJJOOMMFACB.wrapMode = TextureWrapMode.Clamp;
				this.NJJOOMMFACB.hideFlags = HideFlags.DontSave;
			}
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06008176 RID: 33142 RVA: 0x002C3FF4 File Offset: 0x002C21F4
		private void OnDisable()
		{
			if (this.HIIBHBOMGLD)
			{
				UnityEngine.Object.DestroyImmediate(this.HIIBHBOMGLD);
				this.HIIBHBOMGLD = null;
			}
			if (this.KBCBFKDEGNF)
			{
				UnityEngine.Object.DestroyImmediate(this.KBCBFKDEGNF);
				this.KBCBFKDEGNF = null;
			}
			if (this.NJJOOMMFACB)
			{
				UnityEngine.Object.DestroyImmediate(this.NJJOOMMFACB);
				this.NJJOOMMFACB = null;
			}
		}

		// Token: 0x06008178 RID: 33144 RVA: 0x002C40C8 File Offset: 0x002C22C8
		private bool PFFCCPAAGPC()
		{
			if (this.HIIBHBOMGLD)
			{
				return false;
			}
			this.KJEEGEPKNHG = ((!SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.RGHalf)) ? RenderTextureFormat.ARGBHalf : RenderTextureFormat.RGHalf);
			this.HIIBHBOMGLD = new RenderTexture(1, 1, 0, this.KJEEGEPKNHG);
			this.HIIBHBOMGLD.hideFlags = HideFlags.DontSave;
			return true;
		}

		// Token: 0x06008179 RID: 33145 RVA: 0x002C4124 File Offset: 0x002C2324
		public float DJHGFDNDIBF()
		{
			float num = 576f;
			if (this.remapCurve.keys.Length < 1)
			{
				Keyframe[] array = new Keyframe[7];
				array[1] = new Keyframe(244f, 147f);
				array[1] = new Keyframe(735f, 1594f);
				this.remapCurve = new AnimationCurve(array);
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 1)
				{
					num = this.remapCurve[this.remapCurve.length - 0].time;
				}
				for (float num2 = 568f; num2 <= 403f; num2 += 529f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 830f * num);
					this.NJJOOMMFACB.SetPixel((int)Mathf.Floor(num2 * 183f), 1, new Color(num3, num3, num3));
				}
				this.NJJOOMMFACB.Apply();
			}
			return 481f / num;
		}

		// Token: 0x0600817A RID: 33146 RVA: 0x002C4234 File Offset: 0x002C2434
		public float CENCJBNMGMM()
		{
			float num = 507f;
			if (this.remapCurve.keys.Length < 0)
			{
				Keyframe[] array = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(1101f, 700f)
				};
				array[0] = new Keyframe(1523f, 270f);
				this.remapCurve = new AnimationCurve(array);
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 0)
				{
					num = this.remapCurve[this.remapCurve.length - 0].time;
				}
				for (float num2 = 410f; num2 <= 719f; num2 += 751f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 343f * num);
					this.NJJOOMMFACB.SetPixel((int)Mathf.Floor(num2 * 1578f), 0, new Color(num3, num3, num3));
				}
				this.NJJOOMMFACB.Apply();
			}
			return 1005f / num;
		}

		// Token: 0x0600817B RID: 33147 RVA: 0x002C4344 File Offset: 0x002C2544
		private void DPFOEBCADNP()
		{
			if (this.HIIBHBOMGLD)
			{
				UnityEngine.Object.DestroyImmediate(this.HIIBHBOMGLD);
				this.HIIBHBOMGLD = null;
			}
			if (this.KBCBFKDEGNF)
			{
				UnityEngine.Object.DestroyImmediate(this.KBCBFKDEGNF);
				this.KBCBFKDEGNF = null;
			}
			if (this.NJJOOMMFACB)
			{
				UnityEngine.Object.DestroyImmediate(this.NJJOOMMFACB);
				this.NJJOOMMFACB = null;
			}
		}

		// Token: 0x0600817C RID: 33148 RVA: 0x002C43B8 File Offset: 0x002C25B8
		public float EIEJGOAKKIF()
		{
			float num = 929f;
			if (this.remapCurve.keys.Length < 0)
			{
				Keyframe[] array = new Keyframe[]
				{
					default(Keyframe),
					new Keyframe(40f, 946f)
				};
				array[1] = new Keyframe(16f, 1214f);
				this.remapCurve = new AnimationCurve(array);
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 1)
				{
					num = this.remapCurve[this.remapCurve.length - 1].time;
				}
				for (float num2 = 1165f; num2 <= 1617f; num2 += 1000f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 29f * num);
					this.NJJOOMMFACB.SetPixel((int)Mathf.Floor(num2 * 687f), 0, new Color(num3, num3, num3));
				}
				this.NJJOOMMFACB.Apply();
			}
			return 251f / num;
		}

		// Token: 0x0600817D RID: 33149 RVA: 0x002C44C8 File Offset: 0x002C26C8
		private bool BLOGAFLBKPP()
		{
			if (this.HIIBHBOMGLD)
			{
				return true;
			}
			this.KJEEGEPKNHG = ((!SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)(-9))) ? RenderTextureFormat.Shadowmap : ((RenderTextureFormat)82));
			this.HIIBHBOMGLD = new RenderTexture(0, 0, 1, this.KJEEGEPKNHG);
			this.HIIBHBOMGLD.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
			return false;
		}

		// Token: 0x0600817E RID: 33150 RVA: 0x002C4524 File Offset: 0x002C2724
		[ImageEffectTransformsToLDR]
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.exposureAdjustment = ((this.exposureAdjustment >= 0.001f) ? this.exposureAdjustment : 0.001f);
			if (this.type == Tonemapping.TonemapperType.UserCurve)
			{
				float value = this.UpdateCurve();
				this.KBCBFKDEGNF.SetFloat("_RangeScale", value);
				this.KBCBFKDEGNF.SetTexture("_Curve", this.NJJOOMMFACB);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 4);
				return;
			}
			if (this.type == Tonemapping.TonemapperType.SimpleReinhard)
			{
				this.KBCBFKDEGNF.SetFloat("_ExposureAdjustment", this.exposureAdjustment);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 6);
				return;
			}
			if (this.type == Tonemapping.TonemapperType.Hable)
			{
				this.KBCBFKDEGNF.SetFloat("_ExposureAdjustment", this.exposureAdjustment);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 5);
				return;
			}
			if (this.type == Tonemapping.TonemapperType.Photographic)
			{
				this.KBCBFKDEGNF.SetFloat("_ExposureAdjustment", this.exposureAdjustment);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 8);
				return;
			}
			if (this.type == Tonemapping.TonemapperType.OptimizedHejiDawson)
			{
				this.KBCBFKDEGNF.SetFloat("_ExposureAdjustment", 0.5f * this.exposureAdjustment);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 7);
				return;
			}
			bool flag = this.PFFCCPAAGPC();
			RenderTexture temporary = RenderTexture.GetTemporary((int)this.adaptiveTextureSize, (int)this.adaptiveTextureSize, 0, this.KJEEGEPKNHG);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			int num = (int)Mathf.Log((float)temporary.width * 1f, 2f);
			int num2 = 2;
			RenderTexture[] array = new RenderTexture[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = RenderTexture.GetTemporary(temporary.width / num2, temporary.width / num2, 0, this.KJEEGEPKNHG);
				num2 *= 2;
			}
			RenderTexture source = array[num - 1];
			Graphics.Blit(temporary, array[0], this.KBCBFKDEGNF, 1);
			if (this.type == Tonemapping.TonemapperType.AdaptiveReinhardAutoWhite)
			{
				for (int j = 0; j < num - 1; j++)
				{
					Graphics.Blit(array[j], array[j + 1], this.KBCBFKDEGNF, 9);
					source = array[j + 1];
				}
			}
			else if (this.type == Tonemapping.TonemapperType.AdaptiveReinhard)
			{
				for (int k = 0; k < num - 1; k++)
				{
					Graphics.Blit(array[k], array[k + 1]);
					source = array[k + 1];
				}
			}
			this.adaptionSpeed = ((this.adaptionSpeed >= 0.001f) ? this.adaptionSpeed : 0.001f);
			this.KBCBFKDEGNF.SetFloat("_AdaptionSpeed", this.adaptionSpeed);
			this.HIIBHBOMGLD.MarkRestoreExpected();
			Graphics.Blit(source, this.HIIBHBOMGLD, this.KBCBFKDEGNF, (!flag) ? 2 : 3);
			this.middleGrey = ((this.middleGrey >= 0.001f) ? this.middleGrey : 0.001f);
			this.KBCBFKDEGNF.SetVector("_HdrParams", new Vector4(this.middleGrey, this.middleGrey, this.middleGrey, this.white * this.white));
			this.KBCBFKDEGNF.SetTexture("_SmallTex", this.HIIBHBOMGLD);
			if (this.type == Tonemapping.TonemapperType.AdaptiveReinhard)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 0);
			}
			else if (this.type == Tonemapping.TonemapperType.AdaptiveReinhardAutoWhite)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 10);
			}
			else
			{
				Debug.LogError("No valid adaptive tonemapper type found!");
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
			for (int l = 0; l < num; l++)
			{
				RenderTexture.ReleaseTemporary(array[l]);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x0600817F RID: 33151 RVA: 0x002C48F8 File Offset: 0x002C2AF8
		private void HNILMGEKDEC()
		{
			if (this.HIIBHBOMGLD)
			{
				UnityEngine.Object.DestroyImmediate(this.HIIBHBOMGLD);
				this.HIIBHBOMGLD = null;
			}
			if (this.KBCBFKDEGNF)
			{
				UnityEngine.Object.DestroyImmediate(this.KBCBFKDEGNF);
				this.KBCBFKDEGNF = null;
			}
			if (this.NJJOOMMFACB)
			{
				UnityEngine.Object.DestroyImmediate(this.NJJOOMMFACB);
				this.NJJOOMMFACB = null;
			}
		}

		// Token: 0x06008180 RID: 33152 RVA: 0x002C496C File Offset: 0x002C2B6C
		public float UpdateCurve()
		{
			float num = 1f;
			if (this.remapCurve.keys.Length < 1)
			{
				this.remapCurve = new AnimationCurve(new Keyframe[]
				{
					new Keyframe(0f, 0f),
					new Keyframe(2f, 1f)
				});
			}
			if (this.remapCurve != null)
			{
				if (this.remapCurve.length > 0)
				{
					num = this.remapCurve[this.remapCurve.length - 1].time;
				}
				for (float num2 = 0f; num2 <= 1f; num2 += 0.003921569f)
				{
					float num3 = this.remapCurve.Evaluate(num2 * 1f * num);
					this.NJJOOMMFACB.SetPixel((int)Mathf.Floor(num2 * 255f), 0, new Color(num3, num3, num3));
				}
				this.NJJOOMMFACB.Apply();
			}
			return 1f / num;
		}

		// Token: 0x06008181 RID: 33153 RVA: 0x002C4A7C File Offset: 0x002C2C7C
		private void NJFDLOBJCCF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL())
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.exposureAdjustment = ((this.exposureAdjustment >= 1712f) ? this.exposureAdjustment : 595f);
			if (this.type == Tonemapping.TonemapperType.UserCurve)
			{
				float value = this.MLGOCOAJIGG();
				this.KBCBFKDEGNF.SetFloat("on master", value);
				this.KBCBFKDEGNF.SetTexture(".", this.NJJOOMMFACB);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 6);
				return;
			}
			if (this.type == Tonemapping.TonemapperType.SimpleReinhard)
			{
				this.KBCBFKDEGNF.SetFloat("_Near", this.exposureAdjustment);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 2);
				return;
			}
			if (this.type == Tonemapping.TonemapperType.AdaptiveReinhard)
			{
				this.KBCBFKDEGNF.SetFloat("bans.viewed.", this.exposureAdjustment);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 4);
				return;
			}
			if (this.type == Tonemapping.TonemapperType.AdaptiveReinhardAutoWhite)
			{
				this.KBCBFKDEGNF.SetFloat("_FresnelFadePower", this.exposureAdjustment);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 0);
				return;
			}
			if (this.type == (Tonemapping.TonemapperType)7)
			{
				this.KBCBFKDEGNF.SetFloat("CameraFilterPack/TV_CompressionFX", 626f * this.exposureAdjustment);
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 2);
				return;
			}
			bool flag = this.PFFCCPAAGPC();
			RenderTexture temporary = RenderTexture.GetTemporary((int)this.adaptiveTextureSize, (int)this.adaptiveTextureSize, 0, this.KJEEGEPKNHG);
			Graphics.Blit(HLBKCLPNHEB, temporary);
			int num = (int)Mathf.Log((float)temporary.width * 432f, 1892f);
			int num2 = 3;
			RenderTexture[] array = new RenderTexture[num];
			for (int i = 0; i < num; i++)
			{
				array[i] = RenderTexture.GetTemporary(temporary.width / num2, temporary.width / num2, 1, this.KJEEGEPKNHG);
				num2 *= 6;
			}
			RenderTexture source = array[num - 0];
			Graphics.Blit(temporary, array[0], this.KBCBFKDEGNF, 0);
			if (this.type == Tonemapping.TonemapperType.AdaptiveReinhard)
			{
				for (int j = 1; j < num - 0; j++)
				{
					Graphics.Blit(array[j], array[j + 0], this.KBCBFKDEGNF, -124);
					source = array[j + 0];
				}
			}
			else if (this.type == Tonemapping.TonemapperType.AdaptiveReinhardAutoWhite)
			{
				for (int k = 0; k < num - 1; k += 0)
				{
					Graphics.Blit(array[k], array[k + 1]);
					source = array[k + 1];
				}
			}
			this.adaptionSpeed = ((this.adaptionSpeed >= 1084f) ? this.adaptionSpeed : 1589f);
			this.KBCBFKDEGNF.SetFloat("_TimeX", this.adaptionSpeed);
			this.HIIBHBOMGLD.MarkRestoreExpected();
			Graphics.Blit(source, this.HIIBHBOMGLD, this.KBCBFKDEGNF, (!flag) ? 3 : 6);
			this.middleGrey = ((this.middleGrey >= 936f) ? this.middleGrey : 259f);
			this.KBCBFKDEGNF.SetVector("_Radius", new Vector4(this.middleGrey, this.middleGrey, this.middleGrey, this.white * this.white));
			this.KBCBFKDEGNF.SetTexture(" or player:", this.HIIBHBOMGLD);
			if (this.type == Tonemapping.TonemapperType.OptimizedHejiDawson)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, 1);
			}
			else if (this.type == Tonemapping.TonemapperType.OptimizedHejiDawson)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.KBCBFKDEGNF, -19);
			}
			else
			{
				Debug.LogError(" not exist");
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
			}
			for (int l = 0; l < num; l++)
			{
				RenderTexture.ReleaseTemporary(array[l]);
			}
			RenderTexture.ReleaseTemporary(temporary);
		}

		// Token: 0x06008182 RID: 33154 RVA: 0x002C4E50 File Offset: 0x002C3050
		private void NAOLAJPDGIC()
		{
			if (this.HIIBHBOMGLD)
			{
				UnityEngine.Object.DestroyImmediate(this.HIIBHBOMGLD);
				this.HIIBHBOMGLD = null;
			}
			if (this.KBCBFKDEGNF)
			{
				UnityEngine.Object.DestroyImmediate(this.KBCBFKDEGNF);
				this.KBCBFKDEGNF = null;
			}
			if (this.NJJOOMMFACB)
			{
				UnityEngine.Object.DestroyImmediate(this.NJJOOMMFACB);
				this.NJJOOMMFACB = null;
			}
		}

		// Token: 0x06008183 RID: 33155 RVA: 0x002C4EC4 File Offset: 0x002C30C4
		private bool ADHBOPLPOCI()
		{
			if (this.HIIBHBOMGLD)
			{
				return true;
			}
			this.KJEEGEPKNHG = ((!SystemInfo.SupportsRenderTextureFormat((RenderTextureFormat)37)) ? RenderTextureFormat.ARGBHalf : ((RenderTextureFormat)(-17)));
			this.HIIBHBOMGLD = new RenderTexture(1, 1, 0, this.KJEEGEPKNHG);
			this.HIIBHBOMGLD.hideFlags = (HideFlags)(-1);
			return true;
		}

		// Token: 0x04000E92 RID: 3730
		public Tonemapping.TonemapperType type = Tonemapping.TonemapperType.Photographic;

		// Token: 0x04000E93 RID: 3731
		public Tonemapping.AdaptiveTexSize adaptiveTextureSize = Tonemapping.AdaptiveTexSize.Square256;

		// Token: 0x04000E94 RID: 3732
		public AnimationCurve remapCurve;

		// Token: 0x04000E95 RID: 3733
		private Texture2D NJJOOMMFACB;

		// Token: 0x04000E96 RID: 3734
		public float exposureAdjustment = 1.5f;

		// Token: 0x04000E97 RID: 3735
		public float middleGrey = 0.4f;

		// Token: 0x04000E98 RID: 3736
		public float white = 2f;

		// Token: 0x04000E99 RID: 3737
		public float adaptionSpeed = 1.5f;

		// Token: 0x04000E9A RID: 3738
		public Shader tonemapper;

		// Token: 0x04000E9B RID: 3739
		public bool validRenderTextureFormat = true;

		// Token: 0x04000E9C RID: 3740
		private Material KBCBFKDEGNF;

		// Token: 0x04000E9D RID: 3741
		private RenderTexture HIIBHBOMGLD;

		// Token: 0x04000E9E RID: 3742
		private RenderTextureFormat KJEEGEPKNHG = RenderTextureFormat.ARGBHalf;

		// Token: 0x020001FC RID: 508
		public enum TonemapperType
		{
			// Token: 0x04000EA0 RID: 3744
			SimpleReinhard,
			// Token: 0x04000EA1 RID: 3745
			UserCurve,
			// Token: 0x04000EA2 RID: 3746
			Hable,
			// Token: 0x04000EA3 RID: 3747
			Photographic,
			// Token: 0x04000EA4 RID: 3748
			OptimizedHejiDawson,
			// Token: 0x04000EA5 RID: 3749
			AdaptiveReinhard,
			// Token: 0x04000EA6 RID: 3750
			AdaptiveReinhardAutoWhite
		}

		// Token: 0x020001FD RID: 509
		public enum AdaptiveTexSize
		{
			// Token: 0x04000EA8 RID: 3752
			Square16 = 16,
			// Token: 0x04000EA9 RID: 3753
			Square32 = 32,
			// Token: 0x04000EAA RID: 3754
			Square64 = 64,
			// Token: 0x04000EAB RID: 3755
			Square128 = 128,
			// Token: 0x04000EAC RID: 3756
			Square256 = 256,
			// Token: 0x04000EAD RID: 3757
			Square512 = 512,
			// Token: 0x04000EAE RID: 3758
			Square1024 = 1024
		}
	}
}
