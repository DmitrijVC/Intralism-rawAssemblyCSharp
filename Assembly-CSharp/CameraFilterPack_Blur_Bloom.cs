using System;
using UnityEngine;

// Token: 0x0200005B RID: 91
[AddComponentMenu("Camera Filter Pack/Blur/Bloom")]
[ExecuteInEditMode]
public class CameraFilterPack_Blur_Bloom : MonoBehaviour
{
	// Token: 0x0600198C RID: 6540 RVA: 0x000A1343 File Offset: 0x0009F543
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600198D RID: 6541 RVA: 0x000A1360 File Offset: 0x0009F560
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600198E RID: 6542 RVA: 0x000A1398 File Offset: 0x0009F598
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1037f)
			{
				this.HBJJOCHGOPH = 667f;
			}
			this.HKHBBBFLGJH().SetFloat("LevelEditor/CustomEventEditor-", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetFloat("maps.", this.Amount);
			this.JLHLHKPHDFO().SetFloat("settings_bindings_controller_type", this.Glow);
			this.MLMKCOINOOH().SetVector("_Near", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600198F RID: 6543 RVA: 0x000A1464 File Offset: 0x0009F664
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 255f)
			{
				this.HBJJOCHGOPH = 1826f;
			}
			this.CIAFLBFJLEJ().SetFloat("[PlayerController] ", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("_TimeX", this.Amount);
			this.DKNJGHFLAIF().SetFloat(" or ", this.Glow);
			this.HNFFHCLNBDN().SetVector("speed", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001990 RID: 6544 RVA: 0x000A1343 File Offset: 0x0009F543
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001991 RID: 6545 RVA: 0x000A1530 File Offset: 0x0009F730
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("Can't do manual instantiation without PhotonView component.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001992 RID: 6546 RVA: 0x000A1554 File Offset: 0x0009F754
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("#ok");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001993 RID: 6547 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x06001994 RID: 6548 RVA: 0x000A1343 File Offset: 0x0009F543
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001995 RID: 6549 RVA: 0x000A1578 File Offset: 0x0009F778
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
			this.NBPKMLMCHFN.SetFloat("_Amount", this.Amount);
			this.NBPKMLMCHFN.SetFloat("_Glow", this.Glow);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001996 RID: 6550 RVA: 0x000A1644 File Offset: 0x0009F844
	private void JABNHMIHBHC()
	{
		this.SCShader = Shader.Find("BloodAlternative3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001997 RID: 6551 RVA: 0x000A1668 File Offset: 0x0009F868
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("_TapMedium");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001998 RID: 6552 RVA: 0x000A1343 File Offset: 0x0009F543
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001999 RID: 6553 RVA: 0x000A1343 File Offset: 0x0009F543
	private void GNPDGBNDCPL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600199A RID: 6554 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x0600199B RID: 6555 RVA: 0x000A168C File Offset: 0x0009F88C
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600199C RID: 6556 RVA: 0x000A16B0 File Offset: 0x0009F8B0
	private Material LPPEPKGFOEM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600199D RID: 6557 RVA: 0x000A16E8 File Offset: 0x0009F8E8
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 318f)
			{
				this.HBJJOCHGOPH = 351f;
			}
			this.HNFFHCLNBDN().SetFloat("Case-Sensitive", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("#8E8E8EFF", this.Amount);
			this.CIAFLBFJLEJ().SetFloat("Setting autoCleanUpPlayerObjects while in a room is not supported.", this.Glow);
			this.ADGHJOHKEHG().SetVector("#exit", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600199E RID: 6558 RVA: 0x000A17B4 File Offset: 0x0009F9B4
	private void LIBGAKMKHJJ()
	{
		this.SCShader = Shader.Find("_Blue_R");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600199F RID: 6559 RVA: 0x000A17D8 File Offset: 0x0009F9D8
	private void MKOMIDCPCDC()
	{
		this.SCShader = Shader.Find("settings.selectormapsperpage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060019A0 RID: 6560 RVA: 0x000A17FC File Offset: 0x0009F9FC
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1194f)
			{
				this.HBJJOCHGOPH = 783f;
			}
			this.CIAFLBFJLEJ().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.CBCNOEIALHB().SetFloat("_BlurCoe", this.Amount);
			this.CIAFLBFJLEJ().SetFloat(".lastCheckpoint.checkpointsUsed", this.Glow);
			this.CIAFLBFJLEJ().SetVector("/", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060019A1 RID: 6561 RVA: 0x000A18C8 File Offset: 0x0009FAC8
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060019A2 RID: 6562 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x060019A3 RID: 6563 RVA: 0x000A18FF File Offset: 0x0009FAFF
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060019A4 RID: 6564 RVA: 0x000A1938 File Offset: 0x0009FB38
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1599f)
			{
				this.HBJJOCHGOPH = 1031f;
			}
			this.HKHBBBFLGJH().SetFloat(": ", this.HBJJOCHGOPH);
			this.LPPEPKGFOEM().SetFloat("_TimeX", this.Amount);
			this.KHCLIAMBBNC().SetFloat("EventMenu", this.Glow);
			this.NBMPPNFKFLB().SetVector("player.blackcat", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060019A5 RID: 6565 RVA: 0x000A1A04 File Offset: 0x0009FC04
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060019A6 RID: 6566 RVA: 0x000A1A3B File Offset: 0x0009FC3B
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)118;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060019A7 RID: 6567 RVA: 0x000A1A72 File Offset: 0x0009FC72
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("Joystick1Button5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060019A8 RID: 6568 RVA: 0x000A1A98 File Offset: 0x0009FC98
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1582f)
			{
				this.HBJJOCHGOPH = 1894f;
			}
			this.EHDJJANLINB().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat("/", this.Amount);
			this.LENEJAGLCNL().SetFloat("Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", this.Glow);
			this.MJJIEHANFJA().SetVector("Error: I/O Failure! :(", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060019A9 RID: 6569 RVA: 0x000A1B64 File Offset: 0x0009FD64
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 425f)
			{
				this.HBJJOCHGOPH = 1073f;
			}
			this.KHCLIAMBBNC().SetFloat("_BlurParams", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("_Distortion", this.Amount);
			this.DOHGBNPMBKG().SetFloat("_Green_C", this.Glow);
			this.CBCNOEIALHB().SetVector("ClearEnvironment", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060019AA RID: 6570 RVA: 0x000A1C30 File Offset: 0x0009FE30
	private void DKGBFNCOAEO()
	{
		this.SCShader = Shader.Find("settings.volume.editor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060019AB RID: 6571 RVA: 0x000A1C54 File Offset: 0x0009FE54
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060019AC RID: 6572 RVA: 0x000A1343 File Offset: 0x0009F543
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060019AD RID: 6573 RVA: 0x000A1C8C File Offset: 0x0009FE8C
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 104f)
			{
				this.HBJJOCHGOPH = 501f;
			}
			this.IGIAPKPKGPK().SetFloat(" respawn: ", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("Object ID. Case-Sensitive", this.Amount);
			this.ADGHJOHKEHG().SetFloat("LevelEditor/patterns", this.Glow);
			this.LONNIJMNKFB().SetVector("_TimeX", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060019AE RID: 6574 RVA: 0x000A1D58 File Offset: 0x0009FF58
	private Material KHCLIAMBBNC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060019AF RID: 6575 RVA: 0x000A1343 File Offset: 0x0009F543
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060019B0 RID: 6576 RVA: 0x0002523B File Offset: 0x0002343B
	private void FAKGFMFAPDG()
	{
	}

	// Token: 0x060019B1 RID: 6577 RVA: 0x000A1D8F File Offset: 0x0009FF8F
	private Material CECJJMKLEAK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060019B2 RID: 6578 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x060019B3 RID: 6579 RVA: 0x000A1DC6 File Offset: 0x0009FFC6
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("ShowSprite");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060019B4 RID: 6580 RVA: 0x000A1343 File Offset: 0x0009F543
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000041 RID: 65
	// (get) Token: 0x060019B5 RID: 6581 RVA: 0x000A1DEA File Offset: 0x0009FFEA
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

	// Token: 0x060019B6 RID: 6582 RVA: 0x000A1343 File Offset: 0x0009F543
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060019B7 RID: 6583 RVA: 0x000A1E21 File Offset: 0x000A0021
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("_EmissionGain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060019B8 RID: 6584 RVA: 0x000A1E45 File Offset: 0x000A0045
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blur_Bloom");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060019B9 RID: 6585 RVA: 0x000A1E6C File Offset: 0x000A006C
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1610f)
			{
				this.HBJJOCHGOPH = 436f;
			}
			this.MJJIEHANFJA().SetFloat("_Color", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("CameraFilterPack/FX_Screens", this.Amount);
			this.LPPEPKGFOEM().SetFloat("<color=#{0}>{1}</color>", this.Glow);
			this.KBOPGONOCNP().SetVector("_Value2", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060019BA RID: 6586 RVA: 0x000A1F38 File Offset: 0x000A0138
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1434f)
			{
				this.HBJJOCHGOPH = 1980f;
			}
			this.EHDJJANLINB().SetFloat("colorD", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat("\r", this.Amount);
			this.IGIAPKPKGPK().SetFloat("\\", this.Glow);
			this.JLHLHKPHDFO().SetVector("OnPressRight", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060019BB RID: 6587 RVA: 0x000A2004 File Offset: 0x000A0204
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060019BC RID: 6588 RVA: 0x000A203B File Offset: 0x000A023B
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060019BD RID: 6589 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x060019BE RID: 6590 RVA: 0x000A2060 File Offset: 0x000A0260
	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 747f)
			{
				this.HBJJOCHGOPH = 260f;
			}
			this.ADGHJOHKEHG().SetFloat("GameScene", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat(".lastCheckpoint.maxLongestCombo", this.Amount);
			this.LPPEPKGFOEM().SetFloat("#savemapchanges?", this.Glow);
			this.CBCNOEIALHB().SetVector("_Value4", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060019BF RID: 6591 RVA: 0x000A212C File Offset: 0x000A032C
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 709f)
			{
				this.HBJJOCHGOPH = 762f;
			}
			this.KHCLIAMBBNC().SetFloat("inventory.selected.", this.HBJJOCHGOPH);
			this.CECJJMKLEAK().SetFloat("MenuScene", this.Amount);
			this.HKHBBBFLGJH().SetFloat("UseScanLine", this.Glow);
			this.IGIAPKPKGPK().SetVector("/files/editor_manual.pdf", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060019C0 RID: 6592 RVA: 0x000A21F8 File Offset: 0x000A03F8
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find("AudioSampler");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060019C1 RID: 6593 RVA: 0x0002523B File Offset: 0x0002343B
	private void MBLDJEFBLFL()
	{
	}

	// Token: 0x060019C2 RID: 6594 RVA: 0x000A221C File Offset: 0x000A041C
	private Material MJJIEHANFJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)110;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060019C3 RID: 6595 RVA: 0x000A1343 File Offset: 0x0009F543
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060019C4 RID: 6596 RVA: 0x000A2253 File Offset: 0x000A0453
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060019C5 RID: 6597 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x060019C6 RID: 6598 RVA: 0x000A1343 File Offset: 0x0009F543
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060019C7 RID: 6599 RVA: 0x000A228A File Offset: 0x000A048A
	private Material CBCNOEIALHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060019C8 RID: 6600 RVA: 0x000A1343 File Offset: 0x0009F543
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060019C9 RID: 6601 RVA: 0x000A203B File Offset: 0x000A023B
	private void FLKEJJEGCFA()
	{
		this.SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060019CA RID: 6602 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x060019CB RID: 6603 RVA: 0x000A22C1 File Offset: 0x000A04C1
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find("HandsCountSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060019CC RID: 6604 RVA: 0x000A22E5 File Offset: 0x000A04E5
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060019CD RID: 6605 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060019CE RID: 6606 RVA: 0x000A231C File Offset: 0x000A051C
	private void COOHIILCOCO()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060019CF RID: 6607 RVA: 0x000A2340 File Offset: 0x000A0540
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Vision_Blood_Fast");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060019D0 RID: 6608 RVA: 0x000A2364 File Offset: 0x000A0564
	private void OPHBLNNGFKG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 686f)
			{
				this.HBJJOCHGOPH = 1067f;
			}
			this.KBOPGONOCNP().SetFloat(" in-game items", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("PerfectHitsScoreText", this.Amount);
			this.HNFFHCLNBDN().SetFloat("[Right-Down]", this.Glow);
			this.MLMKCOINOOH().SetVector("_Value3", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060019D1 RID: 6609 RVA: 0x0002523B File Offset: 0x0002343B
	private void HCIPECAOGIA()
	{
	}

	// Token: 0x060019D2 RID: 6610 RVA: 0x000A2430 File Offset: 0x000A0630
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1091f)
			{
				this.HBJJOCHGOPH = 1696f;
			}
			this.LENEJAGLCNL().SetFloat("action", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("default", this.Amount);
			this.CIAFLBFJLEJ().SetFloat("\r", this.Glow);
			this.MLMKCOINOOH().SetVector("Load Game", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060019D3 RID: 6611 RVA: 0x000A24FC File Offset: 0x000A06FC
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060019D4 RID: 6612 RVA: 0x000A2533 File Offset: 0x000A0733
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060019D5 RID: 6613 RVA: 0x000A1343 File Offset: 0x0009F543
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060019D6 RID: 6614 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x060019D7 RID: 6615 RVA: 0x000A1343 File Offset: 0x0009F543
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060019D8 RID: 6616 RVA: 0x000A256A File Offset: 0x000A076A
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("FullscreenToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060019D9 RID: 6617 RVA: 0x000A258E File Offset: 0x000A078E
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060019DA RID: 6618 RVA: 0x000A25C5 File Offset: 0x000A07C5
	private Material MLMKCOINOOH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060019DB RID: 6619 RVA: 0x0002523B File Offset: 0x0002343B
	private void COGBDFKOHKK()
	{
	}

	// Token: 0x060019DC RID: 6620 RVA: 0x000A25FC File Offset: 0x000A07FC
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060019DD RID: 6621 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x060019DE RID: 6622 RVA: 0x000A2634 File Offset: 0x000A0834
	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1024f)
			{
				this.HBJJOCHGOPH = 1368f;
			}
			this.EHDJJANLINB().SetFloat("_AlphaHexa", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("InventoryButton", this.Amount);
			this.HKHBBBFLGJH().SetFloat("RecordButton", this.Glow);
			this.KBOPGONOCNP().SetVector("Use \"/help\" for commands list", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060019DF RID: 6623 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x060019E0 RID: 6624 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x060019E1 RID: 6625 RVA: 0x0002523B File Offset: 0x0002343B
	private void POEMOLBJDLG()
	{
	}

	// Token: 0x060019E2 RID: 6626 RVA: 0x000A2700 File Offset: 0x000A0900
	private void JFJLGJEPEAA()
	{
		this.SCShader = Shader.Find("AddEnvironmentObject");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060019E3 RID: 6627 RVA: 0x000A2724 File Offset: 0x000A0924
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060019E4 RID: 6628 RVA: 0x000A275B File Offset: 0x000A095B
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("[LevelEditorScene] Map submitted!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060019E5 RID: 6629 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIFLPHLGLFG()
	{
	}

	// Token: 0x060019E6 RID: 6630 RVA: 0x000A277F File Offset: 0x000A097F
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)88;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060019E7 RID: 6631 RVA: 0x000A27B6 File Offset: 0x000A09B6
	private void JONGNKNLLND()
	{
		this.SCShader = Shader.Find("id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060019E8 RID: 6632 RVA: 0x000A27DA File Offset: 0x000A09DA
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060019E9 RID: 6633 RVA: 0x000A2811 File Offset: 0x000A0A11
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060019EB RID: 6635 RVA: 0x000A2874 File Offset: 0x000A0A74
	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 831f)
			{
				this.HBJJOCHGOPH = 1010f;
			}
			this.CECJJMKLEAK().SetFloat("_Value", this.HBJJOCHGOPH);
			this.LMLENGFLEBD().SetFloat("_BlurCoe", this.Amount);
			this.CECJJMKLEAK().SetFloat("UseFinalGlassColor", this.Glow);
			this.HNFFHCLNBDN().SetVector("_Value4", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060019EC RID: 6636 RVA: 0x000A2940 File Offset: 0x000A0B40
	private void HPFOFGJPNCI()
	{
		this.SCShader = Shader.Find("_SweaterSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060019ED RID: 6637 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x060019EE RID: 6638 RVA: 0x000A2964 File Offset: 0x000A0B64
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("Failed to Instantiate prefab:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060019EF RID: 6639 RVA: 0x000A1343 File Offset: 0x0009F543
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060019F0 RID: 6640 RVA: 0x000A1343 File Offset: 0x0009F543
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060019F1 RID: 6641 RVA: 0x000A2988 File Offset: 0x000A0B88
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 972f)
			{
				this.HBJJOCHGOPH = 432f;
			}
			this.LENEJAGLCNL().SetFloat("Mouse X", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("[LevelEditorScene] Print Audio Wave: Done", this.Amount);
			this.FOOCJIDNGBB().SetFloat("SetSatelliteTrailMinVertexDistance", this.Glow);
			this.LMLENGFLEBD().SetVector("Done!", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060019F2 RID: 6642 RVA: 0x000A2A54 File Offset: 0x000A0C54
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("inventory.selected.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060019F3 RID: 6643 RVA: 0x000A1343 File Offset: 0x0009F543
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060019F4 RID: 6644 RVA: 0x000A1343 File Offset: 0x0009F543
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060019F5 RID: 6645 RVA: 0x000A2A78 File Offset: 0x000A0C78
	private void LGHCJCFHEMF()
	{
		this.SCShader = Shader.Find("CountEventsGoal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060019F6 RID: 6646 RVA: 0x000A2A9C File Offset: 0x000A0C9C
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("0.00");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060019F7 RID: 6647 RVA: 0x000A1343 File Offset: 0x0009F543
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060019F8 RID: 6648 RVA: 0x000A2AC0 File Offset: 0x000A0CC0
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060019F9 RID: 6649 RVA: 0x000A2AF7 File Offset: 0x000A0CF7
	private void GLEJGFLCLPJ()
	{
		this.SCShader = Shader.Find("ticket");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060019FA RID: 6650 RVA: 0x000A1343 File Offset: 0x0009F543
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060019FB RID: 6651 RVA: 0x000A2B1B File Offset: 0x000A0D1B
	private Material FOOCJIDNGBB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-85);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060019FC RID: 6652 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x060019FD RID: 6653 RVA: 0x000A2B54 File Offset: 0x000A0D54
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 562f)
			{
				this.HBJJOCHGOPH = 1369f;
			}
			this.CBCNOEIALHB().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("OnRenderImage in Helper called ...", this.Amount);
			this.KHCLIAMBBNC().SetFloat("0", this.Glow);
			this.LMLENGFLEBD().SetVector("mapselector.filter.subscribedonly", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060019FE RID: 6654 RVA: 0x000A2C20 File Offset: 0x000A0E20
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060019FF RID: 6655 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKMELABKBHO()
	{
	}

	// Token: 0x06001A00 RID: 6656 RVA: 0x000A2C57 File Offset: 0x000A0E57
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("{0:0}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001A01 RID: 6657 RVA: 0x000A2C7C File Offset: 0x000A0E7C
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 451f)
			{
				this.HBJJOCHGOPH = 104f;
			}
			this.LMLENGFLEBD().SetFloat("Object ID. Case-Sensitive", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetFloat("_Value4", this.Amount);
			this.LONNIJMNKFB().SetFloat("CameraFilterPack/Blend2Camera_Color", this.Glow);
			this.KHCLIAMBBNC().SetVector("SetCrosshairColor", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A02 RID: 6658 RVA: 0x000A2D48 File Offset: 0x000A0F48
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("[#clicktogetreward]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001A03 RID: 6659 RVA: 0x000A2D6C File Offset: 0x000A0F6C
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 515f)
			{
				this.HBJJOCHGOPH = 1793f;
			}
			this.IGIAPKPKGPK().SetFloat("DestroyPlayerObjects() failed, cause parameter 'targetPlayer' was null.", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Amount);
			this.LMLENGFLEBD().SetFloat("B", this.Glow);
			this.LDNADDJMIPK().SetVector(" (", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x04000396 RID: 918
	public Shader SCShader;

	// Token: 0x04000397 RID: 919
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000398 RID: 920
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000399 RID: 921
	private Material BJFKDHHMLJH;

	// Token: 0x0400039A RID: 922
	[Range(0f, 10f)]
	public float Amount = 4.5f;

	// Token: 0x0400039B RID: 923
	[Range(0f, 1f)]
	public float Glow = 0.5f;
}
