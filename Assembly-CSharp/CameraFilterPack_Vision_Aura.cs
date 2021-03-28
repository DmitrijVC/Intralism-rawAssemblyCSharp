using System;
using UnityEngine;

// Token: 0x0200012F RID: 303
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Vision/Aura")]
public class CameraFilterPack_Vision_Aura : MonoBehaviour
{
	// Token: 0x06005FEE RID: 24558 RVA: 0x001D33FD File Offset: 0x001D15FD
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005FEF RID: 24559 RVA: 0x001D3434 File Offset: 0x001D1634
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("#failed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005FF0 RID: 24560 RVA: 0x001D3458 File Offset: 0x001D1658
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 834f)
			{
				this.HBJJOCHGOPH = 635f;
			}
			this.EFDEIFCDAFG().SetFloat("?", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("Image", this.Twist);
			this.HNICHJCGJOC().SetColor(" {0}", this.Color);
			this.DOHGBNPMBKG().SetFloat("RarityImage", this.PosX);
			this.EFDEIFCDAFG().SetFloat("_Value4", this.PosY);
			this.JFDGLLEOPGB().SetFloat("offsets", this.Speed);
			this.EFDEIFCDAFG().SetVector("_FarCamera", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 84f, 1336f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FF1 RID: 24561 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005FF2 RID: 24562 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06005FF3 RID: 24563 RVA: 0x001D3570 File Offset: 0x001D1770
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 655f)
			{
				this.HBJJOCHGOPH = 917f;
			}
			this.EFDEIFCDAFG().SetFloat("mainMenu", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("Editor", this.Twist);
			this.NBPKMLMCHFN.SetColor("}", this.Color);
			this.IGKFMCPDNOI().SetFloat(": ", this.PosX);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.PosY);
			this.EFDEIFCDAFG().SetFloat("_Gamma", this.Speed);
			this.NBPKMLMCHFN.SetVector("settings_bindings_", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 693f, 1285f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FF4 RID: 24564 RVA: 0x001D3685 File Offset: 0x001D1885
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("menu.tabid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005FF5 RID: 24565 RVA: 0x001D36A9 File Offset: 0x001D18A9
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005FF6 RID: 24566 RVA: 0x001D36E0 File Offset: 0x001D18E0
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1012f)
			{
				this.HBJJOCHGOPH = 1064f;
			}
			this.JFDGLLEOPGB().SetFloat("Copy from ", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("/", this.Twist);
			this.KEMAALEODNH().SetColor("Joystick1Button11", this.Color);
			this.FAIFBBGFAIB().SetFloat("ScrollPanel", this.PosX);
			this.IGKFMCPDNOI().SetFloat("Init", this.PosY);
			this.JFDGLLEOPGB().SetFloat("/music", this.Speed);
			this.KEMAALEODNH().SetVector("DPADHOR", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1926f, 968f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FF7 RID: 24567 RVA: 0x001D37F8 File Offset: 0x001D19F8
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 758f)
			{
				this.HBJJOCHGOPH = 86f;
			}
			this.FAIFBBGFAIB().SetFloat("Show Title", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat(".lastCheckpoint.lives", this.Twist);
			this.HHIFMIPPMPF().SetColor("STICKLHOR", this.Color);
			this.HHIFMIPPMPF().SetFloat("steamid", this.PosX);
			this.EFDEIFCDAFG().SetFloat("CameraFilterPack/Pixel_Pixelisation", this.PosY);
			this.HHIFMIPPMPF().SetFloat("ConfigVersionSlider", this.Speed);
			this.DBOLLHHMKKN().SetVector("1332644700", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 507f, 19f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FF8 RID: 24568 RVA: 0x001D390D File Offset: 0x001D1B0D
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005FF9 RID: 24569 RVA: 0x001D392A File Offset: 0x001D1B2A
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("Joystick1Button4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005FFA RID: 24570 RVA: 0x001D394E File Offset: 0x001D1B4E
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)118;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005FFB RID: 24571 RVA: 0x001D390D File Offset: 0x001D1B0D
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005FFC RID: 24572 RVA: 0x001D3988 File Offset: 0x001D1B88
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 105f)
			{
				this.HBJJOCHGOPH = 4f;
			}
			this.HHIFMIPPMPF().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("CameraFilterPack/Blend2Camera_Lighten", this.Twist);
			this.HHIFMIPPMPF().SetColor("CameraFilterPack/FX_Hexagon_Black", this.Color);
			this.DBOLLHHMKKN().SetFloat("_TapMedium", this.PosX);
			this.DBOLLHHMKKN().SetFloat("CameraFilterPack/Glasses_On", this.PosY);
			this.JFDGLLEOPGB().SetFloat("_Value4", this.Speed);
			this.DBOLLHHMKKN().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 824f, 1884f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FFE RID: 24574 RVA: 0x001D390D File Offset: 0x001D1B0D
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005FFF RID: 24575 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06006000 RID: 24576 RVA: 0x001D3B04 File Offset: 0x001D1D04
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1716f)
			{
				this.HBJJOCHGOPH = 463f;
			}
			this.DOHGBNPMBKG().SetFloat("score", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("Player", this.Twist);
			this.EFDEIFCDAFG().SetColor("Children", this.Color);
			this.FAIFBBGFAIB().SetFloat("win", this.PosX);
			this.HHIFMIPPMPF().SetFloat("_Value", this.PosY);
			this.JFDGLLEOPGB().SetFloat("sounds/hit_wrong", this.Speed);
			this.DOHGBNPMBKG().SetVector("SetParticlesCountPerBeat", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1633f, 1960f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006001 RID: 24577 RVA: 0x001D3C19 File Offset: 0x001D1E19
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006002 RID: 24578 RVA: 0x001D390D File Offset: 0x001D1B0D
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006003 RID: 24579 RVA: 0x001D3C50 File Offset: 0x001D1E50
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-70);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006004 RID: 24580 RVA: 0x001D3C88 File Offset: 0x001D1E88
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Twist);
			this.NBPKMLMCHFN.SetColor("_Value2", this.Color);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.PosX);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.PosY);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Speed);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006005 RID: 24581 RVA: 0x001D3DA0 File Offset: 0x001D1FA0
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1841f)
			{
				this.HBJJOCHGOPH = 982f;
			}
			this.HNICHJCGJOC().SetFloat("/GetNews/pinnednewsid", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("_Max", this.Twist);
			this.HHIFMIPPMPF().SetColor("settings.volume.sfx", this.Color);
			this.KEMAALEODNH().SetFloat("_TimeX", this.PosX);
			this.HHIFMIPPMPF().SetFloat("STICKLHOR", this.PosY);
			this.IGKFMCPDNOI().SetFloat("_Value3", this.Speed);
			this.EFDEIFCDAFG().SetVector("Tab2Content", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1360f, 1494f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006006 RID: 24582 RVA: 0x001D3EB5 File Offset: 0x001D20B5
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)117;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006007 RID: 24583 RVA: 0x001D3EEC File Offset: 0x001D20EC
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006008 RID: 24584 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06006009 RID: 24585 RVA: 0x001D390D File Offset: 0x001D1B0D
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600600A RID: 24586 RVA: 0x001D3F23 File Offset: 0x001D2123
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600600B RID: 24587 RVA: 0x001D3F5C File Offset: 0x001D215C
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1776f)
			{
				this.HBJJOCHGOPH = 519f;
			}
			this.JFDGLLEOPGB().SetFloat("GameVolumeSlider", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("HightScoreMaxPointsText", this.Twist);
			this.JFDGLLEOPGB().SetColor("Hidden/Subpixel Morphological Anti-aliasing", this.Color);
			this.HNICHJCGJOC().SetFloat("settings.shaders", this.PosX);
			this.DBOLLHHMKKN().SetFloat(" scene: ", this.PosY);
			this.HHIFMIPPMPF().SetFloat("CameraFilterPack_AAA_Blood1", this.Speed);
			this.NBPKMLMCHFN.SetVector("_LowRez", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 216f, 501f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600600C RID: 24588 RVA: 0x001D4071 File Offset: 0x001D2271
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)108;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600600D RID: 24589 RVA: 0x001D40A8 File Offset: 0x001D22A8
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1679f)
			{
				this.HBJJOCHGOPH = 1994f;
			}
			this.EFDEIFCDAFG().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("LevelConfigButton", this.Twist);
			this.DBOLLHHMKKN().SetColor("#score", this.Color);
			this.JFDGLLEOPGB().SetFloat("Updated!", this.PosX);
			this.HNICHJCGJOC().SetFloat("Custom Authentication failed (either due to user-input or configuration or AuthParameter string format). Calling: OnCustomAuthenticationFailed()", this.PosY);
			this.DOHGBNPMBKG().SetFloat("_BorderSize", this.Speed);
			this.IGKFMCPDNOI().SetVector(".r", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 611f, 1504f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600600E RID: 24590 RVA: 0x001D390D File Offset: 0x001D1B0D
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600600F RID: 24591 RVA: 0x001D390D File Offset: 0x001D1B0D
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006010 RID: 24592 RVA: 0x001D41BD File Offset: 0x001D23BD
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find(".");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006011 RID: 24593 RVA: 0x001D41E1 File Offset: 0x001D23E1
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Vision_Aura");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006012 RID: 24594 RVA: 0x001D4205 File Offset: 0x001D2405
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find(" AuthMode ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x17000114 RID: 276
	// (get) Token: 0x06006013 RID: 24595 RVA: 0x001D4229 File Offset: 0x001D2429
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

	// Token: 0x06006014 RID: 24596 RVA: 0x001D4260 File Offset: 0x001D2460
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("settings.volume.game");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006015 RID: 24597 RVA: 0x001D390D File Offset: 0x001D1B0D
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006016 RID: 24598 RVA: 0x001D390D File Offset: 0x001D1B0D
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040009A3 RID: 2467
	public Shader SCShader;

	// Token: 0x040009A4 RID: 2468
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040009A5 RID: 2469
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040009A6 RID: 2470
	private Material BJFKDHHMLJH;

	// Token: 0x040009A7 RID: 2471
	[Range(0f, 2f)]
	public float Twist = 1f;

	// Token: 0x040009A8 RID: 2472
	[Range(-4f, 4f)]
	public float Speed = 1f;

	// Token: 0x040009A9 RID: 2473
	public Color Color = new Color(0.16f, 0.57f, 0.19f);

	// Token: 0x040009AA RID: 2474
	[Range(-1f, 2f)]
	public float PosX = 0.5f;

	// Token: 0x040009AB RID: 2475
	[Range(-1f, 2f)]
	public float PosY = 0.5f;
}
