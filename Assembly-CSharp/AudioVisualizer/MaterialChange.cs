using System;
using System.Collections.Generic;
using UnityEngine;

namespace AudioVisualizer
{
	// Token: 0x0200000D RID: 13
	public class MaterialChange : MonoBehaviour
	{
		// Token: 0x06000241 RID: 577 RVA: 0x000150E0 File Offset: 0x000132E0
		private void JHPOIOELNCG()
		{
			this.HECPCDOLDFM();
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000150E8 File Offset: 0x000132E8
		private void CCLNNLCOPBL()
		{
			this.OEMADMOLHHG = new List<Material>();
			Material[] materials = base.GetComponent<MeshRenderer>().materials;
			for (int i = 0; i < materials.Length; i += 0)
			{
				Material item = materials[i];
				this.OEMADMOLHHG.Add(item);
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00015130 File Offset: 0x00013330
		private void DKOPKPBLDHH()
		{
			this.OEMADMOLHHG = new List<Material>();
			Material[] materials = base.GetComponent<MeshRenderer>().materials;
			for (int i = 0; i < materials.Length; i += 0)
			{
				Material item = materials[i];
				this.OEMADMOLHHG.Add(item);
			}
		}

		// Token: 0x06000244 RID: 580 RVA: 0x000150E0 File Offset: 0x000132E0
		private void IIFCIDDJHPM()
		{
			this.HECPCDOLDFM();
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00015178 File Offset: 0x00013378
		private void BMOFEBKGLFI()
		{
			this.OEMADMOLHHG = new List<Material>();
			foreach (Material item in base.GetComponent<MeshRenderer>().materials)
			{
				this.OEMADMOLHHG.Add(item);
			}
		}

		// Token: 0x06000246 RID: 582 RVA: 0x000151C0 File Offset: 0x000133C0
		private void HDIDKJPCOHO()
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
			num = Mathf.Clamp(num, 271f, 1331f);
			float value = Mathf.Lerp(this.ODEMGPEEJFD, num, this.lerpSpeed * Time.deltaTime);
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.SetFloat("Tab1Content", value);
			}
			this.ODEMGPEEJFD = num;
		}

		// Token: 0x06000248 RID: 584 RVA: 0x000152C4 File Offset: 0x000134C4
		private void OAEFNGBMHIN()
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
			num = Mathf.Clamp(num, 579f, 1494f);
			float value = Mathf.Lerp(this.ODEMGPEEJFD, num, this.lerpSpeed * Time.deltaTime);
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.SetFloat("_Value", value);
			}
			this.ODEMGPEEJFD = num;
		}

		// Token: 0x06000249 RID: 585 RVA: 0x000153A0 File Offset: 0x000135A0
		private void DLBODOFAJGM()
		{
			this.OEMADMOLHHG = new List<Material>();
			Material[] materials = base.GetComponent<MeshRenderer>().materials;
			for (int i = 0; i < materials.Length; i += 0)
			{
				Material item = materials[i];
				this.OEMADMOLHHG.Add(item);
			}
		}

