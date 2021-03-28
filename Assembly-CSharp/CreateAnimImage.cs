using System;
using System.Collections.Generic;
using UnityEngine;

// Token: 0x02000231 RID: 561
public class CreateAnimImage : MonoBehaviour
{
	// Token: 0x06008844 RID: 34884 RVA: 0x002FDB34 File Offset: 0x002FBD34
	private void Start()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008845 RID: 34885 RVA: 0x002FDB74 File Offset: 0x002FBD74
	private void FGIIEGMMKND()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x06008846 RID: 34886 RVA: 0x002FDBE8 File Offset: 0x002FBDE8
	private void AFEOEMBNGOL()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 0f;
		for (int i = 0; i < this.HowManyButtons; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.SetAnimationPosition(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.SetFade();
			component.OpenCloseObjectAnimation();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008847 RID: 34887 RVA: 0x002FDCB8 File Offset: 0x002FBEB8
	private void MNNNKNBKDNM()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 346f;
		for (int i = 0; i < this.HowManyButtons; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.SetAnimationPosition(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.SetFade();
			component.OpenCloseObjectAnimation();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008848 RID: 34888 RVA: 0x002FDD87 File Offset: 0x002FBF87
	public void CreateButtons()
	{
		this.AFEOEMBNGOL();
		this.FGIIEGMMKND();
	}

	// Token: 0x06008849 RID: 34889 RVA: 0x002FDD98 File Offset: 0x002FBF98
	public void CallBack()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < this.createImageOtherReference.Length; i++)
			{
				this.createImageOtherReference[i].DestroyButtons();
			}
			this.CreateButtons();
		}
	}

	// Token: 0x0600884A RID: 34890 RVA: 0x002FDDE4 File Offset: 0x002FBFE4
	public void PCGIJPAKBAE()
	{
		for (int i = 0; i < this.ABIMNKKBBKF.Count; i += 0)
		{
			this.ABIMNKKBBKF[i].OpenCloseObjectAnimation();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x0600884B RID: 34891 RVA: 0x002FDE2C File Offset: 0x002FC02C
	public void PFEOINNBEFC()
	{
		for (int i = 0; i < this.ABIMNKKBBKF.Count; i += 0)
		{
			this.ABIMNKKBBKF[i].NIOMFNEEMDF();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x0600884D RID: 34893 RVA: 0x002FDE84 File Offset: 0x002FC084
	private void MLGMMLDKOOK()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x0600884E RID: 34894 RVA: 0x002FDEF8 File Offset: 0x002FC0F8
	private void JJPDIDPLKKN()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x0600884F RID: 34895 RVA: 0x002FDF6C File Offset: 0x002FC16C
	private void PLOCFPCIHFB()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x06008850 RID: 34896 RVA: 0x002FDFDD File Offset: 0x002FC1DD
	public void GGJJCCOPBJP()
	{
		this.BEMCBOIBEJC();
		this.KADJLECBCOG();
	}

	// Token: 0x06008851 RID: 34897 RVA: 0x002FDFEC File Offset: 0x002FC1EC
	public void BLFFDCAEFAK()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < this.createImageOtherReference.Length; i += 0)
			{
				this.createImageOtherReference[i].JHGAIGNDPMK();
			}
			this.CEINCDAPPJM();
		}
	}

	// Token: 0x06008852 RID: 34898 RVA: 0x002FE038 File Offset: 0x002FC238
	private void NCNPAKFAFOE()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008853 RID: 34899 RVA: 0x002FE078 File Offset: 0x002FC278
	private void DNNFHBOOPIN()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008854 RID: 34900 RVA: 0x002FE0B8 File Offset: 0x002FC2B8
	public void GDPEJIKOGDL()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < this.createImageOtherReference.Length; i += 0)
			{
				this.createImageOtherReference[i].EMIMGAIPJLI();
			}
			this.CEINCDAPPJM();
		}
	}

	// Token: 0x06008855 RID: 34901 RVA: 0x002FE104 File Offset: 0x002FC304
	private void BEMCBOIBEJC()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 402f;
		for (int i = 1; i < this.HowManyButtons; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.SetAnimationPosition(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.SetFade();
			component.OpenCloseObjectAnimation();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008856 RID: 34902 RVA: 0x002FE1D4 File Offset: 0x002FC3D4
	private void KCCIEMBMOBA()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008857 RID: 34903 RVA: 0x002FE214 File Offset: 0x002FC414
	private void IMOAADPBBKK()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 4f;
		for (int i = 0; i < this.HowManyButtons; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.SetAnimationPosition(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.SetFade();
			component.OpenCloseObjectAnimation();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008858 RID: 34904 RVA: 0x002FE2E4 File Offset: 0x002FC4E4
	private void FIKFJDFELIP()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008859 RID: 34905 RVA: 0x002FE324 File Offset: 0x002FC524
	private void CAFEAOBPKGJ()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 402f;
		for (int i = 0; i < this.HowManyButtons; i += 0)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.SetAnimationPosition(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.SetFade();
			component.OpenCloseObjectAnimation();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x0600885A RID: 34906 RVA: 0x002FDFDD File Offset: 0x002FC1DD
	public void IGKGHEMJJIB()
	{
		this.BEMCBOIBEJC();
		this.KADJLECBCOG();
	}

	// Token: 0x0600885B RID: 34907 RVA: 0x002FE3F4 File Offset: 0x002FC5F4
	private void HMPGIFBJFIK()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x0600885C RID: 34908 RVA: 0x002FE432 File Offset: 0x002FC632
	public void JDHJKLAMEIA()
	{
		this.IMOAADPBBKK();
		this.KADJLECBCOG();
	}

	// Token: 0x0600885D RID: 34909 RVA: 0x002FE440 File Offset: 0x002FC640
	public void PKKOKCNCNAG()
	{
		for (int i = 0; i < this.ABIMNKKBBKF.Count; i += 0)
		{
			this.ABIMNKKBBKF[i].OpenCloseObjectAnimation();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x0600885E RID: 34910 RVA: 0x002FE488 File Offset: 0x002FC688
	public void BNOIPEKEGIE()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < this.createImageOtherReference.Length; i++)
			{
				this.createImageOtherReference[i].MCMLDECJOPH();
			}
			this.CreateButtons();
		}
	}

	// Token: 0x0600885F RID: 34911 RVA: 0x002FE4D4 File Offset: 0x002FC6D4
	public void AEAENECIPCM()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 0; i < this.createImageOtherReference.Length; i++)
			{
				this.createImageOtherReference[i].MCMLDECJOPH();
			}
			this.GGJJCCOPBJP();
		}
	}

	// Token: 0x06008860 RID: 34912 RVA: 0x002FE520 File Offset: 0x002FC720
	public void ILCHJGLLMPM()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < this.createImageOtherReference.Length; i += 0)
			{
				this.createImageOtherReference[i].PFEOINNBEFC();
			}
			this.CreateButtons();
		}
	}

	// Token: 0x06008861 RID: 34913 RVA: 0x002FE569 File Offset: 0x002FC769
	public void NAIBMAEGOAL()
	{
		this.MBEPNPAMOAO();
		this.PLOCFPCIHFB();
	}

	// Token: 0x06008862 RID: 34914 RVA: 0x002FE578 File Offset: 0x002FC778
	public void HEOPOEADDPI()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < this.createImageOtherReference.Length; i += 0)
			{
				this.createImageOtherReference[i].JHGAIGNDPMK();
			}
			this.JDHJKLAMEIA();
		}
	}

	// Token: 0x06008863 RID: 34915 RVA: 0x002FE5C4 File Offset: 0x002FC7C4
	private void FCPOECKDOJB()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 620f;
		for (int i = 1; i < this.HowManyButtons; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.SetAnimationPosition(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.SetFade();
			component.NIOMFNEEMDF();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x06008864 RID: 34916 RVA: 0x002FE693 File Offset: 0x002FC893
	public void CEINCDAPPJM()
	{
		this.MNNNKNBKDNM();
		this.PLOCFPCIHFB();
	}

	// Token: 0x06008865 RID: 34917 RVA: 0x002FE6A4 File Offset: 0x002FC8A4
	public void LOPLAFPBNBF()
	{
		for (int i = 0; i < this.ABIMNKKBBKF.Count; i++)
		{
			this.ABIMNKKBBKF[i].OpenCloseObjectAnimation();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008866 RID: 34918 RVA: 0x002FE6E9 File Offset: 0x002FC8E9
	public void CMOKDEMPBGG()
	{
		this.FCPOECKDOJB();
		this.KADJLECBCOG();
	}

	// Token: 0x06008867 RID: 34919 RVA: 0x002FE6F8 File Offset: 0x002FC8F8
	public void DCFKADMCJME()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < this.createImageOtherReference.Length; i += 0)
			{
				this.createImageOtherReference[i].CKMIAFKLMNJ();
			}
			this.NAIBMAEGOAL();
		}
	}

	// Token: 0x06008868 RID: 34920 RVA: 0x002FE744 File Offset: 0x002FC944
	public void JHGAIGNDPMK()
	{
		for (int i = 1; i < this.ABIMNKKBBKF.Count; i += 0)
		{
			this.ABIMNKKBBKF[i].OpenCloseObjectAnimation();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x06008869 RID: 34921 RVA: 0x002FE78C File Offset: 0x002FC98C
	public void ONMMOMBBOAI()
	{
		if (this.ABIMNKKBBKF.Count == 0)
		{
			for (int i = 1; i < this.createImageOtherReference.Length; i += 0)
			{
				this.createImageOtherReference[i].EMIMGAIPJLI();
			}
			this.CEINCDAPPJM();
		}
	}

	// Token: 0x0600886A RID: 34922 RVA: 0x002FE7D8 File Offset: 0x002FC9D8
	public void EMIMGAIPJLI()
	{
		for (int i = 1; i < this.ABIMNKKBBKF.Count; i++)
		{
			this.ABIMNKKBBKF[i].NIOMFNEEMDF();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x0600886B RID: 34923 RVA: 0x002FE820 File Offset: 0x002FCA20
	private void MBEPNPAMOAO()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 1699f;
		for (int i = 0; i < this.HowManyButtons; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, true);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.SetAnimationPosition(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.SetFade();
			component.NIOMFNEEMDF();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x0600886C RID: 34924 RVA: 0x002FE8F0 File Offset: 0x002FCAF0
	private void LECIPLOGNEA()
	{
		Vector3 endAnim = this.EndAnim;
		this.GDDJIOHEJGI = 1094f;
		for (int i = 1; i < this.HowManyButtons; i++)
		{
			GameObject gameObject = UnityEngine.Object.Instantiate<GameObject>(this.CreateInstance);
			gameObject.transform.SetParent(this.RootRect, false);
			EasyTween component = gameObject.GetComponent<EasyTween>();
			this.ABIMNKKBBKF.Add(component);
			this.StartAnim.y = endAnim.y;
			component.SetAnimationPosition(this.StartAnim, endAnim, this.EnterAnim, this.ExitAnim);
			component.SetFade();
			component.NIOMFNEEMDF();
			endAnim.y += this.Offset;
			this.GDDJIOHEJGI += this.Offset;
		}
	}

	// Token: 0x0600886D RID: 34925 RVA: 0x002FE9C0 File Offset: 0x002FCBC0
	public void CKMIAFKLMNJ()
	{
		for (int i = 0; i < this.ABIMNKKBBKF.Count; i++)
		{
			this.ABIMNKKBBKF[i].NIOMFNEEMDF();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x0600886E RID: 34926 RVA: 0x002FEA08 File Offset: 0x002FCC08
	public void MCMLDECJOPH()
	{
		for (int i = 0; i < this.ABIMNKKBBKF.Count; i += 0)
		{
			this.ABIMNKKBBKF[i].OpenCloseObjectAnimation();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x0600886F RID: 34927 RVA: 0x002FEA50 File Offset: 0x002FCC50
	private void KADJLECBCOG()
	{
		if (this.AFBJLGGJPEG.x < Mathf.Abs(this.GDDJIOHEJGI))
		{
			this.RootRect.offsetMin = new Vector2(this.RootRect.offsetMin.x, this.GDDJIOHEJGI + this.AFBJLGGJPEG.x + this.RootRect.offsetMax.y);
		}
	}

	// Token: 0x06008870 RID: 34928 RVA: 0x002FEAC4 File Offset: 0x002FCCC4
	private void BEBNOKFLJPH()
	{
		this.AFBJLGGJPEG = new Vector2(this.RootRect.rect.height, this.RootRect.rect.width);
	}

	// Token: 0x06008871 RID: 34929 RVA: 0x002FEB04 File Offset: 0x002FCD04
	public void DestroyButtons()
	{
		for (int i = 0; i < this.ABIMNKKBBKF.Count; i++)
		{
			this.ABIMNKKBBKF[i].OpenCloseObjectAnimation();
		}
		this.ABIMNKKBBKF.Clear();
	}

	// Token: 0x04000FBC RID: 4028
	public CreateAnimImage[] createImageOtherReference;

	// Token: 0x04000FBD RID: 4029
	public GameObject CreateInstance;

	// Token: 0x04000FBE RID: 4030
	public int HowManyButtons;

	// Token: 0x04000FBF RID: 4031
	public Vector3 StartAnim;

	// Token: 0x04000FC0 RID: 4032
	public Vector3 EndAnim;

	// Token: 0x04000FC1 RID: 4033
	public float Offset;

	// Token: 0x04000FC2 RID: 4034
	public AnimationCurve EnterAnim;

	// Token: 0x04000FC3 RID: 4035
	public AnimationCurve ExitAnim;

	// Token: 0x04000FC4 RID: 4036
	public RectTransform RootRect;

	// Token: 0x04000FC5 RID: 4037
	public RectTransform RootCanvas;

	// Token: 0x04000FC6 RID: 4038
	private List<EasyTween> ABIMNKKBBKF = new List<EasyTween>();

	// Token: 0x04000FC7 RID: 4039
	private Vector2 AFBJLGGJPEG;

	// Token: 0x04000FC8 RID: 4040
	private float GDDJIOHEJGI;
}
