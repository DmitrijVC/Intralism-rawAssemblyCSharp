using System;
using UnityEngine;

// Token: 0x0200010A RID: 266
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Sharpen/Sharpen")]
public class CameraFilterPack_Sharpen_Sharpen : MonoBehaviour
{
	// Token: 0x060052E0 RID: 21216 RVA: 0x0019C6AC File Offset: 0x0019A8AC
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052E1 RID: 21217 RVA: 0x0019C6E3 File Offset: 0x0019A8E3
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060052E2 RID: 21218 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060052E3 RID: 21219 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x060052E4 RID: 21220 RVA: 0x0019C700 File Offset: 0x0019A900
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052E5 RID: 21221 RVA: 0x0019C6E3 File Offset: 0x0019A8E3
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060052E6 RID: 21222 RVA: 0x0019C737 File Offset: 0x0019A937
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052E7 RID: 21223 RVA: 0x0019C76E File Offset: 0x0019A96E
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052E8 RID: 21224 RVA: 0x0019C7A8 File Offset: 0x0019A9A8
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 418f)
			{
				this.HBJJOCHGOPH = 406f;
			}
			this.FHFLKLMFHOI().SetFloat("CameraFilterPack_AAA_Blood2", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetVector("[#clicktogetreward]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1459f, 752f));
			this.DOHGBNPMBKG().SetFloat("[PlayerBase] Loading checkpoint data", this.Value);
			this.DNLMFEGJJDD().SetFloat("[PlayerBase] Ready", this.Value2);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060052E9 RID: 21225 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x060052EA RID: 21226 RVA: 0x0019C87B File Offset: 0x0019AA7B
	private Material CFCPHFMKHII()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052EB RID: 21227 RVA: 0x0019C8B2 File Offset: 0x0019AAB2
	private Material PHGCJOPFDOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052EC RID: 21228 RVA: 0x0019C8E9 File Offset: 0x0019AAE9
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("VoteDownToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060052ED RID: 21229 RVA: 0x0019C6E3 File Offset: 0x0019A8E3
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060052EE RID: 21230 RVA: 0x0019C90D File Offset: 0x0019AB0D
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052EF RID: 21231 RVA: 0x0019C944 File Offset: 0x0019AB44
	private void HIPEHGNBJMN()
	{
		this.SCShader = Shader.Find("/512px-512px.png");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060052F0 RID: 21232 RVA: 0x0019C968 File Offset: 0x0019AB68
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Value);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Value2);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060052F1 RID: 21233 RVA: 0x0019C6E3 File Offset: 0x0019A8E3
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060052F2 RID: 21234 RVA: 0x0019CA3B File Offset: 0x0019AC3B
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052F3 RID: 21235 RVA: 0x0019C76E File Offset: 0x0019A96E
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052F4 RID: 21236 RVA: 0x0019CA72 File Offset: 0x0019AC72
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052F5 RID: 21237 RVA: 0x0019CAA9 File Offset: 0x0019ACA9
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052F6 RID: 21238 RVA: 0x0019C6E3 File Offset: 0x0019A8E3
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060052F7 RID: 21239 RVA: 0x0019C6E3 File Offset: 0x0019A8E3
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060052F8 RID: 21240 RVA: 0x0019CAE0 File Offset: 0x0019ACE0
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052F9 RID: 21241 RVA: 0x0019CB17 File Offset: 0x0019AD17
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-125);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060052FA RID: 21242 RVA: 0x0019C6E3 File Offset: 0x0019A8E3
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060052FB RID: 21243 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x060052FC RID: 21244 RVA: 0x0019CB4E File Offset: 0x0019AD4E
	private void JKBMKPDGCHG()
	{
		this.SCShader = Shader.Find("#restart");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060052FD RID: 21245 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x060052FE RID: 21246 RVA: 0x0019CB72 File Offset: 0x0019AD72
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060052FF RID: 21247 RVA: 0x0019CB96 File Offset: 0x0019AD96
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005300 RID: 21248 RVA: 0x0019C6E3 File Offset: 0x0019A8E3
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005301 RID: 21249 RVA: 0x0019CBCD File Offset: 0x0019ADCD
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005302 RID: 21250 RVA: 0x0019C6E3 File Offset: 0x0019A8E3
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005303 RID: 21251 RVA: 0x0019CC04 File Offset: 0x0019AE04
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find("InventoryContent");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005304 RID: 21252 RVA: 0x0019CC28 File Offset: 0x0019AE28
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005305 RID: 21253 RVA: 0x0019CC4C File Offset: 0x0019AE4C
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 464f)
			{
				this.HBJJOCHGOPH = 1350f;
			}
			this.MLMKCOINOOH().SetFloat("_PColor", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetVector("_Offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 302f, 404f));
			this.OJMHIMIPKME().SetFloat("open", this.Value);
			this.MLMKCOINOOH().SetFloat("MultiplayerButton", this.Value2);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005306 RID: 21254 RVA: 0x0019C6E3 File Offset: 0x0019A8E3
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005307 RID: 21255 RVA: 0x0019CD20 File Offset: 0x0019AF20
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 302f)
			{
				this.HBJJOCHGOPH = 1511f;
			}
			this.DNLMFEGJJDD().SetFloat("_FgCocMask", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1117f, 136f));
			this.KDMBOKLMADJ().SetFloat("ArcsHitsoundTimeDelaySlider", this.Value);
			this.OGMEGHKECAH().SetFloat("skin.hit_normal", this.Value2);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005308 RID: 21256 RVA: 0x0019C6E3 File Offset: 0x0019A8E3
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005309 RID: 21257 RVA: 0x0019CDF3 File Offset: 0x0019AFF3
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600530A RID: 21258 RVA: 0x0019CE2A File Offset: 0x0019B02A
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600530B RID: 21259 RVA: 0x0019CE4E File Offset: 0x0019B04E
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600530C RID: 21260 RVA: 0x0019CE85 File Offset: 0x0019B085
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600530D RID: 21261 RVA: 0x0019CEBC File Offset: 0x0019B0BC
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Gradients_Stripe");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600530E RID: 21262 RVA: 0x0019CE2A File Offset: 0x0019B02A
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600530F RID: 21263 RVA: 0x0019CEE0 File Offset: 0x0019B0E0
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1337f)
			{
				this.HBJJOCHGOPH = 1561f;
			}
			this.DKNJGHFLAIF().SetFloat("???", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetVector("No Name", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1811f, 1660f));
			this.LNLKMDPHDCC().SetFloat("BadgeText", this.Value);
			this.LENEJAGLCNL().SetFloat("LevelEditor/CustomEventEditor-Text", this.Value2);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005310 RID: 21264 RVA: 0x0019C6E3 File Offset: 0x0019A8E3
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005311 RID: 21265 RVA: 0x0019C6E3 File Offset: 0x0019A8E3
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005312 RID: 21266 RVA: 0x0019CFB3 File Offset: 0x0019B1B3
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("shader.sunny");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005313 RID: 21267 RVA: 0x0019CFD8 File Offset: 0x0019B1D8
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 174f)
			{
				this.HBJJOCHGOPH = 569f;
			}
			this.PDEAHJPOMEF().SetFloat("CameraFilterPack/Gradients_ElectricGradient", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetVector("<color=#", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 281f, 1712f));
			this.GKILCDHJFEG().SetFloat("ns", this.Value);
			this.KDMBOKLMADJ().SetFloat("_PositionX", this.Value2);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005314 RID: 21268 RVA: 0x0019D0AB File Offset: 0x0019B2AB
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005315 RID: 21269 RVA: 0x0019D0E2 File Offset: 0x0019B2E2
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005316 RID: 21270 RVA: 0x0019D119 File Offset: 0x0019B319
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005317 RID: 21271 RVA: 0x0019D150 File Offset: 0x0019B350
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("</color>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005318 RID: 21272 RVA: 0x0019D174 File Offset: 0x0019B374
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 447f)
			{
				this.HBJJOCHGOPH = 650f;
			}
			this.PDEAHJPOMEF().SetFloat("_Value", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetVector("_EmissionColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 800f, 739f));
			this.MFHPKGICPIO().SetFloat("#close", this.Value);
			this.IIJMIPBMMBF().SetFloat("bloomintencity:", this.Value2);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005319 RID: 21273 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x0600531A RID: 21274 RVA: 0x0019D247 File Offset: 0x0019B447
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("closed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600531B RID: 21275 RVA: 0x0019D26B File Offset: 0x0019B46B
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600531C RID: 21276 RVA: 0x0019D2A2 File Offset: 0x0019B4A2
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600531D RID: 21277 RVA: 0x0019D2DC File Offset: 0x0019B4DC
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 290f)
			{
				this.HBJJOCHGOPH = 1371f;
			}
			this.NLFJGMBCICG().SetFloat("/", this.HBJJOCHGOPH);
			this.PHGCJOPFDOG().SetVector("Move environment object to the position", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1545f, 406f));
			this.DKKBFFHBHJE().SetFloat("Uploading content", this.Value);
			this.LENEJAGLCNL().SetFloat("CompletedLevel", this.Value2);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600531E RID: 21278 RVA: 0x0019D3AF File Offset: 0x0019B5AF
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x170000EF RID: 239
	// (get) Token: 0x0600531F RID: 21279 RVA: 0x0019D3E6 File Offset: 0x0019B5E6
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

	// Token: 0x06005320 RID: 21280 RVA: 0x0019D41D File Offset: 0x0019B61D
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005321 RID: 21281 RVA: 0x0019C6E3 File Offset: 0x0019A8E3
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005322 RID: 21282 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x06005323 RID: 21283 RVA: 0x0019D454 File Offset: 0x0019B654
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 105f)
			{
				this.HBJJOCHGOPH = 1308f;
			}
			this.MFHPKGICPIO().SetFloat("_AccumOrig", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetVector("Ignored PU RPC, cause item is inactive. ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1719f, 1210f));
			this.DOHGBNPMBKG().SetFloat("_Value2", this.Value);
			this.NLFJGMBCICG().SetFloat("Reload Steam Inventory", this.Value2);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005324 RID: 21284 RVA: 0x0019D527 File Offset: 0x0019B727
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Sharpen_Sharpen");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005325 RID: 21285 RVA: 0x0002523B File Offset: 0x0002343B
	private void PNLKFANNOKO()
	{
	}

	// Token: 0x06005326 RID: 21286 RVA: 0x0019D54C File Offset: 0x0019B74C
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 280f)
			{
				this.HBJJOCHGOPH = 1620f;
			}
			this.LENEJAGLCNL().SetFloat("Unable to get a reward! Try again?", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetVector(": ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 403f, 1858f));
			this.EMDFHOKEGNG().SetFloat("The shader ", this.Value);
			this.CFCPHFMKHII().SetFloat("Fade", this.Value2);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005327 RID: 21287 RVA: 0x0019D61F File Offset: 0x0019B81F
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)88;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005328 RID: 21288 RVA: 0x0019C6E3 File Offset: 0x0019A8E3
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005329 RID: 21289 RVA: 0x0019C6E3 File Offset: 0x0019A8E3
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600532A RID: 21290 RVA: 0x0019D656 File Offset: 0x0019B856
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_Twist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600532B RID: 21291 RVA: 0x0019D67A File Offset: 0x0019B87A
	private Material OJMHIMIPKME()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600532C RID: 21292 RVA: 0x0019C6E3 File Offset: 0x0019A8E3
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600532D RID: 21293 RVA: 0x0019C6E3 File Offset: 0x0019A8E3
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600532E RID: 21294 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x0600532F RID: 21295 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x06005330 RID: 21296 RVA: 0x0019C6E3 File Offset: 0x0019A8E3
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005331 RID: 21297 RVA: 0x0019D6B4 File Offset: 0x0019B8B4
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1703f)
			{
				this.HBJJOCHGOPH = 247f;
			}
			this.KGOLDDBHIFN().SetFloat("SpawnObj", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetVector("wss://", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 900f, 712f));
			this.DNLMFEGJJDD().SetFloat("YES", this.Value);
			this.PHGCJOPFDOG().SetFloat("Simulate", this.Value2);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005332 RID: 21298 RVA: 0x0019D787 File Offset: 0x0019B987
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005333 RID: 21299 RVA: 0x0019D7BE File Offset: 0x0019B9BE
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005334 RID: 21300 RVA: 0x0019C6E3 File Offset: 0x0019A8E3
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005335 RID: 21301 RVA: 0x0019D7F8 File Offset: 0x0019B9F8
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 669f)
			{
				this.HBJJOCHGOPH = 1566f;
			}
			this.NDMPCDHADMJ().SetFloat("Right", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetVector("BitsData", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1798f, 538f));
			this.HCGJCMDJPGD().SetFloat("/", this.Value);
			this.DKKBFFHBHJE().SetFloat("_EmissionGain", this.Value2);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005336 RID: 21302 RVA: 0x0019D8CB File Offset: 0x0019BACB
	private void LGHCJCFHEMF()
	{
		this.SCShader = Shader.Find("_NeutralTonemapperParams1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005337 RID: 21303 RVA: 0x0019D8EF File Offset: 0x0019BAEF
	private void FLKEJJEGCFA()
	{
		this.SCShader = Shader.Find("bad");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005338 RID: 21304 RVA: 0x0019C6E3 File Offset: 0x0019A8E3
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005339 RID: 21305 RVA: 0x0019D914 File Offset: 0x0019BB14
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 231f)
			{
				this.HBJJOCHGOPH = 1634f;
			}
			this.DKKBFFHBHJE().SetFloat("_FarCamera", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetVector("RanksButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 943f, 1515f));
			this.PGPEMMBJOOG().SetFloat("settings.enablerankingnotifications", this.Value);
			this.OGMEGHKECAH().SetFloat("GameScene", this.Value2);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600533A RID: 21306 RVA: 0x0019D9E7 File Offset: 0x0019BBE7
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("EventMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600533B RID: 21307 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x0600533C RID: 21308 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x0600533E RID: 21310 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x0600533F RID: 21311 RVA: 0x0019DA34 File Offset: 0x0019BC34
	private Material MLMKCOINOOH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005340 RID: 21312 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x040008AD RID: 2221
	public Shader SCShader;

	// Token: 0x040008AE RID: 2222
	[Range(0.001f, 100f)]
	public float Value = 4f;

	// Token: 0x040008AF RID: 2223
	[Range(0.001f, 32f)]
	public float Value2 = 1f;

	// Token: 0x040008B0 RID: 2224
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040008B1 RID: 2225
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040008B2 RID: 2226
	private Material BJFKDHHMLJH;
}
