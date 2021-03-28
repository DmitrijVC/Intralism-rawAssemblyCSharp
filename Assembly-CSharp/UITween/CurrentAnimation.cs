using System;
using UnityEngine;
using UnityEngine.UI;

namespace UITween
{
	// Token: 0x02000235 RID: 565
	public class CurrentAnimation
	{
		// Token: 0x060088F7 RID: 35063 RVA: 0x00301214 File Offset: 0x002FF414
		public void EAKPPPIAADM(RectTransform IHOLCKOEPAP, float KLNKJOJDNHD)
		{
			float d = this.KGKJICCJBPL.Evaluate(KLNKJOJDNHD);
			Vector3 b = (this.HPNGOLFDOCA - this.BJBCNFEGJAJ) * d;
			IHOLCKOEPAP.localEulerAngles = this.BJBCNFEGJAJ + b;
		}

		// Token: 0x060088F8 RID: 35064 RVA: 0x00301258 File Offset: 0x002FF458
		public void EPPEGLCHMFA(AnimationCurve JEDNNDEGKMP, Vector3 AHBDCNGFLCN, Vector3 NKOEJNMCMDP)
		{
			this.JEDNNDEGKMP = JEDNNDEGKMP;
			this.AHBDCNGFLCN = AHBDCNGFLCN;
			this.NKOEJNMCMDP = NKOEJNMCMDP;
		}

		// Token: 0x060088F9 RID: 35065 RVA: 0x0030126F File Offset: 0x002FF46F
		public bool IsObjectOpened()
		{
			return this.PCADJGOKBJP.IsObjectOpened();
		}

		// Token: 0x060088FA RID: 35066 RVA: 0x0030127C File Offset: 0x002FF47C
		public void LJKBCBJGDOI(float OBLEOIJLPAF, float NDKFOAGEEPM)
		{
			this.OBLEOIJLPAF = OBLEOIJLPAF;
			this.NDKFOAGEEPM = NDKFOAGEEPM;
		}

		// Token: 0x060088FB RID: 35067 RVA: 0x0030128C File Offset: 0x002FF48C
		public void SetStatus(bool PIKFJDJLPJP)
		{
			this.PCADJGOKBJP.SetStatus(PIKFJDJLPJP);
		}

		// Token: 0x060088FC RID: 35068 RVA: 0x0030129C File Offset: 0x002FF49C
		public void GEAEBKOMEBF(Vector2 ELHCACPPCAG, Vector2 EKMHMLALGPF, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL, RectTransform KPEGABCNLKE)
		{
			this.PCADJGOKBJP.PositionPropetiesAnim.CDILEBLBPAN(true);
			this.PCADJGOKBJP.PositionPropetiesAnim.PADKKHAHDDC(ELHCACPPCAG, KPEGABCNLKE);
			this.PCADJGOKBJP.PositionPropetiesAnim.CNAJMCGHBKP(EKMHMLALGPF, KPEGABCNLKE.transform);
			this.PCADJGOKBJP.PositionPropetiesAnim.ABKCONADIIJ(CANHEAPDBPD, PMOODBJDOEL);
		}

		// Token: 0x060088FD RID: 35069 RVA: 0x00301302 File Offset: 0x002FF502
		public void AACJABEIENG(bool PIKFJDJLPJP)
		{
			this.PCADJGOKBJP.ICJELHJJCIM(PIKFJDJLPJP);
		}

		// Token: 0x060088FE RID: 35070 RVA: 0x00301310 File Offset: 0x002FF510
		public float EPDECNEHFKJ()
		{
			return this.PCADJGOKBJP.GetAnimationDuration();
		}

		// Token: 0x060088FF RID: 35071 RVA: 0x00301320 File Offset: 0x002FF520
		public void SetAnimationOnFrame(RectTransform KPEGABCNLKE, float IBHGINDCMIH)
		{
			if (this.PCADJGOKBJP.PositionPropetiesAnim.IsPositionEnabled())
			{
				this.MoveAnimation(KPEGABCNLKE, IBHGINDCMIH);
			}
			if (this.PCADJGOKBJP.RotationPropetiesAnim.IsRotationEnabled())
			{
				this.RotateAnimation(KPEGABCNLKE, IBHGINDCMIH);
			}
			if (this.PCADJGOKBJP.ScalePropetiesAnim.IsScaleEnabled())
			{
				this.ScaleAnimation(KPEGABCNLKE, IBHGINDCMIH);
			}
			if (this.PCADJGOKBJP.FadePropetiesAnim.IsFadeEnabled())
			{
				this.SetAlphaValue(KPEGABCNLKE.transform, IBHGINDCMIH);
			}
		}

		// Token: 0x06008900 RID: 35072 RVA: 0x003013A6 File Offset: 0x002FF5A6
		public float GBMMENODJHA()
		{
			return this.PCADJGOKBJP.IJEBHBDHGBP();
		}

		// Token: 0x06008901 RID: 35073 RVA: 0x00301310 File Offset: 0x002FF510
		public float GetAnimationDuration()
		{
			return this.PCADJGOKBJP.GetAnimationDuration();
		}

		// Token: 0x06008902 RID: 35074 RVA: 0x003013B3 File Offset: 0x002FF5B3
		public void DAHNFEPEECH(bool FOJONHLNAOM)
		{
			this.PCADJGOKBJP.FadePropetiesAnim.JBJAJLIDFHJ(false);
			this.PCADJGOKBJP.FadePropetiesAnim.HHPBKBKLFLD(FOJONHLNAOM);
		}

		// Token: 0x06008903 RID: 35075 RVA: 0x003013D7 File Offset: 0x002FF5D7
		public void SetFade(bool FOJONHLNAOM)
		{
			this.PCADJGOKBJP.FadePropetiesAnim.SetFadeEnable(true);
			this.PCADJGOKBJP.FadePropetiesAnim.SetFadeOverride(FOJONHLNAOM);
		}

		// Token: 0x06008904 RID: 35076 RVA: 0x003013FC File Offset: 0x002FF5FC
		public void FIMOKAPKPDN(RectTransform IHOLCKOEPAP, float KLNKJOJDNHD)
		{
			float d = this.EKCEHPFHNEF.Evaluate(KLNKJOJDNHD);
			Vector3 b = (this.BAMODAFMADK - this.EKINBNMHFBO) * d;
			IHOLCKOEPAP.localScale = this.EKINBNMHFBO + b;
		}

