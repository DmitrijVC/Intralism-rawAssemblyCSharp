using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000332 RID: 818
public class PhotonTransformViewPositionControl
{
	// Token: 0x0600BAA6 RID: 47782 RVA: 0x0043F1FC File Offset: 0x0043D3FC
	public void DLFLONFGGGG(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			this.MAKLJGJLMGM(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
		}
		else
		{
			this.GFNOFOOGLHA(HCIJEDFCNOP, DAGALCAILLN);
		}
		this.IMNELEFELLD = PhotonNetwork.time;
		this.KNEDICOFDOC = false;
	}

	// Token: 0x0600BAA7 RID: 47783 RVA: 0x0043F250 File Offset: 0x0043D450
	private Vector3 DJGBPPCBIAP()
	{
		Vector3 result = this.LPBKKPPALCD;
		if (this.LLCJGHBKDJF.Count > 1)
		{
			result = this.LLCJGHBKDJF.Peek();
		}
		return result;
	}

	// Token: 0x0600BAA8 RID: 47784 RVA: 0x0043F284 File Offset: 0x0043D484
	private void GOMDFKNFIDK(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		Vector3 lpbkkppalcd = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
		if (this.HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled || this.HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.EstimatedSpeed)
		{
			this.JPAGJFHJAAB = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			this.FEMCINHEMEO = (float)HCIJEDFCNOP.ReceiveNext();
		}
		if (this.LLCJGHBKDJF.Count == 0)
		{
			this.LPBKKPPALCD = lpbkkppalcd;
		}
		this.LLCJGHBKDJF.Enqueue(this.LPBKKPPALCD);
		this.LPBKKPPALCD = lpbkkppalcd;
		while (this.LLCJGHBKDJF.Count > this.HNCFAJJGIPN.ExtrapolateNumberOfStoredPositions)
		{
			this.LLCJGHBKDJF.Dequeue();
		}
	}

	// Token: 0x0600BAA9 RID: 47785 RVA: 0x0043F33C File Offset: 0x0043D53C
	public Vector3 MDAKHCPMDIE()
	{
		return this.LPBKKPPALCD;
	}

	// Token: 0x0600BAAA RID: 47786 RVA: 0x0043F344 File Offset: 0x0043D544
	public void OnPhotonSerializeView(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.isWriting)
		{
			this.MAKLJGJLMGM(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
		}
		else
		{
			this.OCPONOCDGGO(HCIJEDFCNOP, DAGALCAILLN);
		}
		this.IMNELEFELLD = PhotonNetwork.time;
		this.KNEDICOFDOC = false;
	}

