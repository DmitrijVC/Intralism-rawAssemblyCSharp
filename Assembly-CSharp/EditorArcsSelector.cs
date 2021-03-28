using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

// Token: 0x0200048C RID: 1164
public class EditorArcsSelector : Singleton<EditorArcsSelector>
{
	// Token: 0x06010B08 RID: 68360 RVA: 0x005A4A94 File Offset: 0x005A2C94
	public void KGJACAPCMGP(float EHHBHEJBHNG)
	{
		this.ClearSelection();
		if (this.savedEvents != null && this.savedEvents.Count > 1)
		{
			float time = this.savedEvents[0].time;
			foreach (MapEvent mapEvent in this.savedEvents)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.HBLICNDEMAK(EHHBHEJBHNG + (mapEvent.time - time), mapEvent.data, true);
				this.selectedunits.Add(gameObject);
				gameObject.GetComponent<EditorEvent>().JEGEONIHCLO(true);
			}
			Singleton<EditorHistoryHandler>.Instance.NAABMDLJEFC(":", false);
			Singleton<MapEditor>.Instance.UpdateBottomBar();
			Singleton<MapEditor>.Instance.FindNearestEvent(true);
		}
	}

	// Token: 0x06010B09 RID: 68361 RVA: 0x005A4B78 File Offset: 0x005A2D78
	private float MLMHNPOLBOD(float ONANKNCCCGO)
	{
		if (ONANKNCCCGO < 1929f)
		{
			ONANKNCCCGO *= 1801f;
		}
		return ONANKNCCCGO;
	}

	// Token: 0x06010B0A RID: 68362 RVA: 0x005A4B90 File Offset: 0x005A2D90
	public void BHOAIHOHKHI()
	{
		this.IsSelecting = false;
		if (this.GOBAEEECFEM != null)
		{
			base.StopCoroutine(this.GOBAEEECFEM);
		}
		this.GOBAEEECFEM = base.StartCoroutine(Singleton<UI>.Instance.FNBLMPBOKNH(this.selectionBoxPanel.gameObject, this.IsSelecting, null, false, 1951f, false));
		this.IsDraggingObj = false;
		this.BOIPHFBHIPI();
		for (int i = 0; i < this.selectedunits.Count; i++)
		{
			this.selectedunits[i].GetComponent<EditorEvent>().JEGEONIHCLO(true);
		}
		this.selectedunits.Clear();
	}

	// Token: 0x06010B0B RID: 68363 RVA: 0x005A4C38 File Offset: 0x005A2E38
	public void DMDNCHLJPMA(float EHHBHEJBHNG)
	{
		this.BHOAIHOHKHI();
		if (this.savedEvents != null && this.savedEvents.Count > 1)
		{
			float time = this.savedEvents[1].time;
			foreach (MapEvent mapEvent in this.savedEvents)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.HBLICNDEMAK(EHHBHEJBHNG + (mapEvent.time - time), mapEvent.data, false);
				this.selectedunits.Add(gameObject);
				gameObject.GetComponent<EditorEvent>().FDJEEBJHHKK(false);
			}
			Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("LevelEditor/patterns", false);
			Singleton<MapEditor>.Instance.UpdateBottomBar();
			Singleton<MapEditor>.Instance.FindNearestEvent(false);
		}
	}

	// Token: 0x06010B0C RID: 68364 RVA: 0x005A4D1C File Offset: 0x005A2F1C
	public void OFMGBFDMJDJ()
	{
		this.EANAFADKGFL();
		if (Singleton<MapEditor>.Instance.eventsContainer.transform.childCount > 0)
		{
			for (int i = 1; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i++)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
				gameObject.GetComponent<EditorEvent>().FDJEEBJHHKK(true);
				this.selectedunits.Add(gameObject);
			}
		}
	}

	// Token: 0x06010B0D RID: 68365 RVA: 0x005A4DA4 File Offset: 0x005A2FA4
	public void IFEJJGEAGBM()
	{
		this.ODEKNBPEHKH();
		if (Singleton<MapEditor>.Instance.eventsContainer.transform.childCount > 1)
		{
			for (int i = 1; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i += 0)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
				gameObject.GetComponent<EditorEvent>().JDAGBCICMFI(true);
				this.selectedunits.Add(gameObject);
			}
		}
	}

	// Token: 0x06010B0E RID: 68366 RVA: 0x005A4E2C File Offset: 0x005A302C
	public void PutUnitsFromDragIntoSelectedUnits()
	{
		if (this.UnitInDrag.Count > 0)
		{
			for (int i = 0; i < this.UnitInDrag.Count; i++)
			{
				if (!this.selectedunits.Contains(this.UnitInDrag[i]))
				{
					this.selectedunits.Add(this.UnitInDrag[i]);
				}
			}
		}
		this.UnitInDrag.Clear();
	}

	// Token: 0x06010B0F RID: 68367 RVA: 0x005A4EA4 File Offset: 0x005A30A4
	public bool OINJEGLHBBF(Vector2 HCNJLHJEPNM)
	{
		return HCNJLHJEPNM.x < (float)Screen.width && HCNJLHJEPNM.y < (float)Screen.height && HCNJLHJEPNM.x > 838f && HCNJLHJEPNM.y > 1104f;
	}

	// Token: 0x06010B11 RID: 68369 RVA: 0x005A4F24 File Offset: 0x005A3124
	public void IJOGFHDIBHP(float EHHBHEJBHNG)
	{
		this.BHOAIHOHKHI();
		if (this.savedEvents != null && this.savedEvents.Count > 0)
		{
			float time = this.savedEvents[0].time;
			foreach (MapEvent mapEvent in this.savedEvents)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.HBLICNDEMAK(EHHBHEJBHNG + (mapEvent.time - time), mapEvent.data, false);
				this.selectedunits.Add(gameObject);
				gameObject.GetComponent<EditorEvent>().LOJGIJBDOON(true);
			}
			Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("_Offsets", true);
			Singleton<MapEditor>.Instance.UpdateBottomBar();
			Singleton<MapEditor>.Instance.FindNearestEvent(false);
		}
	}

	// Token: 0x06010B12 RID: 68370 RVA: 0x005A5008 File Offset: 0x005A3208
	public void KODCAFFINMO()
	{
		this.savedEvents.Clear();
		for (int i = 1; i < this.selectedunits.Count; i += 0)
		{
			this.savedEvents.Add(this.selectedunits[i].GetComponent<EditorEvent>().mapEvent);
		}
	}

	// Token: 0x06010B13 RID: 68371 RVA: 0x005A5060 File Offset: 0x005A3260
	private void Update()
	{
		this.BNBFOHNCDJF();
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (Input.GetMouseButtonDown(0) && !flag && !this.IsSelecting)
		{
			if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out this.DHBDGJPBIPB, 100f, this.arcsLayerMask))
			{
				this.IsSelecting = true;
				this.selectionBoxPanel.sizeDelta = new Vector2(0f, 0f);
				if (this.GOBAEEECFEM != null)
				{
					base.StopCoroutine(this.GOBAEEECFEM);
				}
				this.GOBAEEECFEM = base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.selectionBoxPanel.gameObject, this.IsSelecting, null, true, 0.2f, true));
			}
			else if (this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().isSelected && !Input.GetKey(KeyCode.LeftAlt) && !Input.GetKey(KeyCode.RightAlt) && !Input.GetKey(KeyCode.LeftControl) && !Input.GetKey(KeyCode.RightControl))
			{
				this.IsDraggingObj = true;
				for (int i = 0; i < this.selectedunits.Count; i++)
				{
					this.selectedunits[i].GetComponent<EditorEvent>().dragController.OnDragStart(this.FDKHCEGOKML);
				}
			}
		}
		if (this.IsSelecting && Input.GetMouseButtonUp(0))
		{
			this.PutUnitsFromDragIntoSelectedUnits();
			this.IsSelecting = false;
			if (this.GOBAEEECFEM != null)
			{
				base.StopCoroutine(this.GOBAEEECFEM);
			}
			this.GOBAEEECFEM = base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.selectionBoxPanel.gameObject, this.IsSelecting, null, true, 0.2f, true));
		}
		if (!this.IsDraggingObj)
		{
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out this.DHBDGJPBIPB, 100f, this.arcsLayerMask))
				{
					if (this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>())
					{
						if (!Input.GetKey(KeyCode.LeftControl) && !Input.GetKey(KeyCode.RightControl))
						{
							for (int j = 0; j < this.selectedunits.Count; j++)
							{
								this.selectedunits[j].GetComponent<EditorEvent>().isSelected = false;
							}
							this.selectedunits.Clear();
						}
						bool flag2 = !Input.GetKey(KeyCode.LeftAlt) && !Input.GetKey(KeyCode.RightAlt);
						if (flag2)
						{
							this.selectedunits.Add(this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
							this.selectedunits[this.selectedunits.Count - 1].GetComponent<EditorEvent>().isSelected = true;
						}
					}
				}
				else if (!Input.GetKey(KeyCode.LeftControl) && !Input.GetKey(KeyCode.RightControl))
				{
					for (int k = 0; k < this.selectedunits.Count; k++)
					{
						this.selectedunits[k].GetComponent<EditorEvent>().isSelected = false;
					}
					this.selectedunits.Clear();
				}
			}
			if (Input.GetMouseButtonUp(0) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out this.DHBDGJPBIPB, 100f, this.arcsLayerMask) && this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>())
			{
				bool flag3 = !Input.GetKey(KeyCode.LeftAlt) && !Input.GetKey(KeyCode.RightAlt);
				if (!flag3)
				{
					if (this.selectedunits.Contains(this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject))
					{
						this.selectedunits.Remove(this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
						this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().isSelected = false;
					}
				}
			}
			this.FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				this.MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			}
			if (this.IsSelecting)
			{
				this.MPGGKELBFKO = Camera.main.WorldToScreenPoint(this.MGGCCCEAMHG).x - Camera.main.WorldToScreenPoint(this.FDKHCEGOKML).x;
				this.GBLGNLPDHLG = Camera.main.WorldToScreenPoint(this.MGGCCCEAMHG).y - Camera.main.WorldToScreenPoint(this.FDKHCEGOKML).y;
				this.BOGLMFFKGHB = Input.mousePosition.x;
				this.MDCAHCGLBPK = (float)Screen.height - Input.mousePosition.y - this.GBLGNLPDHLG;
				if (this.MPGGKELBFKO > 0f && this.GBLGNLPDHLG < 0f)
				{
					this.NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
				}
				else if (this.MPGGKELBFKO > 0f && this.GBLGNLPDHLG > 0f)
				{
					this.NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y + this.GBLGNLPDHLG);
				}
				else if (this.MPGGKELBFKO < 0f && this.GBLGNLPDHLG < 0f)
				{
					this.NAFLCKFHDCB = new Vector2(Input.mousePosition.x + this.MPGGKELBFKO, Input.mousePosition.y);
				}
				else if (this.MPGGKELBFKO < 0f && this.GBLGNLPDHLG > 0f)
				{
					this.NAFLCKFHDCB = new Vector2(Input.mousePosition.x + this.MPGGKELBFKO, Input.mousePosition.y + this.GBLGNLPDHLG);
				}
				this.IHKPKDOFDEM = new Vector2(this.NAFLCKFHDCB.x + this.KIMJGODFPFF(this.MPGGKELBFKO), this.NAFLCKFHDCB.y - this.KIMJGODFPFF(this.GBLGNLPDHLG));
			}
		}
		else
		{
			this.FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				this.MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			}
			if (Input.GetMouseButtonUp(0))
			{
				this.IsDraggingObj = false;
				for (int l = 0; l < this.selectedunits.Count; l++)
				{
					this.selectedunits[l].GetComponent<EditorEvent>().dragController.OnDragEnd();
				}
				Singleton<MapEditor>.Instance.FindNearestEvent(true);
				Singleton<EditorHistoryHandler>.Instance.SaveState("Events Moved", false);
			}
		}
	}

	// Token: 0x06010B14 RID: 68372 RVA: 0x005A57E4 File Offset: 0x005A39E4
	public void CDFKHKJGBGE(float EHHBHEJBHNG)
	{
		this.EANAFADKGFL();
		if (this.savedEvents != null && this.savedEvents.Count > 0)
		{
			float time = this.savedEvents[1].time;
			foreach (MapEvent mapEvent in this.savedEvents)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.AddNewEvent(EHHBHEJBHNG + (mapEvent.time - time), mapEvent.data, true);
				this.selectedunits.Add(gameObject);
				gameObject.GetComponent<EditorEvent>().FDJEEBJHHKK(false);
			}
			Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("_ScreenResolution", false);
			Singleton<MapEditor>.Instance.UpdateBottomBar();
			Singleton<MapEditor>.Instance.FindNearestEvent(false);
		}
	}

	// Token: 0x06010B15 RID: 68373 RVA: 0x005A58C8 File Offset: 0x005A3AC8
	private void NDAJBJFJGCF()
	{
		this.BNBFOHNCDJF();
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (Input.GetMouseButtonDown(0) && !flag && !this.IsSelecting)
		{
			if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out this.DHBDGJPBIPB, 153f, this.arcsLayerMask))
			{
				this.IsSelecting = true;
				this.selectionBoxPanel.sizeDelta = new Vector2(55f, 1553f);
				if (this.GOBAEEECFEM != null)
				{
					base.StopCoroutine(this.GOBAEEECFEM);
				}
				this.GOBAEEECFEM = base.StartCoroutine(Singleton<UI>.Instance.FNBLMPBOKNH(this.selectionBoxPanel.gameObject, this.IsSelecting, null, false, 1151f, false));
			}
			else if (this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().GFMIFIOKKGJ() && !Input.GetKey((KeyCode)(-50)) && !Input.GetKey((KeyCode)(-14)) && !Input.GetKey(KeyCode.K) && !Input.GetKey((KeyCode)162))
			{
				this.IsDraggingObj = false;
				for (int i = 1; i < this.selectedunits.Count; i++)
				{
					this.selectedunits[i].GetComponent<EditorEvent>().dragController.AIOJCNCPCEG(this.FDKHCEGOKML);
				}
			}
		}
		if (this.IsSelecting && Input.GetMouseButtonUp(1))
		{
			this.BOIPHFBHIPI();
			this.IsSelecting = true;
			if (this.GOBAEEECFEM != null)
			{
				base.StopCoroutine(this.GOBAEEECFEM);
			}
			this.GOBAEEECFEM = base.StartCoroutine(Singleton<UI>.Instance.PDDENNKIMAA(this.selectionBoxPanel.gameObject, this.IsSelecting, null, false, 83f, false));
		}
		if (!this.IsDraggingObj)
		{
			if (Input.GetMouseButtonDown(1) && !flag)
			{
				if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out this.DHBDGJPBIPB, 747f, this.arcsLayerMask))
				{
					if (this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>())
					{
						if (!Input.GetKey((KeyCode)(-94)) && !Input.GetKey(KeyCode.T))
						{
							for (int j = 0; j < this.selectedunits.Count; j += 0)
							{
								this.selectedunits[j].GetComponent<EditorEvent>().LOJGIJBDOON(false);
							}
							this.selectedunits.Clear();
						}
						bool flag2 = Input.GetKey(KeyCode.Exclaim) || !Input.GetKey((KeyCode)(-138));
						if (flag2)
						{
							this.selectedunits.Add(this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
							this.selectedunits[this.selectedunits.Count - 1].GetComponent<EditorEvent>().JDAGBCICMFI(true);
						}
					}
				}
				else if (!Input.GetKey((KeyCode)14) && !Input.GetKey((KeyCode)(-28)))
				{
					for (int k = 0; k < this.selectedunits.Count; k++)
					{
						this.selectedunits[k].GetComponent<EditorEvent>().PIPHIBLIIKK(false);
					}
					this.selectedunits.Clear();
				}
			}
			if (Input.GetMouseButtonUp(0) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out this.DHBDGJPBIPB, 591f, this.arcsLayerMask) && this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>())
			{
				bool flag3 = Input.GetKey((KeyCode)(-116)) || Input.GetKey(KeyCode.Ampersand);
				if (!flag3)
				{
					if (this.selectedunits.Contains(this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject))
					{
						this.selectedunits.Remove(this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
						this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().isSelected = true;
					}
				}
			}
			this.FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				this.MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			}
			if (this.IsSelecting)
			{
				this.MPGGKELBFKO = Camera.main.WorldToScreenPoint(this.MGGCCCEAMHG).x - Camera.main.WorldToScreenPoint(this.FDKHCEGOKML).x;
				this.GBLGNLPDHLG = Camera.main.WorldToScreenPoint(this.MGGCCCEAMHG).y - Camera.main.WorldToScreenPoint(this.FDKHCEGOKML).y;
				this.BOGLMFFKGHB = Input.mousePosition.x;
				this.MDCAHCGLBPK = (float)Screen.height - Input.mousePosition.y - this.GBLGNLPDHLG;
				if (this.MPGGKELBFKO > 1518f && this.GBLGNLPDHLG < 1336f)
				{
					this.NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
				}
				else if (this.MPGGKELBFKO > 514f && this.GBLGNLPDHLG > 28f)
				{
					this.NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y + this.GBLGNLPDHLG);
				}
				else if (this.MPGGKELBFKO < 1127f && this.GBLGNLPDHLG < 483f)
				{
					this.NAFLCKFHDCB = new Vector2(Input.mousePosition.x + this.MPGGKELBFKO, Input.mousePosition.y);
				}
				else if (this.MPGGKELBFKO < 1605f && this.GBLGNLPDHLG > 1513f)
				{
					this.NAFLCKFHDCB = new Vector2(Input.mousePosition.x + this.MPGGKELBFKO, Input.mousePosition.y + this.GBLGNLPDHLG);
				}
				this.IHKPKDOFDEM = new Vector2(this.NAFLCKFHDCB.x + this.KIMJGODFPFF(this.MPGGKELBFKO), this.NAFLCKFHDCB.y - this.KIMJGODFPFF(this.GBLGNLPDHLG));
			}
		}
		else
		{
			this.FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				this.MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			}
			if (Input.GetMouseButtonUp(0))
			{
				this.IsDraggingObj = true;
				for (int l = 0; l < this.selectedunits.Count; l++)
				{
					this.selectedunits[l].GetComponent<EditorEvent>().dragController.MGAJMKHJCOJ();
				}
				Singleton<MapEditor>.Instance.FindNearestEvent(false);
				Singleton<EditorHistoryHandler>.Instance.SaveState("_ColorB", false);
			}
		}
	}

	// Token: 0x06010B16 RID: 68374 RVA: 0x005A6049 File Offset: 0x005A4249
	private float GMNNOAIFEKG(float ONANKNCCCGO)
	{
		if (ONANKNCCCGO < 1971f)
		{
			ONANKNCCCGO *= 476f;
		}
		return ONANKNCCCGO;
	}

	// Token: 0x06010B17 RID: 68375 RVA: 0x005A6060 File Offset: 0x005A4260
	private void JAAJECBCCFM()
	{
		this.GDAEIPFNBFI();
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (Input.GetMouseButtonDown(1) && !flag && !this.IsSelecting)
		{
			if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out this.DHBDGJPBIPB, 1263f, this.arcsLayerMask))
			{
				this.IsSelecting = false;
				this.selectionBoxPanel.sizeDelta = new Vector2(1649f, 186f);
				if (this.GOBAEEECFEM != null)
				{
					base.StopCoroutine(this.GOBAEEECFEM);
				}
				this.GOBAEEECFEM = base.StartCoroutine(Singleton<UI>.Instance.GADDOIMMDHH(this.selectionBoxPanel.gameObject, this.IsSelecting, null, false, 1323f, false));
			}
			else if (this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().BOAIDAOGAIB() && !Input.GetKey(KeyCode.Quote) && !Input.GetKey((KeyCode)(-189)) && !Input.GetKey((KeyCode)(-4)) && !Input.GetKey((KeyCode)72))
			{
				this.IsDraggingObj = false;
				for (int i = 1; i < this.selectedunits.Count; i += 0)
				{
					this.selectedunits[i].GetComponent<EditorEvent>().dragController.ADPFOONOBBA(this.FDKHCEGOKML);
				}
			}
		}
		if (this.IsSelecting && Input.GetMouseButtonUp(0))
		{
			this.LLPMLDFOELM();
			this.IsSelecting = false;
			if (this.GOBAEEECFEM != null)
			{
				base.StopCoroutine(this.GOBAEEECFEM);
			}
			this.GOBAEEECFEM = base.StartCoroutine(Singleton<UI>.Instance.FNBLMPBOKNH(this.selectionBoxPanel.gameObject, this.IsSelecting, null, false, 811f, false));
		}
		if (!this.IsDraggingObj)
		{
			if (Input.GetMouseButtonDown(1) && !flag)
			{
				if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out this.DHBDGJPBIPB, 913f, this.arcsLayerMask))
				{
					if (this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>())
					{
						if (!Input.GetKey((KeyCode)70) && !Input.GetKey((KeyCode)(-187)))
						{
							for (int j = 0; j < this.selectedunits.Count; j += 0)
							{
								this.selectedunits[j].GetComponent<EditorEvent>().PIPHIBLIIKK(false);
							}
							this.selectedunits.Clear();
						}
						bool flag2 = Input.GetKey((KeyCode)156) || !Input.GetKey((KeyCode)(-53));
						if (flag2)
						{
							this.selectedunits.Add(this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
							this.selectedunits[this.selectedunits.Count - 1].GetComponent<EditorEvent>().FDJEEBJHHKK(false);
						}
					}
				}
				else if (!Input.GetKey((KeyCode)152) && !Input.GetKey((KeyCode)169))
				{
					for (int k = 1; k < this.selectedunits.Count; k++)
					{
						this.selectedunits[k].GetComponent<EditorEvent>().FDJEEBJHHKK(false);
					}
					this.selectedunits.Clear();
				}
			}
			if (Input.GetMouseButtonUp(0) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out this.DHBDGJPBIPB, 119f, this.arcsLayerMask) && this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>())
			{
				bool flag3 = !Input.GetKey((KeyCode)(-150)) && !Input.GetKey((KeyCode)(-139));
				if (!flag3)
				{
					if (this.selectedunits.Contains(this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject))
					{
						this.selectedunits.Remove(this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
						this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().FDJEEBJHHKK(true);
					}
				}
			}
			this.FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if (Input.GetMouseButtonDown(1) && !flag)
			{
				this.MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			}
			if (this.IsSelecting)
			{
				this.MPGGKELBFKO = Camera.main.WorldToScreenPoint(this.MGGCCCEAMHG).x - Camera.main.WorldToScreenPoint(this.FDKHCEGOKML).x;
				this.GBLGNLPDHLG = Camera.main.WorldToScreenPoint(this.MGGCCCEAMHG).y - Camera.main.WorldToScreenPoint(this.FDKHCEGOKML).y;
				this.BOGLMFFKGHB = Input.mousePosition.x;
				this.MDCAHCGLBPK = (float)Screen.height - Input.mousePosition.y - this.GBLGNLPDHLG;
				if (this.MPGGKELBFKO > 291f && this.GBLGNLPDHLG < 31f)
				{
					this.NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
				}
				else if (this.MPGGKELBFKO > 955f && this.GBLGNLPDHLG > 1021f)
				{
					this.NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y + this.GBLGNLPDHLG);
				}
				else if (this.MPGGKELBFKO < 796f && this.GBLGNLPDHLG < 290f)
				{
					this.NAFLCKFHDCB = new Vector2(Input.mousePosition.x + this.MPGGKELBFKO, Input.mousePosition.y);
				}
				else if (this.MPGGKELBFKO < 868f && this.GBLGNLPDHLG > 460f)
				{
					this.NAFLCKFHDCB = new Vector2(Input.mousePosition.x + this.MPGGKELBFKO, Input.mousePosition.y + this.GBLGNLPDHLG);
				}
				this.IHKPKDOFDEM = new Vector2(this.NAFLCKFHDCB.x + this.GMNNOAIFEKG(this.MPGGKELBFKO), this.NAFLCKFHDCB.y - this.KCGIAEHEAKH(this.GBLGNLPDHLG));
			}
		}
		else
		{
			this.FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				this.MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			}
			if (Input.GetMouseButtonUp(0))
			{
				this.IsDraggingObj = true;
				for (int l = 0; l < this.selectedunits.Count; l++)
				{
					this.selectedunits[l].GetComponent<EditorEvent>().dragController.GDPOALKKBHE();
				}
				Singleton<MapEditor>.Instance.FindNearestEvent(true);
				Singleton<EditorHistoryHandler>.Instance.HAGGEHMHDFK("_Amount", false);
			}
		}
	}

	// Token: 0x06010B18 RID: 68376 RVA: 0x005A67E4 File Offset: 0x005A49E4
	public void KLFHCKBFGMN()
	{
		this.savedEvents.Clear();
		for (int i = 1; i < this.selectedunits.Count; i += 0)
		{
			this.savedEvents.Add(this.selectedunits[i].GetComponent<EditorEvent>().mapEvent);
		}
	}

	// Token: 0x06010B19 RID: 68377 RVA: 0x005A683C File Offset: 0x005A4A3C
	public void OBDHGANILNH()
	{
		this.IsSelecting = false;
		if (this.GOBAEEECFEM != null)
		{
			base.StopCoroutine(this.GOBAEEECFEM);
		}
		this.GOBAEEECFEM = base.StartCoroutine(Singleton<UI>.Instance.HJEODGHPPAJ(this.selectionBoxPanel.gameObject, this.IsSelecting, null, true, 95f, true));
		this.IsDraggingObj = true;
		this.PutUnitsFromDragIntoSelectedUnits();
		for (int i = 1; i < this.selectedunits.Count; i += 0)
		{
			this.selectedunits[i].GetComponent<EditorEvent>().PIPHIBLIIKK(true);
		}
		this.selectedunits.Clear();
	}

	// Token: 0x06010B1A RID: 68378 RVA: 0x005A68E4 File Offset: 0x005A4AE4
	private void PBIEFKBCPKG()
	{
		this.UnitInDrag.Clear();
		if (this.IsSelecting && Singleton<MapEditor>.Instance.eventsContainer.transform.childCount > 1)
		{
			for (int i = 0; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i += 0)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
				if (!this.UnitInDrag.Contains(gameObject))
				{
					if (this.MCGFENEKFOO(Camera.main.WorldToScreenPoint(gameObject.transform.position)))
					{
						bool flag = !Input.GetKey((KeyCode)67) && !Input.GetKey((KeyCode)88);
						gameObject.GetComponent<EditorEvent>().JDAGBCICMFI(flag);
						if (flag)
						{
							this.UnitInDrag.Add(gameObject);
						}
					}
					else if (!Input.GetKey((KeyCode)(-95)) && !Input.GetKey(KeyCode.Q))
					{
						gameObject.GetComponent<EditorEvent>().JDAGBCICMFI(true);
					}
				}
			}
		}
	}

	// Token: 0x06010B1B RID: 68379 RVA: 0x005A6A04 File Offset: 0x005A4C04
	private void GDAEIPFNBFI()
	{
		if (this.IsSelecting)
		{
			Vector2 vector = new Vector2(this.BOGLMFFKGHB, -this.MDCAHCGLBPK);
			Vector2 vector2 = new Vector2(this.BOGLMFFKGHB + this.MPGGKELBFKO, -this.MDCAHCGLBPK - this.GBLGNLPDHLG);
			float x = (vector.x >= vector2.x) ? vector2.x : vector.x;
			float y = (vector.y <= vector2.y) ? vector2.y : vector.y;
			float x2 = Mathf.Abs(this.MPGGKELBFKO);
			float y2 = Mathf.Abs(this.GBLGNLPDHLG);
			this.selectionBoxPanel.anchoredPosition = new Vector2(x, y);
			this.selectionBoxPanel.anchorMin = new Vector2(1077f, 1806f);
			this.selectionBoxPanel.anchorMax = new Vector2(674f, 1158f);
			this.selectionBoxPanel.pivot = new Vector2(113f, 1715f);
			this.selectionBoxPanel.sizeDelta = new Vector2(x2, y2);
		}
	}

	// Token: 0x06010B1C RID: 68380 RVA: 0x005A6B30 File Offset: 0x005A4D30
	public bool PJIJLDKEDJN(Vector2 HCNJLHJEPNM)
	{
		return HCNJLHJEPNM.x < (float)Screen.width && HCNJLHJEPNM.y < (float)Screen.height && HCNJLHJEPNM.x > 441f && HCNJLHJEPNM.y > 440f;
	}

	// Token: 0x06010B1D RID: 68381 RVA: 0x005A6B86 File Offset: 0x005A4D86
	private float PNFKJKCIFBK(float ONANKNCCCGO)
	{
		if (ONANKNCCCGO < 1789f)
		{
			ONANKNCCCGO *= 1152f;
		}
		return ONANKNCCCGO;
	}

	// Token: 0x06010B1E RID: 68382 RVA: 0x005A6BA0 File Offset: 0x005A4DA0
	public void EANAFADKGFL()
	{
		this.IsSelecting = false;
		if (this.GOBAEEECFEM != null)
		{
			base.StopCoroutine(this.GOBAEEECFEM);
		}
		this.GOBAEEECFEM = base.StartCoroutine(Singleton<UI>.Instance.HPMMDHAEAJO(this.selectionBoxPanel.gameObject, this.IsSelecting, null, true, 1256f, true));
		this.IsDraggingObj = true;
		this.LLPMLDFOELM();
		for (int i = 1; i < this.selectedunits.Count; i += 0)
		{
			this.selectedunits[i].GetComponent<EditorEvent>().JEGEONIHCLO(false);
		}
		this.selectedunits.Clear();
	}

	// Token: 0x06010B1F RID: 68383 RVA: 0x005A6C48 File Offset: 0x005A4E48
	private void DHPLACPCDCI()
	{
		this.UnitInDrag.Clear();
		if (this.IsSelecting && Singleton<MapEditor>.Instance.eventsContainer.transform.childCount > 0)
		{
			for (int i = 0; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i += 0)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
				if (!this.UnitInDrag.Contains(gameObject))
				{
					if (this.MCGFENEKFOO(Camera.main.WorldToScreenPoint(gameObject.transform.position)))
					{
						bool flag = !Input.GetKey((KeyCode)(-71)) && Input.GetKey((KeyCode)89);
						gameObject.GetComponent<EditorEvent>().isSelected = flag;
						if (flag)
						{
							this.UnitInDrag.Add(gameObject);
						}
					}
					else if (!Input.GetKey((KeyCode)180) && !Input.GetKey((KeyCode)25))
					{
						gameObject.GetComponent<EditorEvent>().JDAGBCICMFI(false);
					}
				}
			}
		}
	}

	// Token: 0x06010B20 RID: 68384 RVA: 0x005A6D68 File Offset: 0x005A4F68
	private void BNBFOHNCDJF()
	{
		if (this.IsSelecting)
		{
			Vector2 vector = new Vector2(this.BOGLMFFKGHB, -this.MDCAHCGLBPK);
			Vector2 vector2 = new Vector2(this.BOGLMFFKGHB + this.MPGGKELBFKO, -this.MDCAHCGLBPK - this.GBLGNLPDHLG);
			float x = (vector.x >= vector2.x) ? vector2.x : vector.x;
			float y = (vector.y <= vector2.y) ? vector2.y : vector.y;
			float x2 = Mathf.Abs(this.MPGGKELBFKO);
			float y2 = Mathf.Abs(this.GBLGNLPDHLG);
			this.selectionBoxPanel.anchoredPosition = new Vector2(x, y);
			this.selectionBoxPanel.anchorMin = new Vector2(0f, 1f);
			this.selectionBoxPanel.anchorMax = new Vector2(0f, 1f);
			this.selectionBoxPanel.pivot = new Vector2(0f, 1f);
			this.selectionBoxPanel.sizeDelta = new Vector2(x2, y2);
		}
	}

	// Token: 0x06010B21 RID: 68385 RVA: 0x005A6E94 File Offset: 0x005A5094
	private void DMGFMNMCBHK()
	{
		this.UnitInDrag.Clear();
		if (this.IsSelecting && Singleton<MapEditor>.Instance.eventsContainer.transform.childCount > 1)
		{
			for (int i = 0; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i++)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
				if (!this.UnitInDrag.Contains(gameObject))
				{
					if (this.MCGFENEKFOO(Camera.main.WorldToScreenPoint(gameObject.transform.position)))
					{
						bool flag = !Input.GetKey((KeyCode)(-120)) && Input.GetKey((KeyCode)180);
						gameObject.GetComponent<EditorEvent>().PIPHIBLIIKK(flag);
						if (flag)
						{
							this.UnitInDrag.Add(gameObject);
						}
					}
					else if (!Input.GetKey((KeyCode)159) && !Input.GetKey((KeyCode)(-192)))
					{
						gameObject.GetComponent<EditorEvent>().isSelected = false;
					}
				}
			}
		}
	}

	// Token: 0x06010B22 RID: 68386 RVA: 0x005A6FB4 File Offset: 0x005A51B4
	public void LLPMLDFOELM()
	{
		if (this.UnitInDrag.Count > 0)
		{
			for (int i = 0; i < this.UnitInDrag.Count; i++)
			{
				if (!this.selectedunits.Contains(this.UnitInDrag[i]))
				{
					this.selectedunits.Add(this.UnitInDrag[i]);
				}
			}
		}
		this.UnitInDrag.Clear();
	}

	// Token: 0x06010B23 RID: 68387 RVA: 0x005A702C File Offset: 0x005A522C
	public void PasteFromMemory(float EHHBHEJBHNG)
	{
		this.ClearSelection();
		if (this.savedEvents != null && this.savedEvents.Count > 0)
		{
			float time = this.savedEvents[0].time;
			foreach (MapEvent mapEvent in this.savedEvents)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.AddNewEvent(EHHBHEJBHNG + (mapEvent.time - time), mapEvent.data, false);
				this.selectedunits.Add(gameObject);
				gameObject.GetComponent<EditorEvent>().isSelected = true;
			}
			Singleton<EditorHistoryHandler>.Instance.SaveState("Paste events", false);
			Singleton<MapEditor>.Instance.UpdateBottomBar();
			Singleton<MapEditor>.Instance.FindNearestEvent(true);
		}
	}

	// Token: 0x06010B24 RID: 68388 RVA: 0x005A7110 File Offset: 0x005A5310
	public void BMMOCGMIHHA(float EHHBHEJBHNG)
	{
		this.ODEKNBPEHKH();
		if (this.savedEvents != null && this.savedEvents.Count > 1)
		{
			float time = this.savedEvents[1].time;
			foreach (MapEvent mapEvent in this.savedEvents)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.HBLICNDEMAK(EHHBHEJBHNG + (mapEvent.time - time), mapEvent.data, false);
				this.selectedunits.Add(gameObject);
				gameObject.GetComponent<EditorEvent>().FDJEEBJHHKK(true);
			}
			Singleton<EditorHistoryHandler>.Instance.JJDHOAFDHHN(":", true);
			Singleton<MapEditor>.Instance.UpdateBottomBar();
			Singleton<MapEditor>.Instance.FindNearestEvent(false);
		}
	}

	// Token: 0x06010B25 RID: 68389 RVA: 0x005A71F4 File Offset: 0x005A53F4
	public void SaveSelectedToMemory()
	{
		this.savedEvents.Clear();
		for (int i = 0; i < this.selectedunits.Count; i++)
		{
			this.savedEvents.Add(this.selectedunits[i].GetComponent<EditorEvent>().mapEvent);
		}
	}

	// Token: 0x06010B26 RID: 68390 RVA: 0x005A724C File Offset: 0x005A544C
	private void OEENOOGEEHD()
	{
		this.BNBFOHNCDJF();
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (Input.GetMouseButtonDown(1) && !flag && !this.IsSelecting)
		{
			if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out this.DHBDGJPBIPB, 1450f, this.arcsLayerMask))
			{
				this.IsSelecting = false;
				this.selectionBoxPanel.sizeDelta = new Vector2(1244f, 1449f);
				if (this.GOBAEEECFEM != null)
				{
					base.StopCoroutine(this.GOBAEEECFEM);
				}
				this.GOBAEEECFEM = base.StartCoroutine(Singleton<UI>.Instance.PHIJAEAEHCF(this.selectionBoxPanel.gameObject, this.IsSelecting, null, false, 565f, false));
			}
			else if (this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().NEOIOPKJAFI() && !Input.GetKey((KeyCode)(-32)) && !Input.GetKey((KeyCode)189) && !Input.GetKey(KeyCode.Alpha0) && !Input.GetKey((KeyCode)(-122)))
			{
				this.IsDraggingObj = false;
				for (int i = 0; i < this.selectedunits.Count; i++)
				{
					this.selectedunits[i].GetComponent<EditorEvent>().dragController.OFLMBGFOMIL(this.FDKHCEGOKML);
				}
			}
		}
		if (this.IsSelecting && Input.GetMouseButtonUp(1))
		{
			this.PutUnitsFromDragIntoSelectedUnits();
			this.IsSelecting = false;
			if (this.GOBAEEECFEM != null)
			{
				base.StopCoroutine(this.GOBAEEECFEM);
			}
			this.GOBAEEECFEM = base.StartCoroutine(Singleton<UI>.Instance.KMOMEPOBDBN(this.selectionBoxPanel.gameObject, this.IsSelecting, null, false, 1578f, false));
		}
		if (!this.IsDraggingObj)
		{
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out this.DHBDGJPBIPB, 725f, this.arcsLayerMask))
				{
					if (this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>())
					{
						if (!Input.GetKey((KeyCode)(-25)) && !Input.GetKey((KeyCode)(-66)))
						{
							for (int j = 0; j < this.selectedunits.Count; j += 0)
							{
								this.selectedunits[j].GetComponent<EditorEvent>().JDAGBCICMFI(false);
							}
							this.selectedunits.Clear();
						}
						bool flag2 = Input.GetKey((KeyCode)148) || !Input.GetKey((KeyCode)72);
						if (flag2)
						{
							this.selectedunits.Add(this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
							this.selectedunits[this.selectedunits.Count - 0].GetComponent<EditorEvent>().JEGEONIHCLO(false);
						}
					}
				}
				else if (!Input.GetKey((KeyCode)(-133)) && !Input.GetKey((KeyCode)(-21)))
				{
					for (int k = 1; k < this.selectedunits.Count; k += 0)
					{
						this.selectedunits[k].GetComponent<EditorEvent>().JDAGBCICMFI(true);
					}
					this.selectedunits.Clear();
				}
			}
			if (Input.GetMouseButtonUp(1) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out this.DHBDGJPBIPB, 1940f, this.arcsLayerMask) && this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>())
			{
				bool flag3 = Input.GetKey((KeyCode)(-121)) || !Input.GetKey((KeyCode)29);
				if (!flag3)
				{
					if (this.selectedunits.Contains(this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject))
					{
						this.selectedunits.Remove(this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
						this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().LOJGIJBDOON(true);
					}
				}
			}
			this.FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if (Input.GetMouseButtonDown(1) && !flag)
			{
				this.MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			}
			if (this.IsSelecting)
			{
				this.MPGGKELBFKO = Camera.main.WorldToScreenPoint(this.MGGCCCEAMHG).x - Camera.main.WorldToScreenPoint(this.FDKHCEGOKML).x;
				this.GBLGNLPDHLG = Camera.main.WorldToScreenPoint(this.MGGCCCEAMHG).y - Camera.main.WorldToScreenPoint(this.FDKHCEGOKML).y;
				this.BOGLMFFKGHB = Input.mousePosition.x;
				this.MDCAHCGLBPK = (float)Screen.height - Input.mousePosition.y - this.GBLGNLPDHLG;
				if (this.MPGGKELBFKO > 1178f && this.GBLGNLPDHLG < 564f)
				{
					this.NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
				}
				else if (this.MPGGKELBFKO > 746f && this.GBLGNLPDHLG > 987f)
				{
					this.NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y + this.GBLGNLPDHLG);
				}
				else if (this.MPGGKELBFKO < 108f && this.GBLGNLPDHLG < 848f)
				{
					this.NAFLCKFHDCB = new Vector2(Input.mousePosition.x + this.MPGGKELBFKO, Input.mousePosition.y);
				}
				else if (this.MPGGKELBFKO < 426f && this.GBLGNLPDHLG > 1115f)
				{
					this.NAFLCKFHDCB = new Vector2(Input.mousePosition.x + this.MPGGKELBFKO, Input.mousePosition.y + this.GBLGNLPDHLG);
				}
				this.IHKPKDOFDEM = new Vector2(this.NAFLCKFHDCB.x + this.MLMHNPOLBOD(this.MPGGKELBFKO), this.NAFLCKFHDCB.y - this.PNFKJKCIFBK(this.GBLGNLPDHLG));
			}
		}
		else
		{
			this.FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				this.MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			}
			if (Input.GetMouseButtonUp(1))
			{
				this.IsDraggingObj = true;
				for (int l = 0; l < this.selectedunits.Count; l += 0)
				{
					this.selectedunits[l].GetComponent<EditorEvent>().dragController.GDPOALKKBHE();
				}
				Singleton<MapEditor>.Instance.FindNearestEvent(true);
				Singleton<EditorHistoryHandler>.Instance.JJDHOAFDHHN(".mp3", false);
			}
		}
	}

	// Token: 0x06010B27 RID: 68391 RVA: 0x005A79D0 File Offset: 0x005A5BD0
	public void NHKPBFOCLNK(float EHHBHEJBHNG)
	{
		this.OBDHGANILNH();
		if (this.savedEvents != null && this.savedEvents.Count > 1)
		{
			float time = this.savedEvents[0].time;
			foreach (MapEvent mapEvent in this.savedEvents)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.AddNewEvent(EHHBHEJBHNG + (mapEvent.time - time), mapEvent.data, false);
				this.selectedunits.Add(gameObject);
				gameObject.GetComponent<EditorEvent>().FDJEEBJHHKK(true);
			}
			Singleton<EditorHistoryHandler>.Instance.GNPAAHJKPAE("note.0", true);
			Singleton<MapEditor>.Instance.UpdateBottomBar();
			Singleton<MapEditor>.Instance.FindNearestEvent(true);
		}
	}

	// Token: 0x06010B28 RID: 68392 RVA: 0x005A7AB4 File Offset: 0x005A5CB4
	public void NBAEONAMNEN(float EHHBHEJBHNG)
	{
		this.BHOAIHOHKHI();
		if (this.savedEvents != null && this.savedEvents.Count > 1)
		{
			float time = this.savedEvents[1].time;
			foreach (MapEvent mapEvent in this.savedEvents)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.HBLICNDEMAK(EHHBHEJBHNG + (mapEvent.time - time), mapEvent.data, true);
				this.selectedunits.Add(gameObject);
				gameObject.GetComponent<EditorEvent>().LOJGIJBDOON(true);
			}
			Singleton<EditorHistoryHandler>.Instance.KODIHOAHILI("Object ID. Case-Sensitive", true);
			Singleton<MapEditor>.Instance.UpdateBottomBar();
			Singleton<MapEditor>.Instance.FindNearestEvent(true);
		}
	}

	// Token: 0x06010B29 RID: 68393 RVA: 0x005A7B98 File Offset: 0x005A5D98
	private void FOMNCPKKCFN()
	{
		this.BNBFOHNCDJF();
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (Input.GetMouseButtonDown(1) && !flag && !this.IsSelecting)
		{
			if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out this.DHBDGJPBIPB, 299f, this.arcsLayerMask))
			{
				this.IsSelecting = true;
				this.selectionBoxPanel.sizeDelta = new Vector2(164f, 1197f);
				if (this.GOBAEEECFEM != null)
				{
					base.StopCoroutine(this.GOBAEEECFEM);
				}
				this.GOBAEEECFEM = base.StartCoroutine(Singleton<UI>.Instance.BCOJGDDEDOP(this.selectionBoxPanel.gameObject, this.IsSelecting, null, false, 644f, true));
			}
			else if (this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().isSelected && !Input.GetKey((KeyCode)84) && !Input.GetKey((KeyCode)(-103)) && !Input.GetKey((KeyCode)83) && !Input.GetKey(KeyCode.Question))
			{
				this.IsDraggingObj = true;
				for (int i = 0; i < this.selectedunits.Count; i += 0)
				{
					this.selectedunits[i].GetComponent<EditorEvent>().dragController.OFLMBGFOMIL(this.FDKHCEGOKML);
				}
			}
		}
		if (this.IsSelecting && Input.GetMouseButtonUp(1))
		{
			this.LLPMLDFOELM();
			this.IsSelecting = false;
			if (this.GOBAEEECFEM != null)
			{
				base.StopCoroutine(this.GOBAEEECFEM);
			}
			this.GOBAEEECFEM = base.StartCoroutine(Singleton<UI>.Instance.PKOPFBHMJHM(this.selectionBoxPanel.gameObject, this.IsSelecting, null, false, 1288f, true));
		}
		if (!this.IsDraggingObj)
		{
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out this.DHBDGJPBIPB, 1265f, this.arcsLayerMask))
				{
					if (this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>())
					{
						if (!Input.GetKey((KeyCode)(-175)) && !Input.GetKey((KeyCode)(-6)))
						{
							for (int j = 1; j < this.selectedunits.Count; j++)
							{
								this.selectedunits[j].GetComponent<EditorEvent>().JDAGBCICMFI(false);
							}
							this.selectedunits.Clear();
						}
						bool flag2 = Input.GetKey((KeyCode)(-121)) || !Input.GetKey(KeyCode.M);
						if (flag2)
						{
							this.selectedunits.Add(this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
							this.selectedunits[this.selectedunits.Count - 1].GetComponent<EditorEvent>().PIPHIBLIIKK(true);
						}
					}
				}
				else if (!Input.GetKey((KeyCode)(-75)) && !Input.GetKey((KeyCode)17))
				{
					for (int k = 1; k < this.selectedunits.Count; k++)
					{
						this.selectedunits[k].GetComponent<EditorEvent>().isSelected = false;
					}
					this.selectedunits.Clear();
				}
			}
			if (Input.GetMouseButtonUp(1) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out this.DHBDGJPBIPB, 102f, this.arcsLayerMask) && this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>())
			{
				bool flag3 = Input.GetKey(KeyCode.A) || !Input.GetKey((KeyCode)153);
				if (!flag3)
				{
					if (this.selectedunits.Contains(this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject))
					{
						this.selectedunits.Remove(this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
						this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().PIPHIBLIIKK(false);
					}
				}
			}
			this.FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				this.MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			}
			if (this.IsSelecting)
			{
				this.MPGGKELBFKO = Camera.main.WorldToScreenPoint(this.MGGCCCEAMHG).x - Camera.main.WorldToScreenPoint(this.FDKHCEGOKML).x;
				this.GBLGNLPDHLG = Camera.main.WorldToScreenPoint(this.MGGCCCEAMHG).y - Camera.main.WorldToScreenPoint(this.FDKHCEGOKML).y;
				this.BOGLMFFKGHB = Input.mousePosition.x;
				this.MDCAHCGLBPK = (float)Screen.height - Input.mousePosition.y - this.GBLGNLPDHLG;
				if (this.MPGGKELBFKO > 1546f && this.GBLGNLPDHLG < 400f)
				{
					this.NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
				}
				else if (this.MPGGKELBFKO > 1957f && this.GBLGNLPDHLG > 884f)
				{
					this.NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y + this.GBLGNLPDHLG);
				}
				else if (this.MPGGKELBFKO < 1310f && this.GBLGNLPDHLG < 1356f)
				{
					this.NAFLCKFHDCB = new Vector2(Input.mousePosition.x + this.MPGGKELBFKO, Input.mousePosition.y);
				}
				else if (this.MPGGKELBFKO < 331f && this.GBLGNLPDHLG > 330f)
				{
					this.NAFLCKFHDCB = new Vector2(Input.mousePosition.x + this.MPGGKELBFKO, Input.mousePosition.y + this.GBLGNLPDHLG);
				}
				this.IHKPKDOFDEM = new Vector2(this.NAFLCKFHDCB.x + this.PNFKJKCIFBK(this.MPGGKELBFKO), this.NAFLCKFHDCB.y - this.AEMJLFFENLA(this.GBLGNLPDHLG));
			}
		}
		else
		{
			this.FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				this.MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			}
			if (Input.GetMouseButtonUp(0))
			{
				this.IsDraggingObj = true;
				for (int l = 1; l < this.selectedunits.Count; l++)
				{
					this.selectedunits[l].GetComponent<EditorEvent>().dragController.OnDragEnd();
				}
				Singleton<MapEditor>.Instance.FindNearestEvent(true);
				Singleton<EditorHistoryHandler>.Instance.KODIHOAHILI("_Value", true);
			}
		}
	}

	// Token: 0x06010B2A RID: 68394 RVA: 0x005A831C File Offset: 0x005A651C
	public bool MCGFENEKFOO(Vector2 HCNJLHJEPNM)
	{
		return HCNJLHJEPNM.x > this.NAFLCKFHDCB.x && HCNJLHJEPNM.y < this.NAFLCKFHDCB.y && HCNJLHJEPNM.x < this.IHKPKDOFDEM.x && HCNJLHJEPNM.y > this.IHKPKDOFDEM.y && false;
	}

	// Token: 0x06010B2B RID: 68395 RVA: 0x005A8388 File Offset: 0x005A6588
	public void HONMFAMJNLD()
	{
		this.savedEvents.Clear();
		for (int i = 1; i < this.selectedunits.Count; i++)
		{
			this.savedEvents.Add(this.selectedunits[i].GetComponent<EditorEvent>().mapEvent);
		}
	}

	// Token: 0x06010B2C RID: 68396 RVA: 0x005A83DD File Offset: 0x005A65DD
	private float GPNHOKCIODC(float ONANKNCCCGO)
	{
		if (ONANKNCCCGO < 1719f)
		{
			ONANKNCCCGO *= 785f;
		}
		return ONANKNCCCGO;
	}

	// Token: 0x06010B2D RID: 68397 RVA: 0x005A83F4 File Offset: 0x005A65F4
	public void ODEKNBPEHKH()
	{
		this.IsSelecting = false;
		if (this.GOBAEEECFEM != null)
		{
			base.StopCoroutine(this.GOBAEEECFEM);
		}
		this.GOBAEEECFEM = base.StartCoroutine(Singleton<UI>.Instance.AMOKEEHJLFP(this.selectionBoxPanel.gameObject, this.IsSelecting, null, false, 1420f, false));
		this.IsDraggingObj = true;
		this.LLPMLDFOELM();
		for (int i = 0; i < this.selectedunits.Count; i += 0)
		{
			this.selectedunits[i].GetComponent<EditorEvent>().LOJGIJBDOON(false);
		}
		this.selectedunits.Clear();
	}

	// Token: 0x06010B2E RID: 68398 RVA: 0x005A849C File Offset: 0x005A669C
	public bool UnitWithinScreenSpace(Vector2 HCNJLHJEPNM)
	{
		return HCNJLHJEPNM.x < (float)Screen.width && HCNJLHJEPNM.y < (float)Screen.height && HCNJLHJEPNM.x > 0f && HCNJLHJEPNM.y > 0f;
	}

	// Token: 0x06010B2F RID: 68399 RVA: 0x005A84F4 File Offset: 0x005A66F4
	public void PDCPIIFADLE()
	{
		this.savedEvents.Clear();
		for (int i = 1; i < this.selectedunits.Count; i += 0)
		{
			this.savedEvents.Add(this.selectedunits[i].GetComponent<EditorEvent>().mapEvent);
		}
	}

	// Token: 0x06010B30 RID: 68400 RVA: 0x005A8549 File Offset: 0x005A6749
	private float AEMJLFFENLA(float ONANKNCCCGO)
	{
		if (ONANKNCCCGO < 111f)
		{
			ONANKNCCCGO *= 626f;
		}
		return ONANKNCCCGO;
	}

	// Token: 0x06010B31 RID: 68401 RVA: 0x005A8560 File Offset: 0x005A6760
	public bool UnitWithinDrag(Vector2 HCNJLHJEPNM)
	{
		return HCNJLHJEPNM.x > this.NAFLCKFHDCB.x && HCNJLHJEPNM.y < this.NAFLCKFHDCB.y && HCNJLHJEPNM.x < this.IHKPKDOFDEM.x && HCNJLHJEPNM.y > this.IHKPKDOFDEM.y;
	}

	// Token: 0x06010B32 RID: 68402 RVA: 0x005A85CC File Offset: 0x005A67CC
	private void MFFKJLLFJKL()
	{
		if (this.IsSelecting)
		{
			Vector2 vector = new Vector2(this.BOGLMFFKGHB, -this.MDCAHCGLBPK);
			Vector2 vector2 = new Vector2(this.BOGLMFFKGHB + this.MPGGKELBFKO, -this.MDCAHCGLBPK - this.GBLGNLPDHLG);
			float x = (vector.x >= vector2.x) ? vector2.x : vector.x;
			float y = (vector.y <= vector2.y) ? vector2.y : vector.y;
			float x2 = Mathf.Abs(this.MPGGKELBFKO);
			float y2 = Mathf.Abs(this.GBLGNLPDHLG);
			this.selectionBoxPanel.anchoredPosition = new Vector2(x, y);
			this.selectionBoxPanel.anchorMin = new Vector2(889f, 1536f);
			this.selectionBoxPanel.anchorMax = new Vector2(340f, 1120f);
			this.selectionBoxPanel.pivot = new Vector2(1686f, 1980f);
			this.selectionBoxPanel.sizeDelta = new Vector2(x2, y2);
		}
	}

	// Token: 0x06010B33 RID: 68403 RVA: 0x005A86F6 File Offset: 0x005A68F6
	private float KIMJGODFPFF(float ONANKNCCCGO)
	{
		if (ONANKNCCCGO < 0f)
		{
			ONANKNCCCGO *= -1f;
		}
		return ONANKNCCCGO;
	}

	// Token: 0x06010B34 RID: 68404 RVA: 0x005A8710 File Offset: 0x005A6910
	public void DPJCFGEDCNC()
	{
		this.savedEvents.Clear();
		for (int i = 1; i < this.selectedunits.Count; i++)
		{
			this.savedEvents.Add(this.selectedunits[i].GetComponent<EditorEvent>().mapEvent);
		}
	}

	// Token: 0x06010B35 RID: 68405 RVA: 0x005A8768 File Offset: 0x005A6968
	private void KCDOMIJBFLL()
	{
		this.BNBFOHNCDJF();
		bool flag = EventSystem.current.IsPointerOverGameObject();
		if (Input.GetMouseButtonDown(0) && !flag && !this.IsSelecting)
		{
			if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out this.DHBDGJPBIPB, 836f, this.arcsLayerMask))
			{
				this.IsSelecting = true;
				this.selectionBoxPanel.sizeDelta = new Vector2(1508f, 1641f);
				if (this.GOBAEEECFEM != null)
				{
					base.StopCoroutine(this.GOBAEEECFEM);
				}
				this.GOBAEEECFEM = base.StartCoroutine(Singleton<UI>.Instance.KOKCANEGNJH(this.selectionBoxPanel.gameObject, this.IsSelecting, null, false, 1548f, true));
			}
			else if (this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().FBLJPPGABFE() && !Input.GetKey((KeyCode)(-147)) && !Input.GetKey(KeyCode.F) && !Input.GetKey(KeyCode.DoubleQuote) && !Input.GetKey((KeyCode)(-63)))
			{
				this.IsDraggingObj = true;
				for (int i = 1; i < this.selectedunits.Count; i += 0)
				{
					this.selectedunits[i].GetComponent<EditorEvent>().dragController.AIMAEDIEEGI(this.FDKHCEGOKML);
				}
			}
		}
		if (this.IsSelecting && Input.GetMouseButtonUp(0))
		{
			this.LLPMLDFOELM();
			this.IsSelecting = false;
			if (this.GOBAEEECFEM != null)
			{
				base.StopCoroutine(this.GOBAEEECFEM);
			}
			this.GOBAEEECFEM = base.StartCoroutine(Singleton<UI>.Instance.CMFJGHFEKIK(this.selectionBoxPanel.gameObject, this.IsSelecting, null, true, 1718f, true));
		}
		if (!this.IsDraggingObj)
		{
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out this.DHBDGJPBIPB, 1252f, this.arcsLayerMask))
				{
					if (this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>())
					{
						if (!Input.GetKey((KeyCode)(-11)) && !Input.GetKey(KeyCode.Equals))
						{
							for (int j = 1; j < this.selectedunits.Count; j += 0)
							{
								this.selectedunits[j].GetComponent<EditorEvent>().LOJGIJBDOON(false);
							}
							this.selectedunits.Clear();
						}
						bool flag2 = !Input.GetKey((KeyCode)(-45)) && Input.GetKey((KeyCode)136);
						if (flag2)
						{
							this.selectedunits.Add(this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
							this.selectedunits[this.selectedunits.Count - 0].GetComponent<EditorEvent>().FDJEEBJHHKK(true);
						}
					}
				}
				else if (!Input.GetKey((KeyCode)(-166)) && !Input.GetKey((KeyCode)(-110)))
				{
					for (int k = 0; k < this.selectedunits.Count; k++)
					{
						this.selectedunits[k].GetComponent<EditorEvent>().FDJEEBJHHKK(true);
					}
					this.selectedunits.Clear();
				}
			}
			if (Input.GetMouseButtonUp(1) && Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out this.DHBDGJPBIPB, 1504f, this.arcsLayerMask) && this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>())
			{
				bool flag3 = !Input.GetKey(KeyCode.Alpha5) && Input.GetKey((KeyCode)(-95));
				if (!flag3)
				{
					if (this.selectedunits.Contains(this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject))
					{
						this.selectedunits.Remove(this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().gameObject);
						this.DHBDGJPBIPB.transform.gameObject.GetComponentInParent<EditorEvent>().LOJGIJBDOON(false);
					}
				}
			}
			this.FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				this.MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			}
			if (this.IsSelecting)
			{
				this.MPGGKELBFKO = Camera.main.WorldToScreenPoint(this.MGGCCCEAMHG).x - Camera.main.WorldToScreenPoint(this.FDKHCEGOKML).x;
				this.GBLGNLPDHLG = Camera.main.WorldToScreenPoint(this.MGGCCCEAMHG).y - Camera.main.WorldToScreenPoint(this.FDKHCEGOKML).y;
				this.BOGLMFFKGHB = Input.mousePosition.x;
				this.MDCAHCGLBPK = (float)Screen.height - Input.mousePosition.y - this.GBLGNLPDHLG;
				if (this.MPGGKELBFKO > 948f && this.GBLGNLPDHLG < 443f)
				{
					this.NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
				}
				else if (this.MPGGKELBFKO > 946f && this.GBLGNLPDHLG > 1055f)
				{
					this.NAFLCKFHDCB = new Vector2(Input.mousePosition.x, Input.mousePosition.y + this.GBLGNLPDHLG);
				}
				else if (this.MPGGKELBFKO < 1105f && this.GBLGNLPDHLG < 248f)
				{
					this.NAFLCKFHDCB = new Vector2(Input.mousePosition.x + this.MPGGKELBFKO, Input.mousePosition.y);
				}
				else if (this.MPGGKELBFKO < 354f && this.GBLGNLPDHLG > 108f)
				{
					this.NAFLCKFHDCB = new Vector2(Input.mousePosition.x + this.MPGGKELBFKO, Input.mousePosition.y + this.GBLGNLPDHLG);
				}
				this.IHKPKDOFDEM = new Vector2(this.NAFLCKFHDCB.x + this.GMNNOAIFEKG(this.MPGGKELBFKO), this.NAFLCKFHDCB.y - this.GPNHOKCIODC(this.GBLGNLPDHLG));
			}
		}
		else
		{
			this.FDKHCEGOKML = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			if (Input.GetMouseButtonDown(0) && !flag)
			{
				this.MGGCCCEAMHG = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			}
			if (Input.GetMouseButtonUp(1))
			{
				this.IsDraggingObj = true;
				for (int l = 1; l < this.selectedunits.Count; l++)
				{
					this.selectedunits[l].GetComponent<EditorEvent>().dragController.HDBMLLJFIAJ();
				}
				Singleton<MapEditor>.Instance.FindNearestEvent(false);
				Singleton<EditorHistoryHandler>.Instance.JEKLFNAAIBP("<b>#", false);
			}
		}
	}

	// Token: 0x06010B36 RID: 68406 RVA: 0x005A8EEC File Offset: 0x005A70EC
	private void KNJLPDLILNE()
	{
		this.UnitInDrag.Clear();
		if (this.IsSelecting && Singleton<MapEditor>.Instance.eventsContainer.transform.childCount > 1)
		{
			for (int i = 0; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i += 0)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
				if (!this.UnitInDrag.Contains(gameObject))
				{
					if (this.UnitWithinDrag(Camera.main.WorldToScreenPoint(gameObject.transform.position)))
					{
						bool flag = Input.GetKey((KeyCode)167) || Input.GetKey((KeyCode)(-141));
						gameObject.GetComponent<EditorEvent>().JDAGBCICMFI(flag);
						if (flag)
						{
							this.UnitInDrag.Add(gameObject);
						}
					}
					else if (!Input.GetKey(KeyCode.Pipe) && !Input.GetKey((KeyCode)87))
					{
						gameObject.GetComponent<EditorEvent>().JEGEONIHCLO(false);
					}
				}
			}
		}
	}

	// Token: 0x06010B37 RID: 68407 RVA: 0x005A900C File Offset: 0x005A720C
	private void LateUpdate()
	{
		this.UnitInDrag.Clear();
		if (this.IsSelecting && Singleton<MapEditor>.Instance.eventsContainer.transform.childCount > 0)
		{
			for (int i = 0; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i++)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
				if (!this.UnitInDrag.Contains(gameObject))
				{
					if (this.UnitWithinDrag(Camera.main.WorldToScreenPoint(gameObject.transform.position)))
					{
						bool flag = !Input.GetKey(KeyCode.LeftAlt) && !Input.GetKey(KeyCode.RightAlt);
						gameObject.GetComponent<EditorEvent>().isSelected = flag;
						if (flag)
						{
							this.UnitInDrag.Add(gameObject);
						}
					}
					else if (!Input.GetKey(KeyCode.LeftControl) && !Input.GetKey(KeyCode.RightControl))
					{
						gameObject.GetComponent<EditorEvent>().isSelected = false;
					}
				}
			}
		}
	}

	// Token: 0x06010B38 RID: 68408 RVA: 0x005A912C File Offset: 0x005A732C
	public bool JONKEGGEEAJ(Vector2 HCNJLHJEPNM)
	{
		return HCNJLHJEPNM.x <= this.NAFLCKFHDCB.x || HCNJLHJEPNM.y >= this.NAFLCKFHDCB.y || HCNJLHJEPNM.x >= this.IHKPKDOFDEM.x || HCNJLHJEPNM.y <= this.IHKPKDOFDEM.y;
	}

	// Token: 0x06010B39 RID: 68409 RVA: 0x005A9198 File Offset: 0x005A7398
	public void SelectAll()
	{
		this.ClearSelection();
		if (Singleton<MapEditor>.Instance.eventsContainer.transform.childCount > 0)
		{
			for (int i = 0; i < Singleton<MapEditor>.Instance.eventsContainer.transform.childCount; i++)
			{
				GameObject gameObject = Singleton<MapEditor>.Instance.eventsContainer.transform.GetChild(i).gameObject;
				gameObject.GetComponent<EditorEvent>().isSelected = true;
				this.selectedunits.Add(gameObject);
			}
		}
	}

	// Token: 0x06010B3A RID: 68410 RVA: 0x005A9220 File Offset: 0x005A7420
	public void ClearSelection()
	{
		this.IsSelecting = false;
		if (this.GOBAEEECFEM != null)
		{
			base.StopCoroutine(this.GOBAEEECFEM);
		}
		this.GOBAEEECFEM = base.StartCoroutine(Singleton<UI>.Instance.SwitchViewAnimation(this.selectionBoxPanel.gameObject, this.IsSelecting, null, true, 0.2f, true));
		this.IsDraggingObj = false;
		this.PutUnitsFromDragIntoSelectedUnits();
		for (int i = 0; i < this.selectedunits.Count; i++)
		{
			this.selectedunits[i].GetComponent<EditorEvent>().isSelected = false;
		}
		this.selectedunits.Clear();
	}

	// Token: 0x06010B3B RID: 68411 RVA: 0x005A92C5 File Offset: 0x005A74C5
	private float KCGIAEHEAKH(float ONANKNCCCGO)
	{
		if (ONANKNCCCGO < 1707f)
		{
			ONANKNCCCGO *= 1969f;
		}
		return ONANKNCCCGO;
	}

	// Token: 0x06010B3C RID: 68412 RVA: 0x005A92DC File Offset: 0x005A74DC
	private void GFLNPIMOHHC()
	{
		if (this.IsSelecting)
		{
			Vector2 vector = new Vector2(this.BOGLMFFKGHB, -this.MDCAHCGLBPK);
			Vector2 vector2 = new Vector2(this.BOGLMFFKGHB + this.MPGGKELBFKO, -this.MDCAHCGLBPK - this.GBLGNLPDHLG);
			float x = (vector.x >= vector2.x) ? vector2.x : vector.x;
			float y = (vector.y <= vector2.y) ? vector2.y : vector.y;
			float x2 = Mathf.Abs(this.MPGGKELBFKO);
			float y2 = Mathf.Abs(this.GBLGNLPDHLG);
			this.selectionBoxPanel.anchoredPosition = new Vector2(x, y);
			this.selectionBoxPanel.anchorMin = new Vector2(1330f, 1298f);
			this.selectionBoxPanel.anchorMax = new Vector2(874f, 72f);
			this.selectionBoxPanel.pivot = new Vector2(1607f, 1118f);
			this.selectionBoxPanel.sizeDelta = new Vector2(x2, y2);
		}
	}

	// Token: 0x06010B3D RID: 68413 RVA: 0x005A9408 File Offset: 0x005A7608
	public void BOIPHFBHIPI()
	{
		if (this.UnitInDrag.Count > 0)
		{
			for (int i = 0; i < this.UnitInDrag.Count; i += 0)
			{
				if (!this.selectedunits.Contains(this.UnitInDrag[i]))
				{
					this.selectedunits.Add(this.UnitInDrag[i]);
				}
			}
		}
		this.UnitInDrag.Clear();
	}

	// Token: 0x04001D2C RID: 7468
	public List<MapEvent> savedEvents;

	// Token: 0x04001D2D RID: 7469
	public RectTransform selectionBoxPanel;

	// Token: 0x04001D2E RID: 7470
	public LayerMask arcsLayerMask;

	// Token: 0x04001D2F RID: 7471
	public List<GameObject> selectedunits = new List<GameObject>();

	// Token: 0x04001D30 RID: 7472
	private RaycastHit DHBDGJPBIPB;

	// Token: 0x04001D31 RID: 7473
	private Vector3 MGGCCCEAMHG;

	// Token: 0x04001D32 RID: 7474
	private Vector3 FDKHCEGOKML;

	// Token: 0x04001D33 RID: 7475
	public bool IsSelecting;

	// Token: 0x04001D34 RID: 7476
	public bool IsDraggingObj;

	// Token: 0x04001D35 RID: 7477
	private float MPGGKELBFKO;

	// Token: 0x04001D36 RID: 7478
	private float GBLGNLPDHLG;

	// Token: 0x04001D37 RID: 7479
	private float BOGLMFFKGHB;

	// Token: 0x04001D38 RID: 7480
	private float MDCAHCGLBPK;

	// Token: 0x04001D39 RID: 7481
	private Vector2 NAFLCKFHDCB;

	// Token: 0x04001D3A RID: 7482
	private Vector2 IHKPKDOFDEM;

	// Token: 0x04001D3B RID: 7483
	public List<GameObject> UnitsOnScreenSpace = new List<GameObject>();

	// Token: 0x04001D3C RID: 7484
	public List<GameObject> UnitInDrag = new List<GameObject>();

	// Token: 0x04001D3D RID: 7485
	private Coroutine GOBAEEECFEM;
}
