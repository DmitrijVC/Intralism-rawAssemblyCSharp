using System;
using UnityEngine;

// Token: 0x02000336 RID: 822
public class PhotonTransformViewRotationControl
{
	// Token: 0x0600BADB RID: 47835 RVA: 0x00440E54 File Offset: 0x0043F054
	public Quaternion MEBDCCHLBEH(Quaternion LJCFLDEONDG)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BADC RID: 47836 RVA: 0x00440EC8 File Offset: 0x0043F0C8
	public void DEKGPEDBDJE(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.CPIBABMPJLE(LJCFLDEONDG);
			this.JNONKGEGLID = LJCFLDEONDG;
		}
		else
		{
			this.JNONKGEGLID = (Quaternion)HCIJEDFCNOP.KIEJNJBDAJJ();
		}
	}

	// Token: 0x0600BADD RID: 47837 RVA: 0x00440F1C File Offset: 0x0043F11C
	public Quaternion GKJEOLEBMMP(Quaternion LJCFLDEONDG)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BADE RID: 47838 RVA: 0x00440F90 File Offset: 0x0043F190
	public void FOHGOGIMPJJ(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			HCIJEDFCNOP.PNAPNHJHBMN(LJCFLDEONDG);
			this.JNONKGEGLID = LJCFLDEONDG;
		}
		else
		{
			this.JNONKGEGLID = (Quaternion)HCIJEDFCNOP.FIBMOBNIALK();
		}
	}

	// Token: 0x0600BADF RID: 47839 RVA: 0x00440FE4 File Offset: 0x0043F1E4
	public Quaternion JHEBHGPEKHK(Quaternion LJCFLDEONDG)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BAE0 RID: 47840 RVA: 0x00441058 File Offset: 0x0043F258
	public Quaternion GLDKMEANMAL(Quaternion LJCFLDEONDG)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BAE1 RID: 47841 RVA: 0x004410CC File Offset: 0x0043F2CC
	public Quaternion HCGAJCIDHPO(Quaternion LJCFLDEONDG)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BAE2 RID: 47842 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion NCMHIMAKPCK()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BAE3 RID: 47843 RVA: 0x00441148 File Offset: 0x0043F348
	public void PNLAIDLOIDE(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.IBCLJIACBKG(LJCFLDEONDG);
			this.JNONKGEGLID = LJCFLDEONDG;
		}
		else
		{
			this.JNONKGEGLID = (Quaternion)HCIJEDFCNOP.ReceiveNext();
		}
	}

	// Token: 0x0600BAE4 RID: 47844 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion EOGMILGMGLH()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BAE5 RID: 47845 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion NOMHOGGPPBG()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BAE6 RID: 47846 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion BFGDOFKCPGN()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BAE7 RID: 47847 RVA: 0x0044119C File Offset: 0x0043F39C
	public Quaternion BOEOKPPMJFP(Quaternion LJCFLDEONDG)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BAE8 RID: 47848 RVA: 0x00441210 File Offset: 0x0043F410
	public void MOLNBJLBPOO(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			HCIJEDFCNOP.PNAPNHJHBMN(LJCFLDEONDG);
			this.JNONKGEGLID = LJCFLDEONDG;
		}
		else
		{
			this.JNONKGEGLID = (Quaternion)HCIJEDFCNOP.IDKHBJIHKEB();
		}
	}

	// Token: 0x0600BAE9 RID: 47849 RVA: 0x00441264 File Offset: 0x0043F464
	public void MCEKDLDCGAO(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			HCIJEDFCNOP.SendNext(LJCFLDEONDG);
			this.JNONKGEGLID = LJCFLDEONDG;
		}
		else
		{
			this.JNONKGEGLID = (Quaternion)HCIJEDFCNOP.ACOGAHJKGJH();
		}
	}

	// Token: 0x0600BAEA RID: 47850 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion FMKLCNHHPGM()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BAEB RID: 47851 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion FAHKNKNOGPA()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BAEC RID: 47852 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion JPJLCPLIOCA()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BAED RID: 47853 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion GetNetworkRotation()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BAEE RID: 47854 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion EJONOHDCBLA()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BAEF RID: 47855 RVA: 0x004412B8 File Offset: 0x0043F4B8
	public void FBBMPGICGKC(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			HCIJEDFCNOP.SendNext(LJCFLDEONDG);
			this.JNONKGEGLID = LJCFLDEONDG;
		}
		else
		{
			this.JNONKGEGLID = (Quaternion)HCIJEDFCNOP.IDKHBJIHKEB();
		}
	}

	// Token: 0x0600BAF0 RID: 47856 RVA: 0x0044130C File Offset: 0x0043F50C
	public void EJPKMLLGMGB(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.CPIBABMPJLE(LJCFLDEONDG);
			this.JNONKGEGLID = LJCFLDEONDG;
		}
		else
		{
			this.JNONKGEGLID = (Quaternion)HCIJEDFCNOP.LNDLNKJPAGO();
		}
	}

	// Token: 0x0600BAF1 RID: 47857 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion KGPEHOLHPDF()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BAF2 RID: 47858 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion CKHDHEGPMHB()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BAF3 RID: 47859 RVA: 0x00441360 File Offset: 0x0043F560
	public Quaternion JJIODDBPLDP(Quaternion LJCFLDEONDG)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BAF4 RID: 47860 RVA: 0x004413D4 File Offset: 0x0043F5D4
	public void BJHJEDJDCEN(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			HCIJEDFCNOP.FADAIFFMBEL(LJCFLDEONDG);
			this.JNONKGEGLID = LJCFLDEONDG;
		}
		else
		{
			this.JNONKGEGLID = (Quaternion)HCIJEDFCNOP.ACOGAHJKGJH();
		}
	}

	// Token: 0x0600BAF5 RID: 47861 RVA: 0x00441428 File Offset: 0x0043F628
	public void JLPFFACDLJL(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			HCIJEDFCNOP.IBCLJIACBKG(LJCFLDEONDG);
			this.JNONKGEGLID = LJCFLDEONDG;
		}
		else
		{
			this.JNONKGEGLID = (Quaternion)HCIJEDFCNOP.ACOGAHJKGJH();
		}
	}

	// Token: 0x0600BAF6 RID: 47862 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion JIDMMGNNJNB()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BAF7 RID: 47863 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion GBGENCNGBJH()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BAF8 RID: 47864 RVA: 0x0044147C File Offset: 0x0043F67C
	public Quaternion IGMHPDBMMMH(Quaternion LJCFLDEONDG)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BAF9 RID: 47865 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion OAHAHAGJAPD()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BAFA RID: 47866 RVA: 0x004414F0 File Offset: 0x0043F6F0
	public Quaternion NNKFAAFFADP(Quaternion LJCFLDEONDG)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BAFB RID: 47867 RVA: 0x00441564 File Offset: 0x0043F764
	public void NMMEHKPNBCA(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			HCIJEDFCNOP.FADAIFFMBEL(LJCFLDEONDG);
			this.JNONKGEGLID = LJCFLDEONDG;
		}
		else
		{
			this.JNONKGEGLID = (Quaternion)HCIJEDFCNOP.ReceiveNext();
		}
	}

	// Token: 0x0600BAFC RID: 47868 RVA: 0x004415B8 File Offset: 0x0043F7B8
	public Quaternion OCIAPBJGCOM(Quaternion LJCFLDEONDG)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BAFD RID: 47869 RVA: 0x0044162C File Offset: 0x0043F82C
	public Quaternion ABCJPDICMOB(Quaternion LJCFLDEONDG)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BAFE RID: 47870 RVA: 0x004416A0 File Offset: 0x0043F8A0
	public Quaternion DMPPHLOHFKA(Quaternion LJCFLDEONDG)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BAFF RID: 47871 RVA: 0x00441714 File Offset: 0x0043F914
	public void DAFGPDBLAMA(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			HCIJEDFCNOP.CPIBABMPJLE(LJCFLDEONDG);
			this.JNONKGEGLID = LJCFLDEONDG;
		}
		else
		{
			this.JNONKGEGLID = (Quaternion)HCIJEDFCNOP.NLPFEFOCGBC();
		}
	}

	// Token: 0x0600BB00 RID: 47872 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion HAGGDALINJC()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BB01 RID: 47873 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion BKIPKPDHDEL()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BB02 RID: 47874 RVA: 0x00441768 File Offset: 0x0043F968
	public void OnPhotonSerializeView(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.SendNext(LJCFLDEONDG);
			this.JNONKGEGLID = LJCFLDEONDG;
		}
		else
		{
			this.JNONKGEGLID = (Quaternion)HCIJEDFCNOP.ReceiveNext();
		}
	}

	// Token: 0x0600BB03 RID: 47875 RVA: 0x004417BC File Offset: 0x0043F9BC
	public Quaternion PMEKGEFAEON(Quaternion LJCFLDEONDG)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BB04 RID: 47876 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion OJIMODNLGBG()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BB05 RID: 47877 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion KLHIJOJANBB()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BB06 RID: 47878 RVA: 0x00441830 File Offset: 0x0043FA30
	public void HPGOHBHACKF(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.BBHGPGBHMML(LJCFLDEONDG);
			this.JNONKGEGLID = LJCFLDEONDG;
		}
		else
		{
			this.JNONKGEGLID = (Quaternion)HCIJEDFCNOP.FIBMOBNIALK();
		}
	}

	// Token: 0x0600BB07 RID: 47879 RVA: 0x00441884 File Offset: 0x0043FA84
	public Quaternion NBHOLMCPBAE(Quaternion LJCFLDEONDG)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BB08 RID: 47880 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion CEPDDADCDCG()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BB09 RID: 47881 RVA: 0x004418F8 File Offset: 0x0043FAF8
	public Quaternion JEGCEPGNLFF(Quaternion LJCFLDEONDG)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BB0A RID: 47882 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion AGKPEIKIPJI()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BB0B RID: 47883 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion KHNGEMPHIAP()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BB0C RID: 47884 RVA: 0x0044196C File Offset: 0x0043FB6C
	public void DHCCMDLAJIO(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			HCIJEDFCNOP.CPIBABMPJLE(LJCFLDEONDG);
			this.JNONKGEGLID = LJCFLDEONDG;
		}
		else
		{
			this.JNONKGEGLID = (Quaternion)HCIJEDFCNOP.LNDLNKJPAGO();
		}
	}

	// Token: 0x0600BB0D RID: 47885 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion CEABHPLMEPO()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BB0E RID: 47886 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion AOLDNFKNMAP()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BB0F RID: 47887 RVA: 0x004419C0 File Offset: 0x0043FBC0
	public Quaternion GetRotation(Quaternion LJCFLDEONDG)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BB10 RID: 47888 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion MJAKBALLDGD()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BB11 RID: 47889 RVA: 0x00441A34 File Offset: 0x0043FC34
	public Quaternion AIKONMOBJOF(Quaternion LJCFLDEONDG)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BB12 RID: 47890 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion POGBNHOFEGA()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BB13 RID: 47891 RVA: 0x00441AA8 File Offset: 0x0043FCA8
	public Quaternion GKKBHDPOBFN(Quaternion LJCFLDEONDG)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BB14 RID: 47892 RVA: 0x00441B1C File Offset: 0x0043FD1C
	public void CNMIIGDELGE(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.CPIBABMPJLE(LJCFLDEONDG);
			this.JNONKGEGLID = LJCFLDEONDG;
		}
		else
		{
			this.JNONKGEGLID = (Quaternion)HCIJEDFCNOP.IDKHBJIHKEB();
		}
	}

	// Token: 0x0600BB15 RID: 47893 RVA: 0x00441B70 File Offset: 0x0043FD70
	public void JNENAPDBOKE(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			HCIJEDFCNOP.SendNext(LJCFLDEONDG);
			this.JNONKGEGLID = LJCFLDEONDG;
		}
		else
		{
			this.JNONKGEGLID = (Quaternion)HCIJEDFCNOP.KIMDMBDNICC();
		}
	}

	// Token: 0x0600BB16 RID: 47894 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion HODEBPDPNLN()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BB17 RID: 47895 RVA: 0x00441BC4 File Offset: 0x0043FDC4
	public void GBNDJBNLKLI(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.PBECMJMDHBI(LJCFLDEONDG);
			this.JNONKGEGLID = LJCFLDEONDG;
		}
		else
		{
			this.JNONKGEGLID = (Quaternion)HCIJEDFCNOP.LNDLNKJPAGO();
		}
	}

	// Token: 0x0600BB18 RID: 47896 RVA: 0x00441C18 File Offset: 0x0043FE18
	public Quaternion BMKBHDKEOHO(Quaternion LJCFLDEONDG)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BB19 RID: 47897 RVA: 0x00441C8C File Offset: 0x0043FE8C
	public Quaternion JIHNIHKFFBN(Quaternion LJCFLDEONDG)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BB1A RID: 47898 RVA: 0x00441D00 File Offset: 0x0043FF00
	public void HOGEJPIBJAL(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			HCIJEDFCNOP.PBECMJMDHBI(LJCFLDEONDG);
			this.JNONKGEGLID = LJCFLDEONDG;
		}
		else
		{
			this.JNONKGEGLID = (Quaternion)HCIJEDFCNOP.KIEJNJBDAJJ();
		}
	}

	// Token: 0x0600BB1B RID: 47899 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion JAOFDDCABEG()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BB1C RID: 47900 RVA: 0x00441D54 File Offset: 0x0043FF54
	public void JJGHNKLDANI(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			HCIJEDFCNOP.CPIBABMPJLE(LJCFLDEONDG);
			this.JNONKGEGLID = LJCFLDEONDG;
		}
		else
		{
			this.JNONKGEGLID = (Quaternion)HCIJEDFCNOP.LNDLNKJPAGO();
		}
	}

	// Token: 0x0600BB1D RID: 47901 RVA: 0x00441DA8 File Offset: 0x0043FFA8
	public void HHODOGMIJGI(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.isWriting)
		{
			HCIJEDFCNOP.PNAPNHJHBMN(LJCFLDEONDG);
			this.JNONKGEGLID = LJCFLDEONDG;
		}
		else
		{
			this.JNONKGEGLID = (Quaternion)HCIJEDFCNOP.KIMDMBDNICC();
		}
	}

	// Token: 0x0600BB1E RID: 47902 RVA: 0x00441DFA File Offset: 0x0043FFFA
	public PhotonTransformViewRotationControl(PhotonTransformViewRotationModel PMLNAMDEBFI)
	{
		this.HNCFAJJGIPN = PMLNAMDEBFI;
	}

	// Token: 0x0600BB1F RID: 47903 RVA: 0x00441E0C File Offset: 0x0044000C
	public void DCKLCCMEGAA(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			HCIJEDFCNOP.CPIBABMPJLE(LJCFLDEONDG);
			this.JNONKGEGLID = LJCFLDEONDG;
		}
		else
		{
			this.JNONKGEGLID = (Quaternion)HCIJEDFCNOP.HPPOACOIMOJ();
		}
	}

	// Token: 0x0600BB20 RID: 47904 RVA: 0x00441E60 File Offset: 0x00440060
	public void LBLAKDBHADA(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.GKJCHGIMOEJ())
		{
			HCIJEDFCNOP.PBECMJMDHBI(LJCFLDEONDG);
			this.JNONKGEGLID = LJCFLDEONDG;
		}
		else
		{
			this.JNONKGEGLID = (Quaternion)HCIJEDFCNOP.LNDLNKJPAGO();
		}
	}

	// Token: 0x0600BB21 RID: 47905 RVA: 0x00441EB4 File Offset: 0x004400B4
	public void HODGFKONIFC(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			HCIJEDFCNOP.IBCLJIACBKG(LJCFLDEONDG);
			this.JNONKGEGLID = LJCFLDEONDG;
		}
		else
		{
			this.JNONKGEGLID = (Quaternion)HCIJEDFCNOP.ReceiveNext();
		}
	}

	// Token: 0x0600BB22 RID: 47906 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion PGGPFBOADOB()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x0600BB23 RID: 47907 RVA: 0x00441F08 File Offset: 0x00440108
	public Quaternion OAKCMDFCILC(Quaternion LJCFLDEONDG)
	{
		switch (this.HNCFAJJGIPN.InterpolateOption)
		{
		default:
			return this.JNONKGEGLID;
		case PhotonTransformViewRotationModel.InterpolateOptions.RotateTowards:
			return Quaternion.RotateTowards(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateRotateTowardsSpeed * Time.deltaTime);
		case PhotonTransformViewRotationModel.InterpolateOptions.Lerp:
			return Quaternion.Lerp(LJCFLDEONDG, this.JNONKGEGLID, this.HNCFAJJGIPN.InterpolateLerpSpeed * Time.deltaTime);
		}
	}

	// Token: 0x0600BB24 RID: 47908 RVA: 0x00441F7C File Offset: 0x0044017C
	public void HDPOECGCALE(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.FAOJEFAMBFN())
		{
			HCIJEDFCNOP.PBECMJMDHBI(LJCFLDEONDG);
			this.JNONKGEGLID = LJCFLDEONDG;
		}
		else
		{
			this.JNONKGEGLID = (Quaternion)HCIJEDFCNOP.KIEJNJBDAJJ();
		}
	}

	// Token: 0x0600BB25 RID: 47909 RVA: 0x00441FD0 File Offset: 0x004401D0
	public void MKPBBAPGGND(Quaternion LJCFLDEONDG, PhotonStream HCIJEDFCNOP, PhotonMessageInfo DAGALCAILLN)
	{
		if (!this.HNCFAJJGIPN.SynchronizeEnabled)
		{
			return;
		}
		if (HCIJEDFCNOP.PGJIELMHMEJ())
		{
			HCIJEDFCNOP.OLACNHHHOEL(LJCFLDEONDG);
			this.JNONKGEGLID = LJCFLDEONDG;
		}
		else
		{
			this.JNONKGEGLID = (Quaternion)HCIJEDFCNOP.NLPFEFOCGBC();
		}
	}

	// Token: 0x0600BB26 RID: 47910 RVA: 0x0044113E File Offset: 0x0043F33E
	public Quaternion GFLGLDGIGLK()
	{
		return this.JNONKGEGLID;
	}

	// Token: 0x040015EE RID: 5614
	private PhotonTransformViewRotationModel HNCFAJJGIPN;

	// Token: 0x040015EF RID: 5615
	private Quaternion JNONKGEGLID;
}
