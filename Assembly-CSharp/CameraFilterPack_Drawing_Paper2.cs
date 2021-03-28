using System;
using UnityEngine;

// Token: 0x020000AC RID: 172
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Drawing/Paper2")]
public class CameraFilterPack_Drawing_Paper2 : MonoBehaviour
{
	// Token: 0x06003432 RID: 13362 RVA: 0x0010EC6E File Offset: 0x0010CE6E
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003433 RID: 13363 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHJJFJCKGAJ()
	{
	}

	// Token: 0x06003434 RID: 13364 RVA: 0x0010EC6E File Offset: 0x0010CE6E
	private void HNGHDAPKEJG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003435 RID: 13365 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003436 RID: 13366 RVA: 0x0010EC8C File Offset: 0x0010CE8C
	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 949f)
			{
				this.HBJJOCHGOPH = 579f;
			}
			this.MLMKCOINOOH().SetFloat("LeaderboardsButton", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetColor("settings.enableselectormusic", this.Pencil_Color);
			this.KAFBNOBOIAJ().SetFloat("Object ID. Case-Sensitive", this.Pencil_Size);
			this.DIOAAHJDMLK().SetFloat("/../", this.Pencil_Correction);
			this.EJDPNJAEAKJ().SetFloat("_Red_R", this.Intensity);
			this.DIOAAHJDMLK().SetFloat("_ScreenResolution", this.Speed_Animation);
			this.HCGJCMDJPGD().SetFloat("challenges", this.Corner_Lose);
			this.CEKJODEAMGB().SetFloat("_TimeX", this.Fade_Paper_to_BackColor);
			this.ADBKPGFMNKO().SetFloat("IconImage", this.Fade_With_Original);
			this.HKHBBBFLGJH().SetColor("CameraFilterPack_Paper3", this.Back_Color);
			this.BAGICADFBAB().SetTexture("_Value4", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003438 RID: 13368 RVA: 0x0010EE84 File Offset: 0x0010D084
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 627f)
			{
				this.HBJJOCHGOPH = 290f;
			}
			this.ACHNOHCLGOO().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetColor("Metal", this.Pencil_Color);
			this.HCGJCMDJPGD().SetFloat("_Value2", this.Pencil_Size);
			this.ACHNOHCLGOO().SetFloat(".GoalProgress", this.Pencil_Correction);
			this.EFMCNLELMDO().SetFloat("_Value1", this.Intensity);
			this.ACHNOHCLGOO().SetFloat("FrostCanvas", this.Speed_Animation);
			this.FKEOGPDLBDD().SetFloat("maps.", this.Corner_Lose);
			this.MLMKCOINOOH().SetFloat("_Value4", this.Fade_Paper_to_BackColor);
			this.KHCLIAMBBNC().SetFloat("x", this.Fade_With_Original);
			this.ADGHJOHKEHG().SetColor("MultiplayerButton", this.Back_Color);
			this.EFMCNLELMDO().SetTexture(". Possible scene loading in progress?", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003439 RID: 13369 RVA: 0x0010EFDA File Offset: 0x0010D1DA
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600343A RID: 13370 RVA: 0x0010F014 File Offset: 0x0010D214
	private void LNOOFNGHNEL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 484f)
			{
				this.HBJJOCHGOPH = 932f;
			}
			this.ACHNOHCLGOO().SetFloat("_MidGrey", this.HBJJOCHGOPH);
			this.FOOCJIDNGBB().SetColor("AddEnvironmentSprite", this.Pencil_Color);
			this.NFKFAAHHLLM().SetFloat("_MainTex2", this.Pencil_Size);
			this.LPCHMEKDCHI().SetFloat("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", this.Pencil_Correction);
			this.ADGHJOHKEHG().SetFloat("distance", this.Intensity);
			this.DKKBFFHBHJE().SetFloat("_Parameter", this.Speed_Animation);
			this.CEKJODEAMGB().SetFloat("#91CCFF", this.Corner_Lose);
			this.EJDPNJAEAKJ().SetFloat("MenuScene", this.Fade_Paper_to_BackColor);
			this.KHCLIAMBBNC().SetFloat(".", this.Fade_With_Original);
			this.HNFFHCLNBDN().SetColor("\t", this.Back_Color);
			this.ADBKPGFMNKO().SetTexture("_ScreenResolution", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600343B RID: 13371 RVA: 0x0010F16A File Offset: 0x0010D36A
	private void LGHCJCFHEMF()
	{
		this.FPHEBLMINDA = (Resources.Load(".lastCheckpoint.bgcolor") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600343C RID: 13372 RVA: 0x0010F1A3 File Offset: 0x0010D3A3
	private Material FOOCJIDNGBB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600343D RID: 13373 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x0600343E RID: 13374 RVA: 0x0010F1DA File Offset: 0x0010D3DA
	private void KOFAMEKHHGD()
	{
		this.FPHEBLMINDA = (Resources.Load("#alreadystarted") as Texture2D);
		this.SCShader = Shader.Find("tagElement");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600343F RID: 13375 RVA: 0x0010F213 File Offset: 0x0010D413
	private void MDNHCLKNCLE()
	{
		this.FPHEBLMINDA = (Resources.Load("_Radius") as Texture2D);
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003440 RID: 13376 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06003441 RID: 13377 RVA: 0x0010F24C File Offset: 0x0010D44C
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1487f)
			{
				this.HBJJOCHGOPH = 790f;
			}
			this.HKHBBBFLGJH().SetFloat("CountEventsGoal", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetColor("CameraFilterPack/TV_ARCADE_2", this.Pencil_Color);
			this.FOOCJIDNGBB().SetFloat("_Value7", this.Pencil_Size);
			this.FKEOGPDLBDD().SetFloat("RPC: 'OnAwakeRPC' PhotonView: ", this.Pencil_Correction);
			this.EFMCNLELMDO().SetFloat(" not exist", this.Intensity);
			this.KEMAALEODNH().SetFloat("_Value2", this.Speed_Animation);
			this.HNFFHCLNBDN().SetFloat("_ScreenResolution", this.Corner_Lose);
			this.FOOCJIDNGBB().SetFloat("_EmissionColor", this.Fade_Paper_to_BackColor);
			this.NBPKMLMCHFN.SetFloat("EventTimeInputField", this.Fade_With_Original);
			this.NBPKMLMCHFN.SetColor("#close", this.Back_Color);
			this.PLBEJJIHFPB().SetTexture("MainThreadExecuter", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003442 RID: 13378 RVA: 0x0010EC6E File Offset: 0x0010CE6E
	private void OEIBFOHPOPD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003443 RID: 13379 RVA: 0x0010EC6E File Offset: 0x0010CE6E
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003444 RID: 13380 RVA: 0x0010F3A4 File Offset: 0x0010D5A4
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1353f)
			{
				this.HBJJOCHGOPH = 108f;
			}
			this.HCGJCMDJPGD().SetFloat("#timeuntilchallenge: ", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetColor("SetSatelliteSensitivity", this.Pencil_Color);
			this.PLBEJJIHFPB().SetFloat("EventData0DropDownList", this.Pencil_Size);
			this.MICHFGAOPKM().SetFloat("[SaveSystem] Outdated savefile found", this.Pencil_Correction);
			this.DIOAAHJDMLK().SetFloat("LoadMapCanvas", this.Intensity);
			this.MICHFGAOPKM().SetFloat("float,10", this.Speed_Animation);
			this.MICHFGAOPKM().SetFloat("UsernameText", this.Corner_Lose);
			this.ENKPNJMPDEB().SetFloat("1332644700", this.Fade_Paper_to_BackColor);
			this.KHCLIAMBBNC().SetFloat("ScrollPanel", this.Fade_With_Original);
			this.PLBEJJIHFPB().SetColor("BitsData", this.Back_Color);
			this.ACHNOHCLGOO().SetTexture("restrictions\n\n#until: ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003445 RID: 13381 RVA: 0x0010F4FC File Offset: 0x0010D6FC
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 163f)
			{
				this.HBJJOCHGOPH = 66f;
			}
			this.ADGHJOHKEHG().SetFloat("menuthemes", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetColor("settings.shaders", this.Pencil_Color);
			this.HCGJCMDJPGD().SetFloat("Other", this.Pencil_Size);
			this.FOOCJIDNGBB().SetFloat("Failed to InstantiateSceneObject prefab: ", this.Pencil_Correction);
			this.KEMAALEODNH().SetFloat("_ConsoleSettings", this.Intensity);
			this.HCGJCMDJPGD().SetFloat("_Value2", this.Speed_Animation);
			this.MICHFGAOPKM().SetFloat("_Value2", this.Corner_Lose);
			this.NFKFAAHHLLM().SetFloat("arcs", this.Fade_Paper_to_BackColor);
			this.EFMCNLELMDO().SetFloat("speed", this.Fade_With_Original);
			this.KHCLIAMBBNC().SetColor("[EditorEvent] Exception: ", this.Back_Color);
			this.CEKJODEAMGB().SetTexture("ready", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003446 RID: 13382 RVA: 0x0010EC6E File Offset: 0x0010CE6E
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003447 RID: 13383 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x06003448 RID: 13384 RVA: 0x0010F652 File Offset: 0x0010D852
	private Material DOMEEFLPEPJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003449 RID: 13385 RVA: 0x0010F689 File Offset: 0x0010D889
	private Material DIOAAHJDMLK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600344A RID: 13386 RVA: 0x0010F6C0 File Offset: 0x0010D8C0
	private void NKFDNIAKGEO()
	{
		this.FPHEBLMINDA = (Resources.Load("[LevelEditorScene] Print Audio Wave: Done") as Texture2D);
		this.SCShader = Shader.Find("float,0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600344B RID: 13387 RVA: 0x0002523B File Offset: 0x0002343B
	private void FAKGFMFAPDG()
	{
	}

	// Token: 0x0600344C RID: 13388 RVA: 0x0010F6F9 File Offset: 0x0010D8F9
	private Material KHCLIAMBBNC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600344D RID: 13389 RVA: 0x0010F730 File Offset: 0x0010D930
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1485f)
			{
				this.HBJJOCHGOPH = 619f;
			}
			this.FOOCJIDNGBB().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetColor("shader.none", this.Pencil_Color);
			this.FOOCJIDNGBB().SetFloat("_ScreenResolution", this.Pencil_Size);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.Pencil_Correction);
			this.ADGHJOHKEHG().SetFloat("{0}{1}:{2}", this.Intensity);
			this.MLMKCOINOOH().SetFloat("_TimeX", this.Speed_Animation);
			this.HCGJCMDJPGD().SetFloat("[Left]", this.Corner_Lose);
			this.NFKFAAHHLLM().SetFloat("_ScreenResolution", this.Fade_Paper_to_BackColor);
			this.MICHFGAOPKM().SetFloat("_Value3", this.Fade_With_Original);
			this.LPCHMEKDCHI().SetColor("_ScreenResolution", this.Back_Color);
			this.BAGICADFBAB().SetTexture("ns.exitgames.com", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600344E RID: 13390 RVA: 0x0010F888 File Offset: 0x0010DA88
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1078f)
			{
				this.HBJJOCHGOPH = 1239f;
			}
			this.DKKBFFHBHJE().SetFloat("ItemNameText", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetColor("https://www.youtube.com/watch?v=cDVXukrKo74", this.Pencil_Color);
			this.KAFBNOBOIAJ().SetFloat("_Value3", this.Pencil_Size);
			this.ADBKPGFMNKO().SetFloat("_Value2", this.Pencil_Correction);
			this.KAFBNOBOIAJ().SetFloat("player.licenceaccepted", this.Intensity);
			this.ADBKPGFMNKO().SetFloat("settings.volume.sfx", this.Speed_Animation);
			this.FOOCJIDNGBB().SetFloat("CameraFilterPack/AAA_BloodOnScreen", this.Corner_Lose);
			this.HKHBBBFLGJH().SetFloat("action", this.Fade_Paper_to_BackColor);
			this.DOMEEFLPEPJ().SetFloat(". MasterClient: ", this.Fade_With_Original);
			this.ACHNOHCLGOO().SetColor(". The RPC has been ignored.", this.Back_Color);
			this.CEKJODEAMGB().SetTexture("_ProjInfo", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600344F RID: 13391 RVA: 0x0010EC6E File Offset: 0x0010CE6E
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003450 RID: 13392 RVA: 0x0010F9DE File Offset: 0x0010DBDE
	private void OHFOLGANOLC()
	{
		this.FPHEBLMINDA = (Resources.Load(", data: ") as Texture2D);
		this.SCShader = Shader.Find("settings.arcshitsoundtimedelay");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003451 RID: 13393 RVA: 0x0010FA18 File Offset: 0x0010DC18
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1070f)
			{
				this.HBJJOCHGOPH = 1932f;
			}
			this.DIOAAHJDMLK().SetFloat("MapEnd", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetColor("_MainTex2", this.Pencil_Color);
			this.HKHBBBFLGJH().SetFloat("skin.", this.Pencil_Size);
			this.HCGJCMDJPGD().SetFloat("_ScreenResolution", this.Pencil_Correction);
			this.ADBKPGFMNKO().SetFloat("[ResourcesManager] Load audio error: ", this.Intensity);
			this.DKKBFFHBHJE().SetFloat("mapselector.orderby", this.Speed_Animation);
			this.ADBKPGFMNKO().SetFloat("CameraFilterPack/TV_ARCADE_2", this.Corner_Lose);
			this.NFKFAAHHLLM().SetFloat("Down", this.Fade_Paper_to_BackColor);
			this.HCGJCMDJPGD().SetFloat("_ZCurve", this.Fade_With_Original);
			this.ADGHJOHKEHG().SetColor("_LutTex", this.Back_Color);
			this.DIOAAHJDMLK().SetTexture("maps.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003452 RID: 13394 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x06003453 RID: 13395 RVA: 0x0010FB70 File Offset: 0x0010DD70
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1133f)
			{
				this.HBJJOCHGOPH = 309f;
			}
			this.EJDPNJAEAKJ().SetFloat("End index must in an integer.", this.HBJJOCHGOPH);
			this.ENKPNJMPDEB().SetColor(" has no method \"", this.Pencil_Color);
			this.ACHNOHCLGOO().SetFloat(".ogg", this.Pencil_Size);
			this.FOOCJIDNGBB().SetFloat("Bad parameters for set! Use <language>", this.Pencil_Correction);
			this.ENKPNJMPDEB().SetFloat("checkpoint", this.Intensity);
			this.FGENHBKMPDA().SetFloat("Items", this.Speed_Animation);
			this.HCGJCMDJPGD().SetFloat(", ", this.Corner_Lose);
			this.DKKBFFHBHJE().SetFloat("Offline", this.Fade_Paper_to_BackColor);
			this.CEKJODEAMGB().SetFloat("SelectorMusicToggle", this.Fade_With_Original);
			this.FKEOGPDLBDD().SetColor("CameraFilterPack/TV_Artefact", this.Back_Color);
			this.DKKBFFHBHJE().SetTexture("_FixDistance", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003454 RID: 13396 RVA: 0x0010FCC6 File Offset: 0x0010DEC6
	private void CNGAJDBOCLJ()
	{
		this.FPHEBLMINDA = (Resources.Load("0,7,true,0") as Texture2D);
		this.SCShader = Shader.Find("Creating new item...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003455 RID: 13397 RVA: 0x0010FD00 File Offset: 0x0010DF00
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 45f)
			{
				this.HBJJOCHGOPH = 899f;
			}
			this.HNFFHCLNBDN().SetFloat("TStart", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetColor("player.licenceaccepted", this.Pencil_Color);
			this.EJDPNJAEAKJ().SetFloat("[MapsData] Key ", this.Pencil_Size);
			this.CEKJODEAMGB().SetFloat("Tab2Content", this.Pencil_Correction);
			this.MLMKCOINOOH().SetFloat("NetworkPeer broke!", this.Intensity);
			this.HKHBBBFLGJH().SetFloat("_Intensity", this.Speed_Animation);
			this.BAGICADFBAB().SetFloat("_Metrics", this.Corner_Lose);
			this.HKHBBBFLGJH().SetFloat("sounds/hit_perfect", this.Fade_Paper_to_BackColor);
			this.KHCLIAMBBNC().SetFloat("PLEASE WAIT", this.Fade_With_Original);
			this.DKKBFFHBHJE().SetColor("SetEnvSpriteColor", this.Back_Color);
			this.ADBKPGFMNKO().SetTexture("_Val", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003456 RID: 13398 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x06003457 RID: 13399 RVA: 0x0010FE56 File Offset: 0x0010E056
	private void JKBMKPDGCHG()
	{
		this.FPHEBLMINDA = (Resources.Load("[MapEditor] Loaded music file: ") as Texture2D);
		this.SCShader = Shader.Find("achievements.21.completed.workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003458 RID: 13400 RVA: 0x0010FE90 File Offset: 0x0010E090
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 888f)
			{
				this.HBJJOCHGOPH = 1573f;
			}
			this.PLBEJJIHFPB().SetFloat("difficulty", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetColor("OnDeserialize", this.Pencil_Color);
			this.HCGJCMDJPGD().SetFloat("Init", this.Pencil_Size);
			this.DOMEEFLPEPJ().SetFloat("[MapEditor] Loading music...", this.Pencil_Correction);
			this.DOMEEFLPEPJ().SetFloat("ReJoinRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", this.Intensity);
			this.CEKJODEAMGB().SetFloat("default", this.Speed_Animation);
			this.PLBEJJIHFPB().SetFloat("health", this.Corner_Lose);
			this.ACHNOHCLGOO().SetFloat("Can't connect: Loading settings failed. ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", this.Fade_Paper_to_BackColor);
			this.MICHFGAOPKM().SetFloat(" not exist", this.Fade_With_Original);
			this.PLBEJJIHFPB().SetColor("KickThePlayer", this.Back_Color);
			this.BAGICADFBAB().SetTexture("mapselector.tags.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ENKPNJMPDEB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003459 RID: 13401 RVA: 0x0010FFE6 File Offset: 0x0010E1E6
	private void DNNFHBOOPIN()
	{
		this.FPHEBLMINDA = (Resources.Load("_ExposureAdjustment") as Texture2D);
		this.SCShader = Shader.Find("[PlayerBase] New highscore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600345A RID: 13402 RVA: 0x0011001F File Offset: 0x0010E21F
	private void IBLGHLNNAHN()
	{
		this.FPHEBLMINDA = (Resources.Load("y") as Texture2D);
		this.SCShader = Shader.Find("_Color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600345B RID: 13403 RVA: 0x00110058 File Offset: 0x0010E258
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600345C RID: 13404 RVA: 0x00110090 File Offset: 0x0010E290
	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 550f)
			{
				this.HBJJOCHGOPH = 709f;
			}
			this.FGENHBKMPDA().SetFloat("settings.disablestoryboard", this.HBJJOCHGOPH);
			this.FKEOGPDLBDD().SetColor("player.dragon", this.Pencil_Color);
			this.MICHFGAOPKM().SetFloat("VeryHigh", this.Pencil_Size);
			this.HCGJCMDJPGD().SetFloat("blue", this.Pencil_Correction);
			this.ADGHJOHKEHG().SetFloat("CameraFilterPack_AAA_BloodOnScreen1", this.Intensity);
			this.MLMKCOINOOH().SetFloat("Set Satellite Input", this.Speed_Animation);
			this.ADBKPGFMNKO().SetFloat("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp-firstpass", this.Corner_Lose);
			this.MICHFGAOPKM().SetFloat("<color=white>PhotonView Group: ", this.Fade_Paper_to_BackColor);
			this.CEKJODEAMGB().SetFloat("CameraFilterPack/Distortion_BigFace", this.Fade_With_Original);
			this.KAFBNOBOIAJ().SetColor("_Value", this.Back_Color);
			this.FGENHBKMPDA().SetTexture("_SubsampleIndices", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600345D RID: 13405 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x0600345E RID: 13406 RVA: 0x001101E6 File Offset: 0x0010E3E6
	private void JKFDDNMPOJH()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value2") as Texture2D);
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600345F RID: 13407 RVA: 0x0011021F File Offset: 0x0010E41F
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003460 RID: 13408 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x06003461 RID: 13409 RVA: 0x0010EC6E File Offset: 0x0010CE6E
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003462 RID: 13410 RVA: 0x00110258 File Offset: 0x0010E458
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

	// Token: 0x06003463 RID: 13411 RVA: 0x001103AE File Offset: 0x0010E5AE
	private Material ENKPNJMPDEB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003464 RID: 13412 RVA: 0x001103E8 File Offset: 0x0010E5E8
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1443f)
			{
				this.HBJJOCHGOPH = 746f;
			}
			this.DOMEEFLPEPJ().SetFloat("CameraFilterPack/Blur_Noise", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetColor("ERROR: Preview file must be <1MB!", this.Pencil_Color);
			this.ADGHJOHKEHG().SetFloat(": ", this.Pencil_Size);
			this.DOMEEFLPEPJ().SetFloat("SpawnObj", this.Pencil_Correction);
			this.ADGHJOHKEHG().SetFloat("SupportLogger OnDisconnectedFromPhoton().", this.Intensity);
			this.KAFBNOBOIAJ().SetFloat(" : ", this.Speed_Animation);
			this.FKEOGPDLBDD().SetFloat("init", this.Corner_Lose);
			this.KAFBNOBOIAJ().SetFloat("_TimeX", this.Fade_Paper_to_BackColor);
			this.HNFFHCLNBDN().SetFloat("BitsData", this.Fade_With_Original);
			this.ENKPNJMPDEB().SetColor("PossibleMapPointsText", this.Back_Color);
			this.FGENHBKMPDA().SetTexture("float,1", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ENKPNJMPDEB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003465 RID: 13413 RVA: 0x0011053E File Offset: 0x0010E73E
	private void JFJLGJEPEAA()
	{
		this.FPHEBLMINDA = (Resources.Load("inventory.selected.") as Texture2D);
		this.SCShader = Shader.Find("yyyy-MM-dd HH:mm:ss");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003466 RID: 13414 RVA: 0x0010EC6E File Offset: 0x0010CE6E
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003467 RID: 13415 RVA: 0x00110577 File Offset: 0x0010E777
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003468 RID: 13416 RVA: 0x001105AE File Offset: 0x0010E7AE
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_Paper3") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_Paper2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003469 RID: 13417 RVA: 0x001105E8 File Offset: 0x0010E7E8
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1005f)
			{
				this.HBJJOCHGOPH = 1743f;
			}
			this.HNFFHCLNBDN().SetFloat(".lastCheckpoint.playerdistance", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetColor("_Bullet_3", this.Pencil_Color);
			this.LPCHMEKDCHI().SetFloat("_BlurVector", this.Pencil_Size);
			this.NBPKMLMCHFN.SetFloat("_SpherePositionX", this.Pencil_Correction);
			this.ACHNOHCLGOO().SetFloat(" ", this.Intensity);
			this.KEMAALEODNH().SetFloat("_RampTex", this.Speed_Animation);
			this.MLMKCOINOOH().SetFloat("_Distortion", this.Corner_Lose);
			this.HNFFHCLNBDN().SetFloat("_FgOverlap", this.Fade_Paper_to_BackColor);
			this.EJDPNJAEAKJ().SetFloat(".mp3", this.Fade_With_Original);
			this.ENKPNJMPDEB().SetColor("_Distortion", this.Back_Color);
			this.BAGICADFBAB().SetTexture("PhotonView with ID {0} wasn't properly unregistered! Please report this case to developer@photonengine.com", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600346A RID: 13418 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x0600346B RID: 13419 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x0600346C RID: 13420 RVA: 0x00110740 File Offset: 0x0010E940
	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1689f)
			{
				this.HBJJOCHGOPH = 1751f;
			}
			this.ACHNOHCLGOO().SetFloat("input", this.HBJJOCHGOPH);
			this.FKEOGPDLBDD().SetColor("[PlayerController] ", this.Pencil_Color);
			this.KEMAALEODNH().SetFloat("Drop_Near", this.Pencil_Size);
			this.LPCHMEKDCHI().SetFloat(" method: ", this.Pencil_Correction);
			this.MICHFGAOPKM().SetFloat("_Vignetting2", this.Intensity);
			this.KHCLIAMBBNC().SetFloat("float,0", this.Speed_Animation);
			this.FGENHBKMPDA().SetFloat("_Value", this.Corner_Lose);
			this.LPCHMEKDCHI().SetFloat("SetParticlesColor", this.Fade_Paper_to_BackColor);
			this.DKKBFFHBHJE().SetFloat("SaveButton", this.Fade_With_Original);
			this.PLBEJJIHFPB().SetColor("Start", this.Back_Color);
			this.CEKJODEAMGB().SetTexture("Mouse ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600346D RID: 13421 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x0600346E RID: 13422 RVA: 0x00110896 File Offset: 0x0010EA96
	private void ILCFPCIPENO()
	{
		this.FPHEBLMINDA = (Resources.Load("DestroyRpc") as Texture2D);
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600346F RID: 13423 RVA: 0x0010EC6E File Offset: 0x0010CE6E
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003470 RID: 13424 RVA: 0x001108CF File Offset: 0x0010EACF
	private void FLKEJJEGCFA()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value3") as Texture2D);
		this.SCShader = Shader.Find("curScn");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003471 RID: 13425 RVA: 0x0010EC6E File Offset: 0x0010CE6E
	private void JNALDALAJLG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003472 RID: 13426 RVA: 0x0010EC6E File Offset: 0x0010CE6E
	private void BDBJEDIOKBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003473 RID: 13427 RVA: 0x0010EC6E File Offset: 0x0010CE6E
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003474 RID: 13428 RVA: 0x00110908 File Offset: 0x0010EB08
	private void IKDNLHLBHID()
	{
		this.FPHEBLMINDA = (Resources.Load(". Should be just one?") as Texture2D);
		this.SCShader = Shader.Find("{0:0} day{1}, ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003475 RID: 13429 RVA: 0x00110941 File Offset: 0x0010EB41
	private void NNFMIAFHMJM()
	{
		this.FPHEBLMINDA = (Resources.Load("Exception caught! ") as Texture2D);
		this.SCShader = Shader.Find("LevelEditor/icons");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003476 RID: 13430 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x06003477 RID: 13431 RVA: 0x0010EC6E File Offset: 0x0010CE6E
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003478 RID: 13432 RVA: 0x0011097C File Offset: 0x0010EB7C
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1696f)
			{
				this.HBJJOCHGOPH = 1445f;
			}
			this.HKHBBBFLGJH().SetFloat("Expected protocol set to UDP, due to encryption mode DatagramEncryption. Changing protocol in PhotonServerSettings from: ", this.HBJJOCHGOPH);
			this.FKEOGPDLBDD().SetColor("Editor/", this.Pencil_Color);
			this.PLBEJJIHFPB().SetFloat("_Offsets", this.Pencil_Size);
			this.NFKFAAHHLLM().SetFloat("threshold", this.Pencil_Correction);
			this.CEKJODEAMGB().SetFloat("STICKRVER", this.Intensity);
			this.DKKBFFHBHJE().SetFloat("#onrankchangeuptext", this.Speed_Animation);
			this.KAFBNOBOIAJ().SetFloat("_Radius", this.Corner_Lose);
			this.BAGICADFBAB().SetFloat("Texture2", this.Fade_Paper_to_BackColor);
			this.BAGICADFBAB().SetFloat("LoadPlayerSkin", this.Fade_With_Original);
			this.CEKJODEAMGB().SetColor("PossibleMapMaxScoreText", this.Back_Color);
			this.NFKFAAHHLLM().SetTexture("BadgeText", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003479 RID: 13433 RVA: 0x00110AD4 File Offset: 0x0010ECD4
	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 732f)
			{
				this.HBJJOCHGOPH = 1880f;
			}
			this.ADBKPGFMNKO().SetFloat("_Blue_B", this.HBJJOCHGOPH);
			this.KHCLIAMBBNC().SetColor("BadgeText", this.Pencil_Color);
			this.KEMAALEODNH().SetFloat(".png", this.Pencil_Size);
			this.FOOCJIDNGBB().SetFloat("[ResourcesManager] Unloading data resources", this.Pencil_Correction);
			this.HKHBBBFLGJH().SetFloat("DPADVER", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_Offsets", this.Speed_Animation);
			this.DIOAAHJDMLK().SetFloat("ItemNameBGImage", this.Corner_Lose);
			this.CEKJODEAMGB().SetFloat("_ReflectionTexture1", this.Fade_Paper_to_BackColor);
			this.FGENHBKMPDA().SetFloat("[PlayerController] ", this.Fade_With_Original);
			this.DKKBFFHBHJE().SetColor(" or ", this.Back_Color);
			this.DOMEEFLPEPJ().SetTexture("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600347A RID: 13434 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x0600347B RID: 13435 RVA: 0x0010EC6E File Offset: 0x0010CE6E
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600347C RID: 13436 RVA: 0x0010EC6E File Offset: 0x0010CE6E
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600347D RID: 13437 RVA: 0x00110C2C File Offset: 0x0010EE2C
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 275f)
			{
				this.HBJJOCHGOPH = 1074f;
			}
			this.KAFBNOBOIAJ().SetFloat("_Green_R", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetColor("_Value5", this.Pencil_Color);
			this.PLBEJJIHFPB().SetFloat("_MainTex2", this.Pencil_Size);
			this.EFMCNLELMDO().SetFloat("_TimeX", this.Pencil_Correction);
			this.EFMCNLELMDO().SetFloat("BadgeImage", this.Intensity);
			this.KHCLIAMBBNC().SetFloat("_Value3", this.Speed_Animation);
			this.NBPKMLMCHFN.SetFloat("https://steamcommunity.com/app/513510/workshop/", this.Corner_Lose);
			this.KEMAALEODNH().SetFloat("Observed type is not serializable: ", this.Fade_Paper_to_BackColor);
			this.HCGJCMDJPGD().SetFloat("Mar", this.Fade_With_Original);
			this.ADGHJOHKEHG().SetColor("workshop.", this.Back_Color);
			this.KEMAALEODNH().SetTexture("Done! You are a contributor until: ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000091 RID: 145
	// (get) Token: 0x0600347E RID: 13438 RVA: 0x00110D82 File Offset: 0x0010EF82
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

	// Token: 0x0600347F RID: 13439 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x06003480 RID: 13440 RVA: 0x00110DBC File Offset: 0x0010EFBC
	private void KPOCGNOKNOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1366f)
			{
				this.HBJJOCHGOPH = 1178f;
			}
			this.DIOAAHJDMLK().SetFloat("_Value5", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetColor("_ClutTex", this.Pencil_Color);
			this.FGENHBKMPDA().SetFloat("attempted to spawn go (", this.Pencil_Size);
			this.LPCHMEKDCHI().SetFloat("Can't find PhotonView of incoming OwnershipRequest. ViewId not found: ", this.Pencil_Correction);
			this.EJDPNJAEAKJ().SetFloat("Event Received", this.Intensity);
			this.ACHNOHCLGOO().SetFloat("_MainTex2", this.Speed_Animation);
			this.LPCHMEKDCHI().SetFloat("Most likely the game became empty during the switch to GameServer.", this.Corner_Lose);
			this.DKKBFFHBHJE().SetFloat("settings_bindings_controller_type", this.Fade_Paper_to_BackColor);
			this.NFKFAAHHLLM().SetFloat("22x3", this.Fade_With_Original);
			this.LPCHMEKDCHI().SetColor("settings_bindings_", this.Back_Color);
			this.DKKBFFHBHJE().SetTexture("yes", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003481 RID: 13441 RVA: 0x0010EC6E File Offset: 0x0010CE6E
	private void EFECEKPFOEM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003482 RID: 13442 RVA: 0x00110F14 File Offset: 0x0010F114
	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1044f)
			{
				this.HBJJOCHGOPH = 1912f;
			}
			this.NBPKMLMCHFN.SetFloat("ItemsCountText", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetColor("_Value7", this.Pencil_Color);
			this.FOOCJIDNGBB().SetFloat("CameraFilterPack/Oculus_ThermaVision", this.Pencil_Size);
			this.EFMCNLELMDO().SetFloat("colorB", this.Pencil_Correction);
			this.EJDPNJAEAKJ().SetFloat("DPADHOR", this.Intensity);
			this.NFKFAAHHLLM().SetFloat("_Value", this.Speed_Animation);
			this.MICHFGAOPKM().SetFloat("OK", this.Corner_Lose);
			this.HKHBBBFLGJH().SetFloat("_TimeX", this.Fade_Paper_to_BackColor);
			this.ENKPNJMPDEB().SetFloat("CheckResources () for ", this.Fade_With_Original);
			this.HKHBBBFLGJH().SetColor("CameraFilterPack/RainFX", this.Back_Color);
			this.ENKPNJMPDEB().SetTexture("_Visualize", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003483 RID: 13443 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06003484 RID: 13444 RVA: 0x0011106A File Offset: 0x0010F26A
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003485 RID: 13445 RVA: 0x001110A1 File Offset: 0x0010F2A1
	private void LFBGJIIECLD()
	{
		this.FPHEBLMINDA = (Resources.Load("#close") as Texture2D);
		this.SCShader = Shader.Find("MainThreadExecuter");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003486 RID: 13446 RVA: 0x0010EC6E File Offset: 0x0010CE6E
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003487 RID: 13447 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06003488 RID: 13448 RVA: 0x001110DC File Offset: 0x0010F2DC
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1284f)
			{
				this.HBJJOCHGOPH = 866f;
			}
			this.DIOAAHJDMLK().SetFloat("FileMenu", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetColor("_Value", this.Pencil_Color);
			this.MLMKCOINOOH().SetFloat("CameraFilterPack/TV_Old", this.Pencil_Size);
			this.FGENHBKMPDA().SetFloat("OxOD.lastPath", this.Pencil_Correction);
			this.NBPKMLMCHFN.SetFloat("_Bullet_7", this.Intensity);
			this.EJDPNJAEAKJ().SetFloat("Vertical", this.Speed_Animation);
			this.KEMAALEODNH().SetFloat(",", this.Corner_Lose);
			this.EJDPNJAEAKJ().SetFloat(" not exist", this.Fade_Paper_to_BackColor);
			this.CEKJODEAMGB().SetFloat(" not exist", this.Fade_With_Original);
			this.HCGJCMDJPGD().SetColor("[NetworkManager] Joined main lobby", this.Back_Color);
			this.ACHNOHCLGOO().SetTexture("_Value", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003489 RID: 13449 RVA: 0x0010EFDA File Offset: 0x0010D1DA
	private Material EFMCNLELMDO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600348A RID: 13450 RVA: 0x00111232 File Offset: 0x0010F432
	private void BMOFEBKGLFI()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/Fly_Vision") as Texture2D);
		this.SCShader = Shader.Find("_Size");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600348B RID: 13451 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFMEAMBLODG()
	{
	}

	// Token: 0x0600348C RID: 13452 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x0600348D RID: 13453 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x0600348E RID: 13454 RVA: 0x0011126B File Offset: 0x0010F46B
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)108;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600348F RID: 13455 RVA: 0x0010EC6E File Offset: 0x0010CE6E
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003490 RID: 13456 RVA: 0x001112A2 File Offset: 0x0010F4A2
	private Material MLMKCOINOOH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003491 RID: 13457 RVA: 0x001112D9 File Offset: 0x0010F4D9
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003492 RID: 13458 RVA: 0x00111310 File Offset: 0x0010F510
	private void FANADGBGCPI()
	{
		this.FPHEBLMINDA = (Resources.Load("#rate!") as Texture2D);
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003493 RID: 13459 RVA: 0x0010EC6E File Offset: 0x0010CE6E
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003494 RID: 13460 RVA: 0x00111349 File Offset: 0x0010F549
	private void FIKFJDFELIP()
	{
		this.FPHEBLMINDA = (Resources.Load("settings.volume.sfx") as Texture2D);
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003495 RID: 13461 RVA: 0x0010EC6E File Offset: 0x0010CE6E
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003496 RID: 13462 RVA: 0x00111382 File Offset: 0x0010F582
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003497 RID: 13463 RVA: 0x001113B9 File Offset: 0x0010F5B9
	private void IMCKJCHKMKB()
	{
		this.FPHEBLMINDA = (Resources.Load(".lastCheckpoint.currentCombo") as Texture2D);
		this.SCShader = Shader.Find("_FarCamera");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003498 RID: 13464 RVA: 0x001113F2 File Offset: 0x0010F5F2
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003499 RID: 13465 RVA: 0x00111429 File Offset: 0x0010F629
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600349A RID: 13466 RVA: 0x00111460 File Offset: 0x0010F660
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1941f)
			{
				this.HBJJOCHGOPH = 534f;
			}
			this.DOMEEFLPEPJ().SetFloat("_FrustumCornersWS", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetColor("DestroyPlayerObjects() failed, cause players can only destroy their own GameObjects. A Master Client can destroy anyone's. This is master: ", this.Pencil_Color);
			this.MLMKCOINOOH().SetFloat("_BlurredColor", this.Pencil_Size);
			this.KEMAALEODNH().SetFloat("2;13;14;15;16", this.Pencil_Correction);
			this.BAGICADFBAB().SetFloat("NEW", this.Intensity);
			this.ENKPNJMPDEB().SetFloat("The observed monobehaviour (", this.Speed_Animation);
			this.KEMAALEODNH().SetFloat("View", this.Corner_Lose);
			this.KEMAALEODNH().SetFloat(";", this.Fade_Paper_to_BackColor);
			this.DOMEEFLPEPJ().SetFloat("_ReflectionTexture0", this.Fade_With_Original);
			this.NBPKMLMCHFN.SetColor("_TimeX", this.Back_Color);
			this.FGENHBKMPDA().SetTexture(".", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600349B RID: 13467 RVA: 0x0002523B File Offset: 0x0002343B
	private void PFNFPINPCMH()
	{
	}

	// Token: 0x0600349C RID: 13468 RVA: 0x001115B6 File Offset: 0x0010F7B6
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600349D RID: 13469 RVA: 0x001115F0 File Offset: 0x0010F7F0
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1904f)
			{
				this.HBJJOCHGOPH = 1732f;
			}
			this.KAFBNOBOIAJ().SetFloat("EnableRankedNotificationsToggle", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetColor("maps.", this.Pencil_Color);
			this.FGENHBKMPDA().SetFloat("_TimeX", this.Pencil_Size);
			this.MICHFGAOPKM().SetFloat("_TimeX", this.Pencil_Correction);
			this.BAGICADFBAB().SetFloat("_Offsets", this.Intensity);
			this.KHCLIAMBBNC().SetFloat("yyyy-MM-dd HH:mm:ss", this.Speed_Animation);
			this.KEMAALEODNH().SetFloat("No Description", this.Corner_Lose);
			this.MICHFGAOPKM().SetFloat("_ScreenResolution", this.Fade_Paper_to_BackColor);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Fade_With_Original);
			this.DKKBFFHBHJE().SetColor("InfoCanvas", this.Back_Color);
			this.EFMCNLELMDO().SetTexture("play", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600349E RID: 13470 RVA: 0x00111748 File Offset: 0x0010F948
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1807f)
			{
				this.HBJJOCHGOPH = 1761f;
			}
			this.FOOCJIDNGBB().SetFloat("ShadersToggle", this.HBJJOCHGOPH);
			this.FGENHBKMPDA().SetColor("player.redarc", this.Pencil_Color);
			this.ENKPNJMPDEB().SetFloat("settings.arcsdestroydelay", this.Pencil_Size);
			this.FKEOGPDLBDD().SetFloat("Tab1Content", this.Pencil_Correction);
			this.FGENHBKMPDA().SetFloat("_MainTex2", this.Intensity);
			this.KAFBNOBOIAJ().SetFloat("_Value1", this.Speed_Animation);
			this.ADGHJOHKEHG().SetFloat("CameraFilterPack_TV_BrokenGlass_2", this.Corner_Lose);
			this.DOMEEFLPEPJ().SetFloat(",", this.Fade_Paper_to_BackColor);
			this.NBPKMLMCHFN.SetFloat("LoadingStatusText", this.Fade_With_Original);
			this.MLMKCOINOOH().SetColor("CameraFilterPack/Colors_DarkColor", this.Back_Color);
			this.HKHBBBFLGJH().SetTexture("_Distortion", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600349F RID: 13471 RVA: 0x0011189E File Offset: 0x0010FA9E
	private void HJPCJGOEKMF()
	{
		this.FPHEBLMINDA = (Resources.Load("workshop.") as Texture2D);
		this.SCShader = Shader.Find("_TexelOffsetScale");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060034A0 RID: 13472 RVA: 0x0002523B File Offset: 0x0002343B
	private void CPCDFMMLHLO()
	{
	}

	// Token: 0x060034A1 RID: 13473 RVA: 0x0010EC6E File Offset: 0x0010CE6E
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060034A2 RID: 13474 RVA: 0x001118D7 File Offset: 0x0010FAD7
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060034A3 RID: 13475 RVA: 0x0011190E File Offset: 0x0010FB0E
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060034A4 RID: 13476 RVA: 0x00111945 File Offset: 0x0010FB45
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060034A5 RID: 13477 RVA: 0x0011197C File Offset: 0x0010FB7C
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 105f)
			{
				this.HBJJOCHGOPH = 749f;
			}
			this.ADGHJOHKEHG().SetFloat("My New Mod Pack", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetColor("_Near", this.Pencil_Color);
			this.DIOAAHJDMLK().SetFloat("_ScreenResolution", this.Pencil_Size);
			this.ADGHJOHKEHG().SetFloat("_ScreenResolution", this.Pencil_Correction);
			this.DKKBFFHBHJE().SetFloat("ready", this.Intensity);
			this.KEMAALEODNH().SetFloat("_TimeX", this.Speed_Animation);
			this.ACHNOHCLGOO().SetFloat("[DiscordController] Responding no to Ask to Join request", this.Corner_Lose);
			this.KHCLIAMBBNC().SetFloat("#yes", this.Fade_Paper_to_BackColor);
			this.EJDPNJAEAKJ().SetFloat("HighScaleShot", this.Fade_With_Original);
			this.FKEOGPDLBDD().SetColor(": ", this.Back_Color);
			this.ACHNOHCLGOO().SetTexture("float,0", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060034A6 RID: 13478 RVA: 0x0010EC6E File Offset: 0x0010CE6E
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060034A7 RID: 13479 RVA: 0x00111382 File Offset: 0x0010F582
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060034A8 RID: 13480 RVA: 0x00111AD4 File Offset: 0x0010FCD4
	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1483f)
			{
				this.HBJJOCHGOPH = 1473f;
			}
			this.KHCLIAMBBNC().SetFloat("#currentbpm: ", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetColor("_ScreenResolution", this.Pencil_Color);
			this.PLBEJJIHFPB().SetFloat("GlassAberration", this.Pencil_Size);
			this.DOMEEFLPEPJ().SetFloat("_GrainOffsetScale", this.Pencil_Correction);
			this.MICHFGAOPKM().SetFloat("settings.enableranking", this.Intensity);
			this.KEMAALEODNH().SetFloat("_Distance", this.Speed_Animation);
			this.ENKPNJMPDEB().SetFloat("_Value", this.Corner_Lose);
			this.ADGHJOHKEHG().SetFloat("_Value2", this.Fade_Paper_to_BackColor);
			this.PLBEJJIHFPB().SetFloat("RestartButton", this.Fade_With_Original);
			this.HNFFHCLNBDN().SetColor("achievements.21.completed.", this.Back_Color);
			this.EFMCNLELMDO().SetTexture("OK", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060034A9 RID: 13481 RVA: 0x00111C2C File Offset: 0x0010FE2C
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1586f)
			{
				this.HBJJOCHGOPH = 1174f;
			}
			this.ADBKPGFMNKO().SetFloat("_AlphaMask", this.HBJJOCHGOPH);
			this.DIOAAHJDMLK().SetColor("_TimeX", this.Pencil_Color);
			this.DKKBFFHBHJE().SetFloat(" - ", this.Pencil_Size);
			this.BAGICADFBAB().SetFloat("00", this.Pencil_Correction);
			this.HNFFHCLNBDN().SetFloat("BloodAlternative3", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_Size", this.Speed_Animation);
			this.EFMCNLELMDO().SetFloat("_ScreenResolution", this.Corner_Lose);
			this.ADGHJOHKEHG().SetFloat("_ScreenResolution", this.Fade_Paper_to_BackColor);
			this.FKEOGPDLBDD().SetFloat("id", this.Fade_With_Original);
			this.KEMAALEODNH().SetColor("_Value2", this.Back_Color);
			this.CEKJODEAMGB().SetTexture(". We have no such PhotonView! Ignored this if you're leaving a room. State: ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060034AA RID: 13482 RVA: 0x00111D82 File Offset: 0x0010FF82
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060034AB RID: 13483 RVA: 0x00111DB9 File Offset: 0x0010FFB9
	private void PMPKMGKAAJH()
	{
		this.FPHEBLMINDA = (Resources.Load("[Up]") as Texture2D);
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060034AC RID: 13484 RVA: 0x00111DF2 File Offset: 0x0010FFF2
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060034AD RID: 13485 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x060034AE RID: 13486 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x060034AF RID: 13487 RVA: 0x0010EC6E File Offset: 0x0010CE6E
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060034B0 RID: 13488 RVA: 0x00111E2C File Offset: 0x0011002C
	private void GOANCMNGDLE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 124f)
			{
				this.HBJJOCHGOPH = 1569f;
			}
			this.HNFFHCLNBDN().SetFloat("_FixDistance", this.HBJJOCHGOPH);
			this.FGENHBKMPDA().SetColor(" not exist", this.Pencil_Color);
			this.NFKFAAHHLLM().SetFloat("[MapEditor] Updating map assets", this.Pencil_Size);
			this.HCGJCMDJPGD().SetFloat("ComboText", this.Pencil_Correction);
			this.PLBEJJIHFPB().SetFloat("UpdateNewsTileStart", this.Intensity);
			this.HNFFHCLNBDN().SetFloat("_VignetteSettings", this.Speed_Animation);
			this.ACHNOHCLGOO().SetFloat("SetSatelliteTrailWidth", this.Corner_Lose);
			this.FKEOGPDLBDD().SetFloat("_Vibrance", this.Fade_Paper_to_BackColor);
			this.FOOCJIDNGBB().SetFloat("default", this.Fade_With_Original);
			this.NFKFAAHHLLM().SetColor("LT", this.Back_Color);
			this.KEMAALEODNH().SetTexture("ws://", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060034B1 RID: 13489 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x060034B2 RID: 13490 RVA: 0x00111F82 File Offset: 0x00110182
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060034B3 RID: 13491 RVA: 0x0010EC6E File Offset: 0x0010CE6E
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040005CF RID: 1487
	public Shader SCShader;

	// Token: 0x040005D0 RID: 1488
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040005D1 RID: 1489
	public Color Pencil_Color = new Color(0f, 0.371f, 0.78f, 1f);

	// Token: 0x040005D2 RID: 1490
	[Range(0.0001f, 0.0022f)]
	public float Pencil_Size = 0.0008f;

	// Token: 0x040005D3 RID: 1491
	[Range(0f, 2f)]
	public float Pencil_Correction = 0.76f;

	// Token: 0x040005D4 RID: 1492
	[Range(0f, 1f)]
	public float Intensity = 1f;

	// Token: 0x040005D5 RID: 1493
	[Range(0f, 2f)]
	public float Speed_Animation = 1f;

	// Token: 0x040005D6 RID: 1494
	[Range(0f, 1f)]
	public float Corner_Lose = 0.85f;

	// Token: 0x040005D7 RID: 1495
	[Range(0f, 1f)]
	public float Fade_Paper_to_BackColor;

	// Token: 0x040005D8 RID: 1496
	[Range(0f, 1f)]
	public float Fade_With_Original = 1f;

	// Token: 0x040005D9 RID: 1497
	public Color Back_Color = new Color(1f, 1f, 1f, 1f);

	// Token: 0x040005DA RID: 1498
	private Material BJFKDHHMLJH;

	// Token: 0x040005DB RID: 1499
	private Texture2D FPHEBLMINDA;
}
