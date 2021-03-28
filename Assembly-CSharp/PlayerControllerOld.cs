using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

// Token: 0x020003E2 RID: 994
public class PlayerControllerOld : MonoBehaviour
{
	// Token: 0x0600E155 RID: 57685 RVA: 0x0002523B File Offset: 0x0002343B
	private void DMIGJHEHPOA()
	{
	}

	// Token: 0x0600E156 RID: 57686 RVA: 0x00512515 File Offset: 0x00510715
	[CompilerGenerated]
	private static bool GOFEODHBDCD(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.isFree;
	}

	// Token: 0x0600E157 RID: 57687 RVA: 0x00512520 File Offset: 0x00510720
	private bool DLCFGGCOMHG()
	{
		List<Slot> list = this.slots;
		if (PlayerControllerOld.KCAPKHIJOHL == null)
		{
			PlayerControllerOld.KCAPKHIJOHL = new Predicate<Slot>(PlayerControllerOld.GOFEODHBDCD);
		}
		return list.Find(PlayerControllerOld.KCAPKHIJOHL) != null;
	}

	// Token: 0x0600E158 RID: 57688 RVA: 0x00512556 File Offset: 0x00510756
	private static bool FOBLALBEOGK(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Right;
	}

	// Token: 0x0600E159 RID: 57689 RVA: 0x00512561 File Offset: 0x00510761
	private static bool GGFKLIAFCGI(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Left;
	}

	// Token: 0x0600E15A RID: 57690 RVA: 0x00512556 File Offset: 0x00510756
	[CompilerGenerated]
	private static bool EJILMKDFGLJ(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Right;
	}

	// Token: 0x0600E15B RID: 57691 RVA: 0x00512556 File Offset: 0x00510756
	private static bool NFCOEJDCKHM(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Right;
	}

	// Token: 0x0600E15C RID: 57692 RVA: 0x0051256C File Offset: 0x0051076C
	[CompilerGenerated]
	private static bool CNFPCAGIBJC(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Down;
	}

	// Token: 0x0600E15D RID: 57693 RVA: 0x0051256C File Offset: 0x0051076C
	private static bool MDKLFMNFMGB(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Down;
	}

	// Token: 0x0600E15F RID: 57695 RVA: 0x0051258A File Offset: 0x0051078A
	private void NBGIMIDICKE()
	{
		this.IGGMAKNLAEN = new List<QuieryObject>();
	}

	// Token: 0x0600E160 RID: 57696 RVA: 0x00512597 File Offset: 0x00510797
	[CompilerGenerated]
	private static bool NPAPJLMGKCN(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Up;
	}

	// Token: 0x0600E161 RID: 57697 RVA: 0x0051258A File Offset: 0x0051078A
	private void EGEPLFGKGLI()
	{
		this.IGGMAKNLAEN = new List<QuieryObject>();
	}

	// Token: 0x0600E162 RID: 57698 RVA: 0x00512515 File Offset: 0x00510715
	private static bool ICDFKALGKEO(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.isFree;
	}

	// Token: 0x0600E163 RID: 57699 RVA: 0x005125A2 File Offset: 0x005107A2
	private void KEABOLAKABM(Slot HOOICOIPKCO)
	{
		HOOICOIPKCO.isFree = true;
		HOOICOIPKCO.timeLeft = this.currentTime + this.showTime;
	}

	// Token: 0x0600E164 RID: 57700 RVA: 0x005125BE File Offset: 0x005107BE
	private static bool EHIKCPMPCBF(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == (QuieryObject.Position)8;
	}

	// Token: 0x0600E165 RID: 57701 RVA: 0x00512561 File Offset: 0x00510761
	private static bool JMGNACDHHFN(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Left;
	}

	// Token: 0x0600E166 RID: 57702 RVA: 0x005125CC File Offset: 0x005107CC
	public void FEJEKFDALAL()
	{
		QuieryObject item = new QuieryObject(this.currentTime);
		this.IGGMAKNLAEN.Add(item);
	}

