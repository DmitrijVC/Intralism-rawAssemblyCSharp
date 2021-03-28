using System;
using UnityEngine;

// Token: 0x02000067 RID: 103
[AddComponentMenu("Camera Filter Pack/Blur/Steam")]
[ExecuteInEditMode]
public class CameraFilterPack_Blur_Steam : MonoBehaviour
{
	// Token: 0x06001CBA RID: 7354 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001CBB RID: 7355 RVA: 0x000AFA7C File Offset: 0x000ADC7C
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1652f)
			{
				this.HBJJOCHGOPH = 770f;
			}
			this.LEHDPILKKND().SetFloat("SetSunSensitivity", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("roomDescription", this.Radius);
			this.HKHBBBFLGJH().SetFloat("#8E8E8EFF", this.Quality);
			this.JFDGLLEOPGB().SetVector("skin.", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ENKPNJMPDEB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001CBC RID: 7356 RVA: 0x000AFB48 File Offset: 0x000ADD48
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001CBD RID: 7357 RVA: 0x000AFB7F File Offset: 0x000ADD7F
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001CBE RID: 7358 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06001CBF RID: 7359 RVA: 0x000AFBB6 File Offset: 0x000ADDB6
	private Material LEHDPILKKND()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001CC0 RID: 7360 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06001CC1 RID: 7361 RVA: 0x000AFBED File Offset: 0x000ADDED
	private void MODENHKMKOC()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001CC2 RID: 7362 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001CC3 RID: 7363 RVA: 0x000AFC14 File Offset: 0x000ADE14
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1481f)
			{
				this.HBJJOCHGOPH = 1692f;
			}
			this.NMDBCDFPGOK().SetFloat("Color's hex value #RRGGBBAA", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("_Value1", this.Radius);
			this.HKHBBBFLGJH().SetFloat("???", this.Quality);
			this.LPCHMEKDCHI().SetVector("offsets", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001CC4 RID: 7364 RVA: 0x0002523B File Offset: 0x0002343B
	private void GGPDKCHEBAG()
	{
	}

	// Token: 0x06001CC5 RID: 7365 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06001CC6 RID: 7366 RVA: 0x000AFCE0 File Offset: 0x000ADEE0
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 960f)
			{
				this.HBJJOCHGOPH = 1557f;
			}
			this.NBPKMLMCHFN.SetFloat("BitsData", this.HBJJOCHGOPH);
			this.BBIMPFGLDCP().SetFloat("CameraFilterPack_eyes_vision_1", this.Radius);
			this.BAGICADFBAB().SetFloat("CameraFilterPack/Blur_Blurry", this.Quality);
			this.KHCLIAMBBNC().SetVector("CameraFilterPack_3D_Myst1", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001CC7 RID: 7367 RVA: 0x000AFDAC File Offset: 0x000ADFAC
	private void HHKBBEFJEBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 7f)
			{
				this.HBJJOCHGOPH = 1009f;
			}
			this.LPCHMEKDCHI().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.BBIMPFGLDCP().SetFloat("IconImage", this.Radius);
			this.LPMLLJKMAMP().SetFloat("_Red_B", this.Quality);
			this.GKILCDHJFEG().SetVector("JoinOrCreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ENKPNJMPDEB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001CC8 RID: 7368 RVA: 0x000AFE78 File Offset: 0x000AE078
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001CC9 RID: 7369 RVA: 0x000AFE9C File Offset: 0x000AE09C
	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1573f)
			{
				this.HBJJOCHGOPH = 160f;
			}
			this.LPMLLJKMAMP().SetFloat("CameraFilterPack/TV_Artefact", this.HBJJOCHGOPH);
			this.KHCLIAMBBNC().SetFloat("EditMenu", this.Radius);
			this.GCDFNHMJMIP().SetFloat("#pleasewait", this.Quality);
			this.JIBOKBCPDLC().SetVector("_FixDistance", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001CCA RID: 7370 RVA: 0x000AFF68 File Offset: 0x000AE168
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 891f)
			{
				this.HBJJOCHGOPH = 1514f;
			}
			this.CECICEGFHKL().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("_TimeX", this.Radius);
			this.PEIMCBBHLBJ().SetFloat("attempted to spawn a GameObject from recycle bin (", this.Quality);
			this.LEHDPILKKND().SetVector("CameraFilterPack/Glasses_On", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IKAEIOAHPKI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001CCB RID: 7371 RVA: 0x000B0034 File Offset: 0x000AE234
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find(">");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001CCC RID: 7372 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001CCD RID: 7373 RVA: 0x000B0058 File Offset: 0x000AE258
	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1593f)
			{
				this.HBJJOCHGOPH = 1192f;
			}
			this.CECICEGFHKL().SetFloat("materialsitemid[", this.HBJJOCHGOPH);
			this.CECICEGFHKL().SetFloat("_TimeX", this.Radius);
			this.LPCHMEKDCHI().SetFloat("0.00", this.Quality);
			this.LPMLLJKMAMP().SetVector("CameraFilterPack/Blend2Camera_Lighten", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001CCE RID: 7374 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001CCF RID: 7375 RVA: 0x000B0124 File Offset: 0x000AE324
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_VividLight");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x1700004D RID: 77
	// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x000B0148 File Offset: 0x000AE348
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

	// Token: 0x06001CD1 RID: 7377 RVA: 0x000B017F File Offset: 0x000AE37F
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001CD2 RID: 7378 RVA: 0x000B01B6 File Offset: 0x000AE3B6
	private Material NMDBCDFPGOK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001CD3 RID: 7379 RVA: 0x000B01ED File Offset: 0x000AE3ED
	private Material BBIMPFGLDCP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001CD4 RID: 7380 RVA: 0x000B0224 File Offset: 0x000AE424
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1614f)
			{
				this.HBJJOCHGOPH = 1792f;
			}
			this.MJJIEHANFJA().SetFloat("shader.frost", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("maps.", this.Radius);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Gradients_Stripe", this.Quality);
			this.ADAFMBOGPLN().SetVector("_CenterX", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001CD5 RID: 7381 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001CD6 RID: 7382 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001CD7 RID: 7383 RVA: 0x000B02F0 File Offset: 0x000AE4F0
	private void PCHCFIOHIKK()
	{
		this.SCShader = Shader.Find(". Sent by actorNr: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001CD8 RID: 7384 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001CD9 RID: 7385 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001CDA RID: 7386 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void LAMEHAHJKMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001CDB RID: 7387 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x06001CDC RID: 7388 RVA: 0x000B0314 File Offset: 0x000AE514
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001CDD RID: 7389 RVA: 0x000B034C File Offset: 0x000AE54C
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1613f)
			{
				this.HBJJOCHGOPH = 1399f;
			}
			this.LPMLLJKMAMP().SetFloat("TotalHitsScoreText", this.HBJJOCHGOPH);
			this.MJJIEHANFJA().SetFloat("MainCamera", this.Radius);
			this.JFDGLLEOPGB().SetFloat("Hidden/Image Effects/Cinematic/MotionBlur/Reconstruction", this.Quality);
			this.GCDFNHMJMIP().SetVector(": ", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LEHDPILKKND());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001CDE RID: 7390 RVA: 0x000B0418 File Offset: 0x000AE618
	private void OIKAPFGPLML(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1750f)
			{
				this.HBJJOCHGOPH = 1572f;
			}
			this.ENKPNJMPDEB().SetFloat("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("Aug", this.Radius);
			this.FOOCJIDNGBB().SetFloat("_Value1", this.Quality);
			this.BBIMPFGLDCP().SetVector("note.0", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001CDF RID: 7391 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001CE0 RID: 7392 RVA: 0x000B04E4 File Offset: 0x000AE6E4
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001CE1 RID: 7393 RVA: 0x000B0508 File Offset: 0x000AE708
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 186f)
			{
				this.HBJJOCHGOPH = 849f;
			}
			this.NBPKMLMCHFN.SetFloat("RequestSelectedLevel", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("NewMusicFileSelector", this.Radius);
			this.OCHJIMJNEMO().SetFloat("--------------------------------", this.Quality);
			this.OCHJIMJNEMO().SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001CE2 RID: 7394 RVA: 0x000B05D4 File Offset: 0x000AE7D4
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 626f)
			{
				this.HBJJOCHGOPH = 45f;
			}
			this.IKAEIOAHPKI().SetFloat(".png", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("_Value", this.Radius);
			this.CECICEGFHKL().SetFloat("player.licenceaccepted", this.Quality);
			this.FOOCJIDNGBB().SetVector("_Value3", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001CE3 RID: 7395 RVA: 0x000B06A0 File Offset: 0x000AE8A0
	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1693f)
			{
				this.HBJJOCHGOPH = 466f;
			}
			this.LPCHMEKDCHI().SetFloat("id", this.HBJJOCHGOPH);
			this.HILDKDFEBPF().SetFloat("_Intensity", this.Radius);
			this.FOOCJIDNGBB().SetFloat(".completed", this.Quality);
			this.GCDFNHMJMIP().SetVector("x", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001CE4 RID: 7396 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001CE5 RID: 7397 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001CE6 RID: 7398 RVA: 0x000B076C File Offset: 0x000AE96C
	private void JONGNKNLLND()
	{
		this.SCShader = Shader.Find("Music End");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001CE7 RID: 7399 RVA: 0x0002523B File Offset: 0x0002343B
	private void AOLABBMIEIM()
	{
	}

	// Token: 0x06001CE8 RID: 7400 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001CE9 RID: 7401 RVA: 0x000B0790 File Offset: 0x000AE990
	private Material LELKBCALFCF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001CEA RID: 7402 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001CEB RID: 7403 RVA: 0x000B07C8 File Offset: 0x000AE9C8
	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 838f)
			{
				this.HBJJOCHGOPH = 1075f;
			}
			this.GKILCDHJFEG().SetFloat("Color", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("_Value", this.Radius);
			this.LELKBCALFCF().SetFloat("menu.copyright", this.Quality);
			this.LEHDPILKKND().SetVector(",", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001CEC RID: 7404 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void NNBCLMJGFEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001CED RID: 7405 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001CEE RID: 7406 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void ELKELFCGMPE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001CEF RID: 7407 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001CF0 RID: 7408 RVA: 0x000B0894 File Offset: 0x000AEA94
	private Material FOOCJIDNGBB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001CF1 RID: 7409 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x06001CF2 RID: 7410 RVA: 0x000B08CC File Offset: 0x000AEACC
	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 527f)
			{
				this.HBJJOCHGOPH = 899f;
			}
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.ADAFMBOGPLN().SetFloat("#ranks:", this.Radius);
			this.OCHJIMJNEMO().SetFloat("CameraFilterPack/Blend2Camera_BlueScreen", this.Quality);
			this.HKHBBBFLGJH().SetVector("selColor", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001CF3 RID: 7411 RVA: 0x000B0998 File Offset: 0x000AEB98
	private Material ENKPNJMPDEB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001CF4 RID: 7412 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x06001CF5 RID: 7413 RVA: 0x000B09D0 File Offset: 0x000AEBD0
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1522f)
			{
				this.HBJJOCHGOPH = 873f;
			}
			this.GKILCDHJFEG().SetFloat("id", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("maps.", this.Radius);
			this.JIBOKBCPDLC().SetFloat("Update() was called by Unity. Scene is loaded. Let's connect to the Photon Master Server. Calling: PhotonNetwork.ConnectUsingSettings();", this.Quality);
			this.GCDFNHMJMIP().SetVector("HandsCountSlider", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PEIMCBBHLBJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001CF6 RID: 7414 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06001CF7 RID: 7415 RVA: 0x000B0A9C File Offset: 0x000AEC9C
	private Material IKAEIOAHPKI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001CF8 RID: 7416 RVA: 0x000B0AD4 File Offset: 0x000AECD4
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1894f)
			{
				this.HBJJOCHGOPH = 718f;
			}
			this.HKHBBBFLGJH().SetFloat("Joystick1Button11", this.HBJJOCHGOPH);
			this.FOOCJIDNGBB().SetFloat("_UV_Transform", this.Radius);
			this.LPCHMEKDCHI().SetFloat("CameraFilterPack/FX_Dot_Circle", this.Quality);
			this.MJJIEHANFJA().SetVector("Failed to InstantiateSceneObject prefab: ", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001CF9 RID: 7417 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void NNPBKKBFDHH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001CFB RID: 7419 RVA: 0x000B0BC9 File Offset: 0x000AEDC9
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001CFC RID: 7420 RVA: 0x000B0C00 File Offset: 0x000AEE00
	private Material ADAFMBOGPLN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001CFD RID: 7421 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06001CFE RID: 7422 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x06001CFF RID: 7423 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D00 RID: 7424 RVA: 0x000B0C37 File Offset: 0x000AEE37
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D01 RID: 7425 RVA: 0x0002523B File Offset: 0x0002343B
	private void AKCADICOFDD()
	{
	}

	// Token: 0x06001D02 RID: 7426 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D03 RID: 7427 RVA: 0x000B0C6E File Offset: 0x000AEE6E
	private void GLEJGFLCLPJ()
	{
		this.SCShader = Shader.Find("settings.volume.sfx");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001D04 RID: 7428 RVA: 0x000B0C94 File Offset: 0x000AEE94
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 22f)
			{
				this.HBJJOCHGOPH = 298f;
			}
			this.LELKBCALFCF().SetFloat("accuracy", this.HBJJOCHGOPH);
			this.LEHDPILKKND().SetFloat("Joystick1Button11", this.Radius);
			this.JFDGLLEOPGB().SetFloat("Lightning", this.Quality);
			this.BAGICADFBAB().SetVector("UsernameText", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LEHDPILKKND());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001D05 RID: 7429 RVA: 0x000B0D60 File Offset: 0x000AEF60
	private void JECMJNFGBGC()
	{
		this.SCShader = Shader.Find("The given 2D texture ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001D06 RID: 7430 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D07 RID: 7431 RVA: 0x0002523B File Offset: 0x0002343B
	private void GJCOELHNLJE()
	{
	}

	// Token: 0x06001D08 RID: 7432 RVA: 0x000B0D84 File Offset: 0x000AEF84
	private void OPHBLNNGFKG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 612f)
			{
				this.HBJJOCHGOPH = 1788f;
			}
			this.ENKPNJMPDEB().SetFloat("skin.hit_wrong", this.HBJJOCHGOPH);
			this.PEIMCBBHLBJ().SetFloat("_SunColor", this.Radius);
			this.LPMLLJKMAMP().SetFloat("OnJoinedLobby(). This client is connected and does get a room-list, which gets stored as PhotonNetwork.GetRoomList(). This script now calls: PhotonNetwork.JoinRandomRoom();", this.Quality);
			this.NMDBCDFPGOK().SetVector("RecieveChatMessage", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ENKPNJMPDEB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001D09 RID: 7433 RVA: 0x000B0E50 File Offset: 0x000AF050
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find(".");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001D0A RID: 7434 RVA: 0x000B0E74 File Offset: 0x000AF074
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D0B RID: 7435 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D0C RID: 7436 RVA: 0x0002523B File Offset: 0x0002343B
	private void ANKIJGCGCBF()
	{
	}

	// Token: 0x06001D0D RID: 7437 RVA: 0x000B0EAC File Offset: 0x000AF0AC
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 204f)
			{
				this.HBJJOCHGOPH = 1226f;
			}
			this.KHCLIAMBBNC().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("EnvironmentSlider", this.Radius);
			this.HKHBBBFLGJH().SetFloat("_Value2", this.Quality);
			this.NMDBCDFPGOK().SetVector("[Right-Down-Left]", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001D0E RID: 7438 RVA: 0x0002523B File Offset: 0x0002343B
	private void IAIGNDMHFFG()
	{
	}

	// Token: 0x06001D0F RID: 7439 RVA: 0x0002523B File Offset: 0x0002343B
	private void EPJJDKJEDMM()
	{
	}

	// Token: 0x06001D10 RID: 7440 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D11 RID: 7441 RVA: 0x000B0F78 File Offset: 0x000AF178
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("tintColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001D12 RID: 7442 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x06001D13 RID: 7443 RVA: 0x000B0F9C File Offset: 0x000AF19C
	private Material HILDKDFEBPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D14 RID: 7444 RVA: 0x0002523B File Offset: 0x0002343B
	private void INLDEHPAMJC()
	{
	}

	// Token: 0x06001D15 RID: 7445 RVA: 0x000B0F9C File Offset: 0x000AF19C
	private Material PEIMCBBHLBJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D16 RID: 7446 RVA: 0x000B0FD4 File Offset: 0x000AF1D4
	private void PODKOCOPGLC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1249f)
			{
				this.HBJJOCHGOPH = 437f;
			}
			this.PEIMCBBHLBJ().SetFloat("HPToggle", this.HBJJOCHGOPH);
			this.IKAEIOAHPKI().SetFloat("_Offsets", this.Radius);
			this.NBPKMLMCHFN.SetFloat("mapselector.filter.subscribedonly", this.Quality);
			this.FOOCJIDNGBB().SetVector("_Visualize", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001D17 RID: 7447 RVA: 0x000B10A0 File Offset: 0x000AF2A0
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("Warning: No Shape Curve set for CurveWaveform.cs on ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001D18 RID: 7448 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x06001D19 RID: 7449 RVA: 0x000B10C4 File Offset: 0x000AF2C4
	private Material MJJIEHANFJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D1A RID: 7450 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D1B RID: 7451 RVA: 0x0002523B File Offset: 0x0002343B
	private void JCGMGLMADEN()
	{
	}

	// Token: 0x06001D1C RID: 7452 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D1D RID: 7453 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D1E RID: 7454 RVA: 0x000B10FC File Offset: 0x000AF2FC
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1809f)
			{
				this.HBJJOCHGOPH = 602f;
			}
			this.CECICEGFHKL().SetFloat("ticket", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", this.Radius);
			this.LEHDPILKKND().SetFloat("_Near", this.Quality);
			this.GCDFNHMJMIP().SetVector("_Val2", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LEHDPILKKND());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001D1F RID: 7455 RVA: 0x000B11C8 File Offset: 0x000AF3C8
	private Material CECICEGFHKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-116);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D20 RID: 7456 RVA: 0x000B11FF File Offset: 0x000AF3FF
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blur_Steam");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001D21 RID: 7457 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJNJIHCLODK()
	{
	}

	// Token: 0x06001D22 RID: 7458 RVA: 0x000B1223 File Offset: 0x000AF423
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D23 RID: 7459 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D24 RID: 7460 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x06001D25 RID: 7461 RVA: 0x0002523B File Offset: 0x0002343B
	private void CPCDFMMLHLO()
	{
	}

	// Token: 0x06001D26 RID: 7462 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x06001D27 RID: 7463 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06001D28 RID: 7464 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06001D29 RID: 7465 RVA: 0x000B125A File Offset: 0x000AF45A
	private void FDNONDCGGCG()
	{
		this.SCShader = Shader.Find("CameraFilterPack_Glasses_On4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001D2A RID: 7466 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D2B RID: 7467 RVA: 0x0002523B File Offset: 0x0002343B
	private void ODCJJFBJJNF()
	{
	}

	// Token: 0x06001D2C RID: 7468 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x06001D2D RID: 7469 RVA: 0x000B127E File Offset: 0x000AF47E
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("closed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001D2E RID: 7470 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D2F RID: 7471 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void PNNPDMHLFHE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D30 RID: 7472 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D31 RID: 7473 RVA: 0x000B12A2 File Offset: 0x000AF4A2
	private void LGHCJCFHEMF()
	{
		this.SCShader = Shader.Find("AddEnvironmentObject");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001D32 RID: 7474 RVA: 0x000B12C6 File Offset: 0x000AF4C6
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001D33 RID: 7475 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D34 RID: 7476 RVA: 0x000B12EA File Offset: 0x000AF4EA
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("_Value1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001D35 RID: 7477 RVA: 0x000B130E File Offset: 0x000AF50E
	private void OKLAJINHPAN()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001D36 RID: 7478 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void ABHEJPAGNMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D37 RID: 7479 RVA: 0x000B1332 File Offset: 0x000AF532
	private Material KHCLIAMBBNC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D38 RID: 7480 RVA: 0x0002523B File Offset: 0x0002343B
	private void GNCIOPKPLLA()
	{
	}

	// Token: 0x06001D39 RID: 7481 RVA: 0x000B1369 File Offset: 0x000AF569
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find("SetSatelliteRotationSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001D3A RID: 7482 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D3B RID: 7483 RVA: 0x000B138D File Offset: 0x000AF58D
	private void JOHOFNKJDEB()
	{
		this.SCShader = Shader.Find("3d text");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001D3C RID: 7484 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D3D RID: 7485 RVA: 0x000B13B1 File Offset: 0x000AF5B1
	private void DOFDGBGEDFI()
	{
		this.SCShader = Shader.Find("1427616858");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001D3E RID: 7486 RVA: 0x000B13D5 File Offset: 0x000AF5D5
	private void AEDDNDHCLNN()
	{
		this.SCShader = Shader.Find("_DiffuseColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001D3F RID: 7487 RVA: 0x0002523B File Offset: 0x0002343B
	private void BFGIMALGMAJ()
	{
	}

	// Token: 0x06001D40 RID: 7488 RVA: 0x000B13FC File Offset: 0x000AF5FC
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1963f)
			{
				this.HBJJOCHGOPH = 147f;
			}
			this.CECICEGFHKL().SetFloat("CameraFilterPack/Blur_Focus", this.HBJJOCHGOPH);
			this.ADAFMBOGPLN().SetFloat("_FadeFX", this.Radius);
			this.FOOCJIDNGBB().SetFloat("_Value2", this.Quality);
			this.NBPKMLMCHFN.SetVector("SetParticlesCountPerBeat", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BBIMPFGLDCP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001D41 RID: 7489 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFMEAMBLODG()
	{
	}

	// Token: 0x06001D42 RID: 7490 RVA: 0x000B14C8 File Offset: 0x000AF6C8
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
			this.NBPKMLMCHFN.SetFloat("_Radius", this.Radius);
			this.NBPKMLMCHFN.SetFloat("_Quality", this.Quality);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001D43 RID: 7491 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D44 RID: 7492 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void OHBNLJOPDDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D45 RID: 7493 RVA: 0x000B1594 File Offset: 0x000AF794
	private void GOANCMNGDLE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1688f)
			{
				this.HBJJOCHGOPH = 372f;
			}
			this.NMDBCDFPGOK().SetFloat("_FgOverlap", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat(" timeUntilRespawnBasedOnTimeBase:", this.Radius);
			this.JFDGLLEOPGB().SetFloat("_Value", this.Quality);
			this.GKILCDHJFEG().SetVector("inventory.selected.", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001D46 RID: 7494 RVA: 0x000B1660 File Offset: 0x000AF860
	private void HPFOFGJPNCI()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Multiply");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001D47 RID: 7495 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void FJABOCDLCAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D48 RID: 7496 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D49 RID: 7497 RVA: 0x0002523B File Offset: 0x0002343B
	private void MKKJICPMPHK()
	{
	}

	// Token: 0x06001D4A RID: 7498 RVA: 0x000B1684 File Offset: 0x000AF884
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D4B RID: 7499 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void DKPBBJINKMG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D4C RID: 7500 RVA: 0x0002523B File Offset: 0x0002343B
	private void HEBOIFKBLGD()
	{
	}

	// Token: 0x06001D4D RID: 7501 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D4E RID: 7502 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D4F RID: 7503 RVA: 0x000B16BB File Offset: 0x000AF8BB
	private void FEGJMDDIDIC()
	{
		this.SCShader = Shader.Find("Player");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001D50 RID: 7504 RVA: 0x0002523B File Offset: 0x0002343B
	private void PFNFPINPCMH()
	{
	}

	// Token: 0x06001D51 RID: 7505 RVA: 0x000AFA5C File Offset: 0x000ADC5C
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040003E9 RID: 1001
	public Shader SCShader;

	// Token: 0x040003EA RID: 1002
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040003EB RID: 1003
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040003EC RID: 1004
	private Material BJFKDHHMLJH;

	// Token: 0x040003ED RID: 1005
	[Range(0f, 1f)]
	public float Radius = 0.1f;

	// Token: 0x040003EE RID: 1006
	[Range(0f, 1f)]
	public float Quality = 0.75f;
}
