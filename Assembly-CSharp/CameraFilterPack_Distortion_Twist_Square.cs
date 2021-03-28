using System;
using UnityEngine;

// Token: 0x02000094 RID: 148
[AddComponentMenu("Camera Filter Pack/Distortion/Twist_Square")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_Twist_Square : MonoBehaviour
{
	// Token: 0x06002BDA RID: 11226 RVA: 0x000EDEF8 File Offset: 0x000EC0F8
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 380f)
			{
				this.HBJJOCHGOPH = 1925f;
			}
			this.HEHKGPKLAKK().SetFloat("event", this.HBJJOCHGOPH);
			this.JDMJJGEHMJO().SetFloat("received</b>\n#reason: ", this.CenterX);
			this.PDEAHJPOMEF().SetFloat("CheckpointsScoreText", this.CenterY);
			this.OLHDPICFBOF().SetFloat("SetParticlesGravity", this.Distortion);
			this.IKAEIOAHPKI().SetFloat("_Value2", this.Size);
			this.NBPKMLMCHFN.SetVector("AreaTex", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002BDB RID: 11227 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void PGMMBADJIKH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002BDC RID: 11228 RVA: 0x000EE00D File Offset: 0x000EC20D
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find("_SSAO");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002BDD RID: 11229 RVA: 0x000EE031 File Offset: 0x000EC231
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find(". Not Destroying GameObject or PhotonViews!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002BDE RID: 11230 RVA: 0x000EE055 File Offset: 0x000EC255
	private Material OPMDBHHACME()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002BDF RID: 11231 RVA: 0x000EE08C File Offset: 0x000EC28C
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)110;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002BE0 RID: 11232 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void ABEIEGDHBNO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002BE1 RID: 11233 RVA: 0x000EE0C3 File Offset: 0x000EC2C3
	private void KOFAMEKHHGD()
	{
		this.SCShader = Shader.Find("inventory.selected.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002BE2 RID: 11234 RVA: 0x000EE0E7 File Offset: 0x000EC2E7
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002BE3 RID: 11235 RVA: 0x000EE11E File Offset: 0x000EC31E
	private Material IKAEIOAHPKI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002BE4 RID: 11236 RVA: 0x0002523B File Offset: 0x0002343B
	private void GGPDKCHEBAG()
	{
	}

	// Token: 0x06002BE5 RID: 11237 RVA: 0x000EE155 File Offset: 0x000EC355
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002BE6 RID: 11238 RVA: 0x000EE18C File Offset: 0x000EC38C
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 412f)
			{
				this.HBJJOCHGOPH = 1524f;
			}
			this.EOCCJGIGEGJ().SetFloat("VisionBlur", this.HBJJOCHGOPH);
			this.IOHHLNAPGMA().SetFloat("IncorrectHitsScoreText", this.CenterX);
			this.EOCCJGIGEGJ().SetFloat("inventory.selected.", this.CenterY);
			this.IGKFMCPDNOI().SetFloat("_CenterX", this.Distortion);
			this.FKEOGPDLBDD().SetFloat("[", this.Size);
			this.OIIDAKBILMI().SetVector("[LevelEditorScene] Map submitted!", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MPENCEIGLEH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002BE7 RID: 11239 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void BDBJEDIOKBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002BE8 RID: 11240 RVA: 0x000EE284 File Offset: 0x000EC484
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002BE9 RID: 11241 RVA: 0x000EE2BB File Offset: 0x000EC4BB
	private void BKIGIIINEDH()
	{
		this.SCShader = Shader.Find("SetScale");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002BEA RID: 11242 RVA: 0x000EE2DF File Offset: 0x000EC4DF
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find(" timeUntilRespawn: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002BEB RID: 11243 RVA: 0x000EE303 File Offset: 0x000EC503
	private void AEOLJEIDMDB()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002BEC RID: 11244 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06002BED RID: 11245 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06002BEE RID: 11246 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void NHHCGPAMLAJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002BEF RID: 11247 RVA: 0x000EE328 File Offset: 0x000EC528
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1373f)
			{
				this.HBJJOCHGOPH = 1789f;
			}
			this.OIIDAKBILMI().SetFloat("_Size", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("_Parasite", this.CenterX);
			this.HEHKGPKLAKK().SetFloat("maps.", this.CenterY);
			this.FKEOGPDLBDD().SetFloat("RULES", this.Distortion);
			this.KBOPGONOCNP().SetFloat("_SecondTex", this.Size);
			this.KGOLDDBHIFN().SetVector("maps.", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002BF0 RID: 11248 RVA: 0x000EE420 File Offset: 0x000EC620
	private Material IOHHLNAPGMA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002BF1 RID: 11249 RVA: 0x000EE458 File Offset: 0x000EC658
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1774f)
			{
				this.HBJJOCHGOPH = 1096f;
			}
			this.KDMBOKLMADJ().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.FKEOGPDLBDD().SetFloat("Can't do manual instantiation without PhotonView component.", this.CenterX);
			this.OLHDPICFBOF().SetFloat("settings.arcsnohitsoundtimedelay", this.CenterY);
			this.PDEAHJPOMEF().SetFloat("Chat", this.Distortion);
			this.FEAEGGCNIAA().SetFloat("_TimeX", this.Size);
			this.MPENCEIGLEH().SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002BF2 RID: 11250 RVA: 0x000EE550 File Offset: 0x000EC750
	private void LFAFJKJAEEL()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002BF3 RID: 11251 RVA: 0x000EE574 File Offset: 0x000EC774
	private Material ALABBJPHCNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)83;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002BF4 RID: 11252 RVA: 0x000EE5AB File Offset: 0x000EC7AB
	private void IGPCNCJIEOJ()
	{
		this.SCShader = Shader.Find("GameObject ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002BF5 RID: 11253 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06002BF6 RID: 11254 RVA: 0x000EE5CF File Offset: 0x000EC7CF
	private void MKOMIDCPCDC()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002BF7 RID: 11255 RVA: 0x000EE5F3 File Offset: 0x000EC7F3
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("_DistanceParams");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002BF8 RID: 11256 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002BF9 RID: 11257 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x06002BFA RID: 11258 RVA: 0x000EE617 File Offset: 0x000EC817
	private void HDMDKOKOOJC()
	{
		this.SCShader = Shader.Find("EditMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002BFB RID: 11259 RVA: 0x000EE63C File Offset: 0x000EC83C
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
			this.NBPKMLMCHFN.SetFloat("_CenterX", this.CenterX);
			this.NBPKMLMCHFN.SetFloat("_CenterY", this.CenterY);
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("_Size", this.Size);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002BFC RID: 11260 RVA: 0x000EE734 File Offset: 0x000EC934
	private void EDPDMBFLHLP()
	{
		this.SCShader = Shader.Find("_Blend");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002BFD RID: 11261 RVA: 0x000EE758 File Offset: 0x000EC958
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 698f)
			{
				this.HBJJOCHGOPH = 1824f;
			}
			this.KDMBOKLMADJ().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.HKIMAANBGMJ().SetFloat("Edited unlock conditions", this.CenterX);
			this.KGOLDDBHIFN().SetFloat("_MatrixColor", this.CenterY);
			this.IOHHLNAPGMA().SetFloat("Tab2Content", this.Distortion);
			this.OIIDAKBILMI().SetFloat("#ok", this.Size);
			this.ALABBJPHCNG().SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KLKILLCHJHO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002BFE RID: 11262 RVA: 0x000EE850 File Offset: 0x000ECA50
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1762f)
			{
				this.HBJJOCHGOPH = 1799f;
			}
			this.MFHPKGICPIO().SetFloat("_Offsets", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("[PlayerController] ", this.CenterX);
			this.OPMDBHHACME().SetFloat("_Blue_C", this.CenterY);
			this.AELJLBOJAIL().SetFloat("_TimeX", this.Distortion);
			this.HNFFHCLNBDN().SetFloat("_TimeX", this.Size);
			this.ALABBJPHCNG().SetVector("CameraFilterPack/Blend2Camera_Luminosity", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002BFF RID: 11263 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x06002C00 RID: 11264 RVA: 0x000EE948 File Offset: 0x000ECB48
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("MaxLivesSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002C01 RID: 11265 RVA: 0x000EE96C File Offset: 0x000ECB6C
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002C02 RID: 11266 RVA: 0x000EE9A4 File Offset: 0x000ECBA4
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 995f)
			{
				this.HBJJOCHGOPH = 1488f;
			}
			this.OIIDAKBILMI().SetFloat(",", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("_TimeX", this.CenterX);
			this.NBPKMLMCHFN.SetFloat("mapselector.filter.favoriteonly", this.CenterY);
			this.KGOLDDBHIFN().SetFloat("_ScreenResolution", this.Distortion);
			this.KGOLDDBHIFN().SetFloat(".sav", this.Size);
			this.FKEOGPDLBDD().SetVector("MenuScene", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ALABBJPHCNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C03 RID: 11267 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void OHBNLJOPDDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C04 RID: 11268 RVA: 0x000EEA9C File Offset: 0x000ECC9C
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002C05 RID: 11269 RVA: 0x000EEAD3 File Offset: 0x000ECCD3
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002C06 RID: 11270 RVA: 0x000EEAF7 File Offset: 0x000ECCF7
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("_SpotSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002C07 RID: 11271 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06002C08 RID: 11272 RVA: 0x0002523B File Offset: 0x0002343B
	private void MBLDJEFBLFL()
	{
	}

	// Token: 0x06002C09 RID: 11273 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C0A RID: 11274 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C0C RID: 11276 RVA: 0x000EEB5A File Offset: 0x000ECD5A
	private void IKDNLHLBHID()
	{
		this.SCShader = Shader.Find("#close");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002C0D RID: 11277 RVA: 0x000EEB80 File Offset: 0x000ECD80
	private void KLCAJPOCMPF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 938f)
			{
				this.HBJJOCHGOPH = 896f;
			}
			this.OPMDBHHACME().SetFloat("GameObject ", this.HBJJOCHGOPH);
			this.MPENCEIGLEH().SetFloat("_Value4", this.CenterX);
			this.AELJLBOJAIL().SetFloat("MapEnd", this.CenterY);
			this.KDMBOKLMADJ().SetFloat("#forever", this.Distortion);
			this.KGOLDDBHIFN().SetFloat("Default UI Material", this.Size);
			this.KDMBOKLMADJ().SetVector(".message", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C0E RID: 11278 RVA: 0x000EEC78 File Offset: 0x000ECE78
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002C0F RID: 11279 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void JNALDALAJLG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C10 RID: 11280 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C11 RID: 11281 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06002C12 RID: 11282 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06002C13 RID: 11283 RVA: 0x000EECAF File Offset: 0x000ECEAF
	private void JONGNKNLLND()
	{
		this.SCShader = Shader.Find("EventMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002C14 RID: 11284 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x06002C15 RID: 11285 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C16 RID: 11286 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06002C17 RID: 11287 RVA: 0x000EECD4 File Offset: 0x000ECED4
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 351f)
			{
				this.HBJJOCHGOPH = 1246f;
			}
			this.IOHHLNAPGMA().SetFloat("HandsCountSlider", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat("The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.", this.CenterX);
			this.DKKBFFHBHJE().SetFloat("LoadPlayerEnvironment", this.CenterY);
			this.KBOPGONOCNP().SetFloat("_ColorRGB", this.Distortion);
			this.AELJLBOJAIL().SetFloat("_FlipAlphaMask", this.Size);
			this.HKIMAANBGMJ().SetVector("Vertical", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C18 RID: 11288 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x06002C19 RID: 11289 RVA: 0x000EEDCC File Offset: 0x000ECFCC
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_Twist_Square");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002C1A RID: 11290 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x06002C1B RID: 11291 RVA: 0x000EEDF0 File Offset: 0x000ECFF0
	private Material JDMJJGEHMJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002C1C RID: 11292 RVA: 0x000EEE27 File Offset: 0x000ED027
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002C1D RID: 11293 RVA: 0x000EEE5E File Offset: 0x000ED05E
	private void MODENHKMKOC()
	{
		this.SCShader = Shader.Find("Add Environment Object");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002C1E RID: 11294 RVA: 0x000EEE84 File Offset: 0x000ED084
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 206f)
			{
				this.HBJJOCHGOPH = 1963f;
			}
			this.DKKBFFHBHJE().SetFloat("maps.", this.HBJJOCHGOPH);
			this.IOHHLNAPGMA().SetFloat("Beat Detected", this.CenterX);
			this.PDEAHJPOMEF().SetFloat("_FixDistance", this.CenterY);
			this.KBOPGONOCNP().SetFloat("_Value2", this.Distortion);
			this.LPCHMEKDCHI().SetFloat("_Visualize", this.Size);
			this.ACHNOHCLGOO().SetVector("ViewMenu", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KLKILLCHJHO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C1F RID: 11295 RVA: 0x000EEF7C File Offset: 0x000ED17C
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002C20 RID: 11296 RVA: 0x000EEFB3 File Offset: 0x000ED1B3
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002C21 RID: 11297 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C22 RID: 11298 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C23 RID: 11299 RVA: 0x000EEFEA File Offset: 0x000ED1EA
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)96;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002C24 RID: 11300 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x06002C25 RID: 11301 RVA: 0x000EF021 File Offset: 0x000ED221
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002C26 RID: 11302 RVA: 0x000EF058 File Offset: 0x000ED258
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1810f)
			{
				this.HBJJOCHGOPH = 277f;
			}
			this.OPMDBHHACME().SetFloat("s", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("Joystick1Button10", this.CenterX);
			this.ALABBJPHCNG().SetFloat("received</b>\n#reason: ", this.CenterY);
			this.AELJLBOJAIL().SetFloat("y", this.Distortion);
			this.MFHPKGICPIO().SetFloat("#outdatedmap! Challenges will not work!", this.Size);
			this.KLKILLCHJHO().SetVector("Joystick1Button5", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C27 RID: 11303 RVA: 0x000EF150 File Offset: 0x000ED350
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 344f)
			{
				this.HBJJOCHGOPH = 11f;
			}
			this.ALABBJPHCNG().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.IOHHLNAPGMA().SetFloat("_Value2", this.CenterX);
			this.ACHNOHCLGOO().SetFloat("_V", this.CenterY);
			this.AELJLBOJAIL().SetFloat("[SaveSystem] Init from ", this.Distortion);
			this.FKEOGPDLBDD().SetFloat("_Value4", this.Size);
			this.MFHPKGICPIO().SetVector("Editor/", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C28 RID: 11304 RVA: 0x000EF248 File Offset: 0x000ED448
	private void ECBILENEOOL()
	{
		this.SCShader = Shader.Find("Custom Authentication failed (either due to user-input or configuration or AuthParameter string format). Calling: OnCustomAuthenticationFailed()");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002C29 RID: 11305 RVA: 0x000EF26C File Offset: 0x000ED46C
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 430f)
			{
				this.HBJJOCHGOPH = 1098f;
			}
			this.ACHNOHCLGOO().SetFloat("settings.disablestoryboard", this.HBJJOCHGOPH);
			this.MPENCEIGLEH().SetFloat("_MainTex2", this.CenterX);
			this.ACHNOHCLGOO().SetFloat("#savemapchanges?", this.CenterY);
			this.OPMDBHHACME().SetFloat("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results", this.Distortion);
			this.IOHHLNAPGMA().SetFloat("_ScreenResolution", this.Size);
			this.HKIMAANBGMJ().SetVector("Editor", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C2A RID: 11306 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C2B RID: 11307 RVA: 0x000EF364 File Offset: 0x000ED564
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)64;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002C2C RID: 11308 RVA: 0x000EF39C File Offset: 0x000ED59C
	private void HNMIAKKBMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 167f)
			{
				this.HBJJOCHGOPH = 1694f;
			}
			this.HEHKGPKLAKK().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetFloat("_Value", this.CenterX);
			this.KDMBOKLMADJ().SetFloat("_TimeX", this.CenterY);
			this.HKIMAANBGMJ().SetFloat("_VelTex", this.Distortion);
			this.IGKFMCPDNOI().SetFloat("Editor", this.Size);
			this.OPMDBHHACME().SetVector("null", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C2D RID: 11309 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C2E RID: 11310 RVA: 0x000EF494 File Offset: 0x000ED694
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 756f)
			{
				this.HBJJOCHGOPH = 309f;
			}
			this.OPMDBHHACME().SetFloat("_Visualize", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("PunPickupSimple", this.CenterX);
			this.OLHDPICFBOF().SetFloat("Set Satellite Lerp Speed", this.CenterY);
			this.KLKILLCHJHO().SetFloat("_Value4", this.Distortion);
			this.FEAEGGCNIAA().SetFloat("achievements.21.progress", this.Size);
			this.IGKFMCPDNOI().SetVector("_Value3", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ALABBJPHCNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C2F RID: 11311 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMKBLLMIKAB()
	{
	}

	// Token: 0x06002C30 RID: 11312 RVA: 0x000EF58C File Offset: 0x000ED78C
	private void OGJJDKENBNC()
	{
		this.SCShader = Shader.Find("tagElement");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002C31 RID: 11313 RVA: 0x0002523B File Offset: 0x0002343B
	private void COGBDFKOHKK()
	{
	}

	// Token: 0x06002C32 RID: 11314 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C33 RID: 11315 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFMEAMBLODG()
	{
	}

	// Token: 0x06002C34 RID: 11316 RVA: 0x000EF5B0 File Offset: 0x000ED7B0
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("Can't find PhotonView of incoming OwnershipRequest. ViewId not found: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002C35 RID: 11317 RVA: 0x000EF5D4 File Offset: 0x000ED7D4
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 655f)
			{
				this.HBJJOCHGOPH = 164f;
			}
			this.DKKBFFHBHJE().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.OPMDBHHACME().SetFloat(":", this.CenterX);
			this.KDMBOKLMADJ().SetFloat("PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.", this.CenterY);
			this.FAIFBBGFAIB().SetFloat("LoadingStatusText", this.Distortion);
			this.OPMDBHHACME().SetFloat("_TimeX", this.Size);
			this.IOHHLNAPGMA().SetVector("_DistCenterScale", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C36 RID: 11318 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBMBNKOOENB()
	{
	}

	// Token: 0x06002C37 RID: 11319 RVA: 0x000EEC78 File Offset: 0x000ECE78
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002C38 RID: 11320 RVA: 0x000EF6CC File Offset: 0x000ED8CC
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1113f)
			{
				this.HBJJOCHGOPH = 1851f;
			}
			this.IGKFMCPDNOI().SetFloat(" ", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat("Texture2", this.CenterX);
			this.LMLENGFLEBD().SetFloat(": ", this.CenterY);
			this.FKEOGPDLBDD().SetFloat("_TimeX", this.Distortion);
			this.FEAEGGCNIAA().SetFloat("remaining: {0:0.000}", this.Size);
			this.MFHPKGICPIO().SetVector("...", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C39 RID: 11321 RVA: 0x000EF7C4 File Offset: 0x000ED9C4
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1089f)
			{
				this.HBJJOCHGOPH = 1513f;
			}
			this.PDEAHJPOMEF().SetFloat("_BlurCoe", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("_MatrixColor", this.CenterX);
			this.AELJLBOJAIL().SetFloat("Set satellite color", this.CenterY);
			this.LMLENGFLEBD().SetFloat("CameraFilterPack_TV_Noise2", this.Distortion);
			this.HEHKGPKLAKK().SetFloat("Xbox Home", this.Size);
			this.OLHDPICFBOF().SetVector("--------------------------------", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C3A RID: 11322 RVA: 0x000EF8BC File Offset: 0x000EDABC
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002C3B RID: 11323 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x06002C3C RID: 11324 RVA: 0x000EF8F4 File Offset: 0x000EDAF4
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 929f)
			{
				this.HBJJOCHGOPH = 820f;
			}
			this.OIIDAKBILMI().SetFloat("LevelEditor/patterns", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("You did not select a Hosting Type in your PhotonServerSettings. Please set it up or don't use ConnectUsingSettings().", this.CenterX);
			this.FEAEGGCNIAA().SetFloat("DPADVER", this.CenterY);
			this.HKIMAANBGMJ().SetFloat(".lastCheckpoint.correctScore", this.Distortion);
			this.FEAEGGCNIAA().SetFloat("_Value2", this.Size);
			this.IOHHLNAPGMA().SetVector("_Value9", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000079 RID: 121
	// (get) Token: 0x06002C3D RID: 11325 RVA: 0x000EF9EC File Offset: 0x000EDBEC
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

	// Token: 0x06002C3E RID: 11326 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIPBNBKNICE()
	{
	}

	// Token: 0x06002C3F RID: 11327 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x06002C40 RID: 11328 RVA: 0x000EFA23 File Offset: 0x000EDC23
	private void AIBNKIDADPI()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002C41 RID: 11329 RVA: 0x000EFA48 File Offset: 0x000EDC48
	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 523f)
			{
				this.HBJJOCHGOPH = 508f;
			}
			this.FEAEGGCNIAA().SetFloat("[", this.HBJJOCHGOPH);
			this.HKIMAANBGMJ().SetFloat("w", this.CenterX);
			this.ALABBJPHCNG().SetFloat("masterSteamID", this.CenterY);
			this.IOHHLNAPGMA().SetFloat("_Value3", this.Distortion);
			this.JDMJJGEHMJO().SetFloat("sounds/no_hit", this.Size);
			this.OLHDPICFBOF().SetVector(" with prefix ", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C42 RID: 11330 RVA: 0x000EFB40 File Offset: 0x000EDD40
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1337f)
			{
				this.HBJJOCHGOPH = 1552f;
			}
			this.OPMDBHHACME().SetFloat("CameraFilterPack/Blend2Camera_Darken", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("r", this.CenterX);
			this.IOHHLNAPGMA().SetFloat("No Camera attached!", this.CenterY);
			this.FKEOGPDLBDD().SetFloat("_StretchWidth", this.Distortion);
			this.HEHKGPKLAKK().SetFloat("_Value2", this.Size);
			this.JDMJJGEHMJO().SetVector("_Factor", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ALABBJPHCNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C43 RID: 11331 RVA: 0x000EFC38 File Offset: 0x000EDE38
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 892f)
			{
				this.HBJJOCHGOPH = 1314f;
			}
			this.DKKBFFHBHJE().SetFloat(" Time: ", this.HBJJOCHGOPH);
			this.KDMBOKLMADJ().SetFloat("plainText", this.CenterX);
			this.EOCCJGIGEGJ().SetFloat("isBunned", this.CenterY);
			this.KBOPGONOCNP().SetFloat("_Luminance", this.Distortion);
			this.KBOPGONOCNP().SetFloat("ResetButton", this.Size);
			this.PDEAHJPOMEF().SetVector("RECORD [R]", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C44 RID: 11332 RVA: 0x000EFD30 File Offset: 0x000EDF30
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 569f)
			{
				this.HBJJOCHGOPH = 686f;
			}
			this.KBOPGONOCNP().SetFloat("PunRespawn with Position.", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetFloat("_MatrixSpeed", this.CenterX);
			this.EOCCJGIGEGJ().SetFloat("_TimeX", this.CenterY);
			this.ACHNOHCLGOO().SetFloat("EndlessLoopsScoreText", this.Distortion);
			this.LMLENGFLEBD().SetFloat("_Amount", this.Size);
			this.ACHNOHCLGOO().SetVector("PUNCloudBestRegion", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C45 RID: 11333 RVA: 0x000EFE28 File Offset: 0x000EE028
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("---");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002C46 RID: 11334 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void AOKOLPEGHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C47 RID: 11335 RVA: 0x000EFE4C File Offset: 0x000EE04C
	private void EIMNPCMHJLJ()
	{
		this.SCShader = Shader.Find("/?player=");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002C48 RID: 11336 RVA: 0x000EFE70 File Offset: 0x000EE070
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1229f)
			{
				this.HBJJOCHGOPH = 1995f;
			}
			this.KGOLDDBHIFN().SetFloat("Tab2Content", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("_Bullet_1", this.CenterX);
			this.KDMBOKLMADJ().SetFloat(" Owner called.", this.CenterY);
			this.KLKILLCHJHO().SetFloat("player.lollipop", this.Distortion);
			this.KLKILLCHJHO().SetFloat("_Blue_G", this.Size);
			this.KDMBOKLMADJ().SetVector("0.00:0.00", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C49 RID: 11337 RVA: 0x000EFF68 File Offset: 0x000EE168
	private Material MPENCEIGLEH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002C4A RID: 11338 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06002C4B RID: 11339 RVA: 0x000EFFA0 File Offset: 0x000EE1A0
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1909f)
			{
				this.HBJJOCHGOPH = 713f;
			}
			this.IGKFMCPDNOI().SetFloat("Middle Click", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("workshop.", this.CenterX);
			this.AELJLBOJAIL().SetFloat("No Name", this.CenterY);
			this.MFHPKGICPIO().SetFloat("#", this.Distortion);
			this.KDMBOKLMADJ().SetFloat("_Offsets", this.Size);
			this.OIIDAKBILMI().SetVector("_TimeX", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C4C RID: 11340 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x06002C4D RID: 11341 RVA: 0x000F0098 File Offset: 0x000EE298
	private void IBJIBLHJKMG()
	{
		this.SCShader = Shader.Find("Coroutine container not configured... did you forget to call Init?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002C4E RID: 11342 RVA: 0x000F00BC File Offset: 0x000EE2BC
	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1063f)
			{
				this.HBJJOCHGOPH = 648f;
			}
			this.OPMDBHHACME().SetFloat("PublishMapButton", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("Joystick", this.CenterX);
			this.EOCCJGIGEGJ().SetFloat(" #", this.CenterY);
			this.KLKILLCHJHO().SetFloat("_BlurCoe", this.Distortion);
			this.OPMDBHHACME().SetFloat("Left", this.Size);
			this.AELJLBOJAIL().SetVector("AddEnvironmentSprite", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C4F RID: 11343 RVA: 0x000F01B4 File Offset: 0x000EE3B4
	private void OIKAPFGPLML(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1812f)
			{
				this.HBJJOCHGOPH = 977f;
			}
			this.OIIDAKBILMI().SetFloat("offsets", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("/icon", this.CenterX);
			this.MFHPKGICPIO().SetFloat("_AOTex", this.CenterY);
			this.OPMDBHHACME().SetFloat("_Value3", this.Distortion);
			this.AELJLBOJAIL().SetFloat("_Amount", this.Size);
			this.DKKBFFHBHJE().SetVector("EventData0DropDownList", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JDMJJGEHMJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C50 RID: 11344 RVA: 0x000F02AC File Offset: 0x000EE4AC
	private void IBBFFKEAOCE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 860f)
			{
				this.HBJJOCHGOPH = 703f;
			}
			this.HNFFHCLNBDN().SetFloat("Jit ", this.HBJJOCHGOPH);
			this.MPENCEIGLEH().SetFloat("Received your NickName from server. Updating local value to: {0}", this.CenterX);
			this.OIIDAKBILMI().SetFloat("CountEventsGoal", this.CenterY);
			this.PDEAHJPOMEF().SetFloat(": ", this.Distortion);
			this.AELJLBOJAIL().SetFloat("Save level before uploading?", this.Size);
			this.HNFFHCLNBDN().SetVector("CameraFilterPack_Blizzard1", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C51 RID: 11345 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C52 RID: 11346 RVA: 0x000F03A4 File Offset: 0x000EE5A4
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1655f)
			{
				this.HBJJOCHGOPH = 1458f;
			}
			this.KBOPGONOCNP().SetFloat("_ExtraLight", this.HBJJOCHGOPH);
			this.JDMJJGEHMJO().SetFloat("settings.shaders", this.CenterX);
			this.OPMDBHHACME().SetFloat("\n", this.CenterY);
			this.IKAEIOAHPKI().SetFloat("CameraFilterPack/TV_WideScreenHorizontal", this.Distortion);
			this.MPENCEIGLEH().SetFloat("float,0", this.Size);
			this.IGKFMCPDNOI().SetVector("SpectateButton", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C53 RID: 11347 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x06002C54 RID: 11348 RVA: 0x000F049C File Offset: 0x000EE69C
	private void KHIGHFJKPFG()
	{
		this.SCShader = Shader.Find("[Up]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002C55 RID: 11349 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void GNPDGBNDCPL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C56 RID: 11350 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void ANDELGODEOC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C57 RID: 11351 RVA: 0x0002523B File Offset: 0x0002343B
	private void POEMOLBJDLG()
	{
	}

	// Token: 0x06002C58 RID: 11352 RVA: 0x000F04C0 File Offset: 0x000EE6C0
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1645f)
			{
				this.HBJJOCHGOPH = 1889f;
			}
			this.LMLENGFLEBD().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.OPMDBHHACME().SetFloat("GroupNameText", this.CenterX);
			this.ACHNOHCLGOO().SetFloat("\n", this.CenterY);
			this.NBPKMLMCHFN.SetFloat("_MainTex2", this.Distortion);
			this.FAIFBBGFAIB().SetFloat("76561198041679481", this.Size);
			this.IKAEIOAHPKI().SetVector("#exit", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C59 RID: 11353 RVA: 0x0002523B File Offset: 0x0002343B
	private void EDDPLJGKLKJ()
	{
	}

	// Token: 0x06002C5A RID: 11354 RVA: 0x000F05B8 File Offset: 0x000EE7B8
	private void MMPHNFPPEHO()
	{
		this.SCShader = Shader.Find("Texture2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002C5B RID: 11355 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJNJIHCLODK()
	{
	}

	// Token: 0x06002C5C RID: 11356 RVA: 0x000F05DC File Offset: 0x000EE7DC
	private void PODKOCOPGLC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1216f)
			{
				this.HBJJOCHGOPH = 1802f;
			}
			this.OPMDBHHACME().SetFloat("_BlurVector", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("editorVolume", this.CenterX);
			this.AELJLBOJAIL().SetFloat("Testing, the group has toggled [", this.CenterY);
			this.JDMJJGEHMJO().SetFloat("time", this.Distortion);
			this.JDMJJGEHMJO().SetFloat("/", this.Size);
			this.IKAEIOAHPKI().SetVector("_HdrParams", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OPMDBHHACME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C5D RID: 11357 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void EDCMIPNCPLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C5E RID: 11358 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C5F RID: 11359 RVA: 0x000F06D4 File Offset: 0x000EE8D4
	private void HPFIHLMKIPF()
	{
		this.SCShader = Shader.Find("#forever");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002C60 RID: 11360 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C61 RID: 11361 RVA: 0x000F06F8 File Offset: 0x000EE8F8
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("_CenterY");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002C62 RID: 11362 RVA: 0x000F071C File Offset: 0x000EE91C
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002C63 RID: 11363 RVA: 0x000F0753 File Offset: 0x000EE953
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002C64 RID: 11364 RVA: 0x000F078A File Offset: 0x000EE98A
	private Material HKIMAANBGMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002C65 RID: 11365 RVA: 0x000F07C4 File Offset: 0x000EE9C4
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 421f)
			{
				this.HBJJOCHGOPH = 1074f;
			}
			this.KGOLDDBHIFN().SetFloat("{\"items\":", this.HBJJOCHGOPH);
			this.JDMJJGEHMJO().SetFloat(" ", this.CenterX);
			this.OPMDBHHACME().SetFloat("OK", this.CenterY);
			this.KDMBOKLMADJ().SetFloat(".a", this.Distortion);
			this.IGKFMCPDNOI().SetFloat("Can't connect: ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", this.Size);
			this.OPMDBHHACME().SetVector("ticket", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C66 RID: 11366 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x06002C67 RID: 11367 RVA: 0x000F08BC File Offset: 0x000EEABC
	private void POENGNEMHJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1073f)
			{
				this.HBJJOCHGOPH = 1787f;
			}
			this.EOCCJGIGEGJ().SetFloat("_Bloom5", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("maps.", this.CenterX);
			this.KGOLDDBHIFN().SetFloat("_Value2", this.CenterY);
			this.OIIDAKBILMI().SetFloat("UI Extensions/UILinearDodge", this.Distortion);
			this.OIIDAKBILMI().SetFloat("_Offsets", this.Size);
			this.IGKFMCPDNOI().SetVector("_Value2", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MPENCEIGLEH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C68 RID: 11368 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x06002C69 RID: 11369 RVA: 0x000F09B4 File Offset: 0x000EEBB4
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 231f)
			{
				this.HBJJOCHGOPH = 1196f;
			}
			this.IGKFMCPDNOI().SetFloat("CameraFilterPack/TV_Tiles", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("_Distance", this.CenterX);
			this.FKEOGPDLBDD().SetFloat("Vertical", this.CenterY);
			this.KLKILLCHJHO().SetFloat("_ScreenResolution", this.Distortion);
			this.FAIFBBGFAIB().SetFloat("_ScreenResolution", this.Size);
			this.OLHDPICFBOF().SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C6A RID: 11370 RVA: 0x000F0AAC File Offset: 0x000EECAC
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1347f)
			{
				this.HBJJOCHGOPH = 1531f;
			}
			this.AELJLBOJAIL().SetFloat("z", this.HBJJOCHGOPH);
			this.KDMBOKLMADJ().SetFloat("SetBGColor", this.CenterX);
			this.OLHDPICFBOF().SetFloat("settings.hideui", this.CenterY);
			this.ALABBJPHCNG().SetFloat("CameraFilterPack/Blur_Regular", this.Distortion);
			this.EOCCJGIGEGJ().SetFloat("SpeedSlider", this.Size);
			this.HEHKGPKLAKK().SetVector("CheckCombo", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C6B RID: 11371 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void OGLCKDAHOCG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C6C RID: 11372 RVA: 0x000F0BA4 File Offset: 0x000EEDA4
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002C6D RID: 11373 RVA: 0x000F0BDC File Offset: 0x000EEDDC
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1198f)
			{
				this.HBJJOCHGOPH = 209f;
			}
			this.OIIDAKBILMI().SetFloat("CameraFilterPack/TV_ARCADE_2", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("note.2", this.CenterX);
			this.LPCHMEKDCHI().SetFloat("_FixDistance", this.CenterY);
			this.ACHNOHCLGOO().SetFloat("BadgeText", this.Distortion);
			this.PDEAHJPOMEF().SetFloat("CameraFilterPack/Atmosphere_Rain_Pro_3D", this.Size);
			this.FKEOGPDLBDD().SetVector(" cannot be used as a 3D LUT.", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C6E RID: 11374 RVA: 0x000F0CD4 File Offset: 0x000EEED4
	private void KPOCGNOKNOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1634f)
			{
				this.HBJJOCHGOPH = 1284f;
			}
			this.FEAEGGCNIAA().SetFloat("player.blackwhite", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("_Value13", this.CenterX);
			this.FEAEGGCNIAA().SetFloat("[", this.CenterY);
			this.LPCHMEKDCHI().SetFloat(".highscore", this.Distortion);
			this.MFHPKGICPIO().SetFloat("#reward: ", this.Size);
			this.OLHDPICFBOF().SetVector("settings_bindings_controller_type", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MPENCEIGLEH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002C6F RID: 11375 RVA: 0x000F0DCC File Offset: 0x000EEFCC
	private void HAIAHJPCPAG()
	{
		this.SCShader = Shader.Find("[EditorEvent] Exception: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002C70 RID: 11376 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002C71 RID: 11377 RVA: 0x000F0DF0 File Offset: 0x000EEFF0
	private Material KLKILLCHJHO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002C72 RID: 11378 RVA: 0x000F0E27 File Offset: 0x000EF027
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002C73 RID: 11379 RVA: 0x000EDFF0 File Offset: 0x000EC1F0
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0400052F RID: 1327
	public Shader SCShader;

	// Token: 0x04000530 RID: 1328
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000531 RID: 1329
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000532 RID: 1330
	private Material BJFKDHHMLJH;

	// Token: 0x04000533 RID: 1331
	[Range(-2f, 2f)]
	public float CenterX = 0.5f;

	// Token: 0x04000534 RID: 1332
	[Range(-2f, 2f)]
	public float CenterY = 0.5f;

	// Token: 0x04000535 RID: 1333
	[Range(-3.14f, 3.14f)]
	public float Distortion = 0.5f;

	// Token: 0x04000536 RID: 1334
	[Range(-2f, 2f)]
	public float Size = 0.25f;
}
