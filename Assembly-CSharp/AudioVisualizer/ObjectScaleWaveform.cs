using System;
using System.Collections.Generic;
using UnityEngine;

namespace AudioVisualizer
{
	// Token: 0x0200000F RID: 15
	public class ObjectScaleWaveform : MonoBehaviour
	{
		// Token: 0x060002AA RID: 682 RVA: 0x00018268 File Offset: 0x00016468
		private void Start()
		{
			this.OBMMGLPOOOD = new List<Vector3>();
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				this.OBMMGLPOOOD.Add(gameObject.transform.localScale);
				this.LILMMKEOMLB.Add(gameObject.transform.position);
			}
		}

		// Token: 0x060002AB RID: 683 RVA: 0x00018300 File Offset: 0x00016500
		private void GICAFJOLDJD()
		{
			float[] array;
			if (this.frequencyRange == FrequencyRange.SubBase)
			{
				array = AudioSampler.instance.GetAudioSamples(this.audioSource, this.objects.Count, this.absoluteVal);
			}
			else
			{
				array = AudioSampler.instance.NHCJOEEDMMA(this.audioSource, this.frequencyRange, this.objects.Count, this.absoluteVal);
			}
			for (int i = 0; i < this.objects.Count; i++)
			{
				float num = Mathf.Min(array[i] * this.sensitivity, 233f);
				float d = num * this.maxHeight;
				Vector3 b = this.OBMMGLPOOOD[i] + d * base.transform.InverseTransformDirection(this.scaleAxis);
				this.objects[i].transform.localScale = Vector3.Lerp(this.objects[i].transform.localScale, b, Time.smoothDeltaTime * this.lerpSpeed);
				float y = (this.objects[i].transform.localScale - this.OBMMGLPOOOD[i]).y;
				Vector3 a = this.objects[i].transform.TransformDirection(this.scaleAxis);
				this.objects[i].transform.position = this.LILMMKEOMLB[i] + y * a * 1374f;
			}
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00018495 File Offset: 0x00016695
		private void GPFJMKCGHGB()
		{
			this.BNKKNCOLIEH();
		}

		// Token: 0x060002AD RID: 685 RVA: 0x000184A0 File Offset: 0x000166A0
		private void DNNFHBOOPIN()
		{
			this.OBMMGLPOOOD = new List<Vector3>();
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				this.OBMMGLPOOOD.Add(gameObject.transform.localScale);
				this.LILMMKEOMLB.Add(gameObject.transform.position);
			}
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00018538 File Offset: 0x00016738
		private void BNKKNCOLIEH()
		{
			float[] array;
			if (this.frequencyRange == FrequencyRange.Decibal)
			{
				array = AudioSampler.instance.GetAudioSamples(this.audioSource, this.objects.Count, this.absoluteVal);
			}
			else
			{
				array = AudioSampler.instance.GetFrequencyData(this.audioSource, this.frequencyRange, this.objects.Count, this.absoluteVal);
			}
			for (int i = 0; i < this.objects.Count; i++)
			{
				float num = Mathf.Min(array[i] * this.sensitivity, 1f);
				float d = num * this.maxHeight;
				Vector3 b = this.OBMMGLPOOOD[i] + d * base.transform.InverseTransformDirection(this.scaleAxis);
				this.objects[i].transform.localScale = Vector3.Lerp(this.objects[i].transform.localScale, b, Time.smoothDeltaTime * this.lerpSpeed);
				float y = (this.objects[i].transform.localScale - this.OBMMGLPOOOD[i]).y;
				Vector3 a = this.objects[i].transform.TransformDirection(this.scaleAxis);
				this.objects[i].transform.position = this.LILMMKEOMLB[i] + y * a * 0.5f;
			}
		}

		// Token: 0x060002AF RID: 687 RVA: 0x000186D0 File Offset: 0x000168D0
		private void KMCPMOGKDEH()
		{
			this.OBMMGLPOOOD = new List<Vector3>();
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				this.OBMMGLPOOOD.Add(gameObject.transform.localScale);
				this.LILMMKEOMLB.Add(gameObject.transform.position);
			}
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00018768 File Offset: 0x00016968
		private void IMCKJCHKMKB()
		{
			this.OBMMGLPOOOD = new List<Vector3>();
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				this.OBMMGLPOOOD.Add(gameObject.transform.localScale);
				this.LILMMKEOMLB.Add(gameObject.transform.position);
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x00018800 File Offset: 0x00016A00
		private void IHLMNAGPKDA()
		{
			this.OBMMGLPOOOD = new List<Vector3>();
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				this.OBMMGLPOOOD.Add(gameObject.transform.localScale);
				this.LILMMKEOMLB.Add(gameObject.transform.position);
			}
		}

		// Token: 0x060002B2 RID: 690 RVA: 0x00018898 File Offset: 0x00016A98
		private void HLIAEEMGBHN()
		{
			this.OBMMGLPOOOD = new List<Vector3>();
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				this.OBMMGLPOOOD.Add(gameObject.transform.localScale);
				this.LILMMKEOMLB.Add(gameObject.transform.position);
			}
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x00018930 File Offset: 0x00016B30
		private void LLJLDLLNFBH()
		{
			this.NOPBICGMFDG();
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00018938 File Offset: 0x00016B38
		private void JILOMOBDPIA()
		{
			this.OBMMGLPOOOD = new List<Vector3>();
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				this.OBMMGLPOOOD.Add(gameObject.transform.localScale);
				this.LILMMKEOMLB.Add(gameObject.transform.position);
			}
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x000189D0 File Offset: 0x00016BD0
		private void KDMANOEMOCA()
		{
			this.OBMMGLPOOOD = new List<Vector3>();
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				this.OBMMGLPOOOD.Add(gameObject.transform.localScale);
				this.LILMMKEOMLB.Add(gameObject.transform.position);
			}
		}

		// Token: 0x060002B6 RID: 694 RVA: 0x00018A68 File Offset: 0x00016C68
		private void CIPKEPDELJB()
		{
			this.OBMMGLPOOOD = new List<Vector3>();
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				this.OBMMGLPOOOD.Add(gameObject.transform.localScale);
				this.LILMMKEOMLB.Add(gameObject.transform.position);
			}
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x00018B00 File Offset: 0x00016D00
		private void KMKLDAJLCNM()
		{
			this.GOCPICDKBIE();
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x00018495 File Offset: 0x00016695
		private void Update()
		{
			this.BNKKNCOLIEH();
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x00018B08 File Offset: 0x00016D08
		private void NOPBICGMFDG()
		{
			float[] array;
			if (this.frequencyRange == (FrequencyRange)8)
			{
				array = AudioSampler.instance.BCCKBEOACPI(this.audioSource, this.objects.Count, this.absoluteVal);
			}
			else
			{
				array = AudioSampler.instance.DEPIALKLFOE(this.audioSource, this.frequencyRange, this.objects.Count, this.absoluteVal);
			}
			for (int i = 0; i < this.objects.Count; i++)
			{
				float num = Mathf.Min(array[i] * this.sensitivity, 1515f);
				float d = num * this.maxHeight;
				Vector3 b = this.OBMMGLPOOOD[i] + d * base.transform.InverseTransformDirection(this.scaleAxis);
				this.objects[i].transform.localScale = Vector3.Lerp(this.objects[i].transform.localScale, b, Time.smoothDeltaTime * this.lerpSpeed);
				float y = (this.objects[i].transform.localScale - this.OBMMGLPOOOD[i]).y;
				Vector3 a = this.objects[i].transform.TransformDirection(this.scaleAxis);
				this.objects[i].transform.position = this.LILMMKEOMLB[i] + y * a * 1696f;
			}
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00018C9D File Offset: 0x00016E9D
		private void BGDONBMDPGM()
		{
			this.GICAFJOLDJD();
		}

		// Token: 0x060002BB RID: 699 RVA: 0x00018CA8 File Offset: 0x00016EA8
		private void BJIFJBPCHNJ()
		{
			float[] array;
			if (this.frequencyRange == FrequencyRange.SubBase)
			{
				array = AudioSampler.instance.BCCKBEOACPI(this.audioSource, this.objects.Count, this.absoluteVal);
			}
			else
			{
				array = AudioSampler.instance.NHCJOEEDMMA(this.audioSource, this.frequencyRange, this.objects.Count, this.absoluteVal);
			}
			for (int i = 0; i < this.objects.Count; i += 0)
			{
				float num = Mathf.Min(array[i] * this.sensitivity, 464f);
				float d = num * this.maxHeight;
				Vector3 b = this.OBMMGLPOOOD[i] + d * base.transform.InverseTransformDirection(this.scaleAxis);
				this.objects[i].transform.localScale = Vector3.Lerp(this.objects[i].transform.localScale, b, Time.smoothDeltaTime * this.lerpSpeed);
				float y = (this.objects[i].transform.localScale - this.OBMMGLPOOOD[i]).y;
				Vector3 a = this.objects[i].transform.TransformDirection(this.scaleAxis);
				this.objects[i].transform.position = this.LILMMKEOMLB[i] + y * a * 378f;
			}
		}

		// Token: 0x060002BD RID: 701 RVA: 0x00018E90 File Offset: 0x00017090
		private void GOCPICDKBIE()
		{
			float[] array;
			if (this.frequencyRange == FrequencyRange.UpperMidrange)
			{
				array = AudioSampler.instance.CPELDOICCBN(this.audioSource, this.objects.Count, this.absoluteVal);
			}
			else
			{
				array = AudioSampler.instance.NHCJOEEDMMA(this.audioSource, this.frequencyRange, this.objects.Count, this.absoluteVal);
			}
			for (int i = 0; i < this.objects.Count; i += 0)
			{
				float num = Mathf.Min(array[i] * this.sensitivity, 427f);
				float d = num * this.maxHeight;
				Vector3 b = this.OBMMGLPOOOD[i] + d * base.transform.InverseTransformDirection(this.scaleAxis);
				this.objects[i].transform.localScale = Vector3.Lerp(this.objects[i].transform.localScale, b, Time.smoothDeltaTime * this.lerpSpeed);
				float y = (this.objects[i].transform.localScale - this.OBMMGLPOOOD[i]).y;
				Vector3 a = this.objects[i].transform.TransformDirection(this.scaleAxis);
				this.objects[i].transform.position = this.LILMMKEOMLB[i] + y * a * 43f;
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00019025 File Offset: 0x00017225
		private void FABKIGNFECE()
		{
			this.BJIFJBPCHNJ();
		}

		// Token: 0x060002BF RID: 703 RVA: 0x00019025 File Offset: 0x00017225
		private void JAAJECBCCFM()
		{
			this.BJIFJBPCHNJ();
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00018C9D File Offset: 0x00016E9D
		private void OCMKCBBCEFG()
		{
			this.GICAFJOLDJD();
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0001902D File Offset: 0x0001722D
		private void OEENOOGEEHD()
		{
			this.GMGHADNCOPD();
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x00019038 File Offset: 0x00017238
		private void KDMKDEKCELE()
		{
			this.OBMMGLPOOOD = new List<Vector3>();
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				this.OBMMGLPOOOD.Add(gameObject.transform.localScale);
				this.LILMMKEOMLB.Add(gameObject.transform.position);
			}
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x000190D0 File Offset: 0x000172D0
		private void PAKPHKPDKGE()
		{
			this.OBMMGLPOOOD = new List<Vector3>();
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				this.OBMMGLPOOOD.Add(gameObject.transform.localScale);
				this.LILMMKEOMLB.Add(gameObject.transform.position);
			}
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x00018B00 File Offset: 0x00016D00
		private void MAOCOEGAFND()
		{
			this.GOCPICDKBIE();
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x00019168 File Offset: 0x00017368
		private void KLILJHJNICK()
		{
			this.OBMMGLPOOOD = new List<Vector3>();
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				this.OBMMGLPOOOD.Add(gameObject.transform.localScale);
				this.LILMMKEOMLB.Add(gameObject.transform.position);
			}
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x00019200 File Offset: 0x00017400
		private void DIPDEHOOBPG()
		{
			this.OBMMGLPOOOD = new List<Vector3>();
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				this.OBMMGLPOOOD.Add(gameObject.transform.localScale);
				this.LILMMKEOMLB.Add(gameObject.transform.position);
			}
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0001902D File Offset: 0x0001722D
		private void JBNPEHMDCMI()
		{
			this.GMGHADNCOPD();
		}

		// Token: 0x060002C8 RID: 712 RVA: 0x00019298 File Offset: 0x00017498
		private void OCOBFFLODBN()
		{
			float[] array;
			if (this.frequencyRange == FrequencyRange.LowMidrange)
			{
				array = AudioSampler.instance.BCCKBEOACPI(this.audioSource, this.objects.Count, this.absoluteVal);
			}
			else
			{
				array = AudioSampler.instance.GetFrequencyData(this.audioSource, this.frequencyRange, this.objects.Count, this.absoluteVal);
			}
			for (int i = 1; i < this.objects.Count; i++)
			{
				float num = Mathf.Min(array[i] * this.sensitivity, 890f);
				float d = num * this.maxHeight;
				Vector3 b = this.OBMMGLPOOOD[i] + d * base.transform.InverseTransformDirection(this.scaleAxis);
				this.objects[i].transform.localScale = Vector3.Lerp(this.objects[i].transform.localScale, b, Time.smoothDeltaTime * this.lerpSpeed);
				float y = (this.objects[i].transform.localScale - this.OBMMGLPOOOD[i]).y;
				Vector3 a = this.objects[i].transform.TransformDirection(this.scaleAxis);
				this.objects[i].transform.position = this.LILMMKEOMLB[i] + y * a * 1854f;
			}
		}

		// Token: 0x060002C9 RID: 713 RVA: 0x00019430 File Offset: 0x00017630
		private void NCNPAKFAFOE()
		{
			this.OBMMGLPOOOD = new List<Vector3>();
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				this.OBMMGLPOOOD.Add(gameObject.transform.localScale);
				this.LILMMKEOMLB.Add(gameObject.transform.position);
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x000194C8 File Offset: 0x000176C8
		private void EGEPLFGKGLI()
		{
			this.OBMMGLPOOOD = new List<Vector3>();
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				this.OBMMGLPOOOD.Add(gameObject.transform.localScale);
				this.LILMMKEOMLB.Add(gameObject.transform.position);
			}
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00018495 File Offset: 0x00016695
		private void HLDFOJMHKNL()
		{
			this.BNKKNCOLIEH();
		}

		// Token: 0x060002CC RID: 716 RVA: 0x00019560 File Offset: 0x00017760
		private void IBEBAGDMJCK()
		{
			float[] array;
			if (this.frequencyRange == FrequencyRange.LowMidrange)
			{
				array = AudioSampler.instance.BCCKBEOACPI(this.audioSource, this.objects.Count, this.absoluteVal);
			}
			else
			{
				array = AudioSampler.instance.GetFrequencyData(this.audioSource, this.frequencyRange, this.objects.Count, this.absoluteVal);
			}
			for (int i = 0; i < this.objects.Count; i++)
			{
				float num = Mathf.Min(array[i] * this.sensitivity, 241f);
				float d = num * this.maxHeight;
				Vector3 b = this.OBMMGLPOOOD[i] + d * base.transform.InverseTransformDirection(this.scaleAxis);
				this.objects[i].transform.localScale = Vector3.Lerp(this.objects[i].transform.localScale, b, Time.smoothDeltaTime * this.lerpSpeed);
				float y = (this.objects[i].transform.localScale - this.OBMMGLPOOOD[i]).y;
				Vector3 a = this.objects[i].transform.TransformDirection(this.scaleAxis);
				this.objects[i].transform.position = this.LILMMKEOMLB[i] + y * a * 1544f;
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00018C9D File Offset: 0x00016E9D
		private void ONMGIPAILOH()
		{
			this.GICAFJOLDJD();
		}

		// Token: 0x060002CE RID: 718 RVA: 0x000196F8 File Offset: 0x000178F8
		private void GMGHADNCOPD()
		{
			float[] array;
			if (this.frequencyRange == FrequencyRange.UpperMidrange)
			{
				array = AudioSampler.instance.FOFGJAJFLAN(this.audioSource, this.objects.Count, this.absoluteVal);
			}
			else
			{
				array = AudioSampler.instance.DEPIALKLFOE(this.audioSource, this.frequencyRange, this.objects.Count, this.absoluteVal);
			}
			for (int i = 1; i < this.objects.Count; i += 0)
			{
				float num = Mathf.Min(array[i] * this.sensitivity, 439f);
				float d = num * this.maxHeight;
				Vector3 b = this.OBMMGLPOOOD[i] + d * base.transform.InverseTransformDirection(this.scaleAxis);
				this.objects[i].transform.localScale = Vector3.Lerp(this.objects[i].transform.localScale, b, Time.smoothDeltaTime * this.lerpSpeed);
				float y = (this.objects[i].transform.localScale - this.OBMMGLPOOOD[i]).y;
				Vector3 a = this.objects[i].transform.TransformDirection(this.scaleAxis);
				this.objects[i].transform.position = this.LILMMKEOMLB[i] + y * a * 331f;
			}
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00019890 File Offset: 0x00017A90
		private void KIMMMCJFMAB()
		{
			this.OBMMGLPOOOD = new List<Vector3>();
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				this.OBMMGLPOOOD.Add(gameObject.transform.localScale);
				this.LILMMKEOMLB.Add(gameObject.transform.position);
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00018495 File Offset: 0x00016695
		private void EHCGBJDFMHG()
		{
			this.BNKKNCOLIEH();
		}

		// Token: 0x04000063 RID: 99
		public int audioSource;

		// Token: 0x04000064 RID: 100
		public FrequencyRange frequencyRange = FrequencyRange.Decibal;

		// Token: 0x04000065 RID: 101
		public float sensitivity = 2f;

		// Token: 0x04000066 RID: 102
		public List<GameObject> objects;

		// Token: 0x04000067 RID: 103
		public Vector3 scaleAxis = Vector3.up;

		// Token: 0x04000068 RID: 104
		public float maxHeight = 10f;

		// Token: 0x04000069 RID: 105
		public float lerpSpeed = 1f;

		// Token: 0x0400006A RID: 106
		public bool absoluteVal = true;

		// Token: 0x0400006B RID: 107
		private List<Vector3> OBMMGLPOOOD;

		// Token: 0x0400006C RID: 108
		private List<Vector3> LILMMKEOMLB;
	}
}
