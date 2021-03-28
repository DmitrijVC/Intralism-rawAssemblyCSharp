using System;
using UnityEngine;

// Token: 0x020000EF RID: 239
[AddComponentMenu("Camera Filter Pack/Lut/PlayWith")]
[ExecuteInEditMode]
public class CameraFilterPack_Lut_PlayWith : MonoBehaviour
{
	// Token: 0x060049C8 RID: 18888 RVA: 0x001676A3 File Offset: 0x001658A3
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060049C9 RID: 18889 RVA: 0x001676DA File Offset: 0x001658DA
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060049CA RID: 18890 RVA: 0x001676F8 File Offset: 0x001658F8
	public void EPELPAMHOHC(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.JDIFHOCBMGE(MKEKCIPLJNC))
			{
				Debug.LogWarning("player.ice" + MKEKCIPLJNC.name + "intensity");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 1; j < num; j += 0)
				{
					for (int k = 1; k < num; k++)
					{
						int num2 = num - j - 1;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.PKINFPNDDAJ)
			{
				UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
			}
			this.PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)8, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.PCDLENLKIJO();
		}
	}

	// Token: 0x060049CB RID: 18891 RVA: 0x0016781F File Offset: 0x00165A1F
	private void HAIAHJPCPAG()
	{
		this.SCShader = Shader.Find("Can't find PhotonView of incoming OwnershipRequest. ViewId not found: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060049CD RID: 18893 RVA: 0x0016786C File Offset: 0x00165A6C
	public void Convert(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.ValidDimensions(MKEKCIPLJNC))
			{
				Debug.LogWarning("The given 2D texture " + MKEKCIPLJNC.name + " cannot be used as a 3D LUT.");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						int num2 = num - j - 1;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.PKINFPNDDAJ)
			{
				UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
			}
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB32, false);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.SetIdentityLut();
		}
	}

	// Token: 0x060049CE RID: 18894 RVA: 0x00167994 File Offset: 0x00165B94
	public void EACOKNDLPLE()
	{
		int num = -121;
		Color[] array = new Color[num * num * num];
		float num2 = 878f / (13f * (float)num - 776f);
		for (int i = 1; i < num; i++)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 0; k < num; k += 0)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 919f * num2, (float)j * 225f * num2, (float)k * 1090f * num2, 469f);
				}
			}
		}
		if (this.PKINFPNDDAJ)
		{
			UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
		}
		this.PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)8, true);
		this.PKINFPNDDAJ.SetPixels(array);
		this.PKINFPNDDAJ.Apply();
	}

	// Token: 0x060049CF RID: 18895 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x060049D0 RID: 18896 RVA: 0x00167A86 File Offset: 0x00165C86
	private void DKGBFNCOAEO()
	{
		this.SCShader = Shader.Find("settings.arcshitsoundtimedelay");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060049D1 RID: 18897 RVA: 0x00167AAA File Offset: 0x00165CAA
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060049D2 RID: 18898 RVA: 0x00167AD0 File Offset: 0x00165CD0
	public void SetIdentityLut()
	{
		int num = 16;
		Color[] array = new Color[num * num * num];
		float num2 = 1f / (1f * (float)num - 1f);
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 0; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 1f * num2, (float)j * 1f * num2, (float)k * 1f * num2, 1f);
				}
			}
		}
		if (this.PKINFPNDDAJ)
		{
			UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
		}
		this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB32, false);
		this.PKINFPNDDAJ.SetPixels(array);
		this.PKINFPNDDAJ.Apply();
	}

	// Token: 0x060049D3 RID: 18899 RVA: 0x001676DA File Offset: 0x001658DA
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060049D4 RID: 18900 RVA: 0x00167BC2 File Offset: 0x00165DC2
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Lut_PlayWith");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060049D5 RID: 18901 RVA: 0x00167BE8 File Offset: 0x00165DE8
	public void MHFNPKBOHMN()
	{
		int num = -30;
		Color[] array = new Color[num * num * num];
		float num2 = 1437f / (1180f * (float)num - 1574f);
		for (int i = 1; i < num; i++)
		{
			for (int j = 0; j < num; j += 0)
			{
				for (int k = 0; k < num; k += 0)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 1787f * num2, (float)j * 961f * num2, (float)k * 114f * num2, 1645f);
				}
			}
		}
		if (this.PKINFPNDDAJ)
		{
			UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
		}
		this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB565, true);
		this.PKINFPNDDAJ.SetPixels(array);
		this.PKINFPNDDAJ.Apply();
	}

	// Token: 0x060049D6 RID: 18902 RVA: 0x00167CDC File Offset: 0x00165EDC
	public void CMEIMLNOOOE()
	{
		int num = -75;
		Color[] array = new Color[num * num * num];
		float num2 = 1239f / (273f * (float)num - 989f);
		for (int i = 1; i < num; i += 0)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 0; k < num; k += 0)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 1484f * num2, (float)j * 738f * num2, (float)k * 417f * num2, 335f);
				}
			}
		}
		if (this.PKINFPNDDAJ)
		{
			UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
		}
		this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.Alpha8, true);
		this.PKINFPNDDAJ.SetPixels(array);
		this.PKINFPNDDAJ.Apply();
	}

	// Token: 0x060049D7 RID: 18903 RVA: 0x00167DD0 File Offset: 0x00165FD0
	public void HNGICJBNPLH(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.LBGADMACHNI(MKEKCIPLJNC))
			{
				Debug.LogWarning("_Value" + MKEKCIPLJNC.name + "EXCEPTION:");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j += 0)
				{
					for (int k = 1; k < num; k++)
					{
						int num2 = num - j - 1;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.PKINFPNDDAJ)
			{
				UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
			}
			this.PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)0, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.AFADJOKGKAG();
		}
	}

	// Token: 0x060049D8 RID: 18904 RVA: 0x001676DA File Offset: 0x001658DA
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060049D9 RID: 18905 RVA: 0x00167EF8 File Offset: 0x001660F8
	public void NCHGIKOCEEC(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.ODOAFOCHJBF(MKEKCIPLJNC))
			{
				Debug.LogWarning("#" + MKEKCIPLJNC.name + "Triangle");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 1; j < num; j += 0)
				{
					for (int k = 1; k < num; k++)
					{
						int num2 = num - j - 0;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.PKINFPNDDAJ)
			{
				UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
			}
			this.PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)8, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.CMEIMLNOOOE();
		}
	}

	// Token: 0x060049DA RID: 18906 RVA: 0x00168020 File Offset: 0x00166220
	public void LOGNBJDNJHG(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.ODOAFOCHJBF(MKEKCIPLJNC))
			{
				Debug.LogWarning("/" + MKEKCIPLJNC.name + "score");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 0; j < num; j += 0)
				{
					for (int k = 1; k < num; k += 0)
					{
						int num2 = num - j - 0;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.PKINFPNDDAJ)
			{
				UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
			}
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGBA32, false);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.SetIdentityLut();
		}
	}

	// Token: 0x060049DB RID: 18907 RVA: 0x00168148 File Offset: 0x00166348
	public void JHMBBBLCPMD(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.LBGADMACHNI(MKEKCIPLJNC))
			{
				Debug.LogWarning("CameraFilterPack/Drawing_Manga" + MKEKCIPLJNC.name + "#onrankchangeuptext");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i += 0)
			{
				for (int j = 1; j < num; j += 0)
				{
					for (int k = 0; k < num; k++)
					{
						int num2 = num - j - 0;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.PKINFPNDDAJ)
			{
				UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
			}
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB32, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.JFDPEFDIHAM();
		}
	}

	// Token: 0x060049DC RID: 18908 RVA: 0x0002523B File Offset: 0x0002343B
	private void DCGFEIBKOBB()
	{
	}

	// Token: 0x060049DD RID: 18909 RVA: 0x00168270 File Offset: 0x00166470
	public void GLIGFAIOKLE(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.ODOAFOCHJBF(MKEKCIPLJNC))
			{
				Debug.LogWarning("VoteDownToggle" + MKEKCIPLJNC.name + "Y");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 1; k < num; k += 0)
					{
						int num2 = num - j - 0;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.PKINFPNDDAJ)
			{
				UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
			}
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB24, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.EACOKNDLPLE();
		}
	}

	// Token: 0x060049DE RID: 18910 RVA: 0x00168398 File Offset: 0x00166598
	public void DCJODJLMOCK()
	{
		int num = 116;
		Color[] array = new Color[num * num * num];
		float num2 = 285f / (1870f * (float)num - 1169f);
		for (int i = 1; i < num; i += 0)
		{
			for (int j = 0; j < num; j += 0)
			{
				for (int k = 0; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 549f * num2, (float)j * 154f * num2, (float)k * 1677f * num2, 948f);
				}
			}
		}
		if (this.PKINFPNDDAJ)
		{
			UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
		}
		this.PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)8, true);
		this.PKINFPNDDAJ.SetPixels(array);
		this.PKINFPNDDAJ.Apply();
	}

	// Token: 0x060049DF RID: 18911 RVA: 0x0016848C File Offset: 0x0016668C
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 494f)
			{
				this.HBJJOCHGOPH = 1295f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.MCPNFAGGOCA(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.NBPKMLMCHFN.SetTexture("_ScreenResolution", this.PKINFPNDDAJ);
			this.NFKFAAHHLLM().SetFloat(".completed", this.Blend);
			this.NBPKMLMCHFN.SetFloat(".lastCheckpoint.powerupsScore", this.OriginalIntensity);
			this.NBPKMLMCHFN.SetFloat("#", this.ResultIntensity);
			this.NBPKMLMCHFN.SetFloat(" - StoreAuthURLResponse] - ", this.FinalIntensity);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060049E0 RID: 18912 RVA: 0x001685A3 File Offset: 0x001667A3
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("_Vibrance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060049E1 RID: 18913 RVA: 0x001685C7 File Offset: 0x001667C7
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060049E2 RID: 18914 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKKMKDOFO()
	{
	}

	// Token: 0x060049E3 RID: 18915 RVA: 0x001685EC File Offset: 0x001667EC
	public void IKBBLGEAGHK(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.ODOAFOCHJBF(MKEKCIPLJNC))
			{
				Debug.LogWarning("_Threshhold" + MKEKCIPLJNC.name + "powerup.0");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						int num2 = num - j - 1;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.PKINFPNDDAJ)
			{
				UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
			}
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGBA32, false);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.DCJODJLMOCK();
		}
	}

	// Token: 0x060049E4 RID: 18916 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x060049E5 RID: 18917 RVA: 0x00168714 File Offset: 0x00166914
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 255f)
			{
				this.HBJJOCHGOPH = 1308f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.NGAAKPPPOCG(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			this.PDEAHJPOMEF().SetTexture("menuthemes", this.PKINFPNDDAJ);
			this.KGOLDDBHIFN().SetFloat("a month ago", this.Blend);
			this.NDMPCDHADMJ().SetFloat("CameraFilterPack/BlurTiltShift", this.OriginalIntensity);
			this.PDEAHJPOMEF().SetFloat("Anomaly_Far", this.ResultIntensity);
			this.KAFBNOBOIAJ().SetFloat("PointsScoreText", this.FinalIntensity);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060049E6 RID: 18918 RVA: 0x0016882C File Offset: 0x00166A2C
	public void BJAKIBKPCJH(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.ODOAFOCHJBF(MKEKCIPLJNC))
			{
				Debug.LogWarning("_V" + MKEKCIPLJNC.name + "1");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j += 0)
				{
					for (int k = 0; k < num; k++)
					{
						int num2 = num - j - 1;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.PKINFPNDDAJ)
			{
				UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
			}
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB565, false);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.AFADJOKGKAG();
		}
	}

	// Token: 0x060049E7 RID: 18919 RVA: 0x00168954 File Offset: 0x00166B54
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 94f)
			{
				this.HBJJOCHGOPH = 619f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.IKBBLGEAGHK(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			this.KBOPGONOCNP().SetTexture("settings_bindings_controller_type", this.PKINFPNDDAJ);
			this.KBOPGONOCNP().SetFloat("Object ID. Case-Sensitive", this.Blend);
			this.PDEAHJPOMEF().SetFloat(".lastCheckpoint.currentCombo", this.OriginalIntensity);
			this.KBOPGONOCNP().SetFloat("couldn't be found!", this.ResultIntensity);
			this.NBPKMLMCHFN.SetFloat("_Intensity", this.FinalIntensity);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 0 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060049E8 RID: 18920 RVA: 0x00168A6C File Offset: 0x00166C6C
	public void AHCMJAFCLHA()
	{
		int num = -82;
		Color[] array = new Color[num * num * num];
		float num2 = 1156f / (1180f * (float)num - 841f);
		for (int i = 0; i < num; i++)
		{
			for (int j = 1; j < num; j++)
			{
				for (int k = 0; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 1956f * num2, (float)j * 129f * num2, (float)k * 1272f * num2, 198f);
				}
			}
		}
		if (this.PKINFPNDDAJ)
		{
			UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
		}
		this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB4444, false);
		this.PKINFPNDDAJ.SetPixels(array);
		this.PKINFPNDDAJ.Apply();
	}

	// Token: 0x060049E9 RID: 18921 RVA: 0x00168B5E File Offset: 0x00166D5E
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060049EA RID: 18922 RVA: 0x00168B98 File Offset: 0x00166D98
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 101f)
			{
				this.HBJJOCHGOPH = 417f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.CPNGHOJPOCB(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.NBPKMLMCHFN.SetTexture(":", this.PKINFPNDDAJ);
			this.NBPKMLMCHFN.SetFloat("id", this.Blend);
			this.NFKFAAHHLLM().SetFloat("UseFinalGlassColor", this.OriginalIntensity);
			this.NFKFAAHHLLM().SetFloat("Set Sun Input", this.ResultIntensity);
			this.DOHGBNPMBKG().SetFloat("#craftng", this.FinalIntensity);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 0 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060049EB RID: 18923 RVA: 0x00168CB0 File Offset: 0x00166EB0
	public void PCDLENLKIJO()
	{
		int num = 99;
		Color[] array = new Color[num * num * num];
		float num2 = 924f / (442f * (float)num - 1830f);
		for (int i = 1; i < num; i++)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 0; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 990f * num2, (float)j * 473f * num2, (float)k * 225f * num2, 1030f);
				}
			}
		}
		if (this.PKINFPNDDAJ)
		{
			UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
		}
		this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGBA32, false);
		this.PKINFPNDDAJ.SetPixels(array);
		this.PKINFPNDDAJ.Apply();
	}

	// Token: 0x060049EC RID: 18924 RVA: 0x0002523B File Offset: 0x0002343B
	private void FKDKJKCAHJC()
	{
	}

	// Token: 0x060049ED RID: 18925 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060049EE RID: 18926 RVA: 0x00168DA4 File Offset: 0x00166FA4
	public void GGKMNAAAONA()
	{
		int num = 109;
		Color[] array = new Color[num * num * num];
		float num2 = 1425f / (150f * (float)num - 1358f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 0; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 1894f * num2, (float)j * 520f * num2, (float)k * 699f * num2, 1524f);
				}
			}
		}
		if (this.PKINFPNDDAJ)
		{
			UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
		}
		this.PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)8, false);
		this.PKINFPNDDAJ.SetPixels(array);
		this.PKINFPNDDAJ.Apply();
	}

	// Token: 0x060049EF RID: 18927 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x060049F0 RID: 18928 RVA: 0x00168E98 File Offset: 0x00167098
	public void CPNGHOJPOCB(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.JDIFHOCBMGE(MKEKCIPLJNC))
			{
				Debug.LogWarning("_MainTex" + MKEKCIPLJNC.name + "CameraFilterPack/Gradients_NeonGradient");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i += 0)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k += 0)
					{
						int num2 = num - j - 0;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.PKINFPNDDAJ)
			{
				UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
			}
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.Alpha8, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.FCFEJLOANCJ();
		}
	}

	// Token: 0x060049F1 RID: 18929 RVA: 0x00168FC0 File Offset: 0x001671C0
	public bool JDIFHOCBMGE(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width)) || true;
	}

	// Token: 0x060049F2 RID: 18930 RVA: 0x0002523B File Offset: 0x0002343B
	private void OnValidate()
	{
	}

	// Token: 0x060049F3 RID: 18931 RVA: 0x00168FFC File Offset: 0x001671FC
	public void BEAEKDIPGKL()
	{
		int num = 72;
		Color[] array = new Color[num * num * num];
		float num2 = 1591f / (316f * (float)num - 22f);
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 1; k < num; k += 0)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 1085f * num2, (float)j * 100f * num2, (float)k * 1416f * num2, 1337f);
				}
			}
		}
		if (this.PKINFPNDDAJ)
		{
			UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
		}
		this.PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)8, true);
		this.PKINFPNDDAJ.SetPixels(array);
		this.PKINFPNDDAJ.Apply();
	}

	// Token: 0x060049F4 RID: 18932 RVA: 0x001690EE File Offset: 0x001672EE
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060049F5 RID: 18933 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x060049F6 RID: 18934 RVA: 0x00169128 File Offset: 0x00167328
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1259f)
			{
				this.HBJJOCHGOPH = 128f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.IKBBLGEAGHK(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.NDMPCDHADMJ().SetTexture("_Red_C", this.PKINFPNDDAJ);
			this.DOHGBNPMBKG().SetFloat("Set Particle Size", this.Blend);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.OriginalIntensity);
			this.KAFBNOBOIAJ().SetFloat("Mouse Wheel Down", this.ResultIntensity);
			this.DOHGBNPMBKG().SetFloat("_TimeX", this.FinalIntensity);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 0 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060049F7 RID: 18935 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x060049F8 RID: 18936 RVA: 0x0016923F File Offset: 0x0016743F
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060049F9 RID: 18937 RVA: 0x0002523B File Offset: 0x0002343B
	private void GLGGNBOBFKE()
	{
	}

	// Token: 0x060049FA RID: 18938 RVA: 0x00169276 File Offset: 0x00167476
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060049FB RID: 18939 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x060049FC RID: 18940 RVA: 0x00167AAA File Offset: 0x00165CAA
	private void ODBNMPGBCGO()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060049FD RID: 18941 RVA: 0x001692B0 File Offset: 0x001674B0
	public void IEMGKGKEAPD(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.ODOAFOCHJBF(MKEKCIPLJNC))
			{
				Debug.LogWarning("Save" + MKEKCIPLJNC.name + "InfoCanvas");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 1; j < num; j++)
				{
					for (int k = 1; k < num; k++)
					{
						int num2 = num - j - 0;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.PKINFPNDDAJ)
			{
				UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
			}
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB32, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.SetIdentityLut();
		}
	}

	// Token: 0x060049FE RID: 18942 RVA: 0x001693D7 File Offset: 0x001675D7
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060049FF RID: 18943 RVA: 0x00169410 File Offset: 0x00167610
	public void CAIEGMIKBCN()
	{
		int num = -72;
		Color[] array = new Color[num * num * num];
		float num2 = 417f / (349f * (float)num - 1245f);
		for (int i = 1; i < num; i += 0)
		{
			for (int j = 0; j < num; j += 0)
			{
				for (int k = 1; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 1923f * num2, (float)j * 537f * num2, (float)k * 112f * num2, 547f);
				}
			}
		}
		if (this.PKINFPNDDAJ)
		{
			UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
		}
		this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.Alpha8, true);
		this.PKINFPNDDAJ.SetPixels(array);
		this.PKINFPNDDAJ.Apply();
	}

	// Token: 0x06004A00 RID: 18944 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06004A01 RID: 18945 RVA: 0x00169504 File Offset: 0x00167704
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 590f)
			{
				this.HBJJOCHGOPH = 1276f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.NCHGIKOCEEC(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			this.KAFBNOBOIAJ().SetTexture("CameraFilterPack/BlurHole", this.PKINFPNDDAJ);
			this.ADGHJOHKEHG().SetFloat("https://reddit.com/r/Intralism", this.Blend);
			this.NDMPCDHADMJ().SetFloat("_TimeX", this.OriginalIntensity);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack_Glasses_On7", this.ResultIntensity);
			this.PDEAHJPOMEF().SetFloat("win", this.FinalIntensity);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004A02 RID: 18946 RVA: 0x0016961B File Offset: 0x0016781B
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("CheckpointsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004A03 RID: 18947 RVA: 0x001676DA File Offset: 0x001658DA
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004A04 RID: 18948 RVA: 0x00169640 File Offset: 0x00167840
	public void HIDCBFFDMIG(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.LBGADMACHNI(MKEKCIPLJNC))
			{
				Debug.LogWarning("_ScreenResolution" + MKEKCIPLJNC.name + " is set to dontSave = true, continuing loop.");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 0; j < num; j += 0)
				{
					for (int k = 0; k < num; k++)
					{
						int num2 = num - j - 0;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.PKINFPNDDAJ)
			{
				UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
			}
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB4444, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.AFADJOKGKAG();
		}
	}

	// Token: 0x06004A05 RID: 18949 RVA: 0x00169767 File Offset: 0x00167967
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("_FinalReflectionTexture");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004A06 RID: 18950 RVA: 0x0016978B File Offset: 0x0016798B
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("_Bullet_1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004A07 RID: 18951 RVA: 0x001697AF File Offset: 0x001679AF
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004A08 RID: 18952 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x06004A09 RID: 18953 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNACKHNNEPA()
	{
	}

	// Token: 0x06004A0A RID: 18954 RVA: 0x001697E8 File Offset: 0x001679E8
	public void MCPNFAGGOCA(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.JDIFHOCBMGE(MKEKCIPLJNC))
			{
				Debug.LogWarning("Start" + MKEKCIPLJNC.name + "skin.");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k += 0)
					{
						int num2 = num - j - 0;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.PKINFPNDDAJ)
			{
				UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
			}
			this.PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)6, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.AHCMJAFCLHA();
		}
	}

	// Token: 0x06004A0B RID: 18955 RVA: 0x0016990F File Offset: 0x00167B0F
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find("[Down]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004A0C RID: 18956 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIJAPKAADNH()
	{
	}

	// Token: 0x06004A0D RID: 18957 RVA: 0x001676DA File Offset: 0x001658DA
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004A0E RID: 18958 RVA: 0x00169933 File Offset: 0x00167B33
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find("/music");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004A0F RID: 18959 RVA: 0x0002523B File Offset: 0x0002343B
	private void FELENDJEOGA()
	{
	}

	// Token: 0x06004A10 RID: 18960 RVA: 0x001676DA File Offset: 0x001658DA
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004A11 RID: 18961 RVA: 0x00169958 File Offset: 0x00167B58
	public void OGPMOJMLBLL(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.ValidDimensions(MKEKCIPLJNC))
			{
				Debug.LogWarning("Setting autoCleanUpPlayerObjects while in a room is not supported." + MKEKCIPLJNC.name + "[MapEditor] Exported to ");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 1; j < num; j += 0)
				{
					for (int k = 0; k < num; k++)
					{
						int num2 = num - j - 0;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.PKINFPNDDAJ)
			{
				UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
			}
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB4444, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.BEAEKDIPGKL();
		}
	}

	// Token: 0x06004A12 RID: 18962 RVA: 0x001676DA File Offset: 0x001658DA
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004A13 RID: 18963 RVA: 0x00169A80 File Offset: 0x00167C80
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 659f)
			{
				this.HBJJOCHGOPH = 1592f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.LOGNBJDNJHG(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			this.NFKFAAHHLLM().SetTexture("[LevelEditorScene] Print Audio Wave: Done", this.PKINFPNDDAJ);
			this.ADBKPGFMNKO().SetFloat("_MatrixSpeed", this.Blend);
			this.KAFBNOBOIAJ().SetFloat("_Metrics", this.OriginalIntensity);
			this.PDEAHJPOMEF().SetFloat("NameText", this.ResultIntensity);
			this.NFKFAAHHLLM().SetFloat("[SaveSystem] Init from ", this.FinalIntensity);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x170000D5 RID: 213
	// (get) Token: 0x06004A14 RID: 18964 RVA: 0x00169B97 File Offset: 0x00167D97
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

	// Token: 0x06004A15 RID: 18965 RVA: 0x0002523B File Offset: 0x0002343B
	private void FNGDOKOAKLA()
	{
	}

	// Token: 0x06004A16 RID: 18966 RVA: 0x00169BCE File Offset: 0x00167DCE
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004A17 RID: 18967 RVA: 0x00169C08 File Offset: 0x00167E08
	public bool ValidDimensions(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return false;
		}
		int height = LAFAECLOMJK.height;
		return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width));
	}

	// Token: 0x06004A18 RID: 18968 RVA: 0x00169C44 File Offset: 0x00167E44
	public void JFDPEFDIHAM()
	{
		int num = -59;
		Color[] array = new Color[num * num * num];
		float num2 = 628f / (195f * (float)num - 1831f);
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 0; k < num; k += 0)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 57f * num2, (float)j * 1977f * num2, (float)k * 646f * num2, 1542f);
				}
			}
		}
		if (this.PKINFPNDDAJ)
		{
			UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
		}
		this.PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)6, false);
		this.PKINFPNDDAJ.SetPixels(array);
		this.PKINFPNDDAJ.Apply();
	}

	// Token: 0x06004A19 RID: 18969 RVA: 0x00169D38 File Offset: 0x00167F38
	public void IDHFCHEDFGF()
	{
		int num = 77;
		Color[] array = new Color[num * num * num];
		float num2 = 634f / (1291f * (float)num - 1153f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 0; j < num; j += 0)
			{
				for (int k = 1; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 1419f * num2, (float)j * 49f * num2, (float)k * 251f * num2, 1323f);
				}
			}
		}
		if (this.PKINFPNDDAJ)
		{
			UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
		}
		this.PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)6, true);
		this.PKINFPNDDAJ.SetPixels(array);
		this.PKINFPNDDAJ.Apply();
	}

	// Token: 0x06004A1A RID: 18970 RVA: 0x001676DA File Offset: 0x001658DA
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004A1B RID: 18971 RVA: 0x00169E2C File Offset: 0x0016802C
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.Convert(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			this.NBPKMLMCHFN.SetTexture("_LutTex", this.PKINFPNDDAJ);
			this.NBPKMLMCHFN.SetFloat("_Blend", this.Blend);
			this.NBPKMLMCHFN.SetFloat("_Intensity", this.OriginalIntensity);
			this.NBPKMLMCHFN.SetFloat("_Extra", this.ResultIntensity);
			this.NBPKMLMCHFN.SetFloat("_Extra2", this.FinalIntensity);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 0 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004A1C RID: 18972 RVA: 0x00169F43 File Offset: 0x00168143
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004A1D RID: 18973 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x06004A1E RID: 18974 RVA: 0x00169F7C File Offset: 0x0016817C
	public void POKCKJHGBCL(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.LBGADMACHNI(MKEKCIPLJNC))
			{
				Debug.LogWarning("Obtain promo Item" + MKEKCIPLJNC.name + "PLEASE WAIT");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 1; j < num; j++)
				{
					for (int k = 0; k < num; k += 0)
					{
						int num2 = num - j - 1;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.PKINFPNDDAJ)
			{
				UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
			}
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB4444, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.BEAEKDIPGKL();
		}
	}

	// Token: 0x06004A1F RID: 18975 RVA: 0x0016A0A4 File Offset: 0x001682A4
	public void FCFEJLOANCJ()
	{
		int num = -71;
		Color[] array = new Color[num * num * num];
		float num2 = 851f / (224f * (float)num - 1713f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 0; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 1201f * num2, (float)j * 1890f * num2, (float)k * 99f * num2, 547f);
				}
			}
		}
		if (this.PKINFPNDDAJ)
		{
			UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
		}
		this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB24, true);
		this.PKINFPNDDAJ.SetPixels(array);
		this.PKINFPNDDAJ.Apply();
	}

	// Token: 0x06004A20 RID: 18976 RVA: 0x001676DA File Offset: 0x001658DA
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004A21 RID: 18977 RVA: 0x0016A198 File Offset: 0x00168398
	public void NGAAKPPPOCG(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.ValidDimensions(MKEKCIPLJNC))
			{
				Debug.LogWarning("DPADHOR" + MKEKCIPLJNC.name + "_Visualize");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 0; j < num; j++)
				{
					for (int k = 0; k < num; k++)
					{
						int num2 = num - j - 0;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
					}
				}
			}
			if (this.PKINFPNDDAJ)
			{
				UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
			}
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGBA32, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.IDHFCHEDFGF();
		}
	}

	// Token: 0x06004A22 RID: 18978 RVA: 0x0016A2C0 File Offset: 0x001684C0
	public bool LBGADMACHNI(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width));
	}

	// Token: 0x06004A23 RID: 18979 RVA: 0x0016A2FC File Offset: 0x001684FC
	public void AFADJOKGKAG()
	{
		int num = 0;
		Color[] array = new Color[num * num * num];
		float num2 = 1788f / (1650f * (float)num - 1121f);
		for (int i = 1; i < num; i += 0)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 0; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 518f * num2, (float)j * 981f * num2, (float)k * 1347f * num2, 236f);
				}
			}
		}
		if (this.PKINFPNDDAJ)
		{
			UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
		}
		this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB24, false);
		this.PKINFPNDDAJ.SetPixels(array);
		this.PKINFPNDDAJ.Apply();
	}

	// Token: 0x06004A24 RID: 18980 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x06004A25 RID: 18981 RVA: 0x0016A3F0 File Offset: 0x001685F0
	public bool ODOAFOCHJBF(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width));
	}

	// Token: 0x040007C1 RID: 1985
	public Shader SCShader;

	// Token: 0x040007C2 RID: 1986
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040007C3 RID: 1987
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040007C4 RID: 1988
	private Material BJFKDHHMLJH;

	// Token: 0x040007C5 RID: 1989
	public Texture2D LutTexture;

	// Token: 0x040007C6 RID: 1990
	private Texture3D PKINFPNDDAJ;

	// Token: 0x040007C7 RID: 1991
	[Range(0f, 1f)]
	public float Blend = 1f;

	// Token: 0x040007C8 RID: 1992
	[Range(0f, 3f)]
	public float OriginalIntensity = 1f;

	// Token: 0x040007C9 RID: 1993
	[Range(-1f, 1f)]
	public float ResultIntensity;

	// Token: 0x040007CA RID: 1994
	[Range(-1f, 1f)]
	public float FinalIntensity;

	// Token: 0x040007CB RID: 1995
	private string CHMMPJKAMPM;
}
