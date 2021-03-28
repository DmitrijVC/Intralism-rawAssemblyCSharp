using System;
using UnityEngine;

// Token: 0x0200003F RID: 63
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/Darken")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_Darken : MonoBehaviour
{
	// Token: 0x06001194 RID: 4500 RVA: 0x00077DDC File Offset: 0x00075FDC
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

	// Token: 0x06001195 RID: 4501 RVA: 0x00077E16 File Offset: 0x00076016
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001196 RID: 4502 RVA: 0x00077E51 File Offset: 0x00076051
	private void GJPONJKJICG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -72);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001197 RID: 4503 RVA: 0x00077E8C File Offset: 0x0007608C
	private void GLGGNBOBFKE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 60);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001198 RID: 4504 RVA: 0x00077EC8 File Offset: 0x000760C8
	private void KIMMMCJFMAB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -74);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001199 RID: 4505 RVA: 0x00077F34 File Offset: 0x00076134
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 202f)
			{
				this.HBJJOCHGOPH = 830f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("[Left]", this.JDMCFBKJHDD);
			}
			this.LDNADDJMIPK().SetFloat("_Value5", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("L1", this.BlendFX);
			this.LDNADDJMIPK().SetFloat("<b>#", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("downloading", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1889f, 1350f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600119A RID: 4506 RVA: 0x00078030 File Offset: 0x00076230
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1672f)
			{
				this.HBJJOCHGOPH = 481f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("event", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("player.yellowarc", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_HeightParams", this.BlendFX);
			this.LDNADDJMIPK().SetFloat("_BlurTexture", this.SwitchCameraToCamera2);
			this.LDNADDJMIPK().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1350f, 329f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600119C RID: 4508 RVA: 0x00078153 File Offset: 0x00076353
	private void FDIJLKIIMLL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 43);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600119D RID: 4509 RVA: 0x00078190 File Offset: 0x00076390
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 992f)
			{
				this.HBJJOCHGOPH = 1818f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("_ScreenResolution", this.JDMCFBKJHDD);
			}
			this.LDNADDJMIPK().SetFloat("Added unlock condition", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("id", this.BlendFX);
			this.LDNADDJMIPK().SetFloat("[Up-Right-Down-Left]", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("/icon", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 63f, 416f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600119E RID: 4510 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600119F RID: 4511 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x060011A0 RID: 4512 RVA: 0x0007828A File Offset: 0x0007648A
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060011A1 RID: 4513 RVA: 0x000782C1 File Offset: 0x000764C1
	private void IFKNIHJCAFB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 40);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060011A2 RID: 4514 RVA: 0x000782FC File Offset: 0x000764FC
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

	// Token: 0x060011A3 RID: 4515 RVA: 0x00078368 File Offset: 0x00076568
	private void DIPDEHOOBPG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 45);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060011A4 RID: 4516 RVA: 0x000783D1 File Offset: 0x000765D1
	private void MFOOCOIIIJN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -14);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060011A5 RID: 4517 RVA: 0x0007840C File Offset: 0x0007660C
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

	// Token: 0x060011A6 RID: 4518 RVA: 0x00078508 File Offset: 0x00076708
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 284f)
			{
				this.HBJJOCHGOPH = 645f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("_ColorBuffer", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("HiddenToggle", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("GLITCH", this.BlendFX);
			this.LDNADDJMIPK().SetFloat("warning: Audio Source: ", this.SwitchCameraToCamera2);
			this.LDNADDJMIPK().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1213f, 1125f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060011A7 RID: 4519 RVA: 0x00077E16 File Offset: 0x00076016
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x17000026 RID: 38
	// (get) Token: 0x060011A8 RID: 4520 RVA: 0x00078602 File Offset: 0x00076802
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

	// Token: 0x060011A9 RID: 4521 RVA: 0x00078639 File Offset: 0x00076839
	private void OFBLDOCCBBN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -117);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060011AA RID: 4522 RVA: 0x00078674 File Offset: 0x00076874
	private void GPJHPNGNEBP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -58);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x04000277 RID: 631
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Darken";

	// Token: 0x04000278 RID: 632
	public Shader SCShader;

	// Token: 0x04000279 RID: 633
	public Camera Camera2;

	// Token: 0x0400027A RID: 634
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400027B RID: 635
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400027C RID: 636
	private Material BJFKDHHMLJH;

	// Token: 0x0400027D RID: 637
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x0400027E RID: 638
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x0400027F RID: 639
	private RenderTexture JDMCFBKJHDD;
}
