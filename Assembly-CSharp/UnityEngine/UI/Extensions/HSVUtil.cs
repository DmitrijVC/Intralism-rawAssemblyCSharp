using System;
using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000276 RID: 630
	public static class HSVUtil
	{
		// Token: 0x060097A4 RID: 38820 RVA: 0x0036C8BC File Offset: 0x0036AABC
		public static HsvColor ConvertRgbToHsv(Color HABLFKCCKLN)
		{
			return HSVUtil.ConvertRgbToHsv((double)((int)(HABLFKCCKLN.r * 255f)), (double)((int)(HABLFKCCKLN.g * 255f)), (double)((int)(HABLFKCCKLN.b * 255f)));
		}

		// Token: 0x060097A5 RID: 38821 RVA: 0x0036C8F0 File Offset: 0x0036AAF0
		public static HsvColor ConvertRgbToHsv(double BAKIHLJCOEO, double EEINGFCFEGF, double GPHMIAHOGKJ)
		{
			double num = 0.0;
			double num2 = Math.Min(Math.Min(BAKIHLJCOEO, GPHMIAHOGKJ), EEINGFCFEGF);
			double num3 = Math.Max(Math.Max(BAKIHLJCOEO, GPHMIAHOGKJ), EEINGFCFEGF);
			double num4 = num3 - num2;
			double num5;
			if (num3 == 0.0)
			{
				num5 = 0.0;
			}
			else
			{
				num5 = num4 / num3;
			}
			if (num5 == 0.0)
			{
				num = 0.0;
			}
			else
			{
				if (BAKIHLJCOEO == num3)
				{
					num = (GPHMIAHOGKJ - EEINGFCFEGF) / num4;
				}
				else if (GPHMIAHOGKJ == num3)
				{
					num = 2.0 + (EEINGFCFEGF - BAKIHLJCOEO) / num4;
				}
				else if (EEINGFCFEGF == num3)
				{
					num = 4.0 + (BAKIHLJCOEO - GPHMIAHOGKJ) / num4;
				}
				num *= 60.0;
				if (num < 0.0)
				{
					num += 360.0;
				}
			}
			return new HsvColor
			{
				H = num,
				S = num5,
				V = num3 / 255.0
			};
		}

		// Token: 0x060097A6 RID: 38822 RVA: 0x0036CA07 File Offset: 0x0036AC07
		public static Color ConvertHsvToRgb(HsvColor HABLFKCCKLN)
		{
			return HSVUtil.ConvertHsvToRgb(HABLFKCCKLN.H, HABLFKCCKLN.S, HABLFKCCKLN.V);
		}

		// Token: 0x060097A7 RID: 38823 RVA: 0x0036CA24 File Offset: 0x0036AC24
		public static Color ConvertHsvToRgb(double BIGJAJHLLPH, double BDIMLMKEEKO, double AIEJPEPBAEJ)
		{
			double num;
			double num2;
			double num3;
			if (BDIMLMKEEKO == 0.0)
			{
				num = AIEJPEPBAEJ;
				num2 = AIEJPEPBAEJ;
				num3 = AIEJPEPBAEJ;
			}
			else
			{
				if (BIGJAJHLLPH == 360.0)
				{
					BIGJAJHLLPH = 0.0;
				}
				else
				{
					BIGJAJHLLPH /= 60.0;
				}
				int num4 = (int)BIGJAJHLLPH;
				double num5 = BIGJAJHLLPH - (double)num4;
				double num6 = AIEJPEPBAEJ * (1.0 - BDIMLMKEEKO);
				double num7 = AIEJPEPBAEJ * (1.0 - BDIMLMKEEKO * num5);
				double num8 = AIEJPEPBAEJ * (1.0 - BDIMLMKEEKO * (1.0 - num5));
				switch (num4)
				{
				case 0:
					num = AIEJPEPBAEJ;
					num2 = num8;
					num3 = num6;
					break;
				case 1:
					num = num7;
					num2 = AIEJPEPBAEJ;
					num3 = num6;
					break;
				case 2:
					num = num6;
					num2 = AIEJPEPBAEJ;
					num3 = num8;
					break;
				case 3:
					num = num6;
					num2 = num7;
					num3 = AIEJPEPBAEJ;
					break;
				case 4:
					num = num8;
					num2 = num6;
					num3 = AIEJPEPBAEJ;
					break;
				default:
					num = AIEJPEPBAEJ;
					num2 = num6;
					num3 = num7;
					break;
				}
			}
			return new Color((float)num, (float)num2, (float)num3, 1f);
		}

		// Token: 0x060097A8 RID: 38824 RVA: 0x0036CB58 File Offset: 0x0036AD58
		public static List<Color> GenerateHsvSpectrum()
		{
			List<Color> list = new List<Color>(8);
			for (int i = 0; i < 359; i++)
			{
				list.Add(HSVUtil.ConvertHsvToRgb((double)i, 1.0, 1.0));
			}
			list.Add(HSVUtil.ConvertHsvToRgb(0.0, 1.0, 1.0));
			return list;
		}

		// Token: 0x060097A9 RID: 38825 RVA: 0x0036CBC8 File Offset: 0x0036ADC8
		public static Texture2D GenerateHSVTexture(int CJDDBGPKDLP, int PBMAGEKDPLI)
		{
			List<Color> list = HSVUtil.GenerateHsvSpectrum();
			float num = 1f;
			if (list.Count > PBMAGEKDPLI)
			{
				num = (float)list.Count / (float)PBMAGEKDPLI;
			}
			Texture2D texture2D = new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI);
			int num2 = Mathf.Max(1, (int)(1f / ((float)list.Count / num) * (float)PBMAGEKDPLI));
			int num3 = 0;
			Color color = Color.white;
			for (float num4 = 0f; num4 < (float)list.Count; num4 += num)
			{
				color = list[(int)num4];
				Color[] array = new Color[CJDDBGPKDLP * num2];
				for (int i = 0; i < CJDDBGPKDLP * num2; i++)
				{
					array[i] = color;
				}
				if (num3 < PBMAGEKDPLI)
				{
					texture2D.SetPixels(0, num3, CJDDBGPKDLP, num2, array);
				}
				num3 += num2;
			}
			texture2D.Apply();
			return texture2D;
		}

		// Token: 0x060097AA RID: 38826 RVA: 0x0036CCA4 File Offset: 0x0036AEA4
		public static Texture2D GenerateColorTexture(Color JBDEDFFOLMI, Texture2D COKJKFECOOG)
		{
			int width = COKJKFECOOG.width;
			int height = COKJKFECOOG.height;
			HsvColor hsvColor = HSVUtil.ConvertRgbToHsv((double)((int)(JBDEDFFOLMI.r * 255f)), (double)((int)(JBDEDFFOLMI.g * 255f)), (double)((int)(JBDEDFFOLMI.b * 255f)));
			for (int i = 0; i < height; i++)
			{
				for (int j = 0; j < width; j++)
				{
					HsvColor hsvColor2 = hsvColor;
					hsvColor2.V = (double)((float)i / (float)height);
					hsvColor2.S = (double)((float)j / (float)width);
					Color color = HSVUtil.ConvertHsvToRgb(hsvColor2.H, hsvColor2.S, hsvColor2.V);
					COKJKFECOOG.SetPixel(j, i, color);
				}
			}
			COKJKFECOOG.Apply();
			return COKJKFECOOG;
		}

		// Token: 0x060097AB RID: 38827 RVA: 0x0036CD66 File Offset: 0x0036AF66
		public static Texture2D GenerateColorTexture(int CJDDBGPKDLP, int PBMAGEKDPLI, Color JBDEDFFOLMI)
		{
			return HSVUtil.GenerateColorTexture(JBDEDFFOLMI, new Texture2D(CJDDBGPKDLP, PBMAGEKDPLI));
		}
	}
}
