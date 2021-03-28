using System;
using UnityEngine;

// Token: 0x02000072 RID: 114
[AddComponentMenu("Camera Filter Pack/Colors/Noise")]
[ExecuteInEditMode]
public class CameraFilterPack_Color_Noise : MonoBehaviour
{
	// Token: 0x06002047 RID: 8263 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06002048 RID: 8264 RVA: 0x000BCFF0 File Offset: 0x000BB1F0
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
			this.NBPKMLMCHFN.SetFloat("_Noise", this.Noise);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002049 RID: 8265 RVA: 0x000BD0AD File Offset: 0x000BB2AD
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600204A RID: 8266 RVA: 0x000BD0E4 File Offset: 0x000BB2E4
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1213f)
			{
				this.HBJJOCHGOPH = 89f;
			}
			this.JFDGLLEOPGB().SetFloat(".lastCheckpoint.comboScore", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("Gameplay/Segment-[PowerUp]", this.Noise);
			this.IIJMIPBMMBF().SetVector("mapselector.filter.subscribedonly", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 893f, 744f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600204B RID: 8267 RVA: 0x000BD1A1 File Offset: 0x000BB3A1
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600204D RID: 8269 RVA: 0x000BD1DC File Offset: 0x000BB3DC
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600204E RID: 8270 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x0600204F RID: 8271 RVA: 0x000BD1A1 File Offset: 0x000BB3A1
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002050 RID: 8272 RVA: 0x000BD1A1 File Offset: 0x000BB3A1
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002051 RID: 8273 RVA: 0x000BD200 File Offset: 0x000BB400
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002052 RID: 8274 RVA: 0x000BD1A1 File Offset: 0x000BB3A1
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002053 RID: 8275 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06002054 RID: 8276 RVA: 0x000BD237 File Offset: 0x000BB437
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002055 RID: 8277 RVA: 0x000BD25B File Offset: 0x000BB45B
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002056 RID: 8278 RVA: 0x000BD292 File Offset: 0x000BB492
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("ReJoinRoom failed due to offline mode.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002057 RID: 8279 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06002058 RID: 8280 RVA: 0x000BD2B8 File Offset: 0x000BB4B8
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1707f)
			{
				this.HBJJOCHGOPH = 953f;
			}
			this.EFDEIFCDAFG().SetFloat(".lastCheckpoint.powerupsScore", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("EditMenu", this.Noise);
			this.KEMAALEODNH().SetVector("_SpotSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1186f, 1345f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002059 RID: 8281 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x0600205A RID: 8282 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x0600205B RID: 8283 RVA: 0x000BD375 File Offset: 0x000BB575
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600205C RID: 8284 RVA: 0x000BD1A1 File Offset: 0x000BB3A1
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600205D RID: 8285 RVA: 0x000BD3AC File Offset: 0x000BB5AC
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Color_Noise");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600205E RID: 8286 RVA: 0x000BD3D0 File Offset: 0x000BB5D0
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600205F RID: 8287 RVA: 0x000BD407 File Offset: 0x000BB607
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002060 RID: 8288 RVA: 0x000BD43E File Offset: 0x000BB63E
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002061 RID: 8289 RVA: 0x000BD475 File Offset: 0x000BB675
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("skin.hit_wrong");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002062 RID: 8290 RVA: 0x000BD499 File Offset: 0x000BB699
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002063 RID: 8291 RVA: 0x000BD4D0 File Offset: 0x000BB6D0
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002064 RID: 8292 RVA: 0x000BD507 File Offset: 0x000BB707
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("_RgbTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x17000058 RID: 88
	// (get) Token: 0x06002065 RID: 8293 RVA: 0x000BD52B File Offset: 0x000BB72B
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

	// Token: 0x06002066 RID: 8294 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06002067 RID: 8295 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06002068 RID: 8296 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06002069 RID: 8297 RVA: 0x000BD562 File Offset: 0x000BB762
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600206A RID: 8298 RVA: 0x000BD588 File Offset: 0x000BB788
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1192f)
			{
				this.HBJJOCHGOPH = 340f;
			}
			this.OIMMPLPBLBK().SetFloat("[EditorEvent] Exception: ", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("setfloat", this.Noise);
			this.PDEAHJPOMEF().SetVector("PlayMusic", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1677f, 434f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600206B RID: 8299 RVA: 0x000BD645 File Offset: 0x000BB845
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_Comics");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600206C RID: 8300 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x0600206D RID: 8301 RVA: 0x000BD669 File Offset: 0x000BB869
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600206E RID: 8302 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x0600206F RID: 8303 RVA: 0x000BD1A1 File Offset: 0x000BB3A1
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002070 RID: 8304 RVA: 0x000BD1A1 File Offset: 0x000BB3A1
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x04000433 RID: 1075
	public Shader SCShader;

	// Token: 0x04000434 RID: 1076
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000435 RID: 1077
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000436 RID: 1078
	private Material BJFKDHHMLJH;

	// Token: 0x04000437 RID: 1079
	[Range(0f, 1f)]
	public float Noise = 0.235f;
}
