using System;
using System.Collections.Generic;
using UnityEngine;

namespace AudioVisualizer
{
	// Token: 0x02000009 RID: 9
	public class ColorChange : MonoBehaviour
	{
		// Token: 0x0600016B RID: 363 RVA: 0x0000BE5C File Offset: 0x0000A05C
		public void OJECBKEMOBH()
		{
			this.KCNHJDIAAGH = PanelWaveform.GODHDHPGOKB(this.lowColor, this.highColor);
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000BE78 File Offset: 0x0000A078
		private void NLNAJMCBNDC()
		{
			this.KCNHJDIAAGH = PanelWaveform.ADFFJDHKLLC(this.lowColor, this.highColor);
			this.OEMADMOLHHG = new List<Material>();
			foreach (Material item in base.GetComponent<MeshRenderer>().materials)
			{
				this.OEMADMOLHHG.Add(item);
			}
			this.AAEBFBPJJPK = this.OEMADMOLHHG[1].color.a;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x0000BF31 File Offset: 0x0000A131
		private void MFMIODIAKNI()
		{
			this.NAGDOGACFBM();
		}

		// Token: 0x0600016F RID: 367 RVA: 0x0000BF3C File Offset: 0x0000A13C
		private void PIAAIFCHFKJ()
		{
			float num;
			if (this.frequencyRange == FrequencyRange.Decibal)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 680f, 945f);
			Color b = this.KCNHJDIAAGH.Evaluate(num);
			Color color = Color.Lerp(this.OEMADMOLHHG[0].color, b, this.lerpSpeed * Time.deltaTime);
			float b2 = this.lowColor.a + (this.highColor.a - this.lowColor.a) * num;
			this.AAEBFBPJJPK = Mathf.Lerp(this.AAEBFBPJJPK, b2, this.lerpSpeed * Time.deltaTime);
			color.a = this.AAEBFBPJJPK;
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.color = color;
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000C078 File Offset: 0x0000A278
		private void MOAKDFGGCBC()
		{
			float num;
			if (this.frequencyRange == FrequencyRange.VeryHigh)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 1570f, 1729f);
			Color b = this.KCNHJDIAAGH.Evaluate(num);
			Color color = Color.Lerp(this.OEMADMOLHHG[1].color, b, this.lerpSpeed * Time.deltaTime);
			float b2 = this.lowColor.a + (this.highColor.a - this.lowColor.a) * num;
			this.AAEBFBPJJPK = Mathf.Lerp(this.AAEBFBPJJPK, b2, this.lerpSpeed * Time.deltaTime);
			color.a = this.AAEBFBPJJPK;
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.color = color;
			}
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000BF31 File Offset: 0x0000A131
		private void OIBMHPIFAKK()
		{
			this.NAGDOGACFBM();
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000C1B4 File Offset: 0x0000A3B4
		private void BGDJFAFCIGF()
		{
			float num;
			if (this.frequencyRange == FrequencyRange.VeryHigh)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 1071f, 1725f);
			Color b = this.KCNHJDIAAGH.Evaluate(num);
			Color color = Color.Lerp(this.OEMADMOLHHG[0].color, b, this.lerpSpeed * Time.deltaTime);
			float b2 = this.lowColor.a + (this.highColor.a - this.lowColor.a) * num;
			this.AAEBFBPJJPK = Mathf.Lerp(this.AAEBFBPJJPK, b2, this.lerpSpeed * Time.deltaTime);
			color.a = this.AAEBFBPJJPK;
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.color = color;
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000C2F0 File Offset: 0x0000A4F0
		private void FBMDHDBELEK()
		{
			this.HHKOOFNHMMJ();
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000C2F8 File Offset: 0x0000A4F8
		public void LBMLGIAKJCH()
		{
			this.KCNHJDIAAGH = PanelWaveform.HAKMDLECNAL(this.lowColor, this.highColor);
		}

		// Token: 0x06000175 RID: 373 RVA: 0x0000C311 File Offset: 0x0000A511
		private void HDDECCMEJKA()
		{
			this.HBJBBIOKKDO();
		}

		// Token: 0x06000176 RID: 374 RVA: 0x0000C31C File Offset: 0x0000A51C
		private void NAGDOGACFBM()
		{
			float num;
			if (this.frequencyRange == FrequencyRange.High)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 86f, 147f);
			Color b = this.KCNHJDIAAGH.Evaluate(num);
			Color color = Color.Lerp(this.OEMADMOLHHG[1].color, b, this.lerpSpeed * Time.deltaTime);
			float b2 = this.lowColor.a + (this.highColor.a - this.lowColor.a) * num;
			this.AAEBFBPJJPK = Mathf.Lerp(this.AAEBFBPJJPK, b2, this.lerpSpeed * Time.deltaTime);
			color.a = this.AAEBFBPJJPK;
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.color = color;
			}
		}

		// Token: 0x06000177 RID: 375 RVA: 0x0000C458 File Offset: 0x0000A658
		private void OBPCMAFGLON()
		{
			this.KCNHJDIAAGH = PanelWaveform.HAKMDLECNAL(this.lowColor, this.highColor);
			this.OEMADMOLHHG = new List<Material>();
			foreach (Material item in base.GetComponent<MeshRenderer>().materials)
			{
				this.OEMADMOLHHG.Add(item);
			}
			this.AAEBFBPJJPK = this.OEMADMOLHHG[1].color.a;
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000C4D6 File Offset: 0x0000A6D6
		public void ABDHDGNIHHI()
		{
			this.KCNHJDIAAGH = PanelWaveform.NNGGFFAOHEE(this.lowColor, this.highColor);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000C4EF File Offset: 0x0000A6EF
		public void AIEDHEKFPEP()
		{
			this.KCNHJDIAAGH = PanelWaveform.KIKNKECPNMD(this.lowColor, this.highColor);
		}

		// Token: 0x0600017A RID: 378 RVA: 0x0000C508 File Offset: 0x0000A708
		private void JPJNECPABBG()
		{
			this.KCNHJDIAAGH = PanelWaveform.NNGGFFAOHEE(this.lowColor, this.highColor);
			this.OEMADMOLHHG = new List<Material>();
			Material[] materials = base.GetComponent<MeshRenderer>().materials;
			for (int i = 0; i < materials.Length; i += 0)
			{
				Material item = materials[i];
				this.OEMADMOLHHG.Add(item);
			}
			this.AAEBFBPJJPK = this.OEMADMOLHHG[0].color.a;
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000C586 File Offset: 0x0000A786
		private void Update()
		{
			this.DLMEGFCGBJN();
		}

		// Token: 0x0600017C RID: 380 RVA: 0x0000C58E File Offset: 0x0000A78E
		private void HMNLHMLILKD()
		{
			this.DHMBKGCFBBH();
		}

		// Token: 0x0600017D RID: 381 RVA: 0x0000C598 File Offset: 0x0000A798
		private void PPCGJBIIFAO()
		{
			this.KCNHJDIAAGH = PanelWaveform.NCIIBNMIDCI(this.lowColor, this.highColor);
			this.OEMADMOLHHG = new List<Material>();
			foreach (Material item in base.GetComponent<MeshRenderer>().materials)
			{
				this.OEMADMOLHHG.Add(item);
			}
			this.AAEBFBPJJPK = this.OEMADMOLHHG[0].color.a;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000C616 File Offset: 0x0000A816
		private void EJFJENFKLND()
		{
			this.LNOKNKGKCML();
		}

		// Token: 0x0600017F RID: 383 RVA: 0x0000C4EF File Offset: 0x0000A6EF
		public void EMKKGIEFKML()
		{
			this.KCNHJDIAAGH = PanelWaveform.KIKNKECPNMD(this.lowColor, this.highColor);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x0000C620 File Offset: 0x0000A820
		private void KCADPNNKKNK()
		{
			float num;
			if (this.frequencyRange == FrequencyRange.Decibal)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 944f, 484f);
			Color b = this.KCNHJDIAAGH.Evaluate(num);
			Color color = Color.Lerp(this.OEMADMOLHHG[0].color, b, this.lerpSpeed * Time.deltaTime);
			float b2 = this.lowColor.a + (this.highColor.a - this.lowColor.a) * num;
			this.AAEBFBPJJPK = Mathf.Lerp(this.AAEBFBPJJPK, b2, this.lerpSpeed * Time.deltaTime);
			color.a = this.AAEBFBPJJPK;
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.color = color;
			}
		}

		// Token: 0x06000181 RID: 385 RVA: 0x0000C75C File Offset: 0x0000A95C
		private void HHKOOFNHMMJ()
		{
			float num;
			if (this.frequencyRange == FrequencyRange.UpperMidrange)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 1729f, 732f);
			Color b = this.KCNHJDIAAGH.Evaluate(num);
			Color color = Color.Lerp(this.OEMADMOLHHG[1].color, b, this.lerpSpeed * Time.deltaTime);
			float b2 = this.lowColor.a + (this.highColor.a - this.lowColor.a) * num;
			this.AAEBFBPJJPK = Mathf.Lerp(this.AAEBFBPJJPK, b2, this.lerpSpeed * Time.deltaTime);
			color.a = this.AAEBFBPJJPK;
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.color = color;
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x0000C4EF File Offset: 0x0000A6EF
		public void PMLIOODCKDB()
		{
			this.KCNHJDIAAGH = PanelWaveform.KIKNKECPNMD(this.lowColor, this.highColor);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x0000C898 File Offset: 0x0000AA98
		private void GBNOIKAPBBO()
		{
			this.KCNHJDIAAGH = PanelWaveform.ADFFJDHKLLC(this.lowColor, this.highColor);
			this.OEMADMOLHHG = new List<Material>();
			Material[] materials = base.GetComponent<MeshRenderer>().materials;
			for (int i = 1; i < materials.Length; i++)
			{
				Material item = materials[i];
				this.OEMADMOLHHG.Add(item);
			}
			this.AAEBFBPJJPK = this.OEMADMOLHHG[0].color.a;
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000C916 File Offset: 0x0000AB16
		public void Reset()
		{
			this.KCNHJDIAAGH = PanelWaveform.GetColorGradient(this.lowColor, this.highColor);
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000C930 File Offset: 0x0000AB30
		private void HPLPFPPIFPN()
		{
			float num;
			if (this.frequencyRange == FrequencyRange.SubBase)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 1370f, 1545f);
			Color b = this.KCNHJDIAAGH.Evaluate(num);
			Color color = Color.Lerp(this.OEMADMOLHHG[1].color, b, this.lerpSpeed * Time.deltaTime);
			float b2 = this.lowColor.a + (this.highColor.a - this.lowColor.a) * num;
			this.AAEBFBPJJPK = Mathf.Lerp(this.AAEBFBPJJPK, b2, this.lerpSpeed * Time.deltaTime);
			color.a = this.AAEBFBPJJPK;
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.color = color;
			}
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000CA6C File Offset: 0x0000AC6C
		private void POHMFMNEPKK()
		{
			this.KCNHJDIAAGH = PanelWaveform.NCIIBNMIDCI(this.lowColor, this.highColor);
			this.OEMADMOLHHG = new List<Material>();
			Material[] materials = base.GetComponent<MeshRenderer>().materials;
			for (int i = 1; i < materials.Length; i++)
			{
				Material item = materials[i];
				this.OEMADMOLHHG.Add(item);
			}
			this.AAEBFBPJJPK = this.OEMADMOLHHG[1].color.a;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000CAEA File Offset: 0x0000ACEA
		private void IBHACCEEFFI()
		{
			this.PIAAIFCHFKJ();
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000CAF2 File Offset: 0x0000ACF2
		private void AEIJFLJEABG()
		{
			this.MOAKDFGGCBC();
		}

		// Token: 0x06000189 RID: 393 RVA: 0x0000BE5C File Offset: 0x0000A05C
		public void DGNLHKLGAMC()
		{
			this.KCNHJDIAAGH = PanelWaveform.GODHDHPGOKB(this.lowColor, this.highColor);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000CAFC File Offset: 0x0000ACFC
		private void KACPCCMPAHA()
		{
			this.KCNHJDIAAGH = PanelWaveform.HAKMDLECNAL(this.lowColor, this.highColor);
			this.OEMADMOLHHG = new List<Material>();
			Material[] materials = base.GetComponent<MeshRenderer>().materials;
			for (int i = 1; i < materials.Length; i += 0)
			{
				Material item = materials[i];
				this.OEMADMOLHHG.Add(item);
			}
			this.AAEBFBPJJPK = this.OEMADMOLHHG[0].color.a;
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000CB7C File Offset: 0x0000AD7C
		private void LJJKCPFMNPD()
		{
			float num;
			if (this.frequencyRange == (FrequencyRange)8)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 883f, 955f);
			Color b = this.KCNHJDIAAGH.Evaluate(num);
			Color color = Color.Lerp(this.OEMADMOLHHG[1].color, b, this.lerpSpeed * Time.deltaTime);
			float b2 = this.lowColor.a + (this.highColor.a - this.lowColor.a) * num;
			this.AAEBFBPJJPK = Mathf.Lerp(this.AAEBFBPJJPK, b2, this.lerpSpeed * Time.deltaTime);
			color.a = this.AAEBFBPJJPK;
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.color = color;
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000C58E File Offset: 0x0000A78E
		private void LMBDNPLDGIJ()
		{
			this.DHMBKGCFBBH();
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000CCB8 File Offset: 0x0000AEB8
		private void HAEMLLLBPEO()
		{
			float num;
			if (this.frequencyRange == FrequencyRange.LowMidrange)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 1257f, 17f);
			Color b = this.KCNHJDIAAGH.Evaluate(num);
			Color color = Color.Lerp(this.OEMADMOLHHG[1].color, b, this.lerpSpeed * Time.deltaTime);
			float b2 = this.lowColor.a + (this.highColor.a - this.lowColor.a) * num;
			this.AAEBFBPJJPK = Mathf.Lerp(this.AAEBFBPJJPK, b2, this.lerpSpeed * Time.deltaTime);
			color.a = this.AAEBFBPJJPK;
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.color = color;
			}
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000CAEA File Offset: 0x0000ACEA
		private void HPNNCNNFMGK()
		{
			this.PIAAIFCHFKJ();
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000CDF4 File Offset: 0x0000AFF4
		public void OGKGIAAACAD()
		{
			this.KCNHJDIAAGH = PanelWaveform.ADFFJDHKLLC(this.lowColor, this.highColor);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x0000CE10 File Offset: 0x0000B010
		private void OCGDKBGPGNK()
		{
			float num;
			if (this.frequencyRange == FrequencyRange.VeryHigh)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 735f, 78f);
			Color b = this.KCNHJDIAAGH.Evaluate(num);
			Color color = Color.Lerp(this.OEMADMOLHHG[1].color, b, this.lerpSpeed * Time.deltaTime);
			float b2 = this.lowColor.a + (this.highColor.a - this.lowColor.a) * num;
			this.AAEBFBPJJPK = Mathf.Lerp(this.AAEBFBPJJPK, b2, this.lerpSpeed * Time.deltaTime);
			color.a = this.AAEBFBPJJPK;
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.color = color;
			}
		}

		// Token: 0x06000191 RID: 401 RVA: 0x0000CF4C File Offset: 0x0000B14C
		private void DLMEGFCGBJN()
		{
			float num;
			if (this.frequencyRange == FrequencyRange.Decibal)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 0f, 1f);
			Color b = this.KCNHJDIAAGH.Evaluate(num);
			Color color = Color.Lerp(this.OEMADMOLHHG[0].color, b, this.lerpSpeed * Time.deltaTime);
			float b2 = this.lowColor.a + (this.highColor.a - this.lowColor.a) * num;
			this.AAEBFBPJJPK = Mathf.Lerp(this.AAEBFBPJJPK, b2, this.lerpSpeed * Time.deltaTime);
			color.a = this.AAEBFBPJJPK;
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.color = color;
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x0000D088 File Offset: 0x0000B288
		private void DHMBKGCFBBH()
		{
			float num;
			if (this.frequencyRange == FrequencyRange.Midrange)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 1145f, 1091f);
			Color b = this.KCNHJDIAAGH.Evaluate(num);
			Color color = Color.Lerp(this.OEMADMOLHHG[1].color, b, this.lerpSpeed * Time.deltaTime);
			float b2 = this.lowColor.a + (this.highColor.a - this.lowColor.a) * num;
			this.AAEBFBPJJPK = Mathf.Lerp(this.AAEBFBPJJPK, b2, this.lerpSpeed * Time.deltaTime);
			color.a = this.AAEBFBPJJPK;
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.color = color;
			}
		}

		// Token: 0x06000193 RID: 403 RVA: 0x0000D1C4 File Offset: 0x0000B3C4
		private void EPCGHAAONLN()
		{
			this.KCNHJDIAAGH = PanelWaveform.DIHBJMBJHEH(this.lowColor, this.highColor);
			this.OEMADMOLHHG = new List<Material>();
			Material[] materials = base.GetComponent<MeshRenderer>().materials;
			for (int i = 1; i < materials.Length; i++)
			{
				Material item = materials[i];
				this.OEMADMOLHHG.Add(item);
			}
			this.AAEBFBPJJPK = this.OEMADMOLHHG[1].color.a;
		}

		// Token: 0x06000194 RID: 404 RVA: 0x0000D244 File Offset: 0x0000B444
		private void HBJBBIOKKDO()
		{
			float num;
			if (this.frequencyRange == FrequencyRange.High)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 112f, 1910f);
			Color b = this.KCNHJDIAAGH.Evaluate(num);
			Color color = Color.Lerp(this.OEMADMOLHHG[0].color, b, this.lerpSpeed * Time.deltaTime);
			float b2 = this.lowColor.a + (this.highColor.a - this.lowColor.a) * num;
			this.AAEBFBPJJPK = Mathf.Lerp(this.AAEBFBPJJPK, b2, this.lerpSpeed * Time.deltaTime);
			color.a = this.AAEBFBPJJPK;
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.color = color;
			}
		}

		// Token: 0x06000195 RID: 405 RVA: 0x0000D380 File Offset: 0x0000B580
		private void JAAJECBCCFM()
		{
			this.HLMPPKNCMGN();
		}

		// Token: 0x06000196 RID: 406 RVA: 0x0000D388 File Offset: 0x0000B588
		private void BMDOGMAOEPC()
		{
			float num;
			if (this.frequencyRange == FrequencyRange.VeryHigh)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 1417f, 1043f);
			Color b = this.KCNHJDIAAGH.Evaluate(num);
			Color color = Color.Lerp(this.OEMADMOLHHG[0].color, b, this.lerpSpeed * Time.deltaTime);
			float b2 = this.lowColor.a + (this.highColor.a - this.lowColor.a) * num;
			this.AAEBFBPJJPK = Mathf.Lerp(this.AAEBFBPJJPK, b2, this.lerpSpeed * Time.deltaTime);
			color.a = this.AAEBFBPJJPK;
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.color = color;
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x0000D4C4 File Offset: 0x0000B6C4
		private void LNOKNKGKCML()
		{
			float num;
			if (this.frequencyRange == (FrequencyRange)8)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 641f, 1378f);
			Color b = this.KCNHJDIAAGH.Evaluate(num);
			Color color = Color.Lerp(this.OEMADMOLHHG[1].color, b, this.lerpSpeed * Time.deltaTime);
			float b2 = this.lowColor.a + (this.highColor.a - this.lowColor.a) * num;
			this.AAEBFBPJJPK = Mathf.Lerp(this.AAEBFBPJJPK, b2, this.lerpSpeed * Time.deltaTime);
			color.a = this.AAEBFBPJJPK;
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.color = color;
			}
		}

		// Token: 0x06000198 RID: 408 RVA: 0x0000C4D6 File Offset: 0x0000A6D6
		public void LHIBPEGLPHM()
		{
			this.KCNHJDIAAGH = PanelWaveform.NNGGFFAOHEE(this.lowColor, this.highColor);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x0000D600 File Offset: 0x0000B800
		private void ALDGGNGOOKE()
		{
			float num;
			if (this.frequencyRange == FrequencyRange.UpperMidrange)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 487f, 871f);
			Color b = this.KCNHJDIAAGH.Evaluate(num);
			Color color = Color.Lerp(this.OEMADMOLHHG[1].color, b, this.lerpSpeed * Time.deltaTime);
			float b2 = this.lowColor.a + (this.highColor.a - this.lowColor.a) * num;
			this.AAEBFBPJJPK = Mathf.Lerp(this.AAEBFBPJJPK, b2, this.lerpSpeed * Time.deltaTime);
			color.a = this.AAEBFBPJJPK;
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.color = color;
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x0000D73C File Offset: 0x0000B93C
		private void DHNANELONED()
		{
			this.KCNHJDIAAGH = PanelWaveform.NCIIBNMIDCI(this.lowColor, this.highColor);
			this.OEMADMOLHHG = new List<Material>();
			Material[] materials = base.GetComponent<MeshRenderer>().materials;
			for (int i = 1; i < materials.Length; i += 0)
			{
				Material item = materials[i];
				this.OEMADMOLHHG.Add(item);
			}
			this.AAEBFBPJJPK = this.OEMADMOLHHG[1].color.a;
		}

		// Token: 0x0600019B RID: 411 RVA: 0x0000D7BA File Offset: 0x0000B9BA
		public void PCIOHCMKFBE()
		{
			this.KCNHJDIAAGH = PanelWaveform.BLJHHJLJHFI(this.lowColor, this.highColor);
		}

		// Token: 0x0600019C RID: 412 RVA: 0x0000C58E File Offset: 0x0000A78E
		private void KCDOMIJBFLL()
		{
			this.DHMBKGCFBBH();
		}

		// Token: 0x0600019D RID: 413 RVA: 0x0000D7D4 File Offset: 0x0000B9D4
		private void KMGMKPNJBEJ()
		{
			float num;
			if (this.frequencyRange == FrequencyRange.VeryHigh)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 1421f, 1182f);
			Color b = this.KCNHJDIAAGH.Evaluate(num);
			Color color = Color.Lerp(this.OEMADMOLHHG[1].color, b, this.lerpSpeed * Time.deltaTime);
			float b2 = this.lowColor.a + (this.highColor.a - this.lowColor.a) * num;
			this.AAEBFBPJJPK = Mathf.Lerp(this.AAEBFBPJJPK, b2, this.lerpSpeed * Time.deltaTime);
			color.a = this.AAEBFBPJJPK;
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.color = color;
			}
		}

		// Token: 0x0600019E RID: 414 RVA: 0x0000D910 File Offset: 0x0000BB10
		private void HLMPPKNCMGN()
		{
			float num;
			if (this.frequencyRange == FrequencyRange.Bass)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 263f, 1272f);
			Color b = this.KCNHJDIAAGH.Evaluate(num);
			Color color = Color.Lerp(this.OEMADMOLHHG[1].color, b, this.lerpSpeed * Time.deltaTime);
			float b2 = this.lowColor.a + (this.highColor.a - this.lowColor.a) * num;
			this.AAEBFBPJJPK = Mathf.Lerp(this.AAEBFBPJJPK, b2, this.lerpSpeed * Time.deltaTime);
			color.a = this.AAEBFBPJJPK;
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.color = color;
			}
		}

		// Token: 0x0600019F RID: 415 RVA: 0x0000BE5C File Offset: 0x0000A05C
		public void KMEFHCDNDNF()
		{
			this.KCNHJDIAAGH = PanelWaveform.GODHDHPGOKB(this.lowColor, this.highColor);
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x0000D7BA File Offset: 0x0000B9BA
		public void FHPPMBEEKBL()
		{
			this.KCNHJDIAAGH = PanelWaveform.BLJHHJLJHFI(this.lowColor, this.highColor);
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x0000C916 File Offset: 0x0000AB16
		public void LIMBEFBJNPL()
		{
			this.KCNHJDIAAGH = PanelWaveform.GetColorGradient(this.lowColor, this.highColor);
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x0000C2F8 File Offset: 0x0000A4F8
		public void HBFLDGHLMBJ()
		{
			this.KCNHJDIAAGH = PanelWaveform.HAKMDLECNAL(this.lowColor, this.highColor);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x0000DA4C File Offset: 0x0000BC4C
		private void FGEGEBDIOED()
		{
			float num;
			if (this.frequencyRange == FrequencyRange.Midrange)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 577f, 361f);
			Color b = this.KCNHJDIAAGH.Evaluate(num);
			Color color = Color.Lerp(this.OEMADMOLHHG[0].color, b, this.lerpSpeed * Time.deltaTime);
			float b2 = this.lowColor.a + (this.highColor.a - this.lowColor.a) * num;
			this.AAEBFBPJJPK = Mathf.Lerp(this.AAEBFBPJJPK, b2, this.lerpSpeed * Time.deltaTime);
			color.a = this.AAEBFBPJJPK;
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.color = color;
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x0000DB88 File Offset: 0x0000BD88
		private void LEAHIBJDMBI()
		{
			this.KMGMKPNJBEJ();
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000DB90 File Offset: 0x0000BD90
		private void HHJBBHEBJCJ()
		{
			this.KCNHJDIAAGH = PanelWaveform.GODHDHPGOKB(this.lowColor, this.highColor);
			this.OEMADMOLHHG = new List<Material>();
			Material[] materials = base.GetComponent<MeshRenderer>().materials;
			for (int i = 1; i < materials.Length; i += 0)
			{
				Material item = materials[i];
				this.OEMADMOLHHG.Add(item);
			}
			this.AAEBFBPJJPK = this.OEMADMOLHHG[1].color.a;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000DC10 File Offset: 0x0000BE10
		private void Awake()
		{
			this.KCNHJDIAAGH = PanelWaveform.GetColorGradient(this.lowColor, this.highColor);
			this.OEMADMOLHHG = new List<Material>();
			foreach (Material item in base.GetComponent<MeshRenderer>().materials)
			{
				this.OEMADMOLHHG.Add(item);
			}
			this.AAEBFBPJJPK = this.OEMADMOLHHG[0].color.a;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000C4EF File Offset: 0x0000A6EF
		public void JAIMCPINONG()
		{
			this.KCNHJDIAAGH = PanelWaveform.KIKNKECPNMD(this.lowColor, this.highColor);
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x0000DC90 File Offset: 0x0000BE90
		private void GOEPLENNHKG()
		{
			float num;
			if (this.frequencyRange == FrequencyRange.Midrange)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 569f, 442f);
			Color b = this.KCNHJDIAAGH.Evaluate(num);
			Color color = Color.Lerp(this.OEMADMOLHHG[1].color, b, this.lerpSpeed * Time.deltaTime);
			float b2 = this.lowColor.a + (this.highColor.a - this.lowColor.a) * num;
			this.AAEBFBPJJPK = Mathf.Lerp(this.AAEBFBPJJPK, b2, this.lerpSpeed * Time.deltaTime);
			color.a = this.AAEBFBPJJPK;
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.color = color;
			}
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x0000DDCC File Offset: 0x0000BFCC
		private void MIGKOPKCDMF()
		{
			float num;
			if (this.frequencyRange == FrequencyRange.High)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 167f, 1694f);
			Color b = this.KCNHJDIAAGH.Evaluate(num);
			Color color = Color.Lerp(this.OEMADMOLHHG[0].color, b, this.lerpSpeed * Time.deltaTime);
			float b2 = this.lowColor.a + (this.highColor.a - this.lowColor.a) * num;
			this.AAEBFBPJJPK = Mathf.Lerp(this.AAEBFBPJJPK, b2, this.lerpSpeed * Time.deltaTime);
			color.a = this.AAEBFBPJJPK;
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.color = color;
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x0000DF08 File Offset: 0x0000C108
		private void GIOJHHODDBG()
		{
			float num;
			if (this.frequencyRange == FrequencyRange.Midrange)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 1319f, 787f);
			Color b = this.KCNHJDIAAGH.Evaluate(num);
			Color color = Color.Lerp(this.OEMADMOLHHG[1].color, b, this.lerpSpeed * Time.deltaTime);
			float b2 = this.lowColor.a + (this.highColor.a - this.lowColor.a) * num;
			this.AAEBFBPJJPK = Mathf.Lerp(this.AAEBFBPJJPK, b2, this.lerpSpeed * Time.deltaTime);
			color.a = this.AAEBFBPJJPK;
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.color = color;
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000E044 File Offset: 0x0000C244
		private void BFIOIDMHPPL()
		{
			this.KCNHJDIAAGH = PanelWaveform.NCIIBNMIDCI(this.lowColor, this.highColor);
			this.OEMADMOLHHG = new List<Material>();
			Material[] materials = base.GetComponent<MeshRenderer>().materials;
			for (int i = 1; i < materials.Length; i++)
			{
				Material item = materials[i];
				this.OEMADMOLHHG.Add(item);
			}
			this.AAEBFBPJJPK = this.OEMADMOLHHG[1].color.a;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x0000C311 File Offset: 0x0000A511
		private void MMBPLGGLPDB()
		{
			this.HBJBBIOKKDO();
		}

		// Token: 0x060001AD RID: 429 RVA: 0x0000E0C4 File Offset: 0x0000C2C4
		private void HCNECNPPEKA()
		{
			this.KCNHJDIAAGH = PanelWaveform.GetColorGradient(this.lowColor, this.highColor);
			this.OEMADMOLHHG = new List<Material>();
			Material[] materials = base.GetComponent<MeshRenderer>().materials;
			for (int i = 1; i < materials.Length; i += 0)
			{
				Material item = materials[i];
				this.OEMADMOLHHG.Add(item);
			}
			this.AAEBFBPJJPK = this.OEMADMOLHHG[1].color.a;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000E142 File Offset: 0x0000C342
		private void ONMGIPAILOH()
		{
			this.MIGKOPKCDMF();
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000E14C File Offset: 0x0000C34C
		private void LFFAKAOAOCN()
		{
			this.KCNHJDIAAGH = PanelWaveform.ADFFJDHKLLC(this.lowColor, this.highColor);
			this.OEMADMOLHHG = new List<Material>();
			foreach (Material item in base.GetComponent<MeshRenderer>().materials)
			{
				this.OEMADMOLHHG.Add(item);
			}
			this.AAEBFBPJJPK = this.OEMADMOLHHG[0].color.a;
		}

		// Token: 0x04000037 RID: 55
		public int audioSource;

		// Token: 0x04000038 RID: 56
		public FrequencyRange frequencyRange = FrequencyRange.Decibal;

		// Token: 0x04000039 RID: 57
		public float sensitivity = 2f;

		// Token: 0x0400003A RID: 58
		public Color lowColor = Color.white;

		// Token: 0x0400003B RID: 59
		public Color highColor = Color.white;

		// Token: 0x0400003C RID: 60
		public float lerpSpeed = 10f;

		// Token: 0x0400003D RID: 61
		private Gradient KCNHJDIAAGH;

		// Token: 0x0400003E RID: 62
		private List<Material> OEMADMOLHHG;

		// Token: 0x0400003F RID: 63
		private float AAEBFBPJJPK;
	}
}
