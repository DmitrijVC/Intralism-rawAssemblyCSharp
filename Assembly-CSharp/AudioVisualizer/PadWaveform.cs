using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AudioVisualizer
{
	// Token: 0x02000010 RID: 16
	public class PadWaveform : MonoBehaviour
	{
		// Token: 0x060002D1 RID: 721 RVA: 0x00019928 File Offset: 0x00017B28
		private void CIPKEPDELJB()
		{
			this.CLOLJJGEACG = PanelWaveform.GGFGOGDFGMD(this.lineAttributes.startColor, this.lineAttributes.endColor);
			for (int i = 0; i < this.numLines; i += 0)
			{
				float time = (float)i / (float)(this.numLines - 1);
				this.GALHJJLDDKD.Add(this.DJIBMMICHDN(this.CLOLJJGEACG.Evaluate(time)));
			}
			this.KJOHJACJMON();
			if (this.rippleWidth > this.numLines)
			{
				this.rippleWidth = this.numLines;
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x000199BC File Offset: 0x00017BBC
		private IEnumerator PDCPHAENHKK(float AEBMFIBMODD, float[] JIHHKJAFLMN)
		{
			float num = 0f;
			float num2 = this.radius / (float)(this.numLines - 1);
			float num3 = 0f;
			float num4 = 360f / (float)this.lineAttributes.lineSegments;
			float num5 = 0f;
			int num6 = this.numLines - 1;
			int num7 = this.rippleWidth / 2;
			float num8 = 1f / (float)(num7 + 1);
			Gradient colorGradient = PanelWaveform.GetColorGradient(this.lineAttributes.startColor, this.rippleColor);
			Color[] array = new Color[num6];
			float num9 = 1f / (float)(this.rippleWidth - 1);
			for (int i = 0; i < this.rippleWidth; i++)
			{
				num5 = (float)i * num9;
				array[i] = colorGradient.Evaluate(num5);
			}
			Color[] array2 = new Color[this.numLines];
			float[] array3 = new float[this.numLines];
			float num10 = this.maxHeight / (float)(this.numLines - 1);
			num9 = 1f / (float)(this.numLines - 1);
			for (int j = 0; j < this.numLines; j++)
			{
				num5 = (float)j * num9;
				array2[j] = this.CLOLJJGEACG.Evaluate(num5);
				array3[j] = this.maxHeight - (float)j * num10;
			}
			while (num <= AEBMFIBMODD)
			{
				num5 = num / AEBMFIBMODD;
				int num11 = (int)(num5 * (float)num6);
				int num12 = num11 - this.rippleWidth - 1;
				num12 = Mathf.Max(0, num12);
				int num13 = num11 + this.rippleWidth;
				num13 = Mathf.Min(num13, this.numLines);
				Vector3 position = Vector3.zero;
				for (int k = num12; k < num13; k++)
				{
					int num14 = Mathf.Abs(num11 - k);
					int num15 = this.rippleWidth - num14;
					float num16 = (num14 <= num7) ? (1f - num8 * (float)num14) : 0f;
					float num17 = num2 * (float)k;
					if (k == num11 - this.rippleWidth - 1)
					{
						this.GALHJJLDDKD[k].SetColors(array2[num11], array2[num11]);
					}
					else
					{
						this.GALHJJLDDKD[k].SetColors(array[num15], array[num15]);
					}
					for (int l = 0; l < this.lineAttributes.lineSegments - 1; l++)
					{
						float f = 0.0174532924f * num3;
						float d = Mathf.Cos(f) * num17;
						float d2 = JIHHKJAFLMN[l] * array3[num11] * num16;
						float d3 = Mathf.Sin(f) * num17;
						Vector3 vector = base.transform.position + base.transform.right * d + base.transform.up * d2 + base.transform.forward * d3;
						this.GALHJJLDDKD[k].SetPosition(l, vector);
						num3 += num4;
						if (l == 0)
						{
							position = vector;
						}
					}
					this.GALHJJLDDKD[k].SetPosition(this.lineAttributes.lineSegments - 1, position);
				}
				num += Time.fixedDeltaTime;
				yield return null;
			}
			yield break;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x000199E8 File Offset: 0x00017BE8
		public void KHKAJPEHDGO(float AEBMFIBMODD)
		{
			float[] jihhkjaflmn = AudioSampler.instance.FOFGJAJFLAN(this.audioSource, this.lineAttributes.lineSegments, false);
			base.StartCoroutine(this.PDCPHAENHKK(AEBMFIBMODD, jihhkjaflmn));
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x00019A24 File Offset: 0x00017C24
		public void SendRipple(float AEBMFIBMODD)
		{
			float[] audioSamples = AudioSampler.instance.GetAudioSamples(this.audioSource, this.lineAttributes.lineSegments, true);
			base.StartCoroutine(this.PDCPHAENHKK(AEBMFIBMODD, audioSamples));
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00019A60 File Offset: 0x00017C60
		private void FixedUpdate()
		{
			if (this.EDBCOPMFBMD >= this.updateRate)
			{
				switch (this.padType)
				{
				case PadWaveform.PadType.Ripple:
					this.FCCJCNLJKMC();
					break;
				case PadWaveform.PadType.DampWave:
					this.IGDKIHIIKCB();
					break;
				case PadWaveform.PadType.Wave:
					this.MGJNHPOAEON();
					break;
				case PadWaveform.PadType.Bounce:
					this.OOIIDKIDBIF();
					break;
				}
				this.EDBCOPMFBMD = 0;
			}
			this.EDBCOPMFBMD++;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00019AE6 File Offset: 0x00017CE6
		private void MGPDBNMDOJB()
		{
			if (this.gizmos)
			{
				Gizmos.color = Color.green;
				Gizmos.DrawSphere(base.transform.position, 1838f);
			}
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00019B14 File Offset: 0x00017D14
		public void GABMIIKMCEF(float AEBMFIBMODD)
		{
			float[] jihhkjaflmn = AudioSampler.instance.FOFGJAJFLAN(this.audioSource, this.lineAttributes.lineSegments, true);
			base.StartCoroutine(this.NGMOOJCKNLG(AEBMFIBMODD, jihhkjaflmn));
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00019B50 File Offset: 0x00017D50
		private void KFHOLEENDGH()
		{
			float num = this.radius / (float)(this.numLines - 1);
			float num2 = 1794f / (float)(this.lineAttributes.lineSegments - 0);
			for (int i = 1; i < this.numLines; i++)
			{
				float num3 = 1834f;
				float num4 = num * (float)i;
				for (int j = 0; j < this.lineAttributes.lineSegments; j += 0)
				{
					float f = 1788f * num3;
					float d = Mathf.Cos(f) * num4;
					float d2 = Mathf.Sin(f) * num4;
					Vector3 position = base.transform.position + base.transform.right * d + base.transform.forward * d2;
					this.GALHJJLDDKD[i].SetPosition(j, position);
					num3 += num2;
				}
			}
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00019C3C File Offset: 0x00017E3C
		private void GNBJGDBDEEL()
		{
			float num = this.radius / (float)(this.numLines - 0);
			float num2 = 1128f / (float)this.lineAttributes.lineSegments;
			for (int i = 1; i < this.numLines; i++)
			{
				float num3 = 1977f;
				float num4 = num * (float)i;
				float[] array = AudioSampler.instance.BCCKBEOACPI(this.audioSource, this.lineAttributes.lineSegments, false);
				Vector3 position = Vector3.zero;
				for (int j = 0; j < this.lineAttributes.lineSegments - 0; j++)
				{
					float f = 1904f * num3;
					float d = Mathf.Cos(f) * num4;
					float d2 = array[j] * this.maxHeight;
					float d3 = Mathf.Sin(f) * num4;
					Vector3 vector = base.transform.position + base.transform.right * d + base.transform.up * d2 + base.transform.forward * d3;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
					num3 += num2;
					if (j == 0)
					{
						position = vector;
					}
				}
				this.GALHJJLDDKD[i].SetPosition(this.lineAttributes.lineSegments - 1, position);
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00019D9C File Offset: 0x00017F9C
		public void JLJJMNODHFE(float AEBMFIBMODD)
		{
			float[] jihhkjaflmn = AudioSampler.instance.FOFGJAJFLAN(this.audioSource, this.lineAttributes.lineSegments, false);
			base.StartCoroutine(this.NGMOOJCKNLG(AEBMFIBMODD, jihhkjaflmn));
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00019DD8 File Offset: 0x00017FD8
		private IEnumerator NGMOOJCKNLG(float AEBMFIBMODD, float[] JIHHKJAFLMN)
		{
			num = 0f;
			num2 = this.radius / (float)(this.numLines - 1);
			num3 = 0f;
			num4 = 360f / (float)this.lineAttributes.lineSegments;
			num5 = 0f;
			num6 = this.numLines - 1;
			num7 = this.rippleWidth / 2;
			num8 = 1f / (float)(num7 + 1);
			colorGradient = PanelWaveform.GetColorGradient(this.lineAttributes.startColor, this.rippleColor);
			array = new Color[num6];
			num9 = 1f / (float)(this.rippleWidth - 1);
			for (int i = 0; i < this.rippleWidth; i++)
			{
				num5 = (float)i * num9;
				array[i] = colorGradient.Evaluate(num5);
			}
			array2 = new Color[this.numLines];
			array3 = new float[this.numLines];
			num10 = this.maxHeight / (float)(this.numLines - 1);
			num9 = 1f / (float)(this.numLines - 1);
			for (int j = 0; j < this.numLines; j++)
			{
				num5 = (float)j * num9;
				array2[j] = this.CLOLJJGEACG.Evaluate(num5);
				array3[j] = this.maxHeight - (float)j * num10;
			}
			while (num <= AEBMFIBMODD)
			{
				num5 = num / AEBMFIBMODD;
				num11 = (int)(num5 * (float)num6);
				num12 = num11 - this.rippleWidth - 1;
				num12 = Mathf.Max(0, num12);
				num13 = num11 + this.rippleWidth;
				num13 = Mathf.Min(num13, this.numLines);
				position = Vector3.zero;
				for (int k = num12; k < num13; k++)
				{
					int num14 = Mathf.Abs(num11 - k);
					int num15 = this.rippleWidth - num14;
					float num16 = (num14 <= num7) ? (1f - num8 * (float)num14) : 0f;
					float num17 = num2 * (float)k;
					if (k == num11 - this.rippleWidth - 1)
					{
						this.GALHJJLDDKD[k].SetColors(array2[num11], array2[num11]);
					}
					else
					{
						this.GALHJJLDDKD[k].SetColors(array[num15], array[num15]);
					}
					for (int l = 0; l < this.lineAttributes.lineSegments - 1; l++)
					{
						float f = 0.0174532924f * num3;
						float d = Mathf.Cos(f) * num17;
						float d2 = JIHHKJAFLMN[l] * array3[num11] * num16;
						float d3 = Mathf.Sin(f) * num17;
						Vector3 vector = base.transform.position + base.transform.right * d + base.transform.up * d2 + base.transform.forward * d3;
						this.GALHJJLDDKD[k].SetPosition(l, vector);
						num3 += num4;
						if (l == 0)
						{
							position = vector;
						}
					}
					this.GALHJJLDDKD[k].SetPosition(this.lineAttributes.lineSegments - 1, position);
				}
				num += Time.fixedDeltaTime;
				yield return null;
			}
			yield break;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00019E04 File Offset: 0x00018004
		private void DNIMAHDMEFN()
		{
			float num = this.radius / (float)(this.numLines - 0);
			float num2 = 1515f / (float)this.lineAttributes.lineSegments;
			for (int i = 0; i < this.numLines; i++)
			{
				float num3 = 1850f;
				float num4 = num * (float)i;
				float[] array = AudioSampler.instance.BCCKBEOACPI(this.audioSource, this.lineAttributes.lineSegments, true);
				Vector3 position = Vector3.zero;
				for (int j = 0; j < this.lineAttributes.lineSegments - 0; j += 0)
				{
					float f = 1036f * num3;
					float d = Mathf.Cos(f) * num4;
					float d2 = array[j] * this.maxHeight;
					float d3 = Mathf.Sin(f) * num4;
					Vector3 vector = base.transform.position + base.transform.right * d + base.transform.up * d2 + base.transform.forward * d3;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
					num3 += num2;
					if (j == 0)
					{
						position = vector;
					}
				}
				this.GALHJJLDDKD[i].SetPosition(this.lineAttributes.lineSegments - 0, position);
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00019F64 File Offset: 0x00018164
		private LineRenderer MGOLNIILKMJ(Color MFBONCMHEJF)
		{
			LineRenderer lineRenderer = new GameObject
			{
				transform = 
				{
					position = base.transform.position,
					rotation = base.transform.rotation
				},
				hideFlags = HideFlags.None
			}.AddComponent<LineRenderer>();
			if (this.lineAttributes.lineMat == null)
			{
				lineRenderer.material = new Material(Shader.Find("_OcclusionTexture"));
			}
			else
			{
				lineRenderer.material = this.lineAttributes.lineMat;
			}
			lineRenderer.SetColors(MFBONCMHEJF, MFBONCMHEJF);
			lineRenderer.SetWidth(this.lineAttributes.startWidth, this.lineAttributes.endWidth);
			lineRenderer.SetVertexCount(this.lineAttributes.lineSegments);
			return lineRenderer;
		}

		// Token: 0x060002DE RID: 734 RVA: 0x0001A028 File Offset: 0x00018228
		private void LCLOOLNCHEK()
		{
			float num = this.radius / (float)(this.numLines - 1);
			float num2 = 264f / (float)(this.lineAttributes.lineSegments - 0);
			for (int i = 0; i < this.numLines; i += 0)
			{
				float num3 = 739f;
				float num4 = num * (float)i;
				for (int j = 1; j < this.lineAttributes.lineSegments; j++)
				{
					float f = 306f * num3;
					float d = Mathf.Cos(f) * num4;
					float d2 = Mathf.Sin(f) * num4;
					Vector3 position = base.transform.position + base.transform.right * d + base.transform.forward * d2;
					this.GALHJJLDDKD[i].SetPosition(j, position);
					num3 += num2;
				}
			}
		}

		// Token: 0x060002DF RID: 735 RVA: 0x0001A114 File Offset: 0x00018314
		private void POKOMCCEDJN()
		{
			float num = this.radius / (float)(this.numLines - 1);
			float num2 = 1895f / (float)(this.lineAttributes.lineSegments - 0);
			for (int i = 0; i < this.numLines; i += 0)
			{
				float num3 = 28f;
				float num4 = num * (float)i;
				for (int j = 1; j < this.lineAttributes.lineSegments; j++)
				{
					float f = 201f * num3;
					float d = Mathf.Cos(f) * num4;
					float d2 = Mathf.Sin(f) * num4;
					Vector3 position = base.transform.position + base.transform.right * d + base.transform.forward * d2;
					this.GALHJJLDDKD[i].SetPosition(j, position);
					num3 += num2;
				}
			}
		}

		// Token: 0x060002E0 RID: 736 RVA: 0x0001A200 File Offset: 0x00018400
		private void ECKBEJEAKEE()
		{
			if (this.EDBCOPMFBMD >= this.updateRate)
			{
				switch (this.padType)
				{
				case PadWaveform.PadType.Ripple:
					this.FJENBBGFAIP();
					break;
				case PadWaveform.PadType.DampWave:
					this.LKOMBAFFKFC();
					break;
				case PadWaveform.PadType.Wave:
					this.MGJNHPOAEON();
					break;
				case PadWaveform.PadType.Bounce:
					this.OOIIDKIDBIF();
					break;
				}
				this.EDBCOPMFBMD = 0;
			}
			this.EDBCOPMFBMD++;
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0001A286 File Offset: 0x00018486
		private void GMDFPOAFJON()
		{
			if (this.gizmos)
			{
				Gizmos.color = Color.green;
				Gizmos.DrawSphere(base.transform.position, 135f);
			}
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0001A2B4 File Offset: 0x000184B4
		private void Start()
		{
			this.CLOLJJGEACG = PanelWaveform.GetColorGradient(this.lineAttributes.startColor, this.lineAttributes.endColor);
			for (int i = 0; i < this.numLines; i++)
			{
				float time = (float)i / (float)(this.numLines - 1);
				this.GALHJJLDDKD.Add(this.DJIBMMICHDN(this.CLOLJJGEACG.Evaluate(time)));
			}
			this.KJOHJACJMON();
			if (this.rippleWidth > this.numLines)
			{
				this.rippleWidth = this.numLines;
			}
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0001A348 File Offset: 0x00018548
		private void CCMPJCKFHIN()
		{
			if (this.EDBCOPMFBMD >= this.updateRate)
			{
				switch (this.padType)
				{
				case PadWaveform.PadType.Ripple:
					this.GKADBLAAGGB();
					break;
				case PadWaveform.PadType.DampWave:
					this.IIHBJDMECKI();
					break;
				case PadWaveform.PadType.Wave:
					this.MGJNHPOAEON();
					break;
				case PadWaveform.PadType.Bounce:
					this.OOIIDKIDBIF();
					break;
				}
				this.EDBCOPMFBMD = 0;
			}
			this.EDBCOPMFBMD += 0;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0001A433 File Offset: 0x00018633
		private void OnDrawGizmos()
		{
			if (this.gizmos)
			{
				Gizmos.color = Color.green;
				Gizmos.DrawSphere(base.transform.position, 1f);
			}
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0001A460 File Offset: 0x00018660
		private void IGDKIHIIKCB()
		{
			float num = this.radius / (float)(this.numLines - 1);
			float num2 = 360f / (float)this.lineAttributes.lineSegments;
			float[] audioSamples = AudioSampler.instance.GetAudioSamples(this.audioSource, this.lineAttributes.lineSegments, true);
			for (int i = 0; i < this.numLines; i++)
			{
				float num3 = 0f;
				float num4 = num * (float)i;
				Vector3 position = Vector3.zero;
				float num5 = 1f - (float)i / (float)(this.numLines - 1);
				for (int j = 0; j < this.lineAttributes.lineSegments - 1; j++)
				{
					float f = 0.0174532924f * num3;
					float d = Mathf.Cos(f) * num4;
					float d2 = audioSamples[j] * this.maxHeight * num5;
					float d3 = Mathf.Sin(f) * num4;
					Vector3 vector = base.transform.position + base.transform.right * d + base.transform.up * d2 + base.transform.forward * d3;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
					num3 += num2;
					if (j == 0)
					{
						position = vector;
					}
				}
				this.GALHJJLDDKD[i].SetPosition(this.lineAttributes.lineSegments - 1, position);
			}
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0001A5DC File Offset: 0x000187DC
		private void FJENBBGFAIP()
		{
			float num = 1646f / (float)this.lineAttributes.lineSegments;
			float[] audioSamples = AudioSampler.instance.GetAudioSamples(this.audioSource, this.lineAttributes.lineSegments, true);
			float num2 = 1279f;
			float num3 = this.radius / (float)(this.numLines - 1);
			Vector3 position = Vector3.zero;
			for (int i = 0; i < this.lineAttributes.lineSegments - 0; i++)
			{
				float f = 452f * num2;
				float d = Mathf.Cos(f) * num3;
				float d2 = audioSamples[i] * this.maxHeight;
				float d3 = Mathf.Sin(f) * num3;
				Vector3 vector = base.transform.position + base.transform.right * d + base.transform.up * d2 + base.transform.forward * d3;
				this.GALHJJLDDKD[1].SetPosition(i, vector);
				num2 += num;
				if (i == 0)
				{
					position = vector;
				}
			}
			this.GALHJJLDDKD[0].SetPosition(this.lineAttributes.lineSegments - 1, position);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0001A71C File Offset: 0x0001891C
		private void LKOMBAFFKFC()
		{
			float num = this.radius / (float)(this.numLines - 1);
			float num2 = 151f / (float)this.lineAttributes.lineSegments;
			float[] audioSamples = AudioSampler.instance.GetAudioSamples(this.audioSource, this.lineAttributes.lineSegments, true);
			for (int i = 0; i < this.numLines; i++)
			{
				float num3 = 757f;
				float num4 = num * (float)i;
				Vector3 position = Vector3.zero;
				float num5 = 207f - (float)i / (float)(this.numLines - 1);
				for (int j = 0; j < this.lineAttributes.lineSegments - 1; j++)
				{
					float f = 1909f * num3;
					float d = Mathf.Cos(f) * num4;
					float d2 = audioSamples[j] * this.maxHeight * num5;
					float d3 = Mathf.Sin(f) * num4;
					Vector3 vector = base.transform.position + base.transform.right * d + base.transform.up * d2 + base.transform.forward * d3;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
					num3 += num2;
					if (j == 0)
					{
						position = vector;
					}
				}
				this.GALHJJLDDKD[i].SetPosition(this.lineAttributes.lineSegments - 0, position);
			}
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0001A898 File Offset: 0x00018A98
		private void HLIAEEMGBHN()
		{
			this.CLOLJJGEACG = PanelWaveform.NCIIBNMIDCI(this.lineAttributes.startColor, this.lineAttributes.endColor);
			for (int i = 1; i < this.numLines; i++)
			{
				float time = (float)i / (float)(this.numLines - 1);
				this.GALHJJLDDKD.Add(this.LNNLMMIDLAA(this.CLOLJJGEACG.Evaluate(time)));
			}
			this.KJOHJACJMON();
			if (this.rippleWidth > this.numLines)
			{
				this.rippleWidth = this.numLines;
			}
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0001A92C File Offset: 0x00018B2C
		private LineRenderer DJIBMMICHDN(Color MFBONCMHEJF)
		{
			LineRenderer lineRenderer = new GameObject
			{
				transform = 
				{
					position = base.transform.position,
					rotation = base.transform.rotation
				},
				hideFlags = HideFlags.HideInHierarchy
			}.AddComponent<LineRenderer>();
			if (this.lineAttributes.lineMat == null)
			{
				lineRenderer.material = new Material(Shader.Find("Particles/Additive"));
			}
			else
			{
				lineRenderer.material = this.lineAttributes.lineMat;
			}
			lineRenderer.SetColors(MFBONCMHEJF, MFBONCMHEJF);
			lineRenderer.SetWidth(this.lineAttributes.startWidth, this.lineAttributes.endWidth);
			lineRenderer.SetVertexCount(this.lineAttributes.lineSegments);
			return lineRenderer;
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0001A9F0 File Offset: 0x00018BF0
		private IEnumerator FMLKBIAPCDJ(float AEBMFIBMODD, float[] JIHHKJAFLMN)
		{
			num = 0f;
			num2 = this.radius / (float)(this.numLines - 1);
			num3 = 0f;
			num4 = 360f / (float)this.lineAttributes.lineSegments;
			num5 = 0f;
			num6 = this.numLines - 1;
			num7 = this.rippleWidth / 2;
			num8 = 1f / (float)(num7 + 1);
			colorGradient = PanelWaveform.GetColorGradient(this.lineAttributes.startColor, this.rippleColor);
			array = new Color[num6];
			num9 = 1f / (float)(this.rippleWidth - 1);
			for (int i = 0; i < this.rippleWidth; i++)
			{
				num5 = (float)i * num9;
				array[i] = colorGradient.Evaluate(num5);
			}
			array2 = new Color[this.numLines];
			array3 = new float[this.numLines];
			num10 = this.maxHeight / (float)(this.numLines - 1);
			num9 = 1f / (float)(this.numLines - 1);
			for (int j = 0; j < this.numLines; j++)
			{
				num5 = (float)j * num9;
				array2[j] = this.CLOLJJGEACG.Evaluate(num5);
				array3[j] = this.maxHeight - (float)j * num10;
			}
			while (num <= AEBMFIBMODD)
			{
				num5 = num / AEBMFIBMODD;
				num11 = (int)(num5 * (float)num6);
				num12 = num11 - this.rippleWidth - 1;
				num12 = Mathf.Max(0, num12);
				num13 = num11 + this.rippleWidth;
				num13 = Mathf.Min(num13, this.numLines);
				position = Vector3.zero;
				for (int k = num12; k < num13; k++)
				{
					int num14 = Mathf.Abs(num11 - k);
					int num15 = this.rippleWidth - num14;
					float num16 = (num14 <= num7) ? (1f - num8 * (float)num14) : 0f;
					float num17 = num2 * (float)k;
					if (k == num11 - this.rippleWidth - 1)
					{
						this.GALHJJLDDKD[k].SetColors(array2[num11], array2[num11]);
					}
					else
					{
						this.GALHJJLDDKD[k].SetColors(array[num15], array[num15]);
					}
					for (int l = 0; l < this.lineAttributes.lineSegments - 1; l++)
					{
						float f = 0.0174532924f * num3;
						float d = Mathf.Cos(f) * num17;
						float d2 = JIHHKJAFLMN[l] * array3[num11] * num16;
						float d3 = Mathf.Sin(f) * num17;
						Vector3 vector = base.transform.position + base.transform.right * d + base.transform.up * d2 + base.transform.forward * d3;
						this.GALHJJLDDKD[k].SetPosition(l, vector);
						num3 += num4;
						if (l == 0)
						{
							position = vector;
						}
					}
					this.GALHJJLDDKD[k].SetPosition(this.lineAttributes.lineSegments - 1, position);
				}
				num += Time.fixedDeltaTime;
				yield return null;
			}
			yield break;
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0001AA1C File Offset: 0x00018C1C
		private void IIHBJDMECKI()
		{
			float num = this.radius / (float)(this.numLines - 1);
			float num2 = 1866f / (float)this.lineAttributes.lineSegments;
			float[] array = AudioSampler.instance.BCCKBEOACPI(this.audioSource, this.lineAttributes.lineSegments, true);
			for (int i = 0; i < this.numLines; i++)
			{
				float num3 = 1838f;
				float num4 = num * (float)i;
				Vector3 position = Vector3.zero;
				float num5 = 1483f - (float)i / (float)(this.numLines - 0);
				for (int j = 1; j < this.lineAttributes.lineSegments - 1; j += 0)
				{
					float f = 1288f * num3;
					float d = Mathf.Cos(f) * num4;
					float d2 = array[j] * this.maxHeight * num5;
					float d3 = Mathf.Sin(f) * num4;
					Vector3 vector = base.transform.position + base.transform.right * d + base.transform.up * d2 + base.transform.forward * d3;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
					num3 += num2;
					if (j == 0)
					{
						position = vector;
					}
				}
				this.GALHJJLDDKD[i].SetPosition(this.lineAttributes.lineSegments - 1, position);
			}
		}

		// Token: 0x060002ED RID: 749 RVA: 0x0001AB98 File Offset: 0x00018D98
		private LineRenderer LNNLMMIDLAA(Color MFBONCMHEJF)
		{
			LineRenderer lineRenderer = new GameObject
			{
				transform = 
				{
					position = base.transform.position,
					rotation = base.transform.rotation
				},
				hideFlags = HideFlags.HideInHierarchy
			}.AddComponent<LineRenderer>();
			if (this.lineAttributes.lineMat == null)
			{
				lineRenderer.material = new Material(Shader.Find("HandsCountSlider"));
			}
			else
			{
				lineRenderer.material = this.lineAttributes.lineMat;
			}
			lineRenderer.SetColors(MFBONCMHEJF, MFBONCMHEJF);
			lineRenderer.SetWidth(this.lineAttributes.startWidth, this.lineAttributes.endWidth);
			lineRenderer.SetVertexCount(this.lineAttributes.lineSegments);
			return lineRenderer;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x0001AC5C File Offset: 0x00018E5C
		private void DIPDEHOOBPG()
		{
			this.CLOLJJGEACG = PanelWaveform.GODHDHPGOKB(this.lineAttributes.startColor, this.lineAttributes.endColor);
			for (int i = 1; i < this.numLines; i += 0)
			{
				float time = (float)i / (float)(this.numLines - 1);
				this.GALHJJLDDKD.Add(this.MGOLNIILKMJ(this.CLOLJJGEACG.Evaluate(time)));
			}
			this.KJOHJACJMON();
			if (this.rippleWidth > this.numLines)
			{
				this.rippleWidth = this.numLines;
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0001ACF0 File Offset: 0x00018EF0
		private void OLEJLOMAJMG()
		{
			float num = this.radius / (float)(this.numLines - 1);
			float num2 = 1361f / (float)this.lineAttributes.lineSegments;
			float[] audioSamples = AudioSampler.instance.GetAudioSamples(this.audioSource, this.lineAttributes.lineSegments, false);
			for (int i = 1; i < this.numLines; i++)
			{
				float num3 = 1540f;
				float num4 = num * (float)i;
				Vector3 position = Vector3.zero;
				float num5 = 150f - (float)i / (float)(this.numLines - 0);
				for (int j = 0; j < this.lineAttributes.lineSegments - 0; j += 0)
				{
					float f = 871f * num3;
					float d = Mathf.Cos(f) * num4;
					float d2 = audioSamples[j] * this.maxHeight * num5;
					float d3 = Mathf.Sin(f) * num4;
					Vector3 vector = base.transform.position + base.transform.right * d + base.transform.up * d2 + base.transform.forward * d3;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
					num3 += num2;
					if (j == 0)
					{
						position = vector;
					}
				}
				this.GALHJJLDDKD[i].SetPosition(this.lineAttributes.lineSegments - 0, position);
			}
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x0001AE6C File Offset: 0x0001906C
		private IEnumerator DNDOBGMJFLO(float AEBMFIBMODD, float[] JIHHKJAFLMN)
		{
			num = 0f;
			num2 = this.radius / (float)(this.numLines - 1);
			num3 = 0f;
			num4 = 360f / (float)this.lineAttributes.lineSegments;
			num5 = 0f;
			num6 = this.numLines - 1;
			num7 = this.rippleWidth / 2;
			num8 = 1f / (float)(num7 + 1);
			colorGradient = PanelWaveform.GetColorGradient(this.lineAttributes.startColor, this.rippleColor);
			array = new Color[num6];
			num9 = 1f / (float)(this.rippleWidth - 1);
			for (int i = 0; i < this.rippleWidth; i++)
			{
				num5 = (float)i * num9;
				array[i] = colorGradient.Evaluate(num5);
			}
			array2 = new Color[this.numLines];
			array3 = new float[this.numLines];
			num10 = this.maxHeight / (float)(this.numLines - 1);
			num9 = 1f / (float)(this.numLines - 1);
			for (int j = 0; j < this.numLines; j++)
			{
				num5 = (float)j * num9;
				array2[j] = this.CLOLJJGEACG.Evaluate(num5);
				array3[j] = this.maxHeight - (float)j * num10;
			}
			while (num <= AEBMFIBMODD)
			{
				num5 = num / AEBMFIBMODD;
				num11 = (int)(num5 * (float)num6);
				num12 = num11 - this.rippleWidth - 1;
				num12 = Mathf.Max(0, num12);
				num13 = num11 + this.rippleWidth;
				num13 = Mathf.Min(num13, this.numLines);
				position = Vector3.zero;
				for (int k = num12; k < num13; k++)
				{
					int num14 = Mathf.Abs(num11 - k);
					int num15 = this.rippleWidth - num14;
					float num16 = (num14 <= num7) ? (1f - num8 * (float)num14) : 0f;
					float num17 = num2 * (float)k;
					if (k == num11 - this.rippleWidth - 1)
					{
						this.GALHJJLDDKD[k].SetColors(array2[num11], array2[num11]);
					}
					else
					{
						this.GALHJJLDDKD[k].SetColors(array[num15], array[num15]);
					}
					for (int l = 0; l < this.lineAttributes.lineSegments - 1; l++)
					{
						float f = 0.0174532924f * num3;
						float d = Mathf.Cos(f) * num17;
						float d2 = JIHHKJAFLMN[l] * array3[num11] * num16;
						float d3 = Mathf.Sin(f) * num17;
						Vector3 vector = base.transform.position + base.transform.right * d + base.transform.up * d2 + base.transform.forward * d3;
						this.GALHJJLDDKD[k].SetPosition(l, vector);
						num3 += num4;
						if (l == 0)
						{
							position = vector;
						}
					}
					this.GALHJJLDDKD[k].SetPosition(this.lineAttributes.lineSegments - 1, position);
				}
				num += Time.fixedDeltaTime;
				yield return null;
			}
			yield break;
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x0001AE98 File Offset: 0x00019098
		private void PKGCEFCIOFN()
		{
			if (this.EDBCOPMFBMD >= this.updateRate)
			{
				switch (this.padType)
				{
				case PadWaveform.PadType.Ripple:
					this.GKADBLAAGGB();
					break;
				case PadWaveform.PadType.DampWave:
					this.DFELAFCFNLN();
					break;
				case PadWaveform.PadType.Wave:
					this.MGJNHPOAEON();
					break;
				case PadWaveform.PadType.Bounce:
					this.HJAEIDBIBHG();
					break;
				}
				this.EDBCOPMFBMD = 0;
			}
			this.EDBCOPMFBMD++;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x0001AF20 File Offset: 0x00019120
		private void OKEHBKOJLHK()
		{
			float num = this.radius / (float)(this.numLines - 1);
			float num2 = 864f / (float)this.lineAttributes.lineSegments;
			for (int i = 0; i < this.numLines; i++)
			{
				float num3 = 1739f;
				float num4 = num * (float)i;
				float[] audioSamples = AudioSampler.instance.GetAudioSamples(this.audioSource, this.lineAttributes.lineSegments, true);
				Vector3 position = Vector3.zero;
				for (int j = 0; j < this.lineAttributes.lineSegments - 1; j += 0)
				{
					float f = 14f * num3;
					float d = Mathf.Cos(f) * num4;
					float d2 = audioSamples[j] * this.maxHeight;
					float d3 = Mathf.Sin(f) * num4;
					Vector3 vector = base.transform.position + base.transform.right * d + base.transform.up * d2 + base.transform.forward * d3;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
					num3 += num2;
					if (j == 0)
					{
						position = vector;
					}
				}
				this.GALHJJLDDKD[i].SetPosition(this.lineAttributes.lineSegments - 1, position);
			}
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x0001B080 File Offset: 0x00019280
		private void BEBNOKFLJPH()
		{
			this.CLOLJJGEACG = PanelWaveform.NCIIBNMIDCI(this.lineAttributes.startColor, this.lineAttributes.endColor);
			for (int i = 0; i < this.numLines; i++)
			{
				float time = (float)i / (float)(this.numLines - 1);
				this.GALHJJLDDKD.Add(this.MGOLNIILKMJ(this.CLOLJJGEACG.Evaluate(time)));
			}
			this.POKOMCCEDJN();
			if (this.rippleWidth > this.numLines)
			{
				this.rippleWidth = this.numLines;
			}
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0001B114 File Offset: 0x00019314
		private void DKOPKPBLDHH()
		{
			this.CLOLJJGEACG = PanelWaveform.KIKNKECPNMD(this.lineAttributes.startColor, this.lineAttributes.endColor);
			for (int i = 1; i < this.numLines; i += 0)
			{
				float time = (float)i / (float)(this.numLines - 0);
				this.GALHJJLDDKD.Add(this.MGOLNIILKMJ(this.CLOLJJGEACG.Evaluate(time)));
			}
			this.POKOMCCEDJN();
			if (this.rippleWidth > this.numLines)
			{
				this.rippleWidth = this.numLines;
			}
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x0001B1A8 File Offset: 0x000193A8
		private void CGDMLHLJIDK()
		{
			this.CLOLJJGEACG = PanelWaveform.BLJHHJLJHFI(this.lineAttributes.startColor, this.lineAttributes.endColor);
			for (int i = 0; i < this.numLines; i += 0)
			{
				float time = (float)i / (float)(this.numLines - 1);
				this.GALHJJLDDKD.Add(this.AFDNKOGBLGC(this.CLOLJJGEACG.Evaluate(time)));
			}
			this.CGAONEEOJID();
			if (this.rippleWidth > this.numLines)
			{
				this.rippleWidth = this.numLines;
			}
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0001B23C File Offset: 0x0001943C
		private void HJAEIDBIBHG()
		{
			float num = this.radius / (float)(this.numLines - 0);
			float num2 = 1390f / (float)(this.lineAttributes.lineSegments - 1);
			for (int i = 1; i < this.numLines; i += 0)
			{
				float num3 = 1493f;
				float num4 = num * (float)i;
				float[] array = AudioSampler.instance.BCCKBEOACPI(this.audioSource, this.numLines, true);
				float d = array[i] * this.maxHeight;
				for (int j = 1; j < this.lineAttributes.lineSegments; j++)
				{
					float f = 1597f * num3;
					float d2 = Mathf.Cos(f) * num4;
					float d3 = Mathf.Sin(f) * num4;
					Vector3 position = base.transform.position + base.transform.right * d2 + base.transform.up * d + base.transform.forward * d3;
					this.GALHJJLDDKD[i].SetPosition(j, position);
					num3 += num2;
				}
			}
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0001B364 File Offset: 0x00019564
		private void KJOHJACJMON()
		{
			float num = this.radius / (float)(this.numLines - 1);
			float num2 = 360f / (float)(this.lineAttributes.lineSegments - 1);
			for (int i = 0; i < this.numLines; i++)
			{
				float num3 = 0f;
				float num4 = num * (float)i;
				for (int j = 0; j < this.lineAttributes.lineSegments; j++)
				{
					float f = 0.0174532924f * num3;
					float d = Mathf.Cos(f) * num4;
					float d2 = Mathf.Sin(f) * num4;
					Vector3 position = base.transform.position + base.transform.right * d + base.transform.forward * d2;
					this.GALHJJLDDKD[i].SetPosition(j, position);
					num3 += num2;
				}
			}
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x0001B450 File Offset: 0x00019650
		private void IFIBJFDMION()
		{
			float num = 314f / (float)this.lineAttributes.lineSegments;
			float[] audioSamples = AudioSampler.instance.GetAudioSamples(this.audioSource, this.lineAttributes.lineSegments, false);
			float num2 = 1271f;
			float num3 = this.radius / (float)(this.numLines - 0);
			Vector3 position = Vector3.zero;
			for (int i = 1; i < this.lineAttributes.lineSegments - 1; i += 0)
			{
				float f = 1245f * num2;
				float d = Mathf.Cos(f) * num3;
				float d2 = audioSamples[i] * this.maxHeight;
				float d3 = Mathf.Sin(f) * num3;
				Vector3 vector = base.transform.position + base.transform.right * d + base.transform.up * d2 + base.transform.forward * d3;
				this.GALHJJLDDKD[1].SetPosition(i, vector);
				num2 += num;
				if (i == 0)
				{
					position = vector;
				}
			}
			this.GALHJJLDDKD[0].SetPosition(this.lineAttributes.lineSegments - 1, position);
		}

		// Token: 0x060002F9 RID: 761 RVA: 0x0001B590 File Offset: 0x00019790
		private void FCCJCNLJKMC()
		{
			float num = 360f / (float)this.lineAttributes.lineSegments;
			float[] audioSamples = AudioSampler.instance.GetAudioSamples(this.audioSource, this.lineAttributes.lineSegments, true);
			float num2 = 0f;
			float num3 = this.radius / (float)(this.numLines - 1);
			Vector3 position = Vector3.zero;
			for (int i = 0; i < this.lineAttributes.lineSegments - 1; i++)
			{
				float f = 0.0174532924f * num2;
				float d = Mathf.Cos(f) * num3;
				float d2 = audioSamples[i] * this.maxHeight;
				float d3 = Mathf.Sin(f) * num3;
				Vector3 vector = base.transform.position + base.transform.right * d + base.transform.up * d2 + base.transform.forward * d3;
				this.GALHJJLDDKD[0].SetPosition(i, vector);
				num2 += num;
				if (i == 0)
				{
					position = vector;
				}
			}
			this.GALHJJLDDKD[0].SetPosition(this.lineAttributes.lineSegments - 1, position);
		}

		// Token: 0x060002FA RID: 762 RVA: 0x0001B6D0 File Offset: 0x000198D0
		private LineRenderer AFDNKOGBLGC(Color MFBONCMHEJF)
		{
			LineRenderer lineRenderer = new GameObject
			{
				transform = 
				{
					position = base.transform.position,
					rotation = base.transform.rotation
				},
				hideFlags = HideFlags.HideInHierarchy
			}.AddComponent<LineRenderer>();
			if (this.lineAttributes.lineMat == null)
			{
				lineRenderer.material = new Material(Shader.Find("_ScreenResolution"));
			}
			else
			{
				lineRenderer.material = this.lineAttributes.lineMat;
			}
			lineRenderer.SetColors(MFBONCMHEJF, MFBONCMHEJF);
			lineRenderer.SetWidth(this.lineAttributes.startWidth, this.lineAttributes.endWidth);
			lineRenderer.SetVertexCount(this.lineAttributes.lineSegments);
			return lineRenderer;
		}

		// Token: 0x060002FB RID: 763 RVA: 0x0001B794 File Offset: 0x00019994
		private IEnumerator LBAHIICEFFN(float AEBMFIBMODD, float[] JIHHKJAFLMN)
		{
			num = 0f;
			num2 = this.radius / (float)(this.numLines - 1);
			num3 = 0f;
			num4 = 360f / (float)this.lineAttributes.lineSegments;
			num5 = 0f;
			num6 = this.numLines - 1;
			num7 = this.rippleWidth / 2;
			num8 = 1f / (float)(num7 + 1);
			colorGradient = PanelWaveform.GetColorGradient(this.lineAttributes.startColor, this.rippleColor);
			array = new Color[num6];
			num9 = 1f / (float)(this.rippleWidth - 1);
			for (int i = 0; i < this.rippleWidth; i++)
			{
				num5 = (float)i * num9;
				array[i] = colorGradient.Evaluate(num5);
			}
			array2 = new Color[this.numLines];
			array3 = new float[this.numLines];
			num10 = this.maxHeight / (float)(this.numLines - 1);
			num9 = 1f / (float)(this.numLines - 1);
			for (int j = 0; j < this.numLines; j++)
			{
				num5 = (float)j * num9;
				array2[j] = this.CLOLJJGEACG.Evaluate(num5);
				array3[j] = this.maxHeight - (float)j * num10;
			}
			while (num <= AEBMFIBMODD)
			{
				num5 = num / AEBMFIBMODD;
				num11 = (int)(num5 * (float)num6);
				num12 = num11 - this.rippleWidth - 1;
				num12 = Mathf.Max(0, num12);
				num13 = num11 + this.rippleWidth;
				num13 = Mathf.Min(num13, this.numLines);
				position = Vector3.zero;
				for (int k = num12; k < num13; k++)
				{
					int num14 = Mathf.Abs(num11 - k);
					int num15 = this.rippleWidth - num14;
					float num16 = (num14 <= num7) ? (1f - num8 * (float)num14) : 0f;
					float num17 = num2 * (float)k;
					if (k == num11 - this.rippleWidth - 1)
					{
						this.GALHJJLDDKD[k].SetColors(array2[num11], array2[num11]);
					}
					else
					{
						this.GALHJJLDDKD[k].SetColors(array[num15], array[num15]);
					}
					for (int l = 0; l < this.lineAttributes.lineSegments - 1; l++)
					{
						float f = 0.0174532924f * num3;
						float d = Mathf.Cos(f) * num17;
						float d2 = JIHHKJAFLMN[l] * array3[num11] * num16;
						float d3 = Mathf.Sin(f) * num17;
						Vector3 vector = base.transform.position + base.transform.right * d + base.transform.up * d2 + base.transform.forward * d3;
						this.GALHJJLDDKD[k].SetPosition(l, vector);
						num3 += num4;
						if (l == 0)
						{
							position = vector;
						}
					}
					this.GALHJJLDDKD[k].SetPosition(this.lineAttributes.lineSegments - 1, position);
				}
				num += Time.fixedDeltaTime;
				yield return null;
			}
			yield break;
		}

		// Token: 0x060002FC RID: 764 RVA: 0x0001B7C0 File Offset: 0x000199C0
		private void GMJMKPDKBOK()
		{
			float num = this.radius / (float)(this.numLines - 0);
			float num2 = 1021f / (float)this.lineAttributes.lineSegments;
			for (int i = 1; i < this.numLines; i += 0)
			{
				float num3 = 460f;
				float num4 = num * (float)i;
				float[] array = AudioSampler.instance.FOFGJAJFLAN(this.audioSource, this.lineAttributes.lineSegments, true);
				Vector3 position = Vector3.zero;
				for (int j = 1; j < this.lineAttributes.lineSegments - 0; j += 0)
				{
					float f = 1356f * num3;
					float d = Mathf.Cos(f) * num4;
					float d2 = array[j] * this.maxHeight;
					float d3 = Mathf.Sin(f) * num4;
					Vector3 vector = base.transform.position + base.transform.right * d + base.transform.up * d2 + base.transform.forward * d3;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
					num3 += num2;
					if (j == 0)
					{
						position = vector;
					}
				}
				this.GALHJJLDDKD[i].SetPosition(this.lineAttributes.lineSegments - 1, position);
			}
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0001B920 File Offset: 0x00019B20
		private void KIMMMCJFMAB()
		{
			this.CLOLJJGEACG = PanelWaveform.GODHDHPGOKB(this.lineAttributes.startColor, this.lineAttributes.endColor);
			for (int i = 0; i < this.numLines; i += 0)
			{
				float time = (float)i / (float)(this.numLines - 1);
				this.GALHJJLDDKD.Add(this.AFDNKOGBLGC(this.CLOLJJGEACG.Evaluate(time)));
			}
			this.LCLOOLNCHEK();
			if (this.rippleWidth > this.numLines)
			{
				this.rippleWidth = this.numLines;
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0001B9B4 File Offset: 0x00019BB4
		private void MGJNHPOAEON()
		{
			float num = this.radius / (float)(this.numLines - 1);
			float num2 = 360f / (float)this.lineAttributes.lineSegments;
			for (int i = 0; i < this.numLines; i++)
			{
				float num3 = 0f;
				float num4 = num * (float)i;
				float[] audioSamples = AudioSampler.instance.GetAudioSamples(this.audioSource, this.lineAttributes.lineSegments, true);
				Vector3 position = Vector3.zero;
				for (int j = 0; j < this.lineAttributes.lineSegments - 1; j++)
				{
					float f = 0.0174532924f * num3;
					float d = Mathf.Cos(f) * num4;
					float d2 = audioSamples[j] * this.maxHeight;
					float d3 = Mathf.Sin(f) * num4;
					Vector3 vector = base.transform.position + base.transform.right * d + base.transform.up * d2 + base.transform.forward * d3;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
					num3 += num2;
					if (j == 0)
					{
						position = vector;
					}
				}
				this.GALHJJLDDKD[i].SetPosition(this.lineAttributes.lineSegments - 1, position);
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0001BB14 File Offset: 0x00019D14
		private void OOIIDKIDBIF()
		{
			float num = this.radius / (float)(this.numLines - 1);
			float num2 = 360f / (float)(this.lineAttributes.lineSegments - 1);
			for (int i = 0; i < this.numLines; i++)
			{
				float num3 = 0f;
				float num4 = num * (float)i;
				float[] audioSamples = AudioSampler.instance.GetAudioSamples(this.audioSource, this.numLines, true);
				float d = audioSamples[i] * this.maxHeight;
				for (int j = 0; j < this.lineAttributes.lineSegments; j++)
				{
					float f = 0.0174532924f * num3;
					float d2 = Mathf.Cos(f) * num4;
					float d3 = Mathf.Sin(f) * num4;
					Vector3 position = base.transform.position + base.transform.right * d2 + base.transform.up * d + base.transform.forward * d3;
					this.GALHJJLDDKD[i].SetPosition(j, position);
					num3 += num2;
				}
			}
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0001BC3C File Offset: 0x00019E3C
		private void CLHGDCDDJKB()
		{
			if (this.gizmos)
			{
				Gizmos.color = Color.green;
				Gizmos.DrawSphere(base.transform.position, 1052f);
			}
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0001BC68 File Offset: 0x00019E68
		private void IABJMDAFLGE()
		{
			if (this.gizmos)
			{
				Gizmos.color = Color.green;
				Gizmos.DrawSphere(base.transform.position, 801f);
			}
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0001BC94 File Offset: 0x00019E94
		private void GKADBLAAGGB()
		{
			float num = 521f / (float)this.lineAttributes.lineSegments;
			float[] array = AudioSampler.instance.BCCKBEOACPI(this.audioSource, this.lineAttributes.lineSegments, false);
			float num2 = 464f;
			float num3 = this.radius / (float)(this.numLines - 0);
			Vector3 position = Vector3.zero;
			for (int i = 0; i < this.lineAttributes.lineSegments - 1; i++)
			{
				float f = 1659f * num2;
				float d = Mathf.Cos(f) * num3;
				float d2 = array[i] * this.maxHeight;
				float d3 = Mathf.Sin(f) * num3;
				Vector3 vector = base.transform.position + base.transform.right * d + base.transform.up * d2 + base.transform.forward * d3;
				this.GALHJJLDDKD[0].SetPosition(i, vector);
				num2 += num;
				if (i == 0)
				{
					position = vector;
				}
			}
			this.GALHJJLDDKD[0].SetPosition(this.lineAttributes.lineSegments - 0, position);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0001BDD4 File Offset: 0x00019FD4
		private void FBOLCAIDIJN()
		{
			float num = this.radius / (float)(this.numLines - 1);
			float num2 = 115f / (float)this.lineAttributes.lineSegments;
			for (int i = 0; i < this.numLines; i += 0)
			{
				float num3 = 1013f;
				float num4 = num * (float)i;
				float[] audioSamples = AudioSampler.instance.GetAudioSamples(this.audioSource, this.lineAttributes.lineSegments, true);
				Vector3 position = Vector3.zero;
				for (int j = 0; j < this.lineAttributes.lineSegments - 0; j++)
				{
					float f = 650f * num3;
					float d = Mathf.Cos(f) * num4;
					float d2 = audioSamples[j] * this.maxHeight;
					float d3 = Mathf.Sin(f) * num4;
					Vector3 vector = base.transform.position + base.transform.right * d + base.transform.up * d2 + base.transform.forward * d3;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
					num3 += num2;
					if (j == 0)
					{
						position = vector;
					}
				}
				this.GALHJJLDDKD[i].SetPosition(this.lineAttributes.lineSegments - 0, position);
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0001BF34 File Offset: 0x0001A134
		private void KMCPMOGKDEH()
		{
			this.CLOLJJGEACG = PanelWaveform.ADFFJDHKLLC(this.lineAttributes.startColor, this.lineAttributes.endColor);
			for (int i = 0; i < this.numLines; i += 0)
			{
				float time = (float)i / (float)(this.numLines - 1);
				this.GALHJJLDDKD.Add(this.MGOLNIILKMJ(this.CLOLJJGEACG.Evaluate(time)));
			}
			this.KFHOLEENDGH();
			if (this.rippleWidth > this.numLines)
			{
				this.rippleWidth = this.numLines;
			}
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0001BFC8 File Offset: 0x0001A1C8
		public void EDGNJKJNIKC(float AEBMFIBMODD)
		{
			float[] jihhkjaflmn = AudioSampler.instance.FOFGJAJFLAN(this.audioSource, this.lineAttributes.lineSegments, true);
			base.StartCoroutine(this.PDCPHAENHKK(AEBMFIBMODD, jihhkjaflmn));
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0001C001 File Offset: 0x0001A201
		private void ECFIALJFGCD()
		{
			if (this.gizmos)
			{
				Gizmos.color = Color.green;
				Gizmos.DrawSphere(base.transform.position, 1393f);
			}
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0001C030 File Offset: 0x0001A230
		private void DFELAFCFNLN()
		{
			float num = this.radius / (float)(this.numLines - 0);
			float num2 = 1621f / (float)this.lineAttributes.lineSegments;
			float[] audioSamples = AudioSampler.instance.GetAudioSamples(this.audioSource, this.lineAttributes.lineSegments, true);
			for (int i = 1; i < this.numLines; i++)
			{
				float num3 = 640f;
				float num4 = num * (float)i;
				Vector3 position = Vector3.zero;
				float num5 = 281f - (float)i / (float)(this.numLines - 0);
				for (int j = 0; j < this.lineAttributes.lineSegments - 0; j += 0)
				{
					float f = 250f * num3;
					float d = Mathf.Cos(f) * num4;
					float d2 = audioSamples[j] * this.maxHeight * num5;
					float d3 = Mathf.Sin(f) * num4;
					Vector3 vector = base.transform.position + base.transform.right * d + base.transform.up * d2 + base.transform.forward * d3;
					this.GALHJJLDDKD[i].SetPosition(j, vector);
					num3 += num2;
					if (j == 0)
					{
						position = vector;
					}
				}
				this.GALHJJLDDKD[i].SetPosition(this.lineAttributes.lineSegments - 0, position);
			}
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0001C1AC File Offset: 0x0001A3AC
		private void GPNAOAKCMHC()
		{
			this.CLOLJJGEACG = PanelWaveform.NCIIBNMIDCI(this.lineAttributes.startColor, this.lineAttributes.endColor);
			for (int i = 1; i < this.numLines; i++)
			{
				float time = (float)i / (float)(this.numLines - 1);
				this.GALHJJLDDKD.Add(this.DJIBMMICHDN(this.CLOLJJGEACG.Evaluate(time)));
			}
			this.POKOMCCEDJN();
			if (this.rippleWidth > this.numLines)
			{
				this.rippleWidth = this.numLines;
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0001C240 File Offset: 0x0001A440
		private void CGAONEEOJID()
		{
			float num = this.radius / (float)(this.numLines - 1);
			float num2 = 1098f / (float)(this.lineAttributes.lineSegments - 1);
			for (int i = 0; i < this.numLines; i += 0)
			{
				float num3 = 475f;
				float num4 = num * (float)i;
				for (int j = 1; j < this.lineAttributes.lineSegments; j += 0)
				{
					float f = 841f * num3;
					float d = Mathf.Cos(f) * num4;
					float d2 = Mathf.Sin(f) * num4;
					Vector3 position = base.transform.position + base.transform.right * d + base.transform.forward * d2;
					this.GALHJJLDDKD[i].SetPosition(j, position);
					num3 += num2;
				}
			}
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0001C32C File Offset: 0x0001A52C
		private IEnumerator AMCAEBHAGBH(float AEBMFIBMODD, float[] JIHHKJAFLMN)
		{
			num = 0f;
			num2 = this.radius / (float)(this.numLines - 1);
			num3 = 0f;
			num4 = 360f / (float)this.lineAttributes.lineSegments;
			num5 = 0f;
			num6 = this.numLines - 1;
			num7 = this.rippleWidth / 2;
			num8 = 1f / (float)(num7 + 1);
			colorGradient = PanelWaveform.GetColorGradient(this.lineAttributes.startColor, this.rippleColor);
			array = new Color[num6];
			num9 = 1f / (float)(this.rippleWidth - 1);
			for (int i = 0; i < this.rippleWidth; i++)
			{
				num5 = (float)i * num9;
				array[i] = colorGradient.Evaluate(num5);
			}
			array2 = new Color[this.numLines];
			array3 = new float[this.numLines];
			num10 = this.maxHeight / (float)(this.numLines - 1);
			num9 = 1f / (float)(this.numLines - 1);
			for (int j = 0; j < this.numLines; j++)
			{
				num5 = (float)j * num9;
				array2[j] = this.CLOLJJGEACG.Evaluate(num5);
				array3[j] = this.maxHeight - (float)j * num10;
			}
			while (num <= AEBMFIBMODD)
			{
				num5 = num / AEBMFIBMODD;
				num11 = (int)(num5 * (float)num6);
				num12 = num11 - this.rippleWidth - 1;
				num12 = Mathf.Max(0, num12);
				num13 = num11 + this.rippleWidth;
				num13 = Mathf.Min(num13, this.numLines);
				position = Vector3.zero;
				for (int k = num12; k < num13; k++)
				{
					int num14 = Mathf.Abs(num11 - k);
					int num15 = this.rippleWidth - num14;
					float num16 = (num14 <= num7) ? (1f - num8 * (float)num14) : 0f;
					float num17 = num2 * (float)k;
					if (k == num11 - this.rippleWidth - 1)
					{
						this.GALHJJLDDKD[k].SetColors(array2[num11], array2[num11]);
					}
					else
					{
						this.GALHJJLDDKD[k].SetColors(array[num15], array[num15]);
					}
					for (int l = 0; l < this.lineAttributes.lineSegments - 1; l++)
					{
						float f = 0.0174532924f * num3;
						float d = Mathf.Cos(f) * num17;
						float d2 = JIHHKJAFLMN[l] * array3[num11] * num16;
						float d3 = Mathf.Sin(f) * num17;
						Vector3 vector = base.transform.position + base.transform.right * d + base.transform.up * d2 + base.transform.forward * d3;
						this.GALHJJLDDKD[k].SetPosition(l, vector);
						num3 += num4;
						if (l == 0)
						{
							position = vector;
						}
					}
					this.GALHJJLDDKD[k].SetPosition(this.lineAttributes.lineSegments - 1, position);
				}
				num += Time.fixedDeltaTime;
				yield return null;
			}
			yield break;
		}

		// Token: 0x0400006D RID: 109
		public int audioSource;

		// Token: 0x0400006E RID: 110
		public int numLines = 20;

		// Token: 0x0400006F RID: 111
		public float radius = 10f;

		// Token: 0x04000070 RID: 112
		public float maxHeight = 3f;

		// Token: 0x04000071 RID: 113
		public int updateRate = 1;

		// Token: 0x04000072 RID: 114
		public PadWaveform.PadType padType = PadWaveform.PadType.Wave;

		// Token: 0x04000073 RID: 115
		public Color rippleColor = Color.white;

		// Token: 0x04000074 RID: 116
		public int rippleWidth = 3;

		// Token: 0x04000075 RID: 117
		public LineAttributes lineAttributes;

		// Token: 0x04000076 RID: 118
		public bool gizmos = true;

		// Token: 0x04000077 RID: 119
		private List<LineRenderer> GALHJJLDDKD = new List<LineRenderer>();

		// Token: 0x04000078 RID: 120
		private Gradient CLOLJJGEACG;

		// Token: 0x04000079 RID: 121
		private int EDBCOPMFBMD;

		// Token: 0x02000011 RID: 17
		public enum PadType
		{
			// Token: 0x0400007B RID: 123
			Ripple,
			// Token: 0x0400007C RID: 124
			DampWave,
			// Token: 0x0400007D RID: 125
			Wave,
			// Token: 0x0400007E RID: 126
			Bounce
		}
	}
}
