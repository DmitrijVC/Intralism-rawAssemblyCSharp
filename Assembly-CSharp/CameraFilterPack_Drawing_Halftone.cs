using System;
using UnityEngine;

// Token: 0x0200009E RID: 158
[AddComponentMenu("Camera Filter Pack/Drawing/Halftone")]
[ExecuteInEditMode]
public class CameraFilterPack_Drawing_Halftone : MonoBehaviour
{
	// Token: 0x06002FD9 RID: 12249 RVA: 0x000FEE64 File Offset: 0x000FD064
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1439f)
			{
				this.HBJJOCHGOPH = 1970f;
			}
			this.KEMAALEODNH().SetFloat("CameraFilterPack/FX_Dot_Circle", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("colorD", this.Threshold);
			this.PDEAHJPOMEF().SetFloat("HPToggle", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002FDA RID: 12250 RVA: 0x000FEF0C File Offset: 0x000FD10C
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1607f)
			{
				this.HBJJOCHGOPH = 985f;
			}
			this.DBOLLHHMKKN().SetFloat("[LevelEditorScene] Item creation successful! Published Item ID: ", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Anomaly_With_Obj", this.Threshold);
			this.NBPKMLMCHFN.SetFloat("maps.", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002FDB RID: 12251 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06002FDD RID: 12253 RVA: 0x000FEFDB File Offset: 0x000FD1DB
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002FDE RID: 12254 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06002FDF RID: 12255 RVA: 0x000FF012 File Offset: 0x000FD212
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002FE0 RID: 12256 RVA: 0x000FF030 File Offset: 0x000FD230
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 438f)
			{
				this.HBJJOCHGOPH = 248f;
			}
			this.OIMMPLPBLBK().SetFloat("_ReflectionBlur", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("DPADVER", this.Threshold);
			this.DEFBJOCJJKF().SetFloat("_TimeX", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002FE1 RID: 12257 RVA: 0x000FF012 File Offset: 0x000FD212
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002FE2 RID: 12258 RVA: 0x000FF0D8 File Offset: 0x000FD2D8
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1200f)
			{
				this.HBJJOCHGOPH = 558f;
			}
			this.DBOLLHHMKKN().SetFloat("ConnectionTimeout", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("RaiseEvent() failed. Your event is not being sent! Check if your are in a Room and the eventCode must be less than 200 (0..199).", this.Threshold);
			this.DEFBJOCJJKF().SetFloat("_Amount", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002FE3 RID: 12259 RVA: 0x000FF180 File Offset: 0x000FD380
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
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Threshold);
			this.NBPKMLMCHFN.SetFloat("_DotSize", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002FE4 RID: 12260 RVA: 0x000FF226 File Offset: 0x000FD426
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("other");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002FE5 RID: 12261 RVA: 0x000FF24A File Offset: 0x000FD44A
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("Object ID. Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002FE6 RID: 12262 RVA: 0x000FF012 File Offset: 0x000FD212
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002FE7 RID: 12263 RVA: 0x000FF26E File Offset: 0x000FD46E
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_Halftone");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002FE8 RID: 12264 RVA: 0x000FF292 File Offset: 0x000FD492
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("RoomDescriptionText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002FE9 RID: 12265 RVA: 0x000FF2B6 File Offset: 0x000FD4B6
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002FEA RID: 12266 RVA: 0x000FF2ED File Offset: 0x000FD4ED
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002FEB RID: 12267 RVA: 0x000FF324 File Offset: 0x000FD524
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002FEC RID: 12268 RVA: 0x000FF348 File Offset: 0x000FD548
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1285f)
			{
				this.HBJJOCHGOPH = 420f;
			}
			this.LNLKMDPHDCC().SetFloat("_Color", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("tagElement", this.Threshold);
			this.DBOLLHHMKKN().SetFloat("workshop.", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002FED RID: 12269 RVA: 0x000FF3EE File Offset: 0x000FD5EE
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002FEE RID: 12270 RVA: 0x000FF012 File Offset: 0x000FD212
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002FEF RID: 12271 RVA: 0x000FF425 File Offset: 0x000FD625
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002FF0 RID: 12272 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x17000083 RID: 131
	// (get) Token: 0x06002FF1 RID: 12273 RVA: 0x000FF449 File Offset: 0x000FD649
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

	// Token: 0x06002FF2 RID: 12274 RVA: 0x000FF480 File Offset: 0x000FD680
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1290f)
			{
				this.HBJJOCHGOPH = 353f;
			}
			this.DEFBJOCJJKF().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("win", this.Threshold);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack_Glasses_On5", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002FF3 RID: 12275 RVA: 0x000FF526 File Offset: 0x000FD726
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002FF4 RID: 12276 RVA: 0x000FF012 File Offset: 0x000FD212
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002FF5 RID: 12277 RVA: 0x000FF54A File Offset: 0x000FD74A
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002FF6 RID: 12278 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x06002FF7 RID: 12279 RVA: 0x000FF584 File Offset: 0x000FD784
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 821f)
			{
				this.HBJJOCHGOPH = 1071f;
			}
			this.PDEAHJPOMEF().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("CameraFilterPack_Paper1", this.Threshold);
			this.KEMAALEODNH().SetFloat("warning: Audio Source: ", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002FF8 RID: 12280 RVA: 0x000FF62A File Offset: 0x000FD82A
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002FF9 RID: 12281 RVA: 0x000FF2B6 File Offset: 0x000FD4B6
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002FFA RID: 12282 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x04000577 RID: 1399
	public Shader SCShader;

	// Token: 0x04000578 RID: 1400
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000579 RID: 1401
	private Material BJFKDHHMLJH;

	// Token: 0x0400057A RID: 1402
	[Range(0f, 1f)]
	public float Threshold = 0.6f;

	// Token: 0x0400057B RID: 1403
	[Range(1f, 16f)]
	public float DotSize = 4f;
}
