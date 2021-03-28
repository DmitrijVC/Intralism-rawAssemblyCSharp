using System;
using UnityEngine;

// Token: 0x0200011F RID: 287
[AddComponentMenu("Camera Filter Pack/TV/Planet Mars")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_PlanetMars : MonoBehaviour
{
	// Token: 0x06005A37 RID: 23095 RVA: 0x001BDAC0 File Offset: 0x001BBCC0
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A38 RID: 23096 RVA: 0x001BDAF8 File Offset: 0x001BBCF8
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1110f)
			{
				this.HBJJOCHGOPH = 1856f;
			}
			this.BAGICADFBAB().SetFloat(" not exist", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("IntraSig", this.Distortion);
			this.HHIFMIPPMPF().SetFloat("[SaveSystem] Init from ", this.Fade);
			this.CIAFLBFJLEJ().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 503f, 554f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFCPHFMKHII());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A39 RID: 23097 RVA: 0x001BDBCB File Offset: 0x001BBDCB
	private void PMPKMGKAAJH()
	{
		this.SCShader = Shader.Find("ItemNameText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005A3A RID: 23098 RVA: 0x001BDBF0 File Offset: 0x001BBDF0
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1541f)
			{
				this.HBJJOCHGOPH = 1339f;
			}
			this.NFMGLIKNOOC().SetFloat("Sequence contains no elements", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("RedoButton", this.Distortion);
			this.CIAFLBFJLEJ().SetFloat(".icon", this.Fade);
			this.CECJJMKLEAK().SetVector("settings_bindings_controller_type", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1880f, 1404f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000104 RID: 260
	// (get) Token: 0x06005A3B RID: 23099 RVA: 0x001BDCC3 File Offset: 0x001BBEC3
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

	// Token: 0x06005A3C RID: 23100 RVA: 0x001BDCFA File Offset: 0x001BBEFA
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A3D RID: 23101 RVA: 0x001BDD17 File Offset: 0x001BBF17
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A3E RID: 23102 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x06005A3F RID: 23103 RVA: 0x001BDCFA File Offset: 0x001BBEFA
	private void BDBJEDIOKBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A40 RID: 23104 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x06005A41 RID: 23105 RVA: 0x001BDD50 File Offset: 0x001BBF50
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
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("Fade", this.Fade);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A42 RID: 23106 RVA: 0x001BDE24 File Offset: 0x001BC024
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 629f)
			{
				this.HBJJOCHGOPH = 1591f;
			}
			this.LPDOGGFOBDH().SetFloat("BitsData", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("_Value4", this.Distortion);
			this.OIIDAKBILMI().SetFloat("MapConfig", this.Fade);
			this.CECJJMKLEAK().SetVector("mapselector.filter.favoriteonly", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 437f, 64f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A43 RID: 23107 RVA: 0x001BDEF7 File Offset: 0x001BC0F7
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005A44 RID: 23108 RVA: 0x001BDF1B File Offset: 0x001BC11B
	private Material MHBAIEKFBIJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A45 RID: 23109 RVA: 0x001BDF52 File Offset: 0x001BC152
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-92);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A46 RID: 23110 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06005A47 RID: 23111 RVA: 0x001BDCFA File Offset: 0x001BBEFA
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A48 RID: 23112 RVA: 0x001BDCFA File Offset: 0x001BBEFA
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A49 RID: 23113 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06005A4A RID: 23114 RVA: 0x001BDF89 File Offset: 0x001BC189
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A4B RID: 23115 RVA: 0x001BDFC0 File Offset: 0x001BC1C0
	private void AEDDNDHCLNN()
	{
		this.SCShader = Shader.Find("PhotonServerSettings");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005A4C RID: 23116 RVA: 0x001BDFE4 File Offset: 0x001BC1E4
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1670f)
			{
				this.HBJJOCHGOPH = 1771f;
			}
			this.MJJIEHANFJA().SetFloat("skin.", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("_TimeX", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.Fade);
			this.HNICHJCGJOC().SetVector("Tab1Content", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1376f, 1580f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A4D RID: 23117 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x06005A4E RID: 23118 RVA: 0x001BDCFA File Offset: 0x001BBEFA
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A4F RID: 23119 RVA: 0x001BE0B7 File Offset: 0x001BC2B7
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-126);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A50 RID: 23120 RVA: 0x001BE0F0 File Offset: 0x001BC2F0
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 487f)
			{
				this.HBJJOCHGOPH = 1093f;
			}
			this.HNICHJCGJOC().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat("UI Extensions/UISoftAdditive", this.Distortion);
			this.IONHGBPGCHK().SetFloat("MenuScene", this.Fade);
			this.MHBAIEKFBIJ().SetVector("event", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1017f, 545f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A51 RID: 23121 RVA: 0x001BE1C4 File Offset: 0x001BC3C4
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 733f)
			{
				this.HBJJOCHGOPH = 654f;
			}
			this.MJJIEHANFJA().SetFloat("[ItemsHandler] Loading ", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("_ScreenResolution", this.Distortion);
			this.MHBAIEKFBIJ().SetFloat("maps.", this.Fade);
			this.LPDOGGFOBDH().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 607f, 344f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A52 RID: 23122 RVA: 0x001BE297 File Offset: 0x001BC497
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005A53 RID: 23123 RVA: 0x001BE2BB File Offset: 0x001BC4BB
	private void JECMJNFGBGC()
	{
		this.SCShader = Shader.Find(".");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005A54 RID: 23124 RVA: 0x001BE2DF File Offset: 0x001BC4DF
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A55 RID: 23125 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06005A56 RID: 23126 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06005A57 RID: 23127 RVA: 0x001BE316 File Offset: 0x001BC516
	private void JFJLGJEPEAA()
	{
		this.SCShader = Shader.Find("]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005A58 RID: 23128 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06005A59 RID: 23129 RVA: 0x001BDCFA File Offset: 0x001BBEFA
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A5A RID: 23130 RVA: 0x001BDCFA File Offset: 0x001BBEFA
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A5B RID: 23131 RVA: 0x001BE33C File Offset: 0x001BC53C
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 434f)
			{
				this.HBJJOCHGOPH = 1903f;
			}
			this.HFBJAOFLCJI().SetFloat("Editor/", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("Fade", this.Distortion);
			this.OIIDAKBILMI().SetFloat("/../", this.Fade);
			this.CIAFLBFJLEJ().SetVector("Set Particles Gravity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 605f, 1297f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A5C RID: 23132 RVA: 0x001BDCFA File Offset: 0x001BBEFA
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A5D RID: 23133 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x06005A5E RID: 23134 RVA: 0x001BE410 File Offset: 0x001BC610
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 206f)
			{
				this.HBJJOCHGOPH = 416f;
			}
			this.NBPKMLMCHFN.SetFloat("menu.playedpage", this.HBJJOCHGOPH);
			this.CECJJMKLEAK().SetFloat("OK", this.Distortion);
			this.HNICHJCGJOC().SetFloat("#ok", this.Fade);
			this.MHBAIEKFBIJ().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1597f, 1279f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A5F RID: 23135 RVA: 0x001BE4E3 File Offset: 0x001BC6E3
	private void JONGNKNLLND()
	{
		this.SCShader = Shader.Find("RarityImage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005A60 RID: 23136 RVA: 0x001BE508 File Offset: 0x001BC708
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 37f)
			{
				this.HBJJOCHGOPH = 902f;
			}
			this.OIIDAKBILMI().SetFloat("A", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("_Offsets", this.Distortion);
			this.GJHLADDCMFF().SetFloat("Preparing configuration", this.Fade);
			this.LPDOGGFOBDH().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 768f, 304f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A61 RID: 23137 RVA: 0x001BDCC3 File Offset: 0x001BBEC3
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A62 RID: 23138 RVA: 0x001BE5DB File Offset: 0x001BC7DB
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A63 RID: 23139 RVA: 0x001BDCFA File Offset: 0x001BBEFA
	private void DKPBBJINKMG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A64 RID: 23140 RVA: 0x001BE612 File Offset: 0x001BC812
	private Material MJJIEHANFJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A65 RID: 23141 RVA: 0x001BDCFA File Offset: 0x001BBEFA
	private void HOMNAHDDNHJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A66 RID: 23142 RVA: 0x001BE649 File Offset: 0x001BC849
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find("_BorderSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005A67 RID: 23143 RVA: 0x001BDCFA File Offset: 0x001BBEFA
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A68 RID: 23144 RVA: 0x001BDCFA File Offset: 0x001BBEFA
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A69 RID: 23145 RVA: 0x001BE670 File Offset: 0x001BC870
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1898f)
			{
				this.HBJJOCHGOPH = 1536f;
			}
			this.LPDOGGFOBDH().SetFloat("D-Pad Up", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("HiddenToggle", this.Distortion);
			this.IONHGBPGCHK().SetFloat("_TimeX", this.Fade);
			this.NBPKMLMCHFN.SetVector("#accuracy", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1916f, 117f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A6A RID: 23146 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDBBPKIFNJ()
	{
	}

	// Token: 0x06005A6B RID: 23147 RVA: 0x001BDCFA File Offset: 0x001BBEFA
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A6C RID: 23148 RVA: 0x001BE744 File Offset: 0x001BC944
	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 419f)
			{
				this.HBJJOCHGOPH = 228f;
			}
			this.BAGICADFBAB().SetFloat("#no", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("_TimeX", this.Distortion);
			this.OIIDAKBILMI().SetFloat("_ScreenResolution", this.Fade);
			this.NFKFAAHHLLM().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 63f, 591f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A6D RID: 23149 RVA: 0x001BE817 File Offset: 0x001BCA17
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_PlanetMars");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005A6E RID: 23150 RVA: 0x001BE83B File Offset: 0x001BCA3B
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("_DotSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005A6F RID: 23151 RVA: 0x001BE860 File Offset: 0x001BCA60
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1449f)
			{
				this.HBJJOCHGOPH = 985f;
			}
			this.CECJJMKLEAK().SetFloat("/", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("GroupNameText", this.Distortion);
			this.CECJJMKLEAK().SetFloat("UseFinalGlassColor", this.Fade);
			this.GJHLADDCMFF().SetVector("In Main Menu", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 613f, 59f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A70 RID: 23152 RVA: 0x001BE933 File Offset: 0x001BCB33
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("Joystick1Button9");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005A71 RID: 23153 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x06005A72 RID: 23154 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06005A73 RID: 23155 RVA: 0x001BE957 File Offset: 0x001BCB57
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A74 RID: 23156 RVA: 0x001BE98E File Offset: 0x001BCB8E
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("challenges.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005A75 RID: 23157 RVA: 0x001BE9B4 File Offset: 0x001BCBB4
	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1962f)
			{
				this.HBJJOCHGOPH = 1039f;
			}
			this.CIAFLBFJLEJ().SetFloat("{}", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("misses", this.Distortion);
			this.OIIDAKBILMI().SetFloat("Joined room ", this.Fade);
			this.LPDOGGFOBDH().SetVector("VisionBlur", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1902f, 337f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A76 RID: 23158 RVA: 0x001BEA88 File Offset: 0x001BCC88
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 520f)
			{
				this.HBJJOCHGOPH = 57f;
			}
			this.CIAFLBFJLEJ().SetFloat(", our prefix is ", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetFloat("CameraFilterPack/Vision_Hell_Blood", this.Distortion);
			this.GJHLADDCMFF().SetFloat(" ", this.Fade);
			this.HHIFMIPPMPF().SetVector("OPEN FILE", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 426f, 567f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A77 RID: 23159 RVA: 0x001BEB5B File Offset: 0x001BCD5B
	private Material CECJJMKLEAK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A78 RID: 23160 RVA: 0x001BEB92 File Offset: 0x001BCD92
	private void FDNONDCGGCG()
	{
		this.SCShader = Shader.Find("SAVE");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005A79 RID: 23161 RVA: 0x001BEBB6 File Offset: 0x001BCDB6
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("Creating awesome maps");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005A7A RID: 23162 RVA: 0x001BEBDA File Offset: 0x001BCDDA
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("_SunColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005A7B RID: 23163 RVA: 0x001BEBFE File Offset: 0x001BCDFE
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("_FrustumCornersWS");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005A7C RID: 23164 RVA: 0x001BEC22 File Offset: 0x001BCE22
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A7D RID: 23165 RVA: 0x001BEC5C File Offset: 0x001BCE5C
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 456f)
			{
				this.HBJJOCHGOPH = 1300f;
			}
			this.MHBAIEKFBIJ().SetFloat("Image", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("_ScreenResolution", this.Distortion);
			this.OGMEGHKECAH().SetFloat("[PlayerBase] New highscore", this.Fade);
			this.CFCPHFMKHII().SetVector("inventory.selected.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 637f, 1906f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A7E RID: 23166 RVA: 0x001BED2F File Offset: 0x001BCF2F
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A7F RID: 23167 RVA: 0x001BED66 File Offset: 0x001BCF66
	private void COOHIILCOCO()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005A80 RID: 23168 RVA: 0x001BDCFA File Offset: 0x001BBEFA
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A81 RID: 23169 RVA: 0x001BED8A File Offset: 0x001BCF8A
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("SetSatelliteRadius");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005A82 RID: 23170 RVA: 0x001BEDAE File Offset: 0x001BCFAE
	private void MDNHCLKNCLE()
	{
		this.SCShader = Shader.Find("CameraFilterPack/3D_Inverse");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005A83 RID: 23171 RVA: 0x001BEDD2 File Offset: 0x001BCFD2
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A84 RID: 23172 RVA: 0x001BEE09 File Offset: 0x001BD009
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("menu.selectedplaymode");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005A85 RID: 23173 RVA: 0x001BEE2D File Offset: 0x001BD02D
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)123;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A86 RID: 23174 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x06005A87 RID: 23175 RVA: 0x001BEE64 File Offset: 0x001BD064
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1808f)
			{
				this.HBJJOCHGOPH = 1109f;
			}
			this.GHHPOGODBHB().SetFloat("yyyy-MM-dd HH:mm:ss", this.HBJJOCHGOPH);
			this.CIAFLBFJLEJ().SetFloat(".lastCheckpoint.powerupsScore", this.Distortion);
			this.GHHPOGODBHB().SetFloat("PS Home", this.Fade);
			this.NFKFAAHHLLM().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 66f, 1363f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A88 RID: 23176 RVA: 0x001BDCFA File Offset: 0x001BBEFA
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A89 RID: 23177 RVA: 0x001BEF37 File Offset: 0x001BD137
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("Rock");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005A8A RID: 23178 RVA: 0x001BEF5B File Offset: 0x001BD15B
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("_SecondTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005A8B RID: 23179 RVA: 0x001BDCFA File Offset: 0x001BBEFA
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A8C RID: 23180 RVA: 0x001BEF7F File Offset: 0x001BD17F
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("settings.shaders");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005A8D RID: 23181 RVA: 0x0002523B File Offset: 0x0002343B
	private void MBLDJEFBLFL()
	{
	}

	// Token: 0x06005A8E RID: 23182 RVA: 0x001BEFA4 File Offset: 0x001BD1A4
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 169f)
			{
				this.HBJJOCHGOPH = 1991f;
			}
			this.CECJJMKLEAK().SetFloat("[RanksSystem] Init", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("PlayMusic", this.Distortion);
			this.HEINDEMCGIK().SetFloat("-help", this.Fade);
			this.OIIDAKBILMI().SetVector("_SecondTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1696f, 1339f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A8F RID: 23183 RVA: 0x001BF077 File Offset: 0x001BD277
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005A90 RID: 23184 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x06005A91 RID: 23185 RVA: 0x001BDCFA File Offset: 0x001BBEFA
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A92 RID: 23186 RVA: 0x001BDCFA File Offset: 0x001BBEFA
	private void FMHOHGEAIEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A93 RID: 23187 RVA: 0x001BF09B File Offset: 0x001BD29B
	private Material GHHPOGODBHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A94 RID: 23188 RVA: 0x001BF0D2 File Offset: 0x001BD2D2
	private Material CFCPHFMKHII()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005A96 RID: 23190 RVA: 0x001BF132 File Offset: 0x001BD332
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("x");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005A97 RID: 23191 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x06005A98 RID: 23192 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06005A99 RID: 23193 RVA: 0x001BDCFA File Offset: 0x001BBEFA
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A9A RID: 23194 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005A9B RID: 23195 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x06005A9C RID: 23196 RVA: 0x001BDCFA File Offset: 0x001BBEFA
	private void ONPFGCEFMML()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A9D RID: 23197 RVA: 0x001BF158 File Offset: 0x001BD358
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1038f)
			{
				this.HBJJOCHGOPH = 784f;
			}
			this.LPDOGGFOBDH().SetFloat("ConfigVersionSlider", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("ERROR: mod directory not found!", this.Distortion);
			this.HNICHJCGJOC().SetFloat("88f00bdf0ad61b16b803971ebe071962", this.Fade);
			this.GHHPOGODBHB().SetVector("ItemsUploader", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 972f, 1923f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005A9E RID: 23198 RVA: 0x001BDCFA File Offset: 0x001BBEFA
	private void NNPBKKBFDHH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005A9F RID: 23199 RVA: 0x001BF22B File Offset: 0x001BD42B
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("CameraFilterPack_Paper1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005AA0 RID: 23200 RVA: 0x001BDCFA File Offset: 0x001BBEFA
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005AA1 RID: 23201 RVA: 0x001BF24F File Offset: 0x001BD44F
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005AA2 RID: 23202 RVA: 0x001BF288 File Offset: 0x001BD488
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1103f)
			{
				this.HBJJOCHGOPH = 1303f;
			}
			this.CIAFLBFJLEJ().SetFloat("_FgOverlap", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("#close", this.Distortion);
			this.HFBJAOFLCJI().SetFloat("_MaxRadiusOrKInPaper", this.Fade);
			this.LPDOGGFOBDH().SetVector("CameraFilterPack/Colors_DarkColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1928f, 260f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005AA3 RID: 23203 RVA: 0x001BDCFA File Offset: 0x001BBEFA
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005AA4 RID: 23204 RVA: 0x001BF35B File Offset: 0x001BD55B
	private void NDBPCNICGLC()
	{
		this.SCShader = Shader.Find("STICKLHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005AA5 RID: 23205 RVA: 0x001BF37F File Offset: 0x001BD57F
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005AA6 RID: 23206 RVA: 0x001BF3B8 File Offset: 0x001BD5B8
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 577f)
			{
				this.HBJJOCHGOPH = 590f;
			}
			this.MJJIEHANFJA().SetFloat("CameraFilterPack/Blend2Camera_Multiply", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("ControllerRightY", this.Distortion);
			this.NFMGLIKNOOC().SetFloat("ShadersToggle", this.Fade);
			this.NFMGLIKNOOC().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 920f, 80f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005AA7 RID: 23207 RVA: 0x001BF48B File Offset: 0x001BD68B
	private void LFAFJKJAEEL()
	{
		this.SCShader = Shader.Find("_ForceYSwap");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005AA8 RID: 23208 RVA: 0x001BF4AF File Offset: 0x001BD6AF
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("inventory.selected.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005AA9 RID: 23209 RVA: 0x001BF4D4 File Offset: 0x001BD6D4
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1513f)
			{
				this.HBJJOCHGOPH = 1050f;
			}
			this.GHHPOGODBHB().SetFloat("_EdgeWeight", this.HBJJOCHGOPH);
			this.MJJIEHANFJA().SetFloat("[PlayerBase] SetPlayerDistance error: ", this.Distortion);
			this.OGMEGHKECAH().SetFloat("CameraFilterPack/Atmosphere_Fog", this.Fade);
			this.BAGICADFBAB().SetVector("(\\[ *h1 *\\])", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1387f, 217f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0400093E RID: 2366
	public Shader SCShader;

	// Token: 0x0400093F RID: 2367
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000940 RID: 2368
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x04000941 RID: 2369
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000942 RID: 2370
	[Range(-10f, 10f)]
	public float Distortion = 1f;

	// Token: 0x04000943 RID: 2371
	private Material BJFKDHHMLJH;
}
