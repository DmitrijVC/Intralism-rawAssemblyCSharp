using System;

// Token: 0x0200035D RID: 861
public interface IPunTurnManagerCallbacks
{
	// Token: 0x0600C1A8 RID: 49576
	void OnTurnBegins(int JPFFPMDKAMC);

	// Token: 0x0600C1A9 RID: 49577
	void OnTurnCompleted(int JPFFPMDKAMC);

	// Token: 0x0600C1AA RID: 49578
	void OnPlayerMove(PhotonPlayer JHOEDACNNKK, int JPFFPMDKAMC, object HNOKMIIDHHH);

	// Token: 0x0600C1AB RID: 49579
	void OnPlayerFinished(PhotonPlayer JHOEDACNNKK, int JPFFPMDKAMC, object HNOKMIIDHHH);

	// Token: 0x0600C1AC RID: 49580
	void OnTurnTimeEnds(int JPFFPMDKAMC);
}
