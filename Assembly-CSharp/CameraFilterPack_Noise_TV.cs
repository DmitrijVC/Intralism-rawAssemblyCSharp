using System;
using UnityEngine;

// Token: 0x020000F7 RID: 247
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Noise/TV")]
public class CameraFilterPack_Noise_TV : MonoBehaviour
{
	// Token: 0x06004C85 RID: 19589 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C86 RID: 19590 RVA: 0x0017D2CF File Offset: 0x0017B4CF
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-92);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C87 RID: 19591 RVA: 0x0017D308 File Offset: 0x0017B508
	private void AGDIBDLHMKF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 255f)
			{
				this.HBJJOCHGOPH = 1253f;
			}
			this.ILKALHDJBFE().SetFloat("SpawnObj", this.HBJJOCHGOPH);
			this.DABHAJNHOAL().SetFloat("on master", this.Fade);
			this.MFHPKGICPIO().SetFloat("_MidGrey", this.EOKMJCIDCDB);
			this.LELKBCALFCF().SetFloat("CameraFilterPack/3D_Shield", this.ILHJFHFPGBB);
			this.KJMECMIGJJA().SetFloat("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", this.CCIENBFIKKH);
			this.BAGICADFBAB().SetVector("_BlurVector", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1234f, 1138f));
			this.ILKALHDJBFE().SetTexture(".icon", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C88 RID: 19592 RVA: 0x0017D420 File Offset: 0x0017B620
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 210f)
			{
				this.HBJJOCHGOPH = 1811f;
			}
			this.ILKALHDJBFE().SetFloat("Reload Maps", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("#alreadyexist", this.Fade);
			this.BAGICADFBAB().SetFloat(": ", this.EOKMJCIDCDB);
			this.GCDFNHMJMIP().SetFloat("RecieveChatMessage", this.ILHJFHFPGBB);
			this.IONHGBPGCHK().SetFloat("DPADVER", this.CCIENBFIKKH);
			this.PDEAHJPOMEF().SetVector("Joystick1Button9", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1901f, 4f));
			this.DABHAJNHOAL().SetTexture(";", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C89 RID: 19593 RVA: 0x0017D535 File Offset: 0x0017B735
	private Material CECICEGFHKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C8A RID: 19594 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void IABLKKAALGI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C8B RID: 19595 RVA: 0x0017D56C File Offset: 0x0017B76C
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 739f)
			{
				this.HBJJOCHGOPH = 809f;
			}
			this.DOHGBNPMBKG().SetFloat("#exit", this.HBJJOCHGOPH);
			this.DABHAJNHOAL().SetFloat("player.goldbat", this.Fade);
			this.PDEAHJPOMEF().SetFloat("Value", this.EOKMJCIDCDB);
			this.MFHPKGICPIO().SetFloat("_Value", this.ILHJFHFPGBB);
			this.IKAIDLJKLFC().SetFloat("PossibleMapPointsText", this.CCIENBFIKKH);
			this.HJGEHJDMCGI().SetVector("Particles/Additive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1067f, 990f));
			this.DABHAJNHOAL().SetTexture("_Intensity", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IKBJACCLPCL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C8C RID: 19596 RVA: 0x0017D684 File Offset: 0x0017B884
	private void OPIBJIMIOKE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 628f)
			{
				this.HBJJOCHGOPH = 322f;
			}
			this.GKILCDHJFEG().SetFloat("gamemode", this.HBJJOCHGOPH);
			this.ILKALHDJBFE().SetFloat("CameraFilterPack/Distortion_BlackHole", this.Fade);
			this.GJHPODJOBHL().SetFloat("_TimeX", this.EOKMJCIDCDB);
			this.EFDEIFCDAFG().SetFloat("_Value3", this.ILHJFHFPGBB);
			this.KJMECMIGJJA().SetFloat("_Value3", this.CCIENBFIKKH);
			this.DOHGBNPMBKG().SetVector("LevelConfigButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 896f, 1073f));
			this.ADAFMBOGPLN().SetTexture("ConnectToBestCloudServer() failed. Can only connect while in state 'Disconnected'. Current state: ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C8D RID: 19597 RVA: 0x0017D799 File Offset: 0x0017B999
	private void NKFDNIAKGEO()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("[LobbyPlayerElement] Created lpe for ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004C8E RID: 19598 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJNJIHCLODK()
	{
	}

	// Token: 0x06004C8F RID: 19599 RVA: 0x0017D7D2 File Offset: 0x0017B9D2
	private void LFBGJIIECLD()
	{
		this.FPHEBLMINDA = (Resources.Load("{0}sec average:") as Texture2D);
		this.SCShader = Shader.Find("VeryHigh");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004C90 RID: 19600 RVA: 0x0017D80C File Offset: 0x0017BA0C
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 734f)
			{
				this.HBJJOCHGOPH = 62f;
			}
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Sharpen_Sharpen", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("CameraFilterPack/Glasses_On", this.Fade);
			this.IONHGBPGCHK().SetFloat("Alpha", this.EOKMJCIDCDB);
			this.BAGICADFBAB().SetFloat("MenuScene", this.ILHJFHFPGBB);
			this.CECICEGFHKL().SetFloat(" | ", this.CCIENBFIKKH);
			this.IONHGBPGCHK().SetVector("CameraFilterPack/Blend2Camera_LinearDodge", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1104f, 850f));
			this.JFDGLLEOPGB().SetTexture(" ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECICEGFHKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C91 RID: 19601 RVA: 0x0017D921 File Offset: 0x0017BB21
	private Material ILKALHDJBFE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C92 RID: 19602 RVA: 0x0017D958 File Offset: 0x0017BB58
	private Material IKBJACCLPCL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C93 RID: 19603 RVA: 0x0017D98F File Offset: 0x0017BB8F
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C94 RID: 19604 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void FGBDGGCBFLP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C95 RID: 19605 RVA: 0x0017D9C6 File Offset: 0x0017BBC6
	private void GNJDKAECPKA()
	{
		this.FPHEBLMINDA = (Resources.Load("SelectorMusicToggle") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/BlurHole");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004C96 RID: 19606 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C97 RID: 19607 RVA: 0x0017D9FF File Offset: 0x0017BBFF
	private Material DABHAJNHOAL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C98 RID: 19608 RVA: 0x0017DA36 File Offset: 0x0017BC36
	private void JKBMKPDGCHG()
	{
		this.FPHEBLMINDA = (Resources.Load("OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.") as Texture2D);
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004C99 RID: 19609 RVA: 0x0017DA6F File Offset: 0x0017BC6F
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004C9A RID: 19610 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C9B RID: 19611 RVA: 0x0017DAA6 File Offset: 0x0017BCA6
	private void FNCDAPDOBBI()
	{
		this.FPHEBLMINDA = (Resources.Load("[MapEditor] Loaded music file: ") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004C9C RID: 19612 RVA: 0x0017DAE0 File Offset: 0x0017BCE0
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Fade);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.EOKMJCIDCDB);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.ILHJFHFPGBB);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			this.NBPKMLMCHFN.SetTexture("Texture2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004C9D RID: 19613 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void JNALDALAJLG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004C9E RID: 19614 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x06004C9F RID: 19615 RVA: 0x0017DBF5 File Offset: 0x0017BDF5
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)127;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004CA0 RID: 19616 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004CA1 RID: 19617 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004CA2 RID: 19618 RVA: 0x0017DC2C File Offset: 0x0017BE2C
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004CA3 RID: 19619 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004CA4 RID: 19620 RVA: 0x0017DC63 File Offset: 0x0017BE63
	private void NEFHGMNAPEP()
	{
		this.FPHEBLMINDA = (Resources.Load("[NetworkManager] Updating rooms...") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_BlackHole");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004CA5 RID: 19621 RVA: 0x0017DC9C File Offset: 0x0017BE9C
	private void FDNONDCGGCG()
	{
		this.FPHEBLMINDA = (Resources.Load(" not exist") as Texture2D);
		this.SCShader = Shader.Find("Loading...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004CA6 RID: 19622 RVA: 0x0017DCD5 File Offset: 0x0017BED5
	private void GIGMHPHPCHJ()
	{
		this.FPHEBLMINDA = (Resources.Load("[NetworkManager] Joined room with ") as Texture2D);
		this.SCShader = Shader.Find("Alpha");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004CA7 RID: 19623 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06004CA8 RID: 19624 RVA: 0x0017D2CF File Offset: 0x0017B4CF
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-92);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004CA9 RID: 19625 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void HLHJBJGEEEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004CAA RID: 19626 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void BNLENEDAHHL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004CAB RID: 19627 RVA: 0x0017DD0E File Offset: 0x0017BF0E
	private void MNBPNHNAEBK()
	{
		this.FPHEBLMINDA = (Resources.Load("BitsData") as Texture2D);
		this.SCShader = Shader.Find("ArcsDestroyDelaySlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004CAC RID: 19628 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void PNNPDMHLFHE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004CAD RID: 19629 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004CAE RID: 19630 RVA: 0x0017DD47 File Offset: 0x0017BF47
	private void ICILLMAKLMI()
	{
		this.FPHEBLMINDA = (Resources.Load("_Size") as Texture2D);
		this.SCShader = Shader.Find(".");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004CAF RID: 19631 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06004CB0 RID: 19632 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004CB1 RID: 19633 RVA: 0x0017DD80 File Offset: 0x0017BF80
	private void EIMNPCMHJLJ()
	{
		this.FPHEBLMINDA = (Resources.Load(".") as Texture2D);
		this.SCShader = Shader.Find("back");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004CB2 RID: 19634 RVA: 0x0002523B File Offset: 0x0002343B
	private void COMNAPAAPDO()
	{
	}

	// Token: 0x06004CB3 RID: 19635 RVA: 0x0017DDB9 File Offset: 0x0017BFB9
	private void KNBJBNDGCIJ()
	{
		this.FPHEBLMINDA = (Resources.Load("Added event") as Texture2D);
		this.SCShader = Shader.Find(".lastCheckpoint.perfectHits");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004CB4 RID: 19636 RVA: 0x0017DDF4 File Offset: 0x0017BFF4
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1840f)
			{
				this.HBJJOCHGOPH = 128f;
			}
			this.EFDEIFCDAFG().SetFloat("Item invalid. No idea why.", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat("CameraFilterPack/Drawing_Laplacian", this.Fade);
			this.EHDJJANLINB().SetFloat("Tab2Content", this.EOKMJCIDCDB);
			this.MCDGIILBNIF().SetFloat("ScrollPanel", this.ILHJFHFPGBB);
			this.CECICEGFHKL().SetFloat("Object ID. Case-Sensitive", this.CCIENBFIKKH);
			this.CECICEGFHKL().SetVector("[LobbyPlayerElement] On ready click", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1758f, 571f));
			this.MFHPKGICPIO().SetTexture("OPEN", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECICEGFHKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004CB5 RID: 19637 RVA: 0x0002523B File Offset: 0x0002343B
	private void MBLDJEFBLFL()
	{
	}

	// Token: 0x06004CB6 RID: 19638 RVA: 0x0017DF0C File Offset: 0x0017C10C
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 694f)
			{
				this.HBJJOCHGOPH = 1120f;
			}
			this.HJGEHJDMCGI().SetFloat("_Value6", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("AddEnvironmentSprite", this.Fade);
			this.CECICEGFHKL().SetFloat("_NoiseTex", this.EOKMJCIDCDB);
			this.IKBJACCLPCL().SetFloat("settings.enableranking", this.ILHJFHFPGBB);
			this.BAGICADFBAB().SetFloat("CameraFilterPack/3D_Myst", this.CCIENBFIKKH);
			this.DABHAJNHOAL().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1211f, 1304f));
			this.DABHAJNHOAL().SetTexture("UseFinalGlassColor", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004CB7 RID: 19639 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void ABEIEGDHBNO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004CB8 RID: 19640 RVA: 0x0002523B File Offset: 0x0002343B
	private void EDDPLJGKLKJ()
	{
	}

	// Token: 0x06004CB9 RID: 19641 RVA: 0x0017E021 File Offset: 0x0017C221
	private void FLKEJJEGCFA()
	{
		this.FPHEBLMINDA = (Resources.Load("DPADVER") as Texture2D);
		this.SCShader = Shader.Find("UI Extensions/UIAdditive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004CBA RID: 19642 RVA: 0x0017E05C File Offset: 0x0017C25C
	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 921f)
			{
				this.HBJJOCHGOPH = 1605f;
			}
			this.BAGICADFBAB().SetFloat("_BlurPass", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetFloat("menutheme.deleted", this.Fade);
			this.PDEAHJPOMEF().SetFloat("[RanksSystem] Ranks: no need to update", this.EOKMJCIDCDB);
			this.GJHPODJOBHL().SetFloat(".completedCount", this.ILHJFHFPGBB);
			this.MCDGIILBNIF().SetFloat("_NoiseTex", this.CCIENBFIKKH);
			this.IONHGBPGCHK().SetVector("EditMenu", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 984f, 703f));
			this.NBPKMLMCHFN.SetTexture("RespawnAfter", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004CBB RID: 19643 RVA: 0x0002523B File Offset: 0x0002343B
	private void HEBOIFKBLGD()
	{
	}

	// Token: 0x06004CBC RID: 19644 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06004CBD RID: 19645 RVA: 0x0017E171 File Offset: 0x0017C371
	private void OKLAJINHPAN()
	{
		this.FPHEBLMINDA = (Resources.Load("[ItemsHandler] Inventory has changed") as Texture2D);
		this.SCShader = Shader.Find("RoomPlayersCountText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004CBE RID: 19646 RVA: 0x0017E1AA File Offset: 0x0017C3AA
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_TV_Noise") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Noise_TV");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004CBF RID: 19647 RVA: 0x0017E1E3 File Offset: 0x0017C3E3
	private Material EBJKJPAIAAM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004CC0 RID: 19648 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void OEIBFOHPOPD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004CC1 RID: 19649 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void MKFLBEGJJDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004CC2 RID: 19650 RVA: 0x0002523B File Offset: 0x0002343B
	private void CPCDFMMLHLO()
	{
	}

	// Token: 0x06004CC3 RID: 19651 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void IEFMONDKKJN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004CC4 RID: 19652 RVA: 0x0017E21A File Offset: 0x0017C41A
	private Material ADAFMBOGPLN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004CC5 RID: 19653 RVA: 0x0017E254 File Offset: 0x0017C454
	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1900f)
			{
				this.HBJJOCHGOPH = 956f;
			}
			this.DOHGBNPMBKG().SetFloat("BitsData", this.HBJJOCHGOPH);
			this.IKBJACCLPCL().SetFloat("_LensDirtIntensity", this.Fade);
			this.LELKBCALFCF().SetFloat(",viewkeys", this.EOKMJCIDCDB);
			this.HJGEHJDMCGI().SetFloat(" not exist", this.ILHJFHFPGBB);
			this.NBPKMLMCHFN.SetFloat(";", this.CCIENBFIKKH);
			this.GJHPODJOBHL().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1285f, 1971f));
			this.NBPKMLMCHFN.SetTexture("#yes", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004CC6 RID: 19654 RVA: 0x0017E369 File Offset: 0x0017C569
	private void FBPHNEJBDJN()
	{
		this.FPHEBLMINDA = (Resources.Load("settings.gamemessagesduration") as Texture2D);
		this.SCShader = Shader.Find("Joystick1Button1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004CC7 RID: 19655 RVA: 0x0017E3A2 File Offset: 0x0017C5A2
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004CC8 RID: 19656 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void BMGPBIBPBLA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004CC9 RID: 19657 RVA: 0x0017E3DC File Offset: 0x0017C5DC
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1788f)
			{
				this.HBJJOCHGOPH = 1088f;
			}
			this.IKAIDLJKLFC().SetFloat("Bad modpack name: {0}", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("\n", this.Fade);
			this.EBJKJPAIAAM().SetFloat(".message", this.EOKMJCIDCDB);
			this.GKILCDHJFEG().SetFloat("No Dispatcher exists in the scene. Actions will not be invoked!", this.ILHJFHFPGBB);
			this.MCDGIILBNIF().SetFloat("_Level", this.CCIENBFIKKH);
			this.PDEAHJPOMEF().SetVector("0,1,false", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 361f, 933f));
			this.IONHGBPGCHK().SetTexture("EventSystem", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ILKALHDJBFE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004CCA RID: 19658 RVA: 0x0017E4F4 File Offset: 0x0017C6F4
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1026f)
			{
				this.HBJJOCHGOPH = 339f;
			}
			this.CECICEGFHKL().SetFloat("Yes", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat("CameraFilterPack/Distortion_Lens", this.Fade);
			this.MFHPKGICPIO().SetFloat(" x ", this.EOKMJCIDCDB);
			this.PDEAHJPOMEF().SetFloat("CameraFilterPack/Drawing_Manga_FlashWhite", this.ILHJFHFPGBB);
			this.IONHGBPGCHK().SetFloat("_Color2", this.CCIENBFIKKH);
			this.IONHGBPGCHK().SetVector("rarity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1250f, 1678f));
			this.JFDGLLEOPGB().SetTexture("_History1LumaTex", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004CCB RID: 19659 RVA: 0x0017E609 File Offset: 0x0017C809
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004CCC RID: 19660 RVA: 0x0017E640 File Offset: 0x0017C840
	private void EKCJHNJGGAB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 126f)
			{
				this.HBJJOCHGOPH = 1702f;
			}
			this.DABHAJNHOAL().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.EBJKJPAIAAM().SetFloat("Submition failed", this.Fade);
			this.EHDJJANLINB().SetFloat("_AdaptTex", this.EOKMJCIDCDB);
			this.ADAFMBOGPLN().SetFloat("Other", this.ILHJFHFPGBB);
			this.KJMECMIGJJA().SetFloat("set id", this.CCIENBFIKKH);
			this.CECICEGFHKL().SetVector("DifficultyBG", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1409f, 422f));
			this.ADAFMBOGPLN().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ILKALHDJBFE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004CCD RID: 19661 RVA: 0x0017E758 File Offset: 0x0017C958
	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1266f)
			{
				this.HBJJOCHGOPH = 233f;
			}
			this.EFDEIFCDAFG().SetFloat("mainmenu", this.HBJJOCHGOPH);
			this.EBJKJPAIAAM().SetFloat("STICKRVER", this.Fade);
			this.NBPKMLMCHFN.SetFloat("No", this.EOKMJCIDCDB);
			this.GCDFNHMJMIP().SetFloat("resource", this.ILHJFHFPGBB);
			this.BAGICADFBAB().SetFloat("_MainTex2", this.CCIENBFIKKH);
			this.DOHGBNPMBKG().SetVector("JoinButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1214f, 220f));
			this.NBPKMLMCHFN.SetTexture("inventory.selected.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004CCE RID: 19662 RVA: 0x0017E86D File Offset: 0x0017CA6D
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004CCF RID: 19663 RVA: 0x0017E8A4 File Offset: 0x0017CAA4
	private void LFAFJKJAEEL()
	{
		this.FPHEBLMINDA = (Resources.Load("GUICamera") as Texture2D);
		this.SCShader = Shader.Find("w");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004CD0 RID: 19664 RVA: 0x0017E8DD File Offset: 0x0017CADD
	private void EFJDNLGNACH()
	{
		this.FPHEBLMINDA = (Resources.Load(".sawoutdatedmessage") as Texture2D);
		this.SCShader = Shader.Find("wss://");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004CD1 RID: 19665 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004CD2 RID: 19666 RVA: 0x0017E918 File Offset: 0x0017CB18
	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 428f)
			{
				this.HBJJOCHGOPH = 96f;
			}
			this.LELKBCALFCF().SetFloat("ConnectUsingSettings() disabled the offline mode. No longer offline.", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("menu.playedpage", this.Fade);
			this.DABHAJNHOAL().SetFloat("steamid", this.EOKMJCIDCDB);
			this.CECICEGFHKL().SetFloat("/", this.ILHJFHFPGBB);
			this.BAGICADFBAB().SetFloat("_Size", this.CCIENBFIKKH);
			this.PDEAHJPOMEF().SetVector("CameraFilterPack/Drawing_Curve", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 53f, 601f));
			this.EBJKJPAIAAM().SetTexture("ReconnectAndRejoin() disabled the offline mode. No longer offline.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004CD3 RID: 19667 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x06004CD4 RID: 19668 RVA: 0x0017EA30 File Offset: 0x0017CC30
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 578f)
			{
				this.HBJJOCHGOPH = 1488f;
			}
			this.GJHPODJOBHL().SetFloat("float,1", this.HBJJOCHGOPH);
			this.IKBJACCLPCL().SetFloat("Set Particles Gravity", this.Fade);
			this.HJGEHJDMCGI().SetFloat("#ok", this.EOKMJCIDCDB);
			this.DABHAJNHOAL().SetFloat("<command>", this.ILHJFHFPGBB);
			this.LELKBCALFCF().SetFloat("_Value3", this.CCIENBFIKKH);
			this.EHDJJANLINB().SetVector("_ChromaticAberration", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 65f, 476f));
			this.IKBJACCLPCL().SetTexture("Reconnect() failed. It seems the client wasn't connected before?! Current state: ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004CD5 RID: 19669 RVA: 0x0017EB45 File Offset: 0x0017CD45
	private void PCHCFIOHIKK()
	{
		this.FPHEBLMINDA = (Resources.Load("</color>") as Texture2D);
		this.SCShader = Shader.Find("SupportLogger OnDisconnectedFromPhoton().");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004CD6 RID: 19670 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004CD7 RID: 19671 RVA: 0x0017EB80 File Offset: 0x0017CD80
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1460f)
			{
				this.HBJJOCHGOPH = 483f;
			}
			this.HJGEHJDMCGI().SetFloat("#tryagain", this.HBJJOCHGOPH);
			this.CECICEGFHKL().SetFloat("_Blue_C", this.Fade);
			this.GKILCDHJFEG().SetFloat("PLEASE WAIT", this.EOKMJCIDCDB);
			this.ADAFMBOGPLN().SetFloat("open", this.ILHJFHFPGBB);
			this.ADAFMBOGPLN().SetFloat("_DistortionSize", this.CCIENBFIKKH);
			this.CECICEGFHKL().SetVector("downloading", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 412f, 715f));
			this.EBJKJPAIAAM().SetTexture("inventory.selected.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004CD8 RID: 19672 RVA: 0x0017EC98 File Offset: 0x0017CE98
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1403f)
			{
				this.HBJJOCHGOPH = 739f;
			}
			this.IKAIDLJKLFC().SetFloat("value", this.HBJJOCHGOPH);
			this.IKAIDLJKLFC().SetFloat("_TimeX", this.Fade);
			this.CECICEGFHKL().SetFloat("BitsData", this.EOKMJCIDCDB);
			this.ADAFMBOGPLN().SetFloat("/", this.ILHJFHFPGBB);
			this.CECICEGFHKL().SetFloat("GlassDistortion", this.CCIENBFIKKH);
			this.EFDEIFCDAFG().SetVector("_EmissionGain", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1382f, 1793f));
			this.KJMECMIGJJA().SetTexture("SetSatelliteRotationSpeed", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004CD9 RID: 19673 RVA: 0x0017EDB0 File Offset: 0x0017CFB0
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1291f)
			{
				this.HBJJOCHGOPH = 1128f;
			}
			this.EBJKJPAIAAM().SetFloat("SetCrosshairEmission", this.HBJJOCHGOPH);
			this.HJGEHJDMCGI().SetFloat(" not exist", this.Fade);
			this.GCDFNHMJMIP().SetFloat("_Factor", this.EOKMJCIDCDB);
			this.DABHAJNHOAL().SetFloat("_ScreenResolution", this.ILHJFHFPGBB);
			this.GCDFNHMJMIP().SetFloat("[EMPTY]", this.CCIENBFIKKH);
			this.KJMECMIGJJA().SetVector("Tab1Content", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1863f, 1507f));
			this.GKILCDHJFEG().SetTexture("_ScreenResolution", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004CDA RID: 19674 RVA: 0x0017EEC5 File Offset: 0x0017D0C5
	private void MMOKKAPFGAK()
	{
		this.FPHEBLMINDA = (Resources.Load("Sprite") as Texture2D);
		this.SCShader = Shader.Find("\nv.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004CDB RID: 19675 RVA: 0x0017EEFE File Offset: 0x0017D0FE
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004CDC RID: 19676 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void FMHOHGEAIEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004CDD RID: 19677 RVA: 0x0017EF35 File Offset: 0x0017D135
	private void GPNAOAKCMHC()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004CDE RID: 19678 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void GNPDGBNDCPL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x170000DC RID: 220
	// (get) Token: 0x06004CDF RID: 19679 RVA: 0x0017EF6E File Offset: 0x0017D16E
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

	// Token: 0x06004CE0 RID: 19680 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void OMFBGCMHNBM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004CE1 RID: 19681 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004CE2 RID: 19682 RVA: 0x0017D921 File Offset: 0x0017BB21
	private Material IKAIDLJKLFC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004CE3 RID: 19683 RVA: 0x0017EFA5 File Offset: 0x0017D1A5
	private void ODBNMPGBCGO()
	{
		this.FPHEBLMINDA = (Resources.Load("_MainTex2") as Texture2D);
		this.SCShader = Shader.Find("_Extra2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004CE4 RID: 19684 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x06004CE5 RID: 19685 RVA: 0x0002523B File Offset: 0x0002343B
	private void FAKGFMFAPDG()
	{
	}

	// Token: 0x06004CE6 RID: 19686 RVA: 0x0017EFE0 File Offset: 0x0017D1E0
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 769f)
			{
				this.HBJJOCHGOPH = 1843f;
			}
			this.GKILCDHJFEG().SetFloat("EnableRankingToggle", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("_Value4", this.Fade);
			this.LELKBCALFCF().SetFloat("_NoiseTex", this.EOKMJCIDCDB);
			this.GKILCDHJFEG().SetFloat("Triangle", this.ILHJFHFPGBB);
			this.LELKBCALFCF().SetFloat("inventory.itemscash", this.CCIENBFIKKH);
			this.ILKALHDJBFE().SetVector("_Blue_G", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 931f, 1624f));
			this.MCDGIILBNIF().SetTexture("Connecting", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004CE7 RID: 19687 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004CE8 RID: 19688 RVA: 0x0017F0F8 File Offset: 0x0017D2F8
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1922f)
			{
				this.HBJJOCHGOPH = 1489f;
			}
			this.GJHPODJOBHL().SetFloat("NetworkCanvas", this.HBJJOCHGOPH);
			this.EBJKJPAIAAM().SetFloat("isVisible", this.Fade);
			this.BAGICADFBAB().SetFloat("CameraFilterPack/Blend2Camera_Saturation", this.EOKMJCIDCDB);
			this.JFDGLLEOPGB().SetFloat("Editor/", this.ILHJFHFPGBB);
			this.BAGICADFBAB().SetFloat("Mine", this.CCIENBFIKKH);
			this.IKAIDLJKLFC().SetVector(".", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1389f, 473f));
			this.IKAIDLJKLFC().SetTexture("X", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004CE9 RID: 19689 RVA: 0x0017F20D File Offset: 0x0017D40D
	private Material HJGEHJDMCGI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004CEA RID: 19690 RVA: 0x0017F244 File Offset: 0x0017D444
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004CEB RID: 19691 RVA: 0x0017F27B File Offset: 0x0017D47B
	private void ALNNIDLFILB()
	{
		this.FPHEBLMINDA = (Resources.Load("BadgeText") as Texture2D);
		this.SCShader = Shader.Find("|");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004CEC RID: 19692 RVA: 0x0017F2B4 File Offset: 0x0017D4B4
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 911f)
			{
				this.HBJJOCHGOPH = 2f;
			}
			this.MCDGIILBNIF().SetFloat(". Name: ", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("Added event", this.Fade);
			this.DIOAAHJDMLK().SetFloat("distance", this.EOKMJCIDCDB);
			this.MFHPKGICPIO().SetFloat("/../", this.ILHJFHFPGBB);
			this.ADAFMBOGPLN().SetFloat("menu.selectedlevelid", this.CCIENBFIKKH);
			this.DOHGBNPMBKG().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1059f, 792f));
			this.HJGEHJDMCGI().SetTexture("Updating...", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004CED RID: 19693 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06004CEE RID: 19694 RVA: 0x0017F3C9 File Offset: 0x0017D5C9
	private void IHLMNAGPKDA()
	{
		this.FPHEBLMINDA = (Resources.Load("OpLeaveLobby()") as Texture2D);
		this.SCShader = Shader.Find("BitsData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004CEF RID: 19695 RVA: 0x0017F404 File Offset: 0x0017D604
	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1837f)
			{
				this.HBJJOCHGOPH = 638f;
			}
			this.DOHGBNPMBKG().SetFloat("_PColor2", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("_TimeX", this.Fade);
			this.IKAIDLJKLFC().SetFloat("_TimeX", this.EOKMJCIDCDB);
			this.DABHAJNHOAL().SetFloat("http", this.ILHJFHFPGBB);
			this.IONHGBPGCHK().SetFloat("id", this.CCIENBFIKKH);
			this.HJGEHJDMCGI().SetVector("SetParticlesInput", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 300f, 148f));
			this.GJHPODJOBHL().SetTexture("\" to target: ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004CF0 RID: 19696 RVA: 0x0017F519 File Offset: 0x0017D719
	private void BOPKKCAFODF()
	{
		this.FPHEBLMINDA = (Resources.Load("Items/") as Texture2D);
		this.SCShader = Shader.Find("ResetSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004CF1 RID: 19697 RVA: 0x0017F554 File Offset: 0x0017D754
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 164f)
			{
				this.HBJJOCHGOPH = 1649f;
			}
			this.MCDGIILBNIF().SetFloat("useSrcAlphaAsMask", this.HBJJOCHGOPH);
			this.LELKBCALFCF().SetFloat("Mid", this.Fade);
			this.ILKALHDJBFE().SetFloat("Protocol switch from: ", this.EOKMJCIDCDB);
			this.DIOAAHJDMLK().SetFloat("settings_bindings_", this.ILHJFHFPGBB);
			this.EBJKJPAIAAM().SetFloat("achievements.21.progress", this.CCIENBFIKKH);
			this.GCDFNHMJMIP().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 747f, 225f));
			this.CECICEGFHKL().SetTexture("_Green_R", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DABHAJNHOAL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004CF2 RID: 19698 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004CF3 RID: 19699 RVA: 0x0017F669 File Offset: 0x0017D869
	private void ANCKKLFPGDI()
	{
		this.FPHEBLMINDA = (Resources.Load("_ScreenResolution") as Texture2D);
		this.SCShader = Shader.Find("icon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004CF4 RID: 19700 RVA: 0x0017F6A2 File Offset: 0x0017D8A2
	private Material LELKBCALFCF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004CF5 RID: 19701 RVA: 0x0017F6DC File Offset: 0x0017D8DC
	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 948f)
			{
				this.HBJJOCHGOPH = 1032f;
			}
			this.DABHAJNHOAL().SetFloat("[GameEvent] Exeption:", this.HBJJOCHGOPH);
			this.LELKBCALFCF().SetFloat("#TBD", this.Fade);
			this.CECICEGFHKL().SetFloat(".status", this.EOKMJCIDCDB);
			this.ADAFMBOGPLN().SetFloat("ViewMenu", this.ILHJFHFPGBB);
			this.JFDGLLEOPGB().SetFloat("_HrDepthTex", this.CCIENBFIKKH);
			this.GCDFNHMJMIP().SetVector("ShadersToggle", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 481f, 1461f));
			this.KJMECMIGJJA().SetTexture("[Down]", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004CF6 RID: 19702 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004CF7 RID: 19703 RVA: 0x0017F7F1 File Offset: 0x0017D9F1
	private void JFJLGJEPEAA()
	{
		this.FPHEBLMINDA = (Resources.Load("player.currentrank") as Texture2D);
		this.SCShader = Shader.Find("<color=white>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004CF8 RID: 19704 RVA: 0x0017F82A File Offset: 0x0017DA2A
	private Material GJHPODJOBHL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004CF9 RID: 19705 RVA: 0x0017F864 File Offset: 0x0017DA64
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 785f)
			{
				this.HBJJOCHGOPH = 202f;
			}
			this.GCDFNHMJMIP().SetFloat("#news", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("No Name", this.Fade);
			this.GKILCDHJFEG().SetFloat("Object ID. Case-Sensitive", this.EOKMJCIDCDB);
			this.JFDGLLEOPGB().SetFloat("#ok", this.ILHJFHFPGBB);
			this.BAGICADFBAB().SetFloat("_Green_R", this.CCIENBFIKKH);
			this.DABHAJNHOAL().SetVector("D-Pad Right", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 941f, 523f));
			this.MCDGIILBNIF().SetTexture("Print the list of scenes, avalable in game.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004CFA RID: 19706 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004CFB RID: 19707 RVA: 0x0017F979 File Offset: 0x0017DB79
	private void AGEJKLMJGDO()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/Gradients_Therma") as Texture2D);
		this.SCShader = Shader.Find("SetSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004CFC RID: 19708 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06004CFD RID: 19709 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004CFE RID: 19710 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x06004CFF RID: 19711 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x06004D00 RID: 19712 RVA: 0x0002523B File Offset: 0x0002343B
	private void MANDOGNJJBD()
	{
	}

	// Token: 0x06004D01 RID: 19713 RVA: 0x0017F9B2 File Offset: 0x0017DBB2
	private void DKGBFNCOAEO()
	{
		this.FPHEBLMINDA = (Resources.Load("_TapMedium") as Texture2D);
		this.SCShader = Shader.Find("\n\n#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004D02 RID: 19714 RVA: 0x0017F9EB File Offset: 0x0017DBEB
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D03 RID: 19715 RVA: 0x0017FA24 File Offset: 0x0017DC24
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 268f)
			{
				this.HBJJOCHGOPH = 1653f;
			}
			this.IKAIDLJKLFC().SetFloat("_HighlightSuppression", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("'{0}' \t{1}ms \t{2}", this.Fade);
			this.EHDJJANLINB().SetFloat(".lastCheckpoint.checkpointsUsed", this.EOKMJCIDCDB);
			this.DABHAJNHOAL().SetFloat("Fade", this.ILHJFHFPGBB);
			this.JFDGLLEOPGB().SetFloat("Can't set visible when not in that room.", this.CCIENBFIKKH);
			this.EBJKJPAIAAM().SetVector("] Suggested ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 188f, 192f));
			this.JFDGLLEOPGB().SetTexture(" is set to dontSave = true, continuing loop.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HJGEHJDMCGI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D04 RID: 19716 RVA: 0x0017FB3C File Offset: 0x0017DD3C
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1657f)
			{
				this.HBJJOCHGOPH = 245f;
			}
			this.EBJKJPAIAAM().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.CECICEGFHKL().SetFloat("Items/", this.Fade);
			this.GCDFNHMJMIP().SetFloat("Right ", this.EOKMJCIDCDB);
			this.GJHPODJOBHL().SetFloat("Missing shader in ", this.ILHJFHFPGBB);
			this.GJHPODJOBHL().SetFloat("Joystick1Button7", this.CCIENBFIKKH);
			this.JFDGLLEOPGB().SetVector("ItemNameText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1558f, 416f));
			this.LELKBCALFCF().SetTexture("ChangeSelectedLevel", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D05 RID: 19717 RVA: 0x0017FC54 File Offset: 0x0017DE54
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 995f)
			{
				this.HBJJOCHGOPH = 424f;
			}
			this.ADAFMBOGPLN().SetFloat("BitsData", this.HBJJOCHGOPH);
			this.ADAFMBOGPLN().SetFloat("SelectorMusicToggle", this.Fade);
			this.HJGEHJDMCGI().SetFloat("_ScreenResolution", this.EOKMJCIDCDB);
			this.KJMECMIGJJA().SetFloat("CameraFilterPack/Drawing_Manga_Flash_Color", this.ILHJFHFPGBB);
			this.KJMECMIGJJA().SetFloat("music.ogg", this.CCIENBFIKKH);
			this.GJHPODJOBHL().SetVector("shader.frost", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 188f, 923f));
			this.HJGEHJDMCGI().SetTexture("z", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D06 RID: 19718 RVA: 0x0017FD6C File Offset: 0x0017DF6C
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1843f)
			{
				this.HBJJOCHGOPH = 545f;
			}
			this.EHDJJANLINB().SetFloat("Joystick1Button5", this.HBJJOCHGOPH);
			this.IKBJACCLPCL().SetFloat("Coroutine container not configured... did you forget to call Init?", this.Fade);
			this.DIOAAHJDMLK().SetFloat("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp-firstpass", this.EOKMJCIDCDB);
			this.EBJKJPAIAAM().SetFloat("_Noise", this.ILHJFHFPGBB);
			this.MFHPKGICPIO().SetFloat("#yes", this.CCIENBFIKKH);
			this.DIOAAHJDMLK().SetVector("STICKRHOR", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 452f, 1786f));
			this.ILKALHDJBFE().SetTexture("InfoText", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D07 RID: 19719 RVA: 0x0002523B File Offset: 0x0002343B
	private void INLDEHPAMJC()
	{
	}

	// Token: 0x06004D08 RID: 19720 RVA: 0x0017FE84 File Offset: 0x0017E084
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1503f)
			{
				this.HBJJOCHGOPH = 1222f;
			}
			this.IKAIDLJKLFC().SetFloat("RedoButton", this.HBJJOCHGOPH);
			this.DIOAAHJDMLK().SetFloat("_TimeX", this.Fade);
			this.GJHPODJOBHL().SetFloat("_SunColor", this.EOKMJCIDCDB);
			this.GCDFNHMJMIP().SetFloat("{0}\t is: {1}", this.ILHJFHFPGBB);
			this.JFDGLLEOPGB().SetFloat("_ScreenResolution", this.CCIENBFIKKH);
			this.CECICEGFHKL().SetVector("value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 462f, 1997f));
			this.NBPKMLMCHFN.SetTexture("[ItemsHandler] No connection to item server: ", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D09 RID: 19721 RVA: 0x0017FF99 File Offset: 0x0017E199
	private Material DIOAAHJDMLK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004D0A RID: 19722 RVA: 0x0017FFD0 File Offset: 0x0017E1D0
	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 541f)
			{
				this.HBJJOCHGOPH = 737f;
			}
			this.ILKALHDJBFE().SetFloat("settings.arcsnohitsoundtimedelay", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("HostType: {0} ", this.Fade);
			this.DOHGBNPMBKG().SetFloat("_TileTexDebug", this.EOKMJCIDCDB);
			this.HJGEHJDMCGI().SetFloat("SetCrosshairEmission", this.ILHJFHFPGBB);
			this.ILKALHDJBFE().SetFloat("Write me to get one for testing :)", this.CCIENBFIKKH);
			this.BAGICADFBAB().SetVector("menu.selectedplaymode", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1669f, 1392f));
			this.EBJKJPAIAAM().SetTexture("_Value2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D0B RID: 19723 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void FKDEEJFNNJC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D0C RID: 19724 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D0D RID: 19725 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void GEHINELAGBI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D0E RID: 19726 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D0F RID: 19727 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x06004D10 RID: 19728 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06004D12 RID: 19730 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06004D13 RID: 19731 RVA: 0x00180124 File Offset: 0x0017E324
	private void KCCIEMBMOBA()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack/Drawing_Lines") as Texture2D);
		this.SCShader = Shader.Find(" now: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004D14 RID: 19732 RVA: 0x0017D2B2 File Offset: 0x0017B4B2
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004D15 RID: 19733 RVA: 0x0018015D File Offset: 0x0017E35D
	private void BGDPIHMAACO()
	{
		this.FPHEBLMINDA = (Resources.Load("_Value") as Texture2D);
		this.SCShader = Shader.Find("In Network lobby");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004D16 RID: 19734 RVA: 0x00180198 File Offset: 0x0017E398
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1232f)
			{
				this.HBJJOCHGOPH = 25f;
			}
			this.PDEAHJPOMEF().SetFloat("_FarCamera", this.HBJJOCHGOPH);
			this.ADAFMBOGPLN().SetFloat(". Should be just one?", this.Fade);
			this.NBPKMLMCHFN.SetFloat("achievements.21.progress", this.EOKMJCIDCDB);
			this.HJGEHJDMCGI().SetFloat("_Params2", this.ILHJFHFPGBB);
			this.DABHAJNHOAL().SetFloat("_TimeX", this.CCIENBFIKKH);
			this.CECICEGFHKL().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1808f, 763f));
			this.DABHAJNHOAL().SetTexture("[Steamworks.NET] Packsize Test returned false, the wrong version of Steamworks.NET is being run in this platform.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004D17 RID: 19735 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06004D18 RID: 19736 RVA: 0x0002523B File Offset: 0x0002343B
	private void MOMHHBKAGKG()
	{
	}

	// Token: 0x04000818 RID: 2072
	public Shader SCShader;

	// Token: 0x04000819 RID: 2073
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400081A RID: 2074
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400081B RID: 2075
	private Material BJFKDHHMLJH;

	// Token: 0x0400081C RID: 2076
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x0400081D RID: 2077
	[Range(0f, 10f)]
	private float EOKMJCIDCDB = 1f;

	// Token: 0x0400081E RID: 2078
	[Range(0f, 10f)]
	private float ILHJFHFPGBB = 1f;

	// Token: 0x0400081F RID: 2079
	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;

	// Token: 0x04000820 RID: 2080
	private Texture2D FPHEBLMINDA;
}
