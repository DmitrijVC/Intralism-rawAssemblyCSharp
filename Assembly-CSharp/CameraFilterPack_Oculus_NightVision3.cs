using System;
using UnityEngine;

// Token: 0x020000FC RID: 252
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Night Vision/Night Vision 3")]
public class CameraFilterPack_Oculus_NightVision3 : MonoBehaviour
{
	// Token: 0x06004E60 RID: 20064 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x06004E61 RID: 20065 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06004E62 RID: 20066 RVA: 0x00187318 File Offset: 0x00185518
	private void PMPKMGKAAJH()
	{
		this.SCShader = Shader.Find("Item ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004E63 RID: 20067 RVA: 0x0018733C File Offset: 0x0018553C
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004E64 RID: 20068 RVA: 0x0018733C File Offset: 0x0018553C
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004E65 RID: 20069 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06004E66 RID: 20070 RVA: 0x00187359 File Offset: 0x00185559
	private Material CECJJMKLEAK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E67 RID: 20071 RVA: 0x00187390 File Offset: 0x00185590
	private void AKHCOBHHGJP()
	{
		this.SCShader = Shader.Find("MaxLivesSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004E68 RID: 20072 RVA: 0x001873B4 File Offset: 0x001855B4
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
			this.NBPKMLMCHFN.SetFloat("_Greenness", this.Greenness);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E69 RID: 20073 RVA: 0x0018746A File Offset: 0x0018566A
	private void IGPCNCJIEOJ()
	{
		this.SCShader = Shader.Find("Left");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004E6A RID: 20074 RVA: 0x0018748E File Offset: 0x0018568E
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("SetSunMinSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004E6B RID: 20075 RVA: 0x001874B2 File Offset: 0x001856B2
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E6C RID: 20076 RVA: 0x001874EC File Offset: 0x001856EC
	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1745f)
			{
				this.HBJJOCHGOPH = 457f;
			}
			this.BAGICADFBAB().SetFloat("ConfigVersionSlider", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("_ProjectToPixelMatrix", this.Greenness);
			this.NFKFAAHHLLM().SetVector(" not exist", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E6D RID: 20077 RVA: 0x001875A4 File Offset: 0x001857A4
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1866f)
			{
				this.HBJJOCHGOPH = 1436f;
			}
			this.BAGICADFBAB().SetFloat("skin.", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("_Value6", this.Greenness);
			this.NLFJGMBCICG().SetVector("Alpha", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E6E RID: 20078 RVA: 0x0018765A File Offset: 0x0018585A
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("Mouse Wheel Down");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004E6F RID: 20079 RVA: 0x00187680 File Offset: 0x00185880
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1000f)
			{
				this.HBJJOCHGOPH = 1182f;
			}
			this.PDEAHJPOMEF().SetFloat("Set sun min/max size", this.HBJJOCHGOPH);
			this.MLMKCOINOOH().SetFloat("_Saturation", this.Greenness);
			this.NJDIODJNGGA().SetVector("_Value", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E70 RID: 20080 RVA: 0x00187736 File Offset: 0x00185936
	private void MKOMIDCPCDC()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004E71 RID: 20081 RVA: 0x0018775A File Offset: 0x0018595A
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E72 RID: 20082 RVA: 0x00187791 File Offset: 0x00185991
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E73 RID: 20083 RVA: 0x001877C8 File Offset: 0x001859C8
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 217f)
			{
				this.HBJJOCHGOPH = 1978f;
			}
			this.MICHFGAOPKM().SetFloat("<b>", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("0", this.Greenness);
			this.CECJJMKLEAK().SetVector("ItemsCountText", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E74 RID: 20084 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06004E75 RID: 20085 RVA: 0x0018787E File Offset: 0x00185A7E
	private Material GHHPOGODBHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E76 RID: 20086 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06004E77 RID: 20087 RVA: 0x001878B5 File Offset: 0x00185AB5
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E78 RID: 20088 RVA: 0x001878EC File Offset: 0x00185AEC
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E79 RID: 20089 RVA: 0x00187923 File Offset: 0x00185B23
	private Material LPPEPKGFOEM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E7A RID: 20090 RVA: 0x0018795C File Offset: 0x00185B5C
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 276f)
			{
				this.HBJJOCHGOPH = 741f;
			}
			this.ABHDNGIHBKE().SetFloat("_VelTex", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("original.tutorial", this.Greenness);
			this.MLMKCOINOOH().SetVector("Forward", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E7B RID: 20091 RVA: 0x00187A14 File Offset: 0x00185C14
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 72f)
			{
				this.HBJJOCHGOPH = 1012f;
			}
			this.LNLKMDPHDCC().SetFloat("/Saved Games/", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat(".a", this.Greenness);
			this.BBIMPFGLDCP().SetVector("#close", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E7C RID: 20092 RVA: 0x0018733C File Offset: 0x0018553C
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004E7D RID: 20093 RVA: 0x0018733C File Offset: 0x0018553C
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004E7E RID: 20094 RVA: 0x0018733C File Offset: 0x0018553C
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004E7F RID: 20095 RVA: 0x00187ACA File Offset: 0x00185CCA
	private void LFBGJIIECLD()
	{
		this.SCShader = Shader.Find("_Value6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004E80 RID: 20096 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06004E81 RID: 20097 RVA: 0x0018733C File Offset: 0x0018553C
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004E82 RID: 20098 RVA: 0x0018733C File Offset: 0x0018553C
	private void LAMEHAHJKMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004E83 RID: 20099 RVA: 0x00187AEE File Offset: 0x00185CEE
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("masterSteamID");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004E84 RID: 20100 RVA: 0x0018733C File Offset: 0x0018553C
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004E85 RID: 20101 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBPCODPOJAH()
	{
	}

	// Token: 0x06004E86 RID: 20102 RVA: 0x0002523B File Offset: 0x0002343B
	private void LKJMIODJGCM()
	{
	}

	// Token: 0x06004E87 RID: 20103 RVA: 0x00187B12 File Offset: 0x00185D12
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("_AlphaUV");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004E88 RID: 20104 RVA: 0x00187B36 File Offset: 0x00185D36
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("Save");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004E89 RID: 20105 RVA: 0x00187B5A File Offset: 0x00185D5A
	private void ODBNMPGBCGO()
	{
		this.SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004E8A RID: 20106 RVA: 0x00187B80 File Offset: 0x00185D80
	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1597f)
			{
				this.HBJJOCHGOPH = 1803f;
			}
			this.NFKFAAHHLLM().SetFloat("OnRelease", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("_ScreenResolution", this.Greenness);
			this.MFHPKGICPIO().SetVector("_InternalLutTex", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E8B RID: 20107 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06004E8C RID: 20108 RVA: 0x00187C36 File Offset: 0x00185E36
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)114;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E8D RID: 20109 RVA: 0x0002523B File Offset: 0x0002343B
	private void JCGMGLMADEN()
	{
	}

	// Token: 0x06004E8E RID: 20110 RVA: 0x00187C70 File Offset: 0x00185E70
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1404f)
			{
				this.HBJJOCHGOPH = 1057f;
			}
			this.LNLKMDPHDCC().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("JoinRandom failed: {0}.", this.Greenness);
			this.GKILCDHJFEG().SetVector("_Bullet_6", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E8F RID: 20111 RVA: 0x00187D26 File Offset: 0x00185F26
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("quit");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004E90 RID: 20112 RVA: 0x00187D4A File Offset: 0x00185F4A
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E91 RID: 20113 RVA: 0x0002523B File Offset: 0x0002343B
	private void KDJEJBBDILE()
	{
	}

	// Token: 0x06004E92 RID: 20114 RVA: 0x00187D84 File Offset: 0x00185F84
	private void GOANCMNGDLE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1721f)
			{
				this.HBJJOCHGOPH = 1690f;
			}
			this.BLMPMOIDGMG().SetFloat("x", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("_DepthLevel", this.Greenness);
			this.GKILCDHJFEG().SetVector("recipes", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E93 RID: 20115 RVA: 0x00187E3C File Offset: 0x0018603C
	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1637f)
			{
				this.HBJJOCHGOPH = 507f;
			}
			this.BBIMPFGLDCP().SetFloat("_Bullet_11", this.HBJJOCHGOPH);
			this.NJDIODJNGGA().SetFloat("_MainTexBlurred", this.Greenness);
			this.KEMAALEODNH().SetVector("LoadingStatusText", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E94 RID: 20116 RVA: 0x00187EF4 File Offset: 0x001860F4
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 876f)
			{
				this.HBJJOCHGOPH = 187f;
			}
			this.NJDIODJNGGA().SetFloat("ItemNameText", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("0 - background, 1 - foreground", this.Greenness);
			this.EOCCJGIGEGJ().SetVector("z", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E95 RID: 20117 RVA: 0x00187FAA File Offset: 0x001861AA
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("Joystick1Button5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004E96 RID: 20118 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x06004E97 RID: 20119 RVA: 0x00187FD0 File Offset: 0x001861D0
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1452f)
			{
				this.HBJJOCHGOPH = 436f;
			}
			this.KEMAALEODNH().SetFloat("DifficultyBG", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("[MenuScene] Error: ", this.Greenness);
			this.NJDIODJNGGA().SetVector("data", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E98 RID: 20120 RVA: 0x00188088 File Offset: 0x00186288
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 641f)
			{
				this.HBJJOCHGOPH = 1060f;
			}
			this.CEKJODEAMGB().SetFloat("_FarCamera", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("mapselector.filter.rateduponly", this.Greenness);
			this.NJDIODJNGGA().SetVector(".sav", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x170000E1 RID: 225
	// (get) Token: 0x06004E99 RID: 20121 RVA: 0x0018813E File Offset: 0x0018633E
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

	// Token: 0x06004E9A RID: 20122 RVA: 0x00188175 File Offset: 0x00186375
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E9B RID: 20123 RVA: 0x0002523B File Offset: 0x0002343B
	private void PNLKFANNOKO()
	{
	}

	// Token: 0x06004E9C RID: 20124 RVA: 0x001881AC File Offset: 0x001863AC
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 235f)
			{
				this.HBJJOCHGOPH = 1738f;
			}
			this.GHHPOGODBHB().SetFloat("_Value7", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("t", this.Greenness);
			this.NFKFAAHHLLM().SetVector("CONTRAST", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BBIMPFGLDCP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E9D RID: 20125 RVA: 0x00188262 File Offset: 0x00186462
	private Material BBIMPFGLDCP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)67;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E9E RID: 20126 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06004E9F RID: 20127 RVA: 0x0018733C File Offset: 0x0018553C
	private void AOKOLPEGHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004EA0 RID: 20128 RVA: 0x0018829C File Offset: 0x0018649C
	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 646f)
			{
				this.HBJJOCHGOPH = 1307f;
			}
			this.NFKFAAHHLLM().SetFloat("EventMenu", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("MenuScene", this.Greenness);
			this.MLMKCOINOOH().SetVector("[", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004EA1 RID: 20129 RVA: 0x0018733C File Offset: 0x0018553C
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004EA2 RID: 20130 RVA: 0x00188352 File Offset: 0x00186552
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004EA3 RID: 20131 RVA: 0x00188389 File Offset: 0x00186589
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004EA4 RID: 20132 RVA: 0x001883C0 File Offset: 0x001865C0
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004EA5 RID: 20133 RVA: 0x001883F8 File Offset: 0x001865F8
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1750f)
			{
				this.HBJJOCHGOPH = 1703f;
			}
			this.ABHDNGIHBKE().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("ChatInput", this.Greenness);
			this.NJDIODJNGGA().SetVector("restrictions", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004EA6 RID: 20134 RVA: 0x001884B0 File Offset: 0x001866B0
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 162f)
			{
				this.HBJJOCHGOPH = 1481f;
			}
			this.PGPEMMBJOOG().SetFloat("Alternative", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("_TimeX", this.Greenness);
			this.PGPEMMBJOOG().SetVector("Fade", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004EA7 RID: 20135 RVA: 0x0018733C File Offset: 0x0018553C
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004EA8 RID: 20136 RVA: 0x00188566 File Offset: 0x00186766
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004EA9 RID: 20137 RVA: 0x0018733C File Offset: 0x0018553C
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004EAA RID: 20138 RVA: 0x0018859D File Offset: 0x0018679D
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004EAB RID: 20139 RVA: 0x001885D4 File Offset: 0x001867D4
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("HostType: {0} ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004EAC RID: 20140 RVA: 0x001885F8 File Offset: 0x001867F8
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004EAD RID: 20141 RVA: 0x0018862F File Offset: 0x0018682F
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Oculus_NightVision3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004EAE RID: 20142 RVA: 0x00188653 File Offset: 0x00186853
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("player.xp");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004EAF RID: 20143 RVA: 0x00188677 File Offset: 0x00186877
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004EB0 RID: 20144 RVA: 0x001886AE File Offset: 0x001868AE
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Lut_TestMode");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004EB1 RID: 20145 RVA: 0x001886D2 File Offset: 0x001868D2
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004EB2 RID: 20146 RVA: 0x0002523B File Offset: 0x0002343B
	private void HEBOIFKBLGD()
	{
	}

	// Token: 0x06004EB3 RID: 20147 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06004EB4 RID: 20148 RVA: 0x001883C0 File Offset: 0x001865C0
	private Material NJDIODJNGGA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004EB5 RID: 20149 RVA: 0x0018733C File Offset: 0x0018553C
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004EB6 RID: 20150 RVA: 0x00188709 File Offset: 0x00186909
	private void EIMNPCMHJLJ()
	{
		this.SCShader = Shader.Find("SetPlayerDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004EB7 RID: 20151 RVA: 0x0018872D File Offset: 0x0018692D
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004EB8 RID: 20152 RVA: 0x0018733C File Offset: 0x0018553C
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004EB9 RID: 20153 RVA: 0x00188764 File Offset: 0x00186964
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1102f)
			{
				this.HBJJOCHGOPH = 1316f;
			}
			this.PDEAHJPOMEF().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("CameraFilterPack/Blend2Camera_LighterColor", this.Greenness);
			this.MLMKCOINOOH().SetVector("_TapHigh", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004EBA RID: 20154 RVA: 0x0018733C File Offset: 0x0018553C
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004EBB RID: 20155 RVA: 0x0018881A File Offset: 0x00186A1A
	private void ECBILENEOOL()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004EBC RID: 20156 RVA: 0x00188840 File Offset: 0x00186A40
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1722f)
			{
				this.HBJJOCHGOPH = 1653f;
			}
			this.OCHJIMJNEMO().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("CameraFilterPack/Color_GrayScale", this.Greenness);
			this.DBOLLHHMKKN().SetVector("settings.disablestoryboard", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004EBD RID: 20157 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x06004EBE RID: 20158 RVA: 0x001888F8 File Offset: 0x00186AF8
	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1026f)
			{
				this.HBJJOCHGOPH = 220f;
			}
			this.PDEAHJPOMEF().SetFloat(">", this.HBJJOCHGOPH);
			this.LPPEPKGFOEM().SetFloat("menu.selectedplaymode", this.Greenness);
			this.CEKJODEAMGB().SetVector("CameraFilterPack/FX_Funk", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004EBF RID: 20159 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x06004EC0 RID: 20160 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06004EC1 RID: 20161 RVA: 0x001889AE File Offset: 0x00186BAE
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004EC2 RID: 20162 RVA: 0x001889D4 File Offset: 0x00186BD4
	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 989f)
			{
				this.HBJJOCHGOPH = 1003f;
			}
			this.NLFJGMBCICG().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("Failed to InstantiateSceneObject prefab: ", this.Greenness);
			this.EOCCJGIGEGJ().SetVector("w", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004EC3 RID: 20163 RVA: 0x0018733C File Offset: 0x0018553C
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004EC4 RID: 20164 RVA: 0x00188A8A File Offset: 0x00186C8A
	private void NDBPCNICGLC()
	{
		this.SCShader = Shader.Find("_PositionX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004EC5 RID: 20165 RVA: 0x00188AB0 File Offset: 0x00186CB0
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 814f)
			{
				this.HBJJOCHGOPH = 1867f;
			}
			this.LPPEPKGFOEM().SetFloat("StandAloneInputSystem should not be used with the GamePadInputModule, please remove it from the Event System in this scene or disable it when this module is in use", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("_Value3", this.Greenness);
			this.BBIMPFGLDCP().SetVector("return ", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004EC6 RID: 20166 RVA: 0x0018733C File Offset: 0x0018553C
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004EC7 RID: 20167 RVA: 0x0018733C File Offset: 0x0018553C
	private void EDCMIPNCPLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004EC8 RID: 20168 RVA: 0x00188B66 File Offset: 0x00186D66
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004EC9 RID: 20169 RVA: 0x00188B9D File Offset: 0x00186D9D
	private Material MLMKCOINOOH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-81);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004ECB RID: 20171 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06004ECC RID: 20172 RVA: 0x00188BF2 File Offset: 0x00186DF2
	private Material BLMPMOIDGMG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004ECD RID: 20173 RVA: 0x00188C2C File Offset: 0x00186E2C
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 629f)
			{
				this.HBJJOCHGOPH = 29f;
			}
			this.NFKFAAHHLLM().SetFloat("z", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("AccuracyScoreText", this.Greenness);
			this.PDEAHJPOMEF().SetVector(".lastCheckpoint.checkpointsUsed", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004ECE RID: 20174 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x06004ECF RID: 20175 RVA: 0x0018733C File Offset: 0x0018553C
	private void PNNPDMHLFHE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004ED0 RID: 20176 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x06004ED1 RID: 20177 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x06004ED2 RID: 20178 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDBBPKIFNJ()
	{
	}

	// Token: 0x06004ED3 RID: 20179 RVA: 0x00188CE2 File Offset: 0x00186EE2
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find("settings.showHP");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004ED4 RID: 20180 RVA: 0x0018733C File Offset: 0x0018553C
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004ED5 RID: 20181 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x06004ED6 RID: 20182 RVA: 0x00188D06 File Offset: 0x00186F06
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004ED7 RID: 20183 RVA: 0x0018733C File Offset: 0x0018553C
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004ED8 RID: 20184 RVA: 0x00188D3D File Offset: 0x00186F3D
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004ED9 RID: 20185 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x04000841 RID: 2113
	public Shader SCShader;

	// Token: 0x04000842 RID: 2114
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000843 RID: 2115
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000844 RID: 2116
	private Material BJFKDHHMLJH;

	// Token: 0x04000845 RID: 2117
	[Range(0.2f, 2f)]
	public float Greenness = 1f;
}
