using System;
using UnityEngine;

// Token: 0x02000074 RID: 116
[AddComponentMenu("Camera Filter Pack/Colors/Sepia")]
[ExecuteInEditMode]
public class CameraFilterPack_Color_Sepia : MonoBehaviour
{
	// Token: 0x060020C2 RID: 8386 RVA: 0x000BE77C File Offset: 0x000BC97C
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Color_Sepia");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060020C3 RID: 8387 RVA: 0x000BE7A0 File Offset: 0x000BC9A0
	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 673f)
			{
				this.HBJJOCHGOPH = 1002f;
			}
			this.ELBMIEOIABA().SetFloat("SetParticlesColor", this.HBJJOCHGOPH);
			this.HKIMAANBGMJ().SetFloat("ResourceIDInputField", this._Fade);
			this.NBPKMLMCHFN.SetVector("BitsData", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 148f, 1011f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060020C4 RID: 8388 RVA: 0x000BE85D File Offset: 0x000BCA5D
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("[NetworkManager] Connected to ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060020C5 RID: 8389 RVA: 0x000BE884 File Offset: 0x000BCA84
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 474f)
			{
				this.HBJJOCHGOPH = 1675f;
			}
			this.DKKBFFHBHJE().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("SUBMIT '{0}' FILES", this._Fade);
			this.OGMEGHKECAH().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 598f, 1772f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060020C6 RID: 8390 RVA: 0x000BE944 File Offset: 0x000BCB44
	private void FIKNBPAIFBI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 236f)
			{
				this.HBJJOCHGOPH = 597f;
			}
			this.LONNIJMNKFB().SetFloat("Item created: Id: ", this.HBJJOCHGOPH);
			this.IOHHLNAPGMA().SetFloat("float", this._Fade);
			this.CBCNOEIALHB().SetVector("NameText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1874f, 730f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060020C7 RID: 8391 RVA: 0x000BEA04 File Offset: 0x000BCC04
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1941f)
			{
				this.HBJJOCHGOPH = 277f;
			}
			this.CBCNOEIALHB().SetFloat("Save Path: ", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("Gameplay/Base", this._Fade);
			this.BFGNMFCNDBC().SetVector("Failed to 'network-remove' GameObject because it is missing a valid InstantiationId on view: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 832f, 1320f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060020C8 RID: 8392 RVA: 0x000BEAC1 File Offset: 0x000BCCC1
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("[Down]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060020C9 RID: 8393 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCDLIKEDMCF()
	{
	}

	// Token: 0x060020CA RID: 8394 RVA: 0x000BEAE8 File Offset: 0x000BCCE8
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1410f)
			{
				this.HBJJOCHGOPH = 1195f;
			}
			this.LPMLLJKMAMP().SetFloat("CameraFilterPack/Drawing_Manga5", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("_Visualize", this._Fade);
			this.BLMPMOIDGMG().SetVector("LeaderboardsButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 544f, 1991f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060020CB RID: 8395 RVA: 0x000BEBA8 File Offset: 0x000BCDA8
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1149f)
			{
				this.HBJJOCHGOPH = 985f;
			}
			this.ABHDNGIHBKE().SetFloat("_Colored", this.HBJJOCHGOPH);
			this.BBIMPFGLDCP().SetFloat("_Extra2", this._Fade);
			this.OHKGGPFGLFD().SetVector("/icon", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1828f, 1287f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060020CC RID: 8396 RVA: 0x000BEC65 File Offset: 0x000BCE65
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060020CD RID: 8397 RVA: 0x000BEC9C File Offset: 0x000BCE9C
	private void LNOOFNGHNEL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1950f)
			{
				this.HBJJOCHGOPH = 5f;
			}
			this.ECCPAOBFDKP().SetFloat("_Speed", this.HBJJOCHGOPH);
			this.OHKGGPFGLFD().SetFloat("player.lollipop", this._Fade);
			this.ELBMIEOIABA().SetVector("CameraFilterPack/Blend2Camera_Divide", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 870f, 286f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060020CE RID: 8398 RVA: 0x000BED59 File Offset: 0x000BCF59
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("Mouse1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060020CF RID: 8399 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060020D0 RID: 8400 RVA: 0x000BED9C File Offset: 0x000BCF9C
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1065f)
			{
				this.HBJJOCHGOPH = 874f;
			}
			this.MJJIEHANFJA().SetFloat("id", this.HBJJOCHGOPH);
			this.IOHHLNAPGMA().SetFloat("_Value", this._Fade);
			this.MJJIEHANFJA().SetVector(".completedMaps", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1085f, 890f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BBIMPFGLDCP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060020D1 RID: 8401 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIPBNBKNICE()
	{
	}

	// Token: 0x060020D2 RID: 8402 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060020D3 RID: 8403 RVA: 0x000BEE5C File Offset: 0x000BD05C
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 429f)
			{
				this.HBJJOCHGOPH = 100f;
			}
			this.LPMLLJKMAMP().SetFloat("Children", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("_Value4", this._Fade);
			this.GJHPODJOBHL().SetVector("CameraFilterPack_Blizzard1", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 170f, 1606f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060020D4 RID: 8404 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHJJFJCKGAJ()
	{
	}

	// Token: 0x060020D5 RID: 8405 RVA: 0x000BEF1C File Offset: 0x000BD11C
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1170f)
			{
				this.HBJJOCHGOPH = 133f;
			}
			this.CFEDGDGBCHE().SetFloat("Did not read byte array properly", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("player.goldarc", this._Fade);
			this.NBPKMLMCHFN.SetVector("CameraFilterPack/Edge_Sobel", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 836f, 24f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CBCNOEIALHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060020D6 RID: 8406 RVA: 0x000BEFD9 File Offset: 0x000BD1D9
	private Material ELBMIEOIABA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060020D7 RID: 8407 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void ABEIEGDHBNO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060020D8 RID: 8408 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void EFECEKPFOEM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060020D9 RID: 8409 RVA: 0x0002523B File Offset: 0x0002343B
	private void APKNAPHOFHC()
	{
	}

	// Token: 0x060020DA RID: 8410 RVA: 0x000BF010 File Offset: 0x000BD210
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("_Far");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060020DB RID: 8411 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060020DC RID: 8412 RVA: 0x000BF034 File Offset: 0x000BD234
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060020DD RID: 8413 RVA: 0x000BF06B File Offset: 0x000BD26B
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("Can't find key ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060020DE RID: 8414 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060020DF RID: 8415 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060020E0 RID: 8416 RVA: 0x0002523B File Offset: 0x0002343B
	private void MANDOGNJJBD()
	{
	}

	// Token: 0x060020E1 RID: 8417 RVA: 0x000BF090 File Offset: 0x000BD290
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 105f)
			{
				this.HBJJOCHGOPH = 1252f;
			}
			this.EJDPNJAEAKJ().SetFloat("skin.hit_perfect", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("_Value", this._Fade);
			this.IOHHLNAPGMA().SetVector("Texture2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1347f, 628f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060020E2 RID: 8418 RVA: 0x000BF14D File Offset: 0x000BD34D
	private Material OJMHIMIPKME()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060020E3 RID: 8419 RVA: 0x000BF184 File Offset: 0x000BD384
	private Material IOHHLNAPGMA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060020E4 RID: 8420 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void MKFLBEGJJDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060020E5 RID: 8421 RVA: 0x000BF1BC File Offset: 0x000BD3BC
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 667f)
			{
				this.HBJJOCHGOPH = 752f;
			}
			this.LPMLLJKMAMP().SetFloat("#turnoninternet", this.HBJJOCHGOPH);
			this.GJHPODJOBHL().SetFloat("RecieveChatActionMessage", this._Fade);
			this.LPMLLJKMAMP().SetVector("Incoming: \n", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1862f, 865f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060020E6 RID: 8422 RVA: 0x000BF279 File Offset: 0x000BD479
	private Material BKKJJJGADLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060020E7 RID: 8423 RVA: 0x000BF2B0 File Offset: 0x000BD4B0
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1810f)
			{
				this.HBJJOCHGOPH = 1566f;
			}
			this.BBIMPFGLDCP().SetFloat("event", this.HBJJOCHGOPH);
			this.HBLDMJCOAHA().SetFloat("Malformed RPC; this should never occur. Content: ", this._Fade);
			this.BLMPMOIDGMG().SetVector("Object ID. Case-Sensitive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 236f, 880f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060020E8 RID: 8424 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x060020E9 RID: 8425 RVA: 0x000BF36D File Offset: 0x000BD56D
	private Material MJJIEHANFJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060020EA RID: 8426 RVA: 0x000BF3A4 File Offset: 0x000BD5A4
	private void IBBFFKEAOCE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 822f)
			{
				this.HBJJOCHGOPH = 1292f;
			}
			this.LPMLLJKMAMP().SetFloat(" not exist", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("MainCamera", this._Fade);
			this.IOHHLNAPGMA().SetVector("settings.enablehitsoundsinrelax", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1093f, 271f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060020EB RID: 8427 RVA: 0x000BF461 File Offset: 0x000BD661
	private Material GJHPODJOBHL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060020EC RID: 8428 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060020ED RID: 8429 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x060020EE RID: 8430 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060020EF RID: 8431 RVA: 0x000BF498 File Offset: 0x000BD698
	private Material DIOAAHJDMLK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060020F0 RID: 8432 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060020F1 RID: 8433 RVA: 0x0002523B File Offset: 0x0002343B
	private void AOLABBMIEIM()
	{
	}

	// Token: 0x060020F2 RID: 8434 RVA: 0x000BF4D0 File Offset: 0x000BD6D0
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
			this.NBPKMLMCHFN.SetFloat("_Fade", this._Fade);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060020F3 RID: 8435 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void ONPFGCEFMML()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060020F4 RID: 8436 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x060020F5 RID: 8437 RVA: 0x000BF590 File Offset: 0x000BD790
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 518f)
			{
				this.HBJJOCHGOPH = 1062f;
			}
			this.MJJIEHANFJA().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("Hello", this._Fade);
			this.CBCNOEIALHB().SetVector("Set camera (or player) distance. Base player distance - 14", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 543f, 77f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060020F6 RID: 8438 RVA: 0x000BF64D File Offset: 0x000BD84D
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060020F7 RID: 8439 RVA: 0x000BF684 File Offset: 0x000BD884
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 42f)
			{
				this.HBJJOCHGOPH = 946f;
			}
			this.ADGHJOHKEHG().SetFloat("_SpotSize", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat("_Visualize", this._Fade);
			this.BBIMPFGLDCP().SetVector("finished", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 657f, 74f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HBLDMJCOAHA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060020F8 RID: 8440 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x060020F9 RID: 8441 RVA: 0x000BF741 File Offset: 0x000BD941
	private void DOKAKEMDALN()
	{
		this.SCShader = Shader.Find("Set Player Distance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060020FA RID: 8442 RVA: 0x000BF765 File Offset: 0x000BD965
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060020FB RID: 8443 RVA: 0x000BF79C File Offset: 0x000BD99C
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("GhostSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060020FC RID: 8444 RVA: 0x000BF7C0 File Offset: 0x000BD9C0
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 530f)
			{
				this.HBJJOCHGOPH = 994f;
			}
			this.MJJIEHANFJA().SetFloat("_Distortion", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", this._Fade);
			this.ECCPAOBFDKP().SetVector("Editor/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1907f, 1270f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060020FD RID: 8445 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x060020FE RID: 8446 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void ALJEADNKJPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060020FF RID: 8447 RVA: 0x000BF87D File Offset: 0x000BDA7D
	private void LFBGJIIECLD()
	{
		this.SCShader = Shader.Find("Player Connected");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002100 RID: 8448 RVA: 0x000BF8A1 File Offset: 0x000BDAA1
	private void HIPEHGNBJMN()
	{
		this.SCShader = Shader.Find("Bad parameters for set! Use <language>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002101 RID: 8449 RVA: 0x000BF8C5 File Offset: 0x000BDAC5
	private Material HKIMAANBGMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002102 RID: 8450 RVA: 0x000BF8FC File Offset: 0x000BDAFC
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("GlassesColor2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002103 RID: 8451 RVA: 0x000BF920 File Offset: 0x000BDB20
	private Material CBCNOEIALHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002104 RID: 8452 RVA: 0x000BF958 File Offset: 0x000BDB58
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1527f)
			{
				this.HBJJOCHGOPH = 1752f;
			}
			this.ABHDNGIHBKE().SetFloat("StartButton", this.HBJJOCHGOPH);
			this.GJHPODJOBHL().SetFloat("_Value3", this._Fade);
			this.CFEDGDGBCHE().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1207f, 310f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002105 RID: 8453 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002106 RID: 8454 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002107 RID: 8455 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void BMGPBIBPBLA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002108 RID: 8456 RVA: 0x000BFA18 File Offset: 0x000BDC18
	private void KPOCGNOKNOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1632f)
			{
				this.HBJJOCHGOPH = 1387f;
			}
			this.ABHDNGIHBKE().SetFloat("<command>", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("CameraFilterPack_Paper1", this._Fade);
			this.MMOODGIODPC().SetVector("inventory.selected.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 692f, 208f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002109 RID: 8457 RVA: 0x0002523B File Offset: 0x0002343B
	private void PFNFPINPCMH()
	{
	}

	// Token: 0x0600210A RID: 8458 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600210C RID: 8460 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600210D RID: 8461 RVA: 0x000BFAF3 File Offset: 0x000BDCF3
	private Material OHKGGPFGLFD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600210E RID: 8462 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x0600210F RID: 8463 RVA: 0x000BFB2A File Offset: 0x000BDD2A
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002110 RID: 8464 RVA: 0x000BFB64 File Offset: 0x000BDD64
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1418f)
			{
				this.HBJJOCHGOPH = 1125f;
			}
			this.OJMHIMIPKME().SetFloat("0,7,true,0", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("powerup.1", this._Fade);
			this.BFGNMFCNDBC().SetVector("_LutTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 400f, 1707f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002111 RID: 8465 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x06002112 RID: 8466 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002113 RID: 8467 RVA: 0x0002523B File Offset: 0x0002343B
	private void COMNAPAAPDO()
	{
	}

	// Token: 0x06002114 RID: 8468 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002115 RID: 8469 RVA: 0x0002523B File Offset: 0x0002343B
	private void CKECPMDEBLL()
	{
	}

	// Token: 0x06002116 RID: 8470 RVA: 0x000BFC21 File Offset: 0x000BDE21
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("Room: '{0}' {1},{2} {4}/{3} players.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002117 RID: 8471 RVA: 0x0002523B File Offset: 0x0002343B
	private void EIDKCANPHJE()
	{
	}

	// Token: 0x06002118 RID: 8472 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void DKPBBJINKMG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002119 RID: 8473 RVA: 0x000BFC48 File Offset: 0x000BDE48
	private void POENGNEMHJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 43f)
			{
				this.HBJJOCHGOPH = 886f;
			}
			this.BKKJJJGADLM().SetFloat(" to ", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat(" not exist", this._Fade);
			this.MMOODGIODPC().SetVector(").", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 454f, 1879f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600211A RID: 8474 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x0600211B RID: 8475 RVA: 0x0002523B File Offset: 0x0002343B
	private void GGPDKCHEBAG()
	{
	}

	// Token: 0x0600211C RID: 8476 RVA: 0x000BFD05 File Offset: 0x000BDF05
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-98);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600211D RID: 8477 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void IEFMONDKKJN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600211E RID: 8478 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x0600211F RID: 8479 RVA: 0x000BFD3C File Offset: 0x000BDF3C
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002120 RID: 8480 RVA: 0x0002523B File Offset: 0x0002343B
	private void FAKGFMFAPDG()
	{
	}

	// Token: 0x06002121 RID: 8481 RVA: 0x000BFD60 File Offset: 0x000BDF60
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002122 RID: 8482 RVA: 0x000BF64D File Offset: 0x000BD84D
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002123 RID: 8483 RVA: 0x000BFD97 File Offset: 0x000BDF97
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find("player.currentrank");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002124 RID: 8484 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002125 RID: 8485 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002126 RID: 8486 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x06002127 RID: 8487 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void FKDEEJFNNJC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002128 RID: 8488 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDBBPKIFNJ()
	{
	}

	// Token: 0x06002129 RID: 8489 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600212A RID: 8490 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x0600212B RID: 8491 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x0600212C RID: 8492 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600212D RID: 8493 RVA: 0x000BFDBB File Offset: 0x000BDFBB
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600212E RID: 8494 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x0600212F RID: 8495 RVA: 0x0002523B File Offset: 0x0002343B
	private void PNLKFANNOKO()
	{
	}

	// Token: 0x06002130 RID: 8496 RVA: 0x000BFDF2 File Offset: 0x000BDFF2
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002131 RID: 8497 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002132 RID: 8498 RVA: 0x000BFE18 File Offset: 0x000BE018
	private void HNMIAKKBMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 351f)
			{
				this.HBJJOCHGOPH = 820f;
			}
			this.BLMPMOIDGMG().SetFloat("CameraFilterPack/Distortion_Water_Drop", this.HBJJOCHGOPH);
			this.CBCNOEIALHB().SetFloat("Error: Cannot change the name of a remote player!", this._Fade);
			this.CBCNOEIALHB().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1099f, 962f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CBCNOEIALHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002133 RID: 8499 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06002134 RID: 8500 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void POIEGKJEHIP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002135 RID: 8501 RVA: 0x000BFED5 File Offset: 0x000BE0D5
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002136 RID: 8502 RVA: 0x000BFF0C File Offset: 0x000BE10C
	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1986f)
			{
				this.HBJJOCHGOPH = 1138f;
			}
			this.ABHDNGIHBKE().SetFloat("player.egglipszerotwo", this.HBJJOCHGOPH);
			this.CBCNOEIALHB().SetFloat("_Value", this._Fade);
			this.ELBMIEOIABA().SetVector("#C8C8C8FF", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1727f, 991f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002137 RID: 8503 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x06002138 RID: 8504 RVA: 0x000BFFC9 File Offset: 0x000BE1C9
	private Material HBLDMJCOAHA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002139 RID: 8505 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x0600213A RID: 8506 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x0600213B RID: 8507 RVA: 0x000C0000 File Offset: 0x000BE200
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1118f)
			{
				this.HBJJOCHGOPH = 258f;
			}
			this.BKKJJJGADLM().SetFloat("_SSAO", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat("Bad parameters for setbool! Use <key> <value>", this._Fade);
			this.DIOAAHJDMLK().SetVector("Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 603f, 108f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600213C RID: 8508 RVA: 0x000C00BD File Offset: 0x000BE2BD
	private Material BBIMPFGLDCP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x1700005A RID: 90
	// (get) Token: 0x0600213D RID: 8509 RVA: 0x000C00F4 File Offset: 0x000BE2F4
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

	// Token: 0x0600213E RID: 8510 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x0600213F RID: 8511 RVA: 0x000C012B File Offset: 0x000BE32B
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)73;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002140 RID: 8512 RVA: 0x000C0164 File Offset: 0x000BE364
	private void GOANCMNGDLE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1369f)
			{
				this.HBJJOCHGOPH = 261f;
			}
			this.GJHPODJOBHL().SetFloat("Editor", this.HBJJOCHGOPH);
			this.ECCPAOBFDKP().SetFloat("achievements.21.completed.", this._Fade);
			this.OGMEGHKECAH().SetVector("TestTicket", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1152f, 1298f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002141 RID: 8513 RVA: 0x000C0221 File Offset: 0x000BE421
	private Material BLMPMOIDGMG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)108;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002142 RID: 8514 RVA: 0x000C0258 File Offset: 0x000BE458
	private void CCFEDENFNEF()
	{
		this.SCShader = Shader.Find("_Value6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002143 RID: 8515 RVA: 0x0002523B File Offset: 0x0002343B
	private void ABFNJCEBIKA()
	{
	}

	// Token: 0x06002144 RID: 8516 RVA: 0x000C027C File Offset: 0x000BE47C
	private void NEFHGMNAPEP()
	{
		this.SCShader = Shader.Find("Keypad");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002145 RID: 8517 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002146 RID: 8518 RVA: 0x000C02A0 File Offset: 0x000BE4A0
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("Error: Someone else(");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002147 RID: 8519 RVA: 0x000BED7D File Offset: 0x000BCF7D
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002148 RID: 8520 RVA: 0x000C02C4 File Offset: 0x000BE4C4
	private void JONGNKNLLND()
	{
		this.SCShader = Shader.Find("ItemNameBGImage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002149 RID: 8521 RVA: 0x000C02E8 File Offset: 0x000BE4E8
	private void PCHCFIOHIKK()
	{
		this.SCShader = Shader.Find(". local RequestedView.ownerId: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600214A RID: 8522 RVA: 0x000C030C File Offset: 0x000BE50C
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600214B RID: 8523 RVA: 0x000C0343 File Offset: 0x000BE543
	private Material ECCPAOBFDKP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600214C RID: 8524 RVA: 0x000C037A File Offset: 0x000BE57A
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600214D RID: 8525 RVA: 0x000C039E File Offset: 0x000BE59E
	private void FDNONDCGGCG()
	{
		this.SCShader = Shader.Find("#checkpoint");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600214E RID: 8526 RVA: 0x0002523B File Offset: 0x0002343B
	private void MDCFIHDPLIG()
	{
	}

	// Token: 0x0600214F RID: 8527 RVA: 0x000C03C4 File Offset: 0x000BE5C4
	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 184f)
			{
				this.HBJJOCHGOPH = 1826f;
			}
			this.OGMEGHKECAH().SetFloat("cancel", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("[GameScene] Submiting rank", this._Fade);
			this.BBIMPFGLDCP().SetVector("#exit", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1148f, 587f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002150 RID: 8528 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x06002151 RID: 8529 RVA: 0x0002523B File Offset: 0x0002343B
	private void EDDPLJGKLKJ()
	{
	}

	// Token: 0x06002152 RID: 8530 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBFJAOINHMK()
	{
	}

	// Token: 0x0400043D RID: 1085
	public Shader SCShader;

	// Token: 0x0400043E RID: 1086
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400043F RID: 1087
	[Range(0f, 1f)]
	public float _Fade = 1f;

	// Token: 0x04000440 RID: 1088
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000441 RID: 1089
	private Material BJFKDHHMLJH;
}
