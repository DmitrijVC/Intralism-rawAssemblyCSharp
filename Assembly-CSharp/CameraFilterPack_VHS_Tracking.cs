using System;
using UnityEngine;

// Token: 0x0200012E RID: 302
[AddComponentMenu("Camera Filter Pack/VHS/Tracking")]
[ExecuteInEditMode]
public class CameraFilterPack_VHS_Tracking : MonoBehaviour
{
	// Token: 0x06005FA5 RID: 24485 RVA: 0x001D2174 File Offset: 0x001D0374
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 642f)
			{
				this.HBJJOCHGOPH = 13f;
			}
			this.FHFLKLMFHOI().SetFloat("_Value6", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("DifficultyBG", this.Tracking);
			this.LDNADDJMIPK().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 18f, 449f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FA6 RID: 24486 RVA: 0x001D2234 File Offset: 0x001D0434
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 498f)
			{
				this.HBJJOCHGOPH = 666f;
			}
			this.LPMLLJKMAMP().SetFloat("ticket", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetFloat("_MaxRadiusOrKInPaper", this.Tracking);
			this.LPMLLJKMAMP().SetVector("Tab2Content", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 690f, 1050f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FA7 RID: 24487 RVA: 0x001D22F4 File Offset: 0x001D04F4
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 261f)
			{
				this.HBJJOCHGOPH = 1486f;
			}
			this.FHFLKLMFHOI().SetFloat("_Red_C", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat("CameraFilterPack/TV_WideScreenHorizontal", this.Tracking);
			this.GHHPOGODBHB().SetVector(".png", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 476f, 223f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FA8 RID: 24488 RVA: 0x001D23B1 File Offset: 0x001D05B1
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-70);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005FA9 RID: 24489 RVA: 0x001D23E8 File Offset: 0x001D05E8
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("settings_bindings_");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005FAA RID: 24490 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x06005FAB RID: 24491 RVA: 0x001D240C File Offset: 0x001D060C
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005FAC RID: 24492 RVA: 0x001D2444 File Offset: 0x001D0644
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Tracking);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FAD RID: 24493 RVA: 0x001D2501 File Offset: 0x001D0701
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005FAE RID: 24494 RVA: 0x001D2525 File Offset: 0x001D0725
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005FAF RID: 24495 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005FB0 RID: 24496 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06005FB1 RID: 24497 RVA: 0x001D2542 File Offset: 0x001D0742
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005FB2 RID: 24498 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x06005FB3 RID: 24499 RVA: 0x001D2525 File Offset: 0x001D0725
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005FB4 RID: 24500 RVA: 0x001D257C File Offset: 0x001D077C
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 496f)
			{
				this.HBJJOCHGOPH = 1366f;
			}
			this.DOHGBNPMBKG().SetFloat(").", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat("_Value", this.Tracking);
			this.KEMAALEODNH().SetVector("GenerationMenu", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 192f, 1015f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FB5 RID: 24501 RVA: 0x001D2639 File Offset: 0x001D0839
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("_ChangeGreen");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005FB6 RID: 24502 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06005FB7 RID: 24503 RVA: 0x001D2525 File Offset: 0x001D0725
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005FB8 RID: 24504 RVA: 0x001D2525 File Offset: 0x001D0725
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005FB9 RID: 24505 RVA: 0x001D265D File Offset: 0x001D085D
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_VividLight");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005FBA RID: 24506 RVA: 0x001D2681 File Offset: 0x001D0881
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005FBB RID: 24507 RVA: 0x001D2525 File Offset: 0x001D0725
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005FBC RID: 24508 RVA: 0x001D26B8 File Offset: 0x001D08B8
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005FBD RID: 24509 RVA: 0x001D26F0 File Offset: 0x001D08F0
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1354f)
			{
				this.HBJJOCHGOPH = 1212f;
			}
			this.LDNADDJMIPK().SetFloat("LoadPlayerSkin", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("clicked ", this.Tracking);
			this.NBPKMLMCHFN.SetVector("LeaderboardsButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1314f, 223f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FBE RID: 24510 RVA: 0x001D2525 File Offset: 0x001D0725
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005FBF RID: 24511 RVA: 0x001D27B0 File Offset: 0x001D09B0
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1650f)
			{
				this.HBJJOCHGOPH = 1345f;
			}
			this.LPMLLJKMAMP().SetFloat(". Check if the server is available.", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("Ev Destroy Failed. Could not find PhotonView with instantiationId ", this.Tracking);
			this.LPMLLJKMAMP().SetVector("[MapsData] Bad map: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 810f, 694f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FC0 RID: 24512 RVA: 0x001D2525 File Offset: 0x001D0725
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005FC1 RID: 24513 RVA: 0x001D2525 File Offset: 0x001D0725
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005FC2 RID: 24514 RVA: 0x001D2870 File Offset: 0x001D0A70
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 458f)
			{
				this.HBJJOCHGOPH = 1326f;
			}
			this.LPMLLJKMAMP().SetFloat("_MaxVelocity", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("_BaseTex", this.Tracking);
			this.DOHGBNPMBKG().SetVector("materialsitemid[", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 969f, 200f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FC3 RID: 24515 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x06005FC4 RID: 24516 RVA: 0x001D292D File Offset: 0x001D0B2D
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005FC5 RID: 24517 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06005FC6 RID: 24518 RVA: 0x001D2525 File Offset: 0x001D0725
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005FC7 RID: 24519 RVA: 0x001D2964 File Offset: 0x001D0B64
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1776f)
			{
				this.HBJJOCHGOPH = 1412f;
			}
			this.FHFLKLMFHOI().SetFloat("SetRotation", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Intensity", this.Tracking);
			this.LPMLLJKMAMP().SetVector("Intensity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1661f, 664f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FC9 RID: 24521 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06005FCA RID: 24522 RVA: 0x001D2A3F File Offset: 0x001D0C3F
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find("#savemapchanges?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005FCB RID: 24523 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06005FCC RID: 24524 RVA: 0x001D2A64 File Offset: 0x001D0C64
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 503f)
			{
				this.HBJJOCHGOPH = 1784f;
			}
			this.KAFBNOBOIAJ().SetFloat("-1", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat("_Intensity", this.Tracking);
			this.LPMLLJKMAMP().SetVector(" / Sample Count: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1050f, 756f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FCD RID: 24525 RVA: 0x001D2B24 File Offset: 0x001D0D24
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1557f)
			{
				this.HBJJOCHGOPH = 600f;
			}
			this.DEFBJOCJJKF().SetFloat(": ", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("_Radius", this.Tracking);
			this.GHHPOGODBHB().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1709f, 577f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FCE RID: 24526 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06005FCF RID: 24527 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06005FD0 RID: 24528 RVA: 0x001D2BE1 File Offset: 0x001D0DE1
	private Material GHHPOGODBHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005FD1 RID: 24529 RVA: 0x001D2C18 File Offset: 0x001D0E18
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005FD2 RID: 24530 RVA: 0x001D2C4F File Offset: 0x001D0E4F
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("ViewMenu");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005FD3 RID: 24531 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x06005FD4 RID: 24532 RVA: 0x001D2C73 File Offset: 0x001D0E73
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("_Blend");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005FD5 RID: 24533 RVA: 0x001D2C98 File Offset: 0x001D0E98
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1028f)
			{
				this.HBJJOCHGOPH = 1740f;
			}
			this.GHHPOGODBHB().SetFloat("CameraFilterPack_Paper2", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetFloat("_TimeX", this.Tracking);
			this.DEFBJOCJJKF().SetVector("settings.fps", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 536f, 992f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FD6 RID: 24534 RVA: 0x001D2525 File Offset: 0x001D0725
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005FD7 RID: 24535 RVA: 0x001D2525 File Offset: 0x001D0725
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005FD8 RID: 24536 RVA: 0x001D2D55 File Offset: 0x001D0F55
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find("_FarCamera");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005FD9 RID: 24537 RVA: 0x001D2D7C File Offset: 0x001D0F7C
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1656f)
			{
				this.HBJJOCHGOPH = 1333f;
			}
			this.ADGHJOHKEHG().SetFloat("Vignette", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("TotalTimeLabel", this.Tracking);
			this.GHHPOGODBHB().SetVector(". Possible scene loading in progress?", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1090f, 1826f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FDA RID: 24538 RVA: 0x001D2E39 File Offset: 0x001D1039
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Vision_Drost");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x17000113 RID: 275
	// (get) Token: 0x06005FDB RID: 24539 RVA: 0x001D2E5D File Offset: 0x001D105D
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

	// Token: 0x06005FDC RID: 24540 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x06005FDD RID: 24541 RVA: 0x001D2525 File Offset: 0x001D0725
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005FDE RID: 24542 RVA: 0x001D2525 File Offset: 0x001D0725
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005FDF RID: 24543 RVA: 0x001D2E94 File Offset: 0x001D1094
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-92);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005FE0 RID: 24544 RVA: 0x001D2ECB File Offset: 0x001D10CB
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("w");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005FE1 RID: 24545 RVA: 0x001D2EF0 File Offset: 0x001D10F0
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1837f)
			{
				this.HBJJOCHGOPH = 317f;
			}
			this.KAFBNOBOIAJ().SetFloat("[Up]", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("#combo", this.Tracking);
			this.FHFLKLMFHOI().SetVector("CameraFilterPack/Blend2Camera_ColorBurn", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 877f, 574f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FE2 RID: 24546 RVA: 0x001D2FB0 File Offset: 0x001D11B0
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 486f)
			{
				this.HBJJOCHGOPH = 1742f;
			}
			this.GHHPOGODBHB().SetFloat("). ", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("_MainTex2", this.Tracking);
			this.LDNADDJMIPK().SetVector("menu.tabid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 932f, 47f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FE3 RID: 24547 RVA: 0x001D2525 File Offset: 0x001D0725
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005FE4 RID: 24548 RVA: 0x001D3070 File Offset: 0x001D1270
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1460f)
			{
				this.HBJJOCHGOPH = 1195f;
			}
			this.KAFBNOBOIAJ().SetFloat("DISTORT", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat("[ResourcesManager] Load text error: not found", this.Tracking);
			this.GHHPOGODBHB().SetVector("_FarCamera", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1142f, 1322f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FE5 RID: 24549 RVA: 0x001D2525 File Offset: 0x001D0725
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005FE6 RID: 24550 RVA: 0x001D312D File Offset: 0x001D132D
	private void FANADGBGCPI()
	{
		this.SCShader = Shader.Find("_BaseTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005FE7 RID: 24551 RVA: 0x001D3154 File Offset: 0x001D1354
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1387f)
			{
				this.HBJJOCHGOPH = 1635f;
			}
			this.LDNADDJMIPK().SetFloat("Editor/", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat("Horizontal", this.Tracking);
			this.KAFBNOBOIAJ().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1325f, 659f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FE8 RID: 24552 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06005FE9 RID: 24553 RVA: 0x001D3214 File Offset: 0x001D1414
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1788f)
			{
				this.HBJJOCHGOPH = 776f;
			}
			this.LPMLLJKMAMP().SetFloat("SetSatelliteTrailWidth", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat("PointsScoreText", this.Tracking);
			this.DOHGBNPMBKG().SetVector("tagElement", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1843f, 339f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FEA RID: 24554 RVA: 0x001D32D4 File Offset: 0x001D14D4
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1360f)
			{
				this.HBJJOCHGOPH = 664f;
			}
			this.KAFBNOBOIAJ().SetFloat("[LevelEditorScene] Item creation successful! Published Item ID: ", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetFloat("id", this.Tracking);
			this.ADGHJOHKEHG().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1632f, 677f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005FEB RID: 24555 RVA: 0x001D3391 File Offset: 0x001D1591
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("InputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005FEC RID: 24556 RVA: 0x001D33B5 File Offset: 0x001D15B5
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("offline room");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005FED RID: 24557 RVA: 0x001D33D9 File Offset: 0x001D15D9
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/VHS_Tracking");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0400099E RID: 2462
	public Shader SCShader;

	// Token: 0x0400099F RID: 2463
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040009A0 RID: 2464
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040009A1 RID: 2465
	private Material BJFKDHHMLJH;

	// Token: 0x040009A2 RID: 2466
	[Range(0f, 2f)]
	public float Tracking = 1f;
}
