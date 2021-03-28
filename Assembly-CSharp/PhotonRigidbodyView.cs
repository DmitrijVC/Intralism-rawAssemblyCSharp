using System;
using UnityEngine;

// Token: 0x02000330 RID: 816
[AddComponentMenu("Photon Networking/Photon Rigidbody View")]
[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(PhotonView))]
public class PhotonRigidbodyView : MonoBehaviour, IPunObservable
{
	// Token: 0x0600BA02 RID: 47618 RVA: 0x0043C0C1 File Offset: 0x0043A2C1
	private void LOMHIIKFFEP()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BA03 RID: 47619 RVA: 0x0043C0C1 File Offset: 0x0043A2C1
	private void IIPMEPPIFCK()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BA04 RID: 47620 RVA: 0x0043C0C1 File Offset: 0x0043A2C1
	private void FAAJAMIGJNK()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BA05 RID: 47621 RVA: 0x0043C0D0 File Offset: 0x0043A2D0
	public void DCKLCCMEGAA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.SendNext(this.LPFEBLNEEOF.velocity);
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.BBHGPGBHMML(this.LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (this.m_SynchronizeVelocity)
			{
				this.LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
		}
	}

	// Token: 0x0600BA06 RID: 47622 RVA: 0x0043C174 File Offset: 0x0043A374
	public void KAAHPMKNHAD(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.SendNext(this.LPFEBLNEEOF.velocity);
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.BBHGPGBHMML(this.LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (this.m_SynchronizeVelocity)
			{
				this.LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.LNDLNKJPAGO();
			}
		}
	}

	// Token: 0x0600BA08 RID: 47624 RVA: 0x0043C22C File Offset: 0x0043A42C
	public void HBBLLHAOBLE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.SendNext(this.LPFEBLNEEOF.velocity);
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(this.LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (this.m_SynchronizeVelocity)
			{
				this.LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	// Token: 0x0600BA09 RID: 47625 RVA: 0x0043C2D0 File Offset: 0x0043A4D0
	public void OnPhotonSerializeView(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.SendNext(this.LPFEBLNEEOF.velocity);
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.SendNext(this.LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (this.m_SynchronizeVelocity)
			{
				this.LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	// Token: 0x0600BA0A RID: 47626 RVA: 0x0043C0C1 File Offset: 0x0043A2C1
	private void JEEINPBLBDI()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BA0B RID: 47627 RVA: 0x0043C374 File Offset: 0x0043A574
	public void PKDPLHBMKPM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(this.LPFEBLNEEOF.velocity);
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.BBHGPGBHMML(this.LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (this.m_SynchronizeVelocity)
			{
				this.LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	// Token: 0x0600BA0C RID: 47628 RVA: 0x0043C0C1 File Offset: 0x0043A2C1
	private void FMAFBLKAJDF()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BA0D RID: 47629 RVA: 0x0043C418 File Offset: 0x0043A618
	public void GBOFDLLNLLL(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.IBCLJIACBKG(this.LPFEBLNEEOF.velocity);
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.FADAIFFMBEL(this.LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (this.m_SynchronizeVelocity)
			{
				this.LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.LNDLNKJPAGO();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.ACOGAHJKGJH();
			}
		}
	}

	// Token: 0x0600BA0E RID: 47630 RVA: 0x0043C0C1 File Offset: 0x0043A2C1
	private void BODPLDJLFCF()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BA0F RID: 47631 RVA: 0x0043C4BC File Offset: 0x0043A6BC
	public void HPGOHBHACKF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(this.LPFEBLNEEOF.velocity);
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(this.LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (this.m_SynchronizeVelocity)
			{
				this.LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
			}
		}
	}

	// Token: 0x0600BA10 RID: 47632 RVA: 0x0043C0C1 File Offset: 0x0043A2C1
	private void BMAGFLLGDPJ()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BA11 RID: 47633 RVA: 0x0043C560 File Offset: 0x0043A760
	public void BAEICBGEECA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.PBECMJMDHBI(this.LPFEBLNEEOF.velocity);
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.IBCLJIACBKG(this.LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (this.m_SynchronizeVelocity)
			{
				this.LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.LNDLNKJPAGO();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.LNDLNKJPAGO();
			}
		}
	}

	// Token: 0x0600BA12 RID: 47634 RVA: 0x0043C604 File Offset: 0x0043A804
	public void COHGAEMDFEI(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.PNAPNHJHBMN(this.LPFEBLNEEOF.velocity);
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.PBECMJMDHBI(this.LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (this.m_SynchronizeVelocity)
			{
				this.LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.ACOGAHJKGJH();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.ACOGAHJKGJH();
			}
		}
	}

	// Token: 0x0600BA13 RID: 47635 RVA: 0x0043C6A8 File Offset: 0x0043A8A8
	public void HGKFNJAKJMH(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.SendNext(this.LPFEBLNEEOF.velocity);
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.FADAIFFMBEL(this.LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (this.m_SynchronizeVelocity)
			{
				this.LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.FIBMOBNIALK();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.LNDLNKJPAGO();
			}
		}
	}

	// Token: 0x0600BA14 RID: 47636 RVA: 0x0043C0C1 File Offset: 0x0043A2C1
	private void Awake()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody>();
	}

	// Token: 0x0600BA15 RID: 47637 RVA: 0x0043C74C File Offset: 0x0043A94C
	public void KLFPENLPMJP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(this.LPFEBLNEEOF.velocity);
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(this.LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (this.m_SynchronizeVelocity)
			{
				this.LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.FIBMOBNIALK();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.HPPOACOIMOJ();
			}
		}
	}

	// Token: 0x0600BA16 RID: 47638 RVA: 0x0043C7F0 File Offset: 0x0043A9F0
	public void CBIDBNCBLGO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.IBCLJIACBKG(this.LPFEBLNEEOF.velocity);
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.PNAPNHJHBMN(this.LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (this.m_SynchronizeVelocity)
			{
				this.LPFEBLNEEOF.velocity = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	// Token: 0x040015C1 RID: 5569
	[SerializeField]
	private bool m_SynchronizeVelocity = true;

	// Token: 0x040015C2 RID: 5570
	[SerializeField]
	private bool m_SynchronizeAngularVelocity = true;

	// Token: 0x040015C3 RID: 5571
	private Rigidbody LPFEBLNEEOF;
}
