using System;
using UnityEngine;

// Token: 0x02000116 RID: 278
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Glitch/Compression FX")]
public class CameraFilterPack_TV_CompressionFX : MonoBehaviour
{
	// Token: 0x060056CE RID: 22222 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x060056CF RID: 22223 RVA: 0x001B0ABC File Offset: 0x001AECBC
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1236f)
			{
				this.HBJJOCHGOPH = 1922f;
			}
			this.FEAEGGCNIAA().SetFloat("BitsData", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("_EmissionColor", this.Parasite);
			this.FEAEGGCNIAA().SetVector(". Verify the Prefab is in a Resources folder (and not in a subfolder)", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1767f, 110f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060056D0 RID: 22224 RVA: 0x001B0B79 File Offset: 0x001AED79
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060056D1 RID: 22225 RVA: 0x001B0B96 File Offset: 0x001AED96
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("_MainTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060056D2 RID: 22226 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x060056D3 RID: 22227 RVA: 0x001B0B79 File Offset: 0x001AED79
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060056D4 RID: 22228 RVA: 0x001B0BBA File Offset: 0x001AEDBA
	private void CEAGPJBGBMH()
	{
		this.SCShader = Shader.Find("player.xp");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060056D5 RID: 22229 RVA: 0x001B0B79 File Offset: 0x001AED79
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060056D6 RID: 22230 RVA: 0x0002523B File Offset: 0x0002343B
	private void LKJMIODJGCM()
	{
	}

	// Token: 0x060056D8 RID: 22232 RVA: 0x001B0B79 File Offset: 0x001AED79
	private void FGBDGGCBFLP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060056D9 RID: 22233 RVA: 0x001B0B79 File Offset: 0x001AED79
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060056DA RID: 22234 RVA: 0x001B0BFC File Offset: 0x001AEDFC
	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 105f)
			{
				this.HBJJOCHGOPH = 230f;
			}
			this.DOMEEFLPEPJ().SetFloat("icon", this.HBJJOCHGOPH);
			this.LMLENGFLEBD().SetFloat(".completedCount", this.Parasite);
			this.MNLKBFFKHIE().SetVector("BloomShaderValueSlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1455f, 154f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060056DB RID: 22235 RVA: 0x001B0CB9 File Offset: 0x001AEEB9
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_CompressionFX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060056DC RID: 22236 RVA: 0x001B0B79 File Offset: 0x001AED79
	private void AMHEJBMLFNM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060056DD RID: 22237 RVA: 0x001B0CE0 File Offset: 0x001AEEE0
	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1008f)
			{
				this.HBJJOCHGOPH = 1024f;
			}
			this.FEAEGGCNIAA().SetFloat("offsets", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("error", this.Parasite);
			this.KLKILLCHJHO().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 113f, 872f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060056DE RID: 22238 RVA: 0x001B0D9D File Offset: 0x001AEF9D
	private void ADPLHDFJFID()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Gradients_FireGradient");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060056DF RID: 22239 RVA: 0x001B0DC4 File Offset: 0x001AEFC4
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1264f)
			{
				this.HBJJOCHGOPH = 524f;
			}
			this.ELBMIEOIABA().SetFloat("Image", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Image", this.Parasite);
			this.EHDJJANLINB().SetVector("settings.cameramovements", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1091f, 1857f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060056E0 RID: 22240 RVA: 0x001B0E81 File Offset: 0x001AF081
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060056E1 RID: 22241 RVA: 0x001B0EA5 File Offset: 0x001AF0A5
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060056E2 RID: 22242 RVA: 0x001B0EDC File Offset: 0x001AF0DC
	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 952f)
			{
				this.HBJJOCHGOPH = 535f;
			}
			this.FEAEGGCNIAA().SetFloat("OperationResponse unhandled: {0}", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("_Screen", this.Parasite);
			this.OCMBHMLNCEK().SetVector("SetSunSensitivity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1708f, 268f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060056E3 RID: 22243 RVA: 0x0002523B File Offset: 0x0002343B
	private void AKCADICOFDD()
	{
	}

	// Token: 0x060056E4 RID: 22244 RVA: 0x001B0F99 File Offset: 0x001AF199
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060056E5 RID: 22245 RVA: 0x001B0FD0 File Offset: 0x001AF1D0
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Lut_Simple");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060056E6 RID: 22246 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x060056E7 RID: 22247 RVA: 0x001B0FF4 File Offset: 0x001AF1F4
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060056E8 RID: 22248 RVA: 0x001B0B79 File Offset: 0x001AED79
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060056E9 RID: 22249 RVA: 0x001B0B79 File Offset: 0x001AED79
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060056EA RID: 22250 RVA: 0x001B102C File Offset: 0x001AF22C
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1564f)
			{
				this.HBJJOCHGOPH = 1606f;
			}
			this.CFEDGDGBCHE().SetFloat("offsets", this.HBJJOCHGOPH);
			this.DOMEEFLPEPJ().SetFloat("[LevelEditorScene] Map submitted!", this.Parasite);
			this.PGPEMMBJOOG().SetVector("UI Extensions/UIScreen", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 410f, 1841f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060056EB RID: 22251 RVA: 0x001B0B79 File Offset: 0x001AED79
	private void FKDEEJFNNJC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060056EC RID: 22252 RVA: 0x001B10E9 File Offset: 0x001AF2E9
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("_Value6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060056ED RID: 22253 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x060056EE RID: 22254 RVA: 0x001B110D File Offset: 0x001AF30D
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060056EF RID: 22255 RVA: 0x001B1144 File Offset: 0x001AF344
	private void HNMIAKKBMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 784f)
			{
				this.HBJJOCHGOPH = 1058f;
			}
			this.KLKILLCHJHO().SetFloat("_FixDistance", this.HBJJOCHGOPH);
			this.LPPEPKGFOEM().SetFloat("_EmissionColor", this.Parasite);
			this.ELBMIEOIABA().SetVector("FileMenu", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 458f, 1729f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060056F0 RID: 22256 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x060056F1 RID: 22257 RVA: 0x001B1201 File Offset: 0x001AF401
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060056F2 RID: 22258 RVA: 0x001B1238 File Offset: 0x001AF438
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060056F3 RID: 22259 RVA: 0x001B126F File Offset: 0x001AF46F
	private void MJEFMIPLFAB()
	{
		this.SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060056F4 RID: 22260 RVA: 0x001B1293 File Offset: 0x001AF493
	private void KHIGHFJKPFG()
	{
		this.SCShader = Shader.Find("_BlurRadius");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060056F5 RID: 22261 RVA: 0x001B12B7 File Offset: 0x001AF4B7
	private void MDNHCLKNCLE()
	{
		this.SCShader = Shader.Find("challenges.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060056F6 RID: 22262 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x060056F7 RID: 22263 RVA: 0x0002523B File Offset: 0x0002343B
	private void ANKIJGCGCBF()
	{
	}

	// Token: 0x060056F8 RID: 22264 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIFLPHLGLFG()
	{
	}

	// Token: 0x060056F9 RID: 22265 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x060056FA RID: 22266 RVA: 0x001B12DC File Offset: 0x001AF4DC
	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1512f)
			{
				this.HBJJOCHGOPH = 559f;
			}
			this.OHKGGPFGLFD().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("_Red_C", this.Parasite);
			this.OCMBHMLNCEK().SetVector("UndoButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 738f, 704f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060056FB RID: 22267 RVA: 0x001B1399 File Offset: 0x001AF599
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("[PlayerBase] Starting new round");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060056FC RID: 22268 RVA: 0x001B13C0 File Offset: 0x001AF5C0
	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 924f)
			{
				this.HBJJOCHGOPH = 1368f;
			}
			this.MNLKBFFKHIE().SetFloat("[Down]", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("arc", this.Parasite);
			this.MNLKBFFKHIE().SetVector("[MapEditor] Loading map: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1079f, 1345f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060056FD RID: 22269 RVA: 0x001B1480 File Offset: 0x001AF680
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1497f)
			{
				this.HBJJOCHGOPH = 1904f;
			}
			this.MNLKBFFKHIE().SetFloat("AddEnvironmentSprite", this.HBJJOCHGOPH);
			this.MNLKBFFKHIE().SetFloat("settings.arcshitsoundtimedelay", this.Parasite);
			this.CFEDGDGBCHE().SetVector("couldn't be found!", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 539f, 1333f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060056FE RID: 22270 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x060056FF RID: 22271 RVA: 0x001B153D File Offset: 0x001AF73D
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005700 RID: 22272 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06005701 RID: 22273 RVA: 0x001B1574 File Offset: 0x001AF774
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 842f)
			{
				this.HBJJOCHGOPH = 940f;
			}
			this.DOHGBNPMBKG().SetFloat("float,0.5", this.HBJJOCHGOPH);
			this.DOMEEFLPEPJ().SetFloat("<start_index> <end_index>", this.Parasite);
			this.OHKGGPFGLFD().SetVector("_MainTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1401f, 1964f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPPEPKGFOEM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005702 RID: 22274 RVA: 0x001B1631 File Offset: 0x001AF831
	private Material KLKILLCHJHO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005703 RID: 22275 RVA: 0x001B1668 File Offset: 0x001AF868
	private void GOANCMNGDLE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1754f)
			{
				this.HBJJOCHGOPH = 1768f;
			}
			this.HHIFMIPPMPF().SetFloat("MAPS NOT FOUND", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("note.7", this.Parasite);
			this.LMLENGFLEBD().SetVector("_Blue_R", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 21f, 1010f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005704 RID: 22276 RVA: 0x001B1725 File Offset: 0x001AF925
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005705 RID: 22277 RVA: 0x0002523B File Offset: 0x0002343B
	private void INLDEHPAMJC()
	{
	}

	// Token: 0x06005706 RID: 22278 RVA: 0x001B0B79 File Offset: 0x001AED79
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005707 RID: 22279 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x06005708 RID: 22280 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005709 RID: 22281 RVA: 0x001B175C File Offset: 0x001AF95C
	private Material OHKGGPFGLFD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)119;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600570A RID: 22282 RVA: 0x001B1794 File Offset: 0x001AF994
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1216f)
			{
				this.HBJJOCHGOPH = 12f;
			}
			this.MNLKBFFKHIE().SetFloat("#,0.00", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("CameraFilterPack/AAA_Blood", this.Parasite);
			this.LPPEPKGFOEM().SetVector("Best region found in PlayerPrefs. Connecting to: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 794f, 1794f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600570B RID: 22283 RVA: 0x001B1854 File Offset: 0x001AFA54
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1467f)
			{
				this.HBJJOCHGOPH = 1973f;
			}
			this.LPMLLJKMAMP().SetFloat("#onrankchangedowntext", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("_MainTex2", this.Parasite);
			this.PGPEMMBJOOG().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1336f, 690f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600570C RID: 22284 RVA: 0x001B1911 File Offset: 0x001AFB11
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("ClearEnvironment");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600570D RID: 22285 RVA: 0x001B1935 File Offset: 0x001AFB35
	private Material OCMBHMLNCEK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)64;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600570E RID: 22286 RVA: 0x001B196C File Offset: 0x001AFB6C
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1718f)
			{
				this.HBJJOCHGOPH = 1073f;
			}
			this.ACHNOHCLGOO().SetFloat("masterVolume", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("_Value4", this.Parasite);
			this.OCMBHMLNCEK().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 580f, 428f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600570F RID: 22287 RVA: 0x001B1A2C File Offset: 0x001AFC2C
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 276f)
			{
				this.HBJJOCHGOPH = 492f;
			}
			this.LPCHMEKDCHI().SetFloat("_Amount", this.HBJJOCHGOPH);
			this.LPPEPKGFOEM().SetFloat(" workshop map(s)", this.Parasite);
			this.ACHNOHCLGOO().SetVector("_Near", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 505f, 1179f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005710 RID: 22288 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06005711 RID: 22289 RVA: 0x001B0B79 File Offset: 0x001AED79
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005712 RID: 22290 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06005713 RID: 22291 RVA: 0x001B1AE9 File Offset: 0x001AFCE9
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005714 RID: 22292 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06005715 RID: 22293 RVA: 0x001B0B79 File Offset: 0x001AED79
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005716 RID: 22294 RVA: 0x001B1B10 File Offset: 0x001AFD10
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 920f)
			{
				this.HBJJOCHGOPH = 826f;
			}
			this.ELBMIEOIABA().SetFloat("skin.", this.HBJJOCHGOPH);
			this.OHKGGPFGLFD().SetFloat(".ogg", this.Parasite);
			this.OCMBHMLNCEK().SetVector(".message", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 200f, 1197f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005717 RID: 22295 RVA: 0x001B0B79 File Offset: 0x001AED79
	private void FAMLCFNDGNI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005718 RID: 22296 RVA: 0x001B1BD0 File Offset: 0x001AFDD0
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 713f)
			{
				this.HBJJOCHGOPH = 425f;
			}
			this.ELBMIEOIABA().SetFloat(" should be overwritten.", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("VIGNETTE_BLUR", this.Parasite);
			this.GJHLADDCMFF().SetVector("#", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 255f, 812f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005719 RID: 22297 RVA: 0x001B0B79 File Offset: 0x001AED79
	private void LAMEHAHJKMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600571A RID: 22298 RVA: 0x001B1C90 File Offset: 0x001AFE90
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 916f)
			{
				this.HBJJOCHGOPH = 957f;
			}
			this.LMLENGFLEBD().SetFloat("Hex value #RRGGBB", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat("Set satellite color", this.Parasite);
			this.OHKGGPFGLFD().SetVector(" at ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1326f, 599f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600571B RID: 22299 RVA: 0x001B0B79 File Offset: 0x001AED79
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600571C RID: 22300 RVA: 0x001B1D4D File Offset: 0x001AFF4D
	private void NKFDNIAKGEO()
	{
		this.SCShader = Shader.Find("player.goldlollipop");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600571D RID: 22301 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x0600571E RID: 22302 RVA: 0x001B1D71 File Offset: 0x001AFF71
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("settings.disablestoryboard");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600571F RID: 22303 RVA: 0x001B0B79 File Offset: 0x001AED79
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005720 RID: 22304 RVA: 0x001B1D98 File Offset: 0x001AFF98
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 92f)
			{
				this.HBJJOCHGOPH = 210f;
			}
			this.DOMEEFLPEPJ().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("_Lift", this.Parasite);
			this.MNLKBFFKHIE().SetVector("OpCreateRoom()", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 60f, 1634f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005721 RID: 22305 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBDEJFCNOBF()
	{
	}

	// Token: 0x06005722 RID: 22306 RVA: 0x001B1E55 File Offset: 0x001B0055
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005723 RID: 22307 RVA: 0x001B1E8C File Offset: 0x001B008C
	private Material DOMEEFLPEPJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)124;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005724 RID: 22308 RVA: 0x001B1EC3 File Offset: 0x001B00C3
	private Material LPPEPKGFOEM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005725 RID: 22309 RVA: 0x001B1EFA File Offset: 0x001B00FA
	private void HIPEHGNBJMN()
	{
		this.SCShader = Shader.Find("MapEditorScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005726 RID: 22310 RVA: 0x001B1F1E File Offset: 0x001B011E
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005727 RID: 22311 RVA: 0x001B1F58 File Offset: 0x001B0158
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 346f)
			{
				this.HBJJOCHGOPH = 527f;
			}
			this.OHKGGPFGLFD().SetFloat("_MiddleGrey", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("Gameplay/sprite", this.Parasite);
			this.EHDJJANLINB().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1969f, 1288f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005728 RID: 22312 RVA: 0x001B2015 File Offset: 0x001B0215
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("menutheme.27thfloor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005729 RID: 22313 RVA: 0x001B2039 File Offset: 0x001B0239
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("wss://");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600572A RID: 22314 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x0600572B RID: 22315 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x0600572C RID: 22316 RVA: 0x001B205D File Offset: 0x001B025D
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600572D RID: 22317 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x0600572E RID: 22318 RVA: 0x001B2094 File Offset: 0x001B0294
	private void OKLAJINHPAN()
	{
		this.SCShader = Shader.Find("_Blue_C");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600572F RID: 22319 RVA: 0x001B20B8 File Offset: 0x001B02B8
	private void JABNHMIHBHC()
	{
		this.SCShader = Shader.Find("checkpoint");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005730 RID: 22320 RVA: 0x001B20DC File Offset: 0x001B02DC
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("settings.hitvariation");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x170000FB RID: 251
	// (get) Token: 0x06005731 RID: 22321 RVA: 0x001B2100 File Offset: 0x001B0300
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

	// Token: 0x06005732 RID: 22322 RVA: 0x001B2138 File Offset: 0x001B0338
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 224f)
			{
				this.HBJJOCHGOPH = 458f;
			}
			this.MNLKBFFKHIE().SetFloat("menu.playedsolo", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("CameraFilterPack/3D_Anomaly", this.Parasite);
			this.ACHNOHCLGOO().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1602f, 1527f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005733 RID: 22323 RVA: 0x001B21F8 File Offset: 0x001B03F8
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 253f)
			{
				this.HBJJOCHGOPH = 267f;
			}
			this.OHKGGPFGLFD().SetFloat("_Value", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("_ContrastGainGamma", this.Parasite);
			this.DOHGBNPMBKG().SetVector("Item ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 631f, 1289f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005734 RID: 22324 RVA: 0x001B22B5 File Offset: 0x001B04B5
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("RootCanvas");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005735 RID: 22325 RVA: 0x001B22D9 File Offset: 0x001B04D9
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005736 RID: 22326 RVA: 0x001B2310 File Offset: 0x001B0510
	private Material MNLKBFFKHIE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005737 RID: 22327 RVA: 0x001B2348 File Offset: 0x001B0548
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1506f)
			{
				this.HBJJOCHGOPH = 1906f;
			}
			this.LPCHMEKDCHI().SetFloat("FinalScoreSmallText", this.HBJJOCHGOPH);
			this.OHKGGPFGLFD().SetFloat("UseScanLine", this.Parasite);
			this.DOHGBNPMBKG().SetVector("float,1", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1467f, 896f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005738 RID: 22328 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDBBPKIFNJ()
	{
	}

	// Token: 0x06005739 RID: 22329 RVA: 0x0002523B File Offset: 0x0002343B
	private void JGMEKCFHGLE()
	{
	}

	// Token: 0x0600573A RID: 22330 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x0600573B RID: 22331 RVA: 0x001B2405 File Offset: 0x001B0605
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600573C RID: 22332 RVA: 0x001B2429 File Offset: 0x001B0629
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("_SpawnHeuristic");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600573D RID: 22333 RVA: 0x001B2450 File Offset: 0x001B0650
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 119f)
			{
				this.HBJJOCHGOPH = 1617f;
			}
			this.LPPEPKGFOEM().SetFloat("SetParticlesCountPerBeat", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("_ScreenResolution", this.Parasite);
			this.ABHDNGIHBKE().SetVector("color", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1976f, 627f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600573E RID: 22334 RVA: 0x001B250D File Offset: 0x001B070D
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("Drop_Far");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600573F RID: 22335 RVA: 0x001B2531 File Offset: 0x001B0731
	private void ODBNMPGBCGO()
	{
		this.SCShader = Shader.Find("ReJoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005740 RID: 22336 RVA: 0x0002523B File Offset: 0x0002343B
	private void MANDOGNJJBD()
	{
	}

	// Token: 0x06005741 RID: 22337 RVA: 0x001B0B79 File Offset: 0x001AED79
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005742 RID: 22338 RVA: 0x001B2558 File Offset: 0x001B0758
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1841f)
			{
				this.HBJJOCHGOPH = 197f;
			}
			this.DOHGBNPMBKG().SetFloat("[Right-Left]", this.HBJJOCHGOPH);
			this.MNLKBFFKHIE().SetFloat("SetSunColors", this.Parasite);
			this.KAFBNOBOIAJ().SetVector("<color=white>PhotonView Group: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 182f, 409f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005743 RID: 22339 RVA: 0x001B2615 File Offset: 0x001B0815
	private Material ELBMIEOIABA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005744 RID: 22340 RVA: 0x001B264C File Offset: 0x001B084C
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("Anomaly_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005745 RID: 22341 RVA: 0x001B0B79 File Offset: 0x001AED79
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005746 RID: 22342 RVA: 0x001B2670 File Offset: 0x001B0870
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005747 RID: 22343 RVA: 0x001B26A8 File Offset: 0x001B08A8
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 931f)
			{
				this.HBJJOCHGOPH = 1692f;
			}
			this.FEAEGGCNIAA().SetFloat(", ", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("ShowSprite", this.Parasite);
			this.JFDGLLEOPGB().SetVector("curScn", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 80f, 147f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005748 RID: 22344 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06005749 RID: 22345 RVA: 0x001B2768 File Offset: 0x001B0968
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1446f)
			{
				this.HBJJOCHGOPH = 260f;
			}
			this.KLKILLCHJHO().SetFloat("_LensDirt", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("There was an error retrieving the NumberOfCurrentPlayers.", this.Parasite);
			this.ACHNOHCLGOO().SetVector("score", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1401f, 1363f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600574A RID: 22346 RVA: 0x001B2828 File Offset: 0x001B0A28
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
			this.NBPKMLMCHFN.SetFloat("_Parasite", this.Parasite);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600574B RID: 22347 RVA: 0x001B28E5 File Offset: 0x001B0AE5
	private void JECMJNFGBGC()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600574C RID: 22348 RVA: 0x001B2909 File Offset: 0x001B0B09
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600574D RID: 22349 RVA: 0x001B2940 File Offset: 0x001B0B40
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find(",");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600574E RID: 22350 RVA: 0x001B2964 File Offset: 0x001B0B64
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1099f)
			{
				this.HBJJOCHGOPH = 1618f;
			}
			this.OHKGGPFGLFD().SetFloat("_UserLutTex", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("InventoryGrid", this.Parasite);
			this.OHKGGPFGLFD().SetVector(" not exist", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 215f, 946f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600574F RID: 22351 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x06005750 RID: 22352 RVA: 0x001B2A24 File Offset: 0x001B0C24
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1776f)
			{
				this.HBJJOCHGOPH = 1894f;
			}
			this.EHDJJANLINB().SetFloat("Error: you cannot read this stream that you are writing!", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Lerp speed. Recomended 10", this.Parasite);
			this.DOMEEFLPEPJ().SetVector("_DistortionLevel", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1466f, 1561f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KLKILLCHJHO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005751 RID: 22353 RVA: 0x001B2AE1 File Offset: 0x001B0CE1
	private void ECBILENEOOL()
	{
		this.SCShader = Shader.Find("Right Stick Click");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005752 RID: 22354 RVA: 0x001B2B05 File Offset: 0x001B0D05
	private void AIBNKIDADPI()
	{
		this.SCShader = Shader.Find("_EmissionColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005753 RID: 22355 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBMBNKOOENB()
	{
	}

	// Token: 0x0400090B RID: 2315
	public Shader SCShader;

	// Token: 0x0400090C RID: 2316
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400090D RID: 2317
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400090E RID: 2318
	[Range(-10f, 10f)]
	public float Parasite = 1f;

	// Token: 0x0400090F RID: 2319
	private Material BJFKDHHMLJH;
}
