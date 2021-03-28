using System;
using UnityEngine;

// Token: 0x02000128 RID: 296
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/TV/Vignetting")]
public class CameraFilterPack_TV_Vignetting : MonoBehaviour
{
	// Token: 0x06005DA3 RID: 23971 RVA: 0x001C9AA8 File Offset: 0x001C7CA8
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.DKKBFFHBHJE().SetTexture(".completedCount", this.IJFBACJAHAG);
			this.LPDOGGFOBDH().SetFloat("[LobbyPlayerElement] On ready click", this.Vignetting);
			this.KBOPGONOCNP().SetFloat("SetParticlesCountPerBeat", this.VignettingFull);
			this.DOHGBNPMBKG().SetColor("english", this.VignettingColor);
			this.DONENAMLFLF().SetFloat("TBD", this.VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005DA4 RID: 23972 RVA: 0x001C9B50 File Offset: 0x001C7D50
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.MFHPKGICPIO().SetTexture("SteamManager", this.IJFBACJAHAG);
			this.BLMPMOIDGMG().SetFloat("x", this.Vignetting);
			this.OGMEGHKECAH().SetFloat("_ScreenResolution", this.VignettingFull);
			this.DNLMFEGJJDD().SetColor("Print the list of scenes, avalable in game.", this.VignettingColor);
			this.OGMEGHKECAH().SetFloat(" ", this.VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005DA5 RID: 23973 RVA: 0x001C9BF5 File Offset: 0x001C7DF5
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Gradients_FireGradient");
		this.IJFBACJAHAG = (Resources.Load("[") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005DA6 RID: 23974 RVA: 0x001C9C2E File Offset: 0x001C7E2E
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("_RgbDepthTex");
		this.IJFBACJAHAG = (Resources.Load("ConnectToMaster() disabled the offline mode. No longer offline.") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005DA7 RID: 23975 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06005DA9 RID: 23977 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOLDLDLFFLM()
	{
	}

	// Token: 0x06005DAA RID: 23978 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x06005DAB RID: 23979 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x06005DAC RID: 23980 RVA: 0x001C9C99 File Offset: 0x001C7E99
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005DAD RID: 23981 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x06005DAE RID: 23982 RVA: 0x001C9CB6 File Offset: 0x001C7EB6
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find(".sawoutdatedmessage");
		this.IJFBACJAHAG = (Resources.Load("y") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005DAF RID: 23983 RVA: 0x001C9CEF File Offset: 0x001C7EEF
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005DB0 RID: 23984 RVA: 0x001C9D28 File Offset: 0x001C7F28
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.IONHGBPGCHK().SetTexture("/", this.IJFBACJAHAG);
			this.MFHPKGICPIO().SetFloat("_Value", this.Vignetting);
			this.IONHGBPGCHK().SetFloat("Editor", this.VignettingFull);
			this.IONHGBPGCHK().SetColor(";", this.VignettingColor);
			this.IONHGBPGCHK().SetFloat("_Distortion", this.VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005DB1 RID: 23985 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06005DB2 RID: 23986 RVA: 0x001C9DCD File Offset: 0x001C7FCD
	private Material BLMPMOIDGMG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005DB3 RID: 23987 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x06005DB4 RID: 23988 RVA: 0x001C9E04 File Offset: 0x001C8004
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005DB5 RID: 23989 RVA: 0x001C9E3C File Offset: 0x001C803C
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.DOHGBNPMBKG().SetTexture("UI/Particles/Hidden", this.IJFBACJAHAG);
			this.BLMPMOIDGMG().SetFloat("CameraFilterPack/FX_DarkMatter", this.Vignetting);
			this.HEINDEMCGIK().SetFloat("_SpherePositionY", this.VignettingFull);
			this.BLMPMOIDGMG().SetColor("\r", this.VignettingColor);
			this.EOCCJGIGEGJ().SetFloat("shader.none", this.VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005DB6 RID: 23990 RVA: 0x001C9C99 File Offset: 0x001C7E99
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005DB7 RID: 23991 RVA: 0x001C9EE1 File Offset: 0x001C80E1
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005DB8 RID: 23992 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005DB9 RID: 23993 RVA: 0x001C9F18 File Offset: 0x001C8118
	private Material OJMHIMIPKME()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005DBA RID: 23994 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x06005DBB RID: 23995 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x06005DBC RID: 23996 RVA: 0x001C9C99 File Offset: 0x001C7E99
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005DBD RID: 23997 RVA: 0x001C9C99 File Offset: 0x001C7E99
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005DBE RID: 23998 RVA: 0x001C9F4F File Offset: 0x001C814F
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005DBF RID: 23999 RVA: 0x001C9F88 File Offset: 0x001C8188
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.DKKBFFHBHJE().SetTexture("{0}", this.IJFBACJAHAG);
			this.DNLMFEGJJDD().SetFloat("_TimeX", this.Vignetting);
			this.MFHPKGICPIO().SetFloat("workshop.", this.VignettingFull);
			this.DOHGBNPMBKG().SetColor("resource", this.VignettingColor);
			this.GJHPODJOBHL().SetFloat("CameraFilterPack_VHS1", this.VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005DC0 RID: 24000 RVA: 0x001C9C99 File Offset: 0x001C7E99
	private void DKPBBJINKMG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005DC1 RID: 24001 RVA: 0x001CA02D File Offset: 0x001C822D
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)73;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x1700010D RID: 269
	// (get) Token: 0x06005DC2 RID: 24002 RVA: 0x001CA064 File Offset: 0x001C8264
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

	// Token: 0x06005DC3 RID: 24003 RVA: 0x001C9C99 File Offset: 0x001C7E99
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005DC4 RID: 24004 RVA: 0x001CA09B File Offset: 0x001C829B
	private void COOHIILCOCO()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		this.IJFBACJAHAG = (Resources.Load("0.00") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005DC5 RID: 24005 RVA: 0x001C9C99 File Offset: 0x001C7E99
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005DC6 RID: 24006 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x06005DC7 RID: 24007 RVA: 0x001C9C99 File Offset: 0x001C7E99
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005DC8 RID: 24008 RVA: 0x001C9C99 File Offset: 0x001C7E99
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005DC9 RID: 24009 RVA: 0x001CA0D4 File Offset: 0x001C82D4
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("_SecondTex");
		this.IJFBACJAHAG = (Resources.Load("Hex value #RRGGBB") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005DCA RID: 24010 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x06005DCB RID: 24011 RVA: 0x001CA10D File Offset: 0x001C830D
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005DCC RID: 24012 RVA: 0x0002523B File Offset: 0x0002343B
	private void FGNFILLNPJK()
	{
	}

	// Token: 0x06005DCD RID: 24013 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06005DCE RID: 24014 RVA: 0x001CA144 File Offset: 0x001C8344
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.NBPKMLMCHFN.SetTexture("Vignette", this.IJFBACJAHAG);
			this.NBPKMLMCHFN.SetFloat("_Vignetting", this.Vignetting);
			this.NBPKMLMCHFN.SetFloat("_Vignetting2", this.VignettingFull);
			this.NBPKMLMCHFN.SetColor("_VignettingColor", this.VignettingColor);
			this.NBPKMLMCHFN.SetFloat("_VignettingDirt", this.VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005DCF RID: 24015 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x06005DD0 RID: 24016 RVA: 0x001CA1E9 File Offset: 0x001C83E9
	private Material GJHPODJOBHL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005DD1 RID: 24017 RVA: 0x001CA220 File Offset: 0x001C8420
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("BitsData");
		this.IJFBACJAHAG = (Resources.Load("_ScreenResolution") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005DD2 RID: 24018 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x06005DD3 RID: 24019 RVA: 0x001CA25C File Offset: 0x001C845C
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.LNLKMDPHDCC().SetTexture("_Value5", this.IJFBACJAHAG);
			this.OGMEGHKECAH().SetFloat("R1", this.Vignetting);
			this.IONHGBPGCHK().SetFloat("hidden", this.VignettingFull);
			this.DNLMFEGJJDD().SetColor("_LightIntensity", this.VignettingColor);
			this.NBPKMLMCHFN.SetFloat("quit", this.VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005DD4 RID: 24020 RVA: 0x001CA304 File Offset: 0x001C8504
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HEINDEMCGIK().SetTexture("_Value3", this.IJFBACJAHAG);
			this.NBPKMLMCHFN.SetFloat("_SoftZDistance", this.Vignetting);
			this.DKKBFFHBHJE().SetFloat("SetBGColor", this.VignettingFull);
			this.DNLMFEGJJDD().SetColor("x", this.VignettingColor);
			this.DOHGBNPMBKG().SetFloat("_Value3", this.VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005DD5 RID: 24021 RVA: 0x001C9C99 File Offset: 0x001C7E99
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005DD6 RID: 24022 RVA: 0x001CA3A9 File Offset: 0x001C85A9
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005DD7 RID: 24023 RVA: 0x001CA3E0 File Offset: 0x001C85E0
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("mapselector.filter.rateduponly");
		this.IJFBACJAHAG = (Resources.Load("_TimeX") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005DD8 RID: 24024 RVA: 0x001CA419 File Offset: 0x001C8619
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		this.IJFBACJAHAG = (Resources.Load("CameraFilterPack/Blend2Camera_ColorKey") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005DD9 RID: 24025 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06005DDA RID: 24026 RVA: 0x001CA452 File Offset: 0x001C8652
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005DDB RID: 24027 RVA: 0x001C9C99 File Offset: 0x001C7E99
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005DDC RID: 24028 RVA: 0x001CA489 File Offset: 0x001C8689
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005DDD RID: 24029 RVA: 0x001C9C99 File Offset: 0x001C7E99
	private void NNBCLMJGFEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005DDE RID: 24030 RVA: 0x001CA4C0 File Offset: 0x001C86C0
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.DKKBFFHBHJE().SetTexture("^", this.IJFBACJAHAG);
			this.MMOODGIODPC().SetFloat("BloodAlternative1", this.Vignetting);
			this.DONENAMLFLF().SetFloat("checkpoint", this.VignettingFull);
			this.IONHGBPGCHK().SetColor("CameraFilterPack/TV_Old_Movie", this.VignettingColor);
			this.OGMEGHKECAH().SetFloat("_ScreenResolution", this.VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005DDF RID: 24031 RVA: 0x001C9C99 File Offset: 0x001C7E99
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005DE0 RID: 24032 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x06005DE1 RID: 24033 RVA: 0x001CA565 File Offset: 0x001C8765
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005DE2 RID: 24034 RVA: 0x001CA59C File Offset: 0x001C879C
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005DE3 RID: 24035 RVA: 0x001CA5D3 File Offset: 0x001C87D3
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005DE4 RID: 24036 RVA: 0x001CA60C File Offset: 0x001C880C
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.LNLKMDPHDCC().SetTexture("ChatInput", this.IJFBACJAHAG);
			this.DONENAMLFLF().SetFloat("LastNewsButton", this.Vignetting);
			this.DKKBFFHBHJE().SetFloat("Joystick1Button1", this.VignettingFull);
			this.HEINDEMCGIK().SetColor("_Bullet_2", this.VignettingColor);
			this.IIJMIPBMMBF().SetFloat("_Y", this.VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005DE5 RID: 24037 RVA: 0x001CA6B1 File Offset: 0x001C88B1
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_Vignetting");
		this.IJFBACJAHAG = (Resources.Load("CameraFilterPack_TV_Vignetting1") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005DE6 RID: 24038 RVA: 0x001CA6EC File Offset: 0x001C88EC
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HEINDEMCGIK().SetTexture("CameraFilterPack_TV_BrokenGlass1", this.IJFBACJAHAG);
			this.MMOODGIODPC().SetFloat("Ev Destroy Failed. Could not find PhotonView with instantiationId ", this.Vignetting);
			this.GJHPODJOBHL().SetFloat("Prints list of commands", this.VignettingFull);
			this.NBPKMLMCHFN.SetColor("runas", this.VignettingColor);
			this.HEINDEMCGIK().SetFloat("player.crystal", this.VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005DE7 RID: 24039 RVA: 0x001CA794 File Offset: 0x001C8994
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.EOCCJGIGEGJ().SetTexture("OpJoinRandomRoom()", this.IJFBACJAHAG);
			this.EOCCJGIGEGJ().SetFloat("_Value3", this.Vignetting);
			this.GJHPODJOBHL().SetFloat("_Value3", this.VignettingFull);
			this.EMDFHOKEGNG().SetColor("_Value2", this.VignettingColor);
			this.DONENAMLFLF().SetFloat("_MainTex2", this.VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005DE8 RID: 24040 RVA: 0x001C9C99 File Offset: 0x001C7E99
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005DE9 RID: 24041 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x06005DEA RID: 24042 RVA: 0x001CA839 File Offset: 0x001C8A39
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("https://reddit.com/r/Intralism");
		this.IJFBACJAHAG = (Resources.Load("_Value2") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005DEB RID: 24043 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06005DEC RID: 24044 RVA: 0x001CA872 File Offset: 0x001C8A72
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-68);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005DED RID: 24045 RVA: 0x001CA8AC File Offset: 0x001C8AAC
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HEINDEMCGIK().SetTexture("[SERVER] Selected map: ", this.IJFBACJAHAG);
			this.OJMHIMIPKME().SetFloat("2hands", this.Vignetting);
			this.MMOODGIODPC().SetFloat(" .", this.VignettingFull);
			this.IONHGBPGCHK().SetColor("player", this.VignettingColor);
			this.BLMPMOIDGMG().SetFloat("settings.enableranking", this.VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005DEE RID: 24046 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x06005DEF RID: 24047 RVA: 0x001CA954 File Offset: 0x001C8B54
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.KBOPGONOCNP().SetTexture("BitsData", this.IJFBACJAHAG);
			this.DKKBFFHBHJE().SetFloat("AVG Misses:", this.Vignetting);
			this.LNLKMDPHDCC().SetFloat("Gameplay/satellite", this.VignettingFull);
			this.IONHGBPGCHK().SetColor("hitsounds:", this.VignettingColor);
			this.KBOPGONOCNP().SetFloat("RenderTextureUtilityTempTexture", this.VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005DF0 RID: 24048 RVA: 0x001CA9F9 File Offset: 0x001C8BF9
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find("ScreenResolutionPanel");
		this.IJFBACJAHAG = (Resources.Load("Yes") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005DF1 RID: 24049 RVA: 0x001CAA32 File Offset: 0x001C8C32
	private void LGHCJCFHEMF()
	{
		this.SCShader = Shader.Find("Drop_With_Obj");
		this.IJFBACJAHAG = (Resources.Load("_MainTex2") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005DF2 RID: 24050 RVA: 0x001C9C99 File Offset: 0x001C7E99
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005DF3 RID: 24051 RVA: 0x001CAA6B File Offset: 0x001C8C6B
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005DF4 RID: 24052 RVA: 0x001C9C99 File Offset: 0x001C7E99
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005DF5 RID: 24053 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x06005DF6 RID: 24054 RVA: 0x001C9C99 File Offset: 0x001C7E99
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005DF7 RID: 24055 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06005DF8 RID: 24056 RVA: 0x001CAAA4 File Offset: 0x001C8CA4
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.OJMHIMIPKME().SetTexture("Loading maps", this.IJFBACJAHAG);
			this.HEINDEMCGIK().SetFloat("uploads/Intralism/mods_terms.pdf", this.Vignetting);
			this.OJMHIMIPKME().SetFloat("_ScreenResolution", this.VignettingFull);
			this.HEINDEMCGIK().SetColor(": ", this.VignettingColor);
			this.DONENAMLFLF().SetFloat("closed", this.VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005DF9 RID: 24057 RVA: 0x001CAB49 File Offset: 0x001C8D49
	private void KOFAMEKHHGD()
	{
		this.SCShader = Shader.Find("_Value4");
		this.IJFBACJAHAG = (Resources.Load("ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005DFA RID: 24058 RVA: 0x001C9C99 File Offset: 0x001C7E99
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005DFB RID: 24059 RVA: 0x001C9C99 File Offset: 0x001C7E99
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005DFC RID: 24060 RVA: 0x001CAB84 File Offset: 0x001C8D84
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.KBOPGONOCNP().SetTexture("AccuracyScoreText", this.IJFBACJAHAG);
			this.KBOPGONOCNP().SetFloat("Updating...", this.Vignetting);
			this.IONHGBPGCHK().SetFloat("settings_bindings_sec_", this.VignettingFull);
			this.IONHGBPGCHK().SetColor("MenuVolumeSlider", this.VignettingColor);
			this.MFHPKGICPIO().SetFloat("Failed to Destroy objects of playerId: ", this.VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005DFD RID: 24061 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x06005DFE RID: 24062 RVA: 0x001C9C99 File Offset: 0x001C7E99
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005DFF RID: 24063 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06005E00 RID: 24064 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06005E01 RID: 24065 RVA: 0x001CAC29 File Offset: 0x001C8E29
	private void HIPEHGNBJMN()
	{
		this.SCShader = Shader.Find("_Value6");
		this.IJFBACJAHAG = (Resources.Load("Yes") as Texture2D);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005E02 RID: 24066 RVA: 0x001CAC64 File Offset: 0x001C8E64
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.EMDFHOKEGNG().SetTexture("[Up-Right-Left]", this.IJFBACJAHAG);
			this.IIJMIPBMMBF().SetFloat("finished", this.Vignetting);
			this.IIJMIPBMMBF().SetFloat("settings.arcsnohitsoundtimedelay", this.VignettingFull);
			this.GJHPODJOBHL().SetColor("_Value2", this.VignettingColor);
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this.VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E03 RID: 24067 RVA: 0x001CAD0C File Offset: 0x001C8F0C
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.GJHPODJOBHL().SetTexture("_ScreenResolution", this.IJFBACJAHAG);
			this.EMDFHOKEGNG().SetFloat("_TimeX", this.Vignetting);
			this.DONENAMLFLF().SetFloat("#mapalreadyexistupdate", this.VignettingFull);
			this.KBOPGONOCNP().SetColor("_ScreenResolution", this.VignettingColor);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Oculus_NightVision5", this.VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E04 RID: 24068 RVA: 0x001CADB4 File Offset: 0x001C8FB4
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.DOHGBNPMBKG().SetTexture("_Value", this.IJFBACJAHAG);
			this.EOCCJGIGEGJ().SetFloat("CameraFilterPack/FX_Glitch1", this.Vignetting);
			this.DKKBFFHBHJE().SetFloat("_Value4", this.VignettingFull);
			this.IONHGBPGCHK().SetColor("_RedAmplifier", this.VignettingColor);
			this.MFHPKGICPIO().SetFloat(".icon", this.VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E05 RID: 24069 RVA: 0x001CAE5C File Offset: 0x001C905C
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.LPDOGGFOBDH().SetTexture("_Red_G", this.IJFBACJAHAG);
			this.GJHPODJOBHL().SetFloat("SetTrailZoomSpeed", this.Vignetting);
			this.NBPKMLMCHFN.SetFloat("SetEnvSpriteColor", this.VignettingFull);
			this.OGMEGHKECAH().SetColor("set environment id", this.VignettingColor);
			this.OGMEGHKECAH().SetFloat("_Value", this.VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E06 RID: 24070 RVA: 0x001C9C99 File Offset: 0x001C7E99
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E07 RID: 24071 RVA: 0x001CAF04 File Offset: 0x001C9104
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.DNLMFEGJJDD().SetTexture("_Fade", this.IJFBACJAHAG);
			this.KBOPGONOCNP().SetFloat("1,30,true,0", this.Vignetting);
			this.KBOPGONOCNP().SetFloat("id", this.VignettingFull);
			this.MFHPKGICPIO().SetColor("_DotSize", this.VignettingColor);
			this.NBPKMLMCHFN.SetFloat("Joystick1Button10", this.VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E08 RID: 24072 RVA: 0x001CAFAC File Offset: 0x001C91AC
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.EMDFHOKEGNG().SetTexture("CameraFilterPack_eyes_vision_1", this.IJFBACJAHAG);
			this.EOCCJGIGEGJ().SetFloat("_TimeX", this.Vignetting);
			this.IONHGBPGCHK().SetFloat("_Offset", this.VignettingFull);
			this.DKKBFFHBHJE().SetColor("1", this.VignettingColor);
			this.KBOPGONOCNP().SetFloat("Connection error: ", this.VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E09 RID: 24073 RVA: 0x001CB051 File Offset: 0x001C9251
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E0A RID: 24074 RVA: 0x001CB088 File Offset: 0x001C9288
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.BLMPMOIDGMG().SetTexture("HighScaleShot", this.IJFBACJAHAG);
			this.LNLKMDPHDCC().SetFloat("0", this.Vignetting);
			this.IIJMIPBMMBF().SetFloat("JoinRoom failed. A roomname is required. If you don't know one, how will you join?", this.VignettingFull);
			this.MFHPKGICPIO().SetColor("offsets", this.VignettingColor);
			this.KBOPGONOCNP().SetFloat("_Value9", this.VignettingDirt);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x04000973 RID: 2419
	public Shader SCShader;

	// Token: 0x04000974 RID: 2420
	private Material BJFKDHHMLJH;

	// Token: 0x04000975 RID: 2421
	private Texture2D IJFBACJAHAG;

	// Token: 0x04000976 RID: 2422
	[Range(0f, 1f)]
	public float Vignetting = 1f;

	// Token: 0x04000977 RID: 2423
	[Range(0f, 1f)]
	public float VignettingFull;

	// Token: 0x04000978 RID: 2424
	[Range(0f, 1f)]
	public float VignettingDirt;

	// Token: 0x04000979 RID: 2425
	public Color VignettingColor = new Color(0f, 0f, 0f, 1f);
}
