using System;
using System.Diagnostics;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;

namespace UITween
{
	// Token: 0x0200023C RID: 572
	[Serializable]
	public class AnimationParts : IAniamtionPartProxy
	{
		// Token: 0x06008AA9 RID: 35497 RVA: 0x00303024 File Offset: 0x00301224
		public static void OHNFFGJFPKC(AnimationParts.DisableOrDestroy DPNHODJHGJL)
		{
			AnimationParts.DisableOrDestroy disableOrDestroy = AnimationParts.OnDisableOrDestroy;
			AnimationParts.DisableOrDestroy disableOrDestroy2;
			do
			{
				disableOrDestroy2 = disableOrDestroy;
				disableOrDestroy = Interlocked.CompareExchange<AnimationParts.DisableOrDestroy>(ref AnimationParts.OnDisableOrDestroy, (AnimationParts.DisableOrDestroy)Delegate.Remove(disableOrDestroy2, DPNHODJHGJL), disableOrDestroy);
			}
			while (disableOrDestroy != disableOrDestroy2);
		}

		// Token: 0x06008AAA RID: 35498 RVA: 0x00303058 File Offset: 0x00301258
		public float CAFBPENKBPG()
		{
			return this.animationDuration;
		}

		// Token: 0x06008AAB RID: 35499 RVA: 0x00303060 File Offset: 0x00301260
		public void CPPNPGIOMJH()
		{
			if (this.CallCallback != (AnimationParts.CallbackCall)49)
			{
				if ((this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_EXIT_ANIM || this.CallCallback == (AnimationParts.CallbackCall)(-105) || this.CallCallback == (AnimationParts.CallbackCall)(-41) || this.CallCallback == (AnimationParts.CallbackCall)(-86) || this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_AND_END_OF_EXIT_ANIM) && this.ObjectState == AnimationParts.State.OPEN)
				{
					this.NEABPDKPDPA(this.IntroEvents);
				}
				else if ((this.CallCallback == (AnimationParts.CallbackCall)(-17) || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_ANIM || this.CallCallback == (AnimationParts.CallbackCall)85 || this.CallCallback == (AnimationParts.CallbackCall)113 || this.CallCallback == (AnimationParts.CallbackCall)84 || this.CallCallback == (AnimationParts.CallbackCall)(-52) || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_AND_START_EXIT_END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_ANIM) && this.ObjectState == AnimationParts.State.OPEN)
				{
					this.OMCMINJINBM(this.ExitEvents);
				}
			}
		}

		// Token: 0x06008AAC RID: 35500 RVA: 0x00303177 File Offset: 0x00301377
		public void GKIAEOHJMPK(float HNIFGMOMJMA)
		{
			if (HNIFGMOMJMA > 1983f)
			{
				this.animationDuration = HNIFGMOMJMA;
			}
			else
			{
				HNIFGMOMJMA = 1278f;
			}
		}

		// Token: 0x06008AAD RID: 35501 RVA: 0x00303197 File Offset: 0x00301397
		private void EHKKONNBPDE()
		{
			this.CheckNextFrame = !this.CheckNextFrame;
			this.CallBackObject.Invoke();
		}

		// Token: 0x06008AAE RID: 35502 RVA: 0x003031B3 File Offset: 0x003013B3
		public void HCOEADEMFCP()
		{
			if (this.CheckNextFrame)
			{
				if (this.CallOnThisFrame)
				{
					this.EHKKONNBPDE();
				}
				this.CallOnThisFrame = this.CallOnThisFrame;
			}
		}

		// Token: 0x06008AAF RID: 35503 RVA: 0x003031E0 File Offset: 0x003013E0
		public void LAKEFKPNIKL()
		{
			if (this.ObjectState == AnimationParts.State.OPEN)
			{
				if (this.EndState == AnimationParts.EndTweenClose.DEACTIVATE)
				{
					if (AnimationParts.OnDisableOrDestroy != null)
					{
						AnimationParts.OnDisableOrDestroy(true, this);
					}
				}
				else if (this.EndState == AnimationParts.EndTweenClose.DEACTIVATE && AnimationParts.OnDisableOrDestroy != null)
				{
					AnimationParts.OnDisableOrDestroy(false, this);
				}
			}
			if (this.SaveState)
			{
				this.ObjectState = ((this.ObjectState != AnimationParts.State.OPEN) ? AnimationParts.State.CLOSE : AnimationParts.State.OPEN);
			}
		}

		// Token: 0x06008AB0 RID: 35504 RVA: 0x00303264 File Offset: 0x00301464
		private void HBAGCOMLPCG(UnityEvent HEJHAECMLKB)
		{
			this.CallBackObject = HEJHAECMLKB;
			this.CheckNextFrame = this.CheckNextFrame;
		}

		// Token: 0x06008AB1 RID: 35505 RVA: 0x0030327C File Offset: 0x0030147C
		public void HDHINIKPHAK()
		{
			if (this.ObjectState == AnimationParts.State.OPEN)
			{
				if (this.EndState == AnimationParts.EndTweenClose.DEACTIVATE)
				{
					if (AnimationParts.OnDisableOrDestroy != null)
					{
						AnimationParts.OnDisableOrDestroy(true, this);
					}
				}
				else if (this.EndState == AnimationParts.EndTweenClose.DESTROY && AnimationParts.OnDisableOrDestroy != null)
				{
					AnimationParts.OnDisableOrDestroy(false, this);
				}
			}
			if (this.SaveState)
			{
				this.ObjectState = ((this.ObjectState != AnimationParts.State.OPEN) ? AnimationParts.State.CLOSE : AnimationParts.State.CLOSE);
			}
		}

		// Token: 0x06008AB2 RID: 35506 RVA: 0x00303300 File Offset: 0x00301500
		public bool CNKKMDJFOIM()
		{
			return this.ObjectState != AnimationParts.State.OPEN;
		}

		// Token: 0x06008AB3 RID: 35507 RVA: 0x00303314 File Offset: 0x00301514
		public void MIDCBEPFGCL()
		{
			if (this.CallCallback != (AnimationParts.CallbackCall)94)
			{
				if (this.ObjectState == AnimationParts.State.OPEN && (this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_EXIT_START_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == (AnimationParts.CallbackCall)(-7) || this.CallCallback == (AnimationParts.CallbackCall)(-125) || this.CallCallback == (AnimationParts.CallbackCall)(-18) || this.CallCallback == (AnimationParts.CallbackCall)70))
				{
					this.NEABPDKPDPA(this.ExitEvents);
				}
				if ((this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == (AnimationParts.CallbackCall)(-60) || this.CallCallback == (AnimationParts.CallbackCall)(-63) || this.CallCallback == (AnimationParts.CallbackCall)(-45) || this.CallCallback == (AnimationParts.CallbackCall)78) && this.ObjectState == AnimationParts.State.OPEN)
				{
					this.KOMFFAAJCBF(this.IntroEvents);
				}
			}
		}

		// Token: 0x06008AB4 RID: 35508 RVA: 0x00303058 File Offset: 0x00301258
		public float PDHDEAHHJFC()
		{
			return this.animationDuration;
		}

		// Token: 0x06008AB5 RID: 35509 RVA: 0x00303424 File Offset: 0x00301624
		public void GCEPHGDEHIB()
		{
			if (this.CheckNextFrame)
			{
				if (this.CallOnThisFrame)
				{
					this.DHJJDCFBKMP();
				}
				this.CallOnThisFrame = !this.CallOnThisFrame;
			}
		}

