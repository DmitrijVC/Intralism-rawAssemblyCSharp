using System;
using UnityEngine;

// Token: 0x020003A4 RID: 932
public class AnimationFromDistance : MonoBehaviour
{
	// Token: 0x0600D0BF RID: 53439 RVA: 0x004ACC37 File Offset: 0x004AAE37
	private void JADEDAEMLBN()
	{
		this.EFGKBEHNOBH.SetFloat("Crosshair", 532f);
		this.OLBDFLPFFHP = 532f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 1065f;
	}

	// Token: 0x0600D0C0 RID: 53440 RVA: 0x004ACC6A File Offset: 0x004AAE6A
	private void CPGAFFIOGCH()
	{
		this.EFGKBEHNOBH.SetFloat("GLITCH", 410f);
		this.OLBDFLPFFHP = 1062f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 1368f;
	}

	// Token: 0x0600D0C1 RID: 53441 RVA: 0x004ACC9D File Offset: 0x004AAE9D
	private void IICACFLHBCP()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.NALOPIJDJCM();
	}

	// Token: 0x0600D0C2 RID: 53442 RVA: 0x004ACCC7 File Offset: 0x004AAEC7
	private void MBBHOJMLCBC()
	{
		this.EFGKBEHNOBH.SetFloat("0 - background, 1 - foreground", 1236f);
		this.OLBDFLPFFHP = 1597f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 1724f;
	}

	// Token: 0x0600D0C3 RID: 53443 RVA: 0x004ACCFA File Offset: 0x004AAEFA
	public void PHEEPDCDKLI()
	{
		AnimationFromDistance.LGILGCGIHHM = 696f;
		this.CFCECAPJCOM = false;
	}

	// Token: 0x0600D0C4 RID: 53444 RVA: 0x004ACD0D File Offset: 0x004AAF0D
	private void FEAPMDENLBN()
	{
		this.EFGKBEHNOBH.SetFloat("float,1", 1390f);
		this.OLBDFLPFFHP = 1418f;
		this.CFCECAPJCOM = true;
		AnimationFromDistance.LGILGCGIHHM = 1911f;
	}

	// Token: 0x0600D0C5 RID: 53445 RVA: 0x004ACD40 File Offset: 0x004AAF40
	private void HPNNCNNFMGK()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 681f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 222f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("quantity", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1086f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (1316f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1733f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("Delete events", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0C6 RID: 53446 RVA: 0x004ACE51 File Offset: 0x004AB051
	public void HFDKOFIDLBG()
	{
		AnimationFromDistance.LGILGCGIHHM = 1993f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D0C7 RID: 53447 RVA: 0x004ACE64 File Offset: 0x004AB064
	private void GLGOLEOAFOD()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.MNBMLBLLDGL();
	}

	// Token: 0x0600D0C8 RID: 53448 RVA: 0x004ACE8E File Offset: 0x004AB08E
	private void Reset()
	{
		this.EFGKBEHNOBH.SetFloat("time", 0f);
		this.OLBDFLPFFHP = 0f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 0f;
	}

	// Token: 0x0600D0C9 RID: 53449 RVA: 0x004ACEC1 File Offset: 0x004AB0C1
	private void OJBFBLHIEBB()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.MIFIEGOGKDA();
	}

	// Token: 0x0600D0CA RID: 53450 RVA: 0x004ACEEB File Offset: 0x004AB0EB
	public void GMPIALPBIKM()
	{
		AnimationFromDistance.LGILGCGIHHM = 406f;
		this.CFCECAPJCOM = false;
	}

	// Token: 0x0600D0CB RID: 53451 RVA: 0x004ACF00 File Offset: 0x004AB100
	private void FBMDHDBELEK()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 1861f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1431f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("/", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1675f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (862f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 685f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("PossibleMapMaxScoreText", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0CC RID: 53452 RVA: 0x004AD011 File Offset: 0x004AB211
	private void KACPCCMPAHA()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.GLJIDEPMMFO();
	}

	// Token: 0x0600D0CD RID: 53453 RVA: 0x004AD03B File Offset: 0x004AB23B
	private void JOBBGDGHJMB()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.JHPDFCAGCHC();
	}

	// Token: 0x0600D0CE RID: 53454 RVA: 0x004AD068 File Offset: 0x004AB268
	private void APKNAPHOFHC()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 293f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 809f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("CameraFilterPack/Distortion_Dissipation", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 463f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (822f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1329f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("_Noise", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0CF RID: 53455 RVA: 0x004AD179 File Offset: 0x004AB379
	public void DBNHAJIJODM()
	{
		AnimationFromDistance.LGILGCGIHHM = 609f;
		this.CFCECAPJCOM = false;
	}

	// Token: 0x0600D0D0 RID: 53456 RVA: 0x004AD18C File Offset: 0x004AB38C
	private void EHMMNELHAPJ()
	{
		this.EFGKBEHNOBH.SetFloat("CameraFilterPack/3D_Computer", 745f);
		this.OLBDFLPFFHP = 952f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 722f;
	}

	// Token: 0x0600D0D1 RID: 53457 RVA: 0x004AD1C0 File Offset: 0x004AB3C0
	private void LCJHDLKJEOM()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 916f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1145f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("offsets", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1958f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (813f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 749f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("skin.no_hit", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0D2 RID: 53458 RVA: 0x004AD2D1 File Offset: 0x004AB4D1
	private void HFFAJNCOJNB()
	{
		this.EFGKBEHNOBH.SetFloat("EventMenu", 657f);
		this.OLBDFLPFFHP = 230f;
		this.CFCECAPJCOM = true;
		AnimationFromDistance.LGILGCGIHHM = 432f;
	}

	// Token: 0x0600D0D3 RID: 53459 RVA: 0x004AD304 File Offset: 0x004AB504
	public void OHOEFHCIKEK()
	{
		AnimationFromDistance.LGILGCGIHHM = 57f;
		this.CFCECAPJCOM = false;
	}

	// Token: 0x0600D0D4 RID: 53460 RVA: 0x004AD317 File Offset: 0x004AB517
	public void HHNHILPCCDM()
	{
		AnimationFromDistance.LGILGCGIHHM = 362f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D0D5 RID: 53461 RVA: 0x004AD32A File Offset: 0x004AB52A
	public void BIBAKFKFPPM()
	{
		AnimationFromDistance.LGILGCGIHHM = 108f;
		this.CFCECAPJCOM = false;
	}

	// Token: 0x0600D0D6 RID: 53462 RVA: 0x004AD33D File Offset: 0x004AB53D
	public void GGLNMDBEBNB()
	{
		AnimationFromDistance.LGILGCGIHHM = 667f;
		this.CFCECAPJCOM = false;
	}

	// Token: 0x0600D0D7 RID: 53463 RVA: 0x004AD350 File Offset: 0x004AB550
	private void BBBNLHALLBN()
	{
		this.EFGKBEHNOBH.SetFloat("Preparing configuration", 730f);
		this.OLBDFLPFFHP = 1183f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 1383f;
	}

	// Token: 0x0600D0D8 RID: 53464 RVA: 0x004AD383 File Offset: 0x004AB583
	private void MGGNFEPGIJI()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.BDAPPLGLBOL();
	}

	// Token: 0x0600D0D9 RID: 53465 RVA: 0x004AD3B0 File Offset: 0x004AB5B0
	private void JOACBIEHHCE()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 622f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 145f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("_Value5", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 170f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (1972f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 519f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("_Intensity", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0DA RID: 53466 RVA: 0x004AD4C4 File Offset: 0x004AB6C4
	private void DPIPGGDNGHN()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 1185f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 910f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("#status", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 353f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (368f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 50f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("Set arcs speed. Base value - 15", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0DB RID: 53467 RVA: 0x004AD5D5 File Offset: 0x004AB7D5
	public void PGGNNIKIDJI()
	{
		AnimationFromDistance.LGILGCGIHHM = 1081f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D0DC RID: 53468 RVA: 0x004AD5E8 File Offset: 0x004AB7E8
	public void ABFGBBGNPGO()
	{
		AnimationFromDistance.LGILGCGIHHM = 840f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D0DD RID: 53469 RVA: 0x004AD5FB File Offset: 0x004AB7FB
	private void OFKDKJGIDLH()
	{
		this.EFGKBEHNOBH.SetFloat("GlassColor", 1484f);
		this.OLBDFLPFFHP = 337f;
		this.CFCECAPJCOM = true;
		AnimationFromDistance.LGILGCGIHHM = 1186f;
	}

	// Token: 0x0600D0DE RID: 53470 RVA: 0x004AD62E File Offset: 0x004AB82E
	public void KICHIJKKKDC()
	{
		AnimationFromDistance.LGILGCGIHHM = 1362f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D0DF RID: 53471 RVA: 0x004AD641 File Offset: 0x004AB841
	private void GLJIDEPMMFO()
	{
		this.EFGKBEHNOBH.SetFloat("No", 865f);
		this.OLBDFLPFFHP = 211f;
		this.CFCECAPJCOM = true;
		AnimationFromDistance.LGILGCGIHHM = 1886f;
	}

	// Token: 0x0600D0E0 RID: 53472 RVA: 0x004AD383 File Offset: 0x004AB583
	private void KGMCGGIEPDE()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.BDAPPLGLBOL();
	}

	// Token: 0x0600D0E1 RID: 53473 RVA: 0x004AD674 File Offset: 0x004AB874
	private void CFIAKIJAILI()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 1475f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1468f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("stretchWidth", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1769f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (753f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 528f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("???", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0E3 RID: 53475 RVA: 0x004AD785 File Offset: 0x004AB985
	public void Blow()
	{
		AnimationFromDistance.LGILGCGIHHM = 0f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D0E4 RID: 53476 RVA: 0x004AD798 File Offset: 0x004AB998
	private void IIFCIDDJHPM()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 102f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 973f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("_Value6", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 694f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (1330f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1562f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("#8E8E8EFF", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0E5 RID: 53477 RVA: 0x004AD8A9 File Offset: 0x004ABAA9
	public void MMIACKKBMNH()
	{
		AnimationFromDistance.LGILGCGIHHM = 1292f;
		this.CFCECAPJCOM = false;
	}

	// Token: 0x0600D0E6 RID: 53478 RVA: 0x004AD8BC File Offset: 0x004ABABC
	private void MANOCIJICLG()
	{
		this.EFGKBEHNOBH.SetFloat("CameraFilterPack/3D_BlackHole", 1011f);
		this.OLBDFLPFFHP = 1369f;
		this.CFCECAPJCOM = true;
		AnimationFromDistance.LGILGCGIHHM = 313f;
	}

	// Token: 0x0600D0E7 RID: 53479 RVA: 0x004AD8EF File Offset: 0x004ABAEF
	private void JHPDFCAGCHC()
	{
		this.EFGKBEHNOBH.SetFloat("/", 330f);
		this.OLBDFLPFFHP = 1417f;
		this.CFCECAPJCOM = true;
		AnimationFromDistance.LGILGCGIHHM = 1090f;
	}

	// Token: 0x0600D0E8 RID: 53480 RVA: 0x004AD924 File Offset: 0x004ABB24
	private void KKLMPKLKAEM()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 86f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 905f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("x", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1740f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (428f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 16f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("Joystick1Button12", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0E9 RID: 53481 RVA: 0x004ACEC1 File Offset: 0x004AB0C1
	private void NLNAJMCBNDC()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.MIFIEGOGKDA();
	}

	// Token: 0x0600D0EA RID: 53482 RVA: 0x004ADA35 File Offset: 0x004ABC35
	private void LAACNNJDKBI()
	{
		this.EFGKBEHNOBH.SetFloat("\n", 103f);
		this.OLBDFLPFFHP = 495f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 836f;
	}

	// Token: 0x0600D0EB RID: 53483 RVA: 0x004ADA68 File Offset: 0x004ABC68
	private void LHMDCEDONEE()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.Reset();
	}

	// Token: 0x0600D0EC RID: 53484 RVA: 0x004ADA92 File Offset: 0x004ABC92
	public void GCJKCJODDOD()
	{
		AnimationFromDistance.LGILGCGIHHM = 1169f;
		this.CFCECAPJCOM = false;
	}

	// Token: 0x0600D0ED RID: 53485 RVA: 0x004ADAA5 File Offset: 0x004ABCA5
	public void DJCIINMFJII()
	{
		AnimationFromDistance.LGILGCGIHHM = 1916f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D0EE RID: 53486 RVA: 0x004ADAB8 File Offset: 0x004ABCB8
	private void JAAJECBCCFM()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 253f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 839f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("GenerationMenu", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 853f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (808f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 271f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("_TimeX", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0EF RID: 53487 RVA: 0x004ADBC9 File Offset: 0x004ABDC9
	public void LLNGFJLNGPH()
	{
		AnimationFromDistance.LGILGCGIHHM = 761f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D0F0 RID: 53488 RVA: 0x004ADBDC File Offset: 0x004ABDDC
	private void LFHKGIHNONL()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.FEAPMDENLBN();
	}

	// Token: 0x0600D0F1 RID: 53489 RVA: 0x004ADC08 File Offset: 0x004ABE08
	private void OCMKCBBCEFG()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 1240f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1411f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("#highscore", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1504f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (154f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1782f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("JoinButton", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0F2 RID: 53490 RVA: 0x004ADD19 File Offset: 0x004ABF19
	private void OBPCMAFGLON()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.NELFFHHCADM();
	}

	// Token: 0x0600D0F3 RID: 53491 RVA: 0x004ADD43 File Offset: 0x004ABF43
	public void KAPJDHKDFGO()
	{
		AnimationFromDistance.LGILGCGIHHM = 1696f;
		this.CFCECAPJCOM = false;
	}

	// Token: 0x0600D0F4 RID: 53492 RVA: 0x004ADD56 File Offset: 0x004ABF56
	public void ALLLCFEJNKM()
	{
		AnimationFromDistance.LGILGCGIHHM = 1987f;
		this.CFCECAPJCOM = false;
	}

	// Token: 0x0600D0F5 RID: 53493 RVA: 0x004ADD69 File Offset: 0x004ABF69
	private void EEDLLCHIAKG()
	{
		this.EFGKBEHNOBH.SetFloat(" ", 903f);
		this.OLBDFLPFFHP = 848f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 704f;
	}

	// Token: 0x0600D0F6 RID: 53494 RVA: 0x004ADD9C File Offset: 0x004ABF9C
	private void NELFFHHCADM()
	{
		this.EFGKBEHNOBH.SetFloat("_ScreenResolution", 1225f);
		this.OLBDFLPFFHP = 209f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 1850f;
	}

	// Token: 0x0600D0F7 RID: 53495 RVA: 0x004ADDCF File Offset: 0x004ABFCF
	private void KNNOEGLLDAN()
	{
		this.EFGKBEHNOBH.SetFloat("#tryagain", 349f);
		this.OLBDFLPFFHP = 1377f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 612f;
	}

	// Token: 0x0600D0F8 RID: 53496 RVA: 0x004ADE02 File Offset: 0x004AC002
	private void MIFIEGOGKDA()
	{
		this.EFGKBEHNOBH.SetFloat(" ", 1175f);
		this.OLBDFLPFFHP = 1293f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 399f;
	}

	// Token: 0x0600D0F9 RID: 53497 RVA: 0x004ADE38 File Offset: 0x004AC038
	private void LPMINJJPDCH()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 434f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1737f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("/", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1331f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (579f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1145f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat(" ", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0FA RID: 53498 RVA: 0x004ADF4C File Offset: 0x004AC14C
	private void HIKKPDACJGI()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 1227f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1723f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("UI", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 292f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (904f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1169f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("_Bloom0", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0FB RID: 53499 RVA: 0x004AE05D File Offset: 0x004AC25D
	private void MNBMLBLLDGL()
	{
		this.EFGKBEHNOBH.SetFloat("SetParticlesParticleSize", 1973f);
		this.OLBDFLPFFHP = 473f;
		this.CFCECAPJCOM = true;
		AnimationFromDistance.LGILGCGIHHM = 175f;
	}

	// Token: 0x0600D0FC RID: 53500 RVA: 0x004AE090 File Offset: 0x004AC290
	private void EHCGBJDFMHG()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 262f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1524f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("NewMapHandsCountSlider", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1459f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (1314f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 630f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("#currentbpm: ", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0FD RID: 53501 RVA: 0x004AE1A4 File Offset: 0x004AC3A4
	private void JBNPEHMDCMI()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 451f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 757f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("No Name", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1535f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (127f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1356f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("_TimeX", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D0FE RID: 53502 RVA: 0x004AE2B5 File Offset: 0x004AC4B5
	public void MNDJJENAJCL()
	{
		AnimationFromDistance.LGILGCGIHHM = 95f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D0FF RID: 53503 RVA: 0x004AE2C8 File Offset: 0x004AC4C8
	private void EBPAOCJEJGE()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.KNNOEGLLDAN();
	}

	// Token: 0x0600D100 RID: 53504 RVA: 0x004ADA68 File Offset: 0x004ABC68
	private void Awake()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.Reset();
	}

	// Token: 0x0600D101 RID: 53505 RVA: 0x004AE2F2 File Offset: 0x004AC4F2
	private void BJIKAHNJNEB()
	{
		this.EFGKBEHNOBH.SetFloat("LeaderboardsButton", 165f);
		this.OLBDFLPFFHP = 1700f;
		this.CFCECAPJCOM = true;
		AnimationFromDistance.LGILGCGIHHM = 519f;
	}

	// Token: 0x0600D102 RID: 53506 RVA: 0x004AE328 File Offset: 0x004AC528
	private void IEMEHGCFAPD()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 751f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 778f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("_Value", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 214f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (314f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1807f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("_Red_B", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D103 RID: 53507 RVA: 0x004AE43C File Offset: 0x004AC63C
	private void HNDNDPECBPL()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 1651f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 573f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("_MainTex2", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1112f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (1468f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1611f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("_Near", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D104 RID: 53508 RVA: 0x004AE54D File Offset: 0x004AC74D
	private void LDGJGONCEND()
	{
		this.EFGKBEHNOBH.SetFloat("Prints list of commands", 67f);
		this.OLBDFLPFFHP = 1788f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 1163f;
	}

	// Token: 0x0600D105 RID: 53509 RVA: 0x004AE580 File Offset: 0x004AC780
	private void CCDNJPNLGBN()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.EEBGCGFNELO();
	}

	// Token: 0x0600D106 RID: 53510 RVA: 0x004ADA68 File Offset: 0x004ABC68
	private void HCCMANDFEPL()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.Reset();
	}

	// Token: 0x0600D107 RID: 53511 RVA: 0x004AE5AA File Offset: 0x004AC7AA
	public void ILOBCDONJKI()
	{
		AnimationFromDistance.LGILGCGIHHM = 837f;
		this.CFCECAPJCOM = false;
	}

	// Token: 0x0600D108 RID: 53512 RVA: 0x004AE5BD File Offset: 0x004AC7BD
	private void MFAMHKBMBEI()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.LAACNNJDKBI();
	}

	// Token: 0x0600D109 RID: 53513 RVA: 0x004AE5E8 File Offset: 0x004AC7E8
	private void AEIJFLJEABG()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 1808f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 342f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("/Saved Games/", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1664f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (622f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1336f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("Can not SetMasterClient(). Not in room or in offlineMode.", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D10A RID: 53514 RVA: 0x004AE6F9 File Offset: 0x004AC8F9
	private void JEEINPBLBDI()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.OFKDKJGIDLH();
	}

	// Token: 0x0600D10B RID: 53515 RVA: 0x004AE723 File Offset: 0x004AC923
	public void CMCIEBNIFAL()
	{
		AnimationFromDistance.LGILGCGIHHM = 8f;
		this.CFCECAPJCOM = false;
	}

	// Token: 0x0600D10C RID: 53516 RVA: 0x004AE736 File Offset: 0x004AC936
	private void NLBAJOJIHGM()
	{
		this.EFGKBEHNOBH.SetFloat("_DotSize", 1932f);
		this.OLBDFLPFFHP = 1401f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 912f;
	}

	// Token: 0x0600D10D RID: 53517 RVA: 0x004AE769 File Offset: 0x004AC969
	private void DAHIMKKFNPH()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.BBBNLHALLBN();
	}

	// Token: 0x0600D10E RID: 53518 RVA: 0x004AE794 File Offset: 0x004AC994
	private void BGDONBMDPGM()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 591f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1914f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("y", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1766f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (396f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 197f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("RecieveChatActionMessage", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D10F RID: 53519 RVA: 0x004AE8A8 File Offset: 0x004ACAA8
	private void IKMELABKBHO()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 1195f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1471f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("violet", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 129f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (1053f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1633f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("_Value2", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D110 RID: 53520 RVA: 0x004AE9B9 File Offset: 0x004ACBB9
	private void LIMBEFBJNPL()
	{
		this.EFGKBEHNOBH.SetFloat("14", 143f);
		this.OLBDFLPFFHP = 1715f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 221f;
	}

	// Token: 0x0600D111 RID: 53521 RVA: 0x004AE9EC File Offset: 0x004ACBEC
	private void EEBGCGFNELO()
	{
		this.EFGKBEHNOBH.SetFloat("OK", 525f);
		this.OLBDFLPFFHP = 752f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 1107f;
	}

	// Token: 0x0600D112 RID: 53522 RVA: 0x004AEA1F File Offset: 0x004ACC1F
	private void NALOPIJDJCM()
	{
		this.EFGKBEHNOBH.SetFloat("EnvironmentSlider", 592f);
		this.OLBDFLPFFHP = 225f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 779f;
	}

	// Token: 0x0600D113 RID: 53523 RVA: 0x004ACEC1 File Offset: 0x004AB0C1
	private void OLFNCABJBHA()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.MIFIEGOGKDA();
	}

	// Token: 0x0600D114 RID: 53524 RVA: 0x004AEA52 File Offset: 0x004ACC52
	public void MPLOJJAMAOC()
	{
		AnimationFromDistance.LGILGCGIHHM = 1485f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D115 RID: 53525 RVA: 0x004AEA68 File Offset: 0x004ACC68
	private void Update()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 1f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("time", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 0.4f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (1f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 0f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("time", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D116 RID: 53526 RVA: 0x004AEB79 File Offset: 0x004ACD79
	private void ABDHDGNIHHI()
	{
		this.EFGKBEHNOBH.SetFloat("Item created: Id: ", 97f);
		this.OLBDFLPFFHP = 1102f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 1074f;
	}

	// Token: 0x0600D117 RID: 53527 RVA: 0x004AEBAC File Offset: 0x004ACDAC
	public void ICOFJDNIFHM()
	{
		AnimationFromDistance.LGILGCGIHHM = 400f;
		this.CFCECAPJCOM = false;
	}

	// Token: 0x0600D118 RID: 53528 RVA: 0x004AEBBF File Offset: 0x004ACDBF
	public void IMIOENPJAAB()
	{
		AnimationFromDistance.LGILGCGIHHM = 1244f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D119 RID: 53529 RVA: 0x004AEBD2 File Offset: 0x004ACDD2
	private void BDAPPLGLBOL()
	{
		this.EFGKBEHNOBH.SetFloat("_ScreenResolution", 1671f);
		this.OLBDFLPFFHP = 1774f;
		this.CFCECAPJCOM = true;
		AnimationFromDistance.LGILGCGIHHM = 865f;
	}

	// Token: 0x0600D11A RID: 53530 RVA: 0x004AEC08 File Offset: 0x004ACE08
	private void OBAEDJJDCPN()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 1086f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 174f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat(" not exist", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 249f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (811f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1760f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("[BuildInfo] Error: ", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D11B RID: 53531 RVA: 0x004AED1C File Offset: 0x004ACF1C
	private void DNENFLNCIJP()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 199f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1751f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("buttons", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 181f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (631f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1574f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("Could not execute RPC ", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D11C RID: 53532 RVA: 0x004AEE30 File Offset: 0x004AD030
	private void PHJJHFBLICM()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 1116f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 1127f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("CameraFilterPack/Blend2Camera_Luminosity", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 197f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (1455f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 125f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("Jump", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D11D RID: 53533 RVA: 0x004AEF41 File Offset: 0x004AD141
	public void DJANNMFGNCC()
	{
		AnimationFromDistance.LGILGCGIHHM = 82f;
		this.CFCECAPJCOM = true;
	}

	// Token: 0x0600D11E RID: 53534 RVA: 0x004AEF54 File Offset: 0x004AD154
	private void GAOMPMFOJNC()
	{
		this.EFGKBEHNOBH.SetFloat("id", 1848f);
		this.OLBDFLPFFHP = 1201f;
		this.CFCECAPJCOM = false;
		AnimationFromDistance.LGILGCGIHHM = 1920f;
	}

	// Token: 0x0600D11F RID: 53535 RVA: 0x004AEF88 File Offset: 0x004AD188
	private void MFMIODIAKNI()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 1760f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 565f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("_Offsets", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1095f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (1293f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 414f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("GlassColor", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D120 RID: 53536 RVA: 0x004AF099 File Offset: 0x004AD299
	private void GEPELODHBFN()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.BJIKAHNJNEB();
	}

	// Token: 0x0600D121 RID: 53537 RVA: 0x004AF0C4 File Offset: 0x004AD2C4
	private void JNBPKNNBMDI()
	{
		if (!this.CFCECAPJCOM)
		{
			float num = 767f;
			if (Mathf.Abs(this.OJICGBOIKNA.localPosition.z) < this.MPNMOONBMII)
			{
				num = 450f;
			}
			else if (this.OJICGBOIKNA.localPosition.z <= -this.MPNMOONBMII)
			{
				num = (this.IIFGDPMOKOO - Mathf.Abs(this.OJICGBOIKNA.localPosition.z + this.MPNMOONBMII)) / this.IIFGDPMOKOO;
			}
			this.EFGKBEHNOBH.SetFloat("_ScreenResolution", Mathf.Clamp01(num));
			this.OLBDFLPFFHP = num;
		}
		else
		{
			float num2 = 1475f;
			AnimationFromDistance.LGILGCGIHHM += Time.deltaTime * (295f / num2);
			float num3 = Mathf.Lerp(this.OLBDFLPFFHP, 1814f, AnimationFromDistance.LGILGCGIHHM);
			this.EFGKBEHNOBH.SetFloat("ItemsStoreButton", Mathf.Clamp01(num3));
			this.OLBDFLPFFHP = num3;
		}
	}

	// Token: 0x0600D122 RID: 53538 RVA: 0x004AF1D5 File Offset: 0x004AD3D5
	private void KEKNHAAEPCJ()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.EEDLLCHIAKG();
	}

	// Token: 0x0600D123 RID: 53539 RVA: 0x004AF1FF File Offset: 0x004AD3FF
	private void GCMLEEHGBPA()
	{
		this.EFGKBEHNOBH.SetFloat("/", 951f);
		this.OLBDFLPFFHP = 1617f;
		this.CFCECAPJCOM = true;
		AnimationFromDistance.LGILGCGIHHM = 1594f;
	}

	// Token: 0x0600D124 RID: 53540 RVA: 0x004AF232 File Offset: 0x004AD432
	public void LEIHAKCEKID()
	{
		AnimationFromDistance.LGILGCGIHHM = 502f;
		this.CFCECAPJCOM = false;
	}

	// Token: 0x0600D125 RID: 53541 RVA: 0x004AF245 File Offset: 0x004AD445
	private void FNMPIAMIKCP()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.LIMBEFBJNPL();
	}

	// Token: 0x0600D127 RID: 53543 RVA: 0x004ADD19 File Offset: 0x004ABF19
	private void PHHOMLJECOJ()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.NELFFHHCADM();
	}

	// Token: 0x0600D128 RID: 53544 RVA: 0x004AF28D File Offset: 0x004AD48D
	private void LHIBPEGLPHM()
	{
		this.EFGKBEHNOBH.SetFloat("LevelEditor/patterns", 1326f);
		this.OLBDFLPFFHP = 986f;
		this.CFCECAPJCOM = true;
		AnimationFromDistance.LGILGCGIHHM = 1009f;
	}

	// Token: 0x0600D129 RID: 53545 RVA: 0x004AD011 File Offset: 0x004AB211
	private void JIJPHEDDIHC()
	{
		this.EFGKBEHNOBH = base.GetComponent<Animator>();
		this.OJICGBOIKNA = base.transform.parent.transform;
		this.GLJIDEPMMFO();
	}

	// Token: 0x040017FD RID: 6141
	private float MPNMOONBMII = 5f;

	// Token: 0x040017FE RID: 6142
	private float IIFGDPMOKOO = 10f;

	// Token: 0x040017FF RID: 6143
	private Animator EFGKBEHNOBH;

	// Token: 0x04001800 RID: 6144
	private Transform OJICGBOIKNA;

	// Token: 0x04001801 RID: 6145
	private bool CFCECAPJCOM;

	// Token: 0x04001802 RID: 6146
	private static float LGILGCGIHHM;

	// Token: 0x04001803 RID: 6147
	private float OLBDFLPFFHP;
}
