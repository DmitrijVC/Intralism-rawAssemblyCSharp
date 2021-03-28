using System;
using UnityEngine;

// Token: 0x02000065 RID: 101
[AddComponentMenu("Camera Filter Pack/Blur/Radial_Fast")]
[ExecuteInEditMode]
public class CameraFilterPack_Blur_Radial_Fast : MonoBehaviour
{
	// Token: 0x06001C19 RID: 7193 RVA: 0x000ACE17 File Offset: 0x000AB017
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C1A RID: 7194 RVA: 0x000ACE4E File Offset: 0x000AB04E
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001C1B RID: 7195 RVA: 0x000ACE74 File Offset: 0x000AB074
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1953f)
			{
				this.HBJJOCHGOPH = 820f;
			}
			this.HKIMAANBGMJ().SetFloat("Tab1Content", this.HBJJOCHGOPH);
			this.LELKBCALFCF().SetFloat("file://", this.Intensity);
			this.KBOPGONOCNP().SetFloat(".lastCheckpoint.bgcolor", this.MovX);
			this.HCGJCMDJPGD().SetFloat("Operation ", this.MovY);
			this.HCGJCMDJPGD().SetFloat("_Parameter", this.KJIKOEIAENF);
			this.BAGICADFBAB().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1182f, 277f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C1C RID: 7196 RVA: 0x000ACF73 File Offset: 0x000AB173
	private void AEDDNDHCLNN()
	{
		this.SCShader = Shader.Find("Cannot remove cached RPCs on a PhotonView thats not ours! ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001C1E RID: 7198 RVA: 0x000ACFD6 File Offset: 0x000AB1D6
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C1F RID: 7199 RVA: 0x000AD00D File Offset: 0x000AB20D
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001C20 RID: 7200 RVA: 0x0002523B File Offset: 0x0002343B
	private void ANKIJGCGCBF()
	{
	}

	// Token: 0x06001C21 RID: 7201 RVA: 0x000AD031 File Offset: 0x000AB231
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C22 RID: 7202 RVA: 0x000AD04E File Offset: 0x000AB24E
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("_GlowColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001C23 RID: 7203 RVA: 0x000AD074 File Offset: 0x000AB274
	private void HNMIAKKBMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1695f)
			{
				this.HBJJOCHGOPH = 405f;
			}
			this.NFMGLIKNOOC().SetFloat("value", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("custom", this.Intensity);
			this.BFGNMFCNDBC().SetFloat(" | Level: ", this.MovX);
			this.HKIMAANBGMJ().SetFloat("CameraFilterPack/Noise_TV_2", this.MovY);
			this.LELKBCALFCF().SetFloat("RequestSelectedLevel", this.KJIKOEIAENF);
			this.BFGNMFCNDBC().SetVector("a year ago", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 394f, 1967f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C24 RID: 7204 RVA: 0x000AD173 File Offset: 0x000AB373
	private void IGPCNCJIEOJ()
	{
		this.SCShader = Shader.Find("FileMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001C25 RID: 7205 RVA: 0x000AD031 File Offset: 0x000AB231
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C26 RID: 7206 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06001C27 RID: 7207 RVA: 0x000AD198 File Offset: 0x000AB398
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 637f)
			{
				this.HBJJOCHGOPH = 1310f;
			}
			this.OIIDAKBILMI().SetFloat("Network destroy Instantiated GO: ", this.HBJJOCHGOPH);
			this.OHKGGPFGLFD().SetFloat("StandAloneInputSystem should not be used with the GamePadInputModule, please remove it from the Event System in this scene or disable it when this module is in use", this.Intensity);
			this.HKIMAANBGMJ().SetFloat("ShineEffect", this.MovX);
			this.KBOPGONOCNP().SetFloat("SetSunSensitivity", this.MovY);
			this.HKIMAANBGMJ().SetFloat("AudioSampler", this.KJIKOEIAENF);
			this.OIIDAKBILMI().SetVector("IconImage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1180f, 1892f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C28 RID: 7208 RVA: 0x000AD031 File Offset: 0x000AB231
	private void OEIBFOHPOPD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C29 RID: 7209 RVA: 0x000AD298 File Offset: 0x000AB498
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 519f)
			{
				this.HBJJOCHGOPH = 699f;
			}
			this.OCHJIMJNEMO().SetFloat("[LevelEditorScene] Print Audio Wave: Start", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("float,2", this.Intensity);
			this.NFMGLIKNOOC().SetFloat("B", this.MovX);
			this.EOCCJGIGEGJ().SetFloat("_Parameter", this.MovY);
			this.LELKBCALFCF().SetFloat("' was created: ", this.KJIKOEIAENF);
			this.INOBFNCKFGK().SetVector("#status", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1396f, 648f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C2A RID: 7210 RVA: 0x000AD398 File Offset: 0x000AB598
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1873f)
			{
				this.HBJJOCHGOPH = 1770f;
			}
			this.IONHGBPGCHK().SetFloat("CameraFilterPack/Blend2Camera_Exclusion", this.HBJJOCHGOPH);
			this.MJJIEHANFJA().SetFloat("[LevelEditorScene] Error: You're not logged into Steam!", this.Intensity);
			this.AELJLBOJAIL().SetFloat("{0,-18} {1,18}", this.MovX);
			this.IONHGBPGCHK().SetFloat(". The RPC has been ignored.", this.MovY);
			this.AELJLBOJAIL().SetFloat("Up", this.KJIKOEIAENF);
			this.BFGNMFCNDBC().SetVector("#turnoninternet", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1888f, 1694f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C2B RID: 7211 RVA: 0x000AD498 File Offset: 0x000AB698
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1789f)
			{
				this.HBJJOCHGOPH = 183f;
			}
			this.AELJLBOJAIL().SetFloat("_VelTex", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("shader.frost", this.Intensity);
			this.MICHFGAOPKM().SetFloat("itemdefid[0]", this.MovX);
			this.FGENHBKMPDA().SetFloat("CameraFilterPack/TV_Rgb", this.MovY);
			this.MICHFGAOPKM().SetFloat("id", this.KJIKOEIAENF);
			this.NBPKMLMCHFN.SetVector("RemoveEnvironmentObject", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1309f, 330f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C2C RID: 7212 RVA: 0x000AD598 File Offset: 0x000AB798
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 541f)
			{
				this.HBJJOCHGOPH = 187f;
			}
			this.HKIMAANBGMJ().SetFloat("RecordButton", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("Beat Detected", this.Intensity);
			this.NBPKMLMCHFN.SetFloat(":", this.MovX);
			this.KHCLIAMBBNC().SetFloat("CameraFilterPack/EXTRA_SHOWFPS", this.MovY);
			this.BAGICADFBAB().SetFloat("player.gamecompleted", this.KJIKOEIAENF);
			this.KBOPGONOCNP().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1252f, 166f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C2D RID: 7213 RVA: 0x000AD697 File Offset: 0x000AB897
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("The authentication ticket expired. You need to connect (and authenticate) again. Disconnecting.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001C2E RID: 7214 RVA: 0x0002523B File Offset: 0x0002343B
	private void HEBOIFKBLGD()
	{
	}

	// Token: 0x06001C2F RID: 7215 RVA: 0x000AD031 File Offset: 0x000AB231
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C30 RID: 7216 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06001C31 RID: 7217 RVA: 0x000AD6BB File Offset: 0x000AB8BB
	private Material INOBFNCKFGK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C32 RID: 7218 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06001C33 RID: 7219 RVA: 0x000AD6F2 File Offset: 0x000AB8F2
	private void COOHIILCOCO()
	{
		this.SCShader = Shader.Find("Instantiating: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001C34 RID: 7220 RVA: 0x000AD718 File Offset: 0x000AB918
	private void HHKBBEFJEBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 799f)
			{
				this.HBJJOCHGOPH = 1501f;
			}
			this.DOMEEFLPEPJ().SetFloat("Failed!", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("[UI] ", this.Intensity);
			this.HCGJCMDJPGD().SetFloat("_Color_G", this.MovX);
			this.LELKBCALFCF().SetFloat("LoadMapCanvas", this.MovY);
			this.EOCCJGIGEGJ().SetFloat("_TimeX", this.KJIKOEIAENF);
			this.NFMGLIKNOOC().SetVector("plainText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 932f, 188f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C35 RID: 7221 RVA: 0x000AD817 File Offset: 0x000ABA17
	private Material HKIMAANBGMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C36 RID: 7222 RVA: 0x000AD84E File Offset: 0x000ABA4E
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Gradients_Hue");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001C37 RID: 7223 RVA: 0x000AD872 File Offset: 0x000ABA72
	private Material LELKBCALFCF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C38 RID: 7224 RVA: 0x000AD8A9 File Offset: 0x000ABAA9
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find("LevelInfoInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001C39 RID: 7225 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x06001C3A RID: 7226 RVA: 0x000AD031 File Offset: 0x000AB231
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C3B RID: 7227 RVA: 0x000AD8CD File Offset: 0x000ABACD
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C3C RID: 7228 RVA: 0x000AD031 File Offset: 0x000AB231
	private void DKPBBJINKMG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C3D RID: 7229 RVA: 0x000AD904 File Offset: 0x000ABB04
	private void CEDFFAOOPOG()
	{
		this.SCShader = Shader.Find("GenerationMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001C3E RID: 7230 RVA: 0x000AD928 File Offset: 0x000ABB28
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C3F RID: 7231 RVA: 0x000AD031 File Offset: 0x000AB231
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C40 RID: 7232 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06001C41 RID: 7233 RVA: 0x000AD95F File Offset: 0x000ABB5F
	private void EDPDMBFLHLP()
	{
		this.SCShader = Shader.Find("Inside cells:\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001C42 RID: 7234 RVA: 0x000AD031 File Offset: 0x000AB231
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C43 RID: 7235 RVA: 0x000AD031 File Offset: 0x000AB231
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C44 RID: 7236 RVA: 0x000AD984 File Offset: 0x000ABB84
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 199f)
			{
				this.HBJJOCHGOPH = 114f;
			}
			this.KHCLIAMBBNC().SetFloat("_ForceYSwap", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("_TimeX", this.Intensity);
			this.DOMEEFLPEPJ().SetFloat("z", this.MovX);
			this.BAGICADFBAB().SetFloat("CameraFilterPack/Pixelisation_OilPaintHQ", this.MovY);
			this.OHKGGPFGLFD().SetFloat("_Value3", this.KJIKOEIAENF);
			this.MICHFGAOPKM().SetVector(" registered.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 595f, 1111f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C45 RID: 7237 RVA: 0x000ADA83 File Offset: 0x000ABC83
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("_VignettingDirt");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001C46 RID: 7238 RVA: 0x000AD031 File Offset: 0x000AB231
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x1700004B RID: 75
	// (get) Token: 0x06001C47 RID: 7239 RVA: 0x000ADAA7 File Offset: 0x000ABCA7
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

	// Token: 0x06001C48 RID: 7240 RVA: 0x000ADADE File Offset: 0x000ABCDE
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("CameraFilterPack_Blizzard1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001C49 RID: 7241 RVA: 0x000AD031 File Offset: 0x000AB231
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C4A RID: 7242 RVA: 0x000ADB02 File Offset: 0x000ABD02
	private void MKOMIDCPCDC()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001C4B RID: 7243 RVA: 0x000ADB26 File Offset: 0x000ABD26
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C4C RID: 7244 RVA: 0x000ADB60 File Offset: 0x000ABD60
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1643f)
			{
				this.HBJJOCHGOPH = 948f;
			}
			this.LELKBCALFCF().SetFloat("_MatrixSize", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("_ScreenResolution", this.Intensity);
			this.HKIMAANBGMJ().SetFloat("FrostCanvas", this.MovX);
			this.DOMEEFLPEPJ().SetFloat("_Value3", this.MovY);
			this.LELKBCALFCF().SetFloat("#000000CC", this.KJIKOEIAENF);
			this.FGENHBKMPDA().SetVector(" from: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 551f, 147f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C4D RID: 7245 RVA: 0x000ADC60 File Offset: 0x000ABE60
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 389f)
			{
				this.HBJJOCHGOPH = 1927f;
			}
			this.BFGNMFCNDBC().SetFloat("CompletedLevel", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("_Blend", this.Intensity);
			this.HKIMAANBGMJ().SetFloat("cancel", this.MovX);
			this.MJJIEHANFJA().SetFloat("CheckpointsScoreText", this.MovY);
			this.MICHFGAOPKM().SetFloat("UseScanLineSize", this.KJIKOEIAENF);
			this.OCHJIMJNEMO().SetVector("Environment/SunBase_", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 593f, 291f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C4E RID: 7246 RVA: 0x000ADD5F File Offset: 0x000ABF5F
	private void AIBNKIDADPI()
	{
		this.SCShader = Shader.Find("_Val");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001C4F RID: 7247 RVA: 0x000AD031 File Offset: 0x000AB231
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C50 RID: 7248 RVA: 0x000AD031 File Offset: 0x000AB231
	private void GNPDGBNDCPL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C51 RID: 7249 RVA: 0x000ADD83 File Offset: 0x000ABF83
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blur_Radial_Fast");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001C52 RID: 7250 RVA: 0x000ADDA8 File Offset: 0x000ABFA8
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1300f)
			{
				this.HBJJOCHGOPH = 1711f;
			}
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("_ScreenResolution", this.Intensity);
			this.KHCLIAMBBNC().SetFloat("Items", this.MovX);
			this.MJJIEHANFJA().SetFloat("<b>#", this.MovY);
			this.BFGNMFCNDBC().SetFloat("GlassDistortion", this.KJIKOEIAENF);
			this.EOCCJGIGEGJ().SetVector("_Offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1057f, 1239f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C53 RID: 7251 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06001C54 RID: 7252 RVA: 0x000ADEA7 File Offset: 0x000AC0A7
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C55 RID: 7253 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06001C56 RID: 7254 RVA: 0x000AD031 File Offset: 0x000AB231
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C57 RID: 7255 RVA: 0x000ADEDE File Offset: 0x000AC0DE
	private Material DOMEEFLPEPJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C58 RID: 7256 RVA: 0x000AD031 File Offset: 0x000AB231
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C59 RID: 7257 RVA: 0x000ADF18 File Offset: 0x000AC118
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 684f)
			{
				this.HBJJOCHGOPH = 478f;
			}
			this.OIIDAKBILMI().SetFloat("ready", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("_Offsets", this.Intensity);
			this.KBOPGONOCNP().SetFloat("CameraFilterPack/Vision_Plasma", this.MovX);
			this.OCHJIMJNEMO().SetFloat("settings_bindings_controller_type", this.MovY);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Drawing_Toon", this.KJIKOEIAENF);
			this.HCGJCMDJPGD().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1498f, 1754f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C5A RID: 7258 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x06001C5B RID: 7259 RVA: 0x000AE017 File Offset: 0x000AC217
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C5C RID: 7260 RVA: 0x000AE050 File Offset: 0x000AC250
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1786f)
			{
				this.HBJJOCHGOPH = 508f;
			}
			this.NFMGLIKNOOC().SetFloat("OK", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetFloat("stats on", this.Intensity);
			this.INOBFNCKFGK().SetFloat("https://bugs.khb-soft.ru/set_project.php?project_id=1", this.MovX);
			this.EOCCJGIGEGJ().SetFloat("_Value9", this.MovY);
			this.BAGICADFBAB().SetFloat(".lastCheckpoint.lives", this.KJIKOEIAENF);
			this.BFGNMFCNDBC().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 647f, 101f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C5D RID: 7261 RVA: 0x000AE14F File Offset: 0x000AC34F
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-70);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C5E RID: 7262 RVA: 0x000AE188 File Offset: 0x000AC388
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 683f)
			{
				this.HBJJOCHGOPH = 414f;
			}
			this.HCGJCMDJPGD().SetFloat("received</b>\n#reason: ", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("CameraFilterPack/TV_Horror", this.Intensity);
			this.KBOPGONOCNP().SetFloat("EnableRankingToggle", this.MovX);
			this.KBOPGONOCNP().SetFloat("player.goldlollipop", this.MovY);
			this.KHCLIAMBBNC().SetFloat("/", this.KJIKOEIAENF);
			this.AELJLBOJAIL().SetVector("InventoryGrid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 178f, 1150f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C5F RID: 7263 RVA: 0x000AE288 File Offset: 0x000AC488
	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 322f)
			{
				this.HBJJOCHGOPH = 696f;
			}
			this.HKIMAANBGMJ().SetFloat("bans.viewed.", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat(" ownership transfered to: ", this.Intensity);
			this.EFMCNLELMDO().SetFloat("GetGameList failed: ", this.MovX);
			this.FGENHBKMPDA().SetFloat("_ScreenResolution", this.MovY);
			this.LELKBCALFCF().SetFloat("_Distortion", this.KJIKOEIAENF);
			this.MICHFGAOPKM().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1071f, 804f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C60 RID: 7264 RVA: 0x000AD031 File Offset: 0x000AB231
	private void IEFMONDKKJN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C61 RID: 7265 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMNOHLNANIP()
	{
	}

	// Token: 0x06001C62 RID: 7266 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x06001C63 RID: 7267 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBPCODPOJAH()
	{
	}

	// Token: 0x06001C64 RID: 7268 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06001C65 RID: 7269 RVA: 0x000AE387 File Offset: 0x000AC587
	private Material CECJJMKLEAK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C66 RID: 7270 RVA: 0x000AD00D File Offset: 0x000AB20D
	private void GLEJGFLCLPJ()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001C67 RID: 7271 RVA: 0x000AE3BE File Offset: 0x000AC5BE
	private Material OHKGGPFGLFD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C68 RID: 7272 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06001C69 RID: 7273 RVA: 0x000AE3F5 File Offset: 0x000AC5F5
	private void FLKEJJEGCFA()
	{
		this.SCShader = Shader.Find("Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001C6A RID: 7274 RVA: 0x000AD031 File Offset: 0x000AB231
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C6B RID: 7275 RVA: 0x000AE41C File Offset: 0x000AC61C
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 487f)
			{
				this.HBJJOCHGOPH = 1311f;
			}
			this.MICHFGAOPKM().SetFloat("stretchWidth", this.HBJJOCHGOPH);
			this.MJJIEHANFJA().SetFloat(".lastCheckpoint.powerupsScore", this.Intensity);
			this.KBOPGONOCNP().SetFloat("_BlurRadius4", this.MovX);
			this.MICHFGAOPKM().SetFloat("CheckpointsScoreText", this.MovY);
			this.AELJLBOJAIL().SetFloat("_Amount", this.KJIKOEIAENF);
			this.NBPKMLMCHFN.SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 955f, 783f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C6C RID: 7276 RVA: 0x000AE51B File Offset: 0x000AC71B
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("CompletedLevel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001C6D RID: 7277 RVA: 0x000AE540 File Offset: 0x000AC740
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 670f)
			{
				this.HBJJOCHGOPH = 730f;
			}
			this.EOCCJGIGEGJ().SetFloat("Down ", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("original.tutorial", this.Intensity);
			this.KHCLIAMBBNC().SetFloat("_TraceBehindObjects", this.MovX);
			this.HCGJCMDJPGD().SetFloat("PlayButton", this.MovY);
			this.MJJIEHANFJA().SetFloat("#reward: ", this.KJIKOEIAENF);
			this.BAGICADFBAB().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 740f, 1931f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C6E RID: 7278 RVA: 0x000AE640 File Offset: 0x000AC840
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1194f)
			{
				this.HBJJOCHGOPH = 1343f;
			}
			this.MICHFGAOPKM().SetFloat("_RampTex", this.HBJJOCHGOPH);
			this.DOMEEFLPEPJ().SetFloat("_FadeFromBinary", this.Intensity);
			this.MJJIEHANFJA().SetFloat("The given 2D texture ", this.MovX);
			this.OCHJIMJNEMO().SetFloat("_Near", this.MovY);
			this.EFMCNLELMDO().SetFloat(" - Contains ", this.KJIKOEIAENF);
			this.MJJIEHANFJA().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 62f, 1943f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C6F RID: 7279 RVA: 0x000AE73F File Offset: 0x000AC93F
	private Material MJJIEHANFJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C70 RID: 7280 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x06001C71 RID: 7281 RVA: 0x000AE778 File Offset: 0x000AC978
	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1331f)
			{
				this.HBJJOCHGOPH = 368f;
			}
			this.HKIMAANBGMJ().SetFloat("1234332714", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("english", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_Color", this.MovX);
			this.OIIDAKBILMI().SetFloat("_SizeY", this.MovY);
			this.OCHJIMJNEMO().SetFloat("[Down-Left]", this.KJIKOEIAENF);
			this.LELKBCALFCF().SetVector(".mp3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1840f, 339f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C72 RID: 7282 RVA: 0x000AE877 File Offset: 0x000ACA77
	private Material KHCLIAMBBNC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C73 RID: 7283 RVA: 0x000AE8B0 File Offset: 0x000ACAB0
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 0f)
			{
				this.HBJJOCHGOPH = 474f;
			}
			this.OIIDAKBILMI().SetFloat("_ColorBuffer", this.HBJJOCHGOPH);
			this.INOBFNCKFGK().SetFloat("float,10", this.Intensity);
			this.BAGICADFBAB().SetFloat("ConfigVersionSlider", this.MovX);
			this.OIIDAKBILMI().SetFloat("_SpawnHeuristic", this.MovY);
			this.LELKBCALFCF().SetFloat("#savemapbeforeuploading", this.KJIKOEIAENF);
			this.HKIMAANBGMJ().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1603f, 926f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C74 RID: 7284 RVA: 0x000AE9AF File Offset: 0x000ACBAF
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find("[LevelEditorScene] Print Audio Wave: Start");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001C75 RID: 7285 RVA: 0x000ADAA7 File Offset: 0x000ABCA7
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C76 RID: 7286 RVA: 0x000AE9D4 File Offset: 0x000ACBD4
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1960f)
			{
				this.HBJJOCHGOPH = 687f;
			}
			this.EFMCNLELMDO().SetFloat("_AdaptationMin", this.HBJJOCHGOPH);
			this.INOBFNCKFGK().SetFloat("#", this.Intensity);
			this.MJJIEHANFJA().SetFloat("_Axis", this.MovX);
			this.AELJLBOJAIL().SetFloat("return CheckCondition()", this.MovY);
			this.LELKBCALFCF().SetFloat("true", this.KJIKOEIAENF);
			this.OCHJIMJNEMO().SetVector("offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 617f, 352f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C77 RID: 7287 RVA: 0x000AEAD4 File Offset: 0x000ACCD4
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1769f)
			{
				this.HBJJOCHGOPH = 1854f;
			}
			this.MJJIEHANFJA().SetFloat("_ChangeGreen", this.HBJJOCHGOPH);
			this.MJJIEHANFJA().SetFloat(".completedMaps", this.Intensity);
			this.DOMEEFLPEPJ().SetFloat(" or player:", this.MovX);
			this.INOBFNCKFGK().SetFloat(" - PUBLISHED #", this.MovY);
			this.KBOPGONOCNP().SetFloat("skin.hit_normal", this.KJIKOEIAENF);
			this.LELKBCALFCF().SetVector("RoomNameText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1190f, 255f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C78 RID: 7288 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06001C79 RID: 7289 RVA: 0x000ACE17 File Offset: 0x000AB017
	private Material EFMCNLELMDO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C7A RID: 7290 RVA: 0x000AD031 File Offset: 0x000AB231
	private void HAHJJPLPOKB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C7B RID: 7291 RVA: 0x000AEBD3 File Offset: 0x000ACDD3
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("#000000CC");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001C7C RID: 7292 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06001C7D RID: 7293 RVA: 0x000AD00D File Offset: 0x000AB20D
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001C7E RID: 7294 RVA: 0x000AEBF7 File Offset: 0x000ACDF7
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find("mapselector.orderby");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001C7F RID: 7295 RVA: 0x000AEC1B File Offset: 0x000ACE1B
	private void ADPLHDFJFID()
	{
		this.SCShader = Shader.Find("_Red_B");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001C80 RID: 7296 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x06001C81 RID: 7297 RVA: 0x000AEC3F File Offset: 0x000ACE3F
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)100;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C82 RID: 7298 RVA: 0x000AEC76 File Offset: 0x000ACE76
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("mapselector.filter.favoriteonly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001C83 RID: 7299 RVA: 0x000AEC9A File Offset: 0x000ACE9A
	private void CEAGPJBGBMH()
	{
		this.SCShader = Shader.Find(". Check if the server is available.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001C84 RID: 7300 RVA: 0x000AECBE File Offset: 0x000ACEBE
	private void DOKAKEMDALN()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001C85 RID: 7301 RVA: 0x000AECE2 File Offset: 0x000ACEE2
	private void MEBPBNLBECA()
	{
		this.SCShader = Shader.Find("z");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001C86 RID: 7302 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001C87 RID: 7303 RVA: 0x000AD031 File Offset: 0x000AB231
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C88 RID: 7304 RVA: 0x000AD031 File Offset: 0x000AB231
	private void IENKPJEBMFM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C89 RID: 7305 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCDLIKEDMCF()
	{
	}

	// Token: 0x06001C8A RID: 7306 RVA: 0x000AED06 File Offset: 0x000ACF06
	private void FDNONDCGGCG()
	{
		this.SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001C8B RID: 7307 RVA: 0x000AED2C File Offset: 0x000ACF2C
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.MovX);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.MovY);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.KJIKOEIAENF);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C8C RID: 7308 RVA: 0x000AEE2B File Offset: 0x000AD02B
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C8D RID: 7309 RVA: 0x000AEE64 File Offset: 0x000AD064
	private void NJBMCJOOMMP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1088f)
			{
				this.HBJJOCHGOPH = 287f;
			}
			this.AELJLBOJAIL().SetFloat(" ", this.HBJJOCHGOPH);
			this.KHCLIAMBBNC().SetFloat("_ScreenResolution", this.Intensity);
			this.OHKGGPFGLFD().SetFloat("_Value3", this.MovX);
			this.MICHFGAOPKM().SetFloat("_Value2", this.MovY);
			this.OIIDAKBILMI().SetFloat("_MatrixSpeed", this.KJIKOEIAENF);
			this.BAGICADFBAB().SetVector("workshop.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1371f, 725f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C8E RID: 7310 RVA: 0x000AD031 File Offset: 0x000AB231
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C8F RID: 7311 RVA: 0x000AD031 File Offset: 0x000AB231
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C90 RID: 7312 RVA: 0x000AEF64 File Offset: 0x000AD164
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 143f)
			{
				this.HBJJOCHGOPH = 1148f;
			}
			this.HCGJCMDJPGD().SetFloat("finished", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetFloat("TransferOwnership() view ", this.Intensity);
			this.EFMCNLELMDO().SetFloat("Coord", this.MovX);
			this.NFMGLIKNOOC().SetFloat("CameraFilterPack/Blend2Camera_GreenScreen", this.MovY);
			this.BAGICADFBAB().SetFloat("Protocol switch from: ", this.KJIKOEIAENF);
			this.NBPKMLMCHFN.SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 196f, 529f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C91 RID: 7313 RVA: 0x000AD031 File Offset: 0x000AB231
	private void HCDBNAKGDJC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C92 RID: 7314 RVA: 0x000AF064 File Offset: 0x000AD264
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 692f)
			{
				this.HBJJOCHGOPH = 634f;
			}
			this.BFGNMFCNDBC().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("_TreatBackfaceHitAsMiss", this.Intensity);
			this.MICHFGAOPKM().SetFloat("_Distortion", this.MovX);
			this.AELJLBOJAIL().SetFloat("[ResourcesManager] Load audio error: ", this.MovY);
			this.MJJIEHANFJA().SetFloat("_InvScreenSize", this.KJIKOEIAENF);
			this.BFGNMFCNDBC().SetVector("Mouse2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1390f, 1620f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C93 RID: 7315 RVA: 0x000AF163 File Offset: 0x000AD363
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001C94 RID: 7316 RVA: 0x000AF19A File Offset: 0x000AD39A
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("Please specify a map name or buildID");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001C95 RID: 7317 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06001C96 RID: 7318 RVA: 0x000AD031 File Offset: 0x000AB231
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C97 RID: 7319 RVA: 0x000AD031 File Offset: 0x000AB231
	private void PNNPDMHLFHE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001C98 RID: 7320 RVA: 0x000AF1C0 File Offset: 0x000AD3C0
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1783f)
			{
				this.HBJJOCHGOPH = 546f;
			}
			this.CECJJMKLEAK().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("#yes", this.Intensity);
			this.CECJJMKLEAK().SetFloat("achievements.21.progress", this.MovX);
			this.HCGJCMDJPGD().SetFloat("https://twitch.tv/intralism", this.MovY);
			this.NFMGLIKNOOC().SetFloat("Error: You're not logged into Steam!", this.KJIKOEIAENF);
			this.CECJJMKLEAK().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 948f, 775f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C99 RID: 7321 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06001C9A RID: 7322 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x06001C9B RID: 7323 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06001C9C RID: 7324 RVA: 0x000AF2C0 File Offset: 0x000AD4C0
	private void CACCPBENDAP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 705f)
			{
				this.HBJJOCHGOPH = 259f;
			}
			this.DOMEEFLPEPJ().SetFloat("_BlurRadius4", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("MenuScene", this.Intensity);
			this.OHKGGPFGLFD().SetFloat("_ScreenResolution", this.MovX);
			this.OCHJIMJNEMO().SetFloat("UseFinalGlassColor", this.MovY);
			this.HCGJCMDJPGD().SetFloat("player.goldarc", this.KJIKOEIAENF);
			this.BAGICADFBAB().SetVector("failed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1705f, 496f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001C9D RID: 7325 RVA: 0x000AF3BF File Offset: 0x000AD5BF
	private void AKHCOBHHGJP()
	{
		this.SCShader = Shader.Find("#alreadyexist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x040003DB RID: 987
	public Shader SCShader;

	// Token: 0x040003DC RID: 988
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040003DD RID: 989
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040003DE RID: 990
	private Material BJFKDHHMLJH;

	// Token: 0x040003DF RID: 991
	[Range(-0.5f, 0.5f)]
	public float Intensity = 0.125f;

	// Token: 0x040003E0 RID: 992
	[Range(-2f, 2f)]
	public float MovX = 0.5f;

	// Token: 0x040003E1 RID: 993
	[Range(-2f, 2f)]
	public float MovY = 0.5f;

	// Token: 0x040003E2 RID: 994
	[Range(0f, 10f)]
	private float KJIKOEIAENF = 1f;
}
