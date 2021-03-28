using System;
using UnityEngine;

// Token: 0x0200008D RID: 141
[AddComponentMenu("Camera Filter Pack/Distortion/Half_Sphere")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_Half_Sphere : MonoBehaviour
{
	// Token: 0x060028DC RID: 10460 RVA: 0x000E1C32 File Offset: 0x000DFE32
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060028DD RID: 10461 RVA: 0x000E1C69 File Offset: 0x000DFE69
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060028DE RID: 10462 RVA: 0x000E1CA0 File Offset: 0x000DFEA0
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find("PLEASE WAIT");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060028DF RID: 10463 RVA: 0x000E1CC4 File Offset: 0x000DFEC4
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060028E0 RID: 10464 RVA: 0x000E1CFC File Offset: 0x000DFEFC
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 827f)
			{
				this.HBJJOCHGOPH = 800f;
			}
			this.IONHGBPGCHK().SetFloat("_SunThreshold", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat(".icon", this.SphereSize);
			this.EFMCNLELMDO().SetFloat("CameraFilterPack/Drawing_Laplacian", this.SpherePositionX);
			this.PHGCJOPFDOG().SetFloat("ResourceIDInputField", this.SpherePositionY);
			this.FGENHBKMPDA().SetFloat("CameraFilterPack/Blur_Bloom", this.Strength);
			this.EOCCJGIGEGJ().SetVector("finished", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060028E1 RID: 10465 RVA: 0x000E1DF4 File Offset: 0x000DFFF4
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060028E2 RID: 10466 RVA: 0x000E1E14 File Offset: 0x000E0014
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 527f)
			{
				this.HBJJOCHGOPH = 1953f;
			}
			this.CEKJODEAMGB().SetFloat("_BlurDistance", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("accuracy", this.SphereSize);
			this.FGENHBKMPDA().SetFloat("player.mysteryitem", this.SpherePositionX);
			this.KAFBNOBOIAJ().SetFloat("_Bloom5", this.SpherePositionY);
			this.MFHPKGICPIO().SetFloat("LoadPlayerEnvironment", this.Strength);
			this.NBPKMLMCHFN.SetVector("_Far", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060028E3 RID: 10467 RVA: 0x000E1F0C File Offset: 0x000E010C
	private void JKBMKPDGCHG()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060028E4 RID: 10468 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOLDLDLFFLM()
	{
	}

	// Token: 0x060028E5 RID: 10469 RVA: 0x000E1F30 File Offset: 0x000E0130
	private Material GJHPODJOBHL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x17000072 RID: 114
	// (get) Token: 0x060028E6 RID: 10470 RVA: 0x000E1F67 File Offset: 0x000E0167
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

	// Token: 0x060028E7 RID: 10471 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x060028E8 RID: 10472 RVA: 0x000E1DF4 File Offset: 0x000DFFF4
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060028E9 RID: 10473 RVA: 0x000E1F9E File Offset: 0x000E019E
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("green");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060028EA RID: 10474 RVA: 0x000E1FC4 File Offset: 0x000E01C4
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1629f)
			{
				this.HBJJOCHGOPH = 975f;
			}
			this.NLFJGMBCICG().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("CameraFilterPack_3D_Computer1", this.SphereSize);
			this.LPMLLJKMAMP().SetFloat("_Value6", this.SpherePositionX);
			this.GJHPODJOBHL().SetFloat(" in SaveLoadMenu.prefabDictionary!", this.SpherePositionY);
			this.GKILCDHJFEG().SetFloat("_TimeX", this.Strength);
			this.GJHPODJOBHL().SetVector("mapselector.orderby", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060028EB RID: 10475 RVA: 0x000E20BC File Offset: 0x000E02BC
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-125);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060028EC RID: 10476 RVA: 0x000E20F3 File Offset: 0x000E02F3
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("_AccumOrig");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060028ED RID: 10477 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x060028EE RID: 10478 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060028EF RID: 10479 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x060028F0 RID: 10480 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x060028F1 RID: 10481 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x060028F2 RID: 10482 RVA: 0x000E2117 File Offset: 0x000E0317
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find("_Visualize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060028F3 RID: 10483 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x060028F4 RID: 10484 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x060028F5 RID: 10485 RVA: 0x000E213B File Offset: 0x000E033B
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060028F6 RID: 10486 RVA: 0x000E2172 File Offset: 0x000E0372
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060028F7 RID: 10487 RVA: 0x000E2196 File Offset: 0x000E0396
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-92);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060028F8 RID: 10488 RVA: 0x000E1DF4 File Offset: 0x000DFFF4
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060028F9 RID: 10489 RVA: 0x000E1DF4 File Offset: 0x000DFFF4
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060028FA RID: 10490 RVA: 0x000E21D0 File Offset: 0x000E03D0
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 652f)
			{
				this.HBJJOCHGOPH = 1127f;
			}
			this.JLHLHKPHDFO().SetFloat("ControllerRightX", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("PublishButton", this.SphereSize);
			this.GCDFNHMJMIP().SetFloat("_Value", this.SpherePositionX);
			this.MFHPKGICPIO().SetFloat("Editing: ", this.SpherePositionY);
			this.EOCCJGIGEGJ().SetFloat("[PlayerController] ", this.Strength);
			this.PHGCJOPFDOG().SetVector("MouseY", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060028FB RID: 10491 RVA: 0x000E22C8 File Offset: 0x000E04C8
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060028FC RID: 10492 RVA: 0x000E22FF File Offset: 0x000E04FF
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060028FD RID: 10493 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x060028FE RID: 10494 RVA: 0x000E2323 File Offset: 0x000E0523
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060028FF RID: 10495 RVA: 0x000E235A File Offset: 0x000E055A
	private Material PHGCJOPFDOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002900 RID: 10496 RVA: 0x000E2391 File Offset: 0x000E0591
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002901 RID: 10497 RVA: 0x000E23C8 File Offset: 0x000E05C8
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 297f)
			{
				this.HBJJOCHGOPH = 1333f;
			}
			this.JLHLHKPHDFO().SetFloat("Unable to get a reward! Try again?", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("_Bullet_12", this.SphereSize);
			this.EOCCJGIGEGJ().SetFloat("Changed config", this.SpherePositionX);
			this.IONHGBPGCHK().SetFloat("_History2Weight", this.SpherePositionY);
			this.JLHLHKPHDFO().SetFloat("Prints list of commands", this.Strength);
			this.MCDGIILBNIF().SetVector(":", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002902 RID: 10498 RVA: 0x000E1DF4 File Offset: 0x000DFFF4
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002903 RID: 10499 RVA: 0x000E24C0 File Offset: 0x000E06C0
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("UsernameText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002904 RID: 10500 RVA: 0x000E1DF4 File Offset: 0x000DFFF4
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002905 RID: 10501 RVA: 0x000E1DF4 File Offset: 0x000DFFF4
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002906 RID: 10502 RVA: 0x000E24E4 File Offset: 0x000E06E4
	private void COOHIILCOCO()
	{
		this.SCShader = Shader.Find("\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002907 RID: 10503 RVA: 0x000E1DF4 File Offset: 0x000DFFF4
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002908 RID: 10504 RVA: 0x000E1DF4 File Offset: 0x000DFFF4
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002909 RID: 10505 RVA: 0x000E2508 File Offset: 0x000E0708
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600290A RID: 10506 RVA: 0x000E253F File Offset: 0x000E073F
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600290B RID: 10507 RVA: 0x000E2576 File Offset: 0x000E0776
	private void JECMJNFGBGC()
	{
		this.SCShader = Shader.Find("Set Satellite Trail Width");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600290C RID: 10508 RVA: 0x000E1DF4 File Offset: 0x000DFFF4
	private void NNBCLMJGFEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600290D RID: 10509 RVA: 0x000E259A File Offset: 0x000E079A
	private void HAIAHJPCPAG()
	{
		this.SCShader = Shader.Find("Editor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600290E RID: 10510 RVA: 0x000E1DF4 File Offset: 0x000DFFF4
	private void ABEIEGDHBNO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600290F RID: 10511 RVA: 0x000E25BE File Offset: 0x000E07BE
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002910 RID: 10512 RVA: 0x000E25F5 File Offset: 0x000E07F5
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find("_Intensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002911 RID: 10513 RVA: 0x000E1DF4 File Offset: 0x000DFFF4
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002912 RID: 10514 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x06002913 RID: 10515 RVA: 0x000E261C File Offset: 0x000E081C
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 994f)
			{
				this.HBJJOCHGOPH = 1613f;
			}
			this.IONHGBPGCHK().SetFloat("Set satellite trail length in seconds", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("_Value", this.SphereSize);
			this.AELJLBOJAIL().SetFloat("12", this.SpherePositionX);
			this.MFHPKGICPIO().SetFloat("maps.", this.SpherePositionY);
			this.KAFBNOBOIAJ().SetFloat("_XCrop", this.Strength);
			this.LPMLLJKMAMP().SetVector("note.1", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002914 RID: 10516 RVA: 0x000E1DF4 File Offset: 0x000DFFF4
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002915 RID: 10517 RVA: 0x000E1DF4 File Offset: 0x000DFFF4
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002916 RID: 10518 RVA: 0x000E2714 File Offset: 0x000E0914
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("[BuildInfo] Error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002917 RID: 10519 RVA: 0x000E2738 File Offset: 0x000E0938
	private void DKGBFNCOAEO()
	{
		this.SCShader = Shader.Find("88f00bdf0ad61b16b803971ebe071962");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002918 RID: 10520 RVA: 0x000E275C File Offset: 0x000E095C
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 780f)
			{
				this.HBJJOCHGOPH = 1585f;
			}
			this.GKILCDHJFEG().SetFloat("#no", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("player.licenceaccepted", this.SphereSize);
			this.KAFBNOBOIAJ().SetFloat("maps.", this.SpherePositionX);
			this.NFMGLIKNOOC().SetFloat("points:", this.SpherePositionY);
			this.GKILCDHJFEG().SetFloat("_Value4", this.Strength);
			this.EFMCNLELMDO().SetVector(": ", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002919 RID: 10521 RVA: 0x000E2854 File Offset: 0x000E0A54
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600291A RID: 10522 RVA: 0x000E1DF4 File Offset: 0x000DFFF4
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600291B RID: 10523 RVA: 0x000E288C File Offset: 0x000E0A8C
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 127f)
			{
				this.HBJJOCHGOPH = 501f;
			}
			this.MFHPKGICPIO().SetFloat("_Blend", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("Item ", this.SphereSize);
			this.FGENHBKMPDA().SetFloat("). ", this.SpherePositionX);
			this.GJHPODJOBHL().SetFloat("From {0} at Index {1} \n", this.SpherePositionY);
			this.AELJLBOJAIL().SetFloat("_SunColor", this.Strength);
			this.PDEAHJPOMEF().SetVector("settings.crosshairopacity", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600291C RID: 10524 RVA: 0x000E2984 File Offset: 0x000E0B84
	private void HJPCJGOEKMF()
	{
		this.SCShader = Shader.Find("MaxLivesSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600291D RID: 10525 RVA: 0x000E29A8 File Offset: 0x000E0BA8
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 931f)
			{
				this.HBJJOCHGOPH = 477f;
			}
			this.GCDFNHMJMIP().SetFloat("Multiplayer", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("ItemNameText", this.SphereSize);
			this.GCDFNHMJMIP().SetFloat(".highscore", this.SpherePositionX);
			this.NBPKMLMCHFN.SetFloat("_Blend", this.SpherePositionY);
			this.JLHLHKPHDFO().SetFloat("skin.hit_perfect", this.Strength);
			this.LPMLLJKMAMP().SetVector("_FarCamera", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600291E RID: 10526 RVA: 0x000E2AA0 File Offset: 0x000E0CA0
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600291F RID: 10527 RVA: 0x000E259A File Offset: 0x000E079A
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("Editor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002920 RID: 10528 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x06002921 RID: 10529 RVA: 0x0002523B File Offset: 0x0002343B
	private void EPJJDKJEDMM()
	{
	}

	// Token: 0x06002922 RID: 10530 RVA: 0x000E2AD8 File Offset: 0x000E0CD8
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
			this.NBPKMLMCHFN.SetFloat("_SphereSize", this.SphereSize);
			this.NBPKMLMCHFN.SetFloat("_SpherePositionX", this.SpherePositionX);
			this.NBPKMLMCHFN.SetFloat("_SpherePositionY", this.SpherePositionY);
			this.NBPKMLMCHFN.SetFloat("_Strength", this.Strength);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002923 RID: 10531 RVA: 0x000E1DF4 File Offset: 0x000DFFF4
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002924 RID: 10532 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x06002925 RID: 10533 RVA: 0x000E2BD0 File Offset: 0x000E0DD0
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("_SSRMultiplier");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002926 RID: 10534 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06002927 RID: 10535 RVA: 0x000E2BF4 File Offset: 0x000E0DF4
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find(" - ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002928 RID: 10536 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x06002929 RID: 10537 RVA: 0x000E2C18 File Offset: 0x000E0E18
	private void ODBNMPGBCGO()
	{
		this.SCShader = Shader.Find("ChallengesButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600292A RID: 10538 RVA: 0x000E2C3C File Offset: 0x000E0E3C
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600292B RID: 10539 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x0600292D RID: 10541 RVA: 0x000E2C9C File Offset: 0x000E0E9C
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1969f)
			{
				this.HBJJOCHGOPH = 1698f;
			}
			this.HEHKGPKLAKK().SetFloat("inventory.selected.", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("CompletedLevel", this.SphereSize);
			this.MFHPKGICPIO().SetFloat("null", this.SpherePositionX);
			this.AELJLBOJAIL().SetFloat("_Value6", this.SpherePositionY);
			this.MFHPKGICPIO().SetFloat("_MaxBlurRadius", this.Strength);
			this.JLHLHKPHDFO().SetVector("_Blue_B", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600292E RID: 10542 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x0600292F RID: 10543 RVA: 0x000E2D94 File Offset: 0x000E0F94
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 579f)
			{
				this.HBJJOCHGOPH = 1377f;
			}
			this.JLHLHKPHDFO().SetFloat("_Threshold", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("menutheme.27thfloor", this.SphereSize);
			this.NFMGLIKNOOC().SetFloat("The image effect ", this.SpherePositionX);
			this.FGENHBKMPDA().SetFloat("_ScreenResolution", this.SpherePositionY);
			this.MFHPKGICPIO().SetFloat("The given 2D texture ", this.Strength);
			this.HEHKGPKLAKK().SetVector("Editor/", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002930 RID: 10544 RVA: 0x000E2E8C File Offset: 0x000E108C
	private void LGHCJCFHEMF()
	{
		this.SCShader = Shader.Find("playing");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002931 RID: 10545 RVA: 0x000E2EB0 File Offset: 0x000E10B0
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002932 RID: 10546 RVA: 0x000E1F0C File Offset: 0x000E010C
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002933 RID: 10547 RVA: 0x000E2ED4 File Offset: 0x000E10D4
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 588f)
			{
				this.HBJJOCHGOPH = 1288f;
			}
			this.GCDFNHMJMIP().SetFloat("EndlessLoopsScoreText", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("Created by ", this.SphereSize);
			this.LPMLLJKMAMP().SetFloat("player.blackwhite", this.SpherePositionX);
			this.JLHLHKPHDFO().SetFloat("CheckpointsScoreText", this.SpherePositionY);
			this.JLHLHKPHDFO().SetFloat("Joystick1Button1", this.Strength);
			this.NLFJGMBCICG().SetVector(".played", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002934 RID: 10548 RVA: 0x000E1DF4 File Offset: 0x000DFFF4
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002935 RID: 10549 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x06002936 RID: 10550 RVA: 0x000E2FCC File Offset: 0x000E11CC
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002937 RID: 10551 RVA: 0x000E1DF4 File Offset: 0x000DFFF4
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002938 RID: 10552 RVA: 0x000E3003 File Offset: 0x000E1203
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find("ShowTitle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002939 RID: 10553 RVA: 0x000E3027 File Offset: 0x000E1227
	private void JDKHBGDEONK()
	{
		this.SCShader = Shader.Find("System.Single");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600293A RID: 10554 RVA: 0x000E304B File Offset: 0x000E124B
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("</color>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600293B RID: 10555 RVA: 0x000E3070 File Offset: 0x000E1270
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 714f)
			{
				this.HBJJOCHGOPH = 1250f;
			}
			this.PHGCJOPFDOG().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("ShadersToggle", this.SphereSize);
			this.PHGCJOPFDOG().SetFloat("UseFinalGlassColor", this.SpherePositionX);
			this.MFHPKGICPIO().SetFloat(" registered.", this.SpherePositionY);
			this.PHGCJOPFDOG().SetFloat("_Offsets", this.Strength);
			this.HEHKGPKLAKK().SetVector("_Value4", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600293C RID: 10556 RVA: 0x000E3168 File Offset: 0x000E1368
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 917f)
			{
				this.HBJJOCHGOPH = 709f;
			}
			this.JLHLHKPHDFO().SetFloat("Joystick1Button0", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Item ", this.SphereSize);
			this.GJHPODJOBHL().SetFloat("88f00bdf0ad61b16b803971ebe071962", this.SpherePositionX);
			this.NFMGLIKNOOC().SetFloat("_TimeX", this.SpherePositionY);
			this.PHGCJOPFDOG().SetFloat("/", this.Strength);
			this.EFMCNLELMDO().SetVector("Right Stick Click", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600293D RID: 10557 RVA: 0x000E3260 File Offset: 0x000E1460
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1910f)
			{
				this.HBJJOCHGOPH = 1710f;
			}
			this.EFMCNLELMDO().SetFloat("_FixDistance", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("_Value2", this.SphereSize);
			this.PDEAHJPOMEF().SetFloat("null", this.SpherePositionX);
			this.KAFBNOBOIAJ().SetFloat("_Value2", this.SpherePositionY);
			this.EOCCJGIGEGJ().SetFloat("CameraFilterPack/3D_Matrix", this.Strength);
			this.FGENHBKMPDA().SetVector("CameraFilterPack/FX_Hexagon", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600293E RID: 10558 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x0600293F RID: 10559 RVA: 0x000E3358 File Offset: 0x000E1558
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_Half_Sphere");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002940 RID: 10560 RVA: 0x000E1DF4 File Offset: 0x000DFFF4
	private void DKPBBJINKMG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002941 RID: 10561 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06002942 RID: 10562 RVA: 0x000E337C File Offset: 0x000E157C
	private Material EFMCNLELMDO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002943 RID: 10563 RVA: 0x000E33B4 File Offset: 0x000E15B4
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 923f)
			{
				this.HBJJOCHGOPH = 1625f;
			}
			this.PDEAHJPOMEF().SetFloat("cancel", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("_Value3", this.SphereSize);
			this.JLHLHKPHDFO().SetFloat("selColor", this.SpherePositionX);
			this.CEKJODEAMGB().SetFloat("achievements.21.progress", this.SpherePositionY);
			this.HEHKGPKLAKK().SetFloat("_TimeX", this.Strength);
			this.FGENHBKMPDA().SetVector("_TimeX", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002944 RID: 10564 RVA: 0x000E34AC File Offset: 0x000E16AC
	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 59f)
			{
				this.HBJJOCHGOPH = 1575f;
			}
			this.PHGCJOPFDOG().SetFloat("Preparing content", this.HBJJOCHGOPH);
			this.PHGCJOPFDOG().SetFloat(") but there is no recycle bin setup for it. Falling back to Instantiate", this.SphereSize);
			this.EFMCNLELMDO().SetFloat(".lastCheckpoint.comboScore", this.SpherePositionX);
			this.EFMCNLELMDO().SetFloat(":</b> ", this.SpherePositionY);
			this.NLFJGMBCICG().SetFloat("_EmissionColor", this.Strength);
			this.PHGCJOPFDOG().SetVector("back", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002945 RID: 10565 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x040004FE RID: 1278
	public Shader SCShader;

	// Token: 0x040004FF RID: 1279
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000500 RID: 1280
	[Range(1f, 6f)]
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000501 RID: 1281
	private Material BJFKDHHMLJH;

	// Token: 0x04000502 RID: 1282
	public float SphereSize = 2.5f;

	// Token: 0x04000503 RID: 1283
	[Range(-1f, 1f)]
	public float SpherePositionX;

	// Token: 0x04000504 RID: 1284
	[Range(-1f, 1f)]
	public float SpherePositionY;

	// Token: 0x04000505 RID: 1285
	[Range(1f, 10f)]
	public float Strength = 5f;
}
