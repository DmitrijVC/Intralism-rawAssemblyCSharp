using System;
using ExitGames.Client.Photon;

// Token: 0x02000358 RID: 856
public static class ScoreExtensions
{
	// Token: 0x0600C0E3 RID: 49379 RVA: 0x00464DB4 File Offset: 0x00462FB4
	public static void SetScore(this PhotonPlayer JHOEDACNNKK, int PNOFOOIOBLC)
	{
		Hashtable hashtable = new Hashtable();
		hashtable["score"] = PNOFOOIOBLC;
		JHOEDACNNKK.SetCustomProperties(hashtable, null, false);
	}

	// Token: 0x0600C0E4 RID: 49380 RVA: 0x00464DE4 File Offset: 0x00462FE4
	public static void AddScore(this PhotonPlayer JHOEDACNNKK, int GBOEHKKHOEB)
	{
		int num = JHOEDACNNKK.GetScore();
		num += GBOEHKKHOEB;
		Hashtable hashtable = new Hashtable();
		hashtable["score"] = num;
		JHOEDACNNKK.SetCustomProperties(hashtable, null, false);
	}

	// Token: 0x0600C0E5 RID: 49381 RVA: 0x00464E1C File Offset: 0x0046301C
	public static int GetScore(this PhotonPlayer JHOEDACNNKK)
	{
		object obj;
		if (JHOEDACNNKK.CustomProperties.TryGetValue("score", out obj))
		{
			return (int)obj;
		}
		return 0;
	}
}
