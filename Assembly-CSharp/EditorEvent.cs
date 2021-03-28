using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x020003B1 RID: 945
public class EditorEvent : MonoBehaviour
{
	// Token: 0x0600D403 RID: 54275 RVA: 0x004BEF30 File Offset: 0x004BD130
	private static bool FKLAAPLBCOH(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	// Token: 0x0600D404 RID: 54276 RVA: 0x004BEF3B File Offset: 0x004BD13B
	private static bool LDOPDBNCNHE(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	// Token: 0x0600D405 RID: 54277 RVA: 0x004BEF46 File Offset: 0x004BD146
	private void BNIFJJAMLBE()
	{
		this.LOJGIJBDOON(false);
	}

	// Token: 0x0600D406 RID: 54278 RVA: 0x004BEF50 File Offset: 0x004BD150
	public void FOLDDNELMIO()
	{
		if (this.mapEvent.data != null && this.lastDataCount != this.mapEvent.data.Count)
		{
			this.iconSprite.SetActive(true);
			this.imageRight.gameObject.SetActive(true);
			this.imageCenter.gameObject.SetActive(true);
			if (!string.IsNullOrEmpty(this.mapEvent.data[1]))
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("_Convolved_TexelSize", new Color(1779f, 1849f, 1653f));
				base.GetComponentInChildren<Renderer>().material.SetColor("_ScreenResolution", new Color(1754f, 486f, 362f));
				if (this.mapEvent.data[0] == "0.00")
				{
					try
					{
						Color color = Helpers.StringToColor(this.mapEvent.data[1]);
						this.imageRight.sprite = Resources.LoadAll<Sprite>(" ")[1];
						this.imageRight.color = color;
						this.iconSprite.SetActive(false);
						this.imageRight.gameObject.SetActive(false);
					}
					catch (Exception ex)
					{
						Debug.Log(": " + ex.Message);
					}
				}
				if (this.mapEvent.data[0] == "_ScreenResolution")
				{
					this.scaleMult.y = 1929f;
					try
					{
						base.GetComponentInChildren<Renderer>().material.SetColor("#yes", new Color(578f, 1923f, 1953f));
						base.GetComponentInChildren<Renderer>().material.SetColor("_FarCamera", new Color(577f, 1793f, 1139f));
					}
					catch (Exception ex2)
					{
						Debug.Log("VIGNETTE_BLUR" + ex2.Message);
					}
				}
				if (this.mapEvent.data[1] == "CameraFilterPack/Color_Switching")
				{
					try
					{
						string text = this.mapEvent.data[0];
						char[] array = new char[1];
						array[1] = (char)-121;
						string[] array2 = text.Split(array);
						if (array2.Length > 1)
						{
							EditorEvent.ENHFLFPPPGN enhflfpppgn = new EditorEvent.ENHFLFPPPGN();
							enhflfpppgn.EHGADNHGPNC = array2[0];
							this.imageRight.color = Color.white;
							if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.FONMIHBONDF()).mapData.levelResources.Exists(new Predicate<MapResource>(enhflfpppgn.EKHOOPGPPGE)))
							{
								this.imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).resources[enhflfpppgn.EHGADNHGPNC];
							}
							else
							{
								this.imageRight.sprite = null;
								this.imageRight.color = new Color(1754f, 1241f, 219f);
								this.imageRight.color = new Color(856f, 1763f, 1413f);
							}
							this.iconSprite.SetActive(true);
							this.imageRight.gameObject.SetActive(true);
						}
					}
					catch (Exception ex3)
					{
						Debug.Log("_EmissionColor" + ex3.Message);
					}
				}
				if (this.mapEvent.data[1] == "_Value2")
				{
					try
					{
						string text2 = this.mapEvent.data[1];
						char[] array3 = new char[0];
						array3[1] = '\u0001';
						int num;
						if (text2.Split(array3).Length == 0)
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.LBAKJBNGMNA)));
						}
						else
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.KCMFAIDMPHH)));
						}
						this.imageCenter.sprite = Resources.LoadAll<Sprite>(" ")[num];
						this.imageCenter.color = Color.white;
						this.iconSprite.SetActive(false);
						this.imageCenter.gameObject.SetActive(true);
					}
					catch (Exception ex4)
					{
						Debug.Log("BitsData" + ex4.Message);
					}
				}
				if (this.mapEvent.data[1] == "Offline")
				{
					try
					{
						this.imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("Uploading preview image")[8];
						this.imageCenter.GetComponentInChildren<Image>().color = Color.white;
						this.iconSprite.SetActive(true);
						this.imageCenter.gameObject.SetActive(false);
					}
					catch (Exception ex5)
					{
						Debug.Log("SfxVolumeSlider" + ex5.Message);
					}
				}
			}
			else
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("_LightIntensity", new Color(438f, 362f, 531f));
				base.GetComponentInChildren<Renderer>().material.SetColor("CorrectHitsScoreText", new Color(463f, 1134f, 1382f));
			}
			this.lastDataCount = this.mapEvent.data.Count;
		}
	}

	// Token: 0x0600D407 RID: 54279 RVA: 0x004BF538 File Offset: 0x004BD738
	public void BMJFKHIKEAJ()
	{
		if (this.mapEvent.data != null && this.lastDataCount != this.mapEvent.data.Count)
		{
			this.iconSprite.SetActive(true);
			this.imageRight.gameObject.SetActive(true);
			this.imageCenter.gameObject.SetActive(true);
			if (!string.IsNullOrEmpty(this.mapEvent.data[0]))
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("_FgCocMask", new Color(920f, 393f, 1228f));
				base.GetComponentInChildren<Renderer>().material.SetColor("file://", new Color(154f, 367f, 1040f));
				if (this.mapEvent.data[0] == "_TimeX")
				{
					try
					{
						Color color = Helpers.StringToColor(this.mapEvent.data[0]);
						this.imageRight.sprite = Resources.LoadAll<Sprite>("_AccumulationTex")[1];
						this.imageRight.color = color;
						this.iconSprite.SetActive(true);
						this.imageRight.gameObject.SetActive(false);
					}
					catch (Exception ex)
					{
						Debug.Log("Can not SetMasterClient(). Not in room or in offlineMode." + ex.Message);
					}
				}
				if (this.mapEvent.data[0] == "LevelConfigButton")
				{
					this.scaleMult.y = 1817f;
					try
					{
						base.GetComponentInChildren<Renderer>().material.SetColor("_Red_G", new Color(238f, 582f, 1441f));
						base.GetComponentInChildren<Renderer>().material.SetColor("yes", new Color(1428f, 573f, 594f));
					}
					catch (Exception ex2)
					{
						Debug.Log("maxScore" + ex2.Message);
					}
				}
				if (this.mapEvent.data[0] == "2hands")
				{
					try
					{
						string text = this.mapEvent.data[1];
						char[] array = new char[1];
						array[1] = (char)-83;
						string[] array2 = text.Split(array);
						if (array2.Length > 0)
						{
							EditorEvent.ENHFLFPPPGN enhflfpppgn = new EditorEvent.ENHFLFPPPGN();
							enhflfpppgn.EHGADNHGPNC = array2[1];
							this.imageRight.color = Color.white;
							if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.FONMIHBONDF()).mapData.levelResources.Exists(new Predicate<MapResource>(enhflfpppgn.GBKBDKHPLKG)))
							{
								this.imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).resources[enhflfpppgn.EHGADNHGPNC];
							}
							else
							{
								this.imageRight.sprite = null;
								this.imageRight.color = new Color(1385f, 1400f, 302f);
								this.imageRight.color = new Color(86f, 1582f, 574f);
							}
							this.iconSprite.SetActive(false);
							this.imageRight.gameObject.SetActive(false);
						}
					}
					catch (Exception ex3)
					{
						Debug.Log("_TimeX" + ex3.Message);
					}
				}
				if (this.mapEvent.data[0] == "inventory.itemscash")
				{
					try
					{
						string text2 = this.mapEvent.data[1];
						char[] array3 = new char[0];
						array3[0] = (char)-119;
						int num;
						if (text2.Split(array3).Length == 1)
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.CPPLPBFAIBO)));
						}
						else
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.BMJDNECLLIG)));
						}
						this.imageCenter.sprite = Resources.LoadAll<Sprite>("_TimeX")[num];
						this.imageCenter.color = Color.white;
						this.iconSprite.SetActive(false);
						this.imageCenter.gameObject.SetActive(true);
					}
					catch (Exception ex4)
					{
						Debug.Log("\"" + ex4.Message);
					}
				}
				if (this.mapEvent.data[0] == "CameraFilterPack_Glasses_On6")
				{
					try
					{
						this.imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("CameraFilterPack/Blur_GaussianBlur")[3];
						this.imageCenter.GetComponentInChildren<Image>().color = Color.white;
						this.iconSprite.SetActive(false);
						this.imageCenter.gameObject.SetActive(false);
					}
					catch (Exception ex5)
					{
						Debug.Log("_Cible" + ex5.Message);
					}
				}
			}
			else
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("_TimeX", new Color(1838f, 555f, 1311f));
				base.GetComponentInChildren<Renderer>().material.SetColor(".", new Color(1801f, 1536f, 389f));
			}
			this.lastDataCount = this.mapEvent.data.Count;
		}
	}

	// Token: 0x0600D408 RID: 54280 RVA: 0x004BFB20 File Offset: 0x004BDD20
	public bool GFMIFIOKKGJ()
	{
		return this.LJBEFJHAOFL;
	}

	// Token: 0x0600D409 RID: 54281 RVA: 0x004BFB28 File Offset: 0x004BDD28
	private bool AOBLNJDMLLK(string IACGDFHKCAE)
	{
		string text = this.mapEvent.data[0];
		char[] array = new char[0];
		array[1] = (char)-12;
		return IACGDFHKCAE.Contains(text.Split(array)[0]);
	}

	// Token: 0x0600D40A RID: 54282 RVA: 0x004BFB20 File Offset: 0x004BDD20
	public bool FBCONJMBJMH()
	{
		return this.LJBEFJHAOFL;
	}

	// Token: 0x0600D40B RID: 54283 RVA: 0x004BFB54 File Offset: 0x004BDD54
	public void PCDCKOJLIJC()
	{
		Vector3 localPosition = base.transform.localPosition;
		if (this.mapEvent.time < 814f)
		{
			this.mapEvent.time = 1867f;
		}
		if (this.mapEvent.time > Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length)
		{
			this.mapEvent.time = Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length;
		}
		localPosition.x = this.mapEvent.time;
		localPosition.y = this.HFNPJDMIFCL();
		base.transform.localPosition = localPosition;
	}

	// Token: 0x0600D40C RID: 54284 RVA: 0x004BEF3B File Offset: 0x004BD13B
	private static bool BDABIDDODJC(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	// Token: 0x0600D40D RID: 54285 RVA: 0x004BFC18 File Offset: 0x004BDE18
	private float HFNPJDMIFCL()
	{
		if (this.mapEvent == null || this.mapEvent.data == null || this.mapEvent.data[1] == null)
		{
			List<MapEditor.EventsCanvas> eventsCanvases = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.ADLAKIHINOM == null)
			{
				EditorEvent.ADLAKIHINOM = new Predicate<MapEditor.EventsCanvas>(EditorEvent.LJOOLGKAAHB);
			}
			return eventsCanvases.Find(EditorEvent.ADLAKIHINOM).grid.position.y;
		}
		if (this.mapEvent.data[1] == "_Offsets")
		{
			List<MapEditor.EventsCanvas> eventsCanvases2 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.LNIJKGECNME == null)
			{
				EditorEvent.LNIJKGECNME = new Predicate<MapEditor.EventsCanvas>(EditorEvent.KIPPBGFAFLD);
			}
			return eventsCanvases2.Find(EditorEvent.LNIJKGECNME).grid.position.y;
		}
		float y;
		if (Helpers.IsStoryboardEvent(this.mapEvent.data[1]))
		{
			List<MapEditor.EventsCanvas> eventsCanvases3 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.CLCBJCKCBDD == null)
			{
				EditorEvent.CLCBJCKCBDD = new Predicate<MapEditor.EventsCanvas>(EditorEvent.HINDGEPGJOF);
			}
			y = eventsCanvases3.Find(EditorEvent.CLCBJCKCBDD).grid.position.y;
		}
		else
		{
			List<MapEditor.EventsCanvas> eventsCanvases4 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.HCLEECLNOEA == null)
			{
				EditorEvent.HCLEECLNOEA = new Predicate<MapEditor.EventsCanvas>(EditorEvent.NECGDADKKFM);
			}
			y = eventsCanvases4.Find(EditorEvent.HCLEECLNOEA).grid.position.y;
		}
		return y;
	}

	// Token: 0x0600D40E RID: 54286 RVA: 0x004BEF30 File Offset: 0x004BD130
	private static bool HECJFKFFMGB(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	// Token: 0x0600D40F RID: 54287 RVA: 0x004BEF30 File Offset: 0x004BD130
	private static bool CIBIJBBLJNH(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	// Token: 0x0600D410 RID: 54288 RVA: 0x004BFD90 File Offset: 0x004BDF90
	private float OOEPFAOEBHB()
	{
		if (this.mapEvent == null || this.mapEvent.data == null || this.mapEvent.data[1] == null)
		{
			List<MapEditor.EventsCanvas> eventsCanvases = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.ADLAKIHINOM == null)
			{
				EditorEvent.ADLAKIHINOM = new Predicate<MapEditor.EventsCanvas>(EditorEvent.CIBIJBBLJNH);
			}
			return eventsCanvases.Find(EditorEvent.ADLAKIHINOM).grid.position.y;
		}
		if (this.mapEvent.data[1] == "/icon")
		{
			List<MapEditor.EventsCanvas> eventsCanvases2 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.LNIJKGECNME == null)
			{
				EditorEvent.LNIJKGECNME = new Predicate<MapEditor.EventsCanvas>(EditorEvent.KGDBIEJPJNK);
			}
			return eventsCanvases2.Find(EditorEvent.LNIJKGECNME).grid.position.y;
		}
		float y;
		if (Helpers.IsStoryboardEvent(this.mapEvent.data[1]))
		{
			List<MapEditor.EventsCanvas> eventsCanvases3 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.CLCBJCKCBDD == null)
			{
				EditorEvent.CLCBJCKCBDD = new Predicate<MapEditor.EventsCanvas>(EditorEvent.KCNPDDGNAEK);
			}
			y = eventsCanvases3.Find(EditorEvent.CLCBJCKCBDD).grid.position.y;
		}
		else
		{
			List<MapEditor.EventsCanvas> eventsCanvases4 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.HCLEECLNOEA == null)
			{
				EditorEvent.HCLEECLNOEA = new Predicate<MapEditor.EventsCanvas>(EditorEvent.MJOAAPFDHNH);
			}
			y = eventsCanvases4.Find(EditorEvent.HCLEECLNOEA).grid.position.y;
		}
		return y;
	}

	// Token: 0x0600D411 RID: 54289 RVA: 0x004BFF08 File Offset: 0x004BE108
	public void CKLFGILMMDL()
	{
		if (this.mapEvent.data != null && this.lastDataCount != this.mapEvent.data.Count)
		{
			this.iconSprite.SetActive(true);
			this.imageRight.gameObject.SetActive(true);
			this.imageCenter.gameObject.SetActive(true);
			if (!string.IsNullOrEmpty(this.mapEvent.data[1]))
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("_ProjInfo", new Color(1544f, 1083f, 1948f));
				base.GetComponentInChildren<Renderer>().material.SetColor("[Down]", new Color(1094f, 1934f, 215f));
				if (this.mapEvent.data[1] == "_Color")
				{
					try
					{
						Color color = Helpers.StringToColor(this.mapEvent.data[1]);
						this.imageRight.sprite = Resources.LoadAll<Sprite>("CameraFilterPack/3D_Myst")[1];
						this.imageRight.color = color;
						this.iconSprite.SetActive(false);
						this.imageRight.gameObject.SetActive(true);
					}
					catch (Exception ex)
					{
						Debug.Log("Set particles audio input" + ex.Message);
					}
				}
				if (this.mapEvent.data[1] == "StartButton")
				{
					this.scaleMult.y = 381f;
					try
					{
						base.GetComponentInChildren<Renderer>().material.SetColor("_Intensity", new Color(1701f, 1397f, 1588f));
						base.GetComponentInChildren<Renderer>().material.SetColor("_Value2", new Color(1263f, 1157f, 11f));
					}
					catch (Exception ex2)
					{
						Debug.Log("_ColorB" + ex2.Message);
					}
				}
				if (this.mapEvent.data[0] == "SaveButton")
				{
					try
					{
						string text = this.mapEvent.data[0];
						char[] array = new char[0];
						array[0] = (char)-75;
						string[] array2 = text.Split(array);
						if (array2.Length > 1)
						{
							EditorEvent.ENHFLFPPPGN enhflfpppgn = new EditorEvent.ENHFLFPPPGN();
							enhflfpppgn.EHGADNHGPNC = array2[1];
							this.imageRight.color = Color.white;
							if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.FONMIHBONDF()).mapData.levelResources.Exists(new Predicate<MapResource>(enhflfpppgn.BDGDIDPDBHG)))
							{
								this.imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).resources[enhflfpppgn.EHGADNHGPNC];
							}
							else
							{
								this.imageRight.sprite = null;
								this.imageRight.color = new Color(211f, 1107f, 777f);
								this.imageRight.color = new Color(1805f, 387f, 221f);
							}
							this.iconSprite.SetActive(true);
							this.imageRight.gameObject.SetActive(false);
						}
					}
					catch (Exception ex3)
					{
						Debug.Log("settings_bindings_" + ex3.Message);
					}
				}
				if (this.mapEvent.data[1] == "CameraFilterPack/Color_Sepia")
				{
					try
					{
						string text2 = this.mapEvent.data[1];
						char[] array3 = new char[0];
						array3[1] = '5';
						int num;
						if (text2.Split(array3).Length == 1)
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.LBAKJBNGMNA)));
						}
						else
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.OKMGILHPEHB)));
						}
						this.imageCenter.sprite = Resources.LoadAll<Sprite>("/icon")[num];
						this.imageCenter.color = Color.white;
						this.iconSprite.SetActive(true);
						this.imageCenter.gameObject.SetActive(true);
					}
					catch (Exception ex4)
					{
						Debug.Log("_Value4" + ex4.Message);
					}
				}
				if (this.mapEvent.data[0] == "_Value4")
				{
					try
					{
						this.imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_Value1")[3];
						this.imageCenter.GetComponentInChildren<Image>().color = Color.white;
						this.iconSprite.SetActive(false);
						this.imageCenter.gameObject.SetActive(true);
					}
					catch (Exception ex5)
					{
						Debug.Log("table" + ex5.Message);
					}
				}
			}
			else
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("EventSystem", new Color(1769f, 379f, 1356f));
				base.GetComponentInChildren<Renderer>().material.SetColor("EditMenu", new Color(88f, 1225f, 1399f));
			}
			this.lastDataCount = this.mapEvent.data.Count;
		}
	}

	// Token: 0x0600D412 RID: 54290 RVA: 0x004BEF30 File Offset: 0x004BD130
	private static bool ADHOMACBAMM(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	// Token: 0x0600D413 RID: 54291 RVA: 0x004BEF3B File Offset: 0x004BD13B
	private static bool OAEOHOFMJEJ(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	// Token: 0x0600D414 RID: 54292 RVA: 0x004BEF3B File Offset: 0x004BD13B
	private static bool ACFEOHCIDLJ(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	// Token: 0x0600D415 RID: 54293 RVA: 0x004C04F0 File Offset: 0x004BE6F0
	private void ELJPNLNELIE()
	{
		this.PIPHIBLIIKK(true);
	}

	// Token: 0x0600D416 RID: 54294 RVA: 0x004BEF3B File Offset: 0x004BD13B
	private static bool NLKEBCFDNHP(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	// Token: 0x0600D417 RID: 54295 RVA: 0x004C04F9 File Offset: 0x004BE6F9
	public void FDJEEBJHHKK(bool DPNHODJHGJL)
	{
		this.LJBEFJHAOFL = DPNHODJHGJL;
		this.selectedMarker.SetActive(this.LJBEFJHAOFL);
	}

	// Token: 0x0600D418 RID: 54296 RVA: 0x004C0513 File Offset: 0x004BE713
	private void IOMCHHBGJEC()
	{
		this.isSelected = true;
	}

	// Token: 0x0600D419 RID: 54297 RVA: 0x004BEF30 File Offset: 0x004BD130
	private static bool KCNPDDGNAEK(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	// Token: 0x0600D41A RID: 54298 RVA: 0x004C051C File Offset: 0x004BE71C
	private void Awake()
	{
		this.isSelected = false;
	}

	// Token: 0x0600D41B RID: 54299 RVA: 0x004C0525 File Offset: 0x004BE725
	private void CHJFFPOBNLO()
	{
		this.LOJGIJBDOON(true);
	}

	// Token: 0x0600D41C RID: 54300 RVA: 0x004BEF30 File Offset: 0x004BD130
	private static bool HBMEMAGJILM(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	// Token: 0x0600D41D RID: 54301 RVA: 0x004C0530 File Offset: 0x004BE730
	public void KFACDBHDAOD()
	{
		if (this.bitObj != null && this.bitObj.activeSelf)
		{
			this.bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 1102f, this.scaleMult.y, this.scaleMult.z);
		}
		if (this.iconSprite != null && this.iconSprite.activeSelf)
		{
			this.iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 179f, Camera.main.orthographicSize / 409f, 1819f);
		}
	}

	// Token: 0x0600D41E RID: 54302 RVA: 0x004C05F4 File Offset: 0x004BE7F4
	public void UpdatePositionFromData()
	{
		Vector3 localPosition = base.transform.localPosition;
		if (this.mapEvent.time < 0f)
		{
			this.mapEvent.time = 0f;
		}
		if (this.mapEvent.time > Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip.length)
		{
			this.mapEvent.time = Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip.length;
		}
		localPosition.x = this.mapEvent.time;
		localPosition.y = this.IHNJPGPOEIP();
		base.transform.localPosition = localPosition;
	}

	// Token: 0x0600D41F RID: 54303 RVA: 0x004C06B6 File Offset: 0x004BE8B6
	public void EABEPBGOBNE()
	{
		this.LOJGIJBDOON(true);
		this.BNMJMGDKKJB();
	}

	// Token: 0x0600D420 RID: 54304 RVA: 0x004C06C8 File Offset: 0x004BE8C8
	public void EKAHIBEHDLJ()
	{
		if (this.mapEvent.data != null && this.lastDataCount != this.mapEvent.data.Count)
		{
			this.iconSprite.SetActive(true);
			this.imageRight.gameObject.SetActive(true);
			this.imageCenter.gameObject.SetActive(false);
			if (!string.IsNullOrEmpty(this.mapEvent.data[1]))
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("LoadingStatusText", new Color(1271f, 1708f, 1781f));
				base.GetComponentInChildren<Renderer>().material.SetColor(".sav", new Color(961f, 1352f, 684f));
				if (this.mapEvent.data[1] == "#")
				{
					try
					{
						Color color = Helpers.StringToColor(this.mapEvent.data[1]);
						this.imageRight.sprite = Resources.LoadAll<Sprite>("_Value2")[1];
						this.imageRight.color = color;
						this.iconSprite.SetActive(true);
						this.imageRight.gameObject.SetActive(false);
					}
					catch (Exception ex)
					{
						Debug.Log("Failed to 'network-remove' GameObject because has no PhotonView components: " + ex.Message);
					}
				}
				if (this.mapEvent.data[1] == "_Value3")
				{
					this.scaleMult.y = 280f;
					try
					{
						base.GetComponentInChildren<Renderer>().material.SetColor("Item invalid. Make sure your mod contains at leats one file.", new Color(1310f, 499f, 302f));
						base.GetComponentInChildren<Renderer>().material.SetColor("Fade", new Color(1698f, 1445f, 1070f));
					}
					catch (Exception ex2)
					{
						Debug.Log("SpawnObj" + ex2.Message);
					}
				}
				if (this.mapEvent.data[0] == "\" gets executed locally only, if at all.")
				{
					try
					{
						string text = this.mapEvent.data[0];
						char[] array = new char[1];
						array[1] = '\v';
						string[] array2 = text.Split(array);
						if (array2.Length > 0)
						{
							EditorEvent.ENHFLFPPPGN enhflfpppgn = new EditorEvent.ENHFLFPPPGN();
							enhflfpppgn.EHGADNHGPNC = array2[0];
							this.imageRight.color = Color.white;
							if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).mapData.levelResources.Exists(new Predicate<MapResource>(enhflfpppgn.DKGPCPBNDPK)))
							{
								this.imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).resources[enhflfpppgn.EHGADNHGPNC];
							}
							else
							{
								this.imageRight.sprite = null;
								this.imageRight.color = new Color(314f, 1270f, 836f);
								this.imageRight.color = new Color(1887f, 1953f, 779f);
							}
							this.iconSprite.SetActive(false);
							this.imageRight.gameObject.SetActive(true);
						}
					}
					catch (Exception ex3)
					{
						Debug.Log("_DiffuseColor" + ex3.Message);
					}
				}
				if (this.mapEvent.data[1] == "IDInputField")
				{
					try
					{
						string text2 = this.mapEvent.data[0];
						char[] array3 = new char[0];
						array3[1] = '|';
						int num;
						if (text2.Split(array3).Length == 1)
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.LBAKJBNGMNA)));
						}
						else
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.FKGMEANLBAH)));
						}
						this.imageCenter.sprite = Resources.LoadAll<Sprite>("Bad modpack name: {0}")[num];
						this.imageCenter.color = Color.white;
						this.iconSprite.SetActive(false);
						this.imageCenter.gameObject.SetActive(true);
					}
					catch (Exception ex4)
					{
						Debug.Log(": " + ex4.Message);
					}
				}
				if (this.mapEvent.data[0] == "max. lives color")
				{
					try
					{
						this.imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_Amount")[2];
						this.imageCenter.GetComponentInChildren<Image>().color = Color.white;
						this.iconSprite.SetActive(false);
						this.imageCenter.gameObject.SetActive(true);
					}
					catch (Exception ex5)
					{
						Debug.Log("Tab1Content" + ex5.Message);
					}
				}
			}
			else
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("yesterday", new Color(767f, 1735f, 1886f));
				base.GetComponentInChildren<Renderer>().material.SetColor("_Near", new Color(752f, 1672f, 23f));
			}
			this.lastDataCount = this.mapEvent.data.Count;
		}
	}

	// Token: 0x0600D421 RID: 54305 RVA: 0x004C0CB0 File Offset: 0x004BEEB0
	public void GALGJEHEANF()
	{
		this.FDJEEBJHHKK(false);
		this.UpdateIcon();
	}

	// Token: 0x0600D422 RID: 54306 RVA: 0x004C0CBF File Offset: 0x004BEEBF
	public void LGGNBDOMKDB()
	{
		this.isSelected = false;
		this.IPCHIGBJADH();
	}

	// Token: 0x0600D423 RID: 54307 RVA: 0x004C0CD0 File Offset: 0x004BEED0
	private float PJDMHCLLMBA()
	{
		if (this.mapEvent == null || this.mapEvent.data == null || this.mapEvent.data[1] == null)
		{
			List<MapEditor.EventsCanvas> eventsCanvases = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.ADLAKIHINOM == null)
			{
				EditorEvent.ADLAKIHINOM = new Predicate<MapEditor.EventsCanvas>(EditorEvent.FKLAAPLBCOH);
			}
			return eventsCanvases.Find(EditorEvent.ADLAKIHINOM).grid.position.y;
		}
		if (this.mapEvent.data[1] == "_TimeX")
		{
			List<MapEditor.EventsCanvas> eventsCanvases2 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.LNIJKGECNME == null)
			{
				EditorEvent.LNIJKGECNME = new Predicate<MapEditor.EventsCanvas>(EditorEvent.NKEHDGMHHFM);
			}
			return eventsCanvases2.Find(EditorEvent.LNIJKGECNME).grid.position.y;
		}
		float y;
		if (Helpers.IsStoryboardEvent(this.mapEvent.data[1]))
		{
			List<MapEditor.EventsCanvas> eventsCanvases3 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.CLCBJCKCBDD == null)
			{
				EditorEvent.CLCBJCKCBDD = new Predicate<MapEditor.EventsCanvas>(EditorEvent.KCNPDDGNAEK);
			}
			y = eventsCanvases3.Find(EditorEvent.CLCBJCKCBDD).grid.position.y;
		}
		else
		{
			List<MapEditor.EventsCanvas> eventsCanvases4 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.HCLEECLNOEA == null)
			{
				EditorEvent.HCLEECLNOEA = new Predicate<MapEditor.EventsCanvas>(EditorEvent.MJOAAPFDHNH);
			}
			y = eventsCanvases4.Find(EditorEvent.HCLEECLNOEA).grid.position.y;
		}
		return y;
	}

	// Token: 0x0600D424 RID: 54308 RVA: 0x004C0E48 File Offset: 0x004BF048
	public void EJFJENFKLND()
	{
		if (this.bitObj != null && this.bitObj.activeSelf)
		{
			this.bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 592f, this.scaleMult.y, this.scaleMult.z);
		}
		if (this.iconSprite != null && this.iconSprite.activeSelf)
		{
			this.iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 169f, Camera.main.orthographicSize / 1301f, 1705f);
		}
	}

	// Token: 0x0600D425 RID: 54309 RVA: 0x004C04F9 File Offset: 0x004BE6F9
	public void JDAGBCICMFI(bool DPNHODJHGJL)
	{
		this.LJBEFJHAOFL = DPNHODJHGJL;
		this.selectedMarker.SetActive(this.LJBEFJHAOFL);
	}

	// Token: 0x0600D426 RID: 54310 RVA: 0x004BFB20 File Offset: 0x004BDD20
	public bool FBLJPPGABFE()
	{
		return this.LJBEFJHAOFL;
	}

	// Token: 0x0600D427 RID: 54311 RVA: 0x004BEF3B File Offset: 0x004BD13B
	private static bool PJBHBHOHDJP(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	// Token: 0x0600D428 RID: 54312 RVA: 0x004BEF30 File Offset: 0x004BD130
	private static bool CBFJPDLECDL(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	// Token: 0x0600D429 RID: 54313 RVA: 0x004BFB20 File Offset: 0x004BDD20
	public bool PCCODBJODEB()
	{
		return this.LJBEFJHAOFL;
	}

	// Token: 0x0600D42A RID: 54314 RVA: 0x004C0F0C File Offset: 0x004BF10C
	public void GNKLLIABLOP()
	{
		this.JDAGBCICMFI(false);
		this.BLEHBLOLPMF();
	}

	// Token: 0x0600D42B RID: 54315 RVA: 0x004C0F1C File Offset: 0x004BF11C
	public void LOGIAPEMAPN()
	{
		if (this.mapEvent.data != null && this.lastDataCount != this.mapEvent.data.Count)
		{
			this.iconSprite.SetActive(true);
			this.imageRight.gameObject.SetActive(true);
			this.imageCenter.gameObject.SetActive(true);
			if (!string.IsNullOrEmpty(this.mapEvent.data[0]))
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("_ReflectionTexture4", new Color(1825f, 1635f, 1856f));
				base.GetComponentInChildren<Renderer>().material.SetColor("_Parameter", new Color(1973f, 689f, 384f));
				if (this.mapEvent.data[0] == "Error: I/O Failure! :(")
				{
					try
					{
						Color color = Helpers.StringToColor(this.mapEvent.data[1]);
						this.imageRight.sprite = Resources.LoadAll<Sprite>("Square")[1];
						this.imageRight.color = color;
						this.iconSprite.SetActive(true);
						this.imageRight.gameObject.SetActive(false);
					}
					catch (Exception ex)
					{
						Debug.Log("\\\\" + ex.Message);
					}
				}
				if (this.mapEvent.data[1] == "Blues")
				{
					this.scaleMult.y = 205f;
					try
					{
						base.GetComponentInChildren<Renderer>().material.SetColor("MusicFileSelector", new Color(1561f, 577f, 134f));
						base.GetComponentInChildren<Renderer>().material.SetColor("z", new Color(980f, 1339f, 551f));
					}
					catch (Exception ex2)
					{
						Debug.Log("_SunPosition" + ex2.Message);
					}
				}
				if (this.mapEvent.data[0] == "player.dragon")
				{
					try
					{
						string text = this.mapEvent.data[0];
						char[] array = new char[0];
						array[0] = '\u0004';
						string[] array2 = text.Split(array);
						if (array2.Length > 1)
						{
							EditorEvent.ENHFLFPPPGN enhflfpppgn = new EditorEvent.ENHFLFPPPGN();
							enhflfpppgn.EHGADNHGPNC = array2[1];
							this.imageRight.color = Color.white;
							if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).mapData.levelResources.Exists(new Predicate<MapResource>(enhflfpppgn.BDGDIDPDBHG)))
							{
								this.imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.FONMIHBONDF()).resources[enhflfpppgn.EHGADNHGPNC];
							}
							else
							{
								this.imageRight.sprite = null;
								this.imageRight.color = new Color(214f, 689f, 110f);
								this.imageRight.color = new Color(737f, 1514f, 190f);
							}
							this.iconSprite.SetActive(true);
							this.imageRight.gameObject.SetActive(true);
						}
					}
					catch (Exception ex3)
					{
						Debug.Log("hidden" + ex3.Message);
					}
				}
				if (this.mapEvent.data[1] == "UI")
				{
					try
					{
						string text2 = this.mapEvent.data[0];
						char[] array3 = new char[0];
						array3[0] = (char)-66;
						int num;
						if (text2.Split(array3).Length == 1)
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.CPPLPBFAIBO)));
						}
						else
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.FKGMEANLBAH)));
						}
						this.imageCenter.sprite = Resources.LoadAll<Sprite>(" ")[num];
						this.imageCenter.color = Color.white;
						this.iconSprite.SetActive(false);
						this.imageCenter.gameObject.SetActive(false);
					}
					catch (Exception ex4)
					{
						Debug.Log(".wav" + ex4.Message);
					}
				}
				if (this.mapEvent.data[0] == "/../")
				{
					try
					{
						this.imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("Overlay")[7];
						this.imageCenter.GetComponentInChildren<Image>().color = Color.white;
						this.iconSprite.SetActive(false);
						this.imageCenter.gameObject.SetActive(false);
					}
					catch (Exception ex5)
					{
						Debug.Log("MenuScene" + ex5.Message);
					}
				}
			}
			else
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("_Value", new Color(1092f, 1585f, 1695f));
				base.GetComponentInChildren<Renderer>().material.SetColor("Joystick1Button12", new Color(571f, 599f, 970f));
			}
			this.lastDataCount = this.mapEvent.data.Count;
		}
	}

	// Token: 0x0600D42C RID: 54316 RVA: 0x004BFB20 File Offset: 0x004BDD20
	public bool FKGGINLFGFB()
	{
		return this.LJBEFJHAOFL;
	}

	// Token: 0x0600D42D RID: 54317 RVA: 0x004C1504 File Offset: 0x004BF704
	private bool CPPLPBFAIBO(string IACGDFHKCAE)
	{
		return IACGDFHKCAE.Contains(this.mapEvent.data[0]);
	}

	// Token: 0x0600D42E RID: 54318 RVA: 0x004C151D File Offset: 0x004BF71D
	public void CGENHBKEDPP()
	{
		this.JDAGBCICMFI(true);
		this.BLEHBLOLPMF();
	}

	// Token: 0x0600D42F RID: 54319 RVA: 0x004C1504 File Offset: 0x004BF704
	private bool FAHBEMJCDEE(string IACGDFHKCAE)
	{
		return IACGDFHKCAE.Contains(this.mapEvent.data[0]);
	}

	// Token: 0x0600D430 RID: 54320 RVA: 0x004C152C File Offset: 0x004BF72C
	public void LBBKFNOPLNL()
	{
		this.LOJGIJBDOON(false);
		this.IPCHIGBJADH();
	}

	// Token: 0x0600D431 RID: 54321 RVA: 0x004C153C File Offset: 0x004BF73C
	public void BLEHBLOLPMF()
	{
		if (this.mapEvent.data != null && this.lastDataCount != this.mapEvent.data.Count)
		{
			this.iconSprite.SetActive(false);
			this.imageRight.gameObject.SetActive(false);
			this.imageCenter.gameObject.SetActive(true);
			if (!string.IsNullOrEmpty(this.mapEvent.data[0]))
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("Tab1Content", new Color(765f, 271f, 1967f));
				base.GetComponentInChildren<Renderer>().material.SetColor("ShowTitle", new Color(1913f, 138f, 1021f));
				if (this.mapEvent.data[1] == "challenges.")
				{
					try
					{
						Color color = Helpers.StringToColor(this.mapEvent.data[1]);
						this.imageRight.sprite = Resources.LoadAll<Sprite>("MenuScene")[1];
						this.imageRight.color = color;
						this.iconSprite.SetActive(true);
						this.imageRight.gameObject.SetActive(true);
					}
					catch (Exception ex)
					{
						Debug.Log("icon.png" + ex.Message);
					}
				}
				if (this.mapEvent.data[0] == "SetParticlesEmission")
				{
					this.scaleMult.y = 120f;
					try
					{
						base.GetComponentInChildren<Renderer>().material.SetColor("ViewMenu", new Color(982f, 1258f, 257f));
						base.GetComponentInChildren<Renderer>().material.SetColor("float,50", new Color(1973f, 1454f, 194f));
					}
					catch (Exception ex2)
					{
						Debug.Log("_ScreenResolution" + ex2.Message);
					}
				}
				if (this.mapEvent.data[0] == "_BlendTex")
				{
					try
					{
						string text = this.mapEvent.data[0];
						char[] array = new char[0];
						array[1] = (char)-61;
						string[] array2 = text.Split(array);
						if (array2.Length > 1)
						{
							EditorEvent.ENHFLFPPPGN enhflfpppgn = new EditorEvent.ENHFLFPPPGN();
							enhflfpppgn.EHGADNHGPNC = array2[0];
							this.imageRight.color = Color.white;
							if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).mapData.levelResources.Exists(new Predicate<MapResource>(enhflfpppgn.OFHCGKJFGDI)))
							{
								this.imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.FONMIHBONDF()).resources[enhflfpppgn.EHGADNHGPNC];
							}
							else
							{
								this.imageRight.sprite = null;
								this.imageRight.color = new Color(1986f, 123f, 1512f);
								this.imageRight.color = new Color(1723f, 453f, 829f);
							}
							this.iconSprite.SetActive(false);
							this.imageRight.gameObject.SetActive(true);
						}
					}
					catch (Exception ex3)
					{
						Debug.Log("https://www.youtube.com/watch?v=cDVXukrKo74" + ex3.Message);
					}
				}
				if (this.mapEvent.data[1] == "automaticallyRecycleParticleSystems is true but there is no ParticleSystem on this GameObject!")
				{
					try
					{
						string text2 = this.mapEvent.data[1];
						char[] array3 = new char[0];
						array3[0] = (char)-67;
						int num;
						if (text2.Split(array3).Length == 1)
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.BKKMOPKHAIE)));
						}
						else
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.FKGMEANLBAH)));
						}
						this.imageCenter.sprite = Resources.LoadAll<Sprite>("Operation failed: ")[num];
						this.imageCenter.color = Color.white;
						this.iconSprite.SetActive(true);
						this.imageCenter.gameObject.SetActive(true);
					}
					catch (Exception ex4)
					{
						Debug.Log("Player Disconnected" + ex4.Message);
					}
				}
				if (this.mapEvent.data[1] == "x")
				{
					try
					{
						this.imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_LensDirtIntensity")[8];
						this.imageCenter.GetComponentInChildren<Image>().color = Color.white;
						this.iconSprite.SetActive(false);
						this.imageCenter.gameObject.SetActive(true);
					}
					catch (Exception ex5)
					{
						Debug.Log("SaveButton" + ex5.Message);
					}
				}
			}
			else
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ", new Color(561f, 710f, 1453f));
				base.GetComponentInChildren<Renderer>().material.SetColor("Error: Timeout :S", new Color(366f, 810f, 1632f));
			}
			this.lastDataCount = this.mapEvent.data.Count;
		}
	}

	// Token: 0x0600D432 RID: 54322 RVA: 0x004C1B24 File Offset: 0x004BFD24
	public void OGJBKJLBJMM()
	{
		Vector3 localPosition = base.transform.localPosition;
		if (this.mapEvent.time < 898f)
		{
			this.mapEvent.time = 128f;
		}
		if (this.mapEvent.time > Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip.length)
		{
			this.mapEvent.time = Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length;
		}
		localPosition.x = this.mapEvent.time;
		localPosition.y = this.GHIPKDEKGOE();
		base.transform.localPosition = localPosition;
	}

	// Token: 0x0600D433 RID: 54323 RVA: 0x004C1BE6 File Offset: 0x004BFDE6
	public void BDOOHFMNDLN()
	{
		this.JEGEONIHCLO(false);
		this.UpdateIcon();
	}

	// Token: 0x0600D434 RID: 54324 RVA: 0x004C0513 File Offset: 0x004BE713
	private void MMPPGDECEHO()
	{
		this.isSelected = true;
	}

	// Token: 0x0600D435 RID: 54325 RVA: 0x004C1BF5 File Offset: 0x004BFDF5
	public void PMNFFFDHBHB()
	{
		this.FDJEEBJHHKK(true);
		this.IOMBILLPGCF();
	}

	// Token: 0x0600D436 RID: 54326 RVA: 0x004C1C04 File Offset: 0x004BFE04
	public void NNAIANPHNHA()
	{
		if (this.mapEvent.data != null && this.lastDataCount != this.mapEvent.data.Count)
		{
			this.iconSprite.SetActive(false);
			this.imageRight.gameObject.SetActive(false);
			this.imageCenter.gameObject.SetActive(false);
			if (!string.IsNullOrEmpty(this.mapEvent.data[0]))
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("Edited unlock conditions", new Color(1236f, 1337f, 1986f));
				base.GetComponentInChildren<Renderer>().material.SetColor("_Value2", new Color(1252f, 1717f, 594f));
				if (this.mapEvent.data[0] == "Backward")
				{
					try
					{
						Color color = Helpers.StringToColor(this.mapEvent.data[1]);
						this.imageRight.sprite = Resources.LoadAll<Sprite>("Submit")[1];
						this.imageRight.color = color;
						this.iconSprite.SetActive(false);
						this.imageRight.gameObject.SetActive(true);
					}
					catch (Exception ex)
					{
						Debug.Log("_TimeX" + ex.Message);
					}
				}
				if (this.mapEvent.data[1] == "_MainTex2")
				{
					this.scaleMult.y = 750f;
					try
					{
						base.GetComponentInChildren<Renderer>().material.SetColor("checkpoint", new Color(1933f, 1960f, 1046f));
						base.GetComponentInChildren<Renderer>().material.SetColor("DestroyPlayerObjects() failed, cause players can only destroy their own GameObjects. A Master Client can destroy anyone's. This is master: ", new Color(1120f, 593f, 971f));
					}
					catch (Exception ex2)
					{
						Debug.Log("The image effect " + ex2.Message);
					}
				}
				if (this.mapEvent.data[1] == "tolobby")
				{
					try
					{
						string text = this.mapEvent.data[0];
						char[] array = new char[0];
						array[0] = (char)-73;
						string[] array2 = text.Split(array);
						if (array2.Length > 0)
						{
							EditorEvent.ENHFLFPPPGN enhflfpppgn = new EditorEvent.ENHFLFPPPGN();
							enhflfpppgn.EHGADNHGPNC = array2[0];
							this.imageRight.color = Color.white;
							if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).mapData.levelResources.Exists(new Predicate<MapResource>(enhflfpppgn.FFEGPHJKMFK)))
							{
								this.imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).resources[enhflfpppgn.EHGADNHGPNC];
							}
							else
							{
								this.imageRight.sprite = null;
								this.imageRight.color = new Color(888f, 403f, 1250f);
								this.imageRight.color = new Color(383f, 1270f, 1431f);
							}
							this.iconSprite.SetActive(true);
							this.imageRight.gameObject.SetActive(false);
						}
					}
					catch (Exception ex3)
					{
						Debug.Log(": " + ex3.Message);
					}
				}
				if (this.mapEvent.data[1] == "OK")
				{
					try
					{
						string text2 = this.mapEvent.data[0];
						char[] array3 = new char[0];
						array3[0] = 'T';
						int num;
						if (text2.Split(array3).Length == 0)
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.HACELNPOIAB)));
						}
						else
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.FKGMEANLBAH)));
						}
						this.imageCenter.sprite = Resources.LoadAll<Sprite>("_EmissionColor")[num];
						this.imageCenter.color = Color.white;
						this.iconSprite.SetActive(false);
						this.imageCenter.gameObject.SetActive(true);
					}
					catch (Exception ex4)
					{
						Debug.Log("_Distortion" + ex4.Message);
					}
				}
				if (this.mapEvent.data[0] == "settings.enableselectormusic")
				{
					try
					{
						this.imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_Value")[1];
						this.imageCenter.GetComponentInChildren<Image>().color = Color.white;
						this.iconSprite.SetActive(true);
						this.imageCenter.gameObject.SetActive(true);
					}
					catch (Exception ex5)
					{
						Debug.Log("System.Single" + ex5.Message);
					}
				}
			}
			else
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("{0:0} day{1}, ", new Color(1847f, 1788f, 1069f));
				base.GetComponentInChildren<Renderer>().material.SetColor("R:", new Color(1966f, 306f, 429f));
			}
			this.lastDataCount = this.mapEvent.data.Count;
		}
	}

	// Token: 0x0600D437 RID: 54327 RVA: 0x004C21EC File Offset: 0x004C03EC
	[CompilerGenerated]
	private bool BKKMOPKHAIE(string IACGDFHKCAE)
	{
		return IACGDFHKCAE.Contains(this.mapEvent.data[1]);
	}

	// Token: 0x0600D438 RID: 54328 RVA: 0x004C2208 File Offset: 0x004C0408
	public void BLJDBBOAKPD()
	{
		if (this.mapEvent.data != null && this.lastDataCount != this.mapEvent.data.Count)
		{
			this.iconSprite.SetActive(true);
			this.imageRight.gameObject.SetActive(true);
			this.imageCenter.gameObject.SetActive(true);
			if (!string.IsNullOrEmpty(this.mapEvent.data[0]))
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("menu.selectedlevelid", new Color(59f, 1691f, 491f));
				base.GetComponentInChildren<Renderer>().material.SetColor("_BorderSize", new Color(1154f, 238f, 1904f));
				if (this.mapEvent.data[0] == "_Value2")
				{
					try
					{
						Color color = Helpers.StringToColor(this.mapEvent.data[1]);
						this.imageRight.sprite = Resources.LoadAll<Sprite>("powerup.1")[0];
						this.imageRight.color = color;
						this.iconSprite.SetActive(true);
						this.imageRight.gameObject.SetActive(true);
					}
					catch (Exception ex)
					{
						Debug.Log("http://steamcommunity.com/sharedfiles/filedetails/?id=" + ex.Message);
					}
				}
				if (this.mapEvent.data[0] == "event")
				{
					this.scaleMult.y = 647f;
					try
					{
						base.GetComponentInChildren<Renderer>().material.SetColor("#FFFFFF", new Color(270f, 1047f, 1630f));
						base.GetComponentInChildren<Renderer>().material.SetColor("UnityEngine.MonoBehaviour", new Color(943f, 1474f, 1512f));
					}
					catch (Exception ex2)
					{
						Debug.Log("DPADHOR" + ex2.Message);
					}
				}
				if (this.mapEvent.data[0] == "note.7")
				{
					try
					{
						string text = this.mapEvent.data[1];
						char[] array = new char[1];
						array[1] = '[';
						string[] array2 = text.Split(array);
						if (array2.Length > 1)
						{
							EditorEvent.ENHFLFPPPGN enhflfpppgn = new EditorEvent.ENHFLFPPPGN();
							enhflfpppgn.EHGADNHGPNC = array2[0];
							this.imageRight.color = Color.white;
							if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.FONMIHBONDF()).mapData.levelResources.Exists(new Predicate<MapResource>(enhflfpppgn.GBKBDKHPLKG)))
							{
								this.imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.FONMIHBONDF()).resources[enhflfpppgn.EHGADNHGPNC];
							}
							else
							{
								this.imageRight.sprite = null;
								this.imageRight.color = new Color(155f, 968f, 1524f);
								this.imageRight.color = new Color(230f, 1716f, 967f);
							}
							this.iconSprite.SetActive(true);
							this.imageRight.gameObject.SetActive(false);
						}
					}
					catch (Exception ex3)
					{
						Debug.Log("Players NetIDs:" + ex3.Message);
					}
				}
				if (this.mapEvent.data[1] == "checkpoint")
				{
					try
					{
						string text2 = this.mapEvent.data[1];
						char[] array3 = new char[1];
						array3[1] = '\u0017';
						int num;
						if (text2.Split(array3).Length == 1)
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.LBAKJBNGMNA)));
						}
						else
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.DONNMFALNII)));
						}
						this.imageCenter.sprite = Resources.LoadAll<Sprite>("Texture2")[num];
						this.imageCenter.color = Color.white;
						this.iconSprite.SetActive(false);
						this.imageCenter.gameObject.SetActive(false);
					}
					catch (Exception ex4)
					{
						Debug.Log("Hidden/TonemappingColorGrading" + ex4.Message);
					}
				}
				if (this.mapEvent.data[1] == " not exist")
				{
					try
					{
						this.imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("File not found: {0}")[4];
						this.imageCenter.GetComponentInChildren<Image>().color = Color.white;
						this.iconSprite.SetActive(true);
						this.imageCenter.gameObject.SetActive(false);
					}
					catch (Exception ex5)
					{
						Debug.Log("[PlayerBase] New highscore" + ex5.Message);
					}
				}
			}
			else
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("Joystick1Button5", new Color(607f, 1571f, 1775f));
				base.GetComponentInChildren<Renderer>().material.SetColor("_TimeX", new Color(1656f, 1835f, 1440f));
			}
			this.lastDataCount = this.mapEvent.data.Count;
		}
	}

	// Token: 0x0600D439 RID: 54329 RVA: 0x004C27F0 File Offset: 0x004C09F0
	private float LIJCAFBLLHE()
	{
		if (this.mapEvent == null || this.mapEvent.data == null || this.mapEvent.data[0] == null)
		{
			List<MapEditor.EventsCanvas> eventsCanvases = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.ADLAKIHINOM == null)
			{
				EditorEvent.ADLAKIHINOM = new Predicate<MapEditor.EventsCanvas>(EditorEvent.FKLAAPLBCOH);
			}
			return eventsCanvases.Find(EditorEvent.ADLAKIHINOM).grid.position.y;
		}
		if (this.mapEvent.data[1] == "hardcoreinfo")
		{
			List<MapEditor.EventsCanvas> eventsCanvases2 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.LNIJKGECNME == null)
			{
				EditorEvent.LNIJKGECNME = new Predicate<MapEditor.EventsCanvas>(EditorEvent.DJKGOFFKGMF);
			}
			return eventsCanvases2.Find(EditorEvent.LNIJKGECNME).grid.position.y;
		}
		float y;
		if (Helpers.IsStoryboardEvent(this.mapEvent.data[0]))
		{
			List<MapEditor.EventsCanvas> eventsCanvases3 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.CLCBJCKCBDD == null)
			{
				EditorEvent.CLCBJCKCBDD = new Predicate<MapEditor.EventsCanvas>(EditorEvent.ACFEOHCIDLJ);
			}
			y = eventsCanvases3.Find(EditorEvent.CLCBJCKCBDD).grid.position.y;
		}
		else
		{
			List<MapEditor.EventsCanvas> eventsCanvases4 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.HCLEECLNOEA == null)
			{
				EditorEvent.HCLEECLNOEA = new Predicate<MapEditor.EventsCanvas>(EditorEvent.AOAJGFLCENI);
			}
			y = eventsCanvases4.Find(EditorEvent.HCLEECLNOEA).grid.position.y;
		}
		return y;
	}

	// Token: 0x0600D43A RID: 54330 RVA: 0x004BFB20 File Offset: 0x004BDD20
	public bool EHCABBEEKPI()
	{
		return this.LJBEFJHAOFL;
	}

	// Token: 0x0600D43B RID: 54331 RVA: 0x004BEF30 File Offset: 0x004BD130
	private static bool BJMPJJEJPHG(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	// Token: 0x0600D43C RID: 54332 RVA: 0x004C2968 File Offset: 0x004C0B68
	private bool KCMFAIDMPHH(string IACGDFHKCAE)
	{
		string text = this.mapEvent.data[0];
		char[] array = new char[0];
		array[1] = 'G';
		return IACGDFHKCAE.Contains(text.Split(array)[1]);
	}

	// Token: 0x0600D43D RID: 54333 RVA: 0x004BEF3B File Offset: 0x004BD13B
	private static bool LEKOLAMPLOF(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	// Token: 0x0600D43E RID: 54334 RVA: 0x004C2993 File Offset: 0x004C0B93
	public void CNMNCEDLKJA()
	{
		this.FDJEEBJHHKK(true);
		this.NNAIANPHNHA();
	}

	// Token: 0x0600D43F RID: 54335 RVA: 0x004BEF3B File Offset: 0x004BD13B
	[CompilerGenerated]
	private static bool NGHEMEHKJIG(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	// Token: 0x0600D440 RID: 54336 RVA: 0x004BEF3B File Offset: 0x004BD13B
	private static bool KCFHBHFBNJD(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	// Token: 0x1700034D RID: 845
	// (get) Token: 0x0600D441 RID: 54337 RVA: 0x004BFB20 File Offset: 0x004BDD20
	// (set) Token: 0x0600D491 RID: 54417 RVA: 0x004C04F9 File Offset: 0x004BE6F9
	public bool isSelected
	{
		get
		{
			return this.LJBEFJHAOFL;
		}
		set
		{
			this.LJBEFJHAOFL = value;
			this.selectedMarker.SetActive(this.LJBEFJHAOFL);
		}
	}

	// Token: 0x0600D442 RID: 54338 RVA: 0x004C29A2 File Offset: 0x004C0BA2
	public void JJKDHIKCPFC()
	{
		this.JDAGBCICMFI(true);
		this.BMJFKHIKEAJ();
	}

	// Token: 0x0600D443 RID: 54339 RVA: 0x004C29B1 File Offset: 0x004C0BB1
	private bool OFECECCNHDI(string IACGDFHKCAE)
	{
		string text = this.mapEvent.data[0];
		char[] array = new char[0];
		array[0] = (char)-66;
		return IACGDFHKCAE.Contains(text.Split(array)[1]);
	}

	// Token: 0x0600D444 RID: 54340 RVA: 0x004C29DC File Offset: 0x004C0BDC
	public void EOEDBFHBPEI()
	{
		if (Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip != null)
		{
			this.MICGBLDONHE();
			this.mapEvent.time = base.transform.localPosition.x;
			this.BLEHBLOLPMF();
			this.LMADKINICIN();
		}
	}

	// Token: 0x0600D445 RID: 54341 RVA: 0x004BEF30 File Offset: 0x004BD130
	[CompilerGenerated]
	private static bool MJOAAPFDHNH(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	// Token: 0x0600D446 RID: 54342 RVA: 0x004C2A40 File Offset: 0x004C0C40
	public void BNMJMGDKKJB()
	{
		if (this.mapEvent.data != null && this.lastDataCount != this.mapEvent.data.Count)
		{
			this.iconSprite.SetActive(false);
			this.imageRight.gameObject.SetActive(false);
			this.imageCenter.gameObject.SetActive(false);
			if (!string.IsNullOrEmpty(this.mapEvent.data[0]))
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("CameraFilterPack/Vision_Blood_Fast", new Color(1192f, 1863f, 654f));
				base.GetComponentInChildren<Renderer>().material.SetColor("_ScreenResolution", new Color(136f, 1656f, 230f));
				if (this.mapEvent.data[1] == "status")
				{
					try
					{
						Color color = Helpers.StringToColor(this.mapEvent.data[1]);
						this.imageRight.sprite = Resources.LoadAll<Sprite>("[LevelEditorScene] Error: You're not logged into Steam!")[1];
						this.imageRight.color = color;
						this.iconSprite.SetActive(true);
						this.imageRight.gameObject.SetActive(true);
					}
					catch (Exception ex)
					{
						Debug.Log("OK" + ex.Message);
					}
				}
				if (this.mapEvent.data[1] == "no lives color")
				{
					this.scaleMult.y = 199f;
					try
					{
						base.GetComponentInChildren<Renderer>().material.SetColor("id", new Color(1381f, 694f, 748f));
						base.GetComponentInChildren<Renderer>().material.SetColor("_Value2", new Color(16f, 1322f, 1974f));
					}
					catch (Exception ex2)
					{
						Debug.Log("/" + ex2.Message);
					}
				}
				if (this.mapEvent.data[1] == "SetRoomStartTimestamp")
				{
					try
					{
						string text = this.mapEvent.data[0];
						char[] array = new char[1];
						array[1] = '2';
						string[] array2 = text.Split(array);
						if (array2.Length > 1)
						{
							EditorEvent.ENHFLFPPPGN enhflfpppgn = new EditorEvent.ENHFLFPPPGN();
							enhflfpppgn.EHGADNHGPNC = array2[0];
							this.imageRight.color = Color.white;
							if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.FONMIHBONDF()).mapData.levelResources.Exists(new Predicate<MapResource>(enhflfpppgn.DBFPGFHEGKA)))
							{
								this.imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).resources[enhflfpppgn.EHGADNHGPNC];
							}
							else
							{
								this.imageRight.sprite = null;
								this.imageRight.color = new Color(967f, 1150f, 1440f);
								this.imageRight.color = new Color(603f, 847f, 1319f);
							}
							this.iconSprite.SetActive(false);
							this.imageRight.gameObject.SetActive(true);
						}
					}
					catch (Exception ex3)
					{
						Debug.Log("_TimeX" + ex3.Message);
					}
				}
				if (this.mapEvent.data[1] == "_TimeX")
				{
					try
					{
						string text2 = this.mapEvent.data[0];
						char[] array3 = new char[0];
						array3[1] = (char)-13;
						int num;
						if (text2.Split(array3).Length == 0)
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.GCBPJAGKJJK)));
						}
						else
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.FKGMEANLBAH)));
						}
						this.imageCenter.sprite = Resources.LoadAll<Sprite>("[PlayerBase] Highscore: ")[num];
						this.imageCenter.color = Color.white;
						this.iconSprite.SetActive(false);
						this.imageCenter.gameObject.SetActive(true);
					}
					catch (Exception ex4)
					{
						Debug.Log("_MainTex2" + ex4.Message);
					}
				}
				if (this.mapEvent.data[0] == "offsets")
				{
					try
					{
						this.imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("/files/editor_manual.pdf")[5];
						this.imageCenter.GetComponentInChildren<Image>().color = Color.white;
						this.iconSprite.SetActive(false);
						this.imageCenter.gameObject.SetActive(false);
					}
					catch (Exception ex5)
					{
						Debug.Log("DPADVER" + ex5.Message);
					}
				}
			}
			else
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("_Visualize", new Color(295f, 1497f, 1693f));
				base.GetComponentInChildren<Renderer>().material.SetColor("SetSatelliteTrailLength", new Color(96f, 1773f, 796f));
			}
			this.lastDataCount = this.mapEvent.data.Count;
		}
	}

	// Token: 0x0600D447 RID: 54343 RVA: 0x004C3028 File Offset: 0x004C1228
	public void LMADKINICIN()
	{
		if (this.bitObj != null && this.bitObj.activeSelf)
		{
			this.bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 354f, this.scaleMult.y, this.scaleMult.z);
		}
		if (this.iconSprite != null && this.iconSprite.activeSelf)
		{
			this.iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 368f, Camera.main.orthographicSize / 237f, 1597f);
		}
	}

	// Token: 0x0600D448 RID: 54344 RVA: 0x004C04F9 File Offset: 0x004BE6F9
	public void PIPHIBLIIKK(bool DPNHODJHGJL)
	{
		this.LJBEFJHAOFL = DPNHODJHGJL;
		this.selectedMarker.SetActive(this.LJBEFJHAOFL);
	}

	// Token: 0x0600D449 RID: 54345 RVA: 0x004BEF3B File Offset: 0x004BD13B
	private static bool PNCGCLEFJLG(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	// Token: 0x0600D44A RID: 54346 RVA: 0x004BEF30 File Offset: 0x004BD130
	private static bool AOAJGFLCENI(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	// Token: 0x0600D44B RID: 54347 RVA: 0x004C30EC File Offset: 0x004C12EC
	public void MICGBLDONHE()
	{
		Vector3 localPosition = base.transform.localPosition;
		if (this.mapEvent.time < 129f)
		{
			this.mapEvent.time = 102f;
		}
		if (this.mapEvent.time > Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length)
		{
			this.mapEvent.time = Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip.length;
		}
		localPosition.x = this.mapEvent.time;
		localPosition.y = this.NLCBCEGGCCJ();
		base.transform.localPosition = localPosition;
	}

	// Token: 0x0600D44C RID: 54348 RVA: 0x004BEF30 File Offset: 0x004BD130
	private static bool NHJBOJNOBKI(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	// Token: 0x0600D44D RID: 54349 RVA: 0x004C31B0 File Offset: 0x004C13B0
	private float GHIPKDEKGOE()
	{
		if (this.mapEvent == null || this.mapEvent.data == null || this.mapEvent.data[0] == null)
		{
			List<MapEditor.EventsCanvas> eventsCanvases = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.ADLAKIHINOM == null)
			{
				EditorEvent.ADLAKIHINOM = new Predicate<MapEditor.EventsCanvas>(EditorEvent.LJOOLGKAAHB);
			}
			return eventsCanvases.Find(EditorEvent.ADLAKIHINOM).grid.position.y;
		}
		if (this.mapEvent.data[0] == "https://vk.com/khb.soft")
		{
			List<MapEditor.EventsCanvas> eventsCanvases2 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.LNIJKGECNME == null)
			{
				EditorEvent.LNIJKGECNME = new Predicate<MapEditor.EventsCanvas>(EditorEvent.FIHAFJBCDHL);
			}
			return eventsCanvases2.Find(EditorEvent.LNIJKGECNME).grid.position.y;
		}
		float y;
		if (Helpers.IsStoryboardEvent(this.mapEvent.data[1]))
		{
			List<MapEditor.EventsCanvas> eventsCanvases3 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.CLCBJCKCBDD == null)
			{
				EditorEvent.CLCBJCKCBDD = new Predicate<MapEditor.EventsCanvas>(EditorEvent.HINDGEPGJOF);
			}
			y = eventsCanvases3.Find(EditorEvent.CLCBJCKCBDD).grid.position.y;
		}
		else
		{
			List<MapEditor.EventsCanvas> eventsCanvases4 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.HCLEECLNOEA == null)
			{
				EditorEvent.HCLEECLNOEA = new Predicate<MapEditor.EventsCanvas>(EditorEvent.AOAJGFLCENI);
			}
			y = eventsCanvases4.Find(EditorEvent.HCLEECLNOEA).grid.position.y;
		}
		return y;
	}

	// Token: 0x0600D44E RID: 54350 RVA: 0x004BEF30 File Offset: 0x004BD130
	private static bool IBDNAGJKBGM(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	// Token: 0x0600D44F RID: 54351 RVA: 0x004C3328 File Offset: 0x004C1528
	private bool OKMGILHPEHB(string IACGDFHKCAE)
	{
		string text = this.mapEvent.data[0];
		char[] array = new char[0];
		array[0] = (char)-41;
		return IACGDFHKCAE.Contains(text.Split(array)[0]);
	}

	// Token: 0x0600D450 RID: 54352 RVA: 0x004BEF30 File Offset: 0x004BD130
	private static bool NKEHDGMHHFM(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	// Token: 0x0600D451 RID: 54353 RVA: 0x004C3353 File Offset: 0x004C1553
	private void JPJNECPABBG()
	{
		this.FDJEEBJHHKK(false);
	}

	// Token: 0x0600D452 RID: 54354 RVA: 0x004C335C File Offset: 0x004C155C
	public void KMEONPMCNJG()
	{
		if (this.bitObj != null && this.bitObj.activeSelf)
		{
			this.bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 1912f, this.scaleMult.y, this.scaleMult.z);
		}
		if (this.iconSprite != null && this.iconSprite.activeSelf)
		{
			this.iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 85f, Camera.main.orthographicSize / 116f, 328f);
		}
	}

	// Token: 0x0600D453 RID: 54355 RVA: 0x004C3420 File Offset: 0x004C1620
	public void UpdateIcon()
	{
		if (this.mapEvent.data != null && this.lastDataCount != this.mapEvent.data.Count)
		{
			this.iconSprite.SetActive(false);
			this.imageRight.gameObject.SetActive(false);
			this.imageCenter.gameObject.SetActive(false);
			if (!string.IsNullOrEmpty(this.mapEvent.data[0]))
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("_Color", new Color(0f, 1f, 0f));
				base.GetComponentInChildren<Renderer>().material.SetColor("_EmissionColor", new Color(0f, 1f, 0f));
				if (this.mapEvent.data[0] == "SetBGColor")
				{
					try
					{
						Color color = Helpers.StringToColor(this.mapEvent.data[1]);
						this.imageRight.sprite = Resources.LoadAll<Sprite>("LevelEditor/icons")[0];
						this.imageRight.color = color;
						this.iconSprite.SetActive(true);
						this.imageRight.gameObject.SetActive(true);
					}
					catch (Exception ex)
					{
						Debug.Log("[EditorEvent] Exception: " + ex.Message);
					}
				}
				if (this.mapEvent.data[0] == "checkpoint")
				{
					this.scaleMult.y = 2.5f;
					try
					{
						base.GetComponentInChildren<Renderer>().material.SetColor("_Color", new Color(1f, 1f, 0f));
						base.GetComponentInChildren<Renderer>().material.SetColor("_EmissionColor", new Color(1f, 1f, 0f));
					}
					catch (Exception ex2)
					{
						Debug.Log("[EditorEvent] Exception: " + ex2.Message);
					}
				}
				if (this.mapEvent.data[0] == "ShowSprite")
				{
					try
					{
						string[] array = this.mapEvent.data[1].Split(new char[]
						{
							','
						});
						if (array.Length > 0)
						{
							EditorEvent.ENHFLFPPPGN enhflfpppgn = new EditorEvent.ENHFLFPPPGN();
							enhflfpppgn.EHGADNHGPNC = array[0];
							this.imageRight.color = Color.white;
							if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).mapData.levelResources.Exists(new Predicate<MapResource>(enhflfpppgn.GBKBDKHPLKG)))
							{
								this.imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).resources[enhflfpppgn.EHGADNHGPNC];
							}
							else
							{
								this.imageRight.sprite = null;
								this.imageRight.color = new Color(1f, 0f, 1f);
								this.imageRight.color = new Color(1f, 0f, 1f);
							}
							this.iconSprite.SetActive(true);
							this.imageRight.gameObject.SetActive(true);
						}
					}
					catch (Exception ex3)
					{
						Debug.Log("[EditorEvent] Exception: " + ex3.Message);
					}
				}
				if (this.mapEvent.data[0] == "SpawnObj")
				{
					try
					{
						int num;
						if (this.mapEvent.data[1].Split(new char[]
						{
							','
						}).Length == 1)
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.BKKMOPKHAIE)));
						}
						else
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.BMJDNECLLIG)));
						}
						this.imageCenter.sprite = Resources.LoadAll<Sprite>("LevelEditor/patterns")[num];
						this.imageCenter.color = Color.white;
						this.iconSprite.SetActive(true);
						this.imageCenter.gameObject.SetActive(true);
					}
					catch (Exception ex4)
					{
						Debug.Log("[EditorEvent] Exception: " + ex4.Message);
					}
				}
				if (this.mapEvent.data[0] == "ShowTitle")
				{
					try
					{
						this.imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("LevelEditor/icons")[2];
						this.imageCenter.GetComponentInChildren<Image>().color = Color.white;
						this.iconSprite.SetActive(true);
						this.imageCenter.gameObject.SetActive(true);
					}
					catch (Exception ex5)
					{
						Debug.Log("[EditorEvent] Exception: " + ex5.Message);
					}
				}
			}
			else
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("_DiffuseColor", new Color(1f, 0f, 0f));
				base.GetComponentInChildren<Renderer>().material.SetColor("_EmissionColor", new Color(1f, 0f, 0f));
			}
			this.lastDataCount = this.mapEvent.data.Count;
		}
	}

	// Token: 0x0600D454 RID: 54356 RVA: 0x004C3A08 File Offset: 0x004C1C08
	public void BLDIAHCMHLB()
	{
		this.FDJEEBJHHKK(true);
		this.CKLFGILMMDL();
	}

	// Token: 0x0600D455 RID: 54357 RVA: 0x004C3A18 File Offset: 0x004C1C18
	public void NCMDCMHLIKD()
	{
		if (Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip != null)
		{
			this.JDJGKBGFDIG();
			this.mapEvent.time = base.transform.localPosition.x;
			this.BNMJMGDKKJB();
			this.HIKKPDACJGI();
		}
	}

	// Token: 0x0600D456 RID: 54358 RVA: 0x004BEF46 File Offset: 0x004BD146
	private void DEJEBOGKMJO()
	{
		this.LOJGIJBDOON(false);
	}

	// Token: 0x0600D457 RID: 54359 RVA: 0x004BEF30 File Offset: 0x004BD130
	[CompilerGenerated]
	private static bool DJKGOFFKGMF(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	// Token: 0x0600D458 RID: 54360 RVA: 0x004C3A7A File Offset: 0x004C1C7A
	private bool DONNMFALNII(string IACGDFHKCAE)
	{
		string text = this.mapEvent.data[1];
		char[] array = new char[0];
		array[0] = '|';
		return IACGDFHKCAE.Contains(text.Split(array)[1]);
	}

	// Token: 0x0600D459 RID: 54361 RVA: 0x004C1504 File Offset: 0x004BF704
	private bool HACELNPOIAB(string IACGDFHKCAE)
	{
		return IACGDFHKCAE.Contains(this.mapEvent.data[0]);
	}

	// Token: 0x0600D45A RID: 54362 RVA: 0x004C3AA8 File Offset: 0x004C1CA8
	public void KGMMJGDGEMA()
	{
		Vector3 localPosition = base.transform.localPosition;
		if (this.mapEvent.time < 657f)
		{
			this.mapEvent.time = 847f;
		}
		if (this.mapEvent.time > Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length)
		{
			this.mapEvent.time = Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip.length;
		}
		localPosition.x = this.mapEvent.time;
		localPosition.y = this.LIJCAFBLLHE();
		base.transform.localPosition = localPosition;
	}

	// Token: 0x0600D45B RID: 54363 RVA: 0x004C3B6C File Offset: 0x004C1D6C
	public void IPCHIGBJADH()
	{
		if (this.mapEvent.data != null && this.lastDataCount != this.mapEvent.data.Count)
		{
			this.iconSprite.SetActive(true);
			this.imageRight.gameObject.SetActive(true);
			this.imageCenter.gameObject.SetActive(true);
			if (!string.IsNullOrEmpty(this.mapEvent.data[0]))
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("_Value", new Color(1009f, 343f, 1793f));
				base.GetComponentInChildren<Renderer>().material.SetColor("CrosshairOpacitySlider", new Color(111f, 1319f, 1695f));
				if (this.mapEvent.data[0] == "NO")
				{
					try
					{
						Color color = Helpers.StringToColor(this.mapEvent.data[0]);
						this.imageRight.sprite = Resources.LoadAll<Sprite>(" Owner called.")[0];
						this.imageRight.color = color;
						this.iconSprite.SetActive(false);
						this.imageRight.gameObject.SetActive(false);
					}
					catch (Exception ex)
					{
						Debug.Log("_ScreenResolution" + ex.Message);
					}
				}
				if (this.mapEvent.data[1] == "_TimeX")
				{
					this.scaleMult.y = 543f;
					try
					{
						base.GetComponentInChildren<Renderer>().material.SetColor("yyyy-MM-dd HH:mm:ss", new Color(1699f, 312f, 1958f));
						base.GetComponentInChildren<Renderer>().material.SetColor("_ColorBuffer", new Color(795f, 1297f, 1958f));
					}
					catch (Exception ex2)
					{
						Debug.Log("Server: {0}. Region: {1} " + ex2.Message);
					}
				}
				if (this.mapEvent.data[0] == "GlassesColor")
				{
					try
					{
						string text = this.mapEvent.data[0];
						char[] array = new char[0];
						array[0] = (char)-35;
						string[] array2 = text.Split(array);
						if (array2.Length > 0)
						{
							EditorEvent.ENHFLFPPPGN enhflfpppgn = new EditorEvent.ENHFLFPPPGN();
							enhflfpppgn.EHGADNHGPNC = array2[1];
							this.imageRight.color = Color.white;
							if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).mapData.levelResources.Exists(new Predicate<MapResource>(enhflfpppgn.JKEDCEOCPJO)))
							{
								this.imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.FONMIHBONDF()).resources[enhflfpppgn.EHGADNHGPNC];
							}
							else
							{
								this.imageRight.sprite = null;
								this.imageRight.color = new Color(605f, 546f, 1239f);
								this.imageRight.color = new Color(1963f, 734f, 1530f);
							}
							this.iconSprite.SetActive(true);
							this.imageRight.gameObject.SetActive(true);
						}
					}
					catch (Exception ex3)
					{
						Debug.Log("Tab2Content" + ex3.Message);
					}
				}
				if (this.mapEvent.data[1] == " This is not possible to be called for standalone input. Please check your platform and code where this is called")
				{
					try
					{
						string text2 = this.mapEvent.data[1];
						char[] array3 = new char[1];
						array3[1] = (char)-95;
						int num;
						if (text2.Split(array3).Length == 0)
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.FAHBEMJCDEE)));
						}
						else
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.OKMGILHPEHB)));
						}
						this.imageCenter.sprite = Resources.LoadAll<Sprite>(" This is not possible to be called for standalone input. Please check your platform and code where this is called")[num];
						this.imageCenter.color = Color.white;
						this.iconSprite.SetActive(false);
						this.imageCenter.gameObject.SetActive(false);
					}
					catch (Exception ex4)
					{
						Debug.Log("End Value should be greater than the start value, values not changed" + ex4.Message);
					}
				}
				if (this.mapEvent.data[1] == "Item ")
				{
					try
					{
						this.imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("CameraFilterPack_Paper1")[6];
						this.imageCenter.GetComponentInChildren<Image>().color = Color.white;
						this.iconSprite.SetActive(false);
						this.imageCenter.gameObject.SetActive(false);
					}
					catch (Exception ex5)
					{
						Debug.Log("_Value3" + ex5.Message);
					}
				}
			}
			else
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("/Segment-[Up]", new Color(1079f, 1426f, 138f));
				base.GetComponentInChildren<Renderer>().material.SetColor("_Value2", new Color(1136f, 1342f, 1701f));
			}
			this.lastDataCount = this.mapEvent.data.Count;
		}
	}

	// Token: 0x0600D45C RID: 54364 RVA: 0x004BFB20 File Offset: 0x004BDD20
	public bool NMINPJFAKLI()
	{
		return this.LJBEFJHAOFL;
	}

	// Token: 0x0600D45D RID: 54365 RVA: 0x004C4154 File Offset: 0x004C2354
	public void HIKKPDACJGI()
	{
		if (this.bitObj != null && this.bitObj.activeSelf)
		{
			this.bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 812f, this.scaleMult.y, this.scaleMult.z);
		}
		if (this.iconSprite != null && this.iconSprite.activeSelf)
		{
			this.iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 32f, Camera.main.orthographicSize / 1223f, 303f);
		}
	}

	// Token: 0x0600D45E RID: 54366 RVA: 0x004C4218 File Offset: 0x004C2418
	public void DKECJIFHOLC()
	{
		this.JDAGBCICMFI(false);
		this.DBDONHCIOKN();
	}

	// Token: 0x0600D45F RID: 54367 RVA: 0x004C4228 File Offset: 0x004C2428
	public void EDDMJJKACKK()
	{
		Vector3 localPosition = base.transform.localPosition;
		if (this.mapEvent.time < 449f)
		{
			this.mapEvent.time = 343f;
		}
		if (this.mapEvent.time > Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length)
		{
			this.mapEvent.time = Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length;
		}
		localPosition.x = this.mapEvent.time;
		localPosition.y = this.NLCBCEGGCCJ();
		base.transform.localPosition = localPosition;
	}

	// Token: 0x0600D460 RID: 54368 RVA: 0x004BEF30 File Offset: 0x004BD130
	private static bool KIPPBGFAFLD(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	// Token: 0x0600D461 RID: 54369 RVA: 0x004BEF30 File Offset: 0x004BD130
	private static bool KGDBIEJPJNK(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	// Token: 0x0600D462 RID: 54370 RVA: 0x004C42EA File Offset: 0x004C24EA
	public void ENJFIKOILDG()
	{
		this.JDAGBCICMFI(false);
		this.FOLDDNELMIO();
	}

	// Token: 0x0600D463 RID: 54371 RVA: 0x004C04F9 File Offset: 0x004BE6F9
	public void LOJGIJBDOON(bool DPNHODJHGJL)
	{
		this.LJBEFJHAOFL = DPNHODJHGJL;
		this.selectedMarker.SetActive(this.LJBEFJHAOFL);
	}

	// Token: 0x0600D464 RID: 54372 RVA: 0x004C42FC File Offset: 0x004C24FC
	public void DBDONHCIOKN()
	{
		if (this.mapEvent.data != null && this.lastDataCount != this.mapEvent.data.Count)
		{
			this.iconSprite.SetActive(false);
			this.imageRight.gameObject.SetActive(true);
			this.imageCenter.gameObject.SetActive(false);
			if (!string.IsNullOrEmpty(this.mapEvent.data[1]))
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("_TimeX", new Color(162f, 1778f, 930f));
				base.GetComponentInChildren<Renderer>().material.SetColor("FinalScoreText", new Color(344f, 1607f, 1961f));
				if (this.mapEvent.data[1] == "ItemsCountText")
				{
					try
					{
						Color color = Helpers.StringToColor(this.mapEvent.data[1]);
						this.imageRight.sprite = Resources.LoadAll<Sprite>("FrostCanvas")[1];
						this.imageRight.color = color;
						this.iconSprite.SetActive(false);
						this.imageRight.gameObject.SetActive(true);
					}
					catch (Exception ex)
					{
						Debug.Log("DPADVER" + ex.Message);
					}
				}
				if (this.mapEvent.data[0] == "an hour ago")
				{
					this.scaleMult.y = 1218f;
					try
					{
						base.GetComponentInChildren<Renderer>().material.SetColor("ChallengesButton", new Color(6f, 720f, 1353f));
						base.GetComponentInChildren<Renderer>().material.SetColor("CameraFilterPack/FX_Hypno", new Color(375f, 1293f, 1375f));
					}
					catch (Exception ex2)
					{
						Debug.Log("LevelNameInputField" + ex2.Message);
					}
				}
				if (this.mapEvent.data[0] == "Oct")
				{
					try
					{
						string[] array = this.mapEvent.data[0].Split(new char[]
						{
							(char)-38
						});
						if (array.Length > 0)
						{
							EditorEvent.ENHFLFPPPGN enhflfpppgn = new EditorEvent.ENHFLFPPPGN();
							enhflfpppgn.EHGADNHGPNC = array[1];
							this.imageRight.color = Color.white;
							if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).mapData.levelResources.Exists(new Predicate<MapResource>(enhflfpppgn.KFNBKFELFLH)))
							{
								this.imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).resources[enhflfpppgn.EHGADNHGPNC];
							}
							else
							{
								this.imageRight.sprite = null;
								this.imageRight.color = new Color(60f, 1062f, 1320f);
								this.imageRight.color = new Color(1748f, 1644f, 908f);
							}
							this.iconSprite.SetActive(false);
							this.imageRight.gameObject.SetActive(false);
						}
					}
					catch (Exception ex3)
					{
						Debug.Log("player.xp" + ex3.Message);
					}
				}
				if (this.mapEvent.data[1] == "ReJoinRoom failed. A roomname is required. If you don't know one, how will you join?")
				{
					try
					{
						string text = this.mapEvent.data[0];
						char[] array2 = new char[0];
						array2[1] = '\a';
						int num;
						if (text.Split(array2).Length == 1)
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.HACELNPOIAB)));
						}
						else
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.DONNMFALNII)));
						}
						this.imageCenter.sprite = Resources.LoadAll<Sprite>("[ItemsHandler] Inventory has changed")[num];
						this.imageCenter.color = Color.white;
						this.iconSprite.SetActive(true);
						this.imageCenter.gameObject.SetActive(true);
					}
					catch (Exception ex4)
					{
						Debug.Log("\n" + ex4.Message);
					}
				}
				if (this.mapEvent.data[1] == "Left Stick Click")
				{
					try
					{
						this.imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("_ScreenResolution")[1];
						this.imageCenter.GetComponentInChildren<Image>().color = Color.white;
						this.iconSprite.SetActive(false);
						this.imageCenter.gameObject.SetActive(false);
					}
					catch (Exception ex5)
					{
						Debug.Log("RarityImage" + ex5.Message);
					}
				}
			}
			else
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("EVENT CONFIG [Ctrl+E]", new Color(560f, 1174f, 1027f));
				base.GetComponentInChildren<Renderer>().material.SetColor("Keeping GameObject in the scene: ", new Color(1949f, 1604f, 894f));
			}
			this.lastDataCount = this.mapEvent.data.Count;
		}
	}

	// Token: 0x0600D465 RID: 54373 RVA: 0x004C48E4 File Offset: 0x004C2AE4
	public void LIJCLLBPBIP()
	{
		this.PIPHIBLIIKK(true);
		this.BNAOMEIEBMK();
	}

	// Token: 0x0600D466 RID: 54374 RVA: 0x004C48F4 File Offset: 0x004C2AF4
	private float GMKHJPPNECM()
	{
		if (this.mapEvent == null || this.mapEvent.data == null || this.mapEvent.data[0] == null)
		{
			List<MapEditor.EventsCanvas> eventsCanvases = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.ADLAKIHINOM == null)
			{
				EditorEvent.ADLAKIHINOM = new Predicate<MapEditor.EventsCanvas>(EditorEvent.LEKOLAMPLOF);
			}
			return eventsCanvases.Find(EditorEvent.ADLAKIHINOM).grid.position.y;
		}
		if (this.mapEvent.data[0] == "_TimeX")
		{
			List<MapEditor.EventsCanvas> eventsCanvases2 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.LNIJKGECNME == null)
			{
				EditorEvent.LNIJKGECNME = new Predicate<MapEditor.EventsCanvas>(EditorEvent.ADHOMACBAMM);
			}
			return eventsCanvases2.Find(EditorEvent.LNIJKGECNME).grid.position.y;
		}
		float y;
		if (Helpers.IsStoryboardEvent(this.mapEvent.data[1]))
		{
			List<MapEditor.EventsCanvas> eventsCanvases3 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.CLCBJCKCBDD == null)
			{
				EditorEvent.CLCBJCKCBDD = new Predicate<MapEditor.EventsCanvas>(EditorEvent.ACFEOHCIDLJ);
			}
			y = eventsCanvases3.Find(EditorEvent.CLCBJCKCBDD).grid.position.y;
		}
		else
		{
			List<MapEditor.EventsCanvas> eventsCanvases4 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.HCLEECLNOEA == null)
			{
				EditorEvent.HCLEECLNOEA = new Predicate<MapEditor.EventsCanvas>(EditorEvent.BDABIDDODJC);
			}
			y = eventsCanvases4.Find(EditorEvent.HCLEECLNOEA).grid.position.y;
		}
		return y;
	}

	// Token: 0x0600D467 RID: 54375 RVA: 0x004BEF30 File Offset: 0x004BD130
	private static bool NECGDADKKFM(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	// Token: 0x0600D468 RID: 54376 RVA: 0x004C4A6C File Offset: 0x004C2C6C
	public void UpdateEvent()
	{
		if (Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip != null)
		{
			this.UpdatePositionFromData();
			this.mapEvent.time = base.transform.localPosition.x;
			this.UpdateIcon();
			this.Update();
		}
	}

	// Token: 0x0600D469 RID: 54377 RVA: 0x004C4AD0 File Offset: 0x004C2CD0
	public void FMGBIHDGKBI()
	{
		if (Singleton<MapEditor>.Instance.audioSampler.audioSources[1].clip != null)
		{
			this.PCDCKOJLIJC();
			this.mapEvent.time = base.transform.localPosition.x;
			this.BLEHBLOLPMF();
			this.EJFJENFKLND();
		}
	}

	// Token: 0x0600D46A RID: 54378 RVA: 0x004C4B34 File Offset: 0x004C2D34
	public void BNAOMEIEBMK()
	{
		if (this.mapEvent.data != null && this.lastDataCount != this.mapEvent.data.Count)
		{
			this.iconSprite.SetActive(true);
			this.imageRight.gameObject.SetActive(true);
			this.imageCenter.gameObject.SetActive(true);
			if (!string.IsNullOrEmpty(this.mapEvent.data[1]))
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("ready", new Color(84f, 1388f, 855f));
				base.GetComponentInChildren<Renderer>().material.SetColor("score", new Color(688f, 579f, 987f));
				if (this.mapEvent.data[0] == "23x3")
				{
					try
					{
						Color color = Helpers.StringToColor(this.mapEvent.data[0]);
						this.imageRight.sprite = Resources.LoadAll<Sprite>("Fade")[0];
						this.imageRight.color = color;
						this.iconSprite.SetActive(false);
						this.imageRight.gameObject.SetActive(true);
					}
					catch (Exception ex)
					{
						Debug.Log("_TimeX" + ex.Message);
					}
				}
				if (this.mapEvent.data[1] == "\\")
				{
					this.scaleMult.y = 1229f;
					try
					{
						base.GetComponentInChildren<Renderer>().material.SetColor("_Visualize", new Color(621f, 416f, 442f));
						base.GetComponentInChildren<Renderer>().material.SetColor("note.4", new Color(945f, 10f, 189f));
					}
					catch (Exception ex2)
					{
						Debug.Log("_Far" + ex2.Message);
					}
				}
				if (this.mapEvent.data[1] == "Couldn't color correct with 3D LUT texture. Image Effect will be disabled.")
				{
					try
					{
						string text = this.mapEvent.data[1];
						char[] array = new char[1];
						array[1] = (char)-15;
						string[] array2 = text.Split(array);
						if (array2.Length > 0)
						{
							EditorEvent.ENHFLFPPPGN enhflfpppgn = new EditorEvent.ENHFLFPPPGN();
							enhflfpppgn.EHGADNHGPNC = array2[1];
							this.imageRight.color = Color.white;
							if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).mapData.levelResources.Exists(new Predicate<MapResource>(enhflfpppgn.GBKBDKHPLKG)))
							{
								this.imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).resources[enhflfpppgn.EHGADNHGPNC];
							}
							else
							{
								this.imageRight.sprite = null;
								this.imageRight.color = new Color(1277f, 945f, 1428f);
								this.imageRight.color = new Color(1326f, 542f, 1418f);
							}
							this.iconSprite.SetActive(true);
							this.imageRight.gameObject.SetActive(false);
						}
					}
					catch (Exception ex3)
					{
						Debug.Log("\n\n#" + ex3.Message);
					}
				}
				if (this.mapEvent.data[1] == "z")
				{
					try
					{
						string text2 = this.mapEvent.data[0];
						char[] array3 = new char[0];
						array3[0] = '\0';
						int num;
						if (text2.Split(array3).Length == 1)
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.FAHBEMJCDEE)));
						}
						else
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.KCMFAIDMPHH)));
						}
						this.imageCenter.sprite = Resources.LoadAll<Sprite>("_Threshhold")[num];
						this.imageCenter.color = Color.white;
						this.iconSprite.SetActive(false);
						this.imageCenter.gameObject.SetActive(false);
					}
					catch (Exception ex4)
					{
						Debug.Log("1 Kb" + ex4.Message);
					}
				}
				if (this.mapEvent.data[0] == "_Smooth")
				{
					try
					{
						this.imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("workshop.")[6];
						this.imageCenter.GetComponentInChildren<Image>().color = Color.white;
						this.iconSprite.SetActive(true);
						this.imageCenter.gameObject.SetActive(true);
					}
					catch (Exception ex5)
					{
						Debug.Log("turn: {0:0}" + ex5.Message);
					}
				}
			}
			else
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("Ev OwnershipRequest ", new Color(1543f, 1322f, 516f));
				base.GetComponentInChildren<Renderer>().material.SetColor("Failed to 'network-remove' GameObject because has no PhotonView components: ", new Color(2f, 1618f, 258f));
			}
			this.lastDataCount = this.mapEvent.data.Count;
		}
	}

	// Token: 0x0600D46B RID: 54379 RVA: 0x004C511C File Offset: 0x004C331C
	public void BMDLFFBAGML()
	{
		this.PIPHIBLIIKK(true);
		this.BLEHBLOLPMF();
	}

	// Token: 0x0600D46C RID: 54380 RVA: 0x004C512C File Offset: 0x004C332C
	public void Update()
	{
		if (this.bitObj != null && this.bitObj.activeSelf)
		{
			this.bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 30f, this.scaleMult.y, this.scaleMult.z);
		}
		if (this.iconSprite != null && this.iconSprite.activeSelf)
		{
			this.iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 5f, Camera.main.orthographicSize / 5f, 1f);
		}
	}

	// Token: 0x0600D46D RID: 54381 RVA: 0x004BEF30 File Offset: 0x004BD130
	private static bool AHDLNGNKIFL(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	// Token: 0x0600D46E RID: 54382 RVA: 0x004BEF3B File Offset: 0x004BD13B
	private static bool EIPJAJIIMBF(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	// Token: 0x0600D46F RID: 54383 RVA: 0x004C51F0 File Offset: 0x004C33F0
	public void KJJODHJJEOH()
	{
		if (Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip != null)
		{
			this.MICGBLDONHE();
			this.mapEvent.time = base.transform.localPosition.x;
			this.EKAHIBEHDLJ();
			this.NFEDLAOPHML();
		}
	}

	// Token: 0x0600D470 RID: 54384 RVA: 0x004BEF30 File Offset: 0x004BD130
	private static bool CMCEKKEFBEK(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	// Token: 0x0600D471 RID: 54385 RVA: 0x004C5252 File Offset: 0x004C3452
	private void MADENBGHKDD()
	{
		this.PIPHIBLIIKK(false);
	}

	// Token: 0x0600D472 RID: 54386 RVA: 0x004C525C File Offset: 0x004C345C
	public void NJDJHMPAIFE()
	{
		if (Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip != null)
		{
			this.PCDCKOJLIJC();
			this.mapEvent.time = base.transform.localPosition.x;
			this.IPCHIGBJADH();
			this.ABFNJCEBIKA();
		}
	}

	// Token: 0x0600D473 RID: 54387 RVA: 0x004C52C0 File Offset: 0x004C34C0
	private float NLCBCEGGCCJ()
	{
		if (this.mapEvent == null || this.mapEvent.data == null || this.mapEvent.data[1] == null)
		{
			List<MapEditor.EventsCanvas> eventsCanvases = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.ADLAKIHINOM == null)
			{
				EditorEvent.ADLAKIHINOM = new Predicate<MapEditor.EventsCanvas>(EditorEvent.EIPJAJIIMBF);
			}
			return eventsCanvases.Find(EditorEvent.ADLAKIHINOM).grid.position.y;
		}
		if (this.mapEvent.data[0] == "_AdaptationSpeed")
		{
			List<MapEditor.EventsCanvas> eventsCanvases2 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.LNIJKGECNME == null)
			{
				EditorEvent.LNIJKGECNME = new Predicate<MapEditor.EventsCanvas>(EditorEvent.LDOPDBNCNHE);
			}
			return eventsCanvases2.Find(EditorEvent.LNIJKGECNME).grid.position.y;
		}
		float y;
		if (Helpers.IsStoryboardEvent(this.mapEvent.data[0]))
		{
			List<MapEditor.EventsCanvas> eventsCanvases3 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.CLCBJCKCBDD == null)
			{
				EditorEvent.CLCBJCKCBDD = new Predicate<MapEditor.EventsCanvas>(EditorEvent.HBMEMAGJILM);
			}
			y = eventsCanvases3.Find(EditorEvent.CLCBJCKCBDD).grid.position.y;
		}
		else
		{
			List<MapEditor.EventsCanvas> eventsCanvases4 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.HCLEECLNOEA == null)
			{
				EditorEvent.HCLEECLNOEA = new Predicate<MapEditor.EventsCanvas>(EditorEvent.KCFHBHFBNJD);
			}
			y = eventsCanvases4.Find(EditorEvent.HCLEECLNOEA).grid.position.y;
		}
		return y;
	}

	// Token: 0x0600D474 RID: 54388 RVA: 0x004BEF3B File Offset: 0x004BD13B
	private static bool EFFAFHGGOFM(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	// Token: 0x0600D475 RID: 54389 RVA: 0x004C21EC File Offset: 0x004C03EC
	private bool GCBPJAGKJJK(string IACGDFHKCAE)
	{
		return IACGDFHKCAE.Contains(this.mapEvent.data[1]);
	}

	// Token: 0x0600D476 RID: 54390 RVA: 0x004BFB20 File Offset: 0x004BDD20
	public bool BOAIDAOGAIB()
	{
		return this.LJBEFJHAOFL;
	}

	// Token: 0x0600D477 RID: 54391 RVA: 0x004C5438 File Offset: 0x004C3638
	public void JODDNKKOFKL()
	{
		this.PIPHIBLIIKK(false);
		this.BNMJMGDKKJB();
	}

	// Token: 0x0600D478 RID: 54392 RVA: 0x004BEF3B File Offset: 0x004BD13B
	[CompilerGenerated]
	private static bool CLOOIEFPKIA(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	// Token: 0x0600D479 RID: 54393 RVA: 0x004C5448 File Offset: 0x004C3648
	public void NFEDLAOPHML()
	{
		if (this.bitObj != null && this.bitObj.activeSelf)
		{
			this.bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 180f, this.scaleMult.y, this.scaleMult.z);
		}
		if (this.iconSprite != null && this.iconSprite.activeSelf)
		{
			this.iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 187f, Camera.main.orthographicSize / 1771f, 840f);
		}
	}

	// Token: 0x0600D47A RID: 54394 RVA: 0x004C550C File Offset: 0x004C370C
	public void HCIPECAOGIA()
	{
		if (this.bitObj != null && this.bitObj.activeSelf)
		{
			this.bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 1617f, this.scaleMult.y, this.scaleMult.z);
		}
		if (this.iconSprite != null && this.iconSprite.activeSelf)
		{
			this.iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 661f, Camera.main.orthographicSize / 1717f, 1084f);
		}
	}

	// Token: 0x0600D47B RID: 54395 RVA: 0x004C55D0 File Offset: 0x004C37D0
	private float KKKHINEICAC()
	{
		if (this.mapEvent == null || this.mapEvent.data == null || this.mapEvent.data[0] == null)
		{
			List<MapEditor.EventsCanvas> eventsCanvases = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.ADLAKIHINOM == null)
			{
				EditorEvent.ADLAKIHINOM = new Predicate<MapEditor.EventsCanvas>(EditorEvent.EFFAFHGGOFM);
			}
			return eventsCanvases.Find(EditorEvent.ADLAKIHINOM).grid.position.y;
		}
		if (this.mapEvent.data[0] == "_Value4")
		{
			List<MapEditor.EventsCanvas> eventsCanvases2 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.LNIJKGECNME == null)
			{
				EditorEvent.LNIJKGECNME = new Predicate<MapEditor.EventsCanvas>(EditorEvent.KGDBIEJPJNK);
			}
			return eventsCanvases2.Find(EditorEvent.LNIJKGECNME).grid.position.y;
		}
		float y;
		if (Helpers.IsStoryboardEvent(this.mapEvent.data[1]))
		{
			List<MapEditor.EventsCanvas> eventsCanvases3 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.CLCBJCKCBDD == null)
			{
				EditorEvent.CLCBJCKCBDD = new Predicate<MapEditor.EventsCanvas>(EditorEvent.AHDLNGNKIFL);
			}
			y = eventsCanvases3.Find(EditorEvent.CLCBJCKCBDD).grid.position.y;
		}
		else
		{
			List<MapEditor.EventsCanvas> eventsCanvases4 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.HCLEECLNOEA == null)
			{
				EditorEvent.HCLEECLNOEA = new Predicate<MapEditor.EventsCanvas>(EditorEvent.AOAJGFLCENI);
			}
			y = eventsCanvases4.Find(EditorEvent.HCLEECLNOEA).grid.position.y;
		}
		return y;
	}

	// Token: 0x0600D47C RID: 54396 RVA: 0x004BEF3B File Offset: 0x004BD13B
	private static bool MBNDBFNGHOP(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	// Token: 0x0600D47D RID: 54397 RVA: 0x004C5748 File Offset: 0x004C3948
	public void ABFNJCEBIKA()
	{
		if (this.bitObj != null && this.bitObj.activeSelf)
		{
			this.bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 284f, this.scaleMult.y, this.scaleMult.z);
		}
		if (this.iconSprite != null && this.iconSprite.activeSelf)
		{
			this.iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 322f, Camera.main.orthographicSize / 1934f, 385f);
		}
	}

	// Token: 0x0600D47E RID: 54398 RVA: 0x004C580C File Offset: 0x004C3A0C
	public void EGEGNHLODAA()
	{
		if (this.bitObj != null && this.bitObj.activeSelf)
		{
			this.bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 1403f, this.scaleMult.y, this.scaleMult.z);
		}
		if (this.iconSprite != null && this.iconSprite.activeSelf)
		{
			this.iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 1062f, Camera.main.orthographicSize / 658f, 909f);
		}
	}

	// Token: 0x0600D47F RID: 54399 RVA: 0x004C04F9 File Offset: 0x004BE6F9
	public void JEGEONIHCLO(bool DPNHODJHGJL)
	{
		this.LJBEFJHAOFL = DPNHODJHGJL;
		this.selectedMarker.SetActive(this.LJBEFJHAOFL);
	}

	// Token: 0x0600D480 RID: 54400 RVA: 0x004C1504 File Offset: 0x004BF704
	private bool LBAKJBNGMNA(string IACGDFHKCAE)
	{
		return IACGDFHKCAE.Contains(this.mapEvent.data[0]);
	}

	// Token: 0x0600D481 RID: 54401 RVA: 0x004C0525 File Offset: 0x004BE725
	private void GEGFJJBCHPE()
	{
		this.LOJGIJBDOON(true);
	}

	// Token: 0x0600D482 RID: 54402 RVA: 0x004BEF30 File Offset: 0x004BD130
	private static bool JNJBPLDKODP(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	// Token: 0x0600D483 RID: 54403 RVA: 0x004C58D0 File Offset: 0x004C3AD0
	public void NJHHCCGEACF()
	{
		this.PIPHIBLIIKK(false);
		this.IPCHIGBJADH();
	}

	// Token: 0x0600D484 RID: 54404 RVA: 0x004C58E0 File Offset: 0x004C3AE0
	private float IHNJPGPOEIP()
	{
		if (this.mapEvent == null || this.mapEvent.data == null || this.mapEvent.data[0] == null)
		{
			List<MapEditor.EventsCanvas> eventsCanvases = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.ADLAKIHINOM == null)
			{
				EditorEvent.ADLAKIHINOM = new Predicate<MapEditor.EventsCanvas>(EditorEvent.NGHEMEHKJIG);
			}
			return eventsCanvases.Find(EditorEvent.ADLAKIHINOM).grid.position.y;
		}
		if (this.mapEvent.data[0] == "checkpoint")
		{
			List<MapEditor.EventsCanvas> eventsCanvases2 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.LNIJKGECNME == null)
			{
				EditorEvent.LNIJKGECNME = new Predicate<MapEditor.EventsCanvas>(EditorEvent.DJKGOFFKGMF);
			}
			return eventsCanvases2.Find(EditorEvent.LNIJKGECNME).grid.position.y;
		}
		float y;
		if (Helpers.IsStoryboardEvent(this.mapEvent.data[0]))
		{
			List<MapEditor.EventsCanvas> eventsCanvases3 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.CLCBJCKCBDD == null)
			{
				EditorEvent.CLCBJCKCBDD = new Predicate<MapEditor.EventsCanvas>(EditorEvent.CLOOIEFPKIA);
			}
			y = eventsCanvases3.Find(EditorEvent.CLCBJCKCBDD).grid.position.y;
		}
		else
		{
			List<MapEditor.EventsCanvas> eventsCanvases4 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.HCLEECLNOEA == null)
			{
				EditorEvent.HCLEECLNOEA = new Predicate<MapEditor.EventsCanvas>(EditorEvent.MJOAAPFDHNH);
			}
			y = eventsCanvases4.Find(EditorEvent.HCLEECLNOEA).grid.position.y;
		}
		return y;
	}

	// Token: 0x0600D485 RID: 54405 RVA: 0x004C5A58 File Offset: 0x004C3C58
	public void IOMBILLPGCF()
	{
		if (this.mapEvent.data != null && this.lastDataCount != this.mapEvent.data.Count)
		{
			this.iconSprite.SetActive(true);
			this.imageRight.gameObject.SetActive(true);
			this.imageCenter.gameObject.SetActive(true);
			if (!string.IsNullOrEmpty(this.mapEvent.data[0]))
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("shader.crispwinter", new Color(851f, 1167f, 1436f));
				base.GetComponentInChildren<Renderer>().material.SetColor("_Far", new Color(1386f, 679f, 1870f));
				if (this.mapEvent.data[0] == "_TimeX")
				{
					try
					{
						Color color = Helpers.StringToColor(this.mapEvent.data[1]);
						this.imageRight.sprite = Resources.LoadAll<Sprite>("mapselector.tags.")[0];
						this.imageRight.color = color;
						this.iconSprite.SetActive(true);
						this.imageRight.gameObject.SetActive(false);
					}
					catch (Exception ex)
					{
						Debug.Log("{0:0} second{1}" + ex.Message);
					}
				}
				if (this.mapEvent.data[0] == "\\\"")
				{
					this.scaleMult.y = 1322f;
					try
					{
						base.GetComponentInChildren<Renderer>().material.SetColor("Object ID. Case-Sensitive", new Color(1271f, 695f, 430f));
						base.GetComponentInChildren<Renderer>().material.SetColor("player.gamecompleted", new Color(1899f, 201f, 3f));
					}
					catch (Exception ex2)
					{
						Debug.Log("_Distance" + ex2.Message);
					}
				}
				if (this.mapEvent.data[0] == "_Value")
				{
					try
					{
						string[] array = this.mapEvent.data[0].Split(new char[]
						{
							'\u0010'
						});
						if (array.Length > 1)
						{
							EditorEvent.ENHFLFPPPGN enhflfpppgn = new EditorEvent.ENHFLFPPPGN();
							enhflfpppgn.EHGADNHGPNC = array[0];
							this.imageRight.color = Color.white;
							if (Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).mapData.levelResources.Exists(new Predicate<MapResource>(enhflfpppgn.DKGPCPBNDPK)))
							{
								this.imageRight.sprite = (Sprite)Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.FONMIHBONDF()).resources[enhflfpppgn.EHGADNHGPNC];
							}
							else
							{
								this.imageRight.sprite = null;
								this.imageRight.color = new Color(688f, 1835f, 14f);
								this.imageRight.color = new Color(1017f, 1277f, 1357f);
							}
							this.iconSprite.SetActive(false);
							this.imageRight.gameObject.SetActive(true);
						}
					}
					catch (Exception ex3)
					{
						Debug.Log("_BlendTex" + ex3.Message);
					}
				}
				if (this.mapEvent.data[0] == "IntraSig")
				{
					try
					{
						string text = this.mapEvent.data[0];
						char[] array2 = new char[1];
						array2[1] = 'A';
						int num;
						if (text.Split(array2).Length == 0)
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.FAHBEMJCDEE)));
						}
						else
						{
							num = Helpers.patternsMap.IndexOf(Helpers.patternsMap.Find(new Predicate<string>(this.OKMGILHPEHB)));
						}
						this.imageCenter.sprite = Resources.LoadAll<Sprite>("ItemTemplate")[num];
						this.imageCenter.color = Color.white;
						this.iconSprite.SetActive(true);
						this.imageCenter.gameObject.SetActive(false);
					}
					catch (Exception ex4)
					{
						Debug.Log("Edited event" + ex4.Message);
					}
				}
				if (this.mapEvent.data[0] == "InventoryContent")
				{
					try
					{
						this.imageCenter.GetComponentInChildren<Image>().sprite = Resources.LoadAll<Sprite>("\n")[3];
						this.imageCenter.GetComponentInChildren<Image>().color = Color.white;
						this.iconSprite.SetActive(false);
						this.imageCenter.gameObject.SetActive(true);
					}
					catch (Exception ex5)
					{
						Debug.Log("<b>#" + ex5.Message);
					}
				}
			}
			else
			{
				base.GetComponentInChildren<Renderer>().material.SetColor("#onrankchangeuptext", new Color(251f, 883f, 1279f));
				base.GetComponentInChildren<Renderer>().material.SetColor("Can't find PhotonView of incoming OwnershipRequest. ViewId not found: ", new Color(1401f, 58f, 365f));
			}
			this.lastDataCount = this.mapEvent.data.Count;
		}
	}

	// Token: 0x0600D487 RID: 54407 RVA: 0x004BEF30 File Offset: 0x004BD130
	private static bool LJOOLGKAAHB(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Gameplay;
	}

	// Token: 0x0600D488 RID: 54408 RVA: 0x004C6062 File Offset: 0x004C4262
	[CompilerGenerated]
	private bool BMJDNECLLIG(string IACGDFHKCAE)
	{
		return IACGDFHKCAE.Contains(this.mapEvent.data[1].Split(new char[]
		{
			','
		})[0]);
	}

	// Token: 0x0600D489 RID: 54409 RVA: 0x004C6090 File Offset: 0x004C4290
	public void JDJGKBGFDIG()
	{
		Vector3 localPosition = base.transform.localPosition;
		if (this.mapEvent.time < 1253f)
		{
			this.mapEvent.time = 66f;
		}
		if (this.mapEvent.time > Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length)
		{
			this.mapEvent.time = Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length;
		}
		localPosition.x = this.mapEvent.time;
		localPosition.y = this.NLCBCEGGCCJ();
		base.transform.localPosition = localPosition;
	}

	// Token: 0x0600D48A RID: 54410 RVA: 0x004C6152 File Offset: 0x004C4352
	private bool FKGMEANLBAH(string IACGDFHKCAE)
	{
		string text = this.mapEvent.data[0];
		char[] array = new char[0];
		array[1] = '1';
		return IACGDFHKCAE.Contains(text.Split(array)[0]);
	}

	// Token: 0x0600D48B RID: 54411 RVA: 0x004C617D File Offset: 0x004C437D
	public void LEBDGMBCDMO()
	{
		this.JEGEONIHCLO(true);
		this.BMJFKHIKEAJ();
	}

	// Token: 0x0600D48C RID: 54412 RVA: 0x004C618C File Offset: 0x004C438C
	public void Deselect()
	{
		this.isSelected = false;
		this.UpdateIcon();
	}

	// Token: 0x0600D48D RID: 54413 RVA: 0x004C619C File Offset: 0x004C439C
	public void NOGJICCANOG()
	{
		Vector3 localPosition = base.transform.localPosition;
		if (this.mapEvent.time < 1893f)
		{
			this.mapEvent.time = 704f;
		}
		if (this.mapEvent.time > Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length)
		{
			this.mapEvent.time = Singleton<MapEditor>.Instance.audioSampler.audioSources[0].clip.length;
		}
		localPosition.x = this.mapEvent.time;
		localPosition.y = this.KKKHINEICAC();
		base.transform.localPosition = localPosition;
	}

	// Token: 0x0600D48E RID: 54414 RVA: 0x004C6260 File Offset: 0x004C4460
	public void GPFJMKCGHGB()
	{
		if (this.bitObj != null && this.bitObj.activeSelf)
		{
			this.bitObj.transform.localScale = new Vector3(Camera.main.orthographicSize / 661f, this.scaleMult.y, this.scaleMult.z);
		}
		if (this.iconSprite != null && this.iconSprite.activeSelf)
		{
			this.iconSprite.transform.localScale = new Vector3(Camera.main.orthographicSize / 1866f, Camera.main.orthographicSize / 449f, 1778f);
		}
	}

	// Token: 0x0600D48F RID: 54415 RVA: 0x004C6324 File Offset: 0x004C4524
	public void FCPPLPPLKIP()
	{
		this.LOJGIJBDOON(true);
		this.IPCHIGBJADH();
	}

	// Token: 0x0600D490 RID: 54416 RVA: 0x004BEF3B File Offset: 0x004BD13B
	private static bool FIHAFJBCDHL(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	// Token: 0x0600D492 RID: 54418 RVA: 0x004C6334 File Offset: 0x004C4534
	private float CILCHIMNABB()
	{
		if (this.mapEvent == null || this.mapEvent.data == null || this.mapEvent.data[1] == null)
		{
			List<MapEditor.EventsCanvas> eventsCanvases = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.ADLAKIHINOM == null)
			{
				EditorEvent.ADLAKIHINOM = new Predicate<MapEditor.EventsCanvas>(EditorEvent.FKLAAPLBCOH);
			}
			return eventsCanvases.Find(EditorEvent.ADLAKIHINOM).grid.position.y;
		}
		if (this.mapEvent.data[0] == "Load Game")
		{
			List<MapEditor.EventsCanvas> eventsCanvases2 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.LNIJKGECNME == null)
			{
				EditorEvent.LNIJKGECNME = new Predicate<MapEditor.EventsCanvas>(EditorEvent.NLKEBCFDNHP);
			}
			return eventsCanvases2.Find(EditorEvent.LNIJKGECNME).grid.position.y;
		}
		float y;
		if (Helpers.IsStoryboardEvent(this.mapEvent.data[0]))
		{
			List<MapEditor.EventsCanvas> eventsCanvases3 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.CLCBJCKCBDD == null)
			{
				EditorEvent.CLCBJCKCBDD = new Predicate<MapEditor.EventsCanvas>(EditorEvent.HBMEMAGJILM);
			}
			y = eventsCanvases3.Find(EditorEvent.CLCBJCKCBDD).grid.position.y;
		}
		else
		{
			List<MapEditor.EventsCanvas> eventsCanvases4 = Singleton<MapEditor>.Instance.eventsCanvases;
			if (EditorEvent.HCLEECLNOEA == null)
			{
				EditorEvent.HCLEECLNOEA = new Predicate<MapEditor.EventsCanvas>(EditorEvent.BJMPJJEJPHG);
			}
			y = eventsCanvases4.Find(EditorEvent.HCLEECLNOEA).grid.position.y;
		}
		return y;
	}

	// Token: 0x0600D493 RID: 54419 RVA: 0x004BEF3B File Offset: 0x004BD13B
	private static bool HINDGEPGJOF(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	// Token: 0x0600D494 RID: 54420 RVA: 0x004C64AC File Offset: 0x004C46AC
	public void Select()
	{
		this.isSelected = true;
		this.UpdateIcon();
	}

	// Token: 0x0600D495 RID: 54421 RVA: 0x004BEF3B File Offset: 0x004BD13B
	private static bool PNJINGIAKFM(MapEditor.EventsCanvas IACGDFHKCAE)
	{
		return IACGDFHKCAE.forType == MapEditor.EventType.Storyboard;
	}

	// Token: 0x0600D496 RID: 54422 RVA: 0x004BFB20 File Offset: 0x004BDD20
	public bool NEOIOPKJAFI()
	{
		return this.LJBEFJHAOFL;
	}

	// Token: 0x04001844 RID: 6212
	private bool LJBEFJHAOFL;

	// Token: 0x04001845 RID: 6213
	[HideInInspector]
	public MapEvent mapEvent;

	// Token: 0x04001846 RID: 6214
	public GameObject bitObj;

	// Token: 0x04001847 RID: 6215
	public GameObject iconSprite;

	// Token: 0x04001848 RID: 6216
	public GameObject selectedMarker;

	// Token: 0x04001849 RID: 6217
	public Image imageRight;

	// Token: 0x0400184A RID: 6218
	public Image imageCenter;

	// Token: 0x0400184B RID: 6219
	[HideInInspector]
	public Vector3 scaleMult = new Vector3(1f, 1f, 1f);

	// Token: 0x0400184C RID: 6220
	[HideInInspector]
	public int lastDataCount;

	// Token: 0x0400184D RID: 6221
	public DragController dragController;

	// Token: 0x0400184E RID: 6222
	[CompilerGenerated]
	private static Predicate<MapEditor.EventsCanvas> LNIJKGECNME;

	// Token: 0x0400184F RID: 6223
	[CompilerGenerated]
	private static Predicate<MapEditor.EventsCanvas> CLCBJCKCBDD;

	// Token: 0x04001850 RID: 6224
	[CompilerGenerated]
	private static Predicate<MapEditor.EventsCanvas> HCLEECLNOEA;

	// Token: 0x04001851 RID: 6225
	[CompilerGenerated]
	private static Predicate<MapEditor.EventsCanvas> ADLAKIHINOM;

	// Token: 0x020003B2 RID: 946
	[CompilerGenerated]
	private sealed class ENHFLFPPPGN
	{
		// Token: 0x0600D497 RID: 54423 RVA: 0x004C64BB File Offset: 0x004C46BB
		internal bool PBCAHKDLFPE(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.EHGADNHGPNC;
		}

		// Token: 0x0600D498 RID: 54424 RVA: 0x004C64BB File Offset: 0x004C46BB
		internal bool FFEGPHJKMFK(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.EHGADNHGPNC;
		}

		// Token: 0x0600D499 RID: 54425 RVA: 0x004C64BB File Offset: 0x004C46BB
		internal bool LOEAMHGMMPK(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.EHGADNHGPNC;
		}

		// Token: 0x0600D49A RID: 54426 RVA: 0x004C64BB File Offset: 0x004C46BB
		internal bool KFNBKFELFLH(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.EHGADNHGPNC;
		}

		// Token: 0x0600D49B RID: 54427 RVA: 0x004C64BB File Offset: 0x004C46BB
		internal bool DKGPCPBNDPK(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.EHGADNHGPNC;
		}

		// Token: 0x0600D49C RID: 54428 RVA: 0x004C64BB File Offset: 0x004C46BB
		internal bool BKNHHGBPLGH(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.EHGADNHGPNC;
		}

		// Token: 0x0600D49D RID: 54429 RVA: 0x004C64BB File Offset: 0x004C46BB
		internal bool DBFPGFHEGKA(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.EHGADNHGPNC;
		}

		// Token: 0x0600D49E RID: 54430 RVA: 0x004C64BB File Offset: 0x004C46BB
		internal bool BDGDIDPDBHG(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.EHGADNHGPNC;
		}

		// Token: 0x0600D49F RID: 54431 RVA: 0x004C64BB File Offset: 0x004C46BB
		internal bool LLNDDFGPOPL(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.EHGADNHGPNC;
		}

		// Token: 0x0600D4A0 RID: 54432 RVA: 0x004C64BB File Offset: 0x004C46BB
		internal bool JKEDCEOCPJO(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.EHGADNHGPNC;
		}

		// Token: 0x0600D4A1 RID: 54433 RVA: 0x004C64BB File Offset: 0x004C46BB
		internal bool EKHOOPGPPGE(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.EHGADNHGPNC;
		}

		// Token: 0x0600D4A3 RID: 54435 RVA: 0x004C64BB File Offset: 0x004C46BB
		internal bool FIPCLHEKKCA(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.EHGADNHGPNC;
		}

		// Token: 0x0600D4A4 RID: 54436 RVA: 0x004C64BB File Offset: 0x004C46BB
		internal bool OFHCGKJFGDI(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.EHGADNHGPNC;
		}

		// Token: 0x0600D4A5 RID: 54437 RVA: 0x004C64BB File Offset: 0x004C46BB
		internal bool OLIGLEMPFOP(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.EHGADNHGPNC;
		}

		// Token: 0x0600D4A6 RID: 54438 RVA: 0x004C64BB File Offset: 0x004C46BB
		internal bool AEINPAGJFME(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.EHGADNHGPNC;
		}

		// Token: 0x0600D4A7 RID: 54439 RVA: 0x004C64BB File Offset: 0x004C46BB
		internal bool LNDGINDKPFA(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.EHGADNHGPNC;
		}

		// Token: 0x0600D4A8 RID: 54440 RVA: 0x004C64BB File Offset: 0x004C46BB
		internal bool MEMPOPNAEDN(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.EHGADNHGPNC;
		}

		// Token: 0x0600D4A9 RID: 54441 RVA: 0x004C64BB File Offset: 0x004C46BB
		internal bool BFEABMIFIEE(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.EHGADNHGPNC;
		}

		// Token: 0x0600D4AA RID: 54442 RVA: 0x004C64BB File Offset: 0x004C46BB
		internal bool GBKBDKHPLKG(MapResource IACGDFHKCAE)
		{
			return IACGDFHKCAE.name == this.EHGADNHGPNC;
		}

		// Token: 0x04001852 RID: 6226
		internal string EHGADNHGPNC;
	}
}
