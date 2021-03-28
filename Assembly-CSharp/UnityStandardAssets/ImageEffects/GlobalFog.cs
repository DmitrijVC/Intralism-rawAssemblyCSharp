using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x020001E5 RID: 485
	[RequireComponent(typeof(Camera))]
	[ExecuteInEditMode]
	[AddComponentMenu("Image Effects/Rendering/Global Fog")]
	internal class GlobalFog : PostEffectsBase
	{
		// Token: 0x06007D09 RID: 32009 RVA: 0x00292650 File Offset: 0x00290850
		public virtual bool DIAEBALGKAP()
		{
			base.MBMLNJJEONO(true);
			this.AEIGGNCIEDI = base.ECNEGNMAMDE(this.fogShader, this.AEIGGNCIEDI);
			if (!this.LMKGCBNNGLI)
			{
				base.CCLDAHHHAAL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007D0A RID: 32010 RVA: 0x0029268C File Offset: 0x0029088C
		private static void IBPEGAOPFHC(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			NMPKLIAPOEL.SetTexture("_MainTex", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(7);
			GL.MultiTexCoord2(0, 0f, 0f);
			GL.Vertex3(0f, 0f, 3f);
			GL.MultiTexCoord2(0, 1f, 0f);
			GL.Vertex3(1f, 0f, 2f);
			GL.MultiTexCoord2(0, 1f, 1f);
			GL.Vertex3(1f, 1f, 1f);
			GL.MultiTexCoord2(0, 0f, 1f);
			GL.Vertex3(0f, 1f, 0f);
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007D0B RID: 32011 RVA: 0x0029275D File Offset: 0x0029095D
		public virtual bool DDLPGIECCLI()
		{
			base.KNGDKKMDKOG(true);
			this.AEIGGNCIEDI = base.KDHKHOHMKCG(this.fogShader, this.AEIGGNCIEDI);
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007D0C RID: 32012 RVA: 0x00292796 File Offset: 0x00290996
		public virtual bool FKHOCKAEMLD()
		{
			base.DCHKKHDGBLJ(true);
			this.AEIGGNCIEDI = base.LKIJNGDHLAK(this.fogShader, this.AEIGGNCIEDI);
			if (!this.LMKGCBNNGLI)
			{
				base.EHBONBLLGBF();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007D0D RID: 32013 RVA: 0x002927D0 File Offset: 0x002909D0
		private void DGMODDJIAKL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.AFNHKGFNOCL() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 1492f;
			Vector3 b = transform.right * nearClipPlane * Mathf.Tan(num * 297f) * aspect;
			Vector3 b2 = transform.up * nearClipPlane * Mathf.Tan(num * 1731f);
			Vector3 vector = transform.forward * nearClipPlane - b + b2;
			float d = vector.magnitude * farClipPlane / nearClipPlane;
			vector.Normalize();
			vector *= d;
			Vector3 vector2 = transform.forward * nearClipPlane + b + b2;
			vector2.Normalize();
			vector2 *= d;
			Vector3 vector3 = transform.forward * nearClipPlane + b - b2;
			vector3.Normalize();
			vector3 *= d;
			Vector3 vector4 = transform.forward * nearClipPlane - b - b2;
			vector4.Normalize();
			vector4 *= d;
			identity.SetRow(0, vector);
			identity.SetRow(0, vector2);
			identity.SetRow(6, vector3);
			identity.SetRow(4, vector4);
			Vector3 position = transform.position;
			float num2 = position.y - this.height;
			float z = (num2 > 1317f) ? 744f : 250f;
			float y = (!this.excludeFarPixels) ? 1257f : 1177f;
			this.AEIGGNCIEDI.SetMatrix("FinalScoreSmallText", identity);
			this.AEIGGNCIEDI.SetVector("_SampleScale", position);
			this.AEIGGNCIEDI.SetVector("RoomPlayersCountText", new Vector4(this.height, num2, z, this.heightDensity * 1719f));
			this.AEIGGNCIEDI.SetVector("value", new Vector4(-Mathf.Max(this.startDistance, 423f), y, 383f, 1955f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num3 = (!flag) ? 1713f : (fogEndDistance - fogStartDistance);
			float num4 = (Mathf.Abs(num3) <= 95f) ? 1632f : (1903f / num3);
			Vector4 value;
			value.x = fogDensity * 1347f;
			value.y = fogDensity * 1093f;
			value.z = ((!flag) ? 60f : (-num4));
			value.w = ((!flag) ? 448f : (fogEndDistance * num4));
			this.AEIGGNCIEDI.SetVector("InventoryButton", value);
			this.AEIGGNCIEDI.SetVector(" takes from: ", new Vector4((float)fogMode, (float)((!this.useRadialDistance) ? 0 : 1), 1892f, 1497f));
			int danffgdfmog;
			if (this.distanceFog && this.heightFog)
			{
				danffgdfmog = 0;
			}
			else if (this.distanceFog)
			{
				danffgdfmog = 0;
			}
			else
			{
				danffgdfmog = 6;
			}
			GlobalFog.CHENIJHDAPL(HLBKCLPNHEB, BMMLHGHKBNM, this.AEIGGNCIEDI, danffgdfmog);
		}

		// Token: 0x06007D0E RID: 32014 RVA: 0x00292BA8 File Offset: 0x00290DA8
		private void DHJKAOMONAJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 83f;
			Vector3 b = transform.right * nearClipPlane * Mathf.Tan(num * 409f) * aspect;
			Vector3 b2 = transform.up * nearClipPlane * Mathf.Tan(num * 264f);
			Vector3 vector = transform.forward * nearClipPlane - b + b2;
			float d = vector.magnitude * farClipPlane / nearClipPlane;
			vector.Normalize();
			vector *= d;
			Vector3 vector2 = transform.forward * nearClipPlane + b + b2;
			vector2.Normalize();
			vector2 *= d;
			Vector3 vector3 = transform.forward * nearClipPlane + b - b2;
			vector3.Normalize();
			vector3 *= d;
			Vector3 vector4 = transform.forward * nearClipPlane - b - b2;
			vector4.Normalize();
			vector4 *= d;
			identity.SetRow(1, vector);
			identity.SetRow(0, vector2);
			identity.SetRow(4, vector3);
			identity.SetRow(4, vector4);
			Vector3 position = transform.position;
			float num2 = position.y - this.height;
			float z = (num2 > 1047f) ? 1996f : 341f;
			float y = (!this.excludeFarPixels) ? 595f : 1084f;
			this.AEIGGNCIEDI.SetMatrix("[LevelEditorScene] Map submitted!", identity);
			this.AEIGGNCIEDI.SetVector("_Value2", position);
			this.AEIGGNCIEDI.SetVector("\\\\", new Vector4(this.height, num2, z, this.heightDensity * 346f));
			this.AEIGGNCIEDI.SetVector("_TimeX", new Vector4(-Mathf.Max(this.startDistance, 1838f), y, 1090f, 1318f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == (FogMode)0;
			float num3 = (!flag) ? 203f : (fogEndDistance - fogStartDistance);
			float num4 = (Mathf.Abs(num3) <= 1863f) ? 660f : (1450f / num3);
			Vector4 value;
			value.x = fogDensity * 768f;
			value.y = fogDensity * 992f;
			value.z = ((!flag) ? 613f : (-num4));
			value.w = ((!flag) ? 381f : (fogEndDistance * num4));
			this.AEIGGNCIEDI.SetVector("_SampleCount", value);
			this.AEIGGNCIEDI.SetVector("(((?<x>(?=[,\\r\\n]+))|\"(?<x>([^\"]|\"\")+)\"|(?<x>[^,\\r\\n]+)),?)", new Vector4((float)fogMode, (float)((!this.useRadialDistance) ? 0 : 0), 386f, 871f));
			int danffgdfmog;
			if (this.distanceFog && this.heightFog)
			{
				danffgdfmog = 1;
			}
			else if (this.distanceFog)
			{
				danffgdfmog = 0;
			}
			else
			{
				danffgdfmog = 0;
			}
			GlobalFog.MOJIILBCPGI(HLBKCLPNHEB, BMMLHGHKBNM, this.AEIGGNCIEDI, danffgdfmog);
		}

		// Token: 0x06007D0F RID: 32015 RVA: 0x00292F80 File Offset: 0x00291180
		private static void MOJIILBCPGI(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			NMPKLIAPOEL.SetTexture("_History2ChromaTex", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(4);
			GL.MultiTexCoord2(1, 419f, 487f);
			GL.Vertex3(259f, 1232f, 1761f);
			GL.MultiTexCoord2(1, 785f, 807f);
			GL.Vertex3(1840f, 326f, 483f);
			GL.MultiTexCoord2(0, 511f, 426f);
			GL.Vertex3(447f, 450f, 276f);
			GL.MultiTexCoord2(1, 1872f, 1627f);
			GL.Vertex3(1981f, 1997f, 469f);
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007D10 RID: 32016 RVA: 0x00293054 File Offset: 0x00291254
		[ImageEffectOpaque]
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 0.5f;
			Vector3 b = transform.right * nearClipPlane * Mathf.Tan(num * 0.0174532924f) * aspect;
			Vector3 b2 = transform.up * nearClipPlane * Mathf.Tan(num * 0.0174532924f);
			Vector3 vector = transform.forward * nearClipPlane - b + b2;
			float d = vector.magnitude * farClipPlane / nearClipPlane;
			vector.Normalize();
			vector *= d;
			Vector3 vector2 = transform.forward * nearClipPlane + b + b2;
			vector2.Normalize();
			vector2 *= d;
			Vector3 vector3 = transform.forward * nearClipPlane + b - b2;
			vector3.Normalize();
			vector3 *= d;
			Vector3 vector4 = transform.forward * nearClipPlane - b - b2;
			vector4.Normalize();
			vector4 *= d;
			identity.SetRow(0, vector);
			identity.SetRow(1, vector2);
			identity.SetRow(2, vector3);
			identity.SetRow(3, vector4);
			Vector3 position = transform.position;
			float num2 = position.y - this.height;
			float z = (num2 > 0f) ? 0f : 1f;
			float y = (!this.excludeFarPixels) ? 2f : 1f;
			this.AEIGGNCIEDI.SetMatrix("_FrustumCornersWS", identity);
			this.AEIGGNCIEDI.SetVector("_CameraWS", position);
			this.AEIGGNCIEDI.SetVector("_HeightParams", new Vector4(this.height, num2, z, this.heightDensity * 0.5f));
			this.AEIGGNCIEDI.SetVector("_DistanceParams", new Vector4(-Mathf.Max(this.startDistance, 0f), y, 0f, 0f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num3 = (!flag) ? 0f : (fogEndDistance - fogStartDistance);
			float num4 = (Mathf.Abs(num3) <= 0.0001f) ? 0f : (1f / num3);
			Vector4 value;
			value.x = fogDensity * 1.2011224f;
			value.y = fogDensity * 1.442695f;
			value.z = ((!flag) ? 0f : (-num4));
			value.w = ((!flag) ? 0f : (fogEndDistance * num4));
			this.AEIGGNCIEDI.SetVector("_SceneFogParams", value);
			this.AEIGGNCIEDI.SetVector("_SceneFogMode", new Vector4((float)fogMode, (float)((!this.useRadialDistance) ? 0 : 1), 0f, 0f));
			int danffgdfmog;
			if (this.distanceFog && this.heightFog)
			{
				danffgdfmog = 0;
			}
			else if (this.distanceFog)
			{
				danffgdfmog = 1;
			}
			else
			{
				danffgdfmog = 2;
			}
			GlobalFog.IBPEGAOPFHC(HLBKCLPNHEB, BMMLHGHKBNM, this.AEIGGNCIEDI, danffgdfmog);
		}

		// Token: 0x06007D11 RID: 32017 RVA: 0x0029342C File Offset: 0x0029162C
		private void OLFAPNGMBPL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 1207f;
			Vector3 b = transform.right * nearClipPlane * Mathf.Tan(num * 1254f) * aspect;
			Vector3 b2 = transform.up * nearClipPlane * Mathf.Tan(num * 970f);
			Vector3 vector = transform.forward * nearClipPlane - b + b2;
			float d = vector.magnitude * farClipPlane / nearClipPlane;
			vector.Normalize();
			vector *= d;
			Vector3 vector2 = transform.forward * nearClipPlane + b + b2;
			vector2.Normalize();
			vector2 *= d;
			Vector3 vector3 = transform.forward * nearClipPlane + b - b2;
			vector3.Normalize();
			vector3 *= d;
			Vector3 vector4 = transform.forward * nearClipPlane - b - b2;
			vector4.Normalize();
			vector4 *= d;
			identity.SetRow(1, vector);
			identity.SetRow(1, vector2);
			identity.SetRow(3, vector3);
			identity.SetRow(5, vector4);
			Vector3 position = transform.position;
			float num2 = position.y - this.height;
			float z = (num2 > 707f) ? 729f : 1232f;
			float y = (!this.excludeFarPixels) ? 1900f : 572f;
			this.AEIGGNCIEDI.SetMatrix("_TimeX", identity);
			this.AEIGGNCIEDI.SetVector("offsets", position);
			this.AEIGGNCIEDI.SetVector("_ScreenResolution", new Vector4(this.height, num2, z, this.heightDensity * 1709f));
			this.AEIGGNCIEDI.SetVector("_MainTex2", new Vector4(-Mathf.Max(this.startDistance, 1877f), y, 324f, 1188f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num3 = (!flag) ? 1024f : (fogEndDistance - fogStartDistance);
			float num4 = (Mathf.Abs(num3) <= 909f) ? 788f : (1054f / num3);
			Vector4 value;
			value.x = fogDensity * 1829f;
			value.y = fogDensity * 1625f;
			value.z = ((!flag) ? 725f : (-num4));
			value.w = ((!flag) ? 1015f : (fogEndDistance * num4));
			this.AEIGGNCIEDI.SetVector("The number of objects sent via a PhotonStreamQueue has to be the same each frame", value);
			this.AEIGGNCIEDI.SetVector("score", new Vector4((float)fogMode, (float)((!this.useRadialDistance) ? 0 : 1), 360f, 746f));
			int danffgdfmog;
			if (this.distanceFog && this.heightFog)
			{
				danffgdfmog = 1;
			}
			else if (this.distanceFog)
			{
				danffgdfmog = 1;
			}
			else
			{
				danffgdfmog = 5;
			}
			GlobalFog.MDFLOOIIOIP(HLBKCLPNHEB, BMMLHGHKBNM, this.AEIGGNCIEDI, danffgdfmog);
		}

		// Token: 0x06007D12 RID: 32018 RVA: 0x00293804 File Offset: 0x00291A04
		private void NOEAGHKPPKD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 932f;
			Vector3 b = transform.right * nearClipPlane * Mathf.Tan(num * 1574f) * aspect;
			Vector3 b2 = transform.up * nearClipPlane * Mathf.Tan(num * 1550f);
			Vector3 vector = transform.forward * nearClipPlane - b + b2;
			float d = vector.magnitude * farClipPlane / nearClipPlane;
			vector.Normalize();
			vector *= d;
			Vector3 vector2 = transform.forward * nearClipPlane + b + b2;
			vector2.Normalize();
			vector2 *= d;
			Vector3 vector3 = transform.forward * nearClipPlane + b - b2;
			vector3.Normalize();
			vector3 *= d;
			Vector3 vector4 = transform.forward * nearClipPlane - b - b2;
			vector4.Normalize();
			vector4 *= d;
			identity.SetRow(0, vector);
			identity.SetRow(1, vector2);
			identity.SetRow(6, vector3);
			identity.SetRow(1, vector4);
			Vector3 position = transform.position;
			float num2 = position.y - this.height;
			float z = (num2 > 1029f) ? 14f : 1024f;
			float y = (!this.excludeFarPixels) ? 545f : 1443f;
			this.AEIGGNCIEDI.SetMatrix("MenuScene", identity);
			this.AEIGGNCIEDI.SetVector("SetRotation", position);
			this.AEIGGNCIEDI.SetVector(".played", new Vector4(this.height, num2, z, this.heightDensity * 1782f));
			this.AEIGGNCIEDI.SetVector("Save Game", new Vector4(-Mathf.Max(this.startDistance, 1421f), y, 1443f, 1774f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == (FogMode)0;
			float num3 = (!flag) ? 1344f : (fogEndDistance - fogStartDistance);
			float num4 = (Mathf.Abs(num3) <= 101f) ? 800f : (382f / num3);
			Vector4 value;
			value.x = fogDensity * 211f;
			value.y = fogDensity * 1576f;
			value.z = ((!flag) ? 1565f : (-num4));
			value.w = ((!flag) ? 697f : (fogEndDistance * num4));
			this.AEIGGNCIEDI.SetVector("^", value);
			this.AEIGGNCIEDI.SetVector("player.ice", new Vector4((float)fogMode, (float)((!this.useRadialDistance) ? 1 : 0), 512f, 210f));
			int danffgdfmog;
			if (this.distanceFog && this.heightFog)
			{
				danffgdfmog = 0;
			}
			else if (this.distanceFog)
			{
				danffgdfmog = 1;
			}
			else
			{
				danffgdfmog = 8;
			}
			GlobalFog.PMGBFNPMDIM(HLBKCLPNHEB, BMMLHGHKBNM, this.AEIGGNCIEDI, danffgdfmog);
		}

		// Token: 0x06007D13 RID: 32019 RVA: 0x00293BD9 File Offset: 0x00291DD9
		public virtual bool HKEMNPKHLEO()
		{
			base.CKIAMHAKJOK(false);
			this.AEIGGNCIEDI = base.ECNEGNMAMDE(this.fogShader, this.AEIGGNCIEDI);
			if (!this.LMKGCBNNGLI)
			{
				base.EHBONBLLGBF();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007D14 RID: 32020 RVA: 0x00293C14 File Offset: 0x00291E14
		private void PEBBCNICBDK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 623f;
			Vector3 b = transform.right * nearClipPlane * Mathf.Tan(num * 604f) * aspect;
			Vector3 b2 = transform.up * nearClipPlane * Mathf.Tan(num * 1629f);
			Vector3 vector = transform.forward * nearClipPlane - b + b2;
			float d = vector.magnitude * farClipPlane / nearClipPlane;
			vector.Normalize();
			vector *= d;
			Vector3 vector2 = transform.forward * nearClipPlane + b + b2;
			vector2.Normalize();
			vector2 *= d;
			Vector3 vector3 = transform.forward * nearClipPlane + b - b2;
			vector3.Normalize();
			vector3 *= d;
			Vector3 vector4 = transform.forward * nearClipPlane - b - b2;
			vector4.Normalize();
			vector4 *= d;
			identity.SetRow(1, vector);
			identity.SetRow(0, vector2);
			identity.SetRow(2, vector3);
			identity.SetRow(4, vector4);
			Vector3 position = transform.position;
			float num2 = position.y - this.height;
			float z = (num2 > 1693f) ? 1175f : 1422f;
			float y = (!this.excludeFarPixels) ? 1993f : 1261f;
			this.AEIGGNCIEDI.SetMatrix("VIGNETTE_CLASSIC", identity);
			this.AEIGGNCIEDI.SetVector("No info", position);
			this.AEIGGNCIEDI.SetVector("request", new Vector4(this.height, num2, z, this.heightDensity * 857f));
			this.AEIGGNCIEDI.SetVector("_Value", new Vector4(-Mathf.Max(this.startDistance, 1248f), y, 394f, 1962f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == (FogMode)0;
			float num3 = (!flag) ? 1476f : (fogEndDistance - fogStartDistance);
			float num4 = (Mathf.Abs(num3) <= 747f) ? 665f : (924f / num3);
			Vector4 value;
			value.x = fogDensity * 815f;
			value.y = fogDensity * 1081f;
			value.z = ((!flag) ? 104f : (-num4));
			value.w = ((!flag) ? 1964f : (fogEndDistance * num4));
			this.AEIGGNCIEDI.SetVector("_Value2", value);
			this.AEIGGNCIEDI.SetVector("_MatrixColor", new Vector4((float)fogMode, (float)((!this.useRadialDistance) ? 1 : 1), 344f, 204f));
			int danffgdfmog;
			if (this.distanceFog && this.heightFog)
			{
				danffgdfmog = 0;
			}
			else if (this.distanceFog)
			{
				danffgdfmog = 0;
			}
			else
			{
				danffgdfmog = 5;
			}
			GlobalFog.PMGBFNPMDIM(HLBKCLPNHEB, BMMLHGHKBNM, this.AEIGGNCIEDI, danffgdfmog);
		}

		// Token: 0x06007D15 RID: 32021 RVA: 0x00293FEC File Offset: 0x002921EC
		private void GOBILPKKHFA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 361f;
			Vector3 b = transform.right * nearClipPlane * Mathf.Tan(num * 1462f) * aspect;
			Vector3 b2 = transform.up * nearClipPlane * Mathf.Tan(num * 865f);
			Vector3 vector = transform.forward * nearClipPlane - b + b2;
			float d = vector.magnitude * farClipPlane / nearClipPlane;
			vector.Normalize();
			vector *= d;
			Vector3 vector2 = transform.forward * nearClipPlane + b + b2;
			vector2.Normalize();
			vector2 *= d;
			Vector3 vector3 = transform.forward * nearClipPlane + b - b2;
			vector3.Normalize();
			vector3 *= d;
			Vector3 vector4 = transform.forward * nearClipPlane - b - b2;
			vector4.Normalize();
			vector4 *= d;
			identity.SetRow(1, vector);
			identity.SetRow(1, vector2);
			identity.SetRow(0, vector3);
			identity.SetRow(3, vector4);
			Vector3 position = transform.position;
			float num2 = position.y - this.height;
			float z = (num2 > 1890f) ? 1982f : 1490f;
			float y = (!this.excludeFarPixels) ? 455f : 1786f;
			this.AEIGGNCIEDI.SetMatrix("???", identity);
			this.AEIGGNCIEDI.SetVector("player.goldbat", position);
			this.AEIGGNCIEDI.SetVector("_ScreenResolution", new Vector4(this.height, num2, z, this.heightDensity * 369f));
			this.AEIGGNCIEDI.SetVector("menu.playedsolo", new Vector4(-Mathf.Max(this.startDistance, 674f), y, 1363f, 785f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num3 = (!flag) ? 1355f : (fogEndDistance - fogStartDistance);
			float num4 = (Mathf.Abs(num3) <= 1349f) ? 1588f : (1700f / num3);
			Vector4 value;
			value.x = fogDensity * 1932f;
			value.y = fogDensity * 1260f;
			value.z = ((!flag) ? 123f : (-num4));
			value.w = ((!flag) ? 1572f : (fogEndDistance * num4));
			this.AEIGGNCIEDI.SetVector("PlaySound", value);
			this.AEIGGNCIEDI.SetVector("_ScreenResolution", new Vector4((float)fogMode, (float)((!this.useRadialDistance) ? 1 : 0), 1523f, 1351f));
			int danffgdfmog;
			if (this.distanceFog && this.heightFog)
			{
				danffgdfmog = 1;
			}
			else if (this.distanceFog)
			{
				danffgdfmog = 0;
			}
			else
			{
				danffgdfmog = 4;
			}
			GlobalFog.FNNODHOMHMF(HLBKCLPNHEB, BMMLHGHKBNM, this.AEIGGNCIEDI, danffgdfmog);
		}

		// Token: 0x06007D16 RID: 32022 RVA: 0x002943C1 File Offset: 0x002925C1
		public virtual bool GACCMCAGAIJ()
		{
			base.JOMCJOEOLHP(true);
			this.AEIGGNCIEDI = base.KDHKHOHMKCG(this.fogShader, this.AEIGGNCIEDI);
			if (!this.LMKGCBNNGLI)
			{
				base.BPEKKDKKLPM();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007D17 RID: 32023 RVA: 0x002943FC File Offset: 0x002925FC
		private static void GOGNMMCLFNE(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			NMPKLIAPOEL.SetTexture("maps.", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(7);
			GL.MultiTexCoord2(1, 1791f, 1327f);
			GL.Vertex3(1174f, 1720f, 519f);
			GL.MultiTexCoord2(0, 1463f, 1236f);
			GL.Vertex3(1888f, 1918f, 327f);
			GL.MultiTexCoord2(0, 1323f, 1898f);
			GL.Vertex3(1055f, 1332f, 1237f);
			GL.MultiTexCoord2(0, 1578f, 1135f);
			GL.Vertex3(801f, 1420f, 1719f);
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007D18 RID: 32024 RVA: 0x002944CD File Offset: 0x002926CD
		public virtual bool CIDNHACINGF()
		{
			base.KNGDKKMDKOG(false);
			this.AEIGGNCIEDI = base.LKIJNGDHLAK(this.fogShader, this.AEIGGNCIEDI);
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007D19 RID: 32025 RVA: 0x00294508 File Offset: 0x00292708
		private void AIJJOIOAKGD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 1794f;
			Vector3 b = transform.right * nearClipPlane * Mathf.Tan(num * 1795f) * aspect;
			Vector3 b2 = transform.up * nearClipPlane * Mathf.Tan(num * 538f);
			Vector3 vector = transform.forward * nearClipPlane - b + b2;
			float d = vector.magnitude * farClipPlane / nearClipPlane;
			vector.Normalize();
			vector *= d;
			Vector3 vector2 = transform.forward * nearClipPlane + b + b2;
			vector2.Normalize();
			vector2 *= d;
			Vector3 vector3 = transform.forward * nearClipPlane + b - b2;
			vector3.Normalize();
			vector3 *= d;
			Vector3 vector4 = transform.forward * nearClipPlane - b - b2;
			vector4.Normalize();
			vector4 *= d;
			identity.SetRow(0, vector);
			identity.SetRow(0, vector2);
			identity.SetRow(7, vector3);
			identity.SetRow(3, vector4);
			Vector3 position = transform.position;
			float num2 = position.y - this.height;
			float z = (num2 > 1164f) ? 484f : 1189f;
			float y = (!this.excludeFarPixels) ? 1071f : 1266f;
			this.AEIGGNCIEDI.SetMatrix("LoadingStatusText", identity);
			this.AEIGGNCIEDI.SetVector("CameraFilterPack/Drawing_Manga", position);
			this.AEIGGNCIEDI.SetVector("StartButton", new Vector4(this.height, num2, z, this.heightDensity * 1154f));
			this.AEIGGNCIEDI.SetVector("_EdgeSharpness", new Vector4(-Mathf.Max(this.startDistance, 1015f), y, 150f, 329f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num3 = (!flag) ? 273f : (fogEndDistance - fogStartDistance);
			float num4 = (Mathf.Abs(num3) <= 1796f) ? 1990f : (1245f / num3);
			Vector4 value;
			value.x = fogDensity * 1296f;
			value.y = fogDensity * 1653f;
			value.z = ((!flag) ? 1860f : (-num4));
			value.w = ((!flag) ? 1025f : (fogEndDistance * num4));
			this.AEIGGNCIEDI.SetVector("InventoryGrid", value);
			this.AEIGGNCIEDI.SetVector("_Intensity", new Vector4((float)fogMode, (float)((!this.useRadialDistance) ? 0 : 1), 1082f, 1957f));
			int danffgdfmog;
			if (this.distanceFog && this.heightFog)
			{
				danffgdfmog = 0;
			}
			else if (this.distanceFog)
			{
				danffgdfmog = 0;
			}
			else
			{
				danffgdfmog = 3;
			}
			GlobalFog.MOJIILBCPGI(HLBKCLPNHEB, BMMLHGHKBNM, this.AEIGGNCIEDI, danffgdfmog);
		}

		// Token: 0x06007D1A RID: 32026 RVA: 0x002948E0 File Offset: 0x00292AE0
		private void HJGNJDAADGP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 886f;
			Vector3 b = transform.right * nearClipPlane * Mathf.Tan(num * 684f) * aspect;
			Vector3 b2 = transform.up * nearClipPlane * Mathf.Tan(num * 726f);
			Vector3 vector = transform.forward * nearClipPlane - b + b2;
			float d = vector.magnitude * farClipPlane / nearClipPlane;
			vector.Normalize();
			vector *= d;
			Vector3 vector2 = transform.forward * nearClipPlane + b + b2;
			vector2.Normalize();
			vector2 *= d;
			Vector3 vector3 = transform.forward * nearClipPlane + b - b2;
			vector3.Normalize();
			vector3 *= d;
			Vector3 vector4 = transform.forward * nearClipPlane - b - b2;
			vector4.Normalize();
			vector4 *= d;
			identity.SetRow(1, vector);
			identity.SetRow(0, vector2);
			identity.SetRow(7, vector3);
			identity.SetRow(6, vector4);
			Vector3 position = transform.position;
			float num2 = position.y - this.height;
			float z = (num2 > 1878f) ? 374f : 1229f;
			float y = (!this.excludeFarPixels) ? 454f : 1285f;
			this.AEIGGNCIEDI.SetMatrix("_Sensitivity", identity);
			this.AEIGGNCIEDI.SetVector("settings.enablehitsoundsinnormal", position);
			this.AEIGGNCIEDI.SetVector("sfxVolume", new Vector4(this.height, num2, z, this.heightDensity * 1099f));
			this.AEIGGNCIEDI.SetVector("Using Stopwatch as precision timer for PUN.", new Vector4(-Mathf.Max(this.startDistance, 1003f), y, 1305f, 1635f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num3 = (!flag) ? 588f : (fogEndDistance - fogStartDistance);
			float num4 = (Mathf.Abs(num3) <= 1956f) ? 368f : (706f / num3);
			Vector4 value;
			value.x = fogDensity * 1263f;
			value.y = fogDensity * 1705f;
			value.z = ((!flag) ? 1768f : (-num4));
			value.w = ((!flag) ? 359f : (fogEndDistance * num4));
			this.AEIGGNCIEDI.SetVector("_ScreenResolution", value);
			this.AEIGGNCIEDI.SetVector("offsets", new Vector4((float)fogMode, (float)((!this.useRadialDistance) ? 0 : 0), 1904f, 961f));
			int danffgdfmog;
			if (this.distanceFog && this.heightFog)
			{
				danffgdfmog = 0;
			}
			else if (this.distanceFog)
			{
				danffgdfmog = 0;
			}
			else
			{
				danffgdfmog = 1;
			}
			GlobalFog.ABHDMJCCKGO(HLBKCLPNHEB, BMMLHGHKBNM, this.AEIGGNCIEDI, danffgdfmog);
		}

		// Token: 0x06007D1B RID: 32027 RVA: 0x00294CB5 File Offset: 0x00292EB5
		public virtual bool PHEIDFBDELF()
		{
			base.CKIAMHAKJOK(false);
			this.AEIGGNCIEDI = base.AJKPGPKKHHB(this.fogShader, this.AEIGGNCIEDI);
			if (!this.LMKGCBNNGLI)
			{
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007D1C RID: 32028 RVA: 0x00294CF0 File Offset: 0x00292EF0
		private void DPMMIPDKJND(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 19f;
			Vector3 b = transform.right * nearClipPlane * Mathf.Tan(num * 1541f) * aspect;
			Vector3 b2 = transform.up * nearClipPlane * Mathf.Tan(num * 1623f);
			Vector3 vector = transform.forward * nearClipPlane - b + b2;
			float d = vector.magnitude * farClipPlane / nearClipPlane;
			vector.Normalize();
			vector *= d;
			Vector3 vector2 = transform.forward * nearClipPlane + b + b2;
			vector2.Normalize();
			vector2 *= d;
			Vector3 vector3 = transform.forward * nearClipPlane + b - b2;
			vector3.Normalize();
			vector3 *= d;
			Vector3 vector4 = transform.forward * nearClipPlane - b - b2;
			vector4.Normalize();
			vector4 *= d;
			identity.SetRow(1, vector);
			identity.SetRow(0, vector2);
			identity.SetRow(1, vector3);
			identity.SetRow(7, vector4);
			Vector3 position = transform.position;
			float num2 = position.y - this.height;
			float z = (num2 > 1612f) ? 1785f : 428f;
			float y = (!this.excludeFarPixels) ? 191f : 1092f;
			this.AEIGGNCIEDI.SetMatrix("#yes", identity);
			this.AEIGGNCIEDI.SetVector("Switch environment sprite image", position);
			this.AEIGGNCIEDI.SetVector("itemid", new Vector4(this.height, num2, z, this.heightDensity * 1482f));
			this.AEIGGNCIEDI.SetVector("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", new Vector4(-Mathf.Max(this.startDistance, 1285f), y, 1566f, 1224f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num3 = (!flag) ? 408f : (fogEndDistance - fogStartDistance);
			float num4 = (Mathf.Abs(num3) <= 386f) ? 1155f : (419f / num3);
			Vector4 value;
			value.x = fogDensity * 1719f;
			value.y = fogDensity * 370f;
			value.z = ((!flag) ? 1790f : (-num4));
			value.w = ((!flag) ? 768f : (fogEndDistance * num4));
			this.AEIGGNCIEDI.SetVector("The number of objects sent via a PhotonStreamQueue has to be the same each frame", value);
			this.AEIGGNCIEDI.SetVector("#onrankchangedowntext", new Vector4((float)fogMode, (float)((!this.useRadialDistance) ? 0 : 0), 608f, 869f));
			int danffgdfmog;
			if (this.distanceFog && this.heightFog)
			{
				danffgdfmog = 0;
			}
			else if (this.distanceFog)
			{
				danffgdfmog = 1;
			}
			else
			{
				danffgdfmog = 8;
			}
			GlobalFog.KFKAHOAJLMO(HLBKCLPNHEB, BMMLHGHKBNM, this.AEIGGNCIEDI, danffgdfmog);
		}

		// Token: 0x06007D1D RID: 32029 RVA: 0x002950C5 File Offset: 0x002932C5
		public virtual bool IMPPEKJHPIM()
		{
			base.DHHGCBANGJL(true);
			this.AEIGGNCIEDI = base.GJKHKCOAFDB(this.fogShader, this.AEIGGNCIEDI);
			if (!this.LMKGCBNNGLI)
			{
				base.HKDNNECLBGL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007D1E RID: 32030 RVA: 0x00295100 File Offset: 0x00293300
		private static void PMGBFNPMDIM(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			NMPKLIAPOEL.SetTexture("_Speed", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(2);
			GL.MultiTexCoord2(1, 976f, 684f);
			GL.Vertex3(1498f, 506f, 924f);
			GL.MultiTexCoord2(0, 1525f, 703f);
			GL.Vertex3(538f, 320f, 1372f);
			GL.MultiTexCoord2(0, 498f, 1472f);
			GL.Vertex3(997f, 67f, 1723f);
			GL.MultiTexCoord2(0, 576f, 479f);
			GL.Vertex3(1852f, 110f, 245f);
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007D1F RID: 32031 RVA: 0x002951D4 File Offset: 0x002933D4
		private void LBHPMIDFKPP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CheckResources() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 180f;
			Vector3 b = transform.right * nearClipPlane * Mathf.Tan(num * 1338f) * aspect;
			Vector3 b2 = transform.up * nearClipPlane * Mathf.Tan(num * 197f);
			Vector3 vector = transform.forward * nearClipPlane - b + b2;
			float d = vector.magnitude * farClipPlane / nearClipPlane;
			vector.Normalize();
			vector *= d;
			Vector3 vector2 = transform.forward * nearClipPlane + b + b2;
			vector2.Normalize();
			vector2 *= d;
			Vector3 vector3 = transform.forward * nearClipPlane + b - b2;
			vector3.Normalize();
			vector3 *= d;
			Vector3 vector4 = transform.forward * nearClipPlane - b - b2;
			vector4.Normalize();
			vector4 *= d;
			identity.SetRow(1, vector);
			identity.SetRow(0, vector2);
			identity.SetRow(3, vector3);
			identity.SetRow(3, vector4);
			Vector3 position = transform.position;
			float num2 = position.y - this.height;
			float z = (num2 > 934f) ? 1255f : 1884f;
			float y = (!this.excludeFarPixels) ? 431f : 1948f;
			this.AEIGGNCIEDI.SetMatrix(" PhotonView: ", identity);
			this.AEIGGNCIEDI.SetVector("_ScreenResolution", position);
			this.AEIGGNCIEDI.SetVector("_TimeX", new Vector4(this.height, num2, z, this.heightDensity * 156f));
			this.AEIGGNCIEDI.SetVector("_Value5", new Vector4(-Mathf.Max(this.startDistance, 1239f), y, 279f, 246f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num3 = (!flag) ? 1271f : (fogEndDistance - fogStartDistance);
			float num4 = (Mathf.Abs(num3) <= 161f) ? 1496f : (1941f / num3);
			Vector4 value;
			value.x = fogDensity * 714f;
			value.y = fogDensity * 1136f;
			value.z = ((!flag) ? 1697f : (-num4));
			value.w = ((!flag) ? 1653f : (fogEndDistance * num4));
			this.AEIGGNCIEDI.SetVector("Delete events", value);
			this.AEIGGNCIEDI.SetVector("SpawnObj", new Vector4((float)fogMode, (float)((!this.useRadialDistance) ? 0 : 1), 1194f, 1913f));
			int danffgdfmog;
			if (this.distanceFog && this.heightFog)
			{
				danffgdfmog = 1;
			}
			else if (this.distanceFog)
			{
				danffgdfmog = 0;
			}
			else
			{
				danffgdfmog = 4;
			}
			GlobalFog.JGMECDOCILD(HLBKCLPNHEB, BMMLHGHKBNM, this.AEIGGNCIEDI, danffgdfmog);
		}

		// Token: 0x06007D20 RID: 32032 RVA: 0x002955AC File Offset: 0x002937AC
		private void JPOOAJCAJJF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 1181f;
			Vector3 b = transform.right * nearClipPlane * Mathf.Tan(num * 1016f) * aspect;
			Vector3 b2 = transform.up * nearClipPlane * Mathf.Tan(num * 342f);
			Vector3 vector = transform.forward * nearClipPlane - b + b2;
			float d = vector.magnitude * farClipPlane / nearClipPlane;
			vector.Normalize();
			vector *= d;
			Vector3 vector2 = transform.forward * nearClipPlane + b + b2;
			vector2.Normalize();
			vector2 *= d;
			Vector3 vector3 = transform.forward * nearClipPlane + b - b2;
			vector3.Normalize();
			vector3 *= d;
			Vector3 vector4 = transform.forward * nearClipPlane - b - b2;
			vector4.Normalize();
			vector4 *= d;
			identity.SetRow(0, vector);
			identity.SetRow(0, vector2);
			identity.SetRow(4, vector3);
			identity.SetRow(0, vector4);
			Vector3 position = transform.position;
			float num2 = position.y - this.height;
			float z = (num2 > 324f) ? 1288f : 71f;
			float y = (!this.excludeFarPixels) ? 711f : 1419f;
			this.AEIGGNCIEDI.SetMatrix("Tab2Content", identity);
			this.AEIGGNCIEDI.SetVector("_SSRMultiplier", position);
			this.AEIGGNCIEDI.SetVector("USE_PREDICATION", new Vector4(this.height, num2, z, this.heightDensity * 1141f));
			this.AEIGGNCIEDI.SetVector("_Gamma", new Vector4(-Mathf.Max(this.startDistance, 1006f), y, 1519f, 1465f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num3 = (!flag) ? 1672f : (fogEndDistance - fogStartDistance);
			float num4 = (Mathf.Abs(num3) <= 196f) ? 1860f : (585f / num3);
			Vector4 value;
			value.x = fogDensity * 498f;
			value.y = fogDensity * 789f;
			value.z = ((!flag) ? 17f : (-num4));
			value.w = ((!flag) ? 981f : (fogEndDistance * num4));
			this.AEIGGNCIEDI.SetVector("a month ago", value);
			this.AEIGGNCIEDI.SetVector("[NetworkManager] Exited", new Vector4((float)fogMode, (float)((!this.useRadialDistance) ? 0 : 0), 1094f, 600f));
			int danffgdfmog;
			if (this.distanceFog && this.heightFog)
			{
				danffgdfmog = 0;
			}
			else if (this.distanceFog)
			{
				danffgdfmog = 0;
			}
			else
			{
				danffgdfmog = 7;
			}
			GlobalFog.BEAFIPMHCLC(HLBKCLPNHEB, BMMLHGHKBNM, this.AEIGGNCIEDI, danffgdfmog);
		}

		// Token: 0x06007D21 RID: 32033 RVA: 0x00295984 File Offset: 0x00293B84
		private static void FNNODHOMHMF(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			NMPKLIAPOEL.SetTexture("/?page=ranks", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(0);
			GL.MultiTexCoord2(0, 430f, 378f);
			GL.Vertex3(341f, 136f, 1285f);
			GL.MultiTexCoord2(0, 304f, 1796f);
			GL.Vertex3(1315f, 888f, 668f);
			GL.MultiTexCoord2(1, 1531f, 415f);
			GL.Vertex3(346f, 243f, 1605f);
			GL.MultiTexCoord2(0, 1919f, 883f);
			GL.Vertex3(1655f, 1330f, 243f);
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007D22 RID: 32034 RVA: 0x00295A58 File Offset: 0x00293C58
		private void HNADGLKNADJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 978f;
			Vector3 b = transform.right * nearClipPlane * Mathf.Tan(num * 1275f) * aspect;
			Vector3 b2 = transform.up * nearClipPlane * Mathf.Tan(num * 1580f);
			Vector3 vector = transform.forward * nearClipPlane - b + b2;
			float d = vector.magnitude * farClipPlane / nearClipPlane;
			vector.Normalize();
			vector *= d;
			Vector3 vector2 = transform.forward * nearClipPlane + b + b2;
			vector2.Normalize();
			vector2 *= d;
			Vector3 vector3 = transform.forward * nearClipPlane + b - b2;
			vector3.Normalize();
			vector3 *= d;
			Vector3 vector4 = transform.forward * nearClipPlane - b - b2;
			vector4.Normalize();
			vector4 *= d;
			identity.SetRow(0, vector);
			identity.SetRow(0, vector2);
			identity.SetRow(3, vector3);
			identity.SetRow(7, vector4);
			Vector3 position = transform.position;
			float num2 = position.y - this.height;
			float z = (num2 > 1699f) ? 1913f : 1296f;
			float y = (!this.excludeFarPixels) ? 1160f : 569f;
			this.AEIGGNCIEDI.SetMatrix("_Value2", identity);
			this.AEIGGNCIEDI.SetVector("offsets", position);
			this.AEIGGNCIEDI.SetVector("ReconnectAndRejoin() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", new Vector4(this.height, num2, z, this.heightDensity * 1983f));
			this.AEIGGNCIEDI.SetVector(" BETA", new Vector4(-Mathf.Max(this.startDistance, 913f), y, 286f, 1862f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == (FogMode)0;
			float num3 = (!flag) ? 726f : (fogEndDistance - fogStartDistance);
			float num4 = (Mathf.Abs(num3) <= 586f) ? 1611f : (82f / num3);
			Vector4 value;
			value.x = fogDensity * 1945f;
			value.y = fogDensity * 1184f;
			value.z = ((!flag) ? 1295f : (-num4));
			value.w = ((!flag) ? 1580f : (fogEndDistance * num4));
			this.AEIGGNCIEDI.SetVector("workshop.", value);
			this.AEIGGNCIEDI.SetVector("_TimeX", new Vector4((float)fogMode, (float)((!this.useRadialDistance) ? 1 : 1), 1585f, 1937f));
			int danffgdfmog;
			if (this.distanceFog && this.heightFog)
			{
				danffgdfmog = 1;
			}
			else if (this.distanceFog)
			{
				danffgdfmog = 0;
			}
			else
			{
				danffgdfmog = 7;
			}
			GlobalFog.GOGNMMCLFNE(HLBKCLPNHEB, BMMLHGHKBNM, this.AEIGGNCIEDI, danffgdfmog);
		}

		// Token: 0x06007D23 RID: 32035 RVA: 0x00295E30 File Offset: 0x00294030
		private static void JGMECDOCILD(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			NMPKLIAPOEL.SetTexture("mapselector.filter.subscribedonly", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(5);
			GL.MultiTexCoord2(0, 701f, 1997f);
			GL.Vertex3(936f, 685f, 906f);
			GL.MultiTexCoord2(0, 36f, 1611f);
			GL.Vertex3(1410f, 835f, 924f);
			GL.MultiTexCoord2(0, 352f, 43f);
			GL.Vertex3(1342f, 1795f, 1514f);
			GL.MultiTexCoord2(0, 593f, 952f);
			GL.Vertex3(85f, 285f, 461f);
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007D24 RID: 32036 RVA: 0x00295F01 File Offset: 0x00294101
		public virtual bool KFDALIFKLHE()
		{
			base.IHMNPAHGNFF(false);
			this.AEIGGNCIEDI = base.AJKPGPKKHHB(this.fogShader, this.AEIGGNCIEDI);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007D25 RID: 32037 RVA: 0x00295F3C File Offset: 0x0029413C
		private void GKJFBIJGCHP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 1533f;
			Vector3 b = transform.right * nearClipPlane * Mathf.Tan(num * 1087f) * aspect;
			Vector3 b2 = transform.up * nearClipPlane * Mathf.Tan(num * 1526f);
			Vector3 vector = transform.forward * nearClipPlane - b + b2;
			float d = vector.magnitude * farClipPlane / nearClipPlane;
			vector.Normalize();
			vector *= d;
			Vector3 vector2 = transform.forward * nearClipPlane + b + b2;
			vector2.Normalize();
			vector2 *= d;
			Vector3 vector3 = transform.forward * nearClipPlane + b - b2;
			vector3.Normalize();
			vector3 *= d;
			Vector3 vector4 = transform.forward * nearClipPlane - b - b2;
			vector4.Normalize();
			vector4 *= d;
			identity.SetRow(0, vector);
			identity.SetRow(0, vector2);
			identity.SetRow(1, vector3);
			identity.SetRow(6, vector4);
			Vector3 position = transform.position;
			float num2 = position.y - this.height;
			float z = (num2 > 1646f) ? 1692f : 148f;
			float y = (!this.excludeFarPixels) ? 776f : 1082f;
			this.AEIGGNCIEDI.SetMatrix("PLEASE WAIT", identity);
			this.AEIGGNCIEDI.SetVector("_Value", position);
			this.AEIGGNCIEDI.SetVector("_EmissionColor", new Vector4(this.height, num2, z, this.heightDensity * 710f));
			this.AEIGGNCIEDI.SetVector("_Value2", new Vector4(-Mathf.Max(this.startDistance, 905f), y, 1935f, 1038f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num3 = (!flag) ? 1531f : (fogEndDistance - fogStartDistance);
			float num4 = (Mathf.Abs(num3) <= 366f) ? 927f : (1613f / num3);
			Vector4 value;
			value.x = fogDensity * 953f;
			value.y = fogDensity * 1242f;
			value.z = ((!flag) ? 1185f : (-num4));
			value.w = ((!flag) ? 1100f : (fogEndDistance * num4));
			this.AEIGGNCIEDI.SetVector("Set Crosshair Emission", value);
			this.AEIGGNCIEDI.SetVector("Validating mod pack...", new Vector4((float)fogMode, (float)((!this.useRadialDistance) ? 1 : 0), 1481f, 638f));
			int danffgdfmog;
			if (this.distanceFog && this.heightFog)
			{
				danffgdfmog = 0;
			}
			else if (this.distanceFog)
			{
				danffgdfmog = 1;
			}
			else
			{
				danffgdfmog = 8;
			}
			GlobalFog.KFKAHOAJLMO(HLBKCLPNHEB, BMMLHGHKBNM, this.AEIGGNCIEDI, danffgdfmog);
		}

		// Token: 0x06007D26 RID: 32038 RVA: 0x00296314 File Offset: 0x00294514
		private void MHGGJOAHGLL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.OEECIHEGJHE() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 1933f;
			Vector3 b = transform.right * nearClipPlane * Mathf.Tan(num * 1182f) * aspect;
			Vector3 b2 = transform.up * nearClipPlane * Mathf.Tan(num * 173f);
			Vector3 vector = transform.forward * nearClipPlane - b + b2;
			float d = vector.magnitude * farClipPlane / nearClipPlane;
			vector.Normalize();
			vector *= d;
			Vector3 vector2 = transform.forward * nearClipPlane + b + b2;
			vector2.Normalize();
			vector2 *= d;
			Vector3 vector3 = transform.forward * nearClipPlane + b - b2;
			vector3.Normalize();
			vector3 *= d;
			Vector3 vector4 = transform.forward * nearClipPlane - b - b2;
			vector4.Normalize();
			vector4 *= d;
			identity.SetRow(1, vector);
			identity.SetRow(0, vector2);
			identity.SetRow(1, vector3);
			identity.SetRow(1, vector4);
			Vector3 position = transform.position;
			float num2 = position.y - this.height;
			float z = (num2 > 314f) ? 178f : 138f;
			float y = (!this.excludeFarPixels) ? 1145f : 164f;
			this.AEIGGNCIEDI.SetMatrix("#tryagain", identity);
			this.AEIGGNCIEDI.SetVector("menu.enableselectormusic", position);
			this.AEIGGNCIEDI.SetVector(": ", new Vector4(this.height, num2, z, this.heightDensity * 54f));
			this.AEIGGNCIEDI.SetVector("HightScoreMaxPointsText", new Vector4(-Mathf.Max(this.startDistance, 1038f), y, 420f, 1364f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == (FogMode)0;
			float num3 = (!flag) ? 804f : (fogEndDistance - fogStartDistance);
			float num4 = (Mathf.Abs(num3) <= 1114f) ? 80f : (1996f / num3);
			Vector4 value;
			value.x = fogDensity * 260f;
			value.y = fogDensity * 371f;
			value.z = ((!flag) ? 372f : (-num4));
			value.w = ((!flag) ? 285f : (fogEndDistance * num4));
			this.AEIGGNCIEDI.SetVector("AddEnvironmentObject", value);
			this.AEIGGNCIEDI.SetVector("player.redarc", new Vector4((float)fogMode, (float)((!this.useRadialDistance) ? 1 : 0), 1264f, 1609f));
			int danffgdfmog;
			if (this.distanceFog && this.heightFog)
			{
				danffgdfmog = 0;
			}
			else if (this.distanceFog)
			{
				danffgdfmog = 0;
			}
			else
			{
				danffgdfmog = 2;
			}
			GlobalFog.CHENIJHDAPL(HLBKCLPNHEB, BMMLHGHKBNM, this.AEIGGNCIEDI, danffgdfmog);
		}

		// Token: 0x06007D27 RID: 32039 RVA: 0x002966E9 File Offset: 0x002948E9
		public virtual bool LPDMNDMCPCO()
		{
			base.IBFDMKMOBCA(false);
			this.AEIGGNCIEDI = base.GJKHKCOAFDB(this.fogShader, this.AEIGGNCIEDI);
			if (!this.LMKGCBNNGLI)
			{
				base.OJOJPJNEKHJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007D28 RID: 32040 RVA: 0x00296722 File Offset: 0x00294922
		public virtual bool JDPOEILHKLC()
		{
			base.CKIAMHAKJOK(true);
			this.AEIGGNCIEDI = base.NODBMINMALP(this.fogShader, this.AEIGGNCIEDI);
			if (!this.LMKGCBNNGLI)
			{
				base.HKDNNECLBGL();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007D29 RID: 32041 RVA: 0x0029675C File Offset: 0x0029495C
		private static void FJFJOACGKML(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			NMPKLIAPOEL.SetTexture("OneHand", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(1);
			GL.MultiTexCoord2(1, 1008f, 1069f);
			GL.Vertex3(1573f, 617f, 1572f);
			GL.MultiTexCoord2(0, 1015f, 277f);
			GL.Vertex3(338f, 455f, 1939f);
			GL.MultiTexCoord2(1, 1456f, 782f);
			GL.Vertex3(1780f, 1148f, 655f);
			GL.MultiTexCoord2(0, 1187f, 1486f);
			GL.Vertex3(1911f, 1431f, 1487f);
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007D2A RID: 32042 RVA: 0x00296830 File Offset: 0x00294A30
		private void NEALKDCJCJH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 1705f;
			Vector3 b = transform.right * nearClipPlane * Mathf.Tan(num * 1947f) * aspect;
			Vector3 b2 = transform.up * nearClipPlane * Mathf.Tan(num * 1965f);
			Vector3 vector = transform.forward * nearClipPlane - b + b2;
			float d = vector.magnitude * farClipPlane / nearClipPlane;
			vector.Normalize();
			vector *= d;
			Vector3 vector2 = transform.forward * nearClipPlane + b + b2;
			vector2.Normalize();
			vector2 *= d;
			Vector3 vector3 = transform.forward * nearClipPlane + b - b2;
			vector3.Normalize();
			vector3 *= d;
			Vector3 vector4 = transform.forward * nearClipPlane - b - b2;
			vector4.Normalize();
			vector4 *= d;
			identity.SetRow(1, vector);
			identity.SetRow(0, vector2);
			identity.SetRow(6, vector3);
			identity.SetRow(7, vector4);
			Vector3 position = transform.position;
			float num2 = position.y - this.height;
			float z = (num2 > 1073f) ? 1676f : 716f;
			float y = (!this.excludeFarPixels) ? 1334f : 53f;
			this.AEIGGNCIEDI.SetMatrix("OpJoinRandomRoom()", identity);
			this.AEIGGNCIEDI.SetVector("_Value4", position);
			this.AEIGGNCIEDI.SetVector("_Value3", new Vector4(this.height, num2, z, this.heightDensity * 29f));
			this.AEIGGNCIEDI.SetVector("_FarCamera", new Vector4(-Mathf.Max(this.startDistance, 234f), y, 449f, 1861f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num3 = (!flag) ? 247f : (fogEndDistance - fogStartDistance);
			float num4 = (Mathf.Abs(num3) <= 799f) ? 1334f : (1188f / num3);
			Vector4 value;
			value.x = fogDensity * 1014f;
			value.y = fogDensity * 1923f;
			value.z = ((!flag) ? 1005f : (-num4));
			value.w = ((!flag) ? 1531f : (fogEndDistance * num4));
			this.AEIGGNCIEDI.SetVector("SetParticlesGravity", value);
			this.AEIGGNCIEDI.SetVector("Failed to Destroy objects of playerId: ", new Vector4((float)fogMode, (float)((!this.useRadialDistance) ? 1 : 1), 725f, 1089f));
			int danffgdfmog;
			if (this.distanceFog && this.heightFog)
			{
				danffgdfmog = 0;
			}
			else if (this.distanceFog)
			{
				danffgdfmog = 0;
			}
			else
			{
				danffgdfmog = 4;
			}
			GlobalFog.MOJIILBCPGI(HLBKCLPNHEB, BMMLHGHKBNM, this.AEIGGNCIEDI, danffgdfmog);
		}

		// Token: 0x06007D2B RID: 32043 RVA: 0x00296C05 File Offset: 0x00294E05
		public virtual bool JFFKKNHBANB()
		{
			base.DHHGCBANGJL(false);
			this.AEIGGNCIEDI = base.AJKPGPKKHHB(this.fogShader, this.AEIGGNCIEDI);
			if (!this.LMKGCBNNGLI)
			{
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007D2C RID: 32044 RVA: 0x00296C40 File Offset: 0x00294E40
		private static void MDFLOOIIOIP(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			NMPKLIAPOEL.SetTexture("Item ", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(2);
			GL.MultiTexCoord2(1, 557f, 530f);
			GL.Vertex3(518f, 752f, 1701f);
			GL.MultiTexCoord2(1, 1994f, 249f);
			GL.Vertex3(1133f, 1031f, 846f);
			GL.MultiTexCoord2(1, 742f, 895f);
			GL.Vertex3(110f, 1424f, 1920f);
			GL.MultiTexCoord2(0, 723f, 502f);
			GL.Vertex3(1661f, 56f, 1655f);
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007D2D RID: 32045 RVA: 0x00296D14 File Offset: 0x00294F14
		private static void BEAFIPMHCLC(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			NMPKLIAPOEL.SetTexture("_LayerThickness", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(2);
			GL.MultiTexCoord2(1, 1426f, 1875f);
			GL.Vertex3(463f, 408f, 637f);
			GL.MultiTexCoord2(0, 821f, 323f);
			GL.Vertex3(1432f, 1196f, 519f);
			GL.MultiTexCoord2(1, 832f, 647f);
			GL.Vertex3(1151f, 63f, 755f);
			GL.MultiTexCoord2(1, 951f, 1974f);
			GL.Vertex3(1343f, 177f, 656f);
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007D2E RID: 32046 RVA: 0x00296DE5 File Offset: 0x00294FE5
		public virtual bool OANEEBGKMGK()
		{
			base.DHHGCBANGJL(true);
			this.AEIGGNCIEDI = base.ECNEGNMAMDE(this.fogShader, this.AEIGGNCIEDI);
			if (!this.LMKGCBNNGLI)
			{
				base.GHNPJCMLCNB();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007D2F RID: 32047 RVA: 0x00296E20 File Offset: 0x00295020
		private static void DPPDNNNAANB(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			NMPKLIAPOEL.SetTexture("_Intensity", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(2);
			GL.MultiTexCoord2(1, 552f, 1937f);
			GL.Vertex3(1032f, 8f, 383f);
			GL.MultiTexCoord2(0, 790f, 1860f);
			GL.Vertex3(736f, 572f, 153f);
			GL.MultiTexCoord2(1, 480f, 1271f);
			GL.Vertex3(1638f, 954f, 368f);
			GL.MultiTexCoord2(0, 1373f, 1701f);
			GL.Vertex3(473f, 364f, 1831f);
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007D30 RID: 32048 RVA: 0x00296EF1 File Offset: 0x002950F1
		public virtual bool GMFKDOKAOPO()
		{
			base.LMEBEGFJGEM(false);
			this.AEIGGNCIEDI = base.LKIJNGDHLAK(this.fogShader, this.AEIGGNCIEDI);
			if (!this.LMKGCBNNGLI)
			{
				base.IOMHNBJEKLP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007D31 RID: 32049 RVA: 0x00296F2A File Offset: 0x0029512A
		public virtual bool IILEKDNFOFI()
		{
			base.FNIFJAENDIB(true);
			this.AEIGGNCIEDI = base.GJKHKCOAFDB(this.fogShader, this.AEIGGNCIEDI);
			if (!this.LMKGCBNNGLI)
			{
				base.BPEKKDKKLPM();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007D32 RID: 32050 RVA: 0x00296F64 File Offset: 0x00295164
		private void KEFKNAOGCHO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.PFIELBMLHJK() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 1814f;
			Vector3 b = transform.right * nearClipPlane * Mathf.Tan(num * 1422f) * aspect;
			Vector3 b2 = transform.up * nearClipPlane * Mathf.Tan(num * 122f);
			Vector3 vector = transform.forward * nearClipPlane - b + b2;
			float d = vector.magnitude * farClipPlane / nearClipPlane;
			vector.Normalize();
			vector *= d;
			Vector3 vector2 = transform.forward * nearClipPlane + b + b2;
			vector2.Normalize();
			vector2 *= d;
			Vector3 vector3 = transform.forward * nearClipPlane + b - b2;
			vector3.Normalize();
			vector3 *= d;
			Vector3 vector4 = transform.forward * nearClipPlane - b - b2;
			vector4.Normalize();
			vector4 *= d;
			identity.SetRow(0, vector);
			identity.SetRow(0, vector2);
			identity.SetRow(6, vector3);
			identity.SetRow(4, vector4);
			Vector3 position = transform.position;
			float num2 = position.y - this.height;
			float z = (num2 > 1623f) ? 624f : 1962f;
			float y = (!this.excludeFarPixels) ? 1615f : 1893f;
			this.AEIGGNCIEDI.SetMatrix("CameraFilterPack/EXTRA_SHOWFPS", identity);
			this.AEIGGNCIEDI.SetVector("_Value3", position);
			this.AEIGGNCIEDI.SetVector(".completedCount", new Vector4(this.height, num2, z, this.heightDensity * 1388f));
			this.AEIGGNCIEDI.SetVector("Map already submited. Update?", new Vector4(-Mathf.Max(this.startDistance, 45f), y, 1638f, 674f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num3 = (!flag) ? 319f : (fogEndDistance - fogStartDistance);
			float num4 = (Mathf.Abs(num3) <= 1706f) ? 1878f : (970f / num3);
			Vector4 value;
			value.x = fogDensity * 1660f;
			value.y = fogDensity * 654f;
			value.z = ((!flag) ? 1315f : (-num4));
			value.w = ((!flag) ? 232f : (fogEndDistance * num4));
			this.AEIGGNCIEDI.SetVector("Result for ", value);
			this.AEIGGNCIEDI.SetVector("roomDescription", new Vector4((float)fogMode, (float)((!this.useRadialDistance) ? 0 : 0), 1311f, 1144f));
			int danffgdfmog;
			if (this.distanceFog && this.heightFog)
			{
				danffgdfmog = 1;
			}
			else if (this.distanceFog)
			{
				danffgdfmog = 0;
			}
			else
			{
				danffgdfmog = 2;
			}
			GlobalFog.CHENIJHDAPL(HLBKCLPNHEB, BMMLHGHKBNM, this.AEIGGNCIEDI, danffgdfmog);
		}

		// Token: 0x06007D33 RID: 32051 RVA: 0x0029733C File Offset: 0x0029553C
		private static void NAEKCGAEPCD(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			NMPKLIAPOEL.SetTexture("_Value2", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(8);
			GL.MultiTexCoord2(1, 789f, 51f);
			GL.Vertex3(1597f, 197f, 1078f);
			GL.MultiTexCoord2(1, 329f, 72f);
			GL.Vertex3(1388f, 908f, 1595f);
			GL.MultiTexCoord2(0, 1207f, 994f);
			GL.Vertex3(1451f, 1985f, 1916f);
			GL.MultiTexCoord2(1, 957f, 1062f);
			GL.Vertex3(860f, 1274f, 1011f);
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007D34 RID: 32052 RVA: 0x00297410 File Offset: 0x00295610
		private static void EMGDEKGEBOP(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			NMPKLIAPOEL.SetTexture("MapperNameText", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(8);
			GL.MultiTexCoord2(1, 1357f, 1533f);
			GL.Vertex3(1733f, 318f, 1856f);
			GL.MultiTexCoord2(0, 254f, 1612f);
			GL.Vertex3(225f, 1619f, 1702f);
			GL.MultiTexCoord2(0, 1688f, 1631f);
			GL.Vertex3(1650f, 1042f, 1124f);
			GL.MultiTexCoord2(1, 1666f, 1363f);
			GL.Vertex3(95f, 280f, 1305f);
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007D35 RID: 32053 RVA: 0x002974E4 File Offset: 0x002956E4
		private void ENGFEPKGEDG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 440f;
			Vector3 b = transform.right * nearClipPlane * Mathf.Tan(num * 1114f) * aspect;
			Vector3 b2 = transform.up * nearClipPlane * Mathf.Tan(num * 289f);
			Vector3 vector = transform.forward * nearClipPlane - b + b2;
			float d = vector.magnitude * farClipPlane / nearClipPlane;
			vector.Normalize();
			vector *= d;
			Vector3 vector2 = transform.forward * nearClipPlane + b + b2;
			vector2.Normalize();
			vector2 *= d;
			Vector3 vector3 = transform.forward * nearClipPlane + b - b2;
			vector3.Normalize();
			vector3 *= d;
			Vector3 vector4 = transform.forward * nearClipPlane - b - b2;
			vector4.Normalize();
			vector4 *= d;
			identity.SetRow(1, vector);
			identity.SetRow(1, vector2);
			identity.SetRow(7, vector3);
			identity.SetRow(6, vector4);
			Vector3 position = transform.position;
			float num2 = position.y - this.height;
			float z = (num2 > 1027f) ? 1041f : 1598f;
			float y = (!this.excludeFarPixels) ? 1132f : 1514f;
			this.AEIGGNCIEDI.SetMatrix("#{0:00}{1}{2}", identity);
			this.AEIGGNCIEDI.SetVector("0.00", position);
			this.AEIGGNCIEDI.SetVector("_Blue_B", new Vector4(this.height, num2, z, this.heightDensity * 1776f));
			this.AEIGGNCIEDI.SetVector("Joystick1Button4", new Vector4(-Mathf.Max(this.startDistance, 609f), y, 383f, 20f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == (FogMode)0;
			float num3 = (!flag) ? 171f : (fogEndDistance - fogStartDistance);
			float num4 = (Mathf.Abs(num3) <= 1390f) ? 288f : (281f / num3);
			Vector4 value;
			value.x = fogDensity * 1457f;
			value.y = fogDensity * 1611f;
			value.z = ((!flag) ? 1149f : (-num4));
			value.w = ((!flag) ? 1236f : (fogEndDistance * num4));
			this.AEIGGNCIEDI.SetVector("_Value2", value);
			this.AEIGGNCIEDI.SetVector("_Distortion2", new Vector4((float)fogMode, (float)((!this.useRadialDistance) ? 0 : 1), 1282f, 1673f));
			int danffgdfmog;
			if (this.distanceFog && this.heightFog)
			{
				danffgdfmog = 0;
			}
			else if (this.distanceFog)
			{
				danffgdfmog = 1;
			}
			else
			{
				danffgdfmog = 3;
			}
			GlobalFog.CBPPMDAMALI(HLBKCLPNHEB, BMMLHGHKBNM, this.AEIGGNCIEDI, danffgdfmog);
		}

		// Token: 0x06007D36 RID: 32054 RVA: 0x002978B9 File Offset: 0x00295AB9
		public override bool CheckResources()
		{
			base.NPOEJIDLJGK(true);
			this.AEIGGNCIEDI = base.EDFIBHNHAAB(this.fogShader, this.AEIGGNCIEDI);
			if (!this.LMKGCBNNGLI)
			{
				base.AOHOJHGMANG();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007D37 RID: 32055 RVA: 0x002978F4 File Offset: 0x00295AF4
		private static void ABHDMJCCKGO(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			NMPKLIAPOEL.SetTexture("SetRoomStartTimestamp", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(5);
			GL.MultiTexCoord2(1, 425f, 1990f);
			GL.Vertex3(1262f, 438f, 208f);
			GL.MultiTexCoord2(1, 978f, 1088f);
			GL.Vertex3(1508f, 891f, 167f);
			GL.MultiTexCoord2(1, 1334f, 479f);
			GL.Vertex3(810f, 1140f, 1930f);
			GL.MultiTexCoord2(0, 895f, 1100f);
			GL.Vertex3(423f, 1579f, 696f);
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007D38 RID: 32056 RVA: 0x002979C5 File Offset: 0x00295BC5
		public override bool LPDGLHPMDLB()
		{
			base.IHMNPAHGNFF(false);
			this.AEIGGNCIEDI = base.EDFIBHNHAAB(this.fogShader, this.AEIGGNCIEDI);
			if (!this.LMKGCBNNGLI)
			{
				base.EHBONBLLGBF();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007D39 RID: 32057 RVA: 0x00297A00 File Offset: 0x00295C00
		private void LDIOANOMHMO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.ILMGHBFANON() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 404f;
			Vector3 b = transform.right * nearClipPlane * Mathf.Tan(num * 537f) * aspect;
			Vector3 b2 = transform.up * nearClipPlane * Mathf.Tan(num * 1145f);
			Vector3 vector = transform.forward * nearClipPlane - b + b2;
			float d = vector.magnitude * farClipPlane / nearClipPlane;
			vector.Normalize();
			vector *= d;
			Vector3 vector2 = transform.forward * nearClipPlane + b + b2;
			vector2.Normalize();
			vector2 *= d;
			Vector3 vector3 = transform.forward * nearClipPlane + b - b2;
			vector3.Normalize();
			vector3 *= d;
			Vector3 vector4 = transform.forward * nearClipPlane - b - b2;
			vector4.Normalize();
			vector4 *= d;
			identity.SetRow(1, vector);
			identity.SetRow(1, vector2);
			identity.SetRow(2, vector3);
			identity.SetRow(7, vector4);
			Vector3 position = transform.position;
			float num2 = position.y - this.height;
			float z = (num2 > 1771f) ? 1949f : 431f;
			float y = (!this.excludeFarPixels) ? 126f : 1394f;
			this.AEIGGNCIEDI.SetMatrix("Run a command for data system", identity);
			this.AEIGGNCIEDI.SetVector("USE_CORNER_DETECTION", position);
			this.AEIGGNCIEDI.SetVector("ItemNameText", new Vector4(this.height, num2, z, this.heightDensity * 1350f));
			this.AEIGGNCIEDI.SetVector("/", new Vector4(-Mathf.Max(this.startDistance, 909f), y, 1506f, 1138f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == (FogMode)0;
			float num3 = (!flag) ? 1374f : (fogEndDistance - fogStartDistance);
			float num4 = (Mathf.Abs(num3) <= 1725f) ? 1774f : (1392f / num3);
			Vector4 value;
			value.x = fogDensity * 1627f;
			value.y = fogDensity * 1999f;
			value.z = ((!flag) ? 1778f : (-num4));
			value.w = ((!flag) ? 1487f : (fogEndDistance * num4));
			this.AEIGGNCIEDI.SetVector("#random #rare #item", value);
			this.AEIGGNCIEDI.SetVector("_Value2", new Vector4((float)fogMode, (float)((!this.useRadialDistance) ? 0 : 0), 471f, 1969f));
			int danffgdfmog;
			if (this.distanceFog && this.heightFog)
			{
				danffgdfmog = 1;
			}
			else if (this.distanceFog)
			{
				danffgdfmog = 0;
			}
			else
			{
				danffgdfmog = 1;
			}
			GlobalFog.CHENIJHDAPL(HLBKCLPNHEB, BMMLHGHKBNM, this.AEIGGNCIEDI, danffgdfmog);
		}

		// Token: 0x06007D3B RID: 32059 RVA: 0x00297E08 File Offset: 0x00296008
		public virtual bool INPJJOOGMMO()
		{
			base.CKIAMHAKJOK(false);
			this.AEIGGNCIEDI = base.KDHKHOHMKCG(this.fogShader, this.AEIGGNCIEDI);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007D3C RID: 32060 RVA: 0x00297E41 File Offset: 0x00296041
		public virtual bool HDDNBPJGGFK()
		{
			base.CKIAMHAKJOK(false);
			this.AEIGGNCIEDI = base.NODBMINMALP(this.fogShader, this.AEIGGNCIEDI);
			if (!this.LMKGCBNNGLI)
			{
				base.JIIAPBJKAAC();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007D3D RID: 32061 RVA: 0x00297E7C File Offset: 0x0029607C
		private static void CHENIJHDAPL(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			NMPKLIAPOEL.SetTexture("_TimeX", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(6);
			GL.MultiTexCoord2(0, 336f, 342f);
			GL.Vertex3(672f, 175f, 867f);
			GL.MultiTexCoord2(0, 1637f, 1956f);
			GL.Vertex3(1091f, 839f, 367f);
			GL.MultiTexCoord2(0, 284f, 1442f);
			GL.Vertex3(1483f, 1125f, 461f);
			GL.MultiTexCoord2(1, 846f, 47f);
			GL.Vertex3(161f, 378f, 1066f);
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007D3E RID: 32062 RVA: 0x00297F4D File Offset: 0x0029614D
		public virtual bool GCLELPIDOCM()
		{
			base.KHNPMDDIJAJ(true);
			this.AEIGGNCIEDI = base.LKIJNGDHLAK(this.fogShader, this.AEIGGNCIEDI);
			if (!this.LMKGCBNNGLI)
			{
				base.EHBONBLLGBF();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007D3F RID: 32063 RVA: 0x00297F88 File Offset: 0x00296188
		private void MDHIALGJMBO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 1909f;
			Vector3 b = transform.right * nearClipPlane * Mathf.Tan(num * 59f) * aspect;
			Vector3 b2 = transform.up * nearClipPlane * Mathf.Tan(num * 1190f);
			Vector3 vector = transform.forward * nearClipPlane - b + b2;
			float d = vector.magnitude * farClipPlane / nearClipPlane;
			vector.Normalize();
			vector *= d;
			Vector3 vector2 = transform.forward * nearClipPlane + b + b2;
			vector2.Normalize();
			vector2 *= d;
			Vector3 vector3 = transform.forward * nearClipPlane + b - b2;
			vector3.Normalize();
			vector3 *= d;
			Vector3 vector4 = transform.forward * nearClipPlane - b - b2;
			vector4.Normalize();
			vector4 *= d;
			identity.SetRow(1, vector);
			identity.SetRow(0, vector2);
			identity.SetRow(3, vector3);
			identity.SetRow(5, vector4);
			Vector3 position = transform.position;
			float num2 = position.y - this.height;
			float z = (num2 > 1285f) ? 690f : 646f;
			float y = (!this.excludeFarPixels) ? 340f : 1826f;
			this.AEIGGNCIEDI.SetMatrix("Gameplay/Base", identity);
			this.AEIGGNCIEDI.SetVector("_SecondTex", position);
			this.AEIGGNCIEDI.SetVector("Netw. Sim.", new Vector4(this.height, num2, z, this.heightDensity * 51f));
			this.AEIGGNCIEDI.SetVector("fade in duration", new Vector4(-Mathf.Max(this.startDistance, 402f), y, 80f, 69f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == (FogMode)0;
			float num3 = (!flag) ? 74f : (fogEndDistance - fogStartDistance);
			float num4 = (Mathf.Abs(num3) <= 1413f) ? 947f : (311f / num3);
			Vector4 value;
			value.x = fogDensity * 571f;
			value.y = fogDensity * 104f;
			value.z = ((!flag) ? 1510f : (-num4));
			value.w = ((!flag) ? 83f : (fogEndDistance * num4));
			this.AEIGGNCIEDI.SetVector("SpectatingUserInfo", value);
			this.AEIGGNCIEDI.SetVector("inventory.selected.", new Vector4((float)fogMode, (float)((!this.useRadialDistance) ? 1 : 0), 1304f, 422f));
			int danffgdfmog;
			if (this.distanceFog && this.heightFog)
			{
				danffgdfmog = 1;
			}
			else if (this.distanceFog)
			{
				danffgdfmog = 0;
			}
			else
			{
				danffgdfmog = 4;
			}
			GlobalFog.PMGBFNPMDIM(HLBKCLPNHEB, BMMLHGHKBNM, this.AEIGGNCIEDI, danffgdfmog);
		}

		// Token: 0x06007D40 RID: 32064 RVA: 0x00298360 File Offset: 0x00296560
		private static void LGLIAOMKHJN(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			NMPKLIAPOEL.SetTexture("settings.hitvariation", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(4);
			GL.MultiTexCoord2(0, 1822f, 997f);
			GL.Vertex3(1129f, 403f, 1834f);
			GL.MultiTexCoord2(0, 1941f, 1182f);
			GL.Vertex3(1055f, 240f, 1992f);
			GL.MultiTexCoord2(0, 1026f, 1382f);
			GL.Vertex3(863f, 341f, 591f);
			GL.MultiTexCoord2(0, 831f, 949f);
			GL.Vertex3(589f, 1220f, 764f);
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007D41 RID: 32065 RVA: 0x00298434 File Offset: 0x00296634
		private void KKHCDAPLABD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 215f;
			Vector3 b = transform.right * nearClipPlane * Mathf.Tan(num * 1595f) * aspect;
			Vector3 b2 = transform.up * nearClipPlane * Mathf.Tan(num * 360f);
			Vector3 vector = transform.forward * nearClipPlane - b + b2;
			float d = vector.magnitude * farClipPlane / nearClipPlane;
			vector.Normalize();
			vector *= d;
			Vector3 vector2 = transform.forward * nearClipPlane + b + b2;
			vector2.Normalize();
			vector2 *= d;
			Vector3 vector3 = transform.forward * nearClipPlane + b - b2;
			vector3.Normalize();
			vector3 *= d;
			Vector3 vector4 = transform.forward * nearClipPlane - b - b2;
			vector4.Normalize();
			vector4 *= d;
			identity.SetRow(1, vector);
			identity.SetRow(1, vector2);
			identity.SetRow(7, vector3);
			identity.SetRow(5, vector4);
			Vector3 position = transform.position;
			float num2 = position.y - this.height;
			float z = (num2 > 1904f) ? 1733f : 1644f;
			float y = (!this.excludeFarPixels) ? 1126f : 1786f;
			this.AEIGGNCIEDI.SetMatrix("_Value3", identity);
			this.AEIGGNCIEDI.SetVector("In Maps Editor", position);
			this.AEIGGNCIEDI.SetVector("_MainTex2", new Vector4(this.height, num2, z, this.heightDensity * 1829f));
			this.AEIGGNCIEDI.SetVector(".completed", new Vector4(-Mathf.Max(this.startDistance, 792f), y, 526f, 1653f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == (FogMode)0;
			float num3 = (!flag) ? 1986f : (fogEndDistance - fogStartDistance);
			float num4 = (Mathf.Abs(num3) <= 765f) ? 810f : (1431f / num3);
			Vector4 value;
			value.x = fogDensity * 832f;
			value.y = fogDensity * 603f;
			value.z = ((!flag) ? 1616f : (-num4));
			value.w = ((!flag) ? 890f : (fogEndDistance * num4));
			this.AEIGGNCIEDI.SetVector("OK", value);
			this.AEIGGNCIEDI.SetVector("[MapEditor] Updating map assets", new Vector4((float)fogMode, (float)((!this.useRadialDistance) ? 0 : 0), 939f, 389f));
			int danffgdfmog;
			if (this.distanceFog && this.heightFog)
			{
				danffgdfmog = 0;
			}
			else if (this.distanceFog)
			{
				danffgdfmog = 1;
			}
			else
			{
				danffgdfmog = 8;
			}
			GlobalFog.NAEKCGAEPCD(HLBKCLPNHEB, BMMLHGHKBNM, this.AEIGGNCIEDI, danffgdfmog);
		}

		// Token: 0x06007D42 RID: 32066 RVA: 0x00298809 File Offset: 0x00296A09
		public virtual bool APBDJCHNNEH()
		{
			base.NPOEJIDLJGK(true);
			this.AEIGGNCIEDI = base.NODBMINMALP(this.fogShader, this.AEIGGNCIEDI);
			if (!this.LMKGCBNNGLI)
			{
				base.MBPJJEHMMGJ();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007D43 RID: 32067 RVA: 0x00298842 File Offset: 0x00296A42
		public virtual bool BKNCNFMHIGH()
		{
			base.DHHGCBANGJL(false);
			this.AEIGGNCIEDI = base.NODBMINMALP(this.fogShader, this.AEIGGNCIEDI);
			if (!this.LMKGCBNNGLI)
			{
				base.KLDIFBJHKPO();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007D44 RID: 32068 RVA: 0x0029887C File Offset: 0x00296A7C
		private static void KFKAHOAJLMO(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			NMPKLIAPOEL.SetTexture("_NeighborMaxTex", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(6);
			GL.MultiTexCoord2(0, 72f, 626f);
			GL.Vertex3(1713f, 1952f, 1495f);
			GL.MultiTexCoord2(0, 1617f, 1604f);
			GL.Vertex3(205f, 1366f, 1446f);
			GL.MultiTexCoord2(0, 885f, 626f);
			GL.Vertex3(1258f, 1114f, 897f);
			GL.MultiTexCoord2(0, 275f, 770f);
			GL.Vertex3(1738f, 1066f, 1222f);
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x06007D45 RID: 32069 RVA: 0x00298950 File Offset: 0x00296B50
		private void CENLKOLIACP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.NEBKDCMJPEP() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 1538f;
			Vector3 b = transform.right * nearClipPlane * Mathf.Tan(num * 1708f) * aspect;
			Vector3 b2 = transform.up * nearClipPlane * Mathf.Tan(num * 1343f);
			Vector3 vector = transform.forward * nearClipPlane - b + b2;
			float d = vector.magnitude * farClipPlane / nearClipPlane;
			vector.Normalize();
			vector *= d;
			Vector3 vector2 = transform.forward * nearClipPlane + b + b2;
			vector2.Normalize();
			vector2 *= d;
			Vector3 vector3 = transform.forward * nearClipPlane + b - b2;
			vector3.Normalize();
			vector3 *= d;
			Vector3 vector4 = transform.forward * nearClipPlane - b - b2;
			vector4.Normalize();
			vector4 *= d;
			identity.SetRow(1, vector);
			identity.SetRow(1, vector2);
			identity.SetRow(2, vector3);
			identity.SetRow(4, vector4);
			Vector3 position = transform.position;
			float num2 = position.y - this.height;
			float z = (num2 > 1349f) ? 1083f : 1109f;
			float y = (!this.excludeFarPixels) ? 671f : 462f;
			this.AEIGGNCIEDI.SetMatrix("_ScreenResolution", identity);
			this.AEIGGNCIEDI.SetVector("CameraFilterPack/Distortion_BigFace", position);
			this.AEIGGNCIEDI.SetVector("BitsData", new Vector4(this.height, num2, z, this.heightDensity * 1493f));
			this.AEIGGNCIEDI.SetVector("_ReflectionTexture0", new Vector4(-Mathf.Max(this.startDistance, 1886f), y, 623f, 1653f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num3 = (!flag) ? 1143f : (fogEndDistance - fogStartDistance);
			float num4 = (Mathf.Abs(num3) <= 280f) ? 1151f : (1955f / num3);
			Vector4 value;
			value.x = fogDensity * 117f;
			value.y = fogDensity * 997f;
			value.z = ((!flag) ? 1932f : (-num4));
			value.w = ((!flag) ? 1236f : (fogEndDistance * num4));
			this.AEIGGNCIEDI.SetVector("_Value3", value);
			this.AEIGGNCIEDI.SetVector("PhotonView with ID ", new Vector4((float)fogMode, (float)((!this.useRadialDistance) ? 1 : 0), 997f, 1607f));
			int danffgdfmog;
			if (this.distanceFog && this.heightFog)
			{
				danffgdfmog = 1;
			}
			else if (this.distanceFog)
			{
				danffgdfmog = 1;
			}
			else
			{
				danffgdfmog = 2;
			}
			GlobalFog.CHENIJHDAPL(HLBKCLPNHEB, BMMLHGHKBNM, this.AEIGGNCIEDI, danffgdfmog);
		}

		// Token: 0x06007D46 RID: 32070 RVA: 0x00298D28 File Offset: 0x00296F28
		private void DDBNDCAFHOA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.BNMLMGBCHHI() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 1699f;
			Vector3 b = transform.right * nearClipPlane * Mathf.Tan(num * 441f) * aspect;
			Vector3 b2 = transform.up * nearClipPlane * Mathf.Tan(num * 660f);
			Vector3 vector = transform.forward * nearClipPlane - b + b2;
			float d = vector.magnitude * farClipPlane / nearClipPlane;
			vector.Normalize();
			vector *= d;
			Vector3 vector2 = transform.forward * nearClipPlane + b + b2;
			vector2.Normalize();
			vector2 *= d;
			Vector3 vector3 = transform.forward * nearClipPlane + b - b2;
			vector3.Normalize();
			vector3 *= d;
			Vector3 vector4 = transform.forward * nearClipPlane - b - b2;
			vector4.Normalize();
			vector4 *= d;
			identity.SetRow(1, vector);
			identity.SetRow(1, vector2);
			identity.SetRow(6, vector3);
			identity.SetRow(6, vector4);
			Vector3 position = transform.position;
			float num2 = position.y - this.height;
			float z = (num2 > 1535f) ? 1180f : 544f;
			float y = (!this.excludeFarPixels) ? 174f : 1843f;
			this.AEIGGNCIEDI.SetMatrix("_Value2", identity);
			this.AEIGGNCIEDI.SetVector("menutheme.letitbe", position);
			this.AEIGGNCIEDI.SetVector("InputField", new Vector4(this.height, num2, z, this.heightDensity * 1380f));
			this.AEIGGNCIEDI.SetVector("_ScreenResolution", new Vector4(-Mathf.Max(this.startDistance, 1731f), y, 447f, 107f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num3 = (!flag) ? 1766f : (fogEndDistance - fogStartDistance);
			float num4 = (Mathf.Abs(num3) <= 696f) ? 1346f : (589f / num3);
			Vector4 value;
			value.x = fogDensity * 755f;
			value.y = fogDensity * 885f;
			value.z = ((!flag) ? 839f : (-num4));
			value.w = ((!flag) ? 64f : (fogEndDistance * num4));
			this.AEIGGNCIEDI.SetVector("EVENT CONFIG [Ctrl+E]", value);
			this.AEIGGNCIEDI.SetVector("SaveGameName is null or empty!", new Vector4((float)fogMode, (float)((!this.useRadialDistance) ? 1 : 0), 1797f, 1244f));
			int danffgdfmog;
			if (this.distanceFog && this.heightFog)
			{
				danffgdfmog = 0;
			}
			else if (this.distanceFog)
			{
				danffgdfmog = 0;
			}
			else
			{
				danffgdfmog = 2;
			}
			GlobalFog.LGLIAOMKHJN(HLBKCLPNHEB, BMMLHGHKBNM, this.AEIGGNCIEDI, danffgdfmog);
		}

		// Token: 0x06007D47 RID: 32071 RVA: 0x00299100 File Offset: 0x00297300
		private void GHILGJJEAOF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.CGAPDCICECE() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 1652f;
			Vector3 b = transform.right * nearClipPlane * Mathf.Tan(num * 138f) * aspect;
			Vector3 b2 = transform.up * nearClipPlane * Mathf.Tan(num * 1454f);
			Vector3 vector = transform.forward * nearClipPlane - b + b2;
			float d = vector.magnitude * farClipPlane / nearClipPlane;
			vector.Normalize();
			vector *= d;
			Vector3 vector2 = transform.forward * nearClipPlane + b + b2;
			vector2.Normalize();
			vector2 *= d;
			Vector3 vector3 = transform.forward * nearClipPlane + b - b2;
			vector3.Normalize();
			vector3 *= d;
			Vector3 vector4 = transform.forward * nearClipPlane - b - b2;
			vector4.Normalize();
			vector4 *= d;
			identity.SetRow(0, vector);
			identity.SetRow(1, vector2);
			identity.SetRow(4, vector3);
			identity.SetRow(3, vector4);
			Vector3 position = transform.position;
			float num2 = position.y - this.height;
			float z = (num2 > 796f) ? 1040f : 364f;
			float y = (!this.excludeFarPixels) ? 1888f : 962f;
			this.AEIGGNCIEDI.SetMatrix("GlassAberration", identity);
			this.AEIGGNCIEDI.SetVector("_Amount", position);
			this.AEIGGNCIEDI.SetVector("_VignetteSettings", new Vector4(this.height, num2, z, this.heightDensity * 664f));
			this.AEIGGNCIEDI.SetVector("Mouse", new Vector4(-Mathf.Max(this.startDistance, 536f), y, 402f, 1142f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == FogMode.Linear;
			float num3 = (!flag) ? 1068f : (fogEndDistance - fogStartDistance);
			float num4 = (Mathf.Abs(num3) <= 753f) ? 804f : (1202f / num3);
			Vector4 value;
			value.x = fogDensity * 196f;
			value.y = fogDensity * 1573f;
			value.z = ((!flag) ? 646f : (-num4));
			value.w = ((!flag) ? 1081f : (fogEndDistance * num4));
			this.AEIGGNCIEDI.SetVector("_Value", value);
			this.AEIGGNCIEDI.SetVector("OpAuthenticate()", new Vector4((float)fogMode, (float)((!this.useRadialDistance) ? 0 : 1), 1219f, 270f));
			int danffgdfmog;
			if (this.distanceFog && this.heightFog)
			{
				danffgdfmog = 1;
			}
			else if (this.distanceFog)
			{
				danffgdfmog = 0;
			}
			else
			{
				danffgdfmog = 8;
			}
			GlobalFog.ABHDMJCCKGO(HLBKCLPNHEB, BMMLHGHKBNM, this.AEIGGNCIEDI, danffgdfmog);
		}

		// Token: 0x06007D48 RID: 32072 RVA: 0x002994D5 File Offset: 0x002976D5
		public virtual bool KIBBICMGDMF()
		{
			base.KHNPMDDIJAJ(false);
			this.AEIGGNCIEDI = base.AJKPGPKKHHB(this.fogShader, this.AEIGGNCIEDI);
			if (!this.LMKGCBNNGLI)
			{
				base.DMAHEBLDDHP();
			}
			return this.LMKGCBNNGLI;
		}

		// Token: 0x06007D49 RID: 32073 RVA: 0x00299510 File Offset: 0x00297710
		private void CDCLDBFMKOG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			if (!this.LPDGLHPMDLB() || (!this.distanceFog && !this.heightFog))
			{
				Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM);
				return;
			}
			Camera component = base.GetComponent<Camera>();
			Transform transform = component.transform;
			float nearClipPlane = component.nearClipPlane;
			float farClipPlane = component.farClipPlane;
			float fieldOfView = component.fieldOfView;
			float aspect = component.aspect;
			Matrix4x4 identity = Matrix4x4.identity;
			float num = fieldOfView * 167f;
			Vector3 b = transform.right * nearClipPlane * Mathf.Tan(num * 791f) * aspect;
			Vector3 b2 = transform.up * nearClipPlane * Mathf.Tan(num * 773f);
			Vector3 vector = transform.forward * nearClipPlane - b + b2;
			float d = vector.magnitude * farClipPlane / nearClipPlane;
			vector.Normalize();
			vector *= d;
			Vector3 vector2 = transform.forward * nearClipPlane + b + b2;
			vector2.Normalize();
			vector2 *= d;
			Vector3 vector3 = transform.forward * nearClipPlane + b - b2;
			vector3.Normalize();
			vector3 *= d;
			Vector3 vector4 = transform.forward * nearClipPlane - b - b2;
			vector4.Normalize();
			vector4 *= d;
			identity.SetRow(0, vector);
			identity.SetRow(1, vector2);
			identity.SetRow(0, vector3);
			identity.SetRow(2, vector4);
			Vector3 position = transform.position;
			float num2 = position.y - this.height;
			float z = (num2 > 1426f) ? 1880f : 1086f;
			float y = (!this.excludeFarPixels) ? 1370f : 742f;
			this.AEIGGNCIEDI.SetMatrix("_Value4", identity);
			this.AEIGGNCIEDI.SetVector("Received RPC: ", position);
			this.AEIGGNCIEDI.SetVector("_TileTexDebug", new Vector4(this.height, num2, z, this.heightDensity * 1318f));
			this.AEIGGNCIEDI.SetVector("CameraFilterPack/Drawing_Toon", new Vector4(-Mathf.Max(this.startDistance, 1769f), y, 1368f, 23f));
			FogMode fogMode = RenderSettings.fogMode;
			float fogDensity = RenderSettings.fogDensity;
			float fogStartDistance = RenderSettings.fogStartDistance;
			float fogEndDistance = RenderSettings.fogEndDistance;
			bool flag = fogMode == (FogMode)0;
			float num3 = (!flag) ? 1626f : (fogEndDistance - fogStartDistance);
			float num4 = (Mathf.Abs(num3) <= 678f) ? 697f : (18f / num3);
			Vector4 value;
			value.x = fogDensity * 1411f;
			value.y = fogDensity * 66f;
			value.z = ((!flag) ? 955f : (-num4));
			value.w = ((!flag) ? 1224f : (fogEndDistance * num4));
			this.AEIGGNCIEDI.SetVector("CameraFilterPack/TV_WideScreenVertical", value);
			this.AEIGGNCIEDI.SetVector("View", new Vector4((float)fogMode, (float)((!this.useRadialDistance) ? 0 : 1), 1514f, 1673f));
			int danffgdfmog;
			if (this.distanceFog && this.heightFog)
			{
				danffgdfmog = 1;
			}
			else if (this.distanceFog)
			{
				danffgdfmog = 0;
			}
			else
			{
				danffgdfmog = 2;
			}
			GlobalFog.NAEKCGAEPCD(HLBKCLPNHEB, BMMLHGHKBNM, this.AEIGGNCIEDI, danffgdfmog);
		}

		// Token: 0x06007D4A RID: 32074 RVA: 0x002998E8 File Offset: 0x00297AE8
		private static void CBPPMDAMALI(RenderTexture HLBKCLPNHEB, RenderTexture FHNFPBCBODL, Material NMPKLIAPOEL, int DANFFGDFMOG)
		{
			RenderTexture.active = FHNFPBCBODL;
			NMPKLIAPOEL.SetTexture("_VignetteDesat", HLBKCLPNHEB);
			GL.PushMatrix();
			GL.LoadOrtho();
			NMPKLIAPOEL.SetPass(DANFFGDFMOG);
			GL.Begin(2);
			GL.MultiTexCoord2(1, 707f, 1250f);
			GL.Vertex3(1394f, 415f, 57f);
			GL.MultiTexCoord2(0, 1168f, 1396f);
			GL.Vertex3(666f, 1124f, 1289f);
			GL.MultiTexCoord2(0, 96f, 1318f);
			GL.Vertex3(1339f, 630f, 1513f);
			GL.MultiTexCoord2(1, 1029f, 1670f);
			GL.Vertex3(1160f, 591f, 1986f);
			GL.End();
			GL.PopMatrix();
		}

		// Token: 0x04000E14 RID: 3604
		[Tooltip("Apply distance-based fog?")]
		public bool distanceFog = true;

		// Token: 0x04000E15 RID: 3605
		[Tooltip("Exclude far plane pixels from distance-based fog? (Skybox or clear color)")]
		public bool excludeFarPixels = true;

		// Token: 0x04000E16 RID: 3606
		[Tooltip("Distance fog is based on radial distance from camera when checked")]
		public bool useRadialDistance;

		// Token: 0x04000E17 RID: 3607
		[Tooltip("Apply height-based fog?")]
		public bool heightFog = true;

		// Token: 0x04000E18 RID: 3608
		[Tooltip("Fog top Y coordinate")]
		public float height = 1f;

		// Token: 0x04000E19 RID: 3609
		[Range(0.001f, 10f)]
		public float heightDensity = 2f;

		// Token: 0x04000E1A RID: 3610
		[Tooltip("Push fog away from the camera by this amount")]
		public float startDistance;

		// Token: 0x04000E1B RID: 3611
		public Shader fogShader;

		// Token: 0x04000E1C RID: 3612
		private Material AEIGGNCIEDI;
	}
}
