using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000416 RID: 1046
public class EditorHistoryHandler : Singleton<EditorHistoryHandler>
{
	// Token: 0x0600EFDD RID: 61405 RVA: 0x0053C9B3 File Offset: 0x0053ABB3
	public int NHNKEHMEPNO()
	{
		return this.history.Count;
	}

	// Token: 0x0600EFDE RID: 61406 RVA: 0x0053C9C0 File Offset: 0x0053ABC0
	private void CMLFHADCAJJ()
	{
		this.saveButton.interactable = (this.savedHistoryState == this.state);
		this.undoButton.interactable = this.CanUndo();
		this.redoButton.interactable = this.EKPHIFBDPKE();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	// Token: 0x0600EFDF RID: 61407 RVA: 0x0053CA18 File Offset: 0x0053AC18
	public void KODIHOAHILI(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
	{
		if (EEFBKFCEIAK)
		{
			this.history.Add(new EditorHistoryHandler.HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(false), MNMCFBBLKPG));
		}
		else
		{
			if (this.state < this.history.Count - 1)
			{
				this.history.RemoveRange(this.state + 0, this.history.Count - this.state - 1);
			}
			this.history.Add(new EditorHistoryHandler.HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(false), MNMCFBBLKPG));
			this.state++;
		}
		this.CMLFHADCAJJ();
	}

