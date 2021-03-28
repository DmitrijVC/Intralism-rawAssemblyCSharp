using System;
using UnityEngine;

// Token: 0x020000BB RID: 187
[AddComponentMenu("Camera Filter Pack/Film/Grain")]
[ExecuteInEditMode]
public class CameraFilterPack_Film_Grain : MonoBehaviour
{
	// Token: 0x060038D0 RID: 14544 RVA: 0x00120C7A File Offset: 0x0011EE7A
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060038D1 RID: 14545 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x060038D2 RID: 14546 RVA: 0x00120CB1 File Offset: 0x0011EEB1
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060038D3 RID: 14547 RVA: 0x00120CCE File Offset: 0x0011EECE
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060038D4 RID: 14548 RVA: 0x00120D05 File Offset: 0x0011EF05
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060038D5 RID: 14549 RVA: 0x00120D3C File Offset: 0x0011EF3C
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("CameraFilterPack/BlurTiltShift_Hole");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060038D6 RID: 14550 RVA: 0x00120D60 File Offset: 0x0011EF60
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060038D7 RID: 14551 RVA: 0x00120CB1 File Offset: 0x0011EEB1
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060038D8 RID: 14552 RVA: 0x00120CB1 File Offset: 0x0011EEB1
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060038D9 RID: 14553 RVA: 0x00120D97 File Offset: 0x0011EF97
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find(" Remote called.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060038DA RID: 14554 RVA: 0x00120DBB File Offset: 0x0011EFBB
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060038DB RID: 14555 RVA: 0x00120DE0 File Offset: 0x0011EFE0
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Value);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060038DC RID: 14556 RVA: 0x00120EA0 File Offset: 0x0011F0A0
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1765f)
			{
				this.HBJJOCHGOPH = 334f;
			}
			this.HNICHJCGJOC().SetFloat("default", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat("steamid", this.Value);
			this.HFBJAOFLCJI().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 265f, 911f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060038DD RID: 14557 RVA: 0x00120F60 File Offset: 0x0011F160
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1188f)
			{
				this.HBJJOCHGOPH = 1326f;
			}
			this.IGIAPKPKGPK().SetFloat("ERROR: Steam App ID isn't set! Make sure 'steam_appid.txt' is placed next to the executable file, and contains a single line with the app id.", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("#{0:X2}{1:X2}{2:X2}", this.Value);
			this.HKHBBBFLGJH().SetVector("inventory.itemscash", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 519f, 465f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NMDBCDFPGOK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060038DE RID: 14558 RVA: 0x0012101D File Offset: 0x0011F21D
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060038DF RID: 14559 RVA: 0x00121054 File Offset: 0x0011F254
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060038E0 RID: 14560 RVA: 0x00120CB1 File Offset: 0x0011EEB1
	private void CAKNMILHHNE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060038E1 RID: 14561 RVA: 0x00120CB1 File Offset: 0x0011EEB1
	private void DIGHKAJILJH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060038E2 RID: 14562 RVA: 0x00120CB1 File Offset: 0x0011EEB1
	private void OHIJGCLBMJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060038E3 RID: 14563 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x060038E4 RID: 14564 RVA: 0x0012108B File Offset: 0x0011F28B
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)72;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060038E5 RID: 14565 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x060038E6 RID: 14566 RVA: 0x001210C2 File Offset: 0x0011F2C2
	private Material KLKILLCHJHO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060038E7 RID: 14567 RVA: 0x001210F9 File Offset: 0x0011F2F9
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060038E8 RID: 14568 RVA: 0x00121130 File Offset: 0x0011F330
	private Material ILKALHDJBFE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060038E9 RID: 14569 RVA: 0x00121167 File Offset: 0x0011F367
	private void BKIGIIINEDH()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060038EA RID: 14570 RVA: 0x0012118C File Offset: 0x0011F38C
	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 4f)
			{
				this.HBJJOCHGOPH = 1046f;
			}
			this.HNICHJCGJOC().SetFloat("Mask texture not readable, set your sprite to Texture Type 'Advanced' and check 'Read/Write Enabled'", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetFloat("_TimeX", this.Value);
			this.DBOLLHHMKKN().SetVector("mapselector.lastSearch", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1464f, 1407f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060038EB RID: 14571 RVA: 0x0012124C File Offset: 0x0011F44C
	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1212f)
			{
				this.HBJJOCHGOPH = 41f;
			}
			this.ABHDNGIHBKE().SetFloat("Illegal view ID:", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("true", this.Value);
			this.PDEAHJPOMEF().SetVector("title", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1877f, 1293f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060038EC RID: 14572 RVA: 0x00121309 File Offset: 0x0011F509
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find("GhostPosX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060038ED RID: 14573 RVA: 0x0012132D File Offset: 0x0011F52D
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("_Blend");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060038EE RID: 14574 RVA: 0x00121354 File Offset: 0x0011F554
	private void AOGCKKLFGPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1499f)
			{
				this.HBJJOCHGOPH = 946f;
			}
			this.IGIAPKPKGPK().SetFloat("_FgOverlap", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat(".lastCheckpoint.penaltyScore", this.Value);
			this.HNICHJCGJOC().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 520f, 675f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060038EF RID: 14575 RVA: 0x00120CB1 File Offset: 0x0011EEB1
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060038F0 RID: 14576 RVA: 0x00121414 File Offset: 0x0011F614
	private void POENGNEMHJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1663f)
			{
				this.HBJJOCHGOPH = 726f;
			}
			this.KLKILLCHJHO().SetFloat("stats on", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("_TimeX", this.Value);
			this.LPMLLJKMAMP().SetVector(">", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1386f, 598f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060038F1 RID: 14577 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x060038F2 RID: 14578 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBPCODPOJAH()
	{
	}

	// Token: 0x060038F3 RID: 14579 RVA: 0x00121167 File Offset: 0x0011F367
	private void IGPCNCJIEOJ()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060038F4 RID: 14580 RVA: 0x001214D1 File Offset: 0x0011F6D1
	private void LFAFJKJAEEL()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_LighterColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060038F5 RID: 14581 RVA: 0x00120CB1 File Offset: 0x0011EEB1
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060038F6 RID: 14582 RVA: 0x001214F8 File Offset: 0x0011F6F8
	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1335f)
			{
				this.HBJJOCHGOPH = 312f;
			}
			this.LPPEPKGFOEM().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat("[PlayerController] ", this.Value);
			this.HCGJCMDJPGD().SetVector("Sprite", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 96f, 111f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060038F7 RID: 14583 RVA: 0x00120CB1 File Offset: 0x0011EEB1
	private void HCDBNAKGDJC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060038F8 RID: 14584 RVA: 0x001215B5 File Offset: 0x0011F7B5
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060038F9 RID: 14585 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x060038FA RID: 14586 RVA: 0x00120CB1 File Offset: 0x0011EEB1
	private void OEIBFOHPOPD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060038FB RID: 14587 RVA: 0x001215EC File Offset: 0x0011F7EC
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 986f)
			{
				this.HBJJOCHGOPH = 1126f;
			}
			this.LPMLLJKMAMP().SetFloat("Bad parameters for getstring! Use <key> <value>", this.HBJJOCHGOPH);
			this.ILKALHDJBFE().SetFloat(" Mb", this.Value);
			this.NBMPPNFKFLB().SetVector("_Saturation", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 111f, 377f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060038FC RID: 14588 RVA: 0x001216A9 File Offset: 0x0011F8A9
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find(" cannot be used as a 3D LUT.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060038FD RID: 14589 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x060038FE RID: 14590 RVA: 0x001216CD File Offset: 0x0011F8CD
	private void MKOMIDCPCDC()
	{
		this.SCShader = Shader.Find("settings.enablehitsoundsinnormal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060038FF RID: 14591 RVA: 0x001216F1 File Offset: 0x0011F8F1
	private void ECBILENEOOL()
	{
		this.SCShader = Shader.Find("threshold");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003900 RID: 14592 RVA: 0x00120CB1 File Offset: 0x0011EEB1
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003901 RID: 14593 RVA: 0x00121718 File Offset: 0x0011F918
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 899f)
			{
				this.HBJJOCHGOPH = 1357f;
			}
			this.KLKILLCHJHO().SetFloat("CameraFilterPack/Distortion_Lens", this.HBJJOCHGOPH);
			this.HHIAIGCAHDA().SetFloat("ItemNameBGImage", this.Value);
			this.LPMLLJKMAMP().SetVector("float,0", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1503f, 1914f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003902 RID: 14594 RVA: 0x001217D5 File Offset: 0x0011F9D5
	private void CEAGPJBGBMH()
	{
		this.SCShader = Shader.Find("caret");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003903 RID: 14595 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMNOHLNANIP()
	{
	}

	// Token: 0x06003904 RID: 14596 RVA: 0x001217F9 File Offset: 0x0011F9F9
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003905 RID: 14597 RVA: 0x00121830 File Offset: 0x0011FA30
	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 509f)
			{
				this.HBJJOCHGOPH = 401f;
			}
			this.FGENHBKMPDA().SetFloat("_MidGrey", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("_ScreenResolution", this.Value);
			this.HKHBBBFLGJH().SetVector("ResetSpeed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 463f, 990f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003906 RID: 14598 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x06003907 RID: 14599 RVA: 0x0002523B File Offset: 0x0002343B
	private void COMNAPAAPDO()
	{
	}

	// Token: 0x06003908 RID: 14600 RVA: 0x001218ED File Offset: 0x0011FAED
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003909 RID: 14601 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x0600390A RID: 14602 RVA: 0x00120CB1 File Offset: 0x0011EEB1
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600390B RID: 14603 RVA: 0x00120CB1 File Offset: 0x0011EEB1
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600390C RID: 14604 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKMELABKBHO()
	{
	}

	// Token: 0x0600390D RID: 14605 RVA: 0x00121924 File Offset: 0x0011FB24
	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1023f)
			{
				this.HBJJOCHGOPH = 1461f;
			}
			this.LDNADDJMIPK().SetFloat("maps.", this.HBJJOCHGOPH);
			this.DIOAAHJDMLK().SetFloat("Data/Skins/", this.Value);
			this.IGIAPKPKGPK().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1918f, 11f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600390E RID: 14606 RVA: 0x001219E4 File Offset: 0x0011FBE4
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 390f)
			{
				this.HBJJOCHGOPH = 1636f;
			}
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Colors_BleachBypass", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("settings.hitvariation", this.Value);
			this.FGENHBKMPDA().SetVector("[PlayerBase] Loading checkpoint data", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 595f, 90f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600390F RID: 14607 RVA: 0x00121AA1 File Offset: 0x0011FCA1
	private Material LPPEPKGFOEM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x170000A1 RID: 161
	// (get) Token: 0x06003910 RID: 14608 RVA: 0x00121AD8 File Offset: 0x0011FCD8
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

	// Token: 0x06003911 RID: 14609 RVA: 0x00121B0F File Offset: 0x0011FD0F
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003912 RID: 14610 RVA: 0x00121B46 File Offset: 0x0011FD46
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("MessageText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003913 RID: 14611 RVA: 0x00120CB1 File Offset: 0x0011EEB1
	private void AOKOLPEGHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003914 RID: 14612 RVA: 0x00121B6C File Offset: 0x0011FD6C
	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 492f)
			{
				this.HBJJOCHGOPH = 189f;
			}
			this.KJMECMIGJJA().SetFloat("_PositionX", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("https://steamcommunity.com/app/513510/workshop/", this.Value);
			this.HHIAIGCAHDA().SetVector("_SizeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 4f, 912f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003915 RID: 14613 RVA: 0x00121C29 File Offset: 0x0011FE29
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003916 RID: 14614 RVA: 0x00121C60 File Offset: 0x0011FE60
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-122);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003917 RID: 14615 RVA: 0x00121C97 File Offset: 0x0011FE97
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)82;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003918 RID: 14616 RVA: 0x00120CCE File Offset: 0x0011EECE
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003919 RID: 14617 RVA: 0x00121CD0 File Offset: 0x0011FED0
	private void LNOOFNGHNEL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1022f)
			{
				this.HBJJOCHGOPH = 710f;
			}
			this.IGKFMCPDNOI().SetFloat("plainText", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("MessageText", this.Value);
			this.LNLKMDPHDCC().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1060f, 234f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ILKALHDJBFE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600391A RID: 14618 RVA: 0x00121D8D File Offset: 0x0011FF8D
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600391B RID: 14619 RVA: 0x00121DC4 File Offset: 0x0011FFC4
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1129f)
			{
				this.HBJJOCHGOPH = 267f;
			}
			this.NBMPPNFKFLB().SetFloat("CameraFilterPack/Lut_PlayWith", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat(": ", this.Value);
			this.DKKBFFHBHJE().SetVector("[Left]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1926f, 1254f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NMDBCDFPGOK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600391C RID: 14620 RVA: 0x00121E81 File Offset: 0x00120081
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600391D RID: 14621 RVA: 0x00120CB1 File Offset: 0x0011EEB1
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600391E RID: 14622 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x0600391F RID: 14623 RVA: 0x00121EA5 File Offset: 0x001200A5
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003920 RID: 14624 RVA: 0x00121EDC File Offset: 0x001200DC
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003921 RID: 14625 RVA: 0x00121F13 File Offset: 0x00120113
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Gradients_Rainbow");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003922 RID: 14626 RVA: 0x00121F38 File Offset: 0x00120138
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 726f)
			{
				this.HBJJOCHGOPH = 1699f;
			}
			this.IGIAPKPKGPK().SetFloat("SetParticlesInput", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat(":", this.Value);
			this.LNLKMDPHDCC().SetVector("\" marked with the [PunRPC](C#) or @PunRPC(JS) property! Args: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 602f, 1257f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003923 RID: 14627 RVA: 0x00121FF5 File Offset: 0x001201F5
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003924 RID: 14628 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06003925 RID: 14629 RVA: 0x0012202C File Offset: 0x0012022C
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003926 RID: 14630 RVA: 0x00122050 File Offset: 0x00120250
	private void ODMPMJPALID()
	{
		this.SCShader = Shader.Find("Error; Only the MasterClient can call RemoveRPCs for other players.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003927 RID: 14631 RVA: 0x00122074 File Offset: 0x00120274
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003928 RID: 14632 RVA: 0x001220AB File Offset: 0x001202AB
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003929 RID: 14633 RVA: 0x00120CB1 File Offset: 0x0011EEB1
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600392A RID: 14634 RVA: 0x0002523B File Offset: 0x0002343B
	private void PNLKFANNOKO()
	{
	}

	// Token: 0x0600392B RID: 14635 RVA: 0x001220D0 File Offset: 0x001202D0
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1827f)
			{
				this.HBJJOCHGOPH = 1234f;
			}
			this.KBOPGONOCNP().SetFloat("workshop.", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat("checkpoint", this.Value);
			this.DKKBFFHBHJE().SetVector("The observed monobehaviour (", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 711f, 463f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600392C RID: 14636 RVA: 0x00122190 File Offset: 0x00120390
	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1394f)
			{
				this.HBJJOCHGOPH = 838f;
			}
			this.LPPEPKGFOEM().SetFloat("th", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("Failed to InstantiateSceneObject prefab: ", this.Value);
			this.NLFJGMBCICG().SetVector("UseFinalGlassColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 95f, 194f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600392D RID: 14637 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDBBPKIFNJ()
	{
	}

	// Token: 0x0600392E RID: 14638 RVA: 0x0012224D File Offset: 0x0012044D
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("ACCEPT");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600392F RID: 14639 RVA: 0x00122271 File Offset: 0x00120471
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003930 RID: 14640 RVA: 0x00122295 File Offset: 0x00120495
	private void CEDFFAOOPOG()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003931 RID: 14641 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06003932 RID: 14642 RVA: 0x001222BC File Offset: 0x001204BC
	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 152f)
			{
				this.HBJJOCHGOPH = 155f;
			}
			this.ILKALHDJBFE().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("SaveGameName is null or empty!", this.Value);
			this.FGENHBKMPDA().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1517f, 1118f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003933 RID: 14643 RVA: 0x00120CB1 File Offset: 0x0011EEB1
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003934 RID: 14644 RVA: 0x00122379 File Offset: 0x00120579
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Film_Grain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003935 RID: 14645 RVA: 0x001223A0 File Offset: 0x001205A0
	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1088f)
			{
				this.HBJJOCHGOPH = 381f;
			}
			this.NMDBCDFPGOK().SetFloat("NO", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat("settings.shaders.bloomintencity", this.Value);
			this.LDNADDJMIPK().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 341f, 1083f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003936 RID: 14646 RVA: 0x00122460 File Offset: 0x00120660
	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1999f)
			{
				this.HBJJOCHGOPH = 821f;
			}
			this.PDEAHJPOMEF().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetFloat("_Jitter", this.Value);
			this.LMLENGFLEBD().SetVector("#random #rare #item", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 168f, 1282f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ILKALHDJBFE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003937 RID: 14647 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x06003938 RID: 14648 RVA: 0x0012251D File Offset: 0x0012071D
	private void AEMGPJDJGBJ()
	{
		this.SCShader = Shader.Find("OK");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003939 RID: 14649 RVA: 0x00122541 File Offset: 0x00120741
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600393A RID: 14650 RVA: 0x0002523B File Offset: 0x0002343B
	private void ABFNJCEBIKA()
	{
	}

	// Token: 0x0600393B RID: 14651 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x0600393C RID: 14652 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x0600393D RID: 14653 RVA: 0x00122565 File Offset: 0x00120765
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("SetBGColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600393F RID: 14655 RVA: 0x001225A7 File Offset: 0x001207A7
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003940 RID: 14656 RVA: 0x001225E0 File Offset: 0x001207E0
	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 85f)
			{
				this.HBJJOCHGOPH = 1051f;
			}
			this.LPPEPKGFOEM().SetFloat(" : ", this.HBJJOCHGOPH);
			this.LPPEPKGFOEM().SetFloat("_Value3", this.Value);
			this.LDNADDJMIPK().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 156f, 846f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003941 RID: 14657 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003942 RID: 14658 RVA: 0x001226A0 File Offset: 0x001208A0
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 372f)
			{
				this.HBJJOCHGOPH = 327f;
			}
			this.ABHDNGIHBKE().SetFloat("_CenterRadius", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Threshhold", this.Value);
			this.NMDBCDFPGOK().SetVector(",", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 480f, 82f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ILKALHDJBFE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003943 RID: 14659 RVA: 0x0002523B File Offset: 0x0002343B
	private void GFACKFCEIBC()
	{
	}

	// Token: 0x06003944 RID: 14660 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06003945 RID: 14661 RVA: 0x0002523B File Offset: 0x0002343B
	private void EIDKCANPHJE()
	{
	}

	// Token: 0x06003946 RID: 14662 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06003947 RID: 14663 RVA: 0x00122760 File Offset: 0x00120960
	private void HNMIAKKBMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1765f)
			{
				this.HBJJOCHGOPH = 1769f;
			}
			this.HHIAIGCAHDA().SetFloat("MenuScene", this.HBJJOCHGOPH);
			this.LPPEPKGFOEM().SetFloat("_Val2", this.Value);
			this.LDNADDJMIPK().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 127f, 35f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003948 RID: 14664 RVA: 0x00122820 File Offset: 0x00120A20
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 776f)
			{
				this.HBJJOCHGOPH = 1386f;
			}
			this.NBMPPNFKFLB().SetFloat("\" for viewID ", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat("/", this.Value);
			this.LPMLLJKMAMP().SetVector("_Radius", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 157f, 448f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003949 RID: 14665 RVA: 0x001228E0 File Offset: 0x00120AE0
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 445f)
			{
				this.HBJJOCHGOPH = 672f;
			}
			this.HCGJCMDJPGD().SetFloat("Tab2Content", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("FPSToggle", this.Value);
			this.IGIAPKPKGPK().SetVector(": ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 174f, 601f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600394A RID: 14666 RVA: 0x001229A0 File Offset: 0x00120BA0
	private void IHAMJLJFFLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 832f)
			{
				this.HBJJOCHGOPH = 1243f;
			}
			this.LPMLLJKMAMP().SetFloat("SpawnObj", this.HBJJOCHGOPH);
			this.LMLENGFLEBD().SetFloat("maps.", this.Value);
			this.KLKILLCHJHO().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 122f, 89f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600394B RID: 14667 RVA: 0x00122A5D File Offset: 0x00120C5D
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600394C RID: 14668 RVA: 0x00122A94 File Offset: 0x00120C94
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 691f)
			{
				this.HBJJOCHGOPH = 987f;
			}
			this.HKHBBBFLGJH().SetFloat("[", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("float,1", this.Value);
			this.IGIAPKPKGPK().SetVector("targetColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 66f, 1187f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KLKILLCHJHO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600394D RID: 14669 RVA: 0x00122B51 File Offset: 0x00120D51
	private Material DIOAAHJDMLK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600394E RID: 14670 RVA: 0x00120CCE File Offset: 0x0011EECE
	private Material NMDBCDFPGOK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600394F RID: 14671 RVA: 0x00122B88 File Offset: 0x00120D88
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("settings.enablehitsoundsinrelax");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003950 RID: 14672 RVA: 0x00120CB1 File Offset: 0x0011EEB1
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003951 RID: 14673 RVA: 0x00120CB1 File Offset: 0x0011EEB1
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003952 RID: 14674 RVA: 0x00122BAC File Offset: 0x00120DAC
	private Material IFMAPIDFNLI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003953 RID: 14675 RVA: 0x00122BE3 File Offset: 0x00120DE3
	private void NKFDNIAKGEO()
	{
		this.SCShader = Shader.Find("input");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003954 RID: 14676 RVA: 0x0002523B File Offset: 0x0002343B
	private void JCGMGLMADEN()
	{
	}

	// Token: 0x06003955 RID: 14677 RVA: 0x00122C07 File Offset: 0x00120E07
	private void HIPEHGNBJMN()
	{
		this.SCShader = Shader.Find("_Glitch");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003956 RID: 14678 RVA: 0x00122C2C File Offset: 0x00120E2C
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 247f)
			{
				this.HBJJOCHGOPH = 642f;
			}
			this.HCGJCMDJPGD().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("menu.selectedlevelid", this.Value);
			this.NBMPPNFKFLB().SetVector("R:", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1031f, 943f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003957 RID: 14679 RVA: 0x00120CB1 File Offset: 0x0011EEB1
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003958 RID: 14680 RVA: 0x0002523B File Offset: 0x0002343B
	private void EDDPLJGKLKJ()
	{
	}

	// Token: 0x06003959 RID: 14681 RVA: 0x00120CB1 File Offset: 0x0011EEB1
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600395A RID: 14682 RVA: 0x00122CE9 File Offset: 0x00120EE9
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600395B RID: 14683 RVA: 0x00122D20 File Offset: 0x00120F20
	private void EDPDMBFLHLP()
	{
		this.SCShader = Shader.Find(",");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600395C RID: 14684 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x0600395D RID: 14685 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBDEJFCNOBF()
	{
	}

	// Token: 0x0600395E RID: 14686 RVA: 0x00122D44 File Offset: 0x00120F44
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find(".lastCheckpoint.currentCombo");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0400063B RID: 1595
	public Shader SCShader;

	// Token: 0x0400063C RID: 1596
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400063D RID: 1597
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400063E RID: 1598
	private Material BJFKDHHMLJH;

	// Token: 0x0400063F RID: 1599
	[Range(-64f, 64f)]
	public float Value = 32f;
}
