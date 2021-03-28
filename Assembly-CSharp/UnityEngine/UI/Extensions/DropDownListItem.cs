using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000252 RID: 594
	[Serializable]
	public class DropDownListItem
	{
		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06008F89 RID: 36745 RVA: 0x00319F88 File Offset: 0x00318188
		// (set) Token: 0x06008F78 RID: 36728 RVA: 0x00319F58 File Offset: 0x00318158
		public string ID
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}

		// Token: 0x06008F79 RID: 36729 RVA: 0x00319F58 File Offset: 0x00318158
		public void OOKGKBOKKMJ(string DPNHODJHGJL)
		{
			this._id = DPNHODJHGJL;
		}

		// Token: 0x06008F7A RID: 36730 RVA: 0x00319F61 File Offset: 0x00318161
		public void FPNIMAFBMNB(string DPNHODJHGJL)
		{
			this._caption = DPNHODJHGJL;
			if (this.OnUpdate != null)
			{
				this.OnUpdate();
			}
		}

		// Token: 0x06008F7B RID: 36731 RVA: 0x00319F80 File Offset: 0x00318180
		public string NNMJCJBLDOG()
		{
			return this._caption;
		}

		// Token: 0x06008F7C RID: 36732 RVA: 0x00319F88 File Offset: 0x00318188
		public string DJCDFAEOGGJ()
		{
			return this._id;
		}

		// Token: 0x06008F7D RID: 36733 RVA: 0x00319F61 File Offset: 0x00318161
		public void FJPCDOCNGPO(string DPNHODJHGJL)
		{
			this._caption = DPNHODJHGJL;
			if (this.OnUpdate != null)
			{
				this.OnUpdate();
			}
		}

		// Token: 0x06008F7E RID: 36734 RVA: 0x00319F80 File Offset: 0x00318180
		public string GNNINBIBPHI()
		{
			return this._caption;
		}

		// Token: 0x06008F7F RID: 36735 RVA: 0x00319F90 File Offset: 0x00318190
		public Sprite GEMFDHOKMOG()
		{
			return this._image;
		}

		// Token: 0x06008F80 RID: 36736 RVA: 0x00319F98 File Offset: 0x00318198
		public void KANAKBEEBBP(bool DPNHODJHGJL)
		{
			this._isDisabled = DPNHODJHGJL;
			if (this.OnUpdate != null)
			{
				this.OnUpdate();
			}
		}

		// Token: 0x06008F81 RID: 36737 RVA: 0x00319F58 File Offset: 0x00318158
		public void PPDIBFHEHHF(string DPNHODJHGJL)
		{
			this._id = DPNHODJHGJL;
		}

		// Token: 0x06008F82 RID: 36738 RVA: 0x00319F80 File Offset: 0x00318180
		public string DGBOGEKKDFM()
		{
			return this._caption;
		}

		// Token: 0x06008F83 RID: 36739 RVA: 0x00319FB7 File Offset: 0x003181B7
		public bool JDHICGCBFBF()
		{
			return this._isDisabled;
		}

		// Token: 0x06008F84 RID: 36740 RVA: 0x00319FB7 File Offset: 0x003181B7
		public bool DFDGJMLCIKA()
		{
			return this._isDisabled;
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06008F93 RID: 36755 RVA: 0x00319FB7 File Offset: 0x003181B7
		// (set) Token: 0x06008F85 RID: 36741 RVA: 0x00319F98 File Offset: 0x00318198
		public bool IsDisabled
		{
			get
			{
				return this._isDisabled;
			}
			set
			{
				this._isDisabled = value;
				if (this.OnUpdate != null)
				{
					this.OnUpdate();
				}
			}
		}

		// Token: 0x06008F86 RID: 36742 RVA: 0x00319F58 File Offset: 0x00318158
		public void HPNEDEBIEPN(string DPNHODJHGJL)
		{
			this._id = DPNHODJHGJL;
		}

		// Token: 0x06008F87 RID: 36743 RVA: 0x00319F88 File Offset: 0x00318188
		public string LHBHELFAOGF()
		{
			return this._id;
		}

		// Token: 0x06008F88 RID: 36744 RVA: 0x00319FB7 File Offset: 0x003181B7
		public bool AAEPJCHHDNP()
		{
			return this._isDisabled;
		}

		// Token: 0x06008F8A RID: 36746 RVA: 0x00319F90 File Offset: 0x00318190
		public Sprite NDIHLFODKKE()
		{
			return this._image;
		}

		// Token: 0x06008F8B RID: 36747 RVA: 0x00319F58 File Offset: 0x00318158
		public void FEOAKFHKCNA(string DPNHODJHGJL)
		{
			this._id = DPNHODJHGJL;
		}

		// Token: 0x06008F8C RID: 36748 RVA: 0x00319F58 File Offset: 0x00318158
		public void GMABIGOBFDE(string DPNHODJHGJL)
		{
			this._id = DPNHODJHGJL;
		}

		// Token: 0x06008F8D RID: 36749 RVA: 0x00319F98 File Offset: 0x00318198
		public void LPKNAIJDBLG(bool DPNHODJHGJL)
		{
			this._isDisabled = DPNHODJHGJL;
			if (this.OnUpdate != null)
			{
				this.OnUpdate();
			}
		}

		// Token: 0x06008F8E RID: 36750 RVA: 0x00319F58 File Offset: 0x00318158
		public void FBJCDOFJHKF(string DPNHODJHGJL)
		{
			this._id = DPNHODJHGJL;
		}

		// Token: 0x06008F8F RID: 36751 RVA: 0x00319F80 File Offset: 0x00318180
		public string IAMDNDHGFNP()
		{
			return this._caption;
		}

		// Token: 0x06008F90 RID: 36752 RVA: 0x00319F90 File Offset: 0x00318190
		public Sprite LHIKDFGOHMH()
		{
			return this._image;
		}

		// Token: 0x06008F91 RID: 36753 RVA: 0x00319F58 File Offset: 0x00318158
		public void AJPBKHLNJOA(string DPNHODJHGJL)
		{
			this._id = DPNHODJHGJL;
		}

		// Token: 0x06008F92 RID: 36754 RVA: 0x00319F80 File Offset: 0x00318180
		public string OLILGJPEOIE()
		{
			return this._caption;
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06008FA8 RID: 36776 RVA: 0x00319F80 File Offset: 0x00318180
		// (set) Token: 0x06008F94 RID: 36756 RVA: 0x00319F61 File Offset: 0x00318161
		public string Caption
		{
			get
			{
				return this._caption;
			}
			set
			{
				this._caption = value;
				if (this.OnUpdate != null)
				{
					this.OnUpdate();
				}
			}
		}

		// Token: 0x06008F95 RID: 36757 RVA: 0x00319FBF File Offset: 0x003181BF
		public void GBDMINMPLMJ(Sprite DPNHODJHGJL)
		{
			this._image = DPNHODJHGJL;
			if (this.OnUpdate != null)
			{
				this.OnUpdate();
			}
		}

		// Token: 0x06008F96 RID: 36758 RVA: 0x00319F58 File Offset: 0x00318158
		public void IGNKDCLLGLO(string DPNHODJHGJL)
		{
			this._id = DPNHODJHGJL;
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06008F97 RID: 36759 RVA: 0x00319F90 File Offset: 0x00318190
		// (set) Token: 0x06008F98 RID: 36760 RVA: 0x00319FBF File Offset: 0x003181BF
		public Sprite Image
		{
			get
			{
				return this._image;
			}
			set
			{
				this._image = value;
				if (this.OnUpdate != null)
				{
					this.OnUpdate();
				}
			}
		}

		// Token: 0x06008F99 RID: 36761 RVA: 0x00319F88 File Offset: 0x00318188
		public string OJIDDODDDAD()
		{
			return this._id;
		}

		// Token: 0x06008F9A RID: 36762 RVA: 0x00319FB7 File Offset: 0x003181B7
		public bool KEEMCPBDFIB()
		{
			return this._isDisabled;
		}

		// Token: 0x06008F9B RID: 36763 RVA: 0x00319FB7 File Offset: 0x003181B7
		public bool IFINMJJPCHK()
		{
			return this._isDisabled;
		}

		// Token: 0x06008F9C RID: 36764 RVA: 0x00319FB7 File Offset: 0x003181B7
		public bool MKLIJHANLFE()
		{
			return this._isDisabled;
		}

		// Token: 0x06008F9D RID: 36765 RVA: 0x00319F61 File Offset: 0x00318161
		public void JABHGBHOEBN(string DPNHODJHGJL)
		{
			this._caption = DPNHODJHGJL;
			if (this.OnUpdate != null)
			{
				this.OnUpdate();
			}
		}

		// Token: 0x06008F9E RID: 36766 RVA: 0x00319F80 File Offset: 0x00318180
		public string AOGMILOAJMK()
		{
			return this._caption;
		}

		// Token: 0x06008F9F RID: 36767 RVA: 0x00319F61 File Offset: 0x00318161
		public void LOEOAJBDIAA(string DPNHODJHGJL)
		{
			this._caption = DPNHODJHGJL;
			if (this.OnUpdate != null)
			{
				this.OnUpdate();
			}
		}

		// Token: 0x06008FA0 RID: 36768 RVA: 0x00319FB7 File Offset: 0x003181B7
		public bool CGCLOKFGLDL()
		{
			return this._isDisabled;
		}

		// Token: 0x06008FA1 RID: 36769 RVA: 0x00319FB7 File Offset: 0x003181B7
		public bool JBIINMLPBKJ()
		{
			return this._isDisabled;
		}

		// Token: 0x06008FA2 RID: 36770 RVA: 0x00319FDE File Offset: 0x003181DE
		public DropDownListItem(string LJFGKGINJGO = "", string CKMAIFACDFI = "", Sprite IFGKDBEFCCA = null, bool JNNEFDJMHJN = false, Action GIPLENCDLFO = null)
		{
			this._caption = LJFGKGINJGO;
			this._image = IFGKDBEFCCA;
			this._id = CKMAIFACDFI;
			this._isDisabled = JNNEFDJMHJN;
			this.OnSelect = GIPLENCDLFO;
		}

		// Token: 0x06008FA3 RID: 36771 RVA: 0x00319F61 File Offset: 0x00318161
		public void MJDCCLNNIEB(string DPNHODJHGJL)
		{
			this._caption = DPNHODJHGJL;
			if (this.OnUpdate != null)
			{
				this.OnUpdate();
			}
		}

		// Token: 0x06008FA4 RID: 36772 RVA: 0x00319F80 File Offset: 0x00318180
		public string BBLPFDKLPAJ()
		{
			return this._caption;
		}

		// Token: 0x06008FA5 RID: 36773 RVA: 0x00319FB7 File Offset: 0x003181B7
		public bool PODCIEJCLOO()
		{
			return this._isDisabled;
		}

		// Token: 0x06008FA6 RID: 36774 RVA: 0x00319F61 File Offset: 0x00318161
		public void OPLKDJKKFGJ(string DPNHODJHGJL)
		{
			this._caption = DPNHODJHGJL;
			if (this.OnUpdate != null)
			{
				this.OnUpdate();
			}
		}

		// Token: 0x06008FA7 RID: 36775 RVA: 0x00319F88 File Offset: 0x00318188
		public string KBFCLFHCEDA()
		{
			return this._id;
		}

		// Token: 0x06008FA9 RID: 36777 RVA: 0x00319FB7 File Offset: 0x003181B7
		public bool CGDJABKKFGE()
		{
			return this._isDisabled;
		}

		// Token: 0x06008FAA RID: 36778 RVA: 0x00319FB7 File Offset: 0x003181B7
		public bool ANKNHALAGMP()
		{
			return this._isDisabled;
		}

		// Token: 0x0400108D RID: 4237
		[SerializeField]
		private string _caption;

		// Token: 0x0400108E RID: 4238
		[SerializeField]
		private Sprite _image;

		// Token: 0x0400108F RID: 4239
		[SerializeField]
		private bool _isDisabled;

		// Token: 0x04001090 RID: 4240
		[SerializeField]
		private string _id;

		// Token: 0x04001091 RID: 4241
		public Action OnSelect;

		// Token: 0x04001092 RID: 4242
		internal Action OnUpdate;
	}
}
