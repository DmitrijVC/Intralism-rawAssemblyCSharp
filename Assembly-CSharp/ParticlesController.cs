using System;
using AudioVisualizer;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x020003D1 RID: 977
public class ParticlesController : EnvironmentController
{
	// Token: 0x0600DCFF RID: 56575 RVA: 0x004E3E01 File Offset: 0x004E2001
	public override void Awake()
	{
		base.Awake();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.MEAJNJKMKPA = base.GetComponent<ParticleSystem>();
		this.JAJLKKICEPG = base.GetComponent<AudioEventListener>();
	}

	// Token: 0x0600DD00 RID: 56576 RVA: 0x004E3E01 File Offset: 0x004E2001
	public virtual void MADENBGHKDD()
	{
		base.Awake();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.MEAJNJKMKPA = base.GetComponent<ParticleSystem>();
		this.JAJLKKICEPG = base.GetComponent<AudioEventListener>();
	}

	// Token: 0x0600DD01 RID: 56577 RVA: 0x004E3E30 File Offset: 0x004E2030
	public virtual void OGKGIAAACAD()
	{
		base.Reset();
		this.JAJLKKICEPG.KHGOJDPMPML();
		this.color = new Color(431f, 152f, 492f);
		this.colorLerp = 1750f;
		this.emission = 1810f;
		this.particlesPerBit = -3;
		this.JAJLKKICEPG.OnBeat.AddListener(new UnityAction(this.EPDLOFDOBHD));
		this.SetParticleSize(1099f);
	}

	// Token: 0x0600DD02 RID: 56578 RVA: 0x004E3EAD File Offset: 0x004E20AD
	public void MBGGKLDJICH()
	{
		this.MEAJNJKMKPA.Emit(this.particlesPerBit);
	}

