using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020000F5 RID: 245
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Night Vision/Night Vision FX")]
public class CameraFilterPack_NightVisionFX : MonoBehaviour
{
	// Token: 0x06004C22 RID: 19490 RVA: 0x001782A8 File Offset: 0x001764A8
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1028f)
			{
				this.HBJJOCHGOPH = 206f;
			}
			this.IONHGBPGCHK().SetFloat("<b>#banended</b>", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("settings.arcshitsoundtimedelay", this.OnOff);
			this.MLMKCOINOOH().SetFloat("SetSatelliteLerpSpeed", this.Greenness);
			this.DEFBJOCJJKF().SetFloat("[MenuScene] Error: ", this.Vignette);
			this.KEMJNOMIPHN().SetFloat("Preparing content", this.Vignette_Alpha);
			this.EOCCJGIGEGJ().SetFloat("_ScreenResolution", this.Distortion);
			this.MLMKCOINOOH().SetFloat("Missing shader in ", this.Noise);
			this.MICHFGAOPKM().SetFloat("Vertical", this.Intensity);
			this.KEMJNOMIPHN().SetFloat("COMPLETED", this.Light);
			this.KEMJNOMIPHN().SetFloat("Scrollbar", this.Light2);
			this.LENEJAGLCNL().SetFloat("\\\\", this.Line);
			this.MLMKCOINOOH().SetFloat("x", this.Color_R);
			this.IFMAPIDFNLI().SetFloat("ResourceIDInputField", this.Color_G);
			this.IFMAPIDFNLI().SetFloat("LevelConfigButton", this.Color_B);
			this.GJHLADDCMFF().SetFloat("Tab1Content", this._Binocular_Size);
			this.IONHGBPGCHK().SetFloat("Object ID. Case-Sensitive", this._Binocular_Dist);
			this.DKNJGHFLAIF().SetFloat("file://", this._Binocular_Smooth);
			this.OIMMPLPBLBK().SetVector("CameraFilterPack/BlurHole", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C23 RID: 19491 RVA: 0x001784A8 File Offset: 0x001766A8
	private void HIPEHGNBJMN()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004C24 RID: 19492 RVA: 0x001784CC File Offset: 0x001766CC
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C25 RID: 19493 RVA: 0x00178503 File Offset: 0x00176703
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C26 RID: 19494 RVA: 0x00178503 File Offset: 0x00176703
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C27 RID: 19495 RVA: 0x00178520 File Offset: 0x00176720
	private void HDMDKOKOOJC()
	{
		this.SCShader = Shader.Find("_FadeFX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004C28 RID: 19496 RVA: 0x00178544 File Offset: 0x00176744
	private void ONKDMMJPEMN()
	{
		if (this.HODDOPANHAO != this.Preset)
		{
			this.HODDOPANHAO = this.Preset;
			float[] array = new float[127];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-B9B8E8DB27999DD7D297759E2C0DB5F14CDC32B9).FieldHandle);
			float[] array2 = array;
			float[] array3 = new float[80];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-A49B234BAED1E521F4CC502150FB5CD960556BB7).FieldHandle);
			float[] array4 = array3;
			float[] array5 = new float[-36];
			RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.$field-1BC81E84591291A507FFBB2389A425CDBC738E46).FieldHandle);
			float[] array6 = array5;
			float[] array7 = new float[-75];
			RuntimeHelpers.InitializeArray(array7, fieldof(<PrivateImplementationDetails>.$field-231A2B8BB20EA0E6A00B61ED86869E4AF38E568B).FieldHandle);
			float[] array8 = array7;
			float[] array9 = new float[-17];
			RuntimeHelpers.InitializeArray(array9, fieldof(<PrivateImplementationDetails>.$field-344F35933DADC294755E40C6C3723DE2C4E5FD90).FieldHandle);
			float[] array10 = array9;
			float[] array11 = new float[98];
			RuntimeHelpers.InitializeArray(array11, fieldof(<PrivateImplementationDetails>.$field-36D456C626B20C21AFD26F2ECDF45C1FB877A1CD).FieldHandle);
			float[] array12 = array11;
			float[] array13 = new float[-61];
			RuntimeHelpers.InitializeArray(array13, fieldof(<PrivateImplementationDetails>.$field-175291D1FA3DEB078C2B51F363761FA287FE0D22).FieldHandle);
			float[] array14 = array13;
			float[] array15 = new float[]
			{
				2f,
				0.054f,
				1f,
				1.28f,
				0.409f,
				-1f,
				0.41f,
				0.656f,
				0.427f,
				0.95f,
				-0.35f
			};
			float[] array16 = new float[-22];
			RuntimeHelpers.InitializeArray(array16, fieldof(<PrivateImplementationDetails>.$field-2E0E90126C561F5AC67617705F5604DB9E5284A1).FieldHandle);
			float[] array17 = array16;
			float[] array18 = new float[-20];
			RuntimeHelpers.InitializeArray(array18, fieldof(<PrivateImplementationDetails>.$field-49201D55AB670A481AC262DF9FA3BD17F93DC9FD).FieldHandle);
			float[] array19 = array18;
			float[] array20 = new float[42];
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array20 = array2;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array20 = array4;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Low_Light)
			{
				array20 = array6;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_RedBurn)
			{
				array20 = array8;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Sharp)
			{
				array20 = array10;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array20 = array12;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Sharp)
			{
				array20 = array14;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Dark)
			{
				array20 = array15;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_BlueSky)
			{
				array20 = array17;
			}
			if (this.Preset == (CameraFilterPack_NightVisionFX.preset)77)
			{
				array20 = array19;
			}
			if (this.Preset != CameraFilterPack_NightVisionFX.preset.Night_Vision_Personalized)
			{
				this.Greenness = array20[1];
				this.Vignette = array20[1];
				this.Vignette_Alpha = array20[8];
				this.Distortion = array20[5];
				this.Noise = array20[4];
				this.Intensity = array20[6];
				this.Light = array20[6];
				this.Light2 = array20[4];
				this.Line = array20[2];
				this.Color_R = array20[-49];
				this.Color_G = array20[5];
				this.Color_B = array20[21];
			}
		}
	}

	// Token: 0x06004C29 RID: 19497 RVA: 0x0017875E File Offset: 0x0017695E
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/NightVisionFX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004C2A RID: 19498 RVA: 0x00178782 File Offset: 0x00176982
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find("Tab2Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004C2B RID: 19499 RVA: 0x001787A8 File Offset: 0x001769A8
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1257f)
			{
				this.HBJJOCHGOPH = 929f;
			}
			this.KBOPGONOCNP().SetFloat("string", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("/icon", this.OnOff);
			this.MLMKCOINOOH().SetFloat("LastNewsButton", this.Greenness);
			this.GJHLADDCMFF().SetFloat("_Color_R", this.Vignette);
			this.MLMKCOINOOH().SetFloat("#FFDA44", this.Vignette_Alpha);
			this.DEFBJOCJJKF().SetFloat(" ", this.Distortion);
			this.LENEJAGLCNL().SetFloat(".lastCheckpoint.playerdistance", this.Noise);
			this.LENEJAGLCNL().SetFloat("st", this.Intensity);
			this.IONHGBPGCHK().SetFloat("colorD", this.Light);
			this.EOCCJGIGEGJ().SetFloat("mapselector.tags.", this.Light2);
			this.MICHFGAOPKM().SetFloat("history", this.Line);
			this.KBOPGONOCNP().SetFloat("AvatarImage", this.Color_R);
			this.NBPKMLMCHFN.SetFloat("win", this.Color_G);
			this.DKNJGHFLAIF().SetFloat("_PColor", this.Color_B);
			this.NBPKMLMCHFN.SetFloat("InstantiateRpc", this._Binocular_Size);
			this.IFMAPIDFNLI().SetFloat(".completed", this._Binocular_Dist);
			this.MLMKCOINOOH().SetFloat("OnMastedChangeScene", this._Binocular_Smooth);
			this.KBOPGONOCNP().SetVector("OnPhotonRandomJoinFailed() was called by PUN. No random room available, so we create one. Calling: PhotonNetwork.CreateRoom(null, new RoomOptions() {maxPlayers = 4}, null);", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C2C RID: 19500 RVA: 0x00178503 File Offset: 0x00176703
	private void FGBDGGCBFLP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C2D RID: 19501 RVA: 0x001789A8 File Offset: 0x00176BA8
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 545f)
			{
				this.HBJJOCHGOPH = 536f;
			}
			this.IFMAPIDFNLI().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("ServerSettings: ", this.OnOff);
			this.DEFBJOCJJKF().SetFloat("_CenterX", this.Greenness);
			this.KEMJNOMIPHN().SetFloat("#kicked", this.Vignette);
			this.IFMAPIDFNLI().SetFloat("CameraFilterPack/Light_Water2", this.Vignette_Alpha);
			this.DEFBJOCJJKF().SetFloat("_FarCamera", this.Distortion);
			this.DKNJGHFLAIF().SetFloat("Bad parameters for getbool! Use <key> <value>", this.Noise);
			this.DOHGBNPMBKG().SetFloat("SetSunSensitivity", this.Intensity);
			this.MICHFGAOPKM().SetFloat("Waiting for AvailableRegions. State: ", this.Light);
			this.IONHGBPGCHK().SetFloat("mapselector.filter.favoriteonly", this.Light2);
			this.MCDGIILBNIF().SetFloat(" not exist", this.Line);
			this.LENEJAGLCNL().SetFloat("SetSpeed", this.Color_R);
			this.IONHGBPGCHK().SetFloat("12", this.Color_G);
			this.MLMKCOINOOH().SetFloat("SetScale", this.Color_B);
			this.LENEJAGLCNL().SetFloat("JoinButton", this._Binocular_Size);
			this.MCDGIILBNIF().SetFloat("_SecondTex", this._Binocular_Dist);
			this.HKGAONMOBMH().SetFloat("a month ago", this._Binocular_Smooth);
			this.IFMAPIDFNLI().SetVector("#alreadyexist", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C2E RID: 19502 RVA: 0x00178BA8 File Offset: 0x00176DA8
	private Material MLMKCOINOOH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C2F RID: 19503 RVA: 0x00178BDF File Offset: 0x00176DDF
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C30 RID: 19504 RVA: 0x00178503 File Offset: 0x00176703
	private void AMHEJBMLFNM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C31 RID: 19505 RVA: 0x00178C18 File Offset: 0x00176E18
	private void Update()
	{
		if (this.HODDOPANHAO != this.Preset)
		{
			this.HODDOPANHAO = this.Preset;
			float[] array = new float[]
			{
				0.757f,
				0.098f,
				0.458f,
				-2.49f,
				0.559f,
				-0.298f,
				1.202f,
				0.515f,
				1f,
				0f,
				0f,
				0f
			};
			float[] array2 = new float[]
			{
				0.2f,
				0.202f,
				0.68f,
				-1.49f,
				0.084f,
				-0.019f,
				2f,
				0.166f,
				1.948f,
				-0.1f,
				0.15f,
				-0.07f
			};
			float[] array3 = new float[]
			{
				1.45f,
				0.01f,
				0.112f,
				-0.07f,
				0.111f,
				-0.077f,
				0.071f,
				0f,
				0.245f,
				0f,
				0f,
				0f
			};
			float[] array4 = new float[]
			{
				0.779f,
				0.185f,
				0.706f,
				1.21f,
				0.24f,
				0.138f,
				2f,
				0.07f,
				1.224f,
				-0.21f,
				-0.34f,
				0f
			};
			float[] array5 = new float[]
			{
				0.2f,
				0.028f,
				0.706f,
				1.21f,
				0.397f,
				-0.24f,
				2f,
				0.298f,
				1.224f,
				-0.08f,
				0.48f,
				-0.57f
			};
			float[] array6 = new float[]
			{
				0.2f,
				0.159f,
				0.622f,
				-2.28f,
				0.409f,
				-0.24f,
				0.166f,
				0.028f,
				2f,
				-0.08f,
				0.22f,
				0.57f
			};
			float[] array7 = new float[]
			{
				2f,
				0.054f,
				1f,
				-2.28f,
				0.409f,
				-1f,
				2f,
				0.187f,
				0.241f,
				0f,
				1.58f,
				0.21f
			};
			float[] array8 = new float[]
			{
				2f,
				0.054f,
				1f,
				1.28f,
				0.409f,
				-1f,
				0.41f,
				0.656f,
				0.427f,
				0.95f,
				-0.35f,
				1.41f
			};
			float[] array9 = new float[]
			{
				2f,
				0.281f,
				0.156f,
				1.85f,
				0.709f,
				-1f,
				0.41f,
				0.109f,
				0.34f,
				0.95f,
				0.36f,
				-0.14f
			};
			float[] array10 = new float[]
			{
				0.905f,
				0.281f,
				0.156f,
				1.85f,
				0.558f,
				-0.974f,
				1.639f,
				0.252f,
				1.074f,
				0.46f,
				0.95f,
				0.58f
			};
			float[] array11 = new float[12];
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array11 = array;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array11 = array2;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Full)
			{
				array11 = array3;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Dark)
			{
				array11 = array4;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Sharp)
			{
				array11 = array5;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_BlueSky)
			{
				array11 = array6;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Low_Light)
			{
				array11 = array7;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Pinky)
			{
				array11 = array8;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_RedBurn)
			{
				array11 = array9;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_PurpleShadow)
			{
				array11 = array10;
			}
			if (this.Preset != CameraFilterPack_NightVisionFX.preset.Night_Vision_Personalized)
			{
				this.Greenness = array11[0];
				this.Vignette = array11[1];
				this.Vignette_Alpha = array11[2];
				this.Distortion = array11[3];
				this.Noise = array11[4];
				this.Intensity = array11[5];
				this.Light = array11[6];
				this.Light2 = array11[7];
				this.Line = array11[8];
				this.Color_R = array11[9];
				this.Color_G = array11[10];
				this.Color_B = array11[11];
			}
		}
	}

	// Token: 0x06004C32 RID: 19506 RVA: 0x00178E34 File Offset: 0x00177034
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1880f)
			{
				this.HBJJOCHGOPH = 1299f;
			}
			this.KBOPGONOCNP().SetFloat("[MapEditor] Updating top menu", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat(" on effect ", this.OnOff);
			this.MCDGIILBNIF().SetFloat("_Line", this.Greenness);
			this.MLMKCOINOOH().SetFloat(" (inactive)", this.Vignette);
			this.NBPKMLMCHFN.SetFloat("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ", this.Vignette_Alpha);
			this.OIMMPLPBLBK().SetFloat(",", this.Distortion);
			this.MCDGIILBNIF().SetFloat("\n", this.Noise);
			this.DKNJGHFLAIF().SetFloat("Command not found!", this.Intensity);
			this.HKGAONMOBMH().SetFloat("CameraFilterPack/Light_Rainbow", this.Light);
			this.DEFBJOCJJKF().SetFloat("FinalScoreText", this.Light2);
			this.DOHGBNPMBKG().SetFloat("LevelInfoInputField", this.Line);
			this.GJHLADDCMFF().SetFloat("PublishButton", this.Color_R);
			this.DOHGBNPMBKG().SetFloat("CameraFilterPack_TV_Noise2", this.Color_G);
			this.DEFBJOCJJKF().SetFloat("menu.relaxinfo", this.Color_B);
			this.IONHGBPGCHK().SetFloat("closed", this._Binocular_Size);
			this.MLMKCOINOOH().SetFloat("_ScreenResolution", this._Binocular_Dist);
			this.LENEJAGLCNL().SetFloat("_Value9", this._Binocular_Smooth);
			this.GJHLADDCMFF().SetVector("?", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C33 RID: 19507 RVA: 0x00179034 File Offset: 0x00177234
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C34 RID: 19508 RVA: 0x00178503 File Offset: 0x00176703
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C35 RID: 19509 RVA: 0x0017906B File Offset: 0x0017726B
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)80;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C36 RID: 19510 RVA: 0x001790A4 File Offset: 0x001772A4
	private void IDIIELPAMCJ()
	{
		if (this.HODDOPANHAO != this.Preset)
		{
			this.HODDOPANHAO = this.Preset;
			float[] array = new float[-110];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-B9B8E8DB27999DD7D297759E2C0DB5F14CDC32B9).FieldHandle);
			float[] array2 = array;
			float[] array3 = new float[96];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-A49B234BAED1E521F4CC502150FB5CD960556BB7).FieldHandle);
			float[] array4 = array3;
			float[] array5 = new float[20];
			RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.$field-1BC81E84591291A507FFBB2389A425CDBC738E46).FieldHandle);
			float[] array6 = array5;
			float[] array7 = new float[-80];
			RuntimeHelpers.InitializeArray(array7, fieldof(<PrivateImplementationDetails>.$field-231A2B8BB20EA0E6A00B61ED86869E4AF38E568B).FieldHandle);
			float[] array8 = array7;
			float[] array9 = new float[44];
			RuntimeHelpers.InitializeArray(array9, fieldof(<PrivateImplementationDetails>.$field-344F35933DADC294755E40C6C3723DE2C4E5FD90).FieldHandle);
			float[] array10 = array9;
			float[] array11 = new float[-5];
			RuntimeHelpers.InitializeArray(array11, fieldof(<PrivateImplementationDetails>.$field-36D456C626B20C21AFD26F2ECDF45C1FB877A1CD).FieldHandle);
			float[] array12 = array11;
			float[] array13 = new float[47];
			RuntimeHelpers.InitializeArray(array13, fieldof(<PrivateImplementationDetails>.$field-175291D1FA3DEB078C2B51F363761FA287FE0D22).FieldHandle);
			float[] array14 = array13;
			float[] array15 = new float[-82];
			RuntimeHelpers.InitializeArray(array15, fieldof(<PrivateImplementationDetails>.$field-94D18A21349F54EE2CB44216F8FDA81F310F7D60).FieldHandle);
			float[] array16 = array15;
			float[] array17 = new float[71];
			RuntimeHelpers.InitializeArray(array17, fieldof(<PrivateImplementationDetails>.$field-2E0E90126C561F5AC67617705F5604DB9E5284A1).FieldHandle);
			float[] array18 = array17;
			float[] array19 = new float[-88];
			RuntimeHelpers.InitializeArray(array19, fieldof(<PrivateImplementationDetails>.$field-49201D55AB670A481AC262DF9FA3BD17F93DC9FD).FieldHandle);
			float[] array20 = array19;
			float[] array21 = new float[-30];
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array21 = array2;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array21 = array4;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Low_Light)
			{
				array21 = array6;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Sharp)
			{
				array21 = array8;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Sharp)
			{
				array21 = array10;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Pinky)
			{
				array21 = array12;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Dark)
			{
				array21 = array14;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array21 = array16;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Low_Light)
			{
				array21 = array18;
			}
			if (this.Preset == (CameraFilterPack_NightVisionFX.preset)(-58))
			{
				array21 = array20;
			}
			if (this.Preset != CameraFilterPack_NightVisionFX.preset.Night_Vision_Personalized)
			{
				this.Greenness = array21[1];
				this.Vignette = array21[0];
				this.Vignette_Alpha = array21[8];
				this.Distortion = array21[6];
				this.Noise = array21[3];
				this.Intensity = array21[1];
				this.Light = array21[7];
				this.Light2 = array21[5];
				this.Line = array21[0];
				this.Color_R = array21[-126];
				this.Color_G = array21[-116];
				this.Color_B = array21[-4];
			}
		}
	}

	// Token: 0x06004C37 RID: 19511 RVA: 0x001792C0 File Offset: 0x001774C0
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 767f)
			{
				this.HBJJOCHGOPH = 962f;
			}
			this.MCDGIILBNIF().SetFloat("float,10", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("mapselector.filter.favoriteonly", this.OnOff);
			this.MICHFGAOPKM().SetFloat("float,0", this.Greenness);
			this.DOHGBNPMBKG().SetFloat("AppID: {0}*** GameVersion: {1} PeerId: {2} ", this.Vignette);
			this.MCDGIILBNIF().SetFloat("quit", this.Vignette_Alpha);
			this.MICHFGAOPKM().SetFloat("ResetButton", this.Distortion);
			this.MICHFGAOPKM().SetFloat("_Offsets", this.Noise);
			this.GJHLADDCMFF().SetFloat("OK", this.Intensity);
			this.MICHFGAOPKM().SetFloat("Failed to 'GetKeyCode' for key: ", this.Light);
			this.KEMJNOMIPHN().SetFloat("0.00", this.Light2);
			this.GJHLADDCMFF().SetFloat("settings.volume.game", this.Line);
			this.GJHLADDCMFF().SetFloat("In Main Menu", this.Color_R);
			this.DEFBJOCJJKF().SetFloat("Save", this.Color_G);
			this.MCDGIILBNIF().SetFloat("0,2,true,0", this.Color_B);
			this.MICHFGAOPKM().SetFloat("Object ID. Case-Sensitive", this._Binocular_Size);
			this.IFMAPIDFNLI().SetFloat("_TimeX", this._Binocular_Dist);
			this.MLMKCOINOOH().SetFloat("NameText", this._Binocular_Smooth);
			this.LENEJAGLCNL().SetVector("Set sun audio input", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C38 RID: 19512 RVA: 0x001794C0 File Offset: 0x001776C0
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C39 RID: 19513 RVA: 0x001794F7 File Offset: 0x001776F7
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C3A RID: 19514 RVA: 0x00179530 File Offset: 0x00177730
	private void AAPKBNDHBLI()
	{
		if (this.HODDOPANHAO != this.Preset)
		{
			this.HODDOPANHAO = this.Preset;
			float[] array = new float[55];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-B9B8E8DB27999DD7D297759E2C0DB5F14CDC32B9).FieldHandle);
			float[] array2 = array;
			float[] array3 = new float[-46];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-A49B234BAED1E521F4CC502150FB5CD960556BB7).FieldHandle);
			float[] array4 = array3;
			float[] array5 = new float[-67];
			RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.$field-1BC81E84591291A507FFBB2389A425CDBC738E46).FieldHandle);
			float[] array6 = array5;
			float[] array7 = new float[-114];
			RuntimeHelpers.InitializeArray(array7, fieldof(<PrivateImplementationDetails>.$field-231A2B8BB20EA0E6A00B61ED86869E4AF38E568B).FieldHandle);
			float[] array8 = array7;
			float[] array9 = new float[56];
			RuntimeHelpers.InitializeArray(array9, fieldof(<PrivateImplementationDetails>.$field-344F35933DADC294755E40C6C3723DE2C4E5FD90).FieldHandle);
			float[] array10 = array9;
			float[] array11 = new float[123];
			RuntimeHelpers.InitializeArray(array11, fieldof(<PrivateImplementationDetails>.$field-36D456C626B20C21AFD26F2ECDF45C1FB877A1CD).FieldHandle);
			float[] array12 = array11;
			float[] array13 = new float[13];
			RuntimeHelpers.InitializeArray(array13, fieldof(<PrivateImplementationDetails>.$field-175291D1FA3DEB078C2B51F363761FA287FE0D22).FieldHandle);
			float[] array14 = array13;
			float[] array15 = new float[87];
			RuntimeHelpers.InitializeArray(array15, fieldof(<PrivateImplementationDetails>.$field-94D18A21349F54EE2CB44216F8FDA81F310F7D60).FieldHandle);
			float[] array16 = array15;
			float[] array17 = new float[80];
			RuntimeHelpers.InitializeArray(array17, fieldof(<PrivateImplementationDetails>.$field-2E0E90126C561F5AC67617705F5604DB9E5284A1).FieldHandle);
			float[] array18 = array17;
			float[] array19 = new float[-54];
			RuntimeHelpers.InitializeArray(array19, fieldof(<PrivateImplementationDetails>.$field-49201D55AB670A481AC262DF9FA3BD17F93DC9FD).FieldHandle);
			float[] array20 = array19;
			float[] array21 = new float[45];
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array21 = array2;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array21 = array4;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Pinky)
			{
				array21 = array6;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Full)
			{
				array21 = array8;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Low_Light)
			{
				array21 = array10;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array21 = array12;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Full)
			{
				array21 = array14;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Dark)
			{
				array21 = array16;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Dark)
			{
				array21 = array18;
			}
			if (this.Preset == (CameraFilterPack_NightVisionFX.preset)(-70))
			{
				array21 = array20;
			}
			if (this.Preset != CameraFilterPack_NightVisionFX.preset.Night_Vision_Personalized)
			{
				this.Greenness = array21[0];
				this.Vignette = array21[1];
				this.Vignette_Alpha = array21[5];
				this.Distortion = array21[7];
				this.Noise = array21[6];
				this.Intensity = array21[1];
				this.Light = array21[1];
				this.Light2 = array21[5];
				this.Line = array21[0];
				this.Color_R = array21[-102];
				this.Color_G = array21[97];
				this.Color_B = array21[103];
			}
		}
	}

	// Token: 0x06004C3B RID: 19515 RVA: 0x00178503 File Offset: 0x00176703
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C3C RID: 19516 RVA: 0x0017974A File Offset: 0x0017794A
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("float,40");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004C3D RID: 19517 RVA: 0x0017976E File Offset: 0x0017796E
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("shader.pixel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004C3E RID: 19518 RVA: 0x00179792 File Offset: 0x00177992
	private void JKBMKPDGCHG()
	{
		this.SCShader = Shader.Find("LB");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004C3F RID: 19519 RVA: 0x001797B6 File Offset: 0x001779B6
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("_CameraClipInfo");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004C40 RID: 19520 RVA: 0x001797DC File Offset: 0x001779DC
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 795f)
			{
				this.HBJJOCHGOPH = 1833f;
			}
			this.DKNJGHFLAIF().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("[ItemsHandler] Loading Steam inventory", this.OnOff);
			this.IFMAPIDFNLI().SetFloat("Have you fully accept the terms?", this.Greenness);
			this.EOCCJGIGEGJ().SetFloat("_Value8", this.Vignette);
			this.LENEJAGLCNL().SetFloat("_SphereSize", this.Vignette_Alpha);
			this.KBOPGONOCNP().SetFloat("_Blurred", this.Distortion);
			this.HKGAONMOBMH().SetFloat("JoinRoom failed. In offline mode you still have to leave a room to enter another.", this.Noise);
			this.IONHGBPGCHK().SetFloat("(master)", this.Intensity);
			this.MCDGIILBNIF().SetFloat("IconImage", this.Light);
			this.NBPKMLMCHFN.SetFloat("clear", this.Light2);
			this.NBPKMLMCHFN.SetFloat("_Value", this.Line);
			this.NBPKMLMCHFN.SetFloat("EventSystem", this.Color_R);
			this.IFMAPIDFNLI().SetFloat("Fade", this.Color_G);
			this.MLMKCOINOOH().SetFloat("Rap", this.Color_B);
			this.DKNJGHFLAIF().SetFloat("PunPickupSimple", this._Binocular_Size);
			this.DKNJGHFLAIF().SetFloat("OxOD.lastPath", this._Binocular_Dist);
			this.MLMKCOINOOH().SetFloat("\n", this._Binocular_Smooth);
			this.NBPKMLMCHFN.SetVector("settings_bindings_controller_type", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C41 RID: 19521 RVA: 0x00178503 File Offset: 0x00176703
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C42 RID: 19522 RVA: 0x001799DC File Offset: 0x00177BDC
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("Misses:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004C43 RID: 19523 RVA: 0x00179A00 File Offset: 0x00177C00
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 244f)
			{
				this.HBJJOCHGOPH = 1406f;
			}
			this.KEMJNOMIPHN().SetFloat("player.redabstract", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("DPADVER", this.OnOff);
			this.DKNJGHFLAIF().SetFloat("_Value", this.Greenness);
			this.KEMJNOMIPHN().SetFloat("_Value2", this.Vignette);
			this.DOHGBNPMBKG().SetFloat("ViewMenu", this.Vignette_Alpha);
			this.DKNJGHFLAIF().SetFloat("menu.enableselectormusic", this.Distortion);
			this.MICHFGAOPKM().SetFloat("  |  Events Count: ", this.Noise);
			this.HKGAONMOBMH().SetFloat("Using constructor for new PingNativeStatic()", this.Intensity);
			this.IONHGBPGCHK().SetFloat(". The RPC has been ignored.", this.Light);
			this.NBPKMLMCHFN.SetFloat("bad", this.Light2);
			this.IFMAPIDFNLI().SetFloat("_BlendTex", this.Line);
			this.KBOPGONOCNP().SetFloat("BitsData", this.Color_R);
			this.OIMMPLPBLBK().SetFloat("CameraFilterPack/Drawing_Toon", this.Color_G);
			this.MICHFGAOPKM().SetFloat("ShadersToggle", this.Color_B);
			this.LENEJAGLCNL().SetFloat("Tab2Content", this._Binocular_Size);
			this.LENEJAGLCNL().SetFloat("...", this._Binocular_Dist);
			this.HKGAONMOBMH().SetFloat("BitsData", this._Binocular_Smooth);
			this.HKGAONMOBMH().SetVector("_Red_B", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C44 RID: 19524 RVA: 0x00179C00 File Offset: 0x00177E00
	private void IIFCIDDJHPM()
	{
		if (this.HODDOPANHAO != this.Preset)
		{
			this.HODDOPANHAO = this.Preset;
			float[] array = new float[103];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-B9B8E8DB27999DD7D297759E2C0DB5F14CDC32B9).FieldHandle);
			float[] array2 = array;
			float[] array3 = new float[-5];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-A49B234BAED1E521F4CC502150FB5CD960556BB7).FieldHandle);
			float[] array4 = array3;
			float[] array5 = new float[]
			{
				1.45f,
				0.01f,
				0.112f
			};
			float[] array6 = new float[126];
			RuntimeHelpers.InitializeArray(array6, fieldof(<PrivateImplementationDetails>.$field-231A2B8BB20EA0E6A00B61ED86869E4AF38E568B).FieldHandle);
			float[] array7 = array6;
			float[] array8 = new float[-35];
			RuntimeHelpers.InitializeArray(array8, fieldof(<PrivateImplementationDetails>.$field-344F35933DADC294755E40C6C3723DE2C4E5FD90).FieldHandle);
			float[] array9 = array8;
			float[] array10 = new float[79];
			RuntimeHelpers.InitializeArray(array10, fieldof(<PrivateImplementationDetails>.$field-36D456C626B20C21AFD26F2ECDF45C1FB877A1CD).FieldHandle);
			float[] array11 = array10;
			float[] array12 = new float[50];
			RuntimeHelpers.InitializeArray(array12, fieldof(<PrivateImplementationDetails>.$field-175291D1FA3DEB078C2B51F363761FA287FE0D22).FieldHandle);
			float[] array13 = array12;
			float[] array14 = new float[-2];
			RuntimeHelpers.InitializeArray(array14, fieldof(<PrivateImplementationDetails>.$field-94D18A21349F54EE2CB44216F8FDA81F310F7D60).FieldHandle);
			float[] array15 = array14;
			float[] array16 = new float[59];
			RuntimeHelpers.InitializeArray(array16, fieldof(<PrivateImplementationDetails>.$field-2E0E90126C561F5AC67617705F5604DB9E5284A1).FieldHandle);
			float[] array17 = array16;
			float[] array18 = new float[43];
			RuntimeHelpers.InitializeArray(array18, fieldof(<PrivateImplementationDetails>.$field-49201D55AB670A481AC262DF9FA3BD17F93DC9FD).FieldHandle);
			float[] array19 = array18;
			float[] array20 = new float[-23];
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array20 = array2;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array20 = array4;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_BlueSky)
			{
				array20 = array5;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_BlueSky)
			{
				array20 = array7;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array20 = array9;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Pinky)
			{
				array20 = array11;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array20 = array13;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Pinky)
			{
				array20 = array15;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array20 = array17;
			}
			if (this.Preset == (CameraFilterPack_NightVisionFX.preset)96)
			{
				array20 = array19;
			}
			if (this.Preset != CameraFilterPack_NightVisionFX.preset.Night_Vision_Personalized)
			{
				this.Greenness = array20[0];
				this.Vignette = array20[1];
				this.Vignette_Alpha = array20[4];
				this.Distortion = array20[6];
				this.Noise = array20[0];
				this.Intensity = array20[5];
				this.Light = array20[2];
				this.Light2 = array20[8];
				this.Line = array20[6];
				this.Color_R = array20[-48];
				this.Color_G = array20[52];
				this.Color_B = array20[-127];
			}
		}
	}

	// Token: 0x06004C45 RID: 19525 RVA: 0x00179E1A File Offset: 0x0017801A
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("_Near");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004C46 RID: 19526 RVA: 0x00178503 File Offset: 0x00176703
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C47 RID: 19527 RVA: 0x00179E3E File Offset: 0x0017803E
	private void JDKHBGDEONK()
	{
		this.SCShader = Shader.Find("float,0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004C48 RID: 19528 RVA: 0x00179E62 File Offset: 0x00178062
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("sfxVolume");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004C49 RID: 19529 RVA: 0x00179E88 File Offset: 0x00178088
	private void HNDNDPECBPL()
	{
		if (this.HODDOPANHAO != this.Preset)
		{
			this.HODDOPANHAO = this.Preset;
			float[] array = new float[-39];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-B9B8E8DB27999DD7D297759E2C0DB5F14CDC32B9).FieldHandle);
			float[] array2 = array;
			float[] array3 = new float[24];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-A49B234BAED1E521F4CC502150FB5CD960556BB7).FieldHandle);
			float[] array4 = array3;
			float[] array5 = new float[110];
			RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.$field-1BC81E84591291A507FFBB2389A425CDBC738E46).FieldHandle);
			float[] array6 = array5;
			float[] array7 = new float[-66];
			RuntimeHelpers.InitializeArray(array7, fieldof(<PrivateImplementationDetails>.$field-231A2B8BB20EA0E6A00B61ED86869E4AF38E568B).FieldHandle);
			float[] array8 = array7;
			float[] array9 = new float[103];
			RuntimeHelpers.InitializeArray(array9, fieldof(<PrivateImplementationDetails>.$field-344F35933DADC294755E40C6C3723DE2C4E5FD90).FieldHandle);
			float[] array10 = array9;
			float[] array11 = new float[-74];
			RuntimeHelpers.InitializeArray(array11, fieldof(<PrivateImplementationDetails>.$field-36D456C626B20C21AFD26F2ECDF45C1FB877A1CD).FieldHandle);
			float[] array12 = array11;
			float[] array13 = new float[-28];
			RuntimeHelpers.InitializeArray(array13, fieldof(<PrivateImplementationDetails>.$field-175291D1FA3DEB078C2B51F363761FA287FE0D22).FieldHandle);
			float[] array14 = array13;
			float[] array15 = new float[-34];
			RuntimeHelpers.InitializeArray(array15, fieldof(<PrivateImplementationDetails>.$field-94D18A21349F54EE2CB44216F8FDA81F310F7D60).FieldHandle);
			float[] array16 = array15;
			float[] array17 = new float[91];
			RuntimeHelpers.InitializeArray(array17, fieldof(<PrivateImplementationDetails>.$field-2E0E90126C561F5AC67617705F5604DB9E5284A1).FieldHandle);
			float[] array18 = array17;
			float[] array19 = new float[-77];
			RuntimeHelpers.InitializeArray(array19, fieldof(<PrivateImplementationDetails>.$field-49201D55AB670A481AC262DF9FA3BD17F93DC9FD).FieldHandle);
			float[] array20 = array19;
			float[] array21 = new float[27];
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array21 = array2;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array21 = array4;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Dark)
			{
				array21 = array6;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Dark)
			{
				array21 = array8;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Full)
			{
				array21 = array10;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Full)
			{
				array21 = array12;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Sharp)
			{
				array21 = array14;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array21 = array16;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array21 = array18;
			}
			if (this.Preset == (CameraFilterPack_NightVisionFX.preset)15)
			{
				array21 = array20;
			}
			if (this.Preset != CameraFilterPack_NightVisionFX.preset.Night_Vision_Personalized)
			{
				this.Greenness = array21[0];
				this.Vignette = array21[1];
				this.Vignette_Alpha = array21[3];
				this.Distortion = array21[1];
				this.Noise = array21[5];
				this.Intensity = array21[8];
				this.Light = array21[4];
				this.Light2 = array21[4];
				this.Line = array21[6];
				this.Color_R = array21[42];
				this.Color_G = array21[-36];
				this.Color_B = array21[24];
			}
		}
	}

	// Token: 0x06004C4A RID: 19530 RVA: 0x0017A0A2 File Offset: 0x001782A2
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004C4B RID: 19531 RVA: 0x0017A0C6 File Offset: 0x001782C6
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("Updated!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x170000DB RID: 219
	// (get) Token: 0x06004C4C RID: 19532 RVA: 0x0017A0EA File Offset: 0x001782EA
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

	// Token: 0x06004C4D RID: 19533 RVA: 0x00178503 File Offset: 0x00176703
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C4E RID: 19534 RVA: 0x00178503 File Offset: 0x00176703
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C4F RID: 19535 RVA: 0x00178503 File Offset: 0x00176703
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C50 RID: 19536 RVA: 0x00178503 File Offset: 0x00176703
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C51 RID: 19537 RVA: 0x0017A124 File Offset: 0x00178324
	private void AGMJDGHLBMN()
	{
		if (this.HODDOPANHAO != this.Preset)
		{
			this.HODDOPANHAO = this.Preset;
			float[] array = new float[-71];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-B9B8E8DB27999DD7D297759E2C0DB5F14CDC32B9).FieldHandle);
			float[] array2 = array;
			float[] array3 = new float[-117];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-A49B234BAED1E521F4CC502150FB5CD960556BB7).FieldHandle);
			float[] array4 = array3;
			float[] array5 = new float[-23];
			RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.$field-1BC81E84591291A507FFBB2389A425CDBC738E46).FieldHandle);
			float[] array6 = array5;
			float[] array7 = new float[42];
			RuntimeHelpers.InitializeArray(array7, fieldof(<PrivateImplementationDetails>.$field-231A2B8BB20EA0E6A00B61ED86869E4AF38E568B).FieldHandle);
			float[] array8 = array7;
			float[] array9 = new float[-86];
			RuntimeHelpers.InitializeArray(array9, fieldof(<PrivateImplementationDetails>.$field-344F35933DADC294755E40C6C3723DE2C4E5FD90).FieldHandle);
			float[] array10 = array9;
			float[] array11 = new float[36];
			RuntimeHelpers.InitializeArray(array11, fieldof(<PrivateImplementationDetails>.$field-36D456C626B20C21AFD26F2ECDF45C1FB877A1CD).FieldHandle);
			float[] array12 = array11;
			float[] array13 = new float[100];
			RuntimeHelpers.InitializeArray(array13, fieldof(<PrivateImplementationDetails>.$field-175291D1FA3DEB078C2B51F363761FA287FE0D22).FieldHandle);
			float[] array14 = array13;
			float[] array15 = new float[65];
			RuntimeHelpers.InitializeArray(array15, fieldof(<PrivateImplementationDetails>.$field-94D18A21349F54EE2CB44216F8FDA81F310F7D60).FieldHandle);
			float[] array16 = array15;
			float[] array17 = new float[91];
			RuntimeHelpers.InitializeArray(array17, fieldof(<PrivateImplementationDetails>.$field-2E0E90126C561F5AC67617705F5604DB9E5284A1).FieldHandle);
			float[] array18 = array17;
			float[] array19 = new float[-15];
			RuntimeHelpers.InitializeArray(array19, fieldof(<PrivateImplementationDetails>.$field-49201D55AB670A481AC262DF9FA3BD17F93DC9FD).FieldHandle);
			float[] array20 = array19;
			float[] array21 = new float[-28];
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array21 = array2;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array21 = array4;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_RedBurn)
			{
				array21 = array6;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Dark)
			{
				array21 = array8;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Pinky)
			{
				array21 = array10;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_RedBurn)
			{
				array21 = array12;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_RedBurn)
			{
				array21 = array14;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array21 = array16;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Low_Light)
			{
				array21 = array18;
			}
			if (this.Preset == (CameraFilterPack_NightVisionFX.preset)36)
			{
				array21 = array20;
			}
			if (this.Preset != CameraFilterPack_NightVisionFX.preset.Night_Vision_Personalized)
			{
				this.Greenness = array21[1];
				this.Vignette = array21[1];
				this.Vignette_Alpha = array21[4];
				this.Distortion = array21[0];
				this.Noise = array21[5];
				this.Intensity = array21[8];
				this.Light = array21[7];
				this.Light2 = array21[8];
				this.Line = array21[4];
				this.Color_R = array21[82];
				this.Color_G = array21[91];
				this.Color_B = array21[-111];
			}
		}
	}

	// Token: 0x06004C52 RID: 19538 RVA: 0x0017A33E File Offset: 0x0017853E
	private void ODBNMPGBCGO()
	{
		this.SCShader = Shader.Find("Scale environment object by the values");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004C53 RID: 19539 RVA: 0x0017A364 File Offset: 0x00178564
	private void FOLDLDLFFLM()
	{
		if (this.HODDOPANHAO != this.Preset)
		{
			this.HODDOPANHAO = this.Preset;
			float[] array = new float[65];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-B9B8E8DB27999DD7D297759E2C0DB5F14CDC32B9).FieldHandle);
			float[] array2 = array;
			float[] array3 = new float[76];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-A49B234BAED1E521F4CC502150FB5CD960556BB7).FieldHandle);
			float[] array4 = array3;
			float[] array5 = new float[34];
			RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.$field-1BC81E84591291A507FFBB2389A425CDBC738E46).FieldHandle);
			float[] array6 = array5;
			float[] array7 = new float[-116];
			RuntimeHelpers.InitializeArray(array7, fieldof(<PrivateImplementationDetails>.$field-231A2B8BB20EA0E6A00B61ED86869E4AF38E568B).FieldHandle);
			float[] array8 = array7;
			float[] array9 = new float[-1];
			RuntimeHelpers.InitializeArray(array9, fieldof(<PrivateImplementationDetails>.$field-344F35933DADC294755E40C6C3723DE2C4E5FD90).FieldHandle);
			float[] array10 = array9;
			float[] array11 = new float[68];
			RuntimeHelpers.InitializeArray(array11, fieldof(<PrivateImplementationDetails>.$field-36D456C626B20C21AFD26F2ECDF45C1FB877A1CD).FieldHandle);
			float[] array12 = array11;
			float[] array13 = new float[32];
			RuntimeHelpers.InitializeArray(array13, fieldof(<PrivateImplementationDetails>.$field-175291D1FA3DEB078C2B51F363761FA287FE0D22).FieldHandle);
			float[] array14 = array13;
			float[] array15 = new float[-107];
			RuntimeHelpers.InitializeArray(array15, fieldof(<PrivateImplementationDetails>.$field-94D18A21349F54EE2CB44216F8FDA81F310F7D60).FieldHandle);
			float[] array16 = array15;
			float[] array17 = new float[-106];
			RuntimeHelpers.InitializeArray(array17, fieldof(<PrivateImplementationDetails>.$field-2E0E90126C561F5AC67617705F5604DB9E5284A1).FieldHandle);
			float[] array18 = array17;
			float[] array19 = new float[-107];
			RuntimeHelpers.InitializeArray(array19, fieldof(<PrivateImplementationDetails>.$field-49201D55AB670A481AC262DF9FA3BD17F93DC9FD).FieldHandle);
			float[] array20 = array19;
			float[] array21 = new float[-82];
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array21 = array2;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array21 = array4;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Dark)
			{
				array21 = array6;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Pinky)
			{
				array21 = array8;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Pinky)
			{
				array21 = array10;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_BlueSky)
			{
				array21 = array12;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array21 = array14;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Dark)
			{
				array21 = array16;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_RedBurn)
			{
				array21 = array18;
			}
			if (this.Preset == (CameraFilterPack_NightVisionFX.preset)89)
			{
				array21 = array20;
			}
			if (this.Preset != CameraFilterPack_NightVisionFX.preset.Night_Vision_Personalized)
			{
				this.Greenness = array21[0];
				this.Vignette = array21[0];
				this.Vignette_Alpha = array21[2];
				this.Distortion = array21[6];
				this.Noise = array21[4];
				this.Intensity = array21[0];
				this.Light = array21[3];
				this.Light2 = array21[4];
				this.Line = array21[4];
				this.Color_R = array21[-20];
				this.Color_G = array21[2];
				this.Color_B = array21[41];
			}
		}
	}

	// Token: 0x06004C54 RID: 19540 RVA: 0x0017A580 File Offset: 0x00178780
	private void KCDOMIJBFLL()
	{
		if (this.HODDOPANHAO != this.Preset)
		{
			this.HODDOPANHAO = this.Preset;
			float[] array = new float[-9];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-B9B8E8DB27999DD7D297759E2C0DB5F14CDC32B9).FieldHandle);
			float[] array2 = array;
			float[] array3 = new float[-60];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-A49B234BAED1E521F4CC502150FB5CD960556BB7).FieldHandle);
			float[] array4 = array3;
			float[] array5 = new float[82];
			RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.$field-1BC81E84591291A507FFBB2389A425CDBC738E46).FieldHandle);
			float[] array6 = array5;
			float[] array7 = new float[-21];
			RuntimeHelpers.InitializeArray(array7, fieldof(<PrivateImplementationDetails>.$field-231A2B8BB20EA0E6A00B61ED86869E4AF38E568B).FieldHandle);
			float[] array8 = array7;
			float[] array9 = new float[-44];
			RuntimeHelpers.InitializeArray(array9, fieldof(<PrivateImplementationDetails>.$field-344F35933DADC294755E40C6C3723DE2C4E5FD90).FieldHandle);
			float[] array10 = array9;
			float[] array11 = new float[37];
			RuntimeHelpers.InitializeArray(array11, fieldof(<PrivateImplementationDetails>.$field-36D456C626B20C21AFD26F2ECDF45C1FB877A1CD).FieldHandle);
			float[] array12 = array11;
			float[] array13 = new float[-108];
			RuntimeHelpers.InitializeArray(array13, fieldof(<PrivateImplementationDetails>.$field-175291D1FA3DEB078C2B51F363761FA287FE0D22).FieldHandle);
			float[] array14 = array13;
			float[] array15 = new float[65];
			RuntimeHelpers.InitializeArray(array15, fieldof(<PrivateImplementationDetails>.$field-94D18A21349F54EE2CB44216F8FDA81F310F7D60).FieldHandle);
			float[] array16 = array15;
			float[] array17 = new float[75];
			RuntimeHelpers.InitializeArray(array17, fieldof(<PrivateImplementationDetails>.$field-2E0E90126C561F5AC67617705F5604DB9E5284A1).FieldHandle);
			float[] array18 = array17;
			float[] array19 = new float[-33];
			RuntimeHelpers.InitializeArray(array19, fieldof(<PrivateImplementationDetails>.$field-49201D55AB670A481AC262DF9FA3BD17F93DC9FD).FieldHandle);
			float[] array20 = array19;
			float[] array21 = new float[-55];
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array21 = array2;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array21 = array4;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_BlueSky)
			{
				array21 = array6;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array21 = array8;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Pinky)
			{
				array21 = array10;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Pinky)
			{
				array21 = array12;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Pinky)
			{
				array21 = array14;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_RedBurn)
			{
				array21 = array16;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Low_Light)
			{
				array21 = array18;
			}
			if (this.Preset == (CameraFilterPack_NightVisionFX.preset)46)
			{
				array21 = array20;
			}
			if (this.Preset != CameraFilterPack_NightVisionFX.preset.Night_Vision_Personalized)
			{
				this.Greenness = array21[1];
				this.Vignette = array21[1];
				this.Vignette_Alpha = array21[5];
				this.Distortion = array21[2];
				this.Noise = array21[0];
				this.Intensity = array21[8];
				this.Light = array21[7];
				this.Light2 = array21[0];
				this.Line = array21[3];
				this.Color_R = array21[8];
				this.Color_G = array21[50];
				this.Color_B = array21[-25];
			}
		}
	}

	// Token: 0x06004C55 RID: 19541 RVA: 0x0017A79C File Offset: 0x0017899C
	private void EGEGNHLODAA()
	{
		if (this.HODDOPANHAO != this.Preset)
		{
			this.HODDOPANHAO = this.Preset;
			float[] array = new float[-64];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-B9B8E8DB27999DD7D297759E2C0DB5F14CDC32B9).FieldHandle);
			float[] array2 = array;
			float[] array3 = new float[-13];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-A49B234BAED1E521F4CC502150FB5CD960556BB7).FieldHandle);
			float[] array4 = array3;
			float[] array5 = new float[-6];
			RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.$field-1BC81E84591291A507FFBB2389A425CDBC738E46).FieldHandle);
			float[] array6 = array5;
			float[] array7 = new float[63];
			RuntimeHelpers.InitializeArray(array7, fieldof(<PrivateImplementationDetails>.$field-231A2B8BB20EA0E6A00B61ED86869E4AF38E568B).FieldHandle);
			float[] array8 = array7;
			float[] array9 = new float[70];
			RuntimeHelpers.InitializeArray(array9, fieldof(<PrivateImplementationDetails>.$field-344F35933DADC294755E40C6C3723DE2C4E5FD90).FieldHandle);
			float[] array10 = array9;
			float[] array11 = new float[57];
			RuntimeHelpers.InitializeArray(array11, fieldof(<PrivateImplementationDetails>.$field-36D456C626B20C21AFD26F2ECDF45C1FB877A1CD).FieldHandle);
			float[] array12 = array11;
			float[] array13 = new float[84];
			RuntimeHelpers.InitializeArray(array13, fieldof(<PrivateImplementationDetails>.$field-175291D1FA3DEB078C2B51F363761FA287FE0D22).FieldHandle);
			float[] array14 = array13;
			float[] array15 = new float[-7];
			RuntimeHelpers.InitializeArray(array15, fieldof(<PrivateImplementationDetails>.$field-94D18A21349F54EE2CB44216F8FDA81F310F7D60).FieldHandle);
			float[] array16 = array15;
			float[] array17 = new float[-60];
			RuntimeHelpers.InitializeArray(array17, fieldof(<PrivateImplementationDetails>.$field-2E0E90126C561F5AC67617705F5604DB9E5284A1).FieldHandle);
			float[] array18 = array17;
			float[] array19 = new float[-105];
			RuntimeHelpers.InitializeArray(array19, fieldof(<PrivateImplementationDetails>.$field-49201D55AB670A481AC262DF9FA3BD17F93DC9FD).FieldHandle);
			float[] array20 = array19;
			float[] array21 = new float[59];
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array21 = array2;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array21 = array4;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Dark)
			{
				array21 = array6;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array21 = array8;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Full)
			{
				array21 = array10;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array21 = array12;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Sharp)
			{
				array21 = array14;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Dark)
			{
				array21 = array16;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Pinky)
			{
				array21 = array18;
			}
			if (this.Preset == (CameraFilterPack_NightVisionFX.preset)(-86))
			{
				array21 = array20;
			}
			if (this.Preset != CameraFilterPack_NightVisionFX.preset.Night_Vision_Personalized)
			{
				this.Greenness = array21[0];
				this.Vignette = array21[0];
				this.Vignette_Alpha = array21[6];
				this.Distortion = array21[5];
				this.Noise = array21[7];
				this.Intensity = array21[4];
				this.Light = array21[8];
				this.Light2 = array21[8];
				this.Line = array21[4];
				this.Color_R = array21[-105];
				this.Color_G = array21[40];
				this.Color_B = array21[76];
			}
		}
	}

	// Token: 0x06004C56 RID: 19542 RVA: 0x0017A9B8 File Offset: 0x00178BB8
	private void OEENOOGEEHD()
	{
		if (this.HODDOPANHAO != this.Preset)
		{
			this.HODDOPANHAO = this.Preset;
			float[] array = new float[88];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-B9B8E8DB27999DD7D297759E2C0DB5F14CDC32B9).FieldHandle);
			float[] array2 = array;
			float[] array3 = new float[-19];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-A49B234BAED1E521F4CC502150FB5CD960556BB7).FieldHandle);
			float[] array4 = array3;
			float[] array5 = new float[22];
			RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.$field-1BC81E84591291A507FFBB2389A425CDBC738E46).FieldHandle);
			float[] array6 = array5;
			float[] array7 = new float[58];
			RuntimeHelpers.InitializeArray(array7, fieldof(<PrivateImplementationDetails>.$field-231A2B8BB20EA0E6A00B61ED86869E4AF38E568B).FieldHandle);
			float[] array8 = array7;
			float[] array9 = new float[-112];
			RuntimeHelpers.InitializeArray(array9, fieldof(<PrivateImplementationDetails>.$field-344F35933DADC294755E40C6C3723DE2C4E5FD90).FieldHandle);
			float[] array10 = array9;
			float[] array11 = new float[-114];
			RuntimeHelpers.InitializeArray(array11, fieldof(<PrivateImplementationDetails>.$field-36D456C626B20C21AFD26F2ECDF45C1FB877A1CD).FieldHandle);
			float[] array12 = array11;
			float[] array13 = new float[41];
			RuntimeHelpers.InitializeArray(array13, fieldof(<PrivateImplementationDetails>.$field-175291D1FA3DEB078C2B51F363761FA287FE0D22).FieldHandle);
			float[] array14 = array13;
			float[] array15 = new float[-127];
			RuntimeHelpers.InitializeArray(array15, fieldof(<PrivateImplementationDetails>.$field-94D18A21349F54EE2CB44216F8FDA81F310F7D60).FieldHandle);
			float[] array16 = array15;
			float[] array17 = new float[-106];
			RuntimeHelpers.InitializeArray(array17, fieldof(<PrivateImplementationDetails>.$field-2E0E90126C561F5AC67617705F5604DB9E5284A1).FieldHandle);
			float[] array18 = array17;
			float[] array19 = new float[-98];
			RuntimeHelpers.InitializeArray(array19, fieldof(<PrivateImplementationDetails>.$field-49201D55AB670A481AC262DF9FA3BD17F93DC9FD).FieldHandle);
			float[] array20 = array19;
			float[] array21 = new float[-25];
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array21 = array2;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array21 = array4;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Full)
			{
				array21 = array6;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Full)
			{
				array21 = array8;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_BlueSky)
			{
				array21 = array10;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_BlueSky)
			{
				array21 = array12;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_RedBurn)
			{
				array21 = array14;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array21 = array16;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Full)
			{
				array21 = array18;
			}
			if (this.Preset == (CameraFilterPack_NightVisionFX.preset)(-125))
			{
				array21 = array20;
			}
			if (this.Preset != CameraFilterPack_NightVisionFX.preset.Night_Vision_Personalized)
			{
				this.Greenness = array21[0];
				this.Vignette = array21[1];
				this.Vignette_Alpha = array21[8];
				this.Distortion = array21[4];
				this.Noise = array21[4];
				this.Intensity = array21[7];
				this.Light = array21[3];
				this.Light2 = array21[6];
				this.Line = array21[1];
				this.Color_R = array21[-80];
				this.Color_G = array21[83];
				this.Color_B = array21[4];
			}
		}
	}

	// Token: 0x06004C57 RID: 19543 RVA: 0x0017ABD2 File Offset: 0x00178DD2
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find(" ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004C58 RID: 19544 RVA: 0x0017ABF8 File Offset: 0x00178DF8
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 495f)
			{
				this.HBJJOCHGOPH = 737f;
			}
			this.LENEJAGLCNL().SetFloat(" not exist", this.HBJJOCHGOPH);
			this.MLMKCOINOOH().SetFloat("SpawnObj", this.OnOff);
			this.KEMJNOMIPHN().SetFloat("1", this.Greenness);
			this.DEFBJOCJJKF().SetFloat("CameraFilterPack/EyesVision_1", this.Vignette);
			this.LENEJAGLCNL().SetFloat("Set satellite audio input", this.Vignette_Alpha);
			this.IONHGBPGCHK().SetFloat("_CameraWS", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("Select", this.Noise);
			this.DEFBJOCJJKF().SetFloat(" not exist", this.Intensity);
			this.EOCCJGIGEGJ().SetFloat(" not exist", this.Light);
			this.IFMAPIDFNLI().SetFloat("_ScreenResolution", this.Light2);
			this.LENEJAGLCNL().SetFloat("HandsCountSlider", this.Line);
			this.MICHFGAOPKM().SetFloat(": ", this.Color_R);
			this.MLMKCOINOOH().SetFloat("settings_bindings_controller_type", this.Color_G);
			this.OIMMPLPBLBK().SetFloat("_Value", this.Color_B);
			this.MCDGIILBNIF().SetFloat("EnableRankingToggle", this._Binocular_Size);
			this.DEFBJOCJJKF().SetFloat("Offline or in OfflineMode. No VitalStats available.", this._Binocular_Dist);
			this.DKNJGHFLAIF().SetFloat("Texture3", this._Binocular_Smooth);
			this.NBPKMLMCHFN.SetVector("mapselector.tags.", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C59 RID: 19545 RVA: 0x0017ADF8 File Offset: 0x00178FF8
	private void PMPKMGKAAJH()
	{
		this.SCShader = Shader.Find("_WorldToCameraMatrix");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004C5A RID: 19546 RVA: 0x0017AE1C File Offset: 0x0017901C
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find("AvatarImage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004C5B RID: 19547 RVA: 0x00178503 File Offset: 0x00176703
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C5C RID: 19548 RVA: 0x0017AE40 File Offset: 0x00179040
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C5D RID: 19549 RVA: 0x0017AE78 File Offset: 0x00179078
	private void KMEONPMCNJG()
	{
		if (this.HODDOPANHAO != this.Preset)
		{
			this.HODDOPANHAO = this.Preset;
			float[] array = new float[-19];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-B9B8E8DB27999DD7D297759E2C0DB5F14CDC32B9).FieldHandle);
			float[] array2 = array;
			float[] array3 = new float[-14];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-A49B234BAED1E521F4CC502150FB5CD960556BB7).FieldHandle);
			float[] array4 = array3;
			float[] array5 = new float[86];
			RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.$field-1BC81E84591291A507FFBB2389A425CDBC738E46).FieldHandle);
			float[] array6 = array5;
			float[] array7 = new float[48];
			RuntimeHelpers.InitializeArray(array7, fieldof(<PrivateImplementationDetails>.$field-231A2B8BB20EA0E6A00B61ED86869E4AF38E568B).FieldHandle);
			float[] array8 = array7;
			float[] array9 = new float[-68];
			RuntimeHelpers.InitializeArray(array9, fieldof(<PrivateImplementationDetails>.$field-344F35933DADC294755E40C6C3723DE2C4E5FD90).FieldHandle);
			float[] array10 = array9;
			float[] array11 = new float[80];
			RuntimeHelpers.InitializeArray(array11, fieldof(<PrivateImplementationDetails>.$field-36D456C626B20C21AFD26F2ECDF45C1FB877A1CD).FieldHandle);
			float[] array12 = array11;
			float[] array13 = new float[110];
			RuntimeHelpers.InitializeArray(array13, fieldof(<PrivateImplementationDetails>.$field-175291D1FA3DEB078C2B51F363761FA287FE0D22).FieldHandle);
			float[] array14 = array13;
			float[] array15 = new float[126];
			RuntimeHelpers.InitializeArray(array15, fieldof(<PrivateImplementationDetails>.$field-94D18A21349F54EE2CB44216F8FDA81F310F7D60).FieldHandle);
			float[] array16 = array15;
			float[] array17 = new float[-38];
			RuntimeHelpers.InitializeArray(array17, fieldof(<PrivateImplementationDetails>.$field-2E0E90126C561F5AC67617705F5604DB9E5284A1).FieldHandle);
			float[] array18 = array17;
			float[] array19 = new float[-81];
			RuntimeHelpers.InitializeArray(array19, fieldof(<PrivateImplementationDetails>.$field-49201D55AB670A481AC262DF9FA3BD17F93DC9FD).FieldHandle);
			float[] array20 = array19;
			float[] array21 = new float[69];
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array21 = array2;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array21 = array4;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Sharp)
			{
				array21 = array6;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Pinky)
			{
				array21 = array8;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Full)
			{
				array21 = array10;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array21 = array12;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Sharp)
			{
				array21 = array14;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array21 = array16;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Low_Light)
			{
				array21 = array18;
			}
			if (this.Preset == (CameraFilterPack_NightVisionFX.preset)(-2))
			{
				array21 = array20;
			}
			if (this.Preset != CameraFilterPack_NightVisionFX.preset.Night_Vision_Personalized)
			{
				this.Greenness = array21[1];
				this.Vignette = array21[0];
				this.Vignette_Alpha = array21[7];
				this.Distortion = array21[7];
				this.Noise = array21[4];
				this.Intensity = array21[0];
				this.Light = array21[6];
				this.Light2 = array21[8];
				this.Line = array21[3];
				this.Color_R = array21[12];
				this.Color_G = array21[42];
				this.Color_B = array21[-84];
			}
		}
	}

	// Token: 0x06004C5E RID: 19550 RVA: 0x0017B094 File Offset: 0x00179294
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
			this.NBPKMLMCHFN.SetFloat("_OnOff", this.OnOff);
			this.NBPKMLMCHFN.SetFloat("_Greenness", this.Greenness);
			this.NBPKMLMCHFN.SetFloat("_Vignette", this.Vignette);
			this.NBPKMLMCHFN.SetFloat("_Vignette_Alpha", this.Vignette_Alpha);
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("_Noise", this.Noise);
			this.NBPKMLMCHFN.SetFloat("_Intensity", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_Light", this.Light);
			this.NBPKMLMCHFN.SetFloat("_Light2", this.Light2);
			this.NBPKMLMCHFN.SetFloat("_Line", this.Line);
			this.NBPKMLMCHFN.SetFloat("_Color_R", this.Color_R);
			this.NBPKMLMCHFN.SetFloat("_Color_G", this.Color_G);
			this.NBPKMLMCHFN.SetFloat("_Color_B", this.Color_B);
			this.NBPKMLMCHFN.SetFloat("_Size", this._Binocular_Size);
			this.NBPKMLMCHFN.SetFloat("_Dist", this._Binocular_Dist);
			this.NBPKMLMCHFN.SetFloat("_Smooth", this._Binocular_Smooth);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C5F RID: 19551 RVA: 0x00178503 File Offset: 0x00176703
	private void MKFLBEGJJDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C60 RID: 19552 RVA: 0x0017B294 File Offset: 0x00179494
	private void PNLKFANNOKO()
	{
		if (this.HODDOPANHAO != this.Preset)
		{
			this.HODDOPANHAO = this.Preset;
			float[] array = new float[31];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-B9B8E8DB27999DD7D297759E2C0DB5F14CDC32B9).FieldHandle);
			float[] array2 = array;
			float[] array3 = new float[-25];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-A49B234BAED1E521F4CC502150FB5CD960556BB7).FieldHandle);
			float[] array4 = array3;
			float[] array5 = new float[]
			{
				1.45f,
				0.01f
			};
			float[] array6 = new float[-2];
			RuntimeHelpers.InitializeArray(array6, fieldof(<PrivateImplementationDetails>.$field-231A2B8BB20EA0E6A00B61ED86869E4AF38E568B).FieldHandle);
			float[] array7 = array6;
			float[] array8 = new float[-112];
			RuntimeHelpers.InitializeArray(array8, fieldof(<PrivateImplementationDetails>.$field-344F35933DADC294755E40C6C3723DE2C4E5FD90).FieldHandle);
			float[] array9 = array8;
			float[] array10 = new float[47];
			RuntimeHelpers.InitializeArray(array10, fieldof(<PrivateImplementationDetails>.$field-36D456C626B20C21AFD26F2ECDF45C1FB877A1CD).FieldHandle);
			float[] array11 = array10;
			float[] array12 = new float[68];
			RuntimeHelpers.InitializeArray(array12, fieldof(<PrivateImplementationDetails>.$field-175291D1FA3DEB078C2B51F363761FA287FE0D22).FieldHandle);
			float[] array13 = array12;
			float[] array14 = new float[-79];
			RuntimeHelpers.InitializeArray(array14, fieldof(<PrivateImplementationDetails>.$field-94D18A21349F54EE2CB44216F8FDA81F310F7D60).FieldHandle);
			float[] array15 = array14;
			float[] array16 = new float[73];
			RuntimeHelpers.InitializeArray(array16, fieldof(<PrivateImplementationDetails>.$field-2E0E90126C561F5AC67617705F5604DB9E5284A1).FieldHandle);
			float[] array17 = array16;
			float[] array18 = new float[-95];
			RuntimeHelpers.InitializeArray(array18, fieldof(<PrivateImplementationDetails>.$field-49201D55AB670A481AC262DF9FA3BD17F93DC9FD).FieldHandle);
			float[] array19 = array18;
			float[] array20 = new float[5];
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array20 = array2;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array20 = array4;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_BlueSky)
			{
				array20 = array5;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Low_Light)
			{
				array20 = array7;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array20 = array9;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_RedBurn)
			{
				array20 = array11;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array20 = array13;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array20 = array15;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_BlueSky)
			{
				array20 = array17;
			}
			if (this.Preset == (CameraFilterPack_NightVisionFX.preset)45)
			{
				array20 = array19;
			}
			if (this.Preset != CameraFilterPack_NightVisionFX.preset.Night_Vision_Personalized)
			{
				this.Greenness = array20[1];
				this.Vignette = array20[1];
				this.Vignette_Alpha = array20[4];
				this.Distortion = array20[8];
				this.Noise = array20[4];
				this.Intensity = array20[6];
				this.Light = array20[5];
				this.Light2 = array20[6];
				this.Line = array20[7];
				this.Color_R = array20[58];
				this.Color_G = array20[-105];
				this.Color_B = array20[40];
			}
		}
	}

	// Token: 0x06004C61 RID: 19553 RVA: 0x0017B4B0 File Offset: 0x001796B0
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1437f)
			{
				this.HBJJOCHGOPH = 1143f;
			}
			this.EOCCJGIGEGJ().SetFloat("CameraFilterPack/TV_Vintage", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat(".completed", this.OnOff);
			this.DEFBJOCJJKF().SetFloat("#,0.00", this.Greenness);
			this.OIMMPLPBLBK().SetFloat("_PositionX", this.Vignette);
			this.HKGAONMOBMH().SetFloat(" GO:", this.Vignette_Alpha);
			this.IONHGBPGCHK().SetFloat("_TimeX", this.Distortion);
			this.OIMMPLPBLBK().SetFloat("ItemNameBGImage", this.Noise);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Intensity);
			this.KEMJNOMIPHN().SetFloat("Move environment object to the position", this.Light);
			this.IFMAPIDFNLI().SetFloat("_Value2", this.Light2);
			this.EOCCJGIGEGJ().SetFloat("player.redlifering", this.Line);
			this.DEFBJOCJJKF().SetFloat("Lerp speed. Recomended 10", this.Color_R);
			this.DOHGBNPMBKG().SetFloat("maps.", this.Color_G);
			this.MCDGIILBNIF().SetFloat("Missing shader in ", this.Color_B);
			this.DOHGBNPMBKG().SetFloat("[MapsData] Preloading ", this._Binocular_Size);
			this.DOHGBNPMBKG().SetFloat("\" for viewID ", this._Binocular_Dist);
			this.KEMJNOMIPHN().SetFloat("(\\[ */ *b *\\])", this._Binocular_Smooth);
			this.KEMJNOMIPHN().SetVector("/Segment-[Left]", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C62 RID: 19554 RVA: 0x0017B6B0 File Offset: 0x001798B0
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004C63 RID: 19555 RVA: 0x0017B6D4 File Offset: 0x001798D4
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)73;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C64 RID: 19556 RVA: 0x00178503 File Offset: 0x00176703
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C65 RID: 19557 RVA: 0x0017B70B File Offset: 0x0017990B
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)124;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C66 RID: 19558 RVA: 0x0017B744 File Offset: 0x00179944
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1047f)
			{
				this.HBJJOCHGOPH = 1048f;
			}
			this.MCDGIILBNIF().SetFloat("open", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("Joystick1Button6", this.OnOff);
			this.IONHGBPGCHK().SetFloat("_ColorKey", this.Greenness);
			this.IONHGBPGCHK().SetFloat("<i>", this.Vignette);
			this.EOCCJGIGEGJ().SetFloat("CameraFilterPack_RainFX_Anm", this.Vignette_Alpha);
			this.IFMAPIDFNLI().SetFloat("[PlayerController] ", this.Distortion);
			this.IONHGBPGCHK().SetFloat("skin.hit_normal", this.Noise);
			this.MCDGIILBNIF().SetFloat("Hidden/Image Effects/Cinematic/AmbientOcclusion", this.Intensity);
			this.MLMKCOINOOH().SetFloat("an hour ago", this.Light);
			this.IONHGBPGCHK().SetFloat(" base map(s)", this.Light2);
			this.GJHLADDCMFF().SetFloat("BadgeText", this.Line);
			this.DKNJGHFLAIF().SetFloat("_Offsets", this.Color_R);
			this.MCDGIILBNIF().SetFloat("_Value4", this.Color_G);
			this.OIMMPLPBLBK().SetFloat(".completed", this.Color_B);
			this.IFMAPIDFNLI().SetFloat("id", this._Binocular_Size);
			this.KEMJNOMIPHN().SetFloat("GlassAberration", this._Binocular_Dist);
			this.MCDGIILBNIF().SetFloat("_ColorBuffer", this._Binocular_Smooth);
			this.KEMJNOMIPHN().SetVector("id", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C67 RID: 19559 RVA: 0x0017B944 File Offset: 0x00179B44
	private void HAIAHJPCPAG()
	{
		this.SCShader = Shader.Find("plainText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004C68 RID: 19560 RVA: 0x0017B968 File Offset: 0x00179B68
	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 80f)
			{
				this.HBJJOCHGOPH = 1342f;
			}
			this.DOHGBNPMBKG().SetFloat("Server: {0}. Region: {1} ", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("_ScreenResolution", this.OnOff);
			this.IFMAPIDFNLI().SetFloat("SlidingArea", this.Greenness);
			this.OIMMPLPBLBK().SetFloat("_TimeX", this.Vignette);
			this.KEMJNOMIPHN().SetFloat("LevelEditor/CustomEventEditor-Text", this.Vignette_Alpha);
			this.MLMKCOINOOH().SetFloat("_ScreenResolution", this.Distortion);
			this.DOHGBNPMBKG().SetFloat("Set environment sprite color and alpha.", this.Noise);
			this.KBOPGONOCNP().SetFloat("_DistortionLevel", this.Intensity);
			this.MLMKCOINOOH().SetFloat("MusicFileSelector", this.Light);
			this.IONHGBPGCHK().SetFloat("/", this.Light2);
			this.GJHLADDCMFF().SetFloat("GroupNameText", this.Line);
			this.IONHGBPGCHK().SetFloat("_TimeX", this.Color_R);
			this.EOCCJGIGEGJ().SetFloat("[PlayerController] ", this.Color_G);
			this.KEMJNOMIPHN().SetFloat("_FarCamera", this.Color_B);
			this.IFMAPIDFNLI().SetFloat("_ToPrevViewProjCombined", this._Binocular_Size);
			this.DOHGBNPMBKG().SetFloat("inventory.selected.", this._Binocular_Dist);
			this.MLMKCOINOOH().SetFloat("OK", this._Binocular_Smooth);
			this.DEFBJOCJJKF().SetVector("_Value", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C69 RID: 19561 RVA: 0x0017BB68 File Offset: 0x00179D68
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1925f)
			{
				this.HBJJOCHGOPH = 379f;
			}
			this.MLMKCOINOOH().SetFloat("Not sending leave operation. State is not 'Joined': ", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("Operation ", this.OnOff);
			this.KEMJNOMIPHN().SetFloat("0,7,true,0", this.Greenness);
			this.MCDGIILBNIF().SetFloat("Myst", this.Vignette);
			this.EOCCJGIGEGJ().SetFloat(" / ", this.Vignette_Alpha);
			this.EOCCJGIGEGJ().SetFloat(" AuthMode ", this.Distortion);
			this.DEFBJOCJJKF().SetFloat("_ScreenResolution", this.Noise);
			this.KBOPGONOCNP().SetFloat("z", this.Intensity);
			this.MCDGIILBNIF().SetFloat("settings.gamemessagesduration", this.Light);
			this.DKNJGHFLAIF().SetFloat("_Value4", this.Light2);
			this.OIMMPLPBLBK().SetFloat("achievements.21.completed.", this.Line);
			this.HKGAONMOBMH().SetFloat("#close", this.Color_R);
			this.MICHFGAOPKM().SetFloat("SSAARenderTargetCamera", this.Color_G);
			this.IFMAPIDFNLI().SetFloat("path", this.Color_B);
			this.DOHGBNPMBKG().SetFloat("FullscreenToggle", this._Binocular_Size);
			this.KBOPGONOCNP().SetFloat("/", this._Binocular_Dist);
			this.DOHGBNPMBKG().SetFloat("_Value", this._Binocular_Smooth);
			this.KEMJNOMIPHN().SetVector("PossibleMapPointsText", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C6A RID: 19562 RVA: 0x0017BD68 File Offset: 0x00179F68
	private void POIMNOBDBBN()
	{
		if (this.HODDOPANHAO != this.Preset)
		{
			this.HODDOPANHAO = this.Preset;
			float[] array = new float[61];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-B9B8E8DB27999DD7D297759E2C0DB5F14CDC32B9).FieldHandle);
			float[] array2 = array;
			float[] array3 = new float[-83];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-A49B234BAED1E521F4CC502150FB5CD960556BB7).FieldHandle);
			float[] array4 = array3;
			float[] array5 = new float[-105];
			RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.$field-1BC81E84591291A507FFBB2389A425CDBC738E46).FieldHandle);
			float[] array6 = array5;
			float[] array7 = new float[-121];
			RuntimeHelpers.InitializeArray(array7, fieldof(<PrivateImplementationDetails>.$field-231A2B8BB20EA0E6A00B61ED86869E4AF38E568B).FieldHandle);
			float[] array8 = array7;
			float[] array9 = new float[-12];
			RuntimeHelpers.InitializeArray(array9, fieldof(<PrivateImplementationDetails>.$field-344F35933DADC294755E40C6C3723DE2C4E5FD90).FieldHandle);
			float[] array10 = array9;
			float[] array11 = new float[-59];
			RuntimeHelpers.InitializeArray(array11, fieldof(<PrivateImplementationDetails>.$field-36D456C626B20C21AFD26F2ECDF45C1FB877A1CD).FieldHandle);
			float[] array12 = array11;
			float[] array13 = new float[-110];
			RuntimeHelpers.InitializeArray(array13, fieldof(<PrivateImplementationDetails>.$field-175291D1FA3DEB078C2B51F363761FA287FE0D22).FieldHandle);
			float[] array14 = array13;
			float[] array15 = new float[110];
			RuntimeHelpers.InitializeArray(array15, fieldof(<PrivateImplementationDetails>.$field-94D18A21349F54EE2CB44216F8FDA81F310F7D60).FieldHandle);
			float[] array16 = array15;
			float[] array17 = new float[-66];
			RuntimeHelpers.InitializeArray(array17, fieldof(<PrivateImplementationDetails>.$field-2E0E90126C561F5AC67617705F5604DB9E5284A1).FieldHandle);
			float[] array18 = array17;
			float[] array19 = new float[15];
			RuntimeHelpers.InitializeArray(array19, fieldof(<PrivateImplementationDetails>.$field-49201D55AB670A481AC262DF9FA3BD17F93DC9FD).FieldHandle);
			float[] array20 = array19;
			float[] array21 = new float[-95];
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array21 = array2;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array21 = array4;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Full)
			{
				array21 = array6;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Dark)
			{
				array21 = array8;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array21 = array10;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array21 = array12;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Sharp)
			{
				array21 = array14;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Sharp)
			{
				array21 = array16;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Sharp)
			{
				array21 = array18;
			}
			if (this.Preset == (CameraFilterPack_NightVisionFX.preset)118)
			{
				array21 = array20;
			}
			if (this.Preset != CameraFilterPack_NightVisionFX.preset.Night_Vision_Personalized)
			{
				this.Greenness = array21[0];
				this.Vignette = array21[0];
				this.Vignette_Alpha = array21[6];
				this.Distortion = array21[6];
				this.Noise = array21[4];
				this.Intensity = array21[8];
				this.Light = array21[5];
				this.Light2 = array21[7];
				this.Line = array21[8];
				this.Color_R = array21[76];
				this.Color_G = array21[-78];
				this.Color_B = array21[-73];
			}
		}
	}

	// Token: 0x06004C6B RID: 19563 RVA: 0x0017BF82 File Offset: 0x0017A182
	private Material IFMAPIDFNLI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C6C RID: 19564 RVA: 0x0017BFB9 File Offset: 0x0017A1B9
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Vision_Drost");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004C6D RID: 19565 RVA: 0x0017BFE0 File Offset: 0x0017A1E0
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 427f)
			{
				this.HBJJOCHGOPH = 1956f;
			}
			this.HKGAONMOBMH().SetFloat("#,0", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("Nov", this.OnOff);
			this.KEMJNOMIPHN().SetFloat("menu.selectedplaymode", this.Greenness);
			this.EOCCJGIGEGJ().SetFloat("mapselector.filter.favoriteonly", this.Vignette);
			this.NBPKMLMCHFN.SetFloat("_UserLutParams", this.Vignette_Alpha);
			this.KEMJNOMIPHN().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", this.Distortion);
			this.OIMMPLPBLBK().SetFloat("ViewMenu", this.Noise);
			this.MCDGIILBNIF().SetFloat("setfloat", this.Intensity);
			this.KEMJNOMIPHN().SetFloat("Can not SetMasterClient(). Not in room or in offlineMode.", this.Light);
			this.HKGAONMOBMH().SetFloat("SelectorMusicToggle", this.Light2);
			this.HKGAONMOBMH().SetFloat("DPADHOR", this.Line);
			this.KEMJNOMIPHN().SetFloat("NEW", this.Color_R);
			this.LENEJAGLCNL().SetFloat("_Blend", this.Color_G);
			this.DKNJGHFLAIF().SetFloat("Data/Editor/leveltemplate", this.Color_B);
			this.IONHGBPGCHK().SetFloat(".lastCheckpoint.checkpointsUsed", this._Binocular_Size);
			this.HKGAONMOBMH().SetFloat("event", this._Binocular_Dist);
			this.KEMJNOMIPHN().SetFloat("_TimeX", this._Binocular_Smooth);
			this.OIMMPLPBLBK().SetVector("_Value5", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C6E RID: 19566 RVA: 0x0017C1E0 File Offset: 0x0017A3E0
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C6F RID: 19567 RVA: 0x0017C217 File Offset: 0x0017A417
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find("[SERVER] Kicked ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004C70 RID: 19568 RVA: 0x0017C23B File Offset: 0x0017A43B
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("CameraFilterPack_Glasses_On6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004C71 RID: 19569 RVA: 0x0017C25F File Offset: 0x0017A45F
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C72 RID: 19570 RVA: 0x00178503 File Offset: 0x00176703
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C73 RID: 19571 RVA: 0x0017C298 File Offset: 0x0017A498
	private void PFNFPINPCMH()
	{
		if (this.HODDOPANHAO != this.Preset)
		{
			this.HODDOPANHAO = this.Preset;
			float[] array = new float[-42];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-B9B8E8DB27999DD7D297759E2C0DB5F14CDC32B9).FieldHandle);
			float[] array2 = array;
			float[] array3 = new float[88];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-A49B234BAED1E521F4CC502150FB5CD960556BB7).FieldHandle);
			float[] array4 = array3;
			float[] array5 = new float[-76];
			RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.$field-1BC81E84591291A507FFBB2389A425CDBC738E46).FieldHandle);
			float[] array6 = array5;
			float[] array7 = new float[-3];
			RuntimeHelpers.InitializeArray(array7, fieldof(<PrivateImplementationDetails>.$field-231A2B8BB20EA0E6A00B61ED86869E4AF38E568B).FieldHandle);
			float[] array8 = array7;
			float[] array9 = new float[-80];
			RuntimeHelpers.InitializeArray(array9, fieldof(<PrivateImplementationDetails>.$field-344F35933DADC294755E40C6C3723DE2C4E5FD90).FieldHandle);
			float[] array10 = array9;
			float[] array11 = new float[73];
			RuntimeHelpers.InitializeArray(array11, fieldof(<PrivateImplementationDetails>.$field-36D456C626B20C21AFD26F2ECDF45C1FB877A1CD).FieldHandle);
			float[] array12 = array11;
			float[] array13 = new float[122];
			RuntimeHelpers.InitializeArray(array13, fieldof(<PrivateImplementationDetails>.$field-175291D1FA3DEB078C2B51F363761FA287FE0D22).FieldHandle);
			float[] array14 = array13;
			float[] array15 = new float[-2];
			RuntimeHelpers.InitializeArray(array15, fieldof(<PrivateImplementationDetails>.$field-94D18A21349F54EE2CB44216F8FDA81F310F7D60).FieldHandle);
			float[] array16 = array15;
			float[] array17 = new float[-29];
			RuntimeHelpers.InitializeArray(array17, fieldof(<PrivateImplementationDetails>.$field-2E0E90126C561F5AC67617705F5604DB9E5284A1).FieldHandle);
			float[] array18 = array17;
			float[] array19 = new float[66];
			RuntimeHelpers.InitializeArray(array19, fieldof(<PrivateImplementationDetails>.$field-49201D55AB670A481AC262DF9FA3BD17F93DC9FD).FieldHandle);
			float[] array20 = array19;
			float[] array21 = new float[18];
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array21 = array2;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array21 = array4;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Low_Light)
			{
				array21 = array6;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_RedBurn)
			{
				array21 = array8;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array21 = array10;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Low_Light)
			{
				array21 = array12;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array21 = array14;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_RedBurn)
			{
				array21 = array16;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Dark)
			{
				array21 = array18;
			}
			if (this.Preset == (CameraFilterPack_NightVisionFX.preset)111)
			{
				array21 = array20;
			}
			if (this.Preset != CameraFilterPack_NightVisionFX.preset.Night_Vision_Personalized)
			{
				this.Greenness = array21[1];
				this.Vignette = array21[0];
				this.Vignette_Alpha = array21[2];
				this.Distortion = array21[5];
				this.Noise = array21[1];
				this.Intensity = array21[4];
				this.Light = array21[8];
				this.Light2 = array21[3];
				this.Line = array21[3];
				this.Color_R = array21[-11];
				this.Color_G = array21[-29];
				this.Color_B = array21[-99];
			}
		}
	}

	// Token: 0x06004C74 RID: 19572 RVA: 0x0017C4B4 File Offset: 0x0017A6B4
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 162f)
			{
				this.HBJJOCHGOPH = 1303f;
			}
			this.NBPKMLMCHFN.SetFloat("Map: ", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("_ScreenResolution", this.OnOff);
			this.GJHLADDCMFF().SetFloat("violet", this.Greenness);
			this.KEMJNOMIPHN().SetFloat("_ScreenResolution", this.Vignette);
			this.GJHLADDCMFF().SetFloat("_TimeX", this.Vignette_Alpha);
			this.IONHGBPGCHK().SetFloat("_DepthLevel", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("_FrustumCornersWS", this.Noise);
			this.MLMKCOINOOH().SetFloat("ConnectToBestCloudServer() failed. Can only connect while in state 'Disconnected'. Current state: ", this.Intensity);
			this.GJHLADDCMFF().SetFloat("_TimeX", this.Light);
			this.IFMAPIDFNLI().SetFloat("_MainTex2", this.Light2);
			this.NBPKMLMCHFN.SetFloat(" is muted", this.Line);
			this.EOCCJGIGEGJ().SetFloat("_color", this.Color_R);
			this.KBOPGONOCNP().SetFloat("CameraFilterPack/TV_Chromatical2", this.Color_G);
			this.MLMKCOINOOH().SetFloat("maps.", this.Color_B);
			this.EOCCJGIGEGJ().SetFloat("There is already a virtual button named ", this._Binocular_Size);
			this.MICHFGAOPKM().SetFloat("_Value3", this._Binocular_Dist);
			this.OIMMPLPBLBK().SetFloat("Internal LUT", this._Binocular_Smooth);
			this.EOCCJGIGEGJ().SetVector("float,1", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C75 RID: 19573 RVA: 0x0017C6B4 File Offset: 0x0017A8B4
	private void JHPOIOELNCG()
	{
		if (this.HODDOPANHAO != this.Preset)
		{
			this.HODDOPANHAO = this.Preset;
			float[] array = new float[-22];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-B9B8E8DB27999DD7D297759E2C0DB5F14CDC32B9).FieldHandle);
			float[] array2 = array;
			float[] array3 = new float[-18];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-A49B234BAED1E521F4CC502150FB5CD960556BB7).FieldHandle);
			float[] array4 = array3;
			float[] array5 = new float[33];
			RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.$field-1BC81E84591291A507FFBB2389A425CDBC738E46).FieldHandle);
			float[] array6 = array5;
			float[] array7 = new float[-19];
			RuntimeHelpers.InitializeArray(array7, fieldof(<PrivateImplementationDetails>.$field-231A2B8BB20EA0E6A00B61ED86869E4AF38E568B).FieldHandle);
			float[] array8 = array7;
			float[] array9 = new float[]
			{
				0.2f,
				0.028f,
				0.706f,
				1.21f,
				0.397f,
				-0.24f,
				2f
			};
			float[] array10 = new float[-24];
			RuntimeHelpers.InitializeArray(array10, fieldof(<PrivateImplementationDetails>.$field-36D456C626B20C21AFD26F2ECDF45C1FB877A1CD).FieldHandle);
			float[] array11 = array10;
			float[] array12 = new float[34];
			RuntimeHelpers.InitializeArray(array12, fieldof(<PrivateImplementationDetails>.$field-175291D1FA3DEB078C2B51F363761FA287FE0D22).FieldHandle);
			float[] array13 = array12;
			float[] array14 = new float[63];
			RuntimeHelpers.InitializeArray(array14, fieldof(<PrivateImplementationDetails>.$field-94D18A21349F54EE2CB44216F8FDA81F310F7D60).FieldHandle);
			float[] array15 = array14;
			float[] array16 = new float[-106];
			RuntimeHelpers.InitializeArray(array16, fieldof(<PrivateImplementationDetails>.$field-2E0E90126C561F5AC67617705F5604DB9E5284A1).FieldHandle);
			float[] array17 = array16;
			float[] array18 = new float[-17];
			RuntimeHelpers.InitializeArray(array18, fieldof(<PrivateImplementationDetails>.$field-49201D55AB670A481AC262DF9FA3BD17F93DC9FD).FieldHandle);
			float[] array19 = array18;
			float[] array20 = new float[63];
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array20 = array2;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array20 = array4;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Sharp)
			{
				array20 = array6;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_RedBurn)
			{
				array20 = array8;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Classic)
			{
				array20 = array9;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Sharp)
			{
				array20 = array11;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_BlueSky)
			{
				array20 = array13;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Pinky)
			{
				array20 = array15;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array20 = array17;
			}
			if (this.Preset == (CameraFilterPack_NightVisionFX.preset)92)
			{
				array20 = array19;
			}
			if (this.Preset != CameraFilterPack_NightVisionFX.preset.Night_Vision_Personalized)
			{
				this.Greenness = array20[0];
				this.Vignette = array20[1];
				this.Vignette_Alpha = array20[5];
				this.Distortion = array20[5];
				this.Noise = array20[2];
				this.Intensity = array20[6];
				this.Light = array20[8];
				this.Light2 = array20[4];
				this.Line = array20[6];
				this.Color_R = array20[-32];
				this.Color_G = array20[-63];
				this.Color_B = array20[67];
			}
		}
	}

	// Token: 0x06004C76 RID: 19574 RVA: 0x0017A0A2 File Offset: 0x001782A2
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004C77 RID: 19575 RVA: 0x0017C8CE File Offset: 0x0017AACE
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("ReconnectAndRejoin() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004C78 RID: 19576 RVA: 0x0017C8F4 File Offset: 0x0017AAF4
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 137f)
			{
				this.HBJJOCHGOPH = 1514f;
			}
			this.KEMJNOMIPHN().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("#tryagain", this.OnOff);
			this.EOCCJGIGEGJ().SetFloat("other.dust2", this.Greenness);
			this.IFMAPIDFNLI().SetFloat("_LayerThickness", this.Vignette);
			this.MLMKCOINOOH().SetFloat("restrictions\n\n#until: ", this.Vignette_Alpha);
			this.DKNJGHFLAIF().SetFloat("USE_PREDICATION", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("[PlayerBase] ShowTitle error: ", this.Noise);
			this.IONHGBPGCHK().SetFloat("SetSatelliteTrailMinVertexDistance", this.Intensity);
			this.HKGAONMOBMH().SetFloat("ItemTemplate", this.Light);
			this.KEMJNOMIPHN().SetFloat("y", this.Light2);
			this.IFMAPIDFNLI().SetFloat("_MinVelocity", this.Line);
			this.KBOPGONOCNP().SetFloat("_ScreenResolution", this.Color_R);
			this.MLMKCOINOOH().SetFloat("_Offsets", this.Color_G);
			this.IONHGBPGCHK().SetFloat("CameraFilterPack/TV_Vcr", this.Color_B);
			this.DOHGBNPMBKG().SetFloat("LevelURLInputField", this._Binocular_Size);
			this.DEFBJOCJJKF().SetFloat("Coroutine container not configured... did you forget to call Init?", this._Binocular_Dist);
			this.MICHFGAOPKM().SetFloat("CameraFilterPack/Pixel_Pixelisation", this._Binocular_Smooth);
			this.IFMAPIDFNLI().SetVector("Fade", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C79 RID: 19577 RVA: 0x0017CAF4 File Offset: 0x0017ACF4
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1029f)
			{
				this.HBJJOCHGOPH = 689f;
			}
			this.GJHLADDCMFF().SetFloat("_Value5", this.HBJJOCHGOPH);
			this.MLMKCOINOOH().SetFloat("st", this.OnOff);
			this.OIMMPLPBLBK().SetFloat("GridDataArcs", this.Greenness);
			this.MLMKCOINOOH().SetFloat("CameraFilterPack/Blend2Camera_GreenScreen", this.Vignette);
			this.NBPKMLMCHFN.SetFloat("action", this.Vignette_Alpha);
			this.KEMJNOMIPHN().SetFloat("menu.enableselectormusic", this.Distortion);
			this.DEFBJOCJJKF().SetFloat("_Value", this.Noise);
			this.HKGAONMOBMH().SetFloat("OperationResponse unhandled: {0}", this.Intensity);
			this.DOHGBNPMBKG().SetFloat("_MainTex2", this.Light);
			this.OIMMPLPBLBK().SetFloat("_TimeX", this.Light2);
			this.LENEJAGLCNL().SetFloat("Warning: Unhandled event ", this.Line);
			this.OIMMPLPBLBK().SetFloat(" ", this.Color_R);
			this.HKGAONMOBMH().SetFloat("OxOD.lastPath", this.Color_G);
			this.LENEJAGLCNL().SetFloat("#status", this.Color_B);
			this.GJHLADDCMFF().SetFloat("Horizontal", this._Binocular_Size);
			this.HKGAONMOBMH().SetFloat("GameModeText", this._Binocular_Dist);
			this.HKGAONMOBMH().SetFloat("CameraFilterPack_TV_BrokenGlass_2", this._Binocular_Smooth);
			this.MICHFGAOPKM().SetVector("There is already a virtual axis named ", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C7A RID: 19578 RVA: 0x00178503 File Offset: 0x00176703
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C7B RID: 19579 RVA: 0x0017CCF4 File Offset: 0x0017AEF4
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C7C RID: 19580 RVA: 0x0017CD2B File Offset: 0x0017AF2B
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C7D RID: 19581 RVA: 0x0017CD62 File Offset: 0x0017AF62
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find(".lastCheckpoint.checkpointsUsed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004C7E RID: 19582 RVA: 0x0017CD86 File Offset: 0x0017AF86
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("DPADVER");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004C7F RID: 19583 RVA: 0x0017CDAC File Offset: 0x0017AFAC
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1569f)
			{
				this.HBJJOCHGOPH = 1226f;
			}
			this.EOCCJGIGEGJ().SetFloat("CameraFilterPack/Distortion_Lens", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("Player Connected", this.OnOff);
			this.OIMMPLPBLBK().SetFloat("challenges", this.Greenness);
			this.DOHGBNPMBKG().SetFloat("note.1", this.Vignette);
			this.DOHGBNPMBKG().SetFloat("#md5submitionfailed: ", this.Vignette_Alpha);
			this.KBOPGONOCNP().SetFloat("FrostCanvas", this.Distortion);
			this.MCDGIILBNIF().SetFloat("player.bluelifering", this.Noise);
			this.IFMAPIDFNLI().SetFloat("x", this.Intensity);
			this.KEMJNOMIPHN().SetFloat("CameraFilterPack_Glasses_On5", this.Light);
			this.DEFBJOCJJKF().SetFloat("_Parameter", this.Light2);
			this.LENEJAGLCNL().SetFloat("Editor/", this.Line);
			this.EOCCJGIGEGJ().SetFloat("_ScreenResolution", this.Color_R);
			this.IFMAPIDFNLI().SetFloat("Drop_Far", this.Color_G);
			this.OIMMPLPBLBK().SetFloat("_TimeX", this.Color_B);
			this.EOCCJGIGEGJ().SetFloat("_TimeX", this._Binocular_Size);
			this.IFMAPIDFNLI().SetFloat("ComboScoreText", this._Binocular_Dist);
			this.MLMKCOINOOH().SetFloat("[PlayerBase] SpawnObj error: ", this._Binocular_Smooth);
			this.HKGAONMOBMH().SetVector("RecieveChatActionMessage", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C81 RID: 19585 RVA: 0x00178503 File Offset: 0x00176703
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C82 RID: 19586 RVA: 0x0017D04E File Offset: 0x0017B24E
	private void OKLAJINHPAN()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004C83 RID: 19587 RVA: 0x0017D072 File Offset: 0x0017B272
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("Texture2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004C84 RID: 19588 RVA: 0x0017D098 File Offset: 0x0017B298
	private void APKNAPHOFHC()
	{
		if (this.HODDOPANHAO != this.Preset)
		{
			this.HODDOPANHAO = this.Preset;
			float[] array = new float[36];
			RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-B9B8E8DB27999DD7D297759E2C0DB5F14CDC32B9).FieldHandle);
			float[] array2 = array;
			float[] array3 = new float[-11];
			RuntimeHelpers.InitializeArray(array3, fieldof(<PrivateImplementationDetails>.$field-A49B234BAED1E521F4CC502150FB5CD960556BB7).FieldHandle);
			float[] array4 = array3;
			float[] array5 = new float[-60];
			RuntimeHelpers.InitializeArray(array5, fieldof(<PrivateImplementationDetails>.$field-1BC81E84591291A507FFBB2389A425CDBC738E46).FieldHandle);
			float[] array6 = array5;
			float[] array7 = new float[93];
			RuntimeHelpers.InitializeArray(array7, fieldof(<PrivateImplementationDetails>.$field-231A2B8BB20EA0E6A00B61ED86869E4AF38E568B).FieldHandle);
			float[] array8 = array7;
			float[] array9 = new float[122];
			RuntimeHelpers.InitializeArray(array9, fieldof(<PrivateImplementationDetails>.$field-344F35933DADC294755E40C6C3723DE2C4E5FD90).FieldHandle);
			float[] array10 = array9;
			float[] array11 = new float[]
			{
				0.2f,
				0.159f,
				0.622f,
				-2.28f
			};
			float[] array12 = new float[124];
			RuntimeHelpers.InitializeArray(array12, fieldof(<PrivateImplementationDetails>.$field-175291D1FA3DEB078C2B51F363761FA287FE0D22).FieldHandle);
			float[] array13 = array12;
			float[] array14 = new float[-79];
			RuntimeHelpers.InitializeArray(array14, fieldof(<PrivateImplementationDetails>.$field-94D18A21349F54EE2CB44216F8FDA81F310F7D60).FieldHandle);
			float[] array15 = array14;
			float[] array16 = new float[-94];
			RuntimeHelpers.InitializeArray(array16, fieldof(<PrivateImplementationDetails>.$field-2E0E90126C561F5AC67617705F5604DB9E5284A1).FieldHandle);
			float[] array17 = array16;
			float[] array18 = new float[63];
			RuntimeHelpers.InitializeArray(array18, fieldof(<PrivateImplementationDetails>.$field-49201D55AB670A481AC262DF9FA3BD17F93DC9FD).FieldHandle);
			float[] array19 = array18;
			float[] array20 = new float[-66];
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array20 = array2;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_FX)
			{
				array20 = array4;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Sharp)
			{
				array20 = array6;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_BlueSky)
			{
				array20 = array8;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_BlueSky)
			{
				array20 = array10;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Sharp)
			{
				array20 = array11;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_Sharp)
			{
				array20 = array13;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_RedBurn)
			{
				array20 = array15;
			}
			if (this.Preset == CameraFilterPack_NightVisionFX.preset.Night_Vision_BlueSky)
			{
				array20 = array17;
			}
			if (this.Preset == (CameraFilterPack_NightVisionFX.preset)85)
			{
				array20 = array19;
			}
			if (this.Preset != CameraFilterPack_NightVisionFX.preset.Night_Vision_Personalized)
			{
				this.Greenness = array20[0];
				this.Vignette = array20[1];
				this.Vignette_Alpha = array20[7];
				this.Distortion = array20[2];
				this.Noise = array20[0];
				this.Intensity = array20[7];
				this.Light = array20[0];
				this.Light2 = array20[5];
				this.Line = array20[8];
				this.Color_R = array20[-90];
				this.Color_G = array20[48];
				this.Color_B = array20[-26];
			}
		}
	}

	// Token: 0x040007F6 RID: 2038
	public Shader SCShader;

	// Token: 0x040007F7 RID: 2039
	public CameraFilterPack_NightVisionFX.preset Preset;

	// Token: 0x040007F8 RID: 2040
	private CameraFilterPack_NightVisionFX.preset HODDOPANHAO;

	// Token: 0x040007F9 RID: 2041
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040007FA RID: 2042
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040007FB RID: 2043
	private Material BJFKDHHMLJH;

	// Token: 0x040007FC RID: 2044
	[Range(0f, 1f)]
	public float OnOff;

	// Token: 0x040007FD RID: 2045
	[Range(0.2f, 2f)]
	public float Greenness = 1f;

	// Token: 0x040007FE RID: 2046
	[Range(0f, 1f)]
	public float Vignette = 1f;

	// Token: 0x040007FF RID: 2047
	[Range(0f, 1f)]
	public float Vignette_Alpha = 1f;

	// Token: 0x04000800 RID: 2048
	[Range(-10f, 10f)]
	public float Distortion = 1f;

	// Token: 0x04000801 RID: 2049
	[Range(0f, 1f)]
	public float Noise = 1f;

	// Token: 0x04000802 RID: 2050
	[Range(-2f, 1f)]
	public float Intensity = -1f;

	// Token: 0x04000803 RID: 2051
	[Range(0f, 2f)]
	public float Light = 1f;

	// Token: 0x04000804 RID: 2052
	[Range(0f, 1f)]
	public float Light2 = 1f;

	// Token: 0x04000805 RID: 2053
	[Range(0f, 2f)]
	public float Line = 1f;

	// Token: 0x04000806 RID: 2054
	[Range(-2f, 2f)]
	public float Color_R;

	// Token: 0x04000807 RID: 2055
	[Range(-2f, 2f)]
	public float Color_G;

	// Token: 0x04000808 RID: 2056
	[Range(-2f, 2f)]
	public float Color_B;

	// Token: 0x04000809 RID: 2057
	[Range(0f, 1f)]
	public float _Binocular_Size = 0.499f;

	// Token: 0x0400080A RID: 2058
	[Range(0f, 1f)]
	public float _Binocular_Smooth = 0.113f;

	// Token: 0x0400080B RID: 2059
	[Range(0f, 1f)]
	public float _Binocular_Dist = 0.286f;

	// Token: 0x020000F6 RID: 246
	public enum preset
	{
		// Token: 0x0400080D RID: 2061
		Night_Vision_Personalized = -1,
		// Token: 0x0400080E RID: 2062
		Night_Vision_FX,
		// Token: 0x0400080F RID: 2063
		Night_Vision_Classic,
		// Token: 0x04000810 RID: 2064
		Night_Vision_Full,
		// Token: 0x04000811 RID: 2065
		Night_Vision_Dark,
		// Token: 0x04000812 RID: 2066
		Night_Vision_Sharp,
		// Token: 0x04000813 RID: 2067
		Night_Vision_BlueSky,
		// Token: 0x04000814 RID: 2068
		Night_Vision_Low_Light,
		// Token: 0x04000815 RID: 2069
		Night_Vision_Pinky,
		// Token: 0x04000816 RID: 2070
		Night_Vision_RedBurn,
		// Token: 0x04000817 RID: 2071
		Night_Vision_PurpleShadow
	}
}
