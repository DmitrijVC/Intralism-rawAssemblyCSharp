using System;
using UITween;
using UnityEngine;
using UnityEngine.Events;

// Token: 0x02000233 RID: 563
[Serializable]
public class EasyTween : MonoBehaviour
{
	// Token: 0x060088B7 RID: 34999 RVA: 0x00300BFF File Offset: 0x002FEDFF
	public void GIMKLENAIIO(Vector3 OPDFCFOCGPC, Vector3 KCLMKFKHMGC, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		this.currentAnimationGoing.MFKLABJCGMG(OPDFCFOCGPC, KCLMKFKHMGC, CANHEAPDBPD, PMOODBJDOEL);
	}

	// Token: 0x060088B8 RID: 35000 RVA: 0x00300C1B File Offset: 0x002FEE1B
	public void SetFadeStartEndValues(float NGHFGPKHIPP, float HHABIDFFNCK)
	{
		this.currentAnimationGoing.SetFadeValuesStartEnd(NGHFGPKHIPP, HHABIDFFNCK);
	}

	// Token: 0x060088B9 RID: 35001 RVA: 0x00300C2A File Offset: 0x002FEE2A
	public void SetAnimatioDuration(float HNIFGMOMJMA)
	{
		if (HNIFGMOMJMA > 0f)
		{
			this.currentAnimationGoing.SetAniamtioDuration(HNIFGMOMJMA);
		}
		else
		{
			this.currentAnimationGoing.SetAniamtioDuration(0.01f);
		}
	}

	// Token: 0x060088BA RID: 35002 RVA: 0x00300C58 File Offset: 0x002FEE58
	public void MHDEFCKEGEO()
	{
		this.rectTransform.gameObject.SetActive(true);
		this.currentAnimationGoing.PlayCloseAnimations();
	}

	// Token: 0x060088BB RID: 35003 RVA: 0x00300C76 File Offset: 0x002FEE76
	private void IJHDFCAIPOP()
	{
		this.currentAnimationGoing.ECMBKPFMPEG(this.rectTransform);
	}

	// Token: 0x060088BC RID: 35004 RVA: 0x00300C89 File Offset: 0x002FEE89
	public void PMGDBILDKGK(float HNIFGMOMJMA)
	{
		if (HNIFGMOMJMA > 459f)
		{
			this.currentAnimationGoing.SetAniamtioDuration(HNIFGMOMJMA);
		}
		else
		{
			this.currentAnimationGoing.SetAniamtioDuration(1364f);
		}
	}

	// Token: 0x060088BD RID: 35005 RVA: 0x00300CB7 File Offset: 0x002FEEB7
	private void AEIJFLJEABG()
	{
		this.currentAnimationGoing.BFKJPGNMEJM(this.rectTransform);
	}

	// Token: 0x060088BE RID: 35006 RVA: 0x00300CCA File Offset: 0x002FEECA
	public void ADJMKGJKIHC(bool CIOKILFKPHF)
	{
		this.currentAnimationGoing.IEPOJAMAJAK(CIOKILFKPHF);
	}

	// Token: 0x060088BF RID: 35007 RVA: 0x00300CD8 File Offset: 0x002FEED8
	public void SetAnimationProperties(AnimationParts KEMAFNIOEFC)
	{
		this.animationParts = KEMAFNIOEFC;
		this.currentAnimationGoing = new CurrentAnimation(KEMAFNIOEFC);
	}

	// Token: 0x060088C0 RID: 35008 RVA: 0x00300CED File Offset: 0x002FEEED
	public void ChangeSetState(bool CIOKILFKPHF)
	{
		this.currentAnimationGoing.SetStatus(CIOKILFKPHF);
	}

	// Token: 0x060088C1 RID: 35009 RVA: 0x00300CFB File Offset: 0x002FEEFB
	public void CHOODMAKIKD()
	{
		this.rectTransform.gameObject.SetActive(false);
		this.currentAnimationGoing.PlayOpenAnimations();
	}

	// Token: 0x060088C2 RID: 35010 RVA: 0x00300D19 File Offset: 0x002FEF19
	public void SetAnimationScale(Vector3 IJJDBKINBJG, Vector3 DBEPMPMLAFO, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		this.currentAnimationGoing.SetAnimationScale(IJJDBKINBJG, DBEPMPMLAFO, CANHEAPDBPD, PMOODBJDOEL);
	}

