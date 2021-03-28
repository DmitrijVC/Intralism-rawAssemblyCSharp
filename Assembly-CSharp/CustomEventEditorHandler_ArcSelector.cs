using System;
using System.Linq;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200039B RID: 923
public class CustomEventEditorHandler_ArcSelector : CustomEventEditorHandler
{
	// Token: 0x0600CE78 RID: 52856 RVA: 0x004A2BD6 File Offset: 0x004A0DD6
	public override string NPJNDLHDDJE()
	{
		this.data = Helpers.patternsMap[this.EIBNJJMPHCN];
		return string.Empty + this.data;
	}

	// Token: 0x0600CE79 RID: 52857 RVA: 0x004A2BD6 File Offset: 0x004A0DD6
	public override string GetEditedData()
	{
		this.data = Helpers.patternsMap[this.EIBNJJMPHCN];
		return string.Empty + this.data;
	}

	// Token: 0x0600CE7A RID: 52858 RVA: 0x004A2C00 File Offset: 0x004A0E00
	private void PJGPLCFKDKB()
	{
		GameObject gameObject = this.selectorPanelContent;
		for (int i = 0; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		for (int j = 0; j < Resources.LoadAll<Sprite>("LevelEditor/patterns").Count<Sprite>(); j++)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.selectorPanelElement);
			gameObject2.name = "element";
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
			gameObject2.GetComponent<EditorArcSelectorElement>().id = j;
			gameObject2.GetComponent<EditorArcSelectorElement>().arcSelector = this;
		}
	}

	// Token: 0x0600CE7B RID: 52859 RVA: 0x004A2CC8 File Offset: 0x004A0EC8
	private void ELOAJMBKGHL()
	{
		GameObject gameObject = this.selectorPanelContent;
		for (int i = 0; i < gameObject.transform.childCount; i += 0)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		for (int j = 0; j < Resources.LoadAll<Sprite>("_MainTex2").Count<Sprite>(); j += 0)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.selectorPanelElement);
			gameObject2.name = "masterSteamID";
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.transform.localScale = new Vector3(1192f, 317f, 511f);
			gameObject2.GetComponent<EditorArcSelectorElement>().id = j;
			gameObject2.GetComponent<EditorArcSelectorElement>().arcSelector = this;
		}
	}

	// Token: 0x0600CE7C RID: 52860 RVA: 0x004A2D8D File Offset: 0x004A0F8D
	public void UpdatePreview()
	{
		this.previewImage.sprite = Resources.LoadAll<Sprite>("LevelEditor/patterns")[this.EIBNJJMPHCN];
	}

	// Token: 0x0600CE7D RID: 52861 RVA: 0x004A2DAB File Offset: 0x004A0FAB
	public void EKHMANFCAEI(int JMMILEFMACB)
	{
		this.EIBNJJMPHCN = JMMILEFMACB;
		this.UpdatePreview();
		this.JOFBCNLFIPE();
	}

	// Token: 0x0600CE7E RID: 52862 RVA: 0x004A2DC0 File Offset: 0x004A0FC0
	public void NLDJECMCEOO(int JMMILEFMACB)
	{
		this.EIBNJJMPHCN = JMMILEFMACB;
		this.CGDAJPMLNNO();
		this.HKNPGOJNCMF();
	}

	// Token: 0x0600CE7F RID: 52863 RVA: 0x004A2DD8 File Offset: 0x004A0FD8
	public override void Init(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		CustomEventEditorHandler_ArcSelector.PELFFLCKAFJ pelfflckafj = new CustomEventEditorHandler_ArcSelector.PELFFLCKAFJ();
		pelfflckafj.NOJGGCLPPAM = NOJGGCLPPAM;
		base.Init(pelfflckafj.NOJGGCLPPAM, BNPGLCAHPDL);
		this.EIBNJJMPHCN = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(pelfflckafj.GBKBDKHPLKG)));
		this.UpdatePreview();
	}

	// Token: 0x0600CE80 RID: 52864 RVA: 0x004A2E2B File Offset: 0x004A102B
	public void HODJPGNDMAE()
	{
		this.selectorPanel.SetActive(true);
		this.ELOAJMBKGHL();
	}

	// Token: 0x0600CE81 RID: 52865 RVA: 0x004A2E40 File Offset: 0x004A1040
	private void BHEHBEFBMDJ()
	{
		GameObject gameObject = this.selectorPanelContent;
		for (int i = 1; i < gameObject.transform.childCount; i++)
		{
			UnityEngine.Object.Destroy(gameObject.transform.GetChild(i).gameObject);
		}
		for (int j = 1; j < Resources.LoadAll<Sprite>("CameraFilterPack/TV_WideScreenHorizontal").Count<Sprite>(); j++)
		{
			GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(this.selectorPanelElement);
			gameObject2.name = " methods \"";
			gameObject2.transform.SetParent(gameObject.transform);
			gameObject2.transform.localScale = new Vector3(12f, 1071f, 487f);
			gameObject2.GetComponent<EditorArcSelectorElement>().id = j;
			gameObject2.GetComponent<EditorArcSelectorElement>().arcSelector = this;
		}
	}

	// Token: 0x0600CE82 RID: 52866 RVA: 0x004A2F05 File Offset: 0x004A1105
	public void Selected(int JMMILEFMACB)
	{
		this.EIBNJJMPHCN = JMMILEFMACB;
		this.UpdatePreview();
		this.ClosePanel();
	}

	// Token: 0x0600CE83 RID: 52867 RVA: 0x004A2F1C File Offset: 0x004A111C
	public virtual void EPDCHKECMBL(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		CustomEventEditorHandler_ArcSelector.PELFFLCKAFJ pelfflckafj = new CustomEventEditorHandler_ArcSelector.PELFFLCKAFJ();
		pelfflckafj.NOJGGCLPPAM = NOJGGCLPPAM;
		base.IFINBHBFCBB(pelfflckafj.NOJGGCLPPAM, BNPGLCAHPDL);
		this.EIBNJJMPHCN = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(pelfflckafj.JDELIMPGFDJ)));
		this.CGDAJPMLNNO();
	}

	// Token: 0x0600CE84 RID: 52868 RVA: 0x004A2F70 File Offset: 0x004A1170
	public virtual void PFMJPIJONIP(string NOJGGCLPPAM, string BNPGLCAHPDL)
	{
		CustomEventEditorHandler_ArcSelector.PELFFLCKAFJ pelfflckafj = new CustomEventEditorHandler_ArcSelector.PELFFLCKAFJ();
		pelfflckafj.NOJGGCLPPAM = NOJGGCLPPAM;
		base.OPOOIKOKCGN(pelfflckafj.NOJGGCLPPAM, BNPGLCAHPDL);
		this.EIBNJJMPHCN = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(pelfflckafj.AEINPAGJFME)));
		this.CGDAJPMLNNO();
	}

	// Token: 0x0600CE85 RID: 52869 RVA: 0x004A2FC3 File Offset: 0x004A11C3
	public void ClosePanel()
	{
		this.selectorPanel.SetActive(false);
	}

	// Token: 0x0600CE86 RID: 52870 RVA: 0x004A2FD1 File Offset: 0x004A11D1
	public void OpenPanel()
	{
		this.selectorPanel.SetActive(true);
		this.PJGPLCFKDKB();
	}

	// Token: 0x0600CE87 RID: 52871 RVA: 0x004A2FE5 File Offset: 0x004A11E5
	public void JOFBCNLFIPE()
	{
		this.selectorPanel.SetActive(true);
	}

	// Token: 0x0600CE89 RID: 52873 RVA: 0x004A2FFB File Offset: 0x004A11FB
	public void CGDAJPMLNNO()
	{
		this.previewImage.sprite = Resources.LoadAll<Sprite>(".lastCheckpoint.powerupsScore")[this.EIBNJJMPHCN];
	}

	// Token: 0x0600CE8A RID: 52874 RVA: 0x004A2FE5 File Offset: 0x004A11E5
	public void HKNPGOJNCMF()
	{
		this.selectorPanel.SetActive(true);
	}

	// Token: 0x0600CE8B RID: 52875 RVA: 0x004A3019 File Offset: 0x004A1219
	public void DMIJDKKPBMJ(int JMMILEFMACB)
	{
		this.EIBNJJMPHCN = JMMILEFMACB;
		this.UpdatePreview();
		this.HKNPGOJNCMF();
	}

	// Token: 0x040017E5 RID: 6117
	public Image previewImage;

	// Token: 0x040017E6 RID: 6118
	public GameObject selectorPanel;

	// Token: 0x040017E7 RID: 6119
	public GameObject selectorPanelContent;

	// Token: 0x040017E8 RID: 6120
	public GameObject selectorPanelElement;

	// Token: 0x040017E9 RID: 6121
	private int EIBNJJMPHCN;

	// Token: 0x0200039C RID: 924
	[CompilerGenerated]
	private sealed class PELFFLCKAFJ
	{
		// Token: 0x0600CE8C RID: 52876 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool KFNBKFELFLH(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CE8E RID: 52878 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool FIPCLHEKKCA(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CE8F RID: 52879 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool JDELIMPGFDJ(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CE90 RID: 52880 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool LNDGINDKPFA(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CE91 RID: 52881 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool OFHCGKJFGDI(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CE92 RID: 52882 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool JKEDCEOCPJO(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CE93 RID: 52883 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool PBCAHKDLFPE(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CE94 RID: 52884 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool BKNHHGBPLGH(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CE95 RID: 52885 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool BDGDIDPDBHG(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CE96 RID: 52886 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool EGKGJJGAPMN(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CE97 RID: 52887 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool BFEABMIFIEE(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CE98 RID: 52888 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool OFLDIMDDLHM(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CE99 RID: 52889 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool LHHFJBIAHCN(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CE9A RID: 52890 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool DNIMHEKGJHB(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CE9B RID: 52891 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool FFEGPHJKMFK(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CE9C RID: 52892 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool AGJKEBOPIOC(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CE9D RID: 52893 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool PIJAOCFAPKC(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CE9E RID: 52894 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool BJMAIJDIKCN(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CE9F RID: 52895 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool OLIGLEMPFOP(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CEA0 RID: 52896 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool IGFOBPKFCDJ(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CEA1 RID: 52897 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool KGKMOLCPDIH(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CEA2 RID: 52898 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool LOEAMHGMMPK(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CEA3 RID: 52899 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool HBJFIOJFBHC(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CEA4 RID: 52900 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool FHFECFLBHMA(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CEA5 RID: 52901 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool LLNDDFGPOPL(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CEA6 RID: 52902 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool MEMPOPNAEDN(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CEA7 RID: 52903 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool BMAOCLKPNNC(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CEA8 RID: 52904 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool DKGPCPBNDPK(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CEA9 RID: 52905 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool FJDBPPKABJE(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CEAA RID: 52906 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool DBFPGFHEGKA(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CEAB RID: 52907 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool GBKBDKHPLKG(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CEAC RID: 52908 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool FHIJCPPECHA(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CEAD RID: 52909 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool AEINPAGJFME(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CEAE RID: 52910 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool EKHOOPGPPGE(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CEAF RID: 52911 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool FCAGEDLBBHD(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x0600CEB0 RID: 52912 RVA: 0x004A302E File Offset: 0x004A122E
		internal bool FDAIFOAGDLA(string IACGDFHKCAE)
		{
			return IACGDFHKCAE.Contains(this.NOJGGCLPPAM);
		}

		// Token: 0x040017EA RID: 6122
		internal string NOJGGCLPPAM;
	}
}