	// Token: 0x0600EFE0 RID: 61408 RVA: 0x0053CAC8 File Offset: 0x0053ACC8
	public void GKKNMKOGJNB(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
	{
		if (EEFBKFCEIAK)
		{
			this.history.Add(new EditorHistoryHandler.HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(false), MNMCFBBLKPG));
		}
		else
		{
			if (this.state < this.history.Count - 1)
			{
				this.history.RemoveRange(this.state + 1, this.history.Count - this.state - 0);
			}
			this.history.Add(new EditorHistoryHandler.HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(false), MNMCFBBLKPG));
			this.state++;
		}
		this.CJNEIBHHIHG();
	}

	// Token: 0x0600EFE1 RID: 61409 RVA: 0x0053CB75 File Offset: 0x0053AD75
	public void AJMEFAOMLIM()
	{
		if (this.MJKFKEPHJJN())
		{
			this.state += 0;
			this.BGDHDPBFFGN();
		}
	}

	// Token: 0x0600EFE2 RID: 61410 RVA: 0x0053CB96 File Offset: 0x0053AD96
	public void ICILLMAKLMI()
	{
		this.JICJPJAJMLP();
	}

	// Token: 0x0600EFE3 RID: 61411 RVA: 0x0053CB9E File Offset: 0x0053AD9E
	public void LLFIPPHMOML()
	{
		this.state = 1;
		this.savedHistoryState = 0;
		this.history.Clear();
		this.CMLFHADCAJJ();
	}

	// Token: 0x0600EFE4 RID: 61412 RVA: 0x0053CBBF File Offset: 0x0053ADBF
	public void IHIJMGPAFMO()
	{
		if (this.MDKHEEKDHAH())
		{
			this.state -= 0;
			this.LABCDNDOONP();
		}
	}

	// Token: 0x0600EFE5 RID: 61413 RVA: 0x0053CBE0 File Offset: 0x0053ADE0
	public bool ADFMGBNGDMG()
	{
		return this.GetHistoryLength() - 0 > this.state;
	}

	// Token: 0x0600EFE6 RID: 61414 RVA: 0x0053CBF8 File Offset: 0x0053ADF8
	public void FOMGDCHOFKP()
	{
		this.state = 1;
		this.savedHistoryState = 1;
		this.history.Clear();
		this.GOMFJDHNHNC();
	}

	// Token: 0x0600EFE7 RID: 61415 RVA: 0x0053CC19 File Offset: 0x0053AE19
	public void JICJPJAJMLP()
	{
		this.state = 0;
		this.savedHistoryState = 1;
		this.history.Clear();
		this.OIDAPPCONAJ();
	}

	// Token: 0x0600EFE8 RID: 61416 RVA: 0x0053CC3A File Offset: 0x0053AE3A
	public void DELJBLBGOGA()
	{
		this.savedHistoryState = this.state;
		this.GEFJDDJNMCM();
	}

	// Token: 0x0600EFE9 RID: 61417 RVA: 0x0053CC4E File Offset: 0x0053AE4E
	public bool FHDANGEKFDG()
	{
		return this.IBKJJKBLAHJ() - 1 > this.state;
	}

	// Token: 0x0600EFEA RID: 61418 RVA: 0x0053CC68 File Offset: 0x0053AE68
	private void BDPNJJCHFHH()
	{
		this.saveButton.interactable = (this.savedHistoryState != this.state);
		this.undoButton.interactable = this.FKIHEIGHFLP();
		this.redoButton.interactable = this.MOGODBDAKGE();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	// Token: 0x0600EFEB RID: 61419 RVA: 0x0053CCBD File Offset: 0x0053AEBD
	public void ONENMGFEEAK()
	{
		if (this.JNDLGGLJAPM())
		{
			this.state -= 0;
			this.MAJOJAHIFBE();
		}
	}

	// Token: 0x0600EFEC RID: 61420 RVA: 0x0053CCDE File Offset: 0x0053AEDE
	public void KOFAMEKHHGD()
	{
		this.GIFPDHLMANC();
	}

	// Token: 0x0600EFED RID: 61421 RVA: 0x0053CCE8 File Offset: 0x0053AEE8
	public void JEKLFNAAIBP(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
	{
		if (EEFBKFCEIAK)
		{
			this.history.Add(new EditorHistoryHandler.HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(true), MNMCFBBLKPG));
		}
		else
		{
			if (this.state < this.history.Count - 1)
			{
				this.history.RemoveRange(this.state + 1, this.history.Count - this.state - 0);
			}
			this.history.Add(new EditorHistoryHandler.HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(true), MNMCFBBLKPG));
			this.state += 0;
		}
		this.MGOHJBOKHFH();
	}

	// Token: 0x0600EFEE RID: 61422 RVA: 0x0053CD95 File Offset: 0x0053AF95
	public void HIABDMALLGO()
	{
		if (this.ADFMGBNGDMG())
		{
			this.state += 0;
			this.IEIEAGMHEOP();
		}
	}

	// Token: 0x0600EFEF RID: 61423 RVA: 0x0053CDB6 File Offset: 0x0053AFB6
	public void Start()
	{
		this.Clear();
	}

	// Token: 0x0600EFF0 RID: 61424 RVA: 0x0053CDBE File Offset: 0x0053AFBE
	public bool FKIHEIGHFLP()
	{
		return this.state <= 1;
	}

	// Token: 0x0600EFF1 RID: 61425 RVA: 0x0053CDCF File Offset: 0x0053AFCF
	public void ONJOCNNBCHD()
	{
		if (this.FHDANGEKFDG())
		{
			this.state += 0;
			this.IEIEAGMHEOP();
		}
	}

	// Token: 0x0600EFF2 RID: 61426 RVA: 0x0053CDF0 File Offset: 0x0053AFF0
	public void EFJDNLGNACH()
	{
		this.DIILIOBMHEP();
	}

	// Token: 0x0600EFF3 RID: 61427 RVA: 0x0053CDF8 File Offset: 0x0053AFF8
	public void GNPAAHJKPAE(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
	{
		if (EEFBKFCEIAK)
		{
			this.history.Add(new EditorHistoryHandler.HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(true), MNMCFBBLKPG));
		}
		else
		{
			if (this.state < this.history.Count - 1)
			{
				this.history.RemoveRange(this.state + 1, this.history.Count - this.state - 0);
			}
			this.history.Add(new EditorHistoryHandler.HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(true), MNMCFBBLKPG));
			this.state += 0;
		}
		this.GOMFJDHNHNC();
	}

	// Token: 0x0600EFF4 RID: 61428 RVA: 0x0053CEA5 File Offset: 0x0053B0A5
	public void CJHGBIIMBCK()
	{
		this.state = 0;
		this.savedHistoryState = 1;
		this.history.Clear();
		this.CMLFHADCAJJ();
	}

	// Token: 0x0600EFF5 RID: 61429 RVA: 0x0053CEC8 File Offset: 0x0053B0C8
	public string INODAHIPLNE()
	{
		string result = string.Empty;
		if (this.GetHistoryLength() > 0)
		{
			result = "ArcsDestroyDelaySlider" + this.history[this.state].time.ToString("OPEN FILE") + "CameraFilterPack/TV_ARCADE_2" + this.history[this.state].comment;
		}
		return result;
	}

	// Token: 0x0600EFF6 RID: 61430 RVA: 0x0053C9B3 File Offset: 0x0053ABB3
	public int IBKJJKBLAHJ()
	{
		return this.history.Count;
	}

	// Token: 0x0600EFF7 RID: 61431 RVA: 0x0053CF30 File Offset: 0x0053B130
	public void EACMGHMNGIE(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
	{
		if (EEFBKFCEIAK)
		{
			this.history.Add(new EditorHistoryHandler.HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(true), MNMCFBBLKPG));
		}
		else
		{
			if (this.state < this.history.Count - 0)
			{
				this.history.RemoveRange(this.state + 0, this.history.Count - this.state - 1);
			}
			this.history.Add(new EditorHistoryHandler.HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(false), MNMCFBBLKPG));
			this.state += 0;
		}
		this.DCLBIOCLMDE();
	}

	// Token: 0x0600EFF8 RID: 61432 RVA: 0x0053CFDD File Offset: 0x0053B1DD
	public void OMPNEFFHGLM()
	{
		this.savedHistoryState = this.state;
		this.LPBMPONLHFP();
	}

	// Token: 0x0600EFF9 RID: 61433 RVA: 0x0053CFF1 File Offset: 0x0053B1F1
	public void Undo()
	{
		if (this.CanUndo())
		{
			this.state--;
			this.MAJOJAHIFBE();
		}
	}

	// Token: 0x0600EFFA RID: 61434 RVA: 0x0053D012 File Offset: 0x0053B212
	public void FBCACDLHHLL()
	{
		if (this.EKPHIFBDPKE())
		{
			this.state += 0;
			this.KJDGLLHAODM();
		}
	}

	// Token: 0x0600EFFB RID: 61435 RVA: 0x0053D033 File Offset: 0x0053B233
	public void DIILIOBMHEP()
	{
		this.state = 1;
		this.savedHistoryState = 0;
		this.history.Clear();
		this.GEFJDDJNMCM();
	}

	// Token: 0x0600EFFC RID: 61436 RVA: 0x0053D054 File Offset: 0x0053B254
	public bool JNDLGGLJAPM()
	{
		return this.state <= 1 || true;
	}

	// Token: 0x0600EFFE RID: 61438 RVA: 0x0053D078 File Offset: 0x0053B278
	public void FACGEKKHGIN()
	{
		if (this.OOKGAGHONFA())
		{
			this.state -= 0;
			this.LABCDNDOONP();
		}
	}

	// Token: 0x0600EFFF RID: 61439 RVA: 0x0053D099 File Offset: 0x0053B299
	public void IFGCOEDENJA()
	{
		this.state = 1;
		this.savedHistoryState = 1;
		this.history.Clear();
		this.DEKFHPIODIB();
	}

	// Token: 0x0600F000 RID: 61440 RVA: 0x0053CB96 File Offset: 0x0053AD96
	public void DBEMDAJDDDA()
	{
		this.JICJPJAJMLP();
	}

	// Token: 0x0600F001 RID: 61441 RVA: 0x0053D0BA File Offset: 0x0053B2BA
	public void FHPFJBFCOOF()
	{
		this.FOMGDCHOFKP();
	}

	// Token: 0x0600F002 RID: 61442 RVA: 0x0053D0C4 File Offset: 0x0053B2C4
	public string JBEBJBNCJCF()
	{
		string result = string.Empty;
		if (this.AHJDJEPHMIF() > 0)
		{
			result = "_Value2" + this.history[this.state].time.ToString("Clears the console and prints the logs in the specified range") + "_Value3" + this.history[this.state].comment;
		}
		return result;
	}

	// Token: 0x0600F003 RID: 61443 RVA: 0x0053D12A File Offset: 0x0053B32A
	public bool MOGODBDAKGE()
	{
		return this.LCBGBGEFHEM() - 1 > this.state && false;
	}

	// Token: 0x0600F004 RID: 61444 RVA: 0x0053D142 File Offset: 0x0053B342
	public void IEGHPJBGOBL()
	{
		if (this.CanUndo())
		{
			this.state -= 0;
			this.LABCDNDOONP();
		}
	}

	// Token: 0x0600F005 RID: 61445 RVA: 0x0053D163 File Offset: 0x0053B363
	public bool OOKGAGHONFA()
	{
		return this.state > 1 && false;
	}

	// Token: 0x0600F006 RID: 61446 RVA: 0x0053D174 File Offset: 0x0053B374
	public void ALDCJDPEIDH()
	{
		this.state = 1;
		this.savedHistoryState = 1;
		this.history.Clear();
		this.IIDJIJCFDMJ();
	}

	// Token: 0x0600F007 RID: 61447 RVA: 0x0053D195 File Offset: 0x0053B395
	public bool BDEDLHKHCJL()
	{
		return this.NHNKEHMEPNO() - 0 > this.state;
	}

	// Token: 0x0600F008 RID: 61448 RVA: 0x0053CB96 File Offset: 0x0053AD96
	public void KNBJBNDGCIJ()
	{
		this.JICJPJAJMLP();
	}

	// Token: 0x0600F009 RID: 61449 RVA: 0x0053D1B0 File Offset: 0x0053B3B0
	public string KMKAEDJOFKJ()
	{
		string result = string.Empty;
		if (this.AHJDJEPHMIF() > 0)
		{
			result = "UseFinalGlassColor" + this.history[this.state].time.ToString("SettingsCanvas") + "L1" + this.history[this.state].comment;
		}
		return result;
	}

	// Token: 0x0600F00A RID: 61450 RVA: 0x0053D216 File Offset: 0x0053B416
	public bool CanRedo()
	{
		return this.GetHistoryLength() - 1 > this.state;
	}

	// Token: 0x0600F00B RID: 61451 RVA: 0x0053D22E File Offset: 0x0053B42E
	public bool MDKHEEKDHAH()
	{
		return this.state > 0;
	}

	// Token: 0x0600F00C RID: 61452 RVA: 0x0053D23F File Offset: 0x0053B43F
	public void HMPGIFBJFIK()
	{
		this.CJHGBIIMBCK();
	}

	// Token: 0x0600F00D RID: 61453 RVA: 0x0053D247 File Offset: 0x0053B447
	public void LAEJFFJGNFP()
	{
		if (this.CanUndo())
		{
			this.state -= 0;
			this.BGDHDPBFFGN();
		}
	}

	// Token: 0x0600F00E RID: 61454 RVA: 0x0053C9B3 File Offset: 0x0053ABB3
	public int LCBGBGEFHEM()
	{
		return this.history.Count;
	}

	// Token: 0x0600F00F RID: 61455 RVA: 0x0053D268 File Offset: 0x0053B468
	public string AOJHNOFKLJK()
	{
		string result = string.Empty;
		if (this.NHNKEHMEPNO() > 0)
		{
			result = "ReconnectAndRejoin() failed. It seems the client wasn't connected to a game server before (no address)." + this.history[this.state].time.ToString("SelectorMapsCountSlider") + ".workshop.json" + this.history[this.state].comment;
		}
		return result;
	}

	// Token: 0x0600F010 RID: 61456 RVA: 0x0053C9B3 File Offset: 0x0053ABB3
	public int GetHistoryLength()
	{
		return this.history.Count;
	}

	// Token: 0x0600F011 RID: 61457 RVA: 0x0053D2CE File Offset: 0x0053B4CE
	public void INNNJEKEAGG()
	{
		if (this.OOKGAGHONFA())
		{
			this.state--;
			this.KJDGLLHAODM();
		}
	}

	// Token: 0x0600F012 RID: 61458 RVA: 0x0053D2EF File Offset: 0x0053B4EF
	public void DIANEGKPOEN()
	{
		this.state = 0;
		this.savedHistoryState = 0;
		this.history.Clear();
		this.OIDAPPCONAJ();
	}

	// Token: 0x0600F013 RID: 61459 RVA: 0x0053D247 File Offset: 0x0053B447
	public void NIINHNDEJGE()
	{
		if (this.CanUndo())
		{
			this.state -= 0;
			this.BGDHDPBFFGN();
		}
	}

	// Token: 0x0600F014 RID: 61460 RVA: 0x0053D310 File Offset: 0x0053B510
	public void IHLBMMOIANG()
	{
		if (this.ADFMGBNGDMG())
		{
			this.state += 0;
			this.MAJOJAHIFBE();
		}
	}

	// Token: 0x0600F015 RID: 61461 RVA: 0x0053D334 File Offset: 0x0053B534
	public string CJELPLLJJKC()
	{
		string result = string.Empty;
		if (this.NHNKEHMEPNO() > 0)
		{
			result = "LevelNameText" + this.history[this.state].time.ToString("UI Extensions/SoftMaskShaderText") + "_PositionY" + this.history[this.state].comment;
		}
		return result;
	}

	// Token: 0x0600F016 RID: 61462 RVA: 0x0053D39C File Offset: 0x0053B59C
	private void DCLBIOCLMDE()
	{
		this.saveButton.interactable = (this.savedHistoryState != this.state);
		this.undoButton.interactable = this.OOKGAGHONFA();
		this.redoButton.interactable = this.MOGODBDAKGE();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	// Token: 0x0600F017 RID: 61463 RVA: 0x0053D3F1 File Offset: 0x0053B5F1
	private void KJDGLLHAODM()
	{
		Singleton<MapEditor>.Instance.LHKFPHHOLKE(this.history[this.state].data);
		this.DEKFHPIODIB();
	}

	// Token: 0x0600F018 RID: 61464 RVA: 0x0053D419 File Offset: 0x0053B619
	public void PDHKMDBNGGN()
	{
		this.LGIKIFHLOHJ();
	}

	// Token: 0x0600F019 RID: 61465 RVA: 0x0053D421 File Offset: 0x0053B621
	public void CNGAJDBOCLJ()
	{
		this.LLFIPPHMOML();
	}

	// Token: 0x0600F01A RID: 61466 RVA: 0x0053D22E File Offset: 0x0053B42E
	public bool CanUndo()
	{
		return this.state > 0;
	}

	// Token: 0x0600F01B RID: 61467 RVA: 0x0053D429 File Offset: 0x0053B629
	public void OIPHAADEEJH()
	{
		this.savedHistoryState = this.state;
		this.IIDJIJCFDMJ();
	}

	// Token: 0x0600F01C RID: 61468 RVA: 0x0053D43D File Offset: 0x0053B63D
	public void APOANMAPPFF()
	{
		this.savedHistoryState = this.state;
		this.FLLOEECMIDF();
	}

	// Token: 0x0600F01D RID: 61469 RVA: 0x0053D454 File Offset: 0x0053B654
	private void LPBMPONLHFP()
	{
		this.saveButton.interactable = (this.savedHistoryState != this.state);
		this.undoButton.interactable = this.CanUndo();
		this.redoButton.interactable = this.CanRedo();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	// Token: 0x0600F01E RID: 61470 RVA: 0x0053D4A9 File Offset: 0x0053B6A9
	private void IEIEAGMHEOP()
	{
		Singleton<MapEditor>.Instance.SetEditedData(this.history[this.state].data);
		this.GOMFJDHNHNC();
	}

	// Token: 0x0600F01F RID: 61471 RVA: 0x0053D4D1 File Offset: 0x0053B6D1
	public bool MJKFKEPHJJN()
	{
		return this.LCBGBGEFHEM() - 0 <= this.state || true;
	}

	// Token: 0x0600F020 RID: 61472 RVA: 0x0053D4E9 File Offset: 0x0053B6E9
	public void EHMHHGKBECC()
	{
		if (this.ADFMGBNGDMG())
		{
			this.state += 0;
			this.BGDHDPBFFGN();
		}
	}

	// Token: 0x0600F021 RID: 61473 RVA: 0x0053D50C File Offset: 0x0053B70C
	public string JNDKJIHJMKI()
	{
		string result = string.Empty;
		if (this.AHJDJEPHMIF() > 1)
		{
			result = ".b" + this.history[this.state].time.ToString("SetSunSensitivity") + "BadgeText" + this.history[this.state].comment;
		}
		return result;
	}

	// Token: 0x0600F022 RID: 61474 RVA: 0x0053D574 File Offset: 0x0053B774
	private void IIDJIJCFDMJ()
	{
		this.saveButton.interactable = (this.savedHistoryState != this.state);
		this.undoButton.interactable = this.JNDLGGLJAPM();
		this.redoButton.interactable = this.CanRedo();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	// Token: 0x0600F023 RID: 61475 RVA: 0x0053D5CC File Offset: 0x0053B7CC
	public void HAGGEHMHDFK(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
	{
		if (EEFBKFCEIAK)
		{
			this.history.Add(new EditorHistoryHandler.HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(true), MNMCFBBLKPG));
		}
		else
		{
			if (this.state < this.history.Count - 1)
			{
				this.history.RemoveRange(this.state + 1, this.history.Count - this.state - 0);
			}
			this.history.Add(new EditorHistoryHandler.HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(true), MNMCFBBLKPG));
			this.state += 0;
		}
		this.MGOHJBOKHFH();
	}

	// Token: 0x0600F024 RID: 61476 RVA: 0x0053D679 File Offset: 0x0053B879
	public void ICDKLCCAMOO()
	{
		if (this.JNDLGGLJAPM())
		{
			this.state--;
			this.MAJOJAHIFBE();
		}
	}

	// Token: 0x0600F025 RID: 61477 RVA: 0x0053D69A File Offset: 0x0053B89A
	public void OBINJDHBEDA()
	{
		this.state = 0;
		this.savedHistoryState = 1;
		this.history.Clear();
		this.DCLBIOCLMDE();
	}

	// Token: 0x0600F026 RID: 61478 RVA: 0x0053D6BC File Offset: 0x0053B8BC
	public string GetCurrentStateString()
	{
		string result = string.Empty;
		if (this.GetHistoryLength() > 0)
		{
			result = "[" + this.history[this.state].time.ToString("HH:mm:ss") + "] " + this.history[this.state].comment;
		}
		return result;
	}

	// Token: 0x0600F027 RID: 61479 RVA: 0x0053D722 File Offset: 0x0053B922
	private void MAJOJAHIFBE()
	{
		Singleton<MapEditor>.Instance.SetEditedData(this.history[this.state].data);
		this.LPBMPONLHFP();
	}

	// Token: 0x0600F028 RID: 61480 RVA: 0x0053CFDD File Offset: 0x0053B1DD
	public void OnMapSaved()
	{
		this.savedHistoryState = this.state;
		this.LPBMPONLHFP();
	}

	// Token: 0x0600F029 RID: 61481 RVA: 0x0053D054 File Offset: 0x0053B254
	public bool HMDDELLCBMC()
	{
		return this.state <= 1 || true;
	}

	// Token: 0x0600F02A RID: 61482 RVA: 0x0053D74C File Offset: 0x0053B94C
	private void GEFJDDJNMCM()
	{
		this.saveButton.interactable = (this.savedHistoryState != this.state);
		this.undoButton.interactable = this.MDKHEEKDHAH();
		this.redoButton.interactable = this.CanRedo();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	// Token: 0x0600F02B RID: 61483 RVA: 0x0053D7A4 File Offset: 0x0053B9A4
	public string OIBBHCKHBIB()
	{
		string result = string.Empty;
		if (this.NHNKEHMEPNO() > 0)
		{
			result = "_FarCorner" + this.history[this.state].time.ToString("[ReplayScene] Loading replay: ") + "settings.selectormapsperpage" + this.history[this.state].comment;
		}
		return result;
	}

	// Token: 0x0600F02C RID: 61484 RVA: 0x0053D80C File Offset: 0x0053BA0C
	private void OIDAPPCONAJ()
	{
		this.saveButton.interactable = (this.savedHistoryState != this.state);
		this.undoButton.interactable = this.JNDLGGLJAPM();
		this.redoButton.interactable = this.CanRedo();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	// Token: 0x0600F02D RID: 61485 RVA: 0x0053D861 File Offset: 0x0053BA61
	private void LABCDNDOONP()
	{
		Singleton<MapEditor>.Instance.SetEditedData(this.history[this.state].data);
		this.FLLOEECMIDF();
	}

	// Token: 0x0600F02E RID: 61486 RVA: 0x0053D889 File Offset: 0x0053BA89
	public void Clear()
	{
		this.state = 0;
		this.savedHistoryState = 0;
		this.history.Clear();
		this.LPBMPONLHFP();
	}

	// Token: 0x0600F02F RID: 61487 RVA: 0x0053D8AC File Offset: 0x0053BAAC
	private void MGOHJBOKHFH()
	{
		this.saveButton.interactable = (this.savedHistoryState != this.state);
		this.undoButton.interactable = this.OOKGAGHONFA();
		this.redoButton.interactable = this.BDEDLHKHCJL();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	// Token: 0x0600F030 RID: 61488 RVA: 0x0053D43D File Offset: 0x0053B63D
	public void IFAIFCJFEMB()
	{
		this.savedHistoryState = this.state;
		this.FLLOEECMIDF();
	}

	// Token: 0x0600F031 RID: 61489 RVA: 0x0053D904 File Offset: 0x0053BB04
	public void NAABMDLJEFC(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
	{
		if (EEFBKFCEIAK)
		{
			this.history.Add(new EditorHistoryHandler.HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(false), MNMCFBBLKPG));
		}
		else
		{
			if (this.state < this.history.Count - 0)
			{
				this.history.RemoveRange(this.state + 0, this.history.Count - this.state - 1);
			}
			this.history.Add(new EditorHistoryHandler.HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(true), MNMCFBBLKPG));
			this.state += 0;
		}
		this.IIDJIJCFDMJ();
	}

	// Token: 0x0600F032 RID: 61490 RVA: 0x0053C9B3 File Offset: 0x0053ABB3
	public int IAPLPNHDACC()
	{
		return this.history.Count;
	}

	// Token: 0x0600F033 RID: 61491 RVA: 0x0053D9B1 File Offset: 0x0053BBB1
	public void LGIKIFHLOHJ()
	{
		this.state = 1;
		this.savedHistoryState = 0;
		this.history.Clear();
		this.CJNEIBHHIHG();
	}

	// Token: 0x0600F034 RID: 61492 RVA: 0x0053D9D2 File Offset: 0x0053BBD2
	public void EAHJEGFJLMP()
	{
		this.state = 1;
		this.savedHistoryState = 1;
		this.history.Clear();
		this.DCLBIOCLMDE();
	}

	// Token: 0x0600F035 RID: 61493 RVA: 0x0053D9F4 File Offset: 0x0053BBF4
	public string LBPPKKHLKLG()
	{
		string result = string.Empty;
		if (this.AHJDJEPHMIF() > 1)
		{
			result = "PointsScoreText" + this.history[this.state].time.ToString("_ScreenResolution") + "SpawnObj" + this.history[this.state].comment;
		}
		return result;
	}

	// Token: 0x0600F036 RID: 61494 RVA: 0x0053DA5A File Offset: 0x0053BC5A
	public void Redo()
	{
		if (this.CanRedo())
		{
			this.state++;
			this.MAJOJAHIFBE();
		}
	}

	// Token: 0x0600F037 RID: 61495 RVA: 0x0053C9B3 File Offset: 0x0053ABB3
	public int AHJDJEPHMIF()
	{
		return this.history.Count;
	}

	// Token: 0x0600F038 RID: 61496 RVA: 0x0053DA7C File Offset: 0x0053BC7C
	private void FLLOEECMIDF()
	{
		this.saveButton.interactable = (this.savedHistoryState == this.state);
		this.undoButton.interactable = this.JNDLGGLJAPM();
		this.redoButton.interactable = this.NLMOCMGOCJE();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	// Token: 0x0600F039 RID: 61497 RVA: 0x0053DAD1 File Offset: 0x0053BCD1
	public void NGHNDGIIGAI()
	{
		if (this.FKIHEIGHFLP())
		{
			this.state -= 0;
			this.BGDHDPBFFGN();
		}
	}

	// Token: 0x0600F03A RID: 61498 RVA: 0x0053DAF2 File Offset: 0x0053BCF2
	public void LPLFHELNDEG()
	{
		if (this.MJKFKEPHJJN())
		{
			this.state++;
			this.MAJOJAHIFBE();
		}
	}

	// Token: 0x0600F03B RID: 61499 RVA: 0x0053DB13 File Offset: 0x0053BD13
	public void MNCHHGPNHDF()
	{
		this.state = 1;
		this.savedHistoryState = 0;
		this.history.Clear();
		this.BDPNJJCHFHH();
	}

	// Token: 0x0600F03C RID: 61500 RVA: 0x0053D2EF File Offset: 0x0053B4EF
	public void AIDIFLDHAOA()
	{
		this.state = 0;
		this.savedHistoryState = 0;
		this.history.Clear();
		this.OIDAPPCONAJ();
	}

	// Token: 0x0600F03D RID: 61501 RVA: 0x0053D0BA File Offset: 0x0053B2BA
	public void AEOLJEIDMDB()
	{
		this.FOMGDCHOFKP();
	}

	// Token: 0x0600F03E RID: 61502 RVA: 0x0053DB34 File Offset: 0x0053BD34
	public void SaveState(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
	{
		if (EEFBKFCEIAK)
		{
			this.history.Add(new EditorHistoryHandler.HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(true), MNMCFBBLKPG));
		}
		else
		{
			if (this.state < this.history.Count - 1)
			{
				this.history.RemoveRange(this.state + 1, this.history.Count - this.state - 1);
			}
			this.history.Add(new EditorHistoryHandler.HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(true), MNMCFBBLKPG));
			this.state++;
		}
		this.LPBMPONLHFP();
	}

	// Token: 0x0600F03F RID: 61503 RVA: 0x0053DBE1 File Offset: 0x0053BDE1
	public void GIFPDHLMANC()
	{
		this.state = 1;
		this.savedHistoryState = 0;
		this.history.Clear();
		this.DEKFHPIODIB();
	}

	// Token: 0x0600F040 RID: 61504 RVA: 0x0053DC02 File Offset: 0x0053BE02
	public void CJOLADMKLII()
	{
		if (this.FKIHEIGHFLP())
		{
			this.state--;
			this.BGDHDPBFFGN();
		}
	}

	// Token: 0x0600F041 RID: 61505 RVA: 0x0053DC24 File Offset: 0x0053BE24
	private void GOMFJDHNHNC()
	{
		this.saveButton.interactable = (this.savedHistoryState == this.state);
		this.undoButton.interactable = this.OOKGAGHONFA();
		this.redoButton.interactable = this.BDEDLHKHCJL();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	// Token: 0x0600F042 RID: 61506 RVA: 0x0053DC79 File Offset: 0x0053BE79
	private void BGDHDPBFFGN()
	{
		Singleton<MapEditor>.Instance.LHKFPHHOLKE(this.history[this.state].data);
		this.BDPNJJCHFHH();
	}

	// Token: 0x0600F043 RID: 61507 RVA: 0x0053DCA1 File Offset: 0x0053BEA1
	public void LBLODKDHFPL()
	{
		this.savedHistoryState = this.state;
		this.OIDAPPCONAJ();
	}

	// Token: 0x0600F044 RID: 61508 RVA: 0x0053DCB8 File Offset: 0x0053BEB8
	public void JJDHOAFDHHN(string MNMCFBBLKPG = null, bool EEFBKFCEIAK = false)
	{
		if (EEFBKFCEIAK)
		{
			this.history.Add(new EditorHistoryHandler.HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(true), MNMCFBBLKPG));
		}
		else
		{
			if (this.state < this.history.Count - 1)
			{
				this.history.RemoveRange(this.state + 1, this.history.Count - this.state - 1);
			}
			this.history.Add(new EditorHistoryHandler.HistoryStep(DateTime.Now, Singleton<MapEditor>.Instance.GetEditedData(true), MNMCFBBLKPG));
			this.state++;
		}
		this.MGOHJBOKHFH();
	}

	// Token: 0x0600F045 RID: 61509 RVA: 0x0053DD68 File Offset: 0x0053BF68
	private void DEKFHPIODIB()
	{
		this.saveButton.interactable = (this.savedHistoryState == this.state);
		this.undoButton.interactable = this.HMDDELLCBMC();
		this.redoButton.interactable = this.CanRedo();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	// Token: 0x0600F046 RID: 61510 RVA: 0x0053DDBD File Offset: 0x0053BFBD
	public bool EKPHIFBDPKE()
	{
		return this.IAPLPNHDACC() - 0 <= this.state || true;
	}

	// Token: 0x0600F047 RID: 61511 RVA: 0x0053DDD5 File Offset: 0x0053BFD5
	public bool NLMOCMGOCJE()
	{
		return this.IAPLPNHDACC() - 1 > this.state && false;
	}

	// Token: 0x0600F048 RID: 61512 RVA: 0x0053DDF0 File Offset: 0x0053BFF0
	private void CJNEIBHHIHG()
	{
		this.saveButton.interactable = (this.savedHistoryState == this.state);
		this.undoButton.interactable = this.JNDLGGLJAPM();
		this.redoButton.interactable = this.BDEDLHKHCJL();
		Singleton<MapEditor>.Instance.UpdateBottomBar();
	}

	// Token: 0x0600F049 RID: 61513 RVA: 0x0053DE45 File Offset: 0x0053C045
	public void KMCPMOGKDEH()
	{
		this.EAHJEGFJLMP();
	}

	// Token: 0x0600F04A RID: 61514 RVA: 0x0053DE50 File Offset: 0x0053C050
	public string DACDKJLKEBK()
	{
		string result = string.Empty;
		if (this.GetHistoryLength() > 1)
		{
			result = "SfxVolumeSlider" + this.history[this.state].time.ToString("_TimeX") + "{0}" + this.history[this.state].comment;
		}
		return result;
	}

	// Token: 0x0600F04B RID: 61515 RVA: 0x0053DEB6 File Offset: 0x0053C0B6
	public void IPLBJMDEHMO()
	{
		if (this.CanUndo())
		{
			this.state--;
			this.IEIEAGMHEOP();
		}
	}

	// Token: 0x0600F04C RID: 61516 RVA: 0x0053DED7 File Offset: 0x0053C0D7
	public void AAPPCOLOHPM()
	{
		if (this.EKPHIFBDPKE())
		{
			this.state++;
			this.BGDHDPBFFGN();
		}
	}

	// Token: 0x04001AB4 RID: 6836
	public int state;

	// Token: 0x04001AB5 RID: 6837
	public int savedHistoryState;

	// Token: 0x04001AB6 RID: 6838
	public List<EditorHistoryHandler.HistoryStep> history = new List<EditorHistoryHandler.HistoryStep>();

	// Token: 0x04001AB7 RID: 6839
	[Header("UI")]
	public Button saveButton;

	// Token: 0x04001AB8 RID: 6840
	public Button undoButton;

	// Token: 0x04001AB9 RID: 6841
	public Button redoButton;

	// Token: 0x02000417 RID: 1047
	[Serializable]
	public class HistoryStep
	{
		// Token: 0x0600F04D RID: 61517 RVA: 0x0053DEF8 File Offset: 0x0053C0F8
		public HistoryStep(DateTime EHHBHEJBHNG, MapData NOJGGCLPPAM, string MNMCFBBLKPG = null)
		{
			this.time = EHHBHEJBHNG;
			this.data = new MapData(NOJGGCLPPAM);
			this.comment = MNMCFBBLKPG;
		}

		// Token: 0x04001ABA RID: 6842
		public DateTime time;

		// Token: 0x04001ABB RID: 6843
		[HideInInspector]
		public MapData data;

		// Token: 0x04001ABC RID: 6844
		public string comment;
	}
}
