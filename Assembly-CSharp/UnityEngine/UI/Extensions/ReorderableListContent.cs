using System;
using System.Collections;
using System.Collections.Generic;

namespace UnityEngine.UI.Extensions
{
	// Token: 0x02000294 RID: 660
	public class ReorderableListContent : MonoBehaviour
	{
		// Token: 0x06009E95 RID: 40597 RVA: 0x003AED60 File Offset: 0x003ACF60
		private IEnumerator POHNODMLPKE()
		{
			for (int i = 0; i < this.BBNGEJDDCIG.childCount; i++)
			{
				if (!this.ACAGIMIDKDC.Contains(this.BBNGEJDDCIG.GetChild(i)))
				{
					this.GALFGJPPPDC = (this.BBNGEJDDCIG.GetChild(i).gameObject.GetComponent<ReorderableListElement>() ?? this.BBNGEJDDCIG.GetChild(i).gameObject.AddComponent<ReorderableListElement>());
					this.GALFGJPPPDC.Init(this.PDNNCIFOKJA);
					this.ACAGIMIDKDC.Add(this.BBNGEJDDCIG.GetChild(i));
					this.BBJPPOHPPHO.Add(this.GALFGJPPPDC);
				}
			}
			yield return 0;
			for (int j = this.ACAGIMIDKDC.Count - 1; j >= 0; j--)
			{
				if (this.ACAGIMIDKDC[j] == null)
				{
					this.ACAGIMIDKDC.RemoveAt(j);
					this.BBJPPOHPPHO.RemoveAt(j);
				}
			}
			yield break;
		}

		// Token: 0x06009E97 RID: 40599 RVA: 0x003AED7B File Offset: 0x003ACF7B
		public void LKEPIEEIMAE(ReorderableList PFKLCAKIKLH)
		{
			this.PDNNCIFOKJA = PFKLCAKIKLH;
			this.BBNGEJDDCIG = base.GetComponent<RectTransform>();
			this.ACAGIMIDKDC = new List<Transform>();
			this.BBJPPOHPPHO = new List<ReorderableListElement>();
			base.StartCoroutine(this.LJPDPFHNAGC());
		}

		// Token: 0x06009E98 RID: 40600 RVA: 0x003AEDB3 File Offset: 0x003ACFB3
		public void OnTransformChildrenChanged()
		{
			base.StartCoroutine(this.CODNCAOCDGJ());
		}

		// Token: 0x06009E99 RID: 40601 RVA: 0x003AEDC2 File Offset: 0x003ACFC2
		public void Init(ReorderableList PFKLCAKIKLH)
		{
			this.PDNNCIFOKJA = PFKLCAKIKLH;
			this.BBNGEJDDCIG = base.GetComponent<RectTransform>();
			this.ACAGIMIDKDC = new List<Transform>();
			this.BBJPPOHPPHO = new List<ReorderableListElement>();
			base.StartCoroutine(this.CODNCAOCDGJ());
		}

		// Token: 0x06009E9A RID: 40602 RVA: 0x003AEDFC File Offset: 0x003ACFFC
		private IEnumerator LJPDPFHNAGC()
		{
			for (int i = 0; i < this.BBNGEJDDCIG.childCount; i++)
			{
				if (!this.ACAGIMIDKDC.Contains(this.BBNGEJDDCIG.GetChild(i)))
				{
					this.GALFGJPPPDC = (this.BBNGEJDDCIG.GetChild(i).gameObject.GetComponent<ReorderableListElement>() ?? this.BBNGEJDDCIG.GetChild(i).gameObject.AddComponent<ReorderableListElement>());
					this.GALFGJPPPDC.Init(this.PDNNCIFOKJA);
					this.ACAGIMIDKDC.Add(this.BBNGEJDDCIG.GetChild(i));
					this.BBJPPOHPPHO.Add(this.GALFGJPPPDC);
				}
			}
			yield return 0;
			for (int j = this.ACAGIMIDKDC.Count - 1; j >= 0; j--)
			{
				if (this.ACAGIMIDKDC[j] == null)
				{
					this.ACAGIMIDKDC.RemoveAt(j);
					this.BBJPPOHPPHO.RemoveAt(j);
				}
			}
			yield break;
		}