	// Token: 0x060088C3 RID: 35011 RVA: 0x00300D35 File Offset: 0x002FEF35
	private void OnDestroy()
	{
		AnimationParts.OnDisableOrDestroy -= this.AJOEMNCKMKM;
	}

	// Token: 0x060088C4 RID: 35012 RVA: 0x00300D48 File Offset: 0x002FEF48
	private void AKJIJDFJIKB()
	{
		if (!this.currentAnimationGoing.FPOJNHMKIDD())
		{
			this.currentAnimationGoing.BPIMHILGOMG();
		}
		else
		{
			this.currentAnimationGoing.PlayCloseAnimations();
		}
	}

	// Token: 0x060088C5 RID: 35013 RVA: 0x00300D75 File Offset: 0x002FEF75
	private void Update()
	{
		this.currentAnimationGoing.AnimationFrame(this.rectTransform);
	}

	// Token: 0x060088C6 RID: 35014 RVA: 0x00300D88 File Offset: 0x002FEF88
	public void MCLALIEOOLI(float HNIFGMOMJMA)
	{
		if (HNIFGMOMJMA > 940f)
		{
			this.currentAnimationGoing.SetAniamtioDuration(HNIFGMOMJMA);
		}
		else
		{
			this.currentAnimationGoing.SetAniamtioDuration(1621f);
		}
	}

	// Token: 0x060088C7 RID: 35015 RVA: 0x00300DB6 File Offset: 0x002FEFB6
	public void NCDHCJBEBNA(Vector3 OPDFCFOCGPC, Vector3 KCLMKFKHMGC, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		this.currentAnimationGoing.SetAnimationRotation(OPDFCFOCGPC, KCLMKFKHMGC, CANHEAPDBPD, PMOODBJDOEL);
	}

	// Token: 0x060088C8 RID: 35016 RVA: 0x00300DD4 File Offset: 0x002FEFD4
	private void GPKPMAGKGFA(bool AEIMJCDHKFI, AnimationParts AGNIEKAJHNM)
	{
		if (AGNIEKAJHNM != this.animationParts)
		{
			return;
		}
		if (AEIMJCDHKFI)
		{
			this.rectTransform.gameObject.SetActive(false);
		}
		else
		{
			if (base.gameObject && !this.rectTransform.gameObject == base.gameObject)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			UnityEngine.Object.DestroyImmediate(this.rectTransform.gameObject);
		}
	}

	// Token: 0x060088C9 RID: 35017 RVA: 0x00300E58 File Offset: 0x002FF058
	public void SetUnscaledTimeAnimation(bool HCAIOLGHFNN)
	{
		this.animationParts.UnscaledTimeAnimation = HCAIOLGHFNN;
	}

	// Token: 0x060088CA RID: 35018 RVA: 0x00300E66 File Offset: 0x002FF066
	private void PKEGMGDIOFC()
	{
		if (!this.currentAnimationGoing.IsObjectOpened())
		{
			this.currentAnimationGoing.PlayOpenAnimations();
		}
		else
		{
			this.currentAnimationGoing.PlayCloseAnimations();
		}
	}

	// Token: 0x060088CB RID: 35019 RVA: 0x00300D75 File Offset: 0x002FEF75
	private void FABKIGNFECE()
	{
		this.currentAnimationGoing.AnimationFrame(this.rectTransform);
	}

	// Token: 0x060088CC RID: 35020 RVA: 0x00300E93 File Offset: 0x002FF093
	public void SetFade()
	{
		this.currentAnimationGoing.SetFade(false);
	}

	// Token: 0x060088CD RID: 35021 RVA: 0x00300EA1 File Offset: 0x002FF0A1
	public void SetFade(bool FOJONHLNAOM)
	{
		this.currentAnimationGoing.SetFade(FOJONHLNAOM);
	}

	// Token: 0x060088CE RID: 35022 RVA: 0x00300EAF File Offset: 0x002FF0AF
	private void IFAFAMAHOFL()
	{
		if (this.currentAnimationGoing == null)
		{
			this.SetAnimationProperties(this.animationParts);
		}
	}

	// Token: 0x060088CF RID: 35023 RVA: 0x00300C58 File Offset: 0x002FEE58
	public void CloseObjectAnimation()
	{
		this.rectTransform.gameObject.SetActive(true);
		this.currentAnimationGoing.PlayCloseAnimations();
	}

