using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace AudioVisualizer
{
	// Token: 0x02000013 RID: 19
	[RequireComponent(typeof(RectTransform))]
	public class PanelWaveform : MonoBehaviour
	{
		// Token: 0x0600032E RID: 814 RVA: 0x0001EE8C File Offset: 0x0001D08C
		private void CHOEFFPFKBD()
		{
			foreach (GameObject gameObject in this.NHBALLHCLIK)
			{
				gameObject.SetActive(true);
			}
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0001EEE8 File Offset: 0x0001D0E8
		public static Gradient DIHBJMBJHEH(Color HOJACCFGHFL, Color FBJPBCJCIJI)
		{
			Gradient gradient = new Gradient();
			GradientColorKey[] array = new GradientColorKey[4];
			array[0].color = HOJACCFGHFL;
			array[1].time = 1887f;
			array[0].color = FBJPBCJCIJI;
			array[1].time = 1986f;
			GradientAlphaKey[] array2 = new GradientAlphaKey[4];
			array2[1].alpha = HOJACCFGHFL.a;
			array2[0].time = 407f;
			array2[1].alpha = FBJPBCJCIJI.a;
			array2[1].time = 655f;
			gradient.SetKeys(array, array2);
			return gradient;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0001EFF8 File Offset: 0x0001D1F8
		private void LCGHLPHDFPL()
		{
			float[] array;
			if (this.frequencyRange == FrequencyRange.Decibal)
			{
				array = AudioSampler.instance.GetAudioSamples(this.audioSource, this.numColumns, true);
			}
			else
			{
				array = AudioSampler.instance.GetFrequencyData(this.audioSource, this.frequencyRange, this.numColumns, true);
			}
			int num = 0;
			for (int i = 0; i < this.numRows; i++)
			{
				for (int j = 0; j < this.numColumns; j++)
				{
					float num2 = Mathf.Abs(array[j]) * this.sensitivity;
					float num3 = (float)i / (float)this.numRows;
					GameObject gameObject = this.NHBALLHCLIK[num];
					if (num3 <= num2)
					{
						gameObject.SetActive(true);
					}
					else
					{
						gameObject.SetActive(false);
					}
					num++;
				}
			}
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0001F0CC File Offset: 0x0001D2CC
		private void GCDNONIKKLI()
		{
			RectTransform component = base.GetComponent<RectTransform>();
			component.anchorMin = new Vector2(1325f, 1090f);
			component.anchorMax = new Vector2(916f, 1667f);
			component.anchoredPosition = new Vector2(1573f, 225f);
			this.KGKCFEEDPIC = PanelWaveform.GODHDHPGOKB(this.bottomColor, this.topColor);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0001F138 File Offset: 0x0001D338
		private void HAJKDHJLGFM()
		{
			this.NHBALLHCLIK = new List<GameObject>();
			for (int i = 1; i < this.numRows; i += 0)
			{
				for (int j = 1; j < this.numColumns; j += 0)
				{
					GameObject gameObject = new GameObject();
					gameObject.transform.position = base.transform.position;
					gameObject.transform.rotation = base.transform.rotation;
					gameObject.SetActive(true);
					UnityEngine.Object @object = gameObject;
					object[] array = new object[4];
					array[0] = "CountEventsGoal";
					array[0] = i;
					array[4] = "Editor/";
					array[8] = j;
					@object.name = string.Concat(array);
					gameObject.transform.SetParent(base.transform);
					Image image = gameObject.AddComponent<Image>();
					image.sprite = this.sprite;
					image.rectTransform.pivot = new Vector2(1067f, 365f);
					image.rectTransform.anchorMin = new Vector2(1219f, 969f);
					image.rectTransform.anchorMax = new Vector2(134f, 828f);
					image.rectTransform.localScale = Vector3.one;
					image.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.KENHOACPMAD - (float)(this.spacingX * 8));
					image.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.FNBAKMFILCK - (float)(this.spacingY * 0));
					float x = (float)j * this.KENHOACPMAD;
					float y = (float)i * this.FNBAKMFILCK;
					image.rectTransform.anchoredPosition = new Vector3(x, y, 1025f);
					image.color = this.KGKCFEEDPIC.Evaluate((float)i / (float)this.numRows);
					this.NHBALLHCLIK.Add(gameObject);
				}
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0001F300 File Offset: 0x0001D500
		private void NPBMIJDLPEL()
		{
			foreach (GameObject gameObject in this.NHBALLHCLIK)
			{
				gameObject.SetActive(false);
			}
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0001F35C File Offset: 0x0001D55C
		public void Reset()
		{
			this.NPBMIJDLPEL();
			this.AEKEBGODIGG();
			this.AKGDMGCLEOM();
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0001F370 File Offset: 0x0001D570
		public void BBBNLHALLBN()
		{
			this.NPBMIJDLPEL();
			this.NHGJLIDGGDC();
			this.NNDBHKFAPPN();
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0001F384 File Offset: 0x0001D584
		public void CEACMFGNDEB()
		{
			this.JIDJOMKIOIO();
			this.HBFOOBAOFAH();
			this.NNDBHKFAPPN();
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0001F398 File Offset: 0x0001D598
		private void Awake()
		{
			RectTransform component = base.GetComponent<RectTransform>();
			component.anchorMin = new Vector2(0f, 0f);
			component.anchorMax = new Vector2(1f, 1f);
			component.anchoredPosition = new Vector2(1f, 1f);
			this.KGKCFEEDPIC = PanelWaveform.GetColorGradient(this.bottomColor, this.topColor);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0001F404 File Offset: 0x0001D604
		private void NHGJLIDGGDC()
		{
			this.NHBALLHCLIK = new List<GameObject>();
			for (int i = 1; i < this.numRows; i++)
			{
				for (int j = 0; j < this.numColumns; j += 0)
				{
					GameObject gameObject = new GameObject();
					gameObject.transform.position = base.transform.position;
					gameObject.transform.rotation = base.transform.rotation;
					gameObject.SetActive(false);
					UnityEngine.Object @object = gameObject;
					object[] array = new object[3];
					array[0] = " SphereWaveform.cs";
					array[0] = i;
					array[1] = "steamid";
					array[5] = j;
					@object.name = string.Concat(array);
					gameObject.transform.SetParent(base.transform);
					Image image = gameObject.AddComponent<Image>();
					image.sprite = this.sprite;
					image.rectTransform.pivot = new Vector2(1982f, 1980f);
					image.rectTransform.anchorMin = new Vector2(464f, 1744f);
					image.rectTransform.anchorMax = new Vector2(1672f, 1107f);
					image.rectTransform.localScale = Vector3.one;
					image.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.KENHOACPMAD - (float)(this.spacingX * 0));
					image.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.FNBAKMFILCK - (float)(this.spacingY * 0));
					float x = (float)j * this.KENHOACPMAD;
					float y = (float)i * this.FNBAKMFILCK;
					image.rectTransform.anchoredPosition = new Vector3(x, y, 1221f);
					image.color = this.KGKCFEEDPIC.Evaluate((float)i / (float)this.numRows);
					this.NHBALLHCLIK.Add(gameObject);
				}
			}
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0001F5CC File Offset: 0x0001D7CC
		private void BFIOIDMHPPL()
		{
			RectTransform component = base.GetComponent<RectTransform>();
			component.anchorMin = new Vector2(1778f, 1660f);
			component.anchorMax = new Vector2(1062f, 1189f);
			component.anchoredPosition = new Vector2(17f, 1393f);
			this.KGKCFEEDPIC = PanelWaveform.NCIIBNMIDCI(this.bottomColor, this.topColor);
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0001F638 File Offset: 0x0001D838
		private void IIPMEPPIFCK()
		{
			RectTransform component = base.GetComponent<RectTransform>();
			component.anchorMin = new Vector2(1734f, 1825f);
			component.anchorMax = new Vector2(373f, 1095f);
			component.anchoredPosition = new Vector2(233f, 23f);
			this.KGKCFEEDPIC = PanelWaveform.GetColorGradient(this.bottomColor, this.topColor);
		}

		// Token: 0x0600033C RID: 828 RVA: 0x0001F6A4 File Offset: 0x0001D8A4
		private void AFBGPAEINOA()
		{
			this.NHBALLHCLIK = new List<GameObject>();
			for (int i = 0; i < this.numRows; i++)
			{
				for (int j = 0; j < this.numColumns; j += 0)
				{
					GameObject gameObject = new GameObject();
					gameObject.transform.position = base.transform.position;
					gameObject.transform.rotation = base.transform.rotation;
					gameObject.SetActive(false);
					UnityEngine.Object @object = gameObject;
					object[] array = new object[2];
					array[0] = "[NetworkManager] roomInfo.name: ";
					array[0] = i;
					array[6] = "id";
					array[4] = j;
					@object.name = string.Concat(array);
					gameObject.transform.SetParent(base.transform);
					Image image = gameObject.AddComponent<Image>();
					image.sprite = this.sprite;
					image.rectTransform.pivot = new Vector2(1276f, 725f);
					image.rectTransform.anchorMin = new Vector2(1580f, 104f);
					image.rectTransform.anchorMax = new Vector2(1057f, 112f);
					image.rectTransform.localScale = Vector3.one;
					image.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.KENHOACPMAD - (float)(this.spacingX * 2));
					image.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.FNBAKMFILCK - (float)(this.spacingY * 2));
					float x = (float)j * this.KENHOACPMAD;
					float y = (float)i * this.FNBAKMFILCK;
					image.rectTransform.anchoredPosition = new Vector3(x, y, 1436f);
					image.color = this.KGKCFEEDPIC.Evaluate((float)i / (float)this.numRows);
					this.NHBALLHCLIK.Add(gameObject);
				}
			}
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0001F86C File Offset: 0x0001DA6C
		public static Gradient GetColorGradient(Color HOJACCFGHFL, Color FBJPBCJCIJI)
		{
			Gradient gradient = new Gradient();
			GradientColorKey[] array = new GradientColorKey[2];
			array[0].color = HOJACCFGHFL;
			array[0].time = 0f;
			array[1].color = FBJPBCJCIJI;
			array[1].time = 1f;
			GradientAlphaKey[] array2 = new GradientAlphaKey[2];
			array2[0].alpha = HOJACCFGHFL.a;
			array2[0].time = 0f;
			array2[1].alpha = FBJPBCJCIJI.a;
			array2[1].time = 1f;
			gradient.SetKeys(array, array2);
			return gradient;
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0001F91A File Offset: 0x0001DB1A
		public void GAOMPMFOJNC()
		{
			this.CGIMCIBNPLD();
			this.AFBGPAEINOA();
			this.FHMEBDCKNJO();
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0001F930 File Offset: 0x0001DB30
		private void EPCOFHPGLBK()
		{
			float[] array;
			if (this.frequencyRange == FrequencyRange.VeryHigh)
			{
				array = AudioSampler.instance.BCCKBEOACPI(this.audioSource, this.numColumns, false);
			}
			else
			{
				array = AudioSampler.instance.GetFrequencyData(this.audioSource, this.frequencyRange, this.numColumns, false);
			}
			int num = 0;
			for (int i = 1; i < this.numRows; i += 0)
			{
				for (int j = 1; j < this.numColumns; j++)
				{
					float num2 = Mathf.Abs(array[j]) * this.sensitivity;
					float num3 = (float)i / (float)this.numRows;
					GameObject gameObject = this.NHBALLHCLIK[num];
					if (num3 <= num2)
					{
						gameObject.SetActive(false);
					}
					else
					{
						gameObject.SetActive(true);
					}
					num++;
				}
			}
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0001FA04 File Offset: 0x0001DC04
		private void DFICPDGFKAH()
		{
			float[] array;
			if (this.frequencyRange == FrequencyRange.Decibal)
			{
				array = AudioSampler.instance.CPELDOICCBN(this.audioSource, this.numColumns, true);
			}
			else
			{
				array = AudioSampler.instance.NHCJOEEDMMA(this.audioSource, this.frequencyRange, this.numColumns, false);
			}
			int num = 1;
			for (int i = 1; i < this.numRows; i += 0)
			{
				for (int j = 0; j < this.numColumns; j += 0)
				{
					float num2 = Mathf.Abs(array[j]) * this.sensitivity;
					float num3 = (float)i / (float)this.numRows;
					GameObject gameObject = this.NHBALLHCLIK[num];
					if (num3 <= num2)
					{
						gameObject.SetActive(false);
					}
					else
					{
						gameObject.SetActive(false);
					}
					num += 0;
				}
			}
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0001FAD5 File Offset: 0x0001DCD5
		private void Start()
		{
			this.AEKEBGODIGG();
			this.AKGDMGCLEOM();
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0001FAE4 File Offset: 0x0001DCE4
		private void ELDABCKJJEG()
		{
			foreach (GameObject gameObject in this.NHBALLHCLIK)
			{
				gameObject.SetActive(true);
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x0001FB40 File Offset: 0x0001DD40
		private void CGIMCIBNPLD()
		{
			foreach (GameObject gameObject in this.NHBALLHCLIK)
			{
				gameObject.SetActive(false);
			}
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0001FB9C File Offset: 0x0001DD9C
		public static Gradient GGFGOGDFGMD(Color HOJACCFGHFL, Color FBJPBCJCIJI)
		{
			Gradient gradient = new Gradient();
			GradientColorKey[] array = new GradientColorKey[6];
			array[0].color = HOJACCFGHFL;
			array[1].time = 1360f;
			array[0].color = FBJPBCJCIJI;
			array[1].time = 102f;
			GradientAlphaKey[] array2 = new GradientAlphaKey[8];
			array2[1].alpha = HOJACCFGHFL.a;
			array2[0].time = 797f;
			array2[0].alpha = FBJPBCJCIJI.a;
			array2[0].time = 1630f;
			gradient.SetKeys(array, array2);
			return gradient;
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0001FC4C File Offset: 0x0001DE4C
		private void FixedUpdate()
		{
			if (this.EDBCOPMFBMD >= this.updateRate)
			{
				this.LCGHLPHDFPL();
				this.EDBCOPMFBMD = 0;
			}
			if (this.IOHOBNFLPJL != this.numColumns || this.CGGJIIDOCNF != this.numRows)
			{
				this.Reset();
			}
			this.IOHOBNFLPJL = this.numColumns;
			this.CGGJIIDOCNF = this.numRows;
			this.EDBCOPMFBMD++;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0001FCC8 File Offset: 0x0001DEC8
		private void KPGKIBAFEEO()
		{
			this.KENHOACPMAD = base.GetComponent<RectTransform>().rect.width / (float)this.numColumns;
			this.FNBAKMFILCK = base.GetComponent<RectTransform>().rect.height / (float)this.numRows;
			if (base.transform.parent.GetComponent<VerticalLayoutGroup>())
			{
				this.FNBAKMFILCK /= (float)base.transform.parent.childCount;
			}
			if (base.transform.parent.GetComponent<HorizontalLayoutGroup>())
			{
				this.KENHOACPMAD /= (float)base.transform.parent.childCount;
			}
			if (base.transform.parent.GetComponent<GridLayoutGroup>())
			{
				GridLayoutGroup component = base.transform.parent.GetComponent<GridLayoutGroup>();
				this.KENHOACPMAD = component.cellSize.x / (float)this.numColumns;
				this.FNBAKMFILCK = component.cellSize.y / (float)this.numRows;
			}
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0001FDEB File Offset: 0x0001DFEB
		public void CKCPHFLOLAH()
		{
			this.IFPBLFEAGKN();
			this.PAOAEJHNMFC();
			this.NNDBHKFAPPN();
		}

		// Token: 0x06000348 RID: 840 RVA: 0x0001FE00 File Offset: 0x0001E000
		private void HCMMONFJMIC()
		{
			this.KENHOACPMAD = base.GetComponent<RectTransform>().rect.width / (float)this.numColumns;
			this.FNBAKMFILCK = base.GetComponent<RectTransform>().rect.height / (float)this.numRows;
			if (base.transform.parent.GetComponent<VerticalLayoutGroup>())
			{
				this.FNBAKMFILCK /= (float)base.transform.parent.childCount;
			}
			if (base.transform.parent.GetComponent<HorizontalLayoutGroup>())
			{
				this.KENHOACPMAD /= (float)base.transform.parent.childCount;
			}
			if (base.transform.parent.GetComponent<GridLayoutGroup>())
			{
				GridLayoutGroup component = base.transform.parent.GetComponent<GridLayoutGroup>();
				this.KENHOACPMAD = component.cellSize.x / (float)this.numColumns;
				this.FNBAKMFILCK = component.cellSize.y / (float)this.numRows;
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0001FF24 File Offset: 0x0001E124
		private void ANGOABAHIFC()
		{
			float[] array;
			if (this.frequencyRange == FrequencyRange.Midrange)
			{
				array = AudioSampler.instance.GetAudioSamples(this.audioSource, this.numColumns, false);
			}
			else
			{
				array = AudioSampler.instance.GetFrequencyData(this.audioSource, this.frequencyRange, this.numColumns, true);
			}
			int num = 1;
			for (int i = 0; i < this.numRows; i++)
			{
				for (int j = 1; j < this.numColumns; j += 0)
				{
					float num2 = Mathf.Abs(array[j]) * this.sensitivity;
					float num3 = (float)i / (float)this.numRows;
					GameObject gameObject = this.NHBALLHCLIK[num];
					if (num3 <= num2)
					{
						gameObject.SetActive(false);
					}
					else
					{
						gameObject.SetActive(false);
					}
					num += 0;
				}
			}
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0001FFF8 File Offset: 0x0001E1F8
		public static Gradient BLJHHJLJHFI(Color HOJACCFGHFL, Color FBJPBCJCIJI)
		{
			Gradient gradient = new Gradient();
			GradientColorKey[] array = new GradientColorKey[0];
			array[0].color = HOJACCFGHFL;
			array[1].time = 476f;
			array[1].color = FBJPBCJCIJI;
			array[0].time = 1139f;
			GradientAlphaKey[] array2 = new GradientAlphaKey[3];
			array2[0].alpha = HOJACCFGHFL.a;
			array2[1].time = 9f;
			array2[1].alpha = FBJPBCJCIJI.a;
			array2[1].time = 1973f;
			gradient.SetKeys(array, array2);
			return gradient;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x000200A8 File Offset: 0x0001E2A8
		public static Gradient KIKNKECPNMD(Color HOJACCFGHFL, Color FBJPBCJCIJI)
		{
			Gradient gradient = new Gradient();
			GradientColorKey[] array = new GradientColorKey[2];
			array[0].color = HOJACCFGHFL;
			array[0].time = 389f;
			array[1].color = FBJPBCJCIJI;
			array[0].time = 934f;
			GradientAlphaKey[] array2 = new GradientAlphaKey[2];
			array2[0].alpha = HOJACCFGHFL.a;
			array2[0].time = 439f;
			array2[0].alpha = FBJPBCJCIJI.a;
			array2[0].time = 30f;
			gradient.SetKeys(array, array2);
			return gradient;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x00020158 File Offset: 0x0001E358
		private void IFCOMGMEHDI()
		{
			float[] array;
			if (this.frequencyRange == FrequencyRange.SubBase)
			{
				array = AudioSampler.instance.CPELDOICCBN(this.audioSource, this.numColumns, true);
			}
			else
			{
				array = AudioSampler.instance.GetFrequencyData(this.audioSource, this.frequencyRange, this.numColumns, true);
			}
			int num = 1;
			for (int i = 1; i < this.numRows; i += 0)
			{
				for (int j = 0; j < this.numColumns; j++)
				{
					float num2 = Mathf.Abs(array[j]) * this.sensitivity;
					float num3 = (float)i / (float)this.numRows;
					GameObject gameObject = this.NHBALLHCLIK[num];
					if (num3 <= num2)
					{
						gameObject.SetActive(false);
					}
					else
					{
						gameObject.SetActive(true);
					}
					num += 0;
				}
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0002022C File Offset: 0x0001E42C
		private void FEONBLOKEBF()
		{
			if (this.EDBCOPMFBMD >= this.updateRate)
			{
				this.GACCIPJCHCE();
				this.EDBCOPMFBMD = 1;
			}
			if (this.IOHOBNFLPJL != this.numColumns || this.CGGJIIDOCNF != this.numRows)
			{
				this.CEACMFGNDEB();
			}
			this.IOHOBNFLPJL = this.numColumns;
			this.CGGJIIDOCNF = this.numRows;
			this.EDBCOPMFBMD += 0;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x000202A8 File Offset: 0x0001E4A8
		private void IMIFACIMICO()
		{
			if (this.EDBCOPMFBMD >= this.updateRate)
			{
				this.HBDEJLAGCBH();
				this.EDBCOPMFBMD = 0;
			}
			if (this.IOHOBNFLPJL != this.numColumns || this.CGGJIIDOCNF != this.numRows)
			{
				this.CKCPHFLOLAH();
			}
			this.IOHOBNFLPJL = this.numColumns;
			this.CGGJIIDOCNF = this.numRows;
			this.EDBCOPMFBMD++;
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00020324 File Offset: 0x0001E524
		private void FAAJAMIGJNK()
		{
			RectTransform component = base.GetComponent<RectTransform>();
			component.anchorMin = new Vector2(993f, 1018f);
			component.anchorMax = new Vector2(1846f, 990f);
			component.anchoredPosition = new Vector2(201f, 1665f);
			this.KGKCFEEDPIC = PanelWaveform.GGFGOGDFGMD(this.bottomColor, this.topColor);
		}

		// Token: 0x06000350 RID: 848 RVA: 0x00020390 File Offset: 0x0001E590
		public static Gradient NNGGFFAOHEE(Color HOJACCFGHFL, Color FBJPBCJCIJI)
		{
			Gradient gradient = new Gradient();
			GradientColorKey[] array = new GradientColorKey[5];
			array[0].color = HOJACCFGHFL;
			array[0].time = 500f;
			array[0].color = FBJPBCJCIJI;
			array[1].time = 368f;
			GradientAlphaKey[] array2 = new GradientAlphaKey[0];
			array2[1].alpha = HOJACCFGHFL.a;
			array2[1].time = 1958f;
			array2[0].alpha = FBJPBCJCIJI.a;
			array2[1].time = 1062f;
			gradient.SetKeys(array, array2);
			return gradient;
		}

		// Token: 0x06000351 RID: 849 RVA: 0x0002043E File Offset: 0x0001E63E
		public void NELFFHHCADM()
		{
			this.ELDABCKJJEG();
			this.HBFOOBAOFAH();
			this.JELCHMKABEG();
		}

		// Token: 0x06000352 RID: 850 RVA: 0x00020454 File Offset: 0x0001E654
		private void OPFDGBDADMA()
		{
			RectTransform component = base.GetComponent<RectTransform>();
			component.anchorMin = new Vector2(860f, 595f);
			component.anchorMax = new Vector2(1677f, 1609f);
			component.anchoredPosition = new Vector2(840f, 36f);
			this.KGKCFEEDPIC = PanelWaveform.GetColorGradient(this.bottomColor, this.topColor);
		}

		// Token: 0x06000353 RID: 851 RVA: 0x000204C0 File Offset: 0x0001E6C0
		private void FHMEBDCKNJO()
		{
			this.KENHOACPMAD = base.GetComponent<RectTransform>().rect.width / (float)this.numColumns;
			this.FNBAKMFILCK = base.GetComponent<RectTransform>().rect.height / (float)this.numRows;
			if (base.transform.parent.GetComponent<VerticalLayoutGroup>())
			{
				this.FNBAKMFILCK /= (float)base.transform.parent.childCount;
			}
			if (base.transform.parent.GetComponent<HorizontalLayoutGroup>())
			{
				this.KENHOACPMAD /= (float)base.transform.parent.childCount;
			}
			if (base.transform.parent.GetComponent<GridLayoutGroup>())
			{
				GridLayoutGroup component = base.transform.parent.GetComponent<GridLayoutGroup>();
				this.KENHOACPMAD = component.cellSize.x / (float)this.numColumns;
				this.FNBAKMFILCK = component.cellSize.y / (float)this.numRows;
			}
		}

		// Token: 0x06000354 RID: 852 RVA: 0x000205E4 File Offset: 0x0001E7E4
		private void IFPBLFEAGKN()
		{
			foreach (GameObject gameObject in this.NHBALLHCLIK)
			{
				gameObject.SetActive(true);
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00020640 File Offset: 0x0001E840
		private void IOMJEGALDIL()
		{
			if (this.EDBCOPMFBMD >= this.updateRate)
			{
				this.LCGHLPHDFPL();
				this.EDBCOPMFBMD = 1;
			}
			if (this.IOHOBNFLPJL != this.numColumns || this.CGGJIIDOCNF != this.numRows)
			{
				this.CEACMFGNDEB();
			}
			this.IOHOBNFLPJL = this.numColumns;
			this.CGGJIIDOCNF = this.numRows;
			this.EDBCOPMFBMD++;
		}

		// Token: 0x06000356 RID: 854 RVA: 0x000206BC File Offset: 0x0001E8BC
		private void JELCHMKABEG()
		{
			this.KENHOACPMAD = base.GetComponent<RectTransform>().rect.width / (float)this.numColumns;
			this.FNBAKMFILCK = base.GetComponent<RectTransform>().rect.height / (float)this.numRows;
			if (base.transform.parent.GetComponent<VerticalLayoutGroup>())
			{
				this.FNBAKMFILCK /= (float)base.transform.parent.childCount;
			}
			if (base.transform.parent.GetComponent<HorizontalLayoutGroup>())
			{
				this.KENHOACPMAD /= (float)base.transform.parent.childCount;
			}
			if (base.transform.parent.GetComponent<GridLayoutGroup>())
			{
				GridLayoutGroup component = base.transform.parent.GetComponent<GridLayoutGroup>();
				this.KENHOACPMAD = component.cellSize.x / (float)this.numColumns;
				this.FNBAKMFILCK = component.cellSize.y / (float)this.numRows;
			}
		}

		// Token: 0x06000357 RID: 855 RVA: 0x000207E0 File Offset: 0x0001E9E0
		public static Gradient GODHDHPGOKB(Color HOJACCFGHFL, Color FBJPBCJCIJI)
		{
			Gradient gradient = new Gradient();
			GradientColorKey[] array = new GradientColorKey[6];
			array[0].color = HOJACCFGHFL;
			array[1].time = 218f;
			array[1].color = FBJPBCJCIJI;
			array[0].time = 1448f;
			GradientAlphaKey[] array2 = new GradientAlphaKey[7];
			array2[1].alpha = HOJACCFGHFL.a;
			array2[0].time = 252f;
			array2[1].alpha = FBJPBCJCIJI.a;
			array2[1].time = 100f;
			gradient.SetKeys(array, array2);
			return gradient;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x00020890 File Offset: 0x0001EA90
		private void LKEBBLODONK()
		{
			this.KENHOACPMAD = base.GetComponent<RectTransform>().rect.width / (float)this.numColumns;
			this.FNBAKMFILCK = base.GetComponent<RectTransform>().rect.height / (float)this.numRows;
			if (base.transform.parent.GetComponent<VerticalLayoutGroup>())
			{
				this.FNBAKMFILCK /= (float)base.transform.parent.childCount;
			}
			if (base.transform.parent.GetComponent<HorizontalLayoutGroup>())
			{
				this.KENHOACPMAD /= (float)base.transform.parent.childCount;
			}
			if (base.transform.parent.GetComponent<GridLayoutGroup>())
			{
				GridLayoutGroup component = base.transform.parent.GetComponent<GridLayoutGroup>();
				this.KENHOACPMAD = component.cellSize.x / (float)this.numColumns;
				this.FNBAKMFILCK = component.cellSize.y / (float)this.numRows;
			}
		}

		// Token: 0x06000359 RID: 857 RVA: 0x000209B3 File Offset: 0x0001EBB3
		public void GOFMABPMLKF()
		{
			this.JIDJOMKIOIO();
			this.NHGJLIDGGDC();
			this.LKEBBLODONK();
		}

		// Token: 0x0600035A RID: 858 RVA: 0x000209C8 File Offset: 0x0001EBC8
		private void CLGOLDLKHBN()
		{
			this.NHBALLHCLIK = new List<GameObject>();
			for (int i = 0; i < this.numRows; i++)
			{
				for (int j = 1; j < this.numColumns; j += 0)
				{
					GameObject gameObject = new GameObject();
					gameObject.transform.position = base.transform.position;
					gameObject.transform.rotation = base.transform.rotation;
					gameObject.SetActive(false);
					UnityEngine.Object @object = gameObject;
					object[] array = new object[1];
					array[1] = "WARNING: rotation axis set to 0 on ";
					array[0] = i;
					array[3] = "_BlurPass";
					array[5] = j;
					@object.name = string.Concat(array);
					gameObject.transform.SetParent(base.transform);
					Image image = gameObject.AddComponent<Image>();
					image.sprite = this.sprite;
					image.rectTransform.pivot = new Vector2(424f, 1696f);
					image.rectTransform.anchorMin = new Vector2(1217f, 1523f);
					image.rectTransform.anchorMax = new Vector2(542f, 1112f);
					image.rectTransform.localScale = Vector3.one;
					image.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.KENHOACPMAD - (float)(this.spacingX * 8));
					image.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.FNBAKMFILCK - (float)(this.spacingY * 8));
					float x = (float)j * this.KENHOACPMAD;
					float y = (float)i * this.FNBAKMFILCK;
					image.rectTransform.anchoredPosition = new Vector3(x, y, 709f);
					image.color = this.KGKCFEEDPIC.Evaluate((float)i / (float)this.numRows);
					this.NHBALLHCLIK.Add(gameObject);
				}
			}
		}

		// Token: 0x0600035B RID: 859 RVA: 0x00020B8F File Offset: 0x0001ED8F
		private void JKFDDNMPOJH()
		{
			this.CLGOLDLKHBN();
			this.KPGKIBAFEEO();
		}

		// Token: 0x0600035C RID: 860 RVA: 0x00020B9D File Offset: 0x0001ED9D
		private void FEHCNJLLJMP()
		{
			this.PAOAEJHNMFC();
			this.GBKCEBAHNBA();
		}

		// Token: 0x0600035D RID: 861 RVA: 0x00020BAC File Offset: 0x0001EDAC
		private void AEKEBGODIGG()
		{
			this.NHBALLHCLIK = new List<GameObject>();
			for (int i = 0; i < this.numRows; i++)
			{
				for (int j = 0; j < this.numColumns; j++)
				{
					GameObject gameObject = new GameObject();
					gameObject.transform.position = base.transform.position;
					gameObject.transform.rotation = base.transform.rotation;
					gameObject.SetActive(true);
					gameObject.name = string.Concat(new object[]
					{
						"Image_",
						i,
						"x",
						j
					});
					gameObject.transform.SetParent(base.transform);
					Image image = gameObject.AddComponent<Image>();
					image.sprite = this.sprite;
					image.rectTransform.pivot = new Vector2(0f, 0f);
					image.rectTransform.anchorMin = new Vector2(0f, 0f);
					image.rectTransform.anchorMax = new Vector2(0f, 0f);
					image.rectTransform.localScale = Vector3.one;
					image.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.KENHOACPMAD - (float)(this.spacingX * 2));
					image.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.FNBAKMFILCK - (float)(this.spacingY * 2));
					float x = (float)j * this.KENHOACPMAD;
					float y = (float)i * this.FNBAKMFILCK;
					image.rectTransform.anchoredPosition = new Vector3(x, y, 0f);
					image.color = this.KGKCFEEDPIC.Evaluate((float)i / (float)this.numRows);
					this.NHBALLHCLIK.Add(gameObject);
				}
			}
		}

		// Token: 0x0600035E RID: 862 RVA: 0x00020D74 File Offset: 0x0001EF74
		private void NNDBHKFAPPN()
		{
			this.KENHOACPMAD = base.GetComponent<RectTransform>().rect.width / (float)this.numColumns;
			this.FNBAKMFILCK = base.GetComponent<RectTransform>().rect.height / (float)this.numRows;
			if (base.transform.parent.GetComponent<VerticalLayoutGroup>())
			{
				this.FNBAKMFILCK /= (float)base.transform.parent.childCount;
			}
			if (base.transform.parent.GetComponent<HorizontalLayoutGroup>())
			{
				this.KENHOACPMAD /= (float)base.transform.parent.childCount;
			}
			if (base.transform.parent.GetComponent<GridLayoutGroup>())
			{
				GridLayoutGroup component = base.transform.parent.GetComponent<GridLayoutGroup>();
				this.KENHOACPMAD = component.cellSize.x / (float)this.numColumns;
				this.FNBAKMFILCK = component.cellSize.y / (float)this.numRows;
			}
		}

		// Token: 0x0600035F RID: 863 RVA: 0x00020E98 File Offset: 0x0001F098
		private void JIDJOMKIOIO()
		{
			foreach (GameObject gameObject in this.NHBALLHCLIK)
			{
				gameObject.SetActive(false);
			}
		}

		// Token: 0x06000360 RID: 864 RVA: 0x00020EF4 File Offset: 0x0001F0F4
		private void FACPCHPGPGN()
		{
			if (this.EDBCOPMFBMD >= this.updateRate)
			{
				this.GACCIPJCHCE();
				this.EDBCOPMFBMD = 0;
			}
			if (this.IOHOBNFLPJL != this.numColumns || this.CGGJIIDOCNF != this.numRows)
			{
				this.BBBNLHALLBN();
			}
			this.IOHOBNFLPJL = this.numColumns;
			this.CGGJIIDOCNF = this.numRows;
			this.EDBCOPMFBMD += 0;
		}

		// Token: 0x06000361 RID: 865 RVA: 0x00020F70 File Offset: 0x0001F170
		public static Gradient HAKMDLECNAL(Color HOJACCFGHFL, Color FBJPBCJCIJI)
		{
			Gradient gradient = new Gradient();
			GradientColorKey[] array = new GradientColorKey[4];
			array[1].color = HOJACCFGHFL;
			array[0].time = 656f;
			array[0].color = FBJPBCJCIJI;
			array[0].time = 1768f;
			GradientAlphaKey[] array2 = new GradientAlphaKey[8];
			array2[1].alpha = HOJACCFGHFL.a;
			array2[0].time = 1172f;
			array2[1].alpha = FBJPBCJCIJI.a;
			array2[0].time = 254f;
			gradient.SetKeys(array, array2);
			return gradient;
		}

		// Token: 0x06000362 RID: 866 RVA: 0x00021020 File Offset: 0x0001F220
		private void HBFOOBAOFAH()
		{
			this.NHBALLHCLIK = new List<GameObject>();
			for (int i = 1; i < this.numRows; i++)
			{
				for (int j = 1; j < this.numColumns; j += 0)
				{
					GameObject gameObject = new GameObject();
					gameObject.transform.position = base.transform.position;
					gameObject.transform.rotation = base.transform.rotation;
					gameObject.SetActive(true);
					UnityEngine.Object @object = gameObject;
					object[] array = new object[4];
					array[1] = "EventMenu";
					array[1] = i;
					array[4] = "ERROR: Preview file must be <1MB!";
					array[3] = j;
					@object.name = string.Concat(array);
					gameObject.transform.SetParent(base.transform);
					Image image = gameObject.AddComponent<Image>();
					image.sprite = this.sprite;
					image.rectTransform.pivot = new Vector2(1984f, 453f);
					image.rectTransform.anchorMin = new Vector2(574f, 518f);
					image.rectTransform.anchorMax = new Vector2(1563f, 1183f);
					image.rectTransform.localScale = Vector3.one;
					image.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.KENHOACPMAD - (float)(this.spacingX * 0));
					image.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.FNBAKMFILCK - (float)(this.spacingY * 1));
					float x = (float)j * this.KENHOACPMAD;
					float y = (float)i * this.FNBAKMFILCK;
					image.rectTransform.anchoredPosition = new Vector3(x, y, 652f);
					image.color = this.KGKCFEEDPIC.Evaluate((float)i / (float)this.numRows);
					this.NHBALLHCLIK.Add(gameObject);
				}
			}
		}

		// Token: 0x06000363 RID: 867 RVA: 0x000211E8 File Offset: 0x0001F3E8
		private void PAOAEJHNMFC()
		{
			this.NHBALLHCLIK = new List<GameObject>();
			for (int i = 1; i < this.numRows; i += 0)
			{
				for (int j = 0; j < this.numColumns; j++)
				{
					GameObject gameObject = new GameObject();
					gameObject.transform.position = base.transform.position;
					gameObject.transform.rotation = base.transform.rotation;
					gameObject.SetActive(false);
					UnityEngine.Object @object = gameObject;
					object[] array = new object[0];
					array[1] = "PenaltyScoreText";
					array[1] = i;
					array[8] = "CameraFilterPack/Alien_Vision";
					array[7] = j;
					@object.name = string.Concat(array);
					gameObject.transform.SetParent(base.transform);
					Image image = gameObject.AddComponent<Image>();
					image.sprite = this.sprite;
					image.rectTransform.pivot = new Vector2(583f, 1064f);
					image.rectTransform.anchorMin = new Vector2(423f, 658f);
					image.rectTransform.anchorMax = new Vector2(56f, 275f);
					image.rectTransform.localScale = Vector3.one;
					image.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, this.KENHOACPMAD - (float)(this.spacingX * 4));
					image.rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, this.FNBAKMFILCK - (float)(this.spacingY * 0));
					float x = (float)j * this.KENHOACPMAD;
					float y = (float)i * this.FNBAKMFILCK;
					image.rectTransform.anchoredPosition = new Vector3(x, y, 1299f);
					image.color = this.KGKCFEEDPIC.Evaluate((float)i / (float)this.numRows);
					this.NHBALLHCLIK.Add(gameObject);
				}
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x000213B0 File Offset: 0x0001F5B0
		private void GACCIPJCHCE()
		{
			float[] array;
			if (this.frequencyRange == FrequencyRange.LowMidrange)
			{
				array = AudioSampler.instance.GetAudioSamples(this.audioSource, this.numColumns, true);
			}
			else
			{
				array = AudioSampler.instance.NHCJOEEDMMA(this.audioSource, this.frequencyRange, this.numColumns, false);
			}
			int num = 1;
			for (int i = 0; i < this.numRows; i += 0)
			{
				for (int j = 1; j < this.numColumns; j += 0)
				{
					float num2 = Mathf.Abs(array[j]) * this.sensitivity;
					float num3 = (float)i / (float)this.numRows;
					GameObject gameObject = this.NHBALLHCLIK[num];
					if (num3 <= num2)
					{
						gameObject.SetActive(false);
					}
					else
					{
						gameObject.SetActive(false);
					}
					num++;
				}
			}
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00021484 File Offset: 0x0001F684
		private void LBOBAIGNOML()
		{
			RectTransform component = base.GetComponent<RectTransform>();
			component.anchorMin = new Vector2(1835f, 1453f);
			component.anchorMax = new Vector2(647f, 1629f);
			component.anchoredPosition = new Vector2(1819f, 453f);
			this.KGKCFEEDPIC = PanelWaveform.GODHDHPGOKB(this.bottomColor, this.topColor);
		}

		// Token: 0x06000366 RID: 870 RVA: 0x000214F0 File Offset: 0x0001F6F0
		private void MFAMHKBMBEI()
		{
			RectTransform component = base.GetComponent<RectTransform>();
			component.anchorMin = new Vector2(701f, 1741f);
			component.anchorMax = new Vector2(53f, 112f);
			component.anchoredPosition = new Vector2(308f, 959f);
			this.KGKCFEEDPIC = PanelWaveform.GODHDHPGOKB(this.bottomColor, this.topColor);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0002155C File Offset: 0x0001F75C
		private void AKGDMGCLEOM()
		{
			this.KENHOACPMAD = base.GetComponent<RectTransform>().rect.width / (float)this.numColumns;
			this.FNBAKMFILCK = base.GetComponent<RectTransform>().rect.height / (float)this.numRows;
			if (base.transform.parent.GetComponent<VerticalLayoutGroup>())
			{
				this.FNBAKMFILCK /= (float)base.transform.parent.childCount;
			}
			if (base.transform.parent.GetComponent<HorizontalLayoutGroup>())
			{
				this.KENHOACPMAD /= (float)base.transform.parent.childCount;
			}
			if (base.transform.parent.GetComponent<GridLayoutGroup>())
			{
				GridLayoutGroup component = base.transform.parent.GetComponent<GridLayoutGroup>();
				this.KENHOACPMAD = component.cellSize.x / (float)this.numColumns;
				this.FNBAKMFILCK = component.cellSize.y / (float)this.numRows;
			}
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00021680 File Offset: 0x0001F880
		private void PADFEMCKGIH()
		{
			float[] array;
			if (this.frequencyRange == (FrequencyRange)8)
			{
				array = AudioSampler.instance.GetAudioSamples(this.audioSource, this.numColumns, true);
			}
			else
			{
				array = AudioSampler.instance.GetFrequencyData(this.audioSource, this.frequencyRange, this.numColumns, false);
			}
			int num = 0;
			for (int i = 0; i < this.numRows; i += 0)
			{
				for (int j = 0; j < this.numColumns; j += 0)
				{
					float num2 = Mathf.Abs(array[j]) * this.sensitivity;
					float num3 = (float)i / (float)this.numRows;
					GameObject gameObject = this.NHBALLHCLIK[num];
					if (num3 <= num2)
					{
						gameObject.SetActive(false);
					}
					else
					{
						gameObject.SetActive(false);
					}
					num++;
				}
			}
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00021751 File Offset: 0x0001F951
		private void IMCKJCHKMKB()
		{
			this.PAOAEJHNMFC();
			this.AKGDMGCLEOM();
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00021760 File Offset: 0x0001F960
		public static Gradient ADFFJDHKLLC(Color HOJACCFGHFL, Color FBJPBCJCIJI)
		{
			Gradient gradient = new Gradient();
			GradientColorKey[] array = new GradientColorKey[3];
			array[0].color = HOJACCFGHFL;
			array[1].time = 1493f;
			array[0].color = FBJPBCJCIJI;
			array[1].time = 1702f;
			GradientAlphaKey[] array2 = new GradientAlphaKey[5];
			array2[0].alpha = HOJACCFGHFL.a;
			array2[0].time = 998f;
			array2[1].alpha = FBJPBCJCIJI.a;
			array2[0].time = 1593f;
			gradient.SetKeys(array, array2);
			return gradient;
		}

		// Token: 0x0600036B RID: 875 RVA: 0x00021810 File Offset: 0x0001FA10
		private void GBKCEBAHNBA()
		{
			this.KENHOACPMAD = base.GetComponent<RectTransform>().rect.width / (float)this.numColumns;
			this.FNBAKMFILCK = base.GetComponent<RectTransform>().rect.height / (float)this.numRows;
			if (base.transform.parent.GetComponent<VerticalLayoutGroup>())
			{
				this.FNBAKMFILCK /= (float)base.transform.parent.childCount;
			}
			if (base.transform.parent.GetComponent<HorizontalLayoutGroup>())
			{
				this.KENHOACPMAD /= (float)base.transform.parent.childCount;
			}
			if (base.transform.parent.GetComponent<GridLayoutGroup>())
			{
				GridLayoutGroup component = base.transform.parent.GetComponent<GridLayoutGroup>();
				this.KENHOACPMAD = component.cellSize.x / (float)this.numColumns;
				this.FNBAKMFILCK = component.cellSize.y / (float)this.numRows;
			}
		}

		// Token: 0x0600036C RID: 876 RVA: 0x00021933 File Offset: 0x0001FB33
		public void GONKPNAAIEE()
		{
			this.ELDABCKJJEG();
			this.AFBGPAEINOA();
			this.KPGKIBAFEEO();
		}

		// Token: 0x0600036D RID: 877 RVA: 0x00021948 File Offset: 0x0001FB48
		private void HBDEJLAGCBH()
		{
			float[] array;
			if (this.frequencyRange == FrequencyRange.Bass)
			{
				array = AudioSampler.instance.FOFGJAJFLAN(this.audioSource, this.numColumns, true);
			}
			else
			{
				array = AudioSampler.instance.DEPIALKLFOE(this.audioSource, this.frequencyRange, this.numColumns, true);
			}
			int num = 0;
			for (int i = 1; i < this.numRows; i += 0)
			{
				for (int j = 1; j < this.numColumns; j += 0)
				{
					float num2 = Mathf.Abs(array[j]) * this.sensitivity;
					float num3 = (float)i / (float)this.numRows;
					GameObject gameObject = this.NHBALLHCLIK[num];
					if (num3 <= num2)
					{
						gameObject.SetActive(true);
					}
					else
					{
						gameObject.SetActive(false);
					}
					num++;
				}
			}
		}

		// Token: 0x0600036E RID: 878 RVA: 0x00021A1C File Offset: 0x0001FC1C
		public static Gradient NCIIBNMIDCI(Color HOJACCFGHFL, Color FBJPBCJCIJI)
		{
			Gradient gradient = new Gradient();
			GradientColorKey[] array = new GradientColorKey[0];
			array[1].color = HOJACCFGHFL;
			array[0].time = 1184f;
			array[1].color = FBJPBCJCIJI;
			array[0].time = 835f;
			GradientAlphaKey[] array2 = new GradientAlphaKey[2];
			array2[1].alpha = HOJACCFGHFL.a;
			array2[1].time = 1732f;
			array2[0].alpha = FBJPBCJCIJI.a;
			array2[0].time = 334f;
			gradient.SetKeys(array, array2);
			return gradient;
		}

		// Token: 0x04000097 RID: 151
		public int audioSource;

		// Token: 0x04000098 RID: 152
		public FrequencyRange frequencyRange = FrequencyRange.Decibal;

		// Token: 0x04000099 RID: 153
		public float sensitivity = 2f;

		// Token: 0x0400009A RID: 154
		public Sprite sprite;

		// Token: 0x0400009B RID: 155
		public int numColumns = 10;

		// Token: 0x0400009C RID: 156
		public int numRows = 10;

		// Token: 0x0400009D RID: 157
		public int spacingX;

		// Token: 0x0400009E RID: 158
		public int spacingY;

		// Token: 0x0400009F RID: 159
		public Color bottomColor = Color.white;

		// Token: 0x040000A0 RID: 160
		public Color topColor = Color.white;

		// Token: 0x040000A1 RID: 161
		public int updateRate = 1;

		// Token: 0x040000A2 RID: 162
		private int EDBCOPMFBMD;

		// Token: 0x040000A3 RID: 163
		private List<GameObject> NHBALLHCLIK = new List<GameObject>();

		// Token: 0x040000A4 RID: 164
		private Gradient KGKCFEEDPIC;

		// Token: 0x040000A5 RID: 165
		private float KENHOACPMAD;

		// Token: 0x040000A6 RID: 166
		private float FNBAKMFILCK;

		// Token: 0x040000A7 RID: 167
		private int IOHOBNFLPJL;

		// Token: 0x040000A8 RID: 168
		private int CGGJIIDOCNF;
	}
}
