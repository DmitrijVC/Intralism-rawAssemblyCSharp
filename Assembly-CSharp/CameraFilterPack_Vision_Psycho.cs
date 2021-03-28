using System;
using UnityEngine;

// Token: 0x02000137 RID: 311
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Vision/Psycho")]
public class CameraFilterPack_Vision_Psycho : MonoBehaviour
{
	// Token: 0x06006234 RID: 25140 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOLDLDLFFLM()
	{
	}

	// Token: 0x06006236 RID: 25142 RVA: 0x001DD59A File Offset: 0x001DB79A
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006237 RID: 25143 RVA: 0x001DD5B8 File Offset: 0x001DB7B8
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 539f)
			{
				this.HBJJOCHGOPH = 856f;
			}
			this.OIMMPLPBLBK().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("_Value", this.HoleSize);
			this.GKILCDHJFEG().SetFloat("_Parasite", this.HoleSmooth);
			this.GKILCDHJFEG().SetFloat("There is already a virtual button named ", this.Color1);
			this.KOHGPKOFEJO().SetFloat("Error: I/O Failure! :(", this.Color2);
			this.OIMMPLPBLBK().SetVector("KickThePlayer", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1282f, 1122f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006238 RID: 25144 RVA: 0x001DD6B8 File Offset: 0x001DB8B8
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 523f)
			{
				this.HBJJOCHGOPH = 1512f;
			}
			this.EOCCJGIGEGJ().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("_Val", this.HoleSize);
			this.EJDPNJAEAKJ().SetFloat("#FFFFFFFF", this.HoleSmooth);
			this.EOCCJGIGEGJ().SetFloat("OK", this.Color1);
			this.KEMAALEODNH().SetFloat("_Distortion", this.Color2);
			this.DKNJGHFLAIF().SetVector(":", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1179f, 1111f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006239 RID: 25145 RVA: 0x001DD7B7 File Offset: 0x001DB9B7
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600623A RID: 25146 RVA: 0x001DD7F0 File Offset: 0x001DB9F0
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 515f)
			{
				this.HBJJOCHGOPH = 17f;
			}
			this.DEFBJOCJJKF().SetFloat("_BlurDistance", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("CameraFilterPack_AAA_Blood2", this.HoleSize);
			this.OGMEGHKECAH().SetFloat("_Value3", this.HoleSmooth);
			this.NBPKMLMCHFN.SetFloat("finished", this.Color1);
			this.EJDPNJAEAKJ().SetFloat("Warning: Unhandled Event ErrorInfo (251). Set PhotonNetwork.OnEventCall to the method PUN should call for this event.", this.Color2);
			this.HFBJAOFLCJI().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 672f, 677f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600623B RID: 25147 RVA: 0x001DD59A File Offset: 0x001DB79A
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600623C RID: 25148 RVA: 0x001DD59A File Offset: 0x001DB79A
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600623D RID: 25149 RVA: 0x001DD8EF File Offset: 0x001DBAEF
	private void FEKECCBFGMI()
	{
		this.SCShader = Shader.Find("Joystick1Button10");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600623E RID: 25150 RVA: 0x001DD914 File Offset: 0x001DBB14
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 219f)
			{
				this.HBJJOCHGOPH = 1619f;
			}
			this.KEMAALEODNH().SetFloat("#", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_MainTex2", this.HoleSize);
			this.EJDPNJAEAKJ().SetFloat("CurrentTimeLabel", this.HoleSmooth);
			this.ADGHJOHKEHG().SetFloat("Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", this.Color1);
			this.KEMAALEODNH().SetFloat("|", this.Color2);
			this.NBPKMLMCHFN.SetVector("Out {0,4} | In {1,4} | Sum {2,4}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 92f, 953f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600623F RID: 25151 RVA: 0x001DDA14 File Offset: 0x001DBC14
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 721f)
			{
				this.HBJJOCHGOPH = 1693f;
			}
			this.KEMAALEODNH().SetFloat("value", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat(",", this.HoleSize);
			this.KEMAALEODNH().SetFloat("_FarCamera", this.HoleSmooth);
			this.HHIFMIPPMPF().SetFloat("[LevelEditorScene] Error: Timeout :S", this.Color1);
			this.EOCCJGIGEGJ().SetFloat("_MainTex", this.Color2);
			this.DKNJGHFLAIF().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 863f, 247f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006240 RID: 25152 RVA: 0x001DDB13 File Offset: 0x001DBD13
	private void HDMDKOKOOJC()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006241 RID: 25153 RVA: 0x001DDB38 File Offset: 0x001DBD38
	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1726f)
			{
				this.HBJJOCHGOPH = 57f;
			}
			this.LONNIJMNKFB().SetFloat("Could not find RPC with index: ", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value", this.HoleSize);
			this.KEMJNOMIPHN().SetFloat("-1", this.HoleSmooth);
			this.HEHKGPKLAKK().SetFloat("CameraFilterPack/Blend2Camera_LinearLight", this.Color1);
			this.EOCCJGIGEGJ().SetFloat("[PlayerController] ", this.Color2);
			this.KEMAALEODNH().SetVector("0x", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1448f, 961f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006242 RID: 25154 RVA: 0x001DDC37 File Offset: 0x001DBE37
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("(\\[ *\\/ *url *])");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006243 RID: 25155 RVA: 0x001DD59A File Offset: 0x001DB79A
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006244 RID: 25156 RVA: 0x001DD59A File Offset: 0x001DB79A
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006245 RID: 25157 RVA: 0x001DDC5C File Offset: 0x001DBE5C
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1841f)
			{
				this.HBJJOCHGOPH = 668f;
			}
			this.NBPKMLMCHFN.SetFloat("settings_bindings_", this.HBJJOCHGOPH);
			this.KDMBOKLMADJ().SetFloat("_BorderSize", this.HoleSize);
			this.KEMAALEODNH().SetFloat("Had to lookup view that wasn't in photonViewList: ", this.HoleSmooth);
			this.HNICHJCGJOC().SetFloat("IconImage", this.Color1);
			this.EJDPNJAEAKJ().SetFloat("_TimeX", this.Color2);
			this.HEHKGPKLAKK().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1446f, 1306f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006246 RID: 25158 RVA: 0x001DDD5B File Offset: 0x001DBF5B
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Vision_Psycho");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006247 RID: 25159 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06006248 RID: 25160 RVA: 0x001DD59A File Offset: 0x001DB79A
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006249 RID: 25161 RVA: 0x001DD59A File Offset: 0x001DB79A
	private void IABLKKAALGI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600624A RID: 25162 RVA: 0x001DDD80 File Offset: 0x001DBF80
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1009f)
			{
				this.HBJJOCHGOPH = 236f;
			}
			this.HFBJAOFLCJI().SetFloat("Joystick1Button8", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("caret", this.HoleSize);
			this.GKILCDHJFEG().SetFloat("_TimeX", this.HoleSmooth);
			this.KOHGPKOFEJO().SetFloat("DontDestroy", this.Color1);
			this.KBOPGONOCNP().SetFloat("settings.disablestoryboard", this.Color2);
			this.KDMBOKLMADJ().SetVector("Items/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1384f, 536f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600624B RID: 25163 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x0600624C RID: 25164 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x0600624D RID: 25165 RVA: 0x001DDE7F File Offset: 0x001DC07F
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600624E RID: 25166 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x0600624F RID: 25167 RVA: 0x001DDEA3 File Offset: 0x001DC0A3
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006250 RID: 25168 RVA: 0x001DDEDA File Offset: 0x001DC0DA
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-85);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006251 RID: 25169 RVA: 0x001DDF11 File Offset: 0x001DC111
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006252 RID: 25170 RVA: 0x001DDF48 File Offset: 0x001DC148
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1069f)
			{
				this.HBJJOCHGOPH = 223f;
			}
			this.LONNIJMNKFB().SetFloat("_HdrParams", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("CameraFilterPack/Drawing_Halftone", this.HoleSize);
			this.NBPKMLMCHFN.SetFloat("ticket", this.HoleSmooth);
			this.HFBJAOFLCJI().SetFloat("Set Satellite Input", this.Color1);
			this.KOHGPKOFEJO().SetFloat("RequestOwnership(): ", this.Color2);
			this.HEHKGPKLAKK().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1444f, 1513f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006253 RID: 25171 RVA: 0x001DE048 File Offset: 0x001DC248
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1629f)
			{
				this.HBJJOCHGOPH = 1983f;
			}
			this.HEHKGPKLAKK().SetFloat("Set camera (or player) distance. Base player distance - 14", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("maps.", this.HoleSize);
			this.KBOPGONOCNP().SetFloat("My New Mod Pack", this.HoleSmooth);
			this.HHIFMIPPMPF().SetFloat("MenuScene", this.Color1);
			this.GJHLADDCMFF().SetFloat("-", this.Color2);
			this.KOHGPKOFEJO().SetVector("{0:0.0} ms ({1:0.} fps)", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1248f, 628f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006254 RID: 25172 RVA: 0x001DE147 File Offset: 0x001DC347
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006255 RID: 25173 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x06006256 RID: 25174 RVA: 0x001DE17E File Offset: 0x001DC37E
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006257 RID: 25175 RVA: 0x001DD59A File Offset: 0x001DB79A
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006258 RID: 25176 RVA: 0x001DE1B5 File Offset: 0x001DC3B5
	private void OKLAJINHPAN()
	{
		this.SCShader = Shader.Find("Oct");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006259 RID: 25177 RVA: 0x001DE1D9 File Offset: 0x001DC3D9
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find("Player Connected");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600625A RID: 25178 RVA: 0x001DE1FD File Offset: 0x001DC3FD
	private void FLKEJJEGCFA()
	{
		this.SCShader = Shader.Find("{0}{1}{2}={3}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600625B RID: 25179 RVA: 0x0002523B File Offset: 0x0002343B
	private void APKNAPHOFHC()
	{
	}

	// Token: 0x0600625C RID: 25180 RVA: 0x001DE221 File Offset: 0x001DC421
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-125);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600625D RID: 25181 RVA: 0x001DE258 File Offset: 0x001DC458
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 133f)
			{
				this.HBJJOCHGOPH = 100f;
			}
			this.HHIFMIPPMPF().SetFloat("SetPlayerDistance", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat("source", this.HoleSize);
			this.KOHGPKOFEJO().SetFloat("replayData", this.HoleSmooth);
			this.OIMMPLPBLBK().SetFloat("CameraFilterPack/Blend2Camera_DarkerColor", this.Color1);
			this.KAFBNOBOIAJ().SetFloat("_TimeX", this.Color2);
			this.HHIFMIPPMPF().SetVector("_Value6", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 715f, 41f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600625E RID: 25182 RVA: 0x001DE357 File Offset: 0x001DC557
	private void COOHIILCOCO()
	{
		this.SCShader = Shader.Find("SetTrailZoomSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600625F RID: 25183 RVA: 0x001DE37C File Offset: 0x001DC57C
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1441f)
			{
				this.HBJJOCHGOPH = 1255f;
			}
			this.ABHDNGIHBKE().SetFloat("CameraFilterPack/TV_WideScreenHorizontal", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("0,2,true,0", this.HoleSize);
			this.HNICHJCGJOC().SetFloat("Edited hands count", this.HoleSmooth);
			this.EJDPNJAEAKJ().SetFloat("_BlurRadius4", this.Color1);
			this.GJHLADDCMFF().SetFloat("Achievement 21 progress reseted", this.Color2);
			this.KAFBNOBOIAJ().SetVector(": ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 9f, 1472f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006260 RID: 25184 RVA: 0x001DE47C File Offset: 0x001DC67C
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1121f)
			{
				this.HBJJOCHGOPH = 1692f;
			}
			this.DOHGBNPMBKG().SetFloat("Set EnvSprite Image", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("GenerationMenu", this.HoleSize);
			this.KEMJNOMIPHN().SetFloat("Case-Sensitive", this.HoleSmooth);
			this.EJDPNJAEAKJ().SetFloat("value", this.Color1);
			this.EJDPNJAEAKJ().SetFloat(" cannot be used as a 3D LUT.", this.Color2);
			this.HFBJAOFLCJI().SetVector("end", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1928f, 1047f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006261 RID: 25185 RVA: 0x001DE57C File Offset: 0x001DC77C
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 493f)
			{
				this.HBJJOCHGOPH = 381f;
			}
			this.HFBJAOFLCJI().SetFloat("settings_bindings_controller_type", this.HBJJOCHGOPH);
			this.KDMBOKLMADJ().SetFloat("Down", this.HoleSize);
			this.KDMBOKLMADJ().SetFloat("GhostPosY", this.HoleSmooth);
			this.KOHGPKOFEJO().SetFloat("LT", this.Color1);
			this.EJDPNJAEAKJ().SetFloat("L1", this.Color2);
			this.DOHGBNPMBKG().SetVector(".lastCheckpoint.checkpointsUsed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1557f, 1601f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006262 RID: 25186 RVA: 0x001DE67C File Offset: 0x001DC87C
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 633f)
			{
				this.HBJJOCHGOPH = 727f;
			}
			this.KEMAALEODNH().SetFloat("offsets", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("_TimeX", this.HoleSize);
			this.HHIFMIPPMPF().SetFloat("/", this.HoleSmooth);
			this.KBOPGONOCNP().SetFloat("_Value2", this.Color1);
			this.OGMEGHKECAH().SetFloat("X2", this.Color2);
			this.KBOPGONOCNP().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 497f, 323f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006263 RID: 25187 RVA: 0x001DE77B File Offset: 0x001DC97B
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006264 RID: 25188 RVA: 0x001DE7B2 File Offset: 0x001DC9B2
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006265 RID: 25189 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06006266 RID: 25190 RVA: 0x001DE7EC File Offset: 0x001DC9EC
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 511f)
			{
				this.HBJJOCHGOPH = 929f;
			}
			this.HHIFMIPPMPF().SetFloat("TotalHitsScoreText", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("achievements.21.progress", this.HoleSize);
			this.ADGHJOHKEHG().SetFloat("_Green_B", this.HoleSmooth);
			this.HHIFMIPPMPF().SetFloat("Tab2Content", this.Color1);
			this.ABHDNGIHBKE().SetFloat("Set Satellite Radius", this.Color2);
			this.HEHKGPKLAKK().SetVector("SaveButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 523f, 127f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006267 RID: 25191 RVA: 0x001DD59A File Offset: 0x001DB79A
	private void OOGIHDLBBLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006268 RID: 25192 RVA: 0x001DE8EC File Offset: 0x001DCAEC
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1137f)
			{
				this.HBJJOCHGOPH = 1813f;
			}
			this.EOCCJGIGEGJ().SetFloat("BitsData", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("Connecting", this.HoleSize);
			this.KEMAALEODNH().SetFloat(": ", this.HoleSmooth);
			this.EJDPNJAEAKJ().SetFloat("LevelFolderInputField", this.Color1);
			this.OIMMPLPBLBK().SetFloat("maps.", this.Color2);
			this.GJHLADDCMFF().SetVector("menutheme.melancholicose", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 466f, 1909f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006269 RID: 25193 RVA: 0x001DE9EB File Offset: 0x001DCBEB
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600626A RID: 25194 RVA: 0x001DEA24 File Offset: 0x001DCC24
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 953f)
			{
				this.HBJJOCHGOPH = 605f;
			}
			this.HHIFMIPPMPF().SetFloat("#loopnumber ", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("Parent ID", this.HoleSize);
			this.ABHDNGIHBKE().SetFloat("[DiscordController] Join ({0})", this.HoleSmooth);
			this.ADGHJOHKEHG().SetFloat("_CenterX", this.Color1);
			this.OGMEGHKECAH().SetFloat("Set camera (or player) distance. Base player distance - 14", this.Color2);
			this.NBPKMLMCHFN.SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1061f, 1982f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600626B RID: 25195 RVA: 0x001DD59A File Offset: 0x001DB79A
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600626C RID: 25196 RVA: 0x001DEB23 File Offset: 0x001DCD23
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600626D RID: 25197 RVA: 0x001DD59A File Offset: 0x001DB79A
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600626E RID: 25198 RVA: 0x001DEB5C File Offset: 0x001DCD5C
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 579f)
			{
				this.HBJJOCHGOPH = 1409f;
			}
			this.DOHGBNPMBKG().SetFloat("_Noise", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat(" has been disabled as it's not supported on the current platform.", this.HoleSize);
			this.NBPKMLMCHFN.SetFloat(" but this PhotonView does not exist! View was/is ours.", this.HoleSmooth);
			this.KDMBOKLMADJ().SetFloat("Editor/", this.Color1);
			this.HEHKGPKLAKK().SetFloat("PopulateMapsList", this.Color2);
			this.LONNIJMNKFB().SetVector("_Alpha", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1269f, 194f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600626F RID: 25199 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIFLPHLGLFG()
	{
	}

	// Token: 0x06006270 RID: 25200 RVA: 0x001DEC5B File Offset: 0x001DCE5B
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006271 RID: 25201 RVA: 0x001DE221 File Offset: 0x001DC421
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-125);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006272 RID: 25202 RVA: 0x0002523B File Offset: 0x0002343B
	private void COGBDFKOHKK()
	{
	}

	// Token: 0x06006273 RID: 25203 RVA: 0x001DEC7F File Offset: 0x001DCE7F
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006274 RID: 25204 RVA: 0x001DECB8 File Offset: 0x001DCEB8
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 92f)
			{
				this.HBJJOCHGOPH = 1589f;
			}
			this.KBOPGONOCNP().SetFloat("Submit", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("_Saturation", this.HoleSize);
			this.ABHDNGIHBKE().SetFloat("SetSatelliteLerpSpeed", this.HoleSmooth);
			this.HNICHJCGJOC().SetFloat("_Value4", this.Color1);
			this.KBOPGONOCNP().SetFloat("#ok", this.Color2);
			this.EOCCJGIGEGJ().SetVector("SetEnvSpriteImage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1260f, 67f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006275 RID: 25205 RVA: 0x001DEDB8 File Offset: 0x001DCFB8
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1471f)
			{
				this.HBJJOCHGOPH = 1382f;
			}
			this.DKNJGHFLAIF().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("_VignettingColor", this.HoleSize);
			this.DKNJGHFLAIF().SetFloat("Editor/", this.HoleSmooth);
			this.HEHKGPKLAKK().SetFloat("Clears all text from the debug console", this.Color1);
			this.HHIFMIPPMPF().SetFloat("_Value2", this.Color2);
			this.KOHGPKOFEJO().SetVector("settings.fps", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1134f, 1887f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006276 RID: 25206 RVA: 0x001DD59A File Offset: 0x001DB79A
	private void MKFLBEGJJDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006277 RID: 25207 RVA: 0x001DEEB7 File Offset: 0x001DD0B7
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006278 RID: 25208 RVA: 0x001DEEF0 File Offset: 0x001DD0F0
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1962f)
			{
				this.HBJJOCHGOPH = 1349f;
			}
			this.HEHKGPKLAKK().SetFloat("QuickSave", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat("id", this.HoleSize);
			this.EOCCJGIGEGJ().SetFloat("st", this.HoleSmooth);
			this.OGMEGHKECAH().SetFloat("Scene", this.Color1);
			this.NBPKMLMCHFN.SetFloat("mapselector.filter.subscribedonly", this.Color2);
			this.KEMJNOMIPHN().SetVector("Set satellite audio input", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 320f, 939f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006279 RID: 25209 RVA: 0x001DD59A File Offset: 0x001DB79A
	private void NNBCLMJGFEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600627A RID: 25210 RVA: 0x001DD59A File Offset: 0x001DB79A
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600627B RID: 25211 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x0600627C RID: 25212 RVA: 0x001DEFF0 File Offset: 0x001DD1F0
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 89f)
			{
				this.HBJJOCHGOPH = 1570f;
			}
			this.KOHGPKOFEJO().SetFloat("getfloat", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat("Attempting to remove texture that was not allocated: {0}", this.HoleSize);
			this.HHIFMIPPMPF().SetFloat("Fill", this.HoleSmooth);
			this.ADGHJOHKEHG().SetFloat("_YCrop", this.Color1);
			this.HHIFMIPPMPF().SetFloat("AudioSampler", this.Color2);
			this.HEHKGPKLAKK().SetVector("CameraFilterPack/TV_Artefact", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 162f, 1927f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600627D RID: 25213 RVA: 0x001DF0EF File Offset: 0x001DD2EF
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600627E RID: 25214 RVA: 0x001DF126 File Offset: 0x001DD326
	private void PMPKMGKAAJH()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600627F RID: 25215 RVA: 0x001DF14A File Offset: 0x001DD34A
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006280 RID: 25216 RVA: 0x001DF181 File Offset: 0x001DD381
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006281 RID: 25217 RVA: 0x001DF1B8 File Offset: 0x001DD3B8
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006282 RID: 25218 RVA: 0x001DD59A File Offset: 0x001DB79A
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006283 RID: 25219 RVA: 0x001DF1F0 File Offset: 0x001DD3F0
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 148f)
			{
				this.HBJJOCHGOPH = 571f;
			}
			this.HHIFMIPPMPF().SetFloat("OxOD.lastPath", this.HBJJOCHGOPH);
			this.KDMBOKLMADJ().SetFloat("Joystick1Button6", this.HoleSize);
			this.KBOPGONOCNP().SetFloat(" [", this.HoleSmooth);
			this.KAFBNOBOIAJ().SetFloat("<b>Max Score</b>:", this.Color1);
			this.GKILCDHJFEG().SetFloat("settings.volume.game", this.Color2);
			this.LONNIJMNKFB().SetVector("player.xp", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1769f, 355f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006284 RID: 25220 RVA: 0x001DD59A File Offset: 0x001DB79A
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x1700011C RID: 284
	// (get) Token: 0x06006285 RID: 25221 RVA: 0x001DF2EF File Offset: 0x001DD4EF
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

	// Token: 0x06006286 RID: 25222 RVA: 0x001DF328 File Offset: 0x001DD528
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1313f)
			{
				this.HBJJOCHGOPH = 715f;
			}
			this.KOHGPKOFEJO().SetFloat("[SERVER] Kicked ", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", this.HoleSize);
			this.OIMMPLPBLBK().SetFloat("Case-Sensitive", this.HoleSmooth);
			this.DOHGBNPMBKG().SetFloat("_TimeX", this.Color1);
			this.GKILCDHJFEG().SetFloat("-showlogs", this.Color2);
			this.EOCCJGIGEGJ().SetVector(" but this PhotonView does not exist! View was/is ours.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1200f, 1870f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006287 RID: 25223 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x06006288 RID: 25224 RVA: 0x001DF428 File Offset: 0x001DD628
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1833f)
			{
				this.HBJJOCHGOPH = 1904f;
			}
			this.HEHKGPKLAKK().SetFloat("_EdgeThresholdMin", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("_Value3", this.HoleSize);
			this.ADGHJOHKEHG().SetFloat("PointsScoreText", this.HoleSmooth);
			this.LONNIJMNKFB().SetFloat("challenges/", this.Color1);
			this.ABHDNGIHBKE().SetFloat("Editor", this.Color2);
			this.HEHKGPKLAKK().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 4f, 1088f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006289 RID: 25225 RVA: 0x001DF528 File Offset: 0x001DD728
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 203f)
			{
				this.HBJJOCHGOPH = 270f;
			}
			this.DOHGBNPMBKG().SetFloat("{0}sec average:", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("Object ID. Case-Sensitive", this.HoleSize);
			this.ABHDNGIHBKE().SetFloat(" not exist", this.HoleSmooth);
			this.KAFBNOBOIAJ().SetFloat("_NoiseTex", this.Color1);
			this.EOCCJGIGEGJ().SetFloat("/", this.Color2);
			this.HNICHJCGJOC().SetVector(" - ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1511f, 1842f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600628A RID: 25226 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x0600628B RID: 25227 RVA: 0x001DF628 File Offset: 0x001DD828
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 959f)
			{
				this.HBJJOCHGOPH = 1290f;
			}
			this.GKILCDHJFEG().SetFloat("maps.", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("UpdateDownloadingProgress", this.HoleSize);
			this.EJDPNJAEAKJ().SetFloat("skin.", this.HoleSmooth);
			this.DOHGBNPMBKG().SetFloat(", ", this.Color1);
			this.ADGHJOHKEHG().SetFloat("x", this.Color2);
			this.GJHLADDCMFF().SetVector(" not exist", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 512f, 638f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600628C RID: 25228 RVA: 0x001DF728 File Offset: 0x001DD928
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.HoleSize);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.HoleSmooth);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Color1);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Color2);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600628D RID: 25229 RVA: 0x001DF827 File Offset: 0x001DDA27
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_Mirror");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600628E RID: 25230 RVA: 0x001DF84B File Offset: 0x001DDA4B
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600628F RID: 25231 RVA: 0x001DF882 File Offset: 0x001DDA82
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006290 RID: 25232 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x06006291 RID: 25233 RVA: 0x001DDEDA File Offset: 0x001DC0DA
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-85);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006292 RID: 25234 RVA: 0x001DF8B9 File Offset: 0x001DDAB9
	private void MDNHCLKNCLE()
	{
		this.SCShader = Shader.Find("Editor/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006293 RID: 25235 RVA: 0x001DD59A File Offset: 0x001DB79A
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006294 RID: 25236 RVA: 0x001DF8DD File Offset: 0x001DDADD
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006295 RID: 25237 RVA: 0x001DF914 File Offset: 0x001DDB14
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1599f)
			{
				this.HBJJOCHGOPH = 1077f;
			}
			this.KBOPGONOCNP().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("GlassDistortion", this.HoleSize);
			this.DOHGBNPMBKG().SetFloat("HighScaleShot", this.HoleSmooth);
			this.ADGHJOHKEHG().SetFloat("_TimeX", this.Color1);
			this.DEFBJOCJJKF().SetFloat("_OcclusionTexture", this.Color2);
			this.ABHDNGIHBKE().SetVector("SpeedSlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1901f, 1704f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006296 RID: 25238 RVA: 0x001DFA14 File Offset: 0x001DDC14
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1524f)
			{
				this.HBJJOCHGOPH = 558f;
			}
			this.LONNIJMNKFB().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("workshop.", this.HoleSize);
			this.DKNJGHFLAIF().SetFloat("StartCanvas", this.HoleSmooth);
			this.GKILCDHJFEG().SetFloat("SupportLogger OnCreatedRoom(", this.Color1);
			this.ADGHJOHKEHG().SetFloat("_Value2", this.Color2);
			this.DOHGBNPMBKG().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1455f, 32f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006297 RID: 25239 RVA: 0x001DFB14 File Offset: 0x001DDD14
	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 878f)
			{
				this.HBJJOCHGOPH = 1253f;
			}
			this.ADGHJOHKEHG().SetFloat("_Jitter", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("/", this.HoleSize);
			this.KOHGPKOFEJO().SetFloat("SetSatelliteTrailMinVertexDistance", this.HoleSmooth);
			this.GKILCDHJFEG().SetFloat("RULES", this.Color1);
			this.GKILCDHJFEG().SetFloat("_MainTexBlurred", this.Color2);
			this.GJHLADDCMFF().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1816f, 1059f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006298 RID: 25240 RVA: 0x001DFC13 File Offset: 0x001DDE13
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find(" Owner called.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006299 RID: 25241 RVA: 0x001DD59A File Offset: 0x001DB79A
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600629A RID: 25242 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x0600629B RID: 25243 RVA: 0x001DFC37 File Offset: 0x001DDE37
	private void JKBMKPDGCHG()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Edge_Sobel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600629C RID: 25244 RVA: 0x001DD59A File Offset: 0x001DB79A
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600629D RID: 25245 RVA: 0x001DFC5B File Offset: 0x001DDE5B
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("Bad parameters for reset! Use \"reset <challengeid>\"");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x040009E9 RID: 2537
	public Shader SCShader;

	// Token: 0x040009EA RID: 2538
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040009EB RID: 2539
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040009EC RID: 2540
	private Material BJFKDHHMLJH;

	// Token: 0x040009ED RID: 2541
	[Range(0.01f, 1f)]
	public float HoleSize = 0.6f;

	// Token: 0x040009EE RID: 2542
	[Range(-1f, 1f)]
	public float HoleSmooth = 0.3f;

	// Token: 0x040009EF RID: 2543
	[Range(-2f, 2f)]
	public float Color1 = 0.2f;

	// Token: 0x040009F0 RID: 2544
	[Range(-2f, 2f)]
	public float Color2 = 0.9f;
}
