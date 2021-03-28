using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x0200020F RID: 527
	[RequireComponent(typeof(Camera))]
	[AddComponentMenu("Image Effects/Cinematic/Screen Space Reflections")]
	[ImageEffectAllowedInSceneView]
	[ExecuteInEditMode]
	public class ScreenSpaceReflection : MonoBehaviour
	{
		// Token: 0x06008403 RID: 33795 RVA: 0x002D95AC File Offset: 0x002D77AC
		private void GLKJFIOCPLF()
		{
			if (!ImageEffectHelper.IsSupported(this.FJCABMBJHFA(), true, false, this))
			{
				base.enabled = true;
				return;
			}
			this.GAMGCKLCBPE().depthTextureMode |= DepthTextureMode.None;
			ScreenSpaceReflection.LECHJDFACDM = new int[3];
			ScreenSpaceReflection.MJMFKCGAJCI = Shader.PropertyToID("Missing shader for image effect {0}");
			ScreenSpaceReflection.ANEIBMOKEDM = Shader.PropertyToID("players");
			ScreenSpaceReflection.LECHJDFACDM[1] = Shader.PropertyToID(" not exist");
			ScreenSpaceReflection.LECHJDFACDM[1] = Shader.PropertyToID("0");
			ScreenSpaceReflection.LECHJDFACDM[1] = Shader.PropertyToID("RecieveChatActionMessage");
			ScreenSpaceReflection.LECHJDFACDM[8] = Shader.PropertyToID("PopulateMapsList");
			ScreenSpaceReflection.LECHJDFACDM[6] = Shader.PropertyToID("[NetworkMenu] Joining ");
			ScreenSpaceReflection.ONHHKPOABBL = Shader.PropertyToID("EventData0DropDownList");
			ScreenSpaceReflection.NACHHEIPCAE = Shader.PropertyToID("AudioSampler");
			ScreenSpaceReflection.PFBDGMNAJJN = Shader.PropertyToID("materialsitemid[");
			ScreenSpaceReflection.CCNBIKDGJBE = Shader.PropertyToID("_History4Weight");
		}

		// Token: 0x06008404 RID: 33796 RVA: 0x002D96A1 File Offset: 0x002D78A1
		public Shader CDMJMJIOLAE()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("CameraFilterPack/Vision_Tunnel");
			}
			return this.m_Shader;
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06008405 RID: 33797 RVA: 0x002D96CA File Offset: 0x002D78CA
		public Camera camera_
		{
			get
			{
				if (this.CMMMNLFGCJB == null)
				{
					this.CMMMNLFGCJB = base.GetComponent<Camera>();
				}
				return this.CMMMNLFGCJB;
			}
		}

		// Token: 0x06008406 RID: 33798 RVA: 0x002D96F0 File Offset: 0x002D78F0
		private void MKFLBEGJJDC()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
			if (this.GAMGCKLCBPE() != null)
			{
				if (this.MCLNLHKFLOI != null)
				{
					this.EDBDDIOLPJN().RemoveCommandBuffer((CameraEvent)(-80), this.MCLNLHKFLOI);
				}
				this.MCLNLHKFLOI = null;
			}
		}

		// Token: 0x06008407 RID: 33799 RVA: 0x002D9758 File Offset: 0x002D7958
		private void CNDACAHCCOI()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
			if (this.JIKPBCLILCC() != null)
			{
				if (this.MCLNLHKFLOI != null)
				{
					this.EDBDDIOLPJN().RemoveCommandBuffer((CameraEvent)(-36), this.MCLNLHKFLOI);
				}
				this.MCLNLHKFLOI = null;
			}
		}

		// Token: 0x06008408 RID: 33800 RVA: 0x002D97BD File Offset: 0x002D79BD
		public Shader NLECFJKGKJD()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("CameraFilterPack/Blend2Camera_SplitScreen3D");
			}
			return this.m_Shader;
		}

		// Token: 0x06008409 RID: 33801 RVA: 0x002D96CA File Offset: 0x002D78CA
		public Camera PMKPCGLLBEG()
		{
			if (this.CMMMNLFGCJB == null)
			{
				this.CMMMNLFGCJB = base.GetComponent<Camera>();
			}
			return this.CMMMNLFGCJB;
		}

		// Token: 0x0600840A RID: 33802 RVA: 0x002D97E8 File Offset: 0x002D79E8
		private void PAHNKEGFGHB()
		{
			if (!ImageEffectHelper.IsSupported(this.OJCDNJDGOLG(), false, false, this))
			{
				base.enabled = false;
				return;
			}
			this.PMKPCGLLBEG().depthTextureMode |= DepthTextureMode.None;
			ScreenSpaceReflection.LECHJDFACDM = new int[5];
			ScreenSpaceReflection.MJMFKCGAJCI = Shader.PropertyToID("_Green_C");
			ScreenSpaceReflection.ANEIBMOKEDM = Shader.PropertyToID("MenuScene");
			ScreenSpaceReflection.LECHJDFACDM[0] = Shader.PropertyToID(".played");
			ScreenSpaceReflection.LECHJDFACDM[1] = Shader.PropertyToID("Saved Game: ");
			ScreenSpaceReflection.LECHJDFACDM[4] = Shader.PropertyToID("itemid");
			ScreenSpaceReflection.LECHJDFACDM[5] = Shader.PropertyToID("Screenshots only supported in PlayMode");
			ScreenSpaceReflection.LECHJDFACDM[5] = Shader.PropertyToID("_ScreenResolution");
			ScreenSpaceReflection.ONHHKPOABBL = Shader.PropertyToID("_LensDirt");
			ScreenSpaceReflection.NACHHEIPCAE = Shader.PropertyToID("CameraFilterPack_WaterDrop");
			ScreenSpaceReflection.PFBDGMNAJJN = Shader.PropertyToID("_ScreenResolution");
			ScreenSpaceReflection.CCNBIKDGJBE = Shader.PropertyToID("UseScanLine");
		}

		// Token: 0x0600840B RID: 33803 RVA: 0x002D98E0 File Offset: 0x002D7AE0
		private void JOONHGHGKKF()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
			if (this.BKMMMLIJEKO() != null)
			{
				if (this.MCLNLHKFLOI != null)
				{
					this.JIKPBCLILCC().RemoveCommandBuffer((CameraEvent)(-28), this.MCLNLHKFLOI);
				}
				this.MCLNLHKFLOI = null;
			}
		}

		// Token: 0x0600840C RID: 33804 RVA: 0x002D9945 File Offset: 0x002D7B45
		public Material FGENHBKMPDA()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.KEHPLNBCGCJ());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600840D RID: 33805 RVA: 0x002D996F File Offset: 0x002D7B6F
		public Material KEMAALEODNH()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.LPFFIGCNIDF());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600840E RID: 33806 RVA: 0x002D9999 File Offset: 0x002D7B99
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

		// Token: 0x0600840F RID: 33807 RVA: 0x002D99C4 File Offset: 0x002D7BC4
		private void FKEJGBFDCAH()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
			if (this.PMKPCGLLBEG() != null)
			{
				if (this.MCLNLHKFLOI != null)
				{
					this.LCPKEGKALOK().RemoveCommandBuffer((CameraEvent)(-106), this.MCLNLHKFLOI);
				}
				this.MCLNLHKFLOI = null;
			}
		}

		// Token: 0x06008410 RID: 33808 RVA: 0x002D9A2C File Offset: 0x002D7C2C
		public void GKDLKGDPDLI()
		{
			if (this.EHDJJANLINB() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != (RenderingPath)7)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.SSRResolution.High) ? 4 : 0;
			int num2 = this.JBLKMFFGOBM().pixelWidth / num;
			int num3 = this.BKMMMLIJEKO().pixelHeight / num;
			float num4 = (float)this.JIKPBCLILCC().pixelWidth;
			float num5 = (float)this.camera_.pixelHeight;
			float num6 = num4 / 394f;
			float num7 = num5 / 1137f;
			RenderTextureFormat format = (!this.PMKPCGLLBEG().allowHDR) ? RenderTextureFormat.Depth : RenderTextureFormat.Default;
			this.GHHPOGODBHB().SetInt("id", this.settings.reflectionSettings.stepSize);
			this.GHHPOGODBHB().SetInt("settings.hitvariation", (this.settings.reflectionSettings.blendType != ScreenSpaceReflection.SSRReflectionBlendType.Additive) ? 1 : 1);
			this.MJJIEHANFJA().SetInt("_MidGrey", (!this.LIIFBNDLBLB) ? 0 : 1);
			this.MJJIEHANFJA().SetInt("\\n", (!this.GNAJGEOHKLG) ? 1 : 1);
			this.material.SetInt("_HdrParams", (!this.settings.reflectionSettings.reflectBackfaces) ? 1 : 0);
			this.OGMEGHKECAH().SetInt("_TimeX", (!this.BEJICPKGHBF) ? 0 : 1);
			this.PHGCJOPFDOG().SetInt("_RGB", this.settings.reflectionSettings.iterationCount);
			this.EHDJJANLINB().SetInt("GridDataStoryboard", 0);
			this.EHDJJANLINB().SetInt("/", (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.SSRResolution.High) ? 0 : 1);
			this.DONENAMLFLF().SetInt("player.playedtutorial", (!this.KMIBIBKOGDC) ? 0 : 0);
			float value = num4 / (57f * (float)Math.Tan((double)this.JIKPBCLILCC().fieldOfView / 1702.0 * 723.0 * 1901.0));
			this.FGENHBKMPDA().SetFloat("Freq: ", value);
			this.JIBOKBCPDLC().SetFloat("GlassesColor", this.settings.screenEdgeMask.intensity);
			this.MJJIEHANFJA().SetFloat("_Fade", this.settings.reflectionSettings.reflectionBlur);
			this.KDMBOKLMADJ().SetFloat("_Value", this.settings.reflectionSettings.maxDistance);
			this.LMLENGFLEBD().SetFloat("_Red_R", this.settings.intensitySettings.fadeDistance);
			this.JIBOKBCPDLC().SetFloat("_CameraWS", this.settings.reflectionSettings.widthModifier);
			this.OGMEGHKECAH().SetFloat("ticket", this.settings.intensitySettings.reflectionMultiplier);
			this.KDMBOKLMADJ().SetFloat("_ScreenResolution", this.settings.intensitySettings.fresnelFade);
			this.GHHPOGODBHB().SetFloat("updating", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.JBLKMFFGOBM().projectionMatrix;
			Vector4 value2 = new Vector4(1916f / (num4 * projectionMatrix[1]), 1224f / (num5 * projectionMatrix[3]), (1527f - projectionMatrix[8]) / projectionMatrix[0], (282f + projectionMatrix[8]) / projectionMatrix[4]);
			Vector3 v = (!float.IsPositiveInfinity(this.EDBDDIOLPJN().farClipPlane)) ? new Vector3(this.LCPKEGKALOK().nearClipPlane * this.BKMMMLIJEKO().farClipPlane, this.BDJHHDHOFNC().nearClipPlane - this.BDJHHDHOFNC().farClipPlane, this.GAMGCKLCBPE().farClipPlane) : new Vector3(this.BKMMMLIJEKO().nearClipPlane, 296f, 859f);
			this.LPDOGGFOBDH().SetVector("Vertical", new Vector2((float)num2, (float)num3));
			this.ACHNOHCLGOO().SetVector("_TimeX", new Vector2(num4, num5));
			this.JIBOKBCPDLC().SetVector("BitsData", new Vector2(1689f / num4, 1028f / num5));
			this.OGMEGHKECAH().SetVector("_Parameter", value2);
			this.DONENAMLFLF().SetVector("[PlayerBase] Checkpoint error: ", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(1, new Vector4(num6, 1055f, 1666f, num6));
			lhs.SetRow(1, new Vector4(383f, num7, 759f, num7));
			lhs.SetRow(0, new Vector4(722f, 1951f, 1363f, 1690f));
			lhs.SetRow(6, new Vector4(1115f, 680f, 1558f, 1584f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.ACHNOHCLGOO().SetMatrix("checkpoint", value3);
			this.OOMFJGPAOKL().SetMatrix("\n", this.BDJHHDHOFNC().worldToCameraMatrix);
			this.LPDOGGFOBDH().SetMatrix("menu.enableselectormusic", this.GAMGCKLCBPE().worldToCameraMatrix.inverse);
			if (this.MCLNLHKFLOI == null)
			{
				this.MCLNLHKFLOI = new CommandBuffer();
				this.MCLNLHKFLOI.name = "_ScreenResolution";
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.MJMFKCGAJCI, -1, -1, 0, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ANEIBMOKEDM, num2, num3, 0, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
				for (int i = 1; i < 1; i++)
				{
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.LECHJDFACDM[i], num2 >> (i & 97), num3 >> (i & -91), 1, FilterMode.Point, format);
				}
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.NACHHEIPCAE, num2, num3, 0, (!this.LIIFBNDLBLB) ? FilterMode.Point : FilterMode.Point, format);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.PFBDGMNAJJN, num2, num3, 1, FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.PrepassLight, ScreenSpaceReflection.MJMFKCGAJCI, this.LDNADDJMIPK(), 8);
				this.MCLNLHKFLOI.Blit((BuiltinRenderTextureType)6, ScreenSpaceReflection.ANEIBMOKEDM, this.LDNADDJMIPK(), 1);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, ScreenSpaceReflection.NACHHEIPCAE, this.material, 6);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.NACHHEIPCAE, ScreenSpaceReflection.LECHJDFACDM[0], this.DONENAMLFLF(), 0);
				for (int j = 0; j < 0; j += 0)
				{
					int nameID = ScreenSpaceReflection.LECHJDFACDM[j - 0];
					int num8 = j;
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL, num2 >> (num8 & 78), num3 >> (num8 & -24), 1, FilterMode.Point, format);
					this.MCLNLHKFLOI.SetGlobalVector("Received RPC \"", new Vector4(1790f, 231f, 1917f, 803f));
					this.MCLNLHKFLOI.SetGlobalFloat("_Value3", (float)j - 1958f);
					this.MCLNLHKFLOI.Blit(nameID, ScreenSpaceReflection.ONHHKPOABBL, this.LPDOGGFOBDH(), 6);
					this.MCLNLHKFLOI.SetGlobalVector("PunRespawn with Position.", new Vector4(685f, 1477f, 1868f, 77f));
					nameID = ScreenSpaceReflection.LECHJDFACDM[j];
					this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.ONHHKPOABBL, nameID, this.PHGCJOPFDOG(), 5);
					this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL);
				}
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.LECHJDFACDM[0], ScreenSpaceReflection.PFBDGMNAJJN, this.DONENAMLFLF(), 7);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE, this.EDBDDIOLPJN().pixelWidth, this.BDJHHDHOFNC().pixelHeight, 1, FilterMode.Point, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.Depth, ScreenSpaceReflection.CCNBIKDGJBE, this.KHCLIAMBBNC(), 1);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.CCNBIKDGJBE, BuiltinRenderTextureType.CameraTarget);
				this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE);
				this.LCPKEGKALOK().AddCommandBuffer((CameraEvent)(-86), this.MCLNLHKFLOI);
			}
		}

		// Token: 0x06008411 RID: 33809 RVA: 0x002DA2E8 File Offset: 0x002D84E8
		public void HNIGOMJMFDJ()
		{
			if (this.DONENAMLFLF() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != (RenderingPath)8)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.SSRResolution.High) ? 3 : 1;
			int num2 = this.JIKPBCLILCC().pixelWidth / num;
			int num3 = this.BDJHHDHOFNC().pixelHeight / num;
			float num4 = (float)this.LCPKEGKALOK().pixelWidth;
			float num5 = (float)this.JIKPBCLILCC().pixelHeight;
			float num6 = num4 / 531f;
			float num7 = num5 / 1662f;
			RenderTextureFormat format = (!this.NKLHLDLODKG().allowHDR) ? RenderTextureFormat.Depth : RenderTextureFormat.RGB565;
			this.KHCLIAMBBNC().SetInt("[MapsData] Base maps loaded", this.settings.reflectionSettings.stepSize);
			this.DONENAMLFLF().SetInt("Keypad", (this.settings.reflectionSettings.blendType != ScreenSpaceReflection.SSRReflectionBlendType.PhysicallyBased) ? 1 : 1);
			this.DONENAMLFLF().SetInt("BadgeText", (!this.LIIFBNDLBLB) ? 0 : 0);
			this.PHGCJOPFDOG().SetInt("ERROR: Preview file must be <1MB!", (!this.GNAJGEOHKLG) ? 1 : 0);
			this.material.SetInt("[PlayerController] ", (!this.settings.reflectionSettings.reflectBackfaces) ? 0 : 0);
			this.LMLENGFLEBD().SetInt("_TimeX", (!this.BEJICPKGHBF) ? 1 : 0);
			this.LPDOGGFOBDH().SetInt("settings.arcsnohitsoundtimedelay", this.settings.reflectionSettings.iterationCount);
			this.PHGCJOPFDOG().SetInt("CountEventsGoal", 1);
			this.LMLENGFLEBD().SetInt("_TimeX", (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.SSRResolution.High) ? 0 : 1);
			this.EHDJJANLINB().SetInt("LoadingStatusText", (!this.KMIBIBKOGDC) ? 0 : 1);
			float value = num4 / (59f * (float)Math.Tan((double)this.JBLKMFFGOBM().fieldOfView / 919.0 * 1287.0 * 918.0));
			this.OGMEGHKECAH().SetFloat("mapselector.filter.rateduponly", value);
			this.OGMEGHKECAH().SetFloat("Set Satellite Trail Width", this.settings.screenEdgeMask.intensity);
			this.LPDOGGFOBDH().SetFloat("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", this.settings.reflectionSettings.reflectionBlur);
			this.KHCLIAMBBNC().SetFloat("Did not read byte array properly", this.settings.reflectionSettings.maxDistance);
			this.DONENAMLFLF().SetFloat("SpawnObj", this.settings.intensitySettings.fadeDistance);
			this.OOMFJGPAOKL().SetFloat("settings.enablehitsoundsinrelax", this.settings.reflectionSettings.widthModifier);
			this.FGENHBKMPDA().SetFloat("_TimeX", this.settings.intensitySettings.reflectionMultiplier);
			this.ACHNOHCLGOO().SetFloat("GameScene", this.settings.intensitySettings.fresnelFade);
			this.FGENHBKMPDA().SetFloat(":", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.camera_.projectionMatrix;
			Vector4 value2 = new Vector4(41f / (num4 * projectionMatrix[0]), 300f / (num5 * projectionMatrix[0]), (598f - projectionMatrix[1]) / projectionMatrix[0], (508f + projectionMatrix[1]) / projectionMatrix[3]);
			Vector3 v = (!float.IsPositiveInfinity(this.LCPKEGKALOK().farClipPlane)) ? new Vector3(this.JIKPBCLILCC().nearClipPlane * this.BKMMMLIJEKO().farClipPlane, this.camera_.nearClipPlane - this.JIKPBCLILCC().farClipPlane, this.JIKPBCLILCC().farClipPlane) : new Vector3(this.JBLKMFFGOBM().nearClipPlane, 640f, 723f);
			this.EHDJJANLINB().SetVector("/", new Vector2((float)num2, (float)num3));
			this.JIBOKBCPDLC().SetVector("GlassesColor", new Vector2(num4, num5));
			this.JIBOKBCPDLC().SetVector("https://bugs.khb-soft.ru/set_project.php?project_id=1", new Vector2(1515f / num4, 114f / num5));
			this.DONENAMLFLF().SetVector("LevelNameInputField", value2);
			this.LPDOGGFOBDH().SetVector("_Color", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(1, new Vector4(num6, 1791f, 1109f, num6));
			lhs.SetRow(1, new Vector4(1690f, num7, 1541f, num7));
			lhs.SetRow(8, new Vector4(1123f, 1118f, 82f, 418f));
			lhs.SetRow(0, new Vector4(1817f, 1320f, 1224f, 452f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.LDNADDJMIPK().SetMatrix("JoinRoom failed. In offline mode you still have to leave a room to enter another.", value3);
			this.KEMAALEODNH().SetMatrix("_Axis", this.EDBDDIOLPJN().worldToCameraMatrix);
			this.OOMFJGPAOKL().SetMatrix("#FFDA44CC", this.JIKPBCLILCC().worldToCameraMatrix.inverse);
			if (this.MCLNLHKFLOI == null)
			{
				this.MCLNLHKFLOI = new CommandBuffer();
				this.MCLNLHKFLOI.name = "_Value4";
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.MJMFKCGAJCI, -1, -1, 0, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ANEIBMOKEDM, num2, num3, 1, FilterMode.Bilinear, RenderTextureFormat.ARGB2101010, RenderTextureReadWrite.Default);
				for (int i = 1; i < 3; i += 0)
				{
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.LECHJDFACDM[i], num2 >> (i & 57), num3 >> (i & 43), 0, FilterMode.Point, format);
				}
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.NACHHEIPCAE, num2, num3, 0, (!this.LIIFBNDLBLB) ? FilterMode.Point : FilterMode.Point, format);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.PFBDGMNAJJN, num2, num3, 1, FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, ScreenSpaceReflection.MJMFKCGAJCI, this.DONENAMLFLF(), 6);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.DepthNormals, ScreenSpaceReflection.ANEIBMOKEDM, this.MJJIEHANFJA(), 0);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.CurrentActive, ScreenSpaceReflection.NACHHEIPCAE, this.EHDJJANLINB(), 7);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.NACHHEIPCAE, ScreenSpaceReflection.LECHJDFACDM[1], this.GHHPOGODBHB(), 8);
				for (int j = 1; j < 6; j += 0)
				{
					int nameID = ScreenSpaceReflection.LECHJDFACDM[j - 0];
					int num8 = j;
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL, num2 >> (num8 & -107), num3 >> (num8 & 64), 0, FilterMode.Point, format);
					this.MCLNLHKFLOI.SetGlobalVector("finished", new Vector4(415f, 1616f, 782f, 957f));
					this.MCLNLHKFLOI.SetGlobalFloat("Jun", (float)j - 1318f);
					this.MCLNLHKFLOI.Blit(nameID, ScreenSpaceReflection.ONHHKPOABBL, this.LDNADDJMIPK(), 4);
					this.MCLNLHKFLOI.SetGlobalVector("_TimeX", new Vector4(1452f, 481f, 880f, 1082f));
					nameID = ScreenSpaceReflection.LECHJDFACDM[j];
					this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.ONHHKPOABBL, nameID, this.OGMEGHKECAH(), 7);
					this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL);
				}
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.LECHJDFACDM[0], ScreenSpaceReflection.PFBDGMNAJJN, this.JIBOKBCPDLC(), 5);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE, this.NKLHLDLODKG().pixelWidth, this.NKLHLDLODKG().pixelHeight, 0, FilterMode.Point, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.CurrentActive, ScreenSpaceReflection.CCNBIKDGJBE, this.KDMBOKLMADJ(), 0);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.CCNBIKDGJBE, BuiltinRenderTextureType.Depth);
				this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE);
				this.PMKPCGLLBEG().AddCommandBuffer((CameraEvent)(-13), this.MCLNLHKFLOI);
			}
		}

		// Token: 0x06008412 RID: 33810 RVA: 0x002DABA4 File Offset: 0x002D8DA4
		public void COACPHONAME()
		{
			if (this.DONENAMLFLF() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != (RenderingPath)7)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.SSRResolution.High) ? 7 : 0;
			int num2 = this.GAMGCKLCBPE().pixelWidth / num;
			int num3 = this.JIKPBCLILCC().pixelHeight / num;
			float num4 = (float)this.BKMMMLIJEKO().pixelWidth;
			float num5 = (float)this.JIKPBCLILCC().pixelHeight;
			float num6 = num4 / 1006f;
			float num7 = num5 / 1161f;
			RenderTextureFormat format = (!this.EDBDDIOLPJN().allowHDR) ? RenderTextureFormat.Depth : RenderTextureFormat.ARGB1555;
			this.GHHPOGODBHB().SetInt("EventSystem", this.settings.reflectionSettings.stepSize);
			this.LMLENGFLEBD().SetInt("CameraFilterPack_TV_Noise3", (this.settings.reflectionSettings.blendType != ScreenSpaceReflection.SSRReflectionBlendType.Additive) ? 1 : 1);
			this.OGMEGHKECAH().SetInt("UseFinalGlassColor", (!this.LIIFBNDLBLB) ? 0 : 0);
			this.KDMBOKLMADJ().SetInt("_ScreenResolution", (!this.GNAJGEOHKLG) ? 0 : 1);
			this.JIBOKBCPDLC().SetInt("\\", (!this.settings.reflectionSettings.reflectBackfaces) ? 1 : 0);
			this.JIBOKBCPDLC().SetInt("_Radius", (!this.BEJICPKGHBF) ? 1 : 1);
			this.MJJIEHANFJA().SetInt("menu.playedsolo", this.settings.reflectionSettings.iterationCount);
			this.OOMFJGPAOKL().SetInt("VisionBlur", 1);
			this.FGENHBKMPDA().SetInt("CameraFilterPack/TV_Tiles", (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.SSRResolution.High) ? 1 : 0);
			this.KDMBOKLMADJ().SetInt("mapselector.filter.favoriteonly", (!this.KMIBIBKOGDC) ? 0 : 0);
			float value = num4 / (1807f * (float)Math.Tan((double)this.BDJHHDHOFNC().fieldOfView / 1064.0 * 763.0 * 259.0));
			this.KDMBOKLMADJ().SetFloat("_TimeX", value);
			this.JIBOKBCPDLC().SetFloat("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", this.settings.screenEdgeMask.intensity);
			this.LPDOGGFOBDH().SetFloat("SpectateButton", this.settings.reflectionSettings.reflectionBlur);
			this.GHHPOGODBHB().SetFloat("_TimeX", this.settings.reflectionSettings.maxDistance);
			this.LMLENGFLEBD().SetFloat("#currentbpm: ", this.settings.intensitySettings.fadeDistance);
			this.LPDOGGFOBDH().SetFloat("_Params1", this.settings.reflectionSettings.widthModifier);
			this.material.SetFloat("_VelocityScale", this.settings.intensitySettings.reflectionMultiplier);
			this.HHIAIGCAHDA().SetFloat(" not exist", this.settings.intensitySettings.fresnelFade);
			this.DONENAMLFLF().SetFloat("#ok", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.LCPKEGKALOK().projectionMatrix;
			Vector4 value2 = new Vector4(1805f / (num4 * projectionMatrix[0]), 3f / (num5 * projectionMatrix[6]), (1734f - projectionMatrix[0]) / projectionMatrix[1], (1712f + projectionMatrix[0]) / projectionMatrix[5]);
			Vector3 v = (!float.IsPositiveInfinity(this.camera_.farClipPlane)) ? new Vector3(this.JBLKMFFGOBM().nearClipPlane * this.NKLHLDLODKG().farClipPlane, this.BDJHHDHOFNC().nearClipPlane - this.camera_.farClipPlane, this.BKMMMLIJEKO().farClipPlane) : new Vector3(this.JIKPBCLILCC().nearClipPlane, 47f, 1953f);
			this.FGENHBKMPDA().SetVector("settings.disablestoryboard", new Vector2((float)num2, (float)num3));
			this.ACHNOHCLGOO().SetVector("_Value3", new Vector2(num4, num5));
			this.JIBOKBCPDLC().SetVector("Left", new Vector2(776f / num4, 932f / num5));
			this.FGENHBKMPDA().SetVector("settings_bindings_controller_type", value2);
			this.PHGCJOPFDOG().SetVector("bad", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(0, new Vector4(num6, 1282f, 1564f, num6));
			lhs.SetRow(1, new Vector4(1012f, num7, 725f, num7));
			lhs.SetRow(5, new Vector4(969f, 382f, 831f, 1201f));
			lhs.SetRow(4, new Vector4(1334f, 1043f, 573f, 329f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.LPDOGGFOBDH().SetMatrix("UI", value3);
			this.KDMBOKLMADJ().SetMatrix("resetach21", this.LCPKEGKALOK().worldToCameraMatrix);
			this.KEMAALEODNH().SetMatrix("CameraFilterPack/TV_Artefact", this.GAMGCKLCBPE().worldToCameraMatrix.inverse);
			if (this.MCLNLHKFLOI == null)
			{
				this.MCLNLHKFLOI = new CommandBuffer();
				this.MCLNLHKFLOI.name = "\\\\";
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.MJMFKCGAJCI, -1, -1, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ANEIBMOKEDM, num2, num3, 0, FilterMode.Bilinear, RenderTextureFormat.Shadowmap, RenderTextureReadWrite.Default);
				for (int i = 1; i < 0; i++)
				{
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.LECHJDFACDM[i], num2 >> (i & 7), num3 >> (i & 18), 0, FilterMode.Point, format);
				}
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.NACHHEIPCAE, num2, num3, 0, (!this.LIIFBNDLBLB) ? FilterMode.Bilinear : FilterMode.Point, format);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.PFBDGMNAJJN, num2, num3, 1, FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.CameraTarget, ScreenSpaceReflection.MJMFKCGAJCI, this.DONENAMLFLF(), 6);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.CameraTarget, ScreenSpaceReflection.ANEIBMOKEDM, this.JIBOKBCPDLC(), 1);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.ResolvedDepth, ScreenSpaceReflection.NACHHEIPCAE, this.LMLENGFLEBD(), 6);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.NACHHEIPCAE, ScreenSpaceReflection.LECHJDFACDM[1], this.DONENAMLFLF(), 5);
				for (int j = 1; j < 4; j++)
				{
					int nameID = ScreenSpaceReflection.LECHJDFACDM[j - 0];
					int num8 = j;
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL, num2 >> (num8 & -56), num3 >> (num8 & -102), 1, FilterMode.Bilinear, format);
					this.MCLNLHKFLOI.SetGlobalVector("menu.enableselectormusic", new Vector4(1658f, 961f, 1583f, 1691f));
					this.MCLNLHKFLOI.SetGlobalFloat("GlassesColor", (float)j - 253f);
					this.MCLNLHKFLOI.Blit(nameID, ScreenSpaceReflection.ONHHKPOABBL, this.LMLENGFLEBD(), 6);
					this.MCLNLHKFLOI.SetGlobalVector("source", new Vector4(1327f, 263f, 1671f, 443f));
					nameID = ScreenSpaceReflection.LECHJDFACDM[j];
					this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.ONHHKPOABBL, nameID, this.OGMEGHKECAH(), 6);
					this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL);
				}
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.LECHJDFACDM[0], ScreenSpaceReflection.PFBDGMNAJJN, this.DONENAMLFLF(), 8);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE, this.BKMMMLIJEKO().pixelWidth, this.PMKPCGLLBEG().pixelHeight, 1, FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.ResolvedDepth, ScreenSpaceReflection.CCNBIKDGJBE, this.EHDJJANLINB(), 0);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.CCNBIKDGJBE, BuiltinRenderTextureType.CameraTarget);
				this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE);
				this.NKLHLDLODKG().AddCommandBuffer((CameraEvent)(-58), this.MCLNLHKFLOI);
			}
		}

		// Token: 0x06008413 RID: 33811 RVA: 0x002DB45D File Offset: 0x002D965D
		public Material EHDJJANLINB()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.CDMJMJIOLAE());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06008414 RID: 33812 RVA: 0x002DB487 File Offset: 0x002D9687
		public Shader OJCDNJDGOLG()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("downloading");
			}
			return this.m_Shader;
		}

		// Token: 0x06008415 RID: 33813 RVA: 0x002DB4B0 File Offset: 0x002D96B0
		public Shader KEHPLNBCGCJ()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("BitsData");
			}
			return this.m_Shader;
		}

		// Token: 0x06008416 RID: 33814 RVA: 0x002DB4D9 File Offset: 0x002D96D9
		public Material KDMBOKLMADJ()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.HHAAPJLFOLA());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06008417 RID: 33815 RVA: 0x002DB504 File Offset: 0x002D9704
		private void IHPLMLBJELK()
		{
			if (!ImageEffectHelper.IsSupported(this.HHAAPJLFOLA(), true, true, this))
			{
				base.enabled = false;
				return;
			}
			this.JIKPBCLILCC().depthTextureMode |= DepthTextureMode.None;
			ScreenSpaceReflection.LECHJDFACDM = new int[5];
			ScreenSpaceReflection.MJMFKCGAJCI = Shader.PropertyToID("_Bullet_3");
			ScreenSpaceReflection.ANEIBMOKEDM = Shader.PropertyToID("maps.");
			ScreenSpaceReflection.LECHJDFACDM[1] = Shader.PropertyToID("_TimeX");
			ScreenSpaceReflection.LECHJDFACDM[1] = Shader.PropertyToID("VeryHigh");
			ScreenSpaceReflection.LECHJDFACDM[6] = Shader.PropertyToID("ALREADY SEEN");
			ScreenSpaceReflection.LECHJDFACDM[5] = Shader.PropertyToID("CameraFilterPack_3D_Matrix1");
			ScreenSpaceReflection.LECHJDFACDM[7] = Shader.PropertyToID("offsets");
			ScreenSpaceReflection.ONHHKPOABBL = Shader.PropertyToID("_Far");
			ScreenSpaceReflection.NACHHEIPCAE = Shader.PropertyToID("_MainTex2");
			ScreenSpaceReflection.PFBDGMNAJJN = Shader.PropertyToID("_Alpha");
			ScreenSpaceReflection.CCNBIKDGJBE = Shader.PropertyToID("907198288");
		}

		// Token: 0x06008418 RID: 33816 RVA: 0x002DB5FC File Offset: 0x002D97FC
		public void OnPreRender()
		{
			if (this.material == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != RenderingPath.DeferredShading)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.SSRResolution.High) ? 2 : 1;
			int num2 = this.camera_.pixelWidth / num;
			int num3 = this.camera_.pixelHeight / num;
			float num4 = (float)this.camera_.pixelWidth;
			float num5 = (float)this.camera_.pixelHeight;
			float num6 = num4 / 2f;
			float num7 = num5 / 2f;
			RenderTextureFormat format = (!this.camera_.allowHDR) ? RenderTextureFormat.ARGB32 : RenderTextureFormat.ARGBHalf;
			this.material.SetInt("_RayStepSize", this.settings.reflectionSettings.stepSize);
			this.material.SetInt("_AdditiveReflection", (this.settings.reflectionSettings.blendType != ScreenSpaceReflection.SSRReflectionBlendType.Additive) ? 0 : 1);
			this.material.SetInt("_BilateralUpsampling", (!this.LIIFBNDLBLB) ? 0 : 1);
			this.material.SetInt("_TreatBackfaceHitAsMiss", (!this.GNAJGEOHKLG) ? 0 : 1);
			this.material.SetInt("_AllowBackwardsRays", (!this.settings.reflectionSettings.reflectBackfaces) ? 0 : 1);
			this.material.SetInt("_TraceBehindObjects", (!this.BEJICPKGHBF) ? 0 : 1);
			this.material.SetInt("_MaxSteps", this.settings.reflectionSettings.iterationCount);
			this.material.SetInt("_FullResolutionFiltering", 0);
			this.material.SetInt("_HalfResolution", (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.SSRResolution.High) ? 0 : 1);
			this.material.SetInt("_HighlightSuppression", (!this.KMIBIBKOGDC) ? 0 : 1);
			float value = num4 / (-2f * (float)Math.Tan((double)this.camera_.fieldOfView / 180.0 * 3.1415926535897931 * 0.5));
			this.material.SetFloat("_PixelsPerMeterAtOneMeter", value);
			this.material.SetFloat("_ScreenEdgeFading", this.settings.screenEdgeMask.intensity);
			this.material.SetFloat("_ReflectionBlur", this.settings.reflectionSettings.reflectionBlur);
			this.material.SetFloat("_MaxRayTraceDistance", this.settings.reflectionSettings.maxDistance);
			this.material.SetFloat("_FadeDistance", this.settings.intensitySettings.fadeDistance);
			this.material.SetFloat("_LayerThickness", this.settings.reflectionSettings.widthModifier);
			this.material.SetFloat("_SSRMultiplier", this.settings.intensitySettings.reflectionMultiplier);
			this.material.SetFloat("_FresnelFade", this.settings.intensitySettings.fresnelFade);
			this.material.SetFloat("_FresnelFadePower", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.camera_.projectionMatrix;
			Vector4 value2 = new Vector4(-2f / (num4 * projectionMatrix[0]), -2f / (num5 * projectionMatrix[5]), (1f - projectionMatrix[2]) / projectionMatrix[0], (1f + projectionMatrix[6]) / projectionMatrix[5]);
			Vector3 v = (!float.IsPositiveInfinity(this.camera_.farClipPlane)) ? new Vector3(this.camera_.nearClipPlane * this.camera_.farClipPlane, this.camera_.nearClipPlane - this.camera_.farClipPlane, this.camera_.farClipPlane) : new Vector3(this.camera_.nearClipPlane, -1f, 1f);
			this.material.SetVector("_ReflectionBufferSize", new Vector2((float)num2, (float)num3));
			this.material.SetVector("_ScreenSize", new Vector2(num4, num5));
			this.material.SetVector("_InvScreenSize", new Vector2(1f / num4, 1f / num5));
			this.material.SetVector("_ProjInfo", value2);
			this.material.SetVector("_CameraClipInfo", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(0, new Vector4(num6, 0f, 0f, num6));
			lhs.SetRow(1, new Vector4(0f, num7, 0f, num7));
			lhs.SetRow(2, new Vector4(0f, 0f, 1f, 0f));
			lhs.SetRow(3, new Vector4(0f, 0f, 0f, 1f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.material.SetMatrix("_ProjectToPixelMatrix", value3);
			this.material.SetMatrix("_WorldToCameraMatrix", this.camera_.worldToCameraMatrix);
			this.material.SetMatrix("_CameraToWorldMatrix", this.camera_.worldToCameraMatrix.inverse);
			if (this.MCLNLHKFLOI == null)
			{
				this.MCLNLHKFLOI = new CommandBuffer();
				this.MCLNLHKFLOI.name = "Screen Space Reflections";
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.MJMFKCGAJCI, -1, -1, 0, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ANEIBMOKEDM, num2, num3, 0, FilterMode.Bilinear, RenderTextureFormat.ARGBHalf, RenderTextureReadWrite.Linear);
				for (int i = 0; i < 5; i++)
				{
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.LECHJDFACDM[i], num2 >> i, num3 >> i, 0, FilterMode.Bilinear, format);
				}
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.NACHHEIPCAE, num2, num3, 0, (!this.LIIFBNDLBLB) ? FilterMode.Bilinear : FilterMode.Point, format);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.PFBDGMNAJJN, num2, num3, 0, FilterMode.Point, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.CameraTarget, ScreenSpaceReflection.MJMFKCGAJCI, this.material, 6);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.CameraTarget, ScreenSpaceReflection.ANEIBMOKEDM, this.material, 0);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.CameraTarget, ScreenSpaceReflection.NACHHEIPCAE, this.material, 5);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.NACHHEIPCAE, ScreenSpaceReflection.LECHJDFACDM[0], this.material, 8);
				for (int j = 1; j < 5; j++)
				{
					int nameID = ScreenSpaceReflection.LECHJDFACDM[j - 1];
					int num8 = j;
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL, num2 >> num8, num3 >> num8, 0, FilterMode.Bilinear, format);
					this.MCLNLHKFLOI.SetGlobalVector("_Axis", new Vector4(1f, 0f, 0f, 0f));
					this.MCLNLHKFLOI.SetGlobalFloat("_CurrentMipLevel", (float)j - 1f);
					this.MCLNLHKFLOI.Blit(nameID, ScreenSpaceReflection.ONHHKPOABBL, this.material, 2);
					this.MCLNLHKFLOI.SetGlobalVector("_Axis", new Vector4(0f, 1f, 0f, 0f));
					nameID = ScreenSpaceReflection.LECHJDFACDM[j];
					this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.ONHHKPOABBL, nameID, this.material, 2);
					this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL);
				}
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.LECHJDFACDM[0], ScreenSpaceReflection.PFBDGMNAJJN, this.material, 3);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE, this.camera_.pixelWidth, this.camera_.pixelHeight, 0, FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.CameraTarget, ScreenSpaceReflection.CCNBIKDGJBE, this.material, 1);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.CCNBIKDGJBE, BuiltinRenderTextureType.CameraTarget);
				this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE);
				this.camera_.AddCommandBuffer(CameraEvent.AfterFinalPass, this.MCLNLHKFLOI);
			}
		}

		// Token: 0x06008419 RID: 33817 RVA: 0x002DBEB5 File Offset: 0x002DA0B5
		public Material JIBOKBCPDLC()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.IGPCJOCBOIN());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600841A RID: 33818 RVA: 0x002DBEE0 File Offset: 0x002DA0E0
		private void GKNKIIEALCH()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
			if (this.JBLKMFFGOBM() != null)
			{
				if (this.MCLNLHKFLOI != null)
				{
					this.camera_.RemoveCommandBuffer((CameraEvent)41, this.MCLNLHKFLOI);
				}
				this.MCLNLHKFLOI = null;
			}
		}

		// Token: 0x0600841B RID: 33819 RVA: 0x002DBF48 File Offset: 0x002DA148
		private void OFPPIKHNJOD()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
			if (this.PMKPCGLLBEG() != null)
			{
				if (this.MCLNLHKFLOI != null)
				{
					this.JIKPBCLILCC().RemoveCommandBuffer((CameraEvent)(-110), this.MCLNLHKFLOI);
				}
				this.MCLNLHKFLOI = null;
			}
		}

		// Token: 0x0600841C RID: 33820 RVA: 0x002DB4D9 File Offset: 0x002D96D9
		public Material HHIAIGCAHDA()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.HHAAPJLFOLA());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600841D RID: 33821 RVA: 0x002DBFAD File Offset: 0x002DA1AD
		public Shader MFFKMHNGLIH()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("closed");
			}
			return this.m_Shader;
		}

		// Token: 0x0600841E RID: 33822 RVA: 0x002DBFD8 File Offset: 0x002DA1D8
		public void FHNJOJGOAMA()
		{
			if (this.DONENAMLFLF() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != (RenderingPath)4)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.SSRResolution.High) ? 1 : 0;
			int num2 = this.GAMGCKLCBPE().pixelWidth / num;
			int num3 = this.BKMMMLIJEKO().pixelHeight / num;
			float num4 = (float)this.BKMMMLIJEKO().pixelWidth;
			float num5 = (float)this.BKMMMLIJEKO().pixelHeight;
			float num6 = num4 / 541f;
			float num7 = num5 / 481f;
			RenderTextureFormat format = (!this.GAMGCKLCBPE().allowHDR) ? RenderTextureFormat.Depth : RenderTextureFormat.ARGB1555;
			this.FGENHBKMPDA().SetInt("_LightIntensity", this.settings.reflectionSettings.stepSize);
			this.KHCLIAMBBNC().SetInt("AudioSampler", (this.settings.reflectionSettings.blendType != ScreenSpaceReflection.SSRReflectionBlendType.PhysicallyBased) ? 1 : 1);
			this.GHHPOGODBHB().SetInt(". Calling ConnectToRegionMaster() is: ", (!this.LIIFBNDLBLB) ? 1 : 0);
			this.FGENHBKMPDA().SetInt("clear", (!this.GNAJGEOHKLG) ? 1 : 1);
			this.HHIAIGCAHDA().SetInt("_Distortion", (!this.settings.reflectionSettings.reflectBackfaces) ? 1 : 0);
			this.OOMFJGPAOKL().SetInt("maps.", (!this.BEJICPKGHBF) ? 0 : 1);
			this.LMLENGFLEBD().SetInt("SSAARenderTargetCamera", this.settings.reflectionSettings.iterationCount);
			this.JIBOKBCPDLC().SetInt("ConnectUsingSettings() failed. Can only connect while in state 'Disconnected'. Current state: ", 0);
			this.LDNADDJMIPK().SetInt("OK", (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.SSRResolution.High) ? 1 : 0);
			this.material.SetInt("\"", (!this.KMIBIBKOGDC) ? 1 : 1);
			float value = num4 / (1796f * (float)Math.Tan((double)this.GAMGCKLCBPE().fieldOfView / 1033.0 * 875.0 * 12.0));
			this.JIBOKBCPDLC().SetFloat("PunRespawn", value);
			this.material.SetFloat("_RGB", this.settings.screenEdgeMask.intensity);
			this.GHHPOGODBHB().SetFloat("GenerationMenu", this.settings.reflectionSettings.reflectionBlur);
			this.PHGCJOPFDOG().SetFloat("_Offsets", this.settings.reflectionSettings.maxDistance);
			this.KEMAALEODNH().SetFloat("_Noise", this.settings.intensitySettings.fadeDistance);
			this.JIBOKBCPDLC().SetFloat(".mp3", this.settings.reflectionSettings.widthModifier);
			this.KDMBOKLMADJ().SetFloat("ItemTemplate", this.settings.intensitySettings.reflectionMultiplier);
			this.EHDJJANLINB().SetFloat("Items/", this.settings.intensitySettings.fresnelFade);
			this.FGENHBKMPDA().SetFloat("/", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.BDJHHDHOFNC().projectionMatrix;
			Vector4 value2 = new Vector4(1793f / (num4 * projectionMatrix[0]), 277f / (num5 * projectionMatrix[6]), (146f - projectionMatrix[1]) / projectionMatrix[0], (1071f + projectionMatrix[5]) / projectionMatrix[5]);
			Vector3 v = (!float.IsPositiveInfinity(this.EDBDDIOLPJN().farClipPlane)) ? new Vector3(this.JIKPBCLILCC().nearClipPlane * this.LCPKEGKALOK().farClipPlane, this.LCPKEGKALOK().nearClipPlane - this.JBLKMFFGOBM().farClipPlane, this.NKLHLDLODKG().farClipPlane) : new Vector3(this.PMKPCGLLBEG().nearClipPlane, 686f, 442f);
			this.HHIAIGCAHDA().SetVector("NameInfoText", new Vector2((float)num2, (float)num3));
			this.HHIAIGCAHDA().SetVector("EventMenu", new Vector2(num4, num5));
			this.GHHPOGODBHB().SetVector("Set object anchor to another object", new Vector2(72f / num4, 1536f / num5));
			this.OGMEGHKECAH().SetVector("\n\n#", value2);
			this.FGENHBKMPDA().SetVector("_Value2", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(1, new Vector4(num6, 77f, 131f, num6));
			lhs.SetRow(0, new Vector4(361f, num7, 1910f, num7));
			lhs.SetRow(4, new Vector4(877f, 650f, 1894f, 1538f));
			lhs.SetRow(5, new Vector4(281f, 1221f, 1571f, 303f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.LDNADDJMIPK().SetMatrix("_Value3", value3);
			this.LDNADDJMIPK().SetMatrix("_TimeX", this.JBLKMFFGOBM().worldToCameraMatrix);
			this.OOMFJGPAOKL().SetMatrix("_ScreenResolution", this.BDJHHDHOFNC().worldToCameraMatrix.inverse);
			if (this.MCLNLHKFLOI == null)
			{
				this.MCLNLHKFLOI = new CommandBuffer();
				this.MCLNLHKFLOI.name = "LoadingStatusText";
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.MJMFKCGAJCI, -1, -1, 0, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ANEIBMOKEDM, num2, num3, 1, FilterMode.Point, RenderTextureFormat.ARGB2101010, RenderTextureReadWrite.Default);
				for (int i = 0; i < 7; i += 0)
				{
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.LECHJDFACDM[i], num2 >> (i & 117), num3 >> (i & 104), 1, FilterMode.Point, format);
				}
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.NACHHEIPCAE, num2, num3, 0, (!this.LIIFBNDLBLB) ? FilterMode.Bilinear : FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.PFBDGMNAJJN, num2, num3, 0, FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.None, ScreenSpaceReflection.MJMFKCGAJCI, this.LMLENGFLEBD(), 8);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, ScreenSpaceReflection.ANEIBMOKEDM, this.EHDJJANLINB(), 1);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.Depth, ScreenSpaceReflection.NACHHEIPCAE, this.GHHPOGODBHB(), 4);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.NACHHEIPCAE, ScreenSpaceReflection.LECHJDFACDM[0], this.PHGCJOPFDOG(), 3);
				for (int j = 1; j < 2; j += 0)
				{
					int nameID = ScreenSpaceReflection.LECHJDFACDM[j - 0];
					int num8 = j;
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL, num2 >> (num8 & 64), num3 >> (num8 & 119), 1, FilterMode.Bilinear, format);
					this.MCLNLHKFLOI.SetGlobalVector("_ColorG", new Vector4(1793f, 1180f, 1173f, 1278f));
					this.MCLNLHKFLOI.SetGlobalFloat("_TimeX", (float)j - 397f);
					this.MCLNLHKFLOI.Blit(nameID, ScreenSpaceReflection.ONHHKPOABBL, this.FGENHBKMPDA(), 8);
					this.MCLNLHKFLOI.SetGlobalVector("_Value", new Vector4(1428f, 1838f, 1663f, 1506f));
					nameID = ScreenSpaceReflection.LECHJDFACDM[j];
					this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.ONHHKPOABBL, nameID, this.LMLENGFLEBD(), 5);
					this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL);
				}
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.LECHJDFACDM[0], ScreenSpaceReflection.PFBDGMNAJJN, this.LMLENGFLEBD(), 6);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE, this.EDBDDIOLPJN().pixelWidth, this.JBLKMFFGOBM().pixelHeight, 0, FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.CurrentActive, ScreenSpaceReflection.CCNBIKDGJBE, this.material, 0);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.CCNBIKDGJBE, BuiltinRenderTextureType.DepthNormals);
				this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE);
				this.EDBDDIOLPJN().AddCommandBuffer(CameraEvent.AfterImageEffects, this.MCLNLHKFLOI);
			}
		}

		// Token: 0x0600841F RID: 33823 RVA: 0x002DC891 File Offset: 0x002DAA91
		public Material MJJIEHANFJA()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.BPGLBABLFOO());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06008420 RID: 33824 RVA: 0x002DC8BC File Offset: 0x002DAABC
		private void JOJFHFHOCHO()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
			if (this.EDBDDIOLPJN() != null)
			{
				if (this.MCLNLHKFLOI != null)
				{
					this.EDBDDIOLPJN().RemoveCommandBuffer((CameraEvent)(-45), this.MCLNLHKFLOI);
				}
				this.MCLNLHKFLOI = null;
			}
		}

		// Token: 0x06008421 RID: 33825 RVA: 0x002DC924 File Offset: 0x002DAB24
		public void LNEDHGKNIHM()
		{
			if (this.LMLENGFLEBD() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != (RenderingPath)4)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.SSRResolution.High) ? 4 : 0;
			int num2 = this.JBLKMFFGOBM().pixelWidth / num;
			int num3 = this.BDJHHDHOFNC().pixelHeight / num;
			float num4 = (float)this.BDJHHDHOFNC().pixelWidth;
			float num5 = (float)this.JIKPBCLILCC().pixelHeight;
			float num6 = num4 / 473f;
			float num7 = num5 / 1584f;
			RenderTextureFormat format = (!this.GAMGCKLCBPE().allowHDR) ? RenderTextureFormat.ARGB32 : RenderTextureFormat.RGB565;
			this.HHIAIGCAHDA().SetInt("_ScreenResolution", this.settings.reflectionSettings.stepSize);
			this.material.SetInt("_TimeX", (this.settings.reflectionSettings.blendType != ScreenSpaceReflection.SSRReflectionBlendType.PhysicallyBased) ? 0 : 1);
			this.KEMAALEODNH().SetInt("_Distortion", (!this.LIIFBNDLBLB) ? 0 : 1);
			this.OGMEGHKECAH().SetInt("_Value4", (!this.GNAJGEOHKLG) ? 0 : 0);
			this.HHIAIGCAHDA().SetInt(" = ", (!this.settings.reflectionSettings.reflectBackfaces) ? 0 : 1);
			this.KHCLIAMBBNC().SetInt("Joystick1Button1", (!this.BEJICPKGHBF) ? 0 : 0);
			this.KHCLIAMBBNC().SetInt("maphash", this.settings.reflectionSettings.iterationCount);
			this.FGENHBKMPDA().SetInt("[LevelEditorScene] Error: I/O Failure! :(", 1);
			this.LMLENGFLEBD().SetInt("_Value6", (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.SSRResolution.High) ? 1 : 1);
			this.KHCLIAMBBNC().SetInt("_Value", (!this.KMIBIBKOGDC) ? 1 : 0);
			float value = num4 / (1961f * (float)Math.Tan((double)this.GAMGCKLCBPE().fieldOfView / 1071.0 * 1626.0 * 40.0));
			this.OOMFJGPAOKL().SetFloat("_Value3", value);
			this.OGMEGHKECAH().SetFloat(".png", this.settings.screenEdgeMask.intensity);
			this.LMLENGFLEBD().SetFloat("_TimeX", this.settings.reflectionSettings.reflectionBlur);
			this.MJJIEHANFJA().SetFloat("_AlphaHexa", this.settings.reflectionSettings.maxDistance);
			this.EHDJJANLINB().SetFloat("HostType: {0} ", this.settings.intensitySettings.fadeDistance);
			this.ACHNOHCLGOO().SetFloat("Right", this.settings.reflectionSettings.widthModifier);
			this.GHHPOGODBHB().SetFloat("_Value2", this.settings.intensitySettings.reflectionMultiplier);
			this.KDMBOKLMADJ().SetFloat("Error calling OpAuthenticate! Did not work. Check log output, AuthValues and if you're connected.", this.settings.intensitySettings.fresnelFade);
			this.KHCLIAMBBNC().SetFloat("No peer to communicate with. ", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.JBLKMFFGOBM().projectionMatrix;
			Vector4 value2 = new Vector4(351f / (num4 * projectionMatrix[0]), 1445f / (num5 * projectionMatrix[4]), (475f - projectionMatrix[0]) / projectionMatrix[0], (1278f + projectionMatrix[6]) / projectionMatrix[3]);
			Vector3 v = (!float.IsPositiveInfinity(this.camera_.farClipPlane)) ? new Vector3(this.BKMMMLIJEKO().nearClipPlane * this.LCPKEGKALOK().farClipPlane, this.JBLKMFFGOBM().nearClipPlane - this.BKMMMLIJEKO().farClipPlane, this.camera_.farClipPlane) : new Vector3(this.PMKPCGLLBEG().nearClipPlane, 930f, 938f);
			this.LPDOGGFOBDH().SetVector("Set sun directionVector - in which direction sun will grow on beat", new Vector2((float)num2, (float)num3));
			this.DONENAMLFLF().SetVector("settings.volume.sfx", new Vector2(num4, num5));
			this.MJJIEHANFJA().SetVector("Encryption wasn't established: ", new Vector2(1885f / num4, 561f / num5));
			this.HHIAIGCAHDA().SetVector("ExitButton", value2);
			this.KEMAALEODNH().SetVector("_Value2", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(1, new Vector4(num6, 1778f, 1721f, num6));
			lhs.SetRow(0, new Vector4(1912f, num7, 178f, num7));
			lhs.SetRow(1, new Vector4(1475f, 82f, 1159f, 544f));
			lhs.SetRow(8, new Vector4(963f, 988f, 494f, 921f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.KDMBOKLMADJ().SetMatrix("CameraFilterPack/Drawing_Halftone", value3);
			this.LPDOGGFOBDH().SetMatrix("_MainTex", this.JBLKMFFGOBM().worldToCameraMatrix);
			this.KDMBOKLMADJ().SetMatrix("menu.playedsolo", this.camera_.worldToCameraMatrix.inverse);
			if (this.MCLNLHKFLOI == null)
			{
				this.MCLNLHKFLOI = new CommandBuffer();
				this.MCLNLHKFLOI.name = "y";
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.MJMFKCGAJCI, -1, -1, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ANEIBMOKEDM, num2, num3, 1, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
				for (int i = 1; i < 1; i++)
				{
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.LECHJDFACDM[i], num2 >> (i & -108), num3 >> (i & 105), 1, FilterMode.Point, format);
				}
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.NACHHEIPCAE, num2, num3, 1, (!this.LIIFBNDLBLB) ? FilterMode.Bilinear : FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.PFBDGMNAJJN, num2, num3, 0, FilterMode.Point, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.None, ScreenSpaceReflection.MJMFKCGAJCI, this.HHIAIGCAHDA(), 5);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.Depth, ScreenSpaceReflection.ANEIBMOKEDM, this.LDNADDJMIPK(), 0);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.Depth, ScreenSpaceReflection.NACHHEIPCAE, this.LPDOGGFOBDH(), 4);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.NACHHEIPCAE, ScreenSpaceReflection.LECHJDFACDM[0], this.material, 5);
				for (int j = 0; j < 6; j += 0)
				{
					int nameID = ScreenSpaceReflection.LECHJDFACDM[j - 0];
					int num8 = j;
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL, num2 >> (num8 & -49), num3 >> (num8 & 115), 0, FilterMode.Bilinear, format);
					this.MCLNLHKFLOI.SetGlobalVector("_TimeX", new Vector4(343f, 1258f, 343f, 131f));
					this.MCLNLHKFLOI.SetGlobalFloat("Feb", (float)j - 790f);
					this.MCLNLHKFLOI.Blit(nameID, ScreenSpaceReflection.ONHHKPOABBL, this.GHHPOGODBHB(), 4);
					this.MCLNLHKFLOI.SetGlobalVector("_Value2", new Vector4(65f, 966f, 1220f, 1190f));
					nameID = ScreenSpaceReflection.LECHJDFACDM[j];
					this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.ONHHKPOABBL, nameID, this.FGENHBKMPDA(), 2);
					this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL);
				}
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.LECHJDFACDM[0], ScreenSpaceReflection.PFBDGMNAJJN, this.LDNADDJMIPK(), 4);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE, this.BDJHHDHOFNC().pixelWidth, this.GAMGCKLCBPE().pixelHeight, 0, FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.CurrentActive, ScreenSpaceReflection.CCNBIKDGJBE, this.LMLENGFLEBD(), 0);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.CCNBIKDGJBE, BuiltinRenderTextureType.Depth);
				this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE);
				this.BKMMMLIJEKO().AddCommandBuffer((CameraEvent)(-66), this.MCLNLHKFLOI);
			}
		}

		// Token: 0x06008422 RID: 33826 RVA: 0x002D96CA File Offset: 0x002D78CA
		public Camera BKMMMLIJEKO()
		{
			if (this.CMMMNLFGCJB == null)
			{
				this.CMMMNLFGCJB = base.GetComponent<Camera>();
			}
			return this.CMMMNLFGCJB;
		}

		// Token: 0x06008423 RID: 33827 RVA: 0x002DD1DD File Offset: 0x002DB3DD
		public Material DONENAMLFLF()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.APCHLENKBKH());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06008424 RID: 33828 RVA: 0x002DD208 File Offset: 0x002DB408
		public void DHDOPDDCAGH()
		{
			if (this.HHIAIGCAHDA() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != (RenderingPath)6)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.SSRResolution.High) ? 0 : 0;
			int num2 = this.camera_.pixelWidth / num;
			int num3 = this.JBLKMFFGOBM().pixelHeight / num;
			float num4 = (float)this.PMKPCGLLBEG().pixelWidth;
			float num5 = (float)this.BDJHHDHOFNC().pixelHeight;
			float num6 = num4 / 273f;
			float num7 = num5 / 626f;
			RenderTextureFormat format = (!this.NKLHLDLODKG().allowHDR) ? RenderTextureFormat.Depth : RenderTextureFormat.Shadowmap;
			this.ACHNOHCLGOO().SetInt("_ScreenResolution", this.settings.reflectionSettings.stepSize);
			this.LMLENGFLEBD().SetInt(" TimeOfRespawn: ", (this.settings.reflectionSettings.blendType != ScreenSpaceReflection.SSRReflectionBlendType.PhysicallyBased) ? 0 : 0);
			this.FGENHBKMPDA().SetInt("HIDE CONFIG [Ctrl+E]", (!this.LIIFBNDLBLB) ? 0 : 0);
			this.MJJIEHANFJA().SetInt("[Up]", (!this.GNAJGEOHKLG) ? 0 : 1);
			this.OOMFJGPAOKL().SetInt("DPADVER", (!this.settings.reflectionSettings.reflectBackfaces) ? 1 : 1);
			this.KEMAALEODNH().SetInt("Backward", (!this.BEJICPKGHBF) ? 0 : 1);
			this.material.SetInt("OpCreateRoom()", this.settings.reflectionSettings.iterationCount);
			this.KEMAALEODNH().SetInt("Vertical", 1);
			this.MJJIEHANFJA().SetInt("CameraFilterPack/TV_Video3D", (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.SSRResolution.High) ? 0 : 1);
			this.GHHPOGODBHB().SetInt("value", (!this.KMIBIBKOGDC) ? 1 : 1);
			float value = num4 / (566f * (float)Math.Tan((double)this.GAMGCKLCBPE().fieldOfView / 127.0 * 1539.0 * 550.0));
			this.LPDOGGFOBDH().SetFloat("PlayButton", value);
			this.MJJIEHANFJA().SetFloat("_Value5", this.settings.screenEdgeMask.intensity);
			this.KDMBOKLMADJ().SetFloat("_Value5", this.settings.reflectionSettings.reflectionBlur);
			this.DONENAMLFLF().SetFloat("id", this.settings.reflectionSettings.maxDistance);
			this.EHDJJANLINB().SetFloat("masterSteamID", this.settings.intensitySettings.fadeDistance);
			this.JIBOKBCPDLC().SetFloat("_Value3", this.settings.reflectionSettings.widthModifier);
			this.MJJIEHANFJA().SetFloat("Can't set open when not in that room.", this.settings.intensitySettings.reflectionMultiplier);
			this.GHHPOGODBHB().SetFloat("ColorBlood", this.settings.intensitySettings.fresnelFade);
			this.material.SetFloat("open", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.camera_.projectionMatrix;
			Vector4 value2 = new Vector4(1409f / (num4 * projectionMatrix[0]), 1287f / (num5 * projectionMatrix[1]), (335f - projectionMatrix[5]) / projectionMatrix[0], (666f + projectionMatrix[1]) / projectionMatrix[7]);
			Vector3 v = (!float.IsPositiveInfinity(this.GAMGCKLCBPE().farClipPlane)) ? new Vector3(this.NKLHLDLODKG().nearClipPlane * this.LCPKEGKALOK().farClipPlane, this.EDBDDIOLPJN().nearClipPlane - this.GAMGCKLCBPE().farClipPlane, this.LCPKEGKALOK().farClipPlane) : new Vector3(this.JBLKMFFGOBM().nearClipPlane, 1671f, 1519f);
			this.EHDJJANLINB().SetVector("_ScreenResolution", new Vector2((float)num2, (float)num3));
			this.OGMEGHKECAH().SetVector("skin.", new Vector2(num4, num5));
			this.LMLENGFLEBD().SetVector("_Y", new Vector2(1987f / num4, 212f / num5));
			this.JIBOKBCPDLC().SetVector("_Offsets", value2);
			this.DONENAMLFLF().SetVector("Failed to InstantiateSceneObject prefab: ", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(0, new Vector4(num6, 1918f, 807f, num6));
			lhs.SetRow(0, new Vector4(1411f, num7, 210f, num7));
			lhs.SetRow(6, new Vector4(810f, 190f, 1636f, 484f));
			lhs.SetRow(8, new Vector4(504f, 139f, 1264f, 1376f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.GHHPOGODBHB().SetMatrix("Editor/", value3);
			this.FGENHBKMPDA().SetMatrix("UseScanLine", this.PMKPCGLLBEG().worldToCameraMatrix);
			this.OOMFJGPAOKL().SetMatrix("_ScreenResolution", this.NKLHLDLODKG().worldToCameraMatrix.inverse);
			if (this.MCLNLHKFLOI == null)
			{
				this.MCLNLHKFLOI = new CommandBuffer();
				this.MCLNLHKFLOI.name = "(\\[ *\\/ *url *])";
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.MJMFKCGAJCI, -1, -1, 1, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ANEIBMOKEDM, num2, num3, 1, FilterMode.Bilinear, RenderTextureFormat.Default, RenderTextureReadWrite.Linear);
				for (int i = 0; i < 0; i++)
				{
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.LECHJDFACDM[i], num2 >> (i & -112), num3 >> (i & 114), 0, FilterMode.Point, format);
				}
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.NACHHEIPCAE, num2, num3, 1, (!this.LIIFBNDLBLB) ? FilterMode.Point : FilterMode.Point, format);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.PFBDGMNAJJN, num2, num3, 0, FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.Depth, ScreenSpaceReflection.MJMFKCGAJCI, this.OOMFJGPAOKL(), 3);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.CameraTarget, ScreenSpaceReflection.ANEIBMOKEDM, this.LPDOGGFOBDH(), 0);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.Depth, ScreenSpaceReflection.NACHHEIPCAE, this.HHIAIGCAHDA(), 0);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.NACHHEIPCAE, ScreenSpaceReflection.LECHJDFACDM[1], this.JIBOKBCPDLC(), 8);
				for (int j = 0; j < 5; j++)
				{
					int nameID = ScreenSpaceReflection.LECHJDFACDM[j - 1];
					int num8 = j;
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL, num2 >> (num8 & -68), num3 >> (num8 & -69), 1, FilterMode.Point, format);
					this.MCLNLHKFLOI.SetGlobalVector("Done! You are a contributor until: ", new Vector4(1397f, 1782f, 1416f, 14f));
					this.MCLNLHKFLOI.SetGlobalFloat("_Heigh", (float)j - 1304f);
					this.MCLNLHKFLOI.Blit(nameID, ScreenSpaceReflection.ONHHKPOABBL, this.ACHNOHCLGOO(), 6);
					this.MCLNLHKFLOI.SetGlobalVector(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.", new Vector4(1148f, 962f, 1614f, 1340f));
					nameID = ScreenSpaceReflection.LECHJDFACDM[j];
					this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.ONHHKPOABBL, nameID, this.LPDOGGFOBDH(), 8);
					this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL);
				}
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.LECHJDFACDM[1], ScreenSpaceReflection.PFBDGMNAJJN, this.KEMAALEODNH(), 7);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE, this.NKLHLDLODKG().pixelWidth, this.BKMMMLIJEKO().pixelHeight, 0, FilterMode.Point, format);
				this.MCLNLHKFLOI.Blit((BuiltinRenderTextureType)6, ScreenSpaceReflection.CCNBIKDGJBE, this.EHDJJANLINB(), 0);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.CCNBIKDGJBE, BuiltinRenderTextureType.PrepassLight);
				this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE);
				this.JBLKMFFGOBM().AddCommandBuffer((CameraEvent)90, this.MCLNLHKFLOI);
			}
		}

		// Token: 0x06008425 RID: 33829 RVA: 0x002DDAC4 File Offset: 0x002DBCC4
		private void MFLBEJHMEMO()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
			if (this.LCPKEGKALOK() != null)
			{
				if (this.MCLNLHKFLOI != null)
				{
					this.camera_.RemoveCommandBuffer((CameraEvent)29, this.MCLNLHKFLOI);
				}
				this.MCLNLHKFLOI = null;
			}
		}

		// Token: 0x06008426 RID: 33830 RVA: 0x002DDB29 File Offset: 0x002DBD29
		public Material LPDOGGFOBDH()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.EKDCLNEAFBB());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06008427 RID: 33831 RVA: 0x002D96CA File Offset: 0x002D78CA
		public Camera GAMGCKLCBPE()
		{
			if (this.CMMMNLFGCJB == null)
			{
				this.CMMMNLFGCJB = base.GetComponent<Camera>();
			}
			return this.CMMMNLFGCJB;
		}

		// Token: 0x06008428 RID: 33832 RVA: 0x002DDB53 File Offset: 0x002DBD53
		public Shader KGHKBFGDHGF()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("Feb");
			}
			return this.m_Shader;
		}

		// Token: 0x06008429 RID: 33833 RVA: 0x002DDB7C File Offset: 0x002DBD7C
		public void MFOELBJCHNK()
		{
			if (this.KHCLIAMBBNC() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != (RenderingPath)7)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.SSRResolution.High) ? 2 : 0;
			int num2 = this.NKLHLDLODKG().pixelWidth / num;
			int num3 = this.BDJHHDHOFNC().pixelHeight / num;
			float num4 = (float)this.BKMMMLIJEKO().pixelWidth;
			float num5 = (float)this.JIKPBCLILCC().pixelHeight;
			float num6 = num4 / 101f;
			float num7 = num5 / 1653f;
			RenderTextureFormat format = (!this.PMKPCGLLBEG().allowHDR) ? RenderTextureFormat.Depth : RenderTextureFormat.ARGBHalf;
			this.JIBOKBCPDLC().SetInt("mapselector.filter.subscribedonly", this.settings.reflectionSettings.stepSize);
			this.DONENAMLFLF().SetInt(",", (this.settings.reflectionSettings.blendType != ScreenSpaceReflection.SSRReflectionBlendType.Additive) ? 0 : 1);
			this.HHIAIGCAHDA().SetInt("[LevelEditorScene] Print Audio Wave: Done", (!this.LIIFBNDLBLB) ? 0 : 1);
			this.KHCLIAMBBNC().SetInt("unsubscribemap", (!this.GNAJGEOHKLG) ? 1 : 1);
			this.EHDJJANLINB().SetInt(";", (!this.settings.reflectionSettings.reflectBackfaces) ? 1 : 0);
			this.DONENAMLFLF().SetInt("_BokehParams", (!this.BEJICPKGHBF) ? 0 : 1);
			this.LMLENGFLEBD().SetInt(".lastCheckpoint.incorrectScore", this.settings.reflectionSettings.iterationCount);
			this.DONENAMLFLF().SetInt("/music", 1);
			this.MJJIEHANFJA().SetInt("_Line", (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.SSRResolution.High) ? 1 : 0);
			this.KEMAALEODNH().SetInt("ItemNameBGImage", (!this.KMIBIBKOGDC) ? 0 : 0);
			float value = num4 / (1425f * (float)Math.Tan((double)this.PMKPCGLLBEG().fieldOfView / 956.0 * 1066.0 * 431.0));
			this.OGMEGHKECAH().SetFloat("ChatInput", value);
			this.LDNADDJMIPK().SetFloat("Value", this.settings.screenEdgeMask.intensity);
			this.PHGCJOPFDOG().SetFloat("maps.", this.settings.reflectionSettings.reflectionBlur);
			this.OOMFJGPAOKL().SetFloat("ns", this.settings.reflectionSettings.maxDistance);
			this.material.SetFloat("hardcoreinfo", this.settings.intensitySettings.fadeDistance);
			this.KEMAALEODNH().SetFloat("_LutTex", this.settings.reflectionSettings.widthModifier);
			this.PHGCJOPFDOG().SetFloat("_Value1", this.settings.intensitySettings.reflectionMultiplier);
			this.JIBOKBCPDLC().SetFloat("move", this.settings.intensitySettings.fresnelFade);
			this.OGMEGHKECAH().SetFloat("Needs to be attached to the Event System component in the scene", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.BKMMMLIJEKO().projectionMatrix;
			Vector4 value2 = new Vector4(114f / (num4 * projectionMatrix[1]), 268f / (num5 * projectionMatrix[5]), (1122f - projectionMatrix[7]) / projectionMatrix[0], (703f + projectionMatrix[1]) / projectionMatrix[6]);
			Vector3 v = (!float.IsPositiveInfinity(this.BKMMMLIJEKO().farClipPlane)) ? new Vector3(this.NKLHLDLODKG().nearClipPlane * this.PMKPCGLLBEG().farClipPlane, this.camera_.nearClipPlane - this.GAMGCKLCBPE().farClipPlane, this.GAMGCKLCBPE().farClipPlane) : new Vector3(this.camera_.nearClipPlane, 69f, 1241f);
			this.KDMBOKLMADJ().SetVector("AudioSampler", new Vector2((float)num2, (float)num3));
			this.FGENHBKMPDA().SetVector("<color=#{0}>{1}</color>", new Vector2(num4, num5));
			this.KDMBOKLMADJ().SetVector("_Value", new Vector2(618f / num4, 1722f / num5));
			this.MJJIEHANFJA().SetVector("_Value4", value2);
			this.LPDOGGFOBDH().SetVector("Failed to 'network-remove' GameObject because it is missing a valid InstantiationId on view: ", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(1, new Vector4(num6, 489f, 1514f, num6));
			lhs.SetRow(0, new Vector4(1196f, num7, 1033f, num7));
			lhs.SetRow(5, new Vector4(1660f, 455f, 1826f, 141f));
			lhs.SetRow(8, new Vector4(863f, 659f, 1758f, 1585f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.HHIAIGCAHDA().SetMatrix("_TimeX", value3);
			this.FGENHBKMPDA().SetMatrix("settings.enablehitsoundsinnormal", this.JIKPBCLILCC().worldToCameraMatrix);
			this.KEMAALEODNH().SetMatrix("/", this.GAMGCKLCBPE().worldToCameraMatrix.inverse);
			if (this.MCLNLHKFLOI == null)
			{
				this.MCLNLHKFLOI = new CommandBuffer();
				this.MCLNLHKFLOI.name = "SetTrailZoomSpeed";
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.MJMFKCGAJCI, -1, -1, 0, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ANEIBMOKEDM, num2, num3, 1, FilterMode.Point, RenderTextureFormat.RGB565, RenderTextureReadWrite.Default);
				for (int i = 0; i < 4; i += 0)
				{
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.LECHJDFACDM[i], num2 >> (i & -65), num3 >> (i & 86), 0, FilterMode.Bilinear, format);
				}
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.NACHHEIPCAE, num2, num3, 1, (!this.LIIFBNDLBLB) ? FilterMode.Bilinear : FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.PFBDGMNAJJN, num2, num3, 0, FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.DepthNormals, ScreenSpaceReflection.MJMFKCGAJCI, this.material, 2);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.DepthNormals, ScreenSpaceReflection.ANEIBMOKEDM, this.FGENHBKMPDA(), 1);
				this.MCLNLHKFLOI.Blit((BuiltinRenderTextureType)6, ScreenSpaceReflection.NACHHEIPCAE, this.JIBOKBCPDLC(), 4);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.NACHHEIPCAE, ScreenSpaceReflection.LECHJDFACDM[1], this.MJJIEHANFJA(), 3);
				for (int j = 1; j < 3; j++)
				{
					int nameID = ScreenSpaceReflection.LECHJDFACDM[j - 0];
					int num8 = j;
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL, num2 >> (num8 & 20), num3 >> (num8 & -78), 0, FilterMode.Bilinear, format);
					this.MCLNLHKFLOI.SetGlobalVector("note.0", new Vector4(1439f, 518f, 942f, 1890f));
					this.MCLNLHKFLOI.SetGlobalFloat("_Value4", (float)j - 1782f);
					this.MCLNLHKFLOI.Blit(nameID, ScreenSpaceReflection.ONHHKPOABBL, this.MJJIEHANFJA(), 8);
					this.MCLNLHKFLOI.SetGlobalVector(" ", new Vector4(735f, 801f, 1674f, 745f));
					nameID = ScreenSpaceReflection.LECHJDFACDM[j];
					this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.ONHHKPOABBL, nameID, this.GHHPOGODBHB(), 6);
					this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL);
				}
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.LECHJDFACDM[0], ScreenSpaceReflection.PFBDGMNAJJN, this.PHGCJOPFDOG(), 5);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE, this.EDBDDIOLPJN().pixelWidth, this.LCPKEGKALOK().pixelHeight, 1, FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.None, ScreenSpaceReflection.CCNBIKDGJBE, this.LDNADDJMIPK(), 0);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.CCNBIKDGJBE, BuiltinRenderTextureType.PrepassNormalsSpec);
				this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE);
				this.camera_.AddCommandBuffer(CameraEvent.AfterReflections, this.MCLNLHKFLOI);
			}
		}

		// Token: 0x0600842A RID: 33834 RVA: 0x002DE438 File Offset: 0x002DC638
		private void FGBDGGCBFLP()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
			if (this.NKLHLDLODKG() != null)
			{
				if (this.MCLNLHKFLOI != null)
				{
					this.BDJHHDHOFNC().RemoveCommandBuffer((CameraEvent)(-68), this.MCLNLHKFLOI);
				}
				this.MCLNLHKFLOI = null;
			}
		}

		// Token: 0x0600842B RID: 33835 RVA: 0x002DE4A0 File Offset: 0x002DC6A0
		private void JJIMCJBMKEF()
		{
			if (!ImageEffectHelper.IsSupported(this.NBBAABCLJEF(), true, false, this))
			{
				base.enabled = true;
				return;
			}
			this.NKLHLDLODKG().depthTextureMode |= DepthTextureMode.Depth;
			ScreenSpaceReflection.LECHJDFACDM = new int[2];
			ScreenSpaceReflection.MJMFKCGAJCI = Shader.PropertyToID("_TimeX");
			ScreenSpaceReflection.ANEIBMOKEDM = Shader.PropertyToID("#mapby");
			ScreenSpaceReflection.LECHJDFACDM[0] = Shader.PropertyToID("CameraFilterPack/Blend2Camera_Lighten");
			ScreenSpaceReflection.LECHJDFACDM[0] = Shader.PropertyToID("_Value3");
			ScreenSpaceReflection.LECHJDFACDM[5] = Shader.PropertyToID("CameraFilterPack/Vision_Warp");
			ScreenSpaceReflection.LECHJDFACDM[7] = Shader.PropertyToID("LoadPlayerSkin");
			ScreenSpaceReflection.LECHJDFACDM[1] = Shader.PropertyToID(".lastCheckpoint.comboScore");
			ScreenSpaceReflection.ONHHKPOABBL = Shader.PropertyToID("SetEnvSpriteImage");
			ScreenSpaceReflection.NACHHEIPCAE = Shader.PropertyToID("Exit to menu?");
			ScreenSpaceReflection.PFBDGMNAJJN = Shader.PropertyToID("_Value2");
			ScreenSpaceReflection.CCNBIKDGJBE = Shader.PropertyToID("NO");
		}

		// Token: 0x0600842C RID: 33836 RVA: 0x002D96CA File Offset: 0x002D78CA
		public Camera EDBDDIOLPJN()
		{
			if (this.CMMMNLFGCJB == null)
			{
				this.CMMMNLFGCJB = base.GetComponent<Camera>();
			}
			return this.CMMMNLFGCJB;
		}

		// Token: 0x0600842D RID: 33837 RVA: 0x002DE598 File Offset: 0x002DC798
		private void DLOAJEFNKDA()
		{
			if (!ImageEffectHelper.IsSupported(this.EKDCLNEAFBB(), true, true, this))
			{
				base.enabled = true;
				return;
			}
			this.camera_.depthTextureMode |= DepthTextureMode.Depth;
			ScreenSpaceReflection.LECHJDFACDM = new int[3];
			ScreenSpaceReflection.MJMFKCGAJCI = Shader.PropertyToID("_ScreenResolution");
			ScreenSpaceReflection.ANEIBMOKEDM = Shader.PropertyToID("CameraFilterPack/Drawing_Curve");
			ScreenSpaceReflection.LECHJDFACDM[0] = Shader.PropertyToID("_EdgeThresholdMin");
			ScreenSpaceReflection.LECHJDFACDM[1] = Shader.PropertyToID("STOP [R]");
			ScreenSpaceReflection.LECHJDFACDM[7] = Shader.PropertyToID("_TimeX");
			ScreenSpaceReflection.LECHJDFACDM[8] = Shader.PropertyToID("[MapsData] Caching ");
			ScreenSpaceReflection.LECHJDFACDM[3] = Shader.PropertyToID("_ScreenResolution");
			ScreenSpaceReflection.ONHHKPOABBL = Shader.PropertyToID("_Value4");
			ScreenSpaceReflection.NACHHEIPCAE = Shader.PropertyToID("_AreaTex");
			ScreenSpaceReflection.PFBDGMNAJJN = Shader.PropertyToID("x");
			ScreenSpaceReflection.CCNBIKDGJBE = Shader.PropertyToID("SpawnObj");
		}

		// Token: 0x0600842E RID: 33838 RVA: 0x002DE690 File Offset: 0x002DC890
		public void OJBBNBFFGJM()
		{
			if (this.JIBOKBCPDLC() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != RenderingPath.Forward)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.SSRResolution.High) ? 1 : 1;
			int num2 = this.GAMGCKLCBPE().pixelWidth / num;
			int num3 = this.BKMMMLIJEKO().pixelHeight / num;
			float num4 = (float)this.NKLHLDLODKG().pixelWidth;
			float num5 = (float)this.camera_.pixelHeight;
			float num6 = num4 / 66f;
			float num7 = num5 / 1798f;
			RenderTextureFormat format = (!this.EDBDDIOLPJN().allowHDR) ? RenderTextureFormat.ARGB32 : RenderTextureFormat.ARGB2101010;
			this.LDNADDJMIPK().SetInt(": ", this.settings.reflectionSettings.stepSize);
			this.OOMFJGPAOKL().SetInt("_ScreenResolution", (this.settings.reflectionSettings.blendType != ScreenSpaceReflection.SSRReflectionBlendType.PhysicallyBased) ? 0 : 0);
			this.MJJIEHANFJA().SetInt("LeaderboardsButton", (!this.LIIFBNDLBLB) ? 1 : 1);
			this.KHCLIAMBBNC().SetInt("[LocalizationService] All languages: ", (!this.GNAJGEOHKLG) ? 0 : 0);
			this.KDMBOKLMADJ().SetInt("SupportLogger OnJoinedRoom(", (!this.settings.reflectionSettings.reflectBackfaces) ? 0 : 0);
			this.MJJIEHANFJA().SetInt("_Intensity", (!this.BEJICPKGHBF) ? 0 : 0);
			this.EHDJJANLINB().SetInt("_Value4", this.settings.reflectionSettings.iterationCount);
			this.FGENHBKMPDA().SetInt("-showlogs", 1);
			this.FGENHBKMPDA().SetInt("_HrDepthTex", (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.SSRResolution.High) ? 1 : 1);
			this.FGENHBKMPDA().SetInt("_Near", (!this.KMIBIBKOGDC) ? 0 : 1);
			float value = num4 / (1645f * (float)Math.Tan((double)this.BDJHHDHOFNC().fieldOfView / 342.0 * 86.0 * 444.0));
			this.material.SetFloat("Edited unlock conditions", value);
			this.EHDJJANLINB().SetFloat("FileMenu", this.settings.screenEdgeMask.intensity);
			this.GHHPOGODBHB().SetFloat("_ScreenResolution", this.settings.reflectionSettings.reflectionBlur);
			this.ACHNOHCLGOO().SetFloat(".lastCheckpoint.correctScore", this.settings.reflectionSettings.maxDistance);
			this.DONENAMLFLF().SetFloat("maps.", this.settings.intensitySettings.fadeDistance);
			this.GHHPOGODBHB().SetFloat("ReJoinRoom failed due to offline mode.", this.settings.reflectionSettings.widthModifier);
			this.LDNADDJMIPK().SetFloat("_PColor", this.settings.intensitySettings.reflectionMultiplier);
			this.FGENHBKMPDA().SetFloat("Joystick1Button7", this.settings.intensitySettings.fresnelFade);
			this.HHIAIGCAHDA().SetFloat("resource id", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.PMKPCGLLBEG().projectionMatrix;
			Vector4 value2 = new Vector4(1937f / (num4 * projectionMatrix[1]), 1367f / (num5 * projectionMatrix[4]), (1551f - projectionMatrix[3]) / projectionMatrix[1], (1152f + projectionMatrix[7]) / projectionMatrix[5]);
			Vector3 v = (!float.IsPositiveInfinity(this.BDJHHDHOFNC().farClipPlane)) ? new Vector3(this.BKMMMLIJEKO().nearClipPlane * this.JBLKMFFGOBM().farClipPlane, this.JBLKMFFGOBM().nearClipPlane - this.EDBDDIOLPJN().farClipPlane, this.LCPKEGKALOK().farClipPlane) : new Vector3(this.BKMMMLIJEKO().nearClipPlane, 1343f, 671f);
			this.KHCLIAMBBNC().SetVector("...", new Vector2((float)num2, (float)num3));
			this.OGMEGHKECAH().SetVector("connecting", new Vector2(num4, num5));
			this.PHGCJOPFDOG().SetVector("float,0.5", new Vector2(1201f / num4, 1066f / num5));
			this.MJJIEHANFJA().SetVector("CameraFilterPack/Blend2Camera_Divide", value2);
			this.material.SetVector("skin.", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(0, new Vector4(num6, 1108f, 1209f, num6));
			lhs.SetRow(1, new Vector4(12f, num7, 731f, num7));
			lhs.SetRow(4, new Vector4(971f, 1988f, 1430f, 1635f));
			lhs.SetRow(6, new Vector4(1505f, 426f, 843f, 1965f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.EHDJJANLINB().SetMatrix("Middle Click", value3);
			this.EHDJJANLINB().SetMatrix("open", this.BDJHHDHOFNC().worldToCameraMatrix);
			this.OOMFJGPAOKL().SetMatrix(".", this.JIKPBCLILCC().worldToCameraMatrix.inverse);
			if (this.MCLNLHKFLOI == null)
			{
				this.MCLNLHKFLOI = new CommandBuffer();
				this.MCLNLHKFLOI.name = "NEW_ACHIEVEMENT_1_26";
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.MJMFKCGAJCI, -1, -1, 0, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ANEIBMOKEDM, num2, num3, 1, FilterMode.Point, RenderTextureFormat.ARGB4444, RenderTextureReadWrite.Default);
				for (int i = 1; i < 4; i += 0)
				{
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.LECHJDFACDM[i], num2 >> (i & 36), num3 >> (i & -91), 0, FilterMode.Bilinear, format);
				}
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.NACHHEIPCAE, num2, num3, 0, (!this.LIIFBNDLBLB) ? FilterMode.Point : FilterMode.Point, format);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.PFBDGMNAJJN, num2, num3, 0, FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.DepthNormals, ScreenSpaceReflection.MJMFKCGAJCI, this.ACHNOHCLGOO(), 7);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.PrepassLight, ScreenSpaceReflection.ANEIBMOKEDM, this.KDMBOKLMADJ(), 1);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.Depth, ScreenSpaceReflection.NACHHEIPCAE, this.EHDJJANLINB(), 5);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.NACHHEIPCAE, ScreenSpaceReflection.LECHJDFACDM[1], this.HHIAIGCAHDA(), 0);
				for (int j = 0; j < 7; j++)
				{
					int nameID = ScreenSpaceReflection.LECHJDFACDM[j - 0];
					int num8 = j;
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL, num2 >> (num8 & -113), num3 >> (num8 & -47), 1, FilterMode.Point, format);
					this.MCLNLHKFLOI.SetGlobalVector("_Intensity", new Vector4(372f, 96f, 334f, 89f));
					this.MCLNLHKFLOI.SetGlobalFloat("_Blend", (float)j - 299f);
					this.MCLNLHKFLOI.Blit(nameID, ScreenSpaceReflection.ONHHKPOABBL, this.ACHNOHCLGOO(), 8);
					this.MCLNLHKFLOI.SetGlobalVector("_Value4", new Vector4(866f, 500f, 1996f, 1623f));
					nameID = ScreenSpaceReflection.LECHJDFACDM[j];
					this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.ONHHKPOABBL, nameID, this.GHHPOGODBHB(), 0);
					this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL);
				}
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.LECHJDFACDM[0], ScreenSpaceReflection.PFBDGMNAJJN, this.EHDJJANLINB(), 2);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE, this.BDJHHDHOFNC().pixelWidth, this.PMKPCGLLBEG().pixelHeight, 0, FilterMode.Point, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, ScreenSpaceReflection.CCNBIKDGJBE, this.HHIAIGCAHDA(), 0);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.CCNBIKDGJBE, BuiltinRenderTextureType.CameraTarget);
				this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE);
				this.JIKPBCLILCC().AddCommandBuffer(CameraEvent.BeforeForwardAlpha, this.MCLNLHKFLOI);
			}
		}

		// Token: 0x0600842F RID: 33839 RVA: 0x002DEF4C File Offset: 0x002DD14C
		public void ALKLJKLDGKC()
		{
			if (this.KDMBOKLMADJ() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != (RenderingPath)5)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.SSRResolution.High) ? 5 : 1;
			int num2 = this.BKMMMLIJEKO().pixelWidth / num;
			int num3 = this.BDJHHDHOFNC().pixelHeight / num;
			float num4 = (float)this.BDJHHDHOFNC().pixelWidth;
			float num5 = (float)this.JIKPBCLILCC().pixelHeight;
			float num6 = num4 / 276f;
			float num7 = num5 / 598f;
			RenderTextureFormat format = (!this.NKLHLDLODKG().allowHDR) ? RenderTextureFormat.ARGB32 : RenderTextureFormat.Default;
			this.MJJIEHANFJA().SetInt("_QualitySettings", this.settings.reflectionSettings.stepSize);
			this.LMLENGFLEBD().SetInt("Warning: Unhandled event ", (this.settings.reflectionSettings.blendType != ScreenSpaceReflection.SSRReflectionBlendType.Additive) ? 1 : 1);
			this.HHIAIGCAHDA().SetInt("settings.volume.menu", (!this.LIIFBNDLBLB) ? 1 : 1);
			this.ACHNOHCLGOO().SetInt("CameraFilterPack/Real_VHS", (!this.GNAJGEOHKLG) ? 0 : 0);
			this.ACHNOHCLGOO().SetInt(" takes from: ", (!this.settings.reflectionSettings.reflectBackfaces) ? 1 : 1);
			this.LMLENGFLEBD().SetInt("_ScreenResolution", (!this.BEJICPKGHBF) ? 0 : 0);
			this.HHIAIGCAHDA().SetInt("CameraFilterPack/FX_Drunk", this.settings.reflectionSettings.iterationCount);
			this.JIBOKBCPDLC().SetInt("StartButton", 1);
			this.EHDJJANLINB().SetInt("_ScreenResolution", (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.SSRResolution.High) ? 1 : 0);
			this.FGENHBKMPDA().SetInt("/icon", (!this.KMIBIBKOGDC) ? 0 : 0);
			float value = num4 / (279f * (float)Math.Tan((double)this.GAMGCKLCBPE().fieldOfView / 534.0 * 1069.0 * 1523.0));
			this.EHDJJANLINB().SetFloat("SpawnObj", value);
			this.LPDOGGFOBDH().SetFloat("In Main Menu", this.settings.screenEdgeMask.intensity);
			this.material.SetFloat(" from: ", this.settings.reflectionSettings.reflectionBlur);
			this.FGENHBKMPDA().SetFloat("CameraFilterPack_3D_Myst1", this.settings.reflectionSettings.maxDistance);
			this.ACHNOHCLGOO().SetFloat("_Green_C", this.settings.intensitySettings.fadeDistance);
			this.JIBOKBCPDLC().SetFloat("_TimeX", this.settings.reflectionSettings.widthModifier);
			this.FGENHBKMPDA().SetFloat("effector", this.settings.intensitySettings.reflectionMultiplier);
			this.OGMEGHKECAH().SetFloat("CameraFilterPack_TV_HorrorFX", this.settings.intensitySettings.fresnelFade);
			this.EHDJJANLINB().SetFloat("_V", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.BDJHHDHOFNC().projectionMatrix;
			Vector4 value2 = new Vector4(347f / (num4 * projectionMatrix[0]), 1497f / (num5 * projectionMatrix[6]), (804f - projectionMatrix[7]) / projectionMatrix[0], (1197f + projectionMatrix[1]) / projectionMatrix[3]);
			Vector3 v = (!float.IsPositiveInfinity(this.LCPKEGKALOK().farClipPlane)) ? new Vector3(this.JBLKMFFGOBM().nearClipPlane * this.NKLHLDLODKG().farClipPlane, this.PMKPCGLLBEG().nearClipPlane - this.PMKPCGLLBEG().farClipPlane, this.BDJHHDHOFNC().farClipPlane) : new Vector3(this.BDJHHDHOFNC().nearClipPlane, 407f, 980f);
			this.FGENHBKMPDA().SetVector("AvatarImage", new Vector2((float)num2, (float)num3));
			this.ACHNOHCLGOO().SetVector("maps.", new Vector2(num4, num5));
			this.GHHPOGODBHB().SetVector("_TimeX", new Vector2(1328f / num4, 771f / num5));
			this.EHDJJANLINB().SetVector("original.tutorial", value2);
			this.FGENHBKMPDA().SetVector("checkpoint", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(1, new Vector4(num6, 749f, 704f, num6));
			lhs.SetRow(1, new Vector4(1055f, num7, 132f, num7));
			lhs.SetRow(1, new Vector4(1220f, 1604f, 1193f, 1481f));
			lhs.SetRow(1, new Vector4(979f, 1698f, 1579f, 1315f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.MJJIEHANFJA().SetMatrix("_WorldToCameraMatrix", value3);
			this.JIBOKBCPDLC().SetMatrix("DPADHOR", this.GAMGCKLCBPE().worldToCameraMatrix);
			this.LDNADDJMIPK().SetMatrix("_LoopCount", this.EDBDDIOLPJN().worldToCameraMatrix.inverse);
			if (this.MCLNLHKFLOI == null)
			{
				this.MCLNLHKFLOI = new CommandBuffer();
				this.MCLNLHKFLOI.name = "Editor/";
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.MJMFKCGAJCI, -1, -1, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ANEIBMOKEDM, num2, num3, 1, FilterMode.Point, RenderTextureFormat.Shadowmap, RenderTextureReadWrite.Linear);
				for (int i = 0; i < 4; i++)
				{
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.LECHJDFACDM[i], num2 >> (i & -21), num3 >> (i & 102), 1, FilterMode.Point, format);
				}
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.NACHHEIPCAE, num2, num3, 1, (!this.LIIFBNDLBLB) ? FilterMode.Point : FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.PFBDGMNAJJN, num2, num3, 1, FilterMode.Point, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.PrepassLight, ScreenSpaceReflection.MJMFKCGAJCI, this.PHGCJOPFDOG(), 5);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.ResolvedDepth, ScreenSpaceReflection.ANEIBMOKEDM, this.FGENHBKMPDA(), 1);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.PrepassLight, ScreenSpaceReflection.NACHHEIPCAE, this.OGMEGHKECAH(), 4);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.NACHHEIPCAE, ScreenSpaceReflection.LECHJDFACDM[1], this.MJJIEHANFJA(), 2);
				for (int j = 0; j < 2; j++)
				{
					int nameID = ScreenSpaceReflection.LECHJDFACDM[j - 1];
					int num8 = j;
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL, num2 >> (num8 & 49), num3 >> (num8 & 49), 1, FilterMode.Bilinear, format);
					this.MCLNLHKFLOI.SetGlobalVector("_Radius", new Vector4(240f, 1955f, 1033f, 351f));
					this.MCLNLHKFLOI.SetGlobalFloat("mapid", (float)j - 764f);
					this.MCLNLHKFLOI.Blit(nameID, ScreenSpaceReflection.ONHHKPOABBL, this.EHDJJANLINB(), 7);
					this.MCLNLHKFLOI.SetGlobalVector(" BETA", new Vector4(1575f, 1216f, 335f, 1164f));
					nameID = ScreenSpaceReflection.LECHJDFACDM[j];
					this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.ONHHKPOABBL, nameID, this.GHHPOGODBHB(), 6);
					this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL);
				}
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.LECHJDFACDM[1], ScreenSpaceReflection.PFBDGMNAJJN, this.PHGCJOPFDOG(), 1);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE, this.EDBDDIOLPJN().pixelWidth, this.JIKPBCLILCC().pixelHeight, 0, FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.CurrentActive, ScreenSpaceReflection.CCNBIKDGJBE, this.MJJIEHANFJA(), 0);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.CCNBIKDGJBE, BuiltinRenderTextureType.PrepassLight);
				this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE);
				this.EDBDDIOLPJN().AddCommandBuffer((CameraEvent)98, this.MCLNLHKFLOI);
			}
		}

		// Token: 0x06008430 RID: 33840 RVA: 0x002DF808 File Offset: 0x002DDA08
		private void NJHJHBOJKIC()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
			if (this.LCPKEGKALOK() != null)
			{
				if (this.MCLNLHKFLOI != null)
				{
					this.EDBDDIOLPJN().RemoveCommandBuffer((CameraEvent)124, this.MCLNLHKFLOI);
				}
				this.MCLNLHKFLOI = null;
			}
		}

		// Token: 0x06008432 RID: 33842 RVA: 0x002DF88E File Offset: 0x002DDA8E
		public Shader BPGLBABLFOO()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("BloomShaderValueSlider");
			}
			return this.m_Shader;
		}

		// Token: 0x06008433 RID: 33843 RVA: 0x002DF8B8 File Offset: 0x002DDAB8
		private void FJIKDJAMOHA()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
			if (this.BDJHHDHOFNC() != null)
			{
				if (this.MCLNLHKFLOI != null)
				{
					this.camera_.RemoveCommandBuffer((CameraEvent)(-61), this.MCLNLHKFLOI);
				}
				this.MCLNLHKFLOI = null;
			}
		}

		// Token: 0x06008434 RID: 33844 RVA: 0x002DF91D File Offset: 0x002DDB1D
		public Material OOMFJGPAOKL()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.OJCDNJDGOLG());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06008435 RID: 33845 RVA: 0x002DF947 File Offset: 0x002DDB47
		public Shader NBBAABCLJEF()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("[BuildInfo] Error: ");
			}
			return this.m_Shader;
		}

		// Token: 0x06008436 RID: 33846 RVA: 0x002DF970 File Offset: 0x002DDB70
		private void OnDisable()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
			if (this.camera_ != null)
			{
				if (this.MCLNLHKFLOI != null)
				{
					this.camera_.RemoveCommandBuffer(CameraEvent.AfterFinalPass, this.MCLNLHKFLOI);
				}
				this.MCLNLHKFLOI = null;
			}
		}

		// Token: 0x06008437 RID: 33847 RVA: 0x002DF9D8 File Offset: 0x002DDBD8
		public void JHEPEMKNAMM()
		{
			if (this.OGMEGHKECAH() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != (RenderingPath)4)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.SSRResolution.High) ? 3 : 0;
			int num2 = this.EDBDDIOLPJN().pixelWidth / num;
			int num3 = this.NKLHLDLODKG().pixelHeight / num;
			float num4 = (float)this.PMKPCGLLBEG().pixelWidth;
			float num5 = (float)this.BKMMMLIJEKO().pixelHeight;
			float num6 = num4 / 1749f;
			float num7 = num5 / 453f;
			RenderTextureFormat format = (!this.BDJHHDHOFNC().allowHDR) ? RenderTextureFormat.ARGB32 : RenderTextureFormat.ARGB2101010;
			this.GHHPOGODBHB().SetInt("_EmissionGain", this.settings.reflectionSettings.stepSize);
			this.KDMBOKLMADJ().SetInt("_GlowColor", (this.settings.reflectionSettings.blendType != ScreenSpaceReflection.SSRReflectionBlendType.PhysicallyBased) ? 0 : 0);
			this.LMLENGFLEBD().SetInt("In Maps Editor", (!this.LIIFBNDLBLB) ? 0 : 0);
			this.JIBOKBCPDLC().SetInt("Failed to 'GetKeyCode' for key: ", (!this.GNAJGEOHKLG) ? 0 : 1);
			this.LPDOGGFOBDH().SetInt("settings.volume.game", (!this.settings.reflectionSettings.reflectBackfaces) ? 0 : 1);
			this.PHGCJOPFDOG().SetInt("maps.", (!this.BEJICPKGHBF) ? 1 : 0);
			this.FGENHBKMPDA().SetInt("Tab2Content", this.settings.reflectionSettings.iterationCount);
			this.GHHPOGODBHB().SetInt("_Value5", 1);
			this.JIBOKBCPDLC().SetInt("CameraFilterPack/FX_8bits_gb", (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.SSRResolution.High) ? 1 : 0);
			this.LPDOGGFOBDH().SetInt("_Bloom0", (!this.KMIBIBKOGDC) ? 1 : 1);
			float value = num4 / (1616f * (float)Math.Tan((double)this.NKLHLDLODKG().fieldOfView / 1292.0 * 396.0 * 502.0));
			this.JIBOKBCPDLC().SetFloat("0", value);
			this.KDMBOKLMADJ().SetFloat("_Value2", this.settings.screenEdgeMask.intensity);
			this.OOMFJGPAOKL().SetFloat("AudioSampler", this.settings.reflectionSettings.reflectionBlur);
			this.JIBOKBCPDLC().SetFloat("CameraFilterPack_Glasses_On5", this.settings.reflectionSettings.maxDistance);
			this.LDNADDJMIPK().SetFloat("[MapsData] Workshop maps was loaded", this.settings.intensitySettings.fadeDistance);
			this.FGENHBKMPDA().SetFloat("AddEnvironmentSprite", this.settings.reflectionSettings.widthModifier);
			this.GHHPOGODBHB().SetFloat("skin.", this.settings.intensitySettings.reflectionMultiplier);
			this.ACHNOHCLGOO().SetFloat("[Right]", this.settings.intensitySettings.fresnelFade);
			this.EHDJJANLINB().SetFloat("mapselector.tags.", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.camera_.projectionMatrix;
			Vector4 value2 = new Vector4(1179f / (num4 * projectionMatrix[1]), 181f / (num5 * projectionMatrix[4]), (1114f - projectionMatrix[2]) / projectionMatrix[1], (1450f + projectionMatrix[5]) / projectionMatrix[8]);
			Vector3 v = (!float.IsPositiveInfinity(this.LCPKEGKALOK().farClipPlane)) ? new Vector3(this.GAMGCKLCBPE().nearClipPlane * this.GAMGCKLCBPE().farClipPlane, this.JBLKMFFGOBM().nearClipPlane - this.BDJHHDHOFNC().farClipPlane, this.camera_.farClipPlane) : new Vector3(this.JIKPBCLILCC().nearClipPlane, 819f, 1231f);
			this.HHIAIGCAHDA().SetVector("_Green_G", new Vector2((float)num2, (float)num3));
			this.KHCLIAMBBNC().SetVector("Drop_Far", new Vector2(num4, num5));
			this.LPDOGGFOBDH().SetVector("[Right]", new Vector2(881f / num4, 971f / num5));
			this.KEMAALEODNH().SetVector("-", value2);
			this.OGMEGHKECAH().SetVector("SpawnObj", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(1, new Vector4(num6, 1077f, 723f, num6));
			lhs.SetRow(0, new Vector4(354f, num7, 1483f, num7));
			lhs.SetRow(7, new Vector4(217f, 919f, 17f, 17f));
			lhs.SetRow(8, new Vector4(1435f, 218f, 1963f, 1745f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.FGENHBKMPDA().SetMatrix("CameraFilterPack_Broken_Screen1", value3);
			this.HHIAIGCAHDA().SetMatrix(" ", this.camera_.worldToCameraMatrix);
			this.JIBOKBCPDLC().SetMatrix("_UserLutParams", this.EDBDDIOLPJN().worldToCameraMatrix.inverse);
			if (this.MCLNLHKFLOI == null)
			{
				this.MCLNLHKFLOI = new CommandBuffer();
				this.MCLNLHKFLOI.name = "<b>(╯°□°）╯︵ ┻━┻</b>";
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.MJMFKCGAJCI, -1, -1, 1, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Linear);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ANEIBMOKEDM, num2, num3, 1, FilterMode.Bilinear, RenderTextureFormat.ARGB2101010, RenderTextureReadWrite.Default);
				for (int i = 1; i < 7; i++)
				{
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.LECHJDFACDM[i], num2 >> (i & 84), num3 >> (i & -48), 1, FilterMode.Point, format);
				}
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.NACHHEIPCAE, num2, num3, 1, (!this.LIIFBNDLBLB) ? FilterMode.Bilinear : FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.PFBDGMNAJJN, num2, num3, 0, FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.DepthNormals, ScreenSpaceReflection.MJMFKCGAJCI, this.OOMFJGPAOKL(), 3);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.DepthNormals, ScreenSpaceReflection.ANEIBMOKEDM, this.FGENHBKMPDA(), 1);
				this.MCLNLHKFLOI.Blit((BuiltinRenderTextureType)6, ScreenSpaceReflection.NACHHEIPCAE, this.GHHPOGODBHB(), 8);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.NACHHEIPCAE, ScreenSpaceReflection.LECHJDFACDM[0], this.GHHPOGODBHB(), 6);
				for (int j = 0; j < 0; j += 0)
				{
					int nameID = ScreenSpaceReflection.LECHJDFACDM[j - 0];
					int num8 = j;
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL, num2 >> (num8 & 72), num3 >> (num8 & -117), 1, FilterMode.Bilinear, format);
					this.MCLNLHKFLOI.SetGlobalVector("[PlayerController] ", new Vector4(1984f, 779f, 1636f, 849f));
					this.MCLNLHKFLOI.SetGlobalFloat("resetach21", (float)j - 1740f);
					this.MCLNLHKFLOI.Blit(nameID, ScreenSpaceReflection.ONHHKPOABBL, this.material, 1);
					this.MCLNLHKFLOI.SetGlobalVector("[UI] ", new Vector4(1621f, 1105f, 1260f, 850f));
					nameID = ScreenSpaceReflection.LECHJDFACDM[j];
					this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.ONHHKPOABBL, nameID, this.EHDJJANLINB(), 7);
					this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL);
				}
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.LECHJDFACDM[1], ScreenSpaceReflection.PFBDGMNAJJN, this.OGMEGHKECAH(), 3);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE, this.NKLHLDLODKG().pixelWidth, this.LCPKEGKALOK().pixelHeight, 1, FilterMode.Point, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.None, ScreenSpaceReflection.CCNBIKDGJBE, this.HHIAIGCAHDA(), 1);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.CCNBIKDGJBE, BuiltinRenderTextureType.DepthNormals);
				this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE);
				this.JIKPBCLILCC().AddCommandBuffer((CameraEvent)(-16), this.MCLNLHKFLOI);
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06008438 RID: 33848 RVA: 0x002E0291 File Offset: 0x002DE491
		public Shader shader
		{
			get
			{
				if (this.m_Shader == null)
				{
					this.m_Shader = Shader.Find("Hidden/ScreenSpaceReflection");
				}
				return this.m_Shader;
			}
		}

		// Token: 0x06008439 RID: 33849 RVA: 0x002E02BC File Offset: 0x002DE4BC
		public void KMEPBPAKAPK()
		{
			if (this.MJJIEHANFJA() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != RenderingPath.DeferredShading)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.SSRResolution.High) ? 0 : 0;
			int num2 = this.PMKPCGLLBEG().pixelWidth / num;
			int num3 = this.camera_.pixelHeight / num;
			float num4 = (float)this.GAMGCKLCBPE().pixelWidth;
			float num5 = (float)this.PMKPCGLLBEG().pixelHeight;
			float num6 = num4 / 1527f;
			float num7 = num5 / 660f;
			RenderTextureFormat format = (!this.PMKPCGLLBEG().allowHDR) ? RenderTextureFormat.Depth : RenderTextureFormat.ARGBHalf;
			this.KDMBOKLMADJ().SetInt("GLITCH", this.settings.reflectionSettings.stepSize);
			this.FGENHBKMPDA().SetInt("shader.invert", (this.settings.reflectionSettings.blendType != ScreenSpaceReflection.SSRReflectionBlendType.Additive) ? 0 : 1);
			this.MJJIEHANFJA().SetInt("Gameplay/LobbyPlayerIconElement", (!this.LIIFBNDLBLB) ? 0 : 0);
			this.LPDOGGFOBDH().SetInt("_TimeX", (!this.GNAJGEOHKLG) ? 0 : 1);
			this.KDMBOKLMADJ().SetInt("Scrollbar", (!this.settings.reflectionSettings.reflectBackfaces) ? 1 : 0);
			this.KDMBOKLMADJ().SetInt("id", (!this.BEJICPKGHBF) ? 0 : 1);
			this.ACHNOHCLGOO().SetInt("BitsData", this.settings.reflectionSettings.iterationCount);
			this.HHIAIGCAHDA().SetInt("CameraFilterPack/Film_ColorPerfection", 0);
			this.OOMFJGPAOKL().SetInt("UI Extensions/UIMultiply", (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.SSRResolution.High) ? 1 : 0);
			this.OOMFJGPAOKL().SetInt("event", (!this.KMIBIBKOGDC) ? 0 : 1);
			float value = num4 / (1605f * (float)Math.Tan((double)this.EDBDDIOLPJN().fieldOfView / 1945.0 * 1928.0 * 678.0));
			this.PHGCJOPFDOG().SetFloat(".lastCheckpoint.lives", value);
			this.OOMFJGPAOKL().SetFloat("Load Game", this.settings.screenEdgeMask.intensity);
			this.EHDJJANLINB().SetFloat("[MenuScene] Error: ", this.settings.reflectionSettings.reflectionBlur);
			this.MJJIEHANFJA().SetFloat("_Blue_B", this.settings.reflectionSettings.maxDistance);
			this.LPDOGGFOBDH().SetFloat("#TBD", this.settings.intensitySettings.fadeDistance);
			this.PHGCJOPFDOG().SetFloat("_Intensity", this.settings.reflectionSettings.widthModifier);
			this.MJJIEHANFJA().SetFloat("_PositionY", this.settings.intensitySettings.reflectionMultiplier);
			this.HHIAIGCAHDA().SetFloat("_ScreenResolution", this.settings.intensitySettings.fresnelFade);
			this.KDMBOKLMADJ().SetFloat(",", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.camera_.projectionMatrix;
			Vector4 value2 = new Vector4(647f / (num4 * projectionMatrix[0]), 1329f / (num5 * projectionMatrix[7]), (1972f - projectionMatrix[4]) / projectionMatrix[0], (1734f + projectionMatrix[0]) / projectionMatrix[7]);
			Vector3 v = (!float.IsPositiveInfinity(this.JIKPBCLILCC().farClipPlane)) ? new Vector3(this.EDBDDIOLPJN().nearClipPlane * this.BDJHHDHOFNC().farClipPlane, this.LCPKEGKALOK().nearClipPlane - this.EDBDDIOLPJN().farClipPlane, this.camera_.farClipPlane) : new Vector3(this.BKMMMLIJEKO().nearClipPlane, 1326f, 581f);
			this.MJJIEHANFJA().SetVector("ERROR: Preview file must be <1MB!", new Vector2((float)num2, (float)num3));
			this.LMLENGFLEBD().SetVector("offsets", new Vector2(num4, num5));
			this.OGMEGHKECAH().SetVector("Player", new Vector2(362f / num4, 1583f / num5));
			this.ACHNOHCLGOO().SetVector("SpawnObj", value2);
			this.EHDJJANLINB().SetVector("bloomintencity:", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(1, new Vector4(num6, 393f, 1350f, num6));
			lhs.SetRow(0, new Vector4(238f, num7, 1572f, num7));
			lhs.SetRow(3, new Vector4(1573f, 1289f, 229f, 341f));
			lhs.SetRow(3, new Vector4(46f, 27f, 263f, 1001f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.HHIAIGCAHDA().SetMatrix("icon", value3);
			this.LMLENGFLEBD().SetMatrix("bad", this.EDBDDIOLPJN().worldToCameraMatrix);
			this.JIBOKBCPDLC().SetMatrix("_Value", this.JIKPBCLILCC().worldToCameraMatrix.inverse);
			if (this.MCLNLHKFLOI == null)
			{
				this.MCLNLHKFLOI = new CommandBuffer();
				this.MCLNLHKFLOI.name = "Items/";
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.MJMFKCGAJCI, -1, -1, 1, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ANEIBMOKEDM, num2, num3, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB4444, RenderTextureReadWrite.Default);
				for (int i = 0; i < 8; i += 0)
				{
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.LECHJDFACDM[i], num2 >> (i & -83), num3 >> (i & 99), 1, FilterMode.Bilinear, format);
				}
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.NACHHEIPCAE, num2, num3, 1, (!this.LIIFBNDLBLB) ? FilterMode.Point : FilterMode.Point, format);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.PFBDGMNAJJN, num2, num3, 1, FilterMode.Point, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.CurrentActive, ScreenSpaceReflection.MJMFKCGAJCI, this.PHGCJOPFDOG(), 7);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.CameraTarget, ScreenSpaceReflection.ANEIBMOKEDM, this.DONENAMLFLF(), 1);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.DepthNormals, ScreenSpaceReflection.NACHHEIPCAE, this.KHCLIAMBBNC(), 8);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.NACHHEIPCAE, ScreenSpaceReflection.LECHJDFACDM[1], this.material, 1);
				for (int j = 1; j < 1; j++)
				{
					int nameID = ScreenSpaceReflection.LECHJDFACDM[j - 1];
					int num8 = j;
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL, num2 >> (num8 & -51), num3 >> (num8 & 52), 0, FilterMode.Bilinear, format);
					this.MCLNLHKFLOI.SetGlobalVector("BadgeText", new Vector4(1653f, 1389f, 1210f, 315f));
					this.MCLNLHKFLOI.SetGlobalFloat("[PlayerController] ", (float)j - 971f);
					this.MCLNLHKFLOI.Blit(nameID, ScreenSpaceReflection.ONHHKPOABBL, this.LMLENGFLEBD(), 7);
					this.MCLNLHKFLOI.SetGlobalVector("Fade", new Vector4(724f, 1911f, 575f, 295f));
					nameID = ScreenSpaceReflection.LECHJDFACDM[j];
					this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.ONHHKPOABBL, nameID, this.LDNADDJMIPK(), 1);
					this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL);
				}
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.LECHJDFACDM[1], ScreenSpaceReflection.PFBDGMNAJJN, this.FGENHBKMPDA(), 6);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE, this.camera_.pixelWidth, this.LCPKEGKALOK().pixelHeight, 0, FilterMode.Point, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.ResolvedDepth, ScreenSpaceReflection.CCNBIKDGJBE, this.LDNADDJMIPK(), 1);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.CCNBIKDGJBE, BuiltinRenderTextureType.Depth);
				this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE);
				this.LCPKEGKALOK().AddCommandBuffer((CameraEvent)(-117), this.MCLNLHKFLOI);
			}
		}

		// Token: 0x0600843A RID: 33850 RVA: 0x002E0B75 File Offset: 0x002DED75
		public Shader AHJPLBJFCJE()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_Value3");
			}
			return this.m_Shader;
		}

		// Token: 0x0600843B RID: 33851 RVA: 0x002E0BA0 File Offset: 0x002DEDA0
		public void GNILGIPMADE()
		{
			if (this.HHIAIGCAHDA() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != RenderingPath.DeferredLighting)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.SSRResolution.High) ? 4 : 1;
			int num2 = this.BDJHHDHOFNC().pixelWidth / num;
			int num3 = this.JBLKMFFGOBM().pixelHeight / num;
			float num4 = (float)this.JBLKMFFGOBM().pixelWidth;
			float num5 = (float)this.BDJHHDHOFNC().pixelHeight;
			float num6 = num4 / 660f;
			float num7 = num5 / 310f;
			RenderTextureFormat format = (!this.LCPKEGKALOK().allowHDR) ? RenderTextureFormat.Depth : RenderTextureFormat.Shadowmap;
			this.LDNADDJMIPK().SetInt("GlassDistortion", this.settings.reflectionSettings.stepSize);
			this.material.SetInt("MenuVolumeSlider", (this.settings.reflectionSettings.blendType != ScreenSpaceReflection.SSRReflectionBlendType.PhysicallyBased) ? 1 : 0);
			this.material.SetInt("ConnectToMaster() failed. Can only connect while in state 'Disconnected'. Current state: ", (!this.LIIFBNDLBLB) ? 0 : 0);
			this.ACHNOHCLGOO().SetInt("LoadingStatusText", (!this.GNAJGEOHKLG) ? 1 : 0);
			this.material.SetInt("x", (!this.settings.reflectionSettings.reflectBackfaces) ? 0 : 1);
			this.KHCLIAMBBNC().SetInt("bad", (!this.BEJICPKGHBF) ? 1 : 0);
			this.GHHPOGODBHB().SetInt("RateButton", this.settings.reflectionSettings.iterationCount);
			this.KDMBOKLMADJ().SetInt("restart", 1);
			this.OOMFJGPAOKL().SetInt("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.SSRResolution.High) ? 0 : 0);
			this.GHHPOGODBHB().SetInt("cancel", (!this.KMIBIBKOGDC) ? 1 : 1);
			float value = num4 / (348f * (float)Math.Tan((double)this.BDJHHDHOFNC().fieldOfView / 1368.0 * 611.0 * 440.0));
			this.MJJIEHANFJA().SetFloat("_Gamma", value);
			this.MJJIEHANFJA().SetFloat("menutheme.coldheat", this.settings.screenEdgeMask.intensity);
			this.ACHNOHCLGOO().SetFloat("sounds/hit_wrong", this.settings.reflectionSettings.reflectionBlur);
			this.DONENAMLFLF().SetFloat("_Value", this.settings.reflectionSettings.maxDistance);
			this.OGMEGHKECAH().SetFloat("MapperNameText", this.settings.intensitySettings.fadeDistance);
			this.HHIAIGCAHDA().SetFloat("StartButton", this.settings.reflectionSettings.widthModifier);
			this.OGMEGHKECAH().SetFloat(".icon", this.settings.intensitySettings.reflectionMultiplier);
			this.LDNADDJMIPK().SetFloat("LevelProgressBar", this.settings.intensitySettings.fresnelFade);
			this.PHGCJOPFDOG().SetFloat("_ScreenResolution", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.PMKPCGLLBEG().projectionMatrix;
			Vector4 value2 = new Vector4(612f / (num4 * projectionMatrix[0]), 1514f / (num5 * projectionMatrix[0]), (454f - projectionMatrix[7]) / projectionMatrix[1], (1741f + projectionMatrix[1]) / projectionMatrix[4]);
			Vector3 v = (!float.IsPositiveInfinity(this.JIKPBCLILCC().farClipPlane)) ? new Vector3(this.JBLKMFFGOBM().nearClipPlane * this.GAMGCKLCBPE().farClipPlane, this.BKMMMLIJEKO().nearClipPlane - this.JBLKMFFGOBM().farClipPlane, this.JBLKMFFGOBM().farClipPlane) : new Vector3(this.BDJHHDHOFNC().nearClipPlane, 380f, 549f);
			this.FGENHBKMPDA().SetVector("bloomintencity:", new Vector2((float)num2, (float)num3));
			this.FGENHBKMPDA().SetVector("menu.selectedplaymode", new Vector2(num4, num5));
			this.HHIAIGCAHDA().SetVector("UseScanLineSize", new Vector2(723f / num4, 932f / num5));
			this.GHHPOGODBHB().SetVector("GlassesColor2", value2);
			this.FGENHBKMPDA().SetVector("CorrectHitsScoreText", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(0, new Vector4(num6, 236f, 1904f, num6));
			lhs.SetRow(1, new Vector4(1981f, num7, 907f, num7));
			lhs.SetRow(7, new Vector4(1746f, 835f, 906f, 1291f));
			lhs.SetRow(7, new Vector4(1233f, 1700f, 511f, 1413f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.JIBOKBCPDLC().SetMatrix("error", value3);
			this.FGENHBKMPDA().SetMatrix("tagElement", this.NKLHLDLODKG().worldToCameraMatrix);
			this.KEMAALEODNH().SetMatrix("{0}{1}{2}={3}", this.BDJHHDHOFNC().worldToCameraMatrix.inverse);
			if (this.MCLNLHKFLOI == null)
			{
				this.MCLNLHKFLOI = new CommandBuffer();
				this.MCLNLHKFLOI.name = "\\";
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.MJMFKCGAJCI, -1, -1, 0, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ANEIBMOKEDM, num2, num3, 0, FilterMode.Point, RenderTextureFormat.ARGBHalf, RenderTextureReadWrite.Linear);
				for (int i = 1; i < 8; i += 0)
				{
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.LECHJDFACDM[i], num2 >> (i & -44), num3 >> (i & -35), 1, FilterMode.Point, format);
				}
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.NACHHEIPCAE, num2, num3, 0, (!this.LIIFBNDLBLB) ? FilterMode.Bilinear : FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.PFBDGMNAJJN, num2, num3, 1, FilterMode.Point, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.ResolvedDepth, ScreenSpaceReflection.MJMFKCGAJCI, this.DONENAMLFLF(), 0);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.CameraTarget, ScreenSpaceReflection.ANEIBMOKEDM, this.material, 1);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.ResolvedDepth, ScreenSpaceReflection.NACHHEIPCAE, this.FGENHBKMPDA(), 1);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.NACHHEIPCAE, ScreenSpaceReflection.LECHJDFACDM[1], this.KDMBOKLMADJ(), 0);
				for (int j = 0; j < 0; j += 0)
				{
					int nameID = ScreenSpaceReflection.LECHJDFACDM[j - 1];
					int num8 = j;
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL, num2 >> (num8 & 108), num3 >> (num8 & 69), 1, FilterMode.Bilinear, format);
					this.MCLNLHKFLOI.SetGlobalVector("PunSupportLogger", new Vector4(734f, 1349f, 1723f, 1697f));
					this.MCLNLHKFLOI.SetGlobalFloat(" id: ", (float)j - 1528f);
					this.MCLNLHKFLOI.Blit(nameID, ScreenSpaceReflection.ONHHKPOABBL, this.KEMAALEODNH(), 2);
					this.MCLNLHKFLOI.SetGlobalVector("_DisplayVelocityScale", new Vector4(173f, 1731f, 1271f, 1093f));
					nameID = ScreenSpaceReflection.LECHJDFACDM[j];
					this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.ONHHKPOABBL, nameID, this.LMLENGFLEBD(), 5);
					this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL);
				}
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.LECHJDFACDM[0], ScreenSpaceReflection.PFBDGMNAJJN, this.DONENAMLFLF(), 5);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE, this.EDBDDIOLPJN().pixelWidth, this.EDBDDIOLPJN().pixelHeight, 1, FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.PrepassLight, ScreenSpaceReflection.CCNBIKDGJBE, this.KDMBOKLMADJ(), 1);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.CCNBIKDGJBE, BuiltinRenderTextureType.ResolvedDepth);
				this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE);
				this.BKMMMLIJEKO().AddCommandBuffer((CameraEvent)44, this.MCLNLHKFLOI);
			}
		}

		// Token: 0x0600843C RID: 33852 RVA: 0x002E145C File Offset: 0x002DF65C
		private void IBPAMDEAGJL()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
			if (this.PMKPCGLLBEG() != null)
			{
				if (this.MCLNLHKFLOI != null)
				{
					this.LCPKEGKALOK().RemoveCommandBuffer((CameraEvent)123, this.MCLNLHKFLOI);
				}
				this.MCLNLHKFLOI = null;
			}
		}

		// Token: 0x0600843D RID: 33853 RVA: 0x002E14C4 File Offset: 0x002DF6C4
		private void DHNGNHGDPLM()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
			if (this.GAMGCKLCBPE() != null)
			{
				if (this.MCLNLHKFLOI != null)
				{
					this.GAMGCKLCBPE().RemoveCommandBuffer((CameraEvent)(-38), this.MCLNLHKFLOI);
				}
				this.MCLNLHKFLOI = null;
			}
		}

		// Token: 0x0600843E RID: 33854 RVA: 0x002E1529 File Offset: 0x002DF729
		public Material LMLENGFLEBD()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.JFAIMFDJBJC());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x0600843F RID: 33855 RVA: 0x002E1553 File Offset: 0x002DF753
		public Material ACHNOHCLGOO()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.NBBAABCLJEF());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06008440 RID: 33856 RVA: 0x002E1580 File Offset: 0x002DF780
		private void LICOLMAOHKI()
		{
			if (!ImageEffectHelper.IsSupported(this.BPGLBABLFOO(), true, true, this))
			{
				base.enabled = true;
				return;
			}
			this.JBLKMFFGOBM().depthTextureMode |= DepthTextureMode.Depth;
			ScreenSpaceReflection.LECHJDFACDM = new int[8];
			ScreenSpaceReflection.MJMFKCGAJCI = Shader.PropertyToID("  |  Events Count: ");
			ScreenSpaceReflection.ANEIBMOKEDM = Shader.PropertyToID("PublishButton");
			ScreenSpaceReflection.LECHJDFACDM[0] = Shader.PropertyToID("CameraFilterPack/Blend2Camera_Darken");
			ScreenSpaceReflection.LECHJDFACDM[1] = Shader.PropertyToID("Joystick1Button5");
			ScreenSpaceReflection.LECHJDFACDM[3] = Shader.PropertyToID("_Value2");
			ScreenSpaceReflection.LECHJDFACDM[3] = Shader.PropertyToID("_Value2");
			ScreenSpaceReflection.LECHJDFACDM[5] = Shader.PropertyToID(" Also make sure to disable sprite packing for this sprite.");
			ScreenSpaceReflection.ONHHKPOABBL = Shader.PropertyToID("y");
			ScreenSpaceReflection.NACHHEIPCAE = Shader.PropertyToID("_Value5");
			ScreenSpaceReflection.PFBDGMNAJJN = Shader.PropertyToID("_FgOverlap");
			ScreenSpaceReflection.CCNBIKDGJBE = Shader.PropertyToID("Joystick1Button6");
		}

		// Token: 0x06008441 RID: 33857 RVA: 0x002D96CA File Offset: 0x002D78CA
		public Camera LCPKEGKALOK()
		{
			if (this.CMMMNLFGCJB == null)
			{
				this.CMMMNLFGCJB = base.GetComponent<Camera>();
			}
			return this.CMMMNLFGCJB;
		}

		// Token: 0x06008442 RID: 33858 RVA: 0x002D96CA File Offset: 0x002D78CA
		public Camera JIKPBCLILCC()
		{
			if (this.CMMMNLFGCJB == null)
			{
				this.CMMMNLFGCJB = base.GetComponent<Camera>();
			}
			return this.CMMMNLFGCJB;
		}

		// Token: 0x06008443 RID: 33859 RVA: 0x002E1678 File Offset: 0x002DF878
		private void LLDBPKHDPKI()
		{
			if (!ImageEffectHelper.IsSupported(this.ABIPGLGMODP(), true, false, this))
			{
				base.enabled = true;
				return;
			}
			this.LCPKEGKALOK().depthTextureMode |= DepthTextureMode.None;
			ScreenSpaceReflection.LECHJDFACDM = new int[8];
			ScreenSpaceReflection.MJMFKCGAJCI = Shader.PropertyToID("_Speed");
			ScreenSpaceReflection.ANEIBMOKEDM = Shader.PropertyToID("ws://");
			ScreenSpaceReflection.LECHJDFACDM[0] = Shader.PropertyToID("\\n");
			ScreenSpaceReflection.LECHJDFACDM[0] = Shader.PropertyToID("/");
			ScreenSpaceReflection.LECHJDFACDM[0] = Shader.PropertyToID("[PowerUp]");
			ScreenSpaceReflection.LECHJDFACDM[4] = Shader.PropertyToID("TestMapButton");
			ScreenSpaceReflection.LECHJDFACDM[7] = Shader.PropertyToID(". Stopping handling if inactive.");
			ScreenSpaceReflection.ONHHKPOABBL = Shader.PropertyToID("???");
			ScreenSpaceReflection.NACHHEIPCAE = Shader.PropertyToID("PhotonView with ID ");
			ScreenSpaceReflection.PFBDGMNAJJN = Shader.PropertyToID("_TimeX");
			ScreenSpaceReflection.CCNBIKDGJBE = Shader.PropertyToID("_Value1");
		}

		// Token: 0x06008444 RID: 33860 RVA: 0x002E1770 File Offset: 0x002DF970
		private void IFJDKDFLGBG()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
			if (this.JBLKMFFGOBM() != null)
			{
				if (this.MCLNLHKFLOI != null)
				{
					this.BDJHHDHOFNC().RemoveCommandBuffer((CameraEvent)(-121), this.MCLNLHKFLOI);
				}
				this.MCLNLHKFLOI = null;
			}
		}

		// Token: 0x06008445 RID: 33861 RVA: 0x002E17D5 File Offset: 0x002DF9D5
		public Shader APCHLENKBKH()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("menutheme.hunter");
			}
			return this.m_Shader;
		}

		// Token: 0x06008446 RID: 33862 RVA: 0x002E1529 File Offset: 0x002DF729
		public Material PHGCJOPFDOG()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.JFAIMFDJBJC());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06008447 RID: 33863 RVA: 0x002E1800 File Offset: 0x002DFA00
		public void HEMFHNGONJJ()
		{
			if (this.LMLENGFLEBD() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != RenderingPath.DeferredLighting)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.SSRResolution.High) ? 6 : 1;
			int num2 = this.camera_.pixelWidth / num;
			int num3 = this.EDBDDIOLPJN().pixelHeight / num;
			float num4 = (float)this.EDBDDIOLPJN().pixelWidth;
			float num5 = (float)this.JIKPBCLILCC().pixelHeight;
			float num6 = num4 / 1584f;
			float num7 = num5 / 245f;
			RenderTextureFormat format = (!this.camera_.allowHDR) ? RenderTextureFormat.ARGB32 : RenderTextureFormat.ARGBHalf;
			this.OOMFJGPAOKL().SetInt("Joystick1Button9", this.settings.reflectionSettings.stepSize);
			this.LMLENGFLEBD().SetInt("_TimeX", (this.settings.reflectionSettings.blendType != ScreenSpaceReflection.SSRReflectionBlendType.Additive) ? 0 : 0);
			this.ACHNOHCLGOO().SetInt("Editor/", (!this.LIIFBNDLBLB) ? 1 : 0);
			this.JIBOKBCPDLC().SetInt("CameraFilterPack/Distortion_ShockWave", (!this.GNAJGEOHKLG) ? 1 : 0);
			this.KHCLIAMBBNC().SetInt("Middle Click", (!this.settings.reflectionSettings.reflectBackfaces) ? 0 : 0);
			this.material.SetInt("MouseX", (!this.BEJICPKGHBF) ? 0 : 0);
			this.MJJIEHANFJA().SetInt("MenuScene", this.settings.reflectionSettings.iterationCount);
			this.OOMFJGPAOKL().SetInt("settings.shaders", 0);
			this.material.SetInt("InventoryGrid", (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.SSRResolution.High) ? 1 : 0);
			this.ACHNOHCLGOO().SetInt("'{0}' \t{1}ms \t{2}", (!this.KMIBIBKOGDC) ? 0 : 1);
			float value = num4 / (223f * (float)Math.Tan((double)this.NKLHLDLODKG().fieldOfView / 1891.0 * 1533.0 * 580.0));
			this.GHHPOGODBHB().SetFloat("/", value);
			this.material.SetFloat("SaveMapButton", this.settings.screenEdgeMask.intensity);
			this.KDMBOKLMADJ().SetFloat("Left Click", this.settings.reflectionSettings.reflectionBlur);
			this.OGMEGHKECAH().SetFloat("_Value4", this.settings.reflectionSettings.maxDistance);
			this.LDNADDJMIPK().SetFloat(" ", this.settings.intensitySettings.fadeDistance);
			this.DONENAMLFLF().SetFloat("_Min", this.settings.reflectionSettings.widthModifier);
			this.KHCLIAMBBNC().SetFloat("#task", this.settings.intensitySettings.reflectionMultiplier);
			this.FGENHBKMPDA().SetFloat("0.00", this.settings.intensitySettings.fresnelFade);
			this.OGMEGHKECAH().SetFloat("y", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.NKLHLDLODKG().projectionMatrix;
			Vector4 value2 = new Vector4(1956f / (num4 * projectionMatrix[1]), 1684f / (num5 * projectionMatrix[3]), (763f - projectionMatrix[2]) / projectionMatrix[1], (656f + projectionMatrix[4]) / projectionMatrix[4]);
			Vector3 v = (!float.IsPositiveInfinity(this.NKLHLDLODKG().farClipPlane)) ? new Vector3(this.GAMGCKLCBPE().nearClipPlane * this.JBLKMFFGOBM().farClipPlane, this.BDJHHDHOFNC().nearClipPlane - this.LCPKEGKALOK().farClipPlane, this.BDJHHDHOFNC().farClipPlane) : new Vector3(this.NKLHLDLODKG().nearClipPlane, 999f, 1182f);
			this.LPDOGGFOBDH().SetVector("mapselector.orderby", new Vector2((float)num2, (float)num3));
			this.ACHNOHCLGOO().SetVector("Hidden/DepthOfField/MedianFilter", new Vector2(num4, num5));
			this.KDMBOKLMADJ().SetVector("_MatrixSize", new Vector2(379f / num4, 1047f / num5));
			this.ACHNOHCLGOO().SetVector("SelectorMapsCountSlider", value2);
			this.GHHPOGODBHB().SetVector("connecting", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(1, new Vector4(num6, 1290f, 594f, num6));
			lhs.SetRow(0, new Vector4(301f, num7, 303f, num7));
			lhs.SetRow(7, new Vector4(1565f, 1881f, 101f, 1826f));
			lhs.SetRow(6, new Vector4(1869f, 1506f, 200f, 556f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.PHGCJOPFDOG().SetMatrix("#failed: ", value3);
			this.EHDJJANLINB().SetMatrix("Multiplayer", this.camera_.worldToCameraMatrix);
			this.KEMAALEODNH().SetMatrix("Case-Sensitive", this.NKLHLDLODKG().worldToCameraMatrix.inverse);
			if (this.MCLNLHKFLOI == null)
			{
				this.MCLNLHKFLOI = new CommandBuffer();
				this.MCLNLHKFLOI.name = "Children";
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.MJMFKCGAJCI, -1, -1, 0, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ANEIBMOKEDM, num2, num3, 0, FilterMode.Point, RenderTextureFormat.ARGB2101010, RenderTextureReadWrite.Linear);
				for (int i = 1; i < 0; i += 0)
				{
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.LECHJDFACDM[i], num2 >> (i & -88), num3 >> (i & -62), 1, FilterMode.Point, format);
				}
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.NACHHEIPCAE, num2, num3, 1, (!this.LIIFBNDLBLB) ? FilterMode.Bilinear : FilterMode.Point, format);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.PFBDGMNAJJN, num2, num3, 1, FilterMode.Point, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, ScreenSpaceReflection.MJMFKCGAJCI, this.HHIAIGCAHDA(), 3);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.PrepassLight, ScreenSpaceReflection.ANEIBMOKEDM, this.KEMAALEODNH(), 1);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.CurrentActive, ScreenSpaceReflection.NACHHEIPCAE, this.FGENHBKMPDA(), 2);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.NACHHEIPCAE, ScreenSpaceReflection.LECHJDFACDM[0], this.LMLENGFLEBD(), 3);
				for (int j = 1; j < 7; j++)
				{
					int nameID = ScreenSpaceReflection.LECHJDFACDM[j - 0];
					int num8 = j;
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL, num2 >> (num8 & -124), num3 >> (num8 & 42), 1, FilterMode.Bilinear, format);
					this.MCLNLHKFLOI.SetGlobalVector(".lastCheckpoint.comboScore", new Vector4(1916f, 305f, 1614f, 607f));
					this.MCLNLHKFLOI.SetGlobalFloat("offsets", (float)j - 216f);
					this.MCLNLHKFLOI.Blit(nameID, ScreenSpaceReflection.ONHHKPOABBL, this.LDNADDJMIPK(), 8);
					this.MCLNLHKFLOI.SetGlobalVector("_SizeY", new Vector4(1698f, 449f, 1001f, 1596f));
					nameID = ScreenSpaceReflection.LECHJDFACDM[j];
					this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.ONHHKPOABBL, nameID, this.MJJIEHANFJA(), 2);
					this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL);
				}
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.LECHJDFACDM[1], ScreenSpaceReflection.PFBDGMNAJJN, this.KEMAALEODNH(), 1);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE, this.BDJHHDHOFNC().pixelWidth, this.EDBDDIOLPJN().pixelHeight, 0, FilterMode.Point, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.ResolvedDepth, ScreenSpaceReflection.CCNBIKDGJBE, this.LPDOGGFOBDH(), 1);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.CCNBIKDGJBE, BuiltinRenderTextureType.Depth);
				this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE);
				this.BDJHHDHOFNC().AddCommandBuffer((CameraEvent)(-37), this.MCLNLHKFLOI);
			}
		}

		// Token: 0x06008448 RID: 33864 RVA: 0x002E0B75 File Offset: 0x002DED75
		public Shader HHAAPJLFOLA()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_Value3");
			}
			return this.m_Shader;
		}

		// Token: 0x06008449 RID: 33865 RVA: 0x002E20BC File Offset: 0x002E02BC
		private void JHBPINEKDPE()
		{
			if (!ImageEffectHelper.IsSupported(this.KEHPLNBCGCJ(), true, false, this))
			{
				base.enabled = false;
				return;
			}
			this.JBLKMFFGOBM().depthTextureMode |= DepthTextureMode.None;
			ScreenSpaceReflection.LECHJDFACDM = new int[5];
			ScreenSpaceReflection.MJMFKCGAJCI = Shader.PropertyToID("ERROR: preview file name is empty in modName.workshop.json");
			ScreenSpaceReflection.ANEIBMOKEDM = Shader.PropertyToID("_ScreenResolution");
			ScreenSpaceReflection.LECHJDFACDM[0] = Shader.PropertyToID("_TimeX");
			ScreenSpaceReflection.LECHJDFACDM[0] = Shader.PropertyToID("float,0");
			ScreenSpaceReflection.LECHJDFACDM[2] = Shader.PropertyToID("[NetworkManager] Updating current room...");
			ScreenSpaceReflection.LECHJDFACDM[3] = Shader.PropertyToID("CrosshairOpacitySlider");
			ScreenSpaceReflection.LECHJDFACDM[7] = Shader.PropertyToID(" ");
			ScreenSpaceReflection.ONHHKPOABBL = Shader.PropertyToID("Item ");
			ScreenSpaceReflection.NACHHEIPCAE = Shader.PropertyToID("Joystick1Button5");
			ScreenSpaceReflection.PFBDGMNAJJN = Shader.PropertyToID("settings.showHP");
			ScreenSpaceReflection.CCNBIKDGJBE = Shader.PropertyToID("_MinVelocity");
		}

		// Token: 0x0600844A RID: 33866 RVA: 0x002E21B4 File Offset: 0x002E03B4
		private void BKGJOECFMID()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
			if (this.BDJHHDHOFNC() != null)
			{
				if (this.MCLNLHKFLOI != null)
				{
					this.NKLHLDLODKG().RemoveCommandBuffer((CameraEvent)76, this.MCLNLHKFLOI);
				}
				this.MCLNLHKFLOI = null;
			}
		}

		// Token: 0x0600844B RID: 33867 RVA: 0x002E221C File Offset: 0x002E041C
		private void LCOBDKKAGHH()
		{
			if (!ImageEffectHelper.IsSupported(this.NLECFJKGKJD(), true, true, this))
			{
				base.enabled = false;
				return;
			}
			this.LCPKEGKALOK().depthTextureMode |= DepthTextureMode.Depth;
			ScreenSpaceReflection.LECHJDFACDM = new int[2];
			ScreenSpaceReflection.MJMFKCGAJCI = Shader.PropertyToID("Set Particles Gravity");
			ScreenSpaceReflection.ANEIBMOKEDM = Shader.PropertyToID("roomDescription");
			ScreenSpaceReflection.LECHJDFACDM[1] = Shader.PropertyToID("#finished");
			ScreenSpaceReflection.LECHJDFACDM[1] = Shader.PropertyToID("Connected to masterserver.");
			ScreenSpaceReflection.LECHJDFACDM[2] = Shader.PropertyToID("_Value3");
			ScreenSpaceReflection.LECHJDFACDM[0] = Shader.PropertyToID("#done");
			ScreenSpaceReflection.LECHJDFACDM[7] = Shader.PropertyToID("\n");
			ScreenSpaceReflection.ONHHKPOABBL = Shader.PropertyToID("Room: '{0}' {1},{2} {4}/{3} players.");
			ScreenSpaceReflection.NACHHEIPCAE = Shader.PropertyToID("LevelNameInputField");
			ScreenSpaceReflection.PFBDGMNAJJN = Shader.PropertyToID("_SmoothStart");
			ScreenSpaceReflection.CCNBIKDGJBE = Shader.PropertyToID("history");
		}

		// Token: 0x0600844C RID: 33868 RVA: 0x002E2314 File Offset: 0x002E0514
		private void DPGHJILBPCE()
		{
			if (!ImageEffectHelper.IsSupported(this.NBBAABCLJEF(), false, false, this))
			{
				base.enabled = false;
				return;
			}
			this.NKLHLDLODKG().depthTextureMode |= DepthTextureMode.None;
			ScreenSpaceReflection.LECHJDFACDM = new int[3];
			ScreenSpaceReflection.MJMFKCGAJCI = Shader.PropertyToID(": ");
			ScreenSpaceReflection.ANEIBMOKEDM = Shader.PropertyToID("SetSatelliteRadius");
			ScreenSpaceReflection.LECHJDFACDM[0] = Shader.PropertyToID("masterSteamID");
			ScreenSpaceReflection.LECHJDFACDM[0] = Shader.PropertyToID("_Green_B");
			ScreenSpaceReflection.LECHJDFACDM[3] = Shader.PropertyToID("FToA");
			ScreenSpaceReflection.LECHJDFACDM[6] = Shader.PropertyToID("Couldn't call DestroyAll() as only the master client is allowed to call this.");
			ScreenSpaceReflection.LECHJDFACDM[0] = Shader.PropertyToID("stats on");
			ScreenSpaceReflection.ONHHKPOABBL = Shader.PropertyToID("Please attach component to a Graphical UI component");
			ScreenSpaceReflection.NACHHEIPCAE = Shader.PropertyToID("SetParticlesGravity");
			ScreenSpaceReflection.PFBDGMNAJJN = Shader.PropertyToID("_Light");
			ScreenSpaceReflection.CCNBIKDGJBE = Shader.PropertyToID("maps.");
		}

		// Token: 0x0600844D RID: 33869 RVA: 0x002E240C File Offset: 0x002E060C
		public void FCJHPGGPOOA()
		{
			if (this.DONENAMLFLF() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != (RenderingPath)6)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.SSRResolution.High) ? 3 : 1;
			int num2 = this.EDBDDIOLPJN().pixelWidth / num;
			int num3 = this.JIKPBCLILCC().pixelHeight / num;
			float num4 = (float)this.camera_.pixelWidth;
			float num5 = (float)this.BKMMMLIJEKO().pixelHeight;
			float num6 = num4 / 1371f;
			float num7 = num5 / 1588f;
			RenderTextureFormat format = (!this.camera_.allowHDR) ? RenderTextureFormat.Depth : RenderTextureFormat.Shadowmap;
			this.LPDOGGFOBDH().SetInt("#close", this.settings.reflectionSettings.stepSize);
			this.OOMFJGPAOKL().SetInt("_Intensity", (this.settings.reflectionSettings.blendType != ScreenSpaceReflection.SSRReflectionBlendType.PhysicallyBased) ? 1 : 0);
			this.LPDOGGFOBDH().SetInt("UI Extensions/UILinearDodge", (!this.LIIFBNDLBLB) ? 0 : 0);
			this.HHIAIGCAHDA().SetInt("SetParticlesInput", (!this.GNAJGEOHKLG) ? 0 : 1);
			this.PHGCJOPFDOG().SetInt("[PlayerBase] Unknown event: ", (!this.settings.reflectionSettings.reflectBackfaces) ? 1 : 0);
			this.DONENAMLFLF().SetInt("inventory.itemscash", (!this.BEJICPKGHBF) ? 1 : 1);
			this.OOMFJGPAOKL().SetInt("_Blend", this.settings.reflectionSettings.iterationCount);
			this.GHHPOGODBHB().SetInt("[", 0);
			this.KEMAALEODNH().SetInt("/GetNews/pinnednewsid", (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.SSRResolution.High) ? 0 : 0);
			this.OOMFJGPAOKL().SetInt("ResourceFileSelector", (!this.KMIBIBKOGDC) ? 1 : 1);
			float value = num4 / (434f * (float)Math.Tan((double)this.BDJHHDHOFNC().fieldOfView / 1435.0 * 1406.0 * 211.0));
			this.DONENAMLFLF().SetFloat("SAVE", value);
			this.FGENHBKMPDA().SetFloat(".lastCheckpoint.time", this.settings.screenEdgeMask.intensity);
			this.material.SetFloat("CameraFilterPack/FX_Glitch1", this.settings.reflectionSettings.reflectionBlur);
			this.HHIAIGCAHDA().SetFloat("_PrefilterOffs", this.settings.reflectionSettings.maxDistance);
			this.KEMAALEODNH().SetFloat("---", this.settings.intensitySettings.fadeDistance);
			this.GHHPOGODBHB().SetFloat("ItemTemplate", this.settings.reflectionSettings.widthModifier);
			this.GHHPOGODBHB().SetFloat("_MainTex2", this.settings.intensitySettings.reflectionMultiplier);
			this.material.SetFloat("Save level before uploading?", this.settings.intensitySettings.fresnelFade);
			this.KEMAALEODNH().SetFloat("Error: I/O Failure", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.EDBDDIOLPJN().projectionMatrix;
			Vector4 value2 = new Vector4(1910f / (num4 * projectionMatrix[0]), 1704f / (num5 * projectionMatrix[3]), (1266f - projectionMatrix[8]) / projectionMatrix[0], (293f + projectionMatrix[0]) / projectionMatrix[1]);
			Vector3 v = (!float.IsPositiveInfinity(this.BKMMMLIJEKO().farClipPlane)) ? new Vector3(this.EDBDDIOLPJN().nearClipPlane * this.camera_.farClipPlane, this.EDBDDIOLPJN().nearClipPlane - this.LCPKEGKALOK().farClipPlane, this.BDJHHDHOFNC().farClipPlane) : new Vector3(this.GAMGCKLCBPE().nearClipPlane, 1953f, 252f);
			this.LPDOGGFOBDH().SetVector("Scene", new Vector2((float)num2, (float)num3));
			this.KHCLIAMBBNC().SetVector("_Distance", new Vector2(num4, num5));
			this.KDMBOKLMADJ().SetVector("_Value4", new Vector2(906f / num4, 1755f / num5));
			this.LMLENGFLEBD().SetVector("_Color_R", value2);
			this.LDNADDJMIPK().SetVector("_MainTex2", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(1, new Vector4(num6, 251f, 750f, num6));
			lhs.SetRow(0, new Vector4(709f, num7, 1527f, num7));
			lhs.SetRow(3, new Vector4(1217f, 454f, 1562f, 1498f));
			lhs.SetRow(6, new Vector4(1476f, 1095f, 1690f, 1783f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.OGMEGHKECAH().SetMatrix("_Value3", value3);
			this.OGMEGHKECAH().SetMatrix("Set Satellite Color", this.EDBDDIOLPJN().worldToCameraMatrix);
			this.EHDJJANLINB().SetMatrix("_Value3", this.EDBDDIOLPJN().worldToCameraMatrix.inverse);
			if (this.MCLNLHKFLOI == null)
			{
				this.MCLNLHKFLOI = new CommandBuffer();
				this.MCLNLHKFLOI.name = "MapperNameText";
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.MJMFKCGAJCI, -1, -1, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ANEIBMOKEDM, num2, num3, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB1555, RenderTextureReadWrite.Default);
				for (int i = 0; i < 1; i += 0)
				{
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.LECHJDFACDM[i], num2 >> (i & -23), num3 >> (i & 109), 1, FilterMode.Point, format);
				}
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.NACHHEIPCAE, num2, num3, 0, (!this.LIIFBNDLBLB) ? FilterMode.Bilinear : FilterMode.Point, format);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.PFBDGMNAJJN, num2, num3, 0, FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.DepthNormals, ScreenSpaceReflection.MJMFKCGAJCI, this.KEMAALEODNH(), 2);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.None, ScreenSpaceReflection.ANEIBMOKEDM, this.LPDOGGFOBDH(), 0);
				this.MCLNLHKFLOI.Blit((BuiltinRenderTextureType)6, ScreenSpaceReflection.NACHHEIPCAE, this.FGENHBKMPDA(), 4);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.NACHHEIPCAE, ScreenSpaceReflection.LECHJDFACDM[1], this.OGMEGHKECAH(), 8);
				for (int j = 1; j < 3; j++)
				{
					int nameID = ScreenSpaceReflection.LECHJDFACDM[j - 1];
					int num8 = j;
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL, num2 >> (num8 & 8), num3 >> (num8 & -48), 0, FilterMode.Bilinear, format);
					this.MCLNLHKFLOI.SetGlobalVector("_MainTex2", new Vector4(1155f, 1850f, 201f, 1f));
					this.MCLNLHKFLOI.SetGlobalFloat("_Y", (float)j - 1093f);
					this.MCLNLHKFLOI.Blit(nameID, ScreenSpaceReflection.ONHHKPOABBL, this.KHCLIAMBBNC(), 5);
					this.MCLNLHKFLOI.SetGlobalVector("maps.", new Vector4(1449f, 627f, 940f, 1346f));
					nameID = ScreenSpaceReflection.LECHJDFACDM[j];
					this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.ONHHKPOABBL, nameID, this.OOMFJGPAOKL(), 3);
					this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL);
				}
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.LECHJDFACDM[0], ScreenSpaceReflection.PFBDGMNAJJN, this.material, 1);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE, this.PMKPCGLLBEG().pixelWidth, this.LCPKEGKALOK().pixelHeight, 1, FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.CameraTarget, ScreenSpaceReflection.CCNBIKDGJBE, this.KEMAALEODNH(), 0);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.CCNBIKDGJBE, BuiltinRenderTextureType.CurrentActive);
				this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE);
				this.PMKPCGLLBEG().AddCommandBuffer(CameraEvent.BeforeForwardOpaque, this.MCLNLHKFLOI);
			}
		}

		// Token: 0x0600844E RID: 33870 RVA: 0x002E2CC8 File Offset: 0x002E0EC8
		private void CBIBDOIBJAI()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
			if (this.NKLHLDLODKG() != null)
			{
				if (this.MCLNLHKFLOI != null)
				{
					this.NKLHLDLODKG().RemoveCommandBuffer((CameraEvent)(-123), this.MCLNLHKFLOI);
				}
				this.MCLNLHKFLOI = null;
			}
		}

		// Token: 0x0600844F RID: 33871 RVA: 0x002E2D30 File Offset: 0x002E0F30
		private void LKPBGHGCPKL()
		{
			if (!ImageEffectHelper.IsSupported(this.NLECFJKGKJD(), true, true, this))
			{
				base.enabled = false;
				return;
			}
			this.PMKPCGLLBEG().depthTextureMode |= DepthTextureMode.Depth;
			ScreenSpaceReflection.LECHJDFACDM = new int[4];
			ScreenSpaceReflection.MJMFKCGAJCI = Shader.PropertyToID("_Brightness");
			ScreenSpaceReflection.ANEIBMOKEDM = Shader.PropertyToID("PLEASE WAIT");
			ScreenSpaceReflection.LECHJDFACDM[1] = Shader.PropertyToID("_Value2");
			ScreenSpaceReflection.LECHJDFACDM[0] = Shader.PropertyToID("ResourceFileSelector");
			ScreenSpaceReflection.LECHJDFACDM[6] = Shader.PropertyToID(".lastCheckpoint.penaltyScore");
			ScreenSpaceReflection.LECHJDFACDM[3] = Shader.PropertyToID("Tab2Content");
			ScreenSpaceReflection.LECHJDFACDM[0] = Shader.PropertyToID("<b>HP</b>:");
			ScreenSpaceReflection.ONHHKPOABBL = Shader.PropertyToID("_Offsets");
			ScreenSpaceReflection.NACHHEIPCAE = Shader.PropertyToID("/");
			ScreenSpaceReflection.PFBDGMNAJJN = Shader.PropertyToID("Received event Leave for unknown player ID: {0}");
			ScreenSpaceReflection.CCNBIKDGJBE = Shader.PropertyToID(" scene: ");
		}

		// Token: 0x06008450 RID: 33872 RVA: 0x002E2E25 File Offset: 0x002E1025
		public Shader LPFFIGCNIDF()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("player.blackwhite");
			}
			return this.m_Shader;
		}

		// Token: 0x06008451 RID: 33873 RVA: 0x002E2E4E File Offset: 0x002E104E
		public Shader ABIPGLGMODP()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_ColorKey");
			}
			return this.m_Shader;
		}

		// Token: 0x06008452 RID: 33874 RVA: 0x002D96CA File Offset: 0x002D78CA
		public Camera JBLKMFFGOBM()
		{
			if (this.CMMMNLFGCJB == null)
			{
				this.CMMMNLFGCJB = base.GetComponent<Camera>();
			}
			return this.CMMMNLFGCJB;
		}

		// Token: 0x06008453 RID: 33875 RVA: 0x002D9945 File Offset: 0x002D7B45
		public Material GHHPOGODBHB()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.KEHPLNBCGCJ());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06008454 RID: 33876 RVA: 0x002D996F File Offset: 0x002D7B6F
		public Material KHCLIAMBBNC()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.LPFFIGCNIDF());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06008455 RID: 33877 RVA: 0x002E2E78 File Offset: 0x002E1078
		private void GAOOPEEBGJA()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
			if (this.JIKPBCLILCC() != null)
			{
				if (this.MCLNLHKFLOI != null)
				{
					this.EDBDDIOLPJN().RemoveCommandBuffer((CameraEvent)(-109), this.MCLNLHKFLOI);
				}
				this.MCLNLHKFLOI = null;
			}
		}

		// Token: 0x06008456 RID: 33878 RVA: 0x002E2EDD File Offset: 0x002E10DD
		public Shader CBLGFDDGPOD()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("</color>");
			}
			return this.m_Shader;
		}

		// Token: 0x06008457 RID: 33879 RVA: 0x002E2F08 File Offset: 0x002E1108
		private void ODAIMOJLJOF()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
			if (this.LCPKEGKALOK() != null)
			{
				if (this.MCLNLHKFLOI != null)
				{
					this.EDBDDIOLPJN().RemoveCommandBuffer((CameraEvent)100, this.MCLNLHKFLOI);
				}
				this.MCLNLHKFLOI = null;
			}
		}

		// Token: 0x06008458 RID: 33880 RVA: 0x002D96CA File Offset: 0x002D78CA
		public Camera NKLHLDLODKG()
		{
			if (this.CMMMNLFGCJB == null)
			{
				this.CMMMNLFGCJB = base.GetComponent<Camera>();
			}
			return this.CMMMNLFGCJB;
		}

		// Token: 0x06008459 RID: 33881 RVA: 0x002E2F6D File Offset: 0x002E116D
		public Shader IGPCJOCBOIN()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_TimeX");
			}
			return this.m_Shader;
		}

		// Token: 0x0600845A RID: 33882 RVA: 0x002E2F96 File Offset: 0x002E1196
		public Shader EKDCLNEAFBB()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("Chat");
			}
			return this.m_Shader;
		}

		// Token: 0x0600845B RID: 33883 RVA: 0x002E2FC0 File Offset: 0x002E11C0
		public void FBAPOMGMOCM()
		{
			if (this.PHGCJOPFDOG() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != RenderingPath.Forward)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.SSRResolution.High) ? 1 : 1;
			int num2 = this.PMKPCGLLBEG().pixelWidth / num;
			int num3 = this.BDJHHDHOFNC().pixelHeight / num;
			float num4 = (float)this.NKLHLDLODKG().pixelWidth;
			float num5 = (float)this.GAMGCKLCBPE().pixelHeight;
			float num6 = num4 / 825f;
			float num7 = num5 / 408f;
			RenderTextureFormat format = (!this.JBLKMFFGOBM().allowHDR) ? RenderTextureFormat.ARGB32 : RenderTextureFormat.ARGB32;
			this.LMLENGFLEBD().SetInt("The given 2D texture ", this.settings.reflectionSettings.stepSize);
			this.GHHPOGODBHB().SetInt("_Blue_R", (this.settings.reflectionSettings.blendType != ScreenSpaceReflection.SSRReflectionBlendType.Additive) ? 0 : 1);
			this.LDNADDJMIPK().SetInt("z", (!this.LIIFBNDLBLB) ? 0 : 1);
			this.HHIAIGCAHDA().SetInt("_ProjInfo", (!this.GNAJGEOHKLG) ? 1 : 1);
			this.ACHNOHCLGOO().SetInt("MusicFileSelector", (!this.settings.reflectionSettings.reflectBackfaces) ? 1 : 0);
			this.OGMEGHKECAH().SetInt("workshop.", (!this.BEJICPKGHBF) ? 1 : 1);
			this.MJJIEHANFJA().SetInt("CameraFilterPack/Blend2Camera_Multiply", this.settings.reflectionSettings.iterationCount);
			this.OGMEGHKECAH().SetInt("Malformed RPC; this should never occur. Content: ", 1);
			this.JIBOKBCPDLC().SetInt("<command>", (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.SSRResolution.High) ? 1 : 0);
			this.ACHNOHCLGOO().SetInt("_BlurRadius4", (!this.KMIBIBKOGDC) ? 1 : 0);
			float value = num4 / (409f * (float)Math.Tan((double)this.PMKPCGLLBEG().fieldOfView / 230.0 * 744.0 * 1880.0));
			this.LPDOGGFOBDH().SetFloat("_ScreenResolution", value);
			this.OGMEGHKECAH().SetFloat("(http|https)://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?\\.(jpg|jpeg|gif|png)", this.settings.screenEdgeMask.intensity);
			this.EHDJJANLINB().SetFloat(" on effect ", this.settings.reflectionSettings.reflectionBlur);
			this.KEMAALEODNH().SetFloat("sfxVolume", this.settings.reflectionSettings.maxDistance);
			this.ACHNOHCLGOO().SetFloat("_LensDirtIntensity", this.settings.intensitySettings.fadeDistance);
			this.PHGCJOPFDOG().SetFloat("color", this.settings.reflectionSettings.widthModifier);
			this.HHIAIGCAHDA().SetFloat("OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.", this.settings.intensitySettings.reflectionMultiplier);
			this.KDMBOKLMADJ().SetFloat("_Value2", this.settings.intensitySettings.fresnelFade);
			this.KEMAALEODNH().SetFloat("_Value2", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.EDBDDIOLPJN().projectionMatrix;
			Vector4 value2 = new Vector4(112f / (num4 * projectionMatrix[1]), 1371f / (num5 * projectionMatrix[0]), (808f - projectionMatrix[8]) / projectionMatrix[1], (1148f + projectionMatrix[4]) / projectionMatrix[6]);
			Vector3 v = (!float.IsPositiveInfinity(this.JIKPBCLILCC().farClipPlane)) ? new Vector3(this.JIKPBCLILCC().nearClipPlane * this.NKLHLDLODKG().farClipPlane, this.NKLHLDLODKG().nearClipPlane - this.camera_.farClipPlane, this.PMKPCGLLBEG().farClipPlane) : new Vector3(this.BDJHHDHOFNC().nearClipPlane, 1950f, 6f);
			this.LPDOGGFOBDH().SetVector(" Path: ", new Vector2((float)num2, (float)num3));
			this.ACHNOHCLGOO().SetVector("#no", new Vector2(num4, num5));
			this.LDNADDJMIPK().SetVector("_SpherePositionX", new Vector2(882f / num4, 436f / num5));
			this.material.SetVector("ConfigVersionSlider", value2);
			this.JIBOKBCPDLC().SetVector("_Value3", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(0, new Vector4(num6, 1319f, 1988f, num6));
			lhs.SetRow(0, new Vector4(774f, num7, 714f, num7));
			lhs.SetRow(2, new Vector4(1782f, 1848f, 1390f, 1727f));
			lhs.SetRow(7, new Vector4(782f, 585f, 809f, 1009f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.HHIAIGCAHDA().SetMatrix("_EmissionColor", value3);
			this.EHDJJANLINB().SetMatrix("PlayerBase_", this.BDJHHDHOFNC().worldToCameraMatrix);
			this.KDMBOKLMADJ().SetMatrix("There are too many cells created by your subdivision options. Maximum allowed number of cells is ", this.EDBDDIOLPJN().worldToCameraMatrix.inverse);
			if (this.MCLNLHKFLOI == null)
			{
				this.MCLNLHKFLOI = new CommandBuffer();
				this.MCLNLHKFLOI.name = ". Prefab must have a PhotonView component.";
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.MJMFKCGAJCI, -1, -1, 1, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ANEIBMOKEDM, num2, num3, 1, FilterMode.Bilinear, RenderTextureFormat.ARGB2101010, RenderTextureReadWrite.Linear);
				for (int i = 1; i < 2; i++)
				{
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.LECHJDFACDM[i], num2 >> (i & -119), num3 >> (i & -10), 0, FilterMode.Bilinear, format);
				}
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.NACHHEIPCAE, num2, num3, 0, (!this.LIIFBNDLBLB) ? FilterMode.Point : FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.PFBDGMNAJJN, num2, num3, 0, FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, ScreenSpaceReflection.MJMFKCGAJCI, this.MJJIEHANFJA(), 3);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.Depth, ScreenSpaceReflection.ANEIBMOKEDM, this.FGENHBKMPDA(), 0);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.ResolvedDepth, ScreenSpaceReflection.NACHHEIPCAE, this.KDMBOKLMADJ(), 3);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.NACHHEIPCAE, ScreenSpaceReflection.LECHJDFACDM[0], this.KHCLIAMBBNC(), 8);
				for (int j = 0; j < 0; j++)
				{
					int nameID = ScreenSpaceReflection.LECHJDFACDM[j - 0];
					int num8 = j;
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL, num2 >> (num8 & -82), num3 >> (num8 & 63), 1, FilterMode.Bilinear, format);
					this.MCLNLHKFLOI.SetGlobalVector(", ", new Vector4(1499f, 1745f, 461f, 123f));
					this.MCLNLHKFLOI.SetGlobalFloat("_TimeX", (float)j - 1383f);
					this.MCLNLHKFLOI.Blit(nameID, ScreenSpaceReflection.ONHHKPOABBL, this.HHIAIGCAHDA(), 0);
					this.MCLNLHKFLOI.SetGlobalVector(": ", new Vector4(839f, 1715f, 947f, 1044f));
					nameID = ScreenSpaceReflection.LECHJDFACDM[j];
					this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.ONHHKPOABBL, nameID, this.DONENAMLFLF(), 2);
					this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL);
				}
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.LECHJDFACDM[0], ScreenSpaceReflection.PFBDGMNAJJN, this.FGENHBKMPDA(), 5);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE, this.JBLKMFFGOBM().pixelWidth, this.LCPKEGKALOK().pixelHeight, 0, FilterMode.Point, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.CameraTarget, ScreenSpaceReflection.CCNBIKDGJBE, this.LMLENGFLEBD(), 0);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.CCNBIKDGJBE, BuiltinRenderTextureType.ResolvedDepth);
				this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE);
				this.LCPKEGKALOK().AddCommandBuffer((CameraEvent)(-92), this.MCLNLHKFLOI);
			}
		}

		// Token: 0x0600845C RID: 33884 RVA: 0x002E387C File Offset: 0x002E1A7C
		private void OnEnable()
		{
			if (!ImageEffectHelper.IsSupported(this.shader, false, true, this))
			{
				base.enabled = false;
				return;
			}
			this.camera_.depthTextureMode |= DepthTextureMode.Depth;
			ScreenSpaceReflection.LECHJDFACDM = new int[5];
			ScreenSpaceReflection.MJMFKCGAJCI = Shader.PropertyToID("_NormalAndRoughnessTexture");
			ScreenSpaceReflection.ANEIBMOKEDM = Shader.PropertyToID("_HitPointTexture");
			ScreenSpaceReflection.LECHJDFACDM[0] = Shader.PropertyToID("_ReflectionTexture0");
			ScreenSpaceReflection.LECHJDFACDM[1] = Shader.PropertyToID("_ReflectionTexture1");
			ScreenSpaceReflection.LECHJDFACDM[2] = Shader.PropertyToID("_ReflectionTexture2");
			ScreenSpaceReflection.LECHJDFACDM[3] = Shader.PropertyToID("_ReflectionTexture3");
			ScreenSpaceReflection.LECHJDFACDM[4] = Shader.PropertyToID("_ReflectionTexture4");
			ScreenSpaceReflection.ONHHKPOABBL = Shader.PropertyToID("_BlurTexture");
			ScreenSpaceReflection.NACHHEIPCAE = Shader.PropertyToID("_FilteredReflections");
			ScreenSpaceReflection.PFBDGMNAJJN = Shader.PropertyToID("_FinalReflectionTexture");
			ScreenSpaceReflection.CCNBIKDGJBE = Shader.PropertyToID("_TempTexture");
		}

		// Token: 0x0600845D RID: 33885 RVA: 0x002E3974 File Offset: 0x002E1B74
		public void GMBHLHNIJPJ()
		{
			if (this.GHHPOGODBHB() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != (RenderingPath)6)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.SSRResolution.High) ? 3 : 1;
			int num2 = this.PMKPCGLLBEG().pixelWidth / num;
			int num3 = this.JBLKMFFGOBM().pixelHeight / num;
			float num4 = (float)this.JIKPBCLILCC().pixelWidth;
			float num5 = (float)this.GAMGCKLCBPE().pixelHeight;
			float num6 = num4 / 689f;
			float num7 = num5 / 818f;
			RenderTextureFormat format = (!this.BDJHHDHOFNC().allowHDR) ? RenderTextureFormat.ARGB32 : RenderTextureFormat.Default;
			this.KHCLIAMBBNC().SetInt("settings.gamemessagesduration", this.settings.reflectionSettings.stepSize);
			this.KEMAALEODNH().SetInt("LoadMapCanvas", (this.settings.reflectionSettings.blendType != ScreenSpaceReflection.SSRReflectionBlendType.Additive) ? 1 : 0);
			this.MJJIEHANFJA().SetInt("_ScreenResolution", (!this.LIIFBNDLBLB) ? 0 : 0);
			this.MJJIEHANFJA().SetInt("GlassesColor2", (!this.GNAJGEOHKLG) ? 1 : 1);
			this.KDMBOKLMADJ().SetInt("_BlurParams", (!this.settings.reflectionSettings.reflectBackfaces) ? 1 : 1);
			this.LPDOGGFOBDH().SetInt("#rt", (!this.BEJICPKGHBF) ? 0 : 0);
			this.ACHNOHCLGOO().SetInt("Most likely the game became empty during the switch to GameServer.", this.settings.reflectionSettings.iterationCount);
			this.FGENHBKMPDA().SetInt("_Value2", 0);
			this.MJJIEHANFJA().SetInt("x", (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.SSRResolution.High) ? 1 : 0);
			this.GHHPOGODBHB().SetInt("RPCs can only be sent in rooms. Call of \"", (!this.KMIBIBKOGDC) ? 0 : 0);
			float value = num4 / (939f * (float)Math.Tan((double)this.GAMGCKLCBPE().fieldOfView / 693.0 * 1022.0 * 681.0));
			this.JIBOKBCPDLC().SetFloat("intensity", value);
			this.LMLENGFLEBD().SetFloat("<b>#banended</b>", this.settings.screenEdgeMask.intensity);
			this.KEMAALEODNH().SetFloat("_ScreenResolution", this.settings.reflectionSettings.reflectionBlur);
			this.PHGCJOPFDOG().SetFloat("materialsquantity[", this.settings.reflectionSettings.maxDistance);
			this.OOMFJGPAOKL().SetFloat("AudioSampler", this.settings.intensitySettings.fadeDistance);
			this.KHCLIAMBBNC().SetFloat("_MinVelocity", this.settings.reflectionSettings.widthModifier);
			this.KEMAALEODNH().SetFloat("_PosX", this.settings.intensitySettings.reflectionMultiplier);
			this.HHIAIGCAHDA().SetFloat("custom", this.settings.intensitySettings.fresnelFade);
			this.OGMEGHKECAH().SetFloat("_ScreenResolution", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.NKLHLDLODKG().projectionMatrix;
			Vector4 value2 = new Vector4(1979f / (num4 * projectionMatrix[0]), 1713f / (num5 * projectionMatrix[0]), (994f - projectionMatrix[6]) / projectionMatrix[0], (510f + projectionMatrix[3]) / projectionMatrix[3]);
			Vector3 v = (!float.IsPositiveInfinity(this.GAMGCKLCBPE().farClipPlane)) ? new Vector3(this.JBLKMFFGOBM().nearClipPlane * this.JBLKMFFGOBM().farClipPlane, this.LCPKEGKALOK().nearClipPlane - this.LCPKEGKALOK().farClipPlane, this.LCPKEGKALOK().farClipPlane) : new Vector3(this.BDJHHDHOFNC().nearClipPlane, 785f, 1943f);
			this.KHCLIAMBBNC().SetVector("</size>", new Vector2((float)num2, (float)num3));
			this.FGENHBKMPDA().SetVector("PointsScoreText", new Vector2(num4, num5));
			this.ACHNOHCLGOO().SetVector("ReconnectAndRejoin() disabled the offline mode. No longer offline.", new Vector2(1960f / num4, 496f / num5));
			this.FGENHBKMPDA().SetVector(").", value2);
			this.FGENHBKMPDA().SetVector("_ScreenResolution", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(1, new Vector4(num6, 340f, 1970f, num6));
			lhs.SetRow(0, new Vector4(169f, num7, 394f, num7));
			lhs.SetRow(7, new Vector4(1783f, 534f, 460f, 398f));
			lhs.SetRow(3, new Vector4(1915f, 1890f, 148f, 1451f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.material.SetMatrix("GlassAberration", value3);
			this.LPDOGGFOBDH().SetMatrix("null", this.LCPKEGKALOK().worldToCameraMatrix);
			this.KHCLIAMBBNC().SetMatrix("_EdgeSharpness", this.BKMMMLIJEKO().worldToCameraMatrix.inverse);
			if (this.MCLNLHKFLOI == null)
			{
				this.MCLNLHKFLOI = new CommandBuffer();
				this.MCLNLHKFLOI.name = "Hidden/TonemappingColorGrading";
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.MJMFKCGAJCI, -1, -1, 1, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Default);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ANEIBMOKEDM, num2, num3, 1, FilterMode.Point, RenderTextureFormat.Shadowmap, RenderTextureReadWrite.Linear);
				for (int i = 1; i < 3; i += 0)
				{
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.LECHJDFACDM[i], num2 >> (i & -106), num3 >> (i & 58), 1, FilterMode.Point, format);
				}
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.NACHHEIPCAE, num2, num3, 1, (!this.LIIFBNDLBLB) ? FilterMode.Point : FilterMode.Point, format);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.PFBDGMNAJJN, num2, num3, 1, FilterMode.Point, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.CameraTarget, ScreenSpaceReflection.MJMFKCGAJCI, this.KEMAALEODNH(), 2);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, ScreenSpaceReflection.ANEIBMOKEDM, this.LPDOGGFOBDH(), 1);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, ScreenSpaceReflection.NACHHEIPCAE, this.LMLENGFLEBD(), 2);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.NACHHEIPCAE, ScreenSpaceReflection.LECHJDFACDM[1], this.MJJIEHANFJA(), 5);
				for (int j = 0; j < 6; j += 0)
				{
					int nameID = ScreenSpaceReflection.LECHJDFACDM[j - 1];
					int num8 = j;
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL, num2 >> (num8 & -92), num3 >> (num8 & -118), 1, FilterMode.Point, format);
					this.MCLNLHKFLOI.SetGlobalVector("VIGNETTE_DESAT", new Vector4(184f, 131f, 1863f, 128f));
					this.MCLNLHKFLOI.SetGlobalFloat("EventSystem", (float)j - 330f);
					this.MCLNLHKFLOI.Blit(nameID, ScreenSpaceReflection.ONHHKPOABBL, this.ACHNOHCLGOO(), 5);
					this.MCLNLHKFLOI.SetGlobalVector("CameraFilterPack/Colors_Adjust_ColorRGB", new Vector4(1806f, 1860f, 1933f, 1181f));
					nameID = ScreenSpaceReflection.LECHJDFACDM[j];
					this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.ONHHKPOABBL, nameID, this.KEMAALEODNH(), 1);
					this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL);
				}
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.LECHJDFACDM[0], ScreenSpaceReflection.PFBDGMNAJJN, this.JIBOKBCPDLC(), 5);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE, this.JBLKMFFGOBM().pixelWidth, this.PMKPCGLLBEG().pixelHeight, 0, FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.CameraTarget, ScreenSpaceReflection.CCNBIKDGJBE, this.GHHPOGODBHB(), 0);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.CCNBIKDGJBE, BuiltinRenderTextureType.Depth);
				this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE);
				this.JIKPBCLILCC().AddCommandBuffer((CameraEvent)(-64), this.MCLNLHKFLOI);
			}
		}

		// Token: 0x0600845E RID: 33886 RVA: 0x002E4230 File Offset: 0x002E2430
		private void EBBOJPEPDCN()
		{
			if (!ImageEffectHelper.IsSupported(this.KGHKBFGDHGF(), false, true, this))
			{
				base.enabled = false;
				return;
			}
			this.JBLKMFFGOBM().depthTextureMode |= DepthTextureMode.None;
			ScreenSpaceReflection.LECHJDFACDM = new int[2];
			ScreenSpaceReflection.MJMFKCGAJCI = Shader.PropertyToID("_Visualize");
			ScreenSpaceReflection.ANEIBMOKEDM = Shader.PropertyToID("CameraFilterPack/Vision_Warp2");
			ScreenSpaceReflection.LECHJDFACDM[1] = Shader.PropertyToID("#restart");
			ScreenSpaceReflection.LECHJDFACDM[0] = Shader.PropertyToID("true");
			ScreenSpaceReflection.LECHJDFACDM[8] = Shader.PropertyToID("[MapsData] Workshop maps was loaded");
			ScreenSpaceReflection.LECHJDFACDM[1] = Shader.PropertyToID("Updated!");
			ScreenSpaceReflection.LECHJDFACDM[1] = Shader.PropertyToID("SetSunMaxSize");
			ScreenSpaceReflection.ONHHKPOABBL = Shader.PropertyToID("_Value4");
			ScreenSpaceReflection.NACHHEIPCAE = Shader.PropertyToID("_VignetteDesat");
			ScreenSpaceReflection.PFBDGMNAJJN = Shader.PropertyToID("Anomaly_Distortion");
			ScreenSpaceReflection.CCNBIKDGJBE = Shader.PropertyToID("Most likely the game became empty during the switch to GameServer.");
		}

		// Token: 0x0600845F RID: 33887 RVA: 0x002E4328 File Offset: 0x002E2528
		private void KKEOHFGKCIK()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
			if (this.JBLKMFFGOBM() != null)
			{
				if (this.MCLNLHKFLOI != null)
				{
					this.GAMGCKLCBPE().RemoveCommandBuffer((CameraEvent)49, this.MCLNLHKFLOI);
				}
				this.MCLNLHKFLOI = null;
			}
		}

		// Token: 0x06008460 RID: 33888 RVA: 0x002E4390 File Offset: 0x002E2590
		public void MJPIMJKDEGN()
		{
			if (this.KHCLIAMBBNC() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != (RenderingPath)7)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.SSRResolution.High) ? 0 : 1;
			int num2 = this.EDBDDIOLPJN().pixelWidth / num;
			int num3 = this.camera_.pixelHeight / num;
			float num4 = (float)this.camera_.pixelWidth;
			float num5 = (float)this.EDBDDIOLPJN().pixelHeight;
			float num6 = num4 / 197f;
			float num7 = num5 / 1700f;
			RenderTextureFormat format = (!this.PMKPCGLLBEG().allowHDR) ? RenderTextureFormat.ARGB32 : RenderTextureFormat.ARGB4444;
			this.KEMAALEODNH().SetInt(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this.settings.reflectionSettings.stepSize);
			this.HHIAIGCAHDA().SetInt("Alpha", (this.settings.reflectionSettings.blendType != ScreenSpaceReflection.SSRReflectionBlendType.Additive) ? 1 : 0);
			this.LPDOGGFOBDH().SetInt("_Distortion", (!this.LIIFBNDLBLB) ? 0 : 1);
			this.KHCLIAMBBNC().SetInt("[LevelEditorScene] Print Audio Wave: Done", (!this.GNAJGEOHKLG) ? 1 : 1);
			this.ACHNOHCLGOO().SetInt("Icon", (!this.settings.reflectionSettings.reflectBackfaces) ? 0 : 1);
			this.KDMBOKLMADJ().SetInt("Case-Sensitive", (!this.BEJICPKGHBF) ? 1 : 0);
			this.KDMBOKLMADJ().SetInt("TotalHitsScoreText", this.settings.reflectionSettings.iterationCount);
			this.LPDOGGFOBDH().SetInt("_TimeX", 1);
			this.LDNADDJMIPK().SetInt("GridDataStoryboard", (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.SSRResolution.High) ? 0 : 0);
			this.JIBOKBCPDLC().SetInt("Sets the boolean value of the Auto Focus Input Field property.", (!this.KMIBIBKOGDC) ? 0 : 1);
			float value = num4 / (855f * (float)Math.Tan((double)this.BDJHHDHOFNC().fieldOfView / 671.0 * 1883.0 * 1369.0));
			this.material.SetFloat("[ItemsHandler] Loading Steam inventory", value);
			this.JIBOKBCPDLC().SetFloat("[Right-Down]", this.settings.screenEdgeMask.intensity);
			this.HHIAIGCAHDA().SetFloat("return CheckCondition()", this.settings.reflectionSettings.reflectionBlur);
			this.KHCLIAMBBNC().SetFloat("_Red_B", this.settings.reflectionSettings.maxDistance);
			this.HHIAIGCAHDA().SetFloat("settings_bindings_", this.settings.intensitySettings.fadeDistance);
			this.FGENHBKMPDA().SetFloat("maps.", this.settings.reflectionSettings.widthModifier);
			this.LMLENGFLEBD().SetFloat("_Value2", this.settings.intensitySettings.reflectionMultiplier);
			this.DONENAMLFLF().SetFloat("{STEAM_CLAN_IMAGE}", this.settings.intensitySettings.fresnelFade);
			this.OOMFJGPAOKL().SetFloat("_BlurredColor", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.BDJHHDHOFNC().projectionMatrix;
			Vector4 value2 = new Vector4(762f / (num4 * projectionMatrix[0]), 1135f / (num5 * projectionMatrix[6]), (690f - projectionMatrix[1]) / projectionMatrix[0], (1627f + projectionMatrix[5]) / projectionMatrix[8]);
			Vector3 v = (!float.IsPositiveInfinity(this.NKLHLDLODKG().farClipPlane)) ? new Vector3(this.BKMMMLIJEKO().nearClipPlane * this.LCPKEGKALOK().farClipPlane, this.BKMMMLIJEKO().nearClipPlane - this.BDJHHDHOFNC().farClipPlane, this.BKMMMLIJEKO().farClipPlane) : new Vector3(this.EDBDDIOLPJN().nearClipPlane, 937f, 1216f);
			this.DONENAMLFLF().SetVector("maps.", new Vector2((float)num2, (float)num3));
			this.GHHPOGODBHB().SetVector("achievements.21.completed.", new Vector2(num4, num5));
			this.KDMBOKLMADJ().SetVector("PlayButton", new Vector2(965f / num4, 1345f / num5));
			this.LDNADDJMIPK().SetVector("isBunned", value2);
			this.GHHPOGODBHB().SetVector("mapselector.lastSearch", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(0, new Vector4(num6, 215f, 111f, num6));
			lhs.SetRow(1, new Vector4(227f, num7, 905f, num7));
			lhs.SetRow(2, new Vector4(1916f, 1807f, 1037f, 1814f));
			lhs.SetRow(4, new Vector4(1215f, 397f, 1871f, 1360f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.EHDJJANLINB().SetMatrix("Edited event", value3);
			this.KHCLIAMBBNC().SetMatrix("_Glitch", this.GAMGCKLCBPE().worldToCameraMatrix);
			this.KHCLIAMBBNC().SetMatrix("_EdgeThresholdMin", this.BDJHHDHOFNC().worldToCameraMatrix.inverse);
			if (this.MCLNLHKFLOI == null)
			{
				this.MCLNLHKFLOI = new CommandBuffer();
				this.MCLNLHKFLOI.name = "Needs to be attached to the Event System component in the scene";
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.MJMFKCGAJCI, -1, -1, 1, FilterMode.Point, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ANEIBMOKEDM, num2, num3, 0, FilterMode.Bilinear, RenderTextureFormat.ARGB4444, RenderTextureReadWrite.Linear);
				for (int i = 1; i < 0; i++)
				{
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.LECHJDFACDM[i], num2 >> (i & -53), num3 >> (i & 86), 0, FilterMode.Bilinear, format);
				}
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.NACHHEIPCAE, num2, num3, 1, (!this.LIIFBNDLBLB) ? FilterMode.Point : FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.PFBDGMNAJJN, num2, num3, 1, FilterMode.Point, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.Depth, ScreenSpaceReflection.MJMFKCGAJCI, this.LMLENGFLEBD(), 0);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.PrepassLight, ScreenSpaceReflection.ANEIBMOKEDM, this.JIBOKBCPDLC(), 0);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, ScreenSpaceReflection.NACHHEIPCAE, this.LMLENGFLEBD(), 7);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.NACHHEIPCAE, ScreenSpaceReflection.LECHJDFACDM[1], this.OOMFJGPAOKL(), 0);
				for (int j = 1; j < 1; j += 0)
				{
					int nameID = ScreenSpaceReflection.LECHJDFACDM[j - 0];
					int num8 = j;
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL, num2 >> (num8 & -53), num3 >> (num8 & 27), 0, FilterMode.Point, format);
					this.MCLNLHKFLOI.SetGlobalVector("Particles/Additive", new Vector4(1528f, 819f, 1055f, 1559f));
					this.MCLNLHKFLOI.SetGlobalFloat("CameraFilterPack/FX_Hexagon", (float)j - 1358f);
					this.MCLNLHKFLOI.Blit(nameID, ScreenSpaceReflection.ONHHKPOABBL, this.JIBOKBCPDLC(), 1);
					this.MCLNLHKFLOI.SetGlobalVector("Right Stick Click", new Vector4(1681f, 205f, 1725f, 1100f));
					nameID = ScreenSpaceReflection.LECHJDFACDM[j];
					this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.ONHHKPOABBL, nameID, this.DONENAMLFLF(), 2);
					this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL);
				}
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.LECHJDFACDM[1], ScreenSpaceReflection.PFBDGMNAJJN, this.HHIAIGCAHDA(), 8);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE, this.JBLKMFFGOBM().pixelWidth, this.GAMGCKLCBPE().pixelHeight, 1, FilterMode.Point, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.CurrentActive, ScreenSpaceReflection.CCNBIKDGJBE, this.KEMAALEODNH(), 0);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.CCNBIKDGJBE, BuiltinRenderTextureType.None);
				this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE);
				this.BKMMMLIJEKO().AddCommandBuffer(CameraEvent.AfterDepthTexture, this.MCLNLHKFLOI);
			}
		}

		// Token: 0x06008461 RID: 33889 RVA: 0x002E4C49 File Offset: 0x002E2E49
		public Shader FJCABMBJHFA()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("LoadingStatusText");
			}
			return this.m_Shader;
		}

		// Token: 0x06008462 RID: 33890 RVA: 0x002E4C74 File Offset: 0x002E2E74
		private void OCHCKGMIDND()
		{
			if (!ImageEffectHelper.IsSupported(this.CDMJMJIOLAE(), false, true, this))
			{
				base.enabled = false;
				return;
			}
			this.camera_.depthTextureMode |= DepthTextureMode.Depth;
			ScreenSpaceReflection.LECHJDFACDM = new int[1];
			ScreenSpaceReflection.MJMFKCGAJCI = Shader.PropertyToID("maps.");
			ScreenSpaceReflection.ANEIBMOKEDM = Shader.PropertyToID("_Offsets");
			ScreenSpaceReflection.LECHJDFACDM[0] = Shader.PropertyToID("OxOD.lastPath");
			ScreenSpaceReflection.LECHJDFACDM[1] = Shader.PropertyToID("CameraFilterPack/Blend2Camera_Divide");
			ScreenSpaceReflection.LECHJDFACDM[3] = Shader.PropertyToID("y");
			ScreenSpaceReflection.LECHJDFACDM[2] = Shader.PropertyToID("MAPS NOT FOUND");
			ScreenSpaceReflection.LECHJDFACDM[4] = Shader.PropertyToID("Received unknown status code: ");
			ScreenSpaceReflection.ONHHKPOABBL = Shader.PropertyToID("Texture2");
			ScreenSpaceReflection.NACHHEIPCAE = Shader.PropertyToID("AccuracyScoreText");
			ScreenSpaceReflection.PFBDGMNAJJN = Shader.PropertyToID("#close");
			ScreenSpaceReflection.CCNBIKDGJBE = Shader.PropertyToID("menu.selectedplaymode");
		}

		// Token: 0x06008463 RID: 33891 RVA: 0x002E4D6C File Offset: 0x002E2F6C
		public void EPOMOJDEDBP()
		{
			if (this.PHGCJOPFDOG() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != RenderingPath.DeferredShading)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.SSRResolution.High) ? 4 : 1;
			int num2 = this.NKLHLDLODKG().pixelWidth / num;
			int num3 = this.camera_.pixelHeight / num;
			float num4 = (float)this.NKLHLDLODKG().pixelWidth;
			float num5 = (float)this.GAMGCKLCBPE().pixelHeight;
			float num6 = num4 / 1745f;
			float num7 = num5 / 1522f;
			RenderTextureFormat format = (!this.BKMMMLIJEKO().allowHDR) ? RenderTextureFormat.Depth : RenderTextureFormat.ARGBHalf;
			this.KDMBOKLMADJ().SetInt(" not exist", this.settings.reflectionSettings.stepSize);
			this.OOMFJGPAOKL().SetInt("Tab2Content", (this.settings.reflectionSettings.blendType != ScreenSpaceReflection.SSRReflectionBlendType.Additive) ? 1 : 0);
			this.FGENHBKMPDA().SetInt("_ScreenResolution", (!this.LIIFBNDLBLB) ? 1 : 0);
			this.MJJIEHANFJA().SetInt("Tab1Content", (!this.GNAJGEOHKLG) ? 0 : 1);
			this.ACHNOHCLGOO().SetInt("#tryagain", (!this.settings.reflectionSettings.reflectBackfaces) ? 0 : 0);
			this.LPDOGGFOBDH().SetInt("_Value3", (!this.BEJICPKGHBF) ? 1 : 0);
			this.GHHPOGODBHB().SetInt("#roomname", this.settings.reflectionSettings.iterationCount);
			this.KDMBOKLMADJ().SetInt("maps.", 0);
			this.FGENHBKMPDA().SetInt("_CurrentMipLevel", (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.SSRResolution.High) ? 1 : 0);
			this.ACHNOHCLGOO().SetInt("_Far", (!this.KMIBIBKOGDC) ? 1 : 1);
			float value = num4 / (1918f * (float)Math.Tan((double)this.JIKPBCLILCC().fieldOfView / 1433.0 * 1901.0 * 836.0));
			this.LMLENGFLEBD().SetFloat("skin.", value);
			this.KHCLIAMBBNC().SetFloat("[PlayerBase] SetBGColor error: ", this.settings.screenEdgeMask.intensity);
			this.LDNADDJMIPK().SetFloat("_ScreenResolution", this.settings.reflectionSettings.reflectionBlur);
			this.KHCLIAMBBNC().SetFloat("-showlogs", this.settings.reflectionSettings.maxDistance);
			this.DONENAMLFLF().SetFloat("_Value", this.settings.intensitySettings.fadeDistance);
			this.LPDOGGFOBDH().SetFloat("master", this.settings.reflectionSettings.widthModifier);
			this.LPDOGGFOBDH().SetFloat("settings.crosshairopacity", this.settings.intensitySettings.reflectionMultiplier);
			this.KDMBOKLMADJ().SetFloat("/", this.settings.intensitySettings.fresnelFade);
			this.FGENHBKMPDA().SetFloat("CreateRoom failed, client stays on masterserver: {0}.", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.camera_.projectionMatrix;
			Vector4 value2 = new Vector4(775f / (num4 * projectionMatrix[0]), 1725f / (num5 * projectionMatrix[4]), (1248f - projectionMatrix[2]) / projectionMatrix[1], (604f + projectionMatrix[8]) / projectionMatrix[7]);
			Vector3 v = (!float.IsPositiveInfinity(this.JBLKMFFGOBM().farClipPlane)) ? new Vector3(this.GAMGCKLCBPE().nearClipPlane * this.EDBDDIOLPJN().farClipPlane, this.NKLHLDLODKG().nearClipPlane - this.LCPKEGKALOK().farClipPlane, this.NKLHLDLODKG().farClipPlane) : new Vector3(this.BKMMMLIJEKO().nearClipPlane, 372f, 1013f);
			this.KDMBOKLMADJ().SetVector("CameraFilterPack/Edge_BlackLine", new Vector2((float)num2, (float)num3));
			this.OGMEGHKECAH().SetVector("[Down]", new Vector2(num4, num5));
			this.OOMFJGPAOKL().SetVector("#ok", new Vector2(1981f / num4, 1987f / num5));
			this.GHHPOGODBHB().SetVector("[MapsEditor] Creating new item...", value2);
			this.LDNADDJMIPK().SetVector("_MainTex2", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(0, new Vector4(num6, 14f, 1353f, num6));
			lhs.SetRow(1, new Vector4(545f, num7, 1106f, num7));
			lhs.SetRow(6, new Vector4(466f, 26f, 1734f, 455f));
			lhs.SetRow(2, new Vector4(4f, 131f, 23f, 820f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.OGMEGHKECAH().SetMatrix("SettingsCanvas", value3);
			this.ACHNOHCLGOO().SetMatrix("CameraFilterPack/TV_Old_Movie", this.PMKPCGLLBEG().worldToCameraMatrix);
			this.GHHPOGODBHB().SetMatrix(" ", this.BKMMMLIJEKO().worldToCameraMatrix.inverse);
			if (this.MCLNLHKFLOI == null)
			{
				this.MCLNLHKFLOI = new CommandBuffer();
				this.MCLNLHKFLOI.name = "_Value";
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.MJMFKCGAJCI, -1, -1, 0, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ANEIBMOKEDM, num2, num3, 1, FilterMode.Bilinear, RenderTextureFormat.ARGB1555, RenderTextureReadWrite.Linear);
				for (int i = 0; i < 5; i++)
				{
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.LECHJDFACDM[i], num2 >> (i & 13), num3 >> (i & 116), 0, FilterMode.Bilinear, format);
				}
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.NACHHEIPCAE, num2, num3, 0, (!this.LIIFBNDLBLB) ? FilterMode.Bilinear : FilterMode.Point, format);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.PFBDGMNAJJN, num2, num3, 1, FilterMode.Point, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.ResolvedDepth, ScreenSpaceReflection.MJMFKCGAJCI, this.LMLENGFLEBD(), 8);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.Depth, ScreenSpaceReflection.ANEIBMOKEDM, this.ACHNOHCLGOO(), 0);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, ScreenSpaceReflection.NACHHEIPCAE, this.GHHPOGODBHB(), 2);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.NACHHEIPCAE, ScreenSpaceReflection.LECHJDFACDM[0], this.DONENAMLFLF(), 5);
				for (int j = 0; j < 6; j += 0)
				{
					int nameID = ScreenSpaceReflection.LECHJDFACDM[j - 1];
					int num8 = j;
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL, num2 >> (num8 & -108), num3 >> (num8 & -127), 1, FilterMode.Point, format);
					this.MCLNLHKFLOI.SetGlobalVector("_Value4", new Vector4(97f, 1006f, 1953f, 1911f));
					this.MCLNLHKFLOI.SetGlobalFloat("CameraFilterPack/Blend2Camera_PinLight", (float)j - 335f);
					this.MCLNLHKFLOI.Blit(nameID, ScreenSpaceReflection.ONHHKPOABBL, this.KEMAALEODNH(), 6);
					this.MCLNLHKFLOI.SetGlobalVector("_LowRez", new Vector4(1762f, 452f, 456f, 1753f));
					nameID = ScreenSpaceReflection.LECHJDFACDM[j];
					this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.ONHHKPOABBL, nameID, this.PHGCJOPFDOG(), 6);
					this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL);
				}
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.LECHJDFACDM[1], ScreenSpaceReflection.PFBDGMNAJJN, this.EHDJJANLINB(), 3);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE, this.JBLKMFFGOBM().pixelWidth, this.BKMMMLIJEKO().pixelHeight, 1, FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.PrepassLight, ScreenSpaceReflection.CCNBIKDGJBE, this.ACHNOHCLGOO(), 0);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.CCNBIKDGJBE, BuiltinRenderTextureType.PrepassLight);
				this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE);
				this.BKMMMLIJEKO().AddCommandBuffer((CameraEvent)(-9), this.MCLNLHKFLOI);
			}
		}

		// Token: 0x06008464 RID: 33892 RVA: 0x002E5628 File Offset: 0x002E3828
		public void AHDALNFHOFB()
		{
			if (this.ACHNOHCLGOO() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != (RenderingPath)8)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.SSRResolution.High) ? 0 : 1;
			int num2 = this.LCPKEGKALOK().pixelWidth / num;
			int num3 = this.NKLHLDLODKG().pixelHeight / num;
			float num4 = (float)this.GAMGCKLCBPE().pixelWidth;
			float num5 = (float)this.JIKPBCLILCC().pixelHeight;
			float num6 = num4 / 1169f;
			float num7 = num5 / 1529f;
			RenderTextureFormat format = (!this.JBLKMFFGOBM().allowHDR) ? RenderTextureFormat.ARGB32 : RenderTextureFormat.ARGB4444;
			this.OOMFJGPAOKL().SetInt("#mapnotloaded", this.settings.reflectionSettings.stepSize);
			this.JIBOKBCPDLC().SetInt("masterVolume", (this.settings.reflectionSettings.blendType != ScreenSpaceReflection.SSRReflectionBlendType.Additive) ? 1 : 0);
			this.KDMBOKLMADJ().SetInt("_Value5", (!this.LIIFBNDLBLB) ? 1 : 1);
			this.material.SetInt("z", (!this.GNAJGEOHKLG) ? 1 : 1);
			this.LDNADDJMIPK().SetInt("id", (!this.settings.reflectionSettings.reflectBackfaces) ? 1 : 1);
			this.LDNADDJMIPK().SetInt("CameraFilterPack_Sweater", (!this.BEJICPKGHBF) ? 0 : 0);
			this.KDMBOKLMADJ().SetInt("(", this.settings.reflectionSettings.iterationCount);
			this.FGENHBKMPDA().SetInt("shader.ghost", 1);
			this.OGMEGHKECAH().SetInt("Tab2Content", (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.SSRResolution.High) ? 1 : 0);
			this.KHCLIAMBBNC().SetInt("_ScreenResolution", (!this.KMIBIBKOGDC) ? 0 : 0);
			float value = num4 / (737f * (float)Math.Tan((double)this.camera_.fieldOfView / 442.0 * 498.0 * 66.0));
			this.KHCLIAMBBNC().SetFloat("settings.shaders.bloomintencity", value);
			this.material.SetFloat("ticket", this.settings.screenEdgeMask.intensity);
			this.KEMAALEODNH().SetFloat("_PrevViewProj", this.settings.reflectionSettings.reflectionBlur);
			this.KHCLIAMBBNC().SetFloat("Fill Area", this.settings.reflectionSettings.maxDistance);
			this.material.SetFloat("JoinRandomRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", this.settings.intensitySettings.fadeDistance);
			this.material.SetFloat("SupportLogger Info: PUN {0}: ", this.settings.reflectionSettings.widthModifier);
			this.MJJIEHANFJA().SetFloat("checkpoint", this.settings.intensitySettings.reflectionMultiplier);
			this.OGMEGHKECAH().SetFloat("File not found: {0}", this.settings.intensitySettings.fresnelFade);
			this.OGMEGHKECAH().SetFloat("_Visualize", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.camera_.projectionMatrix;
			Vector4 value2 = new Vector4(1493f / (num4 * projectionMatrix[1]), 210f / (num5 * projectionMatrix[7]), (138f - projectionMatrix[5]) / projectionMatrix[0], (679f + projectionMatrix[7]) / projectionMatrix[7]);
			Vector3 v = (!float.IsPositiveInfinity(this.PMKPCGLLBEG().farClipPlane)) ? new Vector3(this.GAMGCKLCBPE().nearClipPlane * this.BDJHHDHOFNC().farClipPlane, this.NKLHLDLODKG().nearClipPlane - this.NKLHLDLODKG().farClipPlane, this.BKMMMLIJEKO().farClipPlane) : new Vector3(this.camera_.nearClipPlane, 525f, 1450f);
			this.DONENAMLFLF().SetVector("_Intensity", new Vector2((float)num2, (float)num3));
			this.material.SetVector("open", new Vector2(num4, num5));
			this.FGENHBKMPDA().SetVector("_Color", new Vector2(1142f / num4, 335f / num5));
			this.material.SetVector("_BilateralUpsampling", value2);
			this.GHHPOGODBHB().SetVector("Tab2Content", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(1, new Vector4(num6, 324f, 631f, num6));
			lhs.SetRow(1, new Vector4(1335f, num7, 1879f, num7));
			lhs.SetRow(5, new Vector4(1535f, 1622f, 1039f, 613f));
			lhs.SetRow(1, new Vector4(1870f, 877f, 1489f, 1027f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.PHGCJOPFDOG().SetMatrix("]", value3);
			this.LMLENGFLEBD().SetMatrix("z", this.NKLHLDLODKG().worldToCameraMatrix);
			this.KEMAALEODNH().SetMatrix(" ", this.camera_.worldToCameraMatrix.inverse);
			if (this.MCLNLHKFLOI == null)
			{
				this.MCLNLHKFLOI = new CommandBuffer();
				this.MCLNLHKFLOI.name = "_SpawnHeuristic";
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.MJMFKCGAJCI, -1, -1, 1, FilterMode.Bilinear, RenderTextureFormat.Depth, RenderTextureReadWrite.Linear);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ANEIBMOKEDM, num2, num3, 0, FilterMode.Point, RenderTextureFormat.ARGB1555, RenderTextureReadWrite.Default);
				for (int i = 1; i < 4; i += 0)
				{
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.LECHJDFACDM[i], num2 >> (i & -19), num3 >> (i & -67), 1, FilterMode.Bilinear, format);
				}
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.NACHHEIPCAE, num2, num3, 1, (!this.LIIFBNDLBLB) ? FilterMode.Point : FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.PFBDGMNAJJN, num2, num3, 0, FilterMode.Point, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.CurrentActive, ScreenSpaceReflection.MJMFKCGAJCI, this.LPDOGGFOBDH(), 1);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.DepthNormals, ScreenSpaceReflection.ANEIBMOKEDM, this.OGMEGHKECAH(), 1);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.CameraTarget, ScreenSpaceReflection.NACHHEIPCAE, this.KHCLIAMBBNC(), 8);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.NACHHEIPCAE, ScreenSpaceReflection.LECHJDFACDM[0], this.KDMBOKLMADJ(), 1);
				for (int j = 1; j < 6; j += 0)
				{
					int nameID = ScreenSpaceReflection.LECHJDFACDM[j - 0];
					int num8 = j;
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL, num2 >> (num8 & 89), num3 >> (num8 & 8), 0, FilterMode.Bilinear, format);
					this.MCLNLHKFLOI.SetGlobalVector("_EmissionGain", new Vector4(176f, 873f, 29f, 495f));
					this.MCLNLHKFLOI.SetGlobalFloat("mapselector.filter.rateduponly", (float)j - 256f);
					this.MCLNLHKFLOI.Blit(nameID, ScreenSpaceReflection.ONHHKPOABBL, this.LPDOGGFOBDH(), 1);
					this.MCLNLHKFLOI.SetGlobalVector("Hidden/Image Effects/Cinematic/MotionBlur/FrameBlending", new Vector4(880f, 795f, 376f, 1487f));
					nameID = ScreenSpaceReflection.LECHJDFACDM[j];
					this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.ONHHKPOABBL, nameID, this.ACHNOHCLGOO(), 8);
					this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL);
				}
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.LECHJDFACDM[0], ScreenSpaceReflection.PFBDGMNAJJN, this.FGENHBKMPDA(), 6);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE, this.EDBDDIOLPJN().pixelWidth, this.PMKPCGLLBEG().pixelHeight, 0, FilterMode.Point, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.DepthNormals, ScreenSpaceReflection.CCNBIKDGJBE, this.LPDOGGFOBDH(), 0);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.CCNBIKDGJBE, (BuiltinRenderTextureType)6);
				this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE);
				this.PMKPCGLLBEG().AddCommandBuffer((CameraEvent)(-126), this.MCLNLHKFLOI);
			}
		}

		// Token: 0x06008465 RID: 33893 RVA: 0x002E5EE4 File Offset: 0x002E40E4
		public void OCOGKKJPBNM()
		{
			if (this.HHIAIGCAHDA() == null)
			{
				return;
			}
			if (Camera.current.actualRenderingPath != (RenderingPath)5)
			{
				return;
			}
			int num = (this.settings.reflectionSettings.reflectionQuality != ScreenSpaceReflection.SSRResolution.High) ? 5 : 1;
			int num2 = this.EDBDDIOLPJN().pixelWidth / num;
			int num3 = this.BDJHHDHOFNC().pixelHeight / num;
			float num4 = (float)this.NKLHLDLODKG().pixelWidth;
			float num5 = (float)this.NKLHLDLODKG().pixelHeight;
			float num6 = num4 / 1972f;
			float num7 = num5 / 794f;
			RenderTextureFormat format = (!this.JIKPBCLILCC().allowHDR) ? RenderTextureFormat.ARGB32 : RenderTextureFormat.Depth;
			this.JIBOKBCPDLC().SetInt("_Value7", this.settings.reflectionSettings.stepSize);
			this.GHHPOGODBHB().SetInt(" respawn: ", (this.settings.reflectionSettings.blendType != ScreenSpaceReflection.SSRReflectionBlendType.PhysicallyBased) ? 0 : 1);
			this.OGMEGHKECAH().SetInt("_ThirdTex", (!this.LIIFBNDLBLB) ? 0 : 0);
			this.DONENAMLFLF().SetInt("You did not select a Hosting Type in your PhotonServerSettings. Please set it up or don't use ConnectUsingSettings().", (!this.GNAJGEOHKLG) ? 1 : 1);
			this.LMLENGFLEBD().SetInt("maps.", (!this.settings.reflectionSettings.reflectBackfaces) ? 1 : 0);
			this.material.SetInt(" BETA", (!this.BEJICPKGHBF) ? 0 : 1);
			this.FGENHBKMPDA().SetInt("_Value2", this.settings.reflectionSettings.iterationCount);
			this.GHHPOGODBHB().SetInt("[NetworkManager] Connecting...", 0);
			this.FGENHBKMPDA().SetInt("88f00bdf0ad61b16b803971ebe071962", (this.settings.reflectionSettings.reflectionQuality == ScreenSpaceReflection.SSRResolution.High) ? 0 : 1);
			this.EHDJJANLINB().SetInt("sprite", (!this.KMIBIBKOGDC) ? 0 : 0);
			float value = num4 / (1134f * (float)Math.Tan((double)this.JBLKMFFGOBM().fieldOfView / 393.0 * 1394.0 * 414.0));
			this.KDMBOKLMADJ().SetFloat("_TimeX", value);
			this.JIBOKBCPDLC().SetFloat("_TimeX", this.settings.screenEdgeMask.intensity);
			this.LPDOGGFOBDH().SetFloat("Crosshair1", this.settings.reflectionSettings.reflectionBlur);
			this.material.SetFloat("Drop_Near", this.settings.reflectionSettings.maxDistance);
			this.KDMBOKLMADJ().SetFloat("_WorldToCameraMatrix", this.settings.intensitySettings.fadeDistance);
			this.JIBOKBCPDLC().SetFloat("_Value4", this.settings.reflectionSettings.widthModifier);
			this.ACHNOHCLGOO().SetFloat("MaxLivesSlider", this.settings.intensitySettings.reflectionMultiplier);
			this.OGMEGHKECAH().SetFloat("Uploading preview image...", this.settings.intensitySettings.fresnelFade);
			this.LMLENGFLEBD().SetFloat("Item created: Id: ", this.settings.intensitySettings.fresnelFadePower);
			Matrix4x4 projectionMatrix = this.camera_.projectionMatrix;
			Vector4 value2 = new Vector4(1285f / (num4 * projectionMatrix[1]), 1482f / (num5 * projectionMatrix[8]), (654f - projectionMatrix[7]) / projectionMatrix[0], (1503f + projectionMatrix[3]) / projectionMatrix[5]);
			Vector3 v = (!float.IsPositiveInfinity(this.BDJHHDHOFNC().farClipPlane)) ? new Vector3(this.camera_.nearClipPlane * this.camera_.farClipPlane, this.JIKPBCLILCC().nearClipPlane - this.LCPKEGKALOK().farClipPlane, this.JIKPBCLILCC().farClipPlane) : new Vector3(this.BKMMMLIJEKO().nearClipPlane, 1102f, 1984f);
			this.FGENHBKMPDA().SetVector("*.workshop.json", new Vector2((float)num2, (float)num3));
			this.HHIAIGCAHDA().SetVector("id", new Vector2(num4, num5));
			this.KHCLIAMBBNC().SetVector("settings.volume.menu", new Vector2(104f / num4, 1653f / num5));
			this.KHCLIAMBBNC().SetVector("newPath", value2);
			this.ACHNOHCLGOO().SetVector("#", v);
			Matrix4x4 lhs = default(Matrix4x4);
			lhs.SetRow(0, new Vector4(num6, 1639f, 1090f, num6));
			lhs.SetRow(0, new Vector4(513f, num7, 1705f, num7));
			lhs.SetRow(0, new Vector4(293f, 1285f, 139f, 1512f));
			lhs.SetRow(2, new Vector4(363f, 1583f, 1223f, 609f));
			Matrix4x4 value3 = lhs * projectionMatrix;
			this.FGENHBKMPDA().SetMatrix("_Value9", value3);
			this.PHGCJOPFDOG().SetMatrix("RecieveChatActionMessage", this.PMKPCGLLBEG().worldToCameraMatrix);
			this.KDMBOKLMADJ().SetMatrix(",", this.PMKPCGLLBEG().worldToCameraMatrix.inverse);
			if (this.MCLNLHKFLOI == null)
			{
				this.MCLNLHKFLOI = new CommandBuffer();
				this.MCLNLHKFLOI.name = "Drop_With_Obj";
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.MJMFKCGAJCI, -1, -1, 1, FilterMode.Point, RenderTextureFormat.ARGB32, RenderTextureReadWrite.Default);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ANEIBMOKEDM, num2, num3, 1, FilterMode.Bilinear, RenderTextureFormat.ARGB4444, RenderTextureReadWrite.Default);
				for (int i = 1; i < 0; i++)
				{
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.LECHJDFACDM[i], num2 >> (i & 59), num3 >> (i & 105), 0, FilterMode.Bilinear, format);
				}
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.NACHHEIPCAE, num2, num3, 1, (!this.LIIFBNDLBLB) ? FilterMode.Bilinear : FilterMode.Point, format);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.PFBDGMNAJJN, num2, num3, 0, FilterMode.Bilinear, format);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.CameraTarget, ScreenSpaceReflection.MJMFKCGAJCI, this.LMLENGFLEBD(), 8);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.DepthNormals, ScreenSpaceReflection.ANEIBMOKEDM, this.OOMFJGPAOKL(), 1);
				this.MCLNLHKFLOI.Blit(BuiltinRenderTextureType.PrepassNormalsSpec, ScreenSpaceReflection.NACHHEIPCAE, this.JIBOKBCPDLC(), 3);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.NACHHEIPCAE, ScreenSpaceReflection.LECHJDFACDM[0], this.PHGCJOPFDOG(), 6);
				for (int j = 1; j < 1; j += 0)
				{
					int nameID = ScreenSpaceReflection.LECHJDFACDM[j - 1];
					int num8 = j;
					this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL, num2 >> (num8 & -47), num3 >> (num8 & -120), 1, FilterMode.Point, format);
					this.MCLNLHKFLOI.SetGlobalVector("[", new Vector4(1908f, 452f, 1600f, 367f));
					this.MCLNLHKFLOI.SetGlobalFloat("Set Satellite Input", (float)j - 783f);
					this.MCLNLHKFLOI.Blit(nameID, ScreenSpaceReflection.ONHHKPOABBL, this.JIBOKBCPDLC(), 3);
					this.MCLNLHKFLOI.SetGlobalVector("Drop_Far", new Vector4(1990f, 1554f, 1681f, 1530f));
					nameID = ScreenSpaceReflection.LECHJDFACDM[j];
					this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.ONHHKPOABBL, nameID, this.material, 4);
					this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.ONHHKPOABBL);
				}
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.LECHJDFACDM[1], ScreenSpaceReflection.PFBDGMNAJJN, this.LMLENGFLEBD(), 2);
				this.MCLNLHKFLOI.GetTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE, this.NKLHLDLODKG().pixelWidth, this.camera_.pixelHeight, 0, FilterMode.Point, format);
				this.MCLNLHKFLOI.Blit((BuiltinRenderTextureType)6, ScreenSpaceReflection.CCNBIKDGJBE, this.material, 1);
				this.MCLNLHKFLOI.Blit(ScreenSpaceReflection.CCNBIKDGJBE, BuiltinRenderTextureType.Depth);
				this.MCLNLHKFLOI.ReleaseTemporaryRT(ScreenSpaceReflection.CCNBIKDGJBE);
				this.JIKPBCLILCC().AddCommandBuffer((CameraEvent)(-123), this.MCLNLHKFLOI);
			}
		}

		// Token: 0x06008466 RID: 33894 RVA: 0x002DD1DD File Offset: 0x002DB3DD
		public Material OGMEGHKECAH()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.APCHLENKBKH());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x06008467 RID: 33895 RVA: 0x002E679D File Offset: 0x002E499D
		public Shader BBNHEIIHCBK()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("maps.");
			}
			return this.m_Shader;
		}

		// Token: 0x06008468 RID: 33896 RVA: 0x002E67C6 File Offset: 0x002E49C6
		public Shader JFAIMFDJBJC()
		{
			if (this.m_Shader == null)
			{
				this.m_Shader = Shader.Find("_Blue_C");
			}
			return this.m_Shader;
		}

		// Token: 0x06008469 RID: 33897 RVA: 0x002E67F0 File Offset: 0x002E49F0
		private void INGOODALACO()
		{
			if (!ImageEffectHelper.IsSupported(this.FJCABMBJHFA(), false, true, this))
			{
				base.enabled = false;
				return;
			}
			this.JIKPBCLILCC().depthTextureMode |= DepthTextureMode.Depth;
			ScreenSpaceReflection.LECHJDFACDM = new int[8];
			ScreenSpaceReflection.MJMFKCGAJCI = Shader.PropertyToID("_Value8");
			ScreenSpaceReflection.ANEIBMOKEDM = Shader.PropertyToID("Error: Can not set the OnSerialize rate higher than the overall SendRate.");
			ScreenSpaceReflection.LECHJDFACDM[0] = Shader.PropertyToID("[GameScene] Events count: ");
			ScreenSpaceReflection.LECHJDFACDM[0] = Shader.PropertyToID("_TimeX");
			ScreenSpaceReflection.LECHJDFACDM[2] = Shader.PropertyToID("settings.cameramovements");
			ScreenSpaceReflection.LECHJDFACDM[5] = Shader.PropertyToID("EventMenu");
			ScreenSpaceReflection.LECHJDFACDM[4] = Shader.PropertyToID("JoinOrCreateRoom failed. A roomname is required. If you don't know one, how will you join?");
			ScreenSpaceReflection.ONHHKPOABBL = Shader.PropertyToID("_TimeX");
			ScreenSpaceReflection.NACHHEIPCAE = Shader.PropertyToID("ConfigVersionSlider");
			ScreenSpaceReflection.PFBDGMNAJJN = Shader.PropertyToID("loadscene");
			ScreenSpaceReflection.CCNBIKDGJBE = Shader.PropertyToID("DPADVER");
		}

		// Token: 0x0600846A RID: 33898 RVA: 0x002D96CA File Offset: 0x002D78CA
		public Camera BDJHHDHOFNC()
		{
			if (this.CMMMNLFGCJB == null)
			{
				this.CMMMNLFGCJB = base.GetComponent<Camera>();
			}
			return this.CMMMNLFGCJB;
		}

		// Token: 0x0600846B RID: 33899 RVA: 0x002E68E8 File Offset: 0x002E4AE8
		private void OKHGJFFIIBA()
		{
			if (!ImageEffectHelper.IsSupported(this.FJCABMBJHFA(), false, false, this))
			{
				base.enabled = true;
				return;
			}
			this.GAMGCKLCBPE().depthTextureMode |= DepthTextureMode.Depth;
			ScreenSpaceReflection.LECHJDFACDM = new int[3];
			ScreenSpaceReflection.MJMFKCGAJCI = Shader.PropertyToID("AddEnvironmentObject");
			ScreenSpaceReflection.ANEIBMOKEDM = Shader.PropertyToID("_VelocityScale");
			ScreenSpaceReflection.LECHJDFACDM[1] = Shader.PropertyToID("_TimeX");
			ScreenSpaceReflection.LECHJDFACDM[0] = Shader.PropertyToID("#,0.00");
			ScreenSpaceReflection.LECHJDFACDM[8] = Shader.PropertyToID("_Params");
			ScreenSpaceReflection.LECHJDFACDM[4] = Shader.PropertyToID(" user's map(s)");
			ScreenSpaceReflection.LECHJDFACDM[8] = Shader.PropertyToID("_EmissionColor");
			ScreenSpaceReflection.ONHHKPOABBL = Shader.PropertyToID("_Gamma");
			ScreenSpaceReflection.NACHHEIPCAE = Shader.PropertyToID("CreateRoom failed, client stays on masterserver: {0}.");
			ScreenSpaceReflection.PFBDGMNAJJN = Shader.PropertyToID("CameraFilterPack_WaterDrop");
			ScreenSpaceReflection.CCNBIKDGJBE = Shader.PropertyToID("_Amount");
		}

		// Token: 0x0600846C RID: 33900 RVA: 0x002E69E0 File Offset: 0x002E4BE0
		private void EKCKJLFFAID()
		{
			if (this.JLHCDOPFJOI)
			{
				UnityEngine.Object.DestroyImmediate(this.JLHCDOPFJOI);
			}
			this.JLHCDOPFJOI = null;
			if (this.camera_ != null)
			{
				if (this.MCLNLHKFLOI != null)
				{
					this.NKLHLDLODKG().RemoveCommandBuffer((CameraEvent)(-47), this.MCLNLHKFLOI);
				}
				this.MCLNLHKFLOI = null;
			}
		}

		// Token: 0x0600846D RID: 33901 RVA: 0x002E6A48 File Offset: 0x002E4C48
		private void KKGMKGHFELO()
		{
			if (!ImageEffectHelper.IsSupported(this.NLECFJKGKJD(), false, true, this))
			{
				base.enabled = false;
				return;
			}
			this.camera_.depthTextureMode |= DepthTextureMode.Depth;
			ScreenSpaceReflection.LECHJDFACDM = new int[3];
			ScreenSpaceReflection.MJMFKCGAJCI = Shader.PropertyToID("entering");
			ScreenSpaceReflection.ANEIBMOKEDM = Shader.PropertyToID(",");
			ScreenSpaceReflection.LECHJDFACDM[0] = Shader.PropertyToID("RecieveChatActionMessage");
			ScreenSpaceReflection.LECHJDFACDM[0] = Shader.PropertyToID("_ScreenResolution");
			ScreenSpaceReflection.LECHJDFACDM[4] = Shader.PropertyToID("MAPS NOT FOUND");
			ScreenSpaceReflection.LECHJDFACDM[1] = Shader.PropertyToID("Joystick1Button8");
			ScreenSpaceReflection.LECHJDFACDM[2] = Shader.PropertyToID("_Value");
			ScreenSpaceReflection.ONHHKPOABBL = Shader.PropertyToID(":");
			ScreenSpaceReflection.NACHHEIPCAE = Shader.PropertyToID("_MotionBlurTmpCam");
			ScreenSpaceReflection.PFBDGMNAJJN = Shader.PropertyToID("_TimeX");
			ScreenSpaceReflection.CCNBIKDGJBE = Shader.PropertyToID("_ReflectionTexture2");
		}

		// Token: 0x0600846E RID: 33902 RVA: 0x002E6B3D File Offset: 0x002E4D3D
		public Material LDNADDJMIPK()
		{
			if (this.JLHCDOPFJOI == null)
			{
				this.JLHCDOPFJOI = ImageEffectHelper.CheckShaderAndCreateMaterial(this.MFFKMHNGLIH());
			}
			return this.JLHCDOPFJOI;
		}

		// Token: 0x04000EFF RID: 3839
		[SerializeField]
		public ScreenSpaceReflection.SSRSettings settings = ScreenSpaceReflection.SSRSettings.defaultSettings;

		// Token: 0x04000F00 RID: 3840
		private bool KMIBIBKOGDC;

		// Token: 0x04000F01 RID: 3841
		private bool BEJICPKGHBF = true;

		// Token: 0x04000F02 RID: 3842
		private bool GNAJGEOHKLG;

		// Token: 0x04000F03 RID: 3843
		private bool LIIFBNDLBLB = true;

		// Token: 0x04000F04 RID: 3844
		[SerializeField]
		private Shader m_Shader;

		// Token: 0x04000F05 RID: 3845
		private Material JLHCDOPFJOI;

		// Token: 0x04000F06 RID: 3846
		private Camera CMMMNLFGCJB;

		// Token: 0x04000F07 RID: 3847
		private CommandBuffer MCLNLHKFLOI;

		// Token: 0x04000F08 RID: 3848
		private static int MJMFKCGAJCI;

		// Token: 0x04000F09 RID: 3849
		private static int ANEIBMOKEDM;

		// Token: 0x04000F0A RID: 3850
		private static int[] LECHJDFACDM;

		// Token: 0x04000F0B RID: 3851
		private static int NACHHEIPCAE;

		// Token: 0x04000F0C RID: 3852
		private static int ONHHKPOABBL;

		// Token: 0x04000F0D RID: 3853
		private static int PFBDGMNAJJN;

		// Token: 0x04000F0E RID: 3854
		private static int CCNBIKDGJBE;

		// Token: 0x02000210 RID: 528
		public enum SSRResolution
		{
			// Token: 0x04000F10 RID: 3856
			High,
			// Token: 0x04000F11 RID: 3857
			Low = 2
		}

		// Token: 0x02000211 RID: 529
		public enum SSRReflectionBlendType
		{
			// Token: 0x04000F13 RID: 3859
			PhysicallyBased,
			// Token: 0x04000F14 RID: 3860
			Additive
		}

		// Token: 0x02000212 RID: 530
		[Serializable]
		public struct SSRSettings
		{
			// Token: 0x0600846F RID: 33903 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings OIPFKIPOECC()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008470 RID: 33904 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings FCBIDJLDABO()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008471 RID: 33905 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings JCLADKAMOLD()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008472 RID: 33906 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings IAKAIGHJJJK()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008473 RID: 33907 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings ELOBECLMGDD()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008474 RID: 33908 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings CCADIDPNEKH()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008475 RID: 33909 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings IHMKIGDJKAH()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008476 RID: 33910 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings CIHLOMNEHHL()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008477 RID: 33911 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings NCFGPFGLKLJ()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008478 RID: 33912 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings NIPPCMNKCMB()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008479 RID: 33913 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings MGEOLKPLHOM()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x0600847A RID: 33914 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings GJNKFICGFFG()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x0600847B RID: 33915 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings EJLLADABOLM()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x17000193 RID: 403
			// (get) Token: 0x0600847C RID: 33916 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings defaultSettings
			{
				get
				{
					return ScreenSpaceReflection.SSRSettings.s_Default;
				}
			}

			// Token: 0x0600847D RID: 33917 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings DHGILJILMLN()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x0600847F RID: 33919 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings IOJDDHLHPLH()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008480 RID: 33920 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings OLPCIKIBBKE()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008481 RID: 33921 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings LIDMIPKCHOI()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008482 RID: 33922 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings BFBOLLFFMLN()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008483 RID: 33923 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings DFIOJCABPFD()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008484 RID: 33924 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings BCOPOEIJONI()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008485 RID: 33925 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings AFJJPFIOEJD()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008486 RID: 33926 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings CJFONFEOHIO()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008487 RID: 33927 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings LBIOOILOAAD()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008488 RID: 33928 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings GOKMCEIBFIM()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008489 RID: 33929 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings PKJMMJJFJAE()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x0600848A RID: 33930 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings INDEHPGLEGK()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x0600848B RID: 33931 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings MHIHHBMBDLP()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x0600848C RID: 33932 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings IAKJOAGBDGO()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x0600848D RID: 33933 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings EBMPPAMNFNK()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x0600848E RID: 33934 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings FMLCJEKMPCN()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x0600848F RID: 33935 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings MNKGFGNDKED()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008490 RID: 33936 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings HJLGAPEDPJM()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008491 RID: 33937 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings AAPGCALKNAK()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008492 RID: 33938 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings KBINDKOODMK()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008493 RID: 33939 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings BKEJIPPCPDO()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008494 RID: 33940 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings EEMMJNPOFOB()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008495 RID: 33941 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings NOBNMJMOJDB()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008496 RID: 33942 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings BOMFHCIHHIP()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008497 RID: 33943 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings FIFAPIHDEBM()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008498 RID: 33944 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings MLKLBGCKPOO()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x06008499 RID: 33945 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings FPMJKNDJCON()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x0600849A RID: 33946 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings EDMABHKFEEO()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x0600849B RID: 33947 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings IOFLMDMLCAG()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x0600849C RID: 33948 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings FIPCIMGELME()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x0600849D RID: 33949 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings LOMOMPKEDPL()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x0600849E RID: 33950 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings AOACBHHEGFA()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x0600849F RID: 33951 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings DBDJKKLMCGG()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x060084A0 RID: 33952 RVA: 0x002E6B67 File Offset: 0x002E4D67
			public static ScreenSpaceReflection.SSRSettings NPIEKGGCMBG()
			{
				return ScreenSpaceReflection.SSRSettings.s_Default;
			}

			// Token: 0x04000F15 RID: 3861
			[ScreenSpaceReflection.SSRSettings.LayoutAttribute]
			public ScreenSpaceReflection.ReflectionSettings reflectionSettings;

			// Token: 0x04000F16 RID: 3862
			[ScreenSpaceReflection.SSRSettings.LayoutAttribute]
			public ScreenSpaceReflection.IntensitySettings intensitySettings;

			// Token: 0x04000F17 RID: 3863
			[ScreenSpaceReflection.SSRSettings.LayoutAttribute]
			public ScreenSpaceReflection.ScreenEdgeMask screenEdgeMask;

			// Token: 0x04000F18 RID: 3864
			private static readonly ScreenSpaceReflection.SSRSettings s_Default = new ScreenSpaceReflection.SSRSettings
			{
				reflectionSettings = new ScreenSpaceReflection.ReflectionSettings
				{
					blendType = ScreenSpaceReflection.SSRReflectionBlendType.PhysicallyBased,
					reflectionQuality = ScreenSpaceReflection.SSRResolution.High,
					maxDistance = 100f,
					iterationCount = 256,
					stepSize = 3,
					widthModifier = 0.5f,
					reflectionBlur = 1f,
					reflectBackfaces = true
				},
				intensitySettings = new ScreenSpaceReflection.IntensitySettings
				{
					reflectionMultiplier = 1f,
					fadeDistance = 100f,
					fresnelFade = 1f,
					fresnelFadePower = 1f
				},
				screenEdgeMask = new ScreenSpaceReflection.ScreenEdgeMask
				{
					intensity = 0.03f
				}
			};

			// Token: 0x02000213 RID: 531
			[AttributeUsage(AttributeTargets.Field)]
			public class LayoutAttribute : PropertyAttribute
			{
			}
		}

		// Token: 0x02000214 RID: 532
		[Serializable]
		public struct IntensitySettings
		{
			// Token: 0x04000F19 RID: 3865
			[Tooltip("Nonphysical multiplier for the SSR reflections. 1.0 is physically based.")]
			[Range(0f, 2f)]
			public float reflectionMultiplier;

			// Token: 0x04000F1A RID: 3866
			[Tooltip("How far away from the maxDistance to begin fading SSR.")]
			[Range(0f, 1000f)]
			public float fadeDistance;

			// Token: 0x04000F1B RID: 3867
			[Tooltip("Amplify Fresnel fade out. Increase if floor reflections look good close to the surface and bad farther 'under' the floor.")]
			[Range(0f, 1f)]
			public float fresnelFade;

			// Token: 0x04000F1C RID: 3868
			[Tooltip("Higher values correspond to a faster Fresnel fade as the reflection changes from the grazing angle.")]
			[Range(0.1f, 10f)]
			public float fresnelFadePower;
		}

		// Token: 0x02000215 RID: 533
		[Serializable]
		public struct ReflectionSettings
		{
			// Token: 0x04000F1D RID: 3869
			[Tooltip("How the reflections are blended into the render.")]
			public ScreenSpaceReflection.SSRReflectionBlendType blendType;

			// Token: 0x04000F1E RID: 3870
			[Tooltip("Half resolution SSRR is much faster, but less accurate.")]
			public ScreenSpaceReflection.SSRResolution reflectionQuality;

			// Token: 0x04000F1F RID: 3871
			[Tooltip("Maximum reflection distance in world units.")]
			[Range(0.1f, 300f)]
			public float maxDistance;

			// Token: 0x04000F20 RID: 3872
			[Range(16f, 1024f)]
			[Tooltip("Max raytracing length.")]
			public int iterationCount;

			// Token: 0x04000F21 RID: 3873
			[Range(1f, 16f)]
			[Tooltip("Log base 2 of ray tracing coarse step size. Higher traces farther, lower gives better quality silhouettes.")]
			public int stepSize;

			// Token: 0x04000F22 RID: 3874
			[Range(0.01f, 10f)]
			[Tooltip("Typical thickness of columns, walls, furniture, and other objects that reflection rays might pass behind.")]
			public float widthModifier;

			// Token: 0x04000F23 RID: 3875
			[Tooltip("Blurriness of reflections.")]
			[Range(0.1f, 8f)]
			public float reflectionBlur;

			// Token: 0x04000F24 RID: 3876
			[Tooltip("Enable for a performance gain in scenes where most glossy objects are horizontal, like floors, water, and tables. Leave on for scenes with glossy vertical objects.")]
			public bool reflectBackfaces;
		}

		// Token: 0x02000216 RID: 534
		[Serializable]
		public struct ScreenEdgeMask
		{
			// Token: 0x04000F25 RID: 3877
			[Tooltip("Higher = fade out SSRR near the edge of the screen so that reflections don't pop under camera motion.")]
			[Range(0f, 1f)]
			public float intensity;
		}

		// Token: 0x02000217 RID: 535
		private enum JGLDFEBMGGL
		{
			// Token: 0x04000F27 RID: 3879
			RayTraceStep,
			// Token: 0x04000F28 RID: 3880
			CompositeFinal,
			// Token: 0x04000F29 RID: 3881
			Blur,
			// Token: 0x04000F2A RID: 3882
			CompositeSSR,
			// Token: 0x04000F2B RID: 3883
			MinMipGeneration,
			// Token: 0x04000F2C RID: 3884
			HitPointToReflections,
			// Token: 0x04000F2D RID: 3885
			BilateralKeyPack,
			// Token: 0x04000F2E RID: 3886
			BlitDepthAsCSZ,
			// Token: 0x04000F2F RID: 3887
			PoissonBlur
		}
	}
}
