using System;
using UnityEngine;

// Token: 0x0200012A RID: 298
[AddComponentMenu("Camera Filter Pack/TV/WideScreenCircle")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_WideScreenCircle : MonoBehaviour
{
	// Token: 0x06005E5D RID: 24157 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06005E5E RID: 24158 RVA: 0x001CC0DB File Offset: 0x001CA2DB
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E5F RID: 24159 RVA: 0x001CC0DB File Offset: 0x001CA2DB
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E61 RID: 24161 RVA: 0x001CC137 File Offset: 0x001CA337
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E62 RID: 24162 RVA: 0x001CC16E File Offset: 0x001CA36E
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("#failed: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005E63 RID: 24163 RVA: 0x001CC0DB File Offset: 0x001CA2DB
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E64 RID: 24164 RVA: 0x001CC0DB File Offset: 0x001CA2DB
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E65 RID: 24165 RVA: 0x001CC192 File Offset: 0x001CA392
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E66 RID: 24166 RVA: 0x001CC1CC File Offset: 0x001CA3CC
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1870f)
			{
				this.HBJJOCHGOPH = 776f;
			}
			this.PLBEJJIHFPB().SetFloat("_Near", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetFloat("_Value3", this.Size);
			this.JIBOKBCPDLC().SetFloat("\" error: ", this.Smooth);
			this.KEMAALEODNH().SetFloat("_Blue_R", this.ICABEDDNGIH);
			this.NBPKMLMCHFN.SetFloat("Gameplay/Base", this.LHOMPJOPKHE);
			this.JIBOKBCPDLC().SetVector("Hex value #RRGGBB", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 891f, 1437f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x1700010F RID: 271
	// (get) Token: 0x06005E67 RID: 24167 RVA: 0x001CC2CB File Offset: 0x001CA4CB
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

	// Token: 0x06005E68 RID: 24168 RVA: 0x001CC304 File Offset: 0x001CA504
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Smooth);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.ICABEDDNGIH);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.LHOMPJOPKHE);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E69 RID: 24169 RVA: 0x001CC404 File Offset: 0x001CA604
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1646f)
			{
				this.HBJJOCHGOPH = 169f;
			}
			this.ADBKPGFMNKO().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("_Blood", this.Size);
			this.JIBOKBCPDLC().SetFloat(": ", this.Smooth);
			this.IONHGBPGCHK().SetFloat("menu.tabid", this.ICABEDDNGIH);
			this.KEMAALEODNH().SetFloat("_Value4", this.LHOMPJOPKHE);
			this.DOHGBNPMBKG().SetVector("#ok", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 440f, 233f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E6A RID: 24170 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005E6B RID: 24171 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06005E6C RID: 24172 RVA: 0x001CC503 File Offset: 0x001CA703
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005E6D RID: 24173 RVA: 0x001CC527 File Offset: 0x001CA727
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E6E RID: 24174 RVA: 0x001CC0DB File Offset: 0x001CA2DB
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E6F RID: 24175 RVA: 0x001CC55E File Offset: 0x001CA75E
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E70 RID: 24176 RVA: 0x001CC595 File Offset: 0x001CA795
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E71 RID: 24177 RVA: 0x001CC5CC File Offset: 0x001CA7CC
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_WideScreenCircle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005E72 RID: 24178 RVA: 0x001CC5F0 File Offset: 0x001CA7F0
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E73 RID: 24179 RVA: 0x001CC627 File Offset: 0x001CA827
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find(";");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005E74 RID: 24180 RVA: 0x001CC64B File Offset: 0x001CA84B
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("R:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005E75 RID: 24181 RVA: 0x001CC66F File Offset: 0x001CA86F
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0400097E RID: 2430
	public Shader SCShader;

	// Token: 0x0400097F RID: 2431
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000980 RID: 2432
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000981 RID: 2433
	private Material BJFKDHHMLJH;

	// Token: 0x04000982 RID: 2434
	[Range(0f, 0.8f)]
	public float Size = 0.55f;

	// Token: 0x04000983 RID: 2435
	[Range(0.01f, 0.4f)]
	public float Smooth = 0.01f;

	// Token: 0x04000984 RID: 2436
	[Range(0f, 10f)]
	private float ICABEDDNGIH = 1f;

	// Token: 0x04000985 RID: 2437
	[Range(0f, 10f)]
	private float LHOMPJOPKHE = 1f;
}
