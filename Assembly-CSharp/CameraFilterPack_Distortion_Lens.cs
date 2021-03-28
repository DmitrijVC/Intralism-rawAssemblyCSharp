using System;
using UnityEngine;

// Token: 0x0200008F RID: 143
[AddComponentMenu("Camera Filter Pack/Distortion/Lens")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_Lens : MonoBehaviour
{
	// Token: 0x06002991 RID: 10641 RVA: 0x000E435A File Offset: 0x000E255A
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002992 RID: 10642 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06002993 RID: 10643 RVA: 0x000E4391 File Offset: 0x000E2591
	private void HAIAHJPCPAG()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_Laplacian");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002994 RID: 10644 RVA: 0x000E43B8 File Offset: 0x000E25B8
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1124f)
			{
				this.HBJJOCHGOPH = 1415f;
			}
			this.HCGJCMDJPGD().SetFloat("_FadeFX", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("[ItemsHandler] Item not found:", this.CenterX);
			this.NBPKMLMCHFN.SetFloat("colorD", this.CenterY);
			this.EMDFHOKEGNG().SetFloat("_Near", this.Distortion);
			this.LENEJAGLCNL().SetVector("LowMid", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002995 RID: 10645 RVA: 0x000E449C File Offset: 0x000E269C
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1626f)
			{
				this.HBJJOCHGOPH = 199f;
			}
			this.HEHKGPKLAKK().SetFloat("player.crystal", this.HBJJOCHGOPH);
			this.CEKJODEAMGB().SetFloat("st", this.CenterX);
			this.OCHJIMJNEMO().SetFloat(".icon", this.CenterY);
			this.CEKJODEAMGB().SetFloat("_Value7", this.Distortion);
			this.HEHKGPKLAKK().SetVector("UseScanLine", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002996 RID: 10646 RVA: 0x000E457E File Offset: 0x000E277E
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002997 RID: 10647 RVA: 0x000E457E File Offset: 0x000E277E
	private void ONPFGCEFMML()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002998 RID: 10648 RVA: 0x000E459B File Offset: 0x000E279B
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_Lens");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002999 RID: 10649 RVA: 0x000E45C0 File Offset: 0x000E27C0
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 936f)
			{
				this.HBJJOCHGOPH = 347f;
			}
			this.HEHKGPKLAKK().SetFloat("sprite", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("_ColorLevel", this.CenterX);
			this.NFKFAAHHLLM().SetFloat("SetPlayerDistance", this.CenterY);
			this.CEKJODEAMGB().SetFloat("w", this.Distortion);
			this.MMOODGIODPC().SetVector("_AOTex", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600299A RID: 10650 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x0600299B RID: 10651 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x0600299C RID: 10652 RVA: 0x000E46A2 File Offset: 0x000E28A2
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Pixel_Pixelisation");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600299D RID: 10653 RVA: 0x000E457E File Offset: 0x000E277E
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600299E RID: 10654 RVA: 0x000E457E File Offset: 0x000E277E
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600299F RID: 10655 RVA: 0x000E46C8 File Offset: 0x000E28C8
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 438f)
			{
				this.HBJJOCHGOPH = 1670f;
			}
			this.DKNJGHFLAIF().SetFloat("CameraFilterPack/TV_Old", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("TStart", this.CenterX);
			this.PLBEJJIHFPB().SetFloat("]", this.CenterY);
			this.MMOODGIODPC().SetFloat("InstantiateRpc", this.Distortion);
			this.EPCGJFCCAFH().SetVector(" canvas not found", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060029A0 RID: 10656 RVA: 0x000E47AA File Offset: 0x000E29AA
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060029A1 RID: 10657 RVA: 0x000E47E4 File Offset: 0x000E29E4
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 619f)
			{
				this.HBJJOCHGOPH = 215f;
			}
			this.NBPKMLMCHFN.SetFloat("_Alpha", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetFloat("[MapEditor] Loading map: ", this.CenterX);
			this.HCGJCMDJPGD().SetFloat("maps.", this.CenterY);
			this.OCHJIMJNEMO().SetFloat("MusicFileSelector", this.Distortion);
			this.ABHDNGIHBKE().SetVector("z", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060029A2 RID: 10658 RVA: 0x000E457E File Offset: 0x000E277E
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060029A3 RID: 10659 RVA: 0x000E48C6 File Offset: 0x000E2AC6
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060029A4 RID: 10660 RVA: 0x000E457E File Offset: 0x000E277E
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060029A5 RID: 10661 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x060029A6 RID: 10662 RVA: 0x000E48FD File Offset: 0x000E2AFD
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060029A7 RID: 10663 RVA: 0x000E4934 File Offset: 0x000E2B34
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("No Name");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060029A8 RID: 10664 RVA: 0x000E4958 File Offset: 0x000E2B58
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060029A9 RID: 10665 RVA: 0x000E498F File Offset: 0x000E2B8F
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-86);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060029AA RID: 10666 RVA: 0x000E49C6 File Offset: 0x000E2BC6
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060029AB RID: 10667 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x060029AC RID: 10668 RVA: 0x000E457E File Offset: 0x000E277E
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060029AD RID: 10669 RVA: 0x000E4A00 File Offset: 0x000E2C00
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1769f)
			{
				this.HBJJOCHGOPH = 1160f;
			}
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("CameraFilterPack/TV_WideScreenVertical", this.CenterX);
			this.HCGJCMDJPGD().SetFloat("_Value2", this.CenterY);
			this.IONHGBPGCHK().SetFloat("_TileTexDebug", this.Distortion);
			this.HEHKGPKLAKK().SetVector("CameraFilterPack/Oculus_NightVision5", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060029AE RID: 10670 RVA: 0x000E4AE2 File Offset: 0x000E2CE2
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060029AF RID: 10671 RVA: 0x000E4B19 File Offset: 0x000E2D19
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("_Distance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060029B0 RID: 10672 RVA: 0x000E4B3D File Offset: 0x000E2D3D
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060029B1 RID: 10673 RVA: 0x000E4B64 File Offset: 0x000E2D64
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1778f)
			{
				this.HBJJOCHGOPH = 1386f;
			}
			this.MFHPKGICPIO().SetFloat("OK", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("R:", this.CenterX);
			this.GKILCDHJFEG().SetFloat("Texture3", this.CenterY);
			this.GKILCDHJFEG().SetFloat("TwoHands", this.Distortion);
			this.EPCGJFCCAFH().SetVector("Loaded Game: ", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060029B2 RID: 10674 RVA: 0x000E4C46 File Offset: 0x000E2E46
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060029B3 RID: 10675 RVA: 0x000E4C7D File Offset: 0x000E2E7D
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060029B4 RID: 10676 RVA: 0x000E4CB4 File Offset: 0x000E2EB4
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find("Curve texture");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060029B5 RID: 10677 RVA: 0x000E4CD8 File Offset: 0x000E2ED8
	private void PMPKMGKAAJH()
	{
		this.SCShader = Shader.Find("#,0.00");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060029B6 RID: 10678 RVA: 0x000E4CFC File Offset: 0x000E2EFC
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060029B7 RID: 10679 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x060029B8 RID: 10680 RVA: 0x000E4D33 File Offset: 0x000E2F33
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060029B9 RID: 10681 RVA: 0x000E457E File Offset: 0x000E277E
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060029BA RID: 10682 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x060029BB RID: 10683 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x060029BC RID: 10684 RVA: 0x000E457E File Offset: 0x000E277E
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060029BD RID: 10685 RVA: 0x000E4D6C File Offset: 0x000E2F6C
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1920f)
			{
				this.HBJJOCHGOPH = 1983f;
			}
			this.GKILCDHJFEG().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("QuickSave", this.CenterX);
			this.KEMJNOMIPHN().SetFloat("Object ID. Case-Sensitive", this.CenterY);
			this.HCGJCMDJPGD().SetFloat("InfoButton", this.Distortion);
			this.OCHJIMJNEMO().SetVector(".lastCheckpoint.powerupsScore", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060029BE RID: 10686 RVA: 0x000E4E4E File Offset: 0x000E304E
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060029BF RID: 10687 RVA: 0x000E4E72 File Offset: 0x000E3072
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060029C0 RID: 10688 RVA: 0x000E457E File Offset: 0x000E277E
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060029C1 RID: 10689 RVA: 0x000E4EAC File Offset: 0x000E30AC
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 152f)
			{
				this.HBJJOCHGOPH = 152f;
			}
			this.NFKFAAHHLLM().SetFloat("Connection error: ", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("SetParticlesEmission", this.CenterX);
			this.KEMJNOMIPHN().SetFloat("_Value3", this.CenterY);
			this.LENEJAGLCNL().SetFloat("CameraFilterPack/Distortion_Half_Sphere", this.Distortion);
			this.KEMJNOMIPHN().SetVector("_NoiseTex", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060029C2 RID: 10690 RVA: 0x000E4F8E File Offset: 0x000E318E
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060029C3 RID: 10691 RVA: 0x000E457E File Offset: 0x000E277E
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000074 RID: 116
	// (get) Token: 0x060029C4 RID: 10692 RVA: 0x000E4FC5 File Offset: 0x000E31C5
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

	// Token: 0x060029C5 RID: 10693 RVA: 0x000E457E File Offset: 0x000E277E
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060029C6 RID: 10694 RVA: 0x000E457E File Offset: 0x000E277E
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060029C7 RID: 10695 RVA: 0x000E4FFC File Offset: 0x000E31FC
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060029C8 RID: 10696 RVA: 0x000E457E File Offset: 0x000E277E
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060029C9 RID: 10697 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x060029CA RID: 10698 RVA: 0x000E457E File Offset: 0x000E277E
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060029CB RID: 10699 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x060029CC RID: 10700 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x060029CD RID: 10701 RVA: 0x000E457E File Offset: 0x000E277E
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060029CE RID: 10702 RVA: 0x000E5033 File Offset: 0x000E3233
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find("_Threshhold");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060029D0 RID: 10704 RVA: 0x000E5075 File Offset: 0x000E3275
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060029D1 RID: 10705 RVA: 0x000E50AC File Offset: 0x000E32AC
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find(" This is not possible to be called for standalone input. Please check your platform and code where this is called");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060029D2 RID: 10706 RVA: 0x000E50D0 File Offset: 0x000E32D0
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060029D3 RID: 10707 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060029D4 RID: 10708 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x060029D5 RID: 10709 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x060029D6 RID: 10710 RVA: 0x000E5108 File Offset: 0x000E3308
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
			this.NBPKMLMCHFN.SetFloat("_CenterX", this.CenterX);
			this.NBPKMLMCHFN.SetFloat("_CenterY", this.CenterY);
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Distortion);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060029D7 RID: 10711 RVA: 0x000E51EA File Offset: 0x000E33EA
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)110;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060029D8 RID: 10712 RVA: 0x000E5221 File Offset: 0x000E3421
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find(".lastCheckpoint.lives");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060029D9 RID: 10713 RVA: 0x000E5248 File Offset: 0x000E3448
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 190f)
			{
				this.HBJJOCHGOPH = 163f;
			}
			this.OCHJIMJNEMO().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("AccuracyScoreText", this.CenterX);
			this.LENEJAGLCNL().SetFloat("#8E8E8EFF", this.CenterY);
			this.IIJMIPBMMBF().SetFloat("_Near", this.Distortion);
			this.CEKJODEAMGB().SetVector("B:", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060029DA RID: 10714 RVA: 0x000E532A File Offset: 0x000E352A
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("(\\[ */ *h1 *\\])");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060029DB RID: 10715 RVA: 0x000E5350 File Offset: 0x000E3550
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 385f)
			{
				this.HBJJOCHGOPH = 1252f;
			}
			this.NBPKMLMCHFN.SetFloat("_SpawnHeuristic", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("getstring", this.CenterX);
			this.OCHJIMJNEMO().SetFloat("_Heigh", this.CenterY);
			this.HCGJCMDJPGD().SetFloat("_TimeX", this.Distortion);
			this.EMDFHOKEGNG().SetVector("_BlurFilterDistance", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060029DC RID: 10716 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x060029DD RID: 10717 RVA: 0x000E5432 File Offset: 0x000E3632
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("_Blend");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060029DE RID: 10718 RVA: 0x000E5456 File Offset: 0x000E3656
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060029DF RID: 10719 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x060029E0 RID: 10720 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x060029E1 RID: 10721 RVA: 0x000E547A File Offset: 0x000E367A
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("Called GetNumberOfCurrentPlayers()");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060029E2 RID: 10722 RVA: 0x000E54A0 File Offset: 0x000E36A0
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1443f)
			{
				this.HBJJOCHGOPH = 1118f;
			}
			this.NBPKMLMCHFN.SetFloat("_ThirdTex", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("PLEASE WAIT", this.CenterX);
			this.NBPKMLMCHFN.SetFloat("_PColor", this.CenterY);
			this.HEHKGPKLAKK().SetFloat("_TimeX", this.Distortion);
			this.OCHJIMJNEMO().SetVector("{0}\n{1}\n{2}\n{3}\n{4}\n{5}", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060029E3 RID: 10723 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x060029E4 RID: 10724 RVA: 0x000E5584 File Offset: 0x000E3784
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1129f)
			{
				this.HBJJOCHGOPH = 1954f;
			}
			this.CEKJODEAMGB().SetFloat("maps.", this.HBJJOCHGOPH);
			this.CEKJODEAMGB().SetFloat("SetRoomStartTimestamp", this.CenterX);
			this.DKNJGHFLAIF().SetFloat("_Value3", this.CenterY);
			this.KGOLDDBHIFN().SetFloat("{0:0} day{1}, ", this.Distortion);
			this.KEMJNOMIPHN().SetVector("PLEASE WAIT", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060029E5 RID: 10725 RVA: 0x000E5666 File Offset: 0x000E3866
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("_VelocityScale");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0400050B RID: 1291
	public Shader SCShader;

	// Token: 0x0400050C RID: 1292
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400050D RID: 1293
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400050E RID: 1294
	private Material BJFKDHHMLJH;

	// Token: 0x0400050F RID: 1295
	[Range(-1f, 1f)]
	public float CenterX;

	// Token: 0x04000510 RID: 1296
	[Range(-1f, 1f)]
	public float CenterY;

	// Token: 0x04000511 RID: 1297
	[Range(0f, 3f)]
	public float Distortion = 1f;
}
