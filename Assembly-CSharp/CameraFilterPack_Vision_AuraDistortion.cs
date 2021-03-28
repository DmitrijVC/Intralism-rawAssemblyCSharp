using System;
using UnityEngine;

// Token: 0x02000130 RID: 304
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Vision/AuraDistortion")]
public class CameraFilterPack_Vision_AuraDistortion : MonoBehaviour
{
	// Token: 0x06006017 RID: 24599 RVA: 0x001D4284 File Offset: 0x001D2484
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)110;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006018 RID: 24600 RVA: 0x001D42BC File Offset: 0x001D24BC
	private void AOGCKKLFGPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1298f)
			{
				this.HBJJOCHGOPH = 1647f;
			}
			this.BKKJJJGADLM().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.OHKGGPFGLFD().SetFloat("ViewMenu", this.Twist);
			this.EOCCJGIGEGJ().SetColor("#join", this.Color);
			this.EJDPNJAEAKJ().SetFloat("DPADHOR", this.PosX);
			this.MJJIEHANFJA().SetFloat("LogStats", this.PosY);
			this.ADBKPGFMNKO().SetFloat("_ColorRGB", this.Speed);
			this.ILKALHDJBFE().SetVector(".lastCheckpoint.time", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 913f, 1624f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006019 RID: 24601 RVA: 0x001D43D4 File Offset: 0x001D25D4
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1133f)
			{
				this.HBJJOCHGOPH = 1474f;
			}
			this.MFHPKGICPIO().SetFloat("End index must in an integer.", this.HBJJOCHGOPH);
			this.HKIMAANBGMJ().SetFloat("CameraFilterPack/Blend2Camera_Hue", this.Twist);
			this.LDNADDJMIPK().SetColor(": ", this.Color);
			this.LEIAFCPJMDP().SetFloat("_TimeX", this.PosX);
			this.IOHHLNAPGMA().SetFloat("_TimeX", this.PosY);
			this.IOHHLNAPGMA().SetFloat("NEW_ACHIEVEMENT_1_", this.Speed);
			this.IKBJACCLPCL().SetVector("Destroying GO as global. ID: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1556f, 545f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600601A RID: 24602 RVA: 0x001D44E9 File Offset: 0x001D26E9
	private Material JJNHPMLMJIH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600601B RID: 24603 RVA: 0x001D4520 File Offset: 0x001D2720
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1998f)
			{
				this.HBJJOCHGOPH = 1936f;
			}
			this.FOOCJIDNGBB().SetFloat("_ToneCurve", this.HBJJOCHGOPH);
			this.JJNHPMLMJIH().SetFloat("_Far", this.Twist);
			this.LEIAFCPJMDP().SetColor("_BorderSize", this.Color);
			this.IOHHLNAPGMA().SetFloat("gameVolume", this.PosX);
			this.NDMPCDHADMJ().SetFloat("_SearchTex", this.PosY);
			this.ILKALHDJBFE().SetFloat("Joystick1Button2", this.Speed);
			this.ADBKPGFMNKO().SetVector(" - StoreAuthURLResponse] - ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1358f, 393f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600601C RID: 24604 RVA: 0x0002523B File Offset: 0x0002343B
	private void EIDKCANPHJE()
	{
	}

	// Token: 0x0600601D RID: 24605 RVA: 0x001D4635 File Offset: 0x001D2835
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600601E RID: 24606 RVA: 0x001D466C File Offset: 0x001D286C
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600601F RID: 24607 RVA: 0x001D46A3 File Offset: 0x001D28A3
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006020 RID: 24608 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006021 RID: 24609 RVA: 0x001D46F7 File Offset: 0x001D28F7
	private void MEBPBNLBECA()
	{
		this.SCShader = Shader.Find("menu.relaxinfo");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006022 RID: 24610 RVA: 0x001D471B File Offset: 0x001D291B
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006023 RID: 24611 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006024 RID: 24612 RVA: 0x001D4752 File Offset: 0x001D2952
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006025 RID: 24613 RVA: 0x001D478C File Offset: 0x001D298C
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

	// Token: 0x06006026 RID: 24614 RVA: 0x001D48A1 File Offset: 0x001D2AA1
	private Material EGOGECOEONM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006027 RID: 24615 RVA: 0x001D48D8 File Offset: 0x001D2AD8
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006028 RID: 24616 RVA: 0x001D490F File Offset: 0x001D2B0F
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006029 RID: 24617 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600602A RID: 24618 RVA: 0x001D4946 File Offset: 0x001D2B46
	private void AIBNKIDADPI()
	{
		this.SCShader = Shader.Find("isVisible");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600602B RID: 24619 RVA: 0x001D44E9 File Offset: 0x001D26E9
	private Material ILKALHDJBFE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600602C RID: 24620 RVA: 0x001D496A File Offset: 0x001D2B6A
	private Material IOHHLNAPGMA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600602D RID: 24621 RVA: 0x001D49A4 File Offset: 0x001D2BA4
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1384f)
			{
				this.HBJJOCHGOPH = 874f;
			}
			this.BAGICADFBAB().SetFloat("InfoCanvas", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("_VignetteColor", this.Twist);
			this.OIBHFCLJKDB().SetColor("_Value3", this.Color);
			this.EBJKJPAIAAM().SetFloat("STICKRHOR", this.PosX);
			this.MFHPKGICPIO().SetFloat("CameraFilterPack/Gradients_ElectricGradient", this.PosY);
			this.EJDPNJAEAKJ().SetFloat("BitsData", this.Speed);
			this.GCDFNHMJMIP().SetVector(".highscore", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 492f, 1331f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600602E RID: 24622 RVA: 0x001D4AB9 File Offset: 0x001D2CB9
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600602F RID: 24623 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void ALJEADNKJPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006030 RID: 24624 RVA: 0x001D4AF0 File Offset: 0x001D2CF0
	private Material OIBHFCLJKDB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006031 RID: 24625 RVA: 0x001D4B27 File Offset: 0x001D2D27
	private void MKOMIDCPCDC()
	{
		this.SCShader = Shader.Find("UI Extensions/UISoftAdditive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006032 RID: 24626 RVA: 0x001D4B4B File Offset: 0x001D2D4B
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("LB");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006033 RID: 24627 RVA: 0x001D4B6F File Offset: 0x001D2D6F
	private void NMAOGOMAING()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_Tiles");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006034 RID: 24628 RVA: 0x001D4B93 File Offset: 0x001D2D93
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("UseFinalGlassColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006035 RID: 24629 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006036 RID: 24630 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006038 RID: 24632 RVA: 0x001D4C1C File Offset: 0x001D2E1C
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("ItemNameBGImage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006039 RID: 24633 RVA: 0x001D4C40 File Offset: 0x001D2E40
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600603A RID: 24634 RVA: 0x001D4C77 File Offset: 0x001D2E77
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-77);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600603B RID: 24635 RVA: 0x001D4CAE File Offset: 0x001D2EAE
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600603C RID: 24636 RVA: 0x001D4CE8 File Offset: 0x001D2EE8
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 721f)
			{
				this.HBJJOCHGOPH = 1055f;
			}
			this.DONENAMLFLF().SetFloat("ERROR You have missing MonoBehaviours on your gameobjects!", this.HBJJOCHGOPH);
			this.MJJIEHANFJA().SetFloat("#mapalreadyexistupdate", this.Twist);
			this.ADBKPGFMNKO().SetColor("SetEnvSpriteImage", this.Color);
			this.EJDPNJAEAKJ().SetFloat("_Green_G", this.PosX);
			this.MJJIEHANFJA().SetFloat("menu.selectedlevelid", this.PosY);
			this.LEIAFCPJMDP().SetFloat("[DiscordController] Join ({0})", this.Speed);
			this.EJDPNJAEAKJ().SetVector("SetCrosshairEmission", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1174f, 391f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600603D RID: 24637 RVA: 0x001D4E00 File Offset: 0x001D3000
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 435f)
			{
				this.HBJJOCHGOPH = 369f;
			}
			this.FOOCJIDNGBB().SetFloat("_Bullet_4", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetFloat("_NeighborMaxTex", this.Twist);
			this.ADBKPGFMNKO().SetColor("RecieveChatMessage", this.Color);
			this.JJNHPMLMJIH().SetFloat("CameraFilterPack_Blizzard1", this.PosX);
			this.CBCNOEIALHB().SetFloat("CameraFilterPack/Drawing_Comics", this.PosY);
			this.EGOGECOEONM().SetFloat("GlassColor", this.Speed);
			this.EGOGECOEONM().SetVector("Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1717f, 1313f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JJNHPMLMJIH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600603E RID: 24638 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x0600603F RID: 24639 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06006040 RID: 24640 RVA: 0x001D4F15 File Offset: 0x001D3115
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("HighScaleShot");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006041 RID: 24641 RVA: 0x001D4F39 File Offset: 0x001D3139
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006042 RID: 24642 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06006043 RID: 24643 RVA: 0x001D4F5D File Offset: 0x001D315D
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("CameraFilterPack/OldFilm_Cutting2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006044 RID: 24644 RVA: 0x001D4F81 File Offset: 0x001D3181
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("MusicFileSelector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006045 RID: 24645 RVA: 0x001D4FA5 File Offset: 0x001D31A5
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006046 RID: 24646 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOAGAKFBIGD()
	{
	}

	// Token: 0x06006047 RID: 24647 RVA: 0x0002523B File Offset: 0x0002343B
	private void APKNAPHOFHC()
	{
	}

	// Token: 0x06006048 RID: 24648 RVA: 0x001D4FDC File Offset: 0x001D31DC
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006049 RID: 24649 RVA: 0x001D5014 File Offset: 0x001D3214
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 781f)
			{
				this.HBJJOCHGOPH = 618f;
			}
			this.NBPKMLMCHFN.SetFloat("win", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("_Value2", this.Twist);
			this.BKKJJJGADLM().SetColor("MenuScene", this.Color);
			this.EGOGECOEONM().SetFloat("HPToggle", this.PosX);
			this.EOCCJGIGEGJ().SetFloat("note.2", this.PosY);
			this.HHIFMIPPMPF().SetFloat("_Value3", this.Speed);
			this.HEHKGPKLAKK().SetVector("_Value5", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 198f, 696f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600604A RID: 24650 RVA: 0x001D512C File Offset: 0x001D332C
	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 258f)
			{
				this.HBJJOCHGOPH = 538f;
			}
			this.IKBJACCLPCL().SetFloat("anonymous", this.HBJJOCHGOPH);
			this.HKIMAANBGMJ().SetFloat("_ScreenResolution", this.Twist);
			this.HEHKGPKLAKK().SetColor("Parent ID", this.Color);
			this.FGENHBKMPDA().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", this.PosX);
			this.HKGAONMOBMH().SetFloat("[ResourcesManager] Unloading data resources", this.PosY);
			this.NLFJGMBCICG().SetFloat("icon", this.Speed);
			this.HKIMAANBGMJ().SetVector("id", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1717f, 1220f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIBHFCLJKDB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600604B RID: 24651 RVA: 0x001D5241 File Offset: 0x001D3441
	private void DKGBFNCOAEO()
	{
		this.SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600604C RID: 24652 RVA: 0x001D5265 File Offset: 0x001D3465
	private void LFBGJIIECLD()
	{
		this.SCShader = Shader.Find("UI Extensions/SoftMaskShader");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600604D RID: 24653 RVA: 0x0002523B File Offset: 0x0002343B
	private void MOMHHBKAGKG()
	{
	}

	// Token: 0x0600604E RID: 24654 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600604F RID: 24655 RVA: 0x001D5289 File Offset: 0x001D3489
	private void CEAGPJBGBMH()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_ARCADE");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006050 RID: 24656 RVA: 0x001D52B0 File Offset: 0x001D34B0
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 230f)
			{
				this.HBJJOCHGOPH = 1581f;
			}
			this.MJJIEHANFJA().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.OIBHFCLJKDB().SetFloat("Drop_Near", this.Twist);
			this.DONENAMLFLF().SetColor("Network destroy Instantiated GO: ", this.Color);
			this.BKKJJJGADLM().SetFloat("_TimeX", this.PosX);
			this.HKHBBBFLGJH().SetFloat("BadgeText", this.PosY);
			this.FOOCJIDNGBB().SetFloat("DPADHOR", this.Speed);
			this.ADBKPGFMNKO().SetVector(".lastCheckpoint.isMapCompleted", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 137f, 1537f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006051 RID: 24657 RVA: 0x001D53C8 File Offset: 0x001D35C8
	private void AIKDNGCEDAB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1646f)
			{
				this.HBJJOCHGOPH = 1753f;
			}
			this.FOOCJIDNGBB().SetFloat(".g", this.HBJJOCHGOPH);
			this.EBJKJPAIAAM().SetFloat(".icon", this.Twist);
			this.IOHHLNAPGMA().SetColor("USE_PREDICATION", this.Color);
			this.MFHPKGICPIO().SetFloat("Loading maps", this.PosX);
			this.HKHBBBFLGJH().SetFloat("_Far", this.PosY);
			this.HEHKGPKLAKK().SetFloat("Tab2Content", this.Speed);
			this.LPDOGGFOBDH().SetVector("???", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1991f, 252f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006052 RID: 24658 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006053 RID: 24659 RVA: 0x001D54DD File Offset: 0x001D36DD
	private Material MJJIEHANFJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006054 RID: 24660 RVA: 0x001D5514 File Offset: 0x001D3714
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006055 RID: 24661 RVA: 0x001D5538 File Offset: 0x001D3738
	private void DPLLKHHLDBB()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blur_Movie");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006056 RID: 24662 RVA: 0x001D555C File Offset: 0x001D375C
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006057 RID: 24663 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006058 RID: 24664 RVA: 0x001D5593 File Offset: 0x001D3793
	private Material HKIMAANBGMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)105;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006059 RID: 24665 RVA: 0x001D55CC File Offset: 0x001D37CC
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1176f)
			{
				this.HBJJOCHGOPH = 931f;
			}
			this.KDMBOKLMADJ().SetFloat("tagElement", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("CameraFilterPack/Blend2Camera_Lighten", this.Twist);
			this.LEHDPILKKND().SetColor("_TimeX", this.Color);
			this.HKIMAANBGMJ().SetFloat("_FixDistance", this.PosX);
			this.LDNADDJMIPK().SetFloat("config.txt", this.PosY);
			this.KHCLIAMBBNC().SetFloat("note.4", this.Speed);
			this.DONENAMLFLF().SetVector(".completed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 564f, 481f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600605A RID: 24666 RVA: 0x001D56E1 File Offset: 0x001D38E1
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("skin.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600605B RID: 24667 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600605C RID: 24668 RVA: 0x001D5705 File Offset: 0x001D3905
	private void PEDHPEMNHBF()
	{
		this.SCShader = Shader.Find("StartButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600605D RID: 24669 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600605E RID: 24670 RVA: 0x001D5729 File Offset: 0x001D3929
	private void JDKHBGDEONK()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600605F RID: 24671 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMNOHLNANIP()
	{
	}

	// Token: 0x06006060 RID: 24672 RVA: 0x001D574D File Offset: 0x001D394D
	private Material OHKGGPFGLFD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006061 RID: 24673 RVA: 0x001D5784 File Offset: 0x001D3984
	private void ALNNIDLFILB()
	{
		this.SCShader = Shader.Find("LevelEditor/CustomEventEditor-Text");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006062 RID: 24674 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006063 RID: 24675 RVA: 0x001D57A8 File Offset: 0x001D39A8
	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 163f)
			{
				this.HBJJOCHGOPH = 1711f;
			}
			this.BKKJJJGADLM().SetFloat("Failed to InstantiateSceneObject prefab: ", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("settings.volume.game", this.Twist);
			this.MFHPKGICPIO().SetColor("_Blue_G", this.Color);
			this.FGENHBKMPDA().SetFloat("_Value3", this.PosX);
			this.ILKALHDJBFE().SetFloat("\" for viewID ", this.PosY);
			this.HEHKGPKLAKK().SetFloat("_Value2", this.Speed);
			this.GCDFNHMJMIP().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 397f, 920f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006064 RID: 24676 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBFJAOINHMK()
	{
	}

	// Token: 0x06006065 RID: 24677 RVA: 0x001D58BD File Offset: 0x001D3ABD
	private Material LEIAFCPJMDP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006066 RID: 24678 RVA: 0x0002523B File Offset: 0x0002343B
	private void HCIPECAOGIA()
	{
	}

	// Token: 0x06006067 RID: 24679 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNIINHHCAFE()
	{
	}

	// Token: 0x06006068 RID: 24680 RVA: 0x001D58F4 File Offset: 0x001D3AF4
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("Items/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006069 RID: 24681 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600606A RID: 24682 RVA: 0x001D5918 File Offset: 0x001D3B18
	private void OGJJDKENBNC()
	{
		this.SCShader = Shader.Find("file://");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600606B RID: 24683 RVA: 0x0002523B File Offset: 0x0002343B
	private void MBLDJEFBLFL()
	{
	}

	// Token: 0x0600606C RID: 24684 RVA: 0x001D593C File Offset: 0x001D3B3C
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600606D RID: 24685 RVA: 0x001D5974 File Offset: 0x001D3B74
	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1152f)
			{
				this.HBJJOCHGOPH = 74f;
			}
			this.KGOLDDBHIFN().SetFloat("settings.disablestoryboard", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("CameraFilterPack/Blend2Camera_HardLight", this.Twist);
			this.FOOCJIDNGBB().SetColor("_Blend", this.Color);
			this.OIBHFCLJKDB().SetFloat(" ", this.PosX);
			this.ILKALHDJBFE().SetFloat("Texture2", this.PosY);
			this.NBPKMLMCHFN.SetFloat("OneHand", this.Speed);
			this.MFHPKGICPIO().SetVector("No Name", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1874f, 322f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600606E RID: 24686 RVA: 0x001D4C40 File Offset: 0x001D2E40
	private Material LEHDPILKKND()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600606F RID: 24687 RVA: 0x001D5A89 File Offset: 0x001D3C89
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("#close");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006070 RID: 24688 RVA: 0x001D5AB0 File Offset: 0x001D3CB0
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1959f)
			{
				this.HBJJOCHGOPH = 209f;
			}
			this.MFHPKGICPIO().SetFloat("GlassesColor", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("SpectateButton", this.Twist);
			this.EBJKJPAIAAM().SetColor("VisionBlur", this.Color);
			this.LPDOGGFOBDH().SetFloat("#pleasewait", this.PosX);
			this.FOOCJIDNGBB().SetFloat("image", this.PosY);
			this.LEHDPILKKND().SetFloat("No Name", this.Speed);
			this.LDNADDJMIPK().SetVector("\n", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1184f, 281f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006071 RID: 24689 RVA: 0x001D5BC8 File Offset: 0x001D3DC8
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1428f)
			{
				this.HBJJOCHGOPH = 189f;
			}
			this.ADBKPGFMNKO().SetFloat("?", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("mode", this.Twist);
			this.HKIMAANBGMJ().SetColor("Unable to get a reward! Try again?", this.Color);
			this.EJDPNJAEAKJ().SetFloat("_RotationMatrix", this.PosX);
			this.HKIMAANBGMJ().SetFloat("Can't execute Disconnect() while not connected. Nothing changed. State: {0}", this.PosY);
			this.HKGAONMOBMH().SetFloat("_Blue_R", this.Speed);
			this.LEHDPILKKND().SetVector("GlassColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 321f, 1593f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CBCNOEIALHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006072 RID: 24690 RVA: 0x001D5CDD File Offset: 0x001D3EDD
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("event");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006073 RID: 24691 RVA: 0x001D5D01 File Offset: 0x001D3F01
	private void PMPKMGKAAJH()
	{
		this.SCShader = Shader.Find("ConnectToBestCloudServer() failed. Can only connect while in state 'Disconnected'. Current state: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006074 RID: 24692 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void DKPBBJINKMG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006075 RID: 24693 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void OMFBGCMHNBM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006076 RID: 24694 RVA: 0x001D5D25 File Offset: 0x001D3F25
	private Material FOOCJIDNGBB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006077 RID: 24695 RVA: 0x001D5D5C File Offset: 0x001D3F5C
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("ItemsCountText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006078 RID: 24696 RVA: 0x0002523B File Offset: 0x0002343B
	private void IAJKLKJJKEJ()
	{
	}

	// Token: 0x06006079 RID: 24697 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x0600607A RID: 24698 RVA: 0x001D5D80 File Offset: 0x001D3F80
	private void KLCAJPOCMPF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1431f)
			{
				this.HBJJOCHGOPH = 1986f;
			}
			this.ADBKPGFMNKO().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("CameraFilterPack/Blend2Camera_Exclusion", this.Twist);
			this.HEINDEMCGIK().SetColor("ConnectToMaster() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", this.Color);
			this.LPDOGGFOBDH().SetFloat("yesterday", this.PosX);
			this.MFHPKGICPIO().SetFloat("_Value4", this.PosY);
			this.JFDGLLEOPGB().SetFloat("_Near", this.Speed);
			this.LDNADDJMIPK().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 640f, 1569f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600607B RID: 24699 RVA: 0x001D5E95 File Offset: 0x001D4095
	private void LIBGAKMKHJJ()
	{
		this.SCShader = Shader.Find(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600607C RID: 24700 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void GEHINELAGBI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600607D RID: 24701 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x0600607E RID: 24702 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJNJIHCLODK()
	{
	}

	// Token: 0x0600607F RID: 24703 RVA: 0x001D5EB9 File Offset: 0x001D40B9
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006080 RID: 24704 RVA: 0x001D5EF0 File Offset: 0x001D40F0
	private void AEOLJEIDMDB()
	{
		this.SCShader = Shader.Find("[PlayerBase] Loaded spawner data");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006081 RID: 24705 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006082 RID: 24706 RVA: 0x001D5F14 File Offset: 0x001D4114
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 77f)
			{
				this.HBJJOCHGOPH = 1170f;
			}
			this.LEHDPILKKND().SetFloat("_BlurVector", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("_TimeX", this.Twist);
			this.IOHHLNAPGMA().SetColor("skin.hit_perfect", this.Color);
			this.NLFJGMBCICG().SetFloat("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ", this.PosX);
			this.EOCCJGIGEGJ().SetFloat("PRESS A KEY", this.PosY);
			this.IOHHLNAPGMA().SetFloat("Joystick1Button9", this.Speed);
			this.CBCNOEIALHB().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1519f, 358f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006083 RID: 24707 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006084 RID: 24708 RVA: 0x001D6029 File Offset: 0x001D4229
	private void MMPHNFPPEHO()
	{
		this.SCShader = Shader.Find(" url: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006085 RID: 24709 RVA: 0x001D604D File Offset: 0x001D424D
	private void COOHIILCOCO()
	{
		this.SCShader = Shader.Find(".");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006086 RID: 24710 RVA: 0x001D6071 File Offset: 0x001D4271
	private Material EBJKJPAIAAM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006087 RID: 24711 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006088 RID: 24712 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006089 RID: 24713 RVA: 0x001D60A8 File Offset: 0x001D42A8
	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1125f)
			{
				this.HBJJOCHGOPH = 1068f;
			}
			this.FGENHBKMPDA().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("true", this.Twist);
			this.EBJKJPAIAAM().SetColor("[DiscordController] Responding yes to Ask to Join request", this.Color);
			this.MFHPKGICPIO().SetFloat("/", this.PosX);
			this.NLFJGMBCICG().SetFloat("EventTimeInputField", this.PosY);
			this.MJJIEHANFJA().SetFloat("_Saturation", this.Speed);
			this.HKGAONMOBMH().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 637f, 159f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600608A RID: 24714 RVA: 0x001D61BD File Offset: 0x001D43BD
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find("float,0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600608B RID: 24715 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600608C RID: 24716 RVA: 0x001D61E4 File Offset: 0x001D43E4
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 633f)
			{
				this.HBJJOCHGOPH = 1236f;
			}
			this.CBCNOEIALHB().SetFloat("_ReflectionTexture1", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("#rt", this.Twist);
			this.BKKJJJGADLM().SetColor("No Camera attached!", this.Color);
			this.ADBKPGFMNKO().SetFloat("_Value2", this.PosX);
			this.GCDFNHMJMIP().SetFloat("_TimeX", this.PosY);
			this.HEHKGPKLAKK().SetFloat("_Value4", this.Speed);
			this.DONENAMLFLF().SetVector("JoinRoom failed. A roomname is required. If you don't know one, how will you join?", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1417f, 1451f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EBJKJPAIAAM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600608D RID: 24717 RVA: 0x001D62F9 File Offset: 0x001D44F9
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Darken");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600608E RID: 24718 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600608F RID: 24719 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006090 RID: 24720 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006091 RID: 24721 RVA: 0x001D6320 File Offset: 0x001D4520
	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 387f)
			{
				this.HBJJOCHGOPH = 615f;
			}
			this.NBPKMLMCHFN.SetFloat("Set Sun Input", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("cameramovements:", this.Twist);
			this.JJNHPMLMJIH().SetColor("menu.enableselectormusic", this.Color);
			this.EBJKJPAIAAM().SetFloat("_DepthLevel", this.PosX);
			this.HHIFMIPPMPF().SetFloat("#score", this.PosY);
			this.KGOLDDBHIFN().SetFloat("SupportLogger OnCreatedRoom(", this.Speed);
			this.BAGICADFBAB().SetVector("CameraFilterPack/Lut_Simple", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1216f, 1256f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006092 RID: 24722 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006093 RID: 24723 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x06006094 RID: 24724 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void NNPBKKBFDHH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006095 RID: 24725 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006096 RID: 24726 RVA: 0x001D6438 File Offset: 0x001D4638
	private void IGJPPFJOFKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 309f)
			{
				this.HBJJOCHGOPH = 386f;
			}
			this.KGOLDDBHIFN().SetFloat("ResetButton", this.HBJJOCHGOPH);
			this.KDMBOKLMADJ().SetFloat("_FixDistance", this.Twist);
			this.DONENAMLFLF().SetColor("_MidGrey", this.Color);
			this.MJJIEHANFJA().SetFloat("_TimeX", this.PosX);
			this.KGOLDDBHIFN().SetFloat("{0} days ago", this.PosY);
			this.MFHPKGICPIO().SetFloat(".lastCheckpoint.checkpointsUsed", this.Speed);
			this.MJJIEHANFJA().SetVector("FinalScoreSmallText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 630f, 118f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006097 RID: 24727 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006098 RID: 24728 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06006099 RID: 24729 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFMEAMBLODG()
	{
	}

	// Token: 0x0600609A RID: 24730 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600609B RID: 24731 RVA: 0x0002523B File Offset: 0x0002343B
	private void FAKGFMFAPDG()
	{
	}

	// Token: 0x0600609C RID: 24732 RVA: 0x001D654D File Offset: 0x001D474D
	private Material IKBJACCLPCL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600609D RID: 24733 RVA: 0x001D6584 File Offset: 0x001D4784
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600609E RID: 24734 RVA: 0x001D65BC File Offset: 0x001D47BC
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1870f)
			{
				this.HBJJOCHGOPH = 635f;
			}
			this.HEINDEMCGIK().SetFloat("_ToneCurveRange", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("Set Crosshair Emission", this.Twist);
			this.KDMBOKLMADJ().SetColor(".status", this.Color);
			this.EBJKJPAIAAM().SetFloat("GlassDistortion", this.PosX);
			this.KGOLDDBHIFN().SetFloat("_Value", this.PosY);
			this.NLFJGMBCICG().SetFloat("_Params", this.Speed);
			this.NLFJGMBCICG().SetVector("source", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1063f, 1739f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600609F RID: 24735 RVA: 0x001D66D1 File Offset: 0x001D48D1
	private Material BKKJJJGADLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060060A0 RID: 24736 RVA: 0x001D6708 File Offset: 0x001D4908
	private void HPPMAKHOPBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 61f)
			{
				this.HBJJOCHGOPH = 1581f;
			}
			this.IKBJACCLPCL().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("menu.selectedplaymode", this.Twist);
			this.EJDPNJAEAKJ().SetColor("levelcompleted", this.Color);
			this.HEINDEMCGIK().SetFloat(" ", this.PosX);
			this.IOHHLNAPGMA().SetFloat("settings.gamemessagesduration", this.PosY);
			this.OIBHFCLJKDB().SetFloat("_TintColor", this.Speed);
			this.FGENHBKMPDA().SetVector("DPADVER", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1203f, 1153f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060060A1 RID: 24737 RVA: 0x001D5D25 File Offset: 0x001D3F25
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060060A2 RID: 24738 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCDLIKEDMCF()
	{
	}

	// Token: 0x060060A3 RID: 24739 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x060060A4 RID: 24740 RVA: 0x001D681D File Offset: 0x001D4A1D
	private Material KHCLIAMBBNC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060060A5 RID: 24741 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void EKPLGFAEOBE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060060A6 RID: 24742 RVA: 0x001D6854 File Offset: 0x001D4A54
	private void EIMNPCMHJLJ()
	{
		this.SCShader = Shader.Find("_NoiseTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060060A7 RID: 24743 RVA: 0x001D6878 File Offset: 0x001D4A78
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060060A8 RID: 24744 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060060A9 RID: 24745 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void KMIEAGOFLBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060060AA RID: 24746 RVA: 0x001D689C File Offset: 0x001D4A9C
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find("_RgbTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060060AB RID: 24747 RVA: 0x001D68C0 File Offset: 0x001D4AC0
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060060AC RID: 24748 RVA: 0x001D4C40 File Offset: 0x001D2E40
	private Material CBCNOEIALHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060060AD RID: 24749 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void IENKPJEBMFM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060060AE RID: 24750 RVA: 0x0002523B File Offset: 0x0002343B
	private void AOLABBMIEIM()
	{
	}

	// Token: 0x060060AF RID: 24751 RVA: 0x001D68F7 File Offset: 0x001D4AF7
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Vision_AuraDistortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060060B0 RID: 24752 RVA: 0x001D691C File Offset: 0x001D4B1C
	private void GOANCMNGDLE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1550f)
			{
				this.HBJJOCHGOPH = 143f;
			}
			this.JJNHPMLMJIH().SetFloat("Fade", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("_Value4", this.Twist);
			this.HKGAONMOBMH().SetColor("Mouse Y", this.Color);
			this.IOHHLNAPGMA().SetFloat("true", this.PosX);
			this.EJDPNJAEAKJ().SetFloat("[LevelEditorScene] Exported to ", this.PosY);
			this.OIBHFCLJKDB().SetFloat("Received unknown status code: ", this.Speed);
			this.JJNHPMLMJIH().SetVector("DifficultyBG", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1616f, 972f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060060B1 RID: 24753 RVA: 0x001D46DA File Offset: 0x001D28DA
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000115 RID: 277
	// (get) Token: 0x060060B2 RID: 24754 RVA: 0x001D6A31 File Offset: 0x001D4C31
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

	// Token: 0x040009AC RID: 2476
	public Shader SCShader;

	// Token: 0x040009AD RID: 2477
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040009AE RID: 2478
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040009AF RID: 2479
	private Material BJFKDHHMLJH;

	// Token: 0x040009B0 RID: 2480
	[Range(0f, 2f)]
	public float Twist = 1f;

	// Token: 0x040009B1 RID: 2481
	[Range(-4f, 4f)]
	public float Speed = 1f;

	// Token: 0x040009B2 RID: 2482
	public Color Color = new Color(0.16f, 0.57f, 0.19f);

	// Token: 0x040009B3 RID: 2483
	[Range(-1f, 2f)]
	public float PosX = 0.5f;

	// Token: 0x040009B4 RID: 2484
	[Range(-1f, 2f)]
	public float PosY = 0.5f;
}
