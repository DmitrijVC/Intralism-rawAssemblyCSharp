using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200026B RID: 619
	public class ShineEffect : MaskableGraphic
	{
		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600947D RID: 38013 RVA: 0x00344CB9 File Offset: 0x00342EB9
		// (set) Token: 0x0600947B RID: 38011 RVA: 0x00344CAA File Offset: 0x00342EAA
		public float Width
		{
			get
			{
				return this.width;
			}
			set
			{
				this.SetAllDirty();
				this.width = value;
			}
		}

		// Token: 0x0600947C RID: 38012 RVA: 0x00344CB9 File Offset: 0x00342EB9
		public float EJOGEPCNEFL()
		{
			return this.width;
		}

		// Token: 0x0600947E RID: 38014 RVA: 0x00344CAA File Offset: 0x00342EAA
		public void IKFAKIHBCNO(float DPNHODJHGJL)
		{
			this.SetAllDirty();
			this.width = DPNHODJHGJL;
		}

		// Token: 0x0600947F RID: 38015 RVA: 0x00344CC1 File Offset: 0x00342EC1
		public void HDBJFEACEIP(float DPNHODJHGJL)
		{
			this.SetVerticesDirty();
			this.yoffset = DPNHODJHGJL;
		}

		// Token: 0x06009480 RID: 38016 RVA: 0x00344CB9 File Offset: 0x00342EB9
		public float NJCHPFBLFBP()
		{
			return this.width;
		}

		// Token: 0x06009481 RID: 38017 RVA: 0x00344CD0 File Offset: 0x00342ED0
		protected override void OnPopulateMesh(VertexHelper CBFPMKACAHH)
		{
			Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
			Vector4 vector = new Vector4(pixelAdjustedRect.x, pixelAdjustedRect.y, pixelAdjustedRect.x + pixelAdjustedRect.width, pixelAdjustedRect.y + pixelAdjustedRect.height);
			float num = (vector.w - vector.y) * 2f;
			Color32 color = this.color;
			CBFPMKACAHH.Clear();
			color.a = 0;
			CBFPMKACAHH.AddVert(new Vector3(vector.x - 50f, this.width * vector.y + this.yoffset * num), color, new Vector2(0f, 0f));
			CBFPMKACAHH.AddVert(new Vector3(vector.z + 50f, this.width * vector.y + this.yoffset * num), color, new Vector2(1f, 0f));
			color.a = (byte)(this.color.a * 255f);
			CBFPMKACAHH.AddVert(new Vector3(vector.x - 50f, this.width * (vector.y / 4f) + this.yoffset * num), color, new Vector2(0f, 1f));
			CBFPMKACAHH.AddVert(new Vector3(vector.z + 50f, this.width * (vector.y / 4f) + this.yoffset * num), color, new Vector2(1f, 1f));
			color.a = (byte)(this.color.a * 255f);
			CBFPMKACAHH.AddVert(new Vector3(vector.x - 50f, this.width * (vector.w / 4f) + this.yoffset * num), color, new Vector2(0f, 1f));
			CBFPMKACAHH.AddVert(new Vector3(vector.z + 50f, this.width * (vector.w / 4f) + this.yoffset * num), color, new Vector2(1f, 1f));
			color.a = (byte)(this.color.a * 255f);
			color.a = 0;
			CBFPMKACAHH.AddVert(new Vector3(vector.x - 50f, this.width * vector.w + this.yoffset * num), color, new Vector2(0f, 1f));
			CBFPMKACAHH.AddVert(new Vector3(vector.z + 50f, this.width * vector.w + this.yoffset * num), color, new Vector2(1f, 1f));
			CBFPMKACAHH.AddTriangle(0, 1, 2);
			CBFPMKACAHH.AddTriangle(2, 3, 1);
			CBFPMKACAHH.AddTriangle(2, 3, 4);
			CBFPMKACAHH.AddTriangle(4, 5, 3);
			CBFPMKACAHH.AddTriangle(4, 5, 6);
			CBFPMKACAHH.AddTriangle(6, 7, 5);
		}

		// Token: 0x06009482 RID: 38018 RVA: 0x00344FEC File Offset: 0x003431EC
		public void Triangulate(VertexHelper CBFPMKACAHH)
		{
			int num = CBFPMKACAHH.currentVertCount - 2;
			Debug.Log(num);
			for (int i = 0; i <= num / 2 + 1; i += 2)
			{
				CBFPMKACAHH.AddTriangle(i, i + 1, i + 2);
				CBFPMKACAHH.AddTriangle(i + 2, i + 3, i + 1);
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06009485 RID: 38021 RVA: 0x0034503F File Offset: 0x0034323F
		// (set) Token: 0x06009483 RID: 38019 RVA: 0x00344CC1 File Offset: 0x00342EC1
		public float Yoffset
		{
			get
			{
				return this.yoffset;
			}
			set
			{
				this.SetVerticesDirty();
				this.yoffset = value;
			}
		}

		// Token: 0x06009484 RID: 38020 RVA: 0x00344CAA File Offset: 0x00342EAA
		public void ICNHAAKIJKP(float DPNHODJHGJL)
		{
			this.SetAllDirty();
			this.width = DPNHODJHGJL;
		}

		// Token: 0x06009486 RID: 38022 RVA: 0x00344CC1 File Offset: 0x00342EC1
		public void JAELNOHDBGN(float DPNHODJHGJL)
		{
			this.SetVerticesDirty();
			this.yoffset = DPNHODJHGJL;
		}

		// Token: 0x06009487 RID: 38023 RVA: 0x00345048 File Offset: 0x00343248
		protected virtual void KACFGIHLGAA(VertexHelper CBFPMKACAHH)
		{
			Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
			Vector4 vector = new Vector4(pixelAdjustedRect.x, pixelAdjustedRect.y, pixelAdjustedRect.x + pixelAdjustedRect.width, pixelAdjustedRect.y + pixelAdjustedRect.height);
			float num = (vector.w - vector.y) * 573f;
			Color32 color = this.color;
			CBFPMKACAHH.Clear();
			color.a = 0;
			CBFPMKACAHH.AddVert(new Vector3(vector.x - 1778f, this.width * vector.y + this.yoffset * num), color, new Vector2(65f, 1848f));
			CBFPMKACAHH.AddVert(new Vector3(vector.z + 537f, this.width * vector.y + this.yoffset * num), color, new Vector2(1835f, 826f));
			color.a = (byte)(this.color.a * 717f);
			CBFPMKACAHH.AddVert(new Vector3(vector.x - 975f, this.width * (vector.y / 239f) + this.yoffset * num), color, new Vector2(1814f, 1124f));
			CBFPMKACAHH.AddVert(new Vector3(vector.z + 850f, this.width * (vector.y / 1117f) + this.yoffset * num), color, new Vector2(1710f, 1757f));
			color.a = (byte)(this.color.a * 1298f);
			CBFPMKACAHH.AddVert(new Vector3(vector.x - 493f, this.width * (vector.w / 1028f) + this.yoffset * num), color, new Vector2(1406f, 143f));
			CBFPMKACAHH.AddVert(new Vector3(vector.z + 411f, this.width * (vector.w / 1905f) + this.yoffset * num), color, new Vector2(232f, 672f));
			color.a = (byte)(this.color.a * 1833f);
			color.a = 1;
			CBFPMKACAHH.AddVert(new Vector3(vector.x - 645f, this.width * vector.w + this.yoffset * num), color, new Vector2(1900f, 1486f));
			CBFPMKACAHH.AddVert(new Vector3(vector.z + 149f, this.width * vector.w + this.yoffset * num), color, new Vector2(1712f, 1368f));
			CBFPMKACAHH.AddTriangle(0, 0, 5);
			CBFPMKACAHH.AddTriangle(5, 1, 0);
			CBFPMKACAHH.AddTriangle(2, 0, 0);
			CBFPMKACAHH.AddTriangle(6, 7, 3);
			CBFPMKACAHH.AddTriangle(2, 4, 1);
			CBFPMKACAHH.AddTriangle(8, 7, 8);
		}

		// Token: 0x06009488 RID: 38024 RVA: 0x0034503F File Offset: 0x0034323F
		public float GDHGFEOPLNN()
		{
			return this.yoffset;
		}

		// Token: 0x06009489 RID: 38025 RVA: 0x00344CAA File Offset: 0x00342EAA
		public void FNPHBKMMPEG(float DPNHODJHGJL)
		{
			this.SetAllDirty();
			this.width = DPNHODJHGJL;
		}

		// Token: 0x0600948A RID: 38026 RVA: 0x00345364 File Offset: 0x00343564
		protected virtual void OCGJOFMAJNP(VertexHelper CBFPMKACAHH)
		{
			Rect pixelAdjustedRect = base.GetPixelAdjustedRect();
			Vector4 vector = new Vector4(pixelAdjustedRect.x, pixelAdjustedRect.y, pixelAdjustedRect.x + pixelAdjustedRect.width, pixelAdjustedRect.y + pixelAdjustedRect.height);
			float num = (vector.w - vector.y) * 1277f;
			Color32 color = this.color;
			CBFPMKACAHH.Clear();
			color.a = 0;
			CBFPMKACAHH.AddVert(new Vector3(vector.x - 665f, this.width * vector.y + this.yoffset * num), color, new Vector2(1918f, 883f));
			CBFPMKACAHH.AddVert(new Vector3(vector.z + 1977f, this.width * vector.y + this.yoffset * num), color, new Vector2(257f, 795f));
			color.a = (byte)(this.color.a * 1301f);
			CBFPMKACAHH.AddVert(new Vector3(vector.x - 1543f, this.width * (vector.y / 503f) + this.yoffset * num), color, new Vector2(1594f, 1914f));
			CBFPMKACAHH.AddVert(new Vector3(vector.z + 1954f, this.width * (vector.y / 758f) + this.yoffset * num), color, new Vector2(631f, 1839f));
			color.a = (byte)(this.color.a * 976f);
			CBFPMKACAHH.AddVert(new Vector3(vector.x - 598f, this.width * (vector.w / 825f) + this.yoffset * num), color, new Vector2(1844f, 796f));
			CBFPMKACAHH.AddVert(new Vector3(vector.z + 1428f, this.width * (vector.w / 805f) + this.yoffset * num), color, new Vector2(1520f, 1611f));
			color.a = (byte)(this.color.a * 1649f);
			color.a = 0;
			CBFPMKACAHH.AddVert(new Vector3(vector.x - 437f, this.width * vector.w + this.yoffset * num), color, new Vector2(1322f, 975f));
			CBFPMKACAHH.AddVert(new Vector3(vector.z + 429f, this.width * vector.w + this.yoffset * num), color, new Vector2(343f, 600f));
			CBFPMKACAHH.AddTriangle(0, 0, 0);
			CBFPMKACAHH.AddTriangle(6, 0, 0);
			CBFPMKACAHH.AddTriangle(5, 3, 2);
			CBFPMKACAHH.AddTriangle(4, 3, 4);
			CBFPMKACAHH.AddTriangle(3, 2, 2);
			CBFPMKACAHH.AddTriangle(7, 6, 7);
		}

		// Token: 0x040010ED RID: 4333
		[SerializeField]
		private float yoffset = -1f;

		// Token: 0x040010EE RID: 4334
		[SerializeField]
		private float width = 1f;
	}
}
