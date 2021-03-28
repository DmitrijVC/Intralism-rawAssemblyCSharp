using System;
using UnityEngine;

// Token: 0x020000DE RID: 222
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Glitch/Mozaic")]
public class CameraFilterPack_Glitch_Mozaic : MonoBehaviour
{
	// Token: 0x06004435 RID: 17461 RVA: 0x001513A0 File Offset: 0x0014F5A0
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 577f)
			{
				this.HBJJOCHGOPH = 42f;
			}
			this.NBPKMLMCHFN.SetFloat("inventory.lastitemscount", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("Horizontal", this.Intensity);
			this.PDEAHJPOMEF().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", this.EOKMJCIDCDB);
			this.NBPKMLMCHFN.SetFloat("Clears all text from the debug console", this.ILHJFHFPGBB);
			this.NBPKMLMCHFN.SetFloat("\t", this.CCIENBFIKKH);
			this.PDEAHJPOMEF().SetVector("[ResourcesManager] Load image error: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1554f, 1128f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004436 RID: 17462 RVA: 0x0015149F File Offset: 0x0014F69F
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004437 RID: 17463 RVA: 0x001514BC File Offset: 0x0014F6BC
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004438 RID: 17464 RVA: 0x001514F4 File Offset: 0x0014F6F4
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 27f)
			{
				this.HBJJOCHGOPH = 583f;
			}
			this.NFMGLIKNOOC().SetFloat("Set Object Scale", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("Set Player Distance", this.Intensity);
			this.KBOPGONOCNP().SetFloat("[Up]", this.EOKMJCIDCDB);
			this.KBOPGONOCNP().SetFloat("_TimeX", this.ILHJFHFPGBB);
			this.NBPKMLMCHFN.SetFloat("[Right]", this.CCIENBFIKKH);
			this.LDNADDJMIPK().SetVector("downloading", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 850f, 103f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004439 RID: 17465 RVA: 0x0015149F File Offset: 0x0014F69F
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600443A RID: 17466 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x0600443B RID: 17467 RVA: 0x001515F3 File Offset: 0x0014F7F3
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Glitch_Mozaic");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600443C RID: 17468 RVA: 0x00151617 File Offset: 0x0014F817
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("Color's hex value #RRGGBBAA");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600443D RID: 17469 RVA: 0x0015163C File Offset: 0x0014F83C
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1267f)
			{
				this.HBJJOCHGOPH = 824f;
			}
			this.ADBKPGFMNKO().SetFloat("[#clicktoacceptchallenge]", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("LoadingStatusText", this.Intensity);
			this.KAFBNOBOIAJ().SetFloat("Error: I/O Failure! :(", this.EOKMJCIDCDB);
			this.PDEAHJPOMEF().SetFloat("[LevelEditorScene] Item creation successful! Published Item ID: ", this.ILHJFHFPGBB);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Colors_Brightness", this.CCIENBFIKKH);
			this.KBOPGONOCNP().SetVector("CameraFilterPack/Oculus_ThermaVision", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 657f, 1394f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600443E RID: 17470 RVA: 0x0015149F File Offset: 0x0014F69F
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600443F RID: 17471 RVA: 0x0015149F File Offset: 0x0014F69F
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004440 RID: 17472 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06004442 RID: 17474 RVA: 0x0015177C File Offset: 0x0014F97C
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.EOKMJCIDCDB);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.ILHJFHFPGBB);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004443 RID: 17475 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06004444 RID: 17476 RVA: 0x0015149F File Offset: 0x0014F69F
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004445 RID: 17477 RVA: 0x001514BC File Offset: 0x0014F6BC
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004446 RID: 17478 RVA: 0x0015187B File Offset: 0x0014FA7B
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)117;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004447 RID: 17479 RVA: 0x001518B2 File Offset: 0x0014FAB2
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004448 RID: 17480 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x06004449 RID: 17481 RVA: 0x001518EC File Offset: 0x0014FAEC
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 231f)
			{
				this.HBJJOCHGOPH = 506f;
			}
			this.ADBKPGFMNKO().SetFloat("0.00", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("_Value", this.Intensity);
			this.ADBKPGFMNKO().SetFloat("Metal", this.EOKMJCIDCDB);
			this.HHIFMIPPMPF().SetFloat(":\n", this.ILHJFHFPGBB);
			this.HHIFMIPPMPF().SetFloat("<b>#", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_Noise", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 475f, 858f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600444A RID: 17482 RVA: 0x0015149F File Offset: 0x0014F69F
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600444B RID: 17483 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600444C RID: 17484 RVA: 0x0015149F File Offset: 0x0014F69F
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600444D RID: 17485 RVA: 0x001519EB File Offset: 0x0014FBEB
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600444E RID: 17486 RVA: 0x00151A0F File Offset: 0x0014FC0F
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("_FarCamera");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600444F RID: 17487 RVA: 0x00151A33 File Offset: 0x0014FC33
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004450 RID: 17488 RVA: 0x00151A6A File Offset: 0x0014FC6A
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004451 RID: 17489 RVA: 0x0015149F File Offset: 0x0014F69F
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004452 RID: 17490 RVA: 0x0015149F File Offset: 0x0014F69F
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004453 RID: 17491 RVA: 0x0015149F File Offset: 0x0014F69F
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004454 RID: 17492 RVA: 0x00151A8E File Offset: 0x0014FC8E
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x170000C4 RID: 196
	// (get) Token: 0x06004455 RID: 17493 RVA: 0x00151AC5 File Offset: 0x0014FCC5
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

	// Token: 0x06004456 RID: 17494 RVA: 0x00151AFC File Offset: 0x0014FCFC
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find(" not exist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004457 RID: 17495 RVA: 0x00151B20 File Offset: 0x0014FD20
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004458 RID: 17496 RVA: 0x0015149F File Offset: 0x0014F69F
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x04000746 RID: 1862
	public Shader SCShader;

	// Token: 0x04000747 RID: 1863
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000748 RID: 1864
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000749 RID: 1865
	private Material BJFKDHHMLJH;

	// Token: 0x0400074A RID: 1866
	[Range(0.001f, 10f)]
	public float Intensity = 1f;

	// Token: 0x0400074B RID: 1867
	[Range(0f, 10f)]
	private float EOKMJCIDCDB = 1f;

	// Token: 0x0400074C RID: 1868
	[Range(0f, 10f)]
	private float ILHJFHFPGBB = 1f;

	// Token: 0x0400074D RID: 1869
	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;
}
