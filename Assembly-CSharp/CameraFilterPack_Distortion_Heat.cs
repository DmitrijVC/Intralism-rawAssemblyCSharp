using System;
using UnityEngine;

// Token: 0x0200008E RID: 142
[AddComponentMenu("Camera Filter Pack/Distortion/Heat")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_Heat : MonoBehaviour
{
	// Token: 0x06002946 RID: 10566 RVA: 0x000E35A4 File Offset: 0x000E17A4
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1680f)
			{
				this.HBJJOCHGOPH = 1793f;
			}
			this.IIJMIPBMMBF().SetFloat("_FilteredReflections", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("note.0", this.Distortion);
			this.DNLMFEGJJDD().SetVector("Set Sun DirectionVector", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 952f, 1777f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002947 RID: 10567 RVA: 0x000E3661 File Offset: 0x000E1861
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002948 RID: 10568 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06002949 RID: 10569 RVA: 0x000E3661 File Offset: 0x000E1861
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000073 RID: 115
	// (get) Token: 0x0600294A RID: 10570 RVA: 0x000E367E File Offset: 0x000E187E
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

	// Token: 0x0600294B RID: 10571 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x0600294C RID: 10572 RVA: 0x000E36B5 File Offset: 0x000E18B5
	private void FLKEJJEGCFA()
	{
		this.SCShader = Shader.Find("_Blend");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600294D RID: 10573 RVA: 0x000E3661 File Offset: 0x000E1861
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600294E RID: 10574 RVA: 0x000E36D9 File Offset: 0x000E18D9
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("_NoiseTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600294F RID: 10575 RVA: 0x000E36FD File Offset: 0x000E18FD
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002951 RID: 10577 RVA: 0x000E3752 File Offset: 0x000E1952
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("OK");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002952 RID: 10578 RVA: 0x000E3778 File Offset: 0x000E1978
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 595f)
			{
				this.HBJJOCHGOPH = 1985f;
			}
			this.OKJOKHGJHGF().SetFloat("Done! You are a contributor until: ", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("CameraFilterPack_3D_Binary1", this.Distortion);
			this.IIJMIPBMMBF().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1093f, 44f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002953 RID: 10579 RVA: 0x000E3838 File Offset: 0x000E1A38
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 748f)
			{
				this.HBJJOCHGOPH = 805f;
			}
			this.DNLMFEGJJDD().SetFloat("CameraFilterPack/Distortion_Aspiration", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("_VelocityScale", this.Distortion);
			this.IGIAPKPKGPK().SetVector("_BlurRadius4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1626f, 1685f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002954 RID: 10580 RVA: 0x000E3661 File Offset: 0x000E1861
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002955 RID: 10581 RVA: 0x000E38F5 File Offset: 0x000E1AF5
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("CurrentTimeLabel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002956 RID: 10582 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06002957 RID: 10583 RVA: 0x000E3919 File Offset: 0x000E1B19
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("(\\[ *quote *\\])");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002958 RID: 10584 RVA: 0x000E393D File Offset: 0x000E1B3D
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("[MapEditor] Loading music...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002959 RID: 10585 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x0600295A RID: 10586 RVA: 0x000E3661 File Offset: 0x000E1861
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600295B RID: 10587 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x0600295C RID: 10588 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x0600295D RID: 10589 RVA: 0x000E3964 File Offset: 0x000E1B64
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 865f)
			{
				this.HBJJOCHGOPH = 196f;
			}
			this.KGOLDDBHIFN().SetFloat("_Offsets", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("MapperNameText", this.Distortion);
			this.IGIAPKPKGPK().SetVector("offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 148f, 930f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600295E RID: 10590 RVA: 0x000E3A21 File Offset: 0x000E1C21
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600295F RID: 10591 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06002960 RID: 10592 RVA: 0x000E3A45 File Offset: 0x000E1C45
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("mapselector.filter.favoriteonly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002961 RID: 10593 RVA: 0x000E3A69 File Offset: 0x000E1C69
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find("curScn");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002962 RID: 10594 RVA: 0x000E3661 File Offset: 0x000E1861
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002963 RID: 10595 RVA: 0x000E3A8D File Offset: 0x000E1C8D
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002964 RID: 10596 RVA: 0x000E3AC4 File Offset: 0x000E1CC4
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_Heat");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002965 RID: 10597 RVA: 0x000E3661 File Offset: 0x000E1861
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002966 RID: 10598 RVA: 0x000E3661 File Offset: 0x000E1861
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002967 RID: 10599 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06002968 RID: 10600 RVA: 0x000E3AE8 File Offset: 0x000E1CE8
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002969 RID: 10601 RVA: 0x000E3B0C File Offset: 0x000E1D0C
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1979f)
			{
				this.HBJJOCHGOPH = 1874f;
			}
			this.KGOLDDBHIFN().SetFloat("_Speed", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("settings.volume.editor", this.Distortion);
			this.HNICHJCGJOC().SetVector("_AOTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1056f, 1968f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600296A RID: 10602 RVA: 0x000E3BCC File Offset: 0x000E1DCC
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
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600296B RID: 10603 RVA: 0x000E3C89 File Offset: 0x000E1E89
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)68;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600296C RID: 10604 RVA: 0x000E3CC0 File Offset: 0x000E1EC0
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1449f)
			{
				this.HBJJOCHGOPH = 1206f;
			}
			this.IGIAPKPKGPK().SetFloat("ScrollPanel", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("[PlayerController] ", this.Distortion);
			this.OKJOKHGJHGF().SetVector("CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 783f, 625f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600296D RID: 10605 RVA: 0x000E3D80 File Offset: 0x000E1F80
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 520f)
			{
				this.HBJJOCHGOPH = 1497f;
			}
			this.KGOLDDBHIFN().SetFloat("\r", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("Creating new item...", this.Distortion);
			this.NBPKMLMCHFN.SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1948f, 1668f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600296E RID: 10606 RVA: 0x000E3E3D File Offset: 0x000E203D
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("PLEASE WAIT");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600296F RID: 10607 RVA: 0x000E3661 File Offset: 0x000E1861
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002970 RID: 10608 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x06002971 RID: 10609 RVA: 0x000E3E61 File Offset: 0x000E2061
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("new round");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002972 RID: 10610 RVA: 0x000E3E85 File Offset: 0x000E2085
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002973 RID: 10611 RVA: 0x000E3661 File Offset: 0x000E1861
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002974 RID: 10612 RVA: 0x000E3EBC File Offset: 0x000E20BC
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("skin.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002975 RID: 10613 RVA: 0x000E3EE0 File Offset: 0x000E20E0
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1442f)
			{
				this.HBJJOCHGOPH = 742f;
			}
			this.KEMAALEODNH().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("n/a", this.Distortion);
			this.KGOLDDBHIFN().SetVector("Mask texture not readable, set your sprite to Texture Type 'Advanced' and check 'Read/Write Enabled'", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1693f, 1469f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002976 RID: 10614 RVA: 0x000E3F9D File Offset: 0x000E219D
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002977 RID: 10615 RVA: 0x000E3661 File Offset: 0x000E1861
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002978 RID: 10616 RVA: 0x000E3FD4 File Offset: 0x000E21D4
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002979 RID: 10617 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x0600297A RID: 10618 RVA: 0x000E3661 File Offset: 0x000E1861
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600297B RID: 10619 RVA: 0x000E400C File Offset: 0x000E220C
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 696f)
			{
				this.HBJJOCHGOPH = 395f;
			}
			this.KGOLDDBHIFN().SetFloat("DPADHOR", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("UseScanLine", this.Distortion);
			this.MCDGIILBNIF().SetVector("challenges.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 31f, 678f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600297C RID: 10620 RVA: 0x000E40C9 File Offset: 0x000E22C9
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("Drop_Far");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600297D RID: 10621 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x0600297E RID: 10622 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x0600297F RID: 10623 RVA: 0x000E40F0 File Offset: 0x000E22F0
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 436f)
			{
				this.HBJJOCHGOPH = 154f;
			}
			this.KEMAALEODNH().SetFloat("0 - sun, 1 - satellite, 2 - particles emitter", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("CameraFilterPack/Drawing_CellShading", this.Distortion);
			this.DNLMFEGJJDD().SetVector("88f00bdf0ad61b16b803971ebe071962", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 63f, 874f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002980 RID: 10624 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06002981 RID: 10625 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06002982 RID: 10626 RVA: 0x000E3661 File Offset: 0x000E1861
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002983 RID: 10627 RVA: 0x000E41B0 File Offset: 0x000E23B0
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1060f)
			{
				this.HBJJOCHGOPH = 1604f;
			}
			this.IIJMIPBMMBF().SetFloat("Run a command for data system", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("CameraFilterPack/BlurTiltShift", this.Distortion);
			this.NBPKMLMCHFN.SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 828f, 639f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002984 RID: 10628 RVA: 0x000E426D File Offset: 0x000E246D
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002985 RID: 10629 RVA: 0x000E3661 File Offset: 0x000E1861
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002986 RID: 10630 RVA: 0x000E42A4 File Offset: 0x000E24A4
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002987 RID: 10631 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06002988 RID: 10632 RVA: 0x000E42DB File Offset: 0x000E24DB
	private Material GHHPOGODBHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002989 RID: 10633 RVA: 0x000E3661 File Offset: 0x000E1861
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600298A RID: 10634 RVA: 0x000E426D File Offset: 0x000E246D
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600298B RID: 10635 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x0600298C RID: 10636 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x0600298D RID: 10637 RVA: 0x000E4312 File Offset: 0x000E2512
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600298E RID: 10638 RVA: 0x000E4336 File Offset: 0x000E2536
	private void JKBMKPDGCHG()
	{
		this.SCShader = Shader.Find("Tab1Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600298F RID: 10639 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x06002990 RID: 10640 RVA: 0x000E3661 File Offset: 0x000E1861
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x04000506 RID: 1286
	public Shader SCShader;

	// Token: 0x04000507 RID: 1287
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000508 RID: 1288
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000509 RID: 1289
	private Material BJFKDHHMLJH;

	// Token: 0x0400050A RID: 1290
	[Range(1f, 100f)]
	public float Distortion = 35f;
}
