using System;
using AudioVisualizer;
using UnityEngine;

// Token: 0x02000404 RID: 1028
public class SatelliteController : EnvironmentController
{
	// Token: 0x0600EA9B RID: 60059 RVA: 0x004C7A6D File Offset: 0x004C5C6D
	public override void FGJOIELIIID(Vector3 JOPCODOJBHD)
	{
		this.targetPosition = JOPCODOJBHD;
	}

	// Token: 0x0600EA9C RID: 60060 RVA: 0x0052BF3C File Offset: 0x0052A13C
	public virtual void JADEDAEMLBN()
	{
		base.IJFMKNEPKEJ();
		this.color = new Color(1686f, 659f, 171f);
		this.colorLerp = 1702f;
		this.emission = 838f;
		this.radius = 551f;
		this.lerpSpeed = 527f;
		if (this.COPNGFGAEAG)
		{
			this.COPNGFGAEAG.sensitivity = 820f;
			this.COPNGFGAEAG.frequencyRange = FrequencyRange.High;
		}
		if (this.CNICPOPEDIO)
		{
			this.CNICPOPEDIO.time = 1677f;
			this.CNICPOPEDIO.widthMultiplier = 819f;
			this.CNICPOPEDIO.Clear();
		}
	}

	// Token: 0x0600EA9D RID: 60061 RVA: 0x0052BFFC File Offset: 0x0052A1FC
	public void JFNHELIJOFC(float DPNHODJHGJL)
	{
		this.CNICPOPEDIO.widthMultiplier = 1596f * DPNHODJHGJL;
	}

