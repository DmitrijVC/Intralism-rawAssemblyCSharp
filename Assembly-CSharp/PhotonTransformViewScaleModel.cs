using System;

// Token: 0x0200033A RID: 826
[Serializable]
public class PhotonTransformViewScaleModel
{
	// Token: 0x040015FA RID: 5626
	public bool SynchronizeEnabled;

	// Token: 0x040015FB RID: 5627
	public PhotonTransformViewScaleModel.InterpolateOptions InterpolateOption;

	// Token: 0x040015FC RID: 5628
	public float InterpolateMoveTowardsSpeed = 1f;

	// Token: 0x040015FD RID: 5629
	public float InterpolateLerpSpeed;

	// Token: 0x0200033B RID: 827
	public enum InterpolateOptions
	{
		// Token: 0x040015FF RID: 5631
		Disabled,
		// Token: 0x04001600 RID: 5632
		MoveTowards,
		// Token: 0x04001601 RID: 5633
		Lerp
	}
}
