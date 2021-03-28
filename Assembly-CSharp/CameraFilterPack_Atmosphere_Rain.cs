using System;
using UnityEngine;

// Token: 0x02000035 RID: 53
[AddComponentMenu("Camera Filter Pack/Weather/Rain")]
[ExecuteInEditMode]
public class CameraFilterPack_Atmosphere_Rain : MonoBehaviour
{
	// Token: 0x06000DC7 RID: 3527 RVA: 0x000614EE File Offset: 0x0005F6EE
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DC8 RID: 3528 RVA: 0x00061525 File Offset: 0x0005F725
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DC9 RID: 3529 RVA: 0x00061542 File Offset: 0x0005F742
	private void CIPKEPDELJB()
	{
		this.FPHEBLMINDA = (Resources.Load("restrictions\n\n#until: ") as Texture2D);
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000DCA RID: 3530 RVA: 0x0006157B File Offset: 0x0005F77B
	private void JMEOGJHCONJ()
	{
		this.FPHEBLMINDA = (Resources.Load("Tab1Content") as Texture2D);
		this.SCShader = Shader.Find("z");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DCB RID: 3531 RVA: 0x000615B4 File Offset: 0x0005F7B4
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1137f)
			{
				this.HBJJOCHGOPH = 602f;
			}
			this.GJHLADDCMFF().SetFloat("open", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("ticket", this.Fade);
			this.JIBOKBCPDLC().SetFloat("Editor/", this.Intensity);
			this.KLKILLCHJHO().SetFloat("SaveButton", this.DirectionX);
			this.EOCCJGIGEGJ().SetFloat("CameraFilterPack_TV_HorrorFX", this.Speed);
			this.FKEOGPDLBDD().SetFloat("maps.", this.Size);
			this.FKEOGPDLBDD().SetFloat(" ", this.Distortion);
			this.IKBJACCLPCL().SetFloat("intensity", this.StormFlashOnOff);
			this.NBPKMLMCHFN.SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 583f, 516f));
			this.KHCLIAMBBNC().SetTexture("Bad parameters for getstring! Use <key> <value>", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DCC RID: 3532 RVA: 0x0006170C File Offset: 0x0005F90C
	private void LNOOFNGHNEL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1436f)
			{
				this.HBJJOCHGOPH = 1714f;
			}
			this.IIJMIPBMMBF().SetFloat("settings.crosshairopacity", this.HBJJOCHGOPH);
			this.BLMPMOIDGMG().SetFloat("Set Sun Sensitivity", this.Fade);
			this.OCHJIMJNEMO().SetFloat("Set arcs speed. Base value - 15", this.Intensity);
			this.IKBJACCLPCL().SetFloat("STICKRHOR", this.DirectionX);
			this.KOHGPKOFEJO().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", this.Speed);
			this.PLBEJJIHFPB().SetFloat("PhotonNetwork error: Could not Instantiate the prefab [", this.Size);
			this.LPDOGGFOBDH().SetFloat("[PlayerBase] Reset", this.Distortion);
			this.IGKFMCPDNOI().SetFloat("-", this.StormFlashOnOff);
			this.NBPKMLMCHFN.SetVector("Please wait..", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 353f, 520f));
			this.NFKFAAHHLLM().SetTexture("Screenshots only supported in PlayMode", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DCD RID: 3533 RVA: 0x00061863 File Offset: 0x0005FA63
	private void FHPFJBFCOOF()
	{
		this.FPHEBLMINDA = (Resources.Load("Tab2Content") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/FX_8bits_gb");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000DCE RID: 3534 RVA: 0x00061525 File Offset: 0x0005F725
	private void JNALDALAJLG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DCF RID: 3535 RVA: 0x0006189C File Offset: 0x0005FA9C
	private void KMCPMOGKDEH()
	{
		this.FPHEBLMINDA = (Resources.Load("id") as Texture2D);
		this.SCShader = Shader.Find("_MinVelocity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DD0 RID: 3536 RVA: 0x00061525 File Offset: 0x0005F725
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DD1 RID: 3537 RVA: 0x000618D5 File Offset: 0x0005FAD5
	private Material MJJIEHANFJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)108;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DD2 RID: 3538 RVA: 0x0002523B File Offset: 0x0002343B
	private void ICGNMOFMLFA()
	{
	}

	// Token: 0x06000DD3 RID: 3539 RVA: 0x00061525 File Offset: 0x0005F725
	private void IENKPJEBMFM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DD4 RID: 3540 RVA: 0x0006190C File Offset: 0x0005FB0C
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1291f)
			{
				this.HBJJOCHGOPH = 1302f;
			}
			this.EOCCJGIGEGJ().SetFloat("LoadingStatusText", this.HBJJOCHGOPH);
			this.ECCPAOBFDKP().SetFloat("_BlurParams", this.Fade);
			this.KLKILLCHJHO().SetFloat("_Noise", this.Intensity);
			this.EBJKJPAIAAM().SetFloat("CameraFilterPack/Blend2Camera_Luminosity", this.DirectionX);
			this.IIJMIPBMMBF().SetFloat("SpawnObj", this.Speed);
			this.KGOLDDBHIFN().SetFloat("Save", this.Size);
			this.NBPKMLMCHFN.SetFloat("GlassesColor2", this.Distortion);
			this.LPDOGGFOBDH().SetFloat("_ScreenResolution", this.StormFlashOnOff);
			this.NJDIODJNGGA().SetVector("{0:0} second{1}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1050f, 1229f));
			this.PDEAHJPOMEF().SetTexture("/Segment-[Right]", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DD5 RID: 3541 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06000DD6 RID: 3542 RVA: 0x00061A63 File Offset: 0x0005FC63
	private void AEDDNDHCLNN()
	{
		this.FPHEBLMINDA = (Resources.Load("yyyy") as Texture2D);
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DD7 RID: 3543 RVA: 0x00061A9C File Offset: 0x0005FC9C
	private void OPIBJIMIOKE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 938f)
			{
				this.HBJJOCHGOPH = 630f;
			}
			this.NJDIODJNGGA().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("Hidden/DepthOfField/DepthOfField", this.Fade);
			this.IIJMIPBMMBF().SetFloat("CameraFilterPack/FX_ZebraColor", this.Intensity);
			this.JIBOKBCPDLC().SetFloat("CameraFilterPack/TV_ARCADE_2", this.DirectionX);
			this.MJJIEHANFJA().SetFloat("SetParticlesParticleSize", this.Speed);
			this.GJHLADDCMFF().SetFloat("_Value2", this.Size);
			this.NFKFAAHHLLM().SetFloat("[PlayerBase] SetSpeed error: ", this.Distortion);
			this.GJHLADDCMFF().SetFloat("_Value2", this.StormFlashOnOff);
			this.FKEOGPDLBDD().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 682f, 318f));
			this.KLKILLCHJHO().SetTexture("original.tutorial", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DD8 RID: 3544 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06000DD9 RID: 3545 RVA: 0x0002523B File Offset: 0x0002343B
	private void PNLKFANNOKO()
	{
	}

	// Token: 0x06000DDA RID: 3546 RVA: 0x00061BF4 File Offset: 0x0005FDF4
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1026f)
			{
				this.HBJJOCHGOPH = 648f;
			}
			this.IIJMIPBMMBF().SetFloat("Error; Only the MasterClient can call RemoveRPCs for other players.", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetFloat("Maps Editor v.", this.Fade);
			this.GJHLADDCMFF().SetFloat("_Distortion", this.Intensity);
			this.NJDIODJNGGA().SetFloat("IDInputField", this.DirectionX);
			this.NBPKMLMCHFN.SetFloat("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ", this.Speed);
			this.KEMAALEODNH().SetFloat("_ScreenResolution", this.Size);
			this.IKBJACCLPCL().SetFloat("menu.playedsolo", this.Distortion);
			this.GJHLADDCMFF().SetFloat("CameraFilterPack/Blend2Camera_ColorBurn", this.StormFlashOnOff);
			this.LPDOGGFOBDH().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 364f, 587f));
			this.FGENHBKMPDA().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DDB RID: 3547 RVA: 0x00061525 File Offset: 0x0005F725
	private void IEFMONDKKJN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DDC RID: 3548 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06000DDD RID: 3549 RVA: 0x00061D4C File Offset: 0x0005FF4C
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 10f)
			{
				this.HBJJOCHGOPH = 1738f;
			}
			this.FKEOGPDLBDD().SetFloat(" - {0}", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat(".", this.Fade);
			this.IIJMIPBMMBF().SetFloat("PUNCloudBestRegion", this.Intensity);
			this.BLMPMOIDGMG().SetFloat("[PlayerBase] Game mode: ", this.DirectionX);
			this.NFKFAAHHLLM().SetFloat("_TimeX", this.Speed);
			this.KOHGPKOFEJO().SetFloat("ItemNameText", this.Size);
			this.GJHLADDCMFF().SetFloat("[MapEditor] Loading map: ", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("w", this.StormFlashOnOff);
			this.MJJIEHANFJA().SetVector("_Amount", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 985f, 554f));
			this.IKBJACCLPCL().SetTexture("CameraFilterPack/Blend2Camera_Color", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DDE RID: 3550 RVA: 0x00061525 File Offset: 0x0005F725
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DDF RID: 3551 RVA: 0x00061EA4 File Offset: 0x000600A4
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.DirectionX);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Value6", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("_Value7", this.StormFlashOnOff);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			this.NBPKMLMCHFN.SetTexture("Texture2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DE0 RID: 3552 RVA: 0x00061FFB File Offset: 0x000601FB
	private Material IKBJACCLPCL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DE1 RID: 3553 RVA: 0x00061525 File Offset: 0x0005F725
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DE2 RID: 3554 RVA: 0x00062032 File Offset: 0x00060232
	private void MKOMIDCPCDC()
	{
		this.FPHEBLMINDA = (Resources.Load("Set sun min/max size") as Texture2D);
		this.SCShader = Shader.Find("curScn");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000DE3 RID: 3555 RVA: 0x0006206B File Offset: 0x0006026B
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DE4 RID: 3556 RVA: 0x000620A2 File Offset: 0x000602A2
	private void LGHCJCFHEMF()
	{
		this.FPHEBLMINDA = (Resources.Load("[ResourcesManager] Load audio error: ") as Texture2D);
		this.SCShader = Shader.Find("0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000DE5 RID: 3557 RVA: 0x000620DB File Offset: 0x000602DB
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_Atmosphere_Rain_FX") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Atmosphere_Rain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DE6 RID: 3558 RVA: 0x00062114 File Offset: 0x00060314
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DE7 RID: 3559 RVA: 0x00061525 File Offset: 0x0005F725
	private void NNBCLMJGFEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DE8 RID: 3560 RVA: 0x00061525 File Offset: 0x0005F725
	private void DKPBBJINKMG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DE9 RID: 3561 RVA: 0x0006214B File Offset: 0x0006034B
	private void PDHKMDBNGGN()
	{
		this.FPHEBLMINDA = (Resources.Load(" workshop map(s)") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000DEA RID: 3562 RVA: 0x00062184 File Offset: 0x00060384
	private Material HKIMAANBGMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DEB RID: 3563 RVA: 0x000621BB File Offset: 0x000603BB
	private void DAHFFNNIGML()
	{
		this.FPHEBLMINDA = (Resources.Load("<color=#{0}>{1}</color>") as Texture2D);
		this.SCShader = Shader.Find("Bass");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000DEC RID: 3564 RVA: 0x000621F4 File Offset: 0x000603F4
	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 122f)
			{
				this.HBJJOCHGOPH = 659f;
			}
			this.MJJIEHANFJA().SetFloat("CameraFilterPack/3D_Myst", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("BloodAlternative1", this.Fade);
			this.FGENHBKMPDA().SetFloat("_Red_C", this.Intensity);
			this.IIJMIPBMMBF().SetFloat("LoadingStatusText", this.DirectionX);
			this.KGOLDDBHIFN().SetFloat("Texture2", this.Speed);
			this.FGENHBKMPDA().SetFloat("Rap", this.Size);
			this.JIBOKBCPDLC().SetFloat("_SmoothEnd", this.Distortion);
			this.KHCLIAMBBNC().SetFloat("shader.future", this.StormFlashOnOff);
			this.KLKILLCHJHO().SetVector("Unable to get a reward! Try again?", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 263f, 1547f));
			this.PDEAHJPOMEF().SetTexture("SetSunMinSize", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IKBJACCLPCL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DED RID: 3565 RVA: 0x0006234B File Offset: 0x0006054B
	private Material ECCPAOBFDKP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)96;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DEE RID: 3566 RVA: 0x00061525 File Offset: 0x0005F725
	private void HLHJBJGEEEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DEF RID: 3567 RVA: 0x00062382 File Offset: 0x00060582
	private void ECBILENEOOL()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value4") as Texture2D);
		this.SCShader = Shader.Find("\r");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DF0 RID: 3568 RVA: 0x000623BC File Offset: 0x000605BC
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1187f)
			{
				this.HBJJOCHGOPH = 1194f;
			}
			this.PLBEJJIHFPB().SetFloat("y", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("VisionBlur", this.Fade);
			this.HKIMAANBGMJ().SetFloat("Set Satellite Input", this.Intensity);
			this.NJDIODJNGGA().SetFloat("_Threshold", this.DirectionX);
			this.KLKILLCHJHO().SetFloat("float,0", this.Speed);
			this.FGENHBKMPDA().SetFloat("Start", this.Size);
			this.FGENHBKMPDA().SetFloat("Items/", this.Distortion);
			this.KGOLDDBHIFN().SetFloat("deletemap", this.StormFlashOnOff);
			this.JIBOKBCPDLC().SetVector("SpectatingUserInfo", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 321f, 637f));
			this.FGENHBKMPDA().SetTexture(" scene view IDs from last level.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DF1 RID: 3569 RVA: 0x00061525 File Offset: 0x0005F725
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DF2 RID: 3570 RVA: 0x00062514 File Offset: 0x00060714
	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 447f)
			{
				this.HBJJOCHGOPH = 1614f;
			}
			this.DIOAAHJDMLK().SetFloat("Jazz", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("Not sending leave operation. State is not 'Joined': ", this.Fade);
			this.EOCCJGIGEGJ().SetFloat("_Value6", this.Intensity);
			this.PLBEJJIHFPB().SetFloat("Connect() failed. Can't connect while disconnecting (still). Current state: ", this.DirectionX);
			this.EBJKJPAIAAM().SetFloat("ticket", this.Speed);
			this.KEMAALEODNH().SetFloat("[LevelEditorScene] Creating new item...", this.Size);
			this.HKIMAANBGMJ().SetFloat("[Down]", this.Distortion);
			this.KOHGPKOFEJO().SetFloat("shader.invert", this.StormFlashOnOff);
			this.OCHJIMJNEMO().SetVector("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 814f, 1907f));
			this.GJHLADDCMFF().SetTexture("Beat Detected", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IKBJACCLPCL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DF3 RID: 3571 RVA: 0x0006266B File Offset: 0x0006086B
	private void KCCIEMBMOBA()
	{
		this.FPHEBLMINDA = (Resources.Load("No peer to communicate with. ") as Texture2D);
		this.SCShader = Shader.Find("[Up-Right-Down]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000DF4 RID: 3572 RVA: 0x000626A4 File Offset: 0x000608A4
	private void FDNONDCGGCG()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value2") as Texture2D);
		this.SCShader = Shader.Find("1,30,true,0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DF5 RID: 3573 RVA: 0x00061525 File Offset: 0x0005F725
	private void FAMLCFNDGNI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DF6 RID: 3574 RVA: 0x000626DD File Offset: 0x000608DD
	private void EIMNPCMHJLJ()
	{
		this.FPHEBLMINDA = (Resources.Load("MenuScene") as Texture2D);
		this.SCShader = Shader.Find("threshold");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DF7 RID: 3575 RVA: 0x00062716 File Offset: 0x00060916
	private Material DIOAAHJDMLK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000DF8 RID: 3576 RVA: 0x0006274D File Offset: 0x0006094D
	private void CHOPDIGHJNH()
	{
		this.FPHEBLMINDA = (Resources.Load(" - ") as Texture2D);
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000DF9 RID: 3577 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDBBPKIFNJ()
	{
	}

	// Token: 0x06000DFA RID: 3578 RVA: 0x00062788 File Offset: 0x00060988
	private void AGDIBDLHMKF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 475f)
			{
				this.HBJJOCHGOPH = 1901f;
			}
			this.KOHGPKOFEJO().SetFloat(":", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("_TimeX", this.Fade);
			this.OCHJIMJNEMO().SetFloat("</color>", this.Intensity);
			this.PLBEJJIHFPB().SetFloat("_Value4", this.DirectionX);
			this.KHCLIAMBBNC().SetFloat("_Offsets", this.Speed);
			this.NJDIODJNGGA().SetFloat("EditMenu", this.Size);
			this.NFKFAAHHLLM().SetFloat("_Value3", this.Distortion);
			this.FGENHBKMPDA().SetFloat("_TimeX", this.StormFlashOnOff);
			this.KEMAALEODNH().SetVector("1", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1143f, 1617f));
			this.PDEAHJPOMEF().SetTexture("OPEN", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DFB RID: 3579 RVA: 0x000628DF File Offset: 0x00060ADF
	private void DOKAKEMDALN()
	{
		this.FPHEBLMINDA = (Resources.Load("OK") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack_eyes_vision_1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000DFC RID: 3580 RVA: 0x00062918 File Offset: 0x00060B18
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1841f)
			{
				this.HBJJOCHGOPH = 1556f;
			}
			this.PLBEJJIHFPB().SetFloat("menu.playedpage", this.HBJJOCHGOPH);
			this.IKBJACCLPCL().SetFloat("_Value3", this.Fade);
			this.EOCCJGIGEGJ().SetFloat("0 - default, 1 - left, 2 - right", this.Intensity);
			this.OCHJIMJNEMO().SetFloat(".played", this.DirectionX);
			this.OCHJIMJNEMO().SetFloat("ResourceIDInputField", this.Speed);
			this.MJJIEHANFJA().SetFloat("_MainTex2", this.Size);
			this.FKEOGPDLBDD().SetFloat(".lastCheckpoint.penaltyScore", this.Distortion);
			this.LPDOGGFOBDH().SetFloat("GenerationMenu", this.StormFlashOnOff);
			this.IGKFMCPDNOI().SetVector("inventory.selected.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 785f, 187f));
			this.DIOAAHJDMLK().SetTexture("Operation ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000DFD RID: 3581 RVA: 0x00062A6F File Offset: 0x00060C6F
	private void CEAGPJBGBMH()
	{
		this.FPHEBLMINDA = (Resources.Load("_Bullet_3") as Texture2D);
		this.SCShader = Shader.Find("Editor/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000DFE RID: 3582 RVA: 0x00061525 File Offset: 0x0005F725
	private void FJABOCDLCAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000DFF RID: 3583 RVA: 0x0002523B File Offset: 0x0002343B
	private void IAJKLKJJKEJ()
	{
	}

	// Token: 0x06000E00 RID: 3584 RVA: 0x00062AA8 File Offset: 0x00060CA8
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1631f)
			{
				this.HBJJOCHGOPH = 1123f;
			}
			this.DIOAAHJDMLK().SetFloat(". MasterClient: ", this.HBJJOCHGOPH);
			this.KLKILLCHJHO().SetFloat("_MainTex2", this.Fade);
			this.KHCLIAMBBNC().SetFloat(" not found", this.Intensity);
			this.PDEAHJPOMEF().SetFloat("_ScreenResolution", this.DirectionX);
			this.ECCPAOBFDKP().SetFloat("player.currentrank", this.Speed);
			this.MJJIEHANFJA().SetFloat("CameraFilterPack/TV_Distorted", this.Size);
			this.MJJIEHANFJA().SetFloat("May", this.Distortion);
			this.NJDIODJNGGA().SetFloat("_TimeX", this.StormFlashOnOff);
			this.JIBOKBCPDLC().SetVector("[LevelEditorScene] Error: Timeout :S", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 977f, 333f));
			this.HKIMAANBGMJ().SetTexture("float,1.5", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E01 RID: 3585 RVA: 0x00062C00 File Offset: 0x00060E00
	private void HHKBBEFJEBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1913f)
			{
				this.HBJJOCHGOPH = 74f;
			}
			this.KLKILLCHJHO().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.MJJIEHANFJA().SetFloat("GlassesColor2", this.Fade);
			this.FKEOGPDLBDD().SetFloat("Preparing content", this.Intensity);
			this.KLKILLCHJHO().SetFloat("_TimeX", this.DirectionX);
			this.NFKFAAHHLLM().SetFloat("Set sun min/max size", this.Speed);
			this.OCHJIMJNEMO().SetFloat("_Value2", this.Size);
			this.FGENHBKMPDA().SetFloat("_VelocityTex", this.Distortion);
			this.EBJKJPAIAAM().SetFloat("EditMenu", this.StormFlashOnOff);
			this.EOCCJGIGEGJ().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 838f, 903f));
			this.KOHGPKOFEJO().SetTexture("#close", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EBJKJPAIAAM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E02 RID: 3586 RVA: 0x00062D58 File Offset: 0x00060F58
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1045f)
			{
				this.HBJJOCHGOPH = 1209f;
			}
			this.PDEAHJPOMEF().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("_Distance", this.Fade);
			this.KGOLDDBHIFN().SetFloat("#onrankchangedowntext", this.Intensity);
			this.EOCCJGIGEGJ().SetFloat("MascotChallenge2019", this.DirectionX);
			this.NFKFAAHHLLM().SetFloat("ItemNameBGImage", this.Speed);
			this.IIJMIPBMMBF().SetFloat("_MainTex2", this.Size);
			this.HKIMAANBGMJ().SetFloat("_SphereSize", this.Distortion);
			this.EOCCJGIGEGJ().SetFloat("MultiplayerButton", this.StormFlashOnOff);
			this.NFKFAAHHLLM().SetVector("_VignetteSettings", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 362f, 54f));
			this.JIBOKBCPDLC().SetTexture("GameMessagesDurationSlider", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KLKILLCHJHO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E03 RID: 3587 RVA: 0x00062EB0 File Offset: 0x000610B0
	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 944f)
			{
				this.HBJJOCHGOPH = 388f;
			}
			this.JIBOKBCPDLC().SetFloat("\\n", this.HBJJOCHGOPH);
			this.MJJIEHANFJA().SetFloat(":", this.Fade);
			this.PDEAHJPOMEF().SetFloat("_TimeX", this.Intensity);
			this.OCHJIMJNEMO().SetFloat("\n", this.DirectionX);
			this.IIJMIPBMMBF().SetFloat("y", this.Speed);
			this.OCHJIMJNEMO().SetFloat("Music End", this.Size);
			this.IGKFMCPDNOI().SetFloat("_Shadow", this.Distortion);
			this.BLMPMOIDGMG().SetFloat("EndlessLoopsScoreText", this.StormFlashOnOff);
			this.EOCCJGIGEGJ().SetVector("[#clicktoacceptchallenge]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 876f, 688f));
			this.LPDOGGFOBDH().SetTexture("[MapsData] Bad map: ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E04 RID: 3588 RVA: 0x00061525 File Offset: 0x0005F725
	private void FGBDGGCBFLP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E05 RID: 3589 RVA: 0x00063008 File Offset: 0x00061208
	private void IHAMJLJFFLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 782f)
			{
				this.HBJJOCHGOPH = 978f;
			}
			this.BLMPMOIDGMG().SetFloat(".icon", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("Received RPC \"", this.Fade);
			this.KLKILLCHJHO().SetFloat("Data/Editor/leveltemplate", this.Intensity);
			this.LPDOGGFOBDH().SetFloat("Bass", this.DirectionX);
			this.EOCCJGIGEGJ().SetFloat("_Green_B", this.Speed);
			this.EBJKJPAIAAM().SetFloat("_Line", this.Size);
			this.GJHLADDCMFF().SetFloat("CameraFilterPack/Distortion_Aspiration", this.Distortion);
			this.IGKFMCPDNOI().SetFloat("_ScreenResolution", this.StormFlashOnOff);
			this.IKBJACCLPCL().SetVector("[PlayerBase] Current attempt: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1409f, 21f));
			this.KHCLIAMBBNC().SetTexture("DPADVER", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E06 RID: 3590 RVA: 0x00061525 File Offset: 0x0005F725
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E07 RID: 3591 RVA: 0x00061525 File Offset: 0x0005F725
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E08 RID: 3592 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x06000E09 RID: 3593 RVA: 0x0006315F File Offset: 0x0006135F
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E0A RID: 3594 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOAGAKFBIGD()
	{
	}

	// Token: 0x06000E0B RID: 3595 RVA: 0x00063198 File Offset: 0x00061398
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1600f)
			{
				this.HBJJOCHGOPH = 437f;
			}
			this.JIBOKBCPDLC().SetFloat("#reward: ", this.HBJJOCHGOPH);
			this.NJDIODJNGGA().SetFloat("_ScreenResolution", this.Fade);
			this.LPDOGGFOBDH().SetFloat("CameraFilterPack/Distortion_Lens", this.Intensity);
			this.BLMPMOIDGMG().SetFloat("_TimeX", this.DirectionX);
			this.FGENHBKMPDA().SetFloat("_Value", this.Speed);
			this.PDEAHJPOMEF().SetFloat("EventMenu", this.Size);
			this.KEMAALEODNH().SetFloat("_Value", this.Distortion);
			this.GJHLADDCMFF().SetFloat("_NoiseTex", this.StormFlashOnOff);
			this.FGENHBKMPDA().SetVector("IconImage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 557f, 157f));
			this.NBPKMLMCHFN.SetTexture("ConnectToMaster() failed. Can only connect while in state 'Disconnected'. Current state: ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E0C RID: 3596 RVA: 0x000632EF File Offset: 0x000614EF
	private void ODBNMPGBCGO()
	{
		this.FPHEBLMINDA = (Resources.Load("Left") as Texture2D);
		this.SCShader = Shader.Find("_Intensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E0D RID: 3597 RVA: 0x00061525 File Offset: 0x0005F725
	private void MFBCLNAHEFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E0E RID: 3598 RVA: 0x00063328 File Offset: 0x00061528
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E0F RID: 3599 RVA: 0x0006335F File Offset: 0x0006155F
	private void PAKPHKPDKGE()
	{
		this.FPHEBLMINDA = (Resources.Load("_HdrParams") as Texture2D);
		this.SCShader = Shader.Find("Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E10 RID: 3600 RVA: 0x00063398 File Offset: 0x00061598
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 233f)
			{
				this.HBJJOCHGOPH = 1560f;
			}
			this.ECCPAOBFDKP().SetFloat("_LowRez", this.HBJJOCHGOPH);
			this.EBJKJPAIAAM().SetFloat("RB", this.Fade);
			this.BLMPMOIDGMG().SetFloat("attempted to spawn a GameObject from recycle bin (", this.Intensity);
			this.MJJIEHANFJA().SetFloat("CameraFilterPack/Distortion_Dream2", this.DirectionX);
			this.LPDOGGFOBDH().SetFloat("_Size", this.Speed);
			this.FGENHBKMPDA().SetFloat("SetParticlesParticleSpeed", this.Size);
			this.PLBEJJIHFPB().SetFloat("a year ago", this.Distortion);
			this.PDEAHJPOMEF().SetFloat("_Threshold", this.StormFlashOnOff);
			this.PDEAHJPOMEF().SetVector("<b>Speed</b>:", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 675f, 16f));
			this.KGOLDDBHIFN().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E11 RID: 3601 RVA: 0x000634EF File Offset: 0x000616EF
	private void AKHCOBHHGJP()
	{
		this.FPHEBLMINDA = (Resources.Load("settings.selectormapsperpage") as Texture2D);
		this.SCShader = Shader.Find("cameramovements:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E12 RID: 3602 RVA: 0x00063528 File Offset: 0x00061728
	private Material NJDIODJNGGA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E13 RID: 3603 RVA: 0x00063560 File Offset: 0x00061760
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 568f)
			{
				this.HBJJOCHGOPH = 1532f;
			}
			this.EBJKJPAIAAM().SetFloat("return ", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("\\\"", this.Fade);
			this.KGOLDDBHIFN().SetFloat("<b>HP</b>:", this.Intensity);
			this.FKEOGPDLBDD().SetFloat("Editor/", this.DirectionX);
			this.HKIMAANBGMJ().SetFloat("AreaTex", this.Speed);
			this.FGENHBKMPDA().SetFloat("https://bitbucket.org/khb-soft/intralismarcsviewer/", this.Size);
			this.GJHLADDCMFF().SetFloat("_TempTexture", this.Distortion);
			this.KEMAALEODNH().SetFloat("sounds/hit_perfect", this.StormFlashOnOff);
			this.LPDOGGFOBDH().SetVector("settings.showHP", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1139f, 1491f));
			this.FKEOGPDLBDD().SetTexture("Items/", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E14 RID: 3604 RVA: 0x000636B7 File Offset: 0x000618B7
	private void DLBODOFAJGM()
	{
		this.FPHEBLMINDA = (Resources.Load("_Speed") as Texture2D);
		this.SCShader = Shader.Find("settings.disablestoryboard");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E15 RID: 3605 RVA: 0x000636F0 File Offset: 0x000618F0
	private void LBAJLLFMMMP()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value2") as Texture2D);
		this.SCShader = Shader.Find("\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E16 RID: 3606 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06000E17 RID: 3607 RVA: 0x00061525 File Offset: 0x0005F725
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E18 RID: 3608 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIPBNBKNICE()
	{
	}

	// Token: 0x06000E19 RID: 3609 RVA: 0x0006372C File Offset: 0x0006192C
	private void KHGEBPHKAGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 961f)
			{
				this.HBJJOCHGOPH = 1226f;
			}
			this.FGENHBKMPDA().SetFloat(".", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("_Value", this.Fade);
			this.GJHLADDCMFF().SetFloat("#tryagain", this.Intensity);
			this.DIOAAHJDMLK().SetFloat("bans.viewed.", this.DirectionX);
			this.FKEOGPDLBDD().SetFloat("_Speed", this.Speed);
			this.EBJKJPAIAAM().SetFloat("skin.hit_wrong", this.Size);
			this.LPDOGGFOBDH().SetFloat("CheckResources () for ", this.Distortion);
			this.OCHJIMJNEMO().SetFloat("_Value7", this.StormFlashOnOff);
			this.EOCCJGIGEGJ().SetVector("[SERVER] Selected map: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1194f, 543f));
			this.BLMPMOIDGMG().SetTexture(": ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E1A RID: 3610 RVA: 0x00063883 File Offset: 0x00061A83
	private void IMCKJCHKMKB()
	{
		this.FPHEBLMINDA = (Resources.Load("settings.gamemessagesduration") as Texture2D);
		this.SCShader = Shader.Find("_DotSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E1B RID: 3611 RVA: 0x000638BC File Offset: 0x00061ABC
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1457f)
			{
				this.HBJJOCHGOPH = 3f;
			}
			this.FGENHBKMPDA().SetFloat("cancel", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Vignetting2", this.Fade);
			this.NFKFAAHHLLM().SetFloat("_TileTexDebug", this.Intensity);
			this.PDEAHJPOMEF().SetFloat("BitsData", this.DirectionX);
			this.NBPKMLMCHFN.SetFloat("ConfigVersionSlider", this.Speed);
			this.ECCPAOBFDKP().SetFloat("_TimeX", this.Size);
			this.HKIMAANBGMJ().SetFloat("config.txt", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("SpawnObj", this.StormFlashOnOff);
			this.NBPKMLMCHFN.SetVector("Scrollbar", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 307f, 589f));
			this.MJJIEHANFJA().SetTexture("_Value", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E1C RID: 3612 RVA: 0x00063A13 File Offset: 0x00061C13
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E1D RID: 3613 RVA: 0x00063528 File Offset: 0x00061728
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E1E RID: 3614 RVA: 0x00061525 File Offset: 0x0005F725
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x06000E1F RID: 3615 RVA: 0x00063A4A File Offset: 0x00061C4A
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

	// Token: 0x06000E20 RID: 3616 RVA: 0x00061525 File Offset: 0x0005F725
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E21 RID: 3617 RVA: 0x00063A81 File Offset: 0x00061C81
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E22 RID: 3618 RVA: 0x00063AB8 File Offset: 0x00061CB8
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E23 RID: 3619 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06000E24 RID: 3620 RVA: 0x00063AEF File Offset: 0x00061CEF
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E25 RID: 3621 RVA: 0x00061525 File Offset: 0x0005F725
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E26 RID: 3622 RVA: 0x00063B28 File Offset: 0x00061D28
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1241f)
			{
				this.HBJJOCHGOPH = 851f;
			}
			this.OCHJIMJNEMO().SetFloat("ScreenResolutionPanel", this.HBJJOCHGOPH);
			this.HKIMAANBGMJ().SetFloat("LevelEditor/CustomEventEditor-Text", this.Fade);
			this.OCHJIMJNEMO().SetFloat("/", this.Intensity);
			this.KGOLDDBHIFN().SetFloat("_Value7", this.DirectionX);
			this.KGOLDDBHIFN().SetFloat("[ItemsHandler] Loading Steam inventory", this.Speed);
			this.GJHLADDCMFF().SetFloat("_Offsets", this.Size);
			this.DIOAAHJDMLK().SetFloat("_DotSize", this.Distortion);
			this.PDEAHJPOMEF().SetFloat("CameraFilterPack/Glasses_On", this.StormFlashOnOff);
			this.KOHGPKOFEJO().SetVector("no lives color", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1466f, 565f));
			this.IKBJACCLPCL().SetTexture("Right", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E27 RID: 3623 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06000E28 RID: 3624 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06000E29 RID: 3625 RVA: 0x00063C7F File Offset: 0x00061E7F
	private void KIMMMCJFMAB()
	{
		this.FPHEBLMINDA = (Resources.Load("#") as Texture2D);
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E2A RID: 3626 RVA: 0x00063CB8 File Offset: 0x00061EB8
	private Material KHCLIAMBBNC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E2B RID: 3627 RVA: 0x00063CEF File Offset: 0x00061EEF
	private void PMPKMGKAAJH()
	{
		this.FPHEBLMINDA = (Resources.Load("Mouse Y") as Texture2D);
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E2C RID: 3628 RVA: 0x00063D28 File Offset: 0x00061F28
	private Material BLMPMOIDGMG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E2D RID: 3629 RVA: 0x00063D5F File Offset: 0x00061F5F
	private void JILOMOBDPIA()
	{
		this.FPHEBLMINDA = (Resources.Load("[DiscordController] Responding yes to Ask to Join request") as Texture2D);
		this.SCShader = Shader.Find("[PlayerBase] SetSpeed error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E2E RID: 3630 RVA: 0x00063D98 File Offset: 0x00061F98
	private Material KLKILLCHJHO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E2F RID: 3631 RVA: 0x00063DCF File Offset: 0x00061FCF
	private void HAIAHJPCPAG()
	{
		this.FPHEBLMINDA = (Resources.Load("SetSpeed") as Texture2D);
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E30 RID: 3632 RVA: 0x00063E08 File Offset: 0x00062008
	private void OGJJDKENBNC()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E31 RID: 3633 RVA: 0x00063E44 File Offset: 0x00062044
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 15f)
			{
				this.HBJJOCHGOPH = 160f;
			}
			this.KGOLDDBHIFN().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("CameraFilterPack/Gradients_ElectricGradient", this.Fade);
			this.EOCCJGIGEGJ().SetFloat("ConnectToMaster() failed. Can only connect while in state 'Disconnected'. Current state: ", this.Intensity);
			this.IGKFMCPDNOI().SetFloat("OnPlayerGameMessage", this.DirectionX);
			this.FKEOGPDLBDD().SetFloat("maps.", this.Speed);
			this.DIOAAHJDMLK().SetFloat("EventTimeInputField", this.Size);
			this.KEMAALEODNH().SetFloat("UseScanLine", this.Distortion);
			this.NJDIODJNGGA().SetFloat("HostType: {0} ", this.StormFlashOnOff);
			this.PLBEJJIHFPB().SetVector("Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 726f, 1871f));
			this.OCHJIMJNEMO().SetTexture("Line", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IKBJACCLPCL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E32 RID: 3634 RVA: 0x00063F9C File Offset: 0x0006219C
	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1895f)
			{
				this.HBJJOCHGOPH = 1119f;
			}
			this.JIBOKBCPDLC().SetFloat("AudioSampler", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("float,2", this.Fade);
			this.MJJIEHANFJA().SetFloat("settings.cameramovements", this.Intensity);
			this.NFKFAAHHLLM().SetFloat("_Value2", this.DirectionX);
			this.KGOLDDBHIFN().SetFloat("_CurTex", this.Speed);
			this.OCHJIMJNEMO().SetFloat("UsernameText", this.Size);
			this.NFKFAAHHLLM().SetFloat("inventory.selected.", this.Distortion);
			this.MJJIEHANFJA().SetFloat("#91CCFF", this.StormFlashOnOff);
			this.EOCCJGIGEGJ().SetVector("LevelConfigButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1794f, 86f));
			this.LPDOGGFOBDH().SetTexture("GlassAberration", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E33 RID: 3635 RVA: 0x000640F3 File Offset: 0x000622F3
	private void CNGAJDBOCLJ()
	{
		this.FPHEBLMINDA = (Resources.Load("maps.") as Texture2D);
		this.SCShader = Shader.Find("player.goldwatermelon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E34 RID: 3636 RVA: 0x00061525 File Offset: 0x0005F725
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E35 RID: 3637 RVA: 0x00061525 File Offset: 0x0005F725
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E36 RID: 3638 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKMELABKBHO()
	{
	}

	// Token: 0x06000E37 RID: 3639 RVA: 0x00061525 File Offset: 0x0005F725
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E38 RID: 3640 RVA: 0x0006412C File Offset: 0x0006232C
	private void IKDNLHLBHID()
	{
		this.FPHEBLMINDA = (Resources.Load("DPADHOR") as Texture2D);
		this.SCShader = Shader.Find("SupportLogger Info: PUN {0}: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E39 RID: 3641 RVA: 0x00063A13 File Offset: 0x00061C13
	private Material EBJKJPAIAAM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E3A RID: 3642 RVA: 0x00064165 File Offset: 0x00062365
	private void JHANGPCOCIG()
	{
		this.FPHEBLMINDA = (Resources.Load("Joystick1Button12") as Texture2D);
		this.SCShader = Shader.Find("Tab2Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E3B RID: 3643 RVA: 0x0006419E File Offset: 0x0006239E
	private void NLDKIPEMILC()
	{
		this.FPHEBLMINDA = (Resources.Load("menu.hardcoreinfo") as Texture2D);
		this.SCShader = Shader.Find("ACCEPT");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E3C RID: 3644 RVA: 0x0002523B File Offset: 0x0002343B
	private void ANKIJGCGCBF()
	{
	}

	// Token: 0x06000E3D RID: 3645 RVA: 0x000641D7 File Offset: 0x000623D7
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E3E RID: 3646 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06000E3F RID: 3647 RVA: 0x0006420E File Offset: 0x0006240E
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)105;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E40 RID: 3648 RVA: 0x00061525 File Offset: 0x0005F725
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E41 RID: 3649 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFMEAMBLODG()
	{
	}

	// Token: 0x06000E42 RID: 3650 RVA: 0x00064245 File Offset: 0x00062445
	private void FJNCHGLIEMA()
	{
		this.FPHEBLMINDA = (Resources.Load("Unknown player asked for PickupItems") as Texture2D);
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E43 RID: 3651 RVA: 0x00064280 File Offset: 0x00062480
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 993f)
			{
				this.HBJJOCHGOPH = 1793f;
			}
			this.HKIMAANBGMJ().SetFloat("float,0", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("JoinButton", this.Fade);
			this.JIBOKBCPDLC().SetFloat("[PlayerController] ", this.Intensity);
			this.JIBOKBCPDLC().SetFloat("_CurveParams", this.DirectionX);
			this.IGKFMCPDNOI().SetFloat("NEW_ACHIEVEMENT_1_", this.Speed);
			this.FGENHBKMPDA().SetFloat("_ColorR", this.Size);
			this.MJJIEHANFJA().SetFloat(" scene: ", this.Distortion);
			this.KGOLDDBHIFN().SetFloat("CameraFilterPack/NightVisionFX", this.StormFlashOnOff);
			this.GJHLADDCMFF().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 829f, 1708f));
			this.NFKFAAHHLLM().SetTexture("Error0", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E44 RID: 3652 RVA: 0x00061525 File Offset: 0x0005F725
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E46 RID: 3654 RVA: 0x0002523B File Offset: 0x0002343B
	private void MDCFIHDPLIG()
	{
	}

	// Token: 0x06000E47 RID: 3655 RVA: 0x00061525 File Offset: 0x0005F725
	private void ALJEADNKJPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E48 RID: 3656 RVA: 0x00061525 File Offset: 0x0005F725
	private void CNPINCHINJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E49 RID: 3657 RVA: 0x00064444 File Offset: 0x00062644
	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1363f)
			{
				this.HBJJOCHGOPH = 21f;
			}
			this.IIJMIPBMMBF().SetFloat("_BokehParams", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("_TimeX", this.Fade);
			this.NBPKMLMCHFN.SetFloat("settings.enableranking", this.Intensity);
			this.KGOLDDBHIFN().SetFloat("Fade", this.DirectionX);
			this.BLMPMOIDGMG().SetFloat("offsets", this.Speed);
			this.NJDIODJNGGA().SetFloat("CameraFilterPack/Edge_BlackLine", this.Size);
			this.IKBJACCLPCL().SetFloat("_Value5", this.Distortion);
			this.BLMPMOIDGMG().SetFloat("id", this.StormFlashOnOff);
			this.FGENHBKMPDA().SetVector("GlassAberration", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 19f, 1179f));
			this.OCHJIMJNEMO().SetTexture("NewIconFileSelector", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E4A RID: 3658 RVA: 0x0002523B File Offset: 0x0002343B
	private void EPJJDKJEDMM()
	{
	}

	// Token: 0x06000E4B RID: 3659 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06000E4C RID: 3660 RVA: 0x0006459B File Offset: 0x0006279B
	private void EFJDNLGNACH()
	{
		this.FPHEBLMINDA = (Resources.Load("ChangeSelectedLevel") as Texture2D);
		this.SCShader = Shader.Find(". ActorNr: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E4D RID: 3661 RVA: 0x000645D4 File Offset: 0x000627D4
	private void CCFEDENFNEF()
	{
		this.FPHEBLMINDA = (Resources.Load("COMPLETED") as Texture2D);
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E4E RID: 3662 RVA: 0x0006460D File Offset: 0x0006280D
	private void NNFMIAFHMJM()
	{
		this.FPHEBLMINDA = (Resources.Load("&search=") as Texture2D);
		this.SCShader = Shader.Find("Parameter levelId must be int or string!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E4F RID: 3663 RVA: 0x00061525 File Offset: 0x0005F725
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E50 RID: 3664 RVA: 0x00064646 File Offset: 0x00062846
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E51 RID: 3665 RVA: 0x0006467D File Offset: 0x0006287D
	private void IHLMNAGPKDA()
	{
		this.FPHEBLMINDA = (Resources.Load("-") as Texture2D);
		this.SCShader = Shader.Find("skin.hit_wrong");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E52 RID: 3666 RVA: 0x000646B6 File Offset: 0x000628B6
	private void EDPDMBFLHLP()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/FX_InverChromiLum") as Texture2D);
		this.SCShader = Shader.Find("Vertical");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000E53 RID: 3667 RVA: 0x000646EF File Offset: 0x000628EF
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000E54 RID: 3668 RVA: 0x00064728 File Offset: 0x00062928
	private void AIKDNGCEDAB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1153f)
			{
				this.HBJJOCHGOPH = 1602f;
			}
			this.DIOAAHJDMLK().SetFloat("MaxLivesSlider", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("Editor/", this.Fade);
			this.IIJMIPBMMBF().SetFloat(").png", this.Intensity);
			this.KOHGPKOFEJO().SetFloat("CameraFilterPack/Glasses_On", this.DirectionX);
			this.FKEOGPDLBDD().SetFloat("PossibleMapPointsText", this.Speed);
			this.NJDIODJNGGA().SetFloat("CameraFilterPack/Edge_Edge_filter", this.Size);
			this.KEMAALEODNH().SetFloat(" on effect ", this.Distortion);
			this.IGKFMCPDNOI().SetFloat("_SampleScale", this.StormFlashOnOff);
			this.KHCLIAMBBNC().SetVector("https://api.steampowered.com/IInventoryService/AddItem/v001", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 601f, 765f));
			this.HKIMAANBGMJ().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E55 RID: 3669 RVA: 0x0006487F File Offset: 0x00062A7F
	private void GNJDKAECPKA()
	{
		this.FPHEBLMINDA = (Resources.Load("_Bullet_7") as Texture2D);
		this.SCShader = Shader.Find("float,2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000E56 RID: 3670 RVA: 0x000648B8 File Offset: 0x00062AB8
	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1655f)
			{
				this.HBJJOCHGOPH = 655f;
			}
			this.HKIMAANBGMJ().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("_Value2", this.Fade);
			this.MJJIEHANFJA().SetFloat("_MainTex2", this.Intensity);
			this.LPDOGGFOBDH().SetFloat("_ScreenResolution", this.DirectionX);
			this.PDEAHJPOMEF().SetFloat("_Value", this.Speed);
			this.KLKILLCHJHO().SetFloat("_CutOff", this.Size);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.Distortion);
			this.PDEAHJPOMEF().SetFloat("Default UI Material", this.StormFlashOnOff);
			this.MJJIEHANFJA().SetVector("Dec", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 445f, 238f));
			this.JIBOKBCPDLC().SetTexture("LoadingStatusText", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000E57 RID: 3671 RVA: 0x00061525 File Offset: 0x0005F725
	private void ONPFGCEFMML()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000E58 RID: 3672 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06000E59 RID: 3673 RVA: 0x00064A0F File Offset: 0x00062C0F
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)124;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000200 RID: 512
	public Shader SCShader;

	// Token: 0x04000201 RID: 513
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000202 RID: 514
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000203 RID: 515
	private Material BJFKDHHMLJH;

	// Token: 0x04000204 RID: 516
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x04000205 RID: 517
	[Range(0f, 2f)]
	public float Intensity = 0.5f;

	// Token: 0x04000206 RID: 518
	[Range(-0.25f, 0.25f)]
	public float DirectionX = 0.12f;

	// Token: 0x04000207 RID: 519
	[Range(0.4f, 2f)]
	public float Size = 1.5f;

	// Token: 0x04000208 RID: 520
	[Range(0f, 0.5f)]
	public float Speed = 0.275f;

	// Token: 0x04000209 RID: 521
	[Range(0f, 0.5f)]
	public float Distortion = 0.05f;

	// Token: 0x0400020A RID: 522
	[Range(0f, 1f)]
	public float StormFlashOnOff = 1f;

	// Token: 0x0400020B RID: 523
	private Texture2D FPHEBLMINDA;
}
