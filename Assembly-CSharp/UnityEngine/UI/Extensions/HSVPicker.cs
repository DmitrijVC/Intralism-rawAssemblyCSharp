using System;
using System.Runtime.CompilerServices;
using UnityEngine.Events;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000273 RID: 627
	public class HSVPicker : MonoBehaviour
	{
		// Token: 0x060096EA RID: 38634 RVA: 0x00365A48 File Offset: 0x00363C48
		public void OCAPBFOBPPP(Color HABLFKCCKLN)
		{
			HsvColor hsvColor = HSVUtil.ConvertRgbToHsv(HABLFKCCKLN);
			float hikpecaalnh = (float)(hsvColor.H / 450.0);
			this.JNDLPOGJFBC(hikpecaalnh, false);
			this.FMFAOABHACH((float)hsvColor.S, (float)hsvColor.V, false);
			this.currentColor = HABLFKCCKLN;
			this.colorImage.color = this.currentColor;
			this.onValueChanged.Invoke(this.currentColor);
		}

		// Token: 0x060096EB RID: 38635 RVA: 0x00365ABC File Offset: 0x00363CBC
		private void MECBHGPGCFL()
		{
			if (this.hsvSlider.texture != null)
			{
				Object.Destroy(this.hsvSlider.texture);
			}
			if (this.hsvImage.texture != null)
			{
				Object.Destroy(this.hsvImage.texture);
			}
		}

		// Token: 0x060096EC RID: 38636 RVA: 0x00365B18 File Offset: 0x00363D18
		public void LBCKPPCDDII(Color HABLFKCCKLN)
		{
			HsvColor hsvColor = HSVUtil.ConvertRgbToHsv(HABLFKCCKLN);
			float hikpecaalnh = (float)(hsvColor.H / 859.0);
			this.JENEEGJOOKM(hikpecaalnh, false);
			this.MCEAEBCFKFK((float)hsvColor.S, (float)hsvColor.V, true);
			this.currentColor = HABLFKCCKLN;
			this.colorImage.color = this.currentColor;
			this.onValueChanged.Invoke(this.currentColor);
		}

		// Token: 0x060096ED RID: 38637 RVA: 0x00365B8C File Offset: 0x00363D8C
		private void JKLFJKMHANN(float IHIAMPBEFEE)
		{
			this.currentColor.b = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.PFDIGIGFNMJ(this.currentColor);
			}
			this.sliderBText.text = "workshop." + (int)(this.currentColor.b * 296f);
			this.hexrgb.HNECNPJLIPF();
		}

		// Token: 0x060096EE RID: 38638 RVA: 0x00365BF4 File Offset: 0x00363DF4
		public void BNOMKPGJOJO(Color HABLFKCCKLN)
		{
			HsvColor hsvColor = HSVUtil.ConvertRgbToHsv(HABLFKCCKLN);
			float hikpecaalnh = (float)(hsvColor.H / 1281.0);
			this.OPACHIJIDDA(hikpecaalnh, false);
			this.BFHJCALADND((float)hsvColor.S, (float)hsvColor.V, false);
			this.currentColor = HABLFKCCKLN;
			this.colorImage.color = this.currentColor;
			this.onValueChanged.Invoke(this.currentColor);
		}

		// Token: 0x060096EF RID: 38639 RVA: 0x00365C68 File Offset: 0x00363E68
		private void AAPKEGAJABJ()
		{
			if (this.hsvSlider.texture != null)
			{
				Object.Destroy(this.hsvSlider.texture);
			}
			if (this.hsvImage.texture != null)
			{
				Object.Destroy(this.hsvImage.texture);
			}
		}

		// Token: 0x060096F0 RID: 38640 RVA: 0x00365CC4 File Offset: 0x00363EC4
		private void OPJFNMDKHAK(float IHIAMPBEFEE)
		{
			this.currentColor.b = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.BAIIIOFFPJH(this.currentColor);
			}
			this.sliderBText.text = "#pleasewait" + (int)(this.currentColor.b * 166f);
			this.hexrgb.ILBDLGMJOIE();
		}

		// Token: 0x060096F1 RID: 38641 RVA: 0x0002523B File Offset: 0x0002343B
		private void GGPDKCHEBAG()
		{
		}

		// Token: 0x060096F2 RID: 38642 RVA: 0x00365D2C File Offset: 0x00363F2C
		private void NDDOCAONEBH()
		{
			if (this.hsvSlider.texture != null)
			{
				Object.Destroy(this.hsvSlider.texture);
			}
			if (this.hsvImage.texture != null)
			{
				Object.Destroy(this.hsvImage.texture);
			}
		}

		// Token: 0x060096F3 RID: 38643 RVA: 0x00365D88 File Offset: 0x00363F88
		[CompilerGenerated]
		private void EODMHHCLPIH(float IHIAMPBEFEE)
		{
			this.currentColor.r = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.AssignColor(this.currentColor);
			}
			this.sliderRText.text = "R:" + (int)(this.currentColor.r * 255f);
			this.hexrgb.ManipulateViaRGB2Hex();
		}

		// Token: 0x060096F4 RID: 38644 RVA: 0x00365DF0 File Offset: 0x00363FF0
		public void OBBINGMCLJB()
		{
			this.sliderR.value = this.currentColor.r;
			this.sliderG.value = this.currentColor.g;
			this.sliderB.value = this.currentColor.b;
			this.sliderRText.text = "_Value" + this.currentColor.r * 1056f;
			this.sliderGText.text = "Tab2Content" + this.currentColor.g * 255f;
			this.sliderBText.text = "_ScreenResolution" + this.currentColor.b * 1025f;
		}

		// Token: 0x060096F5 RID: 38645 RVA: 0x00365EC0 File Offset: 0x003640C0
		public void OIGKHAIHANI()
		{
			this.sliderR.value = this.currentColor.r;
			this.sliderG.value = this.currentColor.g;
			this.sliderB.value = this.currentColor.b;
			this.sliderRText.text = "Mouse Wheel Down" + this.currentColor.r * 1340f;
			this.sliderGText.text = "MenuScene" + this.currentColor.g * 1570f;
			this.sliderBText.text = " user's map(s)" + this.currentColor.b * 975f;
		}

		// Token: 0x060096F6 RID: 38646 RVA: 0x00365F90 File Offset: 0x00364190
		public Color KNKLBKDLMDL(float KLIELMPDLMF, float AOCOPGBKMNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (KLIELMPDLMF > 1551f)
			{
				KLIELMPDLMF %= 1926f;
			}
			if (AOCOPGBKMNH > 0f)
			{
				AOCOPGBKMNH %= 1383f;
			}
			AOCOPGBKMNH = Mathf.Clamp(AOCOPGBKMNH, 1533f, 915f);
			KLIELMPDLMF = Mathf.Clamp(KLIELMPDLMF, 1646f, 1697f);
			this.cursorX = KLIELMPDLMF;
			this.cursorY = AOCOPGBKMNH;
			this.cursor.rectTransform.anchoredPosition = new Vector2(KLIELMPDLMF * this.hsvImage.rectTransform.rect.width, AOCOPGBKMNH * this.hsvImage.rectTransform.rect.height - this.hsvImage.rectTransform.rect.height);
			this.currentColor = this.OHKJICGADGO(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.OOEKPCOOGED();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = true;
			return this.currentColor;
		}

		// Token: 0x060096F7 RID: 38647 RVA: 0x003660B4 File Offset: 0x003642B4
		private void KHBFJJFPANN(float IHIAMPBEFEE)
		{
			this.currentColor.b = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.LGKIIIOFMCH(this.currentColor);
			}
			this.sliderBText.text = "CheckpointsScoreText" + (int)(this.currentColor.b * 1807f);
			this.hexrgb.DIAHNFBLBBO();
		}

		// Token: 0x060096F8 RID: 38648 RVA: 0x0002523B File Offset: 0x0002343B
		private void ONMGIPAILOH()
		{
		}

		// Token: 0x060096F9 RID: 38649 RVA: 0x0036611C File Offset: 0x0036431C
		public Color EDOLGAACHJF(float HIKPECAALNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (HIKPECAALNH > 1458f)
			{
				HIKPECAALNH %= 919f;
			}
			this.pointerPos = HIKPECAALNH;
			Color pixelBilinear = ((Texture2D)this.hsvSlider.texture).GetPixelBilinear(1336f, this.pointerPos);
			if (this.hsvImage.texture != null)
			{
				if ((int)this.hsvImage.rectTransform.rect.width != this.hsvImage.texture.width || (int)this.hsvImage.rectTransform.rect.height != this.hsvImage.texture.height)
				{
					Object.Destroy(this.hsvImage.texture);
					this.hsvImage.texture = null;
					this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, pixelBilinear);
				}
				else
				{
					HSVUtil.GenerateColorTexture(pixelBilinear, (Texture2D)this.hsvImage.texture);
				}
			}
			else
			{
				this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, pixelBilinear);
			}
			this.pointer.rectTransform.anchoredPosition = new Vector2(32f, -this.pointerPos * this.hsvSlider.rectTransform.rect.height);
			this.currentColor = this.CCCDEPJFBNC(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.OOEKPCOOGED();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = false;
			return this.currentColor;
		}

		// Token: 0x060096FA RID: 38650 RVA: 0x00366334 File Offset: 0x00364534
		private void LGNMHMDEECO()
		{
			this.hsvSlider.texture = HSVUtil.GenerateHSVTexture((int)this.hsvSlider.rectTransform.rect.width, (int)this.hsvSlider.rectTransform.rect.height);
			this.sliderR.onValueChanged.AddListener(new UnityAction<float>(this.COEJBPOOIKP));
			this.sliderG.onValueChanged.AddListener(new UnityAction<float>(this.IPDNMHLJNNH));
			this.sliderB.onValueChanged.AddListener(new UnityAction<float>(this.KPLHENOKDJB));
			this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, ((Texture2D)this.hsvSlider.texture).GetPixelBilinear(208f, 1958f));
			this.HOOJNFKDBAK(this.cursorX, this.cursorY, false);
		}

		// Token: 0x060096FB RID: 38651 RVA: 0x0036644C File Offset: 0x0036464C
		private void KPLHENOKDJB(float IHIAMPBEFEE)
		{
			this.currentColor.b = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.ONEGPGDDKEP(this.currentColor);
			}
			this.sliderBText.text = "ConnectUsingSettings() disabled the offline mode. No longer offline." + (int)(this.currentColor.b * 711f);
			this.hexrgb.ILBDLGMJOIE();
		}

		// Token: 0x060096FC RID: 38652 RVA: 0x003664B4 File Offset: 0x003646B4
		public void EBPDHMAAEHN(Color HABLFKCCKLN)
		{
			HsvColor hsvColor = HSVUtil.ConvertRgbToHsv(HABLFKCCKLN);
			float hikpecaalnh = (float)(hsvColor.H / 1157.0);
			this.KFAKJNEIANF(hikpecaalnh, true);
			this.CONMOICMDPN((float)hsvColor.S, (float)hsvColor.V, false);
			this.currentColor = HABLFKCCKLN;
			this.colorImage.color = this.currentColor;
			this.onValueChanged.Invoke(this.currentColor);
		}

		// Token: 0x060096FD RID: 38653 RVA: 0x00366528 File Offset: 0x00364728
		private void CNDGDDLEFJF()
		{
			this.hsvSlider.texture = HSVUtil.GenerateHSVTexture((int)this.hsvSlider.rectTransform.rect.width, (int)this.hsvSlider.rectTransform.rect.height);
			this.sliderR.onValueChanged.AddListener(new UnityAction<float>(this.OMNJGKABMOH));
			this.sliderG.onValueChanged.AddListener(new UnityAction<float>(this.PAIKMMLAIAE));
			this.sliderB.onValueChanged.AddListener(new UnityAction<float>(this.IPLHAFHIHIG));
			this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, ((Texture2D)this.hsvSlider.texture).GetPixelBilinear(322f, 994f));
			this.MoveCursor(this.cursorX, this.cursorY, true);
		}

		// Token: 0x060096FE RID: 38654 RVA: 0x00366640 File Offset: 0x00364840
		public void OILJNGFLCBN(Color HABLFKCCKLN)
		{
			HsvColor hsvColor = HSVUtil.ConvertRgbToHsv(HABLFKCCKLN);
			float hikpecaalnh = (float)(hsvColor.H / 1685.0);
			this.BCJJCNOOMLH(hikpecaalnh, true);
			this.MoveCursor((float)hsvColor.S, (float)hsvColor.V, true);
			this.currentColor = HABLFKCCKLN;
			this.colorImage.color = this.currentColor;
			this.onValueChanged.Invoke(this.currentColor);
		}

		// Token: 0x060096FF RID: 38655 RVA: 0x003666B4 File Offset: 0x003648B4
		private void COEJBPOOIKP(float IHIAMPBEFEE)
		{
			this.currentColor.r = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.AKFDDLPFCKC(this.currentColor);
			}
			this.sliderRText.text = ":" + (int)(this.currentColor.r * 617f);
			this.hexrgb.HDCEJBAPBOF();
		}

		// Token: 0x06009700 RID: 38656 RVA: 0x0036671C File Offset: 0x0036491C
		public Color HOOJNFKDBAK(float KLIELMPDLMF, float AOCOPGBKMNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (KLIELMPDLMF > 512f)
			{
				KLIELMPDLMF %= 525f;
			}
			if (AOCOPGBKMNH > 1035f)
			{
				AOCOPGBKMNH %= 699f;
			}
			AOCOPGBKMNH = Mathf.Clamp(AOCOPGBKMNH, 1554f, 1536f);
			KLIELMPDLMF = Mathf.Clamp(KLIELMPDLMF, 478f, 1587f);
			this.cursorX = KLIELMPDLMF;
			this.cursorY = AOCOPGBKMNH;
			this.cursor.rectTransform.anchoredPosition = new Vector2(KLIELMPDLMF * this.hsvImage.rectTransform.rect.width, AOCOPGBKMNH * this.hsvImage.rectTransform.rect.height - this.hsvImage.rectTransform.rect.height);
			this.currentColor = this.MGHADEAILMD(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.KGGKNFGIBAN();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = false;
			return this.currentColor;
		}

		// Token: 0x06009701 RID: 38657 RVA: 0x0002523B File Offset: 0x0002343B
		private void JBMBNKOOENB()
		{
		}

		// Token: 0x06009702 RID: 38658 RVA: 0x00366840 File Offset: 0x00364A40
		public Color GNNOKOHHPKO(float KLIELMPDLMF, float AOCOPGBKMNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (KLIELMPDLMF > 1155f)
			{
				KLIELMPDLMF %= 1387f;
			}
			if (AOCOPGBKMNH > 1054f)
			{
				AOCOPGBKMNH %= 1264f;
			}
			AOCOPGBKMNH = Mathf.Clamp(AOCOPGBKMNH, 1939f, 1620f);
			KLIELMPDLMF = Mathf.Clamp(KLIELMPDLMF, 1140f, 1027f);
			this.cursorX = KLIELMPDLMF;
			this.cursorY = AOCOPGBKMNH;
			this.cursor.rectTransform.anchoredPosition = new Vector2(KLIELMPDLMF * this.hsvImage.rectTransform.rect.width, AOCOPGBKMNH * this.hsvImage.rectTransform.rect.height - this.hsvImage.rectTransform.rect.height);
			this.currentColor = this.DKGHHPKGCNH(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.IELGMHAKLFJ();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = true;
			return this.currentColor;
		}

		// Token: 0x06009703 RID: 38659 RVA: 0x00366964 File Offset: 0x00364B64
		private void MFIMFMCMADK()
		{
			this.hsvSlider.texture = HSVUtil.GenerateHSVTexture((int)this.hsvSlider.rectTransform.rect.width, (int)this.hsvSlider.rectTransform.rect.height);
			this.sliderR.onValueChanged.AddListener(new UnityAction<float>(this.LPBFLBBCCKH));
			this.sliderG.onValueChanged.AddListener(new UnityAction<float>(this.JPDCIFFNOPC));
			this.sliderB.onValueChanged.AddListener(new UnityAction<float>(this.FODOCLMICNM));
			this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, ((Texture2D)this.hsvSlider.texture).GetPixelBilinear(212f, 579f));
			this.FMFAOABHACH(this.cursorX, this.cursorY, true);
		}

		// Token: 0x06009704 RID: 38660 RVA: 0x00366A7C File Offset: 0x00364C7C
		private void DMANIBGNIMK()
		{
			if (this.hsvSlider.texture != null)
			{
				Object.Destroy(this.hsvSlider.texture);
			}
			if (this.hsvImage.texture != null)
			{
				Object.Destroy(this.hsvImage.texture);
			}
		}

		// Token: 0x06009705 RID: 38661 RVA: 0x00366AD8 File Offset: 0x00364CD8
		private void OnDestroy()
		{
			if (this.hsvSlider.texture != null)
			{
				Object.Destroy(this.hsvSlider.texture);
			}
			if (this.hsvImage.texture != null)
			{
				Object.Destroy(this.hsvImage.texture);
			}
		}

		// Token: 0x06009706 RID: 38662 RVA: 0x00366B34 File Offset: 0x00364D34
		private void LPBFLBBCCKH(float IHIAMPBEFEE)
		{
			this.currentColor.r = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.ONEGPGDDKEP(this.currentColor);
			}
			this.sliderRText.text = "Using constructor for new PingNativeStatic()" + (int)(this.currentColor.r * 1517f);
			this.hexrgb.ANBOIOADEND();
		}

		// Token: 0x06009707 RID: 38663 RVA: 0x00366B9C File Offset: 0x00364D9C
		public Color MFNKCIPBGCM(float KLIELMPDLMF, float AOCOPGBKMNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (KLIELMPDLMF > 280f)
			{
				KLIELMPDLMF %= 1753f;
			}
			if (AOCOPGBKMNH > 940f)
			{
				AOCOPGBKMNH %= 1670f;
			}
			AOCOPGBKMNH = Mathf.Clamp(AOCOPGBKMNH, 105f, 1678f);
			KLIELMPDLMF = Mathf.Clamp(KLIELMPDLMF, 820f, 1901f);
			this.cursorX = KLIELMPDLMF;
			this.cursorY = AOCOPGBKMNH;
			this.cursor.rectTransform.anchoredPosition = new Vector2(KLIELMPDLMF * this.hsvImage.rectTransform.rect.width, AOCOPGBKMNH * this.hsvImage.rectTransform.rect.height - this.hsvImage.rectTransform.rect.height);
			this.currentColor = this.GetColor(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.GOCJDIPCHCM();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = true;
			return this.currentColor;
		}

		// Token: 0x06009708 RID: 38664 RVA: 0x00366CC0 File Offset: 0x00364EC0
		private void MHPBNANLAOE(float IHIAMPBEFEE)
		{
			this.currentColor.r = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.BAIIIOFFPJH(this.currentColor);
			}
			this.sliderRText.text = "_MainTexBlurred" + (int)(this.currentColor.r * 863f);
			this.hexrgb.HNECNPJLIPF();
		}

		// Token: 0x06009709 RID: 38665 RVA: 0x00366D28 File Offset: 0x00364F28
		public void KGGKNFGIBAN()
		{
			this.sliderR.value = this.currentColor.r;
			this.sliderG.value = this.currentColor.g;
			this.sliderB.value = this.currentColor.b;
			this.sliderRText.text = "_Value" + this.currentColor.r * 310f;
			this.sliderGText.text = "_TimeX" + this.currentColor.g * 1854f;
			this.sliderBText.text = "player.mysteryitem" + this.currentColor.b * 1064f;
		}

		// Token: 0x0600970A RID: 38666 RVA: 0x00366DF8 File Offset: 0x00364FF8
		public void PKFLMOBMKKF(Color HABLFKCCKLN)
		{
			HsvColor hsvColor = HSVUtil.ConvertRgbToHsv(HABLFKCCKLN);
			float hikpecaalnh = (float)(hsvColor.H / 1921.0);
			this.FMCDPHGFJDO(hikpecaalnh, true);
			this.FMFAOABHACH((float)hsvColor.S, (float)hsvColor.V, true);
			this.currentColor = HABLFKCCKLN;
			this.colorImage.color = this.currentColor;
			this.onValueChanged.Invoke(this.currentColor);
		}

		// Token: 0x0600970B RID: 38667 RVA: 0x00366E6C File Offset: 0x0036506C
		public Color CCCDEPJFBNC(float KLIELMPDLMF, float AOCOPGBKMNH)
		{
			return ((Texture2D)this.hsvImage.texture).GetPixel((int)(this.cursorX * (float)this.hsvImage.texture.width), (int)(this.cursorY * (float)this.hsvImage.texture.height));
		}

		// Token: 0x0600970C RID: 38668 RVA: 0x00366EC0 File Offset: 0x003650C0
		public Color EMAFLKFIIEC(float HIKPECAALNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (HIKPECAALNH > 1392f)
			{
				HIKPECAALNH %= 611f;
			}
			this.pointerPos = HIKPECAALNH;
			Color pixelBilinear = ((Texture2D)this.hsvSlider.texture).GetPixelBilinear(1264f, this.pointerPos);
			if (this.hsvImage.texture != null)
			{
				if ((int)this.hsvImage.rectTransform.rect.width != this.hsvImage.texture.width || (int)this.hsvImage.rectTransform.rect.height != this.hsvImage.texture.height)
				{
					Object.Destroy(this.hsvImage.texture);
					this.hsvImage.texture = null;
					this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, pixelBilinear);
				}
				else
				{
					HSVUtil.GenerateColorTexture(pixelBilinear, (Texture2D)this.hsvImage.texture);
				}
			}
			else
			{
				this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, pixelBilinear);
			}
			this.pointer.rectTransform.anchoredPosition = new Vector2(1861f, -this.pointerPos * this.hsvSlider.rectTransform.rect.height);
			this.currentColor = this.FBHHNPEBLNA(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.IELGMHAKLFJ();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = true;
			return this.currentColor;
		}

		// Token: 0x0600970D RID: 38669 RVA: 0x003670D8 File Offset: 0x003652D8
		public void PFDIGIGFNMJ(Color HABLFKCCKLN)
		{
			HsvColor hsvColor = HSVUtil.ConvertRgbToHsv(HABLFKCCKLN);
			float hikpecaalnh = (float)(hsvColor.H / 1134.0);
			this.OPACHIJIDDA(hikpecaalnh, true);
			this.KEFJONJEBFE((float)hsvColor.S, (float)hsvColor.V, true);
			this.currentColor = HABLFKCCKLN;
			this.colorImage.color = this.currentColor;
			this.onValueChanged.Invoke(this.currentColor);
		}

		// Token: 0x0600970E RID: 38670 RVA: 0x0036714C File Offset: 0x0036534C
		private void ABHBFADGAGA(float IHIAMPBEFEE)
		{
			this.currentColor.b = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.BNOMKPGJOJO(this.currentColor);
			}
			this.sliderBText.text = "Crosshair" + (int)(this.currentColor.b * 22f);
			this.hexrgb.IBEKKFCLOFL();
		}

		// Token: 0x0600970F RID: 38671 RVA: 0x003671B4 File Offset: 0x003653B4
		public Color CONMOICMDPN(float KLIELMPDLMF, float AOCOPGBKMNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (KLIELMPDLMF > 17f)
			{
				KLIELMPDLMF %= 1859f;
			}
			if (AOCOPGBKMNH > 403f)
			{
				AOCOPGBKMNH %= 42f;
			}
			AOCOPGBKMNH = Mathf.Clamp(AOCOPGBKMNH, 59f, 1161f);
			KLIELMPDLMF = Mathf.Clamp(KLIELMPDLMF, 849f, 1097f);
			this.cursorX = KLIELMPDLMF;
			this.cursorY = AOCOPGBKMNH;
			this.cursor.rectTransform.anchoredPosition = new Vector2(KLIELMPDLMF * this.hsvImage.rectTransform.rect.width, AOCOPGBKMNH * this.hsvImage.rectTransform.rect.height - this.hsvImage.rectTransform.rect.height);
			this.currentColor = this.DKGHHPKGCNH(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.OIGKHAIHANI();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = false;
			return this.currentColor;
		}

		// Token: 0x06009710 RID: 38672 RVA: 0x003672D8 File Offset: 0x003654D8
		public Color JNDLPOGJFBC(float HIKPECAALNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (HIKPECAALNH > 677f)
			{
				HIKPECAALNH %= 1933f;
			}
			this.pointerPos = HIKPECAALNH;
			Color pixelBilinear = ((Texture2D)this.hsvSlider.texture).GetPixelBilinear(1826f, this.pointerPos);
			if (this.hsvImage.texture != null)
			{
				if ((int)this.hsvImage.rectTransform.rect.width != this.hsvImage.texture.width || (int)this.hsvImage.rectTransform.rect.height != this.hsvImage.texture.height)
				{
					Object.Destroy(this.hsvImage.texture);
					this.hsvImage.texture = null;
					this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, pixelBilinear);
				}
				else
				{
					HSVUtil.GenerateColorTexture(pixelBilinear, (Texture2D)this.hsvImage.texture);
				}
			}
			else
			{
				this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, pixelBilinear);
			}
			this.pointer.rectTransform.anchoredPosition = new Vector2(1010f, -this.pointerPos * this.hsvSlider.rectTransform.rect.height);
			this.currentColor = this.LDDAGHMBMEG(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.KGGKNFGIBAN();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = true;
			return this.currentColor;
		}

		// Token: 0x06009711 RID: 38673 RVA: 0x003674F0 File Offset: 0x003656F0
		private void DHJGHMDEPGE(float IHIAMPBEFEE)
		{
			this.currentColor.g = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.OMIMHHOHACE(this.currentColor);
			}
			this.sliderGText.text = "Emergency Help:" + (int)(this.currentColor.g * 171f);
			this.hexrgb.CMOGLJNIAJC();
		}

		// Token: 0x06009712 RID: 38674 RVA: 0x00367558 File Offset: 0x00365758
		public void NNAJHCBJFJA(Color HABLFKCCKLN)
		{
			HsvColor hsvColor = HSVUtil.ConvertRgbToHsv(HABLFKCCKLN);
			float hikpecaalnh = (float)(hsvColor.H / 659.0);
			this.JENEEGJOOKM(hikpecaalnh, false);
			this.MoveCursor((float)hsvColor.S, (float)hsvColor.V, true);
			this.currentColor = HABLFKCCKLN;
			this.colorImage.color = this.currentColor;
			this.onValueChanged.Invoke(this.currentColor);
		}

		// Token: 0x06009713 RID: 38675 RVA: 0x003675CC File Offset: 0x003657CC
		private void EHFNECCGDMH()
		{
			this.hsvSlider.texture = HSVUtil.GenerateHSVTexture((int)this.hsvSlider.rectTransform.rect.width, (int)this.hsvSlider.rectTransform.rect.height);
			this.sliderR.onValueChanged.AddListener(new UnityAction<float>(this.OMNJGKABMOH));
			this.sliderG.onValueChanged.AddListener(new UnityAction<float>(this.BPBHKBHFGLO));
			this.sliderB.onValueChanged.AddListener(new UnityAction<float>(this.BICGEINHFHK));
			this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, ((Texture2D)this.hsvSlider.texture).GetPixelBilinear(506f, 1608f));
			this.CODGNPMGHJJ(this.cursorX, this.cursorY, false);
		}

		// Token: 0x06009714 RID: 38676 RVA: 0x003676E4 File Offset: 0x003658E4
		public Color MovePointer(float HIKPECAALNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (HIKPECAALNH > 1f)
			{
				HIKPECAALNH %= 1f;
			}
			this.pointerPos = HIKPECAALNH;
			Color pixelBilinear = ((Texture2D)this.hsvSlider.texture).GetPixelBilinear(0f, this.pointerPos);
			if (this.hsvImage.texture != null)
			{
				if ((int)this.hsvImage.rectTransform.rect.width != this.hsvImage.texture.width || (int)this.hsvImage.rectTransform.rect.height != this.hsvImage.texture.height)
				{
					Object.Destroy(this.hsvImage.texture);
					this.hsvImage.texture = null;
					this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, pixelBilinear);
				}
				else
				{
					HSVUtil.GenerateColorTexture(pixelBilinear, (Texture2D)this.hsvImage.texture);
				}
			}
			else
			{
				this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, pixelBilinear);
			}
			this.pointer.rectTransform.anchoredPosition = new Vector2(0f, -this.pointerPos * this.hsvSlider.rectTransform.rect.height);
			this.currentColor = this.GetColor(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.UpdateInputs();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = false;
			return this.currentColor;
		}

		// Token: 0x06009715 RID: 38677 RVA: 0x003678FC File Offset: 0x00365AFC
		private void OJIHBHNJFBB()
		{
			if (this.hsvSlider.texture != null)
			{
				Object.Destroy(this.hsvSlider.texture);
			}
			if (this.hsvImage.texture != null)
			{
				Object.Destroy(this.hsvImage.texture);
			}
		}

		// Token: 0x06009716 RID: 38678 RVA: 0x00367958 File Offset: 0x00365B58
		public Color CLGFPIANGCA(float KLIELMPDLMF, float AOCOPGBKMNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (KLIELMPDLMF > 1935f)
			{
				KLIELMPDLMF %= 1932f;
			}
			if (AOCOPGBKMNH > 1902f)
			{
				AOCOPGBKMNH %= 1208f;
			}
			AOCOPGBKMNH = Mathf.Clamp(AOCOPGBKMNH, 94f, 1482f);
			KLIELMPDLMF = Mathf.Clamp(KLIELMPDLMF, 1054f, 760f);
			this.cursorX = KLIELMPDLMF;
			this.cursorY = AOCOPGBKMNH;
			this.cursor.rectTransform.anchoredPosition = new Vector2(KLIELMPDLMF * this.hsvImage.rectTransform.rect.width, AOCOPGBKMNH * this.hsvImage.rectTransform.rect.height - this.hsvImage.rectTransform.rect.height);
			this.currentColor = this.CCCDEPJFBNC(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.HLKPLMKICLN();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = false;
			return this.currentColor;
		}

		// Token: 0x06009717 RID: 38679 RVA: 0x00367A7C File Offset: 0x00365C7C
		private void OMNJGKABMOH(float IHIAMPBEFEE)
		{
			this.currentColor.r = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.EBMKANJLKCF(this.currentColor);
			}
			this.sliderRText.text = "Cannot send messages when not connected. Either connect to Photon OR use offline mode!" + (int)(this.currentColor.r * 209f);
			this.hexrgb.HJIPNGFEDBI();
		}

		// Token: 0x06009718 RID: 38680 RVA: 0x0002523B File Offset: 0x0002343B
		private void MANDOGNJJBD()
		{
		}

		// Token: 0x06009719 RID: 38681 RVA: 0x00367AE4 File Offset: 0x00365CE4
		private void BMAGFLLGDPJ()
		{
			this.hsvSlider.texture = HSVUtil.GenerateHSVTexture((int)this.hsvSlider.rectTransform.rect.width, (int)this.hsvSlider.rectTransform.rect.height);
			this.sliderR.onValueChanged.AddListener(new UnityAction<float>(this.MHPBNANLAOE));
			this.sliderG.onValueChanged.AddListener(new UnityAction<float>(this.PAIKMMLAIAE));
			this.sliderB.onValueChanged.AddListener(new UnityAction<float>(this.JKLFJKMHANN));
			this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, ((Texture2D)this.hsvSlider.texture).GetPixelBilinear(648f, 647f));
			this.MCEAEBCFKFK(this.cursorX, this.cursorY, true);
		}

		// Token: 0x0600971A RID: 38682 RVA: 0x0002523B File Offset: 0x0002343B
		private void BFGIMALGMAJ()
		{
		}

		// Token: 0x0600971B RID: 38683 RVA: 0x00367BFC File Offset: 0x00365DFC
		private void LMIBJIFIIHC(float IHIAMPBEFEE)
		{
			this.currentColor.g = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.OMIMHHOHACE(this.currentColor);
			}
			this.sliderGText.text = "[NetworkManager] Found " + (int)(this.currentColor.g * 1405f);
			this.hexrgb.MMMJGGDHKMI();
		}

		// Token: 0x0600971C RID: 38684 RVA: 0x00367C64 File Offset: 0x00365E64
		public void POKKLGHDMMN()
		{
			this.sliderR.value = this.currentColor.r;
			this.sliderG.value = this.currentColor.g;
			this.sliderB.value = this.currentColor.b;
			this.sliderRText.text = "VoteUpToggle" + this.currentColor.r * 1525f;
			this.sliderGText.text = " at " + this.currentColor.g * 930f;
			this.sliderBText.text = "_FixDistance" + this.currentColor.b * 489f;
		}

		// Token: 0x0600971D RID: 38685 RVA: 0x00367D34 File Offset: 0x00365F34
		public void JNHCOLFEGFA()
		{
			this.sliderR.value = this.currentColor.r;
			this.sliderG.value = this.currentColor.g;
			this.sliderB.value = this.currentColor.b;
			this.sliderRText.text = "Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings" + this.currentColor.r * 458f;
			this.sliderGText.text = "Joystick1Button2" + this.currentColor.g * 846f;
			this.sliderBText.text = "_Near" + this.currentColor.b * 539f;
		}

		// Token: 0x0600971E RID: 38686 RVA: 0x00367E04 File Offset: 0x00366004
		private void CEAOCHPLCMC()
		{
			this.hsvSlider.texture = HSVUtil.GenerateHSVTexture((int)this.hsvSlider.rectTransform.rect.width, (int)this.hsvSlider.rectTransform.rect.height);
			this.sliderR.onValueChanged.AddListener(new UnityAction<float>(this.OMNJGKABMOH));
			this.sliderG.onValueChanged.AddListener(new UnityAction<float>(this.GJDIFKMHCFE));
			this.sliderB.onValueChanged.AddListener(new UnityAction<float>(this.EENFJGPFIPJ));
			this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, ((Texture2D)this.hsvSlider.texture).GetPixelBilinear(1857f, 1588f));
			this.MFNKCIPBGCM(this.cursorX, this.cursorY, false);
		}

		// Token: 0x0600971F RID: 38687 RVA: 0x00367F1C File Offset: 0x0036611C
		public void OOEKPCOOGED()
		{
			this.sliderR.value = this.currentColor.r;
			this.sliderG.value = this.currentColor.g;
			this.sliderB.value = this.currentColor.b;
			this.sliderRText.text = "_Bullet_12" + this.currentColor.r * 123f;
			this.sliderGText.text = "menuthemes" + this.currentColor.g * 959f;
			this.sliderBText.text = "_History2ChromaTex" + this.currentColor.b * 285f;
		}

		// Token: 0x06009720 RID: 38688 RVA: 0x00367FEC File Offset: 0x003661EC
		private void BLELCKABFIP(float IHIAMPBEFEE)
		{
			this.currentColor.r = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.LHFMBFLLDCC(this.currentColor);
			}
			this.sliderRText.text = "Preparing configuration..." + (int)(this.currentColor.r * 465f);
			this.hexrgb.BLHHGAOOMJF();
		}

		// Token: 0x06009721 RID: 38689 RVA: 0x00368054 File Offset: 0x00366254
		private void FCLKOMNEGJD(float IHIAMPBEFEE)
		{
			this.currentColor.r = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.DMGNNBJPJCB(this.currentColor);
			}
			this.sliderRText.text = "_FlipAlphaMask" + (int)(this.currentColor.r * 1874f);
			this.hexrgb.DIAHNFBLBBO();
		}

		// Token: 0x06009722 RID: 38690 RVA: 0x003680BC File Offset: 0x003662BC
		public Color GetColor(float KLIELMPDLMF, float AOCOPGBKMNH)
		{
			return ((Texture2D)this.hsvImage.texture).GetPixel((int)(this.cursorX * (float)this.hsvImage.texture.width), (int)(this.cursorY * (float)this.hsvImage.texture.height));
		}

		// Token: 0x06009723 RID: 38691 RVA: 0x00368110 File Offset: 0x00366310
		private void APONLECBPAI()
		{
			if (this.hsvSlider.texture != null)
			{
				Object.Destroy(this.hsvSlider.texture);
			}
			if (this.hsvImage.texture != null)
			{
				Object.Destroy(this.hsvImage.texture);
			}
		}

		// Token: 0x06009724 RID: 38692 RVA: 0x0036816C File Offset: 0x0036636C
		public Color HCKOJAOINLA(float KLIELMPDLMF, float AOCOPGBKMNH)
		{
			return ((Texture2D)this.hsvImage.texture).GetPixel((int)(this.cursorX * (float)this.hsvImage.texture.width), (int)(this.cursorY * (float)this.hsvImage.texture.height));
		}

		// Token: 0x06009725 RID: 38693 RVA: 0x003681C0 File Offset: 0x003663C0
		private void FBBNBLKOMFA(float IHIAMPBEFEE)
		{
			this.currentColor.r = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.BAIIIOFFPJH(this.currentColor);
			}
			this.sliderRText.text = "blue" + (int)(this.currentColor.r * 624f);
			this.hexrgb.HJIPNGFEDBI();
		}

		// Token: 0x06009726 RID: 38694 RVA: 0x00368228 File Offset: 0x00366428
		public void HJCBLOBIFDC(Color HABLFKCCKLN)
		{
			HsvColor hsvColor = HSVUtil.ConvertRgbToHsv(HABLFKCCKLN);
			float hikpecaalnh = (float)(hsvColor.H / 90.0);
			this.JNDLPOGJFBC(hikpecaalnh, true);
			this.MoveCursor((float)hsvColor.S, (float)hsvColor.V, false);
			this.currentColor = HABLFKCCKLN;
			this.colorImage.color = this.currentColor;
			this.onValueChanged.Invoke(this.currentColor);
		}

		// Token: 0x06009727 RID: 38695 RVA: 0x0036829C File Offset: 0x0036649C
		private void DDAFHDCPHMK(float IHIAMPBEFEE)
		{
			this.currentColor.b = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.LHFMBFLLDCC(this.currentColor);
			}
			this.sliderBText.text = "Mouse " + (int)(this.currentColor.b * 1927f);
			this.hexrgb.FFBOGFLBMCD();
		}

		// Token: 0x06009728 RID: 38696 RVA: 0x00368304 File Offset: 0x00366504
		private void KECHJFPOJMM()
		{
			if (this.hsvSlider.texture != null)
			{
				Object.Destroy(this.hsvSlider.texture);
			}
			if (this.hsvImage.texture != null)
			{
				Object.Destroy(this.hsvImage.texture);
			}
		}

		// Token: 0x06009729 RID: 38697 RVA: 0x00368360 File Offset: 0x00366560
		private void AKBKEPNFOFC(float IHIAMPBEFEE)
		{
			this.currentColor.g = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.BAIIIOFFPJH(this.currentColor);
			}
			this.sliderGText.text = "steamid" + (int)(this.currentColor.g * 1605f);
			this.hexrgb.ANBOIOADEND();
		}

		// Token: 0x0600972A RID: 38698 RVA: 0x003683C8 File Offset: 0x003665C8
		private void LOBHKKPAIMD(float IHIAMPBEFEE)
		{
			this.currentColor.r = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.PFDIGIGFNMJ(this.currentColor);
			}
			this.sliderRText.text = "#ok" + (int)(this.currentColor.r * 1069f);
			this.hexrgb.EAOFHCPNKPB();
		}

		// Token: 0x0600972B RID: 38699 RVA: 0x00368430 File Offset: 0x00366630
		private void BPBHKBHFGLO(float IHIAMPBEFEE)
		{
			this.currentColor.g = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.BNOMKPGJOJO(this.currentColor);
			}
			this.sliderGText.text = "settings.showHP" + (int)(this.currentColor.g * 1574f);
			this.hexrgb.ICKAFLEOFCL();
		}

		// Token: 0x0600972C RID: 38700 RVA: 0x00368498 File Offset: 0x00366698
		private void IJILMPAKKLE(float IHIAMPBEFEE)
		{
			this.currentColor.b = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.HJCBLOBIFDC(this.currentColor);
			}
			this.sliderBText.text = "maps." + (int)(this.currentColor.b * 709f);
			this.hexrgb.BLHHGAOOMJF();
		}

		// Token: 0x0600972D RID: 38701 RVA: 0x00368500 File Offset: 0x00366700
		private void JPDCIFFNOPC(float IHIAMPBEFEE)
		{
			this.currentColor.g = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.OMIMHHOHACE(this.currentColor);
			}
			this.sliderGText.text = "_HalfResolution" + (int)(this.currentColor.g * 1651f);
			this.hexrgb.FFBOGFLBMCD();
		}

		// Token: 0x0600972E RID: 38702 RVA: 0x00368568 File Offset: 0x00366768
		private void EENFJGPFIPJ(float IHIAMPBEFEE)
		{
			this.currentColor.b = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.BAMGOBGMGEJ(this.currentColor);
			}
			this.sliderBText.text = "error" + (int)(this.currentColor.b * 1324f);
			this.hexrgb.HKIAFPCLONJ();
		}

		// Token: 0x0600972F RID: 38703 RVA: 0x003685D0 File Offset: 0x003667D0
		private void IPDNMHLJNNH(float IHIAMPBEFEE)
		{
			this.currentColor.g = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.EBPDHMAAEHN(this.currentColor);
			}
			this.sliderGText.text = "settings.enablehitsoundsinnormal" + (int)(this.currentColor.g * 519f);
			this.hexrgb.ILBDLGMJOIE();
		}

		// Token: 0x06009730 RID: 38704 RVA: 0x00368638 File Offset: 0x00366838
		private void LJEFMGOBKGE()
		{
			this.hsvSlider.texture = HSVUtil.GenerateHSVTexture((int)this.hsvSlider.rectTransform.rect.width, (int)this.hsvSlider.rectTransform.rect.height);
			this.sliderR.onValueChanged.AddListener(new UnityAction<float>(this.FCLKOMNEGJD));
			this.sliderG.onValueChanged.AddListener(new UnityAction<float>(this.JINLOPLJPKP));
			this.sliderB.onValueChanged.AddListener(new UnityAction<float>(this.ODCKLKHHLGM));
			this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, ((Texture2D)this.hsvSlider.texture).GetPixelBilinear(1865f, 520f));
			this.MCEAEBCFKFK(this.cursorX, this.cursorY, true);
		}

		// Token: 0x06009731 RID: 38705 RVA: 0x00368750 File Offset: 0x00366950
		public Color OHKJICGADGO(float KLIELMPDLMF, float AOCOPGBKMNH)
		{
			return ((Texture2D)this.hsvImage.texture).GetPixel((int)(this.cursorX * (float)this.hsvImage.texture.width), (int)(this.cursorY * (float)this.hsvImage.texture.height));
		}

		// Token: 0x06009732 RID: 38706 RVA: 0x003687A4 File Offset: 0x003669A4
		public Color JBNPKHEFCFB(float KLIELMPDLMF, float AOCOPGBKMNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (KLIELMPDLMF > 352f)
			{
				KLIELMPDLMF %= 112f;
			}
			if (AOCOPGBKMNH > 1158f)
			{
				AOCOPGBKMNH %= 1113f;
			}
			AOCOPGBKMNH = Mathf.Clamp(AOCOPGBKMNH, 1849f, 533f);
			KLIELMPDLMF = Mathf.Clamp(KLIELMPDLMF, 977f, 1368f);
			this.cursorX = KLIELMPDLMF;
			this.cursorY = AOCOPGBKMNH;
			this.cursor.rectTransform.anchoredPosition = new Vector2(KLIELMPDLMF * this.hsvImage.rectTransform.rect.width, AOCOPGBKMNH * this.hsvImage.rectTransform.rect.height - this.hsvImage.rectTransform.rect.height);
			this.currentColor = this.DKGHHPKGCNH(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.IELGMHAKLFJ();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = false;
			return this.currentColor;
		}

		// Token: 0x06009733 RID: 38707 RVA: 0x003688C8 File Offset: 0x00366AC8
		private void ILNCCGGGLAJ(float IHIAMPBEFEE)
		{
			this.currentColor.g = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.ONEGPGDDKEP(this.currentColor);
			}
			this.sliderGText.text = "CameraFilterPack/Blend2Camera_Overlay" + (int)(this.currentColor.g * 1660f);
			this.hexrgb.ILBDLGMJOIE();
		}

		// Token: 0x06009734 RID: 38708 RVA: 0x0002523B File Offset: 0x0002343B
		private void HMKBLLMIKAB()
		{
		}

		// Token: 0x06009735 RID: 38709 RVA: 0x00368930 File Offset: 0x00366B30
		private void ODCKLKHHLGM(float IHIAMPBEFEE)
		{
			this.currentColor.b = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.ONEGPGDDKEP(this.currentColor);
			}
			this.sliderBText.text = "_AdaptTex" + (int)(this.currentColor.b * 1997f);
			this.hexrgb.HJIPNGFEDBI();
		}

		// Token: 0x06009736 RID: 38710 RVA: 0x00368998 File Offset: 0x00366B98
		private void BEFHMMKCAHF(float IHIAMPBEFEE)
		{
			this.currentColor.b = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.LHFMBFLLDCC(this.currentColor);
			}
			this.sliderBText.text = "_Value7" + (int)(this.currentColor.b * 337f);
			this.hexrgb.IBEKKFCLOFL();
		}

		// Token: 0x06009737 RID: 38711 RVA: 0x00368A00 File Offset: 0x00366C00
		public Color KEFJONJEBFE(float KLIELMPDLMF, float AOCOPGBKMNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (KLIELMPDLMF > 1077f)
			{
				KLIELMPDLMF %= 1016f;
			}
			if (AOCOPGBKMNH > 1854f)
			{
				AOCOPGBKMNH %= 1976f;
			}
			AOCOPGBKMNH = Mathf.Clamp(AOCOPGBKMNH, 841f, 685f);
			KLIELMPDLMF = Mathf.Clamp(KLIELMPDLMF, 1357f, 1700f);
			this.cursorX = KLIELMPDLMF;
			this.cursorY = AOCOPGBKMNH;
			this.cursor.rectTransform.anchoredPosition = new Vector2(KLIELMPDLMF * this.hsvImage.rectTransform.rect.width, AOCOPGBKMNH * this.hsvImage.rectTransform.rect.height - this.hsvImage.rectTransform.rect.height);
			this.currentColor = this.HCKOJAOINLA(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.HLKPLMKICLN();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = true;
			return this.currentColor;
		}

		// Token: 0x06009738 RID: 38712 RVA: 0x00368B24 File Offset: 0x00366D24
		private void KBHEBICFHKO(float IHIAMPBEFEE)
		{
			this.currentColor.b = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.LGKIIIOFMCH(this.currentColor);
			}
			this.sliderBText.text = "received</b>\n#reason: " + (int)(this.currentColor.b * 78f);
			this.hexrgb.HKIAFPCLONJ();
		}

		// Token: 0x06009739 RID: 38713 RVA: 0x0002523B File Offset: 0x0002343B
		private void FBMDHDBELEK()
		{
		}

		// Token: 0x0600973A RID: 38714 RVA: 0x00368B8C File Offset: 0x00366D8C
		public Color MGHADEAILMD(float KLIELMPDLMF, float AOCOPGBKMNH)
		{
			return ((Texture2D)this.hsvImage.texture).GetPixel((int)(this.cursorX * (float)this.hsvImage.texture.width), (int)(this.cursorY * (float)this.hsvImage.texture.height));
		}

		// Token: 0x0600973B RID: 38715 RVA: 0x00368BE0 File Offset: 0x00366DE0
		public void MPBLJKAJOGC(Color HABLFKCCKLN)
		{
			HsvColor hsvColor = HSVUtil.ConvertRgbToHsv(HABLFKCCKLN);
			float hikpecaalnh = (float)(hsvColor.H / 1106.0);
			this.MovePointer(hikpecaalnh, false);
			this.MFNKCIPBGCM((float)hsvColor.S, (float)hsvColor.V, false);
			this.currentColor = HABLFKCCKLN;
			this.colorImage.color = this.currentColor;
			this.onValueChanged.Invoke(this.currentColor);
		}

		// Token: 0x0600973C RID: 38716 RVA: 0x00368C54 File Offset: 0x00366E54
		public Color MCEAEBCFKFK(float KLIELMPDLMF, float AOCOPGBKMNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (KLIELMPDLMF > 492f)
			{
				KLIELMPDLMF %= 90f;
			}
			if (AOCOPGBKMNH > 317f)
			{
				AOCOPGBKMNH %= 523f;
			}
			AOCOPGBKMNH = Mathf.Clamp(AOCOPGBKMNH, 896f, 886f);
			KLIELMPDLMF = Mathf.Clamp(KLIELMPDLMF, 143f, 1814f);
			this.cursorX = KLIELMPDLMF;
			this.cursorY = AOCOPGBKMNH;
			this.cursor.rectTransform.anchoredPosition = new Vector2(KLIELMPDLMF * this.hsvImage.rectTransform.rect.width, AOCOPGBKMNH * this.hsvImage.rectTransform.rect.height - this.hsvImage.rectTransform.rect.height);
			this.currentColor = this.MHDBJKLIGHC(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.UpdateInputs();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = true;
			return this.currentColor;
		}

		// Token: 0x0600973D RID: 38717 RVA: 0x00368D78 File Offset: 0x00366F78
		public void AssignColor(Color HABLFKCCKLN)
		{
			HsvColor hsvColor = HSVUtil.ConvertRgbToHsv(HABLFKCCKLN);
			float hikpecaalnh = (float)(hsvColor.H / 360.0);
			this.MovePointer(hikpecaalnh, false);
			this.MoveCursor((float)hsvColor.S, (float)hsvColor.V, false);
			this.currentColor = HABLFKCCKLN;
			this.colorImage.color = this.currentColor;
			this.onValueChanged.Invoke(this.currentColor);
		}

		// Token: 0x0600973E RID: 38718 RVA: 0x00368DEC File Offset: 0x00366FEC
		public void IELGMHAKLFJ()
		{
			this.sliderR.value = this.currentColor.r;
			this.sliderG.value = this.currentColor.g;
			this.sliderB.value = this.currentColor.b;
			this.sliderRText.text = "_Intensity" + this.currentColor.r * 45f;
			this.sliderGText.text = "player.violetarc" + this.currentColor.g * 310f;
			this.sliderBText.text = "_Value4" + this.currentColor.b * 359f;
		}

		// Token: 0x0600973F RID: 38719 RVA: 0x0002523B File Offset: 0x0002343B
		private void MDCFIHDPLIG()
		{
		}

		// Token: 0x06009740 RID: 38720 RVA: 0x00368EBC File Offset: 0x003670BC
		public void DMGNNBJPJCB(Color HABLFKCCKLN)
		{
			HsvColor hsvColor = HSVUtil.ConvertRgbToHsv(HABLFKCCKLN);
			float hikpecaalnh = (float)(hsvColor.H / 642.0);
			this.BCJJCNOOMLH(hikpecaalnh, true);
			this.MCEAEBCFKFK((float)hsvColor.S, (float)hsvColor.V, true);
			this.currentColor = HABLFKCCKLN;
			this.colorImage.color = this.currentColor;
			this.onValueChanged.Invoke(this.currentColor);
		}

		// Token: 0x06009741 RID: 38721 RVA: 0x00368F30 File Offset: 0x00367130
		private void BDBODDGIPBM()
		{
			if (this.hsvSlider.texture != null)
			{
				Object.Destroy(this.hsvSlider.texture);
			}
			if (this.hsvImage.texture != null)
			{
				Object.Destroy(this.hsvImage.texture);
			}
		}

		// Token: 0x06009742 RID: 38722 RVA: 0x00368F8C File Offset: 0x0036718C
		[CompilerGenerated]
		private void GJDIFKMHCFE(float IHIAMPBEFEE)
		{
			this.currentColor.g = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.AssignColor(this.currentColor);
			}
			this.sliderGText.text = "G:" + (int)(this.currentColor.g * 255f);
			this.hexrgb.ManipulateViaRGB2Hex();
		}

		// Token: 0x06009743 RID: 38723 RVA: 0x00368FF4 File Offset: 0x003671F4
		public Color IJJJBMPLNFH(float HIKPECAALNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (HIKPECAALNH > 10f)
			{
				HIKPECAALNH %= 229f;
			}
			this.pointerPos = HIKPECAALNH;
			Color pixelBilinear = ((Texture2D)this.hsvSlider.texture).GetPixelBilinear(696f, this.pointerPos);
			if (this.hsvImage.texture != null)
			{
				if ((int)this.hsvImage.rectTransform.rect.width != this.hsvImage.texture.width || (int)this.hsvImage.rectTransform.rect.height != this.hsvImage.texture.height)
				{
					Object.Destroy(this.hsvImage.texture);
					this.hsvImage.texture = null;
					this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, pixelBilinear);
				}
				else
				{
					HSVUtil.GenerateColorTexture(pixelBilinear, (Texture2D)this.hsvImage.texture);
				}
			}
			else
			{
				this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, pixelBilinear);
			}
			this.pointer.rectTransform.anchoredPosition = new Vector2(153f, -this.pointerPos * this.hsvSlider.rectTransform.rect.height);
			this.currentColor = this.DKGHHPKGCNH(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.HLKPLMKICLN();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = true;
			return this.currentColor;
		}

		// Token: 0x06009744 RID: 38724 RVA: 0x0036920C File Offset: 0x0036740C
		public Color OPACHIJIDDA(float HIKPECAALNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (HIKPECAALNH > 348f)
			{
				HIKPECAALNH %= 1586f;
			}
			this.pointerPos = HIKPECAALNH;
			Color pixelBilinear = ((Texture2D)this.hsvSlider.texture).GetPixelBilinear(915f, this.pointerPos);
			if (this.hsvImage.texture != null)
			{
				if ((int)this.hsvImage.rectTransform.rect.width != this.hsvImage.texture.width || (int)this.hsvImage.rectTransform.rect.height != this.hsvImage.texture.height)
				{
					Object.Destroy(this.hsvImage.texture);
					this.hsvImage.texture = null;
					this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, pixelBilinear);
				}
				else
				{
					HSVUtil.GenerateColorTexture(pixelBilinear, (Texture2D)this.hsvImage.texture);
				}
			}
			else
			{
				this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, pixelBilinear);
			}
			this.pointer.rectTransform.anchoredPosition = new Vector2(1870f, -this.pointerPos * this.hsvSlider.rectTransform.rect.height);
			this.currentColor = this.CCCDEPJFBNC(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.UpdateInputs();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = false;
			return this.currentColor;
		}

		// Token: 0x06009745 RID: 38725 RVA: 0x00369424 File Offset: 0x00367624
		private void JLPHGNMBAHI(float IHIAMPBEFEE)
		{
			this.currentColor.r = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.MPBLJKAJOGC(this.currentColor);
			}
			this.sliderRText.text = "UseFinalGlassColor" + (int)(this.currentColor.r * 163f);
			this.hexrgb.CMOGLJNIAJC();
		}

		// Token: 0x06009746 RID: 38726 RVA: 0x0036948C File Offset: 0x0036768C
		private void KEGNPKFMPDG()
		{
			this.hsvSlider.texture = HSVUtil.GenerateHSVTexture((int)this.hsvSlider.rectTransform.rect.width, (int)this.hsvSlider.rectTransform.rect.height);
			this.sliderR.onValueChanged.AddListener(new UnityAction<float>(this.JLPHGNMBAHI));
			this.sliderG.onValueChanged.AddListener(new UnityAction<float>(this.AKBKEPNFOFC));
			this.sliderB.onValueChanged.AddListener(new UnityAction<float>(this.FODOCLMICNM));
			this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, ((Texture2D)this.hsvSlider.texture).GetPixelBilinear(873f, 875f));
			this.MCEAEBCFKFK(this.cursorX, this.cursorY, true);
		}

		// Token: 0x06009747 RID: 38727 RVA: 0x003695A4 File Offset: 0x003677A4
		public Color CODGNPMGHJJ(float KLIELMPDLMF, float AOCOPGBKMNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (KLIELMPDLMF > 932f)
			{
				KLIELMPDLMF %= 1542f;
			}
			if (AOCOPGBKMNH > 1899f)
			{
				AOCOPGBKMNH %= 3f;
			}
			AOCOPGBKMNH = Mathf.Clamp(AOCOPGBKMNH, 88f, 970f);
			KLIELMPDLMF = Mathf.Clamp(KLIELMPDLMF, 1535f, 823f);
			this.cursorX = KLIELMPDLMF;
			this.cursorY = AOCOPGBKMNH;
			this.cursor.rectTransform.anchoredPosition = new Vector2(KLIELMPDLMF * this.hsvImage.rectTransform.rect.width, AOCOPGBKMNH * this.hsvImage.rectTransform.rect.height - this.hsvImage.rectTransform.rect.height);
			this.currentColor = this.CCCDEPJFBNC(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.OBBINGMCLJB();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = false;
			return this.currentColor;
		}

		// Token: 0x06009748 RID: 38728 RVA: 0x003696C8 File Offset: 0x003678C8
		public void AKFDDLPFCKC(Color HABLFKCCKLN)
		{
			HsvColor hsvColor = HSVUtil.ConvertRgbToHsv(HABLFKCCKLN);
			float hikpecaalnh = (float)(hsvColor.H / 275.0);
			this.JNDLPOGJFBC(hikpecaalnh, false);
			this.DCGAJPFAFMD((float)hsvColor.S, (float)hsvColor.V, true);
			this.currentColor = HABLFKCCKLN;
			this.colorImage.color = this.currentColor;
			this.onValueChanged.Invoke(this.currentColor);
		}

		// Token: 0x06009749 RID: 38729 RVA: 0x0036973C File Offset: 0x0036793C
		private void BICGEINHFHK(float IHIAMPBEFEE)
		{
			this.currentColor.b = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.OCAPBFOBPPP(this.currentColor);
			}
			this.sliderBText.text = "_TraceBehindObjects" + (int)(this.currentColor.b * 189f);
			this.hexrgb.BLHHGAOOMJF();
		}

		// Token: 0x0600974A RID: 38730 RVA: 0x003697A4 File Offset: 0x003679A4
		public void LGKIIIOFMCH(Color HABLFKCCKLN)
		{
			HsvColor hsvColor = HSVUtil.ConvertRgbToHsv(HABLFKCCKLN);
			float hikpecaalnh = (float)(hsvColor.H / 22.0);
			this.EMAFLKFIIEC(hikpecaalnh, false);
			this.MHBKFACADJG((float)hsvColor.S, (float)hsvColor.V, false);
			this.currentColor = HABLFKCCKLN;
			this.colorImage.color = this.currentColor;
			this.onValueChanged.Invoke(this.currentColor);
		}

		// Token: 0x0600974B RID: 38731 RVA: 0x00369818 File Offset: 0x00367A18
		private void KDPJOLMNEPG()
		{
			if (this.hsvSlider.texture != null)
			{
				Object.Destroy(this.hsvSlider.texture);
			}
			if (this.hsvImage.texture != null)
			{
				Object.Destroy(this.hsvImage.texture);
			}
		}

		// Token: 0x0600974C RID: 38732 RVA: 0x0002523B File Offset: 0x0002343B
		private void PFNFPINPCMH()
		{
		}

		// Token: 0x0600974D RID: 38733 RVA: 0x00369874 File Offset: 0x00367A74
		public void NHCIGGDCNJJ(Color HABLFKCCKLN)
		{
			HsvColor hsvColor = HSVUtil.ConvertRgbToHsv(HABLFKCCKLN);
			float hikpecaalnh = (float)(hsvColor.H / 1405.0);
			this.KFAKJNEIANF(hikpecaalnh, true);
			this.CLGFPIANGCA((float)hsvColor.S, (float)hsvColor.V, true);
			this.currentColor = HABLFKCCKLN;
			this.colorImage.color = this.currentColor;
			this.onValueChanged.Invoke(this.currentColor);
		}

		// Token: 0x0600974E RID: 38734 RVA: 0x003698E8 File Offset: 0x00367AE8
		public Color DCGAJPFAFMD(float KLIELMPDLMF, float AOCOPGBKMNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (KLIELMPDLMF > 1402f)
			{
				KLIELMPDLMF %= 1647f;
			}
			if (AOCOPGBKMNH > 1826f)
			{
				AOCOPGBKMNH %= 1648f;
			}
			AOCOPGBKMNH = Mathf.Clamp(AOCOPGBKMNH, 739f, 788f);
			KLIELMPDLMF = Mathf.Clamp(KLIELMPDLMF, 1805f, 1475f);
			this.cursorX = KLIELMPDLMF;
			this.cursorY = AOCOPGBKMNH;
			this.cursor.rectTransform.anchoredPosition = new Vector2(KLIELMPDLMF * this.hsvImage.rectTransform.rect.width, AOCOPGBKMNH * this.hsvImage.rectTransform.rect.height - this.hsvImage.rectTransform.rect.height);
			this.currentColor = this.FBHHNPEBLNA(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.UpdateInputs();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = false;
			return this.currentColor;
		}

		// Token: 0x0600974F RID: 38735 RVA: 0x00369A0C File Offset: 0x00367C0C
		public void ONEGPGDDKEP(Color HABLFKCCKLN)
		{
			HsvColor hsvColor = HSVUtil.ConvertRgbToHsv(HABLFKCCKLN);
			float hikpecaalnh = (float)(hsvColor.H / 1608.0);
			this.EDOLGAACHJF(hikpecaalnh, true);
			this.CODGNPMGHJJ((float)hsvColor.S, (float)hsvColor.V, true);
			this.currentColor = HABLFKCCKLN;
			this.colorImage.color = this.currentColor;
			this.onValueChanged.Invoke(this.currentColor);
		}

		// Token: 0x06009750 RID: 38736 RVA: 0x00369A80 File Offset: 0x00367C80
		private void OJEJJNJPBBD(float IHIAMPBEFEE)
		{
			this.currentColor.r = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.HJCBLOBIFDC(this.currentColor);
			}
			this.sliderRText.text = "EnableRankedNotificationsToggle" + (int)(this.currentColor.r * 1851f);
			this.hexrgb.HDCEJBAPBOF();
		}

		// Token: 0x06009751 RID: 38737 RVA: 0x00369AE8 File Offset: 0x00367CE8
		private void CGKMKGNEABL(float IHIAMPBEFEE)
		{
			this.currentColor.r = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.NHCIGGDCNJJ(this.currentColor);
			}
			this.sliderRText.text = "_Value" + (int)(this.currentColor.r * 641f);
			this.hexrgb.CMOGLJNIAJC();
		}

		// Token: 0x06009752 RID: 38738 RVA: 0x00369B50 File Offset: 0x00367D50
		private void CHGFDCKPIEF(float IHIAMPBEFEE)
		{
			this.currentColor.r = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.BAIIIOFFPJH(this.currentColor);
			}
			this.sliderRText.text = " " + (int)(this.currentColor.r * 94f);
			this.hexrgb.HJIPNGFEDBI();
		}

		// Token: 0x06009753 RID: 38739 RVA: 0x00369BB8 File Offset: 0x00367DB8
		public void LHFMBFLLDCC(Color HABLFKCCKLN)
		{
			HsvColor hsvColor = HSVUtil.ConvertRgbToHsv(HABLFKCCKLN);
			float hikpecaalnh = (float)(hsvColor.H / 1806.0);
			this.FMCDPHGFJDO(hikpecaalnh, false);
			this.MoveCursor((float)hsvColor.S, (float)hsvColor.V, false);
			this.currentColor = HABLFKCCKLN;
			this.colorImage.color = this.currentColor;
			this.onValueChanged.Invoke(this.currentColor);
		}

		// Token: 0x06009754 RID: 38740 RVA: 0x00369C2C File Offset: 0x00367E2C
		public void GOCJDIPCHCM()
		{
			this.sliderR.value = this.currentColor.r;
			this.sliderG.value = this.currentColor.g;
			this.sliderB.value = this.currentColor.b;
			this.sliderRText.text = "_Value2" + this.currentColor.r * 940f;
			this.sliderGText.text = "_TimeX" + this.currentColor.g * 1369f;
			this.sliderBText.text = "_ScreenResolution" + this.currentColor.b * 1129f;
		}

		// Token: 0x06009755 RID: 38741 RVA: 0x00369CFC File Offset: 0x00367EFC
		[CompilerGenerated]
		private void FODOCLMICNM(float IHIAMPBEFEE)
		{
			this.currentColor.b = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.AssignColor(this.currentColor);
			}
			this.sliderBText.text = "B:" + (int)(this.currentColor.b * 255f);
			this.hexrgb.ManipulateViaRGB2Hex();
		}

		// Token: 0x06009756 RID: 38742 RVA: 0x0002523B File Offset: 0x0002343B
		private void MFMIODIAKNI()
		{
		}

		// Token: 0x06009757 RID: 38743 RVA: 0x00369D64 File Offset: 0x00367F64
		public Color JENEEGJOOKM(float HIKPECAALNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (HIKPECAALNH > 500f)
			{
				HIKPECAALNH %= 1012f;
			}
			this.pointerPos = HIKPECAALNH;
			Color pixelBilinear = ((Texture2D)this.hsvSlider.texture).GetPixelBilinear(1852f, this.pointerPos);
			if (this.hsvImage.texture != null)
			{
				if ((int)this.hsvImage.rectTransform.rect.width != this.hsvImage.texture.width || (int)this.hsvImage.rectTransform.rect.height != this.hsvImage.texture.height)
				{
					Object.Destroy(this.hsvImage.texture);
					this.hsvImage.texture = null;
					this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, pixelBilinear);
				}
				else
				{
					HSVUtil.GenerateColorTexture(pixelBilinear, (Texture2D)this.hsvImage.texture);
				}
			}
			else
			{
				this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, pixelBilinear);
			}
			this.pointer.rectTransform.anchoredPosition = new Vector2(1021f, -this.pointerPos * this.hsvSlider.rectTransform.rect.height);
			this.currentColor = this.DKGHHPKGCNH(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.OBBINGMCLJB();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = false;
			return this.currentColor;
		}

		// Token: 0x06009758 RID: 38744 RVA: 0x00369F7C File Offset: 0x0036817C
		public Color DKGHHPKGCNH(float KLIELMPDLMF, float AOCOPGBKMNH)
		{
			return ((Texture2D)this.hsvImage.texture).GetPixel((int)(this.cursorX * (float)this.hsvImage.texture.width), (int)(this.cursorY * (float)this.hsvImage.texture.height));
		}

		// Token: 0x06009759 RID: 38745 RVA: 0x0002523B File Offset: 0x0002343B
		private void GCDLIKEDMCF()
		{
		}

		// Token: 0x0600975B RID: 38747 RVA: 0x00369FE4 File Offset: 0x003681E4
		private void EHKDAOCJCLG()
		{
			if (this.hsvSlider.texture != null)
			{
				Object.Destroy(this.hsvSlider.texture);
			}
			if (this.hsvImage.texture != null)
			{
				Object.Destroy(this.hsvImage.texture);
			}
		}

		// Token: 0x0600975C RID: 38748 RVA: 0x0036A040 File Offset: 0x00368240
		private void CDPBNLJPAKH()
		{
			if (this.hsvSlider.texture != null)
			{
				Object.Destroy(this.hsvSlider.texture);
			}
			if (this.hsvImage.texture != null)
			{
				Object.Destroy(this.hsvImage.texture);
			}
		}

		// Token: 0x0600975D RID: 38749 RVA: 0x0036A09C File Offset: 0x0036829C
		private void AMGODDDANKB()
		{
			this.hsvSlider.texture = HSVUtil.GenerateHSVTexture((int)this.hsvSlider.rectTransform.rect.width, (int)this.hsvSlider.rectTransform.rect.height);
			this.sliderR.onValueChanged.AddListener(new UnityAction<float>(this.FCLKOMNEGJD));
			this.sliderG.onValueChanged.AddListener(new UnityAction<float>(this.GJDIFKMHCFE));
			this.sliderB.onValueChanged.AddListener(new UnityAction<float>(this.JKLFJKMHANN));
			this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, ((Texture2D)this.hsvSlider.texture).GetPixelBilinear(1101f, 1144f));
			this.CLGFPIANGCA(this.cursorX, this.cursorY, false);
		}

		// Token: 0x0600975E RID: 38750 RVA: 0x0036A1B4 File Offset: 0x003683B4
		public void HLKPLMKICLN()
		{
			this.sliderR.value = this.currentColor.r;
			this.sliderG.value = this.currentColor.g;
			this.sliderB.value = this.currentColor.b;
			this.sliderRText.text = " ." + this.currentColor.r * 925f;
			this.sliderGText.text = "player.licenceaccepted" + this.currentColor.g * 1632f;
			this.sliderBText.text = " Message: " + this.currentColor.b * 385f;
		}

		// Token: 0x0600975F RID: 38751 RVA: 0x0002523B File Offset: 0x0002343B
		private void COMNAPAAPDO()
		{
		}

		// Token: 0x06009760 RID: 38752 RVA: 0x0036A284 File Offset: 0x00368484
		private void IPLHAFHIHIG(float IHIAMPBEFEE)
		{
			this.currentColor.b = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.HJCBLOBIFDC(this.currentColor);
			}
			this.sliderBText.text = "GameScene" + (int)(this.currentColor.b * 1391f);
			this.hexrgb.BLHHGAOOMJF();
		}

		// Token: 0x06009761 RID: 38753 RVA: 0x0036A2EC File Offset: 0x003684EC
		private void Awake()
		{
			this.hsvSlider.texture = HSVUtil.GenerateHSVTexture((int)this.hsvSlider.rectTransform.rect.width, (int)this.hsvSlider.rectTransform.rect.height);
			this.sliderR.onValueChanged.AddListener(new UnityAction<float>(this.EODMHHCLPIH));
			this.sliderG.onValueChanged.AddListener(new UnityAction<float>(this.GJDIFKMHCFE));
			this.sliderB.onValueChanged.AddListener(new UnityAction<float>(this.FODOCLMICNM));
			this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, ((Texture2D)this.hsvSlider.texture).GetPixelBilinear(0f, 0f));
			this.MoveCursor(this.cursorX, this.cursorY, true);
		}

		// Token: 0x06009762 RID: 38754 RVA: 0x0036A404 File Offset: 0x00368604
		public Color ACKLOKNCIBK(float KLIELMPDLMF, float AOCOPGBKMNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (KLIELMPDLMF > 799f)
			{
				KLIELMPDLMF %= 1929f;
			}
			if (AOCOPGBKMNH > 292f)
			{
				AOCOPGBKMNH %= 1439f;
			}
			AOCOPGBKMNH = Mathf.Clamp(AOCOPGBKMNH, 1807f, 921f);
			KLIELMPDLMF = Mathf.Clamp(KLIELMPDLMF, 802f, 373f);
			this.cursorX = KLIELMPDLMF;
			this.cursorY = AOCOPGBKMNH;
			this.cursor.rectTransform.anchoredPosition = new Vector2(KLIELMPDLMF * this.hsvImage.rectTransform.rect.width, AOCOPGBKMNH * this.hsvImage.rectTransform.rect.height - this.hsvImage.rectTransform.rect.height);
			this.currentColor = this.LDDAGHMBMEG(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.IELGMHAKLFJ();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = false;
			return this.currentColor;
		}

		// Token: 0x06009763 RID: 38755 RVA: 0x0036A528 File Offset: 0x00368728
		private void CCLDIMFBONJ()
		{
			if (this.hsvSlider.texture != null)
			{
				Object.Destroy(this.hsvSlider.texture);
			}
			if (this.hsvImage.texture != null)
			{
				Object.Destroy(this.hsvImage.texture);
			}
		}

		// Token: 0x06009764 RID: 38756 RVA: 0x0036A584 File Offset: 0x00368784
		public void BAIIIOFFPJH(Color HABLFKCCKLN)
		{
			HsvColor hsvColor = HSVUtil.ConvertRgbToHsv(HABLFKCCKLN);
			float hikpecaalnh = (float)(hsvColor.H / 1443.0);
			this.MovePointer(hikpecaalnh, false);
			this.MFNKCIPBGCM((float)hsvColor.S, (float)hsvColor.V, true);
			this.currentColor = HABLFKCCKLN;
			this.colorImage.color = this.currentColor;
			this.onValueChanged.Invoke(this.currentColor);
		}

		// Token: 0x06009765 RID: 38757 RVA: 0x0036A5F8 File Offset: 0x003687F8
		public Color LDDAGHMBMEG(float KLIELMPDLMF, float AOCOPGBKMNH)
		{
			return ((Texture2D)this.hsvImage.texture).GetPixel((int)(this.cursorX * (float)this.hsvImage.texture.width), (int)(this.cursorY * (float)this.hsvImage.texture.height));
		}

		// Token: 0x06009766 RID: 38758 RVA: 0x0036A64C File Offset: 0x0036884C
		public Color FMFAOABHACH(float KLIELMPDLMF, float AOCOPGBKMNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (KLIELMPDLMF > 705f)
			{
				KLIELMPDLMF %= 369f;
			}
			if (AOCOPGBKMNH > 350f)
			{
				AOCOPGBKMNH %= 1748f;
			}
			AOCOPGBKMNH = Mathf.Clamp(AOCOPGBKMNH, 408f, 1966f);
			KLIELMPDLMF = Mathf.Clamp(KLIELMPDLMF, 1774f, 842f);
			this.cursorX = KLIELMPDLMF;
			this.cursorY = AOCOPGBKMNH;
			this.cursor.rectTransform.anchoredPosition = new Vector2(KLIELMPDLMF * this.hsvImage.rectTransform.rect.width, AOCOPGBKMNH * this.hsvImage.rectTransform.rect.height - this.hsvImage.rectTransform.rect.height);
			this.currentColor = this.HCKOJAOINLA(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.GOCJDIPCHCM();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = true;
			return this.currentColor;
		}

		// Token: 0x06009767 RID: 38759 RVA: 0x0036A770 File Offset: 0x00368970
		public Color BCJJCNOOMLH(float HIKPECAALNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (HIKPECAALNH > 473f)
			{
				HIKPECAALNH %= 460f;
			}
			this.pointerPos = HIKPECAALNH;
			Color pixelBilinear = ((Texture2D)this.hsvSlider.texture).GetPixelBilinear(847f, this.pointerPos);
			if (this.hsvImage.texture != null)
			{
				if ((int)this.hsvImage.rectTransform.rect.width != this.hsvImage.texture.width || (int)this.hsvImage.rectTransform.rect.height != this.hsvImage.texture.height)
				{
					Object.Destroy(this.hsvImage.texture);
					this.hsvImage.texture = null;
					this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, pixelBilinear);
				}
				else
				{
					HSVUtil.GenerateColorTexture(pixelBilinear, (Texture2D)this.hsvImage.texture);
				}
			}
			else
			{
				this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, pixelBilinear);
			}
			this.pointer.rectTransform.anchoredPosition = new Vector2(11f, -this.pointerPos * this.hsvSlider.rectTransform.rect.height);
			this.currentColor = this.HCKOJAOINLA(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.OOEKPCOOGED();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = false;
			return this.currentColor;
		}

		// Token: 0x06009768 RID: 38760 RVA: 0x0036A988 File Offset: 0x00368B88
		private void JINLOPLJPKP(float IHIAMPBEFEE)
		{
			this.currentColor.g = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.EBMKANJLKCF(this.currentColor);
			}
			this.sliderGText.text = "SfxVolumeSlider" + (int)(this.currentColor.g * 1726f);
			this.hexrgb.LGFPAHPHKCB();
		}

		// Token: 0x06009769 RID: 38761 RVA: 0x0036A9F0 File Offset: 0x00368BF0
		private void PAIKMMLAIAE(float IHIAMPBEFEE)
		{
			this.currentColor.g = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.AssignColor(this.currentColor);
			}
			this.sliderGText.text = "_TimeX" + (int)(this.currentColor.g * 125f);
			this.hexrgb.CMOGLJNIAJC();
		}

		// Token: 0x0600976A RID: 38762 RVA: 0x0036AA58 File Offset: 0x00368C58
		private void IFONIPPABNA()
		{
			if (this.hsvSlider.texture != null)
			{
				Object.Destroy(this.hsvSlider.texture);
			}
			if (this.hsvImage.texture != null)
			{
				Object.Destroy(this.hsvImage.texture);
			}
		}

		// Token: 0x0600976B RID: 38763 RVA: 0x0036AAB4 File Offset: 0x00368CB4
		public void BAMGOBGMGEJ(Color HABLFKCCKLN)
		{
			HsvColor hsvColor = HSVUtil.ConvertRgbToHsv(HABLFKCCKLN);
			float hikpecaalnh = (float)(hsvColor.H / 1508.0);
			this.OPACHIJIDDA(hikpecaalnh, false);
			this.MCEAEBCFKFK((float)hsvColor.S, (float)hsvColor.V, true);
			this.currentColor = HABLFKCCKLN;
			this.colorImage.color = this.currentColor;
			this.onValueChanged.Invoke(this.currentColor);
		}

		// Token: 0x0600976C RID: 38764 RVA: 0x0036AB28 File Offset: 0x00368D28
		public void UpdateInputs()
		{
			this.sliderR.value = this.currentColor.r;
			this.sliderG.value = this.currentColor.g;
			this.sliderB.value = this.currentColor.b;
			this.sliderRText.text = "R:" + this.currentColor.r * 255f;
			this.sliderGText.text = "G:" + this.currentColor.g * 255f;
			this.sliderBText.text = "B:" + this.currentColor.b * 255f;
		}

		// Token: 0x0600976D RID: 38765 RVA: 0x0036ABF8 File Offset: 0x00368DF8
		public Color MoveCursor(float KLIELMPDLMF, float AOCOPGBKMNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (KLIELMPDLMF > 1f)
			{
				KLIELMPDLMF %= 1f;
			}
			if (AOCOPGBKMNH > 1f)
			{
				AOCOPGBKMNH %= 1f;
			}
			AOCOPGBKMNH = Mathf.Clamp(AOCOPGBKMNH, 0f, 0.9999f);
			KLIELMPDLMF = Mathf.Clamp(KLIELMPDLMF, 0f, 0.9999f);
			this.cursorX = KLIELMPDLMF;
			this.cursorY = AOCOPGBKMNH;
			this.cursor.rectTransform.anchoredPosition = new Vector2(KLIELMPDLMF * this.hsvImage.rectTransform.rect.width, AOCOPGBKMNH * this.hsvImage.rectTransform.rect.height - this.hsvImage.rectTransform.rect.height);
			this.currentColor = this.GetColor(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.UpdateInputs();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = false;
			return this.currentColor;
		}

		// Token: 0x0600976E RID: 38766 RVA: 0x0036AD1C File Offset: 0x00368F1C
		public Color MHDBJKLIGHC(float KLIELMPDLMF, float AOCOPGBKMNH)
		{
			return ((Texture2D)this.hsvImage.texture).GetPixel((int)(this.cursorX * (float)this.hsvImage.texture.width), (int)(this.cursorY * (float)this.hsvImage.texture.height));
		}

		// Token: 0x0600976F RID: 38767 RVA: 0x0036AD70 File Offset: 0x00368F70
		public Color BFHJCALADND(float KLIELMPDLMF, float AOCOPGBKMNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (KLIELMPDLMF > 1940f)
			{
				KLIELMPDLMF %= 954f;
			}
			if (AOCOPGBKMNH > 1381f)
			{
				AOCOPGBKMNH %= 1523f;
			}
			AOCOPGBKMNH = Mathf.Clamp(AOCOPGBKMNH, 360f, 349f);
			KLIELMPDLMF = Mathf.Clamp(KLIELMPDLMF, 343f, 204f);
			this.cursorX = KLIELMPDLMF;
			this.cursorY = AOCOPGBKMNH;
			this.cursor.rectTransform.anchoredPosition = new Vector2(KLIELMPDLMF * this.hsvImage.rectTransform.rect.width, AOCOPGBKMNH * this.hsvImage.rectTransform.rect.height - this.hsvImage.rectTransform.rect.height);
			this.currentColor = this.HCKOJAOINLA(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.UpdateInputs();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = false;
			return this.currentColor;
		}

		// Token: 0x06009770 RID: 38768 RVA: 0x0036AE94 File Offset: 0x00369094
		private void CMDKGBAAGDP()
		{
			if (this.hsvSlider.texture != null)
			{
				Object.Destroy(this.hsvSlider.texture);
			}
			if (this.hsvImage.texture != null)
			{
				Object.Destroy(this.hsvImage.texture);
			}
		}

		// Token: 0x06009771 RID: 38769 RVA: 0x0002523B File Offset: 0x0002343B
		private void Update()
		{
		}

		// Token: 0x06009772 RID: 38770 RVA: 0x0036AEF0 File Offset: 0x003690F0
		private void MADENBGHKDD()
		{
			this.hsvSlider.texture = HSVUtil.GenerateHSVTexture((int)this.hsvSlider.rectTransform.rect.width, (int)this.hsvSlider.rectTransform.rect.height);
			this.sliderR.onValueChanged.AddListener(new UnityAction<float>(this.MHPBNANLAOE));
			this.sliderG.onValueChanged.AddListener(new UnityAction<float>(this.BPBHKBHFGLO));
			this.sliderB.onValueChanged.AddListener(new UnityAction<float>(this.JKLFJKMHANN));
			this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, ((Texture2D)this.hsvSlider.texture).GetPixelBilinear(1104f, 221f));
			this.CODGNPMGHJJ(this.cursorX, this.cursorY, false);
		}

		// Token: 0x06009773 RID: 38771 RVA: 0x0036B008 File Offset: 0x00369208
		private void LLIKHGIPCLA(float IHIAMPBEFEE)
		{
			this.currentColor.b = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.OMIMHHOHACE(this.currentColor);
			}
			this.sliderBText.text = "SetRoomStartTimestamp" + (int)(this.currentColor.b * 773f);
			this.hexrgb.ICKAFLEOFCL();
		}

		// Token: 0x06009774 RID: 38772 RVA: 0x0036B070 File Offset: 0x00369270
		public void EBMKANJLKCF(Color HABLFKCCKLN)
		{
			HsvColor hsvColor = HSVUtil.ConvertRgbToHsv(HABLFKCCKLN);
			float hikpecaalnh = (float)(hsvColor.H / 195.0);
			this.EMAFLKFIIEC(hikpecaalnh, false);
			this.BFHJCALADND((float)hsvColor.S, (float)hsvColor.V, true);
			this.currentColor = HABLFKCCKLN;
			this.colorImage.color = this.currentColor;
			this.onValueChanged.Invoke(this.currentColor);
		}

		// Token: 0x06009775 RID: 38773 RVA: 0x0036B0E4 File Offset: 0x003692E4
		private void OKADMJFLMGP()
		{
			this.hsvSlider.texture = HSVUtil.GenerateHSVTexture((int)this.hsvSlider.rectTransform.rect.width, (int)this.hsvSlider.rectTransform.rect.height);
			this.sliderR.onValueChanged.AddListener(new UnityAction<float>(this.COEJBPOOIKP));
			this.sliderG.onValueChanged.AddListener(new UnityAction<float>(this.JINLOPLJPKP));
			this.sliderB.onValueChanged.AddListener(new UnityAction<float>(this.KHBFJJFPANN));
			this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, ((Texture2D)this.hsvSlider.texture).GetPixelBilinear(1642f, 1816f));
			this.KNKLBKDLMDL(this.cursorX, this.cursorY, false);
		}

		// Token: 0x06009776 RID: 38774 RVA: 0x0036B1FC File Offset: 0x003693FC
		private void GEGFJJBCHPE()
		{
			this.hsvSlider.texture = HSVUtil.GenerateHSVTexture((int)this.hsvSlider.rectTransform.rect.width, (int)this.hsvSlider.rectTransform.rect.height);
			this.sliderR.onValueChanged.AddListener(new UnityAction<float>(this.OJEJJNJPBBD));
			this.sliderG.onValueChanged.AddListener(new UnityAction<float>(this.PAIKMMLAIAE));
			this.sliderB.onValueChanged.AddListener(new UnityAction<float>(this.BICGEINHFHK));
			this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, ((Texture2D)this.hsvSlider.texture).GetPixelBilinear(1103f, 682f));
			this.HOOJNFKDBAK(this.cursorX, this.cursorY, true);
		}

		// Token: 0x06009777 RID: 38775 RVA: 0x0036B314 File Offset: 0x00369514
		public Color KGPOGLMEFJK(float HIKPECAALNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (HIKPECAALNH > 556f)
			{
				HIKPECAALNH %= 325f;
			}
			this.pointerPos = HIKPECAALNH;
			Color pixelBilinear = ((Texture2D)this.hsvSlider.texture).GetPixelBilinear(1578f, this.pointerPos);
			if (this.hsvImage.texture != null)
			{
				if ((int)this.hsvImage.rectTransform.rect.width != this.hsvImage.texture.width || (int)this.hsvImage.rectTransform.rect.height != this.hsvImage.texture.height)
				{
					Object.Destroy(this.hsvImage.texture);
					this.hsvImage.texture = null;
					this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, pixelBilinear);
				}
				else
				{
					HSVUtil.GenerateColorTexture(pixelBilinear, (Texture2D)this.hsvImage.texture);
				}
			}
			else
			{
				this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, pixelBilinear);
			}
			this.pointer.rectTransform.anchoredPosition = new Vector2(1240f, -this.pointerPos * this.hsvSlider.rectTransform.rect.height);
			this.currentColor = this.GetColor(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.GOCJDIPCHCM();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = true;
			return this.currentColor;
		}

		// Token: 0x06009778 RID: 38776 RVA: 0x0036B52C File Offset: 0x0036972C
		public Color MHBKFACADJG(float KLIELMPDLMF, float AOCOPGBKMNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (KLIELMPDLMF > 1198f)
			{
				KLIELMPDLMF %= 1695f;
			}
			if (AOCOPGBKMNH > 1188f)
			{
				AOCOPGBKMNH %= 1603f;
			}
			AOCOPGBKMNH = Mathf.Clamp(AOCOPGBKMNH, 774f, 917f);
			KLIELMPDLMF = Mathf.Clamp(KLIELMPDLMF, 994f, 693f);
			this.cursorX = KLIELMPDLMF;
			this.cursorY = AOCOPGBKMNH;
			this.cursor.rectTransform.anchoredPosition = new Vector2(KLIELMPDLMF * this.hsvImage.rectTransform.rect.width, AOCOPGBKMNH * this.hsvImage.rectTransform.rect.height - this.hsvImage.rectTransform.rect.height);
			this.currentColor = this.LDDAGHMBMEG(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.IELGMHAKLFJ();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = true;
			return this.currentColor;
		}

		// Token: 0x06009779 RID: 38777 RVA: 0x0036B650 File Offset: 0x00369850
		private void DFNBLGHACMM()
		{
			this.hsvSlider.texture = HSVUtil.GenerateHSVTexture((int)this.hsvSlider.rectTransform.rect.width, (int)this.hsvSlider.rectTransform.rect.height);
			this.sliderR.onValueChanged.AddListener(new UnityAction<float>(this.OJEJJNJPBBD));
			this.sliderG.onValueChanged.AddListener(new UnityAction<float>(this.LMIBJIFIIHC));
			this.sliderB.onValueChanged.AddListener(new UnityAction<float>(this.BEFHMMKCAHF));
			this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, ((Texture2D)this.hsvSlider.texture).GetPixelBilinear(1648f, 1353f));
			this.MFNKCIPBGCM(this.cursorX, this.cursorY, false);
		}

		// Token: 0x0600977A RID: 38778 RVA: 0x0036B768 File Offset: 0x00369968
		private void MNHJHOOABKA()
		{
			if (this.hsvSlider.texture != null)
			{
				Object.Destroy(this.hsvSlider.texture);
			}
			if (this.hsvImage.texture != null)
			{
				Object.Destroy(this.hsvImage.texture);
			}
		}

		// Token: 0x0600977B RID: 38779 RVA: 0x0036B7C4 File Offset: 0x003699C4
		public Color FBHHNPEBLNA(float KLIELMPDLMF, float AOCOPGBKMNH)
		{
			return ((Texture2D)this.hsvImage.texture).GetPixel((int)(this.cursorX * (float)this.hsvImage.texture.width), (int)(this.cursorY * (float)this.hsvImage.texture.height));
		}

		// Token: 0x0600977C RID: 38780 RVA: 0x0036B818 File Offset: 0x00369A18
		private void FJMJAMNKDKC(float IHIAMPBEFEE)
		{
			this.currentColor.g = IHIAMPBEFEE;
			if (!this.KFDNDLOHFIJ)
			{
				this.OCAPBFOBPPP(this.currentColor);
			}
			this.sliderGText.text = "CameraFilterPack_Glasses_On3" + (int)(this.currentColor.g * 902f);
			this.hexrgb.HKLHPALNLJF();
		}

		// Token: 0x0600977D RID: 38781 RVA: 0x0036B880 File Offset: 0x00369A80
		public Color KFAKJNEIANF(float HIKPECAALNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (HIKPECAALNH > 313f)
			{
				HIKPECAALNH %= 205f;
			}
			this.pointerPos = HIKPECAALNH;
			Color pixelBilinear = ((Texture2D)this.hsvSlider.texture).GetPixelBilinear(800f, this.pointerPos);
			if (this.hsvImage.texture != null)
			{
				if ((int)this.hsvImage.rectTransform.rect.width != this.hsvImage.texture.width || (int)this.hsvImage.rectTransform.rect.height != this.hsvImage.texture.height)
				{
					Object.Destroy(this.hsvImage.texture);
					this.hsvImage.texture = null;
					this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, pixelBilinear);
				}
				else
				{
					HSVUtil.GenerateColorTexture(pixelBilinear, (Texture2D)this.hsvImage.texture);
				}
			}
			else
			{
				this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, pixelBilinear);
			}
			this.pointer.rectTransform.anchoredPosition = new Vector2(881f, -this.pointerPos * this.hsvSlider.rectTransform.rect.height);
			this.currentColor = this.MHDBJKLIGHC(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.OBBINGMCLJB();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = false;
			return this.currentColor;
		}

		// Token: 0x0600977E RID: 38782 RVA: 0x0036BA98 File Offset: 0x00369C98
		public void OMIMHHOHACE(Color HABLFKCCKLN)
		{
			HsvColor hsvColor = HSVUtil.ConvertRgbToHsv(HABLFKCCKLN);
			float hikpecaalnh = (float)(hsvColor.H / 1339.0);
			this.OPACHIJIDDA(hikpecaalnh, true);
			this.KEFJONJEBFE((float)hsvColor.S, (float)hsvColor.V, false);
			this.currentColor = HABLFKCCKLN;
			this.colorImage.color = this.currentColor;
			this.onValueChanged.Invoke(this.currentColor);
		}

		// Token: 0x0600977F RID: 38783 RVA: 0x0036BB0C File Offset: 0x00369D0C
		public Color FMCDPHGFJDO(float HIKPECAALNH, bool PNDMONOCKCN = true)
		{
			this.KFDNDLOHFIJ = PNDMONOCKCN;
			if (HIKPECAALNH > 1311f)
			{
				HIKPECAALNH %= 1258f;
			}
			this.pointerPos = HIKPECAALNH;
			Color pixelBilinear = ((Texture2D)this.hsvSlider.texture).GetPixelBilinear(489f, this.pointerPos);
			if (this.hsvImage.texture != null)
			{
				if ((int)this.hsvImage.rectTransform.rect.width != this.hsvImage.texture.width || (int)this.hsvImage.rectTransform.rect.height != this.hsvImage.texture.height)
				{
					Object.Destroy(this.hsvImage.texture);
					this.hsvImage.texture = null;
					this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, pixelBilinear);
				}
				else
				{
					HSVUtil.GenerateColorTexture(pixelBilinear, (Texture2D)this.hsvImage.texture);
				}
			}
			else
			{
				this.hsvImage.texture = HSVUtil.GenerateColorTexture((int)this.hsvImage.rectTransform.rect.width, (int)this.hsvImage.rectTransform.rect.height, pixelBilinear);
			}
			this.pointer.rectTransform.anchoredPosition = new Vector2(50f, -this.pointerPos * this.hsvSlider.rectTransform.rect.height);
			this.currentColor = this.GetColor(this.cursorX, this.cursorY);
			this.colorImage.color = this.currentColor;
			if (PNDMONOCKCN)
			{
				this.OIGKHAIHANI();
				this.onValueChanged.Invoke(this.currentColor);
			}
			this.KFDNDLOHFIJ = true;
			return this.currentColor;
		}

		// Token: 0x06009780 RID: 38784 RVA: 0x0002523B File Offset: 0x0002343B
		private void KMEONPMCNJG()
		{
		}

		// Token: 0x04001121 RID: 4385
		public HexRGB hexrgb;

		// Token: 0x04001122 RID: 4386
		public Color currentColor;

		// Token: 0x04001123 RID: 4387
		public Image colorImage;

		// Token: 0x04001124 RID: 4388
		public Image pointer;

		// Token: 0x04001125 RID: 4389
		public Image cursor;

		// Token: 0x04001126 RID: 4390
		public RawImage hsvSlider;

		// Token: 0x04001127 RID: 4391
		public RawImage hsvImage;

		// Token: 0x04001128 RID: 4392
		public Slider sliderR;

		// Token: 0x04001129 RID: 4393
		public Slider sliderG;

		// Token: 0x0400112A RID: 4394
		public Slider sliderB;

		// Token: 0x0400112B RID: 4395
		public Text sliderRText;

		// Token: 0x0400112C RID: 4396
		public Text sliderGText;

		// Token: 0x0400112D RID: 4397
		public Text sliderBText;

		// Token: 0x0400112E RID: 4398
		public float pointerPos;

		// Token: 0x0400112F RID: 4399
		public float cursorX;

		// Token: 0x04001130 RID: 4400
		public float cursorY;

		// Token: 0x04001131 RID: 4401
		public HSVSliderEvent onValueChanged = new HSVSliderEvent();

		// Token: 0x04001132 RID: 4402
		private bool KFDNDLOHFIJ;
	}
}
