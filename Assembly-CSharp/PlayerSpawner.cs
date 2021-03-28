using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020003E3 RID: 995
public class PlayerSpawner : MonoBehaviour
{
	// Token: 0x0600E1A5 RID: 57765 RVA: 0x005134A8 File Offset: 0x005116A8
	public GameObject IKHKPEGCGDH(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 1;
		}
		GameObject gameObject = TrashMan.spawn(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(this.pbase.playerController.objects[KEMDFEFBIOC].transform);
		if (gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = true;
		}
		if (gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = true;
		}
		if (gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().ALKBNPMCEOM(this.pbase);
		}
		if (gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().EJLKPLOEEEP();
		}
		return gameObject;
	}

	// Token: 0x0600E1A6 RID: 57766 RVA: 0x00513564 File Offset: 0x00511764
	public void IJABOLGOAJJ(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && this.pbase.fullLevelData.mapData.handCount == 5)
		{
			KEMDFEFBIOC = 8;
		}
		GameObject gameObject = this.KEDHNCEBKLE(FKCMGBMNNKA, this.spawnPoints[KEMDFEFBIOC].transform.position, this.spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 1583f;
	}

	// Token: 0x0600E1A7 RID: 57767 RVA: 0x005135F0 File Offset: 0x005117F0
	public void AHGKNDNNELO(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && this.pbase.fullLevelData.mapData.handCount == 6)
		{
			KEMDFEFBIOC = 5;
		}
		GameObject gameObject = this.FGDMJCCNMMO(FKCMGBMNNKA, this.spawnPoints[KEMDFEFBIOC].transform.position, this.spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - this.pbase.GetGameScene().HPAnimationTime);
	}

	// Token: 0x0600E1A8 RID: 57768 RVA: 0x0051368C File Offset: 0x0051188C
	public GameObject BMBEHOMJAJB(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = TrashMan.BGNBCDOHBNC(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(this.pbase.playerController.objects[KEMDFEFBIOC].transform);
		if (gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = false;
		}
		if (gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = false;
		}
		if (gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().CAJFKNFJEKC(this.pbase);
		}
		if (gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().EJLKPLOEEEP();
		}
		return gameObject;
	}

	// Token: 0x0600E1A9 RID: 57769 RVA: 0x00513748 File Offset: 0x00511948
	public GameObject JBGFPBGCNLO(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 1;
		}
		GameObject gameObject = TrashMan.BGNBCDOHBNC(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(this.pbase.playerController.objects[KEMDFEFBIOC].transform);
		if (gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = true;
		}
		if (gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = true;
		}
		if (gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().EOPEMLDJAAO(this.pbase);
		}
		if (gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().FIMJABKECNG();
		}
		return gameObject;
	}

	// Token: 0x0600E1AA RID: 57770 RVA: 0x00513804 File Offset: 0x00511A04
	public GameObject DAJAIPNDNJO(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = TrashMan.BGNBCDOHBNC(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(this.pbase.playerController.objects[KEMDFEFBIOC].transform);
		if (gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = false;
		}
		if (gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = false;
		}
		if (gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().KJBJBNGJDAD(this.pbase);
		}
		if (gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().LCKKDMKJJEF();
		}
		return gameObject;
	}

	// Token: 0x0600E1AB RID: 57771 RVA: 0x005138C0 File Offset: 0x00511AC0
	public void ELJCIMPOEPL(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && this.pbase.fullLevelData.mapData.handCount == 5)
		{
			KEMDFEFBIOC = 2;
		}
		GameObject gameObject = this.DGDDKLNFJDI(FKCMGBMNNKA, this.spawnPoints[KEMDFEFBIOC].transform.position, this.spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 1521f;
	}

	// Token: 0x0600E1AC RID: 57772 RVA: 0x0051394C File Offset: 0x00511B4C
	public GameObject PGKPDOKAKPB(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = TrashMan.spawn(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(this.pbase.playerController.objects[KEMDFEFBIOC].transform);
		if (gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = false;
		}
		if (gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = true;
		}
		if (gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().PAFMNAIDAFH(this.pbase);
		}
		if (gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().Init();
		}
		return gameObject;
	}

	// Token: 0x0600E1AD RID: 57773 RVA: 0x00513A08 File Offset: 0x00511C08
	public void LEPDOCHGDLE(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && this.pbase.fullLevelData.mapData.handCount == 4)
		{
			KEMDFEFBIOC = 5;
		}
		GameObject gameObject = this.AJNCBGCPIIF(FKCMGBMNNKA, this.spawnPoints[KEMDFEFBIOC].transform.position, this.spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 591f;
	}

	// Token: 0x0600E1AE RID: 57774 RVA: 0x00513A94 File Offset: 0x00511C94
	public GameObject AJNCBGCPIIF(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 1;
		}
		GameObject gameObject = TrashMan.spawn(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(this.pbase.playerController.objects[KEMDFEFBIOC].transform);
		if (gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = true;
		}
		if (gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = true;
		}
		if (gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().CFKJHLOEDFO(this.pbase);
		}
		if (gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().EMOCEKPLGBK();
		}
		return gameObject;
	}

	// Token: 0x0600E1AF RID: 57775 RVA: 0x0002523B File Offset: 0x0002343B
	public void GCNKIJDNPMD()
	{
	}

	// Token: 0x0600E1B0 RID: 57776 RVA: 0x00513B50 File Offset: 0x00511D50
	public void DKEIFPBDDEG(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && this.pbase.fullLevelData.mapData.handCount == 8)
		{
			KEMDFEFBIOC = 1;
		}
		GameObject gameObject = this.AJNCBGCPIIF(FKCMGBMNNKA, this.spawnPoints[KEMDFEFBIOC].transform.position, this.spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 684f;
	}

	// Token: 0x0600E1B1 RID: 57777 RVA: 0x00513BDC File Offset: 0x00511DDC
	public GameObject DGDDKLNFJDI(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = TrashMan.spawn(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(this.pbase.playerController.objects[KEMDFEFBIOC].transform);
		if (gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = true;
		}
		if (gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = true;
		}
		if (gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().PFMJPIJONIP(this.pbase);
		}
		if (gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().PIEPPKMBJHI();
		}
		return gameObject;
	}

	// Token: 0x0600E1B2 RID: 57778 RVA: 0x00513C98 File Offset: 0x00511E98
	public void MNDBJHPIOCH(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && this.pbase.fullLevelData.mapData.handCount == 2)
		{
			KEMDFEFBIOC = 2;
		}
		GameObject gameObject = this.MECJANHJKJN(FKCMGBMNNKA, this.spawnPoints[KEMDFEFBIOC].transform.position, this.spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - this.pbase.GetGameScene().PJHGHEKLOCH());
	}

	// Token: 0x0600E1B3 RID: 57779 RVA: 0x00513D34 File Offset: 0x00511F34
	public void OIICDOCKJLJ(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && this.pbase.fullLevelData.mapData.handCount == 8)
		{
			KEMDFEFBIOC = 2;
		}
		GameObject gameObject = this.BMBEHOMJAJB(FKCMGBMNNKA, this.spawnPoints[KEMDFEFBIOC].transform.position, this.spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - this.pbase.GetGameScene().EIFMOHOFICD());
	}

	// Token: 0x0600E1B4 RID: 57780 RVA: 0x00513DD0 File Offset: 0x00511FD0
	public void Spawn(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && this.pbase.fullLevelData.mapData.handCount == 2)
		{
			KEMDFEFBIOC = 2;
		}
		GameObject gameObject = this.SpawnAndReturn(FKCMGBMNNKA, this.spawnPoints[KEMDFEFBIOC].transform.position, this.spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - this.pbase.GetGameScene().HPAnimationTime);
	}

	// Token: 0x0600E1B5 RID: 57781 RVA: 0x00513E6C File Offset: 0x0051206C
	public GameObject BMNLJGKJCMK(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 1;
		}
		GameObject gameObject = TrashMan.BGNBCDOHBNC(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(this.pbase.playerController.objects[KEMDFEFBIOC].transform);
		if (gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = false;
		}
		if (gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = false;
		}
		if (gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().LLAHPNGMEOO(this.pbase);
		}
		if (gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().LLAHPNGMEOO();
		}
		return gameObject;
	}

	// Token: 0x0600E1B6 RID: 57782 RVA: 0x00513F28 File Offset: 0x00512128
	public GameObject KEDHNCEBKLE(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 1;
		}
		GameObject gameObject = TrashMan.spawn(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(this.pbase.playerController.objects[KEMDFEFBIOC].transform);
		if (gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = true;
		}
		if (gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = false;
		}
		if (gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().LBICLFNOLAK(this.pbase);
		}
		if (gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().HBKEHHCMMBN();
		}
		return gameObject;
	}

	// Token: 0x0600E1B7 RID: 57783 RVA: 0x00513FE4 File Offset: 0x005121E4
	public void APOAKNCELIN(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && this.pbase.fullLevelData.mapData.handCount == 1)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = this.DAJAIPNDNJO(FKCMGBMNNKA, this.spawnPoints[KEMDFEFBIOC].transform.position, this.spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - this.pbase.DCLNDDJJJMA().PJHGHEKLOCH());
	}

	// Token: 0x0600E1B8 RID: 57784 RVA: 0x00514080 File Offset: 0x00512280
	public void SpawnWithCureentSpeed(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && this.pbase.fullLevelData.mapData.handCount == 2)
		{
			KEMDFEFBIOC = 2;
		}
		GameObject gameObject = this.SpawnAndReturn(FKCMGBMNNKA, this.spawnPoints[KEMDFEFBIOC].transform.position, this.spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + -1.5f;
	}

	// Token: 0x0600E1B9 RID: 57785 RVA: 0x0002523B File Offset: 0x0002343B
	public void FECMEIJGLJI()
	{
	}

	// Token: 0x0600E1BA RID: 57786 RVA: 0x0002523B File Offset: 0x0002343B
	public void ALKBNPMCEOM()
	{
	}

	// Token: 0x0600E1BB RID: 57787 RVA: 0x0002523B File Offset: 0x0002343B
	public void LLAHPNGMEOO()
	{
	}

	// Token: 0x0600E1BC RID: 57788 RVA: 0x0051410C File Offset: 0x0051230C
	public GameObject DCANBOAFPMB(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = TrashMan.BGNBCDOHBNC(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(this.pbase.playerController.objects[KEMDFEFBIOC].transform);
		if (gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = true;
		}
		if (gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = true;
		}
		if (gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().CPFOEFKOJGA(this.pbase);
		}
		if (gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().PIEPPKMBJHI();
		}
		return gameObject;
	}

	// Token: 0x0600E1BD RID: 57789 RVA: 0x005141C8 File Offset: 0x005123C8
	public GameObject SpawnAndReturn(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 1;
		}
		GameObject gameObject = TrashMan.spawn(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(this.pbase.playerController.objects[KEMDFEFBIOC].transform);
		if (gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = true;
		}
		if (gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = true;
		}
		if (gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().Init(this.pbase);
		}
		if (gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().Init();
		}
		return gameObject;
	}

	// Token: 0x0600E1BE RID: 57790 RVA: 0x0002523B File Offset: 0x0002343B
	public void Init()
	{
	}

	// Token: 0x0600E1BF RID: 57791 RVA: 0x00514284 File Offset: 0x00512484
	public void LJGONBGGNHI(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && this.pbase.fullLevelData.mapData.handCount == 1)
		{
			KEMDFEFBIOC = 5;
		}
		GameObject gameObject = this.BMNLJGKJCMK(FKCMGBMNNKA, this.spawnPoints[KEMDFEFBIOC].transform.position, this.spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - this.pbase.GetGameScene().LEFLMCJDFJP());
	}

	// Token: 0x0600E1C0 RID: 57792 RVA: 0x00514320 File Offset: 0x00512520
	public GameObject FGDMJCCNMMO(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = TrashMan.BGNBCDOHBNC(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(this.pbase.playerController.objects[KEMDFEFBIOC].transform);
		if (gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = false;
		}
		if (gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = true;
		}
		if (gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().Init(this.pbase);
		}
		if (gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().LCGMHCBNCDM();
		}
		return gameObject;
	}

	// Token: 0x0600E1C1 RID: 57793 RVA: 0x005143DC File Offset: 0x005125DC
	public void OICMMIDHIDB(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && this.pbase.fullLevelData.mapData.handCount == 7)
		{
			KEMDFEFBIOC = 1;
		}
		GameObject gameObject = this.FGDMJCCNMMO(FKCMGBMNNKA, this.spawnPoints[KEMDFEFBIOC].transform.position, this.spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 1986f;
	}

	// Token: 0x0600E1C2 RID: 57794 RVA: 0x00514468 File Offset: 0x00512668
	public GameObject GGFNGECNAML(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 1;
		}
		GameObject gameObject = TrashMan.BGNBCDOHBNC(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(this.pbase.playerController.objects[KEMDFEFBIOC].transform);
		if (gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = false;
		}
		if (gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = true;
		}
		if (gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().GAJEPOEIOPP(this.pbase);
		}
		if (gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().CAJFKNFJEKC();
		}
		return gameObject;
	}

	// Token: 0x0600E1C3 RID: 57795 RVA: 0x00514524 File Offset: 0x00512724
	public void AKBOBNPBAAO(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && this.pbase.fullLevelData.mapData.handCount == 5)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = this.DCANBOAFPMB(FKCMGBMNNKA, this.spawnPoints[KEMDFEFBIOC].transform.position, this.spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - this.pbase.GetGameScene().PJHGHEKLOCH());
	}

	// Token: 0x0600E1C4 RID: 57796 RVA: 0x005145C0 File Offset: 0x005127C0
	public void MFILHAGLPOI(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && this.pbase.fullLevelData.mapData.handCount == 4)
		{
			KEMDFEFBIOC = 4;
		}
		GameObject gameObject = this.KEDHNCEBKLE(FKCMGBMNNKA, this.spawnPoints[KEMDFEFBIOC].transform.position, this.spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - this.pbase.GetGameScene().HPAnimationTime);
	}

	// Token: 0x0600E1C5 RID: 57797 RVA: 0x0051465C File Offset: 0x0051285C
	public void GOFFBMGGEJI(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && this.pbase.fullLevelData.mapData.handCount == 6)
		{
			KEMDFEFBIOC = 7;
		}
		GameObject gameObject = this.MECJANHJKJN(FKCMGBMNNKA, this.spawnPoints[KEMDFEFBIOC].transform.position, this.spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - this.pbase.GetGameScene().EIFMOHOFICD());
	}

	// Token: 0x0600E1C6 RID: 57798 RVA: 0x005146F8 File Offset: 0x005128F8
	public void FKAFFNFNCLD(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && this.pbase.fullLevelData.mapData.handCount == 1)
		{
			KEMDFEFBIOC = 7;
		}
		GameObject gameObject = this.PGKPDOKAKPB(FKCMGBMNNKA, this.spawnPoints[KEMDFEFBIOC].transform.position, this.spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - this.pbase.GetGameScene().LEFLMCJDFJP());
	}

	// Token: 0x0600E1C7 RID: 57799 RVA: 0x00514794 File Offset: 0x00512994
	public GameObject MECJANHJKJN(GameObject GEKFKCKDBOM, Vector3 JOPCODOJBHD, Quaternion LOMLCCLOIKN, int KEMDFEFBIOC)
	{
		if (KEMDFEFBIOC == 0)
		{
			KEMDFEFBIOC = 0;
		}
		GameObject gameObject = TrashMan.BGNBCDOHBNC(GEKFKCKDBOM, JOPCODOJBHD, LOMLCCLOIKN);
		gameObject.transform.SetParent(this.pbase.playerController.objects[KEMDFEFBIOC].transform);
		if (gameObject.GetComponent<MoveF>())
		{
			gameObject.GetComponent<MoveF>().enabled = false;
		}
		if (gameObject.GetComponent<Collider>())
		{
			gameObject.GetComponent<Collider>().enabled = false;
		}
		if (gameObject.GetComponent<SegmentHandler>())
		{
			gameObject.GetComponent<SegmentHandler>().FFBDGOBNNCO(this.pbase);
		}
		if (gameObject.GetComponent<IncreseAlpha>())
		{
			gameObject.GetComponent<IncreseAlpha>().EKOAKKNGGGI();
		}
		return gameObject;
	}

	// Token: 0x0600E1C8 RID: 57800 RVA: 0x00514850 File Offset: 0x00512A50
	public void LJLKDFCEIOO(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && this.pbase.fullLevelData.mapData.handCount == 4)
		{
			KEMDFEFBIOC = 7;
		}
		GameObject gameObject = this.DGDDKLNFJDI(FKCMGBMNNKA, this.spawnPoints[KEMDFEFBIOC].transform.position, this.spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 1102f;
	}

	// Token: 0x0600E1C9 RID: 57801 RVA: 0x005148DC File Offset: 0x00512ADC
	public void NANCLEIDNPM(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && this.pbase.fullLevelData.mapData.handCount == 1)
		{
			KEMDFEFBIOC = 7;
		}
		GameObject gameObject = this.MECJANHJKJN(FKCMGBMNNKA, this.spawnPoints[KEMDFEFBIOC].transform.position, this.spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 319f;
	}

	// Token: 0x0600E1CA RID: 57802 RVA: 0x00514968 File Offset: 0x00512B68
	public void HLFODJHLNID(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && this.pbase.fullLevelData.mapData.handCount == 8)
		{
			KEMDFEFBIOC = 2;
		}
		GameObject gameObject = this.SpawnAndReturn(FKCMGBMNNKA, this.spawnPoints[KEMDFEFBIOC].transform.position, this.spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 1700f;
	}

	// Token: 0x0600E1CB RID: 57803 RVA: 0x005149F4 File Offset: 0x00512BF4
	public void KHPNFJFIEKF(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && this.pbase.fullLevelData.mapData.handCount == 5)
		{
			KEMDFEFBIOC = 8;
		}
		GameObject gameObject = this.PGKPDOKAKPB(FKCMGBMNNKA, this.spawnPoints[KEMDFEFBIOC].transform.position, this.spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - this.pbase.DCLNDDJJJMA().HPAnimationTime);
	}

	// Token: 0x0600E1CC RID: 57804 RVA: 0x0002523B File Offset: 0x0002343B
	public void HBKEHHCMMBN()
	{
	}

	// Token: 0x0600E1CD RID: 57805 RVA: 0x0002523B File Offset: 0x0002343B
	public void NBIEIGBAKND()
	{
	}

	// Token: 0x0600E1CE RID: 57806 RVA: 0x0002523B File Offset: 0x0002343B
	public void POGJLIDHDIH()
	{
	}

	// Token: 0x0600E1CF RID: 57807 RVA: 0x00514A90 File Offset: 0x00512C90
	public void KELAPPFFMFM(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0)
	{
		if (KEMDFEFBIOC == 0 && this.pbase.fullLevelData.mapData.handCount == 1)
		{
			KEMDFEFBIOC = 4;
		}
		GameObject gameObject = this.DGDDKLNFJDI(FKCMGBMNNKA, this.spawnPoints[KEMDFEFBIOC].transform.position, this.spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = ((GameScene)Singleton<Scene>.Instance).pbase.currentArcsSpeed + 1054f;
	}

	// Token: 0x0600E1D0 RID: 57808 RVA: 0x00514B1C File Offset: 0x00512D1C
	public void ECKJCPIFAHD(GameObject FKCMGBMNNKA, int KEMDFEFBIOC = 0, float BPLICBECOBO = 0f)
	{
		if (KEMDFEFBIOC == 0 && this.pbase.fullLevelData.mapData.handCount == 1)
		{
			KEMDFEFBIOC = 5;
		}
		GameObject gameObject = this.PGKPDOKAKPB(FKCMGBMNNKA, this.spawnPoints[KEMDFEFBIOC].transform.position, this.spawnPoints[KEMDFEFBIOC].transform.rotation, KEMDFEFBIOC);
		gameObject.GetComponent<MoveF>().speed = base.transform.localPosition.z / (BPLICBECOBO - this.pbase.DCLNDDJJJMA().DADGJKNFIIK());
	}

	// Token: 0x0400198F RID: 6543
	public List<GameObject> spawnPoints;

	// Token: 0x04001990 RID: 6544
	public List<GameObject> segments;

	// Token: 0x04001991 RID: 6545
	public PlayerBase pbase;
}
