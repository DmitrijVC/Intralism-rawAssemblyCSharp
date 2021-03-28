using System;
using UnityEngine;

// Token: 0x02000076 RID: 118
[AddComponentMenu("Camera Filter Pack/Colors/Color_YUV")]
[ExecuteInEditMode]
public class CameraFilterPack_Color_YUV : MonoBehaviour
{
	// Token: 0x0600217E RID: 8574 RVA: 0x000C0FBC File Offset: 0x000BF1BC
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 714f)
			{
				this.HBJJOCHGOPH = 539f;
			}
			this.PDEAHJPOMEF().SetFloat("Show image from resources by id at the center of the screen at foreground or background", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("editorVolume", this._Y);
			this.KGOLDDBHIFN().SetFloat("inventory.lastitemscount", this._U);
			this.NLFJGMBCICG().SetFloat("CameraFilterPack/Color_Contrast", this._V);
			this.NBPKMLMCHFN.SetVector("inventory.selected.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1582f, 1591f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600217F RID: 8575 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x06002180 RID: 8576 RVA: 0x000C10A5 File Offset: 0x000BF2A5
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002181 RID: 8577 RVA: 0x000C10C2 File Offset: 0x000BF2C2
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("[NetworkScene] Exited");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002182 RID: 8578 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06002183 RID: 8579 RVA: 0x000C10E8 File Offset: 0x000BF2E8
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 732f)
			{
				this.HBJJOCHGOPH = 1394f;
			}
			this.CEKJODEAMGB().SetFloat("SetSatelliteSensitivity", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("PLEASE WAIT", this._Y);
			this.NBPKMLMCHFN.SetFloat("_MidGrey", this._U);
			this.CEKJODEAMGB().SetFloat("http", this._V);
			this.PLBEJJIHFPB().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 757f, 516f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002184 RID: 8580 RVA: 0x000C11D1 File Offset: 0x000BF3D1
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("_FixDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002185 RID: 8581 RVA: 0x000C10A5 File Offset: 0x000BF2A5
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002186 RID: 8582 RVA: 0x000C10A5 File Offset: 0x000BF2A5
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002187 RID: 8583 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06002188 RID: 8584 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06002189 RID: 8585 RVA: 0x000C10A5 File Offset: 0x000BF2A5
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600218A RID: 8586 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x0600218B RID: 8587 RVA: 0x000C10A5 File Offset: 0x000BF2A5
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600218C RID: 8588 RVA: 0x000C10A5 File Offset: 0x000BF2A5
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600218D RID: 8589 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x0600218E RID: 8590 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x0600218F RID: 8591 RVA: 0x000C10A5 File Offset: 0x000BF2A5
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002190 RID: 8592 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06002191 RID: 8593 RVA: 0x000C11F5 File Offset: 0x000BF3F5
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002192 RID: 8594 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x06002193 RID: 8595 RVA: 0x000C1219 File Offset: 0x000BF419
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Color_YUV");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002194 RID: 8596 RVA: 0x000C123D File Offset: 0x000BF43D
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("BadgeText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002195 RID: 8597 RVA: 0x000C10A5 File Offset: 0x000BF2A5
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002196 RID: 8598 RVA: 0x000C1261 File Offset: 0x000BF461
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002197 RID: 8599 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x06002198 RID: 8600 RVA: 0x000C1298 File Offset: 0x000BF498
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 213f)
			{
				this.HBJJOCHGOPH = 1058f;
			}
			this.PDEAHJPOMEF().SetFloat("Keeping GameObject in the scene: ", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("_TimeX", this._Y);
			this.NBPKMLMCHFN.SetFloat("settings.volume.editor", this._U);
			this.CEKJODEAMGB().SetFloat("_VelocityScale", this._V);
			this.CEKJODEAMGB().SetVector(" ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1497f, 687f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002199 RID: 8601 RVA: 0x000C1381 File Offset: 0x000BF581
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600219A RID: 8602 RVA: 0x000C13B8 File Offset: 0x000BF5B8
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600219B RID: 8603 RVA: 0x000C13F0 File Offset: 0x000BF5F0
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 490f)
			{
				this.HBJJOCHGOPH = 501f;
			}
			this.NBPKMLMCHFN.SetFloat("0x", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("_TimeX", this._Y);
			this.EHDJJANLINB().SetFloat("Hidden/Image Effects/Cinematic/AmbientOcclusion", this._U);
			this.PLBEJJIHFPB().SetFloat("_EmissionColor", this._V);
			this.LDNADDJMIPK().SetVector("speed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1516f, 786f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600219C RID: 8604 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x1700005C RID: 92
	// (get) Token: 0x0600219D RID: 8605 RVA: 0x000C14D9 File Offset: 0x000BF6D9
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

	// Token: 0x0600219E RID: 8606 RVA: 0x000C1510 File Offset: 0x000BF710
	private Material BLMPMOIDGMG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600219F RID: 8607 RVA: 0x000C1547 File Offset: 0x000BF747
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060021A0 RID: 8608 RVA: 0x000C156B File Offset: 0x000BF76B
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060021A1 RID: 8609 RVA: 0x000C1590 File Offset: 0x000BF790
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 127f)
			{
				this.HBJJOCHGOPH = 1764f;
			}
			this.IIJMIPBMMBF().SetFloat("note.4", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("[", this._Y);
			this.GJHLADDCMFF().SetFloat("_Blue_R", this._U);
			this.NLFJGMBCICG().SetFloat("_PrevViewProj", this._V);
			this.EHDJJANLINB().SetVector("\nCreated by Oxy949", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 591f, 679f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060021A2 RID: 8610 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x060021A3 RID: 8611 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060021A4 RID: 8612 RVA: 0x000C1547 File Offset: 0x000BF747
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060021A5 RID: 8613 RVA: 0x000C167C File Offset: 0x000BF87C
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1335f)
			{
				this.HBJJOCHGOPH = 463f;
			}
			this.NLFJGMBCICG().SetFloat("Set sun lerp speed", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("[ResourcesManager] Unloading data resources", this._Y);
			this.LDNADDJMIPK().SetFloat("[DiscordController] Sectate ({0})", this._U);
			this.HHIFMIPPMPF().SetFloat(".", this._V);
			this.NBPKMLMCHFN.SetVector("settings.gamemessagesduration", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1021f, 1955f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060021A6 RID: 8614 RVA: 0x000C10A5 File Offset: 0x000BF2A5
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060021A7 RID: 8615 RVA: 0x000C10A5 File Offset: 0x000BF2A5
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060021A8 RID: 8616 RVA: 0x000C1768 File Offset: 0x000BF968
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1443f)
			{
				this.HBJJOCHGOPH = 1294f;
			}
			this.OCHJIMJNEMO().SetFloat("_InternalLutTex", this.HBJJOCHGOPH);
			this.CEKJODEAMGB().SetFloat("\" marked with the [PunRPC](C#) or @PunRPC(JS) property! Args: ", this._Y);
			this.PLBEJJIHFPB().SetFloat("_Value2", this._U);
			this.PLBEJJIHFPB().SetFloat("ConnectToRegion: ", this._V);
			this.PLBEJJIHFPB().SetVector("#no", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 914f, 1867f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060021A9 RID: 8617 RVA: 0x000C1851 File Offset: 0x000BFA51
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060021AA RID: 8618 RVA: 0x000C1875 File Offset: 0x000BFA75
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060021AB RID: 8619 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x060021AC RID: 8620 RVA: 0x000C18AC File Offset: 0x000BFAAC
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060021AD RID: 8621 RVA: 0x000C18D0 File Offset: 0x000BFAD0
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("DestroyPlayerObjects() failed, cause players can only destroy their own GameObjects. A Master Client can destroy anyone's. This is master: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060021AE RID: 8622 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x060021AF RID: 8623 RVA: 0x000C18F4 File Offset: 0x000BFAF4
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
			this.NBPKMLMCHFN.SetFloat("_Y", this._Y);
			this.NBPKMLMCHFN.SetFloat("_U", this._U);
			this.NBPKMLMCHFN.SetFloat("_V", this._V);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060021B0 RID: 8624 RVA: 0x000C10A5 File Offset: 0x000BF2A5
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060021B1 RID: 8625 RVA: 0x000C19DD File Offset: 0x000BFBDD
	private void JECMJNFGBGC()
	{
		this.SCShader = Shader.Find("error");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060021B2 RID: 8626 RVA: 0x000C1A01 File Offset: 0x000BFC01
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060021B3 RID: 8627 RVA: 0x000C1A38 File Offset: 0x000BFC38
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1571f)
			{
				this.HBJJOCHGOPH = 1156f;
			}
			this.HHIFMIPPMPF().SetFloat(" has ", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("SSAARenderTargetCamera", this._Y);
			this.HHIFMIPPMPF().SetFloat("Editor/", this._U);
			this.IIJMIPBMMBF().SetFloat("OxOD.lastPath", this._V);
			this.PLBEJJIHFPB().SetVector("#turnoninternet", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 496f, 483f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060021B4 RID: 8628 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x060021B5 RID: 8629 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x060021B6 RID: 8630 RVA: 0x000C1B24 File Offset: 0x000BFD24
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 18f)
			{
				this.HBJJOCHGOPH = 491f;
			}
			this.GJHLADDCMFF().SetFloat("_TileTexDebug", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("_Value5", this._Y);
			this.ABHDNGIHBKE().SetFloat(". Check if the server is available.", this._U);
			this.NLFJGMBCICG().SetFloat("Bad parameters for delete! Use <key>", this._V);
			this.CEKJODEAMGB().SetVector("GameVolumeSlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 434f, 1324f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060021B7 RID: 8631 RVA: 0x000C1C10 File Offset: 0x000BFE10
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 401f)
			{
				this.HBJJOCHGOPH = 1547f;
			}
			this.LNLKMDPHDCC().SetFloat("mapselector.filter.subscribedonly", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("#getrewardfailed: ", this._Y);
			this.NLFJGMBCICG().SetFloat("SetSunMinSize", this._U);
			this.KGOLDDBHIFN().SetFloat("Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", this._V);
			this.CEKJODEAMGB().SetVector("#pleasewait", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1348f, 1616f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060021B8 RID: 8632 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJHFOBHJEHL()
	{
	}

	// Token: 0x060021B9 RID: 8633 RVA: 0x000C1CF9 File Offset: 0x000BFEF9
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)73;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060021BB RID: 8635 RVA: 0x000C1D44 File Offset: 0x000BFF44
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1503f)
			{
				this.HBJJOCHGOPH = 1881f;
			}
			this.PLBEJJIHFPB().SetFloat("z", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("float,40", this._Y);
			this.NBPKMLMCHFN.SetFloat("DPADVER", this._U);
			this.PDEAHJPOMEF().SetFloat("UseFinalGlassColor", this._V);
			this.OCHJIMJNEMO().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 361f, 532f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060021BC RID: 8636 RVA: 0x000C10A5 File Offset: 0x000BF2A5
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060021BD RID: 8637 RVA: 0x000C10A5 File Offset: 0x000BF2A5
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060021BE RID: 8638 RVA: 0x000C1E2D File Offset: 0x000C002D
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060021BF RID: 8639 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x060021C0 RID: 8640 RVA: 0x000C1E64 File Offset: 0x000C0064
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060021C1 RID: 8641 RVA: 0x000C1E9B File Offset: 0x000C009B
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060021C2 RID: 8642 RVA: 0x000C1ED4 File Offset: 0x000C00D4
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 782f)
			{
				this.HBJJOCHGOPH = 1949f;
			}
			this.LDNADDJMIPK().SetFloat("GetGameList failed: ", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("player.bat", this._Y);
			this.PDEAHJPOMEF().SetFloat("sounds/hit_perfect", this._U);
			this.BLMPMOIDGMG().SetFloat("_FresnelFadePower", this._V);
			this.LNLKMDPHDCC().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 903f, 63f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060021C3 RID: 8643 RVA: 0x000C1FBD File Offset: 0x000C01BD
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("MenuScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060021C4 RID: 8644 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x060021C5 RID: 8645 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x060021C6 RID: 8646 RVA: 0x000C1FE1 File Offset: 0x000C01E1
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("LoadingStatusText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060021C7 RID: 8647 RVA: 0x000C2005 File Offset: 0x000C0205
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060021C8 RID: 8648 RVA: 0x000C203C File Offset: 0x000C023C
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1296f)
			{
				this.HBJJOCHGOPH = 331f;
			}
			this.BLMPMOIDGMG().SetFloat("[PlayerBase] Saveing checkpoint data", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat(".b", this._Y);
			this.EHDJJANLINB().SetFloat("AudioSampler", this._U);
			this.BLMPMOIDGMG().SetFloat("[PlayerController] ", this._V);
			this.NLFJGMBCICG().SetVector("ConfigVersionSlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1739f, 1581f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060021C9 RID: 8649 RVA: 0x000C2128 File Offset: 0x000C0328
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 754f)
			{
				this.HBJJOCHGOPH = 1584f;
			}
			this.PLBEJJIHFPB().SetFloat("CorrectHitsScoreText", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("GameScene", this._Y);
			this.ABHDNGIHBKE().SetFloat("checkpoint", this._U);
			this.ABHDNGIHBKE().SetFloat("CameraFilterPack/Color_GrayScale", this._V);
			this.LDNADDJMIPK().SetVector("isVisible", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1976f, 1021f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060021CA RID: 8650 RVA: 0x000C2211 File Offset: 0x000C0411
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060021CB RID: 8651 RVA: 0x000C156B File Offset: 0x000BF76B
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060021CC RID: 8652 RVA: 0x000C1547 File Offset: 0x000BF747
	private void MJEFMIPLFAB()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060021CD RID: 8653 RVA: 0x000C2248 File Offset: 0x000C0448
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("Player Disconnected");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060021CE RID: 8654 RVA: 0x000C226C File Offset: 0x000C046C
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("SetParticlesInput");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060021CF RID: 8655 RVA: 0x000C2290 File Offset: 0x000C0490
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find("ScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060021D0 RID: 8656 RVA: 0x000C22B4 File Offset: 0x000C04B4
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1458f)
			{
				this.HBJJOCHGOPH = 1601f;
			}
			this.NLFJGMBCICG().SetFloat("_Red_G", this.HBJJOCHGOPH);
			this.BLMPMOIDGMG().SetFloat("_Value3", this._Y);
			this.IIJMIPBMMBF().SetFloat("_Value2", this._U);
			this.EHDJJANLINB().SetFloat("_TimeX", this._V);
			this.KGOLDDBHIFN().SetVector("_ChangeRed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 338f, 136f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060021D1 RID: 8657 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x060021D2 RID: 8658 RVA: 0x000C23A0 File Offset: 0x000C05A0
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1060f)
			{
				this.HBJJOCHGOPH = 1200f;
			}
			this.KGOLDDBHIFN().SetFloat("Data/Editor/leveltemplate", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("UI Extensions/UIScreen", this._Y);
			this.NBPKMLMCHFN.SetFloat("ResetButton", this._U);
			this.PDEAHJPOMEF().SetFloat("_UserLutTex", this._V);
			this.NLFJGMBCICG().SetVector("USE_UV_BASED_REPROJECTION", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 743f, 371f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060021D3 RID: 8659 RVA: 0x000C2489 File Offset: 0x000C0689
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)108;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060021D4 RID: 8660 RVA: 0x000C24C0 File Offset: 0x000C06C0
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060021D5 RID: 8661 RVA: 0x000C24F7 File Offset: 0x000C06F7
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("visible");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060021D6 RID: 8662 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x04000447 RID: 1095
	public Shader SCShader;

	// Token: 0x04000448 RID: 1096
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000449 RID: 1097
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400044A RID: 1098
	private Material BJFKDHHMLJH;

	// Token: 0x0400044B RID: 1099
	[Range(-1f, 1f)]
	public float _Y;

	// Token: 0x0400044C RID: 1100
	[Range(-1f, 1f)]
	public float _U;

	// Token: 0x0400044D RID: 1101
	[Range(-1f, 1f)]
	public float _V;
}
