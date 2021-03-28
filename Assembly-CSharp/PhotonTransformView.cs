using System;
using UnityEngine;

// Token: 0x02000331 RID: 817
[RequireComponent(typeof(PhotonView))]
[AddComponentMenu("Photon Networking/Photon Transform View")]
public class PhotonTransformView : MonoBehaviour, IPunObservable
{
	// Token: 0x0600BA17 RID: 47639 RVA: 0x0043C894 File Offset: 0x0043AA94
	private void APMIILJFAHI()
	{
		Vector3 vector = this.DKKKOMOJCIF.NLNDBCNKLJH();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 815f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 769f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 1214f);
	}

	// Token: 0x0600BA18 RID: 47640 RVA: 0x0043C93F File Offset: 0x0043AB3F
	private void CPCDFMMLHLO()
	{
		if (this.GDIAJCAHCEC == null || this.GDIAJCAHCEC.KCAOJFPDEIP() || !PhotonNetwork.connected)
		{
			return;
		}
		this.BFEPFLEBEFK();
		this.BCJPFGDJAID();
		this.CAOGNPLGMEH();
	}

	// Token: 0x0600BA19 RID: 47641 RVA: 0x0043C97F File Offset: 0x0043AB7F
	private void PNFGAPFDPIG()
	{
		if (!this.m_PositionModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localPosition = this.DKKKOMOJCIF.BEDHNBMPPGM(base.transform.localPosition);
	}

	// Token: 0x0600BA1A RID: 47642 RVA: 0x0043C9C0 File Offset: 0x0043ABC0
	private void JHOGBKNMCIF()
	{
		Vector3 vector = this.DKKKOMOJCIF.APJJAKOIMIK();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 490f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 1163f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 505f);
	}

	// Token: 0x0600BA1B RID: 47643 RVA: 0x0043CA6C File Offset: 0x0043AC6C
	private void MLPCIDDEIDC()
	{
		this.GDIAJCAHCEC = base.GetComponent<PhotonView>();
		this.DKKKOMOJCIF = new PhotonTransformViewPositionControl(this.m_PositionModel);
		this.NIJLJGDNBHE = new PhotonTransformViewRotationControl(this.m_RotationModel);
		this.JAJKFGFBPIL = new PhotonTransformViewScaleControl(this.m_ScaleModel);
	}

	// Token: 0x0600BA1C RID: 47644 RVA: 0x0043CAB8 File Offset: 0x0043ACB8
	public void ILBIMLHMECN(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		this.DKKKOMOJCIF.CNABAIGBLIC(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	// Token: 0x0600BA1D RID: 47645 RVA: 0x0043CAC7 File Offset: 0x0043ACC7
	private void IHJHGLDCHFK()
	{
		if (!this.m_RotationModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localRotation = this.NIJLJGDNBHE.JIHNIHKFFBN(base.transform.localRotation);
	}

	// Token: 0x0600BA1E RID: 47646 RVA: 0x0043CB06 File Offset: 0x0043AD06
	private void GAIOINPOIHM()
	{
		if (!this.m_RotationModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localRotation = this.NIJLJGDNBHE.OCIAPBJGCOM(base.transform.localRotation);
	}

	// Token: 0x0600BA20 RID: 47648 RVA: 0x0043CB70 File Offset: 0x0043AD70
	public void MCEKDLDCGAO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		this.DKKKOMOJCIF.DEKGPEDBDJE(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		this.NIJLJGDNBHE.FOHGOGIMPJJ(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		this.JAJKFGFBPIL.DLFLONFGGGG(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!this.GDIAJCAHCEC.KCAOJFPDEIP() && this.m_PositionModel.DrawErrorGizmo)
		{
			this.MHLIFACJNLA();
		}
		if (HCIJEDFCNOP.CAOIPMAGIFI())
		{
			this.PPJNLMEJHCN = false;
			if (this.NBJNCJAJNPP)
			{
				this.NBJNCJAJNPP = false;
				if (this.m_PositionModel.SynchronizeEnabled)
				{
					base.transform.localPosition = this.DKKKOMOJCIF.LFJPMNKJBMG();
				}
				if (this.m_RotationModel.SynchronizeEnabled)
				{
					base.transform.localRotation = this.NIJLJGDNBHE.JPJLCPLIOCA();
				}
				if (this.m_ScaleModel.SynchronizeEnabled)
				{
					base.transform.localScale = this.JAJKFGFBPIL.JHLAPBECKPH();
				}
			}
		}
	}

	// Token: 0x0600BA21 RID: 47649 RVA: 0x0043C97F File Offset: 0x0043AB7F
	private void HNOLLNNJKCO()
	{
		if (!this.m_PositionModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localPosition = this.DKKKOMOJCIF.BEDHNBMPPGM(base.transform.localPosition);
	}

	// Token: 0x0600BA22 RID: 47650 RVA: 0x0043CC84 File Offset: 0x0043AE84
	public void JNABPAJHLML(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		this.DKKKOMOJCIF.OnPhotonSerializeView(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		this.NIJLJGDNBHE.HHODOGMIJGI(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		this.JAJKFGFBPIL.KLFPENLPMJP(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!this.GDIAJCAHCEC.KCAOJFPDEIP() && this.m_PositionModel.DrawErrorGizmo)
		{
			this.MNHPFGNPMNL();
		}
		if (HCIJEDFCNOP.CAOIPMAGIFI())
		{
			this.PPJNLMEJHCN = true;
			if (this.NBJNCJAJNPP)
			{
				this.NBJNCJAJNPP = false;
				if (this.m_PositionModel.SynchronizeEnabled)
				{
					base.transform.localPosition = this.DKKKOMOJCIF.APJJAKOIMIK();
				}
				if (this.m_RotationModel.SynchronizeEnabled)
				{
					base.transform.localRotation = this.NIJLJGDNBHE.CEPDDADCDCG();
				}
				if (this.m_ScaleModel.SynchronizeEnabled)
				{
					base.transform.localScale = this.JAJKFGFBPIL.JBGODNPHENN();
				}
			}
		}
	}

	// Token: 0x0600BA23 RID: 47651 RVA: 0x0043CD98 File Offset: 0x0043AF98
	public void BDLOPMIFLJG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		this.DKKKOMOJCIF.HIDJLJIEPHK(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		this.NIJLJGDNBHE.CNMIIGDELGE(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		this.JAJKFGFBPIL.DLFLONFGGGG(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!this.GDIAJCAHCEC.BGJKMGJBPFA() && this.m_PositionModel.DrawErrorGizmo)
		{
			this.JHOGBKNMCIF();
		}
		if (HCIJEDFCNOP.DCGOJLBDGEG())
		{
			this.PPJNLMEJHCN = true;
			if (this.NBJNCJAJNPP)
			{
				this.NBJNCJAJNPP = false;
				if (this.m_PositionModel.SynchronizeEnabled)
				{
					base.transform.localPosition = this.DKKKOMOJCIF.MDAKHCPMDIE();
				}
				if (this.m_RotationModel.SynchronizeEnabled)
				{
					base.transform.localRotation = this.NIJLJGDNBHE.GBGENCNGBJH();
				}
				if (this.m_ScaleModel.SynchronizeEnabled)
				{
					base.transform.localScale = this.JAJKFGFBPIL.MPJGCCAJAOA();
				}
			}
		}
	}

	// Token: 0x0600BA24 RID: 47652 RVA: 0x0043CEAC File Offset: 0x0043B0AC
	private void LJEFMGOBKGE()
	{
		this.GDIAJCAHCEC = base.GetComponent<PhotonView>();
		this.DKKKOMOJCIF = new PhotonTransformViewPositionControl(this.m_PositionModel);
		this.NIJLJGDNBHE = new PhotonTransformViewRotationControl(this.m_RotationModel);
		this.JAJKFGFBPIL = new PhotonTransformViewScaleControl(this.m_ScaleModel);
	}

	// Token: 0x0600BA25 RID: 47653 RVA: 0x0043CEF8 File Offset: 0x0043B0F8
	private void EIFCCFBJKOO()
	{
		this.GDIAJCAHCEC = base.GetComponent<PhotonView>();
		this.DKKKOMOJCIF = new PhotonTransformViewPositionControl(this.m_PositionModel);
		this.NIJLJGDNBHE = new PhotonTransformViewRotationControl(this.m_RotationModel);
		this.JAJKFGFBPIL = new PhotonTransformViewScaleControl(this.m_ScaleModel);
	}

	// Token: 0x0600BA26 RID: 47654 RVA: 0x0043CF44 File Offset: 0x0043B144
	private void JLDJIHNGDMP()
	{
		if (!this.m_PositionModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localPosition = this.DKKKOMOJCIF.FBGHNHMHIFM(base.transform.localPosition);
	}

	// Token: 0x0600BA27 RID: 47655 RVA: 0x0043CF84 File Offset: 0x0043B184
	private void EBCBBBKOKFG()
	{
		Vector3 vector = this.DKKKOMOJCIF.APJJAKOIMIK();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 461f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 700f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 1519f);
	}

	// Token: 0x0600BA28 RID: 47656 RVA: 0x0043D02F File Offset: 0x0043B22F
	private void EBOLINNNGLK()
	{
		if (!this.m_PositionModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localPosition = this.DKKKOMOJCIF.DEEDPNNEJPO(base.transform.localPosition);
	}

	// Token: 0x0600BA29 RID: 47657 RVA: 0x0043D070 File Offset: 0x0043B270
	private void EPCGHAAONLN()
	{
		this.GDIAJCAHCEC = base.GetComponent<PhotonView>();
		this.DKKKOMOJCIF = new PhotonTransformViewPositionControl(this.m_PositionModel);
		this.NIJLJGDNBHE = new PhotonTransformViewRotationControl(this.m_RotationModel);
		this.JAJKFGFBPIL = new PhotonTransformViewScaleControl(this.m_ScaleModel);
	}

	// Token: 0x0600BA2A RID: 47658 RVA: 0x0043D0BC File Offset: 0x0043B2BC
	public void OCPCKNHCMKP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		this.DKKKOMOJCIF.PKDPLHBMKPM(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		this.NIJLJGDNBHE.GBNDJBNLKLI(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		this.JAJKFGFBPIL.FBMDDFMGFMF(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!this.GDIAJCAHCEC.KCAOJFPDEIP() && this.m_PositionModel.DrawErrorGizmo)
		{
			this.BBJHDJBGDAN();
		}
		if (HCIJEDFCNOP.EKDCDLDMKDL())
		{
			this.PPJNLMEJHCN = false;
			if (this.NBJNCJAJNPP)
			{
				this.NBJNCJAJNPP = false;
				if (this.m_PositionModel.SynchronizeEnabled)
				{
					base.transform.localPosition = this.DKKKOMOJCIF.LFJPMNKJBMG();
				}
				if (this.m_RotationModel.SynchronizeEnabled)
				{
					base.transform.localRotation = this.NIJLJGDNBHE.AOLDNFKNMAP();
				}
				if (this.m_ScaleModel.SynchronizeEnabled)
				{
					base.transform.localScale = this.JAJKFGFBPIL.JHLAPBECKPH();
				}
			}
		}
	}

	// Token: 0x0600BA2B RID: 47659 RVA: 0x0043C97F File Offset: 0x0043AB7F
	private void OEFLDIGHANK()
	{
		if (!this.m_PositionModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localPosition = this.DKKKOMOJCIF.BEDHNBMPPGM(base.transform.localPosition);
	}

	// Token: 0x0600BA2C RID: 47660 RVA: 0x0043D1CD File Offset: 0x0043B3CD
	public void KLLLFJIDALE(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		this.DKKKOMOJCIF.SetSynchronizedValues(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	// Token: 0x0600BA2D RID: 47661 RVA: 0x0043D1DC File Offset: 0x0043B3DC
	private void EHKAMNFEGMG()
	{
		this.GDIAJCAHCEC = base.GetComponent<PhotonView>();
		this.DKKKOMOJCIF = new PhotonTransformViewPositionControl(this.m_PositionModel);
		this.NIJLJGDNBHE = new PhotonTransformViewRotationControl(this.m_RotationModel);
		this.JAJKFGFBPIL = new PhotonTransformViewScaleControl(this.m_ScaleModel);
	}

	// Token: 0x0600BA2E RID: 47662 RVA: 0x0043D228 File Offset: 0x0043B428
	public void EOFAACNPFDF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		this.DKKKOMOJCIF.FBMDDFMGFMF(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		this.NIJLJGDNBHE.JNENAPDBOKE(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		this.JAJKFGFBPIL.DLFLONFGGGG(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!this.GDIAJCAHCEC.KCAOJFPDEIP() && this.m_PositionModel.DrawErrorGizmo)
		{
			this.EAOINGGMHOH();
		}
		if (HCIJEDFCNOP.EKDCDLDMKDL())
		{
			this.PPJNLMEJHCN = false;
			if (this.NBJNCJAJNPP)
			{
				this.NBJNCJAJNPP = true;
				if (this.m_PositionModel.SynchronizeEnabled)
				{
					base.transform.localPosition = this.DKKKOMOJCIF.NLNDBCNKLJH();
				}
				if (this.m_RotationModel.SynchronizeEnabled)
				{
					base.transform.localRotation = this.NIJLJGDNBHE.GFLGLDGIGLK();
				}
				if (this.m_ScaleModel.SynchronizeEnabled)
				{
					base.transform.localScale = this.JAJKFGFBPIL.GIMLEHMPBKA();
				}
			}
		}
	}

	// Token: 0x0600BA2F RID: 47663 RVA: 0x0043D33C File Offset: 0x0043B53C
	public void ICPOCNHAAEK(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		this.DKKKOMOJCIF.HIDJLJIEPHK(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		this.NIJLJGDNBHE.HHODOGMIJGI(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		this.JAJKFGFBPIL.BAEICBGEECA(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!this.GDIAJCAHCEC.KCAOJFPDEIP() && this.m_PositionModel.DrawErrorGizmo)
		{
			this.EBCBBBKOKFG();
		}
		if (HCIJEDFCNOP.EKDCDLDMKDL())
		{
			this.PPJNLMEJHCN = false;
			if (this.NBJNCJAJNPP)
			{
				this.NBJNCJAJNPP = true;
				if (this.m_PositionModel.SynchronizeEnabled)
				{
					base.transform.localPosition = this.DKKKOMOJCIF.MDAKHCPMDIE();
				}
				if (this.m_RotationModel.SynchronizeEnabled)
				{
					base.transform.localRotation = this.NIJLJGDNBHE.HAGGDALINJC();
				}
				if (this.m_ScaleModel.SynchronizeEnabled)
				{
					base.transform.localScale = this.JAJKFGFBPIL.DBBAOGADAFG();
				}
			}
		}
	}

	// Token: 0x0600BA30 RID: 47664 RVA: 0x0043D44D File Offset: 0x0043B64D
	private void HOLDCFBBHHP()
	{
		this.NBJNCJAJNPP = true;
	}

	// Token: 0x0600BA31 RID: 47665 RVA: 0x0043D458 File Offset: 0x0043B658
	public void KLFPENLPMJP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		this.DKKKOMOJCIF.AAAGGIHAKEH(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		this.NIJLJGDNBHE.MKPBBAPGGND(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		this.JAJKFGFBPIL.DLFLONFGGGG(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!this.GDIAJCAHCEC.isMine && this.m_PositionModel.DrawErrorGizmo)
		{
			this.OICPDNHGCLA();
		}
		if (HCIJEDFCNOP.DCGOJLBDGEG())
		{
			this.PPJNLMEJHCN = false;
			if (this.NBJNCJAJNPP)
			{
				this.NBJNCJAJNPP = true;
				if (this.m_PositionModel.SynchronizeEnabled)
				{
					base.transform.localPosition = this.DKKKOMOJCIF.LFJPMNKJBMG();
				}
				if (this.m_RotationModel.SynchronizeEnabled)
				{
					base.transform.localRotation = this.NIJLJGDNBHE.FMKLCNHHPGM();
				}
				if (this.m_ScaleModel.SynchronizeEnabled)
				{
					base.transform.localScale = this.JAJKFGFBPIL.JBGODNPHENN();
				}
			}
		}
	}

	// Token: 0x0600BA32 RID: 47666 RVA: 0x0043CF44 File Offset: 0x0043B144
	private void APNJLHDKGDB()
	{
		if (!this.m_PositionModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localPosition = this.DKKKOMOJCIF.FBGHNHMHIFM(base.transform.localPosition);
	}

	// Token: 0x0600BA33 RID: 47667 RVA: 0x0043D56C File Offset: 0x0043B76C
	public void FMLLKJIBBPO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		this.DKKKOMOJCIF.FBMDDFMGFMF(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		this.NIJLJGDNBHE.MOLNBJLBPOO(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		this.JAJKFGFBPIL.BAEICBGEECA(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!this.GDIAJCAHCEC.DOLKFPIABDD() && this.m_PositionModel.DrawErrorGizmo)
		{
			this.MHLIFACJNLA();
		}
		if (HCIJEDFCNOP.CAOIPMAGIFI())
		{
			this.PPJNLMEJHCN = true;
			if (this.NBJNCJAJNPP)
			{
				this.NBJNCJAJNPP = false;
				if (this.m_PositionModel.SynchronizeEnabled)
				{
					base.transform.localPosition = this.DKKKOMOJCIF.GetNetworkPosition();
				}
				if (this.m_RotationModel.SynchronizeEnabled)
				{
					base.transform.localRotation = this.NIJLJGDNBHE.BFGDOFKCPGN();
				}
				if (this.m_ScaleModel.SynchronizeEnabled)
				{
					base.transform.localScale = this.JAJKFGFBPIL.BMOPJJPOKEE();
				}
			}
		}
	}

	// Token: 0x0600BA34 RID: 47668 RVA: 0x0043D67D File Offset: 0x0043B87D
	private void FAKGFMFAPDG()
	{
		if (this.GDIAJCAHCEC == null || this.GDIAJCAHCEC.BGJKMGJBPFA() || !PhotonNetwork.connected)
		{
			return;
		}
		this.APNJLHDKGDB();
		this.IHCIMKAONKC();
		this.PEGIABKFJNH();
	}

	// Token: 0x0600BA35 RID: 47669 RVA: 0x0043D6C0 File Offset: 0x0043B8C0
	private void JHPKLGGMCBL()
	{
		this.GDIAJCAHCEC = base.GetComponent<PhotonView>();
		this.DKKKOMOJCIF = new PhotonTransformViewPositionControl(this.m_PositionModel);
		this.NIJLJGDNBHE = new PhotonTransformViewRotationControl(this.m_RotationModel);
		this.JAJKFGFBPIL = new PhotonTransformViewScaleControl(this.m_ScaleModel);
	}

	// Token: 0x0600BA36 RID: 47670 RVA: 0x0043D70C File Offset: 0x0043B90C
	private void CAGLAMLNJAH()
	{
		if (!this.m_ScaleModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localScale = this.JAJKFGFBPIL.NKLAIOJCAHD(base.transform.localScale);
	}

	// Token: 0x0600BA37 RID: 47671 RVA: 0x0043D74B File Offset: 0x0043B94B
	private void IPIDOPPAPPH()
	{
		if (!this.m_ScaleModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localScale = this.JAJKFGFBPIL.GetScale(base.transform.localScale);
	}

	// Token: 0x0600BA38 RID: 47672 RVA: 0x0043D78A File Offset: 0x0043B98A
	private void PPPFNMIOPNH()
	{
		if (!this.m_RotationModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localRotation = this.NIJLJGDNBHE.AIKONMOBJOF(base.transform.localRotation);
	}

	// Token: 0x0600BA39 RID: 47673 RVA: 0x0043D1CD File Offset: 0x0043B3CD
	public void GCAKKECECPI(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		this.DKKKOMOJCIF.SetSynchronizedValues(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	// Token: 0x0600BA3A RID: 47674 RVA: 0x0043D7C9 File Offset: 0x0043B9C9
	private void OJHFIEEDJGB()
	{
		if (!this.m_PositionModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localPosition = this.DKKKOMOJCIF.UpdatePosition(base.transform.localPosition);
	}

	// Token: 0x0600BA3B RID: 47675 RVA: 0x0043D808 File Offset: 0x0043BA08
	public void CMPDMPKMBMO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		this.DKKKOMOJCIF.PNLAIDLOIDE(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		this.NIJLJGDNBHE.JJGHNKLDANI(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		this.JAJKFGFBPIL.BAEICBGEECA(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!this.GDIAJCAHCEC.DOLKFPIABDD() && this.m_PositionModel.DrawErrorGizmo)
		{
			this.BBJHDJBGDAN();
		}
		if (HCIJEDFCNOP.DCGOJLBDGEG())
		{
			this.PPJNLMEJHCN = false;
			if (this.NBJNCJAJNPP)
			{
				this.NBJNCJAJNPP = false;
				if (this.m_PositionModel.SynchronizeEnabled)
				{
					base.transform.localPosition = this.DKKKOMOJCIF.NLNDBCNKLJH();
				}
				if (this.m_RotationModel.SynchronizeEnabled)
				{
					base.transform.localRotation = this.NIJLJGDNBHE.HODEBPDPNLN();
				}
				if (this.m_ScaleModel.SynchronizeEnabled)
				{
					base.transform.localScale = this.JAJKFGFBPIL.HIAGDLDLOJO();
				}
			}
		}
	}

	// Token: 0x0600BA3C RID: 47676 RVA: 0x0043D91C File Offset: 0x0043BB1C
	private void EEFIMMHNBAC()
	{
		Vector3 vector = this.DKKKOMOJCIF.GetNetworkPosition();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 2f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 2f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 2f);
	}

	// Token: 0x0600BA3D RID: 47677 RVA: 0x0043CAB8 File Offset: 0x0043ACB8
	public void HBDKIJHLHCH(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		this.DKKKOMOJCIF.CNABAIGBLIC(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	// Token: 0x0600BA3E RID: 47678 RVA: 0x0043D9C7 File Offset: 0x0043BBC7
	private void IFKNIHJCAFB()
	{
		this.NBJNCJAJNPP = false;
	}

	// Token: 0x0600BA3F RID: 47679 RVA: 0x0043D9D0 File Offset: 0x0043BBD0
	public void ENPHBNKFFPK(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		this.DKKKOMOJCIF.FBMDDFMGFMF(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		this.NIJLJGDNBHE.DEKGPEDBDJE(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		this.JAJKFGFBPIL.COHGAEMDFEI(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!this.GDIAJCAHCEC.KCAOJFPDEIP() && this.m_PositionModel.DrawErrorGizmo)
		{
			this.AEEKOEDHGAM();
		}
		if (HCIJEDFCNOP.EKDCDLDMKDL())
		{
			this.PPJNLMEJHCN = true;
			if (this.NBJNCJAJNPP)
			{
				this.NBJNCJAJNPP = false;
				if (this.m_PositionModel.SynchronizeEnabled)
				{
					base.transform.localPosition = this.DKKKOMOJCIF.MDAKHCPMDIE();
				}
				if (this.m_RotationModel.SynchronizeEnabled)
				{
					base.transform.localRotation = this.NIJLJGDNBHE.FMKLCNHHPGM();
				}
				if (this.m_ScaleModel.SynchronizeEnabled)
				{
					base.transform.localScale = this.JAJKFGFBPIL.FLFKMOEGOKL();
				}
			}
		}
	}

	// Token: 0x0600BA40 RID: 47680 RVA: 0x0043DAE1 File Offset: 0x0043BCE1
	private void DKIJEFDDODC()
	{
		if (!this.m_RotationModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localRotation = this.NIJLJGDNBHE.GLDKMEANMAL(base.transform.localRotation);
	}

	// Token: 0x0600BA41 RID: 47681 RVA: 0x0043DB20 File Offset: 0x0043BD20
	private void HIELFODJCMI()
	{
		if (!this.m_RotationModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localRotation = this.NIJLJGDNBHE.IGMHPDBMMMH(base.transform.localRotation);
	}

	// Token: 0x0600BA42 RID: 47682 RVA: 0x0043D9C7 File Offset: 0x0043BBC7
	private void HIDOPHINPAL()
	{
		this.NBJNCJAJNPP = false;
	}

	// Token: 0x0600BA43 RID: 47683 RVA: 0x0043DB60 File Offset: 0x0043BD60
	private void BHCCNFJKGPD()
	{
		this.GDIAJCAHCEC = base.GetComponent<PhotonView>();
		this.DKKKOMOJCIF = new PhotonTransformViewPositionControl(this.m_PositionModel);
		this.NIJLJGDNBHE = new PhotonTransformViewRotationControl(this.m_RotationModel);
		this.JAJKFGFBPIL = new PhotonTransformViewScaleControl(this.m_ScaleModel);
	}

	// Token: 0x0600BA44 RID: 47684 RVA: 0x0043DBAC File Offset: 0x0043BDAC
	private void MHECPMBMHIC()
	{
		this.GDIAJCAHCEC = base.GetComponent<PhotonView>();
		this.DKKKOMOJCIF = new PhotonTransformViewPositionControl(this.m_PositionModel);
		this.NIJLJGDNBHE = new PhotonTransformViewRotationControl(this.m_RotationModel);
		this.JAJKFGFBPIL = new PhotonTransformViewScaleControl(this.m_ScaleModel);
	}

	// Token: 0x0600BA45 RID: 47685 RVA: 0x0043D44D File Offset: 0x0043B64D
	private void PPFGHAKKLMN()
	{
		this.NBJNCJAJNPP = true;
	}

	// Token: 0x0600BA46 RID: 47686 RVA: 0x0043DBF8 File Offset: 0x0043BDF8
	private void MAOCOEGAFND()
	{
		if (this.GDIAJCAHCEC == null || this.GDIAJCAHCEC.KCAOJFPDEIP() || !PhotonNetwork.connected)
		{
			return;
		}
		this.APNJLHDKGDB();
		this.CGEKJECJIKC();
		this.CAOGNPLGMEH();
	}

	// Token: 0x0600BA47 RID: 47687 RVA: 0x0043D02F File Offset: 0x0043B22F
	private void PFFFLMFHLMG()
	{
		if (!this.m_PositionModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localPosition = this.DKKKOMOJCIF.DEEDPNNEJPO(base.transform.localPosition);
	}

	// Token: 0x0600BA48 RID: 47688 RVA: 0x0043DC38 File Offset: 0x0043BE38
	private void HCIPECAOGIA()
	{
		if (this.GDIAJCAHCEC == null || this.GDIAJCAHCEC.DOLKFPIABDD() || !PhotonNetwork.connected)
		{
			return;
		}
		this.BFEPFLEBEFK();
		this.HLGENFAPEIC();
		this.OGHNPKKPLKE();
	}

	// Token: 0x0600BA49 RID: 47689 RVA: 0x0043DC78 File Offset: 0x0043BE78
	private void MHLIFACJNLA()
	{
		Vector3 vector = this.DKKKOMOJCIF.NLNDBCNKLJH();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 845f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 861f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 374f);
	}

	// Token: 0x0600BA4A RID: 47690 RVA: 0x0043DD23 File Offset: 0x0043BF23
	private void PEAPFFDOJAB()
	{
		if (!this.m_ScaleModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localScale = this.JAJKFGFBPIL.OMAOHOBIMNM(base.transform.localScale);
	}

	// Token: 0x0600BA4B RID: 47691 RVA: 0x0043DD62 File Offset: 0x0043BF62
	private void KMEONPMCNJG()
	{
		if (this.GDIAJCAHCEC == null || this.GDIAJCAHCEC.DOLKFPIABDD() || !PhotonNetwork.connected)
		{
			return;
		}
		this.HFPHCAIJKEC();
		this.PMOBDAJCAAP();
		this.BNDCAGHJMJN();
	}

	// Token: 0x0600BA4C RID: 47692 RVA: 0x0043D9C7 File Offset: 0x0043BBC7
	private void LGELACBDPEH()
	{
		this.NBJNCJAJNPP = false;
	}

	// Token: 0x0600BA4D RID: 47693 RVA: 0x0043DDA4 File Offset: 0x0043BFA4
	private void Awake()
	{
		this.GDIAJCAHCEC = base.GetComponent<PhotonView>();
		this.DKKKOMOJCIF = new PhotonTransformViewPositionControl(this.m_PositionModel);
		this.NIJLJGDNBHE = new PhotonTransformViewRotationControl(this.m_RotationModel);
		this.JAJKFGFBPIL = new PhotonTransformViewScaleControl(this.m_ScaleModel);
	}

	// Token: 0x0600BA4E RID: 47694 RVA: 0x0043DDF0 File Offset: 0x0043BFF0
	private void KLJKFGAMMNC()
	{
		Vector3 vector = this.DKKKOMOJCIF.JHBPKKMPBGA();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 343f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 1299f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 1787f);
	}

	// Token: 0x0600BA4F RID: 47695 RVA: 0x0043D7C9 File Offset: 0x0043B9C9
	private void HFPHCAIJKEC()
	{
		if (!this.m_PositionModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localPosition = this.DKKKOMOJCIF.UpdatePosition(base.transform.localPosition);
	}

	// Token: 0x0600BA50 RID: 47696 RVA: 0x0043DE9C File Offset: 0x0043C09C
	private void GEPELODHBFN()
	{
		this.GDIAJCAHCEC = base.GetComponent<PhotonView>();
		this.DKKKOMOJCIF = new PhotonTransformViewPositionControl(this.m_PositionModel);
		this.NIJLJGDNBHE = new PhotonTransformViewRotationControl(this.m_RotationModel);
		this.JAJKFGFBPIL = new PhotonTransformViewScaleControl(this.m_ScaleModel);
	}

	// Token: 0x0600BA51 RID: 47697 RVA: 0x0043D1CD File Offset: 0x0043B3CD
	public void OAKGOHPMEDF(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		this.DKKKOMOJCIF.SetSynchronizedValues(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	// Token: 0x0600BA52 RID: 47698 RVA: 0x0043DEE8 File Offset: 0x0043C0E8
	private void LGNMHMDEECO()
	{
		this.GDIAJCAHCEC = base.GetComponent<PhotonView>();
		this.DKKKOMOJCIF = new PhotonTransformViewPositionControl(this.m_PositionModel);
		this.NIJLJGDNBHE = new PhotonTransformViewRotationControl(this.m_RotationModel);
		this.JAJKFGFBPIL = new PhotonTransformViewScaleControl(this.m_ScaleModel);
	}

	// Token: 0x0600BA53 RID: 47699 RVA: 0x0043DF34 File Offset: 0x0043C134
	private void IHCIMKAONKC()
	{
		if (!this.m_RotationModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localRotation = this.NIJLJGDNBHE.NNKFAAFFADP(base.transform.localRotation);
	}

	// Token: 0x0600BA54 RID: 47700 RVA: 0x0043CAB8 File Offset: 0x0043ACB8
	public void EEDIHPHLNND(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		this.DKKKOMOJCIF.CNABAIGBLIC(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	// Token: 0x0600BA55 RID: 47701 RVA: 0x0043DF73 File Offset: 0x0043C173
	private void ANKIJGCGCBF()
	{
		if (this.GDIAJCAHCEC == null || this.GDIAJCAHCEC.isMine || !PhotonNetwork.connected)
		{
			return;
		}
		this.HNOLLNNJKCO();
		this.HLGENFAPEIC();
		this.LOBECCEMCFA();
	}

	// Token: 0x0600BA56 RID: 47702 RVA: 0x0043CAB8 File Offset: 0x0043ACB8
	public void DOCHFMEEKGN(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		this.DKKKOMOJCIF.CNABAIGBLIC(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	// Token: 0x0600BA57 RID: 47703 RVA: 0x0043DFB3 File Offset: 0x0043C1B3
	private void PEGIABKFJNH()
	{
		if (!this.m_ScaleModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localScale = this.JAJKFGFBPIL.FNKIOEHHAMB(base.transform.localScale);
	}

	// Token: 0x0600BA58 RID: 47704 RVA: 0x0043DFF4 File Offset: 0x0043C1F4
	public void EJPKMLLGMGB(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		this.DKKKOMOJCIF.FBMDDFMGFMF(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		this.NIJLJGDNBHE.DAFGPDBLAMA(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		this.JAJKFGFBPIL.BAEICBGEECA(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!this.GDIAJCAHCEC.BGJKMGJBPFA() && this.m_PositionModel.DrawErrorGizmo)
		{
			this.APMIILJFAHI();
		}
		if (HCIJEDFCNOP.JKIGCGFEOOE())
		{
			this.PPJNLMEJHCN = true;
			if (this.NBJNCJAJNPP)
			{
				this.NBJNCJAJNPP = false;
				if (this.m_PositionModel.SynchronizeEnabled)
				{
					base.transform.localPosition = this.DKKKOMOJCIF.JHBPKKMPBGA();
				}
				if (this.m_RotationModel.SynchronizeEnabled)
				{
					base.transform.localRotation = this.NIJLJGDNBHE.AGKPEIKIPJI();
				}
				if (this.m_ScaleModel.SynchronizeEnabled)
				{
					base.transform.localScale = this.JAJKFGFBPIL.HIAGDLDLOJO();
				}
			}
		}
	}

	// Token: 0x0600BA59 RID: 47705 RVA: 0x0043E108 File Offset: 0x0043C308
	private void EMKLCPGKNJL()
	{
		this.GDIAJCAHCEC = base.GetComponent<PhotonView>();
		this.DKKKOMOJCIF = new PhotonTransformViewPositionControl(this.m_PositionModel);
		this.NIJLJGDNBHE = new PhotonTransformViewRotationControl(this.m_RotationModel);
		this.JAJKFGFBPIL = new PhotonTransformViewScaleControl(this.m_ScaleModel);
	}

	// Token: 0x0600BA5A RID: 47706 RVA: 0x0043E154 File Offset: 0x0043C354
	private void ILAMPNNIIPC()
	{
		if (!this.m_PositionModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localPosition = this.DKKKOMOJCIF.GLDIJDCGPJG(base.transform.localPosition);
	}

	// Token: 0x0600BA5B RID: 47707 RVA: 0x0043D1CD File Offset: 0x0043B3CD
	public void HGHNBKDLGJF(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		this.DKKKOMOJCIF.SetSynchronizedValues(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	// Token: 0x0600BA5C RID: 47708 RVA: 0x0043CAB8 File Offset: 0x0043ACB8
	public void ENJMPDFKPJD(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		this.DKKKOMOJCIF.CNABAIGBLIC(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	// Token: 0x0600BA5D RID: 47709 RVA: 0x0043E193 File Offset: 0x0043C393
	private void IFDDACMDNOO()
	{
		if (!this.m_ScaleModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localScale = this.JAJKFGFBPIL.HJKPAPHBNND(base.transform.localScale);
	}

	// Token: 0x0600BA5E RID: 47710 RVA: 0x0043E1D4 File Offset: 0x0043C3D4
	private void EAOINGGMHOH()
	{
		Vector3 vector = this.DKKKOMOJCIF.APJJAKOIMIK();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 779f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 1103f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 175f);
	}

	// Token: 0x0600BA5F RID: 47711 RVA: 0x0043E280 File Offset: 0x0043C480
	public void OnPhotonSerializeView(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		this.DKKKOMOJCIF.OnPhotonSerializeView(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		this.NIJLJGDNBHE.OnPhotonSerializeView(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		this.JAJKFGFBPIL.OnPhotonSerializeView(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!this.GDIAJCAHCEC.isMine && this.m_PositionModel.DrawErrorGizmo)
		{
			this.EEFIMMHNBAC();
		}
		if (HCIJEDFCNOP.isReading)
		{
			this.PPJNLMEJHCN = true;
			if (this.NBJNCJAJNPP)
			{
				this.NBJNCJAJNPP = false;
				if (this.m_PositionModel.SynchronizeEnabled)
				{
					base.transform.localPosition = this.DKKKOMOJCIF.GetNetworkPosition();
				}
				if (this.m_RotationModel.SynchronizeEnabled)
				{
					base.transform.localRotation = this.NIJLJGDNBHE.GetNetworkRotation();
				}
				if (this.m_ScaleModel.SynchronizeEnabled)
				{
					base.transform.localScale = this.JAJKFGFBPIL.GetNetworkScale();
				}
			}
		}
	}

	// Token: 0x0600BA60 RID: 47712 RVA: 0x0043D1CD File Offset: 0x0043B3CD
	public void KOJEAMINJFE(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		this.DKKKOMOJCIF.SetSynchronizedValues(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	// Token: 0x0600BA61 RID: 47713 RVA: 0x0043D70C File Offset: 0x0043B90C
	private void BKDGEHFBEPA()
	{
		if (!this.m_ScaleModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localScale = this.JAJKFGFBPIL.NKLAIOJCAHD(base.transform.localScale);
	}

	// Token: 0x0600BA62 RID: 47714 RVA: 0x0043E391 File Offset: 0x0043C591
	private void OGHNPKKPLKE()
	{
		if (!this.m_ScaleModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localScale = this.JAJKFGFBPIL.GCKHEBOACNA(base.transform.localScale);
	}

	// Token: 0x0600BA63 RID: 47715 RVA: 0x0043D1CD File Offset: 0x0043B3CD
	public void GNKBEAPDNOE(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		this.DKKKOMOJCIF.SetSynchronizedValues(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	// Token: 0x0600BA64 RID: 47716 RVA: 0x0043E3D0 File Offset: 0x0043C5D0
	public void MOLNBJLBPOO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		this.DKKKOMOJCIF.PNLAIDLOIDE(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		this.NIJLJGDNBHE.GBNDJBNLKLI(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		this.JAJKFGFBPIL.BAEICBGEECA(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!this.GDIAJCAHCEC.isMine && this.m_PositionModel.DrawErrorGizmo)
		{
			this.BBJHDJBGDAN();
		}
		if (HCIJEDFCNOP.EMLLALJBPJF())
		{
			this.PPJNLMEJHCN = true;
			if (this.NBJNCJAJNPP)
			{
				this.NBJNCJAJNPP = true;
				if (this.m_PositionModel.SynchronizeEnabled)
				{
					base.transform.localPosition = this.DKKKOMOJCIF.MDAKHCPMDIE();
				}
				if (this.m_RotationModel.SynchronizeEnabled)
				{
					base.transform.localRotation = this.NIJLJGDNBHE.PGGPFBOADOB();
				}
				if (this.m_ScaleModel.SynchronizeEnabled)
				{
					base.transform.localScale = this.JAJKFGFBPIL.PEFDNEOFNBE();
				}
			}
		}
	}

	// Token: 0x0600BA65 RID: 47717 RVA: 0x0043E4E4 File Offset: 0x0043C6E4
	public void IFDFBONAJEG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		this.DKKKOMOJCIF.PKDPLHBMKPM(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		this.NIJLJGDNBHE.NMMEHKPNBCA(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		this.JAJKFGFBPIL.DLFLONFGGGG(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!this.GDIAJCAHCEC.BGJKMGJBPFA() && this.m_PositionModel.DrawErrorGizmo)
		{
			this.MNHPFGNPMNL();
		}
		if (HCIJEDFCNOP.EKDCDLDMKDL())
		{
			this.PPJNLMEJHCN = false;
			if (this.NBJNCJAJNPP)
			{
				this.NBJNCJAJNPP = true;
				if (this.m_PositionModel.SynchronizeEnabled)
				{
					base.transform.localPosition = this.DKKKOMOJCIF.GetNetworkPosition();
				}
				if (this.m_RotationModel.SynchronizeEnabled)
				{
					base.transform.localRotation = this.NIJLJGDNBHE.OAHAHAGJAPD();
				}
				if (this.m_ScaleModel.SynchronizeEnabled)
				{
					base.transform.localScale = this.JAJKFGFBPIL.JHLAPBECKPH();
				}
			}
		}
	}

	// Token: 0x0600BA66 RID: 47718 RVA: 0x0043D74B File Offset: 0x0043B94B
	private void NIFJMJGAMGI()
	{
		if (!this.m_ScaleModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localScale = this.JAJKFGFBPIL.GetScale(base.transform.localScale);
	}

	// Token: 0x0600BA67 RID: 47719 RVA: 0x0043CAB8 File Offset: 0x0043ACB8
	public void PMMMEJDBJAH(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		this.DKKKOMOJCIF.CNABAIGBLIC(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	// Token: 0x0600BA68 RID: 47720 RVA: 0x0043CAB8 File Offset: 0x0043ACB8
	public void JOHIEOOOHNA(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		this.DKKKOMOJCIF.CNABAIGBLIC(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	// Token: 0x0600BA69 RID: 47721 RVA: 0x0043CAC7 File Offset: 0x0043ACC7
	private void GBNCNPAMMLD()
	{
		if (!this.m_RotationModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localRotation = this.NIJLJGDNBHE.JIHNIHKFFBN(base.transform.localRotation);
	}

	// Token: 0x0600BA6A RID: 47722 RVA: 0x0043E391 File Offset: 0x0043C591
	private void CAOGNPLGMEH()
	{
		if (!this.m_ScaleModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localScale = this.JAJKFGFBPIL.GCKHEBOACNA(base.transform.localScale);
	}

	// Token: 0x0600BA6B RID: 47723 RVA: 0x0043E5F5 File Offset: 0x0043C7F5
	private void EOPMOFAGCGP()
	{
		if (!this.m_RotationModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localRotation = this.NIJLJGDNBHE.HCGAJCIDHPO(base.transform.localRotation);
	}

	// Token: 0x0600BA6C RID: 47724 RVA: 0x0043D44D File Offset: 0x0043B64D
	private void BKCJHBJCAKO()
	{
		this.NBJNCJAJNPP = true;
	}

	// Token: 0x0600BA6D RID: 47725 RVA: 0x0043E634 File Offset: 0x0043C834
	private void Update()
	{
		if (this.GDIAJCAHCEC == null || this.GDIAJCAHCEC.isMine || !PhotonNetwork.connected)
		{
			return;
		}
		this.OJHFIEEDJGB();
		this.ALOAIMHLEFK();
		this.IPIDOPPAPPH();
	}

	// Token: 0x0600BA6E RID: 47726 RVA: 0x0043D9C7 File Offset: 0x0043BBC7
	private void LIFBFDKFMMH()
	{
		this.NBJNCJAJNPP = false;
	}

	// Token: 0x0600BA6F RID: 47727 RVA: 0x0043E674 File Offset: 0x0043C874
	private void PAJLGDDPDFL()
	{
		if (!this.m_RotationModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localRotation = this.NIJLJGDNBHE.BOEOKPPMJFP(base.transform.localRotation);
	}

	// Token: 0x0600BA70 RID: 47728 RVA: 0x0043E6B4 File Offset: 0x0043C8B4
	private void GCNKABKPNOJ()
	{
		this.GDIAJCAHCEC = base.GetComponent<PhotonView>();
		this.DKKKOMOJCIF = new PhotonTransformViewPositionControl(this.m_PositionModel);
		this.NIJLJGDNBHE = new PhotonTransformViewRotationControl(this.m_RotationModel);
		this.JAJKFGFBPIL = new PhotonTransformViewScaleControl(this.m_ScaleModel);
	}

	// Token: 0x0600BA71 RID: 47729 RVA: 0x0043D1CD File Offset: 0x0043B3CD
	public void PBBNDLOHDNH(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		this.DKKKOMOJCIF.SetSynchronizedValues(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	// Token: 0x0600BA72 RID: 47730 RVA: 0x0043E193 File Offset: 0x0043C393
	private void BNDCAGHJMJN()
	{
		if (!this.m_ScaleModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localScale = this.JAJKFGFBPIL.HJKPAPHBNND(base.transform.localScale);
	}

	// Token: 0x0600BA73 RID: 47731 RVA: 0x0043D02F File Offset: 0x0043B22F
	private void EMAHOMAPBNL()
	{
		if (!this.m_PositionModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localPosition = this.DKKKOMOJCIF.DEEDPNNEJPO(base.transform.localPosition);
	}

	// Token: 0x0600BA74 RID: 47732 RVA: 0x0043D7C9 File Offset: 0x0043B9C9
	private void LPJAEOBLLPF()
	{
		if (!this.m_PositionModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localPosition = this.DKKKOMOJCIF.UpdatePosition(base.transform.localPosition);
	}

	// Token: 0x0600BA75 RID: 47733 RVA: 0x0043D9C7 File Offset: 0x0043BBC7
	private void KFCCKOBOLAH()
	{
		this.NBJNCJAJNPP = false;
	}

	// Token: 0x0600BA76 RID: 47734 RVA: 0x0043DB20 File Offset: 0x0043BD20
	private void EKFBJDDMDGE()
	{
		if (!this.m_RotationModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localRotation = this.NIJLJGDNBHE.IGMHPDBMMMH(base.transform.localRotation);
	}

	// Token: 0x0600BA77 RID: 47735 RVA: 0x0043D1CD File Offset: 0x0043B3CD
	public void CHPEJCIKJOF(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		this.DKKKOMOJCIF.SetSynchronizedValues(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	// Token: 0x0600BA78 RID: 47736 RVA: 0x0043CF44 File Offset: 0x0043B144
	private void MDFMACKDHBH()
	{
		if (!this.m_PositionModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localPosition = this.DKKKOMOJCIF.FBGHNHMHIFM(base.transform.localPosition);
	}

	// Token: 0x0600BA79 RID: 47737 RVA: 0x0043E700 File Offset: 0x0043C900
	private void ENKEBEKGAFM()
	{
		if (!this.m_RotationModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localRotation = this.NIJLJGDNBHE.GKJEOLEBMMP(base.transform.localRotation);
	}

	// Token: 0x0600BA7A RID: 47738 RVA: 0x0043D1CD File Offset: 0x0043B3CD
	public void CMIKIPBKBPH(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		this.DKKKOMOJCIF.SetSynchronizedValues(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	// Token: 0x0600BA7B RID: 47739 RVA: 0x0043D44D File Offset: 0x0043B64D
	private void OnEnable()
	{
		this.NBJNCJAJNPP = true;
	}

	// Token: 0x0600BA7C RID: 47740 RVA: 0x0043E73F File Offset: 0x0043C93F
	private void KFMEAMBLODG()
	{
		if (this.GDIAJCAHCEC == null || this.GDIAJCAHCEC.isMine || !PhotonNetwork.connected)
		{
			return;
		}
		this.BFEPFLEBEFK();
		this.PPPFNMIOPNH();
		this.BHCIENHFBNC();
	}

	// Token: 0x0600BA7D RID: 47741 RVA: 0x0043E77F File Offset: 0x0043C97F
	private void MECJHOJPODB()
	{
		if (this.GDIAJCAHCEC == null || this.GDIAJCAHCEC.isMine || !PhotonNetwork.connected)
		{
			return;
		}
		this.BFEPFLEBEFK();
		this.APJEGOELEGG();
		this.CAOGNPLGMEH();
	}

	// Token: 0x0600BA7E RID: 47742 RVA: 0x0043E7BF File Offset: 0x0043C9BF
	private void BCJPFGDJAID()
	{
		if (!this.m_RotationModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localRotation = this.NIJLJGDNBHE.ABCJPDICMOB(base.transform.localRotation);
	}

	// Token: 0x0600BA7F RID: 47743 RVA: 0x0043E800 File Offset: 0x0043CA00
	private void BBJHDJBGDAN()
	{
		Vector3 vector = this.DKKKOMOJCIF.APJJAKOIMIK();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 1039f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 1802f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 28f);
	}

	// Token: 0x0600BA80 RID: 47744 RVA: 0x0043D1CD File Offset: 0x0043B3CD
	public void IDHELAJOLCB(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		this.DKKKOMOJCIF.SetSynchronizedValues(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	// Token: 0x0600BA81 RID: 47745 RVA: 0x0043E8AC File Offset: 0x0043CAAC
	private void FGIMGAKLNGD()
	{
		Vector3 vector = this.DKKKOMOJCIF.GetNetworkPosition();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 1258f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 257f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 6f);
	}

	// Token: 0x0600BA82 RID: 47746 RVA: 0x0043CF44 File Offset: 0x0043B144
	private void KCOFHPBDLLP()
	{
		if (!this.m_PositionModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localPosition = this.DKKKOMOJCIF.FBGHNHMHIFM(base.transform.localPosition);
	}

	// Token: 0x0600BA83 RID: 47747 RVA: 0x0043C97F File Offset: 0x0043AB7F
	private void BFEPFLEBEFK()
	{
		if (!this.m_PositionModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localPosition = this.DKKKOMOJCIF.BEDHNBMPPGM(base.transform.localPosition);
	}

	// Token: 0x0600BA84 RID: 47748 RVA: 0x0043D7C9 File Offset: 0x0043B9C9
	private void AMPGFJNNALG()
	{
		if (!this.m_PositionModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localPosition = this.DKKKOMOJCIF.UpdatePosition(base.transform.localPosition);
	}

	// Token: 0x0600BA85 RID: 47749 RVA: 0x0043E958 File Offset: 0x0043CB58
	private void OICPDNHGCLA()
	{
		Vector3 vector = this.DKKKOMOJCIF.APJJAKOIMIK();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 799f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 639f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 395f);
	}

	// Token: 0x0600BA86 RID: 47750 RVA: 0x0043EA04 File Offset: 0x0043CC04
	public void ONJLEAGAKAG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		this.DKKKOMOJCIF.FBMDDFMGFMF(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		this.NIJLJGDNBHE.HODGFKONIFC(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		this.JAJKFGFBPIL.BAEICBGEECA(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!this.GDIAJCAHCEC.KCAOJFPDEIP() && this.m_PositionModel.DrawErrorGizmo)
		{
			this.OICPDNHGCLA();
		}
		if (HCIJEDFCNOP.EMLLALJBPJF())
		{
			this.PPJNLMEJHCN = false;
			if (this.NBJNCJAJNPP)
			{
				this.NBJNCJAJNPP = true;
				if (this.m_PositionModel.SynchronizeEnabled)
				{
					base.transform.localPosition = this.DKKKOMOJCIF.LFJPMNKJBMG();
				}
				if (this.m_RotationModel.SynchronizeEnabled)
				{
					base.transform.localRotation = this.NIJLJGDNBHE.OAHAHAGJAPD();
				}
				if (this.m_ScaleModel.SynchronizeEnabled)
				{
					base.transform.localScale = this.JAJKFGFBPIL.HIAGDLDLOJO();
				}
			}
		}
	}

	// Token: 0x0600BA87 RID: 47751 RVA: 0x0043EB18 File Offset: 0x0043CD18
	private void AEEKOEDHGAM()
	{
		Vector3 vector = this.DKKKOMOJCIF.NLNDBCNKLJH();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 1330f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 1405f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 1160f);
	}

	// Token: 0x0600BA88 RID: 47752 RVA: 0x0043DFB3 File Offset: 0x0043C1B3
	private void BDLEJBFBIEK()
	{
		if (!this.m_ScaleModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localScale = this.JAJKFGFBPIL.FNKIOEHHAMB(base.transform.localScale);
	}

	// Token: 0x0600BA89 RID: 47753 RVA: 0x0043EBC4 File Offset: 0x0043CDC4
	public void BJHJEDJDCEN(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		this.DKKKOMOJCIF.HMMHABFJHEC(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		this.NIJLJGDNBHE.PNLAIDLOIDE(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		this.JAJKFGFBPIL.BAEICBGEECA(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!this.GDIAJCAHCEC.BGJKMGJBPFA() && this.m_PositionModel.DrawErrorGizmo)
		{
			this.OICPDNHGCLA();
		}
		if (HCIJEDFCNOP.JKIGCGFEOOE())
		{
			this.PPJNLMEJHCN = false;
			if (this.NBJNCJAJNPP)
			{
				this.NBJNCJAJNPP = true;
				if (this.m_PositionModel.SynchronizeEnabled)
				{
					base.transform.localPosition = this.DKKKOMOJCIF.LFJPMNKJBMG();
				}
				if (this.m_RotationModel.SynchronizeEnabled)
				{
					base.transform.localRotation = this.NIJLJGDNBHE.AOLDNFKNMAP();
				}
				if (this.m_ScaleModel.SynchronizeEnabled)
				{
					base.transform.localScale = this.JAJKFGFBPIL.JBGODNPHENN();
				}
			}
		}
	}

	// Token: 0x0600BA8A RID: 47754 RVA: 0x0043E154 File Offset: 0x0043C354
	private void COOIEKBKCPL()
	{
		if (!this.m_PositionModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localPosition = this.DKKKOMOJCIF.GLDIJDCGPJG(base.transform.localPosition);
	}

	// Token: 0x0600BA8B RID: 47755 RVA: 0x0043ECD8 File Offset: 0x0043CED8
	private void GPMDMOCJONP()
	{
		Vector3 vector = this.DKKKOMOJCIF.NLNDBCNKLJH();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 1799f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 1641f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 1680f);
	}

	// Token: 0x0600BA8C RID: 47756 RVA: 0x0043C97F File Offset: 0x0043AB7F
	private void DEEDPNNEJPO()
	{
		if (!this.m_PositionModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localPosition = this.DKKKOMOJCIF.BEDHNBMPPGM(base.transform.localPosition);
	}

	// Token: 0x0600BA8D RID: 47757 RVA: 0x0043DAE1 File Offset: 0x0043BCE1
	private void APJEGOELEGG()
	{
		if (!this.m_RotationModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localRotation = this.NIJLJGDNBHE.GLDKMEANMAL(base.transform.localRotation);
	}

	// Token: 0x0600BA8E RID: 47758 RVA: 0x0043ED84 File Offset: 0x0043CF84
	private void MNHPFGNPMNL()
	{
		Vector3 vector = this.DKKKOMOJCIF.MDAKHCPMDIE();
		if (base.transform.parent != null)
		{
			vector = base.transform.parent.position + vector;
		}
		Debug.DrawLine(vector, base.transform.position, Color.red, 514f);
		Debug.DrawLine(base.transform.position, base.transform.position + Vector3.up, Color.green, 95f);
		Debug.DrawLine(vector, vector + Vector3.up, Color.red, 1497f);
	}

	// Token: 0x0600BA8F RID: 47759 RVA: 0x0043E391 File Offset: 0x0043C591
	private void BHCIENHFBNC()
	{
		if (!this.m_ScaleModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localScale = this.JAJKFGFBPIL.GCKHEBOACNA(base.transform.localScale);
	}

	// Token: 0x0600BA90 RID: 47760 RVA: 0x0043EE30 File Offset: 0x0043D030
	private void GOBHPAJFFDB()
	{
		this.GDIAJCAHCEC = base.GetComponent<PhotonView>();
		this.DKKKOMOJCIF = new PhotonTransformViewPositionControl(this.m_PositionModel);
		this.NIJLJGDNBHE = new PhotonTransformViewRotationControl(this.m_RotationModel);
		this.JAJKFGFBPIL = new PhotonTransformViewScaleControl(this.m_ScaleModel);
	}

	// Token: 0x0600BA91 RID: 47761 RVA: 0x0043DB20 File Offset: 0x0043BD20
	private void HLGENFAPEIC()
	{
		if (!this.m_RotationModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localRotation = this.NIJLJGDNBHE.IGMHPDBMMMH(base.transform.localRotation);
	}

	// Token: 0x0600BA92 RID: 47762 RVA: 0x0043D74B File Offset: 0x0043B94B
	private void LOBECCEMCFA()
	{
		if (!this.m_ScaleModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localScale = this.JAJKFGFBPIL.GetScale(base.transform.localScale);
	}

	// Token: 0x0600BA93 RID: 47763 RVA: 0x0043C97F File Offset: 0x0043AB7F
	private void HGKEFDMBELD()
	{
		if (!this.m_PositionModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localPosition = this.DKKKOMOJCIF.BEDHNBMPPGM(base.transform.localPosition);
	}

	// Token: 0x0600BA94 RID: 47764 RVA: 0x0043EE7C File Offset: 0x0043D07C
	private void DLNMAGMEIOA()
	{
		if (!this.m_RotationModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localRotation = this.NIJLJGDNBHE.PMEKGEFAEON(base.transform.localRotation);
	}

	// Token: 0x0600BA95 RID: 47765 RVA: 0x0043EEBB File Offset: 0x0043D0BB
	private void FABKIGNFECE()
	{
		if (this.GDIAJCAHCEC == null || this.GDIAJCAHCEC.isMine || !PhotonNetwork.connected)
		{
			return;
		}
		this.JLDJIHNGDMP();
		this.HLGENFAPEIC();
		this.PEGIABKFJNH();
	}

	// Token: 0x0600BA96 RID: 47766 RVA: 0x0043D44D File Offset: 0x0043B64D
	private void HENBNNAGIKN()
	{
		this.NBJNCJAJNPP = true;
	}

	// Token: 0x0600BA97 RID: 47767 RVA: 0x0043D02F File Offset: 0x0043B22F
	private void IACFFKGGFKB()
	{
		if (!this.m_PositionModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localPosition = this.DKKKOMOJCIF.DEEDPNNEJPO(base.transform.localPosition);
	}

	// Token: 0x0600BA98 RID: 47768 RVA: 0x0043EEFC File Offset: 0x0043D0FC
	private void PNMCFKNENLJ()
	{
		this.GDIAJCAHCEC = base.GetComponent<PhotonView>();
		this.DKKKOMOJCIF = new PhotonTransformViewPositionControl(this.m_PositionModel);
		this.NIJLJGDNBHE = new PhotonTransformViewRotationControl(this.m_RotationModel);
		this.JAJKFGFBPIL = new PhotonTransformViewScaleControl(this.m_ScaleModel);
	}

	// Token: 0x0600BA99 RID: 47769 RVA: 0x0043EF48 File Offset: 0x0043D148
	public void NLCNKMOLPNL(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		this.DKKKOMOJCIF.PNLAIDLOIDE(base.transform.localPosition, HCIJEDFCNOP, DAGALCAILLN);
		this.NIJLJGDNBHE.DCKLCCMEGAA(base.transform.localRotation, HCIJEDFCNOP, DAGALCAILLN);
		this.JAJKFGFBPIL.DLFLONFGGGG(base.transform.localScale, HCIJEDFCNOP, DAGALCAILLN);
		if (!this.GDIAJCAHCEC.KCAOJFPDEIP() && this.m_PositionModel.DrawErrorGizmo)
		{
			this.JHOGBKNMCIF();
		}
		if (HCIJEDFCNOP.JKIGCGFEOOE())
		{
			this.PPJNLMEJHCN = true;
			if (this.NBJNCJAJNPP)
			{
				this.NBJNCJAJNPP = false;
				if (this.m_PositionModel.SynchronizeEnabled)
				{
					base.transform.localPosition = this.DKKKOMOJCIF.MDAKHCPMDIE();
				}
				if (this.m_RotationModel.SynchronizeEnabled)
				{
					base.transform.localRotation = this.NIJLJGDNBHE.BKIPKPDHDEL();
				}
				if (this.m_ScaleModel.SynchronizeEnabled)
				{
					base.transform.localScale = this.JAJKFGFBPIL.PEFDNEOFNBE();
				}
			}
		}
	}

	// Token: 0x0600BA9A RID: 47770 RVA: 0x0043F059 File Offset: 0x0043D259
	private void ALOAIMHLEFK()
	{
		if (!this.m_RotationModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localRotation = this.NIJLJGDNBHE.GetRotation(base.transform.localRotation);
	}

	// Token: 0x0600BA9B RID: 47771 RVA: 0x0043F098 File Offset: 0x0043D298
	private void IICACFLHBCP()
	{
		this.GDIAJCAHCEC = base.GetComponent<PhotonView>();
		this.DKKKOMOJCIF = new PhotonTransformViewPositionControl(this.m_PositionModel);
		this.NIJLJGDNBHE = new PhotonTransformViewRotationControl(this.m_RotationModel);
		this.JAJKFGFBPIL = new PhotonTransformViewScaleControl(this.m_ScaleModel);
	}

	// Token: 0x0600BA9C RID: 47772 RVA: 0x0043F0E4 File Offset: 0x0043D2E4
	private void LEHKEGLAPPO()
	{
		if (!this.m_RotationModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localRotation = this.NIJLJGDNBHE.JJIODDBPLDP(base.transform.localRotation);
	}

	// Token: 0x0600BA9D RID: 47773 RVA: 0x0043F124 File Offset: 0x0043D324
	private void IIPMEPPIFCK()
	{
		this.GDIAJCAHCEC = base.GetComponent<PhotonView>();
		this.DKKKOMOJCIF = new PhotonTransformViewPositionControl(this.m_PositionModel);
		this.NIJLJGDNBHE = new PhotonTransformViewRotationControl(this.m_RotationModel);
		this.JAJKFGFBPIL = new PhotonTransformViewScaleControl(this.m_ScaleModel);
	}

	// Token: 0x0600BA9E RID: 47774 RVA: 0x0043F170 File Offset: 0x0043D370
	private void JOBBGDGHJMB()
	{
		this.GDIAJCAHCEC = base.GetComponent<PhotonView>();
		this.DKKKOMOJCIF = new PhotonTransformViewPositionControl(this.m_PositionModel);
		this.NIJLJGDNBHE = new PhotonTransformViewRotationControl(this.m_RotationModel);
		this.JAJKFGFBPIL = new PhotonTransformViewScaleControl(this.m_ScaleModel);
	}

	// Token: 0x0600BA9F RID: 47775 RVA: 0x0043D9C7 File Offset: 0x0043BBC7
	private void BBPDDHFHJCG()
	{
		this.NBJNCJAJNPP = false;
	}

	// Token: 0x0600BAA0 RID: 47776 RVA: 0x0043DAE1 File Offset: 0x0043BCE1
	private void CGEKJECJIKC()
	{
		if (!this.m_RotationModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localRotation = this.NIJLJGDNBHE.GLDKMEANMAL(base.transform.localRotation);
	}

	// Token: 0x0600BAA1 RID: 47777 RVA: 0x0043F1BC File Offset: 0x0043D3BC
	private void FGNFILLNPJK()
	{
		if (this.GDIAJCAHCEC == null || this.GDIAJCAHCEC.BGJKMGJBPFA() || !PhotonNetwork.connected)
		{
			return;
		}
		this.OHPBHCGDONH();
		this.IHJHGLDCHFK();
		this.IPIDOPPAPPH();
	}

	// Token: 0x0600BAA2 RID: 47778 RVA: 0x0043D44D File Offset: 0x0043B64D
	private void FLHBCHLMOFK()
	{
		this.NBJNCJAJNPP = true;
	}

	// Token: 0x0600BAA3 RID: 47779 RVA: 0x0043E700 File Offset: 0x0043C900
	private void PMOBDAJCAAP()
	{
		if (!this.m_RotationModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localRotation = this.NIJLJGDNBHE.GKJEOLEBMMP(base.transform.localRotation);
	}

	// Token: 0x0600BAA4 RID: 47780 RVA: 0x0043D1CD File Offset: 0x0043B3CD
	public void SetSynchronizedValues(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		this.DKKKOMOJCIF.SetSynchronizedValues(KEDDLFDAIDE, HGHGFIDFHLO);
	}

	// Token: 0x0600BAA5 RID: 47781 RVA: 0x0043D7C9 File Offset: 0x0043B9C9
	private void OHPBHCGDONH()
	{
		if (!this.m_PositionModel.SynchronizeEnabled || !this.PPJNLMEJHCN)
		{
			return;
		}
		base.transform.localPosition = this.DKKKOMOJCIF.UpdatePosition(base.transform.localPosition);
	}

	// Token: 0x040015C4 RID: 5572
	[SerializeField]
	private PhotonTransformViewPositionModel m_PositionModel = new PhotonTransformViewPositionModel();

	// Token: 0x040015C5 RID: 5573
	[SerializeField]
	private PhotonTransformViewRotationModel m_RotationModel = new PhotonTransformViewRotationModel();

	// Token: 0x040015C6 RID: 5574
	[SerializeField]
	private PhotonTransformViewScaleModel m_ScaleModel = new PhotonTransformViewScaleModel();

	// Token: 0x040015C7 RID: 5575
	private PhotonTransformViewPositionControl DKKKOMOJCIF;

	// Token: 0x040015C8 RID: 5576
	private PhotonTransformViewRotationControl NIJLJGDNBHE;

	// Token: 0x040015C9 RID: 5577
	private PhotonTransformViewScaleControl JAJKFGFBPIL;

	// Token: 0x040015CA RID: 5578
	private PhotonView GDIAJCAHCEC;

	// Token: 0x040015CB RID: 5579
	private bool PPJNLMEJHCN;

	// Token: 0x040015CC RID: 5580
	private bool NBJNCJAJNPP;
}
