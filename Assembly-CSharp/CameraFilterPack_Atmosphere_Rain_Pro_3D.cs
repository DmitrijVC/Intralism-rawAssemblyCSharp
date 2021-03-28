using System;
using UnityEngine;

// Token: 0x02000037 RID: 55
[AddComponentMenu("Camera Filter Pack/Weather/Rain_Pro_3D")]
[ExecuteInEditMode]
public class CameraFilterPack_Atmosphere_Rain_Pro_3D : MonoBehaviour
{
	// Token: 0x06000EAE RID: 3758 RVA: 0x000677B0 File Offset: 0x000659B0
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EAF RID: 3759 RVA: 0x000677D0 File Offset: 0x000659D0
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 608f)
			{
				this.HBJJOCHGOPH = 1249f;
			}
			this.AELJLBOJAIL().SetFloat("YES", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("_Value2", this.Fade);
			this.JFDGLLEOPGB().SetFloat("ShadersToggle", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 85f && z < 550f)
				{
					this.IONHGBPGCHK().SetFloat("DontDestroy", z);
				}
				if (z < 1563f)
				{
					this.NBPKMLMCHFN.SetFloat("[PlayerController] ", z);
				}
			}
			else
			{
				this.AELJLBOJAIL().SetFloat("Reading preview file failed!: \"{0}\"", this.DirectionX);
			}
			this.DNLMFEGJJDD().SetFloat("_TimeX", this.Speed);
			this.BFGNMFCNDBC().SetFloat("<start_index> <end_index>", this.Size);
			this.NBPKMLMCHFN.SetFloat("UseFinalGlassColor", this.Distortion);
			this.HEHKGPKLAKK().SetFloat("_DotSize", this.StormFlashOnOff);
			this.BFGNMFCNDBC().SetFloat("JoinRandomRoom failed. In offline mode you still have to leave a room to enter another.", this.DropOnOff);
			this.HFBJAOFLCJI().SetFloat("_MainTex2", this._FixDistance);
			this.PGPEMMBJOOG().SetFloat("checkpoint", (float)((!this._Visualize) ? 0 : 0));
			this.IONHGBPGCHK().SetFloat("Intensity", this.Drop_Near);
			this.LDNADDJMIPK().SetFloat("/", this.Drop_Far);
			this.HEHKGPKLAKK().SetFloat("Set crosshair color", 859f - this.Drop_With_Obj);
			this.IONHGBPGCHK().SetFloat("[PlayerBase] Checkpoint error: ", this.Myst);
			this.LDNADDJMIPK().SetColor("x", this.Myst_Color);
			this.DNLMFEGJJDD().SetFloat("CameraFilterPack/Gradients_ElectricGradient", this.Drop_Floor_Fluid);
			this.HEHKGPKLAKK().SetVector("t", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1642f, 969f));
			this.ADGHJOHKEHG().SetTexture(" on effect ", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EB0 RID: 3760 RVA: 0x00067A78 File Offset: 0x00065C78
	private void PMPKMGKAAJH()
	{
		this.FPHEBLMINDA = (Resources.Load("Items") as Texture2D);
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000EB1 RID: 3761 RVA: 0x00067AB1 File Offset: 0x00065CB1
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-77);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EB2 RID: 3762 RVA: 0x000677B0 File Offset: 0x000659B0
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EB3 RID: 3763 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06000EB4 RID: 3764 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06000EB5 RID: 3765 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06000EB6 RID: 3766 RVA: 0x000677B0 File Offset: 0x000659B0
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EB7 RID: 3767 RVA: 0x00067AE8 File Offset: 0x00065CE8
	private void BMIOFJFMCBG()
	{
		this.FPHEBLMINDA = (Resources.Load("maps.") as Texture2D);
		this.SCShader = Shader.Find("#,0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000EB8 RID: 3768 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06000EB9 RID: 3769 RVA: 0x00067B24 File Offset: 0x00065D24
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 276f)
			{
				this.HBJJOCHGOPH = 1626f;
			}
			this.HFBJAOFLCJI().SetFloat("_XCrop", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("_Value2", this.Fade);
			this.HKGAONMOBMH().SetFloat("_TimeX", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 648f && z < 1636f)
				{
					this.HFBJAOFLCJI().SetFloat("_SampleCount", z);
				}
				if (z < 313f)
				{
					this.EPCGJFCCAFH().SetFloat("ItemsCountText", z);
				}
			}
			else
			{
				this.ADGHJOHKEHG().SetFloat("OpGetGameList not sent. LobbyType must be SqlLobby.", this.DirectionX);
			}
			this.BFGNMFCNDBC().SetFloat("_BlurredColor", this.Speed);
			this.ADGHJOHKEHG().SetFloat("CameraFilterPack/Pixelisation_OilPaint", this.Size);
			this.HFBJAOFLCJI().SetFloat("_ScreenResolution", this.Distortion);
			this.HFBJAOFLCJI().SetFloat("_Red_B", this.StormFlashOnOff);
			this.PGPEMMBJOOG().SetFloat("_ScreenResolution", this.DropOnOff);
			this.PGPEMMBJOOG().SetFloat("_TimeX", this._FixDistance);
			this.EPCGJFCCAFH().SetFloat("_Green_C", (float)((!this._Visualize) ? 0 : 1));
			this.LDNADDJMIPK().SetFloat("/", this.Drop_Near);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack_Broken_Screen1", this.Drop_Far);
			this.PGPEMMBJOOG().SetFloat("_Smooth", 1534f - this.Drop_With_Obj);
			this.HFBJAOFLCJI().SetFloat("_ScreenResolution", this.Myst);
			this.BFGNMFCNDBC().SetColor(" (inactive)", this.Myst_Color);
			this.EPCGJFCCAFH().SetFloat("GraphicsQualitySlider", this.Drop_Floor_Fluid);
			this.ADGHJOHKEHG().SetVector("ScreenResolutionPanel", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 851f, 396f));
			this.AELJLBOJAIL().SetTexture("_Value", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EBA RID: 3770 RVA: 0x00067DCC File Offset: 0x00065FCC
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 599f)
			{
				this.HBJJOCHGOPH = 600f;
			}
			this.ADGHJOHKEHG().SetFloat("_MatrixColor", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("Set Particles Emission", this.Fade);
			this.JFDGLLEOPGB().SetFloat("_BlurVector", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 1850f && z < 737f)
				{
					this.HFBJAOFLCJI().SetFloat("USE_UV_BASED_REPROJECTION", z);
				}
				if (z < 1491f)
				{
					this.IONHGBPGCHK().SetFloat("Received RPC: ", z);
				}
			}
			else
			{
				this.JFDGLLEOPGB().SetFloat("CameraFilterPack/Color_Noise", this.DirectionX);
			}
			this.AELJLBOJAIL().SetFloat("[DiscordController] Shutdown", this.Speed);
			this.HEHKGPKLAKK().SetFloat("_MaxRadiusOrKInPaper", this.Size);
			this.HFBJAOFLCJI().SetFloat("Joystick1Button5", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("_ChromaticAberration", this.StormFlashOnOff);
			this.LDNADDJMIPK().SetFloat("_ScreenResolution", this.DropOnOff);
			this.AELJLBOJAIL().SetFloat("[PlayerController] ", this._FixDistance);
			this.PGPEMMBJOOG().SetFloat("SetRoomStartTimestamp", (float)((!this._Visualize) ? 1 : 1));
			this.HKGAONMOBMH().SetFloat("CameraFilterPack/Glow_Glow_Color", this.Drop_Near);
			this.PGPEMMBJOOG().SetFloat("isVisible", this.Drop_Far);
			this.JFDGLLEOPGB().SetFloat("_ScreenResolution", 1774f - this.Drop_With_Obj);
			this.PGPEMMBJOOG().SetFloat("The directory was created successfully at ", this.Myst);
			this.BFGNMFCNDBC().SetColor("CheckCombo", this.Myst_Color);
			this.BFGNMFCNDBC().SetFloat("EndlessLoopsScoreText", this.Drop_Floor_Fluid);
			this.HEHKGPKLAKK().SetVector(". Not connectedAndReady.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1895f, 1425f));
			this.HFBJAOFLCJI().SetTexture("_Distortion", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EBB RID: 3771 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06000EBC RID: 3772 RVA: 0x00068074 File Offset: 0x00066274
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 700f)
			{
				this.HBJJOCHGOPH = 1602f;
			}
			this.NBPKMLMCHFN.SetFloat("_DepthLevel", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("_LutTex", this.Fade);
			this.LDNADDJMIPK().SetFloat("EditMenu", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 1005f && z < 1962f)
				{
					this.IONHGBPGCHK().SetFloat("_ScreenResolution", z);
				}
				if (z < 1572f)
				{
					this.DNLMFEGJJDD().SetFloat("Obtain test Item", z);
				}
			}
			else
			{
				this.IONHGBPGCHK().SetFloat("_Fade", this.DirectionX);
			}
			this.ADGHJOHKEHG().SetFloat("curScn", this.Speed);
			this.BFGNMFCNDBC().SetFloat("menu.enableselectormusic", this.Size);
			this.EPCGJFCCAFH().SetFloat("[MapsEditor] Creating new item...", this.Distortion);
			this.DNLMFEGJJDD().SetFloat("LobbyCanvas", this.StormFlashOnOff);
			this.HKGAONMOBMH().SetFloat("_Distortion", this.DropOnOff);
			this.PGPEMMBJOOG().SetFloat("SetSatelliteTrailLength", this._FixDistance);
			this.DNLMFEGJJDD().SetFloat("_Value", (float)((!this._Visualize) ? 1 : 0));
			this.HKGAONMOBMH().SetFloat("event", this.Drop_Near);
			this.EPCGJFCCAFH().SetFloat("MaxLivesSlider", this.Drop_Far);
			this.IONHGBPGCHK().SetFloat(".completed", 581f - this.Drop_With_Obj);
			this.PGPEMMBJOOG().SetFloat("CameraFilterPack_TV_HorrorFX", this.Myst);
			this.HFBJAOFLCJI().SetColor(": ", this.Myst_Color);
			this.EPCGJFCCAFH().SetFloat("ItemNameText", this.Drop_Floor_Fluid);
			this.IONHGBPGCHK().SetVector("JoinButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1981f, 109f));
			this.ADGHJOHKEHG().SetTexture("/", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EBD RID: 3773 RVA: 0x0006831C File Offset: 0x0006651C
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1350f)
			{
				this.HBJJOCHGOPH = 1407f;
			}
			this.BFGNMFCNDBC().SetFloat("Tab2Content", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("Turn", this.Fade);
			this.IONHGBPGCHK().SetFloat("EndlessLoopsScoreText", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 1724f && z < 1024f)
				{
					this.EPCGJFCCAFH().SetFloat("The process failed: ", z);
				}
				if (z < 1040f)
				{
					this.HFBJAOFLCJI().SetFloat("_BlurDirectionPacked", z);
				}
			}
			else
			{
				this.ADGHJOHKEHG().SetFloat("_MainTex2", this.DirectionX);
			}
			this.PGPEMMBJOOG().SetFloat("Tab2Content", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Size);
			this.DNLMFEGJJDD().SetFloat("[Up]", this.Distortion);
			this.BFGNMFCNDBC().SetFloat("[MenuScene] Error: ", this.StormFlashOnOff);
			this.NBPKMLMCHFN.SetFloat("id", this.DropOnOff);
			this.JFDGLLEOPGB().SetFloat("_Value4", this._FixDistance);
			this.BFGNMFCNDBC().SetFloat("ColorBlood", (float)((!this._Visualize) ? 1 : 0));
			this.BFGNMFCNDBC().SetFloat("_Y", this.Drop_Near);
			this.JFDGLLEOPGB().SetFloat("Jit ", this.Drop_Far);
			this.HEHKGPKLAKK().SetFloat("SfxVolumeSlider", 1653f - this.Drop_With_Obj);
			this.IONHGBPGCHK().SetFloat("OperationResponse unhandled: {0}", this.Myst);
			this.HEHKGPKLAKK().SetColor("Room: '{0}' {1},{2} {4}/{3} players.", this.Myst_Color);
			this.LDNADDJMIPK().SetFloat("caret", this.Drop_Floor_Fluid);
			this.HKGAONMOBMH().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 668f, 1363f));
			this.DNLMFEGJJDD().SetTexture("ItemTemplate", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EBE RID: 3774 RVA: 0x000685C4 File Offset: 0x000667C4
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EBF RID: 3775 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06000EC0 RID: 3776 RVA: 0x000685FB File Offset: 0x000667FB
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EC1 RID: 3777 RVA: 0x00068632 File Offset: 0x00066832
	private void HLIAEEMGBHN()
	{
		this.FPHEBLMINDA = (Resources.Load(" to: ") as Texture2D);
		this.SCShader = Shader.Find("note.7");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000EC2 RID: 3778 RVA: 0x0006866C File Offset: 0x0006686C
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1170f)
			{
				this.HBJJOCHGOPH = 1539f;
			}
			this.ADGHJOHKEHG().SetFloat(": ", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("_SpherePositionX", this.Fade);
			this.AELJLBOJAIL().SetFloat("_ScreenResolution", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 1970f && z < 35f)
				{
					this.EPCGJFCCAFH().SetFloat(".lastCheckpoint.comboScore", z);
				}
				if (z < 1460f)
				{
					this.LDNADDJMIPK().SetFloat("[PhotonMessageInfo: Sender='{1}' Senttime={0}]", z);
				}
			}
			else
			{
				this.PGPEMMBJOOG().SetFloat("_TimeX", this.DirectionX);
			}
			this.NBPKMLMCHFN.SetFloat("PLEASE WAIT", this.Speed);
			this.EPCGJFCCAFH().SetFloat("{0:0} day{1}, ", this.Size);
			this.JFDGLLEOPGB().SetFloat("GlassDistortion", this.Distortion);
			this.IONHGBPGCHK().SetFloat("_MainTex", this.StormFlashOnOff);
			this.AELJLBOJAIL().SetFloat("player.currentrank", this.DropOnOff);
			this.LDNADDJMIPK().SetFloat("AddEnvironmentSprite", this._FixDistance);
			this.JFDGLLEOPGB().SetFloat("BitsData", (float)((!this._Visualize) ? 0 : 1));
			this.PGPEMMBJOOG().SetFloat("\" call.", this.Drop_Near);
			this.DNLMFEGJJDD().SetFloat("_Visualize", this.Drop_Far);
			this.NBPKMLMCHFN.SetFloat("_Dist", 279f - this.Drop_With_Obj);
			this.ADGHJOHKEHG().SetFloat("<color=white>", this.Myst);
			this.HEHKGPKLAKK().SetColor("_Value2", this.Myst_Color);
			this.HKGAONMOBMH().SetFloat("_DepthLevel", this.Drop_Floor_Fluid);
			this.BFGNMFCNDBC().SetVector("Editor/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1f, 356f));
			this.BFGNMFCNDBC().SetTexture("string", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EC3 RID: 3779 RVA: 0x00068914 File Offset: 0x00066B14
	private void KIMMMCJFMAB()
	{
		this.FPHEBLMINDA = (Resources.Load(" SecondsBeforeRespawn: ") as Texture2D);
		this.SCShader = Shader.Find("Set Particles Speed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000EC4 RID: 3780 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06000EC5 RID: 3781 RVA: 0x00068950 File Offset: 0x00066B50
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1395f)
			{
				this.HBJJOCHGOPH = 1665f;
			}
			this.NBPKMLMCHFN.SetFloat("Cant ask anyone else for PickupItem spawn times.", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("_Value", this.Fade);
			this.AELJLBOJAIL().SetFloat(": ", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 1798f && z < 295f)
				{
					this.DNLMFEGJJDD().SetFloat("team", z);
				}
				if (z < 793f)
				{
					this.HKGAONMOBMH().SetFloat("Joystick1Button7", z);
				}
			}
			else
			{
				this.HKGAONMOBMH().SetFloat("Image", this.DirectionX);
			}
			this.AELJLBOJAIL().SetFloat("SetSunInput", this.Speed);
			this.AELJLBOJAIL().SetFloat("_InternalLutParams", this.Size);
			this.DNLMFEGJJDD().SetFloat("skin.", this.Distortion);
			this.PGPEMMBJOOG().SetFloat("_MainTex2", this.StormFlashOnOff);
			this.AELJLBOJAIL().SetFloat("https://bitbucket.org/khb-soft/intralismarcsviewer/", this.DropOnOff);
			this.ADGHJOHKEHG().SetFloat("LevelEditor/CustomEventEditor-Text", this._FixDistance);
			this.EPCGJFCCAFH().SetFloat("Joystick1Button2", (float)((!this._Visualize) ? 1 : 0));
			this.DNLMFEGJJDD().SetFloat("Instrumental", this.Drop_Near);
			this.PGPEMMBJOOG().SetFloat("#", this.Drop_Far);
			this.PGPEMMBJOOG().SetFloat("}", 321f - this.Drop_With_Obj);
			this.IONHGBPGCHK().SetFloat("GroupNameText", this.Myst);
			this.HEHKGPKLAKK().SetColor("maps.", this.Myst_Color);
			this.EPCGJFCCAFH().SetFloat("_Value2", this.Drop_Floor_Fluid);
			this.LDNADDJMIPK().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 58f, 787f));
			this.AELJLBOJAIL().SetTexture("#timeuntilchallenge: ", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EC6 RID: 3782 RVA: 0x00068BF8 File Offset: 0x00066DF8
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 646f)
			{
				this.HBJJOCHGOPH = 1152f;
			}
			this.EPCGJFCCAFH().SetFloat("[MapEditor] Openning ", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("MapEnd", this.Fade);
			this.HKGAONMOBMH().SetFloat("SetSpeed", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 1558f && z < 981f)
				{
					this.HEHKGPKLAKK().SetFloat("_CenterY", z);
				}
				if (z < 1067f)
				{
					this.JFDGLLEOPGB().SetFloat("_Value", z);
				}
			}
			else
			{
				this.AELJLBOJAIL().SetFloat("menutheme.melancholicose", this.DirectionX);
			}
			this.EPCGJFCCAFH().SetFloat("_Green_R", this.Speed);
			this.DNLMFEGJJDD().SetFloat("GameScene", this.Size);
			this.ADGHJOHKEHG().SetFloat("[PlayerController] ", this.Distortion);
			this.HKGAONMOBMH().SetFloat("UpdateNewsTileStart", this.StormFlashOnOff);
			this.JFDGLLEOPGB().SetFloat("_Value", this.DropOnOff);
			this.HFBJAOFLCJI().SetFloat("_Value4", this._FixDistance);
			this.DNLMFEGJJDD().SetFloat("cancel", (float)((!this._Visualize) ? 0 : 0));
			this.HEHKGPKLAKK().SetFloat("CameraFilterPack/Vision_Plasma", this.Drop_Near);
			this.AELJLBOJAIL().SetFloat("_MainTex", this.Drop_Far);
			this.JFDGLLEOPGB().SetFloat("Joined room ", 1497f - this.Drop_With_Obj);
			this.JFDGLLEOPGB().SetFloat("achievements.21.completed.", this.Myst);
			this.HKGAONMOBMH().SetColor("_TimeX", this.Myst_Color);
			this.JFDGLLEOPGB().SetFloat("AreaTex", this.Drop_Floor_Fluid);
			this.BFGNMFCNDBC().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1938f, 131f));
			this.PGPEMMBJOOG().SetTexture("x", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EC7 RID: 3783 RVA: 0x000677B0 File Offset: 0x000659B0
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EC8 RID: 3784 RVA: 0x00068EA0 File Offset: 0x000670A0
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_Atmosphere_Rain_FX") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Atmosphere_Rain_Pro_3D");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000EC9 RID: 3785 RVA: 0x000677B0 File Offset: 0x000659B0
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000ECA RID: 3786 RVA: 0x00068ED9 File Offset: 0x000670D9
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000ECB RID: 3787 RVA: 0x00068F10 File Offset: 0x00067110
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 423f)
			{
				this.HBJJOCHGOPH = 899f;
			}
			this.HFBJAOFLCJI().SetFloat("float,0", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("Vertical", this.Fade);
			this.BFGNMFCNDBC().SetFloat("rarity", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 1202f && z < 1086f)
				{
					this.HEHKGPKLAKK().SetFloat("RecordButton", z);
				}
				if (z < 585f)
				{
					this.HFBJAOFLCJI().SetFloat("z", z);
				}
			}
			else
			{
				this.HFBJAOFLCJI().SetFloat("_SunPosition", this.DirectionX);
			}
			this.HEHKGPKLAKK().SetFloat("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.", this.Speed);
			this.PGPEMMBJOOG().SetFloat("SpawnObj", this.Size);
			this.ADGHJOHKEHG().SetFloat("There are {0} reported logs.", this.Distortion);
			this.LDNADDJMIPK().SetFloat("_TimeX", this.StormFlashOnOff);
			this.DNLMFEGJJDD().SetFloat("[Up]", this.DropOnOff);
			this.HKGAONMOBMH().SetFloat("NO", this._FixDistance);
			this.PGPEMMBJOOG().SetFloat("id", (float)((!this._Visualize) ? 1 : 0));
			this.HEHKGPKLAKK().SetFloat(",viewkeys", this.Drop_Near);
			this.HEHKGPKLAKK().SetFloat("colorC", this.Drop_Far);
			this.ADGHJOHKEHG().SetFloat(" ", 1355f - this.Drop_With_Obj);
			this.EPCGJFCCAFH().SetFloat("_Green_R", this.Myst);
			this.NBPKMLMCHFN.SetColor("_Bloom", this.Myst_Color);
			this.BFGNMFCNDBC().SetFloat(".g", this.Drop_Floor_Fluid);
			this.AELJLBOJAIL().SetVector("Set particles audio input", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 91f, 1715f));
			this.PGPEMMBJOOG().SetTexture("[MapEditor] Prepairing map editor...", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000ECC RID: 3788 RVA: 0x000691B8 File Offset: 0x000673B8
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000ECD RID: 3789 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06000ECE RID: 3790 RVA: 0x000691F0 File Offset: 0x000673F0
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1540f)
			{
				this.HBJJOCHGOPH = 15f;
			}
			this.HFBJAOFLCJI().SetFloat(".lastCheckpoint.time", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("Tab1Content", this.Fade);
			this.ADGHJOHKEHG().SetFloat("_Gain", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 629f && z < 537f)
				{
					this.HKGAONMOBMH().SetFloat("_Offsets", z);
				}
				if (z < 1790f)
				{
					this.BFGNMFCNDBC().SetFloat("Not sending leave operation. State is not 'Joined': ", z);
				}
			}
			else
			{
				this.JFDGLLEOPGB().SetFloat("player.lollipop", this.DirectionX);
			}
			this.ADGHJOHKEHG().SetFloat("LoadPlayerSkin", this.Speed);
			this.AELJLBOJAIL().SetFloat("DPADHOR", this.Size);
			this.PGPEMMBJOOG().SetFloat("_Value2", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("Connected to gameserver.", this.StormFlashOnOff);
			this.ADGHJOHKEHG().SetFloat("icon", this.DropOnOff);
			this.NBPKMLMCHFN.SetFloat(": ", this._FixDistance);
			this.IONHGBPGCHK().SetFloat(".lastCheckpoint.isMapCompleted", (float)((!this._Visualize) ? 0 : 1));
			this.ADGHJOHKEHG().SetFloat("CameraFilterPack/Blend2Camera_Screen", this.Drop_Near);
			this.DNLMFEGJJDD().SetFloat("CameraFilterPack/Blend2Camera_Subtract", this.Drop_Far);
			this.NBPKMLMCHFN.SetFloat("settings.arcshitsoundtimedelay", 1986f - this.Drop_With_Obj);
			this.JFDGLLEOPGB().SetFloat(":", this.Myst);
			this.JFDGLLEOPGB().SetColor(". Should be just one?", this.Myst_Color);
			this.ADGHJOHKEHG().SetFloat("offsets", this.Drop_Floor_Fluid);
			this.HEHKGPKLAKK().SetVector("HightScoreMaxPointsText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1392f, 1891f));
			this.IONHGBPGCHK().SetTexture("Dec", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000ECF RID: 3791 RVA: 0x00069498 File Offset: 0x00067698
	private void NPLCENPNJBM()
	{
		this.FPHEBLMINDA = (Resources.Load("DPADHOR") as Texture2D);
		this.SCShader = Shader.Find("_Value5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x1700001E RID: 30
	// (get) Token: 0x06000ED0 RID: 3792 RVA: 0x000694D1 File Offset: 0x000676D1
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

	// Token: 0x06000ED1 RID: 3793 RVA: 0x00069508 File Offset: 0x00067708
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000ED2 RID: 3794 RVA: 0x0006953F File Offset: 0x0006773F
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000ED3 RID: 3795 RVA: 0x000677B0 File Offset: 0x000659B0
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000ED4 RID: 3796 RVA: 0x00069578 File Offset: 0x00067778
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 442f)
			{
				this.HBJJOCHGOPH = 116f;
			}
			this.LDNADDJMIPK().SetFloat("LoadMapCanvas", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("_Value4", this.Fade);
			this.DNLMFEGJJDD().SetFloat("_Value2", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 1791f && z < 1985f)
				{
					this.ADGHJOHKEHG().SetFloat("_Value3", z);
				}
				if (z < 1838f)
				{
					this.PGPEMMBJOOG().SetFloat(". Possible scene loading in progress?", z);
				}
			}
			else
			{
				this.HKGAONMOBMH().SetFloat("Item ", this.DirectionX);
			}
			this.ADGHJOHKEHG().SetFloat("_Distortion", this.Speed);
			this.LDNADDJMIPK().SetFloat("_TimeX", this.Size);
			this.PGPEMMBJOOG().SetFloat("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.", this.Distortion);
			this.DNLMFEGJJDD().SetFloat("[EditorEvent] Exception: ", this.StormFlashOnOff);
			this.ADGHJOHKEHG().SetFloat(" Loaded: ", this.DropOnOff);
			this.BFGNMFCNDBC().SetFloat("_BlurredColor", this._FixDistance);
			this.HKGAONMOBMH().SetFloat("{0:0} minute{1}, ", (float)((!this._Visualize) ? 1 : 1));
			this.HFBJAOFLCJI().SetFloat("nd", this.Drop_Near);
			this.LDNADDJMIPK().SetFloat("[CraftingPanel] Init", this.Drop_Far);
			this.PGPEMMBJOOG().SetFloat(". The group number should be at least 1.", 41f - this.Drop_With_Obj);
			this.AELJLBOJAIL().SetFloat("mapselector.filter.subscribedonly", this.Myst);
			this.ADGHJOHKEHG().SetColor(".played", this.Myst_Color);
			this.BFGNMFCNDBC().SetFloat("#close", this.Drop_Floor_Fluid);
			this.ADGHJOHKEHG().SetVector("<i>", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 41f, 23f));
			this.BFGNMFCNDBC().SetTexture("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000ED5 RID: 3797 RVA: 0x00069820 File Offset: 0x00067A20
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000ED6 RID: 3798 RVA: 0x00069857 File Offset: 0x00067A57
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)80;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000ED7 RID: 3799 RVA: 0x00069890 File Offset: 0x00067A90
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 956f)
			{
				this.HBJJOCHGOPH = 402f;
			}
			this.DNLMFEGJJDD().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("_EmissionColor", this.Fade);
			this.HEHKGPKLAKK().SetFloat("GlassAberration", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 1567f && z < 1586f)
				{
					this.IONHGBPGCHK().SetFloat("mapselector.filter.subscribedonly", z);
				}
				if (z < 554f)
				{
					this.HKGAONMOBMH().SetFloat("_Value3", z);
				}
			}
			else
			{
				this.EPCGJFCCAFH().SetFloat("other.dust1", this.DirectionX);
			}
			this.HFBJAOFLCJI().SetFloat("_Value3", this.Speed);
			this.IONHGBPGCHK().SetFloat("Item created: Id: ", this.Size);
			this.EPCGJFCCAFH().SetFloat("SubBass", this.Distortion);
			this.DNLMFEGJJDD().SetFloat("CameraFilterPack/Colors_NewPosterize", this.StormFlashOnOff);
			this.AELJLBOJAIL().SetFloat("_ScreenResolution", this.DropOnOff);
			this.DNLMFEGJJDD().SetFloat("maps.", this._FixDistance);
			this.HFBJAOFLCJI().SetFloat("EXCEPTION:", (float)((!this._Visualize) ? 0 : 0));
			this.LDNADDJMIPK().SetFloat("menu.selectedlevelid", this.Drop_Near);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Distortion_Heat", this.Drop_Far);
			this.IONHGBPGCHK().SetFloat("[GameScene] Events count: ", 1032f - this.Drop_With_Obj);
			this.IONHGBPGCHK().SetFloat("_ScreenResolution", this.Myst);
			this.NBPKMLMCHFN.SetColor("player.crystal", this.Myst_Color);
			this.JFDGLLEOPGB().SetFloat("[LevelEditorScene] Error: You're not logged into Steam!", this.Drop_Floor_Fluid);
			this.IONHGBPGCHK().SetVector("{0:0} day{1}, ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 163f, 1195f));
			this.IONHGBPGCHK().SetTexture("CameraFilterPack/Color_BrightContrastSaturation", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000ED8 RID: 3800 RVA: 0x00069B38 File Offset: 0x00067D38
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000ED9 RID: 3801 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06000EDA RID: 3802 RVA: 0x00069B6F File Offset: 0x00067D6F
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000EDB RID: 3803 RVA: 0x00069BA6 File Offset: 0x00067DA6
	private void FANADGBGCPI()
	{
		this.FPHEBLMINDA = (Resources.Load("CurrentTimeLabel") as Texture2D);
		this.SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000EDC RID: 3804 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06000EDD RID: 3805 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06000EDF RID: 3807 RVA: 0x000677B0 File Offset: 0x000659B0
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EE0 RID: 3808 RVA: 0x000677B0 File Offset: 0x000659B0
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EE1 RID: 3809 RVA: 0x000677B0 File Offset: 0x000659B0
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000EE2 RID: 3810 RVA: 0x00069CA4 File Offset: 0x00067EA4
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 70f)
			{
				this.HBJJOCHGOPH = 1076f;
			}
			this.EPCGJFCCAFH().SetFloat("musicVolume", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("1", this.Fade);
			this.EPCGJFCCAFH().SetFloat("_MainTex2", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 1964f && z < 1854f)
				{
					this.HEHKGPKLAKK().SetFloat("_ColorBuffer", z);
				}
				if (z < 311f)
				{
					this.BFGNMFCNDBC().SetFloat(" By: ", z);
				}
			}
			else
			{
				this.HKGAONMOBMH().SetFloat("IconImage", this.DirectionX);
			}
			this.BFGNMFCNDBC().SetFloat(" TimeOfRespawn: ", this.Speed);
			this.HEHKGPKLAKK().SetFloat("{0}", this.Size);
			this.IONHGBPGCHK().SetFloat(".sawoutdatedmessage", this.Distortion);
			this.BFGNMFCNDBC().SetFloat("FinalScoreText", this.StormFlashOnOff);
			this.PGPEMMBJOOG().SetFloat("_ScreenResolution", this.DropOnOff);
			this.JFDGLLEOPGB().SetFloat("/", this._FixDistance);
			this.IONHGBPGCHK().SetFloat("RoomNameText", (float)((!this._Visualize) ? 1 : 1));
			this.AELJLBOJAIL().SetFloat("Left", this.Drop_Near);
			this.EPCGJFCCAFH().SetFloat("HightScoreMaxPointsText", this.Drop_Far);
			this.HKGAONMOBMH().SetFloat("_ScreenResolution", 1983f - this.Drop_With_Obj);
			this.EPCGJFCCAFH().SetFloat("CameraFilterPack/BlurTiltShift", this.Myst);
			this.AELJLBOJAIL().SetColor("_Value2", this.Myst_Color);
			this.HFBJAOFLCJI().SetFloat("Bad parameters for getstring! Use <key> <value>", this.Drop_Floor_Fluid);
			this.IONHGBPGCHK().SetVector("checkpoint", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 382f, 1302f));
			this.DNLMFEGJJDD().SetTexture("float,10", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EE3 RID: 3811 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06000EE4 RID: 3812 RVA: 0x00069F4C File Offset: 0x0006814C
	private void HMPGIFBJFIK()
	{
		this.FPHEBLMINDA = (Resources.Load("Current xp: ") as Texture2D);
		this.SCShader = Shader.Find("#close");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000EE5 RID: 3813 RVA: 0x00069F88 File Offset: 0x00068188
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 499f)
			{
				this.HBJJOCHGOPH = 750f;
			}
			this.PGPEMMBJOOG().SetFloat("skin.", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("[LevelEditorScene] Error: You're not logged into Steam!", this.Fade);
			this.HKGAONMOBMH().SetFloat("levelcompleted", this.Intensity);
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 493f && z < 593f)
				{
					this.AELJLBOJAIL().SetFloat("mapid", z);
				}
				if (z < 953f)
				{
					this.LDNADDJMIPK().SetFloat("_ToneCurve", z);
				}
			}
			else
			{
				this.HKGAONMOBMH().SetFloat(" at ", this.DirectionX);
			}
			this.DNLMFEGJJDD().SetFloat("_TimeX", this.Speed);
			this.DNLMFEGJJDD().SetFloat("float,10", this.Size);
			this.PGPEMMBJOOG().SetFloat("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results", this.Distortion);
			this.IONHGBPGCHK().SetFloat("_TimeX", this.StormFlashOnOff);
			this.PGPEMMBJOOG().SetFloat("_Speed", this.DropOnOff);
			this.JFDGLLEOPGB().SetFloat(" not exist", this._FixDistance);
			this.ADGHJOHKEHG().SetFloat("_Value", (float)((!this._Visualize) ? 0 : 1));
			this.HEHKGPKLAKK().SetFloat("Exception caught! ", this.Drop_Near);
			this.LDNADDJMIPK().SetFloat("Object ID. Case-Sensitive", this.Drop_Far);
			this.ADGHJOHKEHG().SetFloat("_TimeX", 557f - this.Drop_With_Obj);
			this.JFDGLLEOPGB().SetFloat("_Value3", this.Myst);
			this.HFBJAOFLCJI().SetColor("_Value", this.Myst_Color);
			this.EPCGJFCCAFH().SetFloat("Data/Skins/", this.Drop_Floor_Fluid);
			this.PGPEMMBJOOG().SetVector("SelectionBox component must be placed on a canvas in Screen Space Overlay mode.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 506f, 1378f));
			this.HFBJAOFLCJI().SetTexture("shader.crispwinter", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EE6 RID: 3814 RVA: 0x0006A230 File Offset: 0x00068430
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
			if (this.DirectionFollowCameraZ)
			{
				float z = base.GetComponent<Camera>().transform.rotation.z;
				if (z > 0f && z < 360f)
				{
					this.NBPKMLMCHFN.SetFloat("_Value3", z);
				}
				if (z < 0f)
				{
					this.NBPKMLMCHFN.SetFloat("_Value3", z);
				}
			}
			else
			{
				this.NBPKMLMCHFN.SetFloat("_Value3", this.DirectionX);
			}
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Value6", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("_Value7", this.StormFlashOnOff);
			this.NBPKMLMCHFN.SetFloat("_Value8", this.DropOnOff);
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("_Visualize", (float)((!this._Visualize) ? 0 : 1));
			this.NBPKMLMCHFN.SetFloat("Drop_Near", this.Drop_Near);
			this.NBPKMLMCHFN.SetFloat("Drop_Far", this.Drop_Far);
			this.NBPKMLMCHFN.SetFloat("Drop_With_Obj", 1f - this.Drop_With_Obj);
			this.NBPKMLMCHFN.SetFloat("Myst", this.Myst);
			this.NBPKMLMCHFN.SetColor("Myst_Color", this.Myst_Color);
			this.NBPKMLMCHFN.SetFloat("Drop_Floor_Fluid", this.Drop_Floor_Fluid);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			this.NBPKMLMCHFN.SetTexture("Texture2", this.FPHEBLMINDA);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000EE7 RID: 3815 RVA: 0x0006A4D8 File Offset: 0x000686D8
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000219 RID: 537
	public Shader SCShader;

	// Token: 0x0400021A RID: 538
	public bool _Visualize;

	// Token: 0x0400021B RID: 539
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400021C RID: 540
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400021D RID: 541
	private Material BJFKDHHMLJH;

	// Token: 0x0400021E RID: 542
	[Range(0f, 100f)]
	public float _FixDistance = 3f;

	// Token: 0x0400021F RID: 543
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x04000220 RID: 544
	[Range(0f, 2f)]
	public float Intensity = 0.5f;

	// Token: 0x04000221 RID: 545
	public bool DirectionFollowCameraZ;

	// Token: 0x04000222 RID: 546
	[Range(-0.45f, 0.45f)]
	public float DirectionX = 0.12f;

	// Token: 0x04000223 RID: 547
	[Range(0.4f, 2f)]
	public float Size = 1.5f;

	// Token: 0x04000224 RID: 548
	[Range(0f, 0.5f)]
	public float Speed = 0.275f;

	// Token: 0x04000225 RID: 549
	[Range(0f, 0.5f)]
	public float Distortion = 0.025f;

	// Token: 0x04000226 RID: 550
	[Range(0f, 1f)]
	public float StormFlashOnOff = 1f;

	// Token: 0x04000227 RID: 551
	[Range(0f, 1f)]
	public float DropOnOff = 1f;

	// Token: 0x04000228 RID: 552
	[Range(-0.5f, 0.99f)]
	public float Drop_Near;

	// Token: 0x04000229 RID: 553
	[Range(0f, 1f)]
	public float Drop_Far = 0.5f;

	// Token: 0x0400022A RID: 554
	[Range(0f, 1f)]
	public float Drop_With_Obj = 0.2f;

	// Token: 0x0400022B RID: 555
	[Range(0f, 1f)]
	public float Myst = 0.1f;

	// Token: 0x0400022C RID: 556
	[Range(0f, 1f)]
	public float Drop_Floor_Fluid;

	// Token: 0x0400022D RID: 557
	public Color Myst_Color = new Color(0.5f, 0.5f, 0.5f, 1f);

	// Token: 0x0400022E RID: 558
	private Texture2D FPHEBLMINDA;
}
