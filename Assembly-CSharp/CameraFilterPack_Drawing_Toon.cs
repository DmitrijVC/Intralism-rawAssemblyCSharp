using System;
using UnityEngine;

// Token: 0x020000AE RID: 174
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Drawing/Toon")]
public class CameraFilterPack_Drawing_Toon : MonoBehaviour
{
	// Token: 0x060034F9 RID: 13561 RVA: 0x001138F5 File Offset: 0x00111AF5
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060034FA RID: 13562 RVA: 0x0011392C File Offset: 0x00111B2C
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 220f)
			{
				this.HBJJOCHGOPH = 901f;
			}
			this.FEAEGGCNIAA().SetFloat("DPADHOR", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("Joystick1Button2", this.Threshold);
			this.CFEDGDGBCHE().SetFloat(" not exist", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060034FB RID: 13563 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x060034FC RID: 13564 RVA: 0x001139D2 File Offset: 0x00111BD2
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060034FD RID: 13565 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x060034FE RID: 13566 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x060034FF RID: 13567 RVA: 0x001139EF File Offset: 0x00111BEF
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003500 RID: 13568 RVA: 0x001139D2 File Offset: 0x00111BD2
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003501 RID: 13569 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003502 RID: 13570 RVA: 0x00113A26 File Offset: 0x00111C26
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("Adreno");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003503 RID: 13571 RVA: 0x001139D2 File Offset: 0x00111BD2
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003504 RID: 13572 RVA: 0x001139D2 File Offset: 0x00111BD2
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003505 RID: 13573 RVA: 0x00113A4A File Offset: 0x00111C4A
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("[MapEditor] Updating top menu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003506 RID: 13574 RVA: 0x00113A6E File Offset: 0x00111C6E
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("CameraFilterPack_3D_Myst1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003507 RID: 13575 RVA: 0x001139D2 File Offset: 0x00111BD2
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003508 RID: 13576 RVA: 0x00113A92 File Offset: 0x00111C92
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_Toon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003509 RID: 13577 RVA: 0x00113AB6 File Offset: 0x00111CB6
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600350A RID: 13578 RVA: 0x00113ADA File Offset: 0x00111CDA
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600350B RID: 13579 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x0600350C RID: 13580 RVA: 0x00113B11 File Offset: 0x00111D11
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("R2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600350D RID: 13581 RVA: 0x00113B38 File Offset: 0x00111D38
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 327f)
			{
				this.HBJJOCHGOPH = 1347f;
			}
			this.IIJMIPBMMBF().SetFloat("#scoresubmitionfailed: ", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Rock", this.Threshold);
			this.CFEDGDGBCHE().SetFloat("]. Please verify you have this gameobject in a Resources folder.", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600350E RID: 13582 RVA: 0x00113BE0 File Offset: 0x00111DE0
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1951f)
			{
				this.HBJJOCHGOPH = 1511f;
			}
			this.DBOLLHHMKKN().SetFloat("settings.enablehitsoundsinrelax", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat(":", this.Threshold);
			this.FEAEGGCNIAA().SetFloat("#forever", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600350F RID: 13583 RVA: 0x00113C88 File Offset: 0x00111E88
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 970f)
			{
				this.HBJJOCHGOPH = 754f;
			}
			this.CFEDGDGBCHE().SetFloat("[PlayerBase] Got checkpoint at ", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("PlayMapGoal", this.Threshold);
			this.KAFBNOBOIAJ().SetFloat("offsets", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003510 RID: 13584 RVA: 0x00113D30 File Offset: 0x00111F30
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1343f)
			{
				this.HBJJOCHGOPH = 1240f;
			}
			this.CFEDGDGBCHE().SetFloat("Screen Space Reflections", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value", this.Threshold);
			this.EMDFHOKEGNG().SetFloat("_TimeX", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003511 RID: 13585 RVA: 0x00113DD8 File Offset: 0x00111FD8
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 748f)
			{
				this.HBJJOCHGOPH = 901f;
			}
			this.EOCCJGIGEGJ().SetFloat("Received RPC \"", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("Right ", this.Threshold);
			this.FEAEGGCNIAA().SetFloat("player.blackcat", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003512 RID: 13586 RVA: 0x00113E80 File Offset: 0x00112080
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 478f)
			{
				this.HBJJOCHGOPH = 96f;
			}
			this.EOCCJGIGEGJ().SetFloat("inventory.itemscash", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("F3", this.Threshold);
			this.EJDPNJAEAKJ().SetFloat("ItemsStoreButton", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003513 RID: 13587 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06003514 RID: 13588 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06003516 RID: 13590 RVA: 0x00113F4F File Offset: 0x0011214F
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("Texture2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003517 RID: 13591 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06003518 RID: 13592 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06003519 RID: 13593 RVA: 0x00113F73 File Offset: 0x00112173
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600351A RID: 13594 RVA: 0x00113FAA File Offset: 0x001121AA
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("_Green_G");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600351B RID: 13595 RVA: 0x00113FD0 File Offset: 0x001121D0
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
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Threshold);
			this.NBPKMLMCHFN.SetFloat("_DotSize", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600351C RID: 13596 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x0600351D RID: 13597 RVA: 0x001139D2 File Offset: 0x00111BD2
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600351E RID: 13598 RVA: 0x00114076 File Offset: 0x00112276
	private void FLKEJJEGCFA()
	{
		this.SCShader = Shader.Find("SpectateButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x17000093 RID: 147
	// (get) Token: 0x0600351F RID: 13599 RVA: 0x0011409A File Offset: 0x0011229A
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

	// Token: 0x06003520 RID: 13600 RVA: 0x001140D1 File Offset: 0x001122D1
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003521 RID: 13601 RVA: 0x00114108 File Offset: 0x00112308
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003522 RID: 13602 RVA: 0x001139D2 File Offset: 0x00111BD2
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003523 RID: 13603 RVA: 0x0011412C File Offset: 0x0011232C
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003524 RID: 13604 RVA: 0x00114163 File Offset: 0x00112363
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003525 RID: 13605 RVA: 0x0011419C File Offset: 0x0011239C
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1859f)
			{
				this.HBJJOCHGOPH = 1819f;
			}
			this.EMDFHOKEGNG().SetFloat("_FixDistance", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("float,0", this.Threshold);
			this.EMDFHOKEGNG().SetFloat("bad", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003526 RID: 13606 RVA: 0x00114244 File Offset: 0x00112444
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 425f)
			{
				this.HBJJOCHGOPH = 1952f;
			}
			this.KAFBNOBOIAJ().SetFloat("DifficultyBG", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("_ToneCurve", this.Threshold);
			this.DBOLLHHMKKN().SetFloat("\" that takes ", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003527 RID: 13607 RVA: 0x001142EA File Offset: 0x001124EA
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003528 RID: 13608 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x06003529 RID: 13609 RVA: 0x00114310 File Offset: 0x00112510
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1709f)
			{
				this.HBJJOCHGOPH = 204f;
			}
			this.ADBKPGFMNKO().SetFloat(". Using max value: 255.", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("Error: I/O Failure", this.Threshold);
			this.NBPKMLMCHFN.SetFloat("CrosshairOpacitySlider", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600352A RID: 13610 RVA: 0x001143B6 File Offset: 0x001125B6
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600352B RID: 13611 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x0600352C RID: 13612 RVA: 0x001139D2 File Offset: 0x00111BD2
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600352D RID: 13613 RVA: 0x001139D2 File Offset: 0x00111BD2
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600352E RID: 13614 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x0600352F RID: 13615 RVA: 0x001143F0 File Offset: 0x001125F0
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 334f)
			{
				this.HBJJOCHGOPH = 579f;
			}
			this.NBPKMLMCHFN.SetFloat("1", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("_BlurCoe", this.Threshold);
			this.ADBKPGFMNKO().SetFloat("SpawnObj", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003530 RID: 13616 RVA: 0x00114498 File Offset: 0x00112698
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 119f)
			{
				this.HBJJOCHGOPH = 889f;
			}
			this.EOCCJGIGEGJ().SetFloat("_Value", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("restrictions\n\n#until: ", this.Threshold);
			this.CFEDGDGBCHE().SetFloat("_Value", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003531 RID: 13617 RVA: 0x0011453E File Offset: 0x0011273E
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("ComboScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003532 RID: 13618 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x06003533 RID: 13619 RVA: 0x00114562 File Offset: 0x00112762
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find(" canvas not found");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003534 RID: 13620 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x06003535 RID: 13621 RVA: 0x001139D2 File Offset: 0x00111BD2
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003536 RID: 13622 RVA: 0x00114588 File Offset: 0x00112788
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1470f)
			{
				this.HBJJOCHGOPH = 770f;
			}
			this.DBOLLHHMKKN().SetFloat("Achievement 21 progress reseted", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("settings_bindings_sec_", this.Threshold);
			this.DBOLLHHMKKN().SetFloat("settings.hitvariation", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003537 RID: 13623 RVA: 0x001139D2 File Offset: 0x00111BD2
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003538 RID: 13624 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06003539 RID: 13625 RVA: 0x001139D2 File Offset: 0x00111BD2
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600353A RID: 13626 RVA: 0x00114630 File Offset: 0x00112830
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1280f)
			{
				this.HBJJOCHGOPH = 1550f;
			}
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("_DistortionSize", this.Threshold);
			this.CFEDGDGBCHE().SetFloat("0.00", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600353B RID: 13627 RVA: 0x001146D6 File Offset: 0x001128D6
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x040005E9 RID: 1513
	public Shader SCShader;

	// Token: 0x040005EA RID: 1514
	private Material BJFKDHHMLJH;

	// Token: 0x040005EB RID: 1515
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040005EC RID: 1516
	[Range(0f, 2f)]
	public float Threshold = 1f;

	// Token: 0x040005ED RID: 1517
	[Range(0f, 8f)]
	public float DotSize = 1f;
}
