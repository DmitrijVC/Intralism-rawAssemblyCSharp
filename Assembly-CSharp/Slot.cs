using System;
using UnityEngine;

// Token: 0x020003E1 RID: 993
[Serializable]
public class Slot
{
	// Token: 0x0600E154 RID: 57684 RVA: 0x005124EF File Offset: 0x005106EF
	public Slot(GameObject OBFJPHLBFOL, QuieryObject.Position JOPCODOJBHD, bool OGGJHDKMPPD, int AAMOLMGLPKB)
	{
		this.go = OBFJPHLBFOL;
		this.position = JOPCODOJBHD;
		this.isFree = OGGJHDKMPPD;
		this.timeLeft = (float)AAMOLMGLPKB;
	}

	// Token: 0x04001982 RID: 6530
	public GameObject go;

	// Token: 0x04001983 RID: 6531
	public QuieryObject.Position position;

	// Token: 0x04001984 RID: 6532
	public bool isFree;

	// Token: 0x04001985 RID: 6533
	public float timeLeft;
}
