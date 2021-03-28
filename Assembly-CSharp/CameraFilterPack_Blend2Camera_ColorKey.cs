using System;
using UnityEngine;

// Token: 0x0200003E RID: 62
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Chroma Key/Color Key")]
public class CameraFilterPack_Blend2Camera_ColorKey : MonoBehaviour
{
	// Token: 0x06001113 RID: 4371 RVA: 0x0007440C File Offset: 0x0007260C
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 566f)
			{
				this.HBJJOCHGOPH = 752f;
			}
			if (this.Camera2 != null)
			{
				this.EOCCJGIGEGJ().SetTexture("Set Object Position", this.JDMCFBKJHDD);
			}
			this.GCDFNHMJMIP().SetFloat("#", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("menu.selectedplaymode", this.BlendFX);
			this.HCGJCMDJPGD().SetFloat("menu.selectedlevelid", this.Adjust);
			this.MHBAIEKFBIJ().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", this.Precision);
			this.GKILCDHJFEG().SetFloat(": ", this.Luminosity);
			this.GCDFNHMJMIP().SetFloat("_PrevViewProj", this.Change_Red);
			this.HHIFMIPPMPF().SetFloat("Set Sun DirectionVector", this.Change_Green);
			this.HHIFMIPPMPF().SetFloat("maps.", this.Change_Blue);
			this.CIAFLBFJLEJ().SetColor("0,1,false", this.ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001114 RID: 4372 RVA: 0x0007455D File Offset: 0x0007275D
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001115 RID: 4373 RVA: 0x00074594 File Offset: 0x00072794
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001116 RID: 4374 RVA: 0x000745CC File Offset: 0x000727CC
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 879f)
			{
				this.HBJJOCHGOPH = 18f;
			}
			if (this.Camera2 != null)
			{
				this.IIBLJCKLGFG().SetTexture("mapselector.filter.officialsortmode", this.JDMCFBKJHDD);
			}
			this.HCGJCMDJPGD().SetFloat("CameraFilterPack/Blur_Dithering2x2", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("Anomaly_Distortion", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("{0}{1}{2}={3}", this.Adjust);
			this.EOCCJGIGEGJ().SetFloat("Set Satellite Lerp Speed", this.Precision);
			this.ABHDNGIHBKE().SetFloat("Screen Space Reflections", this.Luminosity);
			this.HHIAIGCAHDA().SetFloat("Set Sun Lerp Speed", this.Change_Red);
			this.DONENAMLFLF().SetFloat("_Red_B", this.Change_Green);
			this.FHFLKLMFHOI().SetFloat("/", this.Change_Blue);
			this.GKILCDHJFEG().SetColor("_LightIntensity", this.ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001117 RID: 4375 RVA: 0x0007471D File Offset: 0x0007291D
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001118 RID: 4376 RVA: 0x00074754 File Offset: 0x00072954
	private void KKGMKGHFELO()
	{
		this.NNCCPEBIAKH();
		this.EHJJFJCKGAJ();
	}

	// Token: 0x06001119 RID: 4377 RVA: 0x00074764 File Offset: 0x00072964
	private void FKEJGBFDCAH()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600111A RID: 4378 RVA: 0x000747C0 File Offset: 0x000729C0
	private void IMCKJCHKMKB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -91);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600111B RID: 4379 RVA: 0x00074838 File Offset: 0x00072A38
	private void CBIBDOIBJAI()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600111C RID: 4380 RVA: 0x00074894 File Offset: 0x00072A94
	private void NNFMIAFHMJM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -78);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600111D RID: 4381 RVA: 0x0007490C File Offset: 0x00072B0C
	private void EAHCLIEEJOG()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600111E RID: 4382 RVA: 0x00074968 File Offset: 0x00072B68
	private void LFBGJIIECLD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 5);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600111F RID: 4383 RVA: 0x000749DF File Offset: 0x00072BDF
	private void ABFNJCEBIKA()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06001120 RID: 4384 RVA: 0x00074A10 File Offset: 0x00072C10
	private void FLKEJJEGCFA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -109);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001121 RID: 4385 RVA: 0x00074A88 File Offset: 0x00072C88
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 693f)
			{
				this.HBJJOCHGOPH = 8f;
			}
			if (this.Camera2 != null)
			{
				this.GKILCDHJFEG().SetTexture(";", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("DisableStoryboardToggle", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("BitsData", this.BlendFX);
			this.GKILCDHJFEG().SetFloat(".", this.Adjust);
			this.ABHDNGIHBKE().SetFloat("\n", this.Precision);
			this.HHIFMIPPMPF().SetFloat("SUBMIT", this.Luminosity);
			this.CBCNOEIALHB().SetFloat("The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.", this.Change_Red);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/FX_8bits_gb", this.Change_Green);
			this.MLMKCOINOOH().SetFloat("CameraFilterPack/3D_BlackHole", this.Change_Blue);
			this.CIAFLBFJLEJ().SetColor("GlassesColor2", this.ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001122 RID: 4386 RVA: 0x00074BDC File Offset: 0x00072DDC
	private void AEDDNDHCLNN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -102);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001123 RID: 4387 RVA: 0x00074C54 File Offset: 0x00072E54
	private void OHFOLGANOLC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -34);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001124 RID: 4388 RVA: 0x00074CCB File Offset: 0x00072ECB
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001125 RID: 4389 RVA: 0x00074D04 File Offset: 0x00072F04
	private void JHJFBCFBKLD()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001126 RID: 4390 RVA: 0x00074D60 File Offset: 0x00072F60
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 440f)
			{
				this.HBJJOCHGOPH = 13f;
			}
			if (this.Camera2 != null)
			{
				this.MHBAIEKFBIJ().SetTexture("_FixDistance", this.JDMCFBKJHDD);
			}
			this.FHFLKLMFHOI().SetFloat("#8E8E8EFF", this.HBJJOCHGOPH);
			this.CBCNOEIALHB().SetFloat("Tab1Content", this.BlendFX);
			this.CIAFLBFJLEJ().SetFloat("?", this.Adjust);
			this.GKILCDHJFEG().SetFloat("_ScreenResolution", this.Precision);
			this.IIBLJCKLGFG().SetFloat("color", this.Luminosity);
			this.HHIFMIPPMPF().SetFloat(":\n", this.Change_Red);
			this.CIAFLBFJLEJ().SetFloat("_MainTex", this.Change_Green);
			this.HHIAIGCAHDA().SetFloat("_SmoothEnd", this.Change_Blue);
			this.GCDFNHMJMIP().SetColor(" could not be executed (yet). Wait for state JoinedLobby or ConnectedToMaster and their callbacks before calling operations. WebRPCs need a server-side configuration. Enum OperationCode helps identify the operation.", this.ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001127 RID: 4391 RVA: 0x00074EB4 File Offset: 0x000730B4
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 662f)
			{
				this.HBJJOCHGOPH = 1176f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("_ScreenResolution", this.JDMCFBKJHDD);
			}
			this.FHFLKLMFHOI().SetFloat("#ok", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("_Value", this.BlendFX);
			this.GCDFNHMJMIP().SetFloat(".lastCheckpoint.powerupsScore", this.Adjust);
			this.IIBLJCKLGFG().SetFloat("0.00", this.Precision);
			this.MLMKCOINOOH().SetFloat("connect", this.Luminosity);
			this.MHBAIEKFBIJ().SetFloat("end", this.Change_Red);
			this.MLMKCOINOOH().SetFloat("settings.crosshairopacity", this.Change_Green);
			this.MLMKCOINOOH().SetFloat("Left ", this.Change_Blue);
			this.ABHDNGIHBKE().SetColor("Image effects aren't supported on this device ({0})", this.ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001128 RID: 4392 RVA: 0x00075008 File Offset: 0x00073208
	private void FMFNILJIEIA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -45);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001129 RID: 4393 RVA: 0x00075080 File Offset: 0x00073280
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1227f)
			{
				this.HBJJOCHGOPH = 1440f;
			}
			if (this.Camera2 != null)
			{
				this.HKGAONMOBMH().SetTexture("X", this.JDMCFBKJHDD);
			}
			this.CIAFLBFJLEJ().SetFloat("Editor/", this.HBJJOCHGOPH);
			this.MLMKCOINOOH().SetFloat("Hidden/Fast Approximate Anti-aliasing", this.BlendFX);
			this.LPDOGGFOBDH().SetFloat("_Value4", this.Adjust);
			this.HCGJCMDJPGD().SetFloat("Joystick1Button12", this.Precision);
			this.LNLKMDPHDCC().SetFloat("/", this.Luminosity);
			this.HCGJCMDJPGD().SetFloat("_Level", this.Change_Red);
			this.HKGAONMOBMH().SetFloat("_TimeX", this.Change_Green);
			this.HHIAIGCAHDA().SetFloat("<color=white>", this.Change_Blue);
			this.MLMKCOINOOH().SetColor("plogs", this.ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600112A RID: 4394 RVA: 0x000751D4 File Offset: 0x000733D4
	private void BDBJEDIOKBN()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600112B RID: 4395 RVA: 0x0007522F File Offset: 0x0007342F
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600112C RID: 4396 RVA: 0x00075266 File Offset: 0x00073466
	private void JOLKPPEBILA()
	{
		this.MMPHNFPPEHO();
		this.ABFNJCEBIKA();
	}

	// Token: 0x0600112D RID: 4397 RVA: 0x00075274 File Offset: 0x00073474
	private void HIFPDKKBDHJ()
	{
		this.HAIAHJPCPAG();
		this.KCDBBPKIFNJ();
	}

	// Token: 0x0600112E RID: 4398 RVA: 0x000749DF File Offset: 0x00072BDF
	private void PBEPCAPAKLG()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x0600112F RID: 4399 RVA: 0x00075284 File Offset: 0x00073484
	private void IGPCNCJIEOJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -116);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001130 RID: 4400 RVA: 0x000749DF File Offset: 0x00072BDF
	private void DGCGGKMNPLD()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06001131 RID: 4401 RVA: 0x000752FC File Offset: 0x000734FC
	private void EKPLGFAEOBE()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001132 RID: 4402 RVA: 0x00075358 File Offset: 0x00073558
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1252f)
			{
				this.HBJJOCHGOPH = 272f;
			}
			if (this.Camera2 != null)
			{
				this.DONENAMLFLF().SetTexture("StartButton", this.JDMCFBKJHDD);
			}
			this.GCDFNHMJMIP().SetFloat("CameraFilterPack/Broken_Screen", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("_Red_B", this.BlendFX);
			this.DONENAMLFLF().SetFloat("inventory.selected.", this.Adjust);
			this.HCGJCMDJPGD().SetFloat("_Value4", this.Precision);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.Luminosity);
			this.HHIAIGCAHDA().SetFloat("mapselector.orderby", this.Change_Red);
			this.HCGJCMDJPGD().SetFloat("open", this.Change_Green);
			this.LPDOGGFOBDH().SetFloat("-1", this.Change_Blue);
			this.GCDFNHMJMIP().SetColor("EditMenu", this.ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001133 RID: 4403 RVA: 0x000754AC File Offset: 0x000736AC
	private void LOMDIOLNFHI()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001134 RID: 4404 RVA: 0x000749DF File Offset: 0x00072BDF
	private void ONKDMMJPEMN()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06001135 RID: 4405 RVA: 0x000749DF File Offset: 0x00072BDF
	private void CPCDFMMLHLO()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06001136 RID: 4406 RVA: 0x00075508 File Offset: 0x00073708
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 244f)
			{
				this.HBJJOCHGOPH = 1122f;
			}
			if (this.Camera2 != null)
			{
				this.ABHDNGIHBKE().SetTexture("SetupEncryption() got called. ", this.JDMCFBKJHDD);
			}
			this.HKGAONMOBMH().SetFloat("ConfigVersionSlider", this.HBJJOCHGOPH);
			this.CBCNOEIALHB().SetFloat("CameraFilterPack_Broken_Screen1", this.BlendFX);
			this.FHFLKLMFHOI().SetFloat("Finished", this.Adjust);
			this.DONENAMLFLF().SetFloat("Data/Maps/", this.Precision);
			this.FHFLKLMFHOI().SetFloat(". Set PhotonNetwork.OnEventCall.", this.Luminosity);
			this.NBPKMLMCHFN.SetFloat("_Blurred", this.Change_Red);
			this.EOCCJGIGEGJ().SetFloat("SettingsCanvas", this.Change_Green);
			this.LNLKMDPHDCC().SetFloat(". Our prefix is ", this.Change_Blue);
			this.MLMKCOINOOH().SetColor("#failed!", this.ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001137 RID: 4407 RVA: 0x00075659 File Offset: 0x00073859
	private Material MLMKCOINOOH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001138 RID: 4408 RVA: 0x00075690 File Offset: 0x00073890
	private void EFJDNLGNACH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 110);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001139 RID: 4409 RVA: 0x000749DF File Offset: 0x00072BDF
	private void HEBOIFKBLGD()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x0600113A RID: 4410 RVA: 0x00075708 File Offset: 0x00073908
	private void KOFAMEKHHGD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -35);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600113B RID: 4411 RVA: 0x00075780 File Offset: 0x00073980
	private void GPNAOAKCMHC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 56);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600113C RID: 4412 RVA: 0x000757F8 File Offset: 0x000739F8
	private void MMPHNFPPEHO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 46);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600113D RID: 4413 RVA: 0x00075870 File Offset: 0x00073A70
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("_MainTex2", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Adjust);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Precision);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Luminosity);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Change_Red);
			this.NBPKMLMCHFN.SetFloat("_Value6", this.Change_Green);
			this.NBPKMLMCHFN.SetFloat("_Value7", this.Change_Blue);
			this.NBPKMLMCHFN.SetColor("_ColorKey", this.ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600113E RID: 4414 RVA: 0x000759C4 File Offset: 0x00073BC4
	private void IENKPJEBMFM()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600113F RID: 4415 RVA: 0x00075A20 File Offset: 0x00073C20
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 985f)
			{
				this.HBJJOCHGOPH = 1952f;
			}
			if (this.Camera2 != null)
			{
				this.ABHDNGIHBKE().SetTexture("shader.invert", this.JDMCFBKJHDD);
			}
			this.FHFLKLMFHOI().SetFloat("HiddenToggle", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("[PlayerBase] Current attempt: ", this.BlendFX);
			this.ABHDNGIHBKE().SetFloat("CameraFilterPack/Edge_Neon", this.Adjust);
			this.ABHDNGIHBKE().SetFloat("_Visualize", this.Precision);
			this.LPCHMEKDCHI().SetFloat("player.blackcat", this.Luminosity);
			this.DONENAMLFLF().SetFloat("Music End", this.Change_Red);
			this.GKILCDHJFEG().SetFloat("request", this.Change_Green);
			this.HKIMAANBGMJ().SetFloat("_Radius", this.Change_Blue);
			this.GKILCDHJFEG().SetColor("InfoButton", this.ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001140 RID: 4416 RVA: 0x00075B74 File Offset: 0x00073D74
	private void KLILJHJNICK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -109);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001141 RID: 4417 RVA: 0x00075BEC File Offset: 0x00073DEC
	private void FDMAEPOHDMK()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001142 RID: 4418 RVA: 0x00075C48 File Offset: 0x00073E48
	private void HAIAHJPCPAG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -58);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001143 RID: 4419 RVA: 0x00075CBF File Offset: 0x00073EBF
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001144 RID: 4420 RVA: 0x00075CF6 File Offset: 0x00073EF6
	private void LIFBFDKFMMH()
	{
		this.FMFNILJIEIA();
		this.Update();
	}

	// Token: 0x06001145 RID: 4421 RVA: 0x00075D04 File Offset: 0x00073F04
	private Material MHBAIEKFBIJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001146 RID: 4422 RVA: 0x000749DF File Offset: 0x00072BDF
	private void JBNPEHMDCMI()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06001147 RID: 4423 RVA: 0x00075D3C File Offset: 0x00073F3C
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1431f)
			{
				this.HBJJOCHGOPH = 417f;
			}
			if (this.Camera2 != null)
			{
				this.DONENAMLFLF().SetTexture("score", this.JDMCFBKJHDD);
			}
			this.MHBAIEKFBIJ().SetFloat("}", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("_TimeX", this.BlendFX);
			this.GKILCDHJFEG().SetFloat("[Left]", this.Adjust);
			this.CBCNOEIALHB().SetFloat("maps.", this.Precision);
			this.MLMKCOINOOH().SetFloat("_Green_C", this.Luminosity);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.Change_Red);
			this.HKIMAANBGMJ().SetFloat("CameraFilterPack/EyesVision_1", this.Change_Green);
			this.HKGAONMOBMH().SetFloat("Fade", this.Change_Blue);
			this.IIBLJCKLGFG().SetColor("[ResourcesManager] Load text error: not found", this.ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001148 RID: 4424 RVA: 0x00075E90 File Offset: 0x00074090
	private void AEMGPJDJGBJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -112);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001149 RID: 4425 RVA: 0x00075F08 File Offset: 0x00074108
	private void PHJLHCMCCKE()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600114A RID: 4426 RVA: 0x00075F64 File Offset: 0x00074164
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1755f)
			{
				this.HBJJOCHGOPH = 871f;
			}
			if (this.Camera2 != null)
			{
				this.LNLKMDPHDCC().SetTexture(".g", this.JDMCFBKJHDD);
			}
			this.IIBLJCKLGFG().SetFloat("_FixDistance", this.HBJJOCHGOPH);
			this.CIAFLBFJLEJ().SetFloat("arc", this.BlendFX);
			this.GCDFNHMJMIP().SetFloat("/", this.Adjust);
			this.FHFLKLMFHOI().SetFloat("Received OnSerialization for view ID ", this.Precision);
			this.GKILCDHJFEG().SetFloat("/", this.Luminosity);
			this.GKILCDHJFEG().SetFloat("Fade", this.Change_Red);
			this.IIBLJCKLGFG().SetFloat("Image", this.Change_Green);
			this.DONENAMLFLF().SetFloat("player.xp", this.Change_Blue);
			this.EOCCJGIGEGJ().SetColor("_LightIntensity", this.ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600114B RID: 4427 RVA: 0x000760B8 File Offset: 0x000742B8
	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1617f)
			{
				this.HBJJOCHGOPH = 561f;
			}
			if (this.Camera2 != null)
			{
				this.EOCCJGIGEGJ().SetTexture("???", this.JDMCFBKJHDD);
			}
			this.GKILCDHJFEG().SetFloat("R1", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("Fade", this.BlendFX);
			this.LPCHMEKDCHI().SetFloat("_Fade", this.Adjust);
			this.ABHDNGIHBKE().SetFloat("_FarCamera", this.Precision);
			this.GCDFNHMJMIP().SetFloat("mapselector.lastSearch", this.Luminosity);
			this.HKGAONMOBMH().SetFloat("_TimeX", this.Change_Red);
			this.HCGJCMDJPGD().SetFloat("_TimeX", this.Change_Green);
			this.KEMAALEODNH().SetFloat("_Factor", this.Change_Blue);
			this.HKGAONMOBMH().SetColor("note.0", this.ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600114C RID: 4428 RVA: 0x000749DF File Offset: 0x00072BDF
	private void FAKGFMFAPDG()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x0600114D RID: 4429 RVA: 0x00076209 File Offset: 0x00074409
	private void KGHFKHBPHEH()
	{
		this.FLKEJJEGCFA();
		this.APKNAPHOFHC();
	}

	// Token: 0x0600114E RID: 4430 RVA: 0x00076218 File Offset: 0x00074418
	private void AOKOLPEGHDD()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600114F RID: 4431 RVA: 0x000749DF File Offset: 0x00072BDF
	private void APKNAPHOFHC()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06001150 RID: 4432 RVA: 0x00076274 File Offset: 0x00074474
	private void PLBOFEPBPKC()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001151 RID: 4433 RVA: 0x000762D0 File Offset: 0x000744D0
	private void EJJEDJIOFAB()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001152 RID: 4434 RVA: 0x0007632C File Offset: 0x0007452C
	private void IABLKKAALGI()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001153 RID: 4435 RVA: 0x000749DF File Offset: 0x00072BDF
	private void MFMIODIAKNI()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06001154 RID: 4436 RVA: 0x00076388 File Offset: 0x00074588
	private void BFEILOMHNPC()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001155 RID: 4437 RVA: 0x000763E3 File Offset: 0x000745E3
	private void OnEnable()
	{
		this.Start();
		this.Update();
	}

	// Token: 0x06001156 RID: 4438 RVA: 0x000763F4 File Offset: 0x000745F4
	private void KDMANOEMOCA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -49);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001157 RID: 4439 RVA: 0x0007646C File Offset: 0x0007466C
	private void MMMDPANNAIO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 58);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001158 RID: 4440 RVA: 0x000764E4 File Offset: 0x000746E4
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 137f)
			{
				this.HBJJOCHGOPH = 639f;
			}
			if (this.Camera2 != null)
			{
				this.LPDOGGFOBDH().SetTexture("SpeedSlider", this.JDMCFBKJHDD);
			}
			this.HKGAONMOBMH().SetFloat("GlassesColor2", this.HBJJOCHGOPH);
			this.CIAFLBFJLEJ().SetFloat("_Near", this.BlendFX);
			this.GCDFNHMJMIP().SetFloat("[PlayerController] ", this.Adjust);
			this.IIBLJCKLGFG().SetFloat("Object ID. Case-Sensitive", this.Precision);
			this.CBCNOEIALHB().SetFloat("CameraFilterPack/Vision_Plasma", this.Luminosity);
			this.HHIAIGCAHDA().SetFloat("menu.selectedplaymode", this.Change_Red);
			this.HHIFMIPPMPF().SetFloat("bad", this.Change_Green);
			this.MLMKCOINOOH().SetFloat("_TimeX", this.Change_Blue);
			this.DONENAMLFLF().SetColor("PointsScoreText", this.ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001159 RID: 4441 RVA: 0x000749DF File Offset: 0x00072BDF
	private void FBMDHDBELEK()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x0600115A RID: 4442 RVA: 0x00076638 File Offset: 0x00074838
	private void OnDisable()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600115B RID: 4443 RVA: 0x00076693 File Offset: 0x00074893
	private void LGELACBDPEH()
	{
		this.OHFOLGANOLC();
		this.HLDFOJMHKNL();
	}

	// Token: 0x0600115C RID: 4444 RVA: 0x000766A1 File Offset: 0x000748A1
	private void LLDBPKHDPKI()
	{
		this.OKLAJINHPAN();
		this.Update();
	}

	// Token: 0x0600115D RID: 4445 RVA: 0x000766B0 File Offset: 0x000748B0
	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 432f)
			{
				this.HBJJOCHGOPH = 1553f;
			}
			if (this.Camera2 != null)
			{
				this.KEMAALEODNH().SetTexture(";", this.JDMCFBKJHDD);
			}
			this.KEMAALEODNH().SetFloat("CameraFilterPack/Drawing_Manga", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Atmosphere_Rain_Pro_3D", this.BlendFX);
			this.LNLKMDPHDCC().SetFloat("\"", this.Adjust);
			this.HKIMAANBGMJ().SetFloat("_Blue_C", this.Precision);
			this.KEMAALEODNH().SetFloat("Set sun audio input", this.Luminosity);
			this.CBCNOEIALHB().SetFloat("[EditorEvent] Exception: ", this.Change_Red);
			this.LPDOGGFOBDH().SetFloat("_TapLowForeground", this.Change_Green);
			this.LNLKMDPHDCC().SetFloat("CameraFilterPack/3D_Inverse", this.Change_Blue);
			this.IIBLJCKLGFG().SetColor("_SpawnHeuristic", this.ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000025 RID: 37
	// (get) Token: 0x0600115E RID: 4446 RVA: 0x00076801 File Offset: 0x00074A01
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

	// Token: 0x0600115F RID: 4447 RVA: 0x00076838 File Offset: 0x00074A38
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1829f)
			{
				this.HBJJOCHGOPH = 935f;
			}
			if (this.Camera2 != null)
			{
				this.LNLKMDPHDCC().SetTexture("Please attach component to a Graphical UI component", this.JDMCFBKJHDD);
			}
			this.MHBAIEKFBIJ().SetFloat("visible", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("colorC", this.BlendFX);
			this.CIAFLBFJLEJ().SetFloat(" argument(s): ", this.Adjust);
			this.EOCCJGIGEGJ().SetFloat("file://", this.Precision);
			this.GCDFNHMJMIP().SetFloat("CameraFilterPack/Vision_Plasma", this.Luminosity);
			this.EOCCJGIGEGJ().SetFloat("_TimeX", this.Change_Red);
			this.ABHDNGIHBKE().SetFloat("settings.shaders", this.Change_Green);
			this.MHBAIEKFBIJ().SetFloat("Failed to InstantiateSceneObject prefab: ", this.Change_Blue);
			this.HHIAIGCAHDA().SetColor("_Value3", this.ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001160 RID: 4448 RVA: 0x0007698C File Offset: 0x00074B8C
	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 588f)
			{
				this.HBJJOCHGOPH = 1513f;
			}
			if (this.Camera2 != null)
			{
				this.CBCNOEIALHB().SetTexture("_Value3", this.JDMCFBKJHDD);
			}
			this.HKIMAANBGMJ().SetFloat("_Value", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("GameScene", this.BlendFX);
			this.LNLKMDPHDCC().SetFloat(" ", this.Adjust);
			this.KEMAALEODNH().SetFloat("_Value8", this.Precision);
			this.HCGJCMDJPGD().SetFloat(".", this.Luminosity);
			this.FHFLKLMFHOI().SetFloat("_Value2", this.Change_Red);
			this.LPDOGGFOBDH().SetFloat("_TimeX", this.Change_Green);
			this.GCDFNHMJMIP().SetFloat("PunRespawn with Position.", this.Change_Blue);
			this.GCDFNHMJMIP().SetColor("TRACKING", this.ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001161 RID: 4449 RVA: 0x00076ADD File Offset: 0x00074CDD
	private void FCKMAOMOKNB()
	{
		this.KLILJHJNICK();
		this.BFGIMALGMAJ();
	}

	// Token: 0x06001162 RID: 4450 RVA: 0x00076AEC File Offset: 0x00074CEC
	private void BMIOFJFMCBG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -9);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001163 RID: 4451 RVA: 0x000749DF File Offset: 0x00072BDF
	private void BFGIMALGMAJ()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06001164 RID: 4452 RVA: 0x00076B64 File Offset: 0x00074D64
	private void MGMAOBPPOBJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -95);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001166 RID: 4454 RVA: 0x000749DF File Offset: 0x00072BDF
	private void Update()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06001167 RID: 4455 RVA: 0x000749DF File Offset: 0x00072BDF
	private void EHJJFJCKGAJ()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06001168 RID: 4456 RVA: 0x00076C04 File Offset: 0x00074E04
	private void PPGEGFMNIKO()
	{
		this.FLKEJJEGCFA();
		this.KCDBBPKIFNJ();
	}

	// Token: 0x06001169 RID: 4457 RVA: 0x00076C12 File Offset: 0x00074E12
	private void IJCBBIJOCAH()
	{
		this.NNFMIAFHMJM();
		this.MFMIODIAKNI();
	}

	// Token: 0x0600116A RID: 4458 RVA: 0x00076C20 File Offset: 0x00074E20
	private void IBPAMDEAGJL()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600116B RID: 4459 RVA: 0x00076C7B File Offset: 0x00074E7B
	private void KDBKBPCIHBL()
	{
		this.KDMANOEMOCA();
		this.EHJJFJCKGAJ();
	}

	// Token: 0x0600116C RID: 4460 RVA: 0x00076C8C File Offset: 0x00074E8C
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 51f)
			{
				this.HBJJOCHGOPH = 1507f;
			}
			if (this.Camera2 != null)
			{
				this.HHIAIGCAHDA().SetTexture("[EditorEvent] Exception: ", this.JDMCFBKJHDD);
			}
			this.ABHDNGIHBKE().SetFloat("ls", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat(":", this.BlendFX);
			this.GKILCDHJFEG().SetFloat("SetParticlesCountPerBeat", this.Adjust);
			this.CBCNOEIALHB().SetFloat("Exit to menu?", this.Precision);
			this.GKILCDHJFEG().SetFloat("_TimeX", this.Luminosity);
			this.GKILCDHJFEG().SetFloat("ConfigVersionSlider", this.Change_Red);
			this.MLMKCOINOOH().SetFloat("custom", this.Change_Green);
			this.IIBLJCKLGFG().SetFloat("_ScreenResolution", this.Change_Blue);
			this.CIAFLBFJLEJ().SetColor("_SSRMultiplier", this.ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600116D RID: 4461 RVA: 0x000749DF File Offset: 0x00072BDF
	private void JBCNIPJDPJB()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x0600116E RID: 4462 RVA: 0x00076DE0 File Offset: 0x00074FE0
	private void LBPHCAMMAPB()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600116F RID: 4463 RVA: 0x000749DF File Offset: 0x00072BDF
	private void JOACBIEHHCE()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06001170 RID: 4464 RVA: 0x00076E3B File Offset: 0x0007503B
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001171 RID: 4465 RVA: 0x00076E74 File Offset: 0x00075074
	private void EKCKJLFFAID()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001172 RID: 4466 RVA: 0x00076ECF File Offset: 0x000750CF
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001173 RID: 4467 RVA: 0x00076F06 File Offset: 0x00075106
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001174 RID: 4468 RVA: 0x00076F40 File Offset: 0x00075140
	private void JNALDALAJLG()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001175 RID: 4469 RVA: 0x00076F9C File Offset: 0x0007519C
	private void NNCCPEBIAKH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 88);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001176 RID: 4470 RVA: 0x000749DF File Offset: 0x00072BDF
	private void HLDFOJMHKNL()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06001177 RID: 4471 RVA: 0x000749DF File Offset: 0x00072BDF
	private void KCDBBPKIFNJ()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06001178 RID: 4472 RVA: 0x00077014 File Offset: 0x00075214
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1005f)
			{
				this.HBJJOCHGOPH = 1919f;
			}
			if (this.Camera2 != null)
			{
				this.MHBAIEKFBIJ().SetTexture("maps.", this.JDMCFBKJHDD);
			}
			this.DONENAMLFLF().SetFloat("_Value", this.HBJJOCHGOPH);
			this.CIAFLBFJLEJ().SetFloat("_BlueAmplifier", this.BlendFX);
			this.GCDFNHMJMIP().SetFloat("CameraFilterPack/TV_ARCADE_Fast", this.Adjust);
			this.IIBLJCKLGFG().SetFloat("FinalScoreText", this.Precision);
			this.LPCHMEKDCHI().SetFloat("_EmissionGain", this.Luminosity);
			this.MHBAIEKFBIJ().SetFloat("_Value2", this.Change_Red);
			this.HKIMAANBGMJ().SetFloat("_Value", this.Change_Green);
			this.LPCHMEKDCHI().SetFloat("LostLive", this.Change_Blue);
			this.EOCCJGIGEGJ().SetColor("_MainTex2", this.ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001179 RID: 4473 RVA: 0x00077165 File Offset: 0x00075365
	private Material CBCNOEIALHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600117A RID: 4474 RVA: 0x0007719C File Offset: 0x0007539C
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600117B RID: 4475 RVA: 0x000771D3 File Offset: 0x000753D3
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600117C RID: 4476 RVA: 0x00074594 File Offset: 0x00072794
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600117D RID: 4477 RVA: 0x0007720C File Offset: 0x0007540C
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 505f)
			{
				this.HBJJOCHGOPH = 1008f;
			}
			if (this.Camera2 != null)
			{
				this.MHBAIEKFBIJ().SetTexture("OxOD.lastPath", this.JDMCFBKJHDD);
			}
			this.HKIMAANBGMJ().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("note.3", this.BlendFX);
			this.MLMKCOINOOH().SetFloat("_BlurVector", this.Adjust);
			this.ABHDNGIHBKE().SetFloat("Joystick1Button12", this.Precision);
			this.MLMKCOINOOH().SetFloat("Bad parameters for setint! Use <key> <value>", this.Luminosity);
			this.LPDOGGFOBDH().SetFloat("Avoid using this directly. Thanks.", this.Change_Red);
			this.CIAFLBFJLEJ().SetFloat("_TimeX", this.Change_Green);
			this.LPDOGGFOBDH().SetFloat("[PlayerBase] Loaded custom model: ", this.Change_Blue);
			this.HHIFMIPPMPF().SetColor("Save", this.ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CBCNOEIALHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600117E RID: 4478 RVA: 0x0007735D File Offset: 0x0007555D
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600117F RID: 4479 RVA: 0x00077394 File Offset: 0x00075594
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 975f)
			{
				this.HBJJOCHGOPH = 1204f;
			}
			if (this.Camera2 != null)
			{
				this.GCDFNHMJMIP().SetTexture("scene ", this.JDMCFBKJHDD);
			}
			this.HHIFMIPPMPF().SetFloat("_Speed", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("ColorBlood", this.BlendFX);
			this.MLMKCOINOOH().SetFloat("DPADHOR", this.Adjust);
			this.HCGJCMDJPGD().SetFloat(" Server: ", this.Precision);
			this.LPDOGGFOBDH().SetFloat("/", this.Luminosity);
			this.MLMKCOINOOH().SetFloat("GenerationMenu", this.Change_Red);
			this.HHIFMIPPMPF().SetFloat("_ScreenResolution", this.Change_Green);
			this.EOCCJGIGEGJ().SetFloat("StartButton", this.Change_Blue);
			this.EOCCJGIGEGJ().SetColor("_TimeX", this.ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001180 RID: 4480 RVA: 0x000774E8 File Offset: 0x000756E8
	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 114f)
			{
				this.HBJJOCHGOPH = 585f;
			}
			if (this.Camera2 != null)
			{
				this.CBCNOEIALHB().SetTexture("#close", this.JDMCFBKJHDD);
			}
			this.CIAFLBFJLEJ().SetFloat("DPADVER", this.HBJJOCHGOPH);
			this.CIAFLBFJLEJ().SetFloat("_TimeX", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("float,2", this.Adjust);
			this.LPCHMEKDCHI().SetFloat(", ", this.Precision);
			this.CBCNOEIALHB().SetFloat(".sawoutdatedmessage", this.Luminosity);
			this.ABHDNGIHBKE().SetFloat("(((?<x>(?=[,\\r\\n]+))|\"(?<x>([^\"]|\"\")+)\"|(?<x>[^,\\r\\n]+)),?)", this.Change_Red);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack_Atmosphere_Rain_FX", this.Change_Green);
			this.HHIAIGCAHDA().SetFloat("EnableRankingToggle", this.Change_Blue);
			this.GCDFNHMJMIP().SetColor("challenges.", this.ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001181 RID: 4481 RVA: 0x0007763C File Offset: 0x0007583C
	private void HNILMGEKDEC()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001182 RID: 4482 RVA: 0x00077697 File Offset: 0x00075897
	private void MEJPBKFMAIG()
	{
		this.IGPCNCJIEOJ();
		this.DGCGGKMNPLD();
	}

	// Token: 0x06001183 RID: 4483 RVA: 0x000749DF File Offset: 0x00072BDF
	private void LJIHHJOAJCN()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06001184 RID: 4484 RVA: 0x000776A8 File Offset: 0x000758A8
	private void NNBCLMJGFEN()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001185 RID: 4485 RVA: 0x00077704 File Offset: 0x00075904
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1767f)
			{
				this.HBJJOCHGOPH = 1194f;
			}
			if (this.Camera2 != null)
			{
				this.MHBAIEKFBIJ().SetTexture("Can't start OFFLINE mode while connected!", this.JDMCFBKJHDD);
			}
			this.LNLKMDPHDCC().SetFloat("_Value", this.HBJJOCHGOPH);
			this.MLMKCOINOOH().SetFloat("_Value", this.BlendFX);
			this.ABHDNGIHBKE().SetFloat("masterSteamID", this.Adjust);
			this.FHFLKLMFHOI().SetFloat("Set camera (or player) distance. Base player distance - 14", this.Precision);
			this.CIAFLBFJLEJ().SetFloat("_TimeX", this.Luminosity);
			this.HKGAONMOBMH().SetFloat("_Intensity", this.Change_Red);
			this.HKGAONMOBMH().SetFloat("r", this.Change_Green);
			this.CBCNOEIALHB().SetFloat("CameraFilterPack/Blend2Camera_LinearLight", this.Change_Blue);
			this.MLMKCOINOOH().SetColor("_ScreenResolution", this.ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001186 RID: 4486 RVA: 0x00077858 File Offset: 0x00075A58
	private void HLIAEEMGBHN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -124);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001187 RID: 4487 RVA: 0x000778D0 File Offset: 0x00075AD0
	private void OKLAJINHPAN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 47);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001188 RID: 4488 RVA: 0x00077948 File Offset: 0x00075B48
	private void BNEJMABFKJE()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001189 RID: 4489 RVA: 0x000779A3 File Offset: 0x00075BA3
	private void IGCJMAADPGG()
	{
		this.Start();
		this.ONKDMMJPEMN();
	}

	// Token: 0x0600118A RID: 4490 RVA: 0x000779B1 File Offset: 0x00075BB1
	private void DPGHJILBPCE()
	{
		this.AEDDNDHCLNN();
		this.JBCNIPJDPJB();
	}

	// Token: 0x0600118B RID: 4491 RVA: 0x000779C0 File Offset: 0x00075BC0
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 498f)
			{
				this.HBJJOCHGOPH = 1805f;
			}
			if (this.Camera2 != null)
			{
				this.GCDFNHMJMIP().SetTexture("_ScreenResolution", this.JDMCFBKJHDD);
			}
			this.HHIAIGCAHDA().SetFloat(" ", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("_TimeX", this.BlendFX);
			this.MHBAIEKFBIJ().SetFloat("_MatrixColor", this.Adjust);
			this.HKIMAANBGMJ().SetFloat("Image", this.Precision);
			this.CBCNOEIALHB().SetFloat("_ScreenResolution", this.Luminosity);
			this.CIAFLBFJLEJ().SetFloat("FavoriteButton", this.Change_Red);
			this.KEMAALEODNH().SetFloat(";", this.Change_Green);
			this.GKILCDHJFEG().SetFloat("ConnectToMaster() disabled the offline mode. No longer offline.", this.Change_Blue);
			this.LPCHMEKDCHI().SetColor("Failed to InstantiateSceneObject prefab: ", this.ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600118C RID: 4492 RVA: 0x00077B11 File Offset: 0x00075D11
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600118D RID: 4493 RVA: 0x00077B48 File Offset: 0x00075D48
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600118E RID: 4494 RVA: 0x00077B80 File Offset: 0x00075D80
	private void Start()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600118F RID: 4495 RVA: 0x000749DF File Offset: 0x00072BDF
	private void GFACKFCEIBC()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06001190 RID: 4496 RVA: 0x00077BF8 File Offset: 0x00075DF8
	private void IEFMONDKKJN()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001191 RID: 4497 RVA: 0x00077C54 File Offset: 0x00075E54
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 352f)
			{
				this.HBJJOCHGOPH = 1826f;
			}
			if (this.Camera2 != null)
			{
				this.HHIFMIPPMPF().SetTexture("Done!", this.JDMCFBKJHDD);
			}
			this.GKILCDHJFEG().SetFloat("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("_Speed", this.BlendFX);
			this.LPCHMEKDCHI().SetFloat("_Value2", this.Adjust);
			this.HHIFMIPPMPF().SetFloat("BitsData", this.Precision);
			this.HKGAONMOBMH().SetFloat("MainCamera", this.Luminosity);
			this.GKILCDHJFEG().SetFloat("_AccumOrig", this.Change_Red);
			this.HCGJCMDJPGD().SetFloat("Switch environment sprite image", this.Change_Green);
			this.MHBAIEKFBIJ().SetFloat("s", this.Change_Blue);
			this.HKGAONMOBMH().SetColor("Gameplay/sprite", this.ColorKey);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001192 RID: 4498 RVA: 0x00076F06 File Offset: 0x00075106
	private Material HKIMAANBGMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001193 RID: 4499 RVA: 0x00077DA5 File Offset: 0x00075FA5
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000268 RID: 616
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_ColorKey";

	// Token: 0x04000269 RID: 617
	public Shader SCShader;

	// Token: 0x0400026A RID: 618
	public Camera Camera2;

	// Token: 0x0400026B RID: 619
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400026C RID: 620
	private Material BJFKDHHMLJH;

	// Token: 0x0400026D RID: 621
	[Range(0f, 1f)]
	public float BlendFX = 1f;

	// Token: 0x0400026E RID: 622
	public Color ColorKey;

	// Token: 0x0400026F RID: 623
	[Range(-0.2f, 0.2f)]
	public float Adjust;

	// Token: 0x04000270 RID: 624
	[Range(-0.2f, 0.2f)]
	public float Precision;

	// Token: 0x04000271 RID: 625
	[Range(-0.2f, 0.2f)]
	public float Luminosity;

	// Token: 0x04000272 RID: 626
	[Range(-0.3f, 0.3f)]
	public float Change_Red;

	// Token: 0x04000273 RID: 627
	[Range(-0.3f, 0.3f)]
	public float Change_Green;

	// Token: 0x04000274 RID: 628
	[Range(-0.3f, 0.3f)]
	public float Change_Blue;

	// Token: 0x04000275 RID: 629
	private RenderTexture JDMCFBKJHDD;

	// Token: 0x04000276 RID: 630
	private Vector2 FPEMMGKMJGA;
}
