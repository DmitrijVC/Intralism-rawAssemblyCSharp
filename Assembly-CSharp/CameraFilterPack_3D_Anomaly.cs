using System;
using UnityEngine;

// Token: 0x0200001C RID: 28
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/3D/Anomaly")]
public class CameraFilterPack_3D_Anomaly : MonoBehaviour
{
	// Token: 0x06000527 RID: 1319 RVA: 0x0002AFDD File Offset: 0x000291DD
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("&map=");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000528 RID: 1320 RVA: 0x0002B001 File Offset: 0x00029201
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000529 RID: 1321 RVA: 0x0002B038 File Offset: 0x00029238
	private void FMNPFCHBLJF()
	{
		this.SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600052A RID: 1322 RVA: 0x0002B05C File Offset: 0x0002925C
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("SetPlayerDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600052B RID: 1323 RVA: 0x0002B080 File Offset: 0x00029280
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600052C RID: 1324 RVA: 0x0002B0A0 File Offset: 0x000292A0
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1136f)
			{
				this.HBJJOCHGOPH = 597f;
			}
			this.KGOLDDBHIFN().SetFloat("[PlayerBase] Starting new round", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("LoadMapCanvas", this.Intensity);
			this.KEMAALEODNH().SetFloat("PlayersScrollRectContent", this.Anomaly_Distortion);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Broken_Screen", this.Anomaly_Distortion_Size);
			this.KDMBOKLMADJ().SetFloat("SpawnObj", this.Anomaly_Intensity);
			this.IIBLJCKLGFG().SetFloat("CameraFilterPack/Blur_Focus", (float)((!this._Visualize) ? 0 : 1));
			this.NBPKMLMCHFN.SetFloat("_Value2", this._FixDistance);
			this.KEMJNOMIPHN().SetFloat("SetSatelliteTrailLength", this.Anomaly_Near);
			this.MMOODGIODPC().SetFloat("SetSatelliteTrailMinVertexDistance", this.Anomaly_Far);
			this.IIBLJCKLGFG().SetFloat("FileMenu", this.AnomalyWithoutObject);
			this.KEMAALEODNH().SetVector("_ReflectionTexture0", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 777f, 287f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600052D RID: 1325 RVA: 0x0002B228 File Offset: 0x00029428
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 977f)
			{
				this.HBJJOCHGOPH = 637f;
			}
			this.LPCHMEKDCHI().SetFloat("Can't start OFFLINE mode while connected!", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("_ScreenResolution", this.Intensity);
			this.CIAFLBFJLEJ().SetFloat("_ScreenResolution", this.Anomaly_Distortion);
			this.LDNADDJMIPK().SetFloat("[MapData] Map timing update from: ", this.Anomaly_Distortion_Size);
			this.KEMJNOMIPHN().SetFloat("Bass", this.Anomaly_Intensity);
			this.NFMGLIKNOOC().SetFloat("UseFinalGlassColor", (float)((!this._Visualize) ? 0 : 0));
			this.KEMJNOMIPHN().SetFloat(".icon", this._FixDistance);
			this.LONNIJMNKFB().SetFloat("D-Pad Down", this.Anomaly_Near);
			this.LDNADDJMIPK().SetFloat("y", this.Anomaly_Far);
			this.KDMBOKLMADJ().SetFloat("0.00", this.AnomalyWithoutObject);
			this.KBOPGONOCNP().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1451f, 1539f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600052E RID: 1326 RVA: 0x0002B3AE File Offset: 0x000295AE
	private void FANADGBGCPI()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600052F RID: 1327 RVA: 0x0002B3D2 File Offset: 0x000295D2
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("_Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000530 RID: 1328 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x06000531 RID: 1329 RVA: 0x0002B3F8 File Offset: 0x000295F8
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1398f)
			{
				this.HBJJOCHGOPH = 1073f;
			}
			this.CIAFLBFJLEJ().SetFloat(" not exist", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("NEW_ACHIEVEMENT_1_", this.Intensity);
			this.KDMBOKLMADJ().SetFloat("Right Stick Click", this.Anomaly_Distortion);
			this.KEMAALEODNH().SetFloat("NO", this.Anomaly_Distortion_Size);
			this.LDNADDJMIPK().SetFloat("mapselector.filter.rateduponly", this.Anomaly_Intensity);
			this.NFMGLIKNOOC().SetFloat("Tab2Content", (float)((!this._Visualize) ? 1 : 0));
			this.KEMAALEODNH().SetFloat(" ", this._FixDistance);
			this.LDNADDJMIPK().SetFloat(" ", this.Anomaly_Near);
			this.HKIMAANBGMJ().SetFloat("shader.future", this.Anomaly_Far);
			this.KGOLDDBHIFN().SetFloat("team", this.AnomalyWithoutObject);
			this.LONNIJMNKFB().SetVector("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 90f, 1711f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000532 RID: 1330 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06000533 RID: 1331 RVA: 0x0002B57E File Offset: 0x0002977E
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000534 RID: 1332 RVA: 0x0002B5B8 File Offset: 0x000297B8
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1014f)
			{
				this.HBJJOCHGOPH = 1243f;
			}
			this.KGOLDDBHIFN().SetFloat("_Near", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value", this.Intensity);
			this.OJMHIMIPKME().SetFloat("note.7", this.Anomaly_Distortion);
			this.LONNIJMNKFB().SetFloat("_Value3", this.Anomaly_Distortion_Size);
			this.LPCHMEKDCHI().SetFloat("shader.pixel", this.Anomaly_Intensity);
			this.KGOLDDBHIFN().SetFloat("#alreadyexist", (float)((!this._Visualize) ? 0 : 0));
			this.KGOLDDBHIFN().SetFloat("_Quality", this._FixDistance);
			this.LPCHMEKDCHI().SetFloat("#getrewardnow ", this.Anomaly_Near);
			this.LPCHMEKDCHI().SetFloat(". Not connectedAndReady.", this.Anomaly_Far);
			this.KBOPGONOCNP().SetFloat("a year ago", this.AnomalyWithoutObject);
			this.LPCHMEKDCHI().SetVector("_ReflectionTexture1", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1316f, 1817f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000535 RID: 1333 RVA: 0x0002B73E File Offset: 0x0002993E
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("BadgeText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000536 RID: 1334 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x06000537 RID: 1335 RVA: 0x0002B080 File Offset: 0x00029280
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000538 RID: 1336 RVA: 0x0002B762 File Offset: 0x00029962
	private Material HKIMAANBGMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000539 RID: 1337 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x0600053A RID: 1338 RVA: 0x0002B799 File Offset: 0x00029999
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600053B RID: 1339 RVA: 0x0002B7D0 File Offset: 0x000299D0
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1086f)
			{
				this.HBJJOCHGOPH = 1200f;
			}
			this.KBOPGONOCNP().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat(": ", this.Intensity);
			this.OJMHIMIPKME().SetFloat("settings.selectormapsperpage", this.Anomaly_Distortion);
			this.LPMLLJKMAMP().SetFloat("(scene)", this.Anomaly_Distortion_Size);
			this.LPCHMEKDCHI().SetFloat("_Value3", this.Anomaly_Intensity);
			this.DBOLLHHMKKN().SetFloat("0.00", (float)((!this._Visualize) ? 1 : 1));
			this.KEMJNOMIPHN().SetFloat("End index must in an integer.", this._FixDistance);
			this.HKIMAANBGMJ().SetFloat("Scene", this.Anomaly_Near);
			this.LPCHMEKDCHI().SetFloat("Exception while connecting to: ", this.Anomaly_Far);
			this.CIAFLBFJLEJ().SetFloat("/icon", this.AnomalyWithoutObject);
			this.IIBLJCKLGFG().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 709f, 596f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600053C RID: 1340 RVA: 0x0002B958 File Offset: 0x00029B58
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1407f)
			{
				this.HBJJOCHGOPH = 699f;
			}
			this.NBPKMLMCHFN.SetFloat("{0}={2}: {1} \"{3}\"", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("_Value4", this.Intensity);
			this.CIAFLBFJLEJ().SetFloat("_Distortion", this.Anomaly_Distortion);
			this.KEMAALEODNH().SetFloat(".lastCheckpoint.time", this.Anomaly_Distortion_Size);
			this.LDNADDJMIPK().SetFloat("2", this.Anomaly_Intensity);
			this.OJMHIMIPKME().SetFloat("Texture2", (float)((!this._Visualize) ? 1 : 1));
			this.CIAFLBFJLEJ().SetFloat("_CameraClipInfo", this._FixDistance);
			this.LPMLLJKMAMP().SetFloat("_ScreenResolution", this.Anomaly_Near);
			this.LPCHMEKDCHI().SetFloat("StartButton", this.Anomaly_Far);
			this.KDMBOKLMADJ().SetFloat("[CraftingPanel] Init", this.AnomalyWithoutObject);
			this.KEMAALEODNH().SetVector("keys", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1903f, 1410f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600053D RID: 1341 RVA: 0x0002B080 File Offset: 0x00029280
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600053E RID: 1342 RVA: 0x0002BADE File Offset: 0x00029CDE
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("ServerSettings: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600053F RID: 1343 RVA: 0x0002B080 File Offset: 0x00029280
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000540 RID: 1344 RVA: 0x0002BB02 File Offset: 0x00029D02
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000541 RID: 1345 RVA: 0x0002BB39 File Offset: 0x00029D39
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000542 RID: 1346 RVA: 0x0002B080 File Offset: 0x00029280
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000543 RID: 1347 RVA: 0x0002BB70 File Offset: 0x00029D70
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000544 RID: 1348 RVA: 0x0002BBA7 File Offset: 0x00029DA7
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find("th");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000545 RID: 1349 RVA: 0x0002BBCB File Offset: 0x00029DCB
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("Waiting to start");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000546 RID: 1350 RVA: 0x0002BBF0 File Offset: 0x00029DF0
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1797f)
			{
				this.HBJJOCHGOPH = 1156f;
			}
			this.LDNADDJMIPK().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("finished", this.Intensity);
			this.NFMGLIKNOOC().SetFloat("CameraFilterPack/Distortion_ShockWave", this.Anomaly_Distortion);
			this.MMOODGIODPC().SetFloat("_Offsets", this.Anomaly_Distortion_Size);
			this.LPMLLJKMAMP().SetFloat("Skipping region because it's not in PhotonServerSettings.EnabledRegions: ", this.Anomaly_Intensity);
			this.LPMLLJKMAMP().SetFloat("VoteDownToggle", (float)((!this._Visualize) ? 0 : 0));
			this.DBOLLHHMKKN().SetFloat("id", this._FixDistance);
			this.KEMAALEODNH().SetFloat("b", this.Anomaly_Near);
			this.NFMGLIKNOOC().SetFloat("_ScreenResolution", this.Anomaly_Far);
			this.NFMGLIKNOOC().SetFloat("Jan", this.AnomalyWithoutObject);
			this.NBPKMLMCHFN.SetVector("menutheme.idunno", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1952f, 1130f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000547 RID: 1351 RVA: 0x0002B080 File Offset: 0x00029280
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000548 RID: 1352 RVA: 0x0002BD76 File Offset: 0x00029F76
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000549 RID: 1353 RVA: 0x0002B080 File Offset: 0x00029280
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600054A RID: 1354 RVA: 0x0002BDAD File Offset: 0x00029FAD
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600054B RID: 1355 RVA: 0x0002B080 File Offset: 0x00029280
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600054C RID: 1356 RVA: 0x0002BDD1 File Offset: 0x00029FD1
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600054D RID: 1357 RVA: 0x0002BDF8 File Offset: 0x00029FF8
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 528f)
			{
				this.HBJJOCHGOPH = 863f;
			}
			this.HKIMAANBGMJ().SetFloat("*.workshop.json", this.HBJJOCHGOPH);
			this.CIAFLBFJLEJ().SetFloat("CameraFilterPack/EXTRA_SHOWFPS", this.Intensity);
			this.OJMHIMIPKME().SetFloat("_Amount", this.Anomaly_Distortion);
			this.KEMAALEODNH().SetFloat("downloading", this.Anomaly_Distortion_Size);
			this.LPCHMEKDCHI().SetFloat("/?page=ranks", this.Anomaly_Intensity);
			this.LDNADDJMIPK().SetFloat("Bad parameters for set! Use <language>", (float)((!this._Visualize) ? 0 : 0));
			this.IIBLJCKLGFG().SetFloat("DPADVER", this._FixDistance);
			this.KEMJNOMIPHN().SetFloat("[PlayerBase] Reset", this.Anomaly_Near);
			this.KEMAALEODNH().SetFloat("_BlurSize", this.Anomaly_Far);
			this.LPMLLJKMAMP().SetFloat("_ScreenResolution", this.AnomalyWithoutObject);
			this.KEMAALEODNH().SetVector("offline room", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 435f, 1479f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600054E RID: 1358 RVA: 0x0002BF7E File Offset: 0x0002A17E
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600054F RID: 1359 RVA: 0x0002BFB5 File Offset: 0x0002A1B5
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_BlackHole");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000550 RID: 1360 RVA: 0x0002BFD9 File Offset: 0x0002A1D9
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000551 RID: 1361 RVA: 0x0002C010 File Offset: 0x0002A210
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_Anomaly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000552 RID: 1362 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06000553 RID: 1363 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKMELABKBHO()
	{
	}

	// Token: 0x06000554 RID: 1364 RVA: 0x0002C034 File Offset: 0x0002A234
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 873f)
			{
				this.HBJJOCHGOPH = 30f;
			}
			this.LPCHMEKDCHI().SetFloat("red", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("value", this.Intensity);
			this.LPMLLJKMAMP().SetFloat("Set Sun Emission", this.Anomaly_Distortion);
			this.LONNIJMNKFB().SetFloat("_Value", this.Anomaly_Distortion_Size);
			this.LPCHMEKDCHI().SetFloat("#{0:X2}{1:X2}{2:X2}", this.Anomaly_Intensity);
			this.OJMHIMIPKME().SetFloat("CameraFilterPack/Blur_DitherOffset", (float)((!this._Visualize) ? 1 : 0));
			this.HKIMAANBGMJ().SetFloat("  |  ", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("_Fade", this.Anomaly_Near);
			this.KGOLDDBHIFN().SetFloat("CameraMovementSlider", this.Anomaly_Far);
			this.KEMJNOMIPHN().SetFloat("Preparing configuration", this.AnomalyWithoutObject);
			this.IIBLJCKLGFG().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1988f, 640f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000555 RID: 1365 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06000556 RID: 1366 RVA: 0x0002B080 File Offset: 0x00029280
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000557 RID: 1367 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06000558 RID: 1368 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06000559 RID: 1369 RVA: 0x0002B080 File Offset: 0x00029280
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600055A RID: 1370 RVA: 0x0002C1BA File Offset: 0x0002A3BA
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600055B RID: 1371 RVA: 0x0002523B File Offset: 0x0002343B
	private void GFACKFCEIBC()
	{
	}

	// Token: 0x0600055C RID: 1372 RVA: 0x0002C1F4 File Offset: 0x0002A3F4
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1699f)
			{
				this.HBJJOCHGOPH = 1565f;
			}
			this.MMOODGIODPC().SetFloat("LowMid", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat("_SmallTex", this.Intensity);
			this.KEMAALEODNH().SetFloat("[PlayerBase] Unknown event: ", this.Anomaly_Distortion);
			this.MMOODGIODPC().SetFloat("[PlayerController] ", this.Anomaly_Distortion_Size);
			this.KEMJNOMIPHN().SetFloat("VHS2", this.Anomaly_Intensity);
			this.LPCHMEKDCHI().SetFloat("#FFDA44", (float)((!this._Visualize) ? 0 : 1));
			this.MMOODGIODPC().SetFloat("maps.", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("#highscore", this.Anomaly_Near);
			this.MMOODGIODPC().SetFloat("_History1ChromaTex", this.Anomaly_Far);
			this.IIBLJCKLGFG().SetFloat("CrosshairOpacitySlider", this.AnomalyWithoutObject);
			this.CIAFLBFJLEJ().SetVector("UsernameText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 310f, 1452f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600055D RID: 1373 RVA: 0x0002B080 File Offset: 0x00029280
	private void FKDEEJFNNJC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600055E RID: 1374 RVA: 0x0002C37A File Offset: 0x0002A57A
	private void FDNONDCGGCG()
	{
		this.SCShader = Shader.Find("ICollection");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600055F RID: 1375 RVA: 0x0002C39E File Offset: 0x0002A59E
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-126);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000560 RID: 1376 RVA: 0x0002B080 File Offset: 0x00029280
	private void IABLKKAALGI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000003 RID: 3
	// (get) Token: 0x06000561 RID: 1377 RVA: 0x0002C3D5 File Offset: 0x0002A5D5
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

	// Token: 0x06000562 RID: 1378 RVA: 0x0002C40C File Offset: 0x0002A60C
	private void DFFKKLAPHCC()
	{
		this.SCShader = Shader.Find("Committing changes...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000563 RID: 1379 RVA: 0x0002C430 File Offset: 0x0002A630
	private Material OJMHIMIPKME()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000564 RID: 1380 RVA: 0x0002C467 File Offset: 0x0002A667
	private void PMPKMGKAAJH()
	{
		this.SCShader = Shader.Find("0 seconds");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000565 RID: 1381 RVA: 0x0002B080 File Offset: 0x00029280
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000566 RID: 1382 RVA: 0x0002B080 File Offset: 0x00029280
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000567 RID: 1383 RVA: 0x0002C48B File Offset: 0x0002A68B
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("Curve texture");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000568 RID: 1384 RVA: 0x0002C4AF File Offset: 0x0002A6AF
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("Set Object Position");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600056A RID: 1386 RVA: 0x0002B080 File Offset: 0x00029280
	private void ONPFGCEFMML()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600056B RID: 1387 RVA: 0x0002523B File Offset: 0x0002343B
	private void MDCFIHDPLIG()
	{
	}

	// Token: 0x0600056C RID: 1388 RVA: 0x0002B080 File Offset: 0x00029280
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600056D RID: 1389 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x0600056E RID: 1390 RVA: 0x0002C54A File Offset: 0x0002A74A
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find("MenuScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600056F RID: 1391 RVA: 0x0002C570 File Offset: 0x0002A770
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1791f)
			{
				this.HBJJOCHGOPH = 30f;
			}
			this.KEMAALEODNH().SetFloat("mapselector.filter.subscribedonly", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("PerfectHitsScoreText", this.Intensity);
			this.KDMBOKLMADJ().SetFloat("value", this.Anomaly_Distortion);
			this.KEMJNOMIPHN().SetFloat("/", this.Anomaly_Distortion_Size);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.Anomaly_Intensity);
			this.MMOODGIODPC().SetFloat("_Value", (float)((!this._Visualize) ? 1 : 1));
			this.KGOLDDBHIFN().SetFloat("CameraFilterPack/Blend2Camera_Subtract", this._FixDistance);
			this.KBOPGONOCNP().SetFloat("menuVolume", this.Anomaly_Near);
			this.NBPKMLMCHFN.SetFloat("Joystick1Button5", this.Anomaly_Far);
			this.LPMLLJKMAMP().SetFloat("Items/", this.AnomalyWithoutObject);
			this.KEMAALEODNH().SetVector("_Value5", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1948f, 1469f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000570 RID: 1392 RVA: 0x0002C6F8 File Offset: 0x0002A8F8
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1222f)
			{
				this.HBJJOCHGOPH = 1900f;
			}
			this.LPMLLJKMAMP().SetFloat("return CheckCondition()", this.HBJJOCHGOPH);
			this.KDMBOKLMADJ().SetFloat("_Green_C", this.Intensity);
			this.KDMBOKLMADJ().SetFloat("OpJoinRoom()", this.Anomaly_Distortion);
			this.LDNADDJMIPK().SetFloat("masterSteamID", this.Anomaly_Distortion_Size);
			this.LONNIJMNKFB().SetFloat("_MaxSteps", this.Anomaly_Intensity);
			this.NBPKMLMCHFN.SetFloat("Hidden/Image Effects/Cinematic/MotionBlur/Reconstruction", (float)((!this._Visualize) ? 0 : 0));
			this.HKIMAANBGMJ().SetFloat("_ScreenResolution", this._FixDistance);
			this.LDNADDJMIPK().SetFloat(" - GameWebCallback] - ", this.Anomaly_Near);
			this.KDMBOKLMADJ().SetFloat("image", this.Anomaly_Far);
			this.MMOODGIODPC().SetFloat("UseFinalGlassColor", this.AnomalyWithoutObject);
			this.KEMAALEODNH().SetVector("CameraFilterPack/Drawing_Manga_Color", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 803f, 506f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000571 RID: 1393 RVA: 0x0002C87E File Offset: 0x0002AA7E
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("saveGameName ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000572 RID: 1394 RVA: 0x0002B080 File Offset: 0x00029280
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000573 RID: 1395 RVA: 0x0002B080 File Offset: 0x00029280
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000574 RID: 1396 RVA: 0x0002B080 File Offset: 0x00029280
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000575 RID: 1397 RVA: 0x0002B080 File Offset: 0x00029280
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000576 RID: 1398 RVA: 0x0002B080 File Offset: 0x00029280
	private void EDCMIPNCPLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000577 RID: 1399 RVA: 0x0002C8A4 File Offset: 0x0002AAA4
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 135f)
			{
				this.HBJJOCHGOPH = 1513f;
			}
			this.MMOODGIODPC().SetFloat("_Y", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("_Noise", this.Intensity);
			this.IIBLJCKLGFG().SetFloat("EndlessLoopsScoreText", this.Anomaly_Distortion);
			this.CIAFLBFJLEJ().SetFloat("#score", this.Anomaly_Distortion_Size);
			this.LPCHMEKDCHI().SetFloat("SpawnObj", this.Anomaly_Intensity);
			this.KGOLDDBHIFN().SetFloat("CameraFilterPack/Blend2Camera_Divide", (float)((!this._Visualize) ? 1 : 1));
			this.LONNIJMNKFB().SetFloat("settings.hitvariation", this._FixDistance);
			this.DBOLLHHMKKN().SetFloat("ticket.ticket1", this.Anomaly_Near);
			this.LDNADDJMIPK().SetFloat("11", this.Anomaly_Far);
			this.CIAFLBFJLEJ().SetFloat("[NetworkManager] Connection failed: ", this.AnomalyWithoutObject);
			this.NFMGLIKNOOC().SetVector("_VignetteCenter", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1267f, 1539f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000578 RID: 1400 RVA: 0x0002B080 File Offset: 0x00029280
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000579 RID: 1401 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x0600057A RID: 1402 RVA: 0x0002B080 File Offset: 0x00029280
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600057B RID: 1403 RVA: 0x0002CA2C File Offset: 0x0002AC2C
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1756f)
			{
				this.HBJJOCHGOPH = 196f;
			}
			this.LDNADDJMIPK().SetFloat("_Offsets", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("\n\n• ", this.Intensity);
			this.KBOPGONOCNP().SetFloat("_Saturation", this.Anomaly_Distortion);
			this.KGOLDDBHIFN().SetFloat("LevelEditor/CustomEventEditor-Text", this.Anomaly_Distortion_Size);
			this.KGOLDDBHIFN().SetFloat(">", this.Anomaly_Intensity);
			this.LPMLLJKMAMP().SetFloat("Preparing content", (float)((!this._Visualize) ? 0 : 1));
			this.KBOPGONOCNP().SetFloat("_Green_G", this._FixDistance);
			this.LONNIJMNKFB().SetFloat("_TimeX", this.Anomaly_Near);
			this.HKIMAANBGMJ().SetFloat("_Bullet_10", this.Anomaly_Far);
			this.HKIMAANBGMJ().SetFloat("gold", this.AnomalyWithoutObject);
			this.NBPKMLMCHFN.SetVector("Trackpad", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1554f, 540f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600057C RID: 1404 RVA: 0x0002CBB4 File Offset: 0x0002ADB4
	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 619f)
			{
				this.HBJJOCHGOPH = 1971f;
			}
			this.KBOPGONOCNP().SetFloat("_Value", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat(":\n", this.Intensity);
			this.HKIMAANBGMJ().SetFloat("_SizeX", this.Anomaly_Distortion);
			this.KGOLDDBHIFN().SetFloat("Right", this.Anomaly_Distortion_Size);
			this.CIAFLBFJLEJ().SetFloat("Scene", this.Anomaly_Intensity);
			this.HKIMAANBGMJ().SetFloat("_TimeX", (float)((!this._Visualize) ? 0 : 1));
			this.CIAFLBFJLEJ().SetFloat("_TimeX", this._FixDistance);
			this.KDMBOKLMADJ().SetFloat("_Value2", this.Anomaly_Near);
			this.LDNADDJMIPK().SetFloat("CameraFilterPack/Color_Contrast", this.Anomaly_Far);
			this.KEMJNOMIPHN().SetFloat("-help", this.AnomalyWithoutObject);
			this.LONNIJMNKFB().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1807f, 1165f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600057D RID: 1405 RVA: 0x0002CD3A File Offset: 0x0002AF3A
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600057E RID: 1406 RVA: 0x0002B080 File Offset: 0x00029280
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600057F RID: 1407 RVA: 0x0002CD74 File Offset: 0x0002AF74
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 301f)
			{
				this.HBJJOCHGOPH = 1112f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value2", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat("DifficultyBG", this.Intensity);
			this.LPMLLJKMAMP().SetFloat("PossibleMapMaxScoreText", this.Anomaly_Distortion);
			this.CIAFLBFJLEJ().SetFloat("/icon", this.Anomaly_Distortion_Size);
			this.KDMBOKLMADJ().SetFloat("OK", this.Anomaly_Intensity);
			this.NBPKMLMCHFN.SetFloat("Set Sun MaxSize", (float)((!this._Visualize) ? 0 : 1));
			this.LPMLLJKMAMP().SetFloat("System.Single", this._FixDistance);
			this.IIBLJCKLGFG().SetFloat("_ChangeGreen", this.Anomaly_Near);
			this.NBPKMLMCHFN.SetFloat("ItemNameText", this.Anomaly_Far);
			this.LONNIJMNKFB().SetFloat("_ScreenResolution", this.AnomalyWithoutObject);
			this.OJMHIMIPKME().SetVector("CameraFilterPack/Glow_Glow_Color", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1565f, 1504f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000580 RID: 1408 RVA: 0x0002CEFA File Offset: 0x0002B0FA
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000581 RID: 1409 RVA: 0x0002CF31 File Offset: 0x0002B131
	private void LIBGAKMKHJJ()
	{
		this.SCShader = Shader.Find("TStart");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000582 RID: 1410 RVA: 0x0002B080 File Offset: 0x00029280
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000583 RID: 1411 RVA: 0x0002CF58 File Offset: 0x0002B158
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 777f)
			{
				this.HBJJOCHGOPH = 1644f;
			}
			this.LPCHMEKDCHI().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("It seems some instantiation is not completed, as instantiation data is used. You should make sure instantiations are paused when calling this method. Cleaning now, despite this.", this.Intensity);
			this.KDMBOKLMADJ().SetFloat("_TimeX", this.Anomaly_Distortion);
			this.LPMLLJKMAMP().SetFloat("Parameter levelId must be int or string!", this.Anomaly_Distortion_Size);
			this.OJMHIMIPKME().SetFloat(":", this.Anomaly_Intensity);
			this.HKIMAANBGMJ().SetFloat(" ", (float)((!this._Visualize) ? 1 : 0));
			this.OJMHIMIPKME().SetFloat("Version 1.0", this._FixDistance);
			this.NFMGLIKNOOC().SetFloat(" not exist", this.Anomaly_Near);
			this.MMOODGIODPC().SetFloat("12", this.Anomaly_Far);
			this.LPMLLJKMAMP().SetFloat(".status", this.AnomalyWithoutObject);
			this.LDNADDJMIPK().SetVector("CameraFilterPack/Colors_BleachBypass", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 965f, 1566f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000584 RID: 1412 RVA: 0x0002D0E0 File Offset: 0x0002B2E0
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1022f)
			{
				this.HBJJOCHGOPH = 1709f;
			}
			this.KEMJNOMIPHN().SetFloat("StartButton", this.HBJJOCHGOPH);
			this.KDMBOKLMADJ().SetFloat("event", this.Intensity);
			this.HKIMAANBGMJ().SetFloat("#forever", this.Anomaly_Distortion);
			this.NFMGLIKNOOC().SetFloat("menu.enableselectormusic", this.Anomaly_Distortion_Size);
			this.KEMAALEODNH().SetFloat("HandsCountSlider", this.Anomaly_Intensity);
			this.KEMAALEODNH().SetFloat("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ", (float)((!this._Visualize) ? 0 : 0));
			this.OJMHIMIPKME().SetFloat("0.00", this._FixDistance);
			this.KEMAALEODNH().SetFloat("_Bullet_3", this.Anomaly_Near);
			this.HKIMAANBGMJ().SetFloat("End index must in an integer.", this.Anomaly_Far);
			this.CIAFLBFJLEJ().SetFloat("MessageText", this.AnomalyWithoutObject);
			this.LPMLLJKMAMP().SetVector("Type \"help\" for list of commands", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1425f, 1763f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000585 RID: 1413 RVA: 0x0002D266 File Offset: 0x0002B466
	private void KOFAMEKHHGD()
	{
		this.SCShader = Shader.Find("SetSunMaxSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000586 RID: 1414 RVA: 0x0002D28C File Offset: 0x0002B48C
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
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("Anomaly_Distortion", this.Anomaly_Distortion);
			this.NBPKMLMCHFN.SetFloat("Anomaly_Distortion_Size", this.Anomaly_Distortion_Size);
			this.NBPKMLMCHFN.SetFloat("Anomaly_Intensity", this.Anomaly_Intensity);
			this.NBPKMLMCHFN.SetFloat("_Visualize", (float)((!this._Visualize) ? 0 : 1));
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("Anomaly_Near", this.Anomaly_Near);
			this.NBPKMLMCHFN.SetFloat("Anomaly_Far", this.Anomaly_Far);
			this.NBPKMLMCHFN.SetFloat("Anomaly_With_Obj", this.AnomalyWithoutObject);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000587 RID: 1415 RVA: 0x0002D412 File Offset: 0x0002B612
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000588 RID: 1416 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06000589 RID: 1417 RVA: 0x0002B080 File Offset: 0x00029280
	private void NNBCLMJGFEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600058A RID: 1418 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x0600058B RID: 1419 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x0600058C RID: 1420 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x0600058D RID: 1421 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x0600058E RID: 1422 RVA: 0x0002B080 File Offset: 0x00029280
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600058F RID: 1423 RVA: 0x0002D44C File Offset: 0x0002B64C
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1058f)
			{
				this.HBJJOCHGOPH = 1475f;
			}
			this.KDMBOKLMADJ().SetFloat("JoinRandomRoom failed. In offline mode you still have to leave a room to enter another.", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("seconds", this.Intensity);
			this.KEMAALEODNH().SetFloat("CameraFilterPack/FX_Scan", this.Anomaly_Distortion);
			this.DBOLLHHMKKN().SetFloat("B", this.Anomaly_Distortion_Size);
			this.MMOODGIODPC().SetFloat(". Current number of cells is ", this.Anomaly_Intensity);
			this.OJMHIMIPKME().SetFloat("_BlueAmplifier", (float)((!this._Visualize) ? 1 : 1));
			this.DBOLLHHMKKN().SetFloat("...", this._FixDistance);
			this.KBOPGONOCNP().SetFloat("_Value2", this.Anomaly_Near);
			this.KEMJNOMIPHN().SetFloat("CameraFilterPack/Colors_Adjust_PreFilters", this.Anomaly_Far);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Color_Sepia", this.AnomalyWithoutObject);
			this.KEMAALEODNH().SetVector("_SubsampleIndices", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 786f, 189f));
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000590 RID: 1424 RVA: 0x0002B080 File Offset: 0x00029280
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040000CA RID: 202
	public Shader SCShader;

	// Token: 0x040000CB RID: 203
	public bool _Visualize;

	// Token: 0x040000CC RID: 204
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040000CD RID: 205
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040000CE RID: 206
	private Material BJFKDHHMLJH;

	// Token: 0x040000CF RID: 207
	[Range(0f, 100f)]
	public float _FixDistance = 23f;

	// Token: 0x040000D0 RID: 208
	[Range(-0.5f, 0.99f)]
	public float Anomaly_Near = 0.045f;

	// Token: 0x040000D1 RID: 209
	[Range(0f, 1f)]
	public float Anomaly_Far = 0.11f;

	// Token: 0x040000D2 RID: 210
	[Range(0f, 2f)]
	public float Intensity = 1f;

	// Token: 0x040000D3 RID: 211
	[Range(0f, 1f)]
	public float AnomalyWithoutObject = 1f;

	// Token: 0x040000D4 RID: 212
	[Range(0.1f, 1f)]
	public float Anomaly_Distortion = 0.25f;

	// Token: 0x040000D5 RID: 213
	[Range(4f, 64f)]
	public float Anomaly_Distortion_Size = 12f;

	// Token: 0x040000D6 RID: 214
	[Range(-4f, 8f)]
	public float Anomaly_Intensity = 2f;
}
