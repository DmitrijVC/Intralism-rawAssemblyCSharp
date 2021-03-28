using System;
using UnityEngine;

// Token: 0x020000A0 RID: 160
[AddComponentMenu("Camera Filter Pack/Drawing/Lines")]
[ExecuteInEditMode]
public class CameraFilterPack_Drawing_Lines : MonoBehaviour
{
	// Token: 0x06003012 RID: 12306 RVA: 0x000FFC5F File Offset: 0x000FDE5F
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003013 RID: 12307 RVA: 0x000FFC5F File Offset: 0x000FDE5F
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003014 RID: 12308 RVA: 0x000FFC7C File Offset: 0x000FDE7C
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003015 RID: 12309 RVA: 0x000FFCA0 File Offset: 0x000FDEA0
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("_PositionX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003016 RID: 12310 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x06003017 RID: 12311 RVA: 0x000FFCC4 File Offset: 0x000FDEC4
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1067f)
			{
				this.HBJJOCHGOPH = 692f;
			}
			this.NBPKMLMCHFN.SetFloat("InfoText", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("_FixDistance", this.Number);
			this.DNLMFEGJJDD().SetFloat("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", this.Random);
			this.JLHLHKPHDFO().SetFloat("#md5submitionfailed: ", this.AOEEPOHCCHE);
			this.FAIFBBGFAIB().SetFloat("x", this.CCIENBFIKKH);
			this.JLHLHKPHDFO().SetVector("_Value7", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 300f, 1030f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003018 RID: 12312 RVA: 0x000FFDC4 File Offset: 0x000FDFC4
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 836f)
			{
				this.HBJJOCHGOPH = 1767f;
			}
			this.PDEAHJPOMEF().SetFloat("Committing changes...", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("[LocalizationService] All languages: ", this.Number);
			this.BFGNMFCNDBC().SetFloat("_EmissionGain", this.Random);
			this.BFGNMFCNDBC().SetFloat("Item ", this.AOEEPOHCCHE);
			this.BFGNMFCNDBC().SetFloat("_FixDistance", this.CCIENBFIKKH);
			this.HKHBBBFLGJH().SetVector("FinalScoreSmallText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1649f, 1018f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003019 RID: 12313 RVA: 0x000FFEC3 File Offset: 0x000FE0C3
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600301A RID: 12314 RVA: 0x000FFEFC File Offset: 0x000FE0FC
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1888f)
			{
				this.HBJJOCHGOPH = 659f;
			}
			this.MFHPKGICPIO().SetFloat("_ColoredChange", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("Add Environment Sprite", this.Number);
			this.JLHLHKPHDFO().SetFloat("_Value7", this.Random);
			this.JLHLHKPHDFO().SetFloat(".", this.AOEEPOHCCHE);
			this.FAIFBBGFAIB().SetFloat("_Value4", this.CCIENBFIKKH);
			this.FLOHGDECHHH().SetVector("LevelNameInputField", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1859f, 674f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600301B RID: 12315 RVA: 0x000FFFFB File Offset: 0x000FE1FB
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600301C RID: 12316 RVA: 0x00100032 File Offset: 0x000FE232
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600301D RID: 12317 RVA: 0x00100069 File Offset: 0x000FE269
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)101;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600301E RID: 12318 RVA: 0x001000A0 File Offset: 0x000FE2A0
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1149f)
			{
				this.HBJJOCHGOPH = 793f;
			}
			this.PDEAHJPOMEF().SetFloat("[DiscordController] Disconnect {0}: {1}", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat(" GO:", this.Number);
			this.FAIFBBGFAIB().SetFloat(" Owner called.", this.Random);
			this.NBPKMLMCHFN.SetFloat("#pleasewait", this.AOEEPOHCCHE);
			this.BFGNMFCNDBC().SetFloat("{0:x2}", this.CCIENBFIKKH);
			this.PDEAHJPOMEF().SetVector("_Bloom5", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1260f, 1970f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600301F RID: 12319 RVA: 0x000FFC5F File Offset: 0x000FDE5F
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003020 RID: 12320 RVA: 0x001001A0 File Offset: 0x000FE3A0
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1956f)
			{
				this.HBJJOCHGOPH = 1922f;
			}
			this.MFHPKGICPIO().SetFloat("colorD", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("Editor/", this.Number);
			this.MFHPKGICPIO().SetFloat("Value", this.Random);
			this.DNLMFEGJJDD().SetFloat("_DiffuseColor", this.AOEEPOHCCHE);
			this.FLOHGDECHHH().SetFloat(", ", this.CCIENBFIKKH);
			this.MFHPKGICPIO().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1377f, 63f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003021 RID: 12321 RVA: 0x000FFC5F File Offset: 0x000FDE5F
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003022 RID: 12322 RVA: 0x000FFEC3 File Offset: 0x000FE0C3
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003023 RID: 12323 RVA: 0x001002A0 File Offset: 0x000FE4A0
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1979f)
			{
				this.HBJJOCHGOPH = 1971f;
			}
			this.DNLMFEGJJDD().SetFloat("settings.volume.editor", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("???", this.Number);
			this.NBPKMLMCHFN.SetFloat("PossibleMapMaxScoreText", this.Random);
			this.PDEAHJPOMEF().SetFloat("OpGetGameList not sent. Lobby cannot be null.", this.AOEEPOHCCHE);
			this.HKHBBBFLGJH().SetFloat("inventory.selected.", this.CCIENBFIKKH);
			this.MICHFGAOPKM().SetVector("_Quality", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1367f, 208f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003024 RID: 12324 RVA: 0x000FFC5F File Offset: 0x000FDE5F
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003025 RID: 12325 RVA: 0x000FFC5F File Offset: 0x000FDE5F
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003026 RID: 12326 RVA: 0x000FFC5F File Offset: 0x000FDE5F
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003027 RID: 12327 RVA: 0x0010039F File Offset: 0x000FE59F
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003028 RID: 12328 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003029 RID: 12329 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x0600302A RID: 12330 RVA: 0x001003D8 File Offset: 0x000FE5D8
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 475f)
			{
				this.HBJJOCHGOPH = 1638f;
			}
			this.PDEAHJPOMEF().SetFloat("ready", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("_Value4", this.Number);
			this.PDEAHJPOMEF().SetFloat("Connected to gameserver.", this.Random);
			this.DNLMFEGJJDD().SetFloat("-", this.AOEEPOHCCHE);
			this.DNLMFEGJJDD().SetFloat("_Value2", this.CCIENBFIKKH);
			this.FAIFBBGFAIB().SetVector("_DepthLevel", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 428f, 1415f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600302B RID: 12331 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x0600302C RID: 12332 RVA: 0x000FFC5F File Offset: 0x000FDE5F
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600302D RID: 12333 RVA: 0x001004D8 File Offset: 0x000FE6D8
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 998f)
			{
				this.HBJJOCHGOPH = 1138f;
			}
			this.MFHPKGICPIO().SetFloat("https://bugs.khb-soft.ru/set_project.php?project_id=1", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("Left Stick Click", this.Number);
			this.JLHLHKPHDFO().SetFloat("#finished", this.Random);
			this.HKHBBBFLGJH().SetFloat("_PColor2", this.AOEEPOHCCHE);
			this.HKHBBBFLGJH().SetFloat("_Speed", this.CCIENBFIKKH);
			this.PDEAHJPOMEF().SetVector("type", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 768f, 39f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600302E RID: 12334 RVA: 0x001005D7 File Offset: 0x000FE7D7
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("_BlurCoe");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600302F RID: 12335 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06003030 RID: 12336 RVA: 0x001005FC File Offset: 0x000FE7FC
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1586f)
			{
				this.HBJJOCHGOPH = 1068f;
			}
			this.FAIFBBGFAIB().SetFloat("shader.invert", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("_MainTex2", this.Number);
			this.BFGNMFCNDBC().SetFloat("_Value2", this.Random);
			this.HKHBBBFLGJH().SetFloat("_ScreenResolution", this.AOEEPOHCCHE);
			this.PDEAHJPOMEF().SetFloat("_Value1", this.CCIENBFIKKH);
			this.JLHLHKPHDFO().SetVector("#onrankchangedowntext", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1472f, 1833f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003031 RID: 12337 RVA: 0x000FFC5F File Offset: 0x000FDE5F
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003032 RID: 12338 RVA: 0x001006FB File Offset: 0x000FE8FB
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_Lines");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x17000085 RID: 133
	// (get) Token: 0x06003033 RID: 12339 RVA: 0x0010071F File Offset: 0x000FE91F
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

	// Token: 0x06003034 RID: 12340 RVA: 0x000FFC5F File Offset: 0x000FDE5F
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003035 RID: 12341 RVA: 0x00100758 File Offset: 0x000FE958
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Number);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Random);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.AOEEPOHCCHE);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003036 RID: 12342 RVA: 0x000FFC5F File Offset: 0x000FDE5F
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003037 RID: 12343 RVA: 0x00100857 File Offset: 0x000FEA57
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("Set Satellite Color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003038 RID: 12344 RVA: 0x0010087B File Offset: 0x000FEA7B
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003039 RID: 12345 RVA: 0x001008B2 File Offset: 0x000FEAB2
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("[PlayerBase] Starting new round");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600303A RID: 12346 RVA: 0x001008D6 File Offset: 0x000FEAD6
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)109;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600303B RID: 12347 RVA: 0x0010090D File Offset: 0x000FEB0D
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600303D RID: 12349 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x0600303E RID: 12350 RVA: 0x00100984 File Offset: 0x000FEB84
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1132f)
			{
				this.HBJJOCHGOPH = 1325f;
			}
			this.BFGNMFCNDBC().SetFloat("Joystick1Button10", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("player.currentrank", this.Number);
			this.MFHPKGICPIO().SetFloat("-1", this.Random);
			this.FLOHGDECHHH().SetFloat("delete", this.AOEEPOHCCHE);
			this.HKHBBBFLGJH().SetFloat("SelectionBox component must be placed on a canvas in Screen Space Overlay mode.", this.CCIENBFIKKH);
			this.DNLMFEGJJDD().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1722f, 428f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600303F RID: 12351 RVA: 0x000FFC5F File Offset: 0x000FDE5F
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003040 RID: 12352 RVA: 0x000FFC5F File Offset: 0x000FDE5F
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003041 RID: 12353 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06003042 RID: 12354 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x06003043 RID: 12355 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x06003044 RID: 12356 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06003045 RID: 12357 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x06003046 RID: 12358 RVA: 0x00100A83 File Offset: 0x000FEC83
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003047 RID: 12359 RVA: 0x00100AA7 File Offset: 0x000FECA7
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003048 RID: 12360 RVA: 0x00100A83 File Offset: 0x000FEC83
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003049 RID: 12361 RVA: 0x00100ACB File Offset: 0x000FECCB
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600304A RID: 12362 RVA: 0x00100AEF File Offset: 0x000FECEF
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find(" By: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600304B RID: 12363 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x0600304C RID: 12364 RVA: 0x00100B13 File Offset: 0x000FED13
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("key");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600304D RID: 12365 RVA: 0x000FFC5F File Offset: 0x000FDE5F
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x04000580 RID: 1408
	public Shader SCShader;

	// Token: 0x04000581 RID: 1409
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000582 RID: 1410
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000583 RID: 1411
	private Material BJFKDHHMLJH;

	// Token: 0x04000584 RID: 1412
	[Range(0.1f, 10f)]
	public float Number = 1f;

	// Token: 0x04000585 RID: 1413
	[Range(0f, 1f)]
	public float Random = 0.5f;

	// Token: 0x04000586 RID: 1414
	[Range(0f, 10f)]
	private float AOEEPOHCCHE = 1f;

	// Token: 0x04000587 RID: 1415
	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;
}
