using System;
using UnityEngine;

// Token: 0x020000E7 RID: 231
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Gradients/Rainbow")]
public class CameraFilterPack_Gradients_Rainbow : MonoBehaviour
{
	// Token: 0x06004730 RID: 18224 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004731 RID: 18225 RVA: 0x0015DBB7 File Offset: 0x0015BDB7
	private Material MLMKCOINOOH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004732 RID: 18226 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004733 RID: 18227 RVA: 0x0015DBEE File Offset: 0x0015BDEE
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004734 RID: 18228 RVA: 0x0015DC13 File Offset: 0x0015BE13
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004735 RID: 18229 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void MKFLBEGJJDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004736 RID: 18230 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004737 RID: 18231 RVA: 0x0015DC4C File Offset: 0x0015BE4C
	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 404f)
			{
				this.HBJJOCHGOPH = 1659f;
			}
			this.CEKJODEAMGB().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat("[EMPTY]", this.Switch);
			this.BLMPMOIDGMG().SetFloat("_BokehParams", this.Fade);
			this.AELJLBOJAIL().SetVector("EventMenu", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 754f, 1313f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004738 RID: 18232 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004739 RID: 18233 RVA: 0x0015DBEE File Offset: 0x0015BDEE
	private void FANADGBGCPI()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600473A RID: 18234 RVA: 0x0015DD1F File Offset: 0x0015BF1F
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600473B RID: 18235 RVA: 0x0015DD44 File Offset: 0x0015BF44
	private Material BLMPMOIDGMG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600473C RID: 18236 RVA: 0x0015DD7C File Offset: 0x0015BF7C
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 702f)
			{
				this.HBJJOCHGOPH = 1047f;
			}
			this.LPDOGGFOBDH().SetFloat("float,1.5", this.HBJJOCHGOPH);
			this.CEKJODEAMGB().SetFloat(".lastCheckpoint.time", this.Switch);
			this.IIJMIPBMMBF().SetFloat("&search=", this.Fade);
			this.OIIDAKBILMI().SetVector("L2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 712f, 1152f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600473D RID: 18237 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600473E RID: 18238 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600473F RID: 18239 RVA: 0x0015DE50 File Offset: 0x0015C050
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 215f)
			{
				this.HBJJOCHGOPH = 1035f;
			}
			this.MICHFGAOPKM().SetFloat("_Value", this.HBJJOCHGOPH);
			this.HHIAIGCAHDA().SetFloat("[SERVER] Selected map: ", this.Switch);
			this.LPDOGGFOBDH().SetFloat("L1", this.Fade);
			this.AELJLBOJAIL().SetVector("SetSatelliteTrailWidth", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 980f, 142f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004740 RID: 18240 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004741 RID: 18241 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004742 RID: 18242 RVA: 0x0015DF23 File Offset: 0x0015C123
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004743 RID: 18243 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004744 RID: 18244 RVA: 0x0015DBEE File Offset: 0x0015BDEE
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004745 RID: 18245 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004746 RID: 18246 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004747 RID: 18247 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void EDCMIPNCPLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004748 RID: 18248 RVA: 0x0015DF5A File Offset: 0x0015C15A
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004749 RID: 18249 RVA: 0x0015DF94 File Offset: 0x0015C194
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 543f)
			{
				this.HBJJOCHGOPH = 563f;
			}
			this.KGOLDDBHIFN().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("Set Satellite Lerp Speed", this.Switch);
			this.IGKFMCPDNOI().SetFloat("#FFFFFFFF", this.Fade);
			this.HKHBBBFLGJH().SetVector("Joystick1Button7", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 143f, 827f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600474A RID: 18250 RVA: 0x0015E067 File Offset: 0x0015C267
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)109;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600474B RID: 18251 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600474C RID: 18252 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x0600474D RID: 18253 RVA: 0x0015E0A0 File Offset: 0x0015C2A0
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1982f)
			{
				this.HBJJOCHGOPH = 1924f;
			}
			this.ADBKPGFMNKO().SetFloat("AllocateViewID() failed. User {0} is out of subIds, as all viewIDs are used.", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("Playing ", this.Switch);
			this.KGOLDDBHIFN().SetFloat("CameraFilterPack_Glasses_On7", this.Fade);
			this.HHIAIGCAHDA().SetVector("OnRelease", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1931f, 1721f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600474E RID: 18254 RVA: 0x0015E173 File Offset: 0x0015C373
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600474F RID: 18255 RVA: 0x0015E1AC File Offset: 0x0015C3AC
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 413f)
			{
				this.HBJJOCHGOPH = 1379f;
			}
			this.MICHFGAOPKM().SetFloat("#C8C8C8FF", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("CameraFilterPack/Glow_Glow_Color", this.Switch);
			this.OGMEGHKECAH().SetFloat("Loading maps", this.Fade);
			this.DEFBJOCJJKF().SetVector("Lightning", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1490f, 508f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004750 RID: 18256 RVA: 0x0015DD1F File Offset: 0x0015BF1F
	private void JDKHBGDEONK()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004751 RID: 18257 RVA: 0x0015E27F File Offset: 0x0015C47F
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004752 RID: 18258 RVA: 0x0015E2B6 File Offset: 0x0015C4B6
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004753 RID: 18259 RVA: 0x0015E2F0 File Offset: 0x0015C4F0
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 474f)
			{
				this.HBJJOCHGOPH = 654f;
			}
			this.IIJMIPBMMBF().SetFloat("/Segment-[Right]", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("https://twitch.tv/intralism", this.Switch);
			this.IIJMIPBMMBF().SetFloat("Players NetIDs:", this.Fade);
			this.IGKFMCPDNOI().SetVector("_Radius", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 55f, 1974f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004754 RID: 18260 RVA: 0x0015E3C4 File Offset: 0x0015C5C4
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1440f)
			{
				this.HBJJOCHGOPH = 712f;
			}
			this.MFHPKGICPIO().SetFloat("Failed to 'network-remove' GameObject because it's null.", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat(" (inactive)", this.Switch);
			this.BLMPMOIDGMG().SetFloat("(master)", this.Fade);
			this.MFHPKGICPIO().SetVector("_BlurParams", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 626f, 350f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004755 RID: 18261 RVA: 0x0015E497 File Offset: 0x0015C697
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004756 RID: 18262 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06004757 RID: 18263 RVA: 0x0015DD1F File Offset: 0x0015BF1F
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004758 RID: 18264 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004759 RID: 18265 RVA: 0x0015E4CE File Offset: 0x0015C6CE
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600475A RID: 18266 RVA: 0x0002523B File Offset: 0x0002343B
	private void LKJMIODJGCM()
	{
	}

	// Token: 0x0600475B RID: 18267 RVA: 0x0015E508 File Offset: 0x0015C708
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 481f)
			{
				this.HBJJOCHGOPH = 54f;
			}
			this.ADBKPGFMNKO().SetFloat("_Intensity", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("/", this.Switch);
			this.DKNJGHFLAIF().SetFloat(" with a prefix of ", this.Fade);
			this.IIJMIPBMMBF().SetVector("_Value6", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 878f, 500f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600475C RID: 18268 RVA: 0x0015DBEE File Offset: 0x0015BDEE
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600475D RID: 18269 RVA: 0x0015DBEE File Offset: 0x0015BDEE
	private void Start()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600475E RID: 18270 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x0600475F RID: 18271 RVA: 0x0015E5DB File Offset: 0x0015C7DB
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)112;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x170000CD RID: 205
	// (get) Token: 0x06004760 RID: 18272 RVA: 0x0015E612 File Offset: 0x0015C812
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

	// Token: 0x06004761 RID: 18273 RVA: 0x0015DBEE File Offset: 0x0015BDEE
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004762 RID: 18274 RVA: 0x0015E649 File Offset: 0x0015C849
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004763 RID: 18275 RVA: 0x0015E680 File Offset: 0x0015C880
	private Material NJDIODJNGGA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)114;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004764 RID: 18276 RVA: 0x0015E6B8 File Offset: 0x0015C8B8
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1995f)
			{
				this.HBJJOCHGOPH = 1505f;
			}
			this.DKNJGHFLAIF().SetFloat("Editor/", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat(". Verify the Prefab is in a Resources folder (and not in a subfolder)", this.Switch);
			this.GKILCDHJFEG().SetFloat("SetPosition", this.Fade);
			this.MLMKCOINOOH().SetVector("Coord", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 678f, 1206f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004765 RID: 18277 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004766 RID: 18278 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004767 RID: 18279 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004769 RID: 18281 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x0600476A RID: 18282 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600476B RID: 18283 RVA: 0x0015E7BF File Offset: 0x0015C9BF
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600476C RID: 18284 RVA: 0x0015DBEE File Offset: 0x0015BDEE
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600476D RID: 18285 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600476E RID: 18286 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600476F RID: 18287 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x06004770 RID: 18288 RVA: 0x0015E7F8 File Offset: 0x0015C9F8
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Switch);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Fade);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004771 RID: 18289 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004772 RID: 18290 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004773 RID: 18291 RVA: 0x0015E8CB File Offset: 0x0015CACB
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004774 RID: 18292 RVA: 0x0015E902 File Offset: 0x0015CB02
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004775 RID: 18293 RVA: 0x0015DBEE File Offset: 0x0015BDEE
	private void ECBILENEOOL()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004776 RID: 18294 RVA: 0x0015E939 File Offset: 0x0015CB39
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-84);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004777 RID: 18295 RVA: 0x0015E970 File Offset: 0x0015CB70
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004778 RID: 18296 RVA: 0x0015E173 File Offset: 0x0015C373
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004779 RID: 18297 RVA: 0x0015E9A7 File Offset: 0x0015CBA7
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)96;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600477A RID: 18298 RVA: 0x0015E9E0 File Offset: 0x0015CBE0
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1827f)
			{
				this.HBJJOCHGOPH = 1349f;
			}
			this.NBPKMLMCHFN.SetFloat(" not found", this.HBJJOCHGOPH);
			this.NJDIODJNGGA().SetFloat("Can't change CrcCheckEnabled while being connected. CrcCheckEnabled stays ", this.Switch);
			this.KGOLDDBHIFN().SetFloat("CameraFilterPack/Blend2Camera_ColorKey", this.Fade);
			this.FAIFBBGFAIB().SetVector("Reconnect() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 573f, 426f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600477B RID: 18299 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void ODGMCJILIHF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600477C RID: 18300 RVA: 0x0015EAB4 File Offset: 0x0015CCB4
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 586f)
			{
				this.HBJJOCHGOPH = 1355f;
			}
			this.NJDIODJNGGA().SetFloat("mapselector.orderby", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("\t", this.Switch);
			this.BLMPMOIDGMG().SetFloat("_Value2", this.Fade);
			this.HKHBBBFLGJH().SetVector("ACCEPT", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 416f, 836f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600477D RID: 18301 RVA: 0x0015DD1F File Offset: 0x0015BF1F
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600477E RID: 18302 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600477F RID: 18303 RVA: 0x0015EB88 File Offset: 0x0015CD88
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 54f)
			{
				this.HBJJOCHGOPH = 668f;
			}
			this.KEMAALEODNH().SetFloat(" not exist", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Set Player Distance", this.Switch);
			this.MICHFGAOPKM().SetFloat("_ExposureAdjustment", this.Fade);
			this.GKILCDHJFEG().SetVector(" cannot be used as a 3D LUT.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1701f, 152f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004780 RID: 18304 RVA: 0x0015EC5C File Offset: 0x0015CE5C
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1292f)
			{
				this.HBJJOCHGOPH = 1557f;
			}
			this.LPDOGGFOBDH().SetFloat("---", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("float,1.5", this.Switch);
			this.NDMPCDHADMJ().SetFloat("_Value4", this.Fade);
			this.AELJLBOJAIL().SetVector("_Blend", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1621f, 1427f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004781 RID: 18305 RVA: 0x0015ED30 File Offset: 0x0015CF30
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1269f)
			{
				this.HBJJOCHGOPH = 1273f;
			}
			this.OIIDAKBILMI().SetFloat("_FresnelFadePower", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("_InvRenderTargetSize", this.Switch);
			this.DKNJGHFLAIF().SetFloat("CameraFilterPack/AAA_Blood_Plus", this.Fade);
			this.MMOODGIODPC().SetVector("TimeBGSlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 832f, 708f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004782 RID: 18306 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004783 RID: 18307 RVA: 0x0015EE03 File Offset: 0x0015D003
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)101;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004784 RID: 18308 RVA: 0x0015EE3A File Offset: 0x0015D03A
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004785 RID: 18309 RVA: 0x0015EE71 File Offset: 0x0015D071
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004786 RID: 18310 RVA: 0x0015EEA8 File Offset: 0x0015D0A8
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 778f)
			{
				this.HBJJOCHGOPH = 1075f;
			}
			this.DEFBJOCJJKF().SetFloat("_SoftZDistance", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("_PrevViewProj", this.Switch);
			this.HHIAIGCAHDA().SetFloat("GameScene", this.Fade);
			this.IIJMIPBMMBF().SetVector("RecieveChatActionMessage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 653f, 722f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004787 RID: 18311 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x06004788 RID: 18312 RVA: 0x0015EF7B File Offset: 0x0015D17B
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004789 RID: 18313 RVA: 0x0015DB9A File Offset: 0x0015BD9A
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600478A RID: 18314 RVA: 0x0015DD1F File Offset: 0x0015BF1F
	private void HAIAHJPCPAG()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600478B RID: 18315 RVA: 0x0015DBEE File Offset: 0x0015BDEE
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600478C RID: 18316 RVA: 0x0015EFB4 File Offset: 0x0015D1B4
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 331f)
			{
				this.HBJJOCHGOPH = 1027f;
			}
			this.KJMECMIGJJA().SetFloat("PunPickupSimple", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("_Red_C", this.Switch);
			this.OGMEGHKECAH().SetFloat("\n\n#", this.Fade);
			this.MLMKCOINOOH().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 731f, 150f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600478D RID: 18317 RVA: 0x0015F087 File Offset: 0x0015D287
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600478E RID: 18318 RVA: 0x0015F0C0 File Offset: 0x0015D2C0
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 830f)
			{
				this.HBJJOCHGOPH = 216f;
			}
			this.ADBKPGFMNKO().SetFloat("Joystick1Button7", this.HBJJOCHGOPH);
			this.NJDIODJNGGA().SetFloat("_Blue_C", this.Switch);
			this.GKILCDHJFEG().SetFloat("steamid", this.Fade);
			this.IIJMIPBMMBF().SetVector("Version 1.0", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 479f, 622f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600478F RID: 18319 RVA: 0x0015E970 File Offset: 0x0015CB70
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004790 RID: 18320 RVA: 0x0015DBEE File Offset: 0x0015BDEE
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004791 RID: 18321 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06004792 RID: 18322 RVA: 0x0015DD1F File Offset: 0x0015BF1F
	private void FDNONDCGGCG()
	{
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0400078B RID: 1931
	public Shader SCShader;

	// Token: 0x0400078C RID: 1932
	private string ELOFMLPCCEA = "CameraFilterPack/Gradients_Rainbow";

	// Token: 0x0400078D RID: 1933
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400078E RID: 1934
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400078F RID: 1935
	private Material BJFKDHHMLJH;

	// Token: 0x04000790 RID: 1936
	[Range(0f, 1f)]
	public float Switch = 1f;

	// Token: 0x04000791 RID: 1937
	[Range(0f, 1f)]
	public float Fade = 1f;
}
