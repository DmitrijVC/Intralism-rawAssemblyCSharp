using System;
using UnityEngine;

// Token: 0x020000AB RID: 171
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Drawing/Paper")]
public class CameraFilterPack_Drawing_Paper : MonoBehaviour
{
	// Token: 0x06003396 RID: 13206 RVA: 0x0010B762 File Offset: 0x00109962
	private void GNPDGBNDCPL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003397 RID: 13207 RVA: 0x0010B77F File Offset: 0x0010997F
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003398 RID: 13208 RVA: 0x0010B762 File Offset: 0x00109962
	private void NFBPKPPECMC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003399 RID: 13209 RVA: 0x0010B7B6 File Offset: 0x001099B6
	private Material JDMJJGEHMJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)67;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600339A RID: 13210 RVA: 0x0010B762 File Offset: 0x00109962
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600339B RID: 13211 RVA: 0x0010B7F0 File Offset: 0x001099F0
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 8f)
			{
				this.HBJJOCHGOPH = 1103f;
			}
			this.NBPKMLMCHFN.SetFloat("_ScratchOffsetScale", this.HBJJOCHGOPH);
			this.FNAFGEMJBDA().SetColor("ResetSpeed", this.Pencil_Color);
			this.NBMPPNFKFLB().SetFloat("&map=", this.Pencil_Size);
			this.DEFBJOCJJKF().SetFloat("yyyy-MM-dd HH:mm:ss", this.Pencil_Correction);
			this.KGOLDDBHIFN().SetFloat("player.xp", this.Intensity);
			this.MCDGIILBNIF().SetFloat("SupportLogger OnJoinedRoom(", this.Speed_Animation);
			this.KGOLDDBHIFN().SetFloat("SpawnObj", this.Corner_Lose);
			this.PLBEJJIHFPB().SetFloat(" item(s) in inventory", this.Fade_Paper_to_BackColor);
			this.NBPKMLMCHFN.SetFloat("_BlendTex", this.Fade_With_Original);
			this.EMDFHOKEGNG().SetColor(" registered.", this.Back_Color);
			this.ILKALHDJBFE().SetTexture("mapid", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600339C RID: 13212 RVA: 0x0010B762 File Offset: 0x00109962
	private void AOKOLPEGHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600339D RID: 13213 RVA: 0x0010B946 File Offset: 0x00109B46
	private void CGDMLHLJIDK()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find("3;4;9;10;21x6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600339E RID: 13214 RVA: 0x0010B980 File Offset: 0x00109B80
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1278f)
			{
				this.HBJJOCHGOPH = 148f;
			}
			this.EMDFHOKEGNG().SetFloat("AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetColor("_MainTex2", this.Pencil_Color);
			this.KGOLDDBHIFN().SetFloat("_Value", this.Pencil_Size);
			this.FKEOGPDLBDD().SetFloat("_Value3", this.Pencil_Correction);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Intensity);
			this.JDMJJGEHMJO().SetFloat("_Value4", this.Speed_Animation);
			this.DEFBJOCJJKF().SetFloat("menutheme.deleted", this.Corner_Lose);
			this.OIIDAKBILMI().SetFloat("_TimeX", this.Fade_Paper_to_BackColor);
			this.BKKJJJGADLM().SetFloat("OpJoinRoom()", this.Fade_With_Original);
			this.LPDOGGFOBDH().SetColor("_Value3", this.Back_Color);
			this.LEIAFCPJMDP().SetTexture("SUCCESS! Item submitted! :D :D :D", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600339F RID: 13215 RVA: 0x0010BAD6 File Offset: 0x00109CD6
	private void KNBJBNDGCIJ()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("<b>(╯°□°）╯︵ ┻━┻</b>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060033A0 RID: 13216 RVA: 0x0010B762 File Offset: 0x00109962
	private void AAEEHINDPNC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060033A1 RID: 13217 RVA: 0x0010B77F File Offset: 0x0010997F
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060033A2 RID: 13218 RVA: 0x0010B762 File Offset: 0x00109962
	private void MIKOICBNGPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060033A3 RID: 13219 RVA: 0x0010B762 File Offset: 0x00109962
	private void EKPLGFAEOBE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060033A4 RID: 13220 RVA: 0x0010BB10 File Offset: 0x00109D10
	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1879f)
			{
				this.HBJJOCHGOPH = 1058f;
			}
			this.HKGAONMOBMH().SetFloat("[RanksSystem] Ranks: no need to update", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetColor("inventory.lastitemscount", this.Pencil_Color);
			this.CECICEGFHKL().SetFloat("Edited unlock conditions", this.Pencil_Size);
			this.FNAFGEMJBDA().SetFloat("FrostCanvas", this.Pencil_Correction);
			this.LEIAFCPJMDP().SetFloat(" - PUBLISHED #", this.Intensity);
			this.OGMEGHKECAH().SetFloat("AllocateViewID() failed. User {0} is out of subIds, as all viewIDs are used.", this.Speed_Animation);
			this.MCDGIILBNIF().SetFloat("_MainTex2", this.Corner_Lose);
			this.LPMLLJKMAMP().SetFloat("Myst_Color", this.Fade_Paper_to_BackColor);
			this.LPMLLJKMAMP().SetFloat("menutheme.hunter", this.Fade_With_Original);
			this.FNAFGEMJBDA().SetColor("CameraFilterPack/Lut_TestMode", this.Back_Color);
			this.DEFBJOCJJKF().SetTexture("SpeedSlider", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECICEGFHKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060033A5 RID: 13221 RVA: 0x0010B762 File Offset: 0x00109962
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060033A6 RID: 13222 RVA: 0x0010BC68 File Offset: 0x00109E68
	private void LKMIFJEBIEC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 669f)
			{
				this.HBJJOCHGOPH = 690f;
			}
			this.FLGPDBBKAIP().SetFloat("maps.", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetColor("didAuthenticate ", this.Pencil_Color);
			this.KGOLDDBHIFN().SetFloat("_Value", this.Pencil_Size);
			this.LPDOGGFOBDH().SetFloat("_Value", this.Pencil_Correction);
			this.DCCHGBHLAAF().SetFloat("_Saturation", this.Intensity);
			this.PLBEJJIHFPB().SetFloat("RPCs can only be sent in rooms. Call of \"", this.Speed_Animation);
			this.CECICEGFHKL().SetFloat("_Color", this.Corner_Lose);
			this.LPMLLJKMAMP().SetFloat("_Value", this.Fade_Paper_to_BackColor);
			this.PLBEJJIHFPB().SetFloat("/", this.Fade_With_Original);
			this.EMDFHOKEGNG().SetColor("Chat", this.Back_Color);
			this.OPMDBHHACME().SetTexture("The used master server address is not available with the subscription currently used. Got to Photon Cloud Dashboard or change URL. Disconnecting.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OPMDBHHACME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060033A7 RID: 13223 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x060033A8 RID: 13224 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMKBLLMIKAB()
	{
	}

	// Token: 0x060033A9 RID: 13225 RVA: 0x0010BDBE File Offset: 0x00109FBE
	private void HPFIHLMKIPF()
	{
		this.FPHEBLMINDA = (Resources.Load(".completed") as Texture2D);
		this.SCShader = Shader.Find("_Exposure");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060033AA RID: 13226 RVA: 0x0010B762 File Offset: 0x00109962
	private void NHHCGPAMLAJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060033AB RID: 13227 RVA: 0x0010BDF7 File Offset: 0x00109FF7
	private void ALNNIDLFILB()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value5") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/FX_Psycho");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060033AC RID: 13228 RVA: 0x0010BE30 File Offset: 0x0010A030
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1835f)
			{
				this.HBJJOCHGOPH = 1875f;
			}
			this.LEIAFCPJMDP().SetFloat("PopulateMapsList", this.HBJJOCHGOPH);
			this.OPMDBHHACME().SetColor("masterSteamID", this.Pencil_Color);
			this.KOHGPKOFEJO().SetFloat("_MainTex2", this.Pencil_Size);
			this.MJJIEHANFJA().SetFloat("_TimeX", this.Pencil_Correction);
			this.EMDFHOKEGNG().SetFloat("<command>", this.Intensity);
			this.PLBEJJIHFPB().SetFloat("_SpotSize", this.Speed_Animation);
			this.NBMPPNFKFLB().SetFloat("_Distortion", this.Corner_Lose);
			this.FKEOGPDLBDD().SetFloat("_FlipAlphaMask", this.Fade_Paper_to_BackColor);
			this.LPDOGGFOBDH().SetFloat("_Value3", this.Fade_With_Original);
			this.BKKJJJGADLM().SetColor("This might be a misconfiguration in the game server config. You need to edit it to a (public) address.", this.Back_Color);
			this.OGMEGHKECAH().SetTexture("ReconnectAndRejoin() failed. It seems the client wasn't connected to a game server before (no address).", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060033AD RID: 13229 RVA: 0x0010BF86 File Offset: 0x0010A186
	private void BKIGIIINEDH()
	{
		this.FPHEBLMINDA = (Resources.Load("menu.tabid") as Texture2D);
		this.SCShader = Shader.Find("note.7");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060033AE RID: 13230 RVA: 0x0010B762 File Offset: 0x00109962
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060033AF RID: 13231 RVA: 0x0010BFBF File Offset: 0x0010A1BF
	private void JKFDDNMPOJH()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value4") as Texture2D);
		this.SCShader = Shader.Find("_BlurVector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060033B0 RID: 13232 RVA: 0x0010BFF8 File Offset: 0x0010A1F8
	private void COIJKMKIEAK()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/FX_Screens") as Texture2D);
		this.SCShader = Shader.Find("settings.selectormapsperpage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060033B1 RID: 13233 RVA: 0x0010B762 File Offset: 0x00109962
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060033B2 RID: 13234 RVA: 0x0010C031 File Offset: 0x0010A231
	private void HAIAHJPCPAG()
	{
		this.FPHEBLMINDA = (Resources.Load("maps.") as Texture2D);
		this.SCShader = Shader.Find("_U");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060033B3 RID: 13235 RVA: 0x0010C06A File Offset: 0x0010A26A
	private void KHIGHFJKPFG()
	{
		this.FPHEBLMINDA = (Resources.Load("selector") as Texture2D);
		this.SCShader = Shader.Find("AVG Misses:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060033B4 RID: 13236 RVA: 0x0010C0A3 File Offset: 0x0010A2A3
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060033B5 RID: 13237 RVA: 0x0010C0DA File Offset: 0x0010A2DA
	private Material MJJIEHANFJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)118;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060033B6 RID: 13238 RVA: 0x0010C111 File Offset: 0x0010A311
	private void IPJFFIDBPFE()
	{
		this.FPHEBLMINDA = (Resources.Load("Crosshair1") as Texture2D);
		this.SCShader = Shader.Find("SpectateButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060033B7 RID: 13239 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x060033B8 RID: 13240 RVA: 0x0010B762 File Offset: 0x00109962
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060033B9 RID: 13241 RVA: 0x0010C14A File Offset: 0x0010A34A
	private void LBAJLLFMMMP()
	{
		this.FPHEBLMINDA = (Resources.Load("NEW_ACHIEVEMENT_1_21") as Texture2D);
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060033BA RID: 13242 RVA: 0x0010C184 File Offset: 0x0010A384
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 816f)
			{
				this.HBJJOCHGOPH = 1399f;
			}
			this.CECICEGFHKL().SetFloat("JoinButton", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetColor("_Value2", this.Pencil_Color);
			this.FLGPDBBKAIP().SetFloat("AudioSampler", this.Pencil_Size);
			this.JDMJJGEHMJO().SetFloat("menu.playedsolo", this.Pencil_Correction);
			this.KOHGPKOFEJO().SetFloat("settings.crosshairopacity", this.Intensity);
			this.CECICEGFHKL().SetFloat("LivesSlider", this.Speed_Animation);
			this.FLGPDBBKAIP().SetFloat("Uploading content", this.Corner_Lose);
			this.KOHGPKOFEJO().SetFloat("CameraFilterPack/Vision_AuraDistortion", this.Fade_Paper_to_BackColor);
			this.MCDGIILBNIF().SetFloat("/", this.Fade_With_Original);
			this.OIIDAKBILMI().SetColor(" not exist", this.Back_Color);
			this.HKGAONMOBMH().SetTexture("\n\n• ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060033BB RID: 13243 RVA: 0x0010C2DA File Offset: 0x0010A4DA
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_Paper1") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_Paper");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060033BC RID: 13244 RVA: 0x0010B762 File Offset: 0x00109962
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060033BD RID: 13245 RVA: 0x0010C314 File Offset: 0x0010A514
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1610f)
			{
				this.HBJJOCHGOPH = 288f;
			}
			this.LEIAFCPJMDP().SetFloat("_SSRMultiplier", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetColor(" : ", this.Pencil_Color);
			this.PLBEJJIHFPB().SetFloat("ready", this.Pencil_Size);
			this.KOHGPKOFEJO().SetFloat(".", this.Pencil_Correction);
			this.NBPKMLMCHFN.SetFloat("[Down]", this.Intensity);
			this.NBMPPNFKFLB().SetFloat("GlassAberration", this.Speed_Animation);
			this.FLGPDBBKAIP().SetFloat("[Up]", this.Corner_Lose);
			this.PLBEJJIHFPB().SetFloat("OperationResponse ignored while disconnecting. Code: ", this.Fade_Paper_to_BackColor);
			this.PLBEJJIHFPB().SetFloat("LivesSlider", this.Fade_With_Original);
			this.HKGAONMOBMH().SetColor("Image", this.Back_Color);
			this.KGOLDDBHIFN().SetTexture("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DCCHGBHLAAF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060033BE RID: 13246 RVA: 0x0010C46A File Offset: 0x0010A66A
	private void IHLMNAGPKDA()
	{
		this.FPHEBLMINDA = (Resources.Load("_Visualize") as Texture2D);
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060033BF RID: 13247 RVA: 0x0010C4A3 File Offset: 0x0010A6A3
	private void ECBILENEOOL()
	{
		this.FPHEBLMINDA = (Resources.Load("_FarCamera") as Texture2D);
		this.SCShader = Shader.Find("#{0:00}{1}{2}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060033C0 RID: 13248 RVA: 0x0010B762 File Offset: 0x00109962
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060033C1 RID: 13249 RVA: 0x0010C4DC File Offset: 0x0010A6DC
	private void FANADGBGCPI()
	{
		this.FPHEBLMINDA = (Resources.Load("#exit") as Texture2D);
		this.SCShader = Shader.Find("MapConfig");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060033C2 RID: 13250 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x060033C3 RID: 13251 RVA: 0x0010B762 File Offset: 0x00109962
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060033C4 RID: 13252 RVA: 0x0010C518 File Offset: 0x0010A718
	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1017f)
			{
				this.HBJJOCHGOPH = 71f;
			}
			this.PLBEJJIHFPB().SetFloat("Dance", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetColor("[LocalizationService] All languages: ", this.Pencil_Color);
			this.CECICEGFHKL().SetFloat("Please attach component to a Graphical UI component", this.Pencil_Size);
			this.FKEOGPDLBDD().SetFloat(" ownership transfered to: ", this.Pencil_Correction);
			this.HKGAONMOBMH().SetFloat("_BlurParams", this.Intensity);
			this.FNAFGEMJBDA().SetFloat("Received unknown status code: ", this.Speed_Animation);
			this.NBPKMLMCHFN.SetFloat("_RampTex", this.Corner_Lose);
			this.PLBEJJIHFPB().SetFloat("_ScreenResolution", this.Fade_Paper_to_BackColor);
			this.FKEOGPDLBDD().SetFloat("_ScreenResolution", this.Fade_With_Original);
			this.MJJIEHANFJA().SetColor("_RampTex", this.Back_Color);
			this.LPMLLJKMAMP().SetTexture("maps.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ILKALHDJBFE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060033C5 RID: 13253 RVA: 0x0010B762 File Offset: 0x00109962
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060033C6 RID: 13254 RVA: 0x0010C66E File Offset: 0x0010A86E
	private Material DCCHGBHLAAF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060033C7 RID: 13255 RVA: 0x0010C6A5 File Offset: 0x0010A8A5
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060033C8 RID: 13256 RVA: 0x0010B762 File Offset: 0x00109962
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060033C9 RID: 13257 RVA: 0x0010B762 File Offset: 0x00109962
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060033CA RID: 13258 RVA: 0x0010C6DC File Offset: 0x0010A8DC
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1399f)
			{
				this.HBJJOCHGOPH = 1853f;
			}
			this.MCDGIILBNIF().SetFloat("ViewMenu", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetColor("Pop", this.Pencil_Color);
			this.JDMJJGEHMJO().SetFloat("[PlayerBase] Starting game from: ", this.Pencil_Size);
			this.ILKALHDJBFE().SetFloat("SfxVolumeSlider", this.Pencil_Correction);
			this.LPMLLJKMAMP().SetFloat("{0}{1}:{2}", this.Intensity);
			this.KOHGPKOFEJO().SetFloat("[ERROR KEY {0}]", this.Speed_Animation);
			this.DOHGBNPMBKG().SetFloat("_Value", this.Corner_Lose);
			this.PLBEJJIHFPB().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", this.Fade_Paper_to_BackColor);
			this.DCCHGBHLAAF().SetFloat("Item ", this.Fade_With_Original);
			this.CECICEGFHKL().SetColor("LevelEditor/CustomEventEditor-", this.Back_Color);
			this.KOHGPKOFEJO().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060033CB RID: 13259 RVA: 0x0010B762 File Offset: 0x00109962
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060033CC RID: 13260 RVA: 0x0010B762 File Offset: 0x00109962
	private void FJABOCDLCAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060033CD RID: 13261 RVA: 0x0010B762 File Offset: 0x00109962
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060033CE RID: 13262 RVA: 0x0010C832 File Offset: 0x0010AA32
	private void ICILLMAKLMI()
	{
		this.FPHEBLMINDA = (Resources.Load(" ") as Texture2D);
		this.SCShader = Shader.Find("_Extra");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060033CF RID: 13263 RVA: 0x0010C86B File Offset: 0x0010AA6B
	private void IDJKNBDKHBD()
	{
		this.FPHEBLMINDA = (Resources.Load(" has ") as Texture2D);
		this.SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060033D0 RID: 13264 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x060033D1 RID: 13265 RVA: 0x0010C8A4 File Offset: 0x0010AAA4
	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1488f)
			{
				this.HBJJOCHGOPH = 1133f;
			}
			this.NBPKMLMCHFN.SetFloat("maps.", this.HBJJOCHGOPH);
			this.DCCHGBHLAAF().SetColor("#savemapchanges?", this.Pencil_Color);
			this.NBMPPNFKFLB().SetFloat("checkpoint", this.Pencil_Size);
			this.JDMJJGEHMJO().SetFloat("_InternalLutTex", this.Pencil_Correction);
			this.BKKJJJGADLM().SetFloat("MenuPlayButton", this.Intensity);
			this.DEFBJOCJJKF().SetFloat("_Distance", this.Speed_Animation);
			this.OPMDBHHACME().SetFloat("offline room", this.Corner_Lose);
			this.FNAFGEMJBDA().SetFloat(".wav", this.Fade_Paper_to_BackColor);
			this.CECICEGFHKL().SetFloat(" ", this.Fade_With_Original);
			this.NBMPPNFKFLB().SetColor("Hex value #RRGGBB", this.Back_Color);
			this.FKEOGPDLBDD().SetTexture("_ScreenResolution", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060033D2 RID: 13266 RVA: 0x0010C9FA File Offset: 0x0010ABFA
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060033D3 RID: 13267 RVA: 0x0010CA31 File Offset: 0x0010AC31
	private void ADPLHDFJFID()
	{
		this.FPHEBLMINDA = (Resources.Load("Messages (shift+tab)") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Colors_BleachBypass");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060033D4 RID: 13268 RVA: 0x0010CA6A File Offset: 0x0010AC6A
	private Material FLGPDBBKAIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)88;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060033D5 RID: 13269 RVA: 0x0010CAA1 File Offset: 0x0010ACA1
	private void JOHOFNKJDEB()
	{
		this.FPHEBLMINDA = (Resources.Load("maps.") as Texture2D);
		this.SCShader = Shader.Find("The process failed: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060033D6 RID: 13270 RVA: 0x0010B762 File Offset: 0x00109962
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060033D7 RID: 13271 RVA: 0x0010CADA File Offset: 0x0010ACDA
	private void MKIMDFLBFOM()
	{
		this.FPHEBLMINDA = (Resources.Load("Gameplay/LobbyPlayerIconElement") as Texture2D);
		this.SCShader = Shader.Find("[EditorEvent] Exception: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060033D8 RID: 13272 RVA: 0x0010B762 File Offset: 0x00109962
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060033D9 RID: 13273 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBFJAOINHMK()
	{
	}

	// Token: 0x060033DA RID: 13274 RVA: 0x0010CB13 File Offset: 0x0010AD13
	private void LFBGJIIECLD()
	{
		this.FPHEBLMINDA = (Resources.Load("Joined Room. isMasterClient: ") as Texture2D);
		this.SCShader = Shader.Find("_SSAO");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060033DB RID: 13275 RVA: 0x0010CB4C File Offset: 0x0010AD4C
	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1229f)
			{
				this.HBJJOCHGOPH = 1785f;
			}
			this.FLGPDBBKAIP().SetFloat("]", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetColor("z", this.Pencil_Color);
			this.NBMPPNFKFLB().SetFloat("\n\n#", this.Pencil_Size);
			this.KOHGPKOFEJO().SetFloat("System.Int64", this.Pencil_Correction);
			this.DEFBJOCJJKF().SetFloat("_Offsets", this.Intensity);
			this.NBPKMLMCHFN.SetFloat(":</b> ", this.Speed_Animation);
			this.FNAFGEMJBDA().SetFloat(": ", this.Corner_Lose);
			this.DOHGBNPMBKG().SetFloat("_Size", this.Fade_Paper_to_BackColor);
			this.EMDFHOKEGNG().SetFloat("_ScreenResolution", this.Fade_With_Original);
			this.NBMPPNFKFLB().SetColor("VeryHigh", this.Back_Color);
			this.KGOLDDBHIFN().SetTexture("ws://", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060033DC RID: 13276 RVA: 0x0002523B File Offset: 0x0002343B
	private void MANDOGNJJBD()
	{
	}

	// Token: 0x060033DD RID: 13277 RVA: 0x0010B762 File Offset: 0x00109962
	private void CAKNMILHHNE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060033DE RID: 13278 RVA: 0x0010CCA2 File Offset: 0x0010AEA2
	private void KOFAMEKHHGD()
	{
		this.FPHEBLMINDA = (Resources.Load("#currentbpm: ") as Texture2D);
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060033DF RID: 13279 RVA: 0x0010CCDC File Offset: 0x0010AEDC
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 763f)
			{
				this.HBJJOCHGOPH = 1761f;
			}
			this.OGMEGHKECAH().SetFloat("The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting.", this.HBJJOCHGOPH);
			this.OPMDBHHACME().SetColor("May", this.Pencil_Color);
			this.NBPKMLMCHFN.SetFloat("_PositionY", this.Pencil_Size);
			this.LPMLLJKMAMP().SetFloat("1.87", this.Pencil_Correction);
			this.PLBEJJIHFPB().SetFloat("_Green_C", this.Intensity);
			this.DEFBJOCJJKF().SetFloat("_Value", this.Speed_Animation);
			this.FLGPDBBKAIP().SetFloat("_Value6", this.Corner_Lose);
			this.HKGAONMOBMH().SetFloat("#or", this.Fade_Paper_to_BackColor);
			this.KGOLDDBHIFN().SetFloat("Joystick1Button5", this.Fade_With_Original);
			this.BKKJJJGADLM().SetColor("value", this.Back_Color);
			this.KGOLDDBHIFN().SetTexture("_Parameter", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060033E0 RID: 13280 RVA: 0x0010CE32 File Offset: 0x0010B032
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060033E1 RID: 13281 RVA: 0x0010B762 File Offset: 0x00109962
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060033E2 RID: 13282 RVA: 0x0010CE6C File Offset: 0x0010B06C
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 53f)
			{
				this.HBJJOCHGOPH = 1217f;
			}
			this.PLBEJJIHFPB().SetFloat("OnSerialize", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetColor("Added GameObject to prefabDictionary: ", this.Pencil_Color);
			this.DEFBJOCJJKF().SetFloat("yes", this.Pencil_Size);
			this.NBPKMLMCHFN.SetFloat("Set Crosshair Color", this.Pencil_Correction);
			this.DCCHGBHLAAF().SetFloat("event", this.Intensity);
			this.CECICEGFHKL().SetFloat("_Value2", this.Speed_Animation);
			this.NBPKMLMCHFN.SetFloat("Scene", this.Corner_Lose);
			this.FNAFGEMJBDA().SetFloat("_ScreenResolution", this.Fade_Paper_to_BackColor);
			this.ILKALHDJBFE().SetFloat("Out {0,4} | In {1,4} | Sum {2,4}", this.Fade_With_Original);
			this.ILKALHDJBFE().SetColor("SetRoomStartTimestamp", this.Back_Color);
			this.DCCHGBHLAAF().SetTexture("RECORD [R]", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060033E3 RID: 13283 RVA: 0x0010CFC4 File Offset: 0x0010B1C4
	private void LNOOFNGHNEL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1783f)
			{
				this.HBJJOCHGOPH = 1191f;
			}
			this.EMDFHOKEGNG().SetFloat("RateButton", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetColor("#failed!", this.Pencil_Color);
			this.KGOLDDBHIFN().SetFloat("_Intensity", this.Pencil_Size);
			this.FLGPDBBKAIP().SetFloat("Lightning", this.Pencil_Correction);
			this.FNAFGEMJBDA().SetFloat("CameraFilterPack/Blend2Camera_SplitScreen3D", this.Intensity);
			this.CECICEGFHKL().SetFloat("}", this.Speed_Animation);
			this.DEFBJOCJJKF().SetFloat(". The group number should be at least 1.", this.Corner_Lose);
			this.JDMJJGEHMJO().SetFloat("[PlayerController] ", this.Fade_Paper_to_BackColor);
			this.LEIAFCPJMDP().SetFloat("_Intensity", this.Fade_With_Original);
			this.NBPKMLMCHFN.SetColor(".lastCheckpoint.time", this.Back_Color);
			this.OPMDBHHACME().SetTexture("BackButton", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FNAFGEMJBDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060033E4 RID: 13284 RVA: 0x0010D11C File Offset: 0x0010B31C
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
			this.NBPKMLMCHFN.SetColor("_PColor", this.Pencil_Color);
			this.NBPKMLMCHFN.SetFloat("_Value1", this.Pencil_Size);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Pencil_Correction);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Speed_Animation);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Corner_Lose);
			this.NBPKMLMCHFN.SetFloat("_Value6", this.Fade_Paper_to_BackColor);
			this.NBPKMLMCHFN.SetFloat("_Value7", this.Fade_With_Original);
			this.NBPKMLMCHFN.SetColor("_PColor2", this.Back_Color);
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060033E5 RID: 13285 RVA: 0x0010D274 File Offset: 0x0010B474
	private void AGDIBDLHMKF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 28f)
			{
				this.HBJJOCHGOPH = 1029f;
			}
			this.EMDFHOKEGNG().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetColor("_TimeX", this.Pencil_Color);
			this.DCCHGBHLAAF().SetFloat("cancel", this.Pencil_Size);
			this.KGOLDDBHIFN().SetFloat("#scoresubmitionfailed: ", this.Pencil_Correction);
			this.OIIDAKBILMI().SetFloat("CameraFilterPack/Blend2Camera_Blend", this.Intensity);
			this.EMDFHOKEGNG().SetFloat("PUNCloudBestRegion", this.Speed_Animation);
			this.KOHGPKOFEJO().SetFloat("Crosshair2", this.Corner_Lose);
			this.ILKALHDJBFE().SetFloat("_Red_R", this.Fade_Paper_to_BackColor);
			this.OIIDAKBILMI().SetFloat("_FixDistance", this.Fade_With_Original);
			this.DEFBJOCJJKF().SetColor("Editor", this.Back_Color);
			this.OIIDAKBILMI().SetTexture("BitsData", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060033E6 RID: 13286 RVA: 0x0002523B File Offset: 0x0002343B
	private void ANKIJGCGCBF()
	{
	}

	// Token: 0x060033E7 RID: 13287 RVA: 0x0010D3CA File Offset: 0x0010B5CA
	private void BEKMLIFILFP()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value6") as Texture2D);
		this.SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060033E8 RID: 13288 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x060033E9 RID: 13289 RVA: 0x0010D404 File Offset: 0x0010B604
	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 911f)
			{
				this.HBJJOCHGOPH = 492f;
			}
			this.NBPKMLMCHFN.SetFloat("Object ID", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetColor("_TimeX", this.Pencil_Color);
			this.OGMEGHKECAH().SetFloat("steamid", this.Pencil_Size);
			this.NBMPPNFKFLB().SetFloat("_Value9", this.Pencil_Correction);
			this.MCDGIILBNIF().SetFloat("error", this.Intensity);
			this.HKGAONMOBMH().SetFloat("_ScreenResolution", this.Speed_Animation);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/AAA_Blood_Hit", this.Corner_Lose);
			this.OPMDBHHACME().SetFloat("Left Stick Click", this.Fade_Paper_to_BackColor);
			this.ILKALHDJBFE().SetFloat("[Up]", this.Fade_With_Original);
			this.DOHGBNPMBKG().SetColor("_MainTex2", this.Back_Color);
			this.KOHGPKOFEJO().SetTexture("Joystick1Button6", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060033EA RID: 13290 RVA: 0x0010D55A File Offset: 0x0010B75A
	private void MMOKKAPFGAK()
	{
		this.FPHEBLMINDA = (Resources.Load("ItemNameText") as Texture2D);
		this.SCShader = Shader.Find("#,0.00");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060033EB RID: 13291 RVA: 0x0010D593 File Offset: 0x0010B793
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060033EC RID: 13292 RVA: 0x0010D5CA File Offset: 0x0010B7CA
	private Material FNAFGEMJBDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060033ED RID: 13293 RVA: 0x0010B762 File Offset: 0x00109962
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060033EE RID: 13294 RVA: 0x0010D601 File Offset: 0x0010B801
	private void OHFOLGANOLC()
	{
		this.FPHEBLMINDA = (Resources.Load("Drop_Near") as Texture2D);
		this.SCShader = Shader.Find(".lastCheckpoint.longestComboScore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060033EF RID: 13295 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x060033F0 RID: 13296 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x060033F1 RID: 13297 RVA: 0x0010D63C File Offset: 0x0010B83C
	private void KLCAJPOCMPF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 361f)
			{
				this.HBJJOCHGOPH = 1413f;
			}
			this.ILKALHDJBFE().SetFloat("_VignetteCenter", this.HBJJOCHGOPH);
			this.MJJIEHANFJA().SetColor("(singleton) ", this.Pencil_Color);
			this.JDMJJGEHMJO().SetFloat("0 - sun, 1 - satellite, 2 - particles emitter", this.Pencil_Size);
			this.PLBEJJIHFPB().SetFloat("CameraFilterPack/Lut_TestMode", this.Pencil_Correction);
			this.NBPKMLMCHFN.SetFloat(".", this.Intensity);
			this.BKKJJJGADLM().SetFloat("[PlayerController] ", this.Speed_Animation);
			this.EMDFHOKEGNG().SetFloat("CameraFilterPack/FX_Hexagon_Black", this.Corner_Lose);
			this.ILKALHDJBFE().SetFloat("_Value", this.Fade_Paper_to_BackColor);
			this.OIIDAKBILMI().SetFloat("_ScreenResolution", this.Fade_With_Original);
			this.MJJIEHANFJA().SetColor("ResourcesConfig", this.Back_Color);
			this.KGOLDDBHIFN().SetTexture("Prints list of commands", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060033F2 RID: 13298 RVA: 0x0010B762 File Offset: 0x00109962
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060033F4 RID: 13300 RVA: 0x0010D832 File Offset: 0x0010BA32
	private Material BKKJJJGADLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-104);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060033F5 RID: 13301 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x060033F6 RID: 13302 RVA: 0x0010D869 File Offset: 0x0010BA69
	private Material OPMDBHHACME()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060033F7 RID: 13303 RVA: 0x0010D8A0 File Offset: 0x0010BAA0
	private Material CECICEGFHKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060033F8 RID: 13304 RVA: 0x0010D8D7 File Offset: 0x0010BAD7
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060033F9 RID: 13305 RVA: 0x0010B762 File Offset: 0x00109962
	private void OOGIHDLBBLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060033FA RID: 13306 RVA: 0x0010B762 File Offset: 0x00109962
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060033FB RID: 13307 RVA: 0x0010D90E File Offset: 0x0010BB0E
	private Material ILKALHDJBFE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060033FC RID: 13308 RVA: 0x0010D945 File Offset: 0x0010BB45
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060033FD RID: 13309 RVA: 0x0010D97C File Offset: 0x0010BB7C
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 20f)
			{
				this.HBJJOCHGOPH = 1337f;
			}
			this.DOHGBNPMBKG().SetFloat("???", this.HBJJOCHGOPH);
			this.FNAFGEMJBDA().SetColor("(\\[ */ *i *\\])", this.Pencil_Color);
			this.PLBEJJIHFPB().SetFloat("LevelConfigButton", this.Pencil_Size);
			this.NBMPPNFKFLB().SetFloat("UseScanLine", this.Pencil_Correction);
			this.CECICEGFHKL().SetFloat(". The group number should be at least 1.", this.Intensity);
			this.BKKJJJGADLM().SetFloat("Clear Environment", this.Speed_Animation);
			this.HKGAONMOBMH().SetFloat("_TimeX", this.Corner_Lose);
			this.LPDOGGFOBDH().SetFloat("RecordButton", this.Fade_Paper_to_BackColor);
			this.MCDGIILBNIF().SetFloat("_Value4", this.Fade_With_Original);
			this.LPDOGGFOBDH().SetColor("There are {0} reported logs.", this.Back_Color);
			this.OGMEGHKECAH().SetTexture("GameScene", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060033FE RID: 13310 RVA: 0x0010DAD2 File Offset: 0x0010BCD2
	private void EDPDMBFLHLP()
	{
		this.FPHEBLMINDA = (Resources.Load("setfloat") as Texture2D);
		this.SCShader = Shader.Find("automaticallyRecycleParticleSystems is true but there is no ParticleSystem on this GameObject!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060033FF RID: 13311 RVA: 0x0010DB0C File Offset: 0x0010BD0C
	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1546f)
			{
				this.HBJJOCHGOPH = 1062f;
			}
			this.FKEOGPDLBDD().SetFloat("clicked ", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetColor("23x3", this.Pencil_Color);
			this.NBMPPNFKFLB().SetFloat("_ZCurve", this.Pencil_Size);
			this.KGOLDDBHIFN().SetFloat(" base map(s)", this.Pencil_Correction);
			this.ILKALHDJBFE().SetFloat("SpawnObj", this.Intensity);
			this.DOHGBNPMBKG().SetFloat("ResourceFileSelector", this.Speed_Animation);
			this.FNAFGEMJBDA().SetFloat("_Axis", this.Corner_Lose);
			this.KGOLDDBHIFN().SetFloat("<b>Kick player by NetID</b>\nuse: /kick {NetID}\nUse \"/players\" command to get all NetIDs\nRoom owner only can kick the players", this.Fade_Paper_to_BackColor);
			this.FLGPDBBKAIP().SetFloat("#ok", this.Fade_With_Original);
			this.MJJIEHANFJA().SetColor("LowMid", this.Back_Color);
			this.OIIDAKBILMI().SetTexture("Down", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003400 RID: 13312 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003401 RID: 13313 RVA: 0x0010DC62 File Offset: 0x0010BE62
	private void CHOPDIGHJNH()
	{
		this.FPHEBLMINDA = (Resources.Load("Lerp speed. Recomended 10") as Texture2D);
		this.SCShader = Shader.Find("_Glow");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003402 RID: 13314 RVA: 0x0010CA6A File Offset: 0x0010AC6A
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)88;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003403 RID: 13315 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x06003404 RID: 13316 RVA: 0x0010DC9B File Offset: 0x0010BE9B
	private void KDMKDEKCELE()
	{
		this.FPHEBLMINDA = (Resources.Load("checkpoint") as Texture2D);
		this.SCShader = Shader.Find("_FixDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003405 RID: 13317 RVA: 0x0010DCD4 File Offset: 0x0010BED4
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1265f)
			{
				this.HBJJOCHGOPH = 479f;
			}
			this.FKEOGPDLBDD().SetFloat("x", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetColor(".workshop.json", this.Pencil_Color);
			this.NBPKMLMCHFN.SetFloat("GlassDistortion", this.Pencil_Size);
			this.MJJIEHANFJA().SetFloat("#getrewardfailed: ", this.Pencil_Correction);
			this.NBMPPNFKFLB().SetFloat("In Network lobby", this.Intensity);
			this.OPMDBHHACME().SetFloat("player.xp", this.Speed_Animation);
			this.BKKJJJGADLM().SetFloat("_TimeX", this.Corner_Lose);
			this.JDMJJGEHMJO().SetFloat("Lag ", this.Fade_Paper_to_BackColor);
			this.JDMJJGEHMJO().SetFloat("_Greenness", this.Fade_With_Original);
			this.HKGAONMOBMH().SetColor("_TimeX", this.Back_Color);
			this.LPDOGGFOBDH().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003406 RID: 13318 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x06003407 RID: 13319 RVA: 0x0010B762 File Offset: 0x00109962
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003408 RID: 13320 RVA: 0x0010DE2C File Offset: 0x0010C02C
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1711f)
			{
				this.HBJJOCHGOPH = 182f;
			}
			this.DEFBJOCJJKF().SetFloat("Default color's lerp speed of color changing. Greater values means faster changing. 0 - intant change.", this.HBJJOCHGOPH);
			this.FNAFGEMJBDA().SetColor("shader.frost", this.Pencil_Color);
			this.KGOLDDBHIFN().SetFloat("_Value4", this.Pencil_Size);
			this.OPMDBHHACME().SetFloat("/", this.Pencil_Correction);
			this.BKKJJJGADLM().SetFloat("_Value2", this.Intensity);
			this.OIIDAKBILMI().SetFloat("0.00", this.Speed_Animation);
			this.FKEOGPDLBDD().SetFloat("\r", this.Corner_Lose);
			this.BKKJJJGADLM().SetFloat("-help", this.Fade_Paper_to_BackColor);
			this.MCDGIILBNIF().SetFloat("DPADHOR", this.Fade_With_Original);
			this.FLGPDBBKAIP().SetColor("Committing changes...", this.Back_Color);
			this.CECICEGFHKL().SetTexture("menutheme.hunter", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OPMDBHHACME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003409 RID: 13321 RVA: 0x0002523B File Offset: 0x0002343B
	private void HCIPECAOGIA()
	{
	}

	// Token: 0x0600340A RID: 13322 RVA: 0x0010DF84 File Offset: 0x0010C184
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 872f)
			{
				this.HBJJOCHGOPH = 1533f;
			}
			this.OPMDBHHACME().SetFloat("sounds/hit_normal", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetColor("_Value5", this.Pencil_Color);
			this.OIIDAKBILMI().SetFloat("OPEN FILE", this.Pencil_Size);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Color_GrayScale", this.Pencil_Correction);
			this.LPMLLJKMAMP().SetFloat("Down", this.Intensity);
			this.NBPKMLMCHFN.SetFloat(" b.", this.Speed_Animation);
			this.NBPKMLMCHFN.SetFloat("_Glow", this.Corner_Lose);
			this.DOHGBNPMBKG().SetFloat("\\\\", this.Fade_Paper_to_BackColor);
			this.CECICEGFHKL().SetFloat("_ReflectionTexture4", this.Fade_With_Original);
			this.DOHGBNPMBKG().SetColor("_Value2", this.Back_Color);
			this.HKGAONMOBMH().SetTexture("UseFinalGlassColor", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600340B RID: 13323 RVA: 0x0010E0DA File Offset: 0x0010C2DA
	private void EIMNPCMHJLJ()
	{
		this.FPHEBLMINDA = (Resources.Load("Received RPC \"") as Texture2D);
		this.SCShader = Shader.Find("/icon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600340C RID: 13324 RVA: 0x0010E113 File Offset: 0x0010C313
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600340D RID: 13325 RVA: 0x0010B762 File Offset: 0x00109962
	private void CIHGFHNNFEE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600340E RID: 13326 RVA: 0x0010E14A File Offset: 0x0010C34A
	private void JOPCCCCHNLI()
	{
		this.FPHEBLMINDA = (Resources.Load("_Bullet_2") as Texture2D);
		this.SCShader = Shader.Find("VisionBlur");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600340F RID: 13327 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06003410 RID: 13328 RVA: 0x0010E183 File Offset: 0x0010C383
	private Material LEIAFCPJMDP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003411 RID: 13329 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06003412 RID: 13330 RVA: 0x0010E1BA File Offset: 0x0010C3BA
	private void KMCPMOGKDEH()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find("_Amount");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003413 RID: 13331 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBMBNKOOENB()
	{
	}

	// Token: 0x06003414 RID: 13332 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBDEJFCNOBF()
	{
	}

	// Token: 0x06003415 RID: 13333 RVA: 0x0010E1F4 File Offset: 0x0010C3F4
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1050f)
			{
				this.HBJJOCHGOPH = 605f;
			}
			this.PLBEJJIHFPB().SetFloat("EditMenu", this.HBJJOCHGOPH);
			this.FNAFGEMJBDA().SetColor("Switch environment sprite image", this.Pencil_Color);
			this.MCDGIILBNIF().SetFloat("StartButton", this.Pencil_Size);
			this.CECICEGFHKL().SetFloat("[LevelEditorScene] Creating new item...", this.Pencil_Correction);
			this.NBMPPNFKFLB().SetFloat("Search: ", this.Intensity);
			this.FKEOGPDLBDD().SetFloat("<b>(╯°□°）╯︵ ┻━┻</b>", this.Speed_Animation);
			this.DEFBJOCJJKF().SetFloat("<b>#", this.Corner_Lose);
			this.LEIAFCPJMDP().SetFloat("R1", this.Fade_Paper_to_BackColor);
			this.MCDGIILBNIF().SetFloat("CameraFilterPack_Paper3", this.Fade_With_Original);
			this.OIIDAKBILMI().SetColor("Tab2Content", this.Back_Color);
			this.LEIAFCPJMDP().SetTexture("CameraFilterPack_AAA_Blood2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OPMDBHHACME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003416 RID: 13334 RVA: 0x0010B762 File Offset: 0x00109962
	private void BDBJEDIOKBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003417 RID: 13335 RVA: 0x0002523B File Offset: 0x0002343B
	private void FGNFILLNPJK()
	{
	}

	// Token: 0x06003418 RID: 13336 RVA: 0x0010E34C File Offset: 0x0010C54C
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1041f)
			{
				this.HBJJOCHGOPH = 88f;
			}
			this.KOHGPKOFEJO().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetColor("CameraFilterPack/FX_ZebraColor", this.Pencil_Color);
			this.FLGPDBBKAIP().SetFloat("CameraFilterPack_Glasses_On6", this.Pencil_Size);
			this.DEFBJOCJJKF().SetFloat("CameraFilterPack/Blend2Camera_Screen", this.Pencil_Correction);
			this.BKKJJJGADLM().SetFloat("Tab1Content", this.Intensity);
			this.OIIDAKBILMI().SetFloat("_TimeX", this.Speed_Animation);
			this.EMDFHOKEGNG().SetFloat("[PlayerController] ", this.Corner_Lose);
			this.NBMPPNFKFLB().SetFloat("Texture3", this.Fade_Paper_to_BackColor);
			this.OIIDAKBILMI().SetFloat("_Value7", this.Fade_With_Original);
			this.HKGAONMOBMH().SetColor("mapselector.filter.rateduponly", this.Back_Color);
			this.KOHGPKOFEJO().SetTexture("_EmissionColor", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003419 RID: 13337 RVA: 0x0010B762 File Offset: 0x00109962
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600341A RID: 13338 RVA: 0x0010E4A2 File Offset: 0x0010C6A2
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600341B RID: 13339 RVA: 0x0010E4D9 File Offset: 0x0010C6D9
	private void CFFCLAHMBAA()
	{
		this.FPHEBLMINDA = (Resources.Load(" ") as Texture2D);
		this.SCShader = Shader.Find(".lastCheckpoint.checkpointsUsed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600341C RID: 13340 RVA: 0x0010E512 File Offset: 0x0010C712
	private void MMPHNFPPEHO()
	{
		this.FPHEBLMINDA = (Resources.Load("#,0.00") as Texture2D);
		this.SCShader = Shader.Find("GroupNameText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600341D RID: 13341 RVA: 0x0010E54B File Offset: 0x0010C74B
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-90);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600341E RID: 13342 RVA: 0x0010B762 File Offset: 0x00109962
	private void BMGPBIBPBLA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600341F RID: 13343 RVA: 0x0010E582 File Offset: 0x0010C782
	private void PMPKMGKAAJH()
	{
		this.FPHEBLMINDA = (Resources.Load("EnableRankingToggle") as Texture2D);
		this.SCShader = Shader.Find("_Smooth");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003420 RID: 13344 RVA: 0x0002523B File Offset: 0x0002343B
	private void POEMOLBJDLG()
	{
	}

	// Token: 0x06003421 RID: 13345 RVA: 0x0010E5BB File Offset: 0x0010C7BB
	private void OKLAJINHPAN()
	{
		this.FPHEBLMINDA = (Resources.Load("#FFDA44CC") as Texture2D);
		this.SCShader = Shader.Find(" x ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x17000090 RID: 144
	// (get) Token: 0x06003422 RID: 13346 RVA: 0x0010E5F4 File Offset: 0x0010C7F4
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

	// Token: 0x06003423 RID: 13347 RVA: 0x0010E62B File Offset: 0x0010C82B
	private void MMMDPANNAIO()
	{
		this.FPHEBLMINDA = (Resources.Load("...") as Texture2D);
		this.SCShader = Shader.Find("Error: You're not logged into Steam!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003424 RID: 13348 RVA: 0x0010E664 File Offset: 0x0010C864
	private void CEAGPJBGBMH()
	{
		this.FPHEBLMINDA = (Resources.Load("Skipping region because it's not in PhotonServerSettings.EnabledRegions: ") as Texture2D);
		this.SCShader = Shader.Find("float,0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003425 RID: 13349 RVA: 0x0010E6A0 File Offset: 0x0010C8A0
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1543f)
			{
				this.HBJJOCHGOPH = 1922f;
			}
			this.DEFBJOCJJKF().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.FNAFGEMJBDA().SetColor("_SunPosition", this.Pencil_Color);
			this.LPDOGGFOBDH().SetFloat("NewIconFileSelector", this.Pencil_Size);
			this.EMDFHOKEGNG().SetFloat("Testing, a toggle has toggled [", this.Pencil_Correction);
			this.DCCHGBHLAAF().SetFloat(".highscore", this.Intensity);
			this.DEFBJOCJJKF().SetFloat("#", this.Speed_Animation);
			this.PLBEJJIHFPB().SetFloat("_ReflectionBlur", this.Corner_Lose);
			this.DEFBJOCJJKF().SetFloat("CurrentTimeLabel", this.Fade_Paper_to_BackColor);
			this.PLBEJJIHFPB().SetFloat("Fade", this.Fade_With_Original);
			this.KOHGPKOFEJO().SetColor("[PlayerController] ", this.Back_Color);
			this.LPDOGGFOBDH().SetTexture("tagElement", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ILKALHDJBFE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003426 RID: 13350 RVA: 0x0010B762 File Offset: 0x00109962
	private void IBFMJGJOPMM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003427 RID: 13351 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06003428 RID: 13352 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06003429 RID: 13353 RVA: 0x0010E7F8 File Offset: 0x0010C9F8
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1668f)
			{
				this.HBJJOCHGOPH = 1738f;
			}
			this.LPDOGGFOBDH().SetFloat(".jpg", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetColor("_MainTexBlurred", this.Pencil_Color);
			this.NBPKMLMCHFN.SetFloat("'{0}'{1}{2}", this.Pencil_Size);
			this.DOHGBNPMBKG().SetFloat("_Value2", this.Pencil_Correction);
			this.FNAFGEMJBDA().SetFloat(".completedCount", this.Intensity);
			this.NBMPPNFKFLB().SetFloat("_Level", this.Speed_Animation);
			this.LPDOGGFOBDH().SetFloat("_EmissionGain", this.Corner_Lose);
			this.LPDOGGFOBDH().SetFloat("_SpawnHeuristic", this.Fade_Paper_to_BackColor);
			this.EMDFHOKEGNG().SetFloat("_Value", this.Fade_With_Original);
			this.LPMLLJKMAMP().SetColor("maps.", this.Back_Color);
			this.NBPKMLMCHFN.SetTexture("StartButton", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600342A RID: 13354 RVA: 0x0010B762 File Offset: 0x00109962
	private void KMIEAGOFLBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600342B RID: 13355 RVA: 0x0010B762 File Offset: 0x00109962
	private void JNALDALAJLG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600342C RID: 13356 RVA: 0x0010E94E File Offset: 0x0010CB4E
	private void MNBPNHNAEBK()
	{
		this.FPHEBLMINDA = (Resources.Load("Received OnSerialization for view ID ") as Texture2D);
		this.SCShader = Shader.Find("Reset XP");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600342D RID: 13357 RVA: 0x0010E987 File Offset: 0x0010CB87
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600342E RID: 13358 RVA: 0x0010E9C0 File Offset: 0x0010CBC0
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 987f)
			{
				this.HBJJOCHGOPH = 1226f;
			}
			this.JDMJJGEHMJO().SetFloat("CameraFilterPack/Drawing_Halftone", this.HBJJOCHGOPH);
			this.LEIAFCPJMDP().SetColor("maps.", this.Pencil_Color);
			this.PLBEJJIHFPB().SetFloat("resource", this.Pencil_Size);
			this.FNAFGEMJBDA().SetFloat("_TimeX", this.Pencil_Correction);
			this.MCDGIILBNIF().SetFloat("curScn", this.Intensity);
			this.OIIDAKBILMI().SetFloat("_Value3", this.Speed_Animation);
			this.CECICEGFHKL().SetFloat("_ChangeRed", this.Corner_Lose);
			this.JDMJJGEHMJO().SetFloat("player.currentrank", this.Fade_Paper_to_BackColor);
			this.FNAFGEMJBDA().SetFloat("SupportLogger OnApplicationPause: ", this.Fade_With_Original);
			this.MJJIEHANFJA().SetColor("Fade", this.Back_Color);
			this.ILKALHDJBFE().SetTexture(".GoalProgress", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLGPDBBKAIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600342F RID: 13359 RVA: 0x0010EB18 File Offset: 0x0010CD18
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1420f)
			{
				this.HBJJOCHGOPH = 1904f;
			}
			this.LPMLLJKMAMP().SetFloat("settings.arcsnohitsoundtimedelay", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetColor("_MainTex2", this.Pencil_Color);
			this.LEIAFCPJMDP().SetFloat("_Value5", this.Pencil_Size);
			this.LPMLLJKMAMP().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this.Pencil_Correction);
			this.DOHGBNPMBKG().SetFloat("/", this.Intensity);
			this.LEIAFCPJMDP().SetFloat("offline", this.Speed_Animation);
			this.EMDFHOKEGNG().SetFloat("_Value2", this.Corner_Lose);
			this.LPDOGGFOBDH().SetFloat("No Description", this.Fade_Paper_to_BackColor);
			this.ILKALHDJBFE().SetFloat("settings.enableranking", this.Fade_With_Original);
			this.NBPKMLMCHFN.SetColor("CameraFilterPack/Blend2Camera_Luminosity", this.Back_Color);
			this.NBPKMLMCHFN.SetTexture("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003430 RID: 13360 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x06003431 RID: 13361 RVA: 0x0002523B File Offset: 0x0002343B
	private void AOLABBMIEIM()
	{
	}

	// Token: 0x040005C2 RID: 1474
	public Shader SCShader;

	// Token: 0x040005C3 RID: 1475
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040005C4 RID: 1476
	public Color Pencil_Color = new Color(0.156f, 0.3f, 0.738f, 1f);

	// Token: 0x040005C5 RID: 1477
	[Range(0.0001f, 0.0022f)]
	public float Pencil_Size = 0.0008f;

	// Token: 0x040005C6 RID: 1478
	[Range(0f, 2f)]
	public float Pencil_Correction = 0.76f;

	// Token: 0x040005C7 RID: 1479
	[Range(0f, 1f)]
	public float Intensity = 1f;

	// Token: 0x040005C8 RID: 1480
	[Range(0f, 2f)]
	public float Speed_Animation = 1f;

	// Token: 0x040005C9 RID: 1481
	[Range(0f, 1f)]
	public float Corner_Lose = 0.5f;

	// Token: 0x040005CA RID: 1482
	[Range(0f, 1f)]
	public float Fade_Paper_to_BackColor;

	// Token: 0x040005CB RID: 1483
	[Range(0f, 1f)]
	public float Fade_With_Original = 1f;

	// Token: 0x040005CC RID: 1484
	public Color Back_Color = new Color(1f, 1f, 1f, 1f);

	// Token: 0x040005CD RID: 1485
	private Material BJFKDHHMLJH;

	// Token: 0x040005CE RID: 1486
	private Texture2D FPHEBLMINDA;
}