	// Token: 0x0600BAAB RID: 47787 RVA: 0x0043F398 File Offset: 0x0043D598
	private void OCPONOCDGGO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		Vector3 lpbkkppalcd = (Vector3)HCIJEDFCNOP.ReceiveNext();
		if (this.HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues || this.HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.SynchronizeValues)
		{
			this.JPAGJFHJAAB = (Vector3)HCIJEDFCNOP.ReceiveNext();
			this.FEMCINHEMEO = (float)HCIJEDFCNOP.ReceiveNext();
		}
		if (this.LLCJGHBKDJF.Count == 0)
		{
			this.LPBKKPPALCD = lpbkkppalcd;
		}
		this.LLCJGHBKDJF.Enqueue(this.LPBKKPPALCD);
		this.LPBKKPPALCD = lpbkkppalcd;
		while (this.LLCJGHBKDJF.Count > this.HNCFAJJGIPN.ExtrapolateNumberOfStoredPositions)
		{
			this.LLCJGHBKDJF.Dequeue();
		}
	}

	// Token: 0x0600BAAC RID: 47788 RVA: 0x0043F450 File Offset: 0x0043D650
	private void AEACCHDDKDN(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		HCIJEDFCNOP.PBECMJMDHBI(BLPBCOCAKGG);
		this.LPBKKPPALCD = BLPBCOCAKGG;
		if (this.HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled || this.HNCFAJJGIPN.InterpolateOption == (PhotonTransformViewPositionModel.InterpolateOptions)5)
		{
			HCIJEDFCNOP.FADAIFFMBEL(this.JPAGJFHJAAB);
			HCIJEDFCNOP.FADAIFFMBEL(this.FEMCINHEMEO);
		}
	}

	// Token: 0x0600BAAD RID: 47789 RVA: 0x0043F4B4 File Offset: 0x0043D6B4
	private void MAKLJGJLMGM(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		HCIJEDFCNOP.SendNext(BLPBCOCAKGG);
		this.LPBKKPPALCD = BLPBCOCAKGG;
		if (this.HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues || this.HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.SynchronizeValues)
		{
			HCIJEDFCNOP.SendNext(this.JPAGJFHJAAB);
			HCIJEDFCNOP.SendNext(this.FEMCINHEMEO);
		}
	}

	// Token: 0x0600BAAE RID: 47790 RVA: 0x0043F518 File Offset: 0x0043D718
	private Vector3 NBDLINFNPDD()
	{
		Vector3 result = this.LPBKKPPALCD;
		if (this.LLCJGHBKDJF.Count > 0)
		{
			result = this.LLCJGHBKDJF.Peek();
		}
		return result;
	}

	// Token: 0x0600BAAF RID: 47791 RVA: 0x0043F33C File Offset: 0x0043D53C
	public Vector3 GetNetworkPosition()
	{
		return this.LPBKKPPALCD;
	}

	// Token: 0x0600BAB0 RID: 47792 RVA: 0x0043F54A File Offset: 0x0043D74A
	public PhotonTransformViewPositionControl(PhotonTransformViewPositionModel PMLNAMDEBFI)
	{
		this.HNCFAJJGIPN = PMLNAMDEBFI;
	}

	// Token: 0x0600BAB1 RID: 47793 RVA: 0x0043F578 File Offset: 0x0043D778
	private void DLIEMONDDJB(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		Vector3 lpbkkppalcd = (Vector3)HCIJEDFCNOP.ACOGAHJKGJH();
		if (this.HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled || this.HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.Disabled)
		{
			this.JPAGJFHJAAB = (Vector3)HCIJEDFCNOP.NLPFEFOCGBC();
			this.FEMCINHEMEO = (float)HCIJEDFCNOP.KIEJNJBDAJJ();
		}
		if (this.LLCJGHBKDJF.Count == 0)
		{
			this.LPBKKPPALCD = lpbkkppalcd;
		}
		this.LLCJGHBKDJF.Enqueue(this.LPBKKPPALCD);
		this.LPBKKPPALCD = lpbkkppalcd;
		while (this.LLCJGHBKDJF.Count > this.HNCFAJJGIPN.ExtrapolateNumberOfStoredPositions)
		{
			this.LLCJGHBKDJF.Dequeue();
		}
	}

	// Token: 0x0600BAB2 RID: 47794 RVA: 0x0043F630 File Offset: 0x0043D830
	public Vector3 FBGHNHMHIFM(Vector3 BLPBCOCAKGG)
	{
		Vector3 vector = this.GetNetworkPosition() + this.NEIMAGJMAID();
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		case PhotonTransformViewPositionModel.InterpolateOptions.Disabled:
			if (!this.KNEDICOFDOC)
			{
				BLPBCOCAKGG = vector;
				this.KNEDICOFDOC = false;
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.FixedSpeed:
			BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * this.HNCFAJJGIPN.InterpolateMoveTowardsSpeed);
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.EstimatedSpeed:
			if (this.LLCJGHBKDJF.Count != 0)
			{
				float num = Vector3.Distance(this.LPBKKPPALCD, this.EPAOHJJPLHF()) / (float)this.LLCJGHBKDJF.Count * (float)PhotonNetwork.sendRateOnSerialize;
				BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * num);
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.SynchronizeValues:
			if (this.JPAGJFHJAAB.magnitude == 927f)
			{
				BLPBCOCAKGG = vector;
			}
			else
			{
				BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * this.JPAGJFHJAAB.magnitude);
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.Lerp:
			BLPBCOCAKGG = Vector3.Lerp(BLPBCOCAKGG, vector, Time.deltaTime * this.HNCFAJJGIPN.InterpolateLerpSpeed);
			break;
		}
		if (this.HNCFAJJGIPN.TeleportEnabled && Vector3.Distance(BLPBCOCAKGG, this.NLNDBCNKLJH()) > this.HNCFAJJGIPN.TeleportIfDistanceGreaterThan)
		{
			BLPBCOCAKGG = this.GetNetworkPosition();
		}
		return BLPBCOCAKGG;
	}

	// Token: 0x0600BAB3 RID: 47795 RVA: 0x0043F794 File Offset: 0x0043D994
	private Vector3 MADPPANNBPF()
	{
		Vector3 result = this.LPBKKPPALCD;
		if (this.LLCJGHBKDJF.Count > 0)
		{
			result = this.LLCJGHBKDJF.Peek();
		}
		return result;
	}

	// Token: 0x0600BAB4 RID: 47796 RVA: 0x0043F7C8 File Offset: 0x0043D9C8
	public Vector3 MAPFEGKAOOG()
	{
		float num = (float)(PhotonNetwork.time - this.IMNELEFELLD);
		if (this.HNCFAJJGIPN.ExtrapolateIncludingRoundTripTime)
		{
			num += (float)PhotonNetwork.GetPing() / 1222f;
		}
		Vector3 result = Vector3.zero;
		PhotonTransformViewPositionModel.ExtrapolateOptions extrapolateOption = this.HNCFAJJGIPN.ExtrapolateOption;
		if (extrapolateOption != PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled)
		{
			if (extrapolateOption != (PhotonTransformViewPositionModel.ExtrapolateOptions)8)
			{
				if (extrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.FixedSpeed)
				{
					Vector3 a = (this.LPBKKPPALCD - this.DJGBPPCBIAP()) * (float)PhotonNetwork.sendRateOnSerialize;
					result = a * num;
				}
			}
			else
			{
				Vector3 normalized = (this.LPBKKPPALCD - this.DJGBPPCBIAP()).normalized;
				result = normalized * this.HNCFAJJGIPN.ExtrapolateSpeed * num;
			}
		}
		else
		{
			Quaternion rotation = Quaternion.Euler(1115f, this.FEMCINHEMEO * num, 819f);
			result = rotation * (this.JPAGJFHJAAB * num);
		}
		return result;
	}

	// Token: 0x0600BAB5 RID: 47797 RVA: 0x0043F8C8 File Offset: 0x0043DAC8
	public Vector3 NEIMAGJMAID()
	{
		float num = (float)(PhotonNetwork.time - this.IMNELEFELLD);
		if (this.HNCFAJJGIPN.ExtrapolateIncludingRoundTripTime)
		{
			num += (float)PhotonNetwork.GetPing() / 1153f;
		}
		Vector3 result = Vector3.zero;
		PhotonTransformViewPositionModel.ExtrapolateOptions extrapolateOption = this.HNCFAJJGIPN.ExtrapolateOption;
		if (extrapolateOption != PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues)
		{
			if (extrapolateOption != PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues)
			{
				if (extrapolateOption == (PhotonTransformViewPositionModel.ExtrapolateOptions)7)
				{
					Vector3 a = (this.LPBKKPPALCD - this.MADPPANNBPF()) * (float)PhotonNetwork.sendRateOnSerialize;
					result = a * num;
				}
			}
			else
			{
				Vector3 normalized = (this.LPBKKPPALCD - this.IBCEDCJHLAM()).normalized;
				result = normalized * this.HNCFAJJGIPN.ExtrapolateSpeed * num;
			}
		}
		else
		{
			Quaternion rotation = Quaternion.Euler(1607f, this.FEMCINHEMEO * num, 1661f);
			result = rotation * (this.JPAGJFHJAAB * num);
		}
		return result;
	}

	// Token: 0x0600BAB6 RID: 47798 RVA: 0x0043F9C8 File Offset: 0x0043DBC8
	private Vector3 FAOPHBBFBMP()
	{
		Vector3 result = this.LPBKKPPALCD;
		if (this.LLCJGHBKDJF.Count > 0)
		{
			result = this.LLCJGHBKDJF.Peek();
		}
		return result;
	}

	// Token: 0x0600BAB7 RID: 47799 RVA: 0x0043F33C File Offset: 0x0043D53C
	public Vector3 JHBPKKMPBGA()
	{
		return this.LPBKKPPALCD;
	}

	// Token: 0x0600BAB8 RID: 47800 RVA: 0x0043F9FC File Offset: 0x0043DBFC
	private void CGDCPIBAGCO(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		Vector3 lpbkkppalcd = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
		if (this.HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues || this.HNCFAJJGIPN.InterpolateOption == (PhotonTransformViewPositionModel.InterpolateOptions)7)
		{
			this.JPAGJFHJAAB = (Vector3)HCIJEDFCNOP.FIBMOBNIALK();
			this.FEMCINHEMEO = (float)HCIJEDFCNOP.IDKHBJIHKEB();
		}
		if (this.LLCJGHBKDJF.Count == 0)
		{
			this.LPBKKPPALCD = lpbkkppalcd;
		}
		this.LLCJGHBKDJF.Enqueue(this.LPBKKPPALCD);
		this.LPBKKPPALCD = lpbkkppalcd;
		while (this.LLCJGHBKDJF.Count > this.HNCFAJJGIPN.ExtrapolateNumberOfStoredPositions)
		{
			this.LLCJGHBKDJF.Dequeue();
		}
	}

	// Token: 0x0600BAB9 RID: 47801 RVA: 0x0043FAB4 File Offset: 0x0043DCB4
	public Vector3 DEEDPNNEJPO(Vector3 BLPBCOCAKGG)
	{
		Vector3 vector = this.NLNDBCNKLJH() + this.NEIMAGJMAID();
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		case PhotonTransformViewPositionModel.InterpolateOptions.Disabled:
			if (!this.KNEDICOFDOC)
			{
				BLPBCOCAKGG = vector;
				this.KNEDICOFDOC = false;
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.FixedSpeed:
			BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * this.HNCFAJJGIPN.InterpolateMoveTowardsSpeed);
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.EstimatedSpeed:
			if (this.LLCJGHBKDJF.Count != 0)
			{
				float num = Vector3.Distance(this.LPBKKPPALCD, this.DEKDAMEJFGB()) / (float)this.LLCJGHBKDJF.Count * (float)PhotonNetwork.sendRateOnSerialize;
				BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * num);
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.SynchronizeValues:
			if (this.JPAGJFHJAAB.magnitude == 390f)
			{
				BLPBCOCAKGG = vector;
			}
			else
			{
				BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * this.JPAGJFHJAAB.magnitude);
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.Lerp:
			BLPBCOCAKGG = Vector3.Lerp(BLPBCOCAKGG, vector, Time.deltaTime * this.HNCFAJJGIPN.InterpolateLerpSpeed);
			break;
		}
		if (this.HNCFAJJGIPN.TeleportEnabled && Vector3.Distance(BLPBCOCAKGG, this.GetNetworkPosition()) > this.HNCFAJJGIPN.TeleportIfDistanceGreaterThan)
		{
			BLPBCOCAKGG = this.NLNDBCNKLJH();
		}
		return BLPBCOCAKGG;
	}

	// Token: 0x0600BABA RID: 47802 RVA: 0x0043FC18 File Offset: 0x0043DE18
	private Vector3 DNCBFGDAEKL()
	{
		Vector3 result = this.LPBKKPPALCD;
		if (this.LLCJGHBKDJF.Count > 0)
		{
			result = this.LLCJGHBKDJF.Peek();
		}
		return result;
	}

	// Token: 0x0600BABB RID: 47803 RVA: 0x0043FC4C File Offset: 0x0043DE4C
	public void DEKGPEDBDJE(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			this.FAPILEEODKG(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
		}
		else
		{
			this.LCOGBDHHONG(HCIJEDFCNOP, DAGALCAILLN);
		}
		this.IMNELEFELLD = PhotonNetwork.time;
		this.KNEDICOFDOC = false;
	}

	// Token: 0x0600BABC RID: 47804 RVA: 0x0043FCA0 File Offset: 0x0043DEA0
	private void IKCDKEKJCCA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		Vector3 lpbkkppalcd = (Vector3)HCIJEDFCNOP.ReceiveNext();
		if (this.HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues || this.HNCFAJJGIPN.InterpolateOption == (PhotonTransformViewPositionModel.InterpolateOptions)6)
		{
			this.JPAGJFHJAAB = (Vector3)HCIJEDFCNOP.FIBMOBNIALK();
			this.FEMCINHEMEO = (float)HCIJEDFCNOP.LNDLNKJPAGO();
		}
		if (this.LLCJGHBKDJF.Count == 0)
		{
			this.LPBKKPPALCD = lpbkkppalcd;
		}
		this.LLCJGHBKDJF.Enqueue(this.LPBKKPPALCD);
		this.LPBKKPPALCD = lpbkkppalcd;
		while (this.LLCJGHBKDJF.Count > this.HNCFAJJGIPN.ExtrapolateNumberOfStoredPositions)
		{
			this.LLCJGHBKDJF.Dequeue();
		}
	}

	// Token: 0x0600BABD RID: 47805 RVA: 0x0043FD58 File Offset: 0x0043DF58
	private Vector3 DEKDAMEJFGB()
	{
		Vector3 result = this.LPBKKPPALCD;
		if (this.LLCJGHBKDJF.Count > 0)
		{
			result = this.LLCJGHBKDJF.Peek();
		}
		return result;
	}

	// Token: 0x0600BABE RID: 47806 RVA: 0x0043FD8C File Offset: 0x0043DF8C
	private Vector3 IBCEDCJHLAM()
	{
		Vector3 result = this.LPBKKPPALCD;
		if (this.LLCJGHBKDJF.Count > 1)
		{
			result = this.LLCJGHBKDJF.Peek();
		}
		return result;
	}

	// Token: 0x0600BABF RID: 47807 RVA: 0x0043FDBE File Offset: 0x0043DFBE
	public void CNABAIGBLIC(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		this.JPAGJFHJAAB = KEDDLFDAIDE;
		this.FEMCINHEMEO = HGHGFIDFHLO;
	}

	// Token: 0x0600BAC0 RID: 47808 RVA: 0x0043FDBE File Offset: 0x0043DFBE
	public void SetSynchronizedValues(Vector3 KEDDLFDAIDE, float HGHGFIDFHLO)
	{
		this.JPAGJFHJAAB = KEDDLFDAIDE;
		this.FEMCINHEMEO = HGHGFIDFHLO;
	}

	// Token: 0x0600BAC1 RID: 47809 RVA: 0x0043FDD0 File Offset: 0x0043DFD0
	public Vector3 GLDIJDCGPJG(Vector3 BLPBCOCAKGG)
	{
		Vector3 vector = this.JHBPKKMPBGA() + this.MGLDFCEODCA();
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		case PhotonTransformViewPositionModel.InterpolateOptions.Disabled:
			if (!this.KNEDICOFDOC)
			{
				BLPBCOCAKGG = vector;
				this.KNEDICOFDOC = true;
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.FixedSpeed:
			BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * this.HNCFAJJGIPN.InterpolateMoveTowardsSpeed);
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.EstimatedSpeed:
			if (this.LLCJGHBKDJF.Count != 0)
			{
				float num = Vector3.Distance(this.LPBKKPPALCD, this.DNCBFGDAEKL()) / (float)this.LLCJGHBKDJF.Count * (float)PhotonNetwork.sendRateOnSerialize;
				BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * num);
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.SynchronizeValues:
			if (this.JPAGJFHJAAB.magnitude == 93f)
			{
				BLPBCOCAKGG = vector;
			}
			else
			{
				BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * this.JPAGJFHJAAB.magnitude);
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.Lerp:
			BLPBCOCAKGG = Vector3.Lerp(BLPBCOCAKGG, vector, Time.deltaTime * this.HNCFAJJGIPN.InterpolateLerpSpeed);
			break;
		}
		if (this.HNCFAJJGIPN.TeleportEnabled && Vector3.Distance(BLPBCOCAKGG, this.APJJAKOIMIK()) > this.HNCFAJJGIPN.TeleportIfDistanceGreaterThan)
		{
			BLPBCOCAKGG = this.LFJPMNKJBMG();
		}
		return BLPBCOCAKGG;
	}

	// Token: 0x0600BAC2 RID: 47810 RVA: 0x0043FF34 File Offset: 0x0043E134
	public void PKDPLHBMKPM(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.isWriting)
		{
			this.FAPILEEODKG(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
		}
		else
		{
			this.CGDCPIBAGCO(HCIJEDFCNOP, DAGALCAILLN);
		}
		this.IMNELEFELLD = PhotonNetwork.time;
		this.KNEDICOFDOC = true;
	}

	// Token: 0x0600BAC3 RID: 47811 RVA: 0x0043FF88 File Offset: 0x0043E188
	private void LCOGBDHHONG(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		Vector3 lpbkkppalcd = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
		if (this.HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues || this.HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.Lerp)
		{
			this.JPAGJFHJAAB = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
			this.FEMCINHEMEO = (float)HCIJEDFCNOP.HPPOACOIMOJ();
		}
		if (this.LLCJGHBKDJF.Count == 0)
		{
			this.LPBKKPPALCD = lpbkkppalcd;
		}
		this.LLCJGHBKDJF.Enqueue(this.LPBKKPPALCD);
		this.LPBKKPPALCD = lpbkkppalcd;
		while (this.LLCJGHBKDJF.Count > this.HNCFAJJGIPN.ExtrapolateNumberOfStoredPositions)
		{
			this.LLCJGHBKDJF.Dequeue();
		}
	}

	// Token: 0x0600BAC4 RID: 47812 RVA: 0x00440040 File Offset: 0x0043E240
	public Vector3 UpdatePosition(Vector3 BLPBCOCAKGG)
	{
		Vector3 vector = this.GetNetworkPosition() + this.GetExtrapolatedPositionOffset();
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		case PhotonTransformViewPositionModel.InterpolateOptions.Disabled:
			if (!this.KNEDICOFDOC)
			{
				BLPBCOCAKGG = vector;
				this.KNEDICOFDOC = true;
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.FixedSpeed:
			BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * this.HNCFAJJGIPN.InterpolateMoveTowardsSpeed);
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.EstimatedSpeed:
			if (this.LLCJGHBKDJF.Count != 0)
			{
				float num = Vector3.Distance(this.LPBKKPPALCD, this.DNCBFGDAEKL()) / (float)this.LLCJGHBKDJF.Count * (float)PhotonNetwork.sendRateOnSerialize;
				BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * num);
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.SynchronizeValues:
			if (this.JPAGJFHJAAB.magnitude == 0f)
			{
				BLPBCOCAKGG = vector;
			}
			else
			{
				BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * this.JPAGJFHJAAB.magnitude);
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.Lerp:
			BLPBCOCAKGG = Vector3.Lerp(BLPBCOCAKGG, vector, Time.deltaTime * this.HNCFAJJGIPN.InterpolateLerpSpeed);
			break;
		}
		if (this.HNCFAJJGIPN.TeleportEnabled && Vector3.Distance(BLPBCOCAKGG, this.GetNetworkPosition()) > this.HNCFAJJGIPN.TeleportIfDistanceGreaterThan)
		{
			BLPBCOCAKGG = this.GetNetworkPosition();
		}
		return BLPBCOCAKGG;
	}

	// Token: 0x0600BAC5 RID: 47813 RVA: 0x004401A4 File Offset: 0x0043E3A4
	public void PNLAIDLOIDE(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			this.MAKLJGJLMGM(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
		}
		else
		{
			this.LCOGBDHHONG(HCIJEDFCNOP, DAGALCAILLN);
		}
		this.IMNELEFELLD = PhotonNetwork.time;
		this.KNEDICOFDOC = true;
	}

	// Token: 0x0600BAC6 RID: 47814 RVA: 0x004401F8 File Offset: 0x0043E3F8
	private void GFNOFOOGLHA(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		Vector3 lpbkkppalcd = (Vector3)HCIJEDFCNOP.ACOGAHJKGJH();
		if (this.HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled || this.HNCFAJJGIPN.InterpolateOption == (PhotonTransformViewPositionModel.InterpolateOptions)8)
		{
			this.JPAGJFHJAAB = (Vector3)HCIJEDFCNOP.ReceiveNext();
			this.FEMCINHEMEO = (float)HCIJEDFCNOP.FIBMOBNIALK();
		}
		if (this.LLCJGHBKDJF.Count == 0)
		{
			this.LPBKKPPALCD = lpbkkppalcd;
		}
		this.LLCJGHBKDJF.Enqueue(this.LPBKKPPALCD);
		this.LPBKKPPALCD = lpbkkppalcd;
		while (this.LLCJGHBKDJF.Count > this.HNCFAJJGIPN.ExtrapolateNumberOfStoredPositions)
		{
			this.LLCJGHBKDJF.Dequeue();
		}
	}

	// Token: 0x0600BAC7 RID: 47815 RVA: 0x004402B0 File Offset: 0x0043E4B0
	public Vector3 FLFDHNJMIOC()
	{
		float num = (float)(PhotonNetwork.time - this.IMNELEFELLD);
		if (this.HNCFAJJGIPN.ExtrapolateIncludingRoundTripTime)
		{
			num += (float)PhotonNetwork.GetPing() / 540f;
		}
		Vector3 result = Vector3.zero;
		PhotonTransformViewPositionModel.ExtrapolateOptions extrapolateOption = this.HNCFAJJGIPN.ExtrapolateOption;
		if (extrapolateOption != PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues)
		{
			if (extrapolateOption != (PhotonTransformViewPositionModel.ExtrapolateOptions)4)
			{
				if (extrapolateOption == (PhotonTransformViewPositionModel.ExtrapolateOptions)8)
				{
					Vector3 a = (this.LPBKKPPALCD - this.DJGBPPCBIAP()) * (float)PhotonNetwork.sendRateOnSerialize;
					result = a * num;
				}
			}
			else
			{
				Vector3 normalized = (this.LPBKKPPALCD - this.DEKDAMEJFGB()).normalized;
				result = normalized * this.HNCFAJJGIPN.ExtrapolateSpeed * num;
			}
		}
		else
		{
			Quaternion rotation = Quaternion.Euler(161f, this.FEMCINHEMEO * num, 1645f);
			result = rotation * (this.JPAGJFHJAAB * num);
		}
		return result;
	}

	// Token: 0x0600BAC8 RID: 47816 RVA: 0x004403B0 File Offset: 0x0043E5B0
	public Vector3 CBALKDFGNPE()
	{
		float num = (float)(PhotonNetwork.time - this.IMNELEFELLD);
		if (this.HNCFAJJGIPN.ExtrapolateIncludingRoundTripTime)
		{
			num += (float)PhotonNetwork.GetPing() / 736f;
		}
		Vector3 result = Vector3.zero;
		PhotonTransformViewPositionModel.ExtrapolateOptions extrapolateOption = this.HNCFAJJGIPN.ExtrapolateOption;
		if (extrapolateOption != PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled)
		{
			if (extrapolateOption != PhotonTransformViewPositionModel.ExtrapolateOptions.FixedSpeed)
			{
				if (extrapolateOption == (PhotonTransformViewPositionModel.ExtrapolateOptions)8)
				{
					Vector3 a = (this.LPBKKPPALCD - this.IBCEDCJHLAM()) * (float)PhotonNetwork.sendRateOnSerialize;
					result = a * num;
				}
			}
			else
			{
				Vector3 normalized = (this.LPBKKPPALCD - this.DNCBFGDAEKL()).normalized;
				result = normalized * this.HNCFAJJGIPN.ExtrapolateSpeed * num;
			}
		}
		else
		{
			Quaternion rotation = Quaternion.Euler(931f, this.FEMCINHEMEO * num, 203f);
			result = rotation * (this.JPAGJFHJAAB * num);
		}
		return result;
	}

	// Token: 0x0600BAC9 RID: 47817 RVA: 0x0043F33C File Offset: 0x0043D53C
	public Vector3 APJJAKOIMIK()
	{
		return this.LPBKKPPALCD;
	}

	// Token: 0x0600BACA RID: 47818 RVA: 0x004404B0 File Offset: 0x0043E6B0
	public Vector3 GetExtrapolatedPositionOffset()
	{
		float num = (float)(PhotonNetwork.time - this.IMNELEFELLD);
		if (this.HNCFAJJGIPN.ExtrapolateIncludingRoundTripTime)
		{
			num += (float)PhotonNetwork.GetPing() / 1000f;
		}
		Vector3 result = Vector3.zero;
		PhotonTransformViewPositionModel.ExtrapolateOptions extrapolateOption = this.HNCFAJJGIPN.ExtrapolateOption;
		if (extrapolateOption != PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues)
		{
			if (extrapolateOption != PhotonTransformViewPositionModel.ExtrapolateOptions.FixedSpeed)
			{
				if (extrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.EstimateSpeedAndTurn)
				{
					Vector3 a = (this.LPBKKPPALCD - this.DNCBFGDAEKL()) * (float)PhotonNetwork.sendRateOnSerialize;
					result = a * num;
				}
			}
			else
			{
				Vector3 normalized = (this.LPBKKPPALCD - this.DNCBFGDAEKL()).normalized;
				result = normalized * this.HNCFAJJGIPN.ExtrapolateSpeed * num;
			}
		}
		else
		{
			Quaternion rotation = Quaternion.Euler(0f, this.FEMCINHEMEO * num, 0f);
			result = rotation * (this.JPAGJFHJAAB * num);
		}
		return result;
	}

	// Token: 0x0600BACB RID: 47819 RVA: 0x004405B0 File Offset: 0x0043E7B0
	public Vector3 BEDHNBMPPGM(Vector3 BLPBCOCAKGG)
	{
		Vector3 vector = this.APJJAKOIMIK() + this.CBALKDFGNPE();
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		case PhotonTransformViewPositionModel.InterpolateOptions.Disabled:
			if (!this.KNEDICOFDOC)
			{
				BLPBCOCAKGG = vector;
				this.KNEDICOFDOC = true;
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.FixedSpeed:
			BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * this.HNCFAJJGIPN.InterpolateMoveTowardsSpeed);
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.EstimatedSpeed:
			if (this.LLCJGHBKDJF.Count != 0)
			{
				float num = Vector3.Distance(this.LPBKKPPALCD, this.IBCEDCJHLAM()) / (float)this.LLCJGHBKDJF.Count * (float)PhotonNetwork.sendRateOnSerialize;
				BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * num);
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.SynchronizeValues:
			if (this.JPAGJFHJAAB.magnitude == 888f)
			{
				BLPBCOCAKGG = vector;
			}
			else
			{
				BLPBCOCAKGG = Vector3.MoveTowards(BLPBCOCAKGG, vector, Time.deltaTime * this.JPAGJFHJAAB.magnitude);
			}
			break;
		case PhotonTransformViewPositionModel.InterpolateOptions.Lerp:
			BLPBCOCAKGG = Vector3.Lerp(BLPBCOCAKGG, vector, Time.deltaTime * this.HNCFAJJGIPN.InterpolateLerpSpeed);
			break;
		}
		if (this.HNCFAJJGIPN.TeleportEnabled && Vector3.Distance(BLPBCOCAKGG, this.NLNDBCNKLJH()) > this.HNCFAJJGIPN.TeleportIfDistanceGreaterThan)
		{
			BLPBCOCAKGG = this.LFJPMNKJBMG();
		}
		return BLPBCOCAKGG;
	}

	// Token: 0x0600BACC RID: 47820 RVA: 0x00440714 File Offset: 0x0043E914
	private void NDOFEBPLPBC(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		Vector3 lpbkkppalcd = (Vector3)HCIJEDFCNOP.IDKHBJIHKEB();
		if (this.HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues || this.HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.Disabled)
		{
			this.JPAGJFHJAAB = (Vector3)HCIJEDFCNOP.FIBMOBNIALK();
			this.FEMCINHEMEO = (float)HCIJEDFCNOP.NLPFEFOCGBC();
		}
		if (this.LLCJGHBKDJF.Count == 0)
		{
			this.LPBKKPPALCD = lpbkkppalcd;
		}
		this.LLCJGHBKDJF.Enqueue(this.LPBKKPPALCD);
		this.LPBKKPPALCD = lpbkkppalcd;
		while (this.LLCJGHBKDJF.Count > this.HNCFAJJGIPN.ExtrapolateNumberOfStoredPositions)
		{
			this.LLCJGHBKDJF.Dequeue();
		}
	}

	// Token: 0x0600BACD RID: 47821 RVA: 0x004407CC File Offset: 0x0043E9CC
	private void NLCMPPDJJAJ(PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		Vector3 lpbkkppalcd = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
		if (this.HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues || this.HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.FixedSpeed)
		{
			this.JPAGJFHJAAB = (Vector3)HCIJEDFCNOP.LNDLNKJPAGO();
			this.FEMCINHEMEO = (float)HCIJEDFCNOP.IDKHBJIHKEB();
		}
		if (this.LLCJGHBKDJF.Count == 0)
		{
			this.LPBKKPPALCD = lpbkkppalcd;
		}
		this.LLCJGHBKDJF.Enqueue(this.LPBKKPPALCD);
		this.LPBKKPPALCD = lpbkkppalcd;
		while (this.LLCJGHBKDJF.Count > this.HNCFAJJGIPN.ExtrapolateNumberOfStoredPositions)
		{
			this.LLCJGHBKDJF.Dequeue();
		}
	}

	// Token: 0x0600BACE RID: 47822 RVA: 0x00440884 File Offset: 0x0043EA84
	public void HIDJLJIEPHK(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			this.AEACCHDDKDN(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
		}
		else
		{
			this.GFNOFOOGLHA(HCIJEDFCNOP, DAGALCAILLN);
		}
		this.IMNELEFELLD = PhotonNetwork.time;
		this.KNEDICOFDOC = false;
	}

	// Token: 0x0600BACF RID: 47823 RVA: 0x004408D8 File Offset: 0x0043EAD8
	private void FAPILEEODKG(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		HCIJEDFCNOP.IBCLJIACBKG(BLPBCOCAKGG);
		this.LPBKKPPALCD = BLPBCOCAKGG;
		if (this.HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues || this.HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.FixedSpeed)
		{
			HCIJEDFCNOP.PNAPNHJHBMN(this.JPAGJFHJAAB);
			HCIJEDFCNOP.CPIBABMPJLE(this.FEMCINHEMEO);
		}
	}

	// Token: 0x0600BAD0 RID: 47824 RVA: 0x0043F33C File Offset: 0x0043D53C
	public Vector3 NLNDBCNKLJH()
	{
		return this.LPBKKPPALCD;
	}

	// Token: 0x0600BAD1 RID: 47825 RVA: 0x0043F33C File Offset: 0x0043D53C
	public Vector3 LFJPMNKJBMG()
	{
		return this.LPBKKPPALCD;
	}

	// Token: 0x0600BAD2 RID: 47826 RVA: 0x0044093C File Offset: 0x0043EB3C
	public Vector3 ECGDJCOKCBF()
	{
		float num = (float)(PhotonNetwork.time - this.IMNELEFELLD);
		if (this.HNCFAJJGIPN.ExtrapolateIncludingRoundTripTime)
		{
			num += (float)PhotonNetwork.GetPing() / 737f;
		}
		Vector3 result = Vector3.zero;
		PhotonTransformViewPositionModel.ExtrapolateOptions extrapolateOption = this.HNCFAJJGIPN.ExtrapolateOption;
		if (extrapolateOption != PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled)
		{
			if (extrapolateOption != (PhotonTransformViewPositionModel.ExtrapolateOptions)4)
			{
				if (extrapolateOption == (PhotonTransformViewPositionModel.ExtrapolateOptions)4)
				{
					Vector3 a = (this.LPBKKPPALCD - this.DEKDAMEJFGB()) * (float)PhotonNetwork.sendRateOnSerialize;
					result = a * num;
				}
			}
			else
			{
				Vector3 normalized = (this.LPBKKPPALCD - this.DNCBFGDAEKL()).normalized;
				result = normalized * this.HNCFAJJGIPN.ExtrapolateSpeed * num;
			}
		}
		else
		{
			Quaternion rotation = Quaternion.Euler(1224f, this.FEMCINHEMEO * num, 1456f);
			result = rotation * (this.JPAGJFHJAAB * num);
		}
		return result;
	}

	// Token: 0x0600BAD3 RID: 47827 RVA: 0x00440A3C File Offset: 0x0043EC3C
	private void DLMGGIPOMCE(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		HCIJEDFCNOP.PBECMJMDHBI(BLPBCOCAKGG);
		this.LPBKKPPALCD = BLPBCOCAKGG;
		if (this.HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled || this.HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.FixedSpeed)
		{
			HCIJEDFCNOP.PBECMJMDHBI(this.JPAGJFHJAAB);
			HCIJEDFCNOP.SendNext(this.FEMCINHEMEO);
		}
	}

	// Token: 0x0600BAD4 RID: 47828 RVA: 0x00440AA0 File Offset: 0x0043ECA0
	public void FBMDDFMGFMF(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			this.MAKLJGJLMGM(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
		}
		else
		{
			this.DLIEMONDDJB(HCIJEDFCNOP, DAGALCAILLN);
		}
		this.IMNELEFELLD = PhotonNetwork.time;
		this.KNEDICOFDOC = true;
	}

	// Token: 0x0600BAD5 RID: 47829 RVA: 0x00440AF4 File Offset: 0x0043ECF4
	public void HMMHABFJHEC(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			this.MAKLJGJLMGM(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
		}
		else
		{
			this.GOMDFKNFIDK(HCIJEDFCNOP, DAGALCAILLN);
		}
		this.IMNELEFELLD = PhotonNetwork.time;
		this.KNEDICOFDOC = false;
	}

	// Token: 0x0600BAD6 RID: 47830 RVA: 0x00440B48 File Offset: 0x0043ED48
	private void OCPFJLCANNF(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		HCIJEDFCNOP.PNAPNHJHBMN(BLPBCOCAKGG);
		this.LPBKKPPALCD = BLPBCOCAKGG;
		if (this.HNCFAJJGIPN.ExtrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled || this.HNCFAJJGIPN.InterpolateOption == PhotonTransformViewPositionModel.InterpolateOptions.Disabled)
		{
			HCIJEDFCNOP.SendNext(this.JPAGJFHJAAB);
			HCIJEDFCNOP.BBHGPGBHMML(this.FEMCINHEMEO);
		}
	}

	// Token: 0x0600BAD7 RID: 47831 RVA: 0x00440BAC File Offset: 0x0043EDAC
	private Vector3 EPAOHJJPLHF()
	{
		Vector3 result = this.LPBKKPPALCD;
		if (this.LLCJGHBKDJF.Count > 0)
		{
			result = this.LLCJGHBKDJF.Peek();
		}
		return result;
	}

	// Token: 0x0600BAD8 RID: 47832 RVA: 0x00440BE0 File Offset: 0x0043EDE0
	public Vector3 MGLDFCEODCA()
	{
		float num = (float)(PhotonNetwork.time - this.IMNELEFELLD);
		if (this.HNCFAJJGIPN.ExtrapolateIncludingRoundTripTime)
		{
			num += (float)PhotonNetwork.GetPing() / 478f;
		}
		Vector3 result = Vector3.zero;
		PhotonTransformViewPositionModel.ExtrapolateOptions extrapolateOption = this.HNCFAJJGIPN.ExtrapolateOption;
		if (extrapolateOption != PhotonTransformViewPositionModel.ExtrapolateOptions.Disabled)
		{
			if (extrapolateOption != (PhotonTransformViewPositionModel.ExtrapolateOptions)6)
			{
				if (extrapolateOption == PhotonTransformViewPositionModel.ExtrapolateOptions.SynchronizeValues)
				{
					Vector3 a = (this.LPBKKPPALCD - this.MADPPANNBPF()) * (float)PhotonNetwork.sendRateOnSerialize;
					result = a * num;
				}
			}
			else
			{
				Vector3 normalized = (this.LPBKKPPALCD - this.IBCEDCJHLAM()).normalized;
				result = normalized * this.HNCFAJJGIPN.ExtrapolateSpeed * num;
			}
		}
		else
		{
			Quaternion rotation = Quaternion.Euler(340f, this.FEMCINHEMEO * num, 761f);
			result = rotation * (this.JPAGJFHJAAB * num);
		}
		return result;
	}

	// Token: 0x0600BAD9 RID: 47833 RVA: 0x00440CE0 File Offset: 0x0043EEE0
	public void AAAGGIHAKEH(Vector3 BLPBCOCAKGG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.isWriting)
		{
			this.MAKLJGJLMGM(BLPBCOCAKGG, HCIJEDFCNOP, DAGALCAILLN);
		}
		else
		{
			this.CGDCPIBAGCO(HCIJEDFCNOP, DAGALCAILLN);
		}
		this.IMNELEFELLD = PhotonNetwork.time;
		this.KNEDICOFDOC = true;
	}

	// Token: 0x040015CD RID: 5581
	private PhotonTransformViewPositionModel HNCFAJJGIPN;

	// Token: 0x040015CE RID: 5582
	private float JEEKDHDNPKB;

	// Token: 0x040015CF RID: 5583
	private double IMNELEFELLD;

	// Token: 0x040015D0 RID: 5584
	private Vector3 JPAGJFHJAAB = Vector3.zero;

	// Token: 0x040015D1 RID: 5585
	private float FEMCINHEMEO;

	// Token: 0x040015D2 RID: 5586
	private Vector3 LPBKKPPALCD;

	// Token: 0x040015D3 RID: 5587
	private Queue<Vector3> LLCJGHBKDJF = new Queue<Vector3>();

	// Token: 0x040015D4 RID: 5588
	private bool KNEDICOFDOC = true;
}
