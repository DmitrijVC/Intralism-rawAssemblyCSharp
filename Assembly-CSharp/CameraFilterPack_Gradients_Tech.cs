using System;
using UnityEngine;

// Token: 0x020000E9 RID: 233
[AddComponentMenu("Camera Filter Pack/Gradients/Tech")]
[ExecuteInEditMode]
public class CameraFilterPack_Gradients_Tech : MonoBehaviour
{
	// Token: 0x170000CF RID: 207
	// (get) Token: 0x060047F6 RID: 18422 RVA: 0x00160423 File Offset: 0x0015E623
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

	// Token: 0x060047F7 RID: 18423 RVA: 0x0016045A File Offset: 0x0015E65A
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060047F8 RID: 18424 RVA: 0x00160491 File Offset: 0x0015E691
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060047F9 RID: 18425 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x060047FA RID: 18426 RVA: 0x00160491 File Offset: 0x0015E691
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060047FB RID: 18427 RVA: 0x00160491 File Offset: 0x0015E691
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060047FC RID: 18428 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x060047FD RID: 18429 RVA: 0x001604B6 File Offset: 0x0015E6B6
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060047FE RID: 18430 RVA: 0x001604D4 File Offset: 0x0015E6D4
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 724f)
			{
				this.HBJJOCHGOPH = 1494f;
			}
			this.NBPKMLMCHFN.SetFloat("SetSunMaxSize", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("#getrewardfailed: ", this.Switch);
			this.HFBJAOFLCJI().SetFloat("_Distortion", this.Fade);
			this.IIBLJCKLGFG().SetVector("Search: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1244f, 37f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060047FF RID: 18431 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06004800 RID: 18432 RVA: 0x001604B6 File Offset: 0x0015E6B6
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004801 RID: 18433 RVA: 0x001605A7 File Offset: 0x0015E7A7
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004802 RID: 18434 RVA: 0x001604B6 File Offset: 0x0015E6B6
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004803 RID: 18435 RVA: 0x001605DE File Offset: 0x0015E7DE
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004804 RID: 18436 RVA: 0x001604B6 File Offset: 0x0015E6B6
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004805 RID: 18437 RVA: 0x00160604 File Offset: 0x0015E804
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 884f)
			{
				this.HBJJOCHGOPH = 1005f;
			}
			this.PDEAHJPOMEF().SetFloat("#obtained", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("PlayerPrefs::Deserialize() parameterContent has ", this.Switch);
			this.PDEAHJPOMEF().SetFloat("\"", this.Fade);
			this.DBOLLHHMKKN().SetVector("value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1870f, 1024f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004806 RID: 18438 RVA: 0x001606D7 File Offset: 0x0015E8D7
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004807 RID: 18439 RVA: 0x001604B6 File Offset: 0x0015E6B6
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004808 RID: 18440 RVA: 0x001604B6 File Offset: 0x0015E6B6
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004809 RID: 18441 RVA: 0x00160491 File Offset: 0x0015E691
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600480A RID: 18442 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600480B RID: 18443 RVA: 0x001604B6 File Offset: 0x0015E6B6
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600480C RID: 18444 RVA: 0x0016070E File Offset: 0x0015E90E
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600480D RID: 18445 RVA: 0x00160748 File Offset: 0x0015E948
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1658f)
			{
				this.HBJJOCHGOPH = 908f;
			}
			this.IIBLJCKLGFG().SetFloat(".", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("_ScreenResolution", this.Switch);
			this.IIBLJCKLGFG().SetFloat("ScreenResolutionPanel", this.Fade);
			this.NBPKMLMCHFN.SetVector("Joystick1Button3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1300f, 1891f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600480E RID: 18446 RVA: 0x0016081C File Offset: 0x0015EA1C
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

	// Token: 0x0600480F RID: 18447 RVA: 0x00160491 File Offset: 0x0015E691
	private void Start()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004810 RID: 18448 RVA: 0x001604B6 File Offset: 0x0015E6B6
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004811 RID: 18449 RVA: 0x001608F0 File Offset: 0x0015EAF0
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 71f)
			{
				this.HBJJOCHGOPH = 60f;
			}
			this.PDEAHJPOMEF().SetFloat("Tab2Content", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("player.licenceaccepted", this.Switch);
			this.NBPKMLMCHFN.SetFloat("[ItemsHandler] All in-game items loaded", this.Fade);
			this.NBPKMLMCHFN.SetVector(".png", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1827f, 1271f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004812 RID: 18450 RVA: 0x001604B6 File Offset: 0x0015E6B6
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004813 RID: 18451 RVA: 0x001609C4 File Offset: 0x0015EBC4
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 384f)
			{
				this.HBJJOCHGOPH = 1938f;
			}
			this.PDEAHJPOMEF().SetFloat("_EmissionColor", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("Object ID. Case-Sensitive", this.Switch);
			this.HFBJAOFLCJI().SetFloat("_ScreenResolution", this.Fade);
			this.IIBLJCKLGFG().SetVector("_HueShift", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1057f, 1465f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x04000799 RID: 1945
	public Shader SCShader;

	// Token: 0x0400079A RID: 1946
	private string ELOFMLPCCEA = "CameraFilterPack/Gradients_Tech";

	// Token: 0x0400079B RID: 1947
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400079C RID: 1948
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400079D RID: 1949
	private Material BJFKDHHMLJH;

	// Token: 0x0400079E RID: 1950
	[Range(0f, 1f)]
	public float Switch = 1f;

	// Token: 0x0400079F RID: 1951
	[Range(0f, 1f)]
	public float Fade = 1f;
}
