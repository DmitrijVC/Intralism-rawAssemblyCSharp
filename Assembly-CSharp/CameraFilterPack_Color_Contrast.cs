using System;
using UnityEngine;

// Token: 0x0200006F RID: 111
[AddComponentMenu("Camera Filter Pack/Colors/Contrast")]
[ExecuteInEditMode]
public class CameraFilterPack_Color_Contrast : MonoBehaviour
{
	// Token: 0x06001F05 RID: 7941 RVA: 0x000B8730 File Offset: 0x000B6930
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("<not connected>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001F06 RID: 7942 RVA: 0x000B8754 File Offset: 0x000B6954
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1591f)
			{
				this.HBJJOCHGOPH = 651f;
			}
			this.DBOLLHHMKKN().SetFloat("#random #epic #item", this.Contrast);
			this.LEIAFCPJMDP().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.NJDIODJNGGA().SetVector("_Params3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1419f, 231f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F07 RID: 7943 RVA: 0x000B8811 File Offset: 0x000B6A11
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find("_Blue_C");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001F08 RID: 7944 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x06001F09 RID: 7945 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06001F0A RID: 7946 RVA: 0x000B8835 File Offset: 0x000B6A35
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001F0B RID: 7947 RVA: 0x000B8852 File Offset: 0x000B6A52
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Color_Contrast");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001F0C RID: 7948 RVA: 0x000B8876 File Offset: 0x000B6A76
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001F0D RID: 7949 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x06001F0E RID: 7950 RVA: 0x000B889C File Offset: 0x000B6A9C
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 790f)
			{
				this.HBJJOCHGOPH = 36f;
			}
			this.NJDIODJNGGA().SetFloat("Cross", this.Contrast);
			this.JCPDCGIJKJD().SetFloat("/", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetVector("_Distance", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 402f, 159f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F0F RID: 7951 RVA: 0x000B8959 File Offset: 0x000B6B59
	private void DPLLKHHLDBB()
	{
		this.SCShader = Shader.Find("CameraFilterPack_eyes_vision_2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001F10 RID: 7952 RVA: 0x000B897D File Offset: 0x000B6B7D
	private Material MPENCEIGLEH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F11 RID: 7953 RVA: 0x000B89B4 File Offset: 0x000B6BB4
	private Material ADAFMBOGPLN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F12 RID: 7954 RVA: 0x000B89EC File Offset: 0x000B6BEC
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1321f)
			{
				this.HBJJOCHGOPH = 252f;
			}
			this.OLHDPICFBOF().SetFloat("CameraFilterPack/Blend2Camera_ColorBurn", this.Contrast);
			this.AELJLBOJAIL().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.IGIAPKPKGPK().SetVector("X", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1824f, 122f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JCPDCGIJKJD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F13 RID: 7955 RVA: 0x000B8AA9 File Offset: 0x000B6CA9
	private void OKLAJINHPAN()
	{
		this.SCShader = Shader.Find(" - ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001F14 RID: 7956 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06001F15 RID: 7957 RVA: 0x0002523B File Offset: 0x0002343B
	private void COGBDFKOHKK()
	{
	}

	// Token: 0x06001F16 RID: 7958 RVA: 0x000B8AD0 File Offset: 0x000B6CD0
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1401f)
			{
				this.HBJJOCHGOPH = 1126f;
			}
			this.LEIAFCPJMDP().SetFloat("Validating mod pack...", this.Contrast);
			this.MNLKBFFKHIE().SetFloat("[Right]", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetVector("]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 762f, 1380f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GBFOAHKAJEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F17 RID: 7959 RVA: 0x000B8835 File Offset: 0x000B6A35
	private void OHIJGCLBMJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001F18 RID: 7960 RVA: 0x000B8835 File Offset: 0x000B6A35
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001F19 RID: 7961 RVA: 0x000B8B8D File Offset: 0x000B6D8D
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F1B RID: 7963 RVA: 0x000B8BE2 File Offset: 0x000B6DE2
	private Material GBFOAHKAJEK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F1C RID: 7964 RVA: 0x000B8C1C File Offset: 0x000B6E1C
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1797f)
			{
				this.HBJJOCHGOPH = 545f;
			}
			this.KBOPGONOCNP().SetFloat("Mouse Y", this.Contrast);
			this.NFMGLIKNOOC().SetFloat("#random #epic #item", this.HBJJOCHGOPH);
			this.OHKGGPFGLFD().SetVector("CameraFilterPack/BlurTiltShift_V", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1432f, 1629f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F1D RID: 7965 RVA: 0x000B8CD9 File Offset: 0x000B6ED9
	private void HDMDKOKOOJC()
	{
		this.SCShader = Shader.Find(".lastCheckpoint.bgcolor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001F1E RID: 7966 RVA: 0x000B8D00 File Offset: 0x000B6F00
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1738f)
			{
				this.HBJJOCHGOPH = 1430f;
			}
			this.AELJLBOJAIL().SetFloat("_HSV", this.Contrast);
			this.LEIAFCPJMDP().SetFloat("_Size", this.HBJJOCHGOPH);
			this.LEIAFCPJMDP().SetVector("settings.shaders", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1150f, 660f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F1F RID: 7967 RVA: 0x000B8DC0 File Offset: 0x000B6FC0
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1639f)
			{
				this.HBJJOCHGOPH = 1651f;
			}
			this.HEINDEMCGIK().SetFloat("_ScreenResolution", this.Contrast);
			this.NJDIODJNGGA().SetFloat("#updateoutdatedmap", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetVector("InfoText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 755f, 891f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F20 RID: 7968 RVA: 0x000B8E7D File Offset: 0x000B707D
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F21 RID: 7969 RVA: 0x000B8EB4 File Offset: 0x000B70B4
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("english");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001F22 RID: 7970 RVA: 0x000B8ED8 File Offset: 0x000B70D8
	private Material PHGCJOPFDOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F23 RID: 7971 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001F24 RID: 7972 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKMELABKBHO()
	{
	}

	// Token: 0x06001F25 RID: 7973 RVA: 0x000B8F10 File Offset: 0x000B7110
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1795f)
			{
				this.HBJJOCHGOPH = 1931f;
			}
			this.HKHBBBFLGJH().SetFloat("Hello World, is my item a clone? [", this.Contrast);
			this.DIOAAHJDMLK().SetFloat("Apr", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetVector("Circle", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 384f, 720f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F26 RID: 7974 RVA: 0x000B8FD0 File Offset: 0x000B71D0
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 964f)
			{
				this.HBJJOCHGOPH = 295f;
			}
			this.JCPDCGIJKJD().SetFloat("Object ID. Case-Sensitive", this.Contrast);
			this.HKHBBBFLGJH().SetFloat("player.currentrank", this.HBJJOCHGOPH);
			this.JCPDCGIJKJD().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1655f, 1215f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F27 RID: 7975 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06001F28 RID: 7976 RVA: 0x000B908D File Offset: 0x000B728D
	private Material INOBFNCKFGK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F29 RID: 7977 RVA: 0x000B90C4 File Offset: 0x000B72C4
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 365f)
			{
				this.HBJJOCHGOPH = 183f;
			}
			this.HKHBBBFLGJH().SetFloat("settings.selectormapsperpage", this.Contrast);
			this.KBOPGONOCNP().SetFloat("shader.frost", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetVector("OpGetGameList()", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 384f, 216f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F2A RID: 7978 RVA: 0x000B9184 File Offset: 0x000B7384
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 453f)
			{
				this.HBJJOCHGOPH = 1962f;
			}
			this.GBFOAHKAJEK().SetFloat("#FFFFFF", this.Contrast);
			this.MICHFGAOPKM().SetFloat("SetBGColor", this.HBJJOCHGOPH);
			this.PHGCJOPFDOG().SetVector("PhotonMono", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1454f, 654f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F2B RID: 7979 RVA: 0x000B9241 File Offset: 0x000B7441
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F2C RID: 7980 RVA: 0x000B9278 File Offset: 0x000B7478
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1412f)
			{
				this.HBJJOCHGOPH = 1639f;
			}
			this.LONNIJMNKFB().SetFloat("_Value4", this.Contrast);
			this.PHGCJOPFDOG().SetFloat("Object ID. Case-Sensitive", this.HBJJOCHGOPH);
			this.INOBFNCKFGK().SetVector("steamid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 228f, 1426f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F2D RID: 7981 RVA: 0x000B9335 File Offset: 0x000B7535
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("challenges");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001F2E RID: 7982 RVA: 0x0002523B File Offset: 0x0002343B
	private void MDCFIHDPLIG()
	{
	}

	// Token: 0x06001F2F RID: 7983 RVA: 0x000B935C File Offset: 0x000B755C
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 122f)
			{
				this.HBJJOCHGOPH = 277f;
			}
			this.OHKGGPFGLFD().SetFloat("_Intensity", this.Contrast);
			this.OLHDPICFBOF().SetFloat("Tab2Content", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetVector("880078120", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1224f, 1972f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F30 RID: 7984 RVA: 0x000B9419 File Offset: 0x000B7619
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find(" not exist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001F31 RID: 7985 RVA: 0x000B8835 File Offset: 0x000B6A35
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001F32 RID: 7986 RVA: 0x000B943D File Offset: 0x000B763D
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F33 RID: 7987 RVA: 0x000B9474 File Offset: 0x000B7674
	private void LIBGAKMKHJJ()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001F34 RID: 7988 RVA: 0x000B9498 File Offset: 0x000B7698
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1058f)
			{
				this.HBJJOCHGOPH = 629f;
			}
			this.IGIAPKPKGPK().SetFloat("_Value6", this.Contrast);
			this.NMDBCDFPGOK().SetFloat("FinalScoreSmallText", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetVector("CameraFilterPack/OldFilm_Cutting2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 12f, 1906f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F35 RID: 7989 RVA: 0x000B8835 File Offset: 0x000B6A35
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001F36 RID: 7990 RVA: 0x0002523B File Offset: 0x0002343B
	private void COMNAPAAPDO()
	{
	}

	// Token: 0x06001F37 RID: 7991 RVA: 0x000B9558 File Offset: 0x000B7758
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1484f)
			{
				this.HBJJOCHGOPH = 878f;
			}
			this.IGIAPKPKGPK().SetFloat("_Value2", this.Contrast);
			this.AELJLBOJAIL().SetFloat("_FgOverlap", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetVector("_ColorRGB", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1687f, 1118f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F38 RID: 7992 RVA: 0x000B9618 File Offset: 0x000B7818
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 975f)
			{
				this.HBJJOCHGOPH = 46f;
			}
			this.OLHDPICFBOF().SetFloat("y", this.Contrast);
			this.MNLKBFFKHIE().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector("RarityImage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1573f, 1719f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F39 RID: 7993 RVA: 0x0002523B File Offset: 0x0002343B
	private void ANKIJGCGCBF()
	{
	}

	// Token: 0x06001F3A RID: 7994 RVA: 0x000B96D5 File Offset: 0x000B78D5
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("_SoftZDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001F3B RID: 7995 RVA: 0x000B96F9 File Offset: 0x000B78F9
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F3C RID: 7996 RVA: 0x000B9730 File Offset: 0x000B7930
	private void AEOLJEIDMDB()
	{
		this.SCShader = Shader.Find("UI Extensions/SoftMaskShaderText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001F3D RID: 7997 RVA: 0x000B9754 File Offset: 0x000B7954
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.NBPKMLMCHFN.SetFloat("_Contrast", this.Contrast);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F3E RID: 7998 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06001F3F RID: 7999 RVA: 0x000B9811 File Offset: 0x000B7A11
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("0.00");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001F40 RID: 8000 RVA: 0x000B9838 File Offset: 0x000B7A38
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 930f)
			{
				this.HBJJOCHGOPH = 769f;
			}
			this.NMDBCDFPGOK().SetFloat("CameraFilterPack/Gradients_NeonGradient", this.Contrast);
			this.AELJLBOJAIL().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.IGIAPKPKGPK().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 868f, 919f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F41 RID: 8001 RVA: 0x000B98F8 File Offset: 0x000B7AF8
	private void OPIBJIMIOKE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 581f)
			{
				this.HBJJOCHGOPH = 183f;
			}
			this.IGIAPKPKGPK().SetFloat("_Green_G", this.Contrast);
			this.JCPDCGIJKJD().SetFloat(".r", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1398f, 1240f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F42 RID: 8002 RVA: 0x000B99B8 File Offset: 0x000B7BB8
	private void IBBFFKEAOCE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1200f)
			{
				this.HBJJOCHGOPH = 182f;
			}
			this.PHGCJOPFDOG().SetFloat("_ScreenResolution", this.Contrast);
			this.ADAFMBOGPLN().SetFloat("local CheckCondition = function()", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetVector("Can't set Room.MaxPlayers to: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 514f, 1645f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F43 RID: 8003 RVA: 0x000B8E7D File Offset: 0x000B707D
	private Material MNLKBFFKHIE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F44 RID: 8004 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06001F45 RID: 8005 RVA: 0x0002523B File Offset: 0x0002343B
	private void CKECPMDEBLL()
	{
	}

	// Token: 0x06001F46 RID: 8006 RVA: 0x000B8835 File Offset: 0x000B6A35
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001F47 RID: 8007 RVA: 0x000B9A75 File Offset: 0x000B7C75
	private Material JCPDCGIJKJD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F48 RID: 8008 RVA: 0x000B9AAC File Offset: 0x000B7CAC
	private void MKOMIDCPCDC()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_WideScreenHorizontal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001F49 RID: 8009 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06001F4A RID: 8010 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x06001F4B RID: 8011 RVA: 0x0002523B File Offset: 0x0002343B
	private void HEBOIFKBLGD()
	{
	}

	// Token: 0x06001F4C RID: 8012 RVA: 0x000B9AD0 File Offset: 0x000B7CD0
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F4D RID: 8013 RVA: 0x000B9B07 File Offset: 0x000B7D07
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("Most likely the game became empty during the switch to GameServer.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001F4E RID: 8014 RVA: 0x000B9B2C File Offset: 0x000B7D2C
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1206f)
			{
				this.HBJJOCHGOPH = 72f;
			}
			this.HNICHJCGJOC().SetFloat(" workshop map(s)", this.Contrast);
			this.JCPDCGIJKJD().SetFloat("CameraFilterPack/3D_Myst", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetVector("offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 742f, 861f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GBFOAHKAJEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F4F RID: 8015 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06001F50 RID: 8016 RVA: 0x000B9BE9 File Offset: 0x000B7DE9
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("_Value7");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001F51 RID: 8017 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x06001F52 RID: 8018 RVA: 0x000B8835 File Offset: 0x000B6A35
	private void CIHGFHNNFEE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001F53 RID: 8019 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFMEAMBLODG()
	{
	}

	// Token: 0x06001F54 RID: 8020 RVA: 0x000B8835 File Offset: 0x000B6A35
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001F55 RID: 8021 RVA: 0x000B9C0D File Offset: 0x000B7E0D
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)76;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F56 RID: 8022 RVA: 0x000B9C44 File Offset: 0x000B7E44
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("_Alpha");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001F57 RID: 8023 RVA: 0x000B9C68 File Offset: 0x000B7E68
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F58 RID: 8024 RVA: 0x000B9CA0 File Offset: 0x000B7EA0
	private void OPKNFOGMGII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1515f)
			{
				this.HBJJOCHGOPH = 1409f;
			}
			this.LONNIJMNKFB().SetFloat("Circle", this.Contrast);
			this.JCPDCGIJKJD().SetFloat("_Value5", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetVector("CameraFilterPack/Light_Rainbow", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1493f, 1902f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F59 RID: 8025 RVA: 0x000B9D5D File Offset: 0x000B7F5D
	private void GLEJGFLCLPJ()
	{
		this.SCShader = Shader.Find("_MainTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001F5A RID: 8026 RVA: 0x000B8835 File Offset: 0x000B6A35
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001F5B RID: 8027 RVA: 0x000B8835 File Offset: 0x000B6A35
	private void LAMEHAHJKMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001F5C RID: 8028 RVA: 0x000B9474 File Offset: 0x000B7674
	private void FEKECCBFGMI()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001F5D RID: 8029 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x06001F5E RID: 8030 RVA: 0x000B9D81 File Offset: 0x000B7F81
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("Remove Environment Object");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001F5F RID: 8031 RVA: 0x000B8835 File Offset: 0x000B6A35
	private void HCDBNAKGDJC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001F60 RID: 8032 RVA: 0x000B9DA5 File Offset: 0x000B7FA5
	private Material OHKGGPFGLFD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F61 RID: 8033 RVA: 0x000B9DDC File Offset: 0x000B7FDC
	private void DKEHGPPOKEA()
	{
		this.SCShader = Shader.Find("?page=addtip");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001F62 RID: 8034 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBFJAOINHMK()
	{
	}

	// Token: 0x06001F63 RID: 8035 RVA: 0x000B9E00 File Offset: 0x000B8000
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("CameraFilterPack_AAA_BloodOnScreen1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001F64 RID: 8036 RVA: 0x0002523B File Offset: 0x0002343B
	private void BFGIMALGMAJ()
	{
	}

	// Token: 0x06001F65 RID: 8037 RVA: 0x000B9E24 File Offset: 0x000B8024
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find("Bad parameters for setint! Use <key> <value>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001F66 RID: 8038 RVA: 0x000B9E48 File Offset: 0x000B8048
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("_Visualize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001F67 RID: 8039 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x06001F68 RID: 8040 RVA: 0x000B8835 File Offset: 0x000B6A35
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001F69 RID: 8041 RVA: 0x000B9E6C File Offset: 0x000B806C
	private Material LEIAFCPJMDP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)73;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F6A RID: 8042 RVA: 0x000B9EA4 File Offset: 0x000B80A4
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 488f)
			{
				this.HBJJOCHGOPH = 138f;
			}
			this.NFMGLIKNOOC().SetFloat("_Color", this.Contrast);
			this.HKIMAANBGMJ().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.HKIMAANBGMJ().SetVector("_InvRenderTargetSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1855f, 754f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F6B RID: 8043 RVA: 0x000B9F61 File Offset: 0x000B8161
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F6C RID: 8044 RVA: 0x000B9F98 File Offset: 0x000B8198
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F6D RID: 8045 RVA: 0x000B9FD0 File Offset: 0x000B81D0
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1218f)
			{
				this.HBJJOCHGOPH = 425f;
			}
			this.NJDIODJNGGA().SetFloat("' was created: ", this.Contrast);
			this.DIOAAHJDMLK().SetFloat(".lastCheckpoint.penaltyScore", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector("_Red_B", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 370f, 1744f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F6E RID: 8046 RVA: 0x000BA08D File Offset: 0x000B828D
	private Material NMDBCDFPGOK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F6F RID: 8047 RVA: 0x000BA0C4 File Offset: 0x000B82C4
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F70 RID: 8048 RVA: 0x000BA0FC File Offset: 0x000B82FC
	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1172f)
			{
				this.HBJJOCHGOPH = 481f;
			}
			this.AELJLBOJAIL().SetFloat("NameInfoText", this.Contrast);
			this.NMDBCDFPGOK().SetFloat("resetach21", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1140f, 595f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F71 RID: 8049 RVA: 0x000BA1BC File Offset: 0x000B83BC
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1318f)
			{
				this.HBJJOCHGOPH = 620f;
			}
			this.PHGCJOPFDOG().SetFloat("_MainTex2", this.Contrast);
			this.NMDBCDFPGOK().SetFloat("_Offsets", this.HBJJOCHGOPH);
			this.OHKGGPFGLFD().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 268f, 1718f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F72 RID: 8050 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06001F73 RID: 8051 RVA: 0x000BA27C File Offset: 0x000B847C
	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1405f)
			{
				this.HBJJOCHGOPH = 826f;
			}
			this.IGIAPKPKGPK().SetFloat("_Bloom2", this.Contrast);
			this.DKKBFFHBHJE().SetFloat("CameraFilterPack/TV_WideScreenVertical", this.HBJJOCHGOPH);
			this.OHKGGPFGLFD().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 296f, 266f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F74 RID: 8052 RVA: 0x000BA339 File Offset: 0x000B8539
	private void FMNPFCHBLJF()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001F75 RID: 8053 RVA: 0x000BA360 File Offset: 0x000B8560
	private void OPHBLNNGFKG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 145f)
			{
				this.HBJJOCHGOPH = 1505f;
			}
			this.INOBFNCKFGK().SetFloat("Texture2", this.Contrast);
			this.KBOPGONOCNP().SetFloat("[Left]", this.HBJJOCHGOPH);
			this.ADAFMBOGPLN().SetVector("New level loaded. Removed ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1378f, 320f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F76 RID: 8054 RVA: 0x000BA41D File Offset: 0x000B861D
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F77 RID: 8055 RVA: 0x000B8835 File Offset: 0x000B6A35
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001F78 RID: 8056 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x17000055 RID: 85
	// (get) Token: 0x06001F79 RID: 8057 RVA: 0x000BA454 File Offset: 0x000B8654
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

	// Token: 0x06001F7A RID: 8058 RVA: 0x000BA48B File Offset: 0x000B868B
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001F7B RID: 8059 RVA: 0x000BA4B0 File Offset: 0x000B86B0
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 637f)
			{
				this.HBJJOCHGOPH = 503f;
			}
			this.MPENCEIGLEH().SetFloat("VIGNETTE_CLASSIC", this.Contrast);
			this.AELJLBOJAIL().SetFloat("visible", this.HBJJOCHGOPH);
			this.IGIAPKPKGPK().SetVector(" != ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 51f, 312f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F7C RID: 8060 RVA: 0x000BA56D File Offset: 0x000B876D
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F7D RID: 8061 RVA: 0x000BA5A4 File Offset: 0x000B87A4
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Gradients_FireGradient");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001F7E RID: 8062 RVA: 0x000BA5C8 File Offset: 0x000B87C8
	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1166f)
			{
				this.HBJJOCHGOPH = 1378f;
			}
			this.NFMGLIKNOOC().SetFloat("HelpMenu", this.Contrast);
			this.AELJLBOJAIL().SetFloat("_DistCenterScale", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1878f, 833f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F7F RID: 8063 RVA: 0x000BA688 File Offset: 0x000B8888
	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 985f)
			{
				this.HBJJOCHGOPH = 291f;
			}
			this.PHGCJOPFDOG().SetFloat("#no", this.Contrast);
			this.JCPDCGIJKJD().SetFloat("Fade", this.HBJJOCHGOPH);
			this.NJDIODJNGGA().SetVector("VisionBlur", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1765f, 134f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OHKGGPFGLFD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F80 RID: 8064 RVA: 0x000B908D File Offset: 0x000B728D
	private Material DIOAAHJDMLK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F81 RID: 8065 RVA: 0x000BA748 File Offset: 0x000B8948
	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 6f)
			{
				this.HBJJOCHGOPH = 68f;
			}
			this.HEINDEMCGIK().SetFloat("Object ID. Case-Sensitive", this.Contrast);
			this.HKIMAANBGMJ().SetFloat("#close", this.HBJJOCHGOPH);
			this.ADAFMBOGPLN().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1973f, 779f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NMDBCDFPGOK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F82 RID: 8066 RVA: 0x000BA805 File Offset: 0x000B8A05
	private void FDNONDCGGCG()
	{
		this.SCShader = Shader.Find("OneHand");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001F83 RID: 8067 RVA: 0x000BA829 File Offset: 0x000B8A29
	private void NEFHGMNAPEP()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Hue");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001F84 RID: 8068 RVA: 0x000B8835 File Offset: 0x000B6A35
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001F85 RID: 8069 RVA: 0x000BA84D File Offset: 0x000B8A4D
	private void NDBPCNICGLC()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001F86 RID: 8070 RVA: 0x000BA871 File Offset: 0x000B8A71
	private Material NJDIODJNGGA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F87 RID: 8071 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x06001F88 RID: 8072 RVA: 0x000BA8A8 File Offset: 0x000B8AA8
	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 120f)
			{
				this.HBJJOCHGOPH = 1263f;
			}
			this.HKIMAANBGMJ().SetFloat("#", this.Contrast);
			this.HNICHJCGJOC().SetFloat("Type of observed is unknown when receiving.", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetVector("OnClick", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 708f, 224f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F89 RID: 8073 RVA: 0x000B8835 File Offset: 0x000B6A35
	private void DKPBBJINKMG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001F8A RID: 8074 RVA: 0x000B8835 File Offset: 0x000B6A35
	private void FAMLCFNDGNI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001F8B RID: 8075 RVA: 0x000B8835 File Offset: 0x000B6A35
	private void ONPFGCEFMML()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001F8C RID: 8076 RVA: 0x000B8835 File Offset: 0x000B6A35
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001F8D RID: 8077 RVA: 0x000BA965 File Offset: 0x000B8B65
	private Material ELBMIEOIABA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F8E RID: 8078 RVA: 0x000B8835 File Offset: 0x000B6A35
	private void HAHJJPLPOKB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001F8F RID: 8079 RVA: 0x000B8835 File Offset: 0x000B6A35
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001F90 RID: 8080 RVA: 0x000BA99C File Offset: 0x000B8B9C
	private void COOHIILCOCO()
	{
		this.SCShader = Shader.Find("Texture2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001F91 RID: 8081 RVA: 0x000BA9C0 File Offset: 0x000B8BC0
	private Material HKIMAANBGMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000424 RID: 1060
	public Shader SCShader;

	// Token: 0x04000425 RID: 1061
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000426 RID: 1062
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000427 RID: 1063
	private Material BJFKDHHMLJH;

	// Token: 0x04000428 RID: 1064
	[Range(0f, 10f)]
	public float Contrast = 4.5f;
}
