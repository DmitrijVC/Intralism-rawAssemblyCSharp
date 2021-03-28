using System;
using UnityEngine;

// Token: 0x020000BF RID: 191
[AddComponentMenu("Camera Filter Pack/FX/Ascii")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_Ascii : MonoBehaviour
{
	// Token: 0x060039D9 RID: 14809 RVA: 0x00124C5F File Offset: 0x00122E5F
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("GameScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060039DA RID: 14810 RVA: 0x00124C83 File Offset: 0x00122E83
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060039DB RID: 14811 RVA: 0x00124CA0 File Offset: 0x00122EA0
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1258f)
			{
				this.HBJJOCHGOPH = 1124f;
			}
			this.DNLMFEGJJDD().SetFloat("Edited event", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("Can't do manual instantiation without PhotonView component.", this.Value);
			this.FAIFBBGFAIB().SetFloat("#random #rare #item", this.Fade);
			this.DNLMFEGJJDD().SetVector(" takes from: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 865f, 297f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060039DC RID: 14812 RVA: 0x00124D74 File Offset: 0x00122F74
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 654f)
			{
				this.HBJJOCHGOPH = 183f;
			}
			this.HFBJAOFLCJI().SetFloat("System.Single", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("Instrumental", this.Value);
			this.FAIFBBGFAIB().SetFloat("_ScreenResolution", this.Fade);
			this.HFBJAOFLCJI().SetVector("LT", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1862f, 1432f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060039DD RID: 14813 RVA: 0x00124E48 File Offset: 0x00123048
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1903f)
			{
				this.HBJJOCHGOPH = 424f;
			}
			this.KBOPGONOCNP().SetFloat("[PlayerController] ", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("restrictions", this.Value);
			this.KAFBNOBOIAJ().SetFloat("_DistortionLevel", this.Fade);
			this.FAIFBBGFAIB().SetVector("Joystick1Button5", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1728f, 1842f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060039DF RID: 14815 RVA: 0x00124C83 File Offset: 0x00122E83
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060039E0 RID: 14816 RVA: 0x00124F44 File Offset: 0x00123144
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("Vertical");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060039E1 RID: 14817 RVA: 0x00124F68 File Offset: 0x00123168
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060039E2 RID: 14818 RVA: 0x00124F9F File Offset: 0x0012319F
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060039E3 RID: 14819 RVA: 0x00124C83 File Offset: 0x00122E83
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060039E4 RID: 14820 RVA: 0x00124FD8 File Offset: 0x001231D8
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
			this.NBPKMLMCHFN.SetFloat("Value", this.Value);
			this.NBPKMLMCHFN.SetFloat("Fade", this.Fade);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060039E5 RID: 14821 RVA: 0x001250AC File Offset: 0x001232AC
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 572f)
			{
				this.HBJJOCHGOPH = 492f;
			}
			this.FAIFBBGFAIB().SetFloat("SaveGameName is null or empty!", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("AudioClip", this.Value);
			this.KAFBNOBOIAJ().SetFloat("[ResourcesManager] Unloading data resources", this.Fade);
			this.DEFBJOCJJKF().SetVector("STICKRHOR", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 893f, 1332f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060039E6 RID: 14822 RVA: 0x0012517F File Offset: 0x0012337F
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Ascii");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060039E7 RID: 14823 RVA: 0x001251A4 File Offset: 0x001233A4
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1586f)
			{
				this.HBJJOCHGOPH = 1293f;
			}
			this.NBPKMLMCHFN.SetFloat("[PlayerBase] Reset", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("#close", this.Value);
			this.HFBJAOFLCJI().SetFloat("_Value2", this.Fade);
			this.DEFBJOCJJKF().SetVector("BestScoreText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 187f, 973f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060039E8 RID: 14824 RVA: 0x00125277 File Offset: 0x00123477
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("ColorBlood");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060039E9 RID: 14825 RVA: 0x0012529B File Offset: 0x0012349B
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060039EA RID: 14826 RVA: 0x001252D4 File Offset: 0x001234D4
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1610f)
			{
				this.HBJJOCHGOPH = 1555f;
			}
			this.DEFBJOCJJKF().SetFloat("BitsData", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("#yes", this.Value);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Fade);
			this.DEFBJOCJJKF().SetVector("achievements.21.progress", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 780f, 1258f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060039EB RID: 14827 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x060039EC RID: 14828 RVA: 0x00124C83 File Offset: 0x00122E83
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060039ED RID: 14829 RVA: 0x001253A7 File Offset: 0x001235A7
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x170000A5 RID: 165
	// (get) Token: 0x060039EE RID: 14830 RVA: 0x001253DE File Offset: 0x001235DE
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

	// Token: 0x060039EF RID: 14831 RVA: 0x00125415 File Offset: 0x00123615
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060039F0 RID: 14832 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x060039F1 RID: 14833 RVA: 0x0012544C File Offset: 0x0012364C
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060039F2 RID: 14834 RVA: 0x00125483 File Offset: 0x00123683
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060039F3 RID: 14835 RVA: 0x001254A7 File Offset: 0x001236A7
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("Waiting to start");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060039F4 RID: 14836 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x060039F5 RID: 14837 RVA: 0x00124C83 File Offset: 0x00122E83
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060039F6 RID: 14838 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060039F7 RID: 14839 RVA: 0x00124C83 File Offset: 0x00122E83
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060039F8 RID: 14840 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x060039F9 RID: 14841 RVA: 0x001254CC File Offset: 0x001236CC
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 950f)
			{
				this.HBJJOCHGOPH = 1748f;
			}
			this.HFBJAOFLCJI().SetFloat("curScn", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("\n\n• ", this.Value);
			this.KBOPGONOCNP().SetFloat("_BlurPass", this.Fade);
			this.HFBJAOFLCJI().SetVector("Case-Sensitive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1666f, 1486f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060039FA RID: 14842 RVA: 0x001255A0 File Offset: 0x001237A0
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 49f)
			{
				this.HBJJOCHGOPH = 1118f;
			}
			this.FAIFBBGFAIB().SetFloat("CameraFilterPack/TV_ARCADE", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("float,50", this.Value);
			this.DNLMFEGJJDD().SetFloat("ArcsNoHitsoundTimeDelaySlider", this.Fade);
			this.KAFBNOBOIAJ().SetVector("LevelConfigButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 548f, 1455f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060039FB RID: 14843 RVA: 0x00124C83 File Offset: 0x00122E83
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x04000653 RID: 1619
	public Shader SCShader;

	// Token: 0x04000654 RID: 1620
	[Range(0f, 2f)]
	public float Value = 1f;

	// Token: 0x04000655 RID: 1621
	[Range(0.01f, 1f)]
	public float Fade = 1f;

	// Token: 0x04000656 RID: 1622
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000657 RID: 1623
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000658 RID: 1624
	private Material BJFKDHHMLJH;
}
