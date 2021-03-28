using System;
using Photon;
using UnityEngine;

// Token: 0x02000363 RID: 867
[RequireComponent(typeof(PhotonView))]
public class SmoothSyncMovement : Photon.MonoBehaviour, IPunObservable
{
	// Token: 0x0600C21F RID: 49695 RVA: 0x00469FF8 File Offset: 0x004681F8
	public void IEMEHGCFAPD()
	{
		if (!base.ACPGHFHDCIP().DOLKFPIABDD())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C220 RID: 49696 RVA: 0x0046A070 File Offset: 0x00468270
	public void LEAHIBJDMBI()
	{
		if (!base.GBHNDHLAJLI().DOLKFPIABDD())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C221 RID: 49697 RVA: 0x0046A0E8 File Offset: 0x004682E8
	public void APKNAPHOFHC()
	{
		if (!base.EOOCGIFFKBG().BGJKMGJBPFA())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C223 RID: 49699 RVA: 0x0046A188 File Offset: 0x00468388
	public void NDAJBJFJGCF()
	{
		if (!base.AAMNKPHHHCI().BGJKMGJBPFA())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C224 RID: 49700 RVA: 0x0046A200 File Offset: 0x00468400
	public void AFIHOEBJPCG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			HCIJEDFCNOP.OLACNHHHOEL(base.transform.position);
			HCIJEDFCNOP.IBCLJIACBKG(base.transform.rotation);
		}
		else
		{
			this.OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.FIBMOBNIALK();
			this.ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.ACOGAHJKGJH();
		}
	}

	// Token: 0x0600C225 RID: 49701 RVA: 0x0046A26C File Offset: 0x0046846C
	public void GLGOLEOAFOD()
	{
		bool flag = true;
		foreach (Component x in base.ACPGHFHDCIP().ObservedComponents)
		{
			if (x == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "CameraFilterPack/Blend2Camera_Saturation");
		}
	}

	// Token: 0x0600C226 RID: 49702 RVA: 0x0046A2F4 File Offset: 0x004684F4
	public void NEKCPLGFOFD()
	{
		if (!base.GBMJAPGLMGB().BGJKMGJBPFA())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C227 RID: 49703 RVA: 0x0046A36C File Offset: 0x0046856C
	public void PEMPABLNJHL()
	{
		bool flag = true;
		foreach (Component x in base.IBKCMBIGOEJ().ObservedComponents)
		{
			if (x == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + " Also make sure to disable sprite packing for this sprite.");
		}
	}

	// Token: 0x0600C228 RID: 49704 RVA: 0x0046A3F4 File Offset: 0x004685F4
	public void IIFCIDDJHPM()
	{
		if (!base.AAMNKPHHHCI().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C229 RID: 49705 RVA: 0x0046A46C File Offset: 0x0046866C
	public void NPFDCLNGGKC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.CPIBABMPJLE(base.transform.position);
			HCIJEDFCNOP.CPIBABMPJLE(base.transform.rotation);
		}
		else
		{
			this.OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.FIBMOBNIALK();
			this.ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.KIMDMBDNICC();
		}
	}

	// Token: 0x0600C22A RID: 49706 RVA: 0x0046A4D8 File Offset: 0x004686D8
	public void EJFJENFKLND()
	{
		if (!base.JAEJDHHCJJO().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C22B RID: 49707 RVA: 0x0046A550 File Offset: 0x00468750
	public void HMMHABFJHEC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			HCIJEDFCNOP.SendNext(base.transform.position);
			HCIJEDFCNOP.OLACNHHHOEL(base.transform.rotation);
		}
		else
		{
			this.OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.FIBMOBNIALK();
			this.ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.KIEJNJBDAJJ();
		}
	}

	// Token: 0x0600C22C RID: 49708 RVA: 0x0046A5BC File Offset: 0x004687BC
	public void CCDNJPNLGBN()
	{
		bool flag = true;
		foreach (Component x in base.BLMHOKPIMOD().ObservedComponents)
		{
			if (x == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "_Distortion");
		}
	}

	// Token: 0x0600C22D RID: 49709 RVA: 0x0046A644 File Offset: 0x00468844
	public void OCMKCBBCEFG()
	{
		if (!base.photonView.DOLKFPIABDD())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C22E RID: 49710 RVA: 0x0046A6BC File Offset: 0x004688BC
	public void JDGFCEPDKAJ()
	{
		if (!base.GBMJAPGLMGB().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C22F RID: 49711 RVA: 0x0046A734 File Offset: 0x00468934
	public void MAOCOEGAFND()
	{
		if (!base.IBKCMBIGOEJ().BGJKMGJBPFA())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C230 RID: 49712 RVA: 0x0046A7AC File Offset: 0x004689AC
	public void Update()
	{
		if (!base.photonView.isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C231 RID: 49713 RVA: 0x0046A824 File Offset: 0x00468A24
	public void JOBBGDGHJMB()
	{
		bool flag = false;
		foreach (Component x in base.GBHNDHLAJLI().ObservedComponents)
		{
			if (x == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "RB");
		}
	}

	// Token: 0x0600C232 RID: 49714 RVA: 0x0046A8AC File Offset: 0x00468AAC
	public void JJGHNKLDANI(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			HCIJEDFCNOP.OLACNHHHOEL(base.transform.position);
			HCIJEDFCNOP.PNAPNHJHBMN(base.transform.rotation);
		}
		else
		{
			this.OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.ReceiveNext();
			this.ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.LNDLNKJPAGO();
		}
	}

	// Token: 0x0600C233 RID: 49715 RVA: 0x0046A918 File Offset: 0x00468B18
	public void HDPOECGCALE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			HCIJEDFCNOP.FADAIFFMBEL(base.transform.position);
			HCIJEDFCNOP.CPIBABMPJLE(base.transform.rotation);
		}
		else
		{
			this.OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.LNDLNKJPAGO();
			this.ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.HPPOACOIMOJ();
		}
	}

	// Token: 0x0600C234 RID: 49716 RVA: 0x0046A984 File Offset: 0x00468B84
	public void OnPhotonSerializeView(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.SendNext(base.transform.position);
			HCIJEDFCNOP.SendNext(base.transform.rotation);
		}
		else
		{
			this.OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.ReceiveNext();
			this.ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.ReceiveNext();
		}
	}

	// Token: 0x0600C235 RID: 49717 RVA: 0x0046A9F0 File Offset: 0x00468BF0
	public void JAAJECBCCFM()
	{
		if (!base.GBMJAPGLMGB().BGJKMGJBPFA())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C236 RID: 49718 RVA: 0x0046AA68 File Offset: 0x00468C68
	public void Awake()
	{
		bool flag = false;
		foreach (Component x in base.photonView.ObservedComponents)
		{
			if (x == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + " is not observed by this object's photonView! OnPhotonSerializeView() in this class won't be used.");
		}
	}

	// Token: 0x0600C237 RID: 49719 RVA: 0x0046AAF0 File Offset: 0x00468CF0
	public void CNDGDDLEFJF()
	{
		bool flag = true;
		foreach (Component x in base.GBHNDHLAJLI().ObservedComponents)
		{
			if (x == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "settings.fps");
		}
	}

	// Token: 0x0600C238 RID: 49720 RVA: 0x0046AB78 File Offset: 0x00468D78
	public void PGMEOJJFIEN(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.BBHGPGBHMML(base.transform.position);
			HCIJEDFCNOP.PBECMJMDHBI(base.transform.rotation);
		}
		else
		{
			this.OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.HPPOACOIMOJ();
			this.ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.ACOGAHJKGJH();
		}
	}

	// Token: 0x0600C239 RID: 49721 RVA: 0x0046ABE4 File Offset: 0x00468DE4
	public void AAPKBNDHBLI()
	{
		if (!base.OELHGNKAMEG().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C23A RID: 49722 RVA: 0x0046AC5C File Offset: 0x00468E5C
	public void HMNLHMLILKD()
	{
		if (!base.IBKCMBIGOEJ().KCAOJFPDEIP())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C23B RID: 49723 RVA: 0x0046ACD4 File Offset: 0x00468ED4
	public void FJHFOBHJEHL()
	{
		if (!base.OELHGNKAMEG().BGJKMGJBPFA())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C23C RID: 49724 RVA: 0x0046AD4C File Offset: 0x00468F4C
	public void PIIMBOLGHOE()
	{
		bool flag = false;
		foreach (Component x in base.OELHGNKAMEG().ObservedComponents)
		{
			if (x == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "IconImage");
		}
	}

	// Token: 0x0600C23D RID: 49725 RVA: 0x0046ADD4 File Offset: 0x00468FD4
	public void EGEGNHLODAA()
	{
		if (!base.AAMNKPHHHCI().KCAOJFPDEIP())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C23E RID: 49726 RVA: 0x0046AE4C File Offset: 0x0046904C
	public void CFIAKIJAILI()
	{
		if (!base.BLMHOKPIMOD().DOLKFPIABDD())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C23F RID: 49727 RVA: 0x0046AEC4 File Offset: 0x004690C4
	public void JIBGLHBMGPP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.BBHGPGBHMML(base.transform.position);
			HCIJEDFCNOP.SendNext(base.transform.rotation);
		}
		else
		{
			this.OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.HPPOACOIMOJ();
			this.ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.HPPOACOIMOJ();
		}
	}

	// Token: 0x0600C240 RID: 49728 RVA: 0x0046AF30 File Offset: 0x00469130
	public void PMBIKIBOHOF()
	{
		bool flag = true;
		foreach (Component x in base.CIACEFBNDDJ().ObservedComponents)
		{
			if (x == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "_Value2");
		}
	}

	// Token: 0x0600C241 RID: 49729 RVA: 0x0046AFB8 File Offset: 0x004691B8
	public void PNLAIDLOIDE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			HCIJEDFCNOP.CPIBABMPJLE(base.transform.position);
			HCIJEDFCNOP.CPIBABMPJLE(base.transform.rotation);
		}
		else
		{
			this.OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.FIBMOBNIALK();
			this.ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.IDKHBJIHKEB();
		}
	}

	// Token: 0x0600C242 RID: 49730 RVA: 0x0046B024 File Offset: 0x00469224
	public void FIABIKEIEKH()
	{
		bool flag = false;
		foreach (Component x in base.BLMHOKPIMOD().ObservedComponents)
		{
			if (x == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "EventMenu");
		}
	}

	// Token: 0x0600C243 RID: 49731 RVA: 0x0046B0AC File Offset: 0x004692AC
	public void HCCMANDFEPL()
	{
		bool flag = true;
		foreach (Component x in base.GMAHNPNHMFK().ObservedComponents)
		{
			if (x == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "#yes");
		}
	}

	// Token: 0x0600C244 RID: 49732 RVA: 0x0046B134 File Offset: 0x00469334
	public void OHJHFPNGLEF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			HCIJEDFCNOP.PBECMJMDHBI(base.transform.position);
			HCIJEDFCNOP.OLACNHHHOEL(base.transform.rotation);
		}
		else
		{
			this.OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.LNDLNKJPAGO();
			this.ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.KIMDMBDNICC();
		}
	}

	// Token: 0x0600C245 RID: 49733 RVA: 0x0046B1A0 File Offset: 0x004693A0
	public void AIJGAJIOJDJ()
	{
		if (!base.OELHGNKAMEG().KCAOJFPDEIP())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C246 RID: 49734 RVA: 0x0046B218 File Offset: 0x00469418
	public void CGBHOELMAOC()
	{
		if (!base.GMAHNPNHMFK().KCAOJFPDEIP())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C247 RID: 49735 RVA: 0x0046B290 File Offset: 0x00469490
	public void DAHIMKKFNPH()
	{
		bool flag = true;
		foreach (Component x in base.JAEJDHHCJJO().ObservedComponents)
		{
			if (x == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "settings_bindings_sec_");
		}
	}

	// Token: 0x0600C248 RID: 49736 RVA: 0x0046B318 File Offset: 0x00469518
	public void HODGFKONIFC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			HCIJEDFCNOP.PNAPNHJHBMN(base.transform.position);
			HCIJEDFCNOP.PNAPNHJHBMN(base.transform.rotation);
		}
		else
		{
			this.OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
			this.ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.IDKHBJIHKEB();
		}
	}

	// Token: 0x0600C249 RID: 49737 RVA: 0x0046B384 File Offset: 0x00469584
	public void GOBHPAJFFDB()
	{
		bool flag = false;
		foreach (Component x in base.ACPGHFHDCIP().ObservedComponents)
		{
			if (x == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "Triangle");
		}
	}

	// Token: 0x0600C24A RID: 49738 RVA: 0x0046B40C File Offset: 0x0046960C
	public void AEEGKLABFLN()
	{
		if (!base.photonView.BGJKMGJBPFA())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C24B RID: 49739 RVA: 0x0046B484 File Offset: 0x00469684
	public void KMEONPMCNJG()
	{
		if (!base.GBMJAPGLMGB().BGJKMGJBPFA())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C24C RID: 49740 RVA: 0x0046B4FC File Offset: 0x004696FC
	public void JOACBIEHHCE()
	{
		if (!base.JAEJDHHCJJO().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C24D RID: 49741 RVA: 0x0046B574 File Offset: 0x00469774
	public void GCHBGCGBMCK()
	{
		if (!base.FFIPLLNKGEN().BGJKMGJBPFA())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C24E RID: 49742 RVA: 0x0046B5EC File Offset: 0x004697EC
	public void GEGFJJBCHPE()
	{
		bool flag = true;
		foreach (Component x in base.BLMHOKPIMOD().ObservedComponents)
		{
			if (x == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "14");
		}
	}

	// Token: 0x0600C24F RID: 49743 RVA: 0x0046B674 File Offset: 0x00469874
	public void FBMDHDBELEK()
	{
		if (!base.AAMNKPHHHCI().DOLKFPIABDD())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C250 RID: 49744 RVA: 0x0046B6EC File Offset: 0x004698EC
	public void KGMCGGIEPDE()
	{
		bool flag = true;
		foreach (Component x in base.OELHGNKAMEG().ObservedComponents)
		{
			if (x == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "offsets");
		}
	}

	// Token: 0x0600C251 RID: 49745 RVA: 0x0046B774 File Offset: 0x00469974
	public void DPIPGGDNGHN()
	{
		if (!base.GBHNDHLAJLI().BGJKMGJBPFA())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C252 RID: 49746 RVA: 0x0046B7EC File Offset: 0x004699EC
	public void PNLKFANNOKO()
	{
		if (!base.FFIPLLNKGEN().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C253 RID: 49747 RVA: 0x0046B864 File Offset: 0x00469A64
	public void DEJEBOGKMJO()
	{
		bool flag = true;
		foreach (Component x in base.ACPGHFHDCIP().ObservedComponents)
		{
			if (x == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "buttons");
		}
	}

	// Token: 0x0600C254 RID: 49748 RVA: 0x0046B8EC File Offset: 0x00469AEC
	public void COGBDFKOHKK()
	{
		if (!base.GMAHNPNHMFK().DOLKFPIABDD())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C255 RID: 49749 RVA: 0x0046B964 File Offset: 0x00469B64
	public void MDOBONJMBKF()
	{
		bool flag = true;
		foreach (Component x in base.BLMHOKPIMOD().ObservedComponents)
		{
			if (x == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "_Value3");
		}
	}

	// Token: 0x0600C256 RID: 49750 RVA: 0x0046B9EC File Offset: 0x00469BEC
	public void HOBJDAHLBDM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			HCIJEDFCNOP.OLACNHHHOEL(base.transform.position);
			HCIJEDFCNOP.BBHGPGBHMML(base.transform.rotation);
		}
		else
		{
			this.OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
			this.ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.IDKHBJIHKEB();
		}
	}

	// Token: 0x0600C257 RID: 49751 RVA: 0x0046BA58 File Offset: 0x00469C58
	public void FABKIGNFECE()
	{
		if (!base.ACPGHFHDCIP().KCAOJFPDEIP())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C258 RID: 49752 RVA: 0x0046BAD0 File Offset: 0x00469CD0
	public void MFMIODIAKNI()
	{
		if (!base.IBKCMBIGOEJ().DOLKFPIABDD())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C259 RID: 49753 RVA: 0x0046BB48 File Offset: 0x00469D48
	public void HBPLJMJAAHK()
	{
		bool flag = true;
		foreach (Component x in base.OELHGNKAMEG().ObservedComponents)
		{
			if (x == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "[LevelEditorScene] Error: Timeout :S");
		}
	}

	// Token: 0x0600C25A RID: 49754 RVA: 0x0046BBD0 File Offset: 0x00469DD0
	public void JNIPABEGJND()
	{
		bool flag = true;
		foreach (Component x in base.photonView.ObservedComponents)
		{
			if (x == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "CameraFilterPack/Distortion_Twist");
		}
	}

	// Token: 0x0600C25B RID: 49755 RVA: 0x0046BC58 File Offset: 0x00469E58
	public void CJHMHIMKILB()
	{
		bool flag = true;
		foreach (Component x in base.AAMNKPHHHCI().ObservedComponents)
		{
			if (x == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "Please specify either t or f.");
		}
	}

	// Token: 0x0600C25C RID: 49756 RVA: 0x0046BCE0 File Offset: 0x00469EE0
	public void GBOFDLLNLLL(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.BBHGPGBHMML(base.transform.position);
			HCIJEDFCNOP.BBHGPGBHMML(base.transform.rotation);
		}
		else
		{
			this.OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.HPPOACOIMOJ();
			this.ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.ReceiveNext();
		}
	}

	// Token: 0x0600C25D RID: 49757 RVA: 0x0046BD4C File Offset: 0x00469F4C
	public void HGKFNJAKJMH(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			HCIJEDFCNOP.OLACNHHHOEL(base.transform.position);
			HCIJEDFCNOP.IBCLJIACBKG(base.transform.rotation);
		}
		else
		{
			this.OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
			this.ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.KIMDMBDNICC();
		}
	}

	// Token: 0x0600C25E RID: 49758 RVA: 0x0046BDB8 File Offset: 0x00469FB8
	public void CNMIIGDELGE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			HCIJEDFCNOP.IBCLJIACBKG(base.transform.position);
			HCIJEDFCNOP.PBECMJMDHBI(base.transform.rotation);
		}
		else
		{
			this.OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
			this.ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.LNDLNKJPAGO();
		}
	}

	// Token: 0x0600C25F RID: 49759 RVA: 0x0046BE24 File Offset: 0x0046A024
	public void GPFJMKCGHGB()
	{
		if (!base.GMAHNPNHMFK().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C260 RID: 49760 RVA: 0x0046BE9C File Offset: 0x0046A09C
	public void PJBBBAOPOCC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.CPIBABMPJLE(base.transform.position);
			HCIJEDFCNOP.OLACNHHHOEL(base.transform.rotation);
		}
		else
		{
			this.OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
			this.ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.HPPOACOIMOJ();
		}
	}

	// Token: 0x0600C261 RID: 49761 RVA: 0x0046BF08 File Offset: 0x0046A108
	public void JHPOIOELNCG()
	{
		if (!base.ACPGHFHDCIP().BGJKMGJBPFA())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C262 RID: 49762 RVA: 0x0046BF80 File Offset: 0x0046A180
	public void KPOIJEKDFBE()
	{
		bool flag = false;
		foreach (Component x in base.IBKCMBIGOEJ().ObservedComponents)
		{
			if (x == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "PlayMusic");
		}
	}

	// Token: 0x0600C263 RID: 49763 RVA: 0x0046C008 File Offset: 0x0046A208
	public void GMELGGJOPBB()
	{
		if (!base.GMAHNPNHMFK().DOLKFPIABDD())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C264 RID: 49764 RVA: 0x0046C080 File Offset: 0x0046A280
	public void EJPAMJBIAGM(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			HCIJEDFCNOP.OLACNHHHOEL(base.transform.position);
			HCIJEDFCNOP.FADAIFFMBEL(base.transform.rotation);
		}
		else
		{
			this.OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
			this.ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.ACOGAHJKGJH();
		}
	}

	// Token: 0x0600C265 RID: 49765 RVA: 0x0046C0EC File Offset: 0x0046A2EC
	public void OJACCGOHBGH()
	{
		bool flag = false;
		foreach (Component x in base.FFIPLLNKGEN().ObservedComponents)
		{
			if (x == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "float,0");
		}
	}

	// Token: 0x0600C266 RID: 49766 RVA: 0x0046C174 File Offset: 0x0046A374
	public void NEEIFNDHDOG()
	{
		bool flag = false;
		foreach (Component x in base.CIACEFBNDDJ().ObservedComponents)
		{
			if (x == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "colorD");
		}
	}

	// Token: 0x0600C267 RID: 49767 RVA: 0x0046C1FC File Offset: 0x0046A3FC
	public void POJFHDFJOPE()
	{
		if (!base.ACPGHFHDCIP().KCAOJFPDEIP())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C268 RID: 49768 RVA: 0x0046C274 File Offset: 0x0046A474
	public void JBCNIPJDPJB()
	{
		if (!base.photonView.BGJKMGJBPFA())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C269 RID: 49769 RVA: 0x0046C2EC File Offset: 0x0046A4EC
	public void FABMDEHEDNO()
	{
		if (!base.BLMHOKPIMOD().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C26A RID: 49770 RVA: 0x0046C364 File Offset: 0x0046A564
	public void NCBGPIKDFIA()
	{
		bool flag = true;
		foreach (Component x in base.IBKCMBIGOEJ().ObservedComponents)
		{
			if (x == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "_Value3");
		}
	}

	// Token: 0x0600C26B RID: 49771 RVA: 0x0046C3EC File Offset: 0x0046A5EC
	public void PCFHKFCIFHF(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			HCIJEDFCNOP.CPIBABMPJLE(base.transform.position);
			HCIJEDFCNOP.PBECMJMDHBI(base.transform.rotation);
		}
		else
		{
			this.OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.IDKHBJIHKEB();
			this.ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.KIEJNJBDAJJ();
		}
	}

	// Token: 0x0600C26C RID: 49772 RVA: 0x0046C458 File Offset: 0x0046A658
	public void EIFCCFBJKOO()
	{
		bool flag = true;
		foreach (Component x in base.photonView.ObservedComponents)
		{
			if (x == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "_Params");
		}
	}

	// Token: 0x0600C26D RID: 49773 RVA: 0x0046C4E0 File Offset: 0x0046A6E0
	public void LPMINJJPDCH()
	{
		if (!base.EOOCGIFFKBG().KCAOJFPDEIP())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C26E RID: 49774 RVA: 0x0046C558 File Offset: 0x0046A758
	public void FODIJCCIION(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			HCIJEDFCNOP.PNAPNHJHBMN(base.transform.position);
			HCIJEDFCNOP.OLACNHHHOEL(base.transform.rotation);
		}
		else
		{
			this.OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.ReceiveNext();
			this.ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.ReceiveNext();
		}
	}

	// Token: 0x0600C26F RID: 49775 RVA: 0x0046C5C4 File Offset: 0x0046A7C4
	public void AGMJDGHLBMN()
	{
		if (!base.BLMHOKPIMOD().DOLKFPIABDD())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C270 RID: 49776 RVA: 0x0046C63C File Offset: 0x0046A83C
	public void KEGNPKFMPDG()
	{
		bool flag = true;
		foreach (Component x in base.BLMHOKPIMOD().ObservedComponents)
		{
			if (x == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "{0} hours ago");
		}
	}

	// Token: 0x0600C271 RID: 49777 RVA: 0x0046C6C4 File Offset: 0x0046A8C4
	public void GKDNDDEAAED(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.OLACNHHHOEL(base.transform.position);
			HCIJEDFCNOP.IBCLJIACBKG(base.transform.rotation);
		}
		else
		{
			this.OKGJMEKOLIM = (Vector3)HCIJEDFCNOP.ACOGAHJKGJH();
			this.ANHDBFEBADJ = (Quaternion)HCIJEDFCNOP.HPPOACOIMOJ();
		}
	}

	// Token: 0x0600C272 RID: 49778 RVA: 0x0046C730 File Offset: 0x0046A930
	public void LBIOIEANMGI()
	{
		if (!base.IBKCMBIGOEJ().DOLKFPIABDD())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C273 RID: 49779 RVA: 0x0046C7A8 File Offset: 0x0046A9A8
	public void FMAFBLKAJDF()
	{
		bool flag = true;
		foreach (Component x in base.GBHNDHLAJLI().ObservedComponents)
		{
			if (x == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "#no");
		}
	}

	// Token: 0x0600C274 RID: 49780 RVA: 0x0046C830 File Offset: 0x0046AA30
	public void POIMNOBDBBN()
	{
		if (!base.EOOCGIFFKBG().KCAOJFPDEIP())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C275 RID: 49781 RVA: 0x0046C8A8 File Offset: 0x0046AAA8
	public void MBCDCBCLMCI()
	{
		bool flag = true;
		foreach (Component x in base.FFIPLLNKGEN().ObservedComponents)
		{
			if (x == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "Error: Timeout :S");
		}
	}

	// Token: 0x0600C276 RID: 49782 RVA: 0x0046C930 File Offset: 0x0046AB30
	public void OEENOOGEEHD()
	{
		if (!base.ACPGHFHDCIP().KCAOJFPDEIP())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C277 RID: 49783 RVA: 0x0046C9A8 File Offset: 0x0046ABA8
	public void MJNPIDGNJMK()
	{
		if (!base.OELHGNKAMEG().DOLKFPIABDD())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C278 RID: 49784 RVA: 0x0046CA20 File Offset: 0x0046AC20
	public void LBOBAIGNOML()
	{
		bool flag = false;
		foreach (Component x in base.ACPGHFHDCIP().ObservedComponents)
		{
			if (x == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "Set particles gravity");
		}
	}

	// Token: 0x0600C279 RID: 49785 RVA: 0x0046CAA8 File Offset: 0x0046ACA8
	public void DGCGGKMNPLD()
	{
		if (!base.ACPGHFHDCIP().KCAOJFPDEIP())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C27A RID: 49786 RVA: 0x0046CB20 File Offset: 0x0046AD20
	public void LLJLDLLNFBH()
	{
		if (!base.JAEJDHHCJJO().isMine)
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C27B RID: 49787 RVA: 0x0046CB98 File Offset: 0x0046AD98
	public void BGFCMMDKCOI()
	{
		bool flag = false;
		foreach (Component x in base.ACPGHFHDCIP().ObservedComponents)
		{
			if (x == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "RenderTextureUtilityTempTexture");
		}
	}

	// Token: 0x0600C27C RID: 49788 RVA: 0x0046CC20 File Offset: 0x0046AE20
	public void OIBMHPIFAKK()
	{
		if (!base.AAMNKPHHHCI().KCAOJFPDEIP())
		{
			base.transform.position = Vector3.Lerp(base.transform.position, this.OKGJMEKOLIM, Time.deltaTime * this.SmoothingDelay);
			base.transform.rotation = Quaternion.Lerp(base.transform.rotation, this.ANHDBFEBADJ, Time.deltaTime * this.SmoothingDelay);
		}
	}

	// Token: 0x0600C27D RID: 49789 RVA: 0x0046CC98 File Offset: 0x0046AE98
	public void POEEMFJIMIP()
	{
		bool flag = true;
		foreach (Component x in base.IBKCMBIGOEJ().ObservedComponents)
		{
			if (x == this)
			{
				flag = false;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + ": ");
		}
	}

	// Token: 0x0600C27E RID: 49790 RVA: 0x0046CD20 File Offset: 0x0046AF20
	public void GCDNONIKKLI()
	{
		bool flag = true;
		foreach (Component x in base.EOOCGIFFKBG().ObservedComponents)
		{
			if (x == this)
			{
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			Debug.LogWarning(this + "IconImage");
		}
	}

	// Token: 0x04001687 RID: 5767
	public float SmoothingDelay = 5f;

	// Token: 0x04001688 RID: 5768
	private Vector3 OKGJMEKOLIM = Vector3.zero;

	// Token: 0x04001689 RID: 5769
	private Quaternion ANHDBFEBADJ = Quaternion.identity;
}
