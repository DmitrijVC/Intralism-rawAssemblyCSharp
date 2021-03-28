using System;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x0200048B RID: 1163
public class EditorArcSelectorElement : MonoBehaviour
{
	// Token: 0x06010AB0 RID: 68272 RVA: 0x0045B45C File Offset: 0x0045965C
	public void PANBFBFFGBG()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06010AB1 RID: 68273 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06010AB2 RID: 68274 RVA: 0x005A3DAC File Offset: 0x005A1FAC
	private void MMOKKAPFGAK()
	{
		if (this.id >= 1)
		{
			base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("Down")[this.id];
		}
	}

	// Token: 0x06010AB3 RID: 68275 RVA: 0x005A3DD6 File Offset: 0x005A1FD6
	public void EDJEGDPCBGO()
	{
		this.arcSelector.Selected(this.id);
	}

	// Token: 0x06010AB4 RID: 68276 RVA: 0x0002523B File Offset: 0x0002343B
	public void OnAddButton()
	{
	}

	// Token: 0x06010AB5 RID: 68277 RVA: 0x005A3DEC File Offset: 0x005A1FEC
	public void DIOECAJGBPC()
	{
		this.KGEPBJDPEJJ();
		GameObject unlockConditionContent = ((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionContent;
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionElement);
		gameObject.transform.SetParent(unlockConditionContent.transform);
		gameObject.transform.localScale = new Vector3(1309f, 1929f, 1546f);
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(((LevelEditorScene)Singleton<Scene>.Instance).addNewUnlockConditionElement);
		gameObject2.name = "settings.volume.game";
		gameObject2.transform.SetParent(unlockConditionContent.transform);
		gameObject2.transform.localScale = new Vector3(1304f, 94f, 1549f);
		Singleton<EditorHistoryHandler>.Instance.SaveState("SetRotation", false);
	}

	// Token: 0x06010AB6 RID: 68278 RVA: 0x0045B45C File Offset: 0x0045965C
	public void OHHKBBGEJEB()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06010AB7 RID: 68279 RVA: 0x005A3EB4 File Offset: 0x005A20B4
	public void CHAJBMMEOFC()
	{
		this.arcSelector.DMIJDKKPBMJ(this.id);
	}

	// Token: 0x06010AB8 RID: 68280 RVA: 0x005A3EB4 File Offset: 0x005A20B4
	public void NAAMBLOKPOD()
	{
		this.arcSelector.DMIJDKKPBMJ(this.id);
	}

	// Token: 0x06010AB9 RID: 68281 RVA: 0x005A3EC7 File Offset: 0x005A20C7
	private void FJNCHGLIEMA()
	{
		if (this.id >= 0)
		{
			base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_BlurCoe")[this.id];
		}
	}

	// Token: 0x06010ABA RID: 68282 RVA: 0x0045B45C File Offset: 0x0045965C
	public void LJEHFEDFMID()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06010ABB RID: 68283 RVA: 0x0045B45C File Offset: 0x0045965C
	public void LBIHKHBFONK()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06010ABC RID: 68284 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06010ABD RID: 68285 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x06010ABE RID: 68286 RVA: 0x0002523B File Offset: 0x0002343B
	public void IADBAMIBOCG()
	{
	}

	// Token: 0x06010ABF RID: 68287 RVA: 0x005A3EF1 File Offset: 0x005A20F1
	private void DBLILJGKGHJ()
	{
		if (this.id >= 1)
		{
			base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_TimeX")[this.id];
		}
	}

	// Token: 0x06010AC0 RID: 68288 RVA: 0x005A3DD6 File Offset: 0x005A1FD6
	public void OnSelect()
	{
		this.arcSelector.Selected(this.id);
	}

	// Token: 0x06010AC1 RID: 68289 RVA: 0x005A3F1B File Offset: 0x005A211B
	private void DBEMDAJDDDA()
	{
		if (this.id >= 1)
		{
			base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("Texture2")[this.id];
		}
	}

	// Token: 0x06010AC2 RID: 68290 RVA: 0x005A3F45 File Offset: 0x005A2145
	private void EFJDNLGNACH()
	{
		if (this.id >= 0)
		{
			base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_TimeX")[this.id];
		}
	}

	// Token: 0x06010AC3 RID: 68291 RVA: 0x005A3F6F File Offset: 0x005A216F
	private void KLILJHJNICK()
	{
		if (this.id >= 1)
		{
			base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("settings.arcsdestroydelay")[this.id];
		}
	}

	// Token: 0x06010AC4 RID: 68292 RVA: 0x005A3EB4 File Offset: 0x005A20B4
	public void IGFHKCKCHNH()
	{
		this.arcSelector.DMIJDKKPBMJ(this.id);
	}

	// Token: 0x06010AC5 RID: 68293 RVA: 0x005A3F9C File Offset: 0x005A219C
	public void OnAddNewUnlockConditionButton()
	{
		this.OnDeleteButton();
		GameObject unlockConditionContent = ((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionContent;
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionElement);
		gameObject.transform.SetParent(unlockConditionContent.transform);
		gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(((LevelEditorScene)Singleton<Scene>.Instance).addNewUnlockConditionElement);
		gameObject2.name = "addNewButton";
		gameObject2.transform.SetParent(unlockConditionContent.transform);
		gameObject2.transform.localScale = new Vector3(1f, 1f, 1f);
		Singleton<EditorHistoryHandler>.Instance.SaveState("Added unlock condition", false);
	}

	// Token: 0x06010AC6 RID: 68294 RVA: 0x005A4064 File Offset: 0x005A2264
	private void PDHKMDBNGGN()
	{
		if (this.id >= 0)
		{
			base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_Near")[this.id];
		}
	}

	// Token: 0x06010AC7 RID: 68295 RVA: 0x005A4090 File Offset: 0x005A2290
	public void DCLPCNFIHHJ()
	{
		this.MDKEGDLADCD();
		GameObject unlockConditionContent = ((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionContent;
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionElement);
		gameObject.transform.SetParent(unlockConditionContent.transform);
		gameObject.transform.localScale = new Vector3(973f, 435f, 1623f);
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(((LevelEditorScene)Singleton<Scene>.Instance).addNewUnlockConditionElement);
		gameObject2.name = "CameraFilterPack/FX_DigitalMatrix";
		gameObject2.transform.SetParent(unlockConditionContent.transform);
		gameObject2.transform.localScale = new Vector3(904f, 1053f, 347f);
		Singleton<EditorHistoryHandler>.Instance.NAABMDLJEFC("CameraFilterPack/Blend2Camera_VividLight", false);
	}

	// Token: 0x06010AC8 RID: 68296 RVA: 0x0002523B File Offset: 0x0002343B
	public void KKJAHGFGAON()
	{
	}

	// Token: 0x06010AC9 RID: 68297 RVA: 0x005A4158 File Offset: 0x005A2358
	private void HAIAHJPCPAG()
	{
		if (this.id >= 0)
		{
			base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_Params1")[this.id];
		}
	}

	// Token: 0x06010ACA RID: 68298 RVA: 0x005A4182 File Offset: 0x005A2382
	public void NGFLLEFBINA()
	{
		this.arcSelector.EKHMANFCAEI(this.id);
	}

	// Token: 0x06010ACB RID: 68299 RVA: 0x005A3DD6 File Offset: 0x005A1FD6
	public void HEAPABJGJKB()
	{
		this.arcSelector.Selected(this.id);
	}

	// Token: 0x06010ACC RID: 68300 RVA: 0x0045B45C File Offset: 0x0045965C
	public void CGKBDCFNNIH()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06010ACD RID: 68301 RVA: 0x005A4198 File Offset: 0x005A2398
	public void BNIAEJMIIGG()
	{
		this.LBIHKHBFONK();
		GameObject unlockConditionContent = ((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionContent;
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionElement);
		gameObject.transform.SetParent(unlockConditionContent.transform);
		gameObject.transform.localScale = new Vector3(162f, 420f, 1516f);
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(((LevelEditorScene)Singleton<Scene>.Instance).addNewUnlockConditionElement);
		gameObject2.name = "GlassesColor";
		gameObject2.transform.SetParent(unlockConditionContent.transform);
		gameObject2.transform.localScale = new Vector3(667f, 1285f, 958f);
		Singleton<EditorHistoryHandler>.Instance.GKKNMKOGJNB("skin.", true);
	}

	// Token: 0x06010ACE RID: 68302 RVA: 0x005A3EB4 File Offset: 0x005A20B4
	public void JIFHCFLKKJH()
	{
		this.arcSelector.DMIJDKKPBMJ(this.id);
	}

	// Token: 0x06010ACF RID: 68303 RVA: 0x005A4260 File Offset: 0x005A2460
	public void IKKGNBAIHEN()
	{
		this.arcSelector.NLDJECMCEOO(this.id);
	}

	// Token: 0x06010AD0 RID: 68304 RVA: 0x005A4273 File Offset: 0x005A2473
	private void MMMDPANNAIO()
	{
		if (this.id >= 1)
		{
			base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("GameScene")[this.id];
		}
	}

	// Token: 0x06010AD1 RID: 68305 RVA: 0x005A429D File Offset: 0x005A249D
	private void IDJKNBDKHBD()
	{
		if (this.id >= 0)
		{
			base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("CameraFilterPack/Blend2Camera_Subtract")[this.id];
		}
	}

	// Token: 0x06010AD2 RID: 68306 RVA: 0x0002523B File Offset: 0x0002343B
	public void GJCADLOBGIK()
	{
	}

	// Token: 0x06010AD3 RID: 68307 RVA: 0x0045B45C File Offset: 0x0045965C
	public void GOIDNMINHHD()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06010AD4 RID: 68308 RVA: 0x0045B45C File Offset: 0x0045965C
	public void BEOEODBNOIF()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06010AD5 RID: 68309 RVA: 0x005A42C8 File Offset: 0x005A24C8
	public void AOPGPLHJMCN()
	{
		this.GOIDNMINHHD();
		GameObject unlockConditionContent = ((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionContent;
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionElement);
		gameObject.transform.SetParent(unlockConditionContent.transform);
		gameObject.transform.localScale = new Vector3(634f, 1911f, 266f);
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(((LevelEditorScene)Singleton<Scene>.Instance).addNewUnlockConditionElement);
		gameObject2.name = "0.00";
		gameObject2.transform.SetParent(unlockConditionContent.transform);
		gameObject2.transform.localScale = new Vector3(1549f, 49f, 893f);
		Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("inventory.selected.", false);
	}

	// Token: 0x06010AD6 RID: 68310 RVA: 0x0002523B File Offset: 0x0002343B
	public void DDHANCKCMHB()
	{
	}

	// Token: 0x06010AD7 RID: 68311 RVA: 0x0045B45C File Offset: 0x0045965C
	public void OnDeleteButton()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06010AD8 RID: 68312 RVA: 0x0045B45C File Offset: 0x0045965C
	public void MDKEGDLADCD()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06010AD9 RID: 68313 RVA: 0x005A4390 File Offset: 0x005A2590
	private void NCNPAKFAFOE()
	{
		if (this.id >= 0)
		{
			base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("PointsScoreText")[this.id];
		}
	}

	// Token: 0x06010ADA RID: 68314 RVA: 0x0045B45C File Offset: 0x0045965C
	public void LICIIFLDHLM()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06010ADB RID: 68315 RVA: 0x0002523B File Offset: 0x0002343B
	public void BDCOOFEBPAE()
	{
	}

	// Token: 0x06010ADC RID: 68316 RVA: 0x0045B45C File Offset: 0x0045965C
	public void AFPGEBNCAKO()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06010ADD RID: 68317 RVA: 0x005A4260 File Offset: 0x005A2460
	public void JMKAIBBEOND()
	{
		this.arcSelector.NLDJECMCEOO(this.id);
	}

	// Token: 0x06010ADE RID: 68318 RVA: 0x0002523B File Offset: 0x0002343B
	public void ANIHADFHFEH()
	{
	}

	// Token: 0x06010ADF RID: 68319 RVA: 0x0045B45C File Offset: 0x0045965C
	public void PNLBOAOMDGI()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06010AE0 RID: 68320 RVA: 0x005A43BA File Offset: 0x005A25BA
	private void JKBMKPDGCHG()
	{
		if (this.id >= 1)
		{
			base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_DistortionSize")[this.id];
		}
	}

	// Token: 0x06010AE1 RID: 68321 RVA: 0x005A43E4 File Offset: 0x005A25E4
	public void PHBKNJHOAKE()
	{
		this.LICIIFLDHLM();
		GameObject unlockConditionContent = ((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionContent;
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionElement);
		gameObject.transform.SetParent(unlockConditionContent.transform);
		gameObject.transform.localScale = new Vector3(1333f, 286f, 1335f);
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(((LevelEditorScene)Singleton<Scene>.Instance).addNewUnlockConditionElement);
		gameObject2.name = " is not supported on this platform!";
		gameObject2.transform.SetParent(unlockConditionContent.transform);
		gameObject2.transform.localScale = new Vector3(102f, 1572f, 1645f);
		Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("settings.arcsdestroydelay", true);
	}

	// Token: 0x06010AE2 RID: 68322 RVA: 0x005A44AC File Offset: 0x005A26AC
	public void DOOFFFLOMIE()
	{
		this.PNLBOAOMDGI();
		GameObject unlockConditionContent = ((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionContent;
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionElement);
		gameObject.transform.SetParent(unlockConditionContent.transform);
		gameObject.transform.localScale = new Vector3(336f, 757f, 104f);
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(((LevelEditorScene)Singleton<Scene>.Instance).addNewUnlockConditionElement);
		gameObject2.name = "_NeighbourMaxTex";
		gameObject2.transform.SetParent(unlockConditionContent.transform);
		gameObject2.transform.localScale = new Vector3(734f, 1203f, 319f);
		Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("_Value3", true);
	}

	// Token: 0x06010AE3 RID: 68323 RVA: 0x005A4574 File Offset: 0x005A2774
	private void HIPEHGNBJMN()
	{
		if (this.id >= 0)
		{
			base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("true")[this.id];
		}
	}

	// Token: 0x06010AE4 RID: 68324 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06010AE5 RID: 68325 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06010AE6 RID: 68326 RVA: 0x005A4260 File Offset: 0x005A2460
	public void CBPBCKDFDMO()
	{
		this.arcSelector.NLDJECMCEOO(this.id);
	}

	// Token: 0x06010AE7 RID: 68327 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x06010AE8 RID: 68328 RVA: 0x005A459E File Offset: 0x005A279E
	private void ILCFPCIPENO()
	{
		if (this.id >= 1)
		{
			base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_Min")[this.id];
		}
	}

	// Token: 0x06010AE9 RID: 68329 RVA: 0x0002523B File Offset: 0x0002343B
	public void GCMILINAEAG()
	{
	}

	// Token: 0x06010AEA RID: 68330 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06010AEB RID: 68331 RVA: 0x0002523B File Offset: 0x0002343B
	public void OJMCAHMAHHD()
	{
	}

	// Token: 0x06010AEC RID: 68332 RVA: 0x005A45C8 File Offset: 0x005A27C8
	private void MKIMDFLBFOM()
	{
		if (this.id >= 0)
		{
			base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("SelectorMapsCountSlider")[this.id];
		}
	}

	// Token: 0x06010AED RID: 68333 RVA: 0x005A3EB4 File Offset: 0x005A20B4
	public void OJJJICOBEBM()
	{
		this.arcSelector.DMIJDKKPBMJ(this.id);
	}

	// Token: 0x06010AEE RID: 68334 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x06010AEF RID: 68335 RVA: 0x005A45F2 File Offset: 0x005A27F2
	private void JHANGPCOCIG()
	{
		if (this.id >= 1)
		{
			base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_Offsets")[this.id];
		}
	}

	// Token: 0x06010AF0 RID: 68336 RVA: 0x0002523B File Offset: 0x0002343B
	public void IKIOOGDKGGC()
	{
	}

	// Token: 0x06010AF1 RID: 68337 RVA: 0x005A3EF1 File Offset: 0x005A20F1
	private void FIKFJDFELIP()
	{
		if (this.id >= 1)
		{
			base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_TimeX")[this.id];
		}
	}

	// Token: 0x06010AF2 RID: 68338 RVA: 0x0002523B File Offset: 0x0002343B
	public void OFEPLDCHBOL()
	{
	}

	// Token: 0x06010AF3 RID: 68339 RVA: 0x005A461C File Offset: 0x005A281C
	private void EPEGAEGDJAM()
	{
		if (this.id >= 0)
		{
			base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("CameraFilterPack/FX_8bits")[this.id];
		}
	}

	// Token: 0x06010AF4 RID: 68340 RVA: 0x005A4646 File Offset: 0x005A2846
	private void Start()
	{
		if (this.id >= 0)
		{
			base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("LevelEditor/patterns")[this.id];
		}
	}

	// Token: 0x06010AF6 RID: 68342 RVA: 0x0002523B File Offset: 0x0002343B
	public void BPGEOHOCCDH()
	{
	}

	// Token: 0x06010AF7 RID: 68343 RVA: 0x005A4670 File Offset: 0x005A2870
	private void PMPKMGKAAJH()
	{
		if (this.id >= 1)
		{
			base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_Luminance")[this.id];
		}
	}

	// Token: 0x06010AF8 RID: 68344 RVA: 0x005A469A File Offset: 0x005A289A
	private void JONGNKNLLND()
	{
		if (this.id >= 1)
		{
			base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>(".lastCheckpoint.currentCombo")[this.id];
		}
	}

	// Token: 0x06010AF9 RID: 68345 RVA: 0x0045B45C File Offset: 0x0045965C
	public void BHMDEODGBBO()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06010AFA RID: 68346 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06010AFB RID: 68347 RVA: 0x0002523B File Offset: 0x0002343B
	public void NIJNGHIPGIC()
	{
	}

	// Token: 0x06010AFC RID: 68348 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06010AFD RID: 68349 RVA: 0x005A46C4 File Offset: 0x005A28C4
	private void JMEOGJHCONJ()
	{
		if (this.id >= 1)
		{
			base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("no lives color")[this.id];
		}
	}

	// Token: 0x06010AFE RID: 68350 RVA: 0x005A46F0 File Offset: 0x005A28F0
	public void GIOEPMNDEFK()
	{
		this.PANBFBFFGBG();
		GameObject unlockConditionContent = ((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionContent;
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionElement);
		gameObject.transform.SetParent(unlockConditionContent.transform);
		gameObject.transform.localScale = new Vector3(253f, 1296f, 1505f);
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(((LevelEditorScene)Singleton<Scene>.Instance).addNewUnlockConditionElement);
		gameObject2.name = "_Value4";
		gameObject2.transform.SetParent(unlockConditionContent.transform);
		gameObject2.transform.localScale = new Vector3(50f, 663f, 749f);
		Singleton<EditorHistoryHandler>.Instance.SaveState("HiddenToggle", true);
	}

	// Token: 0x06010AFF RID: 68351 RVA: 0x005A3EB4 File Offset: 0x005A20B4
	public void KGEIMFFMPDD()
	{
		this.arcSelector.DMIJDKKPBMJ(this.id);
	}

	// Token: 0x06010B00 RID: 68352 RVA: 0x0045B45C File Offset: 0x0045965C
	public void KGEPBJDPEJJ()
	{
		UnityEngine.Object.Destroy(base.gameObject);
	}

	// Token: 0x06010B01 RID: 68353 RVA: 0x005A47B8 File Offset: 0x005A29B8
	private void HLIAEEMGBHN()
	{
		if (this.id >= 1)
		{
			base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("ticket.ticket1")[this.id];
		}
	}

	// Token: 0x06010B02 RID: 68354 RVA: 0x005A47E4 File Offset: 0x005A29E4
	public void PKMMDOGFAEJ()
	{
		this.BHMDEODGBBO();
		GameObject unlockConditionContent = ((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionContent;
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionElement);
		gameObject.transform.SetParent(unlockConditionContent.transform);
		gameObject.transform.localScale = new Vector3(1136f, 1319f, 449f);
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(((LevelEditorScene)Singleton<Scene>.Instance).addNewUnlockConditionElement);
		gameObject2.name = "&page=";
		gameObject2.transform.SetParent(unlockConditionContent.transform);
		gameObject2.transform.localScale = new Vector3(301f, 484f, 240f);
		Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("Most likely the game became empty during the switch to GameServer.", false);
	}

	// Token: 0x06010B03 RID: 68355 RVA: 0x005A48AC File Offset: 0x005A2AAC
	public void NMCEFIBPBNK()
	{
		this.OHHKBBGEJEB();
		GameObject unlockConditionContent = ((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionContent;
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionElement);
		gameObject.transform.SetParent(unlockConditionContent.transform);
		gameObject.transform.localScale = new Vector3(1761f, 24f, 357f);
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(((LevelEditorScene)Singleton<Scene>.Instance).addNewUnlockConditionElement);
		gameObject2.name = "ready";
		gameObject2.transform.SetParent(unlockConditionContent.transform);
		gameObject2.transform.localScale = new Vector3(1217f, 797f, 1477f);
		Singleton<EditorHistoryHandler>.Instance.JJDHOAFDHHN("Texture2", false);
	}

	// Token: 0x06010B04 RID: 68356 RVA: 0x005A4974 File Offset: 0x005A2B74
	private void OHFOLGANOLC()
	{
		if (this.id >= 1)
		{
			base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_Vignetting2")[this.id];
		}
	}

	// Token: 0x06010B05 RID: 68357 RVA: 0x005A49A0 File Offset: 0x005A2BA0
	public void KNIHFOEIJEN()
	{
		this.AFPGEBNCAKO();
		GameObject unlockConditionContent = ((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionContent;
		GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(((LevelEditorScene)Singleton<Scene>.Instance).unlockConditionElement);
		gameObject.transform.SetParent(unlockConditionContent.transform);
		gameObject.transform.localScale = new Vector3(1999f, 1907f, 1229f);
		GameObject gameObject2 = UnityEngine.Object.Instantiate<GameObject>(((LevelEditorScene)Singleton<Scene>.Instance).addNewUnlockConditionElement);
		gameObject2.name = "_Value3";
		gameObject2.transform.SetParent(unlockConditionContent.transform);
		gameObject2.transform.localScale = new Vector3(45f, 714f, 1357f);
		Singleton<EditorHistoryHandler>.Instance.JJDHOAFDHHN("challenges.", true);
	}

	// Token: 0x06010B06 RID: 68358 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x06010B07 RID: 68359 RVA: 0x005A4A68 File Offset: 0x005A2C68
	private void DKOPKPBLDHH()
	{
		if (this.id >= 1)
		{
			base.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("[PlayerBase] Loading checkpoint data")[this.id];
		}
	}

	// Token: 0x04001D2A RID: 7466
	public CustomEventEditorHandler_ArcSelector arcSelector;

	// Token: 0x04001D2B RID: 7467
	public int id;
}