	// Token: 0x0600DD03 RID: 56579 RVA: 0x004E3EC0 File Offset: 0x004E20C0
	public virtual void EHJJFJCKGAJ()
	{
		base.EHCGBJDFMHG();
		this.HKIDNEAKGNO.material.SetColor("CameraFilterPack/Vision_Warp", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("st"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetColor("settings.disablestoryboard", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("[MapsData] Preloading "), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetFloat("_Jitter", Mathf.Lerp(this.HKIDNEAKGNO.material.GetFloat("_Fade"), this.emission * 1163f, Time.smoothDeltaTime * this.colorLerp));
	}

	// Token: 0x0600DD04 RID: 56580 RVA: 0x004E3F9C File Offset: 0x004E219C
	public void LHBOODNOJFO(int JMMILEFMACB)
	{
		this.JAJLKKICEPG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	// Token: 0x0600DD05 RID: 56581 RVA: 0x004E3FAC File Offset: 0x004E21AC
	public virtual void JADEDAEMLBN()
	{
		base.Reset();
		this.JAJLKKICEPG.HFFAJNCOJNB();
		this.color = new Color(1596f, 766f, 1312f);
		this.colorLerp = 1844f;
		this.emission = 1994f;
		this.particlesPerBit = 118;
		this.JAJLKKICEPG.OnBeat.AddListener(new UnityAction(this.MBGGKLDJICH));
		this.BBHCJIFFCLO(1244f);
	}

	// Token: 0x0600DD06 RID: 56582 RVA: 0x004E402C File Offset: 0x004E222C
	public void BBHCJIFFCLO(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = this.MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSize = main.startSize;
		startSize.constantMax = 904f * DPNHODJHGJL;
		startSize.constantMin = 1110f;
		main.startSize = startSize;
	}

	// Token: 0x0600DD07 RID: 56583 RVA: 0x004E4070 File Offset: 0x004E2270
	public void JMPJBCGABHD(float DPNHODJHGJL)
	{
		this.MEAJNJKMKPA.main.gravityModifier = DPNHODJHGJL;
	}

	// Token: 0x0600DD08 RID: 56584 RVA: 0x004E4096 File Offset: 0x004E2296
	public void CCGDBJFKBHL(int DPNHODJHGJL)
	{
		this.particlesPerBit = DPNHODJHGJL;
	}

	// Token: 0x0600DD09 RID: 56585 RVA: 0x004E4096 File Offset: 0x004E2296
	public void GJNJDEOCMAF(int DPNHODJHGJL)
	{
		this.particlesPerBit = DPNHODJHGJL;
	}

	// Token: 0x0600DD0A RID: 56586 RVA: 0x004E409F File Offset: 0x004E229F
	public void BABMEBHPHDA(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600DD0B RID: 56587 RVA: 0x004E3F9C File Offset: 0x004E219C
	public void PIIKOIINLHN(int JMMILEFMACB)
	{
		this.JAJLKKICEPG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	// Token: 0x0600DD0C RID: 56588 RVA: 0x004E409F File Offset: 0x004E229F
	public void GLOJHNDCFHA(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600DD0D RID: 56589 RVA: 0x004E40AF File Offset: 0x004E22AF
	public void KKALIMDILEG(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600DD0E RID: 56590 RVA: 0x004E40B8 File Offset: 0x004E22B8
	public virtual void GEPELODHBFN()
	{
		base.HBPLJMJAAHK();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.MEAJNJKMKPA = base.GetComponent<ParticleSystem>();
		this.JAJLKKICEPG = base.GetComponent<AudioEventListener>();
	}

	// Token: 0x0600DD0F RID: 56591 RVA: 0x004E3EAD File Offset: 0x004E20AD
	public void EIPPJIKJOOD()
	{
		this.MEAJNJKMKPA.Emit(this.particlesPerBit);
	}

	// Token: 0x0600DD10 RID: 56592 RVA: 0x004E3F9C File Offset: 0x004E219C
	public void GAKKHKBCFGP(int JMMILEFMACB)
	{
		this.JAJLKKICEPG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	// Token: 0x0600DD11 RID: 56593 RVA: 0x004E40E4 File Offset: 0x004E22E4
	public override void BGDONBMDPGM()
	{
		base.Update();
		this.HKIDNEAKGNO.material.SetColor("bad", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("[LevelEditorScene] Error: You're not logged into Steam!"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetColor("SupportLogger OnJoinedLobby(", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("Object ID. Case-Sensitive"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetFloat("[PlayerController] ", Mathf.Lerp(this.HKIDNEAKGNO.material.GetFloat("_PColor"), this.emission * 984f, Time.smoothDeltaTime * this.colorLerp));
	}

	// Token: 0x0600DD12 RID: 56594 RVA: 0x004E41C0 File Offset: 0x004E23C0
	public override void EMANBHKAONB()
	{
		base.HHJBBHEBJCJ();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.MEAJNJKMKPA = base.GetComponent<ParticleSystem>();
		this.JAJLKKICEPG = base.GetComponent<AudioEventListener>();
	}

	// Token: 0x0600DD13 RID: 56595 RVA: 0x004E3EAD File Offset: 0x004E20AD
	public void FDCDJLFLLCP()
	{
		this.MEAJNJKMKPA.Emit(this.particlesPerBit);
	}

	// Token: 0x0600DD14 RID: 56596 RVA: 0x004E41EC File Offset: 0x004E23EC
	public void MNCIAMGKCOP(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = this.MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
		startSpeed.constantMax = 58f * DPNHODJHGJL;
		startSpeed.constantMin = 520f;
		main.startSpeed = startSpeed;
	}

	// Token: 0x0600DD15 RID: 56597 RVA: 0x004E3EAD File Offset: 0x004E20AD
	public void EPDLOFDOBHD()
	{
		this.MEAJNJKMKPA.Emit(this.particlesPerBit);
	}

	// Token: 0x0600DD16 RID: 56598 RVA: 0x004E422F File Offset: 0x004E242F
	public virtual void OJACCGOHBGH()
	{
		base.OLFNCABJBHA();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.MEAJNJKMKPA = base.GetComponent<ParticleSystem>();
		this.JAJLKKICEPG = base.GetComponent<AudioEventListener>();
	}

	// Token: 0x0600DD17 RID: 56599 RVA: 0x004E40AF File Offset: 0x004E22AF
	public void SetEmission(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600DD18 RID: 56600 RVA: 0x004E425C File Offset: 0x004E245C
	public void SetParticleSpeed(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = this.MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
		startSpeed.constantMax = 1f * DPNHODJHGJL;
		startSpeed.constantMin = 0f;
		main.startSpeed = startSpeed;
	}

	// Token: 0x0600DD19 RID: 56601 RVA: 0x004E42A0 File Offset: 0x004E24A0
	public void PAPHPPBCNDF(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = this.MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
		startSpeed.constantMax = 1571f * DPNHODJHGJL;
		startSpeed.constantMin = 448f;
		main.startSpeed = startSpeed;
	}

	// Token: 0x0600DD1A RID: 56602 RVA: 0x004E3EAD File Offset: 0x004E20AD
	public void NBLKCMGLFOO()
	{
		this.MEAJNJKMKPA.Emit(this.particlesPerBit);
	}

	// Token: 0x0600DD1B RID: 56603 RVA: 0x004E42E4 File Offset: 0x004E24E4
	public void HEFDKAKLJMB(float DPNHODJHGJL)
	{
		this.MEAJNJKMKPA.main.gravityModifier = DPNHODJHGJL;
	}

	// Token: 0x0600DD1C RID: 56604 RVA: 0x004E430C File Offset: 0x004E250C
	public void GPLOPKHCDKP(float DPNHODJHGJL)
	{
		this.MEAJNJKMKPA.main.gravityModifier = DPNHODJHGJL;
	}

	// Token: 0x0600DD1D RID: 56605 RVA: 0x004E409F File Offset: 0x004E229F
	public void SetColor(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600DD1E RID: 56606 RVA: 0x004E4332 File Offset: 0x004E2532
	public virtual void LFHKGIHNONL()
	{
		base.FMAFBLKAJDF();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.MEAJNJKMKPA = base.GetComponent<ParticleSystem>();
		this.JAJLKKICEPG = base.GetComponent<AudioEventListener>();
	}

	// Token: 0x0600DD1F RID: 56607 RVA: 0x004E4360 File Offset: 0x004E2560
	public void ODOIBJOKNEC(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = this.MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
		startSpeed.constantMax = 705f * DPNHODJHGJL;
		startSpeed.constantMin = 1171f;
		main.startSpeed = startSpeed;
	}

	// Token: 0x0600DD20 RID: 56608 RVA: 0x004E40AF File Offset: 0x004E22AF
	public void FDKDBAOGBGI(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600DD21 RID: 56609 RVA: 0x004E43A4 File Offset: 0x004E25A4
	public void SetParticleSize(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = this.MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSize = main.startSize;
		startSize.constantMax = 0.02f * DPNHODJHGJL;
		startSize.constantMin = 0f;
		main.startSize = startSize;
	}

	// Token: 0x0600DD22 RID: 56610 RVA: 0x004E43E8 File Offset: 0x004E25E8
	public override void EGFBPCMCNDJ()
	{
		base.EGFBPCMCNDJ();
		this.JAJLKKICEPG.FDNKDOOEHBA();
		this.color = new Color(1114f, 750f, 21f);
		this.colorLerp = 721f;
		this.emission = 226f;
		this.particlesPerBit = 37;
		this.JAJLKKICEPG.OnBeat.AddListener(new UnityAction(this.NBLKCMGLFOO));
		this.SetParticleSize(1598f);
	}

	// Token: 0x0600DD23 RID: 56611 RVA: 0x004E4465 File Offset: 0x004E2665
	public virtual void GBNOIKAPBBO()
	{
		base.GMIOCKFLJAK();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.MEAJNJKMKPA = base.GetComponent<ParticleSystem>();
		this.JAJLKKICEPG = base.GetComponent<AudioEventListener>();
	}

	// Token: 0x0600DD24 RID: 56612 RVA: 0x004E40AF File Offset: 0x004E22AF
	public void JMFHNBLFEIE(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600DD25 RID: 56613 RVA: 0x004E4494 File Offset: 0x004E2694
	public virtual void OPCLBGHAPMG()
	{
		base.CFIAKIJAILI();
		this.HKIDNEAKGNO.material.SetColor("R2", Color.Lerp(this.HKIDNEAKGNO.material.GetColor(".lastCheckpoint.longestComboScore"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetColor("settings.cameramovements", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("NEW_ACHIEVEMENT_1_26"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetFloat("LevelInfoInputField", Mathf.Lerp(this.HKIDNEAKGNO.material.GetFloat("challenges."), this.emission * 967f, Time.smoothDeltaTime * this.colorLerp));
	}

	// Token: 0x0600DD26 RID: 56614 RVA: 0x004E4570 File Offset: 0x004E2770
	public virtual void LJEFMGOBKGE()
	{
		base.EMANBHKAONB();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.MEAJNJKMKPA = base.GetComponent<ParticleSystem>();
		this.JAJLKKICEPG = base.GetComponent<AudioEventListener>();
	}

	// Token: 0x0600DD27 RID: 56615 RVA: 0x004E3EAD File Offset: 0x004E20AD
	public void Beat()
	{
		this.MEAJNJKMKPA.Emit(this.particlesPerBit);
	}

	// Token: 0x0600DD28 RID: 56616 RVA: 0x004E3F9C File Offset: 0x004E219C
	public void OFIJNACNPNI(int JMMILEFMACB)
	{
		this.JAJLKKICEPG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	// Token: 0x0600DD29 RID: 56617 RVA: 0x004E459C File Offset: 0x004E279C
	public void DMOGNGJDADN(float DPNHODJHGJL)
	{
		this.MEAJNJKMKPA.main.gravityModifier = DPNHODJHGJL;
	}

	// Token: 0x0600DD2A RID: 56618 RVA: 0x004E409F File Offset: 0x004E229F
	public void PLHOPLBKKGE(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600DD2B RID: 56619 RVA: 0x004E45C4 File Offset: 0x004E27C4
	public void OGDNJLMLAEH(float DPNHODJHGJL)
	{
		this.MEAJNJKMKPA.main.gravityModifier = DPNHODJHGJL;
	}

	// Token: 0x0600DD2C RID: 56620 RVA: 0x004E45EC File Offset: 0x004E27EC
	public override void Reset()
	{
		base.Reset();
		this.JAJLKKICEPG.Reset();
		this.color = new Color(1f, 1f, 1f);
		this.colorLerp = 10f;
		this.emission = 0.75f;
		this.particlesPerBit = 50;
		this.JAJLKKICEPG.OnBeat.AddListener(new UnityAction(this.Beat));
		this.SetParticleSize(1f);
	}

	// Token: 0x0600DD2D RID: 56621 RVA: 0x004E409F File Offset: 0x004E229F
	public void GDENGLNNBLG(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600DD2E RID: 56622 RVA: 0x004E466C File Offset: 0x004E286C
	public virtual void GCHBGCGBMCK()
	{
		base.BGDONBMDPGM();
		this.HKIDNEAKGNO.material.SetColor("sfxVolume", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("_Intensity"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetColor("\\\\", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("menu.playedpage"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetFloat("_FarCamera", Mathf.Lerp(this.HKIDNEAKGNO.material.GetFloat("SetSunMaxSize"), this.emission * 1702f, Time.smoothDeltaTime * this.colorLerp));
	}

	// Token: 0x0600DD2F RID: 56623 RVA: 0x004E3EAD File Offset: 0x004E20AD
	public void EHBPMCMHOCI()
	{
		this.MEAJNJKMKPA.Emit(this.particlesPerBit);
	}

	// Token: 0x0600DD30 RID: 56624 RVA: 0x004E40AF File Offset: 0x004E22AF
	public void IGHBDMLKAPN(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600DD31 RID: 56625 RVA: 0x004E4748 File Offset: 0x004E2948
	public virtual void LBOBAIGNOML()
	{
		base.IOMCHHBGJEC();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.MEAJNJKMKPA = base.GetComponent<ParticleSystem>();
		this.JAJLKKICEPG = base.GetComponent<AudioEventListener>();
	}

	// Token: 0x0600DD32 RID: 56626 RVA: 0x004E4096 File Offset: 0x004E2296
	public void CBNEEGEGJOH(int DPNHODJHGJL)
	{
		this.particlesPerBit = DPNHODJHGJL;
	}

	// Token: 0x0600DD33 RID: 56627 RVA: 0x004E4774 File Offset: 0x004E2974
	public virtual void LBMLGIAKJCH()
	{
		base.GONKPNAAIEE();
		this.JAJLKKICEPG.LPFLJILPAAH();
		this.color = new Color(1196f, 598f, 1166f);
		this.colorLerp = 811f;
		this.emission = 872f;
		this.particlesPerBit = 1;
		this.JAJLKKICEPG.OnBeat.AddListener(new UnityAction(this.EHBPMCMHOCI));
		this.BBHCJIFFCLO(51f);
	}

	// Token: 0x0600DD34 RID: 56628 RVA: 0x004E47F4 File Offset: 0x004E29F4
	public void SetGravity(float DPNHODJHGJL)
	{
		this.MEAJNJKMKPA.main.gravityModifier = DPNHODJHGJL;
	}

	// Token: 0x0600DD35 RID: 56629 RVA: 0x004E40AF File Offset: 0x004E22AF
	public void KGGJDLHKHHL(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600DD36 RID: 56630 RVA: 0x004E481A File Offset: 0x004E2A1A
	public override void OKADMJFLMGP()
	{
		base.FAAJAMIGJNK();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.MEAJNJKMKPA = base.GetComponent<ParticleSystem>();
		this.JAJLKKICEPG = base.GetComponent<AudioEventListener>();
	}

	// Token: 0x0600DD37 RID: 56631 RVA: 0x004E4848 File Offset: 0x004E2A48
	public void OKGAOAMGLPO(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = this.MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
		startSpeed.constantMax = 70f * DPNHODJHGJL;
		startSpeed.constantMin = 218f;
		main.startSpeed = startSpeed;
	}

	// Token: 0x0600DD38 RID: 56632 RVA: 0x004E409F File Offset: 0x004E229F
	public void NFBHGMNGKDC(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600DD39 RID: 56633 RVA: 0x004E3F9C File Offset: 0x004E219C
	public void NINKMGDIBIN(int JMMILEFMACB)
	{
		this.JAJLKKICEPG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	// Token: 0x0600DD3A RID: 56634 RVA: 0x004E488C File Offset: 0x004E2A8C
	public virtual void LDDKCCMHMIC()
	{
		base.BGDONBMDPGM();
		this.HKIDNEAKGNO.material.SetColor("player.deleted", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("Joystick1Button1"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetColor("_Value4", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("_ScreenResolution"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetFloat("[PlayerBase] Loaded environment: ", Mathf.Lerp(this.HKIDNEAKGNO.material.GetFloat("{0}"), this.emission * 790f, Time.smoothDeltaTime * this.colorLerp));
	}

	// Token: 0x0600DD3C RID: 56636 RVA: 0x004E49A8 File Offset: 0x004E2BA8
	public void KMODDDDIEEP(float DPNHODJHGJL)
	{
		this.MEAJNJKMKPA.main.gravityModifier = DPNHODJHGJL;
	}

	// Token: 0x0600DD3D RID: 56637 RVA: 0x004E409F File Offset: 0x004E229F
	public void NOONLBIIGKO(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600DD3E RID: 56638 RVA: 0x004E49D0 File Offset: 0x004E2BD0
	public virtual void KIEJKBNBHMD()
	{
		base.BGDONBMDPGM();
		this.HKIDNEAKGNO.material.SetColor("Cant send PickupItem spawn times to unknown targetPlayer.", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("_Value"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetColor("IconImage", Color.Lerp(this.HKIDNEAKGNO.material.GetColor(").png"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetFloat("ticket.ticket1", Mathf.Lerp(this.HKIDNEAKGNO.material.GetFloat("_ScreenResolution"), this.emission * 1932f, Time.smoothDeltaTime * this.colorLerp));
	}

	// Token: 0x0600DD3F RID: 56639 RVA: 0x004E41C0 File Offset: 0x004E23C0
	public virtual void PEMPABLNJHL()
	{
		base.HHJBBHEBJCJ();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.MEAJNJKMKPA = base.GetComponent<ParticleSystem>();
		this.JAJLKKICEPG = base.GetComponent<AudioEventListener>();
	}

	// Token: 0x0600DD40 RID: 56640 RVA: 0x004E4AAC File Offset: 0x004E2CAC
	public override void CEACMFGNDEB()
	{
		base.LAACNNJDKBI();
		this.JAJLKKICEPG.PDDIOCCBAIL();
		this.color = new Color(1627f, 1187f, 1603f);
		this.colorLerp = 675f;
		this.emission = 1592f;
		this.particlesPerBit = 97;
		this.JAJLKKICEPG.OnBeat.AddListener(new UnityAction(this.MBGGKLDJICH));
		this.BBHCJIFFCLO(1361f);
	}

	// Token: 0x0600DD41 RID: 56641 RVA: 0x004E4B2C File Offset: 0x004E2D2C
	public void MFIMFONHFBP(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = this.MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
		startSpeed.constantMax = 279f * DPNHODJHGJL;
		startSpeed.constantMin = 1549f;
		main.startSpeed = startSpeed;
	}

	// Token: 0x0600DD42 RID: 56642 RVA: 0x004E4096 File Offset: 0x004E2296
	public void FNHHELEALEG(int DPNHODJHGJL)
	{
		this.particlesPerBit = DPNHODJHGJL;
	}

	// Token: 0x0600DD43 RID: 56643 RVA: 0x004E3F9C File Offset: 0x004E219C
	public void MANIAKFKOMP(int JMMILEFMACB)
	{
		this.JAJLKKICEPG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	// Token: 0x0600DD44 RID: 56644 RVA: 0x004E4B70 File Offset: 0x004E2D70
	public virtual void GPFJMKCGHGB()
	{
		base.Update();
		this.HKIDNEAKGNO.material.SetColor("</color>", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("_TimeX"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetColor("_Value3", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("DPADHOR"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetFloat("\n", Mathf.Lerp(this.HKIDNEAKGNO.material.GetFloat("LevelEditor/patterns"), this.emission * 363f, Time.smoothDeltaTime * this.colorLerp));
	}

	// Token: 0x0600DD45 RID: 56645 RVA: 0x004E3F9C File Offset: 0x004E219C
	public void CGJFHCMNENI(int JMMILEFMACB)
	{
		this.JAJLKKICEPG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	// Token: 0x0600DD46 RID: 56646 RVA: 0x004E4C4C File Offset: 0x004E2E4C
	public void MKNFLKBBIEI(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = this.MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSize = main.startSize;
		startSize.constantMax = 435f * DPNHODJHGJL;
		startSize.constantMin = 1330f;
		main.startSize = startSize;
	}

	// Token: 0x0600DD47 RID: 56647 RVA: 0x004E4570 File Offset: 0x004E2770
	public virtual void GGKPLCJNEHF()
	{
		base.EMANBHKAONB();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.MEAJNJKMKPA = base.GetComponent<ParticleSystem>();
		this.JAJLKKICEPG = base.GetComponent<AudioEventListener>();
	}

	// Token: 0x0600DD48 RID: 56648 RVA: 0x004E422F File Offset: 0x004E242F
	public virtual void KGMCGGIEPDE()
	{
		base.OLFNCABJBHA();
		this.HKIDNEAKGNO = base.GetComponent<Renderer>();
		this.MEAJNJKMKPA = base.GetComponent<ParticleSystem>();
		this.JAJLKKICEPG = base.GetComponent<AudioEventListener>();
	}

	// Token: 0x0600DD49 RID: 56649 RVA: 0x004E4C90 File Offset: 0x004E2E90
	public virtual void AIJGAJIOJDJ()
	{
		base.EHCGBJDFMHG();
		this.HKIDNEAKGNO.material.SetColor("[Singleton] multiple instances of '", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("settings.enableranking"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetColor(" = ", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("SetSunInput"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetFloat("[ResourcesManager] Load image error: ", Mathf.Lerp(this.HKIDNEAKGNO.material.GetFloat("_Screen"), this.emission * 1746f, Time.smoothDeltaTime * this.colorLerp));
	}

	// Token: 0x0600DD4A RID: 56650 RVA: 0x004E4D6C File Offset: 0x004E2F6C
	public void HBKKOHNGBNM(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = this.MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
		startSpeed.constantMax = 600f * DPNHODJHGJL;
		startSpeed.constantMin = 820f;
		main.startSpeed = startSpeed;
	}

	// Token: 0x0600DD4B RID: 56651 RVA: 0x004E4DB0 File Offset: 0x004E2FB0
	public void KJMIHJOKAPP(float DPNHODJHGJL)
	{
		this.MEAJNJKMKPA.main.gravityModifier = DPNHODJHGJL;
	}

	// Token: 0x0600DD4C RID: 56652 RVA: 0x004E3F9C File Offset: 0x004E219C
	public void IGEAPHGPAML(int JMMILEFMACB)
	{
		this.JAJLKKICEPG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	// Token: 0x0600DD4D RID: 56653 RVA: 0x004E409F File Offset: 0x004E229F
	public void MOGLPIBCCPI(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600DD4E RID: 56654 RVA: 0x004E3F9C File Offset: 0x004E219C
	public void PPBBONBFIPG(int JMMILEFMACB)
	{
		this.JAJLKKICEPG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	// Token: 0x0600DD4F RID: 56655 RVA: 0x004E409F File Offset: 0x004E229F
	public void NGJMONJPAKB(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600DD50 RID: 56656 RVA: 0x004E3EAD File Offset: 0x004E20AD
	public void KEOFFJJNKME()
	{
		this.MEAJNJKMKPA.Emit(this.particlesPerBit);
	}

	// Token: 0x0600DD51 RID: 56657 RVA: 0x004E3EAD File Offset: 0x004E20AD
	public void GGFFDJALCEK()
	{
		this.MEAJNJKMKPA.Emit(this.particlesPerBit);
	}

	// Token: 0x0600DD52 RID: 56658 RVA: 0x004E4096 File Offset: 0x004E2296
	public void HAICKBPCHBK(int DPNHODJHGJL)
	{
		this.particlesPerBit = DPNHODJHGJL;
	}

	// Token: 0x0600DD53 RID: 56659 RVA: 0x004E409F File Offset: 0x004E229F
	public void HOCOJMHOCPA(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600DD54 RID: 56660 RVA: 0x004E4DD8 File Offset: 0x004E2FD8
	public void CDGMLEOBIGM(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = this.MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSize = main.startSize;
		startSize.constantMax = 632f * DPNHODJHGJL;
		startSize.constantMin = 1529f;
		main.startSize = startSize;
	}

	// Token: 0x0600DD55 RID: 56661 RVA: 0x004E4E1C File Offset: 0x004E301C
	public void LOKBBBFIEMK(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = this.MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
		startSpeed.constantMax = 684f * DPNHODJHGJL;
		startSpeed.constantMin = 1939f;
		main.startSpeed = startSpeed;
	}

	// Token: 0x0600DD56 RID: 56662 RVA: 0x004E4E60 File Offset: 0x004E3060
	public virtual void NFEDLAOPHML()
	{
		base.Update();
		this.HKIDNEAKGNO.material.SetColor("note.0", Color.Lerp(this.HKIDNEAKGNO.material.GetColor(".highscore"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetColor("{0}", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("GlassAberration"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetFloat("shader.frost", Mathf.Lerp(this.HKIDNEAKGNO.material.GetFloat("Added checkpoint"), this.emission * 1683f, Time.smoothDeltaTime * this.colorLerp));
	}

	// Token: 0x0600DD57 RID: 56663 RVA: 0x004E4096 File Offset: 0x004E2296
	public void MIDOJPKHNAA(int DPNHODJHGJL)
	{
		this.particlesPerBit = DPNHODJHGJL;
	}

	// Token: 0x0600DD58 RID: 56664 RVA: 0x004E4F3C File Offset: 0x004E313C
	public void OLIGEOJEMJP(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = this.MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
		startSpeed.constantMax = 1311f * DPNHODJHGJL;
		startSpeed.constantMin = 1377f;
		main.startSpeed = startSpeed;
	}

	// Token: 0x0600DD59 RID: 56665 RVA: 0x004E4F80 File Offset: 0x004E3180
	public void NHDGAAFDJIJ(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = this.MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
		startSpeed.constantMax = 23f * DPNHODJHGJL;
		startSpeed.constantMin = 612f;
		main.startSpeed = startSpeed;
	}

	// Token: 0x0600DD5A RID: 56666 RVA: 0x004E4096 File Offset: 0x004E2296
	public void SetParticleCountPerBeat(int DPNHODJHGJL)
	{
		this.particlesPerBit = DPNHODJHGJL;
	}

	// Token: 0x0600DD5B RID: 56667 RVA: 0x004E3F9C File Offset: 0x004E219C
	public void IHHPNMGIPPL(int JMMILEFMACB)
	{
		this.JAJLKKICEPG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	// Token: 0x0600DD5C RID: 56668 RVA: 0x004E4FC4 File Offset: 0x004E31C4
	public void BKNPCNOOPMK(float DPNHODJHGJL)
	{
		ParticleSystem.MainModule main = this.MEAJNJKMKPA.main;
		ParticleSystem.MinMaxCurve startSpeed = main.startSpeed;
		startSpeed.constantMax = 1764f * DPNHODJHGJL;
		startSpeed.constantMin = 1491f;
		main.startSpeed = startSpeed;
	}

	// Token: 0x0600DD5D RID: 56669 RVA: 0x004E4096 File Offset: 0x004E2296
	public void DIDMMBIIHEF(int DPNHODJHGJL)
	{
		this.particlesPerBit = DPNHODJHGJL;
	}

	// Token: 0x0600DD5E RID: 56670 RVA: 0x004E4096 File Offset: 0x004E2296
	public void MMHDOGBBLKH(int DPNHODJHGJL)
	{
		this.particlesPerBit = DPNHODJHGJL;
	}

	// Token: 0x0600DD5F RID: 56671 RVA: 0x004E5008 File Offset: 0x004E3208
	public virtual void MANOCIJICLG()
	{
		base.LAACNNJDKBI();
		this.JAJLKKICEPG.HFFAJNCOJNB();
		this.color = new Color(1420f, 1138f, 822f);
		this.colorLerp = 664f;
		this.emission = 589f;
		this.particlesPerBit = 34;
		this.JAJLKKICEPG.OnBeat.AddListener(new UnityAction(this.NBLKCMGLFOO));
		this.CDGMLEOBIGM(461f);
	}

	// Token: 0x0600DD60 RID: 56672 RVA: 0x004E3F9C File Offset: 0x004E219C
	public void SetInput(int JMMILEFMACB)
	{
		this.JAJLKKICEPG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	// Token: 0x0600DD61 RID: 56673 RVA: 0x004E40AF File Offset: 0x004E22AF
	public void MOGAJELFJOF(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600DD62 RID: 56674 RVA: 0x004E5088 File Offset: 0x004E3288
	public override void Update()
	{
		base.Update();
		this.HKIDNEAKGNO.material.SetColor("_DiffuseColor", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("_DiffuseColor"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetColor("_EmissionColor", Color.Lerp(this.HKIDNEAKGNO.material.GetColor("_EmissionColor"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.HKIDNEAKGNO.material.SetFloat("_EmissionGain", Mathf.Lerp(this.HKIDNEAKGNO.material.GetFloat("_EmissionGain"), this.emission * 0.2f, Time.smoothDeltaTime * this.colorLerp));
	}

	// Token: 0x040018E1 RID: 6369
	public Color color = new Color(1f, 1f, 1f);

	// Token: 0x040018E2 RID: 6370
	public float colorLerp = 10f;

	// Token: 0x040018E3 RID: 6371
	public float emission = 0.75f;

	// Token: 0x040018E4 RID: 6372
	public int particlesPerBit = 100;

	// Token: 0x040018E5 RID: 6373
	private Renderer HKIDNEAKGNO;

	// Token: 0x040018E6 RID: 6374
	private ParticleSystem MEAJNJKMKPA;

	// Token: 0x040018E7 RID: 6375
	private AudioEventListener JAJLKKICEPG;
}
