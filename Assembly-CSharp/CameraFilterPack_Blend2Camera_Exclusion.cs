using System;
using UnityEngine;

// Token: 0x02000043 RID: 67
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/Exclusion")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_Exclusion : MonoBehaviour
{
	// Token: 0x0600124A RID: 4682 RVA: 0x0007B586 File Offset: 0x00079786
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600124B RID: 4683 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x1700002A RID: 42
	// (get) Token: 0x0600124C RID: 4684 RVA: 0x0007B5C1 File Offset: 0x000797C1
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

	// Token: 0x0600124D RID: 4685 RVA: 0x0007B5F8 File Offset: 0x000797F8
	private void MMMDPANNAIO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -71);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600124E RID: 4686 RVA: 0x0007B664 File Offset: 0x00079864
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1854f)
			{
				this.HBJJOCHGOPH = 227f;
			}
			if (this.Camera2 != null)
			{
				this.DOHGBNPMBKG().SetTexture("Warning: Unhandled Event ErrorInfo (251). Set PhotonNetwork.OnEventCall to the method PUN should call for this event.", this.JDMCFBKJHDD);
			}
			this.KGOLDDBHIFN().SetFloat("_History1ChromaTex", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("/Segment-[Right]", this.BlendFX);
			this.NFMGLIKNOOC().SetFloat("_BlurRadius4", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1583f, 148f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600124F RID: 4687 RVA: 0x0007B75E File Offset: 0x0007995E
	private void HJDPEBAPBPN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 70);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001250 RID: 4688 RVA: 0x0007B79C File Offset: 0x0007999C
	private void NCNPAKFAFOE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 75);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001251 RID: 4689 RVA: 0x0007B805 File Offset: 0x00079A05
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001252 RID: 4690 RVA: 0x0007B83C File Offset: 0x00079A3C
	private void FDIJLKIIMLL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 103);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001253 RID: 4691 RVA: 0x0007B878 File Offset: 0x00079A78
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

	// Token: 0x06001254 RID: 4692 RVA: 0x0007B8E4 File Offset: 0x00079AE4
	private void KIMMMCJFMAB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 88);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001255 RID: 4693 RVA: 0x0007B94D File Offset: 0x00079B4D
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

	// Token: 0x06001256 RID: 4694 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06001257 RID: 4695 RVA: 0x0007B987 File Offset: 0x00079B87
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001258 RID: 4696 RVA: 0x0007B9BE File Offset: 0x00079BBE
	private void JNACKHNNEPA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 38);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600125A RID: 4698 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600125B RID: 4699 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x0600125C RID: 4700 RVA: 0x0007BA22 File Offset: 0x00079C22
	private void ELANJOHIJME()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -113);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600125D RID: 4701 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x0600125E RID: 4702 RVA: 0x0007BA60 File Offset: 0x00079C60
	private void CCLNNLCOPBL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -38);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600125F RID: 4703 RVA: 0x0007B586 File Offset: 0x00079786
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001260 RID: 4704 RVA: 0x0007BACC File Offset: 0x00079CCC
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

	// Token: 0x06001261 RID: 4705 RVA: 0x0007BBC6 File Offset: 0x00079DC6
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001262 RID: 4706 RVA: 0x0007BC00 File Offset: 0x00079E00
	private void DAHFFNNIGML()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 2);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001263 RID: 4707 RVA: 0x0007BC6C File Offset: 0x00079E6C
	private void HLIAEEMGBHN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 71);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001264 RID: 4708 RVA: 0x0007BCD8 File Offset: 0x00079ED8
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1398f)
			{
				this.HBJJOCHGOPH = 1839f;
			}
			if (this.Camera2 != null)
			{
				this.NFMGLIKNOOC().SetTexture("PUNCloudBestRegion", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("_Value4", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("Tab2Content", this.BlendFX);
			this.DOHGBNPMBKG().SetFloat("[Right]", this.SwitchCameraToCamera2);
			this.NFMGLIKNOOC().SetVector("checkpoint", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 20f, 889f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001265 RID: 4709 RVA: 0x0007BDD4 File Offset: 0x00079FD4
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1132f)
			{
				this.HBJJOCHGOPH = 555f;
			}
			if (this.Camera2 != null)
			{
				this.PDEAHJPOMEF().SetTexture("UseScanLine", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("</b>", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("workshop.txt", this.BlendFX);
			this.PDEAHJPOMEF().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this.SwitchCameraToCamera2);
			this.PDEAHJPOMEF().SetVector("{0}{1}{2}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1285f, 1077f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001266 RID: 4710 RVA: 0x0007BECE File Offset: 0x0007A0CE
	private void EMAMCDFBGOA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 69);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001267 RID: 4711 RVA: 0x0007BF0C File Offset: 0x0007A10C
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1125f)
			{
				this.HBJJOCHGOPH = 1941f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("_NeighbourMaxTex", this.JDMCFBKJHDD);
			}
			this.NFMGLIKNOOC().SetFloat("float,1", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("stretchWidth", this.BlendFX);
			this.KGOLDDBHIFN().SetFloat("time", this.SwitchCameraToCamera2);
			this.IONHGBPGCHK().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1510f, 6f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001268 RID: 4712 RVA: 0x0007C006 File Offset: 0x0007A206
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001269 RID: 4713 RVA: 0x0007B94D File Offset: 0x00079B4D
	private void PAEGLMEOKHP()
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

	// Token: 0x0600126A RID: 4714 RVA: 0x0007C040 File Offset: 0x0007A240
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1198f)
			{
				this.HBJJOCHGOPH = 295f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("0 seconds", this.JDMCFBKJHDD);
			}
			this.NFMGLIKNOOC().SetFloat("float,0", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("#yes", this.BlendFX);
			this.DOHGBNPMBKG().SetFloat("ShowTitle", this.SwitchCameraToCamera2);
			this.DOHGBNPMBKG().SetVector("Tab2Content", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 746f, 1161f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600126B RID: 4715 RVA: 0x0007B94D File Offset: 0x00079B4D
	private void DPFOEBCADNP()
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

	// Token: 0x0600126C RID: 4716 RVA: 0x0007C13A File Offset: 0x0007A33A
	private void IBEAPBDAOCC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 107);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600126D RID: 4717 RVA: 0x0007C175 File Offset: 0x0007A375
	private void IFBKMAEMKNN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 102);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600126E RID: 4718 RVA: 0x0007C1B0 File Offset: 0x0007A3B0
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 276f)
			{
				this.HBJJOCHGOPH = 729f;
			}
			if (this.Camera2 != null)
			{
				this.DOHGBNPMBKG().SetTexture("[Up-Down]", this.JDMCFBKJHDD);
			}
			this.DOHGBNPMBKG().SetFloat(" ", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("_Screen", this.BlendFX);
			this.KGOLDDBHIFN().SetFloat("[PlayerBase] Loaded custom model: ", this.SwitchCameraToCamera2);
			this.KGOLDDBHIFN().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 287f, 931f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600126F RID: 4719 RVA: 0x0007C2AA File Offset: 0x0007A4AA
	private void GHICDLBKEJN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -9);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001270 RID: 4720 RVA: 0x0007C2E5 File Offset: 0x0007A4E5
	private void CNHEENCFCMF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -46);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001271 RID: 4721 RVA: 0x0007C320 File Offset: 0x0007A520
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)88;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001272 RID: 4722 RVA: 0x0007C357 File Offset: 0x0007A557
	private void FINDGJLEHOL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -44);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001273 RID: 4723 RVA: 0x0007C392 File Offset: 0x0007A592
	private void LOOGLMFBJHK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 40);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001274 RID: 4724 RVA: 0x0007B94D File Offset: 0x00079B4D
	private void OFIMMFHFHDD()
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

	// Token: 0x0400029B RID: 667
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Exclusion";

	// Token: 0x0400029C RID: 668
	public Shader SCShader;

	// Token: 0x0400029D RID: 669
	public Camera Camera2;

	// Token: 0x0400029E RID: 670
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400029F RID: 671
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040002A0 RID: 672
	private Material BJFKDHHMLJH;

	// Token: 0x040002A1 RID: 673
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x040002A2 RID: 674
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x040002A3 RID: 675
	private RenderTexture JDMCFBKJHDD;
}
