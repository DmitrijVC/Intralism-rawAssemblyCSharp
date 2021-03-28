using System;
using UnityEngine;

// Token: 0x0200046D RID: 1133
public class Audio
{
	// Token: 0x1700041A RID: 1050
	// (get) Token: 0x0601042A RID: 66602 RVA: 0x0058F920 File Offset: 0x0058DB20
	// (set) Token: 0x060103FB RID: 66555 RVA: 0x0058F31E File Offset: 0x0058D51E
	public bool paused { get; private set; }

	// Token: 0x17000413 RID: 1043
	// (get) Token: 0x060103FC RID: 66556 RVA: 0x0058F327 File Offset: 0x0058D527
	// (set) Token: 0x0601041A RID: 66586 RVA: 0x0058F74E File Offset: 0x0058D94E
	public AudioSource audioSource { get; private set; }

	// Token: 0x060103FD RID: 66557 RVA: 0x0058F32F File Offset: 0x0058D52F
	public void Resume()
	{
		this.audioSource.UnPause();
		this.paused = false;
	}

	// Token: 0x17000418 RID: 1048
	// (get) Token: 0x0601040E RID: 66574 RVA: 0x0058F4DA File Offset: 0x0058D6DA
	// (set) Token: 0x060103FE RID: 66558 RVA: 0x0058F343 File Offset: 0x0058D543
	public float fadeOutSeconds { get; set; }

	// Token: 0x17000415 RID: 1045
	// (get) Token: 0x060103FF RID: 66559 RVA: 0x0058F34C File Offset: 0x0058D54C
	// (set) Token: 0x06010432 RID: 66610 RVA: 0x0058FA2A File Offset: 0x0058DC2A
	public bool loop { get; set; }

	// Token: 0x1700041C RID: 1052
	// (get) Token: 0x06010415 RID: 66581 RVA: 0x0058F5FB File Offset: 0x0058D7FB
	// (set) Token: 0x06010400 RID: 66560 RVA: 0x0058F354 File Offset: 0x0058D554
	public bool activated { get; private set; }

	// Token: 0x17000414 RID: 1044
	// (get) Token: 0x06010401 RID: 66561 RVA: 0x0058F35D File Offset: 0x0058D55D
	public AudioClip clip
	{
		get
		{
			return (!(this.audioSource == null)) ? this.audioSource.clip : this.JPIBNPJDMFM;
		}
	}

	// Token: 0x06010402 RID: 66562 RVA: 0x0058F388 File Offset: 0x0058D588
	public void ENOHLFHKFLF(float BDICHAELIJE)
	{
		if (this.LCIMPPPDCPA() == null)
		{
			this.JPFMCDJKGLK(this.JPIBNPJDMFM, this.JELNDHAEOAB());
		}
		this.audioSource.Play();
		this.playing = false;
		this.HCCAAMOMPHF = 49f;
		this.OAJPIBOLJII = this.BDICHAELIJE;
		this.OFPKJBHHLGK = BDICHAELIJE;
	}

