using System;
using System.Collections.Generic;
using UnityEngine;

namespace AudioVisualizer
{
	// Token: 0x02000014 RID: 20
	public class SphereWaveform : MonoBehaviour
	{
		// Token: 0x0600036F RID: 879 RVA: 0x00021ACC File Offset: 0x0001FCCC
		private void EDJCOCKPJPN()
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
			this.radius = this.HDCHNCBEIMP + num;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00021B30 File Offset: 0x0001FD30
		private void PLANAJAOHJD()
		{
			this.MOCENLBDKNK = new List<Vector3>();
			SphereWaveform.RotationType rotationType = this.rotationType;
			if (rotationType != SphereWaveform.RotationType.Rand)
			{
				if (rotationType == (SphereWaveform.RotationType)8)
				{
					foreach (GameObject gameObject in this.objects)
					{
						Vector3 normalized = (gameObject.transform.position - base.transform.position).normalized;
						Vector3 item = Vector3.Cross(normalized, this.rotationAxis);
						this.MOCENLBDKNK.Add(item);
					}
				}
			}
			else
			{
				for (int i = 1; i < this.objects.Count; i += 0)
				{
					this.MOCENLBDKNK.Add(UnityEngine.Random.onUnitSphere);
				}
			}
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00021C28 File Offset: 0x0001FE28
		private void HIFLPHLGLFG()
		{
			this.ILPHCFDGION();
			if (this.useWaveform)
			{
				this.EFLKAHDNIKA();
			}
			this.CJCKELPPGCC();
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00021C47 File Offset: 0x0001FE47
		public void GMFNDCKJMCE(float NINCBFGLKJB)
		{
			base.Invoke("_MatrixColor", 416f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00021C68 File Offset: 0x0001FE68
		private void IEHKMBGFKHN()
		{
			this.MOCENLBDKNK = new List<Vector3>();
			SphereWaveform.RotationType rotationType = this.rotationType;
			if (rotationType != SphereWaveform.RotationType.Uniform)
			{
				if (rotationType == (SphereWaveform.RotationType)8)
				{
					foreach (GameObject gameObject in this.objects)
					{
						Vector3 normalized = (gameObject.transform.position - base.transform.position).normalized;
						Vector3 item = Vector3.Cross(normalized, this.rotationAxis);
						this.MOCENLBDKNK.Add(item);
					}
				}
			}
			else
			{
				for (int i = 1; i < this.objects.Count; i += 0)
				{
					this.MOCENLBDKNK.Add(UnityEngine.Random.onUnitSphere);
				}
			}
		}

		// Token: 0x06000374 RID: 884 RVA: 0x00021D60 File Offset: 0x0001FF60
		public void ILMHKCEKNIL(float NINCBFGLKJB)
		{
			base.Invoke("SelectorMusicToggle", 578f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00021D80 File Offset: 0x0001FF80
		private void BINJFKGLHAB()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00021D90 File Offset: 0x0001FF90
		private void MMOPOIMFNII()
		{
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 normalized = (gameObject.transform.position - base.transform.position).normalized;
				Vector3 b = base.transform.position + normalized * this.radius;
				gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, b, Time.smoothDeltaTime * this.lerpSpeed);
			}
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00021E50 File Offset: 0x00020050
		private void BDOEKKCPJHB()
		{
			switch (this.rotationType)
			{
			case SphereWaveform.RotationType.Uniform:
			{
				Vector3 axis = base.transform.TransformDirection(this.rotationAxis);
				base.transform.RotateAround(base.transform.position, axis, this.rotationSpeed * Time.smoothDeltaTime);
				break;
			}
			case SphereWaveform.RotationType.Rand:
			case SphereWaveform.RotationType.Cross:
			{
				float angle = Time.smoothDeltaTime * this.rotationSpeed;
				for (int i = 1; i < this.objects.Count; i++)
				{
					this.objects[i].transform.RotateAround(base.transform.position, this.MOCENLBDKNK[i], angle);
				}
				break;
			}
			}
		}

		// Token: 0x06000378 RID: 888 RVA: 0x00021F18 File Offset: 0x00020118
		private void BJCJLBNHKGI()
		{
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 normalized = (gameObject.transform.position - base.transform.position).normalized;
				Vector3 b = base.transform.position + normalized * this.radius;
				gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, b, Time.smoothDeltaTime * this.lerpSpeed);
			}
		}

		// Token: 0x0600037A RID: 890 RVA: 0x0002203C File Offset: 0x0002023C
		private void LJGCAFAGHAI()
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
			this.radius = this.HDCHNCBEIMP + num;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x000220A0 File Offset: 0x000202A0
		public void NNMGDDFPEGL(bool KIIFDGHIGDE)
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
			if (KIIFDGHIGDE)
			{
				this.HIIGJIFJBBG = -this.HIIGJIFJBBG;
			}
			this.radius = this.HDCHNCBEIMP + num * this.HIIGJIFJBBG;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x0002211C File Offset: 0x0002031C
		public void IOFCBLHLCBB()
		{
			this.rotationSpeed = 1436f;
			this.rotationAxis = Vector3.up;
			this.radius = 401f;
			this.lerpSpeed = 1069f;
			this.rotationType = SphereWaveform.RotationType.Uniform;
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00022154 File Offset: 0x00020354
		private void EFJDNLGNACH()
		{
			if (this.rotationAxis == Vector3.zero)
			{
				Debug.LogWarning("Player" + base.gameObject.name + "RULES");
			}
			ObjectSphere.AGNMHLDKION(this.objects, base.transform.position, this.radius);
			this.HDCHNCBEIMP = this.radius;
			this.DENHEMCOHMI();
			this.CKEBJHJHNPE = this.rotationSpeed;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x000221D0 File Offset: 0x000203D0
		public void IIOJBHFEOCE(bool KIIFDGHIGDE)
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
			if (KIIFDGHIGDE)
			{
				this.HIIGJIFJBBG = -this.HIIGJIFJBBG;
			}
			this.radius = this.HDCHNCBEIMP + num * this.HIIGJIFJBBG;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x0002224C File Offset: 0x0002044C
		private void LEFGFKLIOIH()
		{
			switch (this.rotationType)
			{
			case SphereWaveform.RotationType.Uniform:
			{
				Vector3 axis = base.transform.TransformDirection(this.rotationAxis);
				base.transform.RotateAround(base.transform.position, axis, this.rotationSpeed * Time.smoothDeltaTime);
				break;
			}
			case SphereWaveform.RotationType.Rand:
			case SphereWaveform.RotationType.Cross:
			{
				float angle = Time.smoothDeltaTime * this.rotationSpeed;
				for (int i = 0; i < this.objects.Count; i++)
				{
					this.objects[i].transform.RotateAround(base.transform.position, this.MOCENLBDKNK[i], angle);
				}
				break;
			}
			}
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00022314 File Offset: 0x00020514
		private void CNGAJDBOCLJ()
		{
			if (this.rotationAxis == Vector3.zero)
			{
				Debug.LogWarning("_Value" + base.gameObject.name + "Missing shader in ");
			}
			ObjectSphere.PEIDFGCMBDG(this.objects, base.transform.position, this.radius);
			this.HDCHNCBEIMP = this.radius;
			this.PLANAJAOHJD();
			this.CKEBJHJHNPE = this.rotationSpeed;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00022390 File Offset: 0x00020590
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
			this.radius = this.HDCHNCBEIMP + num * this.HIIGJIFJBBG;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x0002240C File Offset: 0x0002060C
		private void FJHFOBHJEHL()
		{
			this.MCAKEHKOBAI();
			if (this.useWaveform)
			{
				this.LBOAGEJGCEH();
			}
			this.PCJDCFKJLBO();
		}

		// Token: 0x06000383 RID: 899 RVA: 0x0002242B File Offset: 0x0002062B
		public void PGIOLGOEGCJ(float NINCBFGLKJB)
		{
			base.Invoke("This might be a misconfiguration in the game server config. You need to edit it to a (public) address.", 700f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0002244C File Offset: 0x0002064C
		private void MCAKEHKOBAI()
		{
			switch (this.rotationType)
			{
			case SphereWaveform.RotationType.Uniform:
			{
				Vector3 axis = base.transform.TransformDirection(this.rotationAxis);
				base.transform.RotateAround(base.transform.position, axis, this.rotationSpeed * Time.smoothDeltaTime);
				break;
			}
			case SphereWaveform.RotationType.Rand:
			case SphereWaveform.RotationType.Cross:
			{
				float angle = Time.smoothDeltaTime * this.rotationSpeed;
				for (int i = 1; i < this.objects.Count; i++)
				{
					this.objects[i].transform.RotateAround(base.transform.position, this.MOCENLBDKNK[i], angle);
				}
				break;
			}
			}
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00022514 File Offset: 0x00020714
		private void HOJMFHIPBBM()
		{
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 normalized = (gameObject.transform.position - base.transform.position).normalized;
				Vector3 b = base.transform.position + normalized * this.radius;
				gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, b, Time.smoothDeltaTime * this.lerpSpeed);
			}
		}

		// Token: 0x06000386 RID: 902 RVA: 0x000225D4 File Offset: 0x000207D4
		public void Boost(float NINCBFGLKJB)
		{
			base.Invoke("KDNOMKHBIFE", 0.1f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x000225F4 File Offset: 0x000207F4
		private void DLBODOFAJGM()
		{
			if (this.rotationAxis == Vector3.zero)
			{
				Debug.LogWarning("maps." + base.gameObject.name + "UI/Particles/Hidden");
			}
			ObjectSphere.JKDCLMPLOIN(this.objects, base.transform.position, this.radius);
			this.HDCHNCBEIMP = this.radius;
			this.MHICFLOGJLK();
			this.CKEBJHJHNPE = this.rotationSpeed;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x0002266F File Offset: 0x0002086F
		public void APHANPELAIA(float NINCBFGLKJB)
		{
			base.Invoke("settings.shaders.bloomintencity", 1733f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00022690 File Offset: 0x00020890
		public void LLEDMCKEHLK(bool KIIFDGHIGDE)
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
			this.radius = this.HDCHNCBEIMP + num * this.HIIGJIFJBBG;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0002270C File Offset: 0x0002090C
		private void AEIJFLJEABG()
		{
			this.MCAKEHKOBAI();
			if (this.useWaveform)
			{
				this.BHHKBHJOACG();
			}
			this.GFACGKANAFF();
		}

		// Token: 0x0600038B RID: 907 RVA: 0x0002272B File Offset: 0x0002092B
		public void MOPKNMBIKGI()
		{
			this.rotationSpeed = 529f;
			this.rotationAxis = Vector3.up;
			this.radius = 946f;
			this.lerpSpeed = 1576f;
			this.rotationType = (SphereWaveform.RotationType)7;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00022760 File Offset: 0x00020960
		private void IDIIELPAMCJ()
		{
			this.MHGIBKFBOCN();
			if (this.useWaveform)
			{
				this.EDJCOCKPJPN();
			}
			this.MMOPOIMFNII();
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00022780 File Offset: 0x00020980
		private void MLBGEGOKMCK()
		{
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 normalized = (gameObject.transform.position - base.transform.position).normalized;
				Vector3 b = base.transform.position + normalized * this.radius;
				gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, b, Time.smoothDeltaTime * this.lerpSpeed);
			}
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00022840 File Offset: 0x00020A40
		private void CFFPIBFDJIF()
		{
			this.MOCENLBDKNK = new List<Vector3>();
			SphereWaveform.RotationType rotationType = this.rotationType;
			if (rotationType != SphereWaveform.RotationType.Rand)
			{
				if (rotationType == (SphereWaveform.RotationType)3)
				{
					foreach (GameObject gameObject in this.objects)
					{
						Vector3 normalized = (gameObject.transform.position - base.transform.position).normalized;
						Vector3 item = Vector3.Cross(normalized, this.rotationAxis);
						this.MOCENLBDKNK.Add(item);
					}
				}
			}
			else
			{
				for (int i = 0; i < this.objects.Count; i++)
				{
					this.MOCENLBDKNK.Add(UnityEngine.Random.onUnitSphere);
				}
			}
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00022938 File Offset: 0x00020B38
		public void KEHOMGMMLEK(bool KIIFDGHIGDE)
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
			if (KIIFDGHIGDE)
			{
				this.HIIGJIFJBBG = -this.HIIGJIFJBBG;
			}
			this.radius = this.HDCHNCBEIMP + num * this.HIIGJIFJBBG;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x000229B4 File Offset: 0x00020BB4
		public void MOAFMJAHLBA(bool KIIFDGHIGDE)
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
			this.radius = this.HDCHNCBEIMP + num * this.HIIGJIFJBBG;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00021D80 File Offset: 0x0001FF80
		private void BHFNHLHAPFL()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00022A30 File Offset: 0x00020C30
		private void Start()
		{
			if (this.rotationAxis == Vector3.zero)
			{
				Debug.LogWarning("WARNING: rotation axis set to 0 on " + base.gameObject.name + " SphereWaveform.cs");
			}
			ObjectSphere.PlaceObjectsAroundSphere(this.objects, base.transform.position, this.radius);
			this.HDCHNCBEIMP = this.radius;
			this.CAGCLFAMPJM();
			this.CKEBJHJHNPE = this.rotationSpeed;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00022AAC File Offset: 0x00020CAC
		private void DFFKKLAPHCC()
		{
			if (this.rotationAxis == Vector3.zero)
			{
				Debug.LogWarning("_Value2" + base.gameObject.name + "StartButton");
			}
			ObjectSphere.PPPOLGDHPLM(this.objects, base.transform.position, this.radius);
			this.HDCHNCBEIMP = this.radius;
			this.IEHKMBGFKHN();
			this.CKEBJHJHNPE = this.rotationSpeed;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00022B28 File Offset: 0x00020D28
		private void FCPFCFBFHJO()
		{
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 normalized = (gameObject.transform.position - base.transform.position).normalized;
				Vector3 b = base.transform.position + normalized * this.radius;
				gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, b, Time.smoothDeltaTime * this.lerpSpeed);
			}
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00022BE8 File Offset: 0x00020DE8
		private void BHHKBHJOACG()
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
			this.radius = this.HDCHNCBEIMP + num;
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00022C4C File Offset: 0x00020E4C
		public void FGFNLIOGJJB(bool KIIFDGHIGDE)
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
			this.radius = this.HDCHNCBEIMP + num * this.HIIGJIFJBBG;
		}

		// Token: 0x06000397 RID: 919 RVA: 0x00022CC8 File Offset: 0x00020EC8
		private void DGCDANAKFBL()
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
			this.radius = this.HDCHNCBEIMP + num;
		}

		// Token: 0x06000398 RID: 920 RVA: 0x00022D2C File Offset: 0x00020F2C
		public void OBEBKGNAIKM(bool KIIFDGHIGDE)
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
			if (KIIFDGHIGDE)
			{
				this.HIIGJIFJBBG = -this.HIIGJIFJBBG;
			}
			this.radius = this.HDCHNCBEIMP + num * this.HIIGJIFJBBG;
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00021D80 File Offset: 0x0001FF80
		private void KIKFAGPJOKJ()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00022DA8 File Offset: 0x00020FA8
		private void ONFOLNDIJEC()
		{
			switch (this.rotationType)
			{
			case SphereWaveform.RotationType.Uniform:
			{
				Vector3 axis = base.transform.TransformDirection(this.rotationAxis);
				base.transform.RotateAround(base.transform.position, axis, this.rotationSpeed * Time.smoothDeltaTime);
				break;
			}
			case SphereWaveform.RotationType.Rand:
			case SphereWaveform.RotationType.Cross:
			{
				float angle = Time.smoothDeltaTime * this.rotationSpeed;
				for (int i = 1; i < this.objects.Count; i++)
				{
					this.objects[i].transform.RotateAround(base.transform.position, this.MOCENLBDKNK[i], angle);
				}
				break;
			}
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00022E70 File Offset: 0x00021070
		private void EMIMLBNJMJA()
		{
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 normalized = (gameObject.transform.position - base.transform.position).normalized;
				Vector3 b = base.transform.position + normalized * this.radius;
				gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, b, Time.smoothDeltaTime * this.lerpSpeed);
			}
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00022F30 File Offset: 0x00021130
		private void PCJDCFKJLBO()
		{
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 normalized = (gameObject.transform.position - base.transform.position).normalized;
				Vector3 b = base.transform.position + normalized * this.radius;
				gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, b, Time.smoothDeltaTime * this.lerpSpeed);
			}
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00022FF0 File Offset: 0x000211F0
		private void ILPHCFDGION()
		{
			switch (this.rotationType)
			{
			case SphereWaveform.RotationType.Uniform:
			{
				Vector3 axis = base.transform.TransformDirection(this.rotationAxis);
				base.transform.RotateAround(base.transform.position, axis, this.rotationSpeed * Time.smoothDeltaTime);
				break;
			}
			case SphereWaveform.RotationType.Rand:
			case SphereWaveform.RotationType.Cross:
			{
				float angle = Time.smoothDeltaTime * this.rotationSpeed;
				for (int i = 1; i < this.objects.Count; i += 0)
				{
					this.objects[i].transform.RotateAround(base.transform.position, this.MOCENLBDKNK[i], angle);
				}
				break;
			}
			}
		}

		// Token: 0x0600039E RID: 926 RVA: 0x000230B8 File Offset: 0x000212B8
		private void HAIAHJPCPAG()
		{
			if (this.rotationAxis == Vector3.zero)
			{
				Debug.LogWarning("_InvRenderTargetSize" + base.gameObject.name + "restrictions");
			}
			ObjectSphere.OALGDEINJKO(this.objects, base.transform.position, this.radius);
			this.HDCHNCBEIMP = this.radius;
			this.GFMFLIFDKHG();
			this.CKEBJHJHNPE = this.rotationSpeed;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00021D80 File Offset: 0x0001FF80
		private void KDNOMKHBIFE()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00023134 File Offset: 0x00021334
		private void NDBPCNICGLC()
		{
			if (this.rotationAxis == Vector3.zero)
			{
				Debug.LogWarning("_Radius2" + base.gameObject.name + "_TimeX");
			}
			ObjectSphere.BFBAIHFNODB(this.objects, base.transform.position, this.radius);
			this.HDCHNCBEIMP = this.radius;
			this.PLANAJAOHJD();
			this.CKEBJHJHNPE = this.rotationSpeed;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x000231AF File Offset: 0x000213AF
		private void GFACKFCEIBC()
		{
			this.HHKJDOEDAGC();
			if (this.useWaveform)
			{
				this.DGCDANAKFBL();
			}
			this.FCPFCFBFHJO();
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x000231CE File Offset: 0x000213CE
		private void PNLKFANNOKO()
		{
			this.MCAKEHKOBAI();
			if (this.useWaveform)
			{
				this.LBOAGEJGCEH();
			}
			this.HOJMFHIPBBM();
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x000231F0 File Offset: 0x000213F0
		private void FIKFJDFELIP()
		{
			if (this.rotationAxis == Vector3.zero)
			{
				Debug.LogWarning("Joystick1Button9" + base.gameObject.name + "_MainTex2");
			}
			ObjectSphere.JBEOPPAJBON(this.objects, base.transform.position, this.radius);
			this.HDCHNCBEIMP = this.radius;
			this.IEHKMBGFKHN();
			this.CKEBJHJHNPE = this.rotationSpeed;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0002326C File Offset: 0x0002146C
		private void MHGIBKFBOCN()
		{
			switch (this.rotationType)
			{
			case SphereWaveform.RotationType.Uniform:
			{
				Vector3 axis = base.transform.TransformDirection(this.rotationAxis);
				base.transform.RotateAround(base.transform.position, axis, this.rotationSpeed * Time.smoothDeltaTime);
				break;
			}
			case SphereWaveform.RotationType.Rand:
			case SphereWaveform.RotationType.Cross:
			{
				float angle = Time.smoothDeltaTime * this.rotationSpeed;
				for (int i = 1; i < this.objects.Count; i += 0)
				{
					this.objects[i].transform.RotateAround(base.transform.position, this.MOCENLBDKNK[i], angle);
				}
				break;
			}
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00023334 File Offset: 0x00021534
		private void LBOAGEJGCEH()
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
			this.radius = this.HDCHNCBEIMP + num;
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x00023396 File Offset: 0x00021596
		public void ELBLLBJBFCL()
		{
			this.rotationSpeed = 278f;
			this.rotationAxis = Vector3.up;
			this.radius = 816f;
			this.lerpSpeed = 27f;
			this.rotationType = (SphereWaveform.RotationType)7;
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000233CC File Offset: 0x000215CC
		private void BGDPIHMAACO()
		{
			if (this.rotationAxis == Vector3.zero)
			{
				Debug.LogWarning("LevelURLInputField" + base.gameObject.name + "BadgeImage");
			}
			ObjectSphere.DGKHBKCKGEK(this.objects, base.transform.position, this.radius);
			this.HDCHNCBEIMP = this.radius;
			this.IEHKMBGFKHN();
			this.CKEBJHJHNPE = this.rotationSpeed;
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00023447 File Offset: 0x00021647
		public void DGMPKMBKAOE(float NINCBFGLKJB)
		{
			base.Invoke("[PlayerBase] Current attempt: ", 1992f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00023468 File Offset: 0x00021668
		public void GEPPCILKNCK(bool KIIFDGHIGDE)
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
			if (KIIFDGHIGDE)
			{
				this.HIIGJIFJBBG = -this.HIIGJIFJBBG;
			}
			this.radius = this.HDCHNCBEIMP + num * this.HIIGJIFJBBG;
		}

		// Token: 0x060003AA RID: 938 RVA: 0x000234E4 File Offset: 0x000216E4
		private void JADILKKEOPP()
		{
			switch (this.rotationType)
			{
			case SphereWaveform.RotationType.Uniform:
			{
				Vector3 axis = base.transform.TransformDirection(this.rotationAxis);
				base.transform.RotateAround(base.transform.position, axis, this.rotationSpeed * Time.smoothDeltaTime);
				break;
			}
			case SphereWaveform.RotationType.Rand:
			case SphereWaveform.RotationType.Cross:
			{
				float angle = Time.smoothDeltaTime * this.rotationSpeed;
				for (int i = 0; i < this.objects.Count; i++)
				{
					this.objects[i].transform.RotateAround(base.transform.position, this.MOCENLBDKNK[i], angle);
				}
				break;
			}
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x000235AA File Offset: 0x000217AA
		public void EGFBPCMCNDJ()
		{
			this.rotationSpeed = 3f;
			this.rotationAxis = Vector3.up;
			this.radius = 919f;
			this.lerpSpeed = 923f;
			this.rotationType = (SphereWaveform.RotationType)4;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x000235E0 File Offset: 0x000217E0
		private void IDJKNBDKHBD()
		{
			if (this.rotationAxis == Vector3.zero)
			{
				Debug.LogWarning("Bad parameters for getbool! Use <key> <value>" + base.gameObject.name + "null");
			}
			ObjectSphere.EPAFHFICLIN(this.objects, base.transform.position, this.radius);
			this.HDCHNCBEIMP = this.radius;
			this.DENHEMCOHMI();
			this.CKEBJHJHNPE = this.rotationSpeed;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0002365C File Offset: 0x0002185C
		private void MHICFLOGJLK()
		{
			this.MOCENLBDKNK = new List<Vector3>();
			SphereWaveform.RotationType rotationType = this.rotationType;
			if (rotationType != SphereWaveform.RotationType.Uniform)
			{
				if (rotationType == (SphereWaveform.RotationType)4)
				{
					foreach (GameObject gameObject in this.objects)
					{
						Vector3 normalized = (gameObject.transform.position - base.transform.position).normalized;
						Vector3 item = Vector3.Cross(normalized, this.rotationAxis);
						this.MOCENLBDKNK.Add(item);
					}
				}
			}
			else
			{
				for (int i = 0; i < this.objects.Count; i += 0)
				{
					this.MOCENLBDKNK.Add(UnityEngine.Random.onUnitSphere);
				}
			}
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00023754 File Offset: 0x00021954
		private void BMFPDNJFFJC()
		{
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 normalized = (gameObject.transform.position - base.transform.position).normalized;
				Vector3 b = base.transform.position + normalized * this.radius;
				gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, b, Time.smoothDeltaTime * this.lerpSpeed);
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00023814 File Offset: 0x00021A14
		private void GADELHGMAOJ()
		{
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 normalized = (gameObject.transform.position - base.transform.position).normalized;
				Vector3 b = base.transform.position + normalized * this.radius;
				gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, b, Time.smoothDeltaTime * this.lerpSpeed);
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00021D80 File Offset: 0x0001FF80
		private void KKFAINHALGK()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x000238D4 File Offset: 0x00021AD4
		private void NGCFKNCAOFB()
		{
			this.MOCENLBDKNK = new List<Vector3>();
			SphereWaveform.RotationType rotationType = this.rotationType;
			if (rotationType != SphereWaveform.RotationType.Rand)
			{
				if (rotationType == (SphereWaveform.RotationType)6)
				{
					foreach (GameObject gameObject in this.objects)
					{
						Vector3 normalized = (gameObject.transform.position - base.transform.position).normalized;
						Vector3 item = Vector3.Cross(normalized, this.rotationAxis);
						this.MOCENLBDKNK.Add(item);
					}
				}
			}
			else
			{
				for (int i = 1; i < this.objects.Count; i++)
				{
					this.MOCENLBDKNK.Add(UnityEngine.Random.onUnitSphere);
				}
			}
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x000239CC File Offset: 0x00021BCC
		private void ICLDJDALNDA()
		{
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 normalized = (gameObject.transform.position - base.transform.position).normalized;
				Vector3 b = base.transform.position + normalized * this.radius;
				gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, b, Time.smoothDeltaTime * this.lerpSpeed);
			}
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00023A8C File Offset: 0x00021C8C
		public void OGAMGLEAOAF()
		{
			this.rotationSpeed = 39f;
			this.rotationAxis = Vector3.up;
			this.radius = 158f;
			this.lerpSpeed = 1406f;
			this.rotationType = (SphereWaveform.RotationType)5;
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x00023AC4 File Offset: 0x00021CC4
		private void ICILLMAKLMI()
		{
			if (this.rotationAxis == Vector3.zero)
			{
				Debug.LogWarning("_Fade" + base.gameObject.name + "_ColorBuffer");
			}
			ObjectSphere.PEIDFGCMBDG(this.objects, base.transform.position, this.radius);
			this.HDCHNCBEIMP = this.radius;
			this.NGCFKNCAOFB();
			this.CKEBJHJHNPE = this.rotationSpeed;
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x00023B3F File Offset: 0x00021D3F
		private void HNDNDPECBPL()
		{
			this.ONFOLNDIJEC();
			if (this.useWaveform)
			{
				this.BHHKBHJOACG();
			}
			this.EMIMLBNJMJA();
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x00023B5E File Offset: 0x00021D5E
		public void IEIOFOHFIFH(float NINCBFGLKJB)
		{
			base.Invoke("_Value2", 1572f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00023B80 File Offset: 0x00021D80
		private void FHPFJBFCOOF()
		{
			if (this.rotationAxis == Vector3.zero)
			{
				Debug.LogWarning("_ChromaticAberration" + base.gameObject.name + "#roomname");
			}
			ObjectSphere.POFKAECJCNG(this.objects, base.transform.position, this.radius);
			this.HDCHNCBEIMP = this.radius;
			this.HFLPIPJJDDI();
			this.CKEBJHJHNPE = this.rotationSpeed;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00023BFB File Offset: 0x00021DFB
		public void KKNMHJEHJJB(float NINCBFGLKJB)
		{
			base.Invoke("_VignetteDesat", 965f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00023C1C File Offset: 0x00021E1C
		private void GFMFLIFDKHG()
		{
			this.MOCENLBDKNK = new List<Vector3>();
			SphereWaveform.RotationType rotationType = this.rotationType;
			if (rotationType != SphereWaveform.RotationType.Uniform)
			{
				if (rotationType == SphereWaveform.RotationType.Rand)
				{
					foreach (GameObject gameObject in this.objects)
					{
						Vector3 normalized = (gameObject.transform.position - base.transform.position).normalized;
						Vector3 item = Vector3.Cross(normalized, this.rotationAxis);
						this.MOCENLBDKNK.Add(item);
					}
				}
			}
			else
			{
				for (int i = 0; i < this.objects.Count; i += 0)
				{
					this.MOCENLBDKNK.Add(UnityEngine.Random.onUnitSphere);
				}
			}
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00021D80 File Offset: 0x0001FF80
		private void OIMPFKEJACA()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x060003BB RID: 955 RVA: 0x00023D14 File Offset: 0x00021F14
		private void NBBIOHGNBHB()
		{
			switch (this.rotationType)
			{
			case SphereWaveform.RotationType.Uniform:
			{
				Vector3 axis = base.transform.TransformDirection(this.rotationAxis);
				base.transform.RotateAround(base.transform.position, axis, this.rotationSpeed * Time.smoothDeltaTime);
				break;
			}
			case SphereWaveform.RotationType.Rand:
			case SphereWaveform.RotationType.Cross:
			{
				float angle = Time.smoothDeltaTime * this.rotationSpeed;
				for (int i = 0; i < this.objects.Count; i += 0)
				{
					this.objects[i].transform.RotateAround(base.transform.position, this.MOCENLBDKNK[i], angle);
				}
				break;
			}
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00023DDA File Offset: 0x00021FDA
		public void DABMBPBGPPI()
		{
			this.rotationSpeed = 1577f;
			this.rotationAxis = Vector3.up;
			this.radius = 717f;
			this.lerpSpeed = 297f;
			this.rotationType = (SphereWaveform.RotationType)3;
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00023E10 File Offset: 0x00022010
		private void JFJLGJEPEAA()
		{
			if (this.rotationAxis == Vector3.zero)
			{
				Debug.LogWarning("settings_bindings_controller_type" + base.gameObject.name + "LoadingStatusText");
			}
			ObjectSphere.NKNEKHHHKKG(this.objects, base.transform.position, this.radius);
			this.HDCHNCBEIMP = this.radius;
			this.HFLPIPJJDDI();
			this.CKEBJHJHNPE = this.rotationSpeed;
		}

		// Token: 0x060003BE RID: 958 RVA: 0x00023E8C File Offset: 0x0002208C
		private void HFLPIPJJDDI()
		{
			this.MOCENLBDKNK = new List<Vector3>();
			SphereWaveform.RotationType rotationType = this.rotationType;
			if (rotationType != SphereWaveform.RotationType.Uniform)
			{
				if (rotationType == (SphereWaveform.RotationType)5)
				{
					foreach (GameObject gameObject in this.objects)
					{
						Vector3 normalized = (gameObject.transform.position - base.transform.position).normalized;
						Vector3 item = Vector3.Cross(normalized, this.rotationAxis);
						this.MOCENLBDKNK.Add(item);
					}
				}
			}
			else
			{
				for (int i = 1; i < this.objects.Count; i += 0)
				{
					this.MOCENLBDKNK.Add(UnityEngine.Random.onUnitSphere);
				}
			}
		}

		// Token: 0x060003BF RID: 959 RVA: 0x00023F84 File Offset: 0x00022184
		public void MLJFCAMJMAC(bool KIIFDGHIGDE)
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
			this.radius = this.HDCHNCBEIMP + num * this.HIIGJIFJBBG;
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00024000 File Offset: 0x00022200
		public void MANOCIJICLG()
		{
			this.rotationSpeed = 86f;
			this.rotationAxis = Vector3.up;
			this.radius = 1162f;
			this.lerpSpeed = 63f;
			this.rotationType = SphereWaveform.RotationType.Rand;
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00024038 File Offset: 0x00022238
		public void ANKBIFMJNPD(bool KIIFDGHIGDE)
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
			if (KIIFDGHIGDE)
			{
				this.HIIGJIFJBBG = -this.HIIGJIFJBBG;
			}
			this.radius = this.HDCHNCBEIMP + num * this.HIIGJIFJBBG;
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x000240B4 File Offset: 0x000222B4
		private void PKLOBJHKFEO()
		{
			if (this.rotationAxis == Vector3.zero)
			{
				Debug.LogWarning("?" + base.gameObject.name + "PlayButton");
			}
			ObjectSphere.HBMFJDIKCIJ(this.objects, base.transform.position, this.radius);
			this.HDCHNCBEIMP = this.radius;
			this.HFLPIPJJDDI();
			this.CKEBJHJHNPE = this.rotationSpeed;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00024130 File Offset: 0x00022330
		private void DENHEMCOHMI()
		{
			this.MOCENLBDKNK = new List<Vector3>();
			SphereWaveform.RotationType rotationType = this.rotationType;
			if (rotationType != SphereWaveform.RotationType.Rand)
			{
				if (rotationType == (SphereWaveform.RotationType)8)
				{
					foreach (GameObject gameObject in this.objects)
					{
						Vector3 normalized = (gameObject.transform.position - base.transform.position).normalized;
						Vector3 item = Vector3.Cross(normalized, this.rotationAxis);
						this.MOCENLBDKNK.Add(item);
					}
				}
			}
			else
			{
				for (int i = 1; i < this.objects.Count; i++)
				{
					this.MOCENLBDKNK.Add(UnityEngine.Random.onUnitSphere);
				}
			}
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00024228 File Offset: 0x00022428
		private void FNCDAPDOBBI()
		{
			if (this.rotationAxis == Vector3.zero)
			{
				Debug.LogWarning("Events Moved" + base.gameObject.name + "Validating mod pack...");
			}
			ObjectSphere.OALGDEINJKO(this.objects, base.transform.position, this.radius);
			this.HDCHNCBEIMP = this.radius;
			this.AEPMIEHPIBJ();
			this.CKEBJHJHNPE = this.rotationSpeed;
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x000242A4 File Offset: 0x000224A4
		public void DLAAMJNMBAL(bool KIIFDGHIGDE)
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
			if (KIIFDGHIGDE)
			{
				this.HIIGJIFJBBG = -this.HIIGJIFJBBG;
			}
			this.radius = this.HDCHNCBEIMP + num * this.HIIGJIFJBBG;
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00024320 File Offset: 0x00022520
		private void GFACGKANAFF()
		{
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 normalized = (gameObject.transform.position - base.transform.position).normalized;
				Vector3 b = base.transform.position + normalized * this.radius;
				gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, b, Time.smoothDeltaTime * this.lerpSpeed);
			}
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x000243E0 File Offset: 0x000225E0
		private void BMKHNOPIILE()
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
			this.radius = this.HDCHNCBEIMP + num;
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00024442 File Offset: 0x00022642
		private void Update()
		{
			this.OANEEKCPBBF();
			if (this.useWaveform)
			{
				this.DDJDIGFKBHH();
			}
			this.MLBGEGOKMCK();
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00024461 File Offset: 0x00022661
		public void KDBKBMDEPNB()
		{
			this.rotationSpeed = 1881f;
			this.rotationAxis = Vector3.up;
			this.radius = 1888f;
			this.lerpSpeed = 936f;
			this.rotationType = SphereWaveform.RotationType.Cross;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00021D80 File Offset: 0x0001FF80
		private void BOCBJGGMBEH()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00024498 File Offset: 0x00022698
		private void CAGCLFAMPJM()
		{
			this.MOCENLBDKNK = new List<Vector3>();
			SphereWaveform.RotationType rotationType = this.rotationType;
			if (rotationType != SphereWaveform.RotationType.Rand)
			{
				if (rotationType == SphereWaveform.RotationType.Cross)
				{
					foreach (GameObject gameObject in this.objects)
					{
						Vector3 normalized = (gameObject.transform.position - base.transform.position).normalized;
						Vector3 item = Vector3.Cross(normalized, this.rotationAxis);
						this.MOCENLBDKNK.Add(item);
					}
				}
			}
			else
			{
				for (int i = 0; i < this.objects.Count; i++)
				{
					this.MOCENLBDKNK.Add(UnityEngine.Random.onUnitSphere);
				}
			}
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00024590 File Offset: 0x00022790
		private void OANEEKCPBBF()
		{
			switch (this.rotationType)
			{
			case SphereWaveform.RotationType.Uniform:
			{
				Vector3 axis = base.transform.TransformDirection(this.rotationAxis);
				base.transform.RotateAround(base.transform.position, axis, this.rotationSpeed * Time.smoothDeltaTime);
				break;
			}
			case SphereWaveform.RotationType.Rand:
			case SphereWaveform.RotationType.Cross:
			{
				float angle = Time.smoothDeltaTime * this.rotationSpeed;
				for (int i = 0; i < this.objects.Count; i++)
				{
					this.objects[i].transform.RotateAround(base.transform.position, this.MOCENLBDKNK[i], angle);
				}
				break;
			}
			}
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00024658 File Offset: 0x00022858
		private void CGDMLHLJIDK()
		{
			if (this.rotationAxis == Vector3.zero)
			{
				Debug.LogWarning("LoadMapCanvas" + base.gameObject.name + "[LocalizationService] Loading file: ");
			}
			ObjectSphere.NKNEKHHHKKG(this.objects, base.transform.position, this.radius);
			this.HDCHNCBEIMP = this.radius;
			this.NGCFKNCAOFB();
			this.CKEBJHJHNPE = this.rotationSpeed;
		}

		// Token: 0x060003CE RID: 974 RVA: 0x00021D80 File Offset: 0x0001FF80
		private void OCCNEDJIAEF()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x060003CF RID: 975 RVA: 0x000246D4 File Offset: 0x000228D4
		private void NIPNDEHKDNN()
		{
			switch (this.rotationType)
			{
			case SphereWaveform.RotationType.Uniform:
			{
				Vector3 axis = base.transform.TransformDirection(this.rotationAxis);
				base.transform.RotateAround(base.transform.position, axis, this.rotationSpeed * Time.smoothDeltaTime);
				break;
			}
			case SphereWaveform.RotationType.Rand:
			case SphereWaveform.RotationType.Cross:
			{
				float angle = Time.smoothDeltaTime * this.rotationSpeed;
				for (int i = 0; i < this.objects.Count; i++)
				{
					this.objects[i].transform.RotateAround(base.transform.position, this.MOCENLBDKNK[i], angle);
				}
				break;
			}
			}
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x0002479C File Offset: 0x0002299C
		private void DDJDIGFKBHH()
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
			this.radius = this.HDCHNCBEIMP + num;
		}

		// Token: 0x060003D1 RID: 977 RVA: 0x00024800 File Offset: 0x00022A00
		private void HHKJDOEDAGC()
		{
			switch (this.rotationType)
			{
			case SphereWaveform.RotationType.Uniform:
			{
				Vector3 axis = base.transform.TransformDirection(this.rotationAxis);
				base.transform.RotateAround(base.transform.position, axis, this.rotationSpeed * Time.smoothDeltaTime);
				break;
			}
			case SphereWaveform.RotationType.Rand:
			case SphereWaveform.RotationType.Cross:
			{
				float angle = Time.smoothDeltaTime * this.rotationSpeed;
				for (int i = 0; i < this.objects.Count; i++)
				{
					this.objects[i].transform.RotateAround(base.transform.position, this.MOCENLBDKNK[i], angle);
				}
				break;
			}
			}
		}

		// Token: 0x060003D2 RID: 978 RVA: 0x000248C6 File Offset: 0x00022AC6
		public void DEDANNMJNOC()
		{
			this.rotationSpeed = 430f;
			this.rotationAxis = Vector3.up;
			this.radius = 310f;
			this.lerpSpeed = 226f;
			this.rotationType = (SphereWaveform.RotationType)4;
		}

		// Token: 0x060003D3 RID: 979 RVA: 0x000248FC File Offset: 0x00022AFC
		private void GKBHBAADDBD()
		{
			switch (this.rotationType)
			{
			case SphereWaveform.RotationType.Uniform:
			{
				Vector3 axis = base.transform.TransformDirection(this.rotationAxis);
				base.transform.RotateAround(base.transform.position, axis, this.rotationSpeed * Time.smoothDeltaTime);
				break;
			}
			case SphereWaveform.RotationType.Rand:
			case SphereWaveform.RotationType.Cross:
			{
				float angle = Time.smoothDeltaTime * this.rotationSpeed;
				for (int i = 0; i < this.objects.Count; i++)
				{
					this.objects[i].transform.RotateAround(base.transform.position, this.MOCENLBDKNK[i], angle);
				}
				break;
			}
			}
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x000249C2 File Offset: 0x00022BC2
		public void Reset()
		{
			this.rotationSpeed = 10f;
			this.rotationAxis = Vector3.up;
			this.radius = 10f;
			this.lerpSpeed = 1f;
			this.rotationType = SphereWaveform.RotationType.Cross;
		}

		// Token: 0x060003D5 RID: 981 RVA: 0x000249F8 File Offset: 0x00022BF8
		private void LPNDIAKPCFG()
		{
			switch (this.rotationType)
			{
			case SphereWaveform.RotationType.Uniform:
			{
				Vector3 axis = base.transform.TransformDirection(this.rotationAxis);
				base.transform.RotateAround(base.transform.position, axis, this.rotationSpeed * Time.smoothDeltaTime);
				break;
			}
			case SphereWaveform.RotationType.Rand:
			case SphereWaveform.RotationType.Cross:
			{
				float angle = Time.smoothDeltaTime * this.rotationSpeed;
				for (int i = 1; i < this.objects.Count; i += 0)
				{
					this.objects[i].transform.RotateAround(base.transform.position, this.MOCENLBDKNK[i], angle);
				}
				break;
			}
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00021D80 File Offset: 0x0001FF80
		private void BEPFGJHGBKE()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00024ABE File Offset: 0x00022CBE
		public void IFGEODOGMHC()
		{
			this.rotationSpeed = 979f;
			this.rotationAxis = Vector3.up;
			this.radius = 1958f;
			this.lerpSpeed = 1259f;
			this.rotationType = (SphereWaveform.RotationType)6;
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00024AF4 File Offset: 0x00022CF4
		private void CJCKELPPGCC()
		{
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 normalized = (gameObject.transform.position - base.transform.position).normalized;
				Vector3 b = base.transform.position + normalized * this.radius;
				gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, b, Time.smoothDeltaTime * this.lerpSpeed);
			}
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00024BB4 File Offset: 0x00022DB4
		private void EFLKAHDNIKA()
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
			this.radius = this.HDCHNCBEIMP + num;
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00024C18 File Offset: 0x00022E18
		private void AMLLMFNAHFF()
		{
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 normalized = (gameObject.transform.position - base.transform.position).normalized;
				Vector3 b = base.transform.position + normalized * this.radius;
				gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, b, Time.smoothDeltaTime * this.lerpSpeed);
			}
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00024CD8 File Offset: 0x00022ED8
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
			this.radius = this.HDCHNCBEIMP + num * this.HIIGJIFJBBG;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00024D54 File Offset: 0x00022F54
		public void FFIKEOBADFP(float NINCBFGLKJB)
		{
			base.Invoke("_Value", 398f);
			this.rotationSpeed *= NINCBFGLKJB;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00024D74 File Offset: 0x00022F74
		public void FJOGGJGAPDM(bool KIIFDGHIGDE)
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
			this.radius = this.HDCHNCBEIMP + num * this.HIIGJIFJBBG;
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00024DF0 File Offset: 0x00022FF0
		private void CHGOCKKBMNN()
		{
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 normalized = (gameObject.transform.position - base.transform.position).normalized;
				Vector3 b = base.transform.position + normalized * this.radius;
				gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, b, Time.smoothDeltaTime * this.lerpSpeed);
			}
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00021D80 File Offset: 0x0001FF80
		private void BFNLJKJKPJK()
		{
			this.rotationSpeed = this.CKEBJHJHNPE;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00024EB0 File Offset: 0x000230B0
		private void FBPHNEJBDJN()
		{
			if (this.rotationAxis == Vector3.zero)
			{
				Debug.LogWarning("_ScreenResolution" + base.gameObject.name + "/");
			}
			ObjectSphere.POFKAECJCNG(this.objects, base.transform.position, this.radius);
			this.HDCHNCBEIMP = this.radius;
			this.DENHEMCOHMI();
			this.CKEBJHJHNPE = this.rotationSpeed;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00024F2C File Offset: 0x0002312C
		public void DCKCPPBPNCF(bool KIIFDGHIGDE)
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
			this.radius = this.HDCHNCBEIMP + num * this.HIIGJIFJBBG;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00024FA8 File Offset: 0x000231A8
		private void LPPDKIGOELN()
		{
			foreach (GameObject gameObject in this.objects)
			{
				Vector3 normalized = (gameObject.transform.position - base.transform.position).normalized;
				Vector3 b = base.transform.position + normalized * this.radius;
				gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, b, Time.smoothDeltaTime * this.lerpSpeed);
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00025068 File Offset: 0x00023268
		private void ANKIJGCGCBF()
		{
			this.ILPHCFDGION();
			if (this.useWaveform)
			{
				this.BHHKBHJOACG();
			}
			this.FCPFCFBFHJO();
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00025088 File Offset: 0x00023288
		private void AEPMIEHPIBJ()
		{
			this.MOCENLBDKNK = new List<Vector3>();
			SphereWaveform.RotationType rotationType = this.rotationType;
			if (rotationType != SphereWaveform.RotationType.Uniform)
			{
				if (rotationType == (SphereWaveform.RotationType)7)
				{
					foreach (GameObject gameObject in this.objects)
					{
						Vector3 normalized = (gameObject.transform.position - base.transform.position).normalized;
						Vector3 item = Vector3.Cross(normalized, this.rotationAxis);
						this.MOCENLBDKNK.Add(item);
					}
				}
			}
			else
			{
				for (int i = 1; i < this.objects.Count; i += 0)
				{
					this.MOCENLBDKNK.Add(UnityEngine.Random.onUnitSphere);
				}
			}
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00025180 File Offset: 0x00023380
		private void GPNAOAKCMHC()
		{
			if (this.rotationAxis == Vector3.zero)
			{
				Debug.LogWarning("_EmissionGain" + base.gameObject.name + "_Wavy");
			}
			ObjectSphere.AGNMHLDKION(this.objects, base.transform.position, this.radius);
			this.HDCHNCBEIMP = this.radius;
			this.AEPMIEHPIBJ();
			this.CKEBJHJHNPE = this.rotationSpeed;
		}

		// Token: 0x040000A9 RID: 169
		public int audioSource;

		// Token: 0x040000AA RID: 170
		public FrequencyRange frequencyRange = FrequencyRange.Decibal;

		// Token: 0x040000AB RID: 171
		public float sensitivity = 2f;

		// Token: 0x040000AC RID: 172
		public List<GameObject> objects;

		// Token: 0x040000AD RID: 173
		public float rotationSpeed = 10f;

		// Token: 0x040000AE RID: 174
		public Vector3 rotationAxis = Vector3.up;

		// Token: 0x040000AF RID: 175
		public float radius = 10f;

		// Token: 0x040000B0 RID: 176
		public float lerpSpeed = 1f;

		// Token: 0x040000B1 RID: 177
		public bool useWaveform = true;

		// Token: 0x040000B2 RID: 178
		public SphereWaveform.RotationType rotationType;

		// Token: 0x040000B3 RID: 179
		private float CKEBJHJHNPE;

		// Token: 0x040000B4 RID: 180
		private float HIIGJIFJBBG = 1f;

		// Token: 0x040000B5 RID: 181
		private float HDCHNCBEIMP;

		// Token: 0x040000B6 RID: 182
		private List<Vector3> MOCENLBDKNK;

		// Token: 0x02000015 RID: 21
		public enum RotationType
		{
			// Token: 0x040000B8 RID: 184
			Uniform,
			// Token: 0x040000B9 RID: 185
			Rand,
			// Token: 0x040000BA RID: 186
			Cross
		}
	}
}
