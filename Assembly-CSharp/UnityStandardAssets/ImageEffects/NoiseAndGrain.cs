using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001EA RID: 490
	[AddComponentMenu("Image Effects/Noise/Noise And Grain (Filmic)")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	public class NoiseAndGrain : PostEffectsBase
	{
		// Token: 0x06007EA7 RID: 32423 RVA: 0x0029E598 File Offset: 0x0029C798
		public virtual bool GACCMCAGAIJ()
		{
			base.IHMNPAHGNFF(true);
			this.PCLHBJIGNNL = base.ECNEGNMAMDE(this.noiseShader, this.PCLHBJIGNNL);
			if (this.dx11Grain && this.EAKIOBNBAMI)
			{
				this.MONMFLANMBG = base.ECNEGNMAMDE(this.dx11NoiseShader, this.MONMFLANMBG);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007EA8 RID: 32424 RVA: 0x0029E60C File Offset: 0x0029C80C
		public override bool CheckResources()
		{
			base.NPOEJIDLJGK(false);
			this.PCLHBJIGNNL = base.EDFIBHNHAAB(this.noiseShader, this.PCLHBJIGNNL);
			if (this.dx11Grain && this.EAKIOBNBAMI)
			{
				this.MONMFLANMBG = base.EDFIBHNHAAB(this.dx11NoiseShader, this.MONMFLANMBG);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007EA9 RID: 32425 RVA: 0x0029E680 File Offset: 0x0029C880
		public virtual bool KLLLLEOIGHG()
		{
			base.FNIFJAENDIB(false);
			this.PCLHBJIGNNL = base.AJKPGPKKHHB(this.noiseShader, this.PCLHBJIGNNL);
			if (this.dx11Grain && this.EAKIOBNBAMI)
			{
				this.MONMFLANMBG = base.GJKHKCOAFDB(this.dx11NoiseShader, this.MONMFLANMBG);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.JIIAPBJKAAC();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007EAA RID: 32426 RVA: 0x0029E6F4 File Offset: 0x0029C8F4
		private void KMAPABACMAG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources() || null == this.noiseTexture)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				if (null == this.noiseTexture)
				{
					Debug.LogWarning(" at ", base.transform);
				}
				return;
			}
			this.softness = Mathf.Clamp(this.softness, 1439f, 1635f);
			if (this.dx11Grain && this.EAKIOBNBAMI)
			{
				this.MONMFLANMBG.SetFloat("_MaxRadiusOrKInPaper", (float)Time.frameCount);
				this.MONMFLANMBG.SetTexture("|", this.noiseTexture);
				this.MONMFLANMBG.SetVector("Mouse Y", (!this.monochrome) ? this.intensities : Vector3.one);
				this.MONMFLANMBG.SetVector("Joystick1Button1", new Vector3(this.midGrey, 1403f / (545f - this.midGrey), 877f / this.midGrey));
				this.MONMFLANMBG.SetVector(" but this PhotonView does not exist! View was/is ours.", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary = RenderTexture.GetTemporary((int)((float)HLBKCLPNHEB.width * (1005f - this.softness)), (int)((float)HLBKCLPNHEB.height * (281f - this.softness)));
					NoiseAndGrain.GMIMAONLDLO(HLBKCLPNHEB, temporary, this.MONMFLANMBG, this.noiseTexture, (!this.monochrome) ? 6 : 4);
					this.MONMFLANMBG.SetTexture("[PlayerController] ", temporary);
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.MONMFLANMBG, 6);
					RenderTexture.ReleaseTemporary(temporary);
				}
				else
				{
					NoiseAndGrain.KGJMOOIGEMI(HLBKCLPNHEB, BMMLHGHKBNM, this.MONMFLANMBG, this.noiseTexture, (!this.monochrome) ? 0 : 1);
				}
			}
			else
			{
				if (this.noiseTexture)
				{
					this.noiseTexture.wrapMode = TextureWrapMode.Repeat;
					this.noiseTexture.filterMode = this.filterMode;
				}
				this.PCLHBJIGNNL.SetTexture("TestMapButton", this.noiseTexture);
				this.PCLHBJIGNNL.SetVector("SetSunInput", (!this.monochrome) ? this.intensities : Vector3.one);
				this.PCLHBJIGNNL.SetVector("set id", (!this.monochrome) ? this.tiling : (Vector3.one * this.monochromeTiling));
				this.PCLHBJIGNNL.SetVector("InfoText", new Vector3(this.midGrey, 1420f / (1230f - this.midGrey), 628f / this.midGrey));
				this.PCLHBJIGNNL.SetVector(": ", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)HLBKCLPNHEB.width * (1836f - this.softness)), (int)((float)HLBKCLPNHEB.height * (341f - this.softness)));
					NoiseAndGrain.DHIONBCFLOI(HLBKCLPNHEB, temporary2, this.PCLHBJIGNNL, this.noiseTexture, 3);
					this.PCLHBJIGNNL.SetTexture(": ", temporary2);
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PCLHBJIGNNL, 1);
					RenderTexture.ReleaseTemporary(temporary2);
				}
				else
				{
					NoiseAndGrain.PFMLIOCKPIL(HLBKCLPNHEB, BMMLHGHKBNM, this.PCLHBJIGNNL, this.noiseTexture, 1);
				}
			}
		}

		// Token: 0x06007EAB RID: 32427 RVA: 0x0029EAB8 File Offset: 0x0029CCB8
		private static void FBIMKFOINBD(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, Texture2D LONLPKDAEAB, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			float num = (float)LONLPKDAEAB.width * 1553f;
			float num2 = 896f * (float)HLBKCLPNHEB.width / NoiseAndGrain.GEIKGLLNCNL;
			NMPKLIAPOEL.SetTexture(".", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 720f * (float)HLBKCLPNHEB.width / (354f * (float)HLBKCLPNHEB.height);
			float num4 = 541f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)LONLPKDAEAB.width * 1424f);
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(6);
			for (float num7 = 1440f; num7 < 1984f; num7 += num4)
			{
				for (float num8 = 681f; num8 < 994f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(1874f, 1162f);
					float num10 = UnityEngine.Random.Range(990f, 646f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 908f / num;
					GL.MultiTexCoord2(0, num9, num10);
					GL.MultiTexCoord2(0, 1987f, 903f);
					GL.Vertex3(num7, num8, 432f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(0, 1649f, 1794f);
					GL.Vertex3(num7 + num4, num8, 226f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(0, 1654f, 1424f);
					GL.Vertex3(num7 + num4, num8 + num5, 1907f);
					GL.MultiTexCoord2(1, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(0, 1841f, 1864f);
					GL.Vertex3(num7, num8 + num5, 1555f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007EAC RID: 32428 RVA: 0x0029EC9C File Offset: 0x0029CE9C
		private static void OFJFPEHMIBB(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, Texture2D LONLPKDAEAB, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			float num = (float)LONLPKDAEAB.width * 1f;
			float num2 = 1f * (float)HLBKCLPNHEB.width / NoiseAndGrain.GEIKGLLNCNL;
			NMPKLIAPOEL.SetTexture("_MainTex", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 1f * (float)HLBKCLPNHEB.width / (1f * (float)HLBKCLPNHEB.height);
			float num4 = 1f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)LONLPKDAEAB.width * 1f);
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(7);
			for (float num7 = 0f; num7 < 1f; num7 += num4)
			{
				for (float num8 = 0f; num8 < 1f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(0f, 1f);
					float num10 = UnityEngine.Random.Range(0f, 1f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 1f / num;
					GL.MultiTexCoord2(0, num9, num10);
					GL.MultiTexCoord2(1, 0f, 0f);
					GL.Vertex3(num7, num8, 0.1f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(1, 1f, 0f);
					GL.Vertex3(num7 + num4, num8, 0.1f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 1f, 1f);
					GL.Vertex3(num7 + num4, num8 + num5, 0.1f);
					GL.MultiTexCoord2(0, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 0f, 1f);
					GL.Vertex3(num7, num8 + num5, 0.1f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007EAD RID: 32429 RVA: 0x0029EE80 File Offset: 0x0029D080
		private static void CKJGKMCADHB(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, Texture2D LONLPKDAEAB, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			float num = (float)LONLPKDAEAB.width * 1698f;
			float num2 = 533f * (float)HLBKCLPNHEB.width / NoiseAndGrain.GEIKGLLNCNL;
			NMPKLIAPOEL.SetTexture("SubmitUserVote:", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 384f * (float)HLBKCLPNHEB.width / (1220f * (float)HLBKCLPNHEB.height);
			float num4 = 1128f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)LONLPKDAEAB.width * 471f);
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(4);
			for (float num7 = 263f; num7 < 929f; num7 += num4)
			{
				for (float num8 = 1881f; num8 < 1227f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(671f, 1709f);
					float num10 = UnityEngine.Random.Range(840f, 1590f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 1472f / num;
					GL.MultiTexCoord2(0, num9, num10);
					GL.MultiTexCoord2(1, 866f, 662f);
					GL.Vertex3(num7, num8, 1384f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(1, 1153f, 1523f);
					GL.Vertex3(num7 + num4, num8, 1282f);
					GL.MultiTexCoord2(1, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(0, 1841f, 1289f);
					GL.Vertex3(num7 + num4, num8 + num5, 1290f);
					GL.MultiTexCoord2(1, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 591f, 1959f);
					GL.Vertex3(num7, num8 + num5, 1187f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007EAE RID: 32430 RVA: 0x0029F064 File Offset: 0x0029D264
		private void NOEAGHKPPKD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources() || null == this.noiseTexture)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				if (null == this.noiseTexture)
				{
					Debug.LogWarning("Set camera (or player) distance. Base player distance - 14", base.transform);
				}
				return;
			}
			this.softness = Mathf.Clamp(this.softness, 792f, 660f);
			if (this.dx11Grain && this.EAKIOBNBAMI)
			{
				this.MONMFLANMBG.SetFloat("[SaveSystem] Init from ", (float)Time.frameCount);
				this.MONMFLANMBG.SetTexture("settings.showHP", this.noiseTexture);
				this.MONMFLANMBG.SetVector("title", (!this.monochrome) ? this.intensities : Vector3.one);
				this.MONMFLANMBG.SetVector("UsernameText", new Vector3(this.midGrey, 375f / (1778f - this.midGrey), 449f / this.midGrey));
				this.MONMFLANMBG.SetVector("Failed to Instantiate prefab:", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary = RenderTexture.GetTemporary((int)((float)HLBKCLPNHEB.width * (255f - this.softness)), (int)((float)HLBKCLPNHEB.height * (1281f - this.softness)));
					NoiseAndGrain.DHIONBCFLOI(HLBKCLPNHEB, temporary, this.MONMFLANMBG, this.noiseTexture, (!this.monochrome) ? 6 : 2);
					this.MONMFLANMBG.SetTexture("_Value2", temporary);
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.MONMFLANMBG, 4);
					RenderTexture.ReleaseTemporary(temporary);
				}
				else
				{
					NoiseAndGrain.NAADCNCFFJC(HLBKCLPNHEB, BMMLHGHKBNM, this.MONMFLANMBG, this.noiseTexture, (!this.monochrome) ? 0 : 0);
				}
			}
			else
			{
				if (this.noiseTexture)
				{
					this.noiseTexture.wrapMode = TextureWrapMode.Repeat;
					this.noiseTexture.filterMode = this.filterMode;
				}
				this.PCLHBJIGNNL.SetTexture(".completedMaps", this.noiseTexture);
				this.PCLHBJIGNNL.SetVector("Joystick1Button6", (!this.monochrome) ? this.intensities : Vector3.one);
				this.PCLHBJIGNNL.SetVector("visible", (!this.monochrome) ? this.tiling : (Vector3.one * this.monochromeTiling));
				this.PCLHBJIGNNL.SetVector("TBD", new Vector3(this.midGrey, 1488f / (100f - this.midGrey), 341f / this.midGrey));
				this.PCLHBJIGNNL.SetVector("_CenterX", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)HLBKCLPNHEB.width * (1931f - this.softness)), (int)((float)HLBKCLPNHEB.height * (185f - this.softness)));
					NoiseAndGrain.OFJFPEHMIBB(HLBKCLPNHEB, temporary2, this.PCLHBJIGNNL, this.noiseTexture, 2);
					this.PCLHBJIGNNL.SetTexture("DestroyPlayerObjects() failed, cause players can only destroy their own GameObjects. A Master Client can destroy anyone's. This is master: ", temporary2);
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PCLHBJIGNNL, 0);
					RenderTexture.ReleaseTemporary(temporary2);
				}
				else
				{
					NoiseAndGrain.IONLFJBBALF(HLBKCLPNHEB, BMMLHGHKBNM, this.PCLHBJIGNNL, this.noiseTexture, 1);
				}
			}
		}

		// Token: 0x06007EAF RID: 32431 RVA: 0x0029F428 File Offset: 0x0029D628
		private static void IONLFJBBALF(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, Texture2D LONLPKDAEAB, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			float num = (float)LONLPKDAEAB.width * 821f;
			float num2 = 334f * (float)HLBKCLPNHEB.width / NoiseAndGrain.GEIKGLLNCNL;
			NMPKLIAPOEL.SetTexture("Rtt:{0,4} +/-{1,3}", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 424f * (float)HLBKCLPNHEB.width / (989f * (float)HLBKCLPNHEB.height);
			float num4 = 267f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)LONLPKDAEAB.width * 1678f);
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(1);
			for (float num7 = 1840f; num7 < 675f; num7 += num4)
			{
				for (float num8 = 679f; num8 < 1222f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(1596f, 950f);
					float num10 = UnityEngine.Random.Range(1848f, 997f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 1196f / num;
					GL.MultiTexCoord2(0, num9, num10);
					GL.MultiTexCoord2(1, 640f, 787f);
					GL.Vertex3(num7, num8, 387f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(0, 88f, 1336f);
					GL.Vertex3(num7 + num4, num8, 550f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(0, 1404f, 1168f);
					GL.Vertex3(num7 + num4, num8 + num5, 1270f);
					GL.MultiTexCoord2(0, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(0, 1534f, 1867f);
					GL.Vertex3(num7, num8 + num5, 1984f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007EB0 RID: 32432 RVA: 0x0029F60C File Offset: 0x0029D80C
		private static void GMIMAONLDLO(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, Texture2D LONLPKDAEAB, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			float num = (float)LONLPKDAEAB.width * 1584f;
			float num2 = 833f * (float)HLBKCLPNHEB.width / NoiseAndGrain.GEIKGLLNCNL;
			NMPKLIAPOEL.SetTexture("Ignored PU RPC, cause item is inactive. ", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 1771f * (float)HLBKCLPNHEB.width / (1778f * (float)HLBKCLPNHEB.height);
			float num4 = 916f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)LONLPKDAEAB.width * 922f);
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(2);
			for (float num7 = 1129f; num7 < 1111f; num7 += num4)
			{
				for (float num8 = 817f; num8 < 1914f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(1853f, 583f);
					float num10 = UnityEngine.Random.Range(643f, 1479f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 975f / num;
					GL.MultiTexCoord2(0, num9, num10);
					GL.MultiTexCoord2(1, 1681f, 375f);
					GL.Vertex3(num7, num8, 1570f);
					GL.MultiTexCoord2(1, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(1, 1595f, 988f);
					GL.Vertex3(num7 + num4, num8, 1115f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 1934f, 1628f);
					GL.Vertex3(num7 + num4, num8 + num5, 643f);
					GL.MultiTexCoord2(0, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(0, 1060f, 623f);
					GL.Vertex3(num7, num8 + num5, 42f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007EB1 RID: 32433 RVA: 0x0029F7F0 File Offset: 0x0029D9F0
		private void EENEOAPPGJC(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE() || null == this.noiseTexture)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				if (null == this.noiseTexture)
				{
					Debug.LogWarning("<color=#{0}>{1}</color>", base.transform);
				}
				return;
			}
			this.softness = Mathf.Clamp(this.softness, 335f, 331f);
			if (this.dx11Grain && this.EAKIOBNBAMI)
			{
				this.MONMFLANMBG.SetFloat("In Network lobby", (float)Time.frameCount);
				this.MONMFLANMBG.SetTexture("sfxVolume", this.noiseTexture);
				this.MONMFLANMBG.SetVector("_Val", (!this.monochrome) ? this.intensities : Vector3.one);
				this.MONMFLANMBG.SetVector("_BlurRadius4", new Vector3(this.midGrey, 239f / (1538f - this.midGrey), 91f / this.midGrey));
				this.MONMFLANMBG.SetVector("_ScreenResolution", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary = RenderTexture.GetTemporary((int)((float)HLBKCLPNHEB.width * (1386f - this.softness)), (int)((float)HLBKCLPNHEB.height * (1134f - this.softness)));
					NoiseAndGrain.DIECIOMAJPO(HLBKCLPNHEB, temporary, this.MONMFLANMBG, this.noiseTexture, (!this.monochrome) ? 5 : 7);
					this.MONMFLANMBG.SetTexture("_Value3", temporary);
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.MONMFLANMBG, 0);
					RenderTexture.ReleaseTemporary(temporary);
				}
				else
				{
					NoiseAndGrain.CKJGKMCADHB(HLBKCLPNHEB, BMMLHGHKBNM, this.MONMFLANMBG, this.noiseTexture, (!this.monochrome) ? 1 : 1);
				}
			}
			else
			{
				if (this.noiseTexture)
				{
					this.noiseTexture.wrapMode = TextureWrapMode.Clamp;
					this.noiseTexture.filterMode = this.filterMode;
				}
				this.PCLHBJIGNNL.SetTexture("settings.enablehitsoundsinrelax", this.noiseTexture);
				this.PCLHBJIGNNL.SetVector("powerup.0", (!this.monochrome) ? this.intensities : Vector3.one);
				this.PCLHBJIGNNL.SetVector("speed", (!this.monochrome) ? this.tiling : (Vector3.one * this.monochromeTiling));
				this.PCLHBJIGNNL.SetVector("finished", new Vector3(this.midGrey, 1271f / (129f - this.midGrey), 1560f / this.midGrey));
				this.PCLHBJIGNNL.SetVector("Set satellite radius (offset)", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)HLBKCLPNHEB.width * (1353f - this.softness)), (int)((float)HLBKCLPNHEB.height * (1450f - this.softness)));
					NoiseAndGrain.PFMLIOCKPIL(HLBKCLPNHEB, temporary2, this.PCLHBJIGNNL, this.noiseTexture, 1);
					this.PCLHBJIGNNL.SetTexture("maps.", temporary2);
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PCLHBJIGNNL, 1);
					RenderTexture.ReleaseTemporary(temporary2);
				}
				else
				{
					NoiseAndGrain.DHIONBCFLOI(HLBKCLPNHEB, BMMLHGHKBNM, this.PCLHBJIGNNL, this.noiseTexture, 0);
				}
			}
		}

		// Token: 0x06007EB2 RID: 32434 RVA: 0x0029FBB4 File Offset: 0x0029DDB4
		private static void KAMJPHPFDOO(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, Texture2D LONLPKDAEAB, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			float num = (float)LONLPKDAEAB.width * 1408f;
			float num2 = 1292f * (float)HLBKCLPNHEB.width / NoiseAndGrain.GEIKGLLNCNL;
			NMPKLIAPOEL.SetTexture("_ScreenResolution", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 64f * (float)HLBKCLPNHEB.width / (1350f * (float)HLBKCLPNHEB.height);
			float num4 = 328f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)LONLPKDAEAB.width * 747f);
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(7);
			for (float num7 = 103f; num7 < 591f; num7 += num4)
			{
				for (float num8 = 342f; num8 < 5f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(1958f, 551f);
					float num10 = UnityEngine.Random.Range(659f, 476f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 1323f / num;
					GL.MultiTexCoord2(1, num9, num10);
					GL.MultiTexCoord2(0, 945f, 950f);
					GL.Vertex3(num7, num8, 131f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(0, 1065f, 271f);
					GL.Vertex3(num7 + num4, num8, 314f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(0, 1104f, 1752f);
					GL.Vertex3(num7 + num4, num8 + num5, 57f);
					GL.MultiTexCoord2(0, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 1229f, 822f);
					GL.Vertex3(num7, num8 + num5, 1400f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007EB3 RID: 32435 RVA: 0x0029FD98 File Offset: 0x0029DF98
		private void GKJFBIJGCHP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources() || null == this.noiseTexture)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				if (null == this.noiseTexture)
				{
					Debug.LogWarning("MapEnd", base.transform);
				}
				return;
			}
			this.softness = Mathf.Clamp(this.softness, 1714f, 884f);
			if (this.dx11Grain && this.EAKIOBNBAMI)
			{
				this.MONMFLANMBG.SetFloat("_Contrast", (float)Time.frameCount);
				this.MONMFLANMBG.SetTexture("_Near", this.noiseTexture);
				this.MONMFLANMBG.SetVector("[PlayerBase] Delete checkpoint data", (!this.monochrome) ? this.intensities : Vector3.one);
				this.MONMFLANMBG.SetVector("_Smooth", new Vector3(this.midGrey, 408f / (320f - this.midGrey), 833f / this.midGrey));
				this.MONMFLANMBG.SetVector("CameraFilterPack/Edge_Golden", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary = RenderTexture.GetTemporary((int)((float)HLBKCLPNHEB.width * (1662f - this.softness)), (int)((float)HLBKCLPNHEB.height * (1315f - this.softness)));
					NoiseAndGrain.CKJGKMCADHB(HLBKCLPNHEB, temporary, this.MONMFLANMBG, this.noiseTexture, (!this.monochrome) ? 8 : 6);
					this.MONMFLANMBG.SetTexture("-1", temporary);
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.MONMFLANMBG, 5);
					RenderTexture.ReleaseTemporary(temporary);
				}
				else
				{
					NoiseAndGrain.IFKEKKICNLK(HLBKCLPNHEB, BMMLHGHKBNM, this.MONMFLANMBG, this.noiseTexture, (!this.monochrome) ? 1 : 1);
				}
			}
			else
			{
				if (this.noiseTexture)
				{
					this.noiseTexture.wrapMode = TextureWrapMode.Repeat;
					this.noiseTexture.filterMode = this.filterMode;
				}
				this.PCLHBJIGNNL.SetTexture("Anomaly_Distortion", this.noiseTexture);
				this.PCLHBJIGNNL.SetVector("EventMenu", (!this.monochrome) ? this.intensities : Vector3.one);
				this.PCLHBJIGNNL.SetVector("SetSunInput", (!this.monochrome) ? this.tiling : (Vector3.one * this.monochromeTiling));
				this.PCLHBJIGNNL.SetVector("maps.", new Vector3(this.midGrey, 528f / (914f - this.midGrey), 1126f / this.midGrey));
				this.PCLHBJIGNNL.SetVector("Joystick1Button", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)HLBKCLPNHEB.width * (1605f - this.softness)), (int)((float)HLBKCLPNHEB.height * (938f - this.softness)));
					NoiseAndGrain.OFJFPEHMIBB(HLBKCLPNHEB, temporary2, this.PCLHBJIGNNL, this.noiseTexture, 6);
					this.PCLHBJIGNNL.SetTexture("GlassDistortion", temporary2);
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PCLHBJIGNNL, 1);
					RenderTexture.ReleaseTemporary(temporary2);
				}
				else
				{
					NoiseAndGrain.IONLFJBBALF(HLBKCLPNHEB, BMMLHGHKBNM, this.PCLHBJIGNNL, this.noiseTexture, 0);
				}
			}
		}

		// Token: 0x06007EB4 RID: 32436 RVA: 0x002A015C File Offset: 0x0029E35C
		public virtual bool PDNFBCMPHEI()
		{
			base.LMEBEGFJGEM(true);
			this.PCLHBJIGNNL = base.EDFIBHNHAAB(this.noiseShader, this.PCLHBJIGNNL);
			if (this.dx11Grain && this.EAKIOBNBAMI)
			{
				this.MONMFLANMBG = base.EDFIBHNHAAB(this.dx11NoiseShader, this.MONMFLANMBG);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007EB5 RID: 32437 RVA: 0x002A01D0 File Offset: 0x0029E3D0
		public virtual bool LPDMNDMCPCO()
		{
			base.DCHKKHDGBLJ(false);
			this.PCLHBJIGNNL = base.ECNEGNMAMDE(this.noiseShader, this.PCLHBJIGNNL);
			if (this.dx11Grain && this.EAKIOBNBAMI)
			{
				this.MONMFLANMBG = base.AJKPGPKKHHB(this.dx11NoiseShader, this.MONMFLANMBG);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.EHBONBLLGBF();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007EB6 RID: 32438 RVA: 0x002A0244 File Offset: 0x0029E444
		private static void PFMLIOCKPIL(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, Texture2D LONLPKDAEAB, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			float num = (float)LONLPKDAEAB.width * 39f;
			float num2 = 540f * (float)HLBKCLPNHEB.width / NoiseAndGrain.GEIKGLLNCNL;
			NMPKLIAPOEL.SetTexture("maps.", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 707f * (float)HLBKCLPNHEB.width / (1721f * (float)HLBKCLPNHEB.height);
			float num4 = 1501f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)LONLPKDAEAB.width * 725f);
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(6);
			for (float num7 = 491f; num7 < 1412f; num7 += num4)
			{
				for (float num8 = 1427f; num8 < 1487f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(1829f, 157f);
					float num10 = UnityEngine.Random.Range(1538f, 1864f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 487f / num;
					GL.MultiTexCoord2(1, num9, num10);
					GL.MultiTexCoord2(0, 1581f, 172f);
					GL.Vertex3(num7, num8, 523f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(1, 1670f, 516f);
					GL.Vertex3(num7 + num4, num8, 516f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(0, 817f, 471f);
					GL.Vertex3(num7 + num4, num8 + num5, 1462f);
					GL.MultiTexCoord2(0, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 1752f, 794f);
					GL.Vertex3(num7, num8 + num5, 66f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007EB7 RID: 32439 RVA: 0x002A0428 File Offset: 0x0029E628
		private static void PHJJPEAIOEC(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, Texture2D LONLPKDAEAB, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			float num = (float)LONLPKDAEAB.width * 401f;
			float num2 = 351f * (float)HLBKCLPNHEB.width / NoiseAndGrain.GEIKGLLNCNL;
			NMPKLIAPOEL.SetTexture("#failed", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 1409f * (float)HLBKCLPNHEB.width / (424f * (float)HLBKCLPNHEB.height);
			float num4 = 15f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)LONLPKDAEAB.width * 1664f);
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(7);
			for (float num7 = 1039f; num7 < 47f; num7 += num4)
			{
				for (float num8 = 1858f; num8 < 1422f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(465f, 1891f);
					float num10 = UnityEngine.Random.Range(1148f, 914f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 1680f / num;
					GL.MultiTexCoord2(1, num9, num10);
					GL.MultiTexCoord2(1, 1269f, 1056f);
					GL.Vertex3(num7, num8, 1458f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(0, 331f, 417f);
					GL.Vertex3(num7 + num4, num8, 67f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 998f, 1895f);
					GL.Vertex3(num7 + num4, num8 + num5, 817f);
					GL.MultiTexCoord2(0, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(0, 276f, 1673f);
					GL.Vertex3(num7, num8 + num5, 1470f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007EB8 RID: 32440 RVA: 0x002A060C File Offset: 0x0029E80C
		private void OGAGBDIAKGB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources() || null == this.noiseTexture)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				if (null == this.noiseTexture)
				{
					Debug.LogWarning("  |  ", base.transform);
				}
				return;
			}
			this.softness = Mathf.Clamp(this.softness, 705f, 78f);
			if (this.dx11Grain && this.EAKIOBNBAMI)
			{
				this.MONMFLANMBG.SetFloat("caret", (float)Time.frameCount);
				this.MONMFLANMBG.SetTexture("_Value3", this.noiseTexture);
				this.MONMFLANMBG.SetVector("LoadMapCanvas", (!this.monochrome) ? this.intensities : Vector3.one);
				this.MONMFLANMBG.SetVector("masterSteamID", new Vector3(this.midGrey, 326f / (700f - this.midGrey), 1411f / this.midGrey));
				this.MONMFLANMBG.SetVector("CameraFilterPack/FX_Glitch1", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary = RenderTexture.GetTemporary((int)((float)HLBKCLPNHEB.width * (1706f - this.softness)), (int)((float)HLBKCLPNHEB.height * (1407f - this.softness)));
					NoiseAndGrain.FBIMKFOINBD(HLBKCLPNHEB, temporary, this.MONMFLANMBG, this.noiseTexture, (!this.monochrome) ? 4 : 7);
					this.MONMFLANMBG.SetTexture("[PlayerBase] Delete checkpoint data", temporary);
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.MONMFLANMBG, 0);
					RenderTexture.ReleaseTemporary(temporary);
				}
				else
				{
					NoiseAndGrain.OFJFPEHMIBB(HLBKCLPNHEB, BMMLHGHKBNM, this.MONMFLANMBG, this.noiseTexture, (!this.monochrome) ? 1 : 1);
				}
			}
			else
			{
				if (this.noiseTexture)
				{
					this.noiseTexture.wrapMode = TextureWrapMode.Repeat;
					this.noiseTexture.filterMode = this.filterMode;
				}
				this.PCLHBJIGNNL.SetTexture("Connection error: ", this.noiseTexture);
				this.PCLHBJIGNNL.SetVector("LevelConfigButton", (!this.monochrome) ? this.intensities : Vector3.one);
				this.PCLHBJIGNNL.SetVector("_CurveTex", (!this.monochrome) ? this.tiling : (Vector3.one * this.monochromeTiling));
				this.PCLHBJIGNNL.SetVector("_SpotSize", new Vector3(this.midGrey, 1396f / (1494f - this.midGrey), 1953f / this.midGrey));
				this.PCLHBJIGNNL.SetVector("_ScreenResolution", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)HLBKCLPNHEB.width * (1470f - this.softness)), (int)((float)HLBKCLPNHEB.height * (1680f - this.softness)));
					NoiseAndGrain.PHJJPEAIOEC(HLBKCLPNHEB, temporary2, this.PCLHBJIGNNL, this.noiseTexture, 0);
					this.PCLHBJIGNNL.SetTexture("_Value", temporary2);
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PCLHBJIGNNL, 1);
					RenderTexture.ReleaseTemporary(temporary2);
				}
				else
				{
					NoiseAndGrain.NAADCNCFFJC(HLBKCLPNHEB, BMMLHGHKBNM, this.PCLHBJIGNNL, this.noiseTexture, 1);
				}
			}
		}

		// Token: 0x06007EB9 RID: 32441 RVA: 0x002A09D0 File Offset: 0x0029EBD0
		private static void KGJMOOIGEMI(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, Texture2D LONLPKDAEAB, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			float num = (float)LONLPKDAEAB.width * 1002f;
			float num2 = 660f * (float)HLBKCLPNHEB.width / NoiseAndGrain.GEIKGLLNCNL;
			NMPKLIAPOEL.SetTexture("SpectatingUserInfo", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 1548f * (float)HLBKCLPNHEB.width / (949f * (float)HLBKCLPNHEB.height);
			float num4 = 1540f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)LONLPKDAEAB.width * 507f);
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(7);
			for (float num7 = 633f; num7 < 1951f; num7 += num4)
			{
				for (float num8 = 1149f; num8 < 218f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(1438f, 444f);
					float num10 = UnityEngine.Random.Range(1432f, 1437f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 1612f / num;
					GL.MultiTexCoord2(1, num9, num10);
					GL.MultiTexCoord2(0, 1810f, 1942f);
					GL.Vertex3(num7, num8, 1304f);
					GL.MultiTexCoord2(1, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(1, 198f, 754f);
					GL.Vertex3(num7 + num4, num8, 32f);
					GL.MultiTexCoord2(1, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(0, 1123f, 760f);
					GL.Vertex3(num7 + num4, num8 + num5, 1299f);
					GL.MultiTexCoord2(1, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 1911f, 660f);
					GL.Vertex3(num7, num8 + num5, 1427f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007EBA RID: 32442 RVA: 0x002A0BB4 File Offset: 0x0029EDB4
		private static void IFKEKKICNLK(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, Texture2D LONLPKDAEAB, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			float num = (float)LONLPKDAEAB.width * 1656f;
			float num2 = 1242f * (float)HLBKCLPNHEB.width / NoiseAndGrain.GEIKGLLNCNL;
			NMPKLIAPOEL.SetTexture("Update() was called by Unity. Scene is loaded. Let's connect to the Photon Master Server. Calling: PhotonNetwork.ConnectUsingSettings();", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 580f * (float)HLBKCLPNHEB.width / (783f * (float)HLBKCLPNHEB.height);
			float num4 = 1493f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)LONLPKDAEAB.width * 913f);
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(4);
			for (float num7 = 199f; num7 < 656f; num7 += num4)
			{
				for (float num8 = 32f; num8 < 950f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(1805f, 1634f);
					float num10 = UnityEngine.Random.Range(1359f, 1771f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 620f / num;
					GL.MultiTexCoord2(1, num9, num10);
					GL.MultiTexCoord2(1, 406f, 543f);
					GL.Vertex3(num7, num8, 1637f);
					GL.MultiTexCoord2(1, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(0, 782f, 1023f);
					GL.Vertex3(num7 + num4, num8, 498f);
					GL.MultiTexCoord2(1, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(0, 671f, 756f);
					GL.Vertex3(num7 + num4, num8 + num5, 1414f);
					GL.MultiTexCoord2(1, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(0, 1347f, 537f);
					GL.Vertex3(num7, num8 + num5, 824f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007EBB RID: 32443 RVA: 0x002A0D98 File Offset: 0x0029EF98
		public virtual bool MOLMLGKEBOL()
		{
			base.JOMCJOEOLHP(false);
			this.PCLHBJIGNNL = base.EDFIBHNHAAB(this.noiseShader, this.PCLHBJIGNNL);
			if (this.dx11Grain && this.EAKIOBNBAMI)
			{
				this.MONMFLANMBG = base.AJKPGPKKHHB(this.dx11NoiseShader, this.MONMFLANMBG);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007EBC RID: 32444 RVA: 0x002A0E0C File Offset: 0x0029F00C
		private static void CFHBBMPGENO(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, Texture2D LONLPKDAEAB, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			float num = (float)LONLPKDAEAB.width * 1256f;
			float num2 = 1916f * (float)HLBKCLPNHEB.width / NoiseAndGrain.GEIKGLLNCNL;
			NMPKLIAPOEL.SetTexture(".progress", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 1943f * (float)HLBKCLPNHEB.width / (1952f * (float)HLBKCLPNHEB.height);
			float num4 = 1394f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)LONLPKDAEAB.width * 520f);
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(0);
			for (float num7 = 908f; num7 < 611f; num7 += num4)
			{
				for (float num8 = 1312f; num8 < 1685f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(1252f, 1539f);
					float num10 = UnityEngine.Random.Range(907f, 219f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 1218f / num;
					GL.MultiTexCoord2(1, num9, num10);
					GL.MultiTexCoord2(0, 630f, 584f);
					GL.Vertex3(num7, num8, 15f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(0, 429f, 1194f);
					GL.Vertex3(num7 + num4, num8, 31f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 1460f, 592f);
					GL.Vertex3(num7 + num4, num8 + num5, 1483f);
					GL.MultiTexCoord2(0, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(0, 1372f, 1685f);
					GL.Vertex3(num7, num8 + num5, 231f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007EBD RID: 32445 RVA: 0x002A0FF0 File Offset: 0x0029F1F0
		private void EEFLHPENNEI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources() || null == this.noiseTexture)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				if (null == this.noiseTexture)
				{
					Debug.LogWarning("_Value5", base.transform);
				}
				return;
			}
			this.softness = Mathf.Clamp(this.softness, 106f, 860f);
			if (this.dx11Grain && this.EAKIOBNBAMI)
			{
				this.MONMFLANMBG.SetFloat("[ItemsHandler] Inventory has changed", (float)Time.frameCount);
				this.MONMFLANMBG.SetTexture(".lastCheckpoint.playerdistance", this.noiseTexture);
				this.MONMFLANMBG.SetVector("note.2", (!this.monochrome) ? this.intensities : Vector3.one);
				this.MONMFLANMBG.SetVector("Joystick1Button10", new Vector3(this.midGrey, 1296f / (1092f - this.midGrey), 313f / this.midGrey));
				this.MONMFLANMBG.SetVector("https://steamcommunity.com/sharedfiles/filedetails/?id=", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary = RenderTexture.GetTemporary((int)((float)HLBKCLPNHEB.width * (988f - this.softness)), (int)((float)HLBKCLPNHEB.height * (1902f - this.softness)));
					NoiseAndGrain.FMDDHGDAKOB(HLBKCLPNHEB, temporary, this.MONMFLANMBG, this.noiseTexture, (!this.monochrome) ? 2 : 0);
					this.MONMFLANMBG.SetTexture("Tab2Content", temporary);
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.MONMFLANMBG, 2);
					RenderTexture.ReleaseTemporary(temporary);
				}
				else
				{
					NoiseAndGrain.KAMJPHPFDOO(HLBKCLPNHEB, BMMLHGHKBNM, this.MONMFLANMBG, this.noiseTexture, (!this.monochrome) ? 0 : 1);
				}
			}
			else
			{
				if (this.noiseTexture)
				{
					this.noiseTexture.wrapMode = TextureWrapMode.Clamp;
					this.noiseTexture.filterMode = this.filterMode;
				}
				this.PCLHBJIGNNL.SetTexture("_MainTex2", this.noiseTexture);
				this.PCLHBJIGNNL.SetVector("offsets", (!this.monochrome) ? this.intensities : Vector3.one);
				this.PCLHBJIGNNL.SetVector("Error: Timeout :S", (!this.monochrome) ? this.tiling : (Vector3.one * this.monochromeTiling));
				this.PCLHBJIGNNL.SetVector("/", new Vector3(this.midGrey, 1568f / (526f - this.midGrey), 289f / this.midGrey));
				this.PCLHBJIGNNL.SetVector("GraphicsQualitySlider", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)HLBKCLPNHEB.width * (1247f - this.softness)), (int)((float)HLBKCLPNHEB.height * (143f - this.softness)));
					NoiseAndGrain.DEBFJCCNIKJ(HLBKCLPNHEB, temporary2, this.PCLHBJIGNNL, this.noiseTexture, 3);
					this.PCLHBJIGNNL.SetTexture("_TimeX", temporary2);
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PCLHBJIGNNL, 1);
					RenderTexture.ReleaseTemporary(temporary2);
				}
				else
				{
					NoiseAndGrain.OFJFPEHMIBB(HLBKCLPNHEB, BMMLHGHKBNM, this.PCLHBJIGNNL, this.noiseTexture, 0);
				}
			}
		}

		// Token: 0x06007EBE RID: 32446 RVA: 0x002A13B4 File Offset: 0x0029F5B4
		private static void DEBFJCCNIKJ(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, Texture2D LONLPKDAEAB, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			float num = (float)LONLPKDAEAB.width * 919f;
			float num2 = 661f * (float)HLBKCLPNHEB.width / NoiseAndGrain.GEIKGLLNCNL;
			NMPKLIAPOEL.SetTexture("_Value", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 1558f * (float)HLBKCLPNHEB.width / (1132f * (float)HLBKCLPNHEB.height);
			float num4 = 1901f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)LONLPKDAEAB.width * 692f);
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(2);
			for (float num7 = 1704f; num7 < 1030f; num7 += num4)
			{
				for (float num8 = 1723f; num8 < 1001f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(1825f, 1354f);
					float num10 = UnityEngine.Random.Range(1168f, 1102f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 386f / num;
					GL.MultiTexCoord2(0, num9, num10);
					GL.MultiTexCoord2(1, 1333f, 1165f);
					GL.Vertex3(num7, num8, 1359f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(1, 12f, 89f);
					GL.Vertex3(num7 + num4, num8, 1761f);
					GL.MultiTexCoord2(1, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 1432f, 1513f);
					GL.Vertex3(num7 + num4, num8 + num5, 1007f);
					GL.MultiTexCoord2(0, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 283f, 1180f);
					GL.Vertex3(num7, num8 + num5, 607f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007EBF RID: 32447 RVA: 0x002A1598 File Offset: 0x0029F798
		private static void FMDDHGDAKOB(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, Texture2D LONLPKDAEAB, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			float num = (float)LONLPKDAEAB.width * 275f;
			float num2 = 1466f * (float)HLBKCLPNHEB.width / NoiseAndGrain.GEIKGLLNCNL;
			NMPKLIAPOEL.SetTexture(":\n", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 1876f * (float)HLBKCLPNHEB.width / (1699f * (float)HLBKCLPNHEB.height);
			float num4 = 297f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)LONLPKDAEAB.width * 176f);
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(1);
			for (float num7 = 1373f; num7 < 35f; num7 += num4)
			{
				for (float num8 = 1311f; num8 < 1193f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(848f, 1594f);
					float num10 = UnityEngine.Random.Range(352f, 662f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 318f / num;
					GL.MultiTexCoord2(0, num9, num10);
					GL.MultiTexCoord2(1, 615f, 799f);
					GL.Vertex3(num7, num8, 1118f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(1, 1592f, 1892f);
					GL.Vertex3(num7 + num4, num8, 6f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 1720f, 1250f);
					GL.Vertex3(num7 + num4, num8 + num5, 1550f);
					GL.MultiTexCoord2(0, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(0, 830f, 1723f);
					GL.Vertex3(num7, num8 + num5, 1791f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007EC0 RID: 32448 RVA: 0x002A177C File Offset: 0x0029F97C
		public virtual bool EAOFDBCPJDI()
		{
			base.DCHKKHDGBLJ(true);
			this.PCLHBJIGNNL = base.ECNEGNMAMDE(this.noiseShader, this.PCLHBJIGNNL);
			if (this.dx11Grain && this.EAKIOBNBAMI)
			{
				this.MONMFLANMBG = base.AJKPGPKKHHB(this.dx11NoiseShader, this.MONMFLANMBG);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.EHBONBLLGBF();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007EC2 RID: 32450 RVA: 0x002A1880 File Offset: 0x0029FA80
		public virtual bool OBEFMKGPJLI()
		{
			base.KNGDKKMDKOG(false);
			this.PCLHBJIGNNL = base.AJKPGPKKHHB(this.noiseShader, this.PCLHBJIGNNL);
			if (this.dx11Grain && this.EAKIOBNBAMI)
			{
				this.MONMFLANMBG = base.LKIJNGDHLAK(this.dx11NoiseShader, this.MONMFLANMBG);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.NJEECGOAICD();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007EC3 RID: 32451 RVA: 0x002A18F4 File Offset: 0x0029FAF4
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources() || null == this.noiseTexture)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				if (null == this.noiseTexture)
				{
					Debug.LogWarning("Noise & Grain effect failing as noise texture is not assigned. please assign.", base.transform);
				}
				return;
			}
			this.softness = Mathf.Clamp(this.softness, 0f, 0.99f);
			if (this.dx11Grain && this.EAKIOBNBAMI)
			{
				this.MONMFLANMBG.SetFloat("_DX11NoiseTime", (float)Time.frameCount);
				this.MONMFLANMBG.SetTexture("_NoiseTex", this.noiseTexture);
				this.MONMFLANMBG.SetVector("_NoisePerChannel", (!this.monochrome) ? this.intensities : Vector3.one);
				this.MONMFLANMBG.SetVector("_MidGrey", new Vector3(this.midGrey, 1f / (1f - this.midGrey), -1f / this.midGrey));
				this.MONMFLANMBG.SetVector("_NoiseAmount", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary = RenderTexture.GetTemporary((int)((float)HLBKCLPNHEB.width * (1f - this.softness)), (int)((float)HLBKCLPNHEB.height * (1f - this.softness)));
					NoiseAndGrain.OFJFPEHMIBB(HLBKCLPNHEB, temporary, this.MONMFLANMBG, this.noiseTexture, (!this.monochrome) ? 2 : 3);
					this.MONMFLANMBG.SetTexture("_NoiseTex", temporary);
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.MONMFLANMBG, 4);
					RenderTexture.ReleaseTemporary(temporary);
				}
				else
				{
					NoiseAndGrain.OFJFPEHMIBB(HLBKCLPNHEB, BMMLHGHKBNM, this.MONMFLANMBG, this.noiseTexture, (!this.monochrome) ? 0 : 1);
				}
			}
			else
			{
				if (this.noiseTexture)
				{
					this.noiseTexture.wrapMode = TextureWrapMode.Repeat;
					this.noiseTexture.filterMode = this.filterMode;
				}
				this.PCLHBJIGNNL.SetTexture("_NoiseTex", this.noiseTexture);
				this.PCLHBJIGNNL.SetVector("_NoisePerChannel", (!this.monochrome) ? this.intensities : Vector3.one);
				this.PCLHBJIGNNL.SetVector("_NoiseTilingPerChannel", (!this.monochrome) ? this.tiling : (Vector3.one * this.monochromeTiling));
				this.PCLHBJIGNNL.SetVector("_MidGrey", new Vector3(this.midGrey, 1f / (1f - this.midGrey), -1f / this.midGrey));
				this.PCLHBJIGNNL.SetVector("_NoiseAmount", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)HLBKCLPNHEB.width * (1f - this.softness)), (int)((float)HLBKCLPNHEB.height * (1f - this.softness)));
					NoiseAndGrain.OFJFPEHMIBB(HLBKCLPNHEB, temporary2, this.PCLHBJIGNNL, this.noiseTexture, 2);
					this.PCLHBJIGNNL.SetTexture("_NoiseTex", temporary2);
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PCLHBJIGNNL, 1);
					RenderTexture.ReleaseTemporary(temporary2);
				}
				else
				{
					NoiseAndGrain.OFJFPEHMIBB(HLBKCLPNHEB, BMMLHGHKBNM, this.PCLHBJIGNNL, this.noiseTexture, 0);
				}
			}
		}

		// Token: 0x06007EC4 RID: 32452 RVA: 0x002A1CB8 File Offset: 0x0029FEB8
		private static void DIECIOMAJPO(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, Texture2D LONLPKDAEAB, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			float num = (float)LONLPKDAEAB.width * 1695f;
			float num2 = 1610f * (float)HLBKCLPNHEB.width / NoiseAndGrain.GEIKGLLNCNL;
			NMPKLIAPOEL.SetTexture("RespawnAfter", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 598f * (float)HLBKCLPNHEB.width / (1140f * (float)HLBKCLPNHEB.height);
			float num4 = 1337f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)LONLPKDAEAB.width * 199f);
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(2);
			for (float num7 = 1027f; num7 < 1667f; num7 += num4)
			{
				for (float num8 = 1867f; num8 < 1668f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(1525f, 193f);
					float num10 = UnityEngine.Random.Range(963f, 1373f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 770f / num;
					GL.MultiTexCoord2(0, num9, num10);
					GL.MultiTexCoord2(0, 1895f, 1644f);
					GL.Vertex3(num7, num8, 950f);
					GL.MultiTexCoord2(1, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(1, 1709f, 1533f);
					GL.Vertex3(num7 + num4, num8, 6f);
					GL.MultiTexCoord2(1, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(0, 461f, 1753f);
					GL.Vertex3(num7 + num4, num8 + num5, 1511f);
					GL.MultiTexCoord2(1, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(0, 1437f, 533f);
					GL.Vertex3(num7, num8 + num5, 1814f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007EC5 RID: 32453 RVA: 0x002A1E9C File Offset: 0x002A009C
		private static void NAADCNCFFJC(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, Texture2D LONLPKDAEAB, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			float num = (float)LONLPKDAEAB.width * 765f;
			float num2 = 536f * (float)HLBKCLPNHEB.width / NoiseAndGrain.GEIKGLLNCNL;
			NMPKLIAPOEL.SetTexture("_Gain", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 89f * (float)HLBKCLPNHEB.width / (481f * (float)HLBKCLPNHEB.height);
			float num4 = 1381f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)LONLPKDAEAB.width * 136f);
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(8);
			for (float num7 = 629f; num7 < 1994f; num7 += num4)
			{
				for (float num8 = 11f; num8 < 875f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(865f, 74f);
					float num10 = UnityEngine.Random.Range(136f, 1926f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 793f / num;
					GL.MultiTexCoord2(1, num9, num10);
					GL.MultiTexCoord2(1, 106f, 63f);
					GL.Vertex3(num7, num8, 1666f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(1, 1737f, 1211f);
					GL.Vertex3(num7 + num4, num8, 987f);
					GL.MultiTexCoord2(1, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 1868f, 70f);
					GL.Vertex3(num7 + num4, num8 + num5, 1278f);
					GL.MultiTexCoord2(0, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 595f, 366f);
					GL.Vertex3(num7, num8 + num5, 79f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007EC7 RID: 32455 RVA: 0x002A208C File Offset: 0x002A028C
		private static void DCAAJHFBMID(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, Texture2D LONLPKDAEAB, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			float num = (float)LONLPKDAEAB.width * 953f;
			float num2 = 1401f * (float)HLBKCLPNHEB.width / NoiseAndGrain.GEIKGLLNCNL;
			NMPKLIAPOEL.SetTexture("_Color", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 1526f * (float)HLBKCLPNHEB.width / (568f * (float)HLBKCLPNHEB.height);
			float num4 = 120f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)LONLPKDAEAB.width * 874f);
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(3);
			for (float num7 = 893f; num7 < 1089f; num7 += num4)
			{
				for (float num8 = 1002f; num8 < 1918f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(29f, 1711f);
					float num10 = UnityEngine.Random.Range(1544f, 275f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 1384f / num;
					GL.MultiTexCoord2(0, num9, num10);
					GL.MultiTexCoord2(1, 970f, 1808f);
					GL.Vertex3(num7, num8, 177f);
					GL.MultiTexCoord2(1, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(0, 510f, 1516f);
					GL.Vertex3(num7 + num4, num8, 243f);
					GL.MultiTexCoord2(1, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 1770f, 524f);
					GL.Vertex3(num7 + num4, num8 + num5, 192f);
					GL.MultiTexCoord2(0, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(0, 1009f, 1062f);
					GL.Vertex3(num7, num8 + num5, 437f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007EC8 RID: 32456 RVA: 0x002A2270 File Offset: 0x002A0470
		public virtual bool AMKCNLBKLDJ()
		{
			base.KHNPMDDIJAJ(true);
			this.PCLHBJIGNNL = base.NODBMINMALP(this.noiseShader, this.PCLHBJIGNNL);
			if (this.dx11Grain && this.EAKIOBNBAMI)
			{
				this.MONMFLANMBG = base.NODBMINMALP(this.dx11NoiseShader, this.MONMFLANMBG);
			}
			if (!this.LMKGCBNNGLI)
			{
				base.EHBONBLLGBF();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007EC9 RID: 32457 RVA: 0x002A22E4 File Offset: 0x002A04E4
		private static void DHIONBCFLOI(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, Texture2D LONLPKDAEAB, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			float num = (float)LONLPKDAEAB.width * 1915f;
			float num2 = 1946f * (float)HLBKCLPNHEB.width / NoiseAndGrain.GEIKGLLNCNL;
			NMPKLIAPOEL.SetTexture("_ScreenResolution", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			float num3 = 1934f * (float)HLBKCLPNHEB.width / (1357f * (float)HLBKCLPNHEB.height);
			float num4 = 1323f / num2;
			float num5 = num4 * num3;
			float num6 = num / ((float)LONLPKDAEAB.width * 964f);
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(6);
			for (float num7 = 1678f; num7 < 448f; num7 += num4)
			{
				for (float num8 = 294f; num8 < 1640f; num8 += num5)
				{
					float num9 = UnityEngine.Random.Range(199f, 1159f);
					float num10 = UnityEngine.Random.Range(669f, 264f);
					num9 = Mathf.Floor(num9 * num) / num;
					num10 = Mathf.Floor(num10 * num) / num;
					float num11 = 1971f / num;
					GL.MultiTexCoord2(1, num9, num10);
					GL.MultiTexCoord2(0, 1315f, 635f);
					GL.Vertex3(num7, num8, 1758f);
					GL.MultiTexCoord2(0, num9 + num6 * num11, num10);
					GL.MultiTexCoord2(0, 262f, 197f);
					GL.Vertex3(num7 + num4, num8, 320f);
					GL.MultiTexCoord2(1, num9 + num6 * num11, num10 + num6 * num11);
					GL.MultiTexCoord2(1, 913f, 237f);
					GL.Vertex3(num7 + num4, num8 + num5, 1029f);
					GL.MultiTexCoord2(1, num9, num10 + num6 * num11);
					GL.MultiTexCoord2(0, 463f, 907f);
					GL.Vertex3(num7, num8 + num5, 415f);
				}
			}
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007ECA RID: 32458 RVA: 0x002A24C8 File Offset: 0x002A06C8
		private void KDFILLAPHIO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources() || null == this.noiseTexture)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				if (null == this.noiseTexture)
				{
					Debug.LogWarning("/", base.transform);
				}
				return;
			}
			this.softness = Mathf.Clamp(this.softness, 1549f, 595f);
			if (this.dx11Grain && this.EAKIOBNBAMI)
			{
				this.MONMFLANMBG.SetFloat("IntraSig", (float)Time.frameCount);
				this.MONMFLANMBG.SetTexture("restrictions\n\n#until: ", this.noiseTexture);
				this.MONMFLANMBG.SetVector("_MainTex", (!this.monochrome) ? this.intensities : Vector3.one);
				this.MONMFLANMBG.SetVector("MenuRecordButton", new Vector3(this.midGrey, 1059f / (893f - this.midGrey), 849f / this.midGrey));
				this.MONMFLANMBG.SetVector("Set sun min/max size", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary = RenderTexture.GetTemporary((int)((float)HLBKCLPNHEB.width * (669f - this.softness)), (int)((float)HLBKCLPNHEB.height * (464f - this.softness)));
					NoiseAndGrain.DCAAJHFBMID(HLBKCLPNHEB, temporary, this.MONMFLANMBG, this.noiseTexture, (!this.monochrome) ? 6 : 1);
					this.MONMFLANMBG.SetTexture("[Up]", temporary);
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.MONMFLANMBG, 2);
					RenderTexture.ReleaseTemporary(temporary);
				}
				else
				{
					NoiseAndGrain.CKJGKMCADHB(HLBKCLPNHEB, BMMLHGHKBNM, this.MONMFLANMBG, this.noiseTexture, (!this.monochrome) ? 0 : 1);
				}
			}
			else
			{
				if (this.noiseTexture)
				{
					this.noiseTexture.wrapMode = TextureWrapMode.Repeat;
					this.noiseTexture.filterMode = this.filterMode;
				}
				this.PCLHBJIGNNL.SetTexture("Hex value #RRGGBB", this.noiseTexture);
				this.PCLHBJIGNNL.SetVector("ControllerLeftY", (!this.monochrome) ? this.intensities : Vector3.one);
				this.PCLHBJIGNNL.SetVector("Set Trail Zoom (player camera move forward effect). Base value - 1.5", (!this.monochrome) ? this.tiling : (Vector3.one * this.monochromeTiling));
				this.PCLHBJIGNNL.SetVector("_Blue_R", new Vector3(this.midGrey, 1980f / (680f - this.midGrey), 200f / this.midGrey));
				this.PCLHBJIGNNL.SetVector("null", new Vector3(this.generalIntensity, this.blackIntensity, this.whiteIntensity) * this.intensityMultiplier);
				if (this.softness > Mathf.Epsilon)
				{
					RenderTexture temporary2 = RenderTexture.GetTemporary((int)((float)HLBKCLPNHEB.width * (1835f - this.softness)), (int)((float)HLBKCLPNHEB.height * (1319f - this.softness)));
					NoiseAndGrain.FBIMKFOINBD(HLBKCLPNHEB, temporary2, this.PCLHBJIGNNL, this.noiseTexture, 1);
					this.PCLHBJIGNNL.SetTexture("_Value3", temporary2);
					Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PCLHBJIGNNL, 0);
					RenderTexture.ReleaseTemporary(temporary2);
				}
				else
				{
					NoiseAndGrain.PHJJPEAIOEC(HLBKCLPNHEB, BMMLHGHKBNM, this.PCLHBJIGNNL, this.noiseTexture, 0);
				}
			}
		}

		// Token: 0x04000E24 RID: 3620
		public float intensityMultiplier = 0.25f;

		// Token: 0x04000E25 RID: 3621
		public float generalIntensity = 0.5f;

		// Token: 0x04000E26 RID: 3622
		public float blackIntensity = 1f;

		// Token: 0x04000E27 RID: 3623
		public float whiteIntensity = 1f;

		// Token: 0x04000E28 RID: 3624
		public float midGrey = 0.2f;

		// Token: 0x04000E29 RID: 3625
		public bool dx11Grain;

		// Token: 0x04000E2A RID: 3626
		public float softness;

		// Token: 0x04000E2B RID: 3627
		public bool monochrome;

		// Token: 0x04000E2C RID: 3628
		public Vector3 intensities = new Vector3(1f, 1f, 1f);

		// Token: 0x04000E2D RID: 3629
		public Vector3 tiling = new Vector3(64f, 64f, 64f);

		// Token: 0x04000E2E RID: 3630
		public float monochromeTiling = 64f;

		// Token: 0x04000E2F RID: 3631
		public FilterMode filterMode = FilterMode.Bilinear;

		// Token: 0x04000E30 RID: 3632
		public Texture2D noiseTexture;

		// Token: 0x04000E31 RID: 3633
		public Shader noiseShader;

		// Token: 0x04000E32 RID: 3634
		private Material PCLHBJIGNNL;

		// Token: 0x04000E33 RID: 3635
		public Shader dx11NoiseShader;

		// Token: 0x04000E34 RID: 3636
		private Material MONMFLANMBG;

		// Token: 0x04000E35 RID: 3637
		private static float GEIKGLLNCNL = 64f;
	}
}
