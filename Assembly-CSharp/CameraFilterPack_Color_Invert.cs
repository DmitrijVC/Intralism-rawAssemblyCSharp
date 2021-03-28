using System;
using UnityEngine;

// Token: 0x02000071 RID: 113
[AddComponentMenu("Camera Filter Pack/Colors/Invert")]
[ExecuteInEditMode]
public class CameraFilterPack_Color_Invert : MonoBehaviour
{
	// Token: 0x06002027 RID: 8231 RVA: 0x000BC884 File Offset: 0x000BAA84
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1138f)
			{
				this.HBJJOCHGOPH = 648f;
			}
			this.DEFBJOCJJKF().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("X", this._Fade);
			this.PDEAHJPOMEF().SetVector("}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1439f, 1847f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002028 RID: 8232 RVA: 0x000BC941 File Offset: 0x000BAB41
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002029 RID: 8233 RVA: 0x000BC968 File Offset: 0x000BAB68
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1481f)
			{
				this.HBJJOCHGOPH = 1001f;
			}
			this.PDEAHJPOMEF().SetFloat("Hidden/TonemappingColorGrading", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("Cancel", this._Fade);
			this.NBPKMLMCHFN.SetVector("Tab1Content", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 439f, 1858f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600202A RID: 8234 RVA: 0x000BCA25 File Offset: 0x000BAC25
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x17000057 RID: 87
	// (get) Token: 0x0600202B RID: 8235 RVA: 0x000BCA5C File Offset: 0x000BAC5C
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

	// Token: 0x0600202C RID: 8236 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x0600202D RID: 8237 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600202E RID: 8238 RVA: 0x000BCA94 File Offset: 0x000BAC94
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 237f)
			{
				this.HBJJOCHGOPH = 477f;
			}
			this.PDEAHJPOMEF().SetFloat("Image", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("PLEASE WAIT", this._Fade);
			this.DEFBJOCJJKF().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1777f, 222f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600202F RID: 8239 RVA: 0x000BCB51 File Offset: 0x000BAD51
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002031 RID: 8241 RVA: 0x000BCB51 File Offset: 0x000BAD51
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002032 RID: 8242 RVA: 0x000BCB51 File Offset: 0x000BAD51
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002033 RID: 8243 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06002034 RID: 8244 RVA: 0x000BCB51 File Offset: 0x000BAD51
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002035 RID: 8245 RVA: 0x000BCB8C File Offset: 0x000BAD8C
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("Set Satellite Trail Length");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002036 RID: 8246 RVA: 0x000BCBB0 File Offset: 0x000BADB0
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1812f)
			{
				this.HBJJOCHGOPH = 620f;
			}
			this.PLBEJJIHFPB().SetFloat("/icon", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("SpawnObj", this._Fade);
			this.PDEAHJPOMEF().SetVector("LoadingStatusText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1364f, 1879f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002037 RID: 8247 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06002038 RID: 8248 RVA: 0x000BCC6D File Offset: 0x000BAE6D
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002039 RID: 8249 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x0600203A RID: 8250 RVA: 0x000BCCA4 File Offset: 0x000BAEA4
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("a");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600203B RID: 8251 RVA: 0x000BCB51 File Offset: 0x000BAD51
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600203C RID: 8252 RVA: 0x000BCCC8 File Offset: 0x000BAEC8
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 663f)
			{
				this.HBJJOCHGOPH = 820f;
			}
			this.PLBEJJIHFPB().SetFloat("_Value5", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("skin.", this._Fade);
			this.PLBEJJIHFPB().SetVector("[LocalizationService] Localization: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 17f, 799f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600203D RID: 8253 RVA: 0x000BCD85 File Offset: 0x000BAF85
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("PUN-instantiated '");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600203E RID: 8254 RVA: 0x000BCDAC File Offset: 0x000BAFAC
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
			this.NBPKMLMCHFN.SetFloat("_Fade", this._Fade);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600203F RID: 8255 RVA: 0x000BCE69 File Offset: 0x000BB069
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("GameModeText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002040 RID: 8256 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06002041 RID: 8257 RVA: 0x000BCB51 File Offset: 0x000BAD51
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002042 RID: 8258 RVA: 0x000BCE8D File Offset: 0x000BB08D
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("settings_bindings_sec_");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002043 RID: 8259 RVA: 0x000BCEB1 File Offset: 0x000BB0B1
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)80;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002044 RID: 8260 RVA: 0x000BCEE8 File Offset: 0x000BB0E8
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1500f)
			{
				this.HBJJOCHGOPH = 1965f;
			}
			this.PDEAHJPOMEF().SetFloat("PublishButton", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("CameraFilterPack/Distortion_BigFace", this._Fade);
			this.PLBEJJIHFPB().SetVector("0", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 677f, 1578f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002045 RID: 8261 RVA: 0x000BCFA5 File Offset: 0x000BB1A5
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002046 RID: 8262 RVA: 0x000BCFC9 File Offset: 0x000BB1C9
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Color_Invert");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0400042E RID: 1070
	public Shader SCShader;

	// Token: 0x0400042F RID: 1071
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000430 RID: 1072
	[Range(0f, 1f)]
	public float _Fade = 1f;

	// Token: 0x04000431 RID: 1073
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000432 RID: 1074
	private Material BJFKDHHMLJH;
}
