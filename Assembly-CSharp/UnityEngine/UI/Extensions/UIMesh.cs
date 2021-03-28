using System;
using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200028E RID: 654
	[AddComponentMenu("UI/Extensions/Primitives/UI Mesh")]
	[RequireComponent(typeof(CanvasRenderer))]
	[ExecuteInEditMode]
	public class UIMesh : MaskableGraphic
	{
		// Token: 0x06009DB3 RID: 40371 RVA: 0x003A969C File Offset: 0x003A789C
		protected virtual void MDDCLKMECFH(VertexHelper CBFPMKACAHH)
		{
			Debug.Log(" ");
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.FillMesh(this.m_mesh);
			base.OnPopulateMesh(CBFPMKACAHH);
		}

		// Token: 0x06009DB4 RID: 40372 RVA: 0x003A96C1 File Offset: 0x003A78C1
		public Mesh BMDHKIBBEMB()
		{
			return this.m_mesh;
		}

		// Token: 0x06009DB5 RID: 40373 RVA: 0x003A96C9 File Offset: 0x003A78C9
		public void ELPAHJJJAHM(Mesh DPNHODJHGJL)
		{
			if (this.m_mesh == DPNHODJHGJL)
			{
				return;
			}
			this.m_mesh = DPNHODJHGJL;
			this.SetVerticesDirty();
			this.SetMaterialDirty();
		}

		// Token: 0x06009DB6 RID: 40374 RVA: 0x003A96C1 File Offset: 0x003A78C1
		public Mesh DNKAIHICELI()
		{
			return this.m_mesh;
		}

		// Token: 0x06009DB7 RID: 40375 RVA: 0x003A96F0 File Offset: 0x003A78F0
		protected virtual void NGKFJEFNJPC(VertexHelper CBFPMKACAHH)
		{
			Debug.Log("No Name");
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.FillMesh(this.m_mesh);
			base.OnPopulateMesh(CBFPMKACAHH);
		}

		// Token: 0x06009DB8 RID: 40376 RVA: 0x003A96C1 File Offset: 0x003A78C1
		public Mesh CCPJPNKICMA()
		{
			return this.m_mesh;
		}

		// Token: 0x06009DB9 RID: 40377 RVA: 0x003A9715 File Offset: 0x003A7915
		public List<Material> HMCPBBGFEED()
		{
			return this.m_materials;
		}

		// Token: 0x06009DBA RID: 40378 RVA: 0x003A96C9 File Offset: 0x003A78C9
		public void BEDFGFBBHFL(Mesh DPNHODJHGJL)
		{
			if (this.m_mesh == DPNHODJHGJL)
			{
				return;
			}
			this.m_mesh = DPNHODJHGJL;
			this.SetVerticesDirty();
			this.SetMaterialDirty();
		}

		// Token: 0x06009DBB RID: 40379 RVA: 0x003A9715 File Offset: 0x003A7915
		public List<Material> NJHJMOJOAHP()
		{
			return this.m_materials;
		}

		// Token: 0x06009DBC RID: 40380 RVA: 0x003A96C9 File Offset: 0x003A78C9
		public void CCNDEGHOGPE(Mesh DPNHODJHGJL)
		{
			if (this.m_mesh == DPNHODJHGJL)
			{
				return;
			}
			this.m_mesh = DPNHODJHGJL;
			this.SetVerticesDirty();
			this.SetMaterialDirty();
		}

		// Token: 0x06009DBD RID: 40381 RVA: 0x003A96C9 File Offset: 0x003A78C9
		public void MLLJLFPLCKJ(Mesh DPNHODJHGJL)
		{
			if (this.m_mesh == DPNHODJHGJL)
			{
				return;
			}
			this.m_mesh = DPNHODJHGJL;
			this.SetVerticesDirty();
			this.SetMaterialDirty();
		}

		// Token: 0x06009DBE RID: 40382 RVA: 0x003A971D File Offset: 0x003A791D
		protected virtual void OCGJOFMAJNP(VertexHelper CBFPMKACAHH)
		{
			Debug.Log("Chat");
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.FillMesh(this.m_mesh);
			base.OnPopulateMesh(CBFPMKACAHH);
		}

		// Token: 0x06009DBF RID: 40383 RVA: 0x003A9742 File Offset: 0x003A7942
		public void CDPLEDJJLOB(List<Material> DPNHODJHGJL)
		{
			if (this.m_materials == DPNHODJHGJL)
			{
				return;
			}
			this.m_materials = DPNHODJHGJL;
			this.SetVerticesDirty();
			this.SetMaterialDirty();
		}

		// Token: 0x06009DC0 RID: 40384 RVA: 0x003A96C9 File Offset: 0x003A78C9
		public void BGMKJFAPAEJ(Mesh DPNHODJHGJL)
		{
			if (this.m_mesh == DPNHODJHGJL)
			{
				return;
			}
			this.m_mesh = DPNHODJHGJL;
			this.SetVerticesDirty();
			this.SetMaterialDirty();
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06009DC1 RID: 40385 RVA: 0x003A9715 File Offset: 0x003A7915
		// (set) Token: 0x06009DDB RID: 40411 RVA: 0x003A9742 File Offset: 0x003A7942
		public List<Material> Materials
		{
			get
			{
				return this.m_materials;
			}
			set
			{
				if (this.m_materials == value)
				{
					return;
				}
				this.m_materials = value;
				this.SetVerticesDirty();
				this.SetMaterialDirty();
			}
		}

		// Token: 0x06009DC2 RID: 40386 RVA: 0x003A96C9 File Offset: 0x003A78C9
		public void FBBKPMAHPEB(Mesh DPNHODJHGJL)
		{
			if (this.m_mesh == DPNHODJHGJL)
			{
				return;
			}
			this.m_mesh = DPNHODJHGJL;
			this.SetVerticesDirty();
			this.SetMaterialDirty();
		}

		// Token: 0x06009DC3 RID: 40387 RVA: 0x003A96C9 File Offset: 0x003A78C9
		public void FEJEJKLDHPG(Mesh DPNHODJHGJL)
		{
			if (this.m_mesh == DPNHODJHGJL)
			{
				return;
			}
			this.m_mesh = DPNHODJHGJL;
			this.SetVerticesDirty();
			this.SetMaterialDirty();
		}

		// Token: 0x06009DC4 RID: 40388 RVA: 0x003A9715 File Offset: 0x003A7915
		public List<Material> GHJPPEFLIDL()
		{
			return this.m_materials;
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06009DC5 RID: 40389 RVA: 0x003A96C1 File Offset: 0x003A78C1
		// (set) Token: 0x06009DDF RID: 40415 RVA: 0x003A96C9 File Offset: 0x003A78C9
		public Mesh Mesh
		{
			get
			{
				return this.m_mesh;
			}
			set
			{
				if (this.m_mesh == value)
				{
					return;
				}
				this.m_mesh = value;
				this.SetVerticesDirty();
				this.SetMaterialDirty();
			}
		}

		// Token: 0x06009DC6 RID: 40390 RVA: 0x003A96C9 File Offset: 0x003A78C9
		public void DLIECCNKGKA(Mesh DPNHODJHGJL)
		{
			if (this.m_mesh == DPNHODJHGJL)
			{
				return;
			}
			this.m_mesh = DPNHODJHGJL;
			this.SetVerticesDirty();
			this.SetMaterialDirty();
		}

		// Token: 0x06009DC7 RID: 40391 RVA: 0x003A9715 File Offset: 0x003A7915
		public List<Material> MLGBNADACEM()
		{
			return this.m_materials;
		}

		// Token: 0x06009DC9 RID: 40393 RVA: 0x003A976C File Offset: 0x003A796C
		protected virtual void HLACFEJLMPL(VertexHelper CBFPMKACAHH)
		{
			Debug.Log("kick");
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.FillMesh(this.m_mesh);
			base.OnPopulateMesh(CBFPMKACAHH);
		}

		// Token: 0x06009DCA RID: 40394 RVA: 0x003A9742 File Offset: 0x003A7942
		public void GAHJIDOGGND(List<Material> DPNHODJHGJL)
		{
			if (this.m_materials == DPNHODJHGJL)
			{
				return;
			}
			this.m_materials = DPNHODJHGJL;
			this.SetVerticesDirty();
			this.SetMaterialDirty();
		}

		// Token: 0x06009DCB RID: 40395 RVA: 0x003A96C1 File Offset: 0x003A78C1
		public Mesh LCGBILOKKJC()
		{
			return this.m_mesh;
		}

		// Token: 0x06009DCC RID: 40396 RVA: 0x003A9715 File Offset: 0x003A7915
		public List<Material> BOKEGMMOLNF()
		{
			return this.m_materials;
		}

		// Token: 0x06009DCD RID: 40397 RVA: 0x003A9742 File Offset: 0x003A7942
		public void FHKNIMOHPCN(List<Material> DPNHODJHGJL)
		{
			if (this.m_materials == DPNHODJHGJL)
			{
				return;
			}
			this.m_materials = DPNHODJHGJL;
			this.SetVerticesDirty();
			this.SetMaterialDirty();
		}

		// Token: 0x06009DCE RID: 40398 RVA: 0x003A96C1 File Offset: 0x003A78C1
		public Mesh MFICBOBHHDH()
		{
			return this.m_mesh;
		}

		// Token: 0x06009DCF RID: 40399 RVA: 0x003A9742 File Offset: 0x003A7942
		public void FNEMEAEONMP(List<Material> DPNHODJHGJL)
		{
			if (this.m_materials == DPNHODJHGJL)
			{
				return;
			}
			this.m_materials = DPNHODJHGJL;
			this.SetVerticesDirty();
			this.SetMaterialDirty();
		}

		// Token: 0x06009DD0 RID: 40400 RVA: 0x003A96C1 File Offset: 0x003A78C1
		public Mesh EJDEEFPCFMN()
		{
			return this.m_mesh;
		}

		// Token: 0x06009DD1 RID: 40401 RVA: 0x003A96C1 File Offset: 0x003A78C1
		public Mesh NKDKGMMBAJP()
		{
			return this.m_mesh;
		}

		// Token: 0x06009DD2 RID: 40402 RVA: 0x003A9742 File Offset: 0x003A7942
		public void HIJLECCOBPP(List<Material> DPNHODJHGJL)
		{
			if (this.m_materials == DPNHODJHGJL)
			{
				return;
			}
			this.m_materials = DPNHODJHGJL;
			this.SetVerticesDirty();
			this.SetMaterialDirty();
		}

		// Token: 0x06009DD3 RID: 40403 RVA: 0x003A96C1 File Offset: 0x003A78C1
		public Mesh MFBMBGKKHFG()
		{
			return this.m_mesh;
		}

		// Token: 0x06009DD4 RID: 40404 RVA: 0x003A9791 File Offset: 0x003A7991
		protected virtual void LHGFMLDJBBA(VertexHelper CBFPMKACAHH)
		{
			Debug.Log("_Value5");
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.FillMesh(this.m_mesh);
			base.OnPopulateMesh(CBFPMKACAHH);
		}

		// Token: 0x06009DD5 RID: 40405 RVA: 0x003A9715 File Offset: 0x003A7915
		public List<Material> OAHMLIMDANB()
		{
			return this.m_materials;
		}

		// Token: 0x06009DD6 RID: 40406 RVA: 0x003A9715 File Offset: 0x003A7915
		public List<Material> FNBIGBNIGBA()
		{
			return this.m_materials;
		}

		// Token: 0x06009DD7 RID: 40407 RVA: 0x003A97B6 File Offset: 0x003A79B6
		protected virtual void HJFGAKFDGEH(VertexHelper CBFPMKACAHH)
		{
			Debug.Log("AppID: {0}*** GameVersion: {1} PeerId: {2} ");
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.FillMesh(this.m_mesh);
			base.OnPopulateMesh(CBFPMKACAHH);
		}

		// Token: 0x06009DD8 RID: 40408 RVA: 0x003A97DB File Offset: 0x003A79DB
		protected virtual void MGKBAMLHFBH(VertexHelper CBFPMKACAHH)
		{
			Debug.Log("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ");
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.FillMesh(this.m_mesh);
			base.OnPopulateMesh(CBFPMKACAHH);
		}

		// Token: 0x06009DD9 RID: 40409 RVA: 0x003A96C1 File Offset: 0x003A78C1
		public Mesh MHCLOMIPMNN()
		{
			return this.m_mesh;
		}

		// Token: 0x06009DDA RID: 40410 RVA: 0x003A96C9 File Offset: 0x003A78C9
		public void PLAIHACLOGG(Mesh DPNHODJHGJL)
		{
			if (this.m_mesh == DPNHODJHGJL)
			{
				return;
			}
			this.m_mesh = DPNHODJHGJL;
			this.SetVerticesDirty();
			this.SetMaterialDirty();
		}

		// Token: 0x06009DDC RID: 40412 RVA: 0x003A9800 File Offset: 0x003A7A00
		protected virtual void LMFBMHPKGJJ(VertexHelper CBFPMKACAHH)
		{
			Debug.Log("keep aspect ratio");
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.FillMesh(this.m_mesh);
			base.OnPopulateMesh(CBFPMKACAHH);
		}

		// Token: 0x06009DDD RID: 40413 RVA: 0x003A96C1 File Offset: 0x003A78C1
		public Mesh LJPCIHBBAIK()
		{
			return this.m_mesh;
		}

		// Token: 0x06009DDE RID: 40414 RVA: 0x003A9825 File Offset: 0x003A7A25
		protected override void OnPopulateMesh(VertexHelper CBFPMKACAHH)
		{
			Debug.Log("Populate Mesh Data");
			CBFPMKACAHH.Clear();
			CBFPMKACAHH.FillMesh(this.m_mesh);
			base.OnPopulateMesh(CBFPMKACAHH);
		}

		// Token: 0x06009DE0 RID: 40416 RVA: 0x003A9742 File Offset: 0x003A7942
		public void KPAHOBNGNFD(List<Material> DPNHODJHGJL)
		{
			if (this.m_materials == DPNHODJHGJL)
			{
				return;
			}
			this.m_materials = DPNHODJHGJL;
			this.SetVerticesDirty();
			this.SetMaterialDirty();
		}

		// Token: 0x04001204 RID: 4612
		[SerializeField]
		private Mesh m_mesh;

		// Token: 0x04001205 RID: 4613
		[SerializeField]
		private List<Material> m_materials;
	}
}
