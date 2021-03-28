using System;
using UnityEngine;

// Token: 0x02000083 RID: 131
[AddComponentMenu("Camera Filter Pack/Convert/NormalMap")]
[ExecuteInEditMode]
public class CameraFilterPack_Convert_Normal : MonoBehaviour
{
	// Token: 0x06002558 RID: 9560 RVA: 0x000D564B File Offset: 0x000D384B
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002559 RID: 9561 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x0600255A RID: 9562 RVA: 0x0002523B File Offset: 0x0002343B
	private void MDCFIHDPLIG()
	{
	}

	// Token: 0x0600255B RID: 9563 RVA: 0x000D5668 File Offset: 0x000D3868
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600255C RID: 9564 RVA: 0x000D56A0 File Offset: 0x000D38A0
	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.KGOLDDBHIFN().SetFloat("_ScreenResolution", this._Heigh);
			this.OGMEGHKECAH().SetFloat("OneHand", this._Intervale);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600255D RID: 9565 RVA: 0x000D5703 File Offset: 0x000D3903
	private void MDNHCLKNCLE()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600255E RID: 9566 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x0600255F RID: 9567 RVA: 0x000D5727 File Offset: 0x000D3927
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find("CameraFilterPack_AAA_Blood1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002560 RID: 9568 RVA: 0x000D574B File Offset: 0x000D394B
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-82);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002561 RID: 9569 RVA: 0x000D5782 File Offset: 0x000D3982
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Color_Convert_Normal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002562 RID: 9570 RVA: 0x000D564B File Offset: 0x000D384B
	private void IEFMONDKKJN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002563 RID: 9571 RVA: 0x000D564B File Offset: 0x000D384B
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002564 RID: 9572 RVA: 0x000D57A8 File Offset: 0x000D39A8
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.NFKFAAHHLLM().SetFloat("replayData", this._Heigh);
			this.NBPKMLMCHFN.SetFloat(". MasterClient: ", this._Intervale);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002565 RID: 9573 RVA: 0x000D580B File Offset: 0x000D3A0B
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002566 RID: 9574 RVA: 0x000D5830 File Offset: 0x000D3A30
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.KGOLDDBHIFN().SetFloat("finished", this._Heigh);
			this.NDMPCDHADMJ().SetFloat("EventTimeInputField", this._Intervale);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002567 RID: 9575 RVA: 0x000D5893 File Offset: 0x000D3A93
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("|");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002568 RID: 9576 RVA: 0x000D58B8 File Offset: 0x000D3AB8
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.NBPKMLMCHFN.SetFloat("_Heigh", this._Heigh);
			this.NBPKMLMCHFN.SetFloat("_Intervale", this._Intervale);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002569 RID: 9577 RVA: 0x000D591B File Offset: 0x000D3B1B
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600256A RID: 9578 RVA: 0x000D5952 File Offset: 0x000D3B52
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("EventSystem");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600256B RID: 9579 RVA: 0x0002523B File Offset: 0x0002343B
	private void APKNAPHOFHC()
	{
	}

	// Token: 0x0600256C RID: 9580 RVA: 0x000D5976 File Offset: 0x000D3B76
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600256D RID: 9581 RVA: 0x000D59B0 File Offset: 0x000D3BB0
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.OJMHIMIPKME().SetFloat("Items/", this._Heigh);
			this.LDNADDJMIPK().SetFloat("Is it practically possible?", this._Intervale);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600256E RID: 9582 RVA: 0x000D5A13 File Offset: 0x000D3C13
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600256F RID: 9583 RVA: 0x000D564B File Offset: 0x000D384B
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002570 RID: 9584 RVA: 0x000D5A4A File Offset: 0x000D3C4A
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002571 RID: 9585 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCDLIKEDMCF()
	{
	}

	// Token: 0x06002572 RID: 9586 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06002573 RID: 9587 RVA: 0x000D5A6E File Offset: 0x000D3C6E
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002574 RID: 9588 RVA: 0x000D5AA5 File Offset: 0x000D3CA5
	private void DFFKKLAPHCC()
	{
		this.SCShader = Shader.Find("blue");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002575 RID: 9589 RVA: 0x000D5ACC File Offset: 0x000D3CCC
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.OJMHIMIPKME().SetFloat("settings.enablerankingnotifications", this._Heigh);
			this.NFKFAAHHLLM().SetFloat("Trackpad", this._Intervale);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002576 RID: 9590 RVA: 0x000D5B2F File Offset: 0x000D3D2F
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find(".");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002577 RID: 9591 RVA: 0x000D564B File Offset: 0x000D384B
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002578 RID: 9592 RVA: 0x000D5B53 File Offset: 0x000D3D53
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("shader.future");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002579 RID: 9593 RVA: 0x000D564B File Offset: 0x000D384B
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600257A RID: 9594 RVA: 0x000D5B78 File Offset: 0x000D3D78
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.LONNIJMNKFB().SetFloat(",", this._Heigh);
			this.OJMHIMIPKME().SetFloat("_Saturation", this._Intervale);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600257B RID: 9595 RVA: 0x000D5BDB File Offset: 0x000D3DDB
	private void ODBNMPGBCGO()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600257C RID: 9596 RVA: 0x000D5BFF File Offset: 0x000D3DFF
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-68);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600257D RID: 9597 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x0600257E RID: 9598 RVA: 0x000D5C38 File Offset: 0x000D3E38
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.NFKFAAHHLLM().SetFloat("menu.tabid", this._Heigh);
			this.KAFBNOBOIAJ().SetFloat("F3", this._Intervale);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600257F RID: 9599 RVA: 0x0002523B File Offset: 0x0002343B
	private void EPJJDKJEDMM()
	{
	}

