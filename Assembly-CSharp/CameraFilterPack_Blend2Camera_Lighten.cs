using System;
using UnityEngine;

// Token: 0x02000048 RID: 72
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/Lighten")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_Lighten : MonoBehaviour
{
	// Token: 0x06001419 RID: 5145 RVA: 0x00084C61 File Offset: 0x00082E61
	private void JNACKHNNEPA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -55);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600141A RID: 5146 RVA: 0x00084C9C File Offset: 0x00082E9C
	private void Start()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600141B RID: 5147 RVA: 0x00084D08 File Offset: 0x00082F08
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1760f)
			{
				this.HBJJOCHGOPH = 1989f;
			}
			if (this.Camera2 != null)
			{
				this.EPCGJFCCAFH().SetTexture("CameraFilterPack/TV_Old", this.JDMCFBKJHDD);
			}
			this.EPCGJFCCAFH().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat(".lastCheckpoint.bgcolor", this.BlendFX);
			this.ADBKPGFMNKO().SetFloat("SpawnObj", this.SwitchCameraToCamera2);
			this.HFBJAOFLCJI().SetVector("USE_DIAG_SEARCH", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 968f, 251f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x1700002F RID: 47
	// (get) Token: 0x0600141C RID: 5148 RVA: 0x00084E02 File Offset: 0x00083002
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

	// Token: 0x0600141D RID: 5149 RVA: 0x00084E3C File Offset: 0x0008303C
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("_MainTex2", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600141E RID: 5150 RVA: 0x00084F36 File Offset: 0x00083136
	private void FBIIBKKCOKO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 98);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600141F RID: 5151 RVA: 0x00084F74 File Offset: 0x00083174
	private void KLILJHJNICK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -7);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001420 RID: 5152 RVA: 0x00084FDD File Offset: 0x000831DD
	private void MLAGEPNCCGM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -43);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001421 RID: 5153 RVA: 0x00085018 File Offset: 0x00083218
	private void EPEGAEGDJAM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 77);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001422 RID: 5154 RVA: 0x00085081 File Offset: 0x00083281
	private void HGDDCINLDAD()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001423 RID: 5155 RVA: 0x000850BB File Offset: 0x000832BB
	private void BMHFAMJELFH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 118);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001424 RID: 5156 RVA: 0x00085081 File Offset: 0x00083281
	private void OnDisable()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001425 RID: 5157 RVA: 0x000850F8 File Offset: 0x000832F8
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1493f)
			{
				this.HBJJOCHGOPH = 1898f;
			}
			if (this.Camera2 != null)
			{
				this.LDNADDJMIPK().SetTexture("Parent ID", this.JDMCFBKJHDD);
			}
			this.ADBKPGFMNKO().SetFloat("colorB", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("JoinRandom failed: No open game. Calling: OnPhotonRandomJoinFailed() and staying on master server.", this.BlendFX);
			this.EPCGJFCCAFH().SetFloat("_TimeX", this.SwitchCameraToCamera2);
			this.ADBKPGFMNKO().SetVector("tagElement", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1445f, 1152f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001426 RID: 5158 RVA: 0x000851F2 File Offset: 0x000833F2
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001427 RID: 5159 RVA: 0x00085229 File Offset: 0x00083429
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001428 RID: 5160 RVA: 0x00085260 File Offset: 0x00083460
	private void FELENDJEOGA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -88);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001429 RID: 5161 RVA: 0x0008529B File Offset: 0x0008349B
	private void MPADDMNGJNC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 83);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600142B RID: 5163 RVA: 0x00085081 File Offset: 0x00083281
	private void EJJEDJIOFAB()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600142C RID: 5164 RVA: 0x000852FF File Offset: 0x000834FF
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600142D RID: 5165 RVA: 0x00085336 File Offset: 0x00083536
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600142E RID: 5166 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x0600142F RID: 5167 RVA: 0x00085374 File Offset: 0x00083574
	private void CNGAJDBOCLJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -53);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001430 RID: 5168 RVA: 0x000853DD File Offset: 0x000835DD
	private void LNIOFCGDDKP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 15);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001431 RID: 5169 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06001432 RID: 5170 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06001433 RID: 5171 RVA: 0x00085336 File Offset: 0x00083536
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001434 RID: 5172 RVA: 0x00085418 File Offset: 0x00083618
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 617f)
			{
				this.HBJJOCHGOPH = 564f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("Share", this.JDMCFBKJHDD);
			}
			this.EPCGJFCCAFH().SetFloat("Reset All", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("[MapsData] Found ", this.BlendFX);
			this.EPCGJFCCAFH().SetFloat("UNDISTORT", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("#", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1096f, 50f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001435 RID: 5173 RVA: 0x00085514 File Offset: 0x00083714
	private void PAKPHKPDKGE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 34);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001436 RID: 5174 RVA: 0x0008557D File Offset: 0x0008377D
	private void LOOGLMFBJHK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -26);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001437 RID: 5175 RVA: 0x000855B8 File Offset: 0x000837B8
	private void NNCCPEBIAKH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -21);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001438 RID: 5176 RVA: 0x00085621 File Offset: 0x00083821
	private void INGOODALACO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -72);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001439 RID: 5177 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x0600143A RID: 5178 RVA: 0x0008565C File Offset: 0x0008385C
	private void GPJHPNGNEBP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -104);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600143B RID: 5179 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600143C RID: 5180 RVA: 0x00085697 File Offset: 0x00083897
	private void FGIOPGGPLMB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -103);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600143D RID: 5181 RVA: 0x000856D2 File Offset: 0x000838D2
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)114;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600143E RID: 5182 RVA: 0x00085081 File Offset: 0x00083281
	private void BFEILOMHNPC()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040002CD RID: 717
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Lighten";

	// Token: 0x040002CE RID: 718
	public Shader SCShader;

	// Token: 0x040002CF RID: 719
	public Camera Camera2;

	// Token: 0x040002D0 RID: 720
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040002D1 RID: 721
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040002D2 RID: 722
	private Material BJFKDHHMLJH;

	// Token: 0x040002D3 RID: 723
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x040002D4 RID: 724
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x040002D5 RID: 725
	private RenderTexture JDMCFBKJHDD;
}
