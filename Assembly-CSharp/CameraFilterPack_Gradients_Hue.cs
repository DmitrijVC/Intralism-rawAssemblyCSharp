using System;
using UnityEngine;

// Token: 0x020000E5 RID: 229
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Gradients/Hue")]
public class CameraFilterPack_Gradients_Hue : MonoBehaviour
{
	// Token: 0x0600462F RID: 17967 RVA: 0x0015A1A2 File Offset: 0x001583A2
	private void NKFDNIAKGEO()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004630 RID: 17968 RVA: 0x0015A1C7 File Offset: 0x001583C7
	private Material MNLKBFFKHIE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004631 RID: 17969 RVA: 0x0015A1A2 File Offset: 0x001583A2
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004632 RID: 17970 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x06004633 RID: 17971 RVA: 0x0015A200 File Offset: 0x00158400
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1592f)
			{
				this.HBJJOCHGOPH = 1685f;
			}
			this.ELBMIEOIABA().SetFloat("[PlayerBase] Checkpoint error: ", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("[PlayerController] ", this.Switch);
			this.HKHBBBFLGJH().SetFloat("pointBuffer", this.Fade);
			this.OGMEGHKECAH().SetVector("CameraFilterPack/Blend2Camera_VividLight", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1910f, 773f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004634 RID: 17972 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004635 RID: 17973 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06004636 RID: 17974 RVA: 0x0015A2F0 File Offset: 0x001584F0
	private void JFJLGJEPEAA()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004637 RID: 17975 RVA: 0x0015A315 File Offset: 0x00158515
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004638 RID: 17976 RVA: 0x0015A34C File Offset: 0x0015854C
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004639 RID: 17977 RVA: 0x0015A384 File Offset: 0x00158584
	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 573f)
			{
				this.HBJJOCHGOPH = 808f;
			}
			this.LMLENGFLEBD().SetFloat("21x3", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("0.00", this.Switch);
			this.KEMJNOMIPHN().SetFloat("_MainTex2", this.Fade);
			this.HKGAONMOBMH().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1536f, 711f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600463A RID: 17978 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600463B RID: 17979 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600463C RID: 17980 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600463D RID: 17981 RVA: 0x0015A457 File Offset: 0x00158657
	private Material NMDBCDFPGOK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)86;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600463E RID: 17982 RVA: 0x0015A2F0 File Offset: 0x001584F0
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600463F RID: 17983 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void OEIBFOHPOPD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004640 RID: 17984 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void AAEEHINDPNC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004641 RID: 17985 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x170000CB RID: 203
	// (get) Token: 0x06004642 RID: 17986 RVA: 0x0015A48E File Offset: 0x0015868E
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

	// Token: 0x06004643 RID: 17987 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004644 RID: 17988 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004645 RID: 17989 RVA: 0x0015A1A2 File Offset: 0x001583A2
	private void AEDDNDHCLNN()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004646 RID: 17990 RVA: 0x0015A4C8 File Offset: 0x001586C8
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 787f)
			{
				this.HBJJOCHGOPH = 1473f;
			}
			this.LPCHMEKDCHI().SetFloat("_SceneFogParams", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("CameraFilterPack/Blend2Camera_HardLight", this.Switch);
			this.NMDBCDFPGOK().SetFloat("CameraFilterPack/Vision_Plasma", this.Fade);
			this.NBMPPNFKFLB().SetVector("#close", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 782f, 298f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004647 RID: 17991 RVA: 0x0015A59B File Offset: 0x0015879B
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004648 RID: 17992 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004649 RID: 17993 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600464A RID: 17994 RVA: 0x0015A5D2 File Offset: 0x001587D2
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600464B RID: 17995 RVA: 0x0002523B File Offset: 0x0002343B
	private void GFACKFCEIBC()
	{
	}

	// Token: 0x0600464C RID: 17996 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x0600464D RID: 17997 RVA: 0x0015A60C File Offset: 0x0015880C
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 462f)
			{
				this.HBJJOCHGOPH = 1397f;
			}
			this.NBPKMLMCHFN.SetFloat("settings.showHP", this.HBJJOCHGOPH);
			this.ELBMIEOIABA().SetFloat("Lightning", this.Switch);
			this.EJDPNJAEAKJ().SetFloat("SetupEncryption() called but ignored. Not XB1 compiled. EncryptionData: ", this.Fade);
			this.FOOCJIDNGBB().SetVector("_Contrast", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 345f, 612f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600464E RID: 17998 RVA: 0x0015A6DF File Offset: 0x001588DF
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600464F RID: 17999 RVA: 0x0015A1A2 File Offset: 0x001583A2
	private void OKLAJINHPAN()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004650 RID: 18000 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x06004651 RID: 18001 RVA: 0x0015A716 File Offset: 0x00158916
	private Material ELBMIEOIABA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004652 RID: 18002 RVA: 0x0015A74D File Offset: 0x0015894D
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004653 RID: 18003 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004654 RID: 18004 RVA: 0x0015A784 File Offset: 0x00158984
	private void IJMAPHMBFJI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 746f)
			{
				this.HBJJOCHGOPH = 705f;
			}
			this.LDNADDJMIPK().SetFloat("unsubscribemap", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("CameraFilterPack/Gradients_Therma", this.Switch);
			this.HKHBBBFLGJH().SetFloat("SubmitUserVote:", this.Fade);
			this.KEMAALEODNH().SetVector("VoteUpToggle", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1706f, 1310f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004655 RID: 18005 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004656 RID: 18006 RVA: 0x0015A858 File Offset: 0x00158A58
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 91f)
			{
				this.HBJJOCHGOPH = 124f;
			}
			this.NBPKMLMCHFN.SetFloat("G:", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat("IconImage", this.Switch);
			this.IIBLJCKLGFG().SetFloat(" SecondsBeforeRespawn: ", this.Fade);
			this.BAGICADFBAB().SetVector("{0}{1}:{2}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 425f, 921f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004657 RID: 18007 RVA: 0x0015A92C File Offset: 0x00158B2C
	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1627f)
			{
				this.HBJJOCHGOPH = 1336f;
			}
			this.CEKJODEAMGB().SetFloat("There are too many cells created by your subdivision options. Maximum allowed number of cells is ", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("\nCreated by Oxy949", this.Switch);
			this.OGMEGHKECAH().SetFloat("BadgeText", this.Fade);
			this.HKHBBBFLGJH().SetVector("</color>", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1333f, 1065f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004658 RID: 18008 RVA: 0x0015A1A2 File Offset: 0x001583A2
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004659 RID: 18009 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x0600465A RID: 18010 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600465B RID: 18011 RVA: 0x0015AA00 File Offset: 0x00158C00
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 363f)
			{
				this.HBJJOCHGOPH = 316f;
			}
			this.LMLENGFLEBD().SetFloat("mapselector.lastSearch", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("LoadingStatusText", this.Switch);
			this.OGMEGHKECAH().SetFloat("Testing, the group has toggled [", this.Fade);
			this.KBOPGONOCNP().SetVector("null", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1832f, 190f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600465C RID: 18012 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x0600465D RID: 18013 RVA: 0x0015AAD3 File Offset: 0x00158CD3
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600465E RID: 18014 RVA: 0x0015AB0C File Offset: 0x00158D0C
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 877f)
			{
				this.HBJJOCHGOPH = 700f;
			}
			this.KBOPGONOCNP().SetFloat("_MainTex", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("Object ID. Case-Sensitive", this.Switch);
			this.MNLKBFFKHIE().SetFloat("hidden", this.Fade);
			this.IIBLJCKLGFG().SetVector("Committing changes...", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 902f, 1269f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600465F RID: 18015 RVA: 0x0015ABDF File Offset: 0x00158DDF
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004660 RID: 18016 RVA: 0x0015A2F0 File Offset: 0x001584F0
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004661 RID: 18017 RVA: 0x0015A2F0 File Offset: 0x001584F0
	private void ECBILENEOOL()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004662 RID: 18018 RVA: 0x0015AC18 File Offset: 0x00158E18
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1267f)
			{
				this.HBJJOCHGOPH = 641f;
			}
			this.HKGAONMOBMH().SetFloat("_Value5", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("The process failed: ", this.Switch);
			this.NBMPPNFKFLB().SetFloat("duration", this.Fade);
			this.KGOLDDBHIFN().SetVector("Item creation successful! Published Item ID: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1294f, 470f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004663 RID: 18019 RVA: 0x0015ACEB File Offset: 0x00158EEB
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004664 RID: 18020 RVA: 0x0015AD22 File Offset: 0x00158F22
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)109;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004665 RID: 18021 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x06004666 RID: 18022 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x06004667 RID: 18023 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004668 RID: 18024 RVA: 0x0015A1A2 File Offset: 0x001583A2
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004669 RID: 18025 RVA: 0x0015AD59 File Offset: 0x00158F59
	private Material FOOCJIDNGBB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600466A RID: 18026 RVA: 0x0015AD90 File Offset: 0x00158F90
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600466B RID: 18027 RVA: 0x0015ADC7 File Offset: 0x00158FC7
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600466C RID: 18028 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600466D RID: 18029 RVA: 0x0015AE00 File Offset: 0x00159000
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 615f)
			{
				this.HBJJOCHGOPH = 1986f;
			}
			this.IIBLJCKLGFG().SetFloat("#md5submitionfailed: ", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("_ScreenResolution", this.Switch);
			this.ELBMIEOIABA().SetFloat("0.00", this.Fade);
			this.PLBEJJIHFPB().SetVector("_History4Weight", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1688f, 1592f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600466E RID: 18030 RVA: 0x0015AED4 File Offset: 0x001590D4
	private void GOANCMNGDLE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1461f)
			{
				this.HBJJOCHGOPH = 1836f;
			}
			this.CEKJODEAMGB().SetFloat("PerfectHitsScoreText", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("x", this.Switch);
			this.MMOODGIODPC().SetFloat(" GameServer:", this.Fade);
			this.NBPKMLMCHFN.SetVector("ResetButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1378f, 1648f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600466F RID: 18031 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004670 RID: 18032 RVA: 0x0015AFA8 File Offset: 0x001591A8
	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1513f)
			{
				this.HBJJOCHGOPH = 1182f;
			}
			this.PLBEJJIHFPB().SetFloat("_Far", this.HBJJOCHGOPH);
			this.ELBMIEOIABA().SetFloat("_Vibrance", this.Switch);
			this.NBPKMLMCHFN.SetFloat("Please specify either t or f.", this.Fade);
			this.LMLENGFLEBD().SetVector("LostLive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1470f, 1920f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004671 RID: 18033 RVA: 0x0015A2F0 File Offset: 0x001584F0
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004672 RID: 18034 RVA: 0x0015B07C File Offset: 0x0015927C
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1717f)
			{
				this.HBJJOCHGOPH = 1170f;
			}
			this.OGMEGHKECAH().SetFloat("PLEASE WAIT", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("CameraFilterPack/Blend2Camera_Difference", this.Switch);
			this.FOOCJIDNGBB().SetFloat("RaiseEvent() failed. Your event is not being sent! Check if your are in a Room and the eventCode must be less than 200 (0..199).", this.Fade);
			this.IIBLJCKLGFG().SetVector(". Client is not the MasterClient in this room.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1077f, 1765f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004673 RID: 18035 RVA: 0x0015B150 File Offset: 0x00159350
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Switch);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Fade);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004674 RID: 18036 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x06004675 RID: 18037 RVA: 0x0002523B File Offset: 0x0002343B
	private void JFMIDILENDO()
	{
	}

	// Token: 0x06004676 RID: 18038 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004677 RID: 18039 RVA: 0x0015B223 File Offset: 0x00159423
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004678 RID: 18040 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x06004679 RID: 18041 RVA: 0x0015B25A File Offset: 0x0015945A
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600467A RID: 18042 RVA: 0x0015A2F0 File Offset: 0x001584F0
	private void MMPHNFPPEHO()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600467B RID: 18043 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBFJAOINHMK()
	{
	}

	// Token: 0x0600467C RID: 18044 RVA: 0x0015B294 File Offset: 0x00159494
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 915f)
			{
				this.HBJJOCHGOPH = 1500f;
			}
			this.ELBMIEOIABA().SetFloat("achievements.21.completed.", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("_Value3", this.Switch);
			this.BAGICADFBAB().SetFloat("player.ice", this.Fade);
			this.LPCHMEKDCHI().SetVector("[LevelEditorScene] Map submitted!", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 455f, 440f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600467D RID: 18045 RVA: 0x0002523B File Offset: 0x0002343B
	private void BFGIMALGMAJ()
	{
	}

	// Token: 0x0600467E RID: 18046 RVA: 0x0015A1A2 File Offset: 0x001583A2
	private void CCFEDENFNEF()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600467F RID: 18047 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06004680 RID: 18048 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004681 RID: 18049 RVA: 0x0015B368 File Offset: 0x00159568
	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1437f)
			{
				this.HBJJOCHGOPH = 418f;
			}
			this.HNICHJCGJOC().SetFloat("maps.", this.HBJJOCHGOPH);
			this.CEKJODEAMGB().SetFloat("Set Trail Zoom (player camera move forward effect). Base value - 1.5", this.Switch);
			this.LPCHMEKDCHI().SetFloat("New SaveGame", this.Fade);
			this.MNLKBFFKHIE().SetVector("Set Crosshair Color", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1749f, 1573f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004682 RID: 18050 RVA: 0x0015B43B File Offset: 0x0015963B
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-86);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004683 RID: 18051 RVA: 0x0015B472 File Offset: 0x00159672
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004684 RID: 18052 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004685 RID: 18053 RVA: 0x0015B4AC File Offset: 0x001596AC
	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1415f)
			{
				this.HBJJOCHGOPH = 848f;
			}
			this.KGOLDDBHIFN().SetFloat("DPADVER", this.HBJJOCHGOPH);
			this.MNLKBFFKHIE().SetFloat("0.00", this.Switch);
			this.LDNADDJMIPK().SetFloat("settings.volume.sfx", this.Fade);
			this.MMOODGIODPC().SetVector(" (inactive)", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1773f, 141f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004686 RID: 18054 RVA: 0x0015B580 File Offset: 0x00159780
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1312f)
			{
				this.HBJJOCHGOPH = 1658f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("CameraFilterPack/TV_Videoflip", this.Switch);
			this.CEKJODEAMGB().SetFloat("_TimeX", this.Fade);
			this.NMDBCDFPGOK().SetVector("nogamesfound", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 160f, 948f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004687 RID: 18055 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004688 RID: 18056 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004689 RID: 18057 RVA: 0x0015A1A2 File Offset: 0x001583A2
	private void OGJJDKENBNC()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600468A RID: 18058 RVA: 0x0015A1A2 File Offset: 0x001583A2
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600468C RID: 18060 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void LAMEHAHJKMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600468D RID: 18061 RVA: 0x0015A2F0 File Offset: 0x001584F0
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600468E RID: 18062 RVA: 0x0015B688 File Offset: 0x00159888
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1843f)
			{
				this.HBJJOCHGOPH = 1111f;
			}
			this.KBOPGONOCNP().SetFloat("_Visualize", this.HBJJOCHGOPH);
			this.MNLKBFFKHIE().SetFloat("solo", this.Switch);
			this.HKGAONMOBMH().SetFloat("Texture2", this.Fade);
			this.HNICHJCGJOC().SetVector("ScoreText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1064f, 1475f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600468F RID: 18063 RVA: 0x0015A2F0 File Offset: 0x001584F0
	private void MKOMIDCPCDC()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004690 RID: 18064 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void MCKCCPLJIFE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004691 RID: 18065 RVA: 0x0015A1A2 File Offset: 0x001583A2
	private void LFAFJKJAEEL()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004692 RID: 18066 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004693 RID: 18067 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004694 RID: 18068 RVA: 0x0015A2F0 File Offset: 0x001584F0
	private void EIMNPCMHJLJ()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004695 RID: 18069 RVA: 0x0015A2F0 File Offset: 0x001584F0
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004696 RID: 18070 RVA: 0x0015B75C File Offset: 0x0015995C
	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 117f)
			{
				this.HBJJOCHGOPH = 615f;
			}
			this.KEMAALEODNH().SetFloat("[MapEditor] Item creation successful! Published Item ID: ", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetFloat("_SizeX", this.Switch);
			this.CEKJODEAMGB().SetFloat(".status", this.Fade);
			this.LMLENGFLEBD().SetVector("Error: I/O Failure", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 149f, 1028f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004697 RID: 18071 RVA: 0x0015B82F File Offset: 0x00159A2F
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004698 RID: 18072 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004699 RID: 18073 RVA: 0x0015A1A2 File Offset: 0x001583A2
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600469A RID: 18074 RVA: 0x0015A1A2 File Offset: 0x001583A2
	private void HJPCJGOEKMF()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600469B RID: 18075 RVA: 0x0015B868 File Offset: 0x00159A68
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1011f)
			{
				this.HBJJOCHGOPH = 1704f;
			}
			this.LPCHMEKDCHI().SetFloat("TotalHitsScoreText", this.HBJJOCHGOPH);
			this.MNLKBFFKHIE().SetFloat("LevelInfoInputField", this.Switch);
			this.MMOODGIODPC().SetFloat("other.dust0", this.Fade);
			this.FOOCJIDNGBB().SetVector("_Dist", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1901f, 343f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600469C RID: 18076 RVA: 0x0015A1A2 File Offset: 0x001583A2
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600469D RID: 18077 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600469E RID: 18078 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600469F RID: 18079 RVA: 0x0015A2F0 File Offset: 0x001584F0
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060046A0 RID: 18080 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060046A1 RID: 18081 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x060046A2 RID: 18082 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x060046A3 RID: 18083 RVA: 0x0015B93C File Offset: 0x00159B3C
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 380f)
			{
				this.HBJJOCHGOPH = 1442f;
			}
			this.NBPKMLMCHFN.SetFloat("0.00", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("_Near", this.Switch);
			this.PLBEJJIHFPB().SetFloat("mapselector.filter.rateduponly", this.Fade);
			this.NBPKMLMCHFN.SetVector("_Value7", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1038f, 1778f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060046A4 RID: 18084 RVA: 0x0015BA0F File Offset: 0x00159C0F
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060046A5 RID: 18085 RVA: 0x0015A2F0 File Offset: 0x001584F0
	private void NEFHGMNAPEP()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060046A6 RID: 18086 RVA: 0x0015BA48 File Offset: 0x00159C48
	private void AOGCKKLFGPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1580f)
			{
				this.HBJJOCHGOPH = 499f;
			}
			this.NFMGLIKNOOC().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("_TimeX", this.Switch);
			this.LPCHMEKDCHI().SetFloat("{0}={2}: {1} \"{3}\"", this.Fade);
			this.LPCHMEKDCHI().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1629f, 1418f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060046A7 RID: 18087 RVA: 0x0015BB1C File Offset: 0x00159D1C
	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 242f)
			{
				this.HBJJOCHGOPH = 536f;
			}
			this.LDNADDJMIPK().SetFloat("menu.selectedplaymode", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("Fill", this.Switch);
			this.KBOPGONOCNP().SetFloat("GridDataArcs", this.Fade);
			this.HKHBBBFLGJH().SetVector("rd", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1927f, 1254f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060046A8 RID: 18088 RVA: 0x0015A2F0 File Offset: 0x001584F0
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060046A9 RID: 18089 RVA: 0x0002523B File Offset: 0x0002343B
	private void LKJMIODJGCM()
	{
	}

	// Token: 0x060046AA RID: 18090 RVA: 0x0015BBEF File Offset: 0x00159DEF
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060046AB RID: 18091 RVA: 0x0015A1A2 File Offset: 0x001583A2
	private void Start()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060046AC RID: 18092 RVA: 0x0015A2F0 File Offset: 0x001584F0
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060046AD RID: 18093 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x060046AE RID: 18094 RVA: 0x0015BC28 File Offset: 0x00159E28
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 872f)
			{
				this.HBJJOCHGOPH = 27f;
			}
			this.KEMAALEODNH().SetFloat("file://", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("CheckpointsScoreText", this.Switch);
			this.KBOPGONOCNP().SetFloat("_Offsets", this.Fade);
			this.LMLENGFLEBD().SetVector("[PlayerController] ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 710f, 1930f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060046AF RID: 18095 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060046B0 RID: 18096 RVA: 0x0015A2F0 File Offset: 0x001584F0
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060046B1 RID: 18097 RVA: 0x0015BCFC File Offset: 0x00159EFC
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 220f)
			{
				this.HBJJOCHGOPH = 604f;
			}
			this.NBMPPNFKFLB().SetFloat("menu.playedpage", this.HBJJOCHGOPH);
			this.MNLKBFFKHIE().SetFloat("Can't find key ", this.Switch);
			this.LPCHMEKDCHI().SetFloat("CameraFilterPack/Blend2Camera_ColorDodge", this.Fade);
			this.HKHBBBFLGJH().SetVector("#{0}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 40f, 996f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060046B2 RID: 18098 RVA: 0x0015A2D3 File Offset: 0x001584D3
	private void ANDELGODEOC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0400077D RID: 1917
	public Shader SCShader;

	// Token: 0x0400077E RID: 1918
	private string ELOFMLPCCEA = "CameraFilterPack/Gradients_Hue";

	// Token: 0x0400077F RID: 1919
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000780 RID: 1920
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000781 RID: 1921
	private Material BJFKDHHMLJH;

	// Token: 0x04000782 RID: 1922
	[Range(0f, 1f)]
	public float Switch = 1f;

	// Token: 0x04000783 RID: 1923
	[Range(0f, 1f)]
	public float Fade = 1f;
}
