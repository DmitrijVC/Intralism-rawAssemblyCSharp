using System;
using UnityEngine;

namespace UnityStandardAssets.ImageEffects
{
	// Token: 0x02000481 RID: 1153
	[AddComponentMenu("Image Effects/Color Adjustments/Inver Color")]
	[ExecuteInEditMode]
	public class InvertColors : ImageEffectBase
	{
		// Token: 0x06010884 RID: 67716 RVA: 0x0059C32C File Offset: 0x0059A52C
		public void GMELGGJOPBB()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 1354f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x06010885 RID: 67717 RVA: 0x0059C384 File Offset: 0x0059A584
		private void LPFDJPCIADE(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.FLGPDBBKAIP().SetFloat("addNewButton", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.GJHLADDCMFF());
		}

		// Token: 0x06010886 RID: 67718 RVA: 0x0059C3A9 File Offset: 0x0059A5A9
		private void KENMBHKMEFK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.JFDGLLEOPGB().SetFloat("[LevelEditorScene] Updated", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.MICHFGAOPKM());
		}

		// Token: 0x06010887 RID: 67719 RVA: 0x0059C3CE File Offset: 0x0059A5CE
		private void MDHIALGJMBO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.ABHDNGIHBKE().SetFloat("_Value3", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.DONENAMLFLF());
		}

		// Token: 0x06010888 RID: 67720 RVA: 0x0059C3F3 File Offset: 0x0059A5F3
		private void NEALKDCJCJH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.HHIFMIPPMPF().SetFloat("_ScreenResolution", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NFMGLIKNOOC());
		}

		// Token: 0x06010889 RID: 67721 RVA: 0x0059C418 File Offset: 0x0059A618
		public void AAPKBNDHBLI()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 942f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x0601088A RID: 67722 RVA: 0x0059C470 File Offset: 0x0059A670
		private void CDCLDBFMKOG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.DNLMFEGJJDD().SetFloat("Dec", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NJDIODJNGGA());
		}

		// Token: 0x0601088B RID: 67723 RVA: 0x0059C498 File Offset: 0x0059A698
		public void Update()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 1f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x0601088C RID: 67724 RVA: 0x0059C4F0 File Offset: 0x0059A6F0
		public void JOACBIEHHCE()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 1731f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x0601088D RID: 67725 RVA: 0x0059C548 File Offset: 0x0059A748
		public void LCJHDLKJEOM()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 417f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x0601088E RID: 67726 RVA: 0x0059C5A0 File Offset: 0x0059A7A0
		public void IKIDIJLIGOH()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 952f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x0601088F RID: 67727 RVA: 0x0059C5F8 File Offset: 0x0059A7F8
		private void OnRenderImage(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.NBPKMLMCHFN.SetFloat("_Value1", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NBPKMLMCHFN);
		}

		// Token: 0x06010890 RID: 67728 RVA: 0x0059C61D File Offset: 0x0059A81D
		private void GHILGJJEAOF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.NBPKMLMCHFN.SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NLFJGMBCICG());
		}

		// Token: 0x06010891 RID: 67729 RVA: 0x0059C644 File Offset: 0x0059A844
		public void OMCLOFCJMPG()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 1096f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x06010892 RID: 67730 RVA: 0x0059C69C File Offset: 0x0059A89C
		private void CENLKOLIACP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.HEINDEMCGIK().SetFloat("_FgOverlap", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.EPCGJFCCAFH());
		}

		// Token: 0x06010893 RID: 67731 RVA: 0x0059C6C4 File Offset: 0x0059A8C4
		public void IEMEHGCFAPD()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 1297f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x06010894 RID: 67732 RVA: 0x0059C71C File Offset: 0x0059A91C
		public void BGFJOEPFOPM()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 194f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x06010895 RID: 67733 RVA: 0x0059C774 File Offset: 0x0059A974
		private void KKHCDAPLABD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.IIJMIPBMMBF().SetFloat(".message", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.CECICEGFHKL());
		}

		// Token: 0x06010896 RID: 67734 RVA: 0x0059C799 File Offset: 0x0059A999
		private void HGJJPACDBEP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.IIBLJCKLGFG().SetFloat("OPEN FILE", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.EPCGJFCCAFH());
		}

		// Token: 0x06010897 RID: 67735 RVA: 0x0059C7C0 File Offset: 0x0059A9C0
		public void MAOCOEGAFND()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 1032f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x06010898 RID: 67736 RVA: 0x0059C818 File Offset: 0x0059AA18
		public void OPCLBGHAPMG()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 2f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x06010899 RID: 67737 RVA: 0x0059C870 File Offset: 0x0059AA70
		public void HDDECCMEJKA()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 743f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x0601089A RID: 67738 RVA: 0x0059C8C8 File Offset: 0x0059AAC8
		public void NKLIHNJCHOG()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 1889f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x0601089B RID: 67739 RVA: 0x0059C920 File Offset: 0x0059AB20
		public void PBEPCAPAKLG()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 384f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x0601089C RID: 67740 RVA: 0x0059C978 File Offset: 0x0059AB78
		public void LJIHHJOAJCN()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 1363f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x0601089D RID: 67741 RVA: 0x0059C9D0 File Offset: 0x0059ABD0
		private void EEFLHPENNEI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.NBPKMLMCHFN.SetFloat("_PositionX", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.OOMFJGPAOKL());
		}

		// Token: 0x0601089E RID: 67742 RVA: 0x0059C9F5 File Offset: 0x0059ABF5
		private void KEFKNAOGCHO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.OKJOKHGJHGF().SetFloat("_Value4", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.PGPEMMBJOOG());
		}

		// Token: 0x0601089F RID: 67743 RVA: 0x0059CA1C File Offset: 0x0059AC1C
		public void IBHACCEEFFI()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 1835f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x060108A0 RID: 67744 RVA: 0x0059CA74 File Offset: 0x0059AC74
		private void EMKCNMFNDDD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.IIJMIPBMMBF().SetFloat("CameraFilterPack/Edge_Edge_filter", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.OOMFJGPAOKL());
		}

		// Token: 0x060108A1 RID: 67745 RVA: 0x0059CA9C File Offset: 0x0059AC9C
		public void KMKLDAJLCNM()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 1390f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x060108A2 RID: 67746 RVA: 0x0059CAF4 File Offset: 0x0059ACF4
		public void LMADKINICIN()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 1918f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x060108A3 RID: 67747 RVA: 0x0059CB4C File Offset: 0x0059AD4C
		private void DGMODDJIAKL(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.LDNADDJMIPK().SetFloat("0 seconds", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.DONENAMLFLF());
		}

		// Token: 0x060108A4 RID: 67748 RVA: 0x0059CB71 File Offset: 0x0059AD71
		private void LDIOANOMHMO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.AELJLBOJAIL().SetFloat("_ScreenResolution", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.CFCPHFMKHII());
		}

		// Token: 0x060108A5 RID: 67749 RVA: 0x0059CB96 File Offset: 0x0059AD96
		private void MMBPPEPNNLA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.OKJOKHGJHGF().SetFloat(" cannot be used as a 3D LUT.", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HKHBBBFLGJH());
		}

		// Token: 0x060108A6 RID: 67750 RVA: 0x0059CBBB File Offset: 0x0059ADBB
		private void CACIIEMMMHG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.CECICEGFHKL().SetFloat("_Intensity", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NFMGLIKNOOC());
		}

		// Token: 0x060108A7 RID: 67751 RVA: 0x0059CBE0 File Offset: 0x0059ADE0
		public void HIKKPDACJGI()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 676f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x060108A8 RID: 67752 RVA: 0x0059CC38 File Offset: 0x0059AE38
		private void EFMOIIPLOOB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.DONENAMLFLF().SetFloat("SpawnObj", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HEINDEMCGIK());
		}

		// Token: 0x060108A9 RID: 67753 RVA: 0x0059CC60 File Offset: 0x0059AE60
		public void JNBPKNNBMDI()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 1570f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x060108AA RID: 67754 RVA: 0x0059CCB8 File Offset: 0x0059AEB8
		public void AIJGAJIOJDJ()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 1087f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x060108AB RID: 67755 RVA: 0x0059CD10 File Offset: 0x0059AF10
		private void ABOJKHKBJLN(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.LDNADDJMIPK().SetFloat("Set Satellite Trail Width", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.EJDPNJAEAKJ());
		}

		// Token: 0x060108AC RID: 67756 RVA: 0x0059CD35 File Offset: 0x0059AF35
		private void NKKLGKPFPIK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.HKHBBBFLGJH().SetFloat("_", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HKGAONMOBMH());
		}

		// Token: 0x060108AD RID: 67757 RVA: 0x0059CD5C File Offset: 0x0059AF5C
		public void JBNPEHMDCMI()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 26f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x060108AE RID: 67758 RVA: 0x0059CDB4 File Offset: 0x0059AFB4
		private void NBHMOIGDDAD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.DNLMFEGJJDD().SetFloat("Illegal view ID:", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NJDIODJNGGA());
		}

		// Token: 0x060108AF RID: 67759 RVA: 0x0059CDD9 File Offset: 0x0059AFD9
		private void AODKAMLEIOJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.DONENAMLFLF().SetFloat("_Near", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.CIAFLBFJLEJ());
		}

		// Token: 0x060108B0 RID: 67760 RVA: 0x0059CE00 File Offset: 0x0059B000
		public void EJFJENFKLND()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 1209f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x060108B1 RID: 67761 RVA: 0x0059CE58 File Offset: 0x0059B058
		private void OKNOJEEGONA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.PGPEMMBJOOG().SetFloat("MenuScene", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.IGKFMCPDNOI());
		}

		// Token: 0x060108B2 RID: 67762 RVA: 0x0059CE7D File Offset: 0x0059B07D
		private void BLMICAMBBCD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.PGPEMMBJOOG().SetFloat("CameraFilterPack/Noise_TV", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NFMGLIKNOOC());
		}

		// Token: 0x060108B3 RID: 67763 RVA: 0x0059CEA4 File Offset: 0x0059B0A4
		public void JBCNIPJDPJB()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 1197f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x060108B4 RID: 67764 RVA: 0x0059CEFC File Offset: 0x0059B0FC
		public void MMBPLGGLPDB()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 1026f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x060108B5 RID: 67765 RVA: 0x0059CF54 File Offset: 0x0059B154
		public void KIEJKBNBHMD()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 427f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x060108B6 RID: 67766 RVA: 0x0059CFAC File Offset: 0x0059B1AC
		public void OEENOOGEEHD()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 529f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x060108B7 RID: 67767 RVA: 0x0059D004 File Offset: 0x0059B204
		private void LBHPMIDFKPP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.HKHBBBFLGJH().SetFloat(": ", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.LEIAFCPJMDP());
		}

		// Token: 0x060108B8 RID: 67768 RVA: 0x0059D029 File Offset: 0x0059B229
		private void KDFILLAPHIO(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.CFCPHFMKHII().SetFloat("yes", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.EMDFHOKEGNG());
		}

		// Token: 0x060108B9 RID: 67769 RVA: 0x0059D050 File Offset: 0x0059B250
		public void HNDNDPECBPL()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 224f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x060108BA RID: 67770 RVA: 0x0059D0A8 File Offset: 0x0059B2A8
		private void DHJKAOMONAJ(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.OKJOKHGJHGF().SetFloat("event", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.AELJLBOJAIL());
		}

		// Token: 0x060108BB RID: 67771 RVA: 0x0059D0D0 File Offset: 0x0059B2D0
		public void ONMGIPAILOH()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 812f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x060108BD RID: 67773 RVA: 0x0059D13C File Offset: 0x0059B33C
		public void AEIJFLJEABG()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 1085f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x060108BE RID: 67774 RVA: 0x0059D194 File Offset: 0x0059B394
		private void NJFDLOBJCCF(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.LMLENGFLEBD().SetFloat("SpawnObj", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.OIBHFCLJKDB());
		}

		// Token: 0x060108BF RID: 67775 RVA: 0x0059D1B9 File Offset: 0x0059B3B9
		private void PACLEGDKKPI(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.FLGPDBBKAIP().SetFloat("menu.selectedplaymode", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.FLGPDBBKAIP());
		}

		// Token: 0x060108C0 RID: 67776 RVA: 0x0059D1DE File Offset: 0x0059B3DE
		private void DPMMIPDKJND(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.IGIAPKPKGPK().SetFloat("_TimeX", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.CBCNOEIALHB());
		}

		// Token: 0x060108C1 RID: 67777 RVA: 0x0059D204 File Offset: 0x0059B404
		public void CFIAKIJAILI()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 1803f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x060108C2 RID: 67778 RVA: 0x0059D25C File Offset: 0x0059B45C
		public void KMEONPMCNJG()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 1901f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x060108C3 RID: 67779 RVA: 0x0059D2B4 File Offset: 0x0059B4B4
		private void AIJJOIOAKGD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.CIAFLBFJLEJ().SetFloat("[PlayerBase] Starting new round", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NLFJGMBCICG());
		}

		// Token: 0x060108C4 RID: 67780 RVA: 0x0059D2DC File Offset: 0x0059B4DC
		public void AGMJDGHLBMN()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 1008f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x060108C5 RID: 67781 RVA: 0x0059D334 File Offset: 0x0059B534
		private void JBMEPDENLOM(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.EMDFHOKEGNG().SetFloat("offsets", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.EJDPNJAEAKJ());
		}

		// Token: 0x060108C6 RID: 67782 RVA: 0x0059D359 File Offset: 0x0059B559
		private void GOBILPKKHFA(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.FLGPDBBKAIP().SetFloat("[LocalizationService] Loading file: ", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.CIAFLBFJLEJ());
		}

		// Token: 0x060108C7 RID: 67783 RVA: 0x0059D380 File Offset: 0x0059B580
		public void GHILDCBCDJI()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 0f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x060108C8 RID: 67784 RVA: 0x0059D3D8 File Offset: 0x0059B5D8
		private void DBIDOEKLEII(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.HEHKGPKLAKK().SetFloat("[ReplayScene] Loading replay: ", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.GCDFNHMJMIP());
		}

		// Token: 0x060108C9 RID: 67785 RVA: 0x0059D3FD File Offset: 0x0059B5FD
		private void KMAPABACMAG(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.EJDPNJAEAKJ().SetFloat("DifficultyBG", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.IIJMIPBMMBF());
		}

		// Token: 0x060108CA RID: 67786 RVA: 0x0059D422 File Offset: 0x0059B622
		private void HELHDLOLPLH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.GJHLADDCMFF().SetFloat("inventory.selected.", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.OLHDPICFBOF());
		}

		// Token: 0x060108CB RID: 67787 RVA: 0x0059D447 File Offset: 0x0059B647
		private void PEBBCNICBDK(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.HEHKGPKLAKK().SetFloat("[NetworkManager] Join failed", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.BAGICADFBAB());
		}

		// Token: 0x060108CC RID: 67788 RVA: 0x0059D46C File Offset: 0x0059B66C
		private void JJCEACGCOHB(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.EPCGJFCCAFH().SetFloat("PopulateMapsList", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.HEINDEMCGIK());
		}

		// Token: 0x060108CD RID: 67789 RVA: 0x0059D494 File Offset: 0x0059B694
		public void GPFJMKCGHGB()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 803f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x060108CE RID: 67790 RVA: 0x0059D4EC File Offset: 0x0059B6EC
		private void NHNMJJBFLJP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.OKJOKHGJHGF().SetFloat(".lastCheckpoint.perfectHits", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.NBPKMLMCHFN);
		}

		// Token: 0x060108CF RID: 67791 RVA: 0x0059D514 File Offset: 0x0059B714
		public void NDAJBJFJGCF()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 1630f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x060108D0 RID: 67792 RVA: 0x0059D56C File Offset: 0x0059B76C
		public void MJNPIDGNJMK()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 1820f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x060108D1 RID: 67793 RVA: 0x0059D5C4 File Offset: 0x0059B7C4
		private void CGIMPFJPEKD(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.IGIAPKPKGPK().SetFloat("StartButton", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.IGKFMCPDNOI());
		}

		// Token: 0x060108D2 RID: 67794 RVA: 0x0059D5EC File Offset: 0x0059B7EC
		public void EHCGBJDFMHG()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 664f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x060108D3 RID: 67795 RVA: 0x0059D644 File Offset: 0x0059B844
		private void KFGGHDFLDIP(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.HEHKGPKLAKK().SetFloat(" not exist", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.ABHDNGIHBKE());
		}

		// Token: 0x060108D4 RID: 67796 RVA: 0x0059D669 File Offset: 0x0059B869
		private void IFMHIDNCFFH(RenderTexture HLBKCLPNHEB, RenderTexture BMMLHGHKBNM)
		{
			base.EMDFHOKEGNG().SetFloat("[MapEditor] Created new map: ", this.CJDCPHOOFMC);
			Graphics.Blit(HLBKCLPNHEB, BMMLHGHKBNM, base.LDNADDJMIPK());
		}

		// Token: 0x060108D5 RID: 67797 RVA: 0x0059D690 File Offset: 0x0059B890
		public void NFEDLAOPHML()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 308f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x060108D6 RID: 67798 RVA: 0x0059D6E8 File Offset: 0x0059B8E8
		public void POJFHDFJOPE()
		{
			if (this.CJDCPHOOFMC < this.intensity)
			{
				this.CJDCPHOOFMC += 305f * Time.deltaTime;
			}
			else if (this.CJDCPHOOFMC != this.intensity)
			{
				this.CJDCPHOOFMC = this.intensity;
			}
		}

		// Token: 0x04001CF0 RID: 7408
		[Range(0f, 2f)]
		public float intensity = 1f;

		// Token: 0x04001CF1 RID: 7409
		private float CJDCPHOOFMC;
	}
}
