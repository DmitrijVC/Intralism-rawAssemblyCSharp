using System;
using ExitGames.Client.Photon;
using UnityEngine;

// Token: 0x0200035B RID: 859
public static class TeamExtensions
{
	// Token: 0x0600C13B RID: 49467 RVA: 0x00465EE0 File Offset: 0x004640E0
	public static PunTeams.Team GetTeam(this PhotonPlayer JHOEDACNNKK)
	{
		object obj;
		if (JHOEDACNNKK.CustomProperties.TryGetValue("team", out obj))
		{
			return (PunTeams.Team)obj;
		}
		return PunTeams.Team.none;
	}

	// Token: 0x0600C13C RID: 49468 RVA: 0x00465F0C File Offset: 0x0046410C
	public static void SetTeam(this PhotonPlayer JHOEDACNNKK, PunTeams.Team DEIIIPLIPPF)
	{
		if (!PhotonNetwork.connectedAndReady)
		{
			Debug.LogWarning("JoinTeam was called in state: " + PhotonNetwork.connectionStateDetailed + ". Not connectedAndReady.");
			return;
		}
		PunTeams.Team team = JHOEDACNNKK.GetTeam();
		if (team != DEIIIPLIPPF)
		{
			JHOEDACNNKK.SetCustomProperties(new Hashtable
			{
				{
					"team",
					(byte)DEIIIPLIPPF
				}
			}, null, false);
		}
	}
}
