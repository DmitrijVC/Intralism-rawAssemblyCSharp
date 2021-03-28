using System;
using UnityEngine;

// Token: 0x0200010B RID: 267
[AddComponentMenu("Camera Filter Pack/Special/Bubble")]
[ExecuteInEditMode]
public class CameraFilterPack_Special_Bubble : MonoBehaviour
{
	// Token: 0x06005341 RID: 21313 RVA: 0x0019DA6C File Offset: 0x0019BC6C
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 573f)
			{
				this.HBJJOCHGOPH = 1062f;
			}
			this.DKKBFFHBHJE().SetFloat("[PlayerController] ", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("_Value2", this.X);
			this.LNLKMDPHDCC().SetFloat("Set Particles Speed", this.Y);
			this.EMDFHOKEGNG().SetFloat("Bad parameters for set! Use <language>", this.Rate);
			this.OCHJIMJNEMO().SetFloat("_ScreenResolution", this.CCIENBFIKKH);
			this.KBOPGONOCNP().SetVector(" ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 445f, 1789f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005342 RID: 21314 RVA: 0x0019DB6B File Offset: 0x0019BD6B
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005343 RID: 21315 RVA: 0x0019DBA2 File Offset: 0x0019BDA2
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005344 RID: 21316 RVA: 0x0019DBC0 File Offset: 0x0019BDC0
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1682f)
			{
				this.HBJJOCHGOPH = 532f;
			}
			this.HHIFMIPPMPF().SetFloat("CreateRoom failed. In offline mode you still have to leave a room to enter another.", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("Operation failed: ", this.X);
			this.HHIFMIPPMPF().SetFloat(".lastCheckpoint.playerdistance", this.Y);
			this.AELJLBOJAIL().SetFloat("CameraFilterPack/Blend2Camera_BlueScreen", this.Rate);
			this.DNLMFEGJJDD().SetFloat("float,2", this.CCIENBFIKKH);
			this.HNICHJCGJOC().SetVector("ShadersToggle", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 772f, 256f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005345 RID: 21317 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x06005346 RID: 21318 RVA: 0x0019DCC0 File Offset: 0x0019BEC0
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 850f)
			{
				this.HBJJOCHGOPH = 1988f;
			}
			this.EMDFHOKEGNG().SetFloat("CameraFilterPack/FX_Glitch2", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("Oct", this.X);
			this.KBOPGONOCNP().SetFloat("<color=#", this.Y);
			this.IIJMIPBMMBF().SetFloat("_Value2", this.Rate);
			this.ACHNOHCLGOO().SetFloat("_Value2", this.CCIENBFIKKH);
			this.PHGCJOPFDOG().SetVector("\n\n#", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 597f, 250f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005347 RID: 21319 RVA: 0x0019DDBF File Offset: 0x0019BFBF
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005348 RID: 21320 RVA: 0x0019DBA2 File Offset: 0x0019BDA2
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005349 RID: 21321 RVA: 0x0019DDF6 File Offset: 0x0019BFF6
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find("ItemsUploader");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600534A RID: 21322 RVA: 0x0019DE1A File Offset: 0x0019C01A
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600534B RID: 21323 RVA: 0x0019DE51 File Offset: 0x0019C051
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("yesterday");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600534C RID: 21324 RVA: 0x0019DE75 File Offset: 0x0019C075
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600534D RID: 21325 RVA: 0x0019DE99 File Offset: 0x0019C099
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find(".workshop.json");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600534E RID: 21326 RVA: 0x0019DEC0 File Offset: 0x0019C0C0
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1322f)
			{
				this.HBJJOCHGOPH = 1870f;
			}
			this.PHGCJOPFDOG().SetFloat("_LrDepthTex", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("BitsData", this.X);
			this.OJMHIMIPKME().SetFloat("No regions available. Are you sure your appid is valid and setup?", this.Y);
			this.NBPKMLMCHFN.SetFloat("Editor/", this.Rate);
			this.AELJLBOJAIL().SetFloat("bloomintencity:", this.CCIENBFIKKH);
			this.EMDFHOKEGNG().SetVector("EventSystem", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 687f, 816f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600534F RID: 21327 RVA: 0x0019DFBF File Offset: 0x0019C1BF
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005350 RID: 21328 RVA: 0x0019DFF6 File Offset: 0x0019C1F6
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005351 RID: 21329 RVA: 0x0019E02D File Offset: 0x0019C22D
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005352 RID: 21330 RVA: 0x0019E064 File Offset: 0x0019C264
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-104);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005353 RID: 21331 RVA: 0x0019E09B File Offset: 0x0019C29B
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005354 RID: 21332 RVA: 0x0019DBA2 File Offset: 0x0019BDA2
	private void IEFMONDKKJN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005355 RID: 21333 RVA: 0x0019E0D2 File Offset: 0x0019C2D2
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)96;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005356 RID: 21334 RVA: 0x0019E109 File Offset: 0x0019C309
	private void HJPCJGOEKMF()
	{
		this.SCShader = Shader.Find("_NoOuterClip");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005357 RID: 21335 RVA: 0x0019DBA2 File Offset: 0x0019BDA2
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005358 RID: 21336 RVA: 0x0019DBA2 File Offset: 0x0019BDA2
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005359 RID: 21337 RVA: 0x0019E12D File Offset: 0x0019C32D
	private Material PHGCJOPFDOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600535A RID: 21338 RVA: 0x0019E164 File Offset: 0x0019C364
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("StartButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600535B RID: 21339 RVA: 0x0019DBA2 File Offset: 0x0019BDA2
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600535C RID: 21340 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x0600535D RID: 21341 RVA: 0x0019E188 File Offset: 0x0019C388
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1097f)
			{
				this.HBJJOCHGOPH = 181f;
			}
			this.IIJMIPBMMBF().SetFloat("id", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat("PlayMapsSeriesGoal", this.X);
			this.IIJMIPBMMBF().SetFloat("Mouse Y", this.Y);
			this.DNLMFEGJJDD().SetFloat("y", this.Rate);
			this.ACHNOHCLGOO().SetFloat("_TimeX", this.CCIENBFIKKH);
			this.NLFJGMBCICG().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1146f, 1281f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600535E RID: 21342 RVA: 0x0019E287 File Offset: 0x0019C487
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600535F RID: 21343 RVA: 0x0019DBA2 File Offset: 0x0019BDA2
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005360 RID: 21344 RVA: 0x0019E2C0 File Offset: 0x0019C4C0
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1291f)
			{
				this.HBJJOCHGOPH = 733f;
			}
			this.NLFJGMBCICG().SetFloat("achievements.21.progress", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("_EmissionColor", this.X);
			this.FHFLKLMFHOI().SetFloat("_TimeX", this.Y);
			this.PDEAHJPOMEF().SetFloat("Vertical", this.Rate);
			this.NBPKMLMCHFN.SetFloat("shader.frost", this.CCIENBFIKKH);
			this.DNLMFEGJJDD().SetVector("_ColorB", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 352f, 1756f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005361 RID: 21345 RVA: 0x0019DBA2 File Offset: 0x0019BDA2
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005362 RID: 21346 RVA: 0x0019E3C0 File Offset: 0x0019C5C0
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1294f)
			{
				this.HBJJOCHGOPH = 419f;
			}
			this.PHGCJOPFDOG().SetFloat("Freq: ", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("CameraFilterPack/TV_WideScreenVertical", this.X);
			this.LNLKMDPHDCC().SetFloat("[TextSaver] Text saved to ", this.Y);
			this.KEMJNOMIPHN().SetFloat("DPADHOR", this.Rate);
			this.DNLMFEGJJDD().SetFloat("SfxVolumeSlider", this.CCIENBFIKKH);
			this.HHIFMIPPMPF().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1867f, 1808f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005363 RID: 21347 RVA: 0x0019E4C0 File Offset: 0x0019C6C0
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.X);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Y);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Rate);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005364 RID: 21348 RVA: 0x0019E5C0 File Offset: 0x0019C7C0
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 551f)
			{
				this.HBJJOCHGOPH = 230f;
			}
			this.DKKBFFHBHJE().SetFloat("CameraFilterPack/3D_Myst", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("_Blurred", this.X);
			this.PDEAHJPOMEF().SetFloat("[PlayerController] ", this.Y);
			this.NLFJGMBCICG().SetFloat("DifficultyBG", this.Rate);
			this.NLFJGMBCICG().SetFloat("Object ID. Case-Sensitive", this.CCIENBFIKKH);
			this.NLFJGMBCICG().SetVector("Instrumental", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 52f, 1088f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005365 RID: 21349 RVA: 0x0019E6BF File Offset: 0x0019C8BF
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005366 RID: 21350 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x06005367 RID: 21351 RVA: 0x0019E6F6 File Offset: 0x0019C8F6
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005368 RID: 21352 RVA: 0x0019DBA2 File Offset: 0x0019BDA2
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005369 RID: 21353 RVA: 0x0019E72D File Offset: 0x0019C92D
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("PerfectHitsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x170000F0 RID: 240
	// (get) Token: 0x0600536A RID: 21354 RVA: 0x0019E751 File Offset: 0x0019C951
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

	// Token: 0x0600536B RID: 21355 RVA: 0x0019DBA2 File Offset: 0x0019BDA2
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600536C RID: 21356 RVA: 0x0019E788 File Offset: 0x0019C988
	private Material BKKJJJGADLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600536D RID: 21357 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x0600536E RID: 21358 RVA: 0x0019E7C0 File Offset: 0x0019C9C0
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1196f)
			{
				this.HBJJOCHGOPH = 1800f;
			}
			this.HHIFMIPPMPF().SetFloat("OnAwakeRPC", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("#lives", this.X);
			this.KEMJNOMIPHN().SetFloat("Failed to InstantiateSceneObject prefab:", this.Y);
			this.ACHNOHCLGOO().SetFloat("_MainTex2", this.Rate);
			this.PDEAHJPOMEF().SetFloat("tagElement", this.CCIENBFIKKH);
			this.BKKJJJGADLM().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 440f, 238f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600536F RID: 21359 RVA: 0x0019E8BF File Offset: 0x0019CABF
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005370 RID: 21360 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x06005371 RID: 21361 RVA: 0x0019E8F6 File Offset: 0x0019CAF6
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("_Value9");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005372 RID: 21362 RVA: 0x0019E91A File Offset: 0x0019CB1A
	private Material OJMHIMIPKME()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005373 RID: 21363 RVA: 0x0019E91A File Offset: 0x0019CB1A
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005374 RID: 21364 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06005375 RID: 21365 RVA: 0x0019DBA2 File Offset: 0x0019BDA2
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005376 RID: 21366 RVA: 0x0019E954 File Offset: 0x0019CB54
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1550f)
			{
				this.HBJJOCHGOPH = 1320f;
			}
			this.OCHJIMJNEMO().SetFloat("Particles/Additive", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("_Value", this.X);
			this.FHFLKLMFHOI().SetFloat("bad", this.Y);
			this.DNLMFEGJJDD().SetFloat("CameraFilterPack/FX_Glitch2", this.Rate);
			this.LNLKMDPHDCC().SetFloat("_ScreenResolution", this.CCIENBFIKKH);
			this.KBOPGONOCNP().SetVector("_Green_G", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1771f, 1188f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005377 RID: 21367 RVA: 0x0019EA53 File Offset: 0x0019CC53
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005378 RID: 21368 RVA: 0x0019EA78 File Offset: 0x0019CC78
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 902f)
			{
				this.HBJJOCHGOPH = 1560f;
			}
			this.HHIFMIPPMPF().SetFloat("_Parameter", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("_Blue_C", this.X);
			this.ACHNOHCLGOO().SetFloat(" scene view IDs from last level.", this.Y);
			this.PDEAHJPOMEF().SetFloat("_MatrixSize", this.Rate);
			this.AELJLBOJAIL().SetFloat("_ScreenResolution", this.CCIENBFIKKH);
			this.IIJMIPBMMBF().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1242f, 610f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005379 RID: 21369 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x0600537A RID: 21370 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x0600537B RID: 21371 RVA: 0x0019EB77 File Offset: 0x0019CD77
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Special_Bubble");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600537C RID: 21372 RVA: 0x0019EB9B File Offset: 0x0019CD9B
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600537D RID: 21373 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x0600537E RID: 21374 RVA: 0x0019EBD4 File Offset: 0x0019CDD4
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 902f)
			{
				this.HBJJOCHGOPH = 1463f;
			}
			this.EMDFHOKEGNG().SetFloat("%]</b> ", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("/", this.X);
			this.PDEAHJPOMEF().SetFloat("Authentication failed: '{0}' Code: {1}", this.Y);
			this.HNICHJCGJOC().SetFloat("#tryagain", this.Rate);
			this.OJMHIMIPKME().SetFloat("Down", this.CCIENBFIKKH);
			this.HNICHJCGJOC().SetVector("Destroying GO as global. ID: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1369f, 313f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600537F RID: 21375 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06005380 RID: 21376 RVA: 0x0019ECD4 File Offset: 0x0019CED4
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 871f)
			{
				this.HBJJOCHGOPH = 193f;
			}
			this.AELJLBOJAIL().SetFloat("EnableRankingToggle", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("_MainTex2", this.X);
			this.IIJMIPBMMBF().SetFloat("EventMenu", this.Y);
			this.IIJMIPBMMBF().SetFloat("_TapMedium", this.Rate);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.CCIENBFIKKH);
			this.DKKBFFHBHJE().SetVector("DifficultyBG", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1662f, 466f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005381 RID: 21377 RVA: 0x0019EDD3 File Offset: 0x0019CFD3
	private void HIPEHGNBJMN()
	{
		this.SCShader = Shader.Find(".wav");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005382 RID: 21378 RVA: 0x0019EDF7 File Offset: 0x0019CFF7
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("[LocalizationService] Localization: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005383 RID: 21379 RVA: 0x0019EE1C File Offset: 0x0019D01C
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 208f)
			{
				this.HBJJOCHGOPH = 1363f;
			}
			this.EHDJJANLINB().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("_Value3", this.X);
			this.KEMJNOMIPHN().SetFloat(".highscore", this.Y);
			this.PDEAHJPOMEF().SetFloat("_Amount", this.Rate);
			this.OCHJIMJNEMO().SetFloat("_Value4", this.CCIENBFIKKH);
			this.BKKJJJGADLM().SetVector("CameraFilterPack/Drawing_CellShading", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 31f, 287f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005384 RID: 21380 RVA: 0x0019EF1C File Offset: 0x0019D11C
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1150f)
			{
				this.HBJJOCHGOPH = 1460f;
			}
			this.IIJMIPBMMBF().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("[MapsData] Preloading ", this.X);
			this.KBOPGONOCNP().SetFloat(".played", this.Y);
			this.AELJLBOJAIL().SetFloat("_Fade", this.Rate);
			this.KBOPGONOCNP().SetFloat("w", this.CCIENBFIKKH);
			this.NLFJGMBCICG().SetVector(". Should be just one?", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1364f, 232f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005385 RID: 21381 RVA: 0x0019DBA2 File Offset: 0x0019BDA2
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005386 RID: 21382 RVA: 0x0019F01C File Offset: 0x0019D21C
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 516f)
			{
				this.HBJJOCHGOPH = 1909f;
			}
			this.KEMJNOMIPHN().SetFloat("master", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.X);
			this.HNICHJCGJOC().SetFloat(".lastCheckpoint.longestComboScore", this.Y);
			this.KBOPGONOCNP().SetFloat("Data", this.Rate);
			this.ACHNOHCLGOO().SetFloat("CameraFilterPack/TV_MovieNoise", this.CCIENBFIKKH);
			this.DKKBFFHBHJE().SetVector("CameraFilterPack/Colors_DarkColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1060f, 776f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005387 RID: 21383 RVA: 0x0019F11C File Offset: 0x0019D31C
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 65f)
			{
				this.HBJJOCHGOPH = 1825f;
			}
			this.ACHNOHCLGOO().SetFloat("workshop.", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("_Distortion", this.X);
			this.ACHNOHCLGOO().SetFloat("CameraFilterPack/Blur_Blurry", this.Y);
			this.OCHJIMJNEMO().SetFloat("Set particles gravity", this.Rate);
			this.LNLKMDPHDCC().SetFloat("_Size", this.CCIENBFIKKH);
			this.HNICHJCGJOC().SetVector("_MainTex2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 345f, 87f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005388 RID: 21384 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005389 RID: 21385 RVA: 0x0019F21C File Offset: 0x0019D41C
	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1417f)
			{
				this.HBJJOCHGOPH = 1360f;
			}
			this.KBOPGONOCNP().SetFloat("_FixDistance", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("Set Arcs Speed", this.X);
			this.AELJLBOJAIL().SetFloat("_EdgeSharpness", this.Y);
			this.OJMHIMIPKME().SetFloat("_MainTex2", this.Rate);
			this.HNICHJCGJOC().SetFloat(":\n", this.CCIENBFIKKH);
			this.EMDFHOKEGNG().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 839f, 1182f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600538A RID: 21386 RVA: 0x0019F31B File Offset: 0x0019D51B
	private void PMPKMGKAAJH()
	{
		this.SCShader = Shader.Find("_Visualize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600538B RID: 21387 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x0600538C RID: 21388 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x0600538D RID: 21389 RVA: 0x0019DBA2 File Offset: 0x0019BDA2
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600538E RID: 21390 RVA: 0x0019DBA2 File Offset: 0x0019BDA2
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600538F RID: 21391 RVA: 0x0019F340 File Offset: 0x0019D540
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1534f)
			{
				this.HBJJOCHGOPH = 1327f;
			}
			this.PDEAHJPOMEF().SetFloat("EventData0DropDownList", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Overlay", this.X);
			this.PHGCJOPFDOG().SetFloat("_TimeX", this.Y);
			this.OJMHIMIPKME().SetFloat("(\\[ *b *\\])", this.Rate);
			this.LNLKMDPHDCC().SetFloat("#forever", this.CCIENBFIKKH);
			this.FHFLKLMFHOI().SetVector("OnStatusChanged: {0} current State: {1}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1769f, 858f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005390 RID: 21392 RVA: 0x0019F440 File Offset: 0x0019D640
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 615f)
			{
				this.HBJJOCHGOPH = 1267f;
			}
			this.DKKBFFHBHJE().SetFloat("Tab2Content", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("/?player=", this.X);
			this.EMDFHOKEGNG().SetFloat("_Tint", this.Y);
			this.KEMJNOMIPHN().SetFloat("_MaxRadiusOrKInPaper", this.Rate);
			this.NLFJGMBCICG().SetFloat("The given 2D texture ", this.CCIENBFIKKH);
			this.FHFLKLMFHOI().SetVector(" : ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 948f, 431f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005391 RID: 21393 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x06005392 RID: 21394 RVA: 0x0019F540 File Offset: 0x0019D740
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 350f)
			{
				this.HBJJOCHGOPH = 1282f;
			}
			this.AELJLBOJAIL().SetFloat("[PlayerBase] Unknown event: ", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat(" joined", this.X);
			this.ACHNOHCLGOO().SetFloat("#timeuntilchallenge: ", this.Y);
			this.IIJMIPBMMBF().SetFloat("_Value2", this.Rate);
			this.PHGCJOPFDOG().SetFloat("_ScreenResolution", this.CCIENBFIKKH);
			this.PHGCJOPFDOG().SetVector("_ChangeBlue", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 479f, 900f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005393 RID: 21395 RVA: 0x0019F640 File Offset: 0x0019D840
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 916f)
			{
				this.HBJJOCHGOPH = 1120f;
			}
			this.KEMJNOMIPHN().SetFloat("In Network lobby", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("settings.volume.sfx", this.X);
			this.PDEAHJPOMEF().SetFloat("_Overlay", this.Y);
			this.NLFJGMBCICG().SetFloat("[MapsData] Bad map: ", this.Rate);
			this.EHDJJANLINB().SetFloat("Value", this.CCIENBFIKKH);
			this.OJMHIMIPKME().SetVector("_Value5", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 585f, 1330f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005394 RID: 21396 RVA: 0x0019F740 File Offset: 0x0019D940
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1920f)
			{
				this.HBJJOCHGOPH = 1866f;
			}
			this.OJMHIMIPKME().SetFloat("Tab2Content", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("_Offsets", this.X);
			this.KBOPGONOCNP().SetFloat("menu.selectedlevelid", this.Y);
			this.HNICHJCGJOC().SetFloat("_ScreenResolution", this.Rate);
			this.IIJMIPBMMBF().SetFloat("OnDeserialize", this.CCIENBFIKKH);
			this.DNLMFEGJJDD().SetVector("player.blackwhite", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 617f, 892f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005395 RID: 21397 RVA: 0x0019F840 File Offset: 0x0019DA40
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 359f)
			{
				this.HBJJOCHGOPH = 228f;
			}
			this.OJMHIMIPKME().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("_Value", this.X);
			this.KBOPGONOCNP().SetFloat("challenges/", this.Y);
			this.EMDFHOKEGNG().SetFloat("_MainTex", this.Rate);
			this.AELJLBOJAIL().SetFloat(" does not exist!", this.CCIENBFIKKH);
			this.LNLKMDPHDCC().SetVector(" with a prefix of ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 423f, 1019f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005396 RID: 21398 RVA: 0x0019F93F File Offset: 0x0019DB3F
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("ResourceIDInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005397 RID: 21399 RVA: 0x0019DBA2 File Offset: 0x0019BDA2
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005398 RID: 21400 RVA: 0x0019DBA2 File Offset: 0x0019BDA2
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005399 RID: 21401 RVA: 0x0019DBA2 File Offset: 0x0019BDA2
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600539B RID: 21403 RVA: 0x0019F9A4 File Offset: 0x0019DBA4
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1623f)
			{
				this.HBJJOCHGOPH = 1561f;
			}
			this.NBPKMLMCHFN.SetFloat("st", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("GlassesColor2", this.X);
			this.KEMJNOMIPHN().SetFloat("{0} months ago", this.Y);
			this.PHGCJOPFDOG().SetFloat("_TimeX", this.Rate);
			this.HHIFMIPPMPF().SetFloat("Done!", this.CCIENBFIKKH);
			this.FHFLKLMFHOI().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1216f, 1986f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600539C RID: 21404 RVA: 0x0019FAA3 File Offset: 0x0019DCA3
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600539D RID: 21405 RVA: 0x0019FADA File Offset: 0x0019DCDA
	private void JECMJNFGBGC()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x040008B3 RID: 2227
	public Shader SCShader;

	// Token: 0x040008B4 RID: 2228
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040008B5 RID: 2229
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040008B6 RID: 2230
	private Material BJFKDHHMLJH;

	// Token: 0x040008B7 RID: 2231
	[Range(-4f, 4f)]
	public float X = 0.5f;

	// Token: 0x040008B8 RID: 2232
	[Range(-4f, 4f)]
	public float Y = 0.5f;

	// Token: 0x040008B9 RID: 2233
	[Range(0f, 5f)]
	public float Rate = 1f;

	// Token: 0x040008BA RID: 2234
	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;
}