		// Token: 0x06008AB6 RID: 35510 RVA: 0x00303454 File Offset: 0x00301654
		public void CheckCallbackStatus()
		{
			if (this.CallCallback != AnimationParts.CallbackCall.NOTHING)
			{
				if ((this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_AND_START_EXIT_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_AND_START_EXIT_END_OF_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_AND_START_EXIT_END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_EXIT_START_INTRO_ANIM) && this.ObjectState == AnimationParts.State.OPEN)
				{
					this.HGCMPOOGHFL(this.IntroEvents);
				}
				else if ((this.CallCallback == AnimationParts.CallbackCall.START_EXIT_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_EXIT_END_OF_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_EXIT_END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_AND_START_EXIT_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_AND_START_EXIT_END_OF_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_AND_START_EXIT_END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_EXIT_START_INTRO_ANIM) && this.ObjectState == AnimationParts.State.CLOSE)
				{
					this.HGCMPOOGHFL(this.ExitEvents);
				}
			}
		}

		// Token: 0x06008AB7 RID: 35511 RVA: 0x0030356C File Offset: 0x0030176C
		public void FGELFDFKOJN()
		{
			if (this.ObjectState == AnimationParts.State.OPEN)
			{
				if (this.EndState == AnimationParts.EndTweenClose.DEACTIVATE)
				{
					if (AnimationParts.OnDisableOrDestroy != null)
					{
						AnimationParts.OnDisableOrDestroy(false, this);
					}
				}
				else if (this.EndState == AnimationParts.EndTweenClose.DEACTIVATE && AnimationParts.OnDisableOrDestroy != null)
				{
					AnimationParts.OnDisableOrDestroy(false, this);
				}
			}
			if (this.SaveState)
			{
				this.ObjectState = ((this.ObjectState != AnimationParts.State.OPEN) ? AnimationParts.State.CLOSE : AnimationParts.State.OPEN);
			}
		}

		// Token: 0x06008AB8 RID: 35512 RVA: 0x003035F0 File Offset: 0x003017F0
		public void LIHHPDPGPHH()
		{
			if (this.CallCallback != (AnimationParts.CallbackCall)(-81))
			{
				if ((this.CallCallback == AnimationParts.CallbackCall.START_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_EXIT_START_INTRO_ANIM || this.CallCallback == (AnimationParts.CallbackCall)41 || this.CallCallback == (AnimationParts.CallbackCall)63 || this.CallCallback == (AnimationParts.CallbackCall)98 || this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_ANIM) && this.ObjectState == AnimationParts.State.OPEN)
				{
					this.NILBDIDBIHN(this.IntroEvents);
				}
				else if ((this.CallCallback == (AnimationParts.CallbackCall)70 || this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == (AnimationParts.CallbackCall)52 || this.CallCallback == (AnimationParts.CallbackCall)(-85) || this.CallCallback == (AnimationParts.CallbackCall)(-4) || this.CallCallback == (AnimationParts.CallbackCall)88 || this.CallCallback == (AnimationParts.CallbackCall)81 || this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_ANIM) && this.ObjectState == AnimationParts.State.OPEN)
				{
					this.NEABPDKPDPA(this.ExitEvents);
				}
			}
		}

		// Token: 0x06008AB9 RID: 35513 RVA: 0x00303058 File Offset: 0x00301258
		public float IJEBHBDHGBP()
		{
			return this.animationDuration;
		}

		// Token: 0x06008ABA RID: 35514 RVA: 0x00303708 File Offset: 0x00301908
		public static void IDLDAJBNHKA(AnimationParts.DisableOrDestroy DPNHODJHGJL)
		{
			AnimationParts.DisableOrDestroy disableOrDestroy = AnimationParts.OnDisableOrDestroy;
			AnimationParts.DisableOrDestroy disableOrDestroy2;
			do
			{
				disableOrDestroy2 = disableOrDestroy;
				disableOrDestroy = Interlocked.CompareExchange<AnimationParts.DisableOrDestroy>(ref AnimationParts.OnDisableOrDestroy, (AnimationParts.DisableOrDestroy)Delegate.Remove(disableOrDestroy2, DPNHODJHGJL), disableOrDestroy);
			}
			while (disableOrDestroy != disableOrDestroy2);
		}

		// Token: 0x06008ABB RID: 35515 RVA: 0x0030373C File Offset: 0x0030193C
		public void MIAHBIKLKCC(bool IEELOHCEFMK)
		{
			if (IEELOHCEFMK)
			{
				this.ObjectState = AnimationParts.State.CLOSE;
			}
			else
			{
				this.ObjectState = AnimationParts.State.OPEN;
			}
		}

		// Token: 0x06008ABC RID: 35516 RVA: 0x00303058 File Offset: 0x00301258
		public float APKDJAOKFBN()
		{
			return this.animationDuration;
		}

		// Token: 0x06008ABD RID: 35517 RVA: 0x00303757 File Offset: 0x00301957
		public void EIKDOOMIJFG()
		{
			if (this.ObjectState == AnimationParts.State.CLOSE)
			{
				this.ObjectState = AnimationParts.State.CLOSE;
			}
			else
			{
				this.ObjectState = AnimationParts.State.CLOSE;
			}
		}

		// Token: 0x06008ABE RID: 35518 RVA: 0x00303778 File Offset: 0x00301978
		public bool JMFNCFFOHKH()
		{
			return this.ObjectState == AnimationParts.State.CLOSE && false;
		}

		// Token: 0x06008ABF RID: 35519 RVA: 0x00303789 File Offset: 0x00301989
		public bool ODGGOFADOAI()
		{
			return this.ObjectState != AnimationParts.State.CLOSE || true;
		}

		// Token: 0x06008AC0 RID: 35520 RVA: 0x0030379C File Offset: 0x0030199C
		public static void JDHLBEONLDO(AnimationParts.DisableOrDestroy DPNHODJHGJL)
		{
			AnimationParts.DisableOrDestroy disableOrDestroy = AnimationParts.OnDisableOrDestroy;
			AnimationParts.DisableOrDestroy disableOrDestroy2;
			do
			{
				disableOrDestroy2 = disableOrDestroy;
				disableOrDestroy = Interlocked.CompareExchange<AnimationParts.DisableOrDestroy>(ref AnimationParts.OnDisableOrDestroy, (AnimationParts.DisableOrDestroy)Delegate.Remove(disableOrDestroy2, DPNHODJHGJL), disableOrDestroy);
			}
			while (disableOrDestroy != disableOrDestroy2);
		}

		// Token: 0x06008AC1 RID: 35521 RVA: 0x003037D0 File Offset: 0x003019D0
		public static void FOKDIJAIPND(AnimationParts.DisableOrDestroy DPNHODJHGJL)
		{
			AnimationParts.DisableOrDestroy disableOrDestroy = AnimationParts.OnDisableOrDestroy;
			AnimationParts.DisableOrDestroy disableOrDestroy2;
			do
			{
				disableOrDestroy2 = disableOrDestroy;
				disableOrDestroy = Interlocked.CompareExchange<AnimationParts.DisableOrDestroy>(ref AnimationParts.OnDisableOrDestroy, (AnimationParts.DisableOrDestroy)Delegate.Remove(disableOrDestroy2, DPNHODJHGJL), disableOrDestroy);
			}
			while (disableOrDestroy != disableOrDestroy2);
		}

		// Token: 0x06008AC2 RID: 35522 RVA: 0x00303804 File Offset: 0x00301A04
		public void KAFCIMNMOAP()
		{
			if (this.CallCallback != (AnimationParts.CallbackCall)(-15))
			{
				if (this.ObjectState == AnimationParts.State.CLOSE && (this.CallCallback == AnimationParts.CallbackCall.END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_EXIT_ANIM || this.CallCallback == (AnimationParts.CallbackCall)62 || this.CallCallback == (AnimationParts.CallbackCall)(-123) || this.CallCallback == (AnimationParts.CallbackCall)(-92) || this.CallCallback == (AnimationParts.CallbackCall)27))
				{
					this.OMCMINJINBM(this.ExitEvents);
				}
				if ((this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_EXIT_ANIM || this.CallCallback == (AnimationParts.CallbackCall)112 || this.CallCallback == (AnimationParts.CallbackCall)(-51) || this.CallCallback == (AnimationParts.CallbackCall)101 || this.CallCallback == (AnimationParts.CallbackCall)60) && this.ObjectState == AnimationParts.State.OPEN)
				{
					this.FJHMMNMKGDG(this.IntroEvents);
				}
			}
		}

