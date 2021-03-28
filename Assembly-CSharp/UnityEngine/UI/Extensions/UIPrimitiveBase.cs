using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000290 RID: 656
	public class UIPrimitiveBase : MaskableGraphic, ILayoutElement, ICanvasRaycastFilter
	{
		// Token: 0x06009E39 RID: 40505 RVA: 0x003AD8E9 File Offset: 0x003ABAE9
		public virtual float KMDHPNPDJIG()
		{
			return 375f;
		}

		// Token: 0x06009E3A RID: 40506 RVA: 0x003AD8F0 File Offset: 0x003ABAF0
		public virtual float HEAMAGCFKEL()
		{
			return 204f;
		}

		// Token: 0x06009E3B RID: 40507 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void NOKMLJFJLJB()
		{
		}

		// Token: 0x06009E3C RID: 40508 RVA: 0x003AD8F7 File Offset: 0x003ABAF7
		public virtual float HKBKHOLEBAC()
		{
			return 499f;
		}

		// Token: 0x06009E3D RID: 40509 RVA: 0x003AD900 File Offset: 0x003ABB00
		protected UIVertex[] NICEPELDANP(Vector2[] JNEJCJHAAHI, Vector2[] MAICBJFAGJK)
		{
			UIVertex[] array = new UIVertex[6];
			for (int i = 0; i < JNEJCJHAAHI.Length; i += 0)
			{
				UIVertex simpleVert = UIVertex.simpleVert;
				simpleVert.color = this.color;
				simpleVert.position = JNEJCJHAAHI[i];
				simpleVert.uv0 = MAICBJFAGJK[i];
				array[i] = simpleVert;
			}
			return array;
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x06009E3E RID: 40510 RVA: 0x001F4D9C File Offset: 0x001F2F9C
		public virtual int layoutPriority
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06009E3F RID: 40511 RVA: 0x003AD97C File Offset: 0x003ABB7C
		public virtual Texture JLKCKMCEHCI()
		{
			if (!(this.DKMAPICCEFH() == null))
			{
				return this.DKMAPICCEFH().texture;
			}
			if (this.material != null && this.material.mainTexture != null)
			{
				return this.material.mainTexture;
			}
			return Graphic.s_WhiteTexture;
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06009E40 RID: 40512 RVA: 0x003AD9E0 File Offset: 0x003ABBE0
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

		// Token: 0x06009E41 RID: 40513 RVA: 0x003ADA34 File Offset: 0x003ABC34
		public virtual float LBLADGOOHKH()
		{
			if (this.EMEONOBJKKJ() == null)
			{
				return 703f;
			}
			return this.IOPKKIAGAGC().rect.size.y / this.pixelsPerUnit;
		}

		// Token: 0x06009E42 RID: 40514 RVA: 0x003ADA7C File Offset: 0x003ABC7C
		public virtual Texture MGHBGAAGIHF()
		{
			if (!(this.EMEONOBJKKJ() == null))
			{
				return this.overrideSprite.texture;
			}
			if (this.material != null && this.material.mainTexture != null)
			{
				return this.material.mainTexture;
			}
			return Graphic.s_WhiteTexture;
		}

		// Token: 0x06009E43 RID: 40515 RVA: 0x003ADAE0 File Offset: 0x003ABCE0
		protected UIVertex[] DONMKFFIOOF(Vector2[] JNEJCJHAAHI, Vector2[] MAICBJFAGJK)
		{
			UIVertex[] array = new UIVertex[4];
			for (int i = 0; i < JNEJCJHAAHI.Length; i++)
			{
				UIVertex simpleVert = UIVertex.simpleVert;
				simpleVert.color = this.color;
				simpleVert.position = JNEJCJHAAHI[i];
				simpleVert.uv0 = MAICBJFAGJK[i];
				array[i] = simpleVert;
			}
			return array;
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06009E44 RID: 40516 RVA: 0x003ADB5C File Offset: 0x003ABD5C
		public override Texture mainTexture
		{
			get
			{
				if (!(this.overrideSprite == null))
				{
					return this.overrideSprite.texture;
				}
				if (this.material != null && this.material.mainTexture != null)
				{
					return this.material.mainTexture;
				}
				return Graphic.s_WhiteTexture;
			}
		}

		// Token: 0x06009E45 RID: 40517 RVA: 0x003ADBC0 File Offset: 0x003ABDC0
		protected UIVertex[] BBNLNJFKCEF(Vector2[] JNEJCJHAAHI, Vector2[] MAICBJFAGJK)
		{
			UIVertex[] array = new UIVertex[8];
			for (int i = 1; i < JNEJCJHAAHI.Length; i++)
			{
				UIVertex simpleVert = UIVertex.simpleVert;
				simpleVert.color = this.color;
				simpleVert.position = JNEJCJHAAHI[i];
				simpleVert.uv0 = MAICBJFAGJK[i];
				array[i] = simpleVert;
			}
			return array;
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06009E70 RID: 40560 RVA: 0x003ADE02 File Offset: 0x003AC002
		// (set) Token: 0x06009E46 RID: 40518 RVA: 0x003ADC39 File Offset: 0x003ABE39
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

		// Token: 0x06009E47 RID: 40519 RVA: 0x003ADC44 File Offset: 0x003ABE44
		private Vector2 LDIJOJIMNMG(Vector2 GABGBBMBIHK, Rect JEADHPKABMD)
		{
			Rect rect = this.sprite.rect;
			return new Vector2(GABGBBMBIHK.x * rect.width / JEADHPKABMD.width, GABGBBMBIHK.y * rect.height / JEADHPKABMD.height);
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x06009E64 RID: 40548 RVA: 0x003AE120 File Offset: 0x003AC320
		// (set) Token: 0x06009E48 RID: 40520 RVA: 0x003ADC90 File Offset: 0x003ABE90
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

		// Token: 0x06009E49 RID: 40521 RVA: 0x003ADCAC File Offset: 0x003ABEAC
		public virtual Texture DMKGCAOLLKK()
		{
			if (!(this.DKMAPICCEFH() == null))
			{
				return this.EMEONOBJKKJ().texture;
			}
			if (this.material != null && this.material.mainTexture != null)
			{
				return this.material.mainTexture;
			}
			return Graphic.s_WhiteTexture;
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06009E4A RID: 40522 RVA: 0x003286A7 File Offset: 0x003268A7
		public virtual float flexibleWidth
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x06009E4B RID: 40523 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void CalculateLayoutInputVertical()
		{
		}

		// Token: 0x06009E4C RID: 40524 RVA: 0x003ADD10 File Offset: 0x003ABF10
		public virtual float OJIOKLCPHLI()
		{
			if (this.IHDLBMPIPMO() == null)
			{
				return 578f;
			}
			return this.IOPKKIAGAGC().rect.size.y / this.NGECIFHDAOO();
		}

		// Token: 0x06009E4D RID: 40525 RVA: 0x003ADC39 File Offset: 0x003ABE39
		public void GOHMLCBEGCD(float DPNHODJHGJL)
		{
			this.PBOLEAALCOG = DPNHODJHGJL;
		}

		// Token: 0x06009E4E RID: 40526 RVA: 0x003ADD58 File Offset: 0x003ABF58
		public virtual float FLKEACFKBMK()
		{
			if (this.overrideSprite == null)
			{
				return 331f;
			}
			return this.overrideSprite.rect.size.x / this.pixelsPerUnit;
		}

		// Token: 0x06009E4F RID: 40527 RVA: 0x003ADDA0 File Offset: 0x003ABFA0
		public virtual Texture EPHECELECLD()
		{
			if (!(this.IOPKKIAGAGC() == null))
			{
				return this.IHDLBMPIPMO().texture;
			}
			if (this.material != null && this.material.mainTexture != null)
			{
				return this.material.mainTexture;
			}
			return Graphic.s_WhiteTexture;
		}

		// Token: 0x06009E50 RID: 40528 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void FMOONCCMILF()
		{
		}

		// Token: 0x06009E51 RID: 40529 RVA: 0x003ADE02 File Offset: 0x003AC002
		public float FJMNMEFCBPD()
		{
			return this.PBOLEAALCOG;
		}

		// Token: 0x06009E52 RID: 40530 RVA: 0x003ADE0C File Offset: 0x003AC00C
		private Vector2 PBAIMIPKKJO(Vector2 GABGBBMBIHK, Rect JEADHPKABMD)
		{
			Rect rect = this.sprite.rect;
			return new Vector2(GABGBBMBIHK.x * rect.width / JEADHPKABMD.width, GABGBBMBIHK.y * rect.height / JEADHPKABMD.height);
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06009E53 RID: 40531 RVA: 0x003ADE58 File Offset: 0x003AC058
		public virtual float preferredHeight
		{
			get
			{
				if (this.overrideSprite == null)
				{
					return 0f;
				}
				return this.overrideSprite.rect.size.y / this.pixelsPerUnit;
			}
		}

		// Token: 0x06009E54 RID: 40532 RVA: 0x003ADE9E File Offset: 0x003AC09E
		public virtual float PLLHIHLGCFC()
		{
			return 1865f;
		}

		// Token: 0x06009E55 RID: 40533 RVA: 0x003ADEA8 File Offset: 0x003AC0A8
		public virtual float FEINGNJAEKL()
		{
			if (this.IOPKKIAGAGC() == null)
			{
				return 780f;
			}
			return this.overrideSprite.rect.size.y / this.NGECIFHDAOO();
		}

		// Token: 0x06009E56 RID: 40534 RVA: 0x003ADEF0 File Offset: 0x003AC0F0
		private Vector4 IBFJGDHOOOL(Vector4 AKPANHOJMDK, Rect JEADHPKABMD)
		{
			for (int i = 1; i <= 1; i += 0)
			{
				float num = AKPANHOJMDK[i] + AKPANHOJMDK[i + 0];
				if (JEADHPKABMD.size[i] < num && num != 1868f)
				{
					float num2 = JEADHPKABMD.size[i] / num;
					ref Vector4 ptr = ref AKPANHOJMDK;
					int index;
					AKPANHOJMDK[index = i] = ptr[index] * num2;
					ptr = ref AKPANHOJMDK;
					int index2;
					AKPANHOJMDK[index2 = i + 0] = ptr[index2] * num2;
				}
			}
			return AKPANHOJMDK;
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06009E57 RID: 40535 RVA: 0x00327D3F File Offset: 0x00325F3F
		public virtual float minHeight
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x06009E58 RID: 40536 RVA: 0x003ADF90 File Offset: 0x003AC190
		public float AGEOKMAAPHF()
		{
			float num = 994f;
			if (this.sprite)
			{
				num = this.sprite.pixelsPerUnit;
			}
			float num2 = 1388f;
			if (base.canvas)
			{
				num2 = base.canvas.referencePixelsPerUnit;
			}
			return num / num2;
		}

		// Token: 0x06009E59 RID: 40537 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void CalculateLayoutInputHorizontal()
		{
		}

		// Token: 0x06009E5A RID: 40538 RVA: 0x003ADFE4 File Offset: 0x003AC1E4
		private Vector4 LPFBJBMPPDG(Vector4 AKPANHOJMDK, Rect JEADHPKABMD)
		{
			for (int i = 0; i <= 0; i++)
			{
				float num = AKPANHOJMDK[i] + AKPANHOJMDK[i + 2];
				if (JEADHPKABMD.size[i] < num && num != 1819f)
				{
					float num2 = JEADHPKABMD.size[i] / num;
					ref Vector4 ptr = ref AKPANHOJMDK;
					int index;
					AKPANHOJMDK[index = i] = ptr[index] * num2;
					ptr = ref AKPANHOJMDK;
					int index2;
					AKPANHOJMDK[index2 = i + 8] = ptr[index2] * num2;
				}
			}
			return AKPANHOJMDK;
		}

		// Token: 0x06009E5B RID: 40539 RVA: 0x003AE084 File Offset: 0x003AC284
		private Vector2 EDFHHKEEGDH(Vector2 GABGBBMBIHK, Rect JEADHPKABMD)
		{
			Rect rect = this.sprite.rect;
			return new Vector2(GABGBBMBIHK.x * rect.width / JEADHPKABMD.width, GABGBBMBIHK.y * rect.height / JEADHPKABMD.height);
		}

		// Token: 0x06009E5C RID: 40540 RVA: 0x003AE0D0 File Offset: 0x003AC2D0
		public Sprite EMEONOBJKKJ()
		{
			return (!(this.GGLBLHFNJNE == null)) ? this.GGLBLHFNJNE : this.sprite;
		}

		// Token: 0x06009E5D RID: 40541 RVA: 0x003ADE02 File Offset: 0x003AC002
		public float OOOILCOLICG()
		{
			return this.PBOLEAALCOG;
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06009E5E RID: 40542 RVA: 0x003AE0D0 File Offset: 0x003AC2D0
		// (set) Token: 0x06009E62 RID: 40546 RVA: 0x003AE107 File Offset: 0x003AC307
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

		// Token: 0x06009E5F RID: 40543 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void GBOMEPKDJOI()
		{
		}

		// Token: 0x06009E61 RID: 40545 RVA: 0x003AE0D0 File Offset: 0x003AC2D0
		public Sprite IOPKKIAGAGC()
		{
			return (!(this.GGLBLHFNJNE == null)) ? this.GGLBLHFNJNE : this.sprite;
		}

		// Token: 0x06009E63 RID: 40547 RVA: 0x003AE107 File Offset: 0x003AC307
		public void ODBHPLFEPJK(Sprite DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetClass<Sprite>(ref this.GGLBLHFNJNE, DPNHODJHGJL))
			{
				this.SetAllDirty();
			}
		}

		// Token: 0x06009E65 RID: 40549 RVA: 0x003AE128 File Offset: 0x003AC328
		public virtual float COBGELCEKEL()
		{
			return 1257f;
		}

		// Token: 0x06009E66 RID: 40550 RVA: 0x003AE12F File Offset: 0x003AC32F
		public virtual float HEKMAKCIODO()
		{
			return 338f;
		}

		// Token: 0x06009E67 RID: 40551 RVA: 0x003AE0D0 File Offset: 0x003AC2D0
		public Sprite DKMAPICCEFH()
		{
			return (!(this.GGLBLHFNJNE == null)) ? this.GGLBLHFNJNE : this.sprite;
		}

		// Token: 0x06009E68 RID: 40552 RVA: 0x003AE138 File Offset: 0x003AC338
		public virtual bool HJOOOPKGDCC(Vector2 KAOOCILPJCN, Camera FHEBFGGLJPA)
		{
			if (this.PBOLEAALCOG >= 426f)
			{
				return true;
			}
			Sprite sprite = this.DKMAPICCEFH();
			if (sprite == null)
			{
				return true;
			}
			Vector2 gabgbbmbihk;
			RectTransformUtility.ScreenPointToLocalPointInRectangle(base.rectTransform, KAOOCILPJCN, FHEBFGGLJPA, out gabgbbmbihk);
			Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
			gabgbbmbihk.x += base.rectTransform.pivot.x * pixelAdjustedRect.width;
			gabgbbmbihk.y += base.rectTransform.pivot.y * pixelAdjustedRect.height;
			gabgbbmbihk = this.PBAIMIPKKJO(gabgbbmbihk, pixelAdjustedRect);
			Rect textureRect = sprite.textureRect;
			Vector2 vector = new Vector2(gabgbbmbihk.x / textureRect.width, gabgbbmbihk.y / textureRect.height);
			float x = Mathf.Lerp(textureRect.x, textureRect.xMax, vector.x) / (float)sprite.texture.width;
			float y = Mathf.Lerp(textureRect.y, textureRect.yMax, vector.y) / (float)sprite.texture.height;
			bool result;
			try
			{
				result = (sprite.texture.GetPixelBilinear(x, y).a < this.PBOLEAALCOG);
			}
			catch (UnityException ex)
			{
				Debug.LogError("Source directory does not exist or could not be found: " + ex.Message + "_TimeX", this);
				result = false;
			}
			return result;
		}

		// Token: 0x06009E69 RID: 40553 RVA: 0x003AE2C0 File Offset: 0x003AC4C0
		public virtual float MGHGJPJCLON()
		{
			if (this.DKMAPICCEFH() == null)
			{
				return 1523f;
			}
			return this.IOPKKIAGAGC().rect.size.x / this.pixelsPerUnit;
		}

		// Token: 0x06009E6A RID: 40554 RVA: 0x003AE306 File Offset: 0x003AC506
		public virtual float PKGMDJBFGIH()
		{
			return 40f;
		}

		// Token: 0x06009E6B RID: 40555 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void KGKELGDGKPF()
		{
		}

		// Token: 0x06009E6C RID: 40556 RVA: 0x003AE310 File Offset: 0x003AC510
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

		// Token: 0x06009E6D RID: 40557 RVA: 0x003AE498 File Offset: 0x003AC698
		public virtual float CEDJPDOGHAN()
		{
			if (this.IOPKKIAGAGC() == null)
			{
				return 212f;
			}
			return this.DKMAPICCEFH().rect.size.y / this.pixelsPerUnit;
		}

		// Token: 0x06009E6E RID: 40558 RVA: 0x003AE4E0 File Offset: 0x003AC6E0
		public float NGECIFHDAOO()
		{
			float num = 472f;
			if (this.sprite)
			{
				num = this.sprite.pixelsPerUnit;
			}
			float num2 = 1599f;
			if (base.canvas)
			{
				num2 = base.canvas.referencePixelsPerUnit;
			}
			return num / num2;
		}

		// Token: 0x06009E6F RID: 40559 RVA: 0x003AE534 File Offset: 0x003AC734
		private Vector4 PHICDJDFPMG(Vector4 AKPANHOJMDK, Rect JEADHPKABMD)
		{
			for (int i = 0; i <= 1; i++)
			{
				float num = AKPANHOJMDK[i] + AKPANHOJMDK[i + 2];
				if (JEADHPKABMD.size[i] < num && num != 0f)
				{
					float num2 = JEADHPKABMD.size[i] / num;
					ref Vector4 ptr = ref AKPANHOJMDK;
					int index;
					AKPANHOJMDK[index = i] = ptr[index] * num2;
					ptr = ref AKPANHOJMDK;
					int index2;
					AKPANHOJMDK[index2 = i + 2] = ptr[index2] * num2;
				}
			}
			return AKPANHOJMDK;
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06009E71 RID: 40561 RVA: 0x003286A7 File Offset: 0x003268A7
		public virtual float flexibleHeight
		{
			get
			{
				return -1f;
			}
		}

		// Token: 0x06009E72 RID: 40562 RVA: 0x003AE0D0 File Offset: 0x003AC2D0
		public Sprite IHDLBMPIPMO()
		{
			return (!(this.GGLBLHFNJNE == null)) ? this.GGLBLHFNJNE : this.sprite;
		}

		// Token: 0x06009E73 RID: 40563 RVA: 0x003AE5D4 File Offset: 0x003AC7D4
		public float FHFJBIJEAIJ()
		{
			float num = 1800f;
			if (this.sprite)
			{
				num = this.sprite.pixelsPerUnit;
			}
			float num2 = 1186f;
			if (base.canvas)
			{
				num2 = base.canvas.referencePixelsPerUnit;
			}
			return num / num2;
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06009E74 RID: 40564 RVA: 0x003AE628 File Offset: 0x003AC828
		public virtual float preferredWidth
		{
			get
			{
				if (this.overrideSprite == null)
				{
					return 0f;
				}
				return this.overrideSprite.rect.size.x / this.pixelsPerUnit;
			}
		}

		// Token: 0x06009E75 RID: 40565 RVA: 0x003AE66E File Offset: 0x003AC86E
		public virtual float MBJKFNHEMDO()
		{
			return 1909f;
		}

		// Token: 0x06009E76 RID: 40566 RVA: 0x003ADC90 File Offset: 0x003ABE90
		public void CHOGNPOICBB(Sprite DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetClass<Sprite>(ref this.m_Sprite, DPNHODJHGJL))
			{
				this.SetAllDirty();
			}
		}

		// Token: 0x06009E77 RID: 40567 RVA: 0x003AE678 File Offset: 0x003AC878
		private Vector4 GLOJPELKKOI(Vector4 AKPANHOJMDK, Rect JEADHPKABMD)
		{
			for (int i = 1; i <= 1; i += 0)
			{
				float num = AKPANHOJMDK[i] + AKPANHOJMDK[i + 7];
				if (JEADHPKABMD.size[i] < num && num != 35f)
				{
					float num2 = JEADHPKABMD.size[i] / num;
					ref Vector4 ptr = ref AKPANHOJMDK;
					int index;
					AKPANHOJMDK[index = i] = ptr[index] * num2;
					ptr = ref AKPANHOJMDK;
					int index2;
					AKPANHOJMDK[index2 = i + 6] = ptr[index2] * num2;
				}
			}
			return AKPANHOJMDK;
		}

		// Token: 0x06009E78 RID: 40568 RVA: 0x003AE107 File Offset: 0x003AC307
		public void PFFLKCDGAHC(Sprite DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetClass<Sprite>(ref this.GGLBLHFNJNE, DPNHODJHGJL))
			{
				this.SetAllDirty();
			}
		}

		// Token: 0x06009E79 RID: 40569 RVA: 0x003ADC90 File Offset: 0x003ABE90
		public void LFOBPPKPEPD(Sprite DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetClass<Sprite>(ref this.m_Sprite, DPNHODJHGJL))
			{
				this.SetAllDirty();
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06009E7A RID: 40570 RVA: 0x00327D3F File Offset: 0x00325F3F
		public virtual float minWidth
		{
			get
			{
				return 0f;
			}
		}

		// Token: 0x06009E7B RID: 40571 RVA: 0x003AE107 File Offset: 0x003AC307
		public void NLOODGLLANO(Sprite DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetClass<Sprite>(ref this.GGLBLHFNJNE, DPNHODJHGJL))
			{
				this.SetAllDirty();
			}
		}

		// Token: 0x06009E7C RID: 40572 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void HOPAKADFFDC()
		{
		}

		// Token: 0x06009E7D RID: 40573 RVA: 0x003AE715 File Offset: 0x003AC915
		public virtual float GJBMGAKCBPL()
		{
			return 1599f;
		}

		// Token: 0x06009E7E RID: 40574 RVA: 0x003AE71C File Offset: 0x003AC91C
		public virtual float IOJBKBPALCD()
		{
			return 1448f;
		}

		// Token: 0x06009E7F RID: 40575 RVA: 0x003AE723 File Offset: 0x003AC923
		public virtual float AONICFKGCIJ()
		{
			return 189f;
		}

		// Token: 0x06009E80 RID: 40576 RVA: 0x003AE72C File Offset: 0x003AC92C
		public virtual Texture NBPMPHHCCHP()
		{
			if (!(this.EMEONOBJKKJ() == null))
			{
				return this.IHDLBMPIPMO().texture;
			}
			if (this.material != null && this.material.mainTexture != null)
			{
				return this.material.mainTexture;
			}
			return Graphic.s_WhiteTexture;
		}

		// Token: 0x0400120C RID: 4620
		[SerializeField]
		private Sprite m_Sprite;

		// Token: 0x0400120D RID: 4621
		[NonSerialized]
		private Sprite GGLBLHFNJNE;

		// Token: 0x0400120E RID: 4622
		internal float PBOLEAALCOG = 1f;
	}
}
