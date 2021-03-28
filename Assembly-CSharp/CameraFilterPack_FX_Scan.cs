using System;
using UnityEngine;

// Token: 0x020000D3 RID: 211
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/FX/Scan")]
public class CameraFilterPack_FX_Scan : MonoBehaviour
{
	// Token: 0x06004008 RID: 16392 RVA: 0x0013C990 File Offset: 0x0013AB90
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("{\"items\":");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004009 RID: 16393 RVA: 0x0013C9B4 File Offset: 0x0013ABB4
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600400A RID: 16394 RVA: 0x0013C9D4 File Offset: 0x0013ABD4
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1796f)
			{
				this.HBJJOCHGOPH = 934f;
			}
			this.HFBJAOFLCJI().SetFloat("PhotonView register is ignored, because viewID is 0. No id assigned yet to: ", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("[SERVER] Kicked ", this.Size);
			this.HKGAONMOBMH().SetFloat("[ERROR KEY {0}]", this.Speed);
			this.IGKFMCPDNOI().SetFloat("FinalScoreSmallText", this.ILHJFHFPGBB);
			this.PLBEJJIHFPB().SetFloat("\nv.", this.CCIENBFIKKH);
			this.GHHPOGODBHB().SetVector("\nv.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 643f, 1119f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600400B RID: 16395 RVA: 0x0013CAD4 File Offset: 0x0013ACD4
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 793f)
			{
				this.HBJJOCHGOPH = 1898f;
			}
			this.PLBEJJIHFPB().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("note.4", this.Size);
			this.NBPKMLMCHFN.SetFloat("source", this.Speed);
			this.ADGHJOHKEHG().SetFloat("(\\[ *h1 *\\])", this.ILHJFHFPGBB);
			this.EJDPNJAEAKJ().SetFloat("player.playedtutorial", this.CCIENBFIKKH);
			this.OIMMPLPBLBK().SetVector("wss://", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1074f, 1896f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600400C RID: 16396 RVA: 0x0013C9B4 File Offset: 0x0013ABB4
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600400D RID: 16397 RVA: 0x0013CBD4 File Offset: 0x0013ADD4
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 37f)
			{
				this.HBJJOCHGOPH = 1473f;
			}
			this.PDEAHJPOMEF().SetFloat("float,0", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat(":", this.Size);
			this.FAIFBBGFAIB().SetFloat("RequestSelectedLevel", this.Speed);
			this.DNLMFEGJJDD().SetFloat("_NoiseTex", this.ILHJFHFPGBB);
			this.EJDPNJAEAKJ().SetFloat("CameraFilterPack_Paper4", this.CCIENBFIKKH);
			this.BFGNMFCNDBC().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1286f, 11f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600400E RID: 16398 RVA: 0x0013CCD3 File Offset: 0x0013AED3
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600400F RID: 16399 RVA: 0x0013CD0A File Offset: 0x0013AF0A
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004010 RID: 16400 RVA: 0x0013C9B4 File Offset: 0x0013ABB4
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004011 RID: 16401 RVA: 0x0013CD41 File Offset: 0x0013AF41
	private Material GHHPOGODBHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004012 RID: 16402 RVA: 0x0013CD78 File Offset: 0x0013AF78
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1910f)
			{
				this.HBJJOCHGOPH = 1842f;
			}
			this.HKGAONMOBMH().SetFloat("#failed: ", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Reset XP", this.Size);
			this.HHIAIGCAHDA().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", this.Speed);
			this.DNLMFEGJJDD().SetFloat("\\", this.ILHJFHFPGBB);
			this.FLOHGDECHHH().SetFloat("Fade", this.CCIENBFIKKH);
			this.LONNIJMNKFB().SetVector("_Circle", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1300f, 311f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004013 RID: 16403 RVA: 0x0013C9B4 File Offset: 0x0013ABB4
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004014 RID: 16404 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06004015 RID: 16405 RVA: 0x0013C9B4 File Offset: 0x0013ABB4
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004016 RID: 16406 RVA: 0x0013CE78 File Offset: 0x0013B078
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1900f)
			{
				this.HBJJOCHGOPH = 1145f;
			}
			this.LONNIJMNKFB().SetFloat("[MapsStats] Difficulty: ", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat("EnableRankingToggle", this.Size);
			this.HKGAONMOBMH().SetFloat("[PlayerController] ", this.Speed);
			this.NBPKMLMCHFN.SetFloat("seconds", this.ILHJFHFPGBB);
			this.HHIAIGCAHDA().SetFloat("Error: You're not logged into Steam!", this.CCIENBFIKKH);
			this.LENEJAGLCNL().SetVector("EnableRankingToggle", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 635f, 299f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004017 RID: 16407 RVA: 0x0013CF77 File Offset: 0x0013B177
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004018 RID: 16408 RVA: 0x0013CFAE File Offset: 0x0013B1AE
	private Material BKKJJJGADLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004019 RID: 16409 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x0600401A RID: 16410 RVA: 0x0013CFE5 File Offset: 0x0013B1E5
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find("OpGetGameList not sent. Lobby cannot be null.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600401B RID: 16411 RVA: 0x0013C9B4 File Offset: 0x0013ABB4
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600401C RID: 16412 RVA: 0x0013D009 File Offset: 0x0013B209
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600401D RID: 16413 RVA: 0x0013D040 File Offset: 0x0013B240
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("_Intensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600401E RID: 16414 RVA: 0x0013C9B4 File Offset: 0x0013ABB4
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600401F RID: 16415 RVA: 0x0013C9B4 File Offset: 0x0013ABB4
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004020 RID: 16416 RVA: 0x0013D064 File Offset: 0x0013B264
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("Submit");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004021 RID: 16417 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x06004022 RID: 16418 RVA: 0x0013C9B4 File Offset: 0x0013ABB4
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004023 RID: 16419 RVA: 0x0013D088 File Offset: 0x0013B288
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004024 RID: 16420 RVA: 0x0013D0AC File Offset: 0x0013B2AC
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1969f)
			{
				this.HBJJOCHGOPH = 925f;
			}
			this.IGKFMCPDNOI().SetFloat("Please attach component to a Graphical UI component", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("<b><i>Map's Stats:</i></b>", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Speed);
			this.GHHPOGODBHB().SetFloat("settings.shaders.bloomintencity", this.ILHJFHFPGBB);
			this.NBPKMLMCHFN.SetFloat("AVG Misses:", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector(" (", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 313f, 225f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004025 RID: 16421 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x06004026 RID: 16422 RVA: 0x0013D1AB File Offset: 0x0013B3AB
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("CameraFilterPack/AAA_Blood_Plus");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004027 RID: 16423 RVA: 0x0013C9B4 File Offset: 0x0013ABB4
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004028 RID: 16424 RVA: 0x0013D1CF File Offset: 0x0013B3CF
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004029 RID: 16425 RVA: 0x0013D1F3 File Offset: 0x0013B3F3
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600402A RID: 16426 RVA: 0x0013D217 File Offset: 0x0013B417
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600402B RID: 16427 RVA: 0x0013D24E File Offset: 0x0013B44E
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find("<b>#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600402C RID: 16428 RVA: 0x0013D272 File Offset: 0x0013B472
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600402D RID: 16429 RVA: 0x0013D2A9 File Offset: 0x0013B4A9
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600402E RID: 16430 RVA: 0x0013D2E0 File Offset: 0x0013B4E0
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 376f)
			{
				this.HBJJOCHGOPH = 1198f;
			}
			this.PDEAHJPOMEF().SetFloat("maps.", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("Mouse Y", this.Size);
			this.DNLMFEGJJDD().SetFloat("Tab1Content", this.Speed);
			this.FLOHGDECHHH().SetFloat("CameraFilterPack/Glasses_OnX", this.ILHJFHFPGBB);
			this.PGPEMMBJOOG().SetFloat("LoadMapCanvas", this.CCIENBFIKKH);
			this.PLBEJJIHFPB().SetVector("offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 132f, 1907f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600402F RID: 16431 RVA: 0x0013D3E0 File Offset: 0x0013B5E0
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 224f)
			{
				this.HBJJOCHGOPH = 1754f;
			}
			this.EJDPNJAEAKJ().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("_EmissionColor", this.Size);
			this.HHIAIGCAHDA().SetFloat("/Saved Games/", this.Speed);
			this.BFGNMFCNDBC().SetFloat("restrictions", this.ILHJFHFPGBB);
			this.FLOHGDECHHH().SetFloat("_Value2", this.CCIENBFIKKH);
			this.FAIFBBGFAIB().SetVector("_SizeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 675f, 1611f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004030 RID: 16432 RVA: 0x0013D4DF File Offset: 0x0013B6DF
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004031 RID: 16433 RVA: 0x0013D516 File Offset: 0x0013B716
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004032 RID: 16434 RVA: 0x0013D53A File Offset: 0x0013B73A
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004033 RID: 16435 RVA: 0x0013D571 File Offset: 0x0013B771
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Scan");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004034 RID: 16436 RVA: 0x0013D595 File Offset: 0x0013B795
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004035 RID: 16437 RVA: 0x0013C9B4 File Offset: 0x0013ABB4
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004036 RID: 16438 RVA: 0x0013D5CC File Offset: 0x0013B7CC
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004037 RID: 16439 RVA: 0x0013D603 File Offset: 0x0013B803
	private void FMNPFCHBLJF()
	{
		this.SCShader = Shader.Find(".highscore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x170000B9 RID: 185
	// (get) Token: 0x06004038 RID: 16440 RVA: 0x0013D627 File Offset: 0x0013B827
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

	// Token: 0x06004039 RID: 16441 RVA: 0x0013D660 File Offset: 0x0013B860
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1500f)
			{
				this.HBJJOCHGOPH = 877f;
			}
			this.DNLMFEGJJDD().SetFloat("CameraFilterPack/Blend2Camera_Difference", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("sprite", this.Size);
			this.LENEJAGLCNL().SetFloat("FavoriteButton", this.Speed);
			this.GHHPOGODBHB().SetFloat("There is already a virtual button named ", this.ILHJFHFPGBB);
			this.HFBJAOFLCJI().SetFloat(", ", this.CCIENBFIKKH);
			this.BFGNMFCNDBC().SetVector("Coord", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1846f, 1619f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600403A RID: 16442 RVA: 0x0013D75F File Offset: 0x0013B95F
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find("settings.gamemessagesduration");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600403B RID: 16443 RVA: 0x0013D784 File Offset: 0x0013B984
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1130f)
			{
				this.HBJJOCHGOPH = 587f;
			}
			this.LENEJAGLCNL().SetFloat("CameraFilterPack/Distortion_Flag", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("_Value", this.Size);
			this.DNLMFEGJJDD().SetFloat(".played", this.Speed);
			this.HFBJAOFLCJI().SetFloat("Gameplay/Base", this.ILHJFHFPGBB);
			this.EJDPNJAEAKJ().SetFloat("-", this.CCIENBFIKKH);
			this.LONNIJMNKFB().SetVector("Best region found in PlayerPrefs. Connecting to: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 120f, 1584f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600403C RID: 16444 RVA: 0x0013D883 File Offset: 0x0013BA83
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600403D RID: 16445 RVA: 0x0013D8BC File Offset: 0x0013BABC
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 48f)
			{
				this.HBJJOCHGOPH = 799f;
			}
			this.BKKJJJGADLM().SetFloat("Show Image", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("maps.", this.Size);
			this.FLOHGDECHHH().SetFloat("_Value2", this.Speed);
			this.HFBJAOFLCJI().SetFloat("_Value1", this.ILHJFHFPGBB);
			this.DNLMFEGJJDD().SetFloat(" is not observed by this object's photonView! OnPhotonSerializeView() in this class won't be used.", this.CCIENBFIKKH);
			this.EJDPNJAEAKJ().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 789f, 985f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600403E RID: 16446 RVA: 0x0013D9BB File Offset: 0x0013BBBB
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600403F RID: 16447 RVA: 0x0013D9F2 File Offset: 0x0013BBF2
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004040 RID: 16448 RVA: 0x0013C9B4 File Offset: 0x0013ABB4
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004041 RID: 16449 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06004042 RID: 16450 RVA: 0x0013DA29 File Offset: 0x0013BC29
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_Twist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004043 RID: 16451 RVA: 0x0013C9B4 File Offset: 0x0013ABB4
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004044 RID: 16452 RVA: 0x0013DA4D File Offset: 0x0013BC4D
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004045 RID: 16453 RVA: 0x0013DA84 File Offset: 0x0013BC84
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004046 RID: 16454 RVA: 0x0013DABB File Offset: 0x0013BCBB
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("[Up]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004048 RID: 16456 RVA: 0x0013DB1E File Offset: 0x0013BD1E
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004049 RID: 16457 RVA: 0x0013DB58 File Offset: 0x0013BD58
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 838f)
			{
				this.HBJJOCHGOPH = 1279f;
			}
			this.BFGNMFCNDBC().SetFloat("SetCrosshairColor", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat("workshop.", this.Size);
			this.DNLMFEGJJDD().SetFloat("_Value3", this.Speed);
			this.NBPKMLMCHFN.SetFloat("Horizontal", this.ILHJFHFPGBB);
			this.HHIAIGCAHDA().SetFloat("CameraFilterPack/Blend2Camera_ColorKey", this.CCIENBFIKKH);
			this.HKGAONMOBMH().SetVector("roomDescription", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1846f, 1943f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600404A RID: 16458 RVA: 0x0013DC58 File Offset: 0x0013BE58
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 61f)
			{
				this.HBJJOCHGOPH = 869f;
			}
			this.BFGNMFCNDBC().SetFloat("Exit to menu?", this.HBJJOCHGOPH);
			this.HHIAIGCAHDA().SetFloat("shader.ghost", this.Size);
			this.FAIFBBGFAIB().SetFloat("mapselector.filter.favoriteonly", this.Speed);
			this.PGPEMMBJOOG().SetFloat("b", this.ILHJFHFPGBB);
			this.KOHGPKOFEJO().SetFloat("_AllowBackwardsRays", this.CCIENBFIKKH);
			this.BFGNMFCNDBC().SetVector("intensity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 274f, 91f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600404B RID: 16459 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x0600404C RID: 16460 RVA: 0x0013DD58 File Offset: 0x0013BF58
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 380f)
			{
				this.HBJJOCHGOPH = 178f;
			}
			this.EJDPNJAEAKJ().SetFloat("Can't connect: ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("settings.volume.sfx", this.Size);
			this.PDEAHJPOMEF().SetFloat("_EdgeSharpness", this.Speed);
			this.PDEAHJPOMEF().SetFloat("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception", this.ILHJFHFPGBB);
			this.NBPKMLMCHFN.SetFloat("settings.cameramovements", this.CCIENBFIKKH);
			this.BKKJJJGADLM().SetVector("_Light", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1469f, 1149f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600404D RID: 16461 RVA: 0x0013DE58 File Offset: 0x0013C058
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1738f)
			{
				this.HBJJOCHGOPH = 1335f;
			}
			this.KOHGPKOFEJO().SetFloat("_VignetteSettings", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("MapEnd", this.Size);
			this.HKGAONMOBMH().SetFloat(" Server: ", this.Speed);
			this.ADGHJOHKEHG().SetFloat("#mapalreadyexistupdate", this.ILHJFHFPGBB);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.CCIENBFIKKH);
			this.HKGAONMOBMH().SetVector("CameraFilterPack/TV_BrokenGlass", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1865f, 1405f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600404E RID: 16462 RVA: 0x0013C9B4 File Offset: 0x0013ABB4
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600404F RID: 16463 RVA: 0x0013DF57 File Offset: 0x0013C157
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find("Exit to Windows");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004050 RID: 16464 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06004051 RID: 16465 RVA: 0x0013DF7C File Offset: 0x0013C17C
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1454f)
			{
				this.HBJJOCHGOPH = 34f;
			}
			this.PLBEJJIHFPB().SetFloat("id", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("CameraFilterPack/Vision_Blood_Fast", this.Size);
			this.LONNIJMNKFB().SetFloat("Checkpoint", this.Speed);
			this.BFGNMFCNDBC().SetFloat("BitsData", this.ILHJFHFPGBB);
			this.ADGHJOHKEHG().SetFloat("SetParticlesEmission", this.CCIENBFIKKH);
			this.HKGAONMOBMH().SetVector("sprite", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1015f, 215f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004052 RID: 16466 RVA: 0x0013E07C File Offset: 0x0013C27C
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Speed);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.ILHJFHFPGBB);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004053 RID: 16467 RVA: 0x0013C9B4 File Offset: 0x0013ABB4
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040006D2 RID: 1746
	public Shader SCShader;

	// Token: 0x040006D3 RID: 1747
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040006D4 RID: 1748
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040006D5 RID: 1749
	private Material BJFKDHHMLJH;

	// Token: 0x040006D6 RID: 1750
	[Range(0.001f, 0.1f)]
	public float Size = 0.025f;

	// Token: 0x040006D7 RID: 1751
	[Range(0f, 10f)]
	public float Speed = 1f;

	// Token: 0x040006D8 RID: 1752
	[Range(0f, 10f)]
	private float ILHJFHFPGBB = 1f;

	// Token: 0x040006D9 RID: 1753
	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;
}
