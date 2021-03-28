using System;
using UnityEngine;

// Token: 0x02000138 RID: 312
[AddComponentMenu("Camera Filter Pack/Vision/Rainbow")]
[ExecuteInEditMode]
public class CameraFilterPack_Vision_Rainbow : MonoBehaviour
{
	// Token: 0x0600629E RID: 25246 RVA: 0x001DFC7F File Offset: 0x001DDE7F
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("[ItemsHandler] Loading ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600629F RID: 25247 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x060062A0 RID: 25248 RVA: 0x001DFCA3 File Offset: 0x001DDEA3
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060062A1 RID: 25249 RVA: 0x001DFCC0 File Offset: 0x001DDEC0
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060062A2 RID: 25250 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x060062A3 RID: 25251 RVA: 0x001DFCF8 File Offset: 0x001DDEF8
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 715f)
			{
				this.HBJJOCHGOPH = 224f;
			}
			this.KEMAALEODNH().SetFloat("/Segment-[Right]", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("/", this.Speed);
			this.PLBEJJIHFPB().SetFloat("_Distortion", this.PosX);
			this.HHIAIGCAHDA().SetFloat("G:", this.PosY);
			this.PDEAHJPOMEF().SetFloat("CameraFilterPack/BlurTiltShift", this.Colors);
			this.MICHFGAOPKM().SetFloat("DifficultyBG", this.Vision);
			this.MFHPKGICPIO().SetVector("string", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 623f, 453f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060062A4 RID: 25252 RVA: 0x001DFE0D File Offset: 0x001DE00D
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060062A5 RID: 25253 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x060062A6 RID: 25254 RVA: 0x001DFE44 File Offset: 0x001DE044
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1830f)
			{
				this.HBJJOCHGOPH = 1665f;
			}
			this.PDEAHJPOMEF().SetFloat(":", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("\n\n#", this.Speed);
			this.PDEAHJPOMEF().SetFloat("Fade", this.PosX);
			this.MICHFGAOPKM().SetFloat("LivesSlider", this.PosY);
			this.MFHPKGICPIO().SetFloat("SetLives", this.Colors);
			this.IGKFMCPDNOI().SetFloat(":", this.Vision);
			this.PDEAHJPOMEF().SetVector("float,0.5", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1497f, 303f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060062A7 RID: 25255 RVA: 0x001DFCA3 File Offset: 0x001DDEA3
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060062A8 RID: 25256 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x060062A9 RID: 25257 RVA: 0x001DFF5C File Offset: 0x001DE15C
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 860f)
			{
				this.HBJJOCHGOPH = 61f;
			}
			this.DONENAMLFLF().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("PLEASE WAIT", this.Speed);
			this.PDEAHJPOMEF().SetFloat("_TimeX", this.PosX);
			this.HHIAIGCAHDA().SetFloat("OK", this.PosY);
			this.AELJLBOJAIL().SetFloat("data", this.Colors);
			this.MFHPKGICPIO().SetFloat("settings.crosshairopacity", this.Vision);
			this.IGKFMCPDNOI().SetVector(" not exist", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1569f, 1389f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060062AA RID: 25258 RVA: 0x001E0071 File Offset: 0x001DE271
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-126);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060062AB RID: 25259 RVA: 0x001E00A8 File Offset: 0x001DE2A8
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 8f)
			{
				this.HBJJOCHGOPH = 392f;
			}
			this.PLBEJJIHFPB().SetFloat("Preparing content", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("menu.enableselectormusic", this.Speed);
			this.GKILCDHJFEG().SetFloat("Set Sun MinSize", this.PosX);
			this.GKILCDHJFEG().SetFloat("player.playedtutorial", this.PosY);
			this.IGKFMCPDNOI().SetFloat("NewMapHandsCountSlider", this.Colors);
			this.PLBEJJIHFPB().SetFloat("_Offsets", this.Vision);
			this.PLBEJJIHFPB().SetVector("_AdaptTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1368f, 1717f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060062AC RID: 25260 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060062AD RID: 25261 RVA: 0x001E01C0 File Offset: 0x001DE3C0
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1799f)
			{
				this.HBJJOCHGOPH = 1943f;
			}
			this.PDEAHJPOMEF().SetFloat("Speed is a lerp speed of color changing. Greater values means faster changing. 0 - intant change", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("1 Kb", this.Speed);
			this.KEMAALEODNH().SetFloat("/", this.PosX);
			this.MICHFGAOPKM().SetFloat("/", this.PosY);
			this.PDEAHJPOMEF().SetFloat("[PlayerBase] Loaded custom model: ", this.Colors);
			this.IGKFMCPDNOI().SetFloat("_RampOffset", this.Vision);
			this.PLBEJJIHFPB().SetVector("[Up-Right-Down]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 652f, 1893f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060062AE RID: 25262 RVA: 0x001E02D8 File Offset: 0x001DE4D8
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1866f)
			{
				this.HBJJOCHGOPH = 40f;
			}
			this.IGKFMCPDNOI().SetFloat("stats on", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("NewMusicFileSelector", this.Speed);
			this.PLBEJJIHFPB().SetFloat("Rap", this.PosX);
			this.HHIAIGCAHDA().SetFloat("EndlessLoopsScoreText", this.PosY);
			this.PDEAHJPOMEF().SetFloat("OK", this.Colors);
			this.DNLMFEGJJDD().SetFloat("Stream did not contain properly formatted byte array", this.Vision);
			this.GKILCDHJFEG().SetVector("STICKLVER", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 43f, 176f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060062AF RID: 25263 RVA: 0x001E03F0 File Offset: 0x001DE5F0
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1464f)
			{
				this.HBJJOCHGOPH = 1314f;
			}
			this.PLBEJJIHFPB().SetFloat("_Fade", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat(",", this.Speed);
			this.AELJLBOJAIL().SetFloat("FrostCanvas", this.PosX);
			this.DONENAMLFLF().SetFloat("_Level", this.PosY);
			this.DNLMFEGJJDD().SetFloat("#orderby:", this.Colors);
			this.HHIAIGCAHDA().SetFloat("RecieveChatActionMessage", this.Vision);
			this.MFHPKGICPIO().SetVector("Image", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1961f, 1797f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060062B0 RID: 25264 RVA: 0x001E0508 File Offset: 0x001DE708
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 450f)
			{
				this.HBJJOCHGOPH = 980f;
			}
			this.HHIAIGCAHDA().SetFloat("Players NetIDs:", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("AddEnvironmentSprite", this.Speed);
			this.AELJLBOJAIL().SetFloat("_TimeX", this.PosX);
			this.DNLMFEGJJDD().SetFloat("_EmissionColor", this.PosY);
			this.GKILCDHJFEG().SetFloat("_Value3", this.Colors);
			this.PDEAHJPOMEF().SetFloat("_TimeX", this.Vision);
			this.DONENAMLFLF().SetVector("BitsData", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 691f, 1387f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060062B1 RID: 25265 RVA: 0x001E061D File Offset: 0x001DE81D
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blur_Noise");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060062B2 RID: 25266 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x060062B3 RID: 25267 RVA: 0x001DFCA3 File Offset: 0x001DDEA3
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060062B4 RID: 25268 RVA: 0x001E0641 File Offset: 0x001DE841
	private void FMNPFCHBLJF()
	{
		this.SCShader = Shader.Find("settings.crosshairopacity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060062B5 RID: 25269 RVA: 0x001DFCA3 File Offset: 0x001DDEA3
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060062B6 RID: 25270 RVA: 0x001E0665 File Offset: 0x001DE865
	private void FLKEJJEGCFA()
	{
		this.SCShader = Shader.Find(".wav");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x1700011D RID: 285
	// (get) Token: 0x060062B7 RID: 25271 RVA: 0x001E0689 File Offset: 0x001DE889
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

	// Token: 0x060062B8 RID: 25272 RVA: 0x001E06C0 File Offset: 0x001DE8C0
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060062B9 RID: 25273 RVA: 0x001E06C0 File Offset: 0x001DE8C0
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060062BA RID: 25274 RVA: 0x001DFCA3 File Offset: 0x001DDEA3
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060062BB RID: 25275 RVA: 0x001E06F7 File Offset: 0x001DE8F7
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060062BC RID: 25276 RVA: 0x001E072E File Offset: 0x001DE92E
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("Joystick1Button5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060062BD RID: 25277 RVA: 0x001E0752 File Offset: 0x001DE952
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("ok");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060062BE RID: 25278 RVA: 0x001DFCA3 File Offset: 0x001DDEA3
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060062BF RID: 25279 RVA: 0x001E0778 File Offset: 0x001DE978
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1656f)
			{
				this.HBJJOCHGOPH = 1349f;
			}
			this.PLBEJJIHFPB().SetFloat("LostLive", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("/", this.Speed);
			this.NBPKMLMCHFN.SetFloat("maps.", this.PosX);
			this.KEMAALEODNH().SetFloat("_LightIntensity", this.PosY);
			this.IGKFMCPDNOI().SetFloat("Folk", this.Colors);
			this.AELJLBOJAIL().SetFloat("maps.", this.Vision);
			this.MFHPKGICPIO().SetVector("_MaxRadiusOrKInPaper", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 660f, 1592f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060062C0 RID: 25280 RVA: 0x001E088D File Offset: 0x001DEA8D
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060062C1 RID: 25281 RVA: 0x001E08C4 File Offset: 0x001DEAC4
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1605f)
			{
				this.HBJJOCHGOPH = 298f;
			}
			this.NBPKMLMCHFN.SetFloat("You need to have a Graphic control (such as an Image) for the list [", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("_PixelsPerMeterAtOneMeter", this.Speed);
			this.HHIAIGCAHDA().SetFloat("ConfigVersionSlider", this.PosX);
			this.DONENAMLFLF().SetFloat("_Green_G", this.PosY);
			this.MICHFGAOPKM().SetFloat("HitInRelaxMusicToggle", this.Colors);
			this.PLBEJJIHFPB().SetFloat("RT", this.Vision);
			this.GKILCDHJFEG().SetVector("CameraFilterPack_Atmosphere_Rain_FX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1596f, 1032f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060062C2 RID: 25282 RVA: 0x001E09D9 File Offset: 0x001DEBD9
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("_HalfResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060062C3 RID: 25283 RVA: 0x001E09FD File Offset: 0x001DEBFD
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("Hex value #RRGGBB");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060062C4 RID: 25284 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x060062C5 RID: 25285 RVA: 0x001E0A24 File Offset: 0x001DEC24
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.PosX);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.PosY);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Colors);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Vision);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060062C6 RID: 25286 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x060062C7 RID: 25287 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x060062C8 RID: 25288 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x060062C9 RID: 25289 RVA: 0x001E0B39 File Offset: 0x001DED39
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)86;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060062CA RID: 25290 RVA: 0x001E0B70 File Offset: 0x001DED70
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1763f)
			{
				this.HBJJOCHGOPH = 1070f;
			}
			this.HHIAIGCAHDA().SetFloat("From {0} at Index {1} \n", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("_TimeX", this.Speed);
			this.DNLMFEGJJDD().SetFloat("_ScreenResolution", this.PosX);
			this.IGKFMCPDNOI().SetFloat(":", this.PosY);
			this.GKILCDHJFEG().SetFloat("Done! You are a contributor until: ", this.Colors);
			this.IGKFMCPDNOI().SetFloat("Set Particles Gravity", this.Vision);
			this.KEMAALEODNH().SetVector("CameraFilterPack_AAA_Blood1", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1172f, 192f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060062CB RID: 25291 RVA: 0x001E0C85 File Offset: 0x001DEE85
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("_History1ChromaTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060062CC RID: 25292 RVA: 0x001E0CAC File Offset: 0x001DEEAC
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1761f)
			{
				this.HBJJOCHGOPH = 283f;
			}
			this.MICHFGAOPKM().SetFloat("y", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("id", this.Speed);
			this.PLBEJJIHFPB().SetFloat("_GlowColor", this.PosX);
			this.MICHFGAOPKM().SetFloat("CameraFilterPack/Blend2Camera_Hue", this.PosY);
			this.NBPKMLMCHFN.SetFloat("#no", this.Colors);
			this.KEMAALEODNH().SetFloat("player.xp", this.Vision);
			this.PDEAHJPOMEF().SetVector("roomDescription", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1569f, 1774f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060062CD RID: 25293 RVA: 0x001E0DC1 File Offset: 0x001DEFC1
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060062CE RID: 25294 RVA: 0x001DFCA3 File Offset: 0x001DDEA3
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060062CF RID: 25295 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x060062D0 RID: 25296 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x060062D1 RID: 25297 RVA: 0x001E0DE5 File Offset: 0x001DEFE5
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Vision_Rainbow");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060062D2 RID: 25298 RVA: 0x001DFCA3 File Offset: 0x001DDEA3
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060062D3 RID: 25299 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x060062D4 RID: 25300 RVA: 0x001DFCA3 File Offset: 0x001DDEA3
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060062D5 RID: 25301 RVA: 0x001DFCA3 File Offset: 0x001DDEA3
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060062D7 RID: 25303 RVA: 0x001E0E61 File Offset: 0x001DF061
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060062D8 RID: 25304 RVA: 0x001E0E98 File Offset: 0x001DF098
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 560f)
			{
				this.HBJJOCHGOPH = 1986f;
			}
			this.AELJLBOJAIL().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("_Value2", this.Speed);
			this.PDEAHJPOMEF().SetFloat("_Value6", this.PosX);
			this.MFHPKGICPIO().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this.PosY);
			this.DNLMFEGJJDD().SetFloat("Game Version: ", this.Colors);
			this.DNLMFEGJJDD().SetFloat("ConnectToMaster() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", this.Vision);
			this.AELJLBOJAIL().SetVector("SpectatingUserInfo", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1993f, 768f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060062D9 RID: 25305 RVA: 0x001DFCA3 File Offset: 0x001DDEA3
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060062DA RID: 25306 RVA: 0x001E0FB0 File Offset: 0x001DF1B0
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1798f)
			{
				this.HBJJOCHGOPH = 723f;
			}
			this.NBPKMLMCHFN.SetFloat("_Threshold", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("settings.shaders.bloomintencity", this.Speed);
			this.HHIAIGCAHDA().SetFloat("#availablechallenges", this.PosX);
			this.MICHFGAOPKM().SetFloat("open", this.PosY);
			this.PDEAHJPOMEF().SetFloat("ViewMenu", this.Colors);
			this.KEMAALEODNH().SetFloat("CameraFilterPack/FX_InverChromiLum", this.Vision);
			this.NBPKMLMCHFN.SetVector("settings.enableranking", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1658f, 348f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060062DB RID: 25307 RVA: 0x001E10C8 File Offset: 0x001DF2C8
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1611f)
			{
				this.HBJJOCHGOPH = 1912f;
			}
			this.IGKFMCPDNOI().SetFloat("ReconnectAndRejoin() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("_FixDistance", this.Speed);
			this.KEMAALEODNH().SetFloat("_EmissionGain", this.PosX);
			this.DONENAMLFLF().SetFloat("mapselector.filter.favoriteonly", this.PosY);
			this.IGKFMCPDNOI().SetFloat("SpawnObj", this.Colors);
			this.AELJLBOJAIL().SetFloat("skin.hit_normal", this.Vision);
			this.GKILCDHJFEG().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1151f, 325f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060062DC RID: 25308 RVA: 0x001E11E0 File Offset: 0x001DF3E0
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 493f)
			{
				this.HBJJOCHGOPH = 109f;
			}
			this.KEMAALEODNH().SetFloat("offsets", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("EventData0DropDownList", this.Speed);
			this.PLBEJJIHFPB().SetFloat("[Down]", this.PosX);
			this.PLBEJJIHFPB().SetFloat("ItemNameBGImage", this.PosY);
			this.PDEAHJPOMEF().SetFloat("_FarCamera", this.Colors);
			this.IGKFMCPDNOI().SetFloat("ok", this.Vision);
			this.DONENAMLFLF().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 654f, 584f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060062DD RID: 25309 RVA: 0x001E12F8 File Offset: 0x001DF4F8
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1964f)
			{
				this.HBJJOCHGOPH = 1753f;
			}
			this.MFHPKGICPIO().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("BitsData", this.Speed);
			this.DNLMFEGJJDD().SetFloat("In Main Menu", this.PosX);
			this.IGKFMCPDNOI().SetFloat("Bass", this.PosY);
			this.KEMAALEODNH().SetFloat("[MapsEditor] Creating new item...", this.Colors);
			this.MICHFGAOPKM().SetFloat("_Offsets", this.Vision);
			this.HHIAIGCAHDA().SetVector(": ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 943f, 1268f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060062DE RID: 25310 RVA: 0x001E1410 File Offset: 0x001DF610
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1013f)
			{
				this.HBJJOCHGOPH = 1253f;
			}
			this.PDEAHJPOMEF().SetFloat("#done", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("_Value3", this.Speed);
			this.MFHPKGICPIO().SetFloat("[PlayerController] ", this.PosX);
			this.IGKFMCPDNOI().SetFloat("_MainTex2", this.PosY);
			this.DNLMFEGJJDD().SetFloat("shader.none", this.Colors);
			this.MICHFGAOPKM().SetFloat("_TimeX", this.Vision);
			this.GKILCDHJFEG().SetVector("LivesSlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 598f, 1287f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060062DF RID: 25311 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x060062E0 RID: 25312 RVA: 0x001DFCA3 File Offset: 0x001DDEA3
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060062E1 RID: 25313 RVA: 0x001DFCA3 File Offset: 0x001DDEA3
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060062E2 RID: 25314 RVA: 0x001E1525 File Offset: 0x001DF725
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060062E3 RID: 25315 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x060062E4 RID: 25316 RVA: 0x001DFCA3 File Offset: 0x001DDEA3
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060062E5 RID: 25317 RVA: 0x001E155C File Offset: 0x001DF75C
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060062E6 RID: 25318 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x060062E7 RID: 25319 RVA: 0x001E1594 File Offset: 0x001DF794
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 189f)
			{
				this.HBJJOCHGOPH = 253f;
			}
			this.IGKFMCPDNOI().SetFloat("PossibleMapPointsText", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("GlassAberration", this.Speed);
			this.KEMAALEODNH().SetFloat("CameraFilterPack/Drawing_Curve", this.PosX);
			this.NBPKMLMCHFN.SetFloat("ComboScoreText", this.PosY);
			this.AELJLBOJAIL().SetFloat("_VelTex", this.Colors);
			this.PDEAHJPOMEF().SetFloat("win", this.Vision);
			this.GKILCDHJFEG().SetVector("float,0", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1931f, 286f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060062E8 RID: 25320 RVA: 0x001DFCA3 File Offset: 0x001DDEA3
	private void IABLKKAALGI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060062E9 RID: 25321 RVA: 0x001E16AC File Offset: 0x001DF8AC
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 258f)
			{
				this.HBJJOCHGOPH = 1899f;
			}
			this.DONENAMLFLF().SetFloat("ConnectToMaster() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("_TimeX", this.Speed);
			this.KEMAALEODNH().SetFloat("float,1", this.PosX);
			this.IGKFMCPDNOI().SetFloat("Tab1Content", this.PosY);
			this.MICHFGAOPKM().SetFloat("DisableStoryboardToggle", this.Colors);
			this.AELJLBOJAIL().SetFloat("ConnectToRegion: ", this.Vision);
			this.DONENAMLFLF().SetVector("red", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1639f, 280f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x040009F1 RID: 2545
	public Shader SCShader;

	// Token: 0x040009F2 RID: 2546
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040009F3 RID: 2547
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040009F4 RID: 2548
	private Material BJFKDHHMLJH;

	// Token: 0x040009F5 RID: 2549
	[Range(0f, 10f)]
	public float Speed = 1f;

	// Token: 0x040009F6 RID: 2550
	[Range(0f, 1f)]
	public float PosX = 0.5f;

	// Token: 0x040009F7 RID: 2551
	[Range(0f, 1f)]
	public float PosY = 0.5f;

	// Token: 0x040009F8 RID: 2552
	[Range(0f, 5f)]
	public float Colors = 0.5f;

	// Token: 0x040009F9 RID: 2553
	[Range(0f, 1f)]
	public float Vision = 0.5f;
}
