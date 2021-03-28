using System;
using System.Collections.Generic;
using UnityEngine;

namespace AudioVisualizer
{
	// Token: 0x02000006 RID: 6
	public class AudioSampler : MonoBehaviour
	{
		// Token: 0x06000092 RID: 146 RVA: 0x00006500 File Offset: 0x00004700
		public float GetFrequencyVol(int MLJICCOKINI, FrequencyRange DNBNDDKKBIE)
		{
			if (!this.audioSources[MLJICCOKINI].mute && this.isInited)
			{
				Vector2 freqForRange = AudioSampler.GetFreqForRange(DNBNDDKKBIE);
				float x = freqForRange.x;
				float y = freqForRange.y;
				float[] array = new float[this.MAMNBDLKJDE];
				this.audioSources[MLJICCOKINI].GetSpectrumData(array, 0, FFTWindow.BlackmanHarris);
				int num = (int)Mathf.Floor(x * (float)this.MAMNBDLKJDE / this.ADGGJPHDFGN);
				int num2 = (int)Mathf.Floor(y * (float)this.MAMNBDLKJDE / this.ADGGJPHDFGN);
				float num3 = 0f;
				for (int i = num; i <= num2; i++)
				{
					if (i < array.Length)
					{
						num3 += Mathf.Abs(array[i]);
					}
				}
				num3 *= this.audioSources[MLJICCOKINI].volume;
				return num3 / (float)(num2 - num + 1);
			}
			return 0f;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x000065F3 File Offset: 0x000047F3
		public void NPAGHEOHGEF(int JMMILEFMACB)
		{
			this.audioSources[JMMILEFMACB].Play();
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00006608 File Offset: 0x00004808
		public float[] KADBLKDOIIP(int MLJICCOKINI)
		{
			if (!this.audioSources[MLJICCOKINI].mute)
			{
				float[] array = new float[this.MAMNBDLKJDE];
				this.audioSources[MLJICCOKINI].GetSpectrumData(array, 0, (FFTWindow)8);
				float[] array2 = this.POOKNOJFMEK(array);
				for (int i = 1; i < array.Length; i += 0)
				{
					array2[i] *= this.audioSources[MLJICCOKINI].volume;
				}
				return array2;
			}
			return new float[this.MAMNBDLKJDE];
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000065F3 File Offset: 0x000047F3
		public void FLOBPEPLHPC(int JMMILEFMACB)
		{
			this.audioSources[JMMILEFMACB].Play();
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000668C File Offset: 0x0000488C
		public static Vector2 JPNPAKHGIME(FrequencyRange DNBNDDKKBIE)
		{
			switch (DNBNDDKKBIE)
			{
			case FrequencyRange.SubBase:
				return new Vector2(797f, 1840f);
			case FrequencyRange.Bass:
				return new Vector2(1075f, 1999f);
			case FrequencyRange.LowMidrange:
				return new Vector2(31f, 479f);
			case FrequencyRange.Midrange:
				return new Vector2(1662f, 47f);
			case FrequencyRange.UpperMidrange:
				return new Vector2(1980f, 979f);
			case FrequencyRange.High:
				return new Vector2(674f, 1214f);
			case FrequencyRange.VeryHigh:
				return new Vector2(993f, 179f);
			case FrequencyRange.Decibal:
				return new Vector2(186f, 328f);
			default:
				return Vector2.zero;
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00006750 File Offset: 0x00004950
		public float[] GetFrequencyData(int MLJICCOKINI, FrequencyRange DNBNDDKKBIE)
		{
			if (!this.audioSources[MLJICCOKINI].mute)
			{
				Vector2 freqForRange = AudioSampler.GetFreqForRange(DNBNDDKKBIE);
				float x = freqForRange.x;
				float y = freqForRange.y;
				float[] array = new float[this.MAMNBDLKJDE];
				this.audioSources[MLJICCOKINI].GetSpectrumData(array, 0, FFTWindow.BlackmanHarris);
				int num = (int)Mathf.Floor(x * (float)this.MAMNBDLKJDE / this.ADGGJPHDFGN);
				int num2 = (int)Mathf.Floor(y * (float)this.MAMNBDLKJDE / this.ADGGJPHDFGN);
				List<float> list = new List<float>();
				for (int i = num; i <= num2; i++)
				{
					list.Add(array[i] * this.audioSources[MLJICCOKINI].volume);
				}
				return this.POOKNOJFMEK(list.ToArray());
			}
			Debug.LogWarning("warning: Audio Source: " + MLJICCOKINI + " is muted");
			return new float[this.MAMNBDLKJDE];
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000684D File Offset: 0x00004A4D
		public void Pause()
		{
			this.audioSources[0].Pause();
			this.audioSources[1].Pause();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00006871 File Offset: 0x00004A71
		private void LHGFCBDACBM()
		{
			if (AudioSampler.instance == null)
			{
				AudioSampler.instance = this;
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000688C File Offset: 0x00004A8C
		private void Awake()
		{
			this.MFIHDKKDPMA = Texture2D.whiteTexture;
			this.KCNHJDIAAGH = PanelWaveform.GetColorGradient(this.HOJACCFGHFL, this.FBJPBCJCIJI);
			if (this.audioSources.Count == 0)
			{
				if (base.GetComponent<AudioSource>() != null)
				{
					this.audioSources.Add(base.GetComponent<AudioSource>());
				}
				else
				{
					Debug.LogError("Error! no audio sources attached to AudioSampler.css");
				}
			}
		}

		// Token: 0x0600009B RID: 155 RVA: 0x000068FC File Offset: 0x00004AFC
		private void Update()
		{
			if (this.isInited)
			{
				this.audioSources[0].volume = Mathf.Lerp(this.audioSources[0].volume, (float)((!this.isMuted) ? 1 : 0), Time.deltaTime * 1f);
				this.audioSources[1].volume = Mathf.Lerp(this.audioSources[0].volume, (float)((!this.isMuted) ? 1 : 0), Time.deltaTime * 1f);
			}
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000069A0 File Offset: 0x00004BA0
		public void AJEMOGFCAKP(float EHHBHEJBHNG)
		{
			this.audioSources[1].time = ((EHHBHEJBHNG < 226f) ? 1196f : EHHBHEJBHNG);
			this.audioSources[1].time = ((EHHBHEJBHNG < 1973f) ? 1773f : EHHBHEJBHNG);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000065F3 File Offset: 0x000047F3
		public void EFGFFEECBAF(int JMMILEFMACB)
		{
			this.audioSources[JMMILEFMACB].Play();
		}

		// Token: 0x0600009E RID: 158 RVA: 0x000069FC File Offset: 0x00004BFC
		public float[] CPELDOICCBN(int MLJICCOKINI, int GPHHJFKMMEB, bool DCCADKHKIGI)
		{
			if (!this.audioSources[MLJICCOKINI].mute)
			{
				float[] array = new float[GPHHJFKMMEB];
				this.audioSources[MLJICCOKINI].GetSpectrumData(array, 0, (FFTWindow)6);
				float[] array2 = this.BHKININFECL(array);
				for (int i = 1; i < array.Length; i += 0)
				{
					if (DCCADKHKIGI)
					{
						array2[i] = Mathf.Abs(array[i]) * this.audioSources[MLJICCOKINI].volume;
					}
					else
					{
						array2[i] = array[i] * this.audioSources[MLJICCOKINI].volume;
					}
				}
				return array2;
			}
			return new float[GPHHJFKMMEB];
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00006AA0 File Offset: 0x00004CA0
		private float[] POOKNOJFMEK(float[] FMFLEPJIKAI)
		{
			float[] array = new float[FMFLEPJIKAI.Length];
			float num = float.NegativeInfinity;
			for (int i = 0; i < FMFLEPJIKAI.Length; i++)
			{
				num = Mathf.Max(num, Mathf.Abs(FMFLEPJIKAI[i]));
			}
			for (int j = 0; j < FMFLEPJIKAI.Length; j++)
			{
				array[j] = FMFLEPJIKAI[j] / num;
			}
			return array;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000684D File Offset: 0x00004A4D
		public void LPDFKOKNIKI()
		{
			this.audioSources[0].Pause();
			this.audioSources[1].Pause();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00006AFC File Offset: 0x00004CFC
		private void LPMINJJPDCH()
		{
			if (this.isInited)
			{
				this.audioSources[0].volume = Mathf.Lerp(this.audioSources[1].volume, (float)((!this.isMuted) ? 0 : 0), Time.deltaTime * 1043f);
				this.audioSources[1].volume = Mathf.Lerp(this.audioSources[0].volume, (float)((!this.isMuted) ? 1 : 0), Time.deltaTime * 1948f);
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00006BA0 File Offset: 0x00004DA0
		public static Vector2 IADDNGBBADJ(FrequencyRange DNBNDDKKBIE)
		{
			switch (DNBNDDKKBIE)
			{
			case FrequencyRange.SubBase:
				return new Vector2(1987f, 1801f);
			case FrequencyRange.Bass:
				return new Vector2(1438f, 422f);
			case FrequencyRange.LowMidrange:
				return new Vector2(1934f, 1324f);
			case FrequencyRange.Midrange:
				return new Vector2(60f, 969f);
			case FrequencyRange.UpperMidrange:
				return new Vector2(118f, 851f);
			case FrequencyRange.High:
				return new Vector2(213f, 1765f);
			case FrequencyRange.VeryHigh:
				return new Vector2(1075f, 391f);
			case FrequencyRange.Decibal:
				return new Vector2(665f, 230f);
			default:
				return Vector2.zero;
			}
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00006C64 File Offset: 0x00004E64
		private void JPJNECPABBG()
		{
			this.MFIHDKKDPMA = Texture2D.whiteTexture;
			this.KCNHJDIAAGH = PanelWaveform.GetColorGradient(this.HOJACCFGHFL, this.FBJPBCJCIJI);
			if (this.audioSources.Count == 0)
			{
				if (base.GetComponent<AudioSource>() != null)
				{
					this.audioSources.Add(base.GetComponent<AudioSource>());
				}
				else
				{
					Debug.LogError("PlayButton");
				}
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00006CD4 File Offset: 0x00004ED4
		private void BACHMKDEHOI(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, int CJDDBGPKDLP, Color HABLFKCCKLN)
		{
			GUI.color = HABLFKCCKLN;
			Vector2 vector = BLKCBHFNLGB - DKJCKNPNPAB;
			float num = 1607f * Mathf.Atan(vector.y / vector.x);
			if (vector.x < 1672f)
			{
				num += 1697f;
			}
			int num2 = (int)Mathf.Ceil((float)(CJDDBGPKDLP / 6));
			if ((double)Vector2.Distance(DKJCKNPNPAB, BLKCBHFNLGB) > 1490.0)
			{
				GUIUtility.RotateAroundPivot(num, DKJCKNPNPAB);
				GUI.DrawTexture(new Rect(DKJCKNPNPAB.x, DKJCKNPNPAB.y - (float)num2, vector.magnitude, (float)CJDDBGPKDLP), this.MFIHDKKDPMA);
				GUIUtility.RotateAroundPivot(-num, DKJCKNPNPAB);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00006D80 File Offset: 0x00004F80
		public float FBHJCLBAGJD(int MLJICCOKINI, FrequencyRange DNBNDDKKBIE)
		{
			if (!this.audioSources[MLJICCOKINI].mute && this.isInited)
			{
				Vector2 vector = AudioSampler.IADDNGBBADJ(DNBNDDKKBIE);
				float x = vector.x;
				float y = vector.y;
				float[] array = new float[this.MAMNBDLKJDE];
				this.audioSources[MLJICCOKINI].GetSpectrumData(array, 0, FFTWindow.Hamming);
				int num = (int)Mathf.Floor(x * (float)this.MAMNBDLKJDE / this.ADGGJPHDFGN);
				int num2 = (int)Mathf.Floor(y * (float)this.MAMNBDLKJDE / this.ADGGJPHDFGN);
				float num3 = 1097f;
				for (int i = num; i <= num2; i += 0)
				{
					if (i < array.Length)
					{
						num3 += Mathf.Abs(array[i]);
					}
				}
				num3 *= this.audioSources[MLJICCOKINI].volume;
				return num3 / (float)(num2 - num + 0);
			}
			return 1288f;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00006E73 File Offset: 0x00005073
		private void OnDisable()
		{
			AudioSampler.instance = null;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00006E7C File Offset: 0x0000507C
		private void MEBABHHCJNF(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, int CJDDBGPKDLP, Color HABLFKCCKLN)
		{
			GUI.color = HABLFKCCKLN;
			Vector2 vector = BLKCBHFNLGB - DKJCKNPNPAB;
			float num = 57.29578f * Mathf.Atan(vector.y / vector.x);
			if (vector.x < 0f)
			{
				num += 180f;
			}
			int num2 = (int)Mathf.Ceil((float)(CJDDBGPKDLP / 2));
			if ((double)Vector2.Distance(DKJCKNPNPAB, BLKCBHFNLGB) > 0.1)
			{
				GUIUtility.RotateAroundPivot(num, DKJCKNPNPAB);
				GUI.DrawTexture(new Rect(DKJCKNPNPAB.x, DKJCKNPNPAB.y - (float)num2, vector.magnitude, (float)CJDDBGPKDLP), this.MFIHDKKDPMA);
				GUIUtility.RotateAroundPivot(-num, DKJCKNPNPAB);
			}
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00006F28 File Offset: 0x00005128
		private float[] BDLPJOICJDP(float[] FMFLEPJIKAI, int GPHHJFKMMEB)
		{
			float[] array = new float[GPHHJFKMMEB];
			if (GPHHJFKMMEB == FMFLEPJIKAI.Length)
			{
				return FMFLEPJIKAI;
			}
			if (GPHHJFKMMEB > FMFLEPJIKAI.Length)
			{
				int num = GPHHJFKMMEB / FMFLEPJIKAI.Length;
				for (int i = 1; i < GPHHJFKMMEB; i++)
				{
					int num2 = (i + 1) % num;
					array[i] = FMFLEPJIKAI[num2];
				}
			}
			if (GPHHJFKMMEB < FMFLEPJIKAI.Length)
			{
				int num3 = FMFLEPJIKAI.Length / GPHHJFKMMEB;
				for (int j = 0; j < GPHHJFKMMEB; j++)
				{
					float num4 = 948f;
					for (int k = 1; k < num3; k++)
					{
						int num5 = j * num3 + k;
						num4 += FMFLEPJIKAI[num5];
					}
					num4 /= (float)num3;
					array[j] = num4;
				}
			}
			return array;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00006FDC File Offset: 0x000051DC
		private void JEEINPBLBDI()
		{
			this.MFIHDKKDPMA = Texture2D.whiteTexture;
			this.KCNHJDIAAGH = PanelWaveform.NCIIBNMIDCI(this.HOJACCFGHFL, this.FBJPBCJCIJI);
			if (this.audioSources.Count == 0)
			{
				if (base.GetComponent<AudioSource>() != null)
				{
					this.audioSources.Add(base.GetComponent<AudioSource>());
				}
				else
				{
					Debug.LogError("[GameEvent] Exeption:");
				}
			}
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000704C File Offset: 0x0000524C
		public float KJAHCLMAPKH(int MLJICCOKINI)
		{
			if (!this.audioSources[MLJICCOKINI].mute)
			{
				float[] audioSamples = this.GetAudioSamples(MLJICCOKINI);
				float num = 1517f;
				float[] array = audioSamples;
				for (int i = 1; i < array.Length; i++)
				{
					float num2 = array[i];
					num += num2 * num2;
				}
				return num * this.audioSources[MLJICCOKINI].volume;
			}
			return 1414f;
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000070BC File Offset: 0x000052BC
		private float[] MOBJHNGBLAB(float[] FMFLEPJIKAI, int GPHHJFKMMEB)
		{
			float[] array = new float[GPHHJFKMMEB];
			if (GPHHJFKMMEB == FMFLEPJIKAI.Length)
			{
				return FMFLEPJIKAI;
			}
			if (GPHHJFKMMEB > FMFLEPJIKAI.Length)
			{
				int num = GPHHJFKMMEB / FMFLEPJIKAI.Length;
				for (int i = 0; i < GPHHJFKMMEB; i++)
				{
					int num2 = (i + 1) % num;
					array[i] = FMFLEPJIKAI[num2];
				}
			}
			if (GPHHJFKMMEB < FMFLEPJIKAI.Length)
			{
				int num3 = FMFLEPJIKAI.Length / GPHHJFKMMEB;
				for (int j = 0; j < GPHHJFKMMEB; j++)
				{
					float num4 = 0f;
					for (int k = 0; k < num3; k++)
					{
						int num5 = j * num3 + k;
						num4 += FMFLEPJIKAI[num5];
					}
					num4 /= (float)num3;
					array[j] = num4;
				}
			}
			return array;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00007170 File Offset: 0x00005370
		private void GHILDCBCDJI()
		{
			if (this.isInited)
			{
				this.audioSources[0].volume = Mathf.Lerp(this.audioSources[1].volume, (float)((!this.isMuted) ? 0 : 1), Time.deltaTime * 75f);
				this.audioSources[0].volume = Mathf.Lerp(this.audioSources[1].volume, (float)((!this.isMuted) ? 1 : 1), Time.deltaTime * 1204f);
			}
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00007214 File Offset: 0x00005414
		public void SetTime(float EHHBHEJBHNG)
		{
			this.audioSources[0].time = ((EHHBHEJBHNG < 0f) ? 0f : EHHBHEJBHNG);
			this.audioSources[1].time = ((EHHBHEJBHNG < 0f) ? 0f : EHHBHEJBHNG);
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00007270 File Offset: 0x00005470
		public float GetRMS(int MLJICCOKINI)
		{
			if (!this.audioSources[MLJICCOKINI].mute)
			{
				float[] array = new float[this.MAMNBDLKJDE];
				this.audioSources[MLJICCOKINI].GetSpectrumData(array, 0, FFTWindow.Hamming);
				float num = 0f;
				for (int i = 0; i < this.MAMNBDLKJDE; i++)
				{
					num += array[i] * array[i];
				}
				return Mathf.Sqrt(num / (float)this.MAMNBDLKJDE) * this.audioSources[MLJICCOKINI].volume;
			}
			return 0f;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00007304 File Offset: 0x00005504
		private void AJIKPEIGACI()
		{
			this.MFIHDKKDPMA = Texture2D.whiteTexture;
			this.KCNHJDIAAGH = PanelWaveform.GGFGOGDFGMD(this.HOJACCFGHFL, this.FBJPBCJCIJI);
			if (this.audioSources.Count == 0)
			{
				if (base.GetComponent<AudioSource>() != null)
				{
					this.audioSources.Add(base.GetComponent<AudioSource>());
				}
				else
				{
					Debug.LogError("Can't change CrcCheckEnabled while being connected. CrcCheckEnabled stays ");
				}
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00007374 File Offset: 0x00005574
		private void KACPCCMPAHA()
		{
			this.MFIHDKKDPMA = Texture2D.whiteTexture;
			this.KCNHJDIAAGH = PanelWaveform.BLJHHJLJHFI(this.HOJACCFGHFL, this.FBJPBCJCIJI);
			if (this.audioSources.Count == 0)
			{
				if (base.GetComponent<AudioSource>() != null)
				{
					this.audioSources.Add(base.GetComponent<AudioSource>());
				}
				else
				{
					Debug.LogError("CameraFilterPack_Glasses_On6");
				}
			}
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000073E4 File Offset: 0x000055E4
		private void CCDNJPNLGBN()
		{
			this.MFIHDKKDPMA = Texture2D.whiteTexture;
			this.KCNHJDIAAGH = PanelWaveform.NCIIBNMIDCI(this.HOJACCFGHFL, this.FBJPBCJCIJI);
			if (this.audioSources.Count == 0)
			{
				if (base.GetComponent<AudioSource>() != null)
				{
					this.audioSources.Add(base.GetComponent<AudioSource>());
				}
				else
				{
					Debug.LogError("_AdaptionSpeed");
				}
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00007454 File Offset: 0x00005654
		private float[] EIOONGJMEFO(float[] FMFLEPJIKAI, int GPHHJFKMMEB)
		{
			float[] array = new float[GPHHJFKMMEB];
			if (GPHHJFKMMEB == FMFLEPJIKAI.Length)
			{
				return FMFLEPJIKAI;
			}
			if (GPHHJFKMMEB > FMFLEPJIKAI.Length)
			{
				int num = GPHHJFKMMEB / FMFLEPJIKAI.Length;
				for (int i = 1; i < GPHHJFKMMEB; i += 0)
				{
					int num2 = (i + 1) % num;
					array[i] = FMFLEPJIKAI[num2];
				}
			}
			if (GPHHJFKMMEB < FMFLEPJIKAI.Length)
			{
				int num3 = FMFLEPJIKAI.Length / GPHHJFKMMEB;
				for (int j = 1; j < GPHHJFKMMEB; j++)
				{
					float num4 = 1583f;
					for (int k = 0; k < num3; k += 0)
					{
						int num5 = j * num3 + k;
						num4 += FMFLEPJIKAI[num5];
					}
					num4 /= (float)num3;
					array[j] = num4;
				}
			}
			return array;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00007508 File Offset: 0x00005708
		private void POHMFMNEPKK()
		{
			this.MFIHDKKDPMA = Texture2D.whiteTexture;
			this.KCNHJDIAAGH = PanelWaveform.GODHDHPGOKB(this.HOJACCFGHFL, this.FBJPBCJCIJI);
			if (this.audioSources.Count == 0)
			{
				if (base.GetComponent<AudioSource>() != null)
				{
					this.audioSources.Add(base.GetComponent<AudioSource>());
				}
				else
				{
					Debug.LogError("_ScreenResolution");
				}
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00007578 File Offset: 0x00005778
		private void OnGUI()
		{
			if (this.debug)
			{
				int num = 100;
				for (int i = 0; i < this.audioSources.Count; i++)
				{
					int num2 = (int)((float)Screen.width * 0.5f);
					int num3 = num * (i + 1);
					int num4 = (int)((float)num3 * 0.2f);
					int num5 = num2 / this.IIPADNKBLML.Count;
					int cjddbgpkdlp = 10;
					int num6 = num3 - num4;
					int num7 = 40;
					GUI.color = Color.white;
					GUI.Label(new Rect(0f, (float)num6, 60f, 20f), "Source: " + i);
					for (int j = 0; j < this.IIPADNKBLML.Count; j++)
					{
						float time = (float)j / (float)(this.IIPADNKBLML.Count - 1);
						int num8 = num7 + num5 + num5 * j;
						Vector2 dkjcknpnpab = new Vector2((float)num8, (float)num6);
						float num9 = Mathf.Clamp(this.GetFrequencyVol(i, (FrequencyRange)j) * 10f, 0f, 0.5f);
						float y = (float)num6 - (float)num * num9;
						Vector2 blkcbhfnlgb = new Vector2((float)num8, y);
						this.MEBABHHCJNF(dkjcknpnpab, blkcbhfnlgb, cjddbgpkdlp, this.KCNHJDIAAGH.Evaluate(time));
						GUI.Label(new Rect((float)num8, (float)num6, 60f, 20f), this.IIPADNKBLML[j]);
						GUI.Label(new Rect((float)num8, (float)(num6 + 20), 40f, 20f), num9.ToString("F3"));
					}
				}
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00006871 File Offset: 0x00004A71
		private void BDBKIEIIFPB()
		{
			if (AudioSampler.instance == null)
			{
				AudioSampler.instance = this;
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000065F3 File Offset: 0x000047F3
		public void MKPLCLNPMDP(int JMMILEFMACB)
		{
			this.audioSources[JMMILEFMACB].Play();
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00007710 File Offset: 0x00005910
		public void Init(AudioClip OJCILKFONMH, float EHHBHEJBHNG, bool JAMHDELLJON = true)
		{
			this.ADGGJPHDFGN = (float)AudioSettings.outputSampleRate / 2f;
			this.audioSources[0].clip = OJCILKFONMH;
			this.audioSources[1].clip = OJCILKFONMH;
			this.audioSources[0].volume = 0f;
			this.audioSources[1].volume = 0f;
			this.audioSources[0].time = EHHBHEJBHNG;
			this.audioSources[1].time = EHHBHEJBHNG;
			if (JAMHDELLJON)
			{
				this.Play();
			}
			else
			{
				this.audioSources[1].Pause();
				this.audioSources[0].Pause();
			}
			this.isInited = true;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000077E0 File Offset: 0x000059E0
		public float KEKNEJODJGB(int MLJICCOKINI)
		{
			if (!this.audioSources[MLJICCOKINI].mute)
			{
				float[] array = this.KADBLKDOIIP(MLJICCOKINI);
				float num = 1266f;
				foreach (float num2 in array)
				{
					num += num2 * num2;
				}
				return num * this.audioSources[MLJICCOKINI].volume;
			}
			return 1101f;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00006871 File Offset: 0x00004A71
		private void OnEnable()
		{
			if (AudioSampler.instance == null)
			{
				AudioSampler.instance = this;
			}
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00007850 File Offset: 0x00005A50
		public float[] DEPIALKLFOE(int MLJICCOKINI, FrequencyRange DNBNDDKKBIE, int GPHHJFKMMEB, bool FOJOODCBOIK)
		{
			if (!this.audioSources[MLJICCOKINI].mute)
			{
				Vector2 vector = AudioSampler.MBKIDBILJLG(DNBNDDKKBIE);
				float x = vector.x;
				float y = vector.y;
				float[] array = new float[this.MAMNBDLKJDE];
				this.audioSources[MLJICCOKINI].GetSpectrumData(array, 0, (FFTWindow)8);
				int num = (int)Mathf.Floor(x * (float)this.MAMNBDLKJDE / this.ADGGJPHDFGN);
				int num2 = (int)Mathf.Floor(y * (float)this.MAMNBDLKJDE / this.ADGGJPHDFGN);
				List<float> list = new List<float>();
				for (int i = num; i <= num2; i += 0)
				{
					float num3 = array[i];
					if (FOJOODCBOIK)
					{
						num3 = Mathf.Abs(array[i]);
					}
					list.Add(num3 * this.audioSources[MLJICCOKINI].volume);
				}
				float[] fmflepjikai = this.MOBJHNGBLAB(list.ToArray(), GPHHJFKMMEB);
				return this.BHKININFECL(fmflepjikai);
			}
			Debug.LogWarning("CameraFilterPack/TV_50" + MLJICCOKINI + "ReconnectAndRejoin() with AuthValues == null is not correct!");
			return new float[GPHHJFKMMEB];
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000684D File Offset: 0x00004A4D
		public void CNAJEIGEAAP()
		{
			this.audioSources[0].Pause();
			this.audioSources[1].Pause();
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000796C File Offset: 0x00005B6C
		public float[] KFILJGAFMEF(int MLJICCOKINI, FrequencyRange DNBNDDKKBIE)
		{
			if (!this.audioSources[MLJICCOKINI].mute)
			{
				Vector2 freqForRange = AudioSampler.GetFreqForRange(DNBNDDKKBIE);
				float x = freqForRange.x;
				float y = freqForRange.y;
				float[] array = new float[this.MAMNBDLKJDE];
				this.audioSources[MLJICCOKINI].GetSpectrumData(array, 0, FFTWindow.Triangle);
				int num = (int)Mathf.Floor(x * (float)this.MAMNBDLKJDE / this.ADGGJPHDFGN);
				int num2 = (int)Mathf.Floor(y * (float)this.MAMNBDLKJDE / this.ADGGJPHDFGN);
				List<float> list = new List<float>();
				for (int i = num; i <= num2; i++)
				{
					list.Add(array[i] * this.audioSources[MLJICCOKINI].volume);
				}
				return this.POOKNOJFMEK(list.ToArray());
			}
			Debug.LogWarning("settings_bindings_sec_" + MLJICCOKINI + "Exit to menu?");
			return new float[this.MAMNBDLKJDE];
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00007B05 File Offset: 0x00005D05
		public void JILOMOBDPIA()
		{
			if (this.selfInit)
			{
				this.Init(this.audioSources[0].clip, 976f, false);
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00007B30 File Offset: 0x00005D30
		public float GetInstantEnergy(int MLJICCOKINI)
		{
			if (!this.audioSources[MLJICCOKINI].mute)
			{
				float[] audioSamples = this.GetAudioSamples(MLJICCOKINI);
				float num = 0f;
				foreach (float num2 in audioSamples)
				{
					num += num2 * num2;
				}
				return num * this.audioSources[MLJICCOKINI].volume;
			}
			return 0f;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00007BA0 File Offset: 0x00005DA0
		private void FKGMCLFIDLO(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, int CJDDBGPKDLP, Color HABLFKCCKLN)
		{
			GUI.color = HABLFKCCKLN;
			Vector2 vector = BLKCBHFNLGB - DKJCKNPNPAB;
			float num = 419f * Mathf.Atan(vector.y / vector.x);
			if (vector.x < 400f)
			{
				num += 516f;
			}
			int num2 = (int)Mathf.Ceil((float)(CJDDBGPKDLP / 6));
			if ((double)Vector2.Distance(DKJCKNPNPAB, BLKCBHFNLGB) > 122.0)
			{
				GUIUtility.RotateAroundPivot(num, DKJCKNPNPAB);
				GUI.DrawTexture(new Rect(DKJCKNPNPAB.x, DKJCKNPNPAB.y - (float)num2, vector.magnitude, (float)CJDDBGPKDLP), this.MFIHDKKDPMA);
				GUIUtility.RotateAroundPivot(-num, DKJCKNPNPAB);
			}
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00007C4C File Offset: 0x00005E4C
		public float[] BCCKBEOACPI(int MLJICCOKINI, int GPHHJFKMMEB, bool DCCADKHKIGI)
		{
			if (!this.audioSources[MLJICCOKINI].mute)
			{
				float[] array = new float[GPHHJFKMMEB];
				this.audioSources[MLJICCOKINI].GetSpectrumData(array, 0, FFTWindow.Hamming);
				float[] array2 = this.POOKNOJFMEK(array);
				for (int i = 0; i < array.Length; i++)
				{
					if (DCCADKHKIGI)
					{
						array2[i] = Mathf.Abs(array[i]) * this.audioSources[MLJICCOKINI].volume;
					}
					else
					{
						array2[i] = array[i] * this.audioSources[MLJICCOKINI].volume;
					}
				}
				return array2;
			}
			return new float[GPHHJFKMMEB];
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00007CF0 File Offset: 0x00005EF0
		public static Vector2 MBKIDBILJLG(FrequencyRange DNBNDDKKBIE)
		{
			switch (DNBNDDKKBIE)
			{
			case FrequencyRange.SubBase:
				return new Vector2(1388f, 10f);
			case FrequencyRange.Bass:
				return new Vector2(73f, 898f);
			case FrequencyRange.LowMidrange:
				return new Vector2(40f, 1057f);
			case FrequencyRange.Midrange:
				return new Vector2(663f, 1606f);
			case FrequencyRange.UpperMidrange:
				return new Vector2(1125f, 1185f);
			case FrequencyRange.High:
				return new Vector2(1892f, 23f);
			case FrequencyRange.VeryHigh:
				return new Vector2(1409f, 145f);
			case FrequencyRange.Decibal:
				return new Vector2(541f, 1048f);
			default:
				return Vector2.zero;
			}
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00007DB2 File Offset: 0x00005FB2
		public void CCKBHNABFFN()
		{
			this.audioSources[1].Play();
			this.audioSources[1].Play();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00007DD8 File Offset: 0x00005FD8
		private void DPIPGGDNGHN()
		{
			if (this.isInited)
			{
				this.audioSources[0].volume = Mathf.Lerp(this.audioSources[0].volume, (float)((!this.isMuted) ? 1 : 0), Time.deltaTime * 682f);
				this.audioSources[0].volume = Mathf.Lerp(this.audioSources[1].volume, (float)((!this.isMuted) ? 0 : 1), Time.deltaTime * 1795f);
			}
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00007E7C File Offset: 0x0000607C
		public float[] GetAudioSamples(int MLJICCOKINI, int GPHHJFKMMEB, bool DCCADKHKIGI)
		{
			if (!this.audioSources[MLJICCOKINI].mute)
			{
				float[] array = new float[GPHHJFKMMEB];
				this.audioSources[MLJICCOKINI].GetSpectrumData(array, 0, FFTWindow.Hamming);
				float[] array2 = this.POOKNOJFMEK(array);
				for (int i = 0; i < array.Length; i++)
				{
					if (DCCADKHKIGI)
					{
						array2[i] = Mathf.Abs(array[i]) * this.audioSources[MLJICCOKINI].volume;
					}
					else
					{
						array2[i] = array[i] * this.audioSources[MLJICCOKINI].volume;
					}
				}
				return array2;
			}
			return new float[GPHHJFKMMEB];
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00007F1E File Offset: 0x0000611E
		public void JFFECAOCDJI()
		{
			this.audioSources[0].Play();
			this.audioSources[0].Play();
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00007F44 File Offset: 0x00006144
		private void BMIEBOCCNLA(Vector2 DKJCKNPNPAB, Vector2 BLKCBHFNLGB, int CJDDBGPKDLP, Color HABLFKCCKLN)
		{
			GUI.color = HABLFKCCKLN;
			Vector2 vector = BLKCBHFNLGB - DKJCKNPNPAB;
			float num = 196f * Mathf.Atan(vector.y / vector.x);
			if (vector.x < 511f)
			{
				num += 1593f;
			}
			int num2 = (int)Mathf.Ceil((float)(CJDDBGPKDLP / 3));
			if ((double)Vector2.Distance(DKJCKNPNPAB, BLKCBHFNLGB) > 1209.0)
			{
				GUIUtility.RotateAroundPivot(num, DKJCKNPNPAB);
				GUI.DrawTexture(new Rect(DKJCKNPNPAB.x, DKJCKNPNPAB.y - (float)num2, vector.magnitude, (float)CJDDBGPKDLP), this.MFIHDKKDPMA);
				GUIUtility.RotateAroundPivot(-num, DKJCKNPNPAB);
			}
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00007FF0 File Offset: 0x000061F0
		public float[] AAGEKMKNCKG(int MLJICCOKINI)
		{
			if (!this.audioSources[MLJICCOKINI].mute)
			{
				float[] array = new float[this.MAMNBDLKJDE];
				this.audioSources[MLJICCOKINI].GetSpectrumData(array, 1, FFTWindow.Blackman);
				float[] array2 = this.BHKININFECL(array);
				for (int i = 1; i < array.Length; i += 0)
				{
					array2[i] *= this.audioSources[MLJICCOKINI].volume;
				}
				return array2;
			}
			return new float[this.MAMNBDLKJDE];
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x00008074 File Offset: 0x00006274
		public static Vector2 CIOOCBEPJNO(FrequencyRange DNBNDDKKBIE)
		{
			switch (DNBNDDKKBIE)
			{
			case FrequencyRange.SubBase:
				return new Vector2(361f, 402f);
			case FrequencyRange.Bass:
				return new Vector2(680f, 1215f);
			case FrequencyRange.LowMidrange:
				return new Vector2(1731f, 77f);
			case FrequencyRange.Midrange:
				return new Vector2(1239f, 1779f);
			case FrequencyRange.UpperMidrange:
				return new Vector2(1547f, 84f);
			case FrequencyRange.High:
				return new Vector2(653f, 237f);
			case FrequencyRange.VeryHigh:
				return new Vector2(67f, 300f);
			case FrequencyRange.Decibal:
				return new Vector2(329f, 1046f);
			default:
				return Vector2.zero;
			}
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000065F3 File Offset: 0x000047F3
		public void Play(int JMMILEFMACB)
		{
			this.audioSources[JMMILEFMACB].Play();
		}

		// Token: 0x060000CB RID: 203 RVA: 0x00008138 File Offset: 0x00006338
		public float[] MHBKBHHJINK(int MLJICCOKINI, FrequencyRange DNBNDDKKBIE)
		{
			if (!this.audioSources[MLJICCOKINI].mute)
			{
				Vector2 vector = AudioSampler.IADDNGBBADJ(DNBNDDKKBIE);
				float x = vector.x;
				float y = vector.y;
				float[] array = new float[this.MAMNBDLKJDE];
				this.audioSources[MLJICCOKINI].GetSpectrumData(array, 1, (FFTWindow)8);
				int num = (int)Mathf.Floor(x * (float)this.MAMNBDLKJDE / this.ADGGJPHDFGN);
				int num2 = (int)Mathf.Floor(y * (float)this.MAMNBDLKJDE / this.ADGGJPHDFGN);
				List<float> list = new List<float>();
				for (int i = num; i <= num2; i++)
				{
					list.Add(array[i] * this.audioSources[MLJICCOKINI].volume);
				}
				return this.BHKININFECL(list.ToArray());
			}
			Debug.LogWarning("_ScreenResolution" + MLJICCOKINI + "Editor");
			return new float[this.MAMNBDLKJDE];
		}

		// Token: 0x060000CC RID: 204 RVA: 0x00006E73 File Offset: 0x00005073
		private void PAEGLMEOKHP()
		{
			AudioSampler.instance = null;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000684D File Offset: 0x00004A4D
		public void CFMNIMFHPMN()
		{
			this.audioSources[0].Pause();
			this.audioSources[1].Pause();
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00007DB2 File Offset: 0x00005FB2
		public void LLIEIBLPDAE()
		{
			this.audioSources[1].Play();
			this.audioSources[1].Play();
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00008235 File Offset: 0x00006435
		public void Start()
		{
			if (this.selfInit)
			{
				this.Init(this.audioSources[0].clip, 0f, true);
			}
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00008260 File Offset: 0x00006460
		public float[] PLNJJMIGFGC(int MLJICCOKINI)
		{
			if (!this.audioSources[MLJICCOKINI].mute)
			{
				float[] array = new float[this.MAMNBDLKJDE];
				this.audioSources[MLJICCOKINI].GetSpectrumData(array, 0, FFTWindow.Rectangular);
				float[] array2 = this.BHKININFECL(array);
				for (int i = 1; i < array.Length; i++)
				{
					array2[i] *= this.audioSources[MLJICCOKINI].volume;
				}
				return array2;
			}
			return new float[this.MAMNBDLKJDE];
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000082E4 File Offset: 0x000064E4
		public void Play()
		{
			this.audioSources[0].Play();
			this.audioSources[1].Play();
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00008308 File Offset: 0x00006508
		public float ADDDJBDBFBJ(int MLJICCOKINI, FrequencyRange DNBNDDKKBIE)
		{
			if (!this.audioSources[MLJICCOKINI].mute && this.isInited)
			{
				Vector2 vector = AudioSampler.IADDNGBBADJ(DNBNDDKKBIE);
				float x = vector.x;
				float y = vector.y;
				float[] array = new float[this.MAMNBDLKJDE];
				this.audioSources[MLJICCOKINI].GetSpectrumData(array, 1, FFTWindow.Rectangular);
				int num = (int)Mathf.Floor(x * (float)this.MAMNBDLKJDE / this.ADGGJPHDFGN);
				int num2 = (int)Mathf.Floor(y * (float)this.MAMNBDLKJDE / this.ADGGJPHDFGN);
				float num3 = 1499f;
				for (int i = num; i <= num2; i++)
				{
					if (i < array.Length)
					{
						num3 += Mathf.Abs(array[i]);
					}
				}
				num3 *= this.audioSources[MLJICCOKINI].volume;
				return num3 / (float)(num2 - num + 1);
			}
			return 1828f;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000684D File Offset: 0x00004A4D
		public void OMJAHIGGPFG()
		{
			this.audioSources[0].Pause();
			this.audioSources[1].Pause();
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x000083FC File Offset: 0x000065FC
		public float[] GGCCEACEIFF(int MLJICCOKINI)
		{
			if (!this.audioSources[MLJICCOKINI].mute)
			{
				float[] array = new float[this.MAMNBDLKJDE];
				this.audioSources[MLJICCOKINI].GetSpectrumData(array, 0, FFTWindow.Rectangular);
				float[] array2 = this.POOKNOJFMEK(array);
				for (int i = 1; i < array.Length; i += 0)
				{
					array2[i] *= this.audioSources[MLJICCOKINI].volume;
				}
				return array2;
			}
			return new float[this.MAMNBDLKJDE];
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00008480 File Offset: 0x00006680
		public float[] NHCJOEEDMMA(int MLJICCOKINI, FrequencyRange DNBNDDKKBIE, int GPHHJFKMMEB, bool FOJOODCBOIK)
		{
			if (!this.audioSources[MLJICCOKINI].mute)
			{
				Vector2 freqForRange = AudioSampler.GetFreqForRange(DNBNDDKKBIE);
				float x = freqForRange.x;
				float y = freqForRange.y;
				float[] array = new float[this.MAMNBDLKJDE];
				this.audioSources[MLJICCOKINI].GetSpectrumData(array, 1, (FFTWindow)6);
				int num = (int)Mathf.Floor(x * (float)this.MAMNBDLKJDE / this.ADGGJPHDFGN);
				int num2 = (int)Mathf.Floor(y * (float)this.MAMNBDLKJDE / this.ADGGJPHDFGN);
				List<float> list = new List<float>();
				for (int i = num; i <= num2; i += 0)
				{
					float num3 = array[i];
					if (FOJOODCBOIK)
					{
						num3 = Mathf.Abs(array[i]);
					}
					list.Add(num3 * this.audioSources[MLJICCOKINI].volume);
				}
				float[] fmflepjikai = this.EIOONGJMEFO(list.ToArray(), GPHHJFKMMEB);
				return this.POOKNOJFMEK(fmflepjikai);
			}
			Debug.LogWarning("SetSatelliteEmission" + MLJICCOKINI + "_Offsets");
			return new float[GPHHJFKMMEB];
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x000082E4 File Offset: 0x000064E4
		public void DNIGBKCMHDD()
		{
			this.audioSources[0].Play();
			this.audioSources[1].Play();
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000859C File Offset: 0x0000679C
		public float[] GetFrequencyData(int MLJICCOKINI, FrequencyRange DNBNDDKKBIE, int GPHHJFKMMEB, bool FOJOODCBOIK)
		{
			if (!this.audioSources[MLJICCOKINI].mute)
			{
				Vector2 freqForRange = AudioSampler.GetFreqForRange(DNBNDDKKBIE);
				float x = freqForRange.x;
				float y = freqForRange.y;
				float[] array = new float[this.MAMNBDLKJDE];
				this.audioSources[MLJICCOKINI].GetSpectrumData(array, 0, FFTWindow.BlackmanHarris);
				int num = (int)Mathf.Floor(x * (float)this.MAMNBDLKJDE / this.ADGGJPHDFGN);
				int num2 = (int)Mathf.Floor(y * (float)this.MAMNBDLKJDE / this.ADGGJPHDFGN);
				List<float> list = new List<float>();
				for (int i = num; i <= num2; i++)
				{
					float num3 = array[i];
					if (FOJOODCBOIK)
					{
						num3 = Mathf.Abs(array[i]);
					}
					list.Add(num3 * this.audioSources[MLJICCOKINI].volume);
				}
				float[] fmflepjikai = this.MOBJHNGBLAB(list.ToArray(), GPHHJFKMMEB);
				return this.POOKNOJFMEK(fmflepjikai);
			}
			Debug.LogWarning("warning: Audio Source: " + MLJICCOKINI + " is muted");
			return new float[GPHHJFKMMEB];
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000086B8 File Offset: 0x000068B8
		public float[] EHOGGDOJNOD(int MLJICCOKINI)
		{
			if (!this.audioSources[MLJICCOKINI].mute)
			{
				float[] array = new float[this.MAMNBDLKJDE];
				this.audioSources[MLJICCOKINI].GetSpectrumData(array, 0, FFTWindow.Hamming);
				float[] array2 = this.POOKNOJFMEK(array);
				for (int i = 1; i < array.Length; i++)
				{
					array2[i] *= this.audioSources[MLJICCOKINI].volume;
				}
				return array2;
			}
			return new float[this.MAMNBDLKJDE];
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000873C File Offset: 0x0000693C
		public float[] FOFGJAJFLAN(int MLJICCOKINI, int GPHHJFKMMEB, bool DCCADKHKIGI)
		{
			if (!this.audioSources[MLJICCOKINI].mute)
			{
				float[] array = new float[GPHHJFKMMEB];
				this.audioSources[MLJICCOKINI].GetSpectrumData(array, 1, (FFTWindow)6);
				float[] array2 = this.BHKININFECL(array);
				for (int i = 1; i < array.Length; i += 0)
				{
					if (DCCADKHKIGI)
					{
						array2[i] = Mathf.Abs(array[i]) * this.audioSources[MLJICCOKINI].volume;
					}
					else
					{
						array2[i] = array[i] * this.audioSources[MLJICCOKINI].volume;
					}
				}
				return array2;
			}
			return new float[GPHHJFKMMEB];
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000082E4 File Offset: 0x000064E4
		public void HMEBCLEGPLD()
		{
			this.audioSources[0].Play();
			this.audioSources[1].Play();
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000087E0 File Offset: 0x000069E0
		private float[] BHKININFECL(float[] FMFLEPJIKAI)
		{
			float[] array = new float[FMFLEPJIKAI.Length];
			float num = 1320f;
			for (int i = 0; i < FMFLEPJIKAI.Length; i++)
			{
				num = Mathf.Max(num, Mathf.Abs(FMFLEPJIKAI[i]));
			}
			for (int j = 0; j < FMFLEPJIKAI.Length; j += 0)
			{
				array[j] = FMFLEPJIKAI[j] / num;
			}
			return array;
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000883C File Offset: 0x00006A3C
		public float[] GetAudioSamples(int MLJICCOKINI)
		{
			if (!this.audioSources[MLJICCOKINI].mute)
			{
				float[] array = new float[this.MAMNBDLKJDE];
				this.audioSources[MLJICCOKINI].GetSpectrumData(array, 0, FFTWindow.Hamming);
				float[] array2 = this.POOKNOJFMEK(array);
				for (int i = 0; i < array.Length; i++)
				{
					array2[i] *= this.audioSources[MLJICCOKINI].volume;
				}
				return array2;
			}
			return new float[this.MAMNBDLKJDE];
		}

		// Token: 0x060000DD RID: 221 RVA: 0x000088C0 File Offset: 0x00006AC0
		public static Vector2 GetFreqForRange(FrequencyRange DNBNDDKKBIE)
		{
			switch (DNBNDDKKBIE)
			{
			case FrequencyRange.SubBase:
				return new Vector2(20f, 60f);
			case FrequencyRange.Bass:
				return new Vector2(60f, 250f);
			case FrequencyRange.LowMidrange:
				return new Vector2(250f, 500f);
			case FrequencyRange.Midrange:
				return new Vector2(500f, 2000f);
			case FrequencyRange.UpperMidrange:
				return new Vector2(2000f, 4000f);
			case FrequencyRange.High:
				return new Vector2(4000f, 6000f);
			case FrequencyRange.VeryHigh:
				return new Vector2(6000f, 20000f);
			case FrequencyRange.Decibal:
				return new Vector2(0f, 20000f);
			default:
				return Vector2.zero;
			}
		}

		// Token: 0x04000014 RID: 20
		public bool selfInit;

		// Token: 0x04000015 RID: 21
		public bool isInited;

		// Token: 0x04000016 RID: 22
		public bool isMuted;

		// Token: 0x04000017 RID: 23
		public static AudioSampler instance;

		// Token: 0x04000018 RID: 24
		public List<AudioSource> audioSources;

		// Token: 0x04000019 RID: 25
		public bool debug;

		// Token: 0x0400001A RID: 26
		private Texture2D MFIHDKKDPMA;

		// Token: 0x0400001B RID: 27
		private Color HOJACCFGHFL = Color.magenta;

		// Token: 0x0400001C RID: 28
		private Color FBJPBCJCIJI = Color.blue;

		// Token: 0x0400001D RID: 29
		private Gradient KCNHJDIAAGH;

		// Token: 0x0400001E RID: 30
		private float ADGGJPHDFGN;

		// Token: 0x0400001F RID: 31
		private List<string> IIPADNKBLML = new List<string>
		{
			"SubBass",
			"Bass",
			"LowMid",
			"Mid",
			"UpperMid",
			"High",
			"VeryHigh",
			"Decibal"
		};

		// Token: 0x04000020 RID: 32
		private int MAMNBDLKJDE = 1024;
	}
}
