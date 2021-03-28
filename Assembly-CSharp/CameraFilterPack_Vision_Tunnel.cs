using System;
using UnityEngine;

// Token: 0x0200013A RID: 314
[AddComponentMenu("Camera Filter Pack/Vision/Tunnel")]
[ExecuteInEditMode]
public class CameraFilterPack_Vision_Tunnel : MonoBehaviour
{
	// Token: 0x0600632B RID: 25387 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x0600632C RID: 25388 RVA: 0x001E2970 File Offset: 0x001E0B70
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 173f)
			{
				this.HBJJOCHGOPH = 224f;
			}
			this.EOCCJGIGEGJ().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Value);
			this.GKILCDHJFEG().SetFloat(" not exist", this.Value2);
			this.GCDFNHMJMIP().SetFloat("_Value6", this.Intensity);
			this.MFHPKGICPIO().SetFloat("GameVolumeSlider", this.CCIENBFIKKH);
			this.FHFLKLMFHOI().SetVector("PointerEnter ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1626f, 976f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600632D RID: 25389 RVA: 0x001E2A6F File Offset: 0x001E0C6F
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600632F RID: 25391 RVA: 0x001E2AE8 File Offset: 0x001E0CE8
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 628f)
			{
				this.HBJJOCHGOPH = 1359f;
			}
			this.KAFBNOBOIAJ().SetFloat("Set particles start speed", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("Most likely the game became empty during the switch to GameServer.", this.Value);
			this.FHFLKLMFHOI().SetFloat("_MainTex2", this.Value2);
			this.GCDFNHMJMIP().SetFloat("GameScene", this.Intensity);
			this.GCDFNHMJMIP().SetFloat("#close", this.CCIENBFIKKH);
			this.EOCCJGIGEGJ().SetVector("_Speed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1050f, 1641f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006330 RID: 25392 RVA: 0x001E2BE8 File Offset: 0x001E0DE8
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

	// Token: 0x06006331 RID: 25393 RVA: 0x001E2CE8 File Offset: 0x001E0EE8
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1218f)
			{
				this.HBJJOCHGOPH = 1740f;
			}
			this.GCDFNHMJMIP().SetFloat(".lastCheckpoint.lives", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("mapselector.filter.subscribedonly", this.Value);
			this.GKILCDHJFEG().SetFloat("_Value3", this.Value2);
			this.GCDFNHMJMIP().SetFloat("_ScreenResolution", this.Intensity);
			this.MMOODGIODPC().SetFloat("_ScreenResolution", this.CCIENBFIKKH);
			this.JLHLHKPHDFO().SetVector("_EmissionGain", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 408f, 881f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006332 RID: 25394 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06006333 RID: 25395 RVA: 0x001E2DE7 File Offset: 0x001E0FE7
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006334 RID: 25396 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06006335 RID: 25397 RVA: 0x001E2E1E File Offset: 0x001E101E
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006336 RID: 25398 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06006337 RID: 25399 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x06006338 RID: 25400 RVA: 0x001E2E3C File Offset: 0x001E103C
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1585f)
			{
				this.HBJJOCHGOPH = 860f;
			}
			this.HCGJCMDJPGD().SetFloat("UseScanLine", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("Horizontal", this.Value);
			this.KBOPGONOCNP().SetFloat("_SpherePositionY", this.Value2);
			this.JLHLHKPHDFO().SetFloat("/", this.Intensity);
			this.FHFLKLMFHOI().SetFloat("#getrewardfailed: ", this.CCIENBFIKKH);
			this.NBMPPNFKFLB().SetVector("_DistanceParams", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1508f, 1397f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006339 RID: 25401 RVA: 0x001E2E1E File Offset: 0x001E101E
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600633A RID: 25402 RVA: 0x001E2F3B File Offset: 0x001E113B
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Vision_Tunnel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600633B RID: 25403 RVA: 0x001E2E1E File Offset: 0x001E101E
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600633C RID: 25404 RVA: 0x001E2F5F File Offset: 0x001E115F
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find("z");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600633D RID: 25405 RVA: 0x001E2F83 File Offset: 0x001E1183
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600633E RID: 25406 RVA: 0x001E2FA7 File Offset: 0x001E11A7
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600633F RID: 25407 RVA: 0x001E2FCC File Offset: 0x001E11CC
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1353f)
			{
				this.HBJJOCHGOPH = 841f;
			}
			this.KAFBNOBOIAJ().SetFloat(" Message: ", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("inventory.itemscash", this.Value);
			this.KAFBNOBOIAJ().SetFloat("_ScreenResolution", this.Value2);
			this.GCDFNHMJMIP().SetFloat("menu.playedsolo", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("_History1LumaTex", this.CCIENBFIKKH);
			this.MMOODGIODPC().SetVector("_EmissionColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 468f, 1968f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006340 RID: 25408 RVA: 0x001E30CB File Offset: 0x001E12CB
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)72;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006341 RID: 25409 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x06006342 RID: 25410 RVA: 0x001E3102 File Offset: 0x001E1302
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("_Bullet_1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006343 RID: 25411 RVA: 0x001E3128 File Offset: 0x001E1328
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1576f)
			{
				this.HBJJOCHGOPH = 1548f;
			}
			this.MFHPKGICPIO().SetFloat("[PlayerBase] Reset", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("0.00", this.Value);
			this.GKILCDHJFEG().SetFloat("_MainTex", this.Value2);
			this.KAFBNOBOIAJ().SetFloat(". The group number should be at least 1.", this.Intensity);
			this.NBMPPNFKFLB().SetFloat("_Color", this.CCIENBFIKKH);
			this.KAFBNOBOIAJ().SetVector("mapselector.filter.subscribedonly", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 694f, 1210f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006344 RID: 25412 RVA: 0x001E3227 File Offset: 0x001E1427
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("Object ID. Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006345 RID: 25413 RVA: 0x001E324B File Offset: 0x001E144B
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006346 RID: 25414 RVA: 0x001E326F File Offset: 0x001E146F
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006347 RID: 25415 RVA: 0x001E32A6 File Offset: 0x001E14A6
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("Tab1Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006348 RID: 25416 RVA: 0x001E32CA File Offset: 0x001E14CA
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)114;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006349 RID: 25417 RVA: 0x001E3301 File Offset: 0x001E1501
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("Vertical");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600634A RID: 25418 RVA: 0x001E3328 File Offset: 0x001E1528
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1928f)
			{
				this.HBJJOCHGOPH = 1186f;
			}
			this.KAFBNOBOIAJ().SetFloat("/?player=", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("Players NetIDs:", this.Value);
			this.IONHGBPGCHK().SetFloat("menu.tabid", this.Value2);
			this.NBMPPNFKFLB().SetFloat("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp-firstpass", this.Intensity);
			this.KAFBNOBOIAJ().SetFloat("_Red_C", this.CCIENBFIKKH);
			this.MMOODGIODPC().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1860f, 1065f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600634B RID: 25419 RVA: 0x001E3427 File Offset: 0x001E1627
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600634C RID: 25420 RVA: 0x001E345E File Offset: 0x001E165E
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600634D RID: 25421 RVA: 0x001E3495 File Offset: 0x001E1695
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)112;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600634E RID: 25422 RVA: 0x001E34CC File Offset: 0x001E16CC
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("LevelInfoInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600634F RID: 25423 RVA: 0x001E2FA7 File Offset: 0x001E11A7
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006350 RID: 25424 RVA: 0x001E34F0 File Offset: 0x001E16F0
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006351 RID: 25425 RVA: 0x001E2E1E File Offset: 0x001E101E
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006352 RID: 25426 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06006353 RID: 25427 RVA: 0x001E3527 File Offset: 0x001E1727
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006354 RID: 25428 RVA: 0x001E354C File Offset: 0x001E174C
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 730f)
			{
				this.HBJJOCHGOPH = 430f;
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("_Value7", this.Value);
			this.JLHLHKPHDFO().SetFloat("_Blue_G", this.Value2);
			this.FHFLKLMFHOI().SetFloat("_OcclusionTexture", this.Intensity);
			this.MFHPKGICPIO().SetFloat("-", this.CCIENBFIKKH);
			this.HKHBBBFLGJH().SetVector("Error: You're not logged into Steam!", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1439f, 333f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006355 RID: 25429 RVA: 0x001E364B File Offset: 0x001E184B
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006356 RID: 25430 RVA: 0x001E3682 File Offset: 0x001E1882
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("red");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006357 RID: 25431 RVA: 0x001E36A6 File Offset: 0x001E18A6
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)124;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006358 RID: 25432 RVA: 0x001E36DD File Offset: 0x001E18DD
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006359 RID: 25433 RVA: 0x001E2E1E File Offset: 0x001E101E
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600635A RID: 25434 RVA: 0x001E3714 File Offset: 0x001E1914
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find(" beatThreshold: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600635B RID: 25435 RVA: 0x001E3738 File Offset: 0x001E1938
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 474f)
			{
				this.HBJJOCHGOPH = 85f;
			}
			this.JLHLHKPHDFO().SetFloat("_Speed", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("]", this.Value);
			this.KBOPGONOCNP().SetFloat("_TimeX", this.Value2);
			this.KBOPGONOCNP().SetFloat("_ScreenResolution", this.Intensity);
			this.IONHGBPGCHK().SetFloat("SpawnObj", this.CCIENBFIKKH);
			this.HKHBBBFLGJH().SetVector("\n", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1055f, 1975f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600635C RID: 25436 RVA: 0x001E3837 File Offset: 0x001E1A37
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600635D RID: 25437 RVA: 0x001E2E1E File Offset: 0x001E101E
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600635E RID: 25438 RVA: 0x001E2E1E File Offset: 0x001E101E
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600635F RID: 25439 RVA: 0x001E3870 File Offset: 0x001E1A70
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 612f)
			{
				this.HBJJOCHGOPH = 118f;
			}
			this.HCGJCMDJPGD().SetFloat("MenuScene", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat("Image", this.Value);
			this.NBPKMLMCHFN.SetFloat(".completedMaps", this.Value2);
			this.KBOPGONOCNP().SetFloat("RT", this.Intensity);
			this.KAFBNOBOIAJ().SetFloat("_Noise", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("[PlayerBase] ShowImage \"", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 952f, 1197f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006360 RID: 25440 RVA: 0x001E396F File Offset: 0x001E1B6F
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("_Near");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006361 RID: 25441 RVA: 0x001E2E1E File Offset: 0x001E101E
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006362 RID: 25442 RVA: 0x001E3994 File Offset: 0x001E1B94
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 356f)
			{
				this.HBJJOCHGOPH = 116f;
			}
			this.EOCCJGIGEGJ().SetFloat("PickupItemInit", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("_Bloom1", this.Value);
			this.JLHLHKPHDFO().SetFloat("LoadingStatusText", this.Value2);
			this.KAFBNOBOIAJ().SetFloat("_Offsets", this.Intensity);
			this.KAFBNOBOIAJ().SetFloat("menu.tabid", this.CCIENBFIKKH);
			this.JLHLHKPHDFO().SetVector(". Verify the Prefab is in a Resources folder (and not in a subfolder)", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1768f, 1523f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006363 RID: 25443 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x06006364 RID: 25444 RVA: 0x001E3A93 File Offset: 0x001E1C93
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("Item invalid. Make sure your mod contains at leats one file.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x1700011F RID: 287
	// (get) Token: 0x06006365 RID: 25445 RVA: 0x001E3AB7 File Offset: 0x001E1CB7
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

	// Token: 0x04000A0A RID: 2570
	public Shader SCShader;

	// Token: 0x04000A0B RID: 2571
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000A0C RID: 2572
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000A0D RID: 2573
	private Material BJFKDHHMLJH;

	// Token: 0x04000A0E RID: 2574
	[Range(0f, 1f)]
	public float Value = 0.6f;

	// Token: 0x04000A0F RID: 2575
	[Range(0f, 1f)]
	public float Value2 = 0.4f;

	// Token: 0x04000A10 RID: 2576
	[Range(0f, 1f)]
	public float Intensity = 1f;

	// Token: 0x04000A11 RID: 2577
	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;
}
