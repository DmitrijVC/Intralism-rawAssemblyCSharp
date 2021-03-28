using System;
using UnityEngine;

// Token: 0x02000136 RID: 310
[AddComponentMenu("Camera Filter Pack/Vision/Plasma")]
[ExecuteInEditMode]
public class CameraFilterPack_Vision_Plasma : MonoBehaviour
{
	// Token: 0x060061AC RID: 25004 RVA: 0x001DB023 File Offset: 0x001D9223
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060061AD RID: 25005 RVA: 0x001DB040 File Offset: 0x001D9240
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060061AE RID: 25006 RVA: 0x001DB023 File Offset: 0x001D9223
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060061AF RID: 25007 RVA: 0x001DB023 File Offset: 0x001D9223
	private void HNGHDAPKEJG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060061B0 RID: 25008 RVA: 0x001DB077 File Offset: 0x001D9277
	private void JABNHMIHBHC()
	{
		this.SCShader = Shader.Find("_PColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060061B1 RID: 25009 RVA: 0x001DB09B File Offset: 0x001D929B
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("AudioSampler");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060061B2 RID: 25010 RVA: 0x001DB0BF File Offset: 0x001D92BF
	private void NKFDNIAKGEO()
	{
		this.SCShader = Shader.Find("#pleasewait");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060061B3 RID: 25011 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x060061B4 RID: 25012 RVA: 0x001DB023 File Offset: 0x001D9223
	private void ABEIEGDHBNO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060061B6 RID: 25014 RVA: 0x001DB122 File Offset: 0x001D9322
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060061B7 RID: 25015 RVA: 0x001DB146 File Offset: 0x001D9346
	private Material PEIMCBBHLBJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060061B8 RID: 25016 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x060061B9 RID: 25017 RVA: 0x001DB17D File Offset: 0x001D937D
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)117;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060061BA RID: 25018 RVA: 0x001DB1B4 File Offset: 0x001D93B4
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("sprite");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060061BB RID: 25019 RVA: 0x001DB1D8 File Offset: 0x001D93D8
	private Material NMDBCDFPGOK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060061BC RID: 25020 RVA: 0x001DB210 File Offset: 0x001D9410
	private void KPOCGNOKNOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 727f)
			{
				this.HBJJOCHGOPH = 673f;
			}
			this.HKHBBBFLGJH().SetFloat("Committing changes...", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("[PlayerController] ", this.Value);
			this.CECICEGFHKL().SetFloat("[Up-Down]", this.Value2);
			this.BAGICADFBAB().SetFloat("'{0}'{1}{2}", this.Intensity);
			this.NDMPCDHADMJ().SetFloat("DPADVER", this.CCIENBFIKKH);
			this.IIJMIPBMMBF().SetVector("Mouse Y", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 795f, 804f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NMDBCDFPGOK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060061BD RID: 25021 RVA: 0x001DB023 File Offset: 0x001D9223
	private void NNPBKKBFDHH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060061BE RID: 25022 RVA: 0x001DB023 File Offset: 0x001D9223
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060061BF RID: 25023 RVA: 0x001DB30F File Offset: 0x001D950F
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("EditMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060061C0 RID: 25024 RVA: 0x001DB334 File Offset: 0x001D9534
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1306f)
			{
				this.HBJJOCHGOPH = 1297f;
			}
			this.LMLENGFLEBD().SetFloat("_Screen", this.HBJJOCHGOPH);
			this.CECICEGFHKL().SetFloat("#tryagain", this.Value);
			this.PEIMCBBHLBJ().SetFloat("_TimeX", this.Value2);
			this.HKHBBBFLGJH().SetFloat("OK", this.Intensity);
			this.ENKPNJMPDEB().SetFloat("Set particles count per one beat", this.CCIENBFIKKH);
			this.DKNJGHFLAIF().SetVector("]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 877f, 188f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060061C1 RID: 25025 RVA: 0x001DB433 File Offset: 0x001D9633
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("_Intensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060061C2 RID: 25026 RVA: 0x001DB023 File Offset: 0x001D9223
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060061C3 RID: 25027 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBFJAOINHMK()
	{
	}

	// Token: 0x060061C4 RID: 25028 RVA: 0x001DB023 File Offset: 0x001D9223
	private void MKFLBEGJJDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060061C5 RID: 25029 RVA: 0x001DB457 File Offset: 0x001D9657
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)64;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060061C6 RID: 25030 RVA: 0x0002523B File Offset: 0x0002343B
	private void AKCADICOFDD()
	{
	}

	// Token: 0x060061C7 RID: 25031 RVA: 0x001DB48E File Offset: 0x001D968E
	private void JDKHBGDEONK()
	{
		this.SCShader = Shader.Find("#{0:00}{1}{2}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060061C8 RID: 25032 RVA: 0x001DB4B2 File Offset: 0x001D96B2
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060061C9 RID: 25033 RVA: 0x001DB4D6 File Offset: 0x001D96D6
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060061CA RID: 25034 RVA: 0x001DB50D File Offset: 0x001D970D
	private void HDMDKOKOOJC()
	{
		this.SCShader = Shader.Find("Sprite");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060061CB RID: 25035 RVA: 0x001DB534 File Offset: 0x001D9734
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 890f)
			{
				this.HBJJOCHGOPH = 1675f;
			}
			this.HNFFHCLNBDN().SetFloat("skin.", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetFloat("_ScreenResolution", this.Value);
			this.NDMPCDHADMJ().SetFloat("_Offsets", this.Value2);
			this.NMDBCDFPGOK().SetFloat("LivesSlider", this.Intensity);
			this.FLOHGDECHHH().SetFloat("_ScreenResolution", this.CCIENBFIKKH);
			this.OIIDAKBILMI().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1806f, 1112f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060061CC RID: 25036 RVA: 0x001DB633 File Offset: 0x001D9833
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060061CD RID: 25037 RVA: 0x0002523B File Offset: 0x0002343B
	private void JCGMGLMADEN()
	{
	}

	// Token: 0x060061CE RID: 25038 RVA: 0x001DB66C File Offset: 0x001D986C
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 398f)
			{
				this.HBJJOCHGOPH = 818f;
			}
			this.OGMEGHKECAH().SetFloat("LevelURLInputField", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("0.00", this.Value);
			this.GKILCDHJFEG().SetFloat("id", this.Value2);
			this.DKNJGHFLAIF().SetFloat("  |  Events Count: ", this.Intensity);
			this.KEMJNOMIPHN().SetFloat("#checkpoint", this.CCIENBFIKKH);
			this.NDMPCDHADMJ().SetVector("ReconnectAndRejoin() disabled the offline mode. No longer offline.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1441f, 368f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060061CF RID: 25039 RVA: 0x001DB76C File Offset: 0x001D996C
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
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Value2);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060061D0 RID: 25040 RVA: 0x001DB86B File Offset: 0x001D9A6B
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("Preparing content...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060061D1 RID: 25041 RVA: 0x001DB88F File Offset: 0x001D9A8F
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("Preparing content...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060061D2 RID: 25042 RVA: 0x001DB023 File Offset: 0x001D9223
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060061D3 RID: 25043 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x060061D4 RID: 25044 RVA: 0x001DB8B4 File Offset: 0x001D9AB4
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1240f)
			{
				this.HBJJOCHGOPH = 124f;
			}
			this.ENKPNJMPDEB().SetFloat("Error! no audio sources attached to AudioSampler.css", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("]. Please verify you have this gameobject in a Resources folder.", this.Value);
			this.NFKFAAHHLLM().SetFloat("/", this.Value2);
			this.NDMPCDHADMJ().SetFloat("ShadersToggle", this.Intensity);
			this.NDMPCDHADMJ().SetFloat("turn", this.CCIENBFIKKH);
			this.PEIMCBBHLBJ().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1956f, 302f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060061D5 RID: 25045 RVA: 0x001DB023 File Offset: 0x001D9223
	private void EKPLGFAEOBE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060061D6 RID: 25046 RVA: 0x001DB023 File Offset: 0x001D9223
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060061D7 RID: 25047 RVA: 0x001DB9B3 File Offset: 0x001D9BB3
	private void ALNNIDLFILB()
	{
		this.SCShader = Shader.Find("CameraFilterPack_Glasses_On5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060061D8 RID: 25048 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x060061D9 RID: 25049 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x060061DA RID: 25050 RVA: 0x001DB023 File Offset: 0x001D9223
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060061DB RID: 25051 RVA: 0x001DB023 File Offset: 0x001D9223
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060061DC RID: 25052 RVA: 0x001DB9D8 File Offset: 0x001D9BD8
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1427f)
			{
				this.HBJJOCHGOPH = 959f;
			}
			this.ENKPNJMPDEB().SetFloat("_DepthLevel", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("RanksButton", this.Value);
			this.IIJMIPBMMBF().SetFloat("_Blend", this.Value2);
			this.CFEDGDGBCHE().SetFloat("File not found: {0}", this.Intensity);
			this.PEIMCBBHLBJ().SetFloat("Uploading content", this.CCIENBFIKKH);
			this.IIJMIPBMMBF().SetVector("[PlayerController] ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1619f, 766f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060061DD RID: 25053 RVA: 0x001DBAD8 File Offset: 0x001D9CD8
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1317f)
			{
				this.HBJJOCHGOPH = 1705f;
			}
			this.FLOHGDECHHH().SetFloat("CameraFilterPack/Blend2Camera_LinearBurn", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("maps.", this.Value);
			this.NMDBCDFPGOK().SetFloat("\0\0", this.Value2);
			this.OIIDAKBILMI().SetFloat("custom", this.Intensity);
			this.OIIDAKBILMI().SetFloat("#rate!", this.CCIENBFIKKH);
			this.HKIMAANBGMJ().SetVector("Crosshair", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 556f, 783f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060061DE RID: 25054 RVA: 0x001DBBD8 File Offset: 0x001D9DD8
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 744f)
			{
				this.HBJJOCHGOPH = 891f;
			}
			this.LMLENGFLEBD().SetFloat("Value", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("_Parameter", this.Value);
			this.HCGJCMDJPGD().SetFloat("GLITCH", this.Value2);
			this.HNFFHCLNBDN().SetFloat("ClearEnvironment", this.Intensity);
			this.FKEOGPDLBDD().SetFloat("_Color_B", this.CCIENBFIKKH);
			this.BAGICADFBAB().SetVector("_FixDistance", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 238f, 765f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060061DF RID: 25055 RVA: 0x001DB146 File Offset: 0x001D9346
	private Material NJDIODJNGGA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060061E0 RID: 25056 RVA: 0x001DBCD8 File Offset: 0x001D9ED8
	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1209f)
			{
				this.HBJJOCHGOPH = 877f;
			}
			this.FLOHGDECHHH().SetFloat("_Quality", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("_ScreenResolution", this.Value);
			this.NFKFAAHHLLM().SetFloat("id", this.Value2);
			this.DKNJGHFLAIF().SetFloat("{0,-18} {1,18}", this.Intensity);
			this.CFEDGDGBCHE().SetFloat("ArcsNoHitsoundTimeDelaySlider", this.CCIENBFIKKH);
			this.GKILCDHJFEG().SetVector(" respawn in future: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1291f, 1863f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ENKPNJMPDEB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060061E1 RID: 25057 RVA: 0x001DB023 File Offset: 0x001D9223
	private void BNLENEDAHHL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060061E2 RID: 25058 RVA: 0x001DBDD8 File Offset: 0x001D9FD8
	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 684f)
			{
				this.HBJJOCHGOPH = 199f;
			}
			this.GKILCDHJFEG().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.CECICEGFHKL().SetFloat("CameraFilterPack/Blend2Camera_LinearBurn", this.Value);
			this.NDMPCDHADMJ().SetFloat("_TimeX", this.Value2);
			this.CECICEGFHKL().SetFloat("_TimeX", this.Intensity);
			this.IIJMIPBMMBF().SetFloat("id", this.CCIENBFIKKH);
			this.KGOLDDBHIFN().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 725f, 99f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060061E3 RID: 25059 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x060061E4 RID: 25060 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x060061E5 RID: 25061 RVA: 0x001DB17D File Offset: 0x001D937D
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)117;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060061E6 RID: 25062 RVA: 0x001DBED8 File Offset: 0x001DA0D8
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1813f)
			{
				this.HBJJOCHGOPH = 887f;
			}
			this.CFEDGDGBCHE().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("Editor", this.Value);
			this.OIIDAKBILMI().SetFloat("_ScreenResolution", this.Value2);
			this.OIIDAKBILMI().SetFloat("DifficultyBG", this.Intensity);
			this.HCGJCMDJPGD().SetFloat("downloading", this.CCIENBFIKKH);
			this.HCGJCMDJPGD().SetVector("[PlayerBase] SetBGColor error: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 293f, 441f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060061E7 RID: 25063 RVA: 0x001DBFD7 File Offset: 0x001DA1D7
	private void EDPDMBFLHLP()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Color_GrayScale");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060061E8 RID: 25064 RVA: 0x001DBFFB File Offset: 0x001DA1FB
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Vision_Plasma");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060061E9 RID: 25065 RVA: 0x001DC01F File Offset: 0x001DA21F
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Glasses_On");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060061EA RID: 25066 RVA: 0x001DC043 File Offset: 0x001DA243
	private Material CECICEGFHKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060061EB RID: 25067 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x060061EC RID: 25068 RVA: 0x001DC07A File Offset: 0x001DA27A
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060061ED RID: 25069 RVA: 0x001DC0B1 File Offset: 0x001DA2B1
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060061EE RID: 25070 RVA: 0x001DC0E8 File Offset: 0x001DA2E8
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060061EF RID: 25071 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x060061F0 RID: 25072 RVA: 0x001DB023 File Offset: 0x001D9223
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060061F1 RID: 25073 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOAGAKFBIGD()
	{
	}

	// Token: 0x060061F2 RID: 25074 RVA: 0x001DC120 File Offset: 0x001DA320
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 457f)
			{
				this.HBJJOCHGOPH = 14f;
			}
			this.EJDPNJAEAKJ().SetFloat("/", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("Fade", this.Value);
			this.OIIDAKBILMI().SetFloat("_FixDistance", this.Value2);
			this.LMLENGFLEBD().SetFloat("settings.arcshitsoundtimedelay", this.Intensity);
			this.HNFFHCLNBDN().SetFloat("skin.hit_normal", this.CCIENBFIKKH);
			this.CECICEGFHKL().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1558f, 314f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060061F3 RID: 25075 RVA: 0x001DC21F File Offset: 0x001DA41F
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060061F4 RID: 25076 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x060061F5 RID: 25077 RVA: 0x001DC258 File Offset: 0x001DA458
	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1212f)
			{
				this.HBJJOCHGOPH = 313f;
			}
			this.HCGJCMDJPGD().SetFloat("CameraFilterPack/Lut_Simple", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetFloat("/", this.Value);
			this.NMDBCDFPGOK().SetFloat("yes", this.Value2);
			this.ENKPNJMPDEB().SetFloat("OxOD.lastPath", this.Intensity);
			this.NDMPCDHADMJ().SetFloat("_ScreenResolution", this.CCIENBFIKKH);
			this.ENKPNJMPDEB().SetVector("FreqVolume: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 57f, 85f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060061F6 RID: 25078 RVA: 0x001DC357 File Offset: 0x001DA557
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("player.currentrank");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060061F7 RID: 25079 RVA: 0x001DC37B File Offset: 0x001DA57B
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060061F8 RID: 25080 RVA: 0x001DC3B4 File Offset: 0x001DA5B4
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 127f)
			{
				this.HBJJOCHGOPH = 49f;
			}
			this.OGMEGHKECAH().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("fade in duration", this.Value);
			this.FLOHGDECHHH().SetFloat("_Value7", this.Value2);
			this.CFEDGDGBCHE().SetFloat("_Threshhold", this.Intensity);
			this.PEIMCBBHLBJ().SetFloat("_Bullet_8", this.CCIENBFIKKH);
			this.DKNJGHFLAIF().SetVector(" / ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1588f, 1029f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060061F9 RID: 25081 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x1700011B RID: 283
	// (get) Token: 0x060061FA RID: 25082 RVA: 0x001DC4B3 File Offset: 0x001DA6B3
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

	// Token: 0x060061FB RID: 25083 RVA: 0x001DC4EA File Offset: 0x001DA6EA
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("_Visualize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060061FC RID: 25084 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x060061FD RID: 25085 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x060061FE RID: 25086 RVA: 0x001DC50E File Offset: 0x001DA70E
	private void JONGNKNLLND()
	{
		this.SCShader = Shader.Find(".lastCheckpoint.correctScore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060061FF RID: 25087 RVA: 0x001DC534 File Offset: 0x001DA734
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 96f)
			{
				this.HBJJOCHGOPH = 1989f;
			}
			this.ENKPNJMPDEB().SetFloat("inventory.selected.", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("_DistortionSize", this.Value);
			this.KBOPGONOCNP().SetFloat("_ScreenResolution", this.Value2);
			this.NDMPCDHADMJ().SetFloat("mapselector.filter.subscribedonly", this.Intensity);
			this.LNLKMDPHDCC().SetFloat("#no", this.CCIENBFIKKH);
			this.DKNJGHFLAIF().SetVector("workshop.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1683f, 1399f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006200 RID: 25088 RVA: 0x001DC633 File Offset: 0x001DA833
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006201 RID: 25089 RVA: 0x001DC66A File Offset: 0x001DA86A
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006202 RID: 25090 RVA: 0x001DC6A1 File Offset: 0x001DA8A1
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("SetPlayerDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006203 RID: 25091 RVA: 0x001DC6C8 File Offset: 0x001DA8C8
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1918f)
			{
				this.HBJJOCHGOPH = 751f;
			}
			this.FKEOGPDLBDD().SetFloat("offsets", this.HBJJOCHGOPH);
			this.FKEOGPDLBDD().SetFloat(".sav", this.Value);
			this.KGOLDDBHIFN().SetFloat("_EmissionColor", this.Value2);
			this.ENKPNJMPDEB().SetFloat("CameraFilterPack/FX_Plasma", this.Intensity);
			this.HCGJCMDJPGD().SetFloat("_LoopCount", this.CCIENBFIKKH);
			this.OGMEGHKECAH().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1530f, 1374f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006204 RID: 25092 RVA: 0x001DC7C7 File Offset: 0x001DA9C7
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find("EndlessLoopsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006205 RID: 25093 RVA: 0x001DC7EB File Offset: 0x001DA9EB
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("SetRoomStartTimestamp");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006206 RID: 25094 RVA: 0x001DC80F File Offset: 0x001DAA0F
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006207 RID: 25095 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06006208 RID: 25096 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06006209 RID: 25097 RVA: 0x001DC848 File Offset: 0x001DAA48
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 641f)
			{
				this.HBJJOCHGOPH = 1909f;
			}
			this.FLOHGDECHHH().SetFloat("CameraFilterPack/Distortion_ShockWaveManual", this.HBJJOCHGOPH);
			this.PEIMCBBHLBJ().SetFloat("Set Satellite Trail Length", this.Value);
			this.NJDIODJNGGA().SetFloat(".png", this.Value2);
			this.ENKPNJMPDEB().SetFloat("CameraFilterPack/TV_ARCADE", this.Intensity);
			this.OGMEGHKECAH().SetFloat("_NoiseTex", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("Fade", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 605f, 1671f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600620A RID: 25098 RVA: 0x001DC947 File Offset: 0x001DAB47
	private Material ENKPNJMPDEB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600620B RID: 25099 RVA: 0x001DB023 File Offset: 0x001D9223
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600620C RID: 25100 RVA: 0x001DB023 File Offset: 0x001D9223
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600620D RID: 25101 RVA: 0x001DB023 File Offset: 0x001D9223
	private void GNPDGBNDCPL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600620E RID: 25102 RVA: 0x001DC97E File Offset: 0x001DAB7E
	private void EIMNPCMHJLJ()
	{
		this.SCShader = Shader.Find("settings.disablestoryboard");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600620F RID: 25103 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLDHEJIEDHO()
	{
	}

	// Token: 0x06006210 RID: 25104 RVA: 0x001DB023 File Offset: 0x001D9223
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006211 RID: 25105 RVA: 0x001DC9A4 File Offset: 0x001DABA4
	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 312f)
			{
				this.HBJJOCHGOPH = 408f;
			}
			this.OGMEGHKECAH().SetFloat("VIGNETTE_DESAT", this.HBJJOCHGOPH);
			this.NJDIODJNGGA().SetFloat("_MainTex2", this.Value);
			this.NDMPCDHADMJ().SetFloat("skin.", this.Value2);
			this.HKIMAANBGMJ().SetFloat("finished", this.Intensity);
			this.IIJMIPBMMBF().SetFloat("_Wavy", this.CCIENBFIKKH);
			this.IIJMIPBMMBF().SetVector("inventory.selected.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1505f, 1151f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006212 RID: 25106 RVA: 0x001DCAA3 File Offset: 0x001DACA3
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006213 RID: 25107 RVA: 0x001DCADC File Offset: 0x001DACDC
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 354f)
			{
				this.HBJJOCHGOPH = 1765f;
			}
			this.LMLENGFLEBD().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("_BlurRadius4", this.Value);
			this.BAGICADFBAB().SetFloat("Reading preview file failed! Make sure JSON file is filled properly and/or file exists: \"{0}\"", this.Value2);
			this.BAGICADFBAB().SetFloat("SpectateButton", this.Intensity);
			this.ENKPNJMPDEB().SetFloat("_TimeX", this.CCIENBFIKKH);
			this.HKHBBBFLGJH().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1901f, 298f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006214 RID: 25108 RVA: 0x0002523B File Offset: 0x0002343B
	private void COMNAPAAPDO()
	{
	}

	// Token: 0x06006215 RID: 25109 RVA: 0x001DCBDC File Offset: 0x001DADDC
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 963f)
			{
				this.HBJJOCHGOPH = 1556f;
			}
			this.IIJMIPBMMBF().SetFloat("hand", this.HBJJOCHGOPH);
			this.LMLENGFLEBD().SetFloat("CameraFilterPack/Blend2Camera_Darken", this.Value);
			this.LMLENGFLEBD().SetFloat("MapFolderInputField", this.Value2);
			this.HKIMAANBGMJ().SetFloat("_ScreenResolution", this.Intensity);
			this.LNLKMDPHDCC().SetFloat("Texture2", this.CCIENBFIKKH);
			this.HKIMAANBGMJ().SetVector(" This is not possible to be called for standalone input. Please check your platform and code where this is called", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 166f, 487f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006216 RID: 25110 RVA: 0x001DCCDC File Offset: 0x001DAEDC
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1730f)
			{
				this.HBJJOCHGOPH = 367f;
			}
			this.BAGICADFBAB().SetFloat("_EdgeSize", this.HBJJOCHGOPH);
			this.LMLENGFLEBD().SetFloat("_ScreenResolution", this.Value);
			this.NJDIODJNGGA().SetFloat("[ResourcesManager] Unloading data resources", this.Value2);
			this.KGOLDDBHIFN().SetFloat("score:", this.Intensity);
			this.FKEOGPDLBDD().SetFloat("Text", this.CCIENBFIKKH);
			this.OGMEGHKECAH().SetVector("mapselector.tags.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 755f, 921f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006217 RID: 25111 RVA: 0x001DCDDB File Offset: 0x001DAFDB
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006218 RID: 25112 RVA: 0x001DCE12 File Offset: 0x001DB012
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("_FrustumCornersWS");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006219 RID: 25113 RVA: 0x001DCE36 File Offset: 0x001DB036
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("</color>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600621A RID: 25114 RVA: 0x001DCE5A File Offset: 0x001DB05A
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)72;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600621B RID: 25115 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600621C RID: 25116 RVA: 0x001DCE91 File Offset: 0x001DB091
	private void KHIGHFJKPFG()
	{
		this.SCShader = Shader.Find("#,0.00");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600621D RID: 25117 RVA: 0x001DB023 File Offset: 0x001D9223
	private void HLHJBJGEEEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600621E RID: 25118 RVA: 0x001DCEB5 File Offset: 0x001DB0B5
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("_TapLowBackground");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600621F RID: 25119 RVA: 0x001DB023 File Offset: 0x001D9223
	private void CNPINCHINJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006220 RID: 25120 RVA: 0x001DB023 File Offset: 0x001D9223
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006221 RID: 25121 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x06006222 RID: 25122 RVA: 0x001DCED9 File Offset: 0x001DB0D9
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006223 RID: 25123 RVA: 0x001DB023 File Offset: 0x001D9223
	private void HOMNAHDDNHJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006224 RID: 25124 RVA: 0x001DB023 File Offset: 0x001D9223
	private void ALJEADNKJPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006225 RID: 25125 RVA: 0x001DCEFD File Offset: 0x001DB0FD
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006226 RID: 25126 RVA: 0x001DCF34 File Offset: 0x001DB134
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006227 RID: 25127 RVA: 0x001DCF6B File Offset: 0x001DB16B
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("CameraFilterPack_TV_HorrorFX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006228 RID: 25128 RVA: 0x001DCF8F File Offset: 0x001DB18F
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006229 RID: 25129 RVA: 0x001DCFC6 File Offset: 0x001DB1C6
	private Material HKIMAANBGMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600622A RID: 25130 RVA: 0x001DD000 File Offset: 0x001DB200
	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1196f)
			{
				this.HBJJOCHGOPH = 1958f;
			}
			this.BAGICADFBAB().SetFloat("_BorderColor", this.HBJJOCHGOPH);
			this.HKIMAANBGMJ().SetFloat("LoadingStatusText", this.Value);
			this.FKEOGPDLBDD().SetFloat(".sav", this.Value2);
			this.PEIMCBBHLBJ().SetFloat("_Value1", this.Intensity);
			this.LMLENGFLEBD().SetFloat("Set Sun MaxSize", this.CCIENBFIKKH);
			this.KEMJNOMIPHN().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1937f, 728f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600622B RID: 25131 RVA: 0x001DD100 File Offset: 0x001DB300
	private void IJMAPHMBFJI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 282f)
			{
				this.HBJJOCHGOPH = 157f;
			}
			this.HCGJCMDJPGD().SetFloat("Dec", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("skin.", this.Value);
			this.HKIMAANBGMJ().SetFloat("LevelNameInputField", this.Value2);
			this.KGOLDDBHIFN().SetFloat("#turnoninternet", this.Intensity);
			this.NMDBCDFPGOK().SetFloat(" SecondsBeforeRespawn: ", this.CCIENBFIKKH);
			this.OIIDAKBILMI().SetVector("_History2Weight", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1800f, 1758f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ENKPNJMPDEB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600622C RID: 25132 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBPCODPOJAH()
	{
	}

	// Token: 0x0600622D RID: 25133 RVA: 0x001DD1FF File Offset: 0x001DB3FF
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600622E RID: 25134 RVA: 0x001DD238 File Offset: 0x001DB438
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1541f)
			{
				this.HBJJOCHGOPH = 647f;
			}
			this.HKIMAANBGMJ().SetFloat("[ItemsHandler] All in-game items loaded", this.HBJJOCHGOPH);
			this.CECICEGFHKL().SetFloat(" but this PhotonView does not exist! View was/is ours.", this.Value);
			this.PEIMCBBHLBJ().SetFloat("ShineEffect", this.Value2);
			this.CECICEGFHKL().SetFloat("_Saturation", this.Intensity);
			this.BAGICADFBAB().SetFloat("settings.disablestoryboard", this.CCIENBFIKKH);
			this.NJDIODJNGGA().SetVector("UseFinalGlassColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1350f, 466f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECICEGFHKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600622F RID: 25135 RVA: 0x001DD338 File Offset: 0x001DB538
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1085f)
			{
				this.HBJJOCHGOPH = 1468f;
			}
			this.OGMEGHKECAH().SetFloat("workshop.", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Vision_Warp2", this.Value);
			this.ENKPNJMPDEB().SetFloat("BadgeText", this.Value2);
			this.NDMPCDHADMJ().SetFloat("???", this.Intensity);
			this.HEINDEMCGIK().SetFloat("maps.", this.CCIENBFIKKH);
			this.GKILCDHJFEG().SetVector("ItemTemplate", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 437f, 1215f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006230 RID: 25136 RVA: 0x001DD438 File Offset: 0x001DB638
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1328f)
			{
				this.HBJJOCHGOPH = 1759f;
			}
			this.CECICEGFHKL().SetFloat("STOP [R]", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("LevelInfoInputField", this.Value);
			this.FLOHGDECHHH().SetFloat("#91CCFF", this.Value2);
			this.LMLENGFLEBD().SetFloat("Source: ", this.Intensity);
			this.NDMPCDHADMJ().SetFloat("\"", this.CCIENBFIKKH);
			this.NDMPCDHADMJ().SetVector("settings.enablehitsoundsinrelax", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1133f, 731f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006231 RID: 25137 RVA: 0x001DB023 File Offset: 0x001D9223
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006232 RID: 25138 RVA: 0x001DD537 File Offset: 0x001DB737
	private void IGPCNCJIEOJ()
	{
		this.SCShader = Shader.Find("[MapsStats] Map ID: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006233 RID: 25139 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x040009E1 RID: 2529
	public Shader SCShader;

	// Token: 0x040009E2 RID: 2530
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040009E3 RID: 2531
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040009E4 RID: 2532
	private Material BJFKDHHMLJH;

	// Token: 0x040009E5 RID: 2533
	[Range(-2f, 2f)]
	public float Value = 0.6f;

	// Token: 0x040009E6 RID: 2534
	[Range(-2f, 2f)]
	public float Value2 = 0.2f;

	// Token: 0x040009E7 RID: 2535
	[Range(0f, 60f)]
	public float Intensity = 15f;

	// Token: 0x040009E8 RID: 2536
	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;
}
