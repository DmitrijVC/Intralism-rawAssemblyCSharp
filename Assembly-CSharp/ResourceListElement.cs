using System;
using System.Collections;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

// Token: 0x02000400 RID: 1024
public class ResourceListElement : MonoBehaviour
{
	// Token: 0x0600E992 RID: 59794 RVA: 0x00529F9F File Offset: 0x0052819F
	public void KBFIOEBICDG(string LGHIPFAEONM)
	{
		this.resourceName = LGHIPFAEONM;
	}

	// Token: 0x0600E993 RID: 59795 RVA: 0x00529FA8 File Offset: 0x005281A8
	private void FLMBJPODCOH()
	{
		this.AGIHKJPAKDB(this.resourceName);
		base.transform.Find("ItemNameBGImage").GetComponent<InputField>().text = this.resourceName;
		base.transform.Find("_FgCocMask").GetComponent<Image>().sprite = (Sprite)this.resource;
		base.transform.Find("Joystick1Button12").GetComponent<Text>().text = this.resourceFile;
	}

	// Token: 0x0600E994 RID: 59796 RVA: 0x0052A026 File Offset: 0x00528226
	public void PABDAJGGKNL()
	{
		base.StartCoroutine(this.NGHGKCBKOKC());
	}

	// Token: 0x0600E995 RID: 59797 RVA: 0x00529F9F File Offset: 0x0052819F
	public void AAGEPOLONEJ(string LGHIPFAEONM)
	{
		this.resourceName = LGHIPFAEONM;
	}

	// Token: 0x0600E996 RID: 59798 RVA: 0x0052A035 File Offset: 0x00528235
	public void HFBOMJFKMDL()
	{
		base.StartCoroutine(this.NEGNGJCGKPM());
	}

	// Token: 0x0600E997 RID: 59799 RVA: 0x0052A044 File Offset: 0x00528244
	private void BBMIEEFAMLI()
	{
		this.MJAGEKIDPIJ(this.resourceName);
		base.transform.Find("Editor/").GetComponent<InputField>().text = this.resourceName;
		base.transform.Find("%").GetComponent<Image>().sprite = (Sprite)this.resource;
		base.transform.Find("_NoisePerChannel").GetComponent<Text>().text = this.resourceFile;
	}

	// Token: 0x0600E998 RID: 59800 RVA: 0x0052A0C2 File Offset: 0x005282C2
	public void PIMBFCPHPPP()
	{
		base.StartCoroutine(this.GIDGOJCLNOE());
	}

	// Token: 0x0600E999 RID: 59801 RVA: 0x00529F9F File Offset: 0x0052819F
	public void IBLCJKLDJFP(string LGHIPFAEONM)
	{
		this.resourceName = LGHIPFAEONM;
	}

