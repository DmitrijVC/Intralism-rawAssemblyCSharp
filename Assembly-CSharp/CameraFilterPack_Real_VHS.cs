using System;
using UnityEngine;

// Token: 0x02000108 RID: 264
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/VHS/Real VHS HQ")]
public class CameraFilterPack_Real_VHS : MonoBehaviour
{
	// Token: 0x06005231 RID: 21041 RVA: 0x00198E74 File Offset: 0x00197074
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.NBPKMLMCHFN.SetTexture("_Red_B", this.EIJFCDJLEPB);
			this.AELJLBOJAIL().SetTexture(".message", this.JAFJKILGIKJ);
			this.HNICHJCGJOC().SetFloat("--------------------------------", this.TRACKING);
			this.DKNJGHFLAIF().SetFloat("%", this.JITTER);
			this.ACHNOHCLGOO().SetFloat("LoadingStatusText", this.GLITCH);
			this.MCDGIILBNIF().SetFloat("fade out duration", this.NOISE);
			this.ACHNOHCLGOO().SetFloat("_Red_C", this.Brightness);
			this.AELJLBOJAIL().SetFloat("_ScreenResolution", 654f - this.Constrast);
			int width = 18;
			int height = 96;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = (FilterMode)7;
			Graphics.Blit(AAACLELCPML, temporary, this.LENEJAGLCNL());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005232 RID: 21042 RVA: 0x00198F8A File Offset: 0x0019718A
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005233 RID: 21043 RVA: 0x00198F8A File Offset: 0x0019718A
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005234 RID: 21044 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06005235 RID: 21045 RVA: 0x00198F8A File Offset: 0x0019718A
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005236 RID: 21046 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06005237 RID: 21047 RVA: 0x00198FA7 File Offset: 0x001971A7
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005238 RID: 21048 RVA: 0x00198FE0 File Offset: 0x001971E0
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.MCDGIILBNIF().SetTexture("turn", this.EIJFCDJLEPB);
			this.KOHGPKOFEJO().SetTexture("_TimeX", this.JAFJKILGIKJ);
			this.HNICHJCGJOC().SetFloat("NEW_ACHIEVEMENT_1_26", this.TRACKING);
			this.KBOPGONOCNP().SetFloat("PS Home", this.JITTER);
			this.AELJLBOJAIL().SetFloat("Reconnect() failed. Can only connect while in state 'Disconnected'. Current state: ", this.GLITCH);
			this.MCDGIILBNIF().SetFloat("#yes", this.NOISE);
			this.DKNJGHFLAIF().SetFloat("_Value", this.Brightness);
			this.HEHKGPKLAKK().SetFloat("_MainTex2", 816f - this.Constrast);
			int width = -96;
			int height = -170;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = FilterMode.Trilinear;
			Graphics.Blit(AAACLELCPML, temporary, this.KOHGPKOFEJO());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005239 RID: 21049 RVA: 0x001990F6 File Offset: 0x001972F6
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600523A RID: 21050 RVA: 0x00199130 File Offset: 0x00197330
	public static Texture2D CBEEMEFFFCL(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(333f, 1189f, (float)LGILGCGIHHM.width, (float)LGILGCGIHHM.height), 0, 0);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	// Token: 0x0600523B RID: 21051 RVA: 0x00199178 File Offset: 0x00197378
	public static Texture2D KFKBEKKIOAC(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(1881f, 1545f, (float)LGILGCGIHHM.width, (float)LGILGCGIHHM.height), 1, 1);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	// Token: 0x0600523C RID: 21052 RVA: 0x00198F8A File Offset: 0x0019718A
	private void NNPBKKBFDHH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600523D RID: 21053 RVA: 0x001991C0 File Offset: 0x001973C0
	public static Texture2D BPFMPEIKCBO(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(331f, 677f, (float)LGILGCGIHHM.width, (float)LGILGCGIHHM.height), 0, 0);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	// Token: 0x0600523E RID: 21054 RVA: 0x00198F8A File Offset: 0x0019718A
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600523F RID: 21055 RVA: 0x00199208 File Offset: 0x00197408
	public static Texture2D HFLEMGJEGOJ(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(1003f, 1356f, (float)LGILGCGIHHM.width, (float)LGILGCGIHHM.height), 0, 1);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	// Token: 0x06005240 RID: 21056 RVA: 0x00198F8A File Offset: 0x0019718A
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005241 RID: 21057 RVA: 0x00199250 File Offset: 0x00197450
	public static Texture2D KPIFOAMPJIG(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(198f, 78f, (float)LGILGCGIHHM.width, (float)LGILGCGIHHM.height), 0, 0);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	// Token: 0x170000ED RID: 237
	// (get) Token: 0x06005242 RID: 21058 RVA: 0x00199295 File Offset: 0x00197495
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

