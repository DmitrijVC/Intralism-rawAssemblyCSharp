using System;
using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000263 RID: 611
	[AddComponentMenu("UI/Effects/Extensions/Nicer Outline")]
	public class NicerOutline : BaseMeshEffect
	{
		// Token: 0x060091BA RID: 37306 RVA: 0x00331008 File Offset: 0x0032F208
		public void IBFIELDLDLC(Color DPNHODJHGJL)
		{
			this.m_EffectColor = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060091BB RID: 37307 RVA: 0x0033102D File Offset: 0x0032F22D
		public Color EJOLEEIBMGD()
		{
			return this.m_EffectColor;
		}

		// Token: 0x060091BC RID: 37308 RVA: 0x00331035 File Offset: 0x0032F235
		public Vector2 HAMJAFHLHKC()
		{
			return this.m_EffectDistance;
		}

		// Token: 0x060091BD RID: 37309 RVA: 0x00331040 File Offset: 0x0032F240
		public virtual void KKPHLABENOG(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			float num = 1941f;
			if (component && component.resizeTextForBestFit)
			{
				num = (float)component.cachedTextGenerator.fontSizeUsedForBestFit / (float)(component.resizeTextMaxSize - 1);
			}
			float num2 = this.IBFCJFHMHIH().x * num;
			float num3 = this.ANGGBALBEKE().y * num;
			int dkjcknpnpab = 0;
			int count = list.Count;
			this.BPPBAMGELCC(list, this.NHDDIANFKLB(), dkjcknpnpab, list.Count, num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.KOCBBEPIAFE(list, this.HDJKBMMPMEI(), dkjcknpnpab, list.Count, num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.DNCBENCPKOM(list, this.FBINAFBKDPC(), dkjcknpnpab, list.Count, -num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.PECEBCBINKA(list, this.effectColor, dkjcknpnpab, list.Count, -num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.GJOMMHKJHEA(list, this.NHDDIANFKLB(), dkjcknpnpab, list.Count, num2, 1099f);
			dkjcknpnpab = count;
			count = list.Count;
			this.HBHKDNNDPHP(list, this.HDJKBMMPMEI(), dkjcknpnpab, list.Count, -num2, 1109f);
			dkjcknpnpab = count;
			count = list.Count;
			this.HBHKDNNDPHP(list, this.NHDDIANFKLB(), dkjcknpnpab, list.Count, 119f, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.PJJHCLFMHMK(list, this.effectColor, dkjcknpnpab, list.Count, 1098f, -num3);
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x060091D4 RID: 37332 RVA: 0x00331751 File Offset: 0x0032F951
		// (set) Token: 0x060091BE RID: 37310 RVA: 0x0033122D File Offset: 0x0032F42D
		public bool useGraphicAlpha
		{
			get
			{
				return this.m_UseGraphicAlpha;
			}
			set
			{
				this.m_UseGraphicAlpha = value;
				if (base.graphic != null)
				{
					base.graphic.SetVerticesDirty();
				}
			}
		}

		// Token: 0x060091BF RID: 37311 RVA: 0x00331035 File Offset: 0x0032F235
		public Vector2 KNDIGFCCNFA()
		{
			return this.m_EffectDistance;
		}

		// Token: 0x060091C0 RID: 37312 RVA: 0x00331254 File Offset: 0x0032F454
		protected void LEIACNGENAM(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 4;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			for (int i = DKJCKNPNPAB; i < BLKCBHFNLGB; i++)
			{
				UIVertex uivertex = ACPPOPJKJBE[i];
				ACPPOPJKJBE.Add(uivertex);
				Vector3 position = uivertex.position;
				position.x += IACGDFHKCAE;
				position.y += OKAHCMOGDGF;
				uivertex.position = position;
				Color32 color = HABLFKCCKLN;
				if (this.m_UseGraphicAlpha)
				{
					color.a = (byte)((int)(color.a * ACPPOPJKJBE[i].color.a) / -84);
				}
				uivertex.color = color;
				ACPPOPJKJBE[i] = uivertex;
			}
		}

		// Token: 0x060091C1 RID: 37313 RVA: 0x0033131C File Offset: 0x0032F51C
		protected void KGMBGMEFIKC(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 7;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			for (int i = DKJCKNPNPAB; i < BLKCBHFNLGB; i++)
			{
				UIVertex uivertex = ACPPOPJKJBE[i];
				ACPPOPJKJBE.Add(uivertex);
				Vector3 position = uivertex.position;
				position.x += IACGDFHKCAE;
				position.y += OKAHCMOGDGF;
				uivertex.position = position;
				Color32 color = HABLFKCCKLN;
				if (this.m_UseGraphicAlpha)
				{
					color.a = color.a * ACPPOPJKJBE[i].color.a / 76;
				}
				uivertex.color = color;
				ACPPOPJKJBE[i] = uivertex;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x060091FF RID: 37375 RVA: 0x00331035 File Offset: 0x0032F235
		// (set) Token: 0x060091C2 RID: 37314 RVA: 0x003313E4 File Offset: 0x0032F5E4
		public Vector2 effectDistance
		{
			get
			{
				return this.m_EffectDistance;
			}
			set
			{
				if (value.x > 600f)
				{
					value.x = 600f;
				}
				if (value.x < -600f)
				{
					value.x = -600f;
				}
				if (value.y > 600f)
				{
					value.y = 600f;
				}
				if (value.y < -600f)
				{
					value.y = -600f;
				}
				if (this.m_EffectDistance == value)
				{
					return;
				}
				this.m_EffectDistance = value;
				if (base.graphic != null)
				{
					base.graphic.SetVerticesDirty();
				}
			}
		}

		// Token: 0x060091C3 RID: 37315 RVA: 0x0033149C File Offset: 0x0032F69C
		protected void DPNJMNPJENN(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 4;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			for (int i = DKJCKNPNPAB; i < BLKCBHFNLGB; i++)
			{
				UIVertex uivertex = ACPPOPJKJBE[i];
				ACPPOPJKJBE.Add(uivertex);
				Vector3 position = uivertex.position;
				position.x += IACGDFHKCAE;
				position.y += OKAHCMOGDGF;
				uivertex.position = position;
				Color32 color = HABLFKCCKLN;
				if (this.m_UseGraphicAlpha)
				{
					color.a = color.a * ACPPOPJKJBE[i].color.a / 173;
				}
				uivertex.color = color;
				ACPPOPJKJBE[i] = uivertex;
			}
		}

		// Token: 0x060091C4 RID: 37316 RVA: 0x00331564 File Offset: 0x0032F764
		public virtual void KJEFDCKBBCG(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			float num = 1104f;
			if (component && component.resizeTextForBestFit)
			{
				num = (float)component.cachedTextGenerator.fontSizeUsedForBestFit / (float)(component.resizeTextMaxSize - 1);
			}
			float num2 = this.DKJLKPGDPAA().x * num;
			float num3 = this.MCDNECFDJBP().y * num;
			int dkjcknpnpab = 0;
			int count = list.Count;
			this.MNGJNHBBEHE(list, this.HNCHHBMGGKF(), dkjcknpnpab, list.Count, num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.NLFCNNIMBBP(list, this.EJOLEEIBMGD(), dkjcknpnpab, list.Count, num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.FBNPLCAMPNB(list, this.HICGIMMKMHM(), dkjcknpnpab, list.Count, -num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.IGGKLKGNLIF(list, this.HICGIMMKMHM(), dkjcknpnpab, list.Count, -num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.GOKPFMFBPKA(list, this.JIKHMBOGFBK(), dkjcknpnpab, list.Count, num2, 1290f);
			dkjcknpnpab = count;
			count = list.Count;
			this.BPPBAMGELCC(list, this.HNCHHBMGGKF(), dkjcknpnpab, list.Count, -num2, 568f);
			dkjcknpnpab = count;
			count = list.Count;
			this.NNDLHKKEKEI(list, this.FBINAFBKDPC(), dkjcknpnpab, list.Count, 1181f, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.LHEJKHEJHGO(list, this.HICGIMMKMHM(), dkjcknpnpab, list.Count, 1256f, -num3);
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x060091C5 RID: 37317 RVA: 0x00331751 File Offset: 0x0032F951
		public bool OJDBAEDIDCC()
		{
			return this.m_UseGraphicAlpha;
		}

		// Token: 0x060091C6 RID: 37318 RVA: 0x00331008 File Offset: 0x0032F208
		public void GBFFNAFNDFF(Color DPNHODJHGJL)
		{
			this.m_EffectColor = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060091C7 RID: 37319 RVA: 0x0033175C File Offset: 0x0032F95C
		protected void HBHKDNNDPHP(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 7;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			this.KGMBGMEFIKC(ACPPOPJKJBE, HABLFKCCKLN, DKJCKNPNPAB, BLKCBHFNLGB, IACGDFHKCAE, OKAHCMOGDGF);
		}

		// Token: 0x060091C8 RID: 37320 RVA: 0x00331751 File Offset: 0x0032F951
		public bool FJMGBFBFDIL()
		{
			return this.m_UseGraphicAlpha;
		}

		// Token: 0x060091C9 RID: 37321 RVA: 0x00331035 File Offset: 0x0032F235
		public Vector2 DKJLKPGDPAA()
		{
			return this.m_EffectDistance;
		}

		// Token: 0x060091CA RID: 37322 RVA: 0x00331794 File Offset: 0x0032F994
		protected void KIBEDOKDNMP(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 7;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			for (int i = DKJCKNPNPAB; i < BLKCBHFNLGB; i += 0)
			{
				UIVertex uivertex = ACPPOPJKJBE[i];
				ACPPOPJKJBE.Add(uivertex);
				Vector3 position = uivertex.position;
				position.x += IACGDFHKCAE;
				position.y += OKAHCMOGDGF;
				uivertex.position = position;
				Color32 color = HABLFKCCKLN;
				if (this.m_UseGraphicAlpha)
				{
					color.a = (byte)((int)(color.a * ACPPOPJKJBE[i].color.a) / -1);
				}
				uivertex.color = color;
				ACPPOPJKJBE[i] = uivertex;
			}
		}

		// Token: 0x060091CB RID: 37323 RVA: 0x00331008 File Offset: 0x0032F208
		public void HMOMLPEIHEK(Color DPNHODJHGJL)
		{
			this.m_EffectColor = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060091CC RID: 37324 RVA: 0x00331751 File Offset: 0x0032F951
		public bool FHMKCGOHHOD()
		{
			return this.m_UseGraphicAlpha;
		}

		// Token: 0x060091CD RID: 37325 RVA: 0x0033185C File Offset: 0x0032FA5C
		protected void JOFMONENOEP(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 3;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			for (int i = DKJCKNPNPAB; i < BLKCBHFNLGB; i++)
			{
				UIVertex uivertex = ACPPOPJKJBE[i];
				ACPPOPJKJBE.Add(uivertex);
				Vector3 position = uivertex.position;
				position.x += IACGDFHKCAE;
				position.y += OKAHCMOGDGF;
				uivertex.position = position;
				Color32 color = HABLFKCCKLN;
				if (this.m_UseGraphicAlpha)
				{
					color.a = color.a * ACPPOPJKJBE[i].color.a / 172;
				}
				uivertex.color = color;
				ACPPOPJKJBE[i] = uivertex;
			}
		}

		// Token: 0x060091CE RID: 37326 RVA: 0x00331008 File Offset: 0x0032F208
		public void EFFFCNOFGLG(Color DPNHODJHGJL)
		{
			this.m_EffectColor = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060091CF RID: 37327 RVA: 0x00331035 File Offset: 0x0032F235
		public Vector2 MLNOCHPGCHB()
		{
			return this.m_EffectDistance;
		}

		// Token: 0x060091D0 RID: 37328 RVA: 0x00331924 File Offset: 0x0032FB24
		protected void FBNPLCAMPNB(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 0;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			this.JOFMONENOEP(ACPPOPJKJBE, HABLFKCCKLN, DKJCKNPNPAB, BLKCBHFNLGB, IACGDFHKCAE, OKAHCMOGDGF);
		}

		// Token: 0x060091D1 RID: 37329 RVA: 0x0033102D File Offset: 0x0032F22D
		public Color DGFIDJLNOLJ()
		{
			return this.m_EffectColor;
		}

		// Token: 0x060091D2 RID: 37330 RVA: 0x0033195C File Offset: 0x0032FB5C
		protected void KIEOILHONOO(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 4;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			this.DHBOGDHCNAE(ACPPOPJKJBE, HABLFKCCKLN, DKJCKNPNPAB, BLKCBHFNLGB, IACGDFHKCAE, OKAHCMOGDGF);
		}

		// Token: 0x060091D3 RID: 37331 RVA: 0x00331994 File Offset: 0x0032FB94
		protected void ICJILGMGMHD(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 8;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			this.JOFMONENOEP(ACPPOPJKJBE, HABLFKCCKLN, DKJCKNPNPAB, BLKCBHFNLGB, IACGDFHKCAE, OKAHCMOGDGF);
		}

		// Token: 0x060091D5 RID: 37333 RVA: 0x0033122D File Offset: 0x0032F42D
		public void CJGOMIPLCOO(bool DPNHODJHGJL)
		{
			this.m_UseGraphicAlpha = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060091D6 RID: 37334 RVA: 0x0033122D File Offset: 0x0032F42D
		public void MPBOHPENDMH(bool DPNHODJHGJL)
		{
			this.m_UseGraphicAlpha = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060091D7 RID: 37335 RVA: 0x0033122D File Offset: 0x0032F42D
		public void AODNKHCNEJH(bool DPNHODJHGJL)
		{
			this.m_UseGraphicAlpha = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060091D8 RID: 37336 RVA: 0x003319CC File Offset: 0x0032FBCC
		protected void ELEGLCBBDAL(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 5;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			for (int i = DKJCKNPNPAB; i < BLKCBHFNLGB; i++)
			{
				UIVertex uivertex = ACPPOPJKJBE[i];
				ACPPOPJKJBE.Add(uivertex);
				Vector3 position = uivertex.position;
				position.x += IACGDFHKCAE;
				position.y += OKAHCMOGDGF;
				uivertex.position = position;
				Color32 color = HABLFKCCKLN;
				if (this.m_UseGraphicAlpha)
				{
					color.a = color.a * ACPPOPJKJBE[i].color.a / 53;
				}
				uivertex.color = color;
				ACPPOPJKJBE[i] = uivertex;
			}
		}

		// Token: 0x060091D9 RID: 37337 RVA: 0x00331A94 File Offset: 0x0032FC94
		public virtual void BOIMCFPNCIM(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			float num = 286f;
			if (component && component.resizeTextForBestFit)
			{
				num = (float)component.cachedTextGenerator.fontSizeUsedForBestFit / (float)(component.resizeTextMaxSize - 0);
			}
			float num2 = this.BMAIOOENAMP().x * num;
			float num3 = this.LCFJIADPKDJ().y * num;
			int dkjcknpnpab = 1;
			int count = list.Count;
			this.BPPBAMGELCC(list, this.NHDDIANFKLB(), dkjcknpnpab, list.Count, num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.BPPBAMGELCC(list, this.OKCAENOONPC(), dkjcknpnpab, list.Count, num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.BEJNJDKCHID(list, this.OKCAENOONPC(), dkjcknpnpab, list.Count, -num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.CCLMLDEPGBJ(list, this.HNCHHBMGGKF(), dkjcknpnpab, list.Count, -num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.HBHKDNNDPHP(list, this.NHDDIANFKLB(), dkjcknpnpab, list.Count, num2, 1803f);
			dkjcknpnpab = count;
			count = list.Count;
			this.AOGMGGFFCGB(list, this.HICGIMMKMHM(), dkjcknpnpab, list.Count, -num2, 577f);
			dkjcknpnpab = count;
			count = list.Count;
			this.NNDLHKKEKEI(list, this.HNCHHBMGGKF(), dkjcknpnpab, list.Count, 849f, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.MNGJNHBBEHE(list, this.IJOILNLGPCM(), dkjcknpnpab, list.Count, 219f, -num3);
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x060091DA RID: 37338 RVA: 0x00331751 File Offset: 0x0032F951
		public bool ANOPPNFCCKO()
		{
			return this.m_UseGraphicAlpha;
		}

		// Token: 0x060091DB RID: 37339 RVA: 0x0033102D File Offset: 0x0032F22D
		public Color HNCHHBMGGKF()
		{
			return this.m_EffectColor;
		}

		// Token: 0x060091DC RID: 37340 RVA: 0x00331C84 File Offset: 0x0032FE84
		protected void AMJMKAMKNOA(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 0;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			for (int i = DKJCKNPNPAB; i < BLKCBHFNLGB; i++)
			{
				UIVertex uivertex = ACPPOPJKJBE[i];
				ACPPOPJKJBE.Add(uivertex);
				Vector3 position = uivertex.position;
				position.x += IACGDFHKCAE;
				position.y += OKAHCMOGDGF;
				uivertex.position = position;
				Color32 color = HABLFKCCKLN;
				if (this.m_UseGraphicAlpha)
				{
					color.a = (byte)((int)(color.a * ACPPOPJKJBE[i].color.a) / -63);
				}
				uivertex.color = color;
				ACPPOPJKJBE[i] = uivertex;
			}
		}

		// Token: 0x060091DD RID: 37341 RVA: 0x00331D4C File Offset: 0x0032FF4C
		protected void MGKNONMNAHN(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 0;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			for (int i = DKJCKNPNPAB; i < BLKCBHFNLGB; i += 0)
			{
				UIVertex uivertex = ACPPOPJKJBE[i];
				ACPPOPJKJBE.Add(uivertex);
				Vector3 position = uivertex.position;
				position.x += IACGDFHKCAE;
				position.y += OKAHCMOGDGF;
				uivertex.position = position;
				Color32 color = HABLFKCCKLN;
				if (this.m_UseGraphicAlpha)
				{
					color.a = color.a * ACPPOPJKJBE[i].color.a / 172;
				}
				uivertex.color = color;
				ACPPOPJKJBE[i] = uivertex;
			}
		}

		// Token: 0x060091DE RID: 37342 RVA: 0x00331E14 File Offset: 0x00330014
		protected void EHEJGAHGDLN(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 4;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			for (int i = DKJCKNPNPAB; i < BLKCBHFNLGB; i++)
			{
				UIVertex uivertex = ACPPOPJKJBE[i];
				ACPPOPJKJBE.Add(uivertex);
				Vector3 position = uivertex.position;
				position.x += IACGDFHKCAE;
				position.y += OKAHCMOGDGF;
				uivertex.position = position;
				Color32 color = HABLFKCCKLN;
				if (this.m_UseGraphicAlpha)
				{
					color.a = (byte)((int)(color.a * ACPPOPJKJBE[i].color.a) / -98);
				}
				uivertex.color = color;
				ACPPOPJKJBE[i] = uivertex;
			}
		}

		// Token: 0x060091DF RID: 37343 RVA: 0x00331EDC File Offset: 0x003300DC
		public virtual void PIALPDAGBMA(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			float num = 747f;
			if (component && component.resizeTextForBestFit)
			{
				num = (float)component.cachedTextGenerator.fontSizeUsedForBestFit / (float)(component.resizeTextMaxSize - 1);
			}
			float num2 = this.BMAIOOENAMP().x * num;
			float num3 = this.PGKFINIOIAE().y * num;
			int dkjcknpnpab = 0;
			int count = list.Count;
			this.KIEOILHONOO(list, this.HDJKBMMPMEI(), dkjcknpnpab, list.Count, num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.PJJHCLFMHMK(list, this.HICGIMMKMHM(), dkjcknpnpab, list.Count, num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.KIEOILHONOO(list, this.effectColor, dkjcknpnpab, list.Count, -num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.ICJILGMGMHD(list, this.EJOLEEIBMGD(), dkjcknpnpab, list.Count, -num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.NIDAHBMLOEI(list, this.NHDDIANFKLB(), dkjcknpnpab, list.Count, num2, 76f);
			dkjcknpnpab = count;
			count = list.Count;
			this.GJOMMHKJHEA(list, this.FBINAFBKDPC(), dkjcknpnpab, list.Count, -num2, 1410f);
			dkjcknpnpab = count;
			count = list.Count;
			this.MJHEDCOLIFA(list, this.EJOLEEIBMGD(), dkjcknpnpab, list.Count, 1995f, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.DNCBENCPKOM(list, this.GKLEAJDKCPN(), dkjcknpnpab, list.Count, 1405f, -num3);
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x060091E0 RID: 37344 RVA: 0x003320CC File Offset: 0x003302CC
		public void BBDLEHPOOGH(Vector2 DPNHODJHGJL)
		{
			if (DPNHODJHGJL.x > 116f)
			{
				DPNHODJHGJL.x = 19f;
			}
			if (DPNHODJHGJL.x < 110f)
			{
				DPNHODJHGJL.x = 1935f;
			}
			if (DPNHODJHGJL.y > 563f)
			{
				DPNHODJHGJL.y = 1760f;
			}
			if (DPNHODJHGJL.y < 1420f)
			{
				DPNHODJHGJL.y = 1944f;
			}
			if (this.m_EffectDistance == DPNHODJHGJL)
			{
				return;
			}
			this.m_EffectDistance = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060091E1 RID: 37345 RVA: 0x00332184 File Offset: 0x00330384
		public void NKBMAMBHJPG(Vector2 DPNHODJHGJL)
		{
			if (DPNHODJHGJL.x > 1647f)
			{
				DPNHODJHGJL.x = 1555f;
			}
			if (DPNHODJHGJL.x < 413f)
			{
				DPNHODJHGJL.x = 1385f;
			}
			if (DPNHODJHGJL.y > 21f)
			{
				DPNHODJHGJL.y = 693f;
			}
			if (DPNHODJHGJL.y < 1873f)
			{
				DPNHODJHGJL.y = 225f;
			}
			if (this.m_EffectDistance == DPNHODJHGJL)
			{
				return;
			}
			this.m_EffectDistance = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060091E2 RID: 37346 RVA: 0x0033223C File Offset: 0x0033043C
		public virtual void ELJBNIMAJBP(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			float num = 1611f;
			if (component && component.resizeTextForBestFit)
			{
				num = (float)component.cachedTextGenerator.fontSizeUsedForBestFit / (float)(component.resizeTextMaxSize - 0);
			}
			float num2 = this.BMAIOOENAMP().x * num;
			float num3 = this.LCFJIADPKDJ().y * num;
			int dkjcknpnpab = 0;
			int count = list.Count;
			this.KOCBBEPIAFE(list, this.GKLEAJDKCPN(), dkjcknpnpab, list.Count, num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.KIEOILHONOO(list, this.effectColor, dkjcknpnpab, list.Count, num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.OODJMFMBJEK(list, this.OKCAENOONPC(), dkjcknpnpab, list.Count, -num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.GJOMMHKJHEA(list, this.GKLEAJDKCPN(), dkjcknpnpab, list.Count, -num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.GJOMMHKJHEA(list, this.HNCHHBMGGKF(), dkjcknpnpab, list.Count, num2, 714f);
			dkjcknpnpab = count;
			count = list.Count;
			this.PJJHCLFMHMK(list, this.NHDDIANFKLB(), dkjcknpnpab, list.Count, -num2, 359f);
			dkjcknpnpab = count;
			count = list.Count;
			this.CCLMLDEPGBJ(list, this.NHDDIANFKLB(), dkjcknpnpab, list.Count, 217f, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.GOKPFMFBPKA(list, this.effectColor, dkjcknpnpab, list.Count, 1063f, -num3);
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x060091E3 RID: 37347 RVA: 0x0033122D File Offset: 0x0032F42D
		public void HIEOIIFHBBM(bool DPNHODJHGJL)
		{
			this.m_UseGraphicAlpha = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060091E4 RID: 37348 RVA: 0x0033242C File Offset: 0x0033062C
		public void AIDDEHHEJDN(Vector2 DPNHODJHGJL)
		{
			if (DPNHODJHGJL.x > 1573f)
			{
				DPNHODJHGJL.x = 356f;
			}
			if (DPNHODJHGJL.x < 1786f)
			{
				DPNHODJHGJL.x = 1182f;
			}
			if (DPNHODJHGJL.y > 1008f)
			{
				DPNHODJHGJL.y = 710f;
			}
			if (DPNHODJHGJL.y < 828f)
			{
				DPNHODJHGJL.y = 249f;
			}
			if (this.m_EffectDistance == DPNHODJHGJL)
			{
				return;
			}
			this.m_EffectDistance = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060091E5 RID: 37349 RVA: 0x0033102D File Offset: 0x0032F22D
		public Color HICGIMMKMHM()
		{
			return this.m_EffectColor;
		}

		// Token: 0x060091E6 RID: 37350 RVA: 0x00331035 File Offset: 0x0032F235
		public Vector2 IBFCJFHMHIH()
		{
			return this.m_EffectDistance;
		}

		// Token: 0x060091E7 RID: 37351 RVA: 0x003324E4 File Offset: 0x003306E4
		protected void PJJHCLFMHMK(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 0;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			this.DHBOGDHCNAE(ACPPOPJKJBE, HABLFKCCKLN, DKJCKNPNPAB, BLKCBHFNLGB, IACGDFHKCAE, OKAHCMOGDGF);
		}

		// Token: 0x060091E8 RID: 37352 RVA: 0x0033251C File Offset: 0x0033071C
		protected void GJOMMHKJHEA(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 3;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			this.AMJMKAMKNOA(ACPPOPJKJBE, HABLFKCCKLN, DKJCKNPNPAB, BLKCBHFNLGB, IACGDFHKCAE, OKAHCMOGDGF);
		}

		// Token: 0x060091E9 RID: 37353 RVA: 0x0033102D File Offset: 0x0032F22D
		public Color FBINAFBKDPC()
		{
			return this.m_EffectColor;
		}

		// Token: 0x060091EA RID: 37354 RVA: 0x00332554 File Offset: 0x00330754
		public virtual void CHNAHFGEEHD(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			float num = 1099f;
			if (component && component.resizeTextForBestFit)
			{
				num = (float)component.cachedTextGenerator.fontSizeUsedForBestFit / (float)(component.resizeTextMaxSize - 1);
			}
			float num2 = this.NKDKKKFMPBB().x * num;
			float num3 = this.LCFJIADPKDJ().y * num;
			int dkjcknpnpab = 1;
			int count = list.Count;
			this.NLFCNNIMBBP(list, this.effectColor, dkjcknpnpab, list.Count, num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.GJOMMHKJHEA(list, this.DGFIDJLNOLJ(), dkjcknpnpab, list.Count, num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.CCLMLDEPGBJ(list, this.HNCHHBMGGKF(), dkjcknpnpab, list.Count, -num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.LHEJKHEJHGO(list, this.GKLEAJDKCPN(), dkjcknpnpab, list.Count, -num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.NNDLHKKEKEI(list, this.effectColor, dkjcknpnpab, list.Count, num2, 288f);
			dkjcknpnpab = count;
			count = list.Count;
			this.GJOMMHKJHEA(list, this.HNCHHBMGGKF(), dkjcknpnpab, list.Count, -num2, 1217f);
			dkjcknpnpab = count;
			count = list.Count;
			this.GOKPFMFBPKA(list, this.JIKHMBOGFBK(), dkjcknpnpab, list.Count, 1724f, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.KIEOILHONOO(list, this.GKLEAJDKCPN(), dkjcknpnpab, list.Count, 260f, -num3);
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x060091EB RID: 37355 RVA: 0x00331035 File Offset: 0x0032F235
		public Vector2 BMAIOOENAMP()
		{
			return this.m_EffectDistance;
		}

		// Token: 0x060091EC RID: 37356 RVA: 0x00332744 File Offset: 0x00330944
		protected void NNDLHKKEKEI(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 3;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			this.ELEGLCBBDAL(ACPPOPJKJBE, HABLFKCCKLN, DKJCKNPNPAB, BLKCBHFNLGB, IACGDFHKCAE, OKAHCMOGDGF);
		}

		// Token: 0x060091ED RID: 37357 RVA: 0x0033122D File Offset: 0x0032F42D
		public void CAKPFALKBCP(bool DPNHODJHGJL)
		{
			this.m_UseGraphicAlpha = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060091EE RID: 37358 RVA: 0x00331035 File Offset: 0x0032F235
		public Vector2 LCFJIADPKDJ()
		{
			return this.m_EffectDistance;
		}

		// Token: 0x060091EF RID: 37359 RVA: 0x0033277C File Offset: 0x0033097C
		protected void CCLMLDEPGBJ(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 6;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			this.ELEGLCBBDAL(ACPPOPJKJBE, HABLFKCCKLN, DKJCKNPNPAB, BLKCBHFNLGB, IACGDFHKCAE, OKAHCMOGDGF);
		}

		// Token: 0x060091F0 RID: 37360 RVA: 0x0033102D File Offset: 0x0032F22D
		public Color GKLEAJDKCPN()
		{
			return this.m_EffectColor;
		}

		// Token: 0x060091F1 RID: 37361 RVA: 0x003327B4 File Offset: 0x003309B4
		public void JAKNEADMEOA(Vector2 DPNHODJHGJL)
		{
			if (DPNHODJHGJL.x > 388f)
			{
				DPNHODJHGJL.x = 1577f;
			}
			if (DPNHODJHGJL.x < 1143f)
			{
				DPNHODJHGJL.x = 124f;
			}
			if (DPNHODJHGJL.y > 186f)
			{
				DPNHODJHGJL.y = 1345f;
			}
			if (DPNHODJHGJL.y < 558f)
			{
				DPNHODJHGJL.y = 1166f;
			}
			if (this.m_EffectDistance == DPNHODJHGJL)
			{
				return;
			}
			this.m_EffectDistance = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060091F2 RID: 37362 RVA: 0x00331751 File Offset: 0x0032F951
		public bool EAFIDJHDONO()
		{
			return this.m_UseGraphicAlpha;
		}

		// Token: 0x060091F3 RID: 37363 RVA: 0x0033122D File Offset: 0x0032F42D
		public void PPFNAEOFCOE(bool DPNHODJHGJL)
		{
			this.m_UseGraphicAlpha = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060091F4 RID: 37364 RVA: 0x0033286C File Offset: 0x00330A6C
		protected void PNJJLHFNHIN(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 6;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			for (int i = DKJCKNPNPAB; i < BLKCBHFNLGB; i++)
			{
				UIVertex uivertex = ACPPOPJKJBE[i];
				ACPPOPJKJBE.Add(uivertex);
				Vector3 position = uivertex.position;
				position.x += IACGDFHKCAE;
				position.y += OKAHCMOGDGF;
				uivertex.position = position;
				Color32 color = HABLFKCCKLN;
				if (this.m_UseGraphicAlpha)
				{
					color.a = color.a * ACPPOPJKJBE[i].color.a / 62;
				}
				uivertex.color = color;
				ACPPOPJKJBE[i] = uivertex;
			}
		}

		// Token: 0x060091F5 RID: 37365 RVA: 0x00332934 File Offset: 0x00330B34
		protected void OODJMFMBJEK(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 8;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			this.DMLNBEKJOCE(ACPPOPJKJBE, HABLFKCCKLN, DKJCKNPNPAB, BLKCBHFNLGB, IACGDFHKCAE, OKAHCMOGDGF);
		}

		// Token: 0x060091F6 RID: 37366 RVA: 0x00331035 File Offset: 0x0032F235
		public Vector2 NKDKKKFMPBB()
		{
			return this.m_EffectDistance;
		}

		// Token: 0x060091F7 RID: 37367 RVA: 0x0033296C File Offset: 0x00330B6C
		protected void BPPBAMGELCC(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 6;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			this.PMCDNEMKJBO(ACPPOPJKJBE, HABLFKCCKLN, DKJCKNPNPAB, BLKCBHFNLGB, IACGDFHKCAE, OKAHCMOGDGF);
		}

		// Token: 0x060091F8 RID: 37368 RVA: 0x00331751 File Offset: 0x0032F951
		public bool PNCIAFEABIN()
		{
			return this.m_UseGraphicAlpha;
		}

		// Token: 0x060091F9 RID: 37369 RVA: 0x0033102D File Offset: 0x0032F22D
		public Color JIKHMBOGFBK()
		{
			return this.m_EffectColor;
		}

		// Token: 0x060091FA RID: 37370 RVA: 0x003329A4 File Offset: 0x00330BA4
		public void FMMJEKGGPLE(Vector2 DPNHODJHGJL)
		{
			if (DPNHODJHGJL.x > 280f)
			{
				DPNHODJHGJL.x = 1493f;
			}
			if (DPNHODJHGJL.x < 1644f)
			{
				DPNHODJHGJL.x = 1554f;
			}
			if (DPNHODJHGJL.y > 1929f)
			{
				DPNHODJHGJL.y = 1592f;
			}
			if (DPNHODJHGJL.y < 1022f)
			{
				DPNHODJHGJL.y = 1590f;
			}
			if (this.m_EffectDistance == DPNHODJHGJL)
			{
				return;
			}
			this.m_EffectDistance = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060091FB RID: 37371 RVA: 0x00331008 File Offset: 0x0032F208
		public void AGKPOPDJCHO(Color DPNHODJHGJL)
		{
			this.m_EffectColor = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060091FC RID: 37372 RVA: 0x00332A5C File Offset: 0x00330C5C
		public void IAGFFKHCMKF(Vector2 DPNHODJHGJL)
		{
			if (DPNHODJHGJL.x > 126f)
			{
				DPNHODJHGJL.x = 1503f;
			}
			if (DPNHODJHGJL.x < 34f)
			{
				DPNHODJHGJL.x = 1698f;
			}
			if (DPNHODJHGJL.y > 1212f)
			{
				DPNHODJHGJL.y = 1129f;
			}
			if (DPNHODJHGJL.y < 837f)
			{
				DPNHODJHGJL.y = 661f;
			}
			if (this.m_EffectDistance == DPNHODJHGJL)
			{
				return;
			}
			this.m_EffectDistance = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x060091FD RID: 37373 RVA: 0x00332B14 File Offset: 0x00330D14
		protected void GOKPFMFBPKA(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 2;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			this.CKHOCODMNKP(ACPPOPJKJBE, HABLFKCCKLN, DKJCKNPNPAB, BLKCBHFNLGB, IACGDFHKCAE, OKAHCMOGDGF);
		}

		// Token: 0x060091FE RID: 37374 RVA: 0x00331751 File Offset: 0x0032F951
		public bool HMGKEGLLNKB()
		{
			return this.m_UseGraphicAlpha;
		}

		// Token: 0x06009200 RID: 37376 RVA: 0x00332B4C File Offset: 0x00330D4C
		protected void BEJNJDKCHID(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 1;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			this.KIBEDOKDNMP(ACPPOPJKJBE, HABLFKCCKLN, DKJCKNPNPAB, BLKCBHFNLGB, IACGDFHKCAE, OKAHCMOGDGF);
		}

		// Token: 0x06009201 RID: 37377 RVA: 0x00332B84 File Offset: 0x00330D84
		public override void ModifyMesh(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			float num = 1f;
			if (component && component.resizeTextForBestFit)
			{
				num = (float)component.cachedTextGenerator.fontSizeUsedForBestFit / (float)(component.resizeTextMaxSize - 1);
			}
			float num2 = this.effectDistance.x * num;
			float num3 = this.effectDistance.y * num;
			int dkjcknpnpab = 0;
			int count = list.Count;
			this.GOKPFMFBPKA(list, this.effectColor, dkjcknpnpab, list.Count, num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.GOKPFMFBPKA(list, this.effectColor, dkjcknpnpab, list.Count, num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.GOKPFMFBPKA(list, this.effectColor, dkjcknpnpab, list.Count, -num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.GOKPFMFBPKA(list, this.effectColor, dkjcknpnpab, list.Count, -num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.GOKPFMFBPKA(list, this.effectColor, dkjcknpnpab, list.Count, num2, 0f);
			dkjcknpnpab = count;
			count = list.Count;
			this.GOKPFMFBPKA(list, this.effectColor, dkjcknpnpab, list.Count, -num2, 0f);
			dkjcknpnpab = count;
			count = list.Count;
			this.GOKPFMFBPKA(list, this.effectColor, dkjcknpnpab, list.Count, 0f, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.GOKPFMFBPKA(list, this.effectColor, dkjcknpnpab, list.Count, 0f, -num3);
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06009202 RID: 37378 RVA: 0x0033102D File Offset: 0x0032F22D
		// (set) Token: 0x0600920F RID: 37391 RVA: 0x00331008 File Offset: 0x0032F208
		public Color effectColor
		{
			get
			{
				return this.m_EffectColor;
			}
			set
			{
				this.m_EffectColor = value;
				if (base.graphic != null)
				{
					base.graphic.SetVerticesDirty();
				}
			}
		}

		// Token: 0x06009203 RID: 37379 RVA: 0x00332D74 File Offset: 0x00330F74
		protected void IGGKLKGNLIF(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 8;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			this.AMJMKAMKNOA(ACPPOPJKJBE, HABLFKCCKLN, DKJCKNPNPAB, BLKCBHFNLGB, IACGDFHKCAE, OKAHCMOGDGF);
		}

		// Token: 0x06009204 RID: 37380 RVA: 0x00332DAC File Offset: 0x00330FAC
		protected void MJHEDCOLIFA(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 4;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			this.LEIACNGENAM(ACPPOPJKJBE, HABLFKCCKLN, DKJCKNPNPAB, BLKCBHFNLGB, IACGDFHKCAE, OKAHCMOGDGF);
		}

		// Token: 0x06009205 RID: 37381 RVA: 0x00331751 File Offset: 0x0032F951
		public bool JDHECCJCHDG()
		{
			return this.m_UseGraphicAlpha;
		}

		// Token: 0x06009206 RID: 37382 RVA: 0x00331008 File Offset: 0x0032F208
		public void LDHGAPFMPBM(Color DPNHODJHGJL)
		{
			this.m_EffectColor = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x06009207 RID: 37383 RVA: 0x00332DE4 File Offset: 0x00330FE4
		public virtual void IJIECBFFEPJ(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			float num = 686f;
			if (component && component.resizeTextForBestFit)
			{
				num = (float)component.cachedTextGenerator.fontSizeUsedForBestFit / (float)(component.resizeTextMaxSize - 0);
			}
			float num2 = this.HAMJAFHLHKC().x * num;
			float num3 = this.LLIBEEPGENH().y * num;
			int dkjcknpnpab = 0;
			int count = list.Count;
			this.KIEOILHONOO(list, this.FBINAFBKDPC(), dkjcknpnpab, list.Count, num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.KIEOILHONOO(list, this.EJOLEEIBMGD(), dkjcknpnpab, list.Count, num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.KIEOILHONOO(list, this.HDJKBMMPMEI(), dkjcknpnpab, list.Count, -num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.LHEJKHEJHGO(list, this.OKCAENOONPC(), dkjcknpnpab, list.Count, -num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.NIDAHBMLOEI(list, this.EJOLEEIBMGD(), dkjcknpnpab, list.Count, num2, 25f);
			dkjcknpnpab = count;
			count = list.Count;
			this.NIDAHBMLOEI(list, this.EJOLEEIBMGD(), dkjcknpnpab, list.Count, -num2, 799f);
			dkjcknpnpab = count;
			count = list.Count;
			this.HBHKDNNDPHP(list, this.FBINAFBKDPC(), dkjcknpnpab, list.Count, 404f, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.KOCBBEPIAFE(list, this.HDJKBMMPMEI(), dkjcknpnpab, list.Count, 333f, -num3);
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x06009208 RID: 37384 RVA: 0x00332FD4 File Offset: 0x003311D4
		public void HBCDGJOBHBB(Vector2 DPNHODJHGJL)
		{
			if (DPNHODJHGJL.x > 1812f)
			{
				DPNHODJHGJL.x = 1963f;
			}
			if (DPNHODJHGJL.x < 1282f)
			{
				DPNHODJHGJL.x = 1873f;
			}
			if (DPNHODJHGJL.y > 720f)
			{
				DPNHODJHGJL.y = 1182f;
			}
			if (DPNHODJHGJL.y < 850f)
			{
				DPNHODJHGJL.y = 1528f;
			}
			if (this.m_EffectDistance == DPNHODJHGJL)
			{
				return;
			}
			this.m_EffectDistance = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x06009209 RID: 37385 RVA: 0x00331035 File Offset: 0x0032F235
		public Vector2 AIBMHCIOHKO()
		{
			return this.m_EffectDistance;
		}

		// Token: 0x0600920A RID: 37386 RVA: 0x0033102D File Offset: 0x0032F22D
		public Color OKCAENOONPC()
		{
			return this.m_EffectColor;
		}

		// Token: 0x0600920B RID: 37387 RVA: 0x0033308C File Offset: 0x0033128C
		public void EHNJBANCKJB(Vector2 DPNHODJHGJL)
		{
			if (DPNHODJHGJL.x > 48f)
			{
				DPNHODJHGJL.x = 497f;
			}
			if (DPNHODJHGJL.x < 1084f)
			{
				DPNHODJHGJL.x = 1861f;
			}
			if (DPNHODJHGJL.y > 1088f)
			{
				DPNHODJHGJL.y = 1405f;
			}
			if (DPNHODJHGJL.y < 341f)
			{
				DPNHODJHGJL.y = 195f;
			}
			if (this.m_EffectDistance == DPNHODJHGJL)
			{
				return;
			}
			this.m_EffectDistance = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x0600920C RID: 37388 RVA: 0x00333144 File Offset: 0x00331344
		protected void NLFCNNIMBBP(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 1;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			this.DPNJMNPJENN(ACPPOPJKJBE, HABLFKCCKLN, DKJCKNPNPAB, BLKCBHFNLGB, IACGDFHKCAE, OKAHCMOGDGF);
		}

		// Token: 0x0600920D RID: 37389 RVA: 0x0033317C File Offset: 0x0033137C
		public virtual void GOMKDJABAKC(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			float num = 303f;
			if (component && component.resizeTextForBestFit)
			{
				num = (float)component.cachedTextGenerator.fontSizeUsedForBestFit / (float)(component.resizeTextMaxSize - 0);
			}
			float num2 = this.LLIBEEPGENH().x * num;
			float num3 = this.DKJLKPGDPAA().y * num;
			int dkjcknpnpab = 1;
			int count = list.Count;
			this.ICJILGMGMHD(list, this.GKLEAJDKCPN(), dkjcknpnpab, list.Count, num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.KIEOILHONOO(list, this.effectColor, dkjcknpnpab, list.Count, num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.DNCBENCPKOM(list, this.effectColor, dkjcknpnpab, list.Count, -num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.CCLMLDEPGBJ(list, this.HICGIMMKMHM(), dkjcknpnpab, list.Count, -num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.NNDLHKKEKEI(list, this.NHDDIANFKLB(), dkjcknpnpab, list.Count, num2, 765f);
			dkjcknpnpab = count;
			count = list.Count;
			this.NNDLHKKEKEI(list, this.EJOLEEIBMGD(), dkjcknpnpab, list.Count, -num2, 786f);
			dkjcknpnpab = count;
			count = list.Count;
			this.MJHEDCOLIFA(list, this.HICGIMMKMHM(), dkjcknpnpab, list.Count, 1075f, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.IGGKLKGNLIF(list, this.DGFIDJLNOLJ(), dkjcknpnpab, list.Count, 268f, -num3);
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x0600920E RID: 37390 RVA: 0x0033336C File Offset: 0x0033156C
		protected void CKHOCODMNKP(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 2;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			for (int i = DKJCKNPNPAB; i < BLKCBHFNLGB; i++)
			{
				UIVertex uivertex = ACPPOPJKJBE[i];
				ACPPOPJKJBE.Add(uivertex);
				Vector3 position = uivertex.position;
				position.x += IACGDFHKCAE;
				position.y += OKAHCMOGDGF;
				uivertex.position = position;
				Color32 color = HABLFKCCKLN;
				if (this.m_UseGraphicAlpha)
				{
					color.a = color.a * ACPPOPJKJBE[i].color.a / byte.MaxValue;
				}
				uivertex.color = color;
				ACPPOPJKJBE[i] = uivertex;
			}
		}

		// Token: 0x06009210 RID: 37392 RVA: 0x00331035 File Offset: 0x0032F235
		public Vector2 LMGOCMLPBPO()
		{
			return this.m_EffectDistance;
		}

		// Token: 0x06009211 RID: 37393 RVA: 0x00331751 File Offset: 0x0032F951
		public bool NEBNCHPHIJL()
		{
			return this.m_UseGraphicAlpha;
		}

		// Token: 0x06009212 RID: 37394 RVA: 0x0033122D File Offset: 0x0032F42D
		public void ONBJGIGMBDM(bool DPNHODJHGJL)
		{
			this.m_UseGraphicAlpha = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x06009213 RID: 37395 RVA: 0x00331008 File Offset: 0x0032F208
		public void DOMEDAAAFAH(Color DPNHODJHGJL)
		{
			this.m_EffectColor = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x06009214 RID: 37396 RVA: 0x0033102D File Offset: 0x0032F22D
		public Color HDJKBMMPMEI()
		{
			return this.m_EffectColor;
		}

		// Token: 0x06009215 RID: 37397 RVA: 0x00331035 File Offset: 0x0032F235
		public Vector2 MCDNECFDJBP()
		{
			return this.m_EffectDistance;
		}

		// Token: 0x06009216 RID: 37398 RVA: 0x00331035 File Offset: 0x0032F235
		public Vector2 PGKFINIOIAE()
		{
			return this.m_EffectDistance;
		}

		// Token: 0x06009217 RID: 37399 RVA: 0x00333434 File Offset: 0x00331634
		protected void PMCDNEMKJBO(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 0;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			for (int i = DKJCKNPNPAB; i < BLKCBHFNLGB; i++)
			{
				UIVertex uivertex = ACPPOPJKJBE[i];
				ACPPOPJKJBE.Add(uivertex);
				Vector3 position = uivertex.position;
				position.x += IACGDFHKCAE;
				position.y += OKAHCMOGDGF;
				uivertex.position = position;
				Color32 color = HABLFKCCKLN;
				if (this.m_UseGraphicAlpha)
				{
					color.a = (byte)((int)(color.a * ACPPOPJKJBE[i].color.a) / -46);
				}
				uivertex.color = color;
				ACPPOPJKJBE[i] = uivertex;
			}
		}

		// Token: 0x06009218 RID: 37400 RVA: 0x0033122D File Offset: 0x0032F42D
		public void PKKFGPKEKAI(bool DPNHODJHGJL)
		{
			this.m_UseGraphicAlpha = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x06009219 RID: 37401 RVA: 0x003334FC File Offset: 0x003316FC
		protected void DNCBENCPKOM(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 8;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			this.EHEJGAHGDLN(ACPPOPJKJBE, HABLFKCCKLN, DKJCKNPNPAB, BLKCBHFNLGB, IACGDFHKCAE, OKAHCMOGDGF);
		}

		// Token: 0x0600921A RID: 37402 RVA: 0x00333534 File Offset: 0x00331734
		public virtual void BKDLPLOAJDD(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			float num = 846f;
			if (component && component.resizeTextForBestFit)
			{
				num = (float)component.cachedTextGenerator.fontSizeUsedForBestFit / (float)(component.resizeTextMaxSize - 1);
			}
			float num2 = this.LCFJIADPKDJ().x * num;
			float num3 = this.IBFCJFHMHIH().y * num;
			int dkjcknpnpab = 0;
			int count = list.Count;
			this.PJJHCLFMHMK(list, this.OKCAENOONPC(), dkjcknpnpab, list.Count, num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.GJOMMHKJHEA(list, this.HICGIMMKMHM(), dkjcknpnpab, list.Count, num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.AOGMGGFFCGB(list, this.FBINAFBKDPC(), dkjcknpnpab, list.Count, -num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.FBNPLCAMPNB(list, this.HICGIMMKMHM(), dkjcknpnpab, list.Count, -num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.BPPBAMGELCC(list, this.NHDDIANFKLB(), dkjcknpnpab, list.Count, num2, 916f);
			dkjcknpnpab = count;
			count = list.Count;
			this.GOKPFMFBPKA(list, this.GKLEAJDKCPN(), dkjcknpnpab, list.Count, -num2, 49f);
			dkjcknpnpab = count;
			count = list.Count;
			this.MNGJNHBBEHE(list, this.HICGIMMKMHM(), dkjcknpnpab, list.Count, 601f, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.MNGJNHBBEHE(list, this.EJOLEEIBMGD(), dkjcknpnpab, list.Count, 1135f, -num3);
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x0600921B RID: 37403 RVA: 0x0033122D File Offset: 0x0032F42D
		public void NAPMHFGLJGL(bool DPNHODJHGJL)
		{
			this.m_UseGraphicAlpha = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x0600921C RID: 37404 RVA: 0x00331035 File Offset: 0x0032F235
		public Vector2 OBGIGGDOIDL()
		{
			return this.m_EffectDistance;
		}

		// Token: 0x0600921D RID: 37405 RVA: 0x00333724 File Offset: 0x00331924
		public void EDELLMJMPMG(Vector2 DPNHODJHGJL)
		{
			if (DPNHODJHGJL.x > 1451f)
			{
				DPNHODJHGJL.x = 479f;
			}
			if (DPNHODJHGJL.x < 1323f)
			{
				DPNHODJHGJL.x = 1860f;
			}
			if (DPNHODJHGJL.y > 1770f)
			{
				DPNHODJHGJL.y = 1959f;
			}
			if (DPNHODJHGJL.y < 772f)
			{
				DPNHODJHGJL.y = 823f;
			}
			if (this.m_EffectDistance == DPNHODJHGJL)
			{
				return;
			}
			this.m_EffectDistance = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x0600921E RID: 37406 RVA: 0x0033122D File Offset: 0x0032F42D
		public void IBNFIAGLFDI(bool DPNHODJHGJL)
		{
			this.m_UseGraphicAlpha = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x0600921F RID: 37407 RVA: 0x0033122D File Offset: 0x0032F42D
		public void CNBCMFMBBCJ(bool DPNHODJHGJL)
		{
			this.m_UseGraphicAlpha = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x06009220 RID: 37408 RVA: 0x0033122D File Offset: 0x0032F42D
		public void KGNLILNKBFD(bool DPNHODJHGJL)
		{
			this.m_UseGraphicAlpha = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x06009221 RID: 37409 RVA: 0x0033122D File Offset: 0x0032F42D
		public void LNBEDLBLDLG(bool DPNHODJHGJL)
		{
			this.m_UseGraphicAlpha = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x06009222 RID: 37410 RVA: 0x003337DC File Offset: 0x003319DC
		protected void DHBOGDHCNAE(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 4;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			for (int i = DKJCKNPNPAB; i < BLKCBHFNLGB; i++)
			{
				UIVertex uivertex = ACPPOPJKJBE[i];
				ACPPOPJKJBE.Add(uivertex);
				Vector3 position = uivertex.position;
				position.x += IACGDFHKCAE;
				position.y += OKAHCMOGDGF;
				uivertex.position = position;
				Color32 color = HABLFKCCKLN;
				if (this.m_UseGraphicAlpha)
				{
					color.a = (byte)((int)(color.a * ACPPOPJKJBE[i].color.a) / -36);
				}
				uivertex.color = color;
				ACPPOPJKJBE[i] = uivertex;
			}
		}

		// Token: 0x06009223 RID: 37411 RVA: 0x0033102D File Offset: 0x0032F22D
		public Color IJOILNLGPCM()
		{
			return this.m_EffectColor;
		}

		// Token: 0x06009224 RID: 37412 RVA: 0x00331035 File Offset: 0x0032F235
		public Vector2 LLIBEEPGENH()
		{
			return this.m_EffectDistance;
		}

		// Token: 0x06009225 RID: 37413 RVA: 0x003338A4 File Offset: 0x00331AA4
		public virtual void DOJEEHLHEIJ(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			float num = 458f;
			if (component && component.resizeTextForBestFit)
			{
				num = (float)component.cachedTextGenerator.fontSizeUsedForBestFit / (float)(component.resizeTextMaxSize - 0);
			}
			float num2 = this.LMGOCMLPBPO().x * num;
			float num3 = this.effectDistance.y * num;
			int dkjcknpnpab = 1;
			int count = list.Count;
			this.NIDAHBMLOEI(list, this.HICGIMMKMHM(), dkjcknpnpab, list.Count, num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.ICJILGMGMHD(list, this.FBINAFBKDPC(), dkjcknpnpab, list.Count, num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.AOGMGGFFCGB(list, this.IJOILNLGPCM(), dkjcknpnpab, list.Count, -num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.NLFCNNIMBBP(list, this.IJOILNLGPCM(), dkjcknpnpab, list.Count, -num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.MNGJNHBBEHE(list, this.EJOLEEIBMGD(), dkjcknpnpab, list.Count, num2, 255f);
			dkjcknpnpab = count;
			count = list.Count;
			this.KOCBBEPIAFE(list, this.HDJKBMMPMEI(), dkjcknpnpab, list.Count, -num2, 1116f);
			dkjcknpnpab = count;
			count = list.Count;
			this.ICJILGMGMHD(list, this.JIKHMBOGFBK(), dkjcknpnpab, list.Count, 413f, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.BPPBAMGELCC(list, this.EJOLEEIBMGD(), dkjcknpnpab, list.Count, 357f, -num3);
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x06009226 RID: 37414 RVA: 0x0033122D File Offset: 0x0032F42D
		public void CDEEMMHGAFH(bool DPNHODJHGJL)
		{
			this.m_UseGraphicAlpha = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x06009227 RID: 37415 RVA: 0x00333A94 File Offset: 0x00331C94
		public virtual void ALCKKMEADND(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			float num = 1624f;
			if (component && component.resizeTextForBestFit)
			{
				num = (float)component.cachedTextGenerator.fontSizeUsedForBestFit / (float)(component.resizeTextMaxSize - 0);
			}
			float num2 = this.LLIBEEPGENH().x * num;
			float num3 = this.NKDKKKFMPBB().y * num;
			int dkjcknpnpab = 0;
			int count = list.Count;
			this.PECEBCBINKA(list, this.OKCAENOONPC(), dkjcknpnpab, list.Count, num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.HBHKDNNDPHP(list, this.NHDDIANFKLB(), dkjcknpnpab, list.Count, num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.KIEOILHONOO(list, this.GKLEAJDKCPN(), dkjcknpnpab, list.Count, -num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.HBHKDNNDPHP(list, this.HDJKBMMPMEI(), dkjcknpnpab, list.Count, -num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.KOCBBEPIAFE(list, this.JIKHMBOGFBK(), dkjcknpnpab, list.Count, num2, 1772f);
			dkjcknpnpab = count;
			count = list.Count;
			this.GOKPFMFBPKA(list, this.HNCHHBMGGKF(), dkjcknpnpab, list.Count, -num2, 1685f);
			dkjcknpnpab = count;
			count = list.Count;
			this.AOGMGGFFCGB(list, this.EJOLEEIBMGD(), dkjcknpnpab, list.Count, 1638f, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.OODJMFMBJEK(list, this.HDJKBMMPMEI(), dkjcknpnpab, list.Count, 240f, -num3);
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x06009228 RID: 37416 RVA: 0x00333C84 File Offset: 0x00331E84
		protected void KOCBBEPIAFE(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 6;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			this.LEIACNGENAM(ACPPOPJKJBE, HABLFKCCKLN, DKJCKNPNPAB, BLKCBHFNLGB, IACGDFHKCAE, OKAHCMOGDGF);
		}

		// Token: 0x06009229 RID: 37417 RVA: 0x00331008 File Offset: 0x0032F208
		public void GPLAMPNMIAL(Color DPNHODJHGJL)
		{
			this.m_EffectColor = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x0600922A RID: 37418 RVA: 0x00331035 File Offset: 0x0032F235
		public Vector2 HNFGECPICNG()
		{
			return this.m_EffectDistance;
		}

		// Token: 0x0600922B RID: 37419 RVA: 0x00333CBC File Offset: 0x00331EBC
		public void MENLDNBBPAH(Vector2 DPNHODJHGJL)
		{
			if (DPNHODJHGJL.x > 792f)
			{
				DPNHODJHGJL.x = 1104f;
			}
			if (DPNHODJHGJL.x < 644f)
			{
				DPNHODJHGJL.x = 1271f;
			}
			if (DPNHODJHGJL.y > 1089f)
			{
				DPNHODJHGJL.y = 96f;
			}
			if (DPNHODJHGJL.y < 1883f)
			{
				DPNHODJHGJL.y = 1244f;
			}
			if (this.m_EffectDistance == DPNHODJHGJL)
			{
				return;
			}
			this.m_EffectDistance = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x0600922C RID: 37420 RVA: 0x00331751 File Offset: 0x0032F951
		public bool KFLNNAGNMAM()
		{
			return this.m_UseGraphicAlpha;
		}

		// Token: 0x0600922D RID: 37421 RVA: 0x00333D74 File Offset: 0x00331F74
		public void OMFKMOIKHFH(Vector2 DPNHODJHGJL)
		{
			if (DPNHODJHGJL.x > 469f)
			{
				DPNHODJHGJL.x = 1769f;
			}
			if (DPNHODJHGJL.x < 47f)
			{
				DPNHODJHGJL.x = 1326f;
			}
			if (DPNHODJHGJL.y > 1081f)
			{
				DPNHODJHGJL.y = 1196f;
			}
			if (DPNHODJHGJL.y < 430f)
			{
				DPNHODJHGJL.y = 176f;
			}
			if (this.m_EffectDistance == DPNHODJHGJL)
			{
				return;
			}
			this.m_EffectDistance = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x0600922E RID: 37422 RVA: 0x00331751 File Offset: 0x0032F951
		public bool KIKJIPNEBMI()
		{
			return this.m_UseGraphicAlpha;
		}

		// Token: 0x0600922F RID: 37423 RVA: 0x00333E2C File Offset: 0x0033202C
		protected void LHEJKHEJHGO(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 3;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			this.KIBEDOKDNMP(ACPPOPJKJBE, HABLFKCCKLN, DKJCKNPNPAB, BLKCBHFNLGB, IACGDFHKCAE, OKAHCMOGDGF);
		}

		// Token: 0x06009230 RID: 37424 RVA: 0x00333E64 File Offset: 0x00332064
		protected void PECEBCBINKA(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 1;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			this.LEIACNGENAM(ACPPOPJKJBE, HABLFKCCKLN, DKJCKNPNPAB, BLKCBHFNLGB, IACGDFHKCAE, OKAHCMOGDGF);
		}

		// Token: 0x06009231 RID: 37425 RVA: 0x00333E9C File Offset: 0x0033209C
		protected void AOGMGGFFCGB(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 8;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			this.JOFMONENOEP(ACPPOPJKJBE, HABLFKCCKLN, DKJCKNPNPAB, BLKCBHFNLGB, IACGDFHKCAE, OKAHCMOGDGF);
		}

		// Token: 0x06009233 RID: 37427 RVA: 0x00333F24 File Offset: 0x00332124
		public virtual void LCAHBHFEJJD(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			float num = 1893f;
			if (component && component.resizeTextForBestFit)
			{
				num = (float)component.cachedTextGenerator.fontSizeUsedForBestFit / (float)(component.resizeTextMaxSize - 0);
			}
			float num2 = this.LMGOCMLPBPO().x * num;
			float num3 = this.LCFJIADPKDJ().y * num;
			int dkjcknpnpab = 1;
			int count = list.Count;
			this.LHEJKHEJHGO(list, this.DGFIDJLNOLJ(), dkjcknpnpab, list.Count, num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.PJJHCLFMHMK(list, this.HNCHHBMGGKF(), dkjcknpnpab, list.Count, num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.KIEOILHONOO(list, this.effectColor, dkjcknpnpab, list.Count, -num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.NLFCNNIMBBP(list, this.effectColor, dkjcknpnpab, list.Count, -num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.HBHKDNNDPHP(list, this.GKLEAJDKCPN(), dkjcknpnpab, list.Count, num2, 282f);
			dkjcknpnpab = count;
			count = list.Count;
			this.AOGMGGFFCGB(list, this.HICGIMMKMHM(), dkjcknpnpab, list.Count, -num2, 1788f);
			dkjcknpnpab = count;
			count = list.Count;
			this.FBNPLCAMPNB(list, this.FBINAFBKDPC(), dkjcknpnpab, list.Count, 604f, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.DNCBENCPKOM(list, this.JIKHMBOGFBK(), dkjcknpnpab, list.Count, 1925f, -num3);
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x06009234 RID: 37428 RVA: 0x00334114 File Offset: 0x00332314
		public virtual void KEAEPLNFKEN(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			float num = 275f;
			if (component && component.resizeTextForBestFit)
			{
				num = (float)component.cachedTextGenerator.fontSizeUsedForBestFit / (float)(component.resizeTextMaxSize - 1);
			}
			float num2 = this.MLNOCHPGCHB().x * num;
			float num3 = this.effectDistance.y * num;
			int dkjcknpnpab = 1;
			int count = list.Count;
			this.OODJMFMBJEK(list, this.HNCHHBMGGKF(), dkjcknpnpab, list.Count, num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.LHEJKHEJHGO(list, this.NHDDIANFKLB(), dkjcknpnpab, list.Count, num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.GOKPFMFBPKA(list, this.HDJKBMMPMEI(), dkjcknpnpab, list.Count, -num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.AOGMGGFFCGB(list, this.FBINAFBKDPC(), dkjcknpnpab, list.Count, -num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.AOGMGGFFCGB(list, this.HICGIMMKMHM(), dkjcknpnpab, list.Count, num2, 1959f);
			dkjcknpnpab = count;
			count = list.Count;
			this.HBHKDNNDPHP(list, this.HICGIMMKMHM(), dkjcknpnpab, list.Count, -num2, 1811f);
			dkjcknpnpab = count;
			count = list.Count;
			this.MJHEDCOLIFA(list, this.OKCAENOONPC(), dkjcknpnpab, list.Count, 79f, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.LHEJKHEJHGO(list, this.JIKHMBOGFBK(), dkjcknpnpab, list.Count, 1430f, -num3);
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x06009235 RID: 37429 RVA: 0x00334304 File Offset: 0x00332504
		protected void PHHPOPAMHEG(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 5;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			this.EHEJGAHGDLN(ACPPOPJKJBE, HABLFKCCKLN, DKJCKNPNPAB, BLKCBHFNLGB, IACGDFHKCAE, OKAHCMOGDGF);
		}

		// Token: 0x06009236 RID: 37430 RVA: 0x0033102D File Offset: 0x0032F22D
		public Color NHDDIANFKLB()
		{
			return this.m_EffectColor;
		}

		// Token: 0x06009237 RID: 37431 RVA: 0x0033433C File Offset: 0x0033253C
		public void NNAEGNCJNNF(Vector2 DPNHODJHGJL)
		{
			if (DPNHODJHGJL.x > 996f)
			{
				DPNHODJHGJL.x = 1475f;
			}
			if (DPNHODJHGJL.x < 143f)
			{
				DPNHODJHGJL.x = 1923f;
			}
			if (DPNHODJHGJL.y > 1433f)
			{
				DPNHODJHGJL.y = 1806f;
			}
			if (DPNHODJHGJL.y < 352f)
			{
				DPNHODJHGJL.y = 402f;
			}
			if (this.m_EffectDistance == DPNHODJHGJL)
			{
				return;
			}
			this.m_EffectDistance = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x06009238 RID: 37432 RVA: 0x003343F4 File Offset: 0x003325F4
		protected void MNGJNHBBEHE(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 1;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			this.MGKNONMNAHN(ACPPOPJKJBE, HABLFKCCKLN, DKJCKNPNPAB, BLKCBHFNLGB, IACGDFHKCAE, OKAHCMOGDGF);
		}

		// Token: 0x06009239 RID: 37433 RVA: 0x0033442C File Offset: 0x0033262C
		protected void NIDAHBMLOEI(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 4;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			this.AMJMKAMKNOA(ACPPOPJKJBE, HABLFKCCKLN, DKJCKNPNPAB, BLKCBHFNLGB, IACGDFHKCAE, OKAHCMOGDGF);
		}

		// Token: 0x0600923A RID: 37434 RVA: 0x00334464 File Offset: 0x00332664
		public void MMKAPCFLEID(Vector2 DPNHODJHGJL)
		{
			if (DPNHODJHGJL.x > 1292f)
			{
				DPNHODJHGJL.x = 1349f;
			}
			if (DPNHODJHGJL.x < 615f)
			{
				DPNHODJHGJL.x = 1320f;
			}
			if (DPNHODJHGJL.y > 778f)
			{
				DPNHODJHGJL.y = 617f;
			}
			if (DPNHODJHGJL.y < 919f)
			{
				DPNHODJHGJL.y = 1671f;
			}
			if (this.m_EffectDistance == DPNHODJHGJL)
			{
				return;
			}
			this.m_EffectDistance = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x0600923B RID: 37435 RVA: 0x00331751 File Offset: 0x0032F951
		public bool DANDGLOLBMK()
		{
			return this.m_UseGraphicAlpha;
		}

		// Token: 0x0600923C RID: 37436 RVA: 0x00331008 File Offset: 0x0032F208
		public void MMLMIOGEEHK(Color DPNHODJHGJL)
		{
			this.m_EffectColor = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x0600923D RID: 37437 RVA: 0x0033451C File Offset: 0x0033271C
		public virtual void LPDPCKEDJDG(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			float num = 1783f;
			if (component && component.resizeTextForBestFit)
			{
				num = (float)component.cachedTextGenerator.fontSizeUsedForBestFit / (float)(component.resizeTextMaxSize - 0);
			}
			float num2 = this.HNFGECPICNG().x * num;
			float num3 = this.ANGGBALBEKE().y * num;
			int dkjcknpnpab = 1;
			int count = list.Count;
			this.KIEOILHONOO(list, this.IJOILNLGPCM(), dkjcknpnpab, list.Count, num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.MNGJNHBBEHE(list, this.HICGIMMKMHM(), dkjcknpnpab, list.Count, num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.IGGKLKGNLIF(list, this.JIKHMBOGFBK(), dkjcknpnpab, list.Count, -num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.IGGKLKGNLIF(list, this.HNCHHBMGGKF(), dkjcknpnpab, list.Count, -num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.PHHPOPAMHEG(list, this.HNCHHBMGGKF(), dkjcknpnpab, list.Count, num2, 1154f);
			dkjcknpnpab = count;
			count = list.Count;
			this.LHEJKHEJHGO(list, this.HDJKBMMPMEI(), dkjcknpnpab, list.Count, -num2, 89f);
			dkjcknpnpab = count;
			count = list.Count;
			this.NIDAHBMLOEI(list, this.NHDDIANFKLB(), dkjcknpnpab, list.Count, 1431f, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.DNCBENCPKOM(list, this.HNCHHBMGGKF(), dkjcknpnpab, list.Count, 5f, -num3);
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x0600923E RID: 37438 RVA: 0x0033470C File Offset: 0x0033290C
		protected void AJAGFDDGBGP(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 8;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			for (int i = DKJCKNPNPAB; i < BLKCBHFNLGB; i++)
			{
				UIVertex uivertex = ACPPOPJKJBE[i];
				ACPPOPJKJBE.Add(uivertex);
				Vector3 position = uivertex.position;
				position.x += IACGDFHKCAE;
				position.y += OKAHCMOGDGF;
				uivertex.position = position;
				Color32 color = HABLFKCCKLN;
				if (this.m_UseGraphicAlpha)
				{
					color.a = (byte)((int)(color.a * ACPPOPJKJBE[i].color.a) / -179);
				}
				uivertex.color = color;
				ACPPOPJKJBE[i] = uivertex;
			}
		}

		// Token: 0x0600923F RID: 37439 RVA: 0x003347D4 File Offset: 0x003329D4
		protected void DMLNBEKJOCE(List<UIVertex> ACPPOPJKJBE, Color32 HABLFKCCKLN, int DKJCKNPNPAB, int BLKCBHFNLGB, float IACGDFHKCAE, float OKAHCMOGDGF)
		{
			int num = ACPPOPJKJBE.Count * 1;
			if (ACPPOPJKJBE.Capacity < num)
			{
				ACPPOPJKJBE.Capacity = num;
			}
			for (int i = DKJCKNPNPAB; i < BLKCBHFNLGB; i += 0)
			{
				UIVertex uivertex = ACPPOPJKJBE[i];
				ACPPOPJKJBE.Add(uivertex);
				Vector3 position = uivertex.position;
				position.x += IACGDFHKCAE;
				position.y += OKAHCMOGDGF;
				uivertex.position = position;
				Color32 color = HABLFKCCKLN;
				if (this.m_UseGraphicAlpha)
				{
					color.a = (byte)((int)(color.a * ACPPOPJKJBE[i].color.a) / -73);
				}
				uivertex.color = color;
				ACPPOPJKJBE[i] = uivertex;
			}
		}

		// Token: 0x06009240 RID: 37440 RVA: 0x00331035 File Offset: 0x0032F235
		public Vector2 ANGGBALBEKE()
		{
			return this.m_EffectDistance;
		}

		// Token: 0x06009241 RID: 37441 RVA: 0x0033489C File Offset: 0x00332A9C
		public virtual void IGNHHIFIHFN(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			Text component = base.GetComponent<Text>();
			float num = 1292f;
			if (component && component.resizeTextForBestFit)
			{
				num = (float)component.cachedTextGenerator.fontSizeUsedForBestFit / (float)(component.resizeTextMaxSize - 0);
			}
			float num2 = this.effectDistance.x * num;
			float num3 = this.LCFJIADPKDJ().y * num;
			int dkjcknpnpab = 0;
			int count = list.Count;
			this.HBHKDNNDPHP(list, this.HNCHHBMGGKF(), dkjcknpnpab, list.Count, num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.FBNPLCAMPNB(list, this.HNCHHBMGGKF(), dkjcknpnpab, list.Count, num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.GOKPFMFBPKA(list, this.HNCHHBMGGKF(), dkjcknpnpab, list.Count, -num2, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.PECEBCBINKA(list, this.GKLEAJDKCPN(), dkjcknpnpab, list.Count, -num2, -num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.DNCBENCPKOM(list, this.HDJKBMMPMEI(), dkjcknpnpab, list.Count, num2, 873f);
			dkjcknpnpab = count;
			count = list.Count;
			this.FBNPLCAMPNB(list, this.NHDDIANFKLB(), dkjcknpnpab, list.Count, -num2, 155f);
			dkjcknpnpab = count;
			count = list.Count;
			this.ICJILGMGMHD(list, this.HNCHHBMGGKF(), dkjcknpnpab, list.Count, 379f, num3);
			dkjcknpnpab = count;
			count = list.Count;
			this.KOCBBEPIAFE(list, this.GKLEAJDKCPN(), dkjcknpnpab, list.Count, 1469f, -num3);
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x06009242 RID: 37442 RVA: 0x00334A8C File Offset: 0x00332C8C
		public void BODMMCIKNEN(Vector2 DPNHODJHGJL)
		{
			if (DPNHODJHGJL.x > 1749f)
			{
				DPNHODJHGJL.x = 1109f;
			}
			if (DPNHODJHGJL.x < 467f)
			{
				DPNHODJHGJL.x = 1598f;
			}
			if (DPNHODJHGJL.y > 1720f)
			{
				DPNHODJHGJL.y = 613f;
			}
			if (DPNHODJHGJL.y < 1056f)
			{
				DPNHODJHGJL.y = 693f;
			}
			if (this.m_EffectDistance == DPNHODJHGJL)
			{
				return;
			}
			this.m_EffectDistance = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x06009243 RID: 37443 RVA: 0x0033122D File Offset: 0x0032F42D
		public void EAIPDNHLLEL(bool DPNHODJHGJL)
		{
			this.m_UseGraphicAlpha = DPNHODJHGJL;
			if (base.graphic != null)
			{
				base.graphic.SetVerticesDirty();
			}
		}

		// Token: 0x040010DD RID: 4317
		[SerializeField]
		private Color m_EffectColor = new Color(0f, 0f, 0f, 0.5f);

		// Token: 0x040010DE RID: 4318
		[SerializeField]
		private Vector2 m_EffectDistance = new Vector2(1f, -1f);

		// Token: 0x040010DF RID: 4319
		[SerializeField]
		private bool m_UseGraphicAlpha = true;
	}
}
