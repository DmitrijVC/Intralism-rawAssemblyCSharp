using System;
using UnityEngine;

// Token: 0x020000ED RID: 237
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Light/Water")]
public class CameraFilterPack_Light_Water : MonoBehaviour
{
	// Token: 0x060048FF RID: 18687 RVA: 0x0016428D File Offset: 0x0016248D
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004900 RID: 18688 RVA: 0x001642B1 File Offset: 0x001624B1
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-66);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004901 RID: 18689 RVA: 0x001642E8 File Offset: 0x001624E8
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find("icon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004902 RID: 18690 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x06004903 RID: 18691 RVA: 0x0016430C File Offset: 0x0016250C
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004904 RID: 18692 RVA: 0x0016430C File Offset: 0x0016250C
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004905 RID: 18693 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06004906 RID: 18694 RVA: 0x00164329 File Offset: 0x00162529
	private void FANADGBGCPI()
	{
		this.SCShader = Shader.Find("selector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004907 RID: 18695 RVA: 0x00164350 File Offset: 0x00162550
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * this.Speed;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Alpha", this.Alpha);
			this.NBPKMLMCHFN.SetFloat("_Distance", this.Distance);
			this.NBPKMLMCHFN.SetFloat("_Size", this.Size);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004908 RID: 18696 RVA: 0x0016430C File Offset: 0x0016250C
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004909 RID: 18697 RVA: 0x0016430C File Offset: 0x0016250C
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600490A RID: 18698 RVA: 0x00164440 File Offset: 0x00162640
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("_Value8");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600490B RID: 18699 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x0600490C RID: 18700 RVA: 0x00164464 File Offset: 0x00162664
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600490D RID: 18701 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x0600490E RID: 18702 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x0600490F RID: 18703 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06004910 RID: 18704 RVA: 0x0016449B File Offset: 0x0016269B
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004911 RID: 18705 RVA: 0x0016430C File Offset: 0x0016250C
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004912 RID: 18706 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06004913 RID: 18707 RVA: 0x001644D2 File Offset: 0x001626D2
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("restart");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004914 RID: 18708 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x06004915 RID: 18709 RVA: 0x001644F6 File Offset: 0x001626F6
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("w");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004916 RID: 18710 RVA: 0x0016451A File Offset: 0x0016271A
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Light_Water");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004917 RID: 18711 RVA: 0x0016453E File Offset: 0x0016273E
	private void DKGBFNCOAEO()
	{
		this.SCShader = Shader.Find("help");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004919 RID: 18713 RVA: 0x001645A4 File Offset: 0x001627A4
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * this.Speed;
			if (this.HBJJOCHGOPH > 1797f)
			{
				this.HBJJOCHGOPH = 1469f;
			}
			this.NFMGLIKNOOC().SetFloat("SetBGColor", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("Error: Someone else(", this.Alpha);
			this.DONENAMLFLF().SetFloat("CameraFilterPack/Edge_Edge_filter", this.Distance);
			this.HKGAONMOBMH().SetFloat("Object ID. Case-Sensitive", this.Size);
			this.JLHLHKPHDFO().SetVector("Working.\nPlease wait..", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 211f, 1400f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600491A RID: 18714 RVA: 0x00164694 File Offset: 0x00162894
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("gamemode");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600491B RID: 18715 RVA: 0x001646B8 File Offset: 0x001628B8
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * this.Speed;
			if (this.HBJJOCHGOPH > 147f)
			{
				this.HBJJOCHGOPH = 1805f;
			}
			this.NFMGLIKNOOC().SetFloat("settings.volume.sfx", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("Object ID. Case-Sensitive", this.Alpha);
			this.DONENAMLFLF().SetFloat("[Right]", this.Distance);
			this.HKGAONMOBMH().SetFloat("[ResourcesManager] Load image error: ", this.Size);
			this.NBPKMLMCHFN.SetVector(" SphereWaveform.cs", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1978f, 44f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600491C RID: 18716 RVA: 0x001647A8 File Offset: 0x001629A8
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blur_GaussianBlur");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600491D RID: 18717 RVA: 0x001647CC File Offset: 0x001629CC
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("/../");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600491E RID: 18718 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x0600491F RID: 18719 RVA: 0x001647F0 File Offset: 0x001629F0
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * this.Speed;
			if (this.HBJJOCHGOPH > 1036f)
			{
				this.HBJJOCHGOPH = 1587f;
			}
			this.JLHLHKPHDFO().SetFloat("#finished", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("_Value", this.Alpha);
			this.DONENAMLFLF().SetFloat(".highscore", this.Distance);
			this.HKGAONMOBMH().SetFloat("Data/Skins/", this.Size);
			this.NBPKMLMCHFN.SetVector("SpawnObj", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1314f, 764f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004920 RID: 18720 RVA: 0x0016430C File Offset: 0x0016250C
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004921 RID: 18721 RVA: 0x001648E0 File Offset: 0x00162AE0
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * this.Speed;
			if (this.HBJJOCHGOPH > 1784f)
			{
				this.HBJJOCHGOPH = 1152f;
			}
			this.DONENAMLFLF().SetFloat("ReconnectAndRejoin() with AuthValues == null is not correct!", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("Set satellite emission (glow)", this.Alpha);
			this.FEAEGGCNIAA().SetFloat(" Time: ", this.Distance);
			this.FEAEGGCNIAA().SetFloat("RPC: 'OnAwakeRPC' Parameter: ", this.Size);
			this.FEAEGGCNIAA().SetVector("offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1438f, 1296f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004922 RID: 18722 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x06004923 RID: 18723 RVA: 0x001649D0 File Offset: 0x00162BD0
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * this.Speed;
			if (this.HBJJOCHGOPH > 924f)
			{
				this.HBJJOCHGOPH = 1931f;
			}
			this.HEHKGPKLAKK().SetFloat("--------------------------------", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("RPCs can only be sent in rooms. Call of \"", this.Alpha);
			this.JLHLHKPHDFO().SetFloat("Joystick1Button12", this.Distance);
			this.LENEJAGLCNL().SetFloat("SelectionBox component must be placed on a canvas in Screen Space Overlay mode.", this.Size);
			this.JLHLHKPHDFO().SetVector("Editor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 71f, 1589f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004924 RID: 18724 RVA: 0x00164AC0 File Offset: 0x00162CC0
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * this.Speed;
			if (this.HBJJOCHGOPH > 391f)
			{
				this.HBJJOCHGOPH = 522f;
			}
			this.NFMGLIKNOOC().SetFloat("null", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("hardcoreinfo", this.Alpha);
			this.PLBEJJIHFPB().SetFloat("_Value12", this.Distance);
			this.OCHJIMJNEMO().SetFloat("Map: ", this.Size);
			this.PLBEJJIHFPB().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1846f, 530f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004925 RID: 18725 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x06004926 RID: 18726 RVA: 0x00164BB0 File Offset: 0x00162DB0
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * this.Speed;
			if (this.HBJJOCHGOPH > 27f)
			{
				this.HBJJOCHGOPH = 1159f;
			}
			this.NBPKMLMCHFN.SetFloat("settings.cameramovements", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("CameraFilterPack/Color_GrayScale", this.Alpha);
			this.IONHGBPGCHK().SetFloat("inventory.selected.", this.Distance);
			this.NBPKMLMCHFN.SetFloat("restrictions\n\n#until: ", this.Size);
			this.NFMGLIKNOOC().SetVector("green", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 838f, 1122f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004927 RID: 18727 RVA: 0x0016430C File Offset: 0x0016250C
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004928 RID: 18728 RVA: 0x00164CA0 File Offset: 0x00162EA0
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004929 RID: 18729 RVA: 0x00164CD8 File Offset: 0x00162ED8
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * this.Speed;
			if (this.HBJJOCHGOPH > 904f)
			{
				this.HBJJOCHGOPH = 1104f;
			}
			this.PLBEJJIHFPB().SetFloat("SetSunInput", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("Sprite", this.Alpha);
			this.PLBEJJIHFPB().SetFloat("[PlayerBase] Loaded environment: ", this.Distance);
			this.JLHLHKPHDFO().SetFloat("UseFinalGlassColor", this.Size);
			this.DONENAMLFLF().SetVector("CameraFilterPack/Blend2Camera_ColorBurn", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 193f, 1441f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600492A RID: 18730 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x170000D3 RID: 211
	// (get) Token: 0x0600492B RID: 18731 RVA: 0x00164DC8 File Offset: 0x00162FC8
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

	// Token: 0x0600492C RID: 18732 RVA: 0x0016430C File Offset: 0x0016250C
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600492D RID: 18733 RVA: 0x00164DFF File Offset: 0x00162FFF
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("Joystick1Button12");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600492E RID: 18734 RVA: 0x00164E23 File Offset: 0x00163023
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600492F RID: 18735 RVA: 0x0016430C File Offset: 0x0016250C
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004930 RID: 18736 RVA: 0x00164E5A File Offset: 0x0016305A
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004931 RID: 18737 RVA: 0x00164E94 File Offset: 0x00163094
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * this.Speed;
			if (this.HBJJOCHGOPH > 1577f)
			{
				this.HBJJOCHGOPH = 120f;
			}
			this.NFMGLIKNOOC().SetFloat("_Near", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("caret", this.Alpha);
			this.OCHJIMJNEMO().SetFloat("_ScreenResolution", this.Distance);
			this.JLHLHKPHDFO().SetFloat("SetSatelliteEmission", this.Size);
			this.NBPKMLMCHFN.SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 704f, 1784f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004932 RID: 18738 RVA: 0x0016430C File Offset: 0x0016250C
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004933 RID: 18739 RVA: 0x00164F84 File Offset: 0x00163184
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * this.Speed;
			if (this.HBJJOCHGOPH > 1379f)
			{
				this.HBJJOCHGOPH = 752f;
			}
			this.JLHLHKPHDFO().SetFloat("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("_Value7", this.Alpha);
			this.IONHGBPGCHK().SetFloat("Error0", this.Distance);
			this.HKGAONMOBMH().SetFloat("FinalScoreSmallText", this.Size);
			this.NBPKMLMCHFN.SetVector("Hex value #RRGGBB", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 184f, 1889f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCHJIMJNEMO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004934 RID: 18740 RVA: 0x0016430C File Offset: 0x0016250C
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004935 RID: 18741 RVA: 0x0016430C File Offset: 0x0016250C
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004936 RID: 18742 RVA: 0x00165074 File Offset: 0x00163274
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("CameraFilterPack_Paper1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004937 RID: 18743 RVA: 0x00165098 File Offset: 0x00163298
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find("Hello World, is my item a clone? [");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004938 RID: 18744 RVA: 0x001650BC File Offset: 0x001632BC
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004939 RID: 18745 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x0600493A RID: 18746 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600493B RID: 18747 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x0600493C RID: 18748 RVA: 0x001650E0 File Offset: 0x001632E0
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600493D RID: 18749 RVA: 0x0016430C File Offset: 0x0016250C
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600493E RID: 18750 RVA: 0x00165117 File Offset: 0x00163317
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600493F RID: 18751 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x06004940 RID: 18752 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06004941 RID: 18753 RVA: 0x0016430C File Offset: 0x0016250C
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004942 RID: 18754 RVA: 0x0016514E File Offset: 0x0016334E
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004943 RID: 18755 RVA: 0x00165185 File Offset: 0x00163385
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("steamid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004944 RID: 18756 RVA: 0x001651A9 File Offset: 0x001633A9
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("There are too many cells created by your subdivision options. Maximum allowed number of cells is ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004945 RID: 18757 RVA: 0x001651D0 File Offset: 0x001633D0
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime * this.Speed;
			if (this.HBJJOCHGOPH > 160f)
			{
				this.HBJJOCHGOPH = 1744f;
			}
			this.FEAEGGCNIAA().SetFloat("0,1,false", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value", this.Alpha);
			this.PLBEJJIHFPB().SetFloat("_Offsets", this.Distance);
			this.HEHKGPKLAKK().SetFloat("CameraFilterPack/Fly_Vision", this.Size);
			this.JLHLHKPHDFO().SetVector("Edited unlock conditions", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1891f, 187f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004946 RID: 18758 RVA: 0x001652C0 File Offset: 0x001634C0
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004947 RID: 18759 RVA: 0x0016428D File Offset: 0x0016248D
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004948 RID: 18760 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06004949 RID: 18761 RVA: 0x001652F7 File Offset: 0x001634F7
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find(" - LOCAL");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x040007B1 RID: 1969
	public Shader SCShader;

	// Token: 0x040007B2 RID: 1970
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040007B3 RID: 1971
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040007B4 RID: 1972
	private Material BJFKDHHMLJH;

	// Token: 0x040007B5 RID: 1973
	[Range(0f, 1f)]
	public float Size = 4f;

	// Token: 0x040007B6 RID: 1974
	[Range(0f, 2f)]
	public float Alpha = 0.07f;

	// Token: 0x040007B7 RID: 1975
	[Range(0f, 32f)]
	public float Distance = 10f;

	// Token: 0x040007B8 RID: 1976
	[Range(-2f, 2f)]
	public float Speed = 0.4f;
}
