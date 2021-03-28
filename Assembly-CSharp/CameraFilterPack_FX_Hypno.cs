using System;
using UnityEngine;

// Token: 0x020000CE RID: 206
[AddComponentMenu("Camera Filter Pack/FX/Hypno")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_Hypno : MonoBehaviour
{
	// Token: 0x06003E3F RID: 15935 RVA: 0x001368CD File Offset: 0x00134ACD
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E40 RID: 15936 RVA: 0x001368CD File Offset: 0x00134ACD
	private void FGBDGGCBFLP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E41 RID: 15937 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06003E42 RID: 15938 RVA: 0x001368EA File Offset: 0x00134AEA
	private void FLKEJJEGCFA()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003E43 RID: 15939 RVA: 0x0013690E File Offset: 0x00134B0E
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E44 RID: 15940 RVA: 0x001368CD File Offset: 0x00134ACD
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E45 RID: 15941 RVA: 0x001368CD File Offset: 0x00134ACD
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E46 RID: 15942 RVA: 0x00136945 File Offset: 0x00134B45
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_WideScreenCircle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003E47 RID: 15943 RVA: 0x00136969 File Offset: 0x00134B69
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E48 RID: 15944 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06003E49 RID: 15945 RVA: 0x001369A0 File Offset: 0x00134BA0
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003E4A RID: 15946 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x06003E4B RID: 15947 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x06003E4C RID: 15948 RVA: 0x001369C4 File Offset: 0x00134BC4
	private void NKFDNIAKGEO()
	{
		this.SCShader = Shader.Find("not available at the moment");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x170000B4 RID: 180
	// (get) Token: 0x06003E4D RID: 15949 RVA: 0x001369E8 File Offset: 0x00134BE8
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

	// Token: 0x06003E4E RID: 15950 RVA: 0x00136A1F File Offset: 0x00134C1F
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E4F RID: 15951 RVA: 0x00136A56 File Offset: 0x00134C56
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E50 RID: 15952 RVA: 0x00136A90 File Offset: 0x00134C90
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 799f)
			{
				this.HBJJOCHGOPH = 1457f;
			}
			this.NBPKMLMCHFN.SetFloat("Submit", this.HBJJOCHGOPH);
			this.FKEOGPDLBDD().SetFloat("CameraFilterPack/Noise_TV_3", this.Speed);
			this.FKEOGPDLBDD().SetFloat("--------------------------------", this.Red);
			this.OHKGGPFGLFD().SetFloat("</color>", this.Green);
			this.FKEOGPDLBDD().SetFloat("Edited unlock conditions", this.Blue);
			this.MMOODGIODPC().SetVector("_MainTex2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 858f, 1231f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E51 RID: 15953 RVA: 0x001368CD File Offset: 0x00134ACD
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E52 RID: 15954 RVA: 0x0002523B File Offset: 0x0002343B
	private void PFNFPINPCMH()
	{
	}

	// Token: 0x06003E53 RID: 15955 RVA: 0x001368CD File Offset: 0x00134ACD
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E54 RID: 15956 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003E55 RID: 15957 RVA: 0x00136B90 File Offset: 0x00134D90
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 711f)
			{
				this.HBJJOCHGOPH = 1036f;
			}
			this.OJMHIMIPKME().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.FKEOGPDLBDD().SetFloat("_Light", this.Speed);
			this.NFKFAAHHLLM().SetFloat("TransferOwnership() view ", this.Red);
			this.BAGICADFBAB().SetFloat("_ReflectionTexture1", this.Green);
			this.FOOCJIDNGBB().SetFloat("shader.frost", this.Blue);
			this.LEIAFCPJMDP().SetVector("request", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 720f, 965f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E56 RID: 15958 RVA: 0x00136C8F File Offset: 0x00134E8F
	private void AKHCOBHHGJP()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003E57 RID: 15959 RVA: 0x00136CB3 File Offset: 0x00134EB3
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find("Zoom speed. Base 1.5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003E58 RID: 15960 RVA: 0x00136CD8 File Offset: 0x00134ED8
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1176f)
			{
				this.HBJJOCHGOPH = 324f;
			}
			this.OKJOKHGJHGF().SetFloat("_SizeX", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("EditMenu", this.Speed);
			this.JLHLHKPHDFO().SetFloat("[LevelEditorScene] Creating new item...", this.Red);
			this.IIJMIPBMMBF().SetFloat("_DepthLevel", this.Green);
			this.IIJMIPBMMBF().SetFloat("MapConfig", this.Blue);
			this.BAGICADFBAB().SetVector("LevelEditor/icons", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 537f, 194f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E59 RID: 15961 RVA: 0x001368CD File Offset: 0x00134ACD
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E5A RID: 15962 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x06003E5B RID: 15963 RVA: 0x00136DD7 File Offset: 0x00134FD7
	private Material LELKBCALFCF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E5C RID: 15964 RVA: 0x00136E0E File Offset: 0x0013500E
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("PUNCloudBestRegion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003E5D RID: 15965 RVA: 0x001368CD File Offset: 0x00134ACD
	private void ABEIEGDHBNO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E5E RID: 15966 RVA: 0x00136E32 File Offset: 0x00135032
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E5F RID: 15967 RVA: 0x001368CD File Offset: 0x00134ACD
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E60 RID: 15968 RVA: 0x00136E6C File Offset: 0x0013506C
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1950f)
			{
				this.HBJJOCHGOPH = 1132f;
			}
			this.HCGJCMDJPGD().SetFloat("]", this.HBJJOCHGOPH);
			this.LELKBCALFCF().SetFloat("_RampOffset", this.Speed);
			this.HEINDEMCGIK().SetFloat("MenuScene", this.Red);
			this.NBPKMLMCHFN.SetFloat("Can't change CrcCheckEnabled while being connected. CrcCheckEnabled stays ", this.Green);
			this.GKILCDHJFEG().SetFloat("value", this.Blue);
			this.EJDPNJAEAKJ().SetVector("-help", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1117f, 398f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E61 RID: 15969 RVA: 0x00136DD7 File Offset: 0x00134FD7
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E62 RID: 15970 RVA: 0x00136F6C File Offset: 0x0013516C
	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 499f)
			{
				this.HBJJOCHGOPH = 1f;
			}
			this.LMLENGFLEBD().SetFloat("settings.selectormapsperpage", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("In Main Menu", this.Speed);
			this.OIMMPLPBLBK().SetFloat("_AxialAberration", this.Red);
			this.NFKFAAHHLLM().SetFloat("DPADHOR", this.Green);
			this.HEINDEMCGIK().SetFloat("Can't connect: ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", this.Blue);
			this.BAGICADFBAB().SetVector("quantity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1434f, 496f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E63 RID: 15971 RVA: 0x001368CD File Offset: 0x00134ACD
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E64 RID: 15972 RVA: 0x0013706B File Offset: 0x0013526B
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find("Creating awesome maps");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003E65 RID: 15973 RVA: 0x00137090 File Offset: 0x00135290
	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1920f)
			{
				this.HBJJOCHGOPH = 1658f;
			}
			this.OKJOKHGJHGF().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetFloat("menu.playedpage", this.Speed);
			this.LEIAFCPJMDP().SetFloat("Arc", this.Red);
			this.LMLENGFLEBD().SetFloat("[#clicktogetreward]", this.Green);
			this.OKJOKHGJHGF().SetFloat("CheckpointsScoreText", this.Blue);
			this.LMLENGFLEBD().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 619f, 1278f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E66 RID: 15974 RVA: 0x00137190 File Offset: 0x00135390
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1265f)
			{
				this.HBJJOCHGOPH = 344f;
			}
			this.IIJMIPBMMBF().SetFloat("SetSatelliteEmission", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("LevelConfigButton", this.Speed);
			this.JLHLHKPHDFO().SetFloat("player.licenceaccepted", this.Red);
			this.HNICHJCGJOC().SetFloat("_TimeX", this.Green);
			this.EJDPNJAEAKJ().SetFloat("_NoisePerChannel", this.Blue);
			this.HNICHJCGJOC().SetVector("CameraFilterPack/FX_Scan", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1841f, 161f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OHKGGPFGLFD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E67 RID: 15975 RVA: 0x00137290 File Offset: 0x00135490
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1590f)
			{
				this.HBJJOCHGOPH = 1061f;
			}
			this.FOOCJIDNGBB().SetFloat("[MapEditor] Loaded music file: ", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("settings.enablehitsoundsinrelax", this.Speed);
			this.BAGICADFBAB().SetFloat("LevelNameText", this.Red);
			this.DKNJGHFLAIF().SetFloat("_Value7", this.Green);
			this.OCHJIMJNEMO().SetFloat("_ScreenResolution", this.Blue);
			this.GKILCDHJFEG().SetVector("2hands", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 112f, 146f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E68 RID: 15976 RVA: 0x001368CD File Offset: 0x00134ACD
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E69 RID: 15977 RVA: 0x001368CD File Offset: 0x00134ACD
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E6A RID: 15978 RVA: 0x0013738F File Offset: 0x0013558F
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E6B RID: 15979 RVA: 0x001373C8 File Offset: 0x001355C8
	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 517f)
			{
				this.HBJJOCHGOPH = 1269f;
			}
			this.OIMMPLPBLBK().SetFloat("player.bat", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("_WhiteBalance", this.Speed);
			this.BAGICADFBAB().SetFloat("event", this.Red);
			this.OKJOKHGJHGF().SetFloat("Anomaly_Distortion", this.Green);
			this.HEINDEMCGIK().SetFloat("maps.", this.Blue);
			this.NBPKMLMCHFN.SetVector("SetSatelliteSensitivity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1730f, 763f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E6C RID: 15980 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x06003E6D RID: 15981 RVA: 0x001368CD File Offset: 0x00134ACD
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E6E RID: 15982 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06003E6F RID: 15983 RVA: 0x001374C7 File Offset: 0x001356C7
	private void FDNONDCGGCG()
	{
		this.SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003E70 RID: 15984 RVA: 0x001368CD File Offset: 0x00134ACD
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E71 RID: 15985 RVA: 0x001374EB File Offset: 0x001356EB
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003E72 RID: 15986 RVA: 0x001368CD File Offset: 0x00134ACD
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E73 RID: 15987 RVA: 0x0013750F File Offset: 0x0013570F
	private Material LEIAFCPJMDP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E74 RID: 15988 RVA: 0x001368CD File Offset: 0x00134ACD
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E75 RID: 15989 RVA: 0x00137546 File Offset: 0x00135746
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("_InvRenderTargetSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003E76 RID: 15990 RVA: 0x0013756A File Offset: 0x0013576A
	private Material OJMHIMIPKME()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E77 RID: 15991 RVA: 0x001375A1 File Offset: 0x001357A1
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003E78 RID: 15992 RVA: 0x001368CD File Offset: 0x00134ACD
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E79 RID: 15993 RVA: 0x001375C5 File Offset: 0x001357C5
	private void JKBMKPDGCHG()
	{
		this.SCShader = Shader.Find("x");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003E7A RID: 15994 RVA: 0x001368CD File Offset: 0x00134ACD
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E7B RID: 15995 RVA: 0x001368CD File Offset: 0x00134ACD
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E7C RID: 15996 RVA: 0x001375E9 File Offset: 0x001357E9
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E7D RID: 15997 RVA: 0x00137620 File Offset: 0x00135820
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E7E RID: 15998 RVA: 0x00137658 File Offset: 0x00135858
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 816f)
			{
				this.HBJJOCHGOPH = 1148f;
			}
			this.HEINDEMCGIK().SetFloat("ReconnectAndRejoin() disabled the offline mode. No longer offline.", this.HBJJOCHGOPH);
			this.OHKGGPFGLFD().SetFloat("CameraFilterPack/Drawing_Curve", this.Speed);
			this.HEINDEMCGIK().SetFloat("Cross", this.Red);
			this.FGENHBKMPDA().SetFloat("set", this.Green);
			this.IIJMIPBMMBF().SetFloat("yes", this.Blue);
			this.EJDPNJAEAKJ().SetVector("Fade", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1483f, 877f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E7F RID: 15999 RVA: 0x00137757 File Offset: 0x00135957
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("_Far");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003E80 RID: 16000 RVA: 0x0013777B File Offset: 0x0013597B
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)82;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E81 RID: 16001 RVA: 0x001377B2 File Offset: 0x001359B2
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find(") then the masterserver requests a disconnect!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003E82 RID: 16002 RVA: 0x001368CD File Offset: 0x00134ACD
	private void IEFMONDKKJN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E83 RID: 16003 RVA: 0x001377D8 File Offset: 0x001359D8
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
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Red);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Green);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Blue);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E84 RID: 16004 RVA: 0x001369A0 File Offset: 0x00134BA0
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003E85 RID: 16005 RVA: 0x001378D7 File Offset: 0x00135AD7
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E86 RID: 16006 RVA: 0x001368CD File Offset: 0x00134ACD
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E87 RID: 16007 RVA: 0x0013790E File Offset: 0x00135B0E
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E88 RID: 16008 RVA: 0x00137945 File Offset: 0x00135B45
	private Material OHKGGPFGLFD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E89 RID: 16009 RVA: 0x00136969 File Offset: 0x00134B69
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E8A RID: 16010 RVA: 0x0013797C File Offset: 0x00135B7C
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 591f)
			{
				this.HBJJOCHGOPH = 1906f;
			}
			this.HEINDEMCGIK().SetFloat("[NetworkManager] Join failed", this.HBJJOCHGOPH);
			this.LEIAFCPJMDP().SetFloat("skin.hit_perfect", this.Speed);
			this.OHKGGPFGLFD().SetFloat("_TimeX", this.Red);
			this.OJMHIMIPKME().SetFloat("\"\"", this.Green);
			this.FKEOGPDLBDD().SetFloat("#score", this.Blue);
			this.JLHLHKPHDFO().SetVector("OnRelease", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1167f, 49f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E8B RID: 16011 RVA: 0x00137A7C File Offset: 0x00135C7C
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 884f)
			{
				this.HBJJOCHGOPH = 1000f;
			}
			this.HNICHJCGJOC().SetFloat("player.xp", this.HBJJOCHGOPH);
			this.FKEOGPDLBDD().SetFloat("_Near", this.Speed);
			this.OIMMPLPBLBK().SetFloat("_U", this.Red);
			this.JIBOKBCPDLC().SetFloat("1087340967", this.Green);
			this.OCHJIMJNEMO().SetFloat("ConfigVersionSlider", this.Blue);
			this.NBPKMLMCHFN.SetVector("Back", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 349f, 16f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E8C RID: 16012 RVA: 0x00137B7C File Offset: 0x00135D7C
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 979f)
			{
				this.HBJJOCHGOPH = 1662f;
			}
			this.EJDPNJAEAKJ().SetFloat("_EmissionGain", this.HBJJOCHGOPH);
			this.OHKGGPFGLFD().SetFloat(".save", this.Speed);
			this.DKNJGHFLAIF().SetFloat(". Not Destroying GameObject or PhotonViews!", this.Red);
			this.OIMMPLPBLBK().SetFloat("_MainTex2", this.Green);
			this.LELKBCALFCF().SetFloat("_Saturation", this.Blue);
			this.JLHLHKPHDFO().SetVector("SetPosition", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 408f, 56f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OHKGGPFGLFD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E8D RID: 16013 RVA: 0x00137C7B File Offset: 0x00135E7B
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E8E RID: 16014 RVA: 0x00137CB2 File Offset: 0x00135EB2
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E8F RID: 16015 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06003E90 RID: 16016 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x06003E91 RID: 16017 RVA: 0x00137CEC File Offset: 0x00135EEC
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 270f)
			{
				this.HBJJOCHGOPH = 1812f;
			}
			this.JIBOKBCPDLC().SetFloat("_Size", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetFloat("Set Object Rotation", this.Speed);
			this.IIJMIPBMMBF().SetFloat("Player", this.Red);
			this.LMLENGFLEBD().SetFloat(" not exist", this.Green);
			this.NBPKMLMCHFN.SetFloat("UI/Particles/Hidden", this.Blue);
			this.OCHJIMJNEMO().SetVector("FinalScoreSmallText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1923f, 677f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E92 RID: 16018 RVA: 0x00136DD7 File Offset: 0x00134FD7
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E93 RID: 16019 RVA: 0x00137DEB File Offset: 0x00135FEB
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Hypno");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003E94 RID: 16020 RVA: 0x00137E10 File Offset: 0x00136010
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1155f)
			{
				this.HBJJOCHGOPH = 183f;
			}
			this.JIBOKBCPDLC().SetFloat("mapselector.orderby", this.HBJJOCHGOPH);
			this.FGENHBKMPDA().SetFloat("red", this.Speed);
			this.JIBOKBCPDLC().SetFloat("Set Particle Size", this.Red);
			this.EJDPNJAEAKJ().SetFloat("_ScreenResolution", this.Green);
			this.FKEOGPDLBDD().SetFloat("CameraFilterPack/Blend2Camera_HardLight", this.Blue);
			this.FOOCJIDNGBB().SetVector("This might be a misconfiguration in the game server config. You need to edit it to a (public) address.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 97f, 1467f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003E95 RID: 16021 RVA: 0x001368CD File Offset: 0x00134ACD
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E96 RID: 16022 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06003E97 RID: 16023 RVA: 0x00137F0F File Offset: 0x0013610F
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E98 RID: 16024 RVA: 0x00137F46 File Offset: 0x00136146
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)105;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E99 RID: 16025 RVA: 0x001368CD File Offset: 0x00134ACD
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E9A RID: 16026 RVA: 0x00137F7D File Offset: 0x0013617D
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003E9B RID: 16027 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x06003E9C RID: 16028 RVA: 0x00137FB4 File Offset: 0x001361B4
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find(" cannot be used as a 3D LUT.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003E9D RID: 16029 RVA: 0x00137FD8 File Offset: 0x001361D8
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003E9E RID: 16030 RVA: 0x001368CD File Offset: 0x00134ACD
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003E9F RID: 16031 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x06003EA0 RID: 16032 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06003EA1 RID: 16033 RVA: 0x001368CD File Offset: 0x00134ACD
	private void AMHEJBMLFNM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003EA2 RID: 16034 RVA: 0x001368CD File Offset: 0x00134ACD
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003EA3 RID: 16035 RVA: 0x001368CD File Offset: 0x00134ACD
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003EA4 RID: 16036 RVA: 0x001368CD File Offset: 0x00134ACD
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003EA5 RID: 16037 RVA: 0x00137FFC File Offset: 0x001361FC
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1667f)
			{
				this.HBJJOCHGOPH = 113f;
			}
			this.OCHJIMJNEMO().SetFloat("CurrentTimeLabel", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("\n", this.Speed);
			this.KEMJNOMIPHN().SetFloat("Bad parameters for init! Use \"init\" or \"init <savename>\"", this.Red);
			this.EJDPNJAEAKJ().SetFloat("randomdrop", this.Green);
			this.BAGICADFBAB().SetFloat("_TimeX", this.Blue);
			this.LELKBCALFCF().SetVector("_ExtraLight", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 268f, 129f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003EA7 RID: 16039 RVA: 0x00138130 File Offset: 0x00136330
	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1406f)
			{
				this.HBJJOCHGOPH = 661f;
			}
			this.OHKGGPFGLFD().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.FKEOGPDLBDD().SetFloat("[EditorEvent] Exception: ", this.Speed);
			this.JIBOKBCPDLC().SetFloat("/", this.Red);
			this.HCGJCMDJPGD().SetFloat("_FarCamera", this.Green);
			this.JIBOKBCPDLC().SetFloat("grid", this.Blue);
			this.HNICHJCGJOC().SetVector("Error: Someone else(", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1112f, 1183f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003EA8 RID: 16040 RVA: 0x0013822F File Offset: 0x0013642F
	private void LGHCJCFHEMF()
	{
		this.SCShader = Shader.Find("SetSunInput");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003EA9 RID: 16041 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06003EAA RID: 16042 RVA: 0x001368CD File Offset: 0x00134ACD
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003EAB RID: 16043 RVA: 0x00138253 File Offset: 0x00136453
	private Material FOOCJIDNGBB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003EAC RID: 16044 RVA: 0x0013828C File Offset: 0x0013648C
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 928f)
			{
				this.HBJJOCHGOPH = 1618f;
			}
			this.LELKBCALFCF().SetFloat("Anomaly_With_Obj", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat(",", this.Speed);
			this.MMOODGIODPC().SetFloat("runas", this.Red);
			this.HEINDEMCGIK().SetFloat("_Vibrance", this.Green);
			this.HCGJCMDJPGD().SetFloat("[ResourcesManager] Load image error: ", this.Blue);
			this.JLHLHKPHDFO().SetVector("The directory was created successfully at ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 397f, 33f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003EAD RID: 16045 RVA: 0x0013838B File Offset: 0x0013658B
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x040006B9 RID: 1721
	public Shader SCShader;

	// Token: 0x040006BA RID: 1722
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040006BB RID: 1723
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040006BC RID: 1724
	private Material BJFKDHHMLJH;

	// Token: 0x040006BD RID: 1725
	[Range(0f, 1f)]
	public float Speed = 1f;

	// Token: 0x040006BE RID: 1726
	[Range(-2f, 2f)]
	public float Red;

	// Token: 0x040006BF RID: 1727
	[Range(-2f, 2f)]
	public float Green = 1f;

	// Token: 0x040006C0 RID: 1728
	[Range(-2f, 2f)]
	public float Blue = 1f;
}
