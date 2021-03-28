using System;
using UnityEngine;

// Token: 0x020000A4 RID: 164
[AddComponentMenu("Camera Filter Pack/Drawing/Manga_Flash_Color")]
[ExecuteInEditMode]
public class CameraFilterPack_Drawing_Manga_Flash_Color : MonoBehaviour
{
	// Token: 0x0600312A RID: 12586 RVA: 0x0010370E File Offset: 0x0010190E
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600312B RID: 12587 RVA: 0x00103748 File Offset: 0x00101948
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1140f)
			{
				this.HBJJOCHGOPH = 1204f;
			}
			this.EPCGJFCCAFH().SetFloat("player.bluebat", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat("masterSteamID", this.Size);
			this.BFGNMFCNDBC().SetFloat("_ScreenResolution", (float)this.Speed);
			this.CEKJODEAMGB().SetFloat("Data/Editor/leveltemplate", this.PosX);
			this.KJMECMIGJJA().SetFloat(" not exist", this.PosY);
			this.IONHGBPGCHK().SetFloat("Joystick1Button6", this.Intensity);
			this.BFGNMFCNDBC().SetColor("&search=", this.Color);
			this.NDMPCDHADMJ().SetVector("EditMenu", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 21f, 1305f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600312C RID: 12588 RVA: 0x00103874 File Offset: 0x00101A74
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600312D RID: 12589 RVA: 0x00103898 File Offset: 0x00101A98
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600312E RID: 12590 RVA: 0x001038B5 File Offset: 0x00101AB5
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600312F RID: 12591 RVA: 0x001038EC File Offset: 0x00101AEC
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003130 RID: 12592 RVA: 0x00103910 File Offset: 0x00101B10
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003131 RID: 12593 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06003132 RID: 12594 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x06003133 RID: 12595 RVA: 0x00103948 File Offset: 0x00101B48
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1971f)
			{
				this.HBJJOCHGOPH = 1293f;
			}
			this.IONHGBPGCHK().SetFloat("subscribeall", this.HBJJOCHGOPH);
			this.CEKJODEAMGB().SetFloat("menu.selectedplaymode", this.Size);
			this.JLHLHKPHDFO().SetFloat("EnvironmentSlider", (float)this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.PosX);
			this.BFGNMFCNDBC().SetFloat("#yes", this.PosY);
			this.IGKFMCPDNOI().SetFloat("_HrDepthTex", this.Intensity);
			this.JLHLHKPHDFO().SetColor("_Offsets", this.Color);
			this.KJMECMIGJJA().SetVector("_VelocityTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 762f, 1614f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003134 RID: 12596 RVA: 0x00103898 File Offset: 0x00101A98
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003135 RID: 12597 RVA: 0x00103A74 File Offset: 0x00101C74
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("_Extra2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003136 RID: 12598 RVA: 0x00103A98 File Offset: 0x00101C98
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003137 RID: 12599 RVA: 0x00103898 File Offset: 0x00101A98
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003138 RID: 12600 RVA: 0x00103898 File Offset: 0x00101A98
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003139 RID: 12601 RVA: 0x00103AD0 File Offset: 0x00101CD0
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1208f)
			{
				this.HBJJOCHGOPH = 196f;
			}
			this.JLHLHKPHDFO().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("InputField", this.Size);
			this.EHDJJANLINB().SetFloat("\n", (float)this.Speed);
			this.EHDJJANLINB().SetFloat("EditMenu", this.PosX);
			this.JLHLHKPHDFO().SetFloat(" Remote called.", this.PosY);
			this.JLHLHKPHDFO().SetFloat("</i>", this.Intensity);
			this.JLHLHKPHDFO().SetColor(" Mb", this.Color);
			this.CEKJODEAMGB().SetVector(" has no method \"", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1388f, 651f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600313A RID: 12602 RVA: 0x00103BFC File Offset: 0x00101DFC
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("ComboText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600313B RID: 12603 RVA: 0x00103C20 File Offset: 0x00101E20
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600313C RID: 12604 RVA: 0x00103C44 File Offset: 0x00101E44
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Noise_TV");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600313D RID: 12605 RVA: 0x00103C68 File Offset: 0x00101E68
	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 897f)
			{
				this.HBJJOCHGOPH = 1129f;
			}
			this.IONHGBPGCHK().SetFloat("_Value5", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetFloat("_Value2", this.Size);
			this.IGKFMCPDNOI().SetFloat("skin.", (float)this.Speed);
			this.NDMPCDHADMJ().SetFloat("BloodAlternative2", this.PosX);
			this.CEKJODEAMGB().SetFloat("_ScreenResolution", this.PosY);
			this.EPCGJFCCAFH().SetFloat(" SphereWaveform.cs", this.Intensity);
			this.EPCGJFCCAFH().SetColor("player.xp", this.Color);
			this.CEKJODEAMGB().SetVector("_AdaptionSpeed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1701f, 1613f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000089 RID: 137
	// (get) Token: 0x0600313E RID: 12606 RVA: 0x00103D94 File Offset: 0x00101F94
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

	// Token: 0x0600313F RID: 12607 RVA: 0x00103DCC File Offset: 0x00101FCC
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
			this.NBPKMLMCHFN.SetColor("Color", this.Color);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003140 RID: 12608 RVA: 0x00103EF8 File Offset: 0x001020F8
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 594f)
			{
				this.HBJJOCHGOPH = 12f;
			}
			this.DBOLLHHMKKN().SetFloat("yes", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("CameraFilterPack/Blend2Camera_Lighten", this.Size);
			this.DBOLLHHMKKN().SetFloat("???", (float)this.Speed);
			this.EHDJJANLINB().SetFloat("_ScreenResolution", this.PosX);
			this.KJMECMIGJJA().SetFloat("_FadeFX", this.PosY);
			this.KJMECMIGJJA().SetFloat("_TimeX", this.Intensity);
			this.NLFJGMBCICG().SetColor("PossibleMapPointsText", this.Color);
			this.KOHGPKOFEJO().SetVector("bpmgrid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 574f, 1756f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003141 RID: 12609 RVA: 0x00104024 File Offset: 0x00102224
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("_FgOverlap");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003142 RID: 12610 RVA: 0x00103898 File Offset: 0x00101A98
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003143 RID: 12611 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06003144 RID: 12612 RVA: 0x00104048 File Offset: 0x00102248
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find("Default UI Material");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003145 RID: 12613 RVA: 0x00103898 File Offset: 0x00101A98
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003146 RID: 12614 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06003147 RID: 12615 RVA: 0x00103898 File Offset: 0x00101A98
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003148 RID: 12616 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06003149 RID: 12617 RVA: 0x00103898 File Offset: 0x00101A98
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600314A RID: 12618 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x0600314B RID: 12619 RVA: 0x0010406C File Offset: 0x0010226C
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 12f)
			{
				this.HBJJOCHGOPH = 1537f;
			}
			this.IGKFMCPDNOI().SetFloat(" key(s)", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("Joystick1Button7", this.Size);
			this.CEKJODEAMGB().SetFloat("HPText", (float)this.Speed);
			this.EPCGJFCCAFH().SetFloat(": ", this.PosX);
			this.CEKJODEAMGB().SetFloat(".lastCheckpoint.penaltyScore", this.PosY);
			this.EPCGJFCCAFH().SetFloat("_TimeX", this.Intensity);
			this.NLFJGMBCICG().SetColor("false", this.Color);
			this.BFGNMFCNDBC().SetVector("/icon", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1617f, 877f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600314C RID: 12620 RVA: 0x00104198 File Offset: 0x00102398
	private void FLKEJJEGCFA()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600314D RID: 12621 RVA: 0x001041BC File Offset: 0x001023BC
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1700f)
			{
				this.HBJJOCHGOPH = 631f;
			}
			this.KOHGPKOFEJO().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetFloat("Uploader", this.Size);
			this.CEKJODEAMGB().SetFloat("_TexelOffsetScale", (float)this.Speed);
			this.JLHLHKPHDFO().SetFloat("_Intensity", this.PosX);
			this.NDMPCDHADMJ().SetFloat("_MainTex2", this.PosY);
			this.IGKFMCPDNOI().SetFloat("Cannot remove cached RPCs on a PhotonView thats not ours! ", this.Intensity);
			this.NLFJGMBCICG().SetColor("Tab2Content", this.Color);
			this.IGKFMCPDNOI().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 170f, 557f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600314E RID: 12622 RVA: 0x00103898 File Offset: 0x00101A98
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600314F RID: 12623 RVA: 0x001042E8 File Offset: 0x001024E8
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1277f)
			{
				this.HBJJOCHGOPH = 278f;
			}
			this.IGKFMCPDNOI().SetFloat("on master", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetFloat("player.goldabstract", this.Size);
			this.IONHGBPGCHK().SetFloat("player.deleted", (float)this.Speed);
			this.FHFLKLMFHOI().SetFloat("BitsData", this.PosX);
			this.FHFLKLMFHOI().SetFloat("CameraFilterPack/Atmosphere_Rain", this.PosY);
			this.FHFLKLMFHOI().SetFloat("EventSystem", this.Intensity);
			this.IGKFMCPDNOI().SetColor("Edited unlock conditions", this.Color);
			this.IONHGBPGCHK().SetVector("EventMenu", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1208f, 819f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003150 RID: 12624 RVA: 0x00104414 File Offset: 0x00102614
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1089f)
			{
				this.HBJJOCHGOPH = 332f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value4", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("config.txt", this.Size);
			this.CEKJODEAMGB().SetFloat("_Linecount", (float)this.Speed);
			this.NBPKMLMCHFN.SetFloat(".", this.PosX);
			this.IGKFMCPDNOI().SetFloat(": ", this.PosY);
			this.BFGNMFCNDBC().SetFloat("_ScreenResolution", this.Intensity);
			this.KJMECMIGJJA().SetColor("Items/", this.Color);
			this.DBOLLHHMKKN().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 527f, 128f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003151 RID: 12625 RVA: 0x00104540 File Offset: 0x00102740
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)76;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003152 RID: 12626 RVA: 0x00103898 File Offset: 0x00101A98
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003153 RID: 12627 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x06003154 RID: 12628 RVA: 0x00104577 File Offset: 0x00102777
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003155 RID: 12629 RVA: 0x001045B0 File Offset: 0x001027B0
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1797f)
			{
				this.HBJJOCHGOPH = 1390f;
			}
			this.NDMPCDHADMJ().SetFloat("ViewMenu", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("workshop.", this.Size);
			this.EHDJJANLINB().SetFloat("maps.", (float)this.Speed);
			this.IGKFMCPDNOI().SetFloat("_NoiseTex", this.PosX);
			this.IGKFMCPDNOI().SetFloat("The process failed: ", this.PosY);
			this.CEKJODEAMGB().SetFloat("menu.selectedplaymode", this.Intensity);
			this.EHDJJANLINB().SetColor("_Heigh", this.Color);
			this.NLFJGMBCICG().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 355f, 1180f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003156 RID: 12630 RVA: 0x001046DC File Offset: 0x001028DC
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_Manga_Flash_Color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003157 RID: 12631 RVA: 0x00104700 File Offset: 0x00102900
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 831f)
			{
				this.HBJJOCHGOPH = 1901f;
			}
			this.JLHLHKPHDFO().SetFloat(".GoalProgress", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat(" not exist", this.Size);
			this.FHFLKLMFHOI().SetFloat("settings_bindings_", (float)this.Speed);
			this.NBPKMLMCHFN.SetFloat("start", this.PosX);
			this.NLFJGMBCICG().SetFloat(" not exist", this.PosY);
			this.IGKFMCPDNOI().SetFloat("HH:mm:ss", this.Intensity);
			this.KJMECMIGJJA().SetColor("PUNCloudBestRegion", this.Color);
			this.NLFJGMBCICG().SetVector("Fade", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 170f, 1228f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003158 RID: 12632 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06003159 RID: 12633 RVA: 0x0010482C File Offset: 0x00102A2C
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600315A RID: 12634 RVA: 0x00104864 File Offset: 0x00102A64
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 760f)
			{
				this.HBJJOCHGOPH = 439f;
			}
			this.KJMECMIGJJA().SetFloat("PhotonView with ID {0} wasn't properly unregistered! Please report this case to developer@photonengine.com", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("/Segment-[Right]", this.Size);
			this.NBPKMLMCHFN.SetFloat("_InternalLutParams", (float)this.Speed);
			this.CEKJODEAMGB().SetFloat("_TimeX", this.PosX);
			this.BFGNMFCNDBC().SetFloat("GameScene", this.PosY);
			this.IGKFMCPDNOI().SetFloat("_PColor", this.Intensity);
			this.NDMPCDHADMJ().SetColor("Mar", this.Color);
			this.NBPKMLMCHFN.SetVector("Horizontal", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1762f, 1795f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600315B RID: 12635 RVA: 0x00103898 File Offset: 0x00101A98
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600315C RID: 12636 RVA: 0x00104990 File Offset: 0x00102B90
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_Rgb");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600315D RID: 12637 RVA: 0x00103898 File Offset: 0x00101A98
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600315E RID: 12638 RVA: 0x001049B4 File Offset: 0x00102BB4
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1182f)
			{
				this.HBJJOCHGOPH = 458f;
			}
			this.IGKFMCPDNOI().SetFloat("_Blend", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("[MapsData] Preloading ", this.Size);
			this.NBPKMLMCHFN.SetFloat(" cannot be used as a 3D LUT.", (float)this.Speed);
			this.EPCGJFCCAFH().SetFloat("_SearchTex", this.PosX);
			this.NLFJGMBCICG().SetFloat("_Value7", this.PosY);
			this.DBOLLHHMKKN().SetFloat("SfxVolumeSlider", this.Intensity);
			this.NDMPCDHADMJ().SetColor("restrictions\n\n#until: ", this.Color);
			this.IONHGBPGCHK().SetVector("bool", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1687f, 783f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600315F RID: 12639 RVA: 0x00104AE0 File Offset: 0x00102CE0
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003160 RID: 12640 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOLDLDLFFLM()
	{
	}

	// Token: 0x06003161 RID: 12641 RVA: 0x00103898 File Offset: 0x00101A98
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003162 RID: 12642 RVA: 0x00104B17 File Offset: 0x00102D17
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003163 RID: 12643 RVA: 0x00103898 File Offset: 0x00101A98
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003164 RID: 12644 RVA: 0x00104B50 File Offset: 0x00102D50
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1887f)
			{
				this.HBJJOCHGOPH = 1540f;
			}
			this.FHFLKLMFHOI().SetFloat("checkpoint", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat("-1", this.Size);
			this.NDMPCDHADMJ().SetFloat("_BlurredColor", (float)this.Speed);
			this.NDMPCDHADMJ().SetFloat("_DotSize", this.PosX);
			this.EPCGJFCCAFH().SetFloat("SetScale", this.PosY);
			this.EHDJJANLINB().SetFloat("_Value", this.Intensity);
			this.BFGNMFCNDBC().SetColor("]", this.Color);
			this.EPCGJFCCAFH().SetVector("_MainTex2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1925f, 1888f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003165 RID: 12645 RVA: 0x00104C7C File Offset: 0x00102E7C
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1521f)
			{
				this.HBJJOCHGOPH = 956f;
			}
			this.BFGNMFCNDBC().SetFloat("DifficultyBG", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("_Brightness", this.Size);
			this.IONHGBPGCHK().SetFloat("mapselector.orderby", (float)this.Speed);
			this.BFGNMFCNDBC().SetFloat("_SunThreshold", this.PosX);
			this.DBOLLHHMKKN().SetFloat("_TimeX", this.PosY);
			this.NLFJGMBCICG().SetFloat("#lives", this.Intensity);
			this.FHFLKLMFHOI().SetColor("_Blend", this.Color);
			this.NDMPCDHADMJ().SetVector("sprite", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1212f, 892f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003166 RID: 12646 RVA: 0x00103898 File Offset: 0x00101A98
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003167 RID: 12647 RVA: 0x00104DA8 File Offset: 0x00102FA8
	private void OKLAJINHPAN()
	{
		this.SCShader = Shader.Find("StartCanvas");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003168 RID: 12648 RVA: 0x00104DCC File Offset: 0x00102FCC
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1855f)
			{
				this.HBJJOCHGOPH = 650f;
			}
			this.CEKJODEAMGB().SetFloat("id", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("--------------------------------", this.Size);
			this.NLFJGMBCICG().SetFloat("_Near", (float)this.Speed);
			this.NBPKMLMCHFN.SetFloat("challenges/", this.PosX);
			this.DBOLLHHMKKN().SetFloat("_Speed", this.PosY);
			this.DBOLLHHMKKN().SetFloat("Joystick1Button10", this.Intensity);
			this.DBOLLHHMKKN().SetColor("/icon", this.Color);
			this.KOHGPKOFEJO().SetVector("GridDataStoryboard", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 391f, 1698f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003169 RID: 12649 RVA: 0x00103898 File Offset: 0x00101A98
	private void AMHEJBMLFNM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600316A RID: 12650 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x0600316B RID: 12651 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x0600316C RID: 12652 RVA: 0x00103898 File Offset: 0x00101A98
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600316D RID: 12653 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x0600316E RID: 12654 RVA: 0x00104EF8 File Offset: 0x001030F8
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)67;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600316F RID: 12655 RVA: 0x00104F30 File Offset: 0x00103130
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1590f)
			{
				this.HBJJOCHGOPH = 98f;
			}
			this.IONHGBPGCHK().SetFloat("_Screen", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("_ColorBuffer", this.Size);
			this.KOHGPKOFEJO().SetFloat("JoinRoom failed. A roomname is required. If you don't know one, how will you join?", (float)this.Speed);
			this.EHDJJANLINB().SetFloat("CameraFilterPack_AAA_BloodOnScreen1", this.PosX);
			this.NBPKMLMCHFN.SetFloat("float,0", this.PosY);
			this.JLHLHKPHDFO().SetFloat("maps.", this.Intensity);
			this.FHFLKLMFHOI().SetColor("OnPressRight", this.Color);
			this.NBPKMLMCHFN.SetVector("CameraFilterPack/Edge_Sigmoid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 599f, 1579f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003170 RID: 12656 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06003171 RID: 12657 RVA: 0x0010505C File Offset: 0x0010325C
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1025f)
			{
				this.HBJJOCHGOPH = 615f;
			}
			this.DBOLLHHMKKN().SetFloat("Right Stick Click", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Pixelisation_OilPaint", this.Size);
			this.NBPKMLMCHFN.SetFloat("Delete events", (float)this.Speed);
			this.EPCGJFCCAFH().SetFloat("GlassAberration", this.PosX);
			this.EPCGJFCCAFH().SetFloat("menu.relaxinfo", this.PosY);
			this.KOHGPKOFEJO().SetFloat("hidden", this.Intensity);
			this.FHFLKLMFHOI().SetColor("<color=#{0}>{1}</color>", this.Color);
			this.KOHGPKOFEJO().SetVector(" AuthMode ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1720f, 1343f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003172 RID: 12658 RVA: 0x00103898 File Offset: 0x00101A98
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003173 RID: 12659 RVA: 0x00103898 File Offset: 0x00101A98
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003174 RID: 12660 RVA: 0x00105188 File Offset: 0x00103388
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003175 RID: 12661 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06003176 RID: 12662 RVA: 0x001051C0 File Offset: 0x001033C0
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 742f)
			{
				this.HBJJOCHGOPH = 1446f;
			}
			this.NDMPCDHADMJ().SetFloat("_Value", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat(" in-game items", this.Size);
			this.BFGNMFCNDBC().SetFloat("_BlurVector", (float)this.Speed);
			this.IONHGBPGCHK().SetFloat(" ", this.PosX);
			this.IGKFMCPDNOI().SetFloat(", ", this.PosY);
			this.FHFLKLMFHOI().SetFloat("Ignored PU RPC, cause item is inactive. ", this.Intensity);
			this.FHFLKLMFHOI().SetColor("BadgeText", this.Color);
			this.JLHLHKPHDFO().SetVector("menu.selectedlevelid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1421f, 714f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003177 RID: 12663 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x06003178 RID: 12664 RVA: 0x001052EC File Offset: 0x001034EC
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1644f)
			{
				this.HBJJOCHGOPH = 1492f;
			}
			this.IGKFMCPDNOI().SetFloat("settings.enableranking", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("Rotate environment object to the rotation", this.Size);
			this.DBOLLHHMKKN().SetFloat(". Our prefix is ", (float)this.Speed);
			this.DBOLLHHMKKN().SetFloat("Scene", this.PosX);
			this.NLFJGMBCICG().SetFloat(".highscore", this.PosY);
			this.CEKJODEAMGB().SetFloat("?", this.Intensity);
			this.NLFJGMBCICG().SetColor("_TimeX", this.Color);
			this.FHFLKLMFHOI().SetVector(".lastCheckpoint.perfectHits", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1091f, 1268f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003179 RID: 12665 RVA: 0x00105418 File Offset: 0x00103618
	private void FANADGBGCPI()
	{
		this.SCShader = Shader.Find("#yes");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600317A RID: 12666 RVA: 0x0010543C File Offset: 0x0010363C
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("LoadingStatusText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600317B RID: 12667 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x0600317C RID: 12668 RVA: 0x00103898 File Offset: 0x00101A98
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600317D RID: 12669 RVA: 0x00105460 File Offset: 0x00103660
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1504f)
			{
				this.HBJJOCHGOPH = 956f;
			}
			this.IONHGBPGCHK().SetFloat("Result for ", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("ItemsCountText", this.Size);
			this.KJMECMIGJJA().SetFloat("sprite", (float)this.Speed);
			this.EPCGJFCCAFH().SetFloat("_AdaptionSpeed", this.PosX);
			this.NBPKMLMCHFN.SetFloat("Set Player Distance", this.PosY);
			this.EHDJJANLINB().SetFloat("caret", this.Intensity);
			this.EPCGJFCCAFH().SetColor("_Value3", this.Color);
			this.KJMECMIGJJA().SetVector("OnClick", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 664f, 1184f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600317E RID: 12670 RVA: 0x00104198 File Offset: 0x00102398
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600317F RID: 12671 RVA: 0x00103898 File Offset: 0x00101A98
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003180 RID: 12672 RVA: 0x0010558C File Offset: 0x0010378C
	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 750f)
			{
				this.HBJJOCHGOPH = 1225f;
			}
			this.IGKFMCPDNOI().SetFloat("CameraFilterPack/Drawing_Paper2", this.HBJJOCHGOPH);
			this.CEKJODEAMGB().SetFloat("<color=white>PhotonView Group: ", this.Size);
			this.EPCGJFCCAFH().SetFloat("MenuScene", (float)this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.PosX);
			this.BFGNMFCNDBC().SetFloat("CameraFilterPack/Blend2Camera_HardLight", this.PosY);
			this.KOHGPKOFEJO().SetFloat("BitsData", this.Intensity);
			this.IONHGBPGCHK().SetColor("_MainTex2", this.Color);
			this.EHDJJANLINB().SetVector("shader.future", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 583f, 1486f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003181 RID: 12673 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003182 RID: 12674 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06003183 RID: 12675 RVA: 0x001056B8 File Offset: 0x001038B8
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("StandAloneInputSystem should not be used with the GamePadInputModule, please remove it from the Event System in this scene or disable it when this module is in use");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003184 RID: 12676 RVA: 0x001056DC File Offset: 0x001038DC
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 151f)
			{
				this.HBJJOCHGOPH = 1915f;
			}
			this.JLHLHKPHDFO().SetFloat("FreqVolume: ", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("BadgeImage", this.Size);
			this.NLFJGMBCICG().SetFloat("BadgeText", (float)this.Speed);
			this.KOHGPKOFEJO().SetFloat("stretchWidth", this.PosX);
			this.FHFLKLMFHOI().SetFloat("Set Satellite Input", this.PosY);
			this.NBPKMLMCHFN.SetFloat("Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", this.Intensity);
			this.IGKFMCPDNOI().SetColor("hand", this.Color);
			this.KJMECMIGJJA().SetVector("Joystick1Button8", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 932f, 1500f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003185 RID: 12677 RVA: 0x00105808 File Offset: 0x00103A08
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003186 RID: 12678 RVA: 0x00105840 File Offset: 0x00103A40
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 222f)
			{
				this.HBJJOCHGOPH = 1399f;
			}
			this.IONHGBPGCHK().SetFloat("The given 2D texture ", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat("_FarCamera", this.Size);
			this.IGKFMCPDNOI().SetFloat("maxScore", (float)this.Speed);
			this.EHDJJANLINB().SetFloat("Default UI Material", this.PosX);
			this.IONHGBPGCHK().SetFloat("InfoCanvas", this.PosY);
			this.JLHLHKPHDFO().SetFloat("Value", this.Intensity);
			this.DBOLLHHMKKN().SetColor("z", this.Color);
			this.KOHGPKOFEJO().SetVector("warning: Audio Source: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1133f, 1652f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003187 RID: 12679 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x06003188 RID: 12680 RVA: 0x0010596C File Offset: 0x00103B6C
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003189 RID: 12681 RVA: 0x001059A3 File Offset: 0x00103BA3
	private void FDNONDCGGCG()
	{
		this.SCShader = Shader.Find("_FadeFX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0400059A RID: 1434
	public Shader SCShader;

	// Token: 0x0400059B RID: 1435
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400059C RID: 1436
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400059D RID: 1437
	private Material BJFKDHHMLJH;

	// Token: 0x0400059E RID: 1438
	[Range(1f, 10f)]
	public float Size = 1f;

	// Token: 0x0400059F RID: 1439
	public Color Color = new Color(0f, 0.7f, 1f, 1f);

	// Token: 0x040005A0 RID: 1440
	[Range(0f, 30f)]
	public int Speed = 5;

	// Token: 0x040005A1 RID: 1441
	[Range(0f, 1f)]
	public float PosX = 0.5f;

	// Token: 0x040005A2 RID: 1442
	[Range(0f, 1f)]
	public float PosY = 0.5f;

	// Token: 0x040005A3 RID: 1443
	[Range(0f, 1f)]
	public float Intensity = 1f;
}
