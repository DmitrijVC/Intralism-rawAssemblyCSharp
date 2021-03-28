using System;
using UnityEngine;

// Token: 0x02000339 RID: 825
public class PhotonTransformViewScaleControl
{
	// Token: 0x0600BB28 RID: 47912 RVA: 0x00442047 File Offset: 0x00440247
	public Vector3 JHLAPBECKPH()
	{
		return this.ENAJHAMBNFK;
	}

	// Token: 0x0600BB29 RID: 47913 RVA: 0x00442050 File Offset: 0x00440250
	public Vector3 NKLAIOJCAHD(Vector3 MGMPJFHHBMM)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.ENAJHAMBNFK;
		case PhotonTransformViewScaleModel.InterpolateOptions.MoveTowards:
			return Vector3.MoveTowards(MGMPJFHHBMM, this.ENAJHAMBNFK, this.HNCFAJJGIPN.InterpolateMoveTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewScaleModel.InterpolateOptions.Lerp:
			return Vector3.Lerp(MGMPJFHHBMM, this.ENAJHAMBNFK, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BB2A RID: 47914 RVA: 0x00442047 File Offset: 0x00440247
	public Vector3 MPJGCCAJAOA()
	{
		return this.ENAJHAMBNFK;
	}

	// Token: 0x0600BB2B RID: 47915 RVA: 0x004420C4 File Offset: 0x004402C4
	public void KLFPENLPMJP(Vector3 MGMPJFHHBMM, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.SendNext(MGMPJFHHBMM);
			this.ENAJHAMBNFK = MGMPJFHHBMM;
		}
		else
		{
			this.ENAJHAMBNFK = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
		}
	}

	// Token: 0x0600BB2C RID: 47916 RVA: 0x00442118 File Offset: 0x00440318
	public Vector3 OMAOHOBIMNM(Vector3 MGMPJFHHBMM)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.ENAJHAMBNFK;
		case PhotonTransformViewScaleModel.InterpolateOptions.MoveTowards:
			return Vector3.MoveTowards(MGMPJFHHBMM, this.ENAJHAMBNFK, this.HNCFAJJGIPN.InterpolateMoveTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewScaleModel.InterpolateOptions.Lerp:
			return Vector3.Lerp(MGMPJFHHBMM, this.ENAJHAMBNFK, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BB2D RID: 47917 RVA: 0x0044218C File Offset: 0x0044038C
	public void BAEICBGEECA(Vector3 MGMPJFHHBMM, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			HCIJEDFCNOP.PNAPNHJHBMN(MGMPJFHHBMM);
			this.ENAJHAMBNFK = MGMPJFHHBMM;
		}
		else
		{
			this.ENAJHAMBNFK = (Vector3)HCIJEDFCNOP.KIEJNJBDAJJ();
		}
	}

	// Token: 0x0600BB2E RID: 47918 RVA: 0x00442047 File Offset: 0x00440247
	public Vector3 BMOPJJPOKEE()
	{
		return this.ENAJHAMBNFK;
	}

	// Token: 0x0600BB2F RID: 47919 RVA: 0x004421E0 File Offset: 0x004403E0
	public Vector3 GetScale(Vector3 MGMPJFHHBMM)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.ENAJHAMBNFK;
		case PhotonTransformViewScaleModel.InterpolateOptions.MoveTowards:
			return Vector3.MoveTowards(MGMPJFHHBMM, this.ENAJHAMBNFK, this.HNCFAJJGIPN.InterpolateMoveTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewScaleModel.InterpolateOptions.Lerp:
			return Vector3.Lerp(MGMPJFHHBMM, this.ENAJHAMBNFK, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BB30 RID: 47920 RVA: 0x00442252 File Offset: 0x00440452
	public PhotonTransformViewScaleControl(PhotonTransformViewScaleModel PMLNAMDEBFI)
	{
		this.HNCFAJJGIPN = PMLNAMDEBFI;
	}

	// Token: 0x0600BB31 RID: 47921 RVA: 0x0044226C File Offset: 0x0044046C
	public Vector3 HJKPAPHBNND(Vector3 MGMPJFHHBMM)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.ENAJHAMBNFK;
		case PhotonTransformViewScaleModel.InterpolateOptions.MoveTowards:
			return Vector3.MoveTowards(MGMPJFHHBMM, this.ENAJHAMBNFK, this.HNCFAJJGIPN.InterpolateMoveTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewScaleModel.InterpolateOptions.Lerp:
			return Vector3.Lerp(MGMPJFHHBMM, this.ENAJHAMBNFK, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BB32 RID: 47922 RVA: 0x004422E0 File Offset: 0x004404E0
	public void COHGAEMDFEI(Vector3 MGMPJFHHBMM, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.FADAIFFMBEL(MGMPJFHHBMM);
			this.ENAJHAMBNFK = MGMPJFHHBMM;
		}
		else
		{
			this.ENAJHAMBNFK = (Vector3)HCIJEDFCNOP.FIBMOBNIALK();
		}
	}

	// Token: 0x0600BB33 RID: 47923 RVA: 0x00442047 File Offset: 0x00440247
	public Vector3 FLFKMOEGOKL()
	{
		return this.ENAJHAMBNFK;
	}

	// Token: 0x0600BB34 RID: 47924 RVA: 0x00442334 File Offset: 0x00440534
	public void DLFLONFGGGG(Vector3 MGMPJFHHBMM, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.CPIBABMPJLE(MGMPJFHHBMM);
			this.ENAJHAMBNFK = MGMPJFHHBMM;
		}
		else
		{
			this.ENAJHAMBNFK = (Vector3)HCIJEDFCNOP.KIMDMBDNICC();
		}
	}

	// Token: 0x0600BB35 RID: 47925 RVA: 0x00442047 File Offset: 0x00440247
	public Vector3 GetNetworkScale()
	{
		return this.ENAJHAMBNFK;
	}

	// Token: 0x0600BB36 RID: 47926 RVA: 0x00442047 File Offset: 0x00440247
	public Vector3 DBBAOGADAFG()
	{
		return this.ENAJHAMBNFK;
	}

	// Token: 0x0600BB37 RID: 47927 RVA: 0x00442388 File Offset: 0x00440588
	public void OnPhotonSerializeView(Vector3 MGMPJFHHBMM, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.SendNext(MGMPJFHHBMM);
			this.ENAJHAMBNFK = MGMPJFHHBMM;
		}
		else
		{
			this.ENAJHAMBNFK = (Vector3)HCIJEDFCNOP.ReceiveNext();
		}
	}

	// Token: 0x0600BB38 RID: 47928 RVA: 0x004423DC File Offset: 0x004405DC
	public void FBMDDFMGFMF(Vector3 MGMPJFHHBMM, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			HCIJEDFCNOP.FADAIFFMBEL(MGMPJFHHBMM);
			this.ENAJHAMBNFK = MGMPJFHHBMM;
		}
		else
		{
			this.ENAJHAMBNFK = (Vector3)HCIJEDFCNOP.IDKHBJIHKEB();
		}
	}

	// Token: 0x0600BB39 RID: 47929 RVA: 0x00442047 File Offset: 0x00440247
	public Vector3 IACAMHINPMK()
	{
		return this.ENAJHAMBNFK;
	}

	// Token: 0x0600BB3A RID: 47930 RVA: 0x00442047 File Offset: 0x00440247
	public Vector3 HIAGDLDLOJO()
	{
		return this.ENAJHAMBNFK;
	}

	// Token: 0x0600BB3B RID: 47931 RVA: 0x00442430 File Offset: 0x00440630
	public Vector3 GCKHEBOACNA(Vector3 MGMPJFHHBMM)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.ENAJHAMBNFK;
		case PhotonTransformViewScaleModel.InterpolateOptions.MoveTowards:
			return Vector3.MoveTowards(MGMPJFHHBMM, this.ENAJHAMBNFK, this.HNCFAJJGIPN.InterpolateMoveTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewScaleModel.InterpolateOptions.Lerp:
			return Vector3.Lerp(MGMPJFHHBMM, this.ENAJHAMBNFK, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BB3C RID: 47932 RVA: 0x00442047 File Offset: 0x00440247
	public Vector3 GIMLEHMPBKA()
	{
		return this.ENAJHAMBNFK;
	}

	// Token: 0x0600BB3D RID: 47933 RVA: 0x00442047 File Offset: 0x00440247
	public Vector3 PEFDNEOFNBE()
	{
		return this.ENAJHAMBNFK;
	}

	// Token: 0x0600BB3E RID: 47934 RVA: 0x004424A4 File Offset: 0x004406A4
	public Vector3 FNKIOEHHAMB(Vector3 MGMPJFHHBMM)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.ENAJHAMBNFK;
		case PhotonTransformViewScaleModel.InterpolateOptions.MoveTowards:
			return Vector3.MoveTowards(MGMPJFHHBMM, this.ENAJHAMBNFK, this.HNCFAJJGIPN.InterpolateMoveTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewScaleModel.InterpolateOptions.Lerp:
			return Vector3.Lerp(MGMPJFHHBMM, this.ENAJHAMBNFK, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BB3F RID: 47935 RVA: 0x00442047 File Offset: 0x00440247
	public Vector3 JBGODNPHENN()
	{
		return this.ENAJHAMBNFK;
	}

	// Token: 0x040015F8 RID: 5624
	private PhotonTransformViewScaleModel HNCFAJJGIPN;

	// Token: 0x040015F9 RID: 5625
	private Vector3 ENAJHAMBNFK = Vector3.one;
}
