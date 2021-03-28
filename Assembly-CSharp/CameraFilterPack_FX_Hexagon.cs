using System;
using UnityEngine;

// Token: 0x020000CC RID: 204
[AddComponentMenu("Camera Filter Pack/FX/Hexagon")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_Hexagon : MonoBehaviour
{
	// Token: 0x06003DBF RID: 15807 RVA: 0x00134A20 File Offset: 0x00132C20
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003DC0 RID: 15808 RVA: 0x00134A57 File Offset: 0x00132C57
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("distance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003DC2 RID: 15810 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06003DC3 RID: 15811 RVA: 0x00134A8E File Offset: 0x00132C8E
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003DC4 RID: 15812 RVA: 0x00134AAB File Offset: 0x00132CAB
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003DC5 RID: 15813 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06003DC6 RID: 15814 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003DC7 RID: 15815 RVA: 0x00134A8E File Offset: 0x00132C8E
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003DC8 RID: 15816 RVA: 0x00134AE2 File Offset: 0x00132CE2
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x170000B2 RID: 178
	// (get) Token: 0x06003DC9 RID: 15817 RVA: 0x00134B19 File Offset: 0x00132D19
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

	// Token: 0x06003DCA RID: 15818 RVA: 0x00134B50 File Offset: 0x00132D50
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003DCB RID: 15819 RVA: 0x00134B87 File Offset: 0x00132D87
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("DPADVER");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003DCC RID: 15820 RVA: 0x00134A8E File Offset: 0x00132C8E
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003DCD RID: 15821 RVA: 0x00134BAB File Offset: 0x00132DAB
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Hexagon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003DCE RID: 15822 RVA: 0x00134BD0 File Offset: 0x00132DD0
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 75f;
			}
			this.KGOLDDBHIFN().SetFloat("/?player=", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetVector("_Value6", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1672f, 1182f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003DCF RID: 15823 RVA: 0x00134A8E File Offset: 0x00132C8E
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003DD0 RID: 15824 RVA: 0x00134A8E File Offset: 0x00132C8E
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003DD1 RID: 15825 RVA: 0x00134C78 File Offset: 0x00132E78
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

	// Token: 0x06003DD2 RID: 15826 RVA: 0x00134D1F File Offset: 0x00132F1F
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003DD3 RID: 15827 RVA: 0x00134D56 File Offset: 0x00132F56
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003DD4 RID: 15828 RVA: 0x00134D8D File Offset: 0x00132F8D
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003DD5 RID: 15829 RVA: 0x00134DB1 File Offset: 0x00132FB1
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003DD6 RID: 15830 RVA: 0x00134DE8 File Offset: 0x00132FE8
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("[SERVER] Selected map: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003DD7 RID: 15831 RVA: 0x00134E0C File Offset: 0x0013300C
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003DD8 RID: 15832 RVA: 0x00134E43 File Offset: 0x00133043
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003DD9 RID: 15833 RVA: 0x00134A8E File Offset: 0x00132C8E
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003DDA RID: 15834 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06003DDB RID: 15835 RVA: 0x00134A8E File Offset: 0x00132C8E
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040006B0 RID: 1712
	public Shader SCShader;

	// Token: 0x040006B1 RID: 1713
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040006B2 RID: 1714
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040006B3 RID: 1715
	private Material BJFKDHHMLJH;
}
