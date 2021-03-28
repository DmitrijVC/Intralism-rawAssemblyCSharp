using System;
using UnityEngine;

// Token: 0x020000E8 RID: 232
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Gradients/Stripe")]
public class CameraFilterPack_Gradients_Stripe : MonoBehaviour
{
	// Token: 0x170000CE RID: 206
	// (get) Token: 0x06004793 RID: 18323 RVA: 0x0015F193 File Offset: 0x0015D393
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

	// Token: 0x06004794 RID: 18324 RVA: 0x0015F1CA File Offset: 0x0015D3CA
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004795 RID: 18325 RVA: 0x0015F1E7 File Offset: 0x0015D3E7
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004796 RID: 18326 RVA: 0x0015F21E File Offset: 0x0015D41E
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004797 RID: 18327 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06004798 RID: 18328 RVA: 0x0015F255 File Offset: 0x0015D455
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004799 RID: 18329 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x0600479A RID: 18330 RVA: 0x0015F27C File Offset: 0x0015D47C
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1038f)
			{
				this.HBJJOCHGOPH = 215f;
			}
			this.HCGJCMDJPGD().SetFloat(" is not supported on this platform!", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("Item created: Id: ", this.Switch);
			this.HCGJCMDJPGD().SetFloat("Tab1Content", this.Fade);
			this.KBOPGONOCNP().SetVector("maphash", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1527f, 114f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600479B RID: 18331 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x0600479C RID: 18332 RVA: 0x0015F350 File Offset: 0x0015D550
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1378f)
			{
				this.HBJJOCHGOPH = 1453f;
			}
			this.HCGJCMDJPGD().SetFloat("Skipping EstablishEncryption. Protocol is secure.", this.HBJJOCHGOPH);
			this.MLMKCOINOOH().SetFloat("UI/Particles/Hidden", this.Switch);
			this.HNICHJCGJOC().SetFloat("Identity LUT", this.Fade);
			this.OCHJIMJNEMO().SetVector("_FgCocMask", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 157f, 1855f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600479D RID: 18333 RVA: 0x0015F1CA File Offset: 0x0015D3CA
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600479E RID: 18334 RVA: 0x0015F1CA File Offset: 0x0015D3CA
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600479F RID: 18335 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x060047A0 RID: 18336 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x060047A1 RID: 18337 RVA: 0x0015F423 File Offset: 0x0015D623
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060047A2 RID: 18338 RVA: 0x0015F448 File Offset: 0x0015D648
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1913f)
			{
				this.HBJJOCHGOPH = 174f;
			}
			this.BKKJJJGADLM().SetFloat("&page=", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("float,2", this.Switch);
			this.IGIAPKPKGPK().SetFloat("float,1.5", this.Fade);
			this.HFBJAOFLCJI().SetVector("OK", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 967f, 1780f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060047A3 RID: 18339 RVA: 0x0015F51C File Offset: 0x0015D71C
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Switch);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Fade);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060047A4 RID: 18340 RVA: 0x0015F423 File Offset: 0x0015D623
	private void LIBGAKMKHJJ()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060047A5 RID: 18341 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x060047A6 RID: 18342 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x060047A7 RID: 18343 RVA: 0x0015F5EF File Offset: 0x0015D7EF
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-98);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060047A8 RID: 18344 RVA: 0x0015F628 File Offset: 0x0015D828
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1581f)
			{
				this.HBJJOCHGOPH = 23f;
			}
			this.HFBJAOFLCJI().SetFloat("EnvironmentSlider", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.Switch);
			this.EJDPNJAEAKJ().SetFloat("Anomaly_Distortion_Size", this.Fade);
			this.FAIFBBGFAIB().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1135f, 984f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060047A9 RID: 18345 RVA: 0x0015F255 File Offset: 0x0015D455
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060047AA RID: 18346 RVA: 0x0015F1CA File Offset: 0x0015D3CA
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060047AB RID: 18347 RVA: 0x0015F1CA File Offset: 0x0015D3CA
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060047AC RID: 18348 RVA: 0x0015F6FC File Offset: 0x0015D8FC
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1731f)
			{
				this.HBJJOCHGOPH = 149f;
			}
			this.MLMKCOINOOH().SetFloat("st", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("CameraFilterPack/Drawing_Halftone", this.Switch);
			this.NBPKMLMCHFN.SetFloat(" ", this.Fade);
			this.IGIAPKPKGPK().SetVector(" not exist", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1991f, 1711f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060047AD RID: 18349 RVA: 0x0015F7D0 File Offset: 0x0015D9D0
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 585f)
			{
				this.HBJJOCHGOPH = 176f;
			}
			this.HCGJCMDJPGD().SetFloat("settings.shaders", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("settings.volume.sfx", this.Switch);
			this.EJDPNJAEAKJ().SetFloat("_Value4", this.Fade);
			this.KAFBNOBOIAJ().SetVector("[NetworkManager] Exited", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1919f, 1447f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060047AE RID: 18350 RVA: 0x0015F8A3 File Offset: 0x0015DAA3
	private Material MLMKCOINOOH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060047AF RID: 18351 RVA: 0x0015F1CA File Offset: 0x0015D3CA
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060047B0 RID: 18352 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x060047B1 RID: 18353 RVA: 0x0015F8DA File Offset: 0x0015DADA
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060047B2 RID: 18354 RVA: 0x0015F1CA File Offset: 0x0015D3CA
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060047B3 RID: 18355 RVA: 0x0015F914 File Offset: 0x0015DB14
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 538f)
			{
				this.HBJJOCHGOPH = 221f;
			}
			this.MLMKCOINOOH().SetFloat("id", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("LevelFolderInputField", this.Switch);
			this.EJDPNJAEAKJ().SetFloat("HandleEventLeave for player ID: ", this.Fade);
			this.HFBJAOFLCJI().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1087f, 992f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060047B4 RID: 18356 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x060047B5 RID: 18357 RVA: 0x0015F9E8 File Offset: 0x0015DBE8
	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 373f)
			{
				this.HBJJOCHGOPH = 1227f;
			}
			this.HNICHJCGJOC().SetFloat("{0} days ago", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("#tryagain", this.Switch);
			this.MFHPKGICPIO().SetFloat("_TimeX", this.Fade);
			this.FAIFBBGFAIB().SetVector("SlidingArea", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1313f, 1139f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060047B6 RID: 18358 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060047B7 RID: 18359 RVA: 0x0015F423 File Offset: 0x0015D623
	private void MJEFMIPLFAB()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060047B8 RID: 18360 RVA: 0x0015F423 File Offset: 0x0015D623
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060047B9 RID: 18361 RVA: 0x0015FABB File Offset: 0x0015DCBB
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060047BA RID: 18362 RVA: 0x0015FAF2 File Offset: 0x0015DCF2
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060047BB RID: 18363 RVA: 0x0015FB29 File Offset: 0x0015DD29
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060047BC RID: 18364 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x060047BD RID: 18365 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x060047BE RID: 18366 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x060047BF RID: 18367 RVA: 0x0015FB60 File Offset: 0x0015DD60
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1155f)
			{
				this.HBJJOCHGOPH = 297f;
			}
			this.BFGNMFCNDBC().SetFloat("Spawn new environment sprite (image) and sets its id", this.HBJJOCHGOPH);
			this.MLMKCOINOOH().SetFloat("#rt", this.Switch);
			this.NBPKMLMCHFN.SetFloat("_DistanceParams", this.Fade);
			this.MFHPKGICPIO().SetVector("_MainTex2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 326f, 533f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060047C0 RID: 18368 RVA: 0x0015F423 File Offset: 0x0015D623
	private void DFFKKLAPHCC()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060047C1 RID: 18369 RVA: 0x0015F1CA File Offset: 0x0015D3CA
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060047C3 RID: 18371 RVA: 0x0015FC67 File Offset: 0x0015DE67
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-104);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060047C4 RID: 18372 RVA: 0x0015F255 File Offset: 0x0015D455
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060047C5 RID: 18373 RVA: 0x0015F1CA File Offset: 0x0015D3CA
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060047C6 RID: 18374 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHJJFJCKGAJ()
	{
	}

	// Token: 0x060047C7 RID: 18375 RVA: 0x0015F1CA File Offset: 0x0015D3CA
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060047C8 RID: 18376 RVA: 0x0015F1CA File Offset: 0x0015D3CA
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060047C9 RID: 18377 RVA: 0x0015FCA0 File Offset: 0x0015DEA0
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 760f)
			{
				this.HBJJOCHGOPH = 1093f;
			}
			this.IGIAPKPKGPK().SetFloat("Set particless emission (glow)", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("mapselector.lastSearch", this.Switch);
			this.HCGJCMDJPGD().SetFloat(": ", this.Fade);
			this.OCHJIMJNEMO().SetVector(".lastCheckpoint.perfectHits", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1074f, 1669f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060047CA RID: 18378 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x060047CB RID: 18379 RVA: 0x0015F1CA File Offset: 0x0015D3CA
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060047CC RID: 18380 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x060047CD RID: 18381 RVA: 0x0015FD74 File Offset: 0x0015DF74
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 661f)
			{
				this.HBJJOCHGOPH = 1315f;
			}
			this.EFMCNLELMDO().SetFloat("TestMapButton", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat(" with prefix ", this.Switch);
			this.HCGJCMDJPGD().SetFloat("/", this.Fade);
			this.HNICHJCGJOC().SetVector("CameraFilterPack/TV_Chromatical", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1137f, 1788f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060047CE RID: 18382 RVA: 0x0015F255 File Offset: 0x0015D455
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060047CF RID: 18383 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x060047D0 RID: 18384 RVA: 0x0015FE48 File Offset: 0x0015E048
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1881f)
			{
				this.HBJJOCHGOPH = 1040f;
			}
			this.NDMPCDHADMJ().SetFloat("_Value", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("z", this.Switch);
			this.OCHJIMJNEMO().SetFloat("Editor", this.Fade);
			this.KBOPGONOCNP().SetVector("Show image from resources by id at the center of the screen at foreground or background", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1274f, 1771f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060047D1 RID: 18385 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x060047D2 RID: 18386 RVA: 0x0015F423 File Offset: 0x0015D623
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060047D3 RID: 18387 RVA: 0x0015FF1B File Offset: 0x0015E11B
	private Material EFMCNLELMDO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060047D4 RID: 18388 RVA: 0x0015F255 File Offset: 0x0015D455
	private void OKLAJINHPAN()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060047D5 RID: 18389 RVA: 0x0015F423 File Offset: 0x0015D623
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060047D6 RID: 18390 RVA: 0x0015FF54 File Offset: 0x0015E154
	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 23f)
			{
				this.HBJJOCHGOPH = 1214f;
			}
			this.AELJLBOJAIL().SetFloat(".lastCheckpoint.currentCombo", this.HBJJOCHGOPH);
			this.MLMKCOINOOH().SetFloat("UndoButton", this.Switch);
			this.FAIFBBGFAIB().SetFloat("OK", this.Fade);
			this.BFGNMFCNDBC().SetVector(",", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 894f, 199f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060047D7 RID: 18391 RVA: 0x0015F1CA File Offset: 0x0015D3CA
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060047D8 RID: 18392 RVA: 0x00160027 File Offset: 0x0015E227
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060047D9 RID: 18393 RVA: 0x00160060 File Offset: 0x0015E260
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1829f)
			{
				this.HBJJOCHGOPH = 821f;
			}
			this.FAIFBBGFAIB().SetFloat("[ItemsHandler] Loading ", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("Anomaly_Distortion_Size", this.Switch);
			this.KAFBNOBOIAJ().SetFloat("UI Extensions/SoftMaskShader", this.Fade);
			this.BKKJJJGADLM().SetVector("%", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1558f, 1013f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060047DA RID: 18394 RVA: 0x0015F423 File Offset: 0x0015D623
	private void Start()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060047DB RID: 18395 RVA: 0x00160134 File Offset: 0x0015E334
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 584f)
			{
				this.HBJJOCHGOPH = 1384f;
			}
			this.BKKJJJGADLM().SetFloat("SetSpeed", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("_Value", this.Switch);
			this.HCGJCMDJPGD().SetFloat(".lastCheckpoint.penaltyScore", this.Fade);
			this.BKKJJJGADLM().SetVector("shader.pixel", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 17f, 1955f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060047DC RID: 18396 RVA: 0x00160207 File Offset: 0x0015E407
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060047DD RID: 18397 RVA: 0x00160240 File Offset: 0x0015E440
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 401f)
			{
				this.HBJJOCHGOPH = 1848f;
			}
			this.KBOPGONOCNP().SetFloat("GlassesColor", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("bad", this.Switch);
			this.KBOPGONOCNP().SetFloat(".lastCheckpoint.lives", this.Fade);
			this.BKKJJJGADLM().SetVector("deletemap", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 852f, 191f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060047DE RID: 18398 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x060047DF RID: 18399 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x060047E0 RID: 18400 RVA: 0x00160313 File Offset: 0x0015E513
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060047E1 RID: 18401 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x060047E2 RID: 18402 RVA: 0x0015F423 File Offset: 0x0015D623
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060047E3 RID: 18403 RVA: 0x0015F255 File Offset: 0x0015D455
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060047E4 RID: 18404 RVA: 0x0016034A File Offset: 0x0015E54A
	private Material BKKJJJGADLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060047E5 RID: 18405 RVA: 0x00160381 File Offset: 0x0015E581
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060047E6 RID: 18406 RVA: 0x0015F1CA File Offset: 0x0015D3CA
	private void ELDMKIAPNGP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060047E7 RID: 18407 RVA: 0x001603B8 File Offset: 0x0015E5B8
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)67;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060047E8 RID: 18408 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x060047E9 RID: 18409 RVA: 0x0015F1CA File Offset: 0x0015D3CA
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060047EA RID: 18410 RVA: 0x0015F423 File Offset: 0x0015D623
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060047EB RID: 18411 RVA: 0x0015F1CA File Offset: 0x0015D3CA
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060047EC RID: 18412 RVA: 0x0015F1CA File Offset: 0x0015D3CA
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060047ED RID: 18413 RVA: 0x0015F1CA File Offset: 0x0015D3CA
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060047EE RID: 18414 RVA: 0x0015F255 File Offset: 0x0015D455
	private void NKFDNIAKGEO()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060047EF RID: 18415 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x060047F0 RID: 18416 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJHFOBHJEHL()
	{
	}

	// Token: 0x060047F1 RID: 18417 RVA: 0x0015F423 File Offset: 0x0015D623
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060047F2 RID: 18418 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x060047F3 RID: 18419 RVA: 0x0015F1CA File Offset: 0x0015D3CA
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060047F4 RID: 18420 RVA: 0x0015F255 File Offset: 0x0015D455
	private void JKBMKPDGCHG()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x04000792 RID: 1938
	public Shader SCShader;

	// Token: 0x04000793 RID: 1939
	private string ELOFMLPCCEA = "CameraFilterPack/Gradients_Stripe";

	// Token: 0x04000794 RID: 1940
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000795 RID: 1941
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000796 RID: 1942
	private Material BJFKDHHMLJH;

	// Token: 0x04000797 RID: 1943
	[Range(0f, 1f)]
	public float Switch = 1f;

	// Token: 0x04000798 RID: 1944
	[Range(0f, 1f)]
	public float Fade = 1f;
}