	// Token: 0x060088D0 RID: 35024 RVA: 0x00300EC8 File Offset: 0x002FF0C8
	public void CNDMEAFLOAF(bool CIOKILFKPHF)
	{
		this.currentAnimationGoing.KLMNEMDBOOI(CIOKILFKPHF);
	}

	// Token: 0x060088D1 RID: 35025 RVA: 0x00300ED6 File Offset: 0x002FF0D6
	public void ADFHHDAGGLD()
	{
		this.rectTransform.gameObject.SetActive(true);
		this.currentAnimationGoing.PlayOpenAnimations();
	}

	// Token: 0x060088D2 RID: 35026 RVA: 0x00300ED6 File Offset: 0x002FF0D6
	public void OpenObjectAnimation()
	{
		this.rectTransform.gameObject.SetActive(true);
		this.currentAnimationGoing.PlayOpenAnimations();
	}

	// Token: 0x060088D3 RID: 35027 RVA: 0x00300EF4 File Offset: 0x002FF0F4
	public void ACHFFKPPJCN(Vector3 OPDFCFOCGPC, Vector3 KCLMKFKHMGC, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		this.currentAnimationGoing.CPPPMFEHBHD(OPDFCFOCGPC, KCLMKFKHMGC, CANHEAPDBPD, PMOODBJDOEL);
	}

	// Token: 0x060088D4 RID: 35028 RVA: 0x00300F10 File Offset: 0x002FF110
	private void JLBGEMKBIDO()
	{
		if (this.currentAnimationGoing == null)
		{
			this.LPAMCEDNAGB(this.animationParts);
		}
	}

	// Token: 0x060088D5 RID: 35029 RVA: 0x00300F29 File Offset: 0x002FF129
	public float PDOLGNFAIGJ()
	{
		return this.currentAnimationGoing.EPDECNEHFKJ();
	}

	// Token: 0x060088D6 RID: 35030 RVA: 0x00300E58 File Offset: 0x002FF058
	public void HAKBOKCEJON(bool HCAIOLGHFNN)
	{
		this.animationParts.UnscaledTimeAnimation = HCAIOLGHFNN;
	}

	// Token: 0x060088D7 RID: 35031 RVA: 0x00300F36 File Offset: 0x002FF136
	public void IGPONOLDFMK(float NGHFGPKHIPP, float HHABIDFFNCK)
	{
		this.currentAnimationGoing.OKHHGLDKFMI(NGHFGPKHIPP, HHABIDFFNCK);
	}

	// Token: 0x060088D8 RID: 35032 RVA: 0x00300F45 File Offset: 0x002FF145
	private void MKIMDFLBFOM()
	{
		AnimationParts.JAECJHCOHNH(new AnimationParts.DisableOrDestroy(this.LDKBFMGDMIP));
	}

	// Token: 0x060088D9 RID: 35033 RVA: 0x00300F58 File Offset: 0x002FF158
	private void LDKBFMGDMIP(bool AEIMJCDHKFI, AnimationParts AGNIEKAJHNM)
	{
		if (AGNIEKAJHNM != this.animationParts)
		{
			return;
		}
		if (AEIMJCDHKFI)
		{
			this.rectTransform.gameObject.SetActive(false);
		}
		else
		{
			if (base.gameObject && this.rectTransform.gameObject == base.gameObject)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			UnityEngine.Object.DestroyImmediate(this.rectTransform.gameObject);
		}
	}

	// Token: 0x060088DA RID: 35034 RVA: 0x00300FDC File Offset: 0x002FF1DC
	private void AJOEMNCKMKM(bool AEIMJCDHKFI, AnimationParts AGNIEKAJHNM)
	{
		if (AGNIEKAJHNM != this.animationParts)
		{
			return;
		}
		if (AEIMJCDHKFI)
		{
			this.rectTransform.gameObject.SetActive(false);
		}
		else
		{
			if (base.gameObject && !this.rectTransform.gameObject == base.gameObject)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			UnityEngine.Object.DestroyImmediate(this.rectTransform.gameObject);
		}
	}

	// Token: 0x060088DB RID: 35035 RVA: 0x00300EAF File Offset: 0x002FF0AF
	private void LHLDDCILFAC()
	{
		if (this.currentAnimationGoing == null)
		{
			this.SetAnimationProperties(this.animationParts);
		}
	}

	// Token: 0x060088DC RID: 35036 RVA: 0x00301060 File Offset: 0x002FF260
	public void NGAPEECMEJH(bool CIOKILFKPHF)
	{
		this.currentAnimationGoing.EMHCAMAACII(CIOKILFKPHF);
	}

