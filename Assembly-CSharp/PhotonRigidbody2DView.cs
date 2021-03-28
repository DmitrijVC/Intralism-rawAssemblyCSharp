using System;
using UnityEngine;

// Token: 0x0200032F RID: 815
[RequireComponent(typeof(PhotonView))]
[AddComponentMenu("Photon Networking/Photon Rigidbody 2D View")]
[RequireComponent(typeof(Rigidbody2D))]
public class PhotonRigidbody2DView : MonoBehaviour, IPunObservable
{
	// Token: 0x0600B9A8 RID: 47528 RVA: 0x0043A329 File Offset: 0x00438529
	private void OJACCGOHBGH()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9A9 RID: 47529 RVA: 0x0043A329 File Offset: 0x00438529
	private void GBNOIKAPBBO()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9AA RID: 47530 RVA: 0x0043A329 File Offset: 0x00438529
	private void GEGFJJBCHPE()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9AB RID: 47531 RVA: 0x0043A329 File Offset: 0x00438529
	private void PMBIKIBOHOF()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9AC RID: 47532 RVA: 0x0043A329 File Offset: 0x00438529
	private void PEMPABLNJHL()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9AD RID: 47533 RVA: 0x0043A329 File Offset: 0x00438529
	private void BHCCNFJKGPD()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9AE RID: 47534 RVA: 0x0043A338 File Offset: 0x00438538
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ReceiveNext();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	// Token: 0x0600B9AF RID: 47535 RVA: 0x0043A3DC File Offset: 0x004385DC
	public void FBMDDFMGFMF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.NLPFEFOCGBC();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ACOGAHJKGJH();
			}
		}
	}

	// Token: 0x0600B9B0 RID: 47536 RVA: 0x0043A480 File Offset: 0x00438680
	public void EOBMGCKFNNL(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.PNAPNHJHBMN(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.KIMDMBDNICC();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ACOGAHJKGJH();
			}
		}
	}

	// Token: 0x0600B9B1 RID: 47537 RVA: 0x0043A329 File Offset: 0x00438529
	private void EBPAOCJEJGE()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9B2 RID: 47538 RVA: 0x0043A524 File Offset: 0x00438724
	public void OCPCKNHCMKP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.BBHGPGBHMML(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.FIBMOBNIALK();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.IDKHBJIHKEB();
			}
		}
	}

	// Token: 0x0600B9B3 RID: 47539 RVA: 0x0043A5C8 File Offset: 0x004387C8
	public void AAKPEHOAMGP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.LNDLNKJPAGO();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.FIBMOBNIALK();
			}
		}
	}

	// Token: 0x0600B9B4 RID: 47540 RVA: 0x0043A329 File Offset: 0x00438529
	private void PIIMBOLGHOE()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9B5 RID: 47541 RVA: 0x0043A329 File Offset: 0x00438529
	private void LHMDCEDONEE()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9B6 RID: 47542 RVA: 0x0043A329 File Offset: 0x00438529
	private void IOMCHHBGJEC()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9B7 RID: 47543 RVA: 0x0043A66C File Offset: 0x0043886C
	public void CJKDMGMPMJM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.PBECMJMDHBI(this.LPFEBLNEEOF.velocity);
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(this.LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (this.m_SynchronizeVelocity)
			{
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.LNDLNKJPAGO();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ACOGAHJKGJH();
			}
		}
	}

	// Token: 0x0600B9B8 RID: 47544 RVA: 0x0043A710 File Offset: 0x00438910
	public void CBIDBNCBLGO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.LNDLNKJPAGO();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
		}
	}

	// Token: 0x0600B9B9 RID: 47545 RVA: 0x0043A329 File Offset: 0x00438529
	private void IIPMEPPIFCK()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9BA RID: 47546 RVA: 0x0043A7B4 File Offset: 0x004389B4
	public void HOBJDAHLBDM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.BBHGPGBHMML(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ACOGAHJKGJH();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.FIBMOBNIALK();
			}
		}
	}

	// Token: 0x0600B9BB RID: 47547 RVA: 0x0043A858 File Offset: 0x00438A58
	public void NLCNKMOLPNL(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.FADAIFFMBEL(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.IDKHBJIHKEB();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	// Token: 0x0600B9BC RID: 47548 RVA: 0x0043A8FC File Offset: 0x00438AFC
	public void PGMEOJJFIEN(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.HPPOACOIMOJ();
			}
		}
	}

	// Token: 0x0600B9BD RID: 47549 RVA: 0x0043A9A0 File Offset: 0x00438BA0
	public void PJBBBAOPOCC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.PNAPNHJHBMN(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.FIBMOBNIALK();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
		}
	}

	// Token: 0x0600B9BE RID: 47550 RVA: 0x0043A329 File Offset: 0x00438529
	private void MFCCNPEIOGP()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9BF RID: 47551 RVA: 0x0043AA44 File Offset: 0x00438C44
	public void JNENAPDBOKE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.PBECMJMDHBI(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ACOGAHJKGJH();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.LNDLNKJPAGO();
			}
		}
	}

	// Token: 0x0600B9C0 RID: 47552 RVA: 0x0043AAE8 File Offset: 0x00438CE8
	public void HDPOECGCALE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(this.LPFEBLNEEOF.velocity);
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(this.LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (this.m_SynchronizeVelocity)
			{
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.HPPOACOIMOJ();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ACOGAHJKGJH();
			}
		}
	}

	// Token: 0x0600B9C1 RID: 47553 RVA: 0x0043AB8C File Offset: 0x00438D8C
	public void GGPOCCFNMDF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ReceiveNext();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.HPPOACOIMOJ();
			}
		}
	}

	// Token: 0x0600B9C2 RID: 47554 RVA: 0x0043A329 File Offset: 0x00438529
	private void OPFDGBDADMA()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9C3 RID: 47555 RVA: 0x0043AC30 File Offset: 0x00438E30
	public void IGACCOIJFGM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ReceiveNext();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.KIMDMBDNICC();
			}
		}
	}

	// Token: 0x0600B9C4 RID: 47556 RVA: 0x0043ACD4 File Offset: 0x00438ED4
	public void HMMHABFJHEC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.NLPFEFOCGBC();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.KIMDMBDNICC();
			}
		}
	}

	// Token: 0x0600B9C5 RID: 47557 RVA: 0x0043AD78 File Offset: 0x00438F78
	public void JLPFFACDLJL(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.FADAIFFMBEL(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ACOGAHJKGJH();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.HPPOACOIMOJ();
			}
		}
	}

	// Token: 0x0600B9C6 RID: 47558 RVA: 0x0043A329 File Offset: 0x00438529
	private void PPCGJBIIFAO()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9C7 RID: 47559 RVA: 0x0043AE1C File Offset: 0x0043901C
	public void HIDJLJIEPHK(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.IDKHBJIHKEB();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
		}
	}

	// Token: 0x0600B9C8 RID: 47560 RVA: 0x0043A329 File Offset: 0x00438529
	private void IKGFIOIADLN()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9C9 RID: 47561 RVA: 0x0043AEC0 File Offset: 0x004390C0
	public void HHODOGMIJGI(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.FADAIFFMBEL(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.KIMDMBDNICC();
			}
		}
	}

	// Token: 0x0600B9CA RID: 47562 RVA: 0x0043AF64 File Offset: 0x00439164
	public void PKDPLHBMKPM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.FADAIFFMBEL(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.HPPOACOIMOJ();
			}
		}
	}

	// Token: 0x0600B9CB RID: 47563 RVA: 0x0043B008 File Offset: 0x00439208
	public void OFFPGECPIMN(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.SendNext(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.KIMDMBDNICC();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.HPPOACOIMOJ();
			}
		}
	}

	// Token: 0x0600B9CC RID: 47564 RVA: 0x0043B0AC File Offset: 0x004392AC
	public void HGKFNJAKJMH(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.IDKHBJIHKEB();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
		}
	}

	// Token: 0x0600B9CD RID: 47565 RVA: 0x0043A329 File Offset: 0x00438529
	private void FNMPIAMIKCP()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9CE RID: 47566 RVA: 0x0043A329 File Offset: 0x00438529
	private void KPOIJEKDFBE()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9CF RID: 47567 RVA: 0x0043B150 File Offset: 0x00439350
	public void EIGONAHJHNO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.BBHGPGBHMML(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.IDKHBJIHKEB();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.HPPOACOIMOJ();
			}
		}
	}

	// Token: 0x0600B9D0 RID: 47568 RVA: 0x0043B1F4 File Offset: 0x004393F4
	public void LIFMLJFPLDK(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ACOGAHJKGJH();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.HPPOACOIMOJ();
			}
		}
	}

	// Token: 0x0600B9D1 RID: 47569 RVA: 0x0043A329 File Offset: 0x00438529
	private void HCCMANDFEPL()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9D2 RID: 47570 RVA: 0x0043B298 File Offset: 0x00439498
	public void EJPKMLLGMGB(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.PBECMJMDHBI(this.LPFEBLNEEOF.velocity);
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(this.LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (this.m_SynchronizeVelocity)
			{
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.NLPFEFOCGBC();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	// Token: 0x0600B9D3 RID: 47571 RVA: 0x0043A329 File Offset: 0x00438529
	private void PHHOMLJECOJ()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9D4 RID: 47572 RVA: 0x0043A329 File Offset: 0x00438529
	private void IKKPINNOOLG()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9D5 RID: 47573 RVA: 0x0043A329 File Offset: 0x00438529
	private void LJEFMGOBKGE()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9D6 RID: 47574 RVA: 0x0043B33C File Offset: 0x0043953C
	public void KAAHPMKNHAD(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.FADAIFFMBEL(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	// Token: 0x0600B9D7 RID: 47575 RVA: 0x0043A329 File Offset: 0x00438529
	private void JEEINPBLBDI()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9D8 RID: 47576 RVA: 0x0043B3E0 File Offset: 0x004395E0
	public void GBOFDLLNLLL(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.PNAPNHJHBMN(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.FIBMOBNIALK();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ACOGAHJKGJH();
			}
		}
	}

	// Token: 0x0600B9D9 RID: 47577 RVA: 0x0043B484 File Offset: 0x00439684
	public void BAEICBGEECA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.FADAIFFMBEL(this.LPFEBLNEEOF.velocity);
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(this.LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (this.m_SynchronizeVelocity)
			{
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ACOGAHJKGJH();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.HPPOACOIMOJ();
			}
		}
	}

	// Token: 0x0600B9DA RID: 47578 RVA: 0x0043A329 File Offset: 0x00438529
	private void LFHKGIHNONL()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9DB RID: 47579 RVA: 0x0043B528 File Offset: 0x00439728
	public void NPFDCLNGGKC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.FADAIFFMBEL(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.FIBMOBNIALK();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	// Token: 0x0600B9DC RID: 47580 RVA: 0x0043B5CC File Offset: 0x004397CC
	public void BEPJPKCOLJH(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.CPIBABMPJLE(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ReceiveNext();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.LNDLNKJPAGO();
			}
		}
	}

	// Token: 0x0600B9DD RID: 47581 RVA: 0x0043A329 File Offset: 0x00438529
	private void FKDHFNCOKAK()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9DE RID: 47582 RVA: 0x0043A329 File Offset: 0x00438529
	private void GGKPLCJNEHF()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9DF RID: 47583 RVA: 0x0043B670 File Offset: 0x00439870
	public void DHCCMDLAJIO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.PBECMJMDHBI(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.LNDLNKJPAGO();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	// Token: 0x0600B9E0 RID: 47584 RVA: 0x0043A329 File Offset: 0x00438529
	private void FMAFBLKAJDF()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9E1 RID: 47585 RVA: 0x0043A329 File Offset: 0x00438529
	private void OBPCMAFGLON()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9E2 RID: 47586 RVA: 0x0043B714 File Offset: 0x00439914
	public void EJPAMJBIAGM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.IBCLJIACBKG(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.LNDLNKJPAGO();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ACOGAHJKGJH();
			}
		}
	}

	// Token: 0x0600B9E3 RID: 47587 RVA: 0x0043A329 File Offset: 0x00438529
	private void JNBMKLFJCEM()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9E4 RID: 47588 RVA: 0x0043B7B8 File Offset: 0x004399B8
	public void LBDNIDJNDJK(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.BBHGPGBHMML(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.IDKHBJIHKEB();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.KIMDMBDNICC();
			}
		}
	}

	// Token: 0x0600B9E5 RID: 47589 RVA: 0x0043B85C File Offset: 0x00439A5C
	public void PIBOKINJJDJ(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ACOGAHJKGJH();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ACOGAHJKGJH();
			}
		}
	}

	// Token: 0x0600B9E6 RID: 47590 RVA: 0x0043A329 File Offset: 0x00438529
	private void CJHMHIMKILB()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9E7 RID: 47591 RVA: 0x0043B900 File Offset: 0x00439B00
	public void MKPBBAPGGND(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.PNAPNHJHBMN(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ACOGAHJKGJH();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.FIBMOBNIALK();
			}
		}
	}

	// Token: 0x0600B9E8 RID: 47592 RVA: 0x0043A329 File Offset: 0x00438529
	private void MFAMHKBMBEI()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9E9 RID: 47593 RVA: 0x0043B9A4 File Offset: 0x00439BA4
	public void AAAGGIHAKEH(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(this.LPFEBLNEEOF.velocity);
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(this.LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (this.m_SynchronizeVelocity)
			{
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ReceiveNext();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ACOGAHJKGJH();
			}
		}
	}

	// Token: 0x0600B9EA RID: 47594 RVA: 0x0043A329 File Offset: 0x00438529
	private void EMKLCPGKNJL()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9EB RID: 47595 RVA: 0x0043BA48 File Offset: 0x00439C48
	public void DALBCFGNLLD(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ACOGAHJKGJH();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.LNDLNKJPAGO();
			}
		}
	}

	// Token: 0x0600B9EC RID: 47596 RVA: 0x0043A329 File Offset: 0x00438529
	private void DHNANELONED()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9ED RID: 47597 RVA: 0x0043A329 File Offset: 0x00438529
	private void MCIEAOAMOIG()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9EE RID: 47598 RVA: 0x0043BAEC File Offset: 0x00439CEC
	public void MOLNBJLBPOO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(this.LPFEBLNEEOF.velocity);
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(this.LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (this.m_SynchronizeVelocity)
			{
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.LNDLNKJPAGO();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.ReceiveNext();
			}
		}
	}

	// Token: 0x0600B9EF RID: 47599 RVA: 0x0043A329 File Offset: 0x00438529
	private void POHMFMNEPKK()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9F0 RID: 47600 RVA: 0x0043A329 File Offset: 0x00438529
	private void AJIKPEIGACI()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9F1 RID: 47601 RVA: 0x0043BB90 File Offset: 0x00439D90
	public void IFHKKPEFEOM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.SendNext(this.LPFEBLNEEOF.velocity);
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(this.LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (this.m_SynchronizeVelocity)
			{
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ACOGAHJKGJH();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.KIMDMBDNICC();
			}
		}
	}

	// Token: 0x0600B9F2 RID: 47602 RVA: 0x0043A329 File Offset: 0x00438529
	private void GOBHPAJFFDB()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9F3 RID: 47603 RVA: 0x0043BC34 File Offset: 0x00439E34
	public void OHJHFPNGLEF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.BBHGPGBHMML(this.LPFEBLNEEOF.velocity);
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(this.LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (this.m_SynchronizeVelocity)
			{
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.IDKHBJIHKEB();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.KIMDMBDNICC();
			}
		}
	}

	// Token: 0x0600B9F4 RID: 47604 RVA: 0x0043A329 File Offset: 0x00438529
	private void JBIFKBNPHJE()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9F5 RID: 47605 RVA: 0x0043A329 File Offset: 0x00438529
	private void BFIOIDMHPPL()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9F6 RID: 47606 RVA: 0x0043BCD8 File Offset: 0x00439ED8
	public void MBIPCKMIBFG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.BBHGPGBHMML(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.ReceiveNext();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.KIMDMBDNICC();
			}
		}
	}

	// Token: 0x0600B9F7 RID: 47607 RVA: 0x0043A329 File Offset: 0x00438529
	private void Awake()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9F8 RID: 47608 RVA: 0x0043A329 File Offset: 0x00438529
	private void MADENBGHKDD()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9F9 RID: 47609 RVA: 0x0043BD7C File Offset: 0x00439F7C
	public void DEKGPEDBDJE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.FIBMOBNIALK();
			}
		}
	}

	// Token: 0x0600B9FA RID: 47610 RVA: 0x0043A329 File Offset: 0x00438529
	private void OJBFBLHIEBB()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9FB RID: 47611 RVA: 0x0043BE20 File Offset: 0x0043A020
	public void LBLAKDBHADA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.HPPOACOIMOJ();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
	}

	// Token: 0x0600B9FC RID: 47612 RVA: 0x0043BEC4 File Offset: 0x0043A0C4
	public void AFIHOEBJPCG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.PBECMJMDHBI(this.LPFEBLNEEOF.velocity);
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				HCIJEDFCNOP.OLACNHHHOEL(this.LPFEBLNEEOF.angularVelocity);
			}
		}
		else
		{
			if (this.m_SynchronizeVelocity)
			{
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.LNDLNKJPAGO();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.FIBMOBNIALK();
			}
		}
	}

	// Token: 0x0600B9FD RID: 47613 RVA: 0x0043A329 File Offset: 0x00438529
	private void EMANBHKAONB()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600B9FE RID: 47614 RVA: 0x0043A329 File Offset: 0x00438529
	private void KACPCCMPAHA()
	{
		this.LPFEBLNEEOF = base.GetComponent<Rigidbody2D>();
	}

	// Token: 0x0600BA00 RID: 47616 RVA: 0x0043BF7C File Offset: 0x0043A17C
	public void GGEKDHHOOCH(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.IDKHBJIHKEB();
			}
		}
	}

	// Token: 0x0600BA01 RID: 47617 RVA: 0x0043C020 File Offset: 0x0043A220
	public void JNCHBPPANKP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			if (this.m_SynchronizeVelocity)
			{
				HCIJEDFCNOP.FADAIFFMBEL(this.LPFEBLNEEOF.velocity);
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
				this.LPFEBLNEEOF.velocity = (Vector2)HCIJEDFCNOP.KIEJNJBDAJJ();
			}
			if (this.m_SynchronizeAngularVelocity)
			{
				this.LPFEBLNEEOF.angularVelocity = (float)HCIJEDFCNOP.KIMDMBDNICC();
			}
		}
	}

	// Token: 0x040015BE RID: 5566
	[SerializeField]
	private bool m_SynchronizeVelocity = true;

	// Token: 0x040015BF RID: 5567
	[SerializeField]
	private bool m_SynchronizeAngularVelocity = true;

	// Token: 0x040015C0 RID: 5568
	private Rigidbody2D LPFEBLNEEOF;
}
