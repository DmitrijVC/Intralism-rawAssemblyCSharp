using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SunCubeStudio.Localization;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000468 RID: 1128
public class SliderValueLabel : MonoBehaviour
{
	// Token: 0x06010245 RID: 66117 RVA: 0x005888DA File Offset: 0x00586ADA
	private void MKIMDFLBFOM()
	{
		this.MPNBGMNPFNJ();
	}

	// Token: 0x06010246 RID: 66118 RVA: 0x005888E2 File Offset: 0x00586AE2
	private void KKLMPKLKAEM()
	{
		this.ILBEEBHIDEG();
	}

	// Token: 0x06010247 RID: 66119 RVA: 0x005888EA File Offset: 0x00586AEA
	private void AKHCOBHHGJP()
	{
		this.FAGCFADJMDI();
	}

	// Token: 0x06010248 RID: 66120 RVA: 0x005888F2 File Offset: 0x00586AF2
	private void JMEOGJHCONJ()
	{
		this.OIBELCAKKHH();
	}

	// Token: 0x06010249 RID: 66121 RVA: 0x005888FA File Offset: 0x00586AFA
	private void CGDMLHLJIDK()
	{
		this.DHECOKJKOIG();
	}

	// Token: 0x0601024A RID: 66122 RVA: 0x00588902 File Offset: 0x00586B02
	private void MJNPIDGNJMK()
	{
		this.JOLJFGLFNCK();
	}

