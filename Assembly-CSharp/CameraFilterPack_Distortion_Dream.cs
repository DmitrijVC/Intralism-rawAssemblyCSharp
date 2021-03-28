using System;
using UnityEngine;

// Token: 0x02000088 RID: 136
[AddComponentMenu("Camera Filter Pack/Distortion/Dream")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_Dream : MonoBehaviour
{
	// Token: 0x060026E1 RID: 9953 RVA: 0x000DB113 File Offset: 0x000D9313
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060026E2 RID: 9954 RVA: 0x000DB130 File Offset: 0x000D9330
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060026E3 RID: 9955 RVA: 0x000DB168 File Offset: 0x000D9368
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 440f)
			{
				this.HBJJOCHGOPH = 1958f;
			}
			this.CFEDGDGBCHE().SetFloat("[ItemsHandler] Item not found:", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetFloat(" beatThreshold: ", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060026E4 RID: 9956 RVA: 0x000DB1F8 File Offset: 0x000D93F8
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060026E5 RID: 9957 RVA: 0x000DB113 File Offset: 0x000D9313
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060026E6 RID: 9958 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x1700006D RID: 109
	// (get) Token: 0x060026E7 RID: 9959 RVA: 0x000DB21C File Offset: 0x000D941C
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

	// Token: 0x060026E8 RID: 9960 RVA: 0x000DB113 File Offset: 0x000D9313
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060026E9 RID: 9961 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x060026EA RID: 9962 RVA: 0x000DB253 File Offset: 0x000D9453
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060026EB RID: 9963 RVA: 0x000DB277 File Offset: 0x000D9477
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_Dream");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060026EC RID: 9964 RVA: 0x000DB29B File Offset: 0x000D949B
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060026ED RID: 9965 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x060026EE RID: 9966 RVA: 0x000DB113 File Offset: 0x000D9313
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060026EF RID: 9967 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x060026F0 RID: 9968 RVA: 0x000DB2D2 File Offset: 0x000D94D2
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060026F1 RID: 9969 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x060026F2 RID: 9970 RVA: 0x000DB2F6 File Offset: 0x000D94F6
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060026F3 RID: 9971 RVA: 0x000DB330 File Offset: 0x000D9530
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1505f)
			{
				this.HBJJOCHGOPH = 1238f;
			}
			this.HCGJCMDJPGD().SetFloat("GlassesColor2", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("UpperMid", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060026F4 RID: 9972 RVA: 0x000DB113 File Offset: 0x000D9313
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060026F5 RID: 9973 RVA: 0x000DB253 File Offset: 0x000D9453
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060026F6 RID: 9974 RVA: 0x000DB113 File Offset: 0x000D9313
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060026F7 RID: 9975 RVA: 0x000DB3C0 File Offset: 0x000D95C0
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 323f)
			{
				this.HBJJOCHGOPH = 143f;
			}
			this.LENEJAGLCNL().SetFloat("ERROR: Steam App ID isn't set! Make sure 'steam_appid.txt' is placed next to the executable file, and contains a single line with the app id.", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Found best region: '", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060026F8 RID: 9976 RVA: 0x000DB450 File Offset: 0x000D9650
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1322f)
			{
				this.HBJJOCHGOPH = 380f;
			}
			this.DNLMFEGJJDD().SetFloat("?", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("_Distortion", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060026F9 RID: 9977 RVA: 0x000DB4E0 File Offset: 0x000D96E0
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1317f)
			{
				this.HBJJOCHGOPH = 130f;
			}
			this.DNLMFEGJJDD().SetFloat("float,2", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("Unable to get a reward! Try again?", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060026FA RID: 9978 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x060026FB RID: 9979 RVA: 0x000DB570 File Offset: 0x000D9770
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1726f)
			{
				this.HBJJOCHGOPH = 1863f;
			}
			this.HCGJCMDJPGD().SetFloat("steamid", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Mid", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060026FC RID: 9980 RVA: 0x000DB600 File Offset: 0x000D9800
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060026FD RID: 9981 RVA: 0x000DB624 File Offset: 0x000D9824
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060026FE RID: 9982 RVA: 0x000DB648 File Offset: 0x000D9848
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1653f)
			{
				this.HBJJOCHGOPH = 1087f;
			}
			this.NFMGLIKNOOC().SetFloat(" PhotonView: ", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("-1", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060026FF RID: 9983 RVA: 0x000DB6D8 File Offset: 0x000D98D8
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 755f)
			{
				this.HBJJOCHGOPH = 1992f;
			}
			this.HEINDEMCGIK().SetFloat("elapsed: {0:0.000}", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("CameraFilterPack/Blur_Focus", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002700 RID: 9984 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x06002701 RID: 9985 RVA: 0x000DB768 File Offset: 0x000D9968
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002702 RID: 9986 RVA: 0x000DB113 File Offset: 0x000D9313
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002703 RID: 9987 RVA: 0x000DB79F File Offset: 0x000D999F
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002704 RID: 9988 RVA: 0x000DB113 File Offset: 0x000D9313
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002705 RID: 9989 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06002706 RID: 9990 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06002707 RID: 9991 RVA: 0x000DB7D6 File Offset: 0x000D99D6
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002708 RID: 9992 RVA: 0x000DB80D File Offset: 0x000D9A0D
	private void FANADGBGCPI()
	{
		this.SCShader = Shader.Find("Cannot remove cached RPCs on a PhotonView thats not ours! ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002709 RID: 9993 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x0600270A RID: 9994 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x0600270B RID: 9995 RVA: 0x000DB831 File Offset: 0x000D9A31
	private Material IFMAPIDFNLI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600270C RID: 9996 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x0600270D RID: 9997 RVA: 0x000DB868 File Offset: 0x000D9A68
	private Material BKKJJJGADLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600270F RID: 9999 RVA: 0x000DB8BD File Offset: 0x000D9ABD
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("Left");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002710 RID: 10000 RVA: 0x000DB8E1 File Offset: 0x000D9AE1
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002711 RID: 10001 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06002712 RID: 10002 RVA: 0x000DB908 File Offset: 0x000D9B08
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1787f)
			{
				this.HBJJOCHGOPH = 1140f;
			}
			this.IFMAPIDFNLI().SetFloat("_Size", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Blue_G", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002713 RID: 10003 RVA: 0x000DB998 File Offset: 0x000D9B98
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1094f)
			{
				this.HBJJOCHGOPH = 1453f;
			}
			this.NFMGLIKNOOC().SetFloat("_UV_Transform", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetFloat("HitVariationSlider", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002714 RID: 10004 RVA: 0x000DBA28 File Offset: 0x000D9C28
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find("_ColorRGB");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002715 RID: 10005 RVA: 0x000DB113 File Offset: 0x000D9313
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002716 RID: 10006 RVA: 0x000DBA4C File Offset: 0x000D9C4C
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002717 RID: 10007 RVA: 0x000DB113 File Offset: 0x000D9313
	private void IEFMONDKKJN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002718 RID: 10008 RVA: 0x000DBA70 File Offset: 0x000D9C70
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 28f)
			{
				this.HBJJOCHGOPH = 603f;
			}
			this.CFEDGDGBCHE().SetFloat(":", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat("Created", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002719 RID: 10009 RVA: 0x000DBB00 File Offset: 0x000D9D00
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
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600271A RID: 10010 RVA: 0x000DBB90 File Offset: 0x000D9D90
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600271B RID: 10011 RVA: 0x000DBBC8 File Offset: 0x000D9DC8
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 328f)
			{
				this.HBJJOCHGOPH = 154f;
			}
			this.ADGHJOHKEHG().SetFloat("#E14FFF", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("_ScreenResolution", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600271C RID: 10012 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x0600271D RID: 10013 RVA: 0x000DBC58 File Offset: 0x000D9E58
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1581f)
			{
				this.HBJJOCHGOPH = 1095f;
			}
			this.LDNADDJMIPK().SetFloat("PunSupportLogger", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("Screenshots only supported in PlayMode", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600271E RID: 10014 RVA: 0x000DB113 File Offset: 0x000D9313
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600271F RID: 10015 RVA: 0x000DBCE8 File Offset: 0x000D9EE8
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002720 RID: 10016 RVA: 0x000DBD1F File Offset: 0x000D9F1F
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("#score");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002721 RID: 10017 RVA: 0x000DBD43 File Offset: 0x000D9F43
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Light_Rainbow2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002722 RID: 10018 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x06002723 RID: 10019 RVA: 0x000DBD67 File Offset: 0x000D9F67
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002724 RID: 10020 RVA: 0x000DBD8B File Offset: 0x000D9F8B
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002725 RID: 10021 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x06002726 RID: 10022 RVA: 0x000DBDC4 File Offset: 0x000D9FC4
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 315f)
			{
				this.HBJJOCHGOPH = 1455f;
			}
			this.BKKJJJGADLM().SetFloat("Items/", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("_Value3", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002727 RID: 10023 RVA: 0x000DBE54 File Offset: 0x000DA054
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("SetRotation");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002728 RID: 10024 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06002729 RID: 10025 RVA: 0x000DBE78 File Offset: 0x000DA078
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1235f)
			{
				this.HBJJOCHGOPH = 571f;
			}
			this.HCGJCMDJPGD().SetFloat("Fade", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("Horizontal", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600272A RID: 10026 RVA: 0x000DBF08 File Offset: 0x000DA108
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 911f)
			{
				this.HBJJOCHGOPH = 684f;
			}
			this.BKKJJJGADLM().SetFloat("menu.enableselectormusic", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("[NetworkManager] Join failed", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600272B RID: 10027 RVA: 0x000DBF98 File Offset: 0x000DA198
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 742f)
			{
				this.HBJJOCHGOPH = 227f;
			}
			this.IFMAPIDFNLI().SetFloat("buttons", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("_TimeX", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600272C RID: 10028 RVA: 0x000DC028 File Offset: 0x000DA228
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600272D RID: 10029 RVA: 0x000DB113 File Offset: 0x000D9313
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600272E RID: 10030 RVA: 0x000DC060 File Offset: 0x000DA260
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 642f)
			{
				this.HBJJOCHGOPH = 1567f;
			}
			this.HEINDEMCGIK().SetFloat("Sprite", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("_Radius", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600272F RID: 10031 RVA: 0x000DC0F0 File Offset: 0x000DA2F0
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002730 RID: 10032 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06002731 RID: 10033 RVA: 0x000DC128 File Offset: 0x000DA328
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1530f)
			{
				this.HBJJOCHGOPH = 1905f;
			}
			this.FHFLKLMFHOI().SetFloat("_Value", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("CameraFilterPack/Drawing_Paper3", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002732 RID: 10034 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06002733 RID: 10035 RVA: 0x0002523B File Offset: 0x0002343B
	private void PNLKFANNOKO()
	{
	}

	// Token: 0x06002734 RID: 10036 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x06002735 RID: 10037 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06002736 RID: 10038 RVA: 0x000DC1B8 File Offset: 0x000DA3B8
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find("Data/Editor/leveltemplate");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002737 RID: 10039 RVA: 0x000DB113 File Offset: 0x000D9313
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002738 RID: 10040 RVA: 0x000DC1DC File Offset: 0x000DA3DC
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 226f)
			{
				this.HBJJOCHGOPH = 1993f;
			}
			this.BKKJJJGADLM().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat(".ogg", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002739 RID: 10041 RVA: 0x000DB113 File Offset: 0x000D9313
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600273A RID: 10042 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x0600273B RID: 10043 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x0600273C RID: 10044 RVA: 0x000DC26C File Offset: 0x000DA46C
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600273D RID: 10045 RVA: 0x000DC2A3 File Offset: 0x000DA4A3
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600273E RID: 10046 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x0600273F RID: 10047 RVA: 0x000DB113 File Offset: 0x000D9313
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002740 RID: 10048 RVA: 0x000DC2DC File Offset: 0x000DA4DC
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1840f)
			{
				this.HBJJOCHGOPH = 795f;
			}
			this.LENEJAGLCNL().SetFloat("player.egglipszerotwo", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetFloat(" not exist", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x040004E4 RID: 1252
	public Shader SCShader;

	// Token: 0x040004E5 RID: 1253
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040004E6 RID: 1254
	[Range(1f, 10f)]
	public float Distortion = 1f;

	// Token: 0x040004E7 RID: 1255
	private Material BJFKDHHMLJH;
}
