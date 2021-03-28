using System;
using UnityEngine;

// Token: 0x020000A9 RID: 169
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Drawing/Manga5")]
public class CameraFilterPack_Drawing_Manga5 : MonoBehaviour
{
	// Token: 0x060032F7 RID: 13047 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060032F8 RID: 13048 RVA: 0x00109AA2 File Offset: 0x00107CA2
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060032F9 RID: 13049 RVA: 0x00109ADC File Offset: 0x00107CDC
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 121f)
			{
				this.HBJJOCHGOPH = 1513f;
			}
			this.DOHGBNPMBKG().SetFloat("%", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat(" != ", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060032FA RID: 13050 RVA: 0x00109B6C File Offset: 0x00107D6C
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
			this.NBPKMLMCHFN.SetFloat("_DotSize", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060032FB RID: 13051 RVA: 0x00109BFC File Offset: 0x00107DFC
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1418f)
			{
				this.HBJJOCHGOPH = 536f;
			}
			this.ACHNOHCLGOO().SetFloat("There was an error retrieving the NumberOfCurrentPlayers.", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat(" Message: ", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060032FC RID: 13052 RVA: 0x00109C8C File Offset: 0x00107E8C
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("_Size");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060032FD RID: 13053 RVA: 0x00109CB0 File Offset: 0x00107EB0
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060032FE RID: 13054 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x060032FF RID: 13055 RVA: 0x00109CB0 File Offset: 0x00107EB0
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003300 RID: 13056 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x06003301 RID: 13057 RVA: 0x00109CCD File Offset: 0x00107ECD
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003302 RID: 13058 RVA: 0x00109D04 File Offset: 0x00107F04
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003303 RID: 13059 RVA: 0x00109CB0 File Offset: 0x00107EB0
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003304 RID: 13060 RVA: 0x00109CB0 File Offset: 0x00107EB0
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003305 RID: 13061 RVA: 0x00109D3B File Offset: 0x00107F3B
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003306 RID: 13062 RVA: 0x00109D60 File Offset: 0x00107F60
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1689f)
			{
				this.HBJJOCHGOPH = 1666f;
			}
			this.DOHGBNPMBKG().SetFloat("clear", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("KickThePlayer", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003307 RID: 13063 RVA: 0x00109DF0 File Offset: 0x00107FF0
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 829f)
			{
				this.HBJJOCHGOPH = 636f;
			}
			this.NDMPCDHADMJ().SetFloat("wss://", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("_Radius", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003308 RID: 13064 RVA: 0x00109CB0 File Offset: 0x00107EB0
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003309 RID: 13065 RVA: 0x00109CB0 File Offset: 0x00107EB0
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600330B RID: 13067 RVA: 0x00109E9E File Offset: 0x0010809E
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600330C RID: 13068 RVA: 0x00109ED5 File Offset: 0x001080D5
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("achievements.21.progress");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600330D RID: 13069 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x0600330E RID: 13070 RVA: 0x00109EFC File Offset: 0x001080FC
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 122f)
			{
				this.HBJJOCHGOPH = 1207f;
			}
			this.DOHGBNPMBKG().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("player.playedtutorial", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600330F RID: 13071 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06003310 RID: 13072 RVA: 0x00109F8C File Offset: 0x0010818C
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 730f)
			{
				this.HBJJOCHGOPH = 1808f;
			}
			this.IGKFMCPDNOI().SetFloat("ItemsCountText", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("z", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003311 RID: 13073 RVA: 0x0010A01C File Offset: 0x0010821C
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003312 RID: 13074 RVA: 0x0010A054 File Offset: 0x00108254
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1560f)
			{
				this.HBJJOCHGOPH = 1028f;
			}
			this.DOHGBNPMBKG().SetFloat("_Value", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("DataText", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003313 RID: 13075 RVA: 0x0010A0E4 File Offset: 0x001082E4
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003314 RID: 13076 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06003315 RID: 13077 RVA: 0x0010A11C File Offset: 0x0010831C
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1193f)
			{
				this.HBJJOCHGOPH = 663f;
			}
			this.KEMAALEODNH().SetFloat("menu.enableselectormusic", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("(from resources)", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003316 RID: 13078 RVA: 0x00109CB0 File Offset: 0x00107EB0
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003317 RID: 13079 RVA: 0x0010A1AC File Offset: 0x001083AC
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003318 RID: 13080 RVA: 0x0010A1E3 File Offset: 0x001083E3
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_Manga5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003319 RID: 13081 RVA: 0x00109CB0 File Offset: 0x00107EB0
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600331A RID: 13082 RVA: 0x0010A207 File Offset: 0x00108407
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("plogs");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600331B RID: 13083 RVA: 0x0010A22B File Offset: 0x0010842B
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600331C RID: 13084 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x0600331D RID: 13085 RVA: 0x0010A262 File Offset: 0x00108462
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600331E RID: 13086 RVA: 0x0010A299 File Offset: 0x00108499
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600331F RID: 13087 RVA: 0x0010A2C0 File Offset: 0x001084C0
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1816f)
			{
				this.HBJJOCHGOPH = 1353f;
			}
			this.ACHNOHCLGOO().SetFloat("#", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("bpmgrid", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x1700008E RID: 142
	// (get) Token: 0x06003320 RID: 13088 RVA: 0x0010A350 File Offset: 0x00108550
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

	// Token: 0x040005B9 RID: 1465
	public Shader SCShader;

	// Token: 0x040005BA RID: 1466
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040005BB RID: 1467
	private Material BJFKDHHMLJH;

	// Token: 0x040005BC RID: 1468
	[Range(1f, 8f)]
	public float DotSize = 4.72f;
}
