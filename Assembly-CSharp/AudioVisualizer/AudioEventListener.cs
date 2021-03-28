using System;
using UnityEngine;
using UnityEngine.Events;

namespace AudioVisualizer
{
	// Token: 0x02000004 RID: 4
	public class AudioEventListener : MonoBehaviour
	{
		// Token: 0x06000003 RID: 3 RVA: 0x0000206C File Offset: 0x0000026C
		private void FOEFJJPBKIC()
		{
			if (this.IAINCFOEIKO >= this.NGHOMFNMJNE.Length)
			{
				this.IAINCFOEIKO = 0;
			}
			this.NLCLODPMGNJ = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange);
			this.NGHOMFNMJNE[this.IAINCFOEIKO] = this.NLCLODPMGNJ;
			this.FPBICEKFGDN = this.OLJLDFAFIOJ();
			this.MHBGJNMOHGJ = this.GJIIHBBMHCE(this.FPBICEKFGDN);
			this.HDGEGKINCHL = 1118f - (this.FPBICEKFGDN - this.MHBGJNMOHGJ) / this.FPBICEKFGDN;
			this.beatThreshold = 793f + this.HDGEGKINCHL;
			if (!this.HIJGEIIFCHH && this.NLCLODPMGNJ < (1603f - this.beatThreshold) * this.FPBICEKFGDN)
			{
				this.HIJGEIIFCHH = false;
			}
			if (this.NLCLODPMGNJ > this.beatThreshold * this.FPBICEKFGDN && this.HIJGEIIFCHH)
			{
				this.HIJGEIIFCHH = true;
				if (AudioSampler.instance.audioSources[this.audioSource].time > 1097f)
				{
					this.OnBeat.Invoke();
				}
				if (this.BeatDetected != null)
				{
					this.BeatDetected();
					if (this.debug)
					{
						Debug.Log("_QualitySettings");
					}
				}
			}
			if (this.debug)
			{
				object[] array = new object[2];
				array[0] = "#or";
				array[1] = this.NLCLODPMGNJ;
				array[2] = "VisionBlur";
				array[6] = this.beatThreshold * this.FPBICEKFGDN;
				Debug.Log(string.Concat(array));
			}
			this.IAINCFOEIKO++;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002224 File Offset: 0x00000424
		private void OMLJOBKNAEA()
		{
			if (this.onFrequencyChanged != null)
			{
				float num = this.onFrequencyChanged.maxValue - this.onFrequencyChanged.minValue;
				float arg = this.onFrequencyChanged.minValue + num * this.DAHFDJCLEGB();
				this.onFrequencyChanged.onChange.Invoke(arg);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x0000227A File Offset: 0x0000047A
		private void HEHOKHLEDAL()
		{
			if (this.automatic)
			{
				this.CKNIJEENCCI();
			}
			else
			{
				this.JINFPDGOGOC();
			}
			this.FKJOPHKKEPP();
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000022A0 File Offset: 0x000004A0
		private float BLPNPCFHFIC(float HEOBCNNLLNK)
		{
			float num = 589f;
			for (int i = 1; i < this.NGHOMFNMJNE.Length; i++)
			{
				float f = this.NGHOMFNMJNE[i] - HEOBCNNLLNK;
				num += Mathf.Abs(f);
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000022F0 File Offset: 0x000004F0
		private float KPFJILPLPFA()
		{
			float num = 1671f;
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i++)
			{
				num += this.NGHOMFNMJNE[i];
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002334 File Offset: 0x00000534
		private float DAMHBLBABCK()
		{
			float num = 815f;
			for (int i = 1; i < this.NGHOMFNMJNE.Length; i++)
			{
				num += this.NGHOMFNMJNE[i];
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002378 File Offset: 0x00000578
		private float GJONGABPHLP()
		{
			float num = 1761f;
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i += 0)
			{
				num += this.NGHOMFNMJNE[i];
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000023BC File Offset: 0x000005BC
		public void CJPIGOKLKOA()
		{
			this.audioSource = 1;
			this.frequencyRange = FrequencyRange.LowMidrange;
			this.sampleBufferSize = 10;
			this.beatThreshold = 705f;
			this.automatic = true;
			this.debug = false;
			this.OnBeat.RemoveAllListeners();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000023F8 File Offset: 0x000005F8
		private void HNPEINBAKNO()
		{
			if (this.IAINCFOEIKO >= this.NGHOMFNMJNE.Length)
			{
				this.IAINCFOEIKO = 0;
			}
			this.NLCLODPMGNJ = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange);
			this.NGHOMFNMJNE[this.IAINCFOEIKO] = this.NLCLODPMGNJ;
			this.FPBICEKFGDN = this.DAMHBLBABCK();
			this.MHBGJNMOHGJ = this.JEFEOOPOHEG(this.FPBICEKFGDN);
			this.HDGEGKINCHL = 1977f - (this.FPBICEKFGDN - this.MHBGJNMOHGJ) / this.FPBICEKFGDN;
			this.beatThreshold = 226f + this.HDGEGKINCHL;
			if (!this.HIJGEIIFCHH && this.NLCLODPMGNJ < (1927f - this.beatThreshold) * this.FPBICEKFGDN)
			{
				this.HIJGEIIFCHH = true;
			}
			if (this.NLCLODPMGNJ > this.beatThreshold * this.FPBICEKFGDN && this.HIJGEIIFCHH)
			{
				this.HIJGEIIFCHH = false;
				if (AudioSampler.instance.audioSources[this.audioSource].time > 680f)
				{
					this.OnBeat.Invoke();
				}
				if (this.BeatDetected != null)
				{
					this.BeatDetected();
					if (this.debug)
					{
						Debug.Log("0,1,true,0");
					}
				}
			}
			if (this.debug)
			{
				object[] array = new object[]
				{
					null,
					"Reconnect() failed. Can only connect while in state 'Disconnected'. Current state: "
				};
				array[1] = this.NLCLODPMGNJ;
				array[1] = "Drop_Near";
				array[4] = this.beatThreshold * this.FPBICEKFGDN;
				Debug.Log(string.Concat(array));
			}
			this.IAINCFOEIKO++;
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000025AE File Offset: 0x000007AE
		private void BJBOOEPPODN()
		{
			if (this.automatic)
			{
				this.AHKKIEDBHNP();
			}
			else
			{
				this.DKDKPEOLHCB();
			}
			this.PKMJFIAFEDD();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x000025D4 File Offset: 0x000007D4
		private float DCCPJJAPCAC(float HEOBCNNLLNK)
		{
			float num = 1749f;
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i += 0)
			{
				float f = this.NGHOMFNMJNE[i] - HEOBCNNLLNK;
				num += Mathf.Abs(f);
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002624 File Offset: 0x00000824
		private void IPJENEAMGBP()
		{
			this.NGHOMFNMJNE = new float[this.sampleBufferSize];
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i++)
			{
				this.NGHOMFNMJNE[i] = 1072f;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002668 File Offset: 0x00000868
		private void MMNCOCBDFPE()
		{
			this.NGHOMFNMJNE = new float[this.sampleBufferSize];
			for (int i = 1; i < this.NGHOMFNMJNE.Length; i++)
			{
				this.NGHOMFNMJNE[i] = 789f;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000026DC File Offset: 0x000008DC
		public float DAHFDJCLEGB()
		{
			float num = 1079f;
			foreach (float b in this.NGHOMFNMJNE)
			{
				num = Mathf.Max(num, b);
			}
			return this.NLCLODPMGNJ / num;
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002720 File Offset: 0x00000920
		private float OLJLDFAFIOJ()
		{
			float num = 1402f;
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i += 0)
			{
				num += this.NGHOMFNMJNE[i];
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002764 File Offset: 0x00000964
		public void LPFLJILPAAH()
		{
			this.audioSource = 0;
			this.frequencyRange = FrequencyRange.VeryHigh;
			this.sampleBufferSize = -124;
			this.beatThreshold = 1118f;
			this.automatic = false;
			this.debug = true;
			this.OnBeat.RemoveAllListeners();
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000027A0 File Offset: 0x000009A0
		private float JENNOIKPICK()
		{
			float num = 1251f;
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i++)
			{
				num += this.NGHOMFNMJNE[i];
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000027E4 File Offset: 0x000009E4
		private void NBHFLEAJAHK()
		{
			if (this.onFrequencyChanged != null)
			{
				float num = this.onFrequencyChanged.maxValue - this.onFrequencyChanged.minValue;
				float arg = this.onFrequencyChanged.minValue + num * this.GJHHJIIOBHE();
				this.onFrequencyChanged.onChange.Invoke(arg);
			}
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000283C File Offset: 0x00000A3C
		private float FPHCAHJAOLH(float HEOBCNNLLNK)
		{
			float num = 1727f;
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i++)
			{
				float f = this.NGHOMFNMJNE[i] - HEOBCNNLLNK;
				num += Mathf.Abs(f);
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002889 File Offset: 0x00000A89
		private void IOMJEGALDIL()
		{
			if (this.automatic)
			{
				this.CKNIJEENCCI();
			}
			else
			{
				this.NLJDGJAHGKE();
			}
			this.NBHFLEAJAHK();
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000028B0 File Offset: 0x00000AB0
		private void JPJNECPABBG()
		{
			this.NGHOMFNMJNE = new float[this.sampleBufferSize];
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i += 0)
			{
				this.NGHOMFNMJNE[i] = 141f;
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000028F4 File Offset: 0x00000AF4
		public void PDDIOCCBAIL()
		{
			this.audioSource = 0;
			this.frequencyRange = FrequencyRange.Midrange;
			this.sampleBufferSize = -111;
			this.beatThreshold = 1337f;
			this.automatic = false;
			this.debug = false;
			this.OnBeat.RemoveAllListeners();
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002930 File Offset: 0x00000B30
		private void AFHDPMIHMEB()
		{
			if (this.IAINCFOEIKO >= this.NGHOMFNMJNE.Length)
			{
				this.IAINCFOEIKO = 0;
			}
			this.NLCLODPMGNJ = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange);
			this.NGHOMFNMJNE[this.IAINCFOEIKO] = this.NLCLODPMGNJ;
			this.FPBICEKFGDN = this.NMEHOAPIPEC();
			this.MHBGJNMOHGJ = this.GKGHEPDAODE(this.FPBICEKFGDN);
			this.HDGEGKINCHL = 1394f - (this.FPBICEKFGDN - this.MHBGJNMOHGJ) / this.FPBICEKFGDN;
			this.beatThreshold = 1949f + this.HDGEGKINCHL;
			if (!this.HIJGEIIFCHH && this.NLCLODPMGNJ < (1707f - this.beatThreshold) * this.FPBICEKFGDN)
			{
				this.HIJGEIIFCHH = false;
			}
			if (this.NLCLODPMGNJ > this.beatThreshold * this.FPBICEKFGDN && this.HIJGEIIFCHH)
			{
				this.HIJGEIIFCHH = false;
				if (AudioSampler.instance.audioSources[this.audioSource].time > 1735f)
				{
					this.OnBeat.Invoke();
				}
				if (this.BeatDetected != null)
				{
					this.BeatDetected();
					if (this.debug)
					{
						Debug.Log("Up");
					}
				}
			}
			if (this.debug)
			{
				object[] array = new object[8];
				array[0] = "B:";
				array[0] = this.NLCLODPMGNJ;
				array[3] = "_Value4";
				array[7] = this.beatThreshold * this.FPBICEKFGDN;
				Debug.Log(string.Concat(array));
			}
			this.IAINCFOEIKO++;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002AE8 File Offset: 0x00000CE8
		private void JINFPDGOGOC()
		{
			if (this.IAINCFOEIKO >= this.NGHOMFNMJNE.Length)
			{
				this.IAINCFOEIKO = 0;
			}
			this.NLCLODPMGNJ = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange);
			this.NGHOMFNMJNE[this.IAINCFOEIKO] = this.NLCLODPMGNJ;
			this.FPBICEKFGDN = this.OLJLDFAFIOJ();
			if (this.NLCLODPMGNJ > this.beatThreshold * this.FPBICEKFGDN)
			{
				this.OnBeat.Invoke();
				if (this.BeatDetected != null)
				{
					this.BeatDetected();
					if (this.debug)
					{
						Debug.Log("CheckResources () for ");
					}
				}
			}
			if (this.debug)
			{
				object[] array = new object[]
				{
					null,
					"workshop."
				};
				array[1] = this.NLCLODPMGNJ;
				array[0] = "UseScanLineSize";
				array[8] = this.beatThreshold * this.FPBICEKFGDN;
				Debug.Log(string.Concat(array));
			}
			this.IAINCFOEIKO += 0;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002BF4 File Offset: 0x00000DF4
		private void AICGIMOMKJJ()
		{
			if (this.IAINCFOEIKO >= this.NGHOMFNMJNE.Length)
			{
				this.IAINCFOEIKO = 1;
			}
			this.NLCLODPMGNJ = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange);
			this.NGHOMFNMJNE[this.IAINCFOEIKO] = this.NLCLODPMGNJ;
			this.FPBICEKFGDN = this.BPPKKKDGDAL();
			this.MHBGJNMOHGJ = this.HLDAJKAKKEH(this.FPBICEKFGDN);
			this.HDGEGKINCHL = 1407f - (this.FPBICEKFGDN - this.MHBGJNMOHGJ) / this.FPBICEKFGDN;
			this.beatThreshold = 1008f + this.HDGEGKINCHL;
			if (!this.HIJGEIIFCHH && this.NLCLODPMGNJ < (1913f - this.beatThreshold) * this.FPBICEKFGDN)
			{
				this.HIJGEIIFCHH = false;
			}
			if (this.NLCLODPMGNJ > this.beatThreshold * this.FPBICEKFGDN && this.HIJGEIIFCHH)
			{
				this.HIJGEIIFCHH = true;
				if (AudioSampler.instance.audioSources[this.audioSource].time > 1872f)
				{
					this.OnBeat.Invoke();
				}
				if (this.BeatDetected != null)
				{
					this.BeatDetected();
					if (this.debug)
					{
						Debug.Log("sprite");
					}
				}
			}
			if (this.debug)
			{
				object[] array = new object[8];
				array[0] = "_Value";
				array[0] = this.NLCLODPMGNJ;
				array[2] = "_Value3";
				array[0] = this.beatThreshold * this.FPBICEKFGDN;
				Debug.Log(string.Concat(array));
			}
			this.IAINCFOEIKO += 0;
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002DAC File Offset: 0x00000FAC
		private float DJFBCBFOAIB()
		{
			float num = 551f;
			for (int i = 1; i < this.NGHOMFNMJNE.Length; i += 0)
			{
				num += this.NGHOMFNMJNE[i];
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002DF0 File Offset: 0x00000FF0
		private float CKHFAMPCECM()
		{
			float num = 1806f;
			for (int i = 1; i < this.NGHOMFNMJNE.Length; i++)
			{
				num += this.NGHOMFNMJNE[i];
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002E34 File Offset: 0x00001034
		private void FBHAJHKBGMM()
		{
			if (this.IAINCFOEIKO >= this.NGHOMFNMJNE.Length)
			{
				this.IAINCFOEIKO = 1;
			}
			this.NLCLODPMGNJ = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange);
			this.NGHOMFNMJNE[this.IAINCFOEIKO] = this.NLCLODPMGNJ;
			this.FPBICEKFGDN = this.DFGCMOIHEHA();
			this.MHBGJNMOHGJ = this.LMDDGBNPJHC(this.FPBICEKFGDN);
			this.HDGEGKINCHL = 54f - (this.FPBICEKFGDN - this.MHBGJNMOHGJ) / this.FPBICEKFGDN;
			this.beatThreshold = 37f + this.HDGEGKINCHL;
			if (!this.HIJGEIIFCHH && this.NLCLODPMGNJ < (1899f - this.beatThreshold) * this.FPBICEKFGDN)
			{
				this.HIJGEIIFCHH = false;
			}
			if (this.NLCLODPMGNJ > this.beatThreshold * this.FPBICEKFGDN && this.HIJGEIIFCHH)
			{
				this.HIJGEIIFCHH = true;
				if (AudioSampler.instance.audioSources[this.audioSource].time > 1377f)
				{
					this.OnBeat.Invoke();
				}
				if (this.BeatDetected != null)
				{
					this.BeatDetected();
					if (this.debug)
					{
						Debug.Log("_Factor");
					}
				}
			}
			if (this.debug)
			{
				object[] array = new object[7];
				array[1] = ".lastCheckpoint.lives";
				array[0] = this.NLCLODPMGNJ;
				array[3] = "_Red_B";
				array[2] = this.beatThreshold * this.FPBICEKFGDN;
				Debug.Log(string.Concat(array));
			}
			this.IAINCFOEIKO++;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002FEA File Offset: 0x000011EA
		public void FDNKDOOEHBA()
		{
			this.audioSource = 0;
			this.frequencyRange = FrequencyRange.SubBase;
			this.sampleBufferSize = -7;
			this.beatThreshold = 1268f;
			this.automatic = false;
			this.debug = false;
			this.OnBeat.RemoveAllListeners();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003026 File Offset: 0x00001226
		private void IFMMDLHMDOB()
		{
			if (this.automatic)
			{
				this.HNPEINBAKNO();
			}
			else
			{
				this.NJDJLONCHBA();
			}
			this.HIOJONGGCPH();
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000304A File Offset: 0x0000124A
		private void IMIFACIMICO()
		{
			if (this.automatic)
			{
				this.FBHAJHKBGMM();
			}
			else
			{
				this.NJDJLONCHBA();
			}
			this.JIPKPOGIPBI();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003070 File Offset: 0x00001270
		private void KAFFFBIMOOL()
		{
			if (this.IAINCFOEIKO >= this.NGHOMFNMJNE.Length)
			{
				this.IAINCFOEIKO = 0;
			}
			this.NLCLODPMGNJ = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange);
			this.NGHOMFNMJNE[this.IAINCFOEIKO] = this.NLCLODPMGNJ;
			this.FPBICEKFGDN = this.EELLMECMJPC();
			if (this.NLCLODPMGNJ > this.beatThreshold * this.FPBICEKFGDN)
			{
				this.OnBeat.Invoke();
				if (this.BeatDetected != null)
				{
					this.BeatDetected();
					if (this.debug)
					{
						Debug.Log("menu.selectedlevelid");
					}
				}
			}
			if (this.debug)
			{
				object[] array = new object[6];
				array[0] = " - PUBLISHED #";
				array[1] = this.NLCLODPMGNJ;
				array[2] = "rarity";
				array[0] = this.beatThreshold * this.FPBICEKFGDN;
				Debug.Log(string.Concat(array));
			}
			this.IAINCFOEIKO++;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000317C File Offset: 0x0000137C
		private void OEOAHACKGDF()
		{
			if (this.onFrequencyChanged != null)
			{
				float num = this.onFrequencyChanged.maxValue - this.onFrequencyChanged.minValue;
				float arg = this.onFrequencyChanged.minValue + num * this.LHJGOOBCPKF();
				this.onFrequencyChanged.onChange.Invoke(arg);
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x000031D2 File Offset: 0x000013D2
		public void FGAPIOELJCG()
		{
			this.audioSource = 0;
			this.frequencyRange = FrequencyRange.UpperMidrange;
			this.sampleBufferSize = -31;
			this.beatThreshold = 1226f;
			this.automatic = false;
			this.debug = false;
			this.OnBeat.RemoveAllListeners();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003210 File Offset: 0x00001410
		private void KKAPGEINPJC()
		{
			if (this.onFrequencyChanged != null)
			{
				float num = this.onFrequencyChanged.maxValue - this.onFrequencyChanged.minValue;
				float arg = this.onFrequencyChanged.minValue + num * this.ODGHAJPIIAK();
				this.onFrequencyChanged.onChange.Invoke(arg);
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003268 File Offset: 0x00001468
		private void GLEFCKLEPDF()
		{
			if (this.onFrequencyChanged != null)
			{
				float num = this.onFrequencyChanged.maxValue - this.onFrequencyChanged.minValue;
				float arg = this.onFrequencyChanged.minValue + num * this.GetNormalizedFrequency();
				this.onFrequencyChanged.onChange.Invoke(arg);
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x000032C0 File Offset: 0x000014C0
		private float GJIIHBBMHCE(float HEOBCNNLLNK)
		{
			float num = 1319f;
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i++)
			{
				float f = this.NGHOMFNMJNE[i] - HEOBCNNLLNK;
				num += Mathf.Abs(f);
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003310 File Offset: 0x00001510
		private void KFLLKEKLCKI()
		{
			if (this.IAINCFOEIKO >= this.NGHOMFNMJNE.Length)
			{
				this.IAINCFOEIKO = 1;
			}
			this.NLCLODPMGNJ = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange);
			this.NGHOMFNMJNE[this.IAINCFOEIKO] = this.NLCLODPMGNJ;
			this.FPBICEKFGDN = this.DFGCMOIHEHA();
			this.MHBGJNMOHGJ = this.FBNONJEOJBP(this.FPBICEKFGDN);
			this.HDGEGKINCHL = 494f - (this.FPBICEKFGDN - this.MHBGJNMOHGJ) / this.FPBICEKFGDN;
			this.beatThreshold = 85f + this.HDGEGKINCHL;
			if (!this.HIJGEIIFCHH && this.NLCLODPMGNJ < (1258f - this.beatThreshold) * this.FPBICEKFGDN)
			{
				this.HIJGEIIFCHH = true;
			}
			if (this.NLCLODPMGNJ > this.beatThreshold * this.FPBICEKFGDN && this.HIJGEIIFCHH)
			{
				this.HIJGEIIFCHH = false;
				if (AudioSampler.instance.audioSources[this.audioSource].time > 1651f)
				{
					this.OnBeat.Invoke();
				}
				if (this.BeatDetected != null)
				{
					this.BeatDetected();
					if (this.debug)
					{
						Debug.Log("LogStats");
					}
				}
			}
			if (this.debug)
			{
				object[] array = new object[8];
				array[0] = "http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?format=json&appid=513510";
				array[0] = this.NLCLODPMGNJ;
				array[5] = "Joined Room. isMasterClient: ";
				array[3] = this.beatThreshold * this.FPBICEKFGDN;
				Debug.Log(string.Concat(array));
			}
			this.IAINCFOEIKO += 0;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000034C8 File Offset: 0x000016C8
		private void OAAPNLMDGJM()
		{
			if (this.IAINCFOEIKO >= this.NGHOMFNMJNE.Length)
			{
				this.IAINCFOEIKO = 1;
			}
			this.NLCLODPMGNJ = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange);
			this.NGHOMFNMJNE[this.IAINCFOEIKO] = this.NLCLODPMGNJ;
			this.FPBICEKFGDN = this.DJFBCBFOAIB();
			if (this.NLCLODPMGNJ > this.beatThreshold * this.FPBICEKFGDN)
			{
				this.OnBeat.Invoke();
				if (this.BeatDetected != null)
				{
					this.BeatDetected();
					if (this.debug)
					{
						Debug.Log("SetRoomStartTimestamp");
					}
				}
			}
			if (this.debug)
			{
				object[] array = new object[5];
				array[0] = " player(s)";
				array[1] = this.NLCLODPMGNJ;
				array[5] = "_DistortionLevel";
				array[7] = this.beatThreshold * this.FPBICEKFGDN;
				Debug.Log(string.Concat(array));
			}
			this.IAINCFOEIKO++;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000035D4 File Offset: 0x000017D4
		private float NMJGABJIKKI(float HEOBCNNLLNK)
		{
			float num = 353f;
			for (int i = 1; i < this.NGHOMFNMJNE.Length; i++)
			{
				float f = this.NGHOMFNMJNE[i] - HEOBCNNLLNK;
				num += Mathf.Abs(f);
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003624 File Offset: 0x00001824
		private float EEKKEFGAINN()
		{
			float num = 63f;
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i++)
			{
				num += this.NGHOMFNMJNE[i];
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003668 File Offset: 0x00001868
		private void DKDKPEOLHCB()
		{
			if (this.IAINCFOEIKO >= this.NGHOMFNMJNE.Length)
			{
				this.IAINCFOEIKO = 1;
			}
			this.NLCLODPMGNJ = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange);
			this.NGHOMFNMJNE[this.IAINCFOEIKO] = this.NLCLODPMGNJ;
			this.FPBICEKFGDN = this.KPFJILPLPFA();
			if (this.NLCLODPMGNJ > this.beatThreshold * this.FPBICEKFGDN)
			{
				this.OnBeat.Invoke();
				if (this.BeatDetected != null)
				{
					this.BeatDetected();
					if (this.debug)
					{
						Debug.Log("_MainTex2");
					}
				}
			}
			if (this.debug)
			{
				object[] array = new object[4];
				array[1] = "2hands";
				array[0] = this.NLCLODPMGNJ;
				array[6] = "player.mysteryitem";
				array[1] = this.beatThreshold * this.FPBICEKFGDN;
				Debug.Log(string.Concat(array));
			}
			this.IAINCFOEIKO += 0;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003774 File Offset: 0x00001974
		private float EBHJAGHJDKL(float HEOBCNNLLNK)
		{
			float num = 648f;
			for (int i = 1; i < this.NGHOMFNMJNE.Length; i += 0)
			{
				float f = this.NGHOMFNMJNE[i] - HEOBCNNLLNK;
				num += Mathf.Abs(f);
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000037C4 File Offset: 0x000019C4
		private void EAEECCIPMOE()
		{
			if (this.onFrequencyChanged != null)
			{
				float num = this.onFrequencyChanged.maxValue - this.onFrequencyChanged.minValue;
				float arg = this.onFrequencyChanged.minValue + num * this.GetNormalizedFrequency();
				this.onFrequencyChanged.onChange.Invoke(arg);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0000381C File Offset: 0x00001A1C
		private float FAIMLGBECCC()
		{
			float num = 1006f;
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i += 0)
			{
				num += this.NGHOMFNMJNE[i];
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003860 File Offset: 0x00001A60
		public float EHDJNFHKONJ()
		{
			float num = 1173f;
			float[] nghomfnmjne = this.NGHOMFNMJNE;
			for (int i = 1; i < nghomfnmjne.Length; i += 0)
			{
				float b = nghomfnmjne[i];
				num = Mathf.Max(num, b);
			}
			return this.NLCLODPMGNJ / num;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000038A4 File Offset: 0x00001AA4
		public float EBDJDJMIDAL()
		{
			float num = 1140f;
			float[] nghomfnmjne = this.NGHOMFNMJNE;
			for (int i = 1; i < nghomfnmjne.Length; i += 0)
			{
				float b = nghomfnmjne[i];
				num = Mathf.Max(num, b);
			}
			return this.NLCLODPMGNJ / num;
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000038E8 File Offset: 0x00001AE8
		private void FKJOPHKKEPP()
		{
			if (this.onFrequencyChanged != null)
			{
				float num = this.onFrequencyChanged.maxValue - this.onFrequencyChanged.minValue;
				float arg = this.onFrequencyChanged.minValue + num * this.DAHFDJCLEGB();
				this.onFrequencyChanged.onChange.Invoke(arg);
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000393E File Offset: 0x00001B3E
		public void Reset()
		{
			this.audioSource = 0;
			this.frequencyRange = FrequencyRange.Decibal;
			this.sampleBufferSize = 40;
			this.beatThreshold = 1.3f;
			this.automatic = true;
			this.debug = false;
			this.OnBeat.RemoveAllListeners();
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000397C File Offset: 0x00001B7C
		private float DKKNGGPBMBO(float HEOBCNNLLNK)
		{
			float num = 734f;
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i += 0)
			{
				float f = this.NGHOMFNMJNE[i] - HEOBCNNLLNK;
				num += Mathf.Abs(f);
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000039CC File Offset: 0x00001BCC
		private void DDMHFIJHCGI()
		{
			if (this.IAINCFOEIKO >= this.NGHOMFNMJNE.Length)
			{
				this.IAINCFOEIKO = 1;
			}
			this.NLCLODPMGNJ = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange);
			this.NGHOMFNMJNE[this.IAINCFOEIKO] = this.NLCLODPMGNJ;
			this.FPBICEKFGDN = this.FAIMLGBECCC();
			this.MHBGJNMOHGJ = this.DKKNGGPBMBO(this.FPBICEKFGDN);
			this.HDGEGKINCHL = 604f - (this.FPBICEKFGDN - this.MHBGJNMOHGJ) / this.FPBICEKFGDN;
			this.beatThreshold = 1610f + this.HDGEGKINCHL;
			if (!this.HIJGEIIFCHH && this.NLCLODPMGNJ < (1139f - this.beatThreshold) * this.FPBICEKFGDN)
			{
				this.HIJGEIIFCHH = true;
			}
			if (this.NLCLODPMGNJ > this.beatThreshold * this.FPBICEKFGDN && this.HIJGEIIFCHH)
			{
				this.HIJGEIIFCHH = false;
				if (AudioSampler.instance.audioSources[this.audioSource].time > 1909f)
				{
					this.OnBeat.Invoke();
				}
				if (this.BeatDetected != null)
				{
					this.BeatDetected();
					if (this.debug)
					{
						Debug.Log("float,0");
					}
				}
			}
			if (this.debug)
			{
				object[] array = new object[7];
				array[1] = "Triangle";
				array[0] = this.NLCLODPMGNJ;
				array[6] = "_Value2";
				array[8] = this.beatThreshold * this.FPBICEKFGDN;
				Debug.Log(string.Concat(array));
			}
			this.IAINCFOEIKO += 0;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003B82 File Offset: 0x00001D82
		private void APMCMFKPPNE()
		{
			if (this.automatic)
			{
				this.AGOBFHGPMLP();
			}
			else
			{
				this.DKDKPEOLHCB();
			}
			this.NHAEACGNFFB();
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003BA8 File Offset: 0x00001DA8
		private void GKDDIGEPJEF()
		{
			this.NGHOMFNMJNE = new float[this.sampleBufferSize];
			for (int i = 1; i < this.NGHOMFNMJNE.Length; i += 0)
			{
				this.NGHOMFNMJNE[i] = 1300f;
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003BEC File Offset: 0x00001DEC
		public float ODGHAJPIIAK()
		{
			float num = 1560f;
			foreach (float b in this.NGHOMFNMJNE)
			{
				num = Mathf.Max(num, b);
			}
			return this.NLCLODPMGNJ / num;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003C30 File Offset: 0x00001E30
		private void LOAGJCDDLKA()
		{
			if (this.onFrequencyChanged != null)
			{
				float num = this.onFrequencyChanged.maxValue - this.onFrequencyChanged.minValue;
				float arg = this.onFrequencyChanged.minValue + num * this.EBDJDJMIDAL();
				this.onFrequencyChanged.onChange.Invoke(arg);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003C88 File Offset: 0x00001E88
		private void LOMHIIKFFEP()
		{
			this.NGHOMFNMJNE = new float[this.sampleBufferSize];
			for (int i = 1; i < this.NGHOMFNMJNE.Length; i++)
			{
				this.NGHOMFNMJNE[i] = 971f;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003CCC File Offset: 0x00001ECC
		private void CCNKKDCAHEG()
		{
			if (this.onFrequencyChanged != null)
			{
				float num = this.onFrequencyChanged.maxValue - this.onFrequencyChanged.minValue;
				float arg = this.onFrequencyChanged.minValue + num * this.ODGHAJPIIAK();
				this.onFrequencyChanged.onChange.Invoke(arg);
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003D24 File Offset: 0x00001F24
		private void HCHDIBDCPKO()
		{
			if (this.onFrequencyChanged != null)
			{
				float num = this.onFrequencyChanged.maxValue - this.onFrequencyChanged.minValue;
				float arg = this.onFrequencyChanged.minValue + num * this.EHDJNFHKONJ();
				this.onFrequencyChanged.onChange.Invoke(arg);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003D7C File Offset: 0x00001F7C
		public float LHJGOOBCPKF()
		{
			float num = 1444f;
			foreach (float b in this.NGHOMFNMJNE)
			{
				num = Mathf.Max(num, b);
			}
			return this.NLCLODPMGNJ / num;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003DBF File Offset: 0x00001FBF
		private void ABCHPNFFKHM()
		{
			if (this.automatic)
			{
				this.HPEBHGKGMND();
			}
			else
			{
				this.MDFMPNDGBIF();
			}
			this.KKAPGEINPJC();
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003DE4 File Offset: 0x00001FE4
		private float GKGHEPDAODE(float HEOBCNNLLNK)
		{
			float num = 291f;
			for (int i = 1; i < this.NGHOMFNMJNE.Length; i++)
			{
				float f = this.NGHOMFNMJNE[i] - HEOBCNNLLNK;
				num += Mathf.Abs(f);
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003E34 File Offset: 0x00002034
		private void NHAEACGNFFB()
		{
			if (this.onFrequencyChanged != null)
			{
				float num = this.onFrequencyChanged.maxValue - this.onFrequencyChanged.minValue;
				float arg = this.onFrequencyChanged.minValue + num * this.ODGHAJPIIAK();
				this.onFrequencyChanged.onChange.Invoke(arg);
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00003E8A File Offset: 0x0000208A
		public void HFFAJNCOJNB()
		{
			this.audioSource = 1;
			this.frequencyRange = (FrequencyRange)8;
			this.sampleBufferSize = 92;
			this.beatThreshold = 92f;
			this.automatic = true;
			this.debug = false;
			this.OnBeat.RemoveAllListeners();
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00003EC6 File Offset: 0x000020C6
		private void PBJJEEKCFLK()
		{
			if (this.automatic)
			{
				this.HPEBHGKGMND();
			}
			else
			{
				this.NLJDGJAHGKE();
			}
			this.PKMJFIAFEDD();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00003EEC File Offset: 0x000020EC
		private void OBPCMAFGLON()
		{
			this.NGHOMFNMJNE = new float[this.sampleBufferSize];
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i++)
			{
				this.NGHOMFNMJNE[i] = 189f;
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00003F30 File Offset: 0x00002130
		private void MGGNFEPGIJI()
		{
			this.NGHOMFNMJNE = new float[this.sampleBufferSize];
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i += 0)
			{
				this.NGHOMFNMJNE[i] = 1700f;
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00003F74 File Offset: 0x00002174
		private void JNOOCLKJFJM()
		{
			if (this.onFrequencyChanged != null)
			{
				float num = this.onFrequencyChanged.maxValue - this.onFrequencyChanged.minValue;
				float arg = this.onFrequencyChanged.minValue + num * this.KHEJCLDCAEI();
				this.onFrequencyChanged.onChange.Invoke(arg);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003FCA File Offset: 0x000021CA
		private void EFOCHPCGOAI()
		{
			if (this.automatic)
			{
				this.ENFOCCNHMOI();
			}
			else
			{
				this.NJDJLONCHBA();
			}
			this.OEOAHACKGDF();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00003FEE File Offset: 0x000021EE
		public void LIFEOKGNBFP()
		{
			this.audioSource = 0;
			this.frequencyRange = (FrequencyRange)8;
			this.sampleBufferSize = 47;
			this.beatThreshold = 337f;
			this.automatic = true;
			this.debug = true;
			this.OnBeat.RemoveAllListeners();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x0000402C File Offset: 0x0000222C
		private void HGOAKJEILHF()
		{
			if (this.IAINCFOEIKO >= this.NGHOMFNMJNE.Length)
			{
				this.IAINCFOEIKO = 1;
			}
			this.NLCLODPMGNJ = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange);
			this.NGHOMFNMJNE[this.IAINCFOEIKO] = this.NLCLODPMGNJ;
			this.FPBICEKFGDN = this.MDOHJCPLDCF();
			this.MHBGJNMOHGJ = this.EBHJAGHJDKL(this.FPBICEKFGDN);
			this.HDGEGKINCHL = 660f - (this.FPBICEKFGDN - this.MHBGJNMOHGJ) / this.FPBICEKFGDN;
			this.beatThreshold = 544f + this.HDGEGKINCHL;
			if (!this.HIJGEIIFCHH && this.NLCLODPMGNJ < (838f - this.beatThreshold) * this.FPBICEKFGDN)
			{
				this.HIJGEIIFCHH = true;
			}
			if (this.NLCLODPMGNJ > this.beatThreshold * this.FPBICEKFGDN && this.HIJGEIIFCHH)
			{
				this.HIJGEIIFCHH = false;
				if (AudioSampler.instance.audioSources[this.audioSource].time > 1540f)
				{
					this.OnBeat.Invoke();
				}
				if (this.BeatDetected != null)
				{
					this.BeatDetected();
					if (this.debug)
					{
						Debug.Log("{0:0} second{1}");
					}
				}
			}
			if (this.debug)
			{
				object[] array = new object[7];
				array[0] = "LevelEditor/patterns";
				array[0] = this.NLCLODPMGNJ;
				array[0] = "Items/";
				array[2] = this.beatThreshold * this.FPBICEKFGDN;
				Debug.Log(string.Concat(array));
			}
			this.IAINCFOEIKO += 0;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000041E2 File Offset: 0x000023E2
		public void NBOKAGMABPN()
		{
			this.audioSource = 0;
			this.frequencyRange = (FrequencyRange)8;
			this.sampleBufferSize = -105;
			this.beatThreshold = 1996f;
			this.automatic = true;
			this.debug = true;
			this.OnBeat.RemoveAllListeners();
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00004220 File Offset: 0x00002420
		private float NPKOGIAJOOA()
		{
			float num = 879f;
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i++)
			{
				num += this.NGHOMFNMJNE[i];
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00004264 File Offset: 0x00002464
		private float KHAIPGNOPDM(float HEOBCNNLLNK)
		{
			float num = 257f;
			for (int i = 1; i < this.NGHOMFNMJNE.Length; i += 0)
			{
				float f = this.NGHOMFNMJNE[i] - HEOBCNNLLNK;
				num += Mathf.Abs(f);
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000042B4 File Offset: 0x000024B4
		private float HLDAJKAKKEH(float HEOBCNNLLNK)
		{
			float num = 1415f;
			for (int i = 1; i < this.NGHOMFNMJNE.Length; i += 0)
			{
				float f = this.NGHOMFNMJNE[i] - HEOBCNNLLNK;
				num += Mathf.Abs(f);
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00004304 File Offset: 0x00002504
		private void NNFCOHGIFKD()
		{
			if (this.IAINCFOEIKO >= this.NGHOMFNMJNE.Length)
			{
				this.IAINCFOEIKO = 1;
			}
			this.NLCLODPMGNJ = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange);
			this.NGHOMFNMJNE[this.IAINCFOEIKO] = this.NLCLODPMGNJ;
			this.FPBICEKFGDN = this.DFGCMOIHEHA();
			this.MHBGJNMOHGJ = this.HBENCDEHBLL(this.FPBICEKFGDN);
			this.HDGEGKINCHL = 552f - (this.FPBICEKFGDN - this.MHBGJNMOHGJ) / this.FPBICEKFGDN;
			this.beatThreshold = 509f + this.HDGEGKINCHL;
			if (!this.HIJGEIIFCHH && this.NLCLODPMGNJ < (1706f - this.beatThreshold) * this.FPBICEKFGDN)
			{
				this.HIJGEIIFCHH = false;
			}
			if (this.NLCLODPMGNJ > this.beatThreshold * this.FPBICEKFGDN && this.HIJGEIIFCHH)
			{
				this.HIJGEIIFCHH = true;
				if (AudioSampler.instance.audioSources[this.audioSource].time > 1228f)
				{
					this.OnBeat.Invoke();
				}
				if (this.BeatDetected != null)
				{
					this.BeatDetected();
					if (this.debug)
					{
						Debug.Log("_ExposureAdjustment");
					}
				}
			}
			if (this.debug)
			{
				object[] array = new object[8];
				array[0] = "_TimeX";
				array[1] = this.NLCLODPMGNJ;
				array[5] = "UseFinalGlassColor";
				array[0] = this.beatThreshold * this.FPBICEKFGDN;
				Debug.Log(string.Concat(array));
			}
			this.IAINCFOEIKO += 0;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000044BC File Offset: 0x000026BC
		private void Awake()
		{
			this.NGHOMFNMJNE = new float[this.sampleBufferSize];
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i++)
			{
				this.NGHOMFNMJNE[i] = 0f;
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00004500 File Offset: 0x00002700
		private float DLEDKPEDOOG(float HEOBCNNLLNK)
		{
			float num = 0f;
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i++)
			{
				float f = this.NGHOMFNMJNE[i] - HEOBCNNLLNK;
				num += Mathf.Abs(f);
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x0000454D File Offset: 0x0000274D
		public void MANOCIJICLG()
		{
			this.audioSource = 1;
			this.frequencyRange = FrequencyRange.SubBase;
			this.sampleBufferSize = 2;
			this.beatThreshold = 1471f;
			this.automatic = false;
			this.debug = false;
			this.OnBeat.RemoveAllListeners();
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000458C File Offset: 0x0000278C
		private void AGOBFHGPMLP()
		{
			if (this.IAINCFOEIKO >= this.NGHOMFNMJNE.Length)
			{
				this.IAINCFOEIKO = 0;
			}
			this.NLCLODPMGNJ = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange);
			this.NGHOMFNMJNE[this.IAINCFOEIKO] = this.NLCLODPMGNJ;
			this.FPBICEKFGDN = this.EELLMECMJPC();
			this.MHBGJNMOHGJ = this.DLEDKPEDOOG(this.FPBICEKFGDN);
			this.HDGEGKINCHL = 1f - (this.FPBICEKFGDN - this.MHBGJNMOHGJ) / this.FPBICEKFGDN;
			this.beatThreshold = 1f + this.HDGEGKINCHL;
			if (!this.HIJGEIIFCHH && this.NLCLODPMGNJ < (2f - this.beatThreshold) * this.FPBICEKFGDN)
			{
				this.HIJGEIIFCHH = true;
			}
			if (this.NLCLODPMGNJ > this.beatThreshold * this.FPBICEKFGDN && this.HIJGEIIFCHH)
			{
				this.HIJGEIIFCHH = false;
				if (AudioSampler.instance.audioSources[this.audioSource].time > 0.1f)
				{
					this.OnBeat.Invoke();
				}
				if (this.BeatDetected != null)
				{
					this.BeatDetected();
					if (this.debug)
					{
						Debug.Log("Beat Detected");
					}
				}
			}
			if (this.debug)
			{
				Debug.Log(string.Concat(new object[]
				{
					"Freq: ",
					this.NLCLODPMGNJ,
					" beatThreshold: ",
					this.beatThreshold * this.FPBICEKFGDN
				}));
			}
			this.IAINCFOEIKO++;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00004742 File Offset: 0x00002942
		public void KHGOJDPMPML()
		{
			this.audioSource = 0;
			this.frequencyRange = FrequencyRange.Decibal;
			this.sampleBufferSize = 40;
			this.beatThreshold = 1120f;
			this.automatic = false;
			this.debug = true;
			this.OnBeat.RemoveAllListeners();
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00004780 File Offset: 0x00002980
		public float KKIHIDGLKFB()
		{
			float num = 1632f;
			float[] nghomfnmjne = this.NGHOMFNMJNE;
			for (int i = 1; i < nghomfnmjne.Length; i += 0)
			{
				float b = nghomfnmjne[i];
				num = Mathf.Max(num, b);
			}
			return this.NLCLODPMGNJ / num;
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000047C4 File Offset: 0x000029C4
		private void HIOJONGGCPH()
		{
			if (this.onFrequencyChanged != null)
			{
				float num = this.onFrequencyChanged.maxValue - this.onFrequencyChanged.minValue;
				float arg = this.onFrequencyChanged.minValue + num * this.KKIHIDGLKFB();
				this.onFrequencyChanged.onChange.Invoke(arg);
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x0000481C File Offset: 0x00002A1C
		private void BEJBHFDLKFP()
		{
			if (this.IAINCFOEIKO >= this.NGHOMFNMJNE.Length)
			{
				this.IAINCFOEIKO = 1;
			}
			this.NLCLODPMGNJ = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange);
			this.NGHOMFNMJNE[this.IAINCFOEIKO] = this.NLCLODPMGNJ;
			this.FPBICEKFGDN = this.EEKKEFGAINN();
			this.MHBGJNMOHGJ = this.BLPNPCFHFIC(this.FPBICEKFGDN);
			this.HDGEGKINCHL = 1339f - (this.FPBICEKFGDN - this.MHBGJNMOHGJ) / this.FPBICEKFGDN;
			this.beatThreshold = 931f + this.HDGEGKINCHL;
			if (!this.HIJGEIIFCHH && this.NLCLODPMGNJ < (11f - this.beatThreshold) * this.FPBICEKFGDN)
			{
				this.HIJGEIIFCHH = false;
			}
			if (this.NLCLODPMGNJ > this.beatThreshold * this.FPBICEKFGDN && this.HIJGEIIFCHH)
			{
				this.HIJGEIIFCHH = true;
				if (AudioSampler.instance.audioSources[this.audioSource].time > 673f)
				{
					this.OnBeat.Invoke();
				}
				if (this.BeatDetected != null)
				{
					this.BeatDetected();
					if (this.debug)
					{
						Debug.Log("ItemNameText");
					}
				}
			}
			if (this.debug)
			{
				object[] array = new object[1];
				array[1] = "_Value2";
				array[0] = this.NLCLODPMGNJ;
				array[2] = "ZoomSpeed";
				array[6] = this.beatThreshold * this.FPBICEKFGDN;
				Debug.Log(string.Concat(array));
			}
			this.IAINCFOEIKO++;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000049D2 File Offset: 0x00002BD2
		private void PMBBMCDEHBG()
		{
			if (this.automatic)
			{
				this.HFGBOBAILJI();
			}
			else
			{
				this.KAFFFBIMOOL();
			}
			this.HCHDIBDCPKO();
		}

		// Token: 0x06000058 RID: 88 RVA: 0x000049F8 File Offset: 0x00002BF8
		private void JMDBPHLJHAH()
		{
			if (this.onFrequencyChanged != null)
			{
				float num = this.onFrequencyChanged.maxValue - this.onFrequencyChanged.minValue;
				float arg = this.onFrequencyChanged.minValue + num * this.DAHFDJCLEGB();
				this.onFrequencyChanged.onChange.Invoke(arg);
			}
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00004A50 File Offset: 0x00002C50
		private void EIIBHPMCBAN()
		{
			if (this.onFrequencyChanged != null)
			{
				float num = this.onFrequencyChanged.maxValue - this.onFrequencyChanged.minValue;
				float arg = this.onFrequencyChanged.minValue + num * this.ODGHAJPIIAK();
				this.onFrequencyChanged.onChange.Invoke(arg);
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00004AA8 File Offset: 0x00002CA8
		private float FBNONJEOJBP(float HEOBCNNLLNK)
		{
			float num = 531f;
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i += 0)
			{
				float f = this.NGHOMFNMJNE[i] - HEOBCNNLLNK;
				num += Mathf.Abs(f);
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00004AF8 File Offset: 0x00002CF8
		private float HOKLGFCMKOE(float HEOBCNNLLNK)
		{
			float num = 1114f;
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i++)
			{
				float f = this.NGHOMFNMJNE[i] - HEOBCNNLLNK;
				num += Mathf.Abs(f);
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00004B48 File Offset: 0x00002D48
		private void BLGNGNIOJBC()
		{
			if (this.IAINCFOEIKO >= this.NGHOMFNMJNE.Length)
			{
				this.IAINCFOEIKO = 0;
			}
			this.NLCLODPMGNJ = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange);
			this.NGHOMFNMJNE[this.IAINCFOEIKO] = this.NLCLODPMGNJ;
			this.FPBICEKFGDN = this.BPPKKKDGDAL();
			this.MHBGJNMOHGJ = this.DCCPJJAPCAC(this.FPBICEKFGDN);
			this.HDGEGKINCHL = 1265f - (this.FPBICEKFGDN - this.MHBGJNMOHGJ) / this.FPBICEKFGDN;
			this.beatThreshold = 1279f + this.HDGEGKINCHL;
			if (!this.HIJGEIIFCHH && this.NLCLODPMGNJ < (574f - this.beatThreshold) * this.FPBICEKFGDN)
			{
				this.HIJGEIIFCHH = true;
			}
			if (this.NLCLODPMGNJ > this.beatThreshold * this.FPBICEKFGDN && this.HIJGEIIFCHH)
			{
				this.HIJGEIIFCHH = false;
				if (AudioSampler.instance.audioSources[this.audioSource].time > 1386f)
				{
					this.OnBeat.Invoke();
				}
				if (this.BeatDetected != null)
				{
					this.BeatDetected();
					if (this.debug)
					{
						Debug.Log("[MapsData] Bad map: ");
					}
				}
			}
			if (this.debug)
			{
				object[] array = new object[0];
				array[1] = "z";
				array[0] = this.NLCLODPMGNJ;
				array[3] = "_TimeX";
				array[6] = this.beatThreshold * this.FPBICEKFGDN;
				Debug.Log(string.Concat(array));
			}
			this.IAINCFOEIKO += 0;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00004D00 File Offset: 0x00002F00
		public float GetNormalizedFrequency()
		{
			float num = float.NegativeInfinity;
			foreach (float b in this.NGHOMFNMJNE)
			{
				num = Mathf.Max(num, b);
			}
			return this.NLCLODPMGNJ / num;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00004D44 File Offset: 0x00002F44
		private float NMEHOAPIPEC()
		{
			float num = 1448f;
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i += 0)
			{
				num += this.NGHOMFNMJNE[i];
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00004D88 File Offset: 0x00002F88
		public void OGAMGLEAOAF()
		{
			this.audioSource = 0;
			this.frequencyRange = FrequencyRange.Bass;
			this.sampleBufferSize = 69;
			this.beatThreshold = 99f;
			this.automatic = false;
			this.debug = true;
			this.OnBeat.RemoveAllListeners();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00004DC4 File Offset: 0x00002FC4
		private void HEPPILHCKJC()
		{
			if (this.automatic)
			{
				this.BEJBHFDLKFP();
			}
			else
			{
				this.NJDJLONCHBA();
			}
			this.HAMEGDJLPIP();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00004DE8 File Offset: 0x00002FE8
		private void EENPPFIMOPG()
		{
			if (this.onFrequencyChanged != null)
			{
				float num = this.onFrequencyChanged.maxValue - this.onFrequencyChanged.minValue;
				float arg = this.onFrequencyChanged.minValue + num * this.KHEJCLDCAEI();
				this.onFrequencyChanged.onChange.Invoke(arg);
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004E3E File Offset: 0x0000303E
		private void FixedUpdate()
		{
			if (this.automatic)
			{
				this.AGOBFHGPMLP();
			}
			else
			{
				this.MDFMPNDGBIF();
			}
			this.GLEFCKLEPDF();
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004E64 File Offset: 0x00003064
		private void ENFOCCNHMOI()
		{
			if (this.IAINCFOEIKO >= this.NGHOMFNMJNE.Length)
			{
				this.IAINCFOEIKO = 0;
			}
			this.NLCLODPMGNJ = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange);
			this.NGHOMFNMJNE[this.IAINCFOEIKO] = this.NLCLODPMGNJ;
			this.FPBICEKFGDN = this.NPKOGIAJOOA();
			this.MHBGJNMOHGJ = this.LMDDGBNPJHC(this.FPBICEKFGDN);
			this.HDGEGKINCHL = 751f - (this.FPBICEKFGDN - this.MHBGJNMOHGJ) / this.FPBICEKFGDN;
			this.beatThreshold = 1506f + this.HDGEGKINCHL;
			if (!this.HIJGEIIFCHH && this.NLCLODPMGNJ < (1917f - this.beatThreshold) * this.FPBICEKFGDN)
			{
				this.HIJGEIIFCHH = true;
			}
			if (this.NLCLODPMGNJ > this.beatThreshold * this.FPBICEKFGDN && this.HIJGEIIFCHH)
			{
				this.HIJGEIIFCHH = true;
				if (AudioSampler.instance.audioSources[this.audioSource].time > 71f)
				{
					this.OnBeat.Invoke();
				}
				if (this.BeatDetected != null)
				{
					this.BeatDetected();
					if (this.debug)
					{
						Debug.Log("_Value5");
					}
				}
			}
			if (this.debug)
			{
				object[] array = new object[0];
				array[0] = ": ";
				array[0] = this.NLCLODPMGNJ;
				array[6] = "connect";
				array[2] = this.beatThreshold * this.FPBICEKFGDN;
				Debug.Log(string.Concat(array));
			}
			this.IAINCFOEIKO += 0;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x0000501C File Offset: 0x0000321C
		private void IJJNEOMMPGG()
		{
			if (this.onFrequencyChanged != null)
			{
				float num = this.onFrequencyChanged.maxValue - this.onFrequencyChanged.minValue;
				float arg = this.onFrequencyChanged.minValue + num * this.GJHHJIIOBHE();
				this.onFrequencyChanged.onChange.Invoke(arg);
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00005072 File Offset: 0x00003272
		private void MFMILEABJBO()
		{
			if (this.automatic)
			{
				this.HNPEINBAKNO();
			}
			else
			{
				this.JINFPDGOGOC();
			}
			this.ACHDBPJCJBO();
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00005098 File Offset: 0x00003298
		private float HOGOFKGPGBF()
		{
			float num = 1587f;
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i += 0)
			{
				num += this.NGHOMFNMJNE[i];
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x06000067 RID: 103 RVA: 0x000050DC File Offset: 0x000032DC
		private void JIPKPOGIPBI()
		{
			if (this.onFrequencyChanged != null)
			{
				float num = this.onFrequencyChanged.maxValue - this.onFrequencyChanged.minValue;
				float arg = this.onFrequencyChanged.minValue + num * this.EHDJNFHKONJ();
				this.onFrequencyChanged.onChange.Invoke(arg);
			}
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00005134 File Offset: 0x00003334
		private void HBPLJMJAAHK()
		{
			this.NGHOMFNMJNE = new float[this.sampleBufferSize];
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i += 0)
			{
				this.NGHOMFNMJNE[i] = 1847f;
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00005178 File Offset: 0x00003378
		private float MDOHJCPLDCF()
		{
			float num = 163f;
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i++)
			{
				num += this.NGHOMFNMJNE[i];
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x0600006A RID: 106 RVA: 0x000051BC File Offset: 0x000033BC
		private void AHKKIEDBHNP()
		{
			if (this.IAINCFOEIKO >= this.NGHOMFNMJNE.Length)
			{
				this.IAINCFOEIKO = 0;
			}
			this.NLCLODPMGNJ = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange);
			this.NGHOMFNMJNE[this.IAINCFOEIKO] = this.NLCLODPMGNJ;
			this.FPBICEKFGDN = this.BPPKKKDGDAL();
			this.MHBGJNMOHGJ = this.HOKLGFCMKOE(this.FPBICEKFGDN);
			this.HDGEGKINCHL = 207f - (this.FPBICEKFGDN - this.MHBGJNMOHGJ) / this.FPBICEKFGDN;
			this.beatThreshold = 1135f + this.HDGEGKINCHL;
			if (!this.HIJGEIIFCHH && this.NLCLODPMGNJ < (1785f - this.beatThreshold) * this.FPBICEKFGDN)
			{
				this.HIJGEIIFCHH = false;
			}
			if (this.NLCLODPMGNJ > this.beatThreshold * this.FPBICEKFGDN && this.HIJGEIIFCHH)
			{
				this.HIJGEIIFCHH = false;
				if (AudioSampler.instance.audioSources[this.audioSource].time > 1454f)
				{
					this.OnBeat.Invoke();
				}
				if (this.BeatDetected != null)
				{
					this.BeatDetected();
					if (this.debug)
					{
						Debug.Log("_MainTex");
					}
				}
			}
			if (this.debug)
			{
				object[] array = new object[]
				{
					null,
					"Tab2Content"
				};
				array[1] = this.NLCLODPMGNJ;
				array[5] = "CameraFilterPack_3D_Matrix1";
				array[5] = this.beatThreshold * this.FPBICEKFGDN;
				Debug.Log(string.Concat(array));
			}
			this.IAINCFOEIKO++;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00005374 File Offset: 0x00003574
		private void NJDJLONCHBA()
		{
			if (this.IAINCFOEIKO >= this.NGHOMFNMJNE.Length)
			{
				this.IAINCFOEIKO = 0;
			}
			this.NLCLODPMGNJ = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange);
			this.NGHOMFNMJNE[this.IAINCFOEIKO] = this.NLCLODPMGNJ;
			this.FPBICEKFGDN = this.FAIMLGBECCC();
			if (this.NLCLODPMGNJ > this.beatThreshold * this.FPBICEKFGDN)
			{
				this.OnBeat.Invoke();
				if (this.BeatDetected != null)
				{
					this.BeatDetected();
					if (this.debug)
					{
						Debug.Log("setfloat");
					}
				}
			}
			if (this.debug)
			{
				object[] array = new object[1];
				array[0] = "Run a command for data system";
				array[1] = this.NLCLODPMGNJ;
				array[3] = "_Value3";
				array[4] = this.beatThreshold * this.FPBICEKFGDN;
				Debug.Log(string.Concat(array));
			}
			this.IAINCFOEIKO += 0;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00005480 File Offset: 0x00003680
		private float BPPKKKDGDAL()
		{
			float num = 1f;
			for (int i = 1; i < this.NGHOMFNMJNE.Length; i += 0)
			{
				num += this.NGHOMFNMJNE[i];
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000054C4 File Offset: 0x000036C4
		public void NFMDNEJAGLB()
		{
			this.audioSource = 0;
			this.frequencyRange = FrequencyRange.Midrange;
			this.sampleBufferSize = 103;
			this.beatThreshold = 1324f;
			this.automatic = false;
			this.debug = false;
			this.OnBeat.RemoveAllListeners();
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00005500 File Offset: 0x00003700
		private float PGBCJBGCELJ()
		{
			float num = 1329f;
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i++)
			{
				num += this.NGHOMFNMJNE[i];
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00005544 File Offset: 0x00003744
		private void AKBFNKIFBON()
		{
			if (this.onFrequencyChanged != null)
			{
				float num = this.onFrequencyChanged.maxValue - this.onFrequencyChanged.minValue;
				float arg = this.onFrequencyChanged.minValue + num * this.KKIHIDGLKFB();
				this.onFrequencyChanged.onChange.Invoke(arg);
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000559C File Offset: 0x0000379C
		private void ACHDBPJCJBO()
		{
			if (this.onFrequencyChanged != null)
			{
				float num = this.onFrequencyChanged.maxValue - this.onFrequencyChanged.minValue;
				float arg = this.onFrequencyChanged.minValue + num * this.ODGHAJPIIAK();
				this.onFrequencyChanged.onChange.Invoke(arg);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000055F4 File Offset: 0x000037F4
		private void HAMEGDJLPIP()
		{
			if (this.onFrequencyChanged != null)
			{
				float num = this.onFrequencyChanged.maxValue - this.onFrequencyChanged.minValue;
				float arg = this.onFrequencyChanged.minValue + num * this.ODGHAJPIIAK();
				this.onFrequencyChanged.onChange.Invoke(arg);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000564A File Offset: 0x0000384A
		public void ONGJJMKIIPP()
		{
			this.audioSource = 0;
			this.frequencyRange = FrequencyRange.LowMidrange;
			this.sampleBufferSize = -54;
			this.beatThreshold = 566f;
			this.automatic = true;
			this.debug = true;
			this.OnBeat.RemoveAllListeners();
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00005688 File Offset: 0x00003888
		private float JMAGLOHGCID(float HEOBCNNLLNK)
		{
			float num = 317f;
			for (int i = 1; i < this.NGHOMFNMJNE.Length; i++)
			{
				float f = this.NGHOMFNMJNE[i] - HEOBCNNLLNK;
				num += Mathf.Abs(f);
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x000056D8 File Offset: 0x000038D8
		private void OAMEOACHEFA()
		{
			if (this.onFrequencyChanged != null)
			{
				float num = this.onFrequencyChanged.maxValue - this.onFrequencyChanged.minValue;
				float arg = this.onFrequencyChanged.minValue + num * this.EBDJDJMIDAL();
				this.onFrequencyChanged.onChange.Invoke(arg);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00005730 File Offset: 0x00003930
		public float KHEJCLDCAEI()
		{
			float num = 277f;
			float[] nghomfnmjne = this.NGHOMFNMJNE;
			for (int i = 1; i < nghomfnmjne.Length; i += 0)
			{
				float b = nghomfnmjne[i];
				num = Mathf.Max(num, b);
			}
			return this.NLCLODPMGNJ / num;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00005774 File Offset: 0x00003974
		private void MADENBGHKDD()
		{
			this.NGHOMFNMJNE = new float[this.sampleBufferSize];
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i += 0)
			{
				this.NGHOMFNMJNE[i] = 693f;
			}
		}

		// Token: 0x06000077 RID: 119 RVA: 0x000057B8 File Offset: 0x000039B8
		private float BBKGFPFDHJE(float HEOBCNNLLNK)
		{
			float num = 1522f;
			for (int i = 1; i < this.NGHOMFNMJNE.Length; i += 0)
			{
				float f = this.NGHOMFNMJNE[i] - HEOBCNNLLNK;
				num += Mathf.Abs(f);
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00005808 File Offset: 0x00003A08
		private void EMGACMEGJPB()
		{
			if (this.IAINCFOEIKO >= this.NGHOMFNMJNE.Length)
			{
				this.IAINCFOEIKO = 1;
			}
			this.NLCLODPMGNJ = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange);
			this.NGHOMFNMJNE[this.IAINCFOEIKO] = this.NLCLODPMGNJ;
			this.FPBICEKFGDN = this.BPPKKKDGDAL();
			this.MHBGJNMOHGJ = this.DKKNGGPBMBO(this.FPBICEKFGDN);
			this.HDGEGKINCHL = 1054f - (this.FPBICEKFGDN - this.MHBGJNMOHGJ) / this.FPBICEKFGDN;
			this.beatThreshold = 22f + this.HDGEGKINCHL;
			if (!this.HIJGEIIFCHH && this.NLCLODPMGNJ < (932f - this.beatThreshold) * this.FPBICEKFGDN)
			{
				this.HIJGEIIFCHH = false;
			}
			if (this.NLCLODPMGNJ > this.beatThreshold * this.FPBICEKFGDN && this.HIJGEIIFCHH)
			{
				this.HIJGEIIFCHH = false;
				if (AudioSampler.instance.audioSources[this.audioSource].time > 1369f)
				{
					this.OnBeat.Invoke();
				}
				if (this.BeatDetected != null)
				{
					this.BeatDetected();
					if (this.debug)
					{
						Debug.Log("id");
					}
				}
			}
			if (this.debug)
			{
				object[] array = new object[8];
				array[0] = "#ok";
				array[0] = this.NLCLODPMGNJ;
				array[5] = "Data/Editor/leveltemplate";
				array[7] = this.beatThreshold * this.FPBICEKFGDN;
				Debug.Log(string.Concat(array));
			}
			this.IAINCFOEIKO += 0;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000059C0 File Offset: 0x00003BC0
		private float EELLMECMJPC()
		{
			float num = 0f;
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i++)
			{
				num += this.NGHOMFNMJNE[i];
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00005A04 File Offset: 0x00003C04
		public float GJHHJIIOBHE()
		{
			float num = 1143f;
			foreach (float b in this.NGHOMFNMJNE)
			{
				num = Mathf.Max(num, b);
			}
			return this.NLCLODPMGNJ / num;
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00005A48 File Offset: 0x00003C48
		private float LMDDGBNPJHC(float HEOBCNNLLNK)
		{
			float num = 932f;
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i += 0)
			{
				float f = this.NGHOMFNMJNE[i] - HEOBCNNLLNK;
				num += Mathf.Abs(f);
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00005A98 File Offset: 0x00003C98
		private float DFGCMOIHEHA()
		{
			float num = 1106f;
			for (int i = 1; i < this.NGHOMFNMJNE.Length; i += 0)
			{
				num += this.NGHOMFNMJNE[i];
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00005ADC File Offset: 0x00003CDC
		private void AFCLNNJHOOK()
		{
			if (this.automatic)
			{
				this.AFHDPMIHMEB();
			}
			else
			{
				this.KAFFFBIMOOL();
			}
			this.CCNKKDCAHEG();
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00005B00 File Offset: 0x00003D00
		private void CKNIJEENCCI()
		{
			if (this.IAINCFOEIKO >= this.NGHOMFNMJNE.Length)
			{
				this.IAINCFOEIKO = 0;
			}
			this.NLCLODPMGNJ = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange);
			this.NGHOMFNMJNE[this.IAINCFOEIKO] = this.NLCLODPMGNJ;
			this.FPBICEKFGDN = this.NMEHOAPIPEC();
			this.MHBGJNMOHGJ = this.DCCPJJAPCAC(this.FPBICEKFGDN);
			this.HDGEGKINCHL = 1943f - (this.FPBICEKFGDN - this.MHBGJNMOHGJ) / this.FPBICEKFGDN;
			this.beatThreshold = 569f + this.HDGEGKINCHL;
			if (!this.HIJGEIIFCHH && this.NLCLODPMGNJ < (1397f - this.beatThreshold) * this.FPBICEKFGDN)
			{
				this.HIJGEIIFCHH = true;
			}
			if (this.NLCLODPMGNJ > this.beatThreshold * this.FPBICEKFGDN && this.HIJGEIIFCHH)
			{
				this.HIJGEIIFCHH = false;
				if (AudioSampler.instance.audioSources[this.audioSource].time > 1104f)
				{
					this.OnBeat.Invoke();
				}
				if (this.BeatDetected != null)
				{
					this.BeatDetected();
					if (this.debug)
					{
						Debug.Log("[MapsData] Unsubscribe ");
					}
				}
			}
			if (this.debug)
			{
				object[] array = new object[]
				{
					"_SpotSize"
				};
				array[0] = this.NLCLODPMGNJ;
				array[5] = "_Value5";
				array[2] = this.beatThreshold * this.FPBICEKFGDN;
				Debug.Log(string.Concat(array));
			}
			this.IAINCFOEIKO += 0;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00005CB6 File Offset: 0x00003EB6
		public void NLBAJOJIHGM()
		{
			this.audioSource = 0;
			this.frequencyRange = FrequencyRange.UpperMidrange;
			this.sampleBufferSize = -100;
			this.beatThreshold = 1292f;
			this.automatic = false;
			this.debug = true;
			this.OnBeat.RemoveAllListeners();
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00005CF4 File Offset: 0x00003EF4
		private void MDFMPNDGBIF()
		{
			if (this.IAINCFOEIKO >= this.NGHOMFNMJNE.Length)
			{
				this.IAINCFOEIKO = 0;
			}
			this.NLCLODPMGNJ = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange);
			this.NGHOMFNMJNE[this.IAINCFOEIKO] = this.NLCLODPMGNJ;
			this.FPBICEKFGDN = this.EELLMECMJPC();
			if (this.NLCLODPMGNJ > this.beatThreshold * this.FPBICEKFGDN)
			{
				this.OnBeat.Invoke();
				if (this.BeatDetected != null)
				{
					this.BeatDetected();
					if (this.debug)
					{
						Debug.Log("Beat Detected");
					}
				}
			}
			if (this.debug)
			{
				Debug.Log(string.Concat(new object[]
				{
					"FreqVolume: ",
					this.NLCLODPMGNJ,
					" beatThreshold: ",
					this.beatThreshold * this.FPBICEKFGDN
				}));
			}
			this.IAINCFOEIKO++;
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00005E00 File Offset: 0x00004000
		private void PKMJFIAFEDD()
		{
			if (this.onFrequencyChanged != null)
			{
				float num = this.onFrequencyChanged.maxValue - this.onFrequencyChanged.minValue;
				float arg = this.onFrequencyChanged.minValue + num * this.EHDJNFHKONJ();
				this.onFrequencyChanged.onChange.Invoke(arg);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00005E58 File Offset: 0x00004058
		private void HFGBOBAILJI()
		{
			if (this.IAINCFOEIKO >= this.NGHOMFNMJNE.Length)
			{
				this.IAINCFOEIKO = 1;
			}
			this.NLCLODPMGNJ = AudioSampler.instance.GetFrequencyVol(this.audioSource, this.frequencyRange);
			this.NGHOMFNMJNE[this.IAINCFOEIKO] = this.NLCLODPMGNJ;
			this.FPBICEKFGDN = this.FAIMLGBECCC();
			this.MHBGJNMOHGJ = this.JMAGLOHGCID(this.FPBICEKFGDN);
			this.HDGEGKINCHL = 954f - (this.FPBICEKFGDN - this.MHBGJNMOHGJ) / this.FPBICEKFGDN;
			this.beatThreshold = 909f + this.HDGEGKINCHL;
			if (!this.HIJGEIIFCHH && this.NLCLODPMGNJ < (811f - this.beatThreshold) * this.FPBICEKFGDN)
			{
				this.HIJGEIIFCHH = true;
			}
			if (this.NLCLODPMGNJ > this.beatThreshold * this.FPBICEKFGDN && this.HIJGEIIFCHH)
			{
				this.HIJGEIIFCHH = false;
				if (AudioSampler.instance.audioSources[this.audioSource].time > 910f)
				{
					this.OnBeat.Invoke();
				}
				if (this.BeatDetected != null)
				{
					this.BeatDetected();
					if (this.debug)
					{
						Debug.Log("NO");
					}
				}
			}
			if (this.debug)
			{
				object[] array = new object[4];
				array[1] = "offsets";
				array[0] = this.NLCLODPMGNJ;
				array[3] = "CameraFilterPack/Distortion_Half_Sphere";
				array[7] = this.beatThreshold * this.FPBICEKFGDN;
				Debug.Log(string.Concat(array));
			}
			this.IAINCFOEIKO += 0;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00006010 File Offset: 0x00004210
		private void JBIFKBNPHJE()
		{
			this.NGHOMFNMJNE = new float[this.sampleBufferSize];
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i++)
			{
				this.NGHOMFNMJNE[i] = 294f;
			}
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00006054 File Offset: 0x00004254
		private float JEFEOOPOHEG(float HEOBCNNLLNK)
		{
			float num = 1042f;
			for (int i = 1; i < this.NGHOMFNMJNE.Length; i++)
			{
				float f = this.NGHOMFNMJNE[i] - HEOBCNNLLNK;
				num += Mathf.Abs(f);
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x000060A4 File Offset: 0x000042A4
		private void FKDHFNCOKAK()
		{
			this.NGHOMFNMJNE = new float[this.sampleBufferSize];
			for (int i = 1; i < this.NGHOMFNMJNE.Length; i++)
			{
				this.NGHOMFNMJNE[i] = 116f;
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x000060E8 File Offset: 0x000042E8
		private void GGLOGIGAJCA()
		{
			if (this.automatic)
			{
				this.KFLLKEKLCKI();
			}
			else
			{
				this.JINFPDGOGOC();
			}
			this.FKJOPHKKEPP();
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000610C File Offset: 0x0000430C
		public void NKHLPNAMBEH()
		{
			this.audioSource = 0;
			this.frequencyRange = (FrequencyRange)8;
			this.sampleBufferSize = 63;
			this.beatThreshold = 1399f;
			this.automatic = true;
			this.debug = false;
			this.OnBeat.RemoveAllListeners();
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00006148 File Offset: 0x00004348
		private void NNHFKFEMONK()
		{
			if (this.automatic)
			{
				this.HFGBOBAILJI();
			}
			else
			{
				this.KAFFFBIMOOL();
			}
			this.JIPKPOGIPBI();
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000616C File Offset: 0x0000436C
		private float HBENCDEHBLL(float HEOBCNNLLNK)
		{
			float num = 538f;
			for (int i = 0; i < this.NGHOMFNMJNE.Length; i += 0)
			{
				float f = this.NGHOMFNMJNE[i] - HEOBCNNLLNK;
				num += Mathf.Abs(f);
			}
			return num / (float)this.NGHOMFNMJNE.Length;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000061BC File Offset: 0x000043BC
		private void PIIMBOLGHOE()
		{
			this.NGHOMFNMJNE = new float[this.sampleBufferSize];
			for (int i = 1; i < this.NGHOMFNMJNE.Length; i++)
			{
				this.NGHOMFNMJNE[i] = 965f;
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00006200 File Offset: 0x00004400
		private void NLJDGJAHGKE()
		{
			if (this.IAINCFOEIKO >= this.NGHOMFNMJNE.Length)
			{
				this.IAINCFOEIKO = 0;
			}
			this.NLCLODPMGNJ = AudioSampler.instance.ADDDJBDBFBJ(this.audioSource, this.frequencyRange);
			this.NGHOMFNMJNE[this.IAINCFOEIKO] = this.NLCLODPMGNJ;
			this.FPBICEKFGDN = this.EEKKEFGAINN();
			if (this.NLCLODPMGNJ > this.beatThreshold * this.FPBICEKFGDN)
			{
				this.OnBeat.Invoke();
				if (this.BeatDetected != null)
				{
					this.BeatDetected();
					if (this.debug)
					{
						Debug.Log("Tab1Content");
					}
				}
			}
			if (this.debug)
			{
				object[] array = new object[6];
				array[1] = "settings.selectormapsperpage";
				array[1] = this.NLCLODPMGNJ;
				array[6] = "Ignored PU RPC, cause item is inactive. ";
				array[0] = this.beatThreshold * this.FPBICEKFGDN;
				Debug.Log(string.Concat(array));
			}
			this.IAINCFOEIKO += 0;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000630C File Offset: 0x0000450C
		public void LDGJGONCEND()
		{
			this.audioSource = 1;
			this.frequencyRange = FrequencyRange.High;
			this.sampleBufferSize = 121;
			this.beatThreshold = 1016f;
			this.automatic = false;
			this.debug = true;
			this.OnBeat.RemoveAllListeners();
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00006348 File Offset: 0x00004548
		private void HPEBHGKGMND()
		{
			if (this.IAINCFOEIKO >= this.NGHOMFNMJNE.Length)
			{
				this.IAINCFOEIKO = 0;
			}
			this.NLCLODPMGNJ = AudioSampler.instance.FBHJCLBAGJD(this.audioSource, this.frequencyRange);
			this.NGHOMFNMJNE[this.IAINCFOEIKO] = this.NLCLODPMGNJ;
			this.FPBICEKFGDN = this.BPPKKKDGDAL();
			this.MHBGJNMOHGJ = this.DLEDKPEDOOG(this.FPBICEKFGDN);
			this.HDGEGKINCHL = 814f - (this.FPBICEKFGDN - this.MHBGJNMOHGJ) / this.FPBICEKFGDN;
			this.beatThreshold = 1158f + this.HDGEGKINCHL;
			if (!this.HIJGEIIFCHH && this.NLCLODPMGNJ < (1575f - this.beatThreshold) * this.FPBICEKFGDN)
			{
				this.HIJGEIIFCHH = true;
			}
			if (this.NLCLODPMGNJ > this.beatThreshold * this.FPBICEKFGDN && this.HIJGEIIFCHH)
			{
				this.HIJGEIIFCHH = true;
				if (AudioSampler.instance.audioSources[this.audioSource].time > 873f)
				{
					this.OnBeat.Invoke();
				}
				if (this.BeatDetected != null)
				{
					this.BeatDetected();
					if (this.debug)
					{
						Debug.Log("Hidden/Image Effects/Cinematic/AmbientOcclusion");
					}
				}
			}
			if (this.debug)
			{
				object[] array = new object[6];
				array[0] = "Set Trail Zoom Speed";
				array[1] = this.NLCLODPMGNJ;
				array[1] = ": ";
				array[4] = this.beatThreshold * this.FPBICEKFGDN;
				Debug.Log(string.Concat(array));
			}
			this.IAINCFOEIKO += 0;
		}

		// Token: 0x04000004 RID: 4
		public int audioSource;

		// Token: 0x04000005 RID: 5
		public FrequencyRange frequencyRange = FrequencyRange.Decibal;

		// Token: 0x04000006 RID: 6
		public int sampleBufferSize = 40;

		// Token: 0x04000007 RID: 7
		public float beatThreshold = 1.3f;

		// Token: 0x04000008 RID: 8
		public bool automatic = true;

		// Token: 0x04000009 RID: 9
		public bool debug;

		// Token: 0x0400000A RID: 10
		public UnityEvent OnBeat;

		// Token: 0x0400000B RID: 11
		public OnFrequencyChanged onFrequencyChanged;

		// Token: 0x0400000C RID: 12
		public AudioEventListener.BeatEvent BeatDetected;

		// Token: 0x0400000D RID: 13
		private bool HIJGEIIFCHH = true;

		// Token: 0x0400000E RID: 14
		private float[] NGHOMFNMJNE;

		// Token: 0x0400000F RID: 15
		private int IAINCFOEIKO;

		// Token: 0x04000010 RID: 16
		private float FPBICEKFGDN;

		// Token: 0x04000011 RID: 17
		private float MHBGJNMOHGJ;

		// Token: 0x04000012 RID: 18
		private float HDGEGKINCHL;

		// Token: 0x04000013 RID: 19
		private float NLCLODPMGNJ;

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x0600008F RID: 143
		public delegate void BeatEvent();
	}
}