	// Token: 0x0600EA9E RID: 60062 RVA: 0x0052C010 File Offset: 0x0052A210
	public void CEHEGGINOCN(float DPNHODJHGJL)
	{
		this.COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	// Token: 0x0600EA9F RID: 60063 RVA: 0x0052C020 File Offset: 0x0052A220
	public virtual void MANOCIJICLG()
	{
		base.Reset();
		this.color = new Color(327f, 103f, 829f);
		this.colorLerp = 1094f;
		this.emission = 1231f;
		this.radius = 1338f;
		this.lerpSpeed = 1673f;
		if (this.COPNGFGAEAG)
		{
			this.COPNGFGAEAG.sensitivity = 1048f;
			this.COPNGFGAEAG.frequencyRange = FrequencyRange.UpperMidrange;
		}
		if (this.CNICPOPEDIO)
		{
			this.CNICPOPEDIO.time = 1344f;
			this.CNICPOPEDIO.widthMultiplier = 1605f;
			this.CNICPOPEDIO.Clear();
		}
	}

	// Token: 0x0600EAA0 RID: 60064 RVA: 0x0052C0E0 File Offset: 0x0052A2E0
	public void SetRadius(float DPNHODJHGJL)
	{
		this.radius = DPNHODJHGJL;
	}

	// Token: 0x0600EAA1 RID: 60065 RVA: 0x0052C0EC File Offset: 0x0052A2EC
	public override void Reset()
	{
		base.Reset();
		this.color = new Color(1f, 1f, 1f);
		this.colorLerp = 10f;
		this.emission = 1f;
		this.radius = 2f;
		this.lerpSpeed = 80f;
		if (this.COPNGFGAEAG)
		{
			this.COPNGFGAEAG.sensitivity = 5f;
			this.COPNGFGAEAG.frequencyRange = FrequencyRange.LowMidrange;
		}
		if (this.CNICPOPEDIO)
		{
			this.CNICPOPEDIO.time = 5f;
			this.CNICPOPEDIO.widthMultiplier = 0.04f;
			this.CNICPOPEDIO.Clear();
		}
	}

	// Token: 0x0600EAA2 RID: 60066 RVA: 0x004C7A6D File Offset: 0x004C5C6D
	public override void SetPosition(Vector3 JOPCODOJBHD)
	{
		this.targetPosition = JOPCODOJBHD;
	}

	// Token: 0x0600EAA3 RID: 60067 RVA: 0x0052C1AC File Offset: 0x0052A3AC
	public virtual void MMPOJCFOGJJ()
	{
		base.OPFDGBDADMA();
		this.COPNGFGAEAG = base.GetComponentInChildren<DynamicPosition>();
		this.HIIBHBOMGLD = base.GetComponent<global::Rotate>();
		this.CNICPOPEDIO = base.GetComponentInChildren<TrailRenderer>();
	}

	// Token: 0x0600EAA4 RID: 60068 RVA: 0x0052C1D8 File Offset: 0x0052A3D8
	public virtual void JIJPHEDDIHC()
	{
		base.OKADMJFLMGP();
		this.COPNGFGAEAG = base.GetComponentInChildren<DynamicPosition>();
		this.HIIBHBOMGLD = base.GetComponent<global::Rotate>();
		this.CNICPOPEDIO = base.GetComponentInChildren<TrailRenderer>();
	}

	// Token: 0x0600EAA5 RID: 60069 RVA: 0x0052C204 File Offset: 0x0052A404
	public virtual void FABMDEHEDNO()
	{
		base.NKLIHNJCHOG();
		if (this.scaleLerpSpeed > 902f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, this.targetScale, Time.deltaTime * this.scaleLerpSpeed);
		}
		this.CNICPOPEDIO.material.SetColor("UI/Particles/Hidden", Color.Lerp(this.CNICPOPEDIO.material.GetColor("Distortion"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.CNICPOPEDIO.material.SetColor("Texture2", Color.Lerp(this.CNICPOPEDIO.material.GetColor("skin.hit_wrong"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.CNICPOPEDIO.material.SetFloat(".completedMaps", Mathf.Lerp(this.CNICPOPEDIO.material.GetFloat("EventMenu"), this.emission * 1442f, Time.smoothDeltaTime * this.colorLerp));
		this.HIIBHBOMGLD.speed = Mathf.Lerp(this.HIIBHBOMGLD.speed, this.rotationSpeed, Time.smoothDeltaTime * this.lerpSpeed);
		this.COPNGFGAEAG.lerpSpeed = Mathf.Lerp(this.COPNGFGAEAG.lerpSpeed, this.lerpSpeed, Time.smoothDeltaTime * 1245f);
		this.COPNGFGAEAG.radius = Mathf.Lerp(this.COPNGFGAEAG.radius, this.radius, Time.smoothDeltaTime * this.lerpSpeed);
	}

	// Token: 0x0600EAA6 RID: 60070 RVA: 0x0052C3A3 File Offset: 0x0052A5A3
	public void SetTrailMinVertexDistance(float DPNHODJHGJL)
	{
		this.CNICPOPEDIO.minVertexDistance = DPNHODJHGJL;
	}

	// Token: 0x0600EAA7 RID: 60071 RVA: 0x0052C3B1 File Offset: 0x0052A5B1
	public void JNDABJJGALD(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600EAA8 RID: 60072 RVA: 0x0052C3BA File Offset: 0x0052A5BA
	public override Transform GetChild()
	{
		return this.CNICPOPEDIO.transform;
	}

	// Token: 0x0600EAA9 RID: 60073 RVA: 0x0052C3C7 File Offset: 0x0052A5C7
	public virtual void JBGJGBMAHIH(Vector3 LOMLCCLOIKN)
	{
		this.targetRotation = LOMLCCLOIKN;
		base.transform.localRotation = Quaternion.Euler(this.targetRotation);
	}

	// Token: 0x0600EAAA RID: 60074 RVA: 0x0052C3B1 File Offset: 0x0052A5B1
	public void CBFDAKKKCMK(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600EAAB RID: 60075 RVA: 0x0052C3E6 File Offset: 0x0052A5E6
	public void DJECHFFCIMO(float DPNHODJHGJL)
	{
		this.rotationSpeed = DPNHODJHGJL;
	}

	// Token: 0x0600EAAC RID: 60076 RVA: 0x0052C3EF File Offset: 0x0052A5EF
	public void PAJNAJFJCIJ(float DPNHODJHGJL)
	{
		this.CNICPOPEDIO.widthMultiplier = 1418f * DPNHODJHGJL;
	}

	// Token: 0x0600EAAD RID: 60077 RVA: 0x0052C3E6 File Offset: 0x0052A5E6
	public void LFLIMPAMFEE(float DPNHODJHGJL)
	{
		this.rotationSpeed = DPNHODJHGJL;
	}

	// Token: 0x0600EAAE RID: 60078 RVA: 0x0052C3C7 File Offset: 0x0052A5C7
	public virtual void DKBIMMLGOMP(Vector3 LOMLCCLOIKN)
	{
		this.targetRotation = LOMLCCLOIKN;
		base.transform.localRotation = Quaternion.Euler(this.targetRotation);
	}

	// Token: 0x0600EAAF RID: 60079 RVA: 0x0052C403 File Offset: 0x0052A603
	public void PNGMIFBBGAD(float DPNHODJHGJL)
	{
		this.CNICPOPEDIO.time = DPNHODJHGJL;
	}

	// Token: 0x0600EAB0 RID: 60080 RVA: 0x0052C3C7 File Offset: 0x0052A5C7
	public virtual void MBKFJALEGMG(Vector3 LOMLCCLOIKN)
	{
		this.targetRotation = LOMLCCLOIKN;
		base.transform.localRotation = Quaternion.Euler(this.targetRotation);
	}

	// Token: 0x0600EAB1 RID: 60081 RVA: 0x0052C414 File Offset: 0x0052A614
	public virtual void JNBPKNNBMDI()
	{
		base.Update();
		if (this.scaleLerpSpeed > 1280f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, this.targetScale, Time.deltaTime * this.scaleLerpSpeed);
		}
		this.CNICPOPEDIO.material.SetColor("_Near", Color.Lerp(this.CNICPOPEDIO.material.GetColor("Fade"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.CNICPOPEDIO.material.SetColor("_Extra2", Color.Lerp(this.CNICPOPEDIO.material.GetColor("Pop"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.CNICPOPEDIO.material.SetFloat("/Segment-[Right]", Mathf.Lerp(this.CNICPOPEDIO.material.GetFloat("_ScreenResolution"), this.emission * 607f, Time.smoothDeltaTime * this.colorLerp));
		this.HIIBHBOMGLD.speed = Mathf.Lerp(this.HIIBHBOMGLD.speed, this.rotationSpeed, Time.smoothDeltaTime * this.lerpSpeed);
		this.COPNGFGAEAG.lerpSpeed = Mathf.Lerp(this.COPNGFGAEAG.lerpSpeed, this.lerpSpeed, Time.smoothDeltaTime * 613f);
		this.COPNGFGAEAG.radius = Mathf.Lerp(this.COPNGFGAEAG.radius, this.radius, Time.smoothDeltaTime * this.lerpSpeed);
	}

	// Token: 0x0600EAB2 RID: 60082 RVA: 0x0052C5B3 File Offset: 0x0052A7B3
	public void SetInput(int JMMILEFMACB)
	{
		this.COPNGFGAEAG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	// Token: 0x0600EAB3 RID: 60083 RVA: 0x0052C010 File Offset: 0x0052A210
	public void MACHCCAOOGL(float DPNHODJHGJL)
	{
		this.COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	// Token: 0x0600EAB4 RID: 60084 RVA: 0x0052C3C7 File Offset: 0x0052A5C7
	public virtual void CCCBKEIEFEG(Vector3 LOMLCCLOIKN)
	{
		this.targetRotation = LOMLCCLOIKN;
		base.transform.localRotation = Quaternion.Euler(this.targetRotation);
	}

	// Token: 0x0600EAB5 RID: 60085 RVA: 0x004C7A6D File Offset: 0x004C5C6D
	public virtual void OGOPBNGJOCN(Vector3 JOPCODOJBHD)
	{
		this.targetPosition = JOPCODOJBHD;
	}

	// Token: 0x0600EAB6 RID: 60086 RVA: 0x0052C5B3 File Offset: 0x0052A7B3
	public void PDLJCCCNBKD(int JMMILEFMACB)
	{
		this.COPNGFGAEAG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	// Token: 0x0600EAB7 RID: 60087 RVA: 0x0052C5C1 File Offset: 0x0052A7C1
	public void NGANFKALCCB(float DPNHODJHGJL)
	{
		this.CNICPOPEDIO.widthMultiplier = 771f * DPNHODJHGJL;
	}

	// Token: 0x0600EAB8 RID: 60088 RVA: 0x0052C010 File Offset: 0x0052A210
	public void GMIIBCGBBGO(float DPNHODJHGJL)
	{
		this.COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	// Token: 0x0600EAB9 RID: 60089 RVA: 0x0052C3A3 File Offset: 0x0052A5A3
	public void FPBIBFEBEAC(float DPNHODJHGJL)
	{
		this.CNICPOPEDIO.minVertexDistance = DPNHODJHGJL;
	}

	// Token: 0x0600EABA RID: 60090 RVA: 0x0052C5D8 File Offset: 0x0052A7D8
	public override void Update()
	{
		base.Update();
		if (this.scaleLerpSpeed > 0f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, this.targetScale, Time.deltaTime * this.scaleLerpSpeed);
		}
		this.CNICPOPEDIO.material.SetColor("_DiffuseColor", Color.Lerp(this.CNICPOPEDIO.material.GetColor("_DiffuseColor"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.CNICPOPEDIO.material.SetColor("_EmissionColor", Color.Lerp(this.CNICPOPEDIO.material.GetColor("_EmissionColor"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.CNICPOPEDIO.material.SetFloat("_EmissionGain", Mathf.Lerp(this.CNICPOPEDIO.material.GetFloat("_EmissionGain"), this.emission * 0.2f, Time.smoothDeltaTime * this.colorLerp));
		this.HIIBHBOMGLD.speed = Mathf.Lerp(this.HIIBHBOMGLD.speed, this.rotationSpeed, Time.smoothDeltaTime * this.lerpSpeed);
		this.COPNGFGAEAG.lerpSpeed = Mathf.Lerp(this.COPNGFGAEAG.lerpSpeed, this.lerpSpeed, Time.smoothDeltaTime * 2f);
		this.COPNGFGAEAG.radius = Mathf.Lerp(this.COPNGFGAEAG.radius, this.radius, Time.smoothDeltaTime * this.lerpSpeed);
	}

	// Token: 0x0600EABB RID: 60091 RVA: 0x0052C5B3 File Offset: 0x0052A7B3
	public void MNANPMGEGCC(int JMMILEFMACB)
	{
		this.COPNGFGAEAG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	// Token: 0x0600EABC RID: 60092 RVA: 0x0052C778 File Offset: 0x0052A978
	public virtual void CGBHOELMAOC()
	{
		base.BGDONBMDPGM();
		if (this.scaleLerpSpeed > 1433f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, this.targetScale, Time.deltaTime * this.scaleLerpSpeed);
		}
		this.CNICPOPEDIO.material.SetColor("_Visualize", Color.Lerp(this.CNICPOPEDIO.material.GetColor(":\n"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.CNICPOPEDIO.material.SetColor("id", Color.Lerp(this.CNICPOPEDIO.material.GetColor("DISTORT"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.CNICPOPEDIO.material.SetFloat("player.violetarc", Mathf.Lerp(this.CNICPOPEDIO.material.GetFloat("D-Pad Left"), this.emission * 1695f, Time.smoothDeltaTime * this.colorLerp));
		this.HIIBHBOMGLD.speed = Mathf.Lerp(this.HIIBHBOMGLD.speed, this.rotationSpeed, Time.smoothDeltaTime * this.lerpSpeed);
		this.COPNGFGAEAG.lerpSpeed = Mathf.Lerp(this.COPNGFGAEAG.lerpSpeed, this.lerpSpeed, Time.smoothDeltaTime * 920f);
		this.COPNGFGAEAG.radius = Mathf.Lerp(this.COPNGFGAEAG.radius, this.radius, Time.smoothDeltaTime * this.lerpSpeed);
	}

	// Token: 0x0600EABD RID: 60093 RVA: 0x0052C917 File Offset: 0x0052AB17
	public void HOCOJMHOCPA(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600EABE RID: 60094 RVA: 0x0052C3B1 File Offset: 0x0052A5B1
	public void PGAHEICOAFL(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600EABF RID: 60095 RVA: 0x0052C928 File Offset: 0x0052AB28
	public virtual void HDDECCMEJKA()
	{
		base.NKLIHNJCHOG();
		if (this.scaleLerpSpeed > 513f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, this.targetScale, Time.deltaTime * this.scaleLerpSpeed);
		}
		this.CNICPOPEDIO.material.SetColor("_Value4", Color.Lerp(this.CNICPOPEDIO.material.GetColor("_ScreenResolution"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.CNICPOPEDIO.material.SetColor("Scrollbar", Color.Lerp(this.CNICPOPEDIO.material.GetColor("ViewMenu"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.CNICPOPEDIO.material.SetFloat("custom", Mathf.Lerp(this.CNICPOPEDIO.material.GetFloat("_ScreenResolution"), this.emission * 620f, Time.smoothDeltaTime * this.colorLerp));
		this.HIIBHBOMGLD.speed = Mathf.Lerp(this.HIIBHBOMGLD.speed, this.rotationSpeed, Time.smoothDeltaTime * this.lerpSpeed);
		this.COPNGFGAEAG.lerpSpeed = Mathf.Lerp(this.COPNGFGAEAG.lerpSpeed, this.lerpSpeed, Time.smoothDeltaTime * 676f);
		this.COPNGFGAEAG.radius = Mathf.Lerp(this.COPNGFGAEAG.radius, this.radius, Time.smoothDeltaTime * this.lerpSpeed);
	}

	// Token: 0x0600EAC0 RID: 60096 RVA: 0x0052CAC7 File Offset: 0x0052ACC7
	public void NEBJEDEPIND(float DPNHODJHGJL)
	{
		this.CNICPOPEDIO.widthMultiplier = 1605f * DPNHODJHGJL;
	}

	// Token: 0x0600EAC1 RID: 60097 RVA: 0x0052CADC File Offset: 0x0052ACDC
	public override void LOKKIADJAFE()
	{
		base.EEBGCGFNELO();
		this.color = new Color(1581f, 11f, 1161f);
		this.colorLerp = 1841f;
		this.emission = 1091f;
		this.radius = 992f;
		this.lerpSpeed = 1208f;
		if (this.COPNGFGAEAG)
		{
			this.COPNGFGAEAG.sensitivity = 1425f;
			this.COPNGFGAEAG.frequencyRange = FrequencyRange.VeryHigh;
		}
		if (this.CNICPOPEDIO)
		{
			this.CNICPOPEDIO.time = 135f;
			this.CNICPOPEDIO.widthMultiplier = 1156f;
			this.CNICPOPEDIO.Clear();
		}
	}

	// Token: 0x0600EAC2 RID: 60098 RVA: 0x0052C403 File Offset: 0x0052A603
	public void NJHKFNFKMGO(float DPNHODJHGJL)
	{
		this.CNICPOPEDIO.time = DPNHODJHGJL;
	}

	// Token: 0x0600EAC3 RID: 60099 RVA: 0x0052C0E0 File Offset: 0x0052A2E0
	public void MLCPINBPIBJ(float DPNHODJHGJL)
	{
		this.radius = DPNHODJHGJL;
	}

	// Token: 0x0600EAC4 RID: 60100 RVA: 0x0052C5B3 File Offset: 0x0052A7B3
	public void FJKEADHFDME(int JMMILEFMACB)
	{
		this.COPNGFGAEAG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	// Token: 0x0600EAC5 RID: 60101 RVA: 0x0052CB9C File Offset: 0x0052AD9C
	public virtual void FNMPIAMIKCP()
	{
		base.Awake();
		this.COPNGFGAEAG = base.GetComponentInChildren<DynamicPosition>();
		this.HIIBHBOMGLD = base.GetComponent<global::Rotate>();
		this.CNICPOPEDIO = base.GetComponentInChildren<TrailRenderer>();
	}

	// Token: 0x0600EAC6 RID: 60102 RVA: 0x0052CBC8 File Offset: 0x0052ADC8
	public void SetTrailWidth(float DPNHODJHGJL)
	{
		this.CNICPOPEDIO.widthMultiplier = 0.04f * DPNHODJHGJL;
	}

	// Token: 0x0600EAC7 RID: 60103 RVA: 0x0052C010 File Offset: 0x0052A210
	public void FKOAHEGNACN(float DPNHODJHGJL)
	{
		this.COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	// Token: 0x0600EAC8 RID: 60104 RVA: 0x0052C3B1 File Offset: 0x0052A5B1
	public void DNILEAJPDAP(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600EAC9 RID: 60105 RVA: 0x0052C010 File Offset: 0x0052A210
	public void INLBJOALCPD(float DPNHODJHGJL)
	{
		this.COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	// Token: 0x0600EACA RID: 60106 RVA: 0x0052CBDC File Offset: 0x0052ADDC
	public override void NLNAJMCBNDC()
	{
		base.FMAFBLKAJDF();
		this.COPNGFGAEAG = base.GetComponentInChildren<DynamicPosition>();
		this.HIIBHBOMGLD = base.GetComponent<global::Rotate>();
		this.CNICPOPEDIO = base.GetComponentInChildren<TrailRenderer>();
	}

	// Token: 0x0600EACC RID: 60108 RVA: 0x0052C1AC File Offset: 0x0052A3AC
	public virtual void LHMDCEDONEE()
	{
		base.OPFDGBDADMA();
		this.COPNGFGAEAG = base.GetComponentInChildren<DynamicPosition>();
		this.HIIBHBOMGLD = base.GetComponent<global::Rotate>();
		this.CNICPOPEDIO = base.GetComponentInChildren<TrailRenderer>();
	}

	// Token: 0x0600EACD RID: 60109 RVA: 0x0052C010 File Offset: 0x0052A210
	public void PIDMIGPIMMC(float DPNHODJHGJL)
	{
		this.COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	// Token: 0x0600EACE RID: 60110 RVA: 0x0052C3B1 File Offset: 0x0052A5B1
	public void FPENDOOEPJA(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600EACF RID: 60111 RVA: 0x0052CC6C File Offset: 0x0052AE6C
	public virtual void KMEONPMCNJG()
	{
		base.BMODOIJGIOO();
		if (this.scaleLerpSpeed > 1941f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, this.targetScale, Time.deltaTime * this.scaleLerpSpeed);
		}
		this.CNICPOPEDIO.material.SetColor("SetCrosshairColor", Color.Lerp(this.CNICPOPEDIO.material.GetColor("AvatarImage"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.CNICPOPEDIO.material.SetColor("_Value2", Color.Lerp(this.CNICPOPEDIO.material.GetColor("_TimeX"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.CNICPOPEDIO.material.SetFloat("Mouse2", Mathf.Lerp(this.CNICPOPEDIO.material.GetFloat("_ColorLevel"), this.emission * 1155f, Time.smoothDeltaTime * this.colorLerp));
		this.HIIBHBOMGLD.speed = Mathf.Lerp(this.HIIBHBOMGLD.speed, this.rotationSpeed, Time.smoothDeltaTime * this.lerpSpeed);
		this.COPNGFGAEAG.lerpSpeed = Mathf.Lerp(this.COPNGFGAEAG.lerpSpeed, this.lerpSpeed, Time.smoothDeltaTime * 409f);
		this.COPNGFGAEAG.radius = Mathf.Lerp(this.COPNGFGAEAG.radius, this.radius, Time.smoothDeltaTime * this.lerpSpeed);
	}

	// Token: 0x0600EAD0 RID: 60112 RVA: 0x0052C0E0 File Offset: 0x0052A2E0
	public void BFCFLLPGILC(float DPNHODJHGJL)
	{
		this.radius = DPNHODJHGJL;
	}

	// Token: 0x0600EAD1 RID: 60113 RVA: 0x0052C0E0 File Offset: 0x0052A2E0
	public void KIJOGDMIBLA(float DPNHODJHGJL)
	{
		this.radius = DPNHODJHGJL;
	}

	// Token: 0x0600EAD2 RID: 60114 RVA: 0x0052C3BA File Offset: 0x0052A5BA
	public virtual Transform NPLLOHAIPNG()
	{
		return this.CNICPOPEDIO.transform;
	}

	// Token: 0x0600EAD3 RID: 60115 RVA: 0x004C7A6D File Offset: 0x004C5C6D
	public virtual void EADICKIKIHC(Vector3 JOPCODOJBHD)
	{
		this.targetPosition = JOPCODOJBHD;
	}

	// Token: 0x0600EAD4 RID: 60116 RVA: 0x0052C3BA File Offset: 0x0052A5BA
	public virtual Transform NJBHJNIKFHN()
	{
		return this.CNICPOPEDIO.transform;
	}

	// Token: 0x0600EAD5 RID: 60117 RVA: 0x0052CE0B File Offset: 0x0052B00B
	public void AEOCAOGMOCO(float DPNHODJHGJL)
	{
		this.CNICPOPEDIO.widthMultiplier = 1624f * DPNHODJHGJL;
	}

	// Token: 0x0600EAD6 RID: 60118 RVA: 0x004C7A6D File Offset: 0x004C5C6D
	public virtual void PIAGGNABBOI(Vector3 JOPCODOJBHD)
	{
		this.targetPosition = JOPCODOJBHD;
	}

	// Token: 0x0600EAD7 RID: 60119 RVA: 0x0052C010 File Offset: 0x0052A210
	public void EBFLLKHDBJG(float DPNHODJHGJL)
	{
		this.COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	// Token: 0x0600EAD8 RID: 60120 RVA: 0x0052CE1F File Offset: 0x0052B01F
	public void JLCGLPLEDDP(float DPNHODJHGJL)
	{
		this.CNICPOPEDIO.widthMultiplier = 922f * DPNHODJHGJL;
	}

	// Token: 0x0600EAD9 RID: 60121 RVA: 0x0052C0E0 File Offset: 0x0052A2E0
	public void BALKFDMBGNC(float DPNHODJHGJL)
	{
		this.radius = DPNHODJHGJL;
	}

	// Token: 0x0600EADA RID: 60122 RVA: 0x0052C917 File Offset: 0x0052AB17
	public void OCJMPBPCKAE(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600EADB RID: 60123 RVA: 0x0052CE34 File Offset: 0x0052B034
	public virtual void EMKKGIEFKML()
	{
		base.GONKPNAAIEE();
		this.color = new Color(101f, 714f, 635f);
		this.colorLerp = 671f;
		this.emission = 276f;
		this.radius = 1824f;
		this.lerpSpeed = 270f;
		if (this.COPNGFGAEAG)
		{
			this.COPNGFGAEAG.sensitivity = 1993f;
			this.COPNGFGAEAG.frequencyRange = FrequencyRange.Decibal;
		}
		if (this.CNICPOPEDIO)
		{
			this.CNICPOPEDIO.time = 1037f;
			this.CNICPOPEDIO.widthMultiplier = 25f;
			this.CNICPOPEDIO.Clear();
		}
	}

	// Token: 0x0600EADC RID: 60124 RVA: 0x0052C3E6 File Offset: 0x0052A5E6
	public void GJIMKKMEPKC(float DPNHODJHGJL)
	{
		this.rotationSpeed = DPNHODJHGJL;
	}

	// Token: 0x0600EADD RID: 60125 RVA: 0x0052CEF4 File Offset: 0x0052B0F4
	public virtual void LBIOIEANMGI()
	{
		base.CFIAKIJAILI();
		if (this.scaleLerpSpeed > 337f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, this.targetScale, Time.deltaTime * this.scaleLerpSpeed);
		}
		this.CNICPOPEDIO.material.SetColor("FinalScoreText", Color.Lerp(this.CNICPOPEDIO.material.GetColor("_Factor"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.CNICPOPEDIO.material.SetColor("/C tasklist", Color.Lerp(this.CNICPOPEDIO.material.GetColor("ERROR: mod directory not found!"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.CNICPOPEDIO.material.SetFloat("PUNCloudBestRegion", Mathf.Lerp(this.CNICPOPEDIO.material.GetFloat("menu.selectedplaymode"), this.emission * 1019f, Time.smoothDeltaTime * this.colorLerp));
		this.HIIBHBOMGLD.speed = Mathf.Lerp(this.HIIBHBOMGLD.speed, this.rotationSpeed, Time.smoothDeltaTime * this.lerpSpeed);
		this.COPNGFGAEAG.lerpSpeed = Mathf.Lerp(this.COPNGFGAEAG.lerpSpeed, this.lerpSpeed, Time.smoothDeltaTime * 479f);
		this.COPNGFGAEAG.radius = Mathf.Lerp(this.COPNGFGAEAG.radius, this.radius, Time.smoothDeltaTime * this.lerpSpeed);
	}

	// Token: 0x0600EADE RID: 60126 RVA: 0x0052D093 File Offset: 0x0052B293
	public void SetLerpSpeed(float KEDDLFDAIDE)
	{
		this.lerpSpeed = KEDDLFDAIDE;
	}

	// Token: 0x0600EADF RID: 60127 RVA: 0x0052C3A3 File Offset: 0x0052A5A3
	public void BBIKIMGJLKL(float DPNHODJHGJL)
	{
		this.CNICPOPEDIO.minVertexDistance = DPNHODJHGJL;
	}

	// Token: 0x0600EAE0 RID: 60128 RVA: 0x0052C917 File Offset: 0x0052AB17
	public void CJNFBCCHNLG(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600EAE1 RID: 60129 RVA: 0x0052C403 File Offset: 0x0052A603
	public void GKLPDAJLEKL(float DPNHODJHGJL)
	{
		this.CNICPOPEDIO.time = DPNHODJHGJL;
	}

	// Token: 0x0600EAE2 RID: 60130 RVA: 0x0052C3BA File Offset: 0x0052A5BA
	public virtual Transform EPEKEBMFFFO()
	{
		return this.CNICPOPEDIO.transform;
	}

	// Token: 0x0600EAE3 RID: 60131 RVA: 0x0052C3E6 File Offset: 0x0052A5E6
	public void ENPLILCNPFB(float DPNHODJHGJL)
	{
		this.rotationSpeed = DPNHODJHGJL;
	}

	// Token: 0x0600EAE4 RID: 60132 RVA: 0x0052C3BA File Offset: 0x0052A5BA
	public virtual Transform FBMKCFIEMDH()
	{
		return this.CNICPOPEDIO.transform;
	}

	// Token: 0x0600EAE5 RID: 60133 RVA: 0x0052C403 File Offset: 0x0052A603
	public void SetTrailLength(float DPNHODJHGJL)
	{
		this.CNICPOPEDIO.time = DPNHODJHGJL;
	}

	// Token: 0x0600EAE6 RID: 60134 RVA: 0x0052C5B3 File Offset: 0x0052A7B3
	public void OJPJIBODOIJ(int JMMILEFMACB)
	{
		this.COPNGFGAEAG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	// Token: 0x0600EAE7 RID: 60135 RVA: 0x0052C917 File Offset: 0x0052AB17
	public void KNNJJLIOLFA(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600EAE8 RID: 60136 RVA: 0x0052D09C File Offset: 0x0052B29C
	public virtual void IDOFOCOFEIE()
	{
		base.LAACNNJDKBI();
		this.color = new Color(1891f, 1717f, 962f);
		this.colorLerp = 469f;
		this.emission = 982f;
		this.radius = 97f;
		this.lerpSpeed = 444f;
		if (this.COPNGFGAEAG)
		{
			this.COPNGFGAEAG.sensitivity = 1742f;
			this.COPNGFGAEAG.frequencyRange = FrequencyRange.UpperMidrange;
		}
		if (this.CNICPOPEDIO)
		{
			this.CNICPOPEDIO.time = 1212f;
			this.CNICPOPEDIO.widthMultiplier = 906f;
			this.CNICPOPEDIO.Clear();
		}
	}

	// Token: 0x0600EAE9 RID: 60137 RVA: 0x0052D15C File Offset: 0x0052B35C
	public virtual void HPNNCNNFMGK()
	{
		base.CFIAKIJAILI();
		if (this.scaleLerpSpeed > 514f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, this.targetScale, Time.deltaTime * this.scaleLerpSpeed);
		}
		this.CNICPOPEDIO.material.SetColor("_LightIntensity", Color.Lerp(this.CNICPOPEDIO.material.GetColor("_MainTex2"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.CNICPOPEDIO.material.SetColor("STICKRVER", Color.Lerp(this.CNICPOPEDIO.material.GetColor("Gameplay/sun"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.CNICPOPEDIO.material.SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", Mathf.Lerp(this.CNICPOPEDIO.material.GetFloat(".lastCheckpoint.incorrectScore"), this.emission * 108f, Time.smoothDeltaTime * this.colorLerp));
		this.HIIBHBOMGLD.speed = Mathf.Lerp(this.HIIBHBOMGLD.speed, this.rotationSpeed, Time.smoothDeltaTime * this.lerpSpeed);
		this.COPNGFGAEAG.lerpSpeed = Mathf.Lerp(this.COPNGFGAEAG.lerpSpeed, this.lerpSpeed, Time.smoothDeltaTime * 991f);
		this.COPNGFGAEAG.radius = Mathf.Lerp(this.COPNGFGAEAG.radius, this.radius, Time.smoothDeltaTime * this.lerpSpeed);
	}

	// Token: 0x0600EAEA RID: 60138 RVA: 0x0052C3B1 File Offset: 0x0052A5B1
	public void DBCGALPFIMJ(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600EAEB RID: 60139 RVA: 0x0052D2FC File Offset: 0x0052B4FC
	public virtual void PMLIOODCKDB()
	{
		base.EEBGCGFNELO();
		this.color = new Color(163f, 1795f, 373f);
		this.colorLerp = 1903f;
		this.emission = 303f;
		this.radius = 83f;
		this.lerpSpeed = 1682f;
		if (this.COPNGFGAEAG)
		{
			this.COPNGFGAEAG.sensitivity = 165f;
			this.COPNGFGAEAG.frequencyRange = FrequencyRange.LowMidrange;
		}
		if (this.CNICPOPEDIO)
		{
			this.CNICPOPEDIO.time = 1135f;
			this.CNICPOPEDIO.widthMultiplier = 867f;
			this.CNICPOPEDIO.Clear();
		}
	}

	// Token: 0x0600EAEC RID: 60140 RVA: 0x0052CB9C File Offset: 0x0052AD9C
	public override void Awake()
	{
		base.Awake();
		this.COPNGFGAEAG = base.GetComponentInChildren<DynamicPosition>();
		this.HIIBHBOMGLD = base.GetComponent<global::Rotate>();
		this.CNICPOPEDIO = base.GetComponentInChildren<TrailRenderer>();
	}

	// Token: 0x0600EAED RID: 60141 RVA: 0x0052C3B1 File Offset: 0x0052A5B1
	public void SetEmission(float DPNHODJHGJL)
	{
		this.emission = DPNHODJHGJL;
	}

	// Token: 0x0600EAEE RID: 60142 RVA: 0x0052D3BC File Offset: 0x0052B5BC
	public virtual void OPCLBGHAPMG()
	{
		base.BMODOIJGIOO();
		if (this.scaleLerpSpeed > 668f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, this.targetScale, Time.deltaTime * this.scaleLerpSpeed);
		}
		this.CNICPOPEDIO.material.SetColor("_Value", Color.Lerp(this.CNICPOPEDIO.material.GetColor("CameraFilterPack/3D_BlackHole"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.CNICPOPEDIO.material.SetColor("[MapData] Map timing update from: ", Color.Lerp(this.CNICPOPEDIO.material.GetColor("SUBMIT"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.CNICPOPEDIO.material.SetFloat("SelectionBox component must be placed on a canvas in Screen Space Overlay mode.", Mathf.Lerp(this.CNICPOPEDIO.material.GetFloat("_Value4"), this.emission * 828f, Time.smoothDeltaTime * this.colorLerp));
		this.HIIBHBOMGLD.speed = Mathf.Lerp(this.HIIBHBOMGLD.speed, this.rotationSpeed, Time.smoothDeltaTime * this.lerpSpeed);
		this.COPNGFGAEAG.lerpSpeed = Mathf.Lerp(this.COPNGFGAEAG.lerpSpeed, this.lerpSpeed, Time.smoothDeltaTime * 1781f);
		this.COPNGFGAEAG.radius = Mathf.Lerp(this.COPNGFGAEAG.radius, this.radius, Time.smoothDeltaTime * this.lerpSpeed);
	}

	// Token: 0x0600EAEF RID: 60143 RVA: 0x0052D55C File Offset: 0x0052B75C
	public virtual void FEAPMDENLBN()
	{
		base.IJFMKNEPKEJ();
		this.color = new Color(1325f, 1704f, 1263f);
		this.colorLerp = 1998f;
		this.emission = 1131f;
		this.radius = 1865f;
		this.lerpSpeed = 1302f;
		if (this.COPNGFGAEAG)
		{
			this.COPNGFGAEAG.sensitivity = 421f;
			this.COPNGFGAEAG.frequencyRange = FrequencyRange.UpperMidrange;
		}
		if (this.CNICPOPEDIO)
		{
			this.CNICPOPEDIO.time = 1083f;
			this.CNICPOPEDIO.widthMultiplier = 924f;
			this.CNICPOPEDIO.Clear();
		}
	}

	// Token: 0x0600EAF0 RID: 60144 RVA: 0x0052C3A3 File Offset: 0x0052A5A3
	public void JIFBDINHPMC(float DPNHODJHGJL)
	{
		this.CNICPOPEDIO.minVertexDistance = DPNHODJHGJL;
	}

	// Token: 0x0600EAF1 RID: 60145 RVA: 0x0052D093 File Offset: 0x0052B293
	public void OCLGBLNPNEM(float KEDDLFDAIDE)
	{
		this.lerpSpeed = KEDDLFDAIDE;
	}

	// Token: 0x0600EAF2 RID: 60146 RVA: 0x0052C3E6 File Offset: 0x0052A5E6
	public void GDACMIOIECK(float DPNHODJHGJL)
	{
		this.rotationSpeed = DPNHODJHGJL;
	}

	// Token: 0x0600EAF3 RID: 60147 RVA: 0x0052C3E6 File Offset: 0x0052A5E6
	public void NMDICPOHOLL(float DPNHODJHGJL)
	{
		this.rotationSpeed = DPNHODJHGJL;
	}

	// Token: 0x0600EAF4 RID: 60148 RVA: 0x0052D093 File Offset: 0x0052B293
	public void OEHOKHDDIFG(float KEDDLFDAIDE)
	{
		this.lerpSpeed = KEDDLFDAIDE;
	}

	// Token: 0x0600EAF5 RID: 60149 RVA: 0x0052D61C File Offset: 0x0052B81C
	public void CMMAIKAAGBL(float DPNHODJHGJL)
	{
		this.CNICPOPEDIO.widthMultiplier = 1351f * DPNHODJHGJL;
	}

	// Token: 0x0600EAF6 RID: 60150 RVA: 0x0052D093 File Offset: 0x0052B293
	public void JBJEOJNHNOP(float KEDDLFDAIDE)
	{
		this.lerpSpeed = KEDDLFDAIDE;
	}

	// Token: 0x0600EAF7 RID: 60151 RVA: 0x0052D630 File Offset: 0x0052B830
	public virtual void NCPAFCKGJEA()
	{
		base.EHCGBJDFMHG();
		if (this.scaleLerpSpeed > 616f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, this.targetScale, Time.deltaTime * this.scaleLerpSpeed);
		}
		this.CNICPOPEDIO.material.SetColor("GameMessagesDurationSlider", Color.Lerp(this.CNICPOPEDIO.material.GetColor("Drop_With_Obj"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.CNICPOPEDIO.material.SetColor("GameModeText", Color.Lerp(this.CNICPOPEDIO.material.GetColor("Saved as: "), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.CNICPOPEDIO.material.SetFloat("RanksButton", Mathf.Lerp(this.CNICPOPEDIO.material.GetFloat("Forward"), this.emission * 181f, Time.smoothDeltaTime * this.colorLerp));
		this.HIIBHBOMGLD.speed = Mathf.Lerp(this.HIIBHBOMGLD.speed, this.rotationSpeed, Time.smoothDeltaTime * this.lerpSpeed);
		this.COPNGFGAEAG.lerpSpeed = Mathf.Lerp(this.COPNGFGAEAG.lerpSpeed, this.lerpSpeed, Time.smoothDeltaTime * 1803f);
		this.COPNGFGAEAG.radius = Mathf.Lerp(this.COPNGFGAEAG.radius, this.radius, Time.smoothDeltaTime * this.lerpSpeed);
	}

	// Token: 0x0600EAF8 RID: 60152 RVA: 0x0052C3BA File Offset: 0x0052A5BA
	public virtual Transform PEGEGFEEOKA()
	{
		return this.CNICPOPEDIO.transform;
	}

	// Token: 0x0600EAF9 RID: 60153 RVA: 0x0052C010 File Offset: 0x0052A210
	public void MCBKOAKPLMD(float DPNHODJHGJL)
	{
		this.COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	// Token: 0x0600EAFA RID: 60154 RVA: 0x0052C0E0 File Offset: 0x0052A2E0
	public void LLMMOOLIGLE(float DPNHODJHGJL)
	{
		this.radius = DPNHODJHGJL;
	}

	// Token: 0x0600EAFB RID: 60155 RVA: 0x0052C403 File Offset: 0x0052A603
	public void BONCHKBJHHO(float DPNHODJHGJL)
	{
		this.CNICPOPEDIO.time = DPNHODJHGJL;
	}

	// Token: 0x0600EAFC RID: 60156 RVA: 0x0052C3BA File Offset: 0x0052A5BA
	public virtual Transform MFICHBNDAAG()
	{
		return this.CNICPOPEDIO.transform;
	}

	// Token: 0x0600EAFD RID: 60157 RVA: 0x0052C3C7 File Offset: 0x0052A5C7
	public override void SetRotation(Vector3 LOMLCCLOIKN)
	{
		this.targetRotation = LOMLCCLOIKN;
		base.transform.localRotation = Quaternion.Euler(this.targetRotation);
	}

	// Token: 0x0600EAFE RID: 60158 RVA: 0x0052D7CF File Offset: 0x0052B9CF
	public void DOMCIDMJKKI(float DPNHODJHGJL)
	{
		this.CNICPOPEDIO.widthMultiplier = 1013f * DPNHODJHGJL;
	}

	// Token: 0x0600EAFF RID: 60159 RVA: 0x0052C403 File Offset: 0x0052A603
	public void AOPAJFLOFPA(float DPNHODJHGJL)
	{
		this.CNICPOPEDIO.time = DPNHODJHGJL;
	}

	// Token: 0x0600EB00 RID: 60160 RVA: 0x0052D7E3 File Offset: 0x0052B9E3
	public virtual void JPJNECPABBG()
	{
		base.EMANBHKAONB();
		this.COPNGFGAEAG = base.GetComponentInChildren<DynamicPosition>();
		this.HIIBHBOMGLD = base.GetComponent<global::Rotate>();
		this.CNICPOPEDIO = base.GetComponentInChildren<TrailRenderer>();
	}

	// Token: 0x0600EB01 RID: 60161 RVA: 0x0052C3E6 File Offset: 0x0052A5E6
	public void AGAOJLOEFHM(float DPNHODJHGJL)
	{
		this.rotationSpeed = DPNHODJHGJL;
	}

	// Token: 0x0600EB02 RID: 60162 RVA: 0x004C7A6D File Offset: 0x004C5C6D
	public virtual void PGGPFJJHMKI(Vector3 JOPCODOJBHD)
	{
		this.targetPosition = JOPCODOJBHD;
	}

	// Token: 0x0600EB03 RID: 60163 RVA: 0x0052C3BA File Offset: 0x0052A5BA
	public override Transform PCOHOHLJMDG()
	{
		return this.CNICPOPEDIO.transform;
	}

	// Token: 0x0600EB04 RID: 60164 RVA: 0x0052C5B3 File Offset: 0x0052A7B3
	public void HICFJHJFFCJ(int JMMILEFMACB)
	{
		this.COPNGFGAEAG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	// Token: 0x0600EB05 RID: 60165 RVA: 0x0052C403 File Offset: 0x0052A603
	public void NNCBKHAHOOL(float DPNHODJHGJL)
	{
		this.CNICPOPEDIO.time = DPNHODJHGJL;
	}

	// Token: 0x0600EB06 RID: 60166 RVA: 0x0052C010 File Offset: 0x0052A210
	public void MKDMDCCDHEM(float DPNHODJHGJL)
	{
		this.COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	// Token: 0x0600EB07 RID: 60167 RVA: 0x0052C010 File Offset: 0x0052A210
	public void EMFECHLHOAL(float DPNHODJHGJL)
	{
		this.COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	// Token: 0x0600EB08 RID: 60168 RVA: 0x0052C3C7 File Offset: 0x0052A5C7
	public virtual void HACPNFLNJED(Vector3 LOMLCCLOIKN)
	{
		this.targetRotation = LOMLCCLOIKN;
		base.transform.localRotation = Quaternion.Euler(this.targetRotation);
	}

	// Token: 0x0600EB09 RID: 60169 RVA: 0x0052C3E6 File Offset: 0x0052A5E6
	public void SetRotationSpeed(float DPNHODJHGJL)
	{
		this.rotationSpeed = DPNHODJHGJL;
	}

	// Token: 0x0600EB0A RID: 60170 RVA: 0x0052D80F File Offset: 0x0052BA0F
	public virtual void JOBBGDGHJMB()
	{
		base.HHJBBHEBJCJ();
		this.COPNGFGAEAG = base.GetComponentInChildren<DynamicPosition>();
		this.HIIBHBOMGLD = base.GetComponent<global::Rotate>();
		this.CNICPOPEDIO = base.GetComponentInChildren<TrailRenderer>();
	}

	// Token: 0x0600EB0B RID: 60171 RVA: 0x0052C0E0 File Offset: 0x0052A2E0
	public void LHJMKCPOIGI(float DPNHODJHGJL)
	{
		this.radius = DPNHODJHGJL;
	}

	// Token: 0x0600EB0C RID: 60172 RVA: 0x0052C1D8 File Offset: 0x0052A3D8
	public virtual void NEEIFNDHDOG()
	{
		base.OKADMJFLMGP();
		this.COPNGFGAEAG = base.GetComponentInChildren<DynamicPosition>();
		this.HIIBHBOMGLD = base.GetComponent<global::Rotate>();
		this.CNICPOPEDIO = base.GetComponentInChildren<TrailRenderer>();
	}

	// Token: 0x0600EB0D RID: 60173 RVA: 0x0052D83C File Offset: 0x0052BA3C
	public virtual void MIFIEGOGKDA()
	{
		base.CEACMFGNDEB();
		this.color = new Color(838f, 537f, 1548f);
		this.colorLerp = 1445f;
		this.emission = 365f;
		this.radius = 1573f;
		this.lerpSpeed = 1345f;
		if (this.COPNGFGAEAG)
		{
			this.COPNGFGAEAG.sensitivity = 1601f;
			this.COPNGFGAEAG.frequencyRange = FrequencyRange.VeryHigh;
		}
		if (this.CNICPOPEDIO)
		{
			this.CNICPOPEDIO.time = 908f;
			this.CNICPOPEDIO.widthMultiplier = 687f;
			this.CNICPOPEDIO.Clear();
		}
	}

	// Token: 0x0600EB0E RID: 60174 RVA: 0x004C7A6D File Offset: 0x004C5C6D
	public virtual void KGENAICJFGF(Vector3 JOPCODOJBHD)
	{
		this.targetPosition = JOPCODOJBHD;
	}

	// Token: 0x0600EB0F RID: 60175 RVA: 0x0052C3BA File Offset: 0x0052A5BA
	public virtual Transform CLANIKJPMDP()
	{
		return this.CNICPOPEDIO.transform;
	}

	// Token: 0x0600EB10 RID: 60176 RVA: 0x0052C3E6 File Offset: 0x0052A5E6
	public void INOHPGBBOHI(float DPNHODJHGJL)
	{
		this.rotationSpeed = DPNHODJHGJL;
	}

	// Token: 0x0600EB11 RID: 60177 RVA: 0x0052C0E0 File Offset: 0x0052A2E0
	public void LMEIPIACDHL(float DPNHODJHGJL)
	{
		this.radius = DPNHODJHGJL;
	}

	// Token: 0x0600EB12 RID: 60178 RVA: 0x0052C917 File Offset: 0x0052AB17
	public void SetColor(Color HABLFKCCKLN, float MNHBOECHFEG)
	{
		this.color = HABLFKCCKLN;
		this.colorLerp = MNHBOECHFEG;
	}

	// Token: 0x0600EB13 RID: 60179 RVA: 0x0052CB9C File Offset: 0x0052AD9C
	public virtual void KEGNPKFMPDG()
	{
		base.Awake();
		this.COPNGFGAEAG = base.GetComponentInChildren<DynamicPosition>();
		this.HIIBHBOMGLD = base.GetComponent<global::Rotate>();
		this.CNICPOPEDIO = base.GetComponentInChildren<TrailRenderer>();
	}

	// Token: 0x0600EB14 RID: 60180 RVA: 0x0052D8FC File Offset: 0x0052BAFC
	public virtual void HIKKPDACJGI()
	{
		base.EHCGBJDFMHG();
		if (this.scaleLerpSpeed > 1998f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, this.targetScale, Time.deltaTime * this.scaleLerpSpeed);
		}
		this.CNICPOPEDIO.material.SetColor("[PlayerController] ", Color.Lerp(this.CNICPOPEDIO.material.GetColor("cancel"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.CNICPOPEDIO.material.SetColor("_ScreenResolution", Color.Lerp(this.CNICPOPEDIO.material.GetColor("Joystick1Button5"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.CNICPOPEDIO.material.SetFloat("_Blur", Mathf.Lerp(this.CNICPOPEDIO.material.GetFloat("_HexaColor"), this.emission * 1067f, Time.smoothDeltaTime * this.colorLerp));
		this.HIIBHBOMGLD.speed = Mathf.Lerp(this.HIIBHBOMGLD.speed, this.rotationSpeed, Time.smoothDeltaTime * this.lerpSpeed);
		this.COPNGFGAEAG.lerpSpeed = Mathf.Lerp(this.COPNGFGAEAG.lerpSpeed, this.lerpSpeed, Time.smoothDeltaTime * 1331f);
		this.COPNGFGAEAG.radius = Mathf.Lerp(this.COPNGFGAEAG.radius, this.radius, Time.smoothDeltaTime * this.lerpSpeed);
	}

	// Token: 0x0600EB15 RID: 60181 RVA: 0x0052C010 File Offset: 0x0052A210
	public void SetSensitivity(float DPNHODJHGJL)
	{
		this.COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	// Token: 0x0600EB16 RID: 60182 RVA: 0x0052D093 File Offset: 0x0052B293
	public void DCAHFDJOFBK(float KEDDLFDAIDE)
	{
		this.lerpSpeed = KEDDLFDAIDE;
	}

	// Token: 0x0600EB17 RID: 60183 RVA: 0x0052DA9C File Offset: 0x0052BC9C
	public virtual void IBHACCEEFFI()
	{
		base.Update();
		if (this.scaleLerpSpeed > 238f)
		{
			base.transform.localScale = Vector3.Lerp(base.transform.localScale, this.targetScale, Time.deltaTime * this.scaleLerpSpeed);
		}
		this.CNICPOPEDIO.material.SetColor("_Distortion", Color.Lerp(this.CNICPOPEDIO.material.GetColor("Can't connect: ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings"), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.CNICPOPEDIO.material.SetColor("player.greenarc", Color.Lerp(this.CNICPOPEDIO.material.GetColor("&map="), this.color, Time.smoothDeltaTime * this.colorLerp));
		this.CNICPOPEDIO.material.SetFloat(" not exist", Mathf.Lerp(this.CNICPOPEDIO.material.GetFloat(". We have no such PhotonView! Ignored this if you're leaving a room. State: "), this.emission * 1870f, Time.smoothDeltaTime * this.colorLerp));
		this.HIIBHBOMGLD.speed = Mathf.Lerp(this.HIIBHBOMGLD.speed, this.rotationSpeed, Time.smoothDeltaTime * this.lerpSpeed);
		this.COPNGFGAEAG.lerpSpeed = Mathf.Lerp(this.COPNGFGAEAG.lerpSpeed, this.lerpSpeed, Time.smoothDeltaTime * 1995f);
		this.COPNGFGAEAG.radius = Mathf.Lerp(this.COPNGFGAEAG.radius, this.radius, Time.smoothDeltaTime * this.lerpSpeed);
	}

	// Token: 0x0600EB18 RID: 60184 RVA: 0x0052C5B3 File Offset: 0x0052A7B3
	public void DGEBDJHAPCI(int JMMILEFMACB)
	{
		this.COPNGFGAEAG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	// Token: 0x0600EB19 RID: 60185 RVA: 0x0052C010 File Offset: 0x0052A210
	public void DIEMPKDKPCC(float DPNHODJHGJL)
	{
		this.COPNGFGAEAG.sensitivity = DPNHODJHGJL;
	}

	// Token: 0x0600EB1A RID: 60186 RVA: 0x0052C5B3 File Offset: 0x0052A7B3
	public void HGNOMPAEIEG(int JMMILEFMACB)
	{
		this.COPNGFGAEAG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	// Token: 0x0600EB1B RID: 60187 RVA: 0x0052DC3C File Offset: 0x0052BE3C
	public virtual void DGGPNPLKCOE()
	{
		base.GONKPNAAIEE();
		this.color = new Color(1349f, 923f, 872f);
		this.colorLerp = 1648f;
		this.emission = 1660f;
		this.radius = 1978f;
		this.lerpSpeed = 1314f;
		if (this.COPNGFGAEAG)
		{
			this.COPNGFGAEAG.sensitivity = 397f;
			this.COPNGFGAEAG.frequencyRange = FrequencyRange.UpperMidrange;
		}
		if (this.CNICPOPEDIO)
		{
			this.CNICPOPEDIO.time = 754f;
			this.CNICPOPEDIO.widthMultiplier = 1856f;
			this.CNICPOPEDIO.Clear();
		}
	}

	// Token: 0x0600EB1C RID: 60188 RVA: 0x0052C5B3 File Offset: 0x0052A7B3
	public void FCLOFNOFCPP(int JMMILEFMACB)
	{
		this.COPNGFGAEAG.frequencyRange = (FrequencyRange)JMMILEFMACB;
	}

	// Token: 0x0600EB1D RID: 60189 RVA: 0x0052C3C7 File Offset: 0x0052A5C7
	public virtual void NELGLIKDNLH(Vector3 LOMLCCLOIKN)
	{
		this.targetRotation = LOMLCCLOIKN;
		base.transform.localRotation = Quaternion.Euler(this.targetRotation);
	}

	// Token: 0x04001A68 RID: 6760
	public Color color = new Color(1f, 1f, 1f);

	// Token: 0x04001A69 RID: 6761
	public float colorLerp = 10f;

	// Token: 0x04001A6A RID: 6762
	public float emission = 1f;

	// Token: 0x04001A6B RID: 6763
	public float rotationSpeed = 40f;

	// Token: 0x04001A6C RID: 6764
	public float lerpSpeed = 2f;

	// Token: 0x04001A6D RID: 6765
	public Transform offsetObj;

	// Token: 0x04001A6E RID: 6766
	public float radius = 2f;

	// Token: 0x04001A6F RID: 6767
	private TrailRenderer CNICPOPEDIO;

	// Token: 0x04001A70 RID: 6768
	private DynamicPosition COPNGFGAEAG;

	// Token: 0x04001A71 RID: 6769
	private global::Rotate HIIBHBOMGLD;
}
