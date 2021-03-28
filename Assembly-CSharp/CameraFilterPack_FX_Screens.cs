using System;
using UnityEngine;

// Token: 0x020000D4 RID: 212
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/FX/Screens")]
public class CameraFilterPack_FX_Screens : MonoBehaviour
{
	// Token: 0x06004054 RID: 16468 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x06004055 RID: 16469 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x06004056 RID: 16470 RVA: 0x0013E17C File Offset: 0x0013C37C
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1717f)
			{
				this.HBJJOCHGOPH = 946f;
			}
			this.BFGNMFCNDBC().SetFloat("_Value5", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("{0}", this.Tiles);
			this.PHGCJOPFDOG().SetFloat("GlassesColor2", this.Speed);
			this.DEFBJOCJJKF().SetFloat("Case-Sensitive", this.PosX);
			this.NBPKMLMCHFN.SetFloat("speed", this.PosY);
			this.BFGNMFCNDBC().SetColor("Tab2Content", this.color);
			this.BFGNMFCNDBC().SetVector("_RedAmplifier", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1637f, 280f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004057 RID: 16471 RVA: 0x0013E291 File Offset: 0x0013C491
	private Material BKKJJJGADLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004058 RID: 16472 RVA: 0x0013E2C8 File Offset: 0x0013C4C8
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004059 RID: 16473 RVA: 0x0013E2E5 File Offset: 0x0013C4E5
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("[NetworkManager] Updating rooms...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600405A RID: 16474 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x0600405B RID: 16475 RVA: 0x0013E309 File Offset: 0x0013C509
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("_Sat");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600405C RID: 16476 RVA: 0x0013E2C8 File Offset: 0x0013C4C8
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600405D RID: 16477 RVA: 0x0013E2C8 File Offset: 0x0013C4C8
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600405E RID: 16478 RVA: 0x0013E2C8 File Offset: 0x0013C4C8
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x170000BA RID: 186
	// (get) Token: 0x0600405F RID: 16479 RVA: 0x0013E32D File Offset: 0x0013C52D
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

	// Token: 0x06004060 RID: 16480 RVA: 0x0013E364 File Offset: 0x0013C564
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("PunPickupSimple");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004061 RID: 16481 RVA: 0x0013E2C8 File Offset: 0x0013C4C8
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004062 RID: 16482 RVA: 0x0013E388 File Offset: 0x0013C588
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 464f)
			{
				this.HBJJOCHGOPH = 661f;
			}
			this.PDEAHJPOMEF().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("maps.", this.Tiles);
			this.FHFLKLMFHOI().SetFloat("Save", this.Speed);
			this.CIAFLBFJLEJ().SetFloat("_ScreenResolution", this.PosX);
			this.DKKBFFHBHJE().SetFloat("materialsitemid[", this.PosY);
			this.NJDIODJNGGA().SetColor(" Owner called.", this.color);
			this.NJDIODJNGGA().SetVector("DPADHOR", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1068f, 1629f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004063 RID: 16483 RVA: 0x0013E49D File Offset: 0x0013C69D
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004064 RID: 16484 RVA: 0x0013E4D4 File Offset: 0x0013C6D4
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find("_OcclusionBlurTexture");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004065 RID: 16485 RVA: 0x0002523B File Offset: 0x0002343B
	private void FGNFILLNPJK()
	{
	}

	// Token: 0x06004066 RID: 16486 RVA: 0x0013E4F8 File Offset: 0x0013C6F8
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004067 RID: 16487 RVA: 0x0013E51C File Offset: 0x0013C71C
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004068 RID: 16488 RVA: 0x0013E2C8 File Offset: 0x0013C4C8
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004069 RID: 16489 RVA: 0x0013E553 File Offset: 0x0013C753
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("y");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600406A RID: 16490 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x0600406B RID: 16491 RVA: 0x0013E577 File Offset: 0x0013C777
	private void JKBMKPDGCHG()
	{
		this.SCShader = Shader.Find(",");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600406C RID: 16492 RVA: 0x0013E59B File Offset: 0x0013C79B
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600406D RID: 16493 RVA: 0x0013E5D4 File Offset: 0x0013C7D4
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1914f)
			{
				this.HBJJOCHGOPH = 1631f;
			}
			this.HKHBBBFLGJH().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("\"", this.Tiles);
			this.NJDIODJNGGA().SetFloat(": ", this.Speed);
			this.PHGCJOPFDOG().SetFloat("Mouse Y", this.PosX);
			this.HKHBBBFLGJH().SetFloat("CompletedLevel", this.PosY);
			this.PDEAHJPOMEF().SetColor("HPToggle", this.color);
			this.DKNJGHFLAIF().SetVector("\r", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1901f, 82f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600406E RID: 16494 RVA: 0x0013E2C8 File Offset: 0x0013C4C8
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600406F RID: 16495 RVA: 0x0013E6E9 File Offset: 0x0013C8E9
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004070 RID: 16496 RVA: 0x0013E720 File Offset: 0x0013C920
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1009f)
			{
				this.HBJJOCHGOPH = 163f;
			}
			this.HKGAONMOBMH().SetFloat("SetPlayerDistance", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("_RampTex", this.Tiles);
			this.BKKJJJGADLM().SetFloat("_Value4", this.Speed);
			this.NBPKMLMCHFN.SetFloat("SupportLogger OnJoinedLobby(", this.PosX);
			this.HEINDEMCGIK().SetFloat("Obtain promo Item", this.PosY);
			this.ABHDNGIHBKE().SetColor("_CenterY", this.color);
			this.DKNJGHFLAIF().SetVector("AvatarImage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1979f, 555f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004071 RID: 16497 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06004072 RID: 16498 RVA: 0x0013E838 File Offset: 0x0013CA38
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1948f)
			{
				this.HBJJOCHGOPH = 1684f;
			}
			this.MJJIEHANFJA().SetFloat("Hidden/Image Effects/Cinematic/AmbientOcclusion", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("_Value7", this.Tiles);
			this.HHIAIGCAHDA().SetFloat("_Value", this.Speed);
			this.HKHBBBFLGJH().SetFloat("_SmoothEnd", this.PosX);
			this.PDEAHJPOMEF().SetFloat("RarityImage", this.PosY);
			this.FHFLKLMFHOI().SetColor("<b>", this.color);
			this.BKKJJJGADLM().SetVector("cmd.exe", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 578f, 390f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004073 RID: 16499 RVA: 0x0002523B File Offset: 0x0002343B
	private void KDJEJBBDILE()
	{
	}

	// Token: 0x06004074 RID: 16500 RVA: 0x0013E950 File Offset: 0x0013CB50
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Tiles);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.PosX);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.PosY);
			this.NBPKMLMCHFN.SetColor("_color", this.color);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004075 RID: 16501 RVA: 0x0013EA65 File Offset: 0x0013CC65
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004076 RID: 16502 RVA: 0x0013E2C8 File Offset: 0x0013C4C8
	private void BDBJEDIOKBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004077 RID: 16503 RVA: 0x0013EA89 File Offset: 0x0013CC89
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004078 RID: 16504 RVA: 0x0013EAC0 File Offset: 0x0013CCC0
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004079 RID: 16505 RVA: 0x0013EAE4 File Offset: 0x0013CCE4
	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 699f)
			{
				this.HBJJOCHGOPH = 1652f;
			}
			this.KAFBNOBOIAJ().SetFloat("settings.volume.game", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("Freq: ", this.Tiles);
			this.FHFLKLMFHOI().SetFloat("JoinRandomRoom failed. In offline mode you still have to leave a room to enter another.", this.Speed);
			this.PHGCJOPFDOG().SetFloat(".icon", this.PosX);
			this.HKGAONMOBMH().SetFloat("Metal", this.PosY);
			this.ABHDNGIHBKE().SetColor("x", this.color);
			this.BFGNMFCNDBC().SetVector("_CenterX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1782f, 1700f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600407B RID: 16507 RVA: 0x0013EC4F File Offset: 0x0013CE4F
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600407C RID: 16508 RVA: 0x0013E51C File Offset: 0x0013C71C
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600407D RID: 16509 RVA: 0x0013EC74 File Offset: 0x0013CE74
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 2f)
			{
				this.HBJJOCHGOPH = 75f;
			}
			this.ABHDNGIHBKE().SetFloat("22x3", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("SUBMIT '{0}' FILES", this.Tiles);
			this.HHIAIGCAHDA().SetFloat("Texture2", this.Speed);
			this.PHGCJOPFDOG().SetFloat("_Value3", this.PosX);
			this.OLHDPICFBOF().SetFloat("SetSpeed", this.PosY);
			this.NJDIODJNGGA().SetColor("1", this.color);
			this.DEFBJOCJJKF().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1686f, 470f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600407E RID: 16510 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x0600407F RID: 16511 RVA: 0x0013ED89 File Offset: 0x0013CF89
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004080 RID: 16512 RVA: 0x0013EDC0 File Offset: 0x0013CFC0
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004081 RID: 16513 RVA: 0x0013E2C8 File Offset: 0x0013C4C8
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004082 RID: 16514 RVA: 0x0013EDF8 File Offset: 0x0013CFF8
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 110f)
			{
				this.HBJJOCHGOPH = 761f;
			}
			this.BKKJJJGADLM().SetFloat("[NetworkScene] Exited", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("_ScreenResolution", this.Tiles);
			this.BKKJJJGADLM().SetFloat("Can't connect: ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", this.Speed);
			this.DKNJGHFLAIF().SetFloat("OnEvent: {0}", this.PosX);
			this.HKHBBBFLGJH().SetFloat("_TimeX", this.PosY);
			this.KEMAALEODNH().SetColor("[MapEditor] Updating map assets", this.color);
			this.CIAFLBFJLEJ().SetVector("_Amount", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1574f, 1800f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004083 RID: 16515 RVA: 0x0013EF0D File Offset: 0x0013D10D
	private Material MJJIEHANFJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004084 RID: 16516 RVA: 0x0013EF44 File Offset: 0x0013D144
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find(".workshop.json");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004085 RID: 16517 RVA: 0x0013EF68 File Offset: 0x0013D168
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 308f)
			{
				this.HBJJOCHGOPH = 1749f;
			}
			this.HKGAONMOBMH().SetFloat("Joystick1Button4", this.HBJJOCHGOPH);
			this.NJDIODJNGGA().SetFloat("ShadersToggle", this.Tiles);
			this.HHIAIGCAHDA().SetFloat("Lag ", this.Speed);
			this.LPMLLJKMAMP().SetFloat("_Parasite", this.PosX);
			this.ABHDNGIHBKE().SetFloat("Keeping GameObject in the scene: ", this.PosY);
			this.LPMLLJKMAMP().SetColor("D-Pad Down", this.color);
			this.EOCCJGIGEGJ().SetVector(" timeUntilRespawnBasedOnTimeBase:", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1556f, 1787f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004086 RID: 16518 RVA: 0x0013F07D File Offset: 0x0013D27D
	private Material NJDIODJNGGA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004087 RID: 16519 RVA: 0x0013F0B4 File Offset: 0x0013D2B4
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004088 RID: 16520 RVA: 0x0013E2C8 File Offset: 0x0013C4C8
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004089 RID: 16521 RVA: 0x0013F0EB File Offset: 0x0013D2EB
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find(".completedMaps");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600408A RID: 16522 RVA: 0x0013F110 File Offset: 0x0013D310
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1226f)
			{
				this.HBJJOCHGOPH = 1751f;
			}
			this.EOCCJGIGEGJ().SetFloat("_Value7", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("Map id for", this.Tiles);
			this.EOCCJGIGEGJ().SetFloat("Overlay", this.Speed);
			this.NJDIODJNGGA().SetFloat("CameraFilterPack/FX_Hypno", this.PosX);
			this.NBPKMLMCHFN.SetFloat("/", this.PosY);
			this.HKHBBBFLGJH().SetColor("tolobby", this.color);
			this.FAIFBBGFAIB().SetVector("CameraFilterPack/Glow_Glow", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1727f, 323f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600408B RID: 16523 RVA: 0x0002523B File Offset: 0x0002343B
	private void GFACKFCEIBC()
	{
	}

	// Token: 0x0600408C RID: 16524 RVA: 0x0013F225 File Offset: 0x0013D425
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("Run a command for the Localization Servise");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600408D RID: 16525 RVA: 0x0013F249 File Offset: 0x0013D449
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600408E RID: 16526 RVA: 0x0013F280 File Offset: 0x0013D480
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 418f)
			{
				this.HBJJOCHGOPH = 797f;
			}
			this.CIAFLBFJLEJ().SetFloat("Indie", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat(" to: ", this.Tiles);
			this.DNLMFEGJJDD().SetFloat("offsets", this.Speed);
			this.ABHDNGIHBKE().SetFloat("id", this.PosX);
			this.PDEAHJPOMEF().SetFloat("Switch environment sprite image", this.PosY);
			this.PDEAHJPOMEF().SetColor("settings.crosshairopacity", this.color);
			this.EPCGJFCCAFH().SetVector("GroupNameText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 437f, 469f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600408F RID: 16527 RVA: 0x0013E2C8 File Offset: 0x0013C4C8
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004090 RID: 16528 RVA: 0x0013F398 File Offset: 0x0013D598
	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1360f)
			{
				this.HBJJOCHGOPH = 1301f;
			}
			this.CIAFLBFJLEJ().SetFloat("_FadeFX", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("null", this.Tiles);
			this.EPCGJFCCAFH().SetFloat("_Value2", this.Speed);
			this.DEFBJOCJJKF().SetFloat("Set particless emission (glow)", this.PosX);
			this.PHGCJOPFDOG().SetFloat("0 - default, 1 - left, 2 - right", this.PosY);
			this.KAFBNOBOIAJ().SetColor("Connection error: ", this.color);
			this.HEINDEMCGIK().SetVector("skin.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 281f, 825f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004091 RID: 16529 RVA: 0x0013F4AD File Offset: 0x0013D6AD
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004092 RID: 16530 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06004093 RID: 16531 RVA: 0x0013F4E4 File Offset: 0x0013D6E4
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)114;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004094 RID: 16532 RVA: 0x0013E2C8 File Offset: 0x0013C4C8
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004095 RID: 16533 RVA: 0x0013E2C8 File Offset: 0x0013C4C8
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004096 RID: 16534 RVA: 0x0013E2C8 File Offset: 0x0013C4C8
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004097 RID: 16535 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x06004098 RID: 16536 RVA: 0x0013E2C8 File Offset: 0x0013C4C8
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004099 RID: 16537 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x0600409A RID: 16538 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x0600409B RID: 16539 RVA: 0x0013F51C File Offset: 0x0013D71C
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1259f)
			{
				this.HBJJOCHGOPH = 1737f;
			}
			this.HKHBBBFLGJH().SetFloat(".played", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("_TexelOffsetScale", this.Tiles);
			this.FHFLKLMFHOI().SetFloat("menu.playedsolo", this.Speed);
			this.HKGAONMOBMH().SetFloat("Start index must in an integer.", this.PosX);
			this.FHFLKLMFHOI().SetFloat("speed", this.PosY);
			this.MJJIEHANFJA().SetColor("SpawnObj", this.color);
			this.HKGAONMOBMH().SetVector("0.00", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1307f, 1688f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600409C RID: 16540 RVA: 0x0013F631 File Offset: 0x0013D831
	private void MJEFMIPLFAB()
	{
		this.SCShader = Shader.Find("Attempting to remove texture that was not allocated: {0}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600409D RID: 16541 RVA: 0x0013F658 File Offset: 0x0013D858
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 550f)
			{
				this.HBJJOCHGOPH = 565f;
			}
			this.ABHDNGIHBKE().SetFloat("cipherText", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("_AlphaHexa", this.Tiles);
			this.HKGAONMOBMH().SetFloat("_TimeX", this.Speed);
			this.FAIFBBGFAIB().SetFloat("_SceneFogMode", this.PosX);
			this.BKKJJJGADLM().SetFloat("ticket", this.PosY);
			this.OLHDPICFBOF().SetColor(" : ", this.color);
			this.PHGCJOPFDOG().SetVector("Editor/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 589f, 586f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600409E RID: 16542 RVA: 0x0013F76D File Offset: 0x0013D96D
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find(" takes from: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600409F RID: 16543 RVA: 0x0013F791 File Offset: 0x0013D991
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060040A0 RID: 16544 RVA: 0x0013F7C8 File Offset: 0x0013D9C8
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 406f)
			{
				this.HBJJOCHGOPH = 134f;
			}
			this.HHIAIGCAHDA().SetFloat("[MapEditor] Loaded music file: ", this.HBJJOCHGOPH);
			this.PHGCJOPFDOG().SetFloat("_TapLowForeground", this.Tiles);
			this.BKKJJJGADLM().SetFloat("_Offsets", this.Speed);
			this.KAFBNOBOIAJ().SetFloat("float,1.5", this.PosX);
			this.LPMLLJKMAMP().SetFloat("CameraFilterPack/Glasses_OnX", this.PosY);
			this.PDEAHJPOMEF().SetColor("Keypad", this.color);
			this.MJJIEHANFJA().SetVector("EventData0DropDownList", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1427f, 1337f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060040A1 RID: 16545 RVA: 0x0013F8E0 File Offset: 0x0013DAE0
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 53f)
			{
				this.HBJJOCHGOPH = 1317f;
			}
			this.DEFBJOCJJKF().SetFloat("ok", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("_EmissionColor", this.Tiles);
			this.HKHBBBFLGJH().SetFloat("VIGNETTE_DESAT", this.Speed);
			this.FAIFBBGFAIB().SetFloat(" not exist", this.PosX);
			this.KAFBNOBOIAJ().SetFloat("_Intensity", this.PosY);
			this.MJJIEHANFJA().SetColor("_ScreenResolution", this.color);
			this.DNLMFEGJJDD().SetVector("workshop.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1073f, 252f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060040A2 RID: 16546 RVA: 0x0013F9F5 File Offset: 0x0013DBF5
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("g");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060040A3 RID: 16547 RVA: 0x0013FA1C File Offset: 0x0013DC1C
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1608f)
			{
				this.HBJJOCHGOPH = 1112f;
			}
			this.OLHDPICFBOF().SetFloat("_History1LumaTex", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetFloat("CameraFilterPack/Distortion_Aspiration", this.Tiles);
			this.PDEAHJPOMEF().SetFloat("settings.shaders", this.Speed);
			this.OIIDAKBILMI().SetFloat("MapConfig", this.PosX);
			this.BKKJJJGADLM().SetFloat("In Map Editor", this.PosY);
			this.PDEAHJPOMEF().SetColor("SetSatelliteColor", this.color);
			this.EPCGJFCCAFH().SetVector("offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 477f, 603f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060040A4 RID: 16548 RVA: 0x0013FB34 File Offset: 0x0013DD34
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1584f)
			{
				this.HBJJOCHGOPH = 168f;
			}
			this.MJJIEHANFJA().SetFloat("float,1", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat(".lastCheckpoint.powerupsScore", this.Tiles);
			this.OLHDPICFBOF().SetFloat("[Right]", this.Speed);
			this.LPMLLJKMAMP().SetFloat("/", this.PosX);
			this.DEFBJOCJJKF().SetFloat("skin.", this.PosY);
			this.HKHBBBFLGJH().SetColor("_ScreenResolution", this.color);
			this.FHFLKLMFHOI().SetVector("Tab1Content", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1351f, 1968f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060040A5 RID: 16549 RVA: 0x0013FC49 File Offset: 0x0013DE49
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060040A6 RID: 16550 RVA: 0x0013FC80 File Offset: 0x0013DE80
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1834f)
			{
				this.HBJJOCHGOPH = 1096f;
			}
			this.PDEAHJPOMEF().SetFloat("_Val", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("_TimeX", this.Tiles);
			this.HEINDEMCGIK().SetFloat("settings.volume.game", this.Speed);
			this.KAFBNOBOIAJ().SetFloat("LevelNameInputField", this.PosX);
			this.HKGAONMOBMH().SetFloat("Skipping EstablishEncryption. Protocol is secure.", this.PosY);
			this.MJJIEHANFJA().SetColor("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception", this.color);
			this.NBPKMLMCHFN.SetVector("PLEASE WAIT", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1845f, 362f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060040A7 RID: 16551 RVA: 0x0013E2C8 File Offset: 0x0013C4C8
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060040A8 RID: 16552 RVA: 0x0013FD98 File Offset: 0x0013DF98
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1979f)
			{
				this.HBJJOCHGOPH = 627f;
			}
			this.KAFBNOBOIAJ().SetFloat("[MapsData] Found ", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("(?<=#)\\w+", this.Tiles);
			this.CIAFLBFJLEJ().SetFloat("_TimeX", this.Speed);
			this.HKGAONMOBMH().SetFloat("_Value3", this.PosX);
			this.OIIDAKBILMI().SetFloat("Joystick1Button4", this.PosY);
			this.DKNJGHFLAIF().SetColor("float,0", this.color);
			this.EOCCJGIGEGJ().SetVector("_SpawnHeuristic", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 58f, 1209f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060040A9 RID: 16553 RVA: 0x0013E2C8 File Offset: 0x0013C4C8
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060040AA RID: 16554 RVA: 0x0013E59B File Offset: 0x0013C79B
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060040AB RID: 16555 RVA: 0x0013E2C8 File Offset: 0x0013C4C8
	private void NNBCLMJGFEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060040AC RID: 16556 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x060040AD RID: 16557 RVA: 0x0013FEB0 File Offset: 0x0013E0B0
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 127f)
			{
				this.HBJJOCHGOPH = 10f;
			}
			this.ABHDNGIHBKE().SetFloat("_DepthLevel", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("_ReflectionTexture3", this.Tiles);
			this.HKGAONMOBMH().SetFloat("00", this.Speed);
			this.EPCGJFCCAFH().SetFloat("violet", this.PosX);
			this.ABHDNGIHBKE().SetFloat("MapCreationCanvas", this.PosY);
			this.BFGNMFCNDBC().SetColor(" ; ", this.color);
			this.DKNJGHFLAIF().SetVector(" not exist", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 750f, 383f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060040AE RID: 16558 RVA: 0x0013E2C8 File Offset: 0x0013C4C8
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060040AF RID: 16559 RVA: 0x0013E6E9 File Offset: 0x0013C8E9
	private Material PHGCJOPFDOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060040B0 RID: 16560 RVA: 0x0013FFC8 File Offset: 0x0013E1C8
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 424f)
			{
				this.HBJJOCHGOPH = 51f;
			}
			this.DKNJGHFLAIF().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat(" but this PhotonView does not exist! Was remote PV.", this.Tiles);
			this.HKHBBBFLGJH().SetFloat("_MainTex2", this.Speed);
			this.EPCGJFCCAFH().SetFloat("UI Extensions/UIMultiply", this.PosX);
			this.LPMLLJKMAMP().SetFloat("[MapsStats] Length: ", this.PosY);
			this.DEFBJOCJJKF().SetColor("_Distortion", this.color);
			this.DKNJGHFLAIF().SetVector("[RanksSystem] Ranks updated. Next update: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 285f, 346f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060040B1 RID: 16561 RVA: 0x0013F249 File Offset: 0x0013D449
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060040B2 RID: 16562 RVA: 0x001400DD File Offset: 0x0013E2DD
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060040B3 RID: 16563 RVA: 0x00140114 File Offset: 0x0013E314
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060040B4 RID: 16564 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060040B5 RID: 16565 RVA: 0x0014014B File Offset: 0x0013E34B
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060040B6 RID: 16566 RVA: 0x00140182 File Offset: 0x0013E382
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060040B7 RID: 16567 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHJJFJCKGAJ()
	{
	}

	// Token: 0x060040B8 RID: 16568 RVA: 0x001401B9 File Offset: 0x0013E3B9
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Screens");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060040B9 RID: 16569 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x060040BA RID: 16570 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x060040BB RID: 16571 RVA: 0x001401E0 File Offset: 0x0013E3E0
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1432f)
			{
				this.HBJJOCHGOPH = 1467f;
			}
			this.BKKJJJGADLM().SetFloat("HandleEventLeave for player ID: ", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("DPADVER", this.Tiles);
			this.CIAFLBFJLEJ().SetFloat("player ", this.Speed);
			this.OIIDAKBILMI().SetFloat("Move environment object to the position", this.PosX);
			this.HNFFHCLNBDN().SetFloat("Fill Area", this.PosY);
			this.OLHDPICFBOF().SetColor("_Value", this.color);
			this.ABHDNGIHBKE().SetVector(",", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1105f, 1205f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060040BC RID: 16572 RVA: 0x001402F5 File Offset: 0x0013E4F5
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)127;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060040BD RID: 16573 RVA: 0x0014032C File Offset: 0x0013E52C
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x040006DA RID: 1754
	public Shader SCShader;

	// Token: 0x040006DB RID: 1755
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040006DC RID: 1756
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040006DD RID: 1757
	private Material BJFKDHHMLJH;

	// Token: 0x040006DE RID: 1758
	[Range(0f, 256f)]
	public float Tiles = 8f;

	// Token: 0x040006DF RID: 1759
	[Range(0f, 5f)]
	public float Speed = 0.25f;

	// Token: 0x040006E0 RID: 1760
	public Color color = new Color(0f, 1f, 1f, 1f);

	// Token: 0x040006E1 RID: 1761
	[Range(-1f, 1f)]
	public float PosX;

	// Token: 0x040006E2 RID: 1762
	[Range(-1f, 1f)]
	public float PosY;
}
