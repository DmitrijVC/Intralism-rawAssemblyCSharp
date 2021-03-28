using System;
using UnityEngine;

// Token: 0x0200010E RID: 270
[AddComponentMenu("Camera Filter Pack/TV/ARCADE")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_ARCADE : MonoBehaviour
{
	// Token: 0x0600540A RID: 21514 RVA: 0x001A0BD1 File Offset: 0x0019EDD1
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x170000F3 RID: 243
	// (get) Token: 0x0600540B RID: 21515 RVA: 0x001A0BEE File Offset: 0x0019EDEE
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

	// Token: 0x0600540C RID: 21516 RVA: 0x001A0BD1 File Offset: 0x0019EDD1
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600540D RID: 21517 RVA: 0x001A0BD1 File Offset: 0x0019EDD1
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600540E RID: 21518 RVA: 0x001A0C25 File Offset: 0x0019EE25
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600540F RID: 21519 RVA: 0x001A0C5C File Offset: 0x0019EE5C
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 481f)
			{
				this.HBJJOCHGOPH = 1117f;
			}
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat(".lastCheckpoint.comboScore", this.Fade);
			this.NBMPPNFKFLB().SetVector("OnStatusChanged: {0} current State: {1}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 86f, 1692f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005410 RID: 21520 RVA: 0x001A0D1C File Offset: 0x0019EF1C
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1700f)
			{
				this.HBJJOCHGOPH = 1704f;
			}
			this.PDEAHJPOMEF().SetFloat("_TapLow", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("/", this.Fade);
			this.PDEAHJPOMEF().SetVector("New resource ID. Case-Sensitive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 246f, 1672f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005411 RID: 21521 RVA: 0x001A0DD9 File Offset: 0x0019EFD9
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_ARCADE");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005412 RID: 21522 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06005413 RID: 21523 RVA: 0x001A0DFD File Offset: 0x0019EFFD
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("\" error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005414 RID: 21524 RVA: 0x001A0E24 File Offset: 0x0019F024
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1563f)
			{
				this.HBJJOCHGOPH = 1743f;
			}
			this.NDMPCDHADMJ().SetFloat("Show Title", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Vision_Drost", this.Fade);
			this.NBPKMLMCHFN.SetVector("CameraFilterPack/Drawing_Halftone", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 204f, 1535f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005415 RID: 21525 RVA: 0x001A0EE1 File Offset: 0x0019F0E1
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005416 RID: 21526 RVA: 0x001A0BD1 File Offset: 0x0019EDD1
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005417 RID: 21527 RVA: 0x001A0F18 File Offset: 0x0019F118
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("OpAuthenticate()");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005418 RID: 21528 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06005419 RID: 21529 RVA: 0x001A0F3C File Offset: 0x0019F13C
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("UpperMid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600541A RID: 21530 RVA: 0x001A0F60 File Offset: 0x0019F160
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 362f)
			{
				this.HBJJOCHGOPH = 1326f;
			}
			this.FAIFBBGFAIB().SetFloat("_Size", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("[PlayerController] ", this.Fade);
			this.DOHGBNPMBKG().SetVector("_Y", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1742f, 1688f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600541B RID: 21531 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x0600541C RID: 21532 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x0600541D RID: 21533 RVA: 0x001A101D File Offset: 0x0019F21D
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600541E RID: 21534 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600541F RID: 21535 RVA: 0x001A0BD1 File Offset: 0x0019EDD1
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005421 RID: 21537 RVA: 0x001A1072 File Offset: 0x0019F272
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("End index must in an integer.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005422 RID: 21538 RVA: 0x001A0BD1 File Offset: 0x0019EDD1
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005423 RID: 21539 RVA: 0x001A0BD1 File Offset: 0x0019EDD1
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005424 RID: 21540 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06005425 RID: 21541 RVA: 0x001A1098 File Offset: 0x0019F298
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 854f)
			{
				this.HBJJOCHGOPH = 1083f;
			}
			this.NBMPPNFKFLB().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat(".played", this.Fade);
			this.NBMPPNFKFLB().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1669f, 144f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005426 RID: 21542 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06005427 RID: 21543 RVA: 0x001A1158 File Offset: 0x0019F358
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 893f)
			{
				this.HBJJOCHGOPH = 398f;
			}
			this.DOHGBNPMBKG().SetFloat("_Value1", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("Connecting", this.Fade);
			this.FAIFBBGFAIB().SetVector("Joystick1Button11", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 953f, 508f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005428 RID: 21544 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x06005429 RID: 21545 RVA: 0x001A0BD1 File Offset: 0x0019EDD1
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600542A RID: 21546 RVA: 0x001A0BD1 File Offset: 0x0019EDD1
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600542B RID: 21547 RVA: 0x001A1218 File Offset: 0x0019F418
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1898f)
			{
				this.HBJJOCHGOPH = 1825f;
			}
			this.PDEAHJPOMEF().SetFloat("Object ID. Case-Sensitive", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("maps.", this.Fade);
			this.NBMPPNFKFLB().SetVector("_Value5", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1815f, 1419f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600542C RID: 21548 RVA: 0x001A12D5 File Offset: 0x0019F4D5
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find(".png");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600542D RID: 21549 RVA: 0x001A12FC File Offset: 0x0019F4FC
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
			this.NBPKMLMCHFN.SetFloat("Fade", this.Fade);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600542E RID: 21550 RVA: 0x001A0BD1 File Offset: 0x0019EDD1
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600542F RID: 21551 RVA: 0x001A0BD1 File Offset: 0x0019EDD1
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005430 RID: 21552 RVA: 0x001A13B9 File Offset: 0x0019F5B9
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005431 RID: 21553 RVA: 0x001A13F0 File Offset: 0x0019F5F0
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1806f)
			{
				this.HBJJOCHGOPH = 53f;
			}
			this.NDMPCDHADMJ().SetFloat("Mouse Wheel Up", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.Fade);
			this.DOHGBNPMBKG().SetVector("PointerEnter ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1012f, 704f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005432 RID: 21554 RVA: 0x001A0BD1 File Offset: 0x0019EDD1
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005433 RID: 21555 RVA: 0x001A0BD1 File Offset: 0x0019EDD1
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005434 RID: 21556 RVA: 0x001A14AD File Offset: 0x0019F6AD
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005435 RID: 21557 RVA: 0x001A14E4 File Offset: 0x0019F6E4
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1911f)
			{
				this.HBJJOCHGOPH = 157f;
			}
			this.NBPKMLMCHFN.SetFloat("*.workshop.json", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("_Intensity", this.Fade);
			this.NBMPPNFKFLB().SetVector("_DiffuseColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1712f, 1119f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005436 RID: 21558 RVA: 0x001A15A4 File Offset: 0x0019F7A4
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1039f)
			{
				this.HBJJOCHGOPH = 1979f;
			}
			this.DOHGBNPMBKG().SetFloat("Selection Box", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("Please specify either t or f.", this.Fade);
			this.NBMPPNFKFLB().SetVector("_MainTex2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 603f, 582f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x040008C5 RID: 2245
	public Shader SCShader;

	// Token: 0x040008C6 RID: 2246
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040008C7 RID: 2247
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040008C8 RID: 2248
	private Material BJFKDHHMLJH;

	// Token: 0x040008C9 RID: 2249
	[Range(0f, 1f)]
	public float Fade = 1f;
}
