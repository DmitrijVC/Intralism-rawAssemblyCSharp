using System;
using UnityEngine;

// Token: 0x0200012D RID: 301
[AddComponentMenu("Camera Filter Pack/TV/WideScreenVertical")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_WideScreenVertical : MonoBehaviour
{
	// Token: 0x06005F53 RID: 24403 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06005F54 RID: 24404 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06005F55 RID: 24405 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x06005F56 RID: 24406 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06005F57 RID: 24407 RVA: 0x001D09D0 File Offset: 0x001CEBD0
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 536f)
			{
				this.HBJJOCHGOPH = 492f;
			}
			this.LPDOGGFOBDH().SetFloat("Image effects aren't supported on this device ({0})", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("_Value3", this.Size);
			this.LPDOGGFOBDH().SetFloat("Prints list of commands", this.Smooth);
			this.LONNIJMNKFB().SetFloat("_MainTex2", this.ICABEDDNGIH);
			this.NLFJGMBCICG().SetFloat("Show Title", this.LHOMPJOPKHE);
			this.NLFJGMBCICG().SetVector("#", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1245f, 629f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F58 RID: 24408 RVA: 0x001D0ACF File Offset: 0x001CECCF
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("AddEnvironmentObject");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005F59 RID: 24409 RVA: 0x001D0AF4 File Offset: 0x001CECF4
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1526f)
			{
				this.HBJJOCHGOPH = 208f;
			}
			this.KBOPGONOCNP().SetFloat("Tab2Content", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("CameraFilterPack/FX_DigitalMatrix", this.Size);
			this.MICHFGAOPKM().SetFloat("_ProjInfo", this.Smooth);
			this.NBPKMLMCHFN.SetFloat(" ", this.ICABEDDNGIH);
			this.PDEAHJPOMEF().SetFloat("_TimeX", this.LHOMPJOPKHE);
			this.PDEAHJPOMEF().SetVector("Can't set visible when not in that room.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 673f, 279f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F5A RID: 24410 RVA: 0x001D0BF3 File Offset: 0x001CEDF3
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005F5B RID: 24411 RVA: 0x001D0C2A File Offset: 0x001CEE2A
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F5C RID: 24412 RVA: 0x001D0C48 File Offset: 0x001CEE48
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1003f)
			{
				this.HBJJOCHGOPH = 1011f;
			}
			this.MFHPKGICPIO().SetFloat("offsets", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("ResourceIDInputField", this.Size);
			this.KBOPGONOCNP().SetFloat("Offline", this.Smooth);
			this.IGKFMCPDNOI().SetFloat("_Value1", this.ICABEDDNGIH);
			this.NFKFAAHHLLM().SetFloat("https://bugs.khb-soft.ru/set_project.php?project_id=1", this.LHOMPJOPKHE);
			this.IGKFMCPDNOI().SetVector("AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 711f, 1270f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F5D RID: 24413 RVA: 0x001D0C2A File Offset: 0x001CEE2A
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F5E RID: 24414 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06005F5F RID: 24415 RVA: 0x001D0D48 File Offset: 0x001CEF48
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1989f)
			{
				this.HBJJOCHGOPH = 1738f;
			}
			this.HCGJCMDJPGD().SetFloat("\n\n• ", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetFloat("player.redabstract", this.Size);
			this.NBPKMLMCHFN.SetFloat("ConfigVersionSlider", this.Smooth);
			this.LONNIJMNKFB().SetFloat(" GO:", this.ICABEDDNGIH);
			this.NLFJGMBCICG().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this.LHOMPJOPKHE);
			this.NDMPCDHADMJ().SetVector("init", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1588f, 1986f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F60 RID: 24416 RVA: 0x001D0C2A File Offset: 0x001CEE2A
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F61 RID: 24417 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x17000112 RID: 274
	// (get) Token: 0x06005F62 RID: 24418 RVA: 0x001D0E47 File Offset: 0x001CF047
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

	// Token: 0x06005F63 RID: 24419 RVA: 0x001D0E80 File Offset: 0x001CF080
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 74f)
			{
				this.HBJJOCHGOPH = 1144f;
			}
			this.IGKFMCPDNOI().SetFloat("workshop.", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("_Value", this.Size);
			this.HHIFMIPPMPF().SetFloat("BitsData", this.Smooth);
			this.LONNIJMNKFB().SetFloat("</color>", this.ICABEDDNGIH);
			this.NBPKMLMCHFN.SetFloat("maps.", this.LHOMPJOPKHE);
			this.NDMPCDHADMJ().SetVector("UI Extensions/UI Image Crop", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1615f, 1774f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F64 RID: 24420 RVA: 0x001D0F7F File Offset: 0x001CF17F
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005F65 RID: 24421 RVA: 0x001D0C2A File Offset: 0x001CEE2A
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F66 RID: 24422 RVA: 0x001D0C2A File Offset: 0x001CEE2A
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F67 RID: 24423 RVA: 0x001D0FB6 File Offset: 0x001CF1B6
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-92);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005F68 RID: 24424 RVA: 0x001D0C2A File Offset: 0x001CEE2A
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F69 RID: 24425 RVA: 0x001D0FED File Offset: 0x001CF1ED
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)101;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005F6A RID: 24426 RVA: 0x001D0C2A File Offset: 0x001CEE2A
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F6B RID: 24427 RVA: 0x001D1024 File Offset: 0x001CF224
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("_Saturation");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005F6C RID: 24428 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06005F6D RID: 24429 RVA: 0x001D0C2A File Offset: 0x001CEE2A
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F6E RID: 24430 RVA: 0x001D0C2A File Offset: 0x001CEE2A
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F6F RID: 24431 RVA: 0x001D0C2A File Offset: 0x001CEE2A
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F70 RID: 24432 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005F71 RID: 24433 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x06005F72 RID: 24434 RVA: 0x001D0C2A File Offset: 0x001CEE2A
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F73 RID: 24435 RVA: 0x001D1048 File Offset: 0x001CF248
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005F74 RID: 24436 RVA: 0x001D1080 File Offset: 0x001CF280
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1353f)
			{
				this.HBJJOCHGOPH = 1355f;
			}
			this.NFKFAAHHLLM().SetFloat("_DiffuseColor", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("Set satellite color", this.Size);
			this.MICHFGAOPKM().SetFloat("_Value", this.Smooth);
			this.LONNIJMNKFB().SetFloat("Submit", this.ICABEDDNGIH);
			this.KBOPGONOCNP().SetFloat("_", this.LHOMPJOPKHE);
			this.HHIFMIPPMPF().SetVector("Submition failed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 707f, 158f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F75 RID: 24437 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06005F76 RID: 24438 RVA: 0x001D1180 File Offset: 0x001CF380
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1248f)
			{
				this.HBJJOCHGOPH = 1544f;
			}
			this.LPDOGGFOBDH().SetFloat("player.licenceaccepted", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat(",", this.Size);
			this.NBPKMLMCHFN.SetFloat("No info", this.Smooth);
			this.LPDOGGFOBDH().SetFloat("seconds", this.ICABEDDNGIH);
			this.NLFJGMBCICG().SetFloat("_Value3", this.LHOMPJOPKHE);
			this.NLFJGMBCICG().SetVector("menu.playedpage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 56f, 1076f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F77 RID: 24439 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06005F78 RID: 24440 RVA: 0x001D1280 File Offset: 0x001CF480
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1661f)
			{
				this.HBJJOCHGOPH = 1783f;
			}
			this.LPDOGGFOBDH().SetFloat("#91CCFF", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", this.Size);
			this.LONNIJMNKFB().SetFloat("Joined room ", this.Smooth);
			this.MFHPKGICPIO().SetFloat("_TimeX", this.ICABEDDNGIH);
			this.LONNIJMNKFB().SetFloat("z", this.LHOMPJOPKHE);
			this.PDEAHJPOMEF().SetVector("\\\"", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1133f, 1494f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F79 RID: 24441 RVA: 0x001D137F File Offset: 0x001CF57F
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005F7A RID: 24442 RVA: 0x001D13B8 File Offset: 0x001CF5B8
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1452f)
			{
				this.HBJJOCHGOPH = 995f;
			}
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/TV_Videoflip", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("_Value2", this.Size);
			this.IGKFMCPDNOI().SetFloat("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.", this.Smooth);
			this.MFHPKGICPIO().SetFloat("A", this.ICABEDDNGIH);
			this.NBPKMLMCHFN.SetFloat("[LobbyPlayerElement] On ready click", this.LHOMPJOPKHE);
			this.HCGJCMDJPGD().SetVector(" or player:", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 458f, 1097f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F7B RID: 24443 RVA: 0x001D0C2A File Offset: 0x001CEE2A
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F7C RID: 24444 RVA: 0x001D14B8 File Offset: 0x001CF6B8
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1014f)
			{
				this.HBJJOCHGOPH = 664f;
			}
			this.PDEAHJPOMEF().SetFloat("LevelURLInputField", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("/theme", this.Size);
			this.KBOPGONOCNP().SetFloat("0", this.Smooth);
			this.NBPKMLMCHFN.SetFloat("id", this.ICABEDDNGIH);
			this.HHIFMIPPMPF().SetFloat("Default color's lerp speed of color changing. Greater values means faster changing. 0 - intant change.", this.LHOMPJOPKHE);
			this.MICHFGAOPKM().SetVector("EnableRankingToggle", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1657f, 1375f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F7D RID: 24445 RVA: 0x001D15B8 File Offset: 0x001CF7B8
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1905f)
			{
				this.HBJJOCHGOPH = 1605f;
			}
			this.PDEAHJPOMEF().SetFloat("\\[ *im.*\\](\\n\\n\\n|\\n\\n|\\n|)", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_FullResolutionFiltering", this.Size);
			this.PDEAHJPOMEF().SetFloat("Right Stick Click", this.Smooth);
			this.IGKFMCPDNOI().SetFloat("error", this.ICABEDDNGIH);
			this.LONNIJMNKFB().SetFloat("Result for ", this.LHOMPJOPKHE);
			this.LONNIJMNKFB().SetVector("[LevelEditorScene] Print Audio Wave: Start", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 165f, 1409f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F7E RID: 24446 RVA: 0x001D16B7 File Offset: 0x001CF8B7
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005F7F RID: 24447 RVA: 0x001D16DC File Offset: 0x001CF8DC
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1228f)
			{
				this.HBJJOCHGOPH = 117f;
			}
			this.PDEAHJPOMEF().SetFloat("type", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("value", this.Size);
			this.HCGJCMDJPGD().SetFloat("_Distance", this.Smooth);
			this.KBOPGONOCNP().SetFloat("hand", this.ICABEDDNGIH);
			this.HCGJCMDJPGD().SetFloat("DPADVER", this.LHOMPJOPKHE);
			this.LONNIJMNKFB().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 54f, 1644f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F80 RID: 24448 RVA: 0x001D17DB File Offset: 0x001CF9DB
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find("_MaxRadiusOrKInPaper");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005F81 RID: 24449 RVA: 0x001D0C2A File Offset: 0x001CEE2A
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F82 RID: 24450 RVA: 0x001D1800 File Offset: 0x001CFA00
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 990f)
			{
				this.HBJJOCHGOPH = 1702f;
			}
			this.HHIFMIPPMPF().SetFloat("_MainTex", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("GlassColor", this.Size);
			this.KBOPGONOCNP().SetFloat("settings.fps", this.Smooth);
			this.MICHFGAOPKM().SetFloat(".highscore", this.ICABEDDNGIH);
			this.IGKFMCPDNOI().SetFloat("DPADHOR", this.LHOMPJOPKHE);
			this.LPDOGGFOBDH().SetVector("}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 657f, 955f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F83 RID: 24451 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06005F84 RID: 24452 RVA: 0x001D18FF File Offset: 0x001CFAFF
	private void JKBMKPDGCHG()
	{
		this.SCShader = Shader.Find("Emergency Help:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005F85 RID: 24453 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06005F86 RID: 24454 RVA: 0x001D0C2A File Offset: 0x001CEE2A
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F87 RID: 24455 RVA: 0x001D0C2A File Offset: 0x001CEE2A
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F88 RID: 24456 RVA: 0x001D1923 File Offset: 0x001CFB23
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005F89 RID: 24457 RVA: 0x001D0C2A File Offset: 0x001CEE2A
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F8A RID: 24458 RVA: 0x001D195A File Offset: 0x001CFB5A
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find("#getrewardfailed: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005F8B RID: 24459 RVA: 0x001D0C2A File Offset: 0x001CEE2A
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F8C RID: 24460 RVA: 0x001D1980 File Offset: 0x001CFB80
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1570f)
			{
				this.HBJJOCHGOPH = 620f;
			}
			this.IGKFMCPDNOI().SetFloat("w", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("SpectateButton", this.Size);
			this.MICHFGAOPKM().SetFloat("<size=24>", this.Smooth);
			this.KBOPGONOCNP().SetFloat("Right Stick Click", this.ICABEDDNGIH);
			this.NBPKMLMCHFN.SetFloat("inventory.selected.", this.LHOMPJOPKHE);
			this.MICHFGAOPKM().SetVector("_LightIntensity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 67f, 1674f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F8D RID: 24461 RVA: 0x001D1A7F File Offset: 0x001CFC7F
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005F8E RID: 24462 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06005F8F RID: 24463 RVA: 0x001D1AB6 File Offset: 0x001CFCB6
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005F90 RID: 24464 RVA: 0x001D0FB6 File Offset: 0x001CF1B6
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-92);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005F91 RID: 24465 RVA: 0x001D1ADA File Offset: 0x001CFCDA
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005F92 RID: 24466 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x06005F93 RID: 24467 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x06005F94 RID: 24468 RVA: 0x001D1B11 File Offset: 0x001CFD11
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-126);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005F95 RID: 24469 RVA: 0x001D1B48 File Offset: 0x001CFD48
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Smooth);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.ICABEDDNGIH);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.LHOMPJOPKHE);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F96 RID: 24470 RVA: 0x001D16B7 File Offset: 0x001CF8B7
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005F97 RID: 24471 RVA: 0x001D0C2A File Offset: 0x001CEE2A
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F98 RID: 24472 RVA: 0x001D1C47 File Offset: 0x001CFE47
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_WideScreenVertical");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005F99 RID: 24473 RVA: 0x001D1C6B File Offset: 0x001CFE6B
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("_Value7");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005F9B RID: 24475 RVA: 0x001D1CCE File Offset: 0x001CFECE
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005F9C RID: 24476 RVA: 0x001D1D08 File Offset: 0x001CFF08
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1895f)
			{
				this.HBJJOCHGOPH = 17f;
			}
			this.NBPKMLMCHFN.SetFloat("Editor/", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("DPADHOR", this.Size);
			this.NDMPCDHADMJ().SetFloat("ItemNameText", this.Smooth);
			this.MFHPKGICPIO().SetFloat(".a", this.ICABEDDNGIH);
			this.MICHFGAOPKM().SetFloat("BitsData", this.LHOMPJOPKHE);
			this.NFKFAAHHLLM().SetVector("value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 956f, 369f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F9D RID: 24477 RVA: 0x001D1E07 File Offset: 0x001D0007
	private void DKGBFNCOAEO()
	{
		this.SCShader = Shader.Find("elapsed: {0:0.000}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005F9E RID: 24478 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x06005F9F RID: 24479 RVA: 0x001D1E2C File Offset: 0x001D002C
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 256f)
			{
				this.HBJJOCHGOPH = 875f;
			}
			this.HHIFMIPPMPF().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("Editor/", this.Size);
			this.KBOPGONOCNP().SetFloat("UseScanLine", this.Smooth);
			this.LONNIJMNKFB().SetFloat("Offline", this.ICABEDDNGIH);
			this.NLFJGMBCICG().SetFloat("SaveButton", this.LHOMPJOPKHE);
			this.NFKFAAHHLLM().SetVector("SetSatelliteRotationSpeed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 824f, 417f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FA0 RID: 24480 RVA: 0x001D1F2C File Offset: 0x001D012C
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1163f)
			{
				this.HBJJOCHGOPH = 757f;
			}
			this.HCGJCMDJPGD().SetFloat("_Parameter", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("note.1", this.Size);
			this.HHIFMIPPMPF().SetFloat("MenuScene", this.Smooth);
			this.PDEAHJPOMEF().SetFloat("_ToneCurve", this.ICABEDDNGIH);
			this.NDMPCDHADMJ().SetFloat("_Value", this.LHOMPJOPKHE);
			this.MICHFGAOPKM().SetVector("menutheme.fragout", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 196f, 1363f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FA1 RID: 24481 RVA: 0x001D202B File Offset: 0x001D022B
	private void MJEFMIPLFAB()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005FA2 RID: 24482 RVA: 0x001D204F File Offset: 0x001D024F
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("SetParticlesColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005FA3 RID: 24483 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06005FA4 RID: 24484 RVA: 0x001D2074 File Offset: 0x001D0274
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1857f)
			{
				this.HBJJOCHGOPH = 712f;
			}
			this.LPDOGGFOBDH().SetFloat(" argument(s): ", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("mapselector.filter.rateduponly", this.Size);
			this.KBOPGONOCNP().SetFloat("_TimeX", this.Smooth);
			this.IGKFMCPDNOI().SetFloat("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", this.ICABEDDNGIH);
			this.LPDOGGFOBDH().SetFloat("ItemNameText", this.LHOMPJOPKHE);
			this.IGKFMCPDNOI().SetVector("_Amount", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1157f, 1747f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x04000996 RID: 2454
	public Shader SCShader;

	// Token: 0x04000997 RID: 2455
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000998 RID: 2456
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000999 RID: 2457
	private Material BJFKDHHMLJH;

	// Token: 0x0400099A RID: 2458
	[Range(0f, 0.8f)]
	public float Size = 0.55f;

	// Token: 0x0400099B RID: 2459
	[Range(0.001f, 0.4f)]
	public float Smooth = 0.01f;

	// Token: 0x0400099C RID: 2460
	[Range(0f, 10f)]
	private float ICABEDDNGIH = 1f;

	// Token: 0x0400099D RID: 2461
	[Range(0f, 10f)]
	private float LHOMPJOPKHE = 1f;
}
