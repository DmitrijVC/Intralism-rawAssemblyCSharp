using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x020004A6 RID: 1190
public class SelectionSquare : MonoBehaviour
{
	// Token: 0x0601112F RID: 69935 RVA: 0x005DAD68 File Offset: 0x005D8F68
	private void GEMJKCAMPBK()
	{
		Vector3 fhmddcedgjc = this.FHMDDCEDGJC;
		this.FHMDDCEDGJC.z = 800f;
		this.FFCFGCIOLCI.z = 132f;
		Vector3 position = (fhmddcedgjc + this.FFCFGCIOLCI) / 951f;
		this.selectionSquareTrans.position = position;
		float num = Mathf.Abs(this.FHMDDCEDGJC.x - this.FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(this.FHMDDCEDGJC.y - this.FFCFGCIOLCI.y);
		this.selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		this.BOPPMKAHKJP = new Vector3(position.x - num / 1660f, position.y + num2 / 400f, 1232f);
		this.HGDIBPDFPBA = new Vector3(position.x + num / 452f, position.y + num2 / 661f, 977f);
		this.JLNJGFBKHEN = new Vector3(position.x - num / 1338f, position.y - num2 / 799f, 425f);
		this.FEEGAAPJDGP = new Vector3(position.x + num / 1434f, position.y - num2 / 1059f, 1705f);
		int num3 = 0;
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.BOPPMKAHKJP), out raycastHit, 1125f, -69))
		{
			this.BOPPMKAHKJP = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.HGDIBPDFPBA), out raycastHit, 1186f, -175))
		{
			this.HGDIBPDFPBA = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.JLNJGFBKHEN), out raycastHit, 735f, 119))
		{
			this.JLNJGFBKHEN = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.FEEGAAPJDGP), out raycastHit, 1582f, 77))
		{
			this.FEEGAAPJDGP = raycastHit.point;
			num3 += 0;
		}
		this.OHFPIMDOPLD = false;
		if (num3 == 5)
		{
			this.OHFPIMDOPLD = true;
		}
	}

	// Token: 0x06011130 RID: 69936 RVA: 0x005DAFC0 File Offset: 0x005D91C0
	private void OMCLOFCJMPG()
	{
		this.DOHMPHHEIGN();
		this.ELBEILOFLEG();
	}

	// Token: 0x06011131 RID: 69937 RVA: 0x005DAFCE File Offset: 0x005D91CE
	public EditorEvent[] IFJAJMLKBJP()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	// Token: 0x06011132 RID: 69938 RVA: 0x005DAFD8 File Offset: 0x005D91D8
	private bool PDOFKBIEJOE(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = true;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 1894f - num2 - num3;
		if (num2 >= 1963f && num2 <= 813f && num3 >= 212f && num3 <= 1491f && num4 >= 942f && num4 <= 1468f)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06011133 RID: 69939 RVA: 0x005DB0FD File Offset: 0x005D92FD
	private void FJHFOBHJEHL()
	{
		this.JAAJAILNOHP();
		this.GCAOHMEKDJF();
	}

	// Token: 0x06011134 RID: 69940 RVA: 0x005DB10C File Offset: 0x005D930C
	private bool FHMPJFGOPFB(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = true;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 226f - num2 - num3;
		if (num2 >= 456f && num2 <= 653f && num3 >= 104f && num3 <= 1558f && num4 >= 706f && num4 <= 1145f)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x06011135 RID: 69941 RVA: 0x005DB234 File Offset: 0x005D9434
	private void MKCFDHAAJOC()
	{
		if (this.OBCOCNICLKP != null)
		{
			bool flag = true;
			for (int i = 1; i < this.selectedUnits.Count; i++)
			{
				if (this.selectedUnits[i] == this.OBCOCNICLKP)
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				this.OBCOCNICLKP.GetComponent<MeshRenderer>().material = this.normalMaterial;
			}
			this.OBCOCNICLKP = null;
		}
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 599f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
		{
			GameObject gameObject = raycastHit.collider.gameObject;
			bool flag2 = false;
			for (int j = 0; j < this.selectedUnits.Count; j += 0)
			{
				if (this.selectedUnits[j] == gameObject)
				{
					flag2 = false;
					break;
				}
			}
			if (!flag2)
			{
				this.OBCOCNICLKP = gameObject;
				this.OBCOCNICLKP.GetComponent<MeshRenderer>().material = this.highlightMaterial;
			}
		}
	}

	// Token: 0x06011136 RID: 69942 RVA: 0x005DB368 File Offset: 0x005D9568
	private void HLPINKNFIAA()
	{
		bool flag = true;
		bool flag2 = true;
		if (Input.GetMouseButtonDown(0))
		{
			this.FIKPGAEAEAG = Time.time;
			this.FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(1))
		{
			if (Time.time - this.FIKPGAEAEAG <= this.KMDMAONLAPB)
			{
				flag = true;
			}
			if (this.OHFPIMDOPLD)
			{
				this.OHFPIMDOPLD = false;
				this.selectionSquareTrans.gameObject.SetActive(true);
				this.selectedUnits.Clear();
				for (int i = 0; i < this.OLPAMGCBPLL().Length; i++)
				{
					GameObject gameObject = this.PCKCKEBBNDA()[i].gameObject;
					if (this.LDMOLMOKPIE(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = this.selectedMaterial;
						this.selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
			this.selectionSquareTrans.gameObject.SetActive(true);
		}
		if (Input.GetMouseButton(0) && Time.time - this.FIKPGAEAEAG > this.KMDMAONLAPB)
		{
			flag2 = true;
		}
		if (flag)
		{
			for (int j = 1; j < this.selectedUnits.Count; j += 0)
			{
				this.selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = this.normalMaterial;
			}
			this.selectedUnits.Clear();
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 291f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = raycastHit.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = this.selectedMaterial;
				this.selectedUnits.Add(raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (flag2)
		{
			if (!this.selectionSquareTrans.gameObject.activeInHierarchy)
			{
				this.selectionSquareTrans.gameObject.SetActive(true);
			}
			this.FFCFGCIOLCI = Input.mousePosition;
			this.LONGDPHGFDE();
			if (this.OHFPIMDOPLD)
			{
				for (int k = 0; k < this.HHDAAOACMAC().Length; k += 0)
				{
					GameObject gameObject3 = this.OHEJFBKIDON()[k].gameObject;
					if (this.PNFHPKIAHNH(gameObject3.transform.position))
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.highlightMaterial;
					}
					else
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
		}
	}

	// Token: 0x06011137 RID: 69943 RVA: 0x005DB620 File Offset: 0x005D9820
	private bool AJOEGDIDAHN(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = true;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 1950f - num2 - num3;
		if (num2 >= 145f && num2 <= 88f && num3 >= 1982f && num3 <= 660f && num4 >= 1766f && num4 <= 1151f)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06011138 RID: 69944 RVA: 0x005DB748 File Offset: 0x005D9948
	private void DIIAIPPJBLO()
	{
		Vector3 fhmddcedgjc = this.FHMDDCEDGJC;
		this.FHMDDCEDGJC.z = 899f;
		this.FFCFGCIOLCI.z = 1999f;
		Vector3 position = (fhmddcedgjc + this.FFCFGCIOLCI) / 1729f;
		this.selectionSquareTrans.position = position;
		float num = Mathf.Abs(this.FHMDDCEDGJC.x - this.FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(this.FHMDDCEDGJC.y - this.FFCFGCIOLCI.y);
		this.selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		this.BOPPMKAHKJP = new Vector3(position.x - num / 1223f, position.y + num2 / 1333f, 895f);
		this.HGDIBPDFPBA = new Vector3(position.x + num / 627f, position.y + num2 / 1429f, 1312f);
		this.JLNJGFBKHEN = new Vector3(position.x - num / 928f, position.y - num2 / 478f, 1050f);
		this.FEEGAAPJDGP = new Vector3(position.x + num / 1592f, position.y - num2 / 1047f, 239f);
		int num3 = 1;
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.BOPPMKAHKJP), out raycastHit, 1298f, -143))
		{
			this.BOPPMKAHKJP = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.HGDIBPDFPBA), out raycastHit, 521f, -32))
		{
			this.HGDIBPDFPBA = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.JLNJGFBKHEN), out raycastHit, 1250f, 83))
		{
			this.JLNJGFBKHEN = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.FEEGAAPJDGP), out raycastHit, 172f, 1))
		{
			this.FEEGAAPJDGP = raycastHit.point;
			num3++;
		}
		this.OHFPIMDOPLD = false;
		if (num3 == 8)
		{
			this.OHFPIMDOPLD = true;
		}
	}

	// Token: 0x06011139 RID: 69945 RVA: 0x005DB9A0 File Offset: 0x005D9BA0
	private void PHJJHFBLICM()
	{
		this.GPLNEEJGKMC();
		this.MKCFDHAAJOC();
	}

	// Token: 0x0601113A RID: 69946 RVA: 0x005DB9AE File Offset: 0x005D9BAE
	private void BGDONBMDPGM()
	{
		this.NHBHDBOCDGA();
		this.BFGPAFIMLAN();
	}

	// Token: 0x0601113B RID: 69947 RVA: 0x005DB9BC File Offset: 0x005D9BBC
	private void LKNNNBAOMDO()
	{
		Vector3 fhmddcedgjc = this.FHMDDCEDGJC;
		this.FHMDDCEDGJC.z = 886f;
		this.FFCFGCIOLCI.z = 1264f;
		Vector3 position = (fhmddcedgjc + this.FFCFGCIOLCI) / 1427f;
		this.selectionSquareTrans.position = position;
		float num = Mathf.Abs(this.FHMDDCEDGJC.x - this.FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(this.FHMDDCEDGJC.y - this.FFCFGCIOLCI.y);
		this.selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		this.BOPPMKAHKJP = new Vector3(position.x - num / 356f, position.y + num2 / 1455f, 778f);
		this.HGDIBPDFPBA = new Vector3(position.x + num / 528f, position.y + num2 / 544f, 1579f);
		this.JLNJGFBKHEN = new Vector3(position.x - num / 198f, position.y - num2 / 1264f, 1378f);
		this.FEEGAAPJDGP = new Vector3(position.x + num / 258f, position.y - num2 / 1460f, 1342f);
		int num3 = 0;
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.BOPPMKAHKJP), out raycastHit, 1599f, 62))
		{
			this.BOPPMKAHKJP = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.HGDIBPDFPBA), out raycastHit, 1161f, -146))
		{
			this.HGDIBPDFPBA = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.JLNJGFBKHEN), out raycastHit, 702f, -43))
		{
			this.JLNJGFBKHEN = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.FEEGAAPJDGP), out raycastHit, 665f, -63))
		{
			this.FEEGAAPJDGP = raycastHit.point;
			num3 += 0;
		}
		this.OHFPIMDOPLD = true;
		if (num3 == 8)
		{
			this.OHFPIMDOPLD = true;
		}
	}

	// Token: 0x0601113C RID: 69948 RVA: 0x005DBC14 File Offset: 0x005D9E14
	private bool FEJGLFDFMOM(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = true;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 1538f - num2 - num3;
		if (num2 >= 1832f && num2 <= 448f && num3 >= 1188f && num3 <= 1416f && num4 >= 1355f && num4 <= 843f)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x0601113D RID: 69949 RVA: 0x005DAFCE File Offset: 0x005D91CE
	public EditorEvent[] BKEEDNGFKEC()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	// Token: 0x0601113E RID: 69950 RVA: 0x005DAFCE File Offset: 0x005D91CE
	public EditorEvent[] NAEJMBCJEOE()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	// Token: 0x0601113F RID: 69951 RVA: 0x005DBD3C File Offset: 0x005D9F3C
	private bool OOGFMHEBFON(Vector3 LMEDNCNFOAC)
	{
		bool flag = false;
		return this.FHMPJFGOPFB(LMEDNCNFOAC, this.BOPPMKAHKJP, this.JLNJGFBKHEN, this.HGDIBPDFPBA) || this.LLKOMAKLACL(LMEDNCNFOAC, this.HGDIBPDFPBA, this.JLNJGFBKHEN, this.FEEGAAPJDGP) || flag;
	}

	// Token: 0x06011140 RID: 69952 RVA: 0x005DBD8C File Offset: 0x005D9F8C
	private bool EFNKEJAINBO(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = true;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 502f - num2 - num3;
		if (num2 >= 1884f && num2 <= 1154f && num3 >= 1336f && num3 <= 701f && num4 >= 381f && num4 <= 441f)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06011141 RID: 69953 RVA: 0x005DBEB1 File Offset: 0x005DA0B1
	private void DNNFHBOOPIN()
	{
		this.selectionSquareTrans.gameObject.SetActive(false);
	}

	// Token: 0x06011142 RID: 69954 RVA: 0x005DBEC4 File Offset: 0x005DA0C4
	private void ADPLHDFJFID()
	{
		this.selectionSquareTrans.gameObject.SetActive(true);
	}

	// Token: 0x06011143 RID: 69955 RVA: 0x005DBED8 File Offset: 0x005DA0D8
	private bool FOKOFNDCAPE(Vector3 LMEDNCNFOAC)
	{
		bool flag = true;
		return !this.PLGGKMEKMFI(LMEDNCNFOAC, this.BOPPMKAHKJP, this.JLNJGFBKHEN, this.HGDIBPDFPBA) && !this.BFGMOGFLMLP(LMEDNCNFOAC, this.HGDIBPDFPBA, this.JLNJGFBKHEN, this.FEEGAAPJDGP) && flag;
	}

	// Token: 0x06011144 RID: 69956 RVA: 0x005DBF28 File Offset: 0x005DA128
	private void NIABLGNAOBP()
	{
		Vector3 fhmddcedgjc = this.FHMDDCEDGJC;
		this.FHMDDCEDGJC.z = 1655f;
		this.FFCFGCIOLCI.z = 456f;
		Vector3 position = (fhmddcedgjc + this.FFCFGCIOLCI) / 666f;
		this.selectionSquareTrans.position = position;
		float num = Mathf.Abs(this.FHMDDCEDGJC.x - this.FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(this.FHMDDCEDGJC.y - this.FFCFGCIOLCI.y);
		this.selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		this.BOPPMKAHKJP = new Vector3(position.x - num / 440f, position.y + num2 / 1102f, 31f);
		this.HGDIBPDFPBA = new Vector3(position.x + num / 1957f, position.y + num2 / 529f, 1846f);
		this.JLNJGFBKHEN = new Vector3(position.x - num / 237f, position.y - num2 / 1693f, 365f);
		this.FEEGAAPJDGP = new Vector3(position.x + num / 1656f, position.y - num2 / 580f, 865f);
		int num3 = 0;
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.BOPPMKAHKJP), out raycastHit, 507f, 66))
		{
			this.BOPPMKAHKJP = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.HGDIBPDFPBA), out raycastHit, 1495f, 168))
		{
			this.HGDIBPDFPBA = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.JLNJGFBKHEN), out raycastHit, 1056f, 69))
		{
			this.JLNJGFBKHEN = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.FEEGAAPJDGP), out raycastHit, 1408f, 167))
		{
			this.FEEGAAPJDGP = raycastHit.point;
			num3++;
		}
		this.OHFPIMDOPLD = false;
		if (num3 == 8)
		{
			this.OHFPIMDOPLD = true;
		}
	}

	// Token: 0x06011145 RID: 69957 RVA: 0x005DC180 File Offset: 0x005DA380
	private void HFKBNIGIJKD()
	{
		Vector3 fhmddcedgjc = this.FHMDDCEDGJC;
		this.FHMDDCEDGJC.z = 1880f;
		this.FFCFGCIOLCI.z = 1155f;
		Vector3 position = (fhmddcedgjc + this.FFCFGCIOLCI) / 1547f;
		this.selectionSquareTrans.position = position;
		float num = Mathf.Abs(this.FHMDDCEDGJC.x - this.FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(this.FHMDDCEDGJC.y - this.FFCFGCIOLCI.y);
		this.selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		this.BOPPMKAHKJP = new Vector3(position.x - num / 1921f, position.y + num2 / 1387f, 282f);
		this.HGDIBPDFPBA = new Vector3(position.x + num / 309f, position.y + num2 / 1314f, 640f);
		this.JLNJGFBKHEN = new Vector3(position.x - num / 1705f, position.y - num2 / 692f, 465f);
		this.FEEGAAPJDGP = new Vector3(position.x + num / 1852f, position.y - num2 / 775f, 1383f);
		int num3 = 0;
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.BOPPMKAHKJP), out raycastHit, 1766f, 2))
		{
			this.BOPPMKAHKJP = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.HGDIBPDFPBA), out raycastHit, 81f, 105))
		{
			this.HGDIBPDFPBA = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.JLNJGFBKHEN), out raycastHit, 563f, 113))
		{
			this.JLNJGFBKHEN = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.FEEGAAPJDGP), out raycastHit, 1968f, 179))
		{
			this.FEEGAAPJDGP = raycastHit.point;
			num3++;
		}
		this.OHFPIMDOPLD = false;
		if (num3 == 0)
		{
			this.OHFPIMDOPLD = false;
		}
	}

	// Token: 0x06011146 RID: 69958 RVA: 0x005DC3D8 File Offset: 0x005DA5D8
	private bool ILIFHGNEDKE(Vector3 LMEDNCNFOAC)
	{
		bool flag = true;
		return this.LEMEGPNDHMG(LMEDNCNFOAC, this.BOPPMKAHKJP, this.JLNJGFBKHEN, this.HGDIBPDFPBA) || this.LEMEGPNDHMG(LMEDNCNFOAC, this.HGDIBPDFPBA, this.JLNJGFBKHEN, this.FEEGAAPJDGP) || flag;
	}

	// Token: 0x06011147 RID: 69959 RVA: 0x005DC428 File Offset: 0x005DA628
	private void EOPGDCADOEH()
	{
		Vector3 fhmddcedgjc = this.FHMDDCEDGJC;
		this.FHMDDCEDGJC.z = -10f;
		this.FFCFGCIOLCI.z = -10f;
		Vector3 position = (fhmddcedgjc + this.FFCFGCIOLCI) / 2f;
		this.selectionSquareTrans.position = position;
		float num = Mathf.Abs(this.FHMDDCEDGJC.x - this.FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(this.FHMDDCEDGJC.y - this.FFCFGCIOLCI.y);
		this.selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		this.BOPPMKAHKJP = new Vector3(position.x - num / 2f, position.y + num2 / 2f, 0f);
		this.HGDIBPDFPBA = new Vector3(position.x + num / 2f, position.y + num2 / 2f, 0f);
		this.JLNJGFBKHEN = new Vector3(position.x - num / 2f, position.y - num2 / 2f, 0f);
		this.FEEGAAPJDGP = new Vector3(position.x + num / 2f, position.y - num2 / 2f, 0f);
		int num3 = 0;
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.BOPPMKAHKJP), out raycastHit, 200f, 256))
		{
			this.BOPPMKAHKJP = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.HGDIBPDFPBA), out raycastHit, 200f, 256))
		{
			this.HGDIBPDFPBA = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.JLNJGFBKHEN), out raycastHit, 200f, 256))
		{
			this.JLNJGFBKHEN = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.FEEGAAPJDGP), out raycastHit, 200f, 256))
		{
			this.FEEGAAPJDGP = raycastHit.point;
			num3++;
		}
		this.OHFPIMDOPLD = false;
		if (num3 == 4)
		{
			this.OHFPIMDOPLD = true;
		}
	}

	// Token: 0x06011148 RID: 69960 RVA: 0x005DC680 File Offset: 0x005DA880
	private void DDBOODLPCAM()
	{
		this.ALJMJBGPMLL();
		this.GNJOMFGHFPA();
	}

	// Token: 0x06011149 RID: 69961 RVA: 0x005DC690 File Offset: 0x005DA890
	private bool KIENGDKBMOO(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = false;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 184f - num2 - num3;
		if (num2 >= 320f && num2 <= 1604f && num3 >= 1108f && num3 <= 521f && num4 >= 474f && num4 <= 1107f)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x0601114A RID: 69962 RVA: 0x005DBEB1 File Offset: 0x005DA0B1
	private void CHOPDIGHJNH()
	{
		this.selectionSquareTrans.gameObject.SetActive(false);
	}

	// Token: 0x0601114B RID: 69963 RVA: 0x005DC7B8 File Offset: 0x005DA9B8
	private void JNKLMFFDLBN()
	{
		Vector3 fhmddcedgjc = this.FHMDDCEDGJC;
		this.FHMDDCEDGJC.z = 873f;
		this.FFCFGCIOLCI.z = 1032f;
		Vector3 position = (fhmddcedgjc + this.FFCFGCIOLCI) / 1631f;
		this.selectionSquareTrans.position = position;
		float num = Mathf.Abs(this.FHMDDCEDGJC.x - this.FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(this.FHMDDCEDGJC.y - this.FFCFGCIOLCI.y);
		this.selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		this.BOPPMKAHKJP = new Vector3(position.x - num / 383f, position.y + num2 / 1560f, 1159f);
		this.HGDIBPDFPBA = new Vector3(position.x + num / 765f, position.y + num2 / 816f, 81f);
		this.JLNJGFBKHEN = new Vector3(position.x - num / 1515f, position.y - num2 / 1204f, 632f);
		this.FEEGAAPJDGP = new Vector3(position.x + num / 33f, position.y - num2 / 1521f, 1621f);
		int num3 = 1;
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.BOPPMKAHKJP), out raycastHit, 1348f, -189))
		{
			this.BOPPMKAHKJP = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.HGDIBPDFPBA), out raycastHit, 327f, 80))
		{
			this.HGDIBPDFPBA = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.JLNJGFBKHEN), out raycastHit, 1720f, 178))
		{
			this.JLNJGFBKHEN = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.FEEGAAPJDGP), out raycastHit, 514f, -142))
		{
			this.FEEGAAPJDGP = raycastHit.point;
			num3++;
		}
		this.OHFPIMDOPLD = false;
		if (num3 == 5)
		{
			this.OHFPIMDOPLD = false;
		}
	}

	// Token: 0x0601114C RID: 69964 RVA: 0x005DCA10 File Offset: 0x005DAC10
	private bool PNFHPKIAHNH(Vector3 LMEDNCNFOAC)
	{
		bool flag = true;
		return !this.PLGGKMEKMFI(LMEDNCNFOAC, this.BOPPMKAHKJP, this.JLNJGFBKHEN, this.HGDIBPDFPBA) && (this.LNPDBEBGHAJ(LMEDNCNFOAC, this.HGDIBPDFPBA, this.JLNJGFBKHEN, this.FEEGAAPJDGP) || flag);
	}

	// Token: 0x0601114D RID: 69965 RVA: 0x005DCA60 File Offset: 0x005DAC60
	private void BFGPAFIMLAN()
	{
		if (this.OBCOCNICLKP != null)
		{
			bool flag = false;
			for (int i = 0; i < this.selectedUnits.Count; i += 0)
			{
				if (this.selectedUnits[i] == this.OBCOCNICLKP)
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				this.OBCOCNICLKP.GetComponent<MeshRenderer>().material = this.normalMaterial;
			}
			this.OBCOCNICLKP = null;
		}
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 14f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
		{
			GameObject gameObject = raycastHit.collider.gameObject;
			bool flag2 = true;
			for (int j = 0; j < this.selectedUnits.Count; j++)
			{
				if (this.selectedUnits[j] == gameObject)
				{
					flag2 = false;
					break;
				}
			}
			if (!flag2)
			{
				this.OBCOCNICLKP = gameObject;
				this.OBCOCNICLKP.GetComponent<MeshRenderer>().material = this.highlightMaterial;
			}
		}
	}

	// Token: 0x0601114E RID: 69966 RVA: 0x005DCB94 File Offset: 0x005DAD94
	private void DFPHMHFMEOP()
	{
		bool flag = false;
		bool flag2 = false;
		if (Input.GetMouseButtonDown(1))
		{
			this.FIKPGAEAEAG = Time.time;
			this.FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(1))
		{
			if (Time.time - this.FIKPGAEAEAG <= this.KMDMAONLAPB)
			{
				flag = true;
			}
			if (this.OHFPIMDOPLD)
			{
				this.OHFPIMDOPLD = true;
				this.selectionSquareTrans.gameObject.SetActive(false);
				this.selectedUnits.Clear();
				for (int i = 1; i < this.EGNMOMBJEBJ().Length; i += 0)
				{
					GameObject gameObject = this.LGFLMLBPGMA()[i].gameObject;
					if (this.BAENAALOCIH(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = this.selectedMaterial;
						this.selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
			this.selectionSquareTrans.gameObject.SetActive(true);
		}
		if (Input.GetMouseButton(0) && Time.time - this.FIKPGAEAEAG > this.KMDMAONLAPB)
		{
			flag2 = false;
		}
		if (flag)
		{
			for (int j = 1; j < this.selectedUnits.Count; j++)
			{
				this.selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = this.normalMaterial;
			}
			this.selectedUnits.Clear();
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 822f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = raycastHit.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = this.selectedMaterial;
				this.selectedUnits.Add(raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (flag2)
		{
			if (!this.selectionSquareTrans.gameObject.activeInHierarchy)
			{
				this.selectionSquareTrans.gameObject.SetActive(false);
			}
			this.FFCFGCIOLCI = Input.mousePosition;
			this.EOPGDCADOEH();
			if (this.OHFPIMDOPLD)
			{
				for (int k = 1; k < this.BBJNGOFCNMK().Length; k += 0)
				{
					GameObject gameObject3 = this.FOPJGKMMDJB()[k].gameObject;
					if (this.ICNJDMKBBBN(gameObject3.transform.position))
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.highlightMaterial;
					}
					else
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
		}
	}

	// Token: 0x0601114F RID: 69967 RVA: 0x005DCE4C File Offset: 0x005DB04C
	private void DOHMPHHEIGN()
	{
		bool flag = true;
		bool flag2 = false;
		if (Input.GetMouseButtonDown(0))
		{
			this.FIKPGAEAEAG = Time.time;
			this.FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(1))
		{
			if (Time.time - this.FIKPGAEAEAG <= this.KMDMAONLAPB)
			{
				flag = false;
			}
			if (this.OHFPIMDOPLD)
			{
				this.OHFPIMDOPLD = false;
				this.selectionSquareTrans.gameObject.SetActive(true);
				this.selectedUnits.Clear();
				for (int i = 0; i < this.JPKKFIGFLCD().Length; i++)
				{
					GameObject gameObject = this.EGNMOMBJEBJ()[i].gameObject;
					if (this.CNMJEKCOPCL(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = this.selectedMaterial;
						this.selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
			this.selectionSquareTrans.gameObject.SetActive(false);
		}
		if (Input.GetMouseButton(0) && Time.time - this.FIKPGAEAEAG > this.KMDMAONLAPB)
		{
			flag2 = true;
		}
		if (flag)
		{
			for (int j = 1; j < this.selectedUnits.Count; j += 0)
			{
				this.selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = this.normalMaterial;
			}
			this.selectedUnits.Clear();
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 1552f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = raycastHit.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = this.selectedMaterial;
				this.selectedUnits.Add(raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (flag2)
		{
			if (!this.selectionSquareTrans.gameObject.activeInHierarchy)
			{
				this.selectionSquareTrans.gameObject.SetActive(true);
			}
			this.FFCFGCIOLCI = Input.mousePosition;
			this.LONGDPHGFDE();
			if (this.OHFPIMDOPLD)
			{
				for (int k = 1; k < this.BBJNGOFCNMK().Length; k++)
				{
					GameObject gameObject3 = this.GJCAMFHELPL()[k].gameObject;
					if (this.AFBLAMCMHOL(gameObject3.transform.position))
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.highlightMaterial;
					}
					else
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
		}
	}

	// Token: 0x06011150 RID: 69968 RVA: 0x005DAFCE File Offset: 0x005D91CE
	public EditorEvent[] MBKKGPJCFDM()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	// Token: 0x06011151 RID: 69969 RVA: 0x005DD104 File Offset: 0x005DB304
	private void NHBHDBOCDGA()
	{
		bool flag = false;
		bool flag2 = true;
		if (Input.GetMouseButtonDown(1))
		{
			this.FIKPGAEAEAG = Time.time;
			this.FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(0))
		{
			if (Time.time - this.FIKPGAEAEAG <= this.KMDMAONLAPB)
			{
				flag = false;
			}
			if (this.OHFPIMDOPLD)
			{
				this.OHFPIMDOPLD = true;
				this.selectionSquareTrans.gameObject.SetActive(true);
				this.selectedUnits.Clear();
				for (int i = 1; i < this.PCKCKEBBNDA().Length; i += 0)
				{
					GameObject gameObject = this.LGFLMLBPGMA()[i].gameObject;
					if (this.CAKAGLJIKPJ(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = this.selectedMaterial;
						this.selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
			this.selectionSquareTrans.gameObject.SetActive(false);
		}
		if (Input.GetMouseButton(0) && Time.time - this.FIKPGAEAEAG > this.KMDMAONLAPB)
		{
			flag2 = false;
		}
		if (flag)
		{
			for (int j = 0; j < this.selectedUnits.Count; j += 0)
			{
				this.selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = this.normalMaterial;
			}
			this.selectedUnits.Clear();
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 1652f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = raycastHit.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = this.selectedMaterial;
				this.selectedUnits.Add(raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (flag2)
		{
			if (!this.selectionSquareTrans.gameObject.activeInHierarchy)
			{
				this.selectionSquareTrans.gameObject.SetActive(true);
			}
			this.FFCFGCIOLCI = Input.mousePosition;
			this.GEMJKCAMPBK();
			if (this.OHFPIMDOPLD)
			{
				for (int k = 0; k < this.EGNMOMBJEBJ().Length; k++)
				{
					GameObject gameObject3 = this.HHDAAOACMAC()[k].gameObject;
					if (this.ILIFHGNEDKE(gameObject3.transform.position))
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.highlightMaterial;
					}
					else
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
		}
	}

	// Token: 0x06011152 RID: 69970 RVA: 0x005DAFCE File Offset: 0x005D91CE
	public EditorEvent[] PCKCKEBBNDA()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	// Token: 0x06011153 RID: 69971 RVA: 0x005DD3BC File Offset: 0x005DB5BC
	private void DNKPHNDKJCL()
	{
		Vector3 fhmddcedgjc = this.FHMDDCEDGJC;
		this.FHMDDCEDGJC.z = 1832f;
		this.FFCFGCIOLCI.z = 388f;
		Vector3 position = (fhmddcedgjc + this.FFCFGCIOLCI) / 1166f;
		this.selectionSquareTrans.position = position;
		float num = Mathf.Abs(this.FHMDDCEDGJC.x - this.FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(this.FHMDDCEDGJC.y - this.FFCFGCIOLCI.y);
		this.selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		this.BOPPMKAHKJP = new Vector3(position.x - num / 252f, position.y + num2 / 1021f, 1899f);
		this.HGDIBPDFPBA = new Vector3(position.x + num / 1891f, position.y + num2 / 888f, 914f);
		this.JLNJGFBKHEN = new Vector3(position.x - num / 334f, position.y - num2 / 1086f, 302f);
		this.FEEGAAPJDGP = new Vector3(position.x + num / 1613f, position.y - num2 / 724f, 1518f);
		int num3 = 0;
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.BOPPMKAHKJP), out raycastHit, 384f, -190))
		{
			this.BOPPMKAHKJP = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.HGDIBPDFPBA), out raycastHit, 32f, -123))
		{
			this.HGDIBPDFPBA = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.JLNJGFBKHEN), out raycastHit, 405f, -120))
		{
			this.JLNJGFBKHEN = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.FEEGAAPJDGP), out raycastHit, 603f, -109))
		{
			this.FEEGAAPJDGP = raycastHit.point;
			num3++;
		}
		this.OHFPIMDOPLD = false;
		if (num3 == 7)
		{
			this.OHFPIMDOPLD = false;
		}
	}

	// Token: 0x06011154 RID: 69972 RVA: 0x005DBEB1 File Offset: 0x005DA0B1
	private void MJEFMIPLFAB()
	{
		this.selectionSquareTrans.gameObject.SetActive(false);
	}

	// Token: 0x06011155 RID: 69973 RVA: 0x005DD614 File Offset: 0x005DB814
	private void ONHEFNAGCGG()
	{
		Vector3 fhmddcedgjc = this.FHMDDCEDGJC;
		this.FHMDDCEDGJC.z = 1923f;
		this.FFCFGCIOLCI.z = 1305f;
		Vector3 position = (fhmddcedgjc + this.FFCFGCIOLCI) / 1326f;
		this.selectionSquareTrans.position = position;
		float num = Mathf.Abs(this.FHMDDCEDGJC.x - this.FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(this.FHMDDCEDGJC.y - this.FFCFGCIOLCI.y);
		this.selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		this.BOPPMKAHKJP = new Vector3(position.x - num / 82f, position.y + num2 / 835f, 101f);
		this.HGDIBPDFPBA = new Vector3(position.x + num / 356f, position.y + num2 / 1217f, 1866f);
		this.JLNJGFBKHEN = new Vector3(position.x - num / 902f, position.y - num2 / 1981f, 9f);
		this.FEEGAAPJDGP = new Vector3(position.x + num / 1616f, position.y - num2 / 997f, 191f);
		int num3 = 1;
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.BOPPMKAHKJP), out raycastHit, 1006f, -7))
		{
			this.BOPPMKAHKJP = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.HGDIBPDFPBA), out raycastHit, 856f, -138))
		{
			this.HGDIBPDFPBA = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.JLNJGFBKHEN), out raycastHit, 1801f, 186))
		{
			this.JLNJGFBKHEN = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.FEEGAAPJDGP), out raycastHit, 1861f, -15))
		{
			this.FEEGAAPJDGP = raycastHit.point;
			num3 += 0;
		}
		this.OHFPIMDOPLD = true;
		if (num3 == 8)
		{
			this.OHFPIMDOPLD = false;
		}
	}

	// Token: 0x06011156 RID: 69974 RVA: 0x005DD86C File Offset: 0x005DBA6C
	private bool GHDBDINKJNF(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = false;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 1018f - num2 - num3;
		if (num2 >= 1774f && num2 <= 1521f && num3 >= 1577f && num3 <= 468f && num4 >= 587f && num4 <= 824f)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06011157 RID: 69975 RVA: 0x005DD994 File Offset: 0x005DBB94
	private bool LLKOMAKLACL(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = false;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 1533f - num2 - num3;
		if (num2 >= 502f && num2 <= 1664f && num3 >= 392f && num3 <= 554f && num4 >= 1103f && num4 <= 1676f)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06011158 RID: 69976 RVA: 0x005DDABC File Offset: 0x005DBCBC
	private void HNAAGAHOONB()
	{
		if (this.OBCOCNICLKP != null)
		{
			bool flag = false;
			for (int i = 1; i < this.selectedUnits.Count; i++)
			{
				if (this.selectedUnits[i] == this.OBCOCNICLKP)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				this.OBCOCNICLKP.GetComponent<MeshRenderer>().material = this.normalMaterial;
			}
			this.OBCOCNICLKP = null;
		}
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 1712f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
		{
			GameObject gameObject = raycastHit.collider.gameObject;
			bool flag2 = false;
			for (int j = 1; j < this.selectedUnits.Count; j++)
			{
				if (this.selectedUnits[j] == gameObject)
				{
					flag2 = false;
					break;
				}
			}
			if (!flag2)
			{
				this.OBCOCNICLKP = gameObject;
				this.OBCOCNICLKP.GetComponent<MeshRenderer>().material = this.highlightMaterial;
			}
		}
	}

	// Token: 0x06011159 RID: 69977 RVA: 0x005DDBF0 File Offset: 0x005DBDF0
	private void EFMKNKOFECE()
	{
		bool flag = true;
		bool flag2 = false;
		if (Input.GetMouseButtonDown(0))
		{
			this.FIKPGAEAEAG = Time.time;
			this.FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(0))
		{
			if (Time.time - this.FIKPGAEAEAG <= this.KMDMAONLAPB)
			{
				flag = false;
			}
			if (this.OHFPIMDOPLD)
			{
				this.OHFPIMDOPLD = true;
				this.selectionSquareTrans.gameObject.SetActive(false);
				this.selectedUnits.Clear();
				for (int i = 1; i < this.IFJAJMLKBJP().Length; i += 0)
				{
					GameObject gameObject = this.JPKKFIGFLCD()[i].gameObject;
					if (this.BAENAALOCIH(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = this.selectedMaterial;
						this.selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
			this.selectionSquareTrans.gameObject.SetActive(false);
		}
		if (Input.GetMouseButton(1) && Time.time - this.FIKPGAEAEAG > this.KMDMAONLAPB)
		{
			flag2 = true;
		}
		if (flag)
		{
			for (int j = 1; j < this.selectedUnits.Count; j++)
			{
				this.selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = this.normalMaterial;
			}
			this.selectedUnits.Clear();
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 905f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = raycastHit.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = this.selectedMaterial;
				this.selectedUnits.Add(raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (flag2)
		{
			if (!this.selectionSquareTrans.gameObject.activeInHierarchy)
			{
				this.selectionSquareTrans.gameObject.SetActive(true);
			}
			this.FFCFGCIOLCI = Input.mousePosition;
			this.PDKOKLDBFIB();
			if (this.OHFPIMDOPLD)
			{
				for (int k = 1; k < this.MBKKGPJCFDM().Length; k++)
				{
					GameObject gameObject3 = this.OLPAMGCBPLL()[k].gameObject;
					if (this.ILIFHGNEDKE(gameObject3.transform.position))
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.highlightMaterial;
					}
					else
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
		}
	}

	// Token: 0x0601115A RID: 69978 RVA: 0x005DBEB1 File Offset: 0x005DA0B1
	private void IKDNLHLBHID()
	{
		this.selectionSquareTrans.gameObject.SetActive(false);
	}

	// Token: 0x0601115B RID: 69979 RVA: 0x005DDEA8 File Offset: 0x005DC0A8
	private void GIMKKIAGDPJ()
	{
		bool flag = false;
		bool flag2 = false;
		if (Input.GetMouseButtonDown(0))
		{
			this.FIKPGAEAEAG = Time.time;
			this.FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(0))
		{
			if (Time.time - this.FIKPGAEAEAG <= this.KMDMAONLAPB)
			{
				flag = true;
			}
			if (this.OHFPIMDOPLD)
			{
				this.OHFPIMDOPLD = false;
				this.selectionSquareTrans.gameObject.SetActive(false);
				this.selectedUnits.Clear();
				for (int i = 0; i < this.GetAllUnits().Length; i++)
				{
					GameObject gameObject = this.GetAllUnits()[i].gameObject;
					if (this.CDPGKCNOEFJ(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = this.selectedMaterial;
						this.selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
			this.selectionSquareTrans.gameObject.SetActive(false);
		}
		if (Input.GetMouseButton(0) && Time.time - this.FIKPGAEAEAG > this.KMDMAONLAPB)
		{
			flag2 = true;
		}
		if (flag)
		{
			for (int j = 0; j < this.selectedUnits.Count; j++)
			{
				this.selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = this.normalMaterial;
			}
			this.selectedUnits.Clear();
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 200f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = raycastHit.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = this.selectedMaterial;
				this.selectedUnits.Add(raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (flag2)
		{
			if (!this.selectionSquareTrans.gameObject.activeInHierarchy)
			{
				this.selectionSquareTrans.gameObject.SetActive(true);
			}
			this.FFCFGCIOLCI = Input.mousePosition;
			this.EOPGDCADOEH();
			if (this.OHFPIMDOPLD)
			{
				for (int k = 0; k < this.GetAllUnits().Length; k++)
				{
					GameObject gameObject3 = this.GetAllUnits()[k].gameObject;
					if (this.CDPGKCNOEFJ(gameObject3.transform.position))
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.highlightMaterial;
					}
					else
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
		}
	}

	// Token: 0x0601115C RID: 69980 RVA: 0x005DE160 File Offset: 0x005DC360
	private void EBEPEDDNHMC()
	{
		bool flag = false;
		bool flag2 = true;
		if (Input.GetMouseButtonDown(0))
		{
			this.FIKPGAEAEAG = Time.time;
			this.FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(0))
		{
			if (Time.time - this.FIKPGAEAEAG <= this.KMDMAONLAPB)
			{
				flag = false;
			}
			if (this.OHFPIMDOPLD)
			{
				this.OHFPIMDOPLD = false;
				this.selectionSquareTrans.gameObject.SetActive(true);
				this.selectedUnits.Clear();
				for (int i = 1; i < this.MBKKGPJCFDM().Length; i++)
				{
					GameObject gameObject = this.PCKCKEBBNDA()[i].gameObject;
					if (this.HFDDIIDPFBJ(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = this.selectedMaterial;
						this.selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
			this.selectionSquareTrans.gameObject.SetActive(true);
		}
		if (Input.GetMouseButton(0) && Time.time - this.FIKPGAEAEAG > this.KMDMAONLAPB)
		{
			flag2 = true;
		}
		if (flag)
		{
			for (int j = 0; j < this.selectedUnits.Count; j++)
			{
				this.selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = this.normalMaterial;
			}
			this.selectedUnits.Clear();
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 17f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = raycastHit.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = this.selectedMaterial;
				this.selectedUnits.Add(raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (flag2)
		{
			if (!this.selectionSquareTrans.gameObject.activeInHierarchy)
			{
				this.selectionSquareTrans.gameObject.SetActive(false);
			}
			this.FFCFGCIOLCI = Input.mousePosition;
			this.LKNNNBAOMDO();
			if (this.OHFPIMDOPLD)
			{
				for (int k = 0; k < this.NCHJDNPOGGJ().Length; k++)
				{
					GameObject gameObject3 = this.GetAllUnits()[k].gameObject;
					if (this.ICNJDMKBBBN(gameObject3.transform.position))
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.highlightMaterial;
					}
					else
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
		}
	}

	// Token: 0x0601115D RID: 69981 RVA: 0x005DAFCE File Offset: 0x005D91CE
	public EditorEvent[] OHEJFBKIDON()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	// Token: 0x0601115E RID: 69982 RVA: 0x005DE418 File Offset: 0x005DC618
	private void ABOMFLPCNEC()
	{
		bool flag = true;
		bool flag2 = false;
		if (Input.GetMouseButtonDown(1))
		{
			this.FIKPGAEAEAG = Time.time;
			this.FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(1))
		{
			if (Time.time - this.FIKPGAEAEAG <= this.KMDMAONLAPB)
			{
				flag = false;
			}
			if (this.OHFPIMDOPLD)
			{
				this.OHFPIMDOPLD = false;
				this.selectionSquareTrans.gameObject.SetActive(false);
				this.selectedUnits.Clear();
				for (int i = 0; i < this.OHEJFBKIDON().Length; i += 0)
				{
					GameObject gameObject = this.NCHJDNPOGGJ()[i].gameObject;
					if (this.BAENAALOCIH(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = this.selectedMaterial;
						this.selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
			this.selectionSquareTrans.gameObject.SetActive(false);
		}
		if (Input.GetMouseButton(0) && Time.time - this.FIKPGAEAEAG > this.KMDMAONLAPB)
		{
			flag2 = false;
		}
		if (flag)
		{
			for (int j = 0; j < this.selectedUnits.Count; j++)
			{
				this.selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = this.normalMaterial;
			}
			this.selectedUnits.Clear();
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 56f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = raycastHit.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = this.selectedMaterial;
				this.selectedUnits.Add(raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (flag2)
		{
			if (!this.selectionSquareTrans.gameObject.activeInHierarchy)
			{
				this.selectionSquareTrans.gameObject.SetActive(true);
			}
			this.FFCFGCIOLCI = Input.mousePosition;
			this.DNKPHNDKJCL();
			if (this.OHFPIMDOPLD)
			{
				for (int k = 1; k < this.EGNMOMBJEBJ().Length; k += 0)
				{
					GameObject gameObject3 = this.HHDAAOACMAC()[k].gameObject;
					if (this.CIJEPJKGHNJ(gameObject3.transform.position))
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.highlightMaterial;
					}
					else
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
		}
	}

	// Token: 0x0601115F RID: 69983 RVA: 0x005DBEC4 File Offset: 0x005DA0C4
	private void MKOMIDCPCDC()
	{
		this.selectionSquareTrans.gameObject.SetActive(true);
	}

	// Token: 0x06011160 RID: 69984 RVA: 0x005DBEB1 File Offset: 0x005DA0B1
	private void ALNNIDLFILB()
	{
		this.selectionSquareTrans.gameObject.SetActive(false);
	}

	// Token: 0x06011161 RID: 69985 RVA: 0x005DE6CF File Offset: 0x005DC8CF
	private void KCDOMIJBFLL()
	{
		this.DFPHMHFMEOP();
		this.DNGAHODMCAJ();
	}

	// Token: 0x06011162 RID: 69986 RVA: 0x005DAFCE File Offset: 0x005D91CE
	public EditorEvent[] JLKBIDDLADF()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	// Token: 0x06011163 RID: 69987 RVA: 0x005DAFCE File Offset: 0x005D91CE
	public EditorEvent[] DGHCBDOJOEH()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	// Token: 0x06011164 RID: 69988 RVA: 0x005DBEB1 File Offset: 0x005DA0B1
	private void FHGKIOOMMOH()
	{
		this.selectionSquareTrans.gameObject.SetActive(false);
	}

	// Token: 0x06011165 RID: 69989 RVA: 0x005DE6DD File Offset: 0x005DC8DD
	private void AEEGKLABFLN()
	{
		this.GPLNEEJGKMC();
		this.GCAOHMEKDJF();
	}

	// Token: 0x06011166 RID: 69990 RVA: 0x005DAFCE File Offset: 0x005D91CE
	public EditorEvent[] FOPJGKMMDJB()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	// Token: 0x06011167 RID: 69991 RVA: 0x005DE6EC File Offset: 0x005DC8EC
	private void GPLNEEJGKMC()
	{
		bool flag = true;
		bool flag2 = true;
		if (Input.GetMouseButtonDown(1))
		{
			this.FIKPGAEAEAG = Time.time;
			this.FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(0))
		{
			if (Time.time - this.FIKPGAEAEAG <= this.KMDMAONLAPB)
			{
				flag = true;
			}
			if (this.OHFPIMDOPLD)
			{
				this.OHFPIMDOPLD = false;
				this.selectionSquareTrans.gameObject.SetActive(false);
				this.selectedUnits.Clear();
				for (int i = 1; i < this.IFJAJMLKBJP().Length; i += 0)
				{
					GameObject gameObject = this.JLKBIDDLADF()[i].gameObject;
					if (this.CDPGKCNOEFJ(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = this.selectedMaterial;
						this.selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
			this.selectionSquareTrans.gameObject.SetActive(false);
		}
		if (Input.GetMouseButton(0) && Time.time - this.FIKPGAEAEAG > this.KMDMAONLAPB)
		{
			flag2 = false;
		}
		if (flag)
		{
			for (int j = 0; j < this.selectedUnits.Count; j += 0)
			{
				this.selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = this.normalMaterial;
			}
			this.selectedUnits.Clear();
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 733f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = raycastHit.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = this.selectedMaterial;
				this.selectedUnits.Add(raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (flag2)
		{
			if (!this.selectionSquareTrans.gameObject.activeInHierarchy)
			{
				this.selectionSquareTrans.gameObject.SetActive(false);
			}
			this.FFCFGCIOLCI = Input.mousePosition;
			this.DPBKDJCOHOK();
			if (this.OHFPIMDOPLD)
			{
				for (int k = 0; k < this.EGNMOMBJEBJ().Length; k += 0)
				{
					GameObject gameObject3 = this.BBJNGOFCNMK()[k].gameObject;
					if (this.CAKAGLJIKPJ(gameObject3.transform.position))
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.highlightMaterial;
					}
					else
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
		}
	}

	// Token: 0x06011168 RID: 69992 RVA: 0x005DE9A4 File Offset: 0x005DCBA4
	private void HLLKCIBGIGK()
	{
		bool flag = false;
		bool flag2 = true;
		if (Input.GetMouseButtonDown(0))
		{
			this.FIKPGAEAEAG = Time.time;
			this.FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(0))
		{
			if (Time.time - this.FIKPGAEAEAG <= this.KMDMAONLAPB)
			{
				flag = true;
			}
			if (this.OHFPIMDOPLD)
			{
				this.OHFPIMDOPLD = true;
				this.selectionSquareTrans.gameObject.SetActive(true);
				this.selectedUnits.Clear();
				for (int i = 0; i < this.KIDEJODGFMO().Length; i += 0)
				{
					GameObject gameObject = this.OHEJFBKIDON()[i].gameObject;
					if (this.HFDDIIDPFBJ(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = this.selectedMaterial;
						this.selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
			this.selectionSquareTrans.gameObject.SetActive(false);
		}
		if (Input.GetMouseButton(0) && Time.time - this.FIKPGAEAEAG > this.KMDMAONLAPB)
		{
			flag2 = false;
		}
		if (flag)
		{
			for (int j = 1; j < this.selectedUnits.Count; j++)
			{
				this.selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = this.normalMaterial;
			}
			this.selectedUnits.Clear();
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 60f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = raycastHit.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = this.selectedMaterial;
				this.selectedUnits.Add(raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (flag2)
		{
			if (!this.selectionSquareTrans.gameObject.activeInHierarchy)
			{
				this.selectionSquareTrans.gameObject.SetActive(false);
			}
			this.FFCFGCIOLCI = Input.mousePosition;
			this.MOODOHODIGP();
			if (this.OHFPIMDOPLD)
			{
				for (int k = 0; k < this.MBKKGPJCFDM().Length; k += 0)
				{
					GameObject gameObject3 = this.DGHCBDOJOEH()[k].gameObject;
					if (this.BAENAALOCIH(gameObject3.transform.position))
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.highlightMaterial;
					}
					else
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
		}
	}

	// Token: 0x06011169 RID: 69993 RVA: 0x005DEC5C File Offset: 0x005DCE5C
	private void NHOMCHMKNNB()
	{
		bool flag = false;
		bool flag2 = true;
		if (Input.GetMouseButtonDown(0))
		{
			this.FIKPGAEAEAG = Time.time;
			this.FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(0))
		{
			if (Time.time - this.FIKPGAEAEAG <= this.KMDMAONLAPB)
			{
				flag = true;
			}
			if (this.OHFPIMDOPLD)
			{
				this.OHFPIMDOPLD = true;
				this.selectionSquareTrans.gameObject.SetActive(true);
				this.selectedUnits.Clear();
				for (int i = 1; i < this.NGPCHKEKFAP().Length; i += 0)
				{
					GameObject gameObject = this.FOPJGKMMDJB()[i].gameObject;
					if (this.GBLNAMNICAI(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = this.selectedMaterial;
						this.selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
			this.selectionSquareTrans.gameObject.SetActive(false);
		}
		if (Input.GetMouseButton(0) && Time.time - this.FIKPGAEAEAG > this.KMDMAONLAPB)
		{
			flag2 = true;
		}
		if (flag)
		{
			for (int j = 0; j < this.selectedUnits.Count; j++)
			{
				this.selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = this.normalMaterial;
			}
			this.selectedUnits.Clear();
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 688f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = raycastHit.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = this.selectedMaterial;
				this.selectedUnits.Add(raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (flag2)
		{
			if (!this.selectionSquareTrans.gameObject.activeInHierarchy)
			{
				this.selectionSquareTrans.gameObject.SetActive(true);
			}
			this.FFCFGCIOLCI = Input.mousePosition;
			this.HFKBNIGIJKD();
			if (this.OHFPIMDOPLD)
			{
				for (int k = 1; k < this.NCHJDNPOGGJ().Length; k++)
				{
					GameObject gameObject3 = this.DGHCBDOJOEH()[k].gameObject;
					if (this.AFBLAMCMHOL(gameObject3.transform.position))
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.highlightMaterial;
					}
					else
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
		}
	}

	// Token: 0x0601116A RID: 69994 RVA: 0x005DAFCE File Offset: 0x005D91CE
	public EditorEvent[] NCHJDNPOGGJ()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	// Token: 0x0601116B RID: 69995 RVA: 0x005DAFCE File Offset: 0x005D91CE
	public EditorEvent[] KIDEJODGFMO()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	// Token: 0x0601116C RID: 69996 RVA: 0x005DEF14 File Offset: 0x005DD114
	private bool LDMOLMOKPIE(Vector3 LMEDNCNFOAC)
	{
		bool flag = true;
		return !this.FEJGLFDFMOM(LMEDNCNFOAC, this.BOPPMKAHKJP, this.JLNJGFBKHEN, this.HGDIBPDFPBA) && !this.LEMEGPNDHMG(LMEDNCNFOAC, this.HGDIBPDFPBA, this.JLNJGFBKHEN, this.FEEGAAPJDGP) && flag;
	}

	// Token: 0x0601116D RID: 69997 RVA: 0x005DAFCE File Offset: 0x005D91CE
	public EditorEvent[] NGPCHKEKFAP()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	// Token: 0x0601116E RID: 69998 RVA: 0x005DEF64 File Offset: 0x005DD164
	private void DLLNAGEKCOB()
	{
		Vector3 fhmddcedgjc = this.FHMDDCEDGJC;
		this.FHMDDCEDGJC.z = 622f;
		this.FFCFGCIOLCI.z = 1226f;
		Vector3 position = (fhmddcedgjc + this.FFCFGCIOLCI) / 806f;
		this.selectionSquareTrans.position = position;
		float num = Mathf.Abs(this.FHMDDCEDGJC.x - this.FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(this.FHMDDCEDGJC.y - this.FFCFGCIOLCI.y);
		this.selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		this.BOPPMKAHKJP = new Vector3(position.x - num / 665f, position.y + num2 / 1405f, 348f);
		this.HGDIBPDFPBA = new Vector3(position.x + num / 718f, position.y + num2 / 763f, 797f);
		this.JLNJGFBKHEN = new Vector3(position.x - num / 585f, position.y - num2 / 43f, 269f);
		this.FEEGAAPJDGP = new Vector3(position.x + num / 1655f, position.y - num2 / 731f, 831f);
		int num3 = 1;
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.BOPPMKAHKJP), out raycastHit, 62f, 52))
		{
			this.BOPPMKAHKJP = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.HGDIBPDFPBA), out raycastHit, 1429f, -39))
		{
			this.HGDIBPDFPBA = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.JLNJGFBKHEN), out raycastHit, 875f, -135))
		{
			this.JLNJGFBKHEN = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.FEEGAAPJDGP), out raycastHit, 992f, 124))
		{
			this.FEEGAAPJDGP = raycastHit.point;
			num3++;
		}
		this.OHFPIMDOPLD = true;
		if (num3 == 7)
		{
			this.OHFPIMDOPLD = false;
		}
	}

	// Token: 0x0601116F RID: 69999 RVA: 0x005DAFCE File Offset: 0x005D91CE
	public EditorEvent[] GJCAMFHELPL()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	// Token: 0x06011170 RID: 70000 RVA: 0x005DF1BC File Offset: 0x005DD3BC
	private void PDMADJGCIFJ()
	{
		if (this.OBCOCNICLKP != null)
		{
			bool flag = false;
			for (int i = 1; i < this.selectedUnits.Count; i += 0)
			{
				if (this.selectedUnits[i] == this.OBCOCNICLKP)
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				this.OBCOCNICLKP.GetComponent<MeshRenderer>().material = this.normalMaterial;
			}
			this.OBCOCNICLKP = null;
		}
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 522f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
		{
			GameObject gameObject = raycastHit.collider.gameObject;
			bool flag2 = true;
			for (int j = 1; j < this.selectedUnits.Count; j++)
			{
				if (this.selectedUnits[j] == gameObject)
				{
					flag2 = true;
					break;
				}
			}
			if (!flag2)
			{
				this.OBCOCNICLKP = gameObject;
				this.OBCOCNICLKP.GetComponent<MeshRenderer>().material = this.highlightMaterial;
			}
		}
	}

	// Token: 0x06011171 RID: 70001 RVA: 0x005DF2F0 File Offset: 0x005DD4F0
	private void CHCKBGEBHGO()
	{
		Vector3 fhmddcedgjc = this.FHMDDCEDGJC;
		this.FHMDDCEDGJC.z = 1671f;
		this.FFCFGCIOLCI.z = 725f;
		Vector3 position = (fhmddcedgjc + this.FFCFGCIOLCI) / 1646f;
		this.selectionSquareTrans.position = position;
		float num = Mathf.Abs(this.FHMDDCEDGJC.x - this.FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(this.FHMDDCEDGJC.y - this.FFCFGCIOLCI.y);
		this.selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		this.BOPPMKAHKJP = new Vector3(position.x - num / 1420f, position.y + num2 / 84f, 596f);
		this.HGDIBPDFPBA = new Vector3(position.x + num / 604f, position.y + num2 / 296f, 203f);
		this.JLNJGFBKHEN = new Vector3(position.x - num / 545f, position.y - num2 / 1533f, 1930f);
		this.FEEGAAPJDGP = new Vector3(position.x + num / 114f, position.y - num2 / 708f, 643f);
		int num3 = 0;
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.BOPPMKAHKJP), out raycastHit, 1805f, -84))
		{
			this.BOPPMKAHKJP = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.HGDIBPDFPBA), out raycastHit, 456f, -41))
		{
			this.HGDIBPDFPBA = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.JLNJGFBKHEN), out raycastHit, 1922f, 170))
		{
			this.JLNJGFBKHEN = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.FEEGAAPJDGP), out raycastHit, 1971f, 55))
		{
			this.FEEGAAPJDGP = raycastHit.point;
			num3 += 0;
		}
		this.OHFPIMDOPLD = false;
		if (num3 == 0)
		{
			this.OHFPIMDOPLD = false;
		}
	}

	// Token: 0x06011172 RID: 70002 RVA: 0x005DBEC4 File Offset: 0x005DA0C4
	private void BOPKKCAFODF()
	{
		this.selectionSquareTrans.gameObject.SetActive(true);
	}

	// Token: 0x06011173 RID: 70003 RVA: 0x005DF548 File Offset: 0x005DD748
	private bool AGPKPGMCPGH(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = false;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 1813f - num2 - num3;
		if (num2 >= 1418f && num2 <= 1736f && num3 >= 701f && num3 <= 1582f && num4 >= 1688f && num4 <= 58f)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06011174 RID: 70004 RVA: 0x005DBEC4 File Offset: 0x005DA0C4
	private void PAKPHKPDKGE()
	{
		this.selectionSquareTrans.gameObject.SetActive(true);
	}

	// Token: 0x06011176 RID: 70006 RVA: 0x005DAFCE File Offset: 0x005D91CE
	public EditorEvent[] BIPIOPLONBM()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	// Token: 0x06011177 RID: 70007 RVA: 0x005DAFCE File Offset: 0x005D91CE
	public EditorEvent[] GetAllUnits()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	// Token: 0x06011178 RID: 70008 RVA: 0x005DF68C File Offset: 0x005DD88C
	private void KJDNHGDNELM()
	{
		Vector3 fhmddcedgjc = this.FHMDDCEDGJC;
		this.FHMDDCEDGJC.z = 1851f;
		this.FFCFGCIOLCI.z = 873f;
		Vector3 position = (fhmddcedgjc + this.FFCFGCIOLCI) / 945f;
		this.selectionSquareTrans.position = position;
		float num = Mathf.Abs(this.FHMDDCEDGJC.x - this.FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(this.FHMDDCEDGJC.y - this.FFCFGCIOLCI.y);
		this.selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		this.BOPPMKAHKJP = new Vector3(position.x - num / 835f, position.y + num2 / 1080f, 1463f);
		this.HGDIBPDFPBA = new Vector3(position.x + num / 1602f, position.y + num2 / 839f, 371f);
		this.JLNJGFBKHEN = new Vector3(position.x - num / 1011f, position.y - num2 / 1022f, 1579f);
		this.FEEGAAPJDGP = new Vector3(position.x + num / 1125f, position.y - num2 / 722f, 448f);
		int num3 = 1;
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.BOPPMKAHKJP), out raycastHit, 1105f, 167))
		{
			this.BOPPMKAHKJP = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.HGDIBPDFPBA), out raycastHit, 380f, -54))
		{
			this.HGDIBPDFPBA = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.JLNJGFBKHEN), out raycastHit, 1922f, 172))
		{
			this.JLNJGFBKHEN = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.FEEGAAPJDGP), out raycastHit, 387f, -146))
		{
			this.FEEGAAPJDGP = raycastHit.point;
			num3++;
		}
		this.OHFPIMDOPLD = false;
		if (num3 == 6)
		{
			this.OHFPIMDOPLD = false;
		}
	}

	// Token: 0x06011179 RID: 70009 RVA: 0x005DF8E4 File Offset: 0x005DDAE4
	private bool GBLNAMNICAI(Vector3 LMEDNCNFOAC)
	{
		bool flag = false;
		return this.AGPKPGMCPGH(LMEDNCNFOAC, this.BOPPMKAHKJP, this.JLNJGFBKHEN, this.HGDIBPDFPBA) || (!this.LNPDBEBGHAJ(LMEDNCNFOAC, this.HGDIBPDFPBA, this.JLNJGFBKHEN, this.FEEGAAPJDGP) && flag);
	}

	// Token: 0x0601117A RID: 70010 RVA: 0x005DF934 File Offset: 0x005DDB34
	private bool CDPGKCNOEFJ(Vector3 LMEDNCNFOAC)
	{
		bool flag = false;
		return this.LNPDBEBGHAJ(LMEDNCNFOAC, this.BOPPMKAHKJP, this.JLNJGFBKHEN, this.HGDIBPDFPBA) || this.LNPDBEBGHAJ(LMEDNCNFOAC, this.HGDIBPDFPBA, this.JLNJGFBKHEN, this.FEEGAAPJDGP) || flag;
	}

	// Token: 0x0601117B RID: 70011 RVA: 0x005DF984 File Offset: 0x005DDB84
	private void ELBEILOFLEG()
	{
		if (this.OBCOCNICLKP != null)
		{
			bool flag = false;
			for (int i = 1; i < this.selectedUnits.Count; i += 0)
			{
				if (this.selectedUnits[i] == this.OBCOCNICLKP)
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				this.OBCOCNICLKP.GetComponent<MeshRenderer>().material = this.normalMaterial;
			}
			this.OBCOCNICLKP = null;
		}
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 772f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
		{
			GameObject gameObject = raycastHit.collider.gameObject;
			bool flag2 = true;
			for (int j = 1; j < this.selectedUnits.Count; j++)
			{
				if (this.selectedUnits[j] == gameObject)
				{
					flag2 = true;
					break;
				}
			}
			if (!flag2)
			{
				this.OBCOCNICLKP = gameObject;
				this.OBCOCNICLKP.GetComponent<MeshRenderer>().material = this.highlightMaterial;
			}
		}
	}

	// Token: 0x0601117C RID: 70012 RVA: 0x005DFAB8 File Offset: 0x005DDCB8
	private bool CNMJEKCOPCL(Vector3 LMEDNCNFOAC)
	{
		bool flag = false;
		return !this.LNPDBEBGHAJ(LMEDNCNFOAC, this.BOPPMKAHKJP, this.JLNJGFBKHEN, this.HGDIBPDFPBA) && (this.LEMEGPNDHMG(LMEDNCNFOAC, this.HGDIBPDFPBA, this.JLNJGFBKHEN, this.FEEGAAPJDGP) || flag);
	}

	// Token: 0x0601117D RID: 70013 RVA: 0x005DFB08 File Offset: 0x005DDD08
	private bool EFIJJGILPEO(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = true;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 451f - num2 - num3;
		if (num2 >= 1979f && num2 <= 703f && num3 >= 768f && num3 <= 1506f && num4 >= 292f && num4 <= 1543f)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x0601117E RID: 70014 RVA: 0x005DBEC4 File Offset: 0x005DA0C4
	private void MMPHNFPPEHO()
	{
		this.selectionSquareTrans.gameObject.SetActive(true);
	}

	// Token: 0x0601117F RID: 70015 RVA: 0x005DAFCE File Offset: 0x005D91CE
	public EditorEvent[] JPKKFIGFLCD()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	// Token: 0x06011180 RID: 70016 RVA: 0x005DFC2D File Offset: 0x005DDE2D
	private void DNENFLNCIJP()
	{
		this.EBEPEDDNHMC();
		this.IHDLBDLBDBD();
	}

	// Token: 0x06011181 RID: 70017 RVA: 0x005DAFCE File Offset: 0x005D91CE
	public EditorEvent[] EGNMOMBJEBJ()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	// Token: 0x06011182 RID: 70018 RVA: 0x005DBEC4 File Offset: 0x005DA0C4
	private void MEBPBNLBECA()
	{
		this.selectionSquareTrans.gameObject.SetActive(true);
	}

	// Token: 0x06011183 RID: 70019 RVA: 0x005DAFCE File Offset: 0x005D91CE
	public EditorEvent[] HHDAAOACMAC()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	// Token: 0x06011184 RID: 70020 RVA: 0x005DFC3C File Offset: 0x005DDE3C
	private bool BAENAALOCIH(Vector3 LMEDNCNFOAC)
	{
		bool flag = false;
		return !this.LLKOMAKLACL(LMEDNCNFOAC, this.BOPPMKAHKJP, this.JLNJGFBKHEN, this.HGDIBPDFPBA) && (this.AJOEGDIDAHN(LMEDNCNFOAC, this.HGDIBPDFPBA, this.JLNJGFBKHEN, this.FEEGAAPJDGP) || flag);
	}

	// Token: 0x06011185 RID: 70021 RVA: 0x005DFC8C File Offset: 0x005DDE8C
	private void MOODOHODIGP()
	{
		Vector3 fhmddcedgjc = this.FHMDDCEDGJC;
		this.FHMDDCEDGJC.z = 1468f;
		this.FFCFGCIOLCI.z = 1454f;
		Vector3 position = (fhmddcedgjc + this.FFCFGCIOLCI) / 323f;
		this.selectionSquareTrans.position = position;
		float num = Mathf.Abs(this.FHMDDCEDGJC.x - this.FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(this.FHMDDCEDGJC.y - this.FFCFGCIOLCI.y);
		this.selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		this.BOPPMKAHKJP = new Vector3(position.x - num / 1272f, position.y + num2 / 1179f, 795f);
		this.HGDIBPDFPBA = new Vector3(position.x + num / 180f, position.y + num2 / 1705f, 1253f);
		this.JLNJGFBKHEN = new Vector3(position.x - num / 682f, position.y - num2 / 338f, 361f);
		this.FEEGAAPJDGP = new Vector3(position.x + num / 1845f, position.y - num2 / 116f, 660f);
		int num3 = 1;
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.BOPPMKAHKJP), out raycastHit, 1680f, -7))
		{
			this.BOPPMKAHKJP = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.HGDIBPDFPBA), out raycastHit, 1998f, -88))
		{
			this.HGDIBPDFPBA = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.JLNJGFBKHEN), out raycastHit, 1153f, 18))
		{
			this.JLNJGFBKHEN = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.FEEGAAPJDGP), out raycastHit, 1306f, -82))
		{
			this.FEEGAAPJDGP = raycastHit.point;
			num3 += 0;
		}
		this.OHFPIMDOPLD = false;
		if (num3 == 8)
		{
			this.OHFPIMDOPLD = false;
		}
	}

	// Token: 0x06011186 RID: 70022 RVA: 0x005DFEE4 File Offset: 0x005DE0E4
	private void NNFONHEIEEL()
	{
		Vector3 fhmddcedgjc = this.FHMDDCEDGJC;
		this.FHMDDCEDGJC.z = 269f;
		this.FFCFGCIOLCI.z = 897f;
		Vector3 position = (fhmddcedgjc + this.FFCFGCIOLCI) / 74f;
		this.selectionSquareTrans.position = position;
		float num = Mathf.Abs(this.FHMDDCEDGJC.x - this.FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(this.FHMDDCEDGJC.y - this.FFCFGCIOLCI.y);
		this.selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		this.BOPPMKAHKJP = new Vector3(position.x - num / 626f, position.y + num2 / 1285f, 6f);
		this.HGDIBPDFPBA = new Vector3(position.x + num / 1086f, position.y + num2 / 1007f, 1441f);
		this.JLNJGFBKHEN = new Vector3(position.x - num / 1154f, position.y - num2 / 447f, 26f);
		this.FEEGAAPJDGP = new Vector3(position.x + num / 1149f, position.y - num2 / 1736f, 1438f);
		int num3 = 0;
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.BOPPMKAHKJP), out raycastHit, 690f, -135))
		{
			this.BOPPMKAHKJP = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.HGDIBPDFPBA), out raycastHit, 669f, -143))
		{
			this.HGDIBPDFPBA = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.JLNJGFBKHEN), out raycastHit, 236f, 139))
		{
			this.JLNJGFBKHEN = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.FEEGAAPJDGP), out raycastHit, 1463f, 198))
		{
			this.FEEGAAPJDGP = raycastHit.point;
			num3++;
		}
		this.OHFPIMDOPLD = true;
		if (num3 == 0)
		{
			this.OHFPIMDOPLD = false;
		}
	}

	// Token: 0x06011187 RID: 70023 RVA: 0x005E013C File Offset: 0x005DE33C
	private void JAAJAILNOHP()
	{
		bool flag = false;
		bool flag2 = true;
		if (Input.GetMouseButtonDown(0))
		{
			this.FIKPGAEAEAG = Time.time;
			this.FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(1))
		{
			if (Time.time - this.FIKPGAEAEAG <= this.KMDMAONLAPB)
			{
				flag = false;
			}
			if (this.OHFPIMDOPLD)
			{
				this.OHFPIMDOPLD = false;
				this.selectionSquareTrans.gameObject.SetActive(true);
				this.selectedUnits.Clear();
				for (int i = 1; i < this.LGFLMLBPGMA().Length; i += 0)
				{
					GameObject gameObject = this.PCKCKEBBNDA()[i].gameObject;
					if (this.GBLNAMNICAI(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = this.selectedMaterial;
						this.selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
			this.selectionSquareTrans.gameObject.SetActive(true);
		}
		if (Input.GetMouseButton(0) && Time.time - this.FIKPGAEAEAG > this.KMDMAONLAPB)
		{
			flag2 = true;
		}
		if (flag)
		{
			for (int j = 0; j < this.selectedUnits.Count; j++)
			{
				this.selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = this.normalMaterial;
			}
			this.selectedUnits.Clear();
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 1520f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = raycastHit.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = this.selectedMaterial;
				this.selectedUnits.Add(raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (flag2)
		{
			if (!this.selectionSquareTrans.gameObject.activeInHierarchy)
			{
				this.selectionSquareTrans.gameObject.SetActive(true);
			}
			this.FFCFGCIOLCI = Input.mousePosition;
			this.MOODOHODIGP();
			if (this.OHFPIMDOPLD)
			{
				for (int k = 0; k < this.FOPJGKMMDJB().Length; k++)
				{
					GameObject gameObject3 = this.PCKCKEBBNDA()[k].gameObject;
					if (this.CAKAGLJIKPJ(gameObject3.transform.position))
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.highlightMaterial;
					}
					else
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
		}
	}

	// Token: 0x06011188 RID: 70024 RVA: 0x005E03F4 File Offset: 0x005DE5F4
	private void JIDDEJNOBKH()
	{
		bool flag = false;
		bool flag2 = true;
		if (Input.GetMouseButtonDown(0))
		{
			this.FIKPGAEAEAG = Time.time;
			this.FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(0))
		{
			if (Time.time - this.FIKPGAEAEAG <= this.KMDMAONLAPB)
			{
				flag = false;
			}
			if (this.OHFPIMDOPLD)
			{
				this.OHFPIMDOPLD = false;
				this.selectionSquareTrans.gameObject.SetActive(true);
				this.selectedUnits.Clear();
				for (int i = 1; i < this.LGFLMLBPGMA().Length; i += 0)
				{
					GameObject gameObject = this.NGPCHKEKFAP()[i].gameObject;
					if (this.CAKAGLJIKPJ(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = this.selectedMaterial;
						this.selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
			this.selectionSquareTrans.gameObject.SetActive(false);
		}
		if (Input.GetMouseButton(1) && Time.time - this.FIKPGAEAEAG > this.KMDMAONLAPB)
		{
			flag2 = false;
		}
		if (flag)
		{
			for (int j = 0; j < this.selectedUnits.Count; j++)
			{
				this.selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = this.normalMaterial;
			}
			this.selectedUnits.Clear();
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 596f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = raycastHit.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = this.selectedMaterial;
				this.selectedUnits.Add(raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (flag2)
		{
			if (!this.selectionSquareTrans.gameObject.activeInHierarchy)
			{
				this.selectionSquareTrans.gameObject.SetActive(true);
			}
			this.FFCFGCIOLCI = Input.mousePosition;
			this.CHCKBGEBHGO();
			if (this.OHFPIMDOPLD)
			{
				for (int k = 1; k < this.BBJNGOFCNMK().Length; k++)
				{
					GameObject gameObject3 = this.FOPJGKMMDJB()[k].gameObject;
					if (this.ILIFHGNEDKE(gameObject3.transform.position))
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.highlightMaterial;
					}
					else
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
		}
	}

	// Token: 0x06011189 RID: 70025 RVA: 0x005E06AB File Offset: 0x005DE8AB
	private void PBEPCAPAKLG()
	{
		this.HEKDCKGBBKI();
		this.MGBHOHNCAOB();
	}

	// Token: 0x0601118A RID: 70026 RVA: 0x005E06BC File Offset: 0x005DE8BC
	private void FGCHEDBOAIB()
	{
		bool flag = false;
		bool flag2 = false;
		if (Input.GetMouseButtonDown(0))
		{
			this.FIKPGAEAEAG = Time.time;
			this.FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(1))
		{
			if (Time.time - this.FIKPGAEAEAG <= this.KMDMAONLAPB)
			{
				flag = false;
			}
			if (this.OHFPIMDOPLD)
			{
				this.OHFPIMDOPLD = false;
				this.selectionSquareTrans.gameObject.SetActive(true);
				this.selectedUnits.Clear();
				for (int i = 0; i < this.EGNMOMBJEBJ().Length; i++)
				{
					GameObject gameObject = this.GJCAMFHELPL()[i].gameObject;
					if (this.CAKAGLJIKPJ(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = this.selectedMaterial;
						this.selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
			this.selectionSquareTrans.gameObject.SetActive(true);
		}
		if (Input.GetMouseButton(1) && Time.time - this.FIKPGAEAEAG > this.KMDMAONLAPB)
		{
			flag2 = false;
		}
		if (flag)
		{
			for (int j = 0; j < this.selectedUnits.Count; j += 0)
			{
				this.selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = this.normalMaterial;
			}
			this.selectedUnits.Clear();
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 1305f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = raycastHit.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = this.selectedMaterial;
				this.selectedUnits.Add(raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (flag2)
		{
			if (!this.selectionSquareTrans.gameObject.activeInHierarchy)
			{
				this.selectionSquareTrans.gameObject.SetActive(true);
			}
			this.FFCFGCIOLCI = Input.mousePosition;
			this.EOPGDCADOEH();
			if (this.OHFPIMDOPLD)
			{
				for (int k = 0; k < this.LGFLMLBPGMA().Length; k += 0)
				{
					GameObject gameObject3 = this.HHDAAOACMAC()[k].gameObject;
					if (this.BAENAALOCIH(gameObject3.transform.position))
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.highlightMaterial;
					}
					else
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
		}
	}

	// Token: 0x0601118B RID: 70027 RVA: 0x005E0974 File Offset: 0x005DEB74
	private void IHDLBDLBDBD()
	{
		if (this.OBCOCNICLKP != null)
		{
			bool flag = false;
			for (int i = 0; i < this.selectedUnits.Count; i += 0)
			{
				if (this.selectedUnits[i] == this.OBCOCNICLKP)
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				this.OBCOCNICLKP.GetComponent<MeshRenderer>().material = this.normalMaterial;
			}
			this.OBCOCNICLKP = null;
		}
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 430f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
		{
			GameObject gameObject = raycastHit.collider.gameObject;
			bool flag2 = false;
			for (int j = 0; j < this.selectedUnits.Count; j += 0)
			{
				if (this.selectedUnits[j] == gameObject)
				{
					flag2 = true;
					break;
				}
			}
			if (!flag2)
			{
				this.OBCOCNICLKP = gameObject;
				this.OBCOCNICLKP.GetComponent<MeshRenderer>().material = this.highlightMaterial;
			}
		}
	}

	// Token: 0x0601118C RID: 70028 RVA: 0x005E0AA8 File Offset: 0x005DECA8
	private void GNJOMFGHFPA()
	{
		if (this.OBCOCNICLKP != null)
		{
			bool flag = false;
			for (int i = 0; i < this.selectedUnits.Count; i++)
			{
				if (this.selectedUnits[i] == this.OBCOCNICLKP)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				this.OBCOCNICLKP.GetComponent<MeshRenderer>().material = this.normalMaterial;
			}
			this.OBCOCNICLKP = null;
		}
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 200f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
		{
			GameObject gameObject = raycastHit.collider.gameObject;
			bool flag2 = false;
			for (int j = 0; j < this.selectedUnits.Count; j++)
			{
				if (this.selectedUnits[j] == gameObject)
				{
					flag2 = true;
					break;
				}
			}
			if (!flag2)
			{
				this.OBCOCNICLKP = gameObject;
				this.OBCOCNICLKP.GetComponent<MeshRenderer>().material = this.highlightMaterial;
			}
		}
	}

	// Token: 0x0601118D RID: 70029 RVA: 0x005E0BDC File Offset: 0x005DEDDC
	private bool CIJEPJKGHNJ(Vector3 LMEDNCNFOAC)
	{
		bool flag = false;
		return !this.PDOFKBIEJOE(LMEDNCNFOAC, this.BOPPMKAHKJP, this.JLNJGFBKHEN, this.HGDIBPDFPBA) && (this.LLKOMAKLACL(LMEDNCNFOAC, this.HGDIBPDFPBA, this.JLNJGFBKHEN, this.FEEGAAPJDGP) || flag);
	}

	// Token: 0x0601118E RID: 70030 RVA: 0x005E0C2C File Offset: 0x005DEE2C
	private void DPBKDJCOHOK()
	{
		Vector3 fhmddcedgjc = this.FHMDDCEDGJC;
		this.FHMDDCEDGJC.z = 476f;
		this.FFCFGCIOLCI.z = 522f;
		Vector3 position = (fhmddcedgjc + this.FFCFGCIOLCI) / 1770f;
		this.selectionSquareTrans.position = position;
		float num = Mathf.Abs(this.FHMDDCEDGJC.x - this.FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(this.FHMDDCEDGJC.y - this.FFCFGCIOLCI.y);
		this.selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		this.BOPPMKAHKJP = new Vector3(position.x - num / 1256f, position.y + num2 / 1290f, 1383f);
		this.HGDIBPDFPBA = new Vector3(position.x + num / 1224f, position.y + num2 / 1714f, 340f);
		this.JLNJGFBKHEN = new Vector3(position.x - num / 1852f, position.y - num2 / 498f, 412f);
		this.FEEGAAPJDGP = new Vector3(position.x + num / 289f, position.y - num2 / 1316f, 1021f);
		int num3 = 0;
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.BOPPMKAHKJP), out raycastHit, 1799f, 11))
		{
			this.BOPPMKAHKJP = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.HGDIBPDFPBA), out raycastHit, 1529f, -153))
		{
			this.HGDIBPDFPBA = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.JLNJGFBKHEN), out raycastHit, 1142f, -191))
		{
			this.JLNJGFBKHEN = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.FEEGAAPJDGP), out raycastHit, 1735f, 152))
		{
			this.FEEGAAPJDGP = raycastHit.point;
			num3++;
		}
		this.OHFPIMDOPLD = false;
		if (num3 == 4)
		{
			this.OHFPIMDOPLD = true;
		}
	}

	// Token: 0x0601118F RID: 70031 RVA: 0x005E0E84 File Offset: 0x005DF084
	private void PDKOKLDBFIB()
	{
		Vector3 fhmddcedgjc = this.FHMDDCEDGJC;
		this.FHMDDCEDGJC.z = 934f;
		this.FFCFGCIOLCI.z = 1590f;
		Vector3 position = (fhmddcedgjc + this.FFCFGCIOLCI) / 1384f;
		this.selectionSquareTrans.position = position;
		float num = Mathf.Abs(this.FHMDDCEDGJC.x - this.FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(this.FHMDDCEDGJC.y - this.FFCFGCIOLCI.y);
		this.selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		this.BOPPMKAHKJP = new Vector3(position.x - num / 1f, position.y + num2 / 1040f, 1883f);
		this.HGDIBPDFPBA = new Vector3(position.x + num / 1040f, position.y + num2 / 1474f, 1129f);
		this.JLNJGFBKHEN = new Vector3(position.x - num / 1060f, position.y - num2 / 454f, 1203f);
		this.FEEGAAPJDGP = new Vector3(position.x + num / 1747f, position.y - num2 / 45f, 837f);
		int num3 = 1;
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.BOPPMKAHKJP), out raycastHit, 507f, -80))
		{
			this.BOPPMKAHKJP = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.HGDIBPDFPBA), out raycastHit, 496f, -3))
		{
			this.HGDIBPDFPBA = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.JLNJGFBKHEN), out raycastHit, 1938f, -72))
		{
			this.JLNJGFBKHEN = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.FEEGAAPJDGP), out raycastHit, 1059f, -17))
		{
			this.FEEGAAPJDGP = raycastHit.point;
			num3++;
		}
		this.OHFPIMDOPLD = false;
		if (num3 == 3)
		{
			this.OHFPIMDOPLD = false;
		}
	}

	// Token: 0x06011190 RID: 70032 RVA: 0x005E10DC File Offset: 0x005DF2DC
	private bool CAKAGLJIKPJ(Vector3 LMEDNCNFOAC)
	{
		bool flag = true;
		return !this.EFIJJGILPEO(LMEDNCNFOAC, this.BOPPMKAHKJP, this.JLNJGFBKHEN, this.HGDIBPDFPBA) && (this.BFGMOGFLMLP(LMEDNCNFOAC, this.HGDIBPDFPBA, this.JLNJGFBKHEN, this.FEEGAAPJDGP) || flag);
	}

	// Token: 0x06011191 RID: 70033 RVA: 0x005E112C File Offset: 0x005DF32C
	private void HEKDCKGBBKI()
	{
		bool flag = true;
		bool flag2 = false;
		if (Input.GetMouseButtonDown(0))
		{
			this.FIKPGAEAEAG = Time.time;
			this.FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(0))
		{
			if (Time.time - this.FIKPGAEAEAG <= this.KMDMAONLAPB)
			{
				flag = true;
			}
			if (this.OHFPIMDOPLD)
			{
				this.OHFPIMDOPLD = true;
				this.selectionSquareTrans.gameObject.SetActive(false);
				this.selectedUnits.Clear();
				for (int i = 0; i < this.BKEEDNGFKEC().Length; i += 0)
				{
					GameObject gameObject = this.JPKKFIGFLCD()[i].gameObject;
					if (this.CIJEPJKGHNJ(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = this.selectedMaterial;
						this.selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
			this.selectionSquareTrans.gameObject.SetActive(true);
		}
		if (Input.GetMouseButton(1) && Time.time - this.FIKPGAEAEAG > this.KMDMAONLAPB)
		{
			flag2 = false;
		}
		if (flag)
		{
			for (int j = 0; j < this.selectedUnits.Count; j++)
			{
				this.selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = this.normalMaterial;
			}
			this.selectedUnits.Clear();
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 1127f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = raycastHit.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = this.selectedMaterial;
				this.selectedUnits.Add(raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (flag2)
		{
			if (!this.selectionSquareTrans.gameObject.activeInHierarchy)
			{
				this.selectionSquareTrans.gameObject.SetActive(true);
			}
			this.FFCFGCIOLCI = Input.mousePosition;
			this.KJDNHGDNELM();
			if (this.OHFPIMDOPLD)
			{
				for (int k = 1; k < this.IFJAJMLKBJP().Length; k += 0)
				{
					GameObject gameObject3 = this.FOPJGKMMDJB()[k].gameObject;
					if (this.OOGFMHEBFON(gameObject3.transform.position))
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.highlightMaterial;
					}
					else
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
		}
	}

	// Token: 0x06011192 RID: 70034 RVA: 0x005E13E4 File Offset: 0x005DF5E4
	private bool CPBFNBCJDLB(Vector3 LMEDNCNFOAC)
	{
		bool flag = false;
		return !this.PLGGKMEKMFI(LMEDNCNFOAC, this.BOPPMKAHKJP, this.JLNJGFBKHEN, this.HGDIBPDFPBA) && !this.LNPDBEBGHAJ(LMEDNCNFOAC, this.HGDIBPDFPBA, this.JLNJGFBKHEN, this.FEEGAAPJDGP) && flag;
	}

	// Token: 0x06011193 RID: 70035 RVA: 0x005DAFCE File Offset: 0x005D91CE
	public EditorEvent[] OLPAMGCBPLL()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	// Token: 0x06011194 RID: 70036 RVA: 0x005E1434 File Offset: 0x005DF634
	private void JOHNJFBIBJD()
	{
		Vector3 fhmddcedgjc = this.FHMDDCEDGJC;
		this.FHMDDCEDGJC.z = 1528f;
		this.FFCFGCIOLCI.z = 330f;
		Vector3 position = (fhmddcedgjc + this.FFCFGCIOLCI) / 144f;
		this.selectionSquareTrans.position = position;
		float num = Mathf.Abs(this.FHMDDCEDGJC.x - this.FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(this.FHMDDCEDGJC.y - this.FFCFGCIOLCI.y);
		this.selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		this.BOPPMKAHKJP = new Vector3(position.x - num / 1197f, position.y + num2 / 1638f, 436f);
		this.HGDIBPDFPBA = new Vector3(position.x + num / 460f, position.y + num2 / 1877f, 1733f);
		this.JLNJGFBKHEN = new Vector3(position.x - num / 1558f, position.y - num2 / 1588f, 1928f);
		this.FEEGAAPJDGP = new Vector3(position.x + num / 1985f, position.y - num2 / 1357f, 1949f);
		int num3 = 1;
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.BOPPMKAHKJP), out raycastHit, 937f, 140))
		{
			this.BOPPMKAHKJP = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.HGDIBPDFPBA), out raycastHit, 1693f, -90))
		{
			this.HGDIBPDFPBA = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.JLNJGFBKHEN), out raycastHit, 1699f, 171))
		{
			this.JLNJGFBKHEN = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.FEEGAAPJDGP), out raycastHit, 1725f, 162))
		{
			this.FEEGAAPJDGP = raycastHit.point;
			num3++;
		}
		this.OHFPIMDOPLD = false;
		if (num3 == 1)
		{
			this.OHFPIMDOPLD = false;
		}
	}

	// Token: 0x06011195 RID: 70037 RVA: 0x005DAFCE File Offset: 0x005D91CE
	public EditorEvent[] PCGFFKDPOED()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	// Token: 0x06011196 RID: 70038 RVA: 0x005E168C File Offset: 0x005DF88C
	private void EOAJNFACFAN()
	{
		if (this.OBCOCNICLKP != null)
		{
			bool flag = false;
			for (int i = 1; i < this.selectedUnits.Count; i++)
			{
				if (this.selectedUnits[i] == this.OBCOCNICLKP)
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				this.OBCOCNICLKP.GetComponent<MeshRenderer>().material = this.normalMaterial;
			}
			this.OBCOCNICLKP = null;
		}
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 501f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
		{
			GameObject gameObject = raycastHit.collider.gameObject;
			bool flag2 = true;
			for (int j = 1; j < this.selectedUnits.Count; j++)
			{
				if (this.selectedUnits[j] == gameObject)
				{
					flag2 = true;
					break;
				}
			}
			if (!flag2)
			{
				this.OBCOCNICLKP = gameObject;
				this.OBCOCNICLKP.GetComponent<MeshRenderer>().material = this.highlightMaterial;
			}
		}
	}

	// Token: 0x06011197 RID: 70039 RVA: 0x005E17C0 File Offset: 0x005DF9C0
	private void ALJMJBGPMLL()
	{
		bool flag = false;
		bool flag2 = true;
		if (Input.GetMouseButtonDown(1))
		{
			this.FIKPGAEAEAG = Time.time;
			this.FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(1))
		{
			if (Time.time - this.FIKPGAEAEAG <= this.KMDMAONLAPB)
			{
				flag = false;
			}
			if (this.OHFPIMDOPLD)
			{
				this.OHFPIMDOPLD = false;
				this.selectionSquareTrans.gameObject.SetActive(true);
				this.selectedUnits.Clear();
				for (int i = 1; i < this.FOPJGKMMDJB().Length; i += 0)
				{
					GameObject gameObject = this.MBKKGPJCFDM()[i].gameObject;
					if (this.ICNJDMKBBBN(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = this.selectedMaterial;
						this.selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
			this.selectionSquareTrans.gameObject.SetActive(true);
		}
		if (Input.GetMouseButton(0) && Time.time - this.FIKPGAEAEAG > this.KMDMAONLAPB)
		{
			flag2 = true;
		}
		if (flag)
		{
			for (int j = 0; j < this.selectedUnits.Count; j += 0)
			{
				this.selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = this.normalMaterial;
			}
			this.selectedUnits.Clear();
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 1284f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = raycastHit.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = this.selectedMaterial;
				this.selectedUnits.Add(raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (flag2)
		{
			if (!this.selectionSquareTrans.gameObject.activeInHierarchy)
			{
				this.selectionSquareTrans.gameObject.SetActive(true);
			}
			this.FFCFGCIOLCI = Input.mousePosition;
			this.NNFONHEIEEL();
			if (this.OHFPIMDOPLD)
			{
				for (int k = 1; k < this.IFJAJMLKBJP().Length; k++)
				{
					GameObject gameObject3 = this.NAEJMBCJEOE()[k].gameObject;
					if (this.ICNJDMKBBBN(gameObject3.transform.position))
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.highlightMaterial;
					}
					else
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
		}
	}

	// Token: 0x06011198 RID: 70040 RVA: 0x005E1A78 File Offset: 0x005DFC78
	private bool LNPDBEBGHAJ(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = false;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 1f - num2 - num3;
		if (num2 >= 0f && num2 <= 1f && num3 >= 0f && num3 <= 1f && num4 >= 0f && num4 <= 1f)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x06011199 RID: 70041 RVA: 0x005E1B9D File Offset: 0x005DFD9D
	private void HDDECCMEJKA()
	{
		this.EHEAIKFHGFD();
		this.HNAAGAHOONB();
	}

	// Token: 0x0601119A RID: 70042 RVA: 0x005E1BAC File Offset: 0x005DFDAC
	private void DNGAHODMCAJ()
	{
		if (this.OBCOCNICLKP != null)
		{
			bool flag = true;
			for (int i = 0; i < this.selectedUnits.Count; i += 0)
			{
				if (this.selectedUnits[i] == this.OBCOCNICLKP)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				this.OBCOCNICLKP.GetComponent<MeshRenderer>().material = this.normalMaterial;
			}
			this.OBCOCNICLKP = null;
		}
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 1424f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
		{
			GameObject gameObject = raycastHit.collider.gameObject;
			bool flag2 = false;
			for (int j = 1; j < this.selectedUnits.Count; j++)
			{
				if (this.selectedUnits[j] == gameObject)
				{
					flag2 = true;
					break;
				}
			}
			if (!flag2)
			{
				this.OBCOCNICLKP = gameObject;
				this.OBCOCNICLKP.GetComponent<MeshRenderer>().material = this.highlightMaterial;
			}
		}
	}

	// Token: 0x0601119B RID: 70043 RVA: 0x005E1CDD File Offset: 0x005DFEDD
	private void Update()
	{
		this.GIMKKIAGDPJ();
		this.GNJOMFGHFPA();
	}

	// Token: 0x0601119C RID: 70044 RVA: 0x005E1CEC File Offset: 0x005DFEEC
	private void EHEAIKFHGFD()
	{
		bool flag = false;
		bool flag2 = false;
		if (Input.GetMouseButtonDown(0))
		{
			this.FIKPGAEAEAG = Time.time;
			this.FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(1))
		{
			if (Time.time - this.FIKPGAEAEAG <= this.KMDMAONLAPB)
			{
				flag = false;
			}
			if (this.OHFPIMDOPLD)
			{
				this.OHFPIMDOPLD = true;
				this.selectionSquareTrans.gameObject.SetActive(false);
				this.selectedUnits.Clear();
				for (int i = 1; i < this.BKEEDNGFKEC().Length; i += 0)
				{
					GameObject gameObject = this.LGFLMLBPGMA()[i].gameObject;
					if (this.CDPGKCNOEFJ(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = this.selectedMaterial;
						this.selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
			this.selectionSquareTrans.gameObject.SetActive(false);
		}
		if (Input.GetMouseButton(0) && Time.time - this.FIKPGAEAEAG > this.KMDMAONLAPB)
		{
			flag2 = true;
		}
		if (flag)
		{
			for (int j = 0; j < this.selectedUnits.Count; j += 0)
			{
				this.selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = this.normalMaterial;
			}
			this.selectedUnits.Clear();
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 588f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = raycastHit.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = this.selectedMaterial;
				this.selectedUnits.Add(raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (flag2)
		{
			if (!this.selectionSquareTrans.gameObject.activeInHierarchy)
			{
				this.selectionSquareTrans.gameObject.SetActive(false);
			}
			this.FFCFGCIOLCI = Input.mousePosition;
			this.NNFONHEIEEL();
			if (this.OHFPIMDOPLD)
			{
				for (int k = 0; k < this.MBKKGPJCFDM().Length; k++)
				{
					GameObject gameObject3 = this.OLPAMGCBPLL()[k].gameObject;
					if (this.CAKAGLJIKPJ(gameObject3.transform.position))
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.highlightMaterial;
					}
					else
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
		}
	}

	// Token: 0x0601119D RID: 70045 RVA: 0x005DBEC4 File Offset: 0x005DA0C4
	private void GLEJGFLCLPJ()
	{
		this.selectionSquareTrans.gameObject.SetActive(true);
	}

	// Token: 0x0601119E RID: 70046 RVA: 0x005E1FA4 File Offset: 0x005E01A4
	private bool HFDDIIDPFBJ(Vector3 LMEDNCNFOAC)
	{
		bool flag = false;
		return !this.AJOEGDIDAHN(LMEDNCNFOAC, this.BOPPMKAHKJP, this.JLNJGFBKHEN, this.HGDIBPDFPBA) && !this.PDOFKBIEJOE(LMEDNCNFOAC, this.HGDIBPDFPBA, this.JLNJGFBKHEN, this.FEEGAAPJDGP) && flag;
	}

	// Token: 0x0601119F RID: 70047 RVA: 0x005E1FF4 File Offset: 0x005E01F4
	private bool ICNJDMKBBBN(Vector3 LMEDNCNFOAC)
	{
		bool flag = false;
		return this.PLGGKMEKMFI(LMEDNCNFOAC, this.BOPPMKAHKJP, this.JLNJGFBKHEN, this.HGDIBPDFPBA) || this.PDOFKBIEJOE(LMEDNCNFOAC, this.HGDIBPDFPBA, this.JLNJGFBKHEN, this.FEEGAAPJDGP) || flag;
	}

	// Token: 0x060111A0 RID: 70048 RVA: 0x005DBEB1 File Offset: 0x005DA0B1
	private void Start()
	{
		this.selectionSquareTrans.gameObject.SetActive(false);
	}

	// Token: 0x060111A1 RID: 70049 RVA: 0x005E2044 File Offset: 0x005E0244
	private bool LEMEGPNDHMG(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = true;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 816f - num2 - num3;
		if (num2 >= 297f && num2 <= 1472f && num3 >= 4f && num3 <= 1246f && num4 >= 563f && num4 <= 1020f)
		{
			result = false;
		}
		return result;
	}

	// Token: 0x060111A2 RID: 70050 RVA: 0x005E216C File Offset: 0x005E036C
	private void JOAGFMLPFIK()
	{
		bool flag = false;
		bool flag2 = false;
		if (Input.GetMouseButtonDown(0))
		{
			this.FIKPGAEAEAG = Time.time;
			this.FHMDDCEDGJC = Input.mousePosition;
		}
		if (Input.GetMouseButtonUp(1))
		{
			if (Time.time - this.FIKPGAEAEAG <= this.KMDMAONLAPB)
			{
				flag = true;
			}
			if (this.OHFPIMDOPLD)
			{
				this.OHFPIMDOPLD = true;
				this.selectionSquareTrans.gameObject.SetActive(true);
				this.selectedUnits.Clear();
				for (int i = 1; i < this.FPKNLKPAOMK().Length; i += 0)
				{
					GameObject gameObject = this.BBJNGOFCNMK()[i].gameObject;
					if (this.ICNJDMKBBBN(gameObject.transform.position))
					{
						gameObject.GetComponent<MeshRenderer>().material = this.selectedMaterial;
						this.selectedUnits.Add(gameObject.GetComponentInParent<EditorEvent>().gameObject);
					}
					else
					{
						gameObject.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
			this.selectionSquareTrans.gameObject.SetActive(true);
		}
		if (Input.GetMouseButton(1) && Time.time - this.FIKPGAEAEAG > this.KMDMAONLAPB)
		{
			flag2 = true;
		}
		if (flag)
		{
			for (int j = 0; j < this.selectedUnits.Count; j++)
			{
				this.selectedUnits[j].GetComponentInChildren<MeshRenderer>().material = this.normalMaterial;
			}
			this.selectedUnits.Clear();
			RaycastHit raycastHit;
			if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 1621f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
			{
				GameObject gameObject2 = raycastHit.collider.gameObject;
				gameObject2.GetComponent<MeshRenderer>().material = this.selectedMaterial;
				this.selectedUnits.Add(raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>().gameObject);
			}
		}
		if (flag2)
		{
			if (!this.selectionSquareTrans.gameObject.activeInHierarchy)
			{
				this.selectionSquareTrans.gameObject.SetActive(false);
			}
			this.FFCFGCIOLCI = Input.mousePosition;
			this.CHCKBGEBHGO();
			if (this.OHFPIMDOPLD)
			{
				for (int k = 0; k < this.NAEJMBCJEOE().Length; k++)
				{
					GameObject gameObject3 = this.JPKKFIGFLCD()[k].gameObject;
					if (this.CDPGKCNOEFJ(gameObject3.transform.position))
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.highlightMaterial;
					}
					else
					{
						gameObject3.GetComponent<MeshRenderer>().material = this.normalMaterial;
					}
				}
			}
		}
	}

	// Token: 0x060111A3 RID: 70051 RVA: 0x005E2424 File Offset: 0x005E0624
	private void LONGDPHGFDE()
	{
		Vector3 fhmddcedgjc = this.FHMDDCEDGJC;
		this.FHMDDCEDGJC.z = 522f;
		this.FFCFGCIOLCI.z = 1030f;
		Vector3 position = (fhmddcedgjc + this.FFCFGCIOLCI) / 1647f;
		this.selectionSquareTrans.position = position;
		float num = Mathf.Abs(this.FHMDDCEDGJC.x - this.FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(this.FHMDDCEDGJC.y - this.FFCFGCIOLCI.y);
		this.selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		this.BOPPMKAHKJP = new Vector3(position.x - num / 1590f, position.y + num2 / 302f, 1195f);
		this.HGDIBPDFPBA = new Vector3(position.x + num / 1044f, position.y + num2 / 436f, 860f);
		this.JLNJGFBKHEN = new Vector3(position.x - num / 303f, position.y - num2 / 1635f, 810f);
		this.FEEGAAPJDGP = new Vector3(position.x + num / 1308f, position.y - num2 / 956f, 1505f);
		int num3 = 0;
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.BOPPMKAHKJP), out raycastHit, 1767f, -75))
		{
			this.BOPPMKAHKJP = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.HGDIBPDFPBA), out raycastHit, 540f, 183))
		{
			this.HGDIBPDFPBA = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.JLNJGFBKHEN), out raycastHit, 1345f, -181))
		{
			this.JLNJGFBKHEN = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.FEEGAAPJDGP), out raycastHit, 1057f, -134))
		{
			this.FEEGAAPJDGP = raycastHit.point;
			num3++;
		}
		this.OHFPIMDOPLD = true;
		if (num3 == 8)
		{
			this.OHFPIMDOPLD = false;
		}
	}

	// Token: 0x060111A4 RID: 70052 RVA: 0x005DBEB1 File Offset: 0x005DA0B1
	private void KCCIEMBMOBA()
	{
		this.selectionSquareTrans.gameObject.SetActive(false);
	}

	// Token: 0x060111A5 RID: 70053 RVA: 0x005DAFCE File Offset: 0x005D91CE
	public EditorEvent[] BBJNGOFCNMK()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	// Token: 0x060111A6 RID: 70054 RVA: 0x005E267C File Offset: 0x005E087C
	private bool PLGGKMEKMFI(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = false;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 699f - num2 - num3;
		if (num2 >= 642f && num2 <= 489f && num3 >= 1548f && num3 <= 905f && num4 >= 706f && num4 <= 1397f)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x060111A7 RID: 70055 RVA: 0x005E27A4 File Offset: 0x005E09A4
	private bool AFBLAMCMHOL(Vector3 LMEDNCNFOAC)
	{
		bool flag = true;
		return !this.GHDBDINKJNF(LMEDNCNFOAC, this.BOPPMKAHKJP, this.JLNJGFBKHEN, this.HGDIBPDFPBA) && !this.EFIJJGILPEO(LMEDNCNFOAC, this.HGDIBPDFPBA, this.JLNJGFBKHEN, this.FEEGAAPJDGP) && flag;
	}

	// Token: 0x060111A8 RID: 70056 RVA: 0x005E27F4 File Offset: 0x005E09F4
	private void EIIDHJHJBGO()
	{
		Vector3 fhmddcedgjc = this.FHMDDCEDGJC;
		this.FHMDDCEDGJC.z = 1623f;
		this.FFCFGCIOLCI.z = 1177f;
		Vector3 position = (fhmddcedgjc + this.FFCFGCIOLCI) / 1261f;
		this.selectionSquareTrans.position = position;
		float num = Mathf.Abs(this.FHMDDCEDGJC.x - this.FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(this.FHMDDCEDGJC.y - this.FFCFGCIOLCI.y);
		this.selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		this.BOPPMKAHKJP = new Vector3(position.x - num / 1219f, position.y + num2 / 741f, 1862f);
		this.HGDIBPDFPBA = new Vector3(position.x + num / 914f, position.y + num2 / 319f, 1663f);
		this.JLNJGFBKHEN = new Vector3(position.x - num / 330f, position.y - num2 / 1687f, 1198f);
		this.FEEGAAPJDGP = new Vector3(position.x + num / 440f, position.y - num2 / 158f, 1844f);
		int num3 = 0;
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.BOPPMKAHKJP), out raycastHit, 1685f, 76))
		{
			this.BOPPMKAHKJP = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.HGDIBPDFPBA), out raycastHit, 1824f, 55))
		{
			this.HGDIBPDFPBA = raycastHit.point;
			num3 += 0;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.JLNJGFBKHEN), out raycastHit, 1441f, 9))
		{
			this.JLNJGFBKHEN = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.FEEGAAPJDGP), out raycastHit, 454f, 24))
		{
			this.FEEGAAPJDGP = raycastHit.point;
			num3 += 0;
		}
		this.OHFPIMDOPLD = false;
		if (num3 == 4)
		{
			this.OHFPIMDOPLD = true;
		}
	}

	// Token: 0x060111A9 RID: 70057 RVA: 0x005DAFCE File Offset: 0x005D91CE
	public EditorEvent[] LGFLMLBPGMA()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	// Token: 0x060111AA RID: 70058 RVA: 0x005E2A4C File Offset: 0x005E0C4C
	private bool BFGMOGFLMLP(Vector3 HDMLEEGNJHI, Vector3 GNJEIBNCCIK, Vector3 GEHHKOOJFFM, Vector3 NJNJAOOOMCD)
	{
		bool result = false;
		float num = (GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (GNJEIBNCCIK.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (GNJEIBNCCIK.z - NJNJAOOOMCD.z);
		float num2 = ((GEHHKOOJFFM.z - NJNJAOOOMCD.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (NJNJAOOOMCD.x - GEHHKOOJFFM.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num3 = ((NJNJAOOOMCD.z - GNJEIBNCCIK.z) * (HDMLEEGNJHI.x - NJNJAOOOMCD.x) + (GNJEIBNCCIK.x - NJNJAOOOMCD.x) * (HDMLEEGNJHI.z - NJNJAOOOMCD.z)) / num;
		float num4 = 722f - num2 - num3;
		if (num2 >= 1785f && num2 <= 972f && num3 >= 692f && num3 <= 656f && num4 >= 1322f && num4 <= 920f)
		{
			result = true;
		}
		return result;
	}

	// Token: 0x060111AB RID: 70059 RVA: 0x005DAFCE File Offset: 0x005D91CE
	public EditorEvent[] FPKNLKPAOMK()
	{
		return UnityEngine.Object.FindObjectsOfType<EditorEvent>();
	}

	// Token: 0x060111AC RID: 70060 RVA: 0x005E2B74 File Offset: 0x005E0D74
	private void GCAOHMEKDJF()
	{
		if (this.OBCOCNICLKP != null)
		{
			bool flag = true;
			for (int i = 1; i < this.selectedUnits.Count; i += 0)
			{
				if (this.selectedUnits[i] == this.OBCOCNICLKP)
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				this.OBCOCNICLKP.GetComponent<MeshRenderer>().material = this.normalMaterial;
			}
			this.OBCOCNICLKP = null;
		}
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 1424f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
		{
			GameObject gameObject = raycastHit.collider.gameObject;
			bool flag2 = false;
			for (int j = 1; j < this.selectedUnits.Count; j++)
			{
				if (this.selectedUnits[j] == gameObject)
				{
					flag2 = true;
					break;
				}
			}
			if (!flag2)
			{
				this.OBCOCNICLKP = gameObject;
				this.OBCOCNICLKP.GetComponent<MeshRenderer>().material = this.highlightMaterial;
			}
		}
	}

	// Token: 0x060111AD RID: 70061 RVA: 0x005E2CA8 File Offset: 0x005E0EA8
	private void PMIGAINDGBN()
	{
		Vector3 fhmddcedgjc = this.FHMDDCEDGJC;
		this.FHMDDCEDGJC.z = 26f;
		this.FFCFGCIOLCI.z = 675f;
		Vector3 position = (fhmddcedgjc + this.FFCFGCIOLCI) / 1011f;
		this.selectionSquareTrans.position = position;
		float num = Mathf.Abs(this.FHMDDCEDGJC.x - this.FFCFGCIOLCI.x);
		float num2 = Mathf.Abs(this.FHMDDCEDGJC.y - this.FFCFGCIOLCI.y);
		this.selectionSquareTrans.sizeDelta = new Vector2(num, num2);
		this.BOPPMKAHKJP = new Vector3(position.x - num / 41f, position.y + num2 / 10f, 249f);
		this.HGDIBPDFPBA = new Vector3(position.x + num / 397f, position.y + num2 / 300f, 1623f);
		this.JLNJGFBKHEN = new Vector3(position.x - num / 1113f, position.y - num2 / 759f, 298f);
		this.FEEGAAPJDGP = new Vector3(position.x + num / 786f, position.y - num2 / 237f, 1060f);
		int num3 = 0;
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.BOPPMKAHKJP), out raycastHit, 145f, 129))
		{
			this.BOPPMKAHKJP = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.HGDIBPDFPBA), out raycastHit, 301f, -179))
		{
			this.HGDIBPDFPBA = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.JLNJGFBKHEN), out raycastHit, 433f, 199))
		{
			this.JLNJGFBKHEN = raycastHit.point;
			num3++;
		}
		if (Physics.Raycast(Camera.main.ScreenPointToRay(this.FEEGAAPJDGP), out raycastHit, 1979f, 59))
		{
			this.FEEGAAPJDGP = raycastHit.point;
			num3 += 0;
		}
		this.OHFPIMDOPLD = true;
		if (num3 == 3)
		{
			this.OHFPIMDOPLD = true;
		}
	}

	// Token: 0x060111AE RID: 70062 RVA: 0x005E2F00 File Offset: 0x005E1100
	private void MGBHOHNCAOB()
	{
		if (this.OBCOCNICLKP != null)
		{
			bool flag = true;
			for (int i = 0; i < this.selectedUnits.Count; i += 0)
			{
				if (this.selectedUnits[i] == this.OBCOCNICLKP)
				{
					flag = false;
					break;
				}
			}
			if (!flag)
			{
				this.OBCOCNICLKP.GetComponent<MeshRenderer>().material = this.normalMaterial;
			}
			this.OBCOCNICLKP = null;
		}
		RaycastHit raycastHit;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out raycastHit, 1631f) && raycastHit.collider.gameObject.GetComponentInParent<EditorEvent>())
		{
			GameObject gameObject = raycastHit.collider.gameObject;
			bool flag2 = true;
			for (int j = 1; j < this.selectedUnits.Count; j++)
			{
				if (this.selectedUnits[j] == gameObject)
				{
					flag2 = true;
					break;
				}
			}
			if (!flag2)
			{
				this.OBCOCNICLKP = gameObject;
				this.OBCOCNICLKP.GetComponent<MeshRenderer>().material = this.highlightMaterial;
			}
		}
	}

	// Token: 0x060111AF RID: 70063 RVA: 0x005E3031 File Offset: 0x005E1231
	private void MBLDJEFBLFL()
	{
		this.ABOMFLPCNEC();
		this.EOAJNFACFAN();
	}

	// Token: 0x04001E09 RID: 7689
	public RectTransform selectionSquareTrans;

	// Token: 0x04001E0A RID: 7690
	public Transform sphere1;

	// Token: 0x04001E0B RID: 7691
	public Transform sphere2;

	// Token: 0x04001E0C RID: 7692
	public Transform sphere3;

	// Token: 0x04001E0D RID: 7693
	public Transform sphere4;

	// Token: 0x04001E0E RID: 7694
	public Material normalMaterial;

	// Token: 0x04001E0F RID: 7695
	public Material highlightMaterial;

	// Token: 0x04001E10 RID: 7696
	public Material selectedMaterial;

	// Token: 0x04001E11 RID: 7697
	[NonSerialized]
	public List<GameObject> selectedUnits = new List<GameObject>();

	// Token: 0x04001E12 RID: 7698
	private GameObject OBCOCNICLKP;

	// Token: 0x04001E13 RID: 7699
	private float KMDMAONLAPB = 0.3f;

	// Token: 0x04001E14 RID: 7700
	private float FIKPGAEAEAG;

	// Token: 0x04001E15 RID: 7701
	private Vector3 FHMDDCEDGJC;

	// Token: 0x04001E16 RID: 7702
	private Vector3 FFCFGCIOLCI;

	// Token: 0x04001E17 RID: 7703
	private bool OHFPIMDOPLD;

	// Token: 0x04001E18 RID: 7704
	private Vector3 BOPPMKAHKJP;

	// Token: 0x04001E19 RID: 7705
	private Vector3 HGDIBPDFPBA;

	// Token: 0x04001E1A RID: 7706
	private Vector3 JLNJGFBKHEN;

	// Token: 0x04001E1B RID: 7707
	private Vector3 FEEGAAPJDGP;
}