	// Token: 0x060088DD RID: 35037 RVA: 0x00300CFB File Offset: 0x002FEEFB
	public void FKAEJEPJIEP()
	{
		this.rectTransform.gameObject.SetActive(false);
		this.currentAnimationGoing.PlayOpenAnimations();
	}

	// Token: 0x060088DE RID: 35038 RVA: 0x0030106E File Offset: 0x002FF26E
	public void OpenCloseObjectAnimation()
	{
		this.rectTransform.gameObject.SetActive(true);
		this.PKEGMGDIOFC();
	}

	// Token: 0x060088DF RID: 35039 RVA: 0x00301087 File Offset: 0x002FF287
	public float GetAnimationDuration()
	{
		return this.currentAnimationGoing.GetAnimationDuration();
	}

	// Token: 0x060088E0 RID: 35040 RVA: 0x00300DB6 File Offset: 0x002FEFB6
	public void SetAnimationRotation(Vector3 OPDFCFOCGPC, Vector3 KCLMKFKHMGC, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		this.currentAnimationGoing.SetAnimationRotation(OPDFCFOCGPC, KCLMKFKHMGC, CANHEAPDBPD, PMOODBJDOEL);
	}

	// Token: 0x060088E1 RID: 35041 RVA: 0x00301094 File Offset: 0x002FF294
	public void SetAnimationPosition(Vector2 ELHCACPPCAG, Vector2 EKMHMLALGPF, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		this.currentAnimationGoing.SetAnimationPos(ELHCACPPCAG, EKMHMLALGPF, CANHEAPDBPD, PMOODBJDOEL, this.rectTransform);
	}

	// Token: 0x060088E2 RID: 35042 RVA: 0x003010AC File Offset: 0x002FF2AC
	private void FKBPBJBNFPA(bool AEIMJCDHKFI, AnimationParts AGNIEKAJHNM)
	{
		if (AGNIEKAJHNM != this.animationParts)
		{
			return;
		}
		if (AEIMJCDHKFI)
		{
			this.rectTransform.gameObject.SetActive(false);
		}
		else
		{
			if (base.gameObject && this.rectTransform.gameObject == base.gameObject)
			{
				UnityEngine.Object.Destroy(base.gameObject);
			}
			UnityEngine.Object.DestroyImmediate(this.rectTransform.gameObject);
		}
	}

	// Token: 0x060088E3 RID: 35043 RVA: 0x00300EAF File Offset: 0x002FF0AF
	private void JNANCJOCAPA()
	{
		if (this.currentAnimationGoing == null)
		{
			this.SetAnimationProperties(this.animationParts);
		}
	}

	// Token: 0x060088E4 RID: 35044 RVA: 0x00301130 File Offset: 0x002FF330
	private void Start()
	{
		AnimationParts.OnDisableOrDestroy += this.AJOEMNCKMKM;
	}

	// Token: 0x060088E5 RID: 35045 RVA: 0x00301143 File Offset: 0x002FF343
	public void HOPJFMGADFG(bool CIOKILFKPHF)
	{
		this.currentAnimationGoing.AACJABEIENG(CIOKILFKPHF);
	}

	// Token: 0x060088E6 RID: 35046 RVA: 0x00301151 File Offset: 0x002FF351
	public void GEOJCPFLDFA()
	{
		this.rectTransform.gameObject.SetActive(false);
		this.currentAnimationGoing.BPIMHILGOMG();
	}

	// Token: 0x060088E7 RID: 35047 RVA: 0x00300D19 File Offset: 0x002FEF19
	public void PFBOGOCEFBA(Vector3 IJJDBKINBJG, Vector3 DBEPMPMLAFO, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		this.currentAnimationGoing.SetAnimationScale(IJJDBKINBJG, DBEPMPMLAFO, CANHEAPDBPD, PMOODBJDOEL);
	}

	// Token: 0x060088E8 RID: 35048 RVA: 0x00300CD8 File Offset: 0x002FEED8
	public void LPAMCEDNAGB(AnimationParts KEMAFNIOEFC)
	{
		this.animationParts = KEMAFNIOEFC;
		this.currentAnimationGoing = new CurrentAnimation(KEMAFNIOEFC);
	}

