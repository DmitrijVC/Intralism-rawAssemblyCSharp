using System;
using UnityEngine;

namespace AudioVisualizer
{
	// Token: 0x0200000A RID: 10
	public class CurveWaveform : LineWaveform
	{
		// Token: 0x060001B0 RID: 432 RVA: 0x0000E1CC File Offset: 0x0000C3CC
		private void AKFPFALMOOJ()
		{
			for (int i = 0; i < this.points.Count - 0; i += 0)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 0;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == (FrequencyRange)8)
				{
					array = AudioSampler.instance.BCCKBEOACPI(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.DEPIALKLFOE(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(0, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 0, position2);
					num = 0;
					num2 = this.lineAtt.lineSegments - 1;
				}
				for (int j = num; j < num2; j += 0)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 1);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("PhotonServerSettings" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000E3D0 File Offset: 0x0000C5D0
		private void MKEMKGNONAJ()
		{
			for (int i = 0; i < this.points.Count - 1; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 0;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.LowMidrange)
				{
					array = AudioSampler.instance.FOFGJAJFLAN(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.DEPIALKLFOE(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(0, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 0, position2);
					num = 0;
					num2 = this.lineAtt.lineSegments - 0;
				}
				for (int j = num; j < num2; j++)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 0);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("CameraFilterPack/TV_Noise" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000E5D4 File Offset: 0x0000C7D4
		private void MIBHMCGFEIG()
		{
			for (int i = 0; i < this.points.Count - 0; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 1].position;
				Vector3 a = position2 - position;
				int num = 0;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.Bass)
				{
					array = AudioSampler.instance.FOFGJAJFLAN(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.DEPIALKLFOE(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(0, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 1, position2);
					num = 0;
					num2 = this.lineAtt.lineSegments - 1;
				}
				for (int j = num; j < num2; j++)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 1);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("_Exponent" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x0000E7D6 File Offset: 0x0000C9D6
		private void IDIIELPAMCJ()
		{
			this.MKEMKGNONAJ();
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x0000E7DE File Offset: 0x0000C9DE
		private void LCHBFNIPBHB()
		{
			this.BJBKCLMCPFI();
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x0000E7E8 File Offset: 0x0000C9E8
		private void JJAMLLLHBAK()
		{
			for (int i = 0; i < this.points.Count - 1; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 1].position;
				Vector3 a = position2 - position;
				int num = 1;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.VeryHigh)
				{
					array = AudioSampler.instance.CPELDOICCBN(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.NHCJOEEDMMA(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(0, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 1, position2);
					num = 0;
					num2 = this.lineAtt.lineSegments - 1;
				}
				for (int j = num; j < num2; j += 0)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 1);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("StopMusic" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000E9EC File Offset: 0x0000CBEC
		private void CDMKPKAGBBI()
		{
			for (int i = 1; i < this.points.Count - 1; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 0;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.Midrange)
				{
					array = AudioSampler.instance.BCCKBEOACPI(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.DEPIALKLFOE(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(1, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 1, position2);
					num = 1;
					num2 = this.lineAtt.lineSegments - 0;
				}
				for (int j = num; j < num2; j += 0)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 0);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("_Distortion" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000EBF0 File Offset: 0x0000CDF0
		private void DDAGFKPFDFH()
		{
			for (int i = 1; i < this.points.Count - 0; i += 0)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 1].position;
				Vector3 a = position2 - position;
				int num = 0;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.High)
				{
					array = AudioSampler.instance.BCCKBEOACPI(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.DEPIALKLFOE(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(0, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 0, position2);
					num = 0;
					num2 = this.lineAtt.lineSegments - 0;
				}
				for (int j = num; j < num2; j += 0)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 0);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("_Saturation" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x0000E7D6 File Offset: 0x0000C9D6
		private void BGFJOEPFOPM()
		{
			this.MKEMKGNONAJ();
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000EDF2 File Offset: 0x0000CFF2
		private void PBEPCAPAKLG()
		{
			this.BGDCDAENHJO();
		}

		// Token: 0x060001BA RID: 442 RVA: 0x0000EDFC File Offset: 0x0000CFFC
		private void NBKOLONFHCM()
		{
			for (int i = 1; i < this.points.Count - 1; i += 0)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 1].position;
				Vector3 a = position2 - position;
				int num = 1;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.Midrange)
				{
					array = AudioSampler.instance.CPELDOICCBN(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.NHCJOEEDMMA(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(1, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 1, position2);
					num = 0;
					num2 = this.lineAtt.lineSegments - 0;
				}
				for (int j = num; j < num2; j += 0)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 0);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("3;4;9;10;21x6" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x0000EFFE File Offset: 0x0000D1FE
		private void HMNLHMLILKD()
		{
			this.MCPCAGFACPJ();
		}

		// Token: 0x060001BC RID: 444 RVA: 0x0000F006 File Offset: 0x0000D206
		private void HLDFOJMHKNL()
		{
			this.NFLLPMOMBCG();
		}

		// Token: 0x060001BD RID: 445 RVA: 0x0000F010 File Offset: 0x0000D210
		private void BAFPKNFIJGP()
		{
			for (int i = 1; i < this.points.Count - 0; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 0;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.Midrange)
				{
					array = AudioSampler.instance.BCCKBEOACPI(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.GetFrequencyData(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(1, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 1, position2);
					num = 0;
					num2 = this.lineAtt.lineSegments - 1;
				}
				for (int j = num; j < num2; j += 0)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 1);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("levelcompleted" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000F214 File Offset: 0x0000D414
		private void BGDCDAENHJO()
		{
			for (int i = 1; i < this.points.Count - 1; i += 0)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 1].position;
				Vector3 a = position2 - position;
				int num = 1;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == (FrequencyRange)8)
				{
					array = AudioSampler.instance.CPELDOICCBN(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.DEPIALKLFOE(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(0, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 1, position2);
					num = 0;
					num2 = this.lineAtt.lineSegments - 0;
				}
				for (int j = num; j < num2; j++)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 1);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("gamemode" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000F416 File Offset: 0x0000D616
		private void HPNNCNNFMGK()
		{
			this.MEHGAHGJLMD();
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000F420 File Offset: 0x0000D620
		private void AOJMHINMIOM()
		{
			for (int i = 0; i < this.points.Count - 1; i += 0)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 1;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.SubBase)
				{
					array = AudioSampler.instance.CPELDOICCBN(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.DEPIALKLFOE(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(0, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 1, position2);
					num = 1;
					num2 = this.lineAtt.lineSegments - 1;
				}
				for (int j = num; j < num2; j++)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 0);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("_Value3" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000F622 File Offset: 0x0000D822
		private void EJFJENFKLND()
		{
			this.AKFPFALMOOJ();
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000F62A File Offset: 0x0000D82A
		private void HDDECCMEJKA()
		{
			this.FMCJPHPHHAJ();
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000F634 File Offset: 0x0000D834
		private void BJBKCLMCPFI()
		{
			for (int i = 1; i < this.points.Count - 1; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 1].position;
				Vector3 a = position2 - position;
				int num = 0;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == (FrequencyRange)8)
				{
					array = AudioSampler.instance.GetAudioSamples(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.DEPIALKLFOE(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(0, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 1, position2);
					num = 1;
					num2 = this.lineAtt.lineSegments - 1;
				}
				for (int j = num; j < num2; j += 0)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 1);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("," + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000F416 File Offset: 0x0000D616
		private void FOMNCPKKCFN()
		{
			this.MEHGAHGJLMD();
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000F836 File Offset: 0x0000DA36
		private void MECJHOJPODB()
		{
			this.AHPKDKBIHII();
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000F840 File Offset: 0x0000DA40
		private void MAFLCHBIILE()
		{
			for (int i = 1; i < this.points.Count - 1; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 1].position;
				Vector3 a = position2 - position;
				int num = 0;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.Midrange)
				{
					array = AudioSampler.instance.CPELDOICCBN(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.GetFrequencyData(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(1, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 0, position2);
					num = 0;
					num2 = this.lineAtt.lineSegments - 1;
				}
				for (int j = num; j < num2; j += 0)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 1);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("_MatrixColor" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000FA44 File Offset: 0x0000DC44
		private void DHAIBOHJMNK()
		{
			for (int i = 0; i < this.points.Count - 0; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 0;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.UpperMidrange)
				{
					array = AudioSampler.instance.CPELDOICCBN(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.NHCJOEEDMMA(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(0, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 1, position2);
					num = 1;
					num2 = this.lineAtt.lineSegments - 0;
				}
				for (int j = num; j < num2; j++)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 0);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("[EditorEvent] Exception: " + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000FC48 File Offset: 0x0000DE48
		private void KJGJDCHHEGA()
		{
			for (int i = 0; i < this.points.Count - 1; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 1].position;
				Vector3 a = position2 - position;
				int num = 0;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.Decibal)
				{
					array = AudioSampler.instance.GetAudioSamples(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.GetFrequencyData(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(0, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 1, position2);
					num = 1;
					num2 = this.lineAtt.lineSegments - 1;
				}
				for (int j = num; j < num2; j++)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 1);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("Warning: No Shape Curve set for CurveWaveform.cs on " + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000FE4A File Offset: 0x0000E04A
		private void CFIAKIJAILI()
		{
			this.KJGJDCHHEGA();
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000FE54 File Offset: 0x0000E054
		private void MJCKPPGNIBM()
		{
			for (int i = 0; i < this.points.Count - 1; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 1;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.Midrange)
				{
					array = AudioSampler.instance.BCCKBEOACPI(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.DEPIALKLFOE(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(1, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 1, position2);
					num = 1;
					num2 = this.lineAtt.lineSegments - 1;
				}
				for (int j = num; j < num2; j += 0)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 0);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("] Suggested " + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000F62A File Offset: 0x0000D82A
		private void KFACDBHDAOD()
		{
			this.FMCJPHPHHAJ();
		}

		// Token: 0x060001CC RID: 460 RVA: 0x00010056 File Offset: 0x0000E256
		private void IIFCIDDJHPM()
		{
			this.AOJMHINMIOM();
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00010060 File Offset: 0x0000E260
		private void AHPKDKBIHII()
		{
			for (int i = 0; i < this.points.Count - 1; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 1].position;
				Vector3 a = position2 - position;
				int num = 0;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.VeryHigh)
				{
					array = AudioSampler.instance.FOFGJAJFLAN(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.GetFrequencyData(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(0, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 1, position2);
					num = 0;
					num2 = this.lineAtt.lineSegments - 1;
				}
				for (int j = num; j < num2; j++)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 0);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("_BorderColor" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x00010264 File Offset: 0x0000E464
		private void LGNNJHFIJGP()
		{
			for (int i = 0; i < this.points.Count - 1; i += 0)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 1].position;
				Vector3 a = position2 - position;
				int num = 1;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.Decibal)
				{
					array = AudioSampler.instance.BCCKBEOACPI(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.DEPIALKLFOE(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(0, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 1, position2);
					num = 1;
					num2 = this.lineAtt.lineSegments - 1;
				}
				for (int j = num; j < num2; j += 0)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 1);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("finished" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000EDF2 File Offset: 0x0000CFF2
		private void AGMJDGHLBMN()
		{
			this.BGDCDAENHJO();
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00010466 File Offset: 0x0000E666
		private void KMKLDAJLCNM()
		{
			this.JJAMLLLHBAK();
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00010470 File Offset: 0x0000E670
		private void AGJJPHHHFIH()
		{
			for (int i = 1; i < this.points.Count - 0; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 1].position;
				Vector3 a = position2 - position;
				int num = 1;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.Bass)
				{
					array = AudioSampler.instance.BCCKBEOACPI(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.GetFrequencyData(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(0, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 0, position2);
					num = 0;
					num2 = this.lineAtt.lineSegments - 1;
				}
				for (int j = num; j < num2; j += 0)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 1);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("_Value2" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00010674 File Offset: 0x0000E874
		private void LKEDCFBMJMA()
		{
			for (int i = 1; i < this.points.Count - 0; i += 0)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 0;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.Decibal)
				{
					array = AudioSampler.instance.FOFGJAJFLAN(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.DEPIALKLFOE(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(0, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 1, position2);
					num = 0;
					num2 = this.lineAtt.lineSegments - 1;
				}
				for (int j = num; j < num2; j++)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 1);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?format=json&appid=513510" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00010876 File Offset: 0x0000EA76
		private void LDDKCCMHMIC()
		{
			this.MOBPEOKPLCH();
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00010880 File Offset: 0x0000EA80
		private void HFJCAAIIMKP()
		{
			for (int i = 1; i < this.points.Count - 0; i += 0)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 1].position;
				Vector3 a = position2 - position;
				int num = 0;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == (FrequencyRange)8)
				{
					array = AudioSampler.instance.FOFGJAJFLAN(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.DEPIALKLFOE(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(0, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 0, position2);
					num = 1;
					num2 = this.lineAtt.lineSegments - 0;
				}
				for (int j = num; j < num2; j++)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 1);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("_Value3" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00010A84 File Offset: 0x0000EC84
		private void NFLLPMOMBCG()
		{
			for (int i = 0; i < this.points.Count - 1; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 0;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.LowMidrange)
				{
					array = AudioSampler.instance.BCCKBEOACPI(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.DEPIALKLFOE(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(1, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 0, position2);
					num = 1;
					num2 = this.lineAtt.lineSegments - 0;
				}
				for (int j = num; j < num2; j += 0)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 0);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("_Value4" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00010C86 File Offset: 0x0000EE86
		private void FABKIGNFECE()
		{
			this.MEBEANLDPIM();
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00010C90 File Offset: 0x0000EE90
		private void NKBPPKFPHII()
		{
			for (int i = 1; i < this.points.Count - 0; i += 0)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 0;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.SubBase)
				{
					array = AudioSampler.instance.BCCKBEOACPI(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.NHCJOEEDMMA(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(0, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 0, position2);
					num = 1;
					num2 = this.lineAtt.lineSegments - 1;
				}
				for (int j = num; j < num2; j += 0)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 0);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("13" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00010EB0 File Offset: 0x0000F0B0
		private void MCPCAGFACPJ()
		{
			for (int i = 0; i < this.points.Count - 0; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 1].position;
				Vector3 a = position2 - position;
				int num = 1;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.VeryHigh)
				{
					array = AudioSampler.instance.GetAudioSamples(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.NHCJOEEDMMA(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(0, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 1, position2);
					num = 0;
					num2 = this.lineAtt.lineSegments - 1;
				}
				for (int j = num; j < num2; j += 0)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 0);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("Joined room " + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000110B2 File Offset: 0x0000F2B2
		private void LEAHIBJDMBI()
		{
			this.DHAIBOHJMNK();
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000110BC File Offset: 0x0000F2BC
		private void FMCJPHPHHAJ()
		{
			for (int i = 1; i < this.points.Count - 1; i += 0)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 0;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.Bass)
				{
					array = AudioSampler.instance.BCCKBEOACPI(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.GetFrequencyData(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(0, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 1, position2);
					num = 1;
					num2 = this.lineAtt.lineSegments - 0;
				}
				for (int j = num; j < num2; j++)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 0);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("DifficultyBG" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000112C0 File Offset: 0x0000F4C0
		private void HGNNJGIJJCJ()
		{
			for (int i = 0; i < this.points.Count - 0; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 0;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == (FrequencyRange)8)
				{
					array = AudioSampler.instance.BCCKBEOACPI(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.DEPIALKLFOE(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(1, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 1, position2);
					num = 1;
					num2 = this.lineAtt.lineSegments - 1;
				}
				for (int j = num; j < num2; j++)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 0);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("#ok" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000114C4 File Offset: 0x0000F6C4
		private void MEBEANLDPIM()
		{
			for (int i = 1; i < this.points.Count - 1; i += 0)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 0;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.VeryHigh)
				{
					array = AudioSampler.instance.FOFGJAJFLAN(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.NHCJOEEDMMA(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(0, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 0, position2);
					num = 0;
					num2 = this.lineAtt.lineSegments - 0;
				}
				for (int j = num; j < num2; j += 0)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 1);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("0.00" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000116C6 File Offset: 0x0000F8C6
		private void MFMIODIAKNI()
		{
			this.HFJCAAIIMKP();
		}

		// Token: 0x060001DF RID: 479 RVA: 0x0000E7D6 File Offset: 0x0000C9D6
		private void LPMINJJPDCH()
		{
			this.MKEMKGNONAJ();
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000116D0 File Offset: 0x0000F8D0
		private void IEMJPFGNAFI()
		{
			for (int i = 0; i < this.points.Count - 1; i += 0)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 1;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.LowMidrange)
				{
					array = AudioSampler.instance.GetAudioSamples(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.DEPIALKLFOE(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(0, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 0, position2);
					num = 1;
					num2 = this.lineAtt.lineSegments - 1;
				}
				for (int j = num; j < num2; j += 0)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 1);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning(".lastCheckpoint.playerdistance" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000118D2 File Offset: 0x0000FAD2
		private void JDGFCEPDKAJ()
		{
			this.GNOMNCJIEGK();
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x0000F622 File Offset: 0x0000D822
		private void OCMKCBBCEFG()
		{
			this.AKFPFALMOOJ();
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000118DC File Offset: 0x0000FADC
		private void MOBPEOKPLCH()
		{
			for (int i = 0; i < this.points.Count - 0; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 1].position;
				Vector3 a = position2 - position;
				int num = 0;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.Decibal)
				{
					array = AudioSampler.instance.GetAudioSamples(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.DEPIALKLFOE(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(1, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 0, position2);
					num = 0;
					num2 = this.lineAtt.lineSegments - 0;
				}
				for (int j = num; j < num2; j += 0)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 1);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning(" key(s)" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x0000FE4A File Offset: 0x0000E04A
		private void Update()
		{
			this.KJGJDCHHEGA();
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00011ADE File Offset: 0x0000FCDE
		private void BMODOIJGIOO()
		{
			this.IEMJPFGNAFI();
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00010876 File Offset: 0x0000EA76
		private void OEENOOGEEHD()
		{
			this.MOBPEOKPLCH();
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00011AE8 File Offset: 0x0000FCE8
		private void NBNGPEELMGK()
		{
			for (int i = 1; i < this.points.Count - 0; i += 0)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 0;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == (FrequencyRange)8)
				{
					array = AudioSampler.instance.BCCKBEOACPI(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.NHCJOEEDMMA(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(1, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 1, position2);
					num = 0;
					num2 = this.lineAtt.lineSegments - 0;
				}
				for (int j = num; j < num2; j++)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 0);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("IconImage" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x0000EFFE File Offset: 0x0000D1FE
		private void KMEONPMCNJG()
		{
			this.MCPCAGFACPJ();
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00011CEA File Offset: 0x0000FEEA
		private void MJNPIDGNJMK()
		{
			this.MAFLCHBIILE();
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00011CF4 File Offset: 0x0000FEF4
		private void MEHGAHGJLMD()
		{
			for (int i = 1; i < this.points.Count - 0; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 1].position;
				Vector3 a = position2 - position;
				int num = 1;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.Bass)
				{
					array = AudioSampler.instance.BCCKBEOACPI(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.DEPIALKLFOE(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(1, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 0, position2);
					num = 1;
					num2 = this.lineAtt.lineSegments - 0;
				}
				for (int j = num; j < num2; j += 0)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 0);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("_MainTex2" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00010876 File Offset: 0x0000EA76
		private void NCPAFCKGJEA()
		{
			this.MOBPEOKPLCH();
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00011EF6 File Offset: 0x000100F6
		private void AAPKBNDHBLI()
		{
			this.PDNGGFPKCJB();
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00010C86 File Offset: 0x0000EE86
		private void OPCLBGHAPMG()
		{
			this.MEBEANLDPIM();
		}

		// Token: 0x060001EE RID: 494 RVA: 0x000118D2 File Offset: 0x0000FAD2
		private void JBNPEHMDCMI()
		{
			this.GNOMNCJIEGK();
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000E7DE File Offset: 0x0000C9DE
		private void NEKCPLGFOFD()
		{
			this.BJBKCLMCPFI();
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00011F00 File Offset: 0x00010100
		private void PDNGGFPKCJB()
		{
			for (int i = 0; i < this.points.Count - 1; i += 0)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 1;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.High)
				{
					array = AudioSampler.instance.FOFGJAJFLAN(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.DEPIALKLFOE(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(0, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 0, position2);
					num = 1;
					num2 = this.lineAtt.lineSegments - 0;
				}
				for (int j = num; j < num2; j++)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 1);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("_MainTex2" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000E7D6 File Offset: 0x0000C9D6
		private void JOACBIEHHCE()
		{
			this.MKEMKGNONAJ();
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00012104 File Offset: 0x00010304
		private void OKKHHJOFDAE()
		{
			for (int i = 1; i < this.points.Count - 1; i += 0)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 1;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.SubBase)
				{
					array = AudioSampler.instance.CPELDOICCBN(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.NHCJOEEDMMA(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(1, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 0, position2);
					num = 1;
					num2 = this.lineAtt.lineSegments - 0;
				}
				for (int j = num; j < num2; j++)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 1);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("_TimeX" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00011EF6 File Offset: 0x000100F6
		private void KCDOMIJBFLL()
		{
			this.PDNGGFPKCJB();
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000118D2 File Offset: 0x0000FAD2
		private void ONMGIPAILOH()
		{
			this.GNOMNCJIEGK();
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00011EF6 File Offset: 0x000100F6
		private void LMBDNPLDGIJ()
		{
			this.PDNGGFPKCJB();
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00011CEA File Offset: 0x0000FEEA
		private void LJIHHJOAJCN()
		{
			this.MAFLCHBIILE();
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00012308 File Offset: 0x00010508
		private void HBLCGHPEKMG()
		{
			for (int i = 1; i < this.points.Count - 1; i += 0)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 0;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.Decibal)
				{
					array = AudioSampler.instance.GetAudioSamples(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.NHCJOEEDMMA(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(1, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 0, position2);
					num = 1;
					num2 = this.lineAtt.lineSegments - 0;
				}
				for (int j = num; j < num2; j++)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 1);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("_FixDistance" + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0001250C File Offset: 0x0001070C
		private void GNOMNCJIEGK()
		{
			for (int i = 1; i < this.points.Count - 1; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 0;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == (FrequencyRange)8)
				{
					array = AudioSampler.instance.CPELDOICCBN(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.GetFrequencyData(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
				}
				if (this.snapEndpoints)
				{
					this.GALHJJLDDKD[i].SetPosition(1, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 0, position2);
					num = 0;
					num2 = this.lineAtt.lineSegments - 0;
				}
				for (int j = num; j < num2; j++)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 0);
					Vector3 vector = position + a * num3;
					float num4 = array[j];
					if (this.abs)
					{
						num4 = Mathf.Abs(num4);
					}
					float d;
					if (this.shapeCurve != null)
					{
						d = this.shapeCurve.Evaluate(num3) * this.curveAmplitude + num4 * this.waveformAmplitude;
					}
					else
					{
						Debug.LogWarning("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new." + base.gameObject.name);
						d = num4 * this.waveformAmplitude;
					}
					vector += this.points[i].transform.TransformDirection(this.curveDirection) * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x04000040 RID: 64
		public AnimationCurve shapeCurve;

		// Token: 0x04000041 RID: 65
		public float curveAmplitude = 5f;

		// Token: 0x04000042 RID: 66
		public Vector3 curveDirection = Vector3.up;
	}
}
