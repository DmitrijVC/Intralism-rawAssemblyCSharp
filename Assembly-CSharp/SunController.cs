using System;
using AudioVisualizer;
using UnityEngine;

// Token: 0x02000407 RID: 1031
public class SunController : EnvironmentController
{
	// Token: 0x0600EBD9 RID: 60377 RVA: 0x00530038 File Offset: 0x0052E238
	public void FPFMNEAEMFJ(float DPNHODJHGJL)
	{
		this.CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	// Token: 0x0600EBDA RID: 60378 RVA: 0x00530046 File Offset: 0x0052E246
	public void AODCDDKFJHM(Vector3 JJIJODIEBFP)
	{
		this.CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	// Token: 0x0600EBDB RID: 60379 RVA: 0x00530054 File Offset: 0x0052E254
	public void LIMBPIFKKDK(int CDPLIMAJBGF)
	{
		this.CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	// Token: 0x0600EBDC RID: 60380 RVA: 0x00530062 File Offset: 0x0052E262
	public void ILOGAHJCLJE(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		this.color1 = MGHJCGBNEPL;
		this.color2 = NBPMHDANECK;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600EBDD RID: 60381 RVA: 0x00530079 File Offset: 0x0052E279
	public void KOODDHJPHOI(Vector3 LPIMAGMABLC)
	{
		this.CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	// Token: 0x0600EBDE RID: 60382 RVA: 0x00530087 File Offset: 0x0052E287
	public void HKPKMPPKPAI(Vector3 GNIJKBCHEPG)
	{
		this.CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	// Token: 0x0600EBDF RID: 60383 RVA: 0x00530062 File Offset: 0x0052E262
	public void CADMAAOOAGF(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		this.color1 = MGHJCGBNEPL;
		this.color2 = NBPMHDANECK;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600EBE0 RID: 60384 RVA: 0x00530095 File Offset: 0x0052E295
	public void MNKFLALANBJ(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600EBE1 RID: 60385 RVA: 0x00530087 File Offset: 0x0052E287
	public void KJNBBODKMCD(Vector3 GNIJKBCHEPG)
	{
		this.CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	// Token: 0x0600EBE2 RID: 60386 RVA: 0x005300A0 File Offset: 0x0052E2A0
	public virtual void APKNAPHOFHC()
	{
		base.CFIAKIJAILI();
		this.progress = this.JFCPJAELJOE.GetLifesProgrees();
		this.HKIDNEAKGNO.material.SetColor("Myst", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("CameraFilterPack_VHS2"), Helpers.ColorGradient(this.color1, this.color2, this.progress), Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetColor("IEnumerable", Color.Lerp(this.HKIDNEAKGNO.material.GetColor(":"), Helpers.ColorGradient(this.color1, this.color2, this.progress), Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetFloat("Fade", Mathf.Lerp(this.HKIDNEAKGNO.material.GetFloat("CameraFilterPack/FX_Screens"), this.emission * 609f, Time.smoothDeltaTime * this.colorLerp));
	}

	// Token: 0x0600EBE3 RID: 60387 RVA: 0x00530038 File Offset: 0x0052E238
	public void PIDMIGPIMMC(float DPNHODJHGJL)
	{
		this.CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	// Token: 0x0600EBE4 RID: 60388 RVA: 0x00530046 File Offset: 0x0052E246
	public void OAPMDGDCEGO(Vector3 JJIJODIEBFP)
	{
		this.CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	// Token: 0x0600EBE5 RID: 60389 RVA: 0x005301B0 File Offset: 0x0052E3B0
	public virtual void FGAPIOELJCG()
	{
		base.CEACMFGNDEB();
		this.CBNKJGPOLMG.LOKKIADJAFE();
		this.progress = 1934f;
		this.color1 = new Color(186f, 1233f, 342f);
		this.color2 = new Color(1019f, 1155f, 1445f);
		this.colorLerp = 317f;
		this.emission = 421f;
	}

	// Token: 0x0600EBE6 RID: 60390 RVA: 0x00530054 File Offset: 0x0052E254
	public void MFMPKLLLILB(int CDPLIMAJBGF)
	{
		this.CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	// Token: 0x0600EBE7 RID: 60391 RVA: 0x00530224 File Offset: 0x0052E424
	public virtual void JDGFCEPDKAJ()
	{
		base.EHCGBJDFMHG();
		this.progress = this.JFCPJAELJOE.GetLifesProgrees();
		this.HKIDNEAKGNO.material.SetColor(".lastCheckpoint.playerdistance", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("_Value4"), Helpers.ColorGradient(this.color1, this.color2, this.progress), Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetColor("_ScreenResolution", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("_Green_R"), Helpers.ColorGradient(this.color1, this.color2, this.progress), Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetFloat("threshold", Mathf.Lerp(this.HKIDNEAKGNO.material.GetFloat("icon.png"), this.emission * 1736f, Time.smoothDeltaTime * this.colorLerp));
	}

	// Token: 0x0600EBE8 RID: 60392 RVA: 0x00530095 File Offset: 0x0052E295
	public void GBEAKNALDOE(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600EBE9 RID: 60393 RVA: 0x00530333 File Offset: 0x0052E533
	public override void Awake()
	{
		base.Awake();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.CBNKJGPOLMG = base.GetComponent<DynamicScale>();
		this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600EBEA RID: 60394 RVA: 0x00530360 File Offset: 0x0052E560
	public virtual void LECPHJOIGKN()
	{
		base.GONKPNAAIEE();
		this.CBNKJGPOLMG.IJHGPCAHDEH();
		this.progress = 85f;
		this.color1 = new Color(160f, 899f, 69f);
		this.color2 = new Color(874f, 773f, 934f);
		this.colorLerp = 1048f;
		this.emission = 537f;
	}

	// Token: 0x0600EBEB RID: 60395 RVA: 0x00530062 File Offset: 0x0052E262
	public void OBNOLJNCFFO(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		this.color1 = MGHJCGBNEPL;
		this.color2 = NBPMHDANECK;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600EBEC RID: 60396 RVA: 0x00530046 File Offset: 0x0052E246
	public void OGCEBFAEBGO(Vector3 JJIJODIEBFP)
	{
		this.CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	// Token: 0x0600EBED RID: 60397 RVA: 0x00530038 File Offset: 0x0052E238
	public void SetSensitivity(float DPNHODJHGJL)
	{
		this.CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	// Token: 0x0600EBEE RID: 60398 RVA: 0x00530087 File Offset: 0x0052E287
	public void DJGAAJMNGND(Vector3 GNIJKBCHEPG)
	{
		this.CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	// Token: 0x0600EBEF RID: 60399 RVA: 0x005303D4 File Offset: 0x0052E5D4
	public virtual void IBFJAOINHMK()
	{
		base.Update();
		this.progress = this.JFCPJAELJOE.GetLifesProgrees();
		this.HKIDNEAKGNO.material.SetColor("_TimeX", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("/"), Helpers.ColorGradient(this.color1, this.color2, this.progress), Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetColor("ticket", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("_FixDistance"), Helpers.ColorGradient(this.color1, this.color2, this.progress), Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetFloat("_RampTex", Mathf.Lerp(this.HKIDNEAKGNO.material.GetFloat("ResetButton"), this.emission * 503f, Time.smoothDeltaTime * this.colorLerp));
	}

	// Token: 0x0600EBF0 RID: 60400 RVA: 0x00530062 File Offset: 0x0052E262
	public void KNINICADKDB(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		this.color1 = MGHJCGBNEPL;
		this.color2 = NBPMHDANECK;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600EBF1 RID: 60401 RVA: 0x005304E3 File Offset: 0x0052E6E3
	public virtual void KGMCGGIEPDE()
	{
		base.EMANBHKAONB();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.CBNKJGPOLMG = base.GetComponent<DynamicScale>();
		this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600EBF2 RID: 60402 RVA: 0x00530079 File Offset: 0x0052E279
	public void JOICINMJKHE(Vector3 LPIMAGMABLC)
	{
		this.CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	// Token: 0x0600EBF3 RID: 60403 RVA: 0x00530510 File Offset: 0x0052E710
	public virtual void FOLDLDLFFLM()
	{
		base.Update();
		this.progress = this.JFCPJAELJOE.GetLifesProgrees();
		this.HKIDNEAKGNO.material.SetColor("_Value2", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("/icon"), Helpers.ColorGradient(this.color1, this.color2, this.progress), Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetColor("DPADHOR", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("settings.customdataskin"), Helpers.ColorGradient(this.color1, this.color2, this.progress), Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetFloat("ConfigVersionSlider", Mathf.Lerp(this.HKIDNEAKGNO.material.GetFloat("OPEN"), this.emission * 53f, Time.smoothDeltaTime * this.colorLerp));
	}

	// Token: 0x0600EBF4 RID: 60404 RVA: 0x00530095 File Offset: 0x0052E295
	public void JMFHNBLFEIE(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600EBF5 RID: 60405 RVA: 0x0053061F File Offset: 0x0052E81F
	public void NJEKLECIGIJ(float KEDDLFDAIDE)
	{
		this.CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	// Token: 0x0600EBF6 RID: 60406 RVA: 0x00530062 File Offset: 0x0052E262
	public void CNGNBAKGKGB(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		this.color1 = MGHJCGBNEPL;
		this.color2 = NBPMHDANECK;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600EBF7 RID: 60407 RVA: 0x0053061F File Offset: 0x0052E81F
	public void EFMAODCEBPD(float KEDDLFDAIDE)
	{
		this.CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	// Token: 0x0600EBF8 RID: 60408 RVA: 0x00530062 File Offset: 0x0052E262
	public void PLGPEHKIAHA(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		this.color1 = MGHJCGBNEPL;
		this.color2 = NBPMHDANECK;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600EBF9 RID: 60409 RVA: 0x00530087 File Offset: 0x0052E287
	public void GEKNJFEGELD(Vector3 GNIJKBCHEPG)
	{
		this.CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	// Token: 0x0600EBFA RID: 60410 RVA: 0x00530046 File Offset: 0x0052E246
	public void FJCHGDMEGLO(Vector3 JJIJODIEBFP)
	{
		this.CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	// Token: 0x0600EBFC RID: 60412 RVA: 0x00530079 File Offset: 0x0052E279
	public void LDDBLLHGOCO(Vector3 LPIMAGMABLC)
	{
		this.CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	// Token: 0x0600EBFD RID: 60413 RVA: 0x00530656 File Offset: 0x0052E856
	public virtual void KAMMKPFNJJF()
	{
		base.FAAJAMIGJNK();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.CBNKJGPOLMG = base.GetComponent<DynamicScale>();
		this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600EBFE RID: 60414 RVA: 0x00530684 File Offset: 0x0052E884
	public virtual void PBEPCAPAKLG()
	{
		base.Update();
		this.progress = this.JFCPJAELJOE.GetLifesProgrees();
		this.HKIDNEAKGNO.material.SetColor("RateButton", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("_ScreenResolution"), Helpers.ColorGradient(this.color1, this.color2, this.progress), Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetColor("not available at the moment", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("UsernameText"), Helpers.ColorGradient(this.color1, this.color2, this.progress), Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetFloat("_Value3", Mathf.Lerp(this.HKIDNEAKGNO.material.GetFloat("================================"), this.emission * 1189f, Time.smoothDeltaTime * this.colorLerp));
	}

	// Token: 0x0600EBFF RID: 60415 RVA: 0x00530038 File Offset: 0x0052E238
	public void JKFAGJIBKJF(float DPNHODJHGJL)
	{
		this.CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	// Token: 0x0600EC00 RID: 60416 RVA: 0x00530046 File Offset: 0x0052E246
	public void BIBILLGDIBG(Vector3 JJIJODIEBFP)
	{
		this.CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	// Token: 0x0600EC01 RID: 60417 RVA: 0x00530062 File Offset: 0x0052E262
	public void SetColors(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		this.color1 = MGHJCGBNEPL;
		this.color2 = NBPMHDANECK;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600EC02 RID: 60418 RVA: 0x00530079 File Offset: 0x0052E279
	public void IHJGHNLJOGF(Vector3 LPIMAGMABLC)
	{
		this.CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	// Token: 0x0600EC03 RID: 60419 RVA: 0x00530794 File Offset: 0x0052E994
	public virtual void KCDOMIJBFLL()
	{
		base.FBMDHDBELEK();
		this.progress = this.JFCPJAELJOE.GetLifesProgrees();
		this.HKIDNEAKGNO.material.SetColor("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("Default UI Material"), Helpers.ColorGradient(this.color1, this.color2, this.progress), Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetColor("[Up]", Color.Lerp(this.HKIDNEAKGNO.material.GetColor(".completedMaps"), Helpers.ColorGradient(this.color1, this.color2, this.progress), Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetFloat("LoadMapCanvas", Mathf.Lerp(this.HKIDNEAKGNO.material.GetFloat("No peer to communicate with. "), this.emission * 204f, Time.smoothDeltaTime * this.colorLerp));
	}

	// Token: 0x0600EC04 RID: 60420 RVA: 0x00530087 File Offset: 0x0052E287
	public void CNGIFFAFGOE(Vector3 GNIJKBCHEPG)
	{
		this.CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	// Token: 0x0600EC05 RID: 60421 RVA: 0x00530095 File Offset: 0x0052E295
	public void ECCFMFNCBIE(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600EC06 RID: 60422 RVA: 0x00530038 File Offset: 0x0052E238
	public void PCIPLDNAFCL(float DPNHODJHGJL)
	{
		this.CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	// Token: 0x0600EC07 RID: 60423 RVA: 0x00530054 File Offset: 0x0052E254
	public void KPALEBGNCCK(int CDPLIMAJBGF)
	{
		this.CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	// Token: 0x0600EC08 RID: 60424 RVA: 0x00530062 File Offset: 0x0052E262
	public void CHOKKIPDAPF(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		this.color1 = MGHJCGBNEPL;
		this.color2 = NBPMHDANECK;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600EC09 RID: 60425 RVA: 0x00530079 File Offset: 0x0052E279
	public void ICKKICJIHIP(Vector3 LPIMAGMABLC)
	{
		this.CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	// Token: 0x0600EC0A RID: 60426 RVA: 0x00530079 File Offset: 0x0052E279
	public void DGDLNGADPCP(Vector3 LPIMAGMABLC)
	{
		this.CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	// Token: 0x0600EC0B RID: 60427 RVA: 0x00530079 File Offset: 0x0052E279
	public void OLDNDBMGMEM(Vector3 LPIMAGMABLC)
	{
		this.CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	// Token: 0x0600EC0C RID: 60428 RVA: 0x005308A4 File Offset: 0x0052EAA4
	public virtual void HFFAJNCOJNB()
	{
		base.EGFBPCMCNDJ();
		this.CBNKJGPOLMG.LOKKIADJAFE();
		this.progress = 1325f;
		this.color1 = new Color(681f, 627f, 963f);
		this.color2 = new Color(43f, 393f, 1251f);
		this.colorLerp = 1519f;
		this.emission = 1991f;
	}

	// Token: 0x0600EC0D RID: 60429 RVA: 0x0053061F File Offset: 0x0052E81F
	public void KHMMCADJNOE(float KEDDLFDAIDE)
	{
		this.CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	// Token: 0x0600EC0E RID: 60430 RVA: 0x00530918 File Offset: 0x0052EB18
	public override void Reset()
	{
		base.Reset();
		this.CBNKJGPOLMG.Reset();
		this.progress = 1f;
		this.color1 = new Color(0.8f, 0.8f, 1f);
		this.color2 = new Color(1f, 0f, 0f);
		this.colorLerp = 10f;
		this.emission = 1.5f;
	}

	// Token: 0x0600EC0F RID: 60431 RVA: 0x0053098C File Offset: 0x0052EB8C
	public virtual void MNBMLBLLDGL()
	{
		base.LOKKIADJAFE();
		this.CBNKJGPOLMG.FPKJJBAENGF();
		this.progress = 1135f;
		this.color1 = new Color(1594f, 726f, 581f);
		this.color2 = new Color(1626f, 556f, 1541f);
		this.colorLerp = 1253f;
		this.emission = 823f;
	}

	// Token: 0x0600EC10 RID: 60432 RVA: 0x00530087 File Offset: 0x0052E287
	public void BHMCBLOPIDP(Vector3 GNIJKBCHEPG)
	{
		this.CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	// Token: 0x0600EC11 RID: 60433 RVA: 0x005309FF File Offset: 0x0052EBFF
	public virtual void PEMPABLNJHL()
	{
		base.FMAFBLKAJDF();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.CBNKJGPOLMG = base.GetComponent<DynamicScale>();
		this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600EC12 RID: 60434 RVA: 0x00530054 File Offset: 0x0052E254
	public void MCHHNIMHKMG(int CDPLIMAJBGF)
	{
		this.CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	// Token: 0x0600EC13 RID: 60435 RVA: 0x00530046 File Offset: 0x0052E246
	public void BABLMFPOAJN(Vector3 JJIJODIEBFP)
	{
		this.CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	// Token: 0x0600EC14 RID: 60436 RVA: 0x0053061F File Offset: 0x0052E81F
	public void BELGEMHIJAG(float KEDDLFDAIDE)
	{
		this.CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	// Token: 0x0600EC15 RID: 60437 RVA: 0x00530A2C File Offset: 0x0052EC2C
	public virtual void PDDIOCCBAIL()
	{
		base.BJIKAHNJNEB();
		this.CBNKJGPOLMG.MANOCIJICLG();
		this.progress = 395f;
		this.color1 = new Color(179f, 1f, 1143f);
		this.color2 = new Color(1275f, 1908f, 122f);
		this.colorLerp = 1424f;
		this.emission = 656f;
	}

	// Token: 0x0600EC16 RID: 60438 RVA: 0x00530087 File Offset: 0x0052E287
	public void HMHOIIOKNBL(Vector3 GNIJKBCHEPG)
	{
		this.CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	// Token: 0x0600EC17 RID: 60439 RVA: 0x00530038 File Offset: 0x0052E238
	public void FGOHDAKFFHF(float DPNHODJHGJL)
	{
		this.CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	// Token: 0x0600EC18 RID: 60440 RVA: 0x00530087 File Offset: 0x0052E287
	public void FNKMABBHBPA(Vector3 GNIJKBCHEPG)
	{
		this.CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	// Token: 0x0600EC19 RID: 60441 RVA: 0x00530333 File Offset: 0x0052E533
	public virtual void MGGNFEPGIJI()
	{
		base.Awake();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.CBNKJGPOLMG = base.GetComponent<DynamicScale>();
		this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600EC1A RID: 60442 RVA: 0x00530062 File Offset: 0x0052E262
	public void MEEEPDEELKJ(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		this.color1 = MGHJCGBNEPL;
		this.color2 = NBPMHDANECK;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600EC1B RID: 60443 RVA: 0x00530046 File Offset: 0x0052E246
	public void FJNPBDEIAEJ(Vector3 JJIJODIEBFP)
	{
		this.CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	// Token: 0x0600EC1C RID: 60444 RVA: 0x00530A9F File Offset: 0x0052EC9F
	public virtual void PPGKBEJLBFJ()
	{
		base.NLNAJMCBNDC();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.CBNKJGPOLMG = base.GetComponent<DynamicScale>();
		this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600EC1D RID: 60445 RVA: 0x00530046 File Offset: 0x0052E246
	public void NECMHCAPIIC(Vector3 JJIJODIEBFP)
	{
		this.CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	// Token: 0x0600EC1E RID: 60446 RVA: 0x00530087 File Offset: 0x0052E287
	public void GAMBCMHFONG(Vector3 GNIJKBCHEPG)
	{
		this.CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	// Token: 0x0600EC1F RID: 60447 RVA: 0x00530087 File Offset: 0x0052E287
	public void SetMinSize(Vector3 GNIJKBCHEPG)
	{
		this.CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	// Token: 0x0600EC20 RID: 60448 RVA: 0x00530ACB File Offset: 0x0052ECCB
	public virtual void PMBIKIBOHOF()
	{
		base.OPFDGBDADMA();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.CBNKJGPOLMG = base.GetComponent<DynamicScale>();
		this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600EC21 RID: 60449 RVA: 0x00530046 File Offset: 0x0052E246
	public void OGIBAKNNLGH(Vector3 JJIJODIEBFP)
	{
		this.CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	// Token: 0x0600EC22 RID: 60450 RVA: 0x00530062 File Offset: 0x0052E262
	public void PMFPFNMCAPF(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		this.color1 = MGHJCGBNEPL;
		this.color2 = NBPMHDANECK;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600EC23 RID: 60451 RVA: 0x00530046 File Offset: 0x0052E246
	public void GBBPDPPAOKP(Vector3 JJIJODIEBFP)
	{
		this.CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	// Token: 0x0600EC24 RID: 60452 RVA: 0x00530AF8 File Offset: 0x0052ECF8
	public virtual void LBPCODPOJAH()
	{
		base.EHCGBJDFMHG();
		this.progress = this.JFCPJAELJOE.GetLifesProgrees();
		this.HKIDNEAKGNO.material.SetColor("Object ID. Case-Sensitive", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("Reconnect() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages."), Helpers.ColorGradient(this.color1, this.color2, this.progress), Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetColor("curScn", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("Crosshair"), Helpers.ColorGradient(this.color1, this.color2, this.progress), Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetFloat("Delete events", Mathf.Lerp(this.HKIDNEAKGNO.material.GetFloat("PLEASE WAIT"), this.emission * 479f, Time.smoothDeltaTime * this.colorLerp));
	}

	// Token: 0x0600EC25 RID: 60453 RVA: 0x00530C08 File Offset: 0x0052EE08
	public virtual void IKIDIJLIGOH()
	{
		base.CFIAKIJAILI();
		this.progress = this.JFCPJAELJOE.GetLifesProgrees();
		this.HKIDNEAKGNO.material.SetColor("_Amount", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("Connection error: "), Helpers.ColorGradient(this.color1, this.color2, this.progress), Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetColor("mapselector.filter.rateduponly", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("%"), Helpers.ColorGradient(this.color1, this.color2, this.progress), Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetFloat("NOISE", Mathf.Lerp(this.HKIDNEAKGNO.material.GetFloat("_TimeX"), this.emission * 74f, Time.smoothDeltaTime * this.colorLerp));
	}

	// Token: 0x0600EC26 RID: 60454 RVA: 0x00530D18 File Offset: 0x0052EF18
	public virtual void JLEAKFENJDJ()
	{
		base.EGFBPCMCNDJ();
		this.CBNKJGPOLMG.LDGJGONCEND();
		this.progress = 1920f;
		this.color1 = new Color(600f, 1135f, 1633f);
		this.color2 = new Color(844f, 377f, 1226f);
		this.colorLerp = 1779f;
		this.emission = 1297f;
	}

	// Token: 0x0600EC27 RID: 60455 RVA: 0x005304E3 File Offset: 0x0052E6E3
	public virtual void GEGFJJBCHPE()
	{
		base.EMANBHKAONB();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.CBNKJGPOLMG = base.GetComponent<DynamicScale>();
		this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600EC28 RID: 60456 RVA: 0x00530095 File Offset: 0x0052E295
	public void MLFMFOBDOED(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600EC29 RID: 60457 RVA: 0x00530656 File Offset: 0x0052E856
	public virtual void PHHOMLJECOJ()
	{
		base.FAAJAMIGJNK();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.CBNKJGPOLMG = base.GetComponent<DynamicScale>();
		this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600EC2A RID: 60458 RVA: 0x0053061F File Offset: 0x0052E81F
	public void HJONHHLOCJM(float KEDDLFDAIDE)
	{
		this.CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	// Token: 0x0600EC2B RID: 60459 RVA: 0x00530054 File Offset: 0x0052E254
	public void KOHFHNBPBGG(int CDPLIMAJBGF)
	{
		this.CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	// Token: 0x0600EC2C RID: 60460 RVA: 0x00530D8C File Offset: 0x0052EF8C
	public virtual void IJHGPCAHDEH()
	{
		base.EEBGCGFNELO();
		this.CBNKJGPOLMG.Reset();
		this.progress = 1343f;
		this.color1 = new Color(221f, 1734f, 1941f);
		this.color2 = new Color(857f, 1973f, 1116f);
		this.colorLerp = 1728f;
		this.emission = 1701f;
	}

	// Token: 0x0600EC2D RID: 60461 RVA: 0x00530333 File Offset: 0x0052E533
	public virtual void NCBGPIKDFIA()
	{
		base.Awake();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.CBNKJGPOLMG = base.GetComponent<DynamicScale>();
		this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600EC2E RID: 60462 RVA: 0x00530DFF File Offset: 0x0052EFFF
	public override void GMIOCKFLJAK()
	{
		base.GMIOCKFLJAK();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.CBNKJGPOLMG = base.GetComponent<DynamicScale>();
		this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600EC2F RID: 60463 RVA: 0x00530079 File Offset: 0x0052E279
	public void ECMFHKLEKKL(Vector3 LPIMAGMABLC)
	{
		this.CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	// Token: 0x0600EC30 RID: 60464 RVA: 0x00530079 File Offset: 0x0052E279
	public void SetDirectionVector(Vector3 LPIMAGMABLC)
	{
		this.CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	// Token: 0x0600EC31 RID: 60465 RVA: 0x0053061F File Offset: 0x0052E81F
	public void FBBLHEJADMH(float KEDDLFDAIDE)
	{
		this.CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	// Token: 0x0600EC32 RID: 60466 RVA: 0x0053061F File Offset: 0x0052E81F
	public void JCILLLLGEDB(float KEDDLFDAIDE)
	{
		this.CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	// Token: 0x0600EC33 RID: 60467 RVA: 0x00530046 File Offset: 0x0052E246
	public void BACLAELPOJJ(Vector3 JJIJODIEBFP)
	{
		this.CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	// Token: 0x0600EC34 RID: 60468 RVA: 0x00530062 File Offset: 0x0052E262
	public void HLHAFCDNMEJ(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		this.color1 = MGHJCGBNEPL;
		this.color2 = NBPMHDANECK;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600EC35 RID: 60469 RVA: 0x005304E3 File Offset: 0x0052E6E3
	public virtual void MMPOJCFOGJJ()
	{
		base.EMANBHKAONB();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.CBNKJGPOLMG = base.GetComponent<DynamicScale>();
		this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600EC36 RID: 60470 RVA: 0x00530087 File Offset: 0x0052E287
	public void KBAEPPHJJME(Vector3 GNIJKBCHEPG)
	{
		this.CBNKJGPOLMG.minSize = GNIJKBCHEPG;
	}

	// Token: 0x0600EC37 RID: 60471 RVA: 0x00530079 File Offset: 0x0052E279
	public void ACMENOHGOKD(Vector3 LPIMAGMABLC)
	{
		this.CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	// Token: 0x0600EC38 RID: 60472 RVA: 0x0053061F File Offset: 0x0052E81F
	public void BJJCBNPBKNK(float KEDDLFDAIDE)
	{
		this.CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	// Token: 0x0600EC39 RID: 60473 RVA: 0x00530054 File Offset: 0x0052E254
	public void GFGABKGDCOP(int CDPLIMAJBGF)
	{
		this.CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	// Token: 0x0600EC3A RID: 60474 RVA: 0x00530E2B File Offset: 0x0052F02B
	public virtual void MFIMFMCMADK()
	{
		base.IOMCHHBGJEC();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.CBNKJGPOLMG = base.GetComponent<DynamicScale>();
		this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600EC3B RID: 60475 RVA: 0x00530095 File Offset: 0x0052E295
	public void JFLOMHACLFJ(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600EC3C RID: 60476 RVA: 0x00530054 File Offset: 0x0052E254
	public void HDIDPJOPIIK(int CDPLIMAJBGF)
	{
		this.CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	// Token: 0x0600EC3D RID: 60477 RVA: 0x00530095 File Offset: 0x0052E295
	public void MPFAHHOEMLL(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600EC3E RID: 60478 RVA: 0x00530046 File Offset: 0x0052E246
	public void SetMaxSize(Vector3 JJIJODIEBFP)
	{
		this.CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	// Token: 0x0600EC3F RID: 60479 RVA: 0x00530E58 File Offset: 0x0052F058
	public virtual void LHIBPEGLPHM()
	{
		base.EGFBPCMCNDJ();
		this.CBNKJGPOLMG.MANOCIJICLG();
		this.progress = 37f;
		this.color1 = new Color(1552f, 1428f, 349f);
		this.color2 = new Color(645f, 1267f, 1757f);
		this.colorLerp = 497f;
		this.emission = 1173f;
	}

	// Token: 0x0600EC40 RID: 60480 RVA: 0x00530038 File Offset: 0x0052E238
	public void FKOAHEGNACN(float DPNHODJHGJL)
	{
		this.CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	// Token: 0x0600EC41 RID: 60481 RVA: 0x00530054 File Offset: 0x0052E254
	public void HKIHBIMMECG(int CDPLIMAJBGF)
	{
		this.CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	// Token: 0x0600EC42 RID: 60482 RVA: 0x00530ECC File Offset: 0x0052F0CC
	public override void Update()
	{
		base.Update();
		this.progress = this.JFCPJAELJOE.GetLifesProgrees();
		this.HKIDNEAKGNO.material.SetColor("_DiffuseColor", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("_DiffuseColor"), Helpers.ColorGradient(this.color1, this.color2, this.progress), Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetColor("_EmissionColor", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("_EmissionColor"), Helpers.ColorGradient(this.color1, this.color2, this.progress), Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetFloat("_EmissionGain", Mathf.Lerp(this.HKIDNEAKGNO.material.GetFloat("_EmissionGain"), this.emission * 0.2f, Time.smoothDeltaTime * this.colorLerp));
	}

	// Token: 0x0600EC43 RID: 60483 RVA: 0x00530095 File Offset: 0x0052E295
	public void LCEFIHHFECN(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600EC44 RID: 60484 RVA: 0x00530038 File Offset: 0x0052E238
	public void PFKOEHEFPDC(float DPNHODJHGJL)
	{
		this.CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	// Token: 0x0600EC45 RID: 60485 RVA: 0x00530FDC File Offset: 0x0052F1DC
	public virtual void GCHBGCGBMCK()
	{
		base.EHCGBJDFMHG();
		this.progress = this.JFCPJAELJOE.GetLifesProgrees();
		this.HKIDNEAKGNO.material.SetColor("OxOD.lastPath", Color.Lerp(this.HKIDNEAKGNO.material.GetColor(","), Helpers.ColorGradient(this.color1, this.color2, this.progress), Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetColor("GlassColor", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("maps."), Helpers.ColorGradient(this.color1, this.color2, this.progress), Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetFloat("_Value2", Mathf.Lerp(this.HKIDNEAKGNO.material.GetFloat("id"), this.emission * 858f, Time.smoothDeltaTime * this.colorLerp));
	}

	// Token: 0x0600EC46 RID: 60486 RVA: 0x00530079 File Offset: 0x0052E279
	public void KADFLOHLAHN(Vector3 LPIMAGMABLC)
	{
		this.CBNKJGPOLMG.baseScale = LPIMAGMABLC;
	}

	// Token: 0x0600EC47 RID: 60487 RVA: 0x005310EC File Offset: 0x0052F2EC
	public virtual void ANKIJGCGCBF()
	{
		base.NKLIHNJCHOG();
		this.progress = this.JFCPJAELJOE.GetLifesProgrees();
		this.HKIDNEAKGNO.material.SetColor(" not exist", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("_Value"), Helpers.ColorGradient(this.color1, this.color2, this.progress), Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetColor("_ZCurve", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("Instance\nWorking commands:\ninit or init <savepath>\npath\nsetint <key> <value>\ngetint <key> <value>\nsetfloat <key> <value>\ngetfloat <key> <value>\nsetstring <key> <value>\ngetstring <key> <value>\nsetbool <key> <value>\ngetbool <key> <value>\ndelete <key>\ndeleteall"), Helpers.ColorGradient(this.color1, this.color2, this.progress), Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetFloat("Drop_Near", Mathf.Lerp(this.HKIDNEAKGNO.material.GetFloat("settings.arcsdestroydelay"), this.emission * 1826f, Time.smoothDeltaTime * this.colorLerp));
	}

	// Token: 0x0600EC48 RID: 60488 RVA: 0x00530038 File Offset: 0x0052E238
	public void PFDKFJNHEBG(float DPNHODJHGJL)
	{
		this.CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	// Token: 0x0600EC49 RID: 60489 RVA: 0x00530095 File Offset: 0x0052E295
	public void OOODGNGKHFJ(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600EC4A RID: 60490 RVA: 0x0053061F File Offset: 0x0052E81F
	public void SetLerpSpeed(float KEDDLFDAIDE)
	{
		this.CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	// Token: 0x0600EC4B RID: 60491 RVA: 0x00530038 File Offset: 0x0052E238
	public void HNGCLAICCCG(float DPNHODJHGJL)
	{
		this.CBNKJGPOLMG.sensitivity = DPNHODJHGJL;
	}

	// Token: 0x0600EC4C RID: 60492 RVA: 0x0053061F File Offset: 0x0052E81F
	public void MNOLJMNLCDM(float KEDDLFDAIDE)
	{
		this.CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	// Token: 0x0600EC4D RID: 60493 RVA: 0x00530046 File Offset: 0x0052E246
	public void IHCOABDFACH(Vector3 JJIJODIEBFP)
	{
		this.CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	// Token: 0x0600EC4E RID: 60494 RVA: 0x005311FC File Offset: 0x0052F3FC
	public virtual void OFKDKJGIDLH()
	{
		base.CAPPKCBFILL();
		this.CBNKJGPOLMG.ABDHDGNIHHI();
		this.progress = 185f;
		this.color1 = new Color(1272f, 1773f, 445f);
		this.color2 = new Color(906f, 1274f, 1767f);
		this.colorLerp = 720f;
		this.emission = 1310f;
	}

	// Token: 0x0600EC4F RID: 60495 RVA: 0x0053061F File Offset: 0x0052E81F
	public void DNDDCKDKKHI(float KEDDLFDAIDE)
	{
		this.CBNKJGPOLMG.lerpSpeed = KEDDLFDAIDE;
	}

	// Token: 0x0600EC50 RID: 60496 RVA: 0x00530062 File Offset: 0x0052E262
	public void DICHOHBLHAH(Color MGHJCGBNEPL, Color NBPMHDANECK, float MNHBOECHFEG)
	{
		this.color1 = MGHJCGBNEPL;
		this.color2 = NBPMHDANECK;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600EC51 RID: 60497 RVA: 0x0053126F File Offset: 0x0052F46F
	public virtual void MCIEAOAMOIG()
	{
		base.OLFNCABJBHA();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.CBNKJGPOLMG = base.GetComponent<DynamicScale>();
		this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600EC52 RID: 60498 RVA: 0x0053129B File Offset: 0x0052F49B
	public virtual void MFAMHKBMBEI()
	{
		base.OKADMJFLMGP();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.CBNKJGPOLMG = base.GetComponent<DynamicScale>();
		this.JFCPJAELJOE = base.GetComponentInParent<PlayerBase>();
	}

	// Token: 0x0600EC53 RID: 60499 RVA: 0x00530046 File Offset: 0x0052E246
	public void GFBAGLKILDG(Vector3 JJIJODIEBFP)
	{
		this.CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	// Token: 0x0600EC54 RID: 60500 RVA: 0x00530095 File Offset: 0x0052E295
	public void SetEmission(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600EC55 RID: 60501 RVA: 0x00530054 File Offset: 0x0052E254
	public void LGDMAKOAICA(int CDPLIMAJBGF)
	{
		this.CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	// Token: 0x0600EC56 RID: 60502 RVA: 0x00530046 File Offset: 0x0052E246
	public void LPNMGHEPBKK(Vector3 JJIJODIEBFP)
	{
		this.CBNKJGPOLMG.maxSize = JJIJODIEBFP;
	}

	// Token: 0x0600EC57 RID: 60503 RVA: 0x005312C8 File Offset: 0x0052F4C8
	public virtual void OMAEOBBHHCP()
	{
		base.LAACNNJDKBI();
		this.CBNKJGPOLMG.MANOCIJICLG();
		this.progress = 619f;
		this.color1 = new Color(365f, 1274f, 916f);
		this.color2 = new Color(1721f, 814f, 1397f);
		this.colorLerp = 1192f;
		this.emission = 1377f;
	}

	// Token: 0x0600EC58 RID: 60504 RVA: 0x00530054 File Offset: 0x0052E254
	public void LGFILNGJAOH(int CDPLIMAJBGF)
	{
		this.CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	// Token: 0x0600EC59 RID: 60505 RVA: 0x00530054 File Offset: 0x0052E254
	public void SetInput(int CDPLIMAJBGF)
	{
		this.CBNKJGPOLMG.frequencyRange = (FrequencyRange)CDPLIMAJBGF;
	}

	// Token: 0x04001A7A RID: 6778
	public float progress = 1f;

	// Token: 0x04001A7B RID: 6779
	public Color color1;

	// Token: 0x04001A7C RID: 6780
	public Color color2;

	// Token: 0x04001A7D RID: 6781
	public float colorLerp = 10f;

	// Token: 0x04001A7E RID: 6782
	public float emission = 1.5f;

	// Token: 0x04001A7F RID: 6783
	private Renderer HKIDNEAKGNO;

	// Token: 0x04001A80 RID: 6784
	private DynamicScale CBNKJGPOLMG;

	// Token: 0x04001A81 RID: 6785
	private PlayerBase JFCPJAELJOE;
}
