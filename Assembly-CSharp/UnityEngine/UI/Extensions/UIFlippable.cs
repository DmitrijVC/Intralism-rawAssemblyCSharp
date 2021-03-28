using System;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x0200026E RID: 622
	[DisallowMultipleComponent]
	[AddComponentMenu("UI/Effects/Extensions/Flippable")]
	[RequireComponent(typeof(RectTransform), typeof(Graphic))]
	public class UIFlippable : MonoBehaviour, IMeshModifier
	{
		// Token: 0x0600953A RID: 38202 RVA: 0x00352923 File Offset: 0x00350B23
		public void IAGNKHOHGIC(bool DPNHODJHGJL)
		{
			this.m_Horizontal = DPNHODJHGJL;
		}

		// Token: 0x0600953B RID: 38203 RVA: 0x0035292C File Offset: 0x00350B2C
		public void GOJOGPBDHIN(bool DPNHODJHGJL)
		{
			this.m_Veritical = DPNHODJHGJL;
		}

		// Token: 0x0600953C RID: 38204 RVA: 0x00352935 File Offset: 0x00350B35
		public bool GIGENJHFBJE()
		{
			return this.m_Veritical;
		}

		// Token: 0x0600953D RID: 38205 RVA: 0x0035292C File Offset: 0x00350B2C
		public void BCAFABEMLFE(bool DPNHODJHGJL)
		{
			this.m_Veritical = DPNHODJHGJL;
		}

		// Token: 0x0600953E RID: 38206 RVA: 0x0035293D File Offset: 0x00350B3D
		protected void ACBAHLCGNDD()
		{
			base.GetComponent<Graphic>().SetVerticesDirty();
		}

		// Token: 0x0600953F RID: 38207 RVA: 0x0035294A File Offset: 0x00350B4A
		public bool OMKHPCDOIML()
		{
			return this.m_Horizontal;
		}

		// Token: 0x06009540 RID: 38208 RVA: 0x0035294A File Offset: 0x00350B4A
		public bool FGPCNEBNEOM()
		{
			return this.m_Horizontal;
		}

		// Token: 0x06009541 RID: 38209 RVA: 0x0035294A File Offset: 0x00350B4A
		public bool HMEFCMPEAGK()
		{
			return this.m_Horizontal;
		}

		// Token: 0x06009542 RID: 38210 RVA: 0x0035293D File Offset: 0x00350B3D
		protected void OKHOILMFOEE()
		{
			base.GetComponent<Graphic>().SetVerticesDirty();
		}

		// Token: 0x06009543 RID: 38211 RVA: 0x00352923 File Offset: 0x00350B23
		public void DLHCFHEKCHM(bool DPNHODJHGJL)
		{
			this.m_Horizontal = DPNHODJHGJL;
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x06009544 RID: 38212 RVA: 0x00352935 File Offset: 0x00350B35
		// (set) Token: 0x060095B9 RID: 38329 RVA: 0x0035292C File Offset: 0x00350B2C
		public bool vertical
		{
			get
			{
				return this.m_Veritical;
			}
			set
			{
				this.m_Veritical = value;
			}
		}

		// Token: 0x06009545 RID: 38213 RVA: 0x00352923 File Offset: 0x00350B23
		public void OKGCIOFCJMM(bool DPNHODJHGJL)
		{
			this.m_Horizontal = DPNHODJHGJL;
		}

		// Token: 0x06009546 RID: 38214 RVA: 0x00352935 File Offset: 0x00350B35
		public bool HGMOCBHMEOI()
		{
			return this.m_Veritical;
		}

		// Token: 0x06009547 RID: 38215 RVA: 0x0035293D File Offset: 0x00350B3D
		protected void FELENDJEOGA()
		{
			base.GetComponent<Graphic>().SetVerticesDirty();
		}

		// Token: 0x06009548 RID: 38216 RVA: 0x00352935 File Offset: 0x00350B35
		public bool KAJHNAGMKIK()
		{
			return this.m_Veritical;
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x06009552 RID: 38226 RVA: 0x0035294A File Offset: 0x00350B4A
		// (set) Token: 0x06009549 RID: 38217 RVA: 0x00352923 File Offset: 0x00350B23
		public bool horizontal
		{
			get
			{
				return this.m_Horizontal;
			}
			set
			{
				this.m_Horizontal = value;
			}
		}

		// Token: 0x0600954A RID: 38218 RVA: 0x00352923 File Offset: 0x00350B23
		public void GDLNLBCFDLG(bool DPNHODJHGJL)
		{
			this.m_Horizontal = DPNHODJHGJL;
		}

		// Token: 0x0600954B RID: 38219 RVA: 0x0002523B File Offset: 0x0002343B
		public void JNGINIFJICP(Mesh PIPLEPOKNEF)
		{
		}

		// Token: 0x0600954C RID: 38220 RVA: 0x0002523B File Offset: 0x0002343B
		public void NHDKIBDJBMH(Mesh PIPLEPOKNEF)
		{
		}

		// Token: 0x0600954D RID: 38221 RVA: 0x0035292C File Offset: 0x00350B2C
		public void PHPAININIBK(bool DPNHODJHGJL)
		{
			this.m_Veritical = DPNHODJHGJL;
		}

		// Token: 0x0600954E RID: 38222 RVA: 0x00352923 File Offset: 0x00350B23
		public void IFAEOAAJFHI(bool DPNHODJHGJL)
		{
			this.m_Horizontal = DPNHODJHGJL;
		}

		// Token: 0x0600954F RID: 38223 RVA: 0x0035294A File Offset: 0x00350B4A
		public bool EOFFDJCEDNO()
		{
			return this.m_Horizontal;
		}

		// Token: 0x06009550 RID: 38224 RVA: 0x0035292C File Offset: 0x00350B2C
		public void JEJCFMINMEF(bool DPNHODJHGJL)
		{
			this.m_Veritical = DPNHODJHGJL;
		}

		// Token: 0x06009551 RID: 38225 RVA: 0x0035293D File Offset: 0x00350B3D
		protected void AMIMHHGLPIN()
		{
			base.GetComponent<Graphic>().SetVerticesDirty();
		}

		// Token: 0x06009553 RID: 38227 RVA: 0x0035293D File Offset: 0x00350B3D
		protected void LKCHMPCHKDM()
		{
			base.GetComponent<Graphic>().SetVerticesDirty();
		}

		// Token: 0x06009554 RID: 38228 RVA: 0x0035293D File Offset: 0x00350B3D
		protected void ECKEBMIMIGK()
		{
			base.GetComponent<Graphic>().SetVerticesDirty();
		}

		// Token: 0x06009555 RID: 38229 RVA: 0x0035294A File Offset: 0x00350B4A
		public bool IEIBPNNKDOM()
		{
			return this.m_Horizontal;
		}

		// Token: 0x06009556 RID: 38230 RVA: 0x00352935 File Offset: 0x00350B35
		public bool CLLEPPHFMEI()
		{
			return this.m_Veritical;
		}

		// Token: 0x06009557 RID: 38231 RVA: 0x0002523B File Offset: 0x0002343B
		public void LHELKGCABEA(Mesh PIPLEPOKNEF)
		{
		}

		// Token: 0x06009558 RID: 38232 RVA: 0x0035292C File Offset: 0x00350B2C
		public void CGGOJHDJEMG(bool DPNHODJHGJL)
		{
			this.m_Veritical = DPNHODJHGJL;
		}

		// Token: 0x06009559 RID: 38233 RVA: 0x0035293D File Offset: 0x00350B3D
		protected void JDCJBNHAFCI()
		{
			base.GetComponent<Graphic>().SetVerticesDirty();
		}

		// Token: 0x0600955A RID: 38234 RVA: 0x0035293D File Offset: 0x00350B3D
		protected void NBHKHEPDCHP()
		{
			base.GetComponent<Graphic>().SetVerticesDirty();
		}

		// Token: 0x0600955B RID: 38235 RVA: 0x0035293D File Offset: 0x00350B3D
		protected void JNACKHNNEPA()
		{
			base.GetComponent<Graphic>().SetVerticesDirty();
		}

		// Token: 0x0600955C RID: 38236 RVA: 0x0002523B File Offset: 0x0002343B
		public void IPOJGOGGENA(Mesh PIPLEPOKNEF)
		{
		}

		// Token: 0x0600955D RID: 38237 RVA: 0x00352954 File Offset: 0x00350B54
		public void LODMIJBMAGC(VertexHelper ACPPOPJKJBE)
		{
			RectTransform rectTransform = base.transform as RectTransform;
			for (int i = 1; i < ACPPOPJKJBE.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				ACPPOPJKJBE.PopulateUIVertex(ref vertex, i);
				vertex.position = new Vector3((!this.m_Horizontal) ? vertex.position.x : (vertex.position.x + (rectTransform.rect.center.x - vertex.position.x) * 365f), (!this.m_Veritical) ? vertex.position.y : (vertex.position.y + (rectTransform.rect.center.y - vertex.position.y) * 266f), vertex.position.z);
				ACPPOPJKJBE.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x0600955E RID: 38238 RVA: 0x00352923 File Offset: 0x00350B23
		public void PENJNJNOKPP(bool DPNHODJHGJL)
		{
			this.m_Horizontal = DPNHODJHGJL;
		}

		// Token: 0x0600955F RID: 38239 RVA: 0x00352A5C File Offset: 0x00350C5C
		public void ModifyMesh(VertexHelper ACPPOPJKJBE)
		{
			RectTransform rectTransform = base.transform as RectTransform;
			for (int i = 0; i < ACPPOPJKJBE.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				ACPPOPJKJBE.PopulateUIVertex(ref vertex, i);
				vertex.position = new Vector3((!this.m_Horizontal) ? vertex.position.x : (vertex.position.x + (rectTransform.rect.center.x - vertex.position.x) * 2f), (!this.m_Veritical) ? vertex.position.y : (vertex.position.y + (rectTransform.rect.center.y - vertex.position.y) * 2f), vertex.position.z);
				ACPPOPJKJBE.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06009560 RID: 38240 RVA: 0x0035294A File Offset: 0x00350B4A
		public bool DNMPCAPPGEA()
		{
			return this.m_Horizontal;
		}

		// Token: 0x06009561 RID: 38241 RVA: 0x00352923 File Offset: 0x00350B23
		public void ECHCJCGMPAB(bool DPNHODJHGJL)
		{
			this.m_Horizontal = DPNHODJHGJL;
		}

		// Token: 0x06009562 RID: 38242 RVA: 0x0035292C File Offset: 0x00350B2C
		public void HONODOFINFP(bool DPNHODJHGJL)
		{
			this.m_Veritical = DPNHODJHGJL;
		}

		// Token: 0x06009563 RID: 38243 RVA: 0x0002523B File Offset: 0x0002343B
		public void KAHBKALAPED(Mesh PIPLEPOKNEF)
		{
		}

		// Token: 0x06009564 RID: 38244 RVA: 0x0035292C File Offset: 0x00350B2C
		public void GDJDGHLNNAO(bool DPNHODJHGJL)
		{
			this.m_Veritical = DPNHODJHGJL;
		}

		// Token: 0x06009565 RID: 38245 RVA: 0x0035293D File Offset: 0x00350B3D
		protected void PCJLGDMFOOM()
		{
			base.GetComponent<Graphic>().SetVerticesDirty();
		}

		// Token: 0x06009566 RID: 38246 RVA: 0x0035292C File Offset: 0x00350B2C
		public void FLHIGJCJKAG(bool DPNHODJHGJL)
		{
			this.m_Veritical = DPNHODJHGJL;
		}

		// Token: 0x06009567 RID: 38247 RVA: 0x0035293D File Offset: 0x00350B3D
		protected void IOGLBLFDMLP()
		{
			base.GetComponent<Graphic>().SetVerticesDirty();
		}

		// Token: 0x06009568 RID: 38248 RVA: 0x00352935 File Offset: 0x00350B35
		public bool DLAPKCEFJFO()
		{
			return this.m_Veritical;
		}

		// Token: 0x06009569 RID: 38249 RVA: 0x0002523B File Offset: 0x0002343B
		public void NGAFDJKNLAH(Mesh PIPLEPOKNEF)
		{
		}

		// Token: 0x0600956A RID: 38250 RVA: 0x00352923 File Offset: 0x00350B23
		public void CCMIIHDNLKC(bool DPNHODJHGJL)
		{
			this.m_Horizontal = DPNHODJHGJL;
		}

		// Token: 0x0600956B RID: 38251 RVA: 0x0035294A File Offset: 0x00350B4A
		public bool PGHOABILKGK()
		{
			return this.m_Horizontal;
		}

		// Token: 0x0600956D RID: 38253 RVA: 0x00352935 File Offset: 0x00350B35
		public bool PLJPEHFKOID()
		{
			return this.m_Veritical;
		}

		// Token: 0x0600956E RID: 38254 RVA: 0x0035292C File Offset: 0x00350B2C
		public void DDKDBHGHKEF(bool DPNHODJHGJL)
		{
			this.m_Veritical = DPNHODJHGJL;
		}

		// Token: 0x0600956F RID: 38255 RVA: 0x0002523B File Offset: 0x0002343B
		public void ENMLKBILBLG(Mesh PIPLEPOKNEF)
		{
		}

		// Token: 0x06009570 RID: 38256 RVA: 0x0035292C File Offset: 0x00350B2C
		public void BPENKHCCELC(bool DPNHODJHGJL)
		{
			this.m_Veritical = DPNHODJHGJL;
		}

		// Token: 0x06009571 RID: 38257 RVA: 0x0035294A File Offset: 0x00350B4A
		public bool EBFLENHGJLB()
		{
			return this.m_Horizontal;
		}

		// Token: 0x06009572 RID: 38258 RVA: 0x00352935 File Offset: 0x00350B35
		public bool KEGDAOIHKHD()
		{
			return this.m_Veritical;
		}

		// Token: 0x06009573 RID: 38259 RVA: 0x0002523B File Offset: 0x0002343B
		public void KPGJPGDIGPF(Mesh PIPLEPOKNEF)
		{
		}

		// Token: 0x06009574 RID: 38260 RVA: 0x0035294A File Offset: 0x00350B4A
		public bool CLPAKPCFOJH()
		{
			return this.m_Horizontal;
		}

		// Token: 0x06009575 RID: 38261 RVA: 0x0002523B File Offset: 0x0002343B
		public void KOCNFONLNCF(Mesh PIPLEPOKNEF)
		{
		}

		// Token: 0x06009576 RID: 38262 RVA: 0x0035293D File Offset: 0x00350B3D
		protected void MOEPJDOFBHA()
		{
			base.GetComponent<Graphic>().SetVerticesDirty();
		}

		// Token: 0x06009577 RID: 38263 RVA: 0x0035294A File Offset: 0x00350B4A
		public bool CBGGDAKDADG()
		{
			return this.m_Horizontal;
		}

		// Token: 0x06009578 RID: 38264 RVA: 0x00352923 File Offset: 0x00350B23
		public void JGJHOANPMDN(bool DPNHODJHGJL)
		{
			this.m_Horizontal = DPNHODJHGJL;
		}

		// Token: 0x06009579 RID: 38265 RVA: 0x00352935 File Offset: 0x00350B35
		public bool PKNKOCJCADP()
		{
			return this.m_Veritical;
		}

		// Token: 0x0600957A RID: 38266 RVA: 0x0035293D File Offset: 0x00350B3D
		protected void BJAGGFKIMKK()
		{
			base.GetComponent<Graphic>().SetVerticesDirty();
		}

		// Token: 0x0600957B RID: 38267 RVA: 0x00352935 File Offset: 0x00350B35
		public bool GOPIHOFKOIC()
		{
			return this.m_Veritical;
		}

		// Token: 0x0600957C RID: 38268 RVA: 0x0002523B File Offset: 0x0002343B
		public void BKCKCFPNHEB(Mesh PIPLEPOKNEF)
		{
		}

		// Token: 0x0600957D RID: 38269 RVA: 0x00352B64 File Offset: 0x00350D64
		public void MAABDFLDMPK(VertexHelper ACPPOPJKJBE)
		{
			RectTransform rectTransform = base.transform as RectTransform;
			for (int i = 0; i < ACPPOPJKJBE.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				ACPPOPJKJBE.PopulateUIVertex(ref vertex, i);
				vertex.position = new Vector3((!this.m_Horizontal) ? vertex.position.x : (vertex.position.x + (rectTransform.rect.center.x - vertex.position.x) * 803f), (!this.m_Veritical) ? vertex.position.y : (vertex.position.y + (rectTransform.rect.center.y - vertex.position.y) * 1841f), vertex.position.z);
				ACPPOPJKJBE.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x0600957E RID: 38270 RVA: 0x0035294A File Offset: 0x00350B4A
		public bool BCEJDODHCKE()
		{
			return this.m_Horizontal;
		}

		// Token: 0x0600957F RID: 38271 RVA: 0x0035293D File Offset: 0x00350B3D
		protected void CAOLLBOBPFF()
		{
			base.GetComponent<Graphic>().SetVerticesDirty();
		}

		// Token: 0x06009580 RID: 38272 RVA: 0x00352923 File Offset: 0x00350B23
		public void PAEFJHLJMAP(bool DPNHODJHGJL)
		{
			this.m_Horizontal = DPNHODJHGJL;
		}

		// Token: 0x06009581 RID: 38273 RVA: 0x00352923 File Offset: 0x00350B23
		public void OJDFALOKJKA(bool DPNHODJHGJL)
		{
			this.m_Horizontal = DPNHODJHGJL;
		}

		// Token: 0x06009582 RID: 38274 RVA: 0x00352C6C File Offset: 0x00350E6C
		public void APAGHHDJLDB(VertexHelper ACPPOPJKJBE)
		{
			RectTransform rectTransform = base.transform as RectTransform;
			for (int i = 0; i < ACPPOPJKJBE.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				ACPPOPJKJBE.PopulateUIVertex(ref vertex, i);
				vertex.position = new Vector3((!this.m_Horizontal) ? vertex.position.x : (vertex.position.x + (rectTransform.rect.center.x - vertex.position.x) * 1214f), (!this.m_Veritical) ? vertex.position.y : (vertex.position.y + (rectTransform.rect.center.y - vertex.position.y) * 1410f), vertex.position.z);
				ACPPOPJKJBE.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06009583 RID: 38275 RVA: 0x0002523B File Offset: 0x0002343B
		public void ACLDPOANCMK(Mesh PIPLEPOKNEF)
		{
		}

		// Token: 0x06009584 RID: 38276 RVA: 0x0035293D File Offset: 0x00350B3D
		protected void POIFMMFPELA()
		{
			base.GetComponent<Graphic>().SetVerticesDirty();
		}

		// Token: 0x06009585 RID: 38277 RVA: 0x00352D74 File Offset: 0x00350F74
		public void BHPDEJGCOJI(VertexHelper ACPPOPJKJBE)
		{
			RectTransform rectTransform = base.transform as RectTransform;
			for (int i = 0; i < ACPPOPJKJBE.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				ACPPOPJKJBE.PopulateUIVertex(ref vertex, i);
				vertex.position = new Vector3((!this.m_Horizontal) ? vertex.position.x : (vertex.position.x + (rectTransform.rect.center.x - vertex.position.x) * 963f), (!this.m_Veritical) ? vertex.position.y : (vertex.position.y + (rectTransform.rect.center.y - vertex.position.y) * 1166f), vertex.position.z);
				ACPPOPJKJBE.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06009586 RID: 38278 RVA: 0x0035293D File Offset: 0x00350B3D
		protected void JNKFOLNDNFP()
		{
			base.GetComponent<Graphic>().SetVerticesDirty();
		}

		// Token: 0x06009587 RID: 38279 RVA: 0x0035294A File Offset: 0x00350B4A
		public bool IGMCEAONALP()
		{
			return this.m_Horizontal;
		}

		// Token: 0x06009588 RID: 38280 RVA: 0x0035294A File Offset: 0x00350B4A
		public bool GHECFLFAEIG()
		{
			return this.m_Horizontal;
		}

		// Token: 0x06009589 RID: 38281 RVA: 0x0035294A File Offset: 0x00350B4A
		public bool HDJHLFNBEIM()
		{
			return this.m_Horizontal;
		}

		// Token: 0x0600958A RID: 38282 RVA: 0x00352935 File Offset: 0x00350B35
		public bool GLHKPNNMAOP()
		{
			return this.m_Veritical;
		}

		// Token: 0x0600958B RID: 38283 RVA: 0x0035292C File Offset: 0x00350B2C
		public void IDFENDMMBDH(bool DPNHODJHGJL)
		{
			this.m_Veritical = DPNHODJHGJL;
		}

		// Token: 0x0600958C RID: 38284 RVA: 0x00352923 File Offset: 0x00350B23
		public void EJJKCFCPNAN(bool DPNHODJHGJL)
		{
			this.m_Horizontal = DPNHODJHGJL;
		}

		// Token: 0x0600958D RID: 38285 RVA: 0x0035293D File Offset: 0x00350B3D
		protected void MNHCBAKPBCF()
		{
			base.GetComponent<Graphic>().SetVerticesDirty();
		}

		// Token: 0x0600958E RID: 38286 RVA: 0x00352923 File Offset: 0x00350B23
		public void FHPKCFBLODB(bool DPNHODJHGJL)
		{
			this.m_Horizontal = DPNHODJHGJL;
		}

		// Token: 0x0600958F RID: 38287 RVA: 0x00352E7C File Offset: 0x0035107C
		public void IDPADEBHCFF(VertexHelper ACPPOPJKJBE)
		{
			RectTransform rectTransform = base.transform as RectTransform;
			for (int i = 1; i < ACPPOPJKJBE.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				ACPPOPJKJBE.PopulateUIVertex(ref vertex, i);
				vertex.position = new Vector3((!this.m_Horizontal) ? vertex.position.x : (vertex.position.x + (rectTransform.rect.center.x - vertex.position.x) * 873f), (!this.m_Veritical) ? vertex.position.y : (vertex.position.y + (rectTransform.rect.center.y - vertex.position.y) * 1534f), vertex.position.z);
				ACPPOPJKJBE.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06009590 RID: 38288 RVA: 0x00352923 File Offset: 0x00350B23
		public void FBGCAJAPMJA(bool DPNHODJHGJL)
		{
			this.m_Horizontal = DPNHODJHGJL;
		}

		// Token: 0x06009591 RID: 38289 RVA: 0x00352F84 File Offset: 0x00351184
		public void NEKKCPANHHD(VertexHelper ACPPOPJKJBE)
		{
			RectTransform rectTransform = base.transform as RectTransform;
			for (int i = 1; i < ACPPOPJKJBE.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				ACPPOPJKJBE.PopulateUIVertex(ref vertex, i);
				vertex.position = new Vector3((!this.m_Horizontal) ? vertex.position.x : (vertex.position.x + (rectTransform.rect.center.x - vertex.position.x) * 1963f), (!this.m_Veritical) ? vertex.position.y : (vertex.position.y + (rectTransform.rect.center.y - vertex.position.y) * 876f), vertex.position.z);
				ACPPOPJKJBE.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06009592 RID: 38290 RVA: 0x00352923 File Offset: 0x00350B23
		public void PBPBBJJBILF(bool DPNHODJHGJL)
		{
			this.m_Horizontal = DPNHODJHGJL;
		}

		// Token: 0x06009593 RID: 38291 RVA: 0x00352935 File Offset: 0x00350B35
		public bool FHPKCJJMCMD()
		{
			return this.m_Veritical;
		}

		// Token: 0x06009594 RID: 38292 RVA: 0x0035308C File Offset: 0x0035128C
		public void HACHAIHJHBN(VertexHelper ACPPOPJKJBE)
		{
			RectTransform rectTransform = base.transform as RectTransform;
			for (int i = 1; i < ACPPOPJKJBE.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				ACPPOPJKJBE.PopulateUIVertex(ref vertex, i);
				vertex.position = new Vector3((!this.m_Horizontal) ? vertex.position.x : (vertex.position.x + (rectTransform.rect.center.x - vertex.position.x) * 1607f), (!this.m_Veritical) ? vertex.position.y : (vertex.position.y + (rectTransform.rect.center.y - vertex.position.y) * 1612f), vertex.position.z);
				ACPPOPJKJBE.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x06009595 RID: 38293 RVA: 0x0035294A File Offset: 0x00350B4A
		public bool DDBLMPAAPDL()
		{
			return this.m_Horizontal;
		}

		// Token: 0x06009596 RID: 38294 RVA: 0x0002523B File Offset: 0x0002343B
		public void BKDLPLOAJDD(Mesh PIPLEPOKNEF)
		{
		}

		// Token: 0x06009597 RID: 38295 RVA: 0x00352923 File Offset: 0x00350B23
		public void BNKFMOOICPL(bool DPNHODJHGJL)
		{
			this.m_Horizontal = DPNHODJHGJL;
		}

		// Token: 0x06009598 RID: 38296 RVA: 0x0035292C File Offset: 0x00350B2C
		public void JBIHCGDNKEB(bool DPNHODJHGJL)
		{
			this.m_Veritical = DPNHODJHGJL;
		}

		// Token: 0x06009599 RID: 38297 RVA: 0x00353194 File Offset: 0x00351394
		public void ALNHCDMKAPL(VertexHelper ACPPOPJKJBE)
		{
			RectTransform rectTransform = base.transform as RectTransform;
			for (int i = 1; i < ACPPOPJKJBE.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				ACPPOPJKJBE.PopulateUIVertex(ref vertex, i);
				vertex.position = new Vector3((!this.m_Horizontal) ? vertex.position.x : (vertex.position.x + (rectTransform.rect.center.x - vertex.position.x) * 1056f), (!this.m_Veritical) ? vertex.position.y : (vertex.position.y + (rectTransform.rect.center.y - vertex.position.y) * 1971f), vertex.position.z);
				ACPPOPJKJBE.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x0600959A RID: 38298 RVA: 0x00352923 File Offset: 0x00350B23
		public void KDICDIEIPPO(bool DPNHODJHGJL)
		{
			this.m_Horizontal = DPNHODJHGJL;
		}

		// Token: 0x0600959B RID: 38299 RVA: 0x0035294A File Offset: 0x00350B4A
		public bool DIALAPLFBBM()
		{
			return this.m_Horizontal;
		}

		// Token: 0x0600959C RID: 38300 RVA: 0x0035293D File Offset: 0x00350B3D
		protected void LNCFCGGJJOB()
		{
			base.GetComponent<Graphic>().SetVerticesDirty();
		}

		// Token: 0x0600959D RID: 38301 RVA: 0x0035294A File Offset: 0x00350B4A
		public bool MEJHCEFAOLP()
		{
			return this.m_Horizontal;
		}

		// Token: 0x0600959E RID: 38302 RVA: 0x0035294A File Offset: 0x00350B4A
		public bool KHPKAPPEEKL()
		{
			return this.m_Horizontal;
		}

		// Token: 0x0600959F RID: 38303 RVA: 0x0035292C File Offset: 0x00350B2C
		public void KJGMANGIINF(bool DPNHODJHGJL)
		{
			this.m_Veritical = DPNHODJHGJL;
		}

		// Token: 0x060095A0 RID: 38304 RVA: 0x00352923 File Offset: 0x00350B23
		public void ICPEDLOOAJG(bool DPNHODJHGJL)
		{
			this.m_Horizontal = DPNHODJHGJL;
		}

		// Token: 0x060095A1 RID: 38305 RVA: 0x00352935 File Offset: 0x00350B35
		public bool KHGBMACEDMG()
		{
			return this.m_Veritical;
		}

		// Token: 0x060095A2 RID: 38306 RVA: 0x0035294A File Offset: 0x00350B4A
		public bool NMIFHKBCLOC()
		{
			return this.m_Horizontal;
		}

		// Token: 0x060095A3 RID: 38307 RVA: 0x0035329C File Offset: 0x0035149C
		public void NHHLCCPCCOM(VertexHelper ACPPOPJKJBE)
		{
			RectTransform rectTransform = base.transform as RectTransform;
			for (int i = 1; i < ACPPOPJKJBE.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				ACPPOPJKJBE.PopulateUIVertex(ref vertex, i);
				vertex.position = new Vector3((!this.m_Horizontal) ? vertex.position.x : (vertex.position.x + (rectTransform.rect.center.x - vertex.position.x) * 1824f), (!this.m_Veritical) ? vertex.position.y : (vertex.position.y + (rectTransform.rect.center.y - vertex.position.y) * 1455f), vertex.position.z);
				ACPPOPJKJBE.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x060095A4 RID: 38308 RVA: 0x0002523B File Offset: 0x0002343B
		public void CFJOBJGFCLE(Mesh PIPLEPOKNEF)
		{
		}

		// Token: 0x060095A5 RID: 38309 RVA: 0x0035293D File Offset: 0x00350B3D
		protected void MPHAMHBNCJF()
		{
			base.GetComponent<Graphic>().SetVerticesDirty();
		}

		// Token: 0x060095A6 RID: 38310 RVA: 0x0035294A File Offset: 0x00350B4A
		public bool ALNKDIEDKPM()
		{
			return this.m_Horizontal;
		}

		// Token: 0x060095A7 RID: 38311 RVA: 0x0002523B File Offset: 0x0002343B
		public void AGPCDJEMEDF(Mesh PIPLEPOKNEF)
		{
		}

		// Token: 0x060095A8 RID: 38312 RVA: 0x0035294A File Offset: 0x00350B4A
		public bool MCBNKEGBHCD()
		{
			return this.m_Horizontal;
		}

		// Token: 0x060095A9 RID: 38313 RVA: 0x003533A4 File Offset: 0x003515A4
		public void ELJBNIMAJBP(VertexHelper ACPPOPJKJBE)
		{
			RectTransform rectTransform = base.transform as RectTransform;
			for (int i = 1; i < ACPPOPJKJBE.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				ACPPOPJKJBE.PopulateUIVertex(ref vertex, i);
				vertex.position = new Vector3((!this.m_Horizontal) ? vertex.position.x : (vertex.position.x + (rectTransform.rect.center.x - vertex.position.x) * 1308f), (!this.m_Veritical) ? vertex.position.y : (vertex.position.y + (rectTransform.rect.center.y - vertex.position.y) * 819f), vertex.position.z);
				ACPPOPJKJBE.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x060095AA RID: 38314 RVA: 0x0002523B File Offset: 0x0002343B
		public void KAGIBHJJHIL(Mesh PIPLEPOKNEF)
		{
		}

		// Token: 0x060095AB RID: 38315 RVA: 0x0002523B File Offset: 0x0002343B
		public void DAGEAMDJGPF(Mesh PIPLEPOKNEF)
		{
		}

		// Token: 0x060095AC RID: 38316 RVA: 0x0002523B File Offset: 0x0002343B
		public void NJIOJPMPJIN(Mesh PIPLEPOKNEF)
		{
		}

		// Token: 0x060095AD RID: 38317 RVA: 0x0035294A File Offset: 0x00350B4A
		public bool AENAKNMACCN()
		{
			return this.m_Horizontal;
		}

		// Token: 0x060095AE RID: 38318 RVA: 0x0035294A File Offset: 0x00350B4A
		public bool FLDAKECMKBC()
		{
			return this.m_Horizontal;
		}

		// Token: 0x060095AF RID: 38319 RVA: 0x0035292C File Offset: 0x00350B2C
		public void HAKIFPMKOFB(bool DPNHODJHGJL)
		{
			this.m_Veritical = DPNHODJHGJL;
		}

		// Token: 0x060095B0 RID: 38320 RVA: 0x00352935 File Offset: 0x00350B35
		public bool LKHJOJIDLBC()
		{
			return this.m_Veritical;
		}

		// Token: 0x060095B1 RID: 38321 RVA: 0x0035292C File Offset: 0x00350B2C
		public void IBDDMNFLNFE(bool DPNHODJHGJL)
		{
			this.m_Veritical = DPNHODJHGJL;
		}

		// Token: 0x060095B2 RID: 38322 RVA: 0x0035293D File Offset: 0x00350B3D
		protected void OnValidate()
		{
			base.GetComponent<Graphic>().SetVerticesDirty();
		}

		// Token: 0x060095B3 RID: 38323 RVA: 0x003534AC File Offset: 0x003516AC
		public void KDBELKEEKPC(VertexHelper ACPPOPJKJBE)
		{
			RectTransform rectTransform = base.transform as RectTransform;
			for (int i = 0; i < ACPPOPJKJBE.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				ACPPOPJKJBE.PopulateUIVertex(ref vertex, i);
				vertex.position = new Vector3((!this.m_Horizontal) ? vertex.position.x : (vertex.position.x + (rectTransform.rect.center.x - vertex.position.x) * 693f), (!this.m_Veritical) ? vertex.position.y : (vertex.position.y + (rectTransform.rect.center.y - vertex.position.y) * 430f), vertex.position.z);
				ACPPOPJKJBE.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x060095B4 RID: 38324 RVA: 0x0035293D File Offset: 0x00350B3D
		protected void HPOHJDJIADD()
		{
			base.GetComponent<Graphic>().SetVerticesDirty();
		}

		// Token: 0x060095B5 RID: 38325 RVA: 0x003535B4 File Offset: 0x003517B4
		public void KEAEPLNFKEN(VertexHelper ACPPOPJKJBE)
		{
			RectTransform rectTransform = base.transform as RectTransform;
			for (int i = 0; i < ACPPOPJKJBE.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				ACPPOPJKJBE.PopulateUIVertex(ref vertex, i);
				vertex.position = new Vector3((!this.m_Horizontal) ? vertex.position.x : (vertex.position.x + (rectTransform.rect.center.x - vertex.position.x) * 843f), (!this.m_Veritical) ? vertex.position.y : (vertex.position.y + (rectTransform.rect.center.y - vertex.position.y) * 1362f), vertex.position.z);
				ACPPOPJKJBE.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x060095B6 RID: 38326 RVA: 0x00352923 File Offset: 0x00350B23
		public void CJEADCAMLLA(bool DPNHODJHGJL)
		{
			this.m_Horizontal = DPNHODJHGJL;
		}

		// Token: 0x060095B7 RID: 38327 RVA: 0x0002523B File Offset: 0x0002343B
		public void ModifyMesh(Mesh PIPLEPOKNEF)
		{
		}

		// Token: 0x060095B8 RID: 38328 RVA: 0x003536BC File Offset: 0x003518BC
		public void CGANJJCPICL(VertexHelper ACPPOPJKJBE)
		{
			RectTransform rectTransform = base.transform as RectTransform;
			for (int i = 1; i < ACPPOPJKJBE.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				ACPPOPJKJBE.PopulateUIVertex(ref vertex, i);
				vertex.position = new Vector3((!this.m_Horizontal) ? vertex.position.x : (vertex.position.x + (rectTransform.rect.center.x - vertex.position.x) * 1468f), (!this.m_Veritical) ? vertex.position.y : (vertex.position.y + (rectTransform.rect.center.y - vertex.position.y) * 88f), vertex.position.z);
				ACPPOPJKJBE.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x060095BA RID: 38330 RVA: 0x0035292C File Offset: 0x00350B2C
		public void ELKDKIOBPGG(bool DPNHODJHGJL)
		{
			this.m_Veritical = DPNHODJHGJL;
		}

		// Token: 0x060095BB RID: 38331 RVA: 0x003537C4 File Offset: 0x003519C4
		public void FJGJNHHAKDL(VertexHelper ACPPOPJKJBE)
		{
			RectTransform rectTransform = base.transform as RectTransform;
			for (int i = 0; i < ACPPOPJKJBE.currentVertCount; i += 0)
			{
				UIVertex vertex = default(UIVertex);
				ACPPOPJKJBE.PopulateUIVertex(ref vertex, i);
				vertex.position = new Vector3((!this.m_Horizontal) ? vertex.position.x : (vertex.position.x + (rectTransform.rect.center.x - vertex.position.x) * 857f), (!this.m_Veritical) ? vertex.position.y : (vertex.position.y + (rectTransform.rect.center.y - vertex.position.y) * 1764f), vertex.position.z);
				ACPPOPJKJBE.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x060095BC RID: 38332 RVA: 0x0002523B File Offset: 0x0002343B
		public void LEAJOGBKHKD(Mesh PIPLEPOKNEF)
		{
		}

		// Token: 0x060095BD RID: 38333 RVA: 0x00352935 File Offset: 0x00350B35
		public bool NAOEHAPMFFM()
		{
			return this.m_Veritical;
		}

		// Token: 0x060095BE RID: 38334 RVA: 0x0035293D File Offset: 0x00350B3D
		protected void JBAPHFIBANG()
		{
			base.GetComponent<Graphic>().SetVerticesDirty();
		}

		// Token: 0x060095BF RID: 38335 RVA: 0x00352935 File Offset: 0x00350B35
		public bool GIPCHHFMCPF()
		{
			return this.m_Veritical;
		}

		// Token: 0x060095C0 RID: 38336 RVA: 0x00352923 File Offset: 0x00350B23
		public void GBEGNKDBFIP(bool DPNHODJHGJL)
		{
			this.m_Horizontal = DPNHODJHGJL;
		}

		// Token: 0x060095C1 RID: 38337 RVA: 0x0035293D File Offset: 0x00350B3D
		protected void OIPJFDCNEDH()
		{
			base.GetComponent<Graphic>().SetVerticesDirty();
		}

		// Token: 0x060095C2 RID: 38338 RVA: 0x0002523B File Offset: 0x0002343B
		public void AMKHCDBFJCA(Mesh PIPLEPOKNEF)
		{
		}

		// Token: 0x060095C3 RID: 38339 RVA: 0x0035292C File Offset: 0x00350B2C
		public void PLGBHDKHBHO(bool DPNHODJHGJL)
		{
			this.m_Veritical = DPNHODJHGJL;
		}

		// Token: 0x060095C4 RID: 38340 RVA: 0x00352923 File Offset: 0x00350B23
		public void KEDOFHLGDGO(bool DPNHODJHGJL)
		{
			this.m_Horizontal = DPNHODJHGJL;
		}

		// Token: 0x060095C5 RID: 38341 RVA: 0x0035292C File Offset: 0x00350B2C
		public void NNDONANNONB(bool DPNHODJHGJL)
		{
			this.m_Veritical = DPNHODJHGJL;
		}

		// Token: 0x060095C6 RID: 38342 RVA: 0x00352935 File Offset: 0x00350B35
		public bool BNPIGGIBMKM()
		{
			return this.m_Veritical;
		}

		// Token: 0x060095C7 RID: 38343 RVA: 0x003538CC File Offset: 0x00351ACC
		public void CJAOHBMLMBG(VertexHelper ACPPOPJKJBE)
		{
			RectTransform rectTransform = base.transform as RectTransform;
			for (int i = 1; i < ACPPOPJKJBE.currentVertCount; i++)
			{
				UIVertex vertex = default(UIVertex);
				ACPPOPJKJBE.PopulateUIVertex(ref vertex, i);
				vertex.position = new Vector3((!this.m_Horizontal) ? vertex.position.x : (vertex.position.x + (rectTransform.rect.center.x - vertex.position.x) * 1895f), (!this.m_Veritical) ? vertex.position.y : (vertex.position.y + (rectTransform.rect.center.y - vertex.position.y) * 1342f), vertex.position.z);
				ACPPOPJKJBE.SetUIVertex(vertex, i);
			}
		}

		// Token: 0x060095C8 RID: 38344 RVA: 0x0035292C File Offset: 0x00350B2C
		public void KBCCBOOEKFG(bool DPNHODJHGJL)
		{
			this.m_Veritical = DPNHODJHGJL;
		}

		// Token: 0x060095C9 RID: 38345 RVA: 0x00352935 File Offset: 0x00350B35
		public bool ANEBPMHPBBD()
		{
			return this.m_Veritical;
		}

		// Token: 0x060095CA RID: 38346 RVA: 0x0035293D File Offset: 0x00350B3D
		protected void LIEEGINIKOK()
		{
			base.GetComponent<Graphic>().SetVerticesDirty();
		}

		// Token: 0x060095CB RID: 38347 RVA: 0x0002523B File Offset: 0x0002343B
		public void CONOFFAMNCD(Mesh PIPLEPOKNEF)
		{
		}

		// Token: 0x04001110 RID: 4368
		[SerializeField]
		private bool m_Horizontal;

		// Token: 0x04001111 RID: 4369
		[SerializeField]
		private bool m_Veritical;
	}
}
