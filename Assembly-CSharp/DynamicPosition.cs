using System;
using AudioVisualizer;
using UnityEngine;

// Token: 0x020003AE RID: 942
public class DynamicPosition : MonoBehaviour
{
	// Token: 0x0600D34E RID: 54094 RVA: 0x0002523B File Offset: 0x0002343B
	private void EFJDNLGNACH()
	{
	}

	// Token: 0x0600D34F RID: 54095 RVA: 0x004B8EFC File Offset: 0x004B70FC
	private void GCHBGCGBMCK()
	{
		float num = this.FAJNJACLINK() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 382f * num, 991f, 77f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D350 RID: 54096 RVA: 0x0002523B File Offset: 0x0002343B
	private void CCLNNLCOPBL()
	{
	}

	// Token: 0x0600D351 RID: 54097 RVA: 0x004B8F5C File Offset: 0x004B715C
	private void JHPOIOELNCG()
	{
		float num = this.MDFDIMBOMLG() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 120f * num, 884f, 1296f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D352 RID: 54098 RVA: 0x004B8FBC File Offset: 0x004B71BC
	private float AIBNBFNJIDP()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.High)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D353 RID: 54099 RVA: 0x004B9014 File Offset: 0x004B7214
	private void FJHFOBHJEHL()
	{
		float num = this.JLOJMMBCPFE() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 586f * num, 989f, 1193f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D354 RID: 54100 RVA: 0x004B9074 File Offset: 0x004B7274
	private void CGBHOELMAOC()
	{
		float num = this.FAJNJACLINK() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 959f * num, 940f, 920f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D355 RID: 54101 RVA: 0x004B90D4 File Offset: 0x004B72D4
	private void HNDNDPECBPL()
	{
		float num = this.EBBBIIIALMI() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 840f * num, 771f, 1801f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D356 RID: 54102 RVA: 0x004B9134 File Offset: 0x004B7334
	private float EMEAIBBFGIL()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.Midrange)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D357 RID: 54103 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDPIHMAACO()
	{
	}

	// Token: 0x0600D358 RID: 54104 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMIOFJFMCBG()
	{
	}

	// Token: 0x0600D359 RID: 54105 RVA: 0x004B918C File Offset: 0x004B738C
	private void FABMDEHEDNO()
	{
		float num = this.MHBNJPNBFDP() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 1288f * num, 116f, 714f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D35A RID: 54106 RVA: 0x004B91EC File Offset: 0x004B73EC
	private void KKLMPKLKAEM()
	{
		float num = this.KIJJMDCPELF() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 190f * num, 523f, 967f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D35B RID: 54107 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKDNLHLBHID()
	{
	}

	// Token: 0x0600D35C RID: 54108 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDBPCNICGLC()
	{
	}

	// Token: 0x0600D35D RID: 54109 RVA: 0x004B924C File Offset: 0x004B744C
	private void LMADKINICIN()
	{
		float num = this.EFLKAHDNIKA() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 1921f * num, 526f, 1077f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D35E RID: 54110 RVA: 0x0002523B File Offset: 0x0002343B
	private void DAHFFNNIGML()
	{
	}

	// Token: 0x0600D35F RID: 54111 RVA: 0x004B92AC File Offset: 0x004B74AC
	private void IKMELABKBHO()
	{
		float num = this.DDJDIGFKBHH() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 760f * num, 507f, 863f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D360 RID: 54112 RVA: 0x004B930C File Offset: 0x004B750C
	private float HKIJLEGJOKA()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.Decibal)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D361 RID: 54113 RVA: 0x004B9364 File Offset: 0x004B7564
	private void LCHBFNIPBHB()
	{
		float num = this.LJEELNJEAHO() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 1144f * num, 919f, 1527f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D362 RID: 54114 RVA: 0x0002523B File Offset: 0x0002343B
	private void PAKPHKPDKGE()
	{
	}

	// Token: 0x0600D363 RID: 54115 RVA: 0x0002523B File Offset: 0x0002343B
	private void EIMNPCMHJLJ()
	{
	}

	// Token: 0x0600D364 RID: 54116 RVA: 0x004B93C4 File Offset: 0x004B75C4
	private float HFFLBCACMGA()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.SubBase)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D365 RID: 54117 RVA: 0x004B941C File Offset: 0x004B761C
	private void LDDKCCMHMIC()
	{
		float num = this.KPCPAJAMINO() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 134f * num, 487f, 1119f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D366 RID: 54118 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPLLKHHLDBB()
	{
	}

	// Token: 0x0600D367 RID: 54119 RVA: 0x004B947C File Offset: 0x004B767C
	private float PEMIIJICHAN()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.VeryHigh)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D368 RID: 54120 RVA: 0x0002523B File Offset: 0x0002343B
	private void DOKAKEMDALN()
	{
	}

	// Token: 0x0600D369 RID: 54121 RVA: 0x0002523B File Offset: 0x0002343B
	private void OKLAJINHPAN()
	{
	}

	// Token: 0x0600D36A RID: 54122 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMMDPANNAIO()
	{
	}

	// Token: 0x0600D36B RID: 54123 RVA: 0x004B94D4 File Offset: 0x004B76D4
	private void POIMNOBDBBN()
	{
		float num = this.FAJNJACLINK() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 347f * num, 1019f, 1640f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D36C RID: 54124 RVA: 0x004B9534 File Offset: 0x004B7734
	private void LMBDNPLDGIJ()
	{
		float num = this.BBICAMNKJPO() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 445f * num, 381f, 38f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D36D RID: 54125 RVA: 0x004B9594 File Offset: 0x004B7794
	private float CIJAGCCJMMC()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.VeryHigh)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D36E RID: 54126 RVA: 0x0002523B File Offset: 0x0002343B
	private void LFBGJIIECLD()
	{
	}

	// Token: 0x0600D36F RID: 54127 RVA: 0x0002523B File Offset: 0x0002343B
	private void PDHKMDBNGGN()
	{
	}

	// Token: 0x0600D370 RID: 54128 RVA: 0x004B95EC File Offset: 0x004B77EC
	private float FPKNKPGFNEG()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.SubBase)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D371 RID: 54129 RVA: 0x004B9644 File Offset: 0x004B7844
	private void FGNFILLNPJK()
	{
		float num = this.GLMAIAAILID() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 1679f * num, 1640f, 1361f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D372 RID: 54130 RVA: 0x0002523B File Offset: 0x0002343B
	private void FMNPFCHBLJF()
	{
	}

	// Token: 0x0600D373 RID: 54131 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCCIEMBMOBA()
	{
	}

	// Token: 0x0600D374 RID: 54132 RVA: 0x004B96A4 File Offset: 0x004B78A4
	private float FBDEFILNDEH()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.Midrange)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D375 RID: 54133 RVA: 0x0002523B File Offset: 0x0002343B
	private void NNFMIAFHMJM()
	{
	}

	// Token: 0x0600D376 RID: 54134 RVA: 0x004B96FC File Offset: 0x004B78FC
	private float HPJKPCNNILA()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.Midrange)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D377 RID: 54135 RVA: 0x004B9754 File Offset: 0x004B7954
	private float EJGNOGBFFHN()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.SubBase)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D378 RID: 54136 RVA: 0x004B97AC File Offset: 0x004B79AC
	private void HEBOIFKBLGD()
	{
		float num = this.JLOJMMBCPFE() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 942f * num, 408f, 1496f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D379 RID: 54137 RVA: 0x0002523B File Offset: 0x0002343B
	private void ODBNMPGBCGO()
	{
	}

	// Token: 0x0600D37A RID: 54138 RVA: 0x004B980C File Offset: 0x004B7A0C
	private float EBBBIIIALMI()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.SubBase)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D37B RID: 54139 RVA: 0x004B9864 File Offset: 0x004B7A64
	private void KIEJKBNBHMD()
	{
		float num = this.DDJDIGFKBHH() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 1052f * num, 152f, 1664f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D37C RID: 54140 RVA: 0x0002523B File Offset: 0x0002343B
	private void HJPCJGOEKMF()
	{
	}

	// Token: 0x0600D37E RID: 54142 RVA: 0x0002523B File Offset: 0x0002343B
	private void FIKFJDFELIP()
	{
	}

	// Token: 0x0600D37F RID: 54143 RVA: 0x004B98F4 File Offset: 0x004B7AF4
	private float LJEELNJEAHO()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.UpperMidrange)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D380 RID: 54144 RVA: 0x0002523B File Offset: 0x0002343B
	private void COIJKMKIEAK()
	{
	}

	// Token: 0x0600D381 RID: 54145 RVA: 0x0002523B File Offset: 0x0002343B
	private void JONGNKNLLND()
	{
	}

	// Token: 0x0600D382 RID: 54146 RVA: 0x004B994C File Offset: 0x004B7B4C
	private void KCDOMIJBFLL()
	{
		float num = this.DDJDIGFKBHH() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 617f * num, 1248f, 1871f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D383 RID: 54147 RVA: 0x004B99AC File Offset: 0x004B7BAC
	private void EDDPLJGKLKJ()
	{
		float num = this.FPKNKPGFNEG() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 1465f * num, 1473f, 746f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D384 RID: 54148 RVA: 0x004B9A0C File Offset: 0x004B7C0C
	private float FAJNJACLINK()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.Decibal)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D385 RID: 54149 RVA: 0x004B9A64 File Offset: 0x004B7C64
	private float DDJDIGFKBHH()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.Decibal)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D386 RID: 54150 RVA: 0x004B9ABC File Offset: 0x004B7CBC
	private void FOLDLDLFFLM()
	{
		float num = this.DDJDIGFKBHH() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 1222f * num, 1940f, 1515f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D387 RID: 54151 RVA: 0x0002523B File Offset: 0x0002343B
	private void JECMJNFGBGC()
	{
	}

	// Token: 0x0600D388 RID: 54152 RVA: 0x004B9B1C File Offset: 0x004B7D1C
	private void AKCADICOFDD()
	{
		float num = this.KCKPBGOOEBP() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 58f * num, 846f, 119f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D389 RID: 54153 RVA: 0x004B9B7C File Offset: 0x004B7D7C
	private void JBNPEHMDCMI()
	{
		float num = this.HFFLBCACMGA() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 55f * num, 625f, 1704f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D38A RID: 54154 RVA: 0x004B9BDC File Offset: 0x004B7DDC
	private void JCGMGLMADEN()
	{
		float num = this.ABJPLACFMPK() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 360f * num, 79f, 902f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D38B RID: 54155 RVA: 0x004B9C3C File Offset: 0x004B7E3C
	private float OGGFMBADHJN()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.Bass)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D38C RID: 54156 RVA: 0x004B9C94 File Offset: 0x004B7E94
	private void HPNNCNNFMGK()
	{
		float num = this.OGGFMBADHJN() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 291f * num, 1972f, 1071f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D38D RID: 54157 RVA: 0x004B9CF4 File Offset: 0x004B7EF4
	private void MANDOGNJJBD()
	{
		float num = this.HPJKPCNNILA() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 1030f * num, 643f, 969f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D38E RID: 54158 RVA: 0x004B9D54 File Offset: 0x004B7F54
	private void NEKCPLGFOFD()
	{
		float num = this.FPKNKPGFNEG() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 249f * num, 570f, 656f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D38F RID: 54159 RVA: 0x0002523B File Offset: 0x0002343B
	private void PMPKMGKAAJH()
	{
	}

	// Token: 0x0600D390 RID: 54160 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPNAOAKCMHC()
	{
	}

	// Token: 0x0600D391 RID: 54161 RVA: 0x004B9DB4 File Offset: 0x004B7FB4
	private float KPCPAJAMINO()
	{
		float result;
		if (this.frequencyRange == (FrequencyRange)8)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D392 RID: 54162 RVA: 0x004B9E0C File Offset: 0x004B800C
	private float MHBNJPNBFDP()
	{
		float result;
		if (this.frequencyRange == (FrequencyRange)8)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D393 RID: 54163 RVA: 0x0002523B File Offset: 0x0002343B
	private void KDMKDEKCELE()
	{
	}

	// Token: 0x0600D394 RID: 54164 RVA: 0x0002523B File Offset: 0x0002343B
	private void BOPKKCAFODF()
	{
	}

	// Token: 0x0600D395 RID: 54165 RVA: 0x004B9E64 File Offset: 0x004B8064
	private float JHDFJBCHKEJ()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.Bass)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D396 RID: 54166 RVA: 0x004B9EBC File Offset: 0x004B80BC
	private float GLMAIAAILID()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.Decibal)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D397 RID: 54167 RVA: 0x004B9F14 File Offset: 0x004B8114
	private void EPJJDKJEDMM()
	{
		float num = this.GLMAIAAILID() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 1377f * num, 1749f, 1363f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D398 RID: 54168 RVA: 0x004B9F74 File Offset: 0x004B8174
	private float OPBEFBAFLID()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.VeryHigh)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D399 RID: 54169 RVA: 0x004B9FCC File Offset: 0x004B81CC
	private void PFNFPINPCMH()
	{
		float num = this.OJGDHHAGFGJ() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 673f * num, 11f, 1567f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D39A RID: 54170 RVA: 0x0002523B File Offset: 0x0002343B
	private void FDNONDCGGCG()
	{
	}

	// Token: 0x0600D39B RID: 54171 RVA: 0x004BA02C File Offset: 0x004B822C
	private void IEMEHGCFAPD()
	{
		float num = this.OJGDHHAGFGJ() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 514f * num, 1214f, 324f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D39C RID: 54172 RVA: 0x0002523B File Offset: 0x0002343B
	private void FNCDAPDOBBI()
	{
	}

	// Token: 0x0600D39D RID: 54173 RVA: 0x004BA08C File Offset: 0x004B828C
	private float JLOJMMBCPFE()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.UpperMidrange)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D39E RID: 54174 RVA: 0x004BA0E4 File Offset: 0x004B82E4
	private void Update()
	{
		float num = this.DDJDIGFKBHH() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 1f * num, 0f, 0f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D39F RID: 54175 RVA: 0x004BA144 File Offset: 0x004B8344
	private float ABJPLACFMPK()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.Bass)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D3A0 RID: 54176 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBAJLLFMMMP()
	{
	}

	// Token: 0x0600D3A1 RID: 54177 RVA: 0x004BA19C File Offset: 0x004B839C
	private float MGGFOLJAIGO()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.LowMidrange)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D3A2 RID: 54178 RVA: 0x0002523B File Offset: 0x0002343B
	private void DKGBFNCOAEO()
	{
	}

	// Token: 0x0600D3A3 RID: 54179 RVA: 0x004BA1F4 File Offset: 0x004B83F4
	private void DPIPGGDNGHN()
	{
		float num = this.MGGFOLJAIGO() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 1133f * num, 23f, 922f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D3A4 RID: 54180 RVA: 0x004BA254 File Offset: 0x004B8454
	private float KPIHHJIFCGG()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.Bass)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D3A5 RID: 54181 RVA: 0x004BA2AC File Offset: 0x004B84AC
	private float EFLKAHDNIKA()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.Decibal)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D3A6 RID: 54182 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLIAEEMGBHN()
	{
	}

	// Token: 0x0600D3A7 RID: 54183 RVA: 0x004BA304 File Offset: 0x004B8504
	private float KBKFHDCKJGD()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.Bass)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D3A8 RID: 54184 RVA: 0x004BA35C File Offset: 0x004B855C
	private void OMCLOFCJMPG()
	{
		float num = this.BLJCNNPGIGH() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 1531f * num, 740f, 622f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D3A9 RID: 54185 RVA: 0x004BA3BC File Offset: 0x004B85BC
	private void JBCNIPJDPJB()
	{
		float num = this.KCKPBGOOEBP() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 838f * num, 413f, 447f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D3AA RID: 54186 RVA: 0x004BA41C File Offset: 0x004B861C
	private void HIFLPHLGLFG()
	{
		float num = this.DDJDIGFKBHH() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 540f * num, 1236f, 1157f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D3AB RID: 54187 RVA: 0x004BA47C File Offset: 0x004B867C
	private float DDGMGNFJBIP()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.VeryHigh)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D3AC RID: 54188 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOPCCCCHNLI()
	{
	}

	// Token: 0x0600D3AD RID: 54189 RVA: 0x004BA4D4 File Offset: 0x004B86D4
	private float KCKPBGOOEBP()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.Midrange)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D3AE RID: 54190 RVA: 0x004BA52C File Offset: 0x004B872C
	private void LLJLDLLNFBH()
	{
		float num = this.BLJCNNPGIGH() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 1490f * num, 355f, 257f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D3AF RID: 54191 RVA: 0x0002523B File Offset: 0x0002343B
	private void KDMANOEMOCA()
	{
	}

	// Token: 0x0600D3B0 RID: 54192 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIPEHGNBJMN()
	{
	}

	// Token: 0x0600D3B1 RID: 54193 RVA: 0x004BA58C File Offset: 0x004B878C
	private float OJGDHHAGFGJ()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.SubBase)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D3B2 RID: 54194 RVA: 0x004BA5E4 File Offset: 0x004B87E4
	private float BLJCNNPGIGH()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.VeryHigh)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D3B3 RID: 54195 RVA: 0x004BA63C File Offset: 0x004B883C
	private void BGFJOEPFOPM()
	{
		float num = this.OJGDHHAGFGJ() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 1035f * num, 1948f, 941f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D3B4 RID: 54196 RVA: 0x004BA69C File Offset: 0x004B889C
	private void MECJHOJPODB()
	{
		float num = this.KCKPBGOOEBP() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 547f * num, 1989f, 1454f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D3B5 RID: 54197 RVA: 0x004BA6FC File Offset: 0x004B88FC
	private float KIJJMDCPELF()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.VeryHigh)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D3B6 RID: 54198 RVA: 0x004BA754 File Offset: 0x004B8954
	private float LOEHBOKLGAK()
	{
		float result;
		if (this.frequencyRange == (FrequencyRange)8)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D3B7 RID: 54199 RVA: 0x0002523B File Offset: 0x0002343B
	private void DLBODOFAJGM()
	{
	}

	// Token: 0x0600D3B8 RID: 54200 RVA: 0x004BA7AC File Offset: 0x004B89AC
	private void LLDHEJIEDHO()
	{
		float num = this.HKIJLEGJOKA() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 1688f * num, 1592f, 1649f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D3B9 RID: 54201 RVA: 0x004BA80C File Offset: 0x004B8A0C
	private void IIFCIDDJHPM()
	{
		float num = this.JHDFJBCHKEJ() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 1275f * num, 1449f, 1741f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D3BA RID: 54202 RVA: 0x004BA86C File Offset: 0x004B8A6C
	private void LJIHHJOAJCN()
	{
		float num = this.HFFLBCACMGA() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 359f * num, 32f, 1934f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D3BB RID: 54203 RVA: 0x004BA8CC File Offset: 0x004B8ACC
	private void APKNAPHOFHC()
	{
		float num = this.PLOOIDGBAFN() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 1315f * num, 1135f, 850f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D3BC RID: 54204 RVA: 0x0002523B File Offset: 0x0002343B
	private void NBGIMIDICKE()
	{
	}

	// Token: 0x0600D3BD RID: 54205 RVA: 0x004BA92C File Offset: 0x004B8B2C
	private void KFACDBHDAOD()
	{
		float num = this.HKIJLEGJOKA() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 1504f * num, 1812f, 728f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D3BE RID: 54206 RVA: 0x004BA98C File Offset: 0x004B8B8C
	private float BBICAMNKJPO()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.UpperMidrange)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D3BF RID: 54207 RVA: 0x004BA9E4 File Offset: 0x004B8BE4
	private void LPMINJJPDCH()
	{
		float num = this.JHDFJBCHKEJ() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 1469f * num, 1123f, 521f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D3C0 RID: 54208 RVA: 0x004BAA44 File Offset: 0x004B8C44
	private float MDFDIMBOMLG()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.LowMidrange)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D3C1 RID: 54209 RVA: 0x004BAA9C File Offset: 0x004B8C9C
	private float BMBNPLGBPEL()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.SubBase)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D3C2 RID: 54210 RVA: 0x004BAAF4 File Offset: 0x004B8CF4
	private float PLOOIDGBAFN()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.Midrange)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D3C3 RID: 54211 RVA: 0x004BAB4C File Offset: 0x004B8D4C
	private void NFEDLAOPHML()
	{
		float num = this.MDFDIMBOMLG() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 1262f * num, 244f, 449f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D3C4 RID: 54212 RVA: 0x004BABAC File Offset: 0x004B8DAC
	private void LCJHDLKJEOM()
	{
		float num = this.HFFLBCACMGA() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 1712f * num, 1018f, 1549f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D3C5 RID: 54213 RVA: 0x0002523B File Offset: 0x0002343B
	private void DFFKKLAPHCC()
	{
	}

	// Token: 0x0600D3C6 RID: 54214 RVA: 0x0002523B File Offset: 0x0002343B
	private void FEHCNJLLJMP()
	{
	}

	// Token: 0x0600D3C7 RID: 54215 RVA: 0x004BAC0C File Offset: 0x004B8E0C
	private float EFAHDNONPOL()
	{
		float result;
		if (this.frequencyRange == FrequencyRange.Midrange)
		{
			result = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
		}
		else
		{
			result = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
		}
		return result;
	}

	// Token: 0x0600D3C8 RID: 54216 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJNCHGLIEMA()
	{
	}

	// Token: 0x0600D3C9 RID: 54217 RVA: 0x004BAC64 File Offset: 0x004B8E64
	private void LBPCODPOJAH()
	{
		float num = this.DDGMGNFJBIP() * this.sensitivity;
		base.transform.localPosition = Vector3.Lerp(base.transform.localPosition, new Vector3(this.radius + 1493f * num, 93f, 74f), Time.deltaTime * this.lerpSpeed);
	}

	// Token: 0x0600D3CA RID: 54218 RVA: 0x0002523B File Offset: 0x0002343B
	private void HAIAHJPCPAG()
	{
	}

	// Token: 0x0600D3CB RID: 54219 RVA: 0x0002523B File Offset: 0x0002343B
	private void Start()
	{
	}

	// Token: 0x04001829 RID: 6185
	public int audioSource;

	// Token: 0x0400182A RID: 6186
	public FrequencyRange frequencyRange = FrequencyRange.Decibal;

	// Token: 0x0400182B RID: 6187
	public float sensitivity = 2f;

	// Token: 0x0400182C RID: 6188
	public float lerpSpeed = 1f;

	// Token: 0x0400182D RID: 6189
	public float radius = 2f;
}
