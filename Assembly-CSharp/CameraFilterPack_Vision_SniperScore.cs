using System;
using UnityEngine;

// Token: 0x02000139 RID: 313
[AddComponentMenu("Camera Filter Pack/Vision/SniperScore")]
[ExecuteInEditMode]
public class CameraFilterPack_Vision_SniperScore : MonoBehaviour
{
	// Token: 0x060062EA RID: 25322 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x060062EB RID: 25323 RVA: 0x001E17C1 File Offset: 0x001DF9C1
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060062EC RID: 25324 RVA: 0x001E17F8 File Offset: 0x001DF9F8
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060062ED RID: 25325 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x060062EE RID: 25326 RVA: 0x001E182F File Offset: 0x001DFA2F
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060062EF RID: 25327 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x060062F0 RID: 25328 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x060062F1 RID: 25329 RVA: 0x001E182F File Offset: 0x001DFA2F
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060062F2 RID: 25330 RVA: 0x001E182F File Offset: 0x001DFA2F
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060062F3 RID: 25331 RVA: 0x001E184C File Offset: 0x001DFA4C
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1899f)
			{
				this.HBJJOCHGOPH = 1657f;
			}
			this.IONHGBPGCHK().SetFloat("_Y", this.Fade);
			this.IIBLJCKLGFG().SetFloat("skin.no_hit", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat(" Time: ", this.Size);
			this.NBPKMLMCHFN.SetFloat(" elements", this.Smooth);
			this.HEHKGPKLAKK().SetFloat("_TimeX", this.ICABEDDNGIH);
			this.EMDFHOKEGNG().SetFloat("float,1", this.LHOMPJOPKHE);
			this.EMDFHOKEGNG().SetFloat("[Right]", this._Cible);
			this.FAIFBBGFAIB().SetFloat("Show Image", this._ExtraColor);
			this.MCDGIILBNIF().SetFloat("System.Int64", this._Distortion);
			this.IONHGBPGCHK().SetFloat("CameraFilterPack/Blur_Radial_Fast", this._PosX);
			this.IONHGBPGCHK().SetFloat("menu.enableselectormusic", this._PosY);
			this.ADBKPGFMNKO().SetColor("ClearEnvironment", this._Tint);
			this.IIBLJCKLGFG().SetFloat("TransferOwnership() view ", this._ExtraLight);
			Vector2 vector = new Vector2((float)Screen.width, (float)Screen.height);
			this.KEMJNOMIPHN().SetVector("ns", new Vector4(vector.x, vector.y, vector.y / vector.x, 987f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060062F4 RID: 25332 RVA: 0x001E1A18 File Offset: 0x001DFC18
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-70);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060062F5 RID: 25333 RVA: 0x001E1A4F File Offset: 0x001DFC4F
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Vision_SniperScore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060062F6 RID: 25334 RVA: 0x001E1A74 File Offset: 0x001DFC74
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1965f)
			{
				this.HBJJOCHGOPH = 1502f;
			}
			this.EMDFHOKEGNG().SetFloat("EventTimeInputField", this.Fade);
			this.MMOODGIODPC().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("[RanksSystem] Ranks: no need to update", this.Size);
			this.JLHLHKPHDFO().SetFloat("id", this.Smooth);
			this.IONHGBPGCHK().SetFloat("_TimeX", this.ICABEDDNGIH);
			this.EMDFHOKEGNG().SetFloat("A", this.LHOMPJOPKHE);
			this.EMDFHOKEGNG().SetFloat("GameModeText", this._Cible);
			this.FAIFBBGFAIB().SetFloat(".icon", this._ExtraColor);
			this.NBMPPNFKFLB().SetFloat("BackButton", this._Distortion);
			this.HEHKGPKLAKK().SetFloat("bool", this._PosX);
			this.HEHKGPKLAKK().SetFloat("[MapsData] Bad map: ", this._PosY);
			this.JLHLHKPHDFO().SetColor("_Value2", this._Tint);
			this.EMDFHOKEGNG().SetFloat("_Value3", this._ExtraLight);
			Vector2 vector = new Vector2((float)Screen.width, (float)Screen.height);
			this.ADBKPGFMNKO().SetVector("Failed to 'network-remove' GameObject because it's null.", new Vector4(vector.x, vector.y, vector.y / vector.x, 776f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060062F7 RID: 25335 RVA: 0x001E1C40 File Offset: 0x001DFE40
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060062F8 RID: 25336 RVA: 0x001E1C77 File Offset: 0x001DFE77
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060062F9 RID: 25337 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x060062FA RID: 25338 RVA: 0x001E1CAE File Offset: 0x001DFEAE
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060062FB RID: 25339 RVA: 0x001E182F File Offset: 0x001DFA2F
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060062FC RID: 25340 RVA: 0x001E1CE5 File Offset: 0x001DFEE5
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060062FD RID: 25341 RVA: 0x001E182F File Offset: 0x001DFA2F
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060062FE RID: 25342 RVA: 0x001E1D0C File Offset: 0x001DFF0C
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 708f)
			{
				this.HBJJOCHGOPH = 272f;
			}
			this.IONHGBPGCHK().SetFloat("Did not read byte array properly", this.Fade);
			this.MMOODGIODPC().SetFloat("z", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("[PlayerController] ", this.Size);
			this.MCDGIILBNIF().SetFloat("_Value", this.Smooth);
			this.EMDFHOKEGNG().SetFloat("_Value", this.ICABEDDNGIH);
			this.MCDGIILBNIF().SetFloat("LevelEditor/patterns", this.LHOMPJOPKHE);
			this.IONHGBPGCHK().SetFloat("maps.", this._Cible);
			this.OIMMPLPBLBK().SetFloat("-1", this._ExtraColor);
			this.MCDGIILBNIF().SetFloat("CountEventsGoal", this._Distortion);
			this.MCDGIILBNIF().SetFloat("Set the end of the map. Use this if you want to cut the long music.", this._PosX);
			this.NBMPPNFKFLB().SetFloat("_TimeX", this._PosY);
			this.HEHKGPKLAKK().SetColor("Set crosshair emission (glow)", this._Tint);
			this.FAIFBBGFAIB().SetFloat("1,30,true,0", this._ExtraLight);
			Vector2 vector = new Vector2((float)Screen.width, (float)Screen.height);
			this.KEMJNOMIPHN().SetVector("_History3Weight", new Vector4(vector.x, vector.y, vector.y / vector.x, 289f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060062FF RID: 25343 RVA: 0x001E1CE5 File Offset: 0x001DFEE5
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006300 RID: 25344 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06006301 RID: 25345 RVA: 0x001E1ED8 File Offset: 0x001E00D8
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.NBPKMLMCHFN.SetFloat("_Fade", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Smooth);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.ICABEDDNGIH);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.LHOMPJOPKHE);
			this.NBPKMLMCHFN.SetFloat("_Cible", this._Cible);
			this.NBPKMLMCHFN.SetFloat("_ExtraColor", this._ExtraColor);
			this.NBPKMLMCHFN.SetFloat("_Distortion", this._Distortion);
			this.NBPKMLMCHFN.SetFloat("_PosX", this._PosX);
			this.NBPKMLMCHFN.SetFloat("_PosY", this._PosY);
			this.NBPKMLMCHFN.SetColor("_Tint", this._Tint);
			this.NBPKMLMCHFN.SetFloat("_ExtraLight", this._ExtraLight);
			Vector2 vector = new Vector2((float)Screen.width, (float)Screen.height);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4(vector.x, vector.y, vector.y / vector.x, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006302 RID: 25346 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x06006303 RID: 25347 RVA: 0x001E20A4 File Offset: 0x001E02A4
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006304 RID: 25348 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x06006305 RID: 25349 RVA: 0x001E182F File Offset: 0x001DFA2F
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006306 RID: 25350 RVA: 0x001E182F File Offset: 0x001DFA2F
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006307 RID: 25351 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06006308 RID: 25352 RVA: 0x001E20DB File Offset: 0x001E02DB
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006309 RID: 25353 RVA: 0x001E2112 File Offset: 0x001E0312
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600630A RID: 25354 RVA: 0x001E182F File Offset: 0x001DFA2F
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600630B RID: 25355 RVA: 0x001E2149 File Offset: 0x001E0349
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("OnRenderImage in Helper called ...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600630C RID: 25356 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x0600630D RID: 25357 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x0600630E RID: 25358 RVA: 0x001E216D File Offset: 0x001E036D
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("[NetworkManager] Join failed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600630F RID: 25359 RVA: 0x001E2191 File Offset: 0x001E0391
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("Joystick1Button12");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x1700011E RID: 286
	// (get) Token: 0x06006310 RID: 25360 RVA: 0x001E21B5 File Offset: 0x001E03B5
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

	// Token: 0x06006311 RID: 25361 RVA: 0x001E21EC File Offset: 0x001E03EC
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("{0}\n{1}\n{2}\n{3}\n{4}\n{5}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006312 RID: 25362 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x06006313 RID: 25363 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06006314 RID: 25364 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06006315 RID: 25365 RVA: 0x001E2210 File Offset: 0x001E0410
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find(" / ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006316 RID: 25366 RVA: 0x001E2234 File Offset: 0x001E0434
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find(".b");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006317 RID: 25367 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06006319 RID: 25369 RVA: 0x001E22F8 File Offset: 0x001E04F8
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600631A RID: 25370 RVA: 0x001E232F File Offset: 0x001E052F
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("shader.ghost");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600631B RID: 25371 RVA: 0x001E182F File Offset: 0x001DFA2F
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600631C RID: 25372 RVA: 0x001E182F File Offset: 0x001DFA2F
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600631D RID: 25373 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x0600631E RID: 25374 RVA: 0x001E2354 File Offset: 0x001E0554
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 293f)
			{
				this.HBJJOCHGOPH = 1978f;
			}
			this.KEMJNOMIPHN().SetFloat("_Value6", this.Fade);
			this.OIMMPLPBLBK().SetFloat(". Should be just one?", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("Fill Area", this.Size);
			this.MMOODGIODPC().SetFloat("_Green_C", this.Smooth);
			this.OIMMPLPBLBK().SetFloat("SetEnvSpriteImage", this.ICABEDDNGIH);
			this.IIBLJCKLGFG().SetFloat("sfxVolume", this.LHOMPJOPKHE);
			this.MMOODGIODPC().SetFloat("maps.", this._Cible);
			this.FAIFBBGFAIB().SetFloat("</color>", this._ExtraColor);
			this.IONHGBPGCHK().SetFloat("_TimeX", this._Distortion);
			this.EMDFHOKEGNG().SetFloat("Editor", this._PosX);
			this.ADBKPGFMNKO().SetFloat("SetLives", this._PosY);
			this.ADBKPGFMNKO().SetColor("offline", this._Tint);
			this.IIBLJCKLGFG().SetFloat("_MainTex2", this._ExtraLight);
			Vector2 vector = new Vector2((float)Screen.width, (float)Screen.height);
			this.IIBLJCKLGFG().SetVector("settings_bindings_controller_type", new Vector4(vector.x, vector.y, vector.y / vector.x, 1974f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600631F RID: 25375 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06006320 RID: 25376 RVA: 0x001E2520 File Offset: 0x001E0720
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006321 RID: 25377 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06006322 RID: 25378 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06006323 RID: 25379 RVA: 0x001E182F File Offset: 0x001DFA2F
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006324 RID: 25380 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06006325 RID: 25381 RVA: 0x001E2557 File Offset: 0x001E0757
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("https://steamcdn-a.akamaihd.net/steamcommunity/public/images/clans/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006326 RID: 25382 RVA: 0x001E257B File Offset: 0x001E077B
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-86);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006327 RID: 25383 RVA: 0x001E25B4 File Offset: 0x001E07B4
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1851f)
			{
				this.HBJJOCHGOPH = 455f;
			}
			this.EMDFHOKEGNG().SetFloat("Tab2Content", this.Fade);
			this.FAIFBBGFAIB().SetFloat("  |  Events Count: ", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("settings_bindings_controller_type", this.Size);
			this.IIBLJCKLGFG().SetFloat("Joined room ", this.Smooth);
			this.MCDGIILBNIF().SetFloat("{0}{1}{2}={3}", this.ICABEDDNGIH);
			this.FAIFBBGFAIB().SetFloat("_TimeX", this.LHOMPJOPKHE);
			this.ADBKPGFMNKO().SetFloat("_EmissionColor", this._Cible);
			this.IIBLJCKLGFG().SetFloat("Hidden/Subpixel Morphological Anti-aliasing", this._ExtraColor);
			this.IONHGBPGCHK().SetFloat("_SizeY", this._Distortion);
			this.EMDFHOKEGNG().SetFloat(".g", this._PosX);
			this.KEMJNOMIPHN().SetFloat("Set environment sprite color and alpha.", this._PosY);
			this.HEHKGPKLAKK().SetColor("BitsData", this._Tint);
			this.KEMJNOMIPHN().SetFloat("_SampleCount", this._ExtraLight);
			Vector2 vector = new Vector2((float)Screen.width, (float)Screen.height);
			this.IONHGBPGCHK().SetVector("CameraFilterPack/EyesVision_1", new Vector4(vector.x, vector.y, vector.y / vector.x, 792f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006328 RID: 25384 RVA: 0x001E182F File Offset: 0x001DFA2F
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006329 RID: 25385 RVA: 0x001E2780 File Offset: 0x001E0980
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 194f)
			{
				this.HBJJOCHGOPH = 1408f;
			}
			this.OIMMPLPBLBK().SetFloat("_TimeX", this.Fade);
			this.NBPKMLMCHFN.SetFloat("Committing changes...", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat("CameraFilterPack/Blend2Camera_GreenScreen", this.Size);
			this.FAIFBBGFAIB().SetFloat("inventory.selected.", this.Smooth);
			this.ADBKPGFMNKO().SetFloat("_TimeX", this.ICABEDDNGIH);
			this.ADBKPGFMNKO().SetFloat("Added event", this.LHOMPJOPKHE);
			this.IIBLJCKLGFG().SetFloat("_ScreenResolution", this._Cible);
			this.ADBKPGFMNKO().SetFloat("\\\"", this._ExtraColor);
			this.IONHGBPGCHK().SetFloat("Expected protocol set to UDP, due to encryption mode DatagramEncryption. Changing protocol in PhotonServerSettings from: ", this._Distortion);
			this.OIMMPLPBLBK().SetFloat("_Near", this._PosX);
			this.NBMPPNFKFLB().SetFloat("_CenterY", this._PosY);
			this.NBPKMLMCHFN.SetColor("L2", this._Tint);
			this.JLHLHKPHDFO().SetFloat(" not exist", this._ExtraLight);
			Vector2 vector = new Vector2((float)Screen.width, (float)Screen.height);
			this.JLHLHKPHDFO().SetVector("Set Particles Input", new Vector4(vector.x, vector.y, vector.y / vector.x, 134f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600632A RID: 25386 RVA: 0x001E294C File Offset: 0x001E0B4C
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blizzard");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x040009FA RID: 2554
	public Shader SCShader;

	// Token: 0x040009FB RID: 2555
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040009FC RID: 2556
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040009FD RID: 2557
	private Material BJFKDHHMLJH;

	// Token: 0x040009FE RID: 2558
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x040009FF RID: 2559
	[Range(0f, 1f)]
	public float Size = 0.45f;

	// Token: 0x04000A00 RID: 2560
	[Range(0.01f, 0.4f)]
	public float Smooth = 0.045f;

	// Token: 0x04000A01 RID: 2561
	[Range(0f, 1f)]
	public float _Cible = 0.5f;

	// Token: 0x04000A02 RID: 2562
	[Range(0f, 1f)]
	public float _Distortion = 0.5f;

	// Token: 0x04000A03 RID: 2563
	[Range(0f, 1f)]
	public float _ExtraColor = 0.5f;

	// Token: 0x04000A04 RID: 2564
	[Range(0f, 1f)]
	public float _ExtraLight = 0.35f;

	// Token: 0x04000A05 RID: 2565
	public Color _Tint = new Color(0f, 0.6f, 0f, 0.25f);

	// Token: 0x04000A06 RID: 2566
	[Range(0f, 10f)]
	private float ICABEDDNGIH = 1f;

	// Token: 0x04000A07 RID: 2567
	[Range(0f, 10f)]
	private float LHOMPJOPKHE = 1f;

	// Token: 0x04000A08 RID: 2568
	[Range(-1f, 1f)]
	public float _PosX;

	// Token: 0x04000A09 RID: 2569
	[Range(-1f, 1f)]
	public float _PosY;
}