	// Token: 0x0601024B RID: 66123 RVA: 0x0058890C File Offset: 0x00586B0C
	public void NGLIPNLHBFK()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 0 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.FIPCLHEKKCA)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.HOPMEAJKPHL(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.DAICIOGOPNL)).value) + this.textAfter;
		}
	}

	// Token: 0x0601024C RID: 66124 RVA: 0x00588A08 File Offset: 0x00586C08
	public void OIBELCAKKHH()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 0 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.HBJFIOJFBHC)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.GetLocalizatedText(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.HNMFCOHLALO)).value) + this.textAfter;
		}
	}

	// Token: 0x0601024D RID: 66125 RVA: 0x00588B04 File Offset: 0x00586D04
	public void FJMDFKMLIJC()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 1 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.BDGDIDPDBHG)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.GetLocalizatedText(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.KFNPHCCAJFD)).value) + this.textAfter;
		}
	}

	// Token: 0x0601024E RID: 66126 RVA: 0x005888E2 File Offset: 0x00586AE2
	private void PFNFPINPCMH()
	{
		this.ILBEEBHIDEG();
	}

	// Token: 0x0601024F RID: 66127 RVA: 0x00588BFE File Offset: 0x00586DFE
	private void LCDJFJIBADI()
	{
		this.FAODNNBJEML();
	}

	// Token: 0x06010250 RID: 66128 RVA: 0x00588C06 File Offset: 0x00586E06
	private void EHCGBJDFMHG()
	{
		this.IOMCOLOEHFL();
	}

	// Token: 0x06010251 RID: 66129 RVA: 0x00588C0E File Offset: 0x00586E0E
	private void AEEGKLABFLN()
	{
		this.POFHAJFLAPK();
	}

	// Token: 0x06010252 RID: 66130 RVA: 0x00588C16 File Offset: 0x00586E16
	private void GMELGGJOPBB()
	{
		this.NGLIPNLHBFK();
	}

	// Token: 0x06010253 RID: 66131 RVA: 0x005888EA File Offset: 0x00586AEA
	private void BGDPIHMAACO()
	{
		this.FAGCFADJMDI();
	}

	// Token: 0x06010254 RID: 66132 RVA: 0x00588C1E File Offset: 0x00586E1E
	private void MDCFIHDPLIG()
	{
		this.NNFCMCBGICF();
	}

	// Token: 0x06010255 RID: 66133 RVA: 0x00588C26 File Offset: 0x00586E26
	private void JKFDDNMPOJH()
	{
		this.LMJPEEKJGPK();
	}

	// Token: 0x06010256 RID: 66134 RVA: 0x00588C30 File Offset: 0x00586E30
	public void HMFLACFDMAA()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 1 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.BDGDIDPDBHG)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.HOPMEAJKPHL(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.HMMBBDJNGGL)).value) + this.textAfter;
		}
	}

	// Token: 0x06010257 RID: 66135 RVA: 0x00588C0E File Offset: 0x00586E0E
	private void JOACBIEHHCE()
	{
		this.POFHAJFLAPK();
	}

	// Token: 0x06010258 RID: 66136 RVA: 0x00588D2C File Offset: 0x00586F2C
	public void FAGCFADJMDI()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 1 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.FIPCLHEKKCA)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.GetLocalizatedText(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.DIOBKCECBCH)).value) + this.textAfter;
		}
	}

	// Token: 0x06010259 RID: 66137 RVA: 0x00588E26 File Offset: 0x00587026
	private void HLDFOJMHKNL()
	{
		this.IODAIHCJOMN();
	}

	// Token: 0x0601025A RID: 66138 RVA: 0x00588E30 File Offset: 0x00587030
	public void NKDIBKDAENF()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 1 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.OFHCGKJFGDI)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.HOPMEAJKPHL(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.LKLABDAJAEH)).value) + this.textAfter;
		}
	}

	// Token: 0x0601025B RID: 66139 RVA: 0x00588F2C File Offset: 0x0058712C
	public void HOHFDDNCGCC()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 1 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.FIPCLHEKKCA)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.HOPMEAJKPHL(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.HMMBBDJNGGL)).value) + this.textAfter;
		}
	}

	// Token: 0x0601025C RID: 66140 RVA: 0x00588C06 File Offset: 0x00586E06
	private void DPLLKHHLDBB()
	{
		this.IOMCOLOEHFL();
	}

	// Token: 0x0601025D RID: 66141 RVA: 0x00589026 File Offset: 0x00587226
	private void AEMGPJDJGBJ()
	{
		this.IEAMEOBKGBP();
	}

	// Token: 0x0601025E RID: 66142 RVA: 0x00588C1E File Offset: 0x00586E1E
	private void LBIOIEANMGI()
	{
		this.NNFCMCBGICF();
	}

	// Token: 0x0601025F RID: 66143 RVA: 0x0058902E File Offset: 0x0058722E
	private void FOLDLDLFFLM()
	{
		this.MOAGIBHBDGJ();
	}

	// Token: 0x06010260 RID: 66144 RVA: 0x00589036 File Offset: 0x00587236
	private void MAOCOEGAFND()
	{
		this.DLHNBKDMPIO();
	}

	// Token: 0x06010261 RID: 66145 RVA: 0x0058903E File Offset: 0x0058723E
	private void KDMKDEKCELE()
	{
		this.EKMAGCOPLPD();
	}

	// Token: 0x06010262 RID: 66146 RVA: 0x00588C26 File Offset: 0x00586E26
	private void IKMELABKBHO()
	{
		this.LMJPEEKJGPK();
	}

	// Token: 0x06010263 RID: 66147 RVA: 0x00589046 File Offset: 0x00587246
	private void IEMEHGCFAPD()
	{
		this.GCFNHPDPOOL();
	}

	// Token: 0x06010264 RID: 66148 RVA: 0x00589050 File Offset: 0x00587250
	public void DLHNBKDMPIO()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 1 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.OFHCGKJFGDI)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.GetLocalizatedText(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.HNMFCOHLALO)).value) + this.textAfter;
		}
	}

	// Token: 0x06010265 RID: 66149 RVA: 0x0058914A File Offset: 0x0058734A
	private void DKOPKPBLDHH()
	{
		this.GFMKDMAKECF();
	}

	// Token: 0x06010266 RID: 66150 RVA: 0x005888F2 File Offset: 0x00586AF2
	private void EIMNPCMHJLJ()
	{
		this.OIBELCAKKHH();
	}

	// Token: 0x06010267 RID: 66151 RVA: 0x00589154 File Offset: 0x00587354
	public void DFMLOIEKHLG()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 0 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.KFNBKFELFLH)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.GetLocalizatedText(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.LKLABDAJAEH)).value) + this.textAfter;
		}
	}

	// Token: 0x06010268 RID: 66152 RVA: 0x0058924E File Offset: 0x0058744E
	private void DLBODOFAJGM()
	{
		this.KCOBKOMDIKN();
	}

	// Token: 0x06010269 RID: 66153 RVA: 0x00589256 File Offset: 0x00587456
	private void PHJJHFBLICM()
	{
		this.FJMDFKMLIJC();
	}

	// Token: 0x0601026A RID: 66154 RVA: 0x00588C1E File Offset: 0x00586E1E
	private void FJNCHGLIEMA()
	{
		this.NNFCMCBGICF();
	}

	// Token: 0x0601026B RID: 66155 RVA: 0x005888F2 File Offset: 0x00586AF2
	private void KOFAMEKHHGD()
	{
		this.OIBELCAKKHH();
	}

	// Token: 0x0601026C RID: 66156 RVA: 0x00589260 File Offset: 0x00587460
	public void PBCNOANNNBP()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 1 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.JKEDCEOCPJO)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.HOPMEAJKPHL(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.HMMBBDJNGGL)).value) + this.textAfter;
		}
	}

	// Token: 0x0601026D RID: 66157 RVA: 0x0058903E File Offset: 0x0058723E
	private void LEAHIBJDMBI()
	{
		this.EKMAGCOPLPD();
	}

	// Token: 0x0601026E RID: 66158 RVA: 0x0058935C File Offset: 0x0058755C
	public void IELBCJHEAFL()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 1 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.IGFOBPKFCDJ)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.GetLocalizatedText(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.HCFLGKJFKFE)).value) + this.textAfter;
		}
	}

	// Token: 0x0601026F RID: 66159 RVA: 0x00589458 File Offset: 0x00587658
	public void GCFNHPDPOOL()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 0 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.MEMPOPNAEDN)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.HOPMEAJKPHL(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.HCFLGKJFKFE)).value) + this.textAfter;
		}
	}

	// Token: 0x06010270 RID: 66160 RVA: 0x00588C16 File Offset: 0x00586E16
	private void IBFJAOINHMK()
	{
		this.NGLIPNLHBFK();
	}

	// Token: 0x06010271 RID: 66161 RVA: 0x0058903E File Offset: 0x0058723E
	private void GCHBGCGBMCK()
	{
		this.EKMAGCOPLPD();
	}

	// Token: 0x06010272 RID: 66162 RVA: 0x00589554 File Offset: 0x00587754
	public void GFMKDMAKECF()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 1 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.AGJKEBOPIOC)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.GetLocalizatedText(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.KFNPHCCAJFD)).value) + this.textAfter;
		}
	}

	// Token: 0x06010273 RID: 66163 RVA: 0x00589650 File Offset: 0x00587850
	public void IEAMEOBKGBP()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 1 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.HBJFIOJFBHC)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.GetLocalizatedText(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.HNMFCOHLALO)).value) + this.textAfter;
		}
	}

	// Token: 0x06010274 RID: 66164 RVA: 0x0058974C File Offset: 0x0058794C
	public void MOAGIBHBDGJ()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 1 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.EGKGJJGAPMN)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.GetLocalizatedText(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.HCFLGKJFKFE)).value) + this.textAfter;
		}
	}

	// Token: 0x06010275 RID: 66165 RVA: 0x00589846 File Offset: 0x00587A46
	private void KIEJKBNBHMD()
	{
		this.NKDIBKDAENF();
	}

	// Token: 0x06010276 RID: 66166 RVA: 0x0058984E File Offset: 0x00587A4E
	private void FIKFJDFELIP()
	{
		this.NFBCALMKMLN();
	}

	// Token: 0x06010277 RID: 66167 RVA: 0x005888EA File Offset: 0x00586AEA
	private void JOPCCCCHNLI()
	{
		this.FAGCFADJMDI();
	}

	// Token: 0x06010278 RID: 66168 RVA: 0x00589046 File Offset: 0x00587246
	private void KLILJHJNICK()
	{
		this.GCFNHPDPOOL();
	}

	// Token: 0x06010279 RID: 66169 RVA: 0x00588E26 File Offset: 0x00587026
	private void KIMMMCJFMAB()
	{
		this.IODAIHCJOMN();
	}

	// Token: 0x0601027A RID: 66170 RVA: 0x00589858 File Offset: 0x00587A58
	public void DHECOKJKOIG()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 1 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.GBKBDKHPLKG)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.HOPMEAJKPHL(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.MMJGKBNKFGM)).value) + this.textAfter;
		}
	}

	// Token: 0x0601027B RID: 66171 RVA: 0x00589952 File Offset: 0x00587B52
	private void MECJHOJPODB()
	{
		this.GMOHNBFKLPG();
	}

	// Token: 0x0601027C RID: 66172 RVA: 0x0058995C File Offset: 0x00587B5C
	public void NFBCALMKMLN()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 0 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.HBJFIOJFBHC)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.HOPMEAJKPHL(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.HMMBBDJNGGL)).value) + this.textAfter;
		}
	}

	// Token: 0x0601027D RID: 66173 RVA: 0x00588C16 File Offset: 0x00586E16
	private void ICILLMAKLMI()
	{
		this.NGLIPNLHBFK();
	}

	// Token: 0x0601027E RID: 66174 RVA: 0x00589036 File Offset: 0x00587236
	private void GJCOELHNLJE()
	{
		this.DLHNBKDMPIO();
	}

	// Token: 0x0601027F RID: 66175 RVA: 0x00589A58 File Offset: 0x00587C58
	public void FCNEBPDNKGH()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 1 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.MEMPOPNAEDN)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.GetLocalizatedText(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.DGDCNDCGPCP)).value) + this.textAfter;
		}
	}

	// Token: 0x06010280 RID: 66176 RVA: 0x00589B54 File Offset: 0x00587D54
	public void KCOBKOMDIKN()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 0 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.IGFOBPKFCDJ)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.GetLocalizatedText(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.DAICIOGOPNL)).value) + this.textAfter;
		}
	}

	// Token: 0x06010281 RID: 66177 RVA: 0x00589846 File Offset: 0x00587A46
	private void DFFKKLAPHCC()
	{
		this.NKDIBKDAENF();
	}

	// Token: 0x06010282 RID: 66178 RVA: 0x00589C50 File Offset: 0x00587E50
	public void FALFNOMDNAA()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 0 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.JKEDCEOCPJO)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.HOPMEAJKPHL(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.LLGBONGFMBH)).value) + this.textAfter;
		}
	}

	// Token: 0x06010283 RID: 66179 RVA: 0x00589D4A File Offset: 0x00587F4A
	private void GHILDCBCDJI()
	{
		this.UpdateText();
	}

	// Token: 0x06010284 RID: 66180 RVA: 0x00589D54 File Offset: 0x00587F54
	public void LMJPEEKJGPK()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 0 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.OFHCGKJFGDI)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.GetLocalizatedText(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.LGKMMLGKBEF)).value) + this.textAfter;
		}
	}

	// Token: 0x06010285 RID: 66181 RVA: 0x00589E4E File Offset: 0x0058804E
	private void IDJKNBDKHBD()
	{
		this.EOMBIGCLDDO();
	}

	// Token: 0x06010286 RID: 66182 RVA: 0x00589E56 File Offset: 0x00588056
	private void POIMNOBDBBN()
	{
		this.DFMLOIEKHLG();
	}

	// Token: 0x06010288 RID: 66184 RVA: 0x00589EB1 File Offset: 0x005880B1
	private void FJHFOBHJEHL()
	{
		this.FCNEBPDNKGH();
	}

	// Token: 0x06010289 RID: 66185 RVA: 0x00589D4A File Offset: 0x00587F4A
	private void Start()
	{
		this.UpdateText();
	}

	// Token: 0x0601028A RID: 66186 RVA: 0x00589EBC File Offset: 0x005880BC
	public void MPNBGMNPFNJ()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 1 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.LNDGINDKPFA)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.HOPMEAJKPHL(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.DAICIOGOPNL)).value) + this.textAfter;
		}
	}

	// Token: 0x0601028B RID: 66187 RVA: 0x00589FB6 File Offset: 0x005881B6
	private void EHJJFJCKGAJ()
	{
		this.JANGLKBLHEF();
	}

	// Token: 0x0601028C RID: 66188 RVA: 0x00589952 File Offset: 0x00587B52
	private void AGMJDGHLBMN()
	{
		this.GMOHNBFKLPG();
	}

	// Token: 0x0601028D RID: 66189 RVA: 0x00588E26 File Offset: 0x00587026
	private void EDPDMBFLHLP()
	{
		this.IODAIHCJOMN();
	}

	// Token: 0x0601028E RID: 66190 RVA: 0x00588C0E File Offset: 0x00586E0E
	private void ONMGIPAILOH()
	{
		this.POFHAJFLAPK();
	}

	// Token: 0x0601028F RID: 66191 RVA: 0x00589FC0 File Offset: 0x005881C0
	public void DKDHEBFIHEP()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 1 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.GBKBDKHPLKG)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.HOPMEAJKPHL(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.GMLFBOMLINM)).value) + this.textAfter;
		}
	}

	// Token: 0x06010290 RID: 66192 RVA: 0x005888F2 File Offset: 0x00586AF2
	private void IDIIELPAMCJ()
	{
		this.OIBELCAKKHH();
	}

	// Token: 0x06010291 RID: 66193 RVA: 0x0058A0BA File Offset: 0x005882BA
	private void NNCCPEBIAKH()
	{
		this.PBCNOANNNBP();
	}

	// Token: 0x06010292 RID: 66194 RVA: 0x0058A0C4 File Offset: 0x005882C4
	public void GMOHNBFKLPG()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 1 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.FFEGPHJKMFK)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.GetLocalizatedText(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.MMJGKBNKFGM)).value) + this.textAfter;
		}
	}

	// Token: 0x06010293 RID: 66195 RVA: 0x005888E2 File Offset: 0x00586AE2
	private void NNFMIAFHMJM()
	{
		this.ILBEEBHIDEG();
	}

	// Token: 0x06010294 RID: 66196 RVA: 0x00588E26 File Offset: 0x00587026
	private void MNBPNHNAEBK()
	{
		this.IODAIHCJOMN();
	}

	// Token: 0x06010295 RID: 66197 RVA: 0x00589046 File Offset: 0x00587246
	private void EPEGAEGDJAM()
	{
		this.GCFNHPDPOOL();
	}

	// Token: 0x06010296 RID: 66198 RVA: 0x0058A1C0 File Offset: 0x005883C0
	public void NNFCMCBGICF()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 1 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.JKEDCEOCPJO)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.HOPMEAJKPHL(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.DGDCNDCGPCP)).value) + this.textAfter;
		}
	}

	// Token: 0x06010297 RID: 66199 RVA: 0x00589EB1 File Offset: 0x005880B1
	private void OMCLOFCJMPG()
	{
		this.FCNEBPDNKGH();
	}

	// Token: 0x06010298 RID: 66200 RVA: 0x0058A2BC File Offset: 0x005884BC
	public void POFHAJFLAPK()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 1 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.FFEGPHJKMFK)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.GetLocalizatedText(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.HNMFCOHLALO)).value) + this.textAfter;
		}
	}

	// Token: 0x06010299 RID: 66201 RVA: 0x00589026 File Offset: 0x00587226
	private void BGFJOEPFOPM()
	{
		this.IEAMEOBKGBP();
	}

	// Token: 0x0601029A RID: 66202 RVA: 0x0058A3B8 File Offset: 0x005885B8
	public void FAODNNBJEML()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 1 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.MEMPOPNAEDN)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.HOPMEAJKPHL(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.LGKMMLGKBEF)).value) + this.textAfter;
		}
	}

	// Token: 0x0601029B RID: 66203 RVA: 0x0058A4B4 File Offset: 0x005886B4
	public void JAGHOBNOKLN()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 1 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.AGJKEBOPIOC)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.HOPMEAJKPHL(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.DAICIOGOPNL)).value) + this.textAfter;
		}
	}

	// Token: 0x0601029C RID: 66204 RVA: 0x0058A5AE File Offset: 0x005887AE
	private void JHANGPCOCIG()
	{
		this.JAGHOBNOKLN();
	}

	// Token: 0x0601029D RID: 66205 RVA: 0x0058A5B8 File Offset: 0x005887B8
	public void IOMCOLOEHFL()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 0 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.HBJFIOJFBHC)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.HOPMEAJKPHL(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.DGDCNDCGPCP)).value) + this.textAfter;
		}
	}

	// Token: 0x0601029E RID: 66206 RVA: 0x0058A6B4 File Offset: 0x005888B4
	public void OAFDLPIGMEO()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 0 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.KFNBKFELFLH)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.GetLocalizatedText(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.GMLFBOMLINM)).value) + this.textAfter;
		}
	}

	// Token: 0x0601029F RID: 66207 RVA: 0x00589D4A File Offset: 0x00587F4A
	private void OBAEDJJDCPN()
	{
		this.UpdateText();
	}

	// Token: 0x060102A0 RID: 66208 RVA: 0x0058A7AE File Offset: 0x005889AE
	private void FHPFJBFCOOF()
	{
		this.AEHOKFIKFMB();
	}

	// Token: 0x060102A1 RID: 66209 RVA: 0x00589256 File Offset: 0x00587456
	private void DDBOODLPCAM()
	{
		this.FJMDFKMLIJC();
	}

	// Token: 0x060102A2 RID: 66210 RVA: 0x0058A7B6 File Offset: 0x005889B6
	private void PBEPCAPAKLG()
	{
		this.DKDHEBFIHEP();
	}

	// Token: 0x060102A3 RID: 66211 RVA: 0x005888EA File Offset: 0x00586AEA
	private void PKGJJFIFLII()
	{
		this.FAGCFADJMDI();
	}

	// Token: 0x060102A4 RID: 66212 RVA: 0x0058A7C0 File Offset: 0x005889C0
	public void EOMBIGCLDDO()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 0 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.BDGDIDPDBHG)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.HOPMEAJKPHL(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.ONEPCCGOEKI)).value) + this.textAfter;
		}
	}

	// Token: 0x060102A5 RID: 66213 RVA: 0x0058A8BC File Offset: 0x00588ABC
	public void ILBEEBHIDEG()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 1 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.FIPCLHEKKCA)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.GetLocalizatedText(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.DIOBKCECBCH)).value) + this.textAfter;
		}
	}

	// Token: 0x060102A6 RID: 66214 RVA: 0x0058A9B8 File Offset: 0x00588BB8
	public void EKMAGCOPLPD()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 0 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.EGKGJJGAPMN)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.GetLocalizatedText(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.HNMFCOHLALO)).value) + this.textAfter;
		}
	}

	// Token: 0x060102A7 RID: 66215 RVA: 0x00588C26 File Offset: 0x00586E26
	private void LIBGAKMKHJJ()
	{
		this.LMJPEEKJGPK();
	}

	// Token: 0x060102A8 RID: 66216 RVA: 0x0058AAB4 File Offset: 0x00588CB4
	public void JANGLKBLHEF()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 0 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.FIPCLHEKKCA)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.HOPMEAJKPHL(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.LGKMMLGKBEF)).value) + this.textAfter;
		}
	}

	// Token: 0x060102A9 RID: 66217 RVA: 0x0058ABB0 File Offset: 0x00588DB0
	public void IODAIHCJOMN()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 1 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.HBJFIOJFBHC)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.GetLocalizatedText(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.LKLABDAJAEH)).value) + this.textAfter;
		}
	}

	// Token: 0x060102AA RID: 66218 RVA: 0x0058ACAA File Offset: 0x00588EAA
	private void GFACKFCEIBC()
	{
		this.IELBCJHEAFL();
	}

	// Token: 0x060102AB RID: 66219 RVA: 0x0058ACB2 File Offset: 0x00588EB2
	private void ONKDMMJPEMN()
	{
		this.OAFDLPIGMEO();
	}

	// Token: 0x060102AC RID: 66220 RVA: 0x0058ACAA File Offset: 0x00588EAA
	private void CCLNNLCOPBL()
	{
		this.IELBCJHEAFL();
	}

	// Token: 0x060102AD RID: 66221 RVA: 0x00589026 File Offset: 0x00587226
	private void ADPLHDFJFID()
	{
		this.IEAMEOBKGBP();
	}

	// Token: 0x060102AE RID: 66222 RVA: 0x0058924E File Offset: 0x0058744E
	private void DBLILJGKGHJ()
	{
		this.KCOBKOMDIKN();
	}

	// Token: 0x060102AF RID: 66223 RVA: 0x00589EB1 File Offset: 0x005880B1
	private void ANKIJGCGCBF()
	{
		this.FCNEBPDNKGH();
	}

	// Token: 0x060102B0 RID: 66224 RVA: 0x00589D4A File Offset: 0x00587F4A
	private void Update()
	{
		this.UpdateText();
	}

	// Token: 0x060102B1 RID: 66225 RVA: 0x0058ACBA File Offset: 0x00588EBA
	private void JBCNIPJDPJB()
	{
		this.FALFNOMDNAA();
	}

	// Token: 0x060102B2 RID: 66226 RVA: 0x0058ACC4 File Offset: 0x00588EC4
	public void GLOHOBECDHL()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 1 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.BKNHHGBPLGH)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.GetLocalizatedText(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.LLGBONGFMBH)).value) + this.textAfter;
		}
	}

	// Token: 0x060102B3 RID: 66227 RVA: 0x0058ADC0 File Offset: 0x00588FC0
	public void JOLJFGLFNCK()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 1 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.BDGDIDPDBHG)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.GetLocalizatedText(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.DGDCNDCGPCP)).value) + this.textAfter;
		}
	}

	// Token: 0x060102B4 RID: 66228 RVA: 0x0058A7AE File Offset: 0x005889AE
	private void LCJHDLKJEOM()
	{
		this.AEHOKFIKFMB();
	}

	// Token: 0x060102B5 RID: 66229 RVA: 0x0058AEBC File Offset: 0x005890BC
	public void DBJELEPPKEP()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 0 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.AGJKEBOPIOC)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.HOPMEAJKPHL(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.HCFLGKJFKFE)).value) + this.textAfter;
		}
	}

	// Token: 0x060102B6 RID: 66230 RVA: 0x0058AFB8 File Offset: 0x005891B8
	public void AEHOKFIKFMB()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 1 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.BMAOCLKPNNC)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.HOPMEAJKPHL(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.KFNPHCCAJFD)).value) + this.textAfter;
		}
	}

	// Token: 0x060102B7 RID: 66231 RVA: 0x00589952 File Offset: 0x00587B52
	private void MBLDJEFBLFL()
	{
		this.GMOHNBFKLPG();
	}

	// Token: 0x060102B8 RID: 66232 RVA: 0x00589952 File Offset: 0x00587B52
	private void KNBJBNDGCIJ()
	{
		this.GMOHNBFKLPG();
	}

	// Token: 0x060102B9 RID: 66233 RVA: 0x00589846 File Offset: 0x00587A46
	private void FMNPFCHBLJF()
	{
		this.NKDIBKDAENF();
	}

	// Token: 0x060102BA RID: 66234 RVA: 0x0058B0B2 File Offset: 0x005892B2
	private void MDNHCLKNCLE()
	{
		this.HMFLACFDMAA();
	}

	// Token: 0x060102BB RID: 66235 RVA: 0x005888EA File Offset: 0x00586AEA
	private void KCDOMIJBFLL()
	{
		this.FAGCFADJMDI();
	}

	// Token: 0x060102BC RID: 66236 RVA: 0x0058B0BC File Offset: 0x005892BC
	public void UpdateText()
	{
		SliderValueLabel.DMGPIKIKABE dmgpikikabe = new SliderValueLabel.DMGPIKIKABE();
		dmgpikikabe.IHIAMPBEFEE = ((!this.cut) ? (base.GetComponentInParent<Slider>().value * this.multiply).ToString() : (base.GetComponentInParent<Slider>().value * this.multiply).ToString(this.cutFormat));
		base.GetComponent<Text>().text = this.textBefore + dmgpikikabe.IHIAMPBEFEE + this.textAfter;
		if (this.customKeyValues.Count > 0 && this.customKeyValues.Exists(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.GBKBDKHPLKG)))
		{
			base.GetComponent<Text>().text = this.textBefore + LocalizationService.Instance.GetLocalizatedText(this.customKeyValues.Find(new Predicate<SliderValueLabel.SliderKeyValue>(dmgpikikabe.HMMBBDJNGGL)).value) + this.textAfter;
		}
	}

	// Token: 0x060102BD RID: 66237 RVA: 0x0058ACAA File Offset: 0x00588EAA
	private void CIPKEPDELJB()
	{
		this.IELBCJHEAFL();
	}

	// Token: 0x060102BE RID: 66238 RVA: 0x00589D4A File Offset: 0x00587F4A
	private void HMNLHMLILKD()
	{
		this.UpdateText();
	}

	// Token: 0x04001C71 RID: 7281
	public float multiply = 1f;

	// Token: 0x04001C72 RID: 7282
	public bool cut = true;

	// Token: 0x04001C73 RID: 7283
	public string cutFormat = "0";

	// Token: 0x04001C74 RID: 7284
	public string textBefore = string.Empty;

	// Token: 0x04001C75 RID: 7285
	public string textAfter = string.Empty;

	// Token: 0x04001C76 RID: 7286
	public List<SliderValueLabel.SliderKeyValue> customKeyValues = new List<SliderValueLabel.SliderKeyValue>();

	// Token: 0x02000469 RID: 1129
	[Serializable]
	public class SliderKeyValue
	{
		// Token: 0x04001C77 RID: 7287
		public string key;

		// Token: 0x04001C78 RID: 7288
		public string value;
	}

	// Token: 0x0200046A RID: 1130
	[CompilerGenerated]
	private sealed class DMGPIKIKABE
	{
		// Token: 0x060102C0 RID: 66240 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool DGDCNDCGPCP(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102C1 RID: 66241 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool OFHCGKJFGDI(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102C3 RID: 66243 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool FFEGPHJKMFK(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102C4 RID: 66244 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool LGKMMLGKBEF(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102C5 RID: 66245 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool LKLABDAJAEH(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102C6 RID: 66246 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool DAICIOGOPNL(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102C7 RID: 66247 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool GMLFBOMLINM(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102C8 RID: 66248 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool LLGBONGFMBH(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102C9 RID: 66249 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool HBJFIOJFBHC(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102CA RID: 66250 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool BDGDIDPDBHG(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102CB RID: 66251 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool JKEDCEOCPJO(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102CC RID: 66252 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool AGJKEBOPIOC(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102CD RID: 66253 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool GBKBDKHPLKG(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102CE RID: 66254 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool KFNPHCCAJFD(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102CF RID: 66255 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool IGFOBPKFCDJ(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102D0 RID: 66256 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool KFNBKFELFLH(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102D1 RID: 66257 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool HMMBBDJNGGL(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102D2 RID: 66258 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool BFEABMIFIEE(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102D3 RID: 66259 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool DIOBKCECBCH(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102D4 RID: 66260 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool FIPCLHEKKCA(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102D5 RID: 66261 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool HNMFCOHLALO(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102D6 RID: 66262 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool ONEPCCGOEKI(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102D7 RID: 66263 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool EGKGJJGAPMN(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102D8 RID: 66264 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool BKNHHGBPLGH(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102D9 RID: 66265 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool MMJGKBNKFGM(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102DA RID: 66266 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool BMAOCLKPNNC(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102DB RID: 66267 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool HCFLGKJFKFE(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102DC RID: 66268 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool MEMPOPNAEDN(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102DD RID: 66269 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool LNDGINDKPFA(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x060102DE RID: 66270 RVA: 0x0058B1B6 File Offset: 0x005893B6
		internal bool KGKMOLCPDIH(SliderValueLabel.SliderKeyValue IACGDFHKCAE)
		{
			return IACGDFHKCAE.key == this.IHIAMPBEFEE;
		}

		// Token: 0x04001C79 RID: 7289
		internal string IHIAMPBEFEE;
	}
}
