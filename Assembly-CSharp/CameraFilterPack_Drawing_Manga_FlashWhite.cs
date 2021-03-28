using System;
using UnityEngine;

// Token: 0x020000A5 RID: 165
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Drawing/Manga_FlashWhite")]
public class CameraFilterPack_Drawing_Manga_FlashWhite : MonoBehaviour
{
	// Token: 0x0600318B RID: 12683 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x0600318C RID: 12684 RVA: 0x00105A38 File Offset: 0x00103C38
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600318D RID: 12685 RVA: 0x00105A6F File Offset: 0x00103C6F
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("Player Disconnected");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600318F RID: 12687 RVA: 0x00105AE5 File Offset: 0x00103CE5
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003190 RID: 12688 RVA: 0x00105B1C File Offset: 0x00103D1C
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 980f)
			{
				this.HBJJOCHGOPH = 1731f;
			}
			this.FLOHGDECHHH().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("Chat", this.Size);
			this.HKGAONMOBMH().SetFloat("_Distortion", (float)this.Speed);
			this.BFGNMFCNDBC().SetFloat("_FixDistance", this.PosX);
			this.FHFLKLMFHOI().SetFloat("EnableRankedNotificationsToggle", this.PosY);
			this.MMOODGIODPC().SetFloat("No info", this.Intensity);
			this.FLOHGDECHHH().SetVector("menu.relaxinfo", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1086f, 606f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003191 RID: 12689 RVA: 0x00105C32 File Offset: 0x00103E32
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003192 RID: 12690 RVA: 0x00105C69 File Offset: 0x00103E69
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("Horizontal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003193 RID: 12691 RVA: 0x00105C8D File Offset: 0x00103E8D
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-122);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003194 RID: 12692 RVA: 0x00105CC4 File Offset: 0x00103EC4
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("HandsCountSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003195 RID: 12693 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003196 RID: 12694 RVA: 0x00105CE8 File Offset: 0x00103EE8
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003197 RID: 12695 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06003198 RID: 12696 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x06003199 RID: 12697 RVA: 0x00105CE8 File Offset: 0x00103EE8
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600319A RID: 12698 RVA: 0x00105CE8 File Offset: 0x00103EE8
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600319B RID: 12699 RVA: 0x00105D05 File Offset: 0x00103F05
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("_Value5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600319C RID: 12700 RVA: 0x00105CE8 File Offset: 0x00103EE8
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600319D RID: 12701 RVA: 0x00105D29 File Offset: 0x00103F29
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("visible");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600319E RID: 12702 RVA: 0x00105D4D File Offset: 0x00103F4D
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600319F RID: 12703 RVA: 0x00105CE8 File Offset: 0x00103EE8
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060031A0 RID: 12704 RVA: 0x00105D84 File Offset: 0x00103F84
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_Manga_FlashWhite");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060031A1 RID: 12705 RVA: 0x00105DA8 File Offset: 0x00103FA8
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060031A2 RID: 12706 RVA: 0x00105CE8 File Offset: 0x00103EE8
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060031A3 RID: 12707 RVA: 0x00105DDF File Offset: 0x00103FDF
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find(".lastCheckpoint.bgcolor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060031A4 RID: 12708 RVA: 0x00105CE8 File Offset: 0x00103EE8
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060031A5 RID: 12709 RVA: 0x00105E03 File Offset: 0x00104003
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060031A6 RID: 12710 RVA: 0x00105CE8 File Offset: 0x00103EE8
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060031A7 RID: 12711 RVA: 0x00105CE8 File Offset: 0x00103EE8
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060031A8 RID: 12712 RVA: 0x00105CE8 File Offset: 0x00103EE8
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060031A9 RID: 12713 RVA: 0x00105E3C File Offset: 0x0010403C
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 234f)
			{
				this.HBJJOCHGOPH = 1981f;
			}
			this.ACHNOHCLGOO().SetFloat("_Radius", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat(".completed", this.Size);
			this.HKGAONMOBMH().SetFloat("PunSupportLogger", (float)this.Speed);
			this.PGPEMMBJOOG().SetFloat("_Value2", this.PosX);
			this.PGPEMMBJOOG().SetFloat("_Value", this.PosY);
			this.BFGNMFCNDBC().SetFloat(".lastCheckpoint.lives", this.Intensity);
			this.LDNADDJMIPK().SetVector("LevelEditor/icons", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 482f, 1179f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060031AA RID: 12714 RVA: 0x00105F52 File Offset: 0x00104152
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)88;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060031AB RID: 12715 RVA: 0x00105F8C File Offset: 0x0010418C
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1165f)
			{
				this.HBJJOCHGOPH = 1718f;
			}
			this.HHIFMIPPMPF().SetFloat("finished", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("checkpoint", this.Size);
			this.MMOODGIODPC().SetFloat("_ScreenResolution", (float)this.Speed);
			this.MMOODGIODPC().SetFloat(" x ", this.PosX);
			this.FLOHGDECHHH().SetFloat("Editor", this.PosY);
			this.BFGNMFCNDBC().SetFloat("inventory.selected.", this.Intensity);
			this.FHFLKLMFHOI().SetVector("_Red_C", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1068f, 248f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060031AC RID: 12716 RVA: 0x001060A2 File Offset: 0x001042A2
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)114;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060031AD RID: 12717 RVA: 0x001060DC File Offset: 0x001042DC
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 410f)
			{
				this.HBJJOCHGOPH = 1793f;
			}
			this.KEMAALEODNH().SetFloat("_Axis", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("null", this.Size);
			this.HKGAONMOBMH().SetFloat("EventData0DropDownList", (float)this.Speed);
			this.ACHNOHCLGOO().SetFloat("In Network lobby", this.PosX);
			this.FLOHGDECHHH().SetFloat(":", this.PosY);
			this.HHIFMIPPMPF().SetFloat("PunRespawn", this.Intensity);
			this.NBPKMLMCHFN.SetVector("CameraFilterPack/Distortion_Half_Sphere", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 197f, 132f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060031AE RID: 12718 RVA: 0x001061F4 File Offset: 0x001043F4
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 79f)
			{
				this.HBJJOCHGOPH = 1845f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value3", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("player.bluelifering", this.Size);
			this.FLOHGDECHHH().SetFloat("--------------------------------", (float)this.Speed);
			this.MMOODGIODPC().SetFloat("The given 2D texture ", this.PosX);
			this.PGPEMMBJOOG().SetFloat("Crosshair1", this.PosY);
			this.FLOHGDECHHH().SetFloat("_FilteredReflections", this.Intensity);
			this.KEMAALEODNH().SetVector("OK", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 488f, 1210f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060031AF RID: 12719 RVA: 0x0010630A File Offset: 0x0010450A
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060031B0 RID: 12720 RVA: 0x00106330 File Offset: 0x00104530
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1238f)
			{
				this.HBJJOCHGOPH = 1687f;
			}
			this.MMOODGIODPC().SetFloat("_ExposureAdjustment", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("CameraFilterPack/Fly_Vision", this.Size);
			this.FLOHGDECHHH().SetFloat("_ToneCurveRange", (float)this.Speed);
			this.PGPEMMBJOOG().SetFloat("OpAuthenticate() failed. When you want Custom Authentication encryption is mandatory.", this.PosX);
			this.FLOHGDECHHH().SetFloat("_Value3", this.PosY);
			this.HKGAONMOBMH().SetFloat("Anomaly_Distortion_Size", this.Intensity);
			this.LDNADDJMIPK().SetVector("Hidden/ScreenSpaceReflection", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 226f, 1897f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060031B1 RID: 12721 RVA: 0x00105CE8 File Offset: 0x00103EE8
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060031B2 RID: 12722 RVA: 0x00106448 File Offset: 0x00104648
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1462f)
			{
				this.HBJJOCHGOPH = 521f;
			}
			this.AELJLBOJAIL().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat("SpawnObj", this.Size);
			this.HKGAONMOBMH().SetFloat("My New Mod Pack", (float)this.Speed);
			this.LONNIJMNKFB().SetFloat("]", this.PosX);
			this.LDNADDJMIPK().SetFloat(" key(s)", this.PosY);
			this.NBPKMLMCHFN.SetFloat("https://steamcommunity.com/app/513510/workshop/", this.Intensity);
			this.NBPKMLMCHFN.SetVector("y", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1123f, 1566f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060031B3 RID: 12723 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x060031B4 RID: 12724 RVA: 0x00105CE8 File Offset: 0x00103EE8
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060031B5 RID: 12725 RVA: 0x0010655E File Offset: 0x0010475E
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060031B6 RID: 12726 RVA: 0x00106595 File Offset: 0x00104795
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060031B7 RID: 12727 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x1700008A RID: 138
	// (get) Token: 0x060031B8 RID: 12728 RVA: 0x001065B9 File Offset: 0x001047B9
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

	// Token: 0x060031B9 RID: 12729 RVA: 0x001065F0 File Offset: 0x001047F0
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("achievements.21.progress");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060031BA RID: 12730 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x060031BB RID: 12731 RVA: 0x00106614 File Offset: 0x00104814
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060031BC RID: 12732 RVA: 0x0010664B File Offset: 0x0010484B
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060031BD RID: 12733 RVA: 0x00106682 File Offset: 0x00104882
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060031BE RID: 12734 RVA: 0x001066BC File Offset: 0x001048BC
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Value2", (float)this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.PosX);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.PosY);
			this.NBPKMLMCHFN.SetFloat("_Intensity", this.Intensity);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060031BF RID: 12735 RVA: 0x001067D2 File Offset: 0x001049D2
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060031C0 RID: 12736 RVA: 0x00106809 File Offset: 0x00104A09
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("seconds");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060031C1 RID: 12737 RVA: 0x00105CE8 File Offset: 0x00103EE8
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060031C2 RID: 12738 RVA: 0x00106830 File Offset: 0x00104A30
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 587f)
			{
				this.HBJJOCHGOPH = 264f;
			}
			this.AELJLBOJAIL().SetFloat("3", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat("CameraFilterPack/Edge_Edge_filter", this.Size);
			this.LONNIJMNKFB().SetFloat("_Near", (float)this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.PosX);
			this.HKGAONMOBMH().SetFloat("Fill", this.PosY);
			this.AELJLBOJAIL().SetFloat("_DotSize", this.Intensity);
			this.NBPKMLMCHFN.SetVector("JoinRoom failed. A roomname is required. If you don't know one, how will you join?", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1091f, 179f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x040005A4 RID: 1444
	public Shader SCShader;

	// Token: 0x040005A5 RID: 1445
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040005A6 RID: 1446
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040005A7 RID: 1447
	private Material BJFKDHHMLJH;

	// Token: 0x040005A8 RID: 1448
	[Range(1f, 10f)]
	public float Size = 1f;

	// Token: 0x040005A9 RID: 1449
	[Range(0f, 30f)]
	public int Speed = 5;

	// Token: 0x040005AA RID: 1450
	[Range(-1f, 1f)]
	public float PosX = 0.5f;

	// Token: 0x040005AB RID: 1451
	[Range(-1f, 1f)]
	public float PosY = 0.5f;

	// Token: 0x040005AC RID: 1452
	[Range(0f, 1f)]
	public float Intensity = 1f;
}
