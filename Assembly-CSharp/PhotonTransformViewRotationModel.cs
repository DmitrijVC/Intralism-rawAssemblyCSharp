using System;

// Token: 0x02000337 RID: 823
[Serializable]
public class PhotonTransformViewRotationModel
{
	// Token: 0x040015F0 RID: 5616
	public bool SynchronizeEnabled;

	// Token: 0x040015F1 RID: 5617
	public PhotonTransformViewRotationModel.InterpolateOptions InterpolateOption = PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards;

	// Token: 0x040015F2 RID: 5618
	public float InterpolateRotateTowardsSpeed = 180f;

	// Token: 0x040015F3 RID: 5619
	public float InterpolateLerpSpeed = 5f;

	// Token: 0x02000338 RID: 824
	public enum InterpolateOptions
	{
		// Token: 0x040015F5 RID: 5621
		Disabled,
		// Token: 0x040015F6 RID: 5622
		RotateTowards,
		// Token: 0x040015F7 RID: 5623
		Lerp
	}
}
