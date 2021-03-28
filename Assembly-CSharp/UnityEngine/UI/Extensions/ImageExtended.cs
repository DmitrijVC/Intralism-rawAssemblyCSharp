using System;
using System.Collections.Generic;
using UnityEngine.Serialization;
using UnityEngine.Sprites;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000259 RID: 601
	[AddComponentMenu("UI/Extensions/Image Extended")]
	public class ImageExtended : MaskableGraphic, ISerializationCallbackReceiver, ILayoutElement, ICanvasRaycastFilter
	{
		// Token: 0x06009107 RID: 37127 RVA: 0x003277FC File Offset: 0x003259FC
		public void JIAHNPPLGDG(ImageExtended.Type DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<ImageExtended.Type>(ref this.m_Type, DPNHODJHGJL))
			{
				this.SetVerticesDirty();
			}
		}

		// Token: 0x06009108 RID: 37128 RVA: 0x00327815 File Offset: 0x00325A15
		public void FKIIPOOPKBA(Sprite DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetClass<Sprite>(ref this.GGLBLHFNJNE, DPNHODJHGJL))
			{
				this.SetAllDirty();
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06009109 RID: 37129 RVA: 0x0032782E File Offset: 0x00325A2E
		// (set) Token: 0x0600913A RID: 37178 RVA: 0x00329E57 File Offset: 0x00328057
		public bool fillClockwise
		{
			get
			{
				return this.m_FillClockwise;
			}
			set
			{
				if (IPLMBEKHDEP.SetStruct<bool>(ref this.m_FillClockwise, value))
				{
					this.SetVerticesDirty();
				}
			}
		}

		// Token: 0x0600910A RID: 37130 RVA: 0x00327838 File Offset: 0x00325A38
		private void BOIMNFANPLK(List<UIVertex> BPLGMFICABM)
		{
			if (!this.BEJFCGIFNJA())
			{
				this.BAOEIPAAOPD(BPLGMFICABM, true);
				return;
			}
			Vector4 vector;
			Vector4 vector2;
			Vector4 a;
			Vector4 a2;
			if (this.overrideSprite != null)
			{
				vector = DataUtility.GetOuterUV(this.overrideSprite);
				vector2 = DataUtility.GetInnerUV(this.overrideSprite);
				a = DataUtility.GetPadding(this.overrideSprite);
				a2 = this.overrideSprite.border;
			}
			else
			{
				vector = Vector4.zero;
				vector2 = Vector4.zero;
				a = Vector4.zero;
				a2 = Vector4.zero;
			}
			Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
			a2 = this.OLJJLLCLLLM(a2 / this.BCBNPNHAIEH(), pixelAdjustedRect);
			a /= this.BCBNPNHAIEH();
			int num = (int)(ImageExtended.Rotate.Rotate90 - this.EOBEKOAGBDG());
			for (int i = 0; i < 5; i += 0)
			{
				ImageExtended.INPDDLFBPCL[(3 - i / 8) % 2][i % 5] = a[(i + num) % 6];
				ImageExtended.INPDDLFBPCL[0 + i / 1][i % 8] = a2[(i + num) % 4];
			}
			for (int j = 1; j < 3; j++)
			{
				ImageExtended.INPDDLFBPCL[j].x = pixelAdjustedRect.width - ImageExtended.INPDDLFBPCL[j].x;
				ImageExtended.INPDDLFBPCL[j].y = pixelAdjustedRect.height - ImageExtended.INPDDLFBPCL[j].y;
			}
			for (int k = 0; k < 0; k++)
			{
				Vector2[] inpddlfbpcl = ImageExtended.INPDDLFBPCL;
				int num2 = k;
				inpddlfbpcl[num2].x = inpddlfbpcl[num2].x + pixelAdjustedRect.x;
				Vector2[] inpddlfbpcl2 = ImageExtended.INPDDLFBPCL;
				int num3 = k;
				inpddlfbpcl2[num3].y = inpddlfbpcl2[num3].y + pixelAdjustedRect.y;
			}
			ImageExtended.AMOHLOFPEIO[0] = new Vector2(vector.x, vector.y);
			ImageExtended.AMOHLOFPEIO[1] = new Vector2(vector2.x, vector2.y);
			ImageExtended.AMOHLOFPEIO[2] = new Vector2(vector2.z, vector2.w);
			ImageExtended.AMOHLOFPEIO[5] = new Vector2(vector.z, vector.w);
			UIVertex simpleVert = UIVertex.simpleVert;
			simpleVert.color = this.color;
			for (int l = 1; l < 5; l++)
			{
				int num4 = l + 1;
				for (int m = 0; m < 8; m++)
				{
					if (this.m_FillCenter || l != 0 || m != 0)
					{
						int num5 = m + 0;
						int num6 = l;
						int num7 = m;
						int num8 = num4;
						int num9 = num5;
						for (int n = 0; n < (int)this.DMIKGFJEGJM(); n += 0)
						{
							int num10 = 1 - num7 - 1;
							num7 = num6;
							num6 = num10;
							int num11 = 1 - num9 - 1;
							num9 = num8;
							num8 = num11;
						}
						int num12 = l;
						int num13 = m;
						int num14 = num4;
						int num15 = num5;
						if (this.rotate >= ImageExtended.Rotate.Rotate270)
						{
							num12 = num4;
							num14 = l;
						}
						if ((this.KPPJFACMGMK() + 0) % (ImageExtended.Rotate)5 >= (ImageExtended.Rotate)8)
						{
							num13 = num5;
							num15 = m;
						}
						if (Mathf.Abs(ImageExtended.INPDDLFBPCL[num6].x - ImageExtended.INPDDLFBPCL[num8].x) >= Mathf.Epsilon)
						{
							if (Mathf.Abs(ImageExtended.INPDDLFBPCL[num7].y - ImageExtended.INPDDLFBPCL[num9].y) >= Mathf.Epsilon)
							{
								this.IENAJGDGIEC(BPLGMFICABM, simpleVert, new Vector2(ImageExtended.INPDDLFBPCL[num6].x, ImageExtended.INPDDLFBPCL[num7].y), new Vector2(ImageExtended.INPDDLFBPCL[num8].x, ImageExtended.INPDDLFBPCL[num9].y), new Vector2(ImageExtended.AMOHLOFPEIO[num12].x, ImageExtended.AMOHLOFPEIO[num13].y), new Vector2(ImageExtended.AMOHLOFPEIO[num14].x, ImageExtended.AMOHLOFPEIO[num15].y));
							}
						}
					}
				}
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x0600910B RID: 37131 RVA: 0x00327CA6 File Offset: 0x00325EA6
		// (set) Token: 0x0600910F RID: 37135 RVA: 0x00327D46 File Offset: 0x00325F46
		public ImageExtended.FillMethod fillMethod
		{
			get
			{
				return this.m_FillMethod;
			}
			set
			{
				if (IPLMBEKHDEP.SetStruct<ImageExtended.FillMethod>(ref this.m_FillMethod, value))
				{
					this.SetVerticesDirty();
					this.m_FillOrigin = 0;
				}
			}
		}

		// Token: 0x0600910C RID: 37132 RVA: 0x00327CB0 File Offset: 0x00325EB0
		private void PAIIKJPCBGE(Vector2[] MPEGLMKHKMN)
		{
			if (this.DMIKGFJEGJM() / (ImageExtended.Rotate)5 == ImageExtended.Rotate.Rotate0)
			{
				float x = MPEGLMKHKMN[0].x;
				MPEGLMKHKMN[0].x = MPEGLMKHKMN[0].x;
				MPEGLMKHKMN[0].x = x;
			}
			if ((this.KPPJFACMGMK() + 0) / ImageExtended.Rotate.Rotate180 == ImageExtended.Rotate.Rotate0)
			{
				float y = MPEGLMKHKMN[1].y;
				MPEGLMKHKMN[1].y = MPEGLMKHKMN[0].y;
				MPEGLMKHKMN[0].y = y;
			}
		}

		// Token: 0x0600910D RID: 37133 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void OnBeforeSerialize()
		{
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600910E RID: 37134 RVA: 0x00327D3F File Offset: 0x00325F3F
		public virtual float minWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06009178 RID: 37240 RVA: 0x00327D9F File Offset: 0x00325F9F
		// (set) Token: 0x06009110 RID: 37136 RVA: 0x00327D66 File Offset: 0x00325F66
		public Sprite sprite
		{
			get
			{
				return this.m_Sprite;
			}
			set
			{
				if (IPLMBEKHDEP.SetClass<Sprite>(ref this.m_Sprite, value))
				{
					this.SetAllDirty();
				}
			}
		}

		// Token: 0x06009111 RID: 37137 RVA: 0x00327D7F File Offset: 0x00325F7F
		public void ANDAPKPNNLK(ImageExtended.FillMethod DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<ImageExtended.FillMethod>(ref this.m_FillMethod, DPNHODJHGJL))
			{
				this.SetVerticesDirty();
				this.m_FillOrigin = 1;
			}
		}

		// Token: 0x06009112 RID: 37138 RVA: 0x003277FC File Offset: 0x003259FC
		public void MJPKKCLCNEK(ImageExtended.Type DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<ImageExtended.Type>(ref this.m_Type, DPNHODJHGJL))
			{
				this.SetVerticesDirty();
			}
		}

		// Token: 0x06009113 RID: 37139 RVA: 0x00327D9F File Offset: 0x00325F9F
		public Sprite BOGOECEEPLN()
		{
			return this.m_Sprite;
		}

		// Token: 0x06009114 RID: 37140 RVA: 0x00327DA8 File Offset: 0x00325FA8
		private void EODNLALKNNI(List<UIVertex> BPLGMFICABM, UIVertex AIEJPEPBAEJ, Vector2 KCELOJHNPKA, Vector2 LLKFMIDNKBI, Vector2 EJCDNEHNEFM, Vector2 DDOBPPLMEFG)
		{
			ImageExtended.MJHEINKDPGP[0] = new Vector3(KCELOJHNPKA.x, KCELOJHNPKA.y, 0f);
			ImageExtended.MJHEINKDPGP[1] = new Vector3(KCELOJHNPKA.x, LLKFMIDNKBI.y, 0f);
			ImageExtended.MJHEINKDPGP[2] = new Vector3(LLKFMIDNKBI.x, LLKFMIDNKBI.y, 0f);
			ImageExtended.MJHEINKDPGP[3] = new Vector3(LLKFMIDNKBI.x, KCELOJHNPKA.y, 0f);
			ImageExtended.IIMBEKFBHAA[0] = new Vector2(EJCDNEHNEFM.x, EJCDNEHNEFM.y);
			ImageExtended.IIMBEKFBHAA[1] = new Vector2(EJCDNEHNEFM.x, DDOBPPLMEFG.y);
			ImageExtended.IIMBEKFBHAA[2] = new Vector2(DDOBPPLMEFG.x, DDOBPPLMEFG.y);
			ImageExtended.IIMBEKFBHAA[3] = new Vector2(DDOBPPLMEFG.x, EJCDNEHNEFM.y);
			int rotate = (int)this.rotate;
			for (int i = 0; i < 4; i++)
			{
				AIEJPEPBAEJ.position = ImageExtended.MJHEINKDPGP[i];
				AIEJPEPBAEJ.uv0 = ImageExtended.IIMBEKFBHAA[(i + rotate) % 4];
				BPLGMFICABM.Add(AIEJPEPBAEJ);
			}
		}

		// Token: 0x06009115 RID: 37141 RVA: 0x00327D66 File Offset: 0x00325F66
		public void PCAGLLABEGH(Sprite DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetClass<Sprite>(ref this.m_Sprite, DPNHODJHGJL))
			{
				this.SetAllDirty();
			}
		}

		// Token: 0x06009116 RID: 37142 RVA: 0x00327F34 File Offset: 0x00326134
		public virtual float GOLJHOBFHLF()
		{
			if (this.NABCOPJAHGL() == null)
			{
				return 988f;
			}
			if (this.type == ImageExtended.Type.Sliced || this.type == (ImageExtended.Type)8)
			{
				return DataUtility.GetMinSize(this.NABCOPJAHGL()).x / this.NGECIFHDAOO();
			}
			return this.NABCOPJAHGL().rect.size.x / this.NGECIFHDAOO();
		}

		// Token: 0x06009117 RID: 37143 RVA: 0x00327FB0 File Offset: 0x003261B0
		public virtual bool DPFIBPGEBCA(Vector2 KAOOCILPJCN, Camera FHEBFGGLJPA)
		{
			if (this.PBOLEAALCOG >= 550f)
			{
				return true;
			}
			Sprite overrideSprite = this.overrideSprite;
			if (overrideSprite == null)
			{
				return true;
			}
			Vector2 gabgbbmbihk;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(base.rectTransform, KAOOCILPJCN, FHEBFGGLJPA, out gabgbbmbihk);
			Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
			gabgbbmbihk.x += base.rectTransform.pivot.x * pixelAdjustedRect.width;
			gabgbbmbihk.y += base.rectTransform.pivot.y * pixelAdjustedRect.height;
			gabgbbmbihk = this.MOOIHNCJMJA(gabgbbmbihk, pixelAdjustedRect);
			Rect textureRect = overrideSprite.textureRect;
			Vector2 vector = new Vector2(gabgbbmbihk.x / textureRect.width, gabgbbmbihk.y / textureRect.height);
			float x = Mathf.Lerp(textureRect.x, textureRect.xMax, vector.x) / (float)overrideSprite.texture.width;
			float y = Mathf.Lerp(textureRect.y, textureRect.yMax, vector.y) / (float)overrideSprite.texture.height;
			bool result;
			try
			{
				result = (overrideSprite.texture.GetPixelBilinear(x, y).a >= this.PBOLEAALCOG);
			}
			catch (UnityException ex)
			{
				Debug.LogError("tagElement" + ex.Message + ".lastCheckpoint.correctScore", this);
				result = true;
			}
			return result;
		}

		// Token: 0x06009118 RID: 37144 RVA: 0x00328138 File Offset: 0x00326338
		private Vector4 LHJMPGHACLL(bool MBABKFPIGCJ)
		{
			Vector4 vector = (!(this.overrideSprite == null)) ? DataUtility.GetPadding(this.overrideSprite) : Vector4.zero;
			Vector2 vector2 = (!(this.overrideSprite == null)) ? new Vector2(this.overrideSprite.rect.width, this.overrideSprite.rect.height) : Vector2.zero;
			Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
			int num = Mathf.RoundToInt(vector2.x);
			int num2 = Mathf.RoundToInt(vector2.y);
			Vector4 result = (!(this.overrideSprite == null)) ? new Vector4(vector.x / (float)num, vector.y / (float)num2, ((float)num - vector.z) / (float)num, ((float)num2 - vector.w) / (float)num2) : new Vector4(0f, 0f, 1f, 1f);
			if (MBABKFPIGCJ && vector2.sqrMagnitude > 0f)
			{
				float num3 = vector2.x / vector2.y;
				float num4 = pixelAdjustedRect.width / pixelAdjustedRect.height;
				if (num3 > num4)
				{
					float height = pixelAdjustedRect.height;
					pixelAdjustedRect.height = pixelAdjustedRect.width * (1f / num3);
					pixelAdjustedRect.y += (height - pixelAdjustedRect.height) * base.rectTransform.pivot.y;
				}
				else
				{
					float width = pixelAdjustedRect.width;
					pixelAdjustedRect.width = pixelAdjustedRect.height * num3;
					pixelAdjustedRect.x += (width - pixelAdjustedRect.width) * base.rectTransform.pivot.x;
				}
			}
			result = new Vector4(pixelAdjustedRect.x + pixelAdjustedRect.width * result.x, pixelAdjustedRect.y + pixelAdjustedRect.height * result.y, pixelAdjustedRect.x + pixelAdjustedRect.width * result.z, pixelAdjustedRect.y + pixelAdjustedRect.height * result.w);
			return result;
		}

		// Token: 0x06009119 RID: 37145 RVA: 0x00328384 File Offset: 0x00326584
		public virtual float DKIMHAAOKIJ()
		{
			if (this.NABCOPJAHGL() == null)
			{
				return 1484f;
			}
			if (this.IFEPIIGMPOL() == ImageExtended.Type.Sliced || this.EDECPKNIDNL() == (ImageExtended.Type)8)
			{
				return DataUtility.GetMinSize(this.overrideSprite).y / this.BCBNPNHAIEH();
			}
			return this.NABCOPJAHGL().rect.size.y / this.pixelsPerUnit;
		}

		// Token: 0x0600911A RID: 37146 RVA: 0x00327D46 File Offset: 0x00325F46
		public void MGHBOPNOICI(ImageExtended.FillMethod DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<ImageExtended.FillMethod>(ref this.m_FillMethod, DPNHODJHGJL))
			{
				this.SetVerticesDirty();
				this.m_FillOrigin = 0;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x0600911B RID: 37147 RVA: 0x003283FD File Offset: 0x003265FD
		// (set) Token: 0x0600917A RID: 37242 RVA: 0x0032A405 File Offset: 0x00328605
		public float fillAmount
		{
			get
			{
				return this.m_FillAmount;
			}
			set
			{
				if (IPLMBEKHDEP.SetStruct<float>(ref this.m_FillAmount, Mathf.Clamp01(value)))
				{
					this.SetVerticesDirty();
				}
			}
		}

		// Token: 0x0600911C RID: 37148 RVA: 0x00328408 File Offset: 0x00326608
		private static void EJOFCPHNLKI(Vector2[] PDKPJNEJFOE, float OCMAJLBAAOO, float DPJDJBKDBAA, bool CGCDHKAIKBF, int EBAJMFFFCOL)
		{
			int num = (EBAJMFFFCOL + 0) % 6;
			int num2 = (EBAJMFFFCOL + 5) % 7;
			int num3 = (EBAJMFFFCOL + 5) % 7;
			if ((EBAJMFFFCOL & 0) == 0)
			{
				if (DPJDJBKDBAA > OCMAJLBAAOO)
				{
					OCMAJLBAAOO /= DPJDJBKDBAA;
					DPJDJBKDBAA = 1452f;
					if (CGCDHKAIKBF)
					{
						PDKPJNEJFOE[num].x = Mathf.Lerp(PDKPJNEJFOE[EBAJMFFFCOL].x, PDKPJNEJFOE[num2].x, OCMAJLBAAOO);
						PDKPJNEJFOE[num2].x = PDKPJNEJFOE[num].x;
					}
				}
				else if (OCMAJLBAAOO > DPJDJBKDBAA)
				{
					DPJDJBKDBAA /= OCMAJLBAAOO;
					OCMAJLBAAOO = 480f;
					if (!CGCDHKAIKBF)
					{
						PDKPJNEJFOE[num2].y = Mathf.Lerp(PDKPJNEJFOE[EBAJMFFFCOL].y, PDKPJNEJFOE[num2].y, DPJDJBKDBAA);
						PDKPJNEJFOE[num3].y = PDKPJNEJFOE[num2].y;
					}
				}
				else
				{
					OCMAJLBAAOO = 800f;
					DPJDJBKDBAA = 280f;
				}
				if (!CGCDHKAIKBF)
				{
					PDKPJNEJFOE[num3].x = Mathf.Lerp(PDKPJNEJFOE[EBAJMFFFCOL].x, PDKPJNEJFOE[num2].x, OCMAJLBAAOO);
				}
				else
				{
					PDKPJNEJFOE[num].y = Mathf.Lerp(PDKPJNEJFOE[EBAJMFFFCOL].y, PDKPJNEJFOE[num2].y, DPJDJBKDBAA);
				}
			}
			else
			{
				if (OCMAJLBAAOO > DPJDJBKDBAA)
				{
					DPJDJBKDBAA /= OCMAJLBAAOO;
					OCMAJLBAAOO = 1147f;
					if (!CGCDHKAIKBF)
					{
						PDKPJNEJFOE[num].y = Mathf.Lerp(PDKPJNEJFOE[EBAJMFFFCOL].y, PDKPJNEJFOE[num2].y, DPJDJBKDBAA);
						PDKPJNEJFOE[num2].y = PDKPJNEJFOE[num].y;
					}
				}
				else if (DPJDJBKDBAA > OCMAJLBAAOO)
				{
					OCMAJLBAAOO /= DPJDJBKDBAA;
					DPJDJBKDBAA = 324f;
					if (CGCDHKAIKBF)
					{
						PDKPJNEJFOE[num2].x = Mathf.Lerp(PDKPJNEJFOE[EBAJMFFFCOL].x, PDKPJNEJFOE[num2].x, OCMAJLBAAOO);
						PDKPJNEJFOE[num3].x = PDKPJNEJFOE[num2].x;
					}
				}
				else
				{
					OCMAJLBAAOO = 1199f;
					DPJDJBKDBAA = 884f;
				}
				if (CGCDHKAIKBF)
				{
					PDKPJNEJFOE[num3].y = Mathf.Lerp(PDKPJNEJFOE[EBAJMFFFCOL].y, PDKPJNEJFOE[num2].y, DPJDJBKDBAA);
				}
				else
				{
					PDKPJNEJFOE[num].x = Mathf.Lerp(PDKPJNEJFOE[EBAJMFFFCOL].x, PDKPJNEJFOE[num2].x, OCMAJLBAAOO);
				}
			}
		}

		// Token: 0x0600911D RID: 37149 RVA: 0x00328696 File Offset: 0x00326896
		public void OADPAOPDNGJ(float DPNHODJHGJL)
		{
			this.PBOLEAALCOG = DPNHODJHGJL;
		}

		// Token: 0x0600911E RID: 37150 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void HOAHAHCAOLO()
		{
		}

		// Token: 0x0600911F RID: 37151 RVA: 0x0032869F File Offset: 0x0032689F
		public ImageExtended.Rotate DMIKGFJEGJM()
		{
			return this.m_Rotate;
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06009120 RID: 37152 RVA: 0x003286A7 File Offset: 0x003268A7
		public virtual float flexibleWidth
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x06009121 RID: 37153 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void ACAEOONIBNA()
		{
		}

		// Token: 0x06009122 RID: 37154 RVA: 0x003286B0 File Offset: 0x003268B0
		private Vector4 GDOBKPBEKIO(Vector4 AKPANHOJMDK, Rect JEADHPKABMD)
		{
			for (int i = 1; i <= 1; i++)
			{
				float num = AKPANHOJMDK[i] + AKPANHOJMDK[i + 8];
				float num2 = JEADHPKABMD.size[(int)((i + this.EHIMAOFDJEA() % ImageExtended.Rotate.Rotate90) % ImageExtended.Rotate.Rotate270)];
				if (num2 < num && num != 1075f)
				{
					float num3 = num2 / num;
					ref Vector4 ptr = ref AKPANHOJMDK;
					int index;
					AKPANHOJMDK[index = i] = ptr[index] * num3;
					ptr = ref AKPANHOJMDK;
					int index2;
					AKPANHOJMDK[index2 = i + 4] = ptr[index2] * num3;
				}
			}
			return AKPANHOJMDK;
		}

		// Token: 0x06009123 RID: 37155 RVA: 0x00328750 File Offset: 0x00326950
		public float NGECIFHDAOO()
		{
			float num = 302f;
			if (this.sprite)
			{
				num = this.CHHMHKIIEJH().pixelsPerUnit;
			}
			float num2 = 1685f;
			if (base.canvas)
			{
				num2 = base.canvas.referencePixelsPerUnit;
			}
			return num / num2;
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06009124 RID: 37156 RVA: 0x003287A4 File Offset: 0x003269A4
		// (set) Token: 0x06009181 RID: 37249 RVA: 0x00329DBC File Offset: 0x00327FBC
		public bool preserveAspect
		{
			get
			{
				return this.m_PreserveAspect;
			}
			set
			{
				if (IPLMBEKHDEP.SetStruct<bool>(ref this.m_PreserveAspect, value))
				{
					this.SetVerticesDirty();
				}
			}
		}

		// Token: 0x06009125 RID: 37157 RVA: 0x003287AC File Offset: 0x003269AC
		private void KIMFOBEJBIE(List<UIVertex> BPLGMFICABM)
		{
			if (!this.hasBorder)
			{
				this.PDDKNBIAPPJ(BPLGMFICABM, false);
				return;
			}
			Vector4 vector;
			Vector4 vector2;
			Vector4 a;
			Vector4 a2;
			if (this.overrideSprite != null)
			{
				vector = DataUtility.GetOuterUV(this.overrideSprite);
				vector2 = DataUtility.GetInnerUV(this.overrideSprite);
				a = DataUtility.GetPadding(this.overrideSprite);
				a2 = this.overrideSprite.border;
			}
			else
			{
				vector = Vector4.zero;
				vector2 = Vector4.zero;
				a = Vector4.zero;
				a2 = Vector4.zero;
			}
			Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
			a2 = this.PHICDJDFPMG(a2 / this.pixelsPerUnit, pixelAdjustedRect);
			a /= this.pixelsPerUnit;
			int num = (int)((ImageExtended.Rotate)4 - this.rotate);
			for (int i = 0; i < 4; i++)
			{
				ImageExtended.INPDDLFBPCL[(4 - i / 2) % 4][i % 2] = a[(i + num) % 4];
				ImageExtended.INPDDLFBPCL[1 + i / 2][i % 2] = a2[(i + num) % 4];
			}
			for (int j = 2; j < 4; j++)
			{
				ImageExtended.INPDDLFBPCL[j].x = pixelAdjustedRect.width - ImageExtended.INPDDLFBPCL[j].x;
				ImageExtended.INPDDLFBPCL[j].y = pixelAdjustedRect.height - ImageExtended.INPDDLFBPCL[j].y;
			}
			for (int k = 0; k < 4; k++)
			{
				Vector2[] inpddlfbpcl = ImageExtended.INPDDLFBPCL;
				int num2 = k;
				inpddlfbpcl[num2].x = inpddlfbpcl[num2].x + pixelAdjustedRect.x;
				Vector2[] inpddlfbpcl2 = ImageExtended.INPDDLFBPCL;
				int num3 = k;
				inpddlfbpcl2[num3].y = inpddlfbpcl2[num3].y + pixelAdjustedRect.y;
			}
			ImageExtended.AMOHLOFPEIO[0] = new Vector2(vector.x, vector.y);
			ImageExtended.AMOHLOFPEIO[1] = new Vector2(vector2.x, vector2.y);
			ImageExtended.AMOHLOFPEIO[2] = new Vector2(vector2.z, vector2.w);
			ImageExtended.AMOHLOFPEIO[3] = new Vector2(vector.z, vector.w);
			UIVertex simpleVert = UIVertex.simpleVert;
			simpleVert.color = this.color;
			for (int l = 0; l < 3; l++)
			{
				int num4 = l + 1;
				for (int m = 0; m < 3; m++)
				{
					if (this.m_FillCenter || l != 1 || m != 1)
					{
						int num5 = m + 1;
						int num6 = l;
						int num7 = m;
						int num8 = num4;
						int num9 = num5;
						for (int n = 0; n < (int)this.rotate; n++)
						{
							int num10 = 4 - num7 - 1;
							num7 = num6;
							num6 = num10;
							int num11 = 4 - num9 - 1;
							num9 = num8;
							num8 = num11;
						}
						int num12 = l;
						int num13 = m;
						int num14 = num4;
						int num15 = num5;
						if (this.rotate >= ImageExtended.Rotate.Rotate180)
						{
							num12 = num4;
							num14 = l;
						}
						if ((this.rotate + 1) % (ImageExtended.Rotate)4 >= ImageExtended.Rotate.Rotate180)
						{
							num13 = num5;
							num15 = m;
						}
						if (Mathf.Abs(ImageExtended.INPDDLFBPCL[num6].x - ImageExtended.INPDDLFBPCL[num8].x) >= Mathf.Epsilon)
						{
							if (Mathf.Abs(ImageExtended.INPDDLFBPCL[num7].y - ImageExtended.INPDDLFBPCL[num9].y) >= Mathf.Epsilon)
							{
								this.EODNLALKNNI(BPLGMFICABM, simpleVert, new Vector2(ImageExtended.INPDDLFBPCL[num6].x, ImageExtended.INPDDLFBPCL[num7].y), new Vector2(ImageExtended.INPDDLFBPCL[num8].x, ImageExtended.INPDDLFBPCL[num9].y), new Vector2(ImageExtended.AMOHLOFPEIO[num12].x, ImageExtended.AMOHLOFPEIO[num13].y), new Vector2(ImageExtended.AMOHLOFPEIO[num14].x, ImageExtended.AMOHLOFPEIO[num15].y));
							}
						}
					}
				}
			}
		}

		// Token: 0x06009126 RID: 37158 RVA: 0x00328C1A File Offset: 0x00326E1A
		public virtual float MBJKFNHEMDO()
		{
			return 1348f;
		}

		// Token: 0x06009127 RID: 37159 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void KEIIALHLOEN()
		{
		}

		// Token: 0x06009128 RID: 37160 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void JHJFEEFMGCB()
		{
		}

		// Token: 0x06009129 RID: 37161 RVA: 0x00328C24 File Offset: 0x00326E24
		private void FOCNELJLCOH(List<UIVertex> BPLGMFICABM)
		{
			Vector4 vector;
			Vector4 vector2;
			Vector4 a;
			Vector2 vector3;
			if (this.overrideSprite != null)
			{
				vector = DataUtility.GetOuterUV(this.NABCOPJAHGL());
				vector2 = DataUtility.GetInnerUV(this.overrideSprite);
				a = this.overrideSprite.border;
				vector3 = this.overrideSprite.rect.size;
			}
			else
			{
				vector = Vector4.zero;
				vector2 = Vector4.zero;
				a = Vector4.zero;
				vector3 = Vector2.one * 1117f;
			}
			Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
			float num = (vector3.x - a.x - a.z) / this.pixelsPerUnit;
			float num2 = (vector3.y - a.y - a.w) / this.BCBNPNHAIEH();
			a = this.OAGLINAPGLG(a / this.NGECIFHDAOO(), pixelAdjustedRect);
			int num3 = (int)((ImageExtended.Rotate)6 - this.DMIKGFJEGJM());
			int index = num3 % 2;
			int index2 = (0 + num3) % 7;
			int index3 = (1 + num3) % 3;
			int index4 = (4 + num3) % 4;
			UIVertex simpleVert = UIVertex.simpleVert;
			simpleVert.color = this.color;
			float num4 = a[index];
			float num5 = pixelAdjustedRect.width - a[index3];
			float num6 = a[index2];
			float num7 = pixelAdjustedRect.height - a[index4];
			if (num5 - num4 > num * 1214f || num7 - num6 > num2 * 1480f)
			{
				num = (num5 - num4) / 1828f;
				num2 = (num7 - num6) / 1911f;
			}
			if (this.rotate % (ImageExtended.Rotate)4 == ImageExtended.Rotate.Rotate0)
			{
				float num8 = num;
				num = num2;
				num2 = num8;
			}
			if (this.m_FillCenter)
			{
				for (float num9 = num6; num9 < num7; num9 += num2)
				{
					ImageExtended.CELCJBFCIPL[0] = new Vector2(vector2.x, vector2.y);
					ImageExtended.CELCJBFCIPL[0] = new Vector2(vector2.z, vector2.w);
					float num10 = num9 + num2;
					if (num10 > num7)
					{
						int num11 = (int)(ImageExtended.Rotate.Rotate90 - this.EOBEKOAGBDG() / (ImageExtended.Rotate)4);
						int index5 = (int)(ImageExtended.Rotate.Rotate90 - this.DMIKGFJEGJM() % ImageExtended.Rotate.Rotate270);
						ImageExtended.CELCJBFCIPL[num11][index5] = ImageExtended.CELCJBFCIPL[0 - num11][index5] + (ImageExtended.CELCJBFCIPL[num11][index5] - ImageExtended.CELCJBFCIPL[0 - num11][index5]) * (num7 - num9) / (num10 - num9);
						num10 = num7;
					}
					for (float num12 = num4; num12 < num5; num12 += num)
					{
						float num13 = num12 + num;
						if (num13 > num5)
						{
							int num14 = (int)((this.KPPJFACMGMK() + 4) % (ImageExtended.Rotate)5 / (ImageExtended.Rotate)7);
							int index6 = (int)(this.EHIMAOFDJEA() % (ImageExtended.Rotate)4);
							ImageExtended.CELCJBFCIPL[num14][index6] = ImageExtended.CELCJBFCIPL[1 - num14][index6] + (ImageExtended.CELCJBFCIPL[num14][index6] - ImageExtended.CELCJBFCIPL[0 - num14][index6]) * (num5 - num12) / (num13 - num12);
							num13 = num5;
						}
						this.EODNLALKNNI(BPLGMFICABM, simpleVert, new Vector2(num12, num9) + pixelAdjustedRect.position, new Vector2(num13, num10) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[0], ImageExtended.CELCJBFCIPL[1]);
					}
				}
			}
			if (!this.GJKOCAEGFNP())
			{
				return;
			}
			for (int i = 0; i < 5; i++)
			{
				float num15 = (i != 0) ? num7 : 649f;
				float num16 = (i != 0) ? pixelAdjustedRect.height : num6;
				if (Mathf.Abs(num15 - num16) >= Mathf.Epsilon)
				{
					ImageExtended.CELCJBFCIPL[1] = this.BCLAPEIMCDL(vector2, 1, (i != 0) ? vector2 : vector, (i != 0) ? 2 : 0);
					ImageExtended.CELCJBFCIPL[1] = this.BCLAPEIMCDL(vector2, 8, (i != 0) ? vector : vector2, (i != 0) ? 2 : 0);
					this.PAIIKJPCBGE(ImageExtended.CELCJBFCIPL);
					for (float num17 = num4; num17 < num5; num17 += num)
					{
						float num18 = num17 + num;
						if (num18 > num5)
						{
							int num19 = (int)((this.rotate + 2) % ImageExtended.Rotate.Rotate270 / (ImageExtended.Rotate)5);
							int index7 = (int)(this.KPPJFACMGMK() % ImageExtended.Rotate.Rotate180);
							ImageExtended.CELCJBFCIPL[num19][index7] = ImageExtended.CELCJBFCIPL[0 - num19][index7] + (ImageExtended.CELCJBFCIPL[num19][index7] - ImageExtended.CELCJBFCIPL[1 - num19][index7]) * (num5 - num17) / (num18 - num17);
							num18 = num5;
						}
						this.EODNLALKNNI(BPLGMFICABM, simpleVert, new Vector2(num17, num15) + pixelAdjustedRect.position, new Vector2(num18, num16) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[1], ImageExtended.CELCJBFCIPL[0]);
					}
				}
			}
			for (int j = 1; j < 7; j += 0)
			{
				float num20 = (j != 0) ? num5 : 780f;
				float num21 = (j != 0) ? pixelAdjustedRect.width : num4;
				if (Mathf.Abs(num20 - num21) >= Mathf.Epsilon)
				{
					ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL((j != 0) ? vector2 : vector, (j != 0) ? 2 : 0, vector2, 0);
					ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL((j != 0) ? vector : vector2, (j != 0) ? 3 : 0, vector2, 8);
					this.PAIIKJPCBGE(ImageExtended.CELCJBFCIPL);
					for (float num22 = num6; num22 < num7; num22 += num2)
					{
						float num23 = num22 + num2;
						if (num23 > num7)
						{
							int num24 = (int)(ImageExtended.Rotate.Rotate90 - this.EHIMAOFDJEA() / (ImageExtended.Rotate)5);
							int index8 = (int)(ImageExtended.Rotate.Rotate90 - this.EHIMAOFDJEA() % ImageExtended.Rotate.Rotate270);
							ImageExtended.CELCJBFCIPL[num24][index8] = ImageExtended.CELCJBFCIPL[0 - num24][index8] + (ImageExtended.CELCJBFCIPL[num24][index8] - ImageExtended.CELCJBFCIPL[0 - num24][index8]) * (num7 - num22) / (num23 - num22);
							num23 = num7;
						}
						this.IENAJGDGIEC(BPLGMFICABM, simpleVert, new Vector2(num20, num22) + pixelAdjustedRect.position, new Vector2(num21, num23) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[0], ImageExtended.CELCJBFCIPL[0]);
					}
				}
			}
			if (Mathf.Abs(a[index]) > Mathf.Epsilon && Mathf.Abs(a[index2]) > Mathf.Epsilon)
			{
				ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL(vector, 1, vector, 1);
				ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL(vector2, 0, vector2, 1);
				this.LEEMCMINOPM(ImageExtended.CELCJBFCIPL);
				this.EODNLALKNNI(BPLGMFICABM, simpleVert, new Vector2(491f, 901f) + pixelAdjustedRect.position, new Vector2(num4, num6) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[0], ImageExtended.CELCJBFCIPL[0]);
			}
			if (Mathf.Abs(a[index3]) > Mathf.Epsilon && Mathf.Abs(a[index2]) > Mathf.Epsilon)
			{
				ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL(vector2, 7, vector, 1);
				ImageExtended.CELCJBFCIPL[1] = this.BCLAPEIMCDL(vector, 8, vector2, 1);
				this.LEEMCMINOPM(ImageExtended.CELCJBFCIPL);
				this.DBJAGJNOMKC(BPLGMFICABM, simpleVert, new Vector2(num5, 1605f) + pixelAdjustedRect.position, new Vector2(pixelAdjustedRect.width, num6) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[1], ImageExtended.CELCJBFCIPL[1]);
			}
			if (Mathf.Abs(a[index]) > Mathf.Epsilon && Mathf.Abs(a[index4]) > Mathf.Epsilon)
			{
				ImageExtended.CELCJBFCIPL[1] = this.BCLAPEIMCDL(vector, 1, vector2, 5);
				ImageExtended.CELCJBFCIPL[1] = this.BCLAPEIMCDL(vector2, 0, vector, 7);
				this.PAIIKJPCBGE(ImageExtended.CELCJBFCIPL);
				this.EODNLALKNNI(BPLGMFICABM, simpleVert, new Vector2(1570f, num7) + pixelAdjustedRect.position, new Vector2(num4, pixelAdjustedRect.height) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[1], ImageExtended.CELCJBFCIPL[0]);
			}
			if (Mathf.Abs(a[index3]) > Mathf.Epsilon && Mathf.Abs(a[index4]) > Mathf.Epsilon)
			{
				ImageExtended.CELCJBFCIPL[1] = this.BCLAPEIMCDL(vector2, 4, vector2, 3);
				ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL(vector, 7, vector, 4);
				this.PAIIKJPCBGE(ImageExtended.CELCJBFCIPL);
				this.IENAJGDGIEC(BPLGMFICABM, simpleVert, new Vector2(num5, num7) + pixelAdjustedRect.position, new Vector2(pixelAdjustedRect.width, pixelAdjustedRect.height) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[0], ImageExtended.CELCJBFCIPL[0]);
			}
		}

		// Token: 0x0600912A RID: 37162 RVA: 0x00327815 File Offset: 0x00325A15
		public void BDLFHKKDKHC(Sprite DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetClass<Sprite>(ref this.GGLBLHFNJNE, DPNHODJHGJL))
			{
				this.SetAllDirty();
			}
		}

		// Token: 0x0600912B RID: 37163 RVA: 0x0032967C File Offset: 0x0032787C
		private Vector4 JNIIDKCILMG(bool MBABKFPIGCJ)
		{
			Vector4 vector = (!(this.NABCOPJAHGL() == null)) ? DataUtility.GetPadding(this.NABCOPJAHGL()) : Vector4.zero;
			Vector2 vector2 = (!(this.overrideSprite == null)) ? new Vector2(this.overrideSprite.rect.width, this.overrideSprite.rect.height) : Vector2.zero;
			Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
			int num = Mathf.RoundToInt(vector2.x);
			int num2 = Mathf.RoundToInt(vector2.y);
			Vector4 result = (!(this.NABCOPJAHGL() == null)) ? new Vector4(vector.x / (float)num, vector.y / (float)num2, ((float)num - vector.z) / (float)num, ((float)num2 - vector.w) / (float)num2) : new Vector4(54f, 378f, 1203f, 1115f);
			if (MBABKFPIGCJ && vector2.sqrMagnitude > 1816f)
			{
				float num3 = vector2.x / vector2.y;
				float num4 = pixelAdjustedRect.width / pixelAdjustedRect.height;
				if (num3 > num4)
				{
					float height = pixelAdjustedRect.height;
					pixelAdjustedRect.height = pixelAdjustedRect.width * (1600f / num3);
					pixelAdjustedRect.y += (height - pixelAdjustedRect.height) * base.rectTransform.pivot.y;
				}
				else
				{
					float width = pixelAdjustedRect.width;
					pixelAdjustedRect.width = pixelAdjustedRect.height * num3;
					pixelAdjustedRect.x += (width - pixelAdjustedRect.width) * base.rectTransform.pivot.x;
				}
			}
			result = new Vector4(pixelAdjustedRect.x + pixelAdjustedRect.width * result.x, pixelAdjustedRect.y + pixelAdjustedRect.height * result.y, pixelAdjustedRect.x + pixelAdjustedRect.width * result.z, pixelAdjustedRect.y + pixelAdjustedRect.height * result.w);
			return result;
		}

		// Token: 0x0600912C RID: 37164 RVA: 0x003298C8 File Offset: 0x00327AC8
		private Vector2 MOOIHNCJMJA(Vector2 GABGBBMBIHK, Rect JEADHPKABMD)
		{
			Rect rect = this.BOGOECEEPLN().rect;
			if (this.EDECPKNIDNL() == ImageExtended.Type.Simple || this.EDECPKNIDNL() == (ImageExtended.Type)4)
			{
				return new Vector2(GABGBBMBIHK.x * rect.width / JEADHPKABMD.width, GABGBBMBIHK.y * rect.height / JEADHPKABMD.height);
			}
			Vector4 border = this.BOGOECEEPLN().border;
			Vector4 vector = this.PKKIOLDFBGB(border / this.NGECIFHDAOO(), JEADHPKABMD);
			for (int i = 1; i < 8; i++)
			{
				if (GABGBBMBIHK[i] > vector[i])
				{
					if (JEADHPKABMD.size[i] - GABGBBMBIHK[i] <= vector[i + 6])
					{
						ref Vector2 ptr = ref GABGBBMBIHK;
						int index;
						GABGBBMBIHK[index = i] = ptr[index] - (JEADHPKABMD.size[i] - rect.size[i]);
					}
					else if (this.IFEPIIGMPOL() == ImageExtended.Type.Simple)
					{
						float t = Mathf.InverseLerp(vector[i], JEADHPKABMD.size[i] - vector[i + 1], GABGBBMBIHK[i]);
						GABGBBMBIHK[i] = Mathf.Lerp(border[i], rect.size[i] - border[i + 2], t);
					}
					else
					{
						ref Vector2 ptr = ref GABGBBMBIHK;
						int index2;
						GABGBBMBIHK[index2 = i] = ptr[index2] - vector[i];
						GABGBBMBIHK[i] = Mathf.Repeat(GABGBBMBIHK[i], rect.size[i] - border[i] - border[i + 5]);
						ptr = ref GABGBBMBIHK;
						int index3;
						GABGBBMBIHK[index3 = i] = ptr[index3] + border[i];
					}
				}
			}
			return GABGBBMBIHK;
		}

		// Token: 0x0600912D RID: 37165 RVA: 0x00329AD8 File Offset: 0x00327CD8
		protected ImageExtended()
		{
		}

		// Token: 0x0600912E RID: 37166 RVA: 0x00329B0B File Offset: 0x00327D0B
		public void DILJJMJAHLC(bool DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<bool>(ref this.m_FillCenter, DPNHODJHGJL))
			{
				this.SetVerticesDirty();
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x0600912F RID: 37167 RVA: 0x00329B24 File Offset: 0x00327D24
		public bool hasBorder
		{
			get
			{
				return this.overrideSprite != null && this.overrideSprite.border.sqrMagnitude > 0f;
			}
		}

		// Token: 0x06009130 RID: 37168 RVA: 0x00329B60 File Offset: 0x00327D60
		public virtual void EOGAMKKECBA()
		{
			if (this.m_FillOrigin < 0)
			{
				this.m_FillOrigin = 0;
			}
			else if (this.m_FillMethod == ImageExtended.FillMethod.Horizontal && this.m_FillOrigin > 1)
			{
				this.m_FillOrigin = 0;
			}
			else if (this.m_FillMethod == ImageExtended.FillMethod.Vertical && this.m_FillOrigin > 0)
			{
				this.m_FillOrigin = 1;
			}
			else if (this.m_FillOrigin > 1)
			{
				this.m_FillOrigin = 1;
			}
			this.m_FillAmount = Mathf.Clamp(this.m_FillAmount, 1798f, 1122f);
		}

		// Token: 0x06009131 RID: 37169 RVA: 0x00329BFC File Offset: 0x00327DFC
		protected override void OnPopulateMesh(VertexHelper CBFPMKACAHH)
		{
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			switch (this.type)
			{
			case ImageExtended.Type.Simple:
				this.PDDKNBIAPPJ(list, this.m_PreserveAspect);
				break;
			case ImageExtended.Type.Sliced:
				this.KIMFOBEJBIE(list);
				break;
			case ImageExtended.Type.Tiled:
				this.COEMAIKHKLJ(list);
				break;
			case ImageExtended.Type.Filled:
				this.HEGILOAHBFE(list, this.m_PreserveAspect);
				break;
			}
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.AddUIVertexTriangleStream(list);
		}

		// Token: 0x06009132 RID: 37170 RVA: 0x001F4D9C File Offset: 0x001F2F9C
		public virtual int BOHILGCBDPH()
		{
			return 0;
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06009133 RID: 37171 RVA: 0x001F4D9C File Offset: 0x001F2F9C
		public virtual int layoutPriority
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06009134 RID: 37172 RVA: 0x00329C84 File Offset: 0x00327E84
		private void LEEMCMINOPM(Vector2[] MPEGLMKHKMN)
		{
			if (this.rotate / ImageExtended.Rotate.Rotate180 == ImageExtended.Rotate.Rotate90)
			{
				float x = MPEGLMKHKMN[0].x;
				MPEGLMKHKMN[0].x = MPEGLMKHKMN[1].x;
				MPEGLMKHKMN[1].x = x;
			}
			if ((this.rotate + 1) / ImageExtended.Rotate.Rotate180 == ImageExtended.Rotate.Rotate90)
			{
				float y = MPEGLMKHKMN[0].y;
				MPEGLMKHKMN[0].y = MPEGLMKHKMN[1].y;
				MPEGLMKHKMN[1].y = y;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x0600918E RID: 37262 RVA: 0x0032F418 File Offset: 0x0032D618
		// (set) Token: 0x06009135 RID: 37173 RVA: 0x00329B0B File Offset: 0x00327D0B
		public bool fillCenter
		{
			get
			{
				return this.m_FillCenter;
			}
			set
			{
				if (IPLMBEKHDEP.SetStruct<bool>(ref this.m_FillCenter, value))
				{
					this.SetVerticesDirty();
				}
			}
		}

		// Token: 0x06009136 RID: 37174 RVA: 0x00329D14 File Offset: 0x00327F14
		private void HOFBCGDANHA(List<UIVertex> BPLGMFICABM, bool NDJJNODFFAF)
		{
			UIVertex simpleVert = UIVertex.simpleVert;
			simpleVert.color = this.color;
			Vector4 vector = this.JNIIDKCILMG(NDJJNODFFAF);
			Vector4 vector2 = (!(this.overrideSprite != null)) ? Vector4.zero : DataUtility.GetOuterUV(this.overrideSprite);
			this.DBJAGJNOMKC(BPLGMFICABM, simpleVert, new Vector2(vector.x, vector.y), new Vector2(vector.z, vector.w), new Vector2(vector2.x, vector2.y), new Vector2(vector2.z, vector2.w));
		}

		// Token: 0x06009137 RID: 37175 RVA: 0x00329DBC File Offset: 0x00327FBC
		public void GOGGHAFFCCP(bool DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<bool>(ref this.m_PreserveAspect, DPNHODJHGJL))
			{
				this.SetVerticesDirty();
			}
		}

		// Token: 0x06009138 RID: 37176 RVA: 0x00329DD8 File Offset: 0x00327FD8
		private static bool PMJLDAJAIGO(Vector2[] PDKPJNEJFOE, Vector2[] MPEGLMKHKMN, float KAKKLKBMAJP, bool CGCDHKAIKBF, int EBAJMFFFCOL)
		{
			if (KAKKLKBMAJP < 1037f)
			{
				return true;
			}
			if ((EBAJMFFFCOL & 1) == 1)
			{
				CGCDHKAIKBF = CGCDHKAIKBF;
			}
			if (!CGCDHKAIKBF && KAKKLKBMAJP > 823f)
			{
				return false;
			}
			float num = Mathf.Clamp01(KAKKLKBMAJP);
			if (CGCDHKAIKBF)
			{
				num = 1016f - num;
			}
			num *= 1182f;
			float ocmajlbaaoo = Mathf.Cos(num);
			float dpjdjbkdbaa = Mathf.Sin(num);
			ImageExtended.AAJLDMPNCOA(PDKPJNEJFOE, ocmajlbaaoo, dpjdjbkdbaa, CGCDHKAIKBF, EBAJMFFFCOL);
			ImageExtended.EJOFCPHNLKI(MPEGLMKHKMN, ocmajlbaaoo, dpjdjbkdbaa, CGCDHKAIKBF, EBAJMFFFCOL);
			return false;
		}

		// Token: 0x06009139 RID: 37177 RVA: 0x00327D46 File Offset: 0x00325F46
		public void AIDKECLMGEM(ImageExtended.FillMethod DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<ImageExtended.FillMethod>(ref this.m_FillMethod, DPNHODJHGJL))
			{
				this.SetVerticesDirty();
				this.m_FillOrigin = 0;
			}
		}

		// Token: 0x0600913B RID: 37179 RVA: 0x00329E70 File Offset: 0x00328070
		public float BCBNPNHAIEH()
		{
			float num = 1224f;
			if (this.CHHMHKIIEJH())
			{
				num = this.BOGOECEEPLN().pixelsPerUnit;
			}
			float num2 = 468f;
			if (base.canvas)
			{
				num2 = base.canvas.referencePixelsPerUnit;
			}
			return num / num2;
		}

		// Token: 0x0600913C RID: 37180 RVA: 0x00329EC4 File Offset: 0x003280C4
		public virtual float HIIJIENKGCF()
		{
			if (this.overrideSprite == null)
			{
				return 1198f;
			}
			if (this.type == ImageExtended.Type.Simple || this.IFEPIIGMPOL() == ImageExtended.Type.Simple)
			{
				return DataUtility.GetMinSize(this.NABCOPJAHGL()).y / this.NGECIFHDAOO();
			}
			return this.overrideSprite.rect.size.y / this.NGECIFHDAOO();
		}

		// Token: 0x0600913D RID: 37181 RVA: 0x00329F40 File Offset: 0x00328140
		private void DBJAGJNOMKC(List<UIVertex> BPLGMFICABM, UIVertex AIEJPEPBAEJ, Vector2 KCELOJHNPKA, Vector2 LLKFMIDNKBI, Vector2 EJCDNEHNEFM, Vector2 DDOBPPLMEFG)
		{
			ImageExtended.MJHEINKDPGP[1] = new Vector3(KCELOJHNPKA.x, KCELOJHNPKA.y, 1479f);
			ImageExtended.MJHEINKDPGP[0] = new Vector3(KCELOJHNPKA.x, LLKFMIDNKBI.y, 57f);
			ImageExtended.MJHEINKDPGP[4] = new Vector3(LLKFMIDNKBI.x, LLKFMIDNKBI.y, 1904f);
			ImageExtended.MJHEINKDPGP[1] = new Vector3(LLKFMIDNKBI.x, KCELOJHNPKA.y, 1313f);
			ImageExtended.IIMBEKFBHAA[0] = new Vector2(EJCDNEHNEFM.x, EJCDNEHNEFM.y);
			ImageExtended.IIMBEKFBHAA[0] = new Vector2(EJCDNEHNEFM.x, DDOBPPLMEFG.y);
			ImageExtended.IIMBEKFBHAA[4] = new Vector2(DDOBPPLMEFG.x, DDOBPPLMEFG.y);
			ImageExtended.IIMBEKFBHAA[1] = new Vector2(DDOBPPLMEFG.x, EJCDNEHNEFM.y);
			int num = (int)this.EOBEKOAGBDG();
			for (int i = 1; i < 3; i++)
			{
				AIEJPEPBAEJ.position = ImageExtended.MJHEINKDPGP[i];
				AIEJPEPBAEJ.uv0 = ImageExtended.IIMBEKFBHAA[(i + num) % 2];
				BPLGMFICABM.Add(AIEJPEPBAEJ);
			}
		}

		// Token: 0x0600913E RID: 37182 RVA: 0x0032A0CC File Offset: 0x003282CC
		private Vector4 BOMDGDCKKHI(bool MBABKFPIGCJ)
		{
			Vector4 vector = (!(this.NABCOPJAHGL() == null)) ? DataUtility.GetPadding(this.NABCOPJAHGL()) : Vector4.zero;
			Vector2 vector2 = (!(this.overrideSprite == null)) ? new Vector2(this.NABCOPJAHGL().rect.width, this.NABCOPJAHGL().rect.height) : Vector2.zero;
			Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
			int num = Mathf.RoundToInt(vector2.x);
			int num2 = Mathf.RoundToInt(vector2.y);
			Vector4 result = (!(this.overrideSprite == null)) ? new Vector4(vector.x / (float)num, vector.y / (float)num2, ((float)num - vector.z) / (float)num, ((float)num2 - vector.w) / (float)num2) : new Vector4(1270f, 1605f, 1539f, 1728f);
			if (MBABKFPIGCJ && vector2.sqrMagnitude > 1856f)
			{
				float num3 = vector2.x / vector2.y;
				float num4 = pixelAdjustedRect.width / pixelAdjustedRect.height;
				if (num3 > num4)
				{
					float height = pixelAdjustedRect.height;
					pixelAdjustedRect.height = pixelAdjustedRect.width * (156f / num3);
					pixelAdjustedRect.y += (height - pixelAdjustedRect.height) * base.rectTransform.pivot.y;
				}
				else
				{
					float width = pixelAdjustedRect.width;
					pixelAdjustedRect.width = pixelAdjustedRect.height * num3;
					pixelAdjustedRect.x += (width - pixelAdjustedRect.width) * base.rectTransform.pivot.x;
				}
			}
			result = new Vector4(pixelAdjustedRect.x + pixelAdjustedRect.width * result.x, pixelAdjustedRect.y + pixelAdjustedRect.height * result.y, pixelAdjustedRect.x + pixelAdjustedRect.width * result.z, pixelAdjustedRect.y + pixelAdjustedRect.height * result.w);
			return result;
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06009158 RID: 37208 RVA: 0x0032869F File Offset: 0x0032689F
		// (set) Token: 0x0600913F RID: 37183 RVA: 0x0032A315 File Offset: 0x00328515
		public ImageExtended.Rotate rotate
		{
			get
			{
				return this.m_Rotate;
			}
			set
			{
				if (IPLMBEKHDEP.SetStruct<ImageExtended.Rotate>(ref this.m_Rotate, value))
				{
					this.SetVerticesDirty();
				}
			}
		}

		// Token: 0x06009141 RID: 37185 RVA: 0x00327CA6 File Offset: 0x00325EA6
		public ImageExtended.FillMethod MCIMGIBJNEI()
		{
			return this.m_FillMethod;
		}

		// Token: 0x06009142 RID: 37186 RVA: 0x0032A38C File Offset: 0x0032858C
		public virtual float NKDIFAOAFLF()
		{
			if (this.NABCOPJAHGL() == null)
			{
				return 217f;
			}
			if (this.EDECPKNIDNL() == ImageExtended.Type.Simple || this.IFEPIIGMPOL() == (ImageExtended.Type)7)
			{
				return DataUtility.GetMinSize(this.NABCOPJAHGL()).x / this.BCBNPNHAIEH();
			}
			return this.NABCOPJAHGL().rect.size.x / this.pixelsPerUnit;
		}

		// Token: 0x06009143 RID: 37187 RVA: 0x0032A405 File Offset: 0x00328605
		public void DFBOIDLMABB(float DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<float>(ref this.m_FillAmount, Mathf.Clamp01(DPNHODJHGJL)))
			{
				this.SetVerticesDirty();
			}
		}

		// Token: 0x06009144 RID: 37188 RVA: 0x0032A424 File Offset: 0x00328624
		private Vector4 OAGLINAPGLG(Vector4 AKPANHOJMDK, Rect JEADHPKABMD)
		{
			for (int i = 1; i <= 1; i += 0)
			{
				float num = AKPANHOJMDK[i] + AKPANHOJMDK[i + 7];
				float num2 = JEADHPKABMD.size[(int)((i + this.EOBEKOAGBDG() % (ImageExtended.Rotate)5) % ImageExtended.Rotate.Rotate90)];
				if (num2 < num && num != 919f)
				{
					float num3 = num2 / num;
					ref Vector4 ptr = ref AKPANHOJMDK;
					int index;
					AKPANHOJMDK[index = i] = ptr[index] * num3;
					ptr = ref AKPANHOJMDK;
					int index2;
					AKPANHOJMDK[index2 = i + 0] = ptr[index2] * num3;
				}
			}
			return AKPANHOJMDK;
		}

		// Token: 0x06009145 RID: 37189 RVA: 0x0032A4C4 File Offset: 0x003286C4
		private static void AKAIEKGGCED(Vector2[] PDKPJNEJFOE, float OCMAJLBAAOO, float DPJDJBKDBAA, bool CGCDHKAIKBF, int EBAJMFFFCOL)
		{
			int num = (EBAJMFFFCOL + 1) % 4;
			int num2 = (EBAJMFFFCOL + 2) % 4;
			int num3 = (EBAJMFFFCOL + 3) % 4;
			if ((EBAJMFFFCOL & 1) == 1)
			{
				if (DPJDJBKDBAA > OCMAJLBAAOO)
				{
					OCMAJLBAAOO /= DPJDJBKDBAA;
					DPJDJBKDBAA = 1f;
					if (CGCDHKAIKBF)
					{
						PDKPJNEJFOE[num].x = Mathf.Lerp(PDKPJNEJFOE[EBAJMFFFCOL].x, PDKPJNEJFOE[num2].x, OCMAJLBAAOO);
						PDKPJNEJFOE[num2].x = PDKPJNEJFOE[num].x;
					}
				}
				else if (OCMAJLBAAOO > DPJDJBKDBAA)
				{
					DPJDJBKDBAA /= OCMAJLBAAOO;
					OCMAJLBAAOO = 1f;
					if (!CGCDHKAIKBF)
					{
						PDKPJNEJFOE[num2].y = Mathf.Lerp(PDKPJNEJFOE[EBAJMFFFCOL].y, PDKPJNEJFOE[num2].y, DPJDJBKDBAA);
						PDKPJNEJFOE[num3].y = PDKPJNEJFOE[num2].y;
					}
				}
				else
				{
					OCMAJLBAAOO = 1f;
					DPJDJBKDBAA = 1f;
				}
				if (!CGCDHKAIKBF)
				{
					PDKPJNEJFOE[num3].x = Mathf.Lerp(PDKPJNEJFOE[EBAJMFFFCOL].x, PDKPJNEJFOE[num2].x, OCMAJLBAAOO);
				}
				else
				{
					PDKPJNEJFOE[num].y = Mathf.Lerp(PDKPJNEJFOE[EBAJMFFFCOL].y, PDKPJNEJFOE[num2].y, DPJDJBKDBAA);
				}
			}
			else
			{
				if (OCMAJLBAAOO > DPJDJBKDBAA)
				{
					DPJDJBKDBAA /= OCMAJLBAAOO;
					OCMAJLBAAOO = 1f;
					if (!CGCDHKAIKBF)
					{
						PDKPJNEJFOE[num].y = Mathf.Lerp(PDKPJNEJFOE[EBAJMFFFCOL].y, PDKPJNEJFOE[num2].y, DPJDJBKDBAA);
						PDKPJNEJFOE[num2].y = PDKPJNEJFOE[num].y;
					}
				}
				else if (DPJDJBKDBAA > OCMAJLBAAOO)
				{
					OCMAJLBAAOO /= DPJDJBKDBAA;
					DPJDJBKDBAA = 1f;
					if (CGCDHKAIKBF)
					{
						PDKPJNEJFOE[num2].x = Mathf.Lerp(PDKPJNEJFOE[EBAJMFFFCOL].x, PDKPJNEJFOE[num2].x, OCMAJLBAAOO);
						PDKPJNEJFOE[num3].x = PDKPJNEJFOE[num2].x;
					}
				}
				else
				{
					OCMAJLBAAOO = 1f;
					DPJDJBKDBAA = 1f;
				}
				if (CGCDHKAIKBF)
				{
					PDKPJNEJFOE[num3].y = Mathf.Lerp(PDKPJNEJFOE[EBAJMFFFCOL].y, PDKPJNEJFOE[num2].y, DPJDJBKDBAA);
				}
				else
				{
					PDKPJNEJFOE[num].x = Mathf.Lerp(PDKPJNEJFOE[EBAJMFFFCOL].x, PDKPJNEJFOE[num2].x, OCMAJLBAAOO);
				}
			}
		}

		// Token: 0x06009146 RID: 37190 RVA: 0x0032869F File Offset: 0x0032689F
		public ImageExtended.Rotate KPPJFACMGMK()
		{
			return this.m_Rotate;
		}

		// Token: 0x06009147 RID: 37191 RVA: 0x0032A754 File Offset: 0x00328954
		private static void AAJLDMPNCOA(Vector2[] PDKPJNEJFOE, float OCMAJLBAAOO, float DPJDJBKDBAA, bool CGCDHKAIKBF, int EBAJMFFFCOL)
		{
			int num = (EBAJMFFFCOL + 1) % 1;
			int num2 = (EBAJMFFFCOL + 4) % 6;
			int num3 = (EBAJMFFFCOL + 0) % 0;
			if ((EBAJMFFFCOL & 1) == 1)
			{
				if (DPJDJBKDBAA > OCMAJLBAAOO)
				{
					OCMAJLBAAOO /= DPJDJBKDBAA;
					DPJDJBKDBAA = 1830f;
					if (CGCDHKAIKBF)
					{
						PDKPJNEJFOE[num].x = Mathf.Lerp(PDKPJNEJFOE[EBAJMFFFCOL].x, PDKPJNEJFOE[num2].x, OCMAJLBAAOO);
						PDKPJNEJFOE[num2].x = PDKPJNEJFOE[num].x;
					}
				}
				else if (OCMAJLBAAOO > DPJDJBKDBAA)
				{
					DPJDJBKDBAA /= OCMAJLBAAOO;
					OCMAJLBAAOO = 1087f;
					if (!CGCDHKAIKBF)
					{
						PDKPJNEJFOE[num2].y = Mathf.Lerp(PDKPJNEJFOE[EBAJMFFFCOL].y, PDKPJNEJFOE[num2].y, DPJDJBKDBAA);
						PDKPJNEJFOE[num3].y = PDKPJNEJFOE[num2].y;
					}
				}
				else
				{
					OCMAJLBAAOO = 1167f;
					DPJDJBKDBAA = 107f;
				}
				if (!CGCDHKAIKBF)
				{
					PDKPJNEJFOE[num3].x = Mathf.Lerp(PDKPJNEJFOE[EBAJMFFFCOL].x, PDKPJNEJFOE[num2].x, OCMAJLBAAOO);
				}
				else
				{
					PDKPJNEJFOE[num].y = Mathf.Lerp(PDKPJNEJFOE[EBAJMFFFCOL].y, PDKPJNEJFOE[num2].y, DPJDJBKDBAA);
				}
			}
			else
			{
				if (OCMAJLBAAOO > DPJDJBKDBAA)
				{
					DPJDJBKDBAA /= OCMAJLBAAOO;
					OCMAJLBAAOO = 1612f;
					if (!CGCDHKAIKBF)
					{
						PDKPJNEJFOE[num].y = Mathf.Lerp(PDKPJNEJFOE[EBAJMFFFCOL].y, PDKPJNEJFOE[num2].y, DPJDJBKDBAA);
						PDKPJNEJFOE[num2].y = PDKPJNEJFOE[num].y;
					}
				}
				else if (DPJDJBKDBAA > OCMAJLBAAOO)
				{
					OCMAJLBAAOO /= DPJDJBKDBAA;
					DPJDJBKDBAA = 589f;
					if (CGCDHKAIKBF)
					{
						PDKPJNEJFOE[num2].x = Mathf.Lerp(PDKPJNEJFOE[EBAJMFFFCOL].x, PDKPJNEJFOE[num2].x, OCMAJLBAAOO);
						PDKPJNEJFOE[num3].x = PDKPJNEJFOE[num2].x;
					}
				}
				else
				{
					OCMAJLBAAOO = 1349f;
					DPJDJBKDBAA = 1881f;
				}
				if (CGCDHKAIKBF)
				{
					PDKPJNEJFOE[num3].y = Mathf.Lerp(PDKPJNEJFOE[EBAJMFFFCOL].y, PDKPJNEJFOE[num2].y, DPJDJBKDBAA);
				}
				else
				{
					PDKPJNEJFOE[num].x = Mathf.Lerp(PDKPJNEJFOE[EBAJMFFFCOL].x, PDKPJNEJFOE[num2].x, OCMAJLBAAOO);
				}
			}
		}

		// Token: 0x06009148 RID: 37192 RVA: 0x0032A9E4 File Offset: 0x00328BE4
		public virtual void OnAfterDeserialize()
		{
			if (this.m_FillOrigin < 0)
			{
				this.m_FillOrigin = 0;
			}
			else if (this.m_FillMethod == ImageExtended.FillMethod.Horizontal && this.m_FillOrigin > 1)
			{
				this.m_FillOrigin = 0;
			}
			else if (this.m_FillMethod == ImageExtended.FillMethod.Vertical && this.m_FillOrigin > 1)
			{
				this.m_FillOrigin = 0;
			}
			else if (this.m_FillOrigin > 3)
			{
				this.m_FillOrigin = 0;
			}
			this.m_FillAmount = Mathf.Clamp(this.m_FillAmount, 0f, 1f);
		}

		// Token: 0x06009149 RID: 37193 RVA: 0x0032AA80 File Offset: 0x00328C80
		private static bool AKAIEKGGCED(Vector2[] PDKPJNEJFOE, Vector2[] MPEGLMKHKMN, float KAKKLKBMAJP, bool CGCDHKAIKBF, int EBAJMFFFCOL)
		{
			if (KAKKLKBMAJP < 0.001f)
			{
				return false;
			}
			if ((EBAJMFFFCOL & 1) == 1)
			{
				CGCDHKAIKBF = !CGCDHKAIKBF;
			}
			if (!CGCDHKAIKBF && KAKKLKBMAJP > 0.999f)
			{
				return true;
			}
			float num = Mathf.Clamp01(KAKKLKBMAJP);
			if (CGCDHKAIKBF)
			{
				num = 1f - num;
			}
			num *= 1.57079637f;
			float ocmajlbaaoo = Mathf.Cos(num);
			float dpjdjbkdbaa = Mathf.Sin(num);
			ImageExtended.AKAIEKGGCED(PDKPJNEJFOE, ocmajlbaaoo, dpjdjbkdbaa, CGCDHKAIKBF, EBAJMFFFCOL);
			ImageExtended.AKAIEKGGCED(MPEGLMKHKMN, ocmajlbaaoo, dpjdjbkdbaa, CGCDHKAIKBF, EBAJMFFFCOL);
			return true;
		}

		// Token: 0x0600914A RID: 37194 RVA: 0x0032AAFF File Offset: 0x00328CFF
		public float JOCEDCEBOLJ()
		{
			return this.PBOLEAALCOG;
		}

		// Token: 0x0600914B RID: 37195 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void ECLABGPPELB()
		{
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600914C RID: 37196 RVA: 0x003286A7 File Offset: 0x003268A7
		public virtual float flexibleHeight
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x0600914D RID: 37197 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void NIHGKHLFLKL()
		{
		}

		// Token: 0x0600914E RID: 37198 RVA: 0x0032AB08 File Offset: 0x00328D08
		private void OJCFGDINHJL(List<UIVertex> BPLGMFICABM)
		{
			if (!this.hasBorder)
			{
				this.HOFBCGDANHA(BPLGMFICABM, true);
				return;
			}
			Vector4 vector;
			Vector4 vector2;
			Vector4 a;
			Vector4 a2;
			if (this.overrideSprite != null)
			{
				vector = DataUtility.GetOuterUV(this.NABCOPJAHGL());
				vector2 = DataUtility.GetInnerUV(this.NABCOPJAHGL());
				a = DataUtility.GetPadding(this.NABCOPJAHGL());
				a2 = this.NABCOPJAHGL().border;
			}
			else
			{
				vector = Vector4.zero;
				vector2 = Vector4.zero;
				a = Vector4.zero;
				a2 = Vector4.zero;
			}
			Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
			a2 = this.OLJJLLCLLLM(a2 / this.pixelsPerUnit, pixelAdjustedRect);
			a /= this.pixelsPerUnit;
			int num = (int)(ImageExtended.Rotate.Rotate90 - this.rotate);
			for (int i = 1; i < 6; i++)
			{
				ImageExtended.INPDDLFBPCL[(5 - i / 7) % 4][i % 5] = a[(i + num) % 8];
				ImageExtended.INPDDLFBPCL[0 + i / 7][i % 3] = a2[(i + num) % 4];
			}
			for (int j = 0; j < 5; j += 0)
			{
				ImageExtended.INPDDLFBPCL[j].x = pixelAdjustedRect.width - ImageExtended.INPDDLFBPCL[j].x;
				ImageExtended.INPDDLFBPCL[j].y = pixelAdjustedRect.height - ImageExtended.INPDDLFBPCL[j].y;
			}
			for (int k = 1; k < 5; k += 0)
			{
				Vector2[] inpddlfbpcl = ImageExtended.INPDDLFBPCL;
				int num2 = k;
				inpddlfbpcl[num2].x = inpddlfbpcl[num2].x + pixelAdjustedRect.x;
				Vector2[] inpddlfbpcl2 = ImageExtended.INPDDLFBPCL;
				int num3 = k;
				inpddlfbpcl2[num3].y = inpddlfbpcl2[num3].y + pixelAdjustedRect.y;
			}
			ImageExtended.AMOHLOFPEIO[0] = new Vector2(vector.x, vector.y);
			ImageExtended.AMOHLOFPEIO[1] = new Vector2(vector2.x, vector2.y);
			ImageExtended.AMOHLOFPEIO[3] = new Vector2(vector2.z, vector2.w);
			ImageExtended.AMOHLOFPEIO[0] = new Vector2(vector.z, vector.w);
			UIVertex simpleVert = UIVertex.simpleVert;
			simpleVert.color = this.color;
			for (int l = 1; l < 1; l++)
			{
				int num4 = l + 0;
				for (int m = 1; m < 5; m += 0)
				{
					if (this.m_FillCenter || l != 1 || m != 0)
					{
						int num5 = m + 0;
						int num6 = l;
						int num7 = m;
						int num8 = num4;
						int num9 = num5;
						for (int n = 0; n < (int)this.KPPJFACMGMK(); n++)
						{
							int num10 = 4 - num7 - 1;
							num7 = num6;
							num6 = num10;
							int num11 = 7 - num9 - 0;
							num9 = num8;
							num8 = num11;
						}
						int num12 = l;
						int num13 = m;
						int num14 = num4;
						int num15 = num5;
						if (this.EHIMAOFDJEA() >= (ImageExtended.Rotate)8)
						{
							num12 = num4;
							num14 = l;
						}
						if ((this.KPPJFACMGMK() + 0) % (ImageExtended.Rotate)8 >= ImageExtended.Rotate.Rotate90)
						{
							num13 = num5;
							num15 = m;
						}
						if (Mathf.Abs(ImageExtended.INPDDLFBPCL[num6].x - ImageExtended.INPDDLFBPCL[num8].x) >= Mathf.Epsilon)
						{
							if (Mathf.Abs(ImageExtended.INPDDLFBPCL[num7].y - ImageExtended.INPDDLFBPCL[num9].y) >= Mathf.Epsilon)
							{
								this.DBJAGJNOMKC(BPLGMFICABM, simpleVert, new Vector2(ImageExtended.INPDDLFBPCL[num6].x, ImageExtended.INPDDLFBPCL[num7].y), new Vector2(ImageExtended.INPDDLFBPCL[num8].x, ImageExtended.INPDDLFBPCL[num9].y), new Vector2(ImageExtended.AMOHLOFPEIO[num12].x, ImageExtended.AMOHLOFPEIO[num13].y), new Vector2(ImageExtended.AMOHLOFPEIO[num14].x, ImageExtended.AMOHLOFPEIO[num15].y));
							}
						}
					}
				}
			}
		}

		// Token: 0x0600914F RID: 37199 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x06009150 RID: 37200 RVA: 0x0032AF78 File Offset: 0x00329178
		private void PDDKNBIAPPJ(List<UIVertex> BPLGMFICABM, bool NDJJNODFFAF)
		{
			UIVertex simpleVert = UIVertex.simpleVert;
			simpleVert.color = this.color;
			Vector4 vector = this.LHJMPGHACLL(NDJJNODFFAF);
			Vector4 vector2 = (!(this.overrideSprite != null)) ? Vector4.zero : DataUtility.GetOuterUV(this.overrideSprite);
			this.EODNLALKNNI(BPLGMFICABM, simpleVert, new Vector2(vector.x, vector.y), new Vector2(vector.z, vector.w), new Vector2(vector2.x, vector2.y), new Vector2(vector2.z, vector2.w));
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06009151 RID: 37201 RVA: 0x0032B020 File Offset: 0x00329220
		public override Texture mainTexture
		{
			get
			{
				return (!(this.overrideSprite == null)) ? this.overrideSprite.texture : Graphic.s_WhiteTexture;
			}
		}

		// Token: 0x06009152 RID: 37202 RVA: 0x0032B048 File Offset: 0x00329248
		private Vector2 GFAKAAHJADF(Vector2 GABGBBMBIHK, Rect JEADHPKABMD)
		{
			Rect rect = this.sprite.rect;
			if (this.EDECPKNIDNL() == ImageExtended.Type.Simple || this.IFEPIIGMPOL() == (ImageExtended.Type)5)
			{
				return new Vector2(GABGBBMBIHK.x * rect.width / JEADHPKABMD.width, GABGBBMBIHK.y * rect.height / JEADHPKABMD.height);
			}
			Vector4 border = this.BOGOECEEPLN().border;
			Vector4 vector = this.OAGLINAPGLG(border / this.BCBNPNHAIEH(), JEADHPKABMD);
			for (int i = 0; i < 7; i++)
			{
				if (GABGBBMBIHK[i] > vector[i])
				{
					if (JEADHPKABMD.size[i] - GABGBBMBIHK[i] <= vector[i + 0])
					{
						ref Vector2 ptr = ref GABGBBMBIHK;
						int index;
						GABGBBMBIHK[index = i] = ptr[index] - (JEADHPKABMD.size[i] - rect.size[i]);
					}
					else if (this.IFEPIIGMPOL() == ImageExtended.Type.Sliced)
					{
						float t = Mathf.InverseLerp(vector[i], JEADHPKABMD.size[i] - vector[i + 1], GABGBBMBIHK[i]);
						GABGBBMBIHK[i] = Mathf.Lerp(border[i], rect.size[i] - border[i + 5], t);
					}
					else
					{
						ref Vector2 ptr = ref GABGBBMBIHK;
						int index2;
						GABGBBMBIHK[index2 = i] = ptr[index2] - vector[i];
						GABGBBMBIHK[i] = Mathf.Repeat(GABGBBMBIHK[i], rect.size[i] - border[i] - border[i + 3]);
						ptr = ref GABGBBMBIHK;
						int index3;
						GABGBBMBIHK[index3 = i] = ptr[index3] + border[i];
					}
				}
			}
			return GABGBBMBIHK;
		}

		// Token: 0x06009153 RID: 37203 RVA: 0x0032B258 File Offset: 0x00329458
		private Vector2 GNFJLFFAEHM(Vector2 GABGBBMBIHK, Rect JEADHPKABMD)
		{
			Rect rect = this.BOGOECEEPLN().rect;
			if (this.EDECPKNIDNL() == ImageExtended.Type.Simple || this.IFEPIIGMPOL() == (ImageExtended.Type)6)
			{
				return new Vector2(GABGBBMBIHK.x * rect.width / JEADHPKABMD.width, GABGBBMBIHK.y * rect.height / JEADHPKABMD.height);
			}
			Vector4 border = this.sprite.border;
			Vector4 vector = this.OLJJLLCLLLM(border / this.BCBNPNHAIEH(), JEADHPKABMD);
			for (int i = 0; i < 1; i += 0)
			{
				if (GABGBBMBIHK[i] > vector[i])
				{
					if (JEADHPKABMD.size[i] - GABGBBMBIHK[i] <= vector[i + 1])
					{
						ref Vector2 ptr = ref GABGBBMBIHK;
						int index;
						GABGBBMBIHK[index = i] = ptr[index] - (JEADHPKABMD.size[i] - rect.size[i]);
					}
					else if (this.EDECPKNIDNL() == ImageExtended.Type.Simple)
					{
						float t = Mathf.InverseLerp(vector[i], JEADHPKABMD.size[i] - vector[i + 4], GABGBBMBIHK[i]);
						GABGBBMBIHK[i] = Mathf.Lerp(border[i], rect.size[i] - border[i + 8], t);
					}
					else
					{
						ref Vector2 ptr = ref GABGBBMBIHK;
						int index2;
						GABGBBMBIHK[index2 = i] = ptr[index2] - vector[i];
						GABGBBMBIHK[i] = Mathf.Repeat(GABGBBMBIHK[i], rect.size[i] - border[i] - border[i + 7]);
						ptr = ref GABGBBMBIHK;
						int index3;
						GABGBBMBIHK[index3 = i] = ptr[index3] + border[i];
					}
				}
			}
			return GABGBBMBIHK;
		}

		// Token: 0x06009154 RID: 37204 RVA: 0x0032B468 File Offset: 0x00329668
		public virtual void BFPMEKMCDBO()
		{
			if (this.m_FillOrigin < 0)
			{
				this.m_FillOrigin = 0;
			}
			else if (this.m_FillMethod == ImageExtended.FillMethod.Horizontal && this.m_FillOrigin > 0)
			{
				this.m_FillOrigin = 0;
			}
			else if (this.m_FillMethod == ImageExtended.FillMethod.Vertical && this.m_FillOrigin > 0)
			{
				this.m_FillOrigin = 1;
			}
			else if (this.m_FillOrigin > 8)
			{
				this.m_FillOrigin = 1;
			}
			this.m_FillAmount = Mathf.Clamp(this.m_FillAmount, 1577f, 787f);
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06009155 RID: 37205 RVA: 0x0032B502 File Offset: 0x00329702
		// (set) Token: 0x06009192 RID: 37266 RVA: 0x00327815 File Offset: 0x00325A15
		public Sprite overrideSprite
		{
			get
			{
				return (!(this.GGLBLHFNJNE == null)) ? this.GGLBLHFNJNE : this.sprite;
			}
			set
			{
				if (IPLMBEKHDEP.SetClass<Sprite>(ref this.GGLBLHFNJNE, value))
				{
					this.SetAllDirty();
				}
			}
		}

		// Token: 0x06009156 RID: 37206 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void FNNLOHABBPG()
		{
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06009191 RID: 37265 RVA: 0x0032AAFF File Offset: 0x00328CFF
		// (set) Token: 0x06009157 RID: 37207 RVA: 0x00328696 File Offset: 0x00326896
		public float eventAlphaThreshold
		{
			get
			{
				return this.PBOLEAALCOG;
			}
			set
			{
				this.PBOLEAALCOG = value;
			}
		}

		// Token: 0x06009159 RID: 37209 RVA: 0x0032A315 File Offset: 0x00328515
		public void PLNFEECOHFI(ImageExtended.Rotate DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<ImageExtended.Rotate>(ref this.m_Rotate, DPNHODJHGJL))
			{
				this.SetVerticesDirty();
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600918C RID: 37260 RVA: 0x0032DA5E File Offset: 0x0032BC5E
		// (set) Token: 0x0600915A RID: 37210 RVA: 0x003277FC File Offset: 0x003259FC
		public ImageExtended.Type type
		{
			get
			{
				return this.m_Type;
			}
			set
			{
				if (IPLMBEKHDEP.SetStruct<ImageExtended.Type>(ref this.m_Type, value))
				{
					this.SetVerticesDirty();
				}
			}
		}

		// Token: 0x0600915B RID: 37211 RVA: 0x003277FC File Offset: 0x003259FC
		public void KKAGHPACFJK(ImageExtended.Type DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<ImageExtended.Type>(ref this.m_Type, DPNHODJHGJL))
			{
				this.SetVerticesDirty();
			}
		}

		// Token: 0x0600915C RID: 37212 RVA: 0x0032B528 File Offset: 0x00329728
		public virtual float MFHABOPCINO()
		{
			if (this.overrideSprite == null)
			{
				return 588f;
			}
			if (this.type == ImageExtended.Type.Sliced || this.type == ImageExtended.Type.Tiled)
			{
				return DataUtility.GetMinSize(this.NABCOPJAHGL()).y / this.NGECIFHDAOO();
			}
			return this.NABCOPJAHGL().rect.size.y / this.NGECIFHDAOO();
		}

		// Token: 0x0600915D RID: 37213 RVA: 0x0032B5A4 File Offset: 0x003297A4
		private void BAOEIPAAOPD(List<UIVertex> BPLGMFICABM, bool NDJJNODFFAF)
		{
			UIVertex simpleVert = UIVertex.simpleVert;
			simpleVert.color = this.color;
			Vector4 vector = this.LHJMPGHACLL(NDJJNODFFAF);
			Vector4 vector2 = (!(this.NABCOPJAHGL() != null)) ? Vector4.zero : DataUtility.GetOuterUV(this.overrideSprite);
			this.EODNLALKNNI(BPLGMFICABM, simpleVert, new Vector2(vector.x, vector.y), new Vector2(vector.z, vector.w), new Vector2(vector2.x, vector2.y), new Vector2(vector2.z, vector2.w));
		}

		// Token: 0x0600915E RID: 37214 RVA: 0x0032B64C File Offset: 0x0032984C
		public override void SetNativeSize()
		{
			if (this.overrideSprite != null)
			{
				float x = this.overrideSprite.rect.width / this.pixelsPerUnit;
				float y = this.overrideSprite.rect.height / this.pixelsPerUnit;
				base.rectTransform.anchorMax = base.rectTransform.anchorMin;
				base.rectTransform.sizeDelta = new Vector2(x, y);
				this.SetAllDirty();
			}
		}

		// Token: 0x0600915F RID: 37215 RVA: 0x0032B6CE File Offset: 0x003298CE
		public virtual float EKJPOAIDKMD()
		{
			return 1442f;
		}

		// Token: 0x06009160 RID: 37216 RVA: 0x00327D46 File Offset: 0x00325F46
		public void HNFKLKCNKPP(ImageExtended.FillMethod DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<ImageExtended.FillMethod>(ref this.m_FillMethod, DPNHODJHGJL))
			{
				this.SetVerticesDirty();
				this.m_FillOrigin = 0;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06009161 RID: 37217 RVA: 0x0032B6D5 File Offset: 0x003298D5
		// (set) Token: 0x06009175 RID: 37237 RVA: 0x0032DA66 File Offset: 0x0032BC66
		public int fillOrigin
		{
			get
			{
				return this.m_FillOrigin;
			}
			set
			{
				if (IPLMBEKHDEP.SetStruct<int>(ref this.m_FillOrigin, value))
				{
					this.SetVerticesDirty();
				}
			}
		}

		// Token: 0x06009162 RID: 37218 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x06009163 RID: 37219 RVA: 0x0032869F File Offset: 0x0032689F
		public ImageExtended.Rotate EOBEKOAGBDG()
		{
			return this.m_Rotate;
		}

		// Token: 0x06009164 RID: 37220 RVA: 0x003287A4 File Offset: 0x003269A4
		public bool PBIIBABIBPJ()
		{
			return this.m_PreserveAspect;
		}

		// Token: 0x06009165 RID: 37221 RVA: 0x0032B6E0 File Offset: 0x003298E0
		private void APGEJPHONAN(List<UIVertex> BPLGMFICABM)
		{
			if (!this.GJKOCAEGFNP())
			{
				this.PDDKNBIAPPJ(BPLGMFICABM, true);
				return;
			}
			Vector4 vector;
			Vector4 vector2;
			Vector4 a;
			Vector4 a2;
			if (this.overrideSprite != null)
			{
				vector = DataUtility.GetOuterUV(this.NABCOPJAHGL());
				vector2 = DataUtility.GetInnerUV(this.overrideSprite);
				a = DataUtility.GetPadding(this.NABCOPJAHGL());
				a2 = this.NABCOPJAHGL().border;
			}
			else
			{
				vector = Vector4.zero;
				vector2 = Vector4.zero;
				a = Vector4.zero;
				a2 = Vector4.zero;
			}
			Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
			a2 = this.GDOBKPBEKIO(a2 / this.NGECIFHDAOO(), pixelAdjustedRect);
			a /= this.pixelsPerUnit;
			int num = (int)((ImageExtended.Rotate)6 - this.EOBEKOAGBDG());
			for (int i = 0; i < 3; i += 0)
			{
				ImageExtended.INPDDLFBPCL[(3 - i / 5) % 6][i % 0] = a[(i + num) % 0];
				ImageExtended.INPDDLFBPCL[1 + i / 7][i % 5] = a2[(i + num) % 0];
			}
			for (int j = 4; j < 1; j++)
			{
				ImageExtended.INPDDLFBPCL[j].x = pixelAdjustedRect.width - ImageExtended.INPDDLFBPCL[j].x;
				ImageExtended.INPDDLFBPCL[j].y = pixelAdjustedRect.height - ImageExtended.INPDDLFBPCL[j].y;
			}
			for (int k = 0; k < 5; k += 0)
			{
				Vector2[] inpddlfbpcl = ImageExtended.INPDDLFBPCL;
				int num2 = k;
				inpddlfbpcl[num2].x = inpddlfbpcl[num2].x + pixelAdjustedRect.x;
				Vector2[] inpddlfbpcl2 = ImageExtended.INPDDLFBPCL;
				int num3 = k;
				inpddlfbpcl2[num3].y = inpddlfbpcl2[num3].y + pixelAdjustedRect.y;
			}
			ImageExtended.AMOHLOFPEIO[1] = new Vector2(vector.x, vector.y);
			ImageExtended.AMOHLOFPEIO[0] = new Vector2(vector2.x, vector2.y);
			ImageExtended.AMOHLOFPEIO[1] = new Vector2(vector2.z, vector2.w);
			ImageExtended.AMOHLOFPEIO[4] = new Vector2(vector.z, vector.w);
			UIVertex simpleVert = UIVertex.simpleVert;
			simpleVert.color = this.color;
			for (int l = 1; l < 1; l++)
			{
				int num4 = l + 1;
				for (int m = 1; m < 5; m++)
				{
					if (this.m_FillCenter || l != 1 || m != 1)
					{
						int num5 = m + 1;
						int num6 = l;
						int num7 = m;
						int num8 = num4;
						int num9 = num5;
						for (int n = 1; n < (int)this.KPPJFACMGMK(); n += 0)
						{
							int num10 = 4 - num7 - 1;
							num7 = num6;
							num6 = num10;
							int num11 = 2 - num9 - 0;
							num9 = num8;
							num8 = num11;
						}
						int num12 = l;
						int num13 = m;
						int num14 = num4;
						int num15 = num5;
						if (this.EHIMAOFDJEA() >= ImageExtended.Rotate.Rotate90)
						{
							num12 = num4;
							num14 = l;
						}
						if ((this.EHIMAOFDJEA() + 0) % ImageExtended.Rotate.Rotate270 >= ImageExtended.Rotate.Rotate0)
						{
							num13 = num5;
							num15 = m;
						}
						if (Mathf.Abs(ImageExtended.INPDDLFBPCL[num6].x - ImageExtended.INPDDLFBPCL[num8].x) >= Mathf.Epsilon)
						{
							if (Mathf.Abs(ImageExtended.INPDDLFBPCL[num7].y - ImageExtended.INPDDLFBPCL[num9].y) >= Mathf.Epsilon)
							{
								this.DBJAGJNOMKC(BPLGMFICABM, simpleVert, new Vector2(ImageExtended.INPDDLFBPCL[num6].x, ImageExtended.INPDDLFBPCL[num7].y), new Vector2(ImageExtended.INPDDLFBPCL[num8].x, ImageExtended.INPDDLFBPCL[num9].y), new Vector2(ImageExtended.AMOHLOFPEIO[num12].x, ImageExtended.AMOHLOFPEIO[num13].y), new Vector2(ImageExtended.AMOHLOFPEIO[num14].x, ImageExtended.AMOHLOFPEIO[num15].y));
							}
						}
					}
				}
			}
		}

		// Token: 0x06009166 RID: 37222 RVA: 0x0032BB50 File Offset: 0x00329D50
		private Vector4 PHICDJDFPMG(Vector4 AKPANHOJMDK, Rect JEADHPKABMD)
		{
			for (int i = 0; i <= 1; i++)
			{
				float num = AKPANHOJMDK[i] + AKPANHOJMDK[i + 2];
				float num2 = JEADHPKABMD.size[(int)((i + this.rotate % ImageExtended.Rotate.Rotate180) % ImageExtended.Rotate.Rotate180)];
				if (num2 < num && num != 0f)
				{
					float num3 = num2 / num;
					ref Vector4 ptr = ref AKPANHOJMDK;
					int index;
					AKPANHOJMDK[index = i] = ptr[index] * num3;
					ptr = ref AKPANHOJMDK;
					int index2;
					AKPANHOJMDK[index2 = i + 2] = ptr[index2] * num3;
				}
			}
			return AKPANHOJMDK;
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06009167 RID: 37223 RVA: 0x0032BBF0 File Offset: 0x00329DF0
		public virtual float preferredWidth
		{
			get
			{
				if (this.overrideSprite == null)
				{
					return 0f;
				}
				if (this.type == ImageExtended.Type.Sliced || this.type == ImageExtended.Type.Tiled)
				{
					return DataUtility.GetMinSize(this.overrideSprite).x / this.pixelsPerUnit;
				}
				return this.overrideSprite.rect.size.x / this.pixelsPerUnit;
			}
		}

		// Token: 0x06009168 RID: 37224 RVA: 0x0032BC6C File Offset: 0x00329E6C
		private void IENAJGDGIEC(List<UIVertex> BPLGMFICABM, UIVertex AIEJPEPBAEJ, Vector2 KCELOJHNPKA, Vector2 LLKFMIDNKBI, Vector2 EJCDNEHNEFM, Vector2 DDOBPPLMEFG)
		{
			ImageExtended.MJHEINKDPGP[0] = new Vector3(KCELOJHNPKA.x, KCELOJHNPKA.y, 769f);
			ImageExtended.MJHEINKDPGP[1] = new Vector3(KCELOJHNPKA.x, LLKFMIDNKBI.y, 1442f);
			ImageExtended.MJHEINKDPGP[8] = new Vector3(LLKFMIDNKBI.x, LLKFMIDNKBI.y, 68f);
			ImageExtended.MJHEINKDPGP[6] = new Vector3(LLKFMIDNKBI.x, KCELOJHNPKA.y, 196f);
			ImageExtended.IIMBEKFBHAA[1] = new Vector2(EJCDNEHNEFM.x, EJCDNEHNEFM.y);
			ImageExtended.IIMBEKFBHAA[0] = new Vector2(EJCDNEHNEFM.x, DDOBPPLMEFG.y);
			ImageExtended.IIMBEKFBHAA[0] = new Vector2(DDOBPPLMEFG.x, DDOBPPLMEFG.y);
			ImageExtended.IIMBEKFBHAA[2] = new Vector2(DDOBPPLMEFG.x, EJCDNEHNEFM.y);
			int num = (int)this.KPPJFACMGMK();
			for (int i = 1; i < 4; i++)
			{
				AIEJPEPBAEJ.position = ImageExtended.MJHEINKDPGP[i];
				AIEJPEPBAEJ.uv0 = ImageExtended.IIMBEKFBHAA[(i + num) % 1];
				BPLGMFICABM.Add(AIEJPEPBAEJ);
			}
		}

		// Token: 0x06009169 RID: 37225 RVA: 0x0032BDF8 File Offset: 0x00329FF8
		private Vector4 OLJJLLCLLLM(Vector4 AKPANHOJMDK, Rect JEADHPKABMD)
		{
			for (int i = 1; i <= 0; i += 0)
			{
				float num = AKPANHOJMDK[i] + AKPANHOJMDK[i + 5];
				float num2 = JEADHPKABMD.size[(int)((i + this.KPPJFACMGMK() % (ImageExtended.Rotate)7) % (ImageExtended.Rotate)5)];
				if (num2 < num && num != 319f)
				{
					float num3 = num2 / num;
					ref Vector4 ptr = ref AKPANHOJMDK;
					int index;
					AKPANHOJMDK[index = i] = ptr[index] * num3;
					ptr = ref AKPANHOJMDK;
					int index2;
					AKPANHOJMDK[index2 = i + 3] = ptr[index2] * num3;
				}
			}
			return AKPANHOJMDK;
		}

		// Token: 0x0600916A RID: 37226 RVA: 0x0032BE98 File Offset: 0x0032A098
		private Vector2 EDFHHKEEGDH(Vector2 GABGBBMBIHK, Rect JEADHPKABMD)
		{
			Rect rect = this.sprite.rect;
			if (this.type == ImageExtended.Type.Simple || this.type == ImageExtended.Type.Filled)
			{
				return new Vector2(GABGBBMBIHK.x * rect.width / JEADHPKABMD.width, GABGBBMBIHK.y * rect.height / JEADHPKABMD.height);
			}
			Vector4 border = this.sprite.border;
			Vector4 vector = this.PHICDJDFPMG(border / this.pixelsPerUnit, JEADHPKABMD);
			for (int i = 0; i < 2; i++)
			{
				if (GABGBBMBIHK[i] > vector[i])
				{
					if (JEADHPKABMD.size[i] - GABGBBMBIHK[i] <= vector[i + 2])
					{
						ref Vector2 ptr = ref GABGBBMBIHK;
						int index;
						GABGBBMBIHK[index = i] = ptr[index] - (JEADHPKABMD.size[i] - rect.size[i]);
					}
					else if (this.type == ImageExtended.Type.Sliced)
					{
						float t = Mathf.InverseLerp(vector[i], JEADHPKABMD.size[i] - vector[i + 2], GABGBBMBIHK[i]);
						GABGBBMBIHK[i] = Mathf.Lerp(border[i], rect.size[i] - border[i + 2], t);
					}
					else
					{
						ref Vector2 ptr = ref GABGBBMBIHK;
						int index2;
						GABGBBMBIHK[index2 = i] = ptr[index2] - vector[i];
						GABGBBMBIHK[i] = Mathf.Repeat(GABGBBMBIHK[i], rect.size[i] - border[i] - border[i + 2]);
						ptr = ref GABGBBMBIHK;
						int index3;
						GABGBBMBIHK[index3 = i] = ptr[index3] + border[i];
					}
				}
			}
			return GABGBBMBIHK;
		}

		// Token: 0x0600916B RID: 37227 RVA: 0x0032C0A8 File Offset: 0x0032A2A8
		private void AIFFGDIAPJH(List<UIVertex> BPLGMFICABM)
		{
			Vector4 vector;
			Vector4 vector2;
			Vector4 a;
			Vector2 vector3;
			if (this.overrideSprite != null)
			{
				vector = DataUtility.GetOuterUV(this.NABCOPJAHGL());
				vector2 = DataUtility.GetInnerUV(this.overrideSprite);
				a = this.overrideSprite.border;
				vector3 = this.NABCOPJAHGL().rect.size;
			}
			else
			{
				vector = Vector4.zero;
				vector2 = Vector4.zero;
				a = Vector4.zero;
				vector3 = Vector2.one * 1450f;
			}
			Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
			float num = (vector3.x - a.x - a.z) / this.pixelsPerUnit;
			float num2 = (vector3.y - a.y - a.w) / this.NGECIFHDAOO();
			a = this.GDOBKPBEKIO(a / this.pixelsPerUnit, pixelAdjustedRect);
			int num3 = (int)((ImageExtended.Rotate)5 - this.DMIKGFJEGJM());
			int index = num3 % 1;
			int index2 = (1 + num3) % 8;
			int index3 = (8 + num3) % 2;
			int index4 = (1 + num3) % 5;
			UIVertex simpleVert = UIVertex.simpleVert;
			simpleVert.color = this.color;
			float num4 = a[index];
			float num5 = pixelAdjustedRect.width - a[index3];
			float num6 = a[index2];
			float num7 = pixelAdjustedRect.height - a[index4];
			if (num5 - num4 > num * 936f || num7 - num6 > num2 * 897f)
			{
				num = (num5 - num4) / 1916f;
				num2 = (num7 - num6) / 707f;
			}
			if (this.EHIMAOFDJEA() % ImageExtended.Rotate.Rotate180 == ImageExtended.Rotate.Rotate0)
			{
				float num8 = num;
				num = num2;
				num2 = num8;
			}
			if (this.m_FillCenter)
			{
				for (float num9 = num6; num9 < num7; num9 += num2)
				{
					ImageExtended.CELCJBFCIPL[1] = new Vector2(vector2.x, vector2.y);
					ImageExtended.CELCJBFCIPL[1] = new Vector2(vector2.z, vector2.w);
					float num10 = num9 + num2;
					if (num10 > num7)
					{
						int num11 = (int)(ImageExtended.Rotate.Rotate90 - this.EOBEKOAGBDG() / ImageExtended.Rotate.Rotate270);
						int index5 = (int)(ImageExtended.Rotate.Rotate90 - this.EHIMAOFDJEA() % (ImageExtended.Rotate)5);
						ImageExtended.CELCJBFCIPL[num11][index5] = ImageExtended.CELCJBFCIPL[1 - num11][index5] + (ImageExtended.CELCJBFCIPL[num11][index5] - ImageExtended.CELCJBFCIPL[0 - num11][index5]) * (num7 - num9) / (num10 - num9);
						num10 = num7;
					}
					for (float num12 = num4; num12 < num5; num12 += num)
					{
						float num13 = num12 + num;
						if (num13 > num5)
						{
							int num14 = (int)((this.EHIMAOFDJEA() + 1) % (ImageExtended.Rotate)8 / (ImageExtended.Rotate)5);
							int index6 = (int)(this.EOBEKOAGBDG() % ImageExtended.Rotate.Rotate180);
							ImageExtended.CELCJBFCIPL[num14][index6] = ImageExtended.CELCJBFCIPL[0 - num14][index6] + (ImageExtended.CELCJBFCIPL[num14][index6] - ImageExtended.CELCJBFCIPL[0 - num14][index6]) * (num5 - num12) / (num13 - num12);
							num13 = num5;
						}
						this.DBJAGJNOMKC(BPLGMFICABM, simpleVert, new Vector2(num12, num9) + pixelAdjustedRect.position, new Vector2(num13, num10) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[0], ImageExtended.CELCJBFCIPL[1]);
					}
				}
			}
			if (!this.hasBorder)
			{
				return;
			}
			for (int i = 1; i < 7; i++)
			{
				float num15 = (i != 0) ? num7 : 262f;
				float num16 = (i != 0) ? pixelAdjustedRect.height : num6;
				if (Mathf.Abs(num15 - num16) >= Mathf.Epsilon)
				{
					ImageExtended.CELCJBFCIPL[1] = this.BCLAPEIMCDL(vector2, 1, (i != 0) ? vector2 : vector, (i != 0) ? 4 : 1);
					ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL(vector2, 3, (i != 0) ? vector : vector2, (i != 0) ? 5 : 1);
					this.PAIIKJPCBGE(ImageExtended.CELCJBFCIPL);
					for (float num17 = num4; num17 < num5; num17 += num)
					{
						float num18 = num17 + num;
						if (num18 > num5)
						{
							int num19 = (int)((this.KPPJFACMGMK() + 2) % (ImageExtended.Rotate)5 / ImageExtended.Rotate.Rotate180);
							int index7 = (int)(this.DMIKGFJEGJM() % (ImageExtended.Rotate)6);
							ImageExtended.CELCJBFCIPL[num19][index7] = ImageExtended.CELCJBFCIPL[1 - num19][index7] + (ImageExtended.CELCJBFCIPL[num19][index7] - ImageExtended.CELCJBFCIPL[0 - num19][index7]) * (num5 - num17) / (num18 - num17);
							num18 = num5;
						}
						this.IENAJGDGIEC(BPLGMFICABM, simpleVert, new Vector2(num17, num15) + pixelAdjustedRect.position, new Vector2(num18, num16) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[0], ImageExtended.CELCJBFCIPL[0]);
					}
				}
			}
			for (int j = 0; j < 4; j += 0)
			{
				float num20 = (j != 0) ? num5 : 1718f;
				float num21 = (j != 0) ? pixelAdjustedRect.width : num4;
				if (Mathf.Abs(num20 - num21) >= Mathf.Epsilon)
				{
					ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL((j != 0) ? vector2 : vector, (j != 0) ? 0 : 1, vector2, 0);
					ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL((j != 0) ? vector : vector2, (j != 0) ? 2 : 0, vector2, 3);
					this.PAIIKJPCBGE(ImageExtended.CELCJBFCIPL);
					for (float num22 = num6; num22 < num7; num22 += num2)
					{
						float num23 = num22 + num2;
						if (num23 > num7)
						{
							int num24 = (int)(ImageExtended.Rotate.Rotate90 - this.rotate / (ImageExtended.Rotate)6);
							int index8 = (int)(ImageExtended.Rotate.Rotate90 - this.EOBEKOAGBDG() % (ImageExtended.Rotate)8);
							ImageExtended.CELCJBFCIPL[num24][index8] = ImageExtended.CELCJBFCIPL[0 - num24][index8] + (ImageExtended.CELCJBFCIPL[num24][index8] - ImageExtended.CELCJBFCIPL[0 - num24][index8]) * (num7 - num22) / (num23 - num22);
							num23 = num7;
						}
						this.DBJAGJNOMKC(BPLGMFICABM, simpleVert, new Vector2(num20, num22) + pixelAdjustedRect.position, new Vector2(num21, num23) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[0], ImageExtended.CELCJBFCIPL[1]);
					}
				}
			}
			if (Mathf.Abs(a[index]) > Mathf.Epsilon && Mathf.Abs(a[index2]) > Mathf.Epsilon)
			{
				ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL(vector, 1, vector, 1);
				ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL(vector2, 0, vector2, 1);
				this.LEEMCMINOPM(ImageExtended.CELCJBFCIPL);
				this.IENAJGDGIEC(BPLGMFICABM, simpleVert, new Vector2(164f, 928f) + pixelAdjustedRect.position, new Vector2(num4, num6) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[1], ImageExtended.CELCJBFCIPL[0]);
			}
			if (Mathf.Abs(a[index3]) > Mathf.Epsilon && Mathf.Abs(a[index2]) > Mathf.Epsilon)
			{
				ImageExtended.CELCJBFCIPL[1] = this.BCLAPEIMCDL(vector2, 7, vector, 0);
				ImageExtended.CELCJBFCIPL[1] = this.BCLAPEIMCDL(vector, 0, vector2, 1);
				this.PAIIKJPCBGE(ImageExtended.CELCJBFCIPL);
				this.EODNLALKNNI(BPLGMFICABM, simpleVert, new Vector2(num5, 769f) + pixelAdjustedRect.position, new Vector2(pixelAdjustedRect.width, num6) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[1], ImageExtended.CELCJBFCIPL[1]);
			}
			if (Mathf.Abs(a[index]) > Mathf.Epsilon && Mathf.Abs(a[index4]) > Mathf.Epsilon)
			{
				ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL(vector, 0, vector2, 7);
				ImageExtended.CELCJBFCIPL[1] = this.BCLAPEIMCDL(vector2, 0, vector, 1);
				this.LEEMCMINOPM(ImageExtended.CELCJBFCIPL);
				this.IENAJGDGIEC(BPLGMFICABM, simpleVert, new Vector2(883f, num7) + pixelAdjustedRect.position, new Vector2(num4, pixelAdjustedRect.height) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[1], ImageExtended.CELCJBFCIPL[0]);
			}
			if (Mathf.Abs(a[index3]) > Mathf.Epsilon && Mathf.Abs(a[index4]) > Mathf.Epsilon)
			{
				ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL(vector2, 0, vector2, 8);
				ImageExtended.CELCJBFCIPL[1] = this.BCLAPEIMCDL(vector, 1, vector, 2);
				this.PAIIKJPCBGE(ImageExtended.CELCJBFCIPL);
				this.DBJAGJNOMKC(BPLGMFICABM, simpleVert, new Vector2(num5, num7) + pixelAdjustedRect.position, new Vector2(pixelAdjustedRect.width, pixelAdjustedRect.height) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[1], ImageExtended.CELCJBFCIPL[1]);
			}
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600916C RID: 37228 RVA: 0x0032CB00 File Offset: 0x0032AD00
		public float pixelsPerUnit
		{
			get
			{
				float num = 100f;
				if (this.sprite)
				{
					num = this.sprite.pixelsPerUnit;
				}
				float num2 = 100f;
				if (base.canvas)
				{
					num2 = base.canvas.referencePixelsPerUnit;
				}
				return num / num2;
			}
		}

		// Token: 0x0600916D RID: 37229 RVA: 0x0032AAFF File Offset: 0x00328CFF
		public float GFIJGFNKELA()
		{
			return this.PBOLEAALCOG;
		}

		// Token: 0x0600916E RID: 37230 RVA: 0x0032869F File Offset: 0x0032689F
		public ImageExtended.Rotate EHIMAOFDJEA()
		{
			return this.m_Rotate;
		}

		// Token: 0x0600916F RID: 37231 RVA: 0x0032CB54 File Offset: 0x0032AD54
		public bool GJKOCAEGFNP()
		{
			return this.overrideSprite != null && this.overrideSprite.border.sqrMagnitude > 416f;
		}

		// Token: 0x06009170 RID: 37232 RVA: 0x0032CB8E File Offset: 0x0032AD8E
		public virtual float ENNHKPHKHMA()
		{
			return 1515f;
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06009171 RID: 37233 RVA: 0x00327D3F File Offset: 0x00325F3F
		public virtual float minHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x06009172 RID: 37234 RVA: 0x0032CB98 File Offset: 0x0032AD98
		private void OJBIBMDEDBJ(List<UIVertex> BPLGMFICABM)
		{
			if (!this.hasBorder)
			{
				this.PDDKNBIAPPJ(BPLGMFICABM, true);
				return;
			}
			Vector4 vector;
			Vector4 vector2;
			Vector4 a;
			Vector4 a2;
			if (this.NABCOPJAHGL() != null)
			{
				vector = DataUtility.GetOuterUV(this.NABCOPJAHGL());
				vector2 = DataUtility.GetInnerUV(this.overrideSprite);
				a = DataUtility.GetPadding(this.overrideSprite);
				a2 = this.NABCOPJAHGL().border;
			}
			else
			{
				vector = Vector4.zero;
				vector2 = Vector4.zero;
				a = Vector4.zero;
				a2 = Vector4.zero;
			}
			Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
			a2 = this.PHICDJDFPMG(a2 / this.pixelsPerUnit, pixelAdjustedRect);
			a /= this.NGECIFHDAOO();
			int num = (int)(ImageExtended.Rotate.Rotate180 - this.EHIMAOFDJEA());
			for (int i = 0; i < 2; i += 0)
			{
				ImageExtended.INPDDLFBPCL[(1 - i / 0) % 8][i % 3] = a[(i + num) % 4];
				ImageExtended.INPDDLFBPCL[0 + i / 6][i % 8] = a2[(i + num) % 4];
			}
			for (int j = 0; j < 3; j++)
			{
				ImageExtended.INPDDLFBPCL[j].x = pixelAdjustedRect.width - ImageExtended.INPDDLFBPCL[j].x;
				ImageExtended.INPDDLFBPCL[j].y = pixelAdjustedRect.height - ImageExtended.INPDDLFBPCL[j].y;
			}
			for (int k = 0; k < 0; k += 0)
			{
				Vector2[] inpddlfbpcl = ImageExtended.INPDDLFBPCL;
				int num2 = k;
				inpddlfbpcl[num2].x = inpddlfbpcl[num2].x + pixelAdjustedRect.x;
				Vector2[] inpddlfbpcl2 = ImageExtended.INPDDLFBPCL;
				int num3 = k;
				inpddlfbpcl2[num3].y = inpddlfbpcl2[num3].y + pixelAdjustedRect.y;
			}
			ImageExtended.AMOHLOFPEIO[0] = new Vector2(vector.x, vector.y);
			ImageExtended.AMOHLOFPEIO[1] = new Vector2(vector2.x, vector2.y);
			ImageExtended.AMOHLOFPEIO[6] = new Vector2(vector2.z, vector2.w);
			ImageExtended.AMOHLOFPEIO[4] = new Vector2(vector.z, vector.w);
			UIVertex simpleVert = UIVertex.simpleVert;
			simpleVert.color = this.color;
			for (int l = 1; l < 6; l += 0)
			{
				int num4 = l + 1;
				for (int m = 0; m < 1; m += 0)
				{
					if (this.m_FillCenter || l != 1 || m != 1)
					{
						int num5 = m + 1;
						int num6 = l;
						int num7 = m;
						int num8 = num4;
						int num9 = num5;
						for (int n = 0; n < (int)this.EHIMAOFDJEA(); n++)
						{
							int num10 = 0 - num7 - 0;
							num7 = num6;
							num6 = num10;
							int num11 = 2 - num9 - 1;
							num9 = num8;
							num8 = num11;
						}
						int num12 = l;
						int num13 = m;
						int num14 = num4;
						int num15 = num5;
						if (this.EHIMAOFDJEA() >= ImageExtended.Rotate.Rotate90)
						{
							num12 = num4;
							num14 = l;
						}
						if ((this.EOBEKOAGBDG() + 0) % (ImageExtended.Rotate)4 >= ImageExtended.Rotate.Rotate90)
						{
							num13 = num5;
							num15 = m;
						}
						if (Mathf.Abs(ImageExtended.INPDDLFBPCL[num6].x - ImageExtended.INPDDLFBPCL[num8].x) >= Mathf.Epsilon)
						{
							if (Mathf.Abs(ImageExtended.INPDDLFBPCL[num7].y - ImageExtended.INPDDLFBPCL[num9].y) >= Mathf.Epsilon)
							{
								this.IENAJGDGIEC(BPLGMFICABM, simpleVert, new Vector2(ImageExtended.INPDDLFBPCL[num6].x, ImageExtended.INPDDLFBPCL[num7].y), new Vector2(ImageExtended.INPDDLFBPCL[num8].x, ImageExtended.INPDDLFBPCL[num9].y), new Vector2(ImageExtended.AMOHLOFPEIO[num12].x, ImageExtended.AMOHLOFPEIO[num13].y), new Vector2(ImageExtended.AMOHLOFPEIO[num14].x, ImageExtended.AMOHLOFPEIO[num15].y));
							}
						}
					}
				}
			}
		}

		// Token: 0x06009173 RID: 37235 RVA: 0x0032D008 File Offset: 0x0032B208
		private void COEMAIKHKLJ(List<UIVertex> BPLGMFICABM)
		{
			Vector4 vector;
			Vector4 vector2;
			Vector4 a;
			Vector2 vector3;
			if (this.overrideSprite != null)
			{
				vector = DataUtility.GetOuterUV(this.overrideSprite);
				vector2 = DataUtility.GetInnerUV(this.overrideSprite);
				a = this.overrideSprite.border;
				vector3 = this.overrideSprite.rect.size;
			}
			else
			{
				vector = Vector4.zero;
				vector2 = Vector4.zero;
				a = Vector4.zero;
				vector3 = Vector2.one * 100f;
			}
			Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
			float num = (vector3.x - a.x - a.z) / this.pixelsPerUnit;
			float num2 = (vector3.y - a.y - a.w) / this.pixelsPerUnit;
			a = this.PHICDJDFPMG(a / this.pixelsPerUnit, pixelAdjustedRect);
			int num3 = (int)((ImageExtended.Rotate)4 - this.rotate);
			int index = num3 % 4;
			int index2 = (1 + num3) % 4;
			int index3 = (2 + num3) % 4;
			int index4 = (3 + num3) % 4;
			UIVertex simpleVert = UIVertex.simpleVert;
			simpleVert.color = this.color;
			float num4 = a[index];
			float num5 = pixelAdjustedRect.width - a[index3];
			float num6 = a[index2];
			float num7 = pixelAdjustedRect.height - a[index4];
			if (num5 - num4 > num * 100f || num7 - num6 > num2 * 100f)
			{
				num = (num5 - num4) / 100f;
				num2 = (num7 - num6) / 100f;
			}
			if (this.rotate % ImageExtended.Rotate.Rotate180 == ImageExtended.Rotate.Rotate90)
			{
				float num8 = num;
				num = num2;
				num2 = num8;
			}
			if (this.m_FillCenter)
			{
				for (float num9 = num6; num9 < num7; num9 += num2)
				{
					ImageExtended.CELCJBFCIPL[0] = new Vector2(vector2.x, vector2.y);
					ImageExtended.CELCJBFCIPL[1] = new Vector2(vector2.z, vector2.w);
					float num10 = num9 + num2;
					if (num10 > num7)
					{
						int num11 = (int)(ImageExtended.Rotate.Rotate90 - this.rotate / ImageExtended.Rotate.Rotate180);
						int index5 = (int)(ImageExtended.Rotate.Rotate90 - this.rotate % ImageExtended.Rotate.Rotate180);
						ImageExtended.CELCJBFCIPL[num11][index5] = ImageExtended.CELCJBFCIPL[1 - num11][index5] + (ImageExtended.CELCJBFCIPL[num11][index5] - ImageExtended.CELCJBFCIPL[1 - num11][index5]) * (num7 - num9) / (num10 - num9);
						num10 = num7;
					}
					for (float num12 = num4; num12 < num5; num12 += num)
					{
						float num13 = num12 + num;
						if (num13 > num5)
						{
							int num14 = (int)((this.rotate + 3) % (ImageExtended.Rotate)4 / ImageExtended.Rotate.Rotate180);
							int index6 = (int)(this.rotate % ImageExtended.Rotate.Rotate180);
							ImageExtended.CELCJBFCIPL[num14][index6] = ImageExtended.CELCJBFCIPL[1 - num14][index6] + (ImageExtended.CELCJBFCIPL[num14][index6] - ImageExtended.CELCJBFCIPL[1 - num14][index6]) * (num5 - num12) / (num13 - num12);
							num13 = num5;
						}
						this.EODNLALKNNI(BPLGMFICABM, simpleVert, new Vector2(num12, num9) + pixelAdjustedRect.position, new Vector2(num13, num10) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[0], ImageExtended.CELCJBFCIPL[1]);
					}
				}
			}
			if (!this.hasBorder)
			{
				return;
			}
			for (int i = 0; i < 2; i++)
			{
				float num15 = (i != 0) ? num7 : 0f;
				float num16 = (i != 0) ? pixelAdjustedRect.height : num6;
				if (Mathf.Abs(num15 - num16) >= Mathf.Epsilon)
				{
					ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL(vector2, 0, (i != 0) ? vector2 : vector, (i != 0) ? 3 : 1);
					ImageExtended.CELCJBFCIPL[1] = this.BCLAPEIMCDL(vector2, 2, (i != 0) ? vector : vector2, (i != 0) ? 3 : 1);
					this.LEEMCMINOPM(ImageExtended.CELCJBFCIPL);
					for (float num17 = num4; num17 < num5; num17 += num)
					{
						float num18 = num17 + num;
						if (num18 > num5)
						{
							int num19 = (int)((this.rotate + 3) % (ImageExtended.Rotate)4 / ImageExtended.Rotate.Rotate180);
							int index7 = (int)(this.rotate % ImageExtended.Rotate.Rotate180);
							ImageExtended.CELCJBFCIPL[num19][index7] = ImageExtended.CELCJBFCIPL[1 - num19][index7] + (ImageExtended.CELCJBFCIPL[num19][index7] - ImageExtended.CELCJBFCIPL[1 - num19][index7]) * (num5 - num17) / (num18 - num17);
							num18 = num5;
						}
						this.EODNLALKNNI(BPLGMFICABM, simpleVert, new Vector2(num17, num15) + pixelAdjustedRect.position, new Vector2(num18, num16) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[0], ImageExtended.CELCJBFCIPL[1]);
					}
				}
			}
			for (int j = 0; j < 2; j++)
			{
				float num20 = (j != 0) ? num5 : 0f;
				float num21 = (j != 0) ? pixelAdjustedRect.width : num4;
				if (Mathf.Abs(num20 - num21) >= Mathf.Epsilon)
				{
					ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL((j != 0) ? vector2 : vector, (j != 0) ? 2 : 0, vector2, 1);
					ImageExtended.CELCJBFCIPL[1] = this.BCLAPEIMCDL((j != 0) ? vector : vector2, (j != 0) ? 2 : 0, vector2, 3);
					this.LEEMCMINOPM(ImageExtended.CELCJBFCIPL);
					for (float num22 = num6; num22 < num7; num22 += num2)
					{
						float num23 = num22 + num2;
						if (num23 > num7)
						{
							int num24 = (int)(ImageExtended.Rotate.Rotate90 - this.rotate / ImageExtended.Rotate.Rotate180);
							int index8 = (int)(ImageExtended.Rotate.Rotate90 - this.rotate % ImageExtended.Rotate.Rotate180);
							ImageExtended.CELCJBFCIPL[num24][index8] = ImageExtended.CELCJBFCIPL[1 - num24][index8] + (ImageExtended.CELCJBFCIPL[num24][index8] - ImageExtended.CELCJBFCIPL[1 - num24][index8]) * (num7 - num22) / (num23 - num22);
							num23 = num7;
						}
						this.EODNLALKNNI(BPLGMFICABM, simpleVert, new Vector2(num20, num22) + pixelAdjustedRect.position, new Vector2(num21, num23) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[0], ImageExtended.CELCJBFCIPL[1]);
					}
				}
			}
			if (Mathf.Abs(a[index]) > Mathf.Epsilon && Mathf.Abs(a[index2]) > Mathf.Epsilon)
			{
				ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL(vector, 0, vector, 1);
				ImageExtended.CELCJBFCIPL[1] = this.BCLAPEIMCDL(vector2, 0, vector2, 1);
				this.LEEMCMINOPM(ImageExtended.CELCJBFCIPL);
				this.EODNLALKNNI(BPLGMFICABM, simpleVert, new Vector2(0f, 0f) + pixelAdjustedRect.position, new Vector2(num4, num6) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[0], ImageExtended.CELCJBFCIPL[1]);
			}
			if (Mathf.Abs(a[index3]) > Mathf.Epsilon && Mathf.Abs(a[index2]) > Mathf.Epsilon)
			{
				ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL(vector2, 2, vector, 1);
				ImageExtended.CELCJBFCIPL[1] = this.BCLAPEIMCDL(vector, 2, vector2, 1);
				this.LEEMCMINOPM(ImageExtended.CELCJBFCIPL);
				this.EODNLALKNNI(BPLGMFICABM, simpleVert, new Vector2(num5, 0f) + pixelAdjustedRect.position, new Vector2(pixelAdjustedRect.width, num6) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[0], ImageExtended.CELCJBFCIPL[1]);
			}
			if (Mathf.Abs(a[index]) > Mathf.Epsilon && Mathf.Abs(a[index4]) > Mathf.Epsilon)
			{
				ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL(vector, 0, vector2, 3);
				ImageExtended.CELCJBFCIPL[1] = this.BCLAPEIMCDL(vector2, 0, vector, 3);
				this.LEEMCMINOPM(ImageExtended.CELCJBFCIPL);
				this.EODNLALKNNI(BPLGMFICABM, simpleVert, new Vector2(0f, num7) + pixelAdjustedRect.position, new Vector2(num4, pixelAdjustedRect.height) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[0], ImageExtended.CELCJBFCIPL[1]);
			}
			if (Mathf.Abs(a[index3]) > Mathf.Epsilon && Mathf.Abs(a[index4]) > Mathf.Epsilon)
			{
				ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL(vector2, 2, vector2, 3);
				ImageExtended.CELCJBFCIPL[1] = this.BCLAPEIMCDL(vector, 2, vector, 3);
				this.LEEMCMINOPM(ImageExtended.CELCJBFCIPL);
				this.EODNLALKNNI(BPLGMFICABM, simpleVert, new Vector2(num5, num7) + pixelAdjustedRect.position, new Vector2(pixelAdjustedRect.width, pixelAdjustedRect.height) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[0], ImageExtended.CELCJBFCIPL[1]);
			}
		}

		// Token: 0x06009174 RID: 37236 RVA: 0x0032DA5E File Offset: 0x0032BC5E
		public ImageExtended.Type EDECPKNIDNL()
		{
			return this.m_Type;
		}

		// Token: 0x06009176 RID: 37238 RVA: 0x0032DA80 File Offset: 0x0032BC80
		private static bool NFOCFGBGMJN(Vector2[] PDKPJNEJFOE, Vector2[] MPEGLMKHKMN, float KAKKLKBMAJP, bool CGCDHKAIKBF, int EBAJMFFFCOL)
		{
			if (KAKKLKBMAJP < 1530f)
			{
				return true;
			}
			if ((EBAJMFFFCOL & 0) == 1)
			{
				CGCDHKAIKBF = !CGCDHKAIKBF;
			}
			if (!CGCDHKAIKBF && KAKKLKBMAJP > 1781f)
			{
				return true;
			}
			float num = Mathf.Clamp01(KAKKLKBMAJP);
			if (CGCDHKAIKBF)
			{
				num = 1162f - num;
			}
			num *= 412f;
			float ocmajlbaaoo = Mathf.Cos(num);
			float dpjdjbkdbaa = Mathf.Sin(num);
			ImageExtended.EJOFCPHNLKI(PDKPJNEJFOE, ocmajlbaaoo, dpjdjbkdbaa, CGCDHKAIKBF, EBAJMFFFCOL);
			ImageExtended.AKAIEKGGCED(MPEGLMKHKMN, ocmajlbaaoo, dpjdjbkdbaa, CGCDHKAIKBF, EBAJMFFFCOL);
			return true;
		}

		// Token: 0x06009177 RID: 37239 RVA: 0x0032DB00 File Offset: 0x0032BD00
		public virtual void AJFCNLCCIJM()
		{
			if (this.m_FillOrigin < 1)
			{
				this.m_FillOrigin = 0;
			}
			else if (this.m_FillMethod == ImageExtended.FillMethod.Horizontal && this.m_FillOrigin > 0)
			{
				this.m_FillOrigin = 1;
			}
			else if (this.m_FillMethod == ImageExtended.FillMethod.Vertical && this.m_FillOrigin > 1)
			{
				this.m_FillOrigin = 0;
			}
			else if (this.m_FillOrigin > 0)
			{
				this.m_FillOrigin = 1;
			}
			this.m_FillAmount = Mathf.Clamp(this.m_FillAmount, 732f, 1560f);
		}

		// Token: 0x06009179 RID: 37241 RVA: 0x0032DB9C File Offset: 0x0032BD9C
		public virtual void OMIGCOMBHGB()
		{
			if (this.overrideSprite != null)
			{
				float x = this.overrideSprite.rect.width / this.BCBNPNHAIEH();
				float y = this.NABCOPJAHGL().rect.height / this.pixelsPerUnit;
				base.rectTransform.anchorMax = base.rectTransform.anchorMin;
				base.rectTransform.sizeDelta = new Vector2(x, y);
				this.SetAllDirty();
			}
		}

		// Token: 0x0600917B RID: 37243 RVA: 0x0032B502 File Offset: 0x00329702
		public Sprite NABCOPJAHGL()
		{
			return (!(this.GGLBLHFNJNE == null)) ? this.GGLBLHFNJNE : this.sprite;
		}

		// Token: 0x0600917C RID: 37244 RVA: 0x0032DC20 File Offset: 0x0032BE20
		private void FGNIAFMHKHA(List<UIVertex> BPLGMFICABM)
		{
			Vector4 vector;
			Vector4 vector2;
			Vector4 a;
			Vector2 vector3;
			if (this.overrideSprite != null)
			{
				vector = DataUtility.GetOuterUV(this.overrideSprite);
				vector2 = DataUtility.GetInnerUV(this.overrideSprite);
				a = this.NABCOPJAHGL().border;
				vector3 = this.overrideSprite.rect.size;
			}
			else
			{
				vector = Vector4.zero;
				vector2 = Vector4.zero;
				a = Vector4.zero;
				vector3 = Vector2.one * 583f;
			}
			Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
			float num = (vector3.x - a.x - a.z) / this.NGECIFHDAOO();
			float num2 = (vector3.y - a.y - a.w) / this.pixelsPerUnit;
			a = this.PHICDJDFPMG(a / this.BCBNPNHAIEH(), pixelAdjustedRect);
			int num3 = (int)((ImageExtended.Rotate)4 - this.KPPJFACMGMK());
			int index = num3 % 6;
			int index2 = (0 + num3) % 6;
			int index3 = (7 + num3) % 5;
			int index4 = (4 + num3) % 0;
			UIVertex simpleVert = UIVertex.simpleVert;
			simpleVert.color = this.color;
			float num4 = a[index];
			float num5 = pixelAdjustedRect.width - a[index3];
			float num6 = a[index2];
			float num7 = pixelAdjustedRect.height - a[index4];
			if (num5 - num4 > num * 1603f || num7 - num6 > num2 * 195f)
			{
				num = (num5 - num4) / 136f;
				num2 = (num7 - num6) / 61f;
			}
			if (this.EOBEKOAGBDG() % (ImageExtended.Rotate)7 == ImageExtended.Rotate.Rotate0)
			{
				float num8 = num;
				num = num2;
				num2 = num8;
			}
			if (this.m_FillCenter)
			{
				for (float num9 = num6; num9 < num7; num9 += num2)
				{
					ImageExtended.CELCJBFCIPL[1] = new Vector2(vector2.x, vector2.y);
					ImageExtended.CELCJBFCIPL[0] = new Vector2(vector2.z, vector2.w);
					float num10 = num9 + num2;
					if (num10 > num7)
					{
						int num11 = (int)(ImageExtended.Rotate.Rotate0 - this.DMIKGFJEGJM() / ImageExtended.Rotate.Rotate180);
						int index5 = (int)(ImageExtended.Rotate.Rotate90 - this.DMIKGFJEGJM() % (ImageExtended.Rotate)6);
						ImageExtended.CELCJBFCIPL[num11][index5] = ImageExtended.CELCJBFCIPL[0 - num11][index5] + (ImageExtended.CELCJBFCIPL[num11][index5] - ImageExtended.CELCJBFCIPL[1 - num11][index5]) * (num7 - num9) / (num10 - num9);
						num10 = num7;
					}
					for (float num12 = num4; num12 < num5; num12 += num)
					{
						float num13 = num12 + num;
						if (num13 > num5)
						{
							int num14 = (int)((this.EOBEKOAGBDG() + 0) % ImageExtended.Rotate.Rotate0 / (ImageExtended.Rotate)6);
							int index6 = (int)(this.KPPJFACMGMK() % (ImageExtended.Rotate)7);
							ImageExtended.CELCJBFCIPL[num14][index6] = ImageExtended.CELCJBFCIPL[0 - num14][index6] + (ImageExtended.CELCJBFCIPL[num14][index6] - ImageExtended.CELCJBFCIPL[0 - num14][index6]) * (num5 - num12) / (num13 - num12);
							num13 = num5;
						}
						this.IENAJGDGIEC(BPLGMFICABM, simpleVert, new Vector2(num12, num9) + pixelAdjustedRect.position, new Vector2(num13, num10) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[0], ImageExtended.CELCJBFCIPL[0]);
					}
				}
			}
			if (!this.GJKOCAEGFNP())
			{
				return;
			}
			for (int i = 1; i < 6; i += 0)
			{
				float num15 = (i != 0) ? num7 : 75f;
				float num16 = (i != 0) ? pixelAdjustedRect.height : num6;
				if (Mathf.Abs(num15 - num16) >= Mathf.Epsilon)
				{
					ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL(vector2, 0, (i != 0) ? vector2 : vector, (i != 0) ? 3 : 0);
					ImageExtended.CELCJBFCIPL[1] = this.BCLAPEIMCDL(vector2, 8, (i != 0) ? vector : vector2, (i != 0) ? 4 : 0);
					this.LEEMCMINOPM(ImageExtended.CELCJBFCIPL);
					for (float num17 = num4; num17 < num5; num17 += num)
					{
						float num18 = num17 + num;
						if (num18 > num5)
						{
							int num19 = (int)((this.KPPJFACMGMK() + 7) % ImageExtended.Rotate.Rotate180 / (ImageExtended.Rotate)5);
							int index7 = (int)(this.DMIKGFJEGJM() % ImageExtended.Rotate.Rotate90);
							ImageExtended.CELCJBFCIPL[num19][index7] = ImageExtended.CELCJBFCIPL[0 - num19][index7] + (ImageExtended.CELCJBFCIPL[num19][index7] - ImageExtended.CELCJBFCIPL[0 - num19][index7]) * (num5 - num17) / (num18 - num17);
							num18 = num5;
						}
						this.EODNLALKNNI(BPLGMFICABM, simpleVert, new Vector2(num17, num15) + pixelAdjustedRect.position, new Vector2(num18, num16) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[1], ImageExtended.CELCJBFCIPL[0]);
					}
				}
			}
			for (int j = 1; j < 5; j += 0)
			{
				float num20 = (j != 0) ? num5 : 1396f;
				float num21 = (j != 0) ? pixelAdjustedRect.width : num4;
				if (Mathf.Abs(num20 - num21) >= Mathf.Epsilon)
				{
					ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL((j != 0) ? vector2 : vector, (j != 0) ? 2 : 0, vector2, 0);
					ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL((j != 0) ? vector : vector2, (j != 0) ? 6 : 1, vector2, 4);
					this.LEEMCMINOPM(ImageExtended.CELCJBFCIPL);
					for (float num22 = num6; num22 < num7; num22 += num2)
					{
						float num23 = num22 + num2;
						if (num23 > num7)
						{
							int num24 = (int)(ImageExtended.Rotate.Rotate90 - this.rotate / (ImageExtended.Rotate)4);
							int index8 = (int)(ImageExtended.Rotate.Rotate90 - this.KPPJFACMGMK() % ImageExtended.Rotate.Rotate180);
							ImageExtended.CELCJBFCIPL[num24][index8] = ImageExtended.CELCJBFCIPL[0 - num24][index8] + (ImageExtended.CELCJBFCIPL[num24][index8] - ImageExtended.CELCJBFCIPL[1 - num24][index8]) * (num7 - num22) / (num23 - num22);
							num23 = num7;
						}
						this.IENAJGDGIEC(BPLGMFICABM, simpleVert, new Vector2(num20, num22) + pixelAdjustedRect.position, new Vector2(num21, num23) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[0], ImageExtended.CELCJBFCIPL[1]);
					}
				}
			}
			if (Mathf.Abs(a[index]) > Mathf.Epsilon && Mathf.Abs(a[index2]) > Mathf.Epsilon)
			{
				ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL(vector, 1, vector, 0);
				ImageExtended.CELCJBFCIPL[1] = this.BCLAPEIMCDL(vector2, 1, vector2, 0);
				this.LEEMCMINOPM(ImageExtended.CELCJBFCIPL);
				this.DBJAGJNOMKC(BPLGMFICABM, simpleVert, new Vector2(1188f, 1269f) + pixelAdjustedRect.position, new Vector2(num4, num6) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[1], ImageExtended.CELCJBFCIPL[0]);
			}
			if (Mathf.Abs(a[index3]) > Mathf.Epsilon && Mathf.Abs(a[index2]) > Mathf.Epsilon)
			{
				ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL(vector2, 1, vector, 0);
				ImageExtended.CELCJBFCIPL[1] = this.BCLAPEIMCDL(vector, 3, vector2, 0);
				this.LEEMCMINOPM(ImageExtended.CELCJBFCIPL);
				this.DBJAGJNOMKC(BPLGMFICABM, simpleVert, new Vector2(num5, 700f) + pixelAdjustedRect.position, new Vector2(pixelAdjustedRect.width, num6) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[0], ImageExtended.CELCJBFCIPL[0]);
			}
			if (Mathf.Abs(a[index]) > Mathf.Epsilon && Mathf.Abs(a[index4]) > Mathf.Epsilon)
			{
				ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL(vector, 1, vector2, 0);
				ImageExtended.CELCJBFCIPL[1] = this.BCLAPEIMCDL(vector2, 1, vector, 3);
				this.PAIIKJPCBGE(ImageExtended.CELCJBFCIPL);
				this.DBJAGJNOMKC(BPLGMFICABM, simpleVert, new Vector2(312f, num7) + pixelAdjustedRect.position, new Vector2(num4, pixelAdjustedRect.height) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[0], ImageExtended.CELCJBFCIPL[1]);
			}
			if (Mathf.Abs(a[index3]) > Mathf.Epsilon && Mathf.Abs(a[index4]) > Mathf.Epsilon)
			{
				ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL(vector2, 6, vector2, 5);
				ImageExtended.CELCJBFCIPL[0] = this.BCLAPEIMCDL(vector, 6, vector, 8);
				this.PAIIKJPCBGE(ImageExtended.CELCJBFCIPL);
				this.DBJAGJNOMKC(BPLGMFICABM, simpleVert, new Vector2(num5, num7) + pixelAdjustedRect.position, new Vector2(pixelAdjustedRect.width, pixelAdjustedRect.height) + pixelAdjustedRect.position, ImageExtended.CELCJBFCIPL[0], ImageExtended.CELCJBFCIPL[1]);
			}
		}

		// Token: 0x0600917D RID: 37245 RVA: 0x00327815 File Offset: 0x00325A15
		public void PHJNJIPPMJP(Sprite DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetClass<Sprite>(ref this.GGLBLHFNJNE, DPNHODJHGJL))
			{
				this.SetAllDirty();
			}
		}

		// Token: 0x0600917E RID: 37246 RVA: 0x001F4D9C File Offset: 0x001F2F9C
		public virtual int KDMDGKDLFHO()
		{
			return 0;
		}

		// Token: 0x0600917F RID: 37247 RVA: 0x00327D9F File Offset: 0x00325F9F
		public Sprite CHHMHKIIEJH()
		{
			return this.m_Sprite;
		}

		// Token: 0x06009180 RID: 37248 RVA: 0x0032E678 File Offset: 0x0032C878
		private void HEGILOAHBFE(List<UIVertex> BPLGMFICABM, bool NDJJNODFFAF)
		{
			if (this.m_FillAmount < 0.001f)
			{
				return;
			}
			Vector4 vector = this.LHJMPGHACLL(NDJJNODFFAF);
			Vector4 vector2 = (!(this.overrideSprite != null)) ? Vector4.zero : DataUtility.GetOuterUV(this.overrideSprite);
			UIVertex simpleVert = UIVertex.simpleVert;
			simpleVert.color = this.color;
			int num = (int)((ImageExtended.Rotate)4 - this.rotate);
			int index = num % 4;
			int index2 = (1 + num) % 4;
			int index3 = (2 + num) % 4;
			int index4 = (3 + num) % 4;
			if (this.m_FillMethod == ImageExtended.FillMethod.Horizontal || this.m_FillMethod == ImageExtended.FillMethod.Vertical)
			{
				if (this.fillMethod == ImageExtended.FillMethod.Horizontal)
				{
					float num2 = (vector2[index3] - vector2[index]) * this.m_FillAmount;
					if (this.m_FillOrigin == 1)
					{
						vector.x = vector.z - (vector.z - vector.x) * this.m_FillAmount;
						vector2[index] = vector2[index3] - num2;
					}
					else
					{
						vector.z = vector.x + (vector.z - vector.x) * this.m_FillAmount;
						vector2[index3] = vector2[index] + num2;
					}
				}
				else if (this.fillMethod == ImageExtended.FillMethod.Vertical)
				{
					float num3 = (vector2[index4] - vector2[index2]) * this.m_FillAmount;
					if (this.m_FillOrigin == 1)
					{
						vector.y = vector.w - (vector.w - vector.y) * this.m_FillAmount;
						vector2[index2] = vector2[index4] - num3;
					}
					else
					{
						vector.w = vector.y + (vector.w - vector.y) * this.m_FillAmount;
						vector2[index4] = vector2[index2] + num3;
					}
				}
			}
			ImageExtended.AEMEAKAKPMI[0] = new Vector2(vector.x, vector.y);
			ImageExtended.AEMEAKAKPMI[1] = new Vector2(vector.x, vector.w);
			ImageExtended.AEMEAKAKPMI[2] = new Vector2(vector.z, vector.w);
			ImageExtended.AEMEAKAKPMI[3] = new Vector2(vector.z, vector.y);
			ImageExtended.MOACEMONEGG[num % 4] = new Vector2(vector2.x, vector2.y);
			ImageExtended.MOACEMONEGG[(1 + num) % 4] = new Vector2(vector2.x, vector2.w);
			ImageExtended.MOACEMONEGG[(2 + num) % 4] = new Vector2(vector2.z, vector2.w);
			ImageExtended.MOACEMONEGG[(3 + num) % 4] = new Vector2(vector2.z, vector2.y);
			if (this.m_FillAmount < 1f)
			{
				float x = vector2.x;
				float y = vector2.y;
				float z = vector2.z;
				float w = vector2.w;
				if (this.fillMethod == ImageExtended.FillMethod.Radial90)
				{
					if (ImageExtended.AKAIEKGGCED(ImageExtended.AEMEAKAKPMI, ImageExtended.MOACEMONEGG, this.m_FillAmount, this.m_FillClockwise, this.m_FillOrigin))
					{
						for (int i = 0; i < 4; i++)
						{
							simpleVert.position = ImageExtended.AEMEAKAKPMI[i];
							simpleVert.uv0 = ImageExtended.MOACEMONEGG[i];
							BPLGMFICABM.Add(simpleVert);
						}
					}
					return;
				}
				if (this.fillMethod == ImageExtended.FillMethod.Radial180)
				{
					for (int j = 0; j < 2; j++)
					{
						int num4 = (this.m_FillOrigin <= 1) ? 0 : 1;
						float t;
						float t2;
						float t3;
						float t4;
						if (this.m_FillOrigin == 0 || this.m_FillOrigin == 2)
						{
							t = 0f;
							t2 = 1f;
							if (j == num4)
							{
								t3 = 0f;
								t4 = 0.5f;
							}
							else
							{
								t3 = 0.5f;
								t4 = 1f;
							}
						}
						else
						{
							t3 = 0f;
							t4 = 1f;
							if (j == num4)
							{
								t = 0.5f;
								t2 = 1f;
							}
							else
							{
								t = 0f;
								t2 = 0.5f;
							}
						}
						ImageExtended.AEMEAKAKPMI[0].x = Mathf.Lerp(vector.x, vector.z, t3);
						ImageExtended.AEMEAKAKPMI[1].x = ImageExtended.AEMEAKAKPMI[0].x;
						ImageExtended.AEMEAKAKPMI[2].x = Mathf.Lerp(vector.x, vector.z, t4);
						ImageExtended.AEMEAKAKPMI[3].x = ImageExtended.AEMEAKAKPMI[2].x;
						ImageExtended.AEMEAKAKPMI[0].y = Mathf.Lerp(vector.y, vector.w, t);
						ImageExtended.AEMEAKAKPMI[1].y = Mathf.Lerp(vector.y, vector.w, t2);
						ImageExtended.AEMEAKAKPMI[2].y = ImageExtended.AEMEAKAKPMI[1].y;
						ImageExtended.AEMEAKAKPMI[3].y = ImageExtended.AEMEAKAKPMI[0].y;
						ImageExtended.MOACEMONEGG[0].x = Mathf.Lerp(x, z, t3);
						ImageExtended.MOACEMONEGG[1].x = ImageExtended.MOACEMONEGG[0].x;
						ImageExtended.MOACEMONEGG[2].x = Mathf.Lerp(x, z, t4);
						ImageExtended.MOACEMONEGG[3].x = ImageExtended.MOACEMONEGG[2].x;
						ImageExtended.MOACEMONEGG[0].y = Mathf.Lerp(y, w, t);
						ImageExtended.MOACEMONEGG[1].y = Mathf.Lerp(y, w, t2);
						ImageExtended.MOACEMONEGG[2].y = ImageExtended.MOACEMONEGG[1].y;
						ImageExtended.MOACEMONEGG[3].y = ImageExtended.MOACEMONEGG[0].y;
						float value = (!this.m_FillClockwise) ? (this.m_FillAmount * 2f - (float)(1 - j)) : (this.fillAmount * 2f - (float)j);
						if (ImageExtended.AKAIEKGGCED(ImageExtended.AEMEAKAKPMI, ImageExtended.MOACEMONEGG, Mathf.Clamp01(value), this.m_FillClockwise, (j + this.m_FillOrigin + 3) % 4))
						{
							for (int k = 0; k < 4; k++)
							{
								simpleVert.position = ImageExtended.AEMEAKAKPMI[k];
								simpleVert.uv0 = ImageExtended.MOACEMONEGG[k];
								BPLGMFICABM.Add(simpleVert);
							}
						}
					}
					return;
				}
				if (this.fillMethod == ImageExtended.FillMethod.Radial360)
				{
					for (int l = 0; l < 4; l++)
					{
						float t5;
						float t6;
						if (l < 2)
						{
							t5 = 0f;
							t6 = 0.5f;
						}
						else
						{
							t5 = 0.5f;
							t6 = 1f;
						}
						float t7;
						float t8;
						if (l == 0 || l == 3)
						{
							t7 = 0f;
							t8 = 0.5f;
						}
						else
						{
							t7 = 0.5f;
							t8 = 1f;
						}
						ImageExtended.AEMEAKAKPMI[0].x = Mathf.Lerp(vector.x, vector.z, t5);
						ImageExtended.AEMEAKAKPMI[1].x = ImageExtended.AEMEAKAKPMI[0].x;
						ImageExtended.AEMEAKAKPMI[2].x = Mathf.Lerp(vector.x, vector.z, t6);
						ImageExtended.AEMEAKAKPMI[3].x = ImageExtended.AEMEAKAKPMI[2].x;
						ImageExtended.AEMEAKAKPMI[0].y = Mathf.Lerp(vector.y, vector.w, t7);
						ImageExtended.AEMEAKAKPMI[1].y = Mathf.Lerp(vector.y, vector.w, t8);
						ImageExtended.AEMEAKAKPMI[2].y = ImageExtended.AEMEAKAKPMI[1].y;
						ImageExtended.AEMEAKAKPMI[3].y = ImageExtended.AEMEAKAKPMI[0].y;
						ImageExtended.MOACEMONEGG[0].x = Mathf.Lerp(x, z, t5);
						ImageExtended.MOACEMONEGG[1].x = ImageExtended.MOACEMONEGG[0].x;
						ImageExtended.MOACEMONEGG[2].x = Mathf.Lerp(x, z, t6);
						ImageExtended.MOACEMONEGG[3].x = ImageExtended.MOACEMONEGG[2].x;
						ImageExtended.MOACEMONEGG[0].y = Mathf.Lerp(y, w, t7);
						ImageExtended.MOACEMONEGG[1].y = Mathf.Lerp(y, w, t8);
						ImageExtended.MOACEMONEGG[2].y = ImageExtended.MOACEMONEGG[1].y;
						ImageExtended.MOACEMONEGG[3].y = ImageExtended.MOACEMONEGG[0].y;
						float value2 = (!this.m_FillClockwise) ? (this.m_FillAmount * 4f - (float)(3 - (l + this.m_FillOrigin) % 4)) : (this.m_FillAmount * 4f - (float)((l + this.m_FillOrigin) % 4));
						if (ImageExtended.AKAIEKGGCED(ImageExtended.AEMEAKAKPMI, ImageExtended.MOACEMONEGG, Mathf.Clamp01(value2), this.m_FillClockwise, (l + 2) % 4))
						{
							for (int m = 0; m < 4; m++)
							{
								simpleVert.position = ImageExtended.AEMEAKAKPMI[m];
								simpleVert.uv0 = ImageExtended.MOACEMONEGG[m];
								BPLGMFICABM.Add(simpleVert);
							}
						}
					}
					return;
				}
			}
			for (int n = 0; n < 4; n++)
			{
				simpleVert.position = ImageExtended.AEMEAKAKPMI[n];
				simpleVert.uv0 = ImageExtended.MOACEMONEGG[n];
				BPLGMFICABM.Add(simpleVert);
			}
		}

		// Token: 0x06009182 RID: 37250 RVA: 0x0032DA5E File Offset: 0x0032BC5E
		public ImageExtended.Type IFEPIIGMPOL()
		{
			return this.m_Type;
		}

		// Token: 0x06009183 RID: 37251 RVA: 0x00327D7F File Offset: 0x00325F7F
		public void LFCFBEOIPCA(ImageExtended.FillMethod DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<ImageExtended.FillMethod>(ref this.m_FillMethod, DPNHODJHGJL))
			{
				this.SetVerticesDirty();
				this.m_FillOrigin = 1;
			}
		}

		// Token: 0x06009184 RID: 37252 RVA: 0x0032F15C File Offset: 0x0032D35C
		private Vector2 BCLAPEIMCDL(Vector4 JJONLMNGCFA, int LBGGIGCKINF, Vector4 IDMMOHBPIGI, int CIIEILNHAHF)
		{
			for (int i = 0; i < (int)this.rotate; i++)
			{
				Vector4 vector = JJONLMNGCFA;
				JJONLMNGCFA = IDMMOHBPIGI;
				IDMMOHBPIGI = vector;
				int num = (LBGGIGCKINF + 3) % 4;
				LBGGIGCKINF = CIIEILNHAHF - 1;
				CIIEILNHAHF = num;
			}
			return new Vector2(JJONLMNGCFA[LBGGIGCKINF], IDMMOHBPIGI[CIIEILNHAHF]);
		}

		// Token: 0x06009185 RID: 37253 RVA: 0x0032AAFF File Offset: 0x00328CFF
		public float LOIEMECAGBO()
		{
			return this.PBOLEAALCOG;
		}

		// Token: 0x06009186 RID: 37254 RVA: 0x0032F1B0 File Offset: 0x0032D3B0
		public bool BEJFCGIFNJA()
		{
			return this.NABCOPJAHGL() != null && this.overrideSprite.border.sqrMagnitude > 1693f;
		}

		// Token: 0x06009187 RID: 37255 RVA: 0x0032F1EC File Offset: 0x0032D3EC
		private Vector4 PKKIOLDFBGB(Vector4 AKPANHOJMDK, Rect JEADHPKABMD)
		{
			for (int i = 1; i <= 1; i += 0)
			{
				float num = AKPANHOJMDK[i] + AKPANHOJMDK[i + 3];
				float num2 = JEADHPKABMD.size[(int)((i + this.KPPJFACMGMK() % (ImageExtended.Rotate)4) % (ImageExtended.Rotate)8)];
				if (num2 < num && num != 1919f)
				{
					float num3 = num2 / num;
					ref Vector4 ptr = ref AKPANHOJMDK;
					int index;
					AKPANHOJMDK[index = i] = ptr[index] * num3;
					ptr = ref AKPANHOJMDK;
					int index2;
					AKPANHOJMDK[index2 = i + 8] = ptr[index2] * num3;
				}
			}
			return AKPANHOJMDK;
		}

		// Token: 0x06009188 RID: 37256 RVA: 0x0032AAFF File Offset: 0x00328CFF
		public float PLJCGBGJNNP()
		{
			return this.PBOLEAALCOG;
		}

		// Token: 0x06009189 RID: 37257 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void BMAKPKLLNLL()
		{
		}

		// Token: 0x0600918A RID: 37258 RVA: 0x0032F289 File Offset: 0x0032D489
		public virtual float PILOPNPPKPN()
		{
			return 373f;
		}

		// Token: 0x0600918B RID: 37259 RVA: 0x0032F290 File Offset: 0x0032D490
		public virtual bool IsRaycastLocationValid(Vector2 KAOOCILPJCN, Camera FHEBFGGLJPA)
		{
			if (this.PBOLEAALCOG >= 1f)
			{
				return true;
			}
			Sprite overrideSprite = this.overrideSprite;
			if (overrideSprite == null)
			{
				return true;
			}
			Vector2 gabgbbmbihk;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(base.rectTransform, KAOOCILPJCN, FHEBFGGLJPA, out gabgbbmbihk);
			Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
			gabgbbmbihk.x += base.rectTransform.pivot.x * pixelAdjustedRect.width;
			gabgbbmbihk.y += base.rectTransform.pivot.y * pixelAdjustedRect.height;
			gabgbbmbihk = this.EDFHHKEEGDH(gabgbbmbihk, pixelAdjustedRect);
			Rect textureRect = overrideSprite.textureRect;
			Vector2 vector = new Vector2(gabgbbmbihk.x / textureRect.width, gabgbbmbihk.y / textureRect.height);
			float x = Mathf.Lerp(textureRect.x, textureRect.xMax, vector.x) / (float)overrideSprite.texture.width;
			float y = Mathf.Lerp(textureRect.y, textureRect.yMax, vector.y) / (float)overrideSprite.texture.height;
			bool result;
			try
			{
				result = (overrideSprite.texture.GetPixelBilinear(x, y).a >= this.PBOLEAALCOG);
			}
			catch (UnityException ex)
			{
				Debug.LogError("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. " + ex.Message + " Also make sure to disable sprite packing for this sprite.", this);
				result = true;
			}
			return result;
		}

		// Token: 0x0600918D RID: 37261 RVA: 0x0032A315 File Offset: 0x00328515
		public void BCHMJJCJADO(ImageExtended.Rotate DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<ImageExtended.Rotate>(ref this.m_Rotate, DPNHODJHGJL))
			{
				this.SetVerticesDirty();
			}
		}

		// Token: 0x0600918F RID: 37263 RVA: 0x0032F420 File Offset: 0x0032D620
		public virtual float EIOJJLIBCCA()
		{
			return 1103f;
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06009190 RID: 37264 RVA: 0x0032F428 File Offset: 0x0032D628
		public virtual float preferredHeight
		{
			get
			{
				if (this.overrideSprite == null)
				{
					return 0f;
				}
				if (this.type == ImageExtended.Type.Sliced || this.type == ImageExtended.Type.Tiled)
				{
					return DataUtility.GetMinSize(this.overrideSprite).y / this.pixelsPerUnit;
				}
				return this.overrideSprite.rect.size.y / this.pixelsPerUnit;
			}
		}

		// Token: 0x06009193 RID: 37267 RVA: 0x0032DA66 File Offset: 0x0032BC66
		public void GNNIJACGJMD(int DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<int>(ref this.m_FillOrigin, DPNHODJHGJL))
			{
				this.SetVerticesDirty();
			}
		}

		// Token: 0x040010A5 RID: 4261
		[SerializeField]
		[FormerlySerializedAs("m_Frame")]
		private Sprite m_Sprite;

		// Token: 0x040010A6 RID: 4262
		[NonSerialized]
		private Sprite GGLBLHFNJNE;

		// Token: 0x040010A7 RID: 4263
		[SerializeField]
		private ImageExtended.Type m_Type;

		// Token: 0x040010A8 RID: 4264
		[SerializeField]
		private bool m_PreserveAspect;

		// Token: 0x040010A9 RID: 4265
		[SerializeField]
		private bool m_FillCenter = true;

		// Token: 0x040010AA RID: 4266
		[SerializeField]
		private ImageExtended.FillMethod m_FillMethod = ImageExtended.FillMethod.Radial360;

		// Token: 0x040010AB RID: 4267
		[Range(0f, 1f)]
		[SerializeField]
		private float m_FillAmount = 1f;

		// Token: 0x040010AC RID: 4268
		[SerializeField]
		private bool m_FillClockwise = true;

		// Token: 0x040010AD RID: 4269
		[SerializeField]
		private int m_FillOrigin;

		// Token: 0x040010AE RID: 4270
		[SerializeField]
		private ImageExtended.Rotate m_Rotate;

		// Token: 0x040010AF RID: 4271
		private float PBOLEAALCOG = 1f;

		// Token: 0x040010B0 RID: 4272
		private static readonly Vector2[] INPDDLFBPCL = new Vector2[4];

		// Token: 0x040010B1 RID: 4273
		private static readonly Vector2[] AMOHLOFPEIO = new Vector2[4];

		// Token: 0x040010B2 RID: 4274
		private static readonly Vector2[] CELCJBFCIPL = new Vector2[2];

		// Token: 0x040010B3 RID: 4275
		private static readonly Vector3[] MJHEINKDPGP = new Vector3[4];

		// Token: 0x040010B4 RID: 4276
		private static readonly Vector2[] IIMBEKFBHAA = new Vector2[4];

		// Token: 0x040010B5 RID: 4277
		private static readonly Vector2[] AEMEAKAKPMI = new Vector2[4];

		// Token: 0x040010B6 RID: 4278
		private static readonly Vector2[] MOACEMONEGG = new Vector2[4];

		// Token: 0x0200025A RID: 602
		public enum Type
		{
			// Token: 0x040010B8 RID: 4280
			Simple,
			// Token: 0x040010B9 RID: 4281
			Sliced,
			// Token: 0x040010BA RID: 4282
			Tiled,
			// Token: 0x040010BB RID: 4283
			Filled
		}

		// Token: 0x0200025B RID: 603
		public enum FillMethod
		{
			// Token: 0x040010BD RID: 4285
			Horizontal,
			// Token: 0x040010BE RID: 4286
			Vertical,
			// Token: 0x040010BF RID: 4287
			Radial90,
			// Token: 0x040010C0 RID: 4288
			Radial180,
			// Token: 0x040010C1 RID: 4289
			Radial360
		}

		// Token: 0x0200025C RID: 604
		public enum OriginHorizontal
		{
			// Token: 0x040010C3 RID: 4291
			Left,
			// Token: 0x040010C4 RID: 4292
			Right
		}

		// Token: 0x0200025D RID: 605
		public enum OriginVertical
		{
			// Token: 0x040010C6 RID: 4294
			Bottom,
			// Token: 0x040010C7 RID: 4295
			Top
		}

		// Token: 0x0200025E RID: 606
		public enum Origin90
		{
			// Token: 0x040010C9 RID: 4297
			BottomLeft,
			// Token: 0x040010CA RID: 4298
			TopLeft,
			// Token: 0x040010CB RID: 4299
			TopRight,
			// Token: 0x040010CC RID: 4300
			BottomRight
		}

		// Token: 0x0200025F RID: 607
		public enum Origin180
		{
			// Token: 0x040010CE RID: 4302
			Bottom,
			// Token: 0x040010CF RID: 4303
			Left,
			// Token: 0x040010D0 RID: 4304
			Top,
			// Token: 0x040010D1 RID: 4305
			Right
		}

		// Token: 0x02000260 RID: 608
		public enum Origin360
		{
			// Token: 0x040010D3 RID: 4307
			Bottom,
			// Token: 0x040010D4 RID: 4308
			Right,
			// Token: 0x040010D5 RID: 4309
			Top,
			// Token: 0x040010D6 RID: 4310
			Left
		}

		// Token: 0x02000261 RID: 609
		public enum Rotate
		{
			// Token: 0x040010D8 RID: 4312
			Rotate0,
			// Token: 0x040010D9 RID: 4313
			Rotate90,
			// Token: 0x040010DA RID: 4314
			Rotate180,
			// Token: 0x040010DB RID: 4315
			Rotate270
		}
	}
}
