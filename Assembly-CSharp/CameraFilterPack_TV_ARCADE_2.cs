using System;
using UnityEngine;

// Token: 0x0200010F RID: 271
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/TV/ARCADE_2")]
public class CameraFilterPack_TV_ARCADE_2 : MonoBehaviour
{
	// Token: 0x06005437 RID: 21559 RVA: 0x001A1661 File Offset: 0x0019F861
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005438 RID: 21560 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06005439 RID: 21561 RVA: 0x001A1698 File Offset: 0x0019F898
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 60f)
			{
				this.HBJJOCHGOPH = 773f;
			}
			this.NBPKMLMCHFN.SetFloat("ViewID {0} {1}{2}", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("_Value3", this.Interferance_Size);
			this.PLBEJJIHFPB().SetFloat("_MatrixSpeed", this.Interferance_Speed);
			this.IGKFMCPDNOI().SetFloat("float,10", this.Contrast);
			this.MICHFGAOPKM().SetFloat("LevelProgressBar", this.Fade);
			this.PLBEJJIHFPB().SetVector("settings.enablehitsoundsinnormal", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1872f, 1355f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600543A RID: 21562 RVA: 0x001A1798 File Offset: 0x0019F998
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1134f)
			{
				this.HBJJOCHGOPH = 1929f;
			}
			this.PLBEJJIHFPB().SetFloat("inventory.selected.", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("Failed to Destroy objects of playerId: ", this.Interferance_Size);
			this.EPCGJFCCAFH().SetFloat("???", this.Interferance_Speed);
			this.NFMGLIKNOOC().SetFloat("[NetworkManager] Found ", this.Contrast);
			this.NBPKMLMCHFN.SetFloat("_EmissionGain", this.Fade);
			this.HCGJCMDJPGD().SetVector("-1", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 807f, 1385f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600543B RID: 21563 RVA: 0x001A1897 File Offset: 0x0019FA97
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600543C RID: 21564 RVA: 0x001A18B4 File Offset: 0x0019FAB4
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1227f)
			{
				this.HBJJOCHGOPH = 588f;
			}
			this.HCGJCMDJPGD().SetFloat(".b", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("_ScreenResolution", this.Interferance_Size);
			this.MICHFGAOPKM().SetFloat("EventMenu", this.Interferance_Speed);
			this.PDEAHJPOMEF().SetFloat("Items/", this.Contrast);
			this.MICHFGAOPKM().SetFloat("Fill", this.Fade);
			this.EPCGJFCCAFH().SetVector(" : ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 254f, 1329f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x170000F4 RID: 244
	// (get) Token: 0x0600543D RID: 21565 RVA: 0x001A19B3 File Offset: 0x0019FBB3
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

	// Token: 0x0600543E RID: 21566 RVA: 0x001A19EA File Offset: 0x0019FBEA
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600543F RID: 21567 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06005440 RID: 21568 RVA: 0x001A1897 File Offset: 0x0019FA97
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005441 RID: 21569 RVA: 0x001A1A21 File Offset: 0x0019FC21
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005442 RID: 21570 RVA: 0x001A1A45 File Offset: 0x0019FC45
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005443 RID: 21571 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06005444 RID: 21572 RVA: 0x001A1A7C File Offset: 0x0019FC7C
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005445 RID: 21573 RVA: 0x001A1897 File Offset: 0x0019FA97
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005446 RID: 21574 RVA: 0x001A1AB3 File Offset: 0x0019FCB3
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("#random #epic #item");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005447 RID: 21575 RVA: 0x001A1AD8 File Offset: 0x0019FCD8
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Interferance_Size);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Interferance_Speed);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Contrast);
			this.NBPKMLMCHFN.SetFloat("Fade", this.Fade);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005448 RID: 21576 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06005449 RID: 21577 RVA: 0x001A1897 File Offset: 0x0019FA97
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600544A RID: 21578 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x0600544B RID: 21579 RVA: 0x001A1BD8 File Offset: 0x0019FDD8
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1959f)
			{
				this.HBJJOCHGOPH = 1688f;
			}
			this.KBOPGONOCNP().SetFloat("settings.cameramovements", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("mapselector.filter.favoriteonly", this.Interferance_Size);
			this.PDEAHJPOMEF().SetFloat("_BaseTex", this.Interferance_Speed);
			this.DOHGBNPMBKG().SetFloat("_Green_B", this.Contrast);
			this.NFMGLIKNOOC().SetFloat("_Blue_G", this.Fade);
			this.IGKFMCPDNOI().SetVector("_ExposureAdjustment", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 440f, 1244f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600544C RID: 21580 RVA: 0x001A1CD7 File Offset: 0x0019FED7
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600544D RID: 21581 RVA: 0x001A1D0E File Offset: 0x0019FF0E
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("\n\n#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600544E RID: 21582 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600544F RID: 21583 RVA: 0x001A1D34 File Offset: 0x0019FF34
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1516f)
			{
				this.HBJJOCHGOPH = 1504f;
			}
			this.KBOPGONOCNP().SetFloat("Turn", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("_TimeX", this.Interferance_Size);
			this.NFMGLIKNOOC().SetFloat("_Value3", this.Interferance_Speed);
			this.MICHFGAOPKM().SetFloat("_BlurRadius4", this.Contrast);
			this.HCGJCMDJPGD().SetFloat("#no", this.Fade);
			this.PDEAHJPOMEF().SetVector("_BlurParams", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 582f, 944f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005450 RID: 21584 RVA: 0x001A1E33 File Offset: 0x001A0033
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_ARCADE_2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005451 RID: 21585 RVA: 0x001A1E57 File Offset: 0x001A0057
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005452 RID: 21586 RVA: 0x001A1E8E File Offset: 0x001A008E
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("menu.enableselectormusic");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005453 RID: 21587 RVA: 0x001A1EB2 File Offset: 0x001A00B2
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005454 RID: 21588 RVA: 0x001A1EEC File Offset: 0x001A00EC
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1515f)
			{
				this.HBJJOCHGOPH = 1004f;
			}
			this.DOHGBNPMBKG().SetFloat("CameraFilterPack/AAA_Super_Hexagon", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("CameraFilterPack/Noise_TV", this.Interferance_Size);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Interferance_Speed);
			this.DOHGBNPMBKG().SetFloat("Joystick1Button4", this.Contrast);
			this.HCGJCMDJPGD().SetFloat("_TargetScale", this.Fade);
			this.EPCGJFCCAFH().SetVector("[Singleton] An instance of '", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1481f, 9f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005455 RID: 21589 RVA: 0x001A1FEB File Offset: 0x001A01EB
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("duration");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005456 RID: 21590 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x06005457 RID: 21591 RVA: 0x001A2010 File Offset: 0x001A0210
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 819f)
			{
				this.HBJJOCHGOPH = 1355f;
			}
			this.HCGJCMDJPGD().SetFloat("_Value7", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("CameraFilterPack/EyesVision_1", this.Interferance_Size);
			this.NBPKMLMCHFN.SetFloat("_FadeFX", this.Interferance_Speed);
			this.MICHFGAOPKM().SetFloat("menu.selectedlevelid", this.Contrast);
			this.MICHFGAOPKM().SetFloat("unsubscribemap", this.Fade);
			this.PDEAHJPOMEF().SetVector("Error! no audio sources attached to AudioSampler.css", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 369f, 1015f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005458 RID: 21592 RVA: 0x001A210F File Offset: 0x001A030F
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("1234332714");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005459 RID: 21593 RVA: 0x001A1897 File Offset: 0x0019FA97
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600545A RID: 21594 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x0600545B RID: 21595 RVA: 0x001A1897 File Offset: 0x0019FA97
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600545C RID: 21596 RVA: 0x001A2133 File Offset: 0x001A0333
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("_ProjInfo");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600545D RID: 21597 RVA: 0x001A2158 File Offset: 0x001A0358
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1212f)
			{
				this.HBJJOCHGOPH = 234f;
			}
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("_Intensity", this.Interferance_Size);
			this.NFMGLIKNOOC().SetFloat("%", this.Interferance_Speed);
			this.HCGJCMDJPGD().SetFloat("_SpawnHeuristic", this.Contrast);
			this.NBPKMLMCHFN.SetFloat("t", this.Fade);
			this.NBPKMLMCHFN.SetVector("CameraFilterPack/Distortion_Flush", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 272f, 869f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600545E RID: 21598 RVA: 0x001A1897 File Offset: 0x0019FA97
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600545F RID: 21599 RVA: 0x001A1661 File Offset: 0x0019F861
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005460 RID: 21600 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06005461 RID: 21601 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06005462 RID: 21602 RVA: 0x001A2258 File Offset: 0x001A0458
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1278f)
			{
				this.HBJJOCHGOPH = 1890f;
			}
			this.HCGJCMDJPGD().SetFloat("_Value", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("Please attach component to a Graphical UI component", this.Interferance_Size);
			this.KBOPGONOCNP().SetFloat("2hands", this.Interferance_Speed);
			this.KBOPGONOCNP().SetFloat("Prints the number of logs currently held by DebugLogs", this.Contrast);
			this.NFMGLIKNOOC().SetFloat("Load Game", this.Fade);
			this.DOHGBNPMBKG().SetVector("plogs", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1748f, 719f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005463 RID: 21603 RVA: 0x001A2357 File Offset: 0x001A0557
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005464 RID: 21604 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06005465 RID: 21605 RVA: 0x001A238E File Offset: 0x001A058E
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005467 RID: 21607 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x040008CA RID: 2250
	public Shader SCShader;

	// Token: 0x040008CB RID: 2251
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040008CC RID: 2252
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040008CD RID: 2253
	private Material BJFKDHHMLJH;

	// Token: 0x040008CE RID: 2254
	[Range(0f, 10f)]
	public float Interferance_Size = 1f;

	// Token: 0x040008CF RID: 2255
	[Range(0f, 10f)]
	public float Interferance_Speed = 0.5f;

	// Token: 0x040008D0 RID: 2256
	[Range(0f, 10f)]
	public float Contrast = 1f;

	// Token: 0x040008D1 RID: 2257
	[Range(0f, 1f)]
	public float Fade = 1f;
}