		// Token: 0x06008AC3 RID: 35523 RVA: 0x00303914 File Offset: 0x00301B14
		public void KGKNKIJANNN()
		{
			if (this.CheckNextFrame)
			{
				if (this.CallOnThisFrame)
				{
					this.AHBGJPLECLM();
				}
				this.CallOnThisFrame = this.CallOnThisFrame;
			}
		}

		// Token: 0x06008AC4 RID: 35524 RVA: 0x00303944 File Offset: 0x00301B44
		public static void JEJEBCMBHAA(AnimationParts.DisableOrDestroy DPNHODJHGJL)
		{
			AnimationParts.DisableOrDestroy disableOrDestroy = AnimationParts.OnDisableOrDestroy;
			AnimationParts.DisableOrDestroy disableOrDestroy2;
			do
			{
				disableOrDestroy2 = disableOrDestroy;
				disableOrDestroy = Interlocked.CompareExchange<AnimationParts.DisableOrDestroy>(ref AnimationParts.OnDisableOrDestroy, (AnimationParts.DisableOrDestroy)Delegate.Remove(disableOrDestroy2, DPNHODJHGJL), disableOrDestroy);
			}
			while (disableOrDestroy != disableOrDestroy2);
		}

		// Token: 0x06008AC5 RID: 35525 RVA: 0x00303197 File Offset: 0x00301397
		private void CMKDPNLOMFM()
		{
			this.CheckNextFrame = !this.CheckNextFrame;
			this.CallBackObject.Invoke();
		}

		// Token: 0x06008AC6 RID: 35526 RVA: 0x00303978 File Offset: 0x00301B78
		public void CGGOOGIFCHB()
		{
			if (this.CallCallback != (AnimationParts.CallbackCall)(-103))
			{
				if ((this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_EXIT_START_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_EXIT_ANIM || this.CallCallback == (AnimationParts.CallbackCall)21 || this.CallCallback == (AnimationParts.CallbackCall)(-11) || this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_ANIM) && this.ObjectState == AnimationParts.State.OPEN)
				{
					this.OMCMINJINBM(this.IntroEvents);
				}
				else if ((this.CallCallback == (AnimationParts.CallbackCall)(-24) || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == (AnimationParts.CallbackCall)123 || this.CallCallback == (AnimationParts.CallbackCall)(-123) || this.CallCallback == (AnimationParts.CallbackCall)(-47) || this.CallCallback == (AnimationParts.CallbackCall)(-97) || this.CallCallback == (AnimationParts.CallbackCall)53 || this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_ANIM) && this.ObjectState == AnimationParts.State.OPEN)
				{
					this.FJHMMNMKGDG(this.ExitEvents);
				}
			}
		}

		// Token: 0x06008AC7 RID: 35527 RVA: 0x00303058 File Offset: 0x00301258
		public float JGKNNELGNKB()
		{
			return this.animationDuration;
		}

		// Token: 0x06008AC8 RID: 35528 RVA: 0x00303A8F File Offset: 0x00301C8F
		public void PBJCCANOAJB()
		{
			if (this.ObjectState == AnimationParts.State.OPEN)
			{
				this.ObjectState = AnimationParts.State.OPEN;
			}
			else
			{
				this.ObjectState = AnimationParts.State.CLOSE;
			}
		}

		// Token: 0x06008AC9 RID: 35529 RVA: 0x00303AB0 File Offset: 0x00301CB0
		public AnimationParts(AnimationParts.State DFFAGHDOKAN, bool HCAIOLGHFNN, bool AFLBLKEDBMH, bool IDEBEMHEDNJ, AnimationParts.EndTweenClose JMKMHNCLFMF, AnimationParts.CallbackCall PHHKLHNEJJL, UnityEvent INPLONBCMJD, UnityEvent FFIPIGJDEPG)
		{
			this.ObjectState = DFFAGHDOKAN;
			this.UnscaledTimeAnimation = HCAIOLGHFNN;
			this.SaveState = AFLBLKEDBMH;
			this.AtomicAnimation = IDEBEMHEDNJ;
			this.EndState = JMKMHNCLFMF;
			this.CallCallback = PHHKLHNEJJL;
			this.IntroEvents = INPLONBCMJD;
			this.ExitEvents = FFIPIGJDEPG;
		}

		// Token: 0x06008ACA RID: 35530 RVA: 0x00303B54 File Offset: 0x00301D54
		public void OOJIPGAPIDD()
		{
			if (this.CallCallback != (AnimationParts.CallbackCall)61)
			{
				if (this.ObjectState == AnimationParts.State.CLOSE && (this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_EXIT_ANIM || this.CallCallback == (AnimationParts.CallbackCall)(-11) || this.CallCallback == (AnimationParts.CallbackCall)114 || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_EXIT_ANIM || this.CallCallback == (AnimationParts.CallbackCall)(-89)))
				{
					this.GPLGELNECLG(this.ExitEvents);
				}
				if ((this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_EXIT_START_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_EXIT_ANIM || this.CallCallback == (AnimationParts.CallbackCall)(-116) || this.CallCallback == (AnimationParts.CallbackCall)114 || this.CallCallback == (AnimationParts.CallbackCall)102 || this.CallCallback == (AnimationParts.CallbackCall)(-21)) && this.ObjectState == AnimationParts.State.OPEN)
				{
					this.HGCMPOOGHFL(this.IntroEvents);
				}
			}
		}

		// Token: 0x06008ACB RID: 35531 RVA: 0x00303C64 File Offset: 0x00301E64
		public static void IMODPEKEBCP(AnimationParts.DisableOrDestroy DPNHODJHGJL)
		{
			AnimationParts.DisableOrDestroy disableOrDestroy = AnimationParts.OnDisableOrDestroy;
			AnimationParts.DisableOrDestroy disableOrDestroy2;
			do
			{
				disableOrDestroy2 = disableOrDestroy;
				disableOrDestroy = Interlocked.CompareExchange<AnimationParts.DisableOrDestroy>(ref AnimationParts.OnDisableOrDestroy, (AnimationParts.DisableOrDestroy)Delegate.Combine(disableOrDestroy2, DPNHODJHGJL), disableOrDestroy);
			}
			while (disableOrDestroy != disableOrDestroy2);
		}

		// Token: 0x06008ACC RID: 35532 RVA: 0x00303C98 File Offset: 0x00301E98
		public void FinalEnd()
		{
			if (this.ObjectState == AnimationParts.State.CLOSE)
			{
				if (this.EndState == AnimationParts.EndTweenClose.DEACTIVATE)
				{
					if (AnimationParts.OnDisableOrDestroy != null)
					{
						AnimationParts.OnDisableOrDestroy(true, this);
					}
				}
				else if (this.EndState == AnimationParts.EndTweenClose.DESTROY && AnimationParts.OnDisableOrDestroy != null)
				{
					AnimationParts.OnDisableOrDestroy(false, this);
				}
			}
			if (this.SaveState)
			{
				this.ObjectState = ((this.ObjectState != AnimationParts.State.OPEN) ? AnimationParts.State.OPEN : AnimationParts.State.CLOSE);
			}
		}

		// Token: 0x06008ACD RID: 35533 RVA: 0x00303197 File Offset: 0x00301397
		private void HDGFOOIJGDA()
		{
			this.CheckNextFrame = !this.CheckNextFrame;
			this.CallBackObject.Invoke();
		}

		// Token: 0x06008ACE RID: 35534 RVA: 0x00303D1C File Offset: 0x00301F1C
		public void LLHMIDEIPDP()
		{
			if (this.CheckNextFrame)
			{
				if (this.CallOnThisFrame)
				{
					this.CPFGDFEMDDJ();
				}
				this.CallOnThisFrame = !this.CallOnThisFrame;
			}
		}

