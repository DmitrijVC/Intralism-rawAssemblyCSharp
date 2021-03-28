using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200029C RID: 668
	public interface IBoxSelectable
	{
		// Token: 0x17000211 RID: 529
		// (get) Token: 0x0600A0F8 RID: 41208
		// (set) Token: 0x0600A0F9 RID: 41209
		bool selected { get; set; }

		// Token: 0x17000212 RID: 530
		// (get) Token: 0x0600A0FA RID: 41210
		// (set) Token: 0x0600A0FB RID: 41211
		bool preSelected { get; set; }

		// Token: 0x17000213 RID: 531
		// (get) Token: 0x0600A0FC RID: 41212
		Transform transform { get; }
	}
}
