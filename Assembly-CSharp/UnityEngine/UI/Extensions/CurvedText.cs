using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000254 RID: 596
	[RequireComponent(typeof(Text), typeof(RectTransform))]
	[AddComponentMenu("UI/Effects/Extensions/Curved Text")]
	public class CurvedText : BaseMeshEffect
	{
		// Token: 0x06008FD9 RID: 36825 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void GEGFJJBCHPE()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06008FDA RID: 36826 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void JBIFKBNPHJE()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06008FDB RID: 36827 RVA: 0x0031F542 File Offset: 0x0031D742
		protected virtual void OCHCKGMIDND()
		{
			base.OnEnable();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06008FDC RID: 36828 RVA: 0x0031F55C File Offset: 0x0031D75C
		public virtual void JGDAINEKCFE(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				vertex.position.y = vertex.position.y + this.curveForText.Evaluate(this.NGDGELNAOIA.rect.width * this.NGDGELNAOIA.pivot.x + vertex.position.x) * this.curveMultiplier;
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06008FDD RID: 36829 RVA: 0x0031F60C File Offset: 0x0031D80C
		protected virtual void PGPGMANBLKG()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 0];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 1, key);
		}

		// Token: 0x06008FDE RID: 36830 RVA: 0x0031F528 File Offset: 0x0031D728
		protected override void Awake()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06008FE0 RID: 36832 RVA: 0x0031F698 File Offset: 0x0031D898
		protected override void OnRectTransformDimensionsChange()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 1];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 1, key);
		}

		// Token: 0x06008FE1 RID: 36833 RVA: 0x0031F6F4 File Offset: 0x0031D8F4
		public virtual void BGOGDBBMDJL(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				vertex.position.y = vertex.position.y + this.curveForText.Evaluate(this.NGDGELNAOIA.rect.width * this.NGDGELNAOIA.pivot.x + vertex.position.x) * this.curveMultiplier;
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06008FE2 RID: 36834 RVA: 0x0031F7A4 File Offset: 0x0031D9A4
		protected virtual void MLOFGPHHBJG()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 1];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 0, key);
		}

		// Token: 0x06008FE3 RID: 36835 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void OBAIHNFOJGN()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06008FE4 RID: 36836 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void PPGKBEJLBFJ()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06008FE5 RID: 36837 RVA: 0x0031F542 File Offset: 0x0031D742
		protected virtual void HJDPEBAPBPN()
		{
			base.OnEnable();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06008FE6 RID: 36838 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void GDHMJGBAGHP()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06008FE7 RID: 36839 RVA: 0x0031F542 File Offset: 0x0031D742
		protected override void OnEnable()
		{
			base.OnEnable();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06008FE8 RID: 36840 RVA: 0x0031F800 File Offset: 0x0031DA00
		protected virtual void AJJILMFCEIB()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 1];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 1, key);
		}

		// Token: 0x06008FE9 RID: 36841 RVA: 0x0031F85C File Offset: 0x0031DA5C
		protected virtual void NFNAHPGEJBE()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 1];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 1, key);
		}

		// Token: 0x06008FEA RID: 36842 RVA: 0x0031F542 File Offset: 0x0031D742
		protected virtual void HGJKBDGABKM()
		{
			base.OnEnable();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06008FEB RID: 36843 RVA: 0x0031F8B8 File Offset: 0x0031DAB8
		protected virtual void BKPGLBNLBPJ()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 1];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 0, key);
		}

		// Token: 0x06008FEC RID: 36844 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void DAHIMKKFNPH()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06008FED RID: 36845 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void GEPELODHBFN()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06008FEE RID: 36846 RVA: 0x0031F914 File Offset: 0x0031DB14
		public virtual void FIHMPODAHAI(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				vertex.position.y = vertex.position.y + this.curveForText.Evaluate(this.NGDGELNAOIA.rect.width * this.NGDGELNAOIA.pivot.x + vertex.position.x) * this.curveMultiplier;
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06008FEF RID: 36847 RVA: 0x0031F542 File Offset: 0x0031D742
		protected virtual void IFBPAGFGDGD()
		{
			base.OnEnable();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06008FF0 RID: 36848 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void JOBBGDGHJMB()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06008FF1 RID: 36849 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void JNBMKLFJCEM()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06008FF2 RID: 36850 RVA: 0x0031F542 File Offset: 0x0031D742
		protected virtual void JCDPMLPNOOC()
		{
			base.OnEnable();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06008FF3 RID: 36851 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void OLFNCABJBHA()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06008FF4 RID: 36852 RVA: 0x0031F542 File Offset: 0x0031D742
		protected virtual void LOLHKNKBNPF()
		{
			base.OnEnable();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06008FF5 RID: 36853 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void EPCGHAAONLN()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06008FF6 RID: 36854 RVA: 0x0031F9C4 File Offset: 0x0031DBC4
		protected virtual void LOHECANOCOC()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 1];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 1, key);
		}

		// Token: 0x06008FF7 RID: 36855 RVA: 0x0031FA20 File Offset: 0x0031DC20
		public virtual void GOPKLFDEAJF(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				vertex.position.y = vertex.position.y + this.curveForText.Evaluate(this.NGDGELNAOIA.rect.width * this.NGDGELNAOIA.pivot.x + vertex.position.x) * this.curveMultiplier;
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06008FF8 RID: 36856 RVA: 0x0031FAD0 File Offset: 0x0031DCD0
		public virtual void LPDPCKEDJDG(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				vertex.position.y = vertex.position.y + this.curveForText.Evaluate(this.NGDGELNAOIA.rect.width * this.NGDGELNAOIA.pivot.x + vertex.position.x) * this.curveMultiplier;
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06008FF9 RID: 36857 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void JNIPABEGJND()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06008FFA RID: 36858 RVA: 0x0031FB80 File Offset: 0x0031DD80
		protected virtual void DAAOBKPDKCH()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 1];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 1, key);
		}

		// Token: 0x06008FFB RID: 36859 RVA: 0x0031FBDC File Offset: 0x0031DDDC
		public virtual void GPHCNKNDMEB(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 0; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				vertex.position.y = vertex.position.y + this.curveForText.Evaluate(this.NGDGELNAOIA.rect.width * this.NGDGELNAOIA.pivot.x + vertex.position.x) * this.curveMultiplier;
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06008FFC RID: 36860 RVA: 0x0031FC8C File Offset: 0x0031DE8C
		public override void ModifyMesh(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 0; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				vertex.position.y = vertex.position.y + this.curveForText.Evaluate(this.NGDGELNAOIA.rect.width * this.NGDGELNAOIA.pivot.x + vertex.position.x) * this.curveMultiplier;
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06008FFD RID: 36861 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void HBPLJMJAAHK()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06008FFE RID: 36862 RVA: 0x0031F542 File Offset: 0x0031D742
		protected virtual void FDIJLKIIMLL()
		{
			base.OnEnable();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06008FFF RID: 36863 RVA: 0x0031F542 File Offset: 0x0031D742
		protected virtual void IGHJDBJAFPM()
		{
			base.OnEnable();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009000 RID: 36864 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void KEGNPKFMPDG()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009001 RID: 36865 RVA: 0x0031F542 File Offset: 0x0031D742
		protected virtual void IJCBBIJOCAH()
		{
			base.OnEnable();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009002 RID: 36866 RVA: 0x0031F542 File Offset: 0x0031D742
		protected virtual void CNHEENCFCMF()
		{
			base.OnEnable();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009003 RID: 36867 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void BFFHPJMMGHD()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009004 RID: 36868 RVA: 0x0031F542 File Offset: 0x0031D742
		protected virtual void LICOLMAOHKI()
		{
			base.OnEnable();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009005 RID: 36869 RVA: 0x0031FD3C File Offset: 0x0031DF3C
		protected virtual void LCKMPCPFPOG()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 1];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 0, key);
		}

		// Token: 0x06009006 RID: 36870 RVA: 0x0031F542 File Offset: 0x0031D742
		protected virtual void OAKONCDEPPI()
		{
			base.OnEnable();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009007 RID: 36871 RVA: 0x0031FD98 File Offset: 0x0031DF98
		protected virtual void EIFKLADCOLL()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 0];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 1, key);
		}

		// Token: 0x06009008 RID: 36872 RVA: 0x0031F542 File Offset: 0x0031D742
		protected virtual void GLKJFIOCPLF()
		{
			base.OnEnable();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009009 RID: 36873 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void OKADMJFLMGP()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600900A RID: 36874 RVA: 0x0031FDF4 File Offset: 0x0031DFF4
		public virtual void IDPADEBHCFF(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				vertex.position.y = vertex.position.y + this.curveForText.Evaluate(this.NGDGELNAOIA.rect.width * this.NGDGELNAOIA.pivot.x + vertex.position.x) * this.curveMultiplier;
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x0600900B RID: 36875 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void BMAGFLLGDPJ()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600900C RID: 36876 RVA: 0x0031FEA4 File Offset: 0x0031E0A4
		public virtual void IBNDMHJKIKL(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 0; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				vertex.position.y = vertex.position.y + this.curveForText.Evaluate(this.NGDGELNAOIA.rect.width * this.NGDGELNAOIA.pivot.x + vertex.position.x) * this.curveMultiplier;
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x0600900D RID: 36877 RVA: 0x0031F542 File Offset: 0x0031D742
		protected virtual void OOBIMFILNED()
		{
			base.OnEnable();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600900E RID: 36878 RVA: 0x0031FF54 File Offset: 0x0031E154
		protected virtual void JLPJMJIIGFJ()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 0];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 0, key);
		}

		// Token: 0x0600900F RID: 36879 RVA: 0x0031F542 File Offset: 0x0031D742
		protected virtual void AENIGCONKBD()
		{
			base.OnEnable();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009010 RID: 36880 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void ELJPNLNELIE()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009011 RID: 36881 RVA: 0x0031FFB0 File Offset: 0x0031E1B0
		protected virtual void LMAIEFGBLFG()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 0];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 0, key);
		}

		// Token: 0x06009012 RID: 36882 RVA: 0x0032000C File Offset: 0x0031E20C
		public virtual void KEHEEJOPLJM(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				vertex.position.y = vertex.position.y + this.curveForText.Evaluate(this.NGDGELNAOIA.rect.width * this.NGDGELNAOIA.pivot.x + vertex.position.x) * this.curveMultiplier;
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06009013 RID: 36883 RVA: 0x003200BC File Offset: 0x0031E2BC
		public virtual void KMBFMAKKPKG(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				vertex.position.y = vertex.position.y + this.curveForText.Evaluate(this.NGDGELNAOIA.rect.width * this.NGDGELNAOIA.pivot.x + vertex.position.x) * this.curveMultiplier;
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06009014 RID: 36884 RVA: 0x0031F542 File Offset: 0x0031D742
		protected virtual void IBFHEDHJDLH()
		{
			base.OnEnable();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009015 RID: 36885 RVA: 0x0032016C File Offset: 0x0031E36C
		protected virtual void CFECMNOAGJK()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 0];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 0, key);
		}

		// Token: 0x06009016 RID: 36886 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void MMPPGDECEHO()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009017 RID: 36887 RVA: 0x0031F542 File Offset: 0x0031D742
		protected virtual void EBBOJPEPDCN()
		{
			base.OnEnable();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009018 RID: 36888 RVA: 0x003201C8 File Offset: 0x0031E3C8
		public virtual void PGOGAJDENHE(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 0; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				vertex.position.y = vertex.position.y + this.curveForText.Evaluate(this.NGDGELNAOIA.rect.width * this.NGDGELNAOIA.pivot.x + vertex.position.x) * this.curveMultiplier;
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06009019 RID: 36889 RVA: 0x00320278 File Offset: 0x0031E478
		public virtual void OKDCDMHEALB(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				vertex.position.y = vertex.position.y + this.curveForText.Evaluate(this.NGDGELNAOIA.rect.width * this.NGDGELNAOIA.pivot.x + vertex.position.x) * this.curveMultiplier;
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x0600901A RID: 36890 RVA: 0x00320328 File Offset: 0x0031E528
		protected virtual void FCEDHFADANA()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 0];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 0, key);
		}

		// Token: 0x0600901B RID: 36891 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void FIABIKEIEKH()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600901C RID: 36892 RVA: 0x0031F542 File Offset: 0x0031D742
		protected virtual void HENBNNAGIKN()
		{
			base.OnEnable();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600901D RID: 36893 RVA: 0x00320384 File Offset: 0x0031E584
		protected virtual void OKCNBAKPBBN()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 0];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 0, key);
		}

		// Token: 0x0600901E RID: 36894 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void MADENBGHKDD()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600901F RID: 36895 RVA: 0x0031F542 File Offset: 0x0031D742
		protected virtual void JPPGIKCKFJL()
		{
			base.OnEnable();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009020 RID: 36896 RVA: 0x0031F542 File Offset: 0x0031D742
		protected virtual void MLLPGPANCHI()
		{
			base.OnEnable();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009021 RID: 36897 RVA: 0x003203E0 File Offset: 0x0031E5E0
		protected virtual void DFILHBCHFLC()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 0];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 0, key);
		}

		// Token: 0x06009022 RID: 36898 RVA: 0x0032043C File Offset: 0x0031E63C
		protected virtual void KPJNOPGPEIA()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 0];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 0, key);
		}

		// Token: 0x06009023 RID: 36899 RVA: 0x00320498 File Offset: 0x0031E698
		public virtual void HACHAIHJHBN(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				vertex.position.y = vertex.position.y + this.curveForText.Evaluate(this.NGDGELNAOIA.rect.width * this.NGDGELNAOIA.pivot.x + vertex.position.x) * this.curveMultiplier;
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06009024 RID: 36900 RVA: 0x00320548 File Offset: 0x0031E748
		protected virtual void HIIKOPEHEDE()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 1];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 1, key);
		}

		// Token: 0x06009025 RID: 36901 RVA: 0x003205A4 File Offset: 0x0031E7A4
		protected virtual void HJPPCOPLPEJ()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 1];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 0, key);
		}

		// Token: 0x06009026 RID: 36902 RVA: 0x00320600 File Offset: 0x0031E800
		protected virtual void JJBIOFBEAEM()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 1];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 1, key);
		}

		// Token: 0x06009027 RID: 36903 RVA: 0x0031F542 File Offset: 0x0031D742
		protected virtual void JBBCMAJIMCA()
		{
			base.OnEnable();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009028 RID: 36904 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void MFIMFMCMADK()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009029 RID: 36905 RVA: 0x0032065C File Offset: 0x0031E85C
		protected virtual void KENFINMCKJL()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 0];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 0, key);
		}

		// Token: 0x0600902A RID: 36906 RVA: 0x003206B8 File Offset: 0x0031E8B8
		public virtual void KKPHLABENOG(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 0; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				vertex.position.y = vertex.position.y + this.curveForText.Evaluate(this.NGDGELNAOIA.rect.width * this.NGDGELNAOIA.pivot.x + vertex.position.x) * this.curveMultiplier;
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x0600902B RID: 36907 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void HCCMANDFEPL()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600902C RID: 36908 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void HKKLLDHKBMI()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600902D RID: 36909 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void POHMFMNEPKK()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600902E RID: 36910 RVA: 0x00320768 File Offset: 0x0031E968
		public virtual void MAABDFLDMPK(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				vertex.position.y = vertex.position.y + this.curveForText.Evaluate(this.NGDGELNAOIA.rect.width * this.NGDGELNAOIA.pivot.x + vertex.position.x) * this.curveMultiplier;
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x0600902F RID: 36911 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void OJBFBLHIEBB()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009030 RID: 36912 RVA: 0x00320818 File Offset: 0x0031EA18
		protected virtual void JBEFJNAKHMM()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 0];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 1, key);
		}

		// Token: 0x06009031 RID: 36913 RVA: 0x00320874 File Offset: 0x0031EA74
		public virtual void OBJEKCHNNCB(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				vertex.position.y = vertex.position.y + this.curveForText.Evaluate(this.NGDGELNAOIA.rect.width * this.NGDGELNAOIA.pivot.x + vertex.position.x) * this.curveMultiplier;
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06009032 RID: 36914 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void LBOBAIGNOML()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009033 RID: 36915 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void BHCCNFJKGPD()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009034 RID: 36916 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void PPCGJBIIFAO()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009035 RID: 36917 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void CEKLAECJCKG()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009036 RID: 36918 RVA: 0x0031F542 File Offset: 0x0031D742
		protected virtual void PPGEGFMNIKO()
		{
			base.OnEnable();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009037 RID: 36919 RVA: 0x00320924 File Offset: 0x0031EB24
		protected virtual void BIBENJGFLKA()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 0];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 1, key);
		}

		// Token: 0x06009038 RID: 36920 RVA: 0x00320980 File Offset: 0x0031EB80
		protected virtual void KHPEGOFAGMN()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 0];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 0, key);
		}

		// Token: 0x06009039 RID: 36921 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void NLNAJMCBNDC()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600903A RID: 36922 RVA: 0x003209DC File Offset: 0x0031EBDC
		public virtual void IGNHHIFIHFN(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 0; i < CBFPMKACAHH.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				vertex.position.y = vertex.position.y + this.curveForText.Evaluate(this.NGDGELNAOIA.rect.width * this.NGDGELNAOIA.pivot.x + vertex.position.x) * this.curveMultiplier;
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x0600903B RID: 36923 RVA: 0x0031F542 File Offset: 0x0031D742
		protected virtual void HMEBAIBJPCI()
		{
			base.OnEnable();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600903C RID: 36924 RVA: 0x00320A8C File Offset: 0x0031EC8C
		protected virtual void OELBOCPIMMB()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 0];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 1, key);
		}

		// Token: 0x0600903D RID: 36925 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void JIJPHEDDIHC()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600903E RID: 36926 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void FKDHFNCOKAK()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x0600903F RID: 36927 RVA: 0x00320AE8 File Offset: 0x0031ECE8
		protected virtual void CINCDGNOKCH()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 1];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 0, key);
		}

		// Token: 0x06009040 RID: 36928 RVA: 0x00320B44 File Offset: 0x0031ED44
		protected virtual void AANHAJBNOFL()
		{
			Keyframe key = this.curveForText[this.curveForText.length - 1];
			key.time = this.NGDGELNAOIA.rect.width;
			this.curveForText.MoveKey(this.curveForText.length - 1, key);
		}

		// Token: 0x06009041 RID: 36929 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void IOMCHHBGJEC()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x06009042 RID: 36930 RVA: 0x00320BA0 File Offset: 0x0031EDA0
		public virtual void KOCNFONLNCF(VertexHelper CBFPMKACAHH)
		{
			int currentVertCount = CBFPMKACAHH.currentVertCount;
			if (!this.IsActive() || currentVertCount == 0)
			{
				return;
			}
			for (int i = 1; i < CBFPMKACAHH.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				CBFPMKACAHH.PopulateUIVertex(ref vertex, i);
				vertex.position.y = vertex.position.y + this.curveForText.Evaluate(this.NGDGELNAOIA.rect.width * this.NGDGELNAOIA.pivot.x + vertex.position.x) * this.curveMultiplier;
				CBFPMKACAHH.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06009043 RID: 36931 RVA: 0x0031F528 File Offset: 0x0031D728
		protected virtual void FOMCIHEDIHI()
		{
			base.Awake();
			this.NGDGELNAOIA = base.GetComponent<RectTransform>();
			this.OnRectTransformDimensionsChange();
		}

		// Token: 0x04001093 RID: 4243
		public AnimationCurve curveForText = AnimationCurve.Linear(0f, 0f, 1f, 10f);

		// Token: 0x04001094 RID: 4244
		public float curveMultiplier = 1f;

		// Token: 0x04001095 RID: 4245
		private RectTransform NGDGELNAOIA;
	}
}