		// Token: 0x06008ACF RID: 35535 RVA: 0x00303D49 File Offset: 0x00301F49
		private void AHBGJPLECLM()
		{
			this.CheckNextFrame = this.CheckNextFrame;
			this.CallBackObject.Invoke();
		}

		// Token: 0x06008AD0 RID: 35536 RVA: 0x00303D65 File Offset: 0x00301F65
		public void SetStatus(bool IEELOHCEFMK)
		{
			if (IEELOHCEFMK)
			{
				this.ObjectState = AnimationParts.State.OPEN;
			}
			else
			{
				this.ObjectState = AnimationParts.State.CLOSE;
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06008AD1 RID: 35537 RVA: 0x00303D80 File Offset: 0x00301F80
		// (remove) Token: 0x06008AFC RID: 35580 RVA: 0x0030470C File Offset: 0x0030290C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event AnimationParts.DisableOrDestroy OnDisableOrDestroy;

		// Token: 0x06008AD2 RID: 35538 RVA: 0x00303DB4 File Offset: 0x00301FB4
		public void CAAMLEEDONA(float HNIFGMOMJMA)
		{
			if (HNIFGMOMJMA > 1646f)
			{
				this.animationDuration = HNIFGMOMJMA;
			}
			else
			{
				HNIFGMOMJMA = 1150f;
			}
		}

		// Token: 0x06008AD3 RID: 35539 RVA: 0x00303DD4 File Offset: 0x00301FD4
		private void NILBDIDBIHN(UnityEvent HEJHAECMLKB)
		{
			this.CallBackObject = HEJHAECMLKB;
			this.CheckNextFrame = !this.CheckNextFrame;
		}

		// Token: 0x06008AD4 RID: 35540 RVA: 0x00303DEC File Offset: 0x00301FEC
		public void PAFLJNPHHPD(float HNIFGMOMJMA)
		{
			if (HNIFGMOMJMA > 1805f)
			{
				this.animationDuration = HNIFGMOMJMA;
			}
			else
			{
				HNIFGMOMJMA = 1049f;
			}
		}

		// Token: 0x06008AD5 RID: 35541 RVA: 0x00303D65 File Offset: 0x00301F65
		public void ICJELHJJCIM(bool IEELOHCEFMK)
		{
			if (IEELOHCEFMK)
			{
				this.ObjectState = AnimationParts.State.OPEN;
			}
			else
			{
				this.ObjectState = AnimationParts.State.CLOSE;
			}
		}

		// Token: 0x06008AD6 RID: 35542 RVA: 0x00303E0C File Offset: 0x0030200C
		public void BPNFPEEHEFK(float HNIFGMOMJMA)
		{
			if (HNIFGMOMJMA > 1190f)
			{
				this.animationDuration = HNIFGMOMJMA;
			}
			else
			{
				HNIFGMOMJMA = 712f;
			}
		}

		// Token: 0x06008AD7 RID: 35543 RVA: 0x00303E2C File Offset: 0x0030202C
		public bool KBKNHBKLKAI()
		{
			return this.ObjectState == AnimationParts.State.OPEN && false;
		}

		// Token: 0x06008AD8 RID: 35544 RVA: 0x00303E40 File Offset: 0x00302040
		public static void EAHJEPGPBLG(AnimationParts.DisableOrDestroy DPNHODJHGJL)
		{
			AnimationParts.DisableOrDestroy disableOrDestroy = AnimationParts.OnDisableOrDestroy;
			AnimationParts.DisableOrDestroy disableOrDestroy2;
			do
			{
				disableOrDestroy2 = disableOrDestroy;
				disableOrDestroy = Interlocked.CompareExchange<AnimationParts.DisableOrDestroy>(ref AnimationParts.OnDisableOrDestroy, (AnimationParts.DisableOrDestroy)Delegate.Combine(disableOrDestroy2, DPNHODJHGJL), disableOrDestroy);
			}
			while (disableOrDestroy != disableOrDestroy2);
		}

		// Token: 0x06008AD9 RID: 35545 RVA: 0x00303E74 File Offset: 0x00302074
		public void MIEMHPJMHDB(float HNIFGMOMJMA)
		{
			if (HNIFGMOMJMA > 835f)
			{
				this.animationDuration = HNIFGMOMJMA;
			}
			else
			{
				HNIFGMOMJMA = 806f;
			}
		}

		// Token: 0x06008ADA RID: 35546 RVA: 0x00303E94 File Offset: 0x00302094
		public void OOFFIDHDKNH()
		{
			if (this.CheckNextFrame)
			{
				if (this.CallOnThisFrame)
				{
					this.CKIBAKANONG();
				}
				this.CallOnThisFrame = this.CallOnThisFrame;
			}
		}

		// Token: 0x06008ADB RID: 35547 RVA: 0x00303058 File Offset: 0x00301258
		public float IHJDLAKDEFG()
		{
			return this.animationDuration;
		}

		// Token: 0x06008ADC RID: 35548 RVA: 0x00303EC1 File Offset: 0x003020C1
		public bool IMLMEJJMKJI()
		{
			return this.ObjectState == AnimationParts.State.CLOSE;
		}

		// Token: 0x06008ADD RID: 35549 RVA: 0x00303ED2 File Offset: 0x003020D2
		public void NCKJGAMLDDH(bool IEELOHCEFMK)
		{
			if (IEELOHCEFMK)
			{
				this.ObjectState = AnimationParts.State.OPEN;
			}
			else
			{
				this.ObjectState = AnimationParts.State.OPEN;
			}
		}

		// Token: 0x06008ADE RID: 35550 RVA: 0x00303EED File Offset: 0x003020ED
		public void SetAniamtioDuration(float HNIFGMOMJMA)
		{
			if (HNIFGMOMJMA > 0f)
			{
				this.animationDuration = HNIFGMOMJMA;
			}
			else
			{
				HNIFGMOMJMA = 0.01f;
			}
		}

		// Token: 0x06008ADF RID: 35551 RVA: 0x00303F10 File Offset: 0x00302110
		public void LFGHKFGEPFD()
		{
			if (this.ObjectState == AnimationParts.State.OPEN)
			{
				if (this.EndState == AnimationParts.EndTweenClose.DEACTIVATE)
				{
					if (AnimationParts.OnDisableOrDestroy != null)
					{
						AnimationParts.OnDisableOrDestroy(false, this);
					}
				}
				else if (this.EndState == AnimationParts.EndTweenClose.DESTROY && AnimationParts.OnDisableOrDestroy != null)
				{
					AnimationParts.OnDisableOrDestroy(true, this);
				}
			}
			if (this.SaveState)
			{
				this.ObjectState = ((this.ObjectState != AnimationParts.State.OPEN) ? AnimationParts.State.OPEN : AnimationParts.State.OPEN);
			}
		}

		// Token: 0x06008AE0 RID: 35552 RVA: 0x00303F94 File Offset: 0x00302194
		public void EDKPOHAPNLO()
		{
			if (this.CheckNextFrame)
			{
				if (this.CallOnThisFrame)
				{
					this.HDGFOOIJGDA();
				}
				this.CallOnThisFrame = this.CallOnThisFrame;
			}
		}

		// Token: 0x06008AE1 RID: 35553 RVA: 0x00303FC4 File Offset: 0x003021C4
		public static void MIOIBBOAEJM(AnimationParts.DisableOrDestroy DPNHODJHGJL)
		{
			AnimationParts.DisableOrDestroy disableOrDestroy = AnimationParts.OnDisableOrDestroy;
			AnimationParts.DisableOrDestroy disableOrDestroy2;
			do
			{
				disableOrDestroy2 = disableOrDestroy;
				disableOrDestroy = Interlocked.CompareExchange<AnimationParts.DisableOrDestroy>(ref AnimationParts.OnDisableOrDestroy, (AnimationParts.DisableOrDestroy)Delegate.Remove(disableOrDestroy2, DPNHODJHGJL), disableOrDestroy);
			}
			while (disableOrDestroy != disableOrDestroy2);
		}

		// Token: 0x06008AE2 RID: 35554 RVA: 0x00303FF8 File Offset: 0x003021F8
		public static void LPACHLLEGDN(AnimationParts.DisableOrDestroy DPNHODJHGJL)
		{
			AnimationParts.DisableOrDestroy disableOrDestroy = AnimationParts.OnDisableOrDestroy;
			AnimationParts.DisableOrDestroy disableOrDestroy2;
			do
			{
				disableOrDestroy2 = disableOrDestroy;
				disableOrDestroy = Interlocked.CompareExchange<AnimationParts.DisableOrDestroy>(ref AnimationParts.OnDisableOrDestroy, (AnimationParts.DisableOrDestroy)Delegate.Remove(disableOrDestroy2, DPNHODJHGJL), disableOrDestroy);
			}
			while (disableOrDestroy != disableOrDestroy2);
		}

		// Token: 0x06008AE3 RID: 35555 RVA: 0x00303264 File Offset: 0x00301464
		private void GPLGELNECLG(UnityEvent HEJHAECMLKB)
		{
			this.CallBackObject = HEJHAECMLKB;
			this.CheckNextFrame = this.CheckNextFrame;
		}

		// Token: 0x06008AE4 RID: 35556 RVA: 0x0030402C File Offset: 0x0030222C
		public void JFIGKODILLH()
		{
			if (this.CheckNextFrame)
			{
				if (this.CallOnThisFrame)
				{
					this.DHJJDCFBKMP();
				}
				this.CallOnThisFrame = this.CallOnThisFrame;
			}
		}

		// Token: 0x06008AE5 RID: 35557 RVA: 0x00304059 File Offset: 0x00302259
		public void IOLLFAECKEA(float HNIFGMOMJMA)
		{
			if (HNIFGMOMJMA > 1499f)
			{
				this.animationDuration = HNIFGMOMJMA;
			}
			else
			{
				HNIFGMOMJMA = 913f;
			}
		}

		// Token: 0x06008AE6 RID: 35558 RVA: 0x00303058 File Offset: 0x00301258
		public float ICPPNEMBEEG()
		{
			return this.animationDuration;
		}

		// Token: 0x06008AE7 RID: 35559 RVA: 0x00304079 File Offset: 0x00302279
		public bool IsObjectOpened()
		{
			return this.ObjectState != AnimationParts.State.CLOSE;
		}

		// Token: 0x06008AE8 RID: 35560 RVA: 0x0030408C File Offset: 0x0030228C
		public void Ended()
		{
			if (this.CallCallback != AnimationParts.CallbackCall.NOTHING)
			{
				if (this.ObjectState == AnimationParts.State.CLOSE && (this.CallCallback == AnimationParts.CallbackCall.END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_EXIT_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_EXIT_END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_AND_START_EXIT_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_AND_START_EXIT_END_OF_INTRO_AND_END_OF_EXIT_ANIM))
				{
					this.HGCMPOOGHFL(this.ExitEvents);
				}
				if ((this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_EXIT_END_OF_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_EXIT_END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_AND_START_EXIT_END_OF_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_AND_START_EXIT_END_OF_INTRO_AND_END_OF_EXIT_ANIM) && this.ObjectState == AnimationParts.State.OPEN)
				{
					this.HGCMPOOGHFL(this.IntroEvents);
				}
			}
		}

		// Token: 0x06008AE9 RID: 35561 RVA: 0x00303058 File Offset: 0x00301258
		public float PPHJAFKNJIN()
		{
			return this.animationDuration;
		}

		// Token: 0x06008AEA RID: 35562 RVA: 0x0030419C File Offset: 0x0030239C
		public bool CICJOFKMNGC()
		{
			return this.ObjectState != AnimationParts.State.OPEN || true;
		}

		// Token: 0x06008AEB RID: 35563 RVA: 0x003041AD File Offset: 0x003023AD
		public void MLHEAMKLJHC()
		{
			if (this.CheckNextFrame)
			{
				if (this.CallOnThisFrame)
				{
					this.CMKDPNLOMFM();
				}
				this.CallOnThisFrame = this.CallOnThisFrame;
			}
		}

		// Token: 0x06008AEC RID: 35564 RVA: 0x003041DA File Offset: 0x003023DA
		public void ChangeStatus()
		{
			if (this.ObjectState == AnimationParts.State.CLOSE)
			{
				this.ObjectState = AnimationParts.State.OPEN;
			}
			else
			{
				this.ObjectState = AnimationParts.State.CLOSE;
			}
		}

		// Token: 0x06008AED RID: 35565 RVA: 0x003041FC File Offset: 0x003023FC
		public static void CKHNCHEIMOF(AnimationParts.DisableOrDestroy DPNHODJHGJL)
		{
			AnimationParts.DisableOrDestroy disableOrDestroy = AnimationParts.OnDisableOrDestroy;
			AnimationParts.DisableOrDestroy disableOrDestroy2;
			do
			{
				disableOrDestroy2 = disableOrDestroy;
				disableOrDestroy = Interlocked.CompareExchange<AnimationParts.DisableOrDestroy>(ref AnimationParts.OnDisableOrDestroy, (AnimationParts.DisableOrDestroy)Delegate.Combine(disableOrDestroy2, DPNHODJHGJL), disableOrDestroy);
			}
			while (disableOrDestroy != disableOrDestroy2);
		}

		// Token: 0x06008AEE RID: 35566 RVA: 0x00303058 File Offset: 0x00301258
		public float AKPEAFOOMDP()
		{
			return this.animationDuration;
		}

		// Token: 0x06008AEF RID: 35567 RVA: 0x00303914 File Offset: 0x00301B14
		public void OIAHJHFJFJG()
		{
			if (this.CheckNextFrame)
			{
				if (this.CallOnThisFrame)
				{
					this.AHBGJPLECLM();
				}
				this.CallOnThisFrame = this.CallOnThisFrame;
			}
		}

		// Token: 0x06008AF0 RID: 35568 RVA: 0x00304230 File Offset: 0x00302430
		public void ALJPMEOIGEF()
		{
			if (this.CallCallback != (AnimationParts.CallbackCall)(-76))
			{
				if ((this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_EXIT_START_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.END_OF_EXIT_ANIM || this.CallCallback == (AnimationParts.CallbackCall)(-74) || this.CallCallback == (AnimationParts.CallbackCall)(-64) || this.CallCallback == (AnimationParts.CallbackCall)(-126) || this.CallCallback == AnimationParts.CallbackCall.START_EXIT_START_INTRO_ANIM) && this.ObjectState == AnimationParts.State.OPEN)
				{
					this.NILBDIDBIHN(this.IntroEvents);
				}
				else if ((this.CallCallback == (AnimationParts.CallbackCall)101 || this.CallCallback == AnimationParts.CallbackCall.START_EXIT_START_INTRO_ANIM || this.CallCallback == (AnimationParts.CallbackCall)(-82) || this.CallCallback == AnimationParts.CallbackCall.END_OF_EXIT_ANIM || this.CallCallback == (AnimationParts.CallbackCall)(-8) || this.CallCallback == (AnimationParts.CallbackCall)36 || this.CallCallback == (AnimationParts.CallbackCall)24 || this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_AND_END_OF_EXIT_ANIM) && this.ObjectState == AnimationParts.State.CLOSE)
				{
					this.NEABPDKPDPA(this.ExitEvents);
				}
			}
		}

		// Token: 0x06008AF1 RID: 35569 RVA: 0x00303914 File Offset: 0x00301B14
		public void FHKLHNCPBNF()
		{
			if (this.CheckNextFrame)
			{
				if (this.CallOnThisFrame)
				{
					this.AHBGJPLECLM();
				}
				this.CallOnThisFrame = this.CallOnThisFrame;
			}
		}

		// Token: 0x06008AF2 RID: 35570 RVA: 0x00304348 File Offset: 0x00302548
		public static void NABDOFNAEKN(AnimationParts.DisableOrDestroy DPNHODJHGJL)
		{
			AnimationParts.DisableOrDestroy disableOrDestroy = AnimationParts.OnDisableOrDestroy;
			AnimationParts.DisableOrDestroy disableOrDestroy2;
			do
			{
				disableOrDestroy2 = disableOrDestroy;
				disableOrDestroy = Interlocked.CompareExchange<AnimationParts.DisableOrDestroy>(ref AnimationParts.OnDisableOrDestroy, (AnimationParts.DisableOrDestroy)Delegate.Remove(disableOrDestroy2, DPNHODJHGJL), disableOrDestroy);
			}
			while (disableOrDestroy != disableOrDestroy2);
		}

		// Token: 0x06008AF3 RID: 35571 RVA: 0x0030437C File Offset: 0x0030257C
		public void LEBNFCBFDAM()
		{
			if (this.ObjectState == AnimationParts.State.CLOSE)
			{
				if (this.EndState == AnimationParts.EndTweenClose.DEACTIVATE)
				{
					if (AnimationParts.OnDisableOrDestroy != null)
					{
						AnimationParts.OnDisableOrDestroy(false, this);
					}
				}
				else if (this.EndState == AnimationParts.EndTweenClose.DESTROY && AnimationParts.OnDisableOrDestroy != null)
				{
					AnimationParts.OnDisableOrDestroy(true, this);
				}
			}
			if (this.SaveState)
			{
				this.ObjectState = ((this.ObjectState != AnimationParts.State.OPEN) ? AnimationParts.State.OPEN : AnimationParts.State.CLOSE);
			}
		}

		// Token: 0x06008AF4 RID: 35572 RVA: 0x00304400 File Offset: 0x00302600
		public void KIHLGFANBEC()
		{
			if (this.ObjectState == AnimationParts.State.OPEN)
			{
				if (this.EndState == AnimationParts.EndTweenClose.DEACTIVATE)
				{
					if (AnimationParts.OnDisableOrDestroy != null)
					{
						AnimationParts.OnDisableOrDestroy(true, this);
					}
				}
				else if (this.EndState == AnimationParts.EndTweenClose.DEACTIVATE && AnimationParts.OnDisableOrDestroy != null)
				{
					AnimationParts.OnDisableOrDestroy(true, this);
				}
			}
			if (this.SaveState)
			{
				this.ObjectState = ((this.ObjectState != AnimationParts.State.OPEN) ? AnimationParts.State.OPEN : AnimationParts.State.CLOSE);
			}
		}

		// Token: 0x06008AF5 RID: 35573 RVA: 0x00303DD4 File Offset: 0x00301FD4
		private void KOMFFAAJCBF(UnityEvent HEJHAECMLKB)
		{
			this.CallBackObject = HEJHAECMLKB;
			this.CheckNextFrame = !this.CheckNextFrame;
		}

		// Token: 0x06008AF6 RID: 35574 RVA: 0x00304484 File Offset: 0x00302684
		public void DAPBPBLMEEM()
		{
			if (this.CallCallback != AnimationParts.CallbackCall.START_INTRO_ANIM)
			{
				if (this.ObjectState == AnimationParts.State.CLOSE && (this.CallCallback == AnimationParts.CallbackCall.END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_ANIM || this.CallCallback == (AnimationParts.CallbackCall)68 || this.CallCallback == (AnimationParts.CallbackCall)96 || this.CallCallback == (AnimationParts.CallbackCall)(-66) || this.CallCallback == (AnimationParts.CallbackCall)(-104)))
				{
					this.FJHMMNMKGDG(this.ExitEvents);
				}
				if ((this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == (AnimationParts.CallbackCall)(-60) || this.CallCallback == (AnimationParts.CallbackCall)(-108) || this.CallCallback == (AnimationParts.CallbackCall)108 || this.CallCallback == (AnimationParts.CallbackCall)(-57)) && this.ObjectState == AnimationParts.State.OPEN)
				{
					this.OMCMINJINBM(this.IntroEvents);
				}
			}
		}

		// Token: 0x06008AF7 RID: 35575 RVA: 0x00304594 File Offset: 0x00302794
		public void HKPAOADBGNM()
		{
			if (this.CallCallback != (AnimationParts.CallbackCall)91)
			{
				if (this.ObjectState == AnimationParts.State.OPEN && (this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_INTRO_ANIM || this.CallCallback == (AnimationParts.CallbackCall)122 || this.CallCallback == (AnimationParts.CallbackCall)127 || this.CallCallback == (AnimationParts.CallbackCall)(-18) || this.CallCallback == (AnimationParts.CallbackCall)58))
				{
					this.NILBDIDBIHN(this.ExitEvents);
				}
				if ((this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_EXIT_START_INTRO_ANIM || this.CallCallback == (AnimationParts.CallbackCall)(-78) || this.CallCallback == (AnimationParts.CallbackCall)17 || this.CallCallback == (AnimationParts.CallbackCall)71 || this.CallCallback == (AnimationParts.CallbackCall)(-99)) && this.ObjectState == AnimationParts.State.OPEN)
				{
					this.HGCMPOOGHFL(this.IntroEvents);
				}
			}
		}

		// Token: 0x06008AF8 RID: 35576 RVA: 0x003046A4 File Offset: 0x003028A4
		public static void JAECJHCOHNH(AnimationParts.DisableOrDestroy DPNHODJHGJL)
		{
			AnimationParts.DisableOrDestroy disableOrDestroy = AnimationParts.OnDisableOrDestroy;
			AnimationParts.DisableOrDestroy disableOrDestroy2;
			do
			{
				disableOrDestroy2 = disableOrDestroy;
				disableOrDestroy = Interlocked.CompareExchange<AnimationParts.DisableOrDestroy>(ref AnimationParts.OnDisableOrDestroy, (AnimationParts.DisableOrDestroy)Delegate.Combine(disableOrDestroy2, DPNHODJHGJL), disableOrDestroy);
			}
			while (disableOrDestroy != disableOrDestroy2);
		}

		// Token: 0x06008AF9 RID: 35577 RVA: 0x00303778 File Offset: 0x00301978
		public bool LKLNGEFDNEI()
		{
			return this.ObjectState == AnimationParts.State.CLOSE && false;
		}

		// Token: 0x06008AFA RID: 35578 RVA: 0x00303058 File Offset: 0x00301258
		public float GetAnimationDuration()
		{
			return this.animationDuration;
		}

		// Token: 0x06008AFB RID: 35579 RVA: 0x003046D8 File Offset: 0x003028D8
		public static void AOJECCFLFDF(AnimationParts.DisableOrDestroy DPNHODJHGJL)
		{
			AnimationParts.DisableOrDestroy disableOrDestroy = AnimationParts.OnDisableOrDestroy;
			AnimationParts.DisableOrDestroy disableOrDestroy2;
			do
			{
				disableOrDestroy2 = disableOrDestroy;
				disableOrDestroy = Interlocked.CompareExchange<AnimationParts.DisableOrDestroy>(ref AnimationParts.OnDisableOrDestroy, (AnimationParts.DisableOrDestroy)Delegate.Combine(disableOrDestroy2, DPNHODJHGJL), disableOrDestroy);
			}
			while (disableOrDestroy != disableOrDestroy2);
		}

		// Token: 0x06008AFD RID: 35581 RVA: 0x00303300 File Offset: 0x00301500
		public bool ILJDBJLNDAH()
		{
			return this.ObjectState != AnimationParts.State.OPEN;
		}

		// Token: 0x06008AFE RID: 35582 RVA: 0x00303D49 File Offset: 0x00301F49
		private void OONDKMIHEEI()
		{
			this.CheckNextFrame = this.CheckNextFrame;
			this.CallBackObject.Invoke();
		}

		// Token: 0x06008AFF RID: 35583 RVA: 0x00304740 File Offset: 0x00302940
		public void KBHMGMGJKPB(float HNIFGMOMJMA)
		{
			if (HNIFGMOMJMA > 1899f)
			{
				this.animationDuration = HNIFGMOMJMA;
			}
			else
			{
				HNIFGMOMJMA = 956f;
			}
		}

		// Token: 0x06008B00 RID: 35584 RVA: 0x00303058 File Offset: 0x00301258
		public float KFHGNKPGLPM()
		{
			return this.animationDuration;
		}

		// Token: 0x06008B01 RID: 35585 RVA: 0x00304760 File Offset: 0x00302960
		public void MEHKKGGEFLC()
		{
			if (this.ObjectState == AnimationParts.State.CLOSE)
			{
				if (this.EndState == AnimationParts.EndTweenClose.DEACTIVATE)
				{
					if (AnimationParts.OnDisableOrDestroy != null)
					{
						AnimationParts.OnDisableOrDestroy(true, this);
					}
				}
				else if (this.EndState == AnimationParts.EndTweenClose.DEACTIVATE && AnimationParts.OnDisableOrDestroy != null)
				{
					AnimationParts.OnDisableOrDestroy(false, this);
				}
			}
			if (this.SaveState)
			{
				this.ObjectState = ((this.ObjectState != AnimationParts.State.OPEN) ? AnimationParts.State.CLOSE : AnimationParts.State.OPEN);
			}
		}

		// Token: 0x06008B02 RID: 35586 RVA: 0x00303264 File Offset: 0x00301464
		private void NEABPDKPDPA(UnityEvent HEJHAECMLKB)
		{
			this.CallBackObject = HEJHAECMLKB;
			this.CheckNextFrame = this.CheckNextFrame;
		}

		// Token: 0x06008B03 RID: 35587 RVA: 0x00303E2C File Offset: 0x0030202C
		public bool MGGLPMMENGN()
		{
			return this.ObjectState == AnimationParts.State.OPEN && false;
		}

		// Token: 0x06008B04 RID: 35588 RVA: 0x00303D49 File Offset: 0x00301F49
		private void CPFGDFEMDDJ()
		{
			this.CheckNextFrame = this.CheckNextFrame;
			this.CallBackObject.Invoke();
		}

		// Token: 0x06008B05 RID: 35589 RVA: 0x003047E4 File Offset: 0x003029E4
		public static void MNHMHGLJPNP(AnimationParts.DisableOrDestroy DPNHODJHGJL)
		{
			AnimationParts.DisableOrDestroy disableOrDestroy = AnimationParts.OnDisableOrDestroy;
			AnimationParts.DisableOrDestroy disableOrDestroy2;
			do
			{
				disableOrDestroy2 = disableOrDestroy;
				disableOrDestroy = Interlocked.CompareExchange<AnimationParts.DisableOrDestroy>(ref AnimationParts.OnDisableOrDestroy, (AnimationParts.DisableOrDestroy)Delegate.Remove(disableOrDestroy2, DPNHODJHGJL), disableOrDestroy);
			}
			while (disableOrDestroy != disableOrDestroy2);
		}

		// Token: 0x06008B06 RID: 35590 RVA: 0x00304818 File Offset: 0x00302A18
		public void NCGDHPOGJAH()
		{
			if (this.CallCallback != (AnimationParts.CallbackCall)(-86))
			{
				if (this.ObjectState == AnimationParts.State.OPEN && (this.CallCallback == AnimationParts.CallbackCall.END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == (AnimationParts.CallbackCall)(-92) || this.CallCallback == (AnimationParts.CallbackCall)16 || this.CallCallback == (AnimationParts.CallbackCall)98 || this.CallCallback == (AnimationParts.CallbackCall)(-85)))
				{
					this.HGCMPOOGHFL(this.ExitEvents);
				}
				if ((this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_ANIM || this.CallCallback == (AnimationParts.CallbackCall)(-86) || this.CallCallback == (AnimationParts.CallbackCall)63 || this.CallCallback == (AnimationParts.CallbackCall)85 || this.CallCallback == (AnimationParts.CallbackCall)(-33)) && this.ObjectState == AnimationParts.State.OPEN)
				{
					this.HGCMPOOGHFL(this.IntroEvents);
				}
			}
		}

		// Token: 0x06008B07 RID: 35591 RVA: 0x00304928 File Offset: 0x00302B28
		public static void MCIKDIPOLII(AnimationParts.DisableOrDestroy DPNHODJHGJL)
		{
			AnimationParts.DisableOrDestroy disableOrDestroy = AnimationParts.OnDisableOrDestroy;
			AnimationParts.DisableOrDestroy disableOrDestroy2;
			do
			{
				disableOrDestroy2 = disableOrDestroy;
				disableOrDestroy = Interlocked.CompareExchange<AnimationParts.DisableOrDestroy>(ref AnimationParts.OnDisableOrDestroy, (AnimationParts.DisableOrDestroy)Delegate.Remove(disableOrDestroy2, DPNHODJHGJL), disableOrDestroy);
			}
			while (disableOrDestroy != disableOrDestroy2);
		}

		// Token: 0x06008B08 RID: 35592 RVA: 0x0030495C File Offset: 0x00302B5C
		public void EPGBEJPAPLJ()
		{
			if (this.CheckNextFrame)
			{
				if (this.CallOnThisFrame)
				{
					this.EHKKONNBPDE();
				}
				this.CallOnThisFrame = !this.CallOnThisFrame;
			}
		}

		// Token: 0x06008B09 RID: 35593 RVA: 0x0030498C File Offset: 0x00302B8C
		public void POJCKALIPOM()
		{
			if (this.CallCallback != (AnimationParts.CallbackCall)77)
			{
				if ((this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_EXIT_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_ANIM || this.CallCallback == AnimationParts.CallbackCall.START_EXIT_ANIM || this.CallCallback == (AnimationParts.CallbackCall)127 || this.CallCallback == (AnimationParts.CallbackCall)51 || this.CallCallback == (AnimationParts.CallbackCall)(-22) || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_ANIM) && this.ObjectState == AnimationParts.State.OPEN)
				{
					this.OMCMINJINBM(this.IntroEvents);
				}
				else if ((this.CallCallback == (AnimationParts.CallbackCall)(-1) || this.CallCallback == AnimationParts.CallbackCall.END_OF_INTRO_AND_END_OF_EXIT_ANIM || this.CallCallback == (AnimationParts.CallbackCall)(-16) || this.CallCallback == (AnimationParts.CallbackCall)40 || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_EXIT_ANIM || this.CallCallback == (AnimationParts.CallbackCall)(-44) || this.CallCallback == (AnimationParts.CallbackCall)(-128) || this.CallCallback == AnimationParts.CallbackCall.START_INTRO_END_OF_INTRO_ANIM) && this.ObjectState == AnimationParts.State.OPEN)
				{
					this.HGCMPOOGHFL(this.ExitEvents);
				}
			}
		}

		// Token: 0x06008B0A RID: 35594 RVA: 0x00304AA3 File Offset: 0x00302CA3
		public void FrameCheck()
		{
			if (this.CheckNextFrame)
			{
				if (this.CallOnThisFrame)
				{
					this.CMKDPNLOMFM();
				}
				this.CallOnThisFrame = !this.CallOnThisFrame;
			}
		}

		// Token: 0x06008B0B RID: 35595 RVA: 0x00303197 File Offset: 0x00301397
		private void CKIBAKANONG()
		{
			this.CheckNextFrame = !this.CheckNextFrame;
			this.CallBackObject.Invoke();
		}

		// Token: 0x06008B0C RID: 35596 RVA: 0x00303A8F File Offset: 0x00301C8F
		public void APHLHCEPFCI()
		{
			if (this.ObjectState == AnimationParts.State.OPEN)
			{
				this.ObjectState = AnimationParts.State.OPEN;
			}
			else
			{
				this.ObjectState = AnimationParts.State.CLOSE;
			}
		}

		// Token: 0x06008B0D RID: 35597 RVA: 0x00303D65 File Offset: 0x00301F65
		public void HINLLILIFFB(bool IEELOHCEFMK)
		{
			if (IEELOHCEFMK)
			{
				this.ObjectState = AnimationParts.State.OPEN;
			}
			else
			{
				this.ObjectState = AnimationParts.State.CLOSE;
			}
		}

		// Token: 0x06008B0E RID: 35598 RVA: 0x00304079 File Offset: 0x00302279
		public bool FBICEEKMKBC()
		{
			return this.ObjectState != AnimationParts.State.CLOSE;
		}

		// Token: 0x06008B0F RID: 35599 RVA: 0x00303DD4 File Offset: 0x00301FD4
		private void HGCMPOOGHFL(UnityEvent HEJHAECMLKB)
		{
			this.CallBackObject = HEJHAECMLKB;
			this.CheckNextFrame = !this.CheckNextFrame;
		}

		// Token: 0x06008B10 RID: 35600 RVA: 0x00303264 File Offset: 0x00301464
		private void OMCMINJINBM(UnityEvent HEJHAECMLKB)
		{
			this.CallBackObject = HEJHAECMLKB;
			this.CheckNextFrame = this.CheckNextFrame;
		}

		// Token: 0x06008B11 RID: 35601 RVA: 0x00303264 File Offset: 0x00301464
		private void FJHMMNMKGDG(UnityEvent HEJHAECMLKB)
		{
			this.CallBackObject = HEJHAECMLKB;
			this.CheckNextFrame = this.CheckNextFrame;
		}

		// Token: 0x06008B12 RID: 35602 RVA: 0x00303197 File Offset: 0x00301397
		private void DHJJDCFBKMP()
		{
			this.CheckNextFrame = !this.CheckNextFrame;
			this.CallBackObject.Invoke();
		}

		// Token: 0x06008B13 RID: 35603 RVA: 0x00304AD0 File Offset: 0x00302CD0
		public void EEJHDHAFHAL(float HNIFGMOMJMA)
		{
			if (HNIFGMOMJMA > 277f)
			{
				this.animationDuration = HNIFGMOMJMA;
			}
			else
			{
				HNIFGMOMJMA = 923f;
			}
		}

		// Token: 0x06008B14 RID: 35604 RVA: 0x00304AF0 File Offset: 0x00302CF0
		public static void GNAHAFGFEIE(AnimationParts.DisableOrDestroy DPNHODJHGJL)
		{
			AnimationParts.DisableOrDestroy disableOrDestroy = AnimationParts.OnDisableOrDestroy;
			AnimationParts.DisableOrDestroy disableOrDestroy2;
			do
			{
				disableOrDestroy2 = disableOrDestroy;
				disableOrDestroy = Interlocked.CompareExchange<AnimationParts.DisableOrDestroy>(ref AnimationParts.OnDisableOrDestroy, (AnimationParts.DisableOrDestroy)Delegate.Combine(disableOrDestroy2, DPNHODJHGJL), disableOrDestroy);
			}
			while (disableOrDestroy != disableOrDestroy2);
		}

		// Token: 0x06008B15 RID: 35605 RVA: 0x00303197 File Offset: 0x00301397
		private void CNFEPDJOIAP()
		{
			this.CheckNextFrame = !this.CheckNextFrame;
			this.CallBackObject.Invoke();
		}

		// Token: 0x04000FF9 RID: 4089
		[HideInInspector]
		public PositionPropetiesAnim PositionPropetiesAnim = new PositionPropetiesAnim();

		// Token: 0x04000FFA RID: 4090
		[HideInInspector]
		public ScalePropetiesAnim ScalePropetiesAnim = new ScalePropetiesAnim();

		// Token: 0x04000FFB RID: 4091
		[HideInInspector]
		public RotationPropetiesAnim RotationPropetiesAnim = new RotationPropetiesAnim();

		// Token: 0x04000FFC RID: 4092
		[HideInInspector]
		public FadePropetiesAnim FadePropetiesAnim = new FadePropetiesAnim();

		// Token: 0x04000FFD RID: 4093
		public bool UnscaledTimeAnimation;

		// Token: 0x04000FFE RID: 4094
		public bool SaveState;

		// Token: 0x04000FFF RID: 4095
		public bool AtomicAnimation;

		// Token: 0x04001000 RID: 4096
		public AnimationParts.State ObjectState = AnimationParts.State.CLOSE;

		// Token: 0x04001001 RID: 4097
		public AnimationParts.EndTweenClose EndState;

		// Token: 0x04001002 RID: 4098
		public AnimationParts.CallbackCall CallCallback;

		// Token: 0x04001003 RID: 4099
		public UnityEvent IntroEvents = new UnityEvent();

		// Token: 0x04001004 RID: 4100
		public UnityEvent ExitEvents = new UnityEvent();

		// Token: 0x04001005 RID: 4101
		private UnityEvent CallBackObject;

		// Token: 0x04001006 RID: 4102
		private bool CheckNextFrame;

		// Token: 0x04001007 RID: 4103
		private bool CallOnThisFrame;

		// Token: 0x04001008 RID: 4104
		[HideInInspector]
		[SerializeField]
		private float animationDuration = 1f;

		// Token: 0x0200023D RID: 573
		// (Invoke) Token: 0x06008B17 RID: 35607
		public delegate void DisableOrDestroy(bool AEIMJCDHKFI, AnimationParts AGNIEKAJHNM);

		// Token: 0x0200023E RID: 574
		public enum State
		{
			// Token: 0x0400100A RID: 4106
			OPEN,
			// Token: 0x0400100B RID: 4107
			CLOSE
		}

		// Token: 0x0200023F RID: 575
		public enum EndTweenClose
		{
			// Token: 0x0400100D RID: 4109
			DEACTIVATE,
			// Token: 0x0400100E RID: 4110
			DESTROY,
			// Token: 0x0400100F RID: 4111
			NOTHING
		}

		// Token: 0x02000240 RID: 576
		public enum CallbackCall
		{
			// Token: 0x04001011 RID: 4113
			END_OF_INTRO_ANIM,
			// Token: 0x04001012 RID: 4114
			END_OF_EXIT_ANIM,
			// Token: 0x04001013 RID: 4115
			END_OF_INTRO_AND_END_OF_EXIT_ANIM,
			// Token: 0x04001014 RID: 4116
			START_INTRO_ANIM,
			// Token: 0x04001015 RID: 4117
			START_INTRO_END_OF_EXIT_ANIM,
			// Token: 0x04001016 RID: 4118
			START_INTRO_END_OF_INTRO_ANIM,
			// Token: 0x04001017 RID: 4119
			START_INTRO_END_OF_INTRO_AND_END_OF_EXIT_ANIM,
			// Token: 0x04001018 RID: 4120
			START_EXIT_ANIM,
			// Token: 0x04001019 RID: 4121
			START_EXIT_START_INTRO_ANIM,
			// Token: 0x0400101A RID: 4122
			START_EXIT_END_OF_EXIT_ANIM,
			// Token: 0x0400101B RID: 4123
			START_EXIT_END_OF_INTRO_ANIM,
			// Token: 0x0400101C RID: 4124
			START_EXIT_END_OF_INTRO_AND_END_OF_EXIT_ANIM,
			// Token: 0x0400101D RID: 4125
			START_INTRO_AND_START_EXIT_END_OF_EXIT_ANIM,
			// Token: 0x0400101E RID: 4126
			START_INTRO_AND_START_EXIT_END_OF_INTRO_ANIM,
			// Token: 0x0400101F RID: 4127
			START_INTRO_AND_START_EXIT_END_OF_INTRO_AND_END_OF_EXIT_ANIM,
			// Token: 0x04001020 RID: 4128
			NOTHING
		}
	}
}
