using System;
using UnityEngine;

// Token: 0x020000C7 RID: 199
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/FX/Funk")]
public class CameraFilterPack_FX_Funk : MonoBehaviour
{
	// Token: 0x06003C0B RID: 15371 RVA: 0x0012EE40 File Offset: 0x0012D040
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1656f)
			{
				this.HBJJOCHGOPH = 1162f;
			}
			this.IGKFMCPDNOI().SetFloat("achievements.id", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector("IntraTime", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1238f, 1325f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C0C RID: 15372 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06003C0D RID: 15373 RVA: 0x0012EEE7 File Offset: 0x0012D0E7
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)72;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C0E RID: 15374 RVA: 0x0012EF1E File Offset: 0x0012D11E
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C10 RID: 15376 RVA: 0x0012EF68 File Offset: 0x0012D168
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Funk");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003C11 RID: 15377 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06003C12 RID: 15378 RVA: 0x0012EF8C File Offset: 0x0012D18C
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C13 RID: 15379 RVA: 0x0012EFC3 File Offset: 0x0012D1C3
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C14 RID: 15380 RVA: 0x0012EFC3 File Offset: 0x0012D1C3
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C15 RID: 15381 RVA: 0x0012EFE0 File Offset: 0x0012D1E0
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("_Parameter");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003C16 RID: 15382 RVA: 0x0012F004 File Offset: 0x0012D204
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("OPEN FILE");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003C17 RID: 15383 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06003C18 RID: 15384 RVA: 0x0012F028 File Offset: 0x0012D228
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("907198288");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003C19 RID: 15385 RVA: 0x0012F04C File Offset: 0x0012D24C
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 579f)
			{
				this.HBJJOCHGOPH = 412f;
			}
			this.DEFBJOCJJKF().SetFloat("UseScanLineSize", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetVector(".lastCheckpoint.correctScore", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 556f, 708f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C1A RID: 15386 RVA: 0x0012EFC3 File Offset: 0x0012D1C3
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C1B RID: 15387 RVA: 0x0012EFC3 File Offset: 0x0012D1C3
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C1C RID: 15388 RVA: 0x0012F0F4 File Offset: 0x0012D2F4
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 997f)
			{
				this.HBJJOCHGOPH = 586f;
			}
			this.IGKFMCPDNOI().SetFloat("NO", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetVector("Event Received", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 61f, 1172f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C1D RID: 15389 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x170000AD RID: 173
	// (get) Token: 0x06003C1E RID: 15390 RVA: 0x0012F19B File Offset: 0x0012D39B
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

	// Token: 0x06003C1F RID: 15391 RVA: 0x0012EFC3 File Offset: 0x0012D1C3
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C20 RID: 15392 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06003C21 RID: 15393 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003C22 RID: 15394 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06003C23 RID: 15395 RVA: 0x0012F1D2 File Offset: 0x0012D3D2
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C24 RID: 15396 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06003C25 RID: 15397 RVA: 0x0012F209 File Offset: 0x0012D409
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C26 RID: 15398 RVA: 0x0012F240 File Offset: 0x0012D440
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("settings.customdataskin");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003C27 RID: 15399 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06003C28 RID: 15400 RVA: 0x0012F1D2 File Offset: 0x0012D3D2
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C29 RID: 15401 RVA: 0x0012F264 File Offset: 0x0012D464
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C2A RID: 15402 RVA: 0x0012F29B File Offset: 0x0012D49B
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("intensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003C2B RID: 15403 RVA: 0x0012EFC3 File Offset: 0x0012D1C3
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C2C RID: 15404 RVA: 0x0012F2C0 File Offset: 0x0012D4C0
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
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C2D RID: 15405 RVA: 0x0012F367 File Offset: 0x0012D567
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C2E RID: 15406 RVA: 0x0012F39E File Offset: 0x0012D59E
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("MenuScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003C2F RID: 15407 RVA: 0x0012EFC3 File Offset: 0x0012D1C3
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C30 RID: 15408 RVA: 0x0012F3C4 File Offset: 0x0012D5C4
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1731f)
			{
				this.HBJJOCHGOPH = 978f;
			}
			this.FAIFBBGFAIB().SetFloat("settings_bindings_sec_", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetVector("_FgOverlap", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1126f, 108f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C31 RID: 15409 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06003C32 RID: 15410 RVA: 0x0012F46B File Offset: 0x0012D66B
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("MusicFileSelector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003C33 RID: 15411 RVA: 0x0012F48F File Offset: 0x0012D68F
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("Image");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x04000697 RID: 1687
	public Shader SCShader;

	// Token: 0x04000698 RID: 1688
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000699 RID: 1689
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400069A RID: 1690
	private Material BJFKDHHMLJH;
}
