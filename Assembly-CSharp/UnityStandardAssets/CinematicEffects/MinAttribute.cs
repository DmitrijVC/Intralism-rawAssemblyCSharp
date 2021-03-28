using System;
using UnityEngine;

namespace UnityStandardAssets.CinematicEffects
{
	// Token: 0x020001B0 RID: 432
	public sealed class MinAttribute : PropertyAttribute
	{
		// Token: 0x060077D6 RID: 30678 RVA: 0x002490E8 File Offset: 0x002472E8
		public MinAttribute(float IFNAPFNEGMP)
		{
			this.min = IFNAPFNEGMP;
		}

		// Token: 0x04000C4F RID: 3151
		public readonly float min;
	}
}
