using System;
using System.Collections.Generic;

// Token: 0x0200048D RID: 1165
public class EditorEventFunctionInfo
{
	// Token: 0x06010B3E RID: 68414 RVA: 0x005A9480 File Offset: 0x005A7680
	public EditorEventFunctionInfo(string JMMILEFMACB, string EGIHIANBIGB, List<EditorEventFunctionInfo.EditorEventParametr> GNNEKCBOBEG, string GJHPCNJOJFL, int JGCKIJCMMNB = 1, int BAGGOBLDDMK = -1, EditorEventFunctionInfo.EditorEventType PPJDFMLJIGN = EditorEventFunctionInfo.EditorEventType.Storyboard)
	{
		this.id = JMMILEFMACB;
		this.functionName = EGIHIANBIGB;
		this.parameters = GNNEKCBOBEG;
		this.functionDescription = GJHPCNJOJFL;
		this.minConfigVersion = JGCKIJCMMNB;
		this.maxConfigVersion = BAGGOBLDDMK;
		this.eventType = PPJDFMLJIGN;
	}

	// Token: 0x04001D3E RID: 7486
	public List<EditorEventFunctionInfo.EditorEventParametr> parameters;

	// Token: 0x04001D3F RID: 7487
	public string id;

	// Token: 0x04001D40 RID: 7488
	public string functionName;

	// Token: 0x04001D41 RID: 7489
	public string functionDescription;

	// Token: 0x04001D42 RID: 7490
	public int minConfigVersion;

	// Token: 0x04001D43 RID: 7491
	public int maxConfigVersion = -1;

	// Token: 0x04001D44 RID: 7492
	public EditorEventFunctionInfo.EditorEventType eventType = EditorEventFunctionInfo.EditorEventType.Storyboard;

	// Token: 0x0200048E RID: 1166
	public enum EditorEventParametrType
	{
		// Token: 0x04001D46 RID: 7494
		InputField,
		// Token: 0x04001D47 RID: 7495
		Slider,
		// Token: 0x04001D48 RID: 7496
		Toggle,
		// Token: 0x04001D49 RID: 7497
		ArcSelector
	}

	// Token: 0x0200048F RID: 1167
	public enum EditorEventType
	{
		// Token: 0x04001D4B RID: 7499
		Arcs,
		// Token: 0x04001D4C RID: 7500
		Storyboard
	}

	// Token: 0x02000490 RID: 1168
	public class EditorEventParametr
	{
		// Token: 0x06010B3F RID: 68415 RVA: 0x005A94D6 File Offset: 0x005A76D6
		public EditorEventParametr(string EBEHBBDKDFJ, EditorEventFunctionInfo.EditorEventParametrType EBCIFDLBHJJ, string ADLFGFFKELL, string NOJGGCLPPAM = null)
		{
			this.name = EBEHBBDKDFJ;
			this.editor = EBCIFDLBHJJ;
			this.description = ADLFGFFKELL;
			this.data = NOJGGCLPPAM;
		}

		// Token: 0x04001D4D RID: 7501
		public string name;

		// Token: 0x04001D4E RID: 7502
		public EditorEventFunctionInfo.EditorEventParametrType editor;

		// Token: 0x04001D4F RID: 7503
		public string description;

		// Token: 0x04001D50 RID: 7504
		public string data;
	}
}
