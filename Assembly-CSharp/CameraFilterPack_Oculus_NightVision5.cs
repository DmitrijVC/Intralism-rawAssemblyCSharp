using System;
using System.Runtime.CompilerServices;
using UnityEngine;

// Token: 0x020000FD RID: 253
[AddComponentMenu("Camera Filter Pack/Night Vision/Night Vision 5")]
[ExecuteInEditMode]
public class CameraFilterPack_Oculus_NightVision5 : MonoBehaviour
{
	// Token: 0x06004EDA RID: 20186 RVA: 0x00188D74 File Offset: 0x00186F74
	private void ODMPMJPALID()
	{
		this.MIPGPMKJELI();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004EDB RID: 20187 RVA: 0x00188D9F File Offset: 0x00186F9F
	private Material MNLKBFFKHIE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004EDC RID: 20188 RVA: 0x00188DD6 File Offset: 0x00186FD6
	private void OnValidate()
	{
		this.MIPGPMKJELI();
	}

	// Token: 0x06004EDD RID: 20189 RVA: 0x00188DDE File Offset: 0x00186FDE
	private void AEMGPJDJGBJ()
	{
		this.MIPGPMKJELI();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004EDE RID: 20190 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x06004EDF RID: 20191 RVA: 0x00188E0C File Offset: 0x0018700C
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 644f)
			{
				this.HBJJOCHGOPH = 1602f;
			}
			this.CECICEGFHKL().SetFloat("_BlurTex", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("</color>", this.PLKFKNHPEHE[1] / 480f);
			this.HEHKGPKLAKK().SetFloat("_EmissionColor", this.PLKFKNHPEHE[0] / 463f);
			this.HEHKGPKLAKK().SetFloat(".", this.PLKFKNHPEHE[1] / 137f);
			this.CECICEGFHKL().SetFloat("Preparing content", this.PLKFKNHPEHE[0] / 624f);
			this.DOMEEFLPEPJ().SetFloat("GlassColor", this.PLKFKNHPEHE[1] / 793f);
			this.MHBAIEKFBIJ().SetFloat("in seconds. 0 - forever", this.PLKFKNHPEHE[2] / 115f);
			this.OCMBHMLNCEK().SetFloat("/../", this.PLKFKNHPEHE[3] / 273f);
			this.CFEDGDGBCHE().SetFloat(" not exist", this.PLKFKNHPEHE[4] / 1504f);
			this.KJMECMIGJJA().SetFloat("_TimeX", this.PLKFKNHPEHE[1] / 1893f);
			this.KJMECMIGJJA().SetFloat("_LightIntensity", this.PLKFKNHPEHE[-75] / 439f);
			this.MHBAIEKFBIJ().SetFloat("SpectateButton", this.PLKFKNHPEHE[-16] / 1410f);
			this.MCDGIILBNIF().SetFloat("Vertical", this.PLKFKNHPEHE[53] / 1143f);
			this.DOMEEFLPEPJ().SetFloat("SpawnObj", this.FadeFX);
			this.NMDBCDFPGOK().SetFloat("BitsData", this._Size);
			this.HEHKGPKLAKK().SetFloat("_Value2", this._Dist);
			this.LDNADDJMIPK().SetFloat("#alreadystarted", this._Smooth);
			this.NBPKMLMCHFN.SetVector("_Offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 828f, 754f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004EE0 RID: 20192 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDBBPKIFNJ()
	{
	}

	// Token: 0x06004EE1 RID: 20193 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJHFOBHJEHL()
	{
	}

	// Token: 0x06004EE2 RID: 20194 RVA: 0x00189076 File Offset: 0x00187276
	private void ELJEHKEHFLM()
	{
		this.NBOEFDOKHLE();
	}

	// Token: 0x06004EE3 RID: 20195 RVA: 0x00189080 File Offset: 0x00187280
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
			this.NBPKMLMCHFN.SetFloat("_Red_R", this.PLKFKNHPEHE[0] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Red_G", this.PLKFKNHPEHE[1] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Red_B", this.PLKFKNHPEHE[2] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Green_R", this.PLKFKNHPEHE[3] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Green_G", this.PLKFKNHPEHE[4] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Green_B", this.PLKFKNHPEHE[5] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Blue_R", this.PLKFKNHPEHE[6] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Blue_G", this.PLKFKNHPEHE[7] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Blue_B", this.PLKFKNHPEHE[8] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Red_C", this.PLKFKNHPEHE[9] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Green_C", this.PLKFKNHPEHE[10] / 100f);
			this.NBPKMLMCHFN.SetFloat("_Blue_C", this.PLKFKNHPEHE[11] / 100f);
			this.NBPKMLMCHFN.SetFloat("_FadeFX", this.FadeFX);
			this.NBPKMLMCHFN.SetFloat("_Size", this._Size);
			this.NBPKMLMCHFN.SetFloat("_Dist", this._Dist);
			this.NBPKMLMCHFN.SetFloat("_Smooth", this._Smooth);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004EE4 RID: 20196 RVA: 0x001892EA File Offset: 0x001874EA
	private void BKIGIIINEDH()
	{
		this.FALHNNJBOEM();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004EE5 RID: 20197 RVA: 0x00189315 File Offset: 0x00187515
	private void NPLCENPNJBM()
	{
		this.GKNPHGOHOAE();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004EE6 RID: 20198 RVA: 0x00189340 File Offset: 0x00187540
	private void FALHNNJBOEM()
	{
		float[] array = new float[-37];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004EE7 RID: 20199 RVA: 0x0018935A File Offset: 0x0018755A
	private void PBKELEKDBIC()
	{
		float[] array = new float[-50];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004EE8 RID: 20200 RVA: 0x00189374 File Offset: 0x00187574
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 122f)
			{
				this.HBJJOCHGOPH = 1739f;
			}
			this.MCDGIILBNIF().SetFloat("CameraFilterPack/TV_Chromatical2", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat(".played", this.PLKFKNHPEHE[0] / 1338f);
			this.HEHKGPKLAKK().SetFloat("type", this.PLKFKNHPEHE[0] / 447f);
			this.CFEDGDGBCHE().SetFloat("_BlurredColor", this.PLKFKNHPEHE[5] / 1160f);
			this.KJMECMIGJJA().SetFloat(" not exist", this.PLKFKNHPEHE[5] / 1163f);
			this.HEHKGPKLAKK().SetFloat("_Value6", this.PLKFKNHPEHE[8] / 648f);
			this.MCDGIILBNIF().SetFloat("</color>", this.PLKFKNHPEHE[2] / 832f);
			this.NJDIODJNGGA().SetFloat("Fade", this.PLKFKNHPEHE[6] / 1476f);
			this.KLKILLCHJHO().SetFloat("1", this.PLKFKNHPEHE[8] / 691f);
			this.DOMEEFLPEPJ().SetFloat("_TimeX", this.PLKFKNHPEHE[6] / 220f);
			this.MCDGIILBNIF().SetFloat("GlassDistortion", this.PLKFKNHPEHE[18] / 1095f);
			this.CFEDGDGBCHE().SetFloat("a", this.PLKFKNHPEHE[-37] / 1193f);
			this.DOMEEFLPEPJ().SetFloat("Data/Skins/", this.PLKFKNHPEHE[-15] / 1637f);
			this.KOHGPKOFEJO().SetFloat("Unsupported type: ", this.FadeFX);
			this.KOHGPKOFEJO().SetFloat("CameraFilterPack/Distortion_FishEye", this._Size);
			this.DIOAAHJDMLK().SetFloat("_ColorRGB", this._Dist);
			this.ABHDNGIHBKE().SetFloat("SlidingArea", this._Smooth);
			this.HNFFHCLNBDN().SetVector("#close", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1369f, 943f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004EE9 RID: 20201 RVA: 0x001895DE File Offset: 0x001877DE
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004EEA RID: 20202 RVA: 0x00189615 File Offset: 0x00187815
	private void DHEHFFJDFCD()
	{
		this.LGHFFANDDCM();
	}

	// Token: 0x06004EEB RID: 20203 RVA: 0x0018961D File Offset: 0x0018781D
	private Material DIOAAHJDMLK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004EEC RID: 20204 RVA: 0x00189654 File Offset: 0x00187854
	private void MNHCBAKPBCF()
	{
		this.MPJAFNJLBEF();
	}

	// Token: 0x06004EED RID: 20205 RVA: 0x0018965C File Offset: 0x0018785C
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004EEE RID: 20206 RVA: 0x00189679 File Offset: 0x00187879
	private void DGEAFNJFHHA()
	{
		this.IKNKJMNFFOG();
	}

	// Token: 0x06004EEF RID: 20207 RVA: 0x00189681 File Offset: 0x00187881
	private void KKDDHFJOAAD()
	{
		this.FALHNNJBOEM();
	}

	// Token: 0x06004EF0 RID: 20208 RVA: 0x0018965C File Offset: 0x0018785C
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004EF1 RID: 20209 RVA: 0x00189689 File Offset: 0x00187889
	private void KOJKBFDNGDK()
	{
		this.PEKADICCGAG();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004EF2 RID: 20210 RVA: 0x001896B4 File Offset: 0x001878B4
	private void DIPDEHOOBPG()
	{
		this.KNLDBHHKFPF();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004EF3 RID: 20211 RVA: 0x0018965C File Offset: 0x0018785C
	private void NNBCLMJGFEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004EF4 RID: 20212 RVA: 0x0018965C File Offset: 0x0018785C
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004EF5 RID: 20213 RVA: 0x001896DF File Offset: 0x001878DF
	private void NBOEFDOKHLE()
	{
		float[] array = new float[-64];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004EF6 RID: 20214 RVA: 0x001896F9 File Offset: 0x001878F9
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004EF7 RID: 20215 RVA: 0x00189730 File Offset: 0x00187930
	private void IPJFFIDBPFE()
	{
		this.NBOEFDOKHLE();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004EF8 RID: 20216 RVA: 0x0018975B File Offset: 0x0018795B
	private void PPBFGGFIDKP()
	{
		float[] array = new float[-99];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004EF9 RID: 20217 RVA: 0x00189775 File Offset: 0x00187975
	private void MDNHCLKNCLE()
	{
		this.PPBFGGFIDKP();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004EFA RID: 20218 RVA: 0x001897A0 File Offset: 0x001879A0
	private void OEGEBCOIAHN()
	{
		this.MGGFMCIGOAF();
	}

	// Token: 0x06004EFB RID: 20219 RVA: 0x001897A8 File Offset: 0x001879A8
	private Material NJDIODJNGGA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004EFC RID: 20220 RVA: 0x0018965C File Offset: 0x0018785C
	private void JAFOCEDILNK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004EFE RID: 20222 RVA: 0x0018965C File Offset: 0x0018785C
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004EFF RID: 20223 RVA: 0x00189838 File Offset: 0x00187A38
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1567f)
			{
				this.HBJJOCHGOPH = 511f;
			}
			this.CFEDGDGBCHE().SetFloat("Error: you cannot read this stream that you are writing!", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("maps.", this.PLKFKNHPEHE[1] / 759f);
			this.NJDIODJNGGA().SetFloat(" GameServer:", this.PLKFKNHPEHE[0] / 341f);
			this.KLKILLCHJHO().SetFloat("CameraFilterPack/Blend2Camera_Screen", this.PLKFKNHPEHE[1] / 1295f);
			this.OCMBHMLNCEK().SetFloat("NetworkCanvas", this.PLKFKNHPEHE[7] / 1798f);
			this.NJDIODJNGGA().SetFloat("_Fade", this.PLKFKNHPEHE[3] / 713f);
			this.NJDIODJNGGA().SetFloat("[MapsStats] Hash: ", this.PLKFKNHPEHE[1] / 829f);
			this.NBPKMLMCHFN.SetFloat("The other scroll rect doesnt support scrolling horizontally", this.PLKFKNHPEHE[8] / 1823f);
			this.ABHDNGIHBKE().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[6] / 1319f);
			this.DOMEEFLPEPJ().SetFloat("OnPickedUp", this.PLKFKNHPEHE[8] / 590f);
			this.NMDBCDFPGOK().SetFloat("mapselector.lastSearch", this.PLKFKNHPEHE[-51] / 1495f);
			this.HEHKGPKLAKK().SetFloat("Bad parameters for setbool! Use <key> <value>", this.PLKFKNHPEHE[-20] / 509f);
			this.MHBAIEKFBIJ().SetFloat("bad", this.PLKFKNHPEHE[-2] / 1888f);
			this.HEHKGPKLAKK().SetFloat("_ScreenResolution", this.FadeFX);
			this.MNLKBFFKHIE().SetFloat("Tab2Content", this._Size);
			this.LDNADDJMIPK().SetFloat("offsets", this._Dist);
			this.MHBAIEKFBIJ().SetFloat("_NoiseTex", this._Smooth);
			this.CECICEGFHKL().SetVector("max. lives color", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1996f, 129f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NMDBCDFPGOK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F00 RID: 20224 RVA: 0x001896B4 File Offset: 0x001878B4
	private void BEKMLIFILFP()
	{
		this.KNLDBHHKFPF();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004F01 RID: 20225 RVA: 0x00189AA2 File Offset: 0x00187CA2
	private Material KLKILLCHJHO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004F02 RID: 20226 RVA: 0x00188DDE File Offset: 0x00186FDE
	private void Start()
	{
		this.MIPGPMKJELI();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004F03 RID: 20227 RVA: 0x0018965C File Offset: 0x0018785C
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004F04 RID: 20228 RVA: 0x00189AD9 File Offset: 0x00187CD9
	private void MPHAMHBNCJF()
	{
		this.GDPAIILEEFC();
	}

	// Token: 0x06004F05 RID: 20229 RVA: 0x00189730 File Offset: 0x00187930
	private void MODENHKMKOC()
	{
		this.NBOEFDOKHLE();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004F06 RID: 20230 RVA: 0x00189AE4 File Offset: 0x00187CE4
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 819f)
			{
				this.HBJJOCHGOPH = 547f;
			}
			this.NBPKMLMCHFN.SetFloat("G:", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetFloat("DPADHOR", this.PLKFKNHPEHE[0] / 563f);
			this.HEHKGPKLAKK().SetFloat("System.Boolean", this.PLKFKNHPEHE[0] / 676f);
			this.CFEDGDGBCHE().SetFloat("Updated!", this.PLKFKNHPEHE[3] / 1221f);
			this.LDNADDJMIPK().SetFloat("OK", this.PLKFKNHPEHE[1] / 953f);
			this.CFEDGDGBCHE().SetFloat("Stream did not contain properly formatted byte array", this.PLKFKNHPEHE[0] / 541f);
			this.KOHGPKOFEJO().SetFloat("FPSToggle", this.PLKFKNHPEHE[2] / 74f);
			this.NMDBCDFPGOK().SetFloat("ItemTemplate", this.PLKFKNHPEHE[1] / 1624f);
			this.MHBAIEKFBIJ().SetFloat("_Alpha", this.PLKFKNHPEHE[2] / 720f);
			this.KLKILLCHJHO().SetFloat("maps.", this.PLKFKNHPEHE[6] / 937f);
			this.MHBAIEKFBIJ().SetFloat("PlayMusic", this.PLKFKNHPEHE[48] / 255f);
			this.DKNJGHFLAIF().SetFloat("#startofflinemessage", this.PLKFKNHPEHE[58] / 858f);
			this.ABHDNGIHBKE().SetFloat("Failed!", this.PLKFKNHPEHE[48] / 948f);
			this.MHBAIEKFBIJ().SetFloat("_color", this.FadeFX);
			this.NBPKMLMCHFN.SetFloat("MenuScene", this._Size);
			this.ABHDNGIHBKE().SetFloat("_PositionY", this._Dist);
			this.NMDBCDFPGOK().SetFloat("\" gets executed locally only, if at all.", this._Smooth);
			this.KLKILLCHJHO().SetVector(" : ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 432f, 1073f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F07 RID: 20231 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x06004F08 RID: 20232 RVA: 0x00189D50 File Offset: 0x00187F50
	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1332f)
			{
				this.HBJJOCHGOPH = 1691f;
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("_AlphaHexa", this.PLKFKNHPEHE[0] / 1617f);
			this.OCMBHMLNCEK().SetFloat("shader.none", this.PLKFKNHPEHE[0] / 1592f);
			this.LDNADDJMIPK().SetFloat("CameraFilterPack/Vision_Blood_Fast", this.PLKFKNHPEHE[7] / 904f);
			this.MCDGIILBNIF().SetFloat("Joystick1Button5", this.PLKFKNHPEHE[5] / 263f);
			this.KJMECMIGJJA().SetFloat("[DiscordController] Join request {0}#{1}: {2}", this.PLKFKNHPEHE[8] / 721f);
			this.KOHGPKOFEJO().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[4] / 1793f);
			this.LDNADDJMIPK().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[2] / 1771f);
			this.MNLKBFFKHIE().SetFloat("_Amount", this.PLKFKNHPEHE[1] / 946f);
			this.KOHGPKOFEJO().SetFloat("_NeutralTonemapperParams1", this.PLKFKNHPEHE[1] / 426f);
			this.HEHKGPKLAKK().SetFloat("_Value", this.PLKFKNHPEHE[109] / 220f);
			this.CECICEGFHKL().SetFloat("_EmissionGain", this.PLKFKNHPEHE[-118] / 639f);
			this.HNFFHCLNBDN().SetFloat("_MaxBlurRadius", this.PLKFKNHPEHE[-6] / 866f);
			this.CECICEGFHKL().SetFloat("float,2", this.FadeFX);
			this.CECICEGFHKL().SetFloat("sfxVolume", this._Size);
			this.NBPKMLMCHFN.SetFloat("1159514800", this._Dist);
			this.HNFFHCLNBDN().SetFloat("_TileMaxOffs", this._Smooth);
			this.LDNADDJMIPK().SetVector("Winter2020", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 420f, 1266f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F09 RID: 20233 RVA: 0x00189FBA File Offset: 0x001881BA
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004F0A RID: 20234 RVA: 0x0002523B File Offset: 0x0002343B
	private void FGNFILLNPJK()
	{
	}

	// Token: 0x06004F0B RID: 20235 RVA: 0x00189076 File Offset: 0x00187276
	private void LONLHFLPEJD()
	{
		this.NBOEFDOKHLE();
	}

	// Token: 0x06004F0C RID: 20236 RVA: 0x00189FF1 File Offset: 0x001881F1
	private void MIPGPMKJELI()
	{
		this.PLKFKNHPEHE = new float[]
		{
			200f,
			-200f,
			-200f,
			195f,
			4f,
			-160f,
			200f,
			-200f,
			-200f,
			-200f,
			10f,
			-200f
		};
	}

	// Token: 0x06004F0D RID: 20237 RVA: 0x0018A00B File Offset: 0x0018820B
	private void IMEPOCMPHDL()
	{
		this.PPBFGGFIDKP();
	}

	// Token: 0x06004F0E RID: 20238 RVA: 0x0018965C File Offset: 0x0018785C
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004F0F RID: 20239 RVA: 0x0018A013 File Offset: 0x00188213
	private void BOPKKCAFODF()
	{
		this.IKNKJMNFFOG();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004F10 RID: 20240 RVA: 0x0018A03E File Offset: 0x0018823E
	private void AGFGKIBHCBE()
	{
		this.IAIAGCGJGHI();
	}

	// Token: 0x06004F11 RID: 20241 RVA: 0x0018A046 File Offset: 0x00188246
	private void JILOMOBDPIA()
	{
		this.IAIAGCGJGHI();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004F12 RID: 20242 RVA: 0x0018A071 File Offset: 0x00188271
	private void DCGFEIBKOBB()
	{
		this.JGMPDINHNKD();
	}

	// Token: 0x06004F13 RID: 20243 RVA: 0x0018A07C File Offset: 0x0018827C
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 168f)
			{
				this.HBJJOCHGOPH = 380f;
			}
			this.KOHGPKOFEJO().SetFloat("Set particles size", this.HBJJOCHGOPH);
			this.MNLKBFFKHIE().SetFloat("Right", this.PLKFKNHPEHE[1] / 599f);
			this.KLKILLCHJHO().SetFloat("Chat", this.PLKFKNHPEHE[0] / 391f);
			this.CECICEGFHKL().SetFloat("LevelEditor/CustomEventEditor-", this.PLKFKNHPEHE[6] / 1870f);
			this.DKNJGHFLAIF().SetFloat("UpdateDownloadingProgress", this.PLKFKNHPEHE[1] / 1524f);
			this.DIOAAHJDMLK().SetFloat("maps.", this.PLKFKNHPEHE[8] / 213f);
			this.CECICEGFHKL().SetFloat("_DotSize", this.PLKFKNHPEHE[8] / 1768f);
			this.HNFFHCLNBDN().SetFloat("ConnectToMaster() failed. Can only connect while in state 'Disconnected'. Current state: ", this.PLKFKNHPEHE[8] / 484f);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.PLKFKNHPEHE[0] / 461f);
			this.LDNADDJMIPK().SetFloat("SetScale", this.PLKFKNHPEHE[3] / 1839f);
			this.HNFFHCLNBDN().SetFloat("_Saturation", this.PLKFKNHPEHE[-48] / 1019f);
			this.DOMEEFLPEPJ().SetFloat("ItemsUploader", this.PLKFKNHPEHE[-125] / 1272f);
			this.NMDBCDFPGOK().SetFloat("_CenterX", this.PLKFKNHPEHE[60] / 531f);
			this.OCMBHMLNCEK().SetFloat("_Value", this.FadeFX);
			this.NMDBCDFPGOK().SetFloat("_FgCocMask", this._Size);
			this.OCMBHMLNCEK().SetFloat("STICKRVER", this._Dist);
			this.DOMEEFLPEPJ().SetFloat("_Value2", this._Smooth);
			this.NBPKMLMCHFN.SetVector("_FarCorner", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 212f, 277f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F14 RID: 20244 RVA: 0x0018A2E8 File Offset: 0x001884E8
	private void EFNBMCKBNAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1221f)
			{
				this.HBJJOCHGOPH = 1805f;
			}
			this.ABHDNGIHBKE().SetFloat("CameraFilterPack/Vision_Tunnel", this.HBJJOCHGOPH);
			this.NJDIODJNGGA().SetFloat("loadscene", this.PLKFKNHPEHE[0] / 1839f);
			this.NBPKMLMCHFN.SetFloat("settings_bindings_", this.PLKFKNHPEHE[1] / 684f);
			this.NJDIODJNGGA().SetFloat("_StretchWidth", this.PLKFKNHPEHE[1] / 284f);
			this.CFEDGDGBCHE().SetFloat("_Bullet_8", this.PLKFKNHPEHE[4] / 407f);
			this.CECICEGFHKL().SetFloat("EnableRankedNotificationsToggle", this.PLKFKNHPEHE[4] / 1445f);
			this.MNLKBFFKHIE().SetFloat("EnableRankedNotificationsToggle", this.PLKFKNHPEHE[8] / 870f);
			this.NJDIODJNGGA().SetFloat("_Fade", this.PLKFKNHPEHE[4] / 283f);
			this.KOHGPKOFEJO().SetFloat("_Brightness", this.PLKFKNHPEHE[5] / 1908f);
			this.MNLKBFFKHIE().SetFloat("EnvironmentSlider", this.PLKFKNHPEHE[4] / 231f);
			this.DOMEEFLPEPJ().SetFloat("note.3", this.PLKFKNHPEHE[39] / 1125f);
			this.HEHKGPKLAKK().SetFloat("BitsData", this.PLKFKNHPEHE[12] / 1536f);
			this.KLKILLCHJHO().SetFloat("CameraFilterPack_OldFilm1", this.PLKFKNHPEHE[42] / 1831f);
			this.OCMBHMLNCEK().SetFloat("_TimeX", this.FadeFX);
			this.CFEDGDGBCHE().SetFloat("#tryagain", this._Size);
			this.DIOAAHJDMLK().SetFloat("editor.", this._Dist);
			this.LDNADDJMIPK().SetFloat("_TimeX", this._Smooth);
			this.DOMEEFLPEPJ().SetVector("00", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1993f, 822f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F15 RID: 20245 RVA: 0x0018A552 File Offset: 0x00188752
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-66);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004F16 RID: 20246 RVA: 0x0018A58C File Offset: 0x0018878C
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 200f)
			{
				this.HBJJOCHGOPH = 1246f;
			}
			this.HNFFHCLNBDN().SetFloat(" failed in a server-side plugin. Check the configuration in the Dashboard. Message from server-plugin: ", this.HBJJOCHGOPH);
			this.CECICEGFHKL().SetFloat("\\", this.PLKFKNHPEHE[0] / 1935f);
			this.NJDIODJNGGA().SetFloat("[ResourcesManager] Load text error: not found", this.PLKFKNHPEHE[0] / 1642f);
			this.KOHGPKOFEJO().SetFloat("Forward", this.PLKFKNHPEHE[0] / 652f);
			this.NMDBCDFPGOK().SetFloat("/../", this.PLKFKNHPEHE[4] / 1975f);
			this.KOHGPKOFEJO().SetFloat("Left ", this.PLKFKNHPEHE[6] / 1184f);
			this.OCMBHMLNCEK().SetFloat(" in SaveLoadMenu.prefabDictionary!", this.PLKFKNHPEHE[5] / 1580f);
			this.OCMBHMLNCEK().SetFloat("CompletedLevel", this.PLKFKNHPEHE[8] / 1294f);
			this.ABHDNGIHBKE().SetFloat("steamid", this.PLKFKNHPEHE[5] / 1629f);
			this.KLKILLCHJHO().SetFloat("ConnectToBestCloudServer() failed. Can only connect while in state 'Disconnected'. Current state: ", this.PLKFKNHPEHE[0] / 530f);
			this.MNLKBFFKHIE().SetFloat("#ok", this.PLKFKNHPEHE[94] / 634f);
			this.ABHDNGIHBKE().SetFloat("/", this.PLKFKNHPEHE[126] / 1055f);
			this.KLKILLCHJHO().SetFloat("#no", this.PLKFKNHPEHE[52] / 1319f);
			this.MNLKBFFKHIE().SetFloat("stretchWidth", this.FadeFX);
			this.MCDGIILBNIF().SetFloat("/", this._Size);
			this.LDNADDJMIPK().SetFloat(",", this._Dist);
			this.MHBAIEKFBIJ().SetFloat("Joystick1Button1", this._Smooth);
			this.ABHDNGIHBKE().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1917f, 1986f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F17 RID: 20247 RVA: 0x0018A7F6 File Offset: 0x001889F6
	private void JONGNKNLLND()
	{
		this.JGMPDINHNKD();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004F18 RID: 20248 RVA: 0x0018A821 File Offset: 0x00188A21
	private void AGMHAIFOAAO()
	{
		float[] array = new float[-81];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004F19 RID: 20249 RVA: 0x0018965C File Offset: 0x0018785C
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x170000E2 RID: 226
	// (get) Token: 0x06004F1A RID: 20250 RVA: 0x00188D9F File Offset: 0x00186F9F
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

	// Token: 0x06004F1B RID: 20251 RVA: 0x0002523B File Offset: 0x0002343B
	private void GFACKFCEIBC()
	{
	}

	// Token: 0x06004F1C RID: 20252 RVA: 0x0018A83C File Offset: 0x00188A3C
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 283f)
			{
				this.HBJJOCHGOPH = 805f;
			}
			this.MHBAIEKFBIJ().SetFloat("CameraFilterPack/Blend2Camera_Luminosity", this.HBJJOCHGOPH);
			this.DIOAAHJDMLK().SetFloat("settings.cameramovements", this.PLKFKNHPEHE[0] / 1410f);
			this.NJDIODJNGGA().SetFloat("_TimeX", this.PLKFKNHPEHE[1] / 771f);
			this.DOMEEFLPEPJ().SetFloat("CameraFilterPack/Blend2Camera_Divide", this.PLKFKNHPEHE[7] / 572f);
			this.NBPKMLMCHFN.SetFloat("{0}", this.PLKFKNHPEHE[0] / 572f);
			this.NJDIODJNGGA().SetFloat("setAF", this.PLKFKNHPEHE[6] / 1603f);
			this.HNFFHCLNBDN().SetFloat("maps.", this.PLKFKNHPEHE[8] / 1658f);
			this.KLKILLCHJHO().SetFloat("0", this.PLKFKNHPEHE[7] / 1461f);
			this.CFEDGDGBCHE().SetFloat(">", this.PLKFKNHPEHE[7] / 1926f);
			this.NMDBCDFPGOK().SetFloat("CameraFilterPack/FX_Glitch3", this.PLKFKNHPEHE[3] / 95f);
			this.CFEDGDGBCHE().SetFloat("No valid adaptive tonemapper type found!", this.PLKFKNHPEHE[107] / 91f);
			this.CECICEGFHKL().SetFloat("HandleEventLeave for player ID: ", this.PLKFKNHPEHE[-112] / 1720f);
			this.CFEDGDGBCHE().SetFloat("CameraFilterPack_Broken_Screen1", this.PLKFKNHPEHE[41] / 963f);
			this.HEHKGPKLAKK().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", this.FadeFX);
			this.HNFFHCLNBDN().SetFloat("true", this._Size);
			this.CECICEGFHKL().SetFloat("_ScreenResolution", this._Dist);
			this.HEHKGPKLAKK().SetFloat("EnableRankingToggle", this._Smooth);
			this.ABHDNGIHBKE().SetVector("CameraFilterPack_TV_BrokenGlass_2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1678f, 1052f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F1D RID: 20253 RVA: 0x0018A013 File Offset: 0x00188213
	private void JHANGPCOCIG()
	{
		this.IKNKJMNFFOG();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004F1E RID: 20254 RVA: 0x0018AAA6 File Offset: 0x00188CA6
	private void EALEEMOPJNO()
	{
		float[] array = new float[-62];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004F1F RID: 20255 RVA: 0x0018AAC0 File Offset: 0x00188CC0
	private void KOFOBHNODCH()
	{
		float[] array = new float[125];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004F20 RID: 20256 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIFLPHLGLFG()
	{
	}

	// Token: 0x06004F21 RID: 20257 RVA: 0x0018965C File Offset: 0x0018785C
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004F22 RID: 20258 RVA: 0x0018965C File Offset: 0x0018785C
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004F23 RID: 20259 RVA: 0x00189681 File Offset: 0x00187881
	private void PAAMLLNPGBD()
	{
		this.FALHNNJBOEM();
	}

	// Token: 0x06004F24 RID: 20260 RVA: 0x0018AADC File Offset: 0x00188CDC
	private void MKFFLJGJMLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1660f)
			{
				this.HBJJOCHGOPH = 1040f;
			}
			this.LDNADDJMIPK().SetFloat("_HSV", this.HBJJOCHGOPH);
			this.OCMBHMLNCEK().SetFloat("caret", this.PLKFKNHPEHE[0] / 1739f);
			this.CFEDGDGBCHE().SetFloat("settings.fps", this.PLKFKNHPEHE[1] / 1617f);
			this.HEHKGPKLAKK().SetFloat("_TimeX", this.PLKFKNHPEHE[1] / 277f);
			this.KLKILLCHJHO().SetFloat("_Luminance", this.PLKFKNHPEHE[4] / 1628f);
			this.DKNJGHFLAIF().SetFloat("_Value", this.PLKFKNHPEHE[5] / 1425f);
			this.DIOAAHJDMLK().SetFloat("OnAwakeRPC", this.PLKFKNHPEHE[2] / 211f);
			this.NBPKMLMCHFN.SetFloat("[LevelEditorScene] Item creation successful! Published Item ID: ", this.PLKFKNHPEHE[0] / 1949f);
			this.MNLKBFFKHIE().SetFloat("_StretchWidth", this.PLKFKNHPEHE[8] / 613f);
			this.NJDIODJNGGA().SetFloat("Set Object Position", this.PLKFKNHPEHE[8] / 965f);
			this.HNFFHCLNBDN().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[-98] / 355f);
			this.NJDIODJNGGA().SetFloat("_MainTex2", this.PLKFKNHPEHE[44] / 238f);
			this.DOMEEFLPEPJ().SetFloat(": ", this.PLKFKNHPEHE[-18] / 1025f);
			this.OCMBHMLNCEK().SetFloat("#ok", this.FadeFX);
			this.OCMBHMLNCEK().SetFloat("SetSatelliteColor", this._Size);
			this.MCDGIILBNIF().SetFloat("{0}{1}:{2}", this._Dist);
			this.DKNJGHFLAIF().SetFloat("_TimeX", this._Smooth);
			this.HNFFHCLNBDN().SetVector("SaveGameName is null or empty!", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 138f, 1425f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F25 RID: 20261 RVA: 0x0018AD48 File Offset: 0x00188F48
	private void AOGCKKLFGPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 990f)
			{
				this.HBJJOCHGOPH = 1587f;
			}
			this.KLKILLCHJHO().SetFloat("_Amount", this.HBJJOCHGOPH);
			this.OCMBHMLNCEK().SetFloat("/", this.PLKFKNHPEHE[1] / 1892f);
			this.CFEDGDGBCHE().SetFloat("Coroutine container not configured... did you forget to call Init?", this.PLKFKNHPEHE[1] / 1733f);
			this.NBPKMLMCHFN.SetFloat("_BlurVector", this.PLKFKNHPEHE[5] / 1374f);
			this.MCDGIILBNIF().SetFloat(": ", this.PLKFKNHPEHE[0] / 429f);
			this.MHBAIEKFBIJ().SetFloat("CameraFilterPack/OldFilm_Cutting2", this.PLKFKNHPEHE[0] / 1261f);
			this.KLKILLCHJHO().SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", this.PLKFKNHPEHE[7] / 1682f);
			this.NMDBCDFPGOK().SetFloat(".message", this.PLKFKNHPEHE[2] / 341f);
			this.KLKILLCHJHO().SetFloat("_TimeX", this.PLKFKNHPEHE[3] / 844f);
			this.NJDIODJNGGA().SetFloat("LobbyCanvas", this.PLKFKNHPEHE[5] / 270f);
			this.DOMEEFLPEPJ().SetFloat("Using constructor for new PingNativeDynamic()", this.PLKFKNHPEHE[-96] / 1752f);
			this.HEHKGPKLAKK().SetFloat(" not found", this.PLKFKNHPEHE[126] / 1067f);
			this.MHBAIEKFBIJ().SetFloat("_Green_B", this.PLKFKNHPEHE[7] / 1513f);
			this.HNFFHCLNBDN().SetFloat("_TimeX", this.FadeFX);
			this.OCMBHMLNCEK().SetFloat("Loading...", this._Size);
			this.DOMEEFLPEPJ().SetFloat("_DistortionLevel", this._Dist);
			this.MNLKBFFKHIE().SetFloat("Submit", this._Smooth);
			this.MNLKBFFKHIE().SetVector("[Down-Left]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1170f, 1166f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F26 RID: 20262 RVA: 0x0018A821 File Offset: 0x00188A21
	private void GDPAIILEEFC()
	{
		float[] array = new float[-81];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004F27 RID: 20263 RVA: 0x0018AFB2 File Offset: 0x001891B2
	private void MBFNACDMEEK()
	{
		this.FMEFPOILMDI();
	}

	// Token: 0x06004F28 RID: 20264 RVA: 0x0018AFBA File Offset: 0x001891BA
	private void EDPDMBFLHLP()
	{
		this.GDPAIILEEFC();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004F29 RID: 20265 RVA: 0x00188D74 File Offset: 0x00186F74
	private void DOFDGBGEDFI()
	{
		this.MIPGPMKJELI();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004F2A RID: 20266 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x06004F2B RID: 20267 RVA: 0x0018AFE5 File Offset: 0x001891E5
	private void HJPCJGOEKMF()
	{
		this.FALHNNJBOEM();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004F2C RID: 20268 RVA: 0x0018965C File Offset: 0x0018785C
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004F2D RID: 20269 RVA: 0x0018B010 File Offset: 0x00189210
	private Material OCMBHMLNCEK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004F2E RID: 20270 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x06004F2F RID: 20271 RVA: 0x0018B047 File Offset: 0x00189247
	private void IAIAGCGJGHI()
	{
		float[] array = new float[80];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004F30 RID: 20272 RVA: 0x0018965C File Offset: 0x0018785C
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004F31 RID: 20273 RVA: 0x0018B061 File Offset: 0x00189261
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004F32 RID: 20274 RVA: 0x0018965C File Offset: 0x0018785C
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004F33 RID: 20275 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06004F34 RID: 20276 RVA: 0x0018B098 File Offset: 0x00189298
	private void LMKMEJMGDFO()
	{
		this.JBBKKKJOJMJ();
	}

	// Token: 0x06004F35 RID: 20277 RVA: 0x0018965C File Offset: 0x0018785C
	private void FAMLCFNDGNI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004F36 RID: 20278 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06004F37 RID: 20279 RVA: 0x0018B0A0 File Offset: 0x001892A0
	private Material NMDBCDFPGOK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004F38 RID: 20280 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06004F39 RID: 20281 RVA: 0x0018965C File Offset: 0x0018785C
	private void LAMEHAHJKMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004F3A RID: 20282 RVA: 0x0018B0D7 File Offset: 0x001892D7
	private void LGHFFANDDCM()
	{
		float[] array = new float[-82];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004F3B RID: 20283 RVA: 0x0018A071 File Offset: 0x00188271
	private void KDCLNBBODBO()
	{
		this.JGMPDINHNKD();
	}

	// Token: 0x06004F3C RID: 20284 RVA: 0x0018B0F4 File Offset: 0x001892F4
	private void PODKOCOPGLC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1035f)
			{
				this.HBJJOCHGOPH = 1267f;
			}
			this.ABHDNGIHBKE().SetFloat("ConfigVersionSlider", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetFloat("_Value4", this.PLKFKNHPEHE[0] / 1622f);
			this.DIOAAHJDMLK().SetFloat("_Value5", this.PLKFKNHPEHE[1] / 955f);
			this.DOMEEFLPEPJ().SetFloat(" scene view IDs from last level.", this.PLKFKNHPEHE[5] / 1326f);
			this.MNLKBFFKHIE().SetFloat("ItemTemplate", this.PLKFKNHPEHE[8] / 92f);
			this.DKNJGHFLAIF().SetFloat("_TimeX", this.PLKFKNHPEHE[5] / 904f);
			this.OCMBHMLNCEK().SetFloat(".ogg", this.PLKFKNHPEHE[1] / 1572f);
			this.KOHGPKOFEJO().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[2] / 316f);
			this.OCMBHMLNCEK().SetFloat("musicVolume", this.PLKFKNHPEHE[6] / 1842f);
			this.MNLKBFFKHIE().SetFloat("_MainTex2", this.PLKFKNHPEHE[6] / 1752f);
			this.ABHDNGIHBKE().SetFloat("EnableRankedNotificationsToggle", this.PLKFKNHPEHE[-53] / 194f);
			this.MNLKBFFKHIE().SetFloat("wss://", this.PLKFKNHPEHE[70] / 545f);
			this.DOMEEFLPEPJ().SetFloat("Drop_Near", this.PLKFKNHPEHE[-95] / 638f);
			this.DIOAAHJDMLK().SetFloat("_Value3", this.FadeFX);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_HardLight", this._Size);
			this.OCMBHMLNCEK().SetFloat("UNDISTORT", this._Dist);
			this.KOHGPKOFEJO().SetFloat(": ", this._Smooth);
			this.KJMECMIGJJA().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 799f, 1397f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F3D RID: 20285 RVA: 0x0018965C File Offset: 0x0018785C
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004F3E RID: 20286 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x06004F3F RID: 20287 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06004F40 RID: 20288 RVA: 0x0018B35E File Offset: 0x0018955E
	private void IKNKJMNFFOG()
	{
		float[] array = new float[-83];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004F41 RID: 20289 RVA: 0x0018B378 File Offset: 0x00189578
	private void MEBPBNLBECA()
	{
		this.FMEFPOILMDI();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004F42 RID: 20290 RVA: 0x0018B3A4 File Offset: 0x001895A4
	private void OIKAPFGPLML(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 507f)
			{
				this.HBJJOCHGOPH = 489f;
			}
			this.MHBAIEKFBIJ().SetFloat("Ev Destroy Failed. Could not find PhotonView with instantiationId ", this.HBJJOCHGOPH);
			this.DIOAAHJDMLK().SetFloat("Editor/", this.PLKFKNHPEHE[1] / 679f);
			this.CECICEGFHKL().SetFloat("file://", this.PLKFKNHPEHE[1] / 1381f);
			this.HNFFHCLNBDN().SetFloat("float,0", this.PLKFKNHPEHE[5] / 1589f);
			this.ABHDNGIHBKE().SetFloat("CameraFilterPack/Drawing_Laplacian", this.PLKFKNHPEHE[7] / 372f);
			this.OCMBHMLNCEK().SetFloat(" beatThreshold: ", this.PLKFKNHPEHE[5] / 1099f);
			this.MHBAIEKFBIJ().SetFloat(".", this.PLKFKNHPEHE[5] / 1887f);
			this.DIOAAHJDMLK().SetFloat("_Offsets", this.PLKFKNHPEHE[3] / 914f);
			this.DKNJGHFLAIF().SetFloat("CameraFilterPack/FX_Psycho", this.PLKFKNHPEHE[7] / 1968f);
			this.ABHDNGIHBKE().SetFloat("DPADHOR", this.PLKFKNHPEHE[1] / 567f);
			this.ABHDNGIHBKE().SetFloat("[PlayerController] ", this.PLKFKNHPEHE[-110] / 1554f);
			this.DIOAAHJDMLK().SetFloat("MainButton", this.PLKFKNHPEHE[122] / 1715f);
			this.HNFFHCLNBDN().SetFloat("[SteamManager] Connection established, authorization", this.PLKFKNHPEHE[-95] / 723f);
			this.KLKILLCHJHO().SetFloat("AudioClip", this.FadeFX);
			this.NMDBCDFPGOK().SetFloat("bloomintencity:", this._Size);
			this.CECICEGFHKL().SetFloat("_ScreenResolution", this._Dist);
			this.ABHDNGIHBKE().SetFloat("CameraFilterPack/Distortion_Dissipation", this._Smooth);
			this.ABHDNGIHBKE().SetVector(".lastCheckpoint.powerupsScore", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1215f, 1176f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F43 RID: 20291 RVA: 0x0018A00B File Offset: 0x0018820B
	private void JDCJBNHAFCI()
	{
		this.PPBFGGFIDKP();
	}

	// Token: 0x06004F44 RID: 20292 RVA: 0x0018B60E File Offset: 0x0018980E
	private void FMEFPOILMDI()
	{
		float[] array = new float[91];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004F45 RID: 20293 RVA: 0x00189076 File Offset: 0x00187276
	private void IIKCMDMMJJI()
	{
		this.NBOEFDOKHLE();
	}

	// Token: 0x06004F46 RID: 20294 RVA: 0x00189315 File Offset: 0x00187515
	private void HLIAEEMGBHN()
	{
		this.GKNPHGOHOAE();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004F47 RID: 20295 RVA: 0x0018B628 File Offset: 0x00189828
	private Material MHBAIEKFBIJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004F48 RID: 20296 RVA: 0x0018B65F File Offset: 0x0018985F
	private void MABCDJDPGNA()
	{
		this.PEKADICCGAG();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004F49 RID: 20297 RVA: 0x00189681 File Offset: 0x00187881
	private void APMCFBKLDBD()
	{
		this.FALHNNJBOEM();
	}

	// Token: 0x06004F4A RID: 20298 RVA: 0x0018B68A File Offset: 0x0018988A
	private void LGJAHGCLMLE()
	{
		this.KNLDBHHKFPF();
	}

	// Token: 0x06004F4B RID: 20299 RVA: 0x0018B692 File Offset: 0x00189892
	private Material DOMEEFLPEPJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004F4C RID: 20300 RVA: 0x0018B6C9 File Offset: 0x001898C9
	private void MGGFMCIGOAF()
	{
		float[] array = new float[97];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004F4D RID: 20301 RVA: 0x0018B6E3 File Offset: 0x001898E3
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004F4E RID: 20302 RVA: 0x001897A0 File Offset: 0x001879A0
	private void GAAPMFBPJNH()
	{
		this.MGGFMCIGOAF();
	}

	// Token: 0x06004F4F RID: 20303 RVA: 0x0018B71C File Offset: 0x0018991C
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1251f)
			{
				this.HBJJOCHGOPH = 945f;
			}
			this.DOMEEFLPEPJ().SetFloat("LivesSlider", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("_Cible", this.PLKFKNHPEHE[0] / 1028f);
			this.KJMECMIGJJA().SetFloat("Preparing content...", this.PLKFKNHPEHE[1] / 1668f);
			this.CFEDGDGBCHE().SetFloat("SetSunMaxSize", this.PLKFKNHPEHE[5] / 1422f);
			this.MCDGIILBNIF().SetFloat("Received RPC \"", this.PLKFKNHPEHE[3] / 1321f);
			this.NJDIODJNGGA().SetFloat("Outdated version. Please restart the game to get lastest updates.", this.PLKFKNHPEHE[1] / 1684f);
			this.LDNADDJMIPK().SetFloat("maps.", this.PLKFKNHPEHE[2] / 1825f);
			this.OCMBHMLNCEK().SetFloat(" cannot be used as a 3D LUT.", this.PLKFKNHPEHE[0] / 1646f);
			this.MNLKBFFKHIE().SetFloat("JoinButton", this.PLKFKNHPEHE[6] / 1289f);
			this.NBPKMLMCHFN.SetFloat("_FlipAlphaMask", this.PLKFKNHPEHE[3] / 1084f);
			this.HEHKGPKLAKK().SetFloat("System.Int64", this.PLKFKNHPEHE[-91] / 1534f);
			this.CECICEGFHKL().SetFloat("Hex value #RRGGBB", this.PLKFKNHPEHE[68] / 1509f);
			this.MHBAIEKFBIJ().SetFloat("Year_", this.PLKFKNHPEHE[122] / 1151f);
			this.DIOAAHJDMLK().SetFloat("CameraFilterPack/FX_DarkMatter", this.FadeFX);
			this.NMDBCDFPGOK().SetFloat("0 seconds", this._Size);
			this.DKNJGHFLAIF().SetFloat("DPADHOR", this._Dist);
			this.MCDGIILBNIF().SetFloat("error", this._Smooth);
			this.DKNJGHFLAIF().SetVector("No problem found, so far", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1281f, 123f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F50 RID: 20304 RVA: 0x001892EA File Offset: 0x001874EA
	private void PJHBFAFOEEN()
	{
		this.FALHNNJBOEM();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004F51 RID: 20305 RVA: 0x0018B988 File Offset: 0x00189B88
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 348f)
			{
				this.HBJJOCHGOPH = 915f;
			}
			this.KJMECMIGJJA().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.CECICEGFHKL().SetFloat(" ", this.PLKFKNHPEHE[1] / 1823f);
			this.DIOAAHJDMLK().SetFloat("_MainTex2", this.PLKFKNHPEHE[1] / 929f);
			this.HNFFHCLNBDN().SetFloat("Submition failed", this.PLKFKNHPEHE[6] / 1350f);
			this.NMDBCDFPGOK().SetFloat("NEW_ACHIEVEMENT_1_21", this.PLKFKNHPEHE[3] / 836f);
			this.LDNADDJMIPK().SetFloat("Set satellite MinVertexDistance - how much distance should be between to points of the trail line", this.PLKFKNHPEHE[3] / 1133f);
			this.KLKILLCHJHO().SetFloat("_PositionY", this.PLKFKNHPEHE[2] / 378f);
			this.KLKILLCHJHO().SetFloat("_EmissionGain", this.PLKFKNHPEHE[4] / 1785f);
			this.OCMBHMLNCEK().SetFloat("https://steamcdn-a.akamaihd.net/steamcommunity/public/images/clans/", this.PLKFKNHPEHE[1] / 256f);
			this.KLKILLCHJHO().SetFloat("\"", this.PLKFKNHPEHE[6] / 762f);
			this.ABHDNGIHBKE().SetFloat("0x", this.PLKFKNHPEHE[107] / 1934f);
			this.DIOAAHJDMLK().SetFloat("SpawnObj", this.PLKFKNHPEHE[103] / 1011f);
			this.MHBAIEKFBIJ().SetFloat("_SoftZDistance", this.PLKFKNHPEHE[88] / 762f);
			this.DOMEEFLPEPJ().SetFloat("offsets", this.FadeFX);
			this.KLKILLCHJHO().SetFloat(":\n", this._Size);
			this.CECICEGFHKL().SetFloat("_TimeX", this._Dist);
			this.OCMBHMLNCEK().SetFloat("ShowTitle", this._Smooth);
			this.NMDBCDFPGOK().SetVector("_FresnelFade", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1022f, 322f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F52 RID: 20306 RVA: 0x0018AFB2 File Offset: 0x001891B2
	private void AMIMHHGLPIN()
	{
		this.FMEFPOILMDI();
	}

	// Token: 0x06004F53 RID: 20307 RVA: 0x0018BBF4 File Offset: 0x00189DF4
	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1667f)
			{
				this.HBJJOCHGOPH = 848f;
			}
			this.DKNJGHFLAIF().SetFloat("value", this.HBJJOCHGOPH);
			this.MHBAIEKFBIJ().SetFloat("ready", this.PLKFKNHPEHE[1] / 1224f);
			this.DOMEEFLPEPJ().SetFloat("_Exponent", this.PLKFKNHPEHE[1] / 500f);
			this.NBPKMLMCHFN.SetFloat("Editor/", this.PLKFKNHPEHE[4] / 1263f);
			this.DKNJGHFLAIF().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[3] / 1125f);
			this.KJMECMIGJJA().SetFloat("CameraFilterPack/3D_Mirror", this.PLKFKNHPEHE[4] / 1128f);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.PLKFKNHPEHE[4] / 317f);
			this.DIOAAHJDMLK().SetFloat("Set Sun Sensitivity", this.PLKFKNHPEHE[4] / 1950f);
			this.ABHDNGIHBKE().SetFloat("Fade", this.PLKFKNHPEHE[1] / 835f);
			this.MHBAIEKFBIJ().SetFloat(": ", this.PLKFKNHPEHE[2] / 527f);
			this.LDNADDJMIPK().SetFloat("tintColor", this.PLKFKNHPEHE[-18] / 566f);
			this.CFEDGDGBCHE().SetFloat("_ExtraColor", this.PLKFKNHPEHE[-121] / 249f);
			this.ABHDNGIHBKE().SetFloat("_Value2", this.PLKFKNHPEHE[25] / 892f);
			this.HEHKGPKLAKK().SetFloat("_ToneCurve", this.FadeFX);
			this.DIOAAHJDMLK().SetFloat("_Red_R", this._Size);
			this.OCMBHMLNCEK().SetFloat("_Near", this._Dist);
			this.KLKILLCHJHO().SetFloat("[Steamworks.NET] Packsize Test returned false, the wrong version of Steamworks.NET is being run in this platform.", this._Smooth);
			this.DKNJGHFLAIF().SetVector("[Left]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1159f, 744f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F54 RID: 20308 RVA: 0x0018BE5E File Offset: 0x0018A05E
	private void JGMPDINHNKD()
	{
		float[] array = new float[15];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004F55 RID: 20309 RVA: 0x0018BE78 File Offset: 0x0018A078
	private void IBBFFKEAOCE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 917f)
			{
				this.HBJJOCHGOPH = 1626f;
			}
			this.OCMBHMLNCEK().SetFloat("SetSatelliteRadius", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[0] / 443f);
			this.KJMECMIGJJA().SetFloat(" connected: ", this.PLKFKNHPEHE[0] / 781f);
			this.CFEDGDGBCHE().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[7] / 81f);
			this.CECICEGFHKL().SetFloat("Changed config", this.PLKFKNHPEHE[3] / 824f);
			this.HNFFHCLNBDN().SetFloat("_ScreenResolution", this.PLKFKNHPEHE[0] / 336f);
			this.MNLKBFFKHIE().SetFloat("Can't set visible when not in that room.", this.PLKFKNHPEHE[3] / 1272f);
			this.HNFFHCLNBDN().SetFloat("_TimeX", this.PLKFKNHPEHE[6] / 494f);
			this.KLKILLCHJHO().SetFloat("color", this.PLKFKNHPEHE[8] / 1133f);
			this.NBPKMLMCHFN.SetFloat("VHS", this.PLKFKNHPEHE[6] / 1117f);
			this.KOHGPKOFEJO().SetFloat("CameraFilterPack/Gradients_Stripe", this.PLKFKNHPEHE[31] / 1362f);
			this.OCMBHMLNCEK().SetFloat("[Right]", this.PLKFKNHPEHE[-108] / 1874f);
			this.HNFFHCLNBDN().SetFloat("menutheme.fragout", this.PLKFKNHPEHE[62] / 202f);
			this.LDNADDJMIPK().SetFloat("#random #common #item", this.FadeFX);
			this.KJMECMIGJJA().SetFloat("_Value", this._Size);
			this.LDNADDJMIPK().SetFloat("mapselector.filter.favoriteonly", this._Dist);
			this.KOHGPKOFEJO().SetFloat("[PlayerController] ", this._Smooth);
			this.NJDIODJNGGA().SetVector("Scene", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 974f, 127f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F56 RID: 20310 RVA: 0x0018C0E4 File Offset: 0x0018A2E4
	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1578f)
			{
				this.HBJJOCHGOPH = 231f;
			}
			this.MHBAIEKFBIJ().SetFloat("[LevelEditorScene] Print Audio Wave: Done", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat("player.lollipop", this.PLKFKNHPEHE[0] / 423f);
			this.HEHKGPKLAKK().SetFloat("#{0:X2}{1:X2}{2:X2}", this.PLKFKNHPEHE[1] / 381f);
			this.NMDBCDFPGOK().SetFloat("SetCrosshairEmission", this.PLKFKNHPEHE[0] / 617f);
			this.DKNJGHFLAIF().SetFloat("menu.enableselectormusic", this.PLKFKNHPEHE[0] / 1529f);
			this.KOHGPKOFEJO().SetFloat(": ", this.PLKFKNHPEHE[7] / 1788f);
			this.HEHKGPKLAKK().SetFloat(": ", this.PLKFKNHPEHE[0] / 1968f);
			this.DKNJGHFLAIF().SetFloat("music.ogg", this.PLKFKNHPEHE[5] / 1598f);
			this.KOHGPKOFEJO().SetFloat("yyyy-MM-dd HH:mm:ss", this.PLKFKNHPEHE[2] / 898f);
			this.MHBAIEKFBIJ().SetFloat("itemid", this.PLKFKNHPEHE[4] / 1826f);
			this.LDNADDJMIPK().SetFloat("value", this.PLKFKNHPEHE[80] / 511f);
			this.LDNADDJMIPK().SetFloat("restrictions\n\n#until: ", this.PLKFKNHPEHE[-78] / 1424f);
			this.KLKILLCHJHO().SetFloat(",", this.PLKFKNHPEHE[32] / 1630f);
			this.DIOAAHJDMLK().SetFloat("RateButton", this.FadeFX);
			this.NMDBCDFPGOK().SetFloat("_EmissionGain", this._Size);
			this.DKNJGHFLAIF().SetFloat(".completedCount", this._Dist);
			this.KJMECMIGJJA().SetFloat("#tryagain", this._Smooth);
			this.KJMECMIGJJA().SetVector("_Blue_R", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 848f, 1285f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F57 RID: 20311 RVA: 0x0018C34E File Offset: 0x0018A54E
	private void GKNPHGOHOAE()
	{
		float[] array = new float[-72];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004F58 RID: 20312 RVA: 0x0018C368 File Offset: 0x0018A568
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004F59 RID: 20313 RVA: 0x0018C3A0 File Offset: 0x0018A5A0
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 703f)
			{
				this.HBJJOCHGOPH = 1122f;
			}
			this.HNFFHCLNBDN().SetFloat("_DepthLevel", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("_Value", this.PLKFKNHPEHE[1] / 1989f);
			this.DKNJGHFLAIF().SetFloat("_Blue_R", this.PLKFKNHPEHE[0] / 896f);
			this.DOMEEFLPEPJ().SetFloat("_Value4", this.PLKFKNHPEHE[4] / 220f);
			this.CECICEGFHKL().SetFloat("1087340967", this.PLKFKNHPEHE[4] / 1658f);
			this.NJDIODJNGGA().SetFloat("Hidden/Image Effects/Cinematic/MotionBlur/FrameBlending", this.PLKFKNHPEHE[3] / 339f);
			this.HEHKGPKLAKK().SetFloat("SetCrosshairEmission", this.PLKFKNHPEHE[2] / 258f);
			this.CFEDGDGBCHE().SetFloat("Reset XP", this.PLKFKNHPEHE[2] / 1723f);
			this.ABHDNGIHBKE().SetFloat("OperationResponse unhandled: {0}", this.PLKFKNHPEHE[3] / 1042f);
			this.OCMBHMLNCEK().SetFloat("AudioSampler", this.PLKFKNHPEHE[1] / 1330f);
			this.CFEDGDGBCHE().SetFloat("CameraFilterPack/TV_Distorted", this.PLKFKNHPEHE[76] / 192f);
			this.DIOAAHJDMLK().SetFloat("_SpotSize", this.PLKFKNHPEHE[22] / 1696f);
			this.MNLKBFFKHIE().SetFloat("Hex value #RRGGBB", this.PLKFKNHPEHE[51] / 1464f);
			this.MNLKBFFKHIE().SetFloat("inventory.lastitemscount", this.FadeFX);
			this.ABHDNGIHBKE().SetFloat("System.String", this._Size);
			this.KOHGPKOFEJO().SetFloat("SetPlayerDistance", this._Dist);
			this.ABHDNGIHBKE().SetFloat("_Value2", this._Smooth);
			this.HNFFHCLNBDN().SetVector("Source: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 616f, 516f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F5A RID: 20314 RVA: 0x0018C60A File Offset: 0x0018A80A
	private Material CECICEGFHKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004F5B RID: 20315 RVA: 0x0018C641 File Offset: 0x0018A841
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004F5C RID: 20316 RVA: 0x0018C678 File Offset: 0x0018A878
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 9f)
			{
				this.HBJJOCHGOPH = 226f;
			}
			this.DIOAAHJDMLK().SetFloat("offsets", this.HBJJOCHGOPH);
			this.MNLKBFFKHIE().SetFloat(".workshop.json", this.PLKFKNHPEHE[1] / 291f);
			this.NBPKMLMCHFN.SetFloat("FrostCanvas", this.PLKFKNHPEHE[1] / 1155f);
			this.HNFFHCLNBDN().SetFloat("USE_UV_BASED_REPROJECTION", this.PLKFKNHPEHE[1] / 1666f);
			this.DOMEEFLPEPJ().SetFloat("_Value2", this.PLKFKNHPEHE[0] / 389f);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Color_Noise", this.PLKFKNHPEHE[0] / 8f);
			this.MNLKBFFKHIE().SetFloat("caret", this.PLKFKNHPEHE[5] / 1793f);
			this.HNFFHCLNBDN().SetFloat("_Far", this.PLKFKNHPEHE[4] / 1435f);
			this.MHBAIEKFBIJ().SetFloat("CameraFilterPack_AAA_Blood2", this.PLKFKNHPEHE[2] / 1639f);
			this.CFEDGDGBCHE().SetFloat("_FixDistance", this.PLKFKNHPEHE[3] / 272f);
			this.HNFFHCLNBDN().SetFloat("Right", this.PLKFKNHPEHE[-125] / 232f);
			this.CECICEGFHKL().SetFloat("CameraFilterPack/Colors_DarkColor", this.PLKFKNHPEHE[13] / 1710f);
			this.KOHGPKOFEJO().SetFloat("CameraMovementSlider", this.PLKFKNHPEHE[14] / 1069f);
			this.KJMECMIGJJA().SetFloat("X", this.FadeFX);
			this.MNLKBFFKHIE().SetFloat("\\", this._Size);
			this.NJDIODJNGGA().SetFloat("Spawn new environment object (sun, satellite etc) and sets its id", this._Dist);
			this.DKNJGHFLAIF().SetFloat("Turn", this._Smooth);
			this.DKNJGHFLAIF().SetVector("team", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1911f, 327f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F5D RID: 20317 RVA: 0x0018965C File Offset: 0x0018785C
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004F5E RID: 20318 RVA: 0x0018C8E2 File Offset: 0x0018AAE2
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-82);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004F5F RID: 20319 RVA: 0x0018965C File Offset: 0x0018785C
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004F60 RID: 20320 RVA: 0x0002523B File Offset: 0x0002343B
	private void COMNAPAAPDO()
	{
	}

	// Token: 0x06004F61 RID: 20321 RVA: 0x0018B098 File Offset: 0x00189298
	private void HGPLPMCJNLL()
	{
		this.JBBKKKJOJMJ();
	}

	// Token: 0x06004F62 RID: 20322 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x06004F63 RID: 20323 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x06004F64 RID: 20324 RVA: 0x0018C91C File Offset: 0x0018AB1C
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 433f)
			{
				this.HBJJOCHGOPH = 195f;
			}
			this.OCMBHMLNCEK().SetFloat("note.3", this.HBJJOCHGOPH);
			this.CECICEGFHKL().SetFloat("You did not select a Hosting Type in your PhotonServerSettings. Please set it up or don't use ConnectUsingSettings().", this.PLKFKNHPEHE[1] / 1470f);
			this.CECICEGFHKL().SetFloat("EventTimeInputField", this.PLKFKNHPEHE[1] / 1868f);
			this.MHBAIEKFBIJ().SetFloat("DISTORT", this.PLKFKNHPEHE[2] / 1555f);
			this.DKNJGHFLAIF().SetFloat("_TimeX", this.PLKFKNHPEHE[4] / 976f);
			this.NJDIODJNGGA().SetFloat("_Value6", this.PLKFKNHPEHE[5] / 707f);
			this.MHBAIEKFBIJ().SetFloat("ConnectToRegion: ", this.PLKFKNHPEHE[2] / 1163f);
			this.NMDBCDFPGOK().SetFloat("Set Particles Speed", this.PLKFKNHPEHE[5] / 113f);
			this.NBPKMLMCHFN.SetFloat("Show text at the center of the screen. Usefull for quick messages like 'Thanks for playing!'", this.PLKFKNHPEHE[0] / 1202f);
			this.DIOAAHJDMLK().SetFloat("_NoisePerChannel", this.PLKFKNHPEHE[3] / 932f);
			this.ABHDNGIHBKE().SetFloat("EditMenu", this.PLKFKNHPEHE[-21] / 472f);
			this.MHBAIEKFBIJ().SetFloat("[Right]", this.PLKFKNHPEHE[76] / 296f);
			this.DOMEEFLPEPJ().SetFloat("CameraFilterPack/3D_Scan_Scene", this.PLKFKNHPEHE[-108] / 1107f);
			this.MHBAIEKFBIJ().SetFloat("_Value3", this.FadeFX);
			this.ABHDNGIHBKE().SetFloat("BadgeText", this._Size);
			this.ABHDNGIHBKE().SetFloat("_ScreenResolution", this._Dist);
			this.OCMBHMLNCEK().SetFloat("Tab1Content", this._Smooth);
			this.MNLKBFFKHIE().SetVector(" from: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 405f, 1150f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F65 RID: 20325 RVA: 0x0018965C File Offset: 0x0018785C
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004F66 RID: 20326 RVA: 0x0018AFB2 File Offset: 0x001891B2
	private void PCGODOELOHG()
	{
		this.FMEFPOILMDI();
	}

	// Token: 0x06004F67 RID: 20327 RVA: 0x0018CB86 File Offset: 0x0018AD86
	private void PHINJDJEFLI()
	{
		float[] array = new float[-22];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004F68 RID: 20328 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHJJFJCKGAJ()
	{
	}

	// Token: 0x06004F69 RID: 20329 RVA: 0x00189AD9 File Offset: 0x00187CD9
	private void MPADDMNGJNC()
	{
		this.GDPAIILEEFC();
	}

	// Token: 0x06004F6A RID: 20330 RVA: 0x0018CBA0 File Offset: 0x0018ADA0
	private void GOCIGGGHANF()
	{
		float[] array = new float[-29];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004F6B RID: 20331 RVA: 0x0018CBBA File Offset: 0x0018ADBA
	private void JBBKKKJOJMJ()
	{
		float[] array = new float[-101];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004F6C RID: 20332 RVA: 0x0018AAC0 File Offset: 0x00188CC0
	private void KNLDBHHKFPF()
	{
		float[] array = new float[125];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004F6D RID: 20333 RVA: 0x0018CBD4 File Offset: 0x0018ADD4
	private void MPJAFNJLBEF()
	{
		float[] array = new float[-67];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004F6E RID: 20334 RVA: 0x001897A0 File Offset: 0x001879A0
	private void DPKJPFEIHOB()
	{
		this.MGGFMCIGOAF();
	}

	// Token: 0x06004F6F RID: 20335 RVA: 0x0018CBF0 File Offset: 0x0018ADF0
	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1709f)
			{
				this.HBJJOCHGOPH = 1009f;
			}
			this.DKNJGHFLAIF().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("Hex value #RRGGBB", this.PLKFKNHPEHE[1] / 642f);
			this.MHBAIEKFBIJ().SetFloat("  |  Events Count: ", this.PLKFKNHPEHE[1] / 1949f);
			this.MCDGIILBNIF().SetFloat("[NetworkManager] Updating current room...", this.PLKFKNHPEHE[0] / 1064f);
			this.CECICEGFHKL().SetFloat("source", this.PLKFKNHPEHE[6] / 1611f);
			this.HEHKGPKLAKK().SetFloat("SelectorMusicToggle", this.PLKFKNHPEHE[3] / 73f);
			this.MCDGIILBNIF().SetFloat(". Check if the server is available.", this.PLKFKNHPEHE[6] / 1741f);
			this.ABHDNGIHBKE().SetFloat(": ", this.PLKFKNHPEHE[1] / 208f);
			this.CECICEGFHKL().SetFloat("menu.relaxinfo", this.PLKFKNHPEHE[3] / 1060f);
			this.DIOAAHJDMLK().SetFloat("_Saturation", this.PLKFKNHPEHE[0] / 859f);
			this.NJDIODJNGGA().SetFloat("[MapsData] Found ", this.PLKFKNHPEHE[-117] / 1203f);
			this.DKNJGHFLAIF().SetFloat("y", this.PLKFKNHPEHE[-20] / 43f);
			this.HNFFHCLNBDN().SetFloat("FrostCanvas", this.PLKFKNHPEHE[-93] / 1813f);
			this.KJMECMIGJJA().SetFloat("mapselector.tags.", this.FadeFX);
			this.MCDGIILBNIF().SetFloat("/", this._Size);
			this.DIOAAHJDMLK().SetFloat("[ResourcesManager] Load audio error: ", this._Dist);
			this.KJMECMIGJJA().SetFloat("speed", this._Smooth);
			this.DOMEEFLPEPJ().SetVector("_Speed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1130f, 18f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F70 RID: 20336 RVA: 0x0018CE5C File Offset: 0x0018B05C
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1015f)
			{
				this.HBJJOCHGOPH = 1206f;
			}
			this.DOMEEFLPEPJ().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.KLKILLCHJHO().SetFloat("_TileMaxOffs", this.PLKFKNHPEHE[1] / 92f);
			this.LDNADDJMIPK().SetFloat("_ReflectionBufferSize", this.PLKFKNHPEHE[0] / 274f);
			this.KLKILLCHJHO().SetFloat("https://bitbucket.org/khb-soft/intralismarcsviewer/", this.PLKFKNHPEHE[2] / 347f);
			this.LDNADDJMIPK().SetFloat(":", this.PLKFKNHPEHE[7] / 168f);
			this.LDNADDJMIPK().SetFloat("_Value2", this.PLKFKNHPEHE[4] / 877f);
			this.ABHDNGIHBKE().SetFloat("[NetworkManager] Connected to ", this.PLKFKNHPEHE[0] / 1218f);
			this.KJMECMIGJJA().SetFloat("Case-Sensitive", this.PLKFKNHPEHE[1] / 1256f);
			this.NJDIODJNGGA().SetFloat("_Value3", this.PLKFKNHPEHE[0] / 707f);
			this.CECICEGFHKL().SetFloat("CreateRoom failed. In offline mode you still have to leave a room to enter another.", this.PLKFKNHPEHE[5] / 1591f);
			this.NJDIODJNGGA().SetFloat(": ", this.PLKFKNHPEHE[51] / 1500f);
			this.KJMECMIGJJA().SetFloat("[MapsStats] Map ID: ", this.PLKFKNHPEHE[127] / 932f);
			this.DKNJGHFLAIF().SetFloat("[PlayerController] ", this.PLKFKNHPEHE[-100] / 80f);
			this.OCMBHMLNCEK().SetFloat("[NetworkMenu] Joining ", this.FadeFX);
			this.NMDBCDFPGOK().SetFloat("achievements.21.progress", this._Size);
			this.OCMBHMLNCEK().SetFloat("IconFileSelector", this._Dist);
			this.OCMBHMLNCEK().SetFloat("maps.", this._Smooth);
			this.OCMBHMLNCEK().SetVector("EventTimeInputField", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 910f, 946f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F71 RID: 20337 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x06004F72 RID: 20338 RVA: 0x0018D0C8 File Offset: 0x0018B2C8
	private void AIKDNGCEDAB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 774f)
			{
				this.HBJJOCHGOPH = 512f;
			}
			this.LDNADDJMIPK().SetFloat("_Extra", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("_Parasite", this.PLKFKNHPEHE[1] / 360f);
			this.NMDBCDFPGOK().SetFloat("Custom Authentication failed (either due to user-input or configuration or AuthParameter string format). Calling: OnCustomAuthenticationFailed()", this.PLKFKNHPEHE[0] / 1716f);
			this.KLKILLCHJHO().SetFloat("CameraFilterPack/BlurTiltShift_V", this.PLKFKNHPEHE[8] / 417f);
			this.ABHDNGIHBKE().SetFloat("_Offsets", this.PLKFKNHPEHE[8] / 85f);
			this.KJMECMIGJJA().SetFloat("challengeid", this.PLKFKNHPEHE[6] / 1096f);
			this.CFEDGDGBCHE().SetFloat("_Value2", this.PLKFKNHPEHE[5] / 595f);
			this.KJMECMIGJJA().SetFloat("_LrDepthTex", this.PLKFKNHPEHE[6] / 475f);
			this.LDNADDJMIPK().SetFloat("_Light2", this.PLKFKNHPEHE[6] / 296f);
			this.CFEDGDGBCHE().SetFloat("CameraFilterPack/FX_superDot", this.PLKFKNHPEHE[5] / 2f);
			this.DIOAAHJDMLK().SetFloat("_RotationMatrix", this.PLKFKNHPEHE[111] / 889f);
			this.ABHDNGIHBKE().SetFloat("_Near", this.PLKFKNHPEHE[-35] / 808f);
			this.CFEDGDGBCHE().SetFloat("SetSunEmission", this.PLKFKNHPEHE[90] / 770f);
			this.CECICEGFHKL().SetFloat("_YCrop", this.FadeFX);
			this.CFEDGDGBCHE().SetFloat("_TimeX", this._Size);
			this.KOHGPKOFEJO().SetFloat("JoinButton", this._Dist);
			this.OCMBHMLNCEK().SetFloat("Failed!", this._Smooth);
			this.DIOAAHJDMLK().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 940f, 538f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NMDBCDFPGOK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004F73 RID: 20339 RVA: 0x0018D332 File Offset: 0x0018B532
	private void PEKADICCGAG()
	{
		float[] array = new float[-13];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.$field-F67410C8F39EF676DF776183A98BDDD17C8B98F4).FieldHandle);
		this.PLKFKNHPEHE = array;
	}

	// Token: 0x06004F74 RID: 20340 RVA: 0x0018A00B File Offset: 0x0018820B
	private void AAPKKMKDOFO()
	{
		this.PPBFGGFIDKP();
	}

	// Token: 0x04000846 RID: 2118
	private string ELOFMLPCCEA = "CameraFilterPack/Oculus_NightVision5";

	// Token: 0x04000847 RID: 2119
	public Shader SCShader;

	// Token: 0x04000848 RID: 2120
	[Range(0f, 1f)]
	public float FadeFX = 1f;

	// Token: 0x04000849 RID: 2121
	[Range(0f, 1f)]
	public float _Size = 0.37f;

	// Token: 0x0400084A RID: 2122
	[Range(0f, 1f)]
	public float _Smooth = 0.15f;

	// Token: 0x0400084B RID: 2123
	[Range(0f, 1f)]
	public float _Dist = 0.285f;

	// Token: 0x0400084C RID: 2124
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400084D RID: 2125
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400084E RID: 2126
	private Material BJFKDHHMLJH;

	// Token: 0x0400084F RID: 2127
	private float[] PLKFKNHPEHE;
}
