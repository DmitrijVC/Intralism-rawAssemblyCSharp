using System;
using UnityEngine;

// Token: 0x02000034 RID: 52
[AddComponentMenu("Camera Filter Pack/Weather/Fog")]
[ExecuteInEditMode]
public class CameraFilterPack_Atmosphere_Fog : MonoBehaviour
{
	// Token: 0x06000D55 RID: 3413 RVA: 0x0005EEA8 File Offset: 0x0005D0A8
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1278f)
			{
				this.HBJJOCHGOPH = 1462f;
			}
			this.KEMAALEODNH().SetFloat("COMPLETED", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("\t", this.Fade);
			this.IIJMIPBMMBF().SetFloat("_TimeX", this._Near);
			this.IIJMIPBMMBF().SetFloat("MenuScene", this._Far);
			this.NLFJGMBCICG().SetColor("skin.hit_wrong", this.FogColor);
			this.CECJJMKLEAK().SetVector("Object ID. Case-Sensitive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1412f, 1330f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.HNICHJCGJOC().SetTexture("_Offsets", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D56 RID: 3414 RVA: 0x0005EFCC File Offset: 0x0005D1CC
	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1055f)
			{
				this.HBJJOCHGOPH = 670f;
			}
			this.IONHGBPGCHK().SetFloat("<b>#", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("float,0", this.Fade);
			this.OOMFJGPAOKL().SetFloat("float,10", this._Near);
			this.FLOHGDECHHH().SetFloat(",", this._Far);
			this.JLHLHKPHDFO().SetColor("mapselector.lastSearch", this.FogColor);
			this.FLOHGDECHHH().SetVector("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1733f, 1385f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.NBMPPNFKFLB().SetTexture("CameraFilterPack_Blizzard1", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D57 RID: 3415 RVA: 0x0005F0F0 File Offset: 0x0005D2F0
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1005f)
			{
				this.HBJJOCHGOPH = 289f;
			}
			this.OHKGGPFGLFD().SetFloat("Rock", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("x", this.Fade);
			this.IGKFMCPDNOI().SetFloat("SetSatelliteSensitivity", this._Near);
			this.FLOHGDECHHH().SetFloat("/", this._Far);
			this.FLOHGDECHHH().SetColor("_SweaterSize", this.FogColor);
			this.ADGHJOHKEHG().SetVector("_Blue_C", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1111f, 1430f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.IONHGBPGCHK().SetTexture("challenges.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D58 RID: 3416 RVA: 0x0005F214 File Offset: 0x0005D414
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1013f)
			{
				this.HBJJOCHGOPH = 741f;
			}
			this.ADGHJOHKEHG().SetFloat("SetSunDirectionVector", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("RecordButton", this.Fade);
			this.MICHFGAOPKM().SetFloat("id", this._Near);
			this.FEAEGGCNIAA().SetFloat(" SphereWaveform.cs", this._Far);
			this.FLOHGDECHHH().SetColor("_ScreenResolution", this.FogColor);
			this.NBMPPNFKFLB().SetVector("_ProjectToPixelMatrix", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 159f, 1703f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.DKNJGHFLAIF().SetTexture("note.5", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D59 RID: 3417 RVA: 0x0005F335 File Offset: 0x0005D535
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D5A RID: 3418 RVA: 0x0005F36C File Offset: 0x0005D56C
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 785f)
			{
				this.HBJJOCHGOPH = 922f;
			}
			this.MICHFGAOPKM().SetFloat("_Far", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("[PlayerController] ", this.Fade);
			this.IGKFMCPDNOI().SetFloat(".lastCheckpoint.lives", this._Near);
			this.NLFJGMBCICG().SetFloat("NetworkPeer broke!", this._Far);
			this.OHKGGPFGLFD().SetColor("LoadingStatusText", this.FogColor);
			this.NLFJGMBCICG().SetVector("(\\[ */ *i *\\])", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1756f, 1034f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.HNICHJCGJOC().SetTexture("[PlayerBase] Loaded custom model: ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D5B RID: 3419 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D5C RID: 3420 RVA: 0x0005F4AC File Offset: 0x0005D6AC
	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 605f)
			{
				this.HBJJOCHGOPH = 1994f;
			}
			this.FLOHGDECHHH().SetFloat("System.Single", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("CameraFilterPack/TV_Vintage", this.Fade);
			this.JLHLHKPHDFO().SetFloat("</size>", this._Near);
			this.JLHLHKPHDFO().SetFloat("setAF", this._Far);
			this.MICHFGAOPKM().SetColor("clicked ", this.FogColor);
			this.DKNJGHFLAIF().SetVector("Object ID. Case-Sensitive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 579f, 95f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.KEMAALEODNH().SetTexture("Checkpoint", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D5D RID: 3421 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D5E RID: 3422 RVA: 0x0005F5CD File Offset: 0x0005D7CD
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D5F RID: 3423 RVA: 0x0005F604 File Offset: 0x0005D804
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-85);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D60 RID: 3424 RVA: 0x0005F63B File Offset: 0x0005D83B
	private void BGDPIHMAACO()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/TV_VHS_Rewind") as Texture2D);
		this.SCShader = Shader.Find("_MatrixColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000D61 RID: 3425 RVA: 0x0002523B File Offset: 0x0002343B
	private void MANDOGNJJBD()
	{
	}

	// Token: 0x06000D62 RID: 3426 RVA: 0x0005F674 File Offset: 0x0005D874
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D63 RID: 3427 RVA: 0x0005F6AB File Offset: 0x0005D8AB
	private void LIBGAKMKHJJ()
	{
		this.FPHEBLMINDA = (Resources.Load("_SSAO") as Texture2D);
		this.SCShader = Shader.Find("_Color2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000D64 RID: 3428 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D65 RID: 3429 RVA: 0x0005F6E4 File Offset: 0x0005D8E4
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 642f)
			{
				this.HBJJOCHGOPH = 302f;
			}
			this.KEMAALEODNH().SetFloat("blue", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("targetColor", this.Fade);
			this.DKNJGHFLAIF().SetFloat("_ScreenResolution", this._Near);
			this.EHDJJANLINB().SetFloat("ItemNameText", this._Far);
			this.IIBLJCKLGFG().SetColor("nd", this.FogColor);
			this.OHKGGPFGLFD().SetVector("ComboText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 756f, 737f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.FLOHGDECHHH().SetTexture(" [", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D66 RID: 3430 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D67 RID: 3431 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D68 RID: 3432 RVA: 0x0005F808 File Offset: 0x0005DA08
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1925f)
			{
				this.HBJJOCHGOPH = 1567f;
			}
			this.EHDJJANLINB().SetFloat("Mouse Y", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("request", this.Fade);
			this.IGKFMCPDNOI().SetFloat("AVG Misses:", this._Near);
			this.NBPKMLMCHFN.SetFloat("Object ID. Case-Sensitive", this._Far);
			this.OOMFJGPAOKL().SetColor("_Near", this.FogColor);
			this.KEMAALEODNH().SetVector("steamid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1830f, 43f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.IONHGBPGCHK().SetTexture("bpmgrid", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D69 RID: 3433 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06000D6A RID: 3434 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D6B RID: 3435 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x06000D6C RID: 3436 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D6D RID: 3437 RVA: 0x0005F92C File Offset: 0x0005DB2C
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1051f)
			{
				this.HBJJOCHGOPH = 458f;
			}
			this.IGKFMCPDNOI().SetFloat(" on effect ", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("InventoryGrid", this.Fade);
			this.NBMPPNFKFLB().SetFloat("[PlayerBase] SpawnObj error: ", this._Near);
			this.NFMGLIKNOOC().SetFloat("CameraFilterPack/Blend2Camera_ColorDodge", this._Far);
			this.FLOHGDECHHH().SetColor("<command>", this.FogColor);
			this.KEMAALEODNH().SetVector("Hip-hop", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 866f, 399f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.JLHLHKPHDFO().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D6E RID: 3438 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D6F RID: 3439 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06000D70 RID: 3440 RVA: 0x0005FA4D File Offset: 0x0005DC4D
	private void NNCCPEBIAKH()
	{
		this.FPHEBLMINDA = (Resources.Load("_Radius") as Texture2D);
		this.SCShader = Shader.Find("USE_DIAG_SEARCH");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000D71 RID: 3441 RVA: 0x0005FA86 File Offset: 0x0005DC86
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D72 RID: 3442 RVA: 0x0005FABD File Offset: 0x0005DCBD
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D73 RID: 3443 RVA: 0x0005FAF4 File Offset: 0x0005DCF4
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D74 RID: 3444 RVA: 0x0005FB2C File Offset: 0x0005DD2C
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 584f)
			{
				this.HBJJOCHGOPH = 1354f;
			}
			this.JLHLHKPHDFO().SetFloat("DPADVER", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("SetParticlesInput", this.Fade);
			this.FKEOGPDLBDD().SetFloat("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", this._Near);
			this.CECJJMKLEAK().SetFloat("CameraFilterPack/Blend2Camera_LinearLight", this._Far);
			this.IGKFMCPDNOI().SetColor(".", this.FogColor);
			this.MICHFGAOPKM().SetVector("AudioSampler", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 938f, 1421f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.IONHGBPGCHK().SetTexture("The used master server address is not available with the subscription currently used. Got to Photon Cloud Dashboard or change URL. Disconnecting.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D75 RID: 3445 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x06000D76 RID: 3446 RVA: 0x0005FC4D File Offset: 0x0005DE4D
	private void CCLNNLCOPBL()
	{
		this.FPHEBLMINDA = (Resources.Load("CountEventsGoal") as Texture2D);
		this.SCShader = Shader.Find("player.dragon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000D77 RID: 3447 RVA: 0x0005FC88 File Offset: 0x0005DE88
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
			this.NBPKMLMCHFN.SetFloat("_DepthLevel", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_Near", this._Near);
			this.NBPKMLMCHFN.SetFloat("_Far", this._Far);
			this.NBPKMLMCHFN.SetColor("_ColorRGB", this.FogColor);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.NBPKMLMCHFN.SetTexture("Texture2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D78 RID: 3448 RVA: 0x0005FDAC File Offset: 0x0005DFAC
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1280f)
			{
				this.HBJJOCHGOPH = 31f;
			}
			this.MICHFGAOPKM().SetFloat("SetSatelliteColor", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("_TimeX", this.Fade);
			this.FGENHBKMPDA().SetFloat("CameraFilterPack/Vision_Hell_Blood", this._Near);
			this.NBMPPNFKFLB().SetFloat("_Distortion", this._Far);
			this.HNICHJCGJOC().SetColor("settings.enableranking", this.FogColor);
			this.IONHGBPGCHK().SetVector("mapselector.tags.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1367f, 900f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.NLFJGMBCICG().SetTexture("[ItemsHandler] Found ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D79 RID: 3449 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void LAMEHAHJKMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D7A RID: 3450 RVA: 0x0005FECD File Offset: 0x0005E0CD
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D7B RID: 3451 RVA: 0x0005FF04 File Offset: 0x0005E104
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D7C RID: 3452 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D7D RID: 3453 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D7E RID: 3454 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void EDCMIPNCPLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D7F RID: 3455 RVA: 0x0005FF3C File Offset: 0x0005E13C
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 673f)
			{
				this.HBJJOCHGOPH = 943f;
			}
			this.FKEOGPDLBDD().SetFloat("Editor", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("BitsData", this.Fade);
			this.KEMAALEODNH().SetFloat(" now: ", this._Near);
			this.IIJMIPBMMBF().SetFloat("_ScreenResolution", this._Far);
			this.NBPKMLMCHFN.SetColor(",", this.FogColor);
			this.FGENHBKMPDA().SetVector("DPADVER", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 338f, 1359f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.IONHGBPGCHK().SetTexture("Received your UserID from server. Updating local value to: {0}", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D80 RID: 3456 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D81 RID: 3457 RVA: 0x0006005D File Offset: 0x0005E25D
	private Material OOMFJGPAOKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D82 RID: 3458 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D83 RID: 3459 RVA: 0x00060094 File Offset: 0x0005E294
	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 133f)
			{
				this.HBJJOCHGOPH = 803f;
			}
			this.IIJMIPBMMBF().SetFloat("_SmallTex", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat(": ", this.Fade);
			this.NBMPPNFKFLB().SetFloat("gameVolume", this._Near);
			this.JLHLHKPHDFO().SetFloat(": ", this._Far);
			this.NLFJGMBCICG().SetColor("GlassesColor2", this.FogColor);
			this.MICHFGAOPKM().SetVector("settings.selectormapsperpage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1654f, 1379f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.EHDJJANLINB().SetTexture(",", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D84 RID: 3460 RVA: 0x000601B5 File Offset: 0x0005E3B5
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)101;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D85 RID: 3461 RVA: 0x000601EC File Offset: 0x0005E3EC
	private void NPLCENPNJBM()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/AAA_WaterDrop") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000D86 RID: 3462 RVA: 0x00060225 File Offset: 0x0005E425
	private void KDMKDEKCELE()
	{
		this.FPHEBLMINDA = (Resources.Load("_Shadow") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000D87 RID: 3463 RVA: 0x0006025E File Offset: 0x0005E45E
	private void FMFNILJIEIA()
	{
		this.FPHEBLMINDA = (Resources.Load("shader.future") as Texture2D);
		this.SCShader = Shader.Find("y");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000D88 RID: 3464 RVA: 0x0002523B File Offset: 0x0002343B
	private void FGNFILLNPJK()
	{
	}

	// Token: 0x06000D89 RID: 3465 RVA: 0x00060297 File Offset: 0x0005E497
	private void DKOPKPBLDHH()
	{
		this.FPHEBLMINDA = (Resources.Load("player.currentrank") as Texture2D);
		this.SCShader = Shader.Find("GlassDistortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000D8A RID: 3466 RVA: 0x000602D0 File Offset: 0x0005E4D0
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1786f)
			{
				this.HBJJOCHGOPH = 1783f;
			}
			this.NBPKMLMCHFN.SetFloat("SubmitUserVote:", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("Instance\nWorking commands:\ninit or init <savepath>\npath\nsetint <key> <value>\ngetint <key> <value>\nsetfloat <key> <value>\ngetfloat <key> <value>\nsetstring <key> <value>\ngetstring <key> <value>\nsetbool <key> <value>\ngetbool <key> <value>\ndelete <key>\ndeleteall", this.Fade);
			this.EMDFHOKEGNG().SetFloat("maps.", this._Near);
			this.NBMPPNFKFLB().SetFloat("ticket", this._Far);
			this.HNICHJCGJOC().SetColor("ConfigVersionSlider", this.FogColor);
			this.FGENHBKMPDA().SetVector("CameraFilterPack/TV_VHS", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 175f, 249f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.NBPKMLMCHFN.SetTexture("Rap", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D8B RID: 3467 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D8C RID: 3468 RVA: 0x000603F4 File Offset: 0x0005E5F4
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 340f)
			{
				this.HBJJOCHGOPH = 410f;
			}
			this.FGENHBKMPDA().SetFloat("PUNCloudBestRegion", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("EnableRankingToggle", this.Fade);
			this.IONHGBPGCHK().SetFloat("offsets", this._Near);
			this.NFMGLIKNOOC().SetFloat("_TimeX", this._Far);
			this.IONHGBPGCHK().SetColor("SubmitUserVote:", this.FogColor);
			this.IIJMIPBMMBF().SetVector("CameraFilterPack/Alien_Vision", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1419f, 1154f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.JLHLHKPHDFO().SetTexture("_Value2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D8D RID: 3469 RVA: 0x00060518 File Offset: 0x0005E718
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 986f)
			{
				this.HBJJOCHGOPH = 631f;
			}
			this.FGENHBKMPDA().SetFloat("#FFDA44", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("_Value4", this.Fade);
			this.DKNJGHFLAIF().SetFloat("Mouse1", this._Near);
			this.HNICHJCGJOC().SetFloat("settings.arcsdestroydelay", this._Far);
			this.CECJJMKLEAK().SetColor("_TimeX", this.FogColor);
			this.FLOHGDECHHH().SetVector("SetPosition", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 683f, 1906f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.OHKGGPFGLFD().SetTexture("SSAARenderTargetCamera", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D8E RID: 3470 RVA: 0x00060639 File Offset: 0x0005E839
	private void MMOKKAPFGAK()
	{
		this.FPHEBLMINDA = (Resources.Load("Editor") as Texture2D);
		this.SCShader = Shader.Find("-1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000D8F RID: 3471 RVA: 0x00060672 File Offset: 0x0005E872
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D90 RID: 3472 RVA: 0x000606AC File Offset: 0x0005E8AC
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 640f)
			{
				this.HBJJOCHGOPH = 1287f;
			}
			this.NBMPPNFKFLB().SetFloat("note.1", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("Fade", this.Fade);
			this.IIJMIPBMMBF().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this._Near);
			this.KEMAALEODNH().SetFloat("_ScreenResolution", this._Far);
			this.FKEOGPDLBDD().SetColor("EditMenu", this.FogColor);
			this.ADGHJOHKEHG().SetVector("CameraFilterPack/Film_Grain", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 670f, 905f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.EMDFHOKEGNG().SetTexture("_Value2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OOMFJGPAOKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D91 RID: 3473 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x06000D92 RID: 3474 RVA: 0x000607D0 File Offset: 0x0005E9D0
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1365f)
			{
				this.HBJJOCHGOPH = 1174f;
			}
			this.IIJMIPBMMBF().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("Other", this.Fade);
			this.DKNJGHFLAIF().SetFloat("_Luminance", this._Near);
			this.OOMFJGPAOKL().SetFloat("Type of observed is unknown when receiving.", this._Far);
			this.DKNJGHFLAIF().SetColor("SfxVolumeSlider", this.FogColor);
			this.IIJMIPBMMBF().SetVector("_Gamma", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1939f, 1428f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.NBPKMLMCHFN.SetTexture("/", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D93 RID: 3475 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D94 RID: 3476 RVA: 0x000608F4 File Offset: 0x0005EAF4
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 491f)
			{
				this.HBJJOCHGOPH = 1884f;
			}
			this.OOMFJGPAOKL().SetFloat("menu.relaxinfo", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("AreaTex", this.Fade);
			this.KEMAALEODNH().SetFloat("addNewButton", this._Near);
			this.OHKGGPFGLFD().SetFloat("_Value", this._Far);
			this.IIBLJCKLGFG().SetColor("JoinRandomRoom failed. In offline mode you still have to leave a room to enter another.", this.FogColor);
			this.NBPKMLMCHFN.SetVector("IconFileSelector", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1588f, 1533f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.NLFJGMBCICG().SetTexture("_EmissionGain", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OHKGGPFGLFD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000D95 RID: 3477 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D96 RID: 3478 RVA: 0x00060A15 File Offset: 0x0005EC15
	private void KOJKBFDNGDK()
	{
		this.FPHEBLMINDA = (Resources.Load("PhotonView with ID ") as Texture2D);
		this.SCShader = Shader.Find("Vertical");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000D97 RID: 3479 RVA: 0x00060A4E File Offset: 0x0005EC4E
	private void DLBODOFAJGM()
	{
		this.FPHEBLMINDA = (Resources.Load("SetSpeed") as Texture2D);
		this.SCShader = Shader.Find("SetParticlesEmission");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000D98 RID: 3480 RVA: 0x00060A87 File Offset: 0x0005EC87
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000D99 RID: 3481 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06000D9A RID: 3482 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x06000D9B RID: 3483 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000D9C RID: 3484 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x06000D9D RID: 3485 RVA: 0x00060ABE File Offset: 0x0005ECBE
	private void DFFKKLAPHCC()
	{
		this.FPHEBLMINDA = (Resources.Load(".status") as Texture2D);
		this.SCShader = Shader.Find("_MaxBlurRadius");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000D9E RID: 3486 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x06000D9F RID: 3487 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DA0 RID: 3488 RVA: 0x00060AF7 File Offset: 0x0005ECF7
	private void LFAFJKJAEEL()
	{
		this.FPHEBLMINDA = (Resources.Load("/") as Texture2D);
		this.SCShader = Shader.Find("_BlurVector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000DA1 RID: 3489 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06000DA2 RID: 3490 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DA3 RID: 3491 RVA: 0x00060B30 File Offset: 0x0005ED30
	private void ILCFPCIPENO()
	{
		this.FPHEBLMINDA = (Resources.Load("speed") as Texture2D);
		this.SCShader = Shader.Find("ConnectToMaster() failed. Can only connect while in state 'Disconnected'. Current state: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000DA4 RID: 3492 RVA: 0x00060B69 File Offset: 0x0005ED69
	private void LBAJLLFMMMP()
	{
		this.FPHEBLMINDA = (Resources.Load("Winter2020") as Texture2D);
		this.SCShader = Shader.Find("_PosX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DA5 RID: 3493 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBPCODPOJAH()
	{
	}

	// Token: 0x06000DA6 RID: 3494 RVA: 0x00060BA2 File Offset: 0x0005EDA2
	private Material OHKGGPFGLFD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DA7 RID: 3495 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DA8 RID: 3496 RVA: 0x00060BDC File Offset: 0x0005EDDC
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1932f)
			{
				this.HBJJOCHGOPH = 936f;
			}
			this.IIBLJCKLGFG().SetFloat("_EmissionColor", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("/../", this.Fade);
			this.OHKGGPFGLFD().SetFloat("RecieveChatActionMessage", this._Near);
			this.NLFJGMBCICG().SetFloat("_Intensity", this._Far);
			this.DKNJGHFLAIF().SetColor("_TimeX", this.FogColor);
			this.EMDFHOKEGNG().SetVector("Gameplay/Base", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 814f, 1613f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.NFMGLIKNOOC().SetTexture("ResourceFileSelector", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DA9 RID: 3497 RVA: 0x00060CFD File Offset: 0x0005EEFD
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DAA RID: 3498 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06000DAB RID: 3499 RVA: 0x00060D34 File Offset: 0x0005EF34
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DAC RID: 3500 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DAD RID: 3501 RVA: 0x00060D6B File Offset: 0x0005EF6B
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)115;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DAE RID: 3502 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DAF RID: 3503 RVA: 0x00060DA2 File Offset: 0x0005EFA2
	private void MGMAOBPPOBJ()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find("SlidingArea");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000DB0 RID: 3504 RVA: 0x00060DDB File Offset: 0x0005EFDB
	private void AKHCOBHHGJP()
	{
		this.FPHEBLMINDA = (Resources.Load("#") as Texture2D);
		this.SCShader = Shader.Find("SpectateButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DB1 RID: 3505 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DB2 RID: 3506 RVA: 0x00060E14 File Offset: 0x0005F014
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DB3 RID: 3507 RVA: 0x00060E4C File Offset: 0x0005F04C
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1741f)
			{
				this.HBJJOCHGOPH = 1488f;
			}
			this.NLFJGMBCICG().SetFloat("settings.fps", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.", this.Fade);
			this.NBMPPNFKFLB().SetFloat("_TimeX", this._Near);
			this.FGENHBKMPDA().SetFloat("Gameplay/Base", this._Far);
			this.NLFJGMBCICG().SetColor("_Value4", this.FogColor);
			this.EMDFHOKEGNG().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1071f, 1755f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			this.FEAEGGCNIAA().SetTexture(" - ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DB4 RID: 3508 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void GNPDGBNDCPL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DB5 RID: 3509 RVA: 0x00060F70 File Offset: 0x0005F170
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1105f)
			{
				this.HBJJOCHGOPH = 1510f;
			}
			this.IONHGBPGCHK().SetFloat("sprite", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("Connection error: ", this.Fade);
			this.IGKFMCPDNOI().SetFloat("CameraFilterPack/FX_Scan", this._Near);
			this.MICHFGAOPKM().SetFloat("_Color2", this._Far);
			this.IIJMIPBMMBF().SetColor("plainText", this.FogColor);
			this.FKEOGPDLBDD().SetVector("#{0:00} '{1}'{2} {3}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 819f, 1763f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.FKEOGPDLBDD().SetTexture("[LocalizationService] All keys for ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DB6 RID: 3510 RVA: 0x00061091 File Offset: 0x0005F291
	private void CCFEDENFNEF()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value5") as Texture2D);
		this.SCShader = Shader.Find("_BlurRadius4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DB7 RID: 3511 RVA: 0x000610CC File Offset: 0x0005F2CC
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 687f)
			{
				this.HBJJOCHGOPH = 934f;
			}
			this.NFMGLIKNOOC().SetFloat("2;13;14;15;16", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("0.00", this.Fade);
			this.NFMGLIKNOOC().SetFloat("CameraFilterPack/BlurTiltShift_Hole", this._Near);
			this.ADGHJOHKEHG().SetFloat("steamid", this._Far);
			this.MICHFGAOPKM().SetColor("CameraFilterPack/Glasses_On", this.FogColor);
			this.IIJMIPBMMBF().SetVector("RECORD [R]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1542f, 417f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.OHKGGPFGLFD().SetTexture(": ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x06000DB9 RID: 3513 RVA: 0x00061243 File Offset: 0x0005F443
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

	// Token: 0x06000DBA RID: 3514 RVA: 0x0006127A File Offset: 0x0005F47A
	private Material CECJJMKLEAK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DBB RID: 3515 RVA: 0x000612B4 File Offset: 0x0005F4B4
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1329f)
			{
				this.HBJJOCHGOPH = 121f;
			}
			this.OOMFJGPAOKL().SetFloat("_History2ChromaTex", this.HBJJOCHGOPH);
			this.CECJJMKLEAK().SetFloat("CameraFilterPack/TV_Vcr", this.Fade);
			this.FGENHBKMPDA().SetFloat("_Value5", this._Near);
			this.IGKFMCPDNOI().SetFloat("_RGB", this._Far);
			this.OHKGGPFGLFD().SetColor("_Value", this.FogColor);
			this.JLHLHKPHDFO().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 526f, 123f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			this.NLFJGMBCICG().SetTexture("_FixDistance", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DBC RID: 3516 RVA: 0x000613D5 File Offset: 0x0005F5D5
	private void MJEFMIPLFAB()
	{
		this.FPHEBLMINDA = (Resources.Load("Hidden/ScreenSpaceReflection") as Texture2D);
		this.SCShader = Shader.Find("[Up]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DBD RID: 3517 RVA: 0x0005F5CD File Offset: 0x0005D7CD
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DBE RID: 3518 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06000DBF RID: 3519 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06000DC0 RID: 3520 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DC1 RID: 3521 RVA: 0x0002523B File Offset: 0x0002343B
	private void KDJEJBBDILE()
	{
	}

	// Token: 0x06000DC2 RID: 3522 RVA: 0x0006140E File Offset: 0x0005F60E
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_Atmosphere_Rain_FX") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Atmosphere_Fog");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DC3 RID: 3523 RVA: 0x00061447 File Offset: 0x0005F647
	private void FEKECCBFGMI()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_TV_BrokenGlass1") as Texture2D);
		this.SCShader = Shader.Find(":");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000DC4 RID: 3524 RVA: 0x00061480 File Offset: 0x0005F680
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DC5 RID: 3525 RVA: 0x0005F48D File Offset: 0x0005D68D
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DC6 RID: 3526 RVA: 0x000614B7 File Offset: 0x0005F6B7
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x040001F6 RID: 502
	public Shader SCShader;

	// Token: 0x040001F7 RID: 503
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040001F8 RID: 504
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040001F9 RID: 505
	private Material BJFKDHHMLJH;

	// Token: 0x040001FA RID: 506
	[Range(0f, 1f)]
	public float _Near;

	// Token: 0x040001FB RID: 507
	[Range(0f, 1f)]
	public float _Far = 0.05f;

	// Token: 0x040001FC RID: 508
	public Color FogColor = new Color(0.4f, 0.4f, 0.4f, 1f);

	// Token: 0x040001FD RID: 509
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x040001FE RID: 510
	public static Color ChangeColorRGB;

	// Token: 0x040001FF RID: 511
	private Texture2D FPHEBLMINDA;
}
