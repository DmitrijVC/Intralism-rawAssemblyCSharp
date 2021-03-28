using System;
using UnityEngine;

// Token: 0x020000F2 RID: 242
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Lut/Simple")]
public class CameraFilterPack_Lut_Simple : MonoBehaviour
{
	// Token: 0x06004AD6 RID: 19158 RVA: 0x0016E844 File Offset: 0x0016CA44
	public bool ValidDimensions(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return false;
		}
		int height = LAFAECLOMJK.height;
		return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width));
	}

	// Token: 0x06004AD8 RID: 19160 RVA: 0x0016E894 File Offset: 0x0016CA94
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 893f)
			{
				this.HBJJOCHGOPH = 320f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.MCOFJFMKGDD(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.ADBKPGFMNKO().SetTexture("OnMastedChangeScene", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004AD9 RID: 19161 RVA: 0x0016E953 File Offset: 0x0016CB53
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004ADA RID: 19162 RVA: 0x0016E970 File Offset: 0x0016CB70
	public bool MNDLHIJLBNJ(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return false;
		}
		int height = LAFAECLOMJK.height;
		return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width)) || true;
	}

	// Token: 0x06004ADB RID: 19163 RVA: 0x0002523B File Offset: 0x0002343B
	private void NMNAEPIDENM()
	{
	}

	// Token: 0x06004ADC RID: 19164 RVA: 0x0016E953 File Offset: 0x0016CB53
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004ADD RID: 19165 RVA: 0x0016E9AC File Offset: 0x0016CBAC
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

	// Token: 0x06004ADE RID: 19166 RVA: 0x0016EAA0 File Offset: 0x0016CCA0
	public void NKFCFIGGCOH()
	{
		int num = -51;
		Color[] array = new Color[num * num * num];
		float num2 = 1942f / (1060f * (float)num - 1900f);
		for (int i = 1; i < num; i += 0)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 1; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 304f * num2, (float)j * 1022f * num2, (float)k * 625f * num2, 672f);
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

	// Token: 0x06004ADF RID: 19167 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHICDLBKEJN()
	{
	}

	// Token: 0x06004AE0 RID: 19168 RVA: 0x0016EB94 File Offset: 0x0016CD94
	public void GLJKHBFPOLA(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.CFJHJHKDAGJ(MKEKCIPLJNC))
			{
				Debug.LogWarning("_Value" + MKEKCIPLJNC.name + "CameraFilterPack/AAA_Blood_Hit");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 0; j < num; j++)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB32, false);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.CHCIEBMINOA();
		}
	}

	// Token: 0x06004AE1 RID: 19169 RVA: 0x0016ECBC File Offset: 0x0016CEBC
	public void CHCIEBMINOA()
	{
		int num = 14;
		Color[] array = new Color[num * num * num];
		float num2 = 1072f / (931f * (float)num - 1354f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 0; k < num; k += 0)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 1584f * num2, (float)j * 1783f * num2, (float)k * 1565f * num2, 1024f);
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

	// Token: 0x06004AE2 RID: 19170 RVA: 0x0016EDAE File Offset: 0x0016CFAE
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("_Brightness");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004AE3 RID: 19171 RVA: 0x0016E953 File Offset: 0x0016CB53
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004AE4 RID: 19172 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06004AE5 RID: 19173 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06004AE6 RID: 19174 RVA: 0x0016EDD2 File Offset: 0x0016CFD2
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("Unable to get a reward! Try again?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004AE7 RID: 19175 RVA: 0x0016EDF6 File Offset: 0x0016CFF6
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004AE8 RID: 19176 RVA: 0x0002523B File Offset: 0x0002343B
	private void OnValidate()
	{
	}

	// Token: 0x06004AE9 RID: 19177 RVA: 0x0016EE2D File Offset: 0x0016D02D
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004AEA RID: 19178 RVA: 0x0016EE64 File Offset: 0x0016D064
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004AEB RID: 19179 RVA: 0x0016EE9B File Offset: 0x0016D09B
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("Joystick1Button7");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004AEC RID: 19180 RVA: 0x0016EEBF File Offset: 0x0016D0BF
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Lut_Simple");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004AED RID: 19181 RVA: 0x0016EEE4 File Offset: 0x0016D0E4
	public void BEAEKDIPGKL()
	{
		int num = -2;
		Color[] array = new Color[num * num * num];
		float num2 = 1066f / (440f * (float)num - 1494f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 0; j < num; j += 0)
			{
				for (int k = 1; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 10f * num2, (float)j * 1988f * num2, (float)k * 736f * num2, 1244f);
				}
			}
		}
		if (this.PKINFPNDDAJ)
		{
			UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
		}
		this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.Alpha8, false);
		this.PKINFPNDDAJ.SetPixels(array);
		this.PKINFPNDDAJ.Apply();
	}

	// Token: 0x06004AEE RID: 19182 RVA: 0x0016EFD8 File Offset: 0x0016D1D8
	public void GAIOPDKLKOA()
	{
		int num = -94;
		Color[] array = new Color[num * num * num];
		float num2 = 772f / (161f * (float)num - 318f);
		for (int i = 0; i < num; i++)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 0; k < num; k += 0)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 1379f * num2, (float)j * 1242f * num2, (float)k * 1332f * num2, 913f);
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

	// Token: 0x06004AEF RID: 19183 RVA: 0x0016F0CA File Offset: 0x0016D2CA
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004AF0 RID: 19184 RVA: 0x0016F104 File Offset: 0x0016D304
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 784f)
			{
				this.HBJJOCHGOPH = 952f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.MCOFJFMKGDD(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			this.IGIAPKPKGPK().SetTexture("SpawnObj", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004AF1 RID: 19185 RVA: 0x0002523B File Offset: 0x0002343B
	private void MPADDMNGJNC()
	{
	}

	// Token: 0x06004AF2 RID: 19186 RVA: 0x0016F1C4 File Offset: 0x0016D3C4
	public bool CFJHJHKDAGJ(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return false;
		}
		int height = LAFAECLOMJK.height;
		return height != Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width)) && false;
	}

	// Token: 0x06004AF3 RID: 19187 RVA: 0x0016F1FF File Offset: 0x0016D3FF
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004AF4 RID: 19188 RVA: 0x0016F236 File Offset: 0x0016D436
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004AF5 RID: 19189 RVA: 0x0016F26D File Offset: 0x0016D46D
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004AF6 RID: 19190 RVA: 0x0016F291 File Offset: 0x0016D491
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("english");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004AF7 RID: 19191 RVA: 0x0016E953 File Offset: 0x0016CB53
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004AF8 RID: 19192 RVA: 0x0016F2B8 File Offset: 0x0016D4B8
	public void LGKLMCMLKIC(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.MENGEGPBOEG(MKEKCIPLJNC))
			{
				Debug.LogWarning("_Offsets" + MKEKCIPLJNC.name + "SpectateButton");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)8, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.BEAEKDIPGKL();
		}
	}

	// Token: 0x06004AF9 RID: 19193 RVA: 0x0016F3E0 File Offset: 0x0016D5E0
	public void FFILBFJMAHC(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.MENGEGPBOEG(MKEKCIPLJNC))
			{
				Debug.LogWarning("_TimeX" + MKEKCIPLJNC.name + "note.4");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 1; j < num; j++)
				{
					for (int k = 1; k < num; k += 0)
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
			this.FJJEFOCHFHD();
		}
	}

	// Token: 0x06004AFA RID: 19194 RVA: 0x0016F508 File Offset: 0x0016D708
	public void FJJEFOCHFHD()
	{
		int num = 125;
		Color[] array = new Color[num * num * num];
		float num2 = 756f / (1178f * (float)num - 1910f);
		for (int i = 0; i < num; i++)
		{
			for (int j = 1; j < num; j++)
			{
				for (int k = 0; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 837f * num2, (float)j * 951f * num2, (float)k * 1025f * num2, 533f);
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

	// Token: 0x06004AFB RID: 19195 RVA: 0x0016F5FC File Offset: 0x0016D7FC
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
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 0 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004AFC RID: 19196 RVA: 0x0016F6BC File Offset: 0x0016D8BC
	public void GFAOEIEOKMA()
	{
		int num = -23;
		Color[] array = new Color[num * num * num];
		float num2 = 1190f / (260f * (float)num - 1643f);
		for (int i = 1; i < num; i += 0)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 0; k < num; k += 0)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 481f * num2, (float)j * 59f * num2, (float)k * 403f * num2, 757f);
				}
			}
		}
		if (this.PKINFPNDDAJ)
		{
			UnityEngine.Object.DestroyImmediate(this.PKINFPNDDAJ);
		}
		this.PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)0, false);
		this.PKINFPNDDAJ.SetPixels(array);
		this.PKINFPNDDAJ.Apply();
	}

	// Token: 0x06004AFD RID: 19197 RVA: 0x0002523B File Offset: 0x0002343B
	private void MLAGEPNCCGM()
	{
	}

	// Token: 0x06004AFE RID: 19198 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06004AFF RID: 19199 RVA: 0x0016F7B0 File Offset: 0x0016D9B0
	public bool NPKKFJIHHJM(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		return height != Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width)) && false;
	}

	// Token: 0x06004B00 RID: 19200 RVA: 0x0016F7EC File Offset: 0x0016D9EC
	public void MGKJEDIGHGN(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.NPKKFJIHHJM(MKEKCIPLJNC))
			{
				Debug.LogWarning("_VelocityScale" + MKEKCIPLJNC.name + "Parameter levelId must be int or string!");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j++)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)6, false);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.GFAOEIEOKMA();
		}
	}

	// Token: 0x06004B01 RID: 19201 RVA: 0x0016F914 File Offset: 0x0016DB14
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 495f)
			{
				this.HBJJOCHGOPH = 1424f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.MCOFJFMKGDD(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.HHIFMIPPMPF().SetTexture("HandleEventLeave for player ID: ", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004B02 RID: 19202 RVA: 0x0016F9D4 File Offset: 0x0016DBD4
	public void FKGHJIPPOFK()
	{
		int num = 121;
		Color[] array = new Color[num * num * num];
		float num2 = 1234f / (1168f * (float)num - 1248f);
		for (int i = 1; i < num; i += 0)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 0; k < num; k += 0)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 1194f * num2, (float)j * 264f * num2, (float)k * 831f * num2, 1336f);
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

	// Token: 0x06004B03 RID: 19203 RVA: 0x0016FAC6 File Offset: 0x0016DCC6
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("[PlayerBase] Loaded custom model: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004B04 RID: 19204 RVA: 0x0016FAEC File Offset: 0x0016DCEC
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

	// Token: 0x06004B05 RID: 19205 RVA: 0x0016FC14 File Offset: 0x0016DE14
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1749f)
			{
				this.HBJJOCHGOPH = 1006f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.Convert(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.HHIFMIPPMPF().SetTexture("GhostSize", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004B06 RID: 19206 RVA: 0x0016E953 File Offset: 0x0016CB53
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004B07 RID: 19207 RVA: 0x0016FCD4 File Offset: 0x0016DED4
	public void MCOFJFMKGDD(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.NPKKFJIHHJM(MKEKCIPLJNC))
			{
				Debug.LogWarning("Version 1.0" + MKEKCIPLJNC.name + "color");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i += 0)
			{
				for (int j = 1; j < num; j++)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGBA32, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.GFAOEIEOKMA();
		}
	}

	// Token: 0x170000D8 RID: 216
	// (get) Token: 0x06004B08 RID: 19208 RVA: 0x0016FDFB File Offset: 0x0016DFFB
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

	// Token: 0x06004B09 RID: 19209 RVA: 0x0016FE34 File Offset: 0x0016E034
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 899f)
			{
				this.HBJJOCHGOPH = 694f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.Convert(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			this.EPCGJFCCAFH().SetTexture("settings.volume.menu", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 0 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004B0A RID: 19210 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06004B0B RID: 19211 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFOOCOIIIJN()
	{
	}

	// Token: 0x06004B0C RID: 19212 RVA: 0x0016FEF3 File Offset: 0x0016E0F3
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004B0D RID: 19213 RVA: 0x0016E953 File Offset: 0x0016CB53
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004B0E RID: 19214 RVA: 0x0016FF18 File Offset: 0x0016E118
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1886f)
			{
				this.HBJJOCHGOPH = 1244f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.GLJKHBFPOLA(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			this.NBPKMLMCHFN.SetTexture("Editor", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004B0F RID: 19215 RVA: 0x0016FFD8 File Offset: 0x0016E1D8
	public bool OFNPEGAEJKD(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width));
	}

	// Token: 0x06004B10 RID: 19216 RVA: 0x00170014 File Offset: 0x0016E214
	public bool MENGEGPBOEG(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return false;
		}
		int height = LAFAECLOMJK.height;
		return height != Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width)) && false;
	}

	// Token: 0x06004B11 RID: 19217 RVA: 0x00170050 File Offset: 0x0016E250
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 946f)
			{
				this.HBJJOCHGOPH = 501f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.MCOFJFMKGDD(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.HHIFMIPPMPF().SetTexture("id", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 0 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x040007DC RID: 2012
	public Shader SCShader;

	// Token: 0x040007DD RID: 2013
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040007DE RID: 2014
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040007DF RID: 2015
	private Material BJFKDHHMLJH;

	// Token: 0x040007E0 RID: 2016
	public Texture2D LutTexture;

	// Token: 0x040007E1 RID: 2017
	private Texture3D PKINFPNDDAJ;

	// Token: 0x040007E2 RID: 2018
	private string CHMMPJKAMPM;
}
