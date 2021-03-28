using System;
using UnityEngine;

// Token: 0x020000EB RID: 235
[AddComponentMenu("Camera Filter Pack/Light/Rainbow")]
[ExecuteInEditMode]
public class CameraFilterPack_Light_Rainbow : MonoBehaviour
{
	// Token: 0x06004867 RID: 18535 RVA: 0x001621B4 File Offset: 0x001603B4
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 579f)
			{
				this.HBJJOCHGOPH = 1042f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value6", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("MenuScene", this.Value);
			this.DBOLLHHMKKN().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 408f, 1002f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004868 RID: 18536 RVA: 0x00162271 File Offset: 0x00160471
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004869 RID: 18537 RVA: 0x0016228E File Offset: 0x0016048E
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600486A RID: 18538 RVA: 0x00162271 File Offset: 0x00160471
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600486B RID: 18539 RVA: 0x001622C8 File Offset: 0x001604C8
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Value);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600486C RID: 18540 RVA: 0x00162385 File Offset: 0x00160585
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600486D RID: 18541 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x0600486E RID: 18542 RVA: 0x001623BC File Offset: 0x001605BC
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("Ev OwnershipRequest ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004870 RID: 18544 RVA: 0x00162400 File Offset: 0x00160600
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1079f)
			{
				this.HBJJOCHGOPH = 489f;
			}
			this.HHIFMIPPMPF().SetFloat("settings.arcshitsoundtimedelay", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("[RanksSystem] Ranks: no need to update", this.Value);
			this.DBOLLHHMKKN().SetVector("_Bloom", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1284f, 1001f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004871 RID: 18545 RVA: 0x00162271 File Offset: 0x00160471
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004872 RID: 18546 RVA: 0x001624BD File Offset: 0x001606BD
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("_MidGrey");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004873 RID: 18547 RVA: 0x00162271 File Offset: 0x00160471
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004874 RID: 18548 RVA: 0x001624E1 File Offset: 0x001606E1
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004875 RID: 18549 RVA: 0x00162508 File Offset: 0x00160708
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1194f)
			{
				this.HBJJOCHGOPH = 1174f;
			}
			this.HHIFMIPPMPF().SetFloat("_Red_B", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("MusicFileSelector", this.Value);
			this.ACHNOHCLGOO().SetVector("AudioSampler", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 716f, 364f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004876 RID: 18550 RVA: 0x00162271 File Offset: 0x00160471
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004877 RID: 18551 RVA: 0x001625C8 File Offset: 0x001607C8
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1286f)
			{
				this.HBJJOCHGOPH = 115f;
			}
			this.DBOLLHHMKKN().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("RecieveChatMessage", this.Value);
			this.HFBJAOFLCJI().SetVector("workshop.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 237f, 997f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004878 RID: 18552 RVA: 0x00162685 File Offset: 0x00160885
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004879 RID: 18553 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x0600487A RID: 18554 RVA: 0x00162271 File Offset: 0x00160471
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600487B RID: 18555 RVA: 0x001626BC File Offset: 0x001608BC
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("menu.hardcoreinfo");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x170000D1 RID: 209
	// (get) Token: 0x0600487C RID: 18556 RVA: 0x001626E0 File Offset: 0x001608E0
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

	// Token: 0x0600487D RID: 18557 RVA: 0x00162271 File Offset: 0x00160471
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600487E RID: 18558 RVA: 0x00162717 File Offset: 0x00160917
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600487F RID: 18559 RVA: 0x0016274E File Offset: 0x0016094E
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004880 RID: 18560 RVA: 0x00162785 File Offset: 0x00160985
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Light_Rainbow");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004881 RID: 18561 RVA: 0x00162271 File Offset: 0x00160471
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004882 RID: 18562 RVA: 0x001627A9 File Offset: 0x001609A9
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("player.currentrank");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004883 RID: 18563 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06004884 RID: 18564 RVA: 0x001627CD File Offset: 0x001609CD
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004885 RID: 18565 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x040007A7 RID: 1959
	public Shader SCShader;

	// Token: 0x040007A8 RID: 1960
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040007A9 RID: 1961
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040007AA RID: 1962
	private Material BJFKDHHMLJH;

	// Token: 0x040007AB RID: 1963
	[Range(0.01f, 5f)]
	public float Value = 1.5f;
}