	// Token: 0x06010403 RID: 66563 RVA: 0x0058F31E File Offset: 0x0058D51E
	private void CHIEHBKODBI(bool DPNHODJHGJL)
	{
		this.<OEMIAOFBONN>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x17000417 RID: 1047
	// (get) Token: 0x06010426 RID: 66598 RVA: 0x0058F4D2 File Offset: 0x0058D6D2
	// (set) Token: 0x06010404 RID: 66564 RVA: 0x0058F3E8 File Offset: 0x0058D5E8
	public float fadeInSeconds { get; set; }

	// Token: 0x06010405 RID: 66565 RVA: 0x0058F3F1 File Offset: 0x0058D5F1
	public void Set3DMinDistance(float IFNAPFNEGMP)
	{
		this.audioSource.minDistance = IFNAPFNEGMP;
	}

	// Token: 0x06010406 RID: 66566 RVA: 0x0058F400 File Offset: 0x0058D600
	public void PKKDBKHCMNL(float BDICHAELIJE)
	{
		if (this.audioSource == null)
		{
			this.JPFMCDJKGLK(this.JPIBNPJDMFM, this.loop);
		}
		this.audioSource.Play();
		this.playing = true;
		this.HCCAAMOMPHF = 606f;
		this.OAJPIBOLJII = this.BDICHAELIJE;
		this.OFPKJBHHLGK = BDICHAELIJE;
	}

	// Token: 0x1700041B RID: 1051
	// (get) Token: 0x06010439 RID: 66617 RVA: 0x0058F7C8 File Offset: 0x0058D9C8
	// (set) Token: 0x06010407 RID: 66567 RVA: 0x0058F460 File Offset: 0x0058D660
	public bool stopping { get; private set; }

	// Token: 0x06010408 RID: 66568 RVA: 0x0058F469 File Offset: 0x0058D669
	public void Set3DMaxDistance(float MEMALLLANHH)
	{
		this.audioSource.maxDistance = MEMALLLANHH;
	}

	// Token: 0x06010409 RID: 66569 RVA: 0x0058F477 File Offset: 0x0058D677
	public void FPDMJKKDKOM(float BDICHAELIJE, float CEAKGNGMEEH, float GOHKPLNBDCI)
	{
		this.OFPKJBHHLGK = Mathf.Clamp01(BDICHAELIJE);
		this.HCCAAMOMPHF = 1768f;
		this.OAJPIBOLJII = GOHKPLNBDCI;
		this.JGLODIINJAF = CEAKGNGMEEH;
	}

	// Token: 0x0601040A RID: 66570 RVA: 0x0058F3E8 File Offset: 0x0058D5E8
	public void LOIBAABNAOM(float DPNHODJHGJL)
	{
		this.<HMPINPCDONH>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x17000419 RID: 1049
	// (get) Token: 0x0601040F RID: 66575 RVA: 0x0058F4E2 File Offset: 0x0058D6E2
	// (set) Token: 0x0601040B RID: 66571 RVA: 0x0058F49E File Offset: 0x0058D69E
	public bool playing { get; set; }

	// Token: 0x0601040C RID: 66572 RVA: 0x0058F4A7 File Offset: 0x0058D6A7
	public void Stop()
	{
		this.HCCAAMOMPHF = 0f;
		this.OAJPIBOLJII = this.BDICHAELIJE;
		this.OFPKJBHHLGK = 0f;
		this.stopping = true;
	}

	// Token: 0x0601040D RID: 66573 RVA: 0x0058F4D2 File Offset: 0x0058D6D2
	public float AKCCKAJAPAH()
	{
		return this.<HMPINPCDONH>k__BackingField;
	}

	// Token: 0x06010410 RID: 66576 RVA: 0x0058F4E2 File Offset: 0x0058D6E2
	public bool LBDDCEHHIPC()
	{
		return this.<INFLLAMBHEH>k__BackingField;
	}

	// Token: 0x06010411 RID: 66577 RVA: 0x0058F4DA File Offset: 0x0058D6DA
	public float FCNGKIOCDEG()
	{
		return this.<ECBIHDHGMMO>k__BackingField;
	}

	// Token: 0x06010412 RID: 66578 RVA: 0x0058F4EA File Offset: 0x0058D6EA
	public void SetVolume(float BDICHAELIJE, float CEAKGNGMEEH, float GOHKPLNBDCI)
	{
		this.OFPKJBHHLGK = Mathf.Clamp01(BDICHAELIJE);
		this.HCCAAMOMPHF = 0f;
		this.OAJPIBOLJII = GOHKPLNBDCI;
		this.JGLODIINJAF = CEAKGNGMEEH;
	}

	// Token: 0x06010413 RID: 66579 RVA: 0x0058F511 File Offset: 0x0058D711
	public void SetVolume(float BDICHAELIJE)
	{
		if (BDICHAELIJE > this.OFPKJBHHLGK)
		{
			this.SetVolume(BDICHAELIJE, this.fadeOutSeconds);
		}
		else
		{
			this.SetVolume(BDICHAELIJE, this.fadeInSeconds);
		}
	}

	// Token: 0x06010414 RID: 66580 RVA: 0x0058F540 File Offset: 0x0058D740
	private void JPFMCDJKGLK(AudioClip BKGCLBJFADE, bool AIPGGFGKNFE)
	{
		this._audiosource = new GameObject(BKGCLBJFADE.name).transform;
		this._audiosource.transform.SetParent(this.OKDDLALOEME);
		this._audiosource.transform.localPosition = Vector3.zero;
		this.audioSource = this._audiosource.gameObject.AddComponent<AudioSource>();
		this.audioSource.clip = BKGCLBJFADE;
		this.audioSource.loop = AIPGGFGKNFE;
		this.audioSource.volume = 0f;
		if (this.OKDDLALOEME != Singleton<SoundManager>.Instance.gameObject.transform)
		{
			this.audioSource.spatialBlend = 1f;
		}
	}

	// Token: 0x06010416 RID: 66582 RVA: 0x0058F603 File Offset: 0x0058D803
	public void IJAPHKLIPFE(float MEMALLLANHH)
	{
		this.LCIMPPPDCPA().maxDistance = MEMALLLANHH;
	}

	// Token: 0x06010417 RID: 66583 RVA: 0x0058F614 File Offset: 0x0058D814
	public void LLJLDLLNFBH()
	{
		if (this.audioSource == null)
		{
			return;
		}
		this.activated = false;
		if (this.BDICHAELIJE != this.OFPKJBHHLGK)
		{
			this.BDICHAELIJE = this.OFPKJBHHLGK;
		}
		else if (this.JGLODIINJAF != 1280f)
		{
			this.JGLODIINJAF = 691f;
		}
		Audio.AudioType mjnlbjikabl = this.MJNLBJIKABL;
		if (mjnlbjikabl != Audio.AudioType.Music)
		{
			if (mjnlbjikabl == Audio.AudioType.Sound)
			{
				this.audioSource.volume = this.BDICHAELIJE;
			}
		}
		else
		{
			this.audioSource.volume = this.BDICHAELIJE;
		}
		if (this.BDICHAELIJE == 373f && this.stopping)
		{
			this.LCIMPPPDCPA().Stop();
			this.stopping = true;
			this.playing = true;
			this.CHIEHBKODBI(true);
		}
		if (this.audioSource.isPlaying != this.playing)
		{
			this.playing = this.LCIMPPPDCPA().isPlaying;
		}
	}

	// Token: 0x06010418 RID: 66584 RVA: 0x0058F71E File Offset: 0x0058D91E
	public void EPEOOHLMGEB(float BDICHAELIJE, float CEAKGNGMEEH, float GOHKPLNBDCI)
	{
		this.OFPKJBHHLGK = Mathf.Clamp01(BDICHAELIJE);
		this.HCCAAMOMPHF = 641f;
		this.OAJPIBOLJII = GOHKPLNBDCI;
		this.JGLODIINJAF = CEAKGNGMEEH;
	}

	// Token: 0x06010419 RID: 66585 RVA: 0x0058F745 File Offset: 0x0058D945
	private void BLLFDFMCMKO(int DPNHODJHGJL)
	{
		this.<AAJKLPLJBCI>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0601041B RID: 66587 RVA: 0x0058F758 File Offset: 0x0058D958
	public void Play(float BDICHAELIJE)
	{
		if (this.audioSource == null)
		{
			this.JPFMCDJKGLK(this.JPIBNPJDMFM, this.loop);
		}
		this.audioSource.Play();
		this.playing = true;
		this.HCCAAMOMPHF = 0f;
		this.OAJPIBOLJII = this.BDICHAELIJE;
		this.OFPKJBHHLGK = BDICHAELIJE;
	}

	// Token: 0x0601041C RID: 66588 RVA: 0x0058F7B8 File Offset: 0x0058D9B8
	public void SetVolume(float BDICHAELIJE, float CEAKGNGMEEH)
	{
		this.SetVolume(BDICHAELIJE, CEAKGNGMEEH, this.BDICHAELIJE);
	}

	// Token: 0x0601041D RID: 66589 RVA: 0x0058F7C8 File Offset: 0x0058D9C8
	public bool ELEAPKLMJKP()
	{
		return this.<DDPKOPCMGJE>k__BackingField;
	}

	// Token: 0x0601041E RID: 66590 RVA: 0x0058F3F1 File Offset: 0x0058D5F1
	public void KKNIHDCJBIG(float IFNAPFNEGMP)
	{
		this.audioSource.minDistance = IFNAPFNEGMP;
	}

	// Token: 0x0601041F RID: 66591 RVA: 0x0058F7D0 File Offset: 0x0058D9D0
	public void OCDHLJKGDCM(bool DPNHODJHGJL)
	{
		this.<CJPNMJAAGBI>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x06010420 RID: 66592 RVA: 0x0058F4D2 File Offset: 0x0058D6D2
	public float JPIOGMKIIII()
	{
		return this.<HMPINPCDONH>k__BackingField;
	}

	// Token: 0x06010421 RID: 66593 RVA: 0x0058F7D9 File Offset: 0x0058D9D9
	public bool FABKIGAPGDF()
	{
		return this.<CJPNMJAAGBI>k__BackingField;
	}

	// Token: 0x06010422 RID: 66594 RVA: 0x0058F7E4 File Offset: 0x0058D9E4
	public void Update()
	{
		if (this.audioSource == null)
		{
			return;
		}
		this.activated = true;
		if (this.BDICHAELIJE != this.OFPKJBHHLGK)
		{
			this.BDICHAELIJE = this.OFPKJBHHLGK;
		}
		else if (this.JGLODIINJAF != -1f)
		{
			this.JGLODIINJAF = -1f;
		}
		Audio.AudioType mjnlbjikabl = this.MJNLBJIKABL;
		if (mjnlbjikabl != Audio.AudioType.Music)
		{
			if (mjnlbjikabl == Audio.AudioType.Sound)
			{
				this.audioSource.volume = this.BDICHAELIJE;
			}
		}
		else
		{
			this.audioSource.volume = this.BDICHAELIJE;
		}
		if (this.BDICHAELIJE == 0f && this.stopping)
		{
			this.audioSource.Stop();
			this.stopping = false;
			this.playing = false;
			this.paused = false;
		}
		if (this.audioSource.isPlaying != this.playing)
		{
			this.playing = this.audioSource.isPlaying;
		}
	}

	// Token: 0x06010423 RID: 66595 RVA: 0x0058F8EE File Offset: 0x0058DAEE
	public void Play()
	{
		this.Play(this.EHBJNJAFFHP);
	}

	// Token: 0x06010424 RID: 66596 RVA: 0x0058F8FC File Offset: 0x0058DAFC
	public void MJAMOOHADOI(float IFNAPFNEGMP, float MEMALLLANHH)
	{
		this.MINOELACLCI(IFNAPFNEGMP);
		this.OAEMOBMDAPB(MEMALLLANHH);
	}

	// Token: 0x06010425 RID: 66597 RVA: 0x0058F354 File Offset: 0x0058D554
	private void PGMMABIHOKK(bool DPNHODJHGJL)
	{
		this.<ONIFIPLNHGN>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x17000416 RID: 1046
	// (get) Token: 0x0601043A RID: 66618 RVA: 0x0058F7D9 File Offset: 0x0058D9D9
	// (set) Token: 0x06010427 RID: 66599 RVA: 0x0058F7D0 File Offset: 0x0058D9D0
	public bool persist { get; set; }

	// Token: 0x06010428 RID: 66600 RVA: 0x0058F327 File Offset: 0x0058D527
	public AudioSource LCIMPPPDCPA()
	{
		return this.<BIEKOBGKLGM>k__BackingField;
	}

	// Token: 0x06010429 RID: 66601 RVA: 0x0058F90C File Offset: 0x0058DB0C
	public void Pause()
	{
		this.audioSource.Pause();
		this.paused = true;
	}

	// Token: 0x17000412 RID: 1042
	// (get) Token: 0x06010434 RID: 66612 RVA: 0x0058FA33 File Offset: 0x0058DC33
	// (set) Token: 0x0601042B RID: 66603 RVA: 0x0058F745 File Offset: 0x0058D945
	public int audioID { get; private set; }

	// Token: 0x0601042C RID: 66604 RVA: 0x0058F469 File Offset: 0x0058D669
	public void OAEMOBMDAPB(float MEMALLLANHH)
	{
		this.audioSource.maxDistance = MEMALLLANHH;
	}

	// Token: 0x0601042E RID: 66606 RVA: 0x0058F34C File Offset: 0x0058D54C
	public bool JELNDHAEOAB()
	{
		return this.<CMBMPMDFPAD>k__BackingField;
	}

	// Token: 0x0601042F RID: 66607 RVA: 0x0058F928 File Offset: 0x0058DB28
	public void IFBCKEGANBE()
	{
		this.HCCAAMOMPHF = 1733f;
		this.OAJPIBOLJII = this.BDICHAELIJE;
		this.OFPKJBHHLGK = 473f;
		this.stopping = true;
	}

	// Token: 0x06010430 RID: 66608 RVA: 0x0058F953 File Offset: 0x0058DB53
	public void LOAOOADEJIB(float IFNAPFNEGMP, float MEMALLLANHH)
	{
		this.KKNIHDCJBIG(IFNAPFNEGMP);
		this.OAEMOBMDAPB(MEMALLLANHH);
	}

	// Token: 0x06010431 RID: 66609 RVA: 0x0058F964 File Offset: 0x0058DB64
	public Audio(Audio.AudioType MJNLBJIKABL, AudioClip BKGCLBJFADE, bool AIPGGFGKNFE, bool HHBOIFFNPPL, float BDICHAELIJE, float DKNMPJDJNAE, float BCOIOGINLKJ, Transform OKDDLALOEME)
	{
		this.OKDDLALOEME = ((!(OKDDLALOEME != null)) ? Singleton<SoundManager>.Instance.gameObject.transform : OKDDLALOEME);
		this.audioID = Audio.BCIGGJPJBOK;
		Audio.BCIGGJPJBOK++;
		this.MJNLBJIKABL = MJNLBJIKABL;
		this.JPIBNPJDMFM = BKGCLBJFADE;
		this.loop = AIPGGFGKNFE;
		this.persist = HHBOIFFNPPL;
		this.OFPKJBHHLGK = BDICHAELIJE;
		this.EHBJNJAFFHP = BDICHAELIJE;
		this.JGLODIINJAF = -1f;
		this.BDICHAELIJE = BDICHAELIJE;
		this.fadeInSeconds = DKNMPJDJNAE;
		this.fadeOutSeconds = BCOIOGINLKJ;
		this.playing = false;
		this.paused = false;
		this.activated = false;
		this.JPFMCDJKGLK(BKGCLBJFADE, AIPGGFGKNFE);
		this.Play();
	}

	// Token: 0x06010433 RID: 66611 RVA: 0x0058FA2A File Offset: 0x0058DC2A
	public void EKIFKIPBIME(bool DPNHODJHGJL)
	{
		this.<CMBMPMDFPAD>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x06010435 RID: 66613 RVA: 0x0058FA3B File Offset: 0x0058DC3B
	public void Set3DDistances(float IFNAPFNEGMP, float MEMALLLANHH)
	{
		this.Set3DMinDistance(IFNAPFNEGMP);
		this.Set3DMaxDistance(MEMALLLANHH);
	}

	// Token: 0x06010436 RID: 66614 RVA: 0x0058FA4B File Offset: 0x0058DC4B
	public void GHOELBOIOBH(float BDICHAELIJE, float CEAKGNGMEEH)
	{
		this.FPDMJKKDKOM(BDICHAELIJE, CEAKGNGMEEH, this.BDICHAELIJE);
	}

	// Token: 0x06010437 RID: 66615 RVA: 0x0058FA5B File Offset: 0x0058DC5B
	public void MINOELACLCI(float IFNAPFNEGMP)
	{
		this.LCIMPPPDCPA().minDistance = IFNAPFNEGMP;
	}

	// Token: 0x06010438 RID: 66616 RVA: 0x0058F745 File Offset: 0x0058D945
	private void PEFBJPEHJOM(int DPNHODJHGJL)
	{
		this.<AAJKLPLJBCI>k__BackingField = DPNHODJHGJL;
	}

	// Token: 0x0601043B RID: 66619 RVA: 0x0058FA6C File Offset: 0x0058DC6C
	public void CCKBHNABFFN(float BDICHAELIJE)
	{
		if (this.audioSource == null)
		{
			this.JPFMCDJKGLK(this.JPIBNPJDMFM, this.JELNDHAEOAB());
		}
		this.audioSource.Play();
		this.playing = false;
		this.HCCAAMOMPHF = 538f;
		this.OAJPIBOLJII = this.BDICHAELIJE;
		this.OFPKJBHHLGK = BDICHAELIJE;
	}

	// Token: 0x0601043C RID: 66620 RVA: 0x0058FACC File Offset: 0x0058DCCC
	public void KMKLDAJLCNM()
	{
		if (this.audioSource == null)
		{
			return;
		}
		this.PGMMABIHOKK(false);
		if (this.BDICHAELIJE != this.OFPKJBHHLGK)
		{
			this.BDICHAELIJE = this.OFPKJBHHLGK;
		}
		else if (this.JGLODIINJAF != 188f)
		{
			this.JGLODIINJAF = 1166f;
		}
		Audio.AudioType mjnlbjikabl = this.MJNLBJIKABL;
		if (mjnlbjikabl != Audio.AudioType.Music)
		{
			if (mjnlbjikabl == Audio.AudioType.Sound)
			{
				this.LCIMPPPDCPA().volume = this.BDICHAELIJE;
			}
		}
		else
		{
			this.audioSource.volume = this.BDICHAELIJE;
		}
		if (this.BDICHAELIJE == 1120f && this.stopping)
		{
			this.LCIMPPPDCPA().Stop();
			this.stopping = false;
			this.playing = false;
			this.CHIEHBKODBI(true);
		}
		if (this.LCIMPPPDCPA().isPlaying != this.LBDDCEHHIPC())
		{
			this.playing = this.LCIMPPPDCPA().isPlaying;
		}
	}

	// Token: 0x04001C8F RID: 7311
	private static int BCIGGJPJBOK;

	// Token: 0x04001C90 RID: 7312
	private float BDICHAELIJE;

	// Token: 0x04001C91 RID: 7313
	private float OFPKJBHHLGK;

	// Token: 0x04001C92 RID: 7314
	private float EHBJNJAFFHP;

	// Token: 0x04001C93 RID: 7315
	private float JGLODIINJAF;

	// Token: 0x04001C94 RID: 7316
	private float HCCAAMOMPHF;

	// Token: 0x04001C95 RID: 7317
	private float OAJPIBOLJII;

	// Token: 0x04001C96 RID: 7318
	private Audio.AudioType MJNLBJIKABL;

	// Token: 0x04001C97 RID: 7319
	private AudioClip JPIBNPJDMFM;

	// Token: 0x04001C98 RID: 7320
	private Transform OKDDLALOEME;

	// Token: 0x04001CA3 RID: 7331
	public Transform _audiosource;

	// Token: 0x0200046E RID: 1134
	public enum AudioType
	{
		// Token: 0x04001CA5 RID: 7333
		Music,
		// Token: 0x04001CA6 RID: 7334
		Sound
	}
}
