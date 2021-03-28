using System;
using UnityEngine;

// Token: 0x02000063 RID: 99
[AddComponentMenu("Camera Filter Pack/Blur/Noise")]
[ExecuteInEditMode]
public class CameraFilterPack_Blur_Noise : MonoBehaviour
{
	// Token: 0x06001B77 RID: 7031 RVA: 0x000AA450 File Offset: 0x000A8650
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1320f)
			{
				this.HBJJOCHGOPH = 480f;
			}
			this.LDNADDJMIPK().SetFloat("move", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("mapselector.filter.subscribedonly", (float)this.Level);
			this.NBPKMLMCHFN.SetVector("PopulateMapsList", this.Distance);
			this.NBPKMLMCHFN.SetVector("_RampOffset", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 412f, 1211f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B78 RID: 7032 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06001B79 RID: 7033 RVA: 0x000AA52C File Offset: 0x000A872C
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1301f)
			{
				this.HBJJOCHGOPH = 1609f;
			}
			this.KGOLDDBHIFN().SetFloat("_Bullet_7", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("YES", (float)this.Level);
			this.PDEAHJPOMEF().SetVector("_BlurParams", this.Distance);
			this.ACHNOHCLGOO().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 575f, 213f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B7A RID: 7034 RVA: 0x000AA605 File Offset: 0x000A8805
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B7B RID: 7035 RVA: 0x000AA63C File Offset: 0x000A883C
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001B7C RID: 7036 RVA: 0x000AA63C File Offset: 0x000A883C
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001B7D RID: 7037 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001B7E RID: 7038 RVA: 0x000AA65C File Offset: 0x000A885C
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
			this.NBPKMLMCHFN.SetFloat("_Level", (float)this.Level);
			this.NBPKMLMCHFN.SetVector("_Distance", this.Distance);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B7F RID: 7039 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06001B80 RID: 7040 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06001B81 RID: 7041 RVA: 0x000AA735 File Offset: 0x000A8935
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-126);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x17000049 RID: 73
	// (get) Token: 0x06001B82 RID: 7042 RVA: 0x000AA76C File Offset: 0x000A896C
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

	// Token: 0x06001B83 RID: 7043 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06001B84 RID: 7044 RVA: 0x000AA7A4 File Offset: 0x000A89A4
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1714f)
			{
				this.HBJJOCHGOPH = 1497f;
			}
			this.KGOLDDBHIFN().SetFloat("Submit", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Using constructor for new PingNativeStatic()", (float)this.Level);
			this.ACHNOHCLGOO().SetVector("_ScreenResolution", this.Distance);
			this.KGOLDDBHIFN().SetVector("getbool", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1866f, 1403f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001B85 RID: 7045 RVA: 0x000AA87D File Offset: 0x000A8A7D
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B86 RID: 7046 RVA: 0x000AA8B4 File Offset: 0x000A8AB4
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blur_Noise");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001B87 RID: 7047 RVA: 0x000AA8D8 File Offset: 0x000A8AD8
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("_Noise");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001B88 RID: 7048 RVA: 0x000AA63C File Offset: 0x000A883C
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001B89 RID: 7049 RVA: 0x000AA8FC File Offset: 0x000A8AFC
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("Tab2Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001B8A RID: 7050 RVA: 0x000AA920 File Offset: 0x000A8B20
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001B8B RID: 7051 RVA: 0x000AA63C File Offset: 0x000A883C
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040003CD RID: 973
	public Shader SCShader;

	// Token: 0x040003CE RID: 974
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040003CF RID: 975
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040003D0 RID: 976
	private Material BJFKDHHMLJH;

	// Token: 0x040003D1 RID: 977
	[Range(2f, 16f)]
	public int Level = 4;

	// Token: 0x040003D2 RID: 978
	public Vector2 Distance = new Vector2(30f, 0f);
}