		// Token: 0x06008905 RID: 35077 RVA: 0x00301440 File Offset: 0x002FF640
		public void EPJPMHFOOPK(RectTransform KPEGABCNLKE)
		{
			if (this.AMNFMICDFKN == CurrentAnimation.NBGCCDNIKGC.AWAKE)
			{
				return;
			}
			if (this.BHPKDGNECJG <= 1136f)
			{
				float num = (!this.PCADJGOKBJP.UnscaledTimeAnimation) ? Time.deltaTime : Time.unscaledDeltaTime;
				this.BHPKDGNECJG += num / this.PCADJGOKBJP.IJEBHBDHGBP();
			}
			else if (this.AMNFMICDFKN != CurrentAnimation.NBGCCDNIKGC.AWAKE)
			{
				this.IPMFEFBJCOM(KPEGABCNLKE, 942f);
				if (this.AMNFMICDFKN != CurrentAnimation.NBGCCDNIKGC.READY && this.AMNFMICDFKN != CurrentAnimation.NBGCCDNIKGC.AWAKE && this.PCADJGOKBJP.AtomicAnimation)
				{
					this.PCADJGOKBJP.KAFCIMNMOAP();
					this.AMNFMICDFKN = CurrentAnimation.NBGCCDNIKGC.ENDED;
				}
				else
				{
					this.PCADJGOKBJP.MEHKKGGEFLC();
					this.AMNFMICDFKN = CurrentAnimation.NBGCCDNIKGC.ENDED;
				}
			}
			if (this.BHPKDGNECJG > 1333f && !this.PCADJGOKBJP.AtomicAnimation && this.AMNFMICDFKN != (CurrentAnimation.NBGCCDNIKGC)6 && this.AMNFMICDFKN != CurrentAnimation.NBGCCDNIKGC.COUNT)
			{
				this.PCADJGOKBJP.OOJIPGAPIDD();
				this.AMNFMICDFKN = CurrentAnimation.NBGCCDNIKGC.FINALENDED;
			}
			this.PCADJGOKBJP.KGKNKIJANNN();
		}

		// Token: 0x06008906 RID: 35078 RVA: 0x00301566 File Offset: 0x002FF766
		public bool BHLLCIEJILN()
		{
			return this.PCADJGOKBJP.IMLMEJJMKJI();
		}

		// Token: 0x06008907 RID: 35079 RVA: 0x00301573 File Offset: 0x002FF773
		public void KLMNEMDBOOI(bool PIKFJDJLPJP)
		{
			this.PCADJGOKBJP.MIAHBIKLKCC(PIKFJDJLPJP);
		}

		// Token: 0x06008908 RID: 35080 RVA: 0x00301258 File Offset: 0x002FF458
		public void BGDNKODGKKK(AnimationCurve JEDNNDEGKMP, Vector3 AHBDCNGFLCN, Vector3 NKOEJNMCMDP)
		{
			this.JEDNNDEGKMP = JEDNNDEGKMP;
			this.AHBDCNGFLCN = AHBDCNGFLCN;
			this.NKOEJNMCMDP = NKOEJNMCMDP;
		}

		// Token: 0x06008909 RID: 35081 RVA: 0x00301584 File Offset: 0x002FF784
		public void NMCBOBBDHME(RectTransform IHOLCKOEPAP, float KLNKJOJDNHD)
		{
			float d = this.EKCEHPFHNEF.Evaluate(KLNKJOJDNHD);
			Vector3 b = (this.BAMODAFMADK - this.EKINBNMHFBO) * d;
			IHOLCKOEPAP.localScale = this.EKINBNMHFBO + b;
		}

		// Token: 0x0600890A RID: 35082 RVA: 0x003015C8 File Offset: 0x002FF7C8
		public void KOOJPKAOPML()
		{
			if (this.PCADJGOKBJP.PositionPropetiesAnim.HCKADBPDEJL())
			{
				this.BGIIMKADKBF(this.PCADJGOKBJP.PositionPropetiesAnim.TweenCurveExitPos, this.PCADJGOKBJP.PositionPropetiesAnim.EndPos, this.PCADJGOKBJP.PositionPropetiesAnim.StartPos);
			}
			if (this.PCADJGOKBJP.RotationPropetiesAnim.AHHOBPAKCGM())
			{
				this.SetCurrentAnimRot(this.PCADJGOKBJP.RotationPropetiesAnim.TweenCurveExitRot, this.PCADJGOKBJP.RotationPropetiesAnim.EndRot, this.PCADJGOKBJP.RotationPropetiesAnim.StartRot);
			}
			if (this.PCADJGOKBJP.ScalePropetiesAnim.IsScaleEnabled())
			{
				this.SetCurrentAnimScale(this.PCADJGOKBJP.ScalePropetiesAnim.TweenCurveExitScale, this.PCADJGOKBJP.ScalePropetiesAnim.EndScale, this.PCADJGOKBJP.ScalePropetiesAnim.StartScale);
			}
			if (this.PCADJGOKBJP.FadePropetiesAnim.GHHNMLNGHAG())
			{
				this.LJKBCBJGDOI(this.PCADJGOKBJP.FadePropetiesAnim.KDLHHNEGNNI(), this.PCADJGOKBJP.FadePropetiesAnim.AMFOCHNJKND());
			}
			this.BHPKDGNECJG = 55f;
			this.AMNFMICDFKN = CurrentAnimation.NBGCCDNIKGC.AWAKE;
			this.PCADJGOKBJP.EIKDOOMIJFG();
			this.PCADJGOKBJP.POJCKALIPOM();
		}

		// Token: 0x0600890B RID: 35083 RVA: 0x0030171C File Offset: 0x002FF91C
		public void ScaleAnimation(RectTransform IHOLCKOEPAP, float KLNKJOJDNHD)
		{
			float d = this.EKCEHPFHNEF.Evaluate(KLNKJOJDNHD);
			Vector3 b = (this.BAMODAFMADK - this.EKINBNMHFBO) * d;
			IHOLCKOEPAP.localScale = this.EKINBNMHFBO + b;
		}

		// Token: 0x0600890C RID: 35084 RVA: 0x00301573 File Offset: 0x002FF773
		public void EMHCAMAACII(bool PIKFJDJLPJP)
		{
			this.PCADJGOKBJP.MIAHBIKLKCC(PIKFJDJLPJP);
		}

		// Token: 0x0600890D RID: 35085 RVA: 0x00301760 File Offset: 0x002FF960
		public void OKHHGLDKFMI(float OBLEOIJLPAF, float NDKFOAGEEPM)
		{
			this.PCADJGOKBJP.FadePropetiesAnim.NHBFIDBHPAH(OBLEOIJLPAF, NDKFOAGEEPM);
		}

		// Token: 0x0600890E RID: 35086 RVA: 0x00301774 File Offset: 0x002FF974
		public bool JFOHIAKFPIO()
		{
			return this.PCADJGOKBJP.CNKKMDJFOIM();
		}

		// Token: 0x0600890F RID: 35087 RVA: 0x00301784 File Offset: 0x002FF984
		public void PlayCloseAnimations()
		{
			if (this.PCADJGOKBJP.PositionPropetiesAnim.IsPositionEnabled())
			{
				this.SetCurrentAnimPos(this.PCADJGOKBJP.PositionPropetiesAnim.TweenCurveExitPos, this.PCADJGOKBJP.PositionPropetiesAnim.EndPos, this.PCADJGOKBJP.PositionPropetiesAnim.StartPos);
			}
			if (this.PCADJGOKBJP.RotationPropetiesAnim.IsRotationEnabled())
			{
				this.SetCurrentAnimRot(this.PCADJGOKBJP.RotationPropetiesAnim.TweenCurveExitRot, this.PCADJGOKBJP.RotationPropetiesAnim.EndRot, this.PCADJGOKBJP.RotationPropetiesAnim.StartRot);
			}
			if (this.PCADJGOKBJP.ScalePropetiesAnim.IsScaleEnabled())
			{
				this.SetCurrentAnimScale(this.PCADJGOKBJP.ScalePropetiesAnim.TweenCurveExitScale, this.PCADJGOKBJP.ScalePropetiesAnim.EndScale, this.PCADJGOKBJP.ScalePropetiesAnim.StartScale);
			}
			if (this.PCADJGOKBJP.FadePropetiesAnim.IsFadeEnabled())
			{
				this.SetFadeAnimation(this.PCADJGOKBJP.FadePropetiesAnim.GetEndFadeValue(), this.PCADJGOKBJP.FadePropetiesAnim.GetStartFadeValue());
			}
			this.BHPKDGNECJG = 0f;
			this.AMNFMICDFKN = CurrentAnimation.NBGCCDNIKGC.READY;
			this.PCADJGOKBJP.ChangeStatus();
			this.PCADJGOKBJP.CheckCallbackStatus();
		}

