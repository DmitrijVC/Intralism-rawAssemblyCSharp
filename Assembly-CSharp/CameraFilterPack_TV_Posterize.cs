using System;
using UnityEngine;

// Token: 0x02000120 RID: 288
[AddComponentMenu("Camera Filter Pack/TV/Posterize")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_Posterize : MonoBehaviour
{
	// Token: 0x06005AAA RID: 23210 RVA: 0x0002523B File Offset: 0x0002343B
	private void ANKIJGCGCBF()
	{
	}

	// Token: 0x06005AAB RID: 23211 RVA: 0x001BF5A7 File Offset: 0x001BD7A7
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005AAC RID: 23212 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005AAD RID: 23213 RVA: 0x001BF5FB File Offset: 0x001BD7FB
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)76;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005AAE RID: 23214 RVA: 0x001BF634 File Offset: 0x001BD834
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 380f)
			{
				this.HBJJOCHGOPH = 1520f;
			}
			this.FEAEGGCNIAA().SetFloat("attempted to spawn go (", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("0.000", this.Fade);
			this.DEFBJOCJJKF().SetFloat("-", this.Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005AAF RID: 23215 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005AB0 RID: 23216 RVA: 0x001BF6DA File Offset: 0x001BD8DA
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005AB1 RID: 23217 RVA: 0x001BF711 File Offset: 0x001BD911
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find(".lastCheckpoint.perfectHits");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005AB2 RID: 23218 RVA: 0x001BF735 File Offset: 0x001BD935
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("_LutTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005AB3 RID: 23219 RVA: 0x001BF75C File Offset: 0x001BD95C
	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 765f)
			{
				this.HBJJOCHGOPH = 1267f;
			}
			this.ADGHJOHKEHG().SetFloat("#.##", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat(" Owner called.", this.Fade);
			this.DOMEEFLPEPJ().SetFloat("_TimeX", this.Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005AB4 RID: 23220 RVA: 0x001BF804 File Offset: 0x001BDA04
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
			this.NBPKMLMCHFN.SetFloat("Fade", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005AB5 RID: 23221 RVA: 0x001BF8AC File Offset: 0x001BDAAC
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 143f)
			{
				this.HBJJOCHGOPH = 1631f;
			}
			this.ADGHJOHKEHG().SetFloat("name", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("_LutTex", this.Fade);
			this.LNLKMDPHDCC().SetFloat("[GameScene] Checkpoints count: ", this.Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005AB6 RID: 23222 RVA: 0x001BF954 File Offset: 0x001BDB54
	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1798f)
			{
				this.HBJJOCHGOPH = 1006f;
			}
			this.HKGAONMOBMH().SetFloat("Horizontal", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("My New Mod Pack", this.Fade);
			this.OLHDPICFBOF().SetFloat("[PlayerBase] Loaded environment: ", this.Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPPEPKGFOEM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005AB7 RID: 23223 RVA: 0x001BF9FA File Offset: 0x001BDBFA
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005AB8 RID: 23224 RVA: 0x001BFA34 File Offset: 0x001BDC34
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1641f)
			{
				this.HBJJOCHGOPH = 630f;
			}
			this.BAGICADFBAB().SetFloat("#pleasewait", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("_Exponent", this.Fade);
			this.LPMLLJKMAMP().SetFloat("CameraFilterPack/Film_ColorPerfection", this.Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005AB9 RID: 23225 RVA: 0x001BFADA File Offset: 0x001BDCDA
	private void FEKECCBFGMI()
	{
		this.SCShader = Shader.Find("id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005ABA RID: 23226 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005ABB RID: 23227 RVA: 0x001BFAFE File Offset: 0x001BDCFE
	private Material FLGPDBBKAIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005ABC RID: 23228 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void ELDMKIAPNGP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005ABD RID: 23229 RVA: 0x001BFB35 File Offset: 0x001BDD35
	private void DPLLKHHLDBB()
	{
		this.SCShader = Shader.Find(" has ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005ABE RID: 23230 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06005ABF RID: 23231 RVA: 0x001BFB59 File Offset: 0x001BDD59
	private Material FOOCJIDNGBB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005AC0 RID: 23232 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005AC1 RID: 23233 RVA: 0x001BFB90 File Offset: 0x001BDD90
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Subtract");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005AC2 RID: 23234 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void HOMNAHDDNHJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005AC3 RID: 23235 RVA: 0x001BFBB4 File Offset: 0x001BDDB4
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005AC4 RID: 23236 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005AC6 RID: 23238 RVA: 0x001BFC14 File Offset: 0x001BDE14
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1326f)
			{
				this.HBJJOCHGOPH = 8f;
			}
			this.HCGJCMDJPGD().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("X", this.Fade);
			this.LPMLLJKMAMP().SetFloat("(from resources)", this.Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005AC7 RID: 23239 RVA: 0x001BFCBC File Offset: 0x001BDEBC
	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 495f)
			{
				this.HBJJOCHGOPH = 1429f;
			}
			this.HCGJCMDJPGD().SetFloat("a", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("[Singleton] multiple instances of '", this.Fade);
			this.GJHLADDCMFF().SetFloat("_MainTex2", this.Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005AC8 RID: 23240 RVA: 0x001BFD62 File Offset: 0x001BDF62
	private Material DOMEEFLPEPJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005AC9 RID: 23241 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void BDBJEDIOKBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005ACA RID: 23242 RVA: 0x001BFD9C File Offset: 0x001BDF9C
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 786f)
			{
				this.HBJJOCHGOPH = 1650f;
			}
			this.GJHLADDCMFF().SetFloat("id", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("#newhighscore", this.Fade);
			this.GJHLADDCMFF().SetFloat("note.4", this.Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005ACB RID: 23243 RVA: 0x0002523B File Offset: 0x0002343B
	private void FAKGFMFAPDG()
	{
	}

	// Token: 0x06005ACC RID: 23244 RVA: 0x001BFE42 File Offset: 0x001BE042
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005ACD RID: 23245 RVA: 0x001BFE79 File Offset: 0x001BE079
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005ACE RID: 23246 RVA: 0x0002523B File Offset: 0x0002343B
	private void HEBOIFKBLGD()
	{
	}

	// Token: 0x06005ACF RID: 23247 RVA: 0x001BFEB0 File Offset: 0x001BE0B0
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 332f)
			{
				this.HBJJOCHGOPH = 520f;
			}
			this.ADGHJOHKEHG().SetFloat("Add Environment Sprite", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetFloat("settings.arcshitsoundtimedelay", this.Fade);
			this.BAGICADFBAB().SetFloat("_NormalAndRoughnessTexture", this.Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLGPDBBKAIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005AD0 RID: 23248 RVA: 0x001BFF56 File Offset: 0x001BE156
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("[Up-Left]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x17000105 RID: 261
	// (get) Token: 0x06005AD1 RID: 23249 RVA: 0x001BFF7A File Offset: 0x001BE17A
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

	// Token: 0x06005AD2 RID: 23250 RVA: 0x001BFFB1 File Offset: 0x001BE1B1
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)64;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005AD3 RID: 23251 RVA: 0x0002523B File Offset: 0x0002343B
	private void COGBDFKOHKK()
	{
	}

	// Token: 0x06005AD4 RID: 23252 RVA: 0x001BFFE8 File Offset: 0x001BE1E8
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find("Editor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005AD5 RID: 23253 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005AD6 RID: 23254 RVA: 0x001C000C File Offset: 0x001BE20C
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005AD7 RID: 23255 RVA: 0x001C0044 File Offset: 0x001BE244
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 791f)
			{
				this.HBJJOCHGOPH = 176f;
			}
			this.EJDPNJAEAKJ().SetFloat("_Value", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("[PlayerController] ", this.Fade);
			this.GJHLADDCMFF().SetFloat("menu.tabid", this.Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005AD8 RID: 23256 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005AD9 RID: 23257 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x06005ADA RID: 23258 RVA: 0x001C00EA File Offset: 0x001BE2EA
	private void NKFDNIAKGEO()
	{
		this.SCShader = Shader.Find("Set EnvSprite Image");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005ADB RID: 23259 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005ADC RID: 23260 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005ADD RID: 23261 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005ADE RID: 23262 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005ADF RID: 23263 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005AE0 RID: 23264 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005AE1 RID: 23265 RVA: 0x001C010E File Offset: 0x001BE30E
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005AE2 RID: 23266 RVA: 0x001C0132 File Offset: 0x001BE332
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005AE3 RID: 23267 RVA: 0x001C0169 File Offset: 0x001BE369
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005AE4 RID: 23268 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005AE5 RID: 23269 RVA: 0x001C01A0 File Offset: 0x001BE3A0
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005AE6 RID: 23270 RVA: 0x001C01D7 File Offset: 0x001BE3D7
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005AE7 RID: 23271 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005AE8 RID: 23272 RVA: 0x001C0210 File Offset: 0x001BE410
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 400f)
			{
				this.HBJJOCHGOPH = 1391f;
			}
			this.IONHGBPGCHK().SetFloat("_Offset", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("Tab1Content", this.Fade);
			this.OLHDPICFBOF().SetFloat("[Right]", this.Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLGPDBBKAIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005AE9 RID: 23273 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005AEA RID: 23274 RVA: 0x001C02B8 File Offset: 0x001BE4B8
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 354f)
			{
				this.HBJJOCHGOPH = 363f;
			}
			this.DNLMFEGJJDD().SetFloat("Missing shader in ", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("BloodAlternative3", this.Fade);
			this.EHDJJANLINB().SetFloat("Cancel", this.Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005AEB RID: 23275 RVA: 0x001C035E File Offset: 0x001BE55E
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005AEC RID: 23276 RVA: 0x001C0395 File Offset: 0x001BE595
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005AED RID: 23277 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06005AEE RID: 23278 RVA: 0x001C03CC File Offset: 0x001BE5CC
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("DPADVER");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005AEF RID: 23279 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x06005AF0 RID: 23280 RVA: 0x001C03F0 File Offset: 0x001BE5F0
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 668f)
			{
				this.HBJJOCHGOPH = 423f;
			}
			this.HNFFHCLNBDN().SetFloat("PunPickup", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("SpeedSlider", this.Fade);
			this.LNLKMDPHDCC().SetFloat("_TimeX", this.Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005AF1 RID: 23281 RVA: 0x001C0496 File Offset: 0x001BE696
	private void HPFOFGJPNCI()
	{
		this.SCShader = Shader.Find("ns");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005AF2 RID: 23282 RVA: 0x001C04BA File Offset: 0x001BE6BA
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("GenerationMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005AF3 RID: 23283 RVA: 0x001C04DE File Offset: 0x001BE6DE
	private void HJPCJGOEKMF()
	{
		this.SCShader = Shader.Find("_Parameter");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005AF4 RID: 23284 RVA: 0x001C0502 File Offset: 0x001BE702
	private void FDNONDCGGCG()
	{
		this.SCShader = Shader.Find("Result for ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005AF5 RID: 23285 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void JNALDALAJLG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005AF6 RID: 23286 RVA: 0x001C0526 File Offset: 0x001BE726
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("0,7,true,0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005AF7 RID: 23287 RVA: 0x001C054C File Offset: 0x001BE74C
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1603f)
			{
				this.HBJJOCHGOPH = 1181f;
			}
			this.KEMAALEODNH().SetFloat("DeleteButton", this.HBJJOCHGOPH);
			this.FLGPDBBKAIP().SetFloat("_FixDistance", this.Fade);
			this.IONHGBPGCHK().SetFloat("_TimeX", this.Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005AF8 RID: 23288 RVA: 0x001C05F2 File Offset: 0x001BE7F2
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("ChangeSelectedLevel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005AF9 RID: 23289 RVA: 0x001C0616 File Offset: 0x001BE816
	private void MKOMIDCPCDC()
	{
		this.SCShader = Shader.Find("value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005AFA RID: 23290 RVA: 0x001C063A File Offset: 0x001BE83A
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("a year ago");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005AFB RID: 23291 RVA: 0x001C065E File Offset: 0x001BE85E
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005AFC RID: 23292 RVA: 0x001C0698 File Offset: 0x001BE898
	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1101f)
			{
				this.HBJJOCHGOPH = 1897f;
			}
			this.DNLMFEGJJDD().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("id", this.Fade);
			this.FOOCJIDNGBB().SetFloat("DPADHOR", this.Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005AFD RID: 23293 RVA: 0x001C073E File Offset: 0x001BE93E
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find(").");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005AFE RID: 23294 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005AFF RID: 23295 RVA: 0x001C0762 File Offset: 0x001BE962
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("{STEAM_CLAN_IMAGE}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005B00 RID: 23296 RVA: 0x001C0786 File Offset: 0x001BE986
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("Joystick1Button");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005B01 RID: 23297 RVA: 0x001C07AA File Offset: 0x001BE9AA
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B02 RID: 23298 RVA: 0x001C07E1 File Offset: 0x001BE9E1
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B03 RID: 23299 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void AOKOLPEGHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B04 RID: 23300 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B05 RID: 23301 RVA: 0x001C0818 File Offset: 0x001BEA18
	private Material LPPEPKGFOEM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B06 RID: 23302 RVA: 0x001C084F File Offset: 0x001BEA4F
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find("1.87");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005B07 RID: 23303 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005B08 RID: 23304 RVA: 0x001C0873 File Offset: 0x001BEA73
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("UseScanLineSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005B09 RID: 23305 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B0A RID: 23306 RVA: 0x001C0898 File Offset: 0x001BEA98
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 594f)
			{
				this.HBJJOCHGOPH = 417f;
			}
			this.LPPEPKGFOEM().SetFloat("ConfigVersionSlider", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetFloat("Hidden/DepthOfField/BokehSplatting", this.Fade);
			this.EOCCJGIGEGJ().SetFloat("Achievement 21 progress reseted", this.Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B0B RID: 23307 RVA: 0x001C0940 File Offset: 0x001BEB40
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 960f)
			{
				this.HBJJOCHGOPH = 380f;
			}
			this.KEMAALEODNH().SetFloat("In Maps Editor", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("Trackpad", this.Fade);
			this.EOCCJGIGEGJ().SetFloat(" : ", this.Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B0C RID: 23308 RVA: 0x001C09E6 File Offset: 0x001BEBE6
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005B0D RID: 23309 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x06005B0E RID: 23310 RVA: 0x001C0A0C File Offset: 0x001BEC0C
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1875f)
			{
				this.HBJJOCHGOPH = 58f;
			}
			this.FEAEGGCNIAA().SetFloat("SupportLogger OnJoinedLobby(", this.HBJJOCHGOPH);
			this.LPPEPKGFOEM().SetFloat("_Value5", this.Fade);
			this.DEFBJOCJJKF().SetFloat("/icon", this.Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B0F RID: 23311 RVA: 0x001C0AB2 File Offset: 0x001BECB2
	private void AEMGPJDJGBJ()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005B10 RID: 23312 RVA: 0x001C0AD8 File Offset: 0x001BECD8
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 753f)
			{
				this.HBJJOCHGOPH = 1221f;
			}
			this.ADGHJOHKEHG().SetFloat("GroupNameText", this.HBJJOCHGOPH);
			this.DOMEEFLPEPJ().SetFloat("mapselector.orderby", this.Fade);
			this.HCGJCMDJPGD().SetFloat("[MapData] Map timing update from: ", this.Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B11 RID: 23313 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDBBPKIFNJ()
	{
	}

	// Token: 0x06005B12 RID: 23314 RVA: 0x001C0B7E File Offset: 0x001BED7E
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B13 RID: 23315 RVA: 0x001C0BB5 File Offset: 0x001BEDB5
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B14 RID: 23316 RVA: 0x001C0BEC File Offset: 0x001BEDEC
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("_TreatBackfaceHitAsMiss");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005B15 RID: 23317 RVA: 0x001C0C10 File Offset: 0x001BEE10
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("0.00");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005B16 RID: 23318 RVA: 0x001C0C34 File Offset: 0x001BEE34
	private void KOFAMEKHHGD()
	{
		this.SCShader = Shader.Find("StopMusic");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005B17 RID: 23319 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06005B18 RID: 23320 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B19 RID: 23321 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B1A RID: 23322 RVA: 0x001C0C58 File Offset: 0x001BEE58
	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1863f)
			{
				this.HBJJOCHGOPH = 49f;
			}
			this.NBPKMLMCHFN.SetFloat("Set Satellite Input", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("EnableRankingToggle", this.Fade);
			this.LPMLLJKMAMP().SetFloat("/", this.Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B1B RID: 23323 RVA: 0x001C0CFE File Offset: 0x001BEEFE
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005B1C RID: 23324 RVA: 0x001C0D24 File Offset: 0x001BEF24
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 916f)
			{
				this.HBJJOCHGOPH = 1082f;
			}
			this.EHDJJANLINB().SetFloat("Sending vacant view IDs. Length: ", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("Set Background Color", this.Fade);
			this.NBPKMLMCHFN.SetFloat("other.dust0", this.Posterize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B1D RID: 23325 RVA: 0x001C0DCA File Offset: 0x001BEFCA
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B1E RID: 23326 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B1F RID: 23327 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B20 RID: 23328 RVA: 0x001BF5DE File Offset: 0x001BD7DE
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B21 RID: 23329 RVA: 0x001C0E01 File Offset: 0x001BF001
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_Posterize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005B22 RID: 23330 RVA: 0x001C065E File Offset: 0x001BE85E
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000944 RID: 2372
	public Shader SCShader;

	// Token: 0x04000945 RID: 2373
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000946 RID: 2374
	[Range(1f, 256f)]
	public float Posterize = 64f;

	// Token: 0x04000947 RID: 2375
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x04000948 RID: 2376
	private Material BJFKDHHMLJH;
}
