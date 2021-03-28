using System;
using UnityEngine;

// Token: 0x020000D2 RID: 210
[AddComponentMenu("Camera Filter Pack/FX/Psycho")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_Psycho : MonoBehaviour
{
	// Token: 0x06003F6C RID: 16236 RVA: 0x0013AABD File Offset: 0x00138CBD
	private void JOHOFNKJDEB()
	{
		this.SCShader = Shader.Find("HiddenToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003F6D RID: 16237 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06003F6E RID: 16238 RVA: 0x0013AAE4 File Offset: 0x00138CE4
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 303f)
			{
				this.HBJJOCHGOPH = 1432f;
			}
			this.OCMBHMLNCEK().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("GameScene", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F6F RID: 16239 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F70 RID: 16240 RVA: 0x0013AB91 File Offset: 0x00138D91
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("Uploading preview image");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003F71 RID: 16241 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x06003F72 RID: 16242 RVA: 0x0013ABB5 File Offset: 0x00138DB5
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find("#ok");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003F73 RID: 16243 RVA: 0x0002523B File Offset: 0x0002343B
	private void PFNFPINPCMH()
	{
	}

	// Token: 0x06003F74 RID: 16244 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F75 RID: 16245 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void HOMNAHDDNHJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F76 RID: 16246 RVA: 0x0013ABDC File Offset: 0x00138DDC
	private void HNMIAKKBMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1524f)
			{
				this.HBJJOCHGOPH = 395f;
			}
			this.GJHLADDCMFF().SetFloat("_Intensity", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("Scale environment object by the values", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F77 RID: 16247 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F78 RID: 16248 RVA: 0x0013AC6C File Offset: 0x00138E6C
	private void LNOOFNGHNEL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1993f)
			{
				this.HBJJOCHGOPH = 1499f;
			}
			this.GJHLADDCMFF().SetFloat("...", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("Fade", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F7A RID: 16250 RVA: 0x0013AD1A File Offset: 0x00138F1A
	private Material HJGEHJDMCGI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003F7B RID: 16251 RVA: 0x0013AD51 File Offset: 0x00138F51
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("[ResourcesManager] Load text error: not found");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003F7C RID: 16252 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F7D RID: 16253 RVA: 0x0002523B File Offset: 0x0002343B
	private void EIDKCANPHJE()
	{
	}

	// Token: 0x06003F7E RID: 16254 RVA: 0x0013AD75 File Offset: 0x00138F75
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find(",");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003F7F RID: 16255 RVA: 0x0013AD99 File Offset: 0x00138F99
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003F80 RID: 16256 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F81 RID: 16257 RVA: 0x0013ADC0 File Offset: 0x00138FC0
	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1560f)
			{
				this.HBJJOCHGOPH = 907f;
			}
			this.MCDGIILBNIF().SetFloat("float,1", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("_Value2", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F82 RID: 16258 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F83 RID: 16259 RVA: 0x0013AE50 File Offset: 0x00139050
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003F84 RID: 16260 RVA: 0x0013AE87 File Offset: 0x00139087
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x170000B8 RID: 184
	// (get) Token: 0x06003F85 RID: 16261 RVA: 0x0013AEAB File Offset: 0x001390AB
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

	// Token: 0x06003F86 RID: 16262 RVA: 0x0013AEE2 File Offset: 0x001390E2
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003F87 RID: 16263 RVA: 0x0013AF19 File Offset: 0x00139119
	private Material MPENCEIGLEH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003F88 RID: 16264 RVA: 0x0013AF50 File Offset: 0x00139150
	private void PODKOCOPGLC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1779f)
			{
				this.HBJJOCHGOPH = 1861f;
			}
			this.OCMBHMLNCEK().SetFloat("bool", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("LevelNameInputField", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CBCNOEIALHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F89 RID: 16265 RVA: 0x0013AFE0 File Offset: 0x001391E0
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("_FadeFX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003F8A RID: 16266 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x06003F8B RID: 16267 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F8C RID: 16268 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06003F8D RID: 16269 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06003F8E RID: 16270 RVA: 0x0013B004 File Offset: 0x00139204
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 691f)
			{
				this.HBJJOCHGOPH = 108f;
			}
			this.IIJMIPBMMBF().SetFloat("SupportLogger OnApplicationPause: ", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("#tryagain", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NKBIEMJBCBM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F8F RID: 16271 RVA: 0x0013B094 File Offset: 0x00139294
	private Material CBCNOEIALHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003F90 RID: 16272 RVA: 0x0013B0CC File Offset: 0x001392CC
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1078f)
			{
				this.HBJJOCHGOPH = 1645f;
			}
			this.EJDPNJAEAKJ().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.DIOAAHJDMLK().SetFloat("[NetworkManager] Found ", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F91 RID: 16273 RVA: 0x0013B15C File Offset: 0x0013935C
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 485f)
			{
				this.HBJJOCHGOPH = 440f;
			}
			this.KGOLDDBHIFN().SetFloat("Item invalid. Make sure your mod contains at leats one file.", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("\n", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IOHHLNAPGMA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F92 RID: 16274 RVA: 0x0002523B File Offset: 0x0002343B
	private void GKENNHBFBLA()
	{
	}

	// Token: 0x06003F93 RID: 16275 RVA: 0x0013B1EC File Offset: 0x001393EC
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003F94 RID: 16276 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void LAMEHAHJKMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F95 RID: 16277 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F96 RID: 16278 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F97 RID: 16279 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F98 RID: 16280 RVA: 0x0013B223 File Offset: 0x00139423
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003F99 RID: 16281 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F9A RID: 16282 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F9B RID: 16283 RVA: 0x0002523B File Offset: 0x0002343B
	private void IAIGNDMHFFG()
	{
	}

	// Token: 0x06003F9C RID: 16284 RVA: 0x0013B25C File Offset: 0x0013945C
	private void FIKNBPAIFBI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 28f)
			{
				this.HBJJOCHGOPH = 1916f;
			}
			this.IFMAPIDFNLI().SetFloat("maps.", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("Vignette", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F9D RID: 16285 RVA: 0x0013B2EC File Offset: 0x001394EC
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("getfloat");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003F9E RID: 16286 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F9F RID: 16287 RVA: 0x0013B310 File Offset: 0x00139510
	private Material DIOAAHJDMLK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003FA0 RID: 16288 RVA: 0x0013B348 File Offset: 0x00139548
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1274f)
			{
				this.HBJJOCHGOPH = 484f;
			}
			this.IFMAPIDFNLI().SetFloat("offsets", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("X", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FA1 RID: 16289 RVA: 0x0013B3D8 File Offset: 0x001395D8
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003FA2 RID: 16290 RVA: 0x0013B410 File Offset: 0x00139610
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 619f)
			{
				this.HBJJOCHGOPH = 1141f;
			}
			this.MPENCEIGLEH().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("/", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FA3 RID: 16291 RVA: 0x0013B4A0 File Offset: 0x001396A0
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003FA4 RID: 16292 RVA: 0x0013B4D7 File Offset: 0x001396D7
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003FA5 RID: 16293 RVA: 0x0013B50E File Offset: 0x0013970E
	private void DKGBFNCOAEO()
	{
		this.SCShader = Shader.Find("EnvironmentSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003FA6 RID: 16294 RVA: 0x0013B532 File Offset: 0x00139732
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003FA7 RID: 16295 RVA: 0x0013B56C File Offset: 0x0013976C
	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1278f)
			{
				this.HBJJOCHGOPH = 1328f;
			}
			this.KGOLDDBHIFN().SetFloat(".wav", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("FileMenu", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FA8 RID: 16296 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06003FA9 RID: 16297 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003FAA RID: 16298 RVA: 0x0013B5FC File Offset: 0x001397FC
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1573f)
			{
				this.HBJJOCHGOPH = 1426f;
			}
			this.DOHGBNPMBKG().SetFloat("EventMenu", this.HBJJOCHGOPH);
			this.OCMBHMLNCEK().SetFloat("player ", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OOMFJGPAOKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FAB RID: 16299 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void ELKELFCGMPE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003FAC RID: 16300 RVA: 0x0013B68C File Offset: 0x0013988C
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

	// Token: 0x06003FAD RID: 16301 RVA: 0x0013B532 File Offset: 0x00139732
	private Material ELBMIEOIABA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003FAE RID: 16302 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003FAF RID: 16303 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOLDLDLFFLM()
	{
	}

	// Token: 0x06003FB0 RID: 16304 RVA: 0x0013B71C File Offset: 0x0013991C
	private void JFJLGJEPEAA()
	{
		this.SCShader = Shader.Find("ENABLE_EYE_ADAPTATION");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003FB1 RID: 16305 RVA: 0x0013B740 File Offset: 0x00139940
	private void COOHIILCOCO()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003FB2 RID: 16306 RVA: 0x0013B764 File Offset: 0x00139964
	private void ANBIJFCCANE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 199f)
			{
				this.HBJJOCHGOPH = 1512f;
			}
			this.FAIFBBGFAIB().SetFloat("BitsData", this.HBJJOCHGOPH);
			this.DIOAAHJDMLK().SetFloat(" .", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FB3 RID: 16307 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003FB4 RID: 16308 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06003FB5 RID: 16309 RVA: 0x0013B7F4 File Offset: 0x001399F4
	private void EFNBMCKBNAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1677f)
			{
				this.HBJJOCHGOPH = 1406f;
			}
			this.DOHGBNPMBKG().SetFloat("HighScaleShot", this.HBJJOCHGOPH);
			this.MPENCEIGLEH().SetFloat("Can't find key ", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FB6 RID: 16310 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void PGMMBADJIKH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003FB7 RID: 16311 RVA: 0x0002523B File Offset: 0x0002343B
	private void JFMIDILENDO()
	{
	}

	// Token: 0x06003FB8 RID: 16312 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06003FB9 RID: 16313 RVA: 0x0002523B File Offset: 0x0002343B
	private void EDDPLJGKLKJ()
	{
	}

	// Token: 0x06003FBA RID: 16314 RVA: 0x0013B884 File Offset: 0x00139A84
	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 995f)
			{
				this.HBJJOCHGOPH = 41f;
			}
			this.FAIFBBGFAIB().SetFloat("_Distortion2", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("turn", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MPENCEIGLEH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FBB RID: 16315 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void AAEEHINDPNC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003FBC RID: 16316 RVA: 0x0013B914 File Offset: 0x00139B14
	private void LKMIFJEBIEC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1368f)
			{
				this.HBJJOCHGOPH = 1466f;
			}
			this.IFMAPIDFNLI().SetFloat(".lastCheckpoint.lives", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("Received RPC \"", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FBD RID: 16317 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void GEHINELAGBI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003FBE RID: 16318 RVA: 0x0013B9A4 File Offset: 0x00139BA4
	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1567f)
			{
				this.HBJJOCHGOPH = 1704f;
			}
			this.MCDGIILBNIF().SetFloat("{\"items\":", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("_Value4", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OOMFJGPAOKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FBF RID: 16319 RVA: 0x0013BA34 File Offset: 0x00139C34
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 272f)
			{
				this.HBJJOCHGOPH = 481f;
			}
			this.KDMBOKLMADJ().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.IOHHLNAPGMA().SetFloat("It seems some instantiation is not completed, as instantiation data is used. You should make sure instantiations are paused when calling this method. Cleaning now, despite this.", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FC0 RID: 16320 RVA: 0x0013BAC4 File Offset: 0x00139CC4
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 442f)
			{
				this.HBJJOCHGOPH = 1152f;
			}
			this.HEHKGPKLAKK().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.LEIAFCPJMDP().SetFloat("Drop_With_Obj", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MPENCEIGLEH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FC1 RID: 16321 RVA: 0x0013BB54 File Offset: 0x00139D54
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003FC2 RID: 16322 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void FJABOCDLCAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003FC3 RID: 16323 RVA: 0x0013BB8B File Offset: 0x00139D8B
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003FC4 RID: 16324 RVA: 0x0013BBC4 File Offset: 0x00139DC4
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1202f)
			{
				this.HBJJOCHGOPH = 1685f;
			}
			this.LEIAFCPJMDP().SetFloat("The process failed: ", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("_MainTex2", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FC5 RID: 16325 RVA: 0x0013BC54 File Offset: 0x00139E54
	private void ADPLHDFJFID()
	{
		this.SCShader = Shader.Find("Object ID. Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003FC6 RID: 16326 RVA: 0x0013BC78 File Offset: 0x00139E78
	private Material OOMFJGPAOKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003FC7 RID: 16327 RVA: 0x0013BCAF File Offset: 0x00139EAF
	private Material EGOGECOEONM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003FC8 RID: 16328 RVA: 0x0013BCE6 File Offset: 0x00139EE6
	private void ALNNIDLFILB()
	{
		this.SCShader = Shader.Find("[PlayerBase] Saveing checkpoint data");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003FC9 RID: 16329 RVA: 0x0013BD0A File Offset: 0x00139F0A
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)112;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003FCA RID: 16330 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x06003FCB RID: 16331 RVA: 0x0013B4A0 File Offset: 0x001396A0
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003FCC RID: 16332 RVA: 0x0013BD41 File Offset: 0x00139F41
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003FCD RID: 16333 RVA: 0x0013BD78 File Offset: 0x00139F78
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003FCE RID: 16334 RVA: 0x0013BDAF File Offset: 0x00139FAF
	private void FMNPFCHBLJF()
	{
		this.SCShader = Shader.Find("CameraFilterPack_3D_Myst1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003FCF RID: 16335 RVA: 0x0013BDD3 File Offset: 0x00139FD3
	private Material IFMAPIDFNLI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003FD0 RID: 16336 RVA: 0x0013BE0A File Offset: 0x0013A00A
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("Command not found!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003FD1 RID: 16337 RVA: 0x0013BE30 File Offset: 0x0013A030
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 158f)
			{
				this.HBJJOCHGOPH = 911f;
			}
			this.EJDPNJAEAKJ().SetFloat("_SpawnHeuristic", this.HBJJOCHGOPH);
			this.CBCNOEIALHB().SetFloat("NetworkPeer broke!", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FD2 RID: 16338 RVA: 0x0013BEC0 File Offset: 0x0013A0C0
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 7f)
			{
				this.HBJJOCHGOPH = 235f;
			}
			this.HJGEHJDMCGI().SetFloat("Children", this.HBJJOCHGOPH);
			this.HJGEHJDMCGI().SetFloat("Left", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FD3 RID: 16339 RVA: 0x0013BF50 File Offset: 0x0013A150
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 849f)
			{
				this.HBJJOCHGOPH = 1152f;
			}
			this.IIJMIPBMMBF().SetFloat("PunRespawn", this.HBJJOCHGOPH);
			this.EGOGECOEONM().SetFloat("CameraFilterPack/FX_Grid", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FD4 RID: 16340 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06003FD5 RID: 16341 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003FD6 RID: 16342 RVA: 0x0013BFE0 File Offset: 0x0013A1E0
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("violet");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003FD7 RID: 16343 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x06003FD8 RID: 16344 RVA: 0x0013C004 File Offset: 0x0013A204
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1503f)
			{
				this.HBJJOCHGOPH = 487f;
			}
			this.OOMFJGPAOKL().SetFloat("Line", this.HBJJOCHGOPH);
			this.ELBMIEOIABA().SetFloat("Tab1Content", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FD9 RID: 16345 RVA: 0x0013C094 File Offset: 0x0013A294
	private Material OCMBHMLNCEK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003FDA RID: 16346 RVA: 0x0013C0CC File Offset: 0x0013A2CC
	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 189f)
			{
				this.HBJJOCHGOPH = 1900f;
			}
			this.LENEJAGLCNL().SetFloat("menu.selectedlevelid", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("a month ago", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FDB RID: 16347 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void OMFBGCMHNBM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003FDC RID: 16348 RVA: 0x0013C15C File Offset: 0x0013A35C
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 430f)
			{
				this.HBJJOCHGOPH = 1966f;
			}
			this.NKBIEMJBCBM().SetFloat("_Bullet_11", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("GlassDistortion", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FDD RID: 16349 RVA: 0x0013C1EC File Offset: 0x0013A3EC
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 638f)
			{
				this.HBJJOCHGOPH = 1449f;
			}
			this.HFBJAOFLCJI().SetFloat("settings.arcshitsoundtimedelay", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("</b>", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FDE RID: 16350 RVA: 0x0013C27C File Offset: 0x0013A47C
	private void IKKOIKKIDEG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 783f)
			{
				this.HBJJOCHGOPH = 1531f;
			}
			this.LNLKMDPHDCC().SetFloat("[GameScene] Events count: ", this.HBJJOCHGOPH);
			this.OOMFJGPAOKL().SetFloat("_MainTex2", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FDF RID: 16351 RVA: 0x0013C30C File Offset: 0x0013A50C
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("GameScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003FE0 RID: 16352 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003FE1 RID: 16353 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06003FE2 RID: 16354 RVA: 0x0013C330 File Offset: 0x0013A530
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1430f)
			{
				this.HBJJOCHGOPH = 1245f;
			}
			this.KGOLDDBHIFN().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("MapEditor v.", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FE3 RID: 16355 RVA: 0x0013C3C0 File Offset: 0x0013A5C0
	private Material LEIAFCPJMDP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003FE4 RID: 16356 RVA: 0x0002523B File Offset: 0x0002343B
	private void KDJEJBBDILE()
	{
	}

	// Token: 0x06003FE5 RID: 16357 RVA: 0x0013C3F7 File Offset: 0x0013A5F7
	private Material IOHHLNAPGMA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003FE6 RID: 16358 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003FE7 RID: 16359 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003FE8 RID: 16360 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJHFOBHJEHL()
	{
	}

	// Token: 0x06003FE9 RID: 16361 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x06003FEA RID: 16362 RVA: 0x0013C430 File Offset: 0x0013A630
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1644f)
			{
				this.HBJJOCHGOPH = 829f;
			}
			this.IIJMIPBMMBF().SetFloat("_Amount", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("NetworkScene", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FEB RID: 16363 RVA: 0x0013C4C0 File Offset: 0x0013A6C0
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003FEC RID: 16364 RVA: 0x0002523B File Offset: 0x0002343B
	private void POEMOLBJDLG()
	{
	}

	// Token: 0x06003FED RID: 16365 RVA: 0x0013C4C0 File Offset: 0x0013A6C0
	private Material NJDIODJNGGA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003FEE RID: 16366 RVA: 0x0013C4F7 File Offset: 0x0013A6F7
	private void KHIGHFJKPFG()
	{
		this.SCShader = Shader.Find("color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003FEF RID: 16367 RVA: 0x0013C51C File Offset: 0x0013A71C
	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1777f)
			{
				this.HBJJOCHGOPH = 1317f;
			}
			this.KJMECMIGJJA().SetFloat("HitInRelaxMusicToggle", this.HBJJOCHGOPH);
			this.HHLFDHNEIAH().SetFloat(": ", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NKBIEMJBCBM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FF0 RID: 16368 RVA: 0x0002523B File Offset: 0x0002343B
	private void EPJJDKJEDMM()
	{
	}

	// Token: 0x06003FF1 RID: 16369 RVA: 0x0013C5AC File Offset: 0x0013A7AC
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Psycho");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003FF2 RID: 16370 RVA: 0x0013C5D0 File Offset: 0x0013A7D0
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 443f)
			{
				this.HBJJOCHGOPH = 1600f;
			}
			this.MPENCEIGLEH().SetFloat("menuthemes", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("Bad parameters for setbool! Use <key> <value>", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FF3 RID: 16371 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003FF4 RID: 16372 RVA: 0x0013C660 File Offset: 0x0013A860
	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 701f)
			{
				this.HBJJOCHGOPH = 38f;
			}
			this.EGOGECOEONM().SetFloat("_Dist", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("Editor/", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EGOGECOEONM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FF5 RID: 16373 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003FF6 RID: 16374 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x06003FF7 RID: 16375 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void OGLCKDAHOCG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003FF8 RID: 16376 RVA: 0x0013C6F0 File Offset: 0x0013A8F0
	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1274f)
			{
				this.HBJJOCHGOPH = 718f;
			}
			this.IOHHLNAPGMA().SetFloat("[MenuScene] Error: ", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("_Red_G", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FF9 RID: 16377 RVA: 0x0002523B File Offset: 0x0002343B
	private void KPNKCNJBMKB()
	{
	}

	// Token: 0x06003FFA RID: 16378 RVA: 0x0013C780 File Offset: 0x0013A980
	private void JOPBEKMPPJK()
	{
		this.SCShader = Shader.Find("input");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003FFB RID: 16379 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void IENKPJEBMFM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003FFC RID: 16380 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06003FFD RID: 16381 RVA: 0x0013C7A4 File Offset: 0x0013A9A4
	private Material NKBIEMJBCBM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003FFE RID: 16382 RVA: 0x0013C7DC File Offset: 0x0013A9DC
	private void OPHBLNNGFKG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1022f)
			{
				this.HBJJOCHGOPH = 1856f;
			}
			this.EJDPNJAEAKJ().SetFloat("_EmissionColor", this.HBJJOCHGOPH);
			this.NKBIEMJBCBM().SetFloat("_TimeX", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003FFF RID: 16383 RVA: 0x0013C86C File Offset: 0x0013AA6C
	private Material HHLFDHNEIAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004000 RID: 16384 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004001 RID: 16385 RVA: 0x0013C8A3 File Offset: 0x0013AAA3
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004002 RID: 16386 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x06004003 RID: 16387 RVA: 0x0013C8DC File Offset: 0x0013AADC
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 371f)
			{
				this.HBJJOCHGOPH = 1011f;
			}
			this.HHLFDHNEIAH().SetFloat("#savemapchanges?", this.HBJJOCHGOPH);
			this.CBCNOEIALHB().SetFloat("_Value", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004004 RID: 16388 RVA: 0x0002523B File Offset: 0x0002343B
	private void GNCIOPKPLLA()
	{
	}

	// Token: 0x06004005 RID: 16389 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCDLIKEDMCF()
	{
	}

	// Token: 0x06004006 RID: 16390 RVA: 0x0013AB74 File Offset: 0x00138D74
	private void IBFMJGJOPMM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004007 RID: 16391 RVA: 0x0013C96C File Offset: 0x0013AB6C
	private void IGPCNCJIEOJ()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x040006CE RID: 1742
	public Shader SCShader;

	// Token: 0x040006CF RID: 1743
	private Material BJFKDHHMLJH;

	// Token: 0x040006D0 RID: 1744
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040006D1 RID: 1745
	[Range(0f, 1f)]
	public float Distortion = 1f;
}
