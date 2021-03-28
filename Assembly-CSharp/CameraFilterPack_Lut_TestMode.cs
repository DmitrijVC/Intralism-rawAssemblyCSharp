using System;
using UnityEngine;

// Token: 0x020000F3 RID: 243
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Lut/TestMode")]
public class CameraFilterPack_Lut_TestMode : MonoBehaviour
{
	// Token: 0x06004B12 RID: 19218 RVA: 0x00170110 File Offset: 0x0016E310
	public void GDBBIPKIDFE()
	{
		int num = 60;
		Color[] array = new Color[num * num * num];
		float num2 = 192f / (1170f * (float)num - 484f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 0; j < num; j += 0)
			{
				for (int k = 1; k < num; k += 0)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 1092f * num2, (float)j * 930f * num2, (float)k * 1663f * num2, 1905f);
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

	// Token: 0x06004B13 RID: 19219 RVA: 0x0002523B File Offset: 0x0002343B
	private void FPBIGAKLKIG()
	{
	}

	// Token: 0x06004B14 RID: 19220 RVA: 0x00170204 File Offset: 0x0016E404
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1035f)
			{
				this.HBJJOCHGOPH = 1804f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.GIAANJAEABI(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			this.PGPEMMBJOOG().SetTexture("LevelEditor/icons", this.PKINFPNDDAJ);
			this.EJDPNJAEAKJ().SetFloat("_ScreenResolution", this.Blend);
			this.NBPKMLMCHFN.SetFloat("settings.fps", this.OriginalIntensity);
			this.HKIMAANBGMJ().SetFloat("_VignetteTex", this.ResultIntensity);
			this.NBPKMLMCHFN.SetFloat("Use ticket: ", this.FinalIntensity);
			this.OKJOKHGJHGF().SetFloat("_Value5", this.TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 0 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004B15 RID: 19221 RVA: 0x0002523B File Offset: 0x0002343B
	private void JGDCNDNCFNG()
	{
	}

	// Token: 0x06004B16 RID: 19222 RVA: 0x00170331 File Offset: 0x0016E531
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004B17 RID: 19223 RVA: 0x00170368 File Offset: 0x0016E568
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004B18 RID: 19224 RVA: 0x0017038C File Offset: 0x0016E58C
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004B19 RID: 19225 RVA: 0x001703C3 File Offset: 0x0016E5C3
	private Material CBCNOEIALHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004B1A RID: 19226 RVA: 0x001703FC File Offset: 0x0016E5FC
	public bool HGHNFIPDINC(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		return height != Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width));
	}

	// Token: 0x06004B1B RID: 19227 RVA: 0x00170437 File Offset: 0x0016E637
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("_Near");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004B1C RID: 19228 RVA: 0x0017045C File Offset: 0x0016E65C
	private void FIKNBPAIFBI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 70f)
			{
				this.HBJJOCHGOPH = 797f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.GMOFEELACOE(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			this.DBOLLHHMKKN().SetTexture("_TimeX", this.PKINFPNDDAJ);
			this.PGPEMMBJOOG().SetFloat("_Value", this.Blend);
			this.NBPKMLMCHFN.SetFloat(".played", this.OriginalIntensity);
			this.NBPKMLMCHFN.SetFloat("SpawnObj", this.ResultIntensity);
			this.OKJOKHGJHGF().SetFloat("ZoomSpeed", this.FinalIntensity);
			this.LDNADDJMIPK().SetFloat("_TimeX", this.TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JCPDCGIJKJD(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004B1D RID: 19229 RVA: 0x00170589 File Offset: 0x0016E789
	private void HPFOFGJPNCI()
	{
		this.SCShader = Shader.Find("float,2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004B1E RID: 19230 RVA: 0x001705B0 File Offset: 0x0016E7B0
	public void IEMGKGKEAPD(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.ValidDimensions(MKEKCIPLJNC))
			{
				Debug.LogWarning("GenerationMenu" + MKEKCIPLJNC.name + "CameraFilterPack/Gradients_Therma");
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
						int num2 = num - j - 1;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
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
		else
		{
			this.IDHFCHEDFGF();
		}
	}

	// Token: 0x06004B1F RID: 19231 RVA: 0x001706D8 File Offset: 0x0016E8D8
	public void MJKKNFKMNPF(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.AOLIIGHHMMO(MKEKCIPLJNC))
			{
				Debug.LogWarning("[ResourcesManager] Load audio error: " + MKEKCIPLJNC.name + "Ignoring Connect() because app gets closed. If this is an error, check PhotonHandler.AppQuits.");
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
			this.HMGGOLFFLFB();
		}
	}

	// Token: 0x06004B20 RID: 19232 RVA: 0x001707FF File Offset: 0x0016E9FF
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004B21 RID: 19233 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06004B22 RID: 19234 RVA: 0x00170838 File Offset: 0x0016EA38
	public void IGBAMFGIBBI()
	{
		int num = 51;
		Color[] array = new Color[num * num * num];
		float num2 = 1140f / (737f * (float)num - 442f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 0; j < num; j += 0)
			{
				for (int k = 0; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 1885f * num2, (float)j * 1767f * num2, (float)k * 1852f * num2, 353f);
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

	// Token: 0x06004B23 RID: 19235 RVA: 0x0002523B File Offset: 0x0002343B
	private void JIPEMDLKAGO()
	{
	}

	// Token: 0x06004B24 RID: 19236 RVA: 0x0017092C File Offset: 0x0016EB2C
	public void IEHMCDDOADL(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.HGHNFIPDINC(MKEKCIPLJNC))
			{
				Debug.LogWarning("_PositionY" + MKEKCIPLJNC.name + "note.1");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)8, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.CAIEGMIKBCN();
		}
	}

	// Token: 0x06004B25 RID: 19237 RVA: 0x0002523B File Offset: 0x0002343B
	private void CMBGFMAOEPG()
	{
	}

	// Token: 0x06004B26 RID: 19238 RVA: 0x00170A54 File Offset: 0x0016EC54
	public void PIBMFMFFCML(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.AOLIIGHHMMO(MKEKCIPLJNC))
			{
				Debug.LogWarning("_Near" + MKEKCIPLJNC.name + "_Screen");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i += 0)
			{
				for (int j = 1; j < num; j++)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB24, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.MGBOJGMOEGA();
		}
	}

	// Token: 0x06004B27 RID: 19239 RVA: 0x00170B7B File Offset: 0x0016ED7B
	private void NKFDNIAKGEO()
	{
		this.SCShader = Shader.Find("No child content found, exiting..");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004B28 RID: 19240 RVA: 0x00170B9F File Offset: 0x0016ED9F
	private void HIPEHGNBJMN()
	{
		this.SCShader = Shader.Find("[DiscordController] Connected to {0}#{1}: {2}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004B29 RID: 19241 RVA: 0x00170BC4 File Offset: 0x0016EDC4
	public void OGPMOJMLBLL(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.LFMAKDCJNDM(MKEKCIPLJNC))
			{
				Debug.LogWarning("Can't execute Disconnect() while not connected. Nothing changed. State: {0}" + MKEKCIPLJNC.name + "DPADVER");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)8, false);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.HMGGOLFFLFB();
		}
	}

	// Token: 0x06004B2A RID: 19242 RVA: 0x00170CEB File Offset: 0x0016EEEB
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004B2B RID: 19243 RVA: 0x00170D08 File Offset: 0x0016EF08
	public bool LFMAKDCJNDM(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return false;
		}
		int height = LAFAECLOMJK.height;
		return height != Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width)) && false;
	}

	// Token: 0x06004B2C RID: 19244 RVA: 0x00170D44 File Offset: 0x0016EF44
	public void IOLCHIPNMCK(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.GDLNAHGPEPM(MKEKCIPLJNC))
			{
				Debug.LogWarning("challenges." + MKEKCIPLJNC.name + "\t");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i += 0)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB565, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.MFHOHBNFCDP();
		}
	}

	// Token: 0x06004B2D RID: 19245 RVA: 0x00170E6C File Offset: 0x0016F06C
	public void CDJFAFNLEDP()
	{
		int num = -88;
		Color[] array = new Color[num * num * num];
		float num2 = 1369f / (894f * (float)num - 1287f);
		for (int i = 1; i < num; i++)
		{
			for (int j = 1; j < num; j++)
			{
				for (int k = 0; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 120f * num2, (float)j * 698f * num2, (float)k * 1733f * num2, 479f);
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

	// Token: 0x06004B2E RID: 19246 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x06004B2F RID: 19247 RVA: 0x00170CEB File Offset: 0x0016EEEB
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004B30 RID: 19248 RVA: 0x00170F60 File Offset: 0x0016F160
	private void LNOOFNGHNEL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 370f)
			{
				this.HBJJOCHGOPH = 1360f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.IEMGKGKEAPD(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			this.JCPDCGIJKJD().SetTexture("FullscreenToggle", this.PKINFPNDDAJ);
			this.LDNADDJMIPK().SetFloat("menutheme.letitbe", this.Blend);
			this.EJDPNJAEAKJ().SetFloat("CameraFilterPack/Blend2Camera_Screen", this.OriginalIntensity);
			this.PGPEMMBJOOG().SetFloat("0.00", this.ResultIntensity);
			this.INOBFNCKFGK().SetFloat("[Sound Manager] Audio clip is null, cannot play music", this.FinalIntensity);
			this.HCGJCMDJPGD().SetFloat("EventMenu", this.TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CBCNOEIALHB(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004B31 RID: 19249 RVA: 0x00171090 File Offset: 0x0016F290
	public bool GDLNAHGPEPM(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		return height != Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width)) && false;
	}

	// Token: 0x06004B32 RID: 19250 RVA: 0x001710CC File Offset: 0x0016F2CC
	public bool BBECBFDCFGB(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		return height != Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width)) && false;
	}

	// Token: 0x06004B33 RID: 19251 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x06004B34 RID: 19252 RVA: 0x0002523B File Offset: 0x0002343B
	private void EONOOEJDNEF()
	{
	}

	// Token: 0x06004B35 RID: 19253 RVA: 0x00171108 File Offset: 0x0016F308
	public void MFHOHBNFCDP()
	{
		int num = 12;
		Color[] array = new Color[num * num * num];
		float num2 = 975f / (1557f * (float)num - 111f);
		for (int i = 1; i < num; i++)
		{
			for (int j = 1; j < num; j++)
			{
				for (int k = 1; k < num; k += 0)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 532f * num2, (float)j * 806f * num2, (float)k * 1868f * num2, 76f);
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

	// Token: 0x06004B36 RID: 19254 RVA: 0x0002523B File Offset: 0x0002343B
	private void OnValidate()
	{
	}

	// Token: 0x06004B37 RID: 19255 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06004B38 RID: 19256 RVA: 0x001711FA File Offset: 0x0016F3FA
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("Error: PhotonNetwork.SetInterestGroups was called with an illegal group number: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004B39 RID: 19257 RVA: 0x0002523B File Offset: 0x0002343B
	private void GAAPMFBPJNH()
	{
	}

	// Token: 0x06004B3A RID: 19258 RVA: 0x0017121E File Offset: 0x0016F41E
	private void KHIGHFJKPFG()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004B3B RID: 19259 RVA: 0x00171244 File Offset: 0x0016F444
	public void MGBOJGMOEGA()
	{
		int num = 104;
		Color[] array = new Color[num * num * num];
		float num2 = 272f / (145f * (float)num - 1600f);
		for (int i = 0; i < num; i++)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 0; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 1433f * num2, (float)j * 383f * num2, (float)k * 292f * num2, 895f);
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

	// Token: 0x06004B3C RID: 19260 RVA: 0x0002523B File Offset: 0x0002343B
	private void DCGFEIBKOBB()
	{
	}

	// Token: 0x06004B3D RID: 19261 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06004B3E RID: 19262 RVA: 0x00171338 File Offset: 0x0016F538
	public void ADMLJFIGCJJ(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.FBBJMEBJKPI(MKEKCIPLJNC))
			{
				Debug.LogWarning("Cause: " + MKEKCIPLJNC.name + "_Extra");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 1; j < num; j += 0)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB4444, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.GHANEAKPIDG();
		}
	}

	// Token: 0x06004B3F RID: 19263 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x06004B40 RID: 19264 RVA: 0x00171460 File Offset: 0x0016F660
	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1960f)
			{
				this.HBJJOCHGOPH = 962f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.MLBEEEMAHPK(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.OKJOKHGJHGF().SetTexture("CameraFilterPack/Glasses_On", this.PKINFPNDDAJ);
			this.PGPEMMBJOOG().SetFloat("Data/Skins/", this.Blend);
			this.INOBFNCKFGK().SetFloat("_ScreenResolution", this.OriginalIntensity);
			this.OKJOKHGJHGF().SetFloat("_SunPosition", this.ResultIntensity);
			this.LDNADDJMIPK().SetFloat("_BlurPass", this.FinalIntensity);
			this.JCPDCGIJKJD().SetFloat("GlassDistortion", this.TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 0 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004B41 RID: 19265 RVA: 0x00171590 File Offset: 0x0016F790
	public void LIDOIDIAEJB()
	{
		int num = -50;
		Color[] array = new Color[num * num * num];
		float num2 = 1304f / (588f * (float)num - 980f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 1; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 635f * num2, (float)j * 21f * num2, (float)k * 1646f * num2, 1291f);
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

	// Token: 0x06004B42 RID: 19266 RVA: 0x00171684 File Offset: 0x0016F884
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1021f)
			{
				this.HBJJOCHGOPH = 228f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.Convert(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			this.HKIMAANBGMJ().SetTexture("You have added the SecondScrollRect to a scroll view that already has both directions selected", this.PKINFPNDDAJ);
			this.HCGJCMDJPGD().SetFloat("id", this.Blend);
			this.INOBFNCKFGK().SetFloat("_Parameter", this.OriginalIntensity);
			this.JCPDCGIJKJD().SetFloat("SetSatelliteRadius", this.ResultIntensity);
			this.JCPDCGIJKJD().SetFloat("--------------------------------", this.FinalIntensity);
			this.HCGJCMDJPGD().SetFloat("_TimeX", this.TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 0 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004B43 RID: 19267 RVA: 0x001717B4 File Offset: 0x0016F9B4
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 554f)
			{
				this.HBJJOCHGOPH = 24f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.IEHMCDDOADL(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.CIAFLBFJLEJ().SetTexture("[ERROR KEY {0}]", this.PKINFPNDDAJ);
			this.HFBJAOFLCJI().SetFloat("_Angle", this.Blend);
			this.CIAFLBFJLEJ().SetFloat("_Value7", this.OriginalIntensity);
			this.DBOLLHHMKKN().SetFloat("System.Int64", this.ResultIntensity);
			this.OKJOKHGJHGF().SetFloat("_Value", this.FinalIntensity);
			this.CBCNOEIALHB().SetFloat("_SizeX", this.TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004B44 RID: 19268 RVA: 0x001718E4 File Offset: 0x0016FAE4
	private void HHKBBEFJEBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 114f)
			{
				this.HBJJOCHGOPH = 1708f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.PGJAIMOPEJB(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			this.LDNADDJMIPK().SetTexture("_EmissionColor", this.PKINFPNDDAJ);
			this.HCGJCMDJPGD().SetFloat("maps.", this.Blend);
			this.HCGJCMDJPGD().SetFloat("&page=", this.OriginalIntensity);
			this.CBCNOEIALHB().SetFloat("note.2", this.ResultIntensity);
			this.OKJOKHGJHGF().SetFloat("menu.playedpage", this.FinalIntensity);
			this.JLHLHKPHDFO().SetFloat("_Noise", this.TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004B45 RID: 19269 RVA: 0x00171A14 File Offset: 0x0016FC14
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1521f)
			{
				this.HBJJOCHGOPH = 131f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.HMGDPFBBFCC(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.EJDPNJAEAKJ().SetTexture("StartButton", this.PKINFPNDDAJ);
			this.HFBJAOFLCJI().SetFloat("CameraFilterPack/Vision_Psycho", this.Blend);
			this.JLHLHKPHDFO().SetFloat("_TimeX", this.OriginalIntensity);
			this.NBPKMLMCHFN.SetFloat("Items", this.ResultIntensity);
			this.EJDPNJAEAKJ().SetFloat("maps.", this.FinalIntensity);
			this.JLHLHKPHDFO().SetFloat("3;4;9;10;21x6", this.TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JCPDCGIJKJD(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 0 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004B46 RID: 19270 RVA: 0x00170CEB File Offset: 0x0016EEEB
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004B47 RID: 19271 RVA: 0x00171B44 File Offset: 0x0016FD44
	public void CEKLIKHBJFA(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.HGHNFIPDINC(MKEKCIPLJNC))
			{
				Debug.LogWarning("#" + MKEKCIPLJNC.name + ",");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB32, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.CDJFAFNLEDP();
		}
	}

	// Token: 0x06004B48 RID: 19272 RVA: 0x00171C6C File Offset: 0x0016FE6C
	public bool ValidDimensions(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return false;
		}
		int height = LAFAECLOMJK.height;
		return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width));
	}

	// Token: 0x06004B49 RID: 19273 RVA: 0x0002523B File Offset: 0x0002343B
	private void ABKHEFGLAOJ()
	{
	}

	// Token: 0x06004B4A RID: 19274 RVA: 0x00171CA8 File Offset: 0x0016FEA8
	public void GHANEAKPIDG()
	{
		int num = -3;
		Color[] array = new Color[num * num * num];
		float num2 = 1975f / (1493f * (float)num - 1332f);
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 0; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 287f * num2, (float)j * 863f * num2, (float)k * 78f * num2, 1562f);
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

	// Token: 0x06004B4B RID: 19275 RVA: 0x00170CEB File Offset: 0x0016EEEB
	private void GNPDGBNDCPL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004B4C RID: 19276 RVA: 0x00171D9A File Offset: 0x0016FF9A
	private void LIBGAKMKHJJ()
	{
		this.SCShader = Shader.Find("_Color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004B4D RID: 19277 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06004B4E RID: 19278 RVA: 0x00171DC0 File Offset: 0x0016FFC0
	public void GIAANJAEABI(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.HGHNFIPDINC(MKEKCIPLJNC))
			{
				Debug.LogWarning("???" + MKEKCIPLJNC.name + "_TimeX");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB565, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.HMGGOLFFLFB();
		}
	}

	// Token: 0x06004B4F RID: 19279 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06004B50 RID: 19280 RVA: 0x00171EE7 File Offset: 0x001700E7
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("_Value13");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004B51 RID: 19281 RVA: 0x00171F0C File Offset: 0x0017010C
	public void NGAAKPPPOCG(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.IEHJLKAPGPG(MKEKCIPLJNC))
			{
				Debug.LogWarning("_FixDistance" + MKEKCIPLJNC.name + "SpawnObj");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 0; j < num; j += 0)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGBA32, false);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.MGBOJGMOEGA();
		}
	}

	// Token: 0x06004B52 RID: 19282 RVA: 0x00172034 File Offset: 0x00170234
	public void HMGGOLFFLFB()
	{
		int num = 48;
		Color[] array = new Color[num * num * num];
		float num2 = 381f / (1173f * (float)num - 755f);
		for (int i = 1; i < num; i++)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 0; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 1722f * num2, (float)j * 1724f * num2, (float)k * 821f * num2, 90f);
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

	// Token: 0x06004B53 RID: 19283 RVA: 0x00170CEB File Offset: 0x0016EEEB
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004B54 RID: 19284 RVA: 0x00172128 File Offset: 0x00170328
	public bool MIMOHBMBIOK(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		return height != Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width)) && false;
	}

	// Token: 0x06004B55 RID: 19285 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x06004B56 RID: 19286 RVA: 0x00172163 File Offset: 0x00170363
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004B57 RID: 19287 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06004B58 RID: 19288 RVA: 0x0002523B File Offset: 0x0002343B
	private void LNCFCGGJJOB()
	{
	}

	// Token: 0x06004B59 RID: 19289 RVA: 0x0017219C File Offset: 0x0017039C
	public bool JBPNBOBEFAM(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width));
	}

	// Token: 0x06004B5A RID: 19290 RVA: 0x001721D8 File Offset: 0x001703D8
	public void MPBFDNDBHBM()
	{
		int num = 120;
		Color[] array = new Color[num * num * num];
		float num2 = 1188f / (571f * (float)num - 1557f);
		for (int i = 1; i < num; i += 0)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 1; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 1386f * num2, (float)j * 249f * num2, (float)k * 1246f * num2, 811f);
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

	// Token: 0x06004B5B RID: 19291 RVA: 0x001722CC File Offset: 0x001704CC
	public void JOKFDMPOADA(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.LFMAKDCJNDM(MKEKCIPLJNC))
			{
				Debug.LogWarning("_TimeX" + MKEKCIPLJNC.name + "skins");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i += 0)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB24, false);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.KBIKACDMJGO();
		}
	}

	// Token: 0x06004B5C RID: 19292 RVA: 0x001723F3 File Offset: 0x001705F3
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004B5D RID: 19293 RVA: 0x0017242C File Offset: 0x0017062C
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 527f)
			{
				this.HBJJOCHGOPH = 1469f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.HMGDPFBBFCC(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.INOBFNCKFGK().SetTexture("_ProjInfo", this.PKINFPNDDAJ);
			this.JCPDCGIJKJD().SetFloat("_TimeX", this.Blend);
			this.NBPKMLMCHFN.SetFloat("ShowSprite", this.OriginalIntensity);
			this.CBCNOEIALHB().SetFloat("GlassesColor2", this.ResultIntensity);
			this.JLHLHKPHDFO().SetFloat("<b>(╯°□°）╯︵ ┻━┻</b>", this.FinalIntensity);
			this.JLHLHKPHDFO().SetFloat(" registered.", this.TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.INOBFNCKFGK(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 0 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004B5E RID: 19294 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBFJAOINHMK()
	{
	}

	// Token: 0x06004B5F RID: 19295 RVA: 0x0017255C File Offset: 0x0017075C
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

	// Token: 0x06004B60 RID: 19296 RVA: 0x0002523B File Offset: 0x0002343B
	private void MGMLGCNLMKN()
	{
	}

	// Token: 0x06004B61 RID: 19297 RVA: 0x00172650 File Offset: 0x00170850
	public void CAIEGMIKBCN()
	{
		int num = 120;
		Color[] array = new Color[num * num * num];
		float num2 = 792f / (254f * (float)num - 1771f);
		for (int i = 1; i < num; i += 0)
		{
			for (int j = 0; j < num; j += 0)
			{
				for (int k = 0; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 15f * num2, (float)j * 1023f * num2, (float)k * 121f * num2, 1198f);
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

	// Token: 0x06004B62 RID: 19298 RVA: 0x00172744 File Offset: 0x00170944
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 207f)
			{
				this.HBJJOCHGOPH = 222f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.IOLCHIPNMCK(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.DBOLLHHMKKN().SetTexture("_Linecount", this.PKINFPNDDAJ);
			this.PGPEMMBJOOG().SetFloat("_Value2", this.Blend);
			this.CBCNOEIALHB().SetFloat("UsernameText", this.OriginalIntensity);
			this.INOBFNCKFGK().SetFloat("_ScreenResolution", this.ResultIntensity);
			this.OKJOKHGJHGF().SetFloat("RootCanvas", this.FinalIntensity);
			this.PGPEMMBJOOG().SetFloat("_Speed", this.TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 0 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004B63 RID: 19299 RVA: 0x00172874 File Offset: 0x00170A74
	public void NEGEBFMDKLA(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.ValidDimensions(MKEKCIPLJNC))
			{
				Debug.LogWarning("[NetworkManager] Updating current room..." + MKEKCIPLJNC.name + "LoadingStatusText");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
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
			this.GHANEAKPIDG();
		}
	}

	// Token: 0x06004B64 RID: 19300 RVA: 0x0017299B File Offset: 0x00170B9B
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("Items/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004B65 RID: 19301 RVA: 0x001729BF File Offset: 0x00170BBF
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004B66 RID: 19302 RVA: 0x001729F8 File Offset: 0x00170BF8
	public void DIDMLEGDFKA(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.ValidDimensions(MKEKCIPLJNC))
			{
				Debug.LogWarning("_Value" + MKEKCIPLJNC.name + "_GlowColor");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 0; j < num; j += 0)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB4444, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.GDBBIPKIDFE();
		}
	}

	// Token: 0x06004B67 RID: 19303 RVA: 0x0002523B File Offset: 0x0002343B
	private void DJAEEDICHGD()
	{
	}

	// Token: 0x06004B68 RID: 19304 RVA: 0x00172B20 File Offset: 0x00170D20
	public bool IEHJLKAPGPG(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return false;
		}
		int height = LAFAECLOMJK.height;
		return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width)) || true;
	}

	// Token: 0x06004B69 RID: 19305 RVA: 0x00170CEB File Offset: 0x0016EEEB
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004B6A RID: 19306 RVA: 0x00172B5C File Offset: 0x00170D5C
	public void HLLEFNHABOE(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.LFMAKDCJNDM(MKEKCIPLJNC))
			{
				Debug.LogWarning("Result for " + MKEKCIPLJNC.name + "_Value4");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)0, false);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.HMGGOLFFLFB();
		}
	}

	// Token: 0x06004B6B RID: 19307 RVA: 0x00172C83 File Offset: 0x00170E83
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004B6C RID: 19308 RVA: 0x00172CBC File Offset: 0x00170EBC
	public void POKCKJHGBCL(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.HGHNFIPDINC(MKEKCIPLJNC))
			{
				Debug.LogWarning("< true | false >" + MKEKCIPLJNC.name + "_Blue_C");
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
						int num2 = num - j - 1;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
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
		else
		{
			this.CDJFAFNLEDP();
		}
	}

	// Token: 0x06004B6D RID: 19309 RVA: 0x00172DE4 File Offset: 0x00170FE4
	public void AOIFOCAEMND()
	{
		int num = -115;
		Color[] array = new Color[num * num * num];
		float num2 = 1796f / (1040f * (float)num - 1857f);
		for (int i = 0; i < num; i++)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 1; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 61f * num2, (float)j * 237f * num2, (float)k * 236f * num2, 1169f);
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

	// Token: 0x06004B6E RID: 19310 RVA: 0x00172ED6 File Offset: 0x001710D6
	private Material JCPDCGIJKJD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004B6F RID: 19311 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHICDLBKEJN()
	{
	}

	// Token: 0x06004B70 RID: 19312 RVA: 0x00172F10 File Offset: 0x00171110
	public bool AOLIIGHHMMO(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return false;
		}
		int height = LAFAECLOMJK.height;
		return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width));
	}

	// Token: 0x06004B71 RID: 19313 RVA: 0x00172F4C File Offset: 0x0017114C
	public void MIFBCGEFCFO(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.MIMOHBMBIOK(MKEKCIPLJNC))
			{
				Debug.LogWarning("_Far" + MKEKCIPLJNC.name + "Reset 21 achievement progress");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 0; j < num; j += 0)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)0, false);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.MFHOHBNFCDP();
		}
	}

	// Token: 0x06004B72 RID: 19314 RVA: 0x00173074 File Offset: 0x00171274
	public bool KCBPLKKBKIG(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width)) || true;
	}

	// Token: 0x06004B73 RID: 19315 RVA: 0x001730B0 File Offset: 0x001712B0
	public void MLBEEEMAHPK(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.KCBPLKKBKIG(MKEKCIPLJNC))
			{
				Debug.LogWarning("#challengecomplete" + MKEKCIPLJNC.name + "_Level");
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
						int num2 = num - j - 1;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
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
		else
		{
			this.GDBBIPKIDFE();
		}
	}

	// Token: 0x06004B74 RID: 19316 RVA: 0x001731D7 File Offset: 0x001713D7
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004B75 RID: 19317 RVA: 0x00170CEB File Offset: 0x0016EEEB
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004B76 RID: 19318 RVA: 0x0017320E File Offset: 0x0017140E
	private Material INOBFNCKFGK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004B77 RID: 19319 RVA: 0x00173248 File Offset: 0x00171448
	public void GFICBLAALAP(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.GDLNAHGPEPM(MKEKCIPLJNC))
			{
				Debug.LogWarning("Remove Environment Object" + MKEKCIPLJNC.name + "win");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB4444, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.IDHFCHEDFGF();
		}
	}

	// Token: 0x06004B78 RID: 19320 RVA: 0x00173370 File Offset: 0x00171570
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

	// Token: 0x06004B79 RID: 19321 RVA: 0x00173498 File Offset: 0x00171698
	public void ALFHDENNPHA()
	{
		int num = 76;
		Color[] array = new Color[num * num * num];
		float num2 = 712f / (1434f * (float)num - 492f);
		for (int i = 0; i < num; i++)
		{
			for (int j = 1; j < num; j++)
			{
				for (int k = 1; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 37f * num2, (float)j * 539f * num2, (float)k * 1545f * num2, 1562f);
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

	// Token: 0x06004B7A RID: 19322 RVA: 0x0002523B File Offset: 0x0002343B
	private void KPLKDJFKPDI()
	{
	}

	// Token: 0x06004B7B RID: 19323 RVA: 0x0017358A File Offset: 0x0017178A
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004B7C RID: 19324 RVA: 0x001735C4 File Offset: 0x001717C4
	public void KBIKACDMJGO()
	{
		int num = 105;
		Color[] array = new Color[num * num * num];
		float num2 = 35f / (320f * (float)num - 1145f);
		for (int i = 1; i < num; i++)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 1; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 1951f * num2, (float)j * 36f * num2, (float)k * 360f * num2, 1687f);
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

	// Token: 0x06004B7D RID: 19325 RVA: 0x001736B8 File Offset: 0x001718B8
	public void HMGDPFBBFCC(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.IEHJLKAPGPG(MKEKCIPLJNC))
			{
				Debug.LogWarning("GameScene" + MKEKCIPLJNC.name + "_Value5");
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
						int num2 = num - j - 0;
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
			this.HMGGOLFFLFB();
		}
	}

	// Token: 0x06004B7F RID: 19327 RVA: 0x00173813 File Offset: 0x00171A13
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("_Visualize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004B80 RID: 19328 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKDDHFJOAAD()
	{
	}

	// Token: 0x06004B81 RID: 19329 RVA: 0x0002523B File Offset: 0x0002343B
	private void FELENDJEOGA()
	{
	}

	// Token: 0x06004B82 RID: 19330 RVA: 0x00173837 File Offset: 0x00171A37
	private Material HKIMAANBGMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004B83 RID: 19331 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x06004B84 RID: 19332 RVA: 0x00173870 File Offset: 0x00171A70
	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 934f)
			{
				this.HBJJOCHGOPH = 1077f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.GMOFEELACOE(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.CBCNOEIALHB().SetTexture("[MenuScene] Error: ", this.PKINFPNDDAJ);
			this.JCPDCGIJKJD().SetFloat("menu.selectedlevelid", this.Blend);
			this.CIAFLBFJLEJ().SetFloat("_PColor2", this.OriginalIntensity);
			this.CIAFLBFJLEJ().SetFloat("%", this.ResultIntensity);
			this.HKIMAANBGMJ().SetFloat("GetRegions failed. Can't provide regions list. Error: ", this.FinalIntensity);
			this.OKJOKHGJHGF().SetFloat("_Value4", this.TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004B85 RID: 19333 RVA: 0x001739A0 File Offset: 0x00171BA0
	public void PGJAIMOPEJB(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.AOLIIGHHMMO(MKEKCIPLJNC))
			{
				Debug.LogWarning("\n" + MKEKCIPLJNC.name + "Fade");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 1; j < num; j++)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGBA32, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.HMGGOLFFLFB();
		}
	}

	// Token: 0x06004B86 RID: 19334 RVA: 0x00173AC8 File Offset: 0x00171CC8
	public void GMOFEELACOE(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.HGHNFIPDINC(MKEKCIPLJNC))
			{
				Debug.LogWarning("ERROR: preview file name is empty in modName.workshop.json" + MKEKCIPLJNC.name + "CameraFilterPack/3D_Myst");
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB565, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.CAIEGMIKBCN();
		}
	}

	// Token: 0x06004B87 RID: 19335 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06004B88 RID: 19336 RVA: 0x0002523B File Offset: 0x0002343B
	private void APMCFBKLDBD()
	{
	}

	// Token: 0x06004B89 RID: 19337 RVA: 0x0002523B File Offset: 0x0002343B
	private void MPHAMHBNCJF()
	{
	}

	// Token: 0x06004B8A RID: 19338 RVA: 0x00173BF0 File Offset: 0x00171DF0
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1054f)
			{
				this.HBJJOCHGOPH = 1427f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.POKCKJHGBCL(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.LDNADDJMIPK().SetTexture("CameraFilterPack/Blizzard", this.PKINFPNDDAJ);
			this.NBPKMLMCHFN.SetFloat("_BlurSize", this.Blend);
			this.INOBFNCKFGK().SetFloat("%", this.OriginalIntensity);
			this.DBOLLHHMKKN().SetFloat("Destroying GO as global. ID: ", this.ResultIntensity);
			this.INOBFNCKFGK().SetFloat("start", this.FinalIntensity);
			this.DBOLLHHMKKN().SetFloat("menu.selectedmode", this.TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004B8B RID: 19339 RVA: 0x00173D1D File Offset: 0x00171F1D
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Lut_TestMode");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004B8C RID: 19340 RVA: 0x00173D44 File Offset: 0x00171F44
	public void IDHFCHEDFGF()
	{
		int num = -12;
		Color[] array = new Color[num * num * num];
		float num2 = 1876f / (1620f * (float)num - 1355f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 1; k < num; k += 0)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 1800f * num2, (float)j * 1075f * num2, (float)k * 832f * num2, 1776f);
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

	// Token: 0x06004B8D RID: 19341 RVA: 0x00173E38 File Offset: 0x00172038
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
			this.NBPKMLMCHFN.SetFloat("_Extra3", this.TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 0 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004B8E RID: 19342 RVA: 0x00173F68 File Offset: 0x00172168
	public bool FBBJMEBJKPI(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width)) || true;
	}

	// Token: 0x170000D9 RID: 217
	// (get) Token: 0x06004B8F RID: 19343 RVA: 0x00173FA3 File Offset: 0x001721A3
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

	// Token: 0x06004B90 RID: 19344 RVA: 0x00173FDC File Offset: 0x001721DC
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1599f)
			{
				this.HBJJOCHGOPH = 141f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.DPFIBMMGOHN(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			this.OKJOKHGJHGF().SetTexture("Event Received", this.PKINFPNDDAJ);
			this.EJDPNJAEAKJ().SetFloat("_SecondTex", this.Blend);
			this.HKIMAANBGMJ().SetFloat("id", this.OriginalIntensity);
			this.HCGJCMDJPGD().SetFloat("workshop.", this.ResultIntensity);
			this.NBPKMLMCHFN.SetFloat("Sprite", this.FinalIntensity);
			this.DBOLLHHMKKN().SetFloat(".", this.TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004B91 RID: 19345 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLDHEJIEDHO()
	{
	}

	// Token: 0x06004B92 RID: 19346 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNACKHNNEPA()
	{
	}

	// Token: 0x06004B93 RID: 19347 RVA: 0x0017410C File Offset: 0x0017230C
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 162f)
			{
				this.HBJJOCHGOPH = 1199f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.OGPMOJMLBLL(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			this.HFBJAOFLCJI().SetTexture("float,0", this.PKINFPNDDAJ);
			this.JLHLHKPHDFO().SetFloat("Anomaly_Distortion", this.Blend);
			this.HCGJCMDJPGD().SetFloat("[Left]", this.OriginalIntensity);
			this.CBCNOEIALHB().SetFloat("FinalScoreSmallText", this.ResultIntensity);
			this.PGPEMMBJOOG().SetFloat("Tab1Content", this.FinalIntensity);
			this.EJDPNJAEAKJ().SetFloat("SetSatelliteRotationSpeed", this.TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 0 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004B94 RID: 19348 RVA: 0x0017423C File Offset: 0x0017243C
	public void AKMELFHHFLL()
	{
		int num = 70;
		Color[] array = new Color[num * num * num];
		float num2 = 1961f / (1613f * (float)num - 1896f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 0; k < num; k += 0)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 3f * num2, (float)j * 741f * num2, (float)k * 1065f * num2, 1286f);
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

	// Token: 0x06004B95 RID: 19349 RVA: 0x00174330 File Offset: 0x00172530
	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 362f)
			{
				this.HBJJOCHGOPH = 1707f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.Convert(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.LDNADDJMIPK().SetTexture("_ScreenResolution", this.PKINFPNDDAJ);
			this.CBCNOEIALHB().SetFloat("CameraFilterPack/Gradients_Desert", this.Blend);
			this.LDNADDJMIPK().SetFloat("_Value", this.OriginalIntensity);
			this.CIAFLBFJLEJ().SetFloat("0", this.ResultIntensity);
			this.OKJOKHGJHGF().SetFloat("_Value3", this.FinalIntensity);
			this.DBOLLHHMKKN().SetFloat(" PhotonNetwork.networkingPeer.AvailableRegions ", this.TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JCPDCGIJKJD(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 0 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004B96 RID: 19350 RVA: 0x00174460 File Offset: 0x00172660
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1081f)
			{
				this.HBJJOCHGOPH = 370f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.HLLEFNHABOE(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			this.HKIMAANBGMJ().SetTexture("_Value", this.PKINFPNDDAJ);
			this.PGPEMMBJOOG().SetFloat(".", this.Blend);
			this.LDNADDJMIPK().SetFloat("_ScreenResolution", this.OriginalIntensity);
			this.OKJOKHGJHGF().SetFloat("CameraFilterPack/Color_Invert", this.ResultIntensity);
			this.INOBFNCKFGK().SetFloat("]", this.FinalIntensity);
			this.JLHLHKPHDFO().SetFloat("Load scene by name or build id", this.TestMode);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 0 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004B97 RID: 19351 RVA: 0x0017458D File Offset: 0x0017278D
	private void FANADGBGCPI()
	{
		this.SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004B98 RID: 19352 RVA: 0x001745B4 File Offset: 0x001727B4
	public void DPFIBMMGOHN(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.BBECBFDCFGB(MKEKCIPLJNC))
			{
				Debug.LogWarning("_TimeX" + MKEKCIPLJNC.name + "_ScreenResolution");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 1; j < num; j++)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB565, false);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.ALFHDENNPHA();
		}
	}

	// Token: 0x06004B99 RID: 19353 RVA: 0x0002523B File Offset: 0x0002343B
	private void GEGDELOFIML()
	{
	}

	// Token: 0x040007E3 RID: 2019
	public Shader SCShader;

	// Token: 0x040007E4 RID: 2020
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040007E5 RID: 2021
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040007E6 RID: 2022
	private Material BJFKDHHMLJH;

	// Token: 0x040007E7 RID: 2023
	public Texture2D LutTexture;

	// Token: 0x040007E8 RID: 2024
	private Texture3D PKINFPNDDAJ;

	// Token: 0x040007E9 RID: 2025
	[Range(0f, 1f)]
	public float Blend = 1f;

	// Token: 0x040007EA RID: 2026
	[Range(0f, 3f)]
	public float OriginalIntensity = 1f;

	// Token: 0x040007EB RID: 2027
	[Range(-1f, 1f)]
	public float ResultIntensity;

	// Token: 0x040007EC RID: 2028
	[Range(-1f, 1f)]
	public float FinalIntensity;

	// Token: 0x040007ED RID: 2029
	[Range(0f, 1f)]
	public float TestMode = 0.5f;

	// Token: 0x040007EE RID: 2030
	private string CHMMPJKAMPM;
}
