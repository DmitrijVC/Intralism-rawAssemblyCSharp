using System;
using System.Collections.Generic;
using System.Reflection;
using Photon;
using UnityEngine;

// Token: 0x02000319 RID: 793
[AddComponentMenu("Photon Networking/Photon View &v")]
public class PhotonView : Photon.MonoBehaviour
{
	// Token: 0x0600B4F5 RID: 46325 RVA: 0x00428A99 File Offset: 0x00426C99
	public int LHPJFDEFJPC()
	{
		if (this.prefixBackup == -1 && PhotonNetwork.JNJJAMNLOHA != null)
		{
			this.prefixBackup = (int)PhotonNetwork.JNJJAMNLOHA.PKCNHOKCLJH;
		}
		return this.prefixBackup;
	}

	// Token: 0x0600B4F6 RID: 46326 RVA: 0x00428AC8 File Offset: 0x00426CC8
	protected internal void DOHOBEJAOED(Component GJLCNFAGNPO, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		IPunObservable punObservable = GJLCNFAGNPO as IPunObservable;
		if (punObservable != null)
		{
			punObservable.OnPhotonSerializeView(HCIJEDFCNOP, DAGALCAILLN);
		}
		else if (GJLCNFAGNPO != null)
		{
			MethodInfo methodInfo = null;
			if (!this.JKIMNJDIPLG.TryGetValue(GJLCNFAGNPO, out methodInfo))
			{
				if (!BNGIGHBHPEH.FAAKJJEMNEB(GJLCNFAGNPO as UnityEngine.MonoBehaviour, PhotonNetworkingMessage.OnPhotonSerializeView.ToString(), out methodInfo))
				{
					Debug.LogError("The observed monobehaviour (" + GJLCNFAGNPO.name + ") of this PhotonView does not implement OnPhotonSerializeView()!");
					methodInfo = null;
				}
				this.JKIMNJDIPLG.Add(GJLCNFAGNPO, methodInfo);
			}
			if (methodInfo != null)
			{
				methodInfo.Invoke(GJLCNFAGNPO, new object[]
				{
					HCIJEDFCNOP,
					DAGALCAILLN
				});
			}
		}
	}

	// Token: 0x0600B4F7 RID: 46327 RVA: 0x00428B81 File Offset: 0x00426D81
	public bool FJEMLGIGOCJ()
	{
		return this.CreatorActorNr == 0;
	}

	// Token: 0x0600B4F8 RID: 46328 RVA: 0x003FB3FA File Offset: 0x003F95FA
	public static PhotonView Get(GameObject PJCLKEBEKAP)
	{
		return PJCLKEBEKAP.GetComponent<PhotonView>();
	}

