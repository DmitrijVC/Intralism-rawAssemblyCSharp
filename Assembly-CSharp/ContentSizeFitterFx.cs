using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200040E RID: 1038
public class ContentSizeFitterFx : MonoBehaviour
{
	// Token: 0x0600EDA1 RID: 60833 RVA: 0x005383AC File Offset: 0x005365AC
	private void Update()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.RunFix());
		}
	}

	// Token: 0x0600EDA2 RID: 60834 RVA: 0x00538400 File Offset: 0x00536600
	private void ONKDMMJPEMN()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.PBIPCILMAOC());
		}
	}

	// Token: 0x0600EDA3 RID: 60835 RVA: 0x00538451 File Offset: 0x00536651
	public void GJPPMLPGDHO()
	{
		this.OEPJENMMKIG = false;
	}

	// Token: 0x0600EDA4 RID: 60836 RVA: 0x0053845C File Offset: 0x0053665C
	public IEnumerator OAKKDDEAIBN()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDA5 RID: 60837 RVA: 0x00538477 File Offset: 0x00536677
	public void BPAJLJBPPEP()
	{
		this.OEPJENMMKIG = true;
	}

	// Token: 0x0600EDA6 RID: 60838 RVA: 0x00538480 File Offset: 0x00536680
	private void LCDJFJIBADI()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.MDDADJIHOJP());
		}
	}

	// Token: 0x0600EDA7 RID: 60839 RVA: 0x005384D4 File Offset: 0x005366D4
	private void KDJEJBBDILE()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.COFOOEGOLFA());
		}
	}

	// Token: 0x0600EDA8 RID: 60840 RVA: 0x00538528 File Offset: 0x00536728
	public IEnumerator JDCFAOHDFIN()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDA9 RID: 60841 RVA: 0x00538544 File Offset: 0x00536744
	public IEnumerator COFOOEGOLFA()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDAA RID: 60842 RVA: 0x0053855F File Offset: 0x0053675F
	private void CCLNNLCOPBL()
	{
		this.GJPPMLPGDHO();
	}

	// Token: 0x0600EDAB RID: 60843 RVA: 0x00538451 File Offset: 0x00536651
	public void LJBPHNIEMKO()
	{
		this.OEPJENMMKIG = false;
	}

	// Token: 0x0600EDAC RID: 60844 RVA: 0x00538568 File Offset: 0x00536768
	public IEnumerator LGGLNEGBHPB()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDAD RID: 60845 RVA: 0x00538583 File Offset: 0x00536783
	private void Start()
	{
		this.DoFix();
	}

	// Token: 0x0600EDAE RID: 60846 RVA: 0x0053858C File Offset: 0x0053678C
	public IEnumerator AHALHEPONLD()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDAF RID: 60847 RVA: 0x00538451 File Offset: 0x00536651
	public void DoFix()
	{
		this.OEPJENMMKIG = false;
	}

	// Token: 0x0600EDB0 RID: 60848 RVA: 0x005385A8 File Offset: 0x005367A8
	public IEnumerator OAPNHIPPDBG()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDB1 RID: 60849 RVA: 0x00538451 File Offset: 0x00536651
	public void DEIBEBOEPPK()
	{
		this.OEPJENMMKIG = false;
	}

	// Token: 0x0600EDB2 RID: 60850 RVA: 0x005385C3 File Offset: 0x005367C3
	private void GLEJGFLCLPJ()
	{
		this.LDGICPAAKHO();
	}

	// Token: 0x0600EDB3 RID: 60851 RVA: 0x005385CC File Offset: 0x005367CC
	public IEnumerator BKGOINFBAMJ()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDB4 RID: 60852 RVA: 0x005385E8 File Offset: 0x005367E8
	public IEnumerator MDDADJIHOJP()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDB5 RID: 60853 RVA: 0x00538603 File Offset: 0x00536803
	private void JKBMKPDGCHG()
	{
		this.ENBIIDLGAID();
	}

	// Token: 0x0600EDB6 RID: 60854 RVA: 0x0053860C File Offset: 0x0053680C
	public IEnumerator ENGDDMDBGFH()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDB7 RID: 60855 RVA: 0x00538628 File Offset: 0x00536828
	private void BGDONBMDPGM()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.AHHDHBNKFEG());
		}
	}

	// Token: 0x0600EDB8 RID: 60856 RVA: 0x00538477 File Offset: 0x00536677
	public void LAEIHIHMKNG()
	{
		this.OEPJENMMKIG = true;
	}

	// Token: 0x0600EDB9 RID: 60857 RVA: 0x0053867C File Offset: 0x0053687C
	private void EHCGBJDFMHG()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.OAKKDDEAIBN());
		}
	}

	// Token: 0x0600EDBA RID: 60858 RVA: 0x005386D0 File Offset: 0x005368D0
	public IEnumerator FJJOIELAMOG()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDBB RID: 60859 RVA: 0x00538451 File Offset: 0x00536651
	public void FHNHEBMLGNI()
	{
		this.OEPJENMMKIG = false;
	}

	// Token: 0x0600EDBC RID: 60860 RVA: 0x00538583 File Offset: 0x00536783
	private void JFJLGJEPEAA()
	{
		this.DoFix();
	}

	// Token: 0x0600EDBD RID: 60861 RVA: 0x005386EC File Offset: 0x005368EC
	private void LLJLDLLNFBH()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.HGJBDAAFKBM());
		}
	}

	// Token: 0x0600EDBE RID: 60862 RVA: 0x00538740 File Offset: 0x00536940
	public IEnumerator IDPBCFBOBJP()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDC0 RID: 60864 RVA: 0x0053875B File Offset: 0x0053695B
	private void PDHKMDBNGGN()
	{
		this.AOFJKDNPLAB();
	}

	// Token: 0x0600EDC1 RID: 60865 RVA: 0x00538477 File Offset: 0x00536677
	public void AOFJKDNPLAB()
	{
		this.OEPJENMMKIG = true;
	}

	// Token: 0x0600EDC2 RID: 60866 RVA: 0x00538764 File Offset: 0x00536964
	public IEnumerator AHHDHBNKFEG()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDC3 RID: 60867 RVA: 0x00538780 File Offset: 0x00536980
	private void JBCNIPJDPJB()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.IIBOBNHHGCK());
		}
	}

	// Token: 0x0600EDC4 RID: 60868 RVA: 0x005387D4 File Offset: 0x005369D4
	private void HIFLPHLGLFG()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.OAKKDDEAIBN());
		}
	}

	// Token: 0x0600EDC5 RID: 60869 RVA: 0x00538828 File Offset: 0x00536A28
	private void HCIPECAOGIA()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.AHALHEPONLD());
		}
	}

	// Token: 0x0600EDC6 RID: 60870 RVA: 0x00538879 File Offset: 0x00536A79
	private void HLIAEEMGBHN()
	{
		this.FAGNHANLGAN();
	}

	// Token: 0x0600EDC7 RID: 60871 RVA: 0x00538884 File Offset: 0x00536A84
	private void CGBHOELMAOC()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.FLANIEFNAAI());
		}
	}

	// Token: 0x0600EDC8 RID: 60872 RVA: 0x005388D5 File Offset: 0x00536AD5
	private void IDJKNBDKHBD()
	{
		this.BEKGHFBPCNC();
	}

	// Token: 0x0600EDC9 RID: 60873 RVA: 0x005388DD File Offset: 0x00536ADD
	private void OKLAJINHPAN()
	{
		this.PLPHEBNKDGA();
	}

	// Token: 0x0600EDCA RID: 60874 RVA: 0x005388E8 File Offset: 0x00536AE8
	public IEnumerator PPNKOMMDAPD()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDCB RID: 60875 RVA: 0x005388DD File Offset: 0x00536ADD
	private void LGHCJCFHEMF()
	{
		this.PLPHEBNKDGA();
	}

	// Token: 0x0600EDCC RID: 60876 RVA: 0x00538904 File Offset: 0x00536B04
	private void BGFJOEPFOPM()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.NOBOCGLGFFD());
		}
	}

	// Token: 0x0600EDCD RID: 60877 RVA: 0x00538958 File Offset: 0x00536B58
	public IEnumerator ABEOMIHEDLN()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDCE RID: 60878 RVA: 0x00538974 File Offset: 0x00536B74
	private void PFNFPINPCMH()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.NOBOCGLGFFD());
		}
	}

	// Token: 0x0600EDCF RID: 60879 RVA: 0x00538451 File Offset: 0x00536651
	public void NOGJCBJLPPI()
	{
		this.OEPJENMMKIG = false;
	}

	// Token: 0x0600EDD0 RID: 60880 RVA: 0x005389C5 File Offset: 0x00536BC5
	private void FLKEJJEGCFA()
	{
		this.FHNHEBMLGNI();
	}

	// Token: 0x0600EDD1 RID: 60881 RVA: 0x005389CD File Offset: 0x00536BCD
	private void DKGBFNCOAEO()
	{
		this.OEBICOOHMBF();
	}

	// Token: 0x0600EDD2 RID: 60882 RVA: 0x00538603 File Offset: 0x00536803
	private void DOKAKEMDALN()
	{
		this.ENBIIDLGAID();
	}

	// Token: 0x0600EDD3 RID: 60883 RVA: 0x005389D5 File Offset: 0x00536BD5
	private void GPNAOAKCMHC()
	{
		this.DEIBEBOEPPK();
	}

	// Token: 0x0600EDD4 RID: 60884 RVA: 0x005389E0 File Offset: 0x00536BE0
	private void AEIJFLJEABG()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.INFHBGJLHBH());
		}
	}

	// Token: 0x0600EDD5 RID: 60885 RVA: 0x00538A34 File Offset: 0x00536C34
	public IEnumerator CGNAEGHBBDJ()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDD6 RID: 60886 RVA: 0x00538451 File Offset: 0x00536651
	public void KLGENHIIIBK()
	{
		this.OEPJENMMKIG = false;
	}

	// Token: 0x0600EDD7 RID: 60887 RVA: 0x0053875B File Offset: 0x0053695B
	private void NPLCENPNJBM()
	{
		this.AOFJKDNPLAB();
	}

	// Token: 0x0600EDD8 RID: 60888 RVA: 0x00538A4F File Offset: 0x00536C4F
	private void CGDMLHLJIDK()
	{
		this.LAEIHIHMKNG();
	}

	// Token: 0x0600EDD9 RID: 60889 RVA: 0x00538A57 File Offset: 0x00536C57
	private void DNNFHBOOPIN()
	{
		this.OABFKACDOFO();
	}

	// Token: 0x0600EDDA RID: 60890 RVA: 0x00538A60 File Offset: 0x00536C60
	private void KCDOMIJBFLL()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.MKGMGJJIELK());
		}
	}

	// Token: 0x0600EDDB RID: 60891 RVA: 0x00538AB1 File Offset: 0x00536CB1
	private void IMCKJCHKMKB()
	{
		this.KLGENHIIIBK();
	}

	// Token: 0x0600EDDC RID: 60892 RVA: 0x00538451 File Offset: 0x00536651
	public void DJJADJFADJI()
	{
		this.OEPJENMMKIG = false;
	}

	// Token: 0x0600EDDD RID: 60893 RVA: 0x00538ABC File Offset: 0x00536CBC
	public IEnumerator IPFKCJENGAC()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDDE RID: 60894 RVA: 0x00538451 File Offset: 0x00536651
	public void ENBIIDLGAID()
	{
		this.OEPJENMMKIG = false;
	}

	// Token: 0x0600EDDF RID: 60895 RVA: 0x00538AD8 File Offset: 0x00536CD8
	private void IBFJAOINHMK()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.FJJOIELAMOG());
		}
	}

	// Token: 0x0600EDE0 RID: 60896 RVA: 0x00538B2C File Offset: 0x00536D2C
	private void ODCJJFBJJNF()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.COFOOEGOLFA());
		}
	}

	// Token: 0x0600EDE1 RID: 60897 RVA: 0x00538477 File Offset: 0x00536677
	public void OABFKACDOFO()
	{
		this.OEPJENMMKIG = true;
	}

	// Token: 0x0600EDE2 RID: 60898 RVA: 0x00538B7D File Offset: 0x00536D7D
	private void LBAJLLFMMMP()
	{
		this.LFOLDLFCFED();
	}

	// Token: 0x0600EDE3 RID: 60899 RVA: 0x00538B88 File Offset: 0x00536D88
	public IEnumerator FLANIEFNAAI()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDE4 RID: 60900 RVA: 0x005389C5 File Offset: 0x00536BC5
	private void LFAFJKJAEEL()
	{
		this.FHNHEBMLGNI();
	}

	// Token: 0x0600EDE5 RID: 60901 RVA: 0x00538BA4 File Offset: 0x00536DA4
	private void MDCFIHDPLIG()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.CGNAEGHBBDJ());
		}
	}

	// Token: 0x0600EDE6 RID: 60902 RVA: 0x00538451 File Offset: 0x00536651
	public void BEKGHFBPCNC()
	{
		this.OEPJENMMKIG = false;
	}

	// Token: 0x0600EDE7 RID: 60903 RVA: 0x00538BF8 File Offset: 0x00536DF8
	private void HNDNDPECBPL()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.ELMCDLKBCKK());
		}
	}

	// Token: 0x0600EDE8 RID: 60904 RVA: 0x00538C4C File Offset: 0x00536E4C
	public IEnumerator PBIPCILMAOC()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDE9 RID: 60905 RVA: 0x005389CD File Offset: 0x00536BCD
	private void JILOMOBDPIA()
	{
		this.OEBICOOHMBF();
	}

	// Token: 0x0600EDEA RID: 60906 RVA: 0x00538477 File Offset: 0x00536677
	public void LFOLDLFCFED()
	{
		this.OEPJENMMKIG = true;
	}

	// Token: 0x0600EDEB RID: 60907 RVA: 0x00538477 File Offset: 0x00536677
	public void CNPICMKOEOK()
	{
		this.OEPJENMMKIG = true;
	}

	// Token: 0x0600EDEC RID: 60908 RVA: 0x0053855F File Offset: 0x0053675F
	private void JOPCCCCHNLI()
	{
		this.GJPPMLPGDHO();
	}

	// Token: 0x0600EDED RID: 60909 RVA: 0x00538C68 File Offset: 0x00536E68
	public IEnumerator MDCHJDCJHKJ()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDEE RID: 60910 RVA: 0x00538C83 File Offset: 0x00536E83
	private void ALJEJJCIMJN()
	{
		this.APCHMCEFHAL();
	}

	// Token: 0x0600EDEF RID: 60911 RVA: 0x005385C3 File Offset: 0x005367C3
	private void CNGAJDBOCLJ()
	{
		this.LDGICPAAKHO();
	}

	// Token: 0x0600EDF0 RID: 60912 RVA: 0x005389D5 File Offset: 0x00536BD5
	private void HPFOFGJPNCI()
	{
		this.DEIBEBOEPPK();
	}

	// Token: 0x0600EDF1 RID: 60913 RVA: 0x00538C8C File Offset: 0x00536E8C
	public IEnumerator ANKDOLLBGDD()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDF2 RID: 60914 RVA: 0x00538477 File Offset: 0x00536677
	public void PLPHEBNKDGA()
	{
		this.OEPJENMMKIG = true;
	}

	// Token: 0x0600EDF3 RID: 60915 RVA: 0x00538477 File Offset: 0x00536677
	public void FAGNHANLGAN()
	{
		this.OEPJENMMKIG = true;
	}

	// Token: 0x0600EDF4 RID: 60916 RVA: 0x00538477 File Offset: 0x00536677
	public void APCHMCEFHAL()
	{
		this.OEPJENMMKIG = true;
	}

	// Token: 0x0600EDF5 RID: 60917 RVA: 0x00538CA8 File Offset: 0x00536EA8
	private void MECJHOJPODB()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.PPNKOMMDAPD());
		}
	}

	// Token: 0x0600EDF6 RID: 60918 RVA: 0x00538477 File Offset: 0x00536677
	public void KBGBMIHOPLF()
	{
		this.OEPJENMMKIG = true;
	}

	// Token: 0x0600EDF7 RID: 60919 RVA: 0x00538CFC File Offset: 0x00536EFC
	public IEnumerator PNBKFJIHDGC()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDF8 RID: 60920 RVA: 0x00538D18 File Offset: 0x00536F18
	public IEnumerator MKGMGJJIELK()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDF9 RID: 60921 RVA: 0x00538D34 File Offset: 0x00536F34
	public IEnumerator HGJBDAAFKBM()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDFA RID: 60922 RVA: 0x00538D50 File Offset: 0x00536F50
	public IEnumerator NOBOCGLGFFD()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDFB RID: 60923 RVA: 0x00538D6C File Offset: 0x00536F6C
	public IEnumerator INFHBGJLHBH()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDFC RID: 60924 RVA: 0x00538D88 File Offset: 0x00536F88
	public IEnumerator RunFix()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDFD RID: 60925 RVA: 0x00538DA4 File Offset: 0x00536FA4
	public IEnumerator CMENLDIKOGJ()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EDFE RID: 60926 RVA: 0x00538451 File Offset: 0x00536651
	public void IEJKGNLANAE()
	{
		this.OEPJENMMKIG = false;
	}

	// Token: 0x0600EDFF RID: 60927 RVA: 0x005385C3 File Offset: 0x005367C3
	private void EIMNPCMHJLJ()
	{
		this.LDGICPAAKHO();
	}

	// Token: 0x0600EE00 RID: 60928 RVA: 0x00538DC0 File Offset: 0x00536FC0
	public IEnumerator ELMCDLKBCKK()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EE01 RID: 60929 RVA: 0x00538DDB File Offset: 0x00536FDB
	private void PAKPHKPDKGE()
	{
		this.KBGBMIHOPLF();
	}

	// Token: 0x0600EE02 RID: 60930 RVA: 0x00538DE4 File Offset: 0x00536FE4
	public IEnumerator IIBOBNHHGCK()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EE03 RID: 60931 RVA: 0x00538E00 File Offset: 0x00537000
	public IEnumerator ICFEFPIGPFC()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EE04 RID: 60932 RVA: 0x00538451 File Offset: 0x00536651
	public void EEPGGDBCKDF()
	{
		this.OEPJENMMKIG = false;
	}

	// Token: 0x0600EE05 RID: 60933 RVA: 0x00538603 File Offset: 0x00536803
	private void NBGIMIDICKE()
	{
		this.ENBIIDLGAID();
	}

	// Token: 0x0600EE06 RID: 60934 RVA: 0x00538A4F File Offset: 0x00536C4F
	private void CFFCLAHMBAA()
	{
		this.LAEIHIHMKNG();
	}

	// Token: 0x0600EE07 RID: 60935 RVA: 0x00538E1C File Offset: 0x0053701C
	private void FABKIGNFECE()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.MKGMGJJIELK());
		}
	}

	// Token: 0x0600EE08 RID: 60936 RVA: 0x00538477 File Offset: 0x00536677
	public void OEBICOOHMBF()
	{
		this.OEPJENMMKIG = true;
	}

	// Token: 0x0600EE09 RID: 60937 RVA: 0x00538E6D File Offset: 0x0053706D
	private void FIKFJDFELIP()
	{
		this.DJJADJFADJI();
	}

	// Token: 0x0600EE0A RID: 60938 RVA: 0x00538E78 File Offset: 0x00537078
	private void COGBDFKOHKK()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.IPFKCJENGAC());
		}
	}

	// Token: 0x0600EE0B RID: 60939 RVA: 0x00538ECC File Offset: 0x005370CC
	public IEnumerator LCDKMHEGHJN()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EE0C RID: 60940 RVA: 0x00538EE8 File Offset: 0x005370E8
	public IEnumerator NLOJOMGEGNG()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EE0D RID: 60941 RVA: 0x00538F04 File Offset: 0x00537104
	private void IKIDIJLIGOH()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.AHALHEPONLD());
		}
	}

	// Token: 0x0600EE0E RID: 60942 RVA: 0x00538451 File Offset: 0x00536651
	public void LDGICPAAKHO()
	{
		this.OEPJENMMKIG = false;
	}

	// Token: 0x0600EE0F RID: 60943 RVA: 0x005389CD File Offset: 0x00536BCD
	private void FANADGBGCPI()
	{
		this.OEBICOOHMBF();
	}

	// Token: 0x0600EE10 RID: 60944 RVA: 0x00538B7D File Offset: 0x00536D7D
	private void CIPKEPDELJB()
	{
		this.LFOLDLFCFED();
	}

	// Token: 0x0600EE11 RID: 60945 RVA: 0x00538F58 File Offset: 0x00537158
	private void FBMDHDBELEK()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.IIBOBNHHGCK());
		}
	}

	// Token: 0x0600EE12 RID: 60946 RVA: 0x00538FAC File Offset: 0x005371AC
	public IEnumerator DPCDAONEBPK()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EE13 RID: 60947 RVA: 0x00538FC8 File Offset: 0x005371C8
	private void IKMELABKBHO()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.AHALHEPONLD());
		}
	}

	// Token: 0x0600EE14 RID: 60948 RVA: 0x0053901C File Offset: 0x0053721C
	public IEnumerator CLCOLEIKEJD()
	{
		if (this.csf)
		{
			this.csf.enabled = false;
		}
		yield return new WaitForFixedUpdate();
		if (this.csf)
		{
			this.csf.enabled = true;
		}
		this.OEPJENMMKIG = true;
		yield break;
	}

	// Token: 0x0600EE15 RID: 60949 RVA: 0x00539038 File Offset: 0x00537238
	private void JHPOIOELNCG()
	{
		if (!this.OEPJENMMKIG)
		{
			if (!this.csf && base.GetComponent<ContentSizeFitter>())
			{
				this.csf = base.GetComponent<ContentSizeFitter>();
			}
			base.StartCoroutine(this.AHHDHBNKFEG());
		}
	}

	// Token: 0x04001A9E RID: 6814
	public ContentSizeFitter csf;

	// Token: 0x04001A9F RID: 6815
	private bool OEPJENMMKIG;
}
