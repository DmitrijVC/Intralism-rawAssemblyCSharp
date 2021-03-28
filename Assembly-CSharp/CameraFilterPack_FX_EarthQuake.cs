using System;
using UnityEngine;

// Token: 0x020000C6 RID: 198
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/FX/Earth Quake")]
public class CameraFilterPack_FX_EarthQuake : MonoBehaviour
{
	// Token: 0x06003BEC RID: 15340 RVA: 0x0012E567 File Offset: 0x0012C767
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("Encryption wasn't established: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003BED RID: 15341 RVA: 0x0012E58B File Offset: 0x0012C78B
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003BEE RID: 15342 RVA: 0x0012E5A8 File Offset: 0x0012C7A8
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 790f)
			{
				this.HBJJOCHGOPH = 185f;
			}
			this.OIMMPLPBLBK().SetFloat("masterSteamID", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("workshop.", this.Speed);
			this.OIMMPLPBLBK().SetFloat("custom", this.X);
			this.OIMMPLPBLBK().SetFloat("[Down]", this.Y);
			this.KAFBNOBOIAJ().SetFloat("Player", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector(". Current number of cells is ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1778f, 567f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x170000AC RID: 172
	// (get) Token: 0x06003BEF RID: 15343 RVA: 0x0012E6A7 File Offset: 0x0012C8A7
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

	// Token: 0x06003BF0 RID: 15344 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003BF1 RID: 15345 RVA: 0x0012E58B File Offset: 0x0012C78B
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003BF2 RID: 15346 RVA: 0x0012E6E0 File Offset: 0x0012C8E0
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1250f)
			{
				this.HBJJOCHGOPH = 761f;
			}
			this.NBPKMLMCHFN.SetFloat("0.00", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat(" GameServer:", this.Speed);
			this.OIMMPLPBLBK().SetFloat("[DiscordController] Join request {0}#{1}: {2}", this.X);
			this.NBPKMLMCHFN.SetFloat("workshop.", this.Y);
			this.KAFBNOBOIAJ().SetFloat("_Near", this.CCIENBFIKKH);
			this.KAFBNOBOIAJ().SetVector("#ok", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 512f, 251f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003BF3 RID: 15347 RVA: 0x0012E58B File Offset: 0x0012C78B
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003BF4 RID: 15348 RVA: 0x0012E58B File Offset: 0x0012C78B
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003BF5 RID: 15349 RVA: 0x0012E7DF File Offset: 0x0012C9DF
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003BF7 RID: 15351 RVA: 0x0012E855 File Offset: 0x0012CA55
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003BF8 RID: 15352 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06003BF9 RID: 15353 RVA: 0x0012E88C File Offset: 0x0012CA8C
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003BFA RID: 15354 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06003BFB RID: 15355 RVA: 0x0012E8B0 File Offset: 0x0012CAB0
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_EarthQuake");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003BFC RID: 15356 RVA: 0x0012E8D4 File Offset: 0x0012CAD4
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.X);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Y);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003BFD RID: 15357 RVA: 0x0012E58B File Offset: 0x0012C78B
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003BFE RID: 15358 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06003BFF RID: 15359 RVA: 0x0012E58B File Offset: 0x0012C78B
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C00 RID: 15360 RVA: 0x0012E58B File Offset: 0x0012C78B
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C01 RID: 15361 RVA: 0x0012E58B File Offset: 0x0012C78B
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C02 RID: 15362 RVA: 0x0012E9D3 File Offset: 0x0012CBD3
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_LinearLight");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003C03 RID: 15363 RVA: 0x0012E9F7 File Offset: 0x0012CBF7
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("CheckResources () for ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003C04 RID: 15364 RVA: 0x0012EA1B File Offset: 0x0012CC1B
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("_BlurredColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003C05 RID: 15365 RVA: 0x0012EA40 File Offset: 0x0012CC40
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1375f)
			{
				this.HBJJOCHGOPH = 1193f;
			}
			this.KAFBNOBOIAJ().SetFloat("Vertical", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat(". Using max value: 255.", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Heigh", this.X);
			this.OIMMPLPBLBK().SetFloat("_Value5", this.Y);
			this.NBPKMLMCHFN.SetFloat("_Luminance", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("Identity LUT", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1320f, 1556f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C06 RID: 15366 RVA: 0x0012EB40 File Offset: 0x0012CD40
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1626f)
			{
				this.HBJJOCHGOPH = 1599f;
			}
			this.KAFBNOBOIAJ().SetFloat("Editor/", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("settings.arcsdestroydelay", this.Speed);
			this.OIMMPLPBLBK().SetFloat("CameraFilterPack/Blend2Camera_Saturation", this.X);
			this.KAFBNOBOIAJ().SetFloat("_Value2", this.Y);
			this.KAFBNOBOIAJ().SetFloat("_SpawnHeuristic", this.CCIENBFIKKH);
			this.KAFBNOBOIAJ().SetVector("[MapEditor] Item creation successful! Published Item ID: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1193f, 1678f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C07 RID: 15367 RVA: 0x0012EC40 File Offset: 0x0012CE40
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1741f)
			{
				this.HBJJOCHGOPH = 1075f;
			}
			this.OIMMPLPBLBK().SetFloat("_NoisePerChannel", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("Editor/", this.Speed);
			this.OIMMPLPBLBK().SetFloat("elapsed: {0:0.000}", this.X);
			this.KAFBNOBOIAJ().SetFloat("Other", this.Y);
			this.KAFBNOBOIAJ().SetFloat("#", this.CCIENBFIKKH);
			this.OIMMPLPBLBK().SetVector("_Value5", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1849f, 928f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C08 RID: 15368 RVA: 0x0012ED40 File Offset: 0x0012CF40
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1750f)
			{
				this.HBJJOCHGOPH = 730f;
			}
			this.OIMMPLPBLBK().SetFloat("_CameraToWorldMatrix", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("AddEnvironmentObject", this.Speed);
			this.OIMMPLPBLBK().SetFloat("Error! no audio sources attached to AudioSampler.css", this.X);
			this.NBPKMLMCHFN.SetFloat(". Possible scene loading in progress?", this.Y);
			this.OIMMPLPBLBK().SetFloat("MapEnd", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 499f, 1929f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C09 RID: 15369 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x06003C0A RID: 15370 RVA: 0x0012E88C File Offset: 0x0012CA8C
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0400068F RID: 1679
	public Shader SCShader;

	// Token: 0x04000690 RID: 1680
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000691 RID: 1681
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000692 RID: 1682
	private Material BJFKDHHMLJH;

	// Token: 0x04000693 RID: 1683
	[Range(0f, 100f)]
	public float Speed = 15f;

	// Token: 0x04000694 RID: 1684
	[Range(0f, 0.2f)]
	public float X = 0.008f;

	// Token: 0x04000695 RID: 1685
	[Range(0f, 0.2f)]
	public float Y = 0.008f;

	// Token: 0x04000696 RID: 1686
	[Range(0f, 0.2f)]
	private float CCIENBFIKKH = 1f;
}
