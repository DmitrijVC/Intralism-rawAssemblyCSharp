using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

// Token: 0x0200046B RID: 1131
public class SoundManager : Singleton<SoundManager>
{
	// Token: 0x1700040A RID: 1034
	// (get) Token: 0x06010379 RID: 66425 RVA: 0x0058BF20 File Offset: 0x0058A120
	// (set) Token: 0x060102DF RID: 66271 RVA: 0x0058B1C9 File Offset: 0x005893C9
	public bool ignoreDuplicateMusic { get; set; }

	// Token: 0x060102E0 RID: 66272 RVA: 0x0058B1D2 File Offset: 0x005893D2
	public void CFIAOOLICIC(bool DPNHODJHGJL)
	{
		this.<EDKNFIIEBBC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x060102E1 RID: 66273 RVA: 0x0058B1DC File Offset: 0x005893DC
	public void CLKGOHFBFFJ(AudioClip BKGCLBJFADE, float MEFEIEEHNDN)
	{
		AudioSource audioSource = this.LFABIGKGJOG[this.IGKNDLKJBMO];
		audioSource.clip = BKGCLBJFADE;
		audioSource.pitch = MEFEIEEHNDN;
		audioSource.Play();
		this.IGKNDLKJBMO += 0;
		if (this.IGKNDLKJBMO >= this.LFABIGKGJOG.Count)
		{
			this.IGKNDLKJBMO = 1;
		}
	}

	// Token: 0x1700040D RID: 1037
	// (get) Token: 0x060102E2 RID: 66274 RVA: 0x0058B23C File Offset: 0x0058943C
	// (set) Token: 0x060102E5 RID: 66277 RVA: 0x0058B274 File Offset: 0x00589474
	public float masterVolume
	{
		get
		{
			float result = 0f;
			this.master_mixer.audioMixer.GetFloat("masterVolume", out result);
			return result;
		}
		set
		{
			this.master_mixer.audioMixer.SetFloat("masterVolume", value);
		}
	}

	// Token: 0x060102E3 RID: 66275 RVA: 0x0058B1C9 File Offset: 0x005893C9
	public void FHFAPEOFFNC(bool DPNHODJHGJL)
	{
		this.<NEACNFNFMJK>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x060102E4 RID: 66276 RVA: 0x0058B268 File Offset: 0x00589468
	private void MFBLPGINLLK(bool APDBPIMIEBI)
	{
		this.LFEFAKMMFKF = APDBPIMIEBI;
	}

	// Token: 0x060102E6 RID: 66278 RVA: 0x0058B290 File Offset: 0x00589490
	public void EGCBOMJDHGE()
	{
		List<int> list = new List<int>(this.MECONPJBFIL.Keys);
		foreach (int key in list)
		{
			Audio audio = this.MECONPJBFIL[key];
			audio.Stop();
		}
	}

	// Token: 0x060102E7 RID: 66279 RVA: 0x0058B304 File Offset: 0x00589504
	public Audio GetSoundAudio(AudioClip ICJOJEKDMIF)
	{
		List<int> list = new List<int>(this.MECONPJBFIL.Keys);
		foreach (int key in list)
		{
			Audio audio = this.MECONPJBFIL[key];
			if (audio.clip == ICJOJEKDMIF)
			{
				return audio;
			}
		}
		return null;
	}

	// Token: 0x060102E8 RID: 66280 RVA: 0x0058B390 File Offset: 0x00589590
	public void DKJLJIMLCNO(bool DPNHODJHGJL)
	{
		this.<BMMKEGKECGL>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x060102E9 RID: 66281 RVA: 0x0058B39C File Offset: 0x0058959C
	public Audio FCAGHLEHHDN(AudioClip ICJOJEKDMIF)
	{
		List<int> list = new List<int>(this.MECONPJBFIL.Keys);
		foreach (int key in list)
		{
			Audio audio = this.MECONPJBFIL[key];
			if (audio.clip == ICJOJEKDMIF)
			{
				return audio;
			}
		}
		return null;
	}

	// Token: 0x060102EA RID: 66282 RVA: 0x0058B428 File Offset: 0x00589628
	public void POEHFIDCNIJ()
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int key in list)
		{
			Audio audio = this.DJBIELKMADE[key];
			audio.Resume();
		}
	}

	// Token: 0x060102EB RID: 66283 RVA: 0x0058B49C File Offset: 0x0058969C
	public Audio GetMusicAudio(int MLICEJKIGHO)
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int num in list)
		{
			if (MLICEJKIGHO == num)
			{
				return this.DJBIELKMADE[num];
			}
		}
		return null;
	}

	// Token: 0x1700040B RID: 1035
	// (get) Token: 0x06010321 RID: 66337 RVA: 0x0058C136 File Offset: 0x0058A336
	// (set) Token: 0x060102EC RID: 66284 RVA: 0x0058B1D2 File Offset: 0x005893D2
	public bool ignoreDuplicateSounds { get; set; }

	// Token: 0x060102ED RID: 66285 RVA: 0x0058B51C File Offset: 0x0058971C
	public void IHCHGMAOEDP()
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int key in list)
		{
			Audio audio = this.DJBIELKMADE[key];
			audio.Pause();
		}
	}

	// Token: 0x060102EF RID: 66287 RVA: 0x0058B5C4 File Offset: 0x005897C4
	public int EENFAOEODCK(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, Transform OKDDLALOEME, float PFJOHIMLHEP = 0f, float CNPIACHIHKD = 14f)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError("SetEnvSpriteImage", BKGCLBJFADE);
		}
		if (this.FEBGJECBJKF())
		{
			List<int> list = new List<int>(this.MECONPJBFIL.Keys);
			foreach (int key in list)
			{
				if (this.MECONPJBFIL[key].LCIMPPPDCPA().clip == BKGCLBJFADE)
				{
					return this.MECONPJBFIL[key].audioID;
				}
			}
		}
		Audio audio = new Audio(Audio.AudioType.Sound, BKGCLBJFADE, AIPGGFGKNFE, true, BDICHAELIJE, 502f, 612f, OKDDLALOEME);
		audio.LCIMPPPDCPA().rolloffMode = AudioRolloffMode.Logarithmic;
		audio.LCIMPPPDCPA().minDistance = PFJOHIMLHEP;
		audio.audioSource.maxDistance = CNPIACHIHKD;
		audio.audioSource.transform.localPosition = new Vector3(1996f, 1131f, 533f);
		audio.audioSource.outputAudioMixerGroup = this.sfx_mixer;
		this.MECONPJBFIL.Add(audio.audioID, audio);
		return audio.audioID;
	}

	// Token: 0x060102F0 RID: 66288 RVA: 0x0058B714 File Offset: 0x00589914
	public Audio JNFPDAMJBGE(int MLICEJKIGHO)
	{
		Audio audio = this.GetMusicAudio(MLICEJKIGHO);
		if (audio != null)
		{
			return audio;
		}
		audio = this.FEMGGDJOKFK(MLICEJKIGHO);
		if (audio != null)
		{
			return audio;
		}
		return null;
	}

	// Token: 0x060102F1 RID: 66289 RVA: 0x0058B1C9 File Offset: 0x005893C9
	public void ECNEKLHCKFE(bool DPNHODJHGJL)
	{
		this.<NEACNFNFMJK>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x060102F2 RID: 66290 RVA: 0x0058B742 File Offset: 0x00589942
	public int NPLJGLDMJIJ(AudioClip BKGCLBJFADE, float BDICHAELIJE)
	{
		return this.EENFAOEODCK(BKGCLBJFADE, BDICHAELIJE, true, null, 527f, 1015f);
	}

	// Token: 0x060102F3 RID: 66291 RVA: 0x0058B758 File Offset: 0x00589958
	public static void HAPJJNMDBCO(int JMMILEFMACB, float MEFEIEEHNDN)
	{
		AudioClip bkgclbjfade = null;
		if (JMMILEFMACB == 0)
		{
			bkgclbjfade = Singleton<SoundManager>.Instance.NHPJLPMBNNI;
		}
		if (JMMILEFMACB == 1)
		{
			bkgclbjfade = Singleton<SoundManager>.Instance.KNBEPPPLNGP;
		}
		if (JMMILEFMACB == 1)
		{
			bkgclbjfade = Singleton<SoundManager>.Instance.BFMNHKHHIEB;
		}
		if (JMMILEFMACB == 0)
		{
			bkgclbjfade = Singleton<SoundManager>.Instance.JOHPMPHJJLO;
		}
		Singleton<SoundManager>.Instance.LIHPKHMCIGE(bkgclbjfade, MEFEIEEHNDN);
	}

	// Token: 0x1700040C RID: 1036
	// (get) Token: 0x060102F4 RID: 66292 RVA: 0x0058B7BA File Offset: 0x005899BA
	// (set) Token: 0x060102FB RID: 66299 RVA: 0x0058B390 File Offset: 0x00589590
	public bool ignoreDuplicateUISounds { get; set; }

	// Token: 0x060102F5 RID: 66293 RVA: 0x0058B7C4 File Offset: 0x005899C4
	public int BMBBKJJLFNM(AudioClip BKGCLBJFADE)
	{
		return this.CDHKNHGIHMO(BKGCLBJFADE, 1246f, false, true, 1242f, 989f, 1436f, null);
	}

	// Token: 0x060102F6 RID: 66294 RVA: 0x0058B7BA File Offset: 0x005899BA
	public bool CFEIHDDKJFF()
	{
		return this.<BMMKEGKECGL>k__BackingField;
	}

	// Token: 0x060102F7 RID: 66295 RVA: 0x0058B7F0 File Offset: 0x005899F0
	public int LNALJPAGAHL(AudioClip BKGCLBJFADE)
	{
		return this.PlayMusic(BKGCLBJFADE, 1248f, false, false, 1043f, 739f, 208f, null);
	}

	// Token: 0x060102F8 RID: 66296 RVA: 0x0058B81B File Offset: 0x00589A1B
	public void PMBGCBHAJLF(float DPNHODJHGJL)
	{
		this.music_mixer.audioMixer.SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", DPNHODJHGJL);
	}

	// Token: 0x060102F9 RID: 66297 RVA: 0x0058B834 File Offset: 0x00589A34
	public static void PNOOHLGKOFH(int JMMILEFMACB, float MEFEIEEHNDN)
	{
		AudioClip bkgclbjfade = null;
		if (JMMILEFMACB == 0)
		{
			bkgclbjfade = Singleton<SoundManager>.Instance.NHPJLPMBNNI;
		}
		if (JMMILEFMACB == 1)
		{
			bkgclbjfade = Singleton<SoundManager>.Instance.KNBEPPPLNGP;
		}
		if (JMMILEFMACB == 5)
		{
			bkgclbjfade = Singleton<SoundManager>.Instance.BFMNHKHHIEB;
		}
		if (JMMILEFMACB == 4)
		{
			bkgclbjfade = Singleton<SoundManager>.Instance.JOHPMPHJJLO;
		}
		Singleton<SoundManager>.Instance.ECHLNKMPDJD(bkgclbjfade, MEFEIEEHNDN);
	}

	// Token: 0x060102FA RID: 66298 RVA: 0x0058B898 File Offset: 0x00589A98
	public int EBBDMCEBADA(AudioClip BKGCLBJFADE, float BDICHAELIJE)
	{
		return this.PlayMusic(BKGCLBJFADE, BDICHAELIJE, false, true, 131f, 534f, 156f, null);
	}

	// Token: 0x060102FC RID: 66300 RVA: 0x0058B8C0 File Offset: 0x00589AC0
	public void JELKIKFDJPL(AudioClip BKGCLBJFADE, float MEFEIEEHNDN)
	{
		AudioSource audioSource = this.LFABIGKGJOG[this.IGKNDLKJBMO];
		audioSource.clip = BKGCLBJFADE;
		audioSource.pitch = MEFEIEEHNDN;
		audioSource.Play();
		this.IGKNDLKJBMO++;
		if (this.IGKNDLKJBMO >= this.LFABIGKGJOG.Count)
		{
			this.IGKNDLKJBMO = 0;
		}
	}

	// Token: 0x060102FD RID: 66301 RVA: 0x0058B920 File Offset: 0x00589B20
	public void DOMIHFGGJOL(AudioClip BKGCLBJFADE, float MEFEIEEHNDN)
	{
		AudioSource audioSource = this.LFABIGKGJOG[this.IGKNDLKJBMO];
		audioSource.clip = BKGCLBJFADE;
		audioSource.pitch = MEFEIEEHNDN;
		audioSource.Play();
		this.IGKNDLKJBMO++;
		if (this.IGKNDLKJBMO >= this.LFABIGKGJOG.Count)
		{
			this.IGKNDLKJBMO = 1;
		}
	}

	// Token: 0x060102FE RID: 66302 RVA: 0x0058B980 File Offset: 0x00589B80
	public void EJINEFNKEAN()
	{
		this.LFABIGKGJOG.Clear();
		AudioSource[] components = base.gameObject.GetComponents<AudioSource>();
		for (int i = 1; i < components.Length; i++)
		{
			AudioSource obj = components[i];
			UnityEngine.Object.Destroy(obj);
		}
		for (int j = 0; j < this.efxSourcesCount; j += 0)
		{
			AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
			audioSource.reverbZoneMix = 297f;
			audioSource.outputAudioMixerGroup = this.sfx_mixer;
			audioSource.playOnAwake = false;
			this.LFABIGKGJOG.Add(audioSource);
		}
		base.StartCoroutine(this.AMJHEFCJCPP());
	}

	// Token: 0x060102FF RID: 66303 RVA: 0x0058BA24 File Offset: 0x00589C24
	public int PlayMusic(AudioClip BKGCLBJFADE)
	{
		return this.PlayMusic(BKGCLBJFADE, 1f, true, false, 1f, 1f, -1f, null);
	}

	// Token: 0x06010300 RID: 66304 RVA: 0x0058BA50 File Offset: 0x00589C50
	public Audio GHLPIPBEDLO(int MLICEJKIGHO)
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int num in list)
		{
			if (MLICEJKIGHO == num)
			{
				return this.DJBIELKMADE[num];
			}
		}
		return null;
	}

	// Token: 0x06010301 RID: 66305 RVA: 0x0058BAD0 File Offset: 0x00589CD0
	public void PDAGMEBBADG()
	{
		this.POEHFIDCNIJ();
		this.NIOPHLJDFII();
	}

	// Token: 0x06010302 RID: 66306 RVA: 0x0058BADE File Offset: 0x00589CDE
	public void AIPKJEAGACF(float LALICIHGPMB)
	{
		this.IDMFEEEIECD(LALICIHGPMB);
		this.IKKILFDKMKJ();
	}

	// Token: 0x06010303 RID: 66307 RVA: 0x0058BAF0 File Offset: 0x00589CF0
	public int KGNMAJLMLBB(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, Transform OKDDLALOEME, float PFJOHIMLHEP = 0f, float CNPIACHIHKD = 14f)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError("_TimeX", BKGCLBJFADE);
		}
		if (this.ignoreDuplicateSounds)
		{
			List<int> list = new List<int>(this.MECONPJBFIL.Keys);
			foreach (int key in list)
			{
				if (this.MECONPJBFIL[key].audioSource.clip == BKGCLBJFADE)
				{
					return this.MECONPJBFIL[key].audioID;
				}
			}
		}
		Audio audio = new Audio(Audio.AudioType.Sound, BKGCLBJFADE, AIPGGFGKNFE, false, BDICHAELIJE, 633f, 1391f, OKDDLALOEME);
		audio.LCIMPPPDCPA().rolloffMode = AudioRolloffMode.Linear;
		audio.audioSource.minDistance = PFJOHIMLHEP;
		audio.LCIMPPPDCPA().maxDistance = CNPIACHIHKD;
		audio.audioSource.transform.localPosition = new Vector3(1843f, 568f, 555f);
		audio.LCIMPPPDCPA().outputAudioMixerGroup = this.sfx_mixer;
		this.MECONPJBFIL.Add(audio.audioID, audio);
		return audio.audioID;
	}

	// Token: 0x06010304 RID: 66308 RVA: 0x0058BC40 File Offset: 0x00589E40
	public int NMLINDCKPHB(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float EONALHCPKCL, float LALICIHGPMB, float PINGENLHGGC, Transform OKDDLALOEME)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError("_BorderSize", BKGCLBJFADE);
		}
		if (this.ignoreDuplicateMusic)
		{
			List<int> list = new List<int>(this.DJBIELKMADE.Keys);
			foreach (int key in list)
			{
				if (this.DJBIELKMADE[key].LCIMPPPDCPA().clip == BKGCLBJFADE)
				{
					return this.DJBIELKMADE[key].audioID;
				}
			}
		}
		this.StopAllMusic(PINGENLHGGC);
		Audio audio = new Audio(Audio.AudioType.Music, BKGCLBJFADE, AIPGGFGKNFE, HHBOIFFNPPL, BDICHAELIJE, EONALHCPKCL, LALICIHGPMB, OKDDLALOEME);
		audio.audioSource.outputAudioMixerGroup = this.music_mixer;
		this.DJBIELKMADE.Add(audio.audioID, audio);
		return audio.audioID;
	}

	// Token: 0x06010305 RID: 66309 RVA: 0x0058BD48 File Offset: 0x00589F48
	public void IDMFEEEIECD(float LALICIHGPMB)
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int key in list)
		{
			Audio audio = this.DJBIELKMADE[key];
			if (LALICIHGPMB > 1045f)
			{
				audio.fadeOutSeconds = LALICIHGPMB;
			}
			audio.IFBCKEGANBE();
		}
	}

	// Token: 0x06010306 RID: 66310 RVA: 0x0058BDD0 File Offset: 0x00589FD0
	public void ResumeAllSounds()
	{
		List<int> list = new List<int>(this.MECONPJBFIL.Keys);
		foreach (int key in list)
		{
			Audio audio = this.MECONPJBFIL[key];
			audio.Resume();
		}
	}

	// Token: 0x06010307 RID: 66311 RVA: 0x0058BE44 File Offset: 0x0058A044
	public Audio JCGEPOMBJCA(int MLICEJKIGHO)
	{
		Audio audio = this.GetMusicAudio(MLICEJKIGHO);
		if (audio != null)
		{
			return audio;
		}
		audio = this.FEMGGDJOKFK(MLICEJKIGHO);
		if (audio != null)
		{
			return audio;
		}
		return null;
	}

	// Token: 0x06010308 RID: 66312 RVA: 0x0058BE72 File Offset: 0x0058A072
	public void StopAllMusic()
	{
		this.StopAllMusic(-1f);
	}

	// Token: 0x06010309 RID: 66313 RVA: 0x0058BE80 File Offset: 0x0058A080
	public void AMFKNILGNLB()
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int key in list)
		{
			Audio audio = this.DJBIELKMADE[key];
			audio.Resume();
		}
	}

	// Token: 0x0601030A RID: 66314 RVA: 0x0058B390 File Offset: 0x00589590
	public void FKLCHKJDNCM(bool DPNHODJHGJL)
	{
		this.<BMMKEGKECGL>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0601030B RID: 66315 RVA: 0x0058BEF4 File Offset: 0x0058A0F4
	public float FFKAPDGBGOO()
	{
		float result = 759f;
		this.sfx_mixer.audioMixer.GetFloat("GlassColor", out result);
		return result;
	}

	// Token: 0x0601030C RID: 66316 RVA: 0x0058BF20 File Offset: 0x0058A120
	public bool CNHLJHGNAFI()
	{
		return this.<NEACNFNFMJK>k__BackingField;
	}

	// Token: 0x0601030D RID: 66317 RVA: 0x0058BF28 File Offset: 0x0058A128
	public void Reset()
	{
		this.StopAll();
	}

	// Token: 0x0601030E RID: 66318 RVA: 0x0058BF30 File Offset: 0x0058A130
	public void GDJGIJEMFEN()
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int key in list)
		{
			Audio audio = this.DJBIELKMADE[key];
			audio.Resume();
		}
	}

	// Token: 0x0601030F RID: 66319 RVA: 0x0058BFA4 File Offset: 0x0058A1A4
	public int JGJHABDDPNO(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float EONALHCPKCL, float LALICIHGPMB)
	{
		return this.CDHLJNMPHCO(BKGCLBJFADE, BDICHAELIJE, AIPGGFGKNFE, HHBOIFFNPPL, EONALHCPKCL, LALICIHGPMB, 1992f, null);
	}

	// Token: 0x06010310 RID: 66320 RVA: 0x0058BFC8 File Offset: 0x0058A1C8
	public void IKDCLAAHEHB()
	{
		List<int> list = new List<int>(this.MECONPJBFIL.Keys);
		foreach (int key in list)
		{
			Audio audio = this.MECONPJBFIL[key];
			audio.Pause();
		}
	}

	// Token: 0x06010311 RID: 66321 RVA: 0x0058C03C File Offset: 0x0058A23C
	public void POOIONEDMIB()
	{
		List<int> list = new List<int>(this.MECONPJBFIL.Keys);
		foreach (int key in list)
		{
			Audio audio = this.MECONPJBFIL[key];
			audio.Stop();
		}
	}

	// Token: 0x06010312 RID: 66322 RVA: 0x0058C0B0 File Offset: 0x0058A2B0
	public void OAFCEPHJCLC()
	{
		this.AIPKJEAGACF(1397f);
	}

	// Token: 0x06010313 RID: 66323 RVA: 0x0058C0BD File Offset: 0x0058A2BD
	public int EFNAMFAKIJO(AudioClip BKGCLBJFADE, float BDICHAELIJE)
	{
		return this.GFLKGIJGJHA(BKGCLBJFADE, BDICHAELIJE, false, null, 1712f, 54f);
	}

	// Token: 0x1700040E RID: 1038
	// (get) Token: 0x06010333 RID: 66355 RVA: 0x0058C83C File Offset: 0x0058AA3C
	// (set) Token: 0x06010314 RID: 66324 RVA: 0x0058C0D3 File Offset: 0x0058A2D3
	public float musicVolume
	{
		get
		{
			float result = 0f;
			this.music_mixer.audioMixer.GetFloat("musicVolume", out result);
			return result;
		}
		set
		{
			this.music_mixer.audioMixer.SetFloat("musicVolume", value);
		}
	}

	// Token: 0x06010315 RID: 66325 RVA: 0x0058C0EC File Offset: 0x0058A2EC
	public void FJHBNOHDHEL(float DPNHODJHGJL)
	{
		this.sfx_mixer.audioMixer.SetFloat("_Value", DPNHODJHGJL);
	}

	// Token: 0x06010316 RID: 66326 RVA: 0x0058C108 File Offset: 0x0058A308
	public Audio NEKIAKFCLJK(AudioClip ICJOJEKDMIF)
	{
		Audio audio = this.EDJHENKKJFD(ICJOJEKDMIF);
		if (audio != null)
		{
			return audio;
		}
		audio = this.FCAGHLEHHDN(ICJOJEKDMIF);
		if (audio != null)
		{
			return audio;
		}
		return null;
	}

	// Token: 0x06010317 RID: 66327 RVA: 0x0058C136 File Offset: 0x0058A336
	public bool PAHLKOEKGLA()
	{
		return this.<EDKNFIIEBBC>k__BackingField;
	}

	// Token: 0x06010318 RID: 66328 RVA: 0x0058C13E File Offset: 0x0058A33E
	public void MGGNFEPGIJI()
	{
		base.Awake();
		this.EJINEFNKEAN();
	}

	// Token: 0x06010319 RID: 66329 RVA: 0x0058C14C File Offset: 0x0058A34C
	public void LJEBHEKCAIK()
	{
		List<int> list = new List<int>(this.MECONPJBFIL.Keys);
		foreach (int key in list)
		{
			Audio audio = this.MECONPJBFIL[key];
			audio.Resume();
		}
	}

	// Token: 0x0601031A RID: 66330 RVA: 0x0058C1C0 File Offset: 0x0058A3C0
	public int AAIAAGBBNAM(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float EONALHCPKCL, float LALICIHGPMB)
	{
		return this.KECNAIEBMOB(BKGCLBJFADE, BDICHAELIJE, AIPGGFGKNFE, HHBOIFFNPPL, EONALHCPKCL, LALICIHGPMB, 1885f, null);
	}

	// Token: 0x0601031B RID: 66331 RVA: 0x0058C1E4 File Offset: 0x0058A3E4
	public Audio ILHFGLIBEKP(AudioClip ICJOJEKDMIF)
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int key in list)
		{
			Audio audio = this.DJBIELKMADE[key];
			if (audio.clip == ICJOJEKDMIF)
			{
				return audio;
			}
		}
		return null;
	}

	// Token: 0x0601031C RID: 66332 RVA: 0x0058C270 File Offset: 0x0058A470
	public Audio GetSoundAudio(int MLICEJKIGHO)
	{
		List<int> list = new List<int>(this.MECONPJBFIL.Keys);
		foreach (int num in list)
		{
			if (MLICEJKIGHO == num)
			{
				return this.MECONPJBFIL[num];
			}
		}
		return null;
	}

	// Token: 0x0601031D RID: 66333 RVA: 0x0058C2F0 File Offset: 0x0058A4F0
	public int PlaySound(AudioClip BKGCLBJFADE, bool AIPGGFGKNFE)
	{
		return this.PlaySound(BKGCLBJFADE, 1f, AIPGGFGKNFE, null, 0f, 14f);
	}

	// Token: 0x0601031E RID: 66334 RVA: 0x0058C136 File Offset: 0x0058A336
	public bool MBOJMCCNOJI()
	{
		return this.<EDKNFIIEBBC>k__BackingField;
	}

	// Token: 0x0601031F RID: 66335 RVA: 0x0058C30A File Offset: 0x0058A50A
	public int OIDCFNHNMCP(AudioClip BKGCLBJFADE)
	{
		return this.GOLFGIMABKJ(BKGCLBJFADE, 1006f, false, null, 362f, 1760f);
	}

	// Token: 0x06010320 RID: 66336 RVA: 0x0058C324 File Offset: 0x0058A524
	public float HECHOPCJIOD()
	{
		float result = 1946f;
		this.music_mixer.audioMixer.GetFloat("_Value", out result);
		return result;
	}

	// Token: 0x06010322 RID: 66338 RVA: 0x0058C350 File Offset: 0x0058A550
	public Audio GetMusicAudio(AudioClip ICJOJEKDMIF)
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int key in list)
		{
			Audio audio = this.DJBIELKMADE[key];
			if (audio.clip == ICJOJEKDMIF)
			{
				return audio;
			}
		}
		return null;
	}

	// Token: 0x06010323 RID: 66339 RVA: 0x0058B7BA File Offset: 0x005899BA
	public bool FEGIBCIJEKA()
	{
		return this.<BMMKEGKECGL>k__BackingField;
	}

	// Token: 0x06010324 RID: 66340 RVA: 0x0058C3DC File Offset: 0x0058A5DC
	public int KECNAIEBMOB(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float EONALHCPKCL, float LALICIHGPMB, float PINGENLHGGC, Transform OKDDLALOEME)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError("music", BKGCLBJFADE);
		}
		if (this.ignoreDuplicateMusic)
		{
			List<int> list = new List<int>(this.DJBIELKMADE.Keys);
			foreach (int key in list)
			{
				if (this.DJBIELKMADE[key].LCIMPPPDCPA().clip == BKGCLBJFADE)
				{
					return this.DJBIELKMADE[key].audioID;
				}
			}
		}
		this.StopAllMusic(PINGENLHGGC);
		Audio audio = new Audio(Audio.AudioType.Sound, BKGCLBJFADE, AIPGGFGKNFE, HHBOIFFNPPL, BDICHAELIJE, EONALHCPKCL, LALICIHGPMB, OKDDLALOEME);
		audio.audioSource.outputAudioMixerGroup = this.music_mixer;
		this.DJBIELKMADE.Add(audio.audioID, audio);
		return audio.audioID;
	}

	// Token: 0x06010325 RID: 66341 RVA: 0x0058C4E4 File Offset: 0x0058A6E4
	public void DDENFOCKIGA()
	{
		this.LJOOKPFDJGC();
		this.OGCBHACICMN();
	}

	// Token: 0x06010326 RID: 66342 RVA: 0x0058C4F2 File Offset: 0x0058A6F2
	public void KBLHGOIIKMI()
	{
		this.IDMFEEEIECD(401f);
	}

	// Token: 0x06010327 RID: 66343 RVA: 0x0058C4FF File Offset: 0x0058A6FF
	public int HKAPBCKDEEO(AudioClip BKGCLBJFADE)
	{
		return this.KGNMAJLMLBB(BKGCLBJFADE, 824f, true, null, 1644f, 1064f);
	}

	// Token: 0x06010328 RID: 66344 RVA: 0x0058C519 File Offset: 0x0058A719
	public void CIBJICEBJBA(float DPNHODJHGJL)
	{
		this.master_mixer.audioMixer.SetFloat("settings.selectormapsperpage", DPNHODJHGJL);
	}

	// Token: 0x06010329 RID: 66345 RVA: 0x0058C534 File Offset: 0x0058A734
	private void DAOPOFAHCCE(global::Scene INCNFKFDPPL, LoadSceneMode JBDCBMAICAN)
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int key in list)
		{
			Audio audio = this.DJBIELKMADE[key];
			if (!audio.persist && audio.activated)
			{
				UnityEngine.Object.Destroy(audio.LCIMPPPDCPA());
				this.DJBIELKMADE.Remove(key);
			}
		}
		list = new List<int>(this.MECONPJBFIL.Keys);
		foreach (int key2 in list)
		{
			Audio audio2 = this.MECONPJBFIL[key2];
			UnityEngine.Object.Destroy(audio2.audioSource);
			this.MECONPJBFIL.Remove(key2);
		}
	}

	// Token: 0x0601032A RID: 66346 RVA: 0x0058C64C File Offset: 0x0058A84C
	public void StopAll()
	{
		this.StopAll(-1f);
	}

	// Token: 0x0601032B RID: 66347 RVA: 0x0058C659 File Offset: 0x0058A859
	public new void Awake()
	{
		base.Awake();
		this.Init();
	}

	// Token: 0x0601032C RID: 66348 RVA: 0x0058C668 File Offset: 0x0058A868
	public Audio ELPDBNJHNHN(int MLICEJKIGHO)
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int num in list)
		{
			if (MLICEJKIGHO == num)
			{
				return this.DJBIELKMADE[num];
			}
		}
		return null;
	}

	// Token: 0x0601032D RID: 66349 RVA: 0x0058B1D2 File Offset: 0x005893D2
	public void LFIEDGFOEKJ(bool DPNHODJHGJL)
	{
		this.<EDKNFIIEBBC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0601032E RID: 66350 RVA: 0x0058BF20 File Offset: 0x0058A120
	public bool NKLOOOJHBKN()
	{
		return this.<NEACNFNFMJK>k__BackingField;
	}

	// Token: 0x0601032F RID: 66351 RVA: 0x0058C6E8 File Offset: 0x0058A8E8
	public void PGBLEMNPOIP()
	{
		List<int> list = new List<int>(this.MECONPJBFIL.Keys);
		foreach (int key in list)
		{
			Audio audio = this.MECONPJBFIL[key];
			audio.Stop();
		}
	}

	// Token: 0x06010330 RID: 66352 RVA: 0x0058C75C File Offset: 0x0058A95C
	public void PauseAllMusic()
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int key in list)
		{
			Audio audio = this.DJBIELKMADE[key];
			audio.Pause();
		}
	}

	// Token: 0x06010331 RID: 66353 RVA: 0x0058C7D0 File Offset: 0x0058A9D0
	public void OPNNBPGIDDJ()
	{
		this.IAJIGLGDGBO();
	}

	// Token: 0x06010332 RID: 66354 RVA: 0x0058C7D8 File Offset: 0x0058A9D8
	public static void PlayHitSfx(int JMMILEFMACB, float MEFEIEEHNDN)
	{
		AudioClip bkgclbjfade = null;
		if (JMMILEFMACB == 0)
		{
			bkgclbjfade = Singleton<SoundManager>.Instance.NHPJLPMBNNI;
		}
		if (JMMILEFMACB == 1)
		{
			bkgclbjfade = Singleton<SoundManager>.Instance.KNBEPPPLNGP;
		}
		if (JMMILEFMACB == 2)
		{
			bkgclbjfade = Singleton<SoundManager>.Instance.BFMNHKHHIEB;
		}
		if (JMMILEFMACB == 3)
		{
			bkgclbjfade = Singleton<SoundManager>.Instance.JOHPMPHJJLO;
		}
		Singleton<SoundManager>.Instance.PlaySingle(bkgclbjfade, MEFEIEEHNDN);
	}

	// Token: 0x06010334 RID: 66356 RVA: 0x0058C868 File Offset: 0x0058AA68
	public int CDHLJNMPHCO(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float EONALHCPKCL, float LALICIHGPMB, float PINGENLHGGC, Transform OKDDLALOEME)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError("menu.selectedplaymode", BKGCLBJFADE);
		}
		if (this.ignoreDuplicateMusic)
		{
			List<int> list = new List<int>(this.DJBIELKMADE.Keys);
			foreach (int key in list)
			{
				if (this.DJBIELKMADE[key].audioSource.clip == BKGCLBJFADE)
				{
					return this.DJBIELKMADE[key].audioID;
				}
			}
		}
		this.StopAllMusic(PINGENLHGGC);
		Audio audio = new Audio(Audio.AudioType.Music, BKGCLBJFADE, AIPGGFGKNFE, HHBOIFFNPPL, BDICHAELIJE, EONALHCPKCL, LALICIHGPMB, OKDDLALOEME);
		audio.LCIMPPPDCPA().outputAudioMixerGroup = this.music_mixer;
		this.DJBIELKMADE.Add(audio.audioID, audio);
		return audio.audioID;
	}

	// Token: 0x06010335 RID: 66357 RVA: 0x0058C970 File Offset: 0x0058AB70
	public int PlayMusic(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float EONALHCPKCL, float LALICIHGPMB, float PINGENLHGGC, Transform OKDDLALOEME)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError("[Sound Manager] Audio clip is null, cannot play music", BKGCLBJFADE);
		}
		if (this.ignoreDuplicateMusic)
		{
			List<int> list = new List<int>(this.DJBIELKMADE.Keys);
			foreach (int key in list)
			{
				if (this.DJBIELKMADE[key].audioSource.clip == BKGCLBJFADE)
				{
					return this.DJBIELKMADE[key].audioID;
				}
			}
		}
		this.StopAllMusic(PINGENLHGGC);
		Audio audio = new Audio(Audio.AudioType.Music, BKGCLBJFADE, AIPGGFGKNFE, HHBOIFFNPPL, BDICHAELIJE, EONALHCPKCL, LALICIHGPMB, OKDDLALOEME);
		audio.audioSource.outputAudioMixerGroup = this.music_mixer;
		this.DJBIELKMADE.Add(audio.audioID, audio);
		return audio.audioID;
	}

	// Token: 0x06010336 RID: 66358 RVA: 0x0058CA78 File Offset: 0x0058AC78
	public void ResumeAllMusic()
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int key in list)
		{
			Audio audio = this.DJBIELKMADE[key];
			audio.Resume();
		}
	}

	// Token: 0x06010337 RID: 66359 RVA: 0x0058CAEC File Offset: 0x0058ACEC
	public int HFCDOGPNMCE(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL)
	{
		return this.PlayMusic(BKGCLBJFADE, BDICHAELIJE, AIPGGFGKNFE, HHBOIFFNPPL, 347f, 1429f, 440f, null);
	}

	// Token: 0x06010338 RID: 66360 RVA: 0x0058CB14 File Offset: 0x0058AD14
	private void IDKNEKOCLLK(bool APDBPIMIEBI)
	{
		this.LFEFAKMMFKF = !APDBPIMIEBI;
	}

	// Token: 0x06010339 RID: 66361 RVA: 0x0058CB20 File Offset: 0x0058AD20
	public int LBEJIOICNDE(AudioClip BKGCLBJFADE, float BDICHAELIJE)
	{
		return this.EENFAOEODCK(BKGCLBJFADE, BDICHAELIJE, false, null, 431f, 930f);
	}

	// Token: 0x0601033A RID: 66362 RVA: 0x0058BF28 File Offset: 0x0058A128
	public void FDNKDOOEHBA()
	{
		this.StopAll();
	}

	// Token: 0x0601033B RID: 66363 RVA: 0x0058CB38 File Offset: 0x0058AD38
	public Audio NHKJKDFOAOF(int MLICEJKIGHO)
	{
		Audio audio = this.GetMusicAudio(MLICEJKIGHO);
		if (audio != null)
		{
			return audio;
		}
		audio = this.FEMGGDJOKFK(MLICEJKIGHO);
		if (audio != null)
		{
			return audio;
		}
		return null;
	}

	// Token: 0x0601033C RID: 66364 RVA: 0x0058CB68 File Offset: 0x0058AD68
	public void ECHLNKMPDJD(AudioClip BKGCLBJFADE, float MEFEIEEHNDN)
	{
		AudioSource audioSource = this.LFABIGKGJOG[this.IGKNDLKJBMO];
		audioSource.clip = BKGCLBJFADE;
		audioSource.pitch = MEFEIEEHNDN;
		audioSource.Play();
		this.IGKNDLKJBMO++;
		if (this.IGKNDLKJBMO >= this.LFABIGKGJOG.Count)
		{
			this.IGKNDLKJBMO = 1;
		}
	}

	// Token: 0x0601033D RID: 66365 RVA: 0x0058CBC8 File Offset: 0x0058ADC8
	public float HKAGHFLDAOJ()
	{
		float result = 1404f;
		this.music_mixer.audioMixer.GetFloat("Preparing content", out result);
		return result;
	}

	// Token: 0x0601033E RID: 66366 RVA: 0x0058CBF4 File Offset: 0x0058ADF4
	public int DPNPEKBEPKE(AudioClip BKGCLBJFADE)
	{
		return this.EENFAOEODCK(BKGCLBJFADE, 497f, false, null, 689f, 1524f);
	}

	// Token: 0x0601033F RID: 66367 RVA: 0x0058CC10 File Offset: 0x0058AE10
	public void JOKOOGJGCBC()
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int key in list)
		{
			Audio audio = this.DJBIELKMADE[key];
			audio.Pause();
		}
	}

	// Token: 0x06010340 RID: 66368 RVA: 0x0058CC84 File Offset: 0x0058AE84
	public Audio EEAOJCBKCFI(int MLICEJKIGHO)
	{
		Audio audio = this.ELPDBNJHNHN(MLICEJKIGHO);
		if (audio != null)
		{
			return audio;
		}
		audio = this.BKOMGMACINP(MLICEJKIGHO);
		if (audio != null)
		{
			return audio;
		}
		return null;
	}

	// Token: 0x06010341 RID: 66369 RVA: 0x0058CCB2 File Offset: 0x0058AEB2
	public void FADMCFCMLOO(float DPNHODJHGJL)
	{
		this.sfx_mixer.audioMixer.SetFloat("_TimeX", DPNHODJHGJL);
	}

	// Token: 0x06010342 RID: 66370 RVA: 0x0058CCCC File Offset: 0x0058AECC
	public Audio EPMCBNDCEEP(AudioClip ICJOJEKDMIF)
	{
		Audio audio = this.ILHFGLIBEKP(ICJOJEKDMIF);
		if (audio != null)
		{
			return audio;
		}
		audio = this.GetSoundAudio(ICJOJEKDMIF);
		if (audio != null)
		{
			return audio;
		}
		return null;
	}

	// Token: 0x06010343 RID: 66371 RVA: 0x0058CCFC File Offset: 0x0058AEFC
	public void MGDFHAIMEBO()
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int key in list)
		{
			Audio audio = this.DJBIELKMADE[key];
			audio.Resume();
		}
	}

	// Token: 0x06010344 RID: 66372 RVA: 0x0058CD70 File Offset: 0x0058AF70
	public void StopAllMusic(float LALICIHGPMB)
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int key in list)
		{
			Audio audio = this.DJBIELKMADE[key];
			if (LALICIHGPMB > 0f)
			{
				audio.fadeOutSeconds = LALICIHGPMB;
			}
			audio.Stop();
		}
	}

	// Token: 0x06010345 RID: 66373 RVA: 0x0058CDF8 File Offset: 0x0058AFF8
	public int PlayMusic(AudioClip BKGCLBJFADE, float BDICHAELIJE)
	{
		return this.PlayMusic(BKGCLBJFADE, BDICHAELIJE, true, false, 1f, 1f, -1f, null);
	}

	// Token: 0x06010346 RID: 66374 RVA: 0x0058CE1F File Offset: 0x0058B01F
	public void IAJIGLGDGBO()
	{
		this.StopAll(1906f);
	}

	// Token: 0x06010347 RID: 66375 RVA: 0x0058CE2C File Offset: 0x0058B02C
	public void NBOKAGMABPN()
	{
		this.FCPOMJINNJK();
	}

	// Token: 0x06010348 RID: 66376 RVA: 0x0058CE34 File Offset: 0x0058B034
	public int PlayMusic(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL)
	{
		return this.PlayMusic(BKGCLBJFADE, BDICHAELIJE, AIPGGFGKNFE, HHBOIFFNPPL, 1f, 1f, -1f, null);
	}

	// Token: 0x06010349 RID: 66377 RVA: 0x0058CE5C File Offset: 0x0058B05C
	public void IKKILFDKMKJ()
	{
		List<int> list = new List<int>(this.MECONPJBFIL.Keys);
		foreach (int key in list)
		{
			Audio audio = this.MECONPJBFIL[key];
			audio.Stop();
		}
	}

	// Token: 0x0601034A RID: 66378 RVA: 0x0058CED0 File Offset: 0x0058B0D0
	public int HLDCCELLJMP(AudioClip BKGCLBJFADE)
	{
		return this.CDHKNHGIHMO(BKGCLBJFADE, 1519f, true, false, 743f, 112f, 1438f, null);
	}

	// Token: 0x0601034B RID: 66379 RVA: 0x0058CB14 File Offset: 0x0058AD14
	private void OnApplicationFocus(bool APDBPIMIEBI)
	{
		this.LFEFAKMMFKF = !APDBPIMIEBI;
	}

	// Token: 0x0601034C RID: 66380 RVA: 0x0058CEFB File Offset: 0x0058B0FB
	public void EGCBBEGACFO(float DPNHODJHGJL)
	{
		this.sfx_mixer.audioMixer.SetFloat("No player left to ask", DPNHODJHGJL);
	}

	// Token: 0x0601034D RID: 66381 RVA: 0x0058CF14 File Offset: 0x0058B114
	public void EDMMKPKNALE(float DPNHODJHGJL)
	{
		this.master_mixer.audioMixer.SetFloat("checkpoint", DPNHODJHGJL);
	}

	// Token: 0x0601034E RID: 66382 RVA: 0x0058CF30 File Offset: 0x0058B130
	public float DCENOLKHCIN()
	{
		float result = 477f;
		this.music_mixer.audioMixer.GetFloat("Joystick1Button4", out result);
		return result;
	}

	// Token: 0x0601034F RID: 66383 RVA: 0x0058CF5C File Offset: 0x0058B15C
	public int PlaySound(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, Transform OKDDLALOEME, float PFJOHIMLHEP = 0f, float CNPIACHIHKD = 14f)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError("[Sound Manager] Audio clip is null, cannot play sound", BKGCLBJFADE);
		}
		if (this.ignoreDuplicateSounds)
		{
			List<int> list = new List<int>(this.MECONPJBFIL.Keys);
			foreach (int key in list)
			{
				if (this.MECONPJBFIL[key].audioSource.clip == BKGCLBJFADE)
				{
					return this.MECONPJBFIL[key].audioID;
				}
			}
		}
		Audio audio = new Audio(Audio.AudioType.Sound, BKGCLBJFADE, AIPGGFGKNFE, false, BDICHAELIJE, 0f, 0f, OKDDLALOEME);
		audio.audioSource.rolloffMode = AudioRolloffMode.Linear;
		audio.audioSource.minDistance = PFJOHIMLHEP;
		audio.audioSource.maxDistance = CNPIACHIHKD;
		audio.audioSource.transform.localPosition = new Vector3(0f, 0f, 0f);
		audio.audioSource.outputAudioMixerGroup = this.sfx_mixer;
		this.MECONPJBFIL.Add(audio.audioID, audio);
		return audio.audioID;
	}

	// Token: 0x06010350 RID: 66384 RVA: 0x0058D0AC File Offset: 0x0058B2AC
	public void KGCCAFFMIPE(float LALICIHGPMB)
	{
		this.IDMFEEEIECD(LALICIHGPMB);
		this.POOIONEDMIB();
	}

	// Token: 0x06010351 RID: 66385 RVA: 0x0058D0BC File Offset: 0x0058B2BC
	private IEnumerator IOIEFOBKFFH()
	{
		if (SoundManager.BFOCGKBEALM.LNIJKGECNME == null)
		{
			SoundManager.BFOCGKBEALM.LNIJKGECNME = new Func<bool>(SoundManager.BFOCGKBEALM.GBKBDKHPLKG);
		}
		yield return new WaitWhile(SoundManager.BFOCGKBEALM.LNIJKGECNME);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.hit_normal", "sounds/hit_normal", false));
		this.KNBEPPPLNGP = (AudioClip)ResourcesManager.GetLoadedResource("skin.hit_normal");
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.hit_perfect", "sounds/hit_perfect", false));
		this.NHPJLPMBNNI = (AudioClip)ResourcesManager.GetLoadedResource("skin.hit_perfect");
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.hit_wrong", "sounds/hit_wrong", false));
		this.BFMNHKHHIEB = (AudioClip)ResourcesManager.GetLoadedResource("skin.hit_wrong");
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.no_hit", "sounds/no_hit", false));
		this.JOHPMPHJJLO = (AudioClip)ResourcesManager.GetLoadedResource("skin.no_hit");
		Debug.Log("[SoundManager] Loaded skin audio");
		yield break;
	}

	// Token: 0x1700040F RID: 1039
	// (get) Token: 0x06010382 RID: 66434 RVA: 0x0058DBAC File Offset: 0x0058BDAC
	// (set) Token: 0x06010352 RID: 66386 RVA: 0x0058D0D7 File Offset: 0x0058B2D7
	public float sfxVolume
	{
		get
		{
			float result = 0f;
			this.sfx_mixer.audioMixer.GetFloat("sfxVolume", out result);
			return result;
		}
		set
		{
			this.sfx_mixer.audioMixer.SetFloat("sfxVolume", value);
		}
	}

	// Token: 0x06010353 RID: 66387 RVA: 0x0058D0F0 File Offset: 0x0058B2F0
	public void FFEDODOHCOH()
	{
		List<int> list = new List<int>(this.MECONPJBFIL.Keys);
		foreach (int key in list)
		{
			Audio audio = this.MECONPJBFIL[key];
			audio.Pause();
		}
	}

	// Token: 0x06010354 RID: 66388 RVA: 0x0058C136 File Offset: 0x0058A336
	public bool GFBNDFKMPDJ()
	{
		return this.<EDKNFIIEBBC>k__BackingField;
	}

	// Token: 0x06010355 RID: 66389 RVA: 0x0058D164 File Offset: 0x0058B364
	private IEnumerator AMJHEFCJCPP()
	{
		if (SoundManager.BFOCGKBEALM.LNIJKGECNME == null)
		{
			SoundManager.BFOCGKBEALM.LNIJKGECNME = new Func<bool>(SoundManager.BFOCGKBEALM.GBKBDKHPLKG);
		}
		yield return new WaitWhile(SoundManager.BFOCGKBEALM.LNIJKGECNME);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.hit_normal", "sounds/hit_normal", false));
		this.KNBEPPPLNGP = (AudioClip)ResourcesManager.GetLoadedResource("skin.hit_normal");
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.hit_perfect", "sounds/hit_perfect", false));
		this.NHPJLPMBNNI = (AudioClip)ResourcesManager.GetLoadedResource("skin.hit_perfect");
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.hit_wrong", "sounds/hit_wrong", false));
		this.BFMNHKHHIEB = (AudioClip)ResourcesManager.GetLoadedResource("skin.hit_wrong");
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.no_hit", "sounds/no_hit", false));
		this.JOHPMPHJJLO = (AudioClip)ResourcesManager.GetLoadedResource("skin.no_hit");
		Debug.Log("[SoundManager] Loaded skin audio");
		yield break;
	}

	// Token: 0x06010356 RID: 66390 RVA: 0x0058B1D2 File Offset: 0x005893D2
	public void CPACHKEJNKO(bool DPNHODJHGJL)
	{
		this.<EDKNFIIEBBC>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x06010357 RID: 66391 RVA: 0x0058D17F File Offset: 0x0058B37F
	public void KAFAFNKLFOH(float DPNHODJHGJL)
	{
		this.sfx_mixer.audioMixer.SetFloat("EXCEPTION:", DPNHODJHGJL);
	}

	// Token: 0x06010358 RID: 66392 RVA: 0x0058D198 File Offset: 0x0058B398
	private void IDNNMNMDKMI(global::Scene INCNFKFDPPL, LoadSceneMode JBDCBMAICAN)
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int key in list)
		{
			Audio audio = this.DJBIELKMADE[key];
			if (!audio.persist && audio.activated)
			{
				UnityEngine.Object.Destroy(audio.audioSource);
				this.DJBIELKMADE.Remove(key);
			}
		}
		list = new List<int>(this.MECONPJBFIL.Keys);
		foreach (int key2 in list)
		{
			Audio audio2 = this.MECONPJBFIL[key2];
			UnityEngine.Object.Destroy(audio2.audioSource);
			this.MECONPJBFIL.Remove(key2);
		}
	}

	// Token: 0x06010359 RID: 66393 RVA: 0x0058D2B0 File Offset: 0x0058B4B0
	public Audio EDJHENKKJFD(AudioClip ICJOJEKDMIF)
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int key in list)
		{
			Audio audio = this.DJBIELKMADE[key];
			if (audio.clip == ICJOJEKDMIF)
			{
				return audio;
			}
		}
		return null;
	}

	// Token: 0x0601035A RID: 66394 RVA: 0x0058D33C File Offset: 0x0058B53C
	public Audio GetAudio(AudioClip ICJOJEKDMIF)
	{
		Audio audio = this.GetMusicAudio(ICJOJEKDMIF);
		if (audio != null)
		{
			return audio;
		}
		audio = this.GetSoundAudio(ICJOJEKDMIF);
		if (audio != null)
		{
			return audio;
		}
		return null;
	}

	// Token: 0x0601035B RID: 66395 RVA: 0x0058CE2C File Offset: 0x0058B02C
	public void ABDHDGNIHHI()
	{
		this.FCPOMJINNJK();
	}

	// Token: 0x0601035C RID: 66396 RVA: 0x0058D36A File Offset: 0x0058B56A
	public int OOEDBOONAFO(AudioClip BKGCLBJFADE, float BDICHAELIJE)
	{
		return this.PlaySound(BKGCLBJFADE, BDICHAELIJE, false, null, 972f, 1711f);
	}

	// Token: 0x0601035D RID: 66397 RVA: 0x0058D380 File Offset: 0x0058B580
	public void FCPOMJINNJK()
	{
		this.GPNCMIPNCEF(90f);
	}

	// Token: 0x0601035E RID: 66398 RVA: 0x0058D38D File Offset: 0x0058B58D
	public void PADMLLEIKGJ(float DPNHODJHGJL)
	{
		this.sfx_mixer.audioMixer.SetFloat("[Sound Manager] Audio clip is null, cannot play sound", DPNHODJHGJL);
	}

	// Token: 0x0601035F RID: 66399 RVA: 0x0058CB14 File Offset: 0x0058AD14
	private void FFDPEAEPJOM(bool APDBPIMIEBI)
	{
		this.LFEFAKMMFKF = !APDBPIMIEBI;
	}

	// Token: 0x06010360 RID: 66400 RVA: 0x0058D3A6 File Offset: 0x0058B5A6
	public int PlaySound(AudioClip BKGCLBJFADE)
	{
		return this.PlaySound(BKGCLBJFADE, 1f, false, null, 0f, 14f);
	}

	// Token: 0x06010361 RID: 66401 RVA: 0x0058D3C0 File Offset: 0x0058B5C0
	public int OLAHGLBJMAL(AudioClip BKGCLBJFADE)
	{
		return this.GOLFGIMABKJ(BKGCLBJFADE, 305f, true, null, 1177f, 489f);
	}

	// Token: 0x06010362 RID: 66402 RVA: 0x0058D3DA File Offset: 0x0058B5DA
	public int PlaySound(AudioClip BKGCLBJFADE, float BDICHAELIJE)
	{
		return this.PlaySound(BKGCLBJFADE, BDICHAELIJE, false, null, 0f, 14f);
	}

	// Token: 0x06010363 RID: 66403 RVA: 0x0058D3F0 File Offset: 0x0058B5F0
	public void DFNPEJMJAIH(AudioClip BKGCLBJFADE, float MEFEIEEHNDN)
	{
		AudioSource audioSource = this.LFABIGKGJOG[this.IGKNDLKJBMO];
		audioSource.clip = BKGCLBJFADE;
		audioSource.pitch = MEFEIEEHNDN;
		audioSource.Play();
		this.IGKNDLKJBMO += 0;
		if (this.IGKNDLKJBMO >= this.LFABIGKGJOG.Count)
		{
			this.IGKNDLKJBMO = 1;
		}
	}

	// Token: 0x06010364 RID: 66404 RVA: 0x0058D450 File Offset: 0x0058B650
	public void LJOOKPFDJGC()
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int key in list)
		{
			Audio audio = this.DJBIELKMADE[key];
			audio.Resume();
		}
	}

	// Token: 0x06010365 RID: 66405 RVA: 0x0058D4C4 File Offset: 0x0058B6C4
	public Audio BKOMGMACINP(int MLICEJKIGHO)
	{
		List<int> list = new List<int>(this.MECONPJBFIL.Keys);
		foreach (int num in list)
		{
			if (MLICEJKIGHO == num)
			{
				return this.MECONPJBFIL[num];
			}
		}
		return null;
	}

	// Token: 0x06010366 RID: 66406 RVA: 0x0058D544 File Offset: 0x0058B744
	public void StopAllSounds()
	{
		List<int> list = new List<int>(this.MECONPJBFIL.Keys);
		foreach (int key in list)
		{
			Audio audio = this.MECONPJBFIL[key];
			audio.Stop();
		}
	}

	// Token: 0x06010367 RID: 66407 RVA: 0x0058D5B8 File Offset: 0x0058B7B8
	public Audio GetPlayingMusicAudio()
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int key in list)
		{
			Audio audio = this.DJBIELKMADE[key];
			if (audio.playing)
			{
				return audio;
			}
		}
		return null;
	}

	// Token: 0x06010368 RID: 66408 RVA: 0x0058D640 File Offset: 0x0058B840
	public static void FCNBLDODPKG(int JMMILEFMACB, float MEFEIEEHNDN)
	{
		AudioClip bkgclbjfade = null;
		if (JMMILEFMACB == 0)
		{
			bkgclbjfade = Singleton<SoundManager>.Instance.NHPJLPMBNNI;
		}
		if (JMMILEFMACB == 0)
		{
			bkgclbjfade = Singleton<SoundManager>.Instance.KNBEPPPLNGP;
		}
		if (JMMILEFMACB == 7)
		{
			bkgclbjfade = Singleton<SoundManager>.Instance.BFMNHKHHIEB;
		}
		if (JMMILEFMACB == 1)
		{
			bkgclbjfade = Singleton<SoundManager>.Instance.JOHPMPHJJLO;
		}
		Singleton<SoundManager>.Instance.JELKIKFDJPL(bkgclbjfade, MEFEIEEHNDN);
	}

	// Token: 0x06010369 RID: 66409 RVA: 0x0058D6A4 File Offset: 0x0058B8A4
	public Audio FEMGGDJOKFK(int MLICEJKIGHO)
	{
		List<int> list = new List<int>(this.MECONPJBFIL.Keys);
		foreach (int num in list)
		{
			if (MLICEJKIGHO == num)
			{
				return this.MECONPJBFIL[num];
			}
		}
		return null;
	}

	// Token: 0x0601036A RID: 66410 RVA: 0x0058D724 File Offset: 0x0058B924
	private void AMNADGKJIIP(bool IBNHNGJMBBA)
	{
		this.LFEFAKMMFKF = IBNHNGJMBBA;
	}

	// Token: 0x0601036B RID: 66411 RVA: 0x0058D730 File Offset: 0x0058B930
	public int IFEPJCMGGLH(AudioClip BKGCLBJFADE)
	{
		return this.PlayMusic(BKGCLBJFADE, 1632f, false, false, 95f, 223f, 1418f, null);
	}

	// Token: 0x0601036C RID: 66412 RVA: 0x0058B390 File Offset: 0x00589590
	public void EDFLHGMKPGC(bool DPNHODJHGJL)
	{
		this.<BMMKEGKECGL>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0601036D RID: 66413 RVA: 0x0058D75C File Offset: 0x0058B95C
	public void GPDCFHHLLNG(AudioClip BKGCLBJFADE, float MEFEIEEHNDN)
	{
		AudioSource audioSource = this.LFABIGKGJOG[this.IGKNDLKJBMO];
		audioSource.clip = BKGCLBJFADE;
		audioSource.pitch = MEFEIEEHNDN;
		audioSource.Play();
		this.IGKNDLKJBMO++;
		if (this.IGKNDLKJBMO >= this.LFABIGKGJOG.Count)
		{
			this.IGKNDLKJBMO = 0;
		}
	}

	// Token: 0x0601036E RID: 66414 RVA: 0x0058D7BA File Offset: 0x0058B9BA
	public void OAPJFLICLPI()
	{
		this.JOKOOGJGCBC();
		this.FFEDODOHCOH();
	}

	// Token: 0x0601036F RID: 66415 RVA: 0x0058D7C8 File Offset: 0x0058B9C8
	public int MKEHJGPKONL(AudioClip BKGCLBJFADE, float BDICHAELIJE)
	{
		return this.PlayMusic(BKGCLBJFADE, BDICHAELIJE, true, true, 1314f, 1886f, 337f, null);
	}

	// Token: 0x06010370 RID: 66416 RVA: 0x0058D7EF File Offset: 0x0058B9EF
	public void GPNCMIPNCEF(float LALICIHGPMB)
	{
		this.StopAllMusic(LALICIHGPMB);
		this.POOIONEDMIB();
	}

	// Token: 0x06010371 RID: 66417 RVA: 0x0058D7FE File Offset: 0x0058B9FE
	public void FHOCONCMBME()
	{
		this.IHCHGMAOEDP();
		this.FFEDODOHCOH();
	}

	// Token: 0x06010372 RID: 66418 RVA: 0x0058D80C File Offset: 0x0058BA0C
	public void PauseAllSounds()
	{
		List<int> list = new List<int>(this.MECONPJBFIL.Keys);
		foreach (int key in list)
		{
			Audio audio = this.MECONPJBFIL[key];
			audio.Pause();
		}
	}

	// Token: 0x06010373 RID: 66419 RVA: 0x0058D880 File Offset: 0x0058BA80
	public float CIMAPCBIEBO()
	{
		float result = 1058f;
		this.sfx_mixer.audioMixer.GetFloat("_Value", out result);
		return result;
	}

	// Token: 0x06010374 RID: 66420 RVA: 0x0058D8AC File Offset: 0x0058BAAC
	public Audio MPOOOFEBNFG(AudioClip ICJOJEKDMIF)
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int key in list)
		{
			Audio audio = this.DJBIELKMADE[key];
			if (audio.clip == ICJOJEKDMIF)
			{
				return audio;
			}
		}
		return null;
	}

	// Token: 0x06010375 RID: 66421 RVA: 0x0058D938 File Offset: 0x0058BB38
	public void Init()
	{
		this.LFABIGKGJOG.Clear();
		foreach (AudioSource obj in base.gameObject.GetComponents<AudioSource>())
		{
			UnityEngine.Object.Destroy(obj);
		}
		for (int j = 0; j < this.efxSourcesCount; j++)
		{
			AudioSource audioSource = base.gameObject.AddComponent<AudioSource>();
			audioSource.reverbZoneMix = 0f;
			audioSource.outputAudioMixerGroup = this.sfx_mixer;
			audioSource.playOnAwake = false;
			this.LFABIGKGJOG.Add(audioSource);
		}
		base.StartCoroutine(this.JFFPGKOIKON());
	}

	// Token: 0x06010376 RID: 66422 RVA: 0x0058D9DC File Offset: 0x0058BBDC
	public Audio KHONFICBJOF()
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int key in list)
		{
			Audio audio = this.DJBIELKMADE[key];
			if (audio.LBDDCEHHIPC())
			{
				return audio;
			}
		}
		return null;
	}

	// Token: 0x06010377 RID: 66423 RVA: 0x0058DA64 File Offset: 0x0058BC64
	public Audio GetAudio(int MLICEJKIGHO)
	{
		Audio audio = this.GetMusicAudio(MLICEJKIGHO);
		if (audio != null)
		{
			return audio;
		}
		audio = this.GetSoundAudio(MLICEJKIGHO);
		if (audio != null)
		{
			return audio;
		}
		return null;
	}

	// Token: 0x06010378 RID: 66424 RVA: 0x0058B268 File Offset: 0x00589468
	private void LBONINMGAGF(bool APDBPIMIEBI)
	{
		this.LFEFAKMMFKF = APDBPIMIEBI;
	}

	// Token: 0x0601037A RID: 66426 RVA: 0x0058DA92 File Offset: 0x0058BC92
	public void BPHMLGKCCGD(float DPNHODJHGJL)
	{
		this.music_mixer.audioMixer.SetFloat("_SubsampleIndices", DPNHODJHGJL);
	}

	// Token: 0x0601037B RID: 66427 RVA: 0x0058C136 File Offset: 0x0058A336
	public bool FEBGJECBJKF()
	{
		return this.<EDKNFIIEBBC>k__BackingField;
	}

	// Token: 0x0601037C RID: 66428 RVA: 0x0058C659 File Offset: 0x0058A859
	public void MBCDCBCLMCI()
	{
		base.Awake();
		this.Init();
	}

	// Token: 0x0601037D RID: 66429 RVA: 0x0058DAAB File Offset: 0x0058BCAB
	public int HEDPGJHLMNF(AudioClip BKGCLBJFADE, bool AIPGGFGKNFE)
	{
		return this.GOLFGIMABKJ(BKGCLBJFADE, 548f, AIPGGFGKNFE, null, 51f, 1280f);
	}

	// Token: 0x0601037E RID: 66430 RVA: 0x0058DAC8 File Offset: 0x0058BCC8
	public void LIHPKHMCIGE(AudioClip BKGCLBJFADE, float MEFEIEEHNDN)
	{
		AudioSource audioSource = this.LFABIGKGJOG[this.IGKNDLKJBMO];
		audioSource.clip = BKGCLBJFADE;
		audioSource.pitch = MEFEIEEHNDN;
		audioSource.Play();
		this.IGKNDLKJBMO += 0;
		if (this.IGKNDLKJBMO >= this.LFABIGKGJOG.Count)
		{
			this.IGKNDLKJBMO = 0;
		}
	}

	// Token: 0x0601037F RID: 66431 RVA: 0x0058DB28 File Offset: 0x0058BD28
	public void PlaySingle(AudioClip BKGCLBJFADE, float MEFEIEEHNDN)
	{
		AudioSource audioSource = this.LFABIGKGJOG[this.IGKNDLKJBMO];
		audioSource.clip = BKGCLBJFADE;
		audioSource.pitch = MEFEIEEHNDN;
		audioSource.Play();
		this.IGKNDLKJBMO++;
		if (this.IGKNDLKJBMO >= this.LFABIGKGJOG.Count)
		{
			this.IGKNDLKJBMO = 0;
		}
	}

	// Token: 0x06010380 RID: 66432 RVA: 0x0058D724 File Offset: 0x0058B924
	private void OnApplicationPause(bool IBNHNGJMBBA)
	{
		this.LFEFAKMMFKF = IBNHNGJMBBA;
	}

	// Token: 0x06010381 RID: 66433 RVA: 0x0058DB88 File Offset: 0x0058BD88
	public int PlayMusic(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float EONALHCPKCL, float LALICIHGPMB)
	{
		return this.PlayMusic(BKGCLBJFADE, BDICHAELIJE, AIPGGFGKNFE, HHBOIFFNPPL, EONALHCPKCL, LALICIHGPMB, -1f, null);
	}

	// Token: 0x06010383 RID: 66435 RVA: 0x0058DBD8 File Offset: 0x0058BDD8
	private void Update()
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int key in list)
		{
			Audio audio = this.DJBIELKMADE[key];
			audio.Update();
			if (!audio.playing && !audio.paused && !this.LFEFAKMMFKF)
			{
				UnityEngine.Object.Destroy(audio._audiosource.gameObject);
				this.DJBIELKMADE.Remove(key);
			}
		}
		list = new List<int>(this.MECONPJBFIL.Keys);
		foreach (int key2 in list)
		{
			Audio audio2 = this.MECONPJBFIL[key2];
			audio2.Update();
			if (!audio2.playing && !audio2.paused && !this.LFEFAKMMFKF)
			{
				UnityEngine.Object.Destroy(audio2._audiosource.gameObject);
				this.MECONPJBFIL.Remove(key2);
			}
		}
	}

	// Token: 0x06010384 RID: 66436 RVA: 0x0058DD34 File Offset: 0x0058BF34
	public int GFLKGIJGJHA(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, Transform OKDDLALOEME, float PFJOHIMLHEP = 0f, float CNPIACHIHKD = 14f)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError("NEW_ACHIEVEMENT_1_", BKGCLBJFADE);
		}
		if (this.GFBNDFKMPDJ())
		{
			List<int> list = new List<int>(this.MECONPJBFIL.Keys);
			foreach (int key in list)
			{
				if (this.MECONPJBFIL[key].audioSource.clip == BKGCLBJFADE)
				{
					return this.MECONPJBFIL[key].audioID;
				}
			}
		}
		Audio audio = new Audio(Audio.AudioType.Sound, BKGCLBJFADE, AIPGGFGKNFE, true, BDICHAELIJE, 1347f, 1780f, OKDDLALOEME);
		audio.LCIMPPPDCPA().rolloffMode = AudioRolloffMode.Logarithmic;
		audio.LCIMPPPDCPA().minDistance = PFJOHIMLHEP;
		audio.LCIMPPPDCPA().maxDistance = CNPIACHIHKD;
		audio.audioSource.transform.localPosition = new Vector3(864f, 411f, 311f);
		audio.LCIMPPPDCPA().outputAudioMixerGroup = this.sfx_mixer;
		this.MECONPJBFIL.Add(audio.audioID, audio);
		return audio.audioID;
	}

	// Token: 0x06010385 RID: 66437 RVA: 0x0058DE84 File Offset: 0x0058C084
	public void GEHIKFMPALA()
	{
		List<int> list = new List<int>(this.MECONPJBFIL.Keys);
		foreach (int key in list)
		{
			Audio audio = this.MECONPJBFIL[key];
			audio.Stop();
		}
	}

	// Token: 0x06010386 RID: 66438 RVA: 0x0058DEF8 File Offset: 0x0058C0F8
	public float GGKGIKOPGIN()
	{
		float result = 1332f;
		this.music_mixer.audioMixer.GetFloat("_MainTex2", out result);
		return result;
	}

	// Token: 0x06010387 RID: 66439 RVA: 0x0058DF24 File Offset: 0x0058C124
	public void NIOPHLJDFII()
	{
		List<int> list = new List<int>(this.MECONPJBFIL.Keys);
		foreach (int key in list)
		{
			Audio audio = this.MECONPJBFIL[key];
			audio.Resume();
		}
	}

	// Token: 0x06010388 RID: 66440 RVA: 0x0058DF98 File Offset: 0x0058C198
	private void OMCLOFCJMPG()
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int key in list)
		{
			Audio audio = this.DJBIELKMADE[key];
			audio.KMKLDAJLCNM();
			if (!audio.playing && !audio.paused && !this.LFEFAKMMFKF)
			{
				UnityEngine.Object.Destroy(audio._audiosource.gameObject);
				this.DJBIELKMADE.Remove(key);
			}
		}
		list = new List<int>(this.MECONPJBFIL.Keys);
		foreach (int key2 in list)
		{
			Audio audio2 = this.MECONPJBFIL[key2];
			audio2.KMKLDAJLCNM();
			if (!audio2.playing && !audio2.paused && !this.LFEFAKMMFKF)
			{
				UnityEngine.Object.Destroy(audio2._audiosource.gameObject);
				this.MECONPJBFIL.Remove(key2);
			}
		}
	}

	// Token: 0x06010389 RID: 66441 RVA: 0x0058E0F4 File Offset: 0x0058C2F4
	public void PauseAll()
	{
		this.PauseAllMusic();
		this.PauseAllSounds();
	}

	// Token: 0x0601038A RID: 66442 RVA: 0x0058E104 File Offset: 0x0058C304
	public Audio HDLDNBBFBNB(AudioClip ICJOJEKDMIF)
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int key in list)
		{
			Audio audio = this.DJBIELKMADE[key];
			if (audio.clip == ICJOJEKDMIF)
			{
				return audio;
			}
		}
		return null;
	}

	// Token: 0x0601038B RID: 66443 RVA: 0x0058E190 File Offset: 0x0058C390
	public int GOLFGIMABKJ(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, Transform OKDDLALOEME, float PFJOHIMLHEP = 0f, float CNPIACHIHKD = 14f)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError("CameraFilterPack/Drawing_NewCellShading", BKGCLBJFADE);
		}
		if (this.PAHLKOEKGLA())
		{
			List<int> list = new List<int>(this.MECONPJBFIL.Keys);
			foreach (int key in list)
			{
				if (this.MECONPJBFIL[key].LCIMPPPDCPA().clip == BKGCLBJFADE)
				{
					return this.MECONPJBFIL[key].audioID;
				}
			}
		}
		Audio audio = new Audio(Audio.AudioType.Sound, BKGCLBJFADE, AIPGGFGKNFE, false, BDICHAELIJE, 1342f, 746f, OKDDLALOEME);
		audio.audioSource.rolloffMode = AudioRolloffMode.Linear;
		audio.LCIMPPPDCPA().minDistance = PFJOHIMLHEP;
		audio.audioSource.maxDistance = CNPIACHIHKD;
		audio.audioSource.transform.localPosition = new Vector3(143f, 595f, 365f);
		audio.LCIMPPPDCPA().outputAudioMixerGroup = this.sfx_mixer;
		this.MECONPJBFIL.Add(audio.audioID, audio);
		return audio.audioID;
	}

	// Token: 0x0601038C RID: 66444 RVA: 0x0058E2E0 File Offset: 0x0058C4E0
	public int FOICOHLNLKN(AudioClip BKGCLBJFADE, float BDICHAELIJE)
	{
		return this.GOLFGIMABKJ(BKGCLBJFADE, BDICHAELIJE, true, null, 1396f, 1060f);
	}

	// Token: 0x0601038D RID: 66445 RVA: 0x0058E2F8 File Offset: 0x0058C4F8
	public void OGCBHACICMN()
	{
		List<int> list = new List<int>(this.MECONPJBFIL.Keys);
		foreach (int key in list)
		{
			Audio audio = this.MECONPJBFIL[key];
			audio.Resume();
		}
	}

	// Token: 0x0601038E RID: 66446 RVA: 0x0058E36C File Offset: 0x0058C56C
	public Audio HFKBOMEKKLA(int MLICEJKIGHO)
	{
		Audio audio = this.GHLPIPBEDLO(MLICEJKIGHO);
		if (audio != null)
		{
			return audio;
		}
		audio = this.GetSoundAudio(MLICEJKIGHO);
		if (audio != null)
		{
			return audio;
		}
		return null;
	}

	// Token: 0x0601038F RID: 66447 RVA: 0x0058E39C File Offset: 0x0058C59C
	public Audio OLJBMHOJOFP()
	{
		List<int> list = new List<int>(this.DJBIELKMADE.Keys);
		foreach (int key in list)
		{
			Audio audio = this.DJBIELKMADE[key];
			if (audio.LBDDCEHHIPC())
			{
				return audio;
			}
		}
		return null;
	}

	// Token: 0x06010390 RID: 66448 RVA: 0x0058D7EF File Offset: 0x0058B9EF
	public void KENEOBNJFGG(float LALICIHGPMB)
	{
		this.StopAllMusic(LALICIHGPMB);
		this.POOIONEDMIB();
	}

	// Token: 0x06010391 RID: 66449 RVA: 0x0058E424 File Offset: 0x0058C624
	public void StopAll(float LALICIHGPMB)
	{
		this.StopAllMusic(LALICIHGPMB);
		this.StopAllSounds();
	}

	// Token: 0x06010392 RID: 66450 RVA: 0x0058E434 File Offset: 0x0058C634
	public int CDHKNHGIHMO(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float EONALHCPKCL, float LALICIHGPMB, float PINGENLHGGC, Transform OKDDLALOEME)
	{
		if (BKGCLBJFADE == null)
		{
			Debug.LogError(".png", BKGCLBJFADE);
		}
		if (this.FLFDHECEEAL())
		{
			List<int> list = new List<int>(this.DJBIELKMADE.Keys);
			foreach (int key in list)
			{
				if (this.DJBIELKMADE[key].LCIMPPPDCPA().clip == BKGCLBJFADE)
				{
					return this.DJBIELKMADE[key].audioID;
				}
			}
		}
		this.StopAllMusic(PINGENLHGGC);
		Audio audio = new Audio(Audio.AudioType.Sound, BKGCLBJFADE, AIPGGFGKNFE, HHBOIFFNPPL, BDICHAELIJE, EONALHCPKCL, LALICIHGPMB, OKDDLALOEME);
		audio.LCIMPPPDCPA().outputAudioMixerGroup = this.music_mixer;
		this.DJBIELKMADE.Add(audio.audioID, audio);
		return audio.audioID;
	}

	// Token: 0x06010393 RID: 66451 RVA: 0x0058E53C File Offset: 0x0058C73C
	public int HPBKEPBFENK(AudioClip BKGCLBJFADE, float BDICHAELIJE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float EONALHCPKCL, float LALICIHGPMB)
	{
		return this.KECNAIEBMOB(BKGCLBJFADE, BDICHAELIJE, AIPGGFGKNFE, HHBOIFFNPPL, EONALHCPKCL, LALICIHGPMB, 1189f, null);
	}

	// Token: 0x06010394 RID: 66452 RVA: 0x0058E560 File Offset: 0x0058C760
	private IEnumerator JFFPGKOIKON()
	{
		if (SoundManager.BFOCGKBEALM.LNIJKGECNME == null)
		{
			SoundManager.BFOCGKBEALM.LNIJKGECNME = new Func<bool>(SoundManager.BFOCGKBEALM.GBKBDKHPLKG);
		}
		yield return new WaitWhile(SoundManager.BFOCGKBEALM.LNIJKGECNME);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.hit_normal", "sounds/hit_normal", false));
		this.KNBEPPPLNGP = (AudioClip)ResourcesManager.GetLoadedResource("skin.hit_normal");
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.hit_perfect", "sounds/hit_perfect", false));
		this.NHPJLPMBNNI = (AudioClip)ResourcesManager.GetLoadedResource("skin.hit_perfect");
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.hit_wrong", "sounds/hit_wrong", false));
		this.BFMNHKHHIEB = (AudioClip)ResourcesManager.GetLoadedResource("skin.hit_wrong");
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.no_hit", "sounds/no_hit", false));
		this.JOHPMPHJJLO = (AudioClip)ResourcesManager.GetLoadedResource("skin.no_hit");
		Debug.Log("[SoundManager] Loaded skin audio");
		yield break;
	}

	// Token: 0x06010395 RID: 66453 RVA: 0x0058BF20 File Offset: 0x0058A120
	public bool FLFDHECEEAL()
	{
		return this.<NEACNFNFMJK>k__BackingField;
	}

	// Token: 0x06010396 RID: 66454 RVA: 0x0058BF28 File Offset: 0x0058A128
	public void LOJJBIFHACA()
	{
		this.StopAll();
	}

	// Token: 0x06010397 RID: 66455 RVA: 0x0058E57B File Offset: 0x0058C77B
	public void ResumeAll()
	{
		this.ResumeAllMusic();
		this.ResumeAllSounds();
	}

	// Token: 0x06010398 RID: 66456 RVA: 0x0058B7BA File Offset: 0x005899BA
	public bool FFPBLPFLHGJ()
	{
		return this.<BMMKEGKECGL>k__BackingField;
	}

	// Token: 0x06010399 RID: 66457 RVA: 0x0058E58C File Offset: 0x0058C78C
	public Audio IMDDFGKNABH(AudioClip ICJOJEKDMIF)
	{
		Audio audio = this.MPOOOFEBNFG(ICJOJEKDMIF);
		if (audio != null)
		{
			return audio;
		}
		audio = this.GetSoundAudio(ICJOJEKDMIF);
		if (audio != null)
		{
			return audio;
		}
		return null;
	}

	// Token: 0x0601039A RID: 66458 RVA: 0x0058C136 File Offset: 0x0058A336
	public bool LJBINCCDKKH()
	{
		return this.<EDKNFIIEBBC>k__BackingField;
	}

	// Token: 0x0601039B RID: 66459 RVA: 0x0058E5BC File Offset: 0x0058C7BC
	private IEnumerator ELPBCKLNPGM()
	{
		if (SoundManager.BFOCGKBEALM.LNIJKGECNME == null)
		{
			SoundManager.BFOCGKBEALM.LNIJKGECNME = new Func<bool>(SoundManager.BFOCGKBEALM.GBKBDKHPLKG);
		}
		yield return new WaitWhile(SoundManager.BFOCGKBEALM.LNIJKGECNME);
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.hit_normal", "sounds/hit_normal", false));
		this.KNBEPPPLNGP = (AudioClip)ResourcesManager.GetLoadedResource("skin.hit_normal");
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.hit_perfect", "sounds/hit_perfect", false));
		this.NHPJLPMBNNI = (AudioClip)ResourcesManager.GetLoadedResource("skin.hit_perfect");
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.hit_wrong", "sounds/hit_wrong", false));
		this.BFMNHKHHIEB = (AudioClip)ResourcesManager.GetLoadedResource("skin.hit_wrong");
		yield return base.StartCoroutine(Singleton<ResourcesManager>.Instance.LoadSkinSound("skin.no_hit", "sounds/no_hit", false));
		this.JOHPMPHJJLO = (AudioClip)ResourcesManager.GetLoadedResource("skin.no_hit");
		Debug.Log("[SoundManager] Loaded skin audio");
		yield break;
	}

	// Token: 0x04001C7A RID: 7290
	public AudioMixerGroup master_mixer;

	// Token: 0x04001C7B RID: 7291
	public AudioMixerGroup sfx_mixer;

	// Token: 0x04001C7C RID: 7292
	public AudioMixerGroup music_mixer;

	// Token: 0x04001C7D RID: 7293
	public int efxSourcesCount = 10;

	// Token: 0x04001C7E RID: 7294
	private List<AudioSource> LFABIGKGJOG = new List<AudioSource>();

	// Token: 0x04001C7F RID: 7295
	private Dictionary<int, Audio> DJBIELKMADE = new Dictionary<int, Audio>();

	// Token: 0x04001C80 RID: 7296
	private Dictionary<int, Audio> MECONPJBFIL = new Dictionary<int, Audio>();

	// Token: 0x04001C81 RID: 7297
	private bool LFEFAKMMFKF;

	// Token: 0x04001C85 RID: 7301
	private AudioClip KNBEPPPLNGP;

	// Token: 0x04001C86 RID: 7302
	private AudioClip NHPJLPMBNNI;

	// Token: 0x04001C87 RID: 7303
	private AudioClip BFMNHKHHIEB;

	// Token: 0x04001C88 RID: 7304
	private AudioClip JOHPMPHJJLO;

	// Token: 0x04001C89 RID: 7305
	private int IGKNDLKJBMO;
}
