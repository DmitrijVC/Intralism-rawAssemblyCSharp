using System;
using UnityEngine;

// Token: 0x02000073 RID: 115
[AddComponentMenu("Camera Filter Pack/Colors/RGB")]
[ExecuteInEditMode]
public class CameraFilterPack_Color_RGB : MonoBehaviour
{
	// Token: 0x06002071 RID: 8305 RVA: 0x000BD68D File Offset: 0x000BB88D
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002072 RID: 8306 RVA: 0x000BD6C4 File Offset: 0x000BB8C4
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find("[EditorEvent] Exception: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002073 RID: 8307 RVA: 0x000BD6E8 File Offset: 0x000BB8E8
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002074 RID: 8308 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x06002075 RID: 8309 RVA: 0x000BD705 File Offset: 0x000BB905
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002076 RID: 8310 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06002077 RID: 8311 RVA: 0x000BD6E8 File Offset: 0x000BB8E8
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002078 RID: 8312 RVA: 0x000BD73C File Offset: 0x000BB93C
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Color_RGB");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002079 RID: 8313 RVA: 0x000BD6E8 File Offset: 0x000BB8E8
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000059 RID: 89
	// (get) Token: 0x0600207A RID: 8314 RVA: 0x000BD760 File Offset: 0x000BB960
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

	// Token: 0x0600207B RID: 8315 RVA: 0x000BD6E8 File Offset: 0x000BB8E8
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600207C RID: 8316 RVA: 0x000BD797 File Offset: 0x000BB997
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)100;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600207D RID: 8317 RVA: 0x000BD7CE File Offset: 0x000BB9CE
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-82);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600207E RID: 8318 RVA: 0x000BD805 File Offset: 0x000BBA05
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("source");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600207F RID: 8319 RVA: 0x000BD6E8 File Offset: 0x000BB8E8
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002080 RID: 8320 RVA: 0x000BD829 File Offset: 0x000BBA29
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002081 RID: 8321 RVA: 0x000BD6E8 File Offset: 0x000BB8E8
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002082 RID: 8322 RVA: 0x000BD860 File Offset: 0x000BBA60
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002083 RID: 8323 RVA: 0x000BD6E8 File Offset: 0x000BB8E8
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002084 RID: 8324 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06002085 RID: 8325 RVA: 0x000BD897 File Offset: 0x000BBA97
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Special_Bubble");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002086 RID: 8326 RVA: 0x000BD6E8 File Offset: 0x000BB8E8
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002087 RID: 8327 RVA: 0x000BD8BC File Offset: 0x000BBABC
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 646f)
			{
				this.HBJJOCHGOPH = 688f;
			}
			this.AELJLBOJAIL().SetFloat("LevelURLInputField", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetColor("finished", this.ColorRGB);
			this.MFHPKGICPIO().SetVector("MapEditorScene", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 377f, 1818f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002088 RID: 8328 RVA: 0x000BD979 File Offset: 0x000BBB79
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)80;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002089 RID: 8329 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600208A RID: 8330 RVA: 0x000BD9B0 File Offset: 0x000BBBB0
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1562f)
			{
				this.HBJJOCHGOPH = 1571f;
			}
			this.DONENAMLFLF().SetFloat("settings.cameramovements", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetColor("Adreno", this.ColorRGB);
			this.FEAEGGCNIAA().SetVector(" ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1455f, 1215f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600208B RID: 8331 RVA: 0x000BDA6D File Offset: 0x000BBC6D
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("R1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600208C RID: 8332 RVA: 0x000BDA91 File Offset: 0x000BBC91
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600208D RID: 8333 RVA: 0x000BDAB5 File Offset: 0x000BBCB5
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("SupportLogger OnJoinedLobby(");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600208E RID: 8334 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x0600208F RID: 8335 RVA: 0x000BD6E8 File Offset: 0x000BB8E8
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002090 RID: 8336 RVA: 0x000BDAD9 File Offset: 0x000BBCD9
	private Material GHHPOGODBHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002091 RID: 8337 RVA: 0x000BDB10 File Offset: 0x000BBD10
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-98);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002092 RID: 8338 RVA: 0x000BDB48 File Offset: 0x000BBD48
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 870f)
			{
				this.HBJJOCHGOPH = 1013f;
			}
			this.AELJLBOJAIL().SetFloat("_Extra2", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetColor("workshop.", this.ColorRGB);
			this.IIJMIPBMMBF().SetVector(". ActorNr: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1049f, 1595f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002093 RID: 8339 RVA: 0x000BDC05 File Offset: 0x000BBE05
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find("EventMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002094 RID: 8340 RVA: 0x000BD6E8 File Offset: 0x000BB8E8
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002095 RID: 8341 RVA: 0x000BDC2C File Offset: 0x000BBE2C
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1958f)
			{
				this.HBJJOCHGOPH = 564f;
			}
			this.ACHNOHCLGOO().SetFloat("#yes", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetColor("mapselector.orderby", this.ColorRGB);
			this.MFHPKGICPIO().SetVector("_EmissionGain", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 581f, 1125f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002097 RID: 8343 RVA: 0x000BDD18 File Offset: 0x000BBF18
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1485f)
			{
				this.HBJJOCHGOPH = 827f;
			}
			this.AELJLBOJAIL().SetFloat("SpawnObj", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetColor("ItemNameText", this.ColorRGB);
			this.DONENAMLFLF().SetVector(".", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1614f, 1582f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002098 RID: 8344 RVA: 0x000BDDD5 File Offset: 0x000BBFD5
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002099 RID: 8345 RVA: 0x000BDE0C File Offset: 0x000BC00C
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1142f)
			{
				this.HBJJOCHGOPH = 783f;
			}
			this.BFGNMFCNDBC().SetFloat("SetSpeed", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetColor("ChallengesButton", this.ColorRGB);
			this.EFDEIFCDAFG().SetVector("00", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1259f, 831f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600209A RID: 8346 RVA: 0x000BDEC9 File Offset: 0x000BC0C9
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600209B RID: 8347 RVA: 0x000BD6E8 File Offset: 0x000BB8E8
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600209C RID: 8348 RVA: 0x000BDF00 File Offset: 0x000BC100
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)76;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600209D RID: 8349 RVA: 0x000BDF37 File Offset: 0x000BC137
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600209E RID: 8350 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x0600209F RID: 8351 RVA: 0x000BDF70 File Offset: 0x000BC170
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 891f)
			{
				this.HBJJOCHGOPH = 1546f;
			}
			this.EFDEIFCDAFG().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetColor("Set Particles Emission", this.ColorRGB);
			this.EFDEIFCDAFG().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1789f, 1472f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060020A0 RID: 8352 RVA: 0x000BE02D File Offset: 0x000BC22D
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060020A1 RID: 8353 RVA: 0x000BE064 File Offset: 0x000BC264
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1181f)
			{
				this.HBJJOCHGOPH = 759f;
			}
			this.JFDGLLEOPGB().SetFloat("In Network lobby", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetColor("There are {0} reported logs.", this.ColorRGB);
			this.IIJMIPBMMBF().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 839f, 188f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060020A2 RID: 8354 RVA: 0x000BE124 File Offset: 0x000BC324
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1765f)
			{
				this.HBJJOCHGOPH = 463f;
			}
			this.AELJLBOJAIL().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.CEKJODEAMGB().SetColor("[PlayerController] ", this.ColorRGB);
			this.NFKFAAHHLLM().SetVector("GhostPosY", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 386f, 1682f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060020A3 RID: 8355 RVA: 0x000BE1E1 File Offset: 0x000BC3E1
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("PLEASE WAIT");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060020A4 RID: 8356 RVA: 0x000BE208 File Offset: 0x000BC408
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
			this.NBPKMLMCHFN.SetColor("_ColorRGB", this.ColorRGB);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060020A5 RID: 8357 RVA: 0x000BE2C5 File Offset: 0x000BC4C5
	private void FANADGBGCPI()
	{
		this.SCShader = Shader.Find("offline");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060020A6 RID: 8358 RVA: 0x000BE2E9 File Offset: 0x000BC4E9
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060020A7 RID: 8359 RVA: 0x000BD6E8 File Offset: 0x000BB8E8
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060020A8 RID: 8360 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x060020A9 RID: 8361 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x060020AA RID: 8362 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x060020AB RID: 8363 RVA: 0x000BE320 File Offset: 0x000BC520
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find(" not exist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060020AC RID: 8364 RVA: 0x000BE344 File Offset: 0x000BC544
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1408f)
			{
				this.HBJJOCHGOPH = 1369f;
			}
			this.HFBJAOFLCJI().SetFloat("DisableStoryboardToggle", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetColor("RestartButton", this.ColorRGB);
			this.HNICHJCGJOC().SetVector("YES", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 840f, 760f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060020AD RID: 8365 RVA: 0x000BD6E8 File Offset: 0x000BB8E8
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060020AE RID: 8366 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x060020AF RID: 8367 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x060020B0 RID: 8368 RVA: 0x000BE401 File Offset: 0x000BC601
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("[CraftingPanel] Init");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060020B1 RID: 8369 RVA: 0x000BE425 File Offset: 0x000BC625
	private Material CFCPHFMKHII()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060020B2 RID: 8370 RVA: 0x000BD6E8 File Offset: 0x000BB8E8
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060020B3 RID: 8371 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x060020B4 RID: 8372 RVA: 0x000BE45C File Offset: 0x000BC65C
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060020B5 RID: 8373 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x060020B6 RID: 8374 RVA: 0x000BE493 File Offset: 0x000BC693
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("???");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060020B7 RID: 8375 RVA: 0x000BE4B8 File Offset: 0x000BC6B8
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 849f)
			{
				this.HBJJOCHGOPH = 811f;
			}
			this.DONENAMLFLF().SetFloat("[LevelEditorScene] Creating new item...", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetColor("Use ticket: ", this.ColorRGB);
			this.FEAEGGCNIAA().SetVector("settings.shaders.bloomintencity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1157f, 1109f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060020B8 RID: 8376 RVA: 0x000BE575 File Offset: 0x000BC775
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060020B9 RID: 8377 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x060020BA RID: 8378 RVA: 0x000BE5AC File Offset: 0x000BC7AC
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060020BB RID: 8379 RVA: 0x000BE5E3 File Offset: 0x000BC7E3
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-68);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060020BC RID: 8380 RVA: 0x000BE61A File Offset: 0x000BC81A
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("_Green_R");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060020BD RID: 8381 RVA: 0x000BE640 File Offset: 0x000BC840
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1605f)
			{
				this.HBJJOCHGOPH = 479f;
			}
			this.NFKFAAHHLLM().SetFloat("float,1", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetColor("CameraFilterPack_RainFX_Anm2", this.ColorRGB);
			this.CEKJODEAMGB().SetVector("CameraFilterPack/Vision_Blood", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 286f, 812f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060020BE RID: 8382 RVA: 0x000BE6FD File Offset: 0x000BC8FD
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060020BF RID: 8383 RVA: 0x000BE734 File Offset: 0x000BC934
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("\"");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060020C0 RID: 8384 RVA: 0x000BE758 File Offset: 0x000BC958
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("_NeutralTonemapperParams2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060020C1 RID: 8385 RVA: 0x000BD6E8 File Offset: 0x000BB8E8
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x04000438 RID: 1080
	public Shader SCShader;

	// Token: 0x04000439 RID: 1081
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400043A RID: 1082
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400043B RID: 1083
	private Material BJFKDHHMLJH;

	// Token: 0x0400043C RID: 1084
	public Color ColorRGB = new Color(1f, 1f, 1f);
}