	// Token: 0x0600B4F9 RID: 46329 RVA: 0x00428B8C File Offset: 0x00426D8C
	public void OKHNMAMFDFD(string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MJCDIJOAEPI, false, GNNEKCBOBEG);
	}

	// Token: 0x0600B4FA RID: 46330 RVA: 0x00428B98 File Offset: 0x00426D98
	public void KGGHPNEFFLL()
	{
		this.HFCEJMOIGDF = base.GetComponents<UnityEngine.MonoBehaviour>();
	}

	// Token: 0x0600B4FB RID: 46331 RVA: 0x00428BA6 File Offset: 0x00426DA6
	public static PhotonView BONCCOJCGAF(int NADLIACHBNO)
	{
		return PhotonNetwork.JNJJAMNLOHA.GetPhotonView(NADLIACHBNO);
	}

	// Token: 0x0600B4FC RID: 46332 RVA: 0x00428A99 File Offset: 0x00426C99
	public int HDJPGFBJDPK()
	{
		if (this.prefixBackup == -1 && PhotonNetwork.JNJJAMNLOHA != null)
		{
			this.prefixBackup = (int)PhotonNetwork.JNJJAMNLOHA.PKCNHOKCLJH;
		}
		return this.prefixBackup;
	}

	// Token: 0x0600B4FD RID: 46333 RVA: 0x00428BB3 File Offset: 0x00426DB3
	public int GHNNKHPAFGD()
	{
		return this.ownerId;
	}

	// Token: 0x0600B4FE RID: 46334 RVA: 0x00428BBB File Offset: 0x00426DBB
	public bool DOLKFPIABDD()
	{
		return this.ownerId != PhotonNetwork.player.ID && !this.PFCJNOLLHNF() && PhotonNetwork.isMasterClient;
	}

	// Token: 0x0600B4FF RID: 46335 RVA: 0x00428BE8 File Offset: 0x00426DE8
	public void CHLIDEOBECE(int DPNHODJHGJL)
	{
		bool flag = this.GEKLBLEBECG && this.viewIdField == 0;
		this.ownerId = DPNHODJHGJL / PhotonNetwork.MAX_VIEW_IDS;
		this.viewIdField = DPNHODJHGJL;
		if (flag)
		{
			PhotonNetwork.JNJJAMNLOHA.RegisterPhotonView(this);
		}
	}

	// Token: 0x0600B500 RID: 46336 RVA: 0x00428B98 File Offset: 0x00426D98
	public void IAEIOEGJOBD()
	{
		this.HFCEJMOIGDF = base.GetComponents<UnityEngine.MonoBehaviour>();
	}

	// Token: 0x0600B501 RID: 46337 RVA: 0x00428C34 File Offset: 0x00426E34
	protected internal void DFMDMJHNKGL(Component GJLCNFAGNPO, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (GJLCNFAGNPO == null)
		{
			return;
		}
		if (GJLCNFAGNPO is UnityEngine.MonoBehaviour)
		{
			this.BGNIOHIFNAO(GJLCNFAGNPO, HCIJEDFCNOP, DAGALCAILLN);
		}
		else if (GJLCNFAGNPO is Transform)
		{
			Transform transform = (Transform)GJLCNFAGNPO;
			switch (this.onSerializeTransformOption)
			{
			case OnSerializeTransform.OnlyPosition:
				transform.localPosition = (Vector3)HCIJEDFCNOP.ReceiveNext();
				break;
			case OnSerializeTransform.OnlyRotation:
				transform.localRotation = (Quaternion)HCIJEDFCNOP.LNDLNKJPAGO();
				break;
			case OnSerializeTransform.OnlyScale:
				transform.localScale = (Vector3)HCIJEDFCNOP.HPPOACOIMOJ();
				break;
			case OnSerializeTransform.PositionAndRotation:
				transform.localPosition = (Vector3)HCIJEDFCNOP.HPPOACOIMOJ();
				transform.localRotation = (Quaternion)HCIJEDFCNOP.ReceiveNext();
				break;
			case OnSerializeTransform.All:
				transform.localPosition = (Vector3)HCIJEDFCNOP.ACOGAHJKGJH();
				transform.localRotation = (Quaternion)HCIJEDFCNOP.KIMDMBDNICC();
				transform.localScale = (Vector3)HCIJEDFCNOP.ACOGAHJKGJH();
				break;
			}
		}
		else if (GJLCNFAGNPO is Rigidbody)
		{
			Rigidbody rigidbody = (Rigidbody)GJLCNFAGNPO;
			OnSerializeRigidBody onSerializeRigidBody = this.onSerializeRigidBodyOption;
			if (onSerializeRigidBody != (OnSerializeRigidBody)3)
			{
				if (onSerializeRigidBody != OnSerializeRigidBody.OnlyAngularVelocity)
				{
					if (onSerializeRigidBody == OnSerializeRigidBody.OnlyVelocity)
					{
						rigidbody.velocity = (Vector3)HCIJEDFCNOP.LNDLNKJPAGO();
					}
				}
				else
				{
					rigidbody.angularVelocity = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
				}
			}
			else
			{
				rigidbody.velocity = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
				rigidbody.angularVelocity = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			}
		}
		else if (GJLCNFAGNPO is Rigidbody2D)
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)GJLCNFAGNPO;
			OnSerializeRigidBody onSerializeRigidBody2 = this.onSerializeRigidBodyOption;
			if (onSerializeRigidBody2 != (OnSerializeRigidBody)8)
			{
				if (onSerializeRigidBody2 != OnSerializeRigidBody.OnlyVelocity)
				{
					if (onSerializeRigidBody2 == OnSerializeRigidBody.OnlyVelocity)
					{
						rigidbody2D.velocity = (Vector2)HCIJEDFCNOP.KIMDMBDNICC();
					}
				}
				else
				{
					rigidbody2D.angularVelocity = (float)HCIJEDFCNOP.HPPOACOIMOJ();
				}
			}
			else
			{
				rigidbody2D.velocity = (Vector2)HCIJEDFCNOP.HPPOACOIMOJ();
				rigidbody2D.angularVelocity = (float)HCIJEDFCNOP.LNDLNKJPAGO();
			}
		}
		else
		{
			Debug.LogError("DPADHOR");
		}
	}

	// Token: 0x0600B502 RID: 46338 RVA: 0x00428E6C File Offset: 0x0042706C
	protected internal void BPPCEKEMNMC(Component GJLCNFAGNPO, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		IPunObservable punObservable = GJLCNFAGNPO as IPunObservable;
		if (punObservable != null)
		{
			punObservable.OnPhotonSerializeView(HCIJEDFCNOP, DAGALCAILLN);
		}
		else if (GJLCNFAGNPO != null)
		{
			MethodInfo methodInfo = null;
			if (!this.JKIMNJDIPLG.TryGetValue(GJLCNFAGNPO, out methodInfo))
			{
				if (!BNGIGHBHPEH.IIHAIKHPABG(GJLCNFAGNPO as UnityEngine.MonoBehaviour, ((PhotonNetworkingMessage)72).ToString(), out methodInfo))
				{
					Debug.LogError(". local RequestedView.ownerId: " + GJLCNFAGNPO.name + "_Value2");
					methodInfo = null;
				}
				this.JKIMNJDIPLG.Add(GJLCNFAGNPO, methodInfo);
			}
			if (methodInfo != null)
			{
				MethodBase methodBase = methodInfo;
				object[] array = new object[]
				{
					null,
					HCIJEDFCNOP
				};
				array[0] = DAGALCAILLN;
				methodBase.Invoke(GJLCNFAGNPO, array);
			}
		}
	}

	// Token: 0x0600B503 RID: 46339 RVA: 0x00428F28 File Offset: 0x00427128
	public void LPLDDGOEEIJ(PhotonPlayer DELECHPDOCO)
	{
		if (this.PCLFPBHIHOD() == 0 && !this.OwnerShipWasTransfered && (this.currentMasterID == -1 || this.ownerId == this.currentMasterID))
		{
			this.ownerId = DELECHPDOCO.ID;
		}
		this.currentMasterID = DELECHPDOCO.ONIKFABKELO();
	}

	// Token: 0x0600B504 RID: 46340 RVA: 0x00428F80 File Offset: 0x00427180
	protected internal void BGNIOHIFNAO(Component GJLCNFAGNPO, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		IPunObservable punObservable = GJLCNFAGNPO as IPunObservable;
		if (punObservable != null)
		{
			punObservable.OnPhotonSerializeView(HCIJEDFCNOP, DAGALCAILLN);
		}
		else if (GJLCNFAGNPO != null)
		{
			MethodInfo methodInfo = null;
			if (!this.JKIMNJDIPLG.TryGetValue(GJLCNFAGNPO, out methodInfo))
			{
				if (!BNGIGHBHPEH.IIHAIKHPABG(GJLCNFAGNPO as UnityEngine.MonoBehaviour, ((PhotonNetworkingMessage)(-106)).ToString(), out methodInfo))
				{
					Debug.LogError("BloodAlternative1" + GJLCNFAGNPO.name + "UpdateNewsTileStart");
					methodInfo = null;
				}
				this.JKIMNJDIPLG.Add(GJLCNFAGNPO, methodInfo);
			}
			if (methodInfo != null)
			{
				MethodBase methodBase = methodInfo;
				object[] array = new object[5];
				array[0] = HCIJEDFCNOP;
				array[1] = DAGALCAILLN;
				methodBase.Invoke(GJLCNFAGNPO, array);
			}
		}
	}

	// Token: 0x0600B505 RID: 46341 RVA: 0x0042903C File Offset: 0x0042723C
	public void GAAMDOMCJLK(PhotonPlayer DELECHPDOCO)
	{
		if (this.PCLFPBHIHOD() == 0 && !this.OwnerShipWasTransfered && (this.currentMasterID == -1 || this.ownerId == this.currentMasterID))
		{
			this.ownerId = DELECHPDOCO.ID;
		}
		this.currentMasterID = DELECHPDOCO.ONIKFABKELO();
	}

	// Token: 0x0600B506 RID: 46342 RVA: 0x00429094 File Offset: 0x00427294
	public void IAHMGNHJAKK()
	{
		PhotonNetwork.JNJJAMNLOHA.EPGIIBMOHEG(this.EIMHMIJGMHG(), this.ownerId);
	}

	// Token: 0x0600B507 RID: 46343 RVA: 0x00428BB3 File Offset: 0x00426DB3
	public int IJHCDIHGOHJ()
	{
		return this.ownerId;
	}

	// Token: 0x0600B508 RID: 46344 RVA: 0x004290AC File Offset: 0x004272AC
	public virtual string EJGAGAODACL()
	{
		string format = "Added GameObject to prefabDictionary: ";
		object[] array = new object[8];
		array[0] = this.viewID;
		array[0] = ((!(base.gameObject != null)) ? "JoinButton" : base.gameObject.name);
		array[4] = ((!this.LIDEPDFOMFC()) ? string.Empty : "achievements.21.completed.");
		array[1] = this.LHPJFDEFJPC();
		return string.Format(format, array);
	}

	// Token: 0x0600B509 RID: 46345 RVA: 0x0042912C File Offset: 0x0042732C
	public void HANOCKILFNJ(int DPNHODJHGJL)
	{
		bool flag = !this.GEKLBLEBECG || this.viewIdField == 0;
		this.ownerId = DPNHODJHGJL / PhotonNetwork.MAX_VIEW_IDS;
		this.viewIdField = DPNHODJHGJL;
		if (flag)
		{
			PhotonNetwork.JNJJAMNLOHA.RegisterPhotonView(this);
		}
	}

	// Token: 0x0600B50A RID: 46346 RVA: 0x00429178 File Offset: 0x00427378
	protected internal void LKGCFPHCPAP(Component GJLCNFAGNPO, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (GJLCNFAGNPO == null)
		{
			return;
		}
		if (GJLCNFAGNPO is UnityEngine.MonoBehaviour)
		{
			this.DOHOBEJAOED(GJLCNFAGNPO, HCIJEDFCNOP, DAGALCAILLN);
		}
		else if (GJLCNFAGNPO is Transform)
		{
			Transform transform = (Transform)GJLCNFAGNPO;
			switch (this.onSerializeTransformOption)
			{
			case OnSerializeTransform.OnlyPosition:
				transform.localPosition = (Vector3)HCIJEDFCNOP.ReceiveNext();
				break;
			case OnSerializeTransform.OnlyRotation:
				transform.localRotation = (Quaternion)HCIJEDFCNOP.ReceiveNext();
				break;
			case OnSerializeTransform.OnlyScale:
				transform.localScale = (Vector3)HCIJEDFCNOP.ReceiveNext();
				break;
			case OnSerializeTransform.PositionAndRotation:
				transform.localPosition = (Vector3)HCIJEDFCNOP.ReceiveNext();
				transform.localRotation = (Quaternion)HCIJEDFCNOP.ReceiveNext();
				break;
			case OnSerializeTransform.All:
				transform.localPosition = (Vector3)HCIJEDFCNOP.ReceiveNext();
				transform.localRotation = (Quaternion)HCIJEDFCNOP.ReceiveNext();
				transform.localScale = (Vector3)HCIJEDFCNOP.ReceiveNext();
				break;
			}
		}
		else if (GJLCNFAGNPO is Rigidbody)
		{
			Rigidbody rigidbody = (Rigidbody)GJLCNFAGNPO;
			OnSerializeRigidBody onSerializeRigidBody = this.onSerializeRigidBodyOption;
			if (onSerializeRigidBody != OnSerializeRigidBody.All)
			{
				if (onSerializeRigidBody != OnSerializeRigidBody.OnlyAngularVelocity)
				{
					if (onSerializeRigidBody == OnSerializeRigidBody.OnlyVelocity)
					{
						rigidbody.velocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
					}
				}
				else
				{
					rigidbody.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
				}
			}
			else
			{
				rigidbody.velocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
				rigidbody.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
			}
		}
		else if (GJLCNFAGNPO is Rigidbody2D)
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)GJLCNFAGNPO;
			OnSerializeRigidBody onSerializeRigidBody2 = this.onSerializeRigidBodyOption;
			if (onSerializeRigidBody2 != OnSerializeRigidBody.All)
			{
				if (onSerializeRigidBody2 != OnSerializeRigidBody.OnlyAngularVelocity)
				{
					if (onSerializeRigidBody2 == OnSerializeRigidBody.OnlyVelocity)
					{
						rigidbody2D.velocity = (Vector2)HCIJEDFCNOP.ReceiveNext();
					}
				}
				else
				{
					rigidbody2D.angularVelocity = (float)HCIJEDFCNOP.ReceiveNext();
				}
			}
			else
			{
				rigidbody2D.velocity = (Vector2)HCIJEDFCNOP.ReceiveNext();
				rigidbody2D.angularVelocity = (float)HCIJEDFCNOP.ReceiveNext();
			}
		}
		else
		{
			Debug.LogError("Type of observed is unknown when receiving.");
		}
	}

	// Token: 0x170002AC RID: 684
	// (get) Token: 0x0600B50B RID: 46347 RVA: 0x004293B0 File Offset: 0x004275B0
	public int CreatorActorNr
	{
		get
		{
			return this.viewIdField / PhotonNetwork.MAX_VIEW_IDS;
		}
	}

	// Token: 0x0600B50C RID: 46348 RVA: 0x004293C0 File Offset: 0x004275C0
	protected internal void EGBMPDLBLBM(Component GJLCNFAGNPO, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		IPunObservable punObservable = GJLCNFAGNPO as IPunObservable;
		if (punObservable != null)
		{
			punObservable.OnPhotonSerializeView(HCIJEDFCNOP, DAGALCAILLN);
		}
		else if (GJLCNFAGNPO != null)
		{
			MethodInfo methodInfo = null;
			if (!this.JKIMNJDIPLG.TryGetValue(GJLCNFAGNPO, out methodInfo))
			{
				if (!BNGIGHBHPEH.FAAKJJEMNEB(GJLCNFAGNPO as UnityEngine.MonoBehaviour, ((PhotonNetworkingMessage)(-16)).ToString(), out methodInfo))
				{
					Debug.LogError("_Far" + GJLCNFAGNPO.name + "High");
					methodInfo = null;
				}
				this.JKIMNJDIPLG.Add(GJLCNFAGNPO, methodInfo);
			}
			if (methodInfo != null)
			{
				MethodBase methodBase = methodInfo;
				object[] array = new object[0];
				array[1] = HCIJEDFCNOP;
				array[1] = DAGALCAILLN;
				methodBase.Invoke(GJLCNFAGNPO, array);
			}
		}
	}

	// Token: 0x0600B50D RID: 46349 RVA: 0x00429479 File Offset: 0x00427679
	public void AFFCGFGOHAE(object[] DPNHODJHGJL)
	{
		this.NJDPOGADFJN = DPNHODJHGJL;
	}

	// Token: 0x0600B50E RID: 46350 RVA: 0x00429484 File Offset: 0x00427684
	protected internal void PIIBOGMMNCI(Component GJLCNFAGNPO, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (GJLCNFAGNPO == null)
		{
			return;
		}
		if (GJLCNFAGNPO is UnityEngine.MonoBehaviour)
		{
			this.BPPCEKEMNMC(GJLCNFAGNPO, HCIJEDFCNOP, DAGALCAILLN);
		}
		else if (GJLCNFAGNPO is Transform)
		{
			Transform transform = (Transform)GJLCNFAGNPO;
			switch (this.onSerializeTransformOption)
			{
			case OnSerializeTransform.OnlyPosition:
				HCIJEDFCNOP.SendNext(transform.localPosition);
				break;
			case OnSerializeTransform.OnlyRotation:
				HCIJEDFCNOP.CPIBABMPJLE(transform.localRotation);
				break;
			case OnSerializeTransform.OnlyScale:
				HCIJEDFCNOP.PBECMJMDHBI(transform.localScale);
				break;
			case OnSerializeTransform.PositionAndRotation:
				HCIJEDFCNOP.PNAPNHJHBMN(transform.localPosition);
				HCIJEDFCNOP.BBHGPGBHMML(transform.localRotation);
				break;
			case OnSerializeTransform.All:
				HCIJEDFCNOP.FADAIFFMBEL(transform.localPosition);
				HCIJEDFCNOP.BBHGPGBHMML(transform.localRotation);
				HCIJEDFCNOP.FADAIFFMBEL(transform.localScale);
				break;
			}
		}
		else if (GJLCNFAGNPO is Rigidbody)
		{
			Rigidbody rigidbody = (Rigidbody)GJLCNFAGNPO;
			OnSerializeRigidBody onSerializeRigidBody = this.onSerializeRigidBodyOption;
			if (onSerializeRigidBody != OnSerializeRigidBody.All)
			{
				if (onSerializeRigidBody != OnSerializeRigidBody.OnlyVelocity)
				{
					if (onSerializeRigidBody == OnSerializeRigidBody.OnlyVelocity)
					{
						HCIJEDFCNOP.FADAIFFMBEL(rigidbody.velocity);
					}
				}
				else
				{
					HCIJEDFCNOP.OLACNHHHOEL(rigidbody.angularVelocity);
				}
			}
			else
			{
				HCIJEDFCNOP.PNAPNHJHBMN(rigidbody.velocity);
				HCIJEDFCNOP.PNAPNHJHBMN(rigidbody.angularVelocity);
			}
		}
		else if (GJLCNFAGNPO is Rigidbody2D)
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)GJLCNFAGNPO;
			OnSerializeRigidBody onSerializeRigidBody2 = this.onSerializeRigidBodyOption;
			if (onSerializeRigidBody2 != (OnSerializeRigidBody)7)
			{
				if (onSerializeRigidBody2 != OnSerializeRigidBody.OnlyAngularVelocity)
				{
					if (onSerializeRigidBody2 == OnSerializeRigidBody.OnlyVelocity)
					{
						HCIJEDFCNOP.IBCLJIACBKG(rigidbody2D.velocity);
					}
				}
				else
				{
					HCIJEDFCNOP.FADAIFFMBEL(rigidbody2D.angularVelocity);
				}
			}
			else
			{
				HCIJEDFCNOP.FADAIFFMBEL(rigidbody2D.velocity);
				HCIJEDFCNOP.SendNext(rigidbody2D.angularVelocity);
			}
		}
		else
		{
			Debug.LogError("_NoiseTilingPerChannel" + GJLCNFAGNPO.GetType());
		}
	}

	// Token: 0x0600B50F RID: 46351 RVA: 0x004296C7 File Offset: 0x004278C7
	public PhotonPlayer JJFEGIOPFGN()
	{
		return PhotonPlayer.GJMEMHIGMGN(this.ownerId);
	}

	// Token: 0x0600B510 RID: 46352 RVA: 0x00428BB3 File Offset: 0x00426DB3
	public int PHKEOGCANIG()
	{
		return this.ownerId;
	}

	// Token: 0x0600B511 RID: 46353 RVA: 0x00428A99 File Offset: 0x00426C99
	public int HINDCAIAACA()
	{
		if (this.prefixBackup == -1 && PhotonNetwork.JNJJAMNLOHA != null)
		{
			this.prefixBackup = (int)PhotonNetwork.JNJJAMNLOHA.PKCNHOKCLJH;
		}
		return this.prefixBackup;
	}

	// Token: 0x0600B512 RID: 46354 RVA: 0x004296D4 File Offset: 0x004278D4
	public void OnMasterClientSwitched(PhotonPlayer DELECHPDOCO)
	{
		if (this.CreatorActorNr == 0 && !this.OwnerShipWasTransfered && (this.currentMasterID == -1 || this.ownerId == this.currentMasterID))
		{
			this.ownerId = DELECHPDOCO.ID;
		}
		this.currentMasterID = DELECHPDOCO.ID;
	}

	// Token: 0x0600B513 RID: 46355 RVA: 0x00428B8C File Offset: 0x00426D8C
	public void OILIKMGIHFL(string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MJCDIJOAEPI, false, GNNEKCBOBEG);
	}

	// Token: 0x170002A7 RID: 679
	// (get) Token: 0x0600B521 RID: 46369 RVA: 0x004298BA File Offset: 0x00427ABA
	// (set) Token: 0x0600B514 RID: 46356 RVA: 0x0042972C File Offset: 0x0042792C
	public int viewID
	{
		get
		{
			return this.viewIdField;
		}
		set
		{
			bool flag = this.GEKLBLEBECG && this.viewIdField == 0;
			this.ownerId = value / PhotonNetwork.MAX_VIEW_IDS;
			this.viewIdField = value;
			if (flag)
			{
				PhotonNetwork.JNJJAMNLOHA.RegisterPhotonView(this);
			}
		}
	}

	// Token: 0x0600B515 RID: 46357 RVA: 0x00429778 File Offset: 0x00427978
	public void HEKCAIGGGOK(PhotonPlayer DELECHPDOCO)
	{
		if (this.PCLFPBHIHOD() == 0 && !this.OwnerShipWasTransfered && (this.currentMasterID == -1 || this.ownerId == this.currentMasterID))
		{
			this.ownerId = DELECHPDOCO.ONIKFABKELO();
		}
		this.currentMasterID = DELECHPDOCO.ID;
	}

	// Token: 0x170002A9 RID: 681
	// (get) Token: 0x0600B516 RID: 46358 RVA: 0x004297D0 File Offset: 0x004279D0
	public PhotonPlayer owner
	{
		get
		{
			return PhotonPlayer.Find(this.ownerId);
		}
	}

	// Token: 0x0600B517 RID: 46359 RVA: 0x004297DD File Offset: 0x004279DD
	protected internal void EPCGHAAONLN()
	{
		if (this.NPPEFODKHKN() != 0)
		{
			PhotonNetwork.JNJJAMNLOHA.RegisterPhotonView(this);
			this.NJDPOGADFJN = PhotonNetwork.JNJJAMNLOHA.FetchInstantiationData(this.instantiationId);
		}
		this.GEKLBLEBECG = true;
	}

	// Token: 0x0600B518 RID: 46360 RVA: 0x00429814 File Offset: 0x00427A14
	protected internal void FHKLBHIOKKN()
	{
		if (!this.IHPAIFIHLAE)
		{
			bool flag = PhotonNetwork.JNJJAMNLOHA.LocalCleanPhotonView(this);
			bool flag2 = false;
			if (flag && !flag2 && this.instantiationId > 0 && !PhotonHandler.MBIFDLCKGKN && PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
			{
				Debug.Log("[ItemsHandler] Found " + base.gameObject.name + ":");
			}
		}
	}

	// Token: 0x0600B519 RID: 46361 RVA: 0x004293B0 File Offset: 0x004275B0
	public int PCLFPBHIHOD()
	{
		return this.viewIdField / PhotonNetwork.MAX_VIEW_IDS;
	}

	// Token: 0x0600B51A RID: 46362 RVA: 0x00429886 File Offset: 0x00427A86
	public void RPC(string LBLKDNNPACO, PhotonTargets MPNMOONBMII, params object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MPNMOONBMII, false, GNNEKCBOBEG);
	}

	// Token: 0x0600B51B RID: 46363 RVA: 0x00429892 File Offset: 0x00427A92
	public void NPCJOLMMCGB(string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, bool AKFHJNFOCDP, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MJCDIJOAEPI, AKFHJNFOCDP, GNNEKCBOBEG);
	}

	// Token: 0x0600B51C RID: 46364 RVA: 0x00429886 File Offset: 0x00427A86
	public void IKIJDNPJKPM(string LBLKDNNPACO, PhotonTargets MPNMOONBMII, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MPNMOONBMII, false, GNNEKCBOBEG);
	}

	// Token: 0x0600B51D RID: 46365 RVA: 0x00428BA6 File Offset: 0x00426DA6
	public static PhotonView CPHCOHILOAA(int NADLIACHBNO)
	{
		return PhotonNetwork.JNJJAMNLOHA.GetPhotonView(NADLIACHBNO);
	}

	// Token: 0x0600B51E RID: 46366 RVA: 0x0042989F File Offset: 0x00427A9F
	public void RpcSecure(string LBLKDNNPACO, PhotonTargets MPNMOONBMII, bool AKFHJNFOCDP, params object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MPNMOONBMII, AKFHJNFOCDP, GNNEKCBOBEG);
	}

	// Token: 0x0600B51F RID: 46367 RVA: 0x004298AC File Offset: 0x00427AAC
	public void TransferOwnership(PhotonPlayer FPMBEPHLNMN)
	{
		this.TransferOwnership(FPMBEPHLNMN.ID);
	}

	// Token: 0x0600B520 RID: 46368 RVA: 0x00429094 File Offset: 0x00427294
	public void GPEJDIHFIMM()
	{
		PhotonNetwork.JNJJAMNLOHA.EPGIIBMOHEG(this.EIMHMIJGMHG(), this.ownerId);
	}

	// Token: 0x0600B522 RID: 46370 RVA: 0x004298C4 File Offset: 0x00427AC4
	public virtual string COELLBGIPPO()
	{
		string format = "CameraFilterPack/Lut_PlayWith";
		object[] array = new object[7];
		array[1] = this.KINIHBOKFJH();
		array[1] = ((!(base.gameObject != null)) ? "maps." : base.gameObject.name);
		array[3] = ((!this.LIDEPDFOMFC()) ? string.Empty : "EventSystem");
		array[5] = this.LHPJFDEFJPC();
		return string.Format(format, array);
	}

	// Token: 0x170002A6 RID: 678
	// (get) Token: 0x0600B528 RID: 46376 RVA: 0x00429C0A File Offset: 0x00427E0A
	// (set) Token: 0x0600B523 RID: 46371 RVA: 0x00429479 File Offset: 0x00427679
	public object[] instantiationData
	{
		get
		{
			if (!this.GEKLBLEBECG)
			{
				this.NJDPOGADFJN = PhotonNetwork.JNJJAMNLOHA.FetchInstantiationData(this.instantiationId);
			}
			return this.NJDPOGADFJN;
		}
		set
		{
			this.NJDPOGADFJN = value;
		}
	}

	// Token: 0x0600B524 RID: 46372 RVA: 0x00429944 File Offset: 0x00427B44
	protected internal void CGCDEFOFKJD(Component GJLCNFAGNPO, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (GJLCNFAGNPO == null)
		{
			return;
		}
		if (GJLCNFAGNPO is UnityEngine.MonoBehaviour)
		{
			this.DEMHLCDNKGE(GJLCNFAGNPO, HCIJEDFCNOP, DAGALCAILLN);
		}
		else if (GJLCNFAGNPO is Transform)
		{
			Transform transform = (Transform)GJLCNFAGNPO;
			switch (this.onSerializeTransformOption)
			{
			case OnSerializeTransform.OnlyPosition:
				transform.localPosition = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
				break;
			case OnSerializeTransform.OnlyRotation:
				transform.localRotation = (Quaternion)HCIJEDFCNOP.IDKHBJIHKEB();
				break;
			case OnSerializeTransform.OnlyScale:
				transform.localScale = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
				break;
			case OnSerializeTransform.PositionAndRotation:
				transform.localPosition = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
				transform.localRotation = (Quaternion)HCIJEDFCNOP.KIEJNJBDAJJ();
				break;
			case OnSerializeTransform.All:
				transform.localPosition = (Vector3)HCIJEDFCNOP.ACOGAHJKGJH();
				transform.localRotation = (Quaternion)HCIJEDFCNOP.KIEJNJBDAJJ();
				transform.localScale = (Vector3)HCIJEDFCNOP.LNDLNKJPAGO();
				break;
			}
		}
		else if (GJLCNFAGNPO is Rigidbody)
		{
			Rigidbody rigidbody = (Rigidbody)GJLCNFAGNPO;
			OnSerializeRigidBody onSerializeRigidBody = this.onSerializeRigidBodyOption;
			if (onSerializeRigidBody != (OnSerializeRigidBody)7)
			{
				if (onSerializeRigidBody != OnSerializeRigidBody.OnlyAngularVelocity)
				{
					if (onSerializeRigidBody == OnSerializeRigidBody.OnlyVelocity)
					{
						rigidbody.velocity = (Vector3)HCIJEDFCNOP.HPPOACOIMOJ();
					}
				}
				else
				{
					rigidbody.angularVelocity = (Vector3)HCIJEDFCNOP.ReceiveNext();
				}
			}
			else
			{
				rigidbody.velocity = (Vector3)HCIJEDFCNOP.ACOGAHJKGJH();
				rigidbody.angularVelocity = (Vector3)HCIJEDFCNOP.IDKHBJIHKEB();
			}
		}
		else if (GJLCNFAGNPO is Rigidbody2D)
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)GJLCNFAGNPO;
			OnSerializeRigidBody onSerializeRigidBody2 = this.onSerializeRigidBodyOption;
			if (onSerializeRigidBody2 != OnSerializeRigidBody.OnlyAngularVelocity)
			{
				if (onSerializeRigidBody2 != OnSerializeRigidBody.OnlyAngularVelocity)
				{
					if (onSerializeRigidBody2 == OnSerializeRigidBody.OnlyVelocity)
					{
						rigidbody2D.velocity = (Vector2)HCIJEDFCNOP.FIBMOBNIALK();
					}
				}
				else
				{
					rigidbody2D.angularVelocity = (float)HCIJEDFCNOP.FIBMOBNIALK();
				}
			}
			else
			{
				rigidbody2D.velocity = (Vector2)HCIJEDFCNOP.ACOGAHJKGJH();
				rigidbody2D.angularVelocity = (float)HCIJEDFCNOP.LNDLNKJPAGO();
			}
		}
		else
		{
			Debug.LogError("_BlendTex");
		}
	}

	// Token: 0x0600B525 RID: 46373 RVA: 0x00429B7C File Offset: 0x00427D7C
	public void SerializeView(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (this.ObservedComponents != null && this.ObservedComponents.Count > 0)
		{
			for (int i = 0; i < this.ObservedComponents.Count; i++)
			{
				this.IPOLPPFEJDL(this.ObservedComponents[i], HCIJEDFCNOP, DAGALCAILLN);
			}
		}
	}

	// Token: 0x0600B526 RID: 46374 RVA: 0x00429BD5 File Offset: 0x00427DD5
	protected internal void Awake()
	{
		if (this.viewID != 0)
		{
			PhotonNetwork.JNJJAMNLOHA.RegisterPhotonView(this);
			this.NJDPOGADFJN = PhotonNetwork.JNJJAMNLOHA.FetchInstantiationData(this.instantiationId);
		}
		this.GEKLBLEBECG = true;
	}

	// Token: 0x0600B527 RID: 46375 RVA: 0x00428B98 File Offset: 0x00426D98
	public void RefreshRpcMonoBehaviourCache()
	{
		this.HFCEJMOIGDF = base.GetComponents<UnityEngine.MonoBehaviour>();
	}

	// Token: 0x0600B529 RID: 46377 RVA: 0x00429C34 File Offset: 0x00427E34
	protected internal void OnDestroy()
	{
		if (!this.IHPAIFIHLAE)
		{
			bool flag = PhotonNetwork.JNJJAMNLOHA.LocalCleanPhotonView(this);
			bool flag2 = false;
			if (flag && !flag2 && this.instantiationId > 0 && !PhotonHandler.MBIFDLCKGKN && PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
			{
				Debug.Log("PUN-instantiated '" + base.gameObject.name + "' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().");
			}
		}
	}

	// Token: 0x0600B52A RID: 46378 RVA: 0x00429CA6 File Offset: 0x00427EA6
	public void TransferOwnership(int BJKANENNNOF)
	{
		PhotonNetwork.JNJJAMNLOHA.JHCPMMIEDEE(this.viewID, BJKANENNNOF);
		this.ownerId = BJKANENNNOF;
	}

	// Token: 0x170002AB RID: 683
	// (get) Token: 0x0600B52B RID: 46379 RVA: 0x00429CC0 File Offset: 0x00427EC0
	public bool isOwnerActive
	{
		get
		{
			return this.ownerId != 0 && PhotonNetwork.JNJJAMNLOHA.mActors.ContainsKey(this.ownerId);
		}
	}

	// Token: 0x0600B52C RID: 46380 RVA: 0x00429CE5 File Offset: 0x00427EE5
	public static PhotonView HGJPAIACMIF(Component GJLCNFAGNPO)
	{
		return GJLCNFAGNPO.GetComponent<PhotonView>();
	}

	// Token: 0x0600B52D RID: 46381 RVA: 0x00429CF0 File Offset: 0x00427EF0
	protected internal void KBMGJLMJFOE()
	{
		if (!this.IHPAIFIHLAE)
		{
			bool flag = PhotonNetwork.JNJJAMNLOHA.LocalCleanPhotonView(this);
			bool flag2 = true;
			if (flag && !flag2 && this.instantiationId > 1 && !PhotonHandler.MBIFDLCKGKN && PhotonNetwork.logLevel >= PhotonLogLevel.Informational)
			{
				Debug.Log("_ColorG" + base.gameObject.name + "Default UI Material");
			}
		}
	}

	// Token: 0x0600B52E RID: 46382 RVA: 0x00429CC0 File Offset: 0x00427EC0
	public bool IIJCADFOLOO()
	{
		return this.ownerId != 0 && PhotonNetwork.JNJJAMNLOHA.mActors.ContainsKey(this.ownerId);
	}

	// Token: 0x0600B52F RID: 46383 RVA: 0x00429D64 File Offset: 0x00427F64
	public void BDEJOHNPIFG(PhotonPlayer DELECHPDOCO)
	{
		if (this.FOLKNAAAEAJ() == 0 && !this.OwnerShipWasTransfered && (this.currentMasterID == -1 || this.ownerId == this.currentMasterID))
		{
			this.ownerId = DELECHPDOCO.ONIKFABKELO();
		}
		this.currentMasterID = DELECHPDOCO.ID;
	}

	// Token: 0x0600B530 RID: 46384 RVA: 0x00429DBC File Offset: 0x00427FBC
	public void OMADJOEHOGE(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (this.ObservedComponents != null && this.ObservedComponents.Count > 1)
		{
			for (int i = 0; i < this.ObservedComponents.Count; i++)
			{
				this.PIIBOGMMNCI(this.ObservedComponents[i], HCIJEDFCNOP, DAGALCAILLN);
			}
		}
	}

	// Token: 0x170002AA RID: 682
	// (get) Token: 0x0600B531 RID: 46385 RVA: 0x00428BB3 File Offset: 0x00426DB3
	public int OwnerActorNr
	{
		get
		{
			return this.ownerId;
		}
	}

	// Token: 0x0600B532 RID: 46386 RVA: 0x00428BA6 File Offset: 0x00426DA6
	public static PhotonView JCDPMMJDLOP(int NADLIACHBNO)
	{
		return PhotonNetwork.JNJJAMNLOHA.GetPhotonView(NADLIACHBNO);
	}

	// Token: 0x0600B533 RID: 46387 RVA: 0x00428B8C File Offset: 0x00426D8C
	public void RPC(string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, params object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MJCDIJOAEPI, false, GNNEKCBOBEG);
	}

	// Token: 0x0600B534 RID: 46388 RVA: 0x004298BA File Offset: 0x00427ABA
	public int NPPEFODKHKN()
	{
		return this.viewIdField;
	}

	// Token: 0x0600B535 RID: 46389 RVA: 0x00429E15 File Offset: 0x00428015
	public bool PFCJNOLLHNF()
	{
		return this.ownerId == 0 || PhotonNetwork.JNJJAMNLOHA.mActors.ContainsKey(this.ownerId);
	}

	// Token: 0x0600B536 RID: 46390 RVA: 0x00429E3A File Offset: 0x0042803A
	public void LIPHBCELHLO(PhotonPlayer FPMBEPHLNMN)
	{
		this.INKNMCPAAGF(FPMBEPHLNMN.ID);
	}

	// Token: 0x0600B537 RID: 46391 RVA: 0x004293B0 File Offset: 0x004275B0
	public int LILIOIJNOGO()
	{
		return this.viewIdField / PhotonNetwork.MAX_VIEW_IDS;
	}

	// Token: 0x0600B538 RID: 46392 RVA: 0x00429CE5 File Offset: 0x00427EE5
	public static PhotonView Get(Component GJLCNFAGNPO)
	{
		return GJLCNFAGNPO.GetComponent<PhotonView>();
	}

	// Token: 0x0600B539 RID: 46393 RVA: 0x00429E48 File Offset: 0x00428048
	public void KEKKFNNMLMG(string LBLKDNNPACO, PhotonTargets MPNMOONBMII, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MPNMOONBMII, true, GNNEKCBOBEG);
	}

	// Token: 0x0600B53A RID: 46394 RVA: 0x00429E54 File Offset: 0x00428054
	public void IBGILLAEDFA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (this.ObservedComponents != null && this.ObservedComponents.Count > 0)
		{
			for (int i = 0; i < this.ObservedComponents.Count; i += 0)
			{
				this.FHDECBOJGBN(this.ObservedComponents[i], HCIJEDFCNOP, DAGALCAILLN);
			}
		}
	}

	// Token: 0x0600B53B RID: 46395 RVA: 0x004298BA File Offset: 0x00427ABA
	public int EIMHMIJGMHG()
	{
		return this.viewIdField;
	}

	// Token: 0x0600B53C RID: 46396 RVA: 0x00429EB0 File Offset: 0x004280B0
	public void DeserializeView(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (this.ObservedComponents != null && this.ObservedComponents.Count > 0)
		{
			for (int i = 0; i < this.ObservedComponents.Count; i++)
			{
				this.LKGCFPHCPAP(this.ObservedComponents[i], HCIJEDFCNOP, DAGALCAILLN);
			}
		}
	}

	// Token: 0x0600B53D RID: 46397 RVA: 0x00429F09 File Offset: 0x00428109
	public void PLMAEOHKJPN(string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MJCDIJOAEPI, true, GNNEKCBOBEG);
	}

	// Token: 0x0600B53E RID: 46398 RVA: 0x00429F15 File Offset: 0x00428115
	public bool KCAOJFPDEIP()
	{
		return this.ownerId != PhotonNetwork.player.ONIKFABKELO() && (this.isOwnerActive || PhotonNetwork.isMasterClient);
	}

	// Token: 0x0600B53F RID: 46399 RVA: 0x00429E48 File Offset: 0x00428048
	public void MIAHMDGOOPJ(string LBLKDNNPACO, PhotonTargets MPNMOONBMII, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MPNMOONBMII, true, GNNEKCBOBEG);
	}

	// Token: 0x0600B540 RID: 46400 RVA: 0x0042989F File Offset: 0x00427A9F
	public void OEJDHFFNMFD(string LBLKDNNPACO, PhotonTargets MPNMOONBMII, bool AKFHJNFOCDP, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MPNMOONBMII, AKFHJNFOCDP, GNNEKCBOBEG);
	}

	// Token: 0x170002A8 RID: 680
	// (get) Token: 0x0600B541 RID: 46401 RVA: 0x00428B81 File Offset: 0x00426D81
	public bool isSceneView
	{
		get
		{
			return this.CreatorActorNr == 0;
		}
	}

	// Token: 0x0600B542 RID: 46402 RVA: 0x00429E48 File Offset: 0x00428048
	public void GNFNHDCJOFC(string LBLKDNNPACO, PhotonTargets MPNMOONBMII, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MPNMOONBMII, true, GNNEKCBOBEG);
	}

	// Token: 0x0600B543 RID: 46403 RVA: 0x00428B8C File Offset: 0x00426D8C
	public void DPLELHEFMBE(string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MJCDIJOAEPI, false, GNNEKCBOBEG);
	}

	// Token: 0x0600B544 RID: 46404 RVA: 0x00429F42 File Offset: 0x00428142
	public void BIMKLKFMOCB(int DPNHODJHGJL)
	{
		this.prefixBackup = DPNHODJHGJL;
	}

	// Token: 0x0600B545 RID: 46405 RVA: 0x00429886 File Offset: 0x00427A86
	public void PBMFBOOALKA(string LBLKDNNPACO, PhotonTargets MPNMOONBMII, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MPNMOONBMII, false, GNNEKCBOBEG);
	}

	// Token: 0x0600B546 RID: 46406 RVA: 0x00429F4B File Offset: 0x0042814B
	protected internal void IOMCHHBGJEC()
	{
		if (this.viewID != 0)
		{
			PhotonNetwork.JNJJAMNLOHA.RegisterPhotonView(this);
			this.NJDPOGADFJN = PhotonNetwork.JNJJAMNLOHA.FetchInstantiationData(this.instantiationId);
		}
		this.GEKLBLEBECG = false;
	}

	// Token: 0x0600B547 RID: 46407 RVA: 0x00429F80 File Offset: 0x00428180
	public void JKICFMOKDHK(PhotonPlayer DELECHPDOCO)
	{
		if (this.PCLFPBHIHOD() == 0 && !this.OwnerShipWasTransfered && (this.currentMasterID == -1 || this.ownerId == this.currentMasterID))
		{
			this.ownerId = DELECHPDOCO.ID;
		}
		this.currentMasterID = DELECHPDOCO.ID;
	}

	// Token: 0x0600B548 RID: 46408 RVA: 0x00429FD8 File Offset: 0x004281D8
	public void RequestOwnership()
	{
		PhotonNetwork.JNJJAMNLOHA.EPGIIBMOHEG(this.viewID, this.ownerId);
	}

	// Token: 0x0600B549 RID: 46409 RVA: 0x00429FF0 File Offset: 0x004281F0
	protected internal void IPOLPPFEJDL(Component GJLCNFAGNPO, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (GJLCNFAGNPO == null)
		{
			return;
		}
		if (GJLCNFAGNPO is UnityEngine.MonoBehaviour)
		{
			this.DOHOBEJAOED(GJLCNFAGNPO, HCIJEDFCNOP, DAGALCAILLN);
		}
		else if (GJLCNFAGNPO is Transform)
		{
			Transform transform = (Transform)GJLCNFAGNPO;
			switch (this.onSerializeTransformOption)
			{
			case OnSerializeTransform.OnlyPosition:
				HCIJEDFCNOP.SendNext(transform.localPosition);
				break;
			case OnSerializeTransform.OnlyRotation:
				HCIJEDFCNOP.SendNext(transform.localRotation);
				break;
			case OnSerializeTransform.OnlyScale:
				HCIJEDFCNOP.SendNext(transform.localScale);
				break;
			case OnSerializeTransform.PositionAndRotation:
				HCIJEDFCNOP.SendNext(transform.localPosition);
				HCIJEDFCNOP.SendNext(transform.localRotation);
				break;
			case OnSerializeTransform.All:
				HCIJEDFCNOP.SendNext(transform.localPosition);
				HCIJEDFCNOP.SendNext(transform.localRotation);
				HCIJEDFCNOP.SendNext(transform.localScale);
				break;
			}
		}
		else if (GJLCNFAGNPO is Rigidbody)
		{
			Rigidbody rigidbody = (Rigidbody)GJLCNFAGNPO;
			OnSerializeRigidBody onSerializeRigidBody = this.onSerializeRigidBodyOption;
			if (onSerializeRigidBody != OnSerializeRigidBody.All)
			{
				if (onSerializeRigidBody != OnSerializeRigidBody.OnlyAngularVelocity)
				{
					if (onSerializeRigidBody == OnSerializeRigidBody.OnlyVelocity)
					{
						HCIJEDFCNOP.SendNext(rigidbody.velocity);
					}
				}
				else
				{
					HCIJEDFCNOP.SendNext(rigidbody.angularVelocity);
				}
			}
			else
			{
				HCIJEDFCNOP.SendNext(rigidbody.velocity);
				HCIJEDFCNOP.SendNext(rigidbody.angularVelocity);
			}
		}
		else if (GJLCNFAGNPO is Rigidbody2D)
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)GJLCNFAGNPO;
			OnSerializeRigidBody onSerializeRigidBody2 = this.onSerializeRigidBodyOption;
			if (onSerializeRigidBody2 != OnSerializeRigidBody.All)
			{
				if (onSerializeRigidBody2 != OnSerializeRigidBody.OnlyAngularVelocity)
				{
					if (onSerializeRigidBody2 == OnSerializeRigidBody.OnlyVelocity)
					{
						HCIJEDFCNOP.SendNext(rigidbody2D.velocity);
					}
				}
				else
				{
					HCIJEDFCNOP.SendNext(rigidbody2D.angularVelocity);
				}
			}
			else
			{
				HCIJEDFCNOP.SendNext(rigidbody2D.velocity);
				HCIJEDFCNOP.SendNext(rigidbody2D.angularVelocity);
			}
		}
		else
		{
			Debug.LogError("Observed type is not serializable: " + GJLCNFAGNPO.GetType());
		}
	}

	// Token: 0x0600B54A RID: 46410 RVA: 0x0042A234 File Offset: 0x00428434
	protected internal void DEMHLCDNKGE(Component GJLCNFAGNPO, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		IPunObservable punObservable = GJLCNFAGNPO as IPunObservable;
		if (punObservable != null)
		{
			punObservable.OnPhotonSerializeView(HCIJEDFCNOP, DAGALCAILLN);
		}
		else if (GJLCNFAGNPO != null)
		{
			MethodInfo methodInfo = null;
			if (!this.JKIMNJDIPLG.TryGetValue(GJLCNFAGNPO, out methodInfo))
			{
				if (!BNGIGHBHPEH.IIHAIKHPABG(GJLCNFAGNPO as UnityEngine.MonoBehaviour, ((PhotonNetworkingMessage)(-55)).ToString(), out methodInfo))
				{
					Debug.LogError("file://" + GJLCNFAGNPO.name + "_Saturation");
					methodInfo = null;
				}
				this.JKIMNJDIPLG.Add(GJLCNFAGNPO, methodInfo);
			}
			if (methodInfo != null)
			{
				MethodBase methodBase = methodInfo;
				object[] array = new object[7];
				array[1] = HCIJEDFCNOP;
				array[1] = DAGALCAILLN;
				methodBase.Invoke(GJLCNFAGNPO, array);
			}
		}
	}

	// Token: 0x0600B54B RID: 46411 RVA: 0x00429479 File Offset: 0x00427679
	public void EJGGMCHNJDI(object[] DPNHODJHGJL)
	{
		this.NJDPOGADFJN = DPNHODJHGJL;
	}

	// Token: 0x0600B54C RID: 46412 RVA: 0x0042A2F0 File Offset: 0x004284F0
	protected internal void FHDECBOJGBN(Component GJLCNFAGNPO, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (GJLCNFAGNPO == null)
		{
			return;
		}
		if (GJLCNFAGNPO is UnityEngine.MonoBehaviour)
		{
			this.DEMHLCDNKGE(GJLCNFAGNPO, HCIJEDFCNOP, DAGALCAILLN);
		}
		else if (GJLCNFAGNPO is Transform)
		{
			Transform transform = (Transform)GJLCNFAGNPO;
			switch (this.onSerializeTransformOption)
			{
			case OnSerializeTransform.OnlyPosition:
				HCIJEDFCNOP.CPIBABMPJLE(transform.localPosition);
				break;
			case OnSerializeTransform.OnlyRotation:
				HCIJEDFCNOP.OLACNHHHOEL(transform.localRotation);
				break;
			case OnSerializeTransform.OnlyScale:
				HCIJEDFCNOP.SendNext(transform.localScale);
				break;
			case OnSerializeTransform.PositionAndRotation:
				HCIJEDFCNOP.PBECMJMDHBI(transform.localPosition);
				HCIJEDFCNOP.IBCLJIACBKG(transform.localRotation);
				break;
			case OnSerializeTransform.All:
				HCIJEDFCNOP.BBHGPGBHMML(transform.localPosition);
				HCIJEDFCNOP.PBECMJMDHBI(transform.localRotation);
				HCIJEDFCNOP.PNAPNHJHBMN(transform.localScale);
				break;
			}
		}
		else if (GJLCNFAGNPO is Rigidbody)
		{
			Rigidbody rigidbody = (Rigidbody)GJLCNFAGNPO;
			OnSerializeRigidBody onSerializeRigidBody = this.onSerializeRigidBodyOption;
			if (onSerializeRigidBody != (OnSerializeRigidBody)4)
			{
				if (onSerializeRigidBody != OnSerializeRigidBody.OnlyAngularVelocity)
				{
					if (onSerializeRigidBody == OnSerializeRigidBody.OnlyVelocity)
					{
						HCIJEDFCNOP.BBHGPGBHMML(rigidbody.velocity);
					}
				}
				else
				{
					HCIJEDFCNOP.IBCLJIACBKG(rigidbody.angularVelocity);
				}
			}
			else
			{
				HCIJEDFCNOP.SendNext(rigidbody.velocity);
				HCIJEDFCNOP.SendNext(rigidbody.angularVelocity);
			}
		}
		else if (GJLCNFAGNPO is Rigidbody2D)
		{
			Rigidbody2D rigidbody2D = (Rigidbody2D)GJLCNFAGNPO;
			OnSerializeRigidBody onSerializeRigidBody2 = this.onSerializeRigidBodyOption;
			if (onSerializeRigidBody2 != (OnSerializeRigidBody)3)
			{
				if (onSerializeRigidBody2 != OnSerializeRigidBody.OnlyAngularVelocity)
				{
					if (onSerializeRigidBody2 == OnSerializeRigidBody.OnlyVelocity)
					{
						HCIJEDFCNOP.IBCLJIACBKG(rigidbody2D.velocity);
					}
				}
				else
				{
					HCIJEDFCNOP.PBECMJMDHBI(rigidbody2D.angularVelocity);
				}
			}
			else
			{
				HCIJEDFCNOP.PNAPNHJHBMN(rigidbody2D.velocity);
				HCIJEDFCNOP.OLACNHHHOEL(rigidbody2D.angularVelocity);
			}
		}
		else
		{
			Debug.LogError("SfxVolumeSlider" + GJLCNFAGNPO.GetType());
		}
	}

	// Token: 0x170002AD RID: 685
	// (get) Token: 0x0600B54D RID: 46413 RVA: 0x0042A533 File Offset: 0x00428733
	public bool isMine
	{
		get
		{
			return this.ownerId == PhotonNetwork.player.ID || (!this.isOwnerActive && PhotonNetwork.isMasterClient);
		}
	}

	// Token: 0x0600B54E RID: 46414 RVA: 0x0042A560 File Offset: 0x00428760
	protected internal void KDPJOLMNEPG()
	{
		if (!this.IHPAIFIHLAE)
		{
			bool flag = PhotonNetwork.JNJJAMNLOHA.LocalCleanPhotonView(this);
			bool flag2 = false;
			if (flag && !flag2 && this.instantiationId > 1 && !PhotonHandler.MBIFDLCKGKN && PhotonNetwork.logLevel >= PhotonLogLevel.ErrorsOnly)
			{
				Debug.Log("Set sun min/max size" + base.gameObject.name + ">");
			}
		}
	}

	// Token: 0x0600B54F RID: 46415 RVA: 0x0042A5D2 File Offset: 0x004287D2
	public void INKNMCPAAGF(int BJKANENNNOF)
	{
		PhotonNetwork.JNJJAMNLOHA.JHCPMMIEDEE(this.EIMHMIJGMHG(), BJKANENNNOF);
		this.ownerId = BJKANENNNOF;
	}

	// Token: 0x0600B550 RID: 46416 RVA: 0x00429479 File Offset: 0x00427679
	public void FOLJDOPCBNA(object[] DPNHODJHGJL)
	{
		this.NJDPOGADFJN = DPNHODJHGJL;
	}

	// Token: 0x0600B551 RID: 46417 RVA: 0x00428BA6 File Offset: 0x00426DA6
	public static PhotonView PMLJACJKPLN(int NADLIACHBNO)
	{
		return PhotonNetwork.JNJJAMNLOHA.GetPhotonView(NADLIACHBNO);
	}

	// Token: 0x170002A5 RID: 677
	// (get) Token: 0x0600B553 RID: 46419 RVA: 0x00428A99 File Offset: 0x00426C99
	// (set) Token: 0x0600B560 RID: 46432 RVA: 0x00429F42 File Offset: 0x00428142
	public int prefix
	{
		get
		{
			if (this.prefixBackup == -1 && PhotonNetwork.JNJJAMNLOHA != null)
			{
				this.prefixBackup = (int)PhotonNetwork.JNJJAMNLOHA.PKCNHOKCLJH;
			}
			return this.prefixBackup;
		}
		set
		{
			this.prefixBackup = value;
		}
	}

	// Token: 0x0600B554 RID: 46420 RVA: 0x0042A61C File Offset: 0x0042881C
	public void EIGJKNOFCHH(int BJKANENNNOF)
	{
		PhotonNetwork.JNJJAMNLOHA.JHCPMMIEDEE(this.KINIHBOKFJH(), BJKANENNNOF);
		this.ownerId = BJKANENNNOF;
	}

	// Token: 0x0600B555 RID: 46421 RVA: 0x00428A99 File Offset: 0x00426C99
	public int LLHIOGOHDPK()
	{
		if (this.prefixBackup == -1 && PhotonNetwork.JNJJAMNLOHA != null)
		{
			this.prefixBackup = (int)PhotonNetwork.JNJJAMNLOHA.PKCNHOKCLJH;
		}
		return this.prefixBackup;
	}

	// Token: 0x0600B556 RID: 46422 RVA: 0x00429892 File Offset: 0x00427A92
	public void DKGMOICLEMI(string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, bool AKFHJNFOCDP, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MJCDIJOAEPI, AKFHJNFOCDP, GNNEKCBOBEG);
	}

	// Token: 0x0600B557 RID: 46423 RVA: 0x00429892 File Offset: 0x00427A92
	public void IEJEHKMNLHE(string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, bool AKFHJNFOCDP, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MJCDIJOAEPI, AKFHJNFOCDP, GNNEKCBOBEG);
	}

	// Token: 0x0600B558 RID: 46424 RVA: 0x0042A638 File Offset: 0x00428838
	public override string ToString()
	{
		return string.Format("View ({3}){0} on {1} {2}", new object[]
		{
			this.viewID,
			(!(base.gameObject != null)) ? "GO==null" : base.gameObject.name,
			(!this.isSceneView) ? string.Empty : "(scene)",
			this.prefix
		});
	}

	// Token: 0x0600B559 RID: 46425 RVA: 0x00428BA6 File Offset: 0x00426DA6
	public static PhotonView IOENOELDJOF(int NADLIACHBNO)
	{
		return PhotonNetwork.JNJJAMNLOHA.GetPhotonView(NADLIACHBNO);
	}

	// Token: 0x0600B55A RID: 46426 RVA: 0x00429892 File Offset: 0x00427A92
	public void RpcSecure(string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, bool AKFHJNFOCDP, params object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MJCDIJOAEPI, AKFHJNFOCDP, GNNEKCBOBEG);
	}

	// Token: 0x0600B55B RID: 46427 RVA: 0x0042A6B7 File Offset: 0x004288B7
	public bool BGJKMGJBPFA()
	{
		return this.ownerId == PhotonNetwork.player.ONIKFABKELO() || (!this.JFLEHJHLAOH() && PhotonNetwork.isMasterClient);
	}

	// Token: 0x0600B55C RID: 46428 RVA: 0x0042A6E4 File Offset: 0x004288E4
	public void BJKCNDBLHML(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (this.ObservedComponents != null && this.ObservedComponents.Count > 0)
		{
			for (int i = 0; i < this.ObservedComponents.Count; i++)
			{
				this.FHDECBOJGBN(this.ObservedComponents[i], HCIJEDFCNOP, DAGALCAILLN);
			}
		}
	}

	// Token: 0x0600B55D RID: 46429 RVA: 0x00429094 File Offset: 0x00427294
	public void JGGMHLIHLHJ()
	{
		PhotonNetwork.JNJJAMNLOHA.EPGIIBMOHEG(this.EIMHMIJGMHG(), this.ownerId);
	}

	// Token: 0x0600B55E RID: 46430 RVA: 0x00429FD8 File Offset: 0x004281D8
	public void OMGPDMLNBIO()
	{
		PhotonNetwork.JNJJAMNLOHA.EPGIIBMOHEG(this.viewID, this.ownerId);
	}

	// Token: 0x0600B55F RID: 46431 RVA: 0x004293B0 File Offset: 0x004275B0
	public int FOLKNAAAEAJ()
	{
		return this.viewIdField / PhotonNetwork.MAX_VIEW_IDS;
	}

	// Token: 0x0600B561 RID: 46433 RVA: 0x00428BA6 File Offset: 0x00426DA6
	public static PhotonView Find(int NADLIACHBNO)
	{
		return PhotonNetwork.JNJJAMNLOHA.GetPhotonView(NADLIACHBNO);
	}

	// Token: 0x0600B562 RID: 46434 RVA: 0x0042A740 File Offset: 0x00428940
	public virtual string BNGOOJMFMDB()
	{
		string format = "_ChangeGreen";
		object[] array = new object[7];
		array[0] = this.EIMHMIJGMHG();
		array[0] = ((!(base.gameObject != null)) ? "value" : base.gameObject.name);
		array[6] = ((!this.NADJFHDOFGD()) ? string.Empty : "_TimeX");
		array[1] = this.LHPJFDEFJPC();
		return string.Format(format, array);
	}

	// Token: 0x0600B563 RID: 46435 RVA: 0x00428BA6 File Offset: 0x00426DA6
	public static PhotonView FNNLDKMFBEB(int NADLIACHBNO)
	{
		return PhotonNetwork.JNJJAMNLOHA.GetPhotonView(NADLIACHBNO);
	}

	// Token: 0x0600B564 RID: 46436 RVA: 0x004298BA File Offset: 0x00427ABA
	public int KINIHBOKFJH()
	{
		return this.viewIdField;
	}

	// Token: 0x0600B565 RID: 46437 RVA: 0x0042A7BF File Offset: 0x004289BF
	public bool NADJFHDOFGD()
	{
		return this.PCLFPBHIHOD() == 1;
	}

	// Token: 0x0600B566 RID: 46438 RVA: 0x00428BB3 File Offset: 0x00426DB3
	public int HAKJLPJJEPB()
	{
		return this.ownerId;
	}

	// Token: 0x0600B567 RID: 46439 RVA: 0x0042A7CC File Offset: 0x004289CC
	public void CFNCHMDHHOG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (this.ObservedComponents != null && this.ObservedComponents.Count > 0)
		{
			for (int i = 0; i < this.ObservedComponents.Count; i += 0)
			{
				this.CGCDEFOFKJD(this.ObservedComponents[i], HCIJEDFCNOP, DAGALCAILLN);
			}
		}
	}

	// Token: 0x0600B568 RID: 46440 RVA: 0x00428B98 File Offset: 0x00426D98
	public void ICGKDCPIOML()
	{
		this.HFCEJMOIGDF = base.GetComponents<UnityEngine.MonoBehaviour>();
	}

	// Token: 0x0600B569 RID: 46441 RVA: 0x00429E15 File Offset: 0x00428015
	public bool JFLEHJHLAOH()
	{
		return this.ownerId == 0 || PhotonNetwork.JNJJAMNLOHA.mActors.ContainsKey(this.ownerId);
	}

	// Token: 0x0600B56A RID: 46442 RVA: 0x004297D0 File Offset: 0x004279D0
	public PhotonPlayer JFCKAGHNNCA()
	{
		return PhotonPlayer.Find(this.ownerId);
	}

	// Token: 0x0600B56B RID: 46443 RVA: 0x00429CA6 File Offset: 0x00427EA6
	public void NIFBLFCCLCD(int BJKANENNNOF)
	{
		PhotonNetwork.JNJJAMNLOHA.JHCPMMIEDEE(this.viewID, BJKANENNNOF);
		this.ownerId = BJKANENNNOF;
	}

	// Token: 0x0600B56C RID: 46444 RVA: 0x0042A828 File Offset: 0x00428A28
	public void JAFHOIGANHK(PhotonPlayer DELECHPDOCO)
	{
		if (this.LILIOIJNOGO() == 0 && !this.OwnerShipWasTransfered && (this.currentMasterID == -1 || this.ownerId == this.currentMasterID))
		{
			this.ownerId = DELECHPDOCO.ONIKFABKELO();
		}
		this.currentMasterID = DELECHPDOCO.ONIKFABKELO();
	}

	// Token: 0x0600B56D RID: 46445 RVA: 0x0042A7BF File Offset: 0x004289BF
	public bool LIDEPDFOMFC()
	{
		return this.PCLFPBHIHOD() == 1;
	}

	// Token: 0x0600B56E RID: 46446 RVA: 0x00429F09 File Offset: 0x00428109
	public void KACECEKIPPP(string LBLKDNNPACO, PhotonPlayer MJCDIJOAEPI, object[] GNNEKCBOBEG)
	{
		PhotonNetwork.HFFGNHGFKPE(this, LBLKDNNPACO, MJCDIJOAEPI, true, GNNEKCBOBEG);
	}

	// Token: 0x0600B56F RID: 46447 RVA: 0x0042A880 File Offset: 0x00428A80
	public void OKNICNLFLFP(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (this.ObservedComponents != null && this.ObservedComponents.Count > 0)
		{
			for (int i = 1; i < this.ObservedComponents.Count; i++)
			{
				this.CGCDEFOFKJD(this.ObservedComponents[i], HCIJEDFCNOP, DAGALCAILLN);
			}
		}
	}

	// Token: 0x04001548 RID: 5448
	public int ownerId;

	// Token: 0x04001549 RID: 5449
	public byte group;

	// Token: 0x0400154A RID: 5450
	protected internal bool PBIDCPBMFKJ;

	// Token: 0x0400154B RID: 5451
	public bool OwnerShipWasTransfered;

	// Token: 0x0400154C RID: 5452
	public int prefixBackup = -1;

	// Token: 0x0400154D RID: 5453
	internal object[] NJDPOGADFJN;

	// Token: 0x0400154E RID: 5454
	protected internal object[] EOENPICKCCO;

	// Token: 0x0400154F RID: 5455
	protected internal object[] EMJBOOJPAII;

	// Token: 0x04001550 RID: 5456
	public ViewSynchronization synchronization;

	// Token: 0x04001551 RID: 5457
	public OnSerializeTransform onSerializeTransformOption = OnSerializeTransform.PositionAndRotation;

	// Token: 0x04001552 RID: 5458
	public OnSerializeRigidBody onSerializeRigidBodyOption = OnSerializeRigidBody.All;

	// Token: 0x04001553 RID: 5459
	public OwnershipOption ownershipTransfer;

	// Token: 0x04001554 RID: 5460
	public List<Component> ObservedComponents;

	// Token: 0x04001555 RID: 5461
	private Dictionary<Component, MethodInfo> JKIMNJDIPLG = new Dictionary<Component, MethodInfo>(3);

	// Token: 0x04001556 RID: 5462
	[SerializeField]
	private int viewIdField;

	// Token: 0x04001557 RID: 5463
	public int instantiationId;

	// Token: 0x04001558 RID: 5464
	public int currentMasterID = -1;

	// Token: 0x04001559 RID: 5465
	protected internal bool GEKLBLEBECG;

	// Token: 0x0400155A RID: 5466
	[SerializeField]
	protected internal bool isRuntimeInstantiated;

	// Token: 0x0400155B RID: 5467
	protected internal bool IHPAIFIHLAE;

	// Token: 0x0400155C RID: 5468
	internal UnityEngine.MonoBehaviour[] HFCEJMOIGDF;

	// Token: 0x0400155D RID: 5469
	private MethodInfo EBGDOIJCPMD;

	// Token: 0x0400155E RID: 5470
	private bool HPHLCBGKEAG;
}
