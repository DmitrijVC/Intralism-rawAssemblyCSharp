using System;
using UnityEngine;

// Token: 0x0200007F RID: 127
[AddComponentMenu("Camera Filter Pack/Colors/HUE_Rotate")]
[ExecuteInEditMode]
public class CameraFilterPack_Colors_HUE_Rotate : MonoBehaviour
{
	// Token: 0x060023E4 RID: 9188 RVA: 0x000CF349 File Offset: 0x000CD549
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-116);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060023E5 RID: 9189 RVA: 0x000CF380 File Offset: 0x000CD580
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 766f)
			{
				this.HBJJOCHGOPH = 1721f;
			}
			this.IIBLJCKLGFG().SetFloat("_SecondTex", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("USE_DIAG_SEARCH", this.Speed);
			this.OIMMPLPBLBK().SetVector("MenuScene", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000064 RID: 100
	// (get) Token: 0x060023E6 RID: 9190 RVA: 0x000CF436 File Offset: 0x000CD636
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

	// Token: 0x060023E7 RID: 9191 RVA: 0x000CF46D File Offset: 0x000CD66D
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060023E8 RID: 9192 RVA: 0x000CF4A4 File Offset: 0x000CD6A4
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060023E9 RID: 9193 RVA: 0x000CF4C8 File Offset: 0x000CD6C8
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060023EB RID: 9195 RVA: 0x000CF51D File Offset: 0x000CD71D
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Colors_HUE_Rotate");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060023EC RID: 9196 RVA: 0x000CF541 File Offset: 0x000CD741
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("SetSatelliteRotationSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060023ED RID: 9197 RVA: 0x000CF565 File Offset: 0x000CD765
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060023EE RID: 9198 RVA: 0x000CF565 File Offset: 0x000CD765
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060023EF RID: 9199 RVA: 0x000CF565 File Offset: 0x000CD765
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060023F0 RID: 9200 RVA: 0x000CF584 File Offset: 0x000CD784
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
			this.NBPKMLMCHFN.SetFloat("_Speed", this.Speed);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060023F1 RID: 9201 RVA: 0x000CF565 File Offset: 0x000CD765
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060023F2 RID: 9202 RVA: 0x000CF63A File Offset: 0x000CD83A
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060023F3 RID: 9203 RVA: 0x000CF565 File Offset: 0x000CD765
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060023F4 RID: 9204 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x060023F5 RID: 9205 RVA: 0x000CF674 File Offset: 0x000CD874
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 83f)
			{
				this.HBJJOCHGOPH = 642f;
			}
			this.PDEAHJPOMEF().SetFloat("#", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("RoomPlayersCountText", this.Speed);
			this.HNICHJCGJOC().SetVector("_Val2", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060023F6 RID: 9206 RVA: 0x000CF72A File Offset: 0x000CD92A
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060023F7 RID: 9207 RVA: 0x000CF761 File Offset: 0x000CD961
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060023F8 RID: 9208 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x060023F9 RID: 9209 RVA: 0x000CF565 File Offset: 0x000CD765
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060023FA RID: 9210 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x060023FB RID: 9211 RVA: 0x000CF565 File Offset: 0x000CD765
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060023FC RID: 9212 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x060023FD RID: 9213 RVA: 0x000CF565 File Offset: 0x000CD765
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060023FE RID: 9214 RVA: 0x000CF798 File Offset: 0x000CD998
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 121f)
			{
				this.HBJJOCHGOPH = 740f;
			}
			this.GCDFNHMJMIP().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Right Click", this.Speed);
			this.PDEAHJPOMEF().SetVector("907198288", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060023FF RID: 9215 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06002400 RID: 9216 RVA: 0x000CF850 File Offset: 0x000CDA50
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 532f)
			{
				this.HBJJOCHGOPH = 1264f;
			}
			this.HNICHJCGJOC().SetFloat("Exception while connecting to: ", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("_TimeX", this.Speed);
			this.GCDFNHMJMIP().SetVector("_BlurredColor", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002401 RID: 9217 RVA: 0x000CF906 File Offset: 0x000CDB06
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002402 RID: 9218 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06002403 RID: 9219 RVA: 0x000CF92A File Offset: 0x000CDB2A
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002404 RID: 9220 RVA: 0x000CF565 File Offset: 0x000CD765
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002405 RID: 9221 RVA: 0x000CF964 File Offset: 0x000CDB64
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 536f)
			{
				this.HBJJOCHGOPH = 955f;
			}
			this.DOHGBNPMBKG().SetFloat(" Gb", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("music", this.Speed);
			this.NBPKMLMCHFN.SetVector(".completed", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002406 RID: 9222 RVA: 0x000CFA1A File Offset: 0x000CDC1A
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("0.00");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x040004A4 RID: 1188
	public Shader SCShader;

	// Token: 0x040004A5 RID: 1189
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040004A6 RID: 1190
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040004A7 RID: 1191
	private Material BJFKDHHMLJH;

	// Token: 0x040004A8 RID: 1192
	[Range(1f, 20f)]
	public float Speed = 10f;
}
