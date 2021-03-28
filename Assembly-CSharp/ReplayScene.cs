using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020004F9 RID: 1273
public class ReplayScene : Scene
{
	// Token: 0x0601298B RID: 76171 RVA: 0x0067A3E1 File Offset: 0x006785E1
	public virtual void CCLNNLCOPBL()
	{
		base.MEBPBNLBECA();
		base.KAGHABABGCB(true);
	}

	// Token: 0x0601298C RID: 76172 RVA: 0x0067A3F0 File Offset: 0x006785F0
	public void CMNEEBEFBMC(string BNJFKKGOACF)
	{
		Debug.Log("float,0" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.PHOHPPPOMPE(BNJFKKGOACF, UnityEngine.Object.FindObjectOfType<FileSelector>().result, true, true);
		string text = UnityEngine.Object.FindObjectOfType<FileSelector>().result + "/../";
		base.StartCoroutine(Helpers.SaveFile(text, GameManager.BLNJDEEDEDJ((string)ResourcesManager.GetLoadedResource(BNJFKKGOACF)), false));
		MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
		string dagalcailln = "_Colored" + text;
		string mldackjmkmn = "Set sun emission (glow)";
		if (ReplayScene.LNIJKGECNME == null)
		{
			ReplayScene.LNIJKGECNME = new UnityAction(ReplayScene.EDFLOIENIJN);
		}
		instance.ALHLMBCOILP(dagalcailln, mldackjmkmn, ReplayScene.LNIJKGECNME, false, false, 278f);
	}

	// Token: 0x0601298D RID: 76173 RVA: 0x0002523B File Offset: 0x0002343B
	private static void FIPGMELLAMN()
	{
	}

	// Token: 0x0601298E RID: 76174 RVA: 0x0067A498 File Offset: 0x00678698
	public void HJGNOPFNGCG(string BNJFKKGOACF)
	{
		Debug.Log(". Using max value: 255." + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.PHOHPPPOMPE(BNJFKKGOACF, UnityEngine.Object.FindObjectOfType<FileSelector>().result, false, false);
		string text = UnityEngine.Object.FindObjectOfType<FileSelector>().result + "[Left]";
		base.StartCoroutine(Helpers.SaveFile(text, GameManager.JNPEKFHDAIG((string)ResourcesManager.KLNILBOBLIL(BNJFKKGOACF)), true));
		MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
		string dagalcailln = " not exist" + text;
		string mldackjmkmn = "_Value2";
		if (ReplayScene.LNIJKGECNME == null)
		{
			ReplayScene.LNIJKGECNME = new UnityAction(ReplayScene.JIAMFPAHBKB);
		}
		instance.CHBFDGFOLLL(dagalcailln, mldackjmkmn, ReplayScene.LNIJKGECNME, true, true, 703f);
	}

	// Token: 0x0601298F RID: 76175 RVA: 0x0067A53D File Offset: 0x0067873D
	public virtual void HMPGIFBJFIK()
	{
		base.FLKEJJEGCFA();
		base.KIJNHCEDOPE(true);
	}

	// Token: 0x06012990 RID: 76176 RVA: 0x0002523B File Offset: 0x0002343B
	private static void ELDFBIANPMD()
	{
	}

	// Token: 0x06012991 RID: 76177 RVA: 0x0067A54C File Offset: 0x0067874C
	public void FPDIHMHNAIE(string BNJFKKGOACF)
	{
		Debug.Log("CameraFilterPack/Drawing_NewCellShading" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.DOOMEMNGMEB(BNJFKKGOACF, UnityEngine.Object.FindObjectOfType<FileSelector>().result, false, false);
		string text = UnityEngine.Object.FindObjectOfType<FileSelector>().result + "player.crystal";
		base.StartCoroutine(Helpers.SaveFile(text, GameManager.EHJKPAKGJNA((string)ResourcesManager.HIILLNPNNOB(BNJFKKGOACF)), true));
		MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
		string dagalcailln = "CameraFilterPack/Blend2Camera_Lighten" + text;
		string mldackjmkmn = "R:";
		if (ReplayScene.LNIJKGECNME == null)
		{
			ReplayScene.LNIJKGECNME = new UnityAction(ReplayScene.DLNNBPAEFID);
		}
		instance.ANCIONGLJAC(dagalcailln, mldackjmkmn, ReplayScene.LNIJKGECNME, false, false, 685f);
	}

	// Token: 0x06012992 RID: 76178 RVA: 0x0002523B File Offset: 0x0002343B
	private static void EOMFEKMFJEK()
	{
	}

	// Token: 0x06012993 RID: 76179 RVA: 0x0067A5F4 File Offset: 0x006787F4
	public void JEHLDDMGBFB(string BNJFKKGOACF)
	{
		Debug.Log("achievements.21.completed.workshop." + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.DOOMEMNGMEB(BNJFKKGOACF, UnityEngine.Object.FindObjectOfType<FileSelector>().result, true, true);
		string text = UnityEngine.Object.FindObjectOfType<FileSelector>().result + "skin.hit_normal";
		base.StartCoroutine(Helpers.SaveFile(text, GameManager.FHOAAADFONG((string)ResourcesManager.OPIGIBCFLHE(BNJFKKGOACF)), false));
		MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
		string dagalcailln = "CameraFilterPack/Lut_TestMode" + text;
		string mldackjmkmn = "_Value4";
		if (ReplayScene.LNIJKGECNME == null)
		{
			ReplayScene.LNIJKGECNME = new UnityAction(ReplayScene.COHOKAEMADK);
		}
		instance.JCHNDBKFGFP(dagalcailln, mldackjmkmn, ReplayScene.LNIJKGECNME, false, true, 1336f);
	}

	// Token: 0x06012994 RID: 76180 RVA: 0x0067A699 File Offset: 0x00678899
	public override void FIKFJDFELIP()
	{
		base.ADPLHDFJFID();
		base.LICGKFKFJOF(true);
	}

	// Token: 0x06012995 RID: 76181 RVA: 0x0002523B File Offset: 0x0002343B
	private static void BGMBGFPLCPN()
	{
	}

	// Token: 0x06012996 RID: 76182 RVA: 0x0067A6A8 File Offset: 0x006788A8
	public void EDDOMNPDHAA(string BNJFKKGOACF)
	{
		Debug.Log("#" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.KKFGHHCDOBO(BNJFKKGOACF, UnityEngine.Object.FindObjectOfType<FileSelector>().result, false, true);
		string text = UnityEngine.Object.FindObjectOfType<FileSelector>().result + "PossibleMapMaxScoreText";
		base.StartCoroutine(Helpers.SaveFile(text, GameManager.EHJKPAKGJNA((string)ResourcesManager.PJALIBGIPPH(BNJFKKGOACF)), true));
		MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
		string dagalcailln = "<command>" + text;
		string mldackjmkmn = "_TimeX";
		if (ReplayScene.LNIJKGECNME == null)
		{
			ReplayScene.LNIJKGECNME = new UnityAction(ReplayScene.BBHLIOCPEPE);
		}
		instance.DisplayMessage(dagalcailln, mldackjmkmn, ReplayScene.LNIJKGECNME, true, true, 1842f);
	}

	// Token: 0x06012997 RID: 76183 RVA: 0x0002523B File Offset: 0x0002343B
	private static void CKMNMKNMOKP()
	{
	}

	// Token: 0x06012998 RID: 76184 RVA: 0x0002523B File Offset: 0x0002343B
	private static void JIAMFPAHBKB()
	{
	}

	// Token: 0x06012999 RID: 76185 RVA: 0x0067A750 File Offset: 0x00678950
	public void OpenReplayFile(string BNJFKKGOACF)
	{
		Debug.Log("[ReplayScene] Loading replay: " + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.LoadText(BNJFKKGOACF, UnityEngine.Object.FindObjectOfType<FileSelector>().result, true, false);
		string text = UnityEngine.Object.FindObjectOfType<FileSelector>().result + "_dec.json";
		base.StartCoroutine(Helpers.SaveFile(text, GameManager.Decrypt((string)ResourcesManager.GetLoadedResource(BNJFKKGOACF)), true));
		MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
		string dagalcailln = "Saved as: " + text;
		string mldackjmkmn = "ok";
		if (ReplayScene.LNIJKGECNME == null)
		{
			ReplayScene.LNIJKGECNME = new UnityAction(ReplayScene.INAJPJFLILM);
		}
		instance.DisplayMessage(dagalcailln, mldackjmkmn, ReplayScene.LNIJKGECNME, true, false, 0f);
	}

	// Token: 0x0601299A RID: 76186 RVA: 0x0067A7F5 File Offset: 0x006789F5
	public virtual void NCNPAKFAFOE()
	{
		base.CFFCLAHMBAA();
		base.GFNINHCBMAN(false);
	}

	// Token: 0x0601299B RID: 76187 RVA: 0x0067A804 File Offset: 0x00678A04
	public virtual void IMCKJCHKMKB()
	{
		base.KDMANOEMOCA();
		base.LICGKFKFJOF(true);
	}

	// Token: 0x0601299C RID: 76188 RVA: 0x0067A813 File Offset: 0x00678A13
	public virtual void BMIOFJFMCBG()
	{
		base.MDNHCLKNCLE();
		base.OAIIEOHOKGJ(true);
	}

	// Token: 0x0601299E RID: 76190 RVA: 0x0067A82A File Offset: 0x00678A2A
	public override void BEBNOKFLJPH()
	{
		base.JFJLGJEPEAA();
		base.PJHICJBICHE(false);
	}

	// Token: 0x0601299F RID: 76191 RVA: 0x0067A839 File Offset: 0x00678A39
	public virtual void PAKPHKPDKGE()
	{
		base.MKIMDFLBFOM();
		base.JDONOMPKEED(true);
	}

	// Token: 0x060129A0 RID: 76192 RVA: 0x0067A848 File Offset: 0x00678A48
	public override void EPEGAEGDJAM()
	{
		base.KLILJHJNICK();
		base.NCJKEKHBFHA(true);
	}

	// Token: 0x060129A1 RID: 76193 RVA: 0x0067A858 File Offset: 0x00678A58
	public void HPLAMMJKIDH(string BNJFKKGOACF)
	{
		Debug.Log("Hidden/Image Effects/Cinematic/MotionBlur/Reconstruction" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.PHOHPPPOMPE(BNJFKKGOACF, UnityEngine.Object.FindObjectOfType<FileSelector>().result, true, false);
		string text = UnityEngine.Object.FindObjectOfType<FileSelector>().result + "bad";
		base.StartCoroutine(Helpers.SaveFile(text, GameManager.JNPEKFHDAIG((string)ResourcesManager.GetLoadedResource(BNJFKKGOACF)), false));
		MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
		string dagalcailln = "SetSpeed" + text;
		string mldackjmkmn = "LetterSpacing: Missing Text component";
		if (ReplayScene.LNIJKGECNME == null)
		{
			ReplayScene.LNIJKGECNME = new UnityAction(ReplayScene.DINOJLNEILI);
		}
		instance.AGMKJJLMOHG(dagalcailln, mldackjmkmn, ReplayScene.LNIJKGECNME, true, false, 182f);
	}

	// Token: 0x060129A2 RID: 76194 RVA: 0x0002523B File Offset: 0x0002343B
	private static void BBHLIOCPEPE()
	{
	}

	// Token: 0x060129A3 RID: 76195 RVA: 0x0002523B File Offset: 0x0002343B
	private static void BOKGJFLJLMN()
	{
	}

	// Token: 0x060129A4 RID: 76196 RVA: 0x0067A8FD File Offset: 0x00678AFD
	public virtual void HLIAEEMGBHN()
	{
		base.FLKEJJEGCFA();
		base.ALAJMFBMENK(false);
	}

	// Token: 0x060129A5 RID: 76197 RVA: 0x0067A90C File Offset: 0x00678B0C
	public virtual void EGEPLFGKGLI()
	{
		base.MEBPBNLBECA();
		base.LICGKFKFJOF(false);
	}

	// Token: 0x060129A6 RID: 76198 RVA: 0x0002523B File Offset: 0x0002343B
	[CompilerGenerated]
	private static void INAJPJFLILM()
	{
	}

	// Token: 0x060129A7 RID: 76199 RVA: 0x0067A91C File Offset: 0x00678B1C
	public void AFGGEGMMKLI(string BNJFKKGOACF)
	{
		Debug.Log("Horizontal" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.OFAELGIDIDE(BNJFKKGOACF, UnityEngine.Object.FindObjectOfType<FileSelector>().result, true, false);
		string text = UnityEngine.Object.FindObjectOfType<FileSelector>().result + "_ScreenResolution";
		base.StartCoroutine(Helpers.SaveFile(text, GameManager.JNPEKFHDAIG((string)ResourcesManager.PJALIBGIPPH(BNJFKKGOACF)), true));
		MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
		string dagalcailln = "_Value2" + text;
		string mldackjmkmn = "CameraFilterPack/FX_Funk";
		if (ReplayScene.LNIJKGECNME == null)
		{
			ReplayScene.LNIJKGECNME = new UnityAction(ReplayScene.CKMNMKNMOKP);
		}
		instance.AGMKJJLMOHG(dagalcailln, mldackjmkmn, ReplayScene.LNIJKGECNME, true, false, 967f);
	}

	// Token: 0x060129A8 RID: 76200 RVA: 0x0067A9C4 File Offset: 0x00678BC4
	public void CLGNKEAIPPC(string BNJFKKGOACF)
	{
		Debug.Log("_Jitter" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.BJIDLJJJCJB(BNJFKKGOACF, UnityEngine.Object.FindObjectOfType<FileSelector>().result, true, true);
		string text = UnityEngine.Object.FindObjectOfType<FileSelector>().result + "_Value";
		base.StartCoroutine(Helpers.SaveFile(text, GameManager.BLNJDEEDEDJ((string)ResourcesManager.KLNILBOBLIL(BNJFKKGOACF)), true));
		MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
		string dagalcailln = "_TimeX" + text;
		string mldackjmkmn = "CameraFilterPack/Blend2Camera_LighterColor";
		if (ReplayScene.LNIJKGECNME == null)
		{
			ReplayScene.LNIJKGECNME = new UnityAction(ReplayScene.JIAMFPAHBKB);
		}
		instance.ANCIONGLJAC(dagalcailln, mldackjmkmn, ReplayScene.LNIJKGECNME, true, true, 1106f);
	}

	// Token: 0x060129A9 RID: 76201 RVA: 0x0067AA69 File Offset: 0x00678C69
	public virtual void IHLMNAGPKDA()
	{
		base.CFFCLAHMBAA();
		base.LICGKFKFJOF(false);
	}

	// Token: 0x060129AA RID: 76202 RVA: 0x0002523B File Offset: 0x0002343B
	private static void NDCHMAEJENP()
	{
	}

	// Token: 0x060129AB RID: 76203 RVA: 0x0067AA78 File Offset: 0x00678C78
	public void GJKPMMPFLEJ(string BNJFKKGOACF)
	{
		Debug.Log("/../" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.OFAELGIDIDE(BNJFKKGOACF, UnityEngine.Object.FindObjectOfType<FileSelector>().result, true, true);
		string text = UnityEngine.Object.FindObjectOfType<FileSelector>().result + "_Value";
		base.StartCoroutine(Helpers.SaveFile(text, GameManager.JJNLMGPCNAA((string)ResourcesManager.HIILLNPNNOB(BNJFKKGOACF)), true));
		MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
		string dagalcailln = "AudioSampler" + text;
		string mldackjmkmn = "action";
		if (ReplayScene.LNIJKGECNME == null)
		{
			ReplayScene.LNIJKGECNME = new UnityAction(ReplayScene.MHPEDEPFEAK);
		}
		instance.ALHLMBCOILP(dagalcailln, mldackjmkmn, ReplayScene.LNIJKGECNME, false, true, 590f);
	}

	// Token: 0x060129AC RID: 76204 RVA: 0x0002523B File Offset: 0x0002343B
	private static void COHOKAEMADK()
	{
	}

	// Token: 0x060129AD RID: 76205 RVA: 0x0002523B File Offset: 0x0002343B
	private static void EDFLOIENIJN()
	{
	}

	// Token: 0x060129AE RID: 76206 RVA: 0x0002523B File Offset: 0x0002343B
	private static void MHPEDEPFEAK()
	{
	}

	// Token: 0x060129AF RID: 76207 RVA: 0x0002523B File Offset: 0x0002343B
	private static void DCJNBBGHHKD()
	{
	}

	// Token: 0x060129B0 RID: 76208 RVA: 0x0067AB1D File Offset: 0x00678D1D
	public override void Start()
	{
		base.Start();
		base.ShowCursor(true);
	}

	// Token: 0x060129B1 RID: 76209 RVA: 0x0002523B File Offset: 0x0002343B
	private static void DLNNBPAEFID()
	{
	}

	// Token: 0x060129B2 RID: 76210 RVA: 0x0002523B File Offset: 0x0002343B
	private static void HOJIGCDBDEF()
	{
	}

	// Token: 0x060129B3 RID: 76211 RVA: 0x0067AB2C File Offset: 0x00678D2C
	public virtual void FEHCNJLLJMP()
	{
		base.MDNHCLKNCLE();
		base.IDCJMKMMGJA(false);
	}

	// Token: 0x060129B4 RID: 76212 RVA: 0x0002523B File Offset: 0x0002343B
	private static void DINOJLNEILI()
	{
	}

	// Token: 0x060129B5 RID: 76213 RVA: 0x0067AB3C File Offset: 0x00678D3C
	public void NGKJFIFEFDM(string BNJFKKGOACF)
	{
		Debug.Log("_Level" + BNJFKKGOACF);
		Singleton<ResourcesManager>.Instance.OFAELGIDIDE(BNJFKKGOACF, UnityEngine.Object.FindObjectOfType<FileSelector>().result, true, false);
		string text = UnityEngine.Object.FindObjectOfType<FileSelector>().result + "_Parasite";
		base.StartCoroutine(Helpers.SaveFile(text, GameManager.Decrypt((string)ResourcesManager.KLNILBOBLIL(BNJFKKGOACF)), true));
		MessageBoxPanel instance = Singleton<MessageBoxPanel>.Instance;
		string dagalcailln = "CameraFilterPack_OldFilm1" + text;
		string mldackjmkmn = "InfoText";
		if (ReplayScene.LNIJKGECNME == null)
		{
			ReplayScene.LNIJKGECNME = new UnityAction(ReplayScene.BBHLIOCPEPE);
		}
		instance.JCHNDBKFGFP(dagalcailln, mldackjmkmn, ReplayScene.LNIJKGECNME, true, false, 1194f);
	}

	// Token: 0x040020D5 RID: 8405
	public GameObject selector;

	// Token: 0x040020D6 RID: 8406
	public GameObject text;

	// Token: 0x040020D7 RID: 8407
	[CompilerGenerated]
	private static UnityAction LNIJKGECNME;
}
