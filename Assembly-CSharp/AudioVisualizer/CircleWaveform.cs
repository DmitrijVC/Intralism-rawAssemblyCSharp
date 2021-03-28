using System;
using System.Collections.Generic;
using UnityEngine;

namespace AudioVisualizer
{
	// Token: 0x02000008 RID: 8
	public class CircleWaveform : MonoBehaviour
	{
		// Token: 0x060000DE RID: 222 RVA: 0x00008982 File Offset: 0x00006B82
		private void GPIABJGNFNC()
		{
			Gizmos.color = Color.white;
			Gizmos.DrawSphere(base.transform.position, 1773f);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000089A3 File Offset: 0x00006BA3
		private void DJAIJIMKPHL()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000089B4 File Offset: 0x00006BB4
		private void PPGKBEJLBFJ()
		{
			this.HDJJGNBAIME = new List<float>();
			float num = 1909f / (float)this.objects.Count;
			for (int i = 1; i < this.objects.Count; i++)
			{
				this.HDJJGNBAIME.Add((float)i * num);
			}
			this.CKEBJHJHNPE = this.rotationSpeed;
			this.HDCHNCBEIMP = this.radius;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00008A22 File Offset: 0x00006C22
		public void ENLLMOOCMLO(float NINCBFGLKJB)
		{
			base.Invoke("SpawnObj", 806f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00008A44 File Offset: 0x00006C44
		public void KEHOMGMMLEK(bool KIIFDGHIGDE)
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
			if (KIIFDGHIGDE)
			{
				this.HIIGJIFJBBG = -this.HIIGJIFJBBG;
			}
			this.radius = this.HDCHNCBEIMP * num * this.HIIGJIFJBBG;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00008AC0 File Offset: 0x00006CC0
		public void AGAONKOPMHC(bool KIIFDGHIGDE)
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
			if (KIIFDGHIGDE)
			{
				this.HIIGJIFJBBG = -this.HIIGJIFJBBG;
			}
			this.radius = this.HDCHNCBEIMP * num * this.HIIGJIFJBBG;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00008B3C File Offset: 0x00006D3C
		private void GBNCNBEBCJL()
		{
			Gizmos.color = Color.white;
			Gizmos.DrawSphere(base.transform.position, 1246f);
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00008B60 File Offset: 0x00006D60
		private void ILJKCMBAILH()
		{
			this.JEELPBBJKDL += Time.smoothDeltaTime * this.rotationSpeed;
			for (int i = 0; i < this.objects.Count; i++)
			{
				float f = (this.JEELPBBJKDL + this.HDJJGNBAIME[i]) * 1721f;
				float num = this.radius;
				if (this.useWaveform)
				{
					float num2;
					if (this.frequencyRange == FrequencyRange.SubBase)
					{
						num2 = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
					}
					else
					{
						num2 = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
					}
					num = this.radius * num2;
				}
				float d = Mathf.Cos(f) * num;
				float d2 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, this.lerpSpeed * Time.smoothDeltaTime);
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00008CAC File Offset: 0x00006EAC
		public void LNFKLFCHPEB(float NINCBFGLKJB)
		{
			base.Invoke("\nCreated by Oxy949", 970f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00008CCC File Offset: 0x00006ECC
		private void JHPKLGGMCBL()
		{
			this.HDJJGNBAIME = new List<float>();
			float num = 907f / (float)this.objects.Count;
			for (int i = 1; i < this.objects.Count; i++)
			{
				this.HDJJGNBAIME.Add((float)i * num);
			}
			this.CKEBJHJHNPE = this.rotationSpeed;
			this.HDCHNCBEIMP = this.radius;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00008D3C File Offset: 0x00006F3C
		private void OFFGFINPBMK()
		{
			this.HDJJGNBAIME = new List<float>();
			float num = 974f / (float)this.objects.Count;
			for (int i = 1; i < this.objects.Count; i += 0)
			{
				this.HDJJGNBAIME.Add((float)i * num);
			}
			this.CKEBJHJHNPE = this.rotationSpeed;
			this.HDCHNCBEIMP = this.radius;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00008DAC File Offset: 0x00006FAC
		public void ANKBIFMJNPD(bool KIIFDGHIGDE)
		{
			float num;
			if (this.frequencyRange == FrequencyRange.SubBase)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			if (KIIFDGHIGDE)
			{
				this.HIIGJIFJBBG = -this.HIIGJIFJBBG;
			}
			this.radius = this.HDCHNCBEIMP * num * this.HIIGJIFJBBG;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00008E28 File Offset: 0x00007028
		public void ILMHKCEKNIL(float NINCBFGLKJB)
		{
			base.Invoke(".completed", 421f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000089A3 File Offset: 0x00006BA3
		private void MAHFDDGGHNK()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00008E48 File Offset: 0x00007048
		private void KOJKBFDNGDK()
		{
			this.EBMAGIJEBKG();
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00008E50 File Offset: 0x00007050
		private void MKIMDFLBFOM()
		{
			this.NPOMHDBEMHF();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00008E58 File Offset: 0x00007058
		public void JLFKAHIKLOO(bool KIIFDGHIGDE)
		{
			float num;
			if (this.frequencyRange == FrequencyRange.Midrange)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			if (KIIFDGHIGDE)
			{
				this.HIIGJIFJBBG = -this.HIIGJIFJBBG;
			}
			this.radius = this.HDCHNCBEIMP * num * this.HIIGJIFJBBG;
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00008ED4 File Offset: 0x000070D4
		public void NMEAPKIICDB(bool KIIFDGHIGDE)
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
			if (KIIFDGHIGDE)
			{
				this.HIIGJIFJBBG = -this.HIIGJIFJBBG;
			}
			this.radius = this.HDCHNCBEIMP * num * this.HIIGJIFJBBG;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00008F50 File Offset: 0x00007150
		private void OnDrawGizmos()
		{
			Gizmos.color = Color.white;
			Gizmos.DrawSphere(base.transform.position, 1f);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x000089A3 File Offset: 0x00006BA3
		private void FDKJBOOIJDA()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00008F74 File Offset: 0x00007174
		private void BMFPDNJFFJC()
		{
			this.JEELPBBJKDL += Time.smoothDeltaTime * this.rotationSpeed;
			for (int i = 0; i < this.objects.Count; i += 0)
			{
				float f = (this.JEELPBBJKDL + this.HDJJGNBAIME[i]) * 1847f;
				float num = this.radius;
				if (this.useWaveform)
				{
					float num2;
					if (this.frequencyRange == FrequencyRange.LowMidrange)
					{
						num2 = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
					}
					else
					{
						num2 = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
					}
					num = this.radius * num2;
				}
				float d = Mathf.Cos(f) * num;
				float d2 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, this.lerpSpeed * Time.smoothDeltaTime);
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x000090C0 File Offset: 0x000072C0
		public void MKHHPGAONCL(float NINCBFGLKJB)
		{
			base.Invoke("_TimeX", 1376f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x000089A3 File Offset: 0x00006BA3
		private void OCCNEDJIAEF()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000090E0 File Offset: 0x000072E0
		public void MKEJOCDGGOK(float NINCBFGLKJB)
		{
			base.Invoke("_MainTex2", 1989f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00009100 File Offset: 0x00007300
		private void INJDKGFPMCO()
		{
			Gizmos.color = Color.white;
			Gizmos.DrawSphere(base.transform.position, 1009f);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x000089A3 File Offset: 0x00006BA3
		private void NBPGDCHGMOA()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x00009121 File Offset: 0x00007321
		private void ONKDMMJPEMN()
		{
			this.BLOOADNPBJI();
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00009129 File Offset: 0x00007329
		public void Boost(float NINCBFGLKJB)
		{
			base.Invoke("KDNOMKHBIFE", 0.1f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000914C File Offset: 0x0000734C
		private void HFJEGJONAFO()
		{
			this.JEELPBBJKDL += Time.smoothDeltaTime * this.rotationSpeed;
			for (int i = 0; i < this.objects.Count; i += 0)
			{
				float f = (this.JEELPBBJKDL + this.HDJJGNBAIME[i]) * 1272f;
				float num = this.radius;
				if (this.useWaveform)
				{
					float num2;
					if (this.frequencyRange == FrequencyRange.VeryHigh)
					{
						num2 = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
					}
					else
					{
						num2 = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
					}
					num = this.radius * num2;
				}
				float d = Mathf.Cos(f) * num;
				float d2 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, this.lerpSpeed * Time.smoothDeltaTime);
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00009298 File Offset: 0x00007498
		private void KNDIANACKKF()
		{
			this.JEELPBBJKDL += Time.smoothDeltaTime * this.rotationSpeed;
			for (int i = 0; i < this.objects.Count; i++)
			{
				float f = (this.JEELPBBJKDL + this.HDJJGNBAIME[i]) * 1256f;
				float num = this.radius;
				if (this.useWaveform)
				{
					float num2;
					if (this.frequencyRange == FrequencyRange.UpperMidrange)
					{
						num2 = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
					}
					else
					{
						num2 = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
					}
					num = this.radius * num2;
				}
				float d = Mathf.Cos(f) * num;
				float d2 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, this.lerpSpeed * Time.smoothDeltaTime);
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000093E4 File Offset: 0x000075E4
		private void Awake()
		{
			this.HDJJGNBAIME = new List<float>();
			float num = 360f / (float)this.objects.Count;
			for (int i = 0; i < this.objects.Count; i++)
			{
				this.HDJJGNBAIME.Add((float)i * num);
			}
			this.CKEBJHJHNPE = this.rotationSpeed;
			this.HDCHNCBEIMP = this.radius;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000089A3 File Offset: 0x00006BA3
		private void NLOKCBNBFIN()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00009452 File Offset: 0x00007652
		public void EDAALKIGMHP(float NINCBFGLKJB)
		{
			base.Invoke("Hidden/Image Effects/Cinematic/Bloom", 1040f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00009472 File Offset: 0x00007672
		public void CCGLODCGKFN(float NINCBFGLKJB)
		{
			base.Invoke("intensity", 579f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00009492 File Offset: 0x00007692
		private void AEIJFLJEABG()
		{
			this.INICNAKKKMM();
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000949C File Offset: 0x0000769C
		public void GBMOFLJINIE(bool KIIFDGHIGDE)
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
			if (KIIFDGHIGDE)
			{
				this.HIIGJIFJBBG = -this.HIIGJIFJBBG;
			}
			this.radius = this.HDCHNCBEIMP * num * this.HIIGJIFJBBG;
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00009518 File Offset: 0x00007718
		public void AHGLKPHECIE(bool KIIFDGHIGDE)
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
			if (KIIFDGHIGDE)
			{
				this.HIIGJIFJBBG = -this.HIIGJIFJBBG;
			}
			this.radius = this.HDCHNCBEIMP * num * this.HIIGJIFJBBG;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00009594 File Offset: 0x00007794
		public void AGBDKBKFECL(float NINCBFGLKJB)
		{
			base.Invoke("Received RPC \"", 945f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x06000104 RID: 260 RVA: 0x000095B4 File Offset: 0x000077B4
		private void IINGHAOPNMF()
		{
			Gizmos.color = Color.white;
			Gizmos.DrawSphere(base.transform.position, 1206f);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x000095D5 File Offset: 0x000077D5
		public void EFABGGDGNGA(float NINCBFGLKJB)
		{
			base.Invoke("_color", 1695f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x000095F8 File Offset: 0x000077F8
		private void INICNAKKKMM()
		{
			this.JEELPBBJKDL += Time.smoothDeltaTime * this.rotationSpeed;
			for (int i = 1; i < this.objects.Count; i += 0)
			{
				float f = (this.JEELPBBJKDL + this.HDJJGNBAIME[i]) * 1647f;
				float num = this.radius;
				if (this.useWaveform)
				{
					float num2;
					if (this.frequencyRange == FrequencyRange.High)
					{
						num2 = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
					}
					else
					{
						num2 = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
					}
					num = this.radius * num2;
				}
				float d = Mathf.Cos(f) * num;
				float d2 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, this.lerpSpeed * Time.smoothDeltaTime);
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x00008E50 File Offset: 0x00007050
		private void AEOLJEIDMDB()
		{
			this.NPOMHDBEMHF();
		}

		// Token: 0x06000108 RID: 264 RVA: 0x00009744 File Offset: 0x00007944
		private void BLOOADNPBJI()
		{
			this.JEELPBBJKDL += Time.smoothDeltaTime * this.rotationSpeed;
			for (int i = 1; i < this.objects.Count; i += 0)
			{
				float f = (this.JEELPBBJKDL + this.HDJJGNBAIME[i]) * 28f;
				float num = this.radius;
				if (this.useWaveform)
				{
					float num2;
					if (this.frequencyRange == FrequencyRange.Midrange)
					{
						num2 = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
					}
					else
					{
						num2 = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
					}
					num = this.radius * num2;
				}
				float d = Mathf.Cos(f) * num;
				float d2 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, this.lerpSpeed * Time.smoothDeltaTime);
			}
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00009890 File Offset: 0x00007A90
		private void INEDKMMLBKL()
		{
			Gizmos.color = Color.white;
			Gizmos.DrawSphere(base.transform.position, 1473f);
		}

		// Token: 0x0600010A RID: 266 RVA: 0x000098B1 File Offset: 0x00007AB1
		private void EKKDNFKEAKP()
		{
			Gizmos.color = Color.white;
			Gizmos.DrawSphere(base.transform.position, 1207f);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x000098D4 File Offset: 0x00007AD4
		private void GKMLGGCFKMF()
		{
			this.JEELPBBJKDL += Time.smoothDeltaTime * this.rotationSpeed;
			for (int i = 1; i < this.objects.Count; i += 0)
			{
				float f = (this.JEELPBBJKDL + this.HDJJGNBAIME[i]) * 865f;
				float num = this.radius;
				if (this.useWaveform)
				{
					float num2;
					if (this.frequencyRange == FrequencyRange.Decibal)
					{
						num2 = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
					}
					else
					{
						num2 = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
					}
					num = this.radius * num2;
				}
				float d = Mathf.Cos(f) * num;
				float d2 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, this.lerpSpeed * Time.smoothDeltaTime);
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00009A20 File Offset: 0x00007C20
		private void ABFNJCEBIKA()
		{
			this.LFPOFMAIFNA();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x000089A3 File Offset: 0x00006BA3
		private void CMLLNFLGKMB()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x000089A3 File Offset: 0x00006BA3
		private void BCMKCMODJKI()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00009A28 File Offset: 0x00007C28
		private void OFHELBODPMB()
		{
			this.JEELPBBJKDL += Time.smoothDeltaTime * this.rotationSpeed;
			for (int i = 1; i < this.objects.Count; i++)
			{
				float f = (this.JEELPBBJKDL + this.HDJJGNBAIME[i]) * 1126f;
				float num = this.radius;
				if (this.useWaveform)
				{
					float num2;
					if (this.frequencyRange == FrequencyRange.Bass)
					{
						num2 = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
					}
					else
					{
						num2 = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
					}
					num = this.radius * num2;
				}
				float d = Mathf.Cos(f) * num;
				float d2 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, this.lerpSpeed * Time.smoothDeltaTime);
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x000089A3 File Offset: 0x00006BA3
		private void BCBIFHEAJEE()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00009B74 File Offset: 0x00007D74
		private void DLJFGNHKDKI()
		{
			Gizmos.color = Color.white;
			Gizmos.DrawSphere(base.transform.position, 1505f);
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00009B95 File Offset: 0x00007D95
		public void ALDLHCFCAAA(float NINCBFGLKJB)
		{
			base.Invoke("cmd.exe", 1131f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x06000113 RID: 275 RVA: 0x000089A3 File Offset: 0x00006BA3
		private void MIHEMAEDCMB()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x06000114 RID: 276 RVA: 0x00009BB5 File Offset: 0x00007DB5
		public void JEGEBBNIJHM(float NINCBFGLKJB)
		{
			base.Invoke("_Value2", 1085f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x06000115 RID: 277 RVA: 0x00009BD8 File Offset: 0x00007DD8
		private void LCCDHAKDOIM()
		{
			this.JEELPBBJKDL += Time.smoothDeltaTime * this.rotationSpeed;
			for (int i = 0; i < this.objects.Count; i++)
			{
				float f = (this.JEELPBBJKDL + this.HDJJGNBAIME[i]) * 987f;
				float num = this.radius;
				if (this.useWaveform)
				{
					float num2;
					if (this.frequencyRange == (FrequencyRange)8)
					{
						num2 = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
					}
					else
					{
						num2 = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
					}
					num = this.radius * num2;
				}
				float d = Mathf.Cos(f) * num;
				float d2 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, this.lerpSpeed * Time.smoothDeltaTime);
			}
		}

		// Token: 0x06000116 RID: 278 RVA: 0x00009D24 File Offset: 0x00007F24
		private void DOFDGBGEDFI()
		{
			this.AGJFDCAICGL();
		}

		// Token: 0x06000117 RID: 279 RVA: 0x00009D2C File Offset: 0x00007F2C
		private void LFFAKAOAOCN()
		{
			this.HDJJGNBAIME = new List<float>();
			float num = 26f / (float)this.objects.Count;
			for (int i = 1; i < this.objects.Count; i += 0)
			{
				this.HDJJGNBAIME.Add((float)i * num);
			}
			this.CKEBJHJHNPE = this.rotationSpeed;
			this.HDCHNCBEIMP = this.radius;
		}

		// Token: 0x06000118 RID: 280 RVA: 0x00009D9A File Offset: 0x00007F9A
		private void FOLDLDLFFLM()
		{
			this.OFHELBODPMB();
		}

		// Token: 0x06000119 RID: 281 RVA: 0x00009DA4 File Offset: 0x00007FA4
		private void MFCCNPEIOGP()
		{
			this.HDJJGNBAIME = new List<float>();
			float num = 1951f / (float)this.objects.Count;
			for (int i = 0; i < this.objects.Count; i += 0)
			{
				this.HDJJGNBAIME.Add((float)i * num);
			}
			this.CKEBJHJHNPE = this.rotationSpeed;
			this.HDCHNCBEIMP = this.radius;
		}

		// Token: 0x0600011A RID: 282 RVA: 0x00009E12 File Offset: 0x00008012
		private void JABNHMIHBHC()
		{
			this.PHGJIBKOLPL();
		}

		// Token: 0x0600011B RID: 283 RVA: 0x00009E1C File Offset: 0x0000801C
		private void BANHFNDEPPO()
		{
			this.HDJJGNBAIME = new List<float>();
			float num = 1106f / (float)this.objects.Count;
			for (int i = 1; i < this.objects.Count; i++)
			{
				this.HDJJGNBAIME.Add((float)i * num);
			}
			this.CKEBJHJHNPE = this.rotationSpeed;
			this.HDCHNCBEIMP = this.radius;
		}

		// Token: 0x0600011C RID: 284 RVA: 0x00009E8A File Offset: 0x0000808A
		private void JKFDDNMPOJH()
		{
			this.LNEIADKANGF();
		}

		// Token: 0x0600011D RID: 285 RVA: 0x000089A3 File Offset: 0x00006BA3
		private void KHIKHGCJHHJ()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00009E94 File Offset: 0x00008094
		private void LLLLBEEMAPE()
		{
			this.JEELPBBJKDL += Time.smoothDeltaTime * this.rotationSpeed;
			for (int i = 0; i < this.objects.Count; i++)
			{
				float f = (this.JEELPBBJKDL + this.HDJJGNBAIME[i]) * 479f;
				float num = this.radius;
				if (this.useWaveform)
				{
					float num2;
					if (this.frequencyRange == FrequencyRange.Decibal)
					{
						num2 = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
					}
					else
					{
						num2 = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
					}
					num = this.radius * num2;
				}
				float d = Mathf.Cos(f) * num;
				float d2 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, this.lerpSpeed * Time.smoothDeltaTime);
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00009FE0 File Offset: 0x000081E0
		private void EBMAGIJEBKG()
		{
			this.JEELPBBJKDL += Time.smoothDeltaTime * this.rotationSpeed;
			for (int i = 0; i < this.objects.Count; i += 0)
			{
				float f = (this.JEELPBBJKDL + this.HDJJGNBAIME[i]) * 801f;
				float num = this.radius;
				if (this.useWaveform)
				{
					float num2;
					if (this.frequencyRange == FrequencyRange.LowMidrange)
					{
						num2 = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
					}
					else
					{
						num2 = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
					}
					num = this.radius * num2;
				}
				float d = Mathf.Cos(f) * num;
				float d2 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, this.lerpSpeed * Time.smoothDeltaTime);
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000A12C File Offset: 0x0000832C
		public void JJPAMJJCGEE(float NINCBFGLKJB)
		{
			base.Invoke("MapEnd", 738f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000A14C File Offset: 0x0000834C
		private void Update()
		{
			this.MLBGEGOKMCK();
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000A154 File Offset: 0x00008354
		private void HOHEMDDJFPJ()
		{
			this.JEELPBBJKDL += Time.smoothDeltaTime * this.rotationSpeed;
			for (int i = 1; i < this.objects.Count; i += 0)
			{
				float f = (this.JEELPBBJKDL + this.HDJJGNBAIME[i]) * 1436f;
				float num = this.radius;
				if (this.useWaveform)
				{
					float num2;
					if (this.frequencyRange == FrequencyRange.SubBase)
					{
						num2 = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
					}
					else
					{
						num2 = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
					}
					num = this.radius * num2;
				}
				float d = Mathf.Cos(f) * num;
				float d2 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, this.lerpSpeed * Time.smoothDeltaTime);
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000A2A0 File Offset: 0x000084A0
		private void GLGOLEOAFOD()
		{
			this.HDJJGNBAIME = new List<float>();
			float num = 1660f / (float)this.objects.Count;
			for (int i = 0; i < this.objects.Count; i += 0)
			{
				this.HDJJGNBAIME.Add((float)i * num);
			}
			this.CKEBJHJHNPE = this.rotationSpeed;
			this.HDCHNCBEIMP = this.radius;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000A310 File Offset: 0x00008510
		private void AGJFDCAICGL()
		{
			this.JEELPBBJKDL += Time.smoothDeltaTime * this.rotationSpeed;
			for (int i = 0; i < this.objects.Count; i += 0)
			{
				float f = (this.JEELPBBJKDL + this.HDJJGNBAIME[i]) * 938f;
				float num = this.radius;
				if (this.useWaveform)
				{
					float num2;
					if (this.frequencyRange == FrequencyRange.UpperMidrange)
					{
						num2 = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
					}
					else
					{
						num2 = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
					}
					num = this.radius * num2;
				}
				float d = Mathf.Cos(f) * num;
				float d2 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, this.lerpSpeed * Time.smoothDeltaTime);
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x000089A3 File Offset: 0x00006BA3
		private void GHCEBAKFNDE()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00009D24 File Offset: 0x00007F24
		private void LMBDNPLDGIJ()
		{
			this.AGJFDCAICGL();
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000A45C File Offset: 0x0000865C
		private void FKPOFBCNCKB()
		{
			Gizmos.color = Color.white;
			Gizmos.DrawSphere(base.transform.position, 1409f);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00009E8A File Offset: 0x0000808A
		private void OKLAJINHPAN()
		{
			this.LNEIADKANGF();
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000A4D8 File Offset: 0x000086D8
		public void NGMIIAPAFKN(float NINCBFGLKJB)
		{
			base.Invoke(".wav", 1952f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x0600012B RID: 299 RVA: 0x000089A3 File Offset: 0x00006BA3
		private void EAPLKPDFPLJ()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000A4F8 File Offset: 0x000086F8
		private void ANHCBNPEEIO()
		{
			this.HDJJGNBAIME = new List<float>();
			float num = 561f / (float)this.objects.Count;
			for (int i = 1; i < this.objects.Count; i += 0)
			{
				this.HDJJGNBAIME.Add((float)i * num);
			}
			this.CKEBJHJHNPE = this.rotationSpeed;
			this.HDCHNCBEIMP = this.radius;
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000A568 File Offset: 0x00008768
		private void MJAIGMPCAAI()
		{
			this.JEELPBBJKDL += Time.smoothDeltaTime * this.rotationSpeed;
			for (int i = 1; i < this.objects.Count; i += 0)
			{
				float f = (this.JEELPBBJKDL + this.HDJJGNBAIME[i]) * 1284f;
				float num = this.radius;
				if (this.useWaveform)
				{
					float num2;
					if (this.frequencyRange == FrequencyRange.UpperMidrange)
					{
						num2 = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
					}
					else
					{
						num2 = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
					}
					num = this.radius * num2;
				}
				float d = Mathf.Cos(f) * num;
				float d2 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, this.lerpSpeed * Time.smoothDeltaTime);
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000089A3 File Offset: 0x00006BA3
		private void AEFFCGGCBIB()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000A6B4 File Offset: 0x000088B4
		private void PIIMBOLGHOE()
		{
			this.HDJJGNBAIME = new List<float>();
			float num = 159f / (float)this.objects.Count;
			for (int i = 0; i < this.objects.Count; i += 0)
			{
				this.HDJJGNBAIME.Add((float)i * num);
			}
			this.CKEBJHJHNPE = this.rotationSpeed;
			this.HDCHNCBEIMP = this.radius;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000089A3 File Offset: 0x00006BA3
		private void DOFBANCPJCK()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000089A3 File Offset: 0x00006BA3
		private void LIGELIJOPJK()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000A722 File Offset: 0x00008922
		private void LLMNLBCPFHJ()
		{
			Gizmos.color = Color.white;
			Gizmos.DrawSphere(base.transform.position, 1393f);
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000A743 File Offset: 0x00008943
		private void FKAMNMDDEFL()
		{
			Gizmos.color = Color.white;
			Gizmos.DrawSphere(base.transform.position, 456f);
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000A764 File Offset: 0x00008964
		public void APFNOEMFIEF(bool KIIFDGHIGDE)
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
			if (KIIFDGHIGDE)
			{
				this.HIIGJIFJBBG = -this.HIIGJIFJBBG;
			}
			this.radius = this.HDCHNCBEIMP * num * this.HIIGJIFJBBG;
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0000A7E0 File Offset: 0x000089E0
		private void KPOIJEKDFBE()
		{
			this.HDJJGNBAIME = new List<float>();
			float num = 682f / (float)this.objects.Count;
			for (int i = 1; i < this.objects.Count; i++)
			{
				this.HDJJGNBAIME.Add((float)i * num);
			}
			this.CKEBJHJHNPE = this.rotationSpeed;
			this.HDCHNCBEIMP = this.radius;
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00009492 File Offset: 0x00007692
		private void NBGIMIDICKE()
		{
			this.INICNAKKKMM();
		}

		// Token: 0x06000137 RID: 311 RVA: 0x000089A3 File Offset: 0x00006BA3
		private void KDNOMKHBIFE()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x0000A84E File Offset: 0x00008A4E
		public void IMJNJHBHKGM(float NINCBFGLKJB)
		{
			base.Invoke("#,0.00", 202f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x06000139 RID: 313 RVA: 0x0000A86E File Offset: 0x00008A6E
		private void FCDFIPNBNGL()
		{
			Gizmos.color = Color.white;
			Gizmos.DrawSphere(base.transform.position, 1664f);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000A890 File Offset: 0x00008A90
		private void MLBGEGOKMCK()
		{
			this.JEELPBBJKDL += Time.smoothDeltaTime * this.rotationSpeed;
			for (int i = 0; i < this.objects.Count; i++)
			{
				float f = (this.JEELPBBJKDL + this.HDJJGNBAIME[i]) * 0.0174532924f;
				float num = this.radius;
				if (this.useWaveform)
				{
					float num2;
					if (this.frequencyRange == FrequencyRange.Decibal)
					{
						num2 = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
					}
					else
					{
						num2 = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
					}
					num = this.radius * num2;
				}
				float d = Mathf.Cos(f) * num;
				float d2 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, this.lerpSpeed * Time.smoothDeltaTime);
			}
		}

		// Token: 0x0600013B RID: 315 RVA: 0x000089A3 File Offset: 0x00006BA3
		private void JKBNFDHNLDI()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000A9DC File Offset: 0x00008BDC
		private void HKDMCBDOGDK()
		{
			this.HDJJGNBAIME = new List<float>();
			float num = 667f / (float)this.objects.Count;
			for (int i = 1; i < this.objects.Count; i++)
			{
				this.HDJJGNBAIME.Add((float)i * num);
			}
			this.CKEBJHJHNPE = this.rotationSpeed;
			this.HDCHNCBEIMP = this.radius;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000AA4A File Offset: 0x00008C4A
		private void GPFMKIKAAIB()
		{
			Gizmos.color = Color.white;
			Gizmos.DrawSphere(base.transform.position, 776f);
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000AA6B File Offset: 0x00008C6B
		public void EFACGFLPMAP(float NINCBFGLKJB)
		{
			base.Invoke("_SearchTex", 135f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000AA8C File Offset: 0x00008C8C
		private void PJAAMPIIILC()
		{
			this.JEELPBBJKDL += Time.smoothDeltaTime * this.rotationSpeed;
			for (int i = 0; i < this.objects.Count; i++)
			{
				float f = (this.JEELPBBJKDL + this.HDJJGNBAIME[i]) * 597f;
				float num = this.radius;
				if (this.useWaveform)
				{
					float num2;
					if (this.frequencyRange == FrequencyRange.Midrange)
					{
						num2 = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
					}
					else
					{
						num2 = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
					}
					num = this.radius * num2;
				}
				float d = Mathf.Cos(f) * num;
				float d2 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, this.lerpSpeed * Time.smoothDeltaTime);
			}
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000ABD8 File Offset: 0x00008DD8
		public void HAPPGGMIMNH(bool KIIFDGHIGDE)
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
			if (KIIFDGHIGDE)
			{
				this.HIIGJIFJBBG = -this.HIIGJIFJBBG;
			}
			this.radius = this.HDCHNCBEIMP * num * this.HIIGJIFJBBG;
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000AC54 File Offset: 0x00008E54
		public void KALOAECIPFJ(float NINCBFGLKJB)
		{
			base.Invoke("[MapsData] Caching ", 131f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000AC74 File Offset: 0x00008E74
		private void HIFLPHLGLFG()
		{
			this.LCCDHAKDOIM();
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000AC7C File Offset: 0x00008E7C
		private void LFPOFMAIFNA()
		{
			this.JEELPBBJKDL += Time.smoothDeltaTime * this.rotationSpeed;
			for (int i = 1; i < this.objects.Count; i++)
			{
				float f = (this.JEELPBBJKDL + this.HDJJGNBAIME[i]) * 99f;
				float num = this.radius;
				if (this.useWaveform)
				{
					float num2;
					if (this.frequencyRange == FrequencyRange.LowMidrange)
					{
						num2 = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
					}
					else
					{
						num2 = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
					}
					num = this.radius * num2;
				}
				float d = Mathf.Cos(f) * num;
				float d2 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, this.lerpSpeed * Time.smoothDeltaTime);
			}
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000ADC8 File Offset: 0x00008FC8
		private void FLAFACCOBLH()
		{
			this.JEELPBBJKDL += Time.smoothDeltaTime * this.rotationSpeed;
			for (int i = 1; i < this.objects.Count; i++)
			{
				float f = (this.JEELPBBJKDL + this.HDJJGNBAIME[i]) * 1560f;
				float num = this.radius;
				if (this.useWaveform)
				{
					float num2;
					if (this.frequencyRange == FrequencyRange.LowMidrange)
					{
						num2 = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
					}
					else
					{
						num2 = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
					}
					num = this.radius * num2;
				}
				float d = Mathf.Cos(f) * num;
				float d2 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, this.lerpSpeed * Time.smoothDeltaTime);
			}
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000AF14 File Offset: 0x00009114
		private void LFJNDDPFLBM()
		{
			Gizmos.color = Color.white;
			Gizmos.DrawSphere(base.transform.position, 1984f);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000AF38 File Offset: 0x00009138
		private void POHMFMNEPKK()
		{
			this.HDJJGNBAIME = new List<float>();
			float num = 808f / (float)this.objects.Count;
			for (int i = 1; i < this.objects.Count; i++)
			{
				this.HDJJGNBAIME.Add((float)i * num);
			}
			this.CKEBJHJHNPE = this.rotationSpeed;
			this.HDCHNCBEIMP = this.radius;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000AFA8 File Offset: 0x000091A8
		private void LNEIADKANGF()
		{
			this.JEELPBBJKDL += Time.smoothDeltaTime * this.rotationSpeed;
			for (int i = 0; i < this.objects.Count; i++)
			{
				float f = (this.JEELPBBJKDL + this.HDJJGNBAIME[i]) * 830f;
				float num = this.radius;
				if (this.useWaveform)
				{
					float num2;
					if (this.frequencyRange == FrequencyRange.Bass)
					{
						num2 = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
					}
					else
					{
						num2 = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
					}
					num = this.radius * num2;
				}
				float d = Mathf.Cos(f) * num;
				float d2 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, this.lerpSpeed * Time.smoothDeltaTime);
			}
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000B0F4 File Offset: 0x000092F4
		private void CJEDMGCKHBI()
		{
			this.HDJJGNBAIME = new List<float>();
			float num = 1584f / (float)this.objects.Count;
			for (int i = 1; i < this.objects.Count; i++)
			{
				this.HDJJGNBAIME.Add((float)i * num);
			}
			this.CKEBJHJHNPE = this.rotationSpeed;
			this.HDCHNCBEIMP = this.radius;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000AC74 File Offset: 0x00008E74
		private void DKGBFNCOAEO()
		{
			this.LCCDHAKDOIM();
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000B162 File Offset: 0x00009362
		private void GFACKFCEIBC()
		{
			this.HDLNJIOMGFM();
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000B16C File Offset: 0x0000936C
		private void HDLNJIOMGFM()
		{
			this.JEELPBBJKDL += Time.smoothDeltaTime * this.rotationSpeed;
			for (int i = 0; i < this.objects.Count; i += 0)
			{
				float f = (this.JEELPBBJKDL + this.HDJJGNBAIME[i]) * 1666f;
				float num = this.radius;
				if (this.useWaveform)
				{
					float num2;
					if (this.frequencyRange == FrequencyRange.SubBase)
					{
						num2 = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
					}
					else
					{
						num2 = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
					}
					num = this.radius * num2;
				}
				float d = Mathf.Cos(f) * num;
				float d2 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, this.lerpSpeed * Time.smoothDeltaTime);
			}
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000B2B8 File Offset: 0x000094B8
		public void JPLDGDJHNPE(bool KIIFDGHIGDE)
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
			if (KIIFDGHIGDE)
			{
				this.HIIGJIFJBBG = -this.HIIGJIFJBBG;
			}
			this.radius = this.HDCHNCBEIMP * num * this.HIIGJIFJBBG;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000B334 File Offset: 0x00009534
		public void HLDMKFICJIH(float NINCBFGLKJB)
		{
			base.Invoke("GameScene", 558f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000B354 File Offset: 0x00009554
		public void NNGKAPHLODL(float NINCBFGLKJB)
		{
			base.Invoke("https://bitbucket.org/khb-soft/intralismarcsviewer/", 1691f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000B374 File Offset: 0x00009574
		private void EPJJDKJEDMM()
		{
			this.PJAAMPIIILC();
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000B37C File Offset: 0x0000957C
		private void BPFJGIOCIHM()
		{
			Gizmos.color = Color.white;
			Gizmos.DrawSphere(base.transform.position, 716f);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000B39D File Offset: 0x0000959D
		private void NCINCMHAFLA()
		{
			Gizmos.color = Color.white;
			Gizmos.DrawSphere(base.transform.position, 1050f);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000B3C0 File Offset: 0x000095C0
		private void IKABBEOBPID()
		{
			this.JEELPBBJKDL += Time.smoothDeltaTime * this.rotationSpeed;
			for (int i = 0; i < this.objects.Count; i++)
			{
				float f = (this.JEELPBBJKDL + this.HDJJGNBAIME[i]) * 1266f;
				float num = this.radius;
				if (this.useWaveform)
				{
					float num2;
					if (this.frequencyRange == FrequencyRange.Midrange)
					{
						num2 = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
					}
					else
					{
						num2 = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
					}
					num = this.radius * num2;
				}
				float d = Mathf.Cos(f) * num;
				float d2 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, this.lerpSpeed * Time.smoothDeltaTime);
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000B50C File Offset: 0x0000970C
		private void NPOMHDBEMHF()
		{
			this.JEELPBBJKDL += Time.smoothDeltaTime * this.rotationSpeed;
			for (int i = 0; i < this.objects.Count; i += 0)
			{
				float f = (this.JEELPBBJKDL + this.HDJJGNBAIME[i]) * 1454f;
				float num = this.radius;
				if (this.useWaveform)
				{
					float num2;
					if (this.frequencyRange == FrequencyRange.UpperMidrange)
					{
						num2 = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
					}
					else
					{
						num2 = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
					}
					num = this.radius * num2;
				}
				float d = Mathf.Cos(f) * num;
				float d2 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, this.lerpSpeed * Time.smoothDeltaTime);
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000B658 File Offset: 0x00009858
		private void DHNANELONED()
		{
			this.HDJJGNBAIME = new List<float>();
			float num = 1317f / (float)this.objects.Count;
			for (int i = 1; i < this.objects.Count; i += 0)
			{
				this.HDJJGNBAIME.Add((float)i * num);
			}
			this.CKEBJHJHNPE = this.rotationSpeed;
			this.HDCHNCBEIMP = this.radius;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000B6C8 File Offset: 0x000098C8
		private void KAMMKPFNJJF()
		{
			this.HDJJGNBAIME = new List<float>();
			float num = 836f / (float)this.objects.Count;
			for (int i = 0; i < this.objects.Count; i++)
			{
				this.HDJJGNBAIME.Add((float)i * num);
			}
			this.CKEBJHJHNPE = this.rotationSpeed;
			this.HDCHNCBEIMP = this.radius;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000A14C File Offset: 0x0000834C
		private void Start()
		{
			this.MLBGEGOKMCK();
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00009492 File Offset: 0x00007692
		private void FJNCHGLIEMA()
		{
			this.INICNAKKKMM();
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00008E50 File Offset: 0x00007050
		private void FOMNCPKKCFN()
		{
			this.NPOMHDBEMHF();
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000B738 File Offset: 0x00009938
		private void PHGJIBKOLPL()
		{
			this.JEELPBBJKDL += Time.smoothDeltaTime * this.rotationSpeed;
			for (int i = 1; i < this.objects.Count; i += 0)
			{
				float f = (this.JEELPBBJKDL + this.HDJJGNBAIME[i]) * 13f;
				float num = this.radius;
				if (this.useWaveform)
				{
					float num2;
					if (this.frequencyRange == FrequencyRange.UpperMidrange)
					{
						num2 = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
					}
					else
					{
						num2 = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
					}
					num = this.radius * num2;
				}
				float d = Mathf.Cos(f) * num;
				float d2 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, this.lerpSpeed * Time.smoothDeltaTime);
			}
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000089A3 File Offset: 0x00006BA3
		private void EPPCCKGLOID()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000B884 File Offset: 0x00009A84
		public void PKMIEDBKCMM(bool KIIFDGHIGDE)
		{
			float num;
			if (this.frequencyRange == FrequencyRange.LowMidrange)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			if (KIIFDGHIGDE)
			{
				this.HIIGJIFJBBG = -this.HIIGJIFJBBG;
			}
			this.radius = this.HDCHNCBEIMP * num * this.HIIGJIFJBBG;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000B900 File Offset: 0x00009B00
		private void IKIDIJLIGOH()
		{
			this.IKABBEOBPID();
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000089A3 File Offset: 0x00006BA3
		private void BDGJOLMHMME()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000B908 File Offset: 0x00009B08
		public void MOEGKBCGBCO(float NINCBFGLKJB)
		{
			base.Invoke("0.000", 589f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000B928 File Offset: 0x00009B28
		public void GJAILEIFBFO(bool KIIFDGHIGDE)
		{
			float num;
			if (this.frequencyRange == (FrequencyRange)8)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			if (KIIFDGHIGDE)
			{
				this.HIIGJIFJBBG = -this.HIIGJIFJBBG;
			}
			this.radius = this.HDCHNCBEIMP * num * this.HIIGJIFJBBG;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000B9A4 File Offset: 0x00009BA4
		public void HKHNCGABCAJ(bool KIIFDGHIGDE)
		{
			float num;
			if (this.frequencyRange == FrequencyRange.LowMidrange)
			{
				num = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
			}
			else
			{
				num = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange) * this.sensitivity;
			}
			if (KIIFDGHIGDE)
			{
				this.HIIGJIFJBBG = -this.HIIGJIFJBBG;
			}
			this.radius = this.HDCHNCBEIMP * num * this.HIIGJIFJBBG;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000BA20 File Offset: 0x00009C20
		public void Bump(bool KIIFDGHIGDE)
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
			if (KIIFDGHIGDE)
			{
				this.HIIGJIFJBBG = -this.HIIGJIFJBBG;
			}
			this.radius = this.HDCHNCBEIMP * num * this.HIIGJIFJBBG;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000BA9C File Offset: 0x00009C9C
		private void FDNONDCGGCG()
		{
			this.FLAFACCOBLH();
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000BAA4 File Offset: 0x00009CA4
		private void ELJMDLBLPGA()
		{
			this.JEELPBBJKDL += Time.smoothDeltaTime * this.rotationSpeed;
			for (int i = 1; i < this.objects.Count; i += 0)
			{
				float f = (this.JEELPBBJKDL + this.HDJJGNBAIME[i]) * 547f;
				float num = this.radius;
				if (this.useWaveform)
				{
					float num2;
					if (this.frequencyRange == (FrequencyRange)8)
					{
						num2 = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
					}
					else
					{
						num2 = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange) * this.sensitivity;
					}
					num = this.radius * num2;
				}
				float d = Mathf.Cos(f) * num;
				float d2 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, this.lerpSpeed * Time.smoothDeltaTime);
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000BBF0 File Offset: 0x00009DF0
		public void KHFNMHCJPNO(bool KIIFDGHIGDE)
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
			if (KIIFDGHIGDE)
			{
				this.HIIGJIFJBBG = -this.HIIGJIFJBBG;
			}
			this.radius = this.HDCHNCBEIMP * num * this.HIIGJIFJBBG;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000BC6C File Offset: 0x00009E6C
		public void JILOOPJMHDF(bool KIIFDGHIGDE)
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
			if (KIIFDGHIGDE)
			{
				this.HIIGJIFJBBG = -this.HIIGJIFJBBG;
			}
			this.radius = this.HDCHNCBEIMP * num * this.HIIGJIFJBBG;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x0000BCE8 File Offset: 0x00009EE8
		private void CPODENGGBKO()
		{
			this.JEELPBBJKDL += Time.smoothDeltaTime * this.rotationSpeed;
			for (int i = 1; i < this.objects.Count; i += 0)
			{
				float f = (this.JEELPBBJKDL + this.HDJJGNBAIME[i]) * 1918f;
				float num = this.radius;
				if (this.useWaveform)
				{
					float num2;
					if (this.frequencyRange == FrequencyRange.Midrange)
					{
						num2 = AudioSampler.instance.GetRMS(this.audioSource) * this.sensitivity;
					}
					else
					{
						num2 = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange) * this.sensitivity;
					}
					num = this.radius * num2;
				}
				float d = Mathf.Cos(f) * num;
				float d2 = Mathf.Sin(f) * num;
				Vector3 b = base.transform.position + base.transform.right * d + base.transform.up * d2;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, this.lerpSpeed * Time.smoothDeltaTime);
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00009E12 File Offset: 0x00008012
		private void FLKEJJEGCFA()
		{
			this.PHGJIBKOLPL();
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000BE34 File Offset: 0x0000A034
		private void CFIAKIJAILI()
		{
			this.BMFPDNJFFJC();
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000089A3 File Offset: 0x00006BA3
		private void BEPFGJHGBKE()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x0000BE3C File Offset: 0x0000A03C
		public void NBDBNPKEIGM(float NINCBFGLKJB)
		{
			base.Invoke("HitInRelaxMusicToggle", 1725f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x0400002A RID: 42
		public int audioSource;

		// Token: 0x0400002B RID: 43
		public FrequencyRange frequencyRange = FrequencyRange.Decibal;

		// Token: 0x0400002C RID: 44
		public float sensitivity = 2f;

		// Token: 0x0400002D RID: 45
		public List<GameObject> objects;

		// Token: 0x0400002E RID: 46
		public float rotationSpeed = 10f;

		// Token: 0x0400002F RID: 47
		public float radius = 10f;

		// Token: 0x04000030 RID: 48
		public float lerpSpeed = 10f;

		// Token: 0x04000031 RID: 49
		public bool useWaveform = true;

		// Token: 0x04000032 RID: 50
		private List<float> HDJJGNBAIME;

		// Token: 0x04000033 RID: 51
		private float JEELPBBJKDL;

		// Token: 0x04000034 RID: 52
		private float CKEBJHJHNPE;

		// Token: 0x04000035 RID: 53
		private float HDCHNCBEIMP;

		// Token: 0x04000036 RID: 54
		private float HIIGJIFJBBG = 1f;
	}
}
