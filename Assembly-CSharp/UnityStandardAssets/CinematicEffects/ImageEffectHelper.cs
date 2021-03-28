using System;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x020001AF RID: 431
	public static class ImageEffectHelper
	{
		// Token: 0x060077D3 RID: 30675 RVA: 0x00248FE8 File Offset: 0x002471E8
		public static bool IsSupported(Shader BDIMLMKEEKO, bool EJPNCEPNNPI, bool BCCBAPNLBDD, MonoBehaviour OKAJMIEAKOE)
		{
			if (BDIMLMKEEKO == null || !BDIMLMKEEKO.isSupported)
			{
				Debug.LogWarningFormat("Missing shader for image effect {0}", new object[]
				{
					OKAJMIEAKOE
				});
				return false;
			}
			if (!SystemInfo.supportsImageEffects || !SystemInfo.supportsRenderTextures)
			{
				Debug.LogWarningFormat("Image effects aren't supported on this device ({0})", new object[]
				{
					OKAJMIEAKOE
				});
				return false;
			}
			if (EJPNCEPNNPI && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.Depth))
			{
				Debug.LogWarningFormat("Depth textures aren't supported on this device ({0})", new object[]
				{
					OKAJMIEAKOE
				});
				return false;
			}
			if (BCCBAPNLBDD && !SystemInfo.SupportsRenderTextureFormat(RenderTextureFormat.ARGBHalf))
			{
				Debug.LogWarningFormat("Floating point textures aren't supported on this device ({0})", new object[]
				{
					OKAJMIEAKOE
				});
				return false;
			}
			return true;
		}

		// Token: 0x060077D4 RID: 30676 RVA: 0x0024909C File Offset: 0x0024729C
		public static Material CheckShaderAndCreateMaterial(Shader BDIMLMKEEKO)
		{
			if (BDIMLMKEEKO == null || !BDIMLMKEEKO.isSupported)
			{
				return null;
			}
			return new Material(BDIMLMKEEKO)
			{
				hideFlags = HideFlags.DontSave
			};
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060077D5 RID: 30677 RVA: 0x002490D2 File Offset: 0x002472D2
		public static bool supportsDX11
		{
			get
			{
				return SystemInfo.graphicsShaderLevel >= 50 && SystemInfo.supportsComputeShaders;
			}
		}
	}
}