	// Token: 0x06005243 RID: 21059 RVA: 0x001992CC File Offset: 0x001974CC
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.LENEJAGLCNL().SetTexture("CameraFilterPack/Blend2Camera_Luminosity", this.EIJFCDJLEPB);
			this.KBOPGONOCNP().SetTexture("_Value", this.JAFJKILGIKJ);
			this.ACHNOHCLGOO().SetFloat(":</b> ", this.TRACKING);
			this.MCDGIILBNIF().SetFloat("#pleasewait", this.JITTER);
			this.HEHKGPKLAKK().SetFloat("_Screen", this.GLITCH);
			this.EHDJJANLINB().SetFloat("Select", this.NOISE);
			this.KBOPGONOCNP().SetFloat("AvatarImage", this.Brightness);
			this.LENEJAGLCNL().SetFloat("_Offsets", 1333f - this.Constrast);
			int width = -86;
			int height = 134;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = (FilterMode)8;
			Graphics.Blit(AAACLELCPML, temporary, this.DKNJGHFLAIF());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005244 RID: 21060 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06005245 RID: 21061 RVA: 0x001993E4 File Offset: 0x001975E4
	public static Texture2D LKDFDHPIHME(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(1513f, 118f, (float)LGILGCGIHHM.width, (float)LGILGCGIHHM.height), 1, 1);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	// Token: 0x06005246 RID: 21062 RVA: 0x0019942C File Offset: 0x0019762C
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.AELJLBOJAIL().SetTexture("_TimeX", this.EIJFCDJLEPB);
			this.AELJLBOJAIL().SetTexture("offsets", this.JAFJKILGIKJ);
			this.NBPKMLMCHFN.SetFloat("Reload Maps", this.TRACKING);
			this.MCDGIILBNIF().SetFloat("menu.playedsolo", this.JITTER);
			this.KBOPGONOCNP().SetFloat("_Value", this.GLITCH);
			this.KOHGPKOFEJO().SetFloat("menutheme.27thfloor", this.NOISE);
			this.KBOPGONOCNP().SetFloat("Operation ", this.Brightness);
			this.DKNJGHFLAIF().SetFloat("_Bullet_11", 114f - this.Constrast);
			int width = 121;
			int height = -39;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = (FilterMode)7;
			Graphics.Blit(AAACLELCPML, temporary, this.LENEJAGLCNL());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005247 RID: 21063 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005248 RID: 21064 RVA: 0x00199544 File Offset: 0x00197744
	public static Texture2D PLNJPIAHEIF(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(601f, 1795f, (float)LGILGCGIHHM.width, (float)LGILGCGIHHM.height), 0, 1);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	// Token: 0x06005249 RID: 21065 RVA: 0x0019958C File Offset: 0x0019778C
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("settings_bindings_controller_type");
		this.EIJFCDJLEPB = (Resources.Load("_Value4") as Texture2D);
		this.JAFJKILGIKJ = (Resources.Load("[DiscordController] Join request {0}#{1}: {2}") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600524A RID: 21066 RVA: 0x001995E5 File Offset: 0x001977E5
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600524B RID: 21067 RVA: 0x0019961C File Offset: 0x0019781C
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("move");
		this.EIJFCDJLEPB = (Resources.Load("offsets") as Texture2D);
		this.JAFJKILGIKJ = (Resources.Load("CameraFilterPack/3D_Myst") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600524C RID: 21068 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x0600524D RID: 21069 RVA: 0x00199678 File Offset: 0x00197878
	public static Texture2D GOKCNCOJHOH(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(1497f, 1455f, (float)LGILGCGIHHM.width, (float)LGILGCGIHHM.height), 1, 1);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	// Token: 0x0600524E RID: 21070 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x0600524F RID: 21071 RVA: 0x001996C0 File Offset: 0x001978C0
	private void LGHCJCFHEMF()
	{
		this.SCShader = Shader.Find("Chat");
		this.EIJFCDJLEPB = (Resources.Load("cancel") as Texture2D);
		this.JAFJKILGIKJ = (Resources.Load("}") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005250 RID: 21072 RVA: 0x00199719 File Offset: 0x00197919
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005251 RID: 21073 RVA: 0x00199750 File Offset: 0x00197950
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Real_VHS");
		this.EIJFCDJLEPB = (Resources.Load("CameraFilterPack_VHS1") as Texture2D);
		this.JAFJKILGIKJ = (Resources.Load("CameraFilterPack_VHS2") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005252 RID: 21074 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x06005253 RID: 21075 RVA: 0x001997AC File Offset: 0x001979AC
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.NBPKMLMCHFN.SetTexture("_TimeX", this.EIJFCDJLEPB);
			this.HEHKGPKLAKK().SetTexture("settings_bindings_sec_", this.JAFJKILGIKJ);
			this.KBOPGONOCNP().SetFloat("ComboScoreText", this.TRACKING);
			this.HEHKGPKLAKK().SetFloat("USE_PREDICATION", this.JITTER);
			this.AELJLBOJAIL().SetFloat(".lastCheckpoint.playerdistance", this.GLITCH);
			this.ACHNOHCLGOO().SetFloat(" not exist", this.NOISE);
			this.HNICHJCGJOC().SetFloat("inventory.selected.", this.Brightness);
			this.EHDJJANLINB().SetFloat("maps.", 1273f - this.Constrast);
			int width = 133;
			int height = 170;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = FilterMode.Point;
			Graphics.Blit(AAACLELCPML, temporary, this.ACHNOHCLGOO());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005254 RID: 21076 RVA: 0x001998C4 File Offset: 0x00197AC4
	private void AEOLJEIDMDB()
	{
		this.SCShader = Shader.Find("Reconnect() failed. It seems the client wasn't connected before?! Current state: ");
		this.EIJFCDJLEPB = (Resources.Load("EnableRankingToggle") as Texture2D);
		this.JAFJKILGIKJ = (Resources.Load("_Offsets") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005256 RID: 21078 RVA: 0x0019995C File Offset: 0x00197B5C
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.AELJLBOJAIL().SetTexture("/files/mods_terms.pdf", this.EIJFCDJLEPB);
			this.HEHKGPKLAKK().SetTexture(".lastCheckpoint.checkpointsUsed", this.JAFJKILGIKJ);
			this.NBPKMLMCHFN.SetFloat("InventoryButton", this.TRACKING);
			this.NBPKMLMCHFN.SetFloat("_Near", this.JITTER);
			this.KBOPGONOCNP().SetFloat(" not exist", this.GLITCH);
			this.AELJLBOJAIL().SetFloat("Options", this.NOISE);
			this.AELJLBOJAIL().SetFloat("_BlurVector", this.Brightness);
			this.HNICHJCGJOC().SetFloat("AudioSampler", 1336f - this.Constrast);
			int width = -70;
			int height = 165;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = (FilterMode)6;
			Graphics.Blit(AAACLELCPML, temporary, this.KOHGPKOFEJO());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005257 RID: 21079 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x06005258 RID: 21080 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x06005259 RID: 21081 RVA: 0x00199A74 File Offset: 0x00197C74
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		this.EIJFCDJLEPB = (Resources.Load("rarity") as Texture2D);
		this.JAFJKILGIKJ = (Resources.Load("_Near") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600525A RID: 21082 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x0600525B RID: 21083 RVA: 0x00198F8A File Offset: 0x0019718A
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600525C RID: 21084 RVA: 0x00199AD0 File Offset: 0x00197CD0
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find(". Sent by actorNr: ");
		this.EIJFCDJLEPB = (Resources.Load("mapselector.orderby") as Texture2D);
		this.JAFJKILGIKJ = (Resources.Load("float,0") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600525D RID: 21085 RVA: 0x00199B2C File Offset: 0x00197D2C
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.AELJLBOJAIL().SetTexture("_BlurParams", this.EIJFCDJLEPB);
			this.HNICHJCGJOC().SetTexture("settings.gamemessagesduration", this.JAFJKILGIKJ);
			this.HEHKGPKLAKK().SetFloat("[MapsSystem] Unloading maps resources...", this.TRACKING);
			this.MCDGIILBNIF().SetFloat("/Saved Games/", this.JITTER);
			this.KBOPGONOCNP().SetFloat(">", this.GLITCH);
			this.LENEJAGLCNL().SetFloat("maps.", this.NOISE);
			this.HEHKGPKLAKK().SetFloat("SpawnObj", this.Brightness);
			this.ACHNOHCLGOO().SetFloat("A", 1122f - this.Constrast);
			int width = -114;
			int height = 0;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = (FilterMode)4;
			Graphics.Blit(AAACLELCPML, temporary, this.HNICHJCGJOC());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600525E RID: 21086 RVA: 0x00199C44 File Offset: 0x00197E44
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find("_CenterY");
		this.EIJFCDJLEPB = (Resources.Load("white") as Texture2D);
		this.JAFJKILGIKJ = (Resources.Load("Uploading content") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600525F RID: 21087 RVA: 0x00198F8A File Offset: 0x0019718A
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005260 RID: 21088 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06005261 RID: 21089 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x06005262 RID: 21090 RVA: 0x00199CA0 File Offset: 0x00197EA0
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.DKNJGHFLAIF().SetTexture("r", this.EIJFCDJLEPB);
			this.AELJLBOJAIL().SetTexture("_MainTex", this.JAFJKILGIKJ);
			this.DKNJGHFLAIF().SetFloat("_BorderSize", this.TRACKING);
			this.AELJLBOJAIL().SetFloat("DPADHOR", this.JITTER);
			this.MCDGIILBNIF().SetFloat("ResourceIDInputField", this.GLITCH);
			this.KOHGPKOFEJO().SetFloat("IncorrectHitsScoreText", this.NOISE);
			this.EHDJJANLINB().SetFloat("_MainTex2", this.Brightness);
			this.KBOPGONOCNP().SetFloat("CameraFilterPack_OldFilm2", 1816f - this.Constrast);
			int width = -33;
			int height = 105;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = (FilterMode)3;
			Graphics.Blit(AAACLELCPML, temporary, this.NBPKMLMCHFN);
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005263 RID: 21091 RVA: 0x001995E5 File Offset: 0x001977E5
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005264 RID: 21092 RVA: 0x00199DB8 File Offset: 0x00197FB8
	public static Texture2D GetRTPixels(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(0f, 0f, (float)LGILGCGIHHM.width, (float)LGILGCGIHHM.height), 0, 0);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	// Token: 0x06005265 RID: 21093 RVA: 0x00198F8A File Offset: 0x0019718A
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005266 RID: 21094 RVA: 0x00199E00 File Offset: 0x00198000
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.AELJLBOJAIL().SetTexture("_Exponent", this.EIJFCDJLEPB);
			this.KOHGPKOFEJO().SetTexture("UpdateDownloadingProgress", this.JAFJKILGIKJ);
			this.KBOPGONOCNP().SetFloat("_EmissionGain", this.TRACKING);
			this.ACHNOHCLGOO().SetFloat("_ScreenResolution", this.JITTER);
			this.HEHKGPKLAKK().SetFloat("_TimeX", this.GLITCH);
			this.EHDJJANLINB().SetFloat("_Value3", this.NOISE);
			this.HNICHJCGJOC().SetFloat("_ScreenResolution", this.Brightness);
			this.DKNJGHFLAIF().SetFloat("[SoundManager] Loaded skin audio", 774f - this.Constrast);
			int width = 1;
			int height = 108;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = FilterMode.Trilinear;
			Graphics.Blit(AAACLELCPML, temporary, this.LENEJAGLCNL());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005267 RID: 21095 RVA: 0x00198F8A File Offset: 0x0019718A
	private void IEFMONDKKJN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005268 RID: 21096 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJHFOBHJEHL()
	{
	}

	// Token: 0x06005269 RID: 21097 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x0600526A RID: 21098 RVA: 0x00199F18 File Offset: 0x00198118
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.DKNJGHFLAIF().SetTexture("_ScreenResolution", this.EIJFCDJLEPB);
			this.EHDJJANLINB().SetTexture("scenes", this.JAFJKILGIKJ);
			this.HNICHJCGJOC().SetFloat(" SphereWaveform.cs", this.TRACKING);
			this.ACHNOHCLGOO().SetFloat("Fade", this.JITTER);
			this.DKNJGHFLAIF().SetFloat("_Value3", this.GLITCH);
			this.HNICHJCGJOC().SetFloat("OpCreateRoom()", this.NOISE);
			this.EHDJJANLINB().SetFloat("HandsCountSlider", this.Brightness);
			this.HEHKGPKLAKK().SetFloat("/", 1191f - this.Constrast);
			int width = 155;
			int height = -62;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = FilterMode.Trilinear;
			Graphics.Blit(AAACLELCPML, temporary, this.EHDJJANLINB());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600526B RID: 21099 RVA: 0x0019A030 File Offset: 0x00198230
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HNICHJCGJOC().SetTexture("_Value1", this.EIJFCDJLEPB);
			this.LENEJAGLCNL().SetTexture("FinalScoreText", this.JAFJKILGIKJ);
			this.NBPKMLMCHFN.SetFloat("PlayerBase_", this.TRACKING);
			this.MCDGIILBNIF().SetFloat(": ", this.JITTER);
			this.MCDGIILBNIF().SetFloat("menu.relaxinfo", this.GLITCH);
			this.MCDGIILBNIF().SetFloat("_BlurFilterDistance", this.NOISE);
			this.KOHGPKOFEJO().SetFloat("Search: ", this.Brightness);
			this.ACHNOHCLGOO().SetFloat("_Blue_C", 970f - this.Constrast);
			int width = 139;
			int height = 35;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = FilterMode.Bilinear;
			Graphics.Blit(AAACLELCPML, temporary, this.HEHKGPKLAKK());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600526C RID: 21100 RVA: 0x00198F8A File Offset: 0x0019718A
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600526D RID: 21101 RVA: 0x0019A148 File Offset: 0x00198348
	public static Texture2D AJHJDJLIKAK(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(1568f, 317f, (float)LGILGCGIHHM.width, (float)LGILGCGIHHM.height), 0, 0);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	// Token: 0x0600526E RID: 21102 RVA: 0x0019A190 File Offset: 0x00198390
	private void KOFAMEKHHGD()
	{
		this.SCShader = Shader.Find("#ok");
		this.EIJFCDJLEPB = (Resources.Load("UI Extensions/UIAdditive") as Texture2D);
		this.JAFJKILGIKJ = (Resources.Load("scenes") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600526F RID: 21103 RVA: 0x00198F8A File Offset: 0x0019718A
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005270 RID: 21104 RVA: 0x0019A1EC File Offset: 0x001983EC
	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.AELJLBOJAIL().SetTexture("player.quantum", this.EIJFCDJLEPB);
			this.NBPKMLMCHFN.SetTexture("menuVolume", this.JAFJKILGIKJ);
			this.DKNJGHFLAIF().SetFloat("InfoText", this.TRACKING);
			this.ACHNOHCLGOO().SetFloat("_Value2", this.JITTER);
			this.HEHKGPKLAKK().SetFloat("[MapEditor] Updating top menu", this.GLITCH);
			this.AELJLBOJAIL().SetFloat("Game Version: ", this.NOISE);
			this.HEHKGPKLAKK().SetFloat("Start index must in an integer.", this.Brightness);
			this.AELJLBOJAIL().SetFloat("Please specify either t or f.", 1001f - this.Constrast);
			int width = 85;
			int height = 181;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = (FilterMode)7;
			Graphics.Blit(AAACLELCPML, temporary, this.EHDJJANLINB());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005271 RID: 21105 RVA: 0x0019A304 File Offset: 0x00198504
	public static Texture2D DIKKBBNDOPD(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(415f, 130f, (float)LGILGCGIHHM.width, (float)LGILGCGIHHM.height), 0, 0);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	// Token: 0x06005272 RID: 21106 RVA: 0x0019A34C File Offset: 0x0019854C
	public static Texture2D HNOBPNCADNN(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(298f, 207f, (float)LGILGCGIHHM.width, (float)LGILGCGIHHM.height), 0, 1);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	// Token: 0x06005273 RID: 21107 RVA: 0x0019A394 File Offset: 0x00198594
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("Set Sun MinSize");
		this.EIJFCDJLEPB = (Resources.Load("_ScreenResolution") as Texture2D);
		this.JAFJKILGIKJ = (Resources.Load("CameraFilterPack/Blend2Camera_Divide") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005274 RID: 21108 RVA: 0x0019A3F0 File Offset: 0x001985F0
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HNICHJCGJOC().SetTexture("_TimeX", this.EIJFCDJLEPB);
			this.LENEJAGLCNL().SetTexture("_Green_R", this.JAFJKILGIKJ);
			this.HNICHJCGJOC().SetFloat("_VignetteTex", this.TRACKING);
			this.KOHGPKOFEJO().SetFloat("GlassDistortion", this.JITTER);
			this.KOHGPKOFEJO().SetFloat("BitsData", this.GLITCH);
			this.HNICHJCGJOC().SetFloat("[MapEditor] Importing map: ", this.NOISE);
			this.DKNJGHFLAIF().SetFloat("[PlayerBase] Starting new round", this.Brightness);
			this.KOHGPKOFEJO().SetFloat("_Blend", 512f - this.Constrast);
			int width = 185;
			int height = 113;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = FilterMode.Bilinear;
			Graphics.Blit(AAACLELCPML, temporary, this.KBOPGONOCNP());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005275 RID: 21109 RVA: 0x0019A508 File Offset: 0x00198708
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.AELJLBOJAIL().SetTexture("Set satellite radius (offset)", this.EIJFCDJLEPB);
			this.NBPKMLMCHFN.SetTexture(". Client is not the MasterClient in this room.", this.JAFJKILGIKJ);
			this.AELJLBOJAIL().SetFloat("_Offsets", this.TRACKING);
			this.KOHGPKOFEJO().SetFloat("In Main Menu", this.JITTER);
			this.MCDGIILBNIF().SetFloat("ViewID {0} {1}{2}", this.GLITCH);
			this.KOHGPKOFEJO().SetFloat("_SecondTex", this.NOISE);
			this.LENEJAGLCNL().SetFloat("maps.", this.Brightness);
			this.HEHKGPKLAKK().SetFloat("_TintColor", 825f - this.Constrast);
			int width = -192;
			int height = -176;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = (FilterMode)6;
			Graphics.Blit(AAACLELCPML, temporary, this.DKNJGHFLAIF());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005276 RID: 21110 RVA: 0x0019A620 File Offset: 0x00198820
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.ACHNOHCLGOO().SetTexture("CameraFilterPack_Paper2", this.EIJFCDJLEPB);
			this.ACHNOHCLGOO().SetTexture("[", this.JAFJKILGIKJ);
			this.MCDGIILBNIF().SetFloat("hidden", this.TRACKING);
			this.KOHGPKOFEJO().SetFloat("SetCrosshairColor", this.JITTER);
			this.KOHGPKOFEJO().SetFloat("Hidden/DepthOfField/BokehSplatting", this.GLITCH);
			this.HNICHJCGJOC().SetFloat("?page=addtip", this.NOISE);
			this.NBPKMLMCHFN.SetFloat("RecieveChatMessage", this.Brightness);
			this.EHDJJANLINB().SetFloat("#failed: ", 657f - this.Constrast);
			int width = 21;
			int height = -41;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = (FilterMode)4;
			Graphics.Blit(AAACLELCPML, temporary, this.AELJLBOJAIL());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005277 RID: 21111 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x06005278 RID: 21112 RVA: 0x0019A738 File Offset: 0x00198938
	private void FANADGBGCPI()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Glitch1");
		this.EIJFCDJLEPB = (Resources.Load("_Value5") as Texture2D);
		this.JAFJKILGIKJ = (Resources.Load("ViewID {0} {1}{2}") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005279 RID: 21113 RVA: 0x0019A794 File Offset: 0x00198994
	public static Texture2D KKFKBIHNAKM(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(1770f, 529f, (float)LGILGCGIHHM.width, (float)LGILGCGIHHM.height), 0, 0);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	// Token: 0x0600527A RID: 21114 RVA: 0x0019A7DC File Offset: 0x001989DC
	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.MCDGIILBNIF().SetTexture("_Value", this.EIJFCDJLEPB);
			this.KOHGPKOFEJO().SetTexture("note.6", this.JAFJKILGIKJ);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.TRACKING);
			this.EHDJJANLINB().SetFloat(": ", this.JITTER);
			this.KBOPGONOCNP().SetFloat("_Red_R", this.GLITCH);
			this.KOHGPKOFEJO().SetFloat("offsets", this.NOISE);
			this.KOHGPKOFEJO().SetFloat("0", this.Brightness);
			this.KOHGPKOFEJO().SetFloat("OK", 1334f - this.Constrast);
			int width = -192;
			int height = -106;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = (FilterMode)7;
			Graphics.Blit(AAACLELCPML, temporary, this.MCDGIILBNIF());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600527B RID: 21115 RVA: 0x0019A8F4 File Offset: 0x00198AF4
	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.AELJLBOJAIL().SetTexture("PossibleMapPointsText", this.EIJFCDJLEPB);
			this.KBOPGONOCNP().SetTexture("CameraFilterPack/Drawing_Toon", this.JAFJKILGIKJ);
			this.LENEJAGLCNL().SetFloat("maps.", this.TRACKING);
			this.HEHKGPKLAKK().SetFloat("Back", this.JITTER);
			this.KBOPGONOCNP().SetFloat("GameMessagesDurationSlider", this.GLITCH);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.NOISE);
			this.DKNJGHFLAIF().SetFloat("_TimeX", this.Brightness);
			this.LENEJAGLCNL().SetFloat("Text", 1144f - this.Constrast);
			int width = 7;
			int height = 178;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = (FilterMode)8;
			Graphics.Blit(AAACLELCPML, temporary, this.NBPKMLMCHFN);
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600527C RID: 21116 RVA: 0x0019AA0A File Offset: 0x00198C0A
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600527D RID: 21117 RVA: 0x0019AA44 File Offset: 0x00198C44
	public static Texture2D ALGEMPDDLDC(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(33f, 1683f, (float)LGILGCGIHHM.width, (float)LGILGCGIHHM.height), 0, 0);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	// Token: 0x0600527E RID: 21118 RVA: 0x0019AA8C File Offset: 0x00198C8C
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.ACHNOHCLGOO().SetTexture("SetupEncryption() got called. ", this.EIJFCDJLEPB);
			this.HNICHJCGJOC().SetTexture("settings.enablerankingnotifications", this.JAFJKILGIKJ);
			this.KBOPGONOCNP().SetFloat("SetRotation", this.TRACKING);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.JITTER);
			this.HNICHJCGJOC().SetFloat("_TimeX", this.GLITCH);
			this.ACHNOHCLGOO().SetFloat("restrictions\n\n#until: ", this.NOISE);
			this.KBOPGONOCNP().SetFloat("_ReprojectionMatrix", this.Brightness);
			this.MCDGIILBNIF().SetFloat("_ScreenResolution", 652f - this.Constrast);
			int width = 145;
			int height = 128;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = (FilterMode)5;
			Graphics.Blit(AAACLELCPML, temporary, this.LENEJAGLCNL());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600527F RID: 21119 RVA: 0x0019ABA4 File Offset: 0x00198DA4
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("materialsquantity[");
		this.EIJFCDJLEPB = (Resources.Load("finished") as Texture2D);
		this.JAFJKILGIKJ = (Resources.Load("Turn") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005280 RID: 21120 RVA: 0x0019AC00 File Offset: 0x00198E00
	public static Texture2D FOFFKKAKHLK(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(1363f, 1310f, (float)LGILGCGIHHM.width, (float)LGILGCGIHHM.height), 0, 1);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	// Token: 0x06005281 RID: 21121 RVA: 0x0019AC48 File Offset: 0x00198E48
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("_Value10");
		this.EIJFCDJLEPB = (Resources.Load("_Green_B") as Texture2D);
		this.JAFJKILGIKJ = (Resources.Load("InfoText") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005282 RID: 21122 RVA: 0x0019ACA4 File Offset: 0x00198EA4
	public static Texture2D GKOFFOOKEIH(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(1702f, 464f, (float)LGILGCGIHHM.width, (float)LGILGCGIHHM.height), 0, 1);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	// Token: 0x06005283 RID: 21123 RVA: 0x0019ACEC File Offset: 0x00198EEC
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.NBPKMLMCHFN.SetTexture("VHS", this.EIJFCDJLEPB);
			this.NBPKMLMCHFN.SetTexture("VHS2", this.JAFJKILGIKJ);
			this.NBPKMLMCHFN.SetFloat("TRACKING", this.TRACKING);
			this.NBPKMLMCHFN.SetFloat("JITTER", this.JITTER);
			this.NBPKMLMCHFN.SetFloat("GLITCH", this.GLITCH);
			this.NBPKMLMCHFN.SetFloat("NOISE", this.NOISE);
			this.NBPKMLMCHFN.SetFloat("Brightness", this.Brightness);
			this.NBPKMLMCHFN.SetFloat("CONTRAST", 1f - this.Constrast);
			int width = 382;
			int height = 576;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = FilterMode.Trilinear;
			Graphics.Blit(AAACLELCPML, temporary, this.NBPKMLMCHFN);
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005284 RID: 21124 RVA: 0x0019AE04 File Offset: 0x00199004
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("PLEASE WAIT");
		this.EIJFCDJLEPB = (Resources.Load("_TimeX") as Texture2D);
		this.JAFJKILGIKJ = (Resources.Load("Populate Mesh Data") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005285 RID: 21125 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x06005286 RID: 21126 RVA: 0x0019AE60 File Offset: 0x00199060
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.MCDGIILBNIF().SetTexture("LetterSpacing: Missing Text component", this.EIJFCDJLEPB);
			this.LENEJAGLCNL().SetTexture("[MenuScene] Error: ", this.JAFJKILGIKJ);
			this.EHDJJANLINB().SetFloat("Down", this.TRACKING);
			this.DKNJGHFLAIF().SetFloat("HPToggle", this.JITTER);
			this.MCDGIILBNIF().SetFloat("Please attach component to a Graphical UI component", this.GLITCH);
			this.HEHKGPKLAKK().SetFloat("Default UI Material", this.NOISE);
			this.AELJLBOJAIL().SetFloat("InputField", this.Brightness);
			this.KBOPGONOCNP().SetFloat("settings.gamemessagesduration", 1430f - this.Constrast);
			int width = 173;
			int height = 0;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = (FilterMode)4;
			Graphics.Blit(AAACLELCPML, temporary, this.AELJLBOJAIL());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005287 RID: 21127 RVA: 0x0019AF78 File Offset: 0x00199178
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.KBOPGONOCNP().SetTexture("_CurveTex", this.EIJFCDJLEPB);
			this.EHDJJANLINB().SetTexture("_Value4", this.JAFJKILGIKJ);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.TRACKING);
			this.HEHKGPKLAKK().SetFloat("saveGameName ", this.JITTER);
			this.DKNJGHFLAIF().SetFloat("_Value4", this.GLITCH);
			this.NBPKMLMCHFN.SetFloat("_Value", this.NOISE);
			this.EHDJJANLINB().SetFloat("_Distortion", this.Brightness);
			this.KOHGPKOFEJO().SetFloat("LoadMapCanvas", 722f - this.Constrast);
			int width = 142;
			int height = -28;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = (FilterMode)5;
			Graphics.Blit(AAACLELCPML, temporary, this.EHDJJANLINB());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005288 RID: 21128 RVA: 0x0019B090 File Offset: 0x00199290
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.AELJLBOJAIL().SetTexture("settings.shaders", this.EIJFCDJLEPB);
			this.LENEJAGLCNL().SetTexture("+", this.JAFJKILGIKJ);
			this.KOHGPKOFEJO().SetFloat("help", this.TRACKING);
			this.KOHGPKOFEJO().SetFloat("challenges", this.JITTER);
			this.NBPKMLMCHFN.SetFloat(" SecondsBeforeRespawn: ", this.GLITCH);
			this.DKNJGHFLAIF().SetFloat("_Level", this.NOISE);
			this.HEHKGPKLAKK().SetFloat("_Value6", this.Brightness);
			this.LENEJAGLCNL().SetFloat("NO", 1873f - this.Constrast);
			int width = -145;
			int height = 199;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = (FilterMode)5;
			Graphics.Blit(AAACLELCPML, temporary, this.HNICHJCGJOC());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005289 RID: 21129 RVA: 0x0019B1A6 File Offset: 0x001993A6
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600528A RID: 21130 RVA: 0x0019B1E0 File Offset: 0x001993E0
	public static Texture2D EFBGDKGGCCD(Texture2D LGILGCGIHHM, RenderTexture HIIBHBOMGLD, int EPLDGCDGCEF, int HOKPADCPFPM)
	{
		RenderTexture active = RenderTexture.active;
		RenderTexture.active = HIIBHBOMGLD;
		LGILGCGIHHM.ReadPixels(new Rect(1245f, 1372f, (float)LGILGCGIHHM.width, (float)LGILGCGIHHM.height), 0, 1);
		RenderTexture.active = active;
		return LGILGCGIHHM;
	}

	// Token: 0x0600528B RID: 21131 RVA: 0x00198F8A File Offset: 0x0019718A
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600528C RID: 21132 RVA: 0x0019B225 File Offset: 0x00199425
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600528D RID: 21133 RVA: 0x00198F8A File Offset: 0x0019718A
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600528E RID: 21134 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x0600528F RID: 21135 RVA: 0x0019B25C File Offset: 0x0019945C
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("Save the map before exiting?");
		this.EIJFCDJLEPB = (Resources.Load("[PlayerBase] Loaded custom model: ") as Texture2D);
		this.JAFJKILGIKJ = (Resources.Load("_Value4") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005290 RID: 21136 RVA: 0x0019B2B8 File Offset: 0x001994B8
	private void DFFKKLAPHCC()
	{
		this.SCShader = Shader.Find("Vertical");
		this.EIJFCDJLEPB = (Resources.Load("_Value3") as Texture2D);
		this.JAFJKILGIKJ = (Resources.Load("Start Color's hex value #RRGGBBAA") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005291 RID: 21137 RVA: 0x0019B311 File Offset: 0x00199511
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005292 RID: 21138 RVA: 0x0019B348 File Offset: 0x00199548
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005293 RID: 21139 RVA: 0x0019B380 File Offset: 0x00199580
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.AELJLBOJAIL().SetTexture(".completed", this.EIJFCDJLEPB);
			this.ACHNOHCLGOO().SetTexture("_Value4", this.JAFJKILGIKJ);
			this.HEHKGPKLAKK().SetFloat("CameraFilterPack/Blend2Camera_Multiply", this.TRACKING);
			this.HNICHJCGJOC().SetFloat("FreqVolume: ", this.JITTER);
			this.HEHKGPKLAKK().SetFloat("_TimeX", this.GLITCH);
			this.KOHGPKOFEJO().SetFloat("challenges/", this.NOISE);
			this.LENEJAGLCNL().SetFloat("NEW", this.Brightness);
			this.KBOPGONOCNP().SetFloat("menu.tabid", 926f - this.Constrast);
			int width = -69;
			int height = -150;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = (FilterMode)6;
			Graphics.Blit(AAACLELCPML, temporary, this.HEHKGPKLAKK());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005294 RID: 21140 RVA: 0x0019B498 File Offset: 0x00199698
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HEHKGPKLAKK().SetTexture("IconImage", this.EIJFCDJLEPB);
			this.DKNJGHFLAIF().SetTexture("< true | false >", this.JAFJKILGIKJ);
			this.AELJLBOJAIL().SetFloat("LoadMapCanvas", this.TRACKING);
			this.EHDJJANLINB().SetFloat("_MainTex2", this.JITTER);
			this.HEHKGPKLAKK().SetFloat("EnvironmentSlider", this.GLITCH);
			this.KBOPGONOCNP().SetFloat("_TimeX", this.NOISE);
			this.HEHKGPKLAKK().SetFloat("MapEnd", this.Brightness);
			this.MCDGIILBNIF().SetFloat("_TimeX", 1825f - this.Constrast);
			int width = -89;
			int height = -69;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
			temporary.filterMode = FilterMode.Trilinear;
			Graphics.Blit(AAACLELCPML, temporary, this.EHDJJANLINB());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005295 RID: 21141 RVA: 0x00198F8A File Offset: 0x0019718A
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005296 RID: 21142 RVA: 0x0019B5B0 File Offset: 0x001997B0
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.KOHGPKOFEJO().SetTexture("inventory.selected.", this.EIJFCDJLEPB);
			this.AELJLBOJAIL().SetTexture("_Value2", this.JAFJKILGIKJ);
			this.HEHKGPKLAKK().SetFloat("_Value3", this.TRACKING);
			this.EHDJJANLINB().SetFloat("BloodAlternative2", this.JITTER);
			this.ACHNOHCLGOO().SetFloat("Hex value #RRGGBB", this.GLITCH);
			this.KBOPGONOCNP().SetFloat("22x1", this.NOISE);
			this.KBOPGONOCNP().SetFloat("_DotSize", this.Brightness);
			this.MCDGIILBNIF().SetFloat("maps.", 620f - this.Constrast);
			int width = 100;
			int height = -19;
			RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
			temporary.filterMode = (FilterMode)4;
			Graphics.Blit(AAACLELCPML, temporary, this.HNICHJCGJOC());
			Graphics.Blit(temporary, BGIKADHFKNF);
			RenderTexture.ReleaseTemporary(temporary);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0400089E RID: 2206
	public Shader SCShader;

	// Token: 0x0400089F RID: 2207
	private Material BJFKDHHMLJH;

	// Token: 0x040008A0 RID: 2208
	private Texture2D EIJFCDJLEPB;

	// Token: 0x040008A1 RID: 2209
	private Texture2D JAFJKILGIKJ;

	// Token: 0x040008A2 RID: 2210
	[Range(0f, 1f)]
	public float TRACKING = 0.212f;

	// Token: 0x040008A3 RID: 2211
	[Range(0f, 1f)]
	public float JITTER = 1f;

	// Token: 0x040008A4 RID: 2212
	[Range(0f, 1f)]
	public float GLITCH = 1f;

	// Token: 0x040008A5 RID: 2213
	[Range(0f, 1f)]
	public float NOISE = 1f;

	// Token: 0x040008A6 RID: 2214
	[Range(-1f, 1f)]
	public float Brightness;

	// Token: 0x040008A7 RID: 2215
	[Range(0f, 1.5f)]
	public float Constrast = 1f;
}
