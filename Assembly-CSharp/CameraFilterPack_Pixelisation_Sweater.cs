using System;
using UnityEngine;

// Token: 0x02000106 RID: 262
[AddComponentMenu("Camera Filter Pack/Pixelisation/Pixelisation_Sweater")]
[ExecuteInEditMode]
public class CameraFilterPack_Pixelisation_Sweater : MonoBehaviour
{
	// Token: 0x060051CC RID: 20940 RVA: 0x0019709D File Offset: 0x0019529D
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060051CD RID: 20941 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x060051CE RID: 20942 RVA: 0x0019709D File Offset: 0x0019529D
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060051CF RID: 20943 RVA: 0x001970BA File Offset: 0x001952BA
	private void JONGNKNLLND()
	{
		this.FPHEBLMINDA = (Resources.Load("SettingsCanvas") as Texture2D);
		this.SCShader = Shader.Find("Unknown player asked for PickupItems");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060051D0 RID: 20944 RVA: 0x001970F3 File Offset: 0x001952F3
	private void FIKFJDFELIP()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value3") as Texture2D);
		this.SCShader = Shader.Find("FinalScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060051D1 RID: 20945 RVA: 0x0019712C File Offset: 0x0019532C
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1350f)
			{
				this.HBJJOCHGOPH = 1610f;
			}
			this.KAFBNOBOIAJ().SetFloat(".png", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("inventory.lastitemscount", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.SweaterSize);
			this.OIMMPLPBLBK().SetFloat("time", this._Intensity);
			this.OIMMPLPBLBK().SetTexture("Left", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060051D2 RID: 20946 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x060051D3 RID: 20947 RVA: 0x00197200 File Offset: 0x00195400
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1395f)
			{
				this.HBJJOCHGOPH = 1445f;
			}
			this.GCDFNHMJMIP().SetFloat(". The group number should be at least 1.", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("challenges.", this.Fade);
			this.LPDOGGFOBDH().SetFloat("22x3", this.SweaterSize);
			this.NBPKMLMCHFN.SetFloat("_Value2", this._Intensity);
			this.LPDOGGFOBDH().SetTexture("CameraFilterPack/Drawing_Laplacian", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060051D4 RID: 20948 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x060051D5 RID: 20949 RVA: 0x0019709D File Offset: 0x0019529D
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060051D6 RID: 20950 RVA: 0x001972D2 File Offset: 0x001954D2
	private void MJEFMIPLFAB()
	{
		this.FPHEBLMINDA = (Resources.Load("x") as Texture2D);
		this.SCShader = Shader.Find("Bad parameters for reset! Use \"reset <challengeid>\"");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060051D7 RID: 20951 RVA: 0x0019709D File Offset: 0x0019529D
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060051D8 RID: 20952 RVA: 0x0019730C File Offset: 0x0019550C
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 709f)
			{
				this.HBJJOCHGOPH = 889f;
			}
			this.DBOLLHHMKKN().SetFloat("_TapMedium", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("_Intensity", this.Fade);
			this.BFGNMFCNDBC().SetFloat(".lastCheckpoint.powerupsScore", this.SweaterSize);
			this.LPDOGGFOBDH().SetFloat("elapsed: {0:0.000}", this._Intensity);
			this.LONNIJMNKFB().SetTexture("Received RPC: ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060051D9 RID: 20953 RVA: 0x001973DE File Offset: 0x001955DE
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060051DA RID: 20954 RVA: 0x00197415 File Offset: 0x00195615
	private void NNFMIAFHMJM()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value2") as Texture2D);
		this.SCShader = Shader.Find("_BlurCoe");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060051DB RID: 20955 RVA: 0x0019709D File Offset: 0x0019529D
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060051DC RID: 20956 RVA: 0x0019744E File Offset: 0x0019564E
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-86);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060051DD RID: 20957 RVA: 0x00197485 File Offset: 0x00195685
	private void CHOPDIGHJNH()
	{
		this.FPHEBLMINDA = (Resources.Load("[Up]") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Blur_Noise");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060051DE RID: 20958 RVA: 0x001974C0 File Offset: 0x001956C0
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1283f)
			{
				this.HBJJOCHGOPH = 117f;
			}
			this.LPDOGGFOBDH().SetFloat("Room: '{0}' {1},{2} {4}/{3} players.", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack_Paper3", this.Fade);
			this.EMDFHOKEGNG().SetFloat("LastHighScoreText", this.SweaterSize);
			this.DBOLLHHMKKN().SetFloat(":</b> ", this._Intensity);
			this.NBPKMLMCHFN.SetTexture("_Value", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060051DF RID: 20959 RVA: 0x0019709D File Offset: 0x0019529D
	private void IABLKKAALGI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060051E0 RID: 20960 RVA: 0x00197592 File Offset: 0x00195792
	private void FBPHNEJBDJN()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/3D_Myst") as Texture2D);
		this.SCShader = Shader.Find("Scrollbar");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060051E1 RID: 20961 RVA: 0x001975CB File Offset: 0x001957CB
	private void JKFDDNMPOJH()
	{
		this.FPHEBLMINDA = (Resources.Load("settings.disablestoryboard") as Texture2D);
		this.SCShader = Shader.Find("Sent count: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060051E2 RID: 20962 RVA: 0x00197604 File Offset: 0x00195804
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 647f)
			{
				this.HBJJOCHGOPH = 1681f;
			}
			this.OIMMPLPBLBK().SetFloat("Set Particles Color", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("_Bullet_5", this.Fade);
			this.NFMGLIKNOOC().SetFloat("ItemNameText", this.SweaterSize);
			this.EMDFHOKEGNG().SetFloat("TwoHands", this._Intensity);
			this.BFGNMFCNDBC().SetTexture("OK", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060051E3 RID: 20963 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x060051E4 RID: 20964 RVA: 0x001976D6 File Offset: 0x001958D6
	private void JHANGPCOCIG()
	{
		this.FPHEBLMINDA = (Resources.Load("steamid") as Texture2D);
		this.SCShader = Shader.Find("sounds/hit_wrong");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060051E5 RID: 20965 RVA: 0x0019770F File Offset: 0x0019590F
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060051E6 RID: 20966 RVA: 0x0019709D File Offset: 0x0019529D
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060051E7 RID: 20967 RVA: 0x00197746 File Offset: 0x00195946
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060051E8 RID: 20968 RVA: 0x0019709D File Offset: 0x0019529D
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060051E9 RID: 20969 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x060051EA RID: 20970 RVA: 0x0019709D File Offset: 0x0019529D
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060051EB RID: 20971 RVA: 0x00197780 File Offset: 0x00195980
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1113f)
			{
				this.HBJJOCHGOPH = 911f;
			}
			this.OIMMPLPBLBK().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("menu.playedsolo", this.Fade);
			this.NFMGLIKNOOC().SetFloat("workshop.", this.SweaterSize);
			this.LONNIJMNKFB().SetFloat("Creating new item...", this._Intensity);
			this.NBPKMLMCHFN.SetTexture("No Dispatcher exists in the scene. Actions will not be invoked!", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060051EC RID: 20972 RVA: 0x0019709D File Offset: 0x0019529D
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060051ED RID: 20973 RVA: 0x00197852 File Offset: 0x00195A52
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060051EE RID: 20974 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x060051EF RID: 20975 RVA: 0x0019788C File Offset: 0x00195A8C
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 192f)
			{
				this.HBJJOCHGOPH = 622f;
			}
			this.LONNIJMNKFB().SetFloat("Sending RPC \"", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("NO", this.Fade);
			this.EOCCJGIGEGJ().SetFloat("</color>", this.SweaterSize);
			this.OIMMPLPBLBK().SetFloat("OpJoinRandomRoom()", this._Intensity);
			this.NFKFAAHHLLM().SetTexture("[MapsData] Bad map: ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060051F0 RID: 20976 RVA: 0x0019795E File Offset: 0x00195B5E
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060051F1 RID: 20977 RVA: 0x0019709D File Offset: 0x0019529D
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060051F2 RID: 20978 RVA: 0x00197998 File Offset: 0x00195B98
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1512f)
			{
				this.HBJJOCHGOPH = 182f;
			}
			this.DBOLLHHMKKN().SetFloat("_Value", this.HBJJOCHGOPH);
			this.GCDFNHMJMIP().SetFloat("_Bullet_3", this.Fade);
			this.KAFBNOBOIAJ().SetFloat("_Bullet_8", this.SweaterSize);
			this.NBPKMLMCHFN.SetFloat("/icon", this._Intensity);
			this.KAFBNOBOIAJ().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x170000EB RID: 235
	// (get) Token: 0x060051F3 RID: 20979 RVA: 0x00197A6A File Offset: 0x00195C6A
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

	// Token: 0x060051F4 RID: 20980 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x060051F5 RID: 20981 RVA: 0x00197AA1 File Offset: 0x00195CA1
	private void NPLCENPNJBM()
	{
		this.FPHEBLMINDA = (Resources.Load("UseScanLineSize") as Texture2D);
		this.SCShader = Shader.Find("#failed!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060051F6 RID: 20982 RVA: 0x00197ADA File Offset: 0x00195CDA
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060051F7 RID: 20983 RVA: 0x00197B14 File Offset: 0x00195D14
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1828f)
			{
				this.HBJJOCHGOPH = 1218f;
			}
			this.NFKFAAHHLLM().SetFloat("GlassAberration", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("_Distortion", this.Fade);
			this.KAFBNOBOIAJ().SetFloat("GlassAberration", this.SweaterSize);
			this.BFGNMFCNDBC().SetFloat("settings.selectormapsperpage", this._Intensity);
			this.OIMMPLPBLBK().SetTexture("y", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060051F8 RID: 20984 RVA: 0x00197BE6 File Offset: 0x00195DE6
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060051F9 RID: 20985 RVA: 0x00197C20 File Offset: 0x00195E20
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 812f)
			{
				this.HBJJOCHGOPH = 894f;
			}
			this.EMDFHOKEGNG().SetFloat("/../", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("_Value4", this.Fade);
			this.NBPKMLMCHFN.SetFloat("cmd.exe", this.SweaterSize);
			this.OIMMPLPBLBK().SetFloat("_MainTex", this._Intensity);
			this.EMDFHOKEGNG().SetTexture("GameScene", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060051FA RID: 20986 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060051FB RID: 20987 RVA: 0x0019709D File Offset: 0x0019529D
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060051FC RID: 20988 RVA: 0x0019709D File Offset: 0x0019529D
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060051FE RID: 20990 RVA: 0x0019709D File Offset: 0x0019529D
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060051FF RID: 20991 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06005200 RID: 20992 RVA: 0x00197D26 File Offset: 0x00195F26
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_Sweater") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Pixelisation_Sweater");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005201 RID: 20993 RVA: 0x00197D5F File Offset: 0x00195F5F
	private void FJNCHGLIEMA()
	{
		this.FPHEBLMINDA = (Resources.Load("AccuracyScoreText") as Texture2D);
		this.SCShader = Shader.Find("Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005202 RID: 20994 RVA: 0x00197D98 File Offset: 0x00195F98
	private void FLKEJJEGCFA()
	{
		this.FPHEBLMINDA = (Resources.Load("#getrewardnow ") as Texture2D);
		this.SCShader = Shader.Find("Up ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005203 RID: 20995 RVA: 0x00197DD4 File Offset: 0x00195FD4
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 470f)
			{
				this.HBJJOCHGOPH = 1868f;
			}
			this.CEKJODEAMGB().SetFloat("action", this.HBJJOCHGOPH);
			this.CEKJODEAMGB().SetFloat("_Blue_G", this.Fade);
			this.FLOHGDECHHH().SetFloat("{0}", this.SweaterSize);
			this.GCDFNHMJMIP().SetFloat("stats on", this._Intensity);
			this.FLOHGDECHHH().SetTexture("#yes", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005204 RID: 20996 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x06005205 RID: 20997 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06005206 RID: 20998 RVA: 0x0019709D File Offset: 0x0019529D
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005207 RID: 20999 RVA: 0x00197EA6 File Offset: 0x001960A6
	private void DLBODOFAJGM()
	{
		this.FPHEBLMINDA = (Resources.Load("HighScaleShot") as Texture2D);
		this.SCShader = Shader.Find("action");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005208 RID: 21000 RVA: 0x00197EDF File Offset: 0x001960DF
	private void PMPKMGKAAJH()
	{
		this.FPHEBLMINDA = (Resources.Load("_Glitch") as Texture2D);
		this.SCShader = Shader.Find("float,1.5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005209 RID: 21001 RVA: 0x00197F18 File Offset: 0x00196118
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1610f)
			{
				this.HBJJOCHGOPH = 200f;
			}
			this.FLOHGDECHHH().SetFloat("<b>", this.HBJJOCHGOPH);
			this.IGIAPKPKGPK().SetFloat(". Check if the server is available.", this.Fade);
			this.LPDOGGFOBDH().SetFloat("HightScoreMaxPointsText", this.SweaterSize);
			this.OIMMPLPBLBK().SetFloat("Set camera (or player) distance. Base player distance - 14", this._Intensity);
			this.NFMGLIKNOOC().SetTexture("Fade", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600520A RID: 21002 RVA: 0x00197FEA File Offset: 0x001961EA
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600520B RID: 21003 RVA: 0x00198021 File Offset: 0x00196221
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)67;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600520C RID: 21004 RVA: 0x00198058 File Offset: 0x00196258
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1037f)
			{
				this.HBJJOCHGOPH = 1276f;
			}
			this.EMDFHOKEGNG().SetFloat("_VignettingColor", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetFloat("workshop.", this.Fade);
			this.DBOLLHHMKKN().SetFloat("Chat", this.SweaterSize);
			this.KAFBNOBOIAJ().SetFloat("\" for viewID ", this._Intensity);
			this.EOCCJGIGEGJ().SetTexture("CameraFilterPack/Real_VHS", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600520D RID: 21005 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x0600520E RID: 21006 RVA: 0x0019812A File Offset: 0x0019632A
	private void HLIAEEMGBHN()
	{
		this.FPHEBLMINDA = (Resources.Load("[LevelEditorScene] Print Audio Wave: Done") as Texture2D);
		this.SCShader = Shader.Find("rd");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600520F RID: 21007 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06005210 RID: 21008 RVA: 0x00198163 File Offset: 0x00196363
	private void ANCKKLFPGDI()
	{
		this.FPHEBLMINDA = (Resources.Load("\n") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005211 RID: 21009 RVA: 0x0019819C File Offset: 0x0019639C
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 797f)
			{
				this.HBJJOCHGOPH = 753f;
			}
			this.GCDFNHMJMIP().SetFloat("CameraFilterPack/Glasses_On", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("Down", this.Fade);
			this.OIMMPLPBLBK().SetFloat("Texture2", this.SweaterSize);
			this.KAFBNOBOIAJ().SetFloat("Value", this._Intensity);
			this.BFGNMFCNDBC().SetTexture("_Skybox", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005212 RID: 21010 RVA: 0x0019709D File Offset: 0x0019529D
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005213 RID: 21011 RVA: 0x00197FEA File Offset: 0x001961EA
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005214 RID: 21012 RVA: 0x0019826E File Offset: 0x0019646E
	private void DKOPKPBLDHH()
	{
		this.FPHEBLMINDA = (Resources.Load(" - ") as Texture2D);
		this.SCShader = Shader.Find("RanksButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005215 RID: 21013 RVA: 0x001982A7 File Offset: 0x001964A7
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005216 RID: 21014 RVA: 0x001982DE File Offset: 0x001964DE
	private void ILCFPCIPENO()
	{
		this.FPHEBLMINDA = (Resources.Load("_SSRMultiplier") as Texture2D);
		this.SCShader = Shader.Find("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005217 RID: 21015 RVA: 0x00198318 File Offset: 0x00196518
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 44f)
			{
				this.HBJJOCHGOPH = 665f;
			}
			this.EOCCJGIGEGJ().SetFloat("_Value", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("SupportLogger OnJoinedRoom(", this.Fade);
			this.NFMGLIKNOOC().SetFloat("Value", this.SweaterSize);
			this.NFMGLIKNOOC().SetFloat("Can not SetMasterClient(). Not in room or in offlineMode.", this._Intensity);
			this.KAFBNOBOIAJ().SetTexture("InventoryButton", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005218 RID: 21016 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06005219 RID: 21017 RVA: 0x001983EC File Offset: 0x001965EC
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
			this.NBPKMLMCHFN.SetFloat("_Fade", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_SweaterSize", this.SweaterSize);
			this.NBPKMLMCHFN.SetFloat("_Intensity", this._Intensity);
			this.NBPKMLMCHFN.SetTexture("Texture2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600521A RID: 21018 RVA: 0x001984BE File Offset: 0x001966BE
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600521B RID: 21019 RVA: 0x001984F5 File Offset: 0x001966F5
	private void JMEOGJHCONJ()
	{
		this.FPHEBLMINDA = (Resources.Load("inventory.selected.") as Texture2D);
		this.SCShader = Shader.Find("[MapsData] Base maps loaded");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600521C RID: 21020 RVA: 0x0019852E File Offset: 0x0019672E
	private void JILOMOBDPIA()
	{
		this.FPHEBLMINDA = (Resources.Load("No info") as Texture2D);
		this.SCShader = Shader.Find("_Value5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600521D RID: 21021 RVA: 0x00198567 File Offset: 0x00196767
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-104);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600521E RID: 21022 RVA: 0x0019859E File Offset: 0x0019679E
	private void ODBNMPGBCGO()
	{
		this.FPHEBLMINDA = (Resources.Load("DisableStoryboardToggle") as Texture2D);
		this.SCShader = Shader.Find("mapselector.filter.favoriteonly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600521F RID: 21023 RVA: 0x0019709D File Offset: 0x0019529D
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005220 RID: 21024 RVA: 0x001985D8 File Offset: 0x001967D8
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1546f)
			{
				this.HBJJOCHGOPH = 269f;
			}
			this.DBOLLHHMKKN().SetFloat(".icon", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_History3LumaTex", this.Fade);
			this.NFKFAAHHLLM().SetFloat("SetSunMaxSize", this.SweaterSize);
			this.BFGNMFCNDBC().SetFloat("menu.playedsolo", this._Intensity);
			this.NFMGLIKNOOC().SetTexture(">", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0400088B RID: 2187
	public Shader SCShader;

	// Token: 0x0400088C RID: 2188
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400088D RID: 2189
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400088E RID: 2190
	private Material BJFKDHHMLJH;

	// Token: 0x0400088F RID: 2191
	[Range(16f, 128f)]
	public float SweaterSize = 64f;

	// Token: 0x04000890 RID: 2192
	[Range(0f, 2f)]
	public float _Intensity = 1.4f;

	// Token: 0x04000891 RID: 2193
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x04000892 RID: 2194
	private Texture2D FPHEBLMINDA;
}
