using System;
using System.Collections.Generic;
using UnityEngine;

namespace AudioVisualizer
{
	// Token: 0x0200000E RID: 14
	public class ObjectPositionWaveform : MonoBehaviour
	{
		// Token: 0x06000270 RID: 624 RVA: 0x0001638D File Offset: 0x0001458D
		public void DEDANNMJNOC()
		{
			this.sensitivity = 1362f;
			this.lerpSpeed = 1559f;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x000163A8 File Offset: 0x000145A8
		private void LJIHHJOAJCN()
		{
			this.MPHAHALLNON();
			for (int i = 0; i < this.objects.Count; i++)
			{
				Debug.DrawLine(this.LILMMKEOMLB[i], this.LILMMKEOMLB[i] + this.objects[i].transform.up * this.maxHeight);
			}
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0001641A File Offset: 0x0001461A
		public void GCMLEEHGBPA()
		{
			this.sensitivity = 1771f;
			this.lerpSpeed = 999f;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00016434 File Offset: 0x00014634
		private void DIPDEHOOBPG()
		{
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 item = gameObject.transform.position - base.transform.position;
				this.LILMMKEOMLB.Add(item);
			}
		}

		// Token: 0x06000274 RID: 628 RVA: 0x000164BC File Offset: 0x000146BC
		private void HMNLHMLILKD()
		{
			this.MGMHPODMFOP();
			for (int i = 1; i < this.objects.Count; i += 0)
			{
				Debug.DrawLine(this.LILMMKEOMLB[i], this.LILMMKEOMLB[i] + this.objects[i].transform.up * this.maxHeight);
			}
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00016530 File Offset: 0x00014730
		private void JHPOIOELNCG()
		{
			this.ICLDJDALNDA();
			for (int i = 1; i < this.objects.Count; i += 0)
			{
				Debug.DrawLine(this.LILMMKEOMLB[i], this.LILMMKEOMLB[i] + this.objects[i].transform.up * this.maxHeight);
			}
		}

		// Token: 0x06000276 RID: 630 RVA: 0x000165A4 File Offset: 0x000147A4
		private void DNNFHBOOPIN()
		{
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 item = gameObject.transform.position - base.transform.position;
				this.LILMMKEOMLB.Add(item);
			}
		}

		// Token: 0x06000277 RID: 631 RVA: 0x0001662C File Offset: 0x0001482C
		private void AAPKBNDHBLI()
		{
			this.ILFKOHJKPBB();
			for (int i = 0; i < this.objects.Count; i += 0)
			{
				Debug.DrawLine(this.LILMMKEOMLB[i], this.LILMMKEOMLB[i] + this.objects[i].transform.up * this.maxHeight);
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x000166A0 File Offset: 0x000148A0
		private void Update()
		{
			this.MLBGEGOKMCK();
			for (int i = 0; i < this.objects.Count; i++)
			{
				Debug.DrawLine(this.LILMMKEOMLB[i], this.LILMMKEOMLB[i] + this.objects[i].transform.up * this.maxHeight);
			}
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00016714 File Offset: 0x00014914
		private void POIMNOBDBBN()
		{
			this.HOHEMDDJFPJ();
			for (int i = 1; i < this.objects.Count; i++)
			{
				Debug.DrawLine(this.LILMMKEOMLB[i], this.LILMMKEOMLB[i] + this.objects[i].transform.up * this.maxHeight);
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00016788 File Offset: 0x00014988
		private void JMEOGJHCONJ()
		{
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 item = gameObject.transform.position - base.transform.position;
				this.LILMMKEOMLB.Add(item);
			}
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00016810 File Offset: 0x00014A10
		private void DKGBFNCOAEO()
		{
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 item = gameObject.transform.position - base.transform.position;
				this.LILMMKEOMLB.Add(item);
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00016898 File Offset: 0x00014A98
		private void HDDECCMEJKA()
		{
			this.MJAIGMPCAAI();
			for (int i = 1; i < this.objects.Count; i++)
			{
				Debug.DrawLine(this.LILMMKEOMLB[i], this.LILMMKEOMLB[i] + this.objects[i].transform.up * this.maxHeight);
			}
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0001690C File Offset: 0x00014B0C
		private void IMCKJCHKMKB()
		{
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 item = gameObject.transform.position - base.transform.position;
				this.LILMMKEOMLB.Add(item);
			}
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00016994 File Offset: 0x00014B94
		private void KIMMMCJFMAB()
		{
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 item = gameObject.transform.position - base.transform.position;
				this.LILMMKEOMLB.Add(item);
			}
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00016A1C File Offset: 0x00014C1C
		private void MKIMDFLBFOM()
		{
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 item = gameObject.transform.position - base.transform.position;
				this.LILMMKEOMLB.Add(item);
			}
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00016AA4 File Offset: 0x00014CA4
		private void ICLDJDALNDA()
		{
			float[] array;
			if (this.frequencyRange == FrequencyRange.VeryHigh)
			{
				array = AudioSampler.instance.CPELDOICCBN(this.audioSource, this.objects.Count, this.absoluteVal);
			}
			else
			{
				array = AudioSampler.instance.DEPIALKLFOE(this.audioSource, this.frequencyRange, this.objects.Count, this.absoluteVal);
			}
			for (int i = 1; i < this.objects.Count; i++)
			{
				float num = Mathf.Min(array[i] * this.sensitivity, 1104f);
				float d = num * this.maxHeight;
				Vector3 a = this.objects[i].transform.TransformDirection(this.positionAxis);
				Vector3 b = base.transform.position + this.LILMMKEOMLB[i] + d * a;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, Time.smoothDeltaTime * this.lerpSpeed);
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x00016BCE File Offset: 0x00014DCE
		public void Reset()
		{
			this.sensitivity = 2f;
			this.lerpSpeed = 1f;
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00016BE8 File Offset: 0x00014DE8
		private void CFEKMCMHHJF()
		{
			float[] array;
			if (this.frequencyRange == FrequencyRange.LowMidrange)
			{
				array = AudioSampler.instance.CPELDOICCBN(this.audioSource, this.objects.Count, this.absoluteVal);
			}
			else
			{
				array = AudioSampler.instance.NHCJOEEDMMA(this.audioSource, this.frequencyRange, this.objects.Count, this.absoluteVal);
			}
			for (int i = 1; i < this.objects.Count; i++)
			{
				float num = Mathf.Min(array[i] * this.sensitivity, 1607f);
				float d = num * this.maxHeight;
				Vector3 a = this.objects[i].transform.TransformDirection(this.positionAxis);
				Vector3 b = base.transform.position + this.LILMMKEOMLB[i] + d * a;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, Time.smoothDeltaTime * this.lerpSpeed);
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00016D14 File Offset: 0x00014F14
		private void JAAJECBCCFM()
		{
			this.MGMHPODMFOP();
			for (int i = 0; i < this.objects.Count; i++)
			{
				Debug.DrawLine(this.LILMMKEOMLB[i], this.LILMMKEOMLB[i] + this.objects[i].transform.up * this.maxHeight);
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00016D86 File Offset: 0x00014F86
		public void JHPDFCAGCHC()
		{
			this.sensitivity = 88f;
			this.lerpSpeed = 972f;
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00016DA0 File Offset: 0x00014FA0
		private void HOJMFHIPBBM()
		{
			float[] array;
			if (this.frequencyRange == FrequencyRange.High)
			{
				array = AudioSampler.instance.CPELDOICCBN(this.audioSource, this.objects.Count, this.absoluteVal);
			}
			else
			{
				array = AudioSampler.instance.NHCJOEEDMMA(this.audioSource, this.frequencyRange, this.objects.Count, this.absoluteVal);
			}
			for (int i = 0; i < this.objects.Count; i++)
			{
				float num = Mathf.Min(array[i] * this.sensitivity, 645f);
				float d = num * this.maxHeight;
				Vector3 a = this.objects[i].transform.TransformDirection(this.positionAxis);
				Vector3 b = base.transform.position + this.LILMMKEOMLB[i] + d * a;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, Time.smoothDeltaTime * this.lerpSpeed);
			}
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00016ECC File Offset: 0x000150CC
		private void MMBPLGGLPDB()
		{
			this.MJAIGMPCAAI();
			for (int i = 1; i < this.objects.Count; i += 0)
			{
				Debug.DrawLine(this.LILMMKEOMLB[i], this.LILMMKEOMLB[i] + this.objects[i].transform.up * this.maxHeight);
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00016F40 File Offset: 0x00015140
		private void CHOPDIGHJNH()
		{
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 item = gameObject.transform.position - base.transform.position;
				this.LILMMKEOMLB.Add(item);
			}
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00016FC8 File Offset: 0x000151C8
		public void MBBHOJMLCBC()
		{
			this.sensitivity = 935f;
			this.lerpSpeed = 1101f;
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00016FE0 File Offset: 0x000151E0
		private void NEKCPLGFOFD()
		{
			this.ICLDJDALNDA();
			for (int i = 0; i < this.objects.Count; i++)
			{
				Debug.DrawLine(this.LILMMKEOMLB[i], this.LILMMKEOMLB[i] + this.objects[i].transform.up * this.maxHeight);
			}
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00017054 File Offset: 0x00015254
		private void ONMGIPAILOH()
		{
			this.ICLDJDALNDA();
			for (int i = 1; i < this.objects.Count; i++)
			{
				Debug.DrawLine(this.LILMMKEOMLB[i], this.LILMMKEOMLB[i] + this.objects[i].transform.up * this.maxHeight);
			}
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000170C8 File Offset: 0x000152C8
		private void IHLMNAGPKDA()
		{
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 item = gameObject.transform.position - base.transform.position;
				this.LILMMKEOMLB.Add(item);
			}
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00017150 File Offset: 0x00015350
		private void JBNPEHMDCMI()
		{
			this.HOHEMDDJFPJ();
			for (int i = 0; i < this.objects.Count; i++)
			{
				Debug.DrawLine(this.LILMMKEOMLB[i], this.LILMMKEOMLB[i] + this.objects[i].transform.up * this.maxHeight);
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x000171C4 File Offset: 0x000153C4
		private void FEHCNJLLJMP()
		{
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 item = gameObject.transform.position - base.transform.position;
				this.LILMMKEOMLB.Add(item);
			}
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0001724C File Offset: 0x0001544C
		public void CAPPKCBFILL()
		{
			this.sensitivity = 1671f;
			this.lerpSpeed = 51f;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00017264 File Offset: 0x00015464
		private void FOMNCPKKCFN()
		{
			this.MMOPOIMFNII();
			for (int i = 0; i < this.objects.Count; i++)
			{
				Debug.DrawLine(this.LILMMKEOMLB[i], this.LILMMKEOMLB[i] + this.objects[i].transform.up * this.maxHeight);
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000172D8 File Offset: 0x000154D8
		private void GPFJMKCGHGB()
		{
			this.MMOPOIMFNII();
			for (int i = 0; i < this.objects.Count; i += 0)
			{
				Debug.DrawLine(this.LILMMKEOMLB[i], this.LILMMKEOMLB[i] + this.objects[i].transform.up * this.maxHeight);
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x0001734C File Offset: 0x0001554C
		private void FANADGBGCPI()
		{
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 item = gameObject.transform.position - base.transform.position;
				this.LILMMKEOMLB.Add(item);
			}
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000173D4 File Offset: 0x000155D4
		private void MPHAHALLNON()
		{
			float[] array;
			if (this.frequencyRange == FrequencyRange.UpperMidrange)
			{
				array = AudioSampler.instance.BCCKBEOACPI(this.audioSource, this.objects.Count, this.absoluteVal);
			}
			else
			{
				array = AudioSampler.instance.NHCJOEEDMMA(this.audioSource, this.frequencyRange, this.objects.Count, this.absoluteVal);
			}
			for (int i = 1; i < this.objects.Count; i++)
			{
				float num = Mathf.Min(array[i] * this.sensitivity, 755f);
				float d = num * this.maxHeight;
				Vector3 a = this.objects[i].transform.TransformDirection(this.positionAxis);
				Vector3 b = base.transform.position + this.LILMMKEOMLB[i] + d * a;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, Time.smoothDeltaTime * this.lerpSpeed);
			}
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00017500 File Offset: 0x00015700
		private void GPNAOAKCMHC()
		{
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 item = gameObject.transform.position - base.transform.position;
				this.LILMMKEOMLB.Add(item);
			}
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00017588 File Offset: 0x00015788
		private void OEENOOGEEHD()
		{
			this.MPHAHALLNON();
			for (int i = 0; i < this.objects.Count; i += 0)
			{
				Debug.DrawLine(this.LILMMKEOMLB[i], this.LILMMKEOMLB[i] + this.objects[i].transform.up * this.maxHeight);
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x000175FC File Offset: 0x000157FC
		private void MMOPOIMFNII()
		{
			float[] array;
			if (this.frequencyRange == FrequencyRange.LowMidrange)
			{
				array = AudioSampler.instance.FOFGJAJFLAN(this.audioSource, this.objects.Count, this.absoluteVal);
			}
			else
			{
				array = AudioSampler.instance.GetFrequencyData(this.audioSource, this.frequencyRange, this.objects.Count, this.absoluteVal);
			}
			for (int i = 1; i < this.objects.Count; i += 0)
			{
				float num = Mathf.Min(array[i] * this.sensitivity, 1240f);
				float d = num * this.maxHeight;
				Vector3 a = this.objects[i].transform.TransformDirection(this.positionAxis);
				Vector3 b = base.transform.position + this.LILMMKEOMLB[i] + d * a;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, Time.smoothDeltaTime * this.lerpSpeed);
			}
		}

		// Token: 0x06000296 RID: 662 RVA: 0x00017728 File Offset: 0x00015928
		private void LLJLDLLNFBH()
		{
			this.HOHEMDDJFPJ();
			for (int i = 0; i < this.objects.Count; i += 0)
			{
				Debug.DrawLine(this.LILMMKEOMLB[i], this.LILMMKEOMLB[i] + this.objects[i].transform.up * this.maxHeight);
			}
		}

		// Token: 0x06000297 RID: 663 RVA: 0x0001779C File Offset: 0x0001599C
		private void NBGIMIDICKE()
		{
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 item = gameObject.transform.position - base.transform.position;
				this.LILMMKEOMLB.Add(item);
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x00017824 File Offset: 0x00015A24
		private void Start()
		{
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 item = gameObject.transform.position - base.transform.position;
				this.LILMMKEOMLB.Add(item);
			}
		}

		// Token: 0x06000299 RID: 665 RVA: 0x000178AC File Offset: 0x00015AAC
		public void AIFAGDOHAGD()
		{
			this.sensitivity = 1553f;
			this.lerpSpeed = 966f;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x000178C4 File Offset: 0x00015AC4
		private void FABKIGNFECE()
		{
			this.MMOPOIMFNII();
			for (int i = 0; i < this.objects.Count; i += 0)
			{
				Debug.DrawLine(this.LILMMKEOMLB[i], this.LILMMKEOMLB[i] + this.objects[i].transform.up * this.maxHeight);
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00017936 File Offset: 0x00015B36
		public void FHPPMBEEKBL()
		{
			this.sensitivity = 416f;
			this.lerpSpeed = 945f;
		}

		// Token: 0x0600029C RID: 668 RVA: 0x00017950 File Offset: 0x00015B50
		private void HOHEMDDJFPJ()
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
			for (int i = 1; i < this.objects.Count; i += 0)
			{
				float num = Mathf.Min(array[i] * this.sensitivity, 1114f);
				float d = num * this.maxHeight;
				Vector3 a = this.objects[i].transform.TransformDirection(this.positionAxis);
				Vector3 b = base.transform.position + this.LILMMKEOMLB[i] + d * a;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, Time.smoothDeltaTime * this.lerpSpeed);
			}
		}

		// Token: 0x0600029D RID: 669 RVA: 0x00017A7C File Offset: 0x00015C7C
		private void CIPKEPDELJB()
		{
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 item = gameObject.transform.position - base.transform.position;
				this.LILMMKEOMLB.Add(item);
			}
		}

		// Token: 0x0600029E RID: 670 RVA: 0x00017B04 File Offset: 0x00015D04
		public void JOPOMLLAMKE()
		{
			this.sensitivity = 1471f;
			this.lerpSpeed = 663f;
		}

		// Token: 0x0600029F RID: 671 RVA: 0x00017B1C File Offset: 0x00015D1C
		public void IAPOBEGCHLG()
		{
			this.sensitivity = 110f;
			this.lerpSpeed = 962f;
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x00017B34 File Offset: 0x00015D34
		private void ILFKOHJKPBB()
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
			for (int i = 1; i < this.objects.Count; i++)
			{
				float num = Mathf.Min(array[i] * this.sensitivity, 703f);
				float d = num * this.maxHeight;
				Vector3 a = this.objects[i].transform.TransformDirection(this.positionAxis);
				Vector3 b = base.transform.position + this.LILMMKEOMLB[i] + d * a;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, Time.smoothDeltaTime * this.lerpSpeed);
			}
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00017C60 File Offset: 0x00015E60
		private void MGMHPODMFOP()
		{
			float[] array;
			if (this.frequencyRange == FrequencyRange.High)
			{
				array = AudioSampler.instance.BCCKBEOACPI(this.audioSource, this.objects.Count, this.absoluteVal);
			}
			else
			{
				array = AudioSampler.instance.GetFrequencyData(this.audioSource, this.frequencyRange, this.objects.Count, this.absoluteVal);
			}
			for (int i = 0; i < this.objects.Count; i += 0)
			{
				float num = Mathf.Min(array[i] * this.sensitivity, 781f);
				float d = num * this.maxHeight;
				Vector3 a = this.objects[i].transform.TransformDirection(this.positionAxis);
				Vector3 b = base.transform.position + this.LILMMKEOMLB[i] + d * a;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, Time.smoothDeltaTime * this.lerpSpeed);
			}
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00017D8C File Offset: 0x00015F8C
		private void JOACBIEHHCE()
		{
			this.MGMHPODMFOP();
			for (int i = 0; i < this.objects.Count; i++)
			{
				Debug.DrawLine(this.LILMMKEOMLB[i], this.LILMMKEOMLB[i] + this.objects[i].transform.up * this.maxHeight);
			}
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x00017E00 File Offset: 0x00016000
		private void MLBGEGOKMCK()
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
				Vector3 a = this.objects[i].transform.TransformDirection(this.positionAxis);
				Vector3 b = base.transform.position + this.LILMMKEOMLB[i] + d * a;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, Time.smoothDeltaTime * this.lerpSpeed);
			}
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00017F2C File Offset: 0x0001612C
		private void MJAIGMPCAAI()
		{
			float[] array;
			if (this.frequencyRange == FrequencyRange.VeryHigh)
			{
				array = AudioSampler.instance.GetAudioSamples(this.audioSource, this.objects.Count, this.absoluteVal);
			}
			else
			{
				array = AudioSampler.instance.GetFrequencyData(this.audioSource, this.frequencyRange, this.objects.Count, this.absoluteVal);
			}
			for (int i = 0; i < this.objects.Count; i++)
			{
				float num = Mathf.Min(array[i] * this.sensitivity, 1866f);
				float d = num * this.maxHeight;
				Vector3 a = this.objects[i].transform.TransformDirection(this.positionAxis);
				Vector3 b = base.transform.position + this.LILMMKEOMLB[i] + d * a;
				this.objects[i].transform.position = Vector3.Lerp(this.objects[i].transform.position, b, Time.smoothDeltaTime * this.lerpSpeed);
			}
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x00018056 File Offset: 0x00016256
		public void LECPHJOIGKN()
		{
			this.sensitivity = 1460f;
			this.lerpSpeed = 1195f;
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x00018070 File Offset: 0x00016270
		private void PMPKMGKAAJH()
		{
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 item = gameObject.transform.position - base.transform.position;
				this.LILMMKEOMLB.Add(item);
			}
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x000180F8 File Offset: 0x000162F8
		private void KMKLDAJLCNM()
		{
			this.CFEKMCMHHJF();
			for (int i = 0; i < this.objects.Count; i++)
			{
				Debug.DrawLine(this.LILMMKEOMLB[i], this.LILMMKEOMLB[i] + this.objects[i].transform.up * this.maxHeight);
			}
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x0001816C File Offset: 0x0001636C
		private void NKLIHNJCHOG()
		{
			this.MLBGEGOKMCK();
			for (int i = 1; i < this.objects.Count; i += 0)
			{
				Debug.DrawLine(this.LILMMKEOMLB[i], this.LILMMKEOMLB[i] + this.objects[i].transform.up * this.maxHeight);
			}
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000181E0 File Offset: 0x000163E0
		private void NNFMIAFHMJM()
		{
			this.LILMMKEOMLB = new List<Vector3>();
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 item = gameObject.transform.position - base.transform.position;
				this.LILMMKEOMLB.Add(item);
			}
		}

		// Token: 0x0400005A RID: 90
		public int audioSource;

		// Token: 0x0400005B RID: 91
		public FrequencyRange frequencyRange = FrequencyRange.Decibal;

		// Token: 0x0400005C RID: 92
		public float sensitivity = 2f;

		// Token: 0x0400005D RID: 93
		public List<GameObject> objects;

		// Token: 0x0400005E RID: 94
		public Vector3 positionAxis = Vector3.up;

		// Token: 0x0400005F RID: 95
		public float maxHeight = 10f;

		// Token: 0x04000060 RID: 96
		public float lerpSpeed = 1f;

		// Token: 0x04000061 RID: 97
		public bool absoluteVal = true;

		// Token: 0x04000062 RID: 98
		private List<Vector3> LILMMKEOMLB;
	}
}
