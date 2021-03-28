using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Audio;

// Token: 0x02000479 RID: 1145
public class VolumeSettings : MonoBehaviour
{
	// Token: 0x0601073E RID: 67390 RVA: 0x00597004 File Offset: 0x00595204
	public float ECDGHHKPIHL()
	{
		float hdamkjknkji = 837f;
		this.audioMixer.GetFloat("_Offsets", out hdamkjknkji);
		return this.DPCLFKCHLNP(hdamkjknkji);
	}

	// Token: 0x0601073F RID: 67391 RVA: 0x00597034 File Offset: 0x00595234
	public float IHHOIGPOOBJ()
	{
		float hdamkjknkji = 1533f;
		this.audioMixer.GetFloat("OK", out hdamkjknkji);
		return this.CGGEOGNGBDJ(hdamkjknkji);
	}

	// Token: 0x06010740 RID: 67392 RVA: 0x00597061 File Offset: 0x00595261
	public void SetMenuVolume(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("menuVolume", this.NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("settings.volume.menu", BDICHAELIJE, null);
	}

	// Token: 0x06010741 RID: 67393 RVA: 0x0059708C File Offset: 0x0059528C
	public void HPILGNAEANG(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("Alternative", this.NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("OpSettings()", BDICHAELIJE, null);
	}

	// Token: 0x06010742 RID: 67394 RVA: 0x005970B8 File Offset: 0x005952B8
	public float FIECFKKJNBN()
	{
		float hdamkjknkji = 1506f;
		this.audioMixer.GetFloat("isVisible", out hdamkjknkji);
		return this.FKMNHPFAKOG(hdamkjknkji);
	}

	// Token: 0x06010743 RID: 67395 RVA: 0x005970E5 File Offset: 0x005952E5
	public float FKMNHPFAKOG(float HDAMKJKNKJI)
	{
		return Mathf.Pow(652f, HDAMKJKNKJI / 362f);
	}

	// Token: 0x06010744 RID: 67396 RVA: 0x005970F8 File Offset: 0x005952F8
	private IEnumerator CFOHMCKDELP()
	{
		if (VolumeSettings.PBLBJJCPCME.LNIJKGECNME == null)
		{
			VolumeSettings.PBLBJJCPCME.LNIJKGECNME = new Func<bool>(VolumeSettings.PBLBJJCPCME.GBKBDKHPLKG);
		}
		yield return new WaitUntil(VolumeSettings.PBLBJJCPCME.LNIJKGECNME);
		this.SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f, null));
		this.SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f, null));
		this.SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f, null));
		this.SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f, null));
		yield break;
	}

	// Token: 0x06010745 RID: 67397 RVA: 0x00597113 File Offset: 0x00595313
	public void JKFDDNMPOJH()
	{
		base.StartCoroutine(this.IAIAPPPLMPA());
	}

	// Token: 0x06010746 RID: 67398 RVA: 0x00597124 File Offset: 0x00595324
	public float LDAJBKIDLLG()
	{
		float hdamkjknkji = 376f;
		this.audioMixer.GetFloat("[ResourcesManager] Load image error: ", out hdamkjknkji);
		return this.DIGIPEPHEKJ(hdamkjknkji);
	}

	// Token: 0x06010747 RID: 67399 RVA: 0x00597154 File Offset: 0x00595354
	public float KICALMOMCBM()
	{
		float hdamkjknkji = 1250f;
		this.audioMixer.GetFloat("#close", out hdamkjknkji);
		return this.DPCLFKCHLNP(hdamkjknkji);
	}

	// Token: 0x06010748 RID: 67400 RVA: 0x00597181 File Offset: 0x00595381
	public void IFPPBHNPHJK(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("Items/", this.NGMEOMJBBPC(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.CBIEBMGENJH("<size=24>", BDICHAELIJE, null);
	}

	// Token: 0x06010749 RID: 67401 RVA: 0x005971AC File Offset: 0x005953AC
	public float CFEMEENOBNH()
	{
		float hdamkjknkji = 112f;
		this.audioMixer.GetFloat("settings.enableranking", out hdamkjknkji);
		return this.DPCLFKCHLNP(hdamkjknkji);
	}

	// Token: 0x0601074A RID: 67402 RVA: 0x005971DC File Offset: 0x005953DC
	public float GetSfxVolume()
	{
		float hdamkjknkji = 0f;
		this.audioMixer.GetFloat("sfxVolume", out hdamkjknkji);
		return this.DbToNormal(hdamkjknkji);
	}

	// Token: 0x0601074B RID: 67403 RVA: 0x0059720C File Offset: 0x0059540C
	private IEnumerator NGGODCJPIEM()
	{
		if (VolumeSettings.PBLBJJCPCME.LNIJKGECNME == null)
		{
			VolumeSettings.PBLBJJCPCME.LNIJKGECNME = new Func<bool>(VolumeSettings.PBLBJJCPCME.GBKBDKHPLKG);
		}
		yield return new WaitUntil(VolumeSettings.PBLBJJCPCME.LNIJKGECNME);
		this.SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f, null));
		this.SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f, null));
		this.SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f, null));
		this.SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f, null));
		yield break;
	}

	// Token: 0x0601074C RID: 67404 RVA: 0x00597227 File Offset: 0x00595427
	public void NKJNCMJDHKP(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("/", this.ABKGDNMBAMH(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("\"", BDICHAELIJE, null);
	}

	// Token: 0x0601074D RID: 67405 RVA: 0x00597254 File Offset: 0x00595454
	public float GetMenuVolume()
	{
		float hdamkjknkji = 0f;
		this.audioMixer.GetFloat("menuVolume", out hdamkjknkji);
		return this.DbToNormal(hdamkjknkji);
	}

	// Token: 0x0601074E RID: 67406 RVA: 0x00597281 File Offset: 0x00595481
	public void HOMCHEPLHGM(float BDICHAELIJE)
	{
		this.BKJMEFKAOPJ(BDICHAELIJE);
		this.FACFNHLMGCN(BDICHAELIJE);
	}

	// Token: 0x0601074F RID: 67407 RVA: 0x00597294 File Offset: 0x00595494
	public float EFFFFENIICI()
	{
		float hdamkjknkji = 850f;
		this.audioMixer.GetFloat("_Value3", out hdamkjknkji);
		return this.MLODONCDFIJ(hdamkjknkji);
	}

	// Token: 0x06010750 RID: 67408 RVA: 0x005972C4 File Offset: 0x005954C4
	public float PPABBFAILDD()
	{
		float hdamkjknkji = 193f;
		this.audioMixer.GetFloat(" to ", out hdamkjknkji);
		return this.CGGEOGNGBDJ(hdamkjknkji);
	}

	// Token: 0x06010751 RID: 67409 RVA: 0x005972F4 File Offset: 0x005954F4
	public float OMJIEHMMFLN()
	{
		float hdamkjknkji = 1717f;
		this.audioMixer.GetFloat(".played", out hdamkjknkji);
		return this.MLJFBJLBHDL(hdamkjknkji);
	}

	// Token: 0x06010752 RID: 67410 RVA: 0x00597324 File Offset: 0x00595524
	public float JOJADIFKCDO()
	{
		float hdamkjknkji = 645f;
		this.audioMixer.GetFloat("event", out hdamkjknkji);
		return this.BFAFNHBBADH(hdamkjknkji);
	}

	// Token: 0x06010753 RID: 67411 RVA: 0x00597351 File Offset: 0x00595551
	public float CKBPLJGCLPH(float HDAMKJKNKJI)
	{
		return Mathf.Pow(1647f, HDAMKJKNKJI / 44f);
	}

	// Token: 0x06010754 RID: 67412 RVA: 0x00597364 File Offset: 0x00595564
	public void EEEHGFKAGOO(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("_TimeX", this.NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.EIAJOEAPEJO("ConfigVersionSlider", BDICHAELIJE, null);
	}

	// Token: 0x06010755 RID: 67413 RVA: 0x0059738F File Offset: 0x0059558F
	public void JJFDDNOMCMO(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("CurrentTimeLabel", this.FFGKOFGAEHI(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("_ScreenResolution", BDICHAELIJE, null);
	}

	// Token: 0x06010756 RID: 67414 RVA: 0x005973BA File Offset: 0x005955BA
	public void INEIPFBFJAA(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("_CenterX", this.JBJMLECCBBN(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("_Offsets", BDICHAELIJE, null);
	}

	// Token: 0x06010757 RID: 67415 RVA: 0x005973E5 File Offset: 0x005955E5
	public void MNNLCHOIKIO(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("ENABLE_EYE_ADAPTATION", this.ABKGDNMBAMH(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.EIAJOEAPEJO(":", BDICHAELIJE, null);
	}

	// Token: 0x06010758 RID: 67416 RVA: 0x00597410 File Offset: 0x00595610
	public void IFKGBBEDHLG(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("_TimeX", this.JBJMLECCBBN(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.EIAJOEAPEJO("Out {0,4} | In {1,4} | Sum {2,4}", BDICHAELIJE, null);
	}

	// Token: 0x06010759 RID: 67417 RVA: 0x0059743B File Offset: 0x0059563B
	public float CCADDADHJPM(float HDAMKJKNKJI)
	{
		return Mathf.Pow(636f, HDAMKJKNKJI / 772f);
	}

	// Token: 0x0601075A RID: 67418 RVA: 0x0059744E File Offset: 0x0059564E
	public void SetGameVolume(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("gameVolume", this.NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("settings.volume.game", BDICHAELIJE, null);
	}

	// Token: 0x0601075B RID: 67419 RVA: 0x00597479 File Offset: 0x00595679
	public void MGPDAHIAMAO(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("PublishButton", this.JBJMLECCBBN(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("_Offset", BDICHAELIJE, null);
	}

	// Token: 0x0601075C RID: 67420 RVA: 0x005974A4 File Offset: 0x005956A4
	public float GAAOHHOOEBG(float JCLIHOKDOHN)
	{
		return (JCLIHOKDOHN <= 148f) ? 1621f : (324f * Mathf.Log10(JCLIHOKDOHN));
	}

	// Token: 0x0601075D RID: 67421 RVA: 0x005974C8 File Offset: 0x005956C8
	public float GEDFCIIBDIN()
	{
		float hdamkjknkji = 1511f;
		this.audioMixer.GetFloat("/", out hdamkjknkji);
		return this.CCADDADHJPM(hdamkjknkji);
	}

	// Token: 0x0601075E RID: 67422 RVA: 0x005974F5 File Offset: 0x005956F5
	public void HEHHKHALIHG(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("SetSunEmission", this.GAAOHHOOEBG(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("CONTRAST", BDICHAELIJE, null);
	}

	// Token: 0x0601075F RID: 67423 RVA: 0x00597520 File Offset: 0x00595720
	public void DAHFFNNIGML()
	{
		base.StartCoroutine(this.LAMOIKFHHHJ());
	}

	// Token: 0x06010760 RID: 67424 RVA: 0x00597530 File Offset: 0x00595730
	public float FHJGNHCFOIF()
	{
		float hdamkjknkji = 1262f;
		this.audioMixer.GetFloat("Sprite", out hdamkjknkji);
		return this.CKBPLJGCLPH(hdamkjknkji);
	}

	// Token: 0x06010761 RID: 67425 RVA: 0x0059755D File Offset: 0x0059575D
	public float NormalToDb(float JCLIHOKDOHN)
	{
		return (JCLIHOKDOHN <= 0f) ? -80f : (20f * Mathf.Log10(JCLIHOKDOHN));
	}

	// Token: 0x06010762 RID: 67426 RVA: 0x00597580 File Offset: 0x00595780
	public void KOFGJFEEHAM(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("CameraFilterPack/Blend2Camera_Darken", this.FFGKOFGAEHI(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("_Axis", BDICHAELIJE, null);
	}

	// Token: 0x06010763 RID: 67427 RVA: 0x005975AB File Offset: 0x005957AB
	public void GPDHJMBCFBE(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("Set particles gravity", this.JBJMLECCBBN(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("PenaltyScoreText", BDICHAELIJE, null);
	}

	// Token: 0x06010764 RID: 67428 RVA: 0x005975D8 File Offset: 0x005957D8
	public float GetEditorVolume()
	{
		float hdamkjknkji = 0f;
		this.audioMixer.GetFloat("editorVolume", out hdamkjknkji);
		return this.DbToNormal(hdamkjknkji);
	}

	// Token: 0x06010765 RID: 67429 RVA: 0x00597605 File Offset: 0x00595805
	public void SetSfxVolume(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("sfxVolume", this.NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("settings.volume.sfx", BDICHAELIJE, null);
	}

	// Token: 0x06010766 RID: 67430 RVA: 0x00597630 File Offset: 0x00595830
	public float GOHMKLBMBLB()
	{
		float hdamkjknkji = 373f;
		this.audioMixer.GetFloat("_TimeX", out hdamkjknkji);
		return this.CGGEOGNGBDJ(hdamkjknkji);
	}

	// Token: 0x06010767 RID: 67431 RVA: 0x0059765D File Offset: 0x0059585D
	public float MLODONCDFIJ(float HDAMKJKNKJI)
	{
		return Mathf.Pow(873f, HDAMKJKNKJI / 1100f);
	}

	// Token: 0x06010768 RID: 67432 RVA: 0x00597670 File Offset: 0x00595870
	public void IDMPNIJDPEI(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("_TimeX", this.FFGKOFGAEHI(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.EIAJOEAPEJO("_Value2", BDICHAELIJE, null);
	}

	// Token: 0x06010769 RID: 67433 RVA: 0x0059769B File Offset: 0x0059589B
	public void KCJDHLKCKGL(float BDICHAELIJE)
	{
		this.BKJMEFKAOPJ(BDICHAELIJE);
		this.EEEHGFKAGOO(BDICHAELIJE);
	}

	// Token: 0x0601076A RID: 67434 RVA: 0x005976AC File Offset: 0x005958AC
	private IEnumerator HFJNINPHOJN()
	{
		if (VolumeSettings.PBLBJJCPCME.LNIJKGECNME == null)
		{
			VolumeSettings.PBLBJJCPCME.LNIJKGECNME = new Func<bool>(VolumeSettings.PBLBJJCPCME.GBKBDKHPLKG);
		}
		yield return new WaitUntil(VolumeSettings.PBLBJJCPCME.LNIJKGECNME);
		this.SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f, null));
		this.SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f, null));
		this.SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f, null));
		this.SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f, null));
		yield break;
	}

	// Token: 0x0601076B RID: 67435 RVA: 0x005976C7 File Offset: 0x005958C7
	public void JCFEBDEIMLD(float BDICHAELIJE)
	{
		this.PMJKKGACEBF(BDICHAELIJE);
		this.SetGameVolume(BDICHAELIJE);
	}

	// Token: 0x0601076C RID: 67436 RVA: 0x005976D7 File Offset: 0x005958D7
	public void PNKIOJIKKEG(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("menu.enableselectormusic", this.NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("-help", BDICHAELIJE, null);
	}

	// Token: 0x0601076D RID: 67437 RVA: 0x00597704 File Offset: 0x00595904
	public float FMFHKNLFIJK()
	{
		float hdamkjknkji = 1475f;
		this.audioMixer.GetFloat("CameraFilterPack/Oculus_ThermaVision", out hdamkjknkji);
		return this.MJBMIGAKAMK(hdamkjknkji);
	}

	// Token: 0x0601076E RID: 67438 RVA: 0x00597731 File Offset: 0x00595931
	public void ODCPLPJLHKA(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("Case-Sensitive", this.ABKGDNMBAMH(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("CameraFilterPack/Blend2Camera_LinearBurn", BDICHAELIJE, null);
	}

	// Token: 0x0601076F RID: 67439 RVA: 0x00597113 File Offset: 0x00595313
	public void HMPGIFBJFIK()
	{
		base.StartCoroutine(this.IAIAPPPLMPA());
	}

	// Token: 0x06010770 RID: 67440 RVA: 0x0059775C File Offset: 0x0059595C
	public float JBJMLECCBBN(float JCLIHOKDOHN)
	{
		return (JCLIHOKDOHN <= 1865f) ? 438f : (1600f * Mathf.Log10(JCLIHOKDOHN));
	}

	// Token: 0x06010771 RID: 67441 RVA: 0x0059777F File Offset: 0x0059597F
	public void BAFOCDHHCBA(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("IconImage", this.GAAOHHOOEBG(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("/", BDICHAELIJE, null);
	}

	// Token: 0x06010772 RID: 67442 RVA: 0x005977AA File Offset: 0x005959AA
	public void EGIPGJNAPHA(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("_Near", this.NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("_Value3", BDICHAELIJE, null);
	}

	// Token: 0x06010773 RID: 67443 RVA: 0x005977D8 File Offset: 0x005959D8
	public float EFPGNKOPEDF()
	{
		float hdamkjknkji = 1597f;
		this.audioMixer.GetFloat("MAPS NOT FOUND", out hdamkjknkji);
		return this.FKMNHPFAKOG(hdamkjknkji);
	}

	// Token: 0x06010774 RID: 67444 RVA: 0x00597805 File Offset: 0x00595A05
	public float DbToNormal(float HDAMKJKNKJI)
	{
		return Mathf.Pow(10f, HDAMKJKNKJI / 20f);
	}

	// Token: 0x06010775 RID: 67445 RVA: 0x00597818 File Offset: 0x00595A18
	private IEnumerator IAIAPPPLMPA()
	{
		if (VolumeSettings.PBLBJJCPCME.LNIJKGECNME == null)
		{
			VolumeSettings.PBLBJJCPCME.LNIJKGECNME = new Func<bool>(VolumeSettings.PBLBJJCPCME.GBKBDKHPLKG);
		}
		yield return new WaitUntil(VolumeSettings.PBLBJJCPCME.LNIJKGECNME);
		this.SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f, null));
		this.SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f, null));
		this.SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f, null));
		this.SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f, null));
		yield break;
	}

	// Token: 0x06010776 RID: 67446 RVA: 0x00597834 File Offset: 0x00595A34
	private IEnumerator LAMOIKFHHHJ()
	{
		if (VolumeSettings.PBLBJJCPCME.LNIJKGECNME == null)
		{
			VolumeSettings.PBLBJJCPCME.LNIJKGECNME = new Func<bool>(VolumeSettings.PBLBJJCPCME.GBKBDKHPLKG);
		}
		yield return new WaitUntil(VolumeSettings.PBLBJJCPCME.LNIJKGECNME);
		this.SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f, null));
		this.SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f, null));
		this.SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f, null));
		this.SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f, null));
		yield break;
	}

	// Token: 0x06010777 RID: 67447 RVA: 0x00597850 File Offset: 0x00595A50
	public float GLJFOEIBBFH()
	{
		float hdamkjknkji = 44f;
		this.audioMixer.GetFloat("menu.playedsolo", out hdamkjknkji);
		return this.MLODONCDFIJ(hdamkjknkji);
	}

	// Token: 0x06010778 RID: 67448 RVA: 0x0059787D File Offset: 0x00595A7D
	public float DIGIPEPHEKJ(float HDAMKJKNKJI)
	{
		return Mathf.Pow(831f, HDAMKJKNKJI / 882f);
	}

	// Token: 0x06010779 RID: 67449 RVA: 0x00597890 File Offset: 0x00595A90
	public float DHNJELPHPJO()
	{
		float hdamkjknkji = 1260f;
		this.audioMixer.GetFloat("curScn", out hdamkjknkji);
		return this.DbToNormal(hdamkjknkji);
	}

	// Token: 0x0601077A RID: 67450 RVA: 0x005978BD File Offset: 0x00595ABD
	public void LEACKAPKDAD(float BDICHAELIJE)
	{
		this.ODCPLPJLHKA(BDICHAELIJE);
		this.INEIPFBFJAA(BDICHAELIJE);
	}

	// Token: 0x0601077B RID: 67451 RVA: 0x005978D0 File Offset: 0x00595AD0
	private IEnumerator NCLNAMDDBNP()
	{
		if (VolumeSettings.PBLBJJCPCME.LNIJKGECNME == null)
		{
			VolumeSettings.PBLBJJCPCME.LNIJKGECNME = new Func<bool>(VolumeSettings.PBLBJJCPCME.GBKBDKHPLKG);
		}
		yield return new WaitUntil(VolumeSettings.PBLBJJCPCME.LNIJKGECNME);
		this.SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f, null));
		this.SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f, null));
		this.SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f, null));
		this.SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f, null));
		yield break;
	}

	// Token: 0x0601077C RID: 67452 RVA: 0x005978EB File Offset: 0x00595AEB
	public void PEINHNPAGGA(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("[Right]", this.NGMEOMJBBPC(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.CBIEBMGENJH("JoinOrCreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", BDICHAELIJE, null);
	}

	// Token: 0x0601077D RID: 67453 RVA: 0x00597918 File Offset: 0x00595B18
	public float DANFCBNABEG()
	{
		float hdamkjknkji = 284f;
		this.audioMixer.GetFloat("settings.shaders", out hdamkjknkji);
		return this.HOMOCCLHMDA(hdamkjknkji);
	}

	// Token: 0x0601077E RID: 67454 RVA: 0x00597945 File Offset: 0x00595B45
	public void PFIKHNLPJMJ(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("RarityImage", this.NGMEOMJBBPC(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("_Value", BDICHAELIJE, null);
	}

	// Token: 0x0601077F RID: 67455 RVA: 0x00597970 File Offset: 0x00595B70
	public void DNNFHBOOPIN()
	{
		base.StartCoroutine(this.DLBBADHEGID());
	}

	// Token: 0x06010780 RID: 67456 RVA: 0x0059797F File Offset: 0x00595B7F
	public void GAPGDIMNNMM(float BDICHAELIJE)
	{
		this.ODCPLPJLHKA(BDICHAELIJE);
		this.GGPENMLKGFL(BDICHAELIJE);
	}

	// Token: 0x06010781 RID: 67457 RVA: 0x0059798F File Offset: 0x00595B8F
	public void OEAFOPCOBBH(float BDICHAELIJE)
	{
		this.LJPCPCKALJI(BDICHAELIJE);
		this.EEEHGFKAGOO(BDICHAELIJE);
	}

	// Token: 0x06010782 RID: 67458 RVA: 0x00597113 File Offset: 0x00595313
	public void Start()
	{
		base.StartCoroutine(this.IAIAPPPLMPA());
	}

	// Token: 0x06010783 RID: 67459 RVA: 0x0059799F File Offset: 0x00595B9F
	public void LCIFMHINMEP(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat(".lastCheckpoint.incorrectScore", this.NGMEOMJBBPC(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("maps.", BDICHAELIJE, null);
	}

	// Token: 0x06010784 RID: 67460 RVA: 0x005979CA File Offset: 0x00595BCA
	public void BILBPDFEMOL(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("Image", this.JBJMLECCBBN(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("_Value2", BDICHAELIJE, null);
	}

	// Token: 0x06010785 RID: 67461 RVA: 0x005979F8 File Offset: 0x00595BF8
	public float EINADGLCNHM()
	{
		float hdamkjknkji = 1677f;
		this.audioMixer.GetFloat("float,0.5", out hdamkjknkji);
		return this.CGGEOGNGBDJ(hdamkjknkji);
	}

	// Token: 0x06010786 RID: 67462 RVA: 0x00597A25 File Offset: 0x00595C25
	public void NHHDJPHCIKD(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("RateButton", this.JBJMLECCBBN(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.EIAJOEAPEJO("_ReflectionBlur", BDICHAELIJE, null);
	}

	// Token: 0x06010787 RID: 67463 RVA: 0x00597A50 File Offset: 0x00595C50
	public void KNLHOPGCGBB(float BDICHAELIJE)
	{
		this.BMCOFKEEEFO(BDICHAELIJE);
		this.GGPENMLKGFL(BDICHAELIJE);
	}

	// Token: 0x06010788 RID: 67464 RVA: 0x00597A60 File Offset: 0x00595C60
	private IEnumerator HIGLLOJDCCB()
	{
		if (VolumeSettings.PBLBJJCPCME.LNIJKGECNME == null)
		{
			VolumeSettings.PBLBJJCPCME.LNIJKGECNME = new Func<bool>(VolumeSettings.PBLBJJCPCME.GBKBDKHPLKG);
		}
		yield return new WaitUntil(VolumeSettings.PBLBJJCPCME.LNIJKGECNME);
		this.SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f, null));
		this.SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f, null));
		this.SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f, null));
		this.SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f, null));
		yield break;
	}

	// Token: 0x06010789 RID: 67465 RVA: 0x00597A7B File Offset: 0x00595C7B
	public void FBEPKICCAEE(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("_Value", this.JBJMLECCBBN(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("_Value4", BDICHAELIJE, null);
	}

	// Token: 0x0601078A RID: 67466 RVA: 0x00597AA6 File Offset: 0x00595CA6
	public void PMJKKGACEBF(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("_MainTex2", this.NGMEOMJBBPC(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("GLITCH", BDICHAELIJE, null);
	}

	// Token: 0x0601078B RID: 67467 RVA: 0x00597AD1 File Offset: 0x00595CD1
	public float ABKGDNMBAMH(float JCLIHOKDOHN)
	{
		return (JCLIHOKDOHN <= 1844f) ? 1852f : (464f * Mathf.Log10(JCLIHOKDOHN));
	}

	// Token: 0x0601078C RID: 67468 RVA: 0x00597AF4 File Offset: 0x00595CF4
	public float MLJFBJLBHDL(float HDAMKJKNKJI)
	{
		return Mathf.Pow(1723f, HDAMKJKNKJI / 479f);
	}

	// Token: 0x0601078D RID: 67469 RVA: 0x00597B07 File Offset: 0x00595D07
	public float MJBMIGAKAMK(float HDAMKJKNKJI)
	{
		return Mathf.Pow(1713f, HDAMKJKNKJI / 1448f);
	}

	// Token: 0x0601078E RID: 67470 RVA: 0x00597B1A File Offset: 0x00595D1A
	public float HOMOCCLHMDA(float HDAMKJKNKJI)
	{
		return Mathf.Pow(779f, HDAMKJKNKJI / 1196f);
	}

	// Token: 0x0601078F RID: 67471 RVA: 0x00597B2D File Offset: 0x00595D2D
	public void LECBMDDHMOH(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("#ok", this.GAAOHHOOEBG(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("[SERVER] Player ", BDICHAELIJE, null);
	}

	// Token: 0x06010790 RID: 67472 RVA: 0x00597B58 File Offset: 0x00595D58
	public void SetEditorVolume(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("editorVolume", this.NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("settings.volume.editor", BDICHAELIJE, null);
	}

	// Token: 0x06010791 RID: 67473 RVA: 0x00597B83 File Offset: 0x00595D83
	public float DPCLFKCHLNP(float HDAMKJKNKJI)
	{
		return Mathf.Pow(1869f, HDAMKJKNKJI / 721f);
	}

	// Token: 0x06010792 RID: 67474 RVA: 0x00597B96 File Offset: 0x00595D96
	public void CCGEEKLNIBI(float BDICHAELIJE)
	{
		this.SetMenuVolume(BDICHAELIJE);
		this.LECBMDDHMOH(BDICHAELIJE);
	}

	// Token: 0x06010793 RID: 67475 RVA: 0x00597BA8 File Offset: 0x00595DA8
	public float HPGOMHIMAEL()
	{
		float hdamkjknkji = 1896f;
		this.audioMixer.GetFloat("icon.png", out hdamkjknkji);
		return this.DPCLFKCHLNP(hdamkjknkji);
	}

	// Token: 0x06010794 RID: 67476 RVA: 0x00597113 File Offset: 0x00595313
	public void LGHCJCFHEMF()
	{
		base.StartCoroutine(this.IAIAPPPLMPA());
	}

	// Token: 0x06010795 RID: 67477 RVA: 0x00597BD5 File Offset: 0x00595DD5
	public void LDJOLDNPEFM(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("AudioSampler", this.NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("challenges.", BDICHAELIJE, null);
	}

	// Token: 0x06010796 RID: 67478 RVA: 0x00597C00 File Offset: 0x00595E00
	public float GDHNOIBAODH()
	{
		float hdamkjknkji = 1952f;
		this.audioMixer.GetFloat("CameraFilterPack/3D_Distortion", out hdamkjknkji);
		return this.MJBMIGAKAMK(hdamkjknkji);
	}

	// Token: 0x06010797 RID: 67479 RVA: 0x00597C2D File Offset: 0x00595E2D
	public void LIABLJEFMFP(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("0.000", this.NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("[DiscordController] Join request {0}#{1}: {2}", BDICHAELIJE, null);
	}

	// Token: 0x06010798 RID: 67480 RVA: 0x00597C58 File Offset: 0x00595E58
	public void BJIJEHFIFIK(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("help", this.FFGKOFGAEHI(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("skin.", BDICHAELIJE, null);
	}

	// Token: 0x06010799 RID: 67481 RVA: 0x00597C84 File Offset: 0x00595E84
	public float EGOEKBMAFCL()
	{
		float hdamkjknkji = 92f;
		this.audioMixer.GetFloat("_Offsets", out hdamkjknkji);
		return this.MLODONCDFIJ(hdamkjknkji);
	}

	// Token: 0x0601079A RID: 67482 RVA: 0x0059798F File Offset: 0x00595B8F
	public void HKLKNNOFNIB(float BDICHAELIJE)
	{
		this.LJPCPCKALJI(BDICHAELIJE);
		this.EEEHGFKAGOO(BDICHAELIJE);
	}

	// Token: 0x0601079B RID: 67483 RVA: 0x00597CB1 File Offset: 0x00595EB1
	public void BKJMEFKAOPJ(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("CameraFilterPack/Blend2Camera_HardLight", this.GAAOHHOOEBG(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.EIAJOEAPEJO("th", BDICHAELIJE, null);
	}

	// Token: 0x0601079C RID: 67484 RVA: 0x00597CDC File Offset: 0x00595EDC
	public void BMCOFKEEEFO(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("CameraFilterPack_RainFX_Anm", this.FFGKOFGAEHI(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("r", BDICHAELIJE, null);
	}

	// Token: 0x0601079D RID: 67485 RVA: 0x00597D08 File Offset: 0x00595F08
	public float MPDNIFAHJHE()
	{
		float hdamkjknkji = 1904f;
		this.audioMixer.GetFloat("StartButton", out hdamkjknkji);
		return this.CKBPLJGCLPH(hdamkjknkji);
	}

	// Token: 0x0601079F RID: 67487 RVA: 0x00597D38 File Offset: 0x00595F38
	private IEnumerator DLBBADHEGID()
	{
		if (VolumeSettings.PBLBJJCPCME.LNIJKGECNME == null)
		{
			VolumeSettings.PBLBJJCPCME.LNIJKGECNME = new Func<bool>(VolumeSettings.PBLBJJCPCME.GBKBDKHPLKG);
		}
		yield return new WaitUntil(VolumeSettings.PBLBJJCPCME.LNIJKGECNME);
		this.SetMenuVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.menu", 0.5f, null));
		this.SetGameVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.game", 0.5f, null));
		this.SetSfxVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.sfx", 0.5f, null));
		this.SetEditorVolume(Singleton<SaveSystem>.Instance.GetFloat("settings.volume.editor", 0.5f, null));
		yield break;
	}

	// Token: 0x060107A0 RID: 67488 RVA: 0x00597D53 File Offset: 0x00595F53
	public void SetVolume(float BDICHAELIJE)
	{
		this.SetMenuVolume(BDICHAELIJE);
		this.SetGameVolume(BDICHAELIJE);
	}

	// Token: 0x060107A1 RID: 67489 RVA: 0x00597D63 File Offset: 0x00595F63
	public void DOKAKEMDALN()
	{
		base.StartCoroutine(this.NCLNAMDDBNP());
	}

	// Token: 0x060107A2 RID: 67490 RVA: 0x00597D74 File Offset: 0x00595F74
	public float GetGameVolume()
	{
		float hdamkjknkji = 0f;
		this.audioMixer.GetFloat("gameVolume", out hdamkjknkji);
		return this.DbToNormal(hdamkjknkji);
	}

	// Token: 0x060107A3 RID: 67491 RVA: 0x00597DA1 File Offset: 0x00595FA1
	public void OKCAOBPKDCF(float BDICHAELIJE)
	{
		this.HLAIMFCGOIL(BDICHAELIJE);
		this.EEEHGFKAGOO(BDICHAELIJE);
	}

	// Token: 0x060107A4 RID: 67492 RVA: 0x00597DB4 File Offset: 0x00595FB4
	public float DAOHDNLLEOH()
	{
		float hdamkjknkji = 822f;
		this.audioMixer.GetFloat("[Up]", out hdamkjknkji);
		return this.DIGIPEPHEKJ(hdamkjknkji);
	}

	// Token: 0x060107A5 RID: 67493 RVA: 0x00597DE1 File Offset: 0x00595FE1
	public void LJPCPCKALJI(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("Run a command for data system", this.GAAOHHOOEBG(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.EIAJOEAPEJO("Oct", BDICHAELIJE, null);
	}

	// Token: 0x060107A6 RID: 67494 RVA: 0x00597E0C File Offset: 0x0059600C
	public float CGGEOGNGBDJ(float HDAMKJKNKJI)
	{
		return Mathf.Pow(1763f, HDAMKJKNKJI / 365f);
	}

	// Token: 0x060107A7 RID: 67495 RVA: 0x00597520 File Offset: 0x00595720
	public void DFFKKLAPHCC()
	{
		base.StartCoroutine(this.LAMOIKFHHHJ());
	}

	// Token: 0x060107A8 RID: 67496 RVA: 0x00597E1F File Offset: 0x0059601F
	public float NGMEOMJBBPC(float JCLIHOKDOHN)
	{
		return (JCLIHOKDOHN <= 1232f) ? 1741f : (502f * Mathf.Log10(JCLIHOKDOHN));
	}

	// Token: 0x060107A9 RID: 67497 RVA: 0x00597E42 File Offset: 0x00596042
	public void FJJHDPKBJGP(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("[SERVER] Player ", this.ABKGDNMBAMH(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat("GroupNameText", BDICHAELIJE, null);
	}

	// Token: 0x060107AA RID: 67498 RVA: 0x00597E6D File Offset: 0x0059606D
	public void KNKKGPJCAFN(float BDICHAELIJE)
	{
		this.JJFDDNOMCMO(BDICHAELIJE);
		this.EEEHGFKAGOO(BDICHAELIJE);
	}

	// Token: 0x060107AB RID: 67499 RVA: 0x00597E80 File Offset: 0x00596080
	public float KOFOMELMOGK()
	{
		float hdamkjknkji = 873f;
		this.audioMixer.GetFloat("LevelInfoInputField", out hdamkjknkji);
		return this.CGGEOGNGBDJ(hdamkjknkji);
	}

	// Token: 0x060107AC RID: 67500 RVA: 0x00597EB0 File Offset: 0x005960B0
	public float DKPAGBGHMLE()
	{
		float hdamkjknkji = 550f;
		this.audioMixer.GetFloat("_Parameter", out hdamkjknkji);
		return this.CGGEOGNGBDJ(hdamkjknkji);
	}

	// Token: 0x060107AD RID: 67501 RVA: 0x00597EDD File Offset: 0x005960DD
	public void CKKOBPJPHKK(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.", this.FFGKOFGAEHI(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("_ScreenResolution", BDICHAELIJE, null);
	}

	// Token: 0x060107AE RID: 67502 RVA: 0x00597F08 File Offset: 0x00596108
	public float FPPNNEGMNBG(float HDAMKJKNKJI)
	{
		return Mathf.Pow(209f, HDAMKJKNKJI / 1408f);
	}

	// Token: 0x060107AF RID: 67503 RVA: 0x00597F1B File Offset: 0x0059611B
	public void HLAIMFCGOIL(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("_Extra2", this.JBJMLECCBBN(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("Editor/", BDICHAELIJE, null);
	}

	// Token: 0x060107B0 RID: 67504 RVA: 0x00597F46 File Offset: 0x00596146
	public void GGPENMLKGFL(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("inventory.selected.", this.GAAOHHOOEBG(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("_TimeX", BDICHAELIJE, null);
	}

	// Token: 0x060107B1 RID: 67505 RVA: 0x00597F71 File Offset: 0x00596171
	public void BFEGEAECOKB(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat(": ", this.JBJMLECCBBN(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.EIAJOEAPEJO("_TimeX", BDICHAELIJE, null);
	}

	// Token: 0x060107B2 RID: 67506 RVA: 0x00597F9C File Offset: 0x0059619C
	public float KFFANDOCOFI()
	{
		float hdamkjknkji = 1512f;
		this.audioMixer.GetFloat("[PlayerBase] Checkpoint error: ", out hdamkjknkji);
		return this.DPCLFKCHLNP(hdamkjknkji);
	}

	// Token: 0x060107B3 RID: 67507 RVA: 0x00597FCC File Offset: 0x005961CC
	public float MDBOBKHPJFN()
	{
		float hdamkjknkji = 1882f;
		this.audioMixer.GetFloat("/", out hdamkjknkji);
		return this.MLODONCDFIJ(hdamkjknkji);
	}

	// Token: 0x060107B4 RID: 67508 RVA: 0x00597FF9 File Offset: 0x005961F9
	public void OJMIENICPNA(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("_FixDistance", this.FFGKOFGAEHI(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("_Near", BDICHAELIJE, null);
	}

	// Token: 0x060107B5 RID: 67509 RVA: 0x00598024 File Offset: 0x00596224
	public float FFGCJNNBKLE(float HDAMKJKNKJI)
	{
		return Mathf.Pow(176f, HDAMKJKNKJI / 1353f);
	}

	// Token: 0x060107B6 RID: 67510 RVA: 0x00598037 File Offset: 0x00596237
	public void NGFKFJJOPFH(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("_Value2", this.NGMEOMJBBPC(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.CBIEBMGENJH(" not exist", BDICHAELIJE, null);
	}

	// Token: 0x060107B7 RID: 67511 RVA: 0x00598062 File Offset: 0x00596262
	public void LCGIPBONGGG(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("CameraFilterPack/Drawing_Manga_Color", this.NGMEOMJBBPC(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("cipherText", BDICHAELIJE, null);
	}

	// Token: 0x060107B8 RID: 67512 RVA: 0x0059808D File Offset: 0x0059628D
	public void HGOFPCJGOFO(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("_ScreenResolution", this.FFGKOFGAEHI(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("_Value", BDICHAELIJE, null);
	}

	// Token: 0x060107B9 RID: 67513 RVA: 0x005980B8 File Offset: 0x005962B8
	public float EJLINEJCHAI()
	{
		float hdamkjknkji = 1475f;
		this.audioMixer.GetFloat("_Value2", out hdamkjknkji);
		return this.DIGIPEPHEKJ(hdamkjknkji);
	}

	// Token: 0x060107BA RID: 67514 RVA: 0x005980E5 File Offset: 0x005962E5
	public float FFGKOFGAEHI(float JCLIHOKDOHN)
	{
		return (JCLIHOKDOHN <= 915f) ? 1960f : (658f * Mathf.Log10(JCLIHOKDOHN));
	}

	// Token: 0x060107BB RID: 67515 RVA: 0x00598108 File Offset: 0x00596308
	public void OJJHDKFHJFE(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("UI Extensions/UISoftAdditive", this.ABKGDNMBAMH(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("Horizontal", BDICHAELIJE, null);
	}

	// Token: 0x060107BC RID: 67516 RVA: 0x00598133 File Offset: 0x00596333
	public void PCPJGGCDLGD(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("\"", this.NGMEOMJBBPC(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.IKOAFMHIJLE("Playing ", BDICHAELIJE, null);
	}

	// Token: 0x060107BD RID: 67517 RVA: 0x0059815E File Offset: 0x0059635E
	public void PEMGCAIGPPP(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("LoadingStatusText", this.NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.JBHLCJOEOGL("\t", BDICHAELIJE, null);
	}

	// Token: 0x060107BE RID: 67518 RVA: 0x00598189 File Offset: 0x00596389
	public float BFAFNHBBADH(float HDAMKJKNKJI)
	{
		return Mathf.Pow(1744f, HDAMKJKNKJI / 1575f);
	}

	// Token: 0x060107BF RID: 67519 RVA: 0x0059819C File Offset: 0x0059639C
	public void FACFNHLMGCN(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("skin.hit_wrong", this.ABKGDNMBAMH(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.EIAJOEAPEJO("Editor", BDICHAELIJE, null);
	}

	// Token: 0x060107C0 RID: 67520 RVA: 0x005981C7 File Offset: 0x005963C7
	public void DMLECMADHCP(float BDICHAELIJE)
	{
		this.audioMixer.SetFloat("achievements.21.progress", this.NormalToDb(BDICHAELIJE));
		Singleton<SaveSystem>.Instance.SetFloat(" Maybe GO was destroyed but RPC not cleaned up.", BDICHAELIJE, null);
	}

	// Token: 0x04001CD1 RID: 7377
	public AudioMixer audioMixer;
}
