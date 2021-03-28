using System;
using UnityEngine;

// Token: 0x02000232 RID: 562
public class FollowClick : MonoBehaviour
{
	// Token: 0x06008872 RID: 34930 RVA: 0x002FEB49 File Offset: 0x002FCD49
	private void LCHBFNIPBHB()
	{
		if (Input.GetMouseButtonDown(1))
		{
			this.CILEALNEGAI(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			this.NKJOOIFGNEF(this.RightClick);
		}
	}

	// Token: 0x06008873 RID: 34931 RVA: 0x002FEB80 File Offset: 0x002FCD80
	private void CHBANIHKAFN(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 754f);
		if (!this.TweenToControl.FJFANHLGGHL())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.NIOMFNEEMDF();
	}

	// Token: 0x06008874 RID: 34932 RVA: 0x002FEC54 File Offset: 0x002FCE54
	private void GFEKPHFDENH(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 1533f);
		if (!this.TweenToControl.FJFANHLGGHL())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.OpenCloseObjectAnimation();
	}

	// Token: 0x06008875 RID: 34933 RVA: 0x002FED28 File Offset: 0x002FCF28
	private void KJFFGNHEKDA(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 813f);
		if (!this.TweenToControl.FJFANHLGGHL())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.OpenCloseObjectAnimation();
	}

	// Token: 0x06008876 RID: 34934 RVA: 0x002FEDFB File Offset: 0x002FCFFB
	private void AEEGKLABFLN()
	{
		if (Input.GetMouseButtonDown(1))
		{
			this.FGPNEPGJOGI(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			this.JPENMJLBKAF(this.RightClick);
		}
	}

	// Token: 0x06008877 RID: 34935 RVA: 0x002FEE30 File Offset: 0x002FD030
	private void EHANNFEOCKB(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 854f);
		if (!this.TweenToControl.FJFANHLGGHL())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.OpenCloseObjectAnimation();
	}

	// Token: 0x06008878 RID: 34936 RVA: 0x002FEF04 File Offset: 0x002FD104
	private void GCPNPMELIGP(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 887f);
		if (!this.TweenToControl.IsObjectOpened())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.NIOMFNEEMDF();
	}

	// Token: 0x06008879 RID: 34937 RVA: 0x002FEFD7 File Offset: 0x002FD1D7
	private void MMBPLGGLPDB()
	{
		if (Input.GetMouseButtonDown(1))
		{
			this.HKMGEDGBGKM(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			this.BHNFCLDFEFD(this.RightClick);
		}
	}

	// Token: 0x0600887A RID: 34938 RVA: 0x002FF00C File Offset: 0x002FD20C
	private void OEENOOGEEHD()
	{
		if (Input.GetMouseButtonDown(0))
		{
			this.PHPCFLJLDCE(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			this.CILEALNEGAI(this.RightClick);
		}
	}

	// Token: 0x0600887B RID: 34939 RVA: 0x002FF041 File Offset: 0x002FD241
	private void JBNPEHMDCMI()
	{
		if (Input.GetMouseButtonDown(1))
		{
			this.GHMCFOOAFHF(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			this.EHANNFEOCKB(this.RightClick);
		}
	}

	// Token: 0x0600887C RID: 34940 RVA: 0x002FF076 File Offset: 0x002FD276
	private void NCPAFCKGJEA()
	{
		if (Input.GetMouseButtonDown(0))
		{
			this.HKMGEDGBGKM(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			this.HELCCDAIGNE(this.RightClick);
		}
	}

	// Token: 0x0600887D RID: 34941 RVA: 0x002FF0AB File Offset: 0x002FD2AB
	private void IKIDIJLIGOH()
	{
		if (Input.GetMouseButtonDown(0))
		{
			this.GHMCFOOAFHF(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			this.FGPNEPGJOGI(this.RightClick);
		}
	}

	// Token: 0x0600887E RID: 34942 RVA: 0x002FF0E0 File Offset: 0x002FD2E0
	private void KNJFMLBLOPF(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 231f);
		if (!this.TweenToControl.IsObjectOpened())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.OpenCloseObjectAnimation();
	}

	// Token: 0x0600887F RID: 34943 RVA: 0x002FF1B4 File Offset: 0x002FD3B4
	private void JPENMJLBKAF(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 1461f);
		if (!this.TweenToControl.FJFANHLGGHL())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.NIOMFNEEMDF();
	}

	// Token: 0x06008880 RID: 34944 RVA: 0x002FF288 File Offset: 0x002FD488
	private void HKMGEDGBGKM(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 1800f);
		if (!this.TweenToControl.FJFANHLGGHL())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.OpenCloseObjectAnimation();
	}

	// Token: 0x06008881 RID: 34945 RVA: 0x002FF35C File Offset: 0x002FD55C
	private void GHMCFOOAFHF(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 248f);
		if (!this.TweenToControl.FJFANHLGGHL())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.OpenCloseObjectAnimation();
	}

	// Token: 0x06008882 RID: 34946 RVA: 0x002FF430 File Offset: 0x002FD630
	private void ILKFPGNBHJC(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 1306f);
		if (!this.TweenToControl.FJFANHLGGHL())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.NIOMFNEEMDF();
	}

	// Token: 0x06008883 RID: 34947 RVA: 0x002FF503 File Offset: 0x002FD703
	private void MECJHOJPODB()
	{
		if (Input.GetMouseButtonDown(0))
		{
			this.KJFFGNHEKDA(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			this.KJFFGNHEKDA(this.RightClick);
		}
	}

	// Token: 0x06008884 RID: 34948 RVA: 0x002FF538 File Offset: 0x002FD738
	private void NOMCCMELEDE(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 291f);
		if (!this.TweenToControl.FJFANHLGGHL())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.NIOMFNEEMDF();
	}

	// Token: 0x06008885 RID: 34949 RVA: 0x002FF60B File Offset: 0x002FD80B
	private void DNENFLNCIJP()
	{
		if (Input.GetMouseButtonDown(1))
		{
			this.NKJOOIFGNEF(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			this.FFEHADCOLPF(this.RightClick);
		}
	}

	// Token: 0x06008886 RID: 34950 RVA: 0x002FF640 File Offset: 0x002FD840
	private void LEAHIBJDMBI()
	{
		if (Input.GetMouseButtonDown(1))
		{
			this.KJFFGNHEKDA(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			this.GCPNPMELIGP(this.RightClick);
		}
	}

	// Token: 0x06008887 RID: 34951 RVA: 0x002FF678 File Offset: 0x002FD878
	private void IABHEJLDKLG(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 762f);
		if (!this.TweenToControl.FJFANHLGGHL())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.NIOMFNEEMDF();
	}

	// Token: 0x06008888 RID: 34952 RVA: 0x002FF74B File Offset: 0x002FD94B
	private void PBEPCAPAKLG()
	{
		if (Input.GetMouseButtonDown(0))
		{
			this.KNJFMLBLOPF(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			this.PMEHFFIEEKI(this.RightClick);
		}
	}

	// Token: 0x06008889 RID: 34953 RVA: 0x002FF780 File Offset: 0x002FD980
	private void OFPEHPLFBAG(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 1913f);
		if (!this.TweenToControl.IsObjectOpened())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.NIOMFNEEMDF();
	}

	// Token: 0x0600888A RID: 34954 RVA: 0x002FF854 File Offset: 0x002FDA54
	private void JNMBPNPNNBN(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 699f);
		if (!this.TweenToControl.IsObjectOpened())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.NIOMFNEEMDF();
	}

	// Token: 0x0600888B RID: 34955 RVA: 0x002FF927 File Offset: 0x002FDB27
	private void MFMIODIAKNI()
	{
		if (Input.GetMouseButtonDown(0))
		{
			this.GLPADIGNIJA(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			this.PMEHFFIEEKI(this.RightClick);
		}
	}

	// Token: 0x0600888C RID: 34956 RVA: 0x002FF95C File Offset: 0x002FDB5C
	private void FHDOICBNMNC(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 83f);
		if (!this.TweenToControl.IsObjectOpened())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.NIOMFNEEMDF();
	}

	// Token: 0x0600888D RID: 34957 RVA: 0x002FFA30 File Offset: 0x002FDC30
	private void FFEHADCOLPF(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 757f);
		if (!this.TweenToControl.IsObjectOpened())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.NIOMFNEEMDF();
	}

	// Token: 0x0600888E RID: 34958 RVA: 0x002FFB04 File Offset: 0x002FDD04
	private void INBBPACAPGK(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 205f);
		if (!this.TweenToControl.IsObjectOpened())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.OpenCloseObjectAnimation();
	}

	// Token: 0x0600888F RID: 34959 RVA: 0x002FFBD8 File Offset: 0x002FDDD8
	private void GLPADIGNIJA(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 0f);
		if (!this.TweenToControl.IsObjectOpened())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.OpenCloseObjectAnimation();
	}

	// Token: 0x06008890 RID: 34960 RVA: 0x002FFCAB File Offset: 0x002FDEAB
	private void EHCGBJDFMHG()
	{
		if (Input.GetMouseButtonDown(1))
		{
			this.CILEALNEGAI(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			this.FHDOICBNMNC(this.RightClick);
		}
	}

	// Token: 0x06008891 RID: 34961 RVA: 0x002FFCE0 File Offset: 0x002FDEE0
	private void DGCGGKMNPLD()
	{
		if (Input.GetMouseButtonDown(0))
		{
			this.FGPNEPGJOGI(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			this.ILKFPGNBHJC(this.RightClick);
		}
	}

	// Token: 0x06008892 RID: 34962 RVA: 0x002FFD15 File Offset: 0x002FDF15
	private void JOACBIEHHCE()
	{
		if (Input.GetMouseButtonDown(0))
		{
			this.GHMCFOOAFHF(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			this.FHDOICBNMNC(this.RightClick);
		}
	}

	// Token: 0x06008893 RID: 34963 RVA: 0x002FFD4A File Offset: 0x002FDF4A
	private void IDIIELPAMCJ()
	{
		if (Input.GetMouseButtonDown(0))
		{
			this.DDMJPHIKODF(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			this.GHMCFOOAFHF(this.RightClick);
		}
	}

	// Token: 0x06008894 RID: 34964 RVA: 0x002FFD80 File Offset: 0x002FDF80
	private void ANKECMMLNOP(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 1724f);
		if (!this.TweenToControl.FJFANHLGGHL())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.OpenCloseObjectAnimation();
	}

	// Token: 0x06008895 RID: 34965 RVA: 0x002FFE53 File Offset: 0x002FE053
	private void LPMINJJPDCH()
	{
		if (Input.GetMouseButtonDown(0))
		{
			this.GCPNPMELIGP(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			this.CHBANIHKAFN(this.RightClick);
		}
	}

	// Token: 0x06008896 RID: 34966 RVA: 0x002FFE88 File Offset: 0x002FE088
	private void MJNPIDGNJMK()
	{
		if (Input.GetMouseButtonDown(1))
		{
			this.NKJOOIFGNEF(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			this.OFPEHPLFBAG(this.RightClick);
		}
	}

	// Token: 0x06008897 RID: 34967 RVA: 0x002FFEBD File Offset: 0x002FE0BD
	private void GPFJMKCGHGB()
	{
		if (Input.GetMouseButtonDown(0))
		{
			this.HKMGEDGBGKM(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			this.JFKEIMGOJOM(this.RightClick);
		}
	}

	// Token: 0x06008898 RID: 34968 RVA: 0x002FFEF2 File Offset: 0x002FE0F2
	private void LMBDNPLDGIJ()
	{
		if (Input.GetMouseButtonDown(0))
		{
			this.KJFFGNHEKDA(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			this.BHNFCLDFEFD(this.RightClick);
		}
	}

	// Token: 0x06008899 RID: 34969 RVA: 0x002FFF27 File Offset: 0x002FE127
	private void FABMDEHEDNO()
	{
		if (Input.GetMouseButtonDown(0))
		{
			this.FGPNEPGJOGI(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			this.IKDPMFCJAIK(this.RightClick);
		}
	}

	// Token: 0x0600889A RID: 34970 RVA: 0x002FFF5C File Offset: 0x002FE15C
	private void HDDECCMEJKA()
	{
		if (Input.GetMouseButtonDown(0))
		{
			this.FHDOICBNMNC(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			this.GFEKPHFDENH(this.RightClick);
		}
	}

	// Token: 0x0600889B RID: 34971 RVA: 0x002FFF91 File Offset: 0x002FE191
	private void EGEGNHLODAA()
	{
		if (Input.GetMouseButtonDown(0))
		{
			this.IKDPMFCJAIK(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			this.KJFFGNHEKDA(this.RightClick);
		}
	}

	// Token: 0x0600889C RID: 34972 RVA: 0x002FFFC6 File Offset: 0x002FE1C6
	private void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			this.GLPADIGNIJA(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			this.GLPADIGNIJA(this.RightClick);
		}
	}

	// Token: 0x0600889D RID: 34973 RVA: 0x002FFFFB File Offset: 0x002FE1FB
	private void FBMDHDBELEK()
	{
		if (Input.GetMouseButtonDown(1))
		{
			this.NKJOOIFGNEF(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			this.FFEHADCOLPF(this.RightClick);
		}
	}

	// Token: 0x0600889E RID: 34974 RVA: 0x00300030 File Offset: 0x002FE230
	private void LJIHHJOAJCN()
	{
		if (Input.GetMouseButtonDown(1))
		{
			this.CILEALNEGAI(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			this.FGPNEPGJOGI(this.RightClick);
		}
	}

	// Token: 0x0600889F RID: 34975 RVA: 0x00300065 File Offset: 0x002FE265
	private void AIJGAJIOJDJ()
	{
		if (Input.GetMouseButtonDown(1))
		{
			this.PHPCFLJLDCE(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			this.CHBANIHKAFN(this.RightClick);
		}
	}

	// Token: 0x060088A0 RID: 34976 RVA: 0x0030009A File Offset: 0x002FE29A
	private void NEKCPLGFOFD()
	{
		if (Input.GetMouseButtonDown(0))
		{
			this.NOMCCMELEDE(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			this.INBBPACAPGK(this.RightClick);
		}
	}

	// Token: 0x060088A1 RID: 34977 RVA: 0x003000CF File Offset: 0x002FE2CF
	private void KIEJKBNBHMD()
	{
		if (Input.GetMouseButtonDown(1))
		{
			this.GHMCFOOAFHF(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			this.EHANNFEOCKB(this.RightClick);
		}
	}

	// Token: 0x060088A2 RID: 34978 RVA: 0x00300104 File Offset: 0x002FE304
	private void BMODOIJGIOO()
	{
		if (Input.GetMouseButtonDown(1))
		{
			this.OFPEHPLFBAG(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			this.KJFFGNHEKDA(this.RightClick);
		}
	}

	// Token: 0x060088A3 RID: 34979 RVA: 0x0030013C File Offset: 0x002FE33C
	private void NKJOOIFGNEF(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 1867f);
		if (!this.TweenToControl.FJFANHLGGHL())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.OpenCloseObjectAnimation();
	}

	// Token: 0x060088A4 RID: 34980 RVA: 0x0030020F File Offset: 0x002FE40F
	private void OCMKCBBCEFG()
	{
		if (Input.GetMouseButtonDown(0))
		{
			this.JFKEIMGOJOM(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			this.PLDLEHLKGHG(this.RightClick);
		}
	}

	// Token: 0x060088A5 RID: 34981 RVA: 0x00300244 File Offset: 0x002FE444
	private void FGPNEPGJOGI(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 1465f);
		if (!this.TweenToControl.FJFANHLGGHL())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.OpenCloseObjectAnimation();
	}

	// Token: 0x060088A6 RID: 34982 RVA: 0x00300318 File Offset: 0x002FE518
	private void DDMJPHIKODF(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 1974f);
		if (!this.TweenToControl.FJFANHLGGHL())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.OpenCloseObjectAnimation();
	}

	// Token: 0x060088A7 RID: 34983 RVA: 0x003003EC File Offset: 0x002FE5EC
	private void CILEALNEGAI(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 632f);
		if (!this.TweenToControl.IsObjectOpened())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.NIOMFNEEMDF();
	}

	// Token: 0x060088A8 RID: 34984 RVA: 0x003004BF File Offset: 0x002FE6BF
	private void AGMJDGHLBMN()
	{
		if (Input.GetMouseButtonDown(0))
		{
			this.NOMCCMELEDE(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			this.FGPNEPGJOGI(this.RightClick);
		}
	}

	// Token: 0x060088AA RID: 34986 RVA: 0x003004F4 File Offset: 0x002FE6F4
	private void AAPKBNDHBLI()
	{
		if (Input.GetMouseButtonDown(0))
		{
			this.NOMCCMELEDE(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(0))
		{
			this.OFPEHPLFBAG(this.RightClick);
		}
	}

	// Token: 0x060088AB RID: 34987 RVA: 0x0030052C File Offset: 0x002FE72C
	private void PLDLEHLKGHG(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 1552f);
		if (!this.TweenToControl.IsObjectOpened())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.NIOMFNEEMDF();
	}

	// Token: 0x060088AC RID: 34988 RVA: 0x00300600 File Offset: 0x002FE800
	private void HELCCDAIGNE(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 348f);
		if (!this.TweenToControl.IsObjectOpened())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.OpenCloseObjectAnimation();
	}

	// Token: 0x060088AD RID: 34989 RVA: 0x003006D3 File Offset: 0x002FE8D3
	private void MAOCOEGAFND()
	{
		if (Input.GetMouseButtonDown(1))
		{
			this.KNJFMLBLOPF(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			this.FGPNEPGJOGI(this.RightClick);
		}
	}

	// Token: 0x060088AE RID: 34990 RVA: 0x00300708 File Offset: 0x002FE908
	private void BHNFCLDFEFD(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 718f);
		if (!this.TweenToControl.IsObjectOpened())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.OpenCloseObjectAnimation();
	}

	// Token: 0x060088AF RID: 34991 RVA: 0x003007DC File Offset: 0x002FE9DC
	private void PMEHFFIEEKI(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 1382f);
		if (!this.TweenToControl.FJFANHLGGHL())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.OpenCloseObjectAnimation();
	}

	// Token: 0x060088B0 RID: 34992 RVA: 0x003008AF File Offset: 0x002FEAAF
	private void AEIJFLJEABG()
	{
		if (Input.GetMouseButtonDown(1))
		{
			this.KJFFGNHEKDA(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			this.NOMCCMELEDE(this.RightClick);
		}
	}

	// Token: 0x060088B1 RID: 34993 RVA: 0x003008E4 File Offset: 0x002FEAE4
	private void IKDPMFCJAIK(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 118f);
		if (!this.TweenToControl.IsObjectOpened())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.OpenCloseObjectAnimation();
	}

	// Token: 0x060088B2 RID: 34994 RVA: 0x003009B8 File Offset: 0x002FEBB8
	private void PHPCFLJLDCE(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 331f);
		if (!this.TweenToControl.FJFANHLGGHL())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.NIOMFNEEMDF();
	}

	// Token: 0x060088B3 RID: 34995 RVA: 0x00300A8B File Offset: 0x002FEC8B
	private void ONMGIPAILOH()
	{
		if (Input.GetMouseButtonDown(1))
		{
			this.HKMGEDGBGKM(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			this.IKDPMFCJAIK(this.RightClick);
		}
	}

	// Token: 0x060088B4 RID: 34996 RVA: 0x00300AC0 File Offset: 0x002FECC0
	private void HPNNCNNFMGK()
	{
		if (Input.GetMouseButtonDown(1))
		{
			this.GHMCFOOAFHF(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			this.PHPCFLJLDCE(this.RightClick);
		}
	}

	// Token: 0x060088B5 RID: 34997 RVA: 0x00300AF5 File Offset: 0x002FECF5
	private void JDGFCEPDKAJ()
	{
		if (Input.GetMouseButtonDown(0))
		{
			this.FGPNEPGJOGI(this.LeftClick);
		}
		else if (Input.GetMouseButtonDown(1))
		{
			this.BHNFCLDFEFD(this.RightClick);
		}
	}

	// Token: 0x060088B6 RID: 34998 RVA: 0x00300B2C File Offset: 0x002FED2C
	private void JFKEIMGOJOM(AnimationCurve OLGKOFKLAOP)
	{
		Vector3 v = Camera.main.ScreenToViewportPoint(Input.mousePosition);
		v = new Vector3(v.x * (float)Screen.width / this.RootCanvas.localScale.x, v.y * (float)Screen.height / this.RootCanvas.localScale.y, 1582f);
		if (!this.TweenToControl.IsObjectOpened())
		{
			this.TweenToControl.SetAnimationPosition(this.TweenToControl.rectTransform.anchoredPosition, v, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		else
		{
			this.TweenToControl.SetAnimationPosition(v, this.TweenToControl.rectTransform.anchoredPosition, OLGKOFKLAOP, OLGKOFKLAOP);
		}
		this.TweenToControl.OpenCloseObjectAnimation();
	}

	// Token: 0x04000FC9 RID: 4041
	public AnimationCurve LeftClick;

	// Token: 0x04000FCA RID: 4042
	public AnimationCurve RightClick;

	// Token: 0x04000FCB RID: 4043
	public EasyTween TweenToControl;

	// Token: 0x04000FCC RID: 4044
	public Transform RootCanvas;
}
