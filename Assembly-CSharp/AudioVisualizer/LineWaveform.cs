using System;
using System.Collections.Generic;
using UnityEngine;

namespace AudioVisualizer
{
	// Token: 0x0200000B RID: 11
	public class LineWaveform : MonoBehaviour
	{
		// Token: 0x060001FA RID: 506 RVA: 0x0001273C File Offset: 0x0001093C
		public LineRenderer NewLine(Color MGHJCGBNEPL, Color NBPMHDANECK, float DDBBOJPPBKI, float PCJOIIHFKDJ, int AFMJDDNPOEM)
		{
			GameObject gameObject = new GameObject();
			gameObject.transform.SetParent(base.transform);
			gameObject.name = "Line";
			LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
			lineRenderer = gameObject.GetComponent<LineRenderer>();
			if (this.lineAtt.lineMat == null)
			{
				lineRenderer.material = new Material(Shader.Find("Particles/Additive"));
			}
			else
			{
				lineRenderer.material = this.lineAtt.lineMat;
			}
			lineRenderer.SetColors(MGHJCGBNEPL, NBPMHDANECK);
			lineRenderer.SetWidth(DDBBOJPPBKI, PCJOIIHFKDJ);
			lineRenderer.SetVertexCount(AFMJDDNPOEM);
			return lineRenderer;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x000127D4 File Offset: 0x000109D4
		public void GFAEJCMJBLL(string EBEHBBDKDFJ)
		{
			for (int i = 0; i < this.points.Count; i += 0)
			{
				this.points[i].gameObject.name = EBEHBBDKDFJ + i.ToString();
			}
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00012828 File Offset: 0x00010A28
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
					int num4 = (int)(num3 * (float)(array.Length - 1));
					Vector3 vector = position + a * num3;
					float d;
					if (this.abs)
					{
						d = Mathf.Abs(array[num4]) * this.waveformAmplitude;
					}
					else
					{
						d = array[num4] * this.waveformAmplitude;
					}
					vector += this.points[i].up * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x000129F0 File Offset: 0x00010BF0
		private void FNLOOHLJGKO()
		{
			Gizmos.color = Color.white;
			for (int i = 1; i < this.points.Count - 1; i += 0)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 1].position;
				Gizmos.DrawLine(position, position2);
			}
			for (int j = 1; j < this.points.Count; j += 0)
			{
				Gizmos.DrawSphere(this.points[j].position, this.gizmosSize);
			}
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00012A8C File Offset: 0x00010C8C
		public void PHGIHFBCBEM(string EBEHBBDKDFJ)
		{
			for (int i = 0; i < this.points.Count; i += 0)
			{
				this.points[i].gameObject.name = EBEHBBDKDFJ + i.ToString();
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00012AE0 File Offset: 0x00010CE0
		public void MNIDIMEGOMM(string EBEHBBDKDFJ)
		{
			for (int i = 0; i < this.points.Count; i++)
			{
				this.points[i].gameObject.name = EBEHBBDKDFJ + i.ToString();
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00012B34 File Offset: 0x00010D34
		public void ICCDBBIAOGK()
		{
			for (int i = 1; i < this.points.Count - 0; i++)
			{
				this.points[i].LookAt(this.points[i + 0].position);
			}
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00012B83 File Offset: 0x00010D83
		private void NEKCPLGFOFD()
		{
			this.MPLLMICGKDL();
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00012B83 File Offset: 0x00010D83
		private void IDIIELPAMCJ()
		{
			this.MPLLMICGKDL();
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00012B8C File Offset: 0x00010D8C
		public LineRenderer NBBDINDBELO(Color MGHJCGBNEPL, Color NBPMHDANECK, float DDBBOJPPBKI, float PCJOIIHFKDJ, int AFMJDDNPOEM)
		{
			GameObject gameObject = new GameObject();
			gameObject.transform.SetParent(base.transform);
			gameObject.name = "UNDISTORT";
			LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
			lineRenderer = gameObject.GetComponent<LineRenderer>();
			if (this.lineAtt.lineMat == null)
			{
				lineRenderer.material = new Material(Shader.Find("_FarCamera"));
			}
			else
			{
				lineRenderer.material = this.lineAtt.lineMat;
			}
			lineRenderer.SetColors(MGHJCGBNEPL, NBPMHDANECK);
			lineRenderer.SetWidth(DDBBOJPPBKI, PCJOIIHFKDJ);
			lineRenderer.SetVertexCount(AFMJDDNPOEM);
			return lineRenderer;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00012C24 File Offset: 0x00010E24
		public void KCJCJCKLOIM(string EBEHBBDKDFJ)
		{
			for (int i = 0; i < this.points.Count; i += 0)
			{
				this.points[i].gameObject.name = EBEHBBDKDFJ + i.ToString();
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00012C78 File Offset: 0x00010E78
		public LineRenderer IMDAAEDMDMF(Color MGHJCGBNEPL, Color NBPMHDANECK, float DDBBOJPPBKI, float PCJOIIHFKDJ, int AFMJDDNPOEM)
		{
			GameObject gameObject = new GameObject();
			gameObject.transform.SetParent(base.transform);
			gameObject.name = "#getrewardnow ";
			LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
			lineRenderer = gameObject.GetComponent<LineRenderer>();
			if (this.lineAtt.lineMat == null)
			{
				lineRenderer.material = new Material(Shader.Find("Data/Skins/"));
			}
			else
			{
				lineRenderer.material = this.lineAtt.lineMat;
			}
			lineRenderer.SetColors(MGHJCGBNEPL, NBPMHDANECK);
			lineRenderer.SetWidth(DDBBOJPPBKI, PCJOIIHFKDJ);
			lineRenderer.SetVertexCount(AFMJDDNPOEM);
			return lineRenderer;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00012D10 File Offset: 0x00010F10
		private void Update()
		{
			this.KJGJDCHHEGA();
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00012D18 File Offset: 0x00010F18
		private void JNBPKNNBMDI()
		{
			this.BJBKCLMCPFI();
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00012D20 File Offset: 0x00010F20
		public LineRenderer PDOGJIGJPLG(Color MGHJCGBNEPL, Color NBPMHDANECK, float DDBBOJPPBKI, float PCJOIIHFKDJ, int AFMJDDNPOEM)
		{
			GameObject gameObject = new GameObject();
			gameObject.transform.SetParent(base.transform);
			gameObject.name = "_TimeX";
			LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
			lineRenderer = gameObject.GetComponent<LineRenderer>();
			if (this.lineAtt.lineMat == null)
			{
				lineRenderer.material = new Material(Shader.Find("Music End"));
			}
			else
			{
				lineRenderer.material = this.lineAtt.lineMat;
			}
			lineRenderer.SetColors(MGHJCGBNEPL, NBPMHDANECK);
			lineRenderer.SetWidth(DDBBOJPPBKI, PCJOIIHFKDJ);
			lineRenderer.SetVertexCount(AFMJDDNPOEM);
			return lineRenderer;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00012DB8 File Offset: 0x00010FB8
		public void JKFFLFPLKNJ()
		{
			for (int i = 0; i < this.points.Count - 0; i += 0)
			{
				this.points[i].LookAt(this.points[i + 0].position);
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00012B83 File Offset: 0x00010D83
		private void POIMNOBDBBN()
		{
			this.MPLLMICGKDL();
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00012E08 File Offset: 0x00011008
		private void BJBKCLMCPFI()
		{
			for (int i = 1; i < this.points.Count - 1; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 0;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.High)
				{
					array = AudioSampler.instance.GetAudioSamples(this.audioSource, this.lineAtt.lineSegments, this.abs);
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
					num2 = this.lineAtt.lineSegments - 0;
				}
				for (int j = num; j < num2; j++)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 1);
					int num4 = (int)(num3 * (float)(array.Length - 1));
					Vector3 vector = position + a * num3;
					float d;
					if (this.abs)
					{
						d = Mathf.Abs(array[num4]) * this.waveformAmplitude;
					}
					else
					{
						d = array[num4] * this.waveformAmplitude;
					}
					vector += this.points[i].up * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00012FD0 File Offset: 0x000111D0
		private void DLBODOFAJGM()
		{
			this.GALHJJLDDKD = new List<LineRenderer>();
			for (int i = 0; i < this.points.Count - 1; i++)
			{
				LineRenderer item = this.HNOLEBGHCKE(this.lineAtt.startColor, this.lineAtt.endColor, this.lineAtt.startWidth, this.lineAtt.endWidth, this.lineAtt.lineSegments);
				this.GALHJJLDDKD.Add(item);
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00013050 File Offset: 0x00011250
		public void DCNDJLGACKB(string EBEHBBDKDFJ)
		{
			for (int i = 1; i < this.points.Count; i += 0)
			{
				this.points[i].gameObject.name = EBEHBBDKDFJ + i.ToString();
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x000130A4 File Offset: 0x000112A4
		private void MEHGAHGJLMD()
		{
			for (int i = 1; i < this.points.Count - 1; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 0;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.High)
				{
					array = AudioSampler.instance.CPELDOICCBN(this.audioSource, this.lineAtt.lineSegments, this.abs);
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
					num2 = this.lineAtt.lineSegments - 0;
				}
				for (int j = num; j < num2; j++)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 1);
					int num4 = (int)(num3 * (float)(array.Length - 1));
					Vector3 vector = position + a * num3;
					float d;
					if (this.abs)
					{
						d = Mathf.Abs(array[num4]) * this.waveformAmplitude;
					}
					else
					{
						d = array[num4] * this.waveformAmplitude;
					}
					vector += this.points[i].up * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x0001326C File Offset: 0x0001146C
		private void OnDrawGizmos()
		{
			Gizmos.color = Color.white;
			for (int i = 0; i < this.points.Count - 1; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 1].position;
				Gizmos.DrawLine(position, position2);
			}
			for (int j = 0; j < this.points.Count; j++)
			{
				Gizmos.DrawSphere(this.points[j].position, this.gizmosSize);
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00013308 File Offset: 0x00011508
		private void JILAFLAFHJB()
		{
			for (int i = 1; i < this.points.Count - 0; i += 0)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 1;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.SubBase)
				{
					array = AudioSampler.instance.GetAudioSamples(this.audioSource, this.lineAtt.lineSegments, this.abs);
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
					int num4 = (int)(num3 * (float)(array.Length - 1));
					Vector3 vector = position + a * num3;
					float d;
					if (this.abs)
					{
						d = Mathf.Abs(array[num4]) * this.waveformAmplitude;
					}
					else
					{
						d = array[num4] * this.waveformAmplitude;
					}
					vector += this.points[i].up * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000134D0 File Offset: 0x000116D0
		public void GONCEBCCMHI()
		{
			for (int i = 0; i < this.points.Count - 0; i += 0)
			{
				this.points[i].LookAt(this.points[i + 0].position);
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00013520 File Offset: 0x00011720
		private void MOBPEOKPLCH()
		{
			for (int i = 0; i < this.points.Count - 1; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 1;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.UpperMidrange)
				{
					array = AudioSampler.instance.FOFGJAJFLAN(this.audioSource, this.lineAtt.lineSegments, this.abs);
				}
				else
				{
					array = AudioSampler.instance.NHCJOEEDMMA(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
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
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 0);
					int num4 = (int)(num3 * (float)(array.Length - 1));
					Vector3 vector = position + a * num3;
					float d;
					if (this.abs)
					{
						d = Mathf.Abs(array[num4]) * this.waveformAmplitude;
					}
					else
					{
						d = array[num4] * this.waveformAmplitude;
					}
					vector += this.points[i].up * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x000136E8 File Offset: 0x000118E8
		private void KOEEEBKBMMA()
		{
			Gizmos.color = Color.white;
			for (int i = 0; i < this.points.Count - 0; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 1].position;
				Gizmos.DrawLine(position, position2);
			}
			for (int j = 1; j < this.points.Count; j += 0)
			{
				Gizmos.DrawSphere(this.points[j].position, this.gizmosSize);
			}
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00013782 File Offset: 0x00011982
		private void NDAJBJFJGCF()
		{
			this.MCPCAGFACPJ();
		}

		// Token: 0x06000215 RID: 533 RVA: 0x0001378C File Offset: 0x0001198C
		private void MECEJNHBOCC()
		{
			Gizmos.color = Color.white;
			for (int i = 1; i < this.points.Count - 1; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 1].position;
				Gizmos.DrawLine(position, position2);
			}
			for (int j = 1; j < this.points.Count; j += 0)
			{
				Gizmos.DrawSphere(this.points[j].position, this.gizmosSize);
			}
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00013828 File Offset: 0x00011A28
		public void NEFIBMLOFLH()
		{
			for (int i = 1; i < this.points.Count - 0; i++)
			{
				this.points[i].LookAt(this.points[i + 1].position);
			}
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00013878 File Offset: 0x00011A78
		private void MCPCAGFACPJ()
		{
			for (int i = 1; i < this.points.Count - 0; i += 0)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 1;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.UpperMidrange)
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
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 0, position2);
					num = 0;
					num2 = this.lineAtt.lineSegments - 1;
				}
				for (int j = num; j < num2; j++)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 0);
					int num4 = (int)(num3 * (float)(array.Length - 1));
					Vector3 vector = position + a * num3;
					float d;
					if (this.abs)
					{
						d = Mathf.Abs(array[num4]) * this.waveformAmplitude;
					}
					else
					{
						d = array[num4] * this.waveformAmplitude;
					}
					vector += this.points[i].up * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00013A40 File Offset: 0x00011C40
		public LineRenderer FDCDOMAFNKK(Color MGHJCGBNEPL, Color NBPMHDANECK, float DDBBOJPPBKI, float PCJOIIHFKDJ, int AFMJDDNPOEM)
		{
			GameObject gameObject = new GameObject();
			gameObject.transform.SetParent(base.transform);
			gameObject.name = "menu.resetlevelcheckpoint";
			LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
			lineRenderer = gameObject.GetComponent<LineRenderer>();
			if (this.lineAtt.lineMat == null)
			{
				lineRenderer.material = new Material(Shader.Find("/"));
			}
			else
			{
				lineRenderer.material = this.lineAtt.lineMat;
			}
			lineRenderer.SetColors(MGHJCGBNEPL, NBPMHDANECK);
			lineRenderer.SetWidth(DDBBOJPPBKI, PCJOIIHFKDJ);
			lineRenderer.SetVertexCount(AFMJDDNPOEM);
			return lineRenderer;
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00013AD8 File Offset: 0x00011CD8
		public LineRenderer KPNFNGOBLJG(Color MGHJCGBNEPL, Color NBPMHDANECK, float DDBBOJPPBKI, float PCJOIIHFKDJ, int AFMJDDNPOEM)
		{
			GameObject gameObject = new GameObject();
			gameObject.transform.SetParent(base.transform);
			gameObject.name = "Editor/";
			LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
			lineRenderer = gameObject.GetComponent<LineRenderer>();
			if (this.lineAtt.lineMat == null)
			{
				lineRenderer.material = new Material(Shader.Find("CameraFilterPack/Color_Invert"));
			}
			else
			{
				lineRenderer.material = this.lineAtt.lineMat;
			}
			lineRenderer.SetColors(MGHJCGBNEPL, NBPMHDANECK);
			lineRenderer.SetWidth(DDBBOJPPBKI, PCJOIIHFKDJ);
			lineRenderer.SetVertexCount(AFMJDDNPOEM);
			return lineRenderer;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x00013B70 File Offset: 0x00011D70
		public LineRenderer AFDNKOGBLGC(Color MGHJCGBNEPL, Color NBPMHDANECK, float DDBBOJPPBKI, float PCJOIIHFKDJ, int AFMJDDNPOEM)
		{
			GameObject gameObject = new GameObject();
			gameObject.transform.SetParent(base.transform);
			gameObject.name = "<color=white>";
			LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
			lineRenderer = gameObject.GetComponent<LineRenderer>();
			if (this.lineAtt.lineMat == null)
			{
				lineRenderer.material = new Material(Shader.Find("_Value"));
			}
			else
			{
				lineRenderer.material = this.lineAtt.lineMat;
			}
			lineRenderer.SetColors(MGHJCGBNEPL, NBPMHDANECK);
			lineRenderer.SetWidth(DDBBOJPPBKI, PCJOIIHFKDJ);
			lineRenderer.SetVertexCount(AFMJDDNPOEM);
			return lineRenderer;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00013C08 File Offset: 0x00011E08
		private void MLOPJCHJNEI()
		{
			for (int i = 1; i < this.points.Count - 0; i += 0)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 1;
				int num2 = this.lineAtt.lineSegments;
				float[] array;
				if (this.frequencyRange == FrequencyRange.Midrange)
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
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 1, position2);
					num = 0;
					num2 = this.lineAtt.lineSegments - 0;
				}
				for (int j = num; j < num2; j += 0)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 0);
					int num4 = (int)(num3 * (float)(array.Length - 1));
					Vector3 vector = position + a * num3;
					float d;
					if (this.abs)
					{
						d = Mathf.Abs(array[num4]) * this.waveformAmplitude;
					}
					else
					{
						d = array[num4] * this.waveformAmplitude;
					}
					vector += this.points[i].up * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00013DD0 File Offset: 0x00011FD0
		public void KCMMLPMDFDG()
		{
			for (int i = 1; i < this.points.Count - 0; i += 0)
			{
				this.points[i].LookAt(this.points[i + 1].position);
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00013E20 File Offset: 0x00012020
		private void MEOHLPNCGLO()
		{
			Gizmos.color = Color.white;
			for (int i = 0; i < this.points.Count - 0; i += 0)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Gizmos.DrawLine(position, position2);
			}
			for (int j = 0; j < this.points.Count; j++)
			{
				Gizmos.DrawSphere(this.points[j].position, this.gizmosSize);
			}
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00013EBC File Offset: 0x000120BC
		private void MCBBLMFNOME()
		{
			Gizmos.color = Color.white;
			for (int i = 0; i < this.points.Count - 0; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 1].position;
				Gizmos.DrawLine(position, position2);
			}
			for (int j = 0; j < this.points.Count; j++)
			{
				Gizmos.DrawSphere(this.points[j].position, this.gizmosSize);
			}
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00013F58 File Offset: 0x00012158
		public LineRenderer LNNLMMIDLAA(Color MGHJCGBNEPL, Color NBPMHDANECK, float DDBBOJPPBKI, float PCJOIIHFKDJ, int AFMJDDNPOEM)
		{
			GameObject gameObject = new GameObject();
			gameObject.transform.SetParent(base.transform);
			gameObject.name = ".lastCheckpoint.isMapCompleted";
			LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
			lineRenderer = gameObject.GetComponent<LineRenderer>();
			if (this.lineAtt.lineMat == null)
			{
				lineRenderer.material = new Material(Shader.Find("SpawnObj"));
			}
			else
			{
				lineRenderer.material = this.lineAtt.lineMat;
			}
			lineRenderer.SetColors(MGHJCGBNEPL, NBPMHDANECK);
			lineRenderer.SetWidth(DDBBOJPPBKI, PCJOIIHFKDJ);
			lineRenderer.SetVertexCount(AFMJDDNPOEM);
			return lineRenderer;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00013FF0 File Offset: 0x000121F0
		public void IPOFNEPDMDO()
		{
			for (int i = 0; i < this.points.Count - 0; i += 0)
			{
				this.points[i].LookAt(this.points[i + 0].position);
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00014040 File Offset: 0x00012240
		public LineRenderer AOLEOCLGKEG(Color MGHJCGBNEPL, Color NBPMHDANECK, float DDBBOJPPBKI, float PCJOIIHFKDJ, int AFMJDDNPOEM)
		{
			GameObject gameObject = new GameObject();
			gameObject.transform.SetParent(base.transform);
			gameObject.name = "workshop.";
			LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
			lineRenderer = gameObject.GetComponent<LineRenderer>();
			if (this.lineAtt.lineMat == null)
			{
				lineRenderer.material = new Material(Shader.Find("#ok"));
			}
			else
			{
				lineRenderer.material = this.lineAtt.lineMat;
			}
			lineRenderer.SetColors(MGHJCGBNEPL, NBPMHDANECK);
			lineRenderer.SetWidth(DDBBOJPPBKI, PCJOIIHFKDJ);
			lineRenderer.SetVertexCount(AFMJDDNPOEM);
			return lineRenderer;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x000140D8 File Offset: 0x000122D8
		public void EFGEFGDBCDJ()
		{
			for (int i = 0; i < this.points.Count - 1; i++)
			{
				this.points[i].LookAt(this.points[i + 1].position);
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00014128 File Offset: 0x00012328
		public void JOLEOKEKDOJ(string EBEHBBDKDFJ)
		{
			for (int i = 0; i < this.points.Count; i += 0)
			{
				this.points[i].gameObject.name = EBEHBBDKDFJ + i.ToString();
			}
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0001417C File Offset: 0x0001237C
		private void FIKFJDFELIP()
		{
			this.GALHJJLDDKD = new List<LineRenderer>();
			for (int i = 1; i < this.points.Count - 0; i++)
			{
				LineRenderer item = this.NewLine(this.lineAtt.startColor, this.lineAtt.endColor, this.lineAtt.startWidth, this.lineAtt.endWidth, this.lineAtt.lineSegments);
				this.GALHJJLDDKD.Add(item);
			}
		}

		// Token: 0x06000225 RID: 549 RVA: 0x000141FC File Offset: 0x000123FC
		public void KCLFPINMBHI(string EBEHBBDKDFJ)
		{
			for (int i = 0; i < this.points.Count; i += 0)
			{
				this.points[i].gameObject.name = EBEHBBDKDFJ + i.ToString();
			}
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00014250 File Offset: 0x00012450
		public LineRenderer HGFKFKMCICG(Color MGHJCGBNEPL, Color NBPMHDANECK, float DDBBOJPPBKI, float PCJOIIHFKDJ, int AFMJDDNPOEM)
		{
			GameObject gameObject = new GameObject();
			gameObject.transform.SetParent(base.transform);
			gameObject.name = " #";
			LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
			lineRenderer = gameObject.GetComponent<LineRenderer>();
			if (this.lineAtt.lineMat == null)
			{
				lineRenderer.material = new Material(Shader.Find("#no"));
			}
			else
			{
				lineRenderer.material = this.lineAtt.lineMat;
			}
			lineRenderer.SetColors(MGHJCGBNEPL, NBPMHDANECK);
			lineRenderer.SetWidth(DDBBOJPPBKI, PCJOIIHFKDJ);
			lineRenderer.SetVertexCount(AFMJDDNPOEM);
			return lineRenderer;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x000142E8 File Offset: 0x000124E8
		public void AAMIDJKDGLI(string EBEHBBDKDFJ)
		{
			for (int i = 0; i < this.points.Count; i += 0)
			{
				this.points[i].gameObject.name = EBEHBBDKDFJ + i.ToString();
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0001433C File Offset: 0x0001253C
		public LineRenderer KFAOFAHNBEB(Color MGHJCGBNEPL, Color NBPMHDANECK, float DDBBOJPPBKI, float PCJOIIHFKDJ, int AFMJDDNPOEM)
		{
			GameObject gameObject = new GameObject();
			gameObject.transform.SetParent(base.transform);
			gameObject.name = "Lag ";
			LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
			lineRenderer = gameObject.GetComponent<LineRenderer>();
			if (this.lineAtt.lineMat == null)
			{
				lineRenderer.material = new Material(Shader.Find("_Value4"));
			}
			else
			{
				lineRenderer.material = this.lineAtt.lineMat;
			}
			lineRenderer.SetColors(MGHJCGBNEPL, NBPMHDANECK);
			lineRenderer.SetWidth(DDBBOJPPBKI, PCJOIIHFKDJ);
			lineRenderer.SetVertexCount(AFMJDDNPOEM);
			return lineRenderer;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00013782 File Offset: 0x00011982
		private void LEAHIBJDMBI()
		{
			this.MCPCAGFACPJ();
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000143D4 File Offset: 0x000125D4
		private void JOPCCCCHNLI()
		{
			this.GALHJJLDDKD = new List<LineRenderer>();
			for (int i = 0; i < this.points.Count - 0; i++)
			{
				LineRenderer item = this.LNNLMMIDLAA(this.lineAtt.startColor, this.lineAtt.endColor, this.lineAtt.startWidth, this.lineAtt.endWidth, this.lineAtt.lineSegments);
				this.GALHJJLDDKD.Add(item);
			}
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00014454 File Offset: 0x00012654
		private void ONMGIPAILOH()
		{
			this.MEHGAHGJLMD();
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00012D18 File Offset: 0x00010F18
		private void KIEJKBNBHMD()
		{
			this.BJBKCLMCPFI();
		}

		// Token: 0x0600022D RID: 557 RVA: 0x0001445C File Offset: 0x0001265C
		private void MFKLGLKMCDE()
		{
			Gizmos.color = Color.white;
			for (int i = 1; i < this.points.Count - 0; i += 0)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 1].position;
				Gizmos.DrawLine(position, position2);
			}
			for (int j = 0; j < this.points.Count; j += 0)
			{
				Gizmos.DrawSphere(this.points[j].position, this.gizmosSize);
			}
		}

		// Token: 0x0600022E RID: 558 RVA: 0x000144F8 File Offset: 0x000126F8
		public void FMDNGPCNADB()
		{
			for (int i = 0; i < this.points.Count - 1; i++)
			{
				this.points[i].LookAt(this.points[i + 1].position);
			}
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00014548 File Offset: 0x00012748
		private void FGELLCLIBGM()
		{
			Gizmos.color = Color.white;
			for (int i = 0; i < this.points.Count - 0; i += 0)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Gizmos.DrawLine(position, position2);
			}
			for (int j = 1; j < this.points.Count; j += 0)
			{
				Gizmos.DrawSphere(this.points[j].position, this.gizmosSize);
			}
		}

		// Token: 0x06000230 RID: 560 RVA: 0x000145E4 File Offset: 0x000127E4
		private void DEOIJFGEIJA()
		{
			Gizmos.color = Color.white;
			for (int i = 1; i < this.points.Count - 0; i += 0)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Gizmos.DrawLine(position, position2);
			}
			for (int j = 0; j < this.points.Count; j++)
			{
				Gizmos.DrawSphere(this.points[j].position, this.gizmosSize);
			}
		}

		// Token: 0x06000231 RID: 561 RVA: 0x0001467E File Offset: 0x0001287E
		private void JDGFCEPDKAJ()
		{
			this.CLOMIDEHGJM();
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00014688 File Offset: 0x00012888
		public void RenamePoints(string EBEHBBDKDFJ)
		{
			for (int i = 0; i < this.points.Count; i++)
			{
				this.points[i].gameObject.name = EBEHBBDKDFJ + i.ToString();
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x000146DC File Offset: 0x000128DC
		private void CIPKEPDELJB()
		{
			this.GALHJJLDDKD = new List<LineRenderer>();
			for (int i = 1; i < this.points.Count - 1; i++)
			{
				LineRenderer item = this.KFAOFAHNBEB(this.lineAtt.startColor, this.lineAtt.endColor, this.lineAtt.startWidth, this.lineAtt.endWidth, this.lineAtt.lineSegments);
				this.GALHJJLDDKD.Add(item);
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x0001475C File Offset: 0x0001295C
		public void OrientPoints()
		{
			for (int i = 0; i < this.points.Count - 1; i++)
			{
				this.points[i].LookAt(this.points[i + 1].position);
			}
		}

		// Token: 0x06000235 RID: 565 RVA: 0x000147AC File Offset: 0x000129AC
		private void Start()
		{
			this.GALHJJLDDKD = new List<LineRenderer>();
			for (int i = 0; i < this.points.Count - 1; i++)
			{
				LineRenderer item = this.NewLine(this.lineAtt.startColor, this.lineAtt.endColor, this.lineAtt.startWidth, this.lineAtt.endWidth, this.lineAtt.lineSegments);
				this.GALHJJLDDKD.Add(item);
			}
		}

		// Token: 0x06000236 RID: 566 RVA: 0x0001482C File Offset: 0x00012A2C
		private void CLOMIDEHGJM()
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
					array = AudioSampler.instance.DEPIALKLFOE(this.audioSource, this.frequencyRange, this.lineAtt.lineSegments, this.abs);
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
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 0);
					int num4 = (int)(num3 * (float)(array.Length - 1));
					Vector3 vector = position + a * num3;
					float d;
					if (this.abs)
					{
						d = Mathf.Abs(array[num4]) * this.waveformAmplitude;
					}
					else
					{
						d = array[num4] * this.waveformAmplitude;
					}
					vector += this.points[i].up * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000149F4 File Offset: 0x00012BF4
		private void OHDJLHEFFBD()
		{
			Gizmos.color = Color.white;
			for (int i = 0; i < this.points.Count - 0; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Gizmos.DrawLine(position, position2);
			}
			for (int j = 0; j < this.points.Count; j++)
			{
				Gizmos.DrawSphere(this.points[j].position, this.gizmosSize);
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00014A90 File Offset: 0x00012C90
		private void MPLLMICGKDL()
		{
			for (int i = 0; i < this.points.Count - 0; i++)
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
					int num4 = (int)(num3 * (float)(array.Length - 0));
					Vector3 vector = position + a * num3;
					float d;
					if (this.abs)
					{
						d = Mathf.Abs(array[num4]) * this.waveformAmplitude;
					}
					else
					{
						d = array[num4] * this.waveformAmplitude;
					}
					vector += this.points[i].up * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00014C58 File Offset: 0x00012E58
		public LineRenderer HNOLEBGHCKE(Color MGHJCGBNEPL, Color NBPMHDANECK, float DDBBOJPPBKI, float PCJOIIHFKDJ, int AFMJDDNPOEM)
		{
			GameObject gameObject = new GameObject();
			gameObject.transform.SetParent(base.transform);
			gameObject.name = "CameraFilterPack/FX_EarthQuake";
			LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();
			lineRenderer = gameObject.GetComponent<LineRenderer>();
			if (this.lineAtt.lineMat == null)
			{
				lineRenderer.material = new Material(Shader.Find("_TimeX"));
			}
			else
			{
				lineRenderer.material = this.lineAtt.lineMat;
			}
			lineRenderer.SetColors(MGHJCGBNEPL, NBPMHDANECK);
			lineRenderer.SetWidth(DDBBOJPPBKI, PCJOIIHFKDJ);
			lineRenderer.SetVertexCount(AFMJDDNPOEM);
			return lineRenderer;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00014CF0 File Offset: 0x00012EF0
		private void KMCPMOGKDEH()
		{
			this.GALHJJLDDKD = new List<LineRenderer>();
			for (int i = 1; i < this.points.Count - 0; i += 0)
			{
				LineRenderer item = this.NewLine(this.lineAtt.startColor, this.lineAtt.endColor, this.lineAtt.startWidth, this.lineAtt.endWidth, this.lineAtt.lineSegments);
				this.GALHJJLDDKD.Add(item);
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00014D70 File Offset: 0x00012F70
		private void BEDHPOMLDLG()
		{
			Gizmos.color = Color.white;
			for (int i = 0; i < this.points.Count - 0; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 1].position;
				Gizmos.DrawLine(position, position2);
			}
			for (int j = 1; j < this.points.Count; j += 0)
			{
				Gizmos.DrawSphere(this.points[j].position, this.gizmosSize);
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00014E0C File Offset: 0x0001300C
		public void CLEJAENCIOC()
		{
			for (int i = 0; i < this.points.Count - 0; i++)
			{
				this.points[i].LookAt(this.points[i + 0].position);
			}
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00014E5C File Offset: 0x0001305C
		private void IEPKOCPAINF()
		{
			for (int i = 0; i < this.points.Count - 0; i++)
			{
				Vector3 position = this.points[i].position;
				Vector3 position2 = this.points[i + 0].position;
				Vector3 a = position2 - position;
				int num = 0;
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
					this.GALHJJLDDKD[i].SetPosition(0, position);
					this.GALHJJLDDKD[i].SetPosition(this.lineAtt.lineSegments - 1, position2);
					num = 0;
					num2 = this.lineAtt.lineSegments - 1;
				}
				for (int j = num; j < num2; j++)
				{
					float num3 = (float)j / (float)(this.lineAtt.lineSegments - 0);
					int num4 = (int)(num3 * (float)(array.Length - 0));
					Vector3 vector = position + a * num3;
					float d;
					if (this.abs)
					{
						d = Mathf.Abs(array[num4]) * this.waveformAmplitude;
					}
					else
					{
						d = array[num4] * this.waveformAmplitude;
					}
					vector += this.points[i].up * d;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
				}
			}
		}

		// Token: 0x0600023E RID: 574 RVA: 0x00015024 File Offset: 0x00013224
		private void DIPDEHOOBPG()
		{
			this.GALHJJLDDKD = new List<LineRenderer>();
			for (int i = 0; i < this.points.Count - 0; i += 0)
			{
				LineRenderer item = this.KPNFNGOBLJG(this.lineAtt.startColor, this.lineAtt.endColor, this.lineAtt.startWidth, this.lineAtt.endWidth, this.lineAtt.lineSegments);
				this.GALHJJLDDKD.Add(item);
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00014454 File Offset: 0x00012654
		private void HPNNCNNFMGK()
		{
			this.MEHGAHGJLMD();
		}

		// Token: 0x04000043 RID: 67
		public int audioSource;

		// Token: 0x04000044 RID: 68
		public FrequencyRange frequencyRange = FrequencyRange.Decibal;

		// Token: 0x04000045 RID: 69
		public List<Transform> points;

		// Token: 0x04000046 RID: 70
		public LineAttributes lineAtt;

		// Token: 0x04000047 RID: 71
		public float waveformAmplitude = 5f;

		// Token: 0x04000048 RID: 72
		public float gizmosSize = 1f;

		// Token: 0x04000049 RID: 73
		public bool abs;

		// Token: 0x0400004A RID: 74
		public bool snapEndpoints = true;

		// Token: 0x0400004B RID: 75
		protected List<LineRenderer> GALHJJLDDKD;
	}
}