	// Token: 0x060088E9 RID: 35049 RVA: 0x00301170 File Offset: 0x002FF370
	public EasyTween()
	{
		this.IFAFAMAHOFL();
	}

	// Token: 0x060088EA RID: 35050 RVA: 0x003011A5 File Offset: 0x002FF3A5
	public void NIOMFNEEMDF()
	{
		this.rectTransform.gameObject.SetActive(false);
		this.PKEGMGDIOFC();
	}

	// Token: 0x060088EB RID: 35051 RVA: 0x003011BE File Offset: 0x002FF3BE
	private void AGEJKLMJGDO()
	{
		AnimationParts.GNAHAFGFEIE(new AnimationParts.DisableOrDestroy(this.LDKBFMGDMIP));
	}

	// Token: 0x060088EC RID: 35052 RVA: 0x00300BFF File Offset: 0x002FEDFF
	public void KGHKFJMDLOL(Vector3 OPDFCFOCGPC, Vector3 KCLMKFKHMGC, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		this.currentAnimationGoing.MFKLABJCGMG(OPDFCFOCGPC, KCLMKFKHMGC, CANHEAPDBPD, PMOODBJDOEL);
	}

	// Token: 0x060088ED RID: 35053 RVA: 0x003011D1 File Offset: 0x002FF3D1
	public bool IsObjectOpened()
	{
		return this.currentAnimationGoing.IsObjectOpened();
	}

	// Token: 0x060088EE RID: 35054 RVA: 0x00300CB7 File Offset: 0x002FEEB7
	private void KMKLDAJLCNM()
	{
		this.currentAnimationGoing.BFKJPGNMEJM(this.rectTransform);
	}

	// Token: 0x060088EF RID: 35055 RVA: 0x00300D19 File Offset: 0x002FEF19
	public void HAKGPLODMJL(Vector3 IJJDBKINBJG, Vector3 DBEPMPMLAFO, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		this.currentAnimationGoing.SetAnimationScale(IJJDBKINBJG, DBEPMPMLAFO, CANHEAPDBPD, PMOODBJDOEL);
	}

	// Token: 0x060088F0 RID: 35056 RVA: 0x003011DE File Offset: 0x002FF3DE
	private void APAHOINHLAJ()
	{
		this.currentAnimationGoing.LGBCEGGCJMK(this.rectTransform);
	}

	// Token: 0x060088F1 RID: 35057 RVA: 0x003011F1 File Offset: 0x002FF3F1
	public bool FJFANHLGGHL()
	{
		return this.currentAnimationGoing.JFOHIAKFPIO();
	}

	// Token: 0x060088F2 RID: 35058 RVA: 0x00300CD8 File Offset: 0x002FEED8
	public void LEFOMFFHJCA(AnimationParts KEMAFNIOEFC)
	{
		this.animationParts = KEMAFNIOEFC;
		this.currentAnimationGoing = new CurrentAnimation(KEMAFNIOEFC);
	}

	// Token: 0x060088F3 RID: 35059 RVA: 0x00300BFF File Offset: 0x002FEDFF
	public void NOKKKPAJFFC(Vector3 OPDFCFOCGPC, Vector3 KCLMKFKHMGC, AnimationCurve CANHEAPDBPD, AnimationCurve PMOODBJDOEL)
	{
		this.currentAnimationGoing.MFKLABJCGMG(OPDFCFOCGPC, KCLMKFKHMGC, CANHEAPDBPD, PMOODBJDOEL);
	}

	// Token: 0x060088F4 RID: 35060 RVA: 0x00300E58 File Offset: 0x002FF058
	public void NGJMAODBHMC(bool HCAIOLGHFNN)
	{
		this.animationParts.UnscaledTimeAnimation = HCAIOLGHFNN;
	}

	// Token: 0x060088F5 RID: 35061 RVA: 0x003011FE File Offset: 0x002FF3FE
	private void LateUpdate()
	{
		this.currentAnimationGoing.LateAnimationFrame(this.rectTransform);
	}

	// Token: 0x04000FCD RID: 4045
	public RectTransform rectTransform;

	// Token: 0x04000FCE RID: 4046
	public AnimationParts animationParts = new AnimationParts(AnimationParts.State.CLOSE, false, false, false, AnimationParts.EndTweenClose.DEACTIVATE, AnimationParts.CallbackCall.NOTHING, new UnityEvent(), new UnityEvent());

	// Token: 0x04000FCF RID: 4047
	private CurrentAnimation currentAnimationGoing;
}