		// Token: 0x06008910 RID: 35088 RVA: 0x003018D8 File Offset: 0x002FFAD8
		public void IKFCLBAOCBF(RectTransform IHOLCKOEPAP, float KLNKJOJDNHD)
		{
			float d = this.EKCEHPFHNEF.Evaluate(KLNKJOJDNHD);
			Vector3 b = (this.BAMODAFMADK - this.EKINBNMHFBO) * d;
			IHOLCKOEPAP.localScale = this.EKINBNMHFBO + b;
		}

		// Token: 0x06008911 RID: 35089 RVA: 0x0030191C File Offset: 0x002FFB1C
		public float NIOGAHLFMAL()
		{
			return this.PCADJGOKBJP.PDHDEAHHJFC();
		}

		// Token: 0x06008912 RID: 35090 RVA: 0x0030192C File Offset: 0x002FFB2C
		public void BPIMHILGOMG()
		{
			if (this.PCADJGOKBJP.PositionPropetiesAnim.CNDKLMFLOLM())
			{
				this.SetCurrentAnimPos(this.PCADJGOKBJP.PositionPropetiesAnim.TweenCurveEnterPos, this.PCADJGOKBJP.PositionPropetiesAnim.StartPos, this.PCADJGOKBJP.PositionPropetiesAnim.EndPos);
			}
			if (this.PCADJGOKBJP.RotationPropetiesAnim.OGOFLPEPJKE())
			{
				this.AEOBCMOHMKP(this.PCADJGOKBJP.RotationPropetiesAnim.TweenCurveEnterRot, this.PCADJGOKBJP.RotationPropetiesAnim.StartRot, this.PCADJGOKBJP.RotationPropetiesAnim.EndRot);
			}
			if (this.PCADJGOKBJP.ScalePropetiesAnim.EPGCCFOGBBL())
			{
				this.IPFPAMFFJHO(this.PCADJGOKBJP.ScalePropetiesAnim.TweenCurveEnterScale, this.PCADJGOKBJP.ScalePropetiesAnim.StartScale, this.PCADJGOKBJP.ScalePropetiesAnim.EndScale);
			}
			if (this.PCADJGOKBJP.FadePropetiesAnim.LMLELJKFLCD())
			{
				this.LJKBCBJGDOI(this.PCADJGOKBJP.FadePropetiesAnim.MCEDLAHLDHD(), this.PCADJGOKBJP.FadePropetiesAnim.HAAAGHMKLHI());
			}
			this.BHPKDGNECJG = 280f;
			this.AMNFMICDFKN = CurrentAnimation.NBGCCDNIKGC.READY;
			this.PCADJGOKBJP.PBJCCANOAJB();
			this.PCADJGOKBJP.CPPNPGIOMJH();
		}

		// Token: 0x06008913 RID: 35091 RVA: 0x00301A80 File Offset: 0x002FFC80
		public void LGBCEGGCJMK(RectTransform KPEGABCNLKE)
		{
			if (this.AMNFMICDFKN == CurrentAnimation.NBGCCDNIKGC.AWAKE)
			{
				return;
			}
			if (this.BHPKDGNECJG <= 871f)
			{
				float num = (!this.PCADJGOKBJP.UnscaledTimeAnimation) ? Time.deltaTime : Time.unscaledDeltaTime;
				this.BHPKDGNECJG += num / this.PCADJGOKBJP.APKDJAOKFBN();
			}
			else if (this.AMNFMICDFKN != CurrentAnimation.NBGCCDNIKGC.READY)
			{
				this.SetAnimationOnFrame(KPEGABCNLKE, 1374f);
				if (this.AMNFMICDFKN != CurrentAnimation.NBGCCDNIKGC.AWAKE && this.AMNFMICDFKN != (CurrentAnimation.NBGCCDNIKGC)6 && this.PCADJGOKBJP.AtomicAnimation)
				{
					this.PCADJGOKBJP.OOJIPGAPIDD();
					this.AMNFMICDFKN = CurrentAnimation.NBGCCDNIKGC.AWAKE;
				}
				else
				{
					this.PCADJGOKBJP.KIHLGFANBEC();
					this.AMNFMICDFKN = CurrentAnimation.NBGCCDNIKGC.AWAKE;
				}
			}
			if (this.BHPKDGNECJG > 1817f && !this.PCADJGOKBJP.AtomicAnimation && this.AMNFMICDFKN != (CurrentAnimation.NBGCCDNIKGC)8 && this.AMNFMICDFKN != (CurrentAnimation.NBGCCDNIKGC)7)
			{
				this.PCADJGOKBJP.NCGDHPOGJAH();
				this.AMNFMICDFKN = CurrentAnimation.NBGCCDNIKGC.ENDED;
			}
			this.PCADJGOKBJP.EPGBEJPAPLJ();
		}