		// Token: 0x06009E9B RID: 40603 RVA: 0x003AEE18 File Offset: 0x003AD018
		private IEnumerator FEPGFFPEJMH()
		{
			for (int i = 0; i < this.BBNGEJDDCIG.childCount; i++)
			{
				if (!this.ACAGIMIDKDC.Contains(this.BBNGEJDDCIG.GetChild(i)))
				{
					this.GALFGJPPPDC = (this.BBNGEJDDCIG.GetChild(i).gameObject.GetComponent<ReorderableListElement>() ?? this.BBNGEJDDCIG.GetChild(i).gameObject.AddComponent<ReorderableListElement>());
					this.GALFGJPPPDC.Init(this.PDNNCIFOKJA);
					this.ACAGIMIDKDC.Add(this.BBNGEJDDCIG.GetChild(i));
					this.BBJPPOHPPHO.Add(this.GALFGJPPPDC);
				}
			}
			yield return 0;
			for (int j = this.ACAGIMIDKDC.Count - 1; j >= 0; j--)
			{
				if (this.ACAGIMIDKDC[j] == null)
				{
					this.ACAGIMIDKDC.RemoveAt(j);
					this.BBJPPOHPPHO.RemoveAt(j);
				}
			}
			yield break;
		}

		// Token: 0x06009E9C RID: 40604 RVA: 0x003AEE33 File Offset: 0x003AD033
		public void KDGHCJFJPEN()
		{
			base.StartCoroutine(this.FIOAKEAFAMC());
		}

		// Token: 0x06009E9D RID: 40605 RVA: 0x003AEE42 File Offset: 0x003AD042
		public void FEJAAGGMBOE(ReorderableList PFKLCAKIKLH)
		{
			this.PDNNCIFOKJA = PFKLCAKIKLH;
			this.BBNGEJDDCIG = base.GetComponent<RectTransform>();
			this.ACAGIMIDKDC = new List<Transform>();
			this.BBJPPOHPPHO = new List<ReorderableListElement>();
			base.StartCoroutine(this.JGGJFAAMHII());
		}

		// Token: 0x06009E9E RID: 40606 RVA: 0x003AEE7A File Offset: 0x003AD07A
		public void LDCFCIPNMFK()
		{
			base.StartCoroutine(this.FDEAMAOALBD());
		}

		// Token: 0x06009E9F RID: 40607 RVA: 0x003AEE89 File Offset: 0x003AD089
		public void NBIEIGBAKND(ReorderableList PFKLCAKIKLH)
		{
			this.PDNNCIFOKJA = PFKLCAKIKLH;
			this.BBNGEJDDCIG = base.GetComponent<RectTransform>();
			this.ACAGIMIDKDC = new List<Transform>();
			this.BBJPPOHPPHO = new List<ReorderableListElement>();
			base.StartCoroutine(this.FDEAMAOALBD());
		}

		// Token: 0x06009EA0 RID: 40608 RVA: 0x003AEEC4 File Offset: 0x003AD0C4
		private IEnumerator CODNCAOCDGJ()
		{
			for (int i = 0; i < this.BBNGEJDDCIG.childCount; i++)
			{
				if (!this.ACAGIMIDKDC.Contains(this.BBNGEJDDCIG.GetChild(i)))
				{
					this.GALFGJPPPDC = (this.BBNGEJDDCIG.GetChild(i).gameObject.GetComponent<ReorderableListElement>() ?? this.BBNGEJDDCIG.GetChild(i).gameObject.AddComponent<ReorderableListElement>());
					this.GALFGJPPPDC.Init(this.PDNNCIFOKJA);
					this.ACAGIMIDKDC.Add(this.BBNGEJDDCIG.GetChild(i));
					this.BBJPPOHPPHO.Add(this.GALFGJPPPDC);
				}
			}
			yield return 0;
			for (int j = this.ACAGIMIDKDC.Count - 1; j >= 0; j--)
			{
				if (this.ACAGIMIDKDC[j] == null)
				{
					this.ACAGIMIDKDC.RemoveAt(j);
					this.BBJPPOHPPHO.RemoveAt(j);
				}
			}
			yield break;
		}

		// Token: 0x06009EA1 RID: 40609 RVA: 0x003AEEDF File Offset: 0x003AD0DF
		public void HMHLBAHLNLP()
		{
			base.StartCoroutine(this.ELPIDPIAABC());
		}

		// Token: 0x06009EA2 RID: 40610 RVA: 0x003AEE42 File Offset: 0x003AD042
		public void GGHCMPKGNGE(ReorderableList PFKLCAKIKLH)
		{
			this.PDNNCIFOKJA = PFKLCAKIKLH;
			this.BBNGEJDDCIG = base.GetComponent<RectTransform>();
			this.ACAGIMIDKDC = new List<Transform>();
			this.BBJPPOHPPHO = new List<ReorderableListElement>();
			base.StartCoroutine(this.JGGJFAAMHII());
		}

