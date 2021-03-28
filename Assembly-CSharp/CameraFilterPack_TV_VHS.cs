using System;
using UnityEngine;

// Token: 0x02000124 RID: 292
[AddComponentMenu("Camera Filter Pack/VHS/VHS")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_VHS : MonoBehaviour
{
	// Token: 0x06005C4B RID: 23627 RVA: 0x001C4AE4 File Offset: 0x001C2CE4
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1446f)
			{
				this.HBJJOCHGOPH = 1091f;
			}
			this.PLBEJJIHFPB().SetFloat("yyyy-MM-dd HH:mm:ss", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("_Value2", this.Cryptage);
			this.IONHGBPGCHK().SetFloat("Hex value #RRGGBB", this.Parasite);
			this.PLBEJJIHFPB().SetFloat("#forever", this.Calibrage);
			this.ACHNOHCLGOO().SetFloat("SteamManager", this.WhiteParasite);
			this.ACHNOHCLGOO().SetVector("_Value7", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1158f, 1828f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C4C RID: 23628 RVA: 0x001C4BE3 File Offset: 0x001C2DE3
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C4D RID: 23629 RVA: 0x001C4C00 File Offset: 0x001C2E00
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1533f)
			{
				this.HBJJOCHGOPH = 1065f;
			}
			this.PLBEJJIHFPB().SetFloat("Hidden/TonemappingColorGrading", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.Cryptage);
			this.FAIFBBGFAIB().SetFloat("<b>", this.Parasite);
			this.ACHNOHCLGOO().SetFloat("_BlurVector", this.Calibrage);
			this.NBPKMLMCHFN.SetFloat(" registered.", this.WhiteParasite);
			this.IONHGBPGCHK().SetVector(" methods \"", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 834f, 1148f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C4E RID: 23630 RVA: 0x001C4CFF File Offset: 0x001C2EFF
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_VHS");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005C4F RID: 23631 RVA: 0x001C4D23 File Offset: 0x001C2F23
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("z");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005C50 RID: 23632 RVA: 0x001C4BE3 File Offset: 0x001C2DE3
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C51 RID: 23633 RVA: 0x001C4D47 File Offset: 0x001C2F47
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("#FFFFFF");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005C52 RID: 23634 RVA: 0x001C4D6C File Offset: 0x001C2F6C
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 3f)
			{
				this.HBJJOCHGOPH = 1734f;
			}
			this.FAIFBBGFAIB().SetFloat("shader.crispwinter", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat(" to: ", this.Cryptage);
			this.ACHNOHCLGOO().SetFloat("_Value2", this.Parasite);
			this.ACHNOHCLGOO().SetFloat("_Value2", this.Calibrage);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.WhiteParasite);
			this.LDNADDJMIPK().SetVector("_Metrics", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 826f, 676f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C53 RID: 23635 RVA: 0x001C4E6C File Offset: 0x001C306C
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1932f)
			{
				this.HBJJOCHGOPH = 1513f;
			}
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Drawing_Manga4", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("_TimeX", this.Cryptage);
			this.FAIFBBGFAIB().SetFloat("GameScene", this.Parasite);
			this.IONHGBPGCHK().SetFloat("_Exponent", this.Calibrage);
			this.FAIFBBGFAIB().SetFloat("value", this.WhiteParasite);
			this.FAIFBBGFAIB().SetVector("<start_index> <end_index>", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 370f, 1362f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C54 RID: 23636 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06005C55 RID: 23637 RVA: 0x001C4BE3 File Offset: 0x001C2DE3
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C56 RID: 23638 RVA: 0x001C4F6C File Offset: 0x001C316C
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 825f)
			{
				this.HBJJOCHGOPH = 1318f;
			}
			this.NBPKMLMCHFN.SetFloat("settings.gamemessagesduration", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("Search: ", this.Cryptage);
			this.ACHNOHCLGOO().SetFloat("_Value", this.Parasite);
			this.IONHGBPGCHK().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", this.Calibrage);
			this.IONHGBPGCHK().SetFloat("Received unknown status code: ", this.WhiteParasite);
			this.ACHNOHCLGOO().SetVector("_LightIntensity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1131f, 9f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C57 RID: 23639 RVA: 0x001C4BE3 File Offset: 0x001C2DE3
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C58 RID: 23640 RVA: 0x001C506B File Offset: 0x001C326B
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005C59 RID: 23641 RVA: 0x001C50A2 File Offset: 0x001C32A2
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("CameraFilterPack_RainFX_Anm2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005C5A RID: 23642 RVA: 0x001C50C6 File Offset: 0x001C32C6
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005C5C RID: 23644 RVA: 0x001C4BE3 File Offset: 0x001C2DE3
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C5D RID: 23645 RVA: 0x001C5134 File Offset: 0x001C3334
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 518f)
			{
				this.HBJJOCHGOPH = 232f;
			}
			this.LDNADDJMIPK().SetFloat("Day_", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("[Right]", this.Cryptage);
			this.PLBEJJIHFPB().SetFloat("_TimeX", this.Parasite);
			this.LDNADDJMIPK().SetFloat("offsets", this.Calibrage);
			this.PLBEJJIHFPB().SetFloat("Value", this.WhiteParasite);
			this.FAIFBBGFAIB().SetVector("received</b>\n#reason: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 307f, 1282f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000109 RID: 265
	// (get) Token: 0x06005C5E RID: 23646 RVA: 0x001C5233 File Offset: 0x001C3433
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

	// Token: 0x06005C5F RID: 23647 RVA: 0x001C4BE3 File Offset: 0x001C2DE3
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C60 RID: 23648 RVA: 0x001C526C File Offset: 0x001C346C
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1971f)
			{
				this.HBJJOCHGOPH = 499f;
			}
			this.LDNADDJMIPK().SetFloat("A", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat(".lastCheckpoint.bgcolor", this.Cryptage);
			this.ACHNOHCLGOO().SetFloat("New level loaded. Removed ", this.Parasite);
			this.PLBEJJIHFPB().SetFloat("{0:0} hour{1}, ", this.Calibrage);
			this.PLBEJJIHFPB().SetFloat("_ScreenResolution", this.WhiteParasite);
			this.NBPKMLMCHFN.SetVector("[PlayerController] ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1725f, 812f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C61 RID: 23649 RVA: 0x001C536C File Offset: 0x001C356C
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1147f)
			{
				this.HBJJOCHGOPH = 1458f;
			}
			this.IONHGBPGCHK().SetFloat("_Distortion", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("<command>", this.Cryptage);
			this.LDNADDJMIPK().SetFloat("float,2", this.Parasite);
			this.IONHGBPGCHK().SetFloat("FinalScoreSmallText", this.Calibrage);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.WhiteParasite);
			this.IONHGBPGCHK().SetVector("SetPlayerDistance", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1703f, 1870f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C62 RID: 23650 RVA: 0x001C546B File Offset: 0x001C366B
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005C63 RID: 23651 RVA: 0x001C4BE3 File Offset: 0x001C2DE3
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C64 RID: 23652 RVA: 0x001C54A4 File Offset: 0x001C36A4
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Cryptage);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Parasite);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Calibrage);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.WhiteParasite);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C65 RID: 23653 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005C66 RID: 23654 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06005C67 RID: 23655 RVA: 0x001C4BE3 File Offset: 0x001C2DE3
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C68 RID: 23656 RVA: 0x001C55A3 File Offset: 0x001C37A3
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005C69 RID: 23657 RVA: 0x001C55DA File Offset: 0x001C37DA
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("Texture2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005C6A RID: 23658 RVA: 0x001C55FE File Offset: 0x001C37FE
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005C6B RID: 23659 RVA: 0x001C5635 File Offset: 0x001C3835
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("[PlayerBase] MapEnd error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005C6C RID: 23660 RVA: 0x001C4BE3 File Offset: 0x001C2DE3
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C6D RID: 23661 RVA: 0x001C4BE3 File Offset: 0x001C2DE3
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C6E RID: 23662 RVA: 0x001C4BE3 File Offset: 0x001C2DE3
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C6F RID: 23663 RVA: 0x001C4BE3 File Offset: 0x001C2DE3
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C70 RID: 23664 RVA: 0x001C4BE3 File Offset: 0x001C2DE3
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C71 RID: 23665 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06005C72 RID: 23666 RVA: 0x001C565C File Offset: 0x001C385C
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1666f)
			{
				this.HBJJOCHGOPH = 1420f;
			}
			this.PLBEJJIHFPB().SetFloat("CameraFilterPack/Edge_Edge_filter", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("Preparing content", this.Cryptage);
			this.ACHNOHCLGOO().SetFloat("_TimeX", this.Parasite);
			this.IONHGBPGCHK().SetFloat("_Value6", this.Calibrage);
			this.IONHGBPGCHK().SetFloat("_ScreenResolution", this.WhiteParasite);
			this.NBPKMLMCHFN.SetVector("CameraFilterPack/Broken_Screen", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1412f, 74f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C73 RID: 23667 RVA: 0x001C575B File Offset: 0x001C395B
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("st");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005C74 RID: 23668 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06005C75 RID: 23669 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06005C76 RID: 23670 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x06005C77 RID: 23671 RVA: 0x001C4BE3 File Offset: 0x001C2DE3
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C78 RID: 23672 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06005C79 RID: 23673 RVA: 0x001C4BE3 File Offset: 0x001C2DE3
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C7A RID: 23674 RVA: 0x001C577F File Offset: 0x001C397F
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005C7B RID: 23675 RVA: 0x001C4BE3 File Offset: 0x001C2DE3
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0400095B RID: 2395
	public Shader SCShader;

	// Token: 0x0400095C RID: 2396
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400095D RID: 2397
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400095E RID: 2398
	private Material BJFKDHHMLJH;

	// Token: 0x0400095F RID: 2399
	[Range(1f, 256f)]
	public float Cryptage = 64f;

	// Token: 0x04000960 RID: 2400
	[Range(1f, 100f)]
	public float Parasite = 32f;

	// Token: 0x04000961 RID: 2401
	[Range(0f, 3f)]
	public float Calibrage;

	// Token: 0x04000962 RID: 2402
	[Range(0f, 1f)]
	public float WhiteParasite = 1f;
}
