using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x020002A1 RID: 673
	[AddComponentMenu("UI/Extensions/Bound Tooltip/Tooltip Item")]
	public class BoundTooltipItem : MonoBehaviour
	{
		// Token: 0x0600A17B RID: 41339 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem BOGNFIBCFOM()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A17C RID: 41340 RVA: 0x003C7C3C File Offset: 0x003C5E3C
		public void IINMEHKDFOI(string EAFAMAMDNEG, Vector3 HMDKPLLDBEA)
		{
			if (this.TooltipText.text != EAFAMAMDNEG)
			{
				this.TooltipText.text = EAFAMAMDNEG;
			}
			base.transform.position = HMDKPLLDBEA + this.ToolTipOffset;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A17D RID: 41341 RVA: 0x003C7C8E File Offset: 0x003C5E8E
		public bool LGEPKLBEHML()
		{
			return base.gameObject.activeSelf;
		}

		// Token: 0x0600A17E RID: 41342 RVA: 0x003C7C8E File Offset: 0x003C5E8E
		public bool HIPMCMLCBEE()
		{
			return base.gameObject.activeSelf;
		}

		// Token: 0x0600A180 RID: 41344 RVA: 0x003C7C8E File Offset: 0x003C5E8E
		public bool NHPDIJOLCEA()
		{
			return base.gameObject.activeSelf;
		}

		// Token: 0x0600A181 RID: 41345 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem GLAEIAAPEFK()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A182 RID: 41346 RVA: 0x003C7C8E File Offset: 0x003C5E8E
		public bool BADPPBNNPKN()
		{
			return base.gameObject.activeSelf;
		}

		// Token: 0x0600A183 RID: 41347 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem BIPJOHJMDJB()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A184 RID: 41348 RVA: 0x003C7C8E File Offset: 0x003C5E8E
		public bool KLMKOIMDACA()
		{
			return base.gameObject.activeSelf;
		}

		// Token: 0x0600A185 RID: 41349 RVA: 0x003C7C9C File Offset: 0x003C5E9C
		public void AIIMPHBJHIK(string EAFAMAMDNEG, Vector3 HMDKPLLDBEA)
		{
			if (this.TooltipText.text != EAFAMAMDNEG)
			{
				this.TooltipText.text = EAFAMAMDNEG;
			}
			base.transform.position = HMDKPLLDBEA + this.ToolTipOffset;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A186 RID: 41350 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem GBGAGCENJCL()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A187 RID: 41351 RVA: 0x003C7CF0 File Offset: 0x003C5EF0
		public void JMFPBGEFJCI(string EAFAMAMDNEG, Vector3 HMDKPLLDBEA)
		{
			if (this.TooltipText.text != EAFAMAMDNEG)
			{
				this.TooltipText.text = EAFAMAMDNEG;
			}
			base.transform.position = HMDKPLLDBEA + this.ToolTipOffset;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A188 RID: 41352 RVA: 0x003C7D42 File Offset: 0x003C5F42
		private void MMPPGDECEHO()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.OKDGGFNIFCI();
		}

		// Token: 0x0600A189 RID: 41353 RVA: 0x003C7D6C File Offset: 0x003C5F6C
		private void HCCMANDFEPL()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.KANADNDKDEP();
		}

		// Token: 0x0600A18A RID: 41354 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem LCGNLCPJBOH()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x0600A18B RID: 41355 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem Instance
		{
			get
			{
				if (BoundTooltipItem.BFPIJFMDBGF == null)
				{
					BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
				}
				return BoundTooltipItem.BFPIJFMDBGF;
			}
		}

		// Token: 0x0600A18C RID: 41356 RVA: 0x003C7D98 File Offset: 0x003C5F98
		public void ShowTooltip(string EAFAMAMDNEG, Vector3 HMDKPLLDBEA)
		{
			if (this.TooltipText.text != EAFAMAMDNEG)
			{
				this.TooltipText.text = EAFAMAMDNEG;
			}
			base.transform.position = HMDKPLLDBEA + this.ToolTipOffset;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A18D RID: 41357 RVA: 0x003C7DEC File Offset: 0x003C5FEC
		public void HOLDDHICJNB(string EAFAMAMDNEG, Vector3 HMDKPLLDBEA)
		{
			if (this.TooltipText.text != EAFAMAMDNEG)
			{
				this.TooltipText.text = EAFAMAMDNEG;
			}
			base.transform.position = HMDKPLLDBEA + this.ToolTipOffset;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A18E RID: 41358 RVA: 0x003C7E40 File Offset: 0x003C6040
		public void OHPALEJAFGJ(string EAFAMAMDNEG, Vector3 HMDKPLLDBEA)
		{
			if (this.TooltipText.text != EAFAMAMDNEG)
			{
				this.TooltipText.text = EAFAMAMDNEG;
			}
			base.transform.position = HMDKPLLDBEA + this.ToolTipOffset;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A18F RID: 41359 RVA: 0x003C7E92 File Offset: 0x003C6092
		private void NCBGPIKDFIA()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.EFGJCCANFGJ();
		}

		// Token: 0x0600A190 RID: 41360 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem GFIEMBPCNEC()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A191 RID: 41361 RVA: 0x003C7EBC File Offset: 0x003C60BC
		private void JEEINPBLBDI()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.NLMILEAIFHJ();
		}

		// Token: 0x0600A192 RID: 41362 RVA: 0x0022805F File Offset: 0x0022625F
		public void GEGPDAACGAJ()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A193 RID: 41363 RVA: 0x0022805F File Offset: 0x0022625F
		public void GPHFMBNBBII()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A194 RID: 41364 RVA: 0x003C7EE6 File Offset: 0x003C60E6
		private void OKADMJFLMGP()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.JIBALCGAIMI();
		}

		// Token: 0x0600A195 RID: 41365 RVA: 0x0022805F File Offset: 0x0022625F
		public void FPBPLCFKIEI()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A196 RID: 41366 RVA: 0x002288BA File Offset: 0x00226ABA
		public void OKDGGFNIFCI()
		{
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A197 RID: 41367 RVA: 0x003C7F10 File Offset: 0x003C6110
		public void OMEMFKKLFHI(string EAFAMAMDNEG, Vector3 HMDKPLLDBEA)
		{
			if (this.TooltipText.text != EAFAMAMDNEG)
			{
				this.TooltipText.text = EAFAMAMDNEG;
			}
			base.transform.position = HMDKPLLDBEA + this.ToolTipOffset;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A198 RID: 41368 RVA: 0x0022805F File Offset: 0x0022625F
		public void JNOJNPCKAJN()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A199 RID: 41369 RVA: 0x002288BA File Offset: 0x00226ABA
		public void JKOBCPCCAED()
		{
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A19A RID: 41370 RVA: 0x003C7F62 File Offset: 0x003C6162
		private void KPOIJEKDFBE()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.PDEACAADOEG();
		}

		// Token: 0x0600A19B RID: 41371 RVA: 0x002288BA File Offset: 0x00226ABA
		public void MDFMDDCBKCP()
		{
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A19C RID: 41372 RVA: 0x003C7F8C File Offset: 0x003C618C
		public void NNKBKKFLMBH(string EAFAMAMDNEG, Vector3 HMDKPLLDBEA)
		{
			if (this.TooltipText.text != EAFAMAMDNEG)
			{
				this.TooltipText.text = EAFAMAMDNEG;
			}
			base.transform.position = HMDKPLLDBEA + this.ToolTipOffset;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A19D RID: 41373 RVA: 0x002288BA File Offset: 0x00226ABA
		public void EFGJCCANFGJ()
		{
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A19E RID: 41374 RVA: 0x003C7FE0 File Offset: 0x003C61E0
		public void IIGIPEHOKGN(string EAFAMAMDNEG, Vector3 HMDKPLLDBEA)
		{
			if (this.TooltipText.text != EAFAMAMDNEG)
			{
				this.TooltipText.text = EAFAMAMDNEG;
			}
			base.transform.position = HMDKPLLDBEA + this.ToolTipOffset;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A19F RID: 41375 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem KFPGDCHBEBC()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A1A0 RID: 41376 RVA: 0x003C8032 File Offset: 0x003C6232
		private void Awake()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.HideTooltip();
		}

		// Token: 0x0600A1A1 RID: 41377 RVA: 0x003C7C8E File Offset: 0x003C5E8E
		public bool HEPIMCFHMPA()
		{
			return base.gameObject.activeSelf;
		}

		// Token: 0x0600A1A2 RID: 41378 RVA: 0x003C805C File Offset: 0x003C625C
		private void DHNANELONED()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.GEGPDAACGAJ();
		}

		// Token: 0x0600A1A3 RID: 41379 RVA: 0x003C8088 File Offset: 0x003C6288
		public void FKDMEOANCKB(string EAFAMAMDNEG, Vector3 HMDKPLLDBEA)
		{
			if (this.TooltipText.text != EAFAMAMDNEG)
			{
				this.TooltipText.text = EAFAMAMDNEG;
			}
			base.transform.position = HMDKPLLDBEA + this.ToolTipOffset;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A1A4 RID: 41380 RVA: 0x003C80DA File Offset: 0x003C62DA
		private void AEECPBDJPGN()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.DPDAJBLGGBA();
		}

		// Token: 0x0600A1A5 RID: 41381 RVA: 0x003C8104 File Offset: 0x003C6304
		public void LGNHNCGFMEA(string EAFAMAMDNEG, Vector3 HMDKPLLDBEA)
		{
			if (this.TooltipText.text != EAFAMAMDNEG)
			{
				this.TooltipText.text = EAFAMAMDNEG;
			}
			base.transform.position = HMDKPLLDBEA + this.ToolTipOffset;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A1A6 RID: 41382 RVA: 0x003C8156 File Offset: 0x003C6356
		private void GKDDIGEPJEF()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.INDPOCHDOPI();
		}

		// Token: 0x0600A1A7 RID: 41383 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem KMLCFPCJNOB()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A1A8 RID: 41384 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem JHHBLAJMCBF()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A1A9 RID: 41385 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem IOECLKDFPEO()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A1AA RID: 41386 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem HLEODLCMIMK()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A1AB RID: 41387 RVA: 0x003C8180 File Offset: 0x003C6380
		public void FKDJODHFLDI(string EAFAMAMDNEG, Vector3 HMDKPLLDBEA)
		{
			if (this.TooltipText.text != EAFAMAMDNEG)
			{
				this.TooltipText.text = EAFAMAMDNEG;
			}
			base.transform.position = HMDKPLLDBEA + this.ToolTipOffset;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A1AC RID: 41388 RVA: 0x003C81D4 File Offset: 0x003C63D4
		public void OHCOKOPJDBE(string EAFAMAMDNEG, Vector3 HMDKPLLDBEA)
		{
			if (this.TooltipText.text != EAFAMAMDNEG)
			{
				this.TooltipText.text = EAFAMAMDNEG;
			}
			base.transform.position = HMDKPLLDBEA + this.ToolTipOffset;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A1AD RID: 41389 RVA: 0x0022805F File Offset: 0x0022625F
		public void CEHGJFIDHHF()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A1AE RID: 41390 RVA: 0x002288BA File Offset: 0x00226ABA
		public void HPGCALOCMMC()
		{
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A1AF RID: 41391 RVA: 0x003C7C8E File Offset: 0x003C5E8E
		public bool EJGHFDLCNPN()
		{
			return base.gameObject.activeSelf;
		}

		// Token: 0x0600A1B0 RID: 41392 RVA: 0x0022805F File Offset: 0x0022625F
		public void ACACBDFKMOD()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A1B1 RID: 41393 RVA: 0x003C8226 File Offset: 0x003C6426
		private void MFIMFMCMADK()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.JKOBCPCCAED();
		}

		// Token: 0x0600A1B2 RID: 41394 RVA: 0x003C7C8E File Offset: 0x003C5E8E
		public bool PMIHJAMNLLJ()
		{
			return base.gameObject.activeSelf;
		}

		// Token: 0x0600A1B3 RID: 41395 RVA: 0x003C7C8E File Offset: 0x003C5E8E
		public bool NILPLLIIAEI()
		{
			return base.gameObject.activeSelf;
		}

		// Token: 0x0600A1B4 RID: 41396 RVA: 0x003C8250 File Offset: 0x003C6450
		public void KNMJCEICJAP(string EAFAMAMDNEG, Vector3 HMDKPLLDBEA)
		{
			if (this.TooltipText.text != EAFAMAMDNEG)
			{
				this.TooltipText.text = EAFAMAMDNEG;
			}
			base.transform.position = HMDKPLLDBEA + this.ToolTipOffset;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A1B5 RID: 41397 RVA: 0x003C82A2 File Offset: 0x003C64A2
		private void CIAHIJIOFIE()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.MFOKEJNJBLD();
		}

		// Token: 0x0600A1B6 RID: 41398 RVA: 0x003C82CC File Offset: 0x003C64CC
		public void GHECJNBFGJC(string EAFAMAMDNEG, Vector3 HMDKPLLDBEA)
		{
			if (this.TooltipText.text != EAFAMAMDNEG)
			{
				this.TooltipText.text = EAFAMAMDNEG;
			}
			base.transform.position = HMDKPLLDBEA + this.ToolTipOffset;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A1B7 RID: 41399 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem FCFADOHPCPN()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A1B8 RID: 41400 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem DNMHKEAGIJE()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A1B9 RID: 41401 RVA: 0x003C8032 File Offset: 0x003C6232
		private void CCDNJPNLGBN()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.HideTooltip();
		}

		// Token: 0x0600A1BA RID: 41402 RVA: 0x003C7C8E File Offset: 0x003C5E8E
		public bool GKDKHKEHNLP()
		{
			return base.gameObject.activeSelf;
		}

		// Token: 0x0600A1BB RID: 41403 RVA: 0x002288BA File Offset: 0x00226ABA
		public void LEBAJDFOFGN()
		{
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A1BC RID: 41404 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem LEFIEBAACNO()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A1BD RID: 41405 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem BCLHIBPDOPP()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A1BE RID: 41406 RVA: 0x003C8320 File Offset: 0x003C6520
		public void DABNHIBKLID(string EAFAMAMDNEG, Vector3 HMDKPLLDBEA)
		{
			if (this.TooltipText.text != EAFAMAMDNEG)
			{
				this.TooltipText.text = EAFAMAMDNEG;
			}
			base.transform.position = HMDKPLLDBEA + this.ToolTipOffset;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A1BF RID: 41407 RVA: 0x002288BA File Offset: 0x00226ABA
		public void GCGFALOJLAD()
		{
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A1C0 RID: 41408 RVA: 0x003C7C8E File Offset: 0x003C5E8E
		public bool GLPIOBKICEA()
		{
			return base.gameObject.activeSelf;
		}

		// Token: 0x0600A1C1 RID: 41409 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem NEGGLFMNFLE()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A1C2 RID: 41410 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem CNCBAJACOGD()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A1C3 RID: 41411 RVA: 0x002288BA File Offset: 0x00226ABA
		public void PHMGGLHDEGJ()
		{
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A1C4 RID: 41412 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem IBDLENPHGCD()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A1C5 RID: 41413 RVA: 0x003C7C8E File Offset: 0x003C5E8E
		public bool EEJIPNLOLOO()
		{
			return base.gameObject.activeSelf;
		}

		// Token: 0x0600A1C6 RID: 41414 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem HGPHIHLIEPD()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A1C7 RID: 41415 RVA: 0x003C8372 File Offset: 0x003C6572
		private void LHMDCEDONEE()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.ENFLFDIHMJE();
		}

		// Token: 0x0600A1C8 RID: 41416 RVA: 0x002288BA File Offset: 0x00226ABA
		public void INDPOCHDOPI()
		{
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A1C9 RID: 41417 RVA: 0x0022805F File Offset: 0x0022625F
		public void OGBHOHGEBFB()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A1CA RID: 41418 RVA: 0x003C7C8E File Offset: 0x003C5E8E
		public bool OEPCODHDJLF()
		{
			return base.gameObject.activeSelf;
		}

		// Token: 0x0600A1CB RID: 41419 RVA: 0x003C839C File Offset: 0x003C659C
		public void CFFPCBPBOIF(string EAFAMAMDNEG, Vector3 HMDKPLLDBEA)
		{
			if (this.TooltipText.text != EAFAMAMDNEG)
			{
				this.TooltipText.text = EAFAMAMDNEG;
			}
			base.transform.position = HMDKPLLDBEA + this.ToolTipOffset;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A1CC RID: 41420 RVA: 0x003C83F0 File Offset: 0x003C65F0
		public void LPABGLHJACH(string EAFAMAMDNEG, Vector3 HMDKPLLDBEA)
		{
			if (this.TooltipText.text != EAFAMAMDNEG)
			{
				this.TooltipText.text = EAFAMAMDNEG;
			}
			base.transform.position = HMDKPLLDBEA + this.ToolTipOffset;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A1CD RID: 41421 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem FMFOENCDEHG()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A1CE RID: 41422 RVA: 0x003C8442 File Offset: 0x003C6642
		private void OLFNCABJBHA()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.DIJAIIBAIOG();
		}

		// Token: 0x0600A1CF RID: 41423 RVA: 0x003C80DA File Offset: 0x003C62DA
		private void BANHFNDEPPO()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.DPDAJBLGGBA();
		}

		// Token: 0x0600A1D0 RID: 41424 RVA: 0x0022805F File Offset: 0x0022625F
		public void DMDHNJPDJJK()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A1D1 RID: 41425 RVA: 0x003C7C8E File Offset: 0x003C5E8E
		public bool JFDFFADGJDA()
		{
			return base.gameObject.activeSelf;
		}

		// Token: 0x0600A1D2 RID: 41426 RVA: 0x003C7C8E File Offset: 0x003C5E8E
		public bool HAGKAEMNCEE()
		{
			return base.gameObject.activeSelf;
		}

		// Token: 0x0600A1D3 RID: 41427 RVA: 0x002288BA File Offset: 0x00226ABA
		public void MFOKEJNJBLD()
		{
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A1D4 RID: 41428 RVA: 0x003C846C File Offset: 0x003C666C
		public void HPPPLMEICHH(string EAFAMAMDNEG, Vector3 HMDKPLLDBEA)
		{
			if (this.TooltipText.text != EAFAMAMDNEG)
			{
				this.TooltipText.text = EAFAMAMDNEG;
			}
			base.transform.position = HMDKPLLDBEA + this.ToolTipOffset;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A1D5 RID: 41429 RVA: 0x003C7E92 File Offset: 0x003C6092
		private void MLPCIDDEIDC()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.EFGJCCANFGJ();
		}

		// Token: 0x0600A1D6 RID: 41430 RVA: 0x0022805F File Offset: 0x0022625F
		public void ENFLFDIHMJE()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A1D7 RID: 41431 RVA: 0x0022805F File Offset: 0x0022625F
		public void HideTooltip()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A1D8 RID: 41432 RVA: 0x003C8226 File Offset: 0x003C6426
		private void HKDMCBDOGDK()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.JKOBCPCCAED();
		}

		// Token: 0x0600A1D9 RID: 41433 RVA: 0x0022805F File Offset: 0x0022625F
		public void FOLICHAJPDJ()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A1DA RID: 41434 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem NGDEDGAAFNA()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A1DB RID: 41435 RVA: 0x003C7C8E File Offset: 0x003C5E8E
		public bool CAGIHEMOBHF()
		{
			return base.gameObject.activeSelf;
		}

		// Token: 0x0600A1DC RID: 41436 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem LECLHHENMIA()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A1DD RID: 41437 RVA: 0x003C84BE File Offset: 0x003C66BE
		private void EMKLCPGKNJL()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.HPGCALOCMMC();
		}

		// Token: 0x17000214 RID: 532
		// (get) Token: 0x0600A1DE RID: 41438 RVA: 0x003C7C8E File Offset: 0x003C5E8E
		public bool IsActive
		{
			get
			{
				return base.gameObject.activeSelf;
			}
		}

		// Token: 0x0600A1DF RID: 41439 RVA: 0x003C8226 File Offset: 0x003C6426
		private void PMBIKIBOHOF()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.JKOBCPCCAED();
		}

		// Token: 0x0600A1E0 RID: 41440 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem DBOGJHLNIDD()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A1E1 RID: 41441 RVA: 0x0022805F File Offset: 0x0022625F
		public void NLMILEAIFHJ()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A1E2 RID: 41442 RVA: 0x003C84E8 File Offset: 0x003C66E8
		private void OBAIHNFOJGN()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.OGBHOHGEBFB();
		}

		// Token: 0x0600A1E3 RID: 41443 RVA: 0x0022805F File Offset: 0x0022625F
		public void PDEACAADOEG()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A1E4 RID: 41444 RVA: 0x003C8512 File Offset: 0x003C6712
		private void ELJPNLNELIE()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.PHMGGLHDEGJ();
		}

		// Token: 0x0600A1E5 RID: 41445 RVA: 0x0022805F File Offset: 0x0022625F
		public void DPDAJBLGGBA()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A1E6 RID: 41446 RVA: 0x003C853C File Offset: 0x003C673C
		public void OOFBGIBHPKO(string EAFAMAMDNEG, Vector3 HMDKPLLDBEA)
		{
			if (this.TooltipText.text != EAFAMAMDNEG)
			{
				this.TooltipText.text = EAFAMAMDNEG;
			}
			base.transform.position = HMDKPLLDBEA + this.ToolTipOffset;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A1E7 RID: 41447 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem HMADOEFFOEM()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A1E8 RID: 41448 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem CDOFMOAFKEM()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A1E9 RID: 41449 RVA: 0x003C7C8E File Offset: 0x003C5E8E
		public bool FDJEIBPCPHM()
		{
			return base.gameObject.activeSelf;
		}

		// Token: 0x0600A1EA RID: 41450 RVA: 0x003C8590 File Offset: 0x003C6790
		public void JACHFOPPJLD(string EAFAMAMDNEG, Vector3 HMDKPLLDBEA)
		{
			if (this.TooltipText.text != EAFAMAMDNEG)
			{
				this.TooltipText.text = EAFAMAMDNEG;
			}
			base.transform.position = HMDKPLLDBEA + this.ToolTipOffset;
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A1EB RID: 41451 RVA: 0x003C85E2 File Offset: 0x003C67E2
		private void JIJPHEDDIHC()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.LEBAJDFOFGN();
		}

		// Token: 0x0600A1EC RID: 41452 RVA: 0x003C860C File Offset: 0x003C680C
		private void IIPMEPPIFCK()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.MDFMDDCBKCP();
		}

		// Token: 0x0600A1ED RID: 41453 RVA: 0x003C7C8E File Offset: 0x003C5E8E
		public bool CIGEIOCJGGF()
		{
			return base.gameObject.activeSelf;
		}

		// Token: 0x0600A1EE RID: 41454 RVA: 0x003C8512 File Offset: 0x003C6712
		private void AALONHDMCKO()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.PHMGGLHDEGJ();
		}

		// Token: 0x0600A1EF RID: 41455 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem AIPCJFEOLJG()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A1F0 RID: 41456 RVA: 0x003C8636 File Offset: 0x003C6836
		private void NEEIFNDHDOG()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.CEHGJFIDHHF();
		}

		// Token: 0x0600A1F1 RID: 41457 RVA: 0x003C7C8E File Offset: 0x003C5E8E
		public bool BCDLAHINNGA()
		{
			return base.gameObject.activeSelf;
		}

		// Token: 0x0600A1F2 RID: 41458 RVA: 0x002288BA File Offset: 0x00226ABA
		public void KANADNDKDEP()
		{
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A1F3 RID: 41459 RVA: 0x002288BA File Offset: 0x00226ABA
		public void JIBALCGAIMI()
		{
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A1F4 RID: 41460 RVA: 0x003C7C8E File Offset: 0x003C5E8E
		public bool KFJHJMFBGHG()
		{
			return base.gameObject.activeSelf;
		}

		// Token: 0x0600A1F5 RID: 41461 RVA: 0x003C8660 File Offset: 0x003C6860
		public void LKKIIHKFOPA(string EAFAMAMDNEG, Vector3 HMDKPLLDBEA)
		{
			if (this.TooltipText.text != EAFAMAMDNEG)
			{
				this.TooltipText.text = EAFAMAMDNEG;
			}
			base.transform.position = HMDKPLLDBEA + this.ToolTipOffset;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0600A1F6 RID: 41462 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem AOPOIJGMBDI()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A1F7 RID: 41463 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem KIOBEHGBMCL()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A1F8 RID: 41464 RVA: 0x003C7C8E File Offset: 0x003C5E8E
		public bool ONPKKMGDHNO()
		{
			return base.gameObject.activeSelf;
		}

		// Token: 0x0600A1F9 RID: 41465 RVA: 0x003C7D42 File Offset: 0x003C5F42
		private void JOBBGDGHJMB()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.OKDGGFNIFCI();
		}

		// Token: 0x0600A1FA RID: 41466 RVA: 0x003C7C18 File Offset: 0x003C5E18
		public static BoundTooltipItem BMLJJAMJPMO()
		{
			if (BoundTooltipItem.BFPIJFMDBGF == null)
			{
				BoundTooltipItem.BFPIJFMDBGF = Object.FindObjectOfType<BoundTooltipItem>();
			}
			return BoundTooltipItem.BFPIJFMDBGF;
		}

		// Token: 0x0600A1FB RID: 41467 RVA: 0x003C7F62 File Offset: 0x003C6162
		private void NKNPEAOFHFM()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.PDEACAADOEG();
		}

		// Token: 0x0600A1FC RID: 41468 RVA: 0x003C8156 File Offset: 0x003C6356
		private void PGGNGAMLGAJ()
		{
			BoundTooltipItem.BFPIJFMDBGF = this;
			if (!this.TooltipText)
			{
				this.TooltipText = base.GetComponentInChildren<Text>();
			}
			this.INDPOCHDOPI();
		}

		// Token: 0x0600A1FD RID: 41469 RVA: 0x0022805F File Offset: 0x0022625F
		public void KHGKEIPIDBH()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A1FE RID: 41470 RVA: 0x0022805F File Offset: 0x0022625F
		public void DIJAIIBAIOG()
		{
			base.gameObject.SetActive(false);
		}

		// Token: 0x0600A1FF RID: 41471 RVA: 0x003C86B4 File Offset: 0x003C68B4
		public void EMMAJAPFEAN(string EAFAMAMDNEG, Vector3 HMDKPLLDBEA)
		{
			if (this.TooltipText.text != EAFAMAMDNEG)
			{
				this.TooltipText.text = EAFAMAMDNEG;
			}
			base.transform.position = HMDKPLLDBEA + this.ToolTipOffset;
			base.gameObject.SetActive(true);
		}

		// Token: 0x0400125C RID: 4700
		public Text TooltipText;

		// Token: 0x0400125D RID: 4701
		public Vector3 ToolTipOffset;

		// Token: 0x0400125E RID: 4702
		private static BoundTooltipItem BFPIJFMDBGF;
	}
}
