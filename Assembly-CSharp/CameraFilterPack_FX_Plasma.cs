using System;
using UnityEngine;

// Token: 0x020000D1 RID: 209
[AddComponentMenu("Camera Filter Pack/FX/Plasma")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_Plasma : MonoBehaviour
{
	// Token: 0x06003F20 RID: 16160 RVA: 0x0013990A File Offset: 0x00137B0A
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003F21 RID: 16161 RVA: 0x00139941 File Offset: 0x00137B41
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003F22 RID: 16162 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x06003F23 RID: 16163 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x06003F24 RID: 16164 RVA: 0x00139978 File Offset: 0x00137B78
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003F25 RID: 16165 RVA: 0x001399B0 File Offset: 0x00137BB0
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 316f)
			{
				this.HBJJOCHGOPH = 1373f;
			}
			this.LDNADDJMIPK().SetFloat("The other scroll rect doesnt support scrolling vertically", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("#no", this.ADPHJHEFAON);
			this.GJHLADDCMFF().SetVector("[PlayerController] ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 788f, 60f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F26 RID: 16166 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x06003F27 RID: 16167 RVA: 0x00139A6D File Offset: 0x00137C6D
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F28 RID: 16168 RVA: 0x00139A8A File Offset: 0x00137C8A
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("mapselector.filter.rateduponly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003F29 RID: 16169 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06003F2A RID: 16170 RVA: 0x00139AB0 File Offset: 0x00137CB0
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1028f)
			{
				this.HBJJOCHGOPH = 946f;
			}
			this.HCGJCMDJPGD().SetFloat("_RampTex", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("[SERVER] Kicked ", this.ADPHJHEFAON);
			this.ACHNOHCLGOO().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 376f, 678f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F2B RID: 16171 RVA: 0x00139B6D File Offset: 0x00137D6D
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003F2C RID: 16172 RVA: 0x00139A6D File Offset: 0x00137C6D
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F2D RID: 16173 RVA: 0x00139BA4 File Offset: 0x00137DA4
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 11f)
			{
				this.HBJJOCHGOPH = 731f;
			}
			this.HCGJCMDJPGD().SetFloat("ResetButton", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("_Amount", this.ADPHJHEFAON);
			this.OGMEGHKECAH().SetVector("USE_UV_BASED_REPROJECTION", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 867f, 1361f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F2E RID: 16174 RVA: 0x00139C61 File Offset: 0x00137E61
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003F2F RID: 16175 RVA: 0x00139C98 File Offset: 0x00137E98
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("[Steamworks.NET] SteamAPI_Init() failed. Refer to Valve's documentation or the comment above this line for more information.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003F30 RID: 16176 RVA: 0x00139A6D File Offset: 0x00137C6D
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F31 RID: 16177 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06003F32 RID: 16178 RVA: 0x00139CBC File Offset: 0x00137EBC
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003F33 RID: 16179 RVA: 0x00139CF3 File Offset: 0x00137EF3
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003F34 RID: 16180 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x06003F35 RID: 16181 RVA: 0x00139D2C File Offset: 0x00137F2C
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1028f)
			{
				this.HBJJOCHGOPH = 281f;
			}
			this.HEHKGPKLAKK().SetFloat("(\\[ */ *h1 *\\])", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat(") error: ", this.ADPHJHEFAON);
			this.NFMGLIKNOOC().SetVector("player.neon", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 793f, 1593f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F36 RID: 16182 RVA: 0x00139DEC File Offset: 0x00137FEC
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 161f)
			{
				this.HBJJOCHGOPH = 259f;
			}
			this.NFMGLIKNOOC().SetFloat("Particles/Additive", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("_FilteredReflections", this.ADPHJHEFAON);
			this.LONNIJMNKFB().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 65f, 850f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F37 RID: 16183 RVA: 0x00139A6D File Offset: 0x00137C6D
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F38 RID: 16184 RVA: 0x00139EA9 File Offset: 0x001380A9
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003F39 RID: 16185 RVA: 0x00139EE0 File Offset: 0x001380E0
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("#timeuntilchallenge: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003F3A RID: 16186 RVA: 0x00139A6D File Offset: 0x00137C6D
	private void IABLKKAALGI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F3B RID: 16187 RVA: 0x00139F04 File Offset: 0x00138104
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1446f)
			{
				this.HBJJOCHGOPH = 195f;
			}
			this.HCGJCMDJPGD().SetFloat("_BlurRadius4", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("menu.playedsolo", this.ADPHJHEFAON);
			this.PDEAHJPOMEF().SetVector("Player Connected", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 216f, 1688f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F3C RID: 16188 RVA: 0x00139A6D File Offset: 0x00137C6D
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F3D RID: 16189 RVA: 0x00139FC1 File Offset: 0x001381C1
	private void HAIAHJPCPAG()
	{
		this.SCShader = Shader.Find("Item ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003F3E RID: 16190 RVA: 0x00139FE5 File Offset: 0x001381E5
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003F3F RID: 16191 RVA: 0x0013A01C File Offset: 0x0013821C
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Plasma");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003F40 RID: 16192 RVA: 0x0013A040 File Offset: 0x00138240
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 635f)
			{
				this.HBJJOCHGOPH = 1928f;
			}
			this.LDNADDJMIPK().SetFloat("Drop_Near", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("data", this.ADPHJHEFAON);
			this.ACHNOHCLGOO().SetVector("LevelProgressBar", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 759f, 445f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F41 RID: 16193 RVA: 0x0013A0FD File Offset: 0x001382FD
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003F42 RID: 16194 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06003F43 RID: 16195 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06003F44 RID: 16196 RVA: 0x0013A124 File Offset: 0x00138324
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 463f)
			{
				this.HBJJOCHGOPH = 370f;
			}
			this.HNICHJCGJOC().SetFloat("Submition failed", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("ICollection", this.ADPHJHEFAON);
			this.LONNIJMNKFB().SetVector(" or ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1443f, 539f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F45 RID: 16197 RVA: 0x00139A6D File Offset: 0x00137C6D
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F46 RID: 16198 RVA: 0x0013A1E1 File Offset: 0x001383E1
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("[EditorEvent] Exception: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003F47 RID: 16199 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06003F48 RID: 16200 RVA: 0x0013A205 File Offset: 0x00138405
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("PLEASE WAIT");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003F49 RID: 16201 RVA: 0x0013A22C File Offset: 0x0013842C
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1328f)
			{
				this.HBJJOCHGOPH = 292f;
			}
			this.JLHLHKPHDFO().SetFloat("_Value", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("Validating mod pack...", this.ADPHJHEFAON);
			this.EOCCJGIGEGJ().SetVector("<b>", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 35f, 1772f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F4A RID: 16202 RVA: 0x0013A2E9 File Offset: 0x001384E9
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-81);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003F4B RID: 16203 RVA: 0x0013A320 File Offset: 0x00138520
	private Material GHHPOGODBHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003F4C RID: 16204 RVA: 0x0013A358 File Offset: 0x00138558
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 665f)
			{
				this.HBJJOCHGOPH = 1761f;
			}
			this.EOCCJGIGEGJ().SetFloat(" ", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat("_Value4", this.ADPHJHEFAON);
			this.JLHLHKPHDFO().SetVector("\n\n• ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1600f, 533f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F4D RID: 16205 RVA: 0x0013A415 File Offset: 0x00138615
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003F4E RID: 16206 RVA: 0x0013A43C File Offset: 0x0013863C
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 129f)
			{
				this.HBJJOCHGOPH = 1944f;
			}
			this.NBPKMLMCHFN.SetFloat("_Colorisation", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat("wss://", this.ADPHJHEFAON);
			this.ACHNOHCLGOO().SetVector("SetEnvSpriteImage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 759f, 1595f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F4F RID: 16207 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x06003F50 RID: 16208 RVA: 0x0013A4F9 File Offset: 0x001386F9
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("_AlphaUV");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003F51 RID: 16209 RVA: 0x0013A520 File Offset: 0x00138720
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 316f)
			{
				this.HBJJOCHGOPH = 807f;
			}
			this.HNICHJCGJOC().SetFloat("Set Crosshair Color", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat(" timeUntilRespawn: ", this.ADPHJHEFAON);
			this.PDEAHJPOMEF().SetVector("CameraFilterPack/Vision_Aura", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 725f, 857f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x170000B7 RID: 183
	// (get) Token: 0x06003F52 RID: 16210 RVA: 0x0013A5DD File Offset: 0x001387DD
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

	// Token: 0x06003F53 RID: 16211 RVA: 0x0013A614 File Offset: 0x00138814
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003F54 RID: 16212 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003F55 RID: 16213 RVA: 0x0013A64B File Offset: 0x0013884B
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003F56 RID: 16214 RVA: 0x00139A6D File Offset: 0x00137C6D
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F57 RID: 16215 RVA: 0x0013A66F File Offset: 0x0013886F
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003F58 RID: 16216 RVA: 0x0013A693 File Offset: 0x00138893
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003F59 RID: 16217 RVA: 0x0013A693 File Offset: 0x00138893
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003F5A RID: 16218 RVA: 0x0013A6CA File Offset: 0x001388CA
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003F5B RID: 16219 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x06003F5C RID: 16220 RVA: 0x0013A6EE File Offset: 0x001388EE
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find("#FFDA44");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003F5D RID: 16221 RVA: 0x0013A714 File Offset: 0x00138914
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1404f)
			{
				this.HBJJOCHGOPH = 932f;
			}
			this.HNICHJCGJOC().SetFloat("VisionBlur", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("JoinRoom failed (room maybe closed by now). Client stays on masterserver: {0}. State: {1}", this.ADPHJHEFAON);
			this.NFMGLIKNOOC().SetVector("{0}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 156f, 1067f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F5E RID: 16222 RVA: 0x00139A6D File Offset: 0x00137C6D
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F60 RID: 16224 RVA: 0x0013A7EF File Offset: 0x001389EF
	private void DKGBFNCOAEO()
	{
		this.SCShader = Shader.Find("Room: '{0}' {1},{2} {4}/{3} players.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003F61 RID: 16225 RVA: 0x0013A814 File Offset: 0x00138A14
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 768f)
			{
				this.HBJJOCHGOPH = 386f;
			}
			this.OGMEGHKECAH().SetFloat("_BlueAmplifier", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("Tab2Content", this.ADPHJHEFAON);
			this.ACHNOHCLGOO().SetVector("OnPlayerGameMessage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1267f, 70f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F62 RID: 16226 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x06003F63 RID: 16227 RVA: 0x00139A6D File Offset: 0x00137C6D
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F64 RID: 16228 RVA: 0x0013A8D4 File Offset: 0x00138AD4
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1072f)
			{
				this.HBJJOCHGOPH = 1080f;
			}
			this.ACHNOHCLGOO().SetFloat("CameraFilterPack/FX_Glitch1", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Radius", this.ADPHJHEFAON);
			this.HCGJCMDJPGD().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1076f, 438f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F65 RID: 16229 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06003F66 RID: 16230 RVA: 0x0013A994 File Offset: 0x00138B94
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.ADPHJHEFAON);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003F67 RID: 16231 RVA: 0x0013AA51 File Offset: 0x00138C51
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003F68 RID: 16232 RVA: 0x00139CBC File Offset: 0x00137EBC
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003F69 RID: 16233 RVA: 0x0013AA75 File Offset: 0x00138C75
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("LivesSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003F6A RID: 16234 RVA: 0x00139A6D File Offset: 0x00137C6D
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003F6B RID: 16235 RVA: 0x0013AA99 File Offset: 0x00138C99
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("Sep");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x040006C9 RID: 1737
	public Shader SCShader;

	// Token: 0x040006CA RID: 1738
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040006CB RID: 1739
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040006CC RID: 1740
	private Material BJFKDHHMLJH;

	// Token: 0x040006CD RID: 1741
	[Range(0f, 20f)]
	private float ADPHJHEFAON = 6f;
}
