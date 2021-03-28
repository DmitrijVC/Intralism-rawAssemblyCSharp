using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200029B RID: 667
	public class ExampleSelectable : MonoBehaviour, IBoxSelectable
	{
		// Token: 0x0600A0AE RID: 41134 RVA: 0x003C2EFE File Offset: 0x003C10FE
		private Transform NAFIOKMLLAF()
		{
			return base.transform;
		}

		// Token: 0x0600A0AF RID: 41135 RVA: 0x003C2F06 File Offset: 0x003C1106
		public bool AECPMAMNJAO()
		{
			return this.KEJOBFPNNEA;
		}

		// Token: 0x0600A0B0 RID: 41136 RVA: 0x003C2F10 File Offset: 0x003C1110
		private void Update()
		{
			Color color = Color.white;
			if (this.preSelected)
			{
				color = Color.yellow;
			}
			if (this.selected)
			{
				color = Color.green;
			}
			if (this.EPPIAJKKMDG)
			{
				this.EPPIAJKKMDG.color = color;
			}
			else if (this.EAFAMAMDNEG)
			{
				this.EAFAMAMDNEG.color = color;
			}
			else if (this.IFGKDBEFCCA)
			{
				this.IFGKDBEFCCA.color = color;
			}
			else if (base.GetComponent<Renderer>())
			{
				base.GetComponent<Renderer>().material.color = color;
			}
		}

		// Token: 0x0600A0B1 RID: 41137 RVA: 0x003C2FC9 File Offset: 0x003C11C9
		private void Start()
		{
			this.EPPIAJKKMDG = base.transform.GetComponent<SpriteRenderer>();
			this.IFGKDBEFCCA = base.transform.GetComponent<Image>();
			this.EAFAMAMDNEG = base.transform.GetComponent<Text>();
		}

		// Token: 0x0600A0B2 RID: 41138 RVA: 0x003C2FC9 File Offset: 0x003C11C9
		private void NPLCENPNJBM()
		{
			this.EPPIAJKKMDG = base.transform.GetComponent<SpriteRenderer>();
			this.IFGKDBEFCCA = base.transform.GetComponent<Image>();
			this.EAFAMAMDNEG = base.transform.GetComponent<Text>();
		}

		// Token: 0x0600A0B3 RID: 41139 RVA: 0x003C2FC9 File Offset: 0x003C11C9
		private void KCCIEMBMOBA()
		{
			this.EPPIAJKKMDG = base.transform.GetComponent<SpriteRenderer>();
			this.IFGKDBEFCCA = base.transform.GetComponent<Image>();
			this.EAFAMAMDNEG = base.transform.GetComponent<Text>();
		}

		// Token: 0x0600A0B4 RID: 41140 RVA: 0x003C2FFE File Offset: 0x003C11FE
		public bool GFPBMOKPBOH()
		{
			return this.JOFMAKAIBBI;
		}

		// Token: 0x0600A0B5 RID: 41141 RVA: 0x003C3006 File Offset: 0x003C1206
		public void MKCIGBCFBJJ(bool DPNHODJHGJL)
		{
			this.JOFMAKAIBBI = DPNHODJHGJL;
		}

		// Token: 0x0600A0B6 RID: 41142 RVA: 0x003C2FC9 File Offset: 0x003C11C9
		private void CNGAJDBOCLJ()
		{
			this.EPPIAJKKMDG = base.transform.GetComponent<SpriteRenderer>();
			this.IFGKDBEFCCA = base.transform.GetComponent<Image>();
			this.EAFAMAMDNEG = base.transform.GetComponent<Text>();
		}

		// Token: 0x0600A0B7 RID: 41143 RVA: 0x003C3010 File Offset: 0x003C1210
		private void EHCGBJDFMHG()
		{
			Color color = Color.white;
			if (this.OAHECHEFGGA())
			{
				color = Color.yellow;
			}
			if (this.selected)
			{
				color = Color.green;
			}
			if (this.EPPIAJKKMDG)
			{
				this.EPPIAJKKMDG.color = color;
			}
			else if (this.EAFAMAMDNEG)
			{
				this.EAFAMAMDNEG.color = color;
			}
			else if (this.IFGKDBEFCCA)
			{
				this.IFGKDBEFCCA.color = color;
			}
			else if (base.GetComponent<Renderer>())
			{
				base.GetComponent<Renderer>().material.color = color;
			}
		}

		// Token: 0x0600A0B8 RID: 41144 RVA: 0x003C2FC9 File Offset: 0x003C11C9
		private void BGDPIHMAACO()
		{
			this.EPPIAJKKMDG = base.transform.GetComponent<SpriteRenderer>();
			this.IFGKDBEFCCA = base.transform.GetComponent<Image>();
			this.EAFAMAMDNEG = base.transform.GetComponent<Text>();
		}

		// Token: 0x0600A0B9 RID: 41145 RVA: 0x003C30CC File Offset: 0x003C12CC
		private void JDGFCEPDKAJ()
		{
			Color color = Color.white;
			if (this.GFPBMOKPBOH())
			{
				color = Color.yellow;
			}
			if (this.AECPMAMNJAO())
			{
				color = Color.green;
			}
			if (this.EPPIAJKKMDG)
			{
				this.EPPIAJKKMDG.color = color;
			}
			else if (this.EAFAMAMDNEG)
			{
				this.EAFAMAMDNEG.color = color;
			}
			else if (this.IFGKDBEFCCA)
			{
				this.IFGKDBEFCCA.color = color;
			}
			else if (base.GetComponent<Renderer>())
			{
				base.GetComponent<Renderer>().material.color = color;
			}
		}

		// Token: 0x0600A0BA RID: 41146 RVA: 0x003C2FFE File Offset: 0x003C11FE
		public bool OAHECHEFGGA()
		{
			return this.JOFMAKAIBBI;
		}

		// Token: 0x0600A0BB RID: 41147 RVA: 0x003C3185 File Offset: 0x003C1385
		public void CELGBPAIBGO(bool DPNHODJHGJL)
		{
			this.KEJOBFPNNEA = DPNHODJHGJL;
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x0600A0BC RID: 41148 RVA: 0x003C2FFE File Offset: 0x003C11FE
		// (set) Token: 0x0600A0C0 RID: 41152 RVA: 0x003C3006 File Offset: 0x003C1206
		public bool preSelected
		{
			get
			{
				return this.JOFMAKAIBBI;
			}
			set
			{
				this.JOFMAKAIBBI = value;
			}
		}

		// Token: 0x0600A0BD RID: 41149 RVA: 0x003C2EFE File Offset: 0x003C10FE
		private Transform DECCFOAFKAM()
		{
			return base.transform;
		}

		// Token: 0x0600A0BE RID: 41150 RVA: 0x003C3185 File Offset: 0x003C1385
		public void KAHPEKJJKLC(bool DPNHODJHGJL)
		{
			this.KEJOBFPNNEA = DPNHODJHGJL;
		}

		// Token: 0x0600A0BF RID: 41151 RVA: 0x003C3190 File Offset: 0x003C1390
		private void ONMGIPAILOH()
		{
			Color color = Color.white;
			if (this.HFPBNNMDMPG())
			{
				color = Color.yellow;
			}
			if (this.KJEFLLJIIGH())
			{
				color = Color.green;
			}
			if (this.EPPIAJKKMDG)
			{
				this.EPPIAJKKMDG.color = color;
			}
			else if (this.EAFAMAMDNEG)
			{
				this.EAFAMAMDNEG.color = color;
			}
			else if (this.IFGKDBEFCCA)
			{
				this.IFGKDBEFCCA.color = color;
			}
			else if (base.GetComponent<Renderer>())
			{
				base.GetComponent<Renderer>().material.color = color;
			}
		}

		// Token: 0x0600A0C1 RID: 41153 RVA: 0x003C2FC9 File Offset: 0x003C11C9
		private void FJNCHGLIEMA()
		{
			this.EPPIAJKKMDG = base.transform.GetComponent<SpriteRenderer>();
			this.IFGKDBEFCCA = base.transform.GetComponent<Image>();
			this.EAFAMAMDNEG = base.transform.GetComponent<Text>();
		}

		// Token: 0x0600A0C2 RID: 41154 RVA: 0x003C324C File Offset: 0x003C144C
		private void DPIPGGDNGHN()
		{
			Color color = Color.white;
			if (this.IIAPOLODJEE())
			{
				color = Color.yellow;
			}
			if (this.PJALKPFDGNA())
			{
				color = Color.green;
			}
			if (this.EPPIAJKKMDG)
			{
				this.EPPIAJKKMDG.color = color;
			}
			else if (this.EAFAMAMDNEG)
			{
				this.EAFAMAMDNEG.color = color;
			}
			else if (this.IFGKDBEFCCA)
			{
				this.IFGKDBEFCCA.color = color;
			}
			else if (base.GetComponent<Renderer>())
			{
				base.GetComponent<Renderer>().material.color = color;
			}
		}

		// Token: 0x0600A0C3 RID: 41155 RVA: 0x003C2FC9 File Offset: 0x003C11C9
		private void FIKFJDFELIP()
		{
			this.EPPIAJKKMDG = base.transform.GetComponent<SpriteRenderer>();
			this.IFGKDBEFCCA = base.transform.GetComponent<Image>();
			this.EAFAMAMDNEG = base.transform.GetComponent<Text>();
		}

		// Token: 0x0600A0C4 RID: 41156 RVA: 0x003C2FFE File Offset: 0x003C11FE
		public bool HFPBNNMDMPG()
		{
			return this.JOFMAKAIBBI;
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x0600A0D9 RID: 41177 RVA: 0x003C2F06 File Offset: 0x003C1106
		// (set) Token: 0x0600A0C5 RID: 41157 RVA: 0x003C3185 File Offset: 0x003C1385
		public bool selected
		{
			get
			{
				return this.KEJOBFPNNEA;
			}
			set
			{
				this.KEJOBFPNNEA = value;
			}
		}

		// Token: 0x0600A0C6 RID: 41158 RVA: 0x003C2EFE File Offset: 0x003C10FE
		private Transform BEOFNPKLGLI()
		{
			return base.transform;
		}

		// Token: 0x0600A0C7 RID: 41159 RVA: 0x003C2FFE File Offset: 0x003C11FE
		public bool IBEILFAPNCD()
		{
			return this.JOFMAKAIBBI;
		}

		// Token: 0x0600A0C8 RID: 41160 RVA: 0x003C2EFE File Offset: 0x003C10FE
		private Transform LJLGLJOJFIB()
		{
			return base.transform;
		}

		// Token: 0x0600A0C9 RID: 41161 RVA: 0x003C2EFE File Offset: 0x003C10FE
		private Transform MDJIJOGJGCI()
		{
			return base.transform;
		}

		// Token: 0x0600A0CA RID: 41162 RVA: 0x003C2F06 File Offset: 0x003C1106
		public bool HKFKINPDHBM()
		{
			return this.KEJOBFPNNEA;
		}

		// Token: 0x0600A0CC RID: 41164 RVA: 0x003C2EFE File Offset: 0x003C10FE
		private Transform FJGCEMDLMPI()
		{
			return base.transform;
		}

		// Token: 0x0600A0CD RID: 41165 RVA: 0x003C3006 File Offset: 0x003C1206
		public void ANBNDNFFFFO(bool DPNHODJHGJL)
		{
			this.JOFMAKAIBBI = DPNHODJHGJL;
		}

		// Token: 0x0600A0CE RID: 41166 RVA: 0x003C2FC9 File Offset: 0x003C11C9
		private void PMPKMGKAAJH()
		{
			this.EPPIAJKKMDG = base.transform.GetComponent<SpriteRenderer>();
			this.IFGKDBEFCCA = base.transform.GetComponent<Image>();
			this.EAFAMAMDNEG = base.transform.GetComponent<Text>();
		}

		// Token: 0x0600A0CF RID: 41167 RVA: 0x003C3006 File Offset: 0x003C1206
		public void FCLCMDCADDF(bool DPNHODJHGJL)
		{
			this.JOFMAKAIBBI = DPNHODJHGJL;
		}

		// Token: 0x0600A0D0 RID: 41168 RVA: 0x003C3006 File Offset: 0x003C1206
		public void OHNIJAFMPIF(bool DPNHODJHGJL)
		{
			this.JOFMAKAIBBI = DPNHODJHGJL;
		}

		// Token: 0x0600A0D1 RID: 41169 RVA: 0x003C2FFE File Offset: 0x003C11FE
		public bool IIAPOLODJEE()
		{
			return this.JOFMAKAIBBI;
		}

		// Token: 0x0600A0D2 RID: 41170 RVA: 0x003C3308 File Offset: 0x003C1508
		private void FOMNCPKKCFN()
		{
			Color color = Color.white;
			if (this.GFPBMOKPBOH())
			{
				color = Color.yellow;
			}
			if (this.PMMPKMKLHEA())
			{
				color = Color.green;
			}
			if (this.EPPIAJKKMDG)
			{
				this.EPPIAJKKMDG.color = color;
			}
			else if (this.EAFAMAMDNEG)
			{
				this.EAFAMAMDNEG.color = color;
			}
			else if (this.IFGKDBEFCCA)
			{
				this.IFGKDBEFCCA.color = color;
			}
			else if (base.GetComponent<Renderer>())
			{
				base.GetComponent<Renderer>().material.color = color;
			}
		}

		// Token: 0x0600A0D3 RID: 41171 RVA: 0x003C2F06 File Offset: 0x003C1106
		public bool PJALKPFDGNA()
		{
			return this.KEJOBFPNNEA;
		}

		// Token: 0x0600A0D4 RID: 41172 RVA: 0x003C3006 File Offset: 0x003C1206
		public void DNHLJPNBHLC(bool DPNHODJHGJL)
		{
			this.JOFMAKAIBBI = DPNHODJHGJL;
		}

		// Token: 0x0600A0D5 RID: 41173 RVA: 0x003C2FC9 File Offset: 0x003C11C9
		private void BEBNOKFLJPH()
		{
			this.EPPIAJKKMDG = base.transform.GetComponent<SpriteRenderer>();
			this.IFGKDBEFCCA = base.transform.GetComponent<Image>();
			this.EAFAMAMDNEG = base.transform.GetComponent<Text>();
		}

		// Token: 0x0600A0D6 RID: 41174 RVA: 0x003C2F06 File Offset: 0x003C1106
		public bool KJEFLLJIIGH()
		{
			return this.KEJOBFPNNEA;
		}

		// Token: 0x0600A0D7 RID: 41175 RVA: 0x003C3006 File Offset: 0x003C1206
		public void CKAOIHINHII(bool DPNHODJHGJL)
		{
			this.JOFMAKAIBBI = DPNHODJHGJL;
		}

		// Token: 0x0600A0D8 RID: 41176 RVA: 0x003C2FFE File Offset: 0x003C11FE
		public bool IJNHAJMBIKI()
		{
			return this.JOFMAKAIBBI;
		}

		// Token: 0x0600A0DA RID: 41178 RVA: 0x003C2EFE File Offset: 0x003C10FE
		private Transform FDAHACNMEOB()
		{
			return base.transform;
		}

		// Token: 0x0600A0DB RID: 41179 RVA: 0x003C2FC9 File Offset: 0x003C11C9
		private void DLBODOFAJGM()
		{
			this.EPPIAJKKMDG = base.transform.GetComponent<SpriteRenderer>();
			this.IFGKDBEFCCA = base.transform.GetComponent<Image>();
			this.EAFAMAMDNEG = base.transform.GetComponent<Text>();
		}

		// Token: 0x0600A0DC RID: 41180 RVA: 0x003C2EFE File Offset: 0x003C10FE
		private Transform OCJHICOPNDH()
		{
			return base.transform;
		}

		// Token: 0x0600A0DD RID: 41181 RVA: 0x003C33C4 File Offset: 0x003C15C4
		private void LPMINJJPDCH()
		{
			Color color = Color.white;
			if (this.IIAPOLODJEE())
			{
				color = Color.yellow;
			}
			if (this.selected)
			{
				color = Color.green;
			}
			if (this.EPPIAJKKMDG)
			{
				this.EPPIAJKKMDG.color = color;
			}
			else if (this.EAFAMAMDNEG)
			{
				this.EAFAMAMDNEG.color = color;
			}
			else if (this.IFGKDBEFCCA)
			{
				this.IFGKDBEFCCA.color = color;
			}
			else if (base.GetComponent<Renderer>())
			{
				base.GetComponent<Renderer>().material.color = color;
			}
		}

		// Token: 0x0600A0DE RID: 41182 RVA: 0x003C3185 File Offset: 0x003C1385
		public void OCFMNOLHKEB(bool DPNHODJHGJL)
		{
			this.KEJOBFPNNEA = DPNHODJHGJL;
		}

		// Token: 0x0600A0DF RID: 41183 RVA: 0x003C2EFE File Offset: 0x003C10FE
		private Transform JMBINBOFEFI()
		{
			return base.transform;
		}

		// Token: 0x0600A0E0 RID: 41184 RVA: 0x003C2FC9 File Offset: 0x003C11C9
		private void GPNAOAKCMHC()
		{
			this.EPPIAJKKMDG = base.transform.GetComponent<SpriteRenderer>();
			this.IFGKDBEFCCA = base.transform.GetComponent<Image>();
			this.EAFAMAMDNEG = base.transform.GetComponent<Text>();
		}

		// Token: 0x0600A0E1 RID: 41185 RVA: 0x003C3480 File Offset: 0x003C1680
		private void LCHBFNIPBHB()
		{
			Color color = Color.white;
			if (this.OAHECHEFGGA())
			{
				color = Color.yellow;
			}
			if (this.PMMPKMKLHEA())
			{
				color = Color.green;
			}
			if (this.EPPIAJKKMDG)
			{
				this.EPPIAJKKMDG.color = color;
			}
			else if (this.EAFAMAMDNEG)
			{
				this.EAFAMAMDNEG.color = color;
			}
			else if (this.IFGKDBEFCCA)
			{
				this.IFGKDBEFCCA.color = color;
			}
			else if (base.GetComponent<Renderer>())
			{
				base.GetComponent<Renderer>().material.color = color;
			}
		}

		// Token: 0x0600A0E2 RID: 41186 RVA: 0x003C2FC9 File Offset: 0x003C11C9
		private void CCLNNLCOPBL()
		{
			this.EPPIAJKKMDG = base.transform.GetComponent<SpriteRenderer>();
			this.IFGKDBEFCCA = base.transform.GetComponent<Image>();
			this.EAFAMAMDNEG = base.transform.GetComponent<Text>();
		}

		// Token: 0x0600A0E3 RID: 41187 RVA: 0x003C2FFE File Offset: 0x003C11FE
		public bool MECODENLCJG()
		{
			return this.JOFMAKAIBBI;
		}

		// Token: 0x0600A0E4 RID: 41188 RVA: 0x003C3185 File Offset: 0x003C1385
		public void MKPIDPECNGM(bool DPNHODJHGJL)
		{
			this.KEJOBFPNNEA = DPNHODJHGJL;
		}

		// Token: 0x0600A0E5 RID: 41189 RVA: 0x003C2FC9 File Offset: 0x003C11C9
		private void MKIMDFLBFOM()
		{
			this.EPPIAJKKMDG = base.transform.GetComponent<SpriteRenderer>();
			this.IFGKDBEFCCA = base.transform.GetComponent<Image>();
			this.EAFAMAMDNEG = base.transform.GetComponent<Text>();
		}

		// Token: 0x0600A0E6 RID: 41190 RVA: 0x003C2FC9 File Offset: 0x003C11C9
		private void EFJDNLGNACH()
		{
			this.EPPIAJKKMDG = base.transform.GetComponent<SpriteRenderer>();
			this.IFGKDBEFCCA = base.transform.GetComponent<Image>();
			this.EAFAMAMDNEG = base.transform.GetComponent<Text>();
		}

		// Token: 0x0600A0E7 RID: 41191 RVA: 0x003C2FC9 File Offset: 0x003C11C9
		private void EPEGAEGDJAM()
		{
			this.EPPIAJKKMDG = base.transform.GetComponent<SpriteRenderer>();
			this.IFGKDBEFCCA = base.transform.GetComponent<Image>();
			this.EAFAMAMDNEG = base.transform.GetComponent<Text>();
		}

		// Token: 0x0600A0E8 RID: 41192 RVA: 0x003C2EFE File Offset: 0x003C10FE
		Transform IBoxSelectable.get_transform()
		{
			return base.transform;
		}

		// Token: 0x0600A0E9 RID: 41193 RVA: 0x003C3185 File Offset: 0x003C1385
		public void KCOIDJDGKGC(bool DPNHODJHGJL)
		{
			this.KEJOBFPNNEA = DPNHODJHGJL;
		}

		// Token: 0x0600A0EA RID: 41194 RVA: 0x003C2FC9 File Offset: 0x003C11C9
		private void KLILJHJNICK()
		{
			this.EPPIAJKKMDG = base.transform.GetComponent<SpriteRenderer>();
			this.IFGKDBEFCCA = base.transform.GetComponent<Image>();
			this.EAFAMAMDNEG = base.transform.GetComponent<Text>();
		}

		// Token: 0x0600A0EB RID: 41195 RVA: 0x003C2F06 File Offset: 0x003C1106
		public bool DNBBPICIPGK()
		{
			return this.KEJOBFPNNEA;
		}

		// Token: 0x0600A0EC RID: 41196 RVA: 0x003C3006 File Offset: 0x003C1206
		public void CKDAIHAMNDD(bool DPNHODJHGJL)
		{
			this.JOFMAKAIBBI = DPNHODJHGJL;
		}

		// Token: 0x0600A0ED RID: 41197 RVA: 0x003C2EFE File Offset: 0x003C10FE
		private Transform MPKKLAPCCJM()
		{
			return base.transform;
		}

		// Token: 0x0600A0EE RID: 41198 RVA: 0x003C3006 File Offset: 0x003C1206
		public void NDBGPMNKEAD(bool DPNHODJHGJL)
		{
			this.JOFMAKAIBBI = DPNHODJHGJL;
		}

		// Token: 0x0600A0EF RID: 41199 RVA: 0x003C353C File Offset: 0x003C173C
		private void CGBHOELMAOC()
		{
			Color color = Color.white;
			if (this.GFPBMOKPBOH())
			{
				color = Color.yellow;
			}
			if (this.ADKKKIOLPEB())
			{
				color = Color.green;
			}
			if (this.EPPIAJKKMDG)
			{
				this.EPPIAJKKMDG.color = color;
			}
			else if (this.EAFAMAMDNEG)
			{
				this.EAFAMAMDNEG.color = color;
			}
			else if (this.IFGKDBEFCCA)
			{
				this.IFGKDBEFCCA.color = color;
			}
			else if (base.GetComponent<Renderer>())
			{
				base.GetComponent<Renderer>().material.color = color;
			}
		}

		// Token: 0x0600A0F0 RID: 41200 RVA: 0x003C2F06 File Offset: 0x003C1106
		public bool FJCCLEMLDFN()
		{
			return this.KEJOBFPNNEA;
		}

		// Token: 0x0600A0F1 RID: 41201 RVA: 0x003C3185 File Offset: 0x003C1385
		public void FIMDFGPIKOB(bool DPNHODJHGJL)
		{
			this.KEJOBFPNNEA = DPNHODJHGJL;
		}

		// Token: 0x0600A0F2 RID: 41202 RVA: 0x003C2F06 File Offset: 0x003C1106
		public bool PMMPKMKLHEA()
		{
			return this.KEJOBFPNNEA;
		}

		// Token: 0x0600A0F3 RID: 41203 RVA: 0x003C35F8 File Offset: 0x003C17F8
		private void HDDECCMEJKA()
		{
			Color color = Color.white;
			if (this.OAHECHEFGGA())
			{
				color = Color.yellow;
			}
			if (this.AECPMAMNJAO())
			{
				color = Color.green;
			}
			if (this.EPPIAJKKMDG)
			{
				this.EPPIAJKKMDG.color = color;
			}
			else if (this.EAFAMAMDNEG)
			{
				this.EAFAMAMDNEG.color = color;
			}
			else if (this.IFGKDBEFCCA)
			{
				this.IFGKDBEFCCA.color = color;
			}
			else if (base.GetComponent<Renderer>())
			{
				base.GetComponent<Renderer>().material.color = color;
			}
		}

		// Token: 0x0600A0F4 RID: 41204 RVA: 0x003C2EFE File Offset: 0x003C10FE
		private Transform AKBAJMGGLFL()
		{
			return base.transform;
		}

		// Token: 0x0600A0F5 RID: 41205 RVA: 0x003C2EFE File Offset: 0x003C10FE
		private Transform MDGOONOAKLK()
		{
			return base.transform;
		}

		// Token: 0x0600A0F6 RID: 41206 RVA: 0x003C2F06 File Offset: 0x003C1106
		public bool ADKKKIOLPEB()
		{
			return this.KEJOBFPNNEA;
		}

		// Token: 0x0600A0F7 RID: 41207 RVA: 0x003C3185 File Offset: 0x003C1385
		public void BDKJKGKKHAB(bool DPNHODJHGJL)
		{
			this.KEJOBFPNNEA = DPNHODJHGJL;
		}

		// Token: 0x04001247 RID: 4679
		private bool KEJOBFPNNEA;

		// Token: 0x04001248 RID: 4680
		private bool JOFMAKAIBBI;

		// Token: 0x04001249 RID: 4681
		private SpriteRenderer EPPIAJKKMDG;

		// Token: 0x0400124A RID: 4682
		private Image IFGKDBEFCCA;

		// Token: 0x0400124B RID: 4683
		private Text EAFAMAMDNEG;
	}
}