		// Token: 0x06009EA3 RID: 40611 RVA: 0x003AEEEE File Offset: 0x003AD0EE
		public void KJBJBNGJDAD(ReorderableList PFKLCAKIKLH)
		{
			this.PDNNCIFOKJA = PFKLCAKIKLH;
			this.BBNGEJDDCIG = base.GetComponent<RectTransform>();
			this.ACAGIMIDKDC = new List<Transform>();
			this.BBJPPOHPPHO = new List<ReorderableListElement>();
			base.StartCoroutine(this.FIOAKEAFAMC());
		}

		// Token: 0x06009EA4 RID: 40612 RVA: 0x003AEF26 File Offset: 0x003AD126
		public void KJOACBOOOON()
		{
			base.StartCoroutine(this.LJPDPFHNAGC());
		}

		// Token: 0x06009EA5 RID: 40613 RVA: 0x003AEF35 File Offset: 0x003AD135
		public void HBKEHHCMMBN(ReorderableList PFKLCAKIKLH)
		{
			this.PDNNCIFOKJA = PFKLCAKIKLH;
			this.BBNGEJDDCIG = base.GetComponent<RectTransform>();
			this.ACAGIMIDKDC = new List<Transform>();
			this.BBJPPOHPPHO = new List<ReorderableListElement>();
			base.StartCoroutine(this.FIPKBEJGBOB());
		}

		// Token: 0x06009EA6 RID: 40614 RVA: 0x003AEE33 File Offset: 0x003AD033
		public void KKPELBCKFBM()
		{
			base.StartCoroutine(this.FIOAKEAFAMC());
		}

		// Token: 0x06009EA7 RID: 40615 RVA: 0x003AEDB3 File Offset: 0x003ACFB3
		public void JDHNKAPLGIO()
		{
			base.StartCoroutine(this.CODNCAOCDGJ());
		}

		// Token: 0x06009EA8 RID: 40616 RVA: 0x003AEF70 File Offset: 0x003AD170
		private IEnumerator ELPIDPIAABC()
		{
			for (int i = 0; i < this.BBNGEJDDCIG.childCount; i++)
			{
				if (!this.ACAGIMIDKDC.Contains(this.BBNGEJDDCIG.GetChild(i)))
				{
					this.GALFGJPPPDC = (this.BBNGEJDDCIG.GetChild(i).gameObject.GetComponent<ReorderableListElement>() ?? this.BBNGEJDDCIG.GetChild(i).gameObject.AddComponent<ReorderableListElement>());
					this.GALFGJPPPDC.Init(this.PDNNCIFOKJA);
					this.ACAGIMIDKDC.Add(this.BBNGEJDDCIG.GetChild(i));
					this.BBJPPOHPPHO.Add(this.GALFGJPPPDC);
				}
			}
			yield return 0;
			for (int j = this.ACAGIMIDKDC.Count - 1; j >= 0; j--)
			{
				if (this.ACAGIMIDKDC[j] == null)
				{
					this.ACAGIMIDKDC.RemoveAt(j);
					this.BBJPPOHPPHO.RemoveAt(j);
				}
			}
			yield break;
		}

		// Token: 0x06009EA9 RID: 40617 RVA: 0x003AEDB3 File Offset: 0x003ACFB3
		public void EHNAKOGGOAE()
		{
			base.StartCoroutine(this.CODNCAOCDGJ());
		}

		// Token: 0x06009EAA RID: 40618 RVA: 0x003AEE7A File Offset: 0x003AD07A
		public void CHLKFHFHMNG()
		{
			base.StartCoroutine(this.FDEAMAOALBD());
		}

		// Token: 0x06009EAB RID: 40619 RVA: 0x003AEF8C File Offset: 0x003AD18C
		private IEnumerator FIPKBEJGBOB()
		{
			for (int i = 0; i < this.BBNGEJDDCIG.childCount; i++)
			{
				if (!this.ACAGIMIDKDC.Contains(this.BBNGEJDDCIG.GetChild(i)))
				{
					this.GALFGJPPPDC = (this.BBNGEJDDCIG.GetChild(i).gameObject.GetComponent<ReorderableListElement>() ?? this.BBNGEJDDCIG.GetChild(i).gameObject.AddComponent<ReorderableListElement>());
					this.GALFGJPPPDC.Init(this.PDNNCIFOKJA);
					this.ACAGIMIDKDC.Add(this.BBNGEJDDCIG.GetChild(i));
					this.BBJPPOHPPHO.Add(this.GALFGJPPPDC);
				}
			}
			yield return 0;
			for (int j = this.ACAGIMIDKDC.Count - 1; j >= 0; j--)
			{
				if (this.ACAGIMIDKDC[j] == null)
				{
					this.ACAGIMIDKDC.RemoveAt(j);
					this.BBJPPOHPPHO.RemoveAt(j);
				}
			}
			yield break;
		}

