using System;
using UnityEngine;

// Token: 0x02000121 RID: 289
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/TV/RGB Display")]
public class CameraFilterPack_TV_Rgb : MonoBehaviour
{
	// Token: 0x06005B23 RID: 23331 RVA: 0x001C0E25 File Offset: 0x001BF025
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B24 RID: 23332 RVA: 0x001C0E5C File Offset: 0x001BF05C
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B25 RID: 23333 RVA: 0x001C0E93 File Offset: 0x001BF093
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B26 RID: 23334 RVA: 0x001C0ECA File Offset: 0x001BF0CA
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B27 RID: 23335 RVA: 0x001C0EE7 File Offset: 0x001BF0E7
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find("player.lollipop");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005B28 RID: 23336 RVA: 0x001C0ECA File Offset: 0x001BF0CA
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B29 RID: 23337 RVA: 0x001C0ECA File Offset: 0x001BF0CA
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B2A RID: 23338 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x06005B2B RID: 23339 RVA: 0x001C0F0B File Offset: 0x001BF10B
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("Write me to get one for testing :)");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005B2C RID: 23340 RVA: 0x001C0F2F File Offset: 0x001BF12F
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B2D RID: 23341 RVA: 0x001C0F66 File Offset: 0x001BF166
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005B2E RID: 23342 RVA: 0x001C0F8A File Offset: 0x001BF18A
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005B2F RID: 23343 RVA: 0x001C0FAE File Offset: 0x001BF1AE
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-90);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B30 RID: 23344 RVA: 0x001C0FE5 File Offset: 0x001BF1E5
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("_Smooth");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005B31 RID: 23345 RVA: 0x001C1009 File Offset: 0x001BF209
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find("1.87");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005B32 RID: 23346 RVA: 0x001C102D File Offset: 0x001BF22D
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B33 RID: 23347 RVA: 0x001C1064 File Offset: 0x001BF264
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x17000106 RID: 262
	// (get) Token: 0x06005B34 RID: 23348 RVA: 0x001C109B File Offset: 0x001BF29B
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

	// Token: 0x06005B35 RID: 23349 RVA: 0x001C10D2 File Offset: 0x001BF2D2
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B36 RID: 23350 RVA: 0x001C110C File Offset: 0x001BF30C
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1345f)
			{
				this.HBJJOCHGOPH = 1142f;
			}
			this.ACHNOHCLGOO().SetFloat("menutheme.summerbreeze", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("GlassDistortion", this.Distortion);
			this.GKILCDHJFEG().SetVector("[Up]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1036f, 1814f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B37 RID: 23351 RVA: 0x001C11CC File Offset: 0x001BF3CC
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 104f)
			{
				this.HBJJOCHGOPH = 1664f;
			}
			this.LDNADDJMIPK().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat("<b>Kick player by NetID</b>\nuse: /kick {NetID}\nUse \"/players\" command to get all NetIDs\nRoom owner only can kick the players", this.Distortion);
			this.CFCPHFMKHII().SetVector("_FarCamera", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1753f, 328f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B39 RID: 23353 RVA: 0x001C0ECA File Offset: 0x001BF0CA
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B3A RID: 23354 RVA: 0x001C12A8 File Offset: 0x001BF4A8
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 858f)
			{
				this.HBJJOCHGOPH = 473f;
			}
			this.HNICHJCGJOC().SetFloat("mapselector.tags.", this.HBJJOCHGOPH);
			this.CFCPHFMKHII().SetFloat("Deleted event", this.Distortion);
			this.BFGNMFCNDBC().SetVector("GameVolumeSlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 997f, 291f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B3B RID: 23355 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06005B3C RID: 23356 RVA: 0x001C1365 File Offset: 0x001BF565
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-116);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B3D RID: 23357 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005B3E RID: 23358 RVA: 0x001C139C File Offset: 0x001BF59C
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1806f)
			{
				this.HBJJOCHGOPH = 1670f;
			}
			this.KOHGPKOFEJO().SetFloat("MenuRecordButton", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("CameraFilterPack/3D_Shield", this.Distortion);
			this.LDNADDJMIPK().SetVector(" in-game items", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1078f, 1341f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B3F RID: 23359 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06005B40 RID: 23360 RVA: 0x001C145C File Offset: 0x001BF65C
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 38f)
			{
				this.HBJJOCHGOPH = 1390f;
			}
			this.NDMPCDHADMJ().SetFloat("Color's hex value #RRGGBBAA", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("CameraFilterPack/TV_WideScreenVertical", this.Distortion);
			this.LDNADDJMIPK().SetVector("ShadersToggle", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 694f, 1456f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B41 RID: 23361 RVA: 0x001C1519 File Offset: 0x001BF719
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B42 RID: 23362 RVA: 0x001C0ECA File Offset: 0x001BF0CA
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B43 RID: 23363 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06005B44 RID: 23364 RVA: 0x001C1550 File Offset: 0x001BF750
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("s");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005B45 RID: 23365 RVA: 0x001C1574 File Offset: 0x001BF774
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("IconImage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005B46 RID: 23366 RVA: 0x001C0ECA File Offset: 0x001BF0CA
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B47 RID: 23367 RVA: 0x001C1598 File Offset: 0x001BF798
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 711f)
			{
				this.HBJJOCHGOPH = 230f;
			}
			this.KOHGPKOFEJO().SetFloat("CameraFilterPack/AAA_WaterDropPro", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("Coord", this.Distortion);
			this.KOHGPKOFEJO().SetVector("_Blend", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1036f, 1032f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B48 RID: 23368 RVA: 0x001C0ECA File Offset: 0x001BF0CA
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B49 RID: 23369 RVA: 0x001C1658 File Offset: 0x001BF858
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1620f)
			{
				this.HBJJOCHGOPH = 1851f;
			}
			this.OGMEGHKECAH().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("_Value", this.Distortion);
			this.MMOODGIODPC().SetVector("menu.selectedplaymode", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1948f, 298f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFCPHFMKHII());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B4A RID: 23370 RVA: 0x001C1715 File Offset: 0x001BF915
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B4B RID: 23371 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06005B4C RID: 23372 RVA: 0x001C174C File Offset: 0x001BF94C
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1374f)
			{
				this.HBJJOCHGOPH = 1199f;
			}
			this.GKILCDHJFEG().SetFloat("\"\"", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("_ScreenResolution", this.Distortion);
			this.HEHKGPKLAKK().SetVector("_", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 887f, 1984f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B4D RID: 23373 RVA: 0x001C0ECA File Offset: 0x001BF0CA
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B4E RID: 23374 RVA: 0x001C0ECA File Offset: 0x001BF0CA
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B4F RID: 23375 RVA: 0x001C1809 File Offset: 0x001BFA09
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B50 RID: 23376 RVA: 0x001C1840 File Offset: 0x001BFA40
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B51 RID: 23377 RVA: 0x001C1878 File Offset: 0x001BFA78
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1209f)
			{
				this.HBJJOCHGOPH = 1424f;
			}
			this.FLOHGDECHHH().SetFloat("tagElement", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("Case-Sensitive", this.Distortion);
			this.ACHNOHCLGOO().SetVector("settings.disablestoryboard", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1606f, 1223f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B52 RID: 23378 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06005B53 RID: 23379 RVA: 0x001C1935 File Offset: 0x001BFB35
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("#ok");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005B54 RID: 23380 RVA: 0x001C1959 File Offset: 0x001BFB59
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("settings.enableselectormusic");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005B55 RID: 23381 RVA: 0x001C1980 File Offset: 0x001BFB80
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1544f)
			{
				this.HBJJOCHGOPH = 1808f;
			}
			this.CFCPHFMKHII().SetFloat("SetParent", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("Object ID. Case-Sensitive", this.Distortion);
			this.GKILCDHJFEG().SetVector(". We have no such PhotonView! Ignored this if you're leaving a room. State: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1163f, 1725f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B56 RID: 23382 RVA: 0x001C1A3D File Offset: 0x001BFC3D
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("BitsData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005B57 RID: 23383 RVA: 0x001C1A64 File Offset: 0x001BFC64
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 116f)
			{
				this.HBJJOCHGOPH = 386f;
			}
			this.PDEAHJPOMEF().SetFloat("Can't set Room.MaxPlayers to: ", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("_Value", this.Distortion);
			this.MICHFGAOPKM().SetVector("IconFileSelector", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 132f, 1071f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B58 RID: 23384 RVA: 0x001C0ECA File Offset: 0x001BF0CA
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B59 RID: 23385 RVA: 0x001C1B24 File Offset: 0x001BFD24
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1991f)
			{
				this.HBJJOCHGOPH = 1065f;
			}
			this.ADGHJOHKEHG().SetFloat("No connection to item server!", this.HBJJOCHGOPH);
			this.CFCPHFMKHII().SetFloat("error", this.Distortion);
			this.LONNIJMNKFB().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1058f, 767f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B5A RID: 23386 RVA: 0x001C1BE1 File Offset: 0x001BFDE1
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B5B RID: 23387 RVA: 0x001C1C18 File Offset: 0x001BFE18
	private Material CFCPHFMKHII()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B5C RID: 23388 RVA: 0x001C0ECA File Offset: 0x001BF0CA
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B5D RID: 23389 RVA: 0x001C1C4F File Offset: 0x001BFE4F
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B5E RID: 23390 RVA: 0x001C1C86 File Offset: 0x001BFE86
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B5F RID: 23391 RVA: 0x001C1CBD File Offset: 0x001BFEBD
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("1177138211");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005B60 RID: 23392 RVA: 0x001C1CE4 File Offset: 0x001BFEE4
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 323f)
			{
				this.HBJJOCHGOPH = 1426f;
			}
			this.PDEAHJPOMEF().SetFloat("CameraFilterPack/Blend2Camera_SoftLight", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("EditMenu", this.Distortion);
			this.HEHKGPKLAKK().SetVector("_Value6", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 843f, 1784f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B61 RID: 23393 RVA: 0x001C1DA4 File Offset: 0x001BFFA4
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1558f)
			{
				this.HBJJOCHGOPH = 1616f;
			}
			this.FEAEGGCNIAA().SetFloat("checkpoint", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("grid", this.Distortion);
			this.CFCPHFMKHII().SetVector("Default UI Material", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 324f, 706f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B62 RID: 23394 RVA: 0x001C1E64 File Offset: 0x001C0064
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
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005B63 RID: 23395 RVA: 0x001C0ECA File Offset: 0x001BF0CA
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B64 RID: 23396 RVA: 0x001C0ECA File Offset: 0x001BF0CA
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005B65 RID: 23397 RVA: 0x001C1F21 File Offset: 0x001C0121
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_Rgb");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005B66 RID: 23398 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06005B67 RID: 23399 RVA: 0x001C1F45 File Offset: 0x001C0145
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005B68 RID: 23400 RVA: 0x001C1F7C File Offset: 0x001C017C
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("menu.tabid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005B69 RID: 23401 RVA: 0x001C1FA0 File Offset: 0x001C01A0
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000949 RID: 2377
	public Shader SCShader;

	// Token: 0x0400094A RID: 2378
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400094B RID: 2379
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400094C RID: 2380
	[Range(0.01f, 4f)]
	public float Distortion = 1f;

	// Token: 0x0400094D RID: 2381
	private Material BJFKDHHMLJH;
}
