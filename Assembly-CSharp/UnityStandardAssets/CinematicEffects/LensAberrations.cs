using System;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x02000203 RID: 515
	[ExecuteInEditMode]
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Cinematic/Lens Aberrations")]
	public class LensAberrations : MonoBehaviour
	{
		// Token: 0x06008211 RID: 33297 RVA: 0x002C97A4 File Offset: 0x002C79A4
		private void HDEKADONMPE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.PDEAHJPOMEF().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 712f * Math.Max(Mathf.Abs(this.distortion.amount), 1378f);
				float num = 284f * Math.Min(308f, val);
				float y = 167f * Mathf.Tan(num * 300f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 454f), Mathf.Max(this.distortion.amountY, 893f));
				Vector3 v = new Vector3((this.distortion.amount < 466f) ? (1332f / num) : num, y, 364f / this.distortion.scale);
				this.NFMGLIKNOOC().EnableKeyword((this.distortion.amount < 85f) ? "_ScreenResolution" : "_ScreenResolution");
				this.PLBEJJIHFPB().SetVector("_DisplayVelocityScale", value);
				this.HFBJAOFLCJI().SetVector("CameraFilterPack/Blend2Camera_Hue", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.NFMGLIKNOOC().EnableKeyword("maps.");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 1311f);
				this.NFMGLIKNOOC().SetVector("ChatHistoryInputField", value2);
			}
			if (this.vignette.enabled)
			{
				this.HFBJAOFLCJI().SetColor("Init", this.vignette.color);
				if (this.vignette.blur > 1964f)
				{
					int num2 = HLBKCLPNHEB.width / 0;
					int num3 = HLBKCLPNHEB.height / 6;
					RenderTexture renderTexture = this.DODAGENMBDN.ECGMCKNOBPM(num2, num3, 0, HLBKCLPNHEB.format, FilterMode.Bilinear);
					RenderTexture renderTexture2 = this.DODAGENMBDN.BKOEAHINFBG(num2, num3, 1, HLBKCLPNHEB.format, FilterMode.Bilinear);
					this.PDEAHJPOMEF().SetVector("#discord{0}joinrequest", new Vector2(1736f / (float)num2, 252f));
					Graphics.Blit(HLBKCLPNHEB, renderTexture, this.EPCGJFCCAFH(), 0);
					if (this.distortion.enabled)
					{
						this.PDEAHJPOMEF().DisableKeyword("_Value5");
						this.PLBEJJIHFPB().DisableKeyword("_Offsets");
					}
					this.PDEAHJPOMEF().SetVector("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ", new Vector2(550f, 1477f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.PLBEJJIHFPB(), 1);
					this.material.SetVector("_SmoothStart", new Vector2(1529f / (float)num2, 482f));
					Graphics.Blit(renderTexture2, renderTexture, this.LNLKMDPHDCC(), 1);
					this.NFMGLIKNOOC().SetVector("[PlayerBase] Ready", new Vector2(23f, 281f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.LNLKMDPHDCC(), 1);
					this.LNLKMDPHDCC().SetTexture("To {0} at Index {1} \n", renderTexture2);
					this.material.SetFloat("_Intensity", this.vignette.blur * 1625f);
					this.PDEAHJPOMEF().EnableKeyword("_Value");
					if (this.distortion.enabled)
					{
						this.PLBEJJIHFPB().EnableKeyword((this.distortion.amount < 528f) ? "MenuScene" : "_Value");
					}
				}
				if (this.vignette.desaturate > 573f)
				{
					this.EPCGJFCCAFH().EnableKeyword("float,1");
					this.NFMGLIKNOOC().SetFloat("SetSatelliteTrailLength", 640f - this.vignette.desaturate);
				}
				this.KEMAALEODNH().SetVector("settings_bindings_sec_", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 1310f))
				{
					this.KEMAALEODNH().EnableKeyword("#ranks:");
					this.LNLKMDPHDCC().SetVector("OxOD.lastPath", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.EPCGJFCCAFH().EnableKeyword("L1");
					float z = (171f - this.vignette.roundness) * 1363f + this.vignette.roundness;
					this.LNLKMDPHDCC().SetVector("solo", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 1;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 5;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 0;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 8;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 3;
			}
			else if (this.vignette.enabled)
			{
				pass = 8;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (this.distortion.enabled)
			{
				pass = 7;
			}
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HFBJAOFLCJI(), pass);
			this.DODAGENMBDN.NLAEPPEMDKM();
		}

		// Token: 0x06008212 RID: 33298 RVA: 0x002C9DF4 File Offset: 0x002C7FF4
		private void MHGGJOAHGLL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.NFMGLIKNOOC().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 106f * Math.Max(Mathf.Abs(this.distortion.amount), 572f);
				float num = 1278f * Math.Min(16f, val);
				float y = 888f * Mathf.Tan(num * 894f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 361f), Mathf.Max(this.distortion.amountY, 927f));
				Vector3 v = new Vector3((this.distortion.amount < 1514f) ? (1706f / num) : num, y, 1301f / this.distortion.scale);
				this.material.EnableKeyword((this.distortion.amount < 1433f) ? "CameraFilterPack/TV_Distorted" : "Done! You are a contributor until: ");
				this.HFBJAOFLCJI().SetVector("maps.", value);
				this.HFBJAOFLCJI().SetVector("challenges", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.KEMAALEODNH().EnableKeyword("_TimeX");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 1116f);
				this.PDEAHJPOMEF().SetVector("0,1,true,0", value2);
			}
			if (this.vignette.enabled)
			{
				this.EPCGJFCCAFH().SetColor("Submition failed", this.vignette.color);
				if (this.vignette.blur > 1252f)
				{
					int num2 = HLBKCLPNHEB.width / 2;
					int num3 = HLBKCLPNHEB.height / 3;
					RenderTexture renderTexture = this.DODAGENMBDN.IPNPHDAELAJ(num2, num3, 1, HLBKCLPNHEB.format, FilterMode.Bilinear);
					RenderTexture renderTexture2 = this.DODAGENMBDN.IPNPHDAELAJ(num2, num3, 0, HLBKCLPNHEB.format, FilterMode.Point);
					this.HFBJAOFLCJI().SetVector("Bad parameters for reset! Use \"reset <challengeid>\"", new Vector2(217f / (float)num2, 383f));
					Graphics.Blit(HLBKCLPNHEB, renderTexture, this.PDEAHJPOMEF(), 0);
					if (this.distortion.enabled)
					{
						this.PDEAHJPOMEF().DisableKeyword(".GoalProgress");
						this.KEMAALEODNH().DisableKeyword("EventSystem");
					}
					this.material.SetVector("_TimeX", new Vector2(33f, 433f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.HFBJAOFLCJI(), 1);
					this.NFMGLIKNOOC().SetVector("_CurrentMipLevel", new Vector2(1228f / (float)num2, 1501f));
					Graphics.Blit(renderTexture2, renderTexture, this.PLBEJJIHFPB(), 1);
					this.PLBEJJIHFPB().SetVector("Back", new Vector2(1113f, 1821f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.PLBEJJIHFPB(), 1);
					this.PLBEJJIHFPB().SetTexture("_ToneCurve", renderTexture2);
					this.EPCGJFCCAFH().SetFloat("Parameter levelId can't be null!", this.vignette.blur * 445f);
					this.PDEAHJPOMEF().EnableKeyword("_BloomIntensity");
					if (this.distortion.enabled)
					{
						this.KEMAALEODNH().EnableKeyword((this.distortion.amount < 1333f) ? "SlidingArea" : "Preparing configuration");
					}
				}
				if (this.vignette.desaturate > 1557f)
				{
					this.HFBJAOFLCJI().EnableKeyword("_MatrixSpeed");
					this.PLBEJJIHFPB().SetFloat(" ", 1017f - this.vignette.desaturate);
				}
				this.NFMGLIKNOOC().SetVector("RedoButton", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 769f))
				{
					this.PLBEJJIHFPB().EnableKeyword("LastNewsButton");
					this.PLBEJJIHFPB().SetVector("_Greenness", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.HFBJAOFLCJI().EnableKeyword("Image");
					float z = (1531f - this.vignette.roundness) * 1698f + this.vignette.roundness;
					this.KEMAALEODNH().SetVector("CameraFilterPack_3D_Binary1", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 0;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 2;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 5;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 3;
			}
			else if (this.vignette.enabled)
			{
				pass = 1;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 0;
			}
			else if (this.distortion.enabled)
			{
				pass = 7;
			}
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LNLKMDPHDCC(), pass);
			this.DODAGENMBDN.GDDJLCOAPIO();
		}

		// Token: 0x06008213 RID: 33299 RVA: 0x002CA441 File Offset: 0x002C8641
		public Shader FMOMOEOJFKH()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("LevelEditor/CustomEventEditor-Text");
			}
			return this.m_Shader;
		}

		// Token: 0x06008214 RID: 33300 RVA: 0x002CA46A File Offset: 0x002C866A
		private void HJDPEBAPBPN()
		{
			if (!ImageEffectHelper.IsSupported(this.shader, false, false, this))
			{
				base.enabled = false;
			}
			this.DODAGENMBDN = new RenderTextureUtility();
		}

		// Token: 0x06008215 RID: 33301 RVA: 0x002CA491 File Offset: 0x002C8691
		public Shader IIFGPEOCNOC()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_HitPointTexture");
			}
			return this.m_Shader;
		}

		// Token: 0x06008216 RID: 33302 RVA: 0x002CA4BA File Offset: 0x002C86BA
		public Shader OEOMPCFMEAB()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_TimeX");
			}
			return this.m_Shader;
		}

		// Token: 0x06008217 RID: 33303 RVA: 0x002CA4E3 File Offset: 0x002C86E3
		public Material PLBEJJIHFPB()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.GOLEGOMDLOO());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06008218 RID: 33304 RVA: 0x002CA50D File Offset: 0x002C870D
		private void GFLAINNLMBO()
		{
			if (!ImageEffectHelper.IsSupported(this.GKHMCGLNDAM(), true, true, this))
			{
				base.enabled = false;
			}
			this.DODAGENMBDN = new RenderTextureUtility();
		}

		// Token: 0x06008219 RID: 33305 RVA: 0x002CA534 File Offset: 0x002C8734
		private void KBGCKEDIGAH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.LNLKMDPHDCC().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 1032f * Math.Max(Mathf.Abs(this.distortion.amount), 325f);
				float num = 1193f * Math.Min(353f, val);
				float y = 123f * Mathf.Tan(num * 1913f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 1711f), Mathf.Max(this.distortion.amountY, 1115f));
				Vector3 v = new Vector3((this.distortion.amount < 1808f) ? (1752f / num) : num, y, 1012f / this.distortion.scale);
				this.EPCGJFCCAFH().EnableKeyword((this.distortion.amount < 1263f) ? "Drop_Far" : "y");
				this.material.SetVector("SetRoomStartTimestamp", value);
				this.LNLKMDPHDCC().SetVector("[MenuScene] Error: ", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.PDEAHJPOMEF().EnableKeyword("challenges.");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 228f);
				this.EPCGJFCCAFH().SetVector("Dec", value2);
			}
			if (this.vignette.enabled)
			{
				this.NFMGLIKNOOC().SetColor("Game Version: ", this.vignette.color);
				if (this.vignette.blur > 647f)
				{
					int num2 = HLBKCLPNHEB.width / 7;
					int num3 = HLBKCLPNHEB.height / 1;
					RenderTexture renderTexture = this.DODAGENMBDN.MCMEAEFGPIM(num2, num3, 1, HLBKCLPNHEB.format, FilterMode.Point);
					RenderTexture renderTexture2 = this.DODAGENMBDN.OOIDPBIECDB(num2, num3, 1, HLBKCLPNHEB.format, FilterMode.Bilinear);
					this.PDEAHJPOMEF().SetVector("_Blend", new Vector2(1044f / (float)num2, 1780f));
					Graphics.Blit(HLBKCLPNHEB, renderTexture, this.PLBEJJIHFPB(), 1);
					if (this.distortion.enabled)
					{
						this.PLBEJJIHFPB().DisableKeyword("STICKRVER");
						this.PDEAHJPOMEF().DisableKeyword("offsets");
					}
					this.KEMAALEODNH().SetVector("_Value4", new Vector2(1273f, 1024f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.KEMAALEODNH(), 0);
					this.LNLKMDPHDCC().SetVector("_ScreenResolution", new Vector2(1626f / (float)num2, 519f));
					Graphics.Blit(renderTexture2, renderTexture, this.PLBEJJIHFPB(), 0);
					this.PDEAHJPOMEF().SetVector("_Value3", new Vector2(783f, 434f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.KEMAALEODNH(), 1);
					this.EPCGJFCCAFH().SetTexture("y", renderTexture2);
					this.KEMAALEODNH().SetFloat("_Value2", this.vignette.blur * 762f);
					this.NFMGLIKNOOC().EnableKeyword("_Fade");
					if (this.distortion.enabled)
					{
						this.PDEAHJPOMEF().EnableKeyword((this.distortion.amount < 270f) ? "PAUSE [SPACE]" : " player(s)");
					}
				}
				if (this.vignette.desaturate > 181f)
				{
					this.NFMGLIKNOOC().EnableKeyword("_VignetteSettings");
					this.EPCGJFCCAFH().SetFloat("_ScreenResolution", 417f - this.vignette.desaturate);
				}
				this.NFMGLIKNOOC().SetVector("maps.", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 861f))
				{
					this.HFBJAOFLCJI().EnableKeyword("_SprTex");
					this.LNLKMDPHDCC().SetVector(".message", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.EPCGJFCCAFH().EnableKeyword("Sprite");
					float z = (1362f - this.vignette.roundness) * 1489f + this.vignette.roundness;
					this.NFMGLIKNOOC().SetVector("note.1", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 1;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 2;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 2;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 2;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 4;
			}
			else if (this.vignette.enabled)
			{
				pass = 0;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (this.distortion.enabled)
			{
				pass = 1;
			}
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NFMGLIKNOOC(), pass);
			this.DODAGENMBDN.OFMMDCCCKJK();
		}

		// Token: 0x0600821A RID: 33306 RVA: 0x002CAB84 File Offset: 0x002C8D84
		private void EEFLHPENNEI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.NFMGLIKNOOC().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 654f * Math.Max(Mathf.Abs(this.distortion.amount), 1518f);
				float num = 1803f * Math.Min(1894f, val);
				float y = 1405f * Mathf.Tan(num * 728f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 765f), Mathf.Max(this.distortion.amountY, 1247f));
				Vector3 v = new Vector3((this.distortion.amount < 28f) ? (219f / num) : num, y, 384f / this.distortion.scale);
				this.LNLKMDPHDCC().EnableKeyword((this.distortion.amount < 1414f) ? "mapselector.tags." : "player.mysteryitem");
				this.PDEAHJPOMEF().SetVector("RanksButton", value);
				this.material.SetVector("There is already a virtual button named ", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.PLBEJJIHFPB().EnableKeyword("_Radius");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 1629f);
				this.HFBJAOFLCJI().SetVector("CameraFilterPack/BlurTiltShift_V", value2);
			}
			if (this.vignette.enabled)
			{
				this.EPCGJFCCAFH().SetColor("RT", this.vignette.color);
				if (this.vignette.blur > 1105f)
				{
					int num2 = HLBKCLPNHEB.width / 7;
					int num3 = HLBKCLPNHEB.height / 1;
					RenderTexture temporaryRenderTexture = this.DODAGENMBDN.GetTemporaryRenderTexture(num2, num3, 0, HLBKCLPNHEB.format, FilterMode.Point);
					RenderTexture renderTexture = this.DODAGENMBDN.ECGMCKNOBPM(num2, num3, 1, HLBKCLPNHEB.format, FilterMode.Point);
					this.LNLKMDPHDCC().SetVector("_MainTex", new Vector2(171f / (float)num2, 80f));
					Graphics.Blit(HLBKCLPNHEB, temporaryRenderTexture, this.HFBJAOFLCJI(), 0);
					if (this.distortion.enabled)
					{
						this.KEMAALEODNH().DisableKeyword("Data/Editor/leveltemplate");
						this.EPCGJFCCAFH().DisableKeyword("CameraFilterPack/Drawing_Paper3");
					}
					this.HFBJAOFLCJI().SetVector("/", new Vector2(740f, 400f / (float)num3));
					Graphics.Blit(temporaryRenderTexture, renderTexture, this.PLBEJJIHFPB(), 0);
					this.PDEAHJPOMEF().SetVector("ERROR", new Vector2(1096f / (float)num2, 450f));
					Graphics.Blit(renderTexture, temporaryRenderTexture, this.EPCGJFCCAFH(), 1);
					this.PLBEJJIHFPB().SetVector("_Value2", new Vector2(715f, 573f / (float)num3));
					Graphics.Blit(temporaryRenderTexture, renderTexture, this.material, 0);
					this.PLBEJJIHFPB().SetTexture("#ok", renderTexture);
					this.material.SetFloat(" at ", this.vignette.blur * 1674f);
					this.PDEAHJPOMEF().EnableKeyword("ResourceIDInputField");
					if (this.distortion.enabled)
					{
						this.LNLKMDPHDCC().EnableKeyword((this.distortion.amount < 905f) ? "_ScreenResolution" : "init");
					}
				}
				if (this.vignette.desaturate > 121f)
				{
					this.KEMAALEODNH().EnableKeyword("Set sun colors");
					this.PLBEJJIHFPB().SetFloat("cancel", 996f - this.vignette.desaturate);
				}
				this.NFMGLIKNOOC().SetVector("SetParent", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 272f))
				{
					this.HFBJAOFLCJI().EnableKeyword("yyyy-MM-dd HH:mm:ss");
					this.KEMAALEODNH().SetVector("Failed to InstantiateSceneObject prefab: ", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.KEMAALEODNH().EnableKeyword("settings_bindings_");
					float z = (1271f - this.vignette.roundness) * 151f + this.vignette.roundness;
					this.HFBJAOFLCJI().SetVector("ERROR: Steam App ID isn't set! Make sure 'steam_appid.txt' is placed next to the executable file, and contains a single line with the app id.", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 0;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 8;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 3;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 4;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 6;
			}
			else if (this.vignette.enabled)
			{
				pass = 1;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 0;
			}
			else if (this.distortion.enabled)
			{
				pass = 1;
			}
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.PDEAHJPOMEF(), pass);
			this.DODAGENMBDN.FDJJEOECGCL();
		}

		// Token: 0x0600821B RID: 33307 RVA: 0x002CB1D1 File Offset: 0x002C93D1
		public Shader AJJIFKJBKKI()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("Network destroy Instantiated GO: ");
			}
			return this.m_Shader;
		}

		// Token: 0x0600821C RID: 33308 RVA: 0x002CA4E3 File Offset: 0x002C86E3
		public Material NFMGLIKNOOC()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.GOLEGOMDLOO());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600821D RID: 33309 RVA: 0x002CB1FA File Offset: 0x002C93FA
		public Material material
		{
			get
			{
				if (this.JLHCDOPFJOI == null)
				{
					this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.shader);
				}
				return this.JLHCDOPFJOI;
			}
		}

		// Token: 0x0600821E RID: 33310 RVA: 0x002CB224 File Offset: 0x002C9424
		public Shader GOLEGOMDLOO()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find(" not exist");
			}
			return this.m_Shader;
		}

		// Token: 0x0600821F RID: 33311 RVA: 0x002CB250 File Offset: 0x002C9450
		private void GHOAOEKHEKI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.material.shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 252f * Math.Max(Mathf.Abs(this.distortion.amount), 691f);
				float num = 717f * Math.Min(1225f, val);
				float y = 374f * Mathf.Tan(num * 1575f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 1993f), Mathf.Max(this.distortion.amountY, 1076f));
				Vector3 v = new Vector3((this.distortion.amount < 1146f) ? (402f / num) : num, y, 1654f / this.distortion.scale);
				this.PLBEJJIHFPB().EnableKeyword((this.distortion.amount < 1456f) ? "_ConsoleSettings" : " Mb");
				this.HFBJAOFLCJI().SetVector("_TimeX", value);
				this.NFMGLIKNOOC().SetVector("[PlayerController] ", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.material.EnableKeyword("public");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 14f);
				this.NFMGLIKNOOC().SetVector("RoomDescriptionText", value2);
			}
			if (this.vignette.enabled)
			{
				this.HFBJAOFLCJI().SetColor("BitsData", this.vignette.color);
				if (this.vignette.blur > 636f)
				{
					int num2 = HLBKCLPNHEB.width / 7;
					int num3 = HLBKCLPNHEB.height / 6;
					RenderTexture renderTexture = this.DODAGENMBDN.KCODGJPCOMH(num2, num3, 1, HLBKCLPNHEB.format, FilterMode.Bilinear);
					RenderTexture renderTexture2 = this.DODAGENMBDN.ECGMCKNOBPM(num2, num3, 0, HLBKCLPNHEB.format, FilterMode.Bilinear);
					this.LNLKMDPHDCC().SetVector("Set Particle Size", new Vector2(773f / (float)num2, 134f));
					Graphics.Blit(HLBKCLPNHEB, renderTexture, this.HFBJAOFLCJI(), 0);
					if (this.distortion.enabled)
					{
						this.LNLKMDPHDCC().DisableKeyword("NEW_ACHIEVEMENT_1_");
						this.KEMAALEODNH().DisableKeyword("help");
					}
					this.EPCGJFCCAFH().SetVector("_Bloom5", new Vector2(860f, 1964f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.NFMGLIKNOOC(), 0);
					this.NFMGLIKNOOC().SetVector("settings.arcsnohitsoundtimedelay", new Vector2(97f / (float)num2, 833f));
					Graphics.Blit(renderTexture2, renderTexture, this.material, 1);
					this.KEMAALEODNH().SetVector("Join failed on GameServer. Changing back to MasterServer. Msg: ", new Vector2(1141f, 821f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.PLBEJJIHFPB(), 0);
					this.KEMAALEODNH().SetTexture("Joystick1Button1", renderTexture2);
					this.NFMGLIKNOOC().SetFloat("[LevelEditorScene] Error: You're not logged into Steam!", this.vignette.blur * 108f);
					this.LNLKMDPHDCC().EnableKeyword("Needs to be attached to the Event System component in the scene");
					if (this.distortion.enabled)
					{
						this.PDEAHJPOMEF().EnableKeyword((this.distortion.amount < 567f) ? "powerup.0" : "_Value");
					}
				}
				if (this.vignette.desaturate > 1967f)
				{
					this.PLBEJJIHFPB().EnableKeyword("CameraFilterPack/Drawing_Manga_Flash_Color");
					this.HFBJAOFLCJI().SetFloat("#random #rare #item", 930f - this.vignette.desaturate);
				}
				this.PLBEJJIHFPB().SetVector("_Value3", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 37f))
				{
					this.PDEAHJPOMEF().EnableKeyword("_Value");
					this.LNLKMDPHDCC().SetVector("_Value", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.EPCGJFCCAFH().EnableKeyword("_Params2");
					float z = (833f - this.vignette.roundness) * 979f + this.vignette.roundness;
					this.NFMGLIKNOOC().SetVector("_TimeX", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 1;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 3;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 8;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 2;
			}
			else if (this.vignette.enabled)
			{
				pass = 8;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (this.distortion.enabled)
			{
				pass = 5;
			}
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.material, pass);
			this.DODAGENMBDN.NLAEPPEMDKM();
		}

		// Token: 0x06008220 RID: 33312 RVA: 0x002CB89D File Offset: 0x002C9A9D
		public Material PDEAHJPOMEF()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.FMOMOEOJFKH());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06008221 RID: 33313 RVA: 0x002CB8C7 File Offset: 0x002C9AC7
		private void MHGPANIBBCM()
		{
			if (!ImageEffectHelper.IsSupported(this.GKHMCGLNDAM(), true, true, this))
			{
				base.enabled = true;
			}
			this.DODAGENMBDN = new RenderTextureUtility();
		}

		// Token: 0x06008222 RID: 33314 RVA: 0x002CB89D File Offset: 0x002C9A9D
		public Material LNLKMDPHDCC()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.FMOMOEOJFKH());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06008223 RID: 33315 RVA: 0x002CB8F0 File Offset: 0x002C9AF0
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.material.shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 1.6f * Math.Max(Mathf.Abs(this.distortion.amount), 1f);
				float num = 0.0174532924f * Math.Min(160f, val);
				float y = 2f * Mathf.Tan(num * 0.5f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 0.0001f), Mathf.Max(this.distortion.amountY, 0.0001f));
				Vector3 v = new Vector3((this.distortion.amount < 0f) ? (1f / num) : num, y, 1f / this.distortion.scale);
				this.material.EnableKeyword((this.distortion.amount < 0f) ? "UNDISTORT" : "DISTORT");
				this.material.SetVector("_DistCenterScale", value);
				this.material.SetVector("_DistAmount", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.material.EnableKeyword("CHROMATIC_ABERRATION");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 0.001f);
				this.material.SetVector("_ChromaticAberration", value2);
			}
			if (this.vignette.enabled)
			{
				this.material.SetColor("_VignetteColor", this.vignette.color);
				if (this.vignette.blur > 0f)
				{
					int num2 = HLBKCLPNHEB.width / 2;
					int num3 = HLBKCLPNHEB.height / 2;
					RenderTexture temporaryRenderTexture = this.DODAGENMBDN.GetTemporaryRenderTexture(num2, num3, 0, HLBKCLPNHEB.format, FilterMode.Bilinear);
					RenderTexture temporaryRenderTexture2 = this.DODAGENMBDN.GetTemporaryRenderTexture(num2, num3, 0, HLBKCLPNHEB.format, FilterMode.Bilinear);
					this.material.SetVector("_BlurPass", new Vector2(1f / (float)num2, 0f));
					Graphics.Blit(HLBKCLPNHEB, temporaryRenderTexture, this.material, 0);
					if (this.distortion.enabled)
					{
						this.material.DisableKeyword("DISTORT");
						this.material.DisableKeyword("UNDISTORT");
					}
					this.material.SetVector("_BlurPass", new Vector2(0f, 1f / (float)num3));
					Graphics.Blit(temporaryRenderTexture, temporaryRenderTexture2, this.material, 0);
					this.material.SetVector("_BlurPass", new Vector2(1f / (float)num2, 0f));
					Graphics.Blit(temporaryRenderTexture2, temporaryRenderTexture, this.material, 0);
					this.material.SetVector("_BlurPass", new Vector2(0f, 1f / (float)num3));
					Graphics.Blit(temporaryRenderTexture, temporaryRenderTexture2, this.material, 0);
					this.material.SetTexture("_BlurTex", temporaryRenderTexture2);
					this.material.SetFloat("_VignetteBlur", this.vignette.blur * 3f);
					this.material.EnableKeyword("VIGNETTE_BLUR");
					if (this.distortion.enabled)
					{
						this.material.EnableKeyword((this.distortion.amount < 0f) ? "UNDISTORT" : "DISTORT");
					}
				}
				if (this.vignette.desaturate > 0f)
				{
					this.material.EnableKeyword("VIGNETTE_DESAT");
					this.material.SetFloat("_VignetteDesat", 1f - this.vignette.desaturate);
				}
				this.material.SetVector("_VignetteCenter", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 1f))
				{
					this.material.EnableKeyword("VIGNETTE_CLASSIC");
					this.material.SetVector("_VignetteSettings", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.material.EnableKeyword("VIGNETTE_FILMIC");
					float z = (1f - this.vignette.roundness) * 6f + this.vignette.roundness;
					this.material.SetVector("_VignetteSettings", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 0;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 7;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 5;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 6;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 4;
			}
			else if (this.vignette.enabled)
			{
				pass = 3;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (this.distortion.enabled)
			{
				pass = 2;
			}
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.material, pass);
			this.DODAGENMBDN.ReleaseAllTemporaryRenderTextures();
		}

		// Token: 0x06008224 RID: 33316 RVA: 0x002CBF40 File Offset: 0x002CA140
		private void MDHIALGJMBO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.NFMGLIKNOOC().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 69f * Math.Max(Mathf.Abs(this.distortion.amount), 1214f);
				float num = 1217f * Math.Min(366f, val);
				float y = 367f * Mathf.Tan(num * 841f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 1047f), Mathf.Max(this.distortion.amountY, 1626f));
				Vector3 v = new Vector3((this.distortion.amount < 288f) ? (709f / num) : num, y, 739f / this.distortion.scale);
				this.PLBEJJIHFPB().EnableKeyword((this.distortion.amount < 1615f) ? "float,2" : "Set camera (or player) distance. Base player distance - 14");
				this.LNLKMDPHDCC().SetVector("Bad parameters for init! Use \"init\" or \"init <savename>\"", value);
				this.NFMGLIKNOOC().SetVector(".wav", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.PLBEJJIHFPB().EnableKeyword("Editor/");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 1059f);
				this.NFMGLIKNOOC().SetVector("GlassesColor", value2);
			}
			if (this.vignette.enabled)
			{
				this.EPCGJFCCAFH().SetColor("_TimeX", this.vignette.color);
				if (this.vignette.blur > 832f)
				{
					int num2 = HLBKCLPNHEB.width / 3;
					int num3 = HLBKCLPNHEB.height / 4;
					RenderTexture renderTexture = this.DODAGENMBDN.BKOEAHINFBG(num2, num3, 1, HLBKCLPNHEB.format, FilterMode.Point);
					RenderTexture renderTexture2 = this.DODAGENMBDN.NPHKOAILONP(num2, num3, 0, HLBKCLPNHEB.format, FilterMode.Bilinear);
					this.material.SetVector("_Value2", new Vector2(1787f / (float)num2, 256f));
					Graphics.Blit(HLBKCLPNHEB, renderTexture, this.PDEAHJPOMEF(), 1);
					if (this.distortion.enabled)
					{
						this.EPCGJFCCAFH().DisableKeyword("#highscore");
						this.NFMGLIKNOOC().DisableKeyword("ns");
					}
					this.material.SetVector("player.playedtutorial", new Vector2(1916f, 1695f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.material, 0);
					this.PLBEJJIHFPB().SetVector("#close", new Vector2(856f / (float)num2, 624f));
					Graphics.Blit(renderTexture2, renderTexture, this.LNLKMDPHDCC(), 1);
					this.KEMAALEODNH().SetVector("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", new Vector2(965f, 899f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.HFBJAOFLCJI(), 1);
					this.PDEAHJPOMEF().SetTexture("Moved event", renderTexture2);
					this.material.SetFloat("FinalScoreText", this.vignette.blur * 576f);
					this.HFBJAOFLCJI().EnableKeyword("_GrainTex");
					if (this.distortion.enabled)
					{
						this.HFBJAOFLCJI().EnableKeyword((this.distortion.amount < 1167f) ? "Can't set MaxPlayers when not in that room." : "mapselector.filter.subscribedonly");
					}
				}
				if (this.vignette.desaturate > 1730f)
				{
					this.HFBJAOFLCJI().EnableKeyword("DPADHOR");
					this.material.SetFloat("CameraFilterPack/Alien_Vision", 286f - this.vignette.desaturate);
				}
				this.NFMGLIKNOOC().SetVector("_DotSize", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 1286f))
				{
					this.KEMAALEODNH().EnableKeyword("_TimeX");
					this.material.SetVector("[LocalizationService] Localization: ", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.KEMAALEODNH().EnableKeyword("_ScreenResolution");
					float z = (1773f - this.vignette.roundness) * 770f + this.vignette.roundness;
					this.HFBJAOFLCJI().SetVector("#savemapbeforeuploading", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 1;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 8;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 2;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 2;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 0;
			}
			else if (this.vignette.enabled)
			{
				pass = 2;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (this.distortion.enabled)
			{
				pass = 4;
			}
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.LNLKMDPHDCC(), pass);
			this.DODAGENMBDN.ReleaseAllTemporaryRenderTextures();
		}

		// Token: 0x06008225 RID: 33317 RVA: 0x002CC58D File Offset: 0x002CA78D
		public Material KEMAALEODNH()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.GJMOKEDDCDO());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06008226 RID: 33318 RVA: 0x002CC5B7 File Offset: 0x002CA7B7
		public Shader GJMOKEDDCDO()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("resource");
			}
			return this.m_Shader;
		}

		// Token: 0x06008227 RID: 33319 RVA: 0x002CC5E0 File Offset: 0x002CA7E0
		private void KKHCDAPLABD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.HFBJAOFLCJI().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 1294f * Math.Max(Mathf.Abs(this.distortion.amount), 874f);
				float num = 963f * Math.Min(1552f, val);
				float y = 998f * Mathf.Tan(num * 605f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 1957f), Mathf.Max(this.distortion.amountY, 138f));
				Vector3 v = new Vector3((this.distortion.amount < 232f) ? (1607f / num) : num, y, 1166f / this.distortion.scale);
				this.EPCGJFCCAFH().EnableKeyword((this.distortion.amount < 1421f) ? "workshop." : "Horizontal");
				this.NFMGLIKNOOC().SetVector("_Threshhold", value);
				this.EPCGJFCCAFH().SetVector("turn", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.EPCGJFCCAFH().EnableKeyword("1");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 1700f);
				this.EPCGJFCCAFH().SetVector("[Right]", value2);
			}
			if (this.vignette.enabled)
			{
				this.LNLKMDPHDCC().SetColor("_TimeX", this.vignette.color);
				if (this.vignette.blur > 778f)
				{
					int num2 = HLBKCLPNHEB.width / 6;
					int num3 = HLBKCLPNHEB.height / 6;
					RenderTexture renderTexture = this.DODAGENMBDN.ECGMCKNOBPM(num2, num3, 0, HLBKCLPNHEB.format, FilterMode.Bilinear);
					RenderTexture renderTexture2 = this.DODAGENMBDN.EFDBOOFDPDN(num2, num3, 1, HLBKCLPNHEB.format, FilterMode.Bilinear);
					this.HFBJAOFLCJI().SetVector("_ScreenResolution", new Vector2(740f / (float)num2, 1068f));
					Graphics.Blit(HLBKCLPNHEB, renderTexture, this.HFBJAOFLCJI(), 1);
					if (this.distortion.enabled)
					{
						this.PLBEJJIHFPB().DisableKeyword("_Threshhold");
						this.LNLKMDPHDCC().DisableKeyword("/");
					}
					this.PDEAHJPOMEF().SetVector("_TimeX", new Vector2(955f, 1963f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.PLBEJJIHFPB(), 0);
					this.PDEAHJPOMEF().SetVector("inventory.selected.", new Vector2(480f / (float)num2, 1206f));
					Graphics.Blit(renderTexture2, renderTexture, this.PDEAHJPOMEF(), 0);
					this.EPCGJFCCAFH().SetVector("Stream did not contain properly formatted byte array", new Vector2(1480f, 1150f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.HFBJAOFLCJI(), 1);
					this.EPCGJFCCAFH().SetTexture("_TimeX", renderTexture2);
					this.material.SetFloat("ticket", this.vignette.blur * 1105f);
					this.LNLKMDPHDCC().EnableKeyword("request");
					if (this.distortion.enabled)
					{
						this.PDEAHJPOMEF().EnableKeyword((this.distortion.amount < 1192f) ? "CameraFilterPack/Color_Chromatic_Plus" : "_LightIntensity");
					}
				}
				if (this.vignette.desaturate > 215f)
				{
					this.KEMAALEODNH().EnableKeyword("{0:0} minute{1}, ");
					this.PLBEJJIHFPB().SetFloat("SpawnObj", 526f - this.vignette.desaturate);
				}
				this.EPCGJFCCAFH().SetVector("map.data", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 429f))
				{
					this.material.EnableKeyword("red");
					this.material.SetVector("'{0}' \t{1}ms \t{2}", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.KEMAALEODNH().EnableKeyword("System.Int32");
					float z = (468f - this.vignette.roundness) * 1657f + this.vignette.roundness;
					this.NFMGLIKNOOC().SetVector("wss://", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 1;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 8;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 8;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 7;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 0;
			}
			else if (this.vignette.enabled)
			{
				pass = 2;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (this.distortion.enabled)
			{
				pass = 7;
			}
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HFBJAOFLCJI(), pass);
			this.DODAGENMBDN.NLAEPPEMDKM();
		}

		// Token: 0x06008228 RID: 33320 RVA: 0x002CA46A File Offset: 0x002C866A
		private void OnEnable()
		{
			if (!ImageEffectHelper.IsSupported(this.shader, false, false, this))
			{
				base.enabled = false;
			}
			this.DODAGENMBDN = new RenderTextureUtility();
		}

		// Token: 0x06008229 RID: 33321 RVA: 0x002CB1FA File Offset: 0x002C93FA
		public Material EPCGJFCCAFH()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.shader);
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600822B RID: 33323 RVA: 0x002CC58D File Offset: 0x002CA78D
		public Material HFBJAOFLCJI()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.GJMOKEDDCDO());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600822C RID: 33324 RVA: 0x002CCC56 File Offset: 0x002CAE56
		private void OnDisable()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
			this.DODAGENMBDN.ReleaseAllTemporaryRenderTextures();
		}

		// Token: 0x0600822D RID: 33325 RVA: 0x002CCC88 File Offset: 0x002CAE88
		private void KDFILLAPHIO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.HFBJAOFLCJI().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 1262f * Math.Max(Mathf.Abs(this.distortion.amount), 723f);
				float num = 603f * Math.Min(801f, val);
				float y = 1442f * Mathf.Tan(num * 1065f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 363f), Mathf.Max(this.distortion.amountY, 1430f));
				Vector3 v = new Vector3((this.distortion.amount < 1658f) ? (342f / num) : num, y, 262f / this.distortion.scale);
				this.HFBJAOFLCJI().EnableKeyword((this.distortion.amount < 1527f) ? "/icon" : "_Value2");
				this.HFBJAOFLCJI().SetVector("Failed to InstantiateSceneObject prefab: ", value);
				this.PDEAHJPOMEF().SetVector("_Value4", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.PLBEJJIHFPB().EnableKeyword("CameraFilterPack/Drawing_Manga_Flash");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 1466f);
				this.HFBJAOFLCJI().SetVector("Drop_Far", value2);
			}
			if (this.vignette.enabled)
			{
				this.PDEAHJPOMEF().SetColor("EndlessLoopsScoreText", this.vignette.color);
				if (this.vignette.blur > 1965f)
				{
					int num2 = HLBKCLPNHEB.width / 5;
					int num3 = HLBKCLPNHEB.height / 3;
					RenderTexture renderTexture = this.DODAGENMBDN.MFHJJCMOHFJ(num2, num3, 0, HLBKCLPNHEB.format, FilterMode.Point);
					RenderTexture renderTexture2 = this.DODAGENMBDN.EFDBOOFDPDN(num2, num3, 1, HLBKCLPNHEB.format, FilterMode.Point);
					this.LNLKMDPHDCC().SetVector("\\", new Vector2(702f / (float)num2, 226f));
					Graphics.Blit(HLBKCLPNHEB, renderTexture, this.PDEAHJPOMEF(), 1);
					if (this.distortion.enabled)
					{
						this.KEMAALEODNH().DisableKeyword("_YCrop");
						this.EPCGJFCCAFH().DisableKeyword("[ItemsHandler] Found ");
					}
					this.KEMAALEODNH().SetVector("<color=#{0}>{1}</color>", new Vector2(1853f, 510f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.HFBJAOFLCJI(), 0);
					this.PLBEJJIHFPB().SetVector("_Offsets", new Vector2(1697f / (float)num2, 275f));
					Graphics.Blit(renderTexture2, renderTexture, this.material, 0);
					this.PDEAHJPOMEF().SetVector("HighScaleShot", new Vector2(1094f, 918f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.PLBEJJIHFPB(), 0);
					this.PLBEJJIHFPB().SetTexture("_PrevViewProj", renderTexture2);
					this.KEMAALEODNH().SetFloat("MenuRecordButton", this.vignette.blur * 930f);
					this.HFBJAOFLCJI().EnableKeyword("_SceneFogMode");
					if (this.distortion.enabled)
					{
						this.PDEAHJPOMEF().EnableKeyword((this.distortion.amount < 1808f) ? "SetSatelliteSensitivity" : "_InternalLutParams");
					}
				}
				if (this.vignette.desaturate > 993f)
				{
					this.LNLKMDPHDCC().EnableKeyword(" | Level: ");
					this.KEMAALEODNH().SetFloat("_Value2", 401f - this.vignette.desaturate);
				}
				this.NFMGLIKNOOC().SetVector("note.2", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 15f))
				{
					this.LNLKMDPHDCC().EnableKeyword(". ActorNr: ");
					this.PLBEJJIHFPB().SetVector("HandleEventLeave for player ID: ", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.KEMAALEODNH().EnableKeyword("_ChannelMixerBlue");
					float z = (1602f - this.vignette.roundness) * 1733f + this.vignette.roundness;
					this.NFMGLIKNOOC().SetVector("Set object anchor to another object", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 1;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 6;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 5;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 5;
			}
			else if (this.vignette.enabled)
			{
				pass = 1;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 0;
			}
			else if (this.distortion.enabled)
			{
				pass = 6;
			}
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.material, pass);
			this.DODAGENMBDN.EGKFLFHHGBF();
		}

		// Token: 0x0600822E RID: 33326 RVA: 0x002CD2D5 File Offset: 0x002CB4D5
		public Shader GKHMCGLNDAM()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("EventSystem");
			}
			return this.m_Shader;
		}

		// Token: 0x0600822F RID: 33327 RVA: 0x002CD2FE File Offset: 0x002CB4FE
		public Shader BPGLBABLFOO()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("#ok");
			}
			return this.m_Shader;
		}

		// Token: 0x06008230 RID: 33328 RVA: 0x002CD327 File Offset: 0x002CB527
		public Shader NLECFJKGKJD()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("didAuthenticate ");
			}
			return this.m_Shader;
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06008231 RID: 33329 RVA: 0x002CD350 File Offset: 0x002CB550
		public Shader shader
		{
			get
			{
				if (this.m_Shader == null)
				{
					this.m_Shader = Shader.Find("Hidden/LensAberrations");
				}
				return this.m_Shader;
			}
		}

		// Token: 0x06008232 RID: 33330 RVA: 0x002CD37C File Offset: 0x002CB57C
		private void GKJFBIJGCHP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.LNLKMDPHDCC().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 906f * Math.Max(Mathf.Abs(this.distortion.amount), 1299f);
				float num = 1389f * Math.Min(680f, val);
				float y = 1814f * Mathf.Tan(num * 1383f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 113f), Mathf.Max(this.distortion.amountY, 128f));
				Vector3 v = new Vector3((this.distortion.amount < 94f) ? (860f / num) : num, y, 1385f / this.distortion.scale);
				this.NFMGLIKNOOC().EnableKeyword((this.distortion.amount < 1433f) ? "," : "_TimeX");
				this.HFBJAOFLCJI().SetVector("workshop.", value);
				this.PLBEJJIHFPB().SetVector("float,0", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.LNLKMDPHDCC().EnableKeyword("EventData0DropDownList");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 136f);
				this.PLBEJJIHFPB().SetVector("_MainTex2", value2);
			}
			if (this.vignette.enabled)
			{
				this.HFBJAOFLCJI().SetColor("Joystick1Button9", this.vignette.color);
				if (this.vignette.blur > 412f)
				{
					int num2 = HLBKCLPNHEB.width / 8;
					int num3 = HLBKCLPNHEB.height / 7;
					RenderTexture renderTexture = this.DODAGENMBDN.KCODGJPCOMH(num2, num3, 1, HLBKCLPNHEB.format, FilterMode.Bilinear);
					RenderTexture renderTexture2 = this.DODAGENMBDN.MCMEAEFGPIM(num2, num3, 1, HLBKCLPNHEB.format, FilterMode.Bilinear);
					this.EPCGJFCCAFH().SetVector(".lastCheckpoint.lives", new Vector2(954f / (float)num2, 599f));
					Graphics.Blit(HLBKCLPNHEB, renderTexture, this.NFMGLIKNOOC(), 0);
					if (this.distortion.enabled)
					{
						this.KEMAALEODNH().DisableKeyword("[Down-Left]");
						this.NFMGLIKNOOC().DisableKeyword("SetParticlesInput");
					}
					this.NFMGLIKNOOC().SetVector("ENABLE_DITHERING", new Vector2(626f, 1261f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.material, 0);
					this.PDEAHJPOMEF().SetVector(" not exist", new Vector2(1465f / (float)num2, 1358f));
					Graphics.Blit(renderTexture2, renderTexture, this.NFMGLIKNOOC(), 0);
					this.LNLKMDPHDCC().SetVector("https://reddit.com/r/Intralism", new Vector2(1472f, 1787f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.PDEAHJPOMEF(), 1);
					this.material.SetTexture("_TimeX", renderTexture2);
					this.LNLKMDPHDCC().SetFloat("settings_bindings_controller_type", this.vignette.blur * 1148f);
					this.EPCGJFCCAFH().EnableKeyword("#kicked");
					if (this.distortion.enabled)
					{
						this.HFBJAOFLCJI().EnableKeyword((this.distortion.amount < 485f) ? "notready" : "_Value1");
					}
				}
				if (this.vignette.desaturate > 1082f)
				{
					this.PLBEJJIHFPB().EnableKeyword("_Fade");
					this.HFBJAOFLCJI().SetFloat("SetSatelliteTrailMinVertexDistance", 1557f - this.vignette.desaturate);
				}
				this.NFMGLIKNOOC().SetVector("[Up]", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 552f))
				{
					this.material.EnableKeyword("_Value");
					this.LNLKMDPHDCC().SetVector("_TimeX", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.KEMAALEODNH().EnableKeyword(". Check if the server is available.");
					float z = (885f - this.vignette.roundness) * 662f + this.vignette.roundness;
					this.NFMGLIKNOOC().SetVector("_ColorBuffer", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 0;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 6;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 8;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 1;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 6;
			}
			else if (this.vignette.enabled)
			{
				pass = 7;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 0;
			}
			else if (this.distortion.enabled)
			{
				pass = 3;
			}
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.HFBJAOFLCJI(), pass);
			this.DODAGENMBDN.OFMMDCCCKJK();
		}

		// Token: 0x06008233 RID: 33331 RVA: 0x002CD9C9 File Offset: 0x002CBBC9
		private void JNGMIAFLBDL()
		{
			if (this.JLHCDOPFJOI != null)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
			this.DODAGENMBDN.EGKFLFHHGBF();
		}

		// Token: 0x06008234 RID: 33332 RVA: 0x002CD9FC File Offset: 0x002CBBFC
		private void KMAPABACMAG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.vignette.enabled && !this.chromaticAberration.enabled && !this.distortion.enabled)
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			this.NFMGLIKNOOC().shaderKeywords = null;
			if (this.distortion.enabled)
			{
				float val = 1389f * Math.Max(Mathf.Abs(this.distortion.amount), 2f);
				float num = 1126f * Math.Min(87f, val);
				float y = 935f * Mathf.Tan(num * 437f);
				Vector4 value = new Vector4(this.distortion.centerX, this.distortion.centerY, Mathf.Max(this.distortion.amountX, 77f), Mathf.Max(this.distortion.amountY, 1010f));
				Vector3 v = new Vector3((this.distortion.amount < 1460f) ? (1428f / num) : num, y, 1567f / this.distortion.scale);
				this.PDEAHJPOMEF().EnableKeyword((this.distortion.amount < 1331f) ? ").png" : "_Value2");
				this.KEMAALEODNH().SetVector("settings.arcsnohitsoundtimedelay", value);
				this.material.SetVector("FinalScoreText", v);
			}
			if (this.chromaticAberration.enabled)
			{
				this.NFMGLIKNOOC().EnableKeyword("DPADHOR");
				Vector4 value2 = new Vector4(this.chromaticAberration.color.r, this.chromaticAberration.color.g, this.chromaticAberration.color.b, this.chromaticAberration.amount * 214f);
				this.EPCGJFCCAFH().SetVector("_ScreenResolution", value2);
			}
			if (this.vignette.enabled)
			{
				this.material.SetColor("<color=#{0}>{1}</color>", this.vignette.color);
				if (this.vignette.blur > 1677f)
				{
					int num2 = HLBKCLPNHEB.width / 2;
					int num3 = HLBKCLPNHEB.height / 2;
					RenderTexture renderTexture = this.DODAGENMBDN.EKNOKEKMFEL(num2, num3, 1, HLBKCLPNHEB.format, FilterMode.Bilinear);
					RenderTexture renderTexture2 = this.DODAGENMBDN.NHKIPEIACAC(num2, num3, 0, HLBKCLPNHEB.format, FilterMode.Bilinear);
					this.PDEAHJPOMEF().SetVector("PlayerBase_", new Vector2(1080f / (float)num2, 510f));
					Graphics.Blit(HLBKCLPNHEB, renderTexture, this.LNLKMDPHDCC(), 0);
					if (this.distortion.enabled)
					{
						this.KEMAALEODNH().DisableKeyword("maps.");
						this.KEMAALEODNH().DisableKeyword("_Value2");
					}
					this.HFBJAOFLCJI().SetVector("_Value1", new Vector2(1815f, 321f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.PDEAHJPOMEF(), 1);
					this.PDEAHJPOMEF().SetVector("Creating new item...", new Vector2(1268f / (float)num2, 1505f));
					Graphics.Blit(renderTexture2, renderTexture, this.HFBJAOFLCJI(), 1);
					this.PDEAHJPOMEF().SetVector("Fade", new Vector2(1142f, 102f / (float)num3));
					Graphics.Blit(renderTexture, renderTexture2, this.material, 0);
					this.NFMGLIKNOOC().SetTexture("CameraFilterPack/Glow_Glow_Color", renderTexture2);
					this.PLBEJJIHFPB().SetFloat("settings.enablerankingnotifications", this.vignette.blur * 908f);
					this.material.EnableKeyword("Already exist!");
					if (this.distortion.enabled)
					{
						this.HFBJAOFLCJI().EnableKeyword((this.distortion.amount < 553f) ? "Error in Instantiation! The resource's PhotonView count is not the same as in incoming data." : "null");
					}
				}
				if (this.vignette.desaturate > 1189f)
				{
					this.PLBEJJIHFPB().EnableKeyword("_MainTex2");
					this.HFBJAOFLCJI().SetFloat("playing", 1562f - this.vignette.desaturate);
				}
				this.LNLKMDPHDCC().SetVector("event", this.vignette.center);
				if (Mathf.Approximately(this.vignette.roundness, 821f))
				{
					this.LNLKMDPHDCC().EnableKeyword("_Value4");
					this.EPCGJFCCAFH().SetVector("STICKLVER", new Vector2(this.vignette.intensity, this.vignette.smoothness));
				}
				else
				{
					this.NFMGLIKNOOC().EnableKeyword("[PlayerBase] Loaded custom model: ");
					float z = (490f - this.vignette.roundness) * 1741f + this.vignette.roundness;
					this.PLBEJJIHFPB().SetVector("EnableRankedNotificationsToggle", new Vector3(this.vignette.intensity, this.vignette.smoothness, z));
				}
			}
			int pass = 1;
			if (this.vignette.enabled && this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 4;
			}
			else if (this.vignette.enabled && this.chromaticAberration.enabled)
			{
				pass = 0;
			}
			else if (this.vignette.enabled && this.distortion.enabled)
			{
				pass = 0;
			}
			else if (this.chromaticAberration.enabled && this.distortion.enabled)
			{
				pass = 1;
			}
			else if (this.vignette.enabled)
			{
				pass = 6;
			}
			else if (this.chromaticAberration.enabled)
			{
				pass = 1;
			}
			else if (this.distortion.enabled)
			{
				pass = 7;
			}
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, this.NFMGLIKNOOC(), pass);
			this.DODAGENMBDN.DPPFFOPOJCL();
		}

		// Token: 0x04000EC8 RID: 3784
		[LensAberrations.SettingsGroup]
		public LensAberrations.DistortionSettings distortion = LensAberrations.DistortionSettings.defaultSettings;

		// Token: 0x04000EC9 RID: 3785
		[LensAberrations.SettingsGroup]
		public LensAberrations.VignetteSettings vignette = LensAberrations.VignetteSettings.defaultSettings;

		// Token: 0x04000ECA RID: 3786
		[LensAberrations.SettingsGroup]
		public LensAberrations.ChromaticAberrationSettings chromaticAberration = LensAberrations.ChromaticAberrationSettings.defaultSettings;

		// Token: 0x04000ECB RID: 3787
		[SerializeField]
		private Shader m_Shader;

		// Token: 0x04000ECC RID: 3788
		private Material JLHCDOPFJOI;

		// Token: 0x04000ECD RID: 3789
		private RenderTextureUtility DODAGENMBDN;

		// Token: 0x02000204 RID: 516
		[AttributeUsage(AttributeTargets.Field)]
		public class SettingsGroup : Attribute
		{
		}

		// Token: 0x02000205 RID: 517
		[AttributeUsage(AttributeTargets.Field)]
		public class AdvancedSetting : Attribute
		{
		}

		// Token: 0x02000206 RID: 518
		[Serializable]
		public struct DistortionSettings
		{
			// Token: 0x06008237 RID: 33335 RVA: 0x002CE04C File Offset: 0x002CC24C
			public static LensAberrations.DistortionSettings IHMKIGDJKAH()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 721f,
					centerX = 1691f,
					centerY = 1928f,
					amountX = 436f,
					amountY = 191f,
					scale = 1453f
				};
			}

			// Token: 0x06008238 RID: 33336 RVA: 0x002CE0B4 File Offset: 0x002CC2B4
			public static LensAberrations.DistortionSettings FCBIDJLDABO()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 73f,
					centerX = 1344f,
					centerY = 1036f,
					amountX = 978f,
					amountY = 1964f,
					scale = 1804f
				};
			}

			// Token: 0x06008239 RID: 33337 RVA: 0x002CE11C File Offset: 0x002CC31C
			public static LensAberrations.DistortionSettings INDEHPGLEGK()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 149f,
					centerX = 317f,
					centerY = 1398f,
					amountX = 1355f,
					amountY = 617f,
					scale = 1425f
				};
			}

			// Token: 0x0600823A RID: 33338 RVA: 0x002CE184 File Offset: 0x002CC384
			public static LensAberrations.DistortionSettings MLKLBGCKPOO()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 1397f,
					centerX = 316f,
					centerY = 880f,
					amountX = 1314f,
					amountY = 846f,
					scale = 1250f
				};
			}

			// Token: 0x0600823B RID: 33339 RVA: 0x002CE1EC File Offset: 0x002CC3EC
			public static LensAberrations.DistortionSettings AOACBHHEGFA()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 535f,
					centerX = 457f,
					centerY = 1073f,
					amountX = 335f,
					amountY = 797f,
					scale = 146f
				};
			}

			// Token: 0x0600823C RID: 33340 RVA: 0x002CE254 File Offset: 0x002CC454
			public static LensAberrations.DistortionSettings PKJMMJJFJAE()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 1842f,
					centerX = 1296f,
					centerY = 1088f,
					amountX = 855f,
					amountY = 1428f,
					scale = 49f
				};
			}

			// Token: 0x0600823D RID: 33341 RVA: 0x002CE2BC File Offset: 0x002CC4BC
			public static LensAberrations.DistortionSettings IAKAIGHJJJK()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 1892f,
					centerX = 1161f,
					centerY = 1459f,
					amountX = 597f,
					amountY = 694f,
					scale = 1384f
				};
			}

			// Token: 0x0600823E RID: 33342 RVA: 0x002CE324 File Offset: 0x002CC524
			public static LensAberrations.DistortionSettings LOMOMPKEDPL()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 1200f,
					centerX = 813f,
					centerY = 1361f,
					amountX = 544f,
					amountY = 1301f,
					scale = 697f
				};
			}

			// Token: 0x0600823F RID: 33343 RVA: 0x002CE38C File Offset: 0x002CC58C
			public static LensAberrations.DistortionSettings BCOPOEIJONI()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 1429f,
					centerX = 870f,
					centerY = 9f,
					amountX = 1326f,
					amountY = 1791f,
					scale = 809f
				};
			}

			// Token: 0x06008240 RID: 33344 RVA: 0x002CE3F4 File Offset: 0x002CC5F4
			public static LensAberrations.DistortionSettings IOFLMDMLCAG()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 350f,
					centerX = 1093f,
					centerY = 182f,
					amountX = 1217f,
					amountY = 1924f,
					scale = 1508f
				};
			}

			// Token: 0x06008241 RID: 33345 RVA: 0x002CE45C File Offset: 0x002CC65C
			public static LensAberrations.DistortionSettings LBIOOILOAAD()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 822f,
					centerX = 961f,
					centerY = 1397f,
					amountX = 1608f,
					amountY = 1950f,
					scale = 1998f
				};
			}

			// Token: 0x06008242 RID: 33346 RVA: 0x002CE4C4 File Offset: 0x002CC6C4
			public static LensAberrations.DistortionSettings JCLADKAMOLD()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 1444f,
					centerX = 545f,
					centerY = 937f,
					amountX = 1962f,
					amountY = 1628f,
					scale = 1740f
				};
			}

			// Token: 0x06008243 RID: 33347 RVA: 0x002CE52C File Offset: 0x002CC72C
			public static LensAberrations.DistortionSettings HJLGAPEDPJM()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 743f,
					centerX = 741f,
					centerY = 1667f,
					amountX = 1877f,
					amountY = 946f,
					scale = 1667f
				};
			}

			// Token: 0x06008244 RID: 33348 RVA: 0x002CE594 File Offset: 0x002CC794
			public static LensAberrations.DistortionSettings FPMJKNDJCON()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 550f,
					centerX = 1261f,
					centerY = 1417f,
					amountX = 173f,
					amountY = 1171f,
					scale = 262f
				};
			}

			// Token: 0x06008245 RID: 33349 RVA: 0x002CE5FC File Offset: 0x002CC7FC
			public static LensAberrations.DistortionSettings CIHLOMNEHHL()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 1219f,
					centerX = 1419f,
					centerY = 1996f,
					amountX = 793f,
					amountY = 1383f,
					scale = 8f
				};
			}

			// Token: 0x06008246 RID: 33350 RVA: 0x002CE664 File Offset: 0x002CC864
			public static LensAberrations.DistortionSettings EJLLADABOLM()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 277f,
					centerX = 1208f,
					centerY = 391f,
					amountX = 1339f,
					amountY = 1426f,
					scale = 1027f
				};
			}

			// Token: 0x06008247 RID: 33351 RVA: 0x002CE6CC File Offset: 0x002CC8CC
			public static LensAberrations.DistortionSettings KBINDKOODMK()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 624f,
					centerX = 1740f,
					centerY = 1841f,
					amountX = 1359f,
					amountY = 997f,
					scale = 1683f
				};
			}

			// Token: 0x06008248 RID: 33352 RVA: 0x002CE734 File Offset: 0x002CC934
			public static LensAberrations.DistortionSettings DBDJKKLMCGG()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 530f,
					centerX = 1484f,
					centerY = 1344f,
					amountX = 720f,
					amountY = 1301f,
					scale = 853f
				};
			}

			// Token: 0x06008249 RID: 33353 RVA: 0x002CE79C File Offset: 0x002CC99C
			public static LensAberrations.DistortionSettings MHIHHBMBDLP()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 219f,
					centerX = 1182f,
					centerY = 1432f,
					amountX = 838f,
					amountY = 707f,
					scale = 147f
				};
			}

			// Token: 0x0600824A RID: 33354 RVA: 0x002CE804 File Offset: 0x002CCA04
			public static LensAberrations.DistortionSettings BKEJIPPCPDO()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 1805f,
					centerX = 616f,
					centerY = 1735f,
					amountX = 876f,
					amountY = 107f,
					scale = 230f
				};
			}

			// Token: 0x0600824B RID: 33355 RVA: 0x002CE86C File Offset: 0x002CCA6C
			public static LensAberrations.DistortionSettings EDMABHKFEEO()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 518f,
					centerX = 676f,
					centerY = 505f,
					amountX = 1293f,
					amountY = 1316f,
					scale = 1675f
				};
			}

			// Token: 0x0600824C RID: 33356 RVA: 0x002CE8D4 File Offset: 0x002CCAD4
			public static LensAberrations.DistortionSettings AAPGCALKNAK()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 1176f,
					centerX = 37f,
					centerY = 247f,
					amountX = 900f,
					amountY = 844f,
					scale = 426f
				};
			}

			// Token: 0x0600824D RID: 33357 RVA: 0x002CE93C File Offset: 0x002CCB3C
			public static LensAberrations.DistortionSettings MGEOLKPLHOM()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 1758f,
					centerX = 467f,
					centerY = 1036f,
					amountX = 930f,
					amountY = 214f,
					scale = 425f
				};
			}

			// Token: 0x0600824E RID: 33358 RVA: 0x002CE9A4 File Offset: 0x002CCBA4
			public static LensAberrations.DistortionSettings AFJJPFIOEJD()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 766f,
					centerX = 2f,
					centerY = 1136f,
					amountX = 936f,
					amountY = 1540f,
					scale = 281f
				};
			}

			// Token: 0x0600824F RID: 33359 RVA: 0x002CEA0C File Offset: 0x002CCC0C
			public static LensAberrations.DistortionSettings NCFGPFGLKLJ()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 529f,
					centerX = 1086f,
					centerY = 1719f,
					amountX = 491f,
					amountY = 509f,
					scale = 1968f
				};
			}

			// Token: 0x06008250 RID: 33360 RVA: 0x002CEA74 File Offset: 0x002CCC74
			public static LensAberrations.DistortionSettings NOBNMJMOJDB()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 1969f,
					centerX = 840f,
					centerY = 1346f,
					amountX = 172f,
					amountY = 1915f,
					scale = 1505f
				};
			}

			// Token: 0x06008251 RID: 33361 RVA: 0x002CEADC File Offset: 0x002CCCDC
			public static LensAberrations.DistortionSettings DFIOJCABPFD()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 1468f,
					centerX = 1099f,
					centerY = 170f,
					amountX = 1788f,
					amountY = 947f,
					scale = 1377f
				};
			}

			// Token: 0x06008252 RID: 33362 RVA: 0x002CEB44 File Offset: 0x002CCD44
			public static LensAberrations.DistortionSettings EBMPPAMNFNK()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 876f,
					centerX = 430f,
					centerY = 174f,
					amountX = 1636f,
					amountY = 1299f,
					scale = 557f
				};
			}

			// Token: 0x06008253 RID: 33363 RVA: 0x002CEBAC File Offset: 0x002CCDAC
			public static LensAberrations.DistortionSettings CCADIDPNEKH()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 1714f,
					centerX = 332f,
					centerY = 668f,
					amountX = 919f,
					amountY = 1200f,
					scale = 1571f
				};
			}

			// Token: 0x06008254 RID: 33364 RVA: 0x002CEC14 File Offset: 0x002CCE14
			public static LensAberrations.DistortionSettings MNKGFGNDKED()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 1509f,
					centerX = 1707f,
					centerY = 1522f,
					amountX = 1592f,
					amountY = 1620f,
					scale = 145f
				};
			}

			// Token: 0x06008255 RID: 33365 RVA: 0x002CEC7C File Offset: 0x002CCE7C
			public static LensAberrations.DistortionSettings GJNKFICGFFG()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 71f,
					centerX = 681f,
					centerY = 1047f,
					amountX = 1909f,
					amountY = 513f,
					scale = 1406f
				};
			}

			// Token: 0x06008256 RID: 33366 RVA: 0x002CECE4 File Offset: 0x002CCEE4
			public static LensAberrations.DistortionSettings BOMFHCIHHIP()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 1210f,
					centerX = 754f,
					centerY = 1640f,
					amountX = 505f,
					amountY = 1174f,
					scale = 1504f
				};
			}

			// Token: 0x06008257 RID: 33367 RVA: 0x002CED4C File Offset: 0x002CCF4C
			public static LensAberrations.DistortionSettings LIDMIPKCHOI()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 1356f,
					centerX = 842f,
					centerY = 861f,
					amountX = 1817f,
					amountY = 1276f,
					scale = 475f
				};
			}

			// Token: 0x1700018B RID: 395
			// (get) Token: 0x06008258 RID: 33368 RVA: 0x002CEDB4 File Offset: 0x002CCFB4
			public static LensAberrations.DistortionSettings defaultSettings
			{
				get
				{
					return new LensAberrations.DistortionSettings
					{
						enabled = false,
						amount = 0f,
						centerX = 0f,
						centerY = 0f,
						amountX = 1f,
						amountY = 1f,
						scale = 1f
					};
				}
			}

			// Token: 0x06008259 RID: 33369 RVA: 0x002CEE1C File Offset: 0x002CD01C
			public static LensAberrations.DistortionSettings EEMMJNPOFOB()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 1231f,
					centerX = 1960f,
					centerY = 355f,
					amountX = 1354f,
					amountY = 46f,
					scale = 1092f
				};
			}

			// Token: 0x0600825A RID: 33370 RVA: 0x002CEE84 File Offset: 0x002CD084
			public static LensAberrations.DistortionSettings OIPFKIPOECC()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 1451f,
					centerX = 1874f,
					centerY = 1518f,
					amountX = 1367f,
					amountY = 1110f,
					scale = 593f
				};
			}

			// Token: 0x0600825B RID: 33371 RVA: 0x002CEEEC File Offset: 0x002CD0EC
			public static LensAberrations.DistortionSettings IAKJOAGBDGO()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 1344f,
					centerX = 261f,
					centerY = 374f,
					amountX = 1512f,
					amountY = 1750f,
					scale = 18f
				};
			}

			// Token: 0x0600825C RID: 33372 RVA: 0x002CEF54 File Offset: 0x002CD154
			public static LensAberrations.DistortionSettings CJFONFEOHIO()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 99f,
					centerX = 423f,
					centerY = 1308f,
					amountX = 879f,
					amountY = 1484f,
					scale = 471f
				};
			}

			// Token: 0x0600825D RID: 33373 RVA: 0x002CEFBC File Offset: 0x002CD1BC
			public static LensAberrations.DistortionSettings NIPPCMNKCMB()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 1116f,
					centerX = 66f,
					centerY = 1953f,
					amountX = 302f,
					amountY = 1948f,
					scale = 1942f
				};
			}

			// Token: 0x0600825E RID: 33374 RVA: 0x002CF024 File Offset: 0x002CD224
			public static LensAberrations.DistortionSettings ELOBECLMGDD()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = true,
					amount = 1021f,
					centerX = 1500f,
					centerY = 170f,
					amountX = 15f,
					amountY = 995f,
					scale = 296f
				};
			}

			// Token: 0x0600825F RID: 33375 RVA: 0x002CF08C File Offset: 0x002CD28C
			public static LensAberrations.DistortionSettings GOKMCEIBFIM()
			{
				return new LensAberrations.DistortionSettings
				{
					enabled = false,
					amount = 349f,
					centerX = 1964f,
					centerY = 1843f,
					amountX = 506f,
					amountY = 506f,
					scale = 1207f
				};
			}

			// Token: 0x04000ECE RID: 3790
			public bool enabled;

			// Token: 0x04000ECF RID: 3791
			[Range(-100f, 100f)]
			[Tooltip("Distortion amount.")]
			public float amount;

			// Token: 0x04000ED0 RID: 3792
			[Tooltip("Distortion center point (X axis).")]
			[Range(-1f, 1f)]
			public float centerX;

			// Token: 0x04000ED1 RID: 3793
			[Tooltip("Distortion center point (Y axis).")]
			[Range(-1f, 1f)]
			public float centerY;

			// Token: 0x04000ED2 RID: 3794
			[Tooltip("Amount multiplier on X axis. Set it to 0 to disable distortion on this axis.")]
			[Range(0f, 1f)]
			public float amountX;

			// Token: 0x04000ED3 RID: 3795
			[Tooltip("Amount multiplier on Y axis. Set it to 0 to disable distortion on this axis.")]
			[Range(0f, 1f)]
			public float amountY;

			// Token: 0x04000ED4 RID: 3796
			[Tooltip("Global screen scaling.")]
			[Range(0.01f, 5f)]
			public float scale;
		}

		// Token: 0x02000207 RID: 519
		[Serializable]
		public struct VignetteSettings
		{
			// Token: 0x06008260 RID: 33376 RVA: 0x002CF0F4 File Offset: 0x002CD2F4
			public static LensAberrations.VignetteSettings KBINDKOODMK()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = true,
					color = new Color(1638f, 486f, 673f, 758f),
					center = new Vector2(1335f, 654f),
					intensity = 48f,
					smoothness = 189f,
					roundness = 435f,
					blur = 539f,
					desaturate = 1320f
				};
			}

			// Token: 0x06008261 RID: 33377 RVA: 0x002CF184 File Offset: 0x002CD384
			public static LensAberrations.VignetteSettings JCLADKAMOLD()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(1572f, 50f, 43f, 37f),
					center = new Vector2(1962f, 628f),
					intensity = 98f,
					smoothness = 1762f,
					roundness = 1601f,
					blur = 1271f,
					desaturate = 19f
				};
			}

			// Token: 0x06008262 RID: 33378 RVA: 0x002CF214 File Offset: 0x002CD414
			public static LensAberrations.VignetteSettings NIPPCMNKCMB()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = true,
					color = new Color(223f, 1317f, 1336f, 1138f),
					center = new Vector2(867f, 1315f),
					intensity = 23f,
					smoothness = 1997f,
					roundness = 872f,
					blur = 431f,
					desaturate = 1073f
				};
			}

			// Token: 0x06008263 RID: 33379 RVA: 0x002CF2A4 File Offset: 0x002CD4A4
			public static LensAberrations.VignetteSettings LOMOMPKEDPL()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(1000f, 1029f, 1034f, 1122f),
					center = new Vector2(1333f, 1781f),
					intensity = 341f,
					smoothness = 1588f,
					roundness = 1027f,
					blur = 1079f,
					desaturate = 1285f
				};
			}

			// Token: 0x06008264 RID: 33380 RVA: 0x002CF334 File Offset: 0x002CD534
			public static LensAberrations.VignetteSettings IHMKIGDJKAH()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(820f, 1495f, 1772f, 387f),
					center = new Vector2(1022f, 1956f),
					intensity = 608f,
					smoothness = 879f,
					roundness = 827f,
					blur = 867f,
					desaturate = 1573f
				};
			}

			// Token: 0x06008265 RID: 33381 RVA: 0x002CF3C4 File Offset: 0x002CD5C4
			public static LensAberrations.VignetteSettings HJLGAPEDPJM()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = true,
					color = new Color(855f, 510f, 1242f, 404f),
					center = new Vector2(1798f, 1718f),
					intensity = 1649f,
					smoothness = 547f,
					roundness = 1811f,
					blur = 1510f,
					desaturate = 35f
				};
			}

			// Token: 0x1700018C RID: 396
			// (get) Token: 0x06008266 RID: 33382 RVA: 0x002CF454 File Offset: 0x002CD654
			public static LensAberrations.VignetteSettings defaultSettings
			{
				get
				{
					return new LensAberrations.VignetteSettings
					{
						enabled = false,
						color = new Color(0f, 0f, 0f, 1f),
						center = new Vector2(0.5f, 0.5f),
						intensity = 1.4f,
						smoothness = 0.8f,
						roundness = 1f,
						blur = 0f,
						desaturate = 0f
					};
				}
			}

			// Token: 0x06008267 RID: 33383 RVA: 0x002CF4E4 File Offset: 0x002CD6E4
			public static LensAberrations.VignetteSettings PKJMMJJFJAE()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = true,
					color = new Color(1405f, 878f, 477f, 977f),
					center = new Vector2(1871f, 233f),
					intensity = 896f,
					smoothness = 1894f,
					roundness = 1958f,
					blur = 1079f,
					desaturate = 1970f
				};
			}

			// Token: 0x06008268 RID: 33384 RVA: 0x002CF574 File Offset: 0x002CD774
			public static LensAberrations.VignetteSettings CCADIDPNEKH()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(1665f, 1524f, 1812f, 1234f),
					center = new Vector2(1000f, 434f),
					intensity = 1183f,
					smoothness = 728f,
					roundness = 13f,
					blur = 1965f,
					desaturate = 1756f
				};
			}

			// Token: 0x06008269 RID: 33385 RVA: 0x002CF604 File Offset: 0x002CD804
			public static LensAberrations.VignetteSettings BKEJIPPCPDO()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(950f, 1967f, 1495f, 53f),
					center = new Vector2(410f, 1920f),
					intensity = 373f,
					smoothness = 898f,
					roundness = 336f,
					blur = 512f,
					desaturate = 342f
				};
			}

			// Token: 0x0600826A RID: 33386 RVA: 0x002CF694 File Offset: 0x002CD894
			public static LensAberrations.VignetteSettings EDMABHKFEEO()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(70f, 625f, 1226f, 765f),
					center = new Vector2(1480f, 917f),
					intensity = 169f,
					smoothness = 1117f,
					roundness = 1552f,
					blur = 1352f,
					desaturate = 243f
				};
			}

			// Token: 0x0600826B RID: 33387 RVA: 0x002CF724 File Offset: 0x002CD924
			public static LensAberrations.VignetteSettings MNKGFGNDKED()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = true,
					color = new Color(1949f, 951f, 1920f, 350f),
					center = new Vector2(1501f, 1815f),
					intensity = 361f,
					smoothness = 568f,
					roundness = 1360f,
					blur = 1864f,
					desaturate = 1231f
				};
			}

			// Token: 0x0600826C RID: 33388 RVA: 0x002CF7B4 File Offset: 0x002CD9B4
			public static LensAberrations.VignetteSettings INDEHPGLEGK()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(1728f, 1263f, 873f, 1872f),
					center = new Vector2(149f, 425f),
					intensity = 870f,
					smoothness = 719f,
					roundness = 425f,
					blur = 1004f,
					desaturate = 467f
				};
			}

			// Token: 0x0600826D RID: 33389 RVA: 0x002CF844 File Offset: 0x002CDA44
			public static LensAberrations.VignetteSettings AOACBHHEGFA()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(1467f, 1429f, 1340f, 1311f),
					center = new Vector2(1386f, 1521f),
					intensity = 1072f,
					smoothness = 1811f,
					roundness = 414f,
					blur = 1435f,
					desaturate = 1769f
				};
			}

			// Token: 0x0600826E RID: 33390 RVA: 0x002CF8D4 File Offset: 0x002CDAD4
			public static LensAberrations.VignetteSettings IAKJOAGBDGO()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(1837f, 1794f, 483f, 407f),
					center = new Vector2(955f, 767f),
					intensity = 1777f,
					smoothness = 1003f,
					roundness = 83f,
					blur = 264f,
					desaturate = 1654f
				};
			}

			// Token: 0x0600826F RID: 33391 RVA: 0x002CF964 File Offset: 0x002CDB64
			public static LensAberrations.VignetteSettings OIPFKIPOECC()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = true,
					color = new Color(1548f, 357f, 877f, 211f),
					center = new Vector2(1966f, 853f),
					intensity = 1240f,
					smoothness = 267f,
					roundness = 1540f,
					blur = 309f,
					desaturate = 769f
				};
			}

			// Token: 0x06008270 RID: 33392 RVA: 0x002CF9F4 File Offset: 0x002CDBF4
			public static LensAberrations.VignetteSettings CIHLOMNEHHL()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = true,
					color = new Color(1702f, 169f, 1150f, 214f),
					center = new Vector2(1951f, 910f),
					intensity = 1151f,
					smoothness = 149f,
					roundness = 1738f,
					blur = 79f,
					desaturate = 1183f
				};
			}

			// Token: 0x06008271 RID: 33393 RVA: 0x002CFA84 File Offset: 0x002CDC84
			public static LensAberrations.VignetteSettings ELOBECLMGDD()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(1100f, 1290f, 906f, 839f),
					center = new Vector2(1688f, 416f),
					intensity = 1022f,
					smoothness = 504f,
					roundness = 752f,
					blur = 1383f,
					desaturate = 1072f
				};
			}

			// Token: 0x06008272 RID: 33394 RVA: 0x002CFB14 File Offset: 0x002CDD14
			public static LensAberrations.VignetteSettings DBDJKKLMCGG()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(1119f, 396f, 806f, 1181f),
					center = new Vector2(1173f, 917f),
					intensity = 267f,
					smoothness = 1236f,
					roundness = 160f,
					blur = 574f,
					desaturate = 456f
				};
			}

			// Token: 0x06008273 RID: 33395 RVA: 0x002CFBA4 File Offset: 0x002CDDA4
			public static LensAberrations.VignetteSettings IAKAIGHJJJK()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(1297f, 146f, 500f, 1408f),
					center = new Vector2(1674f, 1285f),
					intensity = 1389f,
					smoothness = 1429f,
					roundness = 1022f,
					blur = 756f,
					desaturate = 1619f
				};
			}

			// Token: 0x06008274 RID: 33396 RVA: 0x002CFC34 File Offset: 0x002CDE34
			public static LensAberrations.VignetteSettings BOMFHCIHHIP()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(742f, 1060f, 1274f, 705f),
					center = new Vector2(212f, 1503f),
					intensity = 1300f,
					smoothness = 1446f,
					roundness = 537f,
					blur = 213f,
					desaturate = 1220f
				};
			}

			// Token: 0x06008275 RID: 33397 RVA: 0x002CFCC4 File Offset: 0x002CDEC4
			public static LensAberrations.VignetteSettings EBMPPAMNFNK()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = true,
					color = new Color(1559f, 1452f, 1771f, 841f),
					center = new Vector2(1755f, 1306f),
					intensity = 290f,
					smoothness = 1567f,
					roundness = 1789f,
					blur = 1145f,
					desaturate = 1171f
				};
			}

			// Token: 0x06008276 RID: 33398 RVA: 0x002CFD54 File Offset: 0x002CDF54
			public static LensAberrations.VignetteSettings NCFGPFGLKLJ()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = true,
					color = new Color(1828f, 1570f, 1634f, 353f),
					center = new Vector2(1097f, 1244f),
					intensity = 1735f,
					smoothness = 579f,
					roundness = 1035f,
					blur = 775f,
					desaturate = 948f
				};
			}

			// Token: 0x06008277 RID: 33399 RVA: 0x002CFDE4 File Offset: 0x002CDFE4
			public static LensAberrations.VignetteSettings MLKLBGCKPOO()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(841f, 982f, 328f, 152f),
					center = new Vector2(1098f, 1063f),
					intensity = 1630f,
					smoothness = 1621f,
					roundness = 1661f,
					blur = 839f,
					desaturate = 1709f
				};
			}

			// Token: 0x06008278 RID: 33400 RVA: 0x002CFE74 File Offset: 0x002CE074
			public static LensAberrations.VignetteSettings AAPGCALKNAK()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(1881f, 1400f, 1090f, 80f),
					center = new Vector2(743f, 1531f),
					intensity = 1435f,
					smoothness = 1703f,
					roundness = 1123f,
					blur = 366f,
					desaturate = 904f
				};
			}

			// Token: 0x06008279 RID: 33401 RVA: 0x002CFF04 File Offset: 0x002CE104
			public static LensAberrations.VignetteSettings EEMMJNPOFOB()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(282f, 1774f, 1764f, 1074f),
					center = new Vector2(169f, 1653f),
					intensity = 1376f,
					smoothness = 718f,
					roundness = 433f,
					blur = 1559f,
					desaturate = 1758f
				};
			}

			// Token: 0x0600827A RID: 33402 RVA: 0x002CFF94 File Offset: 0x002CE194
			public static LensAberrations.VignetteSettings LIDMIPKCHOI()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = true,
					color = new Color(1673f, 171f, 874f, 44f),
					center = new Vector2(1057f, 1430f),
					intensity = 1674f,
					smoothness = 1753f,
					roundness = 1632f,
					blur = 400f,
					desaturate = 1089f
				};
			}

			// Token: 0x0600827B RID: 33403 RVA: 0x002D0024 File Offset: 0x002CE224
			public static LensAberrations.VignetteSettings DFIOJCABPFD()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = true,
					color = new Color(254f, 1622f, 671f, 1347f),
					center = new Vector2(1652f, 315f),
					intensity = 689f,
					smoothness = 1773f,
					roundness = 22f,
					blur = 195f,
					desaturate = 1603f
				};
			}

			// Token: 0x0600827C RID: 33404 RVA: 0x002D00B4 File Offset: 0x002CE2B4
			public static LensAberrations.VignetteSettings AFJJPFIOEJD()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(1518f, 256f, 421f, 1030f),
					center = new Vector2(1412f, 712f),
					intensity = 994f,
					smoothness = 247f,
					roundness = 1905f,
					blur = 1917f,
					desaturate = 585f
				};
			}

			// Token: 0x0600827D RID: 33405 RVA: 0x002D0144 File Offset: 0x002CE344
			public static LensAberrations.VignetteSettings EJLLADABOLM()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(149f, 1302f, 1435f, 920f),
					center = new Vector2(1527f, 1247f),
					intensity = 246f,
					smoothness = 381f,
					roundness = 311f,
					blur = 453f,
					desaturate = 491f
				};
			}

			// Token: 0x0600827E RID: 33406 RVA: 0x002D01D4 File Offset: 0x002CE3D4
			public static LensAberrations.VignetteSettings FPMJKNDJCON()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = true,
					color = new Color(1676f, 632f, 1066f, 1907f),
					center = new Vector2(1196f, 735f),
					intensity = 16f,
					smoothness = 584f,
					roundness = 901f,
					blur = 261f,
					desaturate = 181f
				};
			}

			// Token: 0x0600827F RID: 33407 RVA: 0x002D0264 File Offset: 0x002CE464
			public static LensAberrations.VignetteSettings LBIOOILOAAD()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(36f, 1351f, 411f, 263f),
					center = new Vector2(570f, 697f),
					intensity = 1297f,
					smoothness = 1080f,
					roundness = 1358f,
					blur = 205f,
					desaturate = 1164f
				};
			}

			// Token: 0x06008280 RID: 33408 RVA: 0x002D02F4 File Offset: 0x002CE4F4
			public static LensAberrations.VignetteSettings FCBIDJLDABO()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = true,
					color = new Color(63f, 1722f, 1475f, 1825f),
					center = new Vector2(1968f, 342f),
					intensity = 1954f,
					smoothness = 252f,
					roundness = 791f,
					blur = 1498f,
					desaturate = 1980f
				};
			}

			// Token: 0x06008281 RID: 33409 RVA: 0x002D0384 File Offset: 0x002CE584
			public static LensAberrations.VignetteSettings GJNKFICGFFG()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = true,
					color = new Color(1553f, 750f, 1553f, 195f),
					center = new Vector2(1485f, 375f),
					intensity = 1465f,
					smoothness = 1764f,
					roundness = 1982f,
					blur = 1624f,
					desaturate = 328f
				};
			}

			// Token: 0x06008282 RID: 33410 RVA: 0x002D0414 File Offset: 0x002CE614
			public static LensAberrations.VignetteSettings BCOPOEIJONI()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = false,
					color = new Color(1084f, 319f, 1036f, 1967f),
					center = new Vector2(1085f, 1991f),
					intensity = 1051f,
					smoothness = 1974f,
					roundness = 50f,
					blur = 572f,
					desaturate = 956f
				};
			}

			// Token: 0x06008283 RID: 33411 RVA: 0x002D04A4 File Offset: 0x002CE6A4
			public static LensAberrations.VignetteSettings MHIHHBMBDLP()
			{
				return new LensAberrations.VignetteSettings
				{
					enabled = true,
					color = new Color(1862f, 1098f, 196f, 784f),
					center = new Vector2(0f, 33f),
					intensity = 662f,
					smoothness = 598f,
					roundness = 667f,
					blur = 1718f,
					desaturate = 1316f
				};
			}

			// Token: 0x04000ED5 RID: 3797
			public bool enabled;

			// Token: 0x04000ED6 RID: 3798
			[Tooltip("Vignette color. Use the alpha channel for transparency.")]
			[ColorUsage(false)]
			public Color color;

			// Token: 0x04000ED7 RID: 3799
			[Tooltip("Sets the vignette center point (screen center is [0.5,0.5]).")]
			public Vector2 center;

			// Token: 0x04000ED8 RID: 3800
			[Range(0f, 3f)]
			[Tooltip("Amount of vignetting on screen.")]
			public float intensity;

			// Token: 0x04000ED9 RID: 3801
			[Tooltip("Smoothness of the vignette borders.")]
			[Range(0.01f, 3f)]
			public float smoothness;

			// Token: 0x04000EDA RID: 3802
			[Tooltip("Lower values will make a square-ish vignette.")]
			[Range(0f, 1f)]
			[LensAberrations.AdvancedSetting]
			public float roundness;

			// Token: 0x04000EDB RID: 3803
			[Tooltip("Blurs the corners of the screen. Leave this at 0 to disable it.")]
			[Range(0f, 1f)]
			public float blur;

			// Token: 0x04000EDC RID: 3804
			[Tooltip("Desaturate the corners of the screen. Leave this to 0 to disable it.")]
			[Range(0f, 1f)]
			public float desaturate;
		}

		// Token: 0x02000208 RID: 520
		[Serializable]
		public struct ChromaticAberrationSettings
		{
			// Token: 0x06008284 RID: 33412 RVA: 0x002D0534 File Offset: 0x002CE734
			public static LensAberrations.ChromaticAberrationSettings INDEHPGLEGK()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 1887f
				};
			}

			// Token: 0x1700018D RID: 397
			// (get) Token: 0x06008285 RID: 33413 RVA: 0x002D056C File Offset: 0x002CE76C
			public static LensAberrations.ChromaticAberrationSettings defaultSettings
			{
				get
				{
					return new LensAberrations.ChromaticAberrationSettings
					{
						enabled = false,
						color = Color.green,
						amount = 0f
					};
				}
			}

			// Token: 0x06008286 RID: 33414 RVA: 0x002D05A4 File Offset: 0x002CE7A4
			public static LensAberrations.ChromaticAberrationSettings JCLADKAMOLD()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 1292f
				};
			}

			// Token: 0x06008287 RID: 33415 RVA: 0x002D05DC File Offset: 0x002CE7DC
			public static LensAberrations.ChromaticAberrationSettings EJLLADABOLM()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 991f
				};
			}

			// Token: 0x06008288 RID: 33416 RVA: 0x002D0614 File Offset: 0x002CE814
			public static LensAberrations.ChromaticAberrationSettings LBIOOILOAAD()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 1072f
				};
			}

			// Token: 0x06008289 RID: 33417 RVA: 0x002D064C File Offset: 0x002CE84C
			public static LensAberrations.ChromaticAberrationSettings EEMMJNPOFOB()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 703f
				};
			}

			// Token: 0x0600828A RID: 33418 RVA: 0x002D0684 File Offset: 0x002CE884
			public static LensAberrations.ChromaticAberrationSettings CCADIDPNEKH()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 1947f
				};
			}

			// Token: 0x0600828B RID: 33419 RVA: 0x002D06BC File Offset: 0x002CE8BC
			public static LensAberrations.ChromaticAberrationSettings NIPPCMNKCMB()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 911f
				};
			}

			// Token: 0x0600828C RID: 33420 RVA: 0x002D06F4 File Offset: 0x002CE8F4
			public static LensAberrations.ChromaticAberrationSettings DBDJKKLMCGG()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 5f
				};
			}

			// Token: 0x0600828D RID: 33421 RVA: 0x002D072C File Offset: 0x002CE92C
			public static LensAberrations.ChromaticAberrationSettings MNKGFGNDKED()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 288f
				};
			}

			// Token: 0x0600828E RID: 33422 RVA: 0x002D0764 File Offset: 0x002CE964
			public static LensAberrations.ChromaticAberrationSettings AAPGCALKNAK()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 1635f
				};
			}

			// Token: 0x0600828F RID: 33423 RVA: 0x002D079C File Offset: 0x002CE99C
			public static LensAberrations.ChromaticAberrationSettings DFIOJCABPFD()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 1111f
				};
			}

			// Token: 0x06008290 RID: 33424 RVA: 0x002D07D4 File Offset: 0x002CE9D4
			public static LensAberrations.ChromaticAberrationSettings LOMOMPKEDPL()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = true,
					color = Color.green,
					amount = 277f
				};
			}

			// Token: 0x06008291 RID: 33425 RVA: 0x002D080C File Offset: 0x002CEA0C
			public static LensAberrations.ChromaticAberrationSettings IAKJOAGBDGO()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 398f
				};
			}

			// Token: 0x06008292 RID: 33426 RVA: 0x002D0844 File Offset: 0x002CEA44
			public static LensAberrations.ChromaticAberrationSettings IHMKIGDJKAH()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 562f
				};
			}

			// Token: 0x06008293 RID: 33427 RVA: 0x002D087C File Offset: 0x002CEA7C
			public static LensAberrations.ChromaticAberrationSettings BCOPOEIJONI()
			{
				return new LensAberrations.ChromaticAberrationSettings
				{
					enabled = false,
					color = Color.green,
					amount = 1321f
				};
			}

			// Token: 0x04000EDD RID: 3805
			public bool enabled;

			// Token: 0x04000EDE RID: 3806
			[Tooltip("Channels to apply chromatic aberration to.")]
			[ColorUsage(false)]
			public Color color;

			// Token: 0x04000EDF RID: 3807
			[Range(-50f, 50f)]
			[Tooltip("Amount of tangential distortion.")]
			public float amount;
		}

		// Token: 0x02000209 RID: 521
		private enum NDAEODFDDGO
		{
			// Token: 0x04000EE1 RID: 3809
			BlurPrePass,
			// Token: 0x04000EE2 RID: 3810
			Chroma,
			// Token: 0x04000EE3 RID: 3811
			Distort,
			// Token: 0x04000EE4 RID: 3812
			Vignette,
			// Token: 0x04000EE5 RID: 3813
			ChromaDistort,
			// Token: 0x04000EE6 RID: 3814
			ChromaVignette,
			// Token: 0x04000EE7 RID: 3815
			DistortVignette,
			// Token: 0x04000EE8 RID: 3816
			ChromaDistortVignette
		}
	}
}
