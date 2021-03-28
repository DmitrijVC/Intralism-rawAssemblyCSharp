using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002BA RID: 698
	public static class ScrollRectExtensions
	{
		// Token: 0x0600A755 RID: 42837 RVA: 0x003E2305 File Offset: 0x003E0505
		public static void ScrollToTop(this ScrollRect GIGHNDOLPBN)
		{
			GIGHNDOLPBN.normalizedPosition = new Vector2(0f, 1f);
		}

		// Token: 0x0600A756 RID: 42838 RVA: 0x003E231C File Offset: 0x003E051C
		public static void ScrollToBottom(this ScrollRect GIGHNDOLPBN)
		{
			GIGHNDOLPBN.normalizedPosition = new Vector2(0f, 0f);
		}
	}
}