		// Token: 0x06009EAC RID: 40620 RVA: 0x003AEFA8 File Offset: 0x003AD1A8
		private IEnumerator FDEAMAOALBD()
		{
			for (int i = 0; i < this.BBNGEJDDCIG.childCount; i++)
			{
				if (!this.ACAGIMIDKDC.Contains(this.BBNGEJDDCIG.GetChild(i)))
				{
					this.GALFGJPPPDC = (this.BBNGEJDDCIG.GetChild(i).gameObject.GetComponent<ReorderableListElement>() ?? this.BBNGEJDDCIG.GetChild(i).gameObject.AddComponent<ReorderableListElement>());
					this.GALFGJPPPDC.Init(this.PDNNCIFOKJA);
					this.ACAGIMIDKDC.Add(this.BBNGEJDDCIG.GetChild(i));
					this.BBJPPOHPPHO.Add(this.GALFGJPPPDC);
				}
			}
			yield return 0;
			for (int j = this.ACAGIMIDKDC.Count - 1; j >= 0; j--)
			{
				if (this.ACAGIMIDKDC[j] == null)
				{
					this.ACAGIMIDKDC.RemoveAt(j);
					this.BBJPPOHPPHO.RemoveAt(j);
				}
			}
			yield break;
		}

		// Token: 0x06009EAD RID: 40621 RVA: 0x003AEFC4 File Offset: 0x003AD1C4
		private IEnumerator FIOAKEAFAMC()
		{
			for (int i = 0; i < this.BBNGEJDDCIG.childCount; i++)
			{
				if (!this.ACAGIMIDKDC.Contains(this.BBNGEJDDCIG.GetChild(i)))
				{
					this.GALFGJPPPDC = (this.BBNGEJDDCIG.GetChild(i).gameObject.GetComponent<ReorderableListElement>() ?? this.BBNGEJDDCIG.GetChild(i).gameObject.AddComponent<ReorderableListElement>());
					this.GALFGJPPPDC.Init(this.PDNNCIFOKJA);
					this.ACAGIMIDKDC.Add(this.BBNGEJDDCIG.GetChild(i));
					this.BBJPPOHPPHO.Add(this.GALFGJPPPDC);
				}
			}
			yield return 0;
			for (int j = this.ACAGIMIDKDC.Count - 1; j >= 0; j--)
			{
				if (this.ACAGIMIDKDC[j] == null)
				{
					this.ACAGIMIDKDC.RemoveAt(j);
					this.BBJPPOHPPHO.RemoveAt(j);
				}
			}
			yield break;
		}

		// Token: 0x06009EAE RID: 40622 RVA: 0x003AEFE0 File Offset: 0x003AD1E0
		private IEnumerator JGGJFAAMHII()
		{
			for (int i = 0; i < this.BBNGEJDDCIG.childCount; i++)
			{
				if (!this.ACAGIMIDKDC.Contains(this.BBNGEJDDCIG.GetChild(i)))
				{
					this.GALFGJPPPDC = (this.BBNGEJDDCIG.GetChild(i).gameObject.GetComponent<ReorderableListElement>() ?? this.BBNGEJDDCIG.GetChild(i).gameObject.AddComponent<ReorderableListElement>());
					this.GALFGJPPPDC.Init(this.PDNNCIFOKJA);
					this.ACAGIMIDKDC.Add(this.BBNGEJDDCIG.GetChild(i));
					this.BBJPPOHPPHO.Add(this.GALFGJPPPDC);
				}
			}
			yield return 0;
			for (int j = this.ACAGIMIDKDC.Count - 1; j >= 0; j--)
			{
				if (this.ACAGIMIDKDC[j] == null)
				{
					this.ACAGIMIDKDC.RemoveAt(j);
					this.BBJPPOHPPHO.RemoveAt(j);
				}
			}
			yield break;
		}

		// Token: 0x04001220 RID: 4640
		private List<Transform> ACAGIMIDKDC;

		// Token: 0x04001221 RID: 4641
		private List<ReorderableListElement> BBJPPOHPPHO;

		// Token: 0x04001222 RID: 4642
		private ReorderableListElement GALFGJPPPDC;

		// Token: 0x04001223 RID: 4643
		private ReorderableList PDNNCIFOKJA;

		// Token: 0x04001224 RID: 4644
		private RectTransform BBNGEJDDCIG;
	}
}
