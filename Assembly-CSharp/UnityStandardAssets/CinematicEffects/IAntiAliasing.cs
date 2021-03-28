using System;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x020001A1 RID: 417
	public interface IAntiAliasing
	{
		// Token: 0x0600761E RID: 30238
		void OnEnable(AntiAliasing DNFGMNFCBGA);

		// Token: 0x0600761F RID: 30239
		void OnDisable();

		// Token: 0x06007620 RID: 30240
		void OnPreCull(Camera CPHDLGANKHG);

		// Token: 0x06007621 RID: 30241
		void OnPostRender(Camera CPHDLGANKHG);

		// Token: 0x06007622 RID: 30242
		void OnRenderImage(Camera CPHDLGANKHG, RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM);
	}
}
