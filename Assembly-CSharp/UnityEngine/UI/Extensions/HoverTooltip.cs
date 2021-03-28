using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002A3 RID: 675
	public class HoverTooltip : MonoBehaviour
	{
		// Token: 0x0600A26D RID: 41581 RVA: 0x003C928C File Offset: 0x003C748C
		public void BFAOCEONBPE()
		{
			Vector3 position = this.HLGFJLGJNCK.ScreenToViewportPoint(Input.mousePosition);
			float num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num > this.MKGAFHHNMII.x)
			{
				float num2 = this.MKGAFHHNMII.x - num;
				float num3;
				if ((double)num2 > (double)this.OCFIFJDJNMI * 1223.0)
				{
					num3 = num2;
				}
				else
				{
					num3 = this.OCFIFJDJNMI - this.GAFKGLFACMF * 1675f;
				}
				Vector3 position2 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + num3, 892f, 936f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position2).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num < this.DFMPILPKNEG.x)
			{
				float num4 = this.DFMPILPKNEG.x - num;
				float num3;
				if ((double)num4 < (double)this.OCFIFJDJNMI * 825.0 - (double)this.GAFKGLFACMF)
				{
					num3 = -num4;
				}
				else
				{
					num3 = this.GAFKGLFACMF * 504f;
				}
				Vector3 position3 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - num3, 580f, 742f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position3).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - (this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y - this.LNFALDIJMLM);
			if (num > this.MKGAFHHNMII.y)
			{
				float num5 = this.MKGAFHHNMII.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num5 > (double)this.HMPNJBOIOAH * 1216.0)
				{
					num6 = num5;
				}
				else
				{
					num6 = this.HMPNJBOIOAH - this.LNFALDIJMLM * 1563f;
				}
				Vector3 position4 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 1041f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position4).y;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
			if (num < this.DFMPILPKNEG.y)
			{
				float num7 = this.DFMPILPKNEG.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num7 < (double)this.HMPNJBOIOAH * 1818.0 - (double)this.LNFALDIJMLM)
				{
					num6 = num7;
				}
				else
				{
					num6 = this.LNFALDIJMLM * 736f;
				}
				Vector3 position5 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 1735f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position5).y;
			}
			base.transform.parent.transform.position = new Vector3(this.HLGFJLGJNCK.ViewportToWorldPoint(position).x, this.HLGFJLGJNCK.ViewportToWorldPoint(position).y, 231f);
			base.transform.parent.gameObject.SetActive(true);
			this.MPFNCILGNLK = false;
		}

		// Token: 0x0600A26E RID: 41582 RVA: 0x003C96E6 File Offset: 0x003C78E6
		public void IENIOCCOJFI()
		{
			if (this.OKDFHMNJLOO == RenderMode.ScreenSpaceOverlay && this != null)
			{
				base.transform.parent.gameObject.SetActive(true);
				this.MPFNCILGNLK = false;
				this.FHBGAJFEMCO();
			}
		}

		// Token: 0x0600A26F RID: 41583 RVA: 0x003C9724 File Offset: 0x003C7924
		public void FIMJEONECKI()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 1793f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 1738f);
		}

		// Token: 0x0600A270 RID: 41584 RVA: 0x003C97B8 File Offset: 0x003C79B8
		public void PPKHEFACPBJ()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 778f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 796f);
		}

		// Token: 0x0600A271 RID: 41585 RVA: 0x003C9849 File Offset: 0x003C7A49
		private void KCDOMIJBFLL()
		{
			this.BPPOBJBHEBA();
			if (this.MPFNCILGNLK && this.OKDFHMNJLOO == RenderMode.ScreenSpaceOverlay)
			{
				this.GOIOPCBBPJA();
			}
		}

		// Token: 0x0600A272 RID: 41586 RVA: 0x003C986E File Offset: 0x003C7A6E
		public void IFIAIDCHIEK(string EAFAMAMDNEG, bool IMLPKOPBOMM)
		{
			this.LPEOABKMECM();
			this.thisText.text = EAFAMAMDNEG;
			this.OGPLAIENJNI();
		}

		// Token: 0x0600A273 RID: 41587 RVA: 0x003C9888 File Offset: 0x003C7A88
		public void LHINCEHBMJA()
		{
			Vector3 position = this.HLGFJLGJNCK.ScreenToViewportPoint(Input.mousePosition);
			float num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num > this.MKGAFHHNMII.x)
			{
				float num2 = this.MKGAFHHNMII.x - num;
				float num3;
				if ((double)num2 > (double)this.OCFIFJDJNMI * 715.0)
				{
					num3 = num2;
				}
				else
				{
					num3 = this.OCFIFJDJNMI - this.GAFKGLFACMF * 1999f;
				}
				Vector3 position2 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + num3, 555f, 1662f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position2).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num < this.DFMPILPKNEG.x)
			{
				float num4 = this.DFMPILPKNEG.x - num;
				float num3;
				if ((double)num4 < (double)this.OCFIFJDJNMI * 1885.0 - (double)this.GAFKGLFACMF)
				{
					num3 = -num4;
				}
				else
				{
					num3 = this.GAFKGLFACMF * 567f;
				}
				Vector3 position3 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - num3, 301f, 1261f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position3).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - (this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y - this.LNFALDIJMLM);
			if (num > this.MKGAFHHNMII.y)
			{
				float num5 = this.MKGAFHHNMII.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num5 > (double)this.HMPNJBOIOAH * 1140.0)
				{
					num6 = num5;
				}
				else
				{
					num6 = this.HMPNJBOIOAH - this.LNFALDIJMLM * 707f;
				}
				Vector3 position4 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 1350f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position4).y;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
			if (num < this.DFMPILPKNEG.y)
			{
				float num7 = this.DFMPILPKNEG.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num7 < (double)this.HMPNJBOIOAH * 168.0 - (double)this.LNFALDIJMLM)
				{
					num6 = num7;
				}
				else
				{
					num6 = this.LNFALDIJMLM * 312f;
				}
				Vector3 position5 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 34f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position5).y;
			}
			base.transform.parent.transform.position = new Vector3(this.HLGFJLGJNCK.ViewportToWorldPoint(position).x, this.HLGFJLGJNCK.ViewportToWorldPoint(position).y, 129f);
			base.transform.parent.gameObject.SetActive(true);
			this.MPFNCILGNLK = true;
		}

		// Token: 0x0600A274 RID: 41588 RVA: 0x003C9CE4 File Offset: 0x003C7EE4
		private void IHLMNAGPKDA()
		{
			this.HLGFJLGJNCK = GameObject.Find("CameraFilterPack/Blend2Camera_Darken").GetComponent<Camera>();
			this.OKDFHMNJLOO = base.transform.parent.parent.GetComponent<Canvas>().renderMode;
			this.DFEFFGOJFLL = this.bgImage.GetComponent<Image>();
			this.MPFNCILGNLK = true;
			this.NHKOOGBPKPD();
			base.transform.parent.gameObject.SetActive(false);
		}

		// Token: 0x0600A275 RID: 41589 RVA: 0x003C9D5A File Offset: 0x003C7F5A
		public void SetTooltip(string EAFAMAMDNEG)
		{
			this.PFFEMADMOKE();
			this.thisText.text = EAFAMAMDNEG;
			this.OnScreenSpaceCamera();
		}

		// Token: 0x0600A276 RID: 41590 RVA: 0x003C9D74 File Offset: 0x003C7F74
		public void CKOMLABFNIM()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 1528f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 1980f);
		}

		// Token: 0x0600A277 RID: 41591 RVA: 0x003C9E08 File Offset: 0x003C8008
		private void IOGALJLDAJD()
		{
			this.GHOKOLMJONF = true;
			this.DFMPILPKNEG = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(1682f, 493f, 1618f));
			this.MKGAFHHNMII = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(1623f, 496f, 867f));
			this.DMKHNNKODCF = (float)Screen.height / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.y;
			this.GFLLFHDMEAM = (float)Screen.width / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.x;
		}

		// Token: 0x0600A278 RID: 41592 RVA: 0x003C9EBC File Offset: 0x003C80BC
		private void JMDBONEFBIP()
		{
			this.GHOKOLMJONF = false;
			this.DFMPILPKNEG = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(88f, 1783f, 968f));
			this.MKGAFHHNMII = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(1780f, 1840f, 230f));
			this.DMKHNNKODCF = (float)Screen.height / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.y;
			this.GFLLFHDMEAM = (float)Screen.width / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.x;
		}

		// Token: 0x0600A279 RID: 41593 RVA: 0x003C9F70 File Offset: 0x003C8170
		public void HAHEGNFNJLM()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 1568f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 602f);
		}

		// Token: 0x0600A27A RID: 41594 RVA: 0x003CA004 File Offset: 0x003C8204
		private void LGHCJCFHEMF()
		{
			this.HLGFJLGJNCK = GameObject.Find("_Value2").GetComponent<Camera>();
			this.OKDFHMNJLOO = base.transform.parent.parent.GetComponent<Canvas>().renderMode;
			this.DFEFFGOJFLL = this.bgImage.GetComponent<Image>();
			this.MPFNCILGNLK = false;
			this.PKEECCGECNK();
			base.transform.parent.gameObject.SetActive(false);
		}

		// Token: 0x0600A27B RID: 41595 RVA: 0x003CA07A File Offset: 0x003C827A
		public void FPIMLHLBMGK()
		{
			if (this.OKDFHMNJLOO == RenderMode.ScreenSpaceCamera && this != null)
			{
				base.transform.parent.gameObject.SetActive(true);
				this.MPFNCILGNLK = false;
				this.FAIJEGEALAD();
			}
		}

		// Token: 0x0600A27C RID: 41596 RVA: 0x003CA0B8 File Offset: 0x003C82B8
		public void FEEPCNIPGOD(string[] GNLOGEDHNGF)
		{
			this.CBNAKNCIMNI();
			string text = string.Empty;
			int num = 0;
			for (int i = 1; i < GNLOGEDHNGF.Length; i++)
			{
				string text2 = GNLOGEDHNGF[i];
				if (num == 0)
				{
					text += text2;
				}
				else
				{
					text = text + " Path: " + text2;
				}
				num += 0;
			}
			this.thisText.text = text;
			this.GOIOPCBBPJA();
		}

		// Token: 0x0600A27D RID: 41597 RVA: 0x003CA128 File Offset: 0x003C8328
		public void CEAKHNOBCAD(string EAFAMAMDNEG, bool IMLPKOPBOMM)
		{
			this.OMMENHNGNEB();
			this.thisText.text = EAFAMAMDNEG;
			this.HLDALGBPALG();
		}

		// Token: 0x0600A27E RID: 41598 RVA: 0x003CA142 File Offset: 0x003C8342
		private void FOMNCPKKCFN()
		{
			this.MKLIAKAJFPO();
			if (this.MPFNCILGNLK && this.OKDFHMNJLOO == RenderMode.ScreenSpaceCamera)
			{
				this.OnScreenSpaceCamera();
			}
		}

		// Token: 0x0600A27F RID: 41599 RVA: 0x003CA168 File Offset: 0x003C8368
		public void MFBJDLHCDOD()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 764f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 136f);
		}

		// Token: 0x0600A280 RID: 41600 RVA: 0x003CA1FC File Offset: 0x003C83FC
		private void PFFEMADMOKE()
		{
			this.GHOKOLMJONF = true;
			this.DFMPILPKNEG = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(0f, 0f, 0f));
			this.MKGAFHHNMII = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(1f, 1f, 0f));
			this.DMKHNNKODCF = (float)Screen.height / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.y;
			this.GFLLFHDMEAM = (float)Screen.width / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.x;
		}

		// Token: 0x0600A281 RID: 41601 RVA: 0x003CA2AE File Offset: 0x003C84AE
		public void IOEHGEKMEPF(string EAFAMAMDNEG, bool IMLPKOPBOMM)
		{
			this.LPEOABKMECM();
			this.thisText.text = EAFAMAMDNEG;
			this.HLDALGBPALG();
		}

		// Token: 0x0600A282 RID: 41602 RVA: 0x003CA2C8 File Offset: 0x003C84C8
		private void MDCFIHDPLIG()
		{
			this.KIBAFONHNPB();
			if (this.MPFNCILGNLK && this.OKDFHMNJLOO == RenderMode.ScreenSpaceOverlay)
			{
				this.OnScreenSpaceCamera();
			}
		}

		// Token: 0x0600A283 RID: 41603 RVA: 0x003CA2ED File Offset: 0x003C84ED
		public void JIBGIAHNFPK(string EAFAMAMDNEG, bool IMLPKOPBOMM)
		{
			this.FOLNCLNIDDB();
			this.thisText.text = EAFAMAMDNEG;
			this.AAFFNEPJDBG();
		}

		// Token: 0x0600A284 RID: 41604 RVA: 0x003CA308 File Offset: 0x003C8508
		private void BPBOIIAABBI()
		{
			if (this.GHOKOLMJONF)
			{
				this.GHOKOLMJONF = true;
				this.bgImage.sizeDelta = new Vector2(this.hlG.preferredWidth + (float)this.horizontalPadding, this.hlG.preferredHeight + (float)this.verticalPadding);
				this.HMPNJBOIOAH = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				this.OCFIFJDJNMI = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM * this.bgImage.pivot.x;
				this.LNFALDIJMLM = this.bgImage.sizeDelta.y * this.DMKHNNKODCF;
				this.GAFKGLFACMF = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM;
				this.MJMKOOPDBED();
			}
		}

		// Token: 0x0600A285 RID: 41605 RVA: 0x003CA410 File Offset: 0x003C8610
		public void BNJAFIPKBNC(string[] GNLOGEDHNGF)
		{
			this.CBNAKNCIMNI();
			string text = string.Empty;
			int num = 1;
			for (int i = 1; i < GNLOGEDHNGF.Length; i++)
			{
				string text2 = GNLOGEDHNGF[i];
				if (num == 0)
				{
					text += text2;
				}
				else
				{
					text = text + "Joystick1Button8" + text2;
				}
				num++;
			}
			this.thisText.text = text;
			this.LHINCEHBMJA();
		}

		// Token: 0x0600A286 RID: 41606 RVA: 0x003CA480 File Offset: 0x003C8680
		public void MABHGPLCBJE()
		{
			Vector3 position = this.HLGFJLGJNCK.ScreenToViewportPoint(Input.mousePosition);
			float num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num > this.MKGAFHHNMII.x)
			{
				float num2 = this.MKGAFHHNMII.x - num;
				float num3;
				if ((double)num2 > (double)this.OCFIFJDJNMI * 1763.0)
				{
					num3 = num2;
				}
				else
				{
					num3 = this.OCFIFJDJNMI - this.GAFKGLFACMF * 1139f;
				}
				Vector3 position2 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + num3, 377f, 561f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position2).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num < this.DFMPILPKNEG.x)
			{
				float num4 = this.DFMPILPKNEG.x - num;
				float num3;
				if ((double)num4 < (double)this.OCFIFJDJNMI * 521.0 - (double)this.GAFKGLFACMF)
				{
					num3 = -num4;
				}
				else
				{
					num3 = this.GAFKGLFACMF * 1593f;
				}
				Vector3 position3 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - num3, 598f, 185f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position3).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - (this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y - this.LNFALDIJMLM);
			if (num > this.MKGAFHHNMII.y)
			{
				float num5 = this.MKGAFHHNMII.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num5 > (double)this.HMPNJBOIOAH * 96.0)
				{
					num6 = num5;
				}
				else
				{
					num6 = this.HMPNJBOIOAH - this.LNFALDIJMLM * 437f;
				}
				Vector3 position4 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 1875f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position4).y;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
			if (num < this.DFMPILPKNEG.y)
			{
				float num7 = this.DFMPILPKNEG.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num7 < (double)this.HMPNJBOIOAH * 1735.0 - (double)this.LNFALDIJMLM)
				{
					num6 = num7;
				}
				else
				{
					num6 = this.LNFALDIJMLM * 334f;
				}
				Vector3 position5 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 1171f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position5).y;
			}
			base.transform.parent.transform.position = new Vector3(this.HLGFJLGJNCK.ViewportToWorldPoint(position).x, this.HLGFJLGJNCK.ViewportToWorldPoint(position).y, 1327f);
			base.transform.parent.gameObject.SetActive(false);
			this.MPFNCILGNLK = true;
		}

		// Token: 0x0600A287 RID: 41607 RVA: 0x003CA8DC File Offset: 0x003C8ADC
		public void PBAEOIBMNGH()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 878f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 1487f);
		}

		// Token: 0x0600A288 RID: 41608 RVA: 0x003CA96D File Offset: 0x003C8B6D
		public void MFDOHEHBJIK(string EAFAMAMDNEG)
		{
			this.BCECEKDJHLJ();
			this.thisText.text = EAFAMAMDNEG;
			this.BFAOCEONBPE();
		}

		// Token: 0x0600A289 RID: 41609 RVA: 0x003CA988 File Offset: 0x003C8B88
		private void FNCDAPDOBBI()
		{
			this.HLGFJLGJNCK = GameObject.Find("In Network lobby").GetComponent<Camera>();
			this.OKDFHMNJLOO = base.transform.parent.parent.GetComponent<Canvas>().renderMode;
			this.DFEFFGOJFLL = this.bgImage.GetComponent<Image>();
			this.MPFNCILGNLK = false;
			this.HLHBNBLCCGG();
			base.transform.parent.gameObject.SetActive(true);
		}

		// Token: 0x0600A28A RID: 41610 RVA: 0x003CA9FE File Offset: 0x003C8BFE
		private void ABFNJCEBIKA()
		{
			this.BBHEEEGNJFH();
			if (this.MPFNCILGNLK && this.OKDFHMNJLOO == RenderMode.ScreenSpaceOverlay)
			{
				this.CPFJFIBMEOK();
			}
		}

		// Token: 0x0600A28B RID: 41611 RVA: 0x003CAA23 File Offset: 0x003C8C23
		public void HBNJHPPPPFE()
		{
			if (this.OKDFHMNJLOO == RenderMode.ScreenSpaceCamera && this != null)
			{
				base.transform.parent.gameObject.SetActive(true);
				this.MPFNCILGNLK = true;
				this.CKOMLABFNIM();
			}
		}

		// Token: 0x0600A28C RID: 41612 RVA: 0x003CAA60 File Offset: 0x003C8C60
		private void FCFPNLHOCPC()
		{
			if (this.GHOKOLMJONF)
			{
				this.GHOKOLMJONF = true;
				this.bgImage.sizeDelta = new Vector2(this.hlG.preferredWidth + (float)this.horizontalPadding, this.hlG.preferredHeight + (float)this.verticalPadding);
				this.HMPNJBOIOAH = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				this.OCFIFJDJNMI = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM * this.bgImage.pivot.x;
				this.LNFALDIJMLM = this.bgImage.sizeDelta.y * this.DMKHNNKODCF;
				this.GAFKGLFACMF = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM;
				this.OACHHIOHBMI();
			}
		}

		// Token: 0x0600A28D RID: 41613 RVA: 0x003CAB68 File Offset: 0x003C8D68
		public void AMKEDNOPAAN()
		{
			Vector3 position = this.HLGFJLGJNCK.ScreenToViewportPoint(Input.mousePosition);
			float num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num > this.MKGAFHHNMII.x)
			{
				float num2 = this.MKGAFHHNMII.x - num;
				float num3;
				if ((double)num2 > (double)this.OCFIFJDJNMI * 1507.0)
				{
					num3 = num2;
				}
				else
				{
					num3 = this.OCFIFJDJNMI - this.GAFKGLFACMF * 751f;
				}
				Vector3 position2 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + num3, 175f, 1562f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position2).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num < this.DFMPILPKNEG.x)
			{
				float num4 = this.DFMPILPKNEG.x - num;
				float num3;
				if ((double)num4 < (double)this.OCFIFJDJNMI * 650.0 - (double)this.GAFKGLFACMF)
				{
					num3 = -num4;
				}
				else
				{
					num3 = this.GAFKGLFACMF * 455f;
				}
				Vector3 position3 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - num3, 125f, 1825f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position3).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - (this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y - this.LNFALDIJMLM);
			if (num > this.MKGAFHHNMII.y)
			{
				float num5 = this.MKGAFHHNMII.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num5 > (double)this.HMPNJBOIOAH * 825.0)
				{
					num6 = num5;
				}
				else
				{
					num6 = this.HMPNJBOIOAH - this.LNFALDIJMLM * 284f;
				}
				Vector3 position4 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 833f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position4).y;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
			if (num < this.DFMPILPKNEG.y)
			{
				float num7 = this.DFMPILPKNEG.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num7 < (double)this.HMPNJBOIOAH * 1723.0 - (double)this.LNFALDIJMLM)
				{
					num6 = num7;
				}
				else
				{
					num6 = this.LNFALDIJMLM * 928f;
				}
				Vector3 position5 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 737f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position5).y;
			}
			base.transform.parent.transform.position = new Vector3(this.HLGFJLGJNCK.ViewportToWorldPoint(position).x, this.HLGFJLGJNCK.ViewportToWorldPoint(position).y, 1432f);
			base.transform.parent.gameObject.SetActive(true);
			this.MPFNCILGNLK = false;
		}

		// Token: 0x0600A28E RID: 41614 RVA: 0x003CAFC4 File Offset: 0x003C91C4
		public void FDJOONGODLJ()
		{
			Vector3 position = this.HLGFJLGJNCK.ScreenToViewportPoint(Input.mousePosition);
			float num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num > this.MKGAFHHNMII.x)
			{
				float num2 = this.MKGAFHHNMII.x - num;
				float num3;
				if ((double)num2 > (double)this.OCFIFJDJNMI * 1141.0)
				{
					num3 = num2;
				}
				else
				{
					num3 = this.OCFIFJDJNMI - this.GAFKGLFACMF * 22f;
				}
				Vector3 position2 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + num3, 158f, 783f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position2).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num < this.DFMPILPKNEG.x)
			{
				float num4 = this.DFMPILPKNEG.x - num;
				float num3;
				if ((double)num4 < (double)this.OCFIFJDJNMI * 1724.0 - (double)this.GAFKGLFACMF)
				{
					num3 = -num4;
				}
				else
				{
					num3 = this.GAFKGLFACMF * 238f;
				}
				Vector3 position3 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - num3, 1721f, 1510f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position3).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - (this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y - this.LNFALDIJMLM);
			if (num > this.MKGAFHHNMII.y)
			{
				float num5 = this.MKGAFHHNMII.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num5 > (double)this.HMPNJBOIOAH * 1653.0)
				{
					num6 = num5;
				}
				else
				{
					num6 = this.HMPNJBOIOAH - this.LNFALDIJMLM * 444f;
				}
				Vector3 position4 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 1166f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position4).y;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
			if (num < this.DFMPILPKNEG.y)
			{
				float num7 = this.DFMPILPKNEG.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num7 < (double)this.HMPNJBOIOAH * 1786.0 - (double)this.LNFALDIJMLM)
				{
					num6 = num7;
				}
				else
				{
					num6 = this.LNFALDIJMLM * 1107f;
				}
				Vector3 position5 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 214f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position5).y;
			}
			base.transform.parent.transform.position = new Vector3(this.HLGFJLGJNCK.ViewportToWorldPoint(position).x, this.HLGFJLGJNCK.ViewportToWorldPoint(position).y, 1861f);
			base.transform.parent.gameObject.SetActive(true);
			this.MPFNCILGNLK = true;
		}

		// Token: 0x0600A28F RID: 41615 RVA: 0x003CB420 File Offset: 0x003C9620
		private void HLOHOPBFFKL()
		{
			this.GHOKOLMJONF = true;
			this.DFMPILPKNEG = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(1171f, 1743f, 340f));
			this.MKGAFHHNMII = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(641f, 1445f, 1572f));
			this.DMKHNNKODCF = (float)Screen.height / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.y;
			this.GFLLFHDMEAM = (float)Screen.width / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.x;
		}

		// Token: 0x0600A290 RID: 41616 RVA: 0x003CB4D4 File Offset: 0x003C96D4
		private void Start()
		{
			this.HLGFJLGJNCK = GameObject.Find("GUICamera").GetComponent<Camera>();
			this.OKDFHMNJLOO = base.transform.parent.parent.GetComponent<Canvas>().renderMode;
			this.DFEFFGOJFLL = this.bgImage.GetComponent<Image>();
			this.MPFNCILGNLK = false;
			this.HideTooltipVisibility();
			base.transform.parent.gameObject.SetActive(false);
		}

		// Token: 0x0600A291 RID: 41617 RVA: 0x003CB54A File Offset: 0x003C974A
		public void LKEFLOBLJKA(string EAFAMAMDNEG, bool IMLPKOPBOMM)
		{
			this.KJMNBPJIJAO();
			this.thisText.text = EAFAMAMDNEG;
			this.BFAOCEONBPE();
		}

		// Token: 0x0600A292 RID: 41618 RVA: 0x003CB564 File Offset: 0x003C9764
		public void GANPHPEKNPC()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 136f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 613f);
		}

		// Token: 0x0600A293 RID: 41619 RVA: 0x003CB5F8 File Offset: 0x003C97F8
		public void EENGANDDBIN()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 1177f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 308f);
		}

		// Token: 0x0600A294 RID: 41620 RVA: 0x003CB68C File Offset: 0x003C988C
		private void HAPNFOLDPHH()
		{
			this.GHOKOLMJONF = false;
			this.DFMPILPKNEG = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(852f, 917f, 960f));
			this.MKGAFHHNMII = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(730f, 1821f, 970f));
			this.DMKHNNKODCF = (float)Screen.height / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.y;
			this.GFLLFHDMEAM = (float)Screen.width / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.x;
		}

		// Token: 0x0600A295 RID: 41621 RVA: 0x003CB740 File Offset: 0x003C9940
		private void JIBNILMLCKE()
		{
			this.GHOKOLMJONF = false;
			this.DFMPILPKNEG = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(640f, 1966f, 70f));
			this.MKGAFHHNMII = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(364f, 853f, 1099f));
			this.DMKHNNKODCF = (float)Screen.height / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.y;
			this.GFLLFHDMEAM = (float)Screen.width / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.x;
		}

		// Token: 0x0600A296 RID: 41622 RVA: 0x003CB7F4 File Offset: 0x003C99F4
		private void MIABPDLBDBG()
		{
			if (this.GHOKOLMJONF)
			{
				this.GHOKOLMJONF = true;
				this.bgImage.sizeDelta = new Vector2(this.hlG.preferredWidth + (float)this.horizontalPadding, this.hlG.preferredHeight + (float)this.verticalPadding);
				this.HMPNJBOIOAH = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				this.OCFIFJDJNMI = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM * this.bgImage.pivot.x;
				this.LNFALDIJMLM = this.bgImage.sizeDelta.y * this.DMKHNNKODCF;
				this.GAFKGLFACMF = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM;
				this.MJMKOOPDBED();
			}
		}

		// Token: 0x0600A297 RID: 41623 RVA: 0x003CB8FC File Offset: 0x003C9AFC
		private void KJMNBPJIJAO()
		{
			this.GHOKOLMJONF = true;
			this.DFMPILPKNEG = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(165f, 1910f, 913f));
			this.MKGAFHHNMII = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(664f, 1236f, 1370f));
			this.DMKHNNKODCF = (float)Screen.height / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.y;
			this.GFLLFHDMEAM = (float)Screen.width / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.x;
		}

		// Token: 0x0600A298 RID: 41624 RVA: 0x003CB9B0 File Offset: 0x003C9BB0
		public void CIIPBIGLHAE(string[] GNLOGEDHNGF)
		{
			this.EGBCKALNKLM();
			string text = string.Empty;
			int num = 0;
			for (int i = 1; i < GNLOGEDHNGF.Length; i += 0)
			{
				string text2 = GNLOGEDHNGF[i];
				if (num == 0)
				{
					text += text2;
				}
				else
				{
					text = text + "masterVolume" + text2;
				}
				num += 0;
			}
			this.thisText.text = text;
			this.HLDALGBPALG();
		}

		// Token: 0x0600A299 RID: 41625 RVA: 0x003CBA20 File Offset: 0x003C9C20
		public void HGOHIOLGGLM(string EAFAMAMDNEG)
		{
			this.IOGALJLDAJD();
			this.thisText.text = EAFAMAMDNEG;
			this.MABHGPLCBJE();
		}

		// Token: 0x0600A29A RID: 41626 RVA: 0x003CBA3C File Offset: 0x003C9C3C
		public void ADHFLHDMOFM()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 1716f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 996f);
		}

		// Token: 0x0600A29B RID: 41627 RVA: 0x003CBACD File Offset: 0x003C9CCD
		public void IGEGIDEMNFG()
		{
			if (this.OKDFHMNJLOO == RenderMode.ScreenSpaceOverlay && this != null)
			{
				base.transform.parent.gameObject.SetActive(false);
				this.MPFNCILGNLK = false;
				this.MHDAKFCKFMB();
			}
		}

		// Token: 0x0600A29C RID: 41628 RVA: 0x003CBB0C File Offset: 0x003C9D0C
		public void KPKFBOGGMIB()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 631f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 974f);
		}

		// Token: 0x0600A29D RID: 41629 RVA: 0x003CBBA0 File Offset: 0x003C9DA0
		public void PIIEJPKJGAN(string[] GNLOGEDHNGF)
		{
			this.BCECEKDJHLJ();
			string text = string.Empty;
			int num = 0;
			for (int i = 1; i < GNLOGEDHNGF.Length; i += 0)
			{
				string text2 = GNLOGEDHNGF[i];
				if (num == 0)
				{
					text += text2;
				}
				else
				{
					text = text + "_Green_G" + text2;
				}
				num += 0;
			}
			this.thisText.text = text;
			this.GOIOPCBBPJA();
		}

		// Token: 0x0600A29E RID: 41630 RVA: 0x003CBC10 File Offset: 0x003C9E10
		private void BMODOIJGIOO()
		{
			this.BBHEEEGNJFH();
			if (this.MPFNCILGNLK && this.OKDFHMNJLOO == RenderMode.ScreenSpaceOverlay)
			{
				this.CKJIKNHJALL();
			}
		}

		// Token: 0x0600A29F RID: 41631 RVA: 0x003CBC35 File Offset: 0x003C9E35
		public void OENCLMEDIHL(string EAFAMAMDNEG, bool IMLPKOPBOMM)
		{
			this.HLOHOPBFFKL();
			this.thisText.text = EAFAMAMDNEG;
			this.HLDALGBPALG();
		}

		// Token: 0x0600A2A0 RID: 41632 RVA: 0x003CBC4F File Offset: 0x003C9E4F
		public void FBDIOFPMGGJ(string EAFAMAMDNEG, bool IMLPKOPBOMM)
		{
			this.HAPNFOLDPHH();
			this.thisText.text = EAFAMAMDNEG;
			this.CKJIKNHJALL();
		}

		// Token: 0x0600A2A1 RID: 41633 RVA: 0x003CBC6C File Offset: 0x003C9E6C
		public void HBDHAIMMAEO()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 1701f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 233f);
		}

		// Token: 0x0600A2A2 RID: 41634 RVA: 0x003CBD00 File Offset: 0x003C9F00
		private void KLILJHJNICK()
		{
			this.HLGFJLGJNCK = GameObject.Find("GenerationMenu").GetComponent<Camera>();
			this.OKDFHMNJLOO = base.transform.parent.parent.GetComponent<Canvas>().renderMode;
			this.DFEFFGOJFLL = this.bgImage.GetComponent<Image>();
			this.MPFNCILGNLK = false;
			this.HBDHAIMMAEO();
			base.transform.parent.gameObject.SetActive(true);
		}

		// Token: 0x0600A2A3 RID: 41635 RVA: 0x003CBD78 File Offset: 0x003C9F78
		private void ECLIOEGJLEF()
		{
			if (this.GHOKOLMJONF)
			{
				this.GHOKOLMJONF = false;
				this.bgImage.sizeDelta = new Vector2(this.hlG.preferredWidth + (float)this.horizontalPadding, this.hlG.preferredHeight + (float)this.verticalPadding);
				this.HMPNJBOIOAH = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				this.OCFIFJDJNMI = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM * this.bgImage.pivot.x;
				this.LNFALDIJMLM = this.bgImage.sizeDelta.y * this.DMKHNNKODCF;
				this.GAFKGLFACMF = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM;
				this.ActivateTooltipVisibility();
			}
		}

		// Token: 0x0600A2A4 RID: 41636 RVA: 0x003CBE80 File Offset: 0x003CA080
		public void PJOBIPCBCFJ()
		{
			Vector3 position = this.HLGFJLGJNCK.ScreenToViewportPoint(Input.mousePosition);
			float num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num > this.MKGAFHHNMII.x)
			{
				float num2 = this.MKGAFHHNMII.x - num;
				float num3;
				if ((double)num2 > (double)this.OCFIFJDJNMI * 184.0)
				{
					num3 = num2;
				}
				else
				{
					num3 = this.OCFIFJDJNMI - this.GAFKGLFACMF * 198f;
				}
				Vector3 position2 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + num3, 136f, 424f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position2).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num < this.DFMPILPKNEG.x)
			{
				float num4 = this.DFMPILPKNEG.x - num;
				float num3;
				if ((double)num4 < (double)this.OCFIFJDJNMI * 487.0 - (double)this.GAFKGLFACMF)
				{
					num3 = -num4;
				}
				else
				{
					num3 = this.GAFKGLFACMF * 1138f;
				}
				Vector3 position3 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - num3, 94f, 1989f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position3).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - (this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y - this.LNFALDIJMLM);
			if (num > this.MKGAFHHNMII.y)
			{
				float num5 = this.MKGAFHHNMII.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num5 > (double)this.HMPNJBOIOAH * 1121.0)
				{
					num6 = num5;
				}
				else
				{
					num6 = this.HMPNJBOIOAH - this.LNFALDIJMLM * 1906f;
				}
				Vector3 position4 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 1419f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position4).y;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
			if (num < this.DFMPILPKNEG.y)
			{
				float num7 = this.DFMPILPKNEG.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num7 < (double)this.HMPNJBOIOAH * 1764.0 - (double)this.LNFALDIJMLM)
				{
					num6 = num7;
				}
				else
				{
					num6 = this.LNFALDIJMLM * 1408f;
				}
				Vector3 position5 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 1926f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position5).y;
			}
			base.transform.parent.transform.position = new Vector3(this.HLGFJLGJNCK.ViewportToWorldPoint(position).x, this.HLGFJLGJNCK.ViewportToWorldPoint(position).y, 364f);
			base.transform.parent.gameObject.SetActive(true);
			this.MPFNCILGNLK = true;
		}

		// Token: 0x0600A2A5 RID: 41637 RVA: 0x003CC2DC File Offset: 0x003CA4DC
		public void PEFEJCKBDMO(string[] GNLOGEDHNGF)
		{
			this.LPEOABKMECM();
			string text = string.Empty;
			int num = 1;
			for (int i = 1; i < GNLOGEDHNGF.Length; i++)
			{
				string text2 = GNLOGEDHNGF[i];
				if (num == 0)
				{
					text += text2;
				}
				else
				{
					text = text + "_Value" + text2;
				}
				num += 0;
			}
			this.thisText.text = text;
			this.LHINCEHBMJA();
		}

		// Token: 0x0600A2A6 RID: 41638 RVA: 0x003CC34C File Offset: 0x003CA54C
		private void BCJOAANPKGN()
		{
			this.GHOKOLMJONF = true;
			this.DFMPILPKNEG = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(1949f, 82f, 1246f));
			this.MKGAFHHNMII = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(1702f, 1668f, 979f));
			this.DMKHNNKODCF = (float)Screen.height / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.y;
			this.GFLLFHDMEAM = (float)Screen.width / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.x;
		}

		// Token: 0x0600A2A7 RID: 41639 RVA: 0x003CC3FE File Offset: 0x003CA5FE
		public void LDGMLNAOJBG(string EAFAMAMDNEG)
		{
			this.JIBNILMLCKE();
			this.thisText.text = EAFAMAMDNEG;
			this.HLDALGBPALG();
		}

		// Token: 0x0600A2A8 RID: 41640 RVA: 0x003CC418 File Offset: 0x003CA618
		public void FJICIDCGHGC(string EAFAMAMDNEG)
		{
			this.FOLNCLNIDDB();
			this.thisText.text = EAFAMAMDNEG;
			this.PJOBIPCBCFJ();
		}

		// Token: 0x0600A2A9 RID: 41641 RVA: 0x003CC434 File Offset: 0x003CA634
		public void ActivateTooltipVisibility()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 1f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 0.8f);
		}

		// Token: 0x0600A2AA RID: 41642 RVA: 0x003C9D5A File Offset: 0x003C7F5A
		public void SetTooltip(string EAFAMAMDNEG, bool IMLPKOPBOMM)
		{
			this.PFFEMADMOKE();
			this.thisText.text = EAFAMAMDNEG;
			this.OnScreenSpaceCamera();
		}

		// Token: 0x0600A2AB RID: 41643 RVA: 0x003CC4C8 File Offset: 0x003CA6C8
		public void KKCIFCDEMGN()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 678f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 597f);
		}

		// Token: 0x0600A2AC RID: 41644 RVA: 0x003CC559 File Offset: 0x003CA759
		public void FGCOEOCLEDN(string EAFAMAMDNEG, bool IMLPKOPBOMM)
		{
			this.KJMNBPJIJAO();
			this.thisText.text = EAFAMAMDNEG;
			this.FDJOONGODLJ();
		}

		// Token: 0x0600A2AD RID: 41645 RVA: 0x003CC574 File Offset: 0x003CA774
		public void FAIJEGEALAD()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 19f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 573f);
		}

		// Token: 0x0600A2AE RID: 41646 RVA: 0x003CC608 File Offset: 0x003CA808
		private void BPPOBJBHEBA()
		{
			if (this.GHOKOLMJONF)
			{
				this.GHOKOLMJONF = false;
				this.bgImage.sizeDelta = new Vector2(this.hlG.preferredWidth + (float)this.horizontalPadding, this.hlG.preferredHeight + (float)this.verticalPadding);
				this.HMPNJBOIOAH = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				this.OCFIFJDJNMI = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM * this.bgImage.pivot.x;
				this.LNFALDIJMLM = this.bgImage.sizeDelta.y * this.DMKHNNKODCF;
				this.GAFKGLFACMF = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM;
				this.ActivateTooltipVisibility();
			}
		}

		// Token: 0x0600A2AF RID: 41647 RVA: 0x003CC710 File Offset: 0x003CA910
		private void CBNAKNCIMNI()
		{
			this.GHOKOLMJONF = false;
			this.DFMPILPKNEG = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(1364f, 167f, 151f));
			this.MKGAFHHNMII = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(616f, 1379f, 1490f));
			this.DMKHNNKODCF = (float)Screen.height / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.y;
			this.GFLLFHDMEAM = (float)Screen.width / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.x;
		}

		// Token: 0x0600A2B0 RID: 41648 RVA: 0x003CC7C2 File Offset: 0x003CA9C2
		private void Update()
		{
			this.ECLIOEGJLEF();
			if (this.MPFNCILGNLK && this.OKDFHMNJLOO == RenderMode.ScreenSpaceCamera)
			{
				this.OnScreenSpaceCamera();
			}
		}

		// Token: 0x0600A2B1 RID: 41649 RVA: 0x003CC7E7 File Offset: 0x003CA9E7
		public void AODGHOIEKJE(string EAFAMAMDNEG, bool IMLPKOPBOMM)
		{
			this.HAPNFOLDPHH();
			this.thisText.text = EAFAMAMDNEG;
			this.PJOBIPCBCFJ();
		}

		// Token: 0x0600A2B2 RID: 41650 RVA: 0x003CC804 File Offset: 0x003CAA04
		public void GPLKFCLNLAG(string[] GNLOGEDHNGF)
		{
			this.EGBCKALNKLM();
			string text = string.Empty;
			int num = 1;
			for (int i = 0; i < GNLOGEDHNGF.Length; i += 0)
			{
				string text2 = GNLOGEDHNGF[i];
				if (num == 0)
				{
					text += text2;
				}
				else
				{
					text = text + "_ChannelMixerBlue" + text2;
				}
				num++;
			}
			this.thisText.text = text;
			this.MABHGPLCBJE();
		}

		// Token: 0x0600A2B3 RID: 41651 RVA: 0x003CC874 File Offset: 0x003CAA74
		public void HPDAGLMFNKM()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 375f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 1407f);
		}

		// Token: 0x0600A2B4 RID: 41652 RVA: 0x003CC905 File Offset: 0x003CAB05
		public void HideTooltip()
		{
			if (this.OKDFHMNJLOO == RenderMode.ScreenSpaceCamera && this != null)
			{
				base.transform.parent.gameObject.SetActive(false);
				this.MPFNCILGNLK = false;
				this.HideTooltipVisibility();
			}
		}

		// Token: 0x0600A2B5 RID: 41653 RVA: 0x003CC942 File Offset: 0x003CAB42
		private void POIMNOBDBBN()
		{
			this.NMIPPCPINBN();
			if (this.MPFNCILGNLK && this.OKDFHMNJLOO == RenderMode.ScreenSpaceOverlay)
			{
				this.OnScreenSpaceCamera();
			}
		}

		// Token: 0x0600A2B6 RID: 41654 RVA: 0x003CC968 File Offset: 0x003CAB68
		public void BJIKHAIPANG(string[] GNLOGEDHNGF)
		{
			this.HAPNFOLDPHH();
			string text = string.Empty;
			int num = 1;
			foreach (string text2 in GNLOGEDHNGF)
			{
				if (num == 0)
				{
					text += text2;
				}
				else
				{
					text = text + "_Value4" + text2;
				}
				num++;
			}
			this.thisText.text = text;
			this.PJOBIPCBCFJ();
		}

		// Token: 0x0600A2B7 RID: 41655 RVA: 0x003CC9D8 File Offset: 0x003CABD8
		private void GDNHJKCLHHJ()
		{
			if (this.GHOKOLMJONF)
			{
				this.GHOKOLMJONF = false;
				this.bgImage.sizeDelta = new Vector2(this.hlG.preferredWidth + (float)this.horizontalPadding, this.hlG.preferredHeight + (float)this.verticalPadding);
				this.HMPNJBOIOAH = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				this.OCFIFJDJNMI = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM * this.bgImage.pivot.x;
				this.LNFALDIJMLM = this.bgImage.sizeDelta.y * this.DMKHNNKODCF;
				this.GAFKGLFACMF = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM;
				this.OACHHIOHBMI();
			}
		}

		// Token: 0x0600A2B8 RID: 41656 RVA: 0x003CCAE0 File Offset: 0x003CACE0
		public void GDKDIEKHEAC(string[] GNLOGEDHNGF)
		{
			this.IOGALJLDAJD();
			string text = string.Empty;
			int num = 0;
			for (int i = 0; i < GNLOGEDHNGF.Length; i += 0)
			{
				string text2 = GNLOGEDHNGF[i];
				if (num == 0)
				{
					text += text2;
				}
				else
				{
					text = text + "/" + text2;
				}
				num += 0;
			}
			this.thisText.text = text;
			this.FDJOONGODLJ();
		}

		// Token: 0x0600A2B9 RID: 41657 RVA: 0x003CCB50 File Offset: 0x003CAD50
		private void BIMFHGHHOOC()
		{
			this.GHOKOLMJONF = true;
			this.DFMPILPKNEG = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(766f, 758f, 901f));
			this.MKGAFHHNMII = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(96f, 992f, 1538f));
			this.DMKHNNKODCF = (float)Screen.height / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.y;
			this.GFLLFHDMEAM = (float)Screen.width / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.x;
		}

		// Token: 0x0600A2BA RID: 41658 RVA: 0x003CCC04 File Offset: 0x003CAE04
		public void ODMENBBOFIK(string[] GNLOGEDHNGF)
		{
			this.HLOHOPBFFKL();
			string text = string.Empty;
			int num = 1;
			for (int i = 0; i < GNLOGEDHNGF.Length; i += 0)
			{
				string text2 = GNLOGEDHNGF[i];
				if (num == 0)
				{
					text += text2;
				}
				else
				{
					text = text + "_ScreenResolution" + text2;
				}
				num += 0;
			}
			this.thisText.text = text;
			this.GOIOPCBBPJA();
		}

		// Token: 0x0600A2BB RID: 41659 RVA: 0x003CCC74 File Offset: 0x003CAE74
		public void OEEOEKBFADN()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 1908f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 356f);
		}

		// Token: 0x0600A2BC RID: 41660 RVA: 0x003CCD08 File Offset: 0x003CAF08
		private void NIIBKLNMHBL()
		{
			if (this.GHOKOLMJONF)
			{
				this.GHOKOLMJONF = false;
				this.bgImage.sizeDelta = new Vector2(this.hlG.preferredWidth + (float)this.horizontalPadding, this.hlG.preferredHeight + (float)this.verticalPadding);
				this.HMPNJBOIOAH = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				this.OCFIFJDJNMI = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM * this.bgImage.pivot.x;
				this.LNFALDIJMLM = this.bgImage.sizeDelta.y * this.DMKHNNKODCF;
				this.GAFKGLFACMF = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM;
				this.MFBJDLHCDOD();
			}
		}

		// Token: 0x0600A2BD RID: 41661 RVA: 0x003CCE10 File Offset: 0x003CB010
		public void KAMCFKJKFGA(string[] GNLOGEDHNGF)
		{
			this.PFFEMADMOKE();
			string text = string.Empty;
			int num = 0;
			for (int i = 1; i < GNLOGEDHNGF.Length; i += 0)
			{
				string text2 = GNLOGEDHNGF[i];
				if (num == 0)
				{
					text += text2;
				}
				else
				{
					text = text + "Please specify either t or f." + text2;
				}
				num++;
			}
			this.thisText.text = text;
			this.CPFJFIBMEOK();
		}

		// Token: 0x0600A2BE RID: 41662 RVA: 0x003CCE80 File Offset: 0x003CB080
		private void IMCKJCHKMKB()
		{
			this.HLGFJLGJNCK = GameObject.Find("CameraFilterPack/Distortion_Noise").GetComponent<Camera>();
			this.OKDFHMNJLOO = base.transform.parent.parent.GetComponent<Canvas>().renderMode;
			this.DFEFFGOJFLL = this.bgImage.GetComponent<Image>();
			this.MPFNCILGNLK = true;
			this.FIMJEONECKI();
			base.transform.parent.gameObject.SetActive(true);
		}

		// Token: 0x0600A2BF RID: 41663 RVA: 0x003CCEF8 File Offset: 0x003CB0F8
		public void HideTooltipVisibility()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 0f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 0f);
		}

		// Token: 0x0600A2C0 RID: 41664 RVA: 0x003CCF8C File Offset: 0x003CB18C
		private void JILOMOBDPIA()
		{
			this.HLGFJLGJNCK = GameObject.Find("_Value4").GetComponent<Camera>();
			this.OKDFHMNJLOO = base.transform.parent.parent.GetComponent<Canvas>().renderMode;
			this.DFEFFGOJFLL = this.bgImage.GetComponent<Image>();
			this.MPFNCILGNLK = true;
			this.HLHBNBLCCGG();
			base.transform.parent.gameObject.SetActive(true);
		}

		// Token: 0x0600A2C1 RID: 41665 RVA: 0x003CD002 File Offset: 0x003CB202
		public void IGCLCJPPJCL(string EAFAMAMDNEG)
		{
			this.CBNAKNCIMNI();
			this.thisText.text = EAFAMAMDNEG;
			this.CPFJFIBMEOK();
		}

		// Token: 0x0600A2C2 RID: 41666 RVA: 0x003CD01C File Offset: 0x003CB21C
		private void GNJDKAECPKA()
		{
			this.HLGFJLGJNCK = GameObject.Find(" GO:").GetComponent<Camera>();
			this.OKDFHMNJLOO = base.transform.parent.parent.GetComponent<Canvas>().renderMode;
			this.DFEFFGOJFLL = this.bgImage.GetComponent<Image>();
			this.MPFNCILGNLK = false;
			this.HideTooltipVisibility();
			base.transform.parent.gameObject.SetActive(true);
		}

		// Token: 0x0600A2C3 RID: 41667 RVA: 0x003CD094 File Offset: 0x003CB294
		public void NHKOOGBPKPD()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 580f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 1884f);
		}

		// Token: 0x0600A2C4 RID: 41668 RVA: 0x003CD125 File Offset: 0x003CB325
		private void PFNFPINPCMH()
		{
			this.OOBLNBNNLCN();
			if (this.MPFNCILGNLK && this.OKDFHMNJLOO == RenderMode.ScreenSpaceCamera)
			{
				this.CPFJFIBMEOK();
			}
		}

		// Token: 0x0600A2C5 RID: 41669 RVA: 0x003CD14A File Offset: 0x003CB34A
		private void EGEGNHLODAA()
		{
			this.KLECMGDIHOG();
			if (this.MPFNCILGNLK && this.OKDFHMNJLOO == RenderMode.ScreenSpaceCamera)
			{
				this.LHINCEHBMJA();
			}
		}

		// Token: 0x0600A2C6 RID: 41670 RVA: 0x003CD16F File Offset: 0x003CB36F
		public void MELKOBCOJOL()
		{
			if (this.OKDFHMNJLOO == RenderMode.ScreenSpaceOverlay && this != null)
			{
				base.transform.parent.gameObject.SetActive(true);
				this.MPFNCILGNLK = true;
				this.FIMJEONECKI();
			}
		}

		// Token: 0x0600A2C7 RID: 41671 RVA: 0x003CD1AC File Offset: 0x003CB3AC
		private void LJIHHJOAJCN()
		{
			this.PEFHAAPKCAJ();
			if (this.MPFNCILGNLK && this.OKDFHMNJLOO == RenderMode.ScreenSpaceOverlay)
			{
				this.AMKEDNOPAAN();
			}
		}

		// Token: 0x0600A2C8 RID: 41672 RVA: 0x003CD1D1 File Offset: 0x003CB3D1
		public void KHJKEPCKPPP(string EAFAMAMDNEG, bool IMLPKOPBOMM)
		{
			this.HLOHOPBFFKL();
			this.thisText.text = EAFAMAMDNEG;
			this.OnScreenSpaceCamera();
		}

		// Token: 0x0600A2C9 RID: 41673 RVA: 0x003CD1EC File Offset: 0x003CB3EC
		public void OMMPDLFCBGH()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 866f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 1027f);
		}

		// Token: 0x0600A2CA RID: 41674 RVA: 0x003CD27D File Offset: 0x003CB47D
		public void BGAGIKLPPOH(string EAFAMAMDNEG, bool IMLPKOPBOMM)
		{
			this.HLOHOPBFFKL();
			this.thisText.text = EAFAMAMDNEG;
			this.FDJOONGODLJ();
		}

		// Token: 0x0600A2CB RID: 41675 RVA: 0x003CD298 File Offset: 0x003CB498
		public void EMOGKHOGEMK(string[] GNLOGEDHNGF)
		{
			this.INHJDEOFAFI();
			string text = string.Empty;
			int num = 0;
			for (int i = 1; i < GNLOGEDHNGF.Length; i++)
			{
				string text2 = GNLOGEDHNGF[i];
				if (num == 0)
				{
					text += text2;
				}
				else
				{
					text = text + "0,1,false" + text2;
				}
				num += 0;
			}
			this.thisText.text = text;
			this.PJOBIPCBCFJ();
		}

		// Token: 0x0600A2CC RID: 41676 RVA: 0x003CD308 File Offset: 0x003CB508
		public void PKEECCGECNK()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 1640f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 1997f);
		}

		// Token: 0x0600A2CD RID: 41677 RVA: 0x003CD39C File Offset: 0x003CB59C
		private void KIBAFONHNPB()
		{
			if (this.GHOKOLMJONF)
			{
				this.GHOKOLMJONF = true;
				this.bgImage.sizeDelta = new Vector2(this.hlG.preferredWidth + (float)this.horizontalPadding, this.hlG.preferredHeight + (float)this.verticalPadding);
				this.HMPNJBOIOAH = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				this.OCFIFJDJNMI = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM * this.bgImage.pivot.x;
				this.LNFALDIJMLM = this.bgImage.sizeDelta.y * this.DMKHNNKODCF;
				this.GAFKGLFACMF = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM;
				this.ADHFLHDMOFM();
			}
		}

		// Token: 0x0600A2CE RID: 41678 RVA: 0x003CD4A4 File Offset: 0x003CB6A4
		private void BBHEEEGNJFH()
		{
			if (this.GHOKOLMJONF)
			{
				this.GHOKOLMJONF = true;
				this.bgImage.sizeDelta = new Vector2(this.hlG.preferredWidth + (float)this.horizontalPadding, this.hlG.preferredHeight + (float)this.verticalPadding);
				this.HMPNJBOIOAH = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				this.OCFIFJDJNMI = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM * this.bgImage.pivot.x;
				this.LNFALDIJMLM = this.bgImage.sizeDelta.y * this.DMKHNNKODCF;
				this.GAFKGLFACMF = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM;
				this.PBAEOIBMNGH();
			}
		}

		// Token: 0x0600A2CF RID: 41679 RVA: 0x003CD5AC File Offset: 0x003CB7AC
		private void FOLNCLNIDDB()
		{
			this.GHOKOLMJONF = true;
			this.DFMPILPKNEG = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(539f, 306f, 1349f));
			this.MKGAFHHNMII = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(1735f, 1451f, 666f));
			this.DMKHNNKODCF = (float)Screen.height / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.y;
			this.GFLLFHDMEAM = (float)Screen.width / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.x;
		}

		// Token: 0x0600A2D0 RID: 41680 RVA: 0x003CD65E File Offset: 0x003CB85E
		private void BGDONBMDPGM()
		{
			this.FCFPNLHOCPC();
			if (this.MPFNCILGNLK && this.OKDFHMNJLOO == RenderMode.ScreenSpaceCamera)
			{
				this.OnScreenSpaceCamera();
			}
		}

		// Token: 0x0600A2D1 RID: 41681 RVA: 0x003CD684 File Offset: 0x003CB884
		private void ODMPMJPALID()
		{
			this.HLGFJLGJNCK = GameObject.Find("player.xp").GetComponent<Camera>();
			this.OKDFHMNJLOO = base.transform.parent.parent.GetComponent<Canvas>().renderMode;
			this.DFEFFGOJFLL = this.bgImage.GetComponent<Image>();
			this.MPFNCILGNLK = true;
			this.HBDHAIMMAEO();
			base.transform.parent.gameObject.SetActive(true);
		}

		// Token: 0x0600A2D2 RID: 41682 RVA: 0x003CD6FC File Offset: 0x003CB8FC
		public void AAFFNEPJDBG()
		{
			Vector3 position = this.HLGFJLGJNCK.ScreenToViewportPoint(Input.mousePosition);
			float num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num > this.MKGAFHHNMII.x)
			{
				float num2 = this.MKGAFHHNMII.x - num;
				float num3;
				if ((double)num2 > (double)this.OCFIFJDJNMI * 829.0)
				{
					num3 = num2;
				}
				else
				{
					num3 = this.OCFIFJDJNMI - this.GAFKGLFACMF * 1192f;
				}
				Vector3 position2 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + num3, 513f, 1054f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position2).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num < this.DFMPILPKNEG.x)
			{
				float num4 = this.DFMPILPKNEG.x - num;
				float num3;
				if ((double)num4 < (double)this.OCFIFJDJNMI * 1642.0 - (double)this.GAFKGLFACMF)
				{
					num3 = -num4;
				}
				else
				{
					num3 = this.GAFKGLFACMF * 1506f;
				}
				Vector3 position3 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - num3, 1260f, 829f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position3).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - (this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y - this.LNFALDIJMLM);
			if (num > this.MKGAFHHNMII.y)
			{
				float num5 = this.MKGAFHHNMII.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num5 > (double)this.HMPNJBOIOAH * 1675.0)
				{
					num6 = num5;
				}
				else
				{
					num6 = this.HMPNJBOIOAH - this.LNFALDIJMLM * 1405f;
				}
				Vector3 position4 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 74f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position4).y;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
			if (num < this.DFMPILPKNEG.y)
			{
				float num7 = this.DFMPILPKNEG.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num7 < (double)this.HMPNJBOIOAH * 1472.0 - (double)this.LNFALDIJMLM)
				{
					num6 = num7;
				}
				else
				{
					num6 = this.LNFALDIJMLM * 1427f;
				}
				Vector3 position5 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 1683f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position5).y;
			}
			base.transform.parent.transform.position = new Vector3(this.HLGFJLGJNCK.ViewportToWorldPoint(position).x, this.HLGFJLGJNCK.ViewportToWorldPoint(position).y, 1292f);
			base.transform.parent.gameObject.SetActive(true);
			this.MPFNCILGNLK = false;
		}

		// Token: 0x0600A2D3 RID: 41683 RVA: 0x003CDB58 File Offset: 0x003CBD58
		private void LPEOABKMECM()
		{
			this.GHOKOLMJONF = true;
			this.DFMPILPKNEG = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(499f, 1214f, 1075f));
			this.MKGAFHHNMII = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(1439f, 193f, 1843f));
			this.DMKHNNKODCF = (float)Screen.height / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.y;
			this.GFLLFHDMEAM = (float)Screen.width / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.x;
		}

		// Token: 0x0600A2D4 RID: 41684 RVA: 0x003CDC0C File Offset: 0x003CBE0C
		private void HPFOFGJPNCI()
		{
			this.HLGFJLGJNCK = GameObject.Find("_Fade").GetComponent<Camera>();
			this.OKDFHMNJLOO = base.transform.parent.parent.GetComponent<Canvas>().renderMode;
			this.DFEFFGOJFLL = this.bgImage.GetComponent<Image>();
			this.MPFNCILGNLK = true;
			this.IANJIBJCLMN();
			base.transform.parent.gameObject.SetActive(true);
		}

		// Token: 0x0600A2D5 RID: 41685 RVA: 0x003CDC82 File Offset: 0x003CBE82
		public void PCGBLNHMEPI(string EAFAMAMDNEG)
		{
			this.INHJDEOFAFI();
			this.thisText.text = EAFAMAMDNEG;
			this.OnScreenSpaceCamera();
		}

		// Token: 0x0600A2D6 RID: 41686 RVA: 0x003CDC9C File Offset: 0x003CBE9C
		public void HLHBNBLCCGG()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 1732f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 1242f);
		}

		// Token: 0x0600A2D7 RID: 41687 RVA: 0x003CDD30 File Offset: 0x003CBF30
		public void MHDAKFCKFMB()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 1418f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 1440f);
		}

		// Token: 0x0600A2D8 RID: 41688 RVA: 0x003CDDC1 File Offset: 0x003CBFC1
		private void EPJJDKJEDMM()
		{
			this.ECLIOEGJLEF();
			if (this.MPFNCILGNLK && this.OKDFHMNJLOO == RenderMode.ScreenSpaceOverlay)
			{
				this.CKJIKNHJALL();
			}
		}

		// Token: 0x0600A2D9 RID: 41689 RVA: 0x003CDDE8 File Offset: 0x003CBFE8
		public void FHBGAJFEMCO()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 9f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 1421f);
		}

		// Token: 0x0600A2DA RID: 41690 RVA: 0x003CDE7C File Offset: 0x003CC07C
		private void DNNFHBOOPIN()
		{
			this.HLGFJLGJNCK = GameObject.Find("_Value").GetComponent<Camera>();
			this.OKDFHMNJLOO = base.transform.parent.parent.GetComponent<Canvas>().renderMode;
			this.DFEFFGOJFLL = this.bgImage.GetComponent<Image>();
			this.MPFNCILGNLK = false;
			this.ODDHCMMIBGB();
			base.transform.parent.gameObject.SetActive(false);
		}

		// Token: 0x0600A2DB RID: 41691 RVA: 0x003CDEF4 File Offset: 0x003CC0F4
		private void EGBCKALNKLM()
		{
			this.GHOKOLMJONF = false;
			this.DFMPILPKNEG = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(898f, 487f, 319f));
			this.MKGAFHHNMII = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(1889f, 1666f, 730f));
			this.DMKHNNKODCF = (float)Screen.height / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.y;
			this.GFLLFHDMEAM = (float)Screen.width / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.x;
		}

		// Token: 0x0600A2DC RID: 41692 RVA: 0x003CDFA8 File Offset: 0x003CC1A8
		public void GOIOPCBBPJA()
		{
			Vector3 position = this.HLGFJLGJNCK.ScreenToViewportPoint(Input.mousePosition);
			float num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num > this.MKGAFHHNMII.x)
			{
				float num2 = this.MKGAFHHNMII.x - num;
				float num3;
				if ((double)num2 > (double)this.OCFIFJDJNMI * 296.0)
				{
					num3 = num2;
				}
				else
				{
					num3 = this.OCFIFJDJNMI - this.GAFKGLFACMF * 923f;
				}
				Vector3 position2 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + num3, 956f, 1729f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position2).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num < this.DFMPILPKNEG.x)
			{
				float num4 = this.DFMPILPKNEG.x - num;
				float num3;
				if ((double)num4 < (double)this.OCFIFJDJNMI * 525.0 - (double)this.GAFKGLFACMF)
				{
					num3 = -num4;
				}
				else
				{
					num3 = this.GAFKGLFACMF * 1566f;
				}
				Vector3 position3 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - num3, 21f, 1137f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position3).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - (this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y - this.LNFALDIJMLM);
			if (num > this.MKGAFHHNMII.y)
			{
				float num5 = this.MKGAFHHNMII.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num5 > (double)this.HMPNJBOIOAH * 1198.0)
				{
					num6 = num5;
				}
				else
				{
					num6 = this.HMPNJBOIOAH - this.LNFALDIJMLM * 303f;
				}
				Vector3 position4 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 746f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position4).y;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
			if (num < this.DFMPILPKNEG.y)
			{
				float num7 = this.DFMPILPKNEG.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num7 < (double)this.HMPNJBOIOAH * 791.0 - (double)this.LNFALDIJMLM)
				{
					num6 = num7;
				}
				else
				{
					num6 = this.LNFALDIJMLM * 335f;
				}
				Vector3 position5 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 1533f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position5).y;
			}
			base.transform.parent.transform.position = new Vector3(this.HLGFJLGJNCK.ViewportToWorldPoint(position).x, this.HLGFJLGJNCK.ViewportToWorldPoint(position).y, 1237f);
			base.transform.parent.gameObject.SetActive(true);
			this.MPFNCILGNLK = true;
		}

		// Token: 0x0600A2DD RID: 41693 RVA: 0x003CE404 File Offset: 0x003CC604
		private void KLECMGDIHOG()
		{
			if (this.GHOKOLMJONF)
			{
				this.GHOKOLMJONF = false;
				this.bgImage.sizeDelta = new Vector2(this.hlG.preferredWidth + (float)this.horizontalPadding, this.hlG.preferredHeight + (float)this.verticalPadding);
				this.HMPNJBOIOAH = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				this.OCFIFJDJNMI = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM * this.bgImage.pivot.x;
				this.LNFALDIJMLM = this.bgImage.sizeDelta.y * this.DMKHNNKODCF;
				this.GAFKGLFACMF = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM;
				this.MFBJDLHCDOD();
			}
		}

		// Token: 0x0600A2DE RID: 41694 RVA: 0x003CE50C File Offset: 0x003CC70C
		private void LHDAPNCCPNJ()
		{
			if (this.GHOKOLMJONF)
			{
				this.GHOKOLMJONF = false;
				this.bgImage.sizeDelta = new Vector2(this.hlG.preferredWidth + (float)this.horizontalPadding, this.hlG.preferredHeight + (float)this.verticalPadding);
				this.HMPNJBOIOAH = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				this.OCFIFJDJNMI = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM * this.bgImage.pivot.x;
				this.LNFALDIJMLM = this.bgImage.sizeDelta.y * this.DMKHNNKODCF;
				this.GAFKGLFACMF = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM;
				this.OEEOEKBFADN();
			}
		}

		// Token: 0x0600A2DF RID: 41695 RVA: 0x003CE614 File Offset: 0x003CC814
		public void CKJIKNHJALL()
		{
			Vector3 position = this.HLGFJLGJNCK.ScreenToViewportPoint(Input.mousePosition);
			float num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num > this.MKGAFHHNMII.x)
			{
				float num2 = this.MKGAFHHNMII.x - num;
				float num3;
				if ((double)num2 > (double)this.OCFIFJDJNMI * 8.0)
				{
					num3 = num2;
				}
				else
				{
					num3 = this.OCFIFJDJNMI - this.GAFKGLFACMF * 241f;
				}
				Vector3 position2 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + num3, 1247f, 727f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position2).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num < this.DFMPILPKNEG.x)
			{
				float num4 = this.DFMPILPKNEG.x - num;
				float num3;
				if ((double)num4 < (double)this.OCFIFJDJNMI * 806.0 - (double)this.GAFKGLFACMF)
				{
					num3 = -num4;
				}
				else
				{
					num3 = this.GAFKGLFACMF * 194f;
				}
				Vector3 position3 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - num3, 1482f, 470f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position3).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - (this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y - this.LNFALDIJMLM);
			if (num > this.MKGAFHHNMII.y)
			{
				float num5 = this.MKGAFHHNMII.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num5 > (double)this.HMPNJBOIOAH * 1274.0)
				{
					num6 = num5;
				}
				else
				{
					num6 = this.HMPNJBOIOAH - this.LNFALDIJMLM * 467f;
				}
				Vector3 position4 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 1964f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position4).y;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
			if (num < this.DFMPILPKNEG.y)
			{
				float num7 = this.DFMPILPKNEG.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num7 < (double)this.HMPNJBOIOAH * 1098.0 - (double)this.LNFALDIJMLM)
				{
					num6 = num7;
				}
				else
				{
					num6 = this.LNFALDIJMLM * 1850f;
				}
				Vector3 position5 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 66f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position5).y;
			}
			base.transform.parent.transform.position = new Vector3(this.HLGFJLGJNCK.ViewportToWorldPoint(position).x, this.HLGFJLGJNCK.ViewportToWorldPoint(position).y, 652f);
			base.transform.parent.gameObject.SetActive(true);
			this.MPFNCILGNLK = false;
		}

		// Token: 0x0600A2E0 RID: 41696 RVA: 0x003CEA70 File Offset: 0x003CCC70
		private void PEFHAAPKCAJ()
		{
			if (this.GHOKOLMJONF)
			{
				this.GHOKOLMJONF = true;
				this.bgImage.sizeDelta = new Vector2(this.hlG.preferredWidth + (float)this.horizontalPadding, this.hlG.preferredHeight + (float)this.verticalPadding);
				this.HMPNJBOIOAH = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				this.OCFIFJDJNMI = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM * this.bgImage.pivot.x;
				this.LNFALDIJMLM = this.bgImage.sizeDelta.y * this.DMKHNNKODCF;
				this.GAFKGLFACMF = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM;
				this.EENGANDDBIN();
			}
		}

		// Token: 0x0600A2E1 RID: 41697 RVA: 0x003CEB75 File Offset: 0x003CCD75
		public void PHFLKDLAFJF(string EAFAMAMDNEG, bool IMLPKOPBOMM)
		{
			this.JMDBONEFBIP();
			this.thisText.text = EAFAMAMDNEG;
			this.LHINCEHBMJA();
		}

		// Token: 0x0600A2E3 RID: 41699 RVA: 0x003CEB90 File Offset: 0x003CCD90
		private void MKLIAKAJFPO()
		{
			if (this.GHOKOLMJONF)
			{
				this.GHOKOLMJONF = false;
				this.bgImage.sizeDelta = new Vector2(this.hlG.preferredWidth + (float)this.horizontalPadding, this.hlG.preferredHeight + (float)this.verticalPadding);
				this.HMPNJBOIOAH = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				this.OCFIFJDJNMI = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM * this.bgImage.pivot.x;
				this.LNFALDIJMLM = this.bgImage.sizeDelta.y * this.DMKHNNKODCF;
				this.GAFKGLFACMF = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM;
				this.MJMKOOPDBED();
			}
		}

		// Token: 0x0600A2E4 RID: 41700 RVA: 0x003CEC98 File Offset: 0x003CCE98
		private void NMIPPCPINBN()
		{
			if (this.GHOKOLMJONF)
			{
				this.GHOKOLMJONF = false;
				this.bgImage.sizeDelta = new Vector2(this.hlG.preferredWidth + (float)this.horizontalPadding, this.hlG.preferredHeight + (float)this.verticalPadding);
				this.HMPNJBOIOAH = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				this.OCFIFJDJNMI = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM * this.bgImage.pivot.x;
				this.LNFALDIJMLM = this.bgImage.sizeDelta.y * this.DMKHNNKODCF;
				this.GAFKGLFACMF = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM;
				this.PNBMGNGPBMP();
			}
		}

		// Token: 0x0600A2E5 RID: 41701 RVA: 0x003CEDA0 File Offset: 0x003CCFA0
		private void BCECEKDJHLJ()
		{
			this.GHOKOLMJONF = true;
			this.DFMPILPKNEG = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(236f, 1152f, 732f));
			this.MKGAFHHNMII = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(1041f, 1273f, 1265f));
			this.DMKHNNKODCF = (float)Screen.height / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.y;
			this.GFLLFHDMEAM = (float)Screen.width / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.x;
		}

		// Token: 0x0600A2E6 RID: 41702 RVA: 0x003CD65E File Offset: 0x003CB85E
		private void IBHACCEEFFI()
		{
			this.FCFPNLHOCPC();
			if (this.MPFNCILGNLK && this.OKDFHMNJLOO == RenderMode.ScreenSpaceCamera)
			{
				this.OnScreenSpaceCamera();
			}
		}

		// Token: 0x0600A2E7 RID: 41703 RVA: 0x003CEE54 File Offset: 0x003CD054
		private void INHJDEOFAFI()
		{
			this.GHOKOLMJONF = false;
			this.DFMPILPKNEG = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(1473f, 589f, 1211f));
			this.MKGAFHHNMII = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(645f, 58f, 72f));
			this.DMKHNNKODCF = (float)Screen.height / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.y;
			this.GFLLFHDMEAM = (float)Screen.width / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.x;
		}

		// Token: 0x0600A2E8 RID: 41704 RVA: 0x003CEF08 File Offset: 0x003CD108
		public void IBHLABOPOBH()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 1914f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 282f);
		}

		// Token: 0x0600A2E9 RID: 41705 RVA: 0x003CEF9C File Offset: 0x003CD19C
		public void IANJIBJCLMN()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 1995f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 1047f);
		}

		// Token: 0x0600A2EA RID: 41706 RVA: 0x003CF030 File Offset: 0x003CD230
		public void MJMKOOPDBED()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 204f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 1774f);
		}

		// Token: 0x0600A2EB RID: 41707 RVA: 0x003CF0C1 File Offset: 0x003CD2C1
		private void JOACBIEHHCE()
		{
			this.LHDAPNCCPNJ();
			if (this.MPFNCILGNLK && this.OKDFHMNJLOO == RenderMode.ScreenSpaceCamera)
			{
				this.BFAOCEONBPE();
			}
		}

		// Token: 0x0600A2EC RID: 41708 RVA: 0x003CF0E8 File Offset: 0x003CD2E8
		private void OOBLNBNNLCN()
		{
			if (this.GHOKOLMJONF)
			{
				this.GHOKOLMJONF = true;
				this.bgImage.sizeDelta = new Vector2(this.hlG.preferredWidth + (float)this.horizontalPadding, this.hlG.preferredHeight + (float)this.verticalPadding);
				this.HMPNJBOIOAH = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				this.OCFIFJDJNMI = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM * this.bgImage.pivot.x;
				this.LNFALDIJMLM = this.bgImage.sizeDelta.y * this.DMKHNNKODCF;
				this.GAFKGLFACMF = this.bgImage.sizeDelta.x * this.GFLLFHDMEAM;
				this.OEEOEKBFADN();
			}
		}

		// Token: 0x0600A2ED RID: 41709 RVA: 0x003CF1F0 File Offset: 0x003CD3F0
		public void HLDALGBPALG()
		{
			Vector3 position = this.HLGFJLGJNCK.ScreenToViewportPoint(Input.mousePosition);
			float num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num > this.MKGAFHHNMII.x)
			{
				float num2 = this.MKGAFHHNMII.x - num;
				float num3;
				if ((double)num2 > (double)this.OCFIFJDJNMI * 199.0)
				{
					num3 = num2;
				}
				else
				{
					num3 = this.OCFIFJDJNMI - this.GAFKGLFACMF * 572f;
				}
				Vector3 position2 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + num3, 1118f, 1294f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position2).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num < this.DFMPILPKNEG.x)
			{
				float num4 = this.DFMPILPKNEG.x - num;
				float num3;
				if ((double)num4 < (double)this.OCFIFJDJNMI * 1749.0 - (double)this.GAFKGLFACMF)
				{
					num3 = -num4;
				}
				else
				{
					num3 = this.GAFKGLFACMF * 1823f;
				}
				Vector3 position3 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - num3, 132f, 1255f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position3).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - (this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y - this.LNFALDIJMLM);
			if (num > this.MKGAFHHNMII.y)
			{
				float num5 = this.MKGAFHHNMII.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num5 > (double)this.HMPNJBOIOAH * 97.0)
				{
					num6 = num5;
				}
				else
				{
					num6 = this.HMPNJBOIOAH - this.LNFALDIJMLM * 996f;
				}
				Vector3 position4 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 1761f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position4).y;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
			if (num < this.DFMPILPKNEG.y)
			{
				float num7 = this.DFMPILPKNEG.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num7 < (double)this.HMPNJBOIOAH * 317.0 - (double)this.LNFALDIJMLM)
				{
					num6 = num7;
				}
				else
				{
					num6 = this.LNFALDIJMLM * 480f;
				}
				Vector3 position5 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 1132f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position5).y;
			}
			base.transform.parent.transform.position = new Vector3(this.HLGFJLGJNCK.ViewportToWorldPoint(position).x, this.HLGFJLGJNCK.ViewportToWorldPoint(position).y, 860f);
			base.transform.parent.gameObject.SetActive(false);
			this.MPFNCILGNLK = true;
		}

		// Token: 0x0600A2EE RID: 41710 RVA: 0x003CF64C File Offset: 0x003CD84C
		public void OACHHIOHBMI()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 4f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 1783f);
		}

		// Token: 0x0600A2EF RID: 41711 RVA: 0x003CF6E0 File Offset: 0x003CD8E0
		public void JGIMIGKHLDF(string[] GNLOGEDHNGF)
		{
			this.EGBCKALNKLM();
			string text = string.Empty;
			int num = 0;
			foreach (string text2 in GNLOGEDHNGF)
			{
				if (num == 0)
				{
					text += text2;
				}
				else
				{
					text = text + "CameraFilterPack/Noise_TV" + text2;
				}
				num += 0;
			}
			this.thisText.text = text;
			this.BFAOCEONBPE();
		}

		// Token: 0x0600A2F0 RID: 41712 RVA: 0x003CF750 File Offset: 0x003CD950
		public void SetTooltip(string[] GNLOGEDHNGF)
		{
			this.PFFEMADMOKE();
			string text = string.Empty;
			int num = 0;
			foreach (string text2 in GNLOGEDHNGF)
			{
				if (num == 0)
				{
					text += text2;
				}
				else
				{
					text = text + "\n" + text2;
				}
				num++;
			}
			this.thisText.text = text;
			this.OnScreenSpaceCamera();
		}

		// Token: 0x0600A2F1 RID: 41713 RVA: 0x003CF7C0 File Offset: 0x003CD9C0
		public void LGMELMJCCBN(string EAFAMAMDNEG, bool IMLPKOPBOMM)
		{
			this.BCJOAANPKGN();
			this.thisText.text = EAFAMAMDNEG;
			this.LHINCEHBMJA();
		}

		// Token: 0x0600A2F2 RID: 41714 RVA: 0x003CF7DA File Offset: 0x003CD9DA
		public void JGFBDAJAHDN()
		{
			if (this.OKDFHMNJLOO == RenderMode.ScreenSpaceOverlay && this != null)
			{
				base.transform.parent.gameObject.SetActive(true);
				this.MPFNCILGNLK = true;
				this.GANPHPEKNPC();
			}
		}

		// Token: 0x0600A2F3 RID: 41715 RVA: 0x003CF818 File Offset: 0x003CDA18
		public void ODDHCMMIBGB()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 157f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 1402f);
		}

		// Token: 0x0600A2F4 RID: 41716 RVA: 0x003CF8AC File Offset: 0x003CDAAC
		public void OnScreenSpaceCamera()
		{
			Vector3 position = this.HLGFJLGJNCK.ScreenToViewportPoint(Input.mousePosition);
			float num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num > this.MKGAFHHNMII.x)
			{
				float num2 = this.MKGAFHHNMII.x - num;
				float num3;
				if ((double)num2 > (double)this.OCFIFJDJNMI * 0.75)
				{
					num3 = num2;
				}
				else
				{
					num3 = this.OCFIFJDJNMI - this.GAFKGLFACMF * 2f;
				}
				Vector3 position2 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + num3, 0f, 0f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position2).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num < this.DFMPILPKNEG.x)
			{
				float num4 = this.DFMPILPKNEG.x - num;
				float num3;
				if ((double)num4 < (double)this.OCFIFJDJNMI * 0.75 - (double)this.GAFKGLFACMF)
				{
					num3 = -num4;
				}
				else
				{
					num3 = this.GAFKGLFACMF * 2f;
				}
				Vector3 position3 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - num3, 0f, 0f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position3).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - (this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y - this.LNFALDIJMLM);
			if (num > this.MKGAFHHNMII.y)
			{
				float num5 = this.MKGAFHHNMII.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num5 > (double)this.HMPNJBOIOAH * 0.75)
				{
					num6 = num5;
				}
				else
				{
					num6 = this.HMPNJBOIOAH - this.LNFALDIJMLM * 2f;
				}
				Vector3 position4 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 0f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position4).y;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
			if (num < this.DFMPILPKNEG.y)
			{
				float num7 = this.DFMPILPKNEG.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num7 < (double)this.HMPNJBOIOAH * 0.75 - (double)this.LNFALDIJMLM)
				{
					num6 = num7;
				}
				else
				{
					num6 = this.LNFALDIJMLM * 2f;
				}
				Vector3 position5 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 0f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position5).y;
			}
			base.transform.parent.transform.position = new Vector3(this.HLGFJLGJNCK.ViewportToWorldPoint(position).x, this.HLGFJLGJNCK.ViewportToWorldPoint(position).y, 0f);
			base.transform.parent.gameObject.SetActive(true);
			this.MPFNCILGNLK = true;
		}

		// Token: 0x0600A2F5 RID: 41717 RVA: 0x003CFD08 File Offset: 0x003CDF08
		private void NPPCPBHOHHB()
		{
			this.GHOKOLMJONF = false;
			this.DFMPILPKNEG = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(1820f, 721f, 1378f));
			this.MKGAFHHNMII = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(1516f, 1698f, 591f));
			this.DMKHNNKODCF = (float)Screen.height / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.y;
			this.GFLLFHDMEAM = (float)Screen.width / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.x;
		}

		// Token: 0x0600A2F6 RID: 41718 RVA: 0x003CFDBC File Offset: 0x003CDFBC
		public void AGOPPMGFAFN()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 879f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 161f);
		}

		// Token: 0x0600A2F7 RID: 41719 RVA: 0x003CFE50 File Offset: 0x003CE050
		public void OGPLAIENJNI()
		{
			Vector3 position = this.HLGFJLGJNCK.ScreenToViewportPoint(Input.mousePosition);
			float num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num > this.MKGAFHHNMII.x)
			{
				float num2 = this.MKGAFHHNMII.x - num;
				float num3;
				if ((double)num2 > (double)this.OCFIFJDJNMI * 1010.0)
				{
					num3 = num2;
				}
				else
				{
					num3 = this.OCFIFJDJNMI - this.GAFKGLFACMF * 1568f;
				}
				Vector3 position2 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + num3, 15f, 887f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position2).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num < this.DFMPILPKNEG.x)
			{
				float num4 = this.DFMPILPKNEG.x - num;
				float num3;
				if ((double)num4 < (double)this.OCFIFJDJNMI * 1679.0 - (double)this.GAFKGLFACMF)
				{
					num3 = -num4;
				}
				else
				{
					num3 = this.GAFKGLFACMF * 298f;
				}
				Vector3 position3 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - num3, 1602f, 40f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position3).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - (this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y - this.LNFALDIJMLM);
			if (num > this.MKGAFHHNMII.y)
			{
				float num5 = this.MKGAFHHNMII.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num5 > (double)this.HMPNJBOIOAH * 298.0)
				{
					num6 = num5;
				}
				else
				{
					num6 = this.HMPNJBOIOAH - this.LNFALDIJMLM * 1963f;
				}
				Vector3 position4 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 1252f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position4).y;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
			if (num < this.DFMPILPKNEG.y)
			{
				float num7 = this.DFMPILPKNEG.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num7 < (double)this.HMPNJBOIOAH * 139.0 - (double)this.LNFALDIJMLM)
				{
					num6 = num7;
				}
				else
				{
					num6 = this.LNFALDIJMLM * 1701f;
				}
				Vector3 position5 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 1722f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position5).y;
			}
			base.transform.parent.transform.position = new Vector3(this.HLGFJLGJNCK.ViewportToWorldPoint(position).x, this.HLGFJLGJNCK.ViewportToWorldPoint(position).y, 77f);
			base.transform.parent.gameObject.SetActive(false);
			this.MPFNCILGNLK = true;
		}

		// Token: 0x0600A2F8 RID: 41720 RVA: 0x003D02AC File Offset: 0x003CE4AC
		public void CPFJFIBMEOK()
		{
			Vector3 position = this.HLGFJLGJNCK.ScreenToViewportPoint(Input.mousePosition);
			float num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num > this.MKGAFHHNMII.x)
			{
				float num2 = this.MKGAFHHNMII.x - num;
				float num3;
				if ((double)num2 > (double)this.OCFIFJDJNMI * 1934.0)
				{
					num3 = num2;
				}
				else
				{
					num3 = this.OCFIFJDJNMI - this.GAFKGLFACMF * 1807f;
				}
				Vector3 position2 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x + num3, 782f, 1819f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position2).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - this.GAFKGLFACMF * this.bgImage.pivot.x;
			if (num < this.DFMPILPKNEG.x)
			{
				float num4 = this.DFMPILPKNEG.x - num;
				float num3;
				if ((double)num4 < (double)this.OCFIFJDJNMI * 804.0 - (double)this.GAFKGLFACMF)
				{
					num3 = -num4;
				}
				else
				{
					num3 = this.GAFKGLFACMF * 1631f;
				}
				Vector3 position3 = new Vector3(this.HLGFJLGJNCK.ViewportToScreenPoint(position).x - num3, 888f, 1387f);
				position.x = this.HLGFJLGJNCK.ScreenToViewportPoint(position3).x;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - (this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y - this.LNFALDIJMLM);
			if (num > this.MKGAFHHNMII.y)
			{
				float num5 = this.MKGAFHHNMII.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num5 > (double)this.HMPNJBOIOAH * 1609.0)
				{
					num6 = num5;
				}
				else
				{
					num6 = this.HMPNJBOIOAH - this.LNFALDIJMLM * 45f;
				}
				Vector3 position4 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 970f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position4).y;
			}
			num = this.HLGFJLGJNCK.ViewportToScreenPoint(position).y - this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
			if (num < this.DFMPILPKNEG.y)
			{
				float num7 = this.DFMPILPKNEG.y - num;
				float num6 = this.bgImage.sizeDelta.y * this.DMKHNNKODCF * this.bgImage.pivot.y;
				if ((double)num7 < (double)this.HMPNJBOIOAH * 147.0 - (double)this.LNFALDIJMLM)
				{
					num6 = num7;
				}
				else
				{
					num6 = this.LNFALDIJMLM * 936f;
				}
				Vector3 position5 = new Vector3(position.x, this.HLGFJLGJNCK.ViewportToScreenPoint(position).y + num6, 1916f);
				position.y = this.HLGFJLGJNCK.ScreenToViewportPoint(position5).y;
			}
			base.transform.parent.transform.position = new Vector3(this.HLGFJLGJNCK.ViewportToWorldPoint(position).x, this.HLGFJLGJNCK.ViewportToWorldPoint(position).y, 527f);
			base.transform.parent.gameObject.SetActive(true);
			this.MPFNCILGNLK = true;
		}

		// Token: 0x0600A2F9 RID: 41721 RVA: 0x003D0708 File Offset: 0x003CE908
		private void OMMENHNGNEB()
		{
			this.GHOKOLMJONF = true;
			this.DFMPILPKNEG = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(1271f, 460f, 1538f));
			this.MKGAFHHNMII = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(1679f, 946f, 1391f));
			this.DMKHNNKODCF = (float)Screen.height / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.y;
			this.GFLLFHDMEAM = (float)Screen.width / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.x;
		}

		// Token: 0x0600A2FA RID: 41722 RVA: 0x003D07BC File Offset: 0x003CE9BC
		private void JHANGPCOCIG()
		{
			this.HLGFJLGJNCK = GameObject.Find("_TimeX").GetComponent<Camera>();
			this.OKDFHMNJLOO = base.transform.parent.parent.GetComponent<Canvas>().renderMode;
			this.DFEFFGOJFLL = this.bgImage.GetComponent<Image>();
			this.MPFNCILGNLK = false;
			this.HBDHAIMMAEO();
			base.transform.parent.gameObject.SetActive(true);
		}

		// Token: 0x0600A2FB RID: 41723 RVA: 0x003D0832 File Offset: 0x003CEA32
		public void LGKIGBAKGBE(string EAFAMAMDNEG)
		{
			this.KJMNBPJIJAO();
			this.thisText.text = EAFAMAMDNEG;
			this.OGPLAIENJNI();
		}

		// Token: 0x0600A2FC RID: 41724 RVA: 0x003D084C File Offset: 0x003CEA4C
		public void DBODOKLKNFB(string EAFAMAMDNEG)
		{
			this.PFFEMADMOKE();
			this.thisText.text = EAFAMAMDNEG;
			this.AAFFNEPJDBG();
		}

		// Token: 0x0600A2FD RID: 41725 RVA: 0x003D0866 File Offset: 0x003CEA66
		public void FODNDCOONIN(string EAFAMAMDNEG)
		{
			this.BCJOAANPKGN();
			this.thisText.text = EAFAMAMDNEG;
			this.OnScreenSpaceCamera();
		}

		// Token: 0x0600A2FE RID: 41726 RVA: 0x003D0880 File Offset: 0x003CEA80
		public void PNBMGNGPBMP()
		{
			Color color = this.thisText.color;
			this.thisText.color = new Color(color.r, color.g, color.b, 400f);
			this.DFEFFGOJFLL.color = new Color(this.DFEFFGOJFLL.color.r, this.DFEFFGOJFLL.color.g, this.DFEFFGOJFLL.color.b, 1495f);
		}

		// Token: 0x0600A2FF RID: 41727 RVA: 0x003D0914 File Offset: 0x003CEB14
		private void JJAKKADLGDE()
		{
			this.GHOKOLMJONF = false;
			this.DFMPILPKNEG = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(207f, 147f, 1862f));
			this.MKGAFHHNMII = this.HLGFJLGJNCK.ViewportToScreenPoint(new Vector3(1792f, 1042f, 825f));
			this.DMKHNNKODCF = (float)Screen.height / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.y;
			this.GFLLFHDMEAM = (float)Screen.width / base.transform.root.GetComponent<CanvasScaler>().referenceResolution.x;
		}

		// Token: 0x04001262 RID: 4706
		public int horizontalPadding;

		// Token: 0x04001263 RID: 4707
		public int verticalPadding;

		// Token: 0x04001264 RID: 4708
		public Text thisText;

		// Token: 0x04001265 RID: 4709
		public HorizontalLayoutGroup hlG;

		// Token: 0x04001266 RID: 4710
		public RectTransform bgImage;

		// Token: 0x04001267 RID: 4711
		private Image DFEFFGOJFLL;

		// Token: 0x04001268 RID: 4712
		private bool GHOKOLMJONF;

		// Token: 0x04001269 RID: 4713
		private bool MPFNCILGNLK;

		// Token: 0x0400126A RID: 4714
		private RenderMode OKDFHMNJLOO;

		// Token: 0x0400126B RID: 4715
		private Camera HLGFJLGJNCK;

		// Token: 0x0400126C RID: 4716
		private Vector3 DFMPILPKNEG;

		// Token: 0x0400126D RID: 4717
		private Vector3 MKGAFHHNMII;

		// Token: 0x0400126E RID: 4718
		private float DMKHNNKODCF;

		// Token: 0x0400126F RID: 4719
		private float GFLLFHDMEAM;

		// Token: 0x04001270 RID: 4720
		private float HMPNJBOIOAH;

		// Token: 0x04001271 RID: 4721
		private float OCFIFJDJNMI;

		// Token: 0x04001272 RID: 4722
		private float LNFALDIJMLM;

		// Token: 0x04001273 RID: 4723
		private float GAFKGLFACMF;
	}
}