	// Token: 0x17000068 RID: 104
	// (get) Token: 0x06002580 RID: 9600 RVA: 0x000D5C9B File Offset: 0x000D3E9B
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

	// Token: 0x06002581 RID: 9601 RVA: 0x000D564B File Offset: 0x000D384B
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002582 RID: 9602 RVA: 0x000D5CD4 File Offset: 0x000D3ED4
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.AELJLBOJAIL().SetFloat("checkpoint", this._Heigh);
			this.LDNADDJMIPK().SetFloat("Failed to InstantiateSceneObject prefab:", this._Intervale);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002583 RID: 9603 RVA: 0x000D564B File Offset: 0x000D384B
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002584 RID: 9604 RVA: 0x000D5D37 File Offset: 0x000D3F37
	private Material OJMHIMIPKME()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002585 RID: 9605 RVA: 0x000D5D70 File Offset: 0x000D3F70
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.DOHGBNPMBKG().SetFloat("Set Sun MinSize", this._Heigh);
			this.BAGICADFBAB().SetFloat("UI Extensions/SoftMaskShader", this._Intervale);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002587 RID: 9607 RVA: 0x000D564B File Offset: 0x000D384B
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002588 RID: 9608 RVA: 0x000D5DF1 File Offset: 0x000D3FF1
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002589 RID: 9609 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x0600258A RID: 9610 RVA: 0x000D5E18 File Offset: 0x000D4018
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.DNLMFEGJJDD().SetFloat(" or player:", this._Heigh);
			this.BAGICADFBAB().SetFloat("[SERVER] Kicked ", this._Intervale);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600258B RID: 9611 RVA: 0x000D5E7B File Offset: 0x000D407B
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("_EmissionGain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600258C RID: 9612 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x0600258D RID: 9613 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x0600258E RID: 9614 RVA: 0x000D5E9F File Offset: 0x000D409F
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600258F RID: 9615 RVA: 0x000D5ED6 File Offset: 0x000D40D6
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)76;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002590 RID: 9616 RVA: 0x000D5F10 File Offset: 0x000D4110
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.NFKFAAHHLLM().SetFloat("Joystick1Button", this._Heigh);
			this.OGMEGHKECAH().SetFloat("SetPosition", this._Intervale);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002591 RID: 9617 RVA: 0x000D564B File Offset: 0x000D384B
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002592 RID: 9618 RVA: 0x000D5F73 File Offset: 0x000D4173
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002593 RID: 9619 RVA: 0x000D564B File Offset: 0x000D384B
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002594 RID: 9620 RVA: 0x000D5FAA File Offset: 0x000D41AA
	private void COOHIILCOCO()
	{
		this.SCShader = Shader.Find("roomDescription");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002595 RID: 9621 RVA: 0x000D564B File Offset: 0x000D384B
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002596 RID: 9622 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06002597 RID: 9623 RVA: 0x000D5FD0 File Offset: 0x000D41D0
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.OGMEGHKECAH().SetFloat("CameraFilterPack/Atmosphere_Snow_8bits", this._Heigh);
			this.BAGICADFBAB().SetFloat("_TimeX", this._Intervale);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002598 RID: 9624 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06002599 RID: 9625 RVA: 0x000D6033 File Offset: 0x000D4233
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("StartButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600259A RID: 9626 RVA: 0x000D564B File Offset: 0x000D384B
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600259B RID: 9627 RVA: 0x000D6057 File Offset: 0x000D4257
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600259C RID: 9628 RVA: 0x000D608E File Offset: 0x000D428E
	private Material EFMCNLELMDO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600259D RID: 9629 RVA: 0x000D60C8 File Offset: 0x000D42C8
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.DNLMFEGJJDD().SetFloat("Drop_Near", this._Heigh);
			this.DBOLLHHMKKN().SetFloat("_OcclusionTexture", this._Intervale);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600259E RID: 9630 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x0600259F RID: 9631 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x060025A0 RID: 9632 RVA: 0x000D612B File Offset: 0x000D432B
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("[Down]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060025A1 RID: 9633 RVA: 0x000D564B File Offset: 0x000D384B
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060025A2 RID: 9634 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x060025A3 RID: 9635 RVA: 0x000D614F File Offset: 0x000D434F
	private void AEDDNDHCLNN()
	{
		this.SCShader = Shader.Find("masterVolume");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060025A4 RID: 9636 RVA: 0x000D6174 File Offset: 0x000D4374
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.DOHGBNPMBKG().SetFloat("_PColor", this._Heigh);
			this.BAGICADFBAB().SetFloat("StopSounds", this._Intervale);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060025A5 RID: 9637 RVA: 0x000D564B File Offset: 0x000D384B
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060025A6 RID: 9638 RVA: 0x000D564B File Offset: 0x000D384B
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060025A7 RID: 9639 RVA: 0x000D61D8 File Offset: 0x000D43D8
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.OJMHIMIPKME().SetFloat("_ScreenResolution", this._Heigh);
			this.LDNADDJMIPK().SetFloat("Clears all text from the debug console", this._Intervale);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060025A8 RID: 9640 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x060025A9 RID: 9641 RVA: 0x000D623B File Offset: 0x000D443B
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060025AA RID: 9642 RVA: 0x000D564B File Offset: 0x000D384B
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060025AB RID: 9643 RVA: 0x000D6274 File Offset: 0x000D4474
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.NBMPPNFKFLB().SetFloat("_Value", this._Heigh);
			this.OJMHIMIPKME().SetFloat("CameraFilterPack_Paper3", this._Intervale);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060025AC RID: 9644 RVA: 0x000D62D7 File Offset: 0x000D44D7
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("_DotSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060025AD RID: 9645 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x060025AE RID: 9646 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJHFOBHJEHL()
	{
	}

	// Token: 0x060025AF RID: 9647 RVA: 0x000D564B File Offset: 0x000D384B
	private void ABEIEGDHBNO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060025B0 RID: 9648 RVA: 0x000D62FB File Offset: 0x000D44FB
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("s");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060025B1 RID: 9649 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x060025B2 RID: 9650 RVA: 0x000D564B File Offset: 0x000D384B
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060025B3 RID: 9651 RVA: 0x000D631F File Offset: 0x000D451F
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060025B4 RID: 9652 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x060025B5 RID: 9653 RVA: 0x000D6356 File Offset: 0x000D4556
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("settings.gamemessagesduration");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060025B6 RID: 9654 RVA: 0x000D637A File Offset: 0x000D457A
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060025B7 RID: 9655 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x060025B8 RID: 9656 RVA: 0x000D564B File Offset: 0x000D384B
	private void BDBJEDIOKBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060025B9 RID: 9657 RVA: 0x000D63B4 File Offset: 0x000D45B4
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.AELJLBOJAIL().SetFloat("settings.volume.menu", this._Heigh);
			this.DBOLLHHMKKN().SetFloat("RecordButton", this._Intervale);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060025BA RID: 9658 RVA: 0x000D564B File Offset: 0x000D384B
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060025BB RID: 9659 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOLDLDLFFLM()
	{
	}

	// Token: 0x060025BC RID: 9660 RVA: 0x000D6418 File Offset: 0x000D4618
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.DOHGBNPMBKG().SetFloat("_SizeX", this._Heigh);
			this.BAGICADFBAB().SetFloat("[FileSelector] Dialog ended, result: ", this._Intervale);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060025BD RID: 9661 RVA: 0x000D564B File Offset: 0x000D384B
	private void IABLKKAALGI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060025BE RID: 9662 RVA: 0x000D647B File Offset: 0x000D467B
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060025BF RID: 9663 RVA: 0x000D64B2 File Offset: 0x000D46B2
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060025C0 RID: 9664 RVA: 0x000D64EC File Offset: 0x000D46EC
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.NFKFAAHHLLM().SetFloat("_Value2", this._Heigh);
			this.KAFBNOBOIAJ().SetFloat("Icon", this._Intervale);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060025C1 RID: 9665 RVA: 0x000D654F File Offset: 0x000D474F
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x040004C1 RID: 1217
	public Shader SCShader;

	// Token: 0x040004C2 RID: 1218
	[Range(0f, 0.5f)]
	public float _Heigh = 0.0125f;

	// Token: 0x040004C3 RID: 1219
	[Range(0f, 0.25f)]
	public float _Intervale = 0.0025f;

	// Token: 0x040004C4 RID: 1220
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040004C5 RID: 1221
	private Material BJFKDHHMLJH;
}
