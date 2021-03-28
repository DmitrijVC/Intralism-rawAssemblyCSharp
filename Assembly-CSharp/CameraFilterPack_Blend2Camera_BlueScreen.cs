using System;
using UnityEngine;

// Token: 0x0200003A RID: 58
[AddComponentMenu("Camera Filter Pack/Chroma Key/BlueScreen")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_BlueScreen : MonoBehaviour
{
	// Token: 0x06000F99 RID: 3993 RVA: 0x0006D2C3 File Offset: 0x0006B4C3
	private void Update()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06000F9A RID: 3994 RVA: 0x0006D2F1 File Offset: 0x0006B4F1
	private void ANKALNDLHEL()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06000F9B RID: 3995 RVA: 0x0006D315 File Offset: 0x0006B515
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

	// Token: 0x06000F9C RID: 3996 RVA: 0x0006D350 File Offset: 0x0006B550
	private void EIMNPCMHJLJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -39);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000F9D RID: 3997 RVA: 0x0006D2C3 File Offset: 0x0006B4C3
	private void HIFLPHLGLFG()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06000F9E RID: 3998 RVA: 0x0006D2C3 File Offset: 0x0006B4C3
	private void DGCGGKMNPLD()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06000F9F RID: 3999 RVA: 0x0006D2F1 File Offset: 0x0006B4F1
	private void MLAGEPNCCGM()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06000FA0 RID: 4000 RVA: 0x0006D2F1 File Offset: 0x0006B4F1
	private void EBBMDDEFNKL()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06000FA1 RID: 4001 RVA: 0x0006D2F1 File Offset: 0x0006B4F1
	private void FNGDOKOAKLA()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06000FA2 RID: 4002 RVA: 0x0006D2F1 File Offset: 0x0006B4F1
	private void JGDCNDNCFNG()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06000FA3 RID: 4003 RVA: 0x0006D3C7 File Offset: 0x0006B5C7
	private void OnEnable()
	{
		this.Start();
	}

	// Token: 0x06000FA4 RID: 4004 RVA: 0x0006D315 File Offset: 0x0006B515
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

	// Token: 0x06000FA5 RID: 4005 RVA: 0x0006D2F1 File Offset: 0x0006B4F1
	private void GFELOCODMPJ()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06000FA6 RID: 4006 RVA: 0x0006D3D0 File Offset: 0x0006B5D0
	private void HMPGIFBJFIK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -116);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000FA7 RID: 4007 RVA: 0x0006D448 File Offset: 0x0006B648
	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 508f)
			{
				this.HBJJOCHGOPH = 1326f;
			}
			if (this.Camera2 != null)
			{
				this.NFKFAAHHLLM().SetTexture("maps.", this.JDMCFBKJHDD);
			}
			this.NLFJGMBCICG().SetFloat("[Up]", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat("mapselector.lastSearch", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("SetSunMinSize", this.Adjust);
			this.HKIMAANBGMJ().SetFloat("Default UI Material", this.Precision);
			this.NFKFAAHHLLM().SetFloat("player.rgb", this.Luminosity);
			this.IFMAPIDFNLI().SetFloat("Editor/", this.Change_Red);
			this.LPCHMEKDCHI().SetFloat("Bad parameters for init! Use \"init\" or \"init <savename>\"", this.Change_Green);
			this.OLHDPICFBOF().SetFloat("maps.", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000FA8 RID: 4008 RVA: 0x0006D2F1 File Offset: 0x0006B4F1
	private void FGIOPGGPLMB()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06000FA9 RID: 4009 RVA: 0x0006D584 File Offset: 0x0006B784
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 813f)
			{
				this.HBJJOCHGOPH = 1656f;
			}
			if (this.Camera2 != null)
			{
				this.ADGHJOHKEHG().SetTexture("Received RPC: ", this.JDMCFBKJHDD);
			}
			this.ADGHJOHKEHG().SetFloat("[LocalizationService] Error: ", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Hidden/Subpixel Morphological Anti-aliasing", this.BlendFX);
			this.FLOHGDECHHH().SetFloat("_OnOff", this.Adjust);
			this.KJMECMIGJJA().SetFloat("/", this.Precision);
			this.IONHGBPGCHK().SetFloat("3", this.Luminosity);
			this.NLFJGMBCICG().SetFloat("SetSatelliteLerpSpeed", this.Change_Red);
			this.DKKBFFHBHJE().SetFloat("mine", this.Change_Green);
			this.NLFJGMBCICG().SetFloat("[Up-Left]", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000FAA RID: 4010 RVA: 0x0006D6C0 File Offset: 0x0006B8C0
	private void PKLOBJHKFEO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -40);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000FAB RID: 4011 RVA: 0x0006D2F1 File Offset: 0x0006B4F1
	private void PCGODOELOHG()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06000FAC RID: 4012 RVA: 0x0006D737 File Offset: 0x0006B937
	private void MEJPBKFMAIG()
	{
		this.FBPHNEJBDJN();
	}

	// Token: 0x06000FAD RID: 4013 RVA: 0x0006D2C3 File Offset: 0x0006B4C3
	private void IEMEHGCFAPD()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06000FAE RID: 4014 RVA: 0x0006D2C3 File Offset: 0x0006B4C3
	private void MMBPLGGLPDB()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06000FAF RID: 4015 RVA: 0x0006D73F File Offset: 0x0006B93F
	private void HIFPDKKBDHJ()
	{
		this.FIJHDKIPENG();
	}

	// Token: 0x06000FB0 RID: 4016 RVA: 0x0006D315 File Offset: 0x0006B515
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

	// Token: 0x06000FB1 RID: 4017 RVA: 0x0006D2C3 File Offset: 0x0006B4C3
	private void LKJMIODJGCM()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06000FB2 RID: 4018 RVA: 0x0006D748 File Offset: 0x0006B948
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 836f)
			{
				this.HBJJOCHGOPH = 596f;
			}
			if (this.Camera2 != null)
			{
				this.OLHDPICFBOF().SetTexture("Set Object Rotation", this.JDMCFBKJHDD);
			}
			this.ADGHJOHKEHG().SetFloat("SetParticlesGravity", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat("CameraFilterPack/RainFX", this.BlendFX);
			this.FLOHGDECHHH().SetFloat("LevelConfigButton", this.Adjust);
			this.FLOHGDECHHH().SetFloat("YES", this.Precision);
			this.NLFJGMBCICG().SetFloat("_Value3", this.Luminosity);
			this.NBPKMLMCHFN.SetFloat("Connected to NameServer.", this.Change_Red);
			this.IFMAPIDFNLI().SetFloat("[MapsEditor] Creating new item...", this.Change_Green);
			this.IIJMIPBMMBF().SetFloat("Set satellite radius (offset)", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000FB3 RID: 4019 RVA: 0x0006D315 File Offset: 0x0006B515
	private void JLNNHKPHMAB()
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

	// Token: 0x06000FB4 RID: 4020 RVA: 0x0006D883 File Offset: 0x0006BA83
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000FB5 RID: 4021 RVA: 0x0006D2C3 File Offset: 0x0006B4C3
	private void IBHACCEEFFI()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06000FB6 RID: 4022 RVA: 0x0006D8BC File Offset: 0x0006BABC
	private void FBPHNEJBDJN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 126);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000FB7 RID: 4023 RVA: 0x0006D2C3 File Offset: 0x0006B4C3
	private void APKNAPHOFHC()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06000FB8 RID: 4024 RVA: 0x0006D315 File Offset: 0x0006B515
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

	// Token: 0x06000FB9 RID: 4025 RVA: 0x0006D934 File Offset: 0x0006BB34
	private void MMOKKAPFGAK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 21);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000FBA RID: 4026 RVA: 0x0006D3C7 File Offset: 0x0006B5C7
	private void NGEGCLCPPCD()
	{
		this.Start();
	}

	// Token: 0x06000FBB RID: 4027 RVA: 0x0006D315 File Offset: 0x0006B515
	private void KLOLKEBAPFO()
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

	// Token: 0x06000FBC RID: 4028 RVA: 0x0006D9AC File Offset: 0x0006BBAC
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1376f)
			{
				this.HBJJOCHGOPH = 1651f;
			}
			if (this.Camera2 != null)
			{
				this.HKIMAANBGMJ().SetTexture("] ", this.JDMCFBKJHDD);
			}
			this.NLFJGMBCICG().SetFloat("red", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("%", this.BlendFX);
			this.IIJMIPBMMBF().SetFloat("_RangeScale", this.Adjust);
			this.KJMECMIGJJA().SetFloat("Right", this.Precision);
			this.IIJMIPBMMBF().SetFloat("Default color's lerp speed of color changing. Greater values means faster changing. 0 - intant change.", this.Luminosity);
			this.IONHGBPGCHK().SetFloat(".", this.Change_Red);
			this.HKIMAANBGMJ().SetFloat("AuthenticationValues UserId: {0}, GetParameters: {1} Token available: {2}", this.Change_Green);
			this.IFMAPIDFNLI().SetFloat("english", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000FBD RID: 4029 RVA: 0x0006DAE7 File Offset: 0x0006BCE7
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000FBE RID: 4030 RVA: 0x0006DB1E File Offset: 0x0006BD1E
	private void KCGJMAFGAGH()
	{
		this.KLILJHJNICK();
	}

	// Token: 0x06000FBF RID: 4031 RVA: 0x0006DB28 File Offset: 0x0006BD28
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 836f)
			{
				this.HBJJOCHGOPH = 1178f;
			}
			if (this.Camera2 != null)
			{
				this.IIJMIPBMMBF().SetTexture("_TimeX", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("PublishButton", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("_ScreenResolution", this.BlendFX);
			this.FLOHGDECHHH().SetFloat("Fade", this.Adjust);
			this.FLOHGDECHHH().SetFloat("menu.relaxinfo", this.Precision);
			this.NFKFAAHHLLM().SetFloat(" item(s) in inventory", this.Luminosity);
			this.KJMECMIGJJA().SetFloat("The image effect ", this.Change_Red);
			this.LPCHMEKDCHI().SetFloat("Bad parameters for setstring! Use <key> <value>", this.Change_Green);
			this.HKIMAANBGMJ().SetFloat("_Value2", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000FC0 RID: 4032 RVA: 0x0006DC63 File Offset: 0x0006BE63
	private Material IFMAPIDFNLI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000FC1 RID: 4033 RVA: 0x0006DC9A File Offset: 0x0006BE9A
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000FC2 RID: 4034 RVA: 0x0006D2C3 File Offset: 0x0006B4C3
	private void OCMKCBBCEFG()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06000FC3 RID: 4035 RVA: 0x0006DCD1 File Offset: 0x0006BED1
	private Material HKIMAANBGMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000FC4 RID: 4036 RVA: 0x0006D2F1 File Offset: 0x0006B4F1
	private void KPLKDJFKPDI()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06000FC5 RID: 4037 RVA: 0x0006DB1E File Offset: 0x0006BD1E
	private void FDIJLKIIMLL()
	{
		this.KLILJHJNICK();
	}

	// Token: 0x06000FC6 RID: 4038 RVA: 0x0006D2F1 File Offset: 0x0006B4F1
	private void OnValidate()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06000FC7 RID: 4039 RVA: 0x0006DD08 File Offset: 0x0006BF08
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000FC8 RID: 4040 RVA: 0x0006DD40 File Offset: 0x0006BF40
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1527f)
			{
				this.HBJJOCHGOPH = 1909f;
			}
			if (this.Camera2 != null)
			{
				this.NLFJGMBCICG().SetTexture("_ScreenResolution", this.JDMCFBKJHDD);
			}
			this.ADGHJOHKEHG().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat("misses", this.BlendFX);
			this.FLOHGDECHHH().SetFloat("HighScaleShot", this.Adjust);
			this.HKIMAANBGMJ().SetFloat("{0}", this.Precision);
			this.NBPKMLMCHFN.SetFloat("settings.crosshairopacity", this.Luminosity);
			this.NFKFAAHHLLM().SetFloat("_TempTexture", this.Change_Red);
			this.LPCHMEKDCHI().SetFloat("Brightness", this.Change_Green);
			this.KJMECMIGJJA().SetFloat("_ScreenResolution", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000FC9 RID: 4041 RVA: 0x0006DE7B File Offset: 0x0006C07B
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000FCA RID: 4042 RVA: 0x0006DEB2 File Offset: 0x0006C0B2
	private void HENBNNAGIKN()
	{
		this.EIMNPCMHJLJ();
	}

	// Token: 0x06000FCB RID: 4043 RVA: 0x0006D2F1 File Offset: 0x0006B4F1
	private void MEMKLOMFFJO()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06000FCC RID: 4044 RVA: 0x0006D315 File Offset: 0x0006B515
	private void LINKAMEPKGM()
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

	// Token: 0x06000FCD RID: 4045 RVA: 0x0006D73F File Offset: 0x0006B93F
	private void CNHEENCFCMF()
	{
		this.FIJHDKIPENG();
	}

	// Token: 0x06000FCE RID: 4046 RVA: 0x0006D2C3 File Offset: 0x0006B4C3
	private void NEKCPLGFOFD()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06000FCF RID: 4047 RVA: 0x0006D315 File Offset: 0x0006B515
	private void AOKOLPEGHDD()
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

	// Token: 0x06000FD0 RID: 4048 RVA: 0x0006DEBA File Offset: 0x0006C0BA
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000FD1 RID: 4049 RVA: 0x0006DEF4 File Offset: 0x0006C0F4
	private void PAKPHKPDKGE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 4);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000FD2 RID: 4050 RVA: 0x0006D2C3 File Offset: 0x0006B4C3
	private void LCHBFNIPBHB()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06000FD3 RID: 4051 RVA: 0x0006DF6B File Offset: 0x0006C16B
	private void MBNMADBPDLL()
	{
		this.CCLNNLCOPBL();
	}

	// Token: 0x06000FD4 RID: 4052 RVA: 0x0006D315 File Offset: 0x0006B515
	private void JOONHGHGKKF()
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

	// Token: 0x06000FD5 RID: 4053 RVA: 0x0006D315 File Offset: 0x0006B515
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

	// Token: 0x06000FD6 RID: 4054 RVA: 0x0006D315 File Offset: 0x0006B515
	private void JOJFHFHOCHO()
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

	// Token: 0x06000FD7 RID: 4055 RVA: 0x0006D2C3 File Offset: 0x0006B4C3
	private void GPFJMKCGHGB()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06000FD8 RID: 4056 RVA: 0x0006D3C7 File Offset: 0x0006B5C7
	private void HIDOPHINPAL()
	{
		this.Start();
	}

	// Token: 0x06000FD9 RID: 4057 RVA: 0x0006D2F1 File Offset: 0x0006B4F1
	private void HFLHDMPHOJA()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06000FDA RID: 4058 RVA: 0x0006D315 File Offset: 0x0006B515
	private void PNNPDMHLFHE()
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

	// Token: 0x06000FDB RID: 4059 RVA: 0x0006D2F1 File Offset: 0x0006B4F1
	private void MNHCBAKPBCF()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06000FDC RID: 4060 RVA: 0x0006DF74 File Offset: 0x0006C174
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 319f)
			{
				this.HBJJOCHGOPH = 555f;
			}
			if (this.Camera2 != null)
			{
				this.HKIMAANBGMJ().SetTexture("Connected to masterserver.", this.JDMCFBKJHDD);
			}
			this.NLFJGMBCICG().SetFloat("ScoreText", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("Lerp speed. Recomended 10", this.BlendFX);
			this.HKIMAANBGMJ().SetFloat("z", this.Adjust);
			this.DKKBFFHBHJE().SetFloat("curScn", this.Precision);
			this.FLOHGDECHHH().SetFloat(" beatThreshold: ", this.Luminosity);
			this.HKIMAANBGMJ().SetFloat("_MainTex2", this.Change_Red);
			this.DKKBFFHBHJE().SetFloat("{0}", this.Change_Green);
			this.NFKFAAHHLLM().SetFloat("] ", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000FDD RID: 4061 RVA: 0x0006D2C3 File Offset: 0x0006B4C3
	private void JOACBIEHHCE()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06000FDE RID: 4062 RVA: 0x0006E0B0 File Offset: 0x0006C2B0
	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1896f)
			{
				this.HBJJOCHGOPH = 1790f;
			}
			if (this.Camera2 != null)
			{
				this.FLOHGDECHHH().SetTexture("_ScreenResolution", this.JDMCFBKJHDD);
			}
			this.ADGHJOHKEHG().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("LoadingStatusText", this.BlendFX);
			this.DKKBFFHBHJE().SetFloat("_MatrixSpeed", this.Adjust);
			this.HKIMAANBGMJ().SetFloat("Hidden/LensAberrations", this.Precision);
			this.LPCHMEKDCHI().SetFloat("[MapsStats] Map ID: ", this.Luminosity);
			this.IFMAPIDFNLI().SetFloat("CameraFilterPack/FX_Hexagon_Black", this.Change_Red);
			this.FLOHGDECHHH().SetFloat("_Quality", this.Change_Green);
			this.NFKFAAHHLLM().SetFloat("_Value", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000FDF RID: 4063 RVA: 0x0006E1EB File Offset: 0x0006C3EB
	private void AAPMAEFHKEO()
	{
		this.BEBNOKFLJPH();
	}

	// Token: 0x06000FE0 RID: 4064 RVA: 0x0006E1F4 File Offset: 0x0006C3F4
	private void FEKECCBFGMI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -71);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000FE1 RID: 4065 RVA: 0x0006E26B File Offset: 0x0006C46B
	private void BDBKIEIIFPB()
	{
		this.LBAJLLFMMMP();
	}

	// Token: 0x06000FE2 RID: 4066 RVA: 0x0006D315 File Offset: 0x0006B515
	private void LAMEHAHJKMI()
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

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x06000FE3 RID: 4067 RVA: 0x0006E273 File Offset: 0x0006C473
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

	// Token: 0x06000FE4 RID: 4068 RVA: 0x0006E2AC File Offset: 0x0006C4AC
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 957f)
			{
				this.HBJJOCHGOPH = 635f;
			}
			if (this.Camera2 != null)
			{
				this.IONHGBPGCHK().SetTexture(".message", this.JDMCFBKJHDD);
			}
			this.KJMECMIGJJA().SetFloat("value", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("_AlphaHexa", this.BlendFX);
			this.IFMAPIDFNLI().SetFloat("player.mysteryitem", this.Adjust);
			this.ADGHJOHKEHG().SetFloat("Square", this.Precision);
			this.OLHDPICFBOF().SetFloat("_TimeX", this.Luminosity);
			this.NLFJGMBCICG().SetFloat("LevelInfoInputField", this.Change_Red);
			this.HKIMAANBGMJ().SetFloat("_Value2", this.Change_Green);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000FE5 RID: 4069 RVA: 0x0006E3E7 File Offset: 0x0006C5E7
	private void DNCADKIOEEG()
	{
		this.MMOKKAPFGAK();
	}

	// Token: 0x06000FE6 RID: 4070 RVA: 0x0006E3F0 File Offset: 0x0006C5F0
	private void DNNFHBOOPIN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -45);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000FE7 RID: 4071 RVA: 0x0006E468 File Offset: 0x0006C668
	private void Start()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000FE8 RID: 4072 RVA: 0x0006DEB2 File Offset: 0x0006C0B2
	private void HOLDCFBBHHP()
	{
		this.EIMNPCMHJLJ();
	}

	// Token: 0x06000FE9 RID: 4073 RVA: 0x0006D737 File Offset: 0x0006B937
	private void GLKJFIOCPLF()
	{
		this.FBPHNEJBDJN();
	}

	// Token: 0x06000FEB RID: 4075 RVA: 0x0006E508 File Offset: 0x0006C708
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000FEC RID: 4076 RVA: 0x0006E540 File Offset: 0x0006C740
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1442f)
			{
				this.HBJJOCHGOPH = 1560f;
			}
			if (this.Camera2 != null)
			{
				this.FLOHGDECHHH().SetTexture("[GameEvent] Exeption:", this.JDMCFBKJHDD);
			}
			this.OLHDPICFBOF().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat("_TimeX", this.BlendFX);
			this.IIJMIPBMMBF().SetFloat("Expected protocol set to UDP, due to encryption mode DatagramEncryption. Changing protocol in PhotonServerSettings from: ", this.Adjust);
			this.NLFJGMBCICG().SetFloat("ready", this.Precision);
			this.IFMAPIDFNLI().SetFloat("B:", this.Luminosity);
			this.OLHDPICFBOF().SetFloat("Hidden/DepthOfField/MedianFilter", this.Change_Red);
			this.NBPKMLMCHFN.SetFloat("#8E8E8EFF", this.Change_Green);
			this.NFKFAAHHLLM().SetFloat("_SpotSize", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000FED RID: 4077 RVA: 0x0006E67B File Offset: 0x0006C87B
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000FEE RID: 4078 RVA: 0x0006D2C3 File Offset: 0x0006B4C3
	private void KFACDBHDAOD()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06000FEF RID: 4079 RVA: 0x0006D2F1 File Offset: 0x0006B4F1
	private void MFOOCOIIIJN()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06000FF0 RID: 4080 RVA: 0x0006E6B4 File Offset: 0x0006C8B4
	private void DBLILJGKGHJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 18);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000FF1 RID: 4081 RVA: 0x0006D315 File Offset: 0x0006B515
	private void GJLKJAOBPJD()
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

	// Token: 0x06000FF2 RID: 4082 RVA: 0x0006E72C File Offset: 0x0006C92C
	private void LBAJLLFMMMP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -48);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000FF3 RID: 4083 RVA: 0x0006E7A4 File Offset: 0x0006C9A4
	private void KLILJHJNICK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -26);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000FF4 RID: 4084 RVA: 0x0006E81C File Offset: 0x0006CA1C
	private void MMMDPANNAIO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -49);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000FF5 RID: 4085 RVA: 0x0006E894 File Offset: 0x0006CA94
	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1657f)
			{
				this.HBJJOCHGOPH = 1661f;
			}
			if (this.Camera2 != null)
			{
				this.NFKFAAHHLLM().SetTexture("_Sat", this.JDMCFBKJHDD);
			}
			this.IONHGBPGCHK().SetFloat(": ", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat(":", this.BlendFX);
			this.IFMAPIDFNLI().SetFloat("Malformed RPC; this should never occur. Content: ", this.Adjust);
			this.IIJMIPBMMBF().SetFloat("SetSunInput", this.Precision);
			this.HKIMAANBGMJ().SetFloat("OpCreateRoom()", this.Luminosity);
			this.IFMAPIDFNLI().SetFloat(": ", this.Change_Red);
			this.FLOHGDECHHH().SetFloat("%", this.Change_Green);
			this.HKIMAANBGMJ().SetFloat("shader.crispwinter", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000FF6 RID: 4086 RVA: 0x0006E9CF File Offset: 0x0006CBCF
	private void LKPBGHGCPKL()
	{
		this.NNFMIAFHMJM();
	}

	// Token: 0x06000FF7 RID: 4087 RVA: 0x0006DEB2 File Offset: 0x0006C0B2
	private void MHGPANIBBCM()
	{
		this.EIMNPCMHJLJ();
	}

	// Token: 0x06000FF8 RID: 4088 RVA: 0x0006D315 File Offset: 0x0006B515
	private void OFMNDBNFBDJ()
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

	// Token: 0x06000FF9 RID: 4089 RVA: 0x0006D2C3 File Offset: 0x0006B4C3
	private void FAKGFMFAPDG()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06000FFA RID: 4090 RVA: 0x0006D2C3 File Offset: 0x0006B4C3
	private void HCIPECAOGIA()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06000FFB RID: 4091 RVA: 0x0006E9D8 File Offset: 0x0006CBD8
	private void NNFMIAFHMJM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 9);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000FFC RID: 4092 RVA: 0x0006EA4F File Offset: 0x0006CC4F
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-72);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000FFD RID: 4093 RVA: 0x0006EA88 File Offset: 0x0006CC88
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1028f)
			{
				this.HBJJOCHGOPH = 1567f;
			}
			if (this.Camera2 != null)
			{
				this.FLOHGDECHHH().SetTexture(", data: ", this.JDMCFBKJHDD);
			}
			this.NLFJGMBCICG().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetFloat("_Fade", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("settings.crosshairopacity", this.Adjust);
			this.OLHDPICFBOF().SetFloat("_Value1", this.Precision);
			this.DKKBFFHBHJE().SetFloat("Joystick1Button10", this.Luminosity);
			this.IIJMIPBMMBF().SetFloat("SelectorMapsCountSlider", this.Change_Red);
			this.FLOHGDECHHH().SetFloat("_Distortion", this.Change_Green);
			this.ADGHJOHKEHG().SetFloat("#close", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000FFE RID: 4094 RVA: 0x0006EBC4 File Offset: 0x0006CDC4
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 911f)
			{
				this.HBJJOCHGOPH = 1238f;
			}
			if (this.Camera2 != null)
			{
				this.DKKBFFHBHJE().SetTexture("Switch environment sprite image", this.JDMCFBKJHDD);
			}
			this.ADGHJOHKEHG().SetFloat("_Vignette", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Hex value #RRGGBB", this.BlendFX);
			this.OLHDPICFBOF().SetFloat("#close", this.Adjust);
			this.NBPKMLMCHFN.SetFloat("Connecting", this.Precision);
			this.NFKFAAHHLLM().SetFloat("Fade", this.Luminosity);
			this.NBPKMLMCHFN.SetFloat("[Singleton] multiple instances of '", this.Change_Red);
			this.NFKFAAHHLLM().SetFloat("Backward", this.Change_Green);
			this.LPCHMEKDCHI().SetFloat("value", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000FFF RID: 4095 RVA: 0x0006D2F1 File Offset: 0x0006B4F1
	private void AMIMHHGLPIN()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001000 RID: 4096 RVA: 0x0006ED00 File Offset: 0x0006CF00
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1992f)
			{
				this.HBJJOCHGOPH = 291f;
			}
			if (this.Camera2 != null)
			{
				this.IIJMIPBMMBF().SetTexture("_Near", this.JDMCFBKJHDD);
			}
			this.DKKBFFHBHJE().SetFloat("_Value", this.HBJJOCHGOPH);
			this.HKIMAANBGMJ().SetFloat("_Value2", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("SetParticlesParticleSize", this.Adjust);
			this.LPCHMEKDCHI().SetFloat("/config", this.Precision);
			this.NFKFAAHHLLM().SetFloat("_MainTex2", this.Luminosity);
			this.NLFJGMBCICG().SetFloat("_Red_C", this.Change_Red);
			this.HKIMAANBGMJ().SetFloat("threshold", this.Change_Green);
			this.DKKBFFHBHJE().SetFloat("Received your UserID from server. Updating local value to: {0}", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001001 RID: 4097 RVA: 0x0006D315 File Offset: 0x0006B515
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

	// Token: 0x06001002 RID: 4098 RVA: 0x0006EE3C File Offset: 0x0006D03C
	private void KNBJBNDGCIJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 122);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001003 RID: 4099 RVA: 0x0006EEB4 File Offset: 0x0006D0B4
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
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Adjust);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Precision);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Luminosity);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Change_Red);
			this.NBPKMLMCHFN.SetFloat("_Value6", this.Change_Green);
			this.NBPKMLMCHFN.SetFloat("_Value7", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001004 RID: 4100 RVA: 0x0006D315 File Offset: 0x0006B515
	private void BFEILOMHNPC()
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

	// Token: 0x06001005 RID: 4101 RVA: 0x0006EFF0 File Offset: 0x0006D1F0
	private void FIJHDKIPENG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 63);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001006 RID: 4102 RVA: 0x0006F068 File Offset: 0x0006D268
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 305f)
			{
				this.HBJJOCHGOPH = 540f;
			}
			if (this.Camera2 != null)
			{
				this.HKIMAANBGMJ().SetTexture("Registered PhotonView: ", this.JDMCFBKJHDD);
			}
			this.OLHDPICFBOF().SetFloat("_Distortion", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetFloat("float,1.5", this.BlendFX);
			this.NFKFAAHHLLM().SetFloat("/?page=ranks", this.Adjust);
			this.HKIMAANBGMJ().SetFloat("player.orangelifering", this.Precision);
			this.IIJMIPBMMBF().SetFloat("Command not found!", this.Luminosity);
			this.IONHGBPGCHK().SetFloat("YES", this.Change_Red);
			this.IFMAPIDFNLI().SetFloat("sprite", this.Change_Green);
			this.FLOHGDECHHH().SetFloat("_HighlightSuppression", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001007 RID: 4103 RVA: 0x0006F1A3 File Offset: 0x0006D3A3
	private void DGEPPDJDBLN()
	{
		this.DBLILJGKGHJ();
	}

	// Token: 0x06001008 RID: 4104 RVA: 0x0006D315 File Offset: 0x0006B515
	private void GNMGIHFKJIJ()
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

	// Token: 0x06001009 RID: 4105 RVA: 0x0006F1AC File Offset: 0x0006D3AC
	private void BEBNOKFLJPH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -55);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600100A RID: 4106 RVA: 0x0006F224 File Offset: 0x0006D424
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 671f)
			{
				this.HBJJOCHGOPH = 1112f;
			}
			if (this.Camera2 != null)
			{
				this.HKIMAANBGMJ().SetTexture("FileLabel", this.JDMCFBKJHDD);
			}
			this.LPCHMEKDCHI().SetFloat("quantity", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat("id", this.BlendFX);
			this.IFMAPIDFNLI().SetFloat("curScn", this.Adjust);
			this.KJMECMIGJJA().SetFloat("Vertical", this.Precision);
			this.ADGHJOHKEHG().SetFloat("ShowTitle", this.Luminosity);
			this.ADGHJOHKEHG().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", this.Change_Red);
			this.NFKFAAHHLLM().SetFloat(" = ", this.Change_Green);
			this.NLFJGMBCICG().SetFloat("PUNCloudBestRegion", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600100B RID: 4107 RVA: 0x0006D315 File Offset: 0x0006B515
	private void OFIMMFHFHDD()
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

	// Token: 0x0600100C RID: 4108 RVA: 0x0006D2F1 File Offset: 0x0006B4F1
	private void PKNJBBDKJFK()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x0600100D RID: 4109 RVA: 0x0006F35F File Offset: 0x0006D55F
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600100E RID: 4110 RVA: 0x0006F398 File Offset: 0x0006D598
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1092f)
			{
				this.HBJJOCHGOPH = 783f;
			}
			if (this.Camera2 != null)
			{
				this.IFMAPIDFNLI().SetTexture("Backward", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat(" item(s) in inventory", this.HBJJOCHGOPH);
			this.HKIMAANBGMJ().SetFloat("(\\[ *i *\\])", this.BlendFX);
			this.LPCHMEKDCHI().SetFloat("PhotonMono", this.Adjust);
			this.IONHGBPGCHK().SetFloat("FavoriteButton", this.Precision);
			this.DKKBFFHBHJE().SetFloat("Set Parent", this.Luminosity);
			this.IIJMIPBMMBF().SetFloat(" method: ", this.Change_Red);
			this.NFKFAAHHLLM().SetFloat("_Value5", this.Change_Green);
			this.LPCHMEKDCHI().SetFloat("Tab2Content", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600100F RID: 4111 RVA: 0x0006F4D4 File Offset: 0x0006D6D4
	private void CCLNNLCOPBL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -3);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001010 RID: 4112 RVA: 0x0006F54C File Offset: 0x0006D74C
	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1734f)
			{
				this.HBJJOCHGOPH = 1234f;
			}
			if (this.Camera2 != null)
			{
				this.NFKFAAHHLLM().SetTexture("CameraFilterPack/Blend2Camera_LinearLight", this.JDMCFBKJHDD);
			}
			this.OLHDPICFBOF().SetFloat("ReconnectToMaster() with AuthValues == null is not correct!", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("Obtain promo Item", this.BlendFX);
			this.IFMAPIDFNLI().SetFloat("Speed", this.Adjust);
			this.IONHGBPGCHK().SetFloat("settings.volume.sfx", this.Precision);
			this.LPCHMEKDCHI().SetFloat("_Screen", this.Luminosity);
			this.LPCHMEKDCHI().SetFloat("HightScoreMaxPointsText", this.Change_Red);
			this.HKIMAANBGMJ().SetFloat("BitsData", this.Change_Green);
			this.IFMAPIDFNLI().SetFloat("_Value3", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0400023F RID: 575
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_BlueScreen";

	// Token: 0x04000240 RID: 576
	public Shader SCShader;

	// Token: 0x04000241 RID: 577
	public Camera Camera2;

	// Token: 0x04000242 RID: 578
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000243 RID: 579
	private Material BJFKDHHMLJH;

	// Token: 0x04000244 RID: 580
	[Range(0f, 1f)]
	public float BlendFX = 1f;

	// Token: 0x04000245 RID: 581
	[Range(-0.2f, 0.2f)]
	public float Adjust;

	// Token: 0x04000246 RID: 582
	[Range(-0.2f, 0.2f)]
	public float Precision;

	// Token: 0x04000247 RID: 583
	[Range(-0.2f, 0.2f)]
	public float Luminosity;

	// Token: 0x04000248 RID: 584
	[Range(-0.3f, 0.3f)]
	public float Change_Red;

	// Token: 0x04000249 RID: 585
	[Range(-0.3f, 0.3f)]
	public float Change_Green;

	// Token: 0x0400024A RID: 586
	[Range(-0.3f, 0.3f)]
	public float Change_Blue;

	// Token: 0x0400024B RID: 587
	private RenderTexture JDMCFBKJHDD;

	// Token: 0x0400024C RID: 588
	private Vector2 FPEMMGKMJGA;
}
