using System;
using UnityEngine;

// Token: 0x0200012B RID: 299
[AddComponentMenu("Camera Filter Pack/TV/WideScreenHorizontal")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_WideScreenHorizontal : MonoBehaviour
{
	// Token: 0x06005E76 RID: 24182 RVA: 0x001CC6A6 File Offset: 0x001CA8A6
	private Material GHHPOGODBHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E77 RID: 24183 RVA: 0x001CC6DD File Offset: 0x001CA8DD
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E78 RID: 24184 RVA: 0x0002523B File Offset: 0x0002343B
	private void ODCJJFBJJNF()
	{
	}

	// Token: 0x06005E79 RID: 24185 RVA: 0x001CC714 File Offset: 0x001CA914
	private void PNNPDMHLFHE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E7A RID: 24186 RVA: 0x001CC731 File Offset: 0x001CA931
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005E7B RID: 24187 RVA: 0x001CC755 File Offset: 0x001CA955
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E7C RID: 24188 RVA: 0x001CC78C File Offset: 0x001CA98C
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1825f)
			{
				this.HBJJOCHGOPH = 912f;
			}
			this.HHLFDHNEIAH().SetFloat("settings_bindings_", this.HBJJOCHGOPH);
			this.CFCPHFMKHII().SetFloat("offsets", this.Size);
			this.OHKGGPFGLFD().SetFloat("_Value", this.Smooth);
			this.NBPKMLMCHFN.SetFloat("st", this.ICABEDDNGIH);
			this.NBPKMLMCHFN.SetFloat("value", this.LHOMPJOPKHE);
			this.AELJLBOJAIL().SetVector("{0}{1}:{2}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1076f, 117f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E7D RID: 24189 RVA: 0x001CC88C File Offset: 0x001CAA8C
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1745f)
			{
				this.HBJJOCHGOPH = 1985f;
			}
			this.IGKFMCPDNOI().SetFloat("Mouse", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("_OcclusionTexture", this.Size);
			this.CFCPHFMKHII().SetFloat("Set satellite trail width", this.Smooth);
			this.GHHPOGODBHB().SetFloat("_SunThreshold", this.ICABEDDNGIH);
			this.JFDGLLEOPGB().SetFloat("Fade", this.LHOMPJOPKHE);
			this.DKNJGHFLAIF().SetVector("_Red_G", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1744f, 575f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E7E RID: 24190 RVA: 0x001CC98B File Offset: 0x001CAB8B
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("Set particless emission (glow)");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005E7F RID: 24191 RVA: 0x001CC9AF File Offset: 0x001CABAF
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E80 RID: 24192 RVA: 0x001CC714 File Offset: 0x001CA914
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E81 RID: 24193 RVA: 0x0002523B File Offset: 0x0002343B
	private void ABFNJCEBIKA()
	{
	}

	// Token: 0x06005E82 RID: 24194 RVA: 0x0002523B File Offset: 0x0002343B
	private void COGBDFKOHKK()
	{
	}

	// Token: 0x06005E83 RID: 24195 RVA: 0x001CC9E8 File Offset: 0x001CABE8
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 619f)
			{
				this.HBJJOCHGOPH = 1175f;
			}
			this.DBOLLHHMKKN().SetFloat(" not exist", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat(" item(s) in inventory", this.Size);
			this.ACHNOHCLGOO().SetFloat("CameraFilterPack/3D_Computer", this.Smooth);
			this.OHKGGPFGLFD().SetFloat(" in SaveLoadMenu.prefabDictionary!", this.ICABEDDNGIH);
			this.ACHNOHCLGOO().SetFloat("Tab1Content", this.LHOMPJOPKHE);
			this.NLFJGMBCICG().SetVector("accuracy", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1938f, 1454f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E84 RID: 24196 RVA: 0x001CCAE7 File Offset: 0x001CACE7
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("float,0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005E85 RID: 24197 RVA: 0x001CCB0C File Offset: 0x001CAD0C
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 563f)
			{
				this.HBJJOCHGOPH = 927f;
			}
			this.NBPKMLMCHFN.SetFloat("<b>Max Score</b>:", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("speed", this.Size);
			this.JFDGLLEOPGB().SetFloat("_Value4", this.Smooth);
			this.ACHNOHCLGOO().SetFloat("SpawnObj", this.ICABEDDNGIH);
			this.DBOLLHHMKKN().SetFloat("GlassColor", this.LHOMPJOPKHE);
			this.KEMAALEODNH().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1684f, 1812f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E86 RID: 24198 RVA: 0x001CCC0B File Offset: 0x001CAE0B
	private Material OHKGGPFGLFD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E87 RID: 24199 RVA: 0x001CCC42 File Offset: 0x001CAE42
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("{0:0} hour{1}, ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005E88 RID: 24200 RVA: 0x001CC714 File Offset: 0x001CA914
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E89 RID: 24201 RVA: 0x001CCC66 File Offset: 0x001CAE66
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E8A RID: 24202 RVA: 0x001CCC9D File Offset: 0x001CAE9D
	private Material HHLFDHNEIAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E8B RID: 24203 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x06005E8C RID: 24204 RVA: 0x001CCCD4 File Offset: 0x001CAED4
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E8D RID: 24205 RVA: 0x001CCD0B File Offset: 0x001CAF0B
	private void AEDDNDHCLNN()
	{
		this.SCShader = Shader.Find("SetupEncryption() got called. ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005E8E RID: 24206 RVA: 0x001CC714 File Offset: 0x001CA914
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E8F RID: 24207 RVA: 0x001CCD2F File Offset: 0x001CAF2F
	private void AKHCOBHHGJP()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_Myst");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005E90 RID: 24208 RVA: 0x001CCD54 File Offset: 0x001CAF54
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 591f)
			{
				this.HBJJOCHGOPH = 723f;
			}
			this.DKNJGHFLAIF().SetFloat("_Value", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("RateButton", this.Size);
			this.LONNIJMNKFB().SetFloat("_Value5", this.Smooth);
			this.ACHNOHCLGOO().SetFloat("y", this.ICABEDDNGIH);
			this.NFKFAAHHLLM().SetFloat("ComboScoreText", this.LHOMPJOPKHE);
			this.OHKGGPFGLFD().SetVector("SpawnObj", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1424f, 367f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E91 RID: 24209 RVA: 0x001CCE53 File Offset: 0x001CB053
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_WideScreenHorizontal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005E92 RID: 24210 RVA: 0x001CCE78 File Offset: 0x001CB078
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 493f)
			{
				this.HBJJOCHGOPH = 1435f;
			}
			this.LONNIJMNKFB().SetFloat("_Blue_R", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("_Distortion", this.Size);
			this.HFBJAOFLCJI().SetFloat("2hands", this.Smooth);
			this.KBOPGONOCNP().SetFloat("Out {0,4} | In {1,4} | Sum {2,4}", this.ICABEDDNGIH);
			this.EOCCJGIGEGJ().SetFloat("_Value", this.LHOMPJOPKHE);
			this.EOCCJGIGEGJ().SetVector("???", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 386f, 1893f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E93 RID: 24211 RVA: 0x001CCF78 File Offset: 0x001CB178
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1882f)
			{
				this.HBJJOCHGOPH = 1074f;
			}
			this.NFKFAAHHLLM().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat("[PlayerController] ", this.Size);
			this.KHCLIAMBBNC().SetFloat(" ", this.Smooth);
			this.HHLFDHNEIAH().SetFloat("[ERROR KEY {0}]", this.ICABEDDNGIH);
			this.KBOPGONOCNP().SetFloat("menu.selectedplaymode", this.LHOMPJOPKHE);
			this.AELJLBOJAIL().SetVector("DPADVER", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 335f, 766f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E94 RID: 24212 RVA: 0x001CD077 File Offset: 0x001CB277
	private Material CFCPHFMKHII()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E95 RID: 24213 RVA: 0x001CD0B0 File Offset: 0x001CB2B0
	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1136f)
			{
				this.HBJJOCHGOPH = 1601f;
			}
			this.KJMECMIGJJA().SetFloat("mapselector.lastSearch", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("_TimeX", this.Size);
			this.LONNIJMNKFB().SetFloat("[MenuScene] Error: ", this.Smooth);
			this.GHHPOGODBHB().SetFloat("_TimeX", this.ICABEDDNGIH);
			this.HFBJAOFLCJI().SetFloat("_Distortion", this.LHOMPJOPKHE);
			this.NLFJGMBCICG().SetVector("No player left to ask", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 814f, 938f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E96 RID: 24214 RVA: 0x001CC714 File Offset: 0x001CA914
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E97 RID: 24215 RVA: 0x001CD1AF File Offset: 0x001CB3AF
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find("event");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005E98 RID: 24216 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06005E99 RID: 24217 RVA: 0x001CC714 File Offset: 0x001CA914
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E9A RID: 24218 RVA: 0x001CC714 File Offset: 0x001CA914
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005E9B RID: 24219 RVA: 0x001CC731 File Offset: 0x001CA931
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005E9C RID: 24220 RVA: 0x001CD1D4 File Offset: 0x001CB3D4
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1642f)
			{
				this.HBJJOCHGOPH = 214f;
			}
			this.LPCHMEKDCHI().SetFloat("_MainTex", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("_ScreenResolution", this.Size);
			this.NBPKMLMCHFN.SetFloat("_NoiseTex", this.Smooth);
			this.FAIFBBGFAIB().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", this.ICABEDDNGIH);
			this.HFBJAOFLCJI().SetFloat(": ", this.LHOMPJOPKHE);
			this.NFKFAAHHLLM().SetVector("_BlurVector", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 8f, 921f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E9D RID: 24221 RVA: 0x001CD2D3 File Offset: 0x001CB4D3
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005E9E RID: 24222 RVA: 0x001CD30C File Offset: 0x001CB50C
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1700f)
			{
				this.HBJJOCHGOPH = 1950f;
			}
			this.CFCPHFMKHII().SetFloat("set environment id", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("AvatarImage", this.Size);
			this.FAIFBBGFAIB().SetFloat("_Vignetting2", this.Smooth);
			this.KEMAALEODNH().SetFloat("_ScreenResolution", this.ICABEDDNGIH);
			this.KEMAALEODNH().SetFloat("settings.shaders", this.LHOMPJOPKHE);
			this.EOCCJGIGEGJ().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 148f, 146f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005E9F RID: 24223 RVA: 0x001CD40B File Offset: 0x001CB60B
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005EA0 RID: 24224 RVA: 0x001CD442 File Offset: 0x001CB642
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("ViewMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005EA1 RID: 24225 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x06005EA2 RID: 24226 RVA: 0x001CD466 File Offset: 0x001CB666
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005EA3 RID: 24227 RVA: 0x001CD49D File Offset: 0x001CB69D
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005EA4 RID: 24228 RVA: 0x001CD4D4 File Offset: 0x001CB6D4
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("shader.frost");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005EA5 RID: 24229 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x06005EA6 RID: 24230 RVA: 0x001CD4F8 File Offset: 0x001CB6F8
	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 923f)
			{
				this.HBJJOCHGOPH = 1410f;
			}
			this.GHHPOGODBHB().SetFloat("CameraFilterPack_TV_BrokenGlass_2", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Called GetNumberOfCurrentPlayers()", this.Size);
			this.CFCPHFMKHII().SetFloat("Destroy(targetPhotonView) failed, cause targetPhotonView is null.", this.Smooth);
			this.ABHDNGIHBKE().SetFloat("11", this.ICABEDDNGIH);
			this.KEMJNOMIPHN().SetFloat("_NeighborMaxTex", this.LHOMPJOPKHE);
			this.HFBJAOFLCJI().SetVector("0.00", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 250f, 1976f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OHKGGPFGLFD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005EA8 RID: 24232 RVA: 0x001CD636 File Offset: 0x001CB836
	private void NKFDNIAKGEO()
	{
		this.SCShader = Shader.Find("[MapsData] Preloading ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005EA9 RID: 24233 RVA: 0x001CD65A File Offset: 0x001CB85A
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005EAA RID: 24234 RVA: 0x001CD691 File Offset: 0x001CB891
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005EAB RID: 24235 RVA: 0x001CD6B8 File Offset: 0x001CB8B8
	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1500f)
			{
				this.HBJJOCHGOPH = 283f;
			}
			this.JFDGLLEOPGB().SetFloat("[PlayerBase] Loaded environment: ", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("ConfigVersionSlider", this.Size);
			this.DONENAMLFLF().SetFloat("x", this.Smooth);
			this.NBPKMLMCHFN.SetFloat("offsets", this.ICABEDDNGIH);
			this.MMOODGIODPC().SetFloat("_MainTex2", this.LHOMPJOPKHE);
			this.DONENAMLFLF().SetVector("Tab1Content", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1610f, 1742f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005EAC RID: 24236 RVA: 0x001CD7B8 File Offset: 0x001CB9B8
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 406f)
			{
				this.HBJJOCHGOPH = 867f;
			}
			this.OHKGGPFGLFD().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat(".lastCheckpoint.currentCombo", this.Size);
			this.FAIFBBGFAIB().SetFloat("_TimeX", this.Smooth);
			this.MMOODGIODPC().SetFloat("#failed!", this.ICABEDDNGIH);
			this.KBOPGONOCNP().SetFloat("-1", this.LHOMPJOPKHE);
			this.KEMAALEODNH().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 964f, 127f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005EAD RID: 24237 RVA: 0x001CD8B7 File Offset: 0x001CBAB7
	private void DFFKKLAPHCC()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005EAE RID: 24238 RVA: 0x001CD8DB File Offset: 0x001CBADB
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005EAF RID: 24239 RVA: 0x001CD912 File Offset: 0x001CBB12
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005EB0 RID: 24240 RVA: 0x001CC714 File Offset: 0x001CA914
	private void MCKCCPLJIFE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005EB1 RID: 24241 RVA: 0x001CD949 File Offset: 0x001CBB49
	private void LGHCJCFHEMF()
	{
		this.SCShader = Shader.Find("_HueShift");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005EB2 RID: 24242 RVA: 0x001CD970 File Offset: 0x001CBB70
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1034f)
			{
				this.HBJJOCHGOPH = 659f;
			}
			this.JFDGLLEOPGB().SetFloat(" - LOCAL", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("_EmissionColor", this.Size);
			this.HFBJAOFLCJI().SetFloat("Loading inventory", this.Smooth);
			this.MMOODGIODPC().SetFloat("_ScreenResolution", this.ICABEDDNGIH);
			this.JFDGLLEOPGB().SetFloat("_ScreenResolution", this.LHOMPJOPKHE);
			this.KEMJNOMIPHN().SetVector("menu.tabid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1892f, 131f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005EB3 RID: 24243 RVA: 0x001CDA70 File Offset: 0x001CBC70
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1904f)
			{
				this.HBJJOCHGOPH = 301f;
			}
			this.DONENAMLFLF().SetFloat("...", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("arcs", this.Size);
			this.DONENAMLFLF().SetFloat("Start Color's hex value #RRGGBBAA", this.Smooth);
			this.NDMPCDHADMJ().SetFloat("Editor/", this.ICABEDDNGIH);
			this.IGKFMCPDNOI().SetFloat("CreateRoom failed, client stays on masterserver: {0}.", this.LHOMPJOPKHE);
			this.DKNJGHFLAIF().SetVector("0.00/0.00", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 328f, 802f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005EB4 RID: 24244 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06005EB5 RID: 24245 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06005EB6 RID: 24246 RVA: 0x0002523B File Offset: 0x0002343B
	private void MANDOGNJJBD()
	{
	}

	// Token: 0x06005EB7 RID: 24247 RVA: 0x001CDB70 File Offset: 0x001CBD70
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1958f)
			{
				this.HBJJOCHGOPH = 650f;
			}
			this.ACHNOHCLGOO().SetFloat("</color>", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", this.Size);
			this.KBOPGONOCNP().SetFloat("_Intensity", this.Smooth);
			this.EOCCJGIGEGJ().SetFloat("win", this.ICABEDDNGIH);
			this.DBOLLHHMKKN().SetFloat("_Size", this.LHOMPJOPKHE);
			this.MMOODGIODPC().SetVector("HostType: {0} ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1385f, 995f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005EB8 RID: 24248 RVA: 0x001CD442 File Offset: 0x001CB642
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find("ViewMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005EB9 RID: 24249 RVA: 0x001CDC6F File Offset: 0x001CBE6F
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005EBA RID: 24250 RVA: 0x001CDCA6 File Offset: 0x001CBEA6
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x17000110 RID: 272
	// (get) Token: 0x06005EBB RID: 24251 RVA: 0x001CDCDD File Offset: 0x001CBEDD
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

	// Token: 0x06005EBC RID: 24252 RVA: 0x001CDD14 File Offset: 0x001CBF14
	private void KOFAMEKHHGD()
	{
		this.SCShader = Shader.Find("event");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005EBD RID: 24253 RVA: 0x001CC714 File Offset: 0x001CA914
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005EBE RID: 24254 RVA: 0x001CC714 File Offset: 0x001CA914
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005EBF RID: 24255 RVA: 0x001CDD38 File Offset: 0x001CBF38
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Color_Contrast");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005EC0 RID: 24256 RVA: 0x001CDD5C File Offset: 0x001CBF5C
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1989f)
			{
				this.HBJJOCHGOPH = 1191f;
			}
			this.IIJMIPBMMBF().SetFloat("#failed!", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("_Distortion", this.Size);
			this.IGKFMCPDNOI().SetFloat("\n\n#", this.Smooth);
			this.KEMJNOMIPHN().SetFloat("[Down]", this.ICABEDDNGIH);
			this.DBOLLHHMKKN().SetFloat("error", this.LHOMPJOPKHE);
			this.NLFJGMBCICG().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1797f, 678f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005EC1 RID: 24257 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06005EC2 RID: 24258 RVA: 0x001CDE5C File Offset: 0x001CC05C
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
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Smooth);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.ICABEDDNGIH);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.LHOMPJOPKHE);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005EC3 RID: 24259 RVA: 0x001CDF5B File Offset: 0x001CC15B
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005EC4 RID: 24260 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06005EC5 RID: 24261 RVA: 0x001CC714 File Offset: 0x001CA914
	private void IEFMONDKKJN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005EC6 RID: 24262 RVA: 0x001CDF92 File Offset: 0x001CC192
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005EC7 RID: 24263 RVA: 0x001CDFC9 File Offset: 0x001CC1C9
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("[PlayerBase] Checkpoint error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005EC8 RID: 24264 RVA: 0x001CDFED File Offset: 0x001CC1ED
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)80;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005EC9 RID: 24265 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x06005ECA RID: 24266 RVA: 0x001CE024 File Offset: 0x001CC224
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)117;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005ECB RID: 24267 RVA: 0x001CE05B File Offset: 0x001CC25B
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005ECC RID: 24268 RVA: 0x001CE094 File Offset: 0x001CC294
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 677f)
			{
				this.HBJJOCHGOPH = 1628f;
			}
			this.KEMAALEODNH().SetFloat("_Vibrance", this.HBJJOCHGOPH);
			this.LMLENGFLEBD().SetFloat("[SoundManager] Loaded skin audio", this.Size);
			this.KJMECMIGJJA().SetFloat("HPText", this.Smooth);
			this.KEMAALEODNH().SetFloat(":\n", this.ICABEDDNGIH);
			this.HHLFDHNEIAH().SetFloat("_Fade", this.LHOMPJOPKHE);
			this.MMOODGIODPC().SetVector("#done", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 444f, 584f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005ECD RID: 24269 RVA: 0x001CE194 File Offset: 0x001CC394
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1628f)
			{
				this.HBJJOCHGOPH = 973f;
			}
			this.LMLENGFLEBD().SetFloat("y", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat("ShowSprite", this.Size);
			this.EOCCJGIGEGJ().SetFloat("Object ID. Case-Sensitive", this.Smooth);
			this.JFDGLLEOPGB().SetFloat("CameraFilterPack/BlurTiltShift_V", this.ICABEDDNGIH);
			this.CFCPHFMKHII().SetFloat("_Threshhold", this.LHOMPJOPKHE);
			this.DBOLLHHMKKN().SetVector("player.greenlifering", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 199f, 1625f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005ECE RID: 24270 RVA: 0x001CE294 File Offset: 0x001CC494
	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 959f)
			{
				this.HBJJOCHGOPH = 1199f;
			}
			this.NLFJGMBCICG().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat("/", this.Size);
			this.LONNIJMNKFB().SetFloat("CameraFilterPack/Blur_Movie", this.Smooth);
			this.ABHDNGIHBKE().SetFloat("note.3", this.ICABEDDNGIH);
			this.DONENAMLFLF().SetFloat("Fill Area", this.LHOMPJOPKHE);
			this.HHLFDHNEIAH().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1305f, 807f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005ECF RID: 24271 RVA: 0x001CC714 File Offset: 0x001CA914
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005ED0 RID: 24272 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x06005ED1 RID: 24273 RVA: 0x001CE394 File Offset: 0x001CC594
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 336f)
			{
				this.HBJJOCHGOPH = 1461f;
			}
			this.KJMECMIGJJA().SetFloat("Object ID", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("Alpha", this.Size);
			this.NLFJGMBCICG().SetFloat("Right", this.Smooth);
			this.ABHDNGIHBKE().SetFloat("_TimeX", this.ICABEDDNGIH);
			this.NLFJGMBCICG().SetFloat(".highscore", this.LHOMPJOPKHE);
			this.GHHPOGODBHB().SetVector("BlockSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1287f, 10f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005ED2 RID: 24274 RVA: 0x001CE493 File Offset: 0x001CC693
	private Material KHCLIAMBBNC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005ED3 RID: 24275 RVA: 0x001CE4CA File Offset: 0x001CC6CA
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("achievements.21.completed.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005ED4 RID: 24276 RVA: 0x001CE4EE File Offset: 0x001CC6EE
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005ED5 RID: 24277 RVA: 0x001CC714 File Offset: 0x001CA914
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005ED6 RID: 24278 RVA: 0x001CE525 File Offset: 0x001CC725
	private void FLKEJJEGCFA()
	{
		this.SCShader = Shader.Find("Command not found!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005ED7 RID: 24279 RVA: 0x001CE549 File Offset: 0x001CC749
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005ED8 RID: 24280 RVA: 0x001CE580 File Offset: 0x001CC780
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005ED9 RID: 24281 RVA: 0x001CE5B8 File Offset: 0x001CC7B8
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1067f)
			{
				this.HBJJOCHGOPH = 1782f;
			}
			this.MMOODGIODPC().SetFloat("88f00bdf0ad61b16b803971ebe071962", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("ticket", this.Size);
			this.LMLENGFLEBD().SetFloat("HiddenToggle", this.Smooth);
			this.JFDGLLEOPGB().SetFloat("_TimeX", this.ICABEDDNGIH);
			this.NFKFAAHHLLM().SetFloat("_ScreenResolution", this.LHOMPJOPKHE);
			this.CFCPHFMKHII().SetVector("https://discord.gg/intralism", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1727f, 699f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005EDA RID: 24282 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06005EDB RID: 24283 RVA: 0x001CC714 File Offset: 0x001CA914
	private void OOGIHDLBBLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005EDC RID: 24284 RVA: 0x001CE6B8 File Offset: 0x001CC8B8
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1096f)
			{
				this.HBJJOCHGOPH = 541f;
			}
			this.JFDGLLEOPGB().SetFloat("/music", this.HBJJOCHGOPH);
			this.CFCPHFMKHII().SetFloat("_Min", this.Size);
			this.EOCCJGIGEGJ().SetFloat("ItemNameText", this.Smooth);
			this.HFBJAOFLCJI().SetFloat("_Value", this.ICABEDDNGIH);
			this.GHHPOGODBHB().SetFloat("_Value3", this.LHOMPJOPKHE);
			this.KBOPGONOCNP().SetVector(",", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 774f, 477f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005EDD RID: 24285 RVA: 0x001CC714 File Offset: 0x001CA914
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005EDE RID: 24286 RVA: 0x001CE7B7 File Offset: 0x001CC9B7
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("{STEAM_CLAN_IMAGE}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005EDF RID: 24287 RVA: 0x001CC714 File Offset: 0x001CA914
	private void AMHEJBMLFNM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005EE0 RID: 24288 RVA: 0x001CE7DB File Offset: 0x001CC9DB
	private void NEFHGMNAPEP()
	{
		this.SCShader = Shader.Find("BitsData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005EE1 RID: 24289 RVA: 0x001CC731 File Offset: 0x001CA931
	private void LFAFJKJAEEL()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005EE2 RID: 24290 RVA: 0x001CE7FF File Offset: 0x001CC9FF
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find(".sawoutdatedmessage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005EE3 RID: 24291 RVA: 0x001CC714 File Offset: 0x001CA914
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005EE4 RID: 24292 RVA: 0x001CC714 File Offset: 0x001CA914
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005EE5 RID: 24293 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005EE6 RID: 24294 RVA: 0x001CE823 File Offset: 0x001CCA23
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("Result for ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005EE7 RID: 24295 RVA: 0x001CE847 File Offset: 0x001CCA47
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005EE8 RID: 24296 RVA: 0x001CE87E File Offset: 0x001CCA7E
	private void PMPKMGKAAJH()
	{
		this.SCShader = Shader.Find("Connection error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005EE9 RID: 24297 RVA: 0x001CE8A2 File Offset: 0x001CCAA2
	private void ECBILENEOOL()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x04000986 RID: 2438
	public Shader SCShader;

	// Token: 0x04000987 RID: 2439
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000988 RID: 2440
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000989 RID: 2441
	private Material BJFKDHHMLJH;

	// Token: 0x0400098A RID: 2442
	[Range(0f, 0.8f)]
	public float Size = 0.55f;

	// Token: 0x0400098B RID: 2443
	[Range(0.001f, 0.4f)]
	public float Smooth = 0.01f;

	// Token: 0x0400098C RID: 2444
	[Range(0f, 10f)]
	private float ICABEDDNGIH = 1f;

	// Token: 0x0400098D RID: 2445
	[Range(0f, 10f)]
	private float LHOMPJOPKHE = 1f;
}
