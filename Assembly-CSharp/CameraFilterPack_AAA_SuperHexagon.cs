using System;
using UnityEngine;

// Token: 0x0200002F RID: 47
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/AAA/Super Hexagon")]
public class CameraFilterPack_AAA_SuperHexagon : MonoBehaviour
{
	// Token: 0x06000BED RID: 3053 RVA: 0x000587E8 File Offset: 0x000569E8
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1632f)
			{
				this.HBJJOCHGOPH = 1703f;
			}
			this.KGOLDDBHIFN().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("PossibleMapPointsText", this.HexaSize);
			this.NBPKMLMCHFN.SetFloat("\nCreated by Oxy949", this.center.x);
			this.NBPKMLMCHFN.SetFloat("Connected to NameServer.", this.center.y);
			this.KGOLDDBHIFN().SetFloat("(master)", this.Radius);
			this.IONHGBPGCHK().SetFloat("MessageText", this._BorderSize);
			this.KGOLDDBHIFN().SetColor("_Blue_B", this._BorderColor);
			this.IONHGBPGCHK().SetColor("ready", this._HexaColor);
			this.KGOLDDBHIFN().SetFloat("_ScreenResolution", this._AlphaHexa);
			this.KGOLDDBHIFN().SetFloat("Couldn't call DestroyAll() as only the master client is allowed to call this.", this._SpotSize);
			this.IONHGBPGCHK().SetVector(".", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1426f, 1409f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BEE RID: 3054 RVA: 0x0005895F File Offset: 0x00056B5F
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BEF RID: 3055 RVA: 0x0005895F File Offset: 0x00056B5F
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BF0 RID: 3056 RVA: 0x0005897C File Offset: 0x00056B7C
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 73f)
			{
				this.HBJJOCHGOPH = 667f;
			}
			this.IONHGBPGCHK().SetFloat("SelectorMusicToggle", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("GlassDistortion", this.HexaSize);
			this.KGOLDDBHIFN().SetFloat(" not exist", this.center.x);
			this.KGOLDDBHIFN().SetFloat("Mouse1", this.center.y);
			this.IONHGBPGCHK().SetFloat("SetEnvSpriteColor", this.Radius);
			this.KGOLDDBHIFN().SetFloat("2", this._BorderSize);
			this.IONHGBPGCHK().SetColor("Sets the boolean value of the Auto Focus Input Field property.", this._BorderColor);
			this.KGOLDDBHIFN().SetColor("ConnectToRegion: ", this._HexaColor);
			this.NBPKMLMCHFN.SetFloat("ReconnectToMaster() with AuthValues == null is not correct!", this._AlphaHexa);
			this.KGOLDDBHIFN().SetFloat("GetLive", this._SpotSize);
			this.KGOLDDBHIFN().SetVector("_Glitch", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1444f, 103f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x00058AF3 File Offset: 0x00056CF3
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

	// Token: 0x06000BF2 RID: 3058 RVA: 0x00058B2C File Offset: 0x00056D2C
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 145f)
			{
				this.HBJJOCHGOPH = 1275f;
			}
			this.KGOLDDBHIFN().SetFloat("#{0:X2}{1:X2}{2:X2}", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("CameraFilterPack/Distortion_FishEye", this.HexaSize);
			this.NBPKMLMCHFN.SetFloat("_EmissionColor", this.center.x);
			this.IONHGBPGCHK().SetFloat("_FixDistance", this.center.y);
			this.NBPKMLMCHFN.SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this.Radius);
			this.IONHGBPGCHK().SetFloat("_HexaColor", this._BorderSize);
			this.IONHGBPGCHK().SetColor("_ScreenResolution", this._BorderColor);
			this.KGOLDDBHIFN().SetColor("_Value3", this._HexaColor);
			this.KGOLDDBHIFN().SetFloat("_Parameter", this._AlphaHexa);
			this.IONHGBPGCHK().SetFloat("_Offsets", this._SpotSize);
			this.KGOLDDBHIFN().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 354f, 873f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BF3 RID: 3059 RVA: 0x00058CA3 File Offset: 0x00056EA3
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/AAA_Super_Hexagon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000BF4 RID: 3060 RVA: 0x00058CC7 File Offset: 0x00056EC7
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-116);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BF5 RID: 3061 RVA: 0x00058D00 File Offset: 0x00056F00
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.HexaSize);
			this.NBPKMLMCHFN.SetFloat("_PositionX", this.center.x);
			this.NBPKMLMCHFN.SetFloat("_PositionY", this.center.y);
			this.NBPKMLMCHFN.SetFloat("_Radius", this.Radius);
			this.NBPKMLMCHFN.SetFloat("_BorderSize", this._BorderSize);
			this.NBPKMLMCHFN.SetColor("_BorderColor", this._BorderColor);
			this.NBPKMLMCHFN.SetColor("_HexaColor", this._HexaColor);
			this.NBPKMLMCHFN.SetFloat("_AlphaHexa", this._AlphaHexa);
			this.NBPKMLMCHFN.SetFloat("_SpotSize", this._SpotSize);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BF6 RID: 3062 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06000BF7 RID: 3063 RVA: 0x00058E77 File Offset: 0x00057077
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BF8 RID: 3064 RVA: 0x00058EB0 File Offset: 0x000570B0
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 617f)
			{
				this.HBJJOCHGOPH = 1924f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("LeaderboardsButton", this.HexaSize);
			this.IONHGBPGCHK().SetFloat("Set Object Scale", this.center.x);
			this.NBPKMLMCHFN.SetFloat("#FFFFFFFF", this.center.y);
			this.IONHGBPGCHK().SetFloat("From {0} at Index {1} \n", this.Radius);
			this.NBPKMLMCHFN.SetFloat("_Value2", this._BorderSize);
			this.KGOLDDBHIFN().SetColor("_Smooth", this._BorderColor);
			this.KGOLDDBHIFN().SetColor(" argument(s): ", this._HexaColor);
			this.IONHGBPGCHK().SetFloat("id", this._AlphaHexa);
			this.KGOLDDBHIFN().SetFloat("There are {0} reported logs.", this._SpotSize);
			this.IONHGBPGCHK().SetVector("Object ID. Case-Sensitive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1678f, 431f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BF9 RID: 3065 RVA: 0x0005895F File Offset: 0x00056B5F
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BFA RID: 3066 RVA: 0x0005895F File Offset: 0x00056B5F
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BFB RID: 3067 RVA: 0x00059028 File Offset: 0x00057228
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 8f)
			{
				this.HBJJOCHGOPH = 1379f;
			}
			this.NBPKMLMCHFN.SetFloat("HPText", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("_Value5", this.HexaSize);
			this.IONHGBPGCHK().SetFloat("}", this.center.x);
			this.KGOLDDBHIFN().SetFloat("CameraFilterPack/Glow_Glow_Color", this.center.y);
			this.NBPKMLMCHFN.SetFloat("_Params", this.Radius);
			this.NBPKMLMCHFN.SetFloat("#scoresubmitionfailed: ", this._BorderSize);
			this.KGOLDDBHIFN().SetColor("[SteamManager] Connecting to server", this._BorderColor);
			this.KGOLDDBHIFN().SetColor("_MainTex2", this._HexaColor);
			this.KGOLDDBHIFN().SetFloat("Jan", this._AlphaHexa);
			this.IONHGBPGCHK().SetFloat("CameraFilterPack/Drawing_BluePrint", this._SpotSize);
			this.KGOLDDBHIFN().SetVector("cancel", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1801f, 1761f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BFD RID: 3069 RVA: 0x0005895F File Offset: 0x00056B5F
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BFE RID: 3070 RVA: 0x0005895F File Offset: 0x00056B5F
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040001CE RID: 462
	public Shader SCShader;

	// Token: 0x040001CF RID: 463
	[Range(0f, 1f)]
	public float _AlphaHexa = 1f;

	// Token: 0x040001D0 RID: 464
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040001D1 RID: 465
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040001D2 RID: 466
	private Material BJFKDHHMLJH;

	// Token: 0x040001D3 RID: 467
	[Range(0.2f, 10f)]
	public float HexaSize = 2.5f;

	// Token: 0x040001D4 RID: 468
	public float _BorderSize = 1f;

	// Token: 0x040001D5 RID: 469
	public Color _BorderColor = new Color(0.75f, 0.75f, 1f, 1f);

	// Token: 0x040001D6 RID: 470
	public Color _HexaColor = new Color(0f, 0.5f, 1f, 1f);

	// Token: 0x040001D7 RID: 471
	public float _SpotSize = 2.5f;

	// Token: 0x040001D8 RID: 472
	public Vector2 center = new Vector2(0.5f, 0.5f);

	// Token: 0x040001D9 RID: 473
	public float Radius = 0.25f;
}
