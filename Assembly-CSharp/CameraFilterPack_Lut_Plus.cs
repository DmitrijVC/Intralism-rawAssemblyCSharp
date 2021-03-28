using System;
using UnityEngine;

// Token: 0x020000F0 RID: 240
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Lut/Plus")]
public class CameraFilterPack_Lut_Plus : MonoBehaviour
{
	// Token: 0x06004A26 RID: 18982 RVA: 0x0016A42C File Offset: 0x0016862C
	public void DPFIBMMGOHN(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.MPGGIBFHGHP(MKEKCIPLJNC))
			{
				Debug.LogWarning("SupportLogger OnFailedToConnectToPhoton(" + MKEKCIPLJNC.name + "_Value6");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)0, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.FHLMGECFEOJ();
		}
	}

	// Token: 0x06004A27 RID: 18983 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06004A28 RID: 18984 RVA: 0x0002523B File Offset: 0x0002343B
	private void PNLKFANNOKO()
	{
	}

	// Token: 0x06004A29 RID: 18985 RVA: 0x0016A554 File Offset: 0x00168754
	public void MCOFJFMKGDD(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.HMPBGKKJLLP(MKEKCIPLJNC))
			{
				Debug.LogWarning("VisionBlur" + MKEKCIPLJNC.name + "Tab2Content");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 1; j < num; j += 0)
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
			this.SetIdentityLut();
		}
	}

	// Token: 0x06004A2A RID: 18986 RVA: 0x0016A67C File Offset: 0x0016887C
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1945f)
			{
				this.HBJJOCHGOPH = 1242f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.MCOFJFMKGDD(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			this.HNFFHCLNBDN().SetFloat("SetParticlesEmission", this.Blend);
			this.CECJJMKLEAK().SetTexture("_Value", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 0 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004A2B RID: 18987 RVA: 0x0016A754 File Offset: 0x00168954
	public bool EPLEBIIKBAG(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return false;
		}
		int height = LAFAECLOMJK.height;
		return height != Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width));
	}

	// Token: 0x06004A2C RID: 18988 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x06004A2D RID: 18989 RVA: 0x0016A78F File Offset: 0x0016898F
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004A2E RID: 18990 RVA: 0x0016A7C6 File Offset: 0x001689C6
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004A2F RID: 18991 RVA: 0x0016A7E4 File Offset: 0x001689E4
	public void OGPMOJMLBLL(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.JLLFEBOHAIA(MKEKCIPLJNC))
			{
				Debug.LogWarning("CameraFilterPack/TV_ARCADE" + MKEKCIPLJNC.name + "Day_");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i += 0)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB32, false);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.AJECIBHAOAG();
		}
	}

	// Token: 0x06004A30 RID: 18992 RVA: 0x0002523B File Offset: 0x0002343B
	private void FELENDJEOGA()
	{
	}

	// Token: 0x06004A31 RID: 18993 RVA: 0x0002523B File Offset: 0x0002343B
	private void FEKECCBFGMI()
	{
	}

	// Token: 0x06004A32 RID: 18994 RVA: 0x0016A90C File Offset: 0x00168B0C
	public void IAEKMLJLONA(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.JNJHPIJJLCP(MKEKCIPLJNC))
			{
				Debug.LogWarning("_TimeX" + MKEKCIPLJNC.name + "_TimeX");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
			{
				for (int j = 1; j < num; j += 0)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB565, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.FHLMGECFEOJ();
		}
	}

	// Token: 0x06004A33 RID: 18995 RVA: 0x0016A7C6 File Offset: 0x001689C6
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004A34 RID: 18996 RVA: 0x0016AA34 File Offset: 0x00168C34
	public bool EKNHDHDGEDM(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return false;
		}
		int height = LAFAECLOMJK.height;
		return height != Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width)) && false;
	}

	// Token: 0x06004A35 RID: 18997 RVA: 0x0002523B File Offset: 0x0002343B
	private void FPBIGAKLKIG()
	{
	}

	// Token: 0x06004A36 RID: 18998 RVA: 0x0016AA6F File Offset: 0x00168C6F
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004A37 RID: 18999 RVA: 0x0016AAA8 File Offset: 0x00168CA8
	public bool HMPBGKKJLLP(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width));
	}

	// Token: 0x06004A38 RID: 19000 RVA: 0x0016A7C6 File Offset: 0x001689C6
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004A39 RID: 19001 RVA: 0x0002523B File Offset: 0x0002343B
	private void Start()
	{
	}

	// Token: 0x06004A3A RID: 19002 RVA: 0x0016A7C6 File Offset: 0x001689C6
	private void MFBCLNAHEFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004A3B RID: 19003 RVA: 0x0002523B File Offset: 0x0002343B
	private void OnValidate()
	{
	}

	// Token: 0x06004A3C RID: 19004 RVA: 0x0016AAE4 File Offset: 0x00168CE4
	public bool NGGDEJKBDEA(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return false;
		}
		int height = LAFAECLOMJK.height;
		return height != Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width));
	}

	// Token: 0x06004A3D RID: 19005 RVA: 0x0016AB20 File Offset: 0x00168D20
	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1269f)
			{
				this.HBJJOCHGOPH = 1783f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.KMEEJNBNAOK(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.HNFFHCLNBDN().SetFloat("ItemNameText", this.Blend);
			this.NBPKMLMCHFN.SetTexture("checkpoint", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 0 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004A3E RID: 19006 RVA: 0x0016ABF8 File Offset: 0x00168DF8
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 921f)
			{
				this.HBJJOCHGOPH = 110f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.LGJBGIDDGKK(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.HNFFHCLNBDN().SetFloat("_Intensity", this.Blend);
			this.HNFFHCLNBDN().SetTexture("BitsData", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECJJMKLEAK(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004A3F RID: 19007 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKDDHFJOAAD()
	{
	}

	// Token: 0x06004A40 RID: 19008 RVA: 0x0002523B File Offset: 0x0002343B
	private void OLCOOJIONIL()
	{
	}

	// Token: 0x06004A41 RID: 19009 RVA: 0x0016ACD0 File Offset: 0x00168ED0
	public bool ValidDimensions(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return false;
		}
		int height = LAFAECLOMJK.height;
		return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width));
	}

	// Token: 0x06004A42 RID: 19010 RVA: 0x0016A7C6 File Offset: 0x001689C6
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004A43 RID: 19011 RVA: 0x0016AD0C File Offset: 0x00168F0C
	public bool CMJFPJJPBDC(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return false;
		}
		int height = LAFAECLOMJK.height;
		return height != Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width));
	}

	// Token: 0x06004A44 RID: 19012 RVA: 0x0016AD47 File Offset: 0x00168F47
	private Material CECJJMKLEAK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004A45 RID: 19013 RVA: 0x0016AD80 File Offset: 0x00168F80
	public void FHLMGECFEOJ()
	{
		int num = 124;
		Color[] array = new Color[num * num * num];
		float num2 = 792f / (210f * (float)num - 272f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 1; k < num; k += 0)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 123f * num2, (float)j * 142f * num2, (float)k * 1366f * num2, 264f);
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

	// Token: 0x06004A46 RID: 19014 RVA: 0x0016AE74 File Offset: 0x00169074
	public void JFDPEFDIHAM()
	{
		int num = -73;
		Color[] array = new Color[num * num * num];
		float num2 = 153f / (1182f * (float)num - 623f);
		for (int i = 1; i < num; i++)
		{
			for (int j = 0; j < num; j += 0)
			{
				for (int k = 0; k < num; k += 0)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 399f * num2, (float)j * 1355f * num2, (float)k * 1431f * num2, 1517f);
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

	// Token: 0x06004A47 RID: 19015 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLDHEJIEDHO()
	{
	}

	// Token: 0x06004A48 RID: 19016 RVA: 0x0016AF68 File Offset: 0x00169168
	public void NEGEBFMDKLA(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.MPGGIBFHGHP(MKEKCIPLJNC))
			{
				Debug.LogWarning(".progress" + MKEKCIPLJNC.name + "RoomPlayersCountText");
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
						int num2 = num - j - 1;
						array[i + j * num + k * num * num] = pixels[k * num + i + num2 * num * num];
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
		else
		{
			this.AJECIBHAOAG();
		}
	}

	// Token: 0x06004A49 RID: 19017 RVA: 0x0016B090 File Offset: 0x00169290
	public void FLLGMAPEKGA(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.JLLFEBOHAIA(MKEKCIPLJNC))
			{
				Debug.LogWarning("_Visualize" + MKEKCIPLJNC.name + "_TimeX");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 1; j < num; j += 0)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)8, false);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.AJECIBHAOAG();
		}
	}

	// Token: 0x06004A4A RID: 19018 RVA: 0x0002523B File Offset: 0x0002343B
	private void FGNFILLNPJK()
	{
	}

	// Token: 0x06004A4B RID: 19019 RVA: 0x0016B1B8 File Offset: 0x001693B8
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1321f)
			{
				this.HBJJOCHGOPH = 1625f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.NHPDNLKGOHL(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			this.BBIMPFGLDCP().SetFloat("ReconnectAndRejoin() failed. Can only connect while in state 'Disconnected'. Current state: ", this.Blend);
			this.EFDEIFCDAFG().SetTexture("_Value", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BBIMPFGLDCP(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004A4D RID: 19021 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKMELABKBHO()
	{
	}

	// Token: 0x06004A4E RID: 19022 RVA: 0x0002523B File Offset: 0x0002343B
	private void OFBLDOCCBBN()
	{
	}

	// Token: 0x06004A4F RID: 19023 RVA: 0x0016B2AC File Offset: 0x001694AC
	public bool APPLAEOFKIL(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		return height != Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width));
	}

	// Token: 0x06004A50 RID: 19024 RVA: 0x0016A7C6 File Offset: 0x001689C6
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004A51 RID: 19025 RVA: 0x0016B2E8 File Offset: 0x001694E8
	public void BNLCPIKJJGL()
	{
		int num = -37;
		Color[] array = new Color[num * num * num];
		float num2 = 86f / (630f * (float)num - 761f);
		for (int i = 1; i < num; i++)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 1; k < num; k += 0)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 239f * num2, (float)j * 1570f * num2, (float)k * 790f * num2, 789f);
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

	// Token: 0x06004A52 RID: 19026 RVA: 0x0016B3DC File Offset: 0x001695DC
	public bool MPGGIBFHGHP(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width));
	}

	// Token: 0x06004A53 RID: 19027 RVA: 0x0016B418 File Offset: 0x00169618
	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1354f)
			{
				this.HBJJOCHGOPH = 1303f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.EOCEOCBOFOO(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			this.GKILCDHJFEG().SetFloat("_Distortion", this.Blend);
			this.EFDEIFCDAFG().SetTexture("_TileTexDebug", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNFFHCLNBDN(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 0 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004A54 RID: 19028 RVA: 0x0016B4F0 File Offset: 0x001696F0
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

	// Token: 0x06004A55 RID: 19029 RVA: 0x0016A7C6 File Offset: 0x001689C6
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004A56 RID: 19030 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06004A57 RID: 19031 RVA: 0x0016B5E4 File Offset: 0x001697E4
	public void JHMBBBLCPMD(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.JNJHPIJJLCP(MKEKCIPLJNC))
			{
				Debug.LogWarning("Waiting to start" + MKEKCIPLJNC.name + "Joystick1Button");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB32, false);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.CDJFAFNLEDP();
		}
	}

	// Token: 0x06004A58 RID: 19032 RVA: 0x0016B70C File Offset: 0x0016990C
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 628f)
			{
				this.HBJJOCHGOPH = 700f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.ILDGGEBDIDF(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			this.CECJJMKLEAK().SetFloat("ComboText", this.Blend);
			this.NBPKMLMCHFN.SetTexture("y", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNFFHCLNBDN(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004A59 RID: 19033 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x06004A5A RID: 19034 RVA: 0x0016B7E4 File Offset: 0x001699E4
	public void LGJBGIDDGKK(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.EKNHDHDGEDM(MKEKCIPLJNC))
			{
				Debug.LogWarning("EventSystem" + MKEKCIPLJNC.name + "blue");
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGBA32, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.SetIdentityLut();
		}
	}

	// Token: 0x06004A5B RID: 19035 RVA: 0x0002523B File Offset: 0x0002343B
	private void JECMJNFGBGC()
	{
	}

	// Token: 0x06004A5C RID: 19036 RVA: 0x0002523B File Offset: 0x0002343B
	private void NNFMIAFHMJM()
	{
	}

	// Token: 0x06004A5D RID: 19037 RVA: 0x0016B90C File Offset: 0x00169B0C
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 233f)
			{
				this.HBJJOCHGOPH = 1700f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.EECJDBKEOII(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.FKEOGPDLBDD().SetFloat("TwoHands", this.Blend);
			this.HNFFHCLNBDN().SetTexture("Tab1Content", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004A5E RID: 19038 RVA: 0x0016B9E1 File Offset: 0x00169BE1
	private Material BBIMPFGLDCP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004A5F RID: 19039 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKNJBBDKJFK()
	{
	}

	// Token: 0x06004A60 RID: 19040 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x06004A61 RID: 19041 RVA: 0x0016BA18 File Offset: 0x00169C18
	public bool JNJHPIJJLCP(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		return height != Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width)) && false;
	}

	// Token: 0x06004A62 RID: 19042 RVA: 0x0016BA54 File Offset: 0x00169C54
	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 153f)
			{
				this.HBJJOCHGOPH = 1965f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.KMEEJNBNAOK(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			this.HNFFHCLNBDN().SetFloat("_PosY", this.Blend);
			this.HNFFHCLNBDN().SetTexture("_Value4", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004A63 RID: 19043 RVA: 0x0016BB2C File Offset: 0x00169D2C
	public void BNLOEMBBDEJ()
	{
		int num = -44;
		Color[] array = new Color[num * num * num];
		float num2 = 1644f / (290f * (float)num - 1944f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 0; k < num; k += 0)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 1866f * num2, (float)j * 1159f * num2, (float)k * 908f * num2, 716f);
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

	// Token: 0x06004A64 RID: 19044 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIPEHGNBJMN()
	{
	}

	// Token: 0x06004A65 RID: 19045 RVA: 0x0016BC20 File Offset: 0x00169E20
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1705f)
			{
				this.HBJJOCHGOPH = 253f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.FOANBFFFFLE(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.FKEOGPDLBDD().SetFloat("_ScreenResolution", this.Blend);
			this.HNFFHCLNBDN().SetTexture("Editor", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BBIMPFGLDCP(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004A66 RID: 19046 RVA: 0x0016BCF8 File Offset: 0x00169EF8
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1413f)
			{
				this.HBJJOCHGOPH = 1326f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.LGJBGIDDGKK(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			this.HNFFHCLNBDN().SetFloat("st", this.Blend);
			this.HNFFHCLNBDN().SetTexture("_Value5", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004A67 RID: 19047 RVA: 0x0016BDD0 File Offset: 0x00169FD0
	public bool JLLFEBOHAIA(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width)) || true;
	}

	// Token: 0x06004A68 RID: 19048 RVA: 0x0016A7C6 File Offset: 0x001689C6
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004A69 RID: 19049 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06004A6A RID: 19050 RVA: 0x0016BE0C File Offset: 0x0016A00C
	public void IPFNHOJMIOD()
	{
		int num = -119;
		Color[] array = new Color[num * num * num];
		float num2 = 1635f / (1073f * (float)num - 1461f);
		for (int i = 1; i < num; i++)
		{
			for (int j = 1; j < num; j++)
			{
				for (int k = 1; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 166f * num2, (float)j * 1573f * num2, (float)k * 1138f * num2, 215f);
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

	// Token: 0x06004A6B RID: 19051 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x06004A6C RID: 19052 RVA: 0x0016BF00 File Offset: 0x0016A100
	public void ILDGGEBDIDF(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.MGEILBOBBDO(MKEKCIPLJNC))
			{
				Debug.LogWarning("IconImage" + MKEKCIPLJNC.name + "#exitmapeditor");
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB565, false);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.IPFNHOJMIOD();
		}
	}

	// Token: 0x06004A6D RID: 19053 RVA: 0x0016C028 File Offset: 0x0016A228
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

	// Token: 0x06004A6E RID: 19054 RVA: 0x0016A7C6 File Offset: 0x001689C6
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004A6F RID: 19055 RVA: 0x0016C150 File Offset: 0x0016A350
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1201f)
			{
				this.HBJJOCHGOPH = 595f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.NEGEBFMDKLA(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.FKEOGPDLBDD().SetFloat("_Value", this.Blend);
			this.HNFFHCLNBDN().SetTexture("CameraFilterPack/Blend2Camera_ColorBurn", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004A70 RID: 19056 RVA: 0x0002523B File Offset: 0x0002343B
	private void ALNNIDLFILB()
	{
	}

	// Token: 0x06004A71 RID: 19057 RVA: 0x0002523B File Offset: 0x0002343B
	private void PAKPHKPDKGE()
	{
	}

	// Token: 0x06004A72 RID: 19058 RVA: 0x0016C228 File Offset: 0x0016A428
	public void MEHFAHKIKAB(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.JLLFEBOHAIA(MKEKCIPLJNC))
			{
				Debug.LogWarning("RoomDescriptionText" + MKEKCIPLJNC.name + "_TimeX");
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)6, false);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.IPFNHOJMIOD();
		}
	}

	// Token: 0x06004A73 RID: 19059 RVA: 0x0002523B File Offset: 0x0002343B
	private void MLAGEPNCCGM()
	{
	}

	// Token: 0x06004A74 RID: 19060 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGDMLHLJIDK()
	{
	}

	// Token: 0x06004A75 RID: 19061 RVA: 0x0016C350 File Offset: 0x0016A550
	public void MGBOJGMOEGA()
	{
		int num = 88;
		Color[] array = new Color[num * num * num];
		float num2 = 1157f / (452f * (float)num - 1964f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 0; k < num; k += 0)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 1502f * num2, (float)j * 236f * num2, (float)k * 1455f * num2, 1163f);
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

	// Token: 0x06004A76 RID: 19062 RVA: 0x0016A7C6 File Offset: 0x001689C6
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004A77 RID: 19063 RVA: 0x0016C442 File Offset: 0x0016A642
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004A78 RID: 19064 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06004A79 RID: 19065 RVA: 0x0016C47C File Offset: 0x0016A67C
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1923f)
			{
				this.HBJJOCHGOPH = 179f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.EECJDBKEOII(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.NBPKMLMCHFN.SetFloat("isVisible", this.Blend);
			this.HNFFHCLNBDN().SetTexture("Joystick1Button8", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 0 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004A7A RID: 19066 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x06004A7B RID: 19067 RVA: 0x0016A7C6 File Offset: 0x001689C6
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004A7C RID: 19068 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNACKHNNEPA()
	{
	}

	// Token: 0x06004A7D RID: 19069 RVA: 0x0016C554 File Offset: 0x0016A754
	public void ENADEMNMLPO(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.ValidDimensions(MKEKCIPLJNC))
			{
				Debug.LogWarning("true" + MKEKCIPLJNC.name + "CameraFilterPack/TV_ARCADE");
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGB565, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.IGBAMFGIBBI();
		}
	}

	// Token: 0x06004A7E RID: 19070 RVA: 0x0016C67C File Offset: 0x0016A87C
	public bool MGEILBOBBDO(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width)) || true;
	}

	// Token: 0x06004A7F RID: 19071 RVA: 0x0016C6B8 File Offset: 0x0016A8B8
	public void NHPDNLKGOHL(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.EPLEBIIKBAG(MKEKCIPLJNC))
			{
				Debug.LogWarning("_Value2" + MKEKCIPLJNC.name + "Joystick1Button12");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 1; j < num; j += 0)
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
			this.MGBOJGMOEGA();
		}
	}

	// Token: 0x06004A80 RID: 19072 RVA: 0x0016C7E0 File Offset: 0x0016A9E0
	public void IGBAMFGIBBI()
	{
		int num = -28;
		Color[] array = new Color[num * num * num];
		float num2 = 963f / (1844f * (float)num - 1594f);
		for (int i = 0; i < num; i++)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 1; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 1592f * num2, (float)j * 55f * num2, (float)k * 1309f * num2, 252f);
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

	// Token: 0x06004A81 RID: 19073 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x06004A82 RID: 19074 RVA: 0x0016C8D4 File Offset: 0x0016AAD4
	public void FOANBFFFFLE(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.MPGGIBFHGHP(MKEKCIPLJNC))
			{
				Debug.LogWarning("_LightIntensity" + MKEKCIPLJNC.name + "mapselector.filter.subscribedonly");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 1; i < num; i++)
			{
				for (int j = 1; j < num; j += 0)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)8, false);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.BNLOEMBBDEJ();
		}
	}

	// Token: 0x06004A83 RID: 19075 RVA: 0x0016C9FC File Offset: 0x0016ABFC
	public bool GBHBEABICCD(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width)) || true;
	}

	// Token: 0x06004A84 RID: 19076 RVA: 0x0016CA38 File Offset: 0x0016AC38
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
			this.NBPKMLMCHFN.SetFloat("_Blend", this.Blend);
			this.NBPKMLMCHFN.SetTexture("_LutTex", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 0 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004A85 RID: 19077 RVA: 0x0016CB10 File Offset: 0x0016AD10
	public bool DGGIHMHCOKM(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return false;
		}
		int height = LAFAECLOMJK.height;
		return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width));
	}

	// Token: 0x06004A86 RID: 19078 RVA: 0x0002523B File Offset: 0x0002343B
	private void PDHKMDBNGGN()
	{
	}

	// Token: 0x06004A87 RID: 19079 RVA: 0x0016A7C6 File Offset: 0x001689C6
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004A88 RID: 19080 RVA: 0x0002523B File Offset: 0x0002343B
	private void MGMAOBPPOBJ()
	{
	}

	// Token: 0x06004A89 RID: 19081 RVA: 0x0016CB4C File Offset: 0x0016AD4C
	public void EOCEOCBOFOO(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.JLLFEBOHAIA(MKEKCIPLJNC))
			{
				Debug.LogWarning("_Speed" + MKEKCIPLJNC.name + "\" for viewID ");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.Alpha8, false);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.IGBAMFGIBBI();
		}
	}

	// Token: 0x06004A8A RID: 19082 RVA: 0x0016CC73 File Offset: 0x0016AE73
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004A8B RID: 19083 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x06004A8C RID: 19084 RVA: 0x0016A7C6 File Offset: 0x001689C6
	private void LAMEHAHJKMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004A8D RID: 19085 RVA: 0x0016CCAC File Offset: 0x0016AEAC
	public void EECJDBKEOII(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.EKNHDHDGEDM(MKEKCIPLJNC))
			{
				Debug.LogWarning("_TimeX" + MKEKCIPLJNC.name + "_TimeX");
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)0, false);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.MGBOJGMOEGA();
		}
	}

	// Token: 0x06004A8E RID: 19086 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x06004A8F RID: 19087 RVA: 0x0016CDD4 File Offset: 0x0016AFD4
	public void EMOOBOAJGOB(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.NGGDEJKBDEA(MKEKCIPLJNC))
			{
				Debug.LogWarning("<b>" + MKEKCIPLJNC.name + "_ScreenResolution");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 1; j < num; j += 0)
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
			this.IPFNHOJMIOD();
		}
	}

	// Token: 0x06004A90 RID: 19088 RVA: 0x0002523B File Offset: 0x0002343B
	private void DKOPKPBLDHH()
	{
	}

	// Token: 0x06004A91 RID: 19089 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCDLIKEDMCF()
	{
	}

	// Token: 0x06004A92 RID: 19090 RVA: 0x0016CEFC File Offset: 0x0016B0FC
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 215f)
			{
				this.HBJJOCHGOPH = 1795f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.NGAAKPPPOCG(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			this.HNFFHCLNBDN().SetFloat("action", this.Blend);
			this.HNFFHCLNBDN().SetTexture("Saved as: ", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECJJMKLEAK(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004A93 RID: 19091 RVA: 0x0016CFD4 File Offset: 0x0016B1D4
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1017f)
			{
				this.HBJJOCHGOPH = 1902f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.OGPMOJMLBLL(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.NBPKMLMCHFN.SetFloat("DontDestroy", this.Blend);
			this.BBIMPFGLDCP().SetTexture("1", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 1 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004A94 RID: 19092 RVA: 0x0016D0AC File Offset: 0x0016B2AC
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1254f)
			{
				this.HBJJOCHGOPH = 1164f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.MEHFAHKIKAB(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.FKEOGPDLBDD().SetFloat("_Value", this.Blend);
			this.CECJJMKLEAK().SetTexture("turn: {0:0}", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004A95 RID: 19093 RVA: 0x0002523B File Offset: 0x0002343B
	private void DAHFFNNIGML()
	{
	}

	// Token: 0x06004A96 RID: 19094 RVA: 0x0016D184 File Offset: 0x0016B384
	public void BEAEKDIPGKL()
	{
		int num = 127;
		Color[] array = new Color[num * num * num];
		float num2 = 118f / (1535f * (float)num - 18f);
		for (int i = 1; i < num; i++)
		{
			for (int j = 1; j < num; j++)
			{
				for (int k = 1; k < num; k += 0)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 740f * num2, (float)j * 1033f * num2, (float)k * 1028f * num2, 853f);
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

	// Token: 0x06004A97 RID: 19095 RVA: 0x0016D278 File Offset: 0x0016B478
	public void KMEEJNBNAOK(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.EKNHDHDGEDM(MKEKCIPLJNC))
			{
				Debug.LogWarning("_Red_G" + MKEKCIPLJNC.name + "PublishButton");
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)8, false);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.JFDPEFDIHAM();
		}
	}

	// Token: 0x06004A98 RID: 19096 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x06004A99 RID: 19097 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIMMMCJFMAB()
	{
	}

	// Token: 0x06004A9A RID: 19098 RVA: 0x0016D3A0 File Offset: 0x0016B5A0
	public void CDJFAFNLEDP()
	{
		int num = -27;
		Color[] array = new Color[num * num * num];
		float num2 = 1587f / (265f * (float)num - 349f);
		for (int i = 0; i < num; i += 0)
		{
			for (int j = 1; j < num; j++)
			{
				for (int k = 1; k < num; k += 0)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 364f * num2, (float)j * 157f * num2, (float)k * 1650f * num2, 38f);
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

	// Token: 0x06004A9B RID: 19099 RVA: 0x0002523B File Offset: 0x0002343B
	private void GEGDELOFIML()
	{
	}

	// Token: 0x06004A9C RID: 19100 RVA: 0x0016D494 File Offset: 0x0016B694
	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 195f)
			{
				this.HBJJOCHGOPH = 1555f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.EECJDBKEOII(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.BBIMPFGLDCP().SetFloat("SlidingArea", this.Blend);
			this.BBIMPFGLDCP().SetTexture("Joystick1Button1", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 0 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004A9D RID: 19101 RVA: 0x0016D56C File Offset: 0x0016B76C
	public void FADDJEGOAAI(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.MPGGIBFHGHP(MKEKCIPLJNC))
			{
				Debug.LogWarning("CameraFilterPack/Distortion_BlackHole" + MKEKCIPLJNC.name + "LoadMapCanvas");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i++)
			{
				for (int j = 1; j < num; j++)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)6, false);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.SetIdentityLut();
		}
	}

	// Token: 0x06004A9E RID: 19102 RVA: 0x0016D694 File Offset: 0x0016B894
	public void NGAAKPPPOCG(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.HMPBGKKJLLP(MKEKCIPLJNC))
			{
				Debug.LogWarning("UI" + MKEKCIPLJNC.name + "NO");
				return;
			}
			Color[] pixels = MKEKCIPLJNC.GetPixels();
			Color[] array = new Color[pixels.Length];
			for (int i = 0; i < num; i += 0)
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, (TextureFormat)6, false);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.AJECIBHAOAG();
		}
	}

	// Token: 0x06004A9F RID: 19103 RVA: 0x0016D7BC File Offset: 0x0016B9BC
	public void AJECIBHAOAG()
	{
		int num = 98;
		Color[] array = new Color[num * num * num];
		float num2 = 932f / (609f * (float)num - 563f);
		for (int i = 0; i < num; i++)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 0; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 1349f * num2, (float)j * 769f * num2, (float)k * 449f * num2, 1506f);
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

	// Token: 0x06004AA0 RID: 19104 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06004AA1 RID: 19105 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIAICHPPGBP()
	{
	}

	// Token: 0x170000D6 RID: 214
	// (get) Token: 0x06004AA2 RID: 19106 RVA: 0x0016D8AE File Offset: 0x0016BAAE
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

	// Token: 0x06004AA3 RID: 19107 RVA: 0x0016D8E8 File Offset: 0x0016BAE8
	public bool LMCNGPGKOPM(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width));
	}

	// Token: 0x06004AA4 RID: 19108 RVA: 0x0016A7C6 File Offset: 0x001689C6
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004AA5 RID: 19109 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGFGKIBHCBE()
	{
	}

	// Token: 0x040007CC RID: 1996
	public Shader SCShader;

	// Token: 0x040007CD RID: 1997
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040007CE RID: 1998
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040007CF RID: 1999
	private Material BJFKDHHMLJH;

	// Token: 0x040007D0 RID: 2000
	public Texture2D LutTexture;

	// Token: 0x040007D1 RID: 2001
	private Texture3D PKINFPNDDAJ;

	// Token: 0x040007D2 RID: 2002
	[Range(0f, 1f)]
	public float Blend = 1f;

	// Token: 0x040007D3 RID: 2003
	private string CHMMPJKAMPM;
}