		// Token: 0x06008914 RID: 35092 RVA: 0x00301BA8 File Offset: 0x002FFDA8
		public void SetAnimationScale(Vector2 IJJDBKINBJG, Vector2 DBEPMPMLAFO, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
		{
			this.PCADJGOKBJP.ScalePropetiesAnim.StartScale = IJJDBKINBJG;
			this.PCADJGOKBJP.ScalePropetiesAnim.SetScaleEnable(true);
			this.PCADJGOKBJP.ScalePropetiesAnim.EndScale = DBEPMPMLAFO;
			this.PCADJGOKBJP.ScalePropetiesAnim.SetAniamtionsCurve(CANHEAPDBPD, PMOODBJDOEL);
		}

		// Token: 0x06008915 RID: 35093 RVA: 0x00301C05 File Offset: 0x002FFE05
		public void CBJAIEBKIIF(AnimationCurve KGKJICCJBPL, Vector3 BJBCNFEGJAJ, Vector3 HPNGOLFDOCA)
		{
			this.KGKJICCJBPL = KGKJICCJBPL;
			this.BJBCNFEGJAJ = BJBCNFEGJAJ;
			this.HPNGOLFDOCA = HPNGOLFDOCA;
		}

		// Token: 0x06008916 RID: 35094 RVA: 0x00301C1C File Offset: 0x002FFE1C
		public void MFKLABJCGMG(Vector2 OPDFCFOCGPC, Vector2 KCLMKFKHMGC, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
		{
			this.PCADJGOKBJP.RotationPropetiesAnim.MKBKDCBCJEG(false);
			this.PCADJGOKBJP.RotationPropetiesAnim.StartRot = OPDFCFOCGPC;
			this.PCADJGOKBJP.RotationPropetiesAnim.EndRot = KCLMKFKHMGC;
			this.PCADJGOKBJP.RotationPropetiesAnim.SetAniamtionsCurve(CANHEAPDBPD, PMOODBJDOEL);
		}

		// Token: 0x06008917 RID: 35095 RVA: 0x00301C7C File Offset: 0x002FFE7C
		public void SetAnimationPos(Vector2 ELHCACPPCAG, Vector2 EKMHMLALGPF, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL, RectTransform KPEGABCNLKE)
		{
			this.PCADJGOKBJP.PositionPropetiesAnim.SetPositionEnable(true);
			this.PCADJGOKBJP.PositionPropetiesAnim.SetPosStart(ELHCACPPCAG, KPEGABCNLKE);
			this.PCADJGOKBJP.PositionPropetiesAnim.SetPosEnd(EKMHMLALGPF, KPEGABCNLKE.transform);
			this.PCADJGOKBJP.PositionPropetiesAnim.SetAniamtionsCurve(CANHEAPDBPD, PMOODBJDOEL);
		}

		// Token: 0x06008918 RID: 35096 RVA: 0x00301CE4 File Offset: 0x002FFEE4
		public void LateAnimationFrame(RectTransform KPEGABCNLKE)
		{
			if (this.AMNFMICDFKN == CurrentAnimation.NBGCCDNIKGC.AWAKE)
			{
				return;
			}
			if (this.BHPKDGNECJG <= 1f)
			{
				float num = (!this.PCADJGOKBJP.UnscaledTimeAnimation) ? Time.deltaTime : Time.unscaledDeltaTime;
				this.BHPKDGNECJG += num / this.PCADJGOKBJP.GetAnimationDuration();
			}
			else if (this.AMNFMICDFKN != CurrentAnimation.NBGCCDNIKGC.FINALENDED)
			{
				this.SetAnimationOnFrame(KPEGABCNLKE, 1f);
				if (this.AMNFMICDFKN != CurrentAnimation.NBGCCDNIKGC.ENDED && this.AMNFMICDFKN != CurrentAnimation.NBGCCDNIKGC.FINALENDED && this.PCADJGOKBJP.AtomicAnimation)
				{
					this.PCADJGOKBJP.Ended();
					this.AMNFMICDFKN = CurrentAnimation.NBGCCDNIKGC.ENDED;
				}
				else
				{
					this.PCADJGOKBJP.FinalEnd();
					this.AMNFMICDFKN = CurrentAnimation.NBGCCDNIKGC.FINALENDED;
				}
			}
			if (this.BHPKDGNECJG > 0.9f && !this.PCADJGOKBJP.AtomicAnimation && this.AMNFMICDFKN != CurrentAnimation.NBGCCDNIKGC.ENDED && this.AMNFMICDFKN != CurrentAnimation.NBGCCDNIKGC.FINALENDED)
			{
				this.PCADJGOKBJP.Ended();
				this.AMNFMICDFKN = CurrentAnimation.NBGCCDNIKGC.ENDED;
			}
			this.PCADJGOKBJP.FrameCheck();
		}

		// Token: 0x06008919 RID: 35097 RVA: 0x00301E0C File Offset: 0x0030000C
		public void AEEGKAONKIC(RectTransform IHOLCKOEPAP, float KLNKJOJDNHD)
		{
			float d = this.EKCEHPFHNEF.Evaluate(KLNKJOJDNHD);
			Vector3 b = (this.BAMODAFMADK - this.EKINBNMHFBO) * d;
			IHOLCKOEPAP.localScale = this.EKINBNMHFBO + b;
		}

		// Token: 0x0600891A RID: 35098 RVA: 0x00301E50 File Offset: 0x00300050
		public void MoveAnimation(RectTransform IHOLCKOEPAP, float KLNKJOJDNHD)
		{
			float d = this.JEDNNDEGKMP.Evaluate(KLNKJOJDNHD);
			Vector3 b = (this.NKOEJNMCMDP - this.AHBDCNGFLCN) * d;
			IHOLCKOEPAP.anchoredPosition = this.AHBDCNGFLCN + b;
		}

		// Token: 0x0600891B RID: 35099 RVA: 0x00301E9C File Offset: 0x0030009C
		public void LCCOGNDJPID(RectTransform IHOLCKOEPAP, float KLNKJOJDNHD)
		{
			float d = this.KGKJICCJBPL.Evaluate(KLNKJOJDNHD);
			Vector3 b = (this.HPNGOLFDOCA - this.BJBCNFEGJAJ) * d;
			IHOLCKOEPAP.localEulerAngles = this.BJBCNFEGJAJ + b;
		}

		// Token: 0x0600891C RID: 35100 RVA: 0x00301EE0 File Offset: 0x003000E0
		public void IPFPAMFFJHO(AnimationCurve EKCEHPFHNEF, Vector3 EKINBNMHFBO, Vector3 BAMODAFMADK)
		{
			this.EKCEHPFHNEF = EKCEHPFHNEF;
			this.EKINBNMHFBO = EKINBNMHFBO;
			this.BAMODAFMADK = BAMODAFMADK;
		}

		// Token: 0x0600891D RID: 35101 RVA: 0x00301EF7 File Offset: 0x003000F7
		public void SetAniamtioDuration(float HNIFGMOMJMA)
		{
			this.PCADJGOKBJP.SetAniamtioDuration(HNIFGMOMJMA);
		}

		// Token: 0x0600891E RID: 35102 RVA: 0x00301F08 File Offset: 0x00300108
		public void ECMBKPFMPEG(RectTransform KPEGABCNLKE)
		{
			if (this.AMNFMICDFKN == CurrentAnimation.NBGCCDNIKGC.AWAKE)
			{
				return;
			}
			if (this.BHPKDGNECJG <= 1738f)
			{
				float num = (!this.PCADJGOKBJP.UnscaledTimeAnimation) ? Time.deltaTime : Time.unscaledDeltaTime;
				this.BHPKDGNECJG += num / this.PCADJGOKBJP.CAFBPENKBPG();
			}
			else if (this.AMNFMICDFKN != CurrentAnimation.NBGCCDNIKGC.ENDED)
			{
				this.SetAnimationOnFrame(KPEGABCNLKE, 1101f);
				if (this.AMNFMICDFKN != CurrentAnimation.NBGCCDNIKGC.READY && this.AMNFMICDFKN != (CurrentAnimation.NBGCCDNIKGC)7 && this.PCADJGOKBJP.AtomicAnimation)
				{
					this.PCADJGOKBJP.MIDCBEPFGCL();
					this.AMNFMICDFKN = (CurrentAnimation.NBGCCDNIKGC)6;
				}
				else
				{
					this.PCADJGOKBJP.LAKEFKPNIKL();
					this.AMNFMICDFKN = CurrentAnimation.NBGCCDNIKGC.AWAKE;
				}
			}
			if (this.BHPKDGNECJG > 220f && !this.PCADJGOKBJP.AtomicAnimation && this.AMNFMICDFKN != (CurrentAnimation.NBGCCDNIKGC)6 && this.AMNFMICDFKN != CurrentAnimation.NBGCCDNIKGC.AWAKE)
			{
				this.PCADJGOKBJP.KAFCIMNMOAP();
				this.AMNFMICDFKN = (CurrentAnimation.NBGCCDNIKGC)8;
			}
			this.PCADJGOKBJP.OIAHJHFJFJG();
		}

		// Token: 0x0600891F RID: 35103 RVA: 0x00302030 File Offset: 0x00300230
		public void RotateAnimation(RectTransform IHOLCKOEPAP, float KLNKJOJDNHD)
		{
			float d = this.KGKJICCJBPL.Evaluate(KLNKJOJDNHD);
			Vector3 b = (this.HPNGOLFDOCA - this.BJBCNFEGJAJ) * d;
			IHOLCKOEPAP.localEulerAngles = this.BJBCNFEGJAJ + b;
		}

		// Token: 0x06008920 RID: 35104 RVA: 0x00302074 File Offset: 0x00300274
		public void OPOBNAEDEKM(Transform CKHPAFICAFF, float KLNKJOJDNHD)
		{
			if (CKHPAFICAFF.GetComponent<MaskableGraphic>())
			{
				MaskableGraphic component = CKHPAFICAFF.GetComponent<MaskableGraphic>();
				Color color = component.color;
				KLNKJOJDNHD = Mathf.Clamp(KLNKJOJDNHD, 423f, 589f);
				color.a = Mathf.Abs(this.OBLEOIJLPAF + (this.NDKFOAGEEPM - this.OBLEOIJLPAF) * KLNKJOJDNHD);
				component.color = color;
			}
			if (CKHPAFICAFF.childCount > 1)
			{
				for (int i = 1; i < CKHPAFICAFF.childCount; i += 0)
				{
					Transform child = CKHPAFICAFF.GetChild(i);
					if (child.gameObject.activeSelf && (!child.GetComponent<ReferencedFrom>() || this.PCADJGOKBJP.FadePropetiesAnim.FPJMEKNOJJJ()))
					{
						this.SetAlphaValue(child, KLNKJOJDNHD);
					}
				}
			}
		}

		// Token: 0x06008921 RID: 35105 RVA: 0x00302142 File Offset: 0x00300342
		public bool LANBHCFLMGC()
		{
			return this.PCADJGOKBJP.CICJOFKMNGC();
		}

		// Token: 0x06008922 RID: 35106 RVA: 0x00301258 File Offset: 0x002FF458
		public void IGPBNMGJHCP(AnimationCurve JEDNNDEGKMP, Vector3 AHBDCNGFLCN, Vector3 NKOEJNMCMDP)
		{
			this.JEDNNDEGKMP = JEDNNDEGKMP;
			this.AHBDCNGFLCN = AHBDCNGFLCN;
			this.NKOEJNMCMDP = NKOEJNMCMDP;
		}

		// Token: 0x06008923 RID: 35107 RVA: 0x00302150 File Offset: 0x00300350
		public void APGPGLFFFKF(RectTransform KPEGABCNLKE)
		{
			if (this.AMNFMICDFKN == CurrentAnimation.NBGCCDNIKGC.AWAKE)
			{
				return;
			}
			if (this.BHPKDGNECJG <= 1408f)
			{
				float num = (!this.PCADJGOKBJP.UnscaledTimeAnimation) ? Time.deltaTime : Time.unscaledDeltaTime;
				this.BHPKDGNECJG += num / this.PCADJGOKBJP.KFHGNKPGLPM();
			}
			else if (this.AMNFMICDFKN != (CurrentAnimation.NBGCCDNIKGC)6)
			{
				this.IPMFEFBJCOM(KPEGABCNLKE, 1635f);
				if (this.AMNFMICDFKN != CurrentAnimation.NBGCCDNIKGC.COUNT && this.AMNFMICDFKN != CurrentAnimation.NBGCCDNIKGC.COUNT && this.PCADJGOKBJP.AtomicAnimation)
				{
					this.PCADJGOKBJP.KAFCIMNMOAP();
					this.AMNFMICDFKN = CurrentAnimation.NBGCCDNIKGC.READY;
				}
				else
				{
					this.PCADJGOKBJP.LFGHKFGEPFD();
					this.AMNFMICDFKN = (CurrentAnimation.NBGCCDNIKGC)6;
				}
			}
			if (this.BHPKDGNECJG > 556f && !this.PCADJGOKBJP.AtomicAnimation && this.AMNFMICDFKN != (CurrentAnimation.NBGCCDNIKGC)6 && this.AMNFMICDFKN != CurrentAnimation.NBGCCDNIKGC.READY)
			{
				this.PCADJGOKBJP.Ended();
				this.AMNFMICDFKN = CurrentAnimation.NBGCCDNIKGC.FINALENDED;
			}
			this.PCADJGOKBJP.JFIGKODILLH();
		}

		// Token: 0x06008924 RID: 35108 RVA: 0x00301774 File Offset: 0x002FF974
		public bool FPOJNHMKIDD()
		{
			return this.PCADJGOKBJP.CNKKMDJFOIM();
		}

		// Token: 0x06008925 RID: 35109 RVA: 0x00302278 File Offset: 0x00300478
		public void KGHKFJMDLOL(Vector2 OPDFCFOCGPC, Vector2 KCLMKFKHMGC, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
		{
			this.PCADJGOKBJP.RotationPropetiesAnim.SetRotationEnable(false);
			this.PCADJGOKBJP.RotationPropetiesAnim.StartRot = OPDFCFOCGPC;
			this.PCADJGOKBJP.RotationPropetiesAnim.EndRot = KCLMKFKHMGC;
			this.PCADJGOKBJP.RotationPropetiesAnim.EDHLGBAHNED(CANHEAPDBPD, PMOODBJDOEL);
		}

		// Token: 0x06008926 RID: 35110 RVA: 0x00301258 File Offset: 0x002FF458
		public void HOOFEAFNKPE(AnimationCurve JEDNNDEGKMP, Vector3 AHBDCNGFLCN, Vector3 NKOEJNMCMDP)
		{
			this.JEDNNDEGKMP = JEDNNDEGKMP;
			this.AHBDCNGFLCN = AHBDCNGFLCN;
			this.NKOEJNMCMDP = NKOEJNMCMDP;
		}

		// Token: 0x06008927 RID: 35111 RVA: 0x003022D8 File Offset: 0x003004D8
		public void CAOABPKLBCI(RectTransform KPEGABCNLKE)
		{
			if (this.AMNFMICDFKN == CurrentAnimation.NBGCCDNIKGC.AWAKE)
			{
				return;
			}
			if (this.BHPKDGNECJG <= 1649f)
			{
				float num = (!this.PCADJGOKBJP.UnscaledTimeAnimation) ? Time.deltaTime : Time.unscaledDeltaTime;
				this.BHPKDGNECJG += num / this.PCADJGOKBJP.JGKNNELGNKB();
			}
			else if (this.AMNFMICDFKN != CurrentAnimation.NBGCCDNIKGC.AWAKE)
			{
				this.IPMFEFBJCOM(KPEGABCNLKE, 158f);
				if (this.AMNFMICDFKN != (CurrentAnimation.NBGCCDNIKGC)6 && this.AMNFMICDFKN != CurrentAnimation.NBGCCDNIKGC.START && this.PCADJGOKBJP.AtomicAnimation)
				{
					this.PCADJGOKBJP.KAFCIMNMOAP();
					this.AMNFMICDFKN = CurrentAnimation.NBGCCDNIKGC.READY;
				}
				else
				{
					this.PCADJGOKBJP.FGELFDFKOJN();
					this.AMNFMICDFKN = (CurrentAnimation.NBGCCDNIKGC)6;
				}
			}
			if (this.BHPKDGNECJG > 1119f && !this.PCADJGOKBJP.AtomicAnimation && this.AMNFMICDFKN != CurrentAnimation.NBGCCDNIKGC.START && this.AMNFMICDFKN != CurrentAnimation.NBGCCDNIKGC.READY)
			{
				this.PCADJGOKBJP.OOJIPGAPIDD();
				this.AMNFMICDFKN = CurrentAnimation.NBGCCDNIKGC.ENDED;
			}
			this.PCADJGOKBJP.GCEPHGDEHIB();
		}

		// Token: 0x06008928 RID: 35112 RVA: 0x003023FE File Offset: 0x003005FE
		public void BFKJPGNMEJM(RectTransform KPEGABCNLKE)
		{
			if (this.AMNFMICDFKN == CurrentAnimation.NBGCCDNIKGC.AWAKE)
			{
				return;
			}
			if (this.BHPKDGNECJG <= 1681f)
			{
				this.IPMFEFBJCOM(KPEGABCNLKE, this.BHPKDGNECJG);
			}
		}

		// Token: 0x06008929 RID: 35113 RVA: 0x00301774 File Offset: 0x002FF974
		public bool JEEOGEPFINA()
		{
			return this.PCADJGOKBJP.CNKKMDJFOIM();
		}

		// Token: 0x0600892A RID: 35114 RVA: 0x0030242C File Offset: 0x0030062C
		public void HGDHJPGKDFG(Vector2 ELHCACPPCAG, Vector2 EKMHMLALGPF, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL, RectTransform KPEGABCNLKE)
		{
			this.PCADJGOKBJP.PositionPropetiesAnim.KHLGMBKJKIK(true);
			this.PCADJGOKBJP.PositionPropetiesAnim.PADKKHAHDDC(ELHCACPPCAG, KPEGABCNLKE);
			this.PCADJGOKBJP.PositionPropetiesAnim.CNAJMCGHBKP(EKMHMLALGPF, KPEGABCNLKE.transform);
			this.PCADJGOKBJP.PositionPropetiesAnim.ANIAAOPMOIE(CANHEAPDBPD, PMOODBJDOEL);
		}

		// Token: 0x0600892B RID: 35115 RVA: 0x00301C05 File Offset: 0x002FFE05
		public void SetCurrentAnimRot(AnimationCurve KGKJICCJBPL, Vector3 BJBCNFEGJAJ, Vector3 HPNGOLFDOCA)
		{
			this.KGKJICCJBPL = KGKJICCJBPL;
			this.BJBCNFEGJAJ = BJBCNFEGJAJ;
			this.HPNGOLFDOCA = HPNGOLFDOCA;
		}

		// Token: 0x0600892C RID: 35116 RVA: 0x0030128C File Offset: 0x002FF48C
		public void IEPOJAMAJAK(bool PIKFJDJLPJP)
		{
			this.PCADJGOKBJP.SetStatus(PIKFJDJLPJP);
		}

		// Token: 0x0600892D RID: 35117 RVA: 0x00302492 File Offset: 0x00300692
		public void KKIFBHEOLHE(float OBLEOIJLPAF, float NDKFOAGEEPM)
		{
			this.PCADJGOKBJP.FadePropetiesAnim.PDENHDPOABN(OBLEOIJLPAF, NDKFOAGEEPM);
		}

		// Token: 0x0600892E RID: 35118 RVA: 0x003024A8 File Offset: 0x003006A8
		public void PlayOpenAnimations()
		{
			if (this.PCADJGOKBJP.PositionPropetiesAnim.IsPositionEnabled())
			{
				this.SetCurrentAnimPos(this.PCADJGOKBJP.PositionPropetiesAnim.TweenCurveEnterPos, this.PCADJGOKBJP.PositionPropetiesAnim.StartPos, this.PCADJGOKBJP.PositionPropetiesAnim.EndPos);
			}
			if (this.PCADJGOKBJP.RotationPropetiesAnim.IsRotationEnabled())
			{
				this.SetCurrentAnimRot(this.PCADJGOKBJP.RotationPropetiesAnim.TweenCurveEnterRot, this.PCADJGOKBJP.RotationPropetiesAnim.StartRot, this.PCADJGOKBJP.RotationPropetiesAnim.EndRot);
			}
			if (this.PCADJGOKBJP.ScalePropetiesAnim.IsScaleEnabled())
			{
				this.SetCurrentAnimScale(this.PCADJGOKBJP.ScalePropetiesAnim.TweenCurveEnterScale, this.PCADJGOKBJP.ScalePropetiesAnim.StartScale, this.PCADJGOKBJP.ScalePropetiesAnim.EndScale);
			}
			if (this.PCADJGOKBJP.FadePropetiesAnim.IsFadeEnabled())
			{
				this.SetFadeAnimation(this.PCADJGOKBJP.FadePropetiesAnim.GetStartFadeValue(), this.PCADJGOKBJP.FadePropetiesAnim.GetEndFadeValue());
			}
			this.BHPKDGNECJG = 0f;
			this.AMNFMICDFKN = CurrentAnimation.NBGCCDNIKGC.READY;
			this.PCADJGOKBJP.ChangeStatus();
			this.PCADJGOKBJP.CheckCallbackStatus();
		}

		// Token: 0x0600892F RID: 35119 RVA: 0x003025FC File Offset: 0x003007FC
		public void CPPPMFEHBHD(Vector2 OPDFCFOCGPC, Vector2 KCLMKFKHMGC, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
		{
			this.PCADJGOKBJP.RotationPropetiesAnim.BFNEDLGKOHB(false);
			this.PCADJGOKBJP.RotationPropetiesAnim.StartRot = OPDFCFOCGPC;
			this.PCADJGOKBJP.RotationPropetiesAnim.EndRot = KCLMKFKHMGC;
			this.PCADJGOKBJP.RotationPropetiesAnim.LJPCBONKEOF(CANHEAPDBPD, PMOODBJDOEL);
		}

		// Token: 0x06008930 RID: 35120 RVA: 0x0030265C File Offset: 0x0030085C
		public void SetAnimationRotation(Vector2 OPDFCFOCGPC, Vector2 KCLMKFKHMGC, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
		{
			this.PCADJGOKBJP.RotationPropetiesAnim.SetRotationEnable(true);
			this.PCADJGOKBJP.RotationPropetiesAnim.StartRot = OPDFCFOCGPC;
			this.PCADJGOKBJP.RotationPropetiesAnim.EndRot = KCLMKFKHMGC;
			this.PCADJGOKBJP.RotationPropetiesAnim.SetAniamtionsCurve(CANHEAPDBPD, PMOODBJDOEL);
		}

		// Token: 0x06008931 RID: 35121 RVA: 0x003026B9 File Offset: 0x003008B9
		public void SetFadeValuesStartEnd(float OBLEOIJLPAF, float NDKFOAGEEPM)
		{
			this.PCADJGOKBJP.FadePropetiesAnim.SetFadeValues(OBLEOIJLPAF, NDKFOAGEEPM);
		}

		// Token: 0x06008932 RID: 35122 RVA: 0x003026D0 File Offset: 0x003008D0
		public void DCIJAAFBNAL(Vector2 IJJDBKINBJG, Vector2 DBEPMPMLAFO, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
		{
			this.PCADJGOKBJP.ScalePropetiesAnim.StartScale = IJJDBKINBJG;
			this.PCADJGOKBJP.ScalePropetiesAnim.SetScaleEnable(false);
			this.PCADJGOKBJP.ScalePropetiesAnim.EndScale = DBEPMPMLAFO;
			this.PCADJGOKBJP.ScalePropetiesAnim.KOBMGMOGODB(CANHEAPDBPD, PMOODBJDOEL);
		}

		// Token: 0x06008933 RID: 35123 RVA: 0x00302730 File Offset: 0x00300930
		public void DKJPNDGBDDP(RectTransform KPEGABCNLKE)
		{
			if (this.AMNFMICDFKN == CurrentAnimation.NBGCCDNIKGC.AWAKE)
			{
				return;
			}
			if (this.BHPKDGNECJG <= 1213f)
			{
				float num = (!this.PCADJGOKBJP.UnscaledTimeAnimation) ? Time.deltaTime : Time.unscaledDeltaTime;
				this.BHPKDGNECJG += num / this.PCADJGOKBJP.AKPEAFOOMDP();
			}
			else if (this.AMNFMICDFKN != CurrentAnimation.NBGCCDNIKGC.COUNT)
			{
				this.SetAnimationOnFrame(KPEGABCNLKE, 1385f);
				if (this.AMNFMICDFKN != CurrentAnimation.NBGCCDNIKGC.START && this.AMNFMICDFKN != CurrentAnimation.NBGCCDNIKGC.COUNT && this.PCADJGOKBJP.AtomicAnimation)
				{
					this.PCADJGOKBJP.HKPAOADBGNM();
					this.AMNFMICDFKN = CurrentAnimation.NBGCCDNIKGC.ENDED;
				}
				else
				{
					this.PCADJGOKBJP.LEBNFCBFDAM();
					this.AMNFMICDFKN = (CurrentAnimation.NBGCCDNIKGC)7;
				}
			}
			if (this.BHPKDGNECJG > 806f && !this.PCADJGOKBJP.AtomicAnimation && this.AMNFMICDFKN != CurrentAnimation.NBGCCDNIKGC.COUNT && this.AMNFMICDFKN != (CurrentAnimation.NBGCCDNIKGC)7)
			{
				this.PCADJGOKBJP.KAFCIMNMOAP();
				this.AMNFMICDFKN = CurrentAnimation.NBGCCDNIKGC.COUNT;
			}
			this.PCADJGOKBJP.HCOEADEMFCP();
		}

		// Token: 0x06008934 RID: 35124 RVA: 0x00302858 File Offset: 0x00300A58
		public void IPMFEFBJCOM(RectTransform KPEGABCNLKE, float IBHGINDCMIH)
		{
			if (this.PCADJGOKBJP.PositionPropetiesAnim.JFOGEAHNEOP())
			{
				this.MoveAnimation(KPEGABCNLKE, IBHGINDCMIH);
			}
			if (this.PCADJGOKBJP.RotationPropetiesAnim.AHHOBPAKCGM())
			{
				this.RotateAnimation(KPEGABCNLKE, IBHGINDCMIH);
			}
			if (this.PCADJGOKBJP.ScalePropetiesAnim.AKCJAKKHOHA())
			{
				this.IKFCLBAOCBF(KPEGABCNLKE, IBHGINDCMIH);
			}
			if (this.PCADJGOKBJP.FadePropetiesAnim.IsFadeEnabled())
			{
				this.SetAlphaValue(KPEGABCNLKE.transform, IBHGINDCMIH);
			}
		}

		// Token: 0x06008935 RID: 35125 RVA: 0x00301C05 File Offset: 0x002FFE05
		public void AEOBCMOHMKP(AnimationCurve KGKJICCJBPL, Vector3 BJBCNFEGJAJ, Vector3 HPNGOLFDOCA)
		{
			this.KGKJICCJBPL = KGKJICCJBPL;
			this.BJBCNFEGJAJ = BJBCNFEGJAJ;
			this.HPNGOLFDOCA = HPNGOLFDOCA;
		}

		// Token: 0x06008936 RID: 35126 RVA: 0x0030127C File Offset: 0x002FF47C
		public void SetFadeAnimation(float OBLEOIJLPAF, float NDKFOAGEEPM)
		{
			this.OBLEOIJLPAF = OBLEOIJLPAF;
			this.NDKFOAGEEPM = NDKFOAGEEPM;
		}

		// Token: 0x06008937 RID: 35127 RVA: 0x003028E0 File Offset: 0x00300AE0
		public void SetAlphaValue(Transform CKHPAFICAFF, float KLNKJOJDNHD)
		{
			if (CKHPAFICAFF.GetComponent<MaskableGraphic>())
			{
				MaskableGraphic component = CKHPAFICAFF.GetComponent<MaskableGraphic>();
				Color color = component.color;
				KLNKJOJDNHD = Mathf.Clamp(KLNKJOJDNHD, 0f, 1f);
				color.a = Mathf.Abs(this.OBLEOIJLPAF + (this.NDKFOAGEEPM - this.OBLEOIJLPAF) * KLNKJOJDNHD);
				component.color = color;
			}
			if (CKHPAFICAFF.childCount > 0)
			{
				for (int i = 0; i < CKHPAFICAFF.childCount; i++)
				{
					Transform child = CKHPAFICAFF.GetChild(i);
					if (child.gameObject.activeSelf && (!child.GetComponent<ReferencedFrom>() || this.PCADJGOKBJP.FadePropetiesAnim.IsFadeOverrideEnabled()))
					{
						this.SetAlphaValue(child, KLNKJOJDNHD);
					}
				}
			}
		}

		// Token: 0x06008938 RID: 35128 RVA: 0x003029B0 File Offset: 0x00300BB0
		public void KOHALFIIIAO(RectTransform IHOLCKOEPAP, float KLNKJOJDNHD)
		{
			float d = this.KGKJICCJBPL.Evaluate(KLNKJOJDNHD);
			Vector3 b = (this.HPNGOLFDOCA - this.BJBCNFEGJAJ) * d;
			IHOLCKOEPAP.localEulerAngles = this.BJBCNFEGJAJ + b;
		}

		// Token: 0x06008939 RID: 35129 RVA: 0x003029F4 File Offset: 0x00300BF4
		public void EKGIOAKFGBB(RectTransform IHOLCKOEPAP, float KLNKJOJDNHD)
		{
			float d = this.EKCEHPFHNEF.Evaluate(KLNKJOJDNHD);
			Vector3 b = (this.BAMODAFMADK - this.EKINBNMHFBO) * d;
			IHOLCKOEPAP.localScale = this.EKINBNMHFBO + b;
		}

		// Token: 0x0600893A RID: 35130 RVA: 0x00302A38 File Offset: 0x00300C38
		public void AnimationFrame(RectTransform KPEGABCNLKE)
		{
			if (this.AMNFMICDFKN == CurrentAnimation.NBGCCDNIKGC.AWAKE)
			{
				return;
			}
			if (this.BHPKDGNECJG <= 1f)
			{
				this.SetAnimationOnFrame(KPEGABCNLKE, this.BHPKDGNECJG);
			}
		}

		// Token: 0x0600893B RID: 35131 RVA: 0x00301258 File Offset: 0x002FF458
		public void SetCurrentAnimPos(AnimationCurve JEDNNDEGKMP, Vector3 AHBDCNGFLCN, Vector3 NKOEJNMCMDP)
		{
			this.JEDNNDEGKMP = JEDNNDEGKMP;
			this.AHBDCNGFLCN = AHBDCNGFLCN;
			this.NKOEJNMCMDP = NKOEJNMCMDP;
		}

		// Token: 0x0600893C RID: 35132 RVA: 0x00302A63 File Offset: 0x00300C63
		public CurrentAnimation(AnimationParts PCADJGOKBJP)
		{
			this.PCADJGOKBJP = PCADJGOKBJP;
		}

		// Token: 0x0600893D RID: 35133 RVA: 0x00301258 File Offset: 0x002FF458
		public void BGIIMKADKBF(AnimationCurve JEDNNDEGKMP, Vector3 AHBDCNGFLCN, Vector3 NKOEJNMCMDP)
		{
			this.JEDNNDEGKMP = JEDNNDEGKMP;
			this.AHBDCNGFLCN = AHBDCNGFLCN;
			this.NKOEJNMCMDP = NKOEJNMCMDP;
		}

		// Token: 0x0600893E RID: 35134 RVA: 0x00302A80 File Offset: 0x00300C80
		public void DNCFJNKAOGB(RectTransform IHOLCKOEPAP, float KLNKJOJDNHD)
		{
			float d = this.EKCEHPFHNEF.Evaluate(KLNKJOJDNHD);
			Vector3 b = (this.BAMODAFMADK - this.EKINBNMHFBO) * d;
			IHOLCKOEPAP.localScale = this.EKINBNMHFBO + b;
		}

		// Token: 0x0600893F RID: 35135 RVA: 0x00301EE0 File Offset: 0x003000E0
		public void SetCurrentAnimScale(AnimationCurve EKCEHPFHNEF, Vector3 EKINBNMHFBO, Vector3 BAMODAFMADK)
		{
			this.EKCEHPFHNEF = EKCEHPFHNEF;
			this.EKINBNMHFBO = EKINBNMHFBO;
			this.BAMODAFMADK = BAMODAFMADK;
		}

		// Token: 0x06008940 RID: 35136 RVA: 0x00302AC4 File Offset: 0x00300CC4
		public void AFDGGGAPDMJ(bool FOJONHLNAOM)
		{
			this.PCADJGOKBJP.FadePropetiesAnim.DOCCGPMNNAI(false);
			this.PCADJGOKBJP.FadePropetiesAnim.OOEGCADHANF(FOJONHLNAOM);
		}

		// Token: 0x06008941 RID: 35137 RVA: 0x00302AE8 File Offset: 0x00300CE8
		public void CANEIOLKKOI()
		{
			if (this.PCADJGOKBJP.PositionPropetiesAnim.FADPIMDKPAF())
			{
				this.IGPBNMGJHCP(this.PCADJGOKBJP.PositionPropetiesAnim.TweenCurveExitPos, this.PCADJGOKBJP.PositionPropetiesAnim.EndPos, this.PCADJGOKBJP.PositionPropetiesAnim.StartPos);
			}
			if (this.PCADJGOKBJP.RotationPropetiesAnim.LOHIOBFEFHK())
			{
				this.AEOBCMOHMKP(this.PCADJGOKBJP.RotationPropetiesAnim.TweenCurveExitRot, this.PCADJGOKBJP.RotationPropetiesAnim.EndRot, this.PCADJGOKBJP.RotationPropetiesAnim.StartRot);
			}
			if (this.PCADJGOKBJP.ScalePropetiesAnim.DDJPEGJMLJF())
			{
				this.IPFPAMFFJHO(this.PCADJGOKBJP.ScalePropetiesAnim.TweenCurveExitScale, this.PCADJGOKBJP.ScalePropetiesAnim.EndScale, this.PCADJGOKBJP.ScalePropetiesAnim.StartScale);
			}
			if (this.PCADJGOKBJP.FadePropetiesAnim.NEOJNMAHFEF())
			{
				this.LJKBCBJGDOI(this.PCADJGOKBJP.FadePropetiesAnim.IHGDCIDMPON(), this.PCADJGOKBJP.FadePropetiesAnim.MFJJHLPHHJK());
			}
			this.BHPKDGNECJG = 1351f;
			this.AMNFMICDFKN = CurrentAnimation.NBGCCDNIKGC.AWAKE;
			this.PCADJGOKBJP.ChangeStatus();
			this.PCADJGOKBJP.CGGOOGIFCHB();
		}

		// Token: 0x06008942 RID: 35138 RVA: 0x00301258 File Offset: 0x002FF458
		public void BANAJPCCHLG(AnimationCurve JEDNNDEGKMP, Vector3 AHBDCNGFLCN, Vector3 NKOEJNMCMDP)
		{
			this.JEDNNDEGKMP = JEDNNDEGKMP;
			this.AHBDCNGFLCN = AHBDCNGFLCN;
			this.NKOEJNMCMDP = NKOEJNMCMDP;
		}

		// Token: 0x04000FD0 RID: 4048
		private AnimationParts PCADJGOKBJP;

		// Token: 0x04000FD1 RID: 4049
		private float BHPKDGNECJG = 2f;

		// Token: 0x04000FD2 RID: 4050
		private CurrentAnimation.NBGCCDNIKGC AMNFMICDFKN;

		// Token: 0x04000FD3 RID: 4051
		private AnimationCurve JEDNNDEGKMP;

		// Token: 0x04000FD4 RID: 4052
		private Vector3 AHBDCNGFLCN;

		// Token: 0x04000FD5 RID: 4053
		private Vector3 NKOEJNMCMDP;

		// Token: 0x04000FD6 RID: 4054
		private AnimationCurve EKCEHPFHNEF;

		// Token: 0x04000FD7 RID: 4055
		private Vector3 EKINBNMHFBO;

		// Token: 0x04000FD8 RID: 4056
		private Vector3 BAMODAFMADK;

		// Token: 0x04000FD9 RID: 4057
		private AnimationCurve KGKJICCJBPL;

		// Token: 0x04000FDA RID: 4058
		private Vector3 BJBCNFEGJAJ;

		// Token: 0x04000FDB RID: 4059
		private Vector3 HPNGOLFDOCA;

		// Token: 0x04000FDC RID: 4060
		private float OBLEOIJLPAF;

		// Token: 0x04000FDD RID: 4061
		private float NDKFOAGEEPM;

		// Token: 0x02000236 RID: 566
		private enum NBGCCDNIKGC
		{
			// Token: 0x04000FDF RID: 4063
			AWAKE,
			// Token: 0x04000FE0 RID: 4064
			READY,
			// Token: 0x04000FE1 RID: 4065
			START,
			// Token: 0x04000FE2 RID: 4066
			ENDED,
			// Token: 0x04000FE3 RID: 4067
			FINALENDED,
			// Token: 0x04000FE4 RID: 4068
			COUNT
		}
	}
}
