using System;
using UnityEngine;

// Token: 0x0200001E RID: 30
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/BlackHole")]
public class CameraFilterPack_3D_BlackHole : MonoBehaviour
{
	// Token: 0x060005ED RID: 1517 RVA: 0x000300DA File Offset: 0x0002E2DA
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005EE RID: 1518 RVA: 0x000300DA File Offset: 0x0002E2DA
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005EF RID: 1519 RVA: 0x000300F8 File Offset: 0x0002E2F8
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 117f)
			{
				this.HBJJOCHGOPH = 1626f;
			}
			this.KEMJNOMIPHN().SetFloat("[NetworkManager] Exited", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 532f)
				{
					this._Distance = 820f;
				}
				if (this._Distance < 1157f)
				{
					this._Distance = 1744f;
				}
				this.LPMLLJKMAMP().SetFloat("SetPosition", this._Distance);
			}
			else
			{
				this.KEMJNOMIPHN().SetFloat("x", this._Distance);
			}
			this.HKGAONMOBMH().SetFloat("_ScreenResolution", this._Size);
			this.PLBEJJIHFPB().SetFloat(" to: ", this._FixDistance);
			this.HCGJCMDJPGD().SetFloat("_Speed", this.DistortionLevel);
			this.LDNADDJMIPK().SetFloat("[Left]", this.DistortionSize);
			this.ADGHJOHKEHG().SetFloat("_Intensity", (float)((!this._Visualize) ? 0 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MMOODGIODPC().SetFloat("player.goldbat", 1080f / farClipPlane);
			this.LPMLLJKMAMP().SetVector("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 50f, 1835f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005F0 RID: 1520 RVA: 0x000302D4 File Offset: 0x0002E4D4
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 784f)
			{
				this.HBJJOCHGOPH = 266f;
			}
			this.LDNADDJMIPK().SetFloat("colorA", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 873f)
				{
					this._Distance = 1541f;
				}
				if (this._Distance < 190f)
				{
					this._Distance = 1123f;
				}
				this.JFDGLLEOPGB().SetFloat("inventory.selected.", this._Distance);
			}
			else
			{
				this.JFDGLLEOPGB().SetFloat("_PrevViewProj", this._Distance);
			}
			this.MMOODGIODPC().SetFloat("_BlurRadius", this._Size);
			this.HCGJCMDJPGD().SetFloat("replayData", this._FixDistance);
			this.LPMLLJKMAMP().SetFloat("win", this.DistortionLevel);
			this.HCGJCMDJPGD().SetFloat("_TimeX", this.DistortionSize);
			this.PLBEJJIHFPB().SetFloat("tagElement", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.GHHPOGODBHB().SetFloat("_TimeX", 1006f / farClipPlane);
			this.ADGHJOHKEHG().SetVector("ItemsCountText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 841f, 1123f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005F1 RID: 1521 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x060005F2 RID: 1522 RVA: 0x000304B0 File Offset: 0x0002E6B0
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060005F3 RID: 1523 RVA: 0x000304D4 File Offset: 0x0002E6D4
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 322f)
			{
				this.HBJJOCHGOPH = 1971f;
			}
			this.JFDGLLEOPGB().SetFloat("[LobbyPlayerElement] On ready click", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1539f)
				{
					this._Distance = 170f;
				}
				if (this._Distance < 1592f)
				{
					this._Distance = 1469f;
				}
				this.HKGAONMOBMH().SetFloat("/", this._Distance);
			}
			else
			{
				this.LDNADDJMIPK().SetFloat("_Value3", this._Distance);
			}
			this.JFDGLLEOPGB().SetFloat("-1", this._Size);
			this.HKGAONMOBMH().SetFloat("#or", this._FixDistance);
			this.LPMLLJKMAMP().SetFloat("float,0", this.DistortionLevel);
			this.LDNADDJMIPK().SetFloat("finished", this.DistortionSize);
			this.HKGAONMOBMH().SetFloat("CameraFilterPack/TV_Noise", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HKGAONMOBMH().SetFloat("PointsScoreText", 1893f / farClipPlane);
			this.LDNADDJMIPK().SetVector("DifficultyBG", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 225f, 209f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005F4 RID: 1524 RVA: 0x000306B0 File Offset: 0x0002E8B0
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find(".lastCheckpoint.comboScore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060005F5 RID: 1525 RVA: 0x000306D4 File Offset: 0x0002E8D4
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("open");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060005F6 RID: 1526 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x060005F7 RID: 1527 RVA: 0x000300DA File Offset: 0x0002E2DA
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005F8 RID: 1528 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x060005F9 RID: 1529 RVA: 0x000300DA File Offset: 0x0002E2DA
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005FA RID: 1530 RVA: 0x000300DA File Offset: 0x0002E2DA
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005FB RID: 1531 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x060005FC RID: 1532 RVA: 0x000300DA File Offset: 0x0002E2DA
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060005FD RID: 1533 RVA: 0x000306F8 File Offset: 0x0002E8F8
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1676f)
			{
				this.HBJJOCHGOPH = 1688f;
			}
			this.MFHPKGICPIO().SetFloat("z", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1271f)
				{
					this._Distance = 361f;
				}
				if (this._Distance < 1291f)
				{
					this._Distance = 1192f;
				}
				this.HKGAONMOBMH().SetFloat("LostAllLives", this._Distance);
			}
			else
			{
				this.KEMJNOMIPHN().SetFloat("player.circle", this._Distance);
			}
			this.LPMLLJKMAMP().SetFloat("VisionBlur", this._Size);
			this.ADGHJOHKEHG().SetFloat("_TimeX", this._FixDistance);
			this.JFDGLLEOPGB().SetFloat("Mouse Y", this.DistortionLevel);
			this.HKGAONMOBMH().SetFloat(".lastCheckpoint.checkpointsUsed", this.DistortionSize);
			this.PLBEJJIHFPB().SetFloat(" timeUntilRespawnBasedOnTimeBase:", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.KEMJNOMIPHN().SetFloat("_ScreenResolution", 1254f / farClipPlane);
			this.HCGJCMDJPGD().SetVector("_ColorBuffer", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 890f, 1740f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005FE RID: 1534 RVA: 0x000308D4 File Offset: 0x0002EAD4
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1109f)
			{
				this.HBJJOCHGOPH = 780f;
			}
			this.MMOODGIODPC().SetFloat("Joystick1Button0", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1536f)
				{
					this._Distance = 1774f;
				}
				if (this._Distance < 288f)
				{
					this._Distance = 1607f;
				}
				this.LDNADDJMIPK().SetFloat("PublishButton", this._Distance);
			}
			else
			{
				this.LDNADDJMIPK().SetFloat("CameraFilterPack/Blur_Noise", this._Distance);
			}
			this.GHHPOGODBHB().SetFloat("maps.", this._Size);
			this.PLBEJJIHFPB().SetFloat("RecordButton", this._FixDistance);
			this.HKGAONMOBMH().SetFloat("OpGetGameList()", this.DistortionLevel);
			this.NBPKMLMCHFN.SetFloat("Overlay", this.DistortionSize);
			this.NBPKMLMCHFN.SetFloat("#tryagain", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.HCGJCMDJPGD().SetFloat("ConfigVersionSlider", 1387f / farClipPlane);
			this.HCGJCMDJPGD().SetVector("UNDISTORT", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 340f, 1588f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060005FF RID: 1535 RVA: 0x00030AB0 File Offset: 0x0002ECB0
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1268f)
			{
				this.HBJJOCHGOPH = 1157f;
			}
			this.NBPKMLMCHFN.SetFloat("Exception caught! ", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1365f)
				{
					this._Distance = 1674f;
				}
				if (this._Distance < 418f)
				{
					this._Distance = 587f;
				}
				this.GHHPOGODBHB().SetFloat("_ScreenResolution", this._Distance);
			}
			else
			{
				this.LDNADDJMIPK().SetFloat("InfoButton", this._Distance);
			}
			this.EJDPNJAEAKJ().SetFloat("_ScreenResolution", this._Size);
			this.LDNADDJMIPK().SetFloat(".", this._FixDistance);
			this.EJDPNJAEAKJ().SetFloat("_Value3", this.DistortionLevel);
			this.EOCCJGIGEGJ().SetFloat("skin.", this.DistortionSize);
			this.HCGJCMDJPGD().SetFloat("_BlurDirectionPacked", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.EOCCJGIGEGJ().SetFloat("CameraFilterPack/Drawing_Manga3", 1504f / farClipPlane);
			this.PLBEJJIHFPB().SetVector("SetParticlesParticleSpeed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 517f, 304f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000600 RID: 1536 RVA: 0x00030C8C File Offset: 0x0002EE8C
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000601 RID: 1537 RVA: 0x00030CC3 File Offset: 0x0002EEC3
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000602 RID: 1538 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x06000603 RID: 1539 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06000604 RID: 1540 RVA: 0x00030CFA File Offset: 0x0002EEFA
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find(" not exist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000605 RID: 1541 RVA: 0x00030D1E File Offset: 0x0002EF1E
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000606 RID: 1542 RVA: 0x000300DA File Offset: 0x0002E2DA
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000607 RID: 1543 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06000608 RID: 1544 RVA: 0x00030D55 File Offset: 0x0002EF55
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000609 RID: 1545 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600060A RID: 1546 RVA: 0x000300DA File Offset: 0x0002E2DA
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600060B RID: 1547 RVA: 0x00030D8C File Offset: 0x0002EF8C
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 807f)
			{
				this.HBJJOCHGOPH = 630f;
			}
			this.KEMJNOMIPHN().SetFloat("_TimeX", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1083f)
				{
					this._Distance = 1187f;
				}
				if (this._Distance < 1437f)
				{
					this._Distance = 1853f;
				}
				this.NBPKMLMCHFN.SetFloat("checkpoint", this._Distance);
			}
			else
			{
				this.HKGAONMOBMH().SetFloat("_FresnelFadePower", this._Distance);
			}
			this.GHHPOGODBHB().SetFloat("Tab2Content", this._Size);
			this.MFHPKGICPIO().SetFloat(",", this._FixDistance);
			this.EJDPNJAEAKJ().SetFloat("ComboText", this.DistortionLevel);
			this.KEMJNOMIPHN().SetFloat("_ColorR", this.DistortionSize);
			this.MFHPKGICPIO().SetFloat("0", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MFHPKGICPIO().SetFloat("_Distortion", 666f / farClipPlane);
			this.LDNADDJMIPK().SetVector("Received RPC \"", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1703f, 1352f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600060C RID: 1548 RVA: 0x00030F68 File Offset: 0x0002F168
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
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1f)
				{
					this._Distance = -1f;
				}
				if (this._Distance < -1f)
				{
					this._Distance = 1f;
				}
				this.NBPKMLMCHFN.SetFloat("_Near", this._Distance);
			}
			else
			{
				this.NBPKMLMCHFN.SetFloat("_Near", this._Distance);
			}
			this.NBPKMLMCHFN.SetFloat("_Far", this._Size);
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("_DistortionLevel", this.DistortionLevel);
			this.NBPKMLMCHFN.SetFloat("_DistortionSize", this.DistortionSize);
			this.NBPKMLMCHFN.SetFloat("_Visualize", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.NBPKMLMCHFN.SetFloat("_FarCamera", 1000f / farClipPlane);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600060D RID: 1549 RVA: 0x00031144 File Offset: 0x0002F344
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600060E RID: 1550 RVA: 0x0003117C File Offset: 0x0002F37C
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 930f)
			{
				this.HBJJOCHGOPH = 1316f;
			}
			this.EOCCJGIGEGJ().SetFloat(".lastCheckpoint.longestComboScore", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1415f)
				{
					this._Distance = 1565f;
				}
				if (this._Distance < 1296f)
				{
					this._Distance = 1872f;
				}
				this.HKGAONMOBMH().SetFloat("_MainTex2", this._Distance);
			}
			else
			{
				this.PLBEJJIHFPB().SetFloat("_Size", this._Distance);
			}
			this.GHHPOGODBHB().SetFloat("finished", this._Size);
			this.EOCCJGIGEGJ().SetFloat(".lastCheckpoint.incorrectScore", this._FixDistance);
			this.GHHPOGODBHB().SetFloat("DPADVER", this.DistortionLevel);
			this.ADGHJOHKEHG().SetFloat("wss://", this.DistortionSize);
			this.PLBEJJIHFPB().SetFloat("Joystick1Button6", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MFHPKGICPIO().SetFloat("_TintColor", 486f / farClipPlane);
			this.PLBEJJIHFPB().SetVector("_MatrixSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 609f, 1468f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600060F RID: 1551 RVA: 0x00031358 File Offset: 0x0002F558
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("solo");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000610 RID: 1552 RVA: 0x000300DA File Offset: 0x0002E2DA
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000611 RID: 1553 RVA: 0x0003137C File Offset: 0x0002F57C
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1901f)
			{
				this.HBJJOCHGOPH = 1737f;
			}
			this.ADGHJOHKEHG().SetFloat("[EMPTY]", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 953f)
				{
					this._Distance = 739f;
				}
				if (this._Distance < 1433f)
				{
					this._Distance = 563f;
				}
				this.EOCCJGIGEGJ().SetFloat(" ", this._Distance);
			}
			else
			{
				this.EOCCJGIGEGJ().SetFloat("workshop.", this._Distance);
			}
			this.MMOODGIODPC().SetFloat("1,30,true,0", this._Size);
			this.JFDGLLEOPGB().SetFloat("_MatrixSize", this._FixDistance);
			this.KEMJNOMIPHN().SetFloat("_SearchTex", this.DistortionLevel);
			this.GHHPOGODBHB().SetFloat("Anomaly_Far", this.DistortionSize);
			this.JFDGLLEOPGB().SetFloat("Set Trail Zoom (player camera move forward effect). Base value - 1.5", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LDNADDJMIPK().SetFloat(" .", 248f / farClipPlane);
			this.JFDGLLEOPGB().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1017f, 204f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000612 RID: 1554 RVA: 0x00031558 File Offset: 0x0002F758
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1501f)
			{
				this.HBJJOCHGOPH = 1370f;
			}
			this.HKGAONMOBMH().SetFloat("fade out duration", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1536f)
				{
					this._Distance = 62f;
				}
				if (this._Distance < 1520f)
				{
					this._Distance = 72f;
				}
				this.EOCCJGIGEGJ().SetFloat("_Value7", this._Distance);
			}
			else
			{
				this.NBPKMLMCHFN.SetFloat("MenuScene", this._Distance);
			}
			this.EOCCJGIGEGJ().SetFloat("_Value3", this._Size);
			this.ADGHJOHKEHG().SetFloat(". The RPC has been ignored.", this._FixDistance);
			this.JFDGLLEOPGB().SetFloat("Tab2Content", this.DistortionLevel);
			this.MFHPKGICPIO().SetFloat("Needs to be attached to the Event System component in the scene", this.DistortionSize);
			this.HCGJCMDJPGD().SetFloat("settings.selectormapsperpage", (float)((!this._Visualize) ? 0 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LPMLLJKMAMP().SetFloat("settings.disablestoryboard", 344f / farClipPlane);
			this.KEMJNOMIPHN().SetVector("MusicFileSelector", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1745f, 654f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000613 RID: 1555 RVA: 0x00031734 File Offset: 0x0002F934
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000614 RID: 1556 RVA: 0x0003176B File Offset: 0x0002F96B
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-76);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000615 RID: 1557 RVA: 0x000317A2 File Offset: 0x0002F9A2
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000616 RID: 1558 RVA: 0x000317C8 File Offset: 0x0002F9C8
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 888f)
			{
				this.HBJJOCHGOPH = 1149f;
			}
			this.GHHPOGODBHB().SetFloat(".lastCheckpoint.penaltyScore", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 1880f)
				{
					this._Distance = 1817f;
				}
				if (this._Distance < 1729f)
				{
					this._Distance = 657f;
				}
				this.EOCCJGIGEGJ().SetFloat("#score", this._Distance);
			}
			else
			{
				this.MMOODGIODPC().SetFloat("http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?format=json&appid=513510", this._Distance);
			}
			this.PLBEJJIHFPB().SetFloat("_Value4", this._Size);
			this.PLBEJJIHFPB().SetFloat("_Distortion", this._FixDistance);
			this.MMOODGIODPC().SetFloat("_Green_C", this.DistortionLevel);
			this.ADGHJOHKEHG().SetFloat("ShowTitle", this.DistortionSize);
			this.ADGHJOHKEHG().SetFloat("Object ID. Case-Sensitive", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.LDNADDJMIPK().SetFloat("Skipping EstablishEncryption. Protocol is secure.", 365f / farClipPlane);
			this.EJDPNJAEAKJ().SetVector("CameraFilterPack/AAA_Blood_Plus", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1514f, 1504f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000617 RID: 1559 RVA: 0x000319A4 File Offset: 0x0002FBA4
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("Tab2Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000618 RID: 1560 RVA: 0x000300DA File Offset: 0x0002E2DA
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000619 RID: 1561 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x0600061A RID: 1562 RVA: 0x000319C8 File Offset: 0x0002FBC8
	private Material GHHPOGODBHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600061B RID: 1563 RVA: 0x000319FF File Offset: 0x0002FBFF
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600061C RID: 1564 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x0600061D RID: 1565 RVA: 0x00031A36 File Offset: 0x0002FC36
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("settings.enablehitsoundsinnormal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600061E RID: 1566 RVA: 0x000300DA File Offset: 0x0002E2DA
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000620 RID: 1568 RVA: 0x00031AB4 File Offset: 0x0002FCB4
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1119f)
			{
				this.HBJJOCHGOPH = 552f;
			}
			this.MMOODGIODPC().SetFloat(" ", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 712f)
				{
					this._Distance = 844f;
				}
				if (this._Distance < 972f)
				{
					this._Distance = 78f;
				}
				this.GHHPOGODBHB().SetFloat("_TimeX", this._Distance);
			}
			else
			{
				this.KEMJNOMIPHN().SetFloat("Mouse", this._Distance);
			}
			this.KEMJNOMIPHN().SetFloat("GlassesColor", this._Size);
			this.KEMJNOMIPHN().SetFloat("https://twitch.tv/intralism", this._FixDistance);
			this.LDNADDJMIPK().SetFloat("_SSAO", this.DistortionLevel);
			this.EOCCJGIGEGJ().SetFloat("Need to specify a start index and end index.", this.DistortionSize);
			this.NBPKMLMCHFN.SetFloat("ItemNameBGImage", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.PLBEJJIHFPB().SetFloat("DPADHOR", 745f / farClipPlane);
			this.ADGHJOHKEHG().SetVector("float,1.5", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1709f, 863f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000621 RID: 1569 RVA: 0x000300DA File Offset: 0x0002E2DA
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000622 RID: 1570 RVA: 0x00031C90 File Offset: 0x0002FE90
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000623 RID: 1571 RVA: 0x000300DA File Offset: 0x0002E2DA
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000624 RID: 1572 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06000625 RID: 1573 RVA: 0x00031CC7 File Offset: 0x0002FEC7
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000626 RID: 1574 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06000627 RID: 1575 RVA: 0x00031CFE File Offset: 0x0002FEFE
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find("\\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000628 RID: 1576 RVA: 0x00031D22 File Offset: 0x0002FF22
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000629 RID: 1577 RVA: 0x00031D5C File Offset: 0x0002FF5C
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 465f)
			{
				this.HBJJOCHGOPH = 840f;
			}
			this.LDNADDJMIPK().SetFloat("_SecondTex", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 706f)
				{
					this._Distance = 288f;
				}
				if (this._Distance < 1217f)
				{
					this._Distance = 12f;
				}
				this.KEMJNOMIPHN().SetFloat("[Up-Down]", this._Distance);
			}
			else
			{
				this.KEMJNOMIPHN().SetFloat(", ", this._Distance);
			}
			this.ADGHJOHKEHG().SetFloat("Hex value #RRGGBB", this._Size);
			this.NBPKMLMCHFN.SetFloat("settings.volume.editor", this._FixDistance);
			this.MFHPKGICPIO().SetFloat("_Offsets", this.DistortionLevel);
			this.GHHPOGODBHB().SetFloat("Player", this.DistortionSize);
			this.HCGJCMDJPGD().SetFloat("/icon", (float)((!this._Visualize) ? 1 : 0));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MMOODGIODPC().SetFloat("menu.selectedlevelid", 212f / farClipPlane);
			this.KEMJNOMIPHN().SetVector("_MainTex2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 146f, 38f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600062A RID: 1578 RVA: 0x00031F38 File Offset: 0x00030138
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("_ToPrevViewProjCombined");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x17000005 RID: 5
	// (get) Token: 0x0600062B RID: 1579 RVA: 0x00031F5C File Offset: 0x0003015C
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

	// Token: 0x0600062C RID: 1580 RVA: 0x000300DA File Offset: 0x0002E2DA
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600062D RID: 1581 RVA: 0x000300DA File Offset: 0x0002E2DA
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600062E RID: 1582 RVA: 0x00031F93 File Offset: 0x00030193
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)73;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600062F RID: 1583 RVA: 0x000300DA File Offset: 0x0002E2DA
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000630 RID: 1584 RVA: 0x000300DA File Offset: 0x0002E2DA
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000631 RID: 1585 RVA: 0x000300DA File Offset: 0x0002E2DA
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000632 RID: 1586 RVA: 0x00031FCC File Offset: 0x000301CC
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 948f)
			{
				this.HBJJOCHGOPH = 700f;
			}
			this.HKGAONMOBMH().SetFloat("[Up-Right-Down-Left]", this.HBJJOCHGOPH);
			if (this.AutoAnimatedNear)
			{
				this._Distance += Time.deltaTime * this.AutoAnimatedNearSpeed;
				if (this._Distance > 248f)
				{
					this._Distance = 977f;
				}
				if (this._Distance < 410f)
				{
					this._Distance = 1f;
				}
				this.EOCCJGIGEGJ().SetFloat("/", this._Distance);
			}
			else
			{
				this.NBPKMLMCHFN.SetFloat("mapselector.filter.favoriteonly", this._Distance);
			}
			this.EOCCJGIGEGJ().SetFloat("_BlurVector", this._Size);
			this.EOCCJGIGEGJ().SetFloat("NetworkScene", this._FixDistance);
			this.LPMLLJKMAMP().SetFloat("CameraFilterPack/FX_8bits", this.DistortionLevel);
			this.JFDGLLEOPGB().SetFloat("_Value4", this.DistortionSize);
			this.HCGJCMDJPGD().SetFloat("maps.", (float)((!this._Visualize) ? 1 : 1));
			float farClipPlane = base.GetComponent<Camera>().farClipPlane;
			this.MFHPKGICPIO().SetFloat("PunSupportLogger", 1002f / farClipPlane);
			this.KEMJNOMIPHN().SetVector("MenuVolumeSlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1272f, 575f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000633 RID: 1587 RVA: 0x000321A8 File Offset: 0x000303A8
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_BlackHole");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000634 RID: 1588 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x040000E5 RID: 229
	public Shader SCShader;

	// Token: 0x040000E6 RID: 230
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040000E7 RID: 231
	public bool _Visualize;

	// Token: 0x040000E8 RID: 232
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040000E9 RID: 233
	private Material BJFKDHHMLJH;

	// Token: 0x040000EA RID: 234
	[Range(0f, 100f)]
	public float _FixDistance = 5f;

	// Token: 0x040000EB RID: 235
	[Range(-0.99f, 0.99f)]
	public float _Distance = 0.05f;

	// Token: 0x040000EC RID: 236
	[Range(0f, 1f)]
	public float _Size = 0.25f;

	// Token: 0x040000ED RID: 237
	[Range(-2f, 2f)]
	public float DistortionLevel = 1.2f;

	// Token: 0x040000EE RID: 238
	[Range(0f, 1f)]
	public float DistortionSize;

	// Token: 0x040000EF RID: 239
	public bool AutoAnimatedNear;

	// Token: 0x040000F0 RID: 240
	[Range(-5f, 5f)]
	public float AutoAnimatedNearSpeed = 0.5f;

	// Token: 0x040000F1 RID: 241
	public static Color ChangeColorRGB;
}