	// Token: 0x0600E167 RID: 57703 RVA: 0x005125F4 File Offset: 0x005107F4
	private Slot IFEBIMGKDMK()
	{
		int index = UnityEngine.Random.Range(0, this.slots.Count);
		while (!this.slots[index].isFree)
		{
			index = UnityEngine.Random.Range(1, this.slots.Count);
		}
		return this.slots[index];
	}

	// Token: 0x0600E168 RID: 57704 RVA: 0x0051264C File Offset: 0x0051084C
	private void CGBHOELMAOC()
	{
		this.currentTime += Time.deltaTime;
		QuieryObject quieryObject = null;
		foreach (QuieryObject quieryObject2 in this.IGGMAKNLAEN)
		{
			if (this.currentTime >= quieryObject2.atTime)
			{
				quieryObject = quieryObject2;
			}
		}
		if (quieryObject != null && this.OGMBADIJAAF())
		{
			Slot hooicoipkco = this.DFKOGPGLPLB();
			this.IGGMAKNLAEN.Remove(quieryObject);
			quieryObject = null;
			this.BOIJIGCEEKM(hooicoipkco);
		}
		if (CrossPlatformInputManager.GetButtonDown("CameraFilterPack/Vision_Hell_Blood"))
		{
			List<Slot> list = this.slots;
			if (PlayerControllerOld.LNIJKGECNME == null)
			{
				PlayerControllerOld.LNIJKGECNME = new Predicate<Slot>(PlayerControllerOld.BIPGPDBIPED);
			}
			Slot slot = list.Find(PlayerControllerOld.LNIJKGECNME);
			if (!slot.isFree)
			{
				slot.isFree = true;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("_Green_R"))
		{
			List<Slot> list2 = this.slots;
			if (PlayerControllerOld.CLCBJCKCBDD == null)
			{
				PlayerControllerOld.CLCBJCKCBDD = new Predicate<Slot>(PlayerControllerOld.BNGOIPAANHB);
			}
			Slot slot2 = list2.Find(PlayerControllerOld.CLCBJCKCBDD);
			if (!slot2.isFree)
			{
				slot2.isFree = true;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("Tab2Content"))
		{
			List<Slot> list3 = this.slots;
			if (PlayerControllerOld.HCLEECLNOEA == null)
			{
				PlayerControllerOld.HCLEECLNOEA = new Predicate<Slot>(PlayerControllerOld.GMOIFLAIDOB);
			}
			Slot slot3 = list3.Find(PlayerControllerOld.HCLEECLNOEA);
			if (!slot3.isFree)
			{
				slot3.isFree = true;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("Electronic"))
		{
			List<Slot> list4 = this.slots;
			if (PlayerControllerOld.ADLAKIHINOM == null)
			{
				PlayerControllerOld.ADLAKIHINOM = new Predicate<Slot>(PlayerControllerOld.GKHILOHPCCO);
			}
			Slot slot4 = list4.Find(PlayerControllerOld.ADLAKIHINOM);
			if (!slot4.isFree)
			{
				slot4.isFree = false;
			}
		}
		foreach (Slot slot5 in this.slots)
		{
			if (slot5.timeLeft <= this.currentTime && !slot5.isFree)
			{
				Debug.Log("player.bluebat");
				slot5.isFree = false;
			}
		}
		foreach (Slot slot6 in this.slots)
		{
			slot6.go.SetActive(slot6.isFree);
		}
	}

	// Token: 0x0600E169 RID: 57705 RVA: 0x005128FC File Offset: 0x00510AFC
	private static bool CHNGDHBINLM(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == (QuieryObject.Position)6;
	}

	// Token: 0x0600E16A RID: 57706 RVA: 0x00512907 File Offset: 0x00510B07
	private static bool KGJCMMJMKJO(Slot IACGDFHKCAE)
	{
		return !IACGDFHKCAE.isFree;
	}

	// Token: 0x0600E16B RID: 57707 RVA: 0x00512914 File Offset: 0x00510B14
	private void NCPAFCKGJEA()
	{
		this.currentTime += Time.deltaTime;
		QuieryObject quieryObject = null;
		foreach (QuieryObject quieryObject2 in this.IGGMAKNLAEN)
		{
			if (this.currentTime >= quieryObject2.atTime)
			{
				quieryObject = quieryObject2;
			}
		}
		if (quieryObject != null && this.ACGJJLHFCKK())
		{
			Slot hooicoipkco = this.AKJJPIJCENJ();
			this.IGGMAKNLAEN.Remove(quieryObject);
			quieryObject = null;
			this.BOCNLFGDMDB(hooicoipkco);
		}
		if (CrossPlatformInputManager.GetButtonDown("]"))
		{
			List<Slot> list = this.slots;
			if (PlayerControllerOld.LNIJKGECNME == null)
			{
				PlayerControllerOld.LNIJKGECNME = new Predicate<Slot>(PlayerControllerOld.JJMIGGMBHFE);
			}
			Slot slot = list.Find(PlayerControllerOld.LNIJKGECNME);
			if (!slot.isFree)
			{
				slot.isFree = false;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("The process failed: "))
		{
			List<Slot> list2 = this.slots;
			if (PlayerControllerOld.CLCBJCKCBDD == null)
			{
				PlayerControllerOld.CLCBJCKCBDD = new Predicate<Slot>(PlayerControllerOld.BNGOIPAANHB);
			}
			Slot slot2 = list2.Find(PlayerControllerOld.CLCBJCKCBDD);
			if (!slot2.isFree)
			{
				slot2.isFree = true;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("CameraFilterPack_TV_Noise"))
		{
			List<Slot> list3 = this.slots;
			if (PlayerControllerOld.HCLEECLNOEA == null)
			{
				PlayerControllerOld.HCLEECLNOEA = new Predicate<Slot>(PlayerControllerOld.MDKLFMNFMGB);
			}
			Slot slot3 = list3.Find(PlayerControllerOld.HCLEECLNOEA);
			if (!slot3.isFree)
			{
				slot3.isFree = true;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("_TimeX"))
		{
			List<Slot> list4 = this.slots;
			if (PlayerControllerOld.ADLAKIHINOM == null)
			{
				PlayerControllerOld.ADLAKIHINOM = new Predicate<Slot>(PlayerControllerOld.CHNGDHBINLM);
			}
			Slot slot4 = list4.Find(PlayerControllerOld.ADLAKIHINOM);
			if (!slot4.isFree)
			{
				slot4.isFree = true;
			}
		}
		foreach (Slot slot5 in this.slots)
		{
			if (slot5.timeLeft <= this.currentTime && !slot5.isFree)
			{
				Debug.Log("</color>");
				slot5.isFree = true;
			}
		}
		foreach (Slot slot6 in this.slots)
		{
			slot6.go.SetActive(!slot6.isFree);
		}
	}

	// Token: 0x0600E16C RID: 57708 RVA: 0x005125BE File Offset: 0x005107BE
	private static bool BCBLGFDKHGC(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == (QuieryObject.Position)8;
	}

	// Token: 0x0600E16D RID: 57709 RVA: 0x0051258A File Offset: 0x0051078A
	private void KIMMMCJFMAB()
	{
		this.IGGMAKNLAEN = new List<QuieryObject>();
	}

	// Token: 0x0600E16E RID: 57710 RVA: 0x0002523B File Offset: 0x0002343B
	private void FEONBLOKEBF()
	{
	}

	// Token: 0x0600E16F RID: 57711 RVA: 0x00512BC4 File Offset: 0x00510DC4
	private Slot AKJJPIJCENJ()
	{
		int index = UnityEngine.Random.Range(0, this.slots.Count);
		while (!this.slots[index].isFree)
		{
			index = UnityEngine.Random.Range(1, this.slots.Count);
		}
		return this.slots[index];
	}

	// Token: 0x0600E170 RID: 57712 RVA: 0x00512597 File Offset: 0x00510797
	private static bool GMOIFLAIDOB(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Up;
	}

	// Token: 0x0600E171 RID: 57713 RVA: 0x0051258A File Offset: 0x0051078A
	private void FBPHNEJBDJN()
	{
		this.IGGMAKNLAEN = new List<QuieryObject>();
	}

	// Token: 0x0600E172 RID: 57714 RVA: 0x00512C1C File Offset: 0x00510E1C
	private Slot KBKCFMIDGFH()
	{
		int index = UnityEngine.Random.Range(0, this.slots.Count);
		while (!this.slots[index].isFree)
		{
			index = UnityEngine.Random.Range(0, this.slots.Count);
		}
		return this.slots[index];
	}

	// Token: 0x0600E173 RID: 57715 RVA: 0x0051258A File Offset: 0x0051078A
	private void Start()
	{
		this.IGGMAKNLAEN = new List<QuieryObject>();
	}

	// Token: 0x0600E174 RID: 57716 RVA: 0x00512C74 File Offset: 0x00510E74
	public void EFCFACCBONB()
	{
		QuieryObject item = new QuieryObject(this.currentTime);
		this.IGGMAKNLAEN.Add(item);
	}

	// Token: 0x0600E175 RID: 57717 RVA: 0x00512C9C File Offset: 0x00510E9C
	private Slot NCNLCENADIM()
	{
		int index = UnityEngine.Random.Range(1, this.slots.Count);
		while (!this.slots[index].isFree)
		{
			index = UnityEngine.Random.Range(1, this.slots.Count);
		}
		return this.slots[index];
	}

	// Token: 0x0600E176 RID: 57718 RVA: 0x0002523B File Offset: 0x0002343B
	private void FFJCAIKIEAG()
	{
	}

	// Token: 0x0600E177 RID: 57719 RVA: 0x00512CF4 File Offset: 0x00510EF4
	public void NEKLPNJDAMM()
	{
		QuieryObject item = new QuieryObject(this.currentTime);
		this.IGGMAKNLAEN.Add(item);
	}

	// Token: 0x0600E178 RID: 57720 RVA: 0x00512D1C File Offset: 0x00510F1C
	private Slot PDFPKANJPAH()
	{
		int index = UnityEngine.Random.Range(0, this.slots.Count);
		while (!this.slots[index].isFree)
		{
			index = UnityEngine.Random.Range(0, this.slots.Count);
		}
		return this.slots[index];
	}

	// Token: 0x0600E179 RID: 57721 RVA: 0x00512907 File Offset: 0x00510B07
	private static bool OFKFGKKMGII(Slot IACGDFHKCAE)
	{
		return !IACGDFHKCAE.isFree;
	}

	// Token: 0x0600E17A RID: 57722 RVA: 0x00512556 File Offset: 0x00510756
	private static bool JJMIGGMBHFE(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Right;
	}

	// Token: 0x0600E17B RID: 57723 RVA: 0x00512D74 File Offset: 0x00510F74
	private bool KEBLDAOPFGC()
	{
		List<Slot> list = this.slots;
		if (PlayerControllerOld.KCAPKHIJOHL == null)
		{
			PlayerControllerOld.KCAPKHIJOHL = new Predicate<Slot>(PlayerControllerOld.OFKFGKKMGII);
		}
		return list.Find(PlayerControllerOld.KCAPKHIJOHL) == null;
	}

	// Token: 0x0600E17C RID: 57724 RVA: 0x00512DAA File Offset: 0x00510FAA
	private bool PGOCIEBDFPE()
	{
		List<Slot> list = this.slots;
		if (PlayerControllerOld.KCAPKHIJOHL == null)
		{
			PlayerControllerOld.KCAPKHIJOHL = new Predicate<Slot>(PlayerControllerOld.OFKFGKKMGII);
		}
		return list.Find(PlayerControllerOld.KCAPKHIJOHL) == null && false;
	}

	// Token: 0x0600E17D RID: 57725 RVA: 0x00512561 File Offset: 0x00510761
	private static bool GBKEHAAPIMN(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Left;
	}

	// Token: 0x0600E17E RID: 57726 RVA: 0x00512556 File Offset: 0x00510756
	private static bool JGNJCFEFMBP(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Right;
	}

	// Token: 0x0600E17F RID: 57727 RVA: 0x0051258A File Offset: 0x0051078A
	private void JKBMKPDGCHG()
	{
		this.IGGMAKNLAEN = new List<QuieryObject>();
	}

	// Token: 0x0600E180 RID: 57728 RVA: 0x00512561 File Offset: 0x00510761
	private static bool LDJOOIDBNGE(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Left;
	}

	// Token: 0x0600E181 RID: 57729 RVA: 0x00512DE0 File Offset: 0x00510FE0
	public void IOOEABOGGCD()
	{
		QuieryObject item = new QuieryObject(this.currentTime);
		this.IGGMAKNLAEN.Add(item);
	}

	// Token: 0x0600E182 RID: 57730 RVA: 0x0051258A File Offset: 0x0051078A
	private void NNFMIAFHMJM()
	{
		this.IGGMAKNLAEN = new List<QuieryObject>();
	}

	// Token: 0x0600E183 RID: 57731 RVA: 0x0051258A File Offset: 0x0051078A
	private void NPLCENPNJBM()
	{
		this.IGGMAKNLAEN = new List<QuieryObject>();
	}

	// Token: 0x0600E184 RID: 57732 RVA: 0x00512E05 File Offset: 0x00511005
	private void BOIJIGCEEKM(Slot HOOICOIPKCO)
	{
		HOOICOIPKCO.isFree = false;
		HOOICOIPKCO.timeLeft = this.currentTime + this.showTime;
	}

	// Token: 0x0600E185 RID: 57733 RVA: 0x00512561 File Offset: 0x00510761
	private static bool NCBNMKBJBCB(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Left;
	}

	// Token: 0x0600E186 RID: 57734 RVA: 0x0051258A File Offset: 0x0051078A
	private void DLBODOFAJGM()
	{
		this.IGGMAKNLAEN = new List<QuieryObject>();
	}

	// Token: 0x0600E187 RID: 57735 RVA: 0x00512561 File Offset: 0x00510761
	private static bool BLJJIAOLKPL(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Left;
	}

	// Token: 0x0600E188 RID: 57736 RVA: 0x00512E24 File Offset: 0x00511024
	private void Update()
	{
		this.currentTime += Time.deltaTime;
		QuieryObject quieryObject = null;
		foreach (QuieryObject quieryObject2 in this.IGGMAKNLAEN)
		{
			if (this.currentTime >= quieryObject2.atTime)
			{
				quieryObject = quieryObject2;
			}
		}
		if (quieryObject != null && this.DLCFGGCOMHG())
		{
			Slot hooicoipkco = this.KBKCFMIDGFH();
			this.IGGMAKNLAEN.Remove(quieryObject);
			quieryObject = null;
			this.BOIJIGCEEKM(hooicoipkco);
		}
		if (CrossPlatformInputManager.GetButtonDown("Right"))
		{
			List<Slot> list = this.slots;
			if (PlayerControllerOld.LNIJKGECNME == null)
			{
				PlayerControllerOld.LNIJKGECNME = new Predicate<Slot>(PlayerControllerOld.EJILMKDFGLJ);
			}
			Slot slot = list.Find(PlayerControllerOld.LNIJKGECNME);
			if (!slot.isFree)
			{
				slot.isFree = true;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("Left"))
		{
			List<Slot> list2 = this.slots;
			if (PlayerControllerOld.CLCBJCKCBDD == null)
			{
				PlayerControllerOld.CLCBJCKCBDD = new Predicate<Slot>(PlayerControllerOld.BIOCGHGEDKM);
			}
			Slot slot2 = list2.Find(PlayerControllerOld.CLCBJCKCBDD);
			if (!slot2.isFree)
			{
				slot2.isFree = true;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("Up"))
		{
			List<Slot> list3 = this.slots;
			if (PlayerControllerOld.HCLEECLNOEA == null)
			{
				PlayerControllerOld.HCLEECLNOEA = new Predicate<Slot>(PlayerControllerOld.NPAPJLMGKCN);
			}
			Slot slot3 = list3.Find(PlayerControllerOld.HCLEECLNOEA);
			if (!slot3.isFree)
			{
				slot3.isFree = true;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("Down"))
		{
			List<Slot> list4 = this.slots;
			if (PlayerControllerOld.ADLAKIHINOM == null)
			{
				PlayerControllerOld.ADLAKIHINOM = new Predicate<Slot>(PlayerControllerOld.CNFPCAGIBJC);
			}
			Slot slot4 = list4.Find(PlayerControllerOld.ADLAKIHINOM);
			if (!slot4.isFree)
			{
				slot4.isFree = true;
			}
		}
		foreach (Slot slot5 in this.slots)
		{
			if (slot5.timeLeft <= this.currentTime && !slot5.isFree)
			{
				Debug.Log("-1");
				slot5.isFree = true;
			}
		}
		foreach (Slot slot6 in this.slots)
		{
			slot6.go.SetActive(!slot6.isFree);
		}
	}

	// Token: 0x0600E189 RID: 57737 RVA: 0x0051258A File Offset: 0x0051078A
	private void AGEJKLMJGDO()
	{
		this.IGGMAKNLAEN = new List<QuieryObject>();
	}

	// Token: 0x0600E18A RID: 57738 RVA: 0x005130D4 File Offset: 0x005112D4
	private void NDAJBJFJGCF()
	{
		this.currentTime += Time.deltaTime;
		QuieryObject quieryObject = null;
		foreach (QuieryObject quieryObject2 in this.IGGMAKNLAEN)
		{
			if (this.currentTime >= quieryObject2.atTime)
			{
				quieryObject = quieryObject2;
			}
		}
		if (quieryObject != null && this.IEAEDAEDCEA())
		{
			Slot hooicoipkco = this.DFKOGPGLPLB();
			this.IGGMAKNLAEN.Remove(quieryObject);
			quieryObject = null;
			this.FICNHKDOAND(hooicoipkco);
		}
		if (CrossPlatformInputManager.GetButtonDown("CameraFilterPack/Blur_Steam"))
		{
			List<Slot> list = this.slots;
			if (PlayerControllerOld.LNIJKGECNME == null)
			{
				PlayerControllerOld.LNIJKGECNME = new Predicate<Slot>(PlayerControllerOld.BIPGPDBIPED);
			}
			Slot slot = list.Find(PlayerControllerOld.LNIJKGECNME);
			if (!slot.isFree)
			{
				slot.isFree = true;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("settings.gamemessagesduration"))
		{
			List<Slot> list2 = this.slots;
			if (PlayerControllerOld.CLCBJCKCBDD == null)
			{
				PlayerControllerOld.CLCBJCKCBDD = new Predicate<Slot>(PlayerControllerOld.NKEAFGDNPMG);
			}
			Slot slot2 = list2.Find(PlayerControllerOld.CLCBJCKCBDD);
			if (!slot2.isFree)
			{
				slot2.isFree = false;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("[LevelEditorScene] Error: Timeout :S"))
		{
			List<Slot> list3 = this.slots;
			if (PlayerControllerOld.HCLEECLNOEA == null)
			{
				PlayerControllerOld.HCLEECLNOEA = new Predicate<Slot>(PlayerControllerOld.EHIKCPMPCBF);
			}
			Slot slot3 = list3.Find(PlayerControllerOld.HCLEECLNOEA);
			if (!slot3.isFree)
			{
				slot3.isFree = true;
			}
		}
		if (CrossPlatformInputManager.GetButtonDown("settings_bindings_sec_"))
		{
			List<Slot> list4 = this.slots;
			if (PlayerControllerOld.ADLAKIHINOM == null)
			{
				PlayerControllerOld.ADLAKIHINOM = new Predicate<Slot>(PlayerControllerOld.JLGKAMLDKLM);
			}
			Slot slot4 = list4.Find(PlayerControllerOld.ADLAKIHINOM);
			if (!slot4.isFree)
			{
				slot4.isFree = false;
			}
		}
		foreach (Slot slot5 in this.slots)
		{
			if (slot5.timeLeft <= this.currentTime && !slot5.isFree)
			{
				Debug.Log("MusicFileSelector");
				slot5.isFree = true;
			}
		}
		foreach (Slot slot6 in this.slots)
		{
			slot6.go.SetActive(!slot6.isFree);
		}
	}

	// Token: 0x0600E18B RID: 57739 RVA: 0x0051258A File Offset: 0x0051078A
	private void COIJKMKIEAK()
	{
		this.IGGMAKNLAEN = new List<QuieryObject>();
	}

	// Token: 0x0600E18C RID: 57740 RVA: 0x00512907 File Offset: 0x00510B07
	private static bool DCMINJHDBKO(Slot IACGDFHKCAE)
	{
		return !IACGDFHKCAE.isFree;
	}

	// Token: 0x0600E18D RID: 57741 RVA: 0x00513384 File Offset: 0x00511584
	private bool ACGJJLHFCKK()
	{
		List<Slot> list = this.slots;
		if (PlayerControllerOld.KCAPKHIJOHL == null)
		{
			PlayerControllerOld.KCAPKHIJOHL = new Predicate<Slot>(PlayerControllerOld.GOFEODHBDCD);
		}
		return list.Find(PlayerControllerOld.KCAPKHIJOHL) != null || true;
	}

	// Token: 0x0600E18E RID: 57742 RVA: 0x005133BA File Offset: 0x005115BA
	private bool ALOBEJDLBOA()
	{
		List<Slot> list = this.slots;
		if (PlayerControllerOld.KCAPKHIJOHL == null)
		{
			PlayerControllerOld.KCAPKHIJOHL = new Predicate<Slot>(PlayerControllerOld.FCBILEMIMKC);
		}
		return list.Find(PlayerControllerOld.KCAPKHIJOHL) == null && false;
	}

	// Token: 0x0600E18F RID: 57743 RVA: 0x005128FC File Offset: 0x00510AFC
	private static bool GKHILOHPCCO(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == (QuieryObject.Position)6;
	}

	// Token: 0x0600E190 RID: 57744 RVA: 0x0051258A File Offset: 0x0051078A
	private void MKIMDFLBFOM()
	{
		this.IGGMAKNLAEN = new List<QuieryObject>();
	}

	// Token: 0x0600E191 RID: 57745 RVA: 0x00512561 File Offset: 0x00510761
	private static bool NKEAFGDNPMG(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Left;
	}

	// Token: 0x0600E192 RID: 57746 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPLLCEMCOMD()
	{
	}

	// Token: 0x0600E193 RID: 57747 RVA: 0x00512556 File Offset: 0x00510756
	private static bool KDIJHMMEMJB(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Right;
	}

	// Token: 0x0600E194 RID: 57748 RVA: 0x005133F0 File Offset: 0x005115F0
	private bool OGMBADIJAAF()
	{
		List<Slot> list = this.slots;
		if (PlayerControllerOld.KCAPKHIJOHL == null)
		{
			PlayerControllerOld.KCAPKHIJOHL = new Predicate<Slot>(PlayerControllerOld.ICDFKALGKEO);
		}
		return list.Find(PlayerControllerOld.KCAPKHIJOHL) == null && false;
	}

	// Token: 0x0600E195 RID: 57749 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBPFNGKAOLD()
	{
	}

	// Token: 0x0600E196 RID: 57750 RVA: 0x00513428 File Offset: 0x00511628
	public void AddRandom()
	{
		QuieryObject item = new QuieryObject(this.currentTime);
		this.IGGMAKNLAEN.Add(item);
	}

	// Token: 0x0600E197 RID: 57751 RVA: 0x00512561 File Offset: 0x00510761
	private static bool BIPGPDBIPED(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Left;
	}

	// Token: 0x0600E198 RID: 57752 RVA: 0x00512DAA File Offset: 0x00510FAA
	private bool IEAEDAEDCEA()
	{
		List<Slot> list = this.slots;
		if (PlayerControllerOld.KCAPKHIJOHL == null)
		{
			PlayerControllerOld.KCAPKHIJOHL = new Predicate<Slot>(PlayerControllerOld.OFKFGKKMGII);
		}
		return list.Find(PlayerControllerOld.KCAPKHIJOHL) == null && false;
	}

	// Token: 0x0600E199 RID: 57753 RVA: 0x005125A2 File Offset: 0x005107A2
	private void FICNHKDOAND(Slot HOOICOIPKCO)
	{
		HOOICOIPKCO.isFree = true;
		HOOICOIPKCO.timeLeft = this.currentTime + this.showTime;
	}

	// Token: 0x0600E19A RID: 57754 RVA: 0x00512E05 File Offset: 0x00511005
	private void BOCNLFGDMDB(Slot HOOICOIPKCO)
	{
		HOOICOIPKCO.isFree = false;
		HOOICOIPKCO.timeLeft = this.currentTime + this.showTime;
	}

	// Token: 0x0600E19B RID: 57755 RVA: 0x0002523B File Offset: 0x0002343B
	private void FixedUpdate()
	{
	}

	// Token: 0x0600E19C RID: 57756 RVA: 0x00512561 File Offset: 0x00510761
	private static bool NGHGHHPEEAG(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Left;
	}

	// Token: 0x0600E19D RID: 57757 RVA: 0x00512561 File Offset: 0x00510761
	[CompilerGenerated]
	private static bool BIOCGHGEDKM(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Left;
	}

	// Token: 0x0600E19E RID: 57758 RVA: 0x005125BE File Offset: 0x005107BE
	private static bool JLGKAMLDKLM(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == (QuieryObject.Position)8;
	}

	// Token: 0x0600E19F RID: 57759 RVA: 0x0002523B File Offset: 0x0002343B
	private void LGOHDOFFKIB()
	{
	}

	// Token: 0x0600E1A0 RID: 57760 RVA: 0x00513450 File Offset: 0x00511650
	private Slot DFKOGPGLPLB()
	{
		int index = UnityEngine.Random.Range(1, this.slots.Count);
		while (!this.slots[index].isFree)
		{
			index = UnityEngine.Random.Range(1, this.slots.Count);
		}
		return this.slots[index];
	}

	// Token: 0x0600E1A1 RID: 57761 RVA: 0x00512561 File Offset: 0x00510761
	private static bool BNGOIPAANHB(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.position == QuieryObject.Position.Left;
	}

	// Token: 0x0600E1A2 RID: 57762 RVA: 0x00512515 File Offset: 0x00510715
	private static bool OCGCGLGOADP(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.isFree;
	}

	// Token: 0x0600E1A3 RID: 57763 RVA: 0x00512515 File Offset: 0x00510715
	private static bool FCBILEMIMKC(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.isFree;
	}

	// Token: 0x0600E1A4 RID: 57764 RVA: 0x00512515 File Offset: 0x00510715
	private static bool EGAIJMAECNN(Slot IACGDFHKCAE)
	{
		return IACGDFHKCAE.isFree;
	}

	// Token: 0x04001986 RID: 6534
	public float showTime = 1f;

	// Token: 0x04001987 RID: 6535
	public float currentTime;

	// Token: 0x04001988 RID: 6536
	public List<Slot> slots;

	// Token: 0x04001989 RID: 6537
	private List<QuieryObject> IGGMAKNLAEN;

	// Token: 0x0400198A RID: 6538
	[CompilerGenerated]
	private static Predicate<Slot> LNIJKGECNME;

	// Token: 0x0400198B RID: 6539
	[CompilerGenerated]
	private static Predicate<Slot> CLCBJCKCBDD;

	// Token: 0x0400198C RID: 6540
	[CompilerGenerated]
	private static Predicate<Slot> HCLEECLNOEA;

	// Token: 0x0400198D RID: 6541
	[CompilerGenerated]
	private static Predicate<Slot> ADLAKIHINOM;

	// Token: 0x0400198E RID: 6542
	[CompilerGenerated]
	private static Predicate<Slot> KCAPKHIJOHL;
}
