using System;
using UnityEngine;

// Token: 0x0200005A RID: 90
[AddComponentMenu("Camera Filter Pack/Weather/Blizzard")]
[ExecuteInEditMode]
public class CameraFilterPack_Blizzard : MonoBehaviour
{
	// Token: 0x06001952 RID: 6482 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06001953 RID: 6483 RVA: 0x000A050B File Offset: 0x0009E70B
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)110;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001954 RID: 6484 RVA: 0x000A0544 File Offset: 0x0009E744
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1247f)
			{
				this.HBJJOCHGOPH = 1940f;
			}
			this.PDEAHJPOMEF().SetFloat("_RandomTexture", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat(" registered.", this._Speed);
			this.NBPKMLMCHFN.SetFloat("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", this._Size);
			this.PDEAHJPOMEF().SetFloat("_Value", this._Fade);
			this.FEAEGGCNIAA().SetTexture("JoinButton", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001955 RID: 6485 RVA: 0x000A0616 File Offset: 0x0009E816
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001956 RID: 6486 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x06001957 RID: 6487 RVA: 0x000A0633 File Offset: 0x0009E833
	private void KCCIEMBMOBA()
	{
		this.FPHEBLMINDA = (Resources.Load("Not sending leave operation. State is not 'Joined': ") as Texture2D);
		this.SCShader = Shader.Find("sprite");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001958 RID: 6488 RVA: 0x000A066C File Offset: 0x0009E86C
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001959 RID: 6489 RVA: 0x000A06A3 File Offset: 0x0009E8A3
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600195A RID: 6490 RVA: 0x000A06DA File Offset: 0x0009E8DA
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)108;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600195B RID: 6491 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600195C RID: 6492 RVA: 0x000A0711 File Offset: 0x0009E911
	private void NBGIMIDICKE()
	{
		this.FPHEBLMINDA = (Resources.Load("Submit") as Texture2D);
		this.SCShader = Shader.Find("_GrainTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600195D RID: 6493 RVA: 0x000A074C File Offset: 0x0009E94C
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1668f)
			{
				this.HBJJOCHGOPH = 1295f;
			}
			this.GKILCDHJFEG().SetFloat(" PhotonView: ", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("HPToggle", this._Speed);
			this.MMOODGIODPC().SetFloat("The other scroll rect doesnt support scrolling vertically", this._Size);
			this.LONNIJMNKFB().SetFloat("Set Sun Colors", this._Fade);
			this.LONNIJMNKFB().SetTexture("#failed", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600195E RID: 6494 RVA: 0x000A0820 File Offset: 0x0009EA20
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
			this.NBPKMLMCHFN.SetFloat("_Value", this._Speed);
			this.NBPKMLMCHFN.SetFloat("_Value2", this._Size);
			this.NBPKMLMCHFN.SetFloat("_Value3", this._Fade);
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600195F RID: 6495 RVA: 0x000A08F2 File Offset: 0x0009EAF2
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001960 RID: 6496 RVA: 0x000A092C File Offset: 0x0009EB2C
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 556f)
			{
				this.HBJJOCHGOPH = 206f;
			}
			this.ACHNOHCLGOO().SetFloat("_Value", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("_Near", this._Speed);
			this.KGOLDDBHIFN().SetFloat(",", this._Size);
			this.FEAEGGCNIAA().SetFloat("Set Background Color", this._Fade);
			this.KGOLDDBHIFN().SetTexture("Trackpad", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001961 RID: 6497 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06001962 RID: 6498 RVA: 0x000A09FE File Offset: 0x0009EBFE
	private void FHGKIOOMMOH()
	{
		this.FPHEBLMINDA = (Resources.Load("restrictions\n\n#until: ") as Texture2D);
		this.SCShader = Shader.Find("[#clicktogetreward]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001963 RID: 6499 RVA: 0x000A0A37 File Offset: 0x0009EC37
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001964 RID: 6500 RVA: 0x000A0616 File Offset: 0x0009E816
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001965 RID: 6501 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06001966 RID: 6502 RVA: 0x000A0A6E File Offset: 0x0009EC6E
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-85);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001967 RID: 6503 RVA: 0x000A0616 File Offset: 0x0009E816
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001968 RID: 6504 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06001969 RID: 6505 RVA: 0x000A0AA8 File Offset: 0x0009ECA8
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1690f)
			{
				this.HBJJOCHGOPH = 62f;
			}
			this.PDEAHJPOMEF().SetFloat("menu.enableselectormusic", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetFloat("_Params", this._Speed);
			this.MMOODGIODPC().SetFloat("AvatarImage", this._Size);
			this.LNLKMDPHDCC().SetFloat("CameraFilterPack/Blend2Camera_HardLight", this._Fade);
			this.EFDEIFCDAFG().SetTexture("cipherText", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600196A RID: 6506 RVA: 0x000A0B7A File Offset: 0x0009ED7A
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600196B RID: 6507 RVA: 0x000A0BB1 File Offset: 0x0009EDB1
	private void NCNPAKFAFOE()
	{
		this.FPHEBLMINDA = (Resources.Load("menu.selectedplaymode") as Texture2D);
		this.SCShader = Shader.Find("request");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600196C RID: 6508 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x0600196D RID: 6509 RVA: 0x000A0BEC File Offset: 0x0009EDEC
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 422f)
			{
				this.HBJJOCHGOPH = 658f;
			}
			this.FEAEGGCNIAA().SetFloat("_Green_G", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("_Visualize", this._Speed);
			this.LNLKMDPHDCC().SetFloat("_Distance", this._Size);
			this.GKILCDHJFEG().SetFloat("menu.tabid", this._Fade);
			this.EFDEIFCDAFG().SetTexture("_SecondTex", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600196E RID: 6510 RVA: 0x000A0CBE File Offset: 0x0009EEBE
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-125);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600196F RID: 6511 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06001970 RID: 6512 RVA: 0x000A0CF5 File Offset: 0x0009EEF5
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001971 RID: 6513 RVA: 0x000A0616 File Offset: 0x0009E816
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001972 RID: 6514 RVA: 0x000A0616 File Offset: 0x0009E816
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001973 RID: 6515 RVA: 0x000A0616 File Offset: 0x0009E816
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001974 RID: 6516 RVA: 0x000A0D2C File Offset: 0x0009EF2C
	private void KDMKDEKCELE()
	{
		this.FPHEBLMINDA = (Resources.Load("mapselector.filter.subscribedonly") as Texture2D);
		this.SCShader = Shader.Find("\nCreated by Oxy949");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001975 RID: 6517 RVA: 0x000A0D68 File Offset: 0x0009EF68
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 20f)
			{
				this.HBJJOCHGOPH = 262f;
			}
			this.LNLKMDPHDCC().SetFloat("Items/", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("_MainTex", this._Speed);
			this.IGIAPKPKGPK().SetFloat("#mapalreadyexistupdate", this._Size);
			this.GKILCDHJFEG().SetFloat("[Up-Right]", this._Fade);
			this.LNLKMDPHDCC().SetTexture("[", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001976 RID: 6518 RVA: 0x000A0E3A File Offset: 0x0009F03A
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001977 RID: 6519 RVA: 0x000A0E74 File Offset: 0x0009F074
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 386f)
			{
				this.HBJJOCHGOPH = 1402f;
			}
			this.ACHNOHCLGOO().SetFloat("PunRespawn with Position.", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("_ScreenResolution", this._Speed);
			this.PGPEMMBJOOG().SetFloat("_DiffuseColor", this._Size);
			this.ACHNOHCLGOO().SetFloat("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", this._Fade);
			this.EFDEIFCDAFG().SetTexture("Is it practically possible?", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001978 RID: 6520 RVA: 0x000A0F46 File Offset: 0x0009F146
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001979 RID: 6521 RVA: 0x000A0F7D File Offset: 0x0009F17D
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600197A RID: 6522 RVA: 0x000A0FB4 File Offset: 0x0009F1B4
	private void BMIOFJFMCBG()
	{
		this.FPHEBLMINDA = (Resources.Load("false") as Texture2D);
		this.SCShader = Shader.Find("OnDeserialize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600197B RID: 6523 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x17000040 RID: 64
	// (get) Token: 0x0600197C RID: 6524 RVA: 0x000A0FED File Offset: 0x0009F1ED
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

	// Token: 0x0600197D RID: 6525 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x0600197E RID: 6526 RVA: 0x000A0616 File Offset: 0x0009E816
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600197F RID: 6527 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x06001980 RID: 6528 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06001981 RID: 6529 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06001983 RID: 6531 RVA: 0x000A1058 File Offset: 0x0009F258
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 173f)
			{
				this.HBJJOCHGOPH = 400f;
			}
			this.LONNIJMNKFB().SetFloat("_MatrixSize", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("th", this._Speed);
			this.LONNIJMNKFB().SetFloat("y", this._Size);
			this.NFMGLIKNOOC().SetFloat("float,10", this._Fade);
			this.FEAEGGCNIAA().SetTexture("_Value", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001984 RID: 6532 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06001985 RID: 6533 RVA: 0x000A0616 File Offset: 0x0009E816
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001986 RID: 6534 RVA: 0x000A112C File Offset: 0x0009F32C
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 349f)
			{
				this.HBJJOCHGOPH = 1119f;
			}
			this.EFDEIFCDAFG().SetFloat("MapConfig", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("SaveButton", this._Speed);
			this.MMOODGIODPC().SetFloat("PublishButton", this._Size);
			this.PDEAHJPOMEF().SetFloat("PS Home", this._Fade);
			this.KGOLDDBHIFN().SetTexture("ArcsDestroyDelaySlider", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001987 RID: 6535 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x06001988 RID: 6536 RVA: 0x000A11FE File Offset: 0x0009F3FE
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_Blizzard1") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Blizzard");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001989 RID: 6537 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x0600198A RID: 6538 RVA: 0x000A1238 File Offset: 0x0009F438
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1346f)
			{
				this.HBJJOCHGOPH = 1872f;
			}
			this.LNLKMDPHDCC().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("_AdaptationSpeed", this._Speed);
			this.GKILCDHJFEG().SetFloat("Set Satellite Radius", this._Size);
			this.PDEAHJPOMEF().SetFloat("_Value", this._Fade);
			this.MMOODGIODPC().SetTexture("_Value2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600198B RID: 6539 RVA: 0x000A130A File Offset: 0x0009F50A
	private void GPNAOAKCMHC()
	{
		this.FPHEBLMINDA = (Resources.Load("player.gamecompleted") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0400038F RID: 911
	public Shader SCShader;

	// Token: 0x04000390 RID: 912
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000391 RID: 913
	[Range(0f, 2f)]
	public float _Speed = 1f;

	// Token: 0x04000392 RID: 914
	[Range(0.2f, 2f)]
	public float _Size = 1f;

	// Token: 0x04000393 RID: 915
	[Range(0f, 1f)]
	public float _Fade = 1f;

	// Token: 0x04000394 RID: 916
	private Material BJFKDHHMLJH;

	// Token: 0x04000395 RID: 917
	private Texture2D FPHEBLMINDA;
}
