using System;
using UnityEngine;

// Token: 0x020000A2 RID: 162
[AddComponentMenu("Camera Filter Pack/Drawing/Manga_Color")]
[ExecuteInEditMode]
public class CameraFilterPack_Drawing_Manga_Color : MonoBehaviour
{
	// Token: 0x06003068 RID: 12392 RVA: 0x00100FC8 File Offset: 0x000FF1C8
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("_TileMaxLoop");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003069 RID: 12393 RVA: 0x00100FEC File Offset: 0x000FF1EC
	private Material CBCNOEIALHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600306A RID: 12394 RVA: 0x00101024 File Offset: 0x000FF224
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1939f)
			{
				this.HBJJOCHGOPH = 1306f;
			}
			this.OGMEGHKECAH().SetFloat("#ok", this.HBJJOCHGOPH);
			this.KDMBOKLMADJ().SetFloat("offline", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600306B RID: 12395 RVA: 0x001010B4 File Offset: 0x000FF2B4
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("(master)");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600306C RID: 12396 RVA: 0x001010D8 File Offset: 0x000FF2D8
	private void DKGBFNCOAEO()
	{
		this.SCShader = Shader.Find("mapselector.filter.rateduponly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600306D RID: 12397 RVA: 0x001010FC File Offset: 0x000FF2FC
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)109;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600306E RID: 12398 RVA: 0x00101134 File Offset: 0x000FF334
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 109f)
			{
				this.HBJJOCHGOPH = 1457f;
			}
			this.DOHGBNPMBKG().SetFloat("cancel", this.HBJJOCHGOPH);
			this.KDMBOKLMADJ().SetFloat("_ScreenResolution", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600306F RID: 12399 RVA: 0x001011C4 File Offset: 0x000FF3C4
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003070 RID: 12400 RVA: 0x001011FB File Offset: 0x000FF3FB
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find("CameraFilterPack_Fly_VisionFX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003071 RID: 12401 RVA: 0x0010121F File Offset: 0x000FF41F
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003072 RID: 12402 RVA: 0x00101256 File Offset: 0x000FF456
	private void HAIAHJPCPAG()
	{
		this.SCShader = Shader.Find("_DistortionLevel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003073 RID: 12403 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06003074 RID: 12404 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBFJAOINHMK()
	{
	}

	// Token: 0x06003075 RID: 12405 RVA: 0x0010127C File Offset: 0x000FF47C
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1490f)
			{
				this.HBJJOCHGOPH = 1440f;
			}
			this.DOHGBNPMBKG().SetFloat("0 seconds", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("_Value3", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003076 RID: 12406 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06003077 RID: 12407 RVA: 0x0010130C File Offset: 0x000FF50C
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003078 RID: 12408 RVA: 0x00101329 File Offset: 0x000FF529
	private void PMPKMGKAAJH()
	{
		this.SCShader = Shader.Find("NEW_ACHIEVEMENT_1_21");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003079 RID: 12409 RVA: 0x0010134D File Offset: 0x000FF54D
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find("player.xp");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600307A RID: 12410 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x0600307B RID: 12411 RVA: 0x0002523B File Offset: 0x0002343B
	private void JGMEKCFHGLE()
	{
	}

	// Token: 0x0600307C RID: 12412 RVA: 0x00101371 File Offset: 0x000FF571
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600307D RID: 12413 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x0600307E RID: 12414 RVA: 0x00101395 File Offset: 0x000FF595
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600307F RID: 12415 RVA: 0x0010130C File Offset: 0x000FF50C
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003080 RID: 12416 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x06003081 RID: 12417 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06003082 RID: 12418 RVA: 0x001013CC File Offset: 0x000FF5CC
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)96;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003083 RID: 12419 RVA: 0x00101404 File Offset: 0x000FF604
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 857f)
			{
				this.HBJJOCHGOPH = 659f;
			}
			this.LDNADDJMIPK().SetFloat("_DotSize", this.HBJJOCHGOPH);
			this.CBCNOEIALHB().SetFloat("_Intervale", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CBCNOEIALHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003084 RID: 12420 RVA: 0x00101494 File Offset: 0x000FF694
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003085 RID: 12421 RVA: 0x001014CC File Offset: 0x000FF6CC
	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 634f)
			{
				this.HBJJOCHGOPH = 765f;
			}
			this.OCMBHMLNCEK().SetFloat("_Brightness", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetFloat("_Offsets", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003086 RID: 12422 RVA: 0x0010155C File Offset: 0x000FF75C
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1964f)
			{
				this.HBJJOCHGOPH = 880f;
			}
			this.CBCNOEIALHB().SetFloat("_CurrentMipLevel", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat("_TimeX", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003087 RID: 12423 RVA: 0x0010130C File Offset: 0x000FF50C
	private void FMHOHGEAIEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003088 RID: 12424 RVA: 0x0002523B File Offset: 0x0002343B
	private void MANDOGNJJBD()
	{
	}

	// Token: 0x06003089 RID: 12425 RVA: 0x001011C4 File Offset: 0x000FF3C4
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600308A RID: 12426 RVA: 0x0010130C File Offset: 0x000FF50C
	private void MKFLBEGJJDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600308B RID: 12427 RVA: 0x001015EC File Offset: 0x000FF7EC
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 639f)
			{
				this.HBJJOCHGOPH = 573f;
			}
			this.LONNIJMNKFB().SetFloat("shader.pixel", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("CameraFilterPack/FX_Drunk", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600308C RID: 12428 RVA: 0x0010167C File Offset: 0x000FF87C
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("[SaveSystem] Outdated savefile found");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600308D RID: 12429 RVA: 0x0002523B File Offset: 0x0002343B
	private void COMNAPAAPDO()
	{
	}

	// Token: 0x0600308E RID: 12430 RVA: 0x001016A0 File Offset: 0x000FF8A0
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)86;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600308F RID: 12431 RVA: 0x001016D8 File Offset: 0x000FF8D8
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1776f)
			{
				this.HBJJOCHGOPH = 1285f;
			}
			this.BAGICADFBAB().SetFloat("[PlayerBase] Current attempt: ", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("_TimeX", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003090 RID: 12432 RVA: 0x0010130C File Offset: 0x000FF50C
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003091 RID: 12433 RVA: 0x00101768 File Offset: 0x000FF968
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("_HeightParams");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003092 RID: 12434 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06003093 RID: 12435 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJHFOBHJEHL()
	{
	}

	// Token: 0x06003094 RID: 12436 RVA: 0x0010178C File Offset: 0x000FF98C
	private Material DOMEEFLPEPJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003095 RID: 12437 RVA: 0x0010130C File Offset: 0x000FF50C
	private void EFECEKPFOEM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003096 RID: 12438 RVA: 0x001017C3 File Offset: 0x000FF9C3
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_Manga_Color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003097 RID: 12439 RVA: 0x001017E8 File Offset: 0x000FF9E8
	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1029f)
			{
				this.HBJJOCHGOPH = 713f;
			}
			this.NMDBCDFPGOK().SetFloat("_BlurVector", this.HBJJOCHGOPH);
			this.FKEOGPDLBDD().SetFloat("#yes", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003098 RID: 12440 RVA: 0x0010130C File Offset: 0x000FF50C
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003099 RID: 12441 RVA: 0x0010130C File Offset: 0x000FF50C
	private void GNPDGBNDCPL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600309A RID: 12442 RVA: 0x00101878 File Offset: 0x000FFA78
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600309B RID: 12443 RVA: 0x001018AF File Offset: 0x000FFAAF
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600309C RID: 12444 RVA: 0x001018E8 File Offset: 0x000FFAE8
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 859f)
			{
				this.HBJJOCHGOPH = 323f;
			}
			this.NBPKMLMCHFN.SetFloat("MessageText", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("g", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600309D RID: 12445 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x0600309E RID: 12446 RVA: 0x00101978 File Offset: 0x000FFB78
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600309F RID: 12447 RVA: 0x0002523B File Offset: 0x0002343B
	private void FGNFILLNPJK()
	{
	}

	// Token: 0x060030A0 RID: 12448 RVA: 0x001019AF File Offset: 0x000FFBAF
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060030A1 RID: 12449 RVA: 0x0010130C File Offset: 0x000FF50C
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060030A2 RID: 12450 RVA: 0x0010130C File Offset: 0x000FF50C
	private void DKPBBJINKMG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060030A3 RID: 12451 RVA: 0x001019E6 File Offset: 0x000FFBE6
	private void BOPKKCAFODF()
	{
		this.SCShader = Shader.Find("#join");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060030A4 RID: 12452 RVA: 0x00101A0A File Offset: 0x000FFC0A
	private void DOKAKEMDALN()
	{
		this.SCShader = Shader.Find("#tryagain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060030A5 RID: 12453 RVA: 0x00101A30 File Offset: 0x000FFC30
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 877f)
			{
				this.HBJJOCHGOPH = 561f;
			}
			this.DOMEEFLPEPJ().SetFloat("maps.", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("Image", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060030A6 RID: 12454 RVA: 0x00101AC0 File Offset: 0x000FFCC0
	private void JABNHMIHBHC()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Vision_AuraDistortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060030A7 RID: 12455 RVA: 0x00101AE4 File Offset: 0x000FFCE4
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Lighten");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060030A8 RID: 12456 RVA: 0x0002523B File Offset: 0x0002343B
	private void EDDPLJGKLKJ()
	{
	}

	// Token: 0x060030A9 RID: 12457 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x060030AA RID: 12458 RVA: 0x00101B08 File Offset: 0x000FFD08
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 181f)
			{
				this.HBJJOCHGOPH = 1167f;
			}
			this.LMLENGFLEBD().SetFloat("CameraFilterPack/Lut_Simple", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("editorVolume", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060030AB RID: 12459 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x060030AC RID: 12460 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIFLPHLGLFG()
	{
	}

	// Token: 0x060030AD RID: 12461 RVA: 0x00101B98 File Offset: 0x000FFD98
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1832f)
			{
				this.HBJJOCHGOPH = 1125f;
			}
			this.FGENHBKMPDA().SetFloat("_DotSize", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("Winter2020", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060030AE RID: 12462 RVA: 0x00101C28 File Offset: 0x000FFE28
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060030AF RID: 12463 RVA: 0x0002523B File Offset: 0x0002343B
	private void COGBDFKOHKK()
	{
	}

	// Token: 0x060030B0 RID: 12464 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x060030B1 RID: 12465 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x060030B2 RID: 12466 RVA: 0x00101C60 File Offset: 0x000FFE60
	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1830f)
			{
				this.HBJJOCHGOPH = 1400f;
			}
			this.HFBJAOFLCJI().SetFloat("#close", this.HBJJOCHGOPH);
			this.LMLENGFLEBD().SetFloat("/", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060030B3 RID: 12467 RVA: 0x0002523B File Offset: 0x0002343B
	private void JCGMGLMADEN()
	{
	}

	// Token: 0x060030B4 RID: 12468 RVA: 0x00101CF0 File Offset: 0x000FFEF0
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1573f)
			{
				this.HBJJOCHGOPH = 1807f;
			}
			this.PDEAHJPOMEF().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("Failed to Instantiate prefab:", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060030B5 RID: 12469 RVA: 0x00101D80 File Offset: 0x000FFF80
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 515f)
			{
				this.HBJJOCHGOPH = 1222f;
			}
			this.LONNIJMNKFB().SetFloat("Texture2", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("_Blue_R", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060030B6 RID: 12470 RVA: 0x00101E10 File Offset: 0x00100010
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060030B7 RID: 12471 RVA: 0x00101E34 File Offset: 0x00100034
	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1842f)
			{
				this.HBJJOCHGOPH = 396f;
			}
			this.OOMFJGPAOKL().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("HH:mm:ss", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060030B8 RID: 12472 RVA: 0x00101EC4 File Offset: 0x001000C4
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060030B9 RID: 12473 RVA: 0x00101EE8 File Offset: 0x001000E8
	private Material NMDBCDFPGOK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060030BA RID: 12474 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x060030BB RID: 12475 RVA: 0x0010130C File Offset: 0x000FF50C
	private void EDCMIPNCPLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000087 RID: 135
	// (get) Token: 0x060030BC RID: 12476 RVA: 0x00101F1F File Offset: 0x0010011F
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

	// Token: 0x060030BD RID: 12477 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x060030BE RID: 12478 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060030BF RID: 12479 RVA: 0x0010130C File Offset: 0x000FF50C
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060030C0 RID: 12480 RVA: 0x00101F58 File Offset: 0x00100158
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 141f)
			{
				this.HBJJOCHGOPH = 1669f;
			}
			this.ECCPAOBFDKP().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("_Level", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060030C1 RID: 12481 RVA: 0x00101FE8 File Offset: 0x001001E8
	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 503f)
			{
				this.HBJJOCHGOPH = 324f;
			}
			this.KJMECMIGJJA().SetFloat("?", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("_Params3", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060030C2 RID: 12482 RVA: 0x00102078 File Offset: 0x00100278
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060030C3 RID: 12483 RVA: 0x001020AF File Offset: 0x001002AF
	private void LFBGJIIECLD()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Vision_Tunnel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060030C4 RID: 12484 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x060030C5 RID: 12485 RVA: 0x001020D3 File Offset: 0x001002D3
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("[ResourcesManager] Unloading data resources");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060030C6 RID: 12486 RVA: 0x001020F7 File Offset: 0x001002F7
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060030C7 RID: 12487 RVA: 0x00102130 File Offset: 0x00100330
	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 39f)
			{
				this.HBJJOCHGOPH = 1427f;
			}
			this.ACHNOHCLGOO().SetFloat("Reading preview file failed! Make sure JSON file is filled properly and/or file exists: \"{0}\"", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetFloat("float,1.5", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060030C8 RID: 12488 RVA: 0x00101878 File Offset: 0x000FFA78
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060030C9 RID: 12489 RVA: 0x001019AF File Offset: 0x000FFBAF
	private Material OCMBHMLNCEK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060030CA RID: 12490 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x060030CC RID: 12492 RVA: 0x001021DE File Offset: 0x001003DE
	private Material OOMFJGPAOKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060030CD RID: 12493 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x060030CE RID: 12494 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x060030CF RID: 12495 RVA: 0x0010130C File Offset: 0x000FF50C
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060030D0 RID: 12496 RVA: 0x00102215 File Offset: 0x00100415
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("settings.hideui");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060030D1 RID: 12497 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x060030D2 RID: 12498 RVA: 0x0002523B File Offset: 0x0002343B
	private void AKCADICOFDD()
	{
	}

	// Token: 0x060030D3 RID: 12499 RVA: 0x00102239 File Offset: 0x00100439
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060030D4 RID: 12500 RVA: 0x00102270 File Offset: 0x00100470
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1558f)
			{
				this.HBJJOCHGOPH = 1888f;
			}
			this.DONENAMLFLF().SetFloat("default", this.HBJJOCHGOPH);
			this.ECCPAOBFDKP().SetFloat("LevelConfigButton", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060030D5 RID: 12501 RVA: 0x00102300 File Offset: 0x00100500
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find(" is not observed by this object's photonView! OnPhotonSerializeView() in this class won't be used.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060030D6 RID: 12502 RVA: 0x00102324 File Offset: 0x00100524
	private void DPLLKHHLDBB()
	{
		this.SCShader = Shader.Find("note.0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060030D7 RID: 12503 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x060030D8 RID: 12504 RVA: 0x0010130C File Offset: 0x000FF50C
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060030D9 RID: 12505 RVA: 0x00102348 File Offset: 0x00100548
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1975f)
			{
				this.HBJJOCHGOPH = 1051f;
			}
			this.LMLENGFLEBD().SetFloat(" respawn: ", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("_ArScale", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060030DA RID: 12506 RVA: 0x001023D8 File Offset: 0x001005D8
	private void JECMJNFGBGC()
	{
		this.SCShader = Shader.Find("_CenterY");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060030DB RID: 12507 RVA: 0x001023FC File Offset: 0x001005FC
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
			this.NBPKMLMCHFN.SetFloat("_DotSize", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060030DC RID: 12508 RVA: 0x0010248C File Offset: 0x0010068C
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060030DD RID: 12509 RVA: 0x001024C3 File Offset: 0x001006C3
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060030DE RID: 12510 RVA: 0x001024FA File Offset: 0x001006FA
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060030DF RID: 12511 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x060030E0 RID: 12512 RVA: 0x00102078 File Offset: 0x00100278
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060030E1 RID: 12513 RVA: 0x0010130C File Offset: 0x000FF50C
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060030E2 RID: 12514 RVA: 0x00102531 File Offset: 0x00100731
	private void CEAGPJBGBMH()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060030E3 RID: 12515 RVA: 0x0010130C File Offset: 0x000FF50C
	private void HLHJBJGEEEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060030E4 RID: 12516 RVA: 0x00102555 File Offset: 0x00100755
	private Material ECCPAOBFDKP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060030E5 RID: 12517 RVA: 0x0010258C File Offset: 0x0010078C
	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 442f)
			{
				this.HBJJOCHGOPH = 1662f;
			}
			this.BAGICADFBAB().SetFloat("CameraFilterPack/TV_BrokenGlass", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("_Bloom", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060030E6 RID: 12518 RVA: 0x0010130C File Offset: 0x000FF50C
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060030E7 RID: 12519 RVA: 0x0010261C File Offset: 0x0010081C
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060030E8 RID: 12520 RVA: 0x00102654 File Offset: 0x00100854
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 492f)
			{
				this.HBJJOCHGOPH = 1105f;
			}
			this.FKEOGPDLBDD().SetFloat("_ColorBuffer", this.HBJJOCHGOPH);
			this.BAGICADFBAB().SetFloat("_Value3", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060030E9 RID: 12521 RVA: 0x001026E4 File Offset: 0x001008E4
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060030EA RID: 12522 RVA: 0x0010271B File Offset: 0x0010091B
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("Fake");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060030EB RID: 12523 RVA: 0x00102740 File Offset: 0x00100940
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1879f)
			{
				this.HBJJOCHGOPH = 1839f;
			}
			this.HEINDEMCGIK().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.FGENHBKMPDA().SetFloat("Error: Can not set the OnSerialize rate higher than the overall SendRate.", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0400058C RID: 1420
	public Shader SCShader;

	// Token: 0x0400058D RID: 1421
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400058E RID: 1422
	private Material BJFKDHHMLJH;

	// Token: 0x0400058F RID: 1423
	[Range(1f, 8f)]
	public float DotSize = 1.6f;

	// Token: 0x04000590 RID: 1424
	public static float ChangeDotSize;
}