	// Token: 0x0600E99A RID: 59802 RVA: 0x0052A0D4 File Offset: 0x005282D4
	public IEnumerator GIDGOJCLNOE()
	{
		string text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + this.resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find(new Predicate<MapResource>(base.GBKBDKHPLKG)));
		yield return base.StartCoroutine(Singleton<MapEditor>.Instance.Save(false, true));
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
		yield break;
	}

	// Token: 0x0600E99B RID: 59803 RVA: 0x0052A0F0 File Offset: 0x005282F0
	private void MADOFDPAIFH()
	{
		this.MJAGEKIDPIJ(this.resourceName);
		base.transform.Find("Set Background Color").GetComponent<InputField>().text = this.resourceName;
		base.transform.Find("_TimeX").GetComponent<Image>().sprite = (Sprite)this.resource;
		base.transform.Find("_Value4").GetComponent<Text>().text = this.resourceFile;
	}

	// Token: 0x0600E99C RID: 59804 RVA: 0x0052A170 File Offset: 0x00528370
	public IEnumerator DeleteResource()
	{
		text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + this.resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find(new Predicate<MapResource>(base.GBKBDKHPLKG)));
		yield return base.StartCoroutine(Singleton<MapEditor>.Instance.Save(false, true));
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
		yield break;
	}

	// Token: 0x0600E99D RID: 59805 RVA: 0x0052A18C File Offset: 0x0052838C
	public IEnumerator FBLKGDAFNBO()
	{
		text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + this.resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find(new Predicate<MapResource>(base.GBKBDKHPLKG)));
		yield return base.StartCoroutine(Singleton<MapEditor>.Instance.Save(false, true));
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
		yield break;
	}

	// Token: 0x0600E99E RID: 59806 RVA: 0x0052A1A7 File Offset: 0x005283A7
	public void FNEKLACBDFL(string LKHGHBMAFEL, string KFCPKFBCONE, UnityEngine.Object ACABBJEAMGG)
	{
		this.resourceName = LKHGHBMAFEL;
		this.resourceFile = KFCPKFBCONE;
		this.resource = ACABBJEAMGG;
		this.MADOFDPAIFH();
	}

	// Token: 0x0600E99F RID: 59807 RVA: 0x0052A1C4 File Offset: 0x005283C4
	public void POGJLIDHDIH(string LKHGHBMAFEL, string KFCPKFBCONE, UnityEngine.Object ACABBJEAMGG)
	{
		this.resourceName = LKHGHBMAFEL;
		this.resourceFile = KFCPKFBCONE;
		this.resource = ACABBJEAMGG;
		this.KPAFHHNLNCO();
	}

	// Token: 0x0600E9A0 RID: 59808 RVA: 0x00529F9F File Offset: 0x0052819F
	public void AGIHKJPAKDB(string LGHIPFAEONM)
	{
		this.resourceName = LGHIPFAEONM;
	}

	// Token: 0x0600E9A1 RID: 59809 RVA: 0x0052A1E1 File Offset: 0x005283E1
	public void AOEEOKNJDCK(string LKHGHBMAFEL, string KFCPKFBCONE, UnityEngine.Object ACABBJEAMGG)
	{
		this.resourceName = LKHGHBMAFEL;
		this.resourceFile = KFCPKFBCONE;
		this.resource = ACABBJEAMGG;
		this.FGAOHKALECE();
	}

	// Token: 0x0600E9A2 RID: 59810 RVA: 0x0052A200 File Offset: 0x00528400
	private void JMCOKJCEMDD()
	{
		this.IBLCJKLDJFP(this.resourceName);
		base.transform.Find("Editor/").GetComponent<InputField>().text = this.resourceName;
		base.transform.Find("SetTrailZoomSpeed").GetComponent<Image>().sprite = (Sprite)this.resource;
		base.transform.Find("Set particles gravity").GetComponent<Text>().text = this.resourceFile;
	}

	// Token: 0x0600E9A3 RID: 59811 RVA: 0x0052A280 File Offset: 0x00528480
	public IEnumerator PIBMAMMIKNN()
	{
		text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + this.resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find(new Predicate<MapResource>(base.GBKBDKHPLKG)));
		yield return base.StartCoroutine(Singleton<MapEditor>.Instance.Save(false, true));
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
		yield break;
	}

	// Token: 0x0600E9A4 RID: 59812 RVA: 0x0052A29C File Offset: 0x0052849C
	private void PMOMAAEGNNE()
	{
		this.AHBLGDEPBMJ(this.resourceName);
		base.transform.Find("CameraFilterPack_eyes_vision_1").GetComponent<InputField>().text = this.resourceName;
		base.transform.Find("tagElement").GetComponent<Image>().sprite = (Sprite)this.resource;
		base.transform.Find("player.xp").GetComponent<Text>().text = this.resourceFile;
	}

	// Token: 0x0600E9A5 RID: 59813 RVA: 0x0052A31A File Offset: 0x0052851A
	public void LBPNHCOOJBK()
	{
		base.StartCoroutine(this.DBLJBKCOJIC());
	}

	// Token: 0x0600E9A6 RID: 59814 RVA: 0x0052A32C File Offset: 0x0052852C
	public IEnumerator HHNOAEIHLNO()
	{
		text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + this.resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find(new Predicate<MapResource>(base.GBKBDKHPLKG)));
		yield return base.StartCoroutine(Singleton<MapEditor>.Instance.Save(false, true));
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
		yield break;
	}

	// Token: 0x0600E9A7 RID: 59815 RVA: 0x0052A347 File Offset: 0x00528547
	public void CPFOEFKOJGA(string LKHGHBMAFEL, string KFCPKFBCONE, UnityEngine.Object ACABBJEAMGG)
	{
		this.resourceName = LKHGHBMAFEL;
		this.resourceFile = KFCPKFBCONE;
		this.resource = ACABBJEAMGG;
		this.PMOMAAEGNNE();
	}

	// Token: 0x0600E9A8 RID: 59816 RVA: 0x0052A364 File Offset: 0x00528564
	public void LOLLNPCFBLF()
	{
		base.StartCoroutine(this.LLIIHFEFJJA());
	}

	// Token: 0x0600E9A9 RID: 59817 RVA: 0x0052A373 File Offset: 0x00528573
	public void AGHMCBOKCCK()
	{
		base.StartCoroutine(this.HHNOAEIHLNO());
	}

	// Token: 0x0600E9AA RID: 59818 RVA: 0x0052A384 File Offset: 0x00528584
	public IEnumerator CGIBJICLECE()
	{
		text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + this.resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find(new Predicate<MapResource>(base.GBKBDKHPLKG)));
		yield return base.StartCoroutine(Singleton<MapEditor>.Instance.Save(false, true));
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
		yield break;
	}

	// Token: 0x0600E9AB RID: 59819 RVA: 0x00529F9F File Offset: 0x0052819F
	public void GCKOLPBJANJ(string LGHIPFAEONM)
	{
		this.resourceName = LGHIPFAEONM;
	}

	// Token: 0x0600E9AC RID: 59820 RVA: 0x0052A0C2 File Offset: 0x005282C2
	public void FAJPCAIIKHF()
	{
		base.StartCoroutine(this.GIDGOJCLNOE());
	}

	// Token: 0x0600E9AD RID: 59821 RVA: 0x0052A3A0 File Offset: 0x005285A0
	public IEnumerator BNLAEGAHFPM()
	{
		text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + this.resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find(new Predicate<MapResource>(base.GBKBDKHPLKG)));
		yield return base.StartCoroutine(Singleton<MapEditor>.Instance.Save(false, true));
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
		yield break;
	}

	// Token: 0x0600E9AE RID: 59822 RVA: 0x0052A3BC File Offset: 0x005285BC
	private void JKCCKDMGBAC()
	{
		this.LHKONPDOJGI(this.resourceName);
		base.transform.Find(",").GetComponent<InputField>().text = this.resourceName;
		base.transform.Find("masterSteamID").GetComponent<Image>().sprite = (Sprite)this.resource;
		base.transform.Find("[ResourcesManager] Load audio error: ").GetComponent<Text>().text = this.resourceFile;
	}

	// Token: 0x0600E9AF RID: 59823 RVA: 0x0052A43A File Offset: 0x0052863A
	public void IDHFBNDPOIN()
	{
		base.StartCoroutine(this.ANJKGPBBHMP());
	}

	// Token: 0x0600E9B0 RID: 59824 RVA: 0x0052A44C File Offset: 0x0052864C
	public IEnumerator LLIIHFEFJJA()
	{
		text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + this.resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find(new Predicate<MapResource>(base.GBKBDKHPLKG)));
		yield return base.StartCoroutine(Singleton<MapEditor>.Instance.Save(false, true));
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
		yield break;
	}

	// Token: 0x0600E9B1 RID: 59825 RVA: 0x0052A468 File Offset: 0x00528668
	private void GDAAJCJKHGB()
	{
		this.UpdateID(this.resourceName);
		base.transform.Find("IDInputField").GetComponent<InputField>().text = this.resourceName;
		base.transform.Find("Icon").GetComponent<Image>().sprite = (Sprite)this.resource;
		base.transform.Find("FileLabel").GetComponent<Text>().text = this.resourceFile;
	}

	// Token: 0x0600E9B2 RID: 59826 RVA: 0x0052A4E6 File Offset: 0x005286E6
	public void Remove()
	{
		base.StartCoroutine(this.DeleteResource());
	}

	// Token: 0x0600E9B3 RID: 59827 RVA: 0x0052A4F5 File Offset: 0x005286F5
	public void IFGOHEOEGKH(string LKHGHBMAFEL, string KFCPKFBCONE, UnityEngine.Object ACABBJEAMGG)
	{
		this.resourceName = LKHGHBMAFEL;
		this.resourceFile = KFCPKFBCONE;
		this.resource = ACABBJEAMGG;
		this.JMCOKJCEMDD();
	}

	// Token: 0x0600E9B4 RID: 59828 RVA: 0x00529F9F File Offset: 0x0052819F
	public void BMICAMAGHKE(string LGHIPFAEONM)
	{
		this.resourceName = LGHIPFAEONM;
	}

	// Token: 0x0600E9B5 RID: 59829 RVA: 0x00529F9F File Offset: 0x0052819F
	public void AHBLGDEPBMJ(string LGHIPFAEONM)
	{
		this.resourceName = LGHIPFAEONM;
	}

	// Token: 0x0600E9B6 RID: 59830 RVA: 0x0052A514 File Offset: 0x00528714
	public IEnumerator JIHJHMIEIAN()
	{
		text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + this.resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find(new Predicate<MapResource>(base.GBKBDKHPLKG)));
		yield return base.StartCoroutine(Singleton<MapEditor>.Instance.Save(false, true));
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
		yield break;
	}

	// Token: 0x0600E9B7 RID: 59831 RVA: 0x0052A52F File Offset: 0x0052872F
	public void EFEONCCCKNP(string LKHGHBMAFEL, string KFCPKFBCONE, UnityEngine.Object ACABBJEAMGG)
	{
		this.resourceName = LKHGHBMAFEL;
		this.resourceFile = KFCPKFBCONE;
		this.resource = ACABBJEAMGG;
		this.JKCCKDMGBAC();
	}

	// Token: 0x0600E9B8 RID: 59832 RVA: 0x0052A54C File Offset: 0x0052874C
	private void HFBCONFKOFA()
	{
		this.GDNGFFGPLLO(this.resourceName);
		base.transform.Find("_Near").GetComponent<InputField>().text = this.resourceName;
		base.transform.Find("_TimeX").GetComponent<Image>().sprite = (Sprite)this.resource;
		base.transform.Find("_EmissionGain").GetComponent<Text>().text = this.resourceFile;
	}

	// Token: 0x0600E9B9 RID: 59833 RVA: 0x0052A5CC File Offset: 0x005287CC
	private void BDKHAJPELCL()
	{
		this.UpdateID(this.resourceName);
		base.transform.Find("settings.shaders").GetComponent<InputField>().text = this.resourceName;
		base.transform.Find("editor.").GetComponent<Image>().sprite = (Sprite)this.resource;
		base.transform.Find("Using constructor for new PingNativeDynamic()").GetComponent<Text>().text = this.resourceFile;
	}

	// Token: 0x0600E9BA RID: 59834 RVA: 0x0052A64C File Offset: 0x0052884C
	public IEnumerator DBLJBKCOJIC()
	{
		text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + this.resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find(new Predicate<MapResource>(base.GBKBDKHPLKG)));
		yield return base.StartCoroutine(Singleton<MapEditor>.Instance.Save(false, true));
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
		yield break;
	}

	// Token: 0x0600E9BB RID: 59835 RVA: 0x0052A668 File Offset: 0x00528868
	private void FGMBDLNECAB()
	{
		this.AHBLGDEPBMJ(this.resourceName);
		base.transform.Find("Items/").GetComponent<InputField>().text = this.resourceName;
		base.transform.Find("inventory.selected.").GetComponent<Image>().sprite = (Sprite)this.resource;
		base.transform.Find("_Value2").GetComponent<Text>().text = this.resourceFile;
	}

	// Token: 0x0600E9BC RID: 59836 RVA: 0x00529F9F File Offset: 0x0052819F
	public void JIFBJJHFFEA(string LGHIPFAEONM)
	{
		this.resourceName = LGHIPFAEONM;
	}

	// Token: 0x0600E9BD RID: 59837 RVA: 0x0052A6E8 File Offset: 0x005288E8
	public IEnumerator HOHJEDHCMBN()
	{
		text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + this.resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find(new Predicate<MapResource>(base.GBKBDKHPLKG)));
		yield return base.StartCoroutine(Singleton<MapEditor>.Instance.Save(false, true));
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
		yield break;
	}

	// Token: 0x0600E9BE RID: 59838 RVA: 0x0052A704 File Offset: 0x00528904
	public IEnumerator CCFIABJCBLI()
	{
		text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + this.resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find(new Predicate<MapResource>(base.GBKBDKHPLKG)));
		yield return base.StartCoroutine(Singleton<MapEditor>.Instance.Save(false, true));
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
		yield break;
	}

	// Token: 0x0600E9BF RID: 59839 RVA: 0x0052A71F File Offset: 0x0052891F
	public void NFKKPHKGIEI(string LKHGHBMAFEL, string KFCPKFBCONE, UnityEngine.Object ACABBJEAMGG)
	{
		this.resourceName = LKHGHBMAFEL;
		this.resourceFile = KFCPKFBCONE;
		this.resource = ACABBJEAMGG;
		this.GDAAJCJKHGB();
	}

	// Token: 0x0600E9C0 RID: 59840 RVA: 0x0052A4F5 File Offset: 0x005286F5
	public void ALKBNPMCEOM(string LKHGHBMAFEL, string KFCPKFBCONE, UnityEngine.Object ACABBJEAMGG)
	{
		this.resourceName = LKHGHBMAFEL;
		this.resourceFile = KFCPKFBCONE;
		this.resource = ACABBJEAMGG;
		this.JMCOKJCEMDD();
	}

	// Token: 0x0600E9C1 RID: 59841 RVA: 0x0052A73C File Offset: 0x0052893C
	private void ABJILFDKKDA()
	{
		this.AGIHKJPAKDB(this.resourceName);
		base.transform.Find("Ev Destroy Failed. Could not find PhotonView with instantiationId ").GetComponent<InputField>().text = this.resourceName;
		base.transform.Find("_Parameter").GetComponent<Image>().sprite = (Sprite)this.resource;
		base.transform.Find("settings.enableranking").GetComponent<Text>().text = this.resourceFile;
	}

	// Token: 0x0600E9C2 RID: 59842 RVA: 0x0052A7BC File Offset: 0x005289BC
	private void DFGHDMDDDCG()
	{
		this.JIFBJJHFFEA(this.resourceName);
		base.transform.Find("The given 2D texture ").GetComponent<InputField>().text = this.resourceName;
		base.transform.Find("settings_bindings_sec_").GetComponent<Image>().sprite = (Sprite)this.resource;
		base.transform.Find("\n").GetComponent<Text>().text = this.resourceFile;
	}

	// Token: 0x0600E9C3 RID: 59843 RVA: 0x0052A83C File Offset: 0x00528A3C
	public IEnumerator NGHGKCBKOKC()
	{
		text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + this.resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find(new Predicate<MapResource>(base.GBKBDKHPLKG)));
		yield return base.StartCoroutine(Singleton<MapEditor>.Instance.Save(false, true));
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
		yield break;
	}

	// Token: 0x0600E9C4 RID: 59844 RVA: 0x0052A858 File Offset: 0x00528A58
	public IEnumerator CJGDNHAHIFP()
	{
		text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + this.resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find(new Predicate<MapResource>(base.GBKBDKHPLKG)));
		yield return base.StartCoroutine(Singleton<MapEditor>.Instance.Save(false, true));
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
		yield break;
	}

	// Token: 0x0600E9C5 RID: 59845 RVA: 0x0052A874 File Offset: 0x00528A74
	private void EIJFDPPIAMH()
	{
		this.LHKONPDOJGI(this.resourceName);
		base.transform.Find("_Value3").GetComponent<InputField>().text = this.resourceName;
		base.transform.Find("VoteUpToggle").GetComponent<Image>().sprite = (Sprite)this.resource;
		base.transform.Find("_Threshhold").GetComponent<Text>().text = this.resourceFile;
	}

	// Token: 0x0600E9C6 RID: 59846 RVA: 0x0052A8F2 File Offset: 0x00528AF2
	public void LCOHKDBLJBH()
	{
		base.StartCoroutine(this.CJGDNHAHIFP());
	}

	// Token: 0x0600E9C7 RID: 59847 RVA: 0x0052A71F File Offset: 0x0052891F
	public void MDPJHKECLOF(string LKHGHBMAFEL, string KFCPKFBCONE, UnityEngine.Object ACABBJEAMGG)
	{
		this.resourceName = LKHGHBMAFEL;
		this.resourceFile = KFCPKFBCONE;
		this.resource = ACABBJEAMGG;
		this.GDAAJCJKHGB();
	}

	// Token: 0x0600E9C8 RID: 59848 RVA: 0x0052A904 File Offset: 0x00528B04
	public IEnumerator GAILBIBNJNM()
	{
		text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + this.resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find(new Predicate<MapResource>(base.GBKBDKHPLKG)));
		yield return base.StartCoroutine(Singleton<MapEditor>.Instance.Save(false, true));
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
		yield break;
	}

	// Token: 0x0600E9C9 RID: 59849 RVA: 0x0052A91F File Offset: 0x00528B1F
	public void NBCMDHKCOBN()
	{
		base.StartCoroutine(this.CGIBJICLECE());
	}

	// Token: 0x0600E9CA RID: 59850 RVA: 0x0052A930 File Offset: 0x00528B30
	private void KOEANBPOBLO()
	{
		this.IBLCJKLDJFP(this.resourceName);
		base.transform.Find("_EdgeThreshold").GetComponent<InputField>().text = this.resourceName;
		base.transform.Find("settings.disablestoryboard").GetComponent<Image>().sprite = (Sprite)this.resource;
		base.transform.Find("ItemsUploader").GetComponent<Text>().text = this.resourceFile;
	}

	// Token: 0x0600E9CB RID: 59851 RVA: 0x0052A31A File Offset: 0x0052851A
	public void BKPLFGJCJAN()
	{
		base.StartCoroutine(this.DBLJBKCOJIC());
	}

	// Token: 0x0600E9CC RID: 59852 RVA: 0x0052A9B0 File Offset: 0x00528BB0
	private void FGAOHKALECE()
	{
		this.AGIHKJPAKDB(this.resourceName);
		base.transform.Find("_Value5").GetComponent<InputField>().text = this.resourceName;
		base.transform.Find("#{0:00} '{1}'{2} {3}").GetComponent<Image>().sprite = (Sprite)this.resource;
		base.transform.Find("ItemTemplate").GetComponent<Text>().text = this.resourceFile;
	}

	// Token: 0x0600E9CD RID: 59853 RVA: 0x0052AA30 File Offset: 0x00528C30
	private void DHCJFBNIIAK()
	{
		this.UpdateID(this.resourceName);
		base.transform.Find("CameraFilterPack/Colors_BleachBypass").GetComponent<InputField>().text = this.resourceName;
		base.transform.Find("CameraFilterPack/TV_Old_Movie").GetComponent<Image>().sprite = (Sprite)this.resource;
		base.transform.Find("[SoundManager] Loaded skin audio").GetComponent<Text>().text = this.resourceFile;
	}

	// Token: 0x0600E9CE RID: 59854 RVA: 0x0052AAB0 File Offset: 0x00528CB0
	public IEnumerator NEGNGJCGKPM()
	{
		text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + this.resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find(new Predicate<MapResource>(base.GBKBDKHPLKG)));
		yield return base.StartCoroutine(Singleton<MapEditor>.Instance.Save(false, true));
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
		yield break;
	}

	// Token: 0x0600E9CF RID: 59855 RVA: 0x0052AACB File Offset: 0x00528CCB
	public void MIAIEKCLEAO(string LKHGHBMAFEL, string KFCPKFBCONE, UnityEngine.Object ACABBJEAMGG)
	{
		this.resourceName = LKHGHBMAFEL;
		this.resourceFile = KFCPKFBCONE;
		this.resource = ACABBJEAMGG;
		this.FGMBDLNECAB();
	}

	// Token: 0x0600E9D0 RID: 59856 RVA: 0x0052A71F File Offset: 0x0052891F
	public void Init(string LKHGHBMAFEL, string KFCPKFBCONE, UnityEngine.Object ACABBJEAMGG)
	{
		this.resourceName = LKHGHBMAFEL;
		this.resourceFile = KFCPKFBCONE;
		this.resource = ACABBJEAMGG;
		this.GDAAJCJKHGB();
	}

	// Token: 0x0600E9D1 RID: 59857 RVA: 0x00529F9F File Offset: 0x0052819F
	public void CFLMNNKKCPG(string LGHIPFAEONM)
	{
		this.resourceName = LGHIPFAEONM;
	}

	// Token: 0x0600E9D2 RID: 59858 RVA: 0x00529F9F File Offset: 0x0052819F
	public void MJAGEKIDPIJ(string LGHIPFAEONM)
	{
		this.resourceName = LGHIPFAEONM;
	}

	// Token: 0x0600E9D3 RID: 59859 RVA: 0x0052AAE8 File Offset: 0x00528CE8
	private void KCANHOPLEDI()
	{
		this.ILACAJGMINP(this.resourceName);
		base.transform.Find("[MapsStats] Max score: ").GetComponent<InputField>().text = this.resourceName;
		base.transform.Find("Called GetNumberOfCurrentPlayers()").GetComponent<Image>().sprite = (Sprite)this.resource;
		base.transform.Find("_MainTex").GetComponent<Text>().text = this.resourceFile;
	}

	// Token: 0x0600E9D4 RID: 59860 RVA: 0x00529F9F File Offset: 0x0052819F
	public void LHKONPDOJGI(string LGHIPFAEONM)
	{
		this.resourceName = LGHIPFAEONM;
	}

	// Token: 0x0600E9D5 RID: 59861 RVA: 0x0052A71F File Offset: 0x0052891F
	public void BFMEBNFGCEA(string LKHGHBMAFEL, string KFCPKFBCONE, UnityEngine.Object ACABBJEAMGG)
	{
		this.resourceName = LKHGHBMAFEL;
		this.resourceFile = KFCPKFBCONE;
		this.resource = ACABBJEAMGG;
		this.GDAAJCJKHGB();
	}

	// Token: 0x0600E9D6 RID: 59862 RVA: 0x0052AB68 File Offset: 0x00528D68
	public IEnumerator PDFNDDOLHKK()
	{
		text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + this.resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find(new Predicate<MapResource>(base.GBKBDKHPLKG)));
		yield return base.StartCoroutine(Singleton<MapEditor>.Instance.Save(false, true));
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
		yield break;
	}

	// Token: 0x0600E9D7 RID: 59863 RVA: 0x0052AB83 File Offset: 0x00528D83
	public void OPKKBMCDOEM(string LKHGHBMAFEL, string KFCPKFBCONE, UnityEngine.Object ACABBJEAMGG)
	{
		this.resourceName = LKHGHBMAFEL;
		this.resourceFile = KFCPKFBCONE;
		this.resource = ACABBJEAMGG;
		this.BBMIEEFAMLI();
	}

	// Token: 0x0600E9D8 RID: 59864 RVA: 0x0052A364 File Offset: 0x00528564
	public void HHKILLPKCCE()
	{
		base.StartCoroutine(this.LLIIHFEFJJA());
	}

	// Token: 0x0600E9DA RID: 59866 RVA: 0x0052ABA0 File Offset: 0x00528DA0
	public IEnumerator ANJKGPBBHMP()
	{
		text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + this.resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find(new Predicate<MapResource>(base.GBKBDKHPLKG)));
		yield return base.StartCoroutine(Singleton<MapEditor>.Instance.Save(false, true));
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
		yield break;
	}

	// Token: 0x0600E9DB RID: 59867 RVA: 0x0052A1A7 File Offset: 0x005283A7
	public void BKEFJPOHKDE(string LKHGHBMAFEL, string KFCPKFBCONE, UnityEngine.Object ACABBJEAMGG)
	{
		this.resourceName = LKHGHBMAFEL;
		this.resourceFile = KFCPKFBCONE;
		this.resource = ACABBJEAMGG;
		this.MADOFDPAIFH();
	}

	// Token: 0x0600E9DC RID: 59868 RVA: 0x0052ABBC File Offset: 0x00528DBC
	public IEnumerator EILNOMOAOHN()
	{
		text = Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID()).fullLevelPath + "/" + this.resourceFile;
		if (File.Exists(text))
		{
			FileInfo fileInfo = new FileInfo(text);
			File.Delete(fileInfo.FullName);
		}
		Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Remove(Singleton<MapEditor>.Instance.GetEditedMapDataObj().levelResources.Find(new Predicate<MapResource>(base.GBKBDKHPLKG)));
		yield return base.StartCoroutine(Singleton<MapEditor>.Instance.Save(false, true));
		yield return base.StartCoroutine(Singleton<MapsSystem>.Instance.ReloadLevelResources(Singleton<MapsSystem>.Instance.GetMapData(Singleton<MapEditor>.Instance.GetMapID())));
		Singleton<MapEditor>.Instance.ReloadResList();
		yield break;
	}

	// Token: 0x0600E9DD RID: 59869 RVA: 0x00529F9F File Offset: 0x0052819F
	public void GDNGFFGPLLO(string LGHIPFAEONM)
	{
		this.resourceName = LGHIPFAEONM;
	}

	// Token: 0x0600E9DE RID: 59870 RVA: 0x00529F9F File Offset: 0x0052819F
	public void ILACAJGMINP(string LGHIPFAEONM)
	{
		this.resourceName = LGHIPFAEONM;
	}

	// Token: 0x0600E9DF RID: 59871 RVA: 0x0052AACB File Offset: 0x00528CCB
	public void HBKEHHCMMBN(string LKHGHBMAFEL, string KFCPKFBCONE, UnityEngine.Object ACABBJEAMGG)
	{
		this.resourceName = LKHGHBMAFEL;
		this.resourceFile = KFCPKFBCONE;
		this.resource = ACABBJEAMGG;
		this.FGMBDLNECAB();
	}

	// Token: 0x0600E9E0 RID: 59872 RVA: 0x0052ABD7 File Offset: 0x00528DD7
	public void NKLCNJEIAFB(string LKHGHBMAFEL, string KFCPKFBCONE, UnityEngine.Object ACABBJEAMGG)
	{
		this.resourceName = LKHGHBMAFEL;
		this.resourceFile = KFCPKFBCONE;
		this.resource = ACABBJEAMGG;
		this.BDKHAJPELCL();
	}

	// Token: 0x0600E9E1 RID: 59873 RVA: 0x0052A035 File Offset: 0x00528235
	public void FAMABONDNDB()
	{
		base.StartCoroutine(this.NEGNGJCGKPM());
	}

	// Token: 0x0600E9E2 RID: 59874 RVA: 0x0052ABF4 File Offset: 0x00528DF4
	private void IGNNPJBKBNM()
	{
		this.AAGEPOLONEJ(this.resourceName);
		base.transform.Find(" respawn: ").GetComponent<InputField>().text = this.resourceName;
		base.transform.Find("Player Disconnected").GetComponent<Image>().sprite = (Sprite)this.resource;
		base.transform.Find("SpeedSlider").GetComponent<Text>().text = this.resourceFile;
	}

	// Token: 0x0600E9E3 RID: 59875 RVA: 0x0052AC74 File Offset: 0x00528E74
	private void KPAFHHNLNCO()
	{
		this.HKEFJGFEKHF(this.resourceName);
		base.transform.Find("CameraFilterPack/Lut_PlayWith").GetComponent<InputField>().text = this.resourceName;
		base.transform.Find("settings.gamemessagesduration").GetComponent<Image>().sprite = (Sprite)this.resource;
		base.transform.Find("_Far").GetComponent<Text>().text = this.resourceFile;
	}

	// Token: 0x0600E9E4 RID: 59876 RVA: 0x0052ACF4 File Offset: 0x00528EF4
	private void HLCBCAHLIAI()
	{
		this.KBFIOEBICDG(this.resourceName);
		base.transform.Find("SpeedSlider").GetComponent<InputField>().text = this.resourceName;
		base.transform.Find("HiddenToggle").GetComponent<Image>().sprite = (Sprite)this.resource;
		base.transform.Find("ERROR: preview file name is empty in modName.workshop.json").GetComponent<Text>().text = this.resourceFile;
	}

	// Token: 0x0600E9E5 RID: 59877 RVA: 0x0052AD72 File Offset: 0x00528F72
	public void EKAAMBFENNM()
	{
		base.StartCoroutine(this.BNLAEGAHFPM());
	}

	// Token: 0x0600E9E6 RID: 59878 RVA: 0x00529F9F File Offset: 0x0052819F
	public void CAPLMPPEHHF(string LGHIPFAEONM)
	{
		this.resourceName = LGHIPFAEONM;
	}

	// Token: 0x0600E9E7 RID: 59879 RVA: 0x0052AD81 File Offset: 0x00528F81
	public void NKLNGGOHLMO(string LKHGHBMAFEL, string KFCPKFBCONE, UnityEngine.Object ACABBJEAMGG)
	{
		this.resourceName = LKHGHBMAFEL;
		this.resourceFile = KFCPKFBCONE;
		this.resource = ACABBJEAMGG;
		this.FLMBJPODCOH();
	}

	// Token: 0x0600E9E8 RID: 59880 RVA: 0x00529F9F File Offset: 0x0052819F
	public void UpdateID(string LGHIPFAEONM)
	{
		this.resourceName = LGHIPFAEONM;
	}

	// Token: 0x0600E9E9 RID: 59881 RVA: 0x0052ABD7 File Offset: 0x00528DD7
	public void LDKFAGOEDKF(string LKHGHBMAFEL, string KFCPKFBCONE, UnityEngine.Object ACABBJEAMGG)
	{
		this.resourceName = LKHGHBMAFEL;
		this.resourceFile = KFCPKFBCONE;
		this.resource = ACABBJEAMGG;
		this.BDKHAJPELCL();
	}

	// Token: 0x0600E9EA RID: 59882 RVA: 0x00529F9F File Offset: 0x0052819F
	public void HKEFJGFEKHF(string LGHIPFAEONM)
	{
		this.resourceName = LGHIPFAEONM;
	}

	// Token: 0x04001A5D RID: 6749
	[HideInInspector]
	public UnityEngine.Object resource;

	// Token: 0x04001A5E RID: 6750
	public string resourceName;

	// Token: 0x04001A5F RID: 6751
	public string resourceFile;
}
