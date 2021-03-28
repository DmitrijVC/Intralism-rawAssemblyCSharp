using System;
using UnityEngine;

// Token: 0x0200003D RID: 61
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/ColorDodge")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_ColorDodge : MonoBehaviour
{
	// Token: 0x06001082 RID: 4226 RVA: 0x0007186C File Offset: 0x0006FA6C
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1169f)
			{
				this.HBJJOCHGOPH = 276f;
			}
			if (this.Camera2 != null)
			{
				this.KEMJNOMIPHN().SetTexture("SetSunLerpSpeed", this.JDMCFBKJHDD);
			}
			this.PDEAHJPOMEF().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("MusicFileSelector", this.BlendFX);
			this.ADBKPGFMNKO().SetFloat("_InvRenderTargetSize", this.SwitchCameraToCamera2);
			this.LDNADDJMIPK().SetVector("\r", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1076f, 324f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001083 RID: 4227 RVA: 0x00071968 File Offset: 0x0006FB68
	private void DPLLKHHLDBB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 12);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001084 RID: 4228 RVA: 0x000719D1 File Offset: 0x0006FBD1
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-85);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001085 RID: 4229 RVA: 0x00071A08 File Offset: 0x0006FC08
	private void HGALNAGDJIM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 93);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001086 RID: 4230 RVA: 0x00071A43 File Offset: 0x0006FC43
	private void OEAMLMGNFFC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 117);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001087 RID: 4231 RVA: 0x00071A7E File Offset: 0x0006FC7E
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001088 RID: 4232 RVA: 0x00071AB5 File Offset: 0x0006FCB5
	private void LONLHFLPEJD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -78);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001089 RID: 4233 RVA: 0x00071AF0 File Offset: 0x0006FCF0
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("_MainTex2", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600108A RID: 4234 RVA: 0x00071BEA File Offset: 0x0006FDEA
	private void CNFJDPMLECD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -9);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600108B RID: 4235 RVA: 0x00071C28 File Offset: 0x0006FE28
	private void JOHOFNKJDEB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -110);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600108C RID: 4236 RVA: 0x00071C91 File Offset: 0x0006FE91
	private void IIKCMDMMJJI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 36);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600108D RID: 4237 RVA: 0x00071CCC File Offset: 0x0006FECC
	private Material JCPDCGIJKJD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600108E RID: 4238 RVA: 0x00071D04 File Offset: 0x0006FF04
	private void FIKNBPAIFBI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 377f)
			{
				this.HBJJOCHGOPH = 842f;
			}
			if (this.Camera2 != null)
			{
				this.KGOLDDBHIFN().SetTexture("The region arrays from Name Server are not ok. Must be non-null and same length. ", this.JDMCFBKJHDD);
			}
			this.LELKBCALFCF().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.GJHPODJOBHL().SetFloat("LoadingStatusText", this.BlendFX);
			this.KGOLDDBHIFN().SetFloat("skin.", this.SwitchCameraToCamera2);
			this.KJMECMIGJJA().SetVector("HelpMenu", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1266f, 462f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600108F RID: 4239 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x06001090 RID: 4240 RVA: 0x00071DFE File Offset: 0x0006FFFE
	private void BBDONIDNGOE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -3);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001091 RID: 4241 RVA: 0x00071E39 File Offset: 0x00070039
	private void GLGGNBOBFKE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -18);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001092 RID: 4242 RVA: 0x00071E74 File Offset: 0x00070074
	private void MIAMLFNACAI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -81);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x17000024 RID: 36
	// (get) Token: 0x06001093 RID: 4243 RVA: 0x00071EAF File Offset: 0x000700AF
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

	// Token: 0x06001094 RID: 4244 RVA: 0x00071EE6 File Offset: 0x000700E6
	private Material HJGEHJDMCGI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001095 RID: 4245 RVA: 0x00071F1D File Offset: 0x0007011D
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001096 RID: 4246 RVA: 0x00071F54 File Offset: 0x00070154
	private void HPFOFGJPNCI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 42);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001097 RID: 4247 RVA: 0x00071FBD File Offset: 0x000701BD
	private Material EFMCNLELMDO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001098 RID: 4248 RVA: 0x00071FF4 File Offset: 0x000701F4
	private void ANKALNDLHEL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -15);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001099 RID: 4249 RVA: 0x00072030 File Offset: 0x00070230
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 745f)
			{
				this.HBJJOCHGOPH = 1081f;
			}
			if (this.Camera2 != null)
			{
				this.KJMECMIGJJA().SetTexture("_ExtraColor", this.JDMCFBKJHDD);
			}
			this.CFEDGDGBCHE().SetFloat(":", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("_BlurredColor", this.BlendFX);
			this.KHCLIAMBBNC().SetFloat("_Value2", this.SwitchCameraToCamera2);
			this.HJGEHJDMCGI().SetVector("_Color_G", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 980f, 1222f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600109A RID: 4250 RVA: 0x0007212A File Offset: 0x0007032A
	private void LHGFCBDACBM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 54);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600109B RID: 4251 RVA: 0x00072165 File Offset: 0x00070365
	private void KDCLNBBODBO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 20);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600109C RID: 4252 RVA: 0x000721A0 File Offset: 0x000703A0
	private void FKDEEJFNNJC()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600109D RID: 4253 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x0600109E RID: 4254 RVA: 0x000721A0 File Offset: 0x000703A0
	private void CCPEDDLAMIB()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600109F RID: 4255 RVA: 0x000721DC File Offset: 0x000703DC
	private void CFFCLAHMBAA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 7);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060010A0 RID: 4256 RVA: 0x00072248 File Offset: 0x00070448
	private void FEHCNJLLJMP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -20);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060010A1 RID: 4257 RVA: 0x000721A0 File Offset: 0x000703A0
	private void LBPHCAMMAPB()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060010A2 RID: 4258 RVA: 0x000722B1 File Offset: 0x000704B1
	private Material LELKBCALFCF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060010A3 RID: 4259 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x060010A4 RID: 4260 RVA: 0x000721A0 File Offset: 0x000703A0
	private void CMIBEOJGAIL()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060010A5 RID: 4261 RVA: 0x000721A0 File Offset: 0x000703A0
	private void MKFLBEGJJDC()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060010A6 RID: 4262 RVA: 0x000722E8 File Offset: 0x000704E8
	private void IGPCNCJIEOJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -109);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060010A7 RID: 4263 RVA: 0x00072351 File Offset: 0x00070551
	private void MLEAHDDGEMJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 66);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060010A8 RID: 4264 RVA: 0x0007238C File Offset: 0x0007058C
	private void IBLGHLNNAHN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -120);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060010A9 RID: 4265 RVA: 0x000721A0 File Offset: 0x000703A0
	private void OOGIHDLBBLM()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060010AA RID: 4266 RVA: 0x0002523B File Offset: 0x0002343B
	private void MDCFIHDPLIG()
	{
	}

	// Token: 0x060010AC RID: 4268 RVA: 0x0007241E File Offset: 0x0007061E
	private Material KHCLIAMBBNC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060010AD RID: 4269 RVA: 0x00072458 File Offset: 0x00070658
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 824f)
			{
				this.HBJJOCHGOPH = 1625f;
			}
			if (this.Camera2 != null)
			{
				this.EFMCNLELMDO().SetTexture("_Value", this.JDMCFBKJHDD);
			}
			this.HNICHJCGJOC().SetFloat("</color>", this.HBJJOCHGOPH);
			this.JCPDCGIJKJD().SetFloat("menu.resetlevelcheckpoint", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat(" | ", this.SwitchCameraToCamera2);
			this.HNICHJCGJOC().SetVector(".highscore", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 57f, 1148f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060010AE RID: 4270 RVA: 0x00072552 File Offset: 0x00070752
	private void HPFBICIECGP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -85);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060010AF RID: 4271 RVA: 0x00072590 File Offset: 0x00070790
	private void NBGIMIDICKE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 40);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060010B0 RID: 4272 RVA: 0x000725FC File Offset: 0x000707FC
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 754f)
			{
				this.HBJJOCHGOPH = 777f;
			}
			if (this.Camera2 != null)
			{
				this.KEMJNOMIPHN().SetTexture("_TimeX", this.JDMCFBKJHDD);
			}
			this.HJGEHJDMCGI().SetFloat("value", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat(" Also make sure to disable sprite packing for this sprite.", this.BlendFX);
			this.EFMCNLELMDO().SetFloat("_TimeX", this.SwitchCameraToCamera2);
			this.LELKBCALFCF().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1963f, 163f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060010B1 RID: 4273 RVA: 0x000726F8 File Offset: 0x000708F8
	private void CGDMLHLJIDK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -121);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060010B2 RID: 4274 RVA: 0x00072761 File Offset: 0x00070961
	private void AJENCHHLHKF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 79);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060010B3 RID: 4275 RVA: 0x0007279C File Offset: 0x0007099C
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060010B4 RID: 4276 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x060010B5 RID: 4277 RVA: 0x000727D4 File Offset: 0x000709D4
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1109f)
			{
				this.HBJJOCHGOPH = 489f;
			}
			if (this.Camera2 != null)
			{
				this.GJHPODJOBHL().SetTexture("#close", this.JDMCFBKJHDD);
			}
			this.LDNADDJMIPK().SetFloat("[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("13", this.BlendFX);
			this.LDNADDJMIPK().SetFloat("_AlphaMask", this.SwitchCameraToCamera2);
			this.GJHPODJOBHL().SetVector("R:", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 196f, 117f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060010B6 RID: 4278 RVA: 0x000728D0 File Offset: 0x00070AD0
	private void DFFKKLAPHCC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -57);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060010B7 RID: 4279 RVA: 0x000721A0 File Offset: 0x000703A0
	private void IEFMONDKKJN()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060010B8 RID: 4280 RVA: 0x000721A0 File Offset: 0x000703A0
	private void LOMDIOLNFHI()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060010B9 RID: 4281 RVA: 0x0007293C File Offset: 0x00070B3C
	private void ALJEJJCIMJN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 32);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060010BA RID: 4282 RVA: 0x000721A0 File Offset: 0x000703A0
	private void GPHPJIDGEPI()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060010BB RID: 4283 RVA: 0x000729A5 File Offset: 0x00070BA5
	private void LAGFLMMAGIO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -120);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060010BC RID: 4284 RVA: 0x000729E0 File Offset: 0x00070BE0
	private void NMNAEPIDENM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 11);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060010BD RID: 4285 RVA: 0x00072A1C File Offset: 0x00070C1C
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1941f)
			{
				this.HBJJOCHGOPH = 1656f;
			}
			if (this.Camera2 != null)
			{
				this.CFEDGDGBCHE().SetTexture("#tryagain", this.JDMCFBKJHDD);
			}
			this.HJGEHJDMCGI().SetFloat("_Value", this.HBJJOCHGOPH);
			this.ELBMIEOIABA().SetFloat("_Value6", this.BlendFX);
			this.ADBKPGFMNKO().SetFloat(" | ", this.SwitchCameraToCamera2);
			this.HNICHJCGJOC().SetVector("[Steamworks.NET] DllCheck Test returned false, One or more of the Steamworks binaries seems to be the wrong version.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 269f, 761f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060010BE RID: 4286 RVA: 0x00072B18 File Offset: 0x00070D18
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1306f)
			{
				this.HBJJOCHGOPH = 1780f;
			}
			if (this.Camera2 != null)
			{
				this.JCPDCGIJKJD().SetTexture("GridDataArcs", this.JDMCFBKJHDD);
			}
			this.KGOLDDBHIFN().SetFloat("CameraFilterPack/Colors_Adjust_FullColors", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("\n", this.BlendFX);
			this.LDNADDJMIPK().SetFloat("[PlayerController] ", this.SwitchCameraToCamera2);
			this.ELBMIEOIABA().SetVector("DifficultyBG", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 160f, 1005f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060010BF RID: 4287 RVA: 0x00072C14 File Offset: 0x00070E14
	private void HNMIAKKBMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 739f)
			{
				this.HBJJOCHGOPH = 630f;
			}
			if (this.Camera2 != null)
			{
				this.ADBKPGFMNKO().SetTexture("_ScratchOffsetScale", this.JDMCFBKJHDD);
			}
			this.JFDGLLEOPGB().SetFloat("StartButton", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("ItemNameBGImage", this.BlendFX);
			this.KGOLDDBHIFN().SetFloat(".lastCheckpoint.lives", this.SwitchCameraToCamera2);
			this.LDNADDJMIPK().SetVector("LostLive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 259f, 797f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060010C0 RID: 4288 RVA: 0x00072D10 File Offset: 0x00070F10
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1414f)
			{
				this.HBJJOCHGOPH = 920f;
			}
			if (this.Camera2 != null)
			{
				this.KJMECMIGJJA().SetTexture("Ignored PU RPC, cause item is inactive. ", this.JDMCFBKJHDD);
			}
			this.PDEAHJPOMEF().SetFloat("MenuScene", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("time", this.BlendFX);
			this.CFEDGDGBCHE().SetFloat(".sav", this.SwitchCameraToCamera2);
			this.HNICHJCGJOC().SetVector("<b>[", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 241f, 1489f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060010C1 RID: 4289 RVA: 0x00072E0C File Offset: 0x0007100C
	private void FJNCHGLIEMA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -90);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060010C2 RID: 4290 RVA: 0x00072E78 File Offset: 0x00071078
	private void NNFMIAFHMJM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -2);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060010C3 RID: 4291 RVA: 0x00072EE4 File Offset: 0x000710E4
	private void LBAJLLFMMMP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 119);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060010C4 RID: 4292 RVA: 0x00072F4D File Offset: 0x0007114D
	private void ENDDDMALLBK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 48);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060010C5 RID: 4293 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x060010C6 RID: 4294 RVA: 0x00072F88 File Offset: 0x00071188
	private Material GJHPODJOBHL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-86);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060010C7 RID: 4295 RVA: 0x000721A0 File Offset: 0x000703A0
	private void HAHJJPLPOKB()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060010C8 RID: 4296 RVA: 0x00072FBF File Offset: 0x000711BF
	private void EPALOMHECJM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 0);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060010C9 RID: 4297 RVA: 0x000721A0 File Offset: 0x000703A0
	private void PHJLHCMCCKE()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060010CA RID: 4298 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x060010CB RID: 4299 RVA: 0x00072FFA File Offset: 0x000711FA
	private Material ELBMIEOIABA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060010CC RID: 4300 RVA: 0x00073031 File Offset: 0x00071231
	private void BLDMINMDHPA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 45);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060010CD RID: 4301 RVA: 0x0007306C File Offset: 0x0007126C
	private void EBBOJPEPDCN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 127);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060010CE RID: 4302 RVA: 0x000730A8 File Offset: 0x000712A8
	private void HAAFIECGECG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 897f)
			{
				this.HBJJOCHGOPH = 833f;
			}
			if (this.Camera2 != null)
			{
				this.LPDOGGFOBDH().SetTexture("Adding player twice: ", this.JDMCFBKJHDD);
			}
			this.GJHPODJOBHL().SetFloat("\nCreated by Oxy949", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("...", this.BlendFX);
			this.GJHPODJOBHL().SetFloat("_Value3", this.SwitchCameraToCamera2);
			this.CFEDGDGBCHE().SetVector("PUNCloudBestRegion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 501f, 1024f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060010CF RID: 4303 RVA: 0x000731A2 File Offset: 0x000713A2
	private void ELJEHKEHFLM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -32);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060010D0 RID: 4304 RVA: 0x000731DD File Offset: 0x000713DD
	private void BDCABNEJFCE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 122);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060010D1 RID: 4305 RVA: 0x00073218 File Offset: 0x00071418
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-82);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060010D2 RID: 4306 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCDLIKEDMCF()
	{
	}

	// Token: 0x060010D3 RID: 4307 RVA: 0x000721A0 File Offset: 0x000703A0
	private void NDDNJNCINDA()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060010D4 RID: 4308 RVA: 0x0002523B File Offset: 0x0002343B
	private void EIDKCANPHJE()
	{
	}

	// Token: 0x060010D5 RID: 4309 RVA: 0x00073250 File Offset: 0x00071450
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 238f)
			{
				this.HBJJOCHGOPH = 28f;
			}
			if (this.Camera2 != null)
			{
				this.KHCLIAMBBNC().SetTexture(" - GameWebCallback] - ", this.JDMCFBKJHDD);
			}
			this.KEMJNOMIPHN().SetFloat("OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("\" call.", this.BlendFX);
			this.KGOLDDBHIFN().SetFloat("_TempTexture", this.SwitchCameraToCamera2);
			this.ADBKPGFMNKO().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1291f, 1902f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060010D6 RID: 4310 RVA: 0x0007334C File Offset: 0x0007154C
	private void Start()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060010D7 RID: 4311 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x060010D8 RID: 4312 RVA: 0x000733B8 File Offset: 0x000715B8
	private void JMEOGJHCONJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 104);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060010D9 RID: 4313 RVA: 0x00073421 File Offset: 0x00071621
	private void IFBPAGFGDGD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 81);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060010DA RID: 4314 RVA: 0x0007345C File Offset: 0x0007165C
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060010DB RID: 4315 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIPBNBKNICE()
	{
	}

	// Token: 0x060010DC RID: 4316 RVA: 0x00073493 File Offset: 0x00071693
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-126);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060010DD RID: 4317 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x060010DE RID: 4318 RVA: 0x000734CA File Offset: 0x000716CA
	private void KDMPELCOJCD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 38);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060010DF RID: 4319 RVA: 0x00073505 File Offset: 0x00071705
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060010E0 RID: 4320 RVA: 0x0007353C File Offset: 0x0007173C
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 716f)
			{
				this.HBJJOCHGOPH = 1554f;
			}
			if (this.Camera2 != null)
			{
				this.KHCLIAMBBNC().SetTexture("_TimeX", this.JDMCFBKJHDD);
			}
			this.LPDOGGFOBDH().SetFloat("MapEnd", this.HBJJOCHGOPH);
			this.KHCLIAMBBNC().SetFloat("Set satellite emission (glow)", this.BlendFX);
			this.ELBMIEOIABA().SetFloat("DPADHOR", this.SwitchCameraToCamera2);
			this.PDEAHJPOMEF().SetVector("grid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 498f, 1050f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060010E1 RID: 4321 RVA: 0x00073638 File Offset: 0x00071838
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1083f)
			{
				this.HBJJOCHGOPH = 1371f;
			}
			if (this.Camera2 != null)
			{
				this.KEMJNOMIPHN().SetTexture("yyyy-MM-dd HH:mm:ss", this.JDMCFBKJHDD);
			}
			this.LDNADDJMIPK().SetFloat("EditMenu", this.HBJJOCHGOPH);
			this.ELBMIEOIABA().SetFloat("_TimeX", this.BlendFX);
			this.JFDGLLEOPGB().SetFloat("CameraFilterPack/EXTRA_Rotation", this.SwitchCameraToCamera2);
			this.CFEDGDGBCHE().SetVector("Joystick1Button4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1035f, 1110f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060010E2 RID: 4322 RVA: 0x0002523B File Offset: 0x0002343B
	private void BFGIMALGMAJ()
	{
	}

	// Token: 0x060010E3 RID: 4323 RVA: 0x00073732 File Offset: 0x00071932
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060010E4 RID: 4324 RVA: 0x0007376D File Offset: 0x0007196D
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060010E5 RID: 4325 RVA: 0x000737A4 File Offset: 0x000719A4
	private void MGMLGCNLMKN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 32);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060010E6 RID: 4326 RVA: 0x000737E0 File Offset: 0x000719E0
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 728f)
			{
				this.HBJJOCHGOPH = 1952f;
			}
			if (this.Camera2 != null)
			{
				this.JFDGLLEOPGB().SetTexture("Rap", this.JDMCFBKJHDD);
			}
			this.GJHPODJOBHL().SetFloat("CameraFilterPack/TV_50", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("_Value4", this.BlendFX);
			this.ELBMIEOIABA().SetFloat("Tab2Content", this.SwitchCameraToCamera2);
			this.GJHPODJOBHL().SetVector("id", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 430f, 1133f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060010E7 RID: 4327 RVA: 0x0002523B File Offset: 0x0002343B
	private void KDJEJBBDILE()
	{
	}

	// Token: 0x060010E8 RID: 4328 RVA: 0x000738DC File Offset: 0x00071ADC
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 251f)
			{
				this.HBJJOCHGOPH = 822f;
			}
			if (this.Camera2 != null)
			{
				this.GJHPODJOBHL().SetTexture("MultiplayerButton", this.JDMCFBKJHDD);
			}
			this.GJHPODJOBHL().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("Keypad", this.BlendFX);
			this.ELBMIEOIABA().SetFloat("Set Satellite Color", this.SwitchCameraToCamera2);
			this.JCPDCGIJKJD().SetVector("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1742f, 1950f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060010E9 RID: 4329 RVA: 0x000739D6 File Offset: 0x00071BD6
	private void POIFMMFPELA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -2);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060010EA RID: 4330 RVA: 0x00073A11 File Offset: 0x00071C11
	private void PMOMPBFKOAM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -117);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060010EB RID: 4331 RVA: 0x00073A4C File Offset: 0x00071C4C
	private void HMKJFPBFOFI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -123);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060010EC RID: 4332 RVA: 0x00073A88 File Offset: 0x00071C88
	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 596f)
			{
				this.HBJJOCHGOPH = 1199f;
			}
			if (this.Camera2 != null)
			{
				this.KEMJNOMIPHN().SetTexture("CameraFilterPack/Distortion_FishEye", this.JDMCFBKJHDD);
			}
			this.EFMCNLELMDO().SetFloat("_FixDistance", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("Joystick1Button3", this.BlendFX);
			this.HJGEHJDMCGI().SetFloat(". Not Destroying GameObject or PhotonViews!", this.SwitchCameraToCamera2);
			this.JFDGLLEOPGB().SetVector("Edited unlock conditions", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 262f, 1702f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JCPDCGIJKJD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060010ED RID: 4333 RVA: 0x000721A0 File Offset: 0x000703A0
	private void EDCMIPNCPLB()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060010EE RID: 4334 RVA: 0x00073B82 File Offset: 0x00071D82
	private void PMBOBIDNJCN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -13);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060010EF RID: 4335 RVA: 0x00073732 File Offset: 0x00071932
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060010F0 RID: 4336 RVA: 0x00073BBD File Offset: 0x00071DBD
	private void AAPKKMKDOFO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -88);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060010F1 RID: 4337 RVA: 0x00073BF8 File Offset: 0x00071DF8
	private void AEMGPJDJGBJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -126);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060010F2 RID: 4338 RVA: 0x0002523B File Offset: 0x0002343B
	private void COMNAPAAPDO()
	{
	}

	// Token: 0x060010F3 RID: 4339 RVA: 0x000721A0 File Offset: 0x000703A0
	private void HONBLGFDMLL()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060010F4 RID: 4340 RVA: 0x00073C61 File Offset: 0x00071E61
	private void PMAADPNNHKK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -55);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060010F5 RID: 4341 RVA: 0x00073C9C File Offset: 0x00071E9C
	private void KLILJHJNICK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 72);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060010F6 RID: 4342 RVA: 0x000721A0 File Offset: 0x000703A0
	private void OnDisable()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060010F7 RID: 4343 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x060010F8 RID: 4344 RVA: 0x00073D05 File Offset: 0x00071F05
	private void JKMLIADBEOB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 1);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060010F9 RID: 4345 RVA: 0x00073D40 File Offset: 0x00071F40
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-66);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060010FA RID: 4346 RVA: 0x000721A0 File Offset: 0x000703A0
	private void BNLENEDAHHL()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060010FB RID: 4347 RVA: 0x00073D77 File Offset: 0x00071F77
	private void MEMKLOMFFJO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -56);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060010FC RID: 4348 RVA: 0x00073DB2 File Offset: 0x00071FB2
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060010FD RID: 4349 RVA: 0x00073DEC File Offset: 0x00071FEC
	private void EPEGAEGDJAM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 50);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060010FE RID: 4350 RVA: 0x00073E58 File Offset: 0x00072058
	private void LFAFJKJAEEL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 69);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060010FF RID: 4351 RVA: 0x0002523B File Offset: 0x0002343B
	private void FAKGFMFAPDG()
	{
	}

	// Token: 0x06001100 RID: 4352 RVA: 0x00073EC4 File Offset: 0x000720C4
	private void LGHCJCFHEMF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -41);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001101 RID: 4353 RVA: 0x00073F2D File Offset: 0x0007212D
	private void DJAEEDICHGD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 34);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001102 RID: 4354 RVA: 0x00073F68 File Offset: 0x00072168
	private void JHANGPCOCIG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -103);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001103 RID: 4355 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x06001104 RID: 4356 RVA: 0x00073FD1 File Offset: 0x000721D1
	private void CEIAMKKNDHM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -8);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001105 RID: 4357 RVA: 0x0007400C File Offset: 0x0007220C
	private void ECKEBMIMIGK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -110);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001106 RID: 4358 RVA: 0x00074047 File Offset: 0x00072247
	private void PDILBLLIPFJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 69);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001107 RID: 4359 RVA: 0x00074084 File Offset: 0x00072284
	private void IHAMJLJFFLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1056f)
			{
				this.HBJJOCHGOPH = 1281f;
			}
			if (this.Camera2 != null)
			{
				this.KGOLDDBHIFN().SetTexture("maps.", this.JDMCFBKJHDD);
			}
			this.EFMCNLELMDO().SetFloat("LevelConfigButton", this.HBJJOCHGOPH);
			this.ELBMIEOIABA().SetFloat("_Intensity", this.BlendFX);
			this.KEMJNOMIPHN().SetFloat("SupportLogger OnJoinedRoom(", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("Screenshots only supported in PlayMode", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 662f, 645f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001108 RID: 4360 RVA: 0x00074180 File Offset: 0x00072380
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1310f)
			{
				this.HBJJOCHGOPH = 1138f;
			}
			if (this.Camera2 != null)
			{
				this.HJGEHJDMCGI().SetTexture(" not exist", this.JDMCFBKJHDD);
			}
			this.CFEDGDGBCHE().SetFloat("curScn", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("settings.enablerankingnotifications", this.BlendFX);
			this.EFMCNLELMDO().SetFloat("_Blend", this.SwitchCameraToCamera2);
			this.KJMECMIGJJA().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 822f, 1025f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001109 RID: 4361 RVA: 0x0007427A File Offset: 0x0007247A
	private void BNJEFIBPJLO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 53);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600110A RID: 4362 RVA: 0x000742B5 File Offset: 0x000724B5
	private void OIPJFDCNEDH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -4);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600110B RID: 4363 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x0600110C RID: 4364 RVA: 0x000742F0 File Offset: 0x000724F0
	private void IBFHEDHJDLH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -37);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600110D RID: 4365 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600110E RID: 4366 RVA: 0x0007432B File Offset: 0x0007252B
	private void IJCBBIJOCAH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 40);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600110F RID: 4367 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06001110 RID: 4368 RVA: 0x000721A0 File Offset: 0x000703A0
	private void NNPBKKBFDHH()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001111 RID: 4369 RVA: 0x00074368 File Offset: 0x00072568
	private void HDMDKOKOOJC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 57);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001112 RID: 4370 RVA: 0x000743D1 File Offset: 0x000725D1
	private void GAAPMFBPJNH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -93);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0400025F RID: 607
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_ColorDodge";

	// Token: 0x04000260 RID: 608
	public Shader SCShader;

	// Token: 0x04000261 RID: 609
	public Camera Camera2;

	// Token: 0x04000262 RID: 610
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000263 RID: 611
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000264 RID: 612
	private Material BJFKDHHMLJH;

	// Token: 0x04000265 RID: 613
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x04000266 RID: 614
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x04000267 RID: 615
	private RenderTexture JDMCFBKJHDD;
}
