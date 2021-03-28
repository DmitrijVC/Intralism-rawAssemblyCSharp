using System;
using UnityEngine;

// Token: 0x02000039 RID: 57
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/Blend")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_Blend : MonoBehaviour
{
	// Token: 0x06000F2E RID: 3886 RVA: 0x0006B5AE File Offset: 0x000697AE
	private void DLMPALHKMON()
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

	// Token: 0x06000F2F RID: 3887 RVA: 0x0006B5E8 File Offset: 0x000697E8
	private void FEHCNJLLJMP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -80);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000F30 RID: 3888 RVA: 0x0006B651 File Offset: 0x00069851
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F31 RID: 3889 RVA: 0x0006B5AE File Offset: 0x000697AE
	private void HGDDCINLDAD()
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

	// Token: 0x06000F32 RID: 3890 RVA: 0x0006B688 File Offset: 0x00069888
	private void ELANJOHIJME()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -77);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F33 RID: 3891 RVA: 0x0006B5AE File Offset: 0x000697AE
	private void ODGMCJILIHF()
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

	// Token: 0x06000F34 RID: 3892 RVA: 0x0006B6C4 File Offset: 0x000698C4
	private void LIBGAKMKHJJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -113);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F35 RID: 3893 RVA: 0x0006B72D File Offset: 0x0006992D
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F36 RID: 3894 RVA: 0x0006B764 File Offset: 0x00069964
	private void BMOFEBKGLFI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -64);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F37 RID: 3895 RVA: 0x0002523B File Offset: 0x0002343B
	private void FGNFILLNPJK()
	{
	}

	// Token: 0x06000F38 RID: 3896 RVA: 0x0006B5AE File Offset: 0x000697AE
	private void KMOCDAOKGLI()
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

	// Token: 0x06000F39 RID: 3897 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06000F3A RID: 3898 RVA: 0x0006B7D0 File Offset: 0x000699D0
	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1451f)
			{
				this.HBJJOCHGOPH = 1526f;
			}
			this.IONHGBPGCHK().SetTexture("[EditorEvent] Exception: ", this.JDMCFBKJHDD);
			this.OIIDAKBILMI().SetFloat("_Green_G", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("_MaxBlurRadius", this.BlendFX);
			this.IONHGBPGCHK().SetVector("_Offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1773f, 8f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F3C RID: 3900 RVA: 0x0006B8CC File Offset: 0x00069ACC
	private void HAIAHJPCPAG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 87);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F3D RID: 3901 RVA: 0x0006B938 File Offset: 0x00069B38
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.JDMCFBKJHDD);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value", this.BlendFX);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F3E RID: 3902 RVA: 0x0006BA0B File Offset: 0x00069C0B
	private void PLNLNCDPPGG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -89);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F3F RID: 3903 RVA: 0x0006BA46 File Offset: 0x00069C46
	private void LIFBFDKFMMH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -121);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F40 RID: 3904 RVA: 0x0006BA81 File Offset: 0x00069C81
	private void NLGDPIBFHMK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 107);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F41 RID: 3905 RVA: 0x0006B5AE File Offset: 0x000697AE
	private void DHENLPJJOEN()
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

	// Token: 0x06000F42 RID: 3906 RVA: 0x0006BABC File Offset: 0x00069CBC
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1322f)
			{
				this.HBJJOCHGOPH = 992f;
			}
			this.DBOLLHHMKKN().SetTexture("_HSV", this.JDMCFBKJHDD);
			this.OIIDAKBILMI().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("Editor", this.BlendFX);
			this.JLHLHKPHDFO().SetVector("[PlayerBase] Checkpoint error: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 675f, 1748f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F43 RID: 3907 RVA: 0x0006BB8F File Offset: 0x00069D8F
	private void BFKANNFLAKP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -102);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F44 RID: 3908 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06000F45 RID: 3909 RVA: 0x0006BBCC File Offset: 0x00069DCC
	private void JHANGPCOCIG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 121);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F46 RID: 3910 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06000F47 RID: 3911 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06000F48 RID: 3912 RVA: 0x0006BC35 File Offset: 0x00069E35
	private void HJDPEBAPBPN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -13);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F49 RID: 3913 RVA: 0x0006BC70 File Offset: 0x00069E70
	private void LJEDJDGPGFG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -113);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F4A RID: 3914 RVA: 0x0006BCAB File Offset: 0x00069EAB
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F4B RID: 3915 RVA: 0x0006B5AE File Offset: 0x000697AE
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

	// Token: 0x06000F4C RID: 3916 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06000F4D RID: 3917 RVA: 0x0006BCE2 File Offset: 0x00069EE2
	private void GHMDNIFLGOB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -126);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F4E RID: 3918 RVA: 0x0006BD1D File Offset: 0x00069F1D
	private void HPGKMAIPDEO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 44);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F4F RID: 3919 RVA: 0x0006BD58 File Offset: 0x00069F58
	private void LHGFCBDACBM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -12);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F50 RID: 3920 RVA: 0x0006B5AE File Offset: 0x000697AE
	private void EKCDEFDELMP()
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

	// Token: 0x06000F51 RID: 3921 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06000F52 RID: 3922 RVA: 0x0006BD94 File Offset: 0x00069F94
	private void JDKHBGDEONK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -23);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000F53 RID: 3923 RVA: 0x0006BDFD File Offset: 0x00069FFD
	private void KFCCKOBOLAH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -63);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F54 RID: 3924 RVA: 0x0002523B File Offset: 0x0002343B
	private void EPJJDKJEDMM()
	{
	}

	// Token: 0x06000F55 RID: 3925 RVA: 0x0006B5AE File Offset: 0x000697AE
	private void OFPPIKHNJOD()
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

	// Token: 0x06000F56 RID: 3926 RVA: 0x0006BE38 File Offset: 0x0006A038
	private void DBLILJGKGHJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -71);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000F57 RID: 3927 RVA: 0x0006BEA1 File Offset: 0x0006A0A1
	private Material GJHPODJOBHL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F58 RID: 3928 RVA: 0x0006BED8 File Offset: 0x0006A0D8
	private void JECMJNFGBGC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 13);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F59 RID: 3929 RVA: 0x0006BF44 File Offset: 0x0006A144
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 187f)
			{
				this.HBJJOCHGOPH = 62f;
			}
			this.OLHDPICFBOF().SetTexture("PhotonView with ID ", this.JDMCFBKJHDD);
			this.OCHJIMJNEMO().SetFloat("PopulateMapsList", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("CameraFilterPack/EXTRA_SHOWFPS", this.BlendFX);
			this.OCHJIMJNEMO().SetVector("Set satellite color", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1709f, 579f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F5A RID: 3930 RVA: 0x0006C018 File Offset: 0x0006A218
	private void KNBJBNDGCIJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 109);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000F5B RID: 3931 RVA: 0x0006B5AE File Offset: 0x000697AE
	private void IMGGCJICLHK()
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

	// Token: 0x06000F5C RID: 3932 RVA: 0x0006C084 File Offset: 0x0006A284
	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 664f)
			{
				this.HBJJOCHGOPH = 1487f;
			}
			this.NBPKMLMCHFN.SetTexture("CameraFilterPack_AAA_Blood_Hit1", this.JDMCFBKJHDD);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/TV_MovieNoise", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("_Value3", this.BlendFX);
			this.NBPKMLMCHFN.SetVector("OnMastedChangeScene", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 208f, 378f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F5D RID: 3933 RVA: 0x0006C158 File Offset: 0x0006A358
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1449f)
			{
				this.HBJJOCHGOPH = 1775f;
			}
			this.JFDGLLEOPGB().SetTexture("GameScene", this.JDMCFBKJHDD);
			this.DONENAMLFLF().SetFloat("powerup.0", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("UseFinalGlassColor", this.BlendFX);
			this.DBOLLHHMKKN().SetVector("Joystick1Button3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1579f, 813f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x06000F5E RID: 3934 RVA: 0x0006C22B File Offset: 0x0006A42B
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

	// Token: 0x06000F5F RID: 3935 RVA: 0x0006C264 File Offset: 0x0006A464
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 434f)
			{
				this.HBJJOCHGOPH = 1610f;
			}
			this.DBOLLHHMKKN().SetTexture(": ", this.JDMCFBKJHDD);
			this.DBOLLHHMKKN().SetFloat("ArcsDestroyDelaySlider", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("CameraFilterPack/TV_WideScreenVertical", this.BlendFX);
			this.JFDGLLEOPGB().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1136f, 1981f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F60 RID: 3936 RVA: 0x0006B5AE File Offset: 0x000697AE
	private void PAEGLMEOKHP()
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

	// Token: 0x06000F61 RID: 3937 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06000F62 RID: 3938 RVA: 0x0006C337 File Offset: 0x0006A537
	private void CCKABCDEOJC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 96);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F63 RID: 3939 RVA: 0x0006C372 File Offset: 0x0006A572
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F64 RID: 3940 RVA: 0x0006B5AE File Offset: 0x000697AE
	private void EJJEDJIOFAB()
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

	// Token: 0x06000F65 RID: 3941 RVA: 0x0006C3A9 File Offset: 0x0006A5A9
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-68);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F66 RID: 3942 RVA: 0x0006C3E0 File Offset: 0x0006A5E0
	private void AEDDNDHCLNN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 82);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000F67 RID: 3943 RVA: 0x0006C449 File Offset: 0x0006A649
	private void MDMDGKHDPKP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -48);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F68 RID: 3944 RVA: 0x0006C484 File Offset: 0x0006A684
	private void GHICDLBKEJN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 39);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F69 RID: 3945 RVA: 0x0006C4BF File Offset: 0x0006A6BF
	private void DPGHJILBPCE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -104);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F6A RID: 3946 RVA: 0x0006C4FC File Offset: 0x0006A6FC
	private void IDJKNBDKHBD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -81);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000F6B RID: 3947 RVA: 0x0006C565 File Offset: 0x0006A765
	private void BILILBEBLFL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 41);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F6C RID: 3948 RVA: 0x0006C5A0 File Offset: 0x0006A7A0
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1468f)
			{
				this.HBJJOCHGOPH = 231f;
			}
			this.OLHDPICFBOF().SetTexture(" not found", this.JDMCFBKJHDD);
			this.JFDGLLEOPGB().SetFloat("_Radius2", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("CameraFilterPack/Drawing_Paper2", this.BlendFX);
			this.OLHDPICFBOF().SetVector("Submition failed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 65f, 296f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F6D RID: 3949 RVA: 0x0006C673 File Offset: 0x0006A873
	private void KPLKDJFKPDI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -26);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F6E RID: 3950 RVA: 0x0006C6AE File Offset: 0x0006A8AE
	private void KHDANGFKIGL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 68);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F6F RID: 3951 RVA: 0x0006C6EC File Offset: 0x0006A8EC
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1753f)
			{
				this.HBJJOCHGOPH = 1196f;
			}
			this.GJHPODJOBHL().SetTexture("settings.cameramovements", this.JDMCFBKJHDD);
			this.OIIDAKBILMI().SetFloat("CameraFilterPack/Vision_Hell_Blood", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("downloading", this.BlendFX);
			this.JFDGLLEOPGB().SetVector("CameraFilterPack/Distortion_ShockWave", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1984f, 143f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F70 RID: 3952 RVA: 0x0006BD58 File Offset: 0x00069F58
	private void GJPONJKJICG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -12);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F71 RID: 3953 RVA: 0x0006C7BF File Offset: 0x0006A9BF
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F72 RID: 3954 RVA: 0x0006C7F6 File Offset: 0x0006A9F6
	private void MIAMLFNACAI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -17);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F73 RID: 3955 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06000F74 RID: 3956 RVA: 0x0006C834 File Offset: 0x0006AA34
	private void HMPGIFBJFIK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -10);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F75 RID: 3957 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06000F76 RID: 3958 RVA: 0x0006C89D File Offset: 0x0006AA9D
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F77 RID: 3959 RVA: 0x0006C8D4 File Offset: 0x0006AAD4
	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 906f)
			{
				this.HBJJOCHGOPH = 1672f;
			}
			this.OIIDAKBILMI().SetTexture("_Bloom0", this.JDMCFBKJHDD);
			this.OIIDAKBILMI().SetFloat(" (now: ", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("MenuPlayButton", this.BlendFX);
			this.OLHDPICFBOF().SetVector("ItemNameBGImage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1987f, 1159f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F78 RID: 3960 RVA: 0x0006C9A8 File Offset: 0x0006ABA8
	private void CNGAJDBOCLJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -21);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F79 RID: 3961 RVA: 0x0006B5AE File Offset: 0x000697AE
	private void EAHCLIEEJOG()
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

	// Token: 0x06000F7A RID: 3962 RVA: 0x0006CA14 File Offset: 0x0006AC14
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 848f)
			{
				this.HBJJOCHGOPH = 872f;
			}
			this.IONHGBPGCHK().SetTexture("_PrefilterOffs", this.JDMCFBKJHDD);
			this.OCHJIMJNEMO().SetFloat("Object ID. Case-Sensitive", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("<b>(╯°□°）╯︵ ┻━┻</b>", this.BlendFX);
			this.JFDGLLEOPGB().SetVector("SetRotation", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 483f, 1941f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F7B RID: 3963 RVA: 0x0006CAE7 File Offset: 0x0006ACE7
	private void JDCJBNHAFCI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 27);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F7C RID: 3964 RVA: 0x0006CB24 File Offset: 0x0006AD24
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 978f)
			{
				this.HBJJOCHGOPH = 778f;
			}
			this.NBPKMLMCHFN.SetTexture("skin.", this.JDMCFBKJHDD);
			this.JFDGLLEOPGB().SetFloat("PhotonMono", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("</b>", this.BlendFX);
			this.GJHPODJOBHL().SetVector("Preparing configuration", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 234f, 1350f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F7D RID: 3965 RVA: 0x0006B5AE File Offset: 0x000697AE
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

	// Token: 0x06000F7E RID: 3966 RVA: 0x0006CBF7 File Offset: 0x0006ADF7
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F7F RID: 3967 RVA: 0x0006CC30 File Offset: 0x0006AE30
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

	// Token: 0x06000F80 RID: 3968 RVA: 0x0006CC99 File Offset: 0x0006AE99
	private void HGPLPMCJNLL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -122);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F81 RID: 3969 RVA: 0x0006CCD4 File Offset: 0x0006AED4
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F82 RID: 3970 RVA: 0x0006CD0F File Offset: 0x0006AF0F
	private void FNGDOKOAKLA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -127);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F83 RID: 3971 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x06000F84 RID: 3972 RVA: 0x0006CD4C File Offset: 0x0006AF4C
	private void DKGBFNCOAEO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 93);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000F85 RID: 3973 RVA: 0x0006B5AE File Offset: 0x000697AE
	private void OCCGJMPAJIK()
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

	// Token: 0x06000F86 RID: 3974 RVA: 0x0006CDB5 File Offset: 0x0006AFB5
	private void KOCPGJCINKD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 54);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F87 RID: 3975 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x06000F88 RID: 3976 RVA: 0x0006CDF0 File Offset: 0x0006AFF0
	private void FLKEJJEGCFA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 37);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F89 RID: 3977 RVA: 0x0006CE59 File Offset: 0x0006B059
	private void CAOLLBOBPFF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 77);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F8A RID: 3978 RVA: 0x0006B5AE File Offset: 0x000697AE
	private void CNDACAHCCOI()
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

	// Token: 0x06000F8B RID: 3979 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOLDLDLFFLM()
	{
	}

	// Token: 0x06000F8C RID: 3980 RVA: 0x0006CE94 File Offset: 0x0006B094
	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 24f)
			{
				this.HBJJOCHGOPH = 964f;
			}
			this.NBPKMLMCHFN.SetTexture("_TimeX", this.JDMCFBKJHDD);
			this.OLHDPICFBOF().SetFloat("CameraFilterPack/Color_Chromatic_Plus", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("_FixDistance", this.BlendFX);
			this.GJHPODJOBHL().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1008f, 1394f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F8D RID: 3981 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x06000F8E RID: 3982 RVA: 0x0006CCD4 File Offset: 0x0006AED4
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F8F RID: 3983 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06000F90 RID: 3984 RVA: 0x0006CF68 File Offset: 0x0006B168
	private void COIJKMKIEAK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -89);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F91 RID: 3985 RVA: 0x0006CFD4 File Offset: 0x0006B1D4
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1992f)
			{
				this.HBJJOCHGOPH = 107f;
			}
			this.NDMPCDHADMJ().SetTexture("MainButton", this.JDMCFBKJHDD);
			this.OIIDAKBILMI().SetFloat("BadgeImage", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("_DistortionSize", this.BlendFX);
			this.GJHPODJOBHL().SetVector("ready", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 207f, 1382f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F92 RID: 3986 RVA: 0x0006D0A7 File Offset: 0x0006B2A7
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000F93 RID: 3987 RVA: 0x0006B5AE File Offset: 0x000697AE
	private void IFIHBNJKEKD()
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

	// Token: 0x06000F94 RID: 3988 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x06000F95 RID: 3989 RVA: 0x0002523B File Offset: 0x0002343B
	private void PNLKFANNOKO()
	{
	}

	// Token: 0x06000F96 RID: 3990 RVA: 0x0006D0DE File Offset: 0x0006B2DE
	private void OLAGABIMGDA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 35);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06000F97 RID: 3991 RVA: 0x0006D11C File Offset: 0x0006B31C
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1047f)
			{
				this.HBJJOCHGOPH = 84f;
			}
			this.NDMPCDHADMJ().SetTexture("_Size", this.JDMCFBKJHDD);
			this.OCHJIMJNEMO().SetFloat("No", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("ShadersToggle", this.BlendFX);
			this.OCHJIMJNEMO().SetVector(") of this PhotonView does not implement OnPhotonSerializeView()!", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 769f, 146f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000F98 RID: 3992 RVA: 0x0006D1F0 File Offset: 0x0006B3F0
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 978f)
			{
				this.HBJJOCHGOPH = 701f;
			}
			this.OCHJIMJNEMO().SetTexture("_TimeX", this.JDMCFBKJHDD);
			this.NDMPCDHADMJ().SetFloat("note.0", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Set Sun MinSize", this.BlendFX);
			this.OIIDAKBILMI().SetVector("/icon", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 165f, 1182f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x04000237 RID: 567
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Blend";

	// Token: 0x04000238 RID: 568
	public Shader SCShader;

	// Token: 0x04000239 RID: 569
	public Camera Camera2;

	// Token: 0x0400023A RID: 570
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400023B RID: 571
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400023C RID: 572
	private Material BJFKDHHMLJH;

	// Token: 0x0400023D RID: 573
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x0400023E RID: 574
	private RenderTexture JDMCFBKJHDD;
}
