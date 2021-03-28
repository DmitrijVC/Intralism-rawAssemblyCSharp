using System;

// Token: 0x02000506 RID: 1286
public static class BuildConstants
{
	// Token: 0x040020F7 RID: 8439
	public static readonly DateTime buildDate = new DateTime(637306159274859783L);

	// Token: 0x040020F8 RID: 8440
	public const string version = "5.5.2.5008";

	// Token: 0x040020F9 RID: 8441
	public const BuildConstants.ReleaseType releaseType = BuildConstants.ReleaseType.Release;

	// Token: 0x040020FA RID: 8442
	public const BuildConstants.Platform platform = BuildConstants.Platform.PC;

	// Token: 0x040020FB RID: 8443
	public const BuildConstants.Architecture architecture = BuildConstants.Architecture.Windows_x64;

	// Token: 0x040020FC RID: 8444
	public const BuildConstants.Distribution distribution = BuildConstants.Distribution.None;

	// Token: 0x02000507 RID: 1287
	public enum ReleaseType
	{
		// Token: 0x040020FE RID: 8446
		None,
		// Token: 0x040020FF RID: 8447
		Debug,
		// Token: 0x04002100 RID: 8448
		Release
	}

	// Token: 0x02000508 RID: 1288
	public enum Platform
	{
		// Token: 0x04002102 RID: 8450
		None,
		// Token: 0x04002103 RID: 8451
		Linux,
		// Token: 0x04002104 RID: 8452
		OSX,
		// Token: 0x04002105 RID: 8453
		PC
	}

	// Token: 0x02000509 RID: 1289
	public enum Architecture
	{
		// Token: 0x04002107 RID: 8455
		None,
		// Token: 0x04002108 RID: 8456
		Linux_Universal,
		// Token: 0x04002109 RID: 8457
		OSX_Universal,
		// Token: 0x0400210A RID: 8458
		Windows_x86,
		// Token: 0x0400210B RID: 8459
		Windows_x64
	}

	// Token: 0x0200050A RID: 1290
	public enum Distribution
	{
		// Token: 0x0400210D RID: 8461
		None
	}
}
