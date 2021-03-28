using System;
using UnityEngine;

// Token: 0x020000F1 RID: 241
[AddComponentMenu("Camera Filter Pack/Lut/Plus")]
[ExecuteInEditMode]
public class CameraFilterPack_Lut_Plus_2 : MonoBehaviour
{
	// Token: 0x06004AA6 RID: 19110 RVA: 0x0016D923 File Offset: 0x0016BB23
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)110;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x170000D7 RID: 215
	// (get) Token: 0x06004AA7 RID: 19111 RVA: 0x0016D95A File Offset: 0x0016BB5A
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

	// Token: 0x06004AA8 RID: 19112 RVA: 0x0016D994 File Offset: 0x0016BB94
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

	// Token: 0x06004AA9 RID: 19113 RVA: 0x0016DA88 File Offset: 0x0016BC88
	public bool ValidDimensions(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return false;
		}
		int height = LAFAECLOMJK.height;
		return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width));
	}

	// Token: 0x06004AAA RID: 19114 RVA: 0x0016DAC4 File Offset: 0x0016BCC4
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

	// Token: 0x06004AAB RID: 19115 RVA: 0x0016DBEC File Offset: 0x0016BDEC
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

	// Token: 0x06004AAC RID: 19116 RVA: 0x0002523B File Offset: 0x0002343B
	private void MLAGEPNCCGM()
	{
	}

	// Token: 0x06004AAD RID: 19117 RVA: 0x0016DCC1 File Offset: 0x0016BEC1
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004AAE RID: 19118 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06004AB0 RID: 19120 RVA: 0x0016DCFC File Offset: 0x0016BEFC
	public void MGBOJGMOEGA()
	{
		int num = 38;
		Color[] array = new Color[num * num * num];
		float num2 = 343f / (1740f * (float)num - 1154f);
		for (int i = 1; i < num; i++)
		{
			for (int j = 1; j < num; j += 0)
			{
				for (int k = 0; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 464f * num2, (float)j * 64f * num2, (float)k * 1955f * num2, 1803f);
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

	// Token: 0x06004AB1 RID: 19121 RVA: 0x0016DDEE File Offset: 0x0016BFEE
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004AB2 RID: 19122 RVA: 0x0002523B File Offset: 0x0002343B
	private void OnValidate()
	{
	}

	// Token: 0x06004AB3 RID: 19123 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06004AB4 RID: 19124 RVA: 0x0016DE28 File Offset: 0x0016C028
	public void MPBFDNDBHBM()
	{
		int num = -80;
		Color[] array = new Color[num * num * num];
		float num2 = 768f / (1317f * (float)num - 1687f);
		for (int i = 1; i < num; i += 0)
		{
			for (int j = 1; j < num; j++)
			{
				for (int k = 1; k < num; k += 0)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 524f * num2, (float)j * 1546f * num2, (float)k * 178f * num2, 830f);
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

	// Token: 0x06004AB5 RID: 19125 RVA: 0x0016DF1C File Offset: 0x0016C11C
	public bool JLLFEBOHAIA(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return false;
		}
		int height = LAFAECLOMJK.height;
		return height == Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width));
	}

	// Token: 0x06004AB6 RID: 19126 RVA: 0x0016DF57 File Offset: 0x0016C157
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004AB7 RID: 19127 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPJHPNGNEBP()
	{
	}

	// Token: 0x06004AB8 RID: 19128 RVA: 0x0016DF8E File Offset: 0x0016C18E
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004AB9 RID: 19129 RVA: 0x0016DFC5 File Offset: 0x0016C1C5
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004ABA RID: 19130 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCCIEMBMOBA()
	{
	}

	// Token: 0x06004ABB RID: 19131 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06004ABC RID: 19132 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMPGIFBJFIK()
	{
	}

	// Token: 0x06004ABD RID: 19133 RVA: 0x0016DFFC File Offset: 0x0016C1FC
	public bool OCIOLHMEKII(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		return height != Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width)) && false;
	}

	// Token: 0x06004ABE RID: 19134 RVA: 0x0016E038 File Offset: 0x0016C238
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1903f)
			{
				this.HBJJOCHGOPH = 867f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.Convert(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.NBPKMLMCHFN.SetFloat("Encryption wasn't established: ", this.Blend);
			this.FAIFBBGFAIB().SetTexture("LocalPlayer is null or not in mActors! LocalPlayer: {0} mActors==null: {1} newID: {2}", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ(), (QualitySettings.activeColorSpace != ColorSpace.Linear) ? 0 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004ABF RID: 19135 RVA: 0x0016E110 File Offset: 0x0016C310
	public void FLLICIHANPO(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.ValidDimensions(MKEKCIPLJNC))
			{
				Debug.LogWarning("_TapMedium" + MKEKCIPLJNC.name + "list");
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.RGBA32, false);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.MPBFDNDBHBM();
		}
	}

	// Token: 0x06004AC0 RID: 19136 RVA: 0x0016DCC1 File Offset: 0x0016BEC1
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004AC1 RID: 19137 RVA: 0x0016E238 File Offset: 0x0016C438
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1875f)
			{
				this.HBJJOCHGOPH = 66f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.KLGGNGCHCEN(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Clamp;
			this.NBPKMLMCHFN.SetFloat("cmd.exe", this.Blend);
			this.GCDFNHMJMIP().SetTexture("JoinButton", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 0 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004AC2 RID: 19138 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMFGIAALGFC()
	{
	}

	// Token: 0x06004AC3 RID: 19139 RVA: 0x0016E310 File Offset: 0x0016C510
	public void GAIOPDKLKOA()
	{
		int num = 36;
		Color[] array = new Color[num * num * num];
		float num2 = 1659f / (1975f * (float)num - 892f);
		for (int i = 1; i < num; i += 0)
		{
			for (int j = 0; j < num; j += 0)
			{
				for (int k = 0; k < num; k++)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 762f * num2, (float)j * 340f * num2, (float)k * 1240f * num2, 1479f);
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

	// Token: 0x06004AC4 RID: 19140 RVA: 0x0016E404 File Offset: 0x0016C604
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1862f)
			{
				this.HBJJOCHGOPH = 562f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.FLLICIHANPO(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.LONNIJMNKFB().SetFloat("UseFinalGlassColor", this.Blend);
			this.LONNIJMNKFB().SetTexture("note.3", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 1 : 0);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004AC5 RID: 19141 RVA: 0x0002523B File Offset: 0x0002343B
	private void FCGHOKACFHL()
	{
	}

	// Token: 0x06004AC6 RID: 19142 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06004AC7 RID: 19143 RVA: 0x0002523B File Offset: 0x0002343B
	private void DCGFEIBKOBB()
	{
	}

	// Token: 0x06004AC8 RID: 19144 RVA: 0x0002523B File Offset: 0x0002343B
	private void EPEGAEGDJAM()
	{
	}

	// Token: 0x06004AC9 RID: 19145 RVA: 0x0016E4DC File Offset: 0x0016C6DC
	public void KLGGNGCHCEN(Texture2D MKEKCIPLJNC)
	{
		if (MKEKCIPLJNC)
		{
			int num = MKEKCIPLJNC.width * MKEKCIPLJNC.height;
			num = MKEKCIPLJNC.height;
			if (!this.JLLFEBOHAIA(MKEKCIPLJNC))
			{
				Debug.LogWarning("_Value" + MKEKCIPLJNC.name + "PunRespawn with Position.");
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
			this.PKINFPNDDAJ = new Texture3D(num, num, num, TextureFormat.ARGB32, true);
			this.PKINFPNDDAJ.SetPixels(array);
			this.PKINFPNDDAJ.Apply();
		}
		else
		{
			this.GAIOPDKLKOA();
		}
	}

	// Token: 0x06004ACA RID: 19146 RVA: 0x0002523B File Offset: 0x0002343B
	private void KOCPGJCINKD()
	{
	}

	// Token: 0x06004ACB RID: 19147 RVA: 0x0016DCC1 File Offset: 0x0016BEC1
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004ACC RID: 19148 RVA: 0x0016E604 File Offset: 0x0016C804
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null || !SystemInfo.supports3DTextures)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1526f)
			{
				this.HBJJOCHGOPH = 851f;
			}
			if (this.PKINFPNDDAJ == null)
			{
				this.KLGGNGCHCEN(this.LutTexture);
			}
			this.PKINFPNDDAJ.wrapMode = TextureWrapMode.Repeat;
			this.NDMPCDHADMJ().SetFloat("maps.", this.Blend);
			this.NDMPCDHADMJ().SetTexture("_SmallTex", this.PKINFPNDDAJ);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB(), (QualitySettings.activeColorSpace != ColorSpace.Gamma) ? 0 : 1);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004ACD RID: 19149 RVA: 0x0016E6DC File Offset: 0x0016C8DC
	public bool GBHBEABICCD(Texture2D LAFAECLOMJK)
	{
		if (!LAFAECLOMJK)
		{
			return true;
		}
		int height = LAFAECLOMJK.height;
		return height != Mathf.FloorToInt(Mathf.Sqrt((float)LAFAECLOMJK.width));
	}

	// Token: 0x06004ACE RID: 19150 RVA: 0x0002523B File Offset: 0x0002343B
	private void Start()
	{
	}

	// Token: 0x06004ACF RID: 19151 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06004AD0 RID: 19152 RVA: 0x0016E717 File Offset: 0x0016C917
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004AD1 RID: 19153 RVA: 0x0016E750 File Offset: 0x0016C950
	public void JLCHHOMJPLB()
	{
		int num = -114;
		Color[] array = new Color[num * num * num];
		float num2 = 1783f / (1124f * (float)num - 1307f);
		for (int i = 1; i < num; i += 0)
		{
			for (int j = 0; j < num; j++)
			{
				for (int k = 0; k < num; k += 0)
				{
					array[i + j * num + k * num * num] = new Color((float)i * 20f * num2, (float)j * 1199f * num2, (float)k * 755f * num2, 425f);
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

	// Token: 0x06004AD2 RID: 19154 RVA: 0x0016DCC1 File Offset: 0x0016BEC1
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004AD3 RID: 19155 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06004AD4 RID: 19156 RVA: 0x0002523B File Offset: 0x0002343B
	private void IHLMNAGPKDA()
	{
	}

	// Token: 0x06004AD5 RID: 19157 RVA: 0x0002523B File Offset: 0x0002343B
	private void FINDGJLEHOL()
	{
	}

	// Token: 0x040007D4 RID: 2004
	public Shader SCShader;

	// Token: 0x040007D5 RID: 2005
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040007D6 RID: 2006
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040007D7 RID: 2007
	private Material BJFKDHHMLJH;

	// Token: 0x040007D8 RID: 2008
	public Texture2D LutTexture;

	// Token: 0x040007D9 RID: 2009
	private Texture3D PKINFPNDDAJ;

	// Token: 0x040007DA RID: 2010
	[Range(0f, 1f)]
	public float Blend = 1f;

	// Token: 0x040007DB RID: 2011
	private string CHMMPJKAMPM;
}
