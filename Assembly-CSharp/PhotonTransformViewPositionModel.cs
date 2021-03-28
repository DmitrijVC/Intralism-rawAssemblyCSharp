using System;
using UnityEngine;

// Token: 0x02000333 RID: 819
[Serializable]
public class PhotonTransformViewPositionModel
{
	// Token: 0x040015D5 RID: 5589
	public bool SynchronizeEnabled;

	// Token: 0x040015D6 RID: 5590
	public bool TeleportEnabled = true;

	// Token: 0x040015D7 RID: 5591
	public float TeleportIfDistanceGreaterThan = 3f;

	// Token: 0x040015D8 RID: 5592
	public PhotonTransformViewPositionModel.InterpolateOptions InterpolateOption = PhotonTransformViewPositionModel.InterpolateOptions.EstimatedSpeed;

	// Token: 0x040015D9 RID: 5593
	public float InterpolateMoveTowardsSpeed = 1f;

	// Token: 0x040015DA RID: 5594
	public float InterpolateLerpSpeed = 1f;

	// Token: 0x040015DB RID: 5595
	public float InterpolateMoveTowardsAcceleration = 2f;

	// Token: 0x040015DC RID: 5596
	public float InterpolateMoveTowardsDeceleration = 2f;

	// Token: 0x040015DD RID: 5597
	public AnimationCurve InterpolateSpeedCurve = new AnimationCurve(new Keyframe[]
	{
		new Keyframe(-1f, 0f, 0f, float.PositiveInfinity),
		new Keyframe(0f, 1f, 0f, 0f),
		new Keyframe(1f, 1f, 0f, 1f),
		new Keyframe(4f, 4f, 1f, 0f)
	});

	// Token: 0x040015DE RID: 5598
	public PhotonTransformViewPositionModel.ExtrapolateOptions ExtrapolateOption;

	// Token: 0x040015DF RID: 5599
	public float ExtrapolateSpeed = 1f;

	// Token: 0x040015E0 RID: 5600
	public bool ExtrapolateIncludingRoundTripTime = true;

	// Token: 0x040015E1 RID: 5601
	public int ExtrapolateNumberOfStoredPositions = 1;

	// Token: 0x040015E2 RID: 5602
	public bool DrawErrorGizmo = true;

	// Token: 0x02000334 RID: 820
	public enum InterpolateOptions
	{
		// Token: 0x040015E4 RID: 5604
		Disabled,
		// Token: 0x040015E5 RID: 5605
		FixedSpeed,
		// Token: 0x040015E6 RID: 5606
		EstimatedSpeed,
		// Token: 0x040015E7 RID: 5607
		SynchronizeValues,
		// Token: 0x040015E8 RID: 5608
		Lerp
	}

	// Token: 0x02000335 RID: 821
	public enum ExtrapolateOptions
	{
		// Token: 0x040015EA RID: 5610
		Disabled,
		// Token: 0x040015EB RID: 5611
		SynchronizeValues,
		// Token: 0x040015EC RID: 5612
		EstimateSpeedAndTurn,
		// Token: 0x040015ED RID: 5613
		FixedSpeed
	}
}
