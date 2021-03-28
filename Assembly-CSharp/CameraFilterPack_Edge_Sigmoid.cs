using System;
using UnityEngine;

// Token: 0x020000B3 RID: 179
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Edge/Sigmoid")]
public class CameraFilterPack_Edge_Sigmoid : MonoBehaviour
{
	// Token: 0x06003674 RID: 13940 RVA: 0x00118734 File Offset: 0x00116934
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1736f)
			{
				this.HBJJOCHGOPH = 6f;
			}
			this.OIBHFCLJKDB().SetFloat(" on effect ", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("_TimeX", this.Gain);
			this.MNLKBFFKHIE().SetVector("_TimeX", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003675 RID: 13941 RVA: 0x001187EA File Offset: 0x001169EA
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003676 RID: 13942 RVA: 0x00118807 File Offset: 0x00116A07
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)96;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003677 RID: 13943 RVA: 0x00118840 File Offset: 0x00116A40
	private void KHGEBPHKAGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 2f)
			{
				this.HBJJOCHGOPH = 419f;
			}
			this.MJJIEHANFJA().SetFloat("_EmissionGain", this.HBJJOCHGOPH);
			this.HHLFDHNEIAH().SetFloat(": ", this.Gain);
			this.DKNJGHFLAIF().SetVector("_TimeX", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003678 RID: 13944 RVA: 0x001188F6 File Offset: 0x00116AF6
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find("Horizontal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003679 RID: 13945 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOAGAKFBIGD()
	{
	}

	// Token: 0x0600367A RID: 13946 RVA: 0x0011891A File Offset: 0x00116B1A
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find("JoinButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600367B RID: 13947 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x0600367C RID: 13948 RVA: 0x00118940 File Offset: 0x00116B40
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1925f)
			{
				this.HBJJOCHGOPH = 534f;
			}
			this.BFGNMFCNDBC().SetFloat("InfoCanvas", this.HBJJOCHGOPH);
			this.KHCLIAMBBNC().SetFloat(" ", this.Gain);
			this.KOHGPKOFEJO().SetVector("_Offsets", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600367D RID: 13949 RVA: 0x001189F6 File Offset: 0x00116BF6
	private Material MNLKBFFKHIE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600367E RID: 13950 RVA: 0x00118A2D File Offset: 0x00116C2D
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600367F RID: 13951 RVA: 0x001187EA File Offset: 0x001169EA
	private void PNNPDMHLFHE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003680 RID: 13952 RVA: 0x00118A64 File Offset: 0x00116C64
	private Material KHCLIAMBBNC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003681 RID: 13953 RVA: 0x00118A9B File Offset: 0x00116C9B
	private void HJPCJGOEKMF()
	{
		this.SCShader = Shader.Find("It seems some instantiation is not completed, as instantiation data is used. You should make sure instantiations are paused when calling this method. Cleaning now, despite this.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003682 RID: 13954 RVA: 0x00118ABF File Offset: 0x00116CBF
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Edge_Sigmoid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003683 RID: 13955 RVA: 0x00118AE3 File Offset: 0x00116CE3
	private Material CECJJMKLEAK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003684 RID: 13956 RVA: 0x001187EA File Offset: 0x001169EA
	private void AOKOLPEGHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003685 RID: 13957 RVA: 0x00118B1C File Offset: 0x00116D1C
	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 875f)
			{
				this.HBJJOCHGOPH = 28f;
			}
			this.KHCLIAMBBNC().SetFloat("_Vibrance", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("_Value", this.Gain);
			this.KOHGPKOFEJO().SetVector("_Value12", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003686 RID: 13958 RVA: 0x00118BD4 File Offset: 0x00116DD4
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1174f)
			{
				this.HBJJOCHGOPH = 1997f;
			}
			this.DBOLLHHMKKN().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat(":", this.Gain);
			this.DNLMFEGJJDD().SetVector("[MapEditor] Updating map assets", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003687 RID: 13959 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06003688 RID: 13960 RVA: 0x00118C8A File Offset: 0x00116E8A
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-92);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003689 RID: 13961 RVA: 0x00118CC1 File Offset: 0x00116EC1
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600368A RID: 13962 RVA: 0x001187EA File Offset: 0x001169EA
	private void ELDMKIAPNGP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600368B RID: 13963 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIFLPHLGLFG()
	{
	}

	// Token: 0x0600368C RID: 13964 RVA: 0x0002523B File Offset: 0x0002343B
	private void HCIPECAOGIA()
	{
	}

	// Token: 0x0600368D RID: 13965 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x0600368E RID: 13966 RVA: 0x00118CF8 File Offset: 0x00116EF8
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600368F RID: 13967 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06003690 RID: 13968 RVA: 0x001187EA File Offset: 0x001169EA
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003691 RID: 13969 RVA: 0x001187EA File Offset: 0x001169EA
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003692 RID: 13970 RVA: 0x001187EA File Offset: 0x001169EA
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003693 RID: 13971 RVA: 0x00118D2F File Offset: 0x00116F2F
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("mapselector.filter.subscribedonly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003694 RID: 13972 RVA: 0x00118D53 File Offset: 0x00116F53
	private Material INOBFNCKFGK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003695 RID: 13973 RVA: 0x00118D8C File Offset: 0x00116F8C
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 967f)
			{
				this.HBJJOCHGOPH = 1819f;
			}
			this.FEAEGGCNIAA().SetFloat("_TreatBackfaceHitAsMiss", this.HBJJOCHGOPH);
			this.CECJJMKLEAK().SetFloat("file://", this.Gain);
			this.HKGAONMOBMH().SetVector("steamid", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003696 RID: 13974 RVA: 0x00118E42 File Offset: 0x00117042
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003697 RID: 13975 RVA: 0x001187EA File Offset: 0x001169EA
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003698 RID: 13976 RVA: 0x00118E66 File Offset: 0x00117066
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003699 RID: 13977 RVA: 0x00118EA0 File Offset: 0x001170A0
	private void OPIBJIMIOKE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1725f)
			{
				this.HBJJOCHGOPH = 1718f;
			}
			this.PDEAHJPOMEF().SetFloat("BitsData", this.HBJJOCHGOPH);
			this.MJJIEHANFJA().SetFloat("_ScreenResolution", this.Gain);
			this.BFGNMFCNDBC().SetVector("_TimeX", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600369A RID: 13978 RVA: 0x001187EA File Offset: 0x001169EA
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600369B RID: 13979 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKMELABKBHO()
	{
	}

	// Token: 0x17000098 RID: 152
	// (get) Token: 0x0600369C RID: 13980 RVA: 0x00118F56 File Offset: 0x00117156
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

	// Token: 0x0600369D RID: 13981 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x0600369E RID: 13982 RVA: 0x00118F8D File Offset: 0x0011718D
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600369F RID: 13983 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x060036A0 RID: 13984 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x060036A1 RID: 13985 RVA: 0x00118FC4 File Offset: 0x001171C4
	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 317f)
			{
				this.HBJJOCHGOPH = 722f;
			}
			this.FEAEGGCNIAA().SetFloat("_TapLowBackground", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat("_Value", this.Gain);
			this.OIBHFCLJKDB().SetVector("GlassesColor", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060036A2 RID: 13986 RVA: 0x0011907A File Offset: 0x0011727A
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060036A3 RID: 13987 RVA: 0x001190B1 File Offset: 0x001172B1
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("Creating new item...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060036A4 RID: 13988 RVA: 0x001190D5 File Offset: 0x001172D5
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("&page=");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060036A5 RID: 13989 RVA: 0x001190F9 File Offset: 0x001172F9
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060036A6 RID: 13990 RVA: 0x00119130 File Offset: 0x00117330
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1273f)
			{
				this.HBJJOCHGOPH = 529f;
			}
			this.DKNJGHFLAIF().SetFloat(" / Sample Count: ", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("settings_bindings_controller_type", this.Gain);
			this.DKNJGHFLAIF().SetVector("inventory.selected.", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060036A7 RID: 13991 RVA: 0x001191E8 File Offset: 0x001173E8
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 622f)
			{
				this.HBJJOCHGOPH = 239f;
			}
			this.EHDJJANLINB().SetFloat("_ColorG", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat(" BETA", this.Gain);
			this.FEAEGGCNIAA().SetVector("_TimeX", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060036A8 RID: 13992 RVA: 0x0002523B File Offset: 0x0002343B
	private void JCGMGLMADEN()
	{
	}

	// Token: 0x060036A9 RID: 13993 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBMBNKOOENB()
	{
	}

	// Token: 0x060036AA RID: 13994 RVA: 0x001187EA File Offset: 0x001169EA
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060036AB RID: 13995 RVA: 0x001192A0 File Offset: 0x001174A0
	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 312f)
			{
				this.HBJJOCHGOPH = 347f;
			}
			this.LPDOGGFOBDH().SetFloat("_Size", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("_Distance", this.Gain);
			this.IIJMIPBMMBF().SetVector("workshop.", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060036AC RID: 13996 RVA: 0x00119356 File Offset: 0x00117556
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060036AD RID: 13997 RVA: 0x00119390 File Offset: 0x00117590
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1547f)
			{
				this.HBJJOCHGOPH = 1410f;
			}
			this.KEMAALEODNH().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("EventMenu", this.Gain);
			this.LPDOGGFOBDH().SetVector("skin.", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060036AE RID: 13998 RVA: 0x00119446 File Offset: 0x00117646
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060036AF RID: 13999 RVA: 0x0011947D File Offset: 0x0011767D
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060036B0 RID: 14000 RVA: 0x001194B4 File Offset: 0x001176B4
	private void ALNNIDLFILB()
	{
		this.SCShader = Shader.Find("BestRegion checks region: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060036B1 RID: 14001 RVA: 0x0002523B File Offset: 0x0002343B
	private void LKJMIODJGCM()
	{
	}

	// Token: 0x060036B2 RID: 14002 RVA: 0x001194D8 File Offset: 0x001176D8
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060036B3 RID: 14003 RVA: 0x0011950F File Offset: 0x0011770F
	private Material MJJIEHANFJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060036B4 RID: 14004 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBDEJFCNOBF()
	{
	}

	// Token: 0x060036B5 RID: 14005 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBPCODPOJAH()
	{
	}

	// Token: 0x060036B6 RID: 14006 RVA: 0x00118D53 File Offset: 0x00116F53
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060036B7 RID: 14007 RVA: 0x00119546 File Offset: 0x00117746
	private Material BKKJJJGADLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060036B8 RID: 14008 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x060036B9 RID: 14009 RVA: 0x00119580 File Offset: 0x00117780
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 144f)
			{
				this.HBJJOCHGOPH = 53f;
			}
			this.KOHGPKOFEJO().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("Left Stick Click", this.Gain);
			this.NLFJGMBCICG().SetVector("threshold", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060036BA RID: 14010 RVA: 0x00119638 File Offset: 0x00117838
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1433f)
			{
				this.HBJJOCHGOPH = 198f;
			}
			this.INOBFNCKFGK().SetFloat("_EmissionColor", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("UseScanLineSize", this.Gain);
			this.BFGNMFCNDBC().SetVector("Inside cells:\n", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060036BB RID: 14011 RVA: 0x001196F0 File Offset: 0x001178F0
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 517f)
			{
				this.HBJJOCHGOPH = 138f;
			}
			this.BFGNMFCNDBC().SetFloat("CameraFilterPack/Vision_Blood_Fast", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("_Value", this.Gain);
			this.DBOLLHHMKKN().SetVector("_TimeX", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060036BC RID: 14012 RVA: 0x001197A8 File Offset: 0x001179A8
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 952f)
			{
				this.HBJJOCHGOPH = 1521f;
			}
			this.HHIFMIPPMPF().SetFloat("SetParticlesInput", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("_TimeX", this.Gain);
			this.EHDJJANLINB().SetVector("0,7,true,0", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060036BD RID: 14013 RVA: 0x001187EA File Offset: 0x001169EA
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060036BE RID: 14014 RVA: 0x001187EA File Offset: 0x001169EA
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060036BF RID: 14015 RVA: 0x00119860 File Offset: 0x00117A60
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 633f)
			{
				this.HBJJOCHGOPH = 1643f;
			}
			this.DBOLLHHMKKN().SetFloat("table", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("[MapsData] Unsubscribe ", this.Gain);
			this.KEMJNOMIPHN().SetVector("_Value2", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060036C0 RID: 14016 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x060036C1 RID: 14017 RVA: 0x00119916 File Offset: 0x00117B16
	private void MMPHNFPPEHO()
	{
		this.SCShader = Shader.Find("RanksButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060036C2 RID: 14018 RVA: 0x0011993A File Offset: 0x00117B3A
	private void MDNHCLKNCLE()
	{
		this.SCShader = Shader.Find("CorrectHitsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060036C3 RID: 14019 RVA: 0x0002523B File Offset: 0x0002343B
	private void IAJKLKJJKEJ()
	{
	}

	// Token: 0x060036C4 RID: 14020 RVA: 0x00119960 File Offset: 0x00117B60
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 866f)
			{
				this.HBJJOCHGOPH = 1034f;
			}
			this.BFGNMFCNDBC().SetFloat("value", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("Reconnect() disabled the offline mode. No longer offline.", this.Gain);
			this.KHCLIAMBBNC().SetVector("-showlogs", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MJJIEHANFJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060036C5 RID: 14021 RVA: 0x0011907A File Offset: 0x0011727A
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060036C6 RID: 14022 RVA: 0x001187EA File Offset: 0x001169EA
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060036C7 RID: 14023 RVA: 0x00119A16 File Offset: 0x00117C16
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("LevelURLInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060036C8 RID: 14024 RVA: 0x00119A3A File Offset: 0x00117C3A
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060036C9 RID: 14025 RVA: 0x00119A5E File Offset: 0x00117C5E
	private void ADPLHDFJFID()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060036CA RID: 14026 RVA: 0x001187EA File Offset: 0x001169EA
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060036CB RID: 14027 RVA: 0x001187EA File Offset: 0x001169EA
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060036CC RID: 14028 RVA: 0x00119A82 File Offset: 0x00117C82
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("settings.shaders");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060036CD RID: 14029 RVA: 0x001187EA File Offset: 0x001169EA
	private void HNGHDAPKEJG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060036CE RID: 14030 RVA: 0x00119AA8 File Offset: 0x00117CA8
	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1100f)
			{
				this.HBJJOCHGOPH = 846f;
			}
			this.DKNJGHFLAIF().SetFloat(". Check if the server is available.", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("#{0:00} '{1}'{2} {3}", this.Gain);
			this.HKGAONMOBMH().SetVector("_EdgeThreshold", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060036CF RID: 14031 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x060036D0 RID: 14032 RVA: 0x001187EA File Offset: 0x001169EA
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060036D1 RID: 14033 RVA: 0x00119B5E File Offset: 0x00117D5E
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060036D2 RID: 14034 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x060036D3 RID: 14035 RVA: 0x00119B98 File Offset: 0x00117D98
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1894f)
			{
				this.HBJJOCHGOPH = 1016f;
			}
			this.AELJLBOJAIL().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("Anomaly_Intensity", this.Gain);
			this.PDEAHJPOMEF().SetVector("offsets", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIBHFCLJKDB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060036D4 RID: 14036 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x060036D5 RID: 14037 RVA: 0x00119C4E File Offset: 0x00117E4E
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("pointBuffer");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060036D6 RID: 14038 RVA: 0x00119C72 File Offset: 0x00117E72
	private Material OIBHFCLJKDB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060036D7 RID: 14039 RVA: 0x001187EA File Offset: 0x001169EA
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060036D8 RID: 14040 RVA: 0x00119CA9 File Offset: 0x00117EA9
	private void IGPCNCJIEOJ()
	{
		this.SCShader = Shader.Find("Aimer Input Module is incompatible with the StandAloneInputSystem, please remove it from the Event System in this scene or disable it when this module is in use");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060036D9 RID: 14041 RVA: 0x001187EA File Offset: 0x001169EA
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060036DA RID: 14042 RVA: 0x00119CD0 File Offset: 0x00117ED0
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1792f)
			{
				this.HBJJOCHGOPH = 1606f;
			}
			this.CECJJMKLEAK().SetFloat("Joystick1Button0", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("#failed!", this.Gain);
			this.FEAEGGCNIAA().SetVector("DPADHOR", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060036DB RID: 14043 RVA: 0x00119D86 File Offset: 0x00117F86
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("[EMPTY]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060036DC RID: 14044 RVA: 0x00119DAA File Offset: 0x00117FAA
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find(". Should be just one?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060036DD RID: 14045 RVA: 0x00119DCE File Offset: 0x00117FCE
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("[LevelEditorScene] Error: I/O Failure! :(");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060036DE RID: 14046 RVA: 0x00119DF2 File Offset: 0x00117FF2
	private void EIMNPCMHJLJ()
	{
		this.SCShader = Shader.Find("Triangle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060036DF RID: 14047 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCDLIKEDMCF()
	{
	}

	// Token: 0x060036E0 RID: 14048 RVA: 0x00119E18 File Offset: 0x00118018
	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1977f)
			{
				this.HBJJOCHGOPH = 1419f;
			}
			this.HHIFMIPPMPF().SetFloat("FPSToggle", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("masterSteamID", this.Gain);
			this.KEMAALEODNH().SetVector("_Bullet_9", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIBHFCLJKDB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060036E1 RID: 14049 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x060036E2 RID: 14050 RVA: 0x00119ED0 File Offset: 0x001180D0
	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1095f)
			{
				this.HBJJOCHGOPH = 973f;
			}
			this.HKGAONMOBMH().SetFloat("maps.", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("StartButton", this.Gain);
			this.KOHGPKOFEJO().SetVector("skin.", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060036E3 RID: 14051 RVA: 0x001187EA File Offset: 0x001169EA
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060036E4 RID: 14052 RVA: 0x00119F88 File Offset: 0x00118188
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
			this.NBPKMLMCHFN.SetFloat("_Gain", this.Gain);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060036E5 RID: 14053 RVA: 0x0011A040 File Offset: 0x00118240
	private void EKCJHNJGGAB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1494f)
			{
				this.HBJJOCHGOPH = 1917f;
			}
			this.FEAEGGCNIAA().SetFloat("[SaveSystem] Init from ", this.HBJJOCHGOPH);
			this.INOBFNCKFGK().SetFloat("mapselector.lastSearch", this.Gain);
			this.ADBKPGFMNKO().SetVector("CameraFilterPack/Drawing_Manga5", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060036E6 RID: 14054 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x060036E7 RID: 14055 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x060036E8 RID: 14056 RVA: 0x0011A0F6 File Offset: 0x001182F6
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060036E9 RID: 14057 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060036EA RID: 14058 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x060036EB RID: 14059 RVA: 0x0002523B File Offset: 0x0002343B
	private void COGBDFKOHKK()
	{
	}

	// Token: 0x060036EC RID: 14060 RVA: 0x001187EA File Offset: 0x001169EA
	private void HAHJJPLPOKB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060036ED RID: 14061 RVA: 0x001187EA File Offset: 0x001169EA
	private void IABLKKAALGI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060036EE RID: 14062 RVA: 0x001187EA File Offset: 0x001169EA
	private void KMIEAGOFLBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060036EF RID: 14063 RVA: 0x0011A11A File Offset: 0x0011831A
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060036F0 RID: 14064 RVA: 0x0011A154 File Offset: 0x00118354
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 898f)
			{
				this.HBJJOCHGOPH = 571f;
			}
			this.AELJLBOJAIL().SetFloat("checkpoint", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("CameraFilterPack/Blur_Movie", this.Gain);
			this.BKKJJJGADLM().SetVector("_DepthLevel", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060036F1 RID: 14065 RVA: 0x0011A20C File Offset: 0x0011840C
	private void IJMAPHMBFJI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1667f)
			{
				this.HBJJOCHGOPH = 1388f;
			}
			this.INOBFNCKFGK().SetFloat("[Down-Left]", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("#random #epic #item", this.Gain);
			this.KHCLIAMBBNC().SetVector("[Left]", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060036F2 RID: 14066 RVA: 0x0011A2C4 File Offset: 0x001184C4
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1573f)
			{
				this.HBJJOCHGOPH = 1306f;
			}
			this.EHDJJANLINB().SetFloat("_Value", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("TimeBGSlider", this.Gain);
			this.DBOLLHHMKKN().SetVector("Print the list of scenes, avalable in game.", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060036F3 RID: 14067 RVA: 0x0011A37A File Offset: 0x0011857A
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("Failed to InstantiateSceneObject prefab: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060036F5 RID: 14069 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x060036F6 RID: 14070 RVA: 0x001187EA File Offset: 0x001169EA
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060036F7 RID: 14071 RVA: 0x0011A3BC File Offset: 0x001185BC
	private Material HHLFDHNEIAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060036F8 RID: 14072 RVA: 0x0011A3F3 File Offset: 0x001185F3
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)119;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060036F9 RID: 14073 RVA: 0x001187EA File Offset: 0x001169EA
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060036FA RID: 14074 RVA: 0x0011A42C File Offset: 0x0011862C
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 731f)
			{
				this.HBJJOCHGOPH = 1435f;
			}
			this.EHDJJANLINB().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("_Amount", this.Gain);
			this.HHIFMIPPMPF().SetVector("settings.shaders.bloomintencity", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060036FB RID: 14075 RVA: 0x0011A4E4 File Offset: 0x001186E4
	private void FIKNBPAIFBI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 294f)
			{
				this.HBJJOCHGOPH = 1202f;
			}
			this.BFGNMFCNDBC().SetFloat("_Offsets", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat(" .", this.Gain);
			this.NBPKMLMCHFN.SetVector("#exit", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060036FC RID: 14076 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x060036FD RID: 14077 RVA: 0x0011A59C File Offset: 0x0011879C
	private void KPOCGNOKNOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 693f)
			{
				this.HBJJOCHGOPH = 1918f;
			}
			this.KOHGPKOFEJO().SetFloat("maps.", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("). ", this.Gain);
			this.PDEAHJPOMEF().SetVector("menu.selectedplaymode", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x04000602 RID: 1538
	public Shader SCShader;

	// Token: 0x04000603 RID: 1539
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000604 RID: 1540
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000605 RID: 1541
	private Material BJFKDHHMLJH;

	// Token: 0x04000606 RID: 1542
	[Range(1f, 10f)]
	public float Gain = 3f;
}
