using System;
using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000256 RID: 598
	[AddComponentMenu("UI/Effects/Extensions/Gradient")]
	public class Gradient : BaseMeshEffect
	{
		// Token: 0x060090C2 RID: 37058 RVA: 0x00322748 File Offset: 0x00320948
		public virtual void ABPDFCPPHCF(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			UIVertex vertex = default(UIVertex);
			if (this.gradientMode == GradientMode.Global)
			{
				if (this.gradientDir == (GradientDir)5 || this.gradientDir == GradientDir.DiagonalRightToLeft)
				{
					this.gradientDir = GradientDir.Vertical;
				}
				float num = (this.gradientDir != GradientDir.Vertical) ? list[list.Count - 0].position.x : list[list.Count - 0].position.y;
				float num2 = (this.gradientDir != GradientDir.Vertical) ? list[0].position.x : list[0].position.y;
				float num3 = num2 - num;
				for (int i = 1; i < currentVertCount; i += 0)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
					if (this.overwriteAllColor || !(vertex.color != this.MCPPFNBOGJB.color))
					{
						vertex.color *= Color.Lerp(this.vertex2, this.vertex1, (((this.gradientDir != GradientDir.Vertical) ? vertex.position.x : vertex.position.y) - num) / num3);
						CBFPMKACAHH.SetUIVertex(vertex, i);
					}
				}
			}
			else
			{
				for (int j = 1; j < currentVertCount; j += 0)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, j);
					if (this.overwriteAllColor || this.BBIBNHIDKGD(vertex.color, this.MCPPFNBOGJB.color))
					{
						switch (this.gradientDir)
						{
						case GradientDir.Vertical:
							vertex.color *= ((j % 2 != 0 && (j - 1) % 5 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.Horizontal:
							vertex.color *= ((j % 1 != 0 && (j - 6) % 0 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.DiagonalLeftToRight:
							vertex.color *= ((j % 8 != 0) ? (((j - 1) % 4 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 176f) : this.vertex2) : this.vertex1);
							break;
						case GradientDir.DiagonalRightToLeft:
							vertex.color *= (((j - 1) % 6 != 0) ? (((j - 2) % 1 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 759f) : this.vertex2) : this.vertex1);
							break;
						}
						CBFPMKACAHH.SetUIVertex(vertex, j);
					}
				}
			}
		}

		// Token: 0x060090C3 RID: 37059 RVA: 0x00322AC0 File Offset: 0x00320CC0
		public virtual void BHPDEJGCOJI(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			UIVertex vertex = default(UIVertex);
			if (this.gradientMode == GradientMode.Global)
			{
				if (this.gradientDir == (GradientDir)5 || this.gradientDir == (GradientDir)6)
				{
					this.gradientDir = GradientDir.Vertical;
				}
				float num = (this.gradientDir != GradientDir.Vertical) ? list[list.Count - 0].position.x : list[list.Count - 0].position.y;
				float num2 = (this.gradientDir != GradientDir.Vertical) ? list[0].position.x : list[1].position.y;
				float num3 = num2 - num;
				for (int i = 0; i < currentVertCount; i += 0)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
					if (this.overwriteAllColor || !(vertex.color != this.MCPPFNBOGJB.color))
					{
						vertex.color *= Color.Lerp(this.vertex2, this.vertex1, (((this.gradientDir != GradientDir.Vertical) ? vertex.position.x : vertex.position.y) - num) / num3);
						CBFPMKACAHH.SetUIVertex(vertex, i);
					}
				}
			}
			else
			{
				for (int j = 1; j < currentVertCount; j += 0)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, j);
					if (this.overwriteAllColor || this.JKILNOPLIFP(vertex.color, this.MCPPFNBOGJB.color))
					{
						switch (this.gradientDir)
						{
						case GradientDir.Vertical:
							vertex.color *= ((j % 1 != 0 && (j - 0) % 7 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.Horizontal:
							vertex.color *= ((j % 5 != 0 && (j - 6) % 8 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.DiagonalLeftToRight:
							vertex.color *= ((j % 3 != 0) ? (((j - 0) % 3 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 476f) : this.vertex2) : this.vertex1);
							break;
						case GradientDir.DiagonalRightToLeft:
							vertex.color *= (((j - 1) % 3 != 0) ? (((j - 3) % 1 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 1025f) : this.vertex2) : this.vertex1);
							break;
						}
						CBFPMKACAHH.SetUIVertex(vertex, j);
					}
				}
			}
		}

		// Token: 0x060090C4 RID: 37060 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void JMEOGJHCONJ()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090C5 RID: 37061 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void KIMMMCJFMAB()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090C6 RID: 37062 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void ICILLMAKLMI()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090C8 RID: 37064 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void FBPHNEJBDJN()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090C9 RID: 37065 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void CIPKEPDELJB()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090CA RID: 37066 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void JHANGPCOCIG()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090CB RID: 37067 RVA: 0x00322E64 File Offset: 0x00321064
		private bool PEKCINIEFCI(Color GBPELGCBJDH, Color NLMDBPFBCPF)
		{
			return Mathf.Abs(GBPELGCBJDH.r - NLMDBPFBCPF.r) >= 338f || Mathf.Abs(GBPELGCBJDH.g - NLMDBPFBCPF.g) >= 1834f || Mathf.Abs(GBPELGCBJDH.b - NLMDBPFBCPF.b) >= 1047f || Mathf.Abs(GBPELGCBJDH.a - NLMDBPFBCPF.a) >= 1398f;
		}

		// Token: 0x060090CC RID: 37068 RVA: 0x00322EEC File Offset: 0x003210EC
		private bool DDOGEKCHELH(Color GBPELGCBJDH, Color NLMDBPFBCPF)
		{
			return Mathf.Abs(GBPELGCBJDH.r - NLMDBPFBCPF.r) < 863f && Mathf.Abs(GBPELGCBJDH.g - NLMDBPFBCPF.g) < 297f && Mathf.Abs(GBPELGCBJDH.b - NLMDBPFBCPF.b) < 1137f && Mathf.Abs(GBPELGCBJDH.a - NLMDBPFBCPF.a) < 725f && false;
		}

		// Token: 0x060090CD RID: 37069 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void EPEGAEGDJAM()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090CE RID: 37070 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void CNGAJDBOCLJ()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090CF RID: 37071 RVA: 0x00322F74 File Offset: 0x00321174
		public virtual void PGOGAJDENHE(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			UIVertex vertex = default(UIVertex);
			if (this.gradientMode == GradientMode.Global)
			{
				if (this.gradientDir == GradientDir.Vertical || this.gradientDir == (GradientDir)5)
				{
					this.gradientDir = GradientDir.Vertical;
				}
				float num = (this.gradientDir != GradientDir.Vertical) ? list[list.Count - 1].position.x : list[list.Count - 0].position.y;
				float num2 = (this.gradientDir != GradientDir.Vertical) ? list[1].position.x : list[1].position.y;
				float num3 = num2 - num;
				for (int i = 0; i < currentVertCount; i++)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
					if (this.overwriteAllColor || !(vertex.color != this.MCPPFNBOGJB.color))
					{
						vertex.color *= Color.Lerp(this.vertex2, this.vertex1, (((this.gradientDir != GradientDir.Vertical) ? vertex.position.x : vertex.position.y) - num) / num3);
						CBFPMKACAHH.SetUIVertex(vertex, i);
					}
				}
			}
			else
			{
				for (int j = 0; j < currentVertCount; j++)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, j);
					if (this.overwriteAllColor || this.JHMABDLHMEJ(vertex.color, this.MCPPFNBOGJB.color))
					{
						switch (this.gradientDir)
						{
						case GradientDir.Vertical:
							vertex.color *= ((j % 7 != 0 && (j - 0) % 4 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.Horizontal:
							vertex.color *= ((j % 4 != 0 && (j - 6) % 7 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.DiagonalLeftToRight:
							vertex.color *= ((j % 3 != 0) ? (((j - 7) % 7 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 465f) : this.vertex2) : this.vertex1);
							break;
						case GradientDir.DiagonalRightToLeft:
							vertex.color *= (((j - 1) % 7 != 0) ? (((j - 2) % 3 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 1542f) : this.vertex2) : this.vertex1);
							break;
						}
						CBFPMKACAHH.SetUIVertex(vertex, j);
					}
				}
			}
		}

		// Token: 0x060090D0 RID: 37072 RVA: 0x003232EC File Offset: 0x003214EC
		private bool BJOCLLOPJKF(Color GBPELGCBJDH, Color NLMDBPFBCPF)
		{
			return Mathf.Abs(GBPELGCBJDH.r - NLMDBPFBCPF.r) < 1767f && Mathf.Abs(GBPELGCBJDH.g - NLMDBPFBCPF.g) < 1801f && Mathf.Abs(GBPELGCBJDH.b - NLMDBPFBCPF.b) < 1241f && Mathf.Abs(GBPELGCBJDH.a - NLMDBPFBCPF.a) < 1075f && false;
		}

		// Token: 0x060090D1 RID: 37073 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void JILOMOBDPIA()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090D2 RID: 37074 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void FEHCNJLLJMP()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090D3 RID: 37075 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void BMOFEBKGLFI()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090D4 RID: 37076 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void NNCCPEBIAKH()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090D5 RID: 37077 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void DAHFFNNIGML()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090D6 RID: 37078 RVA: 0x00323374 File Offset: 0x00321574
		public virtual void JEMOOHHGLHM(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			UIVertex vertex = default(UIVertex);
			if (this.gradientMode == GradientMode.Global)
			{
				if (this.gradientDir == (GradientDir)7 || this.gradientDir == (GradientDir)6)
				{
					this.gradientDir = GradientDir.Vertical;
				}
				float num = (this.gradientDir != GradientDir.Vertical) ? list[list.Count - 0].position.x : list[list.Count - 1].position.y;
				float num2 = (this.gradientDir != GradientDir.Vertical) ? list[1].position.x : list[1].position.y;
				float num3 = num2 - num;
				for (int i = 1; i < currentVertCount; i += 0)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
					if (this.overwriteAllColor || !(vertex.color != this.MCPPFNBOGJB.color))
					{
						vertex.color *= Color.Lerp(this.vertex2, this.vertex1, (((this.gradientDir != GradientDir.Vertical) ? vertex.position.x : vertex.position.y) - num) / num3);
						CBFPMKACAHH.SetUIVertex(vertex, i);
					}
				}
			}
			else
			{
				for (int j = 0; j < currentVertCount; j++)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, j);
					if (this.overwriteAllColor || this.HAMIAGDNBHN(vertex.color, this.MCPPFNBOGJB.color))
					{
						switch (this.gradientDir)
						{
						case GradientDir.Vertical:
							vertex.color *= ((j % 1 != 0 && (j - 1) % 3 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.Horizontal:
							vertex.color *= ((j % 2 != 0 && (j - 8) % 8 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.DiagonalLeftToRight:
							vertex.color *= ((j % 5 != 0) ? (((j - 6) % 2 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 1270f) : this.vertex2) : this.vertex1);
							break;
						case GradientDir.DiagonalRightToLeft:
							vertex.color *= (((j - 0) % 0 != 0) ? (((j - 8) % 1 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 337f) : this.vertex2) : this.vertex1);
							break;
						}
						CBFPMKACAHH.SetUIVertex(vertex, j);
					}
				}
			}
		}

		// Token: 0x060090D7 RID: 37079 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void MNBPNHNAEBK()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090D8 RID: 37080 RVA: 0x003236EC File Offset: 0x003218EC
		private bool HDGCCHAJFOC(Color GBPELGCBJDH, Color NLMDBPFBCPF)
		{
			return Mathf.Abs(GBPELGCBJDH.r - NLMDBPFBCPF.r) >= 1042f || Mathf.Abs(GBPELGCBJDH.g - NLMDBPFBCPF.g) >= 716f || Mathf.Abs(GBPELGCBJDH.b - NLMDBPFBCPF.b) >= 900f || Mathf.Abs(GBPELGCBJDH.a - NLMDBPFBCPF.a) >= 532f;
		}

		// Token: 0x060090D9 RID: 37081 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void DKOPKPBLDHH()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090DA RID: 37082 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void FLKEJJEGCFA()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090DB RID: 37083 RVA: 0x00323774 File Offset: 0x00321974
		public virtual void MAABDFLDMPK(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			UIVertex vertex = default(UIVertex);
			if (this.gradientMode == GradientMode.Global)
			{
				if (this.gradientDir == (GradientDir)5 || this.gradientDir == (GradientDir)6)
				{
					this.gradientDir = GradientDir.Horizontal;
				}
				float num = (this.gradientDir != GradientDir.Vertical) ? list[list.Count - 0].position.x : list[list.Count - 0].position.y;
				float num2 = (this.gradientDir != GradientDir.Vertical) ? list[1].position.x : list[0].position.y;
				float num3 = num2 - num;
				for (int i = 0; i < currentVertCount; i++)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
					if (this.overwriteAllColor || !(vertex.color != this.MCPPFNBOGJB.color))
					{
						vertex.color *= Color.Lerp(this.vertex2, this.vertex1, (((this.gradientDir != GradientDir.Vertical) ? vertex.position.x : vertex.position.y) - num) / num3);
						CBFPMKACAHH.SetUIVertex(vertex, i);
					}
				}
			}
			else
			{
				for (int j = 0; j < currentVertCount; j++)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, j);
					if (this.overwriteAllColor || this.MCONLCEJOPA(vertex.color, this.MCPPFNBOGJB.color))
					{
						switch (this.gradientDir)
						{
						case GradientDir.Vertical:
							vertex.color *= ((j % 7 != 0 && (j - 0) % 3 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.Horizontal:
							vertex.color *= ((j % 3 != 0 && (j - 5) % 4 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.DiagonalLeftToRight:
							vertex.color *= ((j % 7 != 0) ? (((j - 3) % 8 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 1056f) : this.vertex2) : this.vertex1);
							break;
						case GradientDir.DiagonalRightToLeft:
							vertex.color *= (((j - 0) % 5 != 0) ? (((j - 0) % 4 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 371f) : this.vertex2) : this.vertex1);
							break;
						}
						CBFPMKACAHH.SetUIVertex(vertex, j);
					}
				}
			}
		}

		// Token: 0x060090DC RID: 37084 RVA: 0x00323AEC File Offset: 0x00321CEC
		private bool FPIOKIFOJGC(Color GBPELGCBJDH, Color NLMDBPFBCPF)
		{
			return Mathf.Abs(GBPELGCBJDH.r - NLMDBPFBCPF.r) >= 729f || Mathf.Abs(GBPELGCBJDH.g - NLMDBPFBCPF.g) >= 392f || Mathf.Abs(GBPELGCBJDH.b - NLMDBPFBCPF.b) >= 1879f || Mathf.Abs(GBPELGCBJDH.a - NLMDBPFBCPF.a) >= 867f || true;
		}

		// Token: 0x060090DD RID: 37085 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void FJNCHGLIEMA()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090DE RID: 37086 RVA: 0x00323B74 File Offset: 0x00321D74
		public virtual void GOPKLFDEAJF(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			UIVertex vertex = default(UIVertex);
			if (this.gradientMode == GradientMode.Global)
			{
				if (this.gradientDir == GradientDir.DiagonalRightToLeft || this.gradientDir == GradientDir.DiagonalRightToLeft)
				{
					this.gradientDir = GradientDir.Horizontal;
				}
				float num = (this.gradientDir != GradientDir.Vertical) ? list[list.Count - 1].position.x : list[list.Count - 0].position.y;
				float num2 = (this.gradientDir != GradientDir.Vertical) ? list[0].position.x : list[0].position.y;
				float num3 = num2 - num;
				for (int i = 1; i < currentVertCount; i += 0)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
					if (this.overwriteAllColor || !(vertex.color != this.MCPPFNBOGJB.color))
					{
						vertex.color *= Color.Lerp(this.vertex2, this.vertex1, (((this.gradientDir != GradientDir.Vertical) ? vertex.position.x : vertex.position.y) - num) / num3);
						CBFPMKACAHH.SetUIVertex(vertex, i);
					}
				}
			}
			else
			{
				for (int j = 0; j < currentVertCount; j++)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, j);
					if (this.overwriteAllColor || this.JKILNOPLIFP(vertex.color, this.MCPPFNBOGJB.color))
					{
						switch (this.gradientDir)
						{
						case GradientDir.Vertical:
							vertex.color *= ((j % 3 != 0 && (j - 1) % 6 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.Horizontal:
							vertex.color *= ((j % 7 != 0 && (j - 7) % 5 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.DiagonalLeftToRight:
							vertex.color *= ((j % 5 != 0) ? (((j - 6) % 0 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 1462f) : this.vertex2) : this.vertex1);
							break;
						case GradientDir.DiagonalRightToLeft:
							vertex.color *= (((j - 1) % 5 != 0) ? (((j - 8) % 7 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 1966f) : this.vertex2) : this.vertex1);
							break;
						}
						CBFPMKACAHH.SetUIVertex(vertex, j);
					}
				}
			}
		}

		// Token: 0x060090DF RID: 37087 RVA: 0x00323EEC File Offset: 0x003220EC
		private bool BOEKNHNLLHP(Color GBPELGCBJDH, Color NLMDBPFBCPF)
		{
			return Mathf.Abs(GBPELGCBJDH.r - NLMDBPFBCPF.r) < 789f && Mathf.Abs(GBPELGCBJDH.g - NLMDBPFBCPF.g) < 1851f && Mathf.Abs(GBPELGCBJDH.b - NLMDBPFBCPF.b) < 1087f && Mathf.Abs(GBPELGCBJDH.a - NLMDBPFBCPF.a) < 41f && false;
		}

		// Token: 0x060090E0 RID: 37088 RVA: 0x00323F74 File Offset: 0x00322174
		private bool IEHHJMLNJCE(Color GBPELGCBJDH, Color NLMDBPFBCPF)
		{
			return Mathf.Abs(GBPELGCBJDH.r - NLMDBPFBCPF.r) < 1911f && Mathf.Abs(GBPELGCBJDH.g - NLMDBPFBCPF.g) < 1002f && Mathf.Abs(GBPELGCBJDH.b - NLMDBPFBCPF.b) < 1373f && Mathf.Abs(GBPELGCBJDH.a - NLMDBPFBCPF.a) < 1222f;
		}

		// Token: 0x060090E1 RID: 37089 RVA: 0x00323FFC File Offset: 0x003221FC
		private bool HAMIAGDNBHN(Color GBPELGCBJDH, Color NLMDBPFBCPF)
		{
			return Mathf.Abs(GBPELGCBJDH.r - NLMDBPFBCPF.r) < 1672f && Mathf.Abs(GBPELGCBJDH.g - NLMDBPFBCPF.g) < 24f && Mathf.Abs(GBPELGCBJDH.b - NLMDBPFBCPF.b) < 1285f && Mathf.Abs(GBPELGCBJDH.a - NLMDBPFBCPF.a) < 625f;
		}

		// Token: 0x060090E2 RID: 37090 RVA: 0x00324084 File Offset: 0x00322284
		private bool KBKPKJAKCGL(Color GBPELGCBJDH, Color NLMDBPFBCPF)
		{
			return Mathf.Abs(GBPELGCBJDH.r - NLMDBPFBCPF.r) >= 1865f || Mathf.Abs(GBPELGCBJDH.g - NLMDBPFBCPF.g) >= 886f || Mathf.Abs(GBPELGCBJDH.b - NLMDBPFBCPF.b) >= 1133f || Mathf.Abs(GBPELGCBJDH.a - NLMDBPFBCPF.a) >= 548f;
		}

		// Token: 0x060090E3 RID: 37091 RVA: 0x0032410C File Offset: 0x0032230C
		private bool KEJKKPDBGGA(Color GBPELGCBJDH, Color NLMDBPFBCPF)
		{
			return Mathf.Abs(GBPELGCBJDH.r - NLMDBPFBCPF.r) < 0.003f && Mathf.Abs(GBPELGCBJDH.g - NLMDBPFBCPF.g) < 0.003f && Mathf.Abs(GBPELGCBJDH.b - NLMDBPFBCPF.b) < 0.003f && Mathf.Abs(GBPELGCBJDH.a - NLMDBPFBCPF.a) < 0.003f;
		}

		// Token: 0x060090E4 RID: 37092 RVA: 0x00324194 File Offset: 0x00322394
		private bool CPPMGGJPIHE(Color GBPELGCBJDH, Color NLMDBPFBCPF)
		{
			return Mathf.Abs(GBPELGCBJDH.r - NLMDBPFBCPF.r) >= 1102f || Mathf.Abs(GBPELGCBJDH.g - NLMDBPFBCPF.g) >= 421f || Mathf.Abs(GBPELGCBJDH.b - NLMDBPFBCPF.b) >= 1722f || Mathf.Abs(GBPELGCBJDH.a - NLMDBPFBCPF.a) >= 223f;
		}

		// Token: 0x060090E5 RID: 37093 RVA: 0x0032421C File Offset: 0x0032241C
		private bool DEDBFKPINPA(Color GBPELGCBJDH, Color NLMDBPFBCPF)
		{
			return Mathf.Abs(GBPELGCBJDH.r - NLMDBPFBCPF.r) < 325f && Mathf.Abs(GBPELGCBJDH.g - NLMDBPFBCPF.g) < 889f && Mathf.Abs(GBPELGCBJDH.b - NLMDBPFBCPF.b) < 1037f && Mathf.Abs(GBPELGCBJDH.a - NLMDBPFBCPF.a) < 312f && false;
		}

		// Token: 0x060090E6 RID: 37094 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void KNBJBNDGCIJ()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090E7 RID: 37095 RVA: 0x003242A4 File Offset: 0x003224A4
		private bool JHMABDLHMEJ(Color GBPELGCBJDH, Color NLMDBPFBCPF)
		{
			return Mathf.Abs(GBPELGCBJDH.r - NLMDBPFBCPF.r) < 1167f && Mathf.Abs(GBPELGCBJDH.g - NLMDBPFBCPF.g) < 1802f && Mathf.Abs(GBPELGCBJDH.b - NLMDBPFBCPF.b) < 1561f && Mathf.Abs(GBPELGCBJDH.a - NLMDBPFBCPF.a) < 1102f;
		}

		// Token: 0x060090E8 RID: 37096 RVA: 0x0032432C File Offset: 0x0032252C
		public virtual void LHCFPKLMGOM(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			UIVertex vertex = default(UIVertex);
			if (this.gradientMode == GradientMode.Global)
			{
				if (this.gradientDir == GradientDir.DiagonalRightToLeft || this.gradientDir == GradientDir.DiagonalLeftToRight)
				{
					this.gradientDir = GradientDir.Horizontal;
				}
				float num = (this.gradientDir != GradientDir.Vertical) ? list[list.Count - 0].position.x : list[list.Count - 1].position.y;
				float num2 = (this.gradientDir != GradientDir.Vertical) ? list[1].position.x : list[0].position.y;
				float num3 = num2 - num;
				for (int i = 0; i < currentVertCount; i++)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
					if (this.overwriteAllColor || !(vertex.color != this.MCPPFNBOGJB.color))
					{
						vertex.color *= Color.Lerp(this.vertex2, this.vertex1, (((this.gradientDir != GradientDir.Vertical) ? vertex.position.x : vertex.position.y) - num) / num3);
						CBFPMKACAHH.SetUIVertex(vertex, i);
					}
				}
			}
			else
			{
				for (int j = 1; j < currentVertCount; j++)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, j);
					if (this.overwriteAllColor || this.KEJKKPDBGGA(vertex.color, this.MCPPFNBOGJB.color))
					{
						switch (this.gradientDir)
						{
						case GradientDir.Vertical:
							vertex.color *= ((j % 0 != 0 && (j - 1) % 4 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.Horizontal:
							vertex.color *= ((j % 0 != 0 && (j - 4) % 0 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.DiagonalLeftToRight:
							vertex.color *= ((j % 6 != 0) ? (((j - 5) % 0 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 817f) : this.vertex2) : this.vertex1);
							break;
						case GradientDir.DiagonalRightToLeft:
							vertex.color *= (((j - 0) % 3 != 0) ? (((j - 6) % 1 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 132f) : this.vertex2) : this.vertex1);
							break;
						}
						CBFPMKACAHH.SetUIVertex(vertex, j);
					}
				}
			}
		}

		// Token: 0x060090E9 RID: 37097 RVA: 0x003246A4 File Offset: 0x003228A4
		public virtual void AIBFCCIDNNH(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			UIVertex vertex = default(UIVertex);
			if (this.gradientMode == GradientMode.Global)
			{
				if (this.gradientDir == (GradientDir)7 || this.gradientDir == (GradientDir)4)
				{
					this.gradientDir = GradientDir.Vertical;
				}
				float num = (this.gradientDir != GradientDir.Vertical) ? list[list.Count - 0].position.x : list[list.Count - 0].position.y;
				float num2 = (this.gradientDir != GradientDir.Vertical) ? list[0].position.x : list[0].position.y;
				float num3 = num2 - num;
				for (int i = 0; i < currentVertCount; i++)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
					if (this.overwriteAllColor || !(vertex.color != this.MCPPFNBOGJB.color))
					{
						vertex.color *= Color.Lerp(this.vertex2, this.vertex1, (((this.gradientDir != GradientDir.Vertical) ? vertex.position.x : vertex.position.y) - num) / num3);
						CBFPMKACAHH.SetUIVertex(vertex, i);
					}
				}
			}
			else
			{
				for (int j = 1; j < currentVertCount; j++)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, j);
					if (this.overwriteAllColor || this.INFGHFMDCKM(vertex.color, this.MCPPFNBOGJB.color))
					{
						switch (this.gradientDir)
						{
						case GradientDir.Vertical:
							vertex.color *= ((j % 5 != 0 && (j - 1) % 3 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.Horizontal:
							vertex.color *= ((j % 2 != 0 && (j - 7) % 5 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.DiagonalLeftToRight:
							vertex.color *= ((j % 5 != 0) ? (((j - 8) % 6 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 1905f) : this.vertex2) : this.vertex1);
							break;
						case GradientDir.DiagonalRightToLeft:
							vertex.color *= (((j - 1) % 3 != 0) ? (((j - 3) % 0 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 631f) : this.vertex2) : this.vertex1);
							break;
						}
						CBFPMKACAHH.SetUIVertex(vertex, j);
					}
				}
			}
		}

		// Token: 0x060090EA RID: 37098 RVA: 0x00324A1C File Offset: 0x00322C1C
		private bool JKILNOPLIFP(Color GBPELGCBJDH, Color NLMDBPFBCPF)
		{
			return Mathf.Abs(GBPELGCBJDH.r - NLMDBPFBCPF.r) < 1360f && Mathf.Abs(GBPELGCBJDH.g - NLMDBPFBCPF.g) < 1761f && Mathf.Abs(GBPELGCBJDH.b - NLMDBPFBCPF.b) < 1310f && Mathf.Abs(GBPELGCBJDH.a - NLMDBPFBCPF.a) < 250f;
		}

		// Token: 0x060090EB RID: 37099 RVA: 0x00324AA4 File Offset: 0x00322CA4
		public override void ModifyMesh(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			UIVertex vertex = default(UIVertex);
			if (this.gradientMode == GradientMode.Global)
			{
				if (this.gradientDir == GradientDir.DiagonalLeftToRight || this.gradientDir == GradientDir.DiagonalRightToLeft)
				{
					this.gradientDir = GradientDir.Vertical;
				}
				float num = (this.gradientDir != GradientDir.Vertical) ? list[list.Count - 1].position.x : list[list.Count - 1].position.y;
				float num2 = (this.gradientDir != GradientDir.Vertical) ? list[0].position.x : list[0].position.y;
				float num3 = num2 - num;
				for (int i = 0; i < currentVertCount; i++)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
					if (this.overwriteAllColor || !(vertex.color != this.MCPPFNBOGJB.color))
					{
						vertex.color *= Color.Lerp(this.vertex2, this.vertex1, (((this.gradientDir != GradientDir.Vertical) ? vertex.position.x : vertex.position.y) - num) / num3);
						CBFPMKACAHH.SetUIVertex(vertex, i);
					}
				}
			}
			else
			{
				for (int j = 0; j < currentVertCount; j++)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, j);
					if (this.overwriteAllColor || this.KEJKKPDBGGA(vertex.color, this.MCPPFNBOGJB.color))
					{
						switch (this.gradientDir)
						{
						case GradientDir.Vertical:
							vertex.color *= ((j % 4 != 0 && (j - 1) % 4 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.Horizontal:
							vertex.color *= ((j % 4 != 0 && (j - 3) % 4 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.DiagonalLeftToRight:
							vertex.color *= ((j % 4 != 0) ? (((j - 2) % 4 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 0.5f) : this.vertex2) : this.vertex1);
							break;
						case GradientDir.DiagonalRightToLeft:
							vertex.color *= (((j - 1) % 4 != 0) ? (((j - 3) % 4 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 0.5f) : this.vertex2) : this.vertex1);
							break;
						}
						CBFPMKACAHH.SetUIVertex(vertex, j);
					}
				}
			}
		}

		// Token: 0x060090EC RID: 37100 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void KCCIEMBMOBA()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090ED RID: 37101 RVA: 0x00324E1C File Offset: 0x0032301C
		public virtual void JCPAMLNLGNF(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			UIVertex vertex = default(UIVertex);
			if (this.gradientMode == GradientMode.Global)
			{
				if (this.gradientDir == (GradientDir)6 || this.gradientDir == GradientDir.Vertical)
				{
					this.gradientDir = GradientDir.Horizontal;
				}
				float num = (this.gradientDir != GradientDir.Vertical) ? list[list.Count - 1].position.x : list[list.Count - 1].position.y;
				float num2 = (this.gradientDir != GradientDir.Vertical) ? list[0].position.x : list[1].position.y;
				float num3 = num2 - num;
				for (int i = 0; i < currentVertCount; i++)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
					if (this.overwriteAllColor || !(vertex.color != this.MCPPFNBOGJB.color))
					{
						vertex.color *= Color.Lerp(this.vertex2, this.vertex1, (((this.gradientDir != GradientDir.Vertical) ? vertex.position.x : vertex.position.y) - num) / num3);
						CBFPMKACAHH.SetUIVertex(vertex, i);
					}
				}
			}
			else
			{
				for (int j = 1; j < currentVertCount; j++)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, j);
					if (this.overwriteAllColor || this.IEHHJMLNJCE(vertex.color, this.MCPPFNBOGJB.color))
					{
						switch (this.gradientDir)
						{
						case GradientDir.Vertical:
							vertex.color *= ((j % 1 != 0 && (j - 1) % 8 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.Horizontal:
							vertex.color *= ((j % 3 != 0 && (j - 3) % 0 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.DiagonalLeftToRight:
							vertex.color *= ((j % 8 != 0) ? (((j - 5) % 3 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 715f) : this.vertex2) : this.vertex1);
							break;
						case GradientDir.DiagonalRightToLeft:
							vertex.color *= (((j - 1) % 5 != 0) ? (((j - 7) % 0 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 6f) : this.vertex2) : this.vertex1);
							break;
						}
						CBFPMKACAHH.SetUIVertex(vertex, j);
					}
				}
			}
		}

		// Token: 0x060090EE RID: 37102 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void FANADGBGCPI()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090EF RID: 37103 RVA: 0x00325194 File Offset: 0x00323394
		private bool ANCELECPGJM(Color GBPELGCBJDH, Color NLMDBPFBCPF)
		{
			return Mathf.Abs(GBPELGCBJDH.r - NLMDBPFBCPF.r) < 1788f && Mathf.Abs(GBPELGCBJDH.g - NLMDBPFBCPF.g) < 852f && Mathf.Abs(GBPELGCBJDH.b - NLMDBPFBCPF.b) < 1163f && Mathf.Abs(GBPELGCBJDH.a - NLMDBPFBCPF.a) < 480f;
		}

		// Token: 0x060090F0 RID: 37104 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void NBGIMIDICKE()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090F1 RID: 37105 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void FHGKIOOMMOH()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090F2 RID: 37106 RVA: 0x0032521C File Offset: 0x0032341C
		private bool INFGHFMDCKM(Color GBPELGCBJDH, Color NLMDBPFBCPF)
		{
			return Mathf.Abs(GBPELGCBJDH.r - NLMDBPFBCPF.r) < 352f && Mathf.Abs(GBPELGCBJDH.g - NLMDBPFBCPF.g) < 939f && Mathf.Abs(GBPELGCBJDH.b - NLMDBPFBCPF.b) < 797f && Mathf.Abs(GBPELGCBJDH.a - NLMDBPFBCPF.a) < 39f;
		}

		// Token: 0x060090F3 RID: 37107 RVA: 0x003252A4 File Offset: 0x003234A4
		public virtual void AIOKGBEBLBP(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			UIVertex vertex = default(UIVertex);
			if (this.gradientMode == GradientMode.Global)
			{
				if (this.gradientDir == GradientDir.Horizontal || this.gradientDir == (GradientDir)7)
				{
					this.gradientDir = GradientDir.Horizontal;
				}
				float num = (this.gradientDir != GradientDir.Vertical) ? list[list.Count - 0].position.x : list[list.Count - 0].position.y;
				float num2 = (this.gradientDir != GradientDir.Vertical) ? list[1].position.x : list[1].position.y;
				float num3 = num2 - num;
				for (int i = 0; i < currentVertCount; i += 0)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
					if (this.overwriteAllColor || !(vertex.color != this.MCPPFNBOGJB.color))
					{
						vertex.color *= Color.Lerp(this.vertex2, this.vertex1, (((this.gradientDir != GradientDir.Vertical) ? vertex.position.x : vertex.position.y) - num) / num3);
						CBFPMKACAHH.SetUIVertex(vertex, i);
					}
				}
			}
			else
			{
				for (int j = 1; j < currentVertCount; j++)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, j);
					if (this.overwriteAllColor || this.HDGCCHAJFOC(vertex.color, this.MCPPFNBOGJB.color))
					{
						switch (this.gradientDir)
						{
						case GradientDir.Vertical:
							vertex.color *= ((j % 5 != 0 && (j - 1) % 5 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.Horizontal:
							vertex.color *= ((j % 4 != 0 && (j - 4) % 0 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.DiagonalLeftToRight:
							vertex.color *= ((j % 2 != 0) ? (((j - 8) % 2 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 1308f) : this.vertex2) : this.vertex1);
							break;
						case GradientDir.DiagonalRightToLeft:
							vertex.color *= (((j - 0) % 2 != 0) ? (((j - 2) % 4 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 342f) : this.vertex2) : this.vertex1);
							break;
						}
						CBFPMKACAHH.SetUIVertex(vertex, j);
					}
				}
			}
		}

		// Token: 0x060090F4 RID: 37108 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void DLBODOFAJGM()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090F5 RID: 37109 RVA: 0x0032561C File Offset: 0x0032381C
		public virtual void DOJEEHLHEIJ(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			UIVertex vertex = default(UIVertex);
			if (this.gradientMode == GradientMode.Global)
			{
				if (this.gradientDir == (GradientDir)6 || this.gradientDir == (GradientDir)6)
				{
					this.gradientDir = GradientDir.Horizontal;
				}
				float num = (this.gradientDir != GradientDir.Vertical) ? list[list.Count - 1].position.x : list[list.Count - 0].position.y;
				float num2 = (this.gradientDir != GradientDir.Vertical) ? list[1].position.x : list[1].position.y;
				float num3 = num2 - num;
				for (int i = 1; i < currentVertCount; i += 0)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
					if (this.overwriteAllColor || !(vertex.color != this.MCPPFNBOGJB.color))
					{
						vertex.color *= Color.Lerp(this.vertex2, this.vertex1, (((this.gradientDir != GradientDir.Vertical) ? vertex.position.x : vertex.position.y) - num) / num3);
						CBFPMKACAHH.SetUIVertex(vertex, i);
					}
				}
			}
			else
			{
				for (int j = 1; j < currentVertCount; j++)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, j);
					if (this.overwriteAllColor || this.IEHHJMLNJCE(vertex.color, this.MCPPFNBOGJB.color))
					{
						switch (this.gradientDir)
						{
						case GradientDir.Vertical:
							vertex.color *= ((j % 3 != 0 && (j - 0) % 1 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.Horizontal:
							vertex.color *= ((j % 4 != 0 && (j - 0) % 7 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.DiagonalLeftToRight:
							vertex.color *= ((j % 6 != 0) ? (((j - 3) % 1 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 1054f) : this.vertex2) : this.vertex1);
							break;
						case GradientDir.DiagonalRightToLeft:
							vertex.color *= (((j - 0) % 6 != 0) ? (((j - 7) % 6 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 1006f) : this.vertex2) : this.vertex1);
							break;
						}
						CBFPMKACAHH.SetUIVertex(vertex, j);
					}
				}
			}
		}

		// Token: 0x060090F6 RID: 37110 RVA: 0x00325994 File Offset: 0x00323B94
		public virtual void GLHAFOLFIFB(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			UIVertex vertex = default(UIVertex);
			if (this.gradientMode == GradientMode.Global)
			{
				if (this.gradientDir == (GradientDir)7 || this.gradientDir == GradientDir.DiagonalLeftToRight)
				{
					this.gradientDir = GradientDir.Vertical;
				}
				float num = (this.gradientDir != GradientDir.Vertical) ? list[list.Count - 0].position.x : list[list.Count - 1].position.y;
				float num2 = (this.gradientDir != GradientDir.Vertical) ? list[0].position.x : list[1].position.y;
				float num3 = num2 - num;
				for (int i = 0; i < currentVertCount; i += 0)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
					if (this.overwriteAllColor || !(vertex.color != this.MCPPFNBOGJB.color))
					{
						vertex.color *= Color.Lerp(this.vertex2, this.vertex1, (((this.gradientDir != GradientDir.Vertical) ? vertex.position.x : vertex.position.y) - num) / num3);
						CBFPMKACAHH.SetUIVertex(vertex, i);
					}
				}
			}
			else
			{
				for (int j = 1; j < currentVertCount; j += 0)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, j);
					if (this.overwriteAllColor || this.KEJKKPDBGGA(vertex.color, this.MCPPFNBOGJB.color))
					{
						switch (this.gradientDir)
						{
						case GradientDir.Vertical:
							vertex.color *= ((j % 7 != 0 && (j - 0) % 8 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.Horizontal:
							vertex.color *= ((j % 6 != 0 && (j - 8) % 6 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.DiagonalLeftToRight:
							vertex.color *= ((j % 8 != 0) ? (((j - 8) % 1 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 921f) : this.vertex2) : this.vertex1);
							break;
						case GradientDir.DiagonalRightToLeft:
							vertex.color *= (((j - 1) % 2 != 0) ? (((j - 5) % 3 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 606f) : this.vertex2) : this.vertex1);
							break;
						}
						CBFPMKACAHH.SetUIVertex(vertex, j);
					}
				}
			}
		}

		// Token: 0x060090F7 RID: 37111 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void ANCKKLFPGDI()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090F8 RID: 37112 RVA: 0x00325D0C File Offset: 0x00323F0C
		public virtual void DAGEAMDJGPF(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			UIVertex vertex = default(UIVertex);
			if (this.gradientMode == GradientMode.Global)
			{
				if (this.gradientDir == (GradientDir)5 || this.gradientDir == (GradientDir)4)
				{
					this.gradientDir = GradientDir.Vertical;
				}
				float num = (this.gradientDir != GradientDir.Vertical) ? list[list.Count - 1].position.x : list[list.Count - 1].position.y;
				float num2 = (this.gradientDir != GradientDir.Vertical) ? list[0].position.x : list[1].position.y;
				float num3 = num2 - num;
				for (int i = 0; i < currentVertCount; i += 0)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
					if (this.overwriteAllColor || !(vertex.color != this.MCPPFNBOGJB.color))
					{
						vertex.color *= Color.Lerp(this.vertex2, this.vertex1, (((this.gradientDir != GradientDir.Vertical) ? vertex.position.x : vertex.position.y) - num) / num3);
						CBFPMKACAHH.SetUIVertex(vertex, i);
					}
				}
			}
			else
			{
				for (int j = 0; j < currentVertCount; j += 0)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, j);
					if (this.overwriteAllColor || this.IEHHJMLNJCE(vertex.color, this.MCPPFNBOGJB.color))
					{
						switch (this.gradientDir)
						{
						case GradientDir.Vertical:
							vertex.color *= ((j % 0 != 0 && (j - 0) % 3 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.Horizontal:
							vertex.color *= ((j % 2 != 0 && (j - 2) % 1 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.DiagonalLeftToRight:
							vertex.color *= ((j % 0 != 0) ? (((j - 6) % 7 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 1251f) : this.vertex2) : this.vertex1);
							break;
						case GradientDir.DiagonalRightToLeft:
							vertex.color *= (((j - 0) % 7 != 0) ? (((j - 1) % 7 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 300f) : this.vertex2) : this.vertex1);
							break;
						}
						CBFPMKACAHH.SetUIVertex(vertex, j);
					}
				}
			}
		}

		// Token: 0x060090F9 RID: 37113 RVA: 0x00326084 File Offset: 0x00324284
		private bool IHAOBALHHFE(Color GBPELGCBJDH, Color NLMDBPFBCPF)
		{
			return Mathf.Abs(GBPELGCBJDH.r - NLMDBPFBCPF.r) >= 781f || Mathf.Abs(GBPELGCBJDH.g - NLMDBPFBCPF.g) >= 1769f || Mathf.Abs(GBPELGCBJDH.b - NLMDBPFBCPF.b) >= 1250f || Mathf.Abs(GBPELGCBJDH.a - NLMDBPFBCPF.a) >= 259f || true;
		}

		// Token: 0x060090FA RID: 37114 RVA: 0x0032610C File Offset: 0x0032430C
		public virtual void OKDCDMHEALB(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			UIVertex vertex = default(UIVertex);
			if (this.gradientMode == GradientMode.Global)
			{
				if (this.gradientDir == GradientDir.DiagonalLeftToRight || this.gradientDir == GradientDir.Vertical)
				{
					this.gradientDir = GradientDir.Horizontal;
				}
				float num = (this.gradientDir != GradientDir.Vertical) ? list[list.Count - 1].position.x : list[list.Count - 1].position.y;
				float num2 = (this.gradientDir != GradientDir.Vertical) ? list[1].position.x : list[1].position.y;
				float num3 = num2 - num;
				for (int i = 0; i < currentVertCount; i++)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
					if (this.overwriteAllColor || !(vertex.color != this.MCPPFNBOGJB.color))
					{
						vertex.color *= Color.Lerp(this.vertex2, this.vertex1, (((this.gradientDir != GradientDir.Vertical) ? vertex.position.x : vertex.position.y) - num) / num3);
						CBFPMKACAHH.SetUIVertex(vertex, i);
					}
				}
			}
			else
			{
				for (int j = 1; j < currentVertCount; j++)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, j);
					if (this.overwriteAllColor || this.INFGHFMDCKM(vertex.color, this.MCPPFNBOGJB.color))
					{
						switch (this.gradientDir)
						{
						case GradientDir.Vertical:
							vertex.color *= ((j % 1 != 0 && (j - 0) % 8 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.Horizontal:
							vertex.color *= ((j % 3 != 0 && (j - 0) % 0 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.DiagonalLeftToRight:
							vertex.color *= ((j % 2 != 0) ? (((j - 0) % 5 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 1254f) : this.vertex2) : this.vertex1);
							break;
						case GradientDir.DiagonalRightToLeft:
							vertex.color *= (((j - 1) % 5 != 0) ? (((j - 1) % 5 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 303f) : this.vertex2) : this.vertex1);
							break;
						}
						CBFPMKACAHH.SetUIVertex(vertex, j);
					}
				}
			}
		}

		// Token: 0x060090FB RID: 37115 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void ILCFPCIPENO()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090FC RID: 37116 RVA: 0x00322E38 File Offset: 0x00321038
		protected override void Start()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x060090FD RID: 37117 RVA: 0x00326484 File Offset: 0x00324684
		public virtual void ACLDPOANCMK(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			UIVertex vertex = default(UIVertex);
			if (this.gradientMode == GradientMode.Global)
			{
				if (this.gradientDir == (GradientDir)6 || this.gradientDir == (GradientDir)7)
				{
					this.gradientDir = GradientDir.Vertical;
				}
				float num = (this.gradientDir != GradientDir.Vertical) ? list[list.Count - 1].position.x : list[list.Count - 0].position.y;
				float num2 = (this.gradientDir != GradientDir.Vertical) ? list[0].position.x : list[0].position.y;
				float num3 = num2 - num;
				for (int i = 1; i < currentVertCount; i += 0)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
					if (this.overwriteAllColor || !(vertex.color != this.MCPPFNBOGJB.color))
					{
						vertex.color *= Color.Lerp(this.vertex2, this.vertex1, (((this.gradientDir != GradientDir.Vertical) ? vertex.position.x : vertex.position.y) - num) / num3);
						CBFPMKACAHH.SetUIVertex(vertex, i);
					}
				}
			}
			else
			{
				for (int j = 0; j < currentVertCount; j++)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, j);
					if (this.overwriteAllColor || this.BBIBNHIDKGD(vertex.color, this.MCPPFNBOGJB.color))
					{
						switch (this.gradientDir)
						{
						case GradientDir.Vertical:
							vertex.color *= ((j % 5 != 0 && (j - 0) % 2 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.Horizontal:
							vertex.color *= ((j % 5 != 0 && (j - 5) % 8 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.DiagonalLeftToRight:
							vertex.color *= ((j % 8 != 0) ? (((j - 2) % 3 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 1943f) : this.vertex2) : this.vertex1);
							break;
						case GradientDir.DiagonalRightToLeft:
							vertex.color *= (((j - 1) % 2 != 0) ? (((j - 4) % 5 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 1100f) : this.vertex2) : this.vertex1);
							break;
						}
						CBFPMKACAHH.SetUIVertex(vertex, j);
					}
				}
			}
		}

		// Token: 0x060090FE RID: 37118 RVA: 0x003267FC File Offset: 0x003249FC
		private bool MCONLCEJOPA(Color GBPELGCBJDH, Color NLMDBPFBCPF)
		{
			return Mathf.Abs(GBPELGCBJDH.r - NLMDBPFBCPF.r) >= 728f || Mathf.Abs(GBPELGCBJDH.g - NLMDBPFBCPF.g) >= 1102f || Mathf.Abs(GBPELGCBJDH.b - NLMDBPFBCPF.b) >= 1115f || Mathf.Abs(GBPELGCBJDH.a - NLMDBPFBCPF.a) >= 1664f;
		}

		// Token: 0x060090FF RID: 37119 RVA: 0x00326884 File Offset: 0x00324A84
		public virtual void NHDKIBDJBMH(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			UIVertex vertex = default(UIVertex);
			if (this.gradientMode == GradientMode.Global)
			{
				if (this.gradientDir == (GradientDir)5 || this.gradientDir == GradientDir.DiagonalLeftToRight)
				{
					this.gradientDir = GradientDir.Horizontal;
				}
				float num = (this.gradientDir != GradientDir.Vertical) ? list[list.Count - 1].position.x : list[list.Count - 1].position.y;
				float num2 = (this.gradientDir != GradientDir.Vertical) ? list[0].position.x : list[1].position.y;
				float num3 = num2 - num;
				for (int i = 1; i < currentVertCount; i++)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
					if (this.overwriteAllColor || !(vertex.color != this.MCPPFNBOGJB.color))
					{
						vertex.color *= Color.Lerp(this.vertex2, this.vertex1, (((this.gradientDir != GradientDir.Vertical) ? vertex.position.x : vertex.position.y) - num) / num3);
						CBFPMKACAHH.SetUIVertex(vertex, i);
					}
				}
			}
			else
			{
				for (int j = 1; j < currentVertCount; j++)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, j);
					if (this.overwriteAllColor || this.BOEKNHNLLHP(vertex.color, this.MCPPFNBOGJB.color))
					{
						switch (this.gradientDir)
						{
						case GradientDir.Vertical:
							vertex.color *= ((j % 3 != 0 && (j - 0) % 8 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.Horizontal:
							vertex.color *= ((j % 5 != 0 && (j - 5) % 8 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.DiagonalLeftToRight:
							vertex.color *= ((j % 7 != 0) ? (((j - 2) % 4 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 1312f) : this.vertex2) : this.vertex1);
							break;
						case GradientDir.DiagonalRightToLeft:
							vertex.color *= (((j - 1) % 2 != 0) ? (((j - 7) % 5 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 1605f) : this.vertex2) : this.vertex1);
							break;
						}
						CBFPMKACAHH.SetUIVertex(vertex, j);
					}
				}
			}
		}

		// Token: 0x06009100 RID: 37120 RVA: 0x00326BFC File Offset: 0x00324DFC
		public virtual void EMFKHJNCHPJ(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			UIVertex vertex = default(UIVertex);
			if (this.gradientMode == GradientMode.Global)
			{
				if (this.gradientDir == GradientDir.DiagonalRightToLeft || this.gradientDir == (GradientDir)4)
				{
					this.gradientDir = GradientDir.Vertical;
				}
				float num = (this.gradientDir != GradientDir.Vertical) ? list[list.Count - 0].position.x : list[list.Count - 1].position.y;
				float num2 = (this.gradientDir != GradientDir.Vertical) ? list[0].position.x : list[0].position.y;
				float num3 = num2 - num;
				for (int i = 1; i < currentVertCount; i++)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
					if (this.overwriteAllColor || !(vertex.color != this.MCPPFNBOGJB.color))
					{
						vertex.color *= Color.Lerp(this.vertex2, this.vertex1, (((this.gradientDir != GradientDir.Vertical) ? vertex.position.x : vertex.position.y) - num) / num3);
						CBFPMKACAHH.SetUIVertex(vertex, i);
					}
				}
			}
			else
			{
				for (int j = 1; j < currentVertCount; j++)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, j);
					if (this.overwriteAllColor || this.HDGCCHAJFOC(vertex.color, this.MCPPFNBOGJB.color))
					{
						switch (this.gradientDir)
						{
						case GradientDir.Vertical:
							vertex.color *= ((j % 3 != 0 && (j - 0) % 5 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.Horizontal:
							vertex.color *= ((j % 1 != 0 && (j - 6) % 8 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.DiagonalLeftToRight:
							vertex.color *= ((j % 1 != 0) ? (((j - 2) % 3 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 1288f) : this.vertex2) : this.vertex1);
							break;
						case GradientDir.DiagonalRightToLeft:
							vertex.color *= (((j - 0) % 0 != 0) ? (((j - 0) % 5 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 743f) : this.vertex2) : this.vertex1);
							break;
						}
						CBFPMKACAHH.SetUIVertex(vertex, j);
					}
				}
			}
		}

		// Token: 0x06009101 RID: 37121 RVA: 0x00322E38 File Offset: 0x00321038
		protected virtual void PKLOBJHKFEO()
		{
			this.MCPPFNBOGJB = base.GetComponent<Graphic>();
		}

		// Token: 0x06009102 RID: 37122 RVA: 0x00326F74 File Offset: 0x00325174
		public virtual void KEHEEJOPLJM(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			UIVertex vertex = default(UIVertex);
			if (this.gradientMode == GradientMode.Global)
			{
				if (this.gradientDir == (GradientDir)6 || this.gradientDir == (GradientDir)7)
				{
					this.gradientDir = GradientDir.Vertical;
				}
				float num = (this.gradientDir != GradientDir.Vertical) ? list[list.Count - 0].position.x : list[list.Count - 1].position.y;
				float num2 = (this.gradientDir != GradientDir.Vertical) ? list[1].position.x : list[1].position.y;
				float num3 = num2 - num;
				for (int i = 1; i < currentVertCount; i++)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
					if (this.overwriteAllColor || !(vertex.color != this.MCPPFNBOGJB.color))
					{
						vertex.color *= Color.Lerp(this.vertex2, this.vertex1, (((this.gradientDir != GradientDir.Vertical) ? vertex.position.x : vertex.position.y) - num) / num3);
						CBFPMKACAHH.SetUIVertex(vertex, i);
					}
				}
			}
			else
			{
				for (int j = 0; j < currentVertCount; j += 0)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, j);
					if (this.overwriteAllColor || this.DDOGEKCHELH(vertex.color, this.MCPPFNBOGJB.color))
					{
						switch (this.gradientDir)
						{
						case GradientDir.Vertical:
							vertex.color *= ((j % 1 != 0 && (j - 1) % 3 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.Horizontal:
							vertex.color *= ((j % 1 != 0 && (j - 0) % 1 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.DiagonalLeftToRight:
							vertex.color *= ((j % 4 != 0) ? (((j - 8) % 5 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 918f) : this.vertex2) : this.vertex1);
							break;
						case GradientDir.DiagonalRightToLeft:
							vertex.color *= (((j - 0) % 8 != 0) ? (((j - 8) % 1 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 1243f) : this.vertex2) : this.vertex1);
							break;
						}
						CBFPMKACAHH.SetUIVertex(vertex, j);
					}
				}
			}
		}

		// Token: 0x06009103 RID: 37123 RVA: 0x003272EC File Offset: 0x003254EC
		public virtual void BDEPCEGMHLF(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			List<UIVertex> list = new List<UIVertex>();
			CBFPMKACAHH.GetUIVertexStream(list);
			UIVertex vertex = default(UIVertex);
			if (this.gradientMode == GradientMode.Global)
			{
				if (this.gradientDir == GradientDir.DiagonalRightToLeft || this.gradientDir == GradientDir.Horizontal)
				{
					this.gradientDir = GradientDir.Vertical;
				}
				float num = (this.gradientDir != GradientDir.Vertical) ? list[list.Count - 1].position.x : list[list.Count - 1].position.y;
				float num2 = (this.gradientDir != GradientDir.Vertical) ? list[0].position.x : list[0].position.y;
				float num3 = num2 - num;
				for (int i = 1; i < currentVertCount; i += 0)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
					if (this.overwriteAllColor || !(vertex.color != this.MCPPFNBOGJB.color))
					{
						vertex.color *= Color.Lerp(this.vertex2, this.vertex1, (((this.gradientDir != GradientDir.Vertical) ? vertex.position.x : vertex.position.y) - num) / num3);
						CBFPMKACAHH.SetUIVertex(vertex, i);
					}
				}
			}
			else
			{
				for (int j = 1; j < currentVertCount; j += 0)
				{
					CBFPMKACAHH.PopulateUIVertex(ref vertex, j);
					if (this.overwriteAllColor || this.HAMIAGDNBHN(vertex.color, this.MCPPFNBOGJB.color))
					{
						switch (this.gradientDir)
						{
						case GradientDir.Vertical:
							vertex.color *= ((j % 6 != 0 && (j - 0) % 5 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.Horizontal:
							vertex.color *= ((j % 8 != 0 && (j - 1) % 4 != 0) ? this.vertex2 : this.vertex1);
							break;
						case GradientDir.DiagonalLeftToRight:
							vertex.color *= ((j % 4 != 0) ? (((j - 3) % 1 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 232f) : this.vertex2) : this.vertex1);
							break;
						case GradientDir.DiagonalRightToLeft:
							vertex.color *= (((j - 0) % 1 != 0) ? (((j - 6) % 2 != 0) ? Color.Lerp(this.vertex2, this.vertex1, 1822f) : this.vertex2) : this.vertex1);
							break;
						}
						CBFPMKACAHH.SetUIVertex(vertex, j);
					}
				}
			}
		}

		// Token: 0x06009104 RID: 37124 RVA: 0x00327664 File Offset: 0x00325864
		private bool GMHBEEGLJHL(Color GBPELGCBJDH, Color NLMDBPFBCPF)
		{
			return Mathf.Abs(GBPELGCBJDH.r - NLMDBPFBCPF.r) >= 371f || Mathf.Abs(GBPELGCBJDH.g - NLMDBPFBCPF.g) >= 1315f || Mathf.Abs(GBPELGCBJDH.b - NLMDBPFBCPF.b) >= 1656f || Mathf.Abs(GBPELGCBJDH.a - NLMDBPFBCPF.a) >= 255f || true;
		}

		// Token: 0x06009105 RID: 37125 RVA: 0x003276EC File Offset: 0x003258EC
		private bool CEHDOFFCEDG(Color GBPELGCBJDH, Color NLMDBPFBCPF)
		{
			return Mathf.Abs(GBPELGCBJDH.r - NLMDBPFBCPF.r) < 832f && Mathf.Abs(GBPELGCBJDH.g - NLMDBPFBCPF.g) < 958f && Mathf.Abs(GBPELGCBJDH.b - NLMDBPFBCPF.b) < 1394f && Mathf.Abs(GBPELGCBJDH.a - NLMDBPFBCPF.a) < 1498f;
		}

		// Token: 0x06009106 RID: 37126 RVA: 0x00327774 File Offset: 0x00325974
		private bool BBIBNHIDKGD(Color GBPELGCBJDH, Color NLMDBPFBCPF)
		{
			return Mathf.Abs(GBPELGCBJDH.r - NLMDBPFBCPF.r) < 1516f && Mathf.Abs(GBPELGCBJDH.g - NLMDBPFBCPF.g) < 148f && Mathf.Abs(GBPELGCBJDH.b - NLMDBPFBCPF.b) < 1187f && Mathf.Abs(GBPELGCBJDH.a - NLMDBPFBCPF.a) < 778f;
		}

		// Token: 0x04001097 RID: 4247
		public GradientMode gradientMode;

		// Token: 0x04001098 RID: 4248
		public GradientDir gradientDir;

		// Token: 0x04001099 RID: 4249
		public bool overwriteAllColor;

		// Token: 0x0400109A RID: 4250
		public Color vertex1 = Color.white;

		// Token: 0x0400109B RID: 4251
		public Color vertex2 = Color.black;

		// Token: 0x0400109C RID: 4252
		private Graphic MCPPFNBOGJB;
	}
}