		// Token: 0x0600024A RID: 586 RVA: 0x000153E8 File Offset: 0x000135E8
		private void OJIGMOKPCOD()
		{
			float num;
			if (this.frequencyRange == FrequencyRange.Bass)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 548f, 240f);
			float value = Mathf.Lerp(this.ODEMGPEEJFD, num, this.lerpSpeed * Time.deltaTime);
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.SetFloat("/Segment-[Right]", value);
			}
			this.ODEMGPEEJFD = num;
		}

		// Token: 0x0600024B RID: 587 RVA: 0x000154C4 File Offset: 0x000136C4
		private void OJEGPPDHAFH()
		{
			float num;
			if (this.frequencyRange == FrequencyRange.Bass)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 1805f, 2f);
			float value = Mathf.Lerp(this.ODEMGPEEJFD, num, this.lerpSpeed * Time.deltaTime);
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.SetFloat("_ScreenResolution", value);
			}
			this.ODEMGPEEJFD = num;
		}

		// Token: 0x0600024C RID: 588 RVA: 0x000155A0 File Offset: 0x000137A0
		private void PBNAPNDFFCD()
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
			num = Mathf.Clamp(num, 1650f, 1187f);
			float value = Mathf.Lerp(this.ODEMGPEEJFD, num, this.lerpSpeed * Time.deltaTime);
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.SetFloat("Map: ", value);
			}
			this.ODEMGPEEJFD = num;
		}

		// Token: 0x0600024D RID: 589 RVA: 0x0001567C File Offset: 0x0001387C
		private void KDMANOEMOCA()
		{
			this.OEMADMOLHHG = new List<Material>();
			Material[] materials = base.GetComponent<MeshRenderer>().materials;
			for (int i = 1; i < materials.Length; i++)
			{
				Material item = materials[i];
				this.OEMADMOLHHG.Add(item);
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000156C4 File Offset: 0x000138C4
		private void FIKFJDFELIP()
		{
			this.OEMADMOLHHG = new List<Material>();
			Material[] materials = base.GetComponent<MeshRenderer>().materials;
			for (int i = 0; i < materials.Length; i += 0)
			{
				Material item = materials[i];
				this.OEMADMOLHHG.Add(item);
			}
		}

		// Token: 0x0600024F RID: 591 RVA: 0x0001570C File Offset: 0x0001390C
		private void KLILJHJNICK()
		{
			this.OEMADMOLHHG = new List<Material>();
			Material[] materials = base.GetComponent<MeshRenderer>().materials;
			for (int i = 1; i < materials.Length; i++)
			{
				Material item = materials[i];
				this.OEMADMOLHHG.Add(item);
			}
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00015754 File Offset: 0x00013954
		private void LLJLDLLNFBH()
		{
			this.KLJKHMFMOAA();
		}

		// Token: 0x06000251 RID: 593 RVA: 0x0001575C File Offset: 0x0001395C
		private void Update()
		{
			this.EAPHGFHGCAK();
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00015764 File Offset: 0x00013964
		private void DIPDEHOOBPG()
		{
			this.OEMADMOLHHG = new List<Material>();
			Material[] materials = base.GetComponent<MeshRenderer>().materials;
			for (int i = 1; i < materials.Length; i += 0)
			{
				Material item = materials[i];
				this.OEMADMOLHHG.Add(item);
			}
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000157AC File Offset: 0x000139AC
		private void OCMKCBBCEFG()
		{
			this.LJDHIDONMIC();
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000157B4 File Offset: 0x000139B4
		private void NHAHGDCNAIG()
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
			num = Mathf.Clamp(num, 388f, 1551f);
			float value = Mathf.Lerp(this.ODEMGPEEJFD, num, this.lerpSpeed * Time.deltaTime);
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.SetFloat("arcs", value);
			}
			this.ODEMGPEEJFD = num;
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00015890 File Offset: 0x00013A90
		private void FOMNCPKKCFN()
		{
			this.PDKKEAGDBPO();
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00015898 File Offset: 0x00013A98
		private void Start()
		{
			this.OEMADMOLHHG = new List<Material>();
			foreach (Material item in base.GetComponent<MeshRenderer>().materials)
			{
				this.OEMADMOLHHG.Add(item);
			}
		}

		// Token: 0x06000257 RID: 599 RVA: 0x000158E0 File Offset: 0x00013AE0
		private void AIJGAJIOJDJ()
		{
			this.OAEFNGBMHIN();
		}

		// Token: 0x06000258 RID: 600 RVA: 0x000158E8 File Offset: 0x00013AE8
		private void IHLMNAGPKDA()
		{
			this.OEMADMOLHHG = new List<Material>();
			Material[] materials = base.GetComponent<MeshRenderer>().materials;
			for (int i = 0; i < materials.Length; i += 0)
			{
				Material item = materials[i];
				this.OEMADMOLHHG.Add(item);
			}
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00015930 File Offset: 0x00013B30
		private void DNNFHBOOPIN()
		{
			this.OEMADMOLHHG = new List<Material>();
			Material[] materials = base.GetComponent<MeshRenderer>().materials;
			for (int i = 0; i < materials.Length; i += 0)
			{
				Material item = materials[i];
				this.OEMADMOLHHG.Add(item);
			}
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00015978 File Offset: 0x00013B78
		private void NEKCPLGFOFD()
		{
			this.CBLIOLEOJLH();
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00015980 File Offset: 0x00013B80
		private void CBLIOLEOJLH()
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
			num = Mathf.Clamp(num, 598f, 87f);
			float value = Mathf.Lerp(this.ODEMGPEEJFD, num, this.lerpSpeed * Time.deltaTime);
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.SetFloat("_NoiseAmount", value);
			}
			this.ODEMGPEEJFD = num;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00015A5C File Offset: 0x00013C5C
		private void LJDHIDONMIC()
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
			num = Mathf.Clamp(num, 306f, 1616f);
			float value = Mathf.Lerp(this.ODEMGPEEJFD, num, this.lerpSpeed * Time.deltaTime);
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.SetFloat("_TimeX", value);
			}
			this.ODEMGPEEJFD = num;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00015B38 File Offset: 0x00013D38
		private void BIGBIPFJBAA()
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
			num = Mathf.Clamp(num, 440f, 242f);
			float value = Mathf.Lerp(this.ODEMGPEEJFD, num, this.lerpSpeed * Time.deltaTime);
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.SetFloat("[LobbyPlayerElement] Created lpe for ", value);
			}
			this.ODEMGPEEJFD = num;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00015C14 File Offset: 0x00013E14
		private void NBGIMIDICKE()
		{
			this.OEMADMOLHHG = new List<Material>();
			Material[] materials = base.GetComponent<MeshRenderer>().materials;
			for (int i = 0; i < materials.Length; i += 0)
			{
				Material item = materials[i];
				this.OEMADMOLHHG.Add(item);
			}
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00015C5C File Offset: 0x00013E5C
		private void CNGAJDBOCLJ()
		{
			this.OEMADMOLHHG = new List<Material>();
			Material[] materials = base.GetComponent<MeshRenderer>().materials;
			for (int i = 1; i < materials.Length; i++)
			{
				Material item = materials[i];
				this.OEMADMOLHHG.Add(item);
			}
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00015CA4 File Offset: 0x00013EA4
		private void BGDPIHMAACO()
		{
			this.OEMADMOLHHG = new List<Material>();
			Material[] materials = base.GetComponent<MeshRenderer>().materials;
			for (int i = 1; i < materials.Length; i += 0)
			{
				Material item = materials[i];
				this.OEMADMOLHHG.Add(item);
			}
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00015CEC File Offset: 0x00013EEC
		private void EHCGBJDFMHG()
		{
			this.JMLNILAAKFP();
		}

		// Token: 0x06000262 RID: 610 RVA: 0x000150E0 File Offset: 0x000132E0
		private void FBMDHDBELEK()
		{
			this.HECPCDOLDFM();
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00015CF4 File Offset: 0x00013EF4
		private void HLIAEEMGBHN()
		{
			this.OEMADMOLHHG = new List<Material>();
			Material[] materials = base.GetComponent<MeshRenderer>().materials;
			for (int i = 1; i < materials.Length; i += 0)
			{
				Material item = materials[i];
				this.OEMADMOLHHG.Add(item);
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00015D3C File Offset: 0x00013F3C
		private void HECPCDOLDFM()
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
			num = Mathf.Clamp(num, 733f, 1389f);
			float value = Mathf.Lerp(this.ODEMGPEEJFD, num, this.lerpSpeed * Time.deltaTime);
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.SetFloat("workshop.", value);
			}
			this.ODEMGPEEJFD = num;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00015CEC File Offset: 0x00013EEC
		private void HLDFOJMHKNL()
		{
			this.JMLNILAAKFP();
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00015E18 File Offset: 0x00014018
		private void PDKKEAGDBPO()
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
			num = Mathf.Clamp(num, 40f, 1475f);
			float value = Mathf.Lerp(this.ODEMGPEEJFD, num, this.lerpSpeed * Time.deltaTime);
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.SetFloat("editorVolume", value);
			}
			this.ODEMGPEEJFD = num;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x000150E0 File Offset: 0x000132E0
		private void BMODOIJGIOO()
		{
			this.HECPCDOLDFM();
		}

		// Token: 0x06000268 RID: 616 RVA: 0x000158E0 File Offset: 0x00013AE0
		private void JOACBIEHHCE()
		{
			this.OAEFNGBMHIN();
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00015EF4 File Offset: 0x000140F4
		private void EOFIKLOCJJK()
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
			num = Mathf.Clamp(num, 1843f, 1436f);
			float value = Mathf.Lerp(this.ODEMGPEEJFD, num, this.lerpSpeed * Time.deltaTime);
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.SetFloat("\n", value);
			}
			this.ODEMGPEEJFD = num;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00015FD0 File Offset: 0x000141D0
		private void JMLNILAAKFP()
		{
			float num;
			if (this.frequencyRange == FrequencyRange.High)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 973f, 482f);
			float value = Mathf.Lerp(this.ODEMGPEEJFD, num, this.lerpSpeed * Time.deltaTime);
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.SetFloat("y", value);
			}
			this.ODEMGPEEJFD = num;
		}

		// Token: 0x0600026B RID: 619 RVA: 0x000160AC File Offset: 0x000142AC
		private void EAPHGFHGCAK()
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
			float value = Mathf.Lerp(this.ODEMGPEEJFD, num, this.lerpSpeed * Time.deltaTime);
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.SetFloat("_Blend", value);
			}
			this.ODEMGPEEJFD = num;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00016188 File Offset: 0x00014388
		private void KLJKHMFMOAA()
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
			num = Mathf.Clamp(num, 360f, 1027f);
			float value = Mathf.Lerp(this.ODEMGPEEJFD, num, this.lerpSpeed * Time.deltaTime);
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.SetFloat("NO", value);
			}
			this.ODEMGPEEJFD = num;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x000157AC File Offset: 0x000139AC
		private void AAPKBNDHBLI()
		{
			this.LJDHIDONMIC();
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00016264 File Offset: 0x00014464
		private void GCHHMBJLLBH()
		{
			float num;
			if (this.frequencyRange == FrequencyRange.UpperMidrange)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			num = Mathf.Clamp(num, 1573f, 1226f);
			float value = Mathf.Lerp(this.ODEMGPEEJFD, num, this.lerpSpeed * Time.deltaTime);
			foreach (Material material in this.OEMADMOLHHG)
			{
				material.SetFloat("</b>", value);
			}
			this.ODEMGPEEJFD = num;
		}

		// Token: 0x04000052 RID: 82
		public int audioSource;

		// Token: 0x04000053 RID: 83
		public FrequencyRange frequencyRange = FrequencyRange.Decibal;

		// Token: 0x04000054 RID: 84
		public float sensitivity = 2f;

		// Token: 0x04000055 RID: 85
		public Material lowMat;

		// Token: 0x04000056 RID: 86
		public Material highMat;

		// Token: 0x04000057 RID: 87
		public float lerpSpeed = 10f;

		// Token: 0x04000058 RID: 88
		private List<Material> OEMADMOLHHG;

		// Token: 0x04000059 RID: 89
		private float ODEMGPEEJFD;
	}
}
