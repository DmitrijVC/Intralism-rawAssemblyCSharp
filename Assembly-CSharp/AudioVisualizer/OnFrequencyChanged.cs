using System;

namespace AudioVisualizer
{
	// Token: 0x02000003 RID: 3
	[Serializable]
	public class OnFrequencyChanged
	{
		// Token: 0x04000001 RID: 1
		public OnFrequencyEvent onChange;

		// Token: 0x04000002 RID: 2
		public float minValue;

		// Token: 0x04000003 RID: 3
		public float maxValue = 1f;
	}
}
