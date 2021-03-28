using System;

// Token: 0x020003DF RID: 991
public class QuieryObject
{
	// Token: 0x0600E153 RID: 57683 RVA: 0x005124E0 File Offset: 0x005106E0
	public QuieryObject(float ALDMCPOIBCF)
	{
		this.atTime = ALDMCPOIBCF;
	}

	// Token: 0x0400197B RID: 6523
	public float atTime;

	// Token: 0x0400197C RID: 6524
	public bool spawned;

	// Token: 0x020003E0 RID: 992
	public enum Position
	{
		// Token: 0x0400197E RID: 6526
		Left,
		// Token: 0x0400197F RID: 6527
		Right,
		// Token: 0x04001980 RID: 6528
		Up,
		// Token: 0x04001981 RID: 6529
		Down
	}
}
