using System;
using UnityEngine;

// Token: 0x0200011C RID: 284
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Old Film/Old")]
public class CameraFilterPack_TV_Old : MonoBehaviour
{
	// Token: 0x06005923 RID: 22819 RVA: 0x001BA260 File Offset: 0x001B8460
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000101 RID: 257
	// (get) Token: 0x06005924 RID: 22820 RVA: 0x001BA27D File Offset: 0x001B847D
	private Material NBPKMLMCHFN
	{
		get
		{
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
			}
			return this.BJFKDHHMLJH;
		}
	}

	// Token: 0x06005925 RID: 22821 RVA: 0x001BA260 File Offset: 0x001B8460
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005926 RID: 22822 RVA: 0x001BA260 File Offset: 0x001B8460
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005927 RID: 22823 RVA: 0x001BA2B4 File Offset: 0x001B84B4
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("/icon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005929 RID: 22825 RVA: 0x001BA260 File Offset: 0x001B8460
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600592A RID: 22826 RVA: 0x001BA260 File Offset: 0x001B8460
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600592B RID: 22827 RVA: 0x001BA2F6 File Offset: 0x001B84F6
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-86);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600592C RID: 22828 RVA: 0x001BA260 File Offset: 0x001B8460
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600592D RID: 22829 RVA: 0x001BA32D File Offset: 0x001B852D
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600592E RID: 22830 RVA: 0x001BA260 File Offset: 0x001B8460
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600592F RID: 22831 RVA: 0x001BA364 File Offset: 0x001B8564
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1158f)
			{
				this.HBJJOCHGOPH = 1549f;
			}
			this.LONNIJMNKFB().SetFloat("Is Clone ?: ", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("_ScreenResolution", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005930 RID: 22832 RVA: 0x001BA3F4 File Offset: 0x001B85F4
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Vision_Warp");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005931 RID: 22833 RVA: 0x001BA418 File Offset: 0x001B8618
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005932 RID: 22834 RVA: 0x001BA44F File Offset: 0x001B864F
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005933 RID: 22835 RVA: 0x001BA260 File Offset: 0x001B8460
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005934 RID: 22836 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x06005935 RID: 22837 RVA: 0x001BA486 File Offset: 0x001B8686
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005936 RID: 22838 RVA: 0x001BA260 File Offset: 0x001B8460
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005937 RID: 22839 RVA: 0x001BA4C0 File Offset: 0x001B86C0
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1973f)
			{
				this.HBJJOCHGOPH = 220f;
			}
			this.KGOLDDBHIFN().SetFloat("_Vignette", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("value", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005938 RID: 22840 RVA: 0x001BA550 File Offset: 0x001B8750
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("ICollection");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005939 RID: 22841 RVA: 0x001BA574 File Offset: 0x001B8774
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find("RanksButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600593A RID: 22842 RVA: 0x001BA598 File Offset: 0x001B8798
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600593B RID: 22843 RVA: 0x001BA5D0 File Offset: 0x001B87D0
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 616f)
			{
				this.HBJJOCHGOPH = 1027f;
			}
			this.MMOODGIODPC().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("id", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600593C RID: 22844 RVA: 0x001BA660 File Offset: 0x001B8860
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600593D RID: 22845 RVA: 0x001BA697 File Offset: 0x001B8897
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-126);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600593E RID: 22846 RVA: 0x001BA260 File Offset: 0x001B8460
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600593F RID: 22847 RVA: 0x001BA6CE File Offset: 0x001B88CE
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005940 RID: 22848 RVA: 0x001BA708 File Offset: 0x001B8908
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1103f)
			{
				this.HBJJOCHGOPH = 738f;
			}
			this.JIBOKBCPDLC().SetFloat("#lives", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("_EmissionGain", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005941 RID: 22849 RVA: 0x001BA798 File Offset: 0x001B8998
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005942 RID: 22850 RVA: 0x001BA828 File Offset: 0x001B8A28
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 890f)
			{
				this.HBJJOCHGOPH = 1751f;
			}
			this.IIBLJCKLGFG().SetFloat("[PlayerBase] ShowImage \"", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("InstantiateRpc", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005943 RID: 22851 RVA: 0x001BA8B8 File Offset: 0x001B8AB8
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_Old");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005944 RID: 22852 RVA: 0x001BA260 File Offset: 0x001B8460
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005945 RID: 22853 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06005946 RID: 22854 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06005947 RID: 22855 RVA: 0x001BA8DC File Offset: 0x001B8ADC
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("Connecting to server");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005948 RID: 22856 RVA: 0x001BA900 File Offset: 0x001B8B00
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1573f)
			{
				this.HBJJOCHGOPH = 1684f;
			}
			this.GKILCDHJFEG().SetFloat(" Owner called.", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("HandleEventLeave for player ID: ", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005949 RID: 22857 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x0600594A RID: 22858 RVA: 0x001BA990 File Offset: 0x001B8B90
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1972f)
			{
				this.HBJJOCHGOPH = 935f;
			}
			this.MMOODGIODPC().SetFloat("SetScale", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("CameraFilterPack/TV_VHS", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600594B RID: 22859 RVA: 0x001BAA20 File Offset: 0x001B8C20
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600594C RID: 22860 RVA: 0x001BAA57 File Offset: 0x001B8C57
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600594D RID: 22861 RVA: 0x001BA260 File Offset: 0x001B8460
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600594E RID: 22862 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x0600594F RID: 22863 RVA: 0x001BAA7C File Offset: 0x001B8C7C
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1710f)
			{
				this.HBJJOCHGOPH = 1650f;
			}
			this.OIMMPLPBLBK().SetFloat("L2", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("ItemsStoreButton", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005950 RID: 22864 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005951 RID: 22865 RVA: 0x001BAB0C File Offset: 0x001B8D0C
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005952 RID: 22866 RVA: 0x001BAB44 File Offset: 0x001B8D44
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 7f)
			{
				this.HBJJOCHGOPH = 644f;
			}
			this.NBPKMLMCHFN.SetFloat(" ", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetFloat("CameraFilterPack/Distortion_Dissipation", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005953 RID: 22867 RVA: 0x001BABD4 File Offset: 0x001B8DD4
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1069f)
			{
				this.HBJJOCHGOPH = 1497f;
			}
			this.GKILCDHJFEG().SetFloat("_Near", this.HBJJOCHGOPH);
			this.IGIAPKPKGPK().SetFloat("Object ID. Case-Sensitive", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005954 RID: 22868 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x0400092D RID: 2349
	public Shader SCShader;

	// Token: 0x0400092E RID: 2350
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400092F RID: 2351
	[Range(1f, 10f)]
	public float Distortion = 1f;

	// Token: 0x04000930 RID: 2352
	private Material BJFKDHHMLJH;
}
