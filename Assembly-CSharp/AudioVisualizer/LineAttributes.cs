using System;
using UnityEngine;

namespace AudioVisualizer
{
	// Token: 0x0200000C RID: 12
	[Serializable]
	public class LineAttributes
	{
		// Token: 0x0400004C RID: 76
		public Material lineMat;

		// Token: 0x0400004D RID: 77
		public Color startColor = Color.cyan;

		// Token: 0x0400004E RID: 78
		public Color endColor = Color.magenta;

		// Token: 0x0400004F RID: 79
		public float startWidth = 0.1f;

		// Token: 0x04000050 RID: 80
		public float endWidth = 0.1f;

		// Token: 0x04000051 RID: 81
		public int lineSegments = 36;
	}
}
