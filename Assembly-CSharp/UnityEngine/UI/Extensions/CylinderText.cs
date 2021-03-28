using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000255 RID: 597
	[AddComponentMenu("UI/Effects/Extensions/Cylinder Text")]
	[RequireComponent(typeof(Text), typeof(RectTransform))]
	public class CylinderText : BaseMeshEffect
	{
		// Token: 0x06009044 RID: 36932 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void AONJNAGNLIH()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009045 RID: 36933 RVA: 0x00320C60 File Offset: 0x0031EE60
		public virtual void CNMPIMEFDLO(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 0; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06009046 RID: 36934 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void GENKFCNHBLH()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009047 RID: 36935 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void JBBCMAJIMCA()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009048 RID: 36936 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void IDKPHKOCOLD()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009049 RID: 36937 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected override void OnEnable()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600904A RID: 36938 RVA: 0x00320D10 File Offset: 0x0031EF10
		public virtual void IPOJGOGGENA(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x0600904B RID: 36939 RVA: 0x00320DC0 File Offset: 0x0031EFC0
		public virtual void EOMJHBJNIEF(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x0600904C RID: 36940 RVA: 0x00320E70 File Offset: 0x0031F070
		public virtual void DOJEEHLHEIJ(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x0600904D RID: 36941 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void MLPCIDDEIDC()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600904E RID: 36942 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void EBBOJPEPDCN()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600904F RID: 36943 RVA: 0x00320F30 File Offset: 0x0031F130
		public virtual void BDEPCEGMHLF(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 0; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06009050 RID: 36944 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void JPJNECPABBG()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009051 RID: 36945 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void GEPELODHBFN()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009052 RID: 36946 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void MBNMADBPDLL()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009053 RID: 36947 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void OJACCGOHBGH()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009054 RID: 36948 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void LKPBGHGCPKL()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009055 RID: 36949 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void BODPLDJLFCF()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009056 RID: 36950 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void DEJEBOGKMJO()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009057 RID: 36951 RVA: 0x00320FE0 File Offset: 0x0031F1E0
		public virtual void GMJHCGHOCGN(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 0; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06009058 RID: 36952 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void GCDNONIKKLI()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009059 RID: 36953 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void KCGJMAFGAGH()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600905A RID: 36954 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void KAMMKPFNJJF()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600905B RID: 36955 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void JCDPMLPNOOC()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600905C RID: 36956 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void GDHMJGBAGHP()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600905D RID: 36957 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void PGGNGAMLGAJ()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600905E RID: 36958 RVA: 0x00321090 File Offset: 0x0031F290
		public virtual void IDPADEBHCFF(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x0600905F RID: 36959 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void EMAMCDFBGOA()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009060 RID: 36960 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void EPCGHAAONLN()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009061 RID: 36961 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void AENGMPAMCFL()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009062 RID: 36962 RVA: 0x00321140 File Offset: 0x0031F340
		public virtual void IBNDMHJKIKL(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 0; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06009063 RID: 36963 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void FKDHFNCOKAK()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009064 RID: 36964 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void IOMCHHBGJEC()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009065 RID: 36965 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void CEKLAECJCKG()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009066 RID: 36966 RVA: 0x003211F0 File Offset: 0x0031F3F0
		public virtual void FIHMPODAHAI(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06009067 RID: 36967 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void CJHMHIMKILB()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009068 RID: 36968 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void OKHGJFFIIBA()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009069 RID: 36969 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void OLFNCABJBHA()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600906A RID: 36970 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void HIDOPHINPAL()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600906B RID: 36971 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void OLAGABIMGDA()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600906C RID: 36972 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void OAKONCDEPPI()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600906D RID: 36973 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void GBNOIKAPBBO()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600906E RID: 36974 RVA: 0x003212A0 File Offset: 0x0031F4A0
		public virtual void NNHKCEECOFI(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x0600906F RID: 36975 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void IIPMEPPIFCK()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009070 RID: 36976 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void OCHCKGMIDND()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009071 RID: 36977 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void CCDNJPNLGBN()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009072 RID: 36978 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void NLGDPIBFHMK()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009073 RID: 36979 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void NGEGCLCPPCD()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009074 RID: 36980 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void IGCJMAADPGG()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009075 RID: 36981 RVA: 0x00321350 File Offset: 0x0031F550
		public virtual void IELBOBHIMEJ(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06009076 RID: 36982 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void HKDMCBDOGDK()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009078 RID: 36984 RVA: 0x00321408 File Offset: 0x0031F608
		public virtual void PDLDLOFJFCL(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 0; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06009079 RID: 36985 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void KFCCKOBOLAH()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600907A RID: 36986 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void GLNBNEJBMHA()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600907B RID: 36987 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void OOHJBHLKGDJ()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600907C RID: 36988 RVA: 0x003214B8 File Offset: 0x0031F6B8
		public virtual void DAGEAMDJGPF(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x0600907D RID: 36989 RVA: 0x00321568 File Offset: 0x0031F768
		public virtual void MAIMGKEAMDN(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x0600907E RID: 36990 RVA: 0x00321618 File Offset: 0x0031F818
		public virtual void CLGGKMDIFDN(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x0600907F RID: 36991 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void MEJPBKFMAIG()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009080 RID: 36992 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void PPGKBEJLBFJ()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009081 RID: 36993 RVA: 0x003216C8 File Offset: 0x0031F8C8
		public virtual void KKPHLABENOG(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06009082 RID: 36994 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void GOBHPAJFFDB()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009083 RID: 36995 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void LLMECKIHEIC()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009084 RID: 36996 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void EMKLCPGKNJL()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009085 RID: 36997 RVA: 0x00321778 File Offset: 0x0031F978
		public virtual void JEMLLFGOENC(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06009086 RID: 36998 RVA: 0x00321828 File Offset: 0x0031FA28
		public virtual void FMPHNLLGFLK(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 0; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06009087 RID: 36999 RVA: 0x003218D8 File Offset: 0x0031FAD8
		public virtual void HOLPPNEFBCC(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 0; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06009088 RID: 37000 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void EANDKCPHLJO()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009089 RID: 37001 RVA: 0x00321988 File Offset: 0x0031FB88
		public virtual void KEHEEJOPLJM(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 0; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x0600908A RID: 37002 RVA: 0x00321A38 File Offset: 0x0031FC38
		public virtual void KEAEPLNFKEN(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x0600908B RID: 37003 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void HOLDCFBBHHP()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600908C RID: 37004 RVA: 0x00321AE8 File Offset: 0x0031FCE8
		public virtual void BKCKCFPNHEB(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x0600908D RID: 37005 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void EIFCCFBJKOO()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600908E RID: 37006 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void DGEPPDJDBLN()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600908F RID: 37007 RVA: 0x00321B98 File Offset: 0x0031FD98
		public virtual void KEIICKGMOAD(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06009090 RID: 37008 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void BFFHPJMMGHD()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009091 RID: 37009 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void IFBKMAEMKNN()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009092 RID: 37010 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void DLOAJEFNKDA()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009093 RID: 37011 RVA: 0x00321C48 File Offset: 0x0031FE48
		public virtual void EMGDPPOCBGG(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06009094 RID: 37012 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void JOLKPPEBILA()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009095 RID: 37013 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void HFCJHNPGKEG()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009096 RID: 37014 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void MCKOAMFEDGL()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009097 RID: 37015 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void OLDNINDEIKO()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009098 RID: 37016 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void BANHFNDEPPO()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009099 RID: 37017 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void HJDPEBAPBPN()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600909A RID: 37018 RVA: 0x00321CF8 File Offset: 0x0031FEF8
		public virtual void GLHAFOLFIFB(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x0600909B RID: 37019 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void PHHOMLJECOJ()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600909C RID: 37020 RVA: 0x00321DA8 File Offset: 0x0031FFA8
		public virtual void ELCEINLAGNM(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 0; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x0600909D RID: 37021 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void PMBIKIBOHOF()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600909E RID: 37022 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void LICOLMAOHKI()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600909F RID: 37023 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void LLDBPKHDPKI()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x060090A0 RID: 37024 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void LJEFMGOBKGE()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x060090A1 RID: 37025 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void NEEIFNDHDOG()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x060090A2 RID: 37026 RVA: 0x00321E58 File Offset: 0x00320058
		public virtual void BOIMCFPNCIM(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x060090A3 RID: 37027 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void LFFAKAOAOCN()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x060090A4 RID: 37028 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void HGIMCCHIPCP()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x060090A5 RID: 37029 RVA: 0x00321F08 File Offset: 0x00320108
		public virtual void ABPDFCPPHCF(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 0; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x060090A6 RID: 37030 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void JNIPABEGJND()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x060090A7 RID: 37031 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void CIAHIJIOFIE()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x060090A8 RID: 37032 RVA: 0x00321FB8 File Offset: 0x003201B8
		public virtual void FHLOBLDHKDF(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 0; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x060090A9 RID: 37033 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void NCBGPIKDFIA()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x060090AA RID: 37034 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void EAIPPDOABCG()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x060090AB RID: 37035 RVA: 0x00322068 File Offset: 0x00320268
		public virtual void GPHCNKNDMEB(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 0; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x060090AC RID: 37036 RVA: 0x00322118 File Offset: 0x00320318
		public virtual void ALALBLHBAAF(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 0; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x060090AD RID: 37037 RVA: 0x003221C8 File Offset: 0x003203C8
		public override void ModifyMesh(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 0; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x060090AE RID: 37038 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void CFMJMJOHJII()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x060090AF RID: 37039 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void AALONHDMCKO()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x060090B0 RID: 37040 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void MMPOJCFOGJJ()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x060090B1 RID: 37041 RVA: 0x00322278 File Offset: 0x00320478
		public virtual void BGOGDBBMDJL(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x060090B2 RID: 37042 RVA: 0x00322328 File Offset: 0x00320528
		public virtual void HBKNHPFDFBF(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x060090B3 RID: 37043 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void MCIEAOAMOIG()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x060090B4 RID: 37044 RVA: 0x003223D8 File Offset: 0x003205D8
		public virtual void IBPNPILOAGI(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x060090B5 RID: 37045 RVA: 0x00320F20 File Offset: 0x0031F120
		protected override void Awake()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x060090B6 RID: 37046 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void ICPOEGIAFBL()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x060090B7 RID: 37047 RVA: 0x00322488 File Offset: 0x00320688
		public virtual void EGKEHGHCJAH(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 0; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x060090B8 RID: 37048 RVA: 0x00322538 File Offset: 0x00320738
		public virtual void ALCKKMEADND(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x060090B9 RID: 37049 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void KEGNPKFMPDG()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x060090BA RID: 37050 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void FNMPIAMIKCP()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x060090BB RID: 37051 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void GEGFJJBCHPE()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x060090BC RID: 37052 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void PLIPIMPKNLO()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x060090BD RID: 37053 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void ENDDDMALLBK()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x060090BE RID: 37054 RVA: 0x003225E8 File Offset: 0x003207E8
		public virtual void KDBELKEEKPC(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x060090BF RID: 37055 RVA: 0x00322698 File Offset: 0x00320898
		public virtual void AGPCDJEMEDF(VertexHelper CBFPMKACAHH)
		{
			if (!this.IsActive())
			{
				return;
			}
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				float x = vertex.position.x;
				vertex.position.z = -this.radius * Mathf.Cos(x / this.radius);
				vertex.position.x = this.radius * Mathf.Sin(x / this.radius);
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x060090C0 RID: 37056 RVA: 0x00320C50 File Offset: 0x0031EE50
		protected virtual void BBLEPIHAEJJ()
		{
			base.OnEnable();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x060090C1 RID: 37057 RVA: 0x00320F20 File Offset: 0x0031F120
		protected virtual void JIJPHEDDIHC()
		{
			base.Awake();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x04001096 RID: 4246
		public float radius;
	}
}
