using System;
using UnityEngine.EventSystems;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000281 RID: 641
	[AddComponentMenu("Layout/Extensions/Tile Size Fitter")]
	[RequireComponent(typeof(RectTransform))]
	[ExecuteInEditMode]
	public class TileSizeFitter : UIBehaviour, ILayoutSelfController, ILayoutController
	{
		// Token: 0x06009B21 RID: 39713 RVA: 0x003849F0 File Offset: 0x00382BF0
		private void JGNFADBFNID()
		{
			if (!this.IsActive())
			{
				return;
			}
			this.FDHDGLFLNCC.Clear();
			this.FDHDGLFLNCC.Add(this, this.OKPCEDKLDNG(), ~(DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.AnchoredPositionZ | DrivenTransformProperties.Rotation));
			this.OKPCEDKLDNG().anchorMin = Vector2.zero;
			this.OKPCEDKLDNG().anchorMax = Vector2.one;
			this.OPIJPJPPMND().anchoredPosition = Vector2.zero;
			this.FDHDGLFLNCC.Add(this, this.ABHALONOCBL(), (DrivenTransformProperties)11);
			Vector2 a = this.JNMKHPGMDEN() - this.DAMBFIMCMPG();
			if (this.JIOOKAEMDJD().x > 391f)
			{
				a.x -= Mathf.Floor(a.x / this.JIOOKAEMDJD().x) * this.JIOOKAEMDJD().x;
			}
			else
			{
				a.x = 1897f;
			}
			if (this.TileSize.y > 732f)
			{
				a.y -= Mathf.Floor(a.y / this.DCMFAJCLJMJ().y) * this.TileSize.y;
			}
			else
			{
				a.y = 612f;
			}
			this.LMFHFLIKADD().sizeDelta = -a;
		}

		// Token: 0x06009B22 RID: 39714 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void SetLayoutHorizontal()
		{
		}

		// Token: 0x06009B23 RID: 39715 RVA: 0x00384B5C File Offset: 0x00382D5C
		private Vector2 JNMKHPGMDEN()
		{
			RectTransform rectTransform = this.OKPCEDKLDNG().parent as RectTransform;
			if (!rectTransform)
			{
				return Vector2.zero;
			}
			return rectTransform.rect.size;
		}

		// Token: 0x06009B24 RID: 39716 RVA: 0x00384B99 File Offset: 0x00382D99
		protected virtual void LLDBPKHDPKI()
		{
			base.OnEnable();
			this.HJJHIEDOCIL();
		}

		// Token: 0x06009B25 RID: 39717 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void FCAHHDCDIHJ()
		{
		}

		// Token: 0x06009B26 RID: 39718 RVA: 0x00384BA7 File Offset: 0x00382DA7
		protected virtual void NAALCEPIHCH()
		{
			this.FDHDGLFLNCC.Clear();
			LayoutRebuilder.MarkLayoutForRebuild(this.OPIJPJPPMND());
			base.OnDisable();
		}

		// Token: 0x06009B27 RID: 39719 RVA: 0x00384BC5 File Offset: 0x00382DC5
		protected virtual void MOOGPHBCAHH()
		{
			this.CNIONDNLGMC();
		}

		// Token: 0x06009B28 RID: 39720 RVA: 0x00384B99 File Offset: 0x00382D99
		protected virtual void IFKNIHJCAFB()
		{
			base.OnEnable();
			this.HJJHIEDOCIL();
		}

		// Token: 0x06009B29 RID: 39721 RVA: 0x00384BA7 File Offset: 0x00382DA7
		protected virtual void IMGGCJICLHK()
		{
			this.FDHDGLFLNCC.Clear();
			LayoutRebuilder.MarkLayoutForRebuild(this.OPIJPJPPMND());
			base.OnDisable();
		}

		// Token: 0x06009B2A RID: 39722 RVA: 0x00384BD0 File Offset: 0x00382DD0
		private void MFFHOGKOHDF()
		{
			if (!this.IsActive())
			{
				return;
			}
			this.FDHDGLFLNCC.Clear();
			this.FDHDGLFLNCC.Add(this, this.AHOEPLPLPGP(), (DrivenTransformProperties)163);
			this.LMFHFLIKADD().anchorMin = Vector2.zero;
			this.OPIJPJPPMND().anchorMax = Vector2.one;
			this.AHOEPLPLPGP().anchoredPosition = Vector2.zero;
			this.FDHDGLFLNCC.Add(this, this.KPEGABCNLKE, DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.Rotation | DrivenTransformProperties.ScaleX);
			Vector2 a = this.PGCLOEOHGML() - this.GHEEJMNJKFO();
			if (this.JIOOKAEMDJD().x > 1143f)
			{
				a.x -= Mathf.Floor(a.x / this.JIOOKAEMDJD().x) * this.JIOOKAEMDJD().x;
			}
			else
			{
				a.x = 552f;
			}
			if (this.DCMFAJCLJMJ().y > 1435f)
			{
				a.y -= Mathf.Floor(a.y / this.JIOOKAEMDJD().y) * this.JIOOKAEMDJD().y;
			}
			else
			{
				a.y = 1305f;
			}
			this.ABHALONOCBL().sizeDelta = -a;
		}

		// Token: 0x06009B2B RID: 39723 RVA: 0x00384D3C File Offset: 0x00382F3C
		private void CNIONDNLGMC()
		{
			if (!this.IsActive())
			{
				return;
			}
			this.FDHDGLFLNCC.Clear();
			this.FDHDGLFLNCC.Add(this, this.KPEGABCNLKE, (DrivenTransformProperties)(-6));
			this.KPEGABCNLKE.anchorMin = Vector2.zero;
			this.LMFHFLIKADD().anchorMax = Vector2.one;
			this.KPEGABCNLKE.anchoredPosition = Vector2.zero;
			this.FDHDGLFLNCC.Add(this, this.ABHALONOCBL(), (DrivenTransformProperties)195);
			Vector2 a = this.JNMKHPGMDEN() - this.DAMBFIMCMPG();
			if (this.JIOOKAEMDJD().x > 1761f)
			{
				a.x -= Mathf.Floor(a.x / this.DCMFAJCLJMJ().x) * this.DCMFAJCLJMJ().x;
			}
			else
			{
				a.x = 1173f;
			}
			if (this.JIOOKAEMDJD().y > 1347f)
			{
				a.y -= Mathf.Floor(a.y / this.MJEKMHBNEMD().y) * this.DCMFAJCLJMJ().y;
			}
			else
			{
				a.y = 711f;
			}
			this.ABHALONOCBL().sizeDelta = -a;
		}

		// Token: 0x06009B2C RID: 39724 RVA: 0x00384EA8 File Offset: 0x003830A8
		private Vector2 MAGIOOOFMCJ()
		{
			RectTransform rectTransform = this.KPEGABCNLKE.parent as RectTransform;
			if (!rectTransform)
			{
				return Vector2.zero;
			}
			return rectTransform.rect.size;
		}

		// Token: 0x06009B2D RID: 39725 RVA: 0x00384EE5 File Offset: 0x003830E5
		public Vector2 GHEEJMNJKFO()
		{
			return this.m_Border;
		}

		// Token: 0x06009B2E RID: 39726 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void NEBFOPMHFLO()
		{
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06009B2F RID: 39727 RVA: 0x00384EED File Offset: 0x003830ED
		private RectTransform KPEGABCNLKE
		{
			get
			{
				if (this.GLLFFIOBKLD == null)
				{
					this.GLLFFIOBKLD = base.GetComponent<RectTransform>();
				}
				return this.GLLFFIOBKLD;
			}
		}

		// Token: 0x06009B30 RID: 39728 RVA: 0x00384BA7 File Offset: 0x00382DA7
		protected virtual void FDPOFMCFBMF()
		{
			this.FDHDGLFLNCC.Clear();
			LayoutRebuilder.MarkLayoutForRebuild(this.OPIJPJPPMND());
			base.OnDisable();
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06009B6E RID: 39790 RVA: 0x0038529A File Offset: 0x0038349A
		// (set) Token: 0x06009B31 RID: 39729 RVA: 0x00384F12 File Offset: 0x00383112
		public Vector2 TileSize
		{
			get
			{
				return this.m_TileSize;
			}
			set
			{
				if (IPLMBEKHDEP.SetStruct<Vector2>(ref this.m_TileSize, value))
				{
					this.KPHBJMDEOBF();
				}
			}
		}

		// Token: 0x06009B32 RID: 39730 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void JLBANNJIMIL()
		{
		}

		// Token: 0x06009B33 RID: 39731 RVA: 0x00384F2C File Offset: 0x0038312C
		private void KMBPEFPCIJC()
		{
			if (!this.IsActive())
			{
				return;
			}
			this.FDHDGLFLNCC.Clear();
			this.FDHDGLFLNCC.Add(this, this.KPEGABCNLKE, (DrivenTransformProperties)(-94));
			this.LMFHFLIKADD().anchorMin = Vector2.zero;
			this.KPEGABCNLKE.anchorMax = Vector2.one;
			this.OKPCEDKLDNG().anchoredPosition = Vector2.zero;
			this.FDHDGLFLNCC.Add(this, this.OKPCEDKLDNG(), ~(DrivenTransformProperties.ScaleY | DrivenTransformProperties.ScaleZ));
			Vector2 a = this.NKLIJIKBDML() - this.DAMBFIMCMPG();
			if (this.TileSize.x > 1713f)
			{
				a.x -= Mathf.Floor(a.x / this.MJEKMHBNEMD().x) * this.JIOOKAEMDJD().x;
			}
			else
			{
				a.x = 458f;
			}
			if (this.DCMFAJCLJMJ().y > 1855f)
			{
				a.y -= Mathf.Floor(a.y / this.TileSize.y) * this.DCMFAJCLJMJ().y;
			}
			else
			{
				a.y = 845f;
			}
			this.OPIJPJPPMND().sizeDelta = -a;
		}

		// Token: 0x06009B34 RID: 39732 RVA: 0x00384EED File Offset: 0x003830ED
		private RectTransform OPIJPJPPMND()
		{
			if (this.GLLFFIOBKLD == null)
			{
				this.GLLFFIOBKLD = base.GetComponent<RectTransform>();
			}
			return this.GLLFFIOBKLD;
		}

		// Token: 0x06009B35 RID: 39733 RVA: 0x00384EE5 File Offset: 0x003830E5
		public Vector2 DAMBFIMCMPG()
		{
			return this.m_Border;
		}

		// Token: 0x06009B36 RID: 39734 RVA: 0x00384EE5 File Offset: 0x003830E5
		public Vector2 NMJKLLJEHFJ()
		{
			return this.m_Border;
		}

		// Token: 0x06009B37 RID: 39735 RVA: 0x00385098 File Offset: 0x00383298
		private void GKNGIEHIABK()
		{
			if (!this.IsActive())
			{
				return;
			}
			this.FDHDGLFLNCC.Clear();
			this.FDHDGLFLNCC.Add(this, this.OPIJPJPPMND(), (DrivenTransformProperties)(-92));
			this.AHOEPLPLPGP().anchorMin = Vector2.zero;
			this.AHOEPLPLPGP().anchorMax = Vector2.one;
			this.ABHALONOCBL().anchoredPosition = Vector2.zero;
			this.FDHDGLFLNCC.Add(this, this.ABHALONOCBL(), (DrivenTransformProperties)77);
			Vector2 a = this.FIGDDFAMDJD() - this.NMJKLLJEHFJ();
			if (this.TileSize.x > 321f)
			{
				a.x -= Mathf.Floor(a.x / this.JIOOKAEMDJD().x) * this.DCMFAJCLJMJ().x;
			}
			else
			{
				a.x = 1607f;
			}
			if (this.DCMFAJCLJMJ().y > 1425f)
			{
				a.y -= Mathf.Floor(a.y / this.DCMFAJCLJMJ().y) * this.TileSize.y;
			}
			else
			{
				a.y = 1462f;
			}
			this.LMFHFLIKADD().sizeDelta = -a;
		}

		// Token: 0x06009B38 RID: 39736 RVA: 0x00385204 File Offset: 0x00383404
		private Vector2 NKLIJIKBDML()
		{
			RectTransform rectTransform = this.KPEGABCNLKE.parent as RectTransform;
			if (!rectTransform)
			{
				return Vector2.zero;
			}
			return rectTransform.rect.size;
		}

		// Token: 0x06009B39 RID: 39737 RVA: 0x00384EED File Offset: 0x003830ED
		private RectTransform LMFHFLIKADD()
		{
			if (this.GLLFFIOBKLD == null)
			{
				this.GLLFFIOBKLD = base.GetComponent<RectTransform>();
			}
			return this.GLLFFIOBKLD;
		}

		// Token: 0x06009B3A RID: 39738 RVA: 0x00385241 File Offset: 0x00383441
		protected virtual void LGELACBDPEH()
		{
			base.OnEnable();
			this.ECBMIOBOAJG();
		}

		// Token: 0x06009B3B RID: 39739 RVA: 0x0038524F File Offset: 0x0038344F
		public void ANENFKIHJKA(Vector2 DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<Vector2>(ref this.m_Border, DPNHODJHGJL))
			{
				this.KPHBJMDEOBF();
			}
		}

		// Token: 0x06009B3C RID: 39740 RVA: 0x00385268 File Offset: 0x00383468
		public void LPOCALAINBL(Vector2 DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<Vector2>(ref this.m_TileSize, DPNHODJHGJL))
			{
				this.JLBBFOENEBM();
			}
		}

		// Token: 0x06009B3D RID: 39741 RVA: 0x00385281 File Offset: 0x00383481
		public void MKAMNKNLMMF(Vector2 DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<Vector2>(ref this.m_Border, DPNHODJHGJL))
			{
				this.HEDGKNICLFD();
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06009B76 RID: 39798 RVA: 0x00384EE5 File Offset: 0x003830E5
		// (set) Token: 0x06009B3E RID: 39742 RVA: 0x0038524F File Offset: 0x0038344F
		public Vector2 Border
		{
			get
			{
				return this.m_Border;
			}
			set
			{
				if (IPLMBEKHDEP.SetStruct<Vector2>(ref this.m_Border, value))
				{
					this.KPHBJMDEOBF();
				}
			}
		}

		// Token: 0x06009B3F RID: 39743 RVA: 0x0038529A File Offset: 0x0038349A
		public Vector2 DCMFAJCLJMJ()
		{
			return this.m_TileSize;
		}

		// Token: 0x06009B40 RID: 39744 RVA: 0x003852A4 File Offset: 0x003834A4
		private Vector2 FIGDDFAMDJD()
		{
			RectTransform rectTransform = this.ABHALONOCBL().parent as RectTransform;
			if (!rectTransform)
			{
				return Vector2.zero;
			}
			return rectTransform.rect.size;
		}

		// Token: 0x06009B41 RID: 39745 RVA: 0x003852E1 File Offset: 0x003834E1
		public void HHMBPEHJPAG(Vector2 DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<Vector2>(ref this.m_TileSize, DPNHODJHGJL))
			{
				this.FBDNKGMPEKJ();
			}
		}

		// Token: 0x06009B42 RID: 39746 RVA: 0x003852FA File Offset: 0x003834FA
		protected override void OnDisable()
		{
			this.FDHDGLFLNCC.Clear();
			LayoutRebuilder.MarkLayoutForRebuild(this.KPEGABCNLKE);
			base.OnDisable();
		}

		// Token: 0x06009B43 RID: 39747 RVA: 0x00385318 File Offset: 0x00383518
		private void ACCCEKFHOBA()
		{
			if (!this.IsActive())
			{
				return;
			}
			this.FDHDGLFLNCC.Clear();
			this.FDHDGLFLNCC.Add(this, this.KPEGABCNLKE, ~(DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.ScaleY));
			this.OKPCEDKLDNG().anchorMin = Vector2.zero;
			this.KPEGABCNLKE.anchorMax = Vector2.one;
			this.AHOEPLPLPGP().anchoredPosition = Vector2.zero;
			this.FDHDGLFLNCC.Add(this, this.KPEGABCNLKE, (DrivenTransformProperties)(-162));
			Vector2 a = this.NKLIJIKBDML() - this.GHEEJMNJKFO();
			if (this.JIOOKAEMDJD().x > 683f)
			{
				a.x -= Mathf.Floor(a.x / this.JIOOKAEMDJD().x) * this.DCMFAJCLJMJ().x;
			}
			else
			{
				a.x = 999f;
			}
			if (this.DCMFAJCLJMJ().y > 1364f)
			{
				a.y -= Mathf.Floor(a.y / this.DCMFAJCLJMJ().y) * this.JIOOKAEMDJD().y;
			}
			else
			{
				a.y = 1478f;
			}
			this.LMFHFLIKADD().sizeDelta = -a;
		}

		// Token: 0x06009B44 RID: 39748 RVA: 0x00385482 File Offset: 0x00383682
		public void FAPICOEMHDB(Vector2 DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<Vector2>(ref this.m_Border, DPNHODJHGJL))
			{
				this.HJJHIEDOCIL();
			}
		}

		// Token: 0x06009B45 RID: 39749 RVA: 0x003852FA File Offset: 0x003834FA
		protected virtual void GPHPJIDGEPI()
		{
			this.FDHDGLFLNCC.Clear();
			LayoutRebuilder.MarkLayoutForRebuild(this.KPEGABCNLKE);
			base.OnDisable();
		}

		// Token: 0x06009B46 RID: 39750 RVA: 0x0038549B File Offset: 0x0038369B
		protected void HJJHIEDOCIL()
		{
			if (!this.IsActive())
			{
				return;
			}
			this.ACCCEKFHOBA();
		}

		// Token: 0x06009B47 RID: 39751 RVA: 0x003854AF File Offset: 0x003836AF
		protected virtual void BKJMCFADNGH()
		{
			base.OnEnable();
			this.FBDNKGMPEKJ();
		}

		// Token: 0x06009B48 RID: 39752 RVA: 0x003854C0 File Offset: 0x003836C0
		private void NNMBNKADHEK()
		{
			if (!this.IsActive())
			{
				return;
			}
			this.FDHDGLFLNCC.Clear();
			this.FDHDGLFLNCC.Add(this, this.AHOEPLPLPGP(), (DrivenTransformProperties)(-90));
			this.KPEGABCNLKE.anchorMin = Vector2.zero;
			this.OPIJPJPPMND().anchorMax = Vector2.one;
			this.AHOEPLPLPGP().anchoredPosition = Vector2.zero;
			this.FDHDGLFLNCC.Add(this, this.LMFHFLIKADD(), ~(DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.AnchoredPositionZ | DrivenTransformProperties.ScaleZ));
			Vector2 a = this.FIGDDFAMDJD() - this.GPOGLEJGJCE();
			if (this.TileSize.x > 295f)
			{
				a.x -= Mathf.Floor(a.x / this.JIOOKAEMDJD().x) * this.TileSize.x;
			}
			else
			{
				a.x = 1794f;
			}
			if (this.DCMFAJCLJMJ().y > 1624f)
			{
				a.y -= Mathf.Floor(a.y / this.TileSize.y) * this.TileSize.y;
			}
			else
			{
				a.y = 458f;
			}
			this.KPEGABCNLKE.sizeDelta = -a;
		}

		// Token: 0x06009B49 RID: 39753 RVA: 0x0038562A File Offset: 0x0038382A
		protected void FBDNKGMPEKJ()
		{
			if (!this.IsActive())
			{
				return;
			}
			this.MEIFPGHPBKF();
		}

		// Token: 0x06009B4A RID: 39754 RVA: 0x00384EED File Offset: 0x003830ED
		private RectTransform OKPCEDKLDNG()
		{
			if (this.GLLFFIOBKLD == null)
			{
				this.GLLFFIOBKLD = base.GetComponent<RectTransform>();
			}
			return this.GLLFFIOBKLD;
		}

		// Token: 0x06009B4B RID: 39755 RVA: 0x0038563E File Offset: 0x0038383E
		protected virtual void NLPIDMLBBGG()
		{
			this.APOINMJBHLJ();
		}

		// Token: 0x06009B4C RID: 39756 RVA: 0x00385648 File Offset: 0x00383848
		private void MEIFPGHPBKF()
		{
			if (!this.IsActive())
			{
				return;
			}
			this.FDHDGLFLNCC.Clear();
			this.FDHDGLFLNCC.Add(this, this.KPEGABCNLKE, (DrivenTransformProperties)1);
			this.AHOEPLPLPGP().anchorMin = Vector2.zero;
			this.KPEGABCNLKE.anchorMax = Vector2.one;
			this.KPEGABCNLKE.anchoredPosition = Vector2.zero;
			this.FDHDGLFLNCC.Add(this, this.KPEGABCNLKE, ~(DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.ScaleY | DrivenTransformProperties.ScaleZ));
			Vector2 a = this.PGCLOEOHGML() - this.DAMBFIMCMPG();
			if (this.DCMFAJCLJMJ().x > 1292f)
			{
				a.x -= Mathf.Floor(a.x / this.MJEKMHBNEMD().x) * this.MJEKMHBNEMD().x;
			}
			else
			{
				a.x = 1956f;
			}
			if (this.TileSize.y > 246f)
			{
				a.y -= Mathf.Floor(a.y / this.TileSize.y) * this.MJEKMHBNEMD().y;
			}
			else
			{
				a.y = 940f;
			}
			this.LMFHFLIKADD().sizeDelta = -a;
		}

		// Token: 0x06009B4D RID: 39757 RVA: 0x0038529A File Offset: 0x0038349A
		public Vector2 MJEKMHBNEMD()
		{
			return this.m_TileSize;
		}

		// Token: 0x06009B4E RID: 39758 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void CFHLMFELEGO()
		{
		}

		// Token: 0x06009B4F RID: 39759 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void SetLayoutVertical()
		{
		}

		// Token: 0x06009B50 RID: 39760 RVA: 0x003854AF File Offset: 0x003836AF
		protected virtual void JKMLIADBEOB()
		{
			base.OnEnable();
			this.FBDNKGMPEKJ();
		}

		// Token: 0x06009B51 RID: 39761 RVA: 0x00384EE5 File Offset: 0x003830E5
		public Vector2 GPOGLEJGJCE()
		{
			return this.m_Border;
		}

		// Token: 0x06009B52 RID: 39762 RVA: 0x003857B2 File Offset: 0x003839B2
		protected override void OnRectTransformDimensionsChange()
		{
			this.PLPCOJEPPPF();
		}

		// Token: 0x06009B53 RID: 39763 RVA: 0x00384F12 File Offset: 0x00383112
		public void KHNHLCEFBJB(Vector2 DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<Vector2>(ref this.m_TileSize, DPNHODJHGJL))
			{
				this.KPHBJMDEOBF();
			}
		}

		// Token: 0x06009B54 RID: 39764 RVA: 0x00384F12 File Offset: 0x00383112
		public void GDMOCOGINDA(Vector2 DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<Vector2>(ref this.m_TileSize, DPNHODJHGJL))
			{
				this.KPHBJMDEOBF();
			}
		}

		// Token: 0x06009B55 RID: 39765 RVA: 0x003854AF File Offset: 0x003836AF
		protected virtual void HJDPEBAPBPN()
		{
			base.OnEnable();
			this.FBDNKGMPEKJ();
		}

		// Token: 0x06009B56 RID: 39766 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void KMGGCLHEKGC()
		{
		}

		// Token: 0x06009B57 RID: 39767 RVA: 0x003857BA File Offset: 0x003839BA
		protected void KPHBJMDEOBF()
		{
			if (!this.IsActive())
			{
				return;
			}
			this.PLPCOJEPPPF();
		}

		// Token: 0x06009B58 RID: 39768 RVA: 0x003857CE File Offset: 0x003839CE
		protected override void OnEnable()
		{
			base.OnEnable();
			this.KPHBJMDEOBF();
		}

		// Token: 0x06009B59 RID: 39769 RVA: 0x003857DC File Offset: 0x003839DC
		private void EIIFLNOKMFD()
		{
			if (!this.IsActive())
			{
				return;
			}
			this.FDHDGLFLNCC.Clear();
			this.FDHDGLFLNCC.Add(this, this.OKPCEDKLDNG(), (DrivenTransformProperties)107);
			this.OPIJPJPPMND().anchorMin = Vector2.zero;
			this.OKPCEDKLDNG().anchorMax = Vector2.one;
			this.OKPCEDKLDNG().anchoredPosition = Vector2.zero;
			this.FDHDGLFLNCC.Add(this, this.AHOEPLPLPGP(), ~(DrivenTransformProperties.AnchoredPositionZ | DrivenTransformProperties.Rotation | DrivenTransformProperties.ScaleY));
			Vector2 a = this.NKLIJIKBDML() - this.GPOGLEJGJCE();
			if (this.JIOOKAEMDJD().x > 1812f)
			{
				a.x -= Mathf.Floor(a.x / this.TileSize.x) * this.DCMFAJCLJMJ().x;
			}
			else
			{
				a.x = 1737f;
			}
			if (this.JIOOKAEMDJD().y > 421f)
			{
				a.y -= Mathf.Floor(a.y / this.TileSize.y) * this.MJEKMHBNEMD().y;
			}
			else
			{
				a.y = 1823f;
			}
			this.ABHALONOCBL().sizeDelta = -a;
		}

		// Token: 0x06009B5A RID: 39770 RVA: 0x0038563E File Offset: 0x0038383E
		protected virtual void FKNDPCINHFB()
		{
			this.APOINMJBHLJ();
		}

		// Token: 0x06009B5B RID: 39771 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void PBFPJMHAHGK()
		{
		}

		// Token: 0x06009B5C RID: 39772 RVA: 0x0038529A File Offset: 0x0038349A
		public Vector2 JIOOKAEMDJD()
		{
			return this.m_TileSize;
		}

		// Token: 0x06009B5D RID: 39773 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void NPKONDMLOAH()
		{
		}

		// Token: 0x06009B5E RID: 39774 RVA: 0x00385948 File Offset: 0x00383B48
		private void MIFOMEEIPIM()
		{
			if (!this.IsActive())
			{
				return;
			}
			this.FDHDGLFLNCC.Clear();
			this.FDHDGLFLNCC.Add(this, this.OPIJPJPPMND(), (DrivenTransformProperties)145);
			this.KPEGABCNLKE.anchorMin = Vector2.zero;
			this.KPEGABCNLKE.anchorMax = Vector2.one;
			this.LMFHFLIKADD().anchoredPosition = Vector2.zero;
			this.FDHDGLFLNCC.Add(this, this.KPEGABCNLKE, (DrivenTransformProperties)169);
			Vector2 a = this.JNMKHPGMDEN() - this.GHEEJMNJKFO();
			if (this.JIOOKAEMDJD().x > 582f)
			{
				a.x -= Mathf.Floor(a.x / this.TileSize.x) * this.MJEKMHBNEMD().x;
			}
			else
			{
				a.x = 257f;
			}
			if (this.MJEKMHBNEMD().y > 1115f)
			{
				a.y -= Mathf.Floor(a.y / this.DCMFAJCLJMJ().y) * this.DCMFAJCLJMJ().y;
			}
			else
			{
				a.y = 1259f;
			}
			this.AHOEPLPLPGP().sizeDelta = -a;
		}

		// Token: 0x06009B5F RID: 39775 RVA: 0x00384B99 File Offset: 0x00382D99
		protected virtual void EAOKCECGKAK()
		{
			base.OnEnable();
			this.HJJHIEDOCIL();
		}

		// Token: 0x06009B60 RID: 39776 RVA: 0x00385AB2 File Offset: 0x00383CB2
		public void KGKJJEKMJJB(Vector2 DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<Vector2>(ref this.m_Border, DPNHODJHGJL))
			{
				this.ECBMIOBOAJG();
			}
		}

		// Token: 0x06009B62 RID: 39778 RVA: 0x00385AEC File Offset: 0x00383CEC
		private void DJCCLAGIAPC()
		{
			if (!this.IsActive())
			{
				return;
			}
			this.FDHDGLFLNCC.Clear();
			this.FDHDGLFLNCC.Add(this, this.AHOEPLPLPGP(), (DrivenTransformProperties)(-140));
			this.OPIJPJPPMND().anchorMin = Vector2.zero;
			this.OPIJPJPPMND().anchorMax = Vector2.one;
			this.OKPCEDKLDNG().anchoredPosition = Vector2.zero;
			this.FDHDGLFLNCC.Add(this, this.LMFHFLIKADD(), (DrivenTransformProperties)23);
			Vector2 a = this.FIGDDFAMDJD() - this.GHEEJMNJKFO();
			if (this.JIOOKAEMDJD().x > 1757f)
			{
				a.x -= Mathf.Floor(a.x / this.MJEKMHBNEMD().x) * this.TileSize.x;
			}
			else
			{
				a.x = 1522f;
			}
			if (this.TileSize.y > 1623f)
			{
				a.y -= Mathf.Floor(a.y / this.DCMFAJCLJMJ().y) * this.DCMFAJCLJMJ().y;
			}
			else
			{
				a.y = 891f;
			}
			this.OKPCEDKLDNG().sizeDelta = -a;
		}

		// Token: 0x06009B63 RID: 39779 RVA: 0x0038524F File Offset: 0x0038344F
		public void CDFJNCLOAMO(Vector2 DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<Vector2>(ref this.m_Border, DPNHODJHGJL))
			{
				this.KPHBJMDEOBF();
			}
		}

		// Token: 0x06009B64 RID: 39780 RVA: 0x0038524F File Offset: 0x0038344F
		public void HNMHNIPNAAH(Vector2 DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<Vector2>(ref this.m_Border, DPNHODJHGJL))
			{
				this.KPHBJMDEOBF();
			}
		}

		// Token: 0x06009B65 RID: 39781 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void EODLBDPOGIE()
		{
		}

		// Token: 0x06009B66 RID: 39782 RVA: 0x00385C56 File Offset: 0x00383E56
		protected virtual void KPJNOPGPEIA()
		{
			this.MIFOMEEIPIM();
		}

		// Token: 0x06009B67 RID: 39783 RVA: 0x00385C60 File Offset: 0x00383E60
		private void APOINMJBHLJ()
		{
			if (!this.IsActive())
			{
				return;
			}
			this.FDHDGLFLNCC.Clear();
			this.FDHDGLFLNCC.Add(this, this.ABHALONOCBL(), (DrivenTransformProperties)7);
			this.AHOEPLPLPGP().anchorMin = Vector2.zero;
			this.AHOEPLPLPGP().anchorMax = Vector2.one;
			this.OPIJPJPPMND().anchoredPosition = Vector2.zero;
			this.FDHDGLFLNCC.Add(this, this.LMFHFLIKADD(), ~(DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.Rotation | DrivenTransformProperties.ScaleX));
			Vector2 a = this.MAGIOOOFMCJ() - this.GPOGLEJGJCE();
			if (this.JIOOKAEMDJD().x > 1764f)
			{
				a.x -= Mathf.Floor(a.x / this.DCMFAJCLJMJ().x) * this.TileSize.x;
			}
			else
			{
				a.x = 1863f;
			}
			if (this.JIOOKAEMDJD().y > 974f)
			{
				a.y -= Mathf.Floor(a.y / this.TileSize.y) * this.TileSize.y;
			}
			else
			{
				a.y = 655f;
			}
			this.ABHALONOCBL().sizeDelta = -a;
		}

		// Token: 0x06009B68 RID: 39784 RVA: 0x00384EED File Offset: 0x003830ED
		private RectTransform ABHALONOCBL()
		{
			if (this.GLLFFIOBKLD == null)
			{
				this.GLLFFIOBKLD = base.GetComponent<RectTransform>();
			}
			return this.GLLFFIOBKLD;
		}

		// Token: 0x06009B69 RID: 39785 RVA: 0x00385DCA File Offset: 0x00383FCA
		protected virtual void HGIMCCHIPCP()
		{
			base.OnEnable();
			this.JLBBFOENEBM();
		}

		// Token: 0x06009B6A RID: 39786 RVA: 0x00385DD8 File Offset: 0x00383FD8
		private void PLPCOJEPPPF()
		{
			if (!this.IsActive())
			{
				return;
			}
			this.FDHDGLFLNCC.Clear();
			this.FDHDGLFLNCC.Add(this, this.KPEGABCNLKE, DrivenTransformProperties.AnchoredPositionX | DrivenTransformProperties.AnchoredPositionY | DrivenTransformProperties.AnchorMinX | DrivenTransformProperties.AnchorMinY | DrivenTransformProperties.AnchorMaxX | DrivenTransformProperties.AnchorMaxY);
			this.KPEGABCNLKE.anchorMin = Vector2.zero;
			this.KPEGABCNLKE.anchorMax = Vector2.one;
			this.KPEGABCNLKE.anchoredPosition = Vector2.zero;
			this.FDHDGLFLNCC.Add(this, this.KPEGABCNLKE, DrivenTransformProperties.SizeDelta);
			Vector2 a = this.NKLIJIKBDML() - this.Border;
			if (this.TileSize.x > 0.001f)
			{
				a.x -= Mathf.Floor(a.x / this.TileSize.x) * this.TileSize.x;
			}
			else
			{
				a.x = 0f;
			}
			if (this.TileSize.y > 0.001f)
			{
				a.y -= Mathf.Floor(a.y / this.TileSize.y) * this.TileSize.y;
			}
			else
			{
				a.y = 0f;
			}
			this.KPEGABCNLKE.sizeDelta = -a;
		}

		// Token: 0x06009B6B RID: 39787 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void JKBNDNFCFGD()
		{
		}

		// Token: 0x06009B6C RID: 39788 RVA: 0x00385F42 File Offset: 0x00384142
		protected virtual void HDIHJPFOCKI()
		{
			this.MFFHOGKOHDF();
		}

		// Token: 0x06009B6D RID: 39789 RVA: 0x00385DCA File Offset: 0x00383FCA
		protected virtual void HGJKBDGABKM()
		{
			base.OnEnable();
			this.JLBBFOENEBM();
		}

		// Token: 0x06009B6F RID: 39791 RVA: 0x003857BA File Offset: 0x003839BA
		protected void HEDGKNICLFD()
		{
			if (!this.IsActive())
			{
				return;
			}
			this.PLPCOJEPPPF();
		}

		// Token: 0x06009B70 RID: 39792 RVA: 0x00385F4A File Offset: 0x0038414A
		public void CDEMNBCJCCG(Vector2 DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<Vector2>(ref this.m_TileSize, DPNHODJHGJL))
			{
				this.ECBMIOBOAJG();
			}
		}

		// Token: 0x06009B71 RID: 39793 RVA: 0x00385F63 File Offset: 0x00384163
		protected void ECBMIOBOAJG()
		{
			if (!this.IsActive())
			{
				return;
			}
			this.CNIONDNLGMC();
		}

		// Token: 0x06009B72 RID: 39794 RVA: 0x00384EED File Offset: 0x003830ED
		private RectTransform AHOEPLPLPGP()
		{
			if (this.GLLFFIOBKLD == null)
			{
				this.GLLFFIOBKLD = base.GetComponent<RectTransform>();
			}
			return this.GLLFFIOBKLD;
		}

		// Token: 0x06009B73 RID: 39795 RVA: 0x00385F77 File Offset: 0x00384177
		public void GBADAFOBPLE(Vector2 DPNHODJHGJL)
		{
			if (IPLMBEKHDEP.SetStruct<Vector2>(ref this.m_Border, DPNHODJHGJL))
			{
				this.FBDNKGMPEKJ();
			}
		}

		// Token: 0x06009B74 RID: 39796 RVA: 0x00385F90 File Offset: 0x00384190
		protected virtual void OCCGJMPAJIK()
		{
			this.FDHDGLFLNCC.Clear();
			LayoutRebuilder.MarkLayoutForRebuild(this.ABHALONOCBL());
			base.OnDisable();
		}

		// Token: 0x06009B75 RID: 39797 RVA: 0x00385FAE File Offset: 0x003841AE
		protected void JLBBFOENEBM()
		{
			if (!this.IsActive())
			{
				return;
			}
			this.GKNGIEHIABK();
		}

		// Token: 0x06009B77 RID: 39799 RVA: 0x0002523B File Offset: 0x0002343B
		public virtual void CMICHABAMMH()
		{
		}

		// Token: 0x06009B78 RID: 39800 RVA: 0x00385FC4 File Offset: 0x003841C4
		private Vector2 PGCLOEOHGML()
		{
			RectTransform rectTransform = this.AHOEPLPLPGP().parent as RectTransform;
			if (!rectTransform)
			{
				return Vector2.zero;
			}
			return rectTransform.rect.size;
		}

		// Token: 0x06009B79 RID: 39801 RVA: 0x00384BC5 File Offset: 0x00382DC5
		protected virtual void PJCICPFCLPG()
		{
			this.CNIONDNLGMC();
		}

		// Token: 0x0400118B RID: 4491
		[SerializeField]
		private Vector2 m_Border = Vector2.zero;

		// Token: 0x0400118C RID: 4492
		[SerializeField]
		private Vector2 m_TileSize = Vector2.zero;

		// Token: 0x0400118D RID: 4493
		[NonSerialized]
		private RectTransform GLLFFIOBKLD;

		// Token: 0x0400118E RID: 4494
		private DrivenRectTransformTracker FDHDGLFLNCC;
	}
}
